; HotFix.BattleLogic.WeightRandomData$$AddRejectFlag
; RVA 0x663220C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00663220C  str      x30, [sp, #-0x30]!
006632210  stp      x22, x21, [sp, #0x10]
006632214  stp      x20, x19, [sp, #0x20]
006632218  adrp     x21, #0x9599000
00663221C  adrp     x22, #0x8f0c000
006632220  ldrb     w8, [x21, #0x9c9]
006632224  ldr      x22, [x22, #0xed8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.AddRejectFlag() @ 0x92cbb70
006632228  mov      w20, w1
00663222C  mov      x19, x0
006632230  tbnz     w8, #0, #0x6632248
006632234  adrp     x0, #0x8f0c000
006632238  ldr      x0, [x0, #0xed8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.AddRejectFlag() @ 0x92cbb70
00663223C  bl       #0x382bd14 ; 
006632240  mov      w8, #1
006632244  strb     w8, [x21, #0x9c9]
006632248  ldr      x2, [x22]
00663224C  ldrb     w8, [x2, #0x53]
006632250  tbnz     w8, #5, #0x66322b0
006632254  cbz      w20, #0x663229c
006632258  ldr      x10, [x19, #0x10]
00663225C  cbz      x10, #0x663229c
006632260  ldr      w8, [x10, #0x18]
006632264  cmp      w8, #1
006632268  b.lt     #0x663229c
00663226C  mov      x9, xzr
006632270  add      x10, x10, #0x20
006632274  mov      w11, #1
006632278  cmp      w9, w8
00663227C  b.hs     #0x66322d8
006632280  ldr      w12, [x10, x9, lsl #2]
006632284  lsl      w12, w11, w12
006632288  cmp      w12, w20
00663228C  b.eq     #0x66322cc
006632290  add      x9, x9, #1
006632294  cmp      w9, w8
006632298  b.lt     #0x6632278
00663229C  mov      w0, wzr
0066322A0  ldp      x20, x19, [sp, #0x20]
0066322A4  ldp      x22, x21, [sp, #0x10]
0066322A8  ldr      x30, [sp], #0x30
0066322AC  ret      
0066322B0  ldr      x3, [x2, #0x60]
0066322B4  mov      x0, x19
0066322B8  mov      w1, w20
0066322BC  ldp      x20, x19, [sp, #0x20]
0066322C0  ldp      x22, x21, [sp, #0x10]
0066322C4  ldr      x30, [sp], #0x30
0066322C8  br       x3
0066322CC  mov      w0, #1
0066322D0  strb     w0, [x19, #0x20]
0066322D4  b        #0x66322a0 ; 
0066322D8  bl       #0x382bfc0 ; 

