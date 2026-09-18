#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Reconstruct Chapter 1 wave pacing from decoded client tables.

This script intentionally separates:
- deterministic spawn instructions;
- random spawns whose exact composition can be proven from the referenced pools;
- wave timing / kill-gate metadata;
- experience budget alignment.

It does not simulate runtime hotfixes or server-side changes.
"""

from __future__ import annotations

import argparse
import json
from collections import Counter, defaultdict
from pathlib import Path
from typing import Any


ROOT = Path(__file__).resolve().parents[1]
TABLES = ROOT / "restored" / "configs" / "tables"

MISSION_PATH = TABLES / "MissionWaterfallMission_WaterfallMission.json"
WAVE_PATH = TABLES / "ChapterWave_Waves.json"
GROUP_PATH = TABLES / "Mission_PositionGroupMonsterFlushConfig.json"
RANDOM_PATH = TABLES / "Mission_RandomMonsterFlushConfig.json"
EXP_PATH = TABLES / "Exp_exp.json"
CHARACTER_PATH = TABLES / "Character_entity.json"


def load_json(path: Path) -> list[dict[str, Any]]:
    with path.open("r", encoding="utf-8") as f:
        return json.load(f)


def decimal(value: Any) -> float:
    if isinstance(value, dict):
        return float(value.get("decimal", value.get("runtime_value", 0)))
    if value is None:
        return 0.0
    return float(value)


def parse_flush_pool(value: Any) -> list[dict[str, Any]]:
    if not value:
        return []
    if isinstance(value, str):
        return json.loads(value)
    return value


def exact_random_entities(
    row: dict[str, Any],
    random_by_id: dict[int, dict[str, Any]],
) -> tuple[Counter[int], bool, set[int]]:
    """Resolve exact random composition when every referenced pool can only yield one entity type.

    WaterfallBattleManager.CalRandomMonster fills until numberRandom is reached.
    If all candidate entity IDs collapse to one unique monster ID, composition is exact
    even though the pool selection itself is random.
    """
    target = int(row.get("numberRandom", 0) or 0)
    pool_ids = row.get("randomMonster") or []
    candidates: set[int] = set()

    for pool_id in pool_ids:
        cfg = random_by_id.get(int(pool_id))
        if not cfg:
            continue
        candidates.update(int(x) for x in (cfg.get("entityId") or []))

    if target <= 0:
        return Counter(), True, candidates

    if len(candidates) == 1:
        entity_id = next(iter(candidates))
        return Counter({entity_id: target}), True, candidates

    return Counter(), False, candidates


def reconstruct() -> dict[str, Any]:
    missions = load_json(MISSION_PATH)
    waves = load_json(WAVE_PATH)
    groups = load_json(GROUP_PATH)
    random_cfg = load_json(RANDOM_PATH)
    exps = load_json(EXP_PATH)
    characters = load_json(CHARACTER_PATH)

    chapter_rows = [
        x for x in missions
        if 1001001 <= int(x["id"]) <= 1001078
    ]
    group_by_id = {int(x["id"]): x for x in groups}
    random_by_id = {int(x["id"]): x for x in random_cfg}
    wave_by_id = {int(x["id"]): x for x in waves}
    character_by_id = {int(x["ID"]): x for x in characters}

    result_waves: list[dict[str, Any]] = []

    for wave_no in range(1, 16):
        rows = [x for x in chapter_rows if int(x["wave"]) == wave_no]
        if not rows:
            raise RuntimeError(f"Missing wave {wave_no}")

        start = min(decimal(x["time"]) for x in rows)
        next_rows = [x for x in chapter_rows if int(x["wave"]) == wave_no + 1]
        next_start = min((decimal(x["time"]) for x in next_rows), default=None)

        events: dict[float, Counter[int]] = defaultdict(Counter)
        event_sources: dict[float, list[str]] = defaultdict(list)
        unresolved_random: list[dict[str, Any]] = []
        mission_events: list[dict[str, Any]] = []

        for row in rows:
            base = decimal(row.get("time")) + decimal(row.get("delayTime"))
            mission_type = int(row.get("missinType", 0) or 0)
            if mission_type:
                mission_events.append({
                    "at": round(base, 3),
                    "relative": round(base - start, 3),
                    "missionType": mission_type,
                    "rowId": int(row["id"]),
                })

            for group_id in row.get("positionGroupMonster") or []:
                group = group_by_id.get(int(group_id))
                if not group:
                    continue
                for flush in parse_flush_pool(group.get("flushPool")):
                    at = base + float(flush.get("Delay", 0) or 0)
                    for monster_id in flush.get("Monster") or []:
                        events[at][int(monster_id)] += 1
                    event_sources[at].append(f"group:{group_id}")

            for monster_id in row.get("Monster") or []:
                events[base][int(monster_id)] += 1
                event_sources[base].append(f"direct:{row['id']}")

            random_counts, exact, candidates = exact_random_entities(row, random_by_id)
            if row.get("randomMonster") and int(row.get("numberRandom", 0) or 0) > 0:
                if exact:
                    events[base].update(random_counts)
                    event_sources[base].append(
                        f"random-target:{row.get('numberRandom')} pools={row.get('randomMonster')}"
                    )
                else:
                    unresolved_random.append({
                        "rowId": int(row["id"]),
                        "at": round(base, 3),
                        "target": int(row.get("numberRandom", 0) or 0),
                        "pools": row.get("randomMonster"),
                        "candidateEntities": sorted(candidates),
                    })

        timeline = []
        composition: Counter[int] = Counter()
        for at in sorted(events):
            composition.update(events[at])
            timeline.append({
                "at": round(at, 3),
                "relative": round(at - start, 3),
                "composition": dict(sorted(events[at].items())),
                "sources": event_sources[at],
            })

        wave_cfg = wave_by_id.get(100100 + wave_no, {})
        monster_meta = {}
        for monster_id in sorted(composition):
            c = character_by_id.get(monster_id, {})
            monster_meta[str(monster_id)] = {
                "type": c.get("Type"),
                "hp": decimal(c.get("HP")),
                "exp": c.get("exp"),
                "expWeight": c.get("expWeight"),
                "monsterDropType": c.get("MonsterDropType"),
            }

        special_monsters = []
        for monster_id, count in sorted(composition.items()):
            monster_type = character_by_id.get(monster_id, {}).get("Type")
            if monster_type in (201, 3):
                special_monsters.append({
                    "entityId": monster_id,
                    "type": monster_type,
                    "count": count,
                })

        result_waves.append({
            "wave": wave_no,
            "start": start,
            "combatStart": timeline[0]["at"] if timeline else None,
            "lastConfiguredSpawn": timeline[-1]["at"] if timeline else None,
            "nextStart": next_start,
            "nominalDuration": None if next_start is None else round(next_start - start, 3),
            "stopByEliteOrBossKilled": int(wave_cfg.get("StopByEliteOrBossKilled", 0) or 0),
            "waveAllExp": int(wave_cfg.get("WaveAllExp", 0) or 0),
            "waveStartSpecialUIType": wave_cfg.get("WaveStartSpecialUIType") or [],
            "waveEndSpecialUIType": wave_cfg.get("WaveEndSpecialUIType") or [],
            "rawMissionRows": len(rows),
            "spawnMoments": len(timeline),
            "totalMonsterCount": sum(composition.values()),
            "composition": dict(sorted(composition.items())),
            "specialMonsters": special_monsters,
            "monsterMeta": monster_meta,
            "timeline": timeline,
            "missionEvents": mission_events,
            "unresolvedRandom": unresolved_random,
        })

    wave_exp = [int(x["waveAllExp"]) for x in result_waves]
    thresholds = [int(x["waveExp"]) for x in exps[:15]]
    deltas = [thresholds[0]] + [
        thresholds[i] - thresholds[i - 1]
        for i in range(1, len(thresholds))
    ]

    return {
        "source": {
            "client": "1.0.16",
            "versionCode": 40,
            "chapterMissionIdRange": [1001001, 1001078],
            "missionRowCount": len(chapter_rows),
        },
        "timelineToBossSpawnSeconds": 347,
        "notes": [
            "CalRandomMonster native shows numberRandom is the target emitted entity count.",
            "Chapter 1 random configs referenced here collapse to entity 330006, so random composition is exact.",
            "totalMonsterCount is the configured maximum. On StopByEliteOrBossKilled waves, special-monster death can clear queued CreateMonsterData, so realized spawns can be lower.",
            "nominalDuration is a configured scheduling window. Wave 10 and Wave 15 additionally have special-monster kill gates.",
        ],
        "waves": result_waves,
        "experience": {
            "waveAllExp": wave_exp,
            "cumulativeWaveExpThresholds": thresholds,
            "thresholdDeltas": deltas,
            "exactMatch": wave_exp == deltas,
        },
    }


def print_markdown(data: dict[str, Any]) -> None:
    print("| 波 | 开始 | 名义窗口 | 怪数 | 组合 | Stop | 经验 |")
    print("|---:|---:|---:|---:|---|---:|---:|")
    for w in data["waves"]:
        comp = "，".join(f"{mid}×{count}" for mid, count in w["composition"].items())
        duration = "-" if w["nominalDuration"] is None else f'{w["nominalDuration"]:g}s'
        print(
            f'| {w["wave"]} | {w["start"]:g}s | {duration} | '
            f'{w["totalMonsterCount"]} | {comp} | '
            f'{w["stopByEliteOrBossKilled"]} | {w["waveAllExp"]} |'
        )

    exp = data["experience"]
    print()
    print("WaveAllExp:", exp["waveAllExp"])
    print("Threshold deltas:", exp["thresholdDeltas"])
    print("Exact match:", exp["exactMatch"])


def main() -> None:
    parser = argparse.ArgumentParser()
    parser.add_argument(
        "--json",
        action="store_true",
        help="Print the full reconstructed result as JSON.",
    )
    parser.add_argument(
        "--write-json",
        type=Path,
        help="Write the full reconstructed result to a JSON file.",
    )
    args = parser.parse_args()

    data = reconstruct()

    if args.write_json:
        out = args.write_json
        if not out.is_absolute():
            out = ROOT / out
        out.parent.mkdir(parents=True, exist_ok=True)
        out.write_text(
            json.dumps(data, ensure_ascii=False, indent=2),
            encoding="utf-8",
        )

    if args.json:
        print(json.dumps(data, ensure_ascii=False, indent=2))
    else:
        print_markdown(data)


if __name__ == "__main__":
    main()
