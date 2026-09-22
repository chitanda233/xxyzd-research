; HotFix.BattleLogic.AI320013$$InitAttackLoop
; RVA 0x6B9ADA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B9ADA8  sub      sp, sp, #0x70
006B9ADAC  str      x30, [sp, #0x40]
006B9ADB0  stp      x22, x21, [sp, #0x50]
006B9ADB4  stp      x20, x19, [sp, #0x60]
006B9ADB8  mrs      x22, tpidr_el0
006B9ADBC  ldr      x8, [x22, #0x28]
006B9ADC0  adrp     x20, #0x95a0000
006B9ADC4  adrp     x21, #0x8f44000
006B9ADC8  mov      x19, x0
006B9ADCC  str      x8, [sp, #0x38]
006B9ADD0  ldrb     w8, [x20, #0x7c]
006B9ADD4  ldr      x21, [x21, #0x178] ; GLOBAL Method$HotFix.BattleLogic.AI320013.InitAttackLoop()
006B9ADD8  tbnz     w8, #0, #0x6b9ae44
006B9ADDC  adrp     x0, #0x8f44000
006B9ADE0  ldr      x0, [x0, #0x178] ; GLOBAL Method$HotFix.BattleLogic.AI320013.InitAttackLoop()
006B9ADE4  bl       #0x382bd14 ; 
006B9ADE8  adrp     x0, #0x8f44000
006B9ADEC  ldr      x0, [x0, #0x180] ; GLOBAL Method$HotFix.BattleLogic.AI320013.<InitAttackLoop>b__10_0()
006B9ADF0  bl       #0x382bd14 ; 
006B9ADF4  adrp     x0, #0x8f44000
006B9ADF8  ldr      x0, [x0, #0x188] ; GLOBAL Method$HotFix.BattleLogic.AI320013.<InitAttackLoop>b__10_1()
006B9ADFC  bl       #0x382bd14 ; 
006B9AE00  adrp     x0, #0x8f42000
006B9AE04  ldr      x0, [x0, #0x3e8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackAction>()
006B9AE08  bl       #0x382bd14 ; 
006B9AE0C  adrp     x0, #0x8f06000
006B9AE10  ldr      x0, [x0, #0x4a0] ; GLOBAL System.Action<TaskBase<FP>>_TypeInfo
006B9AE14  bl       #0x382bd14 ; 
006B9AE18  adrp     x0, #0x8f05000
006B9AE1C  ldr      x0, [x0, #0xaf8] ; GLOBAL System.Action<TaskBase<FP>, bool>_TypeInfo
006B9AE20  bl       #0x382bd14 ; 
006B9AE24  adrp     x0, #0x8f06000
006B9AE28  ldr      x0, [x0, #0x4a8] ; GLOBAL Method$System.Linq.Enumerable.ToList<int>()
006B9AE2C  bl       #0x382bd14 ; 
006B9AE30  adrp     x0, #0x8f05000
006B9AE34  ldr      x0, [x0, #0x828] ; GLOBAL Idle
006B9AE38  bl       #0x382bd14 ; 
006B9AE3C  mov      w8, #1
006B9AE40  strb     w8, [x20, #0x7c]
006B9AE44  ldr      x1, [x21]
006B9AE48  ldrb     w8, [x1, #0x53]
006B9AE4C  tbnz     w8, #5, #0x6b9aed0
006B9AE50  ldr      x0, [x19, #0x58]
006B9AE54  cbz      x0, #0x6b9b070
006B9AE58  adrp     x8, #0x8f05000
006B9AE5C  ldr      x8, [x8, #0x828] ; GLOBAL Idle
006B9AE60  mov      x2, xzr
006B9AE64  ldr      x1, [x8]
006B9AE68  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
006B9AE6C  ldr      x20, [x19, #0x58]
006B9AE70  mov      x0, x19
006B9AE74  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
006B9AE78  cbz      x20, #0x6b9b070
006B9AE7C  mov      x1, x0
006B9AE80  mov      x0, x20
006B9AE84  mov      x2, xzr
006B9AE88  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
006B9AE8C  ldr      x20, [x19, #0x58]
006B9AE90  cbz      x20, #0x6b9b070
006B9AE94  adrp     x21, #0x9598000
006B9AE98  ldrb     w8, [x21, #0xfb7]
006B9AE9C  cbnz     w8, #0x6b9aeb4
006B9AEA0  adrp     x0, #0x8f05000
006B9AEA4  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006B9AEA8  bl       #0x382bd14 ; 
006B9AEAC  mov      w8, #1
006B9AEB0  strb     w8, [x21, #0xfb7]
006B9AEB4  adrp     x8, #0x8f05000
006B9AEB8  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006B9AEBC  ldr      x1, [x8]
006B9AEC0  ldrb     w8, [x1, #0x53]
006B9AEC4  tbnz     w8, #5, #0x6b9aee0
006B9AEC8  ldr      x20, [x20, #0x118]
006B9AECC  b        #0x6b9aef0 ; 
006B9AED0  ldr      x8, [x1, #0x60]
006B9AED4  mov      x0, x19
006B9AED8  blr      x8
006B9AEDC  b        #0x6b9b04c ; 
006B9AEE0  ldr      x8, [x1, #0x60]
006B9AEE4  mov      x0, x20
006B9AEE8  blr      x8
006B9AEEC  mov      x20, x0
006B9AEF0  ldr      x8, [x19, #0x118]
006B9AEF4  cbz      x8, #0x6b9b070
006B9AEF8  ldp      x1, x3, [x8, #0x20]
006B9AEFC  add      x0, sp, #0x20
006B9AF00  mov      x2, xzr
006B9AF04  mov      x4, xzr
006B9AF08  stp      xzr, xzr, [sp, #0x20]
006B9AF0C  str      xzr, [sp, #0x30]
006B9AF10  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
006B9AF14  cbz      x20, #0x6b9b070
006B9AF18  ldr      q0, [sp, #0x20]
006B9AF1C  ldr      x8, [sp, #0x30]
006B9AF20  mov      x1, sp
006B9AF24  mov      x0, x20
006B9AF28  mov      x2, xzr
006B9AF2C  str      q0, [sp]
006B9AF30  str      x8, [sp, #0x10]
006B9AF34  bl       #0x672c948 ; HotFix.BattleLogic.CharacterComponentTransform$$LookRotationDir
006B9AF38  ldr      x1, [x19, #0x120]
006B9AF3C  mov      x0, x19
006B9AF40  bl       #0x6b963c4 ; HotFix.BattleLogic.AIStateController$$GetMultiRedLineWarningTask
006B9AF44  ldr      x8, [x19, #0x138]
006B9AF48  cbz      x8, #0x6b9b070
006B9AF4C  mov      x20, x0
006B9AF50  mov      x0, x8
006B9AF54  mov      x1, xzr
006B9AF58  bl       #0x6b21e6c ; LocalModels.Bean.Weapon_Weapon$$GetEntityPosTypes
006B9AF5C  adrp     x8, #0x8f06000
006B9AF60  ldr      x8, [x8, #0x4a8] ; GLOBAL Method$System.Linq.Enumerable.ToList<int>()
006B9AF64  ldr      x1, [x8]
006B9AF68  bl       #0x45dc05c ; System.Linq.Enumerable$$ToList<int>
006B9AF6C  cbz      x20, #0x6b9b070
006B9AF70  mov      x1, x0
006B9AF74  mov      x0, x20
006B9AF78  str      x1, [x0, #0x88]!
006B9AF7C  bl       #0x382bcb8 ; 
006B9AF80  ldr      x8, [x19, #0x118]
006B9AF84  cbz      x8, #0x6b9b070
006B9AF88  ldr      w8, [x8, #0x38]
006B9AF8C  str      w8, [x20, #0x80]
006B9AF90  adrp     x8, #0x8f06000
006B9AF94  ldr      x8, [x8, #0x4a0] ; GLOBAL System.Action<TaskBase<FP>>_TypeInfo
006B9AF98  ldr      x0, [x8]
006B9AF9C  bl       #0x382bfa0 ; 
006B9AFA0  adrp     x8, #0x8f44000
006B9AFA4  ldr      x8, [x8, #0x180] ; GLOBAL Method$HotFix.BattleLogic.AI320013.<InitAttackLoop>b__10_0()
006B9AFA8  mov      x1, x19
006B9AFAC  mov      x3, xzr
006B9AFB0  mov      x21, x0
006B9AFB4  ldr      x2, [x8]
006B9AFB8  bl       #0x5f44014 ; System.Action<object>$$.ctor
006B9AFBC  mov      x0, x20
006B9AFC0  str      x21, [x0, #0x40]!
006B9AFC4  mov      x1, x21
006B9AFC8  bl       #0x382bcb8 ; 
006B9AFCC  adrp     x8, #0x8f05000
006B9AFD0  ldr      x8, [x8, #0xaf8] ; GLOBAL System.Action<TaskBase<FP>, bool>_TypeInfo
006B9AFD4  ldr      x0, [x8]
006B9AFD8  bl       #0x382bfa0 ; 
006B9AFDC  adrp     x8, #0x8f44000
006B9AFE0  ldr      x8, [x8, #0x188] ; GLOBAL Method$HotFix.BattleLogic.AI320013.<InitAttackLoop>b__10_1()
006B9AFE4  mov      x1, x19
006B9AFE8  mov      x3, xzr
006B9AFEC  mov      x21, x0
006B9AFF0  ldr      x2, [x8]
006B9AFF4  bl       #0x60424d0 ; System.Action<object, bool>$$.ctor
006B9AFF8  mov      x0, x20
006B9AFFC  str      x21, [x0, #0x38]!
006B9B000  mov      x1, x21
006B9B004  bl       #0x382bcb8 ; 
006B9B008  mov      x0, x19
006B9B00C  mov      x1, x20
006B9B010  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006B9B014  ldr      x1, [x19, #0x130]
006B9B018  mov      x0, x19
006B9B01C  bl       #0x6b809a0 ; HotFix.BattleLogic.AIStateController$$AddTaskWait
006B9B020  adrp     x8, #0x8f42000
006B9B024  ldr      x8, [x8, #0x3e8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<AttackAction>()
006B9B028  mov      x0, x19
006B9B02C  ldr      x1, [x8]
006B9B030  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
006B9B034  mov      x1, x0
006B9B038  mov      x0, x19
006B9B03C  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006B9B040  ldr      x1, [x19, #0x128]
006B9B044  mov      x0, x19
006B9B048  bl       #0x6b809a0 ; HotFix.BattleLogic.AIStateController$$AddTaskWait
006B9B04C  ldr      x8, [x22, #0x28]
006B9B050  ldr      x9, [sp, #0x38]
006B9B054  cmp      x8, x9
006B9B058  b.ne     #0x6b9b074
006B9B05C  ldp      x20, x19, [sp, #0x60]
006B9B060  ldp      x22, x21, [sp, #0x50]
006B9B064  ldr      x30, [sp, #0x40]
006B9B068  add      sp, sp, #0x70
006B9B06C  ret      
006B9B070  bl       #0x382bfb8 ; 
006B9B074  bl       #0x89edb60 ; 

