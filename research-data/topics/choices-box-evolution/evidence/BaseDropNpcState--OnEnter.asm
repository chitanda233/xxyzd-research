; HotFix.BattleLogic.BaseDropNpcState$$OnEnter
; RVA 0x659851C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659851C  str      x30, [sp, #-0x30]!
006598520  stp      x22, x21, [sp, #0x10]
006598524  stp      x20, x19, [sp, #0x20]
006598528  adrp     x21, #0x9599000
00659852C  adrp     x22, #0x8f08000
006598530  ldrb     w8, [x21, #0x2ee]
006598534  ldr      x22, [x22, #0xc78] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnEnter() @ 0x923b080
006598538  mov      x20, x1
00659853C  mov      x19, x0
006598540  tbnz     w8, #0, #0x6598564
006598544  adrp     x0, #0x8f08000
006598548  ldr      x0, [x0, #0xc78] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnEnter() @ 0x923b080
00659854C  bl       #0x382bd14 ; 
006598550  adrp     x0, #0x8f08000
006598554  ldr      x0, [x0, #0xc80] ; GLOBAL HotFix.BattleLogic.EnterNpcDropParam_TypeInfo @ 0x91e5a40
006598558  bl       #0x382bd14 ; 
00659855C  mov      w8, #1
006598560  strb     w8, [x21, #0x2ee]
006598564  ldr      x2, [x22]
006598568  ldrb     w8, [x2, #0x53]
00659856C  tbnz     w8, #5, #0x6598588
006598570  ldrb     w8, [x19, #0x20]
006598574  cbz      w8, #0x65985a4
006598578  ldp      x20, x19, [sp, #0x20]
00659857C  ldp      x22, x21, [sp, #0x10]
006598580  ldr      x30, [sp], #0x30
006598584  ret      
006598588  ldr      x3, [x2, #0x60]
00659858C  mov      x0, x19
006598590  mov      x1, x20
006598594  ldp      x20, x19, [sp, #0x20]
006598598  ldp      x22, x21, [sp, #0x10]
00659859C  ldr      x30, [sp], #0x30
0065985A0  br       x3
0065985A4  mov      w8, #1
0065985A8  strb     w8, [x19, #0x20]
0065985AC  cbz      x20, #0x6598610
0065985B0  adrp     x9, #0x8f08000
0065985B4  ldr      x9, [x9, #0xc80] ; GLOBAL HotFix.BattleLogic.EnterNpcDropParam_TypeInfo @ 0x91e5a40
0065985B8  ldr      x8, [x20]
0065985BC  ldr      x1, [x9]
0065985C0  ldrb     w10, [x8, #0x130]
0065985C4  ldrb     w9, [x1, #0x130]
0065985C8  cmp      w10, w9
0065985CC  b.lo     #0x6598608
0065985D0  ldr      x8, [x8, #0xc8]
0065985D4  add      x8, x8, x9, lsl #3
0065985D8  ldur     x8, [x8, #-8]
0065985DC  cmp      x8, x1
0065985E0  b.ne     #0x6598608
0065985E4  ldrb     w8, [x20, #0x14]
0065985E8  strb     wzr, [x19, #0x24]
0065985EC  mov      x0, x19
0065985F0  ldp      x22, x21, [sp, #0x10]
0065985F4  eor      w8, w8, #1
0065985F8  strb     w8, [x19, #0x23]
0065985FC  ldp      x20, x19, [sp, #0x20]
006598600  ldr      x30, [sp], #0x30
006598604  b        #0x6598614 ; HotFix.BattleLogic.BaseDropNpcState$$Init
006598608  mov      x0, x20
00659860C  bl       #0x382c354 ; 
006598610  bl       #0x382bfb8 ; 

