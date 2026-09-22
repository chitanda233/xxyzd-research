; HotFix.BattleLogic.EntityCharacterData$$get_IsTypeMonsterNormal
; RVA 0x68234B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068234B8  stp      x30, x21, [sp, #-0x20]!
0068234BC  stp      x20, x19, [sp, #0x10]
0068234C0  adrp     x20, #0x959b000
0068234C4  adrp     x21, #0x8f22000
0068234C8  ldrb     w8, [x20, #0x6c6]
0068234CC  ldr      x21, [x21, #0x88] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonsterNormal()
0068234D0  mov      x19, x0
0068234D4  tbnz     w8, #0, #0x68234ec
0068234D8  adrp     x0, #0x8f22000
0068234DC  ldr      x0, [x0, #0x88] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonsterNormal()
0068234E0  bl       #0x382bd14 ; 
0068234E4  mov      w8, #1
0068234E8  strb     w8, [x20, #0x6c6]
0068234EC  ldr      x1, [x21]
0068234F0  ldrb     w8, [x1, #0x53]
0068234F4  tbnz     w8, #5, #0x6823514
0068234F8  mov      x0, x19
0068234FC  bl       #0x6823340 ; HotFix.BattleLogic.EntityCharacterData$$get_CharacterType
006823500  ldp      x20, x19, [sp, #0x10]
006823504  cmp      w0, #2
006823508  cset     w0, eq
00682350C  ldp      x30, x21, [sp], #0x20
006823510  ret      
006823514  ldr      x2, [x1, #0x60]
006823518  mov      x0, x19
00682351C  ldp      x20, x19, [sp, #0x10]
006823520  ldp      x30, x21, [sp], #0x20
006823524  br       x2

