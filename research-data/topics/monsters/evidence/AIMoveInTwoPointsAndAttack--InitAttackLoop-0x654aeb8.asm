; HotFix.BattleLogic.AIMoveInTwoPointsAndAttack$$InitAttackLoop
; RVA 0x654AEB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654AEB8  sub      sp, sp, #0xc0
00654AEBC  stp      x30, x25, [sp, #0x80]
00654AEC0  stp      x24, x23, [sp, #0x90]
00654AEC4  stp      x22, x21, [sp, #0xa0]
00654AEC8  stp      x20, x19, [sp, #0xb0]
00654AECC  mrs      x23, tpidr_el0
00654AED0  ldr      x8, [x23, #0x28]
00654AED4  adrp     x20, #0x9598000
00654AED8  adrp     x21, #0x8f05000
00654AEDC  mov      x19, x0
00654AEE0  str      x8, [sp, #0x78]
00654AEE4  ldrb     w8, [x20, #0xe34]
00654AEE8  ldr      x21, [x21, #0x7f0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.InitAttackLoop()
00654AEEC  tbnz     w8, #0, #0x654af64
00654AEF0  adrp     x0, #0x8f05000
00654AEF4  ldr      x0, [x0, #0x7f0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.InitAttackLoop()
00654AEF8  bl       #0x382bd14 ; 
00654AEFC  adrp     x0, #0x8f05000
00654AF00  ldr      x0, [x0, #0x7f8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.<InitAttackLoop>b__4_0()
00654AF04  bl       #0x382bd14 ; 
00654AF08  adrp     x0, #0x8f05000
00654AF0C  ldr      x0, [x0, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
00654AF10  bl       #0x382bd14 ; 
00654AF14  adrp     x0, #0x8f05000
00654AF18  ldr      x0, [x0, #0x808] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveInTwoPoint>()
00654AF1C  bl       #0x382bd14 ; 
00654AF20  adrp     x0, #0x8f05000
00654AF24  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
00654AF28  bl       #0x382bd14 ; 
00654AF2C  adrp     x0, #0x8ee6000
00654AF30  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00654AF34  bl       #0x382bd14 ; 
00654AF38  adrp     x0, #0x8f05000
00654AF3C  ldr      x0, [x0, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
00654AF40  bl       #0x382bd14 ; 
00654AF44  adrp     x0, #0x8f05000
00654AF48  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
00654AF4C  bl       #0x382bd14 ; 
00654AF50  adrp     x0, #0x8f05000
00654AF54  ldr      x0, [x0, #0x828] ; GLOBAL Idle
00654AF58  bl       #0x382bd14 ; 
00654AF5C  mov      w8, #1
00654AF60  strb     w8, [x20, #0xe34]
00654AF64  ldr      x1, [x21]
00654AF68  ldrb     w8, [x1, #0x53]
00654AF6C  tbnz     w8, #5, #0x654aff4
00654AF70  ldr      x0, [x19, #0x58]
00654AF74  cbz      x0, #0x654b2d4
00654AF78  adrp     x8, #0x8f05000
00654AF7C  ldr      x8, [x8, #0x828] ; GLOBAL Idle
00654AF80  mov      x2, xzr
00654AF84  ldr      x1, [x8]
00654AF88  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
00654AF8C  ldr      x20, [x19, #0x58]
00654AF90  mov      x0, x19
00654AF94  mov      x1, xzr
00654AF98  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00654AF9C  cbz      x20, #0x654b2d4
00654AFA0  mov      x1, x0
00654AFA4  mov      x0, x20
00654AFA8  mov      x2, xzr
00654AFAC  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00654AFB0  ldr      x20, [x19, #0x58]
00654AFB4  cbz      x20, #0x654b2d4
00654AFB8  adrp     x21, #0x9598000
00654AFBC  ldrb     w8, [x21, #0xfb7]
00654AFC0  cbnz     w8, #0x654afd8
00654AFC4  adrp     x0, #0x8f05000
00654AFC8  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654AFCC  bl       #0x382bd14 ; 
00654AFD0  mov      w8, #1
00654AFD4  strb     w8, [x21, #0xfb7]
00654AFD8  adrp     x8, #0x8f05000
00654AFDC  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654AFE0  ldr      x1, [x8]
00654AFE4  ldrb     w8, [x1, #0x53]
00654AFE8  tbnz     w8, #5, #0x654b004
00654AFEC  ldr      x20, [x20, #0x118]
00654AFF0  b        #0x654b014 ; 
00654AFF4  ldr      x8, [x1, #0x60]
00654AFF8  mov      x0, x19
00654AFFC  blr      x8
00654B000  b        #0x654b2ac ; 
00654B004  ldr      x8, [x1, #0x60]
00654B008  mov      x0, x20
00654B00C  blr      x8
00654B010  mov      x20, x0
00654B014  ldr      x8, [x19, #0x118]
00654B018  cbz      x8, #0x654b2d4
00654B01C  ldp      x1, x3, [x8, #0x20]
00654B020  add      x0, sp, #0x48
00654B024  mov      x2, xzr
00654B028  mov      x4, xzr
00654B02C  stp      xzr, xzr, [sp, #0x48]
00654B030  str      xzr, [sp, #0x58]
00654B034  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
00654B038  cbz      x20, #0x654b2d4
00654B03C  ldur     q0, [sp, #0x48]
00654B040  ldr      x8, [sp, #0x58]
00654B044  add      x1, sp, #0x30
00654B048  mov      x0, x20
00654B04C  mov      x2, xzr
00654B050  str      q0, [sp, #0x30]
00654B054  str      x8, [sp, #0x40]
00654B058  bl       #0x672c948 ; HotFix.BattleLogic.CharacterComponentTransform$$LookRotationDir
00654B05C  adrp     x8, #0x8f05000
00654B060  ldr      x8, [x8, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
00654B064  mov      x0, x19
00654B068  ldr      x1, [x8]
00654B06C  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
00654B070  adrp     x8, #0x8f05000
00654B074  ldr      x8, [x8, #0x808] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveInTwoPoint>()
00654B078  mov      x20, x0
00654B07C  mov      x0, x19
00654B080  ldr      x1, [x8]
00654B084  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654B088  ldr      x8, [x19, #0x58]
00654B08C  cbz      x8, #0x654b2d4
00654B090  adrp     x22, #0x8ee6000
00654B094  ldr      x22, [x22, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00654B098  mov      x21, x0
00654B09C  ldr      x1, [x22]
00654B0A0  ldrb     w9, [x1, #0x53]
00654B0A4  tbnz     w9, #5, #0x654b0b0
00654B0A8  ldr      x0, [x8, #0x38]
00654B0AC  b        #0x654b0bc ; 
00654B0B0  ldr      x9, [x1, #0x60]
00654B0B4  mov      x0, x8
00654B0B8  blr      x9
00654B0BC  cbz      x0, #0x654b2d4
00654B0C0  add      x8, sp, #0x60
00654B0C4  mov      x1, xzr
00654B0C8  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00654B0CC  ldr      x8, [x19, #0x118]
00654B0D0  cbz      x8, #0x654b2d4
00654B0D4  ldr      x0, [x19, #0x58]
00654B0D8  cbz      x0, #0x654b2d4
00654B0DC  ldr      x1, [x22]
00654B0E0  ldr      x24, [sp, #0x60]
00654B0E4  ldr      x25, [x8, #0x10]
00654B0E8  ldrb     w9, [x1, #0x53]
00654B0EC  tbnz     w9, #5, #0x654b0f8
00654B0F0  ldr      x0, [x0, #0x38]
00654B0F4  b        #0x654b100 ; 
00654B0F8  ldr      x8, [x1, #0x60]
00654B0FC  blr      x8
00654B100  cbz      x0, #0x654b2d4
00654B104  add      x8, sp, #0x60
00654B108  mov      x1, xzr
00654B10C  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00654B110  ldr      x0, [x19, #0x58]
00654B114  cbz      x0, #0x654b2d4
00654B118  ldr      x1, [x22]
00654B11C  ldr      x22, [sp, #0x68]
00654B120  ldrb     w8, [x1, #0x53]
00654B124  tbnz     w8, #5, #0x654b130
00654B128  ldr      x0, [x0, #0x38]
00654B12C  b        #0x654b138 ; 
00654B130  ldr      x8, [x1, #0x60]
00654B134  blr      x8
00654B138  cbz      x0, #0x654b2d4
00654B13C  add      x8, sp, #0x60
00654B140  mov      x1, xzr
00654B144  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00654B148  ldr      x8, [x19, #0x118]
00654B14C  cbz      x8, #0x654b2d4
00654B150  ldr      x9, [sp, #0x70]
00654B154  ldr      x8, [x8, #0x18]
00654B158  add      x1, x25, x24
00654B15C  add      x0, sp, #0x18
00654B160  mov      x2, x22
00654B164  add      x3, x8, x9
00654B168  mov      x4, xzr
00654B16C  stp      xzr, xzr, [sp, #0x18]
00654B170  str      xzr, [sp, #0x28]
00654B174  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
00654B178  cbz      x21, #0x654b2d4
00654B17C  adrp     x22, #0x9598000
00654B180  ldur     q0, [sp, #0x18]
00654B184  ldr      x8, [sp, #0x28]
00654B188  ldrb     w9, [x22, #0xfb9]
00654B18C  str      q0, [sp]
00654B190  str      x8, [sp, #0x10]
00654B194  cbnz     w9, #0x654b1ac
00654B198  adrp     x0, #0x8f05000
00654B19C  ldr      x0, [x0, #0x830] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.SetData()
00654B1A0  bl       #0x382bd14 ; 
00654B1A4  mov      w8, #1
00654B1A8  strb     w8, [x22, #0xfb9]
00654B1AC  adrp     x8, #0x8f05000
00654B1B0  ldr      x8, [x8, #0x830] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.SetData()
00654B1B4  ldr      x2, [x8]
00654B1B8  ldrb     w8, [x2, #0x53]
00654B1BC  tbnz     w8, #5, #0x654b1d4
00654B1C0  ldr      x8, [sp, #0x10]
00654B1C4  ldr      q0, [sp]
00654B1C8  str      x8, [x21, #0x98]
00654B1CC  stur     q0, [x21, #0x88]
00654B1D0  b        #0x654b1f4 ; 
00654B1D4  ldr      q0, [sp]
00654B1D8  ldr      x8, [sp, #0x10]
00654B1DC  ldr      x9, [x2, #0x60]
00654B1E0  add      x1, sp, #0x60
00654B1E4  mov      x0, x21
00654B1E8  str      q0, [sp, #0x60]
00654B1EC  str      x8, [sp, #0x70]
00654B1F0  blr      x9
00654B1F4  cbz      x20, #0x654b2d4
00654B1F8  adrp     x24, #0x8f05000
00654B1FC  ldr      x24, [x24, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
00654B200  mov      x0, x20
00654B204  mov      x1, x21
00654B208  ldr      x2, [x24]
00654B20C  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
00654B210  ldr      x8, [x19, #0x118]
00654B214  cbz      x8, #0x654b2d4
00654B218  ldrb     w8, [x8, #0x40]
00654B21C  cbz      w8, #0x654b29c
00654B220  adrp     x8, #0x8f05000
00654B224  ldr      x8, [x8, #0x800] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackActionLoop>()
00654B228  mov      x0, x19
00654B22C  ldr      x1, [x8]
00654B230  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654B234  adrp     x8, #0x8f05000
00654B238  ldr      x8, [x8, #0x818] ; GLOBAL System.Func<FP>_TypeInfo
00654B23C  mov      x21, x0
00654B240  ldr      x8, [x8]
00654B244  mov      x0, x8
00654B248  bl       #0x382bfa0 ; 
00654B24C  adrp     x8, #0x8f05000
00654B250  ldr      x8, [x8, #0x7f8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.<InitAttackLoop>b__4_0()
00654B254  mov      x1, x19
00654B258  mov      x3, xzr
00654B25C  mov      x22, x0
00654B260  ldr      x2, [x8]
00654B264  bl       #0x635b760 ; System.Func<FP>$$.ctor
00654B268  ldr      x8, [x19, #0x118]
00654B26C  cbz      x8, #0x654b2d4
00654B270  cbz      x21, #0x654b2d4
00654B274  ldr      x2, [x8, #0x38]
00654B278  mov      w3, #1
00654B27C  mov      x0, x21
00654B280  mov      x1, x22
00654B284  mov      x4, xzr
00654B288  bl       #0x660bcc0 ; HotFix.BattleLogic.AttackActionLoop$$SetData
00654B28C  ldr      x2, [x24]
00654B290  mov      x0, x20
00654B294  mov      x1, x21
00654B298  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
00654B29C  mov      x0, x19
00654B2A0  mov      x1, x20
00654B2A4  mov      x2, xzr
00654B2A8  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654B2AC  ldr      x8, [x23, #0x28]
00654B2B0  ldr      x9, [sp, #0x78]
00654B2B4  cmp      x8, x9
00654B2B8  b.ne     #0x654b2d8
00654B2BC  ldp      x20, x19, [sp, #0xb0]
00654B2C0  ldp      x22, x21, [sp, #0xa0]
00654B2C4  ldp      x24, x23, [sp, #0x90]
00654B2C8  ldp      x30, x25, [sp, #0x80]
00654B2CC  add      sp, sp, #0xc0
00654B2D0  ret      
00654B2D4  bl       #0x382bfb8 ; 
00654B2D8  bl       #0x89edb60 ; 

