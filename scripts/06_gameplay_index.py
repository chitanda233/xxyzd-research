from pathlib import Path
import json, re, collections, sqlite3
ROOT = Path(__file__).resolve().parents[1]
TABLES = ROOT / 'restored/configs/tables'
OUT = ROOT / 'gameplay'
OUT.mkdir(exist_ok=True)

def read_table(name):
    return json.loads((TABLES/(name+'.json')).read_text(encoding='utf-8'))

def simple(value):
    if isinstance(value,dict):
        if 'fp_raw' in value:
            return value['decimal']
        return {k:simple(v) for k,v in value.items()}
    if isinstance(value,list):
        return [simple(v) for v in value]
    return value

def save(name,value):
    (OUT/name).write_text(json.dumps(value,ensure_ascii=False,indent=2),encoding='utf-8', newline="\n")

def main():
    configs=json.loads((ROOT/'indexes/config-tables.json').read_text(encoding='utf-8'))
    domains=[
        ('关卡与刷怪',r'^(Chapter|Mission|MonsterAI)', ['WaterfallBattleManager','BaseSurvivalBattleManager','BeeMonsterCreator','BeeMonsterRefresher']),
        ('技能与随机选牌',r'^(Skill|BattleMain_skill)', ['HeroSkillCreator','SinglePlayerSkillCreator','NormalSkillCreator','HeroComponentRandomSkill','WeightRandom']),
        ('伤害与怪物行为',r'^(Character|Weapon|Bullet|Buff|Attribute)', ['CharacterComponentOnHit','CharacterComponentBuff','EntityMonster']),
        ('掉落与奖励',r'^(Drop|Item|ChapterReward|DrawBox)', ['MainDropManager','DropMgr']),
        ('角色装备与养成',r'^(Role|Equipment|Rune|Talent|Drone|Pilot|AirplaneGun|Collection|UltimateCore|Card)', []),
        ('商店与付费',r'^(Shop|IAP|Pay|VIP|Recharge|BattlePass)', []),
        ('公会竞技与多人',r'^(Guild|CrossArena|Arena|WorldBoss|Rank|Multi)', ['WaterfallMultiBattleManager','GuildBossBattleManager','WorldBossBattleManager']),
        ('活动任务与解锁',r'^(Event|Task|Calendar|Function|Guide|Activity|Achievement)', []),
    ]
    mapping=[]
    for label,pattern,classes in domains:
        mapping.append({'system':label,'classification':'Navigation candidates from names; not proof of runtime activation','tables':[x for x in configs if re.search(pattern,x['name'])],'entry_classes':classes})
    save('systems-index.json',mapping)
    lines=['# 系统和玩法入口','', '这是当前 APK 的静态研究索引。模块按名称归类；具体是否启用、服务端控制项和运行时调用路径仍需逐项验证。','', '| 方向 | 配置入口 | 代码入口 |','|---|---|---|']
    for d in mapping:
        decoded=[x for x in d['tables'] if x['status']=='decoded']
        links=', '.join(f'[{x["name"]}](../{x["output"]})' for x in decoded[:3])
        lines.append(f'| {d["system"]} | {links}（{len(decoded)} 张可读表） | '+', '.join('`'+x+'`' for x in d['entry_classes'])+' |')
    lines+=['', '全部表名、行数、解码状态和原文件位置见 [配置索引](../indexes/config-tables.json)。', '', '核心原生方法见 [native-evidence](../restored/code/native-evidence)。`.asm` 为 ARM64 反汇编，分支调用附带已知函数名；程序集 `.cs` 是结构声明，空方法体不是原始实现。', '', '## 已整理的便捷数据', '', '- [主线章节](chapters-readable.json)：字段保留，FP 简化为配置十进制值，附中文标题。', '- [技能目录](skills-readable.json)：原技能字段，附中文名称和说明文本；描述占位符未替换。', '- [怪物及角色实体](characters-readable.json)：保留实体 ID、属性、AI 参数等。', '', '这些便捷数据不覆盖原始表。精确定点运行值及原始整数见 `restored/configs/tables`。A/B 字段只保留原名，暂不推断其业务含义。']
    (OUT/'系统玩法入口.md').write_text('\n'.join(lines)+'\n',encoding='utf-8', newline="\n")
    language={str(x['id']):x.get('chinesesimplified','') for x in read_table('Language_languagetable')}
    chapters=simple(read_table('Chapter_MainChapter'))
    for row in chapters:
        row['_中文标题']=language.get(str(row.get('chapterNameLanguageId','')),'')
    save('chapters-readable.json',chapters)
    skills=simple(read_table('Skill_Main'))
    for row in skills:
        row['_中文名称']=language.get(str(row.get('LanguageNameId','')),'')
        row['_中文说明模板']=language.get(str(row.get('LanguageInfoId','')),'')
    save('skills-readable.json',skills)
    save('characters-readable.json',simple(read_table('Character_entity')))
    # Searchable offline database: native method names/addresses and table provenance.
    connection=sqlite3.connect(ROOT/'indexes/research.sqlite')
    connection.executescript('CREATE TABLE IF NOT EXISTS methods(name TEXT,address INTEGER,signature TEXT); DELETE FROM methods; CREATE TABLE IF NOT EXISTS tables(name TEXT,status TEXT,row_count INTEGER,source TEXT,output TEXT); DELETE FROM tables;')
    methods=json.loads((ROOT/'restored/code/il2cpp/script.json').read_text())['ScriptMethod']
    connection.executemany('INSERT INTO methods VALUES (?,?,?)',((m['Name'],m['Address'],m.get('Signature','')) for m in methods))
    connection.executemany('INSERT INTO tables VALUES (?,?,?,?,?)',((t['name'],t['status'],t.get('rows'),t['source'],t.get('output')) for t in configs))
    connection.execute('CREATE INDEX IF NOT EXISTS methods_name ON methods(name)')
    connection.commit()
    connection.close()
    # Separate core class declarations so users do not need to search huge dump.cs.
    desired=set(c for d in mapping for c in d['entry_classes'])
    folder=ROOT/'restored/code/gameplay-structures'
    folder.mkdir(exist_ok=True)
    for file in (ROOT/'restored/code/il2cpp/assemblies').glob('HotFix*.cs'):
        for part in re.split(r'(?=^// Namespace:)',file.read_text(encoding='utf-8'),flags=re.M):
            match=re.search(r'^(?:public|internal|private)(?: abstract| sealed| static)* class (\w+)\s*:',part,re.M)
            if match and match.group(1) in desired:
                (folder/(match.group(1)+'.cs')).write_text('// Structure only. Read corresponding native-evidence .asm for real implementation.\n'+part,encoding='utf-8', newline="\n")
    print(json.dumps({'chapters':len(chapters),'skills':len(skills),'methods_indexed':len(methods),'system_groups':len(mapping)},ensure_ascii=False))

if __name__=='__main__':
    main()
