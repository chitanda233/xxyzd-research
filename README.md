# 小小远征队：策划与玩法研究

研究基线：`com.fhzj.game` · 客户端1.0.16 · versionCode 40。

- **正式报告：[局内整体链路策划报告](docs/core.html)**；[在线阅读](https://chitanda233.github.io/xxyzd-research/core.html)。
- **中间数据：[research-data/in-run](research-data/in-run/)**；[网页查阅](docs/research-data.html)。
- **研究结构与交接：[RESEARCH.md](RESEARCH.md)**。
- **底层导航：[系统玩法入口](gameplay/系统玩法入口.md)**，仅需深查时使用。

日常分析从中间数据开始，不要求APK、完整反编译工程或SQLite数据库。包内保存相关配置行、最小函数摘录、规则、波次与技能关系，以及版本和哈希。

```sh
python3 research-data/tools/research.py query 复活
python3 research-data/tools/research.py query wave:10
python3 research-data/tools/research.py validate
python3 research-data/tools/research.py export
```

四层职责：APK/解包原件 → 配置解码与原生实现 → 可复用中间数据 → 策划报告。原件和底层路径保持不动，避免破坏可追溯性。正式报告、波次计算器与局内数据入口各保留一套。

本基线为客户端静态研究，非_B基础配置不自动代表线上分流；热更新、实际开放、服务端到账及实机体验需要相应证据。结构声明的空方法体不是恢复出的实现。
