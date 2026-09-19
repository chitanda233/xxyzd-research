#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""Compress chapter-1 Waterfall mission rows into a 15-wave planning summary.

Run from repository root:
    python scripts/analyze_chapter1_waves.py
"""
from __future__ import annotations
import json
from collections import Counter
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
TABLES = ROOT / "restored" / "configs" / "tables"

def load(name: str):
    return json.loads((TABLES / name).read_text(encoding="utf-8"))

def fp(v):
    if isinstance(v, dict):
        return v.get("decimal", 0)
    return v or 0

missions = load("MissionWaterfallMission_WaterfallMission.json")
groups = load("Mission_PositionGroupMonsterFlushConfig.json")
randoms = load("Mission_RandomMonsterFlushConfig.json")
waves_cfg = load("ChapterWave_Waves.json")

chapter = [x for x in missions if 1001001 <= x["id"] <= 1001078]
group_map = {x["id"]: json.loads(x["flushPool"]) for x in groups}
random_map = {x["id"]: x for x in randoms}
wave_cfg_map = {x["id"]: x for x in waves_cfg}

def add(counter, monster_id, n=1):
    if monster_id is not None:
        counter[monster_id] += n

def summarize(wave_no: int):
    rows = [x for x in chapter if x.get("wave") == wave_no]
    events = []
    counts = Counter()

    for row in rows:
        base = fp(row.get("time"))
        delay = fp(row.get("delayTime"))
        if row.get("missinType"):
            events.append((base, "event", str(row["missinType"])))

        direct = Counter()
        for mid in row.get("Monster", []):
            add(direct, mid); add(counts, mid)
        for rid in row.get("randomMonster", []):
            rr = random_map.get(rid)
            if rr:
                for mid in rr.get("entityId", []):
                    n = row.get("numberRandom", 0)
                    add(direct, mid, n); add(counts, mid, n)
        if direct:
            events.append((base + delay, "spawn", dict(direct)))

        for gid in row.get("positionGroupMonster", []):
            for e in group_map.get(gid, []):
                c = Counter()
                for mid in e.get("Monster", []):
                    add(c, mid); add(counts, mid)
                events.append((base + e.get("Delay", 0), "spawn", dict(c)))

    events.sort(key=lambda x: x[0])
    cfg = wave_cfg_map.get(100100 + wave_no, {})
    start = min(fp(x.get("time")) for x in rows)
    next_rows = [x for x in chapter if x.get("wave") == wave_no + 1]
    next_start = min((fp(x.get("time")) for x in next_rows), default=None)
    return {
        "wave": wave_no,
        "start": start,
        "next_start": next_start,
        "nominal_window": None if next_start is None else next_start - start,
        "StopByEliteOrBossKilled": cfg.get("StopByEliteOrBossKilled"),
        "WaveAllExp": cfg.get("WaveAllExp"),
        "WaveStartSpecialUIType": cfg.get("WaveStartSpecialUIType"),
        "WaveEndSpecialUIType": cfg.get("WaveEndSpecialUIType"),
        "mission_rows": len(rows),
        "monster_counts": dict(counts),
        "events": events,
    }

if __name__ == "__main__":
    result = [summarize(i) for i in range(1, 16)]
    print(json.dumps(result, ensure_ascii=False, indent=2))
