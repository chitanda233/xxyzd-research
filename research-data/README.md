# 研究数据与证据目录

本目录是可直接浏览、查询和移交的中间层，不生成压缩包。正式报告位于 `../docs/`，总入口为 `../docs/index.html`。各策划专题并列，局内链路只是其中一个模块。

| 模块 | 数据与证据目录 |
|---|---|
| 局内整体链路 | [in-run/](in-run/) |
| 三选一、宝箱与武器进化 | [topics/choices-box-evolution/](topics/choices-box-evolution/) |
| 章节规划 | [topics/chapter-planning/](topics/chapter-planning/) |
| 怪物与弹幕 | [topics/monsters/](topics/monsters/) |

每个模块先读 README 和 facts.json，再按 sources.json 或结论中的 evidence 路径查看 inputs/ 配置快照及 evidence/ 原生函数摘录。questions.json 保存未闭合的问题，manifest.json 保存文件指纹。专题派生表直接留在对应目录。

最新主线宝箱分析：[结构化结论](topics/choices-box-evolution/mainline-chest-pool.json)。

## 研究层级

- L0：APK 原始材料，版本与指纹见各模块 baseline.json。
- L1：`../restored/` 和底层反编译材料，仅在中间层不足时定向追查。
- L2：本目录，保存可复用结论、数据、来源索引和最小证据。
- L3：`../docs/`，保存策划报告和查表页面。

移交时直接交付 research-data/ 与 docs/ 两个目录，保留相对路径。无需重复提供 APK 或完整反编译工程。

## 查询与更新

在仓库根目录运行：

```sh
python3 research-data/tools/research.py query F12
python3 research-data/tools/research.py validate
python3 research-data/tools/monster_topic.py monster:330017
python3 research-data/tools/chapter_topic.py chapter:55
```

更新数据后执行对应模块的 rebuild、render、validate；不执行打包。新增证据放进所属专题的 evidence/，补充来源与适用范围；没有证据的结论保留未确认状态。只有需要新方法或新版本时才深入 L1/L0。

## 策划正文维护

七个策划模块的正文源在 [planner/](planner/README.md)，以条件、系统动作、玩家结果和设计参考组织。统一渲染：`python3 research-data/tools/planner_reports.py`。怪物、章节和技能全量数据保留在独立查询工具。
