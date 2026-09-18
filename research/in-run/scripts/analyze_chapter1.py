#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""Reproduce the chapter-1 Waterfall wave/EXP summary from restored configs.

Run from repository root:
    python research/in-run/scripts/analyze_chapter1.py

The script intentionally reports refresh-script structure rather than pretending
that every mission row equals one spawned entity. Position/random templates can
fan out into multiple entities.
"""
from __future__ import annotations

import json
from collections import Counter, defaultdict
from pathlib import Path

ROOT = Path(__file__).resolve().parents[3]
TABLES = ROOT / "restored" / "configs" / "tables"


def load(name: str):
    with (TABLES / name).open("r", encoding="utf-8") as f:
        return json.load(f)


def fp(v):
    if isinstance(v, dict):
        return v.get("runtime_value", v.get("decimal", 0))
    return v or 0


def main():
    chapter_waves = {
        x["id"]: x
        for x in load("ChapterWave_Waves.json")
        if 100101 <= x["id"] <= 100115
    }
    exp_rows = load("Exp_exp.json")
    missions = [
        x
        for x in load("MissionWaterfallMission_WaterfallMission.json")
        if 1001000 <= x["id"] < 1002000
    ]
    position_groups = {
        x["id"]: x for x in load("Mission_PositionGroupMonsterFlushConfig.json")
    }

    by_wave = defaultdict(list)
    for row in missions:
        by_wave[row["wave"]].append(row)

    cumulative = 0
    print("# Chapter 1 wave summary")
    print()
    print("|wave|start(s)|mission rows|WaveAllExp|cum exp|Exp_exp threshold|gate|direct refreshes|position groups|random groups|")
    print("|---:|---|---:|---:|---:|---:|:---:|---|---|---|")

    for wave in range(1, 16):
        cfg = chapter_waves[100100 + wave]
        rows = by_wave[wave]
        budget = cfg["WaveAllExp"]
        cumulative += budget
        threshold = exp_rows[wave - 1]["waveExp"]

        starts = sorted({round(fp(r.get("time")), 3) for r in rows})
        direct = Counter()
        groups = set()
        random_groups = set()

        for row in rows:
            direct.update(row.get("Monster") or [])
            groups.update(row.get("positionGroupMonster") or [])
            random_groups.update(row.get("randomMonster") or [])

        direct_s = ",".join(f"{k}×{v}" for k, v in sorted(direct.items())) or "-"
        group_s = ",".join(map(str, sorted(groups))) or "-"
        random_s = ",".join(map(str, sorted(random_groups))) or "-"

        print(
            f"|{wave}|{','.join(map(str, starts))}|{len(rows)}|{budget}|{cumulative}|"
            f"{threshold}|{'Y' if cfg['StopByEliteOrBossKilled'] else 'N'}|"
            f"{direct_s}|{group_s}|{random_s}|"
        )

    print()
    print("## Position-group expansion used by chapter 1")
    chapter_group_ids = sorted(
        {
            gid
            for rows in by_wave.values()
            for row in rows
            for gid in (row.get("positionGroupMonster") or [])
        }
    )
    for gid in chapter_group_ids:
        group = position_groups.get(gid)
        if not group:
            continue
        try:
            pool = json.loads(group["flushPool"])
        except (TypeError, json.JSONDecodeError):
            continue
        monsters = Counter()
        max_delay = 0.0
        for item in pool:
            monsters.update(item.get("Monster") or [])
            max_delay = max(max_delay, float(item.get("Delay") or 0))
        print(
            f"- {gid}: entries={len(pool)}, maxDelay={max_delay:g}s, "
            + ", ".join(f"{k}×{v}" for k, v in sorted(monsters.items()))
        )

    print()
    ok = all(
        sum(chapter_waves[100100 + i]["WaveAllExp"] for i in range(1, wave + 1))
        == exp_rows[wave - 1]["waveExp"]
        for wave in range(1, 16)
    )
    print(f"EXP cumulative thresholds match all 15 waves: {ok}")


if __name__ == "__main__":
    main()
