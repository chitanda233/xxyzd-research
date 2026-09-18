# Chapter 1 wave / upgrade native evidence notes

Purpose: preserve the minimum native evidence needed to reproduce the design conclusions in `research/battle/wave-analysis.md`. This is not a reconstructed C# implementation.

## Wave timing and random-spawn evidence

Source: `restored/code/native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm`.

- `CalRandomMonster` — RVA **0x65D2D9C**.
  - Reads referenced random-monster config rows and their `entityId` arrays.
  - Around **0x65D36D8–0x65D36E4**, the generated-count accumulator is advanced by the current entity index and compared with the requested target; when the target is reached, control exits the current fill loop.
  - Around **0x65D36E8–0x65D3708**, if the selected pool did not satisfy the target, it continues selecting until satisfied, with a safety cap of 0x1F5.
  - This is why Chapter 1 rows using random pools 2 / 5 / 13 can be converted to exact `330006` counts: all three pools contain only `330006`, and `numberRandom` is the target count.

## Elite / Boss hard-gate evidence

Source: `WaterfallBattleManager.asm`.

- `CheckStopByEliteOrBossKilled` — RVA **0x65D3784**.
  - Reads the current `ChapterWave` stop flag and returns true only for the enabled wave.
- `EnemyDieSpecialLogic` — RVA **0x65D4E80**.
  - Only enters the special-death branch when the current wave uses the stop flag.
  - Checks monster type **201 (0xC9)** or **3**.
  - Decrements `_remainSpecialMonsterCount`.
  - When the count reaches zero, calls `BaseSurvivalBattleManager.EnemySpecialDie`.

Source: `restored/code/native-evidence/HotFix.BattleLogic.BaseSurvivalBattleManager.asm`.

- `EnemySpecialDie` — RVA **0x65875AC**.
  - Calls `SetRefreshState` to release/reset the special refresh state and allow progression.

Chapter 1 data then makes the design distinction explicit:
- Wave 5: `StopByEliteOrBossKilled = 0`; no Type=201/3 monster.
- Wave 10: `StopByEliteOrBossKilled = 1`; `310008` is Type=201.
- Wave 15: `StopByEliteOrBossKilled = 1`; `340002` is Type=3.

## Wave-end level-up queue evidence

Source: `WaterfallBattleManager.asm`.

- `AddUpLevel` — RVA **0x65C8890**: increments `_needUpLevelCount`.
- `DelUpLevel` — RVA **0x65C88FC**: consumes one pending count; when valid, increments `curWaveUpLevelCount`.
- `ShouldApplyLevelOnSelectSkillEnter` — RVA **0x65C8978**: moves the wave-end level-up state from waiting-for-selection to selection-entered.
- `MarkWaveEndSelectSkillFinished` — RVA **0x65C8A00**: only succeeds from the expected state, advances the state and calls `DelUpLevel`.
- `QueueSelectSkill` — RVA **0x65C8E98**: queues/activates the select-skill state during the wave-end flow.
- `OnProgressFinish` — RVA **0x65CC838**:
  - waits for / absorbs remaining drops and EXP;
  - checks EXP animation/level-up readiness;
  - if `_needUpLevelCount != 0`, branches to `QueueSelectSkill`;
  - otherwise continues the wave-end special-UI progression.

Together these functions prove that multiple level gains are represented as a count and consumed **one selection at a time**, rather than collapsed into one selection.

## Experience-budget evidence

Static tables:
- `ChapterWave_Waves.json`: Chapter 1 `WaveAllExp` =
  `200, 550, 600, 600, 700, 800, 800, 950, 1000, 1100, 1200, 1200, 1400, 1700, 2000`.
- `Exp_exp.json`: first 15 cumulative `waveExp` =
  `200, 750, 1350, 1950, 2650, 3450, 4250, 5200, 6200, 7300, 8500, 9700, 11100, 12800, 14800`.

Adjacent threshold differences are exactly equal to `WaveAllExp`, giving a direct design invariant: one complete Chapter 1 wave budget equals one next-level increment.

## Evidence boundary

These notes prove the bundled APK fallback behavior and static data. They do not prove:
- online hotfix substitutions;
- real-time UI pause duration;
- post-Boss result-screen duration;
- server-side overrides.
