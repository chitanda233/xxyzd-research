# 四层研究结构与交接方式

## 唯一入口

网站入口为 `docs/index.html`。策划反拆按独立模块并列组织：局内整体链路、怪物与弹幕、三选一与武器进化、章节规划、升级词条、战机与皮肤、局外系统。各模块不是局内整体链路的下级；工具区只承担查表与数据查询。导航由 `research-data/tools/site_structure.py` 统一维护。

- 报告入口：`docs/index.html`，各策划模块独立进入。
- 中间数据：`research-data/in-run/` 与 `research-data/topics/`（各模块规则、可计算数据与最小证据）。
- 人工阅览：`docs/research-data.html`（由中间数据生成）。
- 日常工具：`research-data/tools/research.py`。

```text
L0 版本原件          L1 反编译/解码           L2 中间数据                 L3 最终报告
APK与SHA-256   →     配置表/字段结构     →     版本基线+输入快照       →     策划链路与设计解释
解包文件清单        原生函数与地址            规则+波次+技能关系           必要边界
                    二进制指纹              证据摘录+来源+待证问题        逐波表由L2生成
                                             ↑ 日常研究从这里开始
```

| 层 | 现有位置 | 职责 | 默认交接 |
|---|---|---|---|
| L0 原件 | `original/`（本机可选）、`unpacked/`、`indexes/apk-summary.json`、`indexes/apk-files.json` | 保存不可混淆的版本和原始内容；APK缺失时明确缺失，不冒称在包中 | 否；只在L2带版本指纹 |
| L1 解码/反编译 | `restored/configs/{tables,schemas,textassets}`、`restored/code/`、`evidence/` | 保留配置结构、函数地址与原生实现；空C#方法体不作为实现证据 | 否；需要时按L2来源索引取对应文件 |
| L2 中间数据 | `research-data/in-run/`、`research-data/topics/` | 让各独立模块的研究可以检索、计算和复用；每条规则有状态、范围、依据 | 是；含必要配置行与函数摘录 |
| L3 报告 | `docs/index.html`下的各独立模块 | 给策划讲明对应系统的规则与设计关系，不混入工作日志或分析版本对比 | 是 |

物理上不搬动数百MB的L0/L1文件，以免破坏现有路径；层级由职责、清单和引用建立。L2为自包含快照，不依赖原仓库的绝对路径。

## 同事接手的工作顺序

1. 读报告明确问题，查L2规则与数据。
2. 引用现有F编号开展新分析，先检查适用客户端与配置分支。
3. 需要重新计算时用包内inputs和唯一计算器，通常无需网络或原项目。
4. 已有规则不能回答时查看questions与sources，按表行/函数地址精准取L1证据。
5. 仅当L1缺实现、解码失败或研究版本变化时再取L0、反编译或运行态材料。
6. 新结论回写L2：事实、来源、范围、限制、缺口；最后更新报告。禁止只把结论留在聊天里。

## 哪些情况必须回到底层

- 现有来源互相矛盾，或源码实际分支不支持已写规则。
- 新问题要求未还原的公式、资格、概率或净收益。
- 客户端指纹、表指纹或实际分流发生变化。
- 需要服务端/热更新/实机事实，而现有包只有APK静态证据。

“为了熟悉项目”不构成重新全量扫描的理由。调用不存在也不证明功能不存在，应区分内联、间接调用和热更。

## 包的验收与更新

```sh
python3 research-data/tools/research.py validate
python3 research-data/tools/research.py rebuild
python3 research-data/tools/render.py
```

交接时直接移交 `docs/` 报告与 `research-data/` 中间数据、证据、清单和查询/复算工具；各目录以普通文件形式保存，不打包。Python标准库即可校验。包内不放APK、完整native库、美术或SQLite数据库。独立页面上的外围研究站链接可能仍需联网。

所有L2文件带哈希清单；F编号引用来源ID，来源提供L1原路径、函数RVA或表行键。变更时保留Git提交记录即可，不维护多份相互竞争的“最终分析”。历史研究笔记不是新的事实入口。

## 成本控制

先查询→再计算→最后定向反编译。研究目录保存的不只是结论，还包含推导所需输入和最小证据，避免下一位同事重复购买同一次分析成本。对已验证规则只在版本变化、出现反证或任务需要更精确结论时复核。

## 章节规划专题

- 唯一报告：`docs/chapter-planning.html`，含70章对照、2032条双分支逐波明细与章节随机规则。
- 中间数据：`research-data/topics/chapter-planning/`；大型输入用标准gzip压缩，保留完整字段与定点数。
- 查询与校验：`python3 research-data/tools/chapter_topic.py chapter:55` / `validate`。
- 交接方式：直接使用对应的 `research-data/topics/` 数据与证据目录，以及 `docs/` 中的报告文件，不生成压缩包。

## 三选一与武器进化专题

- 唯一专题报告：`docs/choices-box-evolution.html`。
- 结构化数据：`research-data/topics/choices-box-evolution/`（规则、71章权重映射、22条配方、常量、证据和未闭合断点）。
- 校验：`python3 research-data/tools/choice_topic.py validate`。
- 以实际代码为准：主线宝箱实体8已接通章节生成→接触拾取→批量奖励→条件性武器特殊选择；调用链见treasure-chain.json，416条事件见treasure-schedule.json。额外杀怪掉箱未获证据，不能作为既定机制。

## 怪物专题

- 唯一报告：`docs/monsters.html`，含110种主线怪物档案、15类行为、基础属性与抗性、武器/子弹、基础碰撞形状、70章双分支2030波投放。
- 中间数据：`research-data/topics/monsters/`，保留完整305条敌方实体、任务级投放、188个编队、30条路径和必要原生证据；文件与字段说明见目录README。
- 日常查询：`python3 research-data/tools/monster_topic.py monster:320007` / `chapter:19`；独立复算与校验：`rebuild` / `validate`。
- 交接方式：直接使用对应的 `research-data/topics/` 数据与证据目录，以及 `docs/` 中的报告文件，不生成压缩包。

## 策划报告的正式结构

以 `docs/index.html` 为总入口，七个模块并列：局内节奏、怪物与弹幕、三选一/宝箱/进化、章节规划、武器构筑、战机养成、局外循环。策划提要在 `research-data/planner/`，完整规则由 `research-data/tools/planner_details.py` 依据 L2 数据生成，统一执行 `python3 research-data/tools/planner_reports.py`。正文按设计问题、条件与动作、具体案例、设计参考组织，代码和字段解释通过来源链接下沉。全量查表独立放在 `monster-query.html`、`chapter-query.html`、`skill-query.html`，不与正文混排。
