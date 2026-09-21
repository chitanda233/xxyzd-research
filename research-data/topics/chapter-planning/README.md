# 章节规划专题（客户端1.0.16）

报告：`docs/chapter-planning.html`。范围：1—70章，基础/B双分支；隐藏9999保留但排除在正式统计外。

- `chapters.json`：71条章节汇总，每条包含基础/B参数。
- `waves.json`：2032条章节/分支/波次记录，含原波次ID与任务ID、时点、经验、门槛、属性、宝箱事件。
- `branch-differences.json`：排除ID前缀后的任务与波次字段差异；按任务前缀内升序记录对齐。
- `facts.json`：配置事实与策划解读分开标记，引用输入和方法证据。
- `inputs/`：完整必要配置表、已验证技能权重与规则、版本基线。大型JSON采用标准gzip压缩；工具自动读取，解压后可直接分析，不需要APK。
- `evidence/`：定向方法摘录，保留RVA和全局字段注释；间接调用及线上热更不视为已经验证。
- `sources.json`：每份输入的原始路径、来源哈希与选取方式。
- `questions.json`：缺口、已查范围与继续条件。
- `manifest.json`：本专题全部输入/产物哈希。

使用Python标准库即可执行：

```sh
python3 research-data/tools/chapter_topic.py validate
python3 research-data/tools/chapter_topic.py chapter:55
python3 research-data/tools/chapter_topic.py rebuild
python3 research-data/tools/chapter_topic.py render
python3 research-data/tools/chapter_topic.py export
```

`snapshot`只用于从本机L1更新输入；移交者通常不需要执行。`rebuild`由包内输入复算所有对照数据。`validate`检查哈希、引用、重算结果和关键分布。

口径：任务行数不是怪物数；终波起点不是通关时间；倍率不是最终血量或实测难度；相对权重不是最终展示概率；配置存在不是线上已开放。
