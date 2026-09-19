# 结构化研究数据

默认从本目录继续分析。唯一正式报告是 `docs/core.html`；唯一局内数据集是 `in-run/`。已有规则不需要重新反编译。

## 阅读顺序

1. `in-run/baseline.json`：版本、APK指纹、基础分支与适用范围。
2. `in-run/facts.json`：25条规则；固定F编号、状态、参数、适用范围和来源。
3. `in-run/datasets/chapter-1.json`：逐波与逐事件数据。
4. `in-run/datasets/skill-build.json`：技能节点、配置边、突破配方。
5. `in-run/questions.json`：只有任务触及这些缺口时才安排深查。
6. 需要核查时按 `sources.json` 定位 `inputs/` 配置快照或 `evidence/` 函数摘录。

`inputs/`包含报告相关配置的完整原始行（保留定点数与_B列），不是全包表。`evidence/`仅包含支持本报告规则的函数，不是完整反编译工程。二者都是轻量中间层的一部分。

## 不依赖源码的操作

在交接包根目录使用Python 3.9+，无需安装第三方库：

```sh
python3 research-data/tools/research.py validate
python3 research-data/tools/research.py query wave:10
python3 research-data/tools/research.py query skill:10000103
python3 research-data/tools/research.py query 复活
python3 research-data/tools/research.py query F12
```

查询结论会一并返回其来源和未决问题。派生数据可从包内输入重建：

```sh
python3 research-data/tools/research.py rebuild
python3 research-data/tools/render.py
python3 research-data/tools/research.py export
```

`rebuild`只使用已批准快照，不访问APK、不联网。`render.py`生成数据阅览页并更新正式报告的逐波表。正文其余部分仍由研究者编写。

## 更新规则

- 改表或获得新版本：在完整研究仓库运行 `python3 research-data/tools/import_sources.py` 明确重新提取快照，然后审查来源差异。此工具是底层导入入口，不是日常查询步骤。
- 不得为通过校验而盲目改哈希；快照或证据变更必须复核所有引用它的F编号。
- 参数、适用条件或解释变更，更新 `facts.json`；如果证据不足，记录到 `questions.json`，不得升级成已证实。
- 不同APK或_B分支使用新的dataset_id与独立数据目录，不覆盖本基线。
- 中间数据变更后依次 `rebuild → render → validate → export`；发布 `docs` 并同步对应数据版本。
- `manifest.json`记录全部L2文件的SHA-256；数据字典见 `in-run/DICTIONARY.md`。
