# 怪物专题：中间数据入口

适用：com.fhzj.game，客户端1.0.16。静态主线70章、基础/B双分支；不保证线上开放与热更新一致。

- `catalog.json.gz`：305条敌方实体完整属性；mainline=true的110条进入脚本分布，含中文名、能力、AI参数、武器/子弹关联和名义属性区间。
- `occurrences.json.gz`：20496条非宝箱任务行。chapter/branch/wave/mission定位；routes保留每种编队候选，counts是逐种数量上下界，total是独立计算的总量上下界。**不同怪的边界不一定同时成立，不能相加当总量**。
- `chapters.json`、`waves.json`：140章分支和2030波投放汇总；数量为脚本预算，排除动态召唤、宝箱、隐藏9999。
- `maps.json`：188个被主线引用的模板，坐标/旋转/延迟来自完整读取验证过的地图二进制。
- `weapons.json`、`bullets.json`、`links.json`：117武器、89子弹和显式关联；包含后续触发武器。配置关联不保证每条运行时触发。
- `inputs/`：完整22张表、中文词典、版本基线、30条烘焙路径、编队快照。保留定点原始字段；计算展示使用解码十进制，可能有定点舍入误差。
- `evidence/`、`sources.json`：最小原生方法摘录、原始路径及SHA-256。C#空方法体不是实现证据。
- `facts.json`：结论→证据；`questions.json`：具体边界和继续研究入口；`manifest.json`：包内哈希。

离线命令（只需Python标准库）：
```
python3 research-data/tools/monster_topic.py validate
python3 research-data/tools/monster_topic.py monster:320007
python3 research-data/tools/monster_topic.py chapter:19
python3 research-data/tools/monster_topic.py rebuild
python3 research-data/tools/monster_topic.py render
```
`snapshot`才需要L1；日常rebuild/render/query不需要APK。先读报告，再查上述数据，仅在questions所列需求出现时定向下挖。
