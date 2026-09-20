# 三选一、宝箱怪与武器进化专题数据

正式报告：`docs/choices-box-evolution.html`。本目录是可独立移交的 L2；已证实与未闭合结论在 facts.json 分开，勿删除 limitations。

- `facts.json`：规则、适用范围、证据路径和限制。
- `chapters.json`：71章技能模式、权重组、新手保护开关。
- `pool-weights.json`：初始/常规技能入口及10组权重，含中文名。
- `evolution-recipes.json`：对称配置去重后的配方、候选权重与二次选项。
- `constants.json`、`probability-examples.json`：常量与带前提概率示例。
- `questions.json`：已查范围、断点、下一份所需证据。商店当前停止扩大搜索。
- `inputs/`：最小配置快照及常量字节哈希恢复结果。
- `evidence/`：定向函数摘录、RVA和直接交叉引用。
- `sources.json`、`manifest.json`：来源和内容哈希。

层级：L0 APK指纹见baseline.json → L1配置与反编译 → L2本目录 → L3唯一专题HTML报告。正常分析直接读L2，不重跑APK。需要补缺口时才使用 scripts/export-choice-topic.py 和 scripts/extract-topic-constant-arrays.py。

离线检查：`python3 research-data/tools/choice_topic.py validate`；查配方：`python3 research-data/tools/choice_topic.py skill:10000103`；查规则：`python3 research-data/tools/choice_topic.py C05`。

直接B/BL交叉引用不覆盖虚调用、内联或hotfix；“未找到”不是不存在的证明。原始Skill_Main拼写UnlockUpgradeNeddSkill保留。所有概率均为静态条件模型，非玩家实测频率。
