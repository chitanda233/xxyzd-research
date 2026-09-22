; HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew$$InitAttackLoop
; RVA 0x654CE84; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654CE84  sub      sp, sp, #0x80
00654CE88  str      x30, [sp, #0x50]
00654CE8C  stp      x22, x21, [sp, #0x60]
00654CE90  stp      x20, x19, [sp, #0x70]
00654CE94  mrs      x22, tpidr_el0
00654CE98  ldr      x8, [x22, #0x28]
00654CE9C  adrp     x20, #0x9598000
00654CEA0  adrp     x21, #0x8f05000
00654CEA4  mov      x19, x0
00654CEA8  str      x8, [sp, #0x48]
00654CEAC  ldrb     w8, [x20, #0xe4f]
00654CEB0  ldr      x21, [x21, #0x960] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.InitAttackLoop()
00654CEB4  tbnz     w8, #0, #0x654cef0
00654CEB8  adrp     x0, #0x8f05000
00654CEBC  ldr      x0, [x0, #0x960] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.InitAttackLoop()
00654CEC0  bl       #0x382bd14 ; 
00654CEC4  adrp     x0, #0x8f05000
00654CEC8  ldr      x0, [x0, #0x968] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.OnMovePath()
00654CECC  bl       #0x382bd14 ; 
00654CED0  adrp     x0, #0x8f05000
00654CED4  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654CED8  bl       #0x382bd14 ; 
00654CEDC  adrp     x0, #0x8f05000
00654CEE0  ldr      x0, [x0, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
00654CEE4  bl       #0x382bd14 ; 
00654CEE8  mov      w8, #1
00654CEEC  strb     w8, [x20, #0xe4f]
00654CEF0  ldr      x1, [x21]
00654CEF4  ldrb     w8, [x1, #0x53]
00654CEF8  tbnz     w8, #5, #0x654cf84
00654CEFC  ldr      x8, [x19, #0x118]
00654CF00  cbz      x8, #0x654d0b0
00654CF04  ldr      w8, [x8, #0x38]
00654CF08  cbnz     w8, #0x654cf30
00654CF0C  ldr      x20, [x19, #0x58]
00654CF10  mov      x0, x19
00654CF14  mov      x1, xzr
00654CF18  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00654CF1C  cbz      x20, #0x654d0b0
00654CF20  mov      x1, x0
00654CF24  mov      x0, x20
00654CF28  mov      x2, xzr
00654CF2C  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00654CF30  ldrb     w8, [x19, #0x128]
00654CF34  cbz      w8, #0x654cff0
00654CF38  ldrb     w8, [x19, #0x129]
00654CF3C  cbnz     w8, #0x654cff0
00654CF40  ldr      x20, [x19, #0x58]
00654CF44  cbz      x20, #0x654d0b0
00654CF48  adrp     x21, #0x9598000
00654CF4C  ldrb     w8, [x21, #0xfb7]
00654CF50  cbnz     w8, #0x654cf68
00654CF54  adrp     x0, #0x8f05000
00654CF58  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654CF5C  bl       #0x382bd14 ; 
00654CF60  mov      w8, #1
00654CF64  strb     w8, [x21, #0xfb7]
00654CF68  adrp     x8, #0x8f05000
00654CF6C  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654CF70  ldr      x1, [x8]
00654CF74  ldrb     w8, [x1, #0x53]
00654CF78  tbnz     w8, #5, #0x654cf94
00654CF7C  ldr      x20, [x20, #0x118]
00654CF80  b        #0x654cfa4 ; 
00654CF84  ldr      x8, [x1, #0x60]
00654CF88  mov      x0, x19
00654CF8C  blr      x8
00654CF90  b        #0x654d08c ; 
00654CF94  ldr      x8, [x1, #0x60]
00654CF98  mov      x0, x20
00654CF9C  blr      x8
00654CFA0  mov      x20, x0
00654CFA4  ldr      x0, [x19, #0x58]
00654CFA8  cbz      x0, #0x654d0b0
00654CFAC  add      x8, sp, #0x18
00654CFB0  mov      x1, xzr
00654CFB4  bl       #0x67d6328 ; HotFix.BattleLogic.EntityCharacter$$GetLoopMoveRestartPos
00654CFB8  ldur     q0, [sp, #0x18]
00654CFBC  ldr      x8, [sp, #0x28]
00654CFC0  str      q0, [sp, #0x30]
00654CFC4  str      x8, [sp, #0x40]
00654CFC8  cbz      x20, #0x654d0b0
00654CFCC  ldr      q0, [sp, #0x30]
00654CFD0  ldr      x8, [sp, #0x40]
00654CFD4  mov      x1, sp
00654CFD8  mov      w2, #1
00654CFDC  mov      x0, x20
00654CFE0  mov      x3, xzr
00654CFE4  str      q0, [sp]
00654CFE8  str      x8, [sp, #0x10]
00654CFEC  bl       #0x672c418 ; HotFix.BattleLogic.CharacterComponentTransform$$MoveToPosition
00654CFF0  mov      w8, #1
00654CFF4  strh     w8, [x19, #0x128]
00654CFF8  adrp     x8, #0x8f05000
00654CFFC  ldr      x8, [x8, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654D000  mov      x0, x19
00654D004  ldr      x1, [x8]
00654D008  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654D00C  ldr      x8, [x19, #0x118]
00654D010  cbz      x8, #0x654d0b0
00654D014  mov      x20, x0
00654D018  cbz      x0, #0x654d0b0
00654D01C  ldr      w8, [x8, #0x10]
00654D020  strh     wzr, [x20, #0x74]
00654D024  str      w8, [x20, #0x70]
00654D028  adrp     x8, #0x8f05000
00654D02C  ldr      x8, [x8, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
00654D030  ldr      x0, [x8]
00654D034  bl       #0x382bfa0 ; 
00654D038  adrp     x8, #0x8f05000
00654D03C  ldr      x8, [x8, #0x968] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.OnMovePath()
00654D040  mov      x1, x19
00654D044  mov      x3, xzr
00654D048  mov      x21, x0
00654D04C  ldr      x2, [x8]
00654D050  bl       #0x5f40564 ; System.Action<FP>$$.ctor
00654D054  mov      x0, x20
00654D058  str      x21, [x0, #0x88]!
00654D05C  mov      x1, x21
00654D060  bl       #0x382bcb8 ; 
00654D064  ldr      x8, [x19, #0x118]
00654D068  cbz      x8, #0x654d0b0
00654D06C  ldr      w8, [x8, #0x28]
00654D070  mov      x0, x19
00654D074  mov      x1, x20
00654D078  mov      x2, xzr
00654D07C  cmp      w8, #1
00654D080  cset     w8, eq
00654D084  strb     w8, [x20, #0x90]
00654D088  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654D08C  ldr      x8, [x22, #0x28]
00654D090  ldr      x9, [sp, #0x48]
00654D094  cmp      x8, x9
00654D098  b.ne     #0x654d0b4
00654D09C  ldp      x20, x19, [sp, #0x70]
00654D0A0  ldp      x22, x21, [sp, #0x60]
00654D0A4  ldr      x30, [sp, #0x50]
00654D0A8  add      sp, sp, #0x80
00654D0AC  ret      
00654D0B0  bl       #0x382bfb8 ; 
00654D0B4  bl       #0x89edb60 ; 

