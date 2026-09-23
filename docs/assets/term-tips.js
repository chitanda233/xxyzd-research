(() => {
  if (!document.querySelector('link[href$="term-tips.css"]')) {
    const stylesheet = document.createElement("link");
    stylesheet.rel = "stylesheet";
    stylesheet.href = "assets/term-tips.css";
    document.head.append(stylesheet);
  }
  const glossary = {
    "HP": "基础生命",
    "Attack": "基础攻击",
    "BodyAttack": "接触攻击",
    "MoveSpeed": "移动速度",
    "AttackDistance": "攻击距离参数",
    "BulletLifeRange": "子弹距离参数",
    "Shape": "碰撞形状",
    "ModelScale": "模型缩放",
    "WaveAIId": "主线行为类",
    "WaveAIParameters": "主线行为参数",
    "AIId": "常规行为类",
    "AIParameters": "常规行为参数",
    "WeaponID": "直接武器",
    "MonsterAbility": "能力与抗性",
    "MonsterTraitID": "特殊词缀",
    "bornType": "出生类型",
    "bornParameters": "出生参数",
    "WaveleaveType": "主线离场类型",
    "WaveleaveParameters": "主线离场参数",
    "deathClassId": "死亡处理类型",
    "deathParams": "死亡参数",
    "MinBulletHurtTime": "同目标重复伤害间隔",
    "LifeTime": "子弹寿命",
    "Scale": "表内缩放值，未合成为碰撞缩放",
    "hurtAttributes": "伤害表达式",
    "ShapeOffset": "碰撞偏移",
    "Trajectory": "弹道类型",
    "TrajectoryParams": "弹道参数",
    "FireCD": "通用射击冷却字段，不替代AI间隔",
    "FireHoldTime": "弹道蓄力参数",
    "fireInterval": "AI循环射击间隔",
    "fireDelay": "AI射击延迟",
    "PathId": "路径资源编号",
    "WeaponSalvoMod": "齐射修饰器",
    "FollowMod": "追踪修饰器",
    "WeaponFireOnDeadMod": "死亡时触发后续武器",
    "ThroughMod": "穿透修饰器",
    "MinZs": "各武器动作纵向下界参数",
    "MaxZs": "各武器动作纵向上界参数",
    "nextPointX": "两点运动横向参数",
    "nextPointZ": "两点运动纵向参数",
    "needAttack": "是否启用攻击任务",
    "DeathOnFinish": "路径结束死亡参数",
    "IsLoop": "路径循环参数",
    "IsLoopSelf": "自身循环参数",
    "Behaviour": "运动任务及其参数字符串",
    "CallCDTime": "召唤动作冷却参数",
    "CallMonsterWeight": "召唤动作相对权重，不能直接解释为百分比",
    "CallMonsters": "召唤对象及时间参数",
    "FollowSpeedScale": "追随速度倍率",
    "IsIgnoreLaserWarning": "是否忽略激光预警",
    "OriginAngle": "初始运动角度",
    "RushSpeed": "冲刺速度",
    "SecondMoveIsRotateToTarget": "第二段移动是否朝向目标",
    "SecondMoveSpeedScale": "第二段移动速度倍率",
    "SelfRotateSpeed": "自身旋转速度",
    "ShadowFadeTime": "影子淡出时间",
    "ShowShadow": "影子显示开关",
    "WaitTimeMax": "最长等待时间",
    "WaitTimeMin": "最短等待时间",
    "WarnTime": "预警时间",
    "WarningDir": "预警方向类型",
    "WeaponMoveTypes": "各武器动作的移动类型",
    "fireDirectionX": "射击方向横向分量",
    "fireDirectionZ": "射击方向纵向分量",
    "isLoop": "循环参数",
    "isSelfRotate": "是否自转",
    "nextPointOffsetX": "目标点横向偏移",
    "nextPointOffsetZ": "目标点纵向偏移",
    "noFindTarget": "不主动查找目标参数",
    "rotateSpeed": "旋转速度",
    "weaponWeights": "武器选择的相对权重",
    "WeaponWeights": "武器选择的相对权重",
    "Count": "数量参数，具体含义取决于所在修饰器",
    "TotalAngle": "齐射分配总角度",
    "StartAngle": "齐射起始角度",
    "RotateSpeed": "转向速度参数",
    "CallMonsterId": "被召唤的怪物实体ID",
    "TotalDuration": "召唤持续时间",
    "MinInterval": "召唤最小间隔",
    "MaxInterval": "召唤最大间隔",
    "CallAIType": "召唤怪的行为类型",
    "FireDamageAddToSelf%": "自身承受火伤增加百分比",
    "IceDamageResist%": "冰属性伤害抗性百分比",
    "AttackTime": "离场攻击持续参数，须先确认离场类型启用",
    "Duration": "持续时间",
    "Parallel": "并行执行参数",
    "RandomEdge": "随机边缘出生参数",
    "ExplosionEffectId": "死亡爆炸表现特效编号",
    "ThroughCount": "可穿透次数",
    "ScaleAnimMod": "缩放动画修饰器",
    "StartScale": "初始缩放",
    "TargetScale": "目标缩放",
    "ScaleTime": "缩放耗时",
    "FireOnDeadMod": "死亡触发射击修饰器",
    "MoveStraight": "直线弹道",
    "Laser": "激光弹道",
    "numberRandom": "随机路线实际目标生成数量，最后一个候选编队会截断",
    "missionPool": "实际位置编队的模板名候选列表",
    "Monster": "替换模板成员的怪物候选ID",
    "flushPool": "组合编队子项列表",
    "Delay": "子编队延迟",
    "interval": "重复次数与重复间隔",
    "effects": "实际属性效果表达式",
    "Type": "实体类型或子弹类型，取决于所在配置表",
    "leaveType": "离场逻辑类型，0表示未启用",
    "SkillGroupWeight": "章节选择技能权重列的编号：0取默认Weight，非0取相应Weight_n。",
    "NewPlayerProtect": "章节保护代码列表。当前主线第2—10章含3，仍需满足本局构筑条件才触发增权。",
    "ProtectTemplate": "章节引用的血量保护模板编号；当前四个模板所有倍率均为1。",
    "HpRate": "血量倍率。当前保护模板的10档均为1，没有配置降血量幅度。",
    "mapStyle": "地图样式配置ID；相同ID表示复用同一配置，不代表关卡敌人和数值相同。",
    "NewMonsters": "章节新怪展示标记列表，不能替代实际刷怪任务表。",
    "SuggestedSkills": "章节界面的推荐技能列表，不保证随机抽中这些技能。",
    "SuggestedFunction": "章节推荐功能代码列表；具体功能名需要对应定义才能解释。",
    "randomMonster": "任务可以抽取的怪物组ID数组；一项代表一个组，不一定只有一只怪。",
    "entityId": "怪物组包含的实体ID列表。",
    "CreateRandomMonster": "把缓存的怪物组选择转成实际生成计划，并处理成员位置的方法。",
    "Mission_RandomMonsterFlushConfig": "随机刷新怪物组配置。其weight/height字段在已查路径中用于队形坐标。",
    "weight": "此处特指随机怪物组的小写weight字段，参与成员横向坐标计算；不同于技能大写Weight。",
    "height": "随机怪物组中参与另一轴成员坐标计算的字段。",
    "hpUpgrade": "血量相关配置倍率。最终怪物生命还涉及其他层的属性与计算。",
    "attackUp": "攻击相关倍率；本版本章节层值均为1，波次层有独立数值，需要区分配置层级。",
    "ResurrectionTimes": "章节复活相关配置值；实际可复活资格与次数还需结合完整复活流程。",
    "skill3SelectCreditsRandom": "章节中的旧命名随机数组，当前证据不足以把它视为主线三选一概率。",
    "A/B": "A/B 分流：同一功能的两套配置或实现，用于对照实验；报告中的 _B 表示 B 分支。",
    "_B": "B 分支字段或实现。它代表配置分流，不等同于老玩家版本。",
    "APK": "Android 安装包。本报告以客户端 1.0.16 的 APK 静态内容为研究基线。",
    "NPC": "非玩家角色。主线宝箱在代码中属于可交互 NPC，而不是普通掉落物。",
    "SkillType": "章节配置的技能系统类型。主线值为 2，对应 DankeSkillCreator。",
    "DankeSkillCreator": "主线局内构筑的专用技能候选生成器。",
    "GetNormalSkill": "生成一次普通技能候选的主流程。",
    "GetRandomSkills": "从当前合法候选池按类别和技能权重抽取技能的方法。",
    "InitSurvivorGroup": "开局初始候选池；当前快照包含 10 个武器入口。",
    "SurvivorGroup": "常规局内候选池；包含武器与被动入口。",
    "Init": "开局初始池的剩余使用计数；大于 0 时优先使用初始池。",
    "WeightForNewplayer": "配置中的新玩家权重字段；当前核实的主线取权重路径没有读取它。",
    "Weight_1": "技能在第 1 组章节权重中的数值；第一章使用这一列。",
    "Weight": "候选的相对权重。需要与同池其他有效候选重新归一化，不能直接当百分比。",
    "OverrideGuideRandomSkill": "引导指定候选列表；存在时覆盖本次普通随机，使用后清空。",
    "LevelUpSkillUpRate%": "升级选项品质相关属性；它修改普通品质数组，不能直接套到主线专用权重。",
    "ExHighSkillRate%": "高阶技能相关属性；通过 qualityUp 条件影响主线内部的类别处理。",
    "qualityUp": "本次抽取是否启用品质提升处理的布尔标记。",
    "fallback": "原生后备实现。热更未接管时才执行；空实现不证明线上功能不存在。",
    "Punchboard": "宝箱批量技能奖励流程的内部命名。其奖励数量档为 1／3／5。",
    "FiveSkillRate%": "Punchboard 五奖励档的权重增幅属性；仍受五档解锁门槛约束。",
    "IsBattleSkill": "技能是否计入局内战斗技能组统计的配置标记。",
    "BattleSkillGroup": "战斗技能分组 ID；宝箱会按不同分组数判断是否开放五奖励档。",
    "WorldType": "战斗世界类型。主线为 1，不同世界类型可使用不同宝箱空间规则。",
    "IsSkillABTestB": "当前局是否走技能系统 B 分支的运行标记。",
    "GetIsUpgrade": "读取技能节点是否属于特殊升级节点。",
    "IsUpgrade": "技能配置中的特殊升级标记。命中后可能进入专属选择队列。",
    "TryUnlockUpgradeSkills": "检查武器与模块配方，并把满足条件的进化节点加入候选池。",
    "UpgradeSkillId": "特殊升级节点后续可选技能 ID 列表。",
    "OpenSelectSpecialSkill": "打开武器专属后续选择的入口。",
    "missinType": "任务类型字段的原始拼写。值 9 对应主线宝箱事件。",
    "RandomNpc": "任务配置中的随机 NPC 类型字段；只有值 9 才会进入已发现的遗漏补偿分支。",
    "state11": "战斗状态 11：Punchboard 宝箱批量奖励状态。",
    "state12": "战斗状态 12：武器特殊技能选择状态。",
    "MainDropManager": "主线普通怪物掉落管理器。其静态后备实现不足以证明热更后的特殊掉落行为。",
    "DropMgr": "局内掉落实体的统一创建与管理组件。",
    "EntityTreasure": "一个碰撞后创建怪物的实体类；不能仅凭名字把它认作主线奖励宝箱。",
    "BaseDropNpcState": "传统 NPC／Box 奖励状态的基础类，与实体 8 的 Punchboard 流程分开。",
    "InitSelectBoxRate%": "传统两结果 Box 在初始阶段的出现概率属性。",
    "JSON": "结构化文本数据格式；交接包用它保存可复算的中间数据。",
    "L0": "原始 APK 与版本指纹层。",
    "L1": "反编译代码、配置表和原生函数证据层。",
    "L2": "可直接移交和查询的结构化中间数据层。",
    "L3": "面向策划阅读的最终报告层。",
    "StopByEliteOrBossKilled": "当前波必须等精英或首领目标死亡后才推进的门槛。",
    "SkillStar": "技能当前星级；宝箱已学升级池会据此筛选。",
    "NextSkill": "技能的下一阶段节点关系；不是必然获得。",
    "CoverSkill": "取得新节点后覆盖旧技能的关系。",
    "PreSkillIds": "技能入池或学习所需的前置技能 ID。",
    "NeedSkills": "当前候选所要求已具备的技能。",
    "RejectSkills": "与当前候选互斥的技能。",
    "UpgradeSkillGroup": "进化候选配置池；配置行不等于本局可直接抽取。",
    "Role_Role": "机体母体配置表。",
    "Role_Skin": "机体形态、品质、解锁资源和模型配置表。",
    "Role_SkinStar": "机体逐星成本、属性和能力节点配置表。",
    "FeatureOnStarUp": "机体升到该星级时连接的能力节点。",
    "Shop_Shop": "商店配置表，定义商品集合和店铺级限制。",
    "Shop_ShopGoods": "具体商品的价格、奖励、限购和解锁条件表。",
    "Shop_LootBox": "局外抽取箱配置；不同于局内接触宝箱。",
    "FreeCD": "局外抽取箱免费机会的冷却配置字段；具体业务单位仍需核对。",
    "IsUpgrade": "技能是否为特殊升级节点的标记。",
    "AICommonBoss": "首领行为类，可能按权重执行攻击和召唤动作。",
    "AIMoveFollowTarget": "持续根据目标位置修正跟随轨迹的行为类。",
    "AIMoveDynamicRotateCenter": "围绕中心旋转并可动态改变半径的行为类。",
    "AIMoveUpDown": "上下运动并可带冲刺的行为类。",
  };

  for (let i = 2; i <= 10; i++) glossary[`Weight_${i}`] = `技能第${i}组章节权重列；由章节SkillGroupWeight选择，编号不直接等于章号。`;
  const terms = Object.keys(glossary).sort((a, b) => b.length - a.length);
  const escaped = terms.map(term => term.replace(/[.*+?^${}()|[\]\\]/g, "\\$&"));
  const matcher = new RegExp(`(^|[^A-Za-z0-9_])(${escaped.join("|")})(?=$|[^A-Za-z0-9_])`, "g");
  const excluded = new Set(["A", "ABBR", "CODE", "PRE", "SCRIPT", "STYLE", "TEXTAREA"]);
  const root = document.querySelector(".article") || document.querySelector("main");
  if (!root) return;

  const walker = document.createTreeWalker(root, NodeFilter.SHOW_TEXT, {
    acceptNode(node) {
      if (!node.nodeValue.trim()) return NodeFilter.FILTER_REJECT;
      if (node.parentElement && excluded.has(node.parentElement.tagName)) return NodeFilter.FILTER_REJECT;
      matcher.lastIndex = 0;
      return matcher.test(node.nodeValue) ? NodeFilter.FILTER_ACCEPT : NodeFilter.FILTER_REJECT;
    }
  });
  const nodes = [];
  while (walker.nextNode()) nodes.push(walker.currentNode);

  for (const node of nodes) {
    const fragment = document.createDocumentFragment();
    let last = 0;
    matcher.lastIndex = 0;
    for (const match of node.nodeValue.matchAll(matcher)) {
      const term = match[2];
      const termStart = match.index + match[1].length;
      fragment.append(node.nodeValue.slice(last, termStart));
      const tip = document.createElement("abbr");
      tip.className = "term-tip";
      tip.textContent = term;
      tip.title = glossary[term];
      tip.dataset.tip = glossary[term];
      tip.tabIndex = 0;
      tip.setAttribute("aria-label", `${term}：${glossary[term]}`);
      fragment.append(tip);
      last = termStart + term.length;
    }
    fragment.append(node.nodeValue.slice(last));
    node.replaceWith(fragment);
  }

  root.addEventListener("click", event => {
    const current = event.target.closest?.(".term-tip");
    root.querySelectorAll(".term-tip.is-open").forEach(tip => {
      if (tip !== current) tip.classList.remove("is-open");
    });
    if (current) {
      event.preventDefault();
      current.classList.toggle("is-open");
      current.focus({ preventScroll: true });
    }
  });
  document.addEventListener("click", event => {
    if (!event.target.closest?.(".term-tip")) {
      root.querySelectorAll(".term-tip.is-open").forEach(tip => tip.classList.remove("is-open"));
    }
  });
})();
