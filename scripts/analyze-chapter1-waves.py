#!/usr/bin/env python3
"""Compress chapter-1 Waterfall mission instructions into a 15-wave rhythm summary.

Usage:
  python scripts/analyze-chapter1-waves.py
  python scripts/analyze-chapter1-waves.py --json research/battle/chapter1-wave-summary.json

Only Python stdlib is required.
"""
from __future__ import annotations

import argparse
import json
from collections import Counter
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
TABLES = ROOT / "restored" / "configs" / "tables"

def load(name: str):
    return json.loads((TABLES / name).read_text(encoding="utf-8"))

def fp(v):
    return v.get("decimal", 0) if isinstance(v, dict) else (v or 0)

def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--json", type=Path, help="optional output JSON path")
    args = ap.parse_args()

    missions = load("MissionWaterfallMission_WaterfallMission.json")
    groups = load("Mission_PositionGroupMonsterFlushConfig.json")
    randoms = load("Mission_RandomMonsterFlushConfig.json")
    waves_cfg = load("ChapterWave_Waves.json")
    chars = load("Character_entity.json")

    rows = [x for x in missions if 1001001 <= x["id"] <= 1001078]
    group_map = {
        x["id"]: json.loads(x["flushPool"]) if isinstance(x["flushPool"], str) else x["flushPool"]
        for x in groups
    }
    random_map = {x["id"]: x for x in randoms}
    char_map = {x["ID"]: x for x in chars}

    out = {"chapter": 1, "instructionCount": len(rows), "waves": []}

    for wave in range(1, 16):
        wr = [x for x in rows if x.get("wave") == wave]
        counts = Counter()
        events = []

        for x in wr:
            base = fp(x.get("time"))
            delay = fp(x.get("delayTime"))
            if x.get("missinType"):
                events.append({"time": base, "kind": "mission_event",
                               "missionId": x["id"], "missionType": x["missinType"]})

            local = Counter(x.get("Monster") or [])
            for rid in x.get("randomMonster") or []:
                r = random_map.get(rid)
                if r:
                    for entity_id in r.get("entityId") or []:
                        local[entity_id] += x.get("numberRandom") or 0
            if local:
                counts.update(local)
                events.append({"time": base + delay, "kind": "spawn",
                               "source": "direct_or_random", "missionId": x["id"],
                               "monsters": dict(local)})

            for gid in x.get("positionGroupMonster") or []:
                for item in group_map.get(gid, []):
                    local = Counter(item.get("Monster") or [])
                    counts.update(local)
                    events.append({"time": base + (item.get("Delay") or 0), "kind": "spawn",
                                   "source": f"position_group:{gid}", "missionId": x["id"],
                                   "monsters": dict(local)})

        events.sort(key=lambda e: e["time"])
        spawn_times = sorted({e["time"] for e in events if e["kind"] == "spawn"})
        cfg = next((x for x in waves_cfg if x.get("id") == 100100 + wave), {})
        start = min(fp(x["time"]) for x in wr)
        next_rows = [x for x in rows if x.get("wave") == wave + 1]
        next_start = min((fp(x["time"]) for x in next_rows), default=None)

        monsters = []
        for entity_id, count in sorted(counts.items()):
            c = char_map.get(entity_id, {})
            monsters.append({
                "id": entity_id, "count": count,
                "type": c.get("Type"), "showHpType": c.get("ShowHpType"),
                "hp": fp(c.get("HP")), "attack": fp(c.get("Attack")),
                "exp": c.get("exp"), "monsterDropType": c.get("MonsterDropType"),
            })

        out["waves"].append({
            "wave": wave, "startTime": start, "nextWaveStartTime": next_start,
            "nominalDuration": None if next_start is None else next_start - start,
            "lastSpawnTime": max((e["time"] for e in events if e["kind"] == "spawn"), default=None),
            "spawnBatchCount": len(spawn_times), "rowCount": len(wr),
            "stopByEliteOrBossKilled": cfg.get("StopByEliteOrBossKilled"),
            "waveAllExp": cfg.get("WaveAllExp"),
            "waveStartSpecialUIType": cfg.get("WaveStartSpecialUIType", []),
            "waveEndSpecialUIType": cfg.get("WaveEndSpecialUIType", []),
            "monsters": monsters, "events": events,
        })

    print("|波|开始|下一波|名义时长|批次|总怪数|硬门槛|经验|")
    print("|---:|---:|---:|---:|---:|---:|---:|---:|")
    for w in out["waves"]:
        total = sum(x["count"] for x in w["monsters"])
        print(f'|{w["wave"]}|{w["startTime"]}|{w["nextWaveStartTime"] or "-"}|'
              f'{w["nominalDuration"] or "-"}|{w["spawnBatchCount"]}|{total}|'
              f'{w["stopByEliteOrBossKilled"]}|{w["waveAllExp"]}|')

    if args.json:
        path = args.json if args.json.is_absolute() else ROOT / args.json
        path.parent.mkdir(parents=True, exist_ok=True)
        path.write_text(json.dumps(out, ensure_ascii=False, indent=2), encoding="utf-8")
        print(f"wrote {path.relative_to(ROOT)}")

if __name__ == "__main__":
    main()
