#!/usr/bin/env node

/**
 * Compress Chapter 1 Waterfall mission instructions into 15 wave summaries.
 *
 * Sources:
 * - restored/configs/tables/MissionWaterfallMission_WaterfallMission.json
 * - restored/configs/tables/Mission_PositionGroupMonsterFlushConfig.json
 * - restored/configs/tables/Mission_RandomMonsterFlushConfig.json
 * - restored/configs/tables/ChapterWave_Waves.json
 *
 * Usage:
 *   node scripts/analyze-chapter1-waves.js
 */

const fs = require("fs");
const path = require("path");

const root = path.resolve(__dirname, "..");
const readJson = (p) =>
  JSON.parse(fs.readFileSync(path.join(root, p), "utf8"));

const mission = readJson(
  "restored/configs/tables/MissionWaterfallMission_WaterfallMission.json"
);
const positionGroups = readJson(
  "restored/configs/tables/Mission_PositionGroupMonsterFlushConfig.json"
);
const randomPools = readJson(
  "restored/configs/tables/Mission_RandomMonsterFlushConfig.json"
);
const chapterWaves = readJson(
  "restored/configs/tables/ChapterWave_Waves.json"
);

const rows = mission.filter((x) => x.id >= 1001001 && x.id <= 1001078);
const groupMap = new Map(
  positionGroups.map((x) => [x.id, JSON.parse(x.flushPool)])
);
const randomMap = new Map(randomPools.map((x) => [x.id, x]));

function addCount(target, id, count = 1) {
  if (id == null) return;
  target[id] = (target[id] || 0) + count;
}

function summarizeWave(wave) {
  const waveRows = rows.filter((x) => x.wave === wave);
  const counts = {};
  const timeline = [];

  for (const row of waveRows) {
    const baseTime = row.time?.decimal || 0;
    const delay = row.delayTime?.decimal || 0;

    if (row.missinType) {
      timeline.push({
        time: baseTime,
        kind: "event",
        detail: { missionType: row.missinType, missionId: row.id },
      });
    }

    const direct = {};

    for (const monsterId of row.Monster || []) {
      addCount(direct, monsterId);
      addCount(counts, monsterId);
    }

    for (const randomId of row.randomMonster || []) {
      const pool = randomMap.get(randomId);
      if (!pool) continue;

      for (const monsterId of pool.entityId || []) {
        addCount(direct, monsterId, row.numberRandom || 0);
        addCount(counts, monsterId, row.numberRandom || 0);
      }
    }

    if (Object.keys(direct).length > 0) {
      timeline.push({
        time: baseTime + delay,
        kind: "spawn",
        detail: direct,
      });
    }

    for (const groupId of row.positionGroupMonster || []) {
      const group = groupMap.get(groupId) || [];

      for (const entry of group) {
        const groupCounts = {};

        for (const monsterId of entry.Monster || []) {
          addCount(groupCounts, monsterId);
          addCount(counts, monsterId);
        }

        timeline.push({
          time: baseTime + (entry.Delay || 0),
          kind: "spawn",
          detail: groupCounts,
          groupId,
        });
      }
    }
  }

  timeline.sort((a, b) => a.time - b.time);

  const config = chapterWaves.find((x) => x.id === 100100 + wave);
  const start = Math.min(...waveRows.map((x) => x.time.decimal));
  const nextRows = rows.filter((x) => x.wave === wave + 1);
  const nextStart = nextRows.length
    ? Math.min(...nextRows.map((x) => x.time.decimal))
    : null;

  const spawnTimes = [
    ...new Set(
      timeline
        .filter((x) => x.kind === "spawn")
        .map((x) => x.time)
    ),
  ];

  return {
    wave,
    start,
    nextStart,
    nominalDuration:
      nextStart == null ? null : nextStart - start,
    stopByEliteOrBossKilled:
      config?.StopByEliteOrBossKilled ?? null,
    waveAllExp: config?.WaveAllExp ?? null,
    waveStartSpecialUIType:
      config?.WaveStartSpecialUIType ?? [],
    waveEndSpecialUIType:
      config?.WaveEndSpecialUIType ?? [],
    distinctSpawnBatches: spawnTimes.length,
    firstSpawn: spawnTimes[0] ?? null,
    lastSpawn: spawnTimes.at(-1) ?? null,
    monsterCounts: counts,
    timeline,
  };
}

const result = {
  sourceMissionRows: rows.length,
  waves: Array.from({ length: 15 }, (_, i) => summarizeWave(i + 1)),
};

process.stdout.write(JSON.stringify(result, null, 2) + "\n");
