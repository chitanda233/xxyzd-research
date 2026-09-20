; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectFlag
; RVA 0x6874ABC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874ABC  str      x30, [sp, #-0x30]!
006874AC0  stp      x22, x21, [sp, #0x10]
006874AC4  stp      x20, x19, [sp, #0x20]
006874AC8  adrp     x21, #0x959b000
006874ACC  adrp     x22, #0x8f24000
006874AD0  ldrb     w8, [x21, #0xab0]
006874AD4  ldr      x22, [x22, #0x4c8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnAddRejectFlag() @ 0x92aa980
006874AD8  mov      w19, w1
006874ADC  mov      x20, x0
006874AE0  tbnz     w8, #0, #0x6874af8
006874AE4  adrp     x0, #0x8f24000
006874AE8  ldr      x0, [x0, #0x4c8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnAddRejectFlag() @ 0x92aa980
006874AEC  bl       #0x382bd14 ; 
006874AF0  mov      w8, #1
006874AF4  strb     w8, [x21, #0xab0]
006874AF8  ldr      x2, [x22]
006874AFC  ldrb     w8, [x2, #0x53]
006874B00  tbnz     w8, #5, #0x6874ba4
006874B04  ldr      x21, [x20, #0x18]
006874B08  cbz      x21, #0x6874bc4
006874B0C  ldr      w8, [x21, #0x18]
006874B10  cmp      w8, #1
006874B14  b.lt     #0x6874b4c
006874B18  mov      w22, wzr
006874B1C  cmp      w22, w8
006874B20  b.hs     #0x6874bc0
006874B24  add      x8, x21, w22, sxtw #3
006874B28  ldr      x0, [x8, #0x20]
006874B2C  cbz      x0, #0x6874bc4
006874B30  mov      w1, w19
006874B34  mov      x2, xzr
006874B38  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874B3C  ldr      w8, [x21, #0x18]
006874B40  add      w22, w22, #1
006874B44  cmp      w22, w8
006874B48  b.lt     #0x6874b1c
006874B4C  ldr      x20, [x20, #0x20]
006874B50  cbz      x20, #0x6874bc4
006874B54  ldr      w8, [x20, #0x18]
006874B58  cmp      w8, #1
006874B5C  b.lt     #0x6874b94
006874B60  mov      w21, wzr
006874B64  cmp      w21, w8
006874B68  b.hs     #0x6874bc0
006874B6C  add      x8, x20, w21, sxtw #3
006874B70  ldr      x0, [x8, #0x20]
006874B74  cbz      x0, #0x6874bc4
006874B78  mov      w1, w19
006874B7C  mov      x2, xzr
006874B80  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874B84  ldr      w8, [x20, #0x18]
006874B88  add      w21, w21, #1
006874B8C  cmp      w21, w8
006874B90  b.lt     #0x6874b64
006874B94  ldp      x20, x19, [sp, #0x20]
006874B98  ldp      x22, x21, [sp, #0x10]
006874B9C  ldr      x30, [sp], #0x30
006874BA0  ret      
006874BA4  ldr      x3, [x2, #0x60]
006874BA8  mov      x0, x20
006874BAC  mov      w1, w19
006874BB0  ldp      x20, x19, [sp, #0x20]
006874BB4  ldp      x22, x21, [sp, #0x10]
006874BB8  ldr      x30, [sp], #0x30
006874BBC  br       x3
006874BC0  bl       #0x382bfc0 ; 
006874BC4  bl       #0x382bfb8 ; 

