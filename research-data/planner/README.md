# 策划反拆正文与来源

七份模块 JSON 是唯一正式正文源，渲染为 docs/ 中的七个并列策划模块。每节区分运行规则、配置规则、策划归纳和设计参考；使用条件、系统动作、玩家结果及具体案例组织。

- 日常修改正文：编辑对应模块 JSON，再运行 `python3 research-data/tools/planner_reports.py`。
- 校验：`python3 research-data/tools/planner_reports.py validate`。
- 证据优先复用 `../in-run/` 与 `../topics/`，通过 refs 直接引用；不复制反编译工程。
- `inputs/` 补充战机与局外系统所需的最小配置，`sources.json` 记录原始路径、选取范围和哈希。
- 查询层：docs/monster-query.html、chapter-query.html、skill-query.html；全量档案不进入正文。
- 设计参考是根据已知规则提出的方案，不作为游戏现有实现。
- 数据按目录交接，不打包。manifest.json 为本目录文件哈希。
