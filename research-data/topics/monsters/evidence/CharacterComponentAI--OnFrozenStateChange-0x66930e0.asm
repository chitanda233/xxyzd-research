; HotFix.BattleLogic.CharacterComponentAI$$OnFrozenStateChange
; RVA 0x66930E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066930E0  str      x30, [sp, #-0x30]!
0066930E4  stp      x22, x21, [sp, #0x10]
0066930E8  stp      x20, x19, [sp, #0x20]
0066930EC  adrp     x21, #0x959a000
0066930F0  adrp     x22, #0x8f10000
0066930F4  ldrb     w8, [x21, #0x46]
0066930F8  ldr      x22, [x22, #0xa08] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnFrozenStateChange()
0066930FC  mov      w19, w1
006693100  mov      x20, x0
006693104  tbnz     w8, #0, #0x669311c
006693108  adrp     x0, #0x8f10000
00669310C  ldr      x0, [x0, #0xa08] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnFrozenStateChange()
006693110  bl       #0x382bd14 ; 
006693114  mov      w8, #1
006693118  strb     w8, [x21, #0x46]
00669311C  ldr      x2, [x22]
006693120  ldrb     w8, [x2, #0x53]
006693124  tbnz     w8, #5, #0x6693144
006693128  ldr      x0, [x20, #0x40]
00669312C  cbz      x0, #0x6693178
006693130  ldr      x8, [x0]
006693134  tbz      w19, #0, #0x6693160
006693138  ldr      x2, [x8, #0x238]
00669313C  ldr      x1, [x8, #0x240]
006693140  b        #0x6693168 ; 
006693144  ldr      x3, [x2, #0x60]
006693148  and      w1, w19, #1
00669314C  mov      x0, x20
006693150  ldp      x20, x19, [sp, #0x20]
006693154  ldp      x22, x21, [sp, #0x10]
006693158  ldr      x30, [sp], #0x30
00669315C  br       x3
006693160  ldr      x2, [x8, #0x248]
006693164  ldr      x1, [x8, #0x250]
006693168  ldp      x20, x19, [sp, #0x20]
00669316C  ldp      x22, x21, [sp, #0x10]
006693170  ldr      x30, [sp], #0x30
006693174  br       x2
006693178  bl       #0x382bfb8 ; 

