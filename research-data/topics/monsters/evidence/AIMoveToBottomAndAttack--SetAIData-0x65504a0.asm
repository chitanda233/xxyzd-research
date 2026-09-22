; HotFix.BattleLogic.AIMoveToBottomAndAttack$$SetAIData
; RVA 0x65504A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065504A0  str      x30, [sp, #-0x30]!
0065504A4  stp      x22, x21, [sp, #0x10]
0065504A8  stp      x20, x19, [sp, #0x20]
0065504AC  adrp     x21, #0x9598000
0065504B0  adrp     x22, #0x8f05000
0065504B4  ldrb     w8, [x21, #0xe70]
0065504B8  ldr      x22, [x22, #0xae0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.SetAIData()
0065504BC  mov      x19, x1
0065504C0  mov      x20, x0
0065504C4  tbnz     w8, #0, #0x65504e8
0065504C8  adrp     x0, #0x8f05000
0065504CC  ldr      x0, [x0, #0xae0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttack.SetAIData()
0065504D0  bl       #0x382bd14 ; 
0065504D4  adrp     x0, #0x8f05000
0065504D8  ldr      x0, [x0, #0xac8] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttack.Data_TypeInfo
0065504DC  bl       #0x382bd14 ; 
0065504E0  mov      w8, #1
0065504E4  strb     w8, [x21, #0xe70]
0065504E8  ldr      x2, [x22]
0065504EC  ldrb     w8, [x2, #0x53]
0065504F0  tbnz     w8, #5, #0x6550558
0065504F4  cbz      x19, #0x6550574
0065504F8  adrp     x8, #0x8f05000
0065504FC  ldr      x8, [x8, #0xac8] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttack.Data_TypeInfo
006550500  ldr      x9, [x19]
006550504  ldr      x1, [x8]
006550508  ldrb     w10, [x9, #0x130]
00655050C  ldrb     w8, [x1, #0x130]
006550510  cmp      w10, w8
006550514  b.lo     #0x6550590
006550518  ldr      x10, [x9, #0xc8]
00655051C  sub      x9, x8, #1
006550520  ldr      x10, [x10, x9, lsl #3]
006550524  cmp      x10, x1
006550528  b.ne     #0x6550590
00655052C  str      x19, [x20, #0x118]
006550530  ldr      x10, [x19]
006550534  ldrb     w11, [x10, #0x130]
006550538  cmp      w11, w8
00655053C  b.lo     #0x6550590
006550540  ldr      x8, [x10, #0xc8]
006550544  ldr      x8, [x8, x9, lsl #3]
006550548  cmp      x8, x1
00655054C  b.ne     #0x6550590
006550550  add      x0, x20, #0x118
006550554  b        #0x655057c ; 
006550558  ldr      x3, [x2, #0x60]
00655055C  mov      x0, x20
006550560  mov      x1, x19
006550564  ldp      x20, x19, [sp, #0x20]
006550568  ldp      x22, x21, [sp, #0x10]
00655056C  ldr      x30, [sp], #0x30
006550570  br       x3
006550574  add      x0, x20, #0x118
006550578  str      xzr, [x20, #0x118]
00655057C  mov      x1, x19
006550580  ldp      x20, x19, [sp, #0x20]
006550584  ldp      x22, x21, [sp, #0x10]
006550588  ldr      x30, [sp], #0x30
00655058C  b        #0x382bcb8 ; 
006550590  mov      x0, x19
006550594  bl       #0x382c354 ; 

