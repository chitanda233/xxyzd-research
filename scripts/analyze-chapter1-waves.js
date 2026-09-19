#!/usr/bin/env node
/**
 * Compress chapter-1 Waterfall mission rows into a 15-wave design-facing summary.
 * Keeps deterministic spawns and random-pool draws separate.
 */
const fs = require("fs");
const path = require("path");

const root = path.resolve(__dirname, "..");
const load = p => JSON.parse(fs.readFileSync(path.join(root,p),"utf8"));
const M = load("restored/configs/tables/MissionWaterfallMission_WaterfallMission.json");
const G = load("restored/configs/tables/Mission_PositionGroupMonsterFlushConfig.json");
const R = load("restored/configs/tables/Mission_RandomMonsterFlushConfig.json");
const C = load("restored/configs/tables/ChapterWave_Waves.json");

const first = M.filter(x => x.id >= 1001001 && x.id <= 1001078);
const gmap = new Map(G.map(x => [x.id, JSON.parse(x.flushPool)]));
const rmap = new Map(R.map(x => [x.id, x]));
const add=(o,k,n=1)=>{ if(k!==undefined&&k!==null)o[k]=(o[k]||0)+n; };

function wave(w){
  const rows=first.filter(x=>x.wave===w), deterministic={}, random=[], events=[];
  for(const x of rows){
    const base=x.time?.decimal||0, delay=x.delayTime?.decimal||0;
    if(x.missinType) events.push({t:base,kind:"event",missionType:x.missinType,id:x.id});
    for(const m of x.Monster||[]) add(deterministic,m);
    if((x.Monster||[]).length) events.push({t:base+delay,kind:"direct",monsters:x.Monster});
    for(const rid of x.randomMonster||[]){
      const rr=rmap.get(rid);
      random.push({t:base+delay,poolId:rid,draws:x.numberRandom||0,candidates:rr?.entityId||[],weights:rr?.weight||rr?.Weight||null});
    }
    for(const gid of x.positionGroupMonster||[]){
      for(const e of gmap.get(gid)||[]){
        for(const m of e.Monster||[]) add(deterministic,m);
        events.push({t:base+(e.Delay||0),kind:"group",groupId:gid,monsters:e.Monster||[]});
      }
    }
  }
  events.sort((a,b)=>a.t-b.t);
  const cfg=C.find(x=>x.id===100100+w);
  const start=Math.min(...rows.map(x=>x.time.decimal));
  const nr=first.filter(x=>x.wave===w+1);
  const next=nr.length?Math.min(...nr.map(x=>x.time.decimal)):null;
  return {wave:w,start,next,nominalWindow:next===null?null:next-start,stopByEliteOrBossKilled:cfg?.StopByEliteOrBossKilled,waveAllExp:cfg?.WaveAllExp,deterministic,random,events};
}

const result=Array.from({length:15},(_,i)=>wave(i+1));
process.stdout.write(JSON.stringify(result,null,2)+"\n");
