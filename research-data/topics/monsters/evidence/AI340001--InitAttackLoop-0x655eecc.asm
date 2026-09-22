; HotFix.BattleLogic.AI340001$$InitAttackLoop
; RVA 0x655EECC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00655EECC  stp      x30, x21, [sp, #-0x20]!
00655EED0  stp      x20, x19, [sp, #0x10]
00655EED4  adrp     x20, #0x9598000
00655EED8  adrp     x21, #0x8f06000
00655EEDC  ldrb     w8, [x20, #0xf32]
00655EEE0  ldr      x21, [x21, #0x438] ; GLOBAL Method$HotFix.BattleLogic.AI340001.InitAttackLoop()
00655EEE4  mov      x19, x0
00655EEE8  tbnz     w8, #0, #0x655ef18
00655EEEC  adrp     x0, #0x8f06000
00655EEF0  ldr      x0, [x0, #0x438] ; GLOBAL Method$HotFix.BattleLogic.AI340001.InitAttackLoop()
00655EEF4  bl       #0x382bd14 ; 
00655EEF8  adrp     x0, #0x8f05000
00655EEFC  ldr      x0, [x0, #0xc80] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveRandomReverse>()
00655EF00  bl       #0x382bd14 ; 
00655EF04  adrp     x0, #0x8f05000
00655EF08  ldr      x0, [x0, #0x828] ; GLOBAL Idle
00655EF0C  bl       #0x382bd14 ; 
00655EF10  mov      w8, #1
00655EF14  strb     w8, [x20, #0xf32]
00655EF18  ldr      x1, [x21]
00655EF1C  ldrb     w8, [x1, #0x53]
00655EF20  tbnz     w8, #5, #0x655ef9c
00655EF24  ldr      x0, [x19, #0x58]
00655EF28  cbz      x0, #0x655f00c
00655EF2C  adrp     x8, #0x8f05000
00655EF30  ldr      x8, [x8, #0x828] ; GLOBAL Idle
00655EF34  mov      x2, xzr
00655EF38  ldr      x1, [x8]
00655EF3C  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
00655EF40  ldr      x20, [x19, #0x58]
00655EF44  mov      x0, x19
00655EF48  mov      x1, xzr
00655EF4C  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00655EF50  cbz      x20, #0x655f00c
00655EF54  mov      x1, x0
00655EF58  mov      x0, x20
00655EF5C  mov      x2, xzr
00655EF60  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00655EF64  ldrb     w8, [x19, #0x129]
00655EF68  cbz      w8, #0x655efb0
00655EF6C  ldr      x8, [x19, #0x130]
00655EF70  strb     wzr, [x19, #0x129]
00655EF74  mov      x0, x19
00655EF78  mov      w1, #1
00655EF7C  neg      x8, x8
00655EF80  str      x8, [x19, #0x130]
00655EF84  ldp      x20, x19, [sp, #0x10]
00655EF88  mov      x2, xzr
00655EF8C  mov      x3, xzr
00655EF90  mov      x4, xzr
00655EF94  ldp      x30, x21, [sp], #0x20
00655EF98  b        #0x6b7f374 ; HotFix.BattleLogic.AIStateController$$AddTaskAttack
00655EF9C  ldr      x2, [x1, #0x60]
00655EFA0  mov      x0, x19
00655EFA4  ldp      x20, x19, [sp, #0x10]
00655EFA8  ldp      x30, x21, [sp], #0x20
00655EFAC  br       x2
00655EFB0  adrp     x8, #0x8f05000
00655EFB4  ldr      x8, [x8, #0xc80] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveRandomReverse>()
00655EFB8  mov      x0, x19
00655EFBC  ldr      x1, [x8]
00655EFC0  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00655EFC4  ldr      x8, [x19, #0x118]
00655EFC8  cbz      x8, #0x655f00c
00655EFCC  mov      x20, x0
00655EFD0  cbz      x0, #0x655f00c
00655EFD4  ldr      x1, [x8, #0x30]
00655EFD8  mov      x0, x20
00655EFDC  mov      x2, xzr
00655EFE0  bl       #0x6617604 ; HotFix.BattleLogic.MonsterMoveRandomReverse$$SetData
00655EFE4  mov      w21, #1
00655EFE8  mov      x0, x19
00655EFEC  mov      x1, x20
00655EFF0  mov      x2, xzr
00655EFF4  strb     w21, [x20, #0xc0]
00655EFF8  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00655EFFC  strb     w21, [x19, #0x129]
00655F000  ldp      x20, x19, [sp, #0x10]
00655F004  ldp      x30, x21, [sp], #0x20
00655F008  ret      
00655F00C  bl       #0x382bfb8 ; 

