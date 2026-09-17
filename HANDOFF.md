# 远程同事接手

研究目标：拆解《小小远征队》1.0.16 / versionCode 40 的系统和玩法。优先查原始配置、实际原生函数和调用关系。预制体、美术和场景还原不属于当前重点。

## 获取仓库

安装 Git、Git LFS、Python 3.12，然后执行：

```powershell
git lfs install
git clone https://github.com/chitanda233/xxyzd-research.git
cd xxyzd-research
git config core.autocrlf false
git config core.longpaths true
git lfs pull
git lfs fsck --objects
python scripts/check_handoff.py
python scripts/06_gameplay_index.py
python scripts/query_game.py methods WaterfallBattleManager 10
```

使用 GitHub Desktop 克隆也可以。请使用 Git 克隆并拉取 LFS，不依赖网页下载 ZIP 获取全部大文件。LFS 指针以 `version https://git-lfs.github.com/spec/v1` 开头，指针不是实际二进制。

`06_gameplay_index.py` 只依赖 Python 标准库，会生成未提交的 `indexes/research.sqlite`（约 132 MiB）。不用安装资源提取工具，就能查配置和方法地址。

需要继续执行原生分析或资源提取时：

```powershell
python -m pip install --target tools/python -r requirements-research.txt
python scripts/04_native_evidence.py
python scripts/05_decode_tables.py
python scripts/07_verify.py
```

## 从哪里继续

- [系统玩法入口](gameplay/系统玩法入口.md)：按关卡、技能、伤害、掉落、养成导航。
- `restored/configs/tables/`：407 张 JSON 表，共 84,894 行。
- `restored/configs/textassets/`：表的原始二进制，含 23 张尚无匹配结构的表。
- `restored/configs/schemas/`：413 个字段结构、读取函数和 RVA。
- `restored/code/il2cpp/assemblies/` 与 `restored/code/gameplay-structures/`：类、方法、字段结构；空方法体不是恢复出的实现。
- `restored/code/native-evidence/`：关键 ARM64 反汇编及直接调用标注。
- `unpacked/apk/lib/arm64-v8a/libil2cpp.so`：唯一交接的原生逻辑二进制（LFS）。
- `unpacked/apk/assets/bin/Data/Managed/Metadata/global-metadata.dat`：IL2CPP 元数据。
- `indexes/apk-files.json`：每个 APK 条目的 SHA-256 和准确 `extracted_path`。Windows 大小写冲突文件在 `unpacked/case-preserved/`。

建议先追 `WaterfallBattleManager` → 波次配置 → 刷怪配置，以及 `HeroSkillCreator` / `NormalSkillCreator` 的选技能逻辑，再追 `CharacterComponentOnHit` 的伤害路径。类名仅用于定位；业务规则需以代码和配置交叉验证。

## 提交范围

| 文件 | 交接方式 |
|---|---|
| 原始 APK | 不提交；完整解包数据及逐文件哈希已保留 |
| `libil2cpp.so`、`il2cpp.h`、`script.json`、`dump.cs` | Git LFS，保留实际文件名和分析脚本兼容性 |
| `research.sqlite` | 不提交，用 `06_gameplay_index.py` 重建 |
| `unity-objects.jsonl`、`restored/resources/` | 不提交；全量美术对象导出，当前玩法研究不依赖 |
| `tools/` | 不提交；Python 依赖按 requirements 安装 |
| Android 重复资源目录 | 不提交；原始内容已在 `unpacked/`，Java 源文件保留 |
| 未完成 Unity 工程、日志 | 仅保留在最初研究机器 |

`01_unpack_apk.py` 是最初完整解包流程，需要另外提供原始 APK；同事已有 `unpacked/`，无需再执行它。`02_export_unity.py` 可以从已提交的解包资源重新导出对象索引，但这不是日常玩法研究所需步骤。

若需要重新运行外部工具：最初使用 [Il2CppDumper 6.7.46](https://github.com/Perfare/Il2CppDumper/releases/tag/v6.7.46)、[JADX 1.5.6](https://github.com/skylot/jadx/releases/tag/v1.5.6)。目前分析入口已有导出结果，不依赖这些安装包。

## 已知边界

361 张表使用当前 4 字节行头；46 张为通过全表边界验证的旧 2 字节行头布局。不能把表存在等同于当前玩法已启用。定点数同时保留配置值和 Q16 运行值。尚未运行游戏或验证服务端、线上热更新。

GitHub 普通 Git 文件上限为 100 MiB；LFS 单独计入仓库所有者的存储和下载额度。[大小限制](https://docs.github.com/en/repositories/working-with-files/managing-large-files/about-large-files-on-github)、[LFS 额度](https://docs.github.com/en/billing/concepts/product-billing/git-lfs)。
