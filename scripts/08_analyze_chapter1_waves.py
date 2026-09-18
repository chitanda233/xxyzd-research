#!/usr/bin/env python3
"""Flatten Chapter 1 waterfall mission rows into a planner-readable 15-wave table.

Run from repository root:
    python scripts/08_analyze_chapter1_waves.py
"""
from __future__ import annotations

import json
from collections import Counter
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
TABLES = ROOT / "restored" / "configs" / "tables"


def load(name: str):
    return json.loads((TABLES / name).read_text(encoding="utf-8"))


def dec(v) -> float:
    if isinstance(v, dict):
        return float(v.get("decimal", 0))
    return float(v or 0)


def main() -> None:
    chapters = load("Chapter_MainChapter.json")
    waves = load("ChapterWave_Waves.json")
    missions = load("MissionWaterfallMission_WaterfallMission.json")
    groups = load("Mission_PositionGroupMonsterFlushConfig.json")
    random_cfg = load("Mission_RandomMonsterFlushConfig.json")
    exp_rows = load("Exp_exp.json")

    chapter = next(row for row in chapters if row["id"] == 1)
    mission_prefix = chapter["missionIdPrev"]  # 1001 for Chapter 1
    wave_base = chapter["waveId"]              # 100100 for Chapter 1

    chapter_missions = [m for m in missions if m["id"] // 1000 == mission_prefix]
    if len(chapter_missions) != 78:
        raise RuntimeError(f"Expected 78 Chapter-1 mission rows, got {len(chapter_missions)}")

    group_map = {g["id"]: json.loads(g["flushPool"]) for g in groups}
    random_map = {r["id"]: r.get("entityId", []) for r in random_cfg}
    wave_map = {w["id"]: w for w in waves}

    print("|波|开始|下一波|窗口|固定怪|随机怪|总量|最后刷出|EXP|硬门槛|固定组合|")
    print("|---:|---:|---:|---:|---:|---:|---:|---:|---:|:---:|---|")

    wave_exp = []
    for wave_no in range(1, chapter["waveNum"] + 1):
        rows = [m for m in chapter_missions if m["wave"] == wave_no]
        if not rows:
            raise RuntimeError(f"Missing wave {wave_no}")

        start = min(dec(m["time"]) for m in rows)
        next_rows = [m for m in chapter_missions if m["wave"] == wave_no + 1]
        next_start = min((dec(m["time"]) for m in next_rows), default=None)

        fixed = Counter()
        fixed_count = 0
        random_min = 0
        random_max = 0
        latest = start

        for m in rows:
            base = dec(m["time"])
            delay = dec(m["delayTime"])
            latest = max(latest, base + delay)

            # missionType 9 is an event/control row, not a monster row.
            if m.get("missinType") == 9:
                continue

            for entity_id in m.get("Monster", []):
                fixed[entity_id] += 1
                fixed_count += 1

            for group_id in m.get("positionGroupMonster", []):
                for entry in group_map.get(group_id, []):
                    latest = max(latest, base + float(entry.get("Delay", 0)))
                    for entity_id in entry.get("Monster", []):
                        fixed[entity_id] += 1
                        fixed_count += 1

            candidates = m.get("randomMonster", [])
            picks = int(m.get("numberRandom", 0))
            if candidates and picks > 0:
                sizes = [len(random_map[cfg_id]) for cfg_id in candidates]
                random_min += min(sizes) * picks
                random_max += max(sizes) * picks

        wcfg = wave_map[wave_base + wave_no]
        wave_exp.append(wcfg["WaveAllExp"])
        total_min = fixed_count + random_min
        total_max = fixed_count + random_max
        random_text = str(random_min) if random_min == random_max else f"{random_min}~{random_max}"
        total_text = str(total_min) if total_min == total_max else f"{total_min}~{total_max}"
        next_text = "-" if next_start is None else f"{next_start:g}s"
        window_text = "-" if next_start is None else f"{next_start - start:g}s"
        comp = ", ".join(f"{eid}×{cnt}" for eid, cnt in sorted(fixed.items()))

        print(
            f"|{wave_no}|{start:g}s|{next_text}|{window_text}|{fixed_count}|"
            f"{random_text}|{total_text}|{latest:g}s|{wcfg['WaveAllExp']}|"
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
