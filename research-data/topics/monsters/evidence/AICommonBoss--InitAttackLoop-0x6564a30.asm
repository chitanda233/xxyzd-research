; HotFix.BattleLogic.AICommonBoss$$InitAttackLoop
; RVA 0x6564A30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006564A30  stp      x30, x21, [sp, #-0x20]!
006564A34  stp      x20, x19, [sp, #0x10]
006564A38  adrp     x20, #0x9598000
006564A3C  adrp     x21, #0x8f06000
006564A40  ldrb     w8, [x20, #0xf89]
006564A44  ldr      x21, [x21, #0x808] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.InitAttackLoop()
006564A48  mov      x19, x0
006564A4C  tbnz     w8, #0, #0x6564a70
006564A50  adrp     x0, #0x8f06000
006564A54  ldr      x0, [x0, #0x808] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.InitAttackLoop()
006564A58  bl       #0x382bd14 ; 
006564A5C  adrp     x0, #0x8f05000
006564A60  ldr      x0, [x0, #0x828] ; GLOBAL Idle
006564A64  bl       #0x382bd14 ; 
006564A68  mov      w8, #1
006564A6C  strb     w8, [x20, #0xf89]
006564A70  ldr      x1, [x21]
006564A74  ldrb     w8, [x1, #0x53]
006564A78  tbnz     w8, #5, #0x6564b04
006564A7C  ldr      x0, [x19, #0x58]
006564A80  cbz      x0, #0x6564b44
006564A84  adrp     x8, #0x8f05000
006564A88  ldr      x8, [x8, #0x828] ; GLOBAL Idle
006564A8C  mov      x2, xzr
006564A90  ldr      x1, [x8]
006564A94  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
006564A98  ldr      x20, [x19, #0x58]
006564A9C  mov      x0, x19
006564AA0  mov      x1, xzr
006564AA4  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
006564AA8  cbz      x20, #0x6564b44
006564AAC  mov      x1, x0
006564AB0  mov      x0, x20
006564AB4  mov      x2, xzr
006564AB8  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
006564ABC  ldr      x1, [x19, #0x148]
006564AC0  mov      x0, x19
006564AC4  mov      x2, xzr
006564AC8  bl       #0x6b90668 ; HotFix.BattleLogic.AIStateController$$SelectWeightedRandomIndex
006564ACC  cmp      w0, #1
006564AD0  b.eq     #0x6564b18
006564AD4  cbnz     w0, #0x6564b38
006564AD8  ldr      x8, [x19, #0x118]
006564ADC  cbz      x8, #0x6564b44
006564AE0  ldr      x1, [x8, #0x20]
006564AE4  mov      x0, x19
006564AE8  mov      x2, xzr
006564AEC  bl       #0x6b90668 ; HotFix.BattleLogic.AIStateController$$SelectWeightedRandomIndex
006564AF0  mov      w1, w0
006564AF4  mov      x0, x19
006564AF8  ldp      x20, x19, [sp, #0x10]
006564AFC  ldp      x30, x21, [sp], #0x20
006564B00  b        #0x6564b48 ; HotFix.BattleLogic.AICommonBoss$$onRandomAI
006564B04  ldr      x2, [x1, #0x60]
006564B08  mov      x0, x19
006564B0C  ldp      x20, x19, [sp, #0x10]
006564B10  ldp      x30, x21, [sp], #0x20
006564B14  br       x2
006564B18  mov      x0, x19
006564B1C  bl       #0x6564f18 ; HotFix.BattleLogic.AICommonBoss$$getCallMonsterTaskWrapper
006564B20  mov      x1, x0
006564B24  mov      x0, x19
006564B28  ldp      x20, x19, [sp, #0x10]
006564B2C  mov      x2, xzr
006564B30  ldp      x30, x21, [sp], #0x20
006564B34  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006564B38  ldp      x20, x19, [sp, #0x10]
006564B3C  ldp      x30, x21, [sp], #0x20
006564B40  ret      
006564B44  bl       #0x382bfb8 ; 

