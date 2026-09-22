; HotFix.BattleLogic.AIMoveToBottomAndAttack$$InitAttackLoop
; RVA 0x6550598; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006550598  sub      sp, sp, #0x130
00655059C  str      x29, [sp, #0xd0]
0065505A0  stp      x30, x27, [sp, #0xe0]
0065505A4  stp      x26, x25, [sp, #0xf0]
0065505A8  stp      x24, x23, [sp, #0x100]
0065505AC  stp      x22, x21, [sp, #0x110]
0065505B0  stp      x20, x19, [sp, #0x120]
0065505B4  mrs      x24, tpidr_el0
0065505B8  ldr      x8, [x24, #0x28]
0065505BC  adrp     x20, #0x9598000
0065505C0  adrp     x21, #0x8f05000
0065505C4  mov      x19, x0
0065505C8  str      x8, [sp, #0xc8]
0065505CC  ldrb     w8, [x20, #0xe71]
0065505D0  ldr      x21, [x21, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.InitAttackLoop()
0065505D4  tbnz     w8, #0, #0x6550670
0065505D8  adrp     x0, #0x8f05000
0065505DC  ldr      x0, [x0, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.InitAttackLoop()
0065505E0  bl       #0x382bd14 ; 
0065505E4  adrp     x0, #0x8f05000
0065505E8  ldr      x0, [x0, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
0065505EC  bl       #0x382bd14 ; 
0065505F0  adrp     x0, #0x8f05000
0065505F4  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToPoint>()
0065505F8  bl       #0x382bd14 ; 
0065505FC  adrp     x0, #0x8f05000
006550600  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
006550604  bl       #0x382bd14 ; 
006550608  adrp     x0, #0x8f05000
00655060C  ldr      x0, [x0, #0xaf8] ; GLOBAL System.Action<TaskBase<FP>, bool>_TypeInfo
006550610  bl       #0x382bd14 ; 
006550614  adrp     x0, #0x8ee6000
006550618  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00655061C  bl       #0x382bd14 ; 
006550620  adrp     x0, #0x8f05000
006550624  ldr      x0, [x0, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
006550628  bl       #0x382bd14 ; 
00655062C  adrp     x0, #0x8f05000
006550630  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
006550634  bl       #0x382bd14 ; 
006550638  adrp     x0, #0x8f05000
00655063C  ldr      x0, [x0, #0xb00] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.<>c__DisplayClass4_0.<InitAttackLoop>b__0()
006550640  bl       #0x382bd14 ; 
006550644  adrp     x0, #0x8f05000
006550648  ldr      x0, [x0, #0xb08] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.<>c__DisplayClass4_0.<InitAttackLoop>b__1()
00655064C  bl       #0x382bd14 ; 
006550650  adrp     x0, #0x8f05000
006550654  ldr      x0, [x0, #0xb10] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttack.<>c__DisplayClass4_0_TypeInfo
006550658  bl       #0x382bd14 ; 
00655065C  adrp     x0, #0x8f05000
006550660  ldr      x0, [x0, #0x828] ; GLOBAL Idle
006550664  bl       #0x382bd14 ; 
006550668  mov      w8, #1
00655066C  strb     w8, [x20, #0xe71]
006550670  ldr      x1, [x21]
006550674  ldrb     w8, [x1, #0x53]
006550678  tbnz     w8, #5, #0x655072c
00655067C  adrp     x8, #0x8f05000
006550680  ldr      x8, [x8, #0xb10] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttack.<>c__DisplayClass4_0_TypeInfo
006550684  ldr      x0, [x8]
006550688  bl       #0x382bfa0 ; 
00655068C  mov      x20, x0
006550690  bl       #0x6550b40 ; HotFix.BattleLogic.AIMoveToBottomAndAttack.<>c__DisplayClass4_0$$.ctor
006550694  cbz      x20, #0x6550b38
006550698  mov      x0, x20
00655069C  str      x19, [x0, #0x18]!
0065506A0  mov      x1, x19
0065506A4  bl       #0x382bcb8 ; 
0065506A8  ldr      x0, [x19, #0x58]
0065506AC  cbz      x0, #0x6550b38
0065506B0  adrp     x8, #0x8f05000
0065506B4  ldr      x8, [x8, #0x828] ; GLOBAL Idle
0065506B8  mov      x2, xzr
0065506BC  ldr      x1, [x8]
0065506C0  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
0065506C4  ldr      x21, [x19, #0x58]
0065506C8  mov      x0, x19
0065506CC  mov      x1, xzr
0065506D0  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
0065506D4  cbz      x21, #0x6550b38
0065506D8  mov      x1, x0
0065506DC  mov      x0, x21
0065506E0  mov      x2, xzr
0065506E4  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
0065506E8  ldr      x21, [x19, #0x58]
0065506EC  cbz      x21, #0x6550b38
0065506F0  adrp     x22, #0x9598000
0065506F4  ldrb     w8, [x22, #0xfb7]
0065506F8  cbnz     w8, #0x6550710
0065506FC  adrp     x0, #0x8f05000
006550700  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006550704  bl       #0x382bd14 ; 
006550708  mov      w8, #1
00655070C  strb     w8, [x22, #0xfb7]
006550710  adrp     x8, #0x8f05000
006550714  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006550718  ldr      x1, [x8]
00655071C  ldrb     w8, [x1, #0x53]
006550720  tbnz     w8, #5, #0x655073c
006550724  ldr      x21, [x21, #0x118]
006550728  b        #0x655074c ; 
00655072C  ldr      x8, [x1, #0x60]
006550730  mov      x0, x19
006550734  blr      x8
006550738  b        #0x6550b08 ; 
00655073C  ldr      x8, [x1, #0x60]
006550740  mov      x0, x21
006550744  blr      x8
006550748  mov      x21, x0
00655074C  ldr      x8, [x19, #0x118]
006550750  cbz      x8, #0x6550b38
006550754  ldp      x1, x3, [x8, #0x20]
006550758  add      x0, sp, #0xb0
00655075C  mov      x2, xzr
006550760  mov      x4, xzr
006550764  stp      xzr, xzr, [sp, #0xb0]
006550768  str      xzr, [sp, #0xc0]
00655076C  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
006550770  cbz      x21, #0x6550b38
006550774  ldr      q0, [sp, #0xb0]
006550778  ldr      x8, [sp, #0xc0]
00655077C  add      x1, sp, #0x90
006550780  mov      x0, x21
006550784  mov      x2, xzr
006550788  str      q0, [sp, #0x90]
00655078C  str      x8, [sp, #0xa0]
006550790  bl       #0x672c948 ; HotFix.BattleLogic.CharacterComponentTransform$$LookRotationDir
006550794  adrp     x8, #0x8f05000
006550798  ldr      x8, [x8, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
00655079C  mov      x0, x19
0065507A0  ldr      x1, [x8]
0065507A4  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
0065507A8  adrp     x8, #0x8f05000
0065507AC  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToPoint>()
0065507B0  mov      x21, x0
0065507B4  mov      x0, x19
0065507B8  ldr      x1, [x8]
0065507BC  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
0065507C0  adrp     x23, #0x9591000
0065507C4  ldrb     w8, [x23, #0xa4b]
0065507C8  mov      x22, x0
0065507CC  cbnz     w8, #0x65507e4
0065507D0  adrp     x0, #0x8ee5000
0065507D4  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0065507D8  bl       #0x382bd14 ; 
0065507DC  mov      w8, #1
0065507E0  strb     w8, [x23, #0xa4b]
0065507E4  adrp     x8, #0x8ee5000
0065507E8  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0065507EC  ldr      x1, [x8]
0065507F0  ldrb     w8, [x1, #0x53]
0065507F4  tbnz     w8, #5, #0x6550800
0065507F8  ldr      x23, [x19, #0x20]
0065507FC  b        #0x6550810 ; 
006550800  ldr      x8, [x1, #0x60]
006550804  mov      x0, x19
006550808  blr      x8
00655080C  mov      x23, x0
006550810  cbz      x23, #0x6550b38
006550814  adrp     x25, #0x9591000
006550818  ldrb     w8, [x25, #0xa9c]
00655081C  cbnz     w8, #0x6550834
006550820  adrp     x0, #0x8ee6000
006550824  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
006550828  bl       #0x382bd14 ; 
00655082C  mov      w8, #1
006550830  strb     w8, [x25, #0xa9c]
006550834  adrp     x8, #0x8ee6000
006550838  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
00655083C  ldr      x1, [x8]
006550840  ldrb     w8, [x1, #0x53]
006550844  tbnz     w8, #5, #0x6550850
006550848  ldr      x0, [x23, #0x240]
00655084C  b        #0x655085c ; 
006550850  ldr      x8, [x1, #0x60]
006550854  mov      x0, x23
006550858  blr      x8
00655085C  cbz      x0, #0x6550b38
006550860  ldr      x8, [x0, #0x10]
006550864  cbz      x8, #0x6550b38
006550868  ldr      x9, [x19, #0x118]
00655086C  cbz      x9, #0x6550b38
006550870  ldr      w9, [x9, #0x40]
006550874  ldr      x25, [x8, #0x28]
006550878  cmp      w9, #1
00655087C  cset     w8, eq
006550880  strb     w8, [x20, #0x10]
006550884  ldr      x0, [x19, #0x58]
006550888  cbz      x0, #0x6550b38
00655088C  adrp     x23, #0x8ee6000
006550890  ldr      x23, [x23, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006550894  ldr      x1, [x23]
006550898  ldrb     w8, [x1, #0x53]
00655089C  tbnz     w8, #5, #0x65508a8
0065508A0  ldr      x0, [x0, #0x38]
0065508A4  b        #0x65508b0 ; 
0065508A8  ldr      x8, [x1, #0x60]
0065508AC  blr      x8
0065508B0  cbz      x0, #0x6550b38
0065508B4  add      x8, sp, #0x78
0065508B8  mov      x1, xzr
0065508BC  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0065508C0  ldr      x8, [x19, #0x118]
0065508C4  cbz      x8, #0x6550b38
0065508C8  ldr      x0, [x19, #0x58]
0065508CC  cbz      x0, #0x6550b38
0065508D0  ldr      x1, [x23]
0065508D4  ldr      x26, [sp, #0x78]
0065508D8  ldr      x27, [x8, #0x10]
0065508DC  ldrb     w9, [x1, #0x53]
0065508E0  tbnz     w9, #5, #0x65508ec
0065508E4  ldr      x0, [x0, #0x38]
0065508E8  b        #0x65508f4 ; 
0065508EC  ldr      x8, [x1, #0x60]
0065508F0  blr      x8
0065508F4  cbz      x0, #0x6550b38
0065508F8  add      x8, sp, #0x78
0065508FC  mov      x1, xzr
006550900  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006550904  ldr      x8, [x19, #0x58]
006550908  cbz      x8, #0x6550b38
00655090C  ldr      x9, [x19, #0x118]
006550910  cbz      x9, #0x6550b38
006550914  ldr      x8, [x8, #0x90]
006550918  ldr      x9, [x9, #0x18]
00655091C  ldr      x2, [sp, #0x80]
006550920  add      x1, x27, x26
006550924  add      x8, x8, x25
006550928  add      x3, x8, x9
00655092C  add      x0, sp, #0x78
006550930  mov      x4, xzr
006550934  stp      xzr, xzr, [sp, #0x78]
006550938  str      xzr, [sp, #0x88]
00655093C  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
006550940  ldr      x0, [x19, #0x58]
006550944  cbz      x0, #0x6550b38
006550948  ldr      x1, [x23]
00655094C  ldrb     w8, [x1, #0x53]
006550950  tbnz     w8, #5, #0x655095c
006550954  ldr      x23, [x0, #0x38]
006550958  b        #0x6550968 ; 
00655095C  ldr      x8, [x1, #0x60]
006550960  blr      x8
006550964  mov      x23, x0
006550968  cbz      x23, #0x6550b38
00655096C  adrp     x25, #0x9598000
006550970  ldrb     w8, [x25, #0xfbc]
006550974  cbnz     w8, #0x655098c
006550978  adrp     x0, #0x8f05000
00655097C  ldr      x0, [x0, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_InMapOriginPos()
006550980  bl       #0x382bd14 ; 
006550984  mov      w8, #1
006550988  strb     w8, [x25, #0xfbc]
00655098C  adrp     x8, #0x8f05000
006550990  ldr      x8, [x8, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_InMapOriginPos()
006550994  ldr      x1, [x8]
006550998  ldrb     w8, [x1, #0x53]
00655099C  tbnz     w8, #5, #0x65509b8
0065509A0  add      x8, x23, #0x138
0065509A4  ldr      x9, [x23, #0x148]
0065509A8  ldr      q0, [x8]
0065509AC  str      x9, [sp, #0x50]
0065509B0  str      q0, [sp, #0x40]
0065509B4  b        #0x65509c8 ; 
0065509B8  ldr      x9, [x1, #0x60]
0065509BC  add      x8, sp, #0x40
0065509C0  mov      x0, x23
0065509C4  blr      x9
0065509C8  ldr      q0, [sp, #0x40]
0065509CC  ldr      x8, [sp, #0x50]
0065509D0  str      q0, [sp, #0x60]
0065509D4  str      x8, [sp, #0x70]
0065509D8  cbz      x22, #0x6550b38
0065509DC  ldrb     w3, [x20, #0x10]
0065509E0  ldur     q0, [sp, #0x78]
0065509E4  ldr      x8, [sp, #0x88]
0065509E8  ldr      q1, [sp, #0x60]
0065509EC  ldr      x9, [sp, #0x70]
0065509F0  add      x1, sp, #0x20
0065509F4  mov      x2, sp
0065509F8  mov      x0, x22
0065509FC  mov      x4, xzr
006550A00  str      q0, [sp, #0x20]
006550A04  str      x8, [sp, #0x30]
006550A08  str      q1, [sp]
006550A0C  str      x9, [sp, #0x10]
006550A10  bl       #0x661bba8 ; HotFix.BattleLogic.MonsterMoveToPoint$$SetData
006550A14  adrp     x8, #0x8f05000
006550A18  ldr      x8, [x8, #0xaf8] ; GLOBAL System.Action<TaskBase<FP>, bool>_TypeInfo
006550A1C  ldr      x0, [x8]
006550A20  bl       #0x382bfa0 ; 
006550A24  adrp     x8, #0x8f05000
006550A28  ldr      x8, [x8, #0xb00] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.<>c__DisplayClass4_0.<InitAttackLoop>b__0()
006550A2C  mov      x1, x20
006550A30  mov      x3, xzr
006550A34  mov      x23, x0
006550A38  ldr      x2, [x8]
006550A3C  bl       #0x60424d0 ; System.Action<object, bool>$$.ctor
006550A40  mov      x0, x22
006550A44  str      x23, [x0, #0x38]!
006550A48  mov      x1, x23
006550A4C  bl       #0x382bcb8 ; 
006550A50  cbz      x21, #0x6550b38
006550A54  adrp     x25, #0x8f05000
006550A58  ldr      x25, [x25, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
006550A5C  mov      x0, x21
006550A60  mov      x1, x22
006550A64  ldr      x2, [x25]
006550A68  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
006550A6C  ldr      x8, [x19, #0x118]
006550A70  cbz      x8, #0x6550b38
006550A74  ldrb     w8, [x8, #0x44]
006550A78  cbz      w8, #0x6550af8
006550A7C  adrp     x8, #0x8f05000
006550A80  ldr      x8, [x8, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
006550A84  mov      x0, x19
006550A88  ldr      x1, [x8]
006550A8C  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
006550A90  adrp     x8, #0x8f05000
006550A94  ldr      x8, [x8, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
006550A98  mov      x22, x0
006550A9C  ldr      x8, [x8]
006550AA0  mov      x0, x8
006550AA4  bl       #0x382bfa0 ; 
006550AA8  adrp     x8, #0x8f05000
006550AAC  ldr      x8, [x8, #0xb08] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.<>c__DisplayClass4_0.<InitAttackLoop>b__1()
006550AB0  mov      x1, x20
006550AB4  mov      x3, xzr
006550AB8  mov      x23, x0
006550ABC  ldr      x2, [x8]
006550AC0  bl       #0x635b760 ; System.Func<FP>$$.ctor
006550AC4  ldr      x8, [x19, #0x118]
006550AC8  cbz      x8, #0x6550b38
006550ACC  cbz      x22, #0x6550b38
006550AD0  ldr      x2, [x8, #0x38]
006550AD4  mov      w3, #1
006550AD8  mov      x0, x22
006550ADC  mov      x1, x23
006550AE0  mov      x4, xzr
006550AE4  bl       #0x660bcc0 ; HotFix.BattleLogic.AttackActionLoop$$SetData
006550AE8  ldr      x2, [x25]
006550AEC  mov      x0, x21
006550AF0  mov      x1, x22
006550AF4  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
006550AF8  mov      x0, x19
006550AFC  mov      x1, x21
006550B00  mov      x2, xzr
006550B04  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006550B08  ldr      x8, [x24, #0x28]
006550B0C  ldr      x9, [sp, #0xc8]
006550B10  cmp      x8, x9
006550B14  b.ne     #0x6550b3c
006550B18  ldp      x20, x19, [sp, #0x120]
006550B1C  ldp      x22, x21, [sp, #0x110]
006550B20  ldp      x24, x23, [sp, #0x100]
006550B24  ldp      x26, x25, [sp, #0xf0]
006550B28  ldp      x30, x27, [sp, #0xe0]
006550B2C  ldr      x29, [sp, #0xd0]
006550B30  add      sp, sp, #0x130
006550B34  ret      
006550B38  bl       #0x382bfb8 ; 
006550B3C  bl       #0x89edb60 ; 

