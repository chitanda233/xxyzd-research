; HotFix.BattleLogic.AIMoveToBottomAndAttackNew$$InitAttackLoop
; RVA 0x6550FFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006550FFC  sub      sp, sp, #0x130
006551000  str      x29, [sp, #0xd0]
006551004  stp      x30, x27, [sp, #0xe0]
006551008  stp      x26, x25, [sp, #0xf0]
00655100C  stp      x24, x23, [sp, #0x100]
006551010  stp      x22, x21, [sp, #0x110]
006551014  stp      x20, x19, [sp, #0x120]
006551018  mrs      x24, tpidr_el0
00655101C  ldr      x8, [x24, #0x28]
006551020  adrp     x20, #0x9598000
006551024  adrp     x21, #0x8f05000
006551028  mov      x19, x0
00655102C  str      x8, [sp, #0xc8]
006551030  ldrb     w8, [x20, #0xe79]
006551034  ldr      x21, [x21, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.InitAttackLoop()
006551038  tbnz     w8, #0, #0x65510ec
00655103C  adrp     x0, #0x8f05000
006551040  ldr      x0, [x0, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.InitAttackLoop()
006551044  bl       #0x382bd14 ; 
006551048  adrp     x0, #0x8f05000
00655104C  ldr      x0, [x0, #0x878] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.AllowAttack()
006551050  bl       #0x382bd14 ; 
006551054  adrp     x0, #0x8f05000
006551058  ldr      x0, [x0, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
00655105C  bl       #0x382bd14 ; 
006551060  adrp     x0, #0x8f05000
006551064  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToPoint>()
006551068  bl       #0x382bd14 ; 
00655106C  adrp     x0, #0x8f05000
006551070  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
006551074  bl       #0x382bd14 ; 
006551078  adrp     x0, #0x8f05000
00655107C  ldr      x0, [x0, #0xaf8] ; GLOBAL System.Action<TaskBase<FP>, bool>_TypeInfo
006551080  bl       #0x382bd14 ; 
006551084  adrp     x0, #0x8ee6000
006551088  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00655108C  bl       #0x382bd14 ; 
006551090  adrp     x0, #0x8ec2000
006551094  ldr      x0, [x0, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo
006551098  bl       #0x382bd14 ; 
00655109C  adrp     x0, #0x8f05000
0065510A0  ldr      x0, [x0, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
0065510A4  bl       #0x382bd14 ; 
0065510A8  adrp     x0, #0x8f05000
0065510AC  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
0065510B0  bl       #0x382bd14 ; 
0065510B4  adrp     x0, #0x8f05000
0065510B8  ldr      x0, [x0, #0xb60] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.<>c__DisplayClass4_0.<InitAttackLoop>b__0()
0065510BC  bl       #0x382bd14 ; 
0065510C0  adrp     x0, #0x8f05000
0065510C4  ldr      x0, [x0, #0xb68] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.<>c__DisplayClass4_0.<InitAttackLoop>b__1()
0065510C8  bl       #0x382bd14 ; 
0065510CC  adrp     x0, #0x8f05000
0065510D0  ldr      x0, [x0, #0xb70] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttackNew.<>c__DisplayClass4_0_TypeInfo
0065510D4  bl       #0x382bd14 ; 
0065510D8  adrp     x0, #0x8f05000
0065510DC  ldr      x0, [x0, #0x828] ; GLOBAL Idle
0065510E0  bl       #0x382bd14 ; 
0065510E4  mov      w8, #1
0065510E8  strb     w8, [x20, #0xe79]
0065510EC  ldr      x1, [x21]
0065510F0  ldrb     w8, [x1, #0x53]
0065510F4  tbnz     w8, #5, #0x65511a8
0065510F8  adrp     x8, #0x8f05000
0065510FC  ldr      x8, [x8, #0xb70] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttackNew.<>c__DisplayClass4_0_TypeInfo
006551100  ldr      x0, [x8]
006551104  bl       #0x382bfa0 ; 
006551108  mov      x20, x0
00655110C  bl       #0x65515f8 ; HotFix.BattleLogic.AIMoveToBottomAndAttackNew.<>c__DisplayClass4_0$$.ctor
006551110  cbz      x20, #0x65515f0
006551114  mov      x0, x20
006551118  str      x19, [x0, #0x18]!
00655111C  mov      x1, x19
006551120  bl       #0x382bcb8 ; 
006551124  ldr      x0, [x19, #0x58]
006551128  cbz      x0, #0x65515f0
00655112C  adrp     x8, #0x8f05000
006551130  ldr      x8, [x8, #0x828] ; GLOBAL Idle
006551134  mov      x2, xzr
006551138  ldr      x1, [x8]
00655113C  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
006551140  ldr      x21, [x19, #0x58]
006551144  mov      x0, x19
006551148  mov      x1, xzr
00655114C  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
006551150  cbz      x21, #0x65515f0
006551154  mov      x1, x0
006551158  mov      x0, x21
00655115C  mov      x2, xzr
006551160  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
006551164  ldr      x21, [x19, #0x58]
006551168  cbz      x21, #0x65515f0
00655116C  adrp     x22, #0x9598000
006551170  ldrb     w8, [x22, #0xfb7]
006551174  cbnz     w8, #0x655118c
006551178  adrp     x0, #0x8f05000
00655117C  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006551180  bl       #0x382bd14 ; 
006551184  mov      w8, #1
006551188  strb     w8, [x22, #0xfb7]
00655118C  adrp     x8, #0x8f05000
006551190  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006551194  ldr      x1, [x8]
006551198  ldrb     w8, [x1, #0x53]
00655119C  tbnz     w8, #5, #0x65511b8
0065511A0  ldr      x21, [x21, #0x118]
0065511A4  b        #0x65511c8 ; 
0065511A8  ldr      x8, [x1, #0x60]
0065511AC  mov      x0, x19
0065511B0  blr      x8
0065511B4  b        #0x65515c0 ; 
0065511B8  ldr      x8, [x1, #0x60]
0065511BC  mov      x0, x21
0065511C0  blr      x8
0065511C4  mov      x21, x0
0065511C8  ldr      x8, [x19, #0x118]
0065511CC  cbz      x8, #0x65515f0
0065511D0  ldp      x1, x3, [x8, #0x20]
0065511D4  add      x0, sp, #0xb0
0065511D8  mov      x2, xzr
0065511DC  mov      x4, xzr
0065511E0  stp      xzr, xzr, [sp, #0xb0]
0065511E4  str      xzr, [sp, #0xc0]
0065511E8  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065511EC  cbz      x21, #0x65515f0
0065511F0  ldr      q0, [sp, #0xb0]
0065511F4  ldr      x8, [sp, #0xc0]
0065511F8  add      x1, sp, #0x90
0065511FC  mov      x0, x21
006551200  mov      x2, xzr
006551204  str      q0, [sp, #0x90]
006551208  str      x8, [sp, #0xa0]
00655120C  bl       #0x672c948 ; HotFix.BattleLogic.CharacterComponentTransform$$LookRotationDir
006551210  adrp     x8, #0x8f05000
006551214  ldr      x8, [x8, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
006551218  mov      x0, x19
00655121C  ldr      x1, [x8]
006551220  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
006551224  adrp     x8, #0x8f05000
006551228  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToPoint>()
00655122C  mov      x21, x0
006551230  mov      x0, x19
006551234  ldr      x1, [x8]
006551238  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00655123C  adrp     x23, #0x9591000
006551240  ldrb     w8, [x23, #0xa4b]
006551244  mov      x22, x0
006551248  cbnz     w8, #0x6551260
00655124C  adrp     x0, #0x8ee5000
006551250  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006551254  bl       #0x382bd14 ; 
006551258  mov      w8, #1
00655125C  strb     w8, [x23, #0xa4b]
006551260  adrp     x8, #0x8ee5000
006551264  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006551268  ldr      x1, [x8]
00655126C  ldrb     w8, [x1, #0x53]
006551270  tbnz     w8, #5, #0x655127c
006551274  ldr      x23, [x19, #0x20]
006551278  b        #0x655128c ; 
00655127C  ldr      x8, [x1, #0x60]
006551280  mov      x0, x19
006551284  blr      x8
006551288  mov      x23, x0
00655128C  cbz      x23, #0x65515f0
006551290  adrp     x25, #0x9591000
006551294  ldrb     w8, [x25, #0xa9c]
006551298  cbnz     w8, #0x65512b0
00655129C  adrp     x0, #0x8ee6000
0065512A0  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065512A4  bl       #0x382bd14 ; 
0065512A8  mov      w8, #1
0065512AC  strb     w8, [x25, #0xa9c]
0065512B0  adrp     x8, #0x8ee6000
0065512B4  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065512B8  ldr      x1, [x8]
0065512BC  ldrb     w8, [x1, #0x53]
0065512C0  tbnz     w8, #5, #0x65512cc
0065512C4  ldr      x0, [x23, #0x240]
0065512C8  b        #0x65512d8 ; 
0065512CC  ldr      x8, [x1, #0x60]
0065512D0  mov      x0, x23
0065512D4  blr      x8
0065512D8  cbz      x0, #0x65515f0
0065512DC  ldr      x8, [x0, #0x10]
0065512E0  cbz      x8, #0x65515f0
0065512E4  ldr      x9, [x19, #0x118]
0065512E8  cbz      x9, #0x65515f0
0065512EC  ldr      w9, [x9, #0x40]
0065512F0  ldr      x25, [x8, #0x28]
0065512F4  cmp      w9, #1
0065512F8  cset     w8, eq
0065512FC  strb     w8, [x20, #0x10]
006551300  ldr      x0, [x19, #0x58]
006551304  cbz      x0, #0x65515f0
006551308  adrp     x23, #0x8ee6000
00655130C  ldr      x23, [x23, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006551310  ldr      x1, [x23]
006551314  ldrb     w8, [x1, #0x53]
006551318  tbnz     w8, #5, #0x6551324
00655131C  ldr      x0, [x0, #0x38]
006551320  b        #0x655132c ; 
006551324  ldr      x8, [x1, #0x60]
006551328  blr      x8
00655132C  cbz      x0, #0x65515f0
006551330  add      x8, sp, #0x78
006551334  mov      x1, xzr
006551338  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00655133C  ldr      x8, [x19, #0x118]
006551340  cbz      x8, #0x65515f0
006551344  ldr      x0, [x19, #0x58]
006551348  cbz      x0, #0x65515f0
00655134C  ldr      x1, [x23]
006551350  ldr      x26, [sp, #0x78]
006551354  ldr      x27, [x8, #0x10]
006551358  ldrb     w9, [x1, #0x53]
00655135C  tbnz     w9, #5, #0x6551368
006551360  ldr      x0, [x0, #0x38]
006551364  b        #0x6551370 ; 
006551368  ldr      x8, [x1, #0x60]
00655136C  blr      x8
006551370  cbz      x0, #0x65515f0
006551374  add      x8, sp, #0x78
006551378  mov      x1, xzr
00655137C  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006551380  ldr      x8, [x19, #0x58]
006551384  cbz      x8, #0x65515f0
006551388  ldr      x9, [x19, #0x118]
00655138C  cbz      x9, #0x65515f0
006551390  ldr      x8, [x8, #0x90]
006551394  ldr      x9, [x9, #0x18]
006551398  ldr      x2, [sp, #0x80]
00655139C  add      x1, x27, x26
0065513A0  add      x8, x8, x25
0065513A4  add      x3, x8, x9
0065513A8  add      x0, sp, #0x78
0065513AC  mov      x4, xzr
0065513B0  stp      xzr, xzr, [sp, #0x78]
0065513B4  str      xzr, [sp, #0x88]
0065513B8  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065513BC  ldr      x0, [x19, #0x58]
0065513C0  cbz      x0, #0x65515f0
0065513C4  ldr      x1, [x23]
0065513C8  ldrb     w8, [x1, #0x53]
0065513CC  tbnz     w8, #5, #0x65513d8
0065513D0  ldr      x23, [x0, #0x38]
0065513D4  b        #0x65513e4 ; 
0065513D8  ldr      x8, [x1, #0x60]
0065513DC  blr      x8
0065513E0  mov      x23, x0
0065513E4  cbz      x23, #0x65515f0
0065513E8  adrp     x25, #0x9598000
0065513EC  ldrb     w8, [x25, #0xfbc]
0065513F0  cbnz     w8, #0x6551408
0065513F4  adrp     x0, #0x8f05000
0065513F8  ldr      x0, [x0, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_InMapOriginPos()
0065513FC  bl       #0x382bd14 ; 
006551400  mov      w8, #1
006551404  strb     w8, [x25, #0xfbc]
006551408  adrp     x8, #0x8f05000
00655140C  ldr      x8, [x8, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_InMapOriginPos()
006551410  ldr      x1, [x8]
006551414  ldrb     w8, [x1, #0x53]
006551418  tbnz     w8, #5, #0x6551434
00655141C  add      x8, x23, #0x138
006551420  ldr      x9, [x23, #0x148]
006551424  ldr      q0, [x8]
006551428  str      x9, [sp, #0x50]
00655142C  str      q0, [sp, #0x40]
006551430  b        #0x6551444 ; 
006551434  ldr      x9, [x1, #0x60]
006551438  add      x8, sp, #0x40
00655143C  mov      x0, x23
006551440  blr      x9
006551444  ldr      q0, [sp, #0x40]
006551448  ldr      x8, [sp, #0x50]
00655144C  str      q0, [sp, #0x60]
006551450  str      x8, [sp, #0x70]
006551454  cbz      x22, #0x65515f0
006551458  ldrb     w3, [x20, #0x10]
00655145C  ldur     q0, [sp, #0x78]
006551460  ldr      x8, [sp, #0x88]
006551464  ldr      q1, [sp, #0x60]
006551468  ldr      x9, [sp, #0x70]
00655146C  add      x1, sp, #0x20
006551470  mov      x2, sp
006551474  mov      x0, x22
006551478  mov      x4, xzr
00655147C  str      q0, [sp, #0x20]
006551480  str      x8, [sp, #0x30]
006551484  str      q1, [sp]
006551488  str      x9, [sp, #0x10]
00655148C  bl       #0x661bba8 ; HotFix.BattleLogic.MonsterMoveToPoint$$SetData
006551490  adrp     x8, #0x8f05000
006551494  ldr      x8, [x8, #0xaf8] ; GLOBAL System.Action<TaskBase<FP>, bool>_TypeInfo
006551498  ldr      x0, [x8]
00655149C  bl       #0x382bfa0 ; 
0065514A0  adrp     x8, #0x8f05000
0065514A4  ldr      x8, [x8, #0xb60] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.<>c__DisplayClass4_0.<InitAttackLoop>b__0()
0065514A8  mov      x1, x20
0065514AC  mov      x3, xzr
0065514B0  mov      x23, x0
0065514B4  ldr      x2, [x8]
0065514B8  bl       #0x60424d0 ; System.Action<object, bool>$$.ctor
0065514BC  mov      x0, x22
0065514C0  str      x23, [x0, #0x38]!
0065514C4  mov      x1, x23
0065514C8  bl       #0x382bcb8 ; 
0065514CC  cbz      x21, #0x65515f0
0065514D0  adrp     x25, #0x8f05000
0065514D4  ldr      x25, [x25, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
0065514D8  mov      x0, x21
0065514DC  mov      x1, x22
0065514E0  ldr      x2, [x25]
0065514E4  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
0065514E8  ldr      x8, [x19, #0x118]
0065514EC  cbz      x8, #0x65515f0
0065514F0  ldrb     w8, [x8, #0x44]
0065514F4  cbz      w8, #0x65515b0
0065514F8  adrp     x8, #0x8f05000
0065514FC  ldr      x8, [x8, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
006551500  mov      x0, x19
006551504  ldr      x1, [x8]
006551508  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00655150C  adrp     x8, #0x8f05000
006551510  ldr      x8, [x8, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
006551514  mov      x22, x0
006551518  ldr      x8, [x8]
00655151C  mov      x0, x8
006551520  bl       #0x382bfa0 ; 
006551524  adrp     x8, #0x8f05000
006551528  ldr      x8, [x8, #0xb68] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.<>c__DisplayClass4_0.<InitAttackLoop>b__1()
00655152C  mov      x1, x20
006551530  mov      x3, xzr
006551534  mov      x23, x0
006551538  ldr      x2, [x8]
00655153C  bl       #0x635b760 ; System.Func<FP>$$.ctor
006551540  ldr      x8, [x19, #0x118]
006551544  cbz      x8, #0x65515f0
006551548  cbz      x22, #0x65515f0
00655154C  ldr      x2, [x8, #0x38]
006551550  mov      w3, #1
006551554  mov      x0, x22
006551558  mov      x1, x23
00655155C  mov      x4, xzr
006551560  bl       #0x660bcc0 ; HotFix.BattleLogic.AttackActionLoop$$SetData
006551564  adrp     x8, #0x8ec2000
006551568  ldr      x8, [x8, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo
00655156C  ldr      x0, [x8]
006551570  bl       #0x382bfa0 ; 
006551574  adrp     x8, #0x8f05000
006551578  ldr      x8, [x8, #0x878] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.AllowAttack()
00655157C  mov      x1, x19
006551580  mov      x3, xzr
006551584  mov      x20, x0
006551588  ldr      x2, [x8]
00655158C  bl       #0x635ad78 ; System.Func<bool>$$.ctor
006551590  mov      x0, x22
006551594  str      x20, [x0, #0x90]!
006551598  mov      x1, x20
00655159C  bl       #0x382bcb8 ; 
0065515A0  ldr      x2, [x25]
0065515A4  mov      x0, x21
0065515A8  mov      x1, x22
0065515AC  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
0065515B0  mov      x0, x19
0065515B4  mov      x1, x21
0065515B8  mov      x2, xzr
0065515BC  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
0065515C0  ldr      x8, [x24, #0x28]
0065515C4  ldr      x9, [sp, #0xc8]
0065515C8  cmp      x8, x9
0065515CC  b.ne     #0x65515f4
0065515D0  ldp      x20, x19, [sp, #0x120]
0065515D4  ldp      x22, x21, [sp, #0x110]
0065515D8  ldp      x24, x23, [sp, #0x100]
0065515DC  ldp      x26, x25, [sp, #0xf0]
0065515E0  ldp      x30, x27, [sp, #0xe0]
0065515E4  ldr      x29, [sp, #0xd0]
0065515E8  add      sp, sp, #0x130
0065515EC  ret      
0065515F0  bl       #0x382bfb8 ; 
0065515F4  bl       #0x89edb60 ; 

