; HotFix.BattleLogic.BasePunchboardState$$GetPunchboardRandomCount
; RVA 0x65A03AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065A03AC  stp      x30, x21, [sp, #-0x20]!
0065A03B0  stp      x20, x19, [sp, #0x10]
0065A03B4  adrp     x20, #0x9599000
0065A03B8  adrp     x21, #0x8f09000
0065A03BC  ldrb     w8, [x20, #0x336]
0065A03C0  ldr      x21, [x21, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.GetPunchboardRandomCount() @ 0x923b6a8
0065A03C4  mov      x19, x0
0065A03C8  tbnz     w8, #0, #0x65a03ec
0065A03CC  adrp     x0, #0x8f09000
0065A03D0  ldr      x0, [x0, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.GetPunchboardRandomCount() @ 0x923b6a8
0065A03D4  bl       #0x382bd14 ; 
0065A03D8  adrp     x0, #0x8f07000
0065A03DC  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065A03E0  bl       #0x382bd14 ; 
0065A03E4  mov      w8, #1
0065A03E8  strb     w8, [x20, #0x336]
0065A03EC  ldr      x1, [x21]
0065A03F0  ldrb     w8, [x1, #0x53]
0065A03F4  tbnz     w8, #5, #0x65a0424
0065A03F8  ldr      x0, [x19, #0x18]
0065A03FC  cbz      x0, #0x65a0438
0065A0400  adrp     x8, #0x8f07000
0065A0404  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065A0408  ldr      x1, [x8]
0065A040C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065A0410  cbz      x0, #0x65a0438
0065A0414  ldp      x20, x19, [sp, #0x10]
0065A0418  mov      x1, xzr
0065A041C  ldp      x30, x21, [sp], #0x20
0065A0420  b        #0x686f88c ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetPunchboardRandomCount
0065A0424  ldr      x2, [x1, #0x60]
0065A0428  mov      x0, x19
0065A042C  ldp      x20, x19, [sp, #0x10]
0065A0430  ldp      x30, x21, [sp], #0x20
0065A0434  br       x2
0065A0438  bl       #0x382bfb8 ; 

