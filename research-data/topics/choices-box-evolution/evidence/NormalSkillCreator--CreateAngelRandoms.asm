; HotFix.BattleLogic.NormalSkillCreator$$CreateAngelRandoms
; RVA 0x68741FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068741FC  str      x30, [sp, #-0x60]!
006874200  stp      x28, x27, [sp, #0x10]
006874204  stp      x26, x25, [sp, #0x20]
006874208  stp      x24, x23, [sp, #0x30]
00687420C  stp      x22, x21, [sp, #0x40]
006874210  stp      x20, x19, [sp, #0x50]
006874214  adrp     x20, #0x959b000
006874218  adrp     x21, #0x8f24000
00687421C  ldrb     w8, [x20, #0xaa4]
006874220  ldr      x21, [x21, #0x488] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.CreateAngelRandoms() @ 0x9295e78
006874224  mov      x19, x0
006874228  tbnz     w8, #0, #0x6874258
00687422C  adrp     x0, #0x8ee8000
006874230  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006874234  bl       #0x382bd14 ; 
006874238  adrp     x0, #0x8f24000
00687423C  ldr      x0, [x0, #0x488] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.CreateAngelRandoms() @ 0x9295e78
006874240  bl       #0x382bd14 ; 
006874244  adrp     x0, #0x8f23000
006874248  ldr      x0, [x0, #0xb20] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeightRandom>() @ 0x92ceb38
00687424C  bl       #0x382bd14 ; 
006874250  mov      w8, #1
006874254  strb     w8, [x20, #0xaa4]
006874258  ldr      x1, [x21]
00687425C  ldrb     w8, [x1, #0x53]
006874260  tbnz     w8, #5, #0x6874350
006874264  adrp     x23, #0x8ee8000
006874268  adrp     x24, #0x8f23000
00687426C  adrp     x20, #0x8ee5000
006874270  ldr      x23, [x23, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006874274  ldr      x24, [x24, #0xb20] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeightRandom>() @ 0x92ceb38
006874278  ldr      x20, [x20, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator() @ 0x923fe80
00687427C  mov      x22, xzr
006874280  mov      w25, #0x20
006874284  adrp     x26, #0x9591000
006874288  mov      w27, #1
00687428C  ldr      x0, [x23]
006874290  ldr      w8, [x0, #0xe0]
006874294  cbnz     w8, #0x68742a0
006874298  bl       #0x382be8c ; 
00687429C  ldr      x0, [x23]
0068742A0  ldr      x8, [x0, #0xb8]
0068742A4  ldrsw    x8, [x8, #0x2f0]
0068742A8  cmp      x22, x8
0068742AC  b.ge     #0x6874374
0068742B0  ldr      x28, [x19, #0x78]
0068742B4  mov      x0, x19
0068742B8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068742BC  cbz      x0, #0x6874390
0068742C0  ldrb     w8, [x26, #0xa4c]
0068742C4  mov      x21, x0
0068742C8  cbnz     w8, #0x68742d8
0068742CC  mov      x0, x20
0068742D0  bl       #0x382bd14 ; 
0068742D4  strb     w27, [x26, #0xa4c]
0068742D8  ldr      x1, [x20]
0068742DC  ldrb     w8, [x1, #0x53]
0068742E0  tbnz     w8, #5, #0x68742ec
0068742E4  ldr      x0, [x21, #0x210]
0068742E8  b        #0x68742f8 ; 
0068742EC  ldr      x8, [x1, #0x60]
0068742F0  mov      x0, x21
0068742F4  blr      x8
0068742F8  cbz      x0, #0x6874390
0068742FC  ldr      x1, [x24]
006874300  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
006874304  cbz      x28, #0x6874390
006874308  mov      x21, x0
00687430C  cbz      x0, #0x6874324
006874310  ldr      x8, [x28]
006874314  mov      x0, x21
006874318  ldr      x1, [x8, #0x40]
00687431C  bl       #0x382be90 ; 
006874320  cbz      x0, #0x6874398
006874324  ldr      w8, [x28, #0x18]
006874328  cmp      x22, x8
00687432C  b.hs     #0x6874394
006874330  add      x8, x28, x22, lsl #3
006874334  add      x0, x28, x25
006874338  mov      x1, x21
00687433C  str      x21, [x8, #0x20]
006874340  bl       #0x382bcb8 ; 
006874344  add      x22, x22, #1
006874348  add      x25, x25, #8
00687434C  b        #0x687428c ; 
006874350  ldr      x2, [x1, #0x60]
006874354  mov      x0, x19
006874358  ldp      x20, x19, [sp, #0x50]
00687435C  ldp      x22, x21, [sp, #0x40]
006874360  ldp      x24, x23, [sp, #0x30]
006874364  ldp      x26, x25, [sp, #0x20]
006874368  ldp      x28, x27, [sp, #0x10]
00687436C  ldr      x30, [sp], #0x60
006874370  br       x2
006874374  ldp      x20, x19, [sp, #0x50]
006874378  ldp      x22, x21, [sp, #0x40]
00687437C  ldp      x24, x23, [sp, #0x30]
006874380  ldp      x26, x25, [sp, #0x20]
006874384  ldp      x28, x27, [sp, #0x10]
006874388  ldr      x30, [sp], #0x60
00687438C  ret      
006874390  bl       #0x382bfb8 ; 
006874394  bl       #0x382bfc0 ; 
006874398  bl       #0x382bfdc ; 
00687439C  mov      x1, xzr
0068743A0  bl       #0x382be7c ; 

