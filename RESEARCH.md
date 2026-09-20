# 四层研究结构与交接方式

## 唯一入口

- 最终报告：`docs/core.html`（网页正文）。
- 中间数据：`research-data/in-run/`（规则、可计算数据与最小证据）。
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
| L2 中间数据 | `research-data/in-run/` | 让已完成的研究可以检索、计算和复用；每条规则有状态、范围、依据 | 是；含必要配置行与函数摘录 |
| L3 报告 | `docs/core.html` | 给策划讲明单局规则与设计关系，不混入工作日志或分析版本对比 | 是 |

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
python3 research-data/tools/research.py export
```

轻量ZIP包含报告、数据页、样式、L2全部数据与最小摘录、查询/复算工具。接手者解压即可离线读报告和JSON，Python标准库即可校验。不含APK、完整native库、美术、SQLite数据库。独立页面上的外围研究站链接可能仍需联网。

所有L2文件带哈希清单；F编号引用来源ID，来源提供L1原路径、函数RVA或表行键。变更时保留Git提交记录即可，不维护多份相互竞争的“最终分析”。历史研究笔记不是新的事实入口。

## 成本控制

先查询→再计算→最后定向反编译。交接包保存的不只是结论，还包含推导所需输入和最小证据，避免下一位同事重复购买同一次分析成本。对已验证规则只在版本变化、出现反证或任务需要更精确结论时复核。

## 三选一与武器进化专题

- 唯一专题报告：`docs/choices-box-evolution.html`。
- 结构化数据：`research-data/topics/choices-box-evolution/`（规则、71章权重映射、22条配方、常量、证据和未闭合断点）。
- 校验：`python3 research-data/tools/choice_topic.py validate`。
- 宝箱怪按“击杀→拾取物→三选一”定义，目前身份链未闭合；中途商店未确认，停止扩大搜索。不要用Punchboard或传统两结果Box替代。
