# 小小远征队：系统与玩法研究

研究对象：`com.fhzj.game`，客户端 1.0.16，versionCode 40。工作重点是系统、玩法、配置及客户端逻辑。原 APK 保留在上级目录，同时保存了一份 SHA-256 一致的副本。

**从 [系统玩法入口](gameplay/系统玩法入口.md) 开始。**

**远程同事请先看 [交接与环境恢复说明](HANDOFF.md)。** GitHub 提交的是玩法研究交接集；原始 APK、工具安装包、美术批量导出和可重建数据库仅保留本地。下文目录和扫描统计描述最初完整工作区，不代表这些文件都随仓库下载。

| 目录 | 用途 |
|---|---|
| `original/` | 原 APK 副本 |
| `unpacked/apk/` | APK 解包工作目录 |
| `unpacked/case-preserved/` | Windows 大小写冲突文件的逐项原样保存 |
| `restored/configs/textassets/` | TextAsset 原始内容，包括二进制表 |
| `restored/configs/tables/` | 407 张可读 JSON 配置表 |
| `restored/configs/schemas/` | 413 个表结构及原生读取函数信息 |
| `restored/code/il2cpp/assemblies/` | 按 146 个程序集拆开的 C# 结构声明 |
| `restored/code/gameplay-structures/` | 核心玩法类的独立结构文件 |
| `restored/code/native-evidence/` | 1,482 个所选函数的 ARM64 原生反汇编与调用标注 |
| `restored/code/android/` | Android 清单、Java 反编译结果及资源 |
| `gameplay/` | 系统导航、中文技能和章节便捷数据 |
| `indexes/` | 文件哈希、配置、类型、方法地址、校验结果及查询数据库 |
| `scripts/` | 可复现解包、导出、解码与验证脚本 |
| `logs/`、`tools/` | 操作日志和本地分析工具 |

## 当前结果与证据边界

- APK 中 2,613 个文件已按清单逐一验证 SHA-256。243 个条目存在大小写冲突，准确提取路径请以 `indexes/apk-files.json` 的 `extracted_path` 为准；不要把工作目录中同名文件当作完整档案。
- 本地表资源共 430 张：407 张解码成功，共 84,894 行；23 张没有匹配的当前 Bean 结构，原始内容已保留，详见 `indexes/config-decode-summary.json`。
- 407 张中，361 张使用当前客户端的 4 字节行头；46 张使用 2 字节行头，属于按全表边界验证的旧布局推断，不能据此认定当前运行时正在加载它们。表的 `layout` 已明确标记。
- 413 个结构的读取顺序和字段写入偏移均通过原生指令核对。每张已输出表均通过逐行长度、文件末尾和 JSON 行数检查。
- FP 数值同时保留原始整数、除以 10,000 的配置十进制数，以及客户端截断后的 Q16 原始值和运行值。便捷数据仅展示配置十进制数。
- `Chapter_MainChapter` 有 71 条，`Skill_Main` 有 1,184 条，`Character_entity` 有 348 条。它们是静态配置行数，不等于已开放关卡、可用技能或怪物种类数量。
- `dump.cs`、DummyDll 和分程序集 `.cs` 恢复的是结构及地址，方法体为空壳，不是完整 C# 源码。`native-evidence` 来自真实二进制；范围取下一已知方法地址，单函数最多 16,000 字节，间接调用尚未全部解析。
- 热更新快照中的两个 `.dll` TextAsset 实际仅有单字节 `1`，不是可反编译的热更新程序集。真实已编译逻辑见 `libil2cpp.so`。
- JADX 输出 14,798 个 Java 文件，日志报告 101 个反编译错误；不能称为 Android 层无损源码恢复。游戏核心在 IL2CPP 层。
- Unity 全包对象扫描已完成；`unity_app_guid` 是标识文件，不是序列化资源，扫描器对此记录了一个非资源输入提示。`unity-objects.jsonl` 以输入文件为单位记录，分片自动拼接可能造成重复记录，不用它的总数代表唯一资源数量。
- 用户已明确以系统和玩法为重点。Unity 工程及图片导出已停止，先前产物保留在 `restored/unity-project` 和 `restored/resources`；工程是不完整的，不作为本轮交付入口。
- 未运行游戏、未修改客户端、未下载线上热更新；服务端规则和线上当前内容尚未验证。

## 查询

在本目录运行：

```powershell
python scripts/query_game.py tables Chapter
python scripts/query_game.py methods WaterfallBattleManager 20
python scripts/query_game.py methods CharacterComponentOnHit 20
```

`indexes/research.sqlite` 收录 371,307 条方法记录（含泛型实例，非唯一逻辑方法数量），可通过名称查 RVA 和签名。

工具来源：[Il2CppDumper](https://github.com/Perfare/Il2CppDumper)、[UnityPy](https://github.com/K0lb3/UnityPy)、[JADX](https://github.com/skylot/jadx)、[AssetRipper](https://github.com/AssetRipper/AssetRipper)。各工具输出的能力与限制以上述实际结果为准。
