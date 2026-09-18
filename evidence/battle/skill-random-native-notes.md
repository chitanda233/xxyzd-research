# Skill random / dynamic weight native evidence notes

Purpose: preserve the minimum native evidence for `research/battle/skill-random-analysis.md`.

## Skill-type grouping and learned-count tracking

Source: `restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm`.

- `GroupSkillsByType` — RVA **0x686BEAC**.
  - Builds per-type skill collections used by `HeroComponentRandomSkill`.
- `UpdateLearnedSkillCount` — RVA **0x686AEF4**.
  - Increments the learned count for the supplied type in the per-type dictionary.
- `AddSkill` — RVA **0x6869018**.
  - Calls `UpdateLearnedSkillCount`.
  - Later calls `GetDeltaWeightPercent`, then `AdjustWeightsForSkillGroup`.
- `RemoveSkillInSTG` — RVA **0x68691F0**.
  - Has the corresponding recomputation / adjustment path after skill removal.

## Intended type-weight formula

- `GetDeltaWeightPercent` — RVA **0x6869E9C**.
  - Calls `LocalModelManager.GetSkill_SkillTypeWeight(skillType)`.
  - Calls `GetSkillCountByType`.
  - Reads `AddWeightPerSkill` and `AddWeightMax`.
  - Converts the integer-percent configuration to FP, multiplies by learned count, and returns the smaller value after cap comparison.

For the active config rows:
- `AddWeightPerSkill = 50` → FP 0.5.
- `AddWeightMax = 500` → FP 5.0.

So the intended delta is:

`min(learnedSkillCountForType × 0.5, 5.0)`.

## Critical finding: APK fallback does not apply the group delta

- `AdjustWeightsForSkillGroup` — RVA **0x686A17C**.

The native function first checks the normal hotfix/dispatch metadata. In the non-hotfixed fallback path, the implementation immediately restores registers and returns. It does **not**:
- read `_skillGroupsByType`;
- enumerate a type's skill IDs;
- access a `WeightRandom`;
- call `WeightRandom.UpdateWeightPercent`.

Only the hotfix-dispatch branch jumps to an externally supplied implementation.

Therefore the static APK proves the design intent and formula, but **not active type-weight adjustment in the fallback implementation**.

## The lower-level weight engine is real and active-capable

Source: `restored/code/native-evidence/HotFix.BattleLogic.WeightRandom.asm`.

- `UpdateWeightPercent` — RVA **0x66327C4**.
  - Iterates candidate data and updates the percentage field for IDs included in the supplied skill-ID array.
- `RecalculateAllWeight` — RVA **0x6633750**.
  - Recomputes `_allWeight` from each candidate's effective `Weight()`.
- `BoostWeightByPercent` — RVA **0x6633824**.
  - Applies a temporary boost to one candidate and increases total weight by the returned increment.
- `RevertWeightBoost` — RVA **0x6633908**.
  - Reverts that temporary increment.
- `GetRandom` — RVA **0x66339E8**.
  - Draws against total weight and walks candidate weights until the random interval is hit.
- `GetRandomCount` — RVA **0x6633C0C**.
  - Performs repeated weighted selection while respecting result / skill / ban lists and upgrade-subskill handling.

This proves that weighted random is not hypothetical. The missing link is specifically the type-group adjustment call in `HeroComponentRandomSkill`.

## Candidate-pool restructuring helpers

`WeightRandom` also contains real native methods:
- `GetAlreadyStudySkill` — RVA **0x6634F18**.
- `GetReadyStudySkill` — RVA **0x6635318**.
- `GetOneStarSkill` — RVA **0x6635690**.
- `RandomOneSubSkillByParent` — RVA **0x66346A0**.

They rebuild/filter weighted candidates using current skill data, max-star/upgrade information and dependency checks. Exact slot priority inside the final three-choice output is still being traced because part of the call path is indirect.

## Static-call boundary

A direct scan of the stored `HeroComponentRandomSkill.asm` finds no direct call to:
- `WeightRandom.UpdateWeightPercent` (0x66327C4);
- `WeightRandom.GetRandom` / `GetRandomCount` helper RVAs.

That is consistent with indirect object/virtual dispatch in parts of the selection path and, importantly, does not rescue the empty `AdjustWeightsForSkillGroup` fallback.

The correct current statement is therefore:

**Type-based +50% / +500% Build weighting is designed and parameterized, but its activation is not proven in the bundled APK fallback. Runtime hotfix or statistical runtime evidence is required to upgrade it from “intended mechanism” to “active rule”.**

## Ordinary quality-weight modifiers

Source: `restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm`.

### `GetNormalSkill` — RVA **0x686E0A0**

For the ordinary (non-Danke) branch the method:

1. copies `Const.RandomSkillWeight` into the local `_skillWeights` array;
2. obtains the current hero's `AttributeData`;
3. calls `AttributeData.GetAttributeValueOrDefault(string)`;
4. if the returned FP raw value is positive, computes `factor = attr + FP.One` (`0x10000` raw);
5. multiplies array index 1 and array index 2 by that factor;
6. rounds each result with `FPMath.RoundToInt`;
7. leaves index 0 and index 3 unchanged;
8. passes the adjusted array into the normal skill-creator call.

This proves a second-stage quality-distribution modifier on top of the base `40/40/20/0`.

Config evidence from `AttributeString_string` contains id **110**, `ExHighSkillRate%`, comment “获得更高品质技能几率”, and id **126**, `LevelUpSkillUpRate%`, comment “升级提升品质概率”. The first name is a direct semantic match for the index-1/index-2 multiplicative redistribution. The native static string operand is not symbolized by the current disassembler, so retain this as a high-confidence name mapping rather than address-level string proof.

### `CheckQualityUp` — RVA **0x686DE10**

This is separate from the weight redistribution. It reads another FP attribute through `AttributeData.GetAttributeValueOrDefault`, and when the value is positive passes it to `BattleWorldContext.SkillRandomNextBool`. On success it returns true and emits the related hover event. This behavior is the semantic match for `LevelUpSkillUpRate%`: a probability gate for the later quality-index +1 path, not a direct rewrite of the `40/40/20/0` array.

## Init-pool runtime state is first-class and persistent

Structure source: `restored/code/il2cpp/assemblies/HotFixBattle.dll.cs`.

- `BattleData.InitSkillGroupCount` is its own field at struct offset **0x34**.
- `BattleSaveData.initSkillGroupCount` exists at object offset **0x20**.
- `BattleSaveData.SaveAllBattleData(..., int initSkillGroupCount, ...)` persists it.
- `BattleWorldContext.get_InitSkillGroupCount()` — RVA **0x6A033B4**.
- `BattleWorldContext.DoInitSkillGroup()` — RVA **0x6A035C0**.
- `BattleWorldContext.DoInitSkillGroupCount(int count)` — RVA **0x6A0362C**.

Combined with `SinglePlayerSkillCreator.GetNormalSkill` (RVA **0x6875450**) reading/decrementing the runtime counter and switching to `_initRandoms`, this proves the counter has a deliberate runtime and save-data lifecycle.

Still missing: a stored native caller that connects battle preparation directly to `Const.UseInitSkillGroupCout = 1`. Do not upgrade that last link to hard proof yet.
