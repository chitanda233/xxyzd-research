# 数据字典与证据约定

所有JSON使用UTF-8。数组顺序有意义时不得自动重排；ID通常为整数，`composition`的JSON键为十进制ID字符串。`null`表示不适用或未知，绝不等同0。

## 基线

`baseline.json`：`dataset_id`为不可混用的基线标识；`apk_sha256`标识源APK；`scope`限定第一章、非_B基础配置、静态实现。所有规则继承此基线。线上实际分流没有验证。

## 规则 facts.json

| 字段 | 类型 | 语义 |
|---|---|---|
| id | string | 稳定规则编号F01…；供报告、流程和问题引用 |
| topic / report_anchor | string | 报告章节锚点 |
| status | enum | verified_static=静态证据确认；designed_only=有设计配置但未证实启用；interpretation=策划解释 |
| statement | string | 自包含规则，不记录分析过程或版本争论 |
| parameters | object | 已核对的机器可读参数；权重与概率不得混用 |
| source_ids | string[] | 必须可在sources.json解析 |
| applies_to | string | 本规则具体范围 |
| limitations | string[] | 不允许由规则外推的结论 |

verified_static只表示静态实现与配置范围，不等于live verified。问题不混入事实枚举，集中在questions.json。

## 来源 sources.json

| 字段 | 含义 |
|---|---|
| id | T:表名 或 N:函数别名 |
| kind | config_rows / native_excerpt |
| path | 相对本数据集根目录，可离线读取 |
| sha256 | 包内快照/摘录的指纹 |
| row_key / row_ids / record_count | 精确行键、所保留行、行数 |
| method / rva | 原生方法全名与ARM64地址 |
| origin.path / origin.sha256 | L1原文件路径及指纹，深查才需要 |
| origin.raw_path / raw_sha256 / layout | 原始表位置、指纹和解码布局；仅配置来源 |
| scope | 原生导出/热更/间接调用边界 |

来源定位到函数或配置行，不用“某个目录存在”作为证据。已解析的字符串注释是地址映射，不自动证明数据流。函数摘录沿用原导出的下一已知地址边界与16000字节上限。

## 逐波 datasets/chapter-1.json

| 字段 | 单位与语义 |
|---|---|
| script_start_seconds / next_script_start_seconds | 配置脚本秒；不是玩家墙钟时间 |
| nominal_window_seconds | 相邻波脚本起点差；末波null，不估计Boss耗时 |
| configured_monster_count | 配置刷新总数；硬门槛波可能提前截断 |
| count_semantics | 普通配置数 / 脚本最大数量，不表示实战必出 |
| composition | 实体ID→配置数量 |
| death_gate / special_entities | 是否需特殊目标死亡 / 目标ID |
| experience_budget | 波总经验预算，与静态怪物exp之和不同 |
| cumulative_experience / level_threshold | 截至该波的累计预算与对应等级阈值 |
| ordinary_growth_node | 是否配置普通波末升级UI，不表示必定只升级一次 |
| events | 刷新与阶段任务明细，保留mission_id、source_ref、脚本时间 |
| events.source_ref.entry_index | 位置组flushPool内的零基序号 |
| events.source_ref.row_ids | 随机候选配置ID列表；数量由F03解释 |

规则：`numberRandom`是总目标怪量，不是“池数×组大小×抽取次数”。当前包只支持随机候选实体集合单一的精确计算；混合实体池会报错，要求补充概率模型，不输出猜测组合。时间计算使用配置decimal；完整Q16运行值仍在inputs里。

## 技能 datasets/skill-build.json

- `pools`：四类配置池的入口ID；count是配置行数。
- `nodes`：相关技能及依赖闭包。name是语言映射；description_template与description_args分开，未伪造最终游戏文案。
- `edges`：保留原字段名为relation。NextSkill是升级后继、CoverSkill是覆盖节点、UpgradeSkillId是候选分支；Need/Reject/Pre关系不应一律解释成升级。
- `recipes`：owner_skill + required_skill → result_skill，来自同一配置行的平行数组。双向配方可分别出现；它表示依赖关系，不保证候选一定生成。
- `target_in_dataset=false`：目标不在此包，不允许当成不存在。
- `_B`变体保留在输入快照，当前派生图只取基础列。

## 流程与缺口

`flow.json`是策划关系图，不冒充客户端原始状态机；每条edge含条件和fact_ids。`questions.json`记录问题、关联F编号、已查范围、所需新证据、影响及重开条件。只有新证据或具体任务确实需要，才继续底层研究。

## 校验范围

工具检查快照哈希、清单完整性、引用完整性、数据精确复算、15波经验、14个成长节点、3次阶段事件、怪量和池数量等。它不自动证明ARM64人工解释正确，不代替线上行为验证。
