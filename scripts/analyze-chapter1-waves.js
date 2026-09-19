#!/usr/bin/env node

/**
 * Chapter-1 Waterfall wave compressor.
 *
 * Converts the 78 raw MissionWaterfallMission rows into a 15-wave summary.
 * Important: deterministic spawns and random-pool draws are kept separate.
 */

const fs = require("fs");
const path = require("path");

const ROOT = path.resolve(__dirname, "..");
const readJson = rel => JSON.parse(fs.readFileSync(path.join(ROOT, rel), "utf8"));

const missions = readJson("restored/configs/tables/MissionWaterfallMission_WaterfallMission.json");
const groups = readJson("restored/configs/tables/Mission_PositionGroupMonsterFlushConfig.json");
const randomPools = readJson("restored/configs/tables/Mission_RandomMonsterFlushConfig.json");
const waves = readJson("restored/configs/tables/ChapterWave_Waves.json");

const chapter1 = missions.filter(x => x.id >= 1001001 && x.id <= 1001078);
if (chapter1.length !== 78) {
  throw new Error(`Expected 78 chapter-1 mission rows, got ${chapter1.length}`);
}

const groupMap = new Map(groups.map(x => [x.id, JSON.parse(x.flushPool)]));
const randomMap = new Map(randomPools.map(x => [x.id, x]));

function addCount(map, id, count = 1) {
  if (id === undefined || id === null) return;
  map[id] = (map[id] || 0) + count;
}

function summarizeWave(wave) {
  const rows = chapter1.filter(x => x.wave === wave);
  const deterministic = {};
  const random = [];
  const events = [];

  for (const row of rows) {
    const base = row.time?.decimal || 0;
    const delay = row.delayTime?.decimal || 0;

    if (row.missinType) {
      events.push({ time: base, kind: "mission-event", missionType: row.missinType, missionId: row.id });
    }

    if ((row.Monster || []).length) {
      const batch = {};
      for (const monsterId of row.Monster) {
        addCount(batch, monsterId);
        addCount(deterministic, monsterId);
      }
      events.push({ time: base + delay, kind: "spawn", source: `mission:${row.id}`, monsters: batch });
    }

    for (const randomId of row.randomMonster || []) {
      const pool = randomMap.get(randomId);
      random.push({
        time: base + delay,
        missionId: row.id,
        poolId: randomId,
        draws: row.numberRandom || 0,
        candidates: pool?.entityId || [],
        weight: pool?.weight || pool?.Weight || null
      });
      events.push({
        time: base + delay,
        kind: "random-pool",
        source: `mission:${row.id}`,
        poolId: randomId,
        draws: row.numberRandom || 0
      });
    }

    for (const groupId of row.positionGroupMonster || []) {
      for (const flush of groupMap.get(groupId) || []) {
        const batch = {};
        for (const monsterId of flush.Monster || []) {
          addCount(batch, monsterId);
          addCount(deterministic, monsterId);
        }
        events.push({
          time: base + (flush.Delay || 0),
          kind: "spawn",
          source: `group:${groupId}`,
          monsters: batch
        });
      }
    }
  }

  events.sort((a, b) => a.time - b.time);

  const waveConfig = waves.find(x => x.id === 100100 + wave);
  const start = Math.min(...rows.map(x => x.time.decimal));
  const nextRows = chapter1.filter(x => x.wave === wave + 1);
  const nextStart = nextRows.length ? Math.min(...nextRows.map(x => x.time.decimal)) : null;

  return {
    wave,
    start,
    nextStart,
    nominalWindow: nextStart === null ? null : nextStart - start,
    stopByEliteOrBossKilled: waveConfig?.StopByEliteOrBossKilled ?? null,
    waveAllExp: waveConfig?.WaveAllExp ?? null,
    startSpecialUI: waveConfig?.WaveStartSpecialUIType ?? [],
    endSpecialUI: waveConfig?.WaveEndSpecialUIType ?? [],
    deterministic,
    random,
    events
  };
}

const result = Array.from({ length: 15 }, (_, i) => summarizeWave(i + 1));
process.stdout.write(JSON.stringify(result, null, 2) + "\n");
