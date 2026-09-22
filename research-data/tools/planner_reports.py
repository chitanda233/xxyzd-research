"""Render planner reference modules from reusable editorial data; no APK access."""
from pathlib import Path
import json,html,re,hashlib,sys
ROOT=Path(__file__).resolve().parents[2];DATA=ROOT/'research-data/planner';DOCS=ROOT/'docs'
MODULES=[('core','局内节奏'),('monsters','怪物与弹幕'),('choices-box-evolution','三选一、宝箱与进化'),('chapter-planning','章节规划'),('skills','武器构筑'),('aircraft','战机养成'),('systems','局外循环')]
TOOLS=[('monster-query.html','怪物与逐波查询'),('chapter-query.html','章节配置查询'),('skill-query.html','武器与词条查询'),('config.html','全部配置查询'),('research-data.html','规则与证据查询')]
BASE='https://github.com/chitanda233/xxyzd-research/blob/main/research-data/'
def esc(x):return html.escape(str(x),quote=True)
def read(slug):return json.loads((DATA/(slug+'.json')).read_text())
def nav(current,sections=[]):
 return '<nav class="toc" aria-label="报告目录"><a href="index.html">研究首页</a><strong>策划反拆</strong><ul>'+''.join('<li>'+('<b aria-current="page">'+label+'</b>' if current==slug else '<a href="'+slug+'.html">'+label+'</a>')+'</li>' for slug,label in MODULES)+'</ul>'+('<strong>本页</strong><ul>'+''.join('<li><a href="#'+s['id']+'">'+esc(s['title'])+'</a></li>' for s in sections)+'</ul>' if sections else '')+'<strong>工具 · 查表</strong><ul>'+''.join('<li><a href="'+p+'">'+n+'</a></li>' for p,n in TOOLS)+'</ul></nav>'
def shell(title,lead,content,slug='',sections=[],eyebrow='策划参考 · 客户端1.0.16'):
 return '<!doctype html><html lang="zh-CN"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1"><title>'+esc(title)+' · 小小远征队</title><link rel="stylesheet" href="assets/planner.css"><link rel="stylesheet" href="assets/term-tips.css"></head><body><header class="masthead"><a href="index.html">小小远征队 / 研究资料库</a><span>'+eyebrow+'</span></header><div class="layout">'+nav(slug,sections)+'<main id="main"><header class="hero"><h1>'+esc(title)+'</h1><p class="lead">'+esc(lead)+'</p></header>'+content+'</main></div><footer>策划报告与查表工具分开维护 · 中间数据和证据按专题目录保存</footer><script src="assets/term-tips.js"></script></body></html>'
def render_page(slug):
 d=read(slug);out=['<details class="mobile-contents"><summary>本页内容</summary><ul>'+''.join('<li><a href="#'+v['id']+'">'+esc(v['title'])+'</a></li>' for v in d['sections'])+'</ul></details>','<div class="question"><span>本模块回答</span><p>'+esc(d['question'])+'</p></div>']
 if slug=='core':
  out.append('<ol class="timeline" aria-label="第一章阶段节奏">'+''.join('<li><b>'+a+'</b><span>'+b+'</span></li>' for a,b in [('1—4波','选择方向'),('5波','首次压力峰'),('6波','宝箱补强'),('10波','精英检验'),('11波','宝箱补强'),('15波','宝箱＋首领')])+'</ol>')
 for s in d['sections']:
  kind=s['kind'];label={'reference':'设计参考 · 非原作新增规则','interpretation':'策划归纳','configuration':'配置规则','rule':'运行规则与案例'}[kind]
  out.append('<section id="'+s['id']+'" class="section '+kind+'"><div class="label">'+label+'</div><h2>'+esc(s['title'])+'</h2><p>'+esc(s['text'])+'</p>')
  if s['rows']:
   out.append('<div class="table-wrap" tabindex="0" role="region" aria-label="'+esc(s['title'])+'"><table><thead><tr>'+''.join('<th scope="col">'+esc(h)+'</th>' for h in s['heads'])+'</tr></thead><tbody>')
   for row in s['rows']:out.append('<tr>'+''.join(('<th scope="row">'+esc(v)+'</th>') if i==0 else '<td>'+esc(v)+'</td>' for i,v in enumerate(row))+'</tr>')
   out.append('</tbody></table></div>')
  if s['refs']:out.append('<details class="sources"><summary>查看本节数据依据</summary>'+''.join('<a href="'+BASE+esc(r)+'">'+esc(r.split('/')[-1])+'</a> ' for r in s['refs'])+'</details>')
  out.append('</section>')
 out.append('<aside class="lookup"><h2>需要具体数值或逐条核查？</h2><p>正文用于理解规则和参考设计，完整配置、逐条数据与证据保留在查询层。</p><a class="button" href="'+d['lookup']+'">打开本模块查表工具</a> <a href="https://github.com/chitanda233/xxyzd-research/tree/main/research-data/">查看数据与证据目录</a></aside>')
 if d['sources']:out.append('<details class="sources"><summary>本模块来源与适用范围</summary>'+''.join('<p><a href="'+BASE+r+'">'+esc(r)+'</a></p>' for r in d['sources'])+'</details>')
 (DOCS/(slug+'.html')).write_text(shell(d['title'],d['lead'],''.join(out),slug,d['sections']))
def render_lookup(kind,text):
 if kind=='monsters':
  start=text.index('<h2 id="catalog">');end=text.index('<h2 id="evidence">',start)
  body=text[start:end]
  script=''.join(re.findall(r'<script(?! src)[\s\S]*?</script>',text))
  style=''.join(re.findall(r'<style>[\s\S]*?</style>',text))
  body=body.replace('7. 逐怪档案','逐怪档案').replace('8. 逐章与逐波分布','逐章与逐波分布')
  result=shell('怪物与逐波查询','按怪物、类型和章节筛选；查看数值、行为参数、武器子弹和每波投放。',style+body+script)
  (DOCS/'monster-query.html').write_text(result)
 elif kind=='chapters':
  # Keep only complete chapter lookup and its generated disclosure rows.
  hs=list(re.finditer(r'<h2 id="([^"]+)">([^<]+)</h2>',text));hit=next(i for i,m in enumerate(hs) if '全部70章' in m[2])
  body=text[hs[hit].start():hs[hit+1].start()]
  (DOCS/'chapter-query.html').write_text(shell('章节配置查询','逐章核对波次、经验、宝箱、击杀门槛与基础/B差异。',body))
 elif kind=='skills':
  body=text[text.index('<body>')+6:text.index('</body>')]
  # Preserve client-side query controls and their IDs; remove the old editorial tail.
  body=re.sub(r'<header[\s\S]*?</header>','',body,count=1)
  body=re.sub(r'<nav class="toc">[\s\S]*?</nav>','',body)
  body=re.sub(r'<h2[^>]*>四层池子分别代表什么</h2>[\s\S]*?(?=<script|</main>)','',body)
  body=re.sub(r'<h2[^>]*>下一步研究重点</h2>[\s\S]*?(?=<script|</main>)','',body)
  (DOCS/'skill-query.html').write_text(shell('武器与词条查询','按武器家族、池类型、名称和ID查词条。配置行数与权重不等于当前可抽数量或最终概率。',body))
 else:raise ValueError(kind)
def index():
 cards=''.join('<a class="card" href="'+slug+'.html"><span>0'+str(i+1)+'</span><h2>'+label+'</h2><p>'+esc(read(slug)['question'])+'</p><b>查看策划反拆 →</b></a>' for i,(slug,label) in enumerate(MODULES))
 tools=''.join('<a href="'+p+'">'+label+' →</a>' for p,label in TOOLS)
 body='<div class="question"><span>阅读方式</span><p>每个模块先讲设计作用，再给“条件 → 系统行为 → 玩家结果”的规则与案例，最后提供可借鉴的设计方案。策划归纳和设计参考均单独标明。</p></div><h2>策划反拆 · 独立模块</h2><div class="cards">'+cards+'</div><section class="section"><h2>工具 · 只做查询</h2><p>需要全量名单、逐波数据或配置字段时，从这里进入。</p><div class="tool-links">'+tools+'</div></section><section class="section"><h2>研究材料怎样交接</h2><p>APK → 反编译 → 中间数据与证据 → 最终报告。日常研究直接使用中间数据，只有规则缺口需要时才继续定向查源码。</p><a href="https://github.com/chitanda233/xxyzd-research/tree/main/research-data/">打开数据与证据目录 →</a></section>'
 (DOCS/'index.html').write_text(shell('小小远征队 · 策划反拆参考','从玩家要处理的问题出发，解释系统在什么情况下做什么，以及这些规则怎样组成可参考的设计方案。',body))
def validate():
 for slug,_ in MODULES:
  d=read(slug);assert len(d['sections'])>=5
  for s in d['sections']:
   assert all(len(row)==len(s['heads']) for row in s['rows']),slug
   for r in s['refs']:assert (ROOT/'research-data'/r).is_file(),r
  for r in d['sources']:assert (ROOT/'research-data'/r).is_file(),r
  text=(DOCS/(slug+'.html')).read_text();ids=re.findall(r'id="([^"]+)"',text)
  assert len(ids)==len(set(ids)),slug
  assert set(re.findall(r'href="#([^"]+)"',text))<=set(ids),slug
  for href in re.findall(r'href="([^"]+)"',text):
   if not href.startswith(('http','#')):assert (DOCS/href.split('?')[0].split('#')[0]).exists(),href
 print('PASS: 7 planner modules, source paths, table shapes, anchors and local links')
def manifest():
 files={str(p.relative_to(DATA)):hashlib.sha256(p.read_bytes()).hexdigest() for p in DATA.rglob('*') if p.is_file() and p.name!='manifest.json'}
 (DATA/'manifest.json').write_text(json.dumps(files,ensure_ascii=False,indent=2)+'\n')
if __name__=='__main__':
 if len(sys.argv)>1 and sys.argv[1]=='validate':validate()
 else:
  for slug,_ in MODULES:render_page(slug)
  index()
  template=DATA/'skill-query.template.html'
  if template.exists():(DOCS/'skill-query.html').write_text(template.read_text())
  manifest();validate()
