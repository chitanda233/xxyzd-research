const GROUPS = {
  aircraft:{title:'战机 / 皮肤配置',desc:'Role 本体、长期等级、升星、战机形态与形态升星。',tables:['Role_Role.json','Role_Level.json','Role_LevelAttr.json','Role_Star.json','Role_Upgrade.json','Role_Skin.json','Role_SkinStar.json']},
  weapons:{title:'武器配置',desc:'AirplaneGun 本体、升星、武器皮肤与总配置。',tables:['AirplaneGun_AirplaneGun.json','AirplaneGun_Star.json','AirplaneGun_Skin.json','AirplaneGun_AirplaneGunConfig.json']},
  equipment:{title:'装备配置',desc:'装备本体、等级、品质、部位和相关显示配置。',tables:['Equipment_Equip.json','Equipment_Level.json','Equipment_Quality.json','Equipment_Position.json','Equipment_ABicon.json']},
  drones:{title:'僚机配置',desc:'僚机本体、升星、等级模板、天赋和收藏成长。',tables:['Drone_Drone.json','Drone_Star.json','Drone_LevelTemplate.json','Drone_TalentNode.json','Drone_TalentLevel.json','Drone_Collection.json']},
  pilots:{title:'Pilot 配置组',desc:'Pilot 本体、升星、动画映射和总配置。',tables:['Pilot_Pilot.json','Pilot_Star.json','Pilot_PilotAnim.json','Pilot_PilotConfig.json','Pilot_Sheet1.json']},
  collections:{title:'收藏品配置',desc:'当前 Treasure 体系与历史 Collection 配置统一放在这里查。',tables:['Collection_Treasure.json','Collection_TreasureStar.json','Collection_TreasureSuit.json','Collection_TreasureQuality.json','Collection_Equip.json','Collection_Rune.json','Collection_Card.json']},
  runbuild:{title:'局内构筑配置',desc:'玩家局内抽取池及其分支、升级、高阶组。底层 Skill_Main 另有大表附录。',tables:['SkillGroup_SurvivorGroup.json','SkillGroup_BranchSurvivorGroup.json','SkillGroup_UpgradeSurvivorGroup.json','SkillGroup_UpgradeSkillGroup.json','SkillGroup_InitSurvivorGroup.json','SkillGroup_SurvivorFullGroup.json','SkillGroup_InfinateSkillGroup.json']},
  chapters:{title:'关卡 / 模式配置',desc:'主线以及各类局外模式的关卡配置。',tables:['Chapter_MainChapter.json','Chapter_MainChapterHard.json','Chapter_Sections.json','Chapter_Tower.json','Chapter_Arena.json','Chapter_GoldDungeon.json','Chapter_WorldBoss.json','Chapter_GuildBoss.json','Chapter_MapStyle.json']}
};
const LABELS={aircraft:'战机/皮肤',weapons:'武器',equipment:'装备',drones:'僚机',pilots:'Pilot',collections:'收藏品',runbuild:'局内构筑',chapters:'关卡/模式'};
const BASE='https://raw.githubusercontent.com/chitanda233/xxyzd-research/main/restored/configs/tables/';
const GH='https://github.com/chitanda233/xxyzd-research/blob/main/restored/configs/tables/';
const qs=new URLSearchParams(location.search); let group=qs.get('group')||'aircraft'; if(!GROUPS[group]) group='aircraft';
let rows=[], filtered=[], page=1; const PAGE=50;
const $=id=>document.getElementById(id);
$('groupTitle').textContent=GROUPS[group].title; $('groupDesc').textContent=GROUPS[group].desc;
$('groupNav').innerHTML=Object.keys(GROUPS).map(k=>'<a href="config-view.html?group='+k+'"'+(k===group?' style="font-weight:700;border-color:#0d766c"':'')+'>'+LABELS[k]+'</a>').join('');
$('tableSelect').innerHTML=GROUPS[group].tables.map(t=>'<option value="'+t+'">'+t.replace('.json','')+'</option>').join('');
function flat(v){ if(v==null)return ''; if(typeof v==='object') return JSON.stringify(v); return String(v); }
function esc(s){return String(s).replace(/[&<>"']/g,c=>({'&':'&amp;','<':'&lt;','>':'&gt;','"':'&quot;',"'":'&#39;'}[c]));}
async function load(){
 const file=$('tableSelect').value; $('rawLink').href=GH+file; $('dataWrap').innerHTML='<div style="padding:24px">正在读取 '+esc(file)+'…</div>';
 try{ const r=await fetch(BASE+file); if(!r.ok) throw new Error('HTTP '+r.status); const d=await r.json(); rows=Array.isArray(d)?d:[d]; page=1; apply(); }
 catch(e){ $('dataWrap').innerHTML='<div style="padding:24px">读取失败：'+esc(e.message)+'</div>'; }
}
function apply(){
 const q=$('configSearch').value.trim().toLowerCase();
 filtered=q?rows.filter(r=>JSON.stringify(r).toLowerCase().includes(q)):rows.slice();
 page=1; render();
}
function render(){
 const totalPages=Math.max(1,Math.ceil(filtered.length/PAGE)); page=Math.min(page,totalPages);
 const slice=filtered.slice((page-1)*PAGE,page*PAGE);
 const keys=[]; slice.forEach(r=>Object.keys(r||{}).forEach(k=>{if(!keys.includes(k))keys.push(k)}));
 $('tableInfo').textContent=$('tableSelect').value+' · 原始 '+rows.length+' 行';
 $('matchInfo').textContent='当前匹配 '+filtered.length+' 行';
 $('pageInfo').textContent='第 '+page+' / '+totalPages+' 页';
 if(!slice.length){$('dataWrap').innerHTML='<div style="padding:24px">没有匹配记录。</div>';return;}
 let h='<table class="datatable"><thead><tr>'+keys.map(k=>'<th>'+esc(k)+'</th>').join('')+'</tr></thead><tbody>';
 h+=slice.map(r=>'<tr>'+keys.map(k=>{const v=r[k]; const obj=v&&typeof v==='object'; return '<td'+(obj?' class="object"':'')+' title="'+esc(flat(v))+'">'+esc(flat(v))+'</td>';}).join('')+'</tr>').join('');
 h+='</tbody></table>'; $('dataWrap').innerHTML=h;
}
$('tableSelect').addEventListener('change',load);
$('configSearch').addEventListener('input',apply);
$('prevPage').addEventListener('click',()=>{if(page>1){page--;render();}});
$('nextPage').addEventListener('click',()=>{if(page<Math.ceil(filtered.length/PAGE)){page++;render();}});
load();