; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$OnPlayerLevelUp
; RVA 0x65B7784; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B7784  stp      x30, x21, [sp, #-0x20]!
0065B7788  stp      x20, x19, [sp, #0x10]
0065B778C  adrp     x20, #0x9599000
0065B7790  adrp     x21, #0x8f09000
0065B7794  ldrb     w8, [x20, #0x445]
0065B7798  ldr      x21, [x21, #0xce0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.OnPlayerLevelUp() @ 0x92c8908
0065B779C  mov      x19, x0
0065B77A0  tbnz     w8, #0, #0x65b77c4
0065B77A4  adrp     x0, #0x8f07000
0065B77A8  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B77AC  bl       #0x382bd14 ; 
0065B77B0  adrp     x0, #0x8f09000
0065B77B4  ldr      x0, [x0, #0xce0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.OnPlayerLevelUp() @ 0x92c8908
0065B77B8  bl       #0x382bd14 ; 
0065B77BC  mov      w8, #1
0065B77C0  strb     w8, [x20, #0x445]
0065B77C4  ldr      x1, [x21]
0065B77C8  ldrb     w8, [x1, #0x53]
0065B77CC  tbnz     w8, #5, #0x65b7818
0065B77D0  ldr      x20, [x19, #0x18]
0065B77D4  cbz      x20, #0x65b786c
0065B77D8  adrp     x21, #0x9599000
0065B77DC  ldrb     w8, [x21, #0x4b0]
0065B77E0  cbnz     w8, #0x65b77f8
0065B77E4  adrp     x0, #0x8f08000
0065B77E8  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
0065B77EC  bl       #0x382bd14 ; 
0065B77F0  mov      w8, #1
0065B77F4  strb     w8, [x21, #0x4b0]
0065B77F8  adrp     x8, #0x8f08000
0065B77FC  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
0065B7800  ldr      x2, [x8]
0065B7804  ldrb     w8, [x2, #0x53]
0065B7808  tbnz     w8, #5, #0x65b782c
0065B780C  mov      w8, #1
0065B7810  strb     w8, [x20, #0x648]
0065B7814  b        #0x65b783c ; 
0065B7818  ldr      x2, [x1, #0x60]
0065B781C  mov      x0, x19
0065B7820  ldp      x20, x19, [sp, #0x10]
0065B7824  ldp      x30, x21, [sp], #0x20
0065B7828  br       x2
0065B782C  ldr      x8, [x2, #0x60]
0065B7830  mov      w1, #1
0065B7834  mov      x0, x20
0065B7838  blr      x8
0065B783C  ldr      x0, [x19, #0x18]
0065B7840  cbz      x0, #0x65b786c
0065B7844  adrp     x8, #0x8f07000
0065B7848  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B784C  ldr      x1, [x8]
0065B7850  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065B7854  cbz      x0, #0x65b786c
0065B7858  ldp      x20, x19, [sp, #0x10]
0065B785C  mov      w1, #1
0065B7860  mov      x2, xzr
0065B7864  ldp      x30, x21, [sp], #0x20
0065B7868  b        #0x6870474 ; HotFix.BattleLogic.HeroComponentRandomSkill$$OpenSelectSpecialSkill
0065B786C  bl       #0x382bfb8 ; 

