; HotFix.BattleLogic.EntityCharacterData$$get_IsFLy
; RVA 0x68220A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068220A0  stp      x30, x21, [sp, #-0x20]!
0068220A4  stp      x20, x19, [sp, #0x10]
0068220A8  adrp     x20, #0x959b000
0068220AC  adrp     x21, #0x8f06000
0068220B0  ldrb     w8, [x20, #0x6b6]
0068220B4  ldr      x21, [x21, #0xab0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsFLy()
0068220B8  mov      x19, x0
0068220BC  tbnz     w8, #0, #0x68220d4
0068220C0  adrp     x0, #0x8f06000
0068220C4  ldr      x0, [x0, #0xab0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsFLy()
0068220C8  bl       #0x382bd14 ; 
0068220CC  mov      w8, #1
0068220D0  strb     w8, [x20, #0x6b6]
0068220D4  ldr      x1, [x21]
0068220D8  ldrb     w8, [x1, #0x53]
0068220DC  tbnz     w8, #5, #0x6822120
0068220E0  adrp     x20, #0x9591000
0068220E4  ldrb     w8, [x20, #0xa74]
0068220E8  cbnz     w8, #0x6822100
0068220EC  adrp     x0, #0x8ee6000
0068220F0  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068220F4  bl       #0x382bd14 ; 
0068220F8  mov      w8, #1
0068220FC  strb     w8, [x20, #0xa74]
006822100  adrp     x21, #0x8ee6000
006822104  ldr      x21, [x21, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822108  ldr      x1, [x21]
00682210C  ldrb     w8, [x1, #0x53]
006822110  tbnz     w8, #5, #0x6822134
006822114  ldr      x0, [x19, #0x170]
006822118  cbnz     x0, #0x6822144
00682211C  b        #0x68221d8 ; 
006822120  ldr      x2, [x1, #0x60]
006822124  mov      x0, x19
006822128  ldp      x20, x19, [sp, #0x10]
00682212C  ldp      x30, x21, [sp], #0x20
006822130  br       x2
006822134  ldr      x8, [x1, #0x60]
006822138  mov      x0, x19
00682213C  blr      x8
006822140  cbz      x0, #0x68221d8
006822144  ldrb     w8, [x20, #0xa74]
006822148  cbnz     w8, #0x6822160
00682214C  adrp     x0, #0x8ee6000
006822150  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822154  bl       #0x382bd14 ; 
006822158  mov      w8, #1
00682215C  strb     w8, [x20, #0xa74]
006822160  ldr      x1, [x21]
006822164  ldrb     w8, [x1, #0x53]
006822168  tbnz     w8, #5, #0x6822174
00682216C  ldr      x19, [x19, #0x170]
006822170  b        #0x6822184 ; 
006822174  ldr      x8, [x1, #0x60]
006822178  mov      x0, x19
00682217C  blr      x8
006822180  mov      x19, x0
006822184  cbz      x19, #0x68221e4
006822188  adrp     x20, #0x9598000
00682218C  ldrb     w8, [x20, #0xfc9]
006822190  cbnz     w8, #0x68221a8
006822194  adrp     x0, #0x8f06000
006822198  ldr      x0, [x0, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_moveType()
00682219C  bl       #0x382bd14 ; 
0068221A0  mov      w8, #1
0068221A4  strb     w8, [x20, #0xfc9]
0068221A8  adrp     x8, #0x8f06000
0068221AC  ldr      x8, [x8, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_moveType()
0068221B0  ldr      x1, [x8]
0068221B4  ldrb     w8, [x1, #0x53]
0068221B8  tbnz     w8, #5, #0x68221c4
0068221BC  ldr      w0, [x19, #0x1c0]
0068221C0  b        #0x68221d0 ; 
0068221C4  ldr      x8, [x1, #0x60]
0068221C8  mov      x0, x19
0068221CC  blr      x8
0068221D0  cmp      w0, #1
0068221D4  cset     w0, eq
0068221D8  ldp      x20, x19, [sp, #0x10]
0068221DC  ldp      x30, x21, [sp], #0x20
0068221E0  ret      
0068221E4  bl       #0x382bfb8 ; 

