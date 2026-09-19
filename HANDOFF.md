# 交接入口

直接交付轻量ZIP即可开展局内分析。结构与维护规则见 [RESEARCH.md](RESEARCH.md)。

1. 阅读 `docs/core.html`。
2. 查询 `research-data/in-run/facts.json` 与 `datasets/`。
3. 从 `sources.json` 读取对应包内配置行或函数摘录。
4. 查看 `questions.json` 确认已有查证范围；只有任务需要该缺口时才继续深查。

无需APK或反编译环境的校验：

```sh
python3 research-data/tools/research.py validate
```

只有需要完整底层材料时才克隆仓库并执行Git LFS拉取。LFS指针不是二进制：真实库为 `unpacked/apk/lib/arm64-v8a/libil2cpp.so`，元数据为 `unpacked/apk/assets/bin/Data/Managed/Metadata/global-metadata.dat`。

完整仓库的原生分析依赖见 `requirements-research.txt`；原生导出入口为 `scripts/04_native_evidence.py`。日常报告调整、查询与数据复算不执行该脚本。

中间数据更新后的交付命令：

```sh
python3 research-data/tools/research.py rebuild
python3 research-data/tools/render.py
python3 research-data/tools/research.py validate
python3 research-data/tools/research.py export
```
