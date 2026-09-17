const ROOT='https://raw.githubusercontent.com/chitanda233/xxyzd-research/main/';
const POOLS=[
  {key:'base',label:'基础可选',file:'restored/configs/tables/SkillGroup_SurvivorGroup.json',hint:'首次进入构筑的武器与通用强化入口'},
  {key:'branch',label:'分支强化',file:'restored/configs/tables/SkillGroup_BranchSurvivorGroup.json',hint:'武器内部的分支型强化节点'},
  {key:'upgrade',label:'后续升级',file:'restored/configs/tables/SkillGroup_UpgradeSurvivorGroup.json',hint:'局内构筑过程中继续出现的升级节点'},
  {key:'high',label:'高阶升级组',file:'restored/configs/tables/SkillGroup_UpgradeSkillGroup.json',hint:'单独配置的高阶升级池；具体触发条件仍需结合运行逻辑'}
];
const FAMILIES=[
  {code:'001',name:'主武器'},
  {code:'002',name:'酸液弹'},
  {code:'003',name:'电弧枪'},
  {code:'004',name:'霰弹枪'},
  {code:'006',name:'冰刃弹'},
  {code:'007',name:'高爆导弹'},
  {code:'009',name:'黑洞'},
  {code:'011',name:'星空剑'},
  {code:'015',name:'激光炮'},
  {code:'016',name:'旋转锯盘'},
  {code:'017',name:'灼热射线'}
];
const FAMILY_NAME=Object.fromEntries(FAMILIES.map(x=>[x.code,x.name]));
let all=[],shown=[];
const $=id=>document.getElementById(id);
const esc=v=>String(v??'').replace(/[&<>"']/g,c=>({'&':'&amp;','<':'&lt;','>':'&gt;','"':'&quot;',"'":'&#39;'}[c]));
const meaningful=v=>Array.isArray(v)?v.length>0:(v!==0&&v!==''&&v!==null&&v!==undefined);
function familyOf(pool,row,id){if(pool.key==='base'&&Number(row.EventID)>=100)return'general';const s=String(id);if(s.length<6)return'';const code=s.slice(3,6);return FAMILY_NAME[code]?code:''}
function titleOf(x){return x.skill?._中文名称||x.row.notes?.replace(/[-－]\d+$/,'')||`配置 ${x.id}`}
function descOf(x){return x.skill?._中文说明模板||''}
function rel(label,v){if(!meaningful(v))return'';return `<div class="kv"><b>${label}</b><span>${esc(Array.isArray(v)?v.join(', '):v)}</span></div>`}
function weightProfile(row){const vals=[];for(let i=1;i<=10;i++){const k=`Weight_${i}`;if(k in row)vals.push(`${i}:${row[k]}`)}return vals.length?vals.join(' · '):''}
function card(x){const s=x.skill||{},note=x.row.notes||'';const badges=[x.pool.label,`ID ${x.id}`];if(x.family&&x.family!=='general')badges.unshift(`${FAMILY_NAME[x.family]} · ${x.family}`);if(x.family==='general')badges.unshift('通用强化');if(x.row.Weight!==undefined)badges.push(`权重 ${x.row.Weight}`);if(s.SkillStar!==undefined&&s.SkillStar!==0)badges.push(`星级 ${s.SkillStar}`);if(s.SkillType!==undefined)badges.push(`Type ${s.SkillType}`);if(s.IsSuper===1)badges.push('SUPER');const profile=weightProfile(x.row);return `<article class="skill-card"><div class="skill-top"><div><h3>${esc(titleOf(x))}</h3><div class="skill-id">${esc(note||x.pool.hint)}</div></div></div><div class="badges">${badges.map(b=>`<span>${esc(b)}</span>`).join('')}</div>${descOf(x)?`<p class="skill-desc">${esc(descOf(x))}</p>`:`<p class="skill-desc muted">当前便捷数据没有中文说明模板；可展开查看底层字段。</p>`}<div class="relations">${rel('前置 PreSkillIds',s.PreSkillIds)}${rel('需要 NeedSkills',s.NeedSkills)}${rel('互斥 RejectSkills',s.RejectSkills)}${rel('升级到 UpgradeSkillId',s.UpgradeSkillId)}${rel('下一节点 NextSkill',s.NextSkill)}${rel('覆盖 CoverSkill',s.CoverSkill)}${rel('Super 前置',s.SuperNeedSkill)}</div>${profile?`<details><summary>查看情境权重</summary><p class="mono">默认 ${esc(x.row.Weight)} · 新手 ${esc(x.row.WeightForNewplayer??'—')}<br>${esc(profile)}</p></details>`:''}<details><summary>原始池记录 + Skill_Main</summary><pre>${esc(JSON.stringify({pool:x.row,skill:x.skill||null},null,2))}</pre></details></article>`}
function familyTable(){const rows=FAMILIES.map(f=>{const items=all.filter(x=>x.family===f.code);const c=k=>items.filter(x=>x.pool.key===k).length;return `<tr><td><strong>${esc(f.name)}</strong><br><code>${f.code}</code></td><td>${c('base')}</td><td>${c('branch')}</td><td>${c('upgrade')}</td><td>${c('high')}</td><td><strong>${items.length}</strong></td></tr>`}).join('');$('familyTable').innerHTML=`<table><thead><tr><th>武器线</th><th>基础入口</th><th>分支</th><th>后续升级</th><th>高阶</th><th>合计</th></tr></thead><tbody>${rows}</tbody></table>`}
function render(){const q=$('q').value.trim().toLowerCase(),family=$('family').value,pool=$('pool').value,kind=$('kind').value;shown=all.filter(x=>{if(family&&x.family!==family)return false;if(pool&&x.pool.key!==pool)return false;if(kind==='weapon'&&!(x.pool.key==='base'&&x.row.EventID<100))return false;if(kind==='general'&&x.family!=='general')return false;if(kind==='zero'&&Number(x.row.Weight)!==0)return false;if(q){const hay=[x.id,x.row.notes,titleOf(x),descOf(x),FAMILY_NAME[x.family]||'',JSON.stringify(x.skill||{})].join(' ').toLowerCase();if(!hay.includes(q))return false}return true});$('status').textContent=`显示 ${shown.length} / ${all.length} 条池记录`;$('cards').innerHTML=shown.length?shown.map(card).join(''):'<div class="loading">没有匹配的局内升级项。</div>'}
async function load(){try{const [skills,...poolData]=await Promise.all([fetch(ROOT+'gameplay/skills-readable.json').then(r=>r.json()),...POOLS.map(p=>fetch(ROOT+p.file).then(r=>r.json()))]);const skillMap=new Map(skills.map(s=>[String(s.id),s]));all=[];POOLS.forEach((pool,i)=>{poolData[i].forEach(row=>{const id=row.GetID??row.EventID;all.push({pool,row,id,family:familyOf(pool,row,id),skill:skillMap.get(String(id))||null})})});const counts=Object.fromEntries(POOLS.map(p=>[p.key,all.filter(x=>x.pool.key===p.key).length]));const unique=new Set(all.map(x=>String(x.id))).size;const linked=all.filter(x=>x.skill).length;const zero=all.filter(x=>Number(x.row.Weight)===0).length;$('summary').innerHTML=`<div class="stat"><b>${counts.base||0}</b><span>基础可选</span></div><div class="stat"><b>${counts.branch||0}</b><span>分支强化</span></div><div class="stat"><b>${counts.upgrade||0}</b><span>后续升级</span></div><div class="stat"><b>${counts.high||0}</b><span>高阶升级组</span></div><div class="stat"><b>${unique}</b><span>池内唯一 ID</span></div><div class="stat"><b>${linked}</b><span>已反查 Skill_Main</span></div>`;$('family').innerHTML='<option value="">全部武器线 + 通用</option>'+FAMILIES.map(f=>`<option value="${f.code}">${f.name} · ${f.code}</option>`).join('')+'<option value="general">通用强化</option>';$('pool').innerHTML='<option value="">全部池</option>'+POOLS.map(p=>`<option value="${p.key}">${p.label} (${counts[p.key]||0})</option>`).join('');$('zeroNote').textContent=zero?`其中 ${zero} 条默认 Weight=0，说明“存在于配置”不等于当前默认会被抽到。`:'';familyTable();render()}catch(e){$('status').textContent='读取失败';$('cards').innerHTML=`<div class="loading">数据加载失败：${esc(e.message)}</div>`}}
['q','family','pool','kind'].forEach(id=>document.addEventListener('input',e=>{if(e.target.id===id)render()}));load();