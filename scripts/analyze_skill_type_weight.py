#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""Summarize the designed same-SkillType dynamic weight curve.

This script only reproduces the configuration/native formula:
    delta = min(current_count * AddWeightPerSkill / 100, AddWeightMax / 100)
    practical_multiplier = 1 + delta

It intentionally does NOT claim that the mechanism is active in the APK baseline.
The 1.0.16 fallback implementation of AdjustWeightsForSkillGroup is empty; see:
    evidence/skill-dynamic-weight.md
"""

from __future__ import annotations

import argparse
import json
from collections import Counter
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
TABLE = ROOT / "restored" / "configs" / "tables" / "Skill_SkillTypeWeight.json"


def load_rows():
    with TABLE.open("r", encoding="utf-8") as f:
        rows = json.load(f)
    return [
        row for row in rows
        if int(row.get("id", 0)) != 0
    ]


def curve(per_skill: int, cap: int, max_count: int):
    result = []
    for count in range(max_count + 1):
        percent = min(count * per_skill, cap)
        delta = percent / 100.0
        result.append({
            "learnedCount": count,
            "deltaPercent": percent,
            "delta": delta,
            "practicalWeightMultiplier": 1.0 + delta,
        })
    return result


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--max-count", type=int, default=12)
    parser.add_argument("--json", action="store_true")
    args = parser.parse_args()

    rows = load_rows()
    configs = Counter(
        (int(r["AddWeightPerSkill"]), int(r["AddWeightMax"]))
        for r in rows
    )

    if not configs:
        raise RuntimeError("No effective Skill_SkillTypeWeight rows found")

    (per_skill, cap), frequency = configs.most_common(1)[0]
    result = {
        "source": str(TABLE.relative_to(ROOT)),
        "effectiveSkillTypeRows": len(rows),
        "dominantConfig": {
            "AddWeightPerSkill": per_skill,
            "AddWeightMax": cap,
            "rowCount": frequency,
        },
        "nativeInterpretation": {
            "formula": "targetDelta = min(currentLearnedCount * AddWeightPerSkill / 100, AddWeightMax / 100)",
            "practicalWeight": "BaseWeight * (1 + targetDelta)",
            "semantics": "absolute target recomputed from current same-type learned count",
            "apkBaselineApplication": "unproven: AdjustWeightsForSkillGroup fallback is empty in client 1.0.16",
        },
        "curve": curve(per_skill, cap, args.max_count),
    }

    if args.json:
        print(json.dumps(result, ensure_ascii=False, indent=2))
        return

    print(f"Effective SkillType rows: {len(rows)}")
    print(f"Dominant config: +{per_skill}% per learned skill, cap +{cap}%")
    print()
    print("| 同类型已学数量 | 目标增权 | 实际权重倍率 |")
    print("|---:|---:|---:|")
    for row in result["curve"]:
        print(
            f'| {row["learnedCount"]} | '
            f'+{row["deltaPercent"]}% | '
            f'×{row["practicalWeightMultiplier"]:.1f} |'
        )
    print()
    print("NOTE: formula/design is proven; APK baseline application is not.")


if __name__ == "__main__":
    main()
