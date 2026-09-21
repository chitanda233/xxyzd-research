#!/usr/bin/env python3
"""Generate the data reading page and the report wave table from canonical L2 JSON."""
import html,json,re,runpy
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];D=ROOT/'research-data/in-run'
def read(n):return json.loads((D/n).read_text())
def esc(x):return html.escape(str(x),quote=True)
def show(x):return json.dumps(x,ensure_ascii=False,indent=2)
facts=read('facts.json');sources=read('sources.json');questions=read('questions.json');waves=read('datasets/chapter-1.json')['waves'];skills=read('datasets/skill-build.json')
rows=[]
for w in waves:
 comp=' + '.join(f'{k}×{v}' for k,v in w['composition'].items())
 events=[e for e in w['events'] if e['kind']=='punchboard']
 nature='特殊目标死亡锁' if w['death_gate'] else '脚本与波末流程'
 if events:nature='阶段技能事件 → '+nature
 count=('最多' if w['death_gate'] else '')+str(w['configured_monster_count'])
 window='终局' if w['nominal_window_seconds'] is None else f"{w['nominal_window_seconds']:g}s"
 rows.append('<tr>'+''.join('<td>'+esc(v)+'</td>' for v in [w['wave'],f"{w['script_start_seconds']:g}s",window,count,comp,nature,w['experience_budget']])+'</tr>')
table='<div class="scroll"><table><thead><tr>'+''.join('<th>'+x+'</th>' for x in ['波','脚本起点','名义窗口','配置怪量','怪物组合','推进与事件','经验预算'])+'</tr></thead><tbody>'+''.join(rows)+'</tbody></table></div>'
p=ROOT/'docs/core.html';s=p.read_text();s,n=re.subn(r'<!-- BEGIN GENERATED WAVES -->.*?<!-- END GENERATED WAVES -->','<!-- BEGIN GENERATED WAVES -->\n'+table+'\n<!-- END GENERATED WAVES -->',s,flags=re.S);assert n==1
if 'assets/term-tips.js' not in s:s=s.replace('</body>','<script src="assets/term-tips.js"></script></body>')
p.write_text(s)
base='https://github.com/chitanda233/xxyzd-research/blob/main/research-data/in-run/' if (ROOT/'restored').exists() else '../research-data/in-run/'
parts=['''<!doctype html><html lang="zh-CN"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1"><title>局内研究数据 · 规则与证据</title><link rel="stylesheet" href="assets/style.css"><style>pre{white-space:pre-wrap;overflow-wrap:anywhere;background:#f3f7f6;padding:16px;border-radius:8px;font-size:13px}details{border-bottom:1px solid #d4e2de;padding:14px 0}summary{cursor:pointer;font-weight:bold}summary:focus-visible{outline:2px solid #0a756c}details:target{background:#edf4fb} .record{scroll-margin-top:18px}</style></head><body><header class="page-head"><div class="hero"><div class="eyebrow">REUSABLE RESEARCH DATA</div><h1>局内研究数据</h1><p>从规则查到参数，从数据查到依据。默认复用本数据集，遇到明确缺口再深入源码。</p><div class="chips"><span>客户端1.0.16</span><span>第一章基础配置</span><span>25条规则</span><span>15波明细</span><span>离线可用</span></div></div></header><main class="layout"><nav class="toc"><strong>数据目录</strong><ul>''']
for anchor,label in [('overview','使用方式'),('facts','规则索引'),('waves','波次数据'),('build-data','技能关系'),('sources','来源索引'),('questions','待证问题'),('dictionary','字段与校验')]:parts.append(f'<li><a href="#{anchor}">{label}</a></li>')
parts.append('</ul><a href="core.html">返回正式报告</a><p><a href="choices-box-evolution.html">三选一与武器进化专题</a></p></nav><article class="article"><h2 id="overview">使用方式</h2>')
parts.append('<p class="summary">先查规则F编号或15波表，再按来源ID定位包内配置行或函数摘录。这里保存的是可复用研究结果；证据状态与适用条件不会因页面展示而省略。</p><p><a href="downloads/xxyzd-in-run-handoff.zip">下载报告＋中间数据交接包</a> · <a href="'+base+'baseline.json">版本指纹</a> · <a href="'+base+'manifest.json">文件哈希清单</a></p>')
parts.append('<pre>python3 research-data/tools/research.py query wave:10\npython3 research-data/tools/research.py query skill:10000103\npython3 research-data/tools/research.py query 复活\npython3 research-data/tools/research.py validate</pre><h2 id="facts">规则索引</h2><p>静态确认：配置和APK实现范围内成立。设计存在：不能作为实际启用规则。每条记录可展开参数和限制。</p>')
labels={'verified_static':'静态确认','designed_only':'设计存在，未证实启用','interpretation':'策划解释'}
for f in facts:
 parts.append(f'<details class="record" id="{f["id"]}"><summary>{f["id"]} · {esc(f["title"])} <span class="badge">{labels[f["status"]]}</span></summary><p>{esc(f["statement"])}</p><pre>{esc(show(f["parameters"]))}</pre>')
 parts.append('<p>适用：'+esc(f['applies_to'])+'</p>')
 if f['limitations']:parts.append('<p class="callout">'+esc('；'.join(f['limitations']))+'</p>')
 parts.append('<p>依据：'+' · '.join(f'<a href="#src-{esc(i.replace(":","-"))}">{esc(i)}</a>' for i in f['source_ids'])+'</p></details>')
parts.append('<h2 id="waves">15波数据</h2><p>由包内输入计算生成；时间单位为配置脚本秒，硬门槛波怪量按最大脚本规模表达。<a href="'+base+'datasets/chapter-1.json">读取完整JSON（含逐事件来源）</a></p>'+table)
parts.append('<h2 id="build-data">技能与依赖关系</h2><p>'+str(len(skills['nodes']))+'个相关技能节点，'+str(len(skills['edges']))+'条配置关系，'+str(len(skills['recipes']))+'条方向性配方记录。节点包含四个池及相关依赖闭包，不等于玩家可选数量。</p><p><a href="'+base+'datasets/skill-build.json">技能图JSON</a> · <a href="'+base+'flow.json">局内流程关系JSON</a></p>')
parts.append('<h2 id="sources">来源索引</h2><p>链接打开最小证据快照，完整底层来源由origin字段定位。交接包内无需下载完整反编译库。</p>')
for r in sources:
 label=r.get('method',r['id']);detail=(str(r['record_count'])+'行' if r['kind']=='config_rows' else r['rva'])
 parts.append(f'<details id="src-{esc(r["id"].replace(":","-"))}"><summary>{esc(r["id"])} · {esc(detail)}</summary><p>{esc(label)}</p><p><a href="{base+esc(r["path"])}">打开快照或函数摘录</a></p><pre>{esc(show(r))}</pre></details>')
parts.append('<h2 id="questions">待证问题与深查条件</h2><p>下列条目没有被当成已确认规则。已有查证范围一起保存，避免下次从头重做。</p>')
for q in questions:
 parts.append(f'<details id="{q["id"]}"><summary>{q["id"]} · {esc(q["question"])}</summary><p><strong>影响：</strong>{esc(q["impact"])}</p><p><strong>已查：</strong>{esc(q["already_checked"])}</p><p><strong>所需：</strong>{esc(q["required_evidence"])}</p><p><strong>何时继续：</strong>{esc(q["reopen_when"])}</p></details>')
parts.append('<h2 id="dictionary">字段与校验</h2><p><a href="'+base+'DICTIONARY.md">完整数据字典</a> · <a href="'+base+'facts.json">规则JSON</a> · <a href="'+base+'sources.json">来源JSON</a> · <a href="'+base+'questions.json">问题JSON</a></p><p>校验覆盖文件哈希、记录引用、输入复算与关键数值约束，不代表线上行为已验证。完整定点数、_B列与语言模板保存在输入快照，派生数据限定基础配置。</p></article></main><a class="back" href="core.html">← 正式报告</a><script src="assets/term-tips.js"></script></body></html>')
(ROOT/'docs/research-data.html').write_text(''.join(parts))
print('Rendered data page and report wave table from canonical JSON')
