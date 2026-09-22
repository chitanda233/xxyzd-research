; HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew$$InitAttackLoop
; RVA 0x654B648; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654B648  sub      sp, sp, #0xc0
00654B64C  stp      x30, x25, [sp, #0x80]
00654B650  stp      x24, x23, [sp, #0x90]
00654B654  stp      x22, x21, [sp, #0xa0]
00654B658  stp      x20, x19, [sp, #0xb0]
00654B65C  mrs      x23, tpidr_el0
00654B660  ldr      x8, [x23, #0x28]
00654B664  adrp     x20, #0x9598000
00654B668  adrp     x21, #0x8f05000
00654B66C  mov      x19, x0
00654B670  str      x8, [sp, #0x78]
00654B674  ldrb     w8, [x20, #0xe3a]
00654B678  ldr      x21, [x21, #0x868] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.InitAttackLoop()
00654B67C  tbnz     w8, #0, #0x654b70c
00654B680  adrp     x0, #0x8f05000
00654B684  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.InitAttackLoop()
00654B688  bl       #0x382bd14 ; 
00654B68C  adrp     x0, #0x8f05000
00654B690  ldr      x0, [x0, #0x870] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.<InitAttackLoop>b__4_0()
00654B694  bl       #0x382bd14 ; 
00654B698  adrp     x0, #0x8f05000
00654B69C  ldr      x0, [x0, #0x878] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.AllowAttack()
00654B6A0  bl       #0x382bd14 ; 
00654B6A4  adrp     x0, #0x8f05000
00654B6A8  ldr      x0, [x0, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
00654B6AC  bl       #0x382bd14 ; 
00654B6B0  adrp     x0, #0x8f05000
00654B6B4  ldr      x0, [x0, #0x808] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveInTwoPoint>()
00654B6B8  bl       #0x382bd14 ; 
00654B6BC  adrp     x0, #0x8f05000
00654B6C0  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
00654B6C4  bl       #0x382bd14 ; 
00654B6C8  adrp     x0, #0x8ee6000
00654B6CC  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00654B6D0  bl       #0x382bd14 ; 
00654B6D4  adrp     x0, #0x8ec2000
00654B6D8  ldr      x0, [x0, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo
00654B6DC  bl       #0x382bd14 ; 
00654B6E0  adrp     x0, #0x8f05000
00654B6E4  ldr      x0, [x0, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
00654B6E8  bl       #0x382bd14 ; 
00654B6EC  adrp     x0, #0x8f05000
00654B6F0  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
00654B6F4  bl       #0x382bd14 ; 
00654B6F8  adrp     x0, #0x8f05000
00654B6FC  ldr      x0, [x0, #0x828] ; GLOBAL Idle
00654B700  bl       #0x382bd14 ; 
00654B704  mov      w8, #1
00654B708  strb     w8, [x20, #0xe3a]
00654B70C  ldr      x1, [x21]
00654B710  ldrb     w8, [x1, #0x53]
00654B714  tbnz     w8, #5, #0x654b79c
00654B718  ldr      x0, [x19, #0x58]
00654B71C  cbz      x0, #0x654bab8
00654B720  adrp     x8, #0x8f05000
00654B724  ldr      x8, [x8, #0x828] ; GLOBAL Idle
00654B728  mov      x2, xzr
00654B72C  ldr      x1, [x8]
00654B730  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
00654B734  ldr      x20, [x19, #0x58]
00654B738  mov      x0, x19
00654B73C  mov      x1, xzr
00654B740  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00654B744  cbz      x20, #0x654bab8
00654B748  mov      x1, x0
00654B74C  mov      x0, x20
00654B750  mov      x2, xzr
00654B754  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00654B758  ldr      x20, [x19, #0x58]
00654B75C  cbz      x20, #0x654bab8
00654B760  adrp     x21, #0x9598000
00654B764  ldrb     w8, [x21, #0xfb7]
00654B768  cbnz     w8, #0x654b780
00654B76C  adrp     x0, #0x8f05000
00654B770  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654B774  bl       #0x382bd14 ; 
00654B778  mov      w8, #1
00654B77C  strb     w8, [x21, #0xfb7]
00654B780  adrp     x8, #0x8f05000
00654B784  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654B788  ldr      x1, [x8]
00654B78C  ldrb     w8, [x1, #0x53]
00654B790  tbnz     w8, #5, #0x654b7ac
00654B794  ldr      x20, [x20, #0x118]
00654B798  b        #0x654b7bc ; 
00654B79C  ldr      x8, [x1, #0x60]
00654B7A0  mov      x0, x19
00654B7A4  blr      x8
00654B7A8  b        #0x654ba90 ; 
00654B7AC  ldr      x8, [x1, #0x60]
00654B7B0  mov      x0, x20
00654B7B4  blr      x8
00654B7B8  mov      x20, x0
00654B7BC  ldr      x8, [x19, #0x118]
00654B7C0  cbz      x8, #0x654bab8
00654B7C4  ldp      x1, x3, [x8, #0x20]
00654B7C8  add      x0, sp, #0x48
00654B7CC  mov      x2, xzr
00654B7D0  mov      x4, xzr
00654B7D4  stp      xzr, xzr, [sp, #0x48]
00654B7D8  str      xzr, [sp, #0x58]
00654B7DC  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
00654B7E0  cbz      x20, #0x654bab8
00654B7E4  ldur     q0, [sp, #0x48]
00654B7E8  ldr      x8, [sp, #0x58]
00654B7EC  add      x1, sp, #0x30
00654B7F0  mov      x0, x20
00654B7F4  mov      x2, xzr
00654B7F8  str      q0, [sp, #0x30]
00654B7FC  str      x8, [sp, #0x40]
00654B800  bl       #0x672c948 ; HotFix.BattleLogic.CharacterComponentTransform$$LookRotationDir
00654B804  adrp     x8, #0x8f05000
00654B808  ldr      x8, [x8, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
00654B80C  mov      x0, x19
00654B810  ldr      x1, [x8]
00654B814  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
00654B818  adrp     x8, #0x8f05000
00654B81C  ldr      x8, [x8, #0x808] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveInTwoPoint>()
00654B820  mov      x20, x0
00654B824  mov      x0, x19
00654B828  ldr      x1, [x8]
00654B82C  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654B830  ldr      x8, [x19, #0x58]
00654B834  cbz      x8, #0x654bab8
00654B838  adrp     x22, #0x8ee6000
00654B83C  ldr      x22, [x22, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00654B840  mov      x21, x0
00654B844  ldr      x1, [x22]
00654B848  ldrb     w9, [x1, #0x53]
00654B84C  tbnz     w9, #5, #0x654b858
00654B850  ldr      x0, [x8, #0x38]
00654B854  b        #0x654b864 ; 
00654B858  ldr      x9, [x1, #0x60]
00654B85C  mov      x0, x8
00654B860  blr      x9
00654B864  cbz      x0, #0x654bab8
00654B868  add      x8, sp, #0x60
00654B86C  mov      x1, xzr
00654B870  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00654B874  ldr      x8, [x19, #0x118]
00654B878  cbz      x8, #0x654bab8
00654B87C  ldr      x0, [x19, #0x58]
00654B880  cbz      x0, #0x654bab8
00654B884  ldr      x1, [x22]
00654B888  ldr      x24, [sp, #0x60]
00654B88C  ldr      x25, [x8, #0x10]
00654B890  ldrb     w9, [x1, #0x53]
00654B894  tbnz     w9, #5, #0x654b8a0
00654B898  ldr      x0, [x0, #0x38]
00654B89C  b        #0x654b8a8 ; 
00654B8A0  ldr      x8, [x1, #0x60]
00654B8A4  blr      x8
00654B8A8  cbz      x0, #0x654bab8
00654B8AC  add      x8, sp, #0x60
00654B8B0  mov      x1, xzr
00654B8B4  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00654B8B8  ldr      x0, [x19, #0x58]
00654B8BC  cbz      x0, #0x654bab8
00654B8C0  ldr      x1, [x22]
00654B8C4  ldr      x22, [sp, #0x68]
00654B8C8  ldrb     w8, [x1, #0x53]
00654B8CC  tbnz     w8, #5, #0x654b8d8
00654B8D0  ldr      x0, [x0, #0x38]
00654B8D4  b        #0x654b8e0 ; 
00654B8D8  ldr      x8, [x1, #0x60]
00654B8DC  blr      x8
00654B8E0  cbz      x0, #0x654bab8
00654B8E4  add      x8, sp, #0x60
00654B8E8  mov      x1, xzr
00654B8EC  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00654B8F0  ldr      x8, [x19, #0x118]
00654B8F4  cbz      x8, #0x654bab8
00654B8F8  ldr      x9, [sp, #0x70]
00654B8FC  ldr      x8, [x8, #0x18]
00654B900  add      x1, x25, x24
00654B904  add      x0, sp, #0x18
00654B908  mov      x2, x22
00654B90C  add      x3, x8, x9
00654B910  mov      x4, xzr
00654B914  stp      xzr, xzr, [sp, #0x18]
00654B918  str      xzr, [sp, #0x28]
00654B91C  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
00654B920  cbz      x21, #0x654bab8
00654B924  adrp     x22, #0x9598000
00654B928  ldur     q0, [sp, #0x18]
00654B92C  ldr      x8, [sp, #0x28]
00654B930  ldrb     w9, [x22, #0xfb9]
00654B934  str      q0, [sp]
00654B938  str      x8, [sp, #0x10]
00654B93C  cbnz     w9, #0x654b954
00654B940  adrp     x0, #0x8f05000
00654B944  ldr      x0, [x0, #0x830] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.SetData()
00654B948  bl       #0x382bd14 ; 
00654B94C  mov      w8, #1
00654B950  strb     w8, [x22, #0xfb9]
00654B954  adrp     x8, #0x8f05000
00654B958  ldr      x8, [x8, #0x830] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.SetData()
00654B95C  ldr      x2, [x8]
00654B960  ldrb     w8, [x2, #0x53]
00654B964  tbnz     w8, #5, #0x654b97c
00654B968  ldr      x8, [sp, #0x10]
00654B96C  ldr      q0, [sp]
00654B970  str      x8, [x21, #0x98]
00654B974  stur     q0, [x21, #0x88]
00654B978  b        #0x654b99c ; 
00654B97C  ldr      q0, [sp]
00654B980  ldr      x8, [sp, #0x10]
00654B984  ldr      x9, [x2, #0x60]
00654B988  add      x1, sp, #0x60
00654B98C  mov      x0, x21
00654B990  str      q0, [sp, #0x60]
00654B994  str      x8, [sp, #0x70]
00654B998  blr      x9
00654B99C  cbz      x20, #0x654bab8
00654B9A0  adrp     x24, #0x8f05000
00654B9A4  ldr      x24, [x24, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
00654B9A8  mov      x0, x20
00654B9AC  mov      x1, x21
00654B9B0  ldr      x2, [x24]
00654B9B4  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
00654B9B8  ldr      x8, [x19, #0x118]
00654B9BC  cbz      x8, #0x654bab8
00654B9C0  ldrb     w8, [x8, #0x40]
00654B9C4  cbz      w8, #0x654ba80
00654B9C8  adrp     x8, #0x8f05000
00654B9CC  ldr      x8, [x8, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
00654B9D0  mov      x0, x19
00654B9D4  ldr      x1, [x8]
00654B9D8  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654B9DC  adrp     x8, #0x8f05000
00654B9E0  ldr      x8, [x8, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
00654B9E4  mov      x21, x0
00654B9E8  ldr      x8, [x8]
00654B9EC  mov      x0, x8
00654B9F0  bl       #0x382bfa0 ; 
00654B9F4  adrp     x8, #0x8f05000
00654B9F8  ldr      x8, [x8, #0x870] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.<InitAttackLoop>b__4_0()
00654B9FC  mov      x1, x19
00654BA00  mov      x3, xzr
00654BA04  mov      x22, x0
00654BA08  ldr      x2, [x8]
00654BA0C  bl       #0x635b760 ; System.Func<FP>$$.ctor
00654BA10  ldr      x8, [x19, #0x118]
00654BA14  cbz      x8, #0x654bab8
00654BA18  cbz      x21, #0x654bab8
00654BA1C  ldr      x2, [x8, #0x38]
00654BA20  mov      w3, #1
00654BA24  mov      x0, x21
00654BA28  mov      x1, x22
00654BA2C  mov      x4, xzr
00654BA30  bl       #0x660bcc0 ; HotFix.BattleLogic.AttackActionLoop$$SetData
00654BA34  adrp     x8, #0x8ec2000
00654BA38  ldr      x8, [x8, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo
00654BA3C  ldr      x0, [x8]
00654BA40  bl       #0x382bfa0 ; 
00654BA44  adrp     x8, #0x8f05000
00654BA48  ldr      x8, [x8, #0x878] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.AllowAttack()
00654BA4C  mov      x1, x19
00654BA50  mov      x3, xzr
00654BA54  mov      x22, x0
00654BA58  ldr      x2, [x8]
00654BA5C  bl       #0x635ad78 ; System.Func<bool>$$.ctor
00654BA60  mov      x0, x21
00654BA64  str      x22, [x0, #0x90]!
00654BA68  mov      x1, x22
00654BA6C  bl       #0x382bcb8 ; 
00654BA70  ldr      x2, [x24]
00654BA74  mov      x0, x20
00654BA78  mov      x1, x21
00654BA7C  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
00654BA80  mov      x0, x19
00654BA84  mov      x1, x20
00654BA88  mov      x2, xzr
00654BA8C  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654BA90  ldr      x8, [x23, #0x28]
00654BA94  ldr      x9, [sp, #0x78]
00654BA98  cmp      x8, x9
00654BA9C  b.ne     #0x654babc
00654BAA0  ldp      x20, x19, [sp, #0xb0]
00654BAA4  ldp      x22, x21, [sp, #0xa0]
00654BAA8  ldp      x24, x23, [sp, #0x90]
00654BAAC  ldp      x30, x25, [sp, #0x80]
00654BAB0  add      sp, sp, #0xc0
00654BAB4  ret      
00654BAB8  bl       #0x382bfb8 ; 
00654BABC  bl       #0x89edb60 ; 

