; HotFix.BattleLogic.EntityCharacterData$$get_IsTypeMonster
; RVA 0x682342C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00682342C  stp      x30, x21, [sp, #-0x20]!
006823430  stp      x20, x19, [sp, #0x10]
006823434  adrp     x20, #0x959b000
006823438  adrp     x21, #0x8f22000
00682343C  ldrb     w8, [x20, #0x6c5]
006823440  ldr      x21, [x21, #0x80] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonster()
006823444  mov      x19, x0
006823448  tbnz     w8, #0, #0x6823460
00682344C  adrp     x0, #0x8f22000
006823450  ldr      x0, [x0, #0x80] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonster()
006823454  bl       #0x382bd14 ; 
006823458  mov      w8, #1
00682345C  strb     w8, [x20, #0x6c5]
006823460  ldr      x1, [x21]
006823464  ldrb     w8, [x1, #0x53]
006823468  tbnz     w8, #5, #0x6823494
00682346C  mov      x0, x19
006823470  bl       #0x68234b8 ; HotFix.BattleLogic.EntityCharacterData$$get_IsTypeMonsterNormal
006823474  tbnz     w0, #0, #0x6823484
006823478  mov      x0, x19
00682347C  bl       #0x6823528 ; HotFix.BattleLogic.EntityCharacterData$$get_IsTypeMonsterElite
006823480  tbz      w0, #0, #0x68234a8
006823484  ldp      x20, x19, [sp, #0x10]
006823488  mov      w0, #1
00682348C  ldp      x30, x21, [sp], #0x20
006823490  ret      
006823494  ldr      x2, [x1, #0x60]
006823498  mov      x0, x19
00682349C  ldp      x20, x19, [sp, #0x10]
0068234A0  ldp      x30, x21, [sp], #0x20
0068234A4  br       x2
0068234A8  mov      x0, x19
0068234AC  ldp      x20, x19, [sp, #0x10]
0068234B0  ldp      x30, x21, [sp], #0x20
0068234B4  b        #0x6823598 ; HotFix.BattleLogic.EntityCharacterData$$get_IsTypeMonsterBoss

