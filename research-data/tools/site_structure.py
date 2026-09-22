"""Shared, flat information architecture for planner reports."""
import re
from pathlib import Path
MODULES=[('core.html','局内整体链路'),('monsters.html','怪物、弹幕与章节分布'),('choices-box-evolution.html','三选一、宝箱与武器进化'),('chapter-planning.html','章节规划与规则差异'),('skills.html','局内升级词条'),('aircraft.html','战机与皮肤'),('systems.html','局外系统')]
def normalize(text,current):
 if 'assets/planner.css' in text:return text
 def nav(match):
  old=match.group(0);anchors=re.findall(r'<li>\s*(<a href="#[^"]+">.*?</a>)\s*</li>',old,re.S)
  local='<strong>本页目录</strong><ul>'+''.join('<li>'+a+'</li>' for a in anchors)+'</ul>' if anchors else ''
  return '<nav class="toc"><p><a href="index.html">← 研究首页</a></p><strong>策划反拆 · 独立模块</strong><ul>'+''.join('<li>'+('<strong aria-current="page">'+label+'</strong>' if path==current else '<a href="'+path+'">'+label+'</a>')+'</li>' for path,label in MODULES)+'</ul>'+local+'<strong>工具 · 查表</strong><p><a href="config.html">配置查询</a></p><p><a href="research-data.html">研究数据查询</a></p></nav>'
 text=re.sub(r'<nav class="toc">.*?</nav>',nav,text,flags=re.S)
 return re.sub(r'<a class="back" href="[^"]+">.*?</a>','<a class="back" href="index.html">← 研究首页</a>',text)
def homepage(text):
 if 'assets/planner.css' in text:return text
 cards={re.search(r'href="([^"]+)"',c)[1]:c for c in re.findall(r'<a class="card".*?</a>',text,re.S)}
 planner='<h2>策划反拆</h2><p>独立模块并列组织，分别解释各系统的设计逻辑、规则与配置关系。</p><section class="grid">'+''.join(cards[p] for p,_ in MODULES)+'</section>'
 tools='<h2 style="margin-top:34px">工具</h2><p>按表名、字段、ID和结论编号查询数据。</p><section class="grid">'+cards['config.html']+cards['research-data.html']+'</section>'
 start=text.index('<h2>策划反拆</h2>');end=text.index('<section class="stats">',start)
 return text[:start]+planner+tools+text[end:]
if __name__=='__main__':
 root=Path(__file__).resolve().parents[2]
 p=root/'docs/index.html';p.write_text(homepage(p.read_text()))
 for name,_ in MODULES:
  p=root/'docs'/name;p.write_text(normalize(p.read_text(),name))
