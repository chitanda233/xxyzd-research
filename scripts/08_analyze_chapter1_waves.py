#!/usr/bin/env python3
"""Flatten Chapter 1 waterfall missions into a planner-readable 15-wave table.

Run from repository root:
    python scripts/08_analyze_chapter1_waves.py

Important native rule:
Mission.numberRandom is the TARGET MONSTER COUNT of that random-spawn
instruction. CalRandomMonster repeatedly chooses a random config and expands
its entityId list, but stops/truncates as soon as that target count is reached.
"""
from __future__ import annotations

import json
from collections import Counter
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
TABLES = ROOT / "restored" / "configs" / "tables"


def load(name: str):
    return json.loads((TABLES / name).read_text(encoding="utf-8"))


def dec(value) -> float:
    if isinstance(value, dict):
        return float(value.get("decimal", 0))
    return float(value or 0)


def random_entity_set(candidate_ids, random_map):
    """Return all entity IDs that can appear from these candidate configs."""
    result = set()
    for cfg_id in candidate_ids:
        result.update(random_map.get(cfg_id, []))
    return result


def main() -> None:
    chapters = load("Chapter_MainChapter.json")
    waves = load("ChapterWave_Waves.json")
    missions = load("MissionWaterfallMission_WaterfallMission.json")
    groups = load("Mission_PositionGroupMonsterFlushConfig.json")
    random_cfg = load("Mission_RandomMonsterFlushConfig.json")
    exp_rows = load("Exp_exp.json")

    chapter = next(row for row in chapters if row["id"] == 1)
    mission_prefix = chapter["missionIdPrev"]  # 1001
    wave_base = chapter["waveId"]              # 100100

    chapter_missions = [m for m in missions if m["id"] // 1000 == mission_prefix]
    if len(chapter_missions) != 78:
        raise RuntimeError(
            f"Expected 78 Chapter-1 mission rows, got {len(chapter_missions)}"
        )

    group_map = {g["id"]: json.loads(g["flushPool"]) for g in groups}
    random_map = {r["id"]: r.get("entityId", []) for r in random_cfg}
    wave_map = {w["id"]: w for w in waves}

    print("|波|开始|下一波|窗口|怪量|最后刷出|EXP|硬门槛|组合|")
    print("|---:|---:|---:|---:|---:|---:|---:|:---:|---|")

    wave_exp = []

    for wave_no in range(1, chapter["waveNum"] + 1):
        rows = [m for m in chapter_missions if m["wave"] == wave_no]
        if not rows:
            raise RuntimeError(f"Missing wave {wave_no}")

        start = min(dec(m["time"]) for m in rows)
        next_rows = [m for m in chapter_missions if m["wave"] == wave_no + 1]
        next_start = min((dec(m["time"]) for m in next_rows), default=None)

        composition = Counter()
        unknown_random = []
        total_count = 0
        latest = start

        for m in rows:
            base = dec(m["time"])
            delay = dec(m["delayTime"])
            latest = max(latest, base + delay)

            # missionType 9 is an event/control row, not a monster spawn.
            if m.get("missinType") == 9:
                continue

            for entity_id in m.get("Monster", []):
                composition[entity_id] += 1
                total_count += 1

            for group_id in m.get("positionGroupMonster", []):
                for entry in group_map.get(group_id, []):
                    latest = max(latest, base + float(entry.get("Delay", 0)))
                    for entity_id in entry.get("Monster", []):
                        composition[entity_id] += 1
                        total_count += 1

            candidates = m.get("randomMonster", [])
            target = int(m.get("numberRandom", 0))
            if candidates and target > 0:
                # Native CalRandomMonster guarantees exactly target entities
                # (assuming valid configs); it can truncate a selected config.
                total_count += target

                possible_entities = random_entity_set(candidates, random_map)
                if len(possible_entities) == 1:
                    # Chapter 1 pools 2/5/13 all resolve only to 330006,
                    # so the random composition is also exact.
                    composition[next(iter(possible_entities))] += target
                else:
                    unknown_random.append(
                        f"{target} random from cfg {','.join(map(str, candidates))}"
                    )

        wcfg = wave_map[wave_base + wave_no]
        wave_exp.append(wcfg["WaveAllExp"])

        next_text = "-" if next_start is None else f"{next_start:g}s"
        window_text = "-" if next_start is None else f"{next_start - start:g}s"
        comp = ", ".join(f"{eid}×{cnt}" for eid, cnt in sorted(composition.items()))
        if unknown_random:
            comp += ("; " if comp else "") + "; ".join(unknown_random)

        print(
            f"|{wave_no}|{start:g}s|{next_text}|{window_text}|{total_count}|"
            f"{latest:g}s|{wcfg['WaveAllExp']}|"
            f"{wcfg['StopByEliteOrBossKilled']}|{comp}|"
        )

    thresholds = [row["waveExp"] for row in exp_rows[: len(wave_exp)]]
    deltas = [thresholds[0]] + [b - a for a, b in zip(thresholds, thresholds[1:])]

    print()
    print("WaveAllExp:", wave_exp)
    print("Threshold deltas:", deltas)
    print("Exact one-wave/one-level match:", wave_exp == deltas)
    print("WaitUpLevel:", chapter["WaitUpLevel"])


if __name__ == "__main__":
    main()
