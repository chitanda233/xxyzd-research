; HotFix.BattleLogic.MonsterMoveInTwoPoint$$SetData
; RVA 0x66152A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066152A8  sub      sp, sp, #0x50
0066152AC  stp      x30, x23, [sp, #0x20]
0066152B0  stp      x22, x21, [sp, #0x30]
0066152B4  stp      x20, x19, [sp, #0x40]
0066152B8  mrs      x21, tpidr_el0
0066152BC  ldr      x8, [x21, #0x28]
0066152C0  adrp     x22, #0x9599000
0066152C4  adrp     x23, #0x8f05000
0066152C8  mov      x20, x1
0066152CC  str      x8, [sp, #0x18]
0066152D0  ldrb     w8, [x22, #0x879]
0066152D4  ldr      x23, [x23, #0x830] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.SetData()
0066152D8  mov      x19, x0
0066152DC  tbnz     w8, #0, #0x66152f4
0066152E0  adrp     x0, #0x8f05000
0066152E4  ldr      x0, [x0, #0x830] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.SetData()
0066152E8  bl       #0x382bd14 ; 
0066152EC  mov      w8, #1
0066152F0  strb     w8, [x22, #0x879]
0066152F4  ldr      x2, [x23]
0066152F8  ldrb     w8, [x2, #0x53]
0066152FC  tbnz     w8, #5, #0x6615314
006615300  ldr      x8, [x20, #0x10]
006615304  ldr      q0, [x20]
006615308  str      x8, [x19, #0x98]
00661530C  stur     q0, [x19, #0x88]
006615310  b        #0x6615334 ; 
006615314  ldr      x8, [x20, #0x10]
006615318  ldr      q0, [x20]
00661531C  ldr      x9, [x2, #0x60]
006615320  mov      x1, sp
006615324  mov      x0, x19
006615328  str      x8, [sp, #0x10]
00661532C  str      q0, [sp]
006615330  blr      x9
006615334  ldr      x8, [x21, #0x28]
006615338  ldr      x9, [sp, #0x18]
00661533C  cmp      x8, x9
006615340  b.ne     #0x6615358
006615344  ldp      x20, x19, [sp, #0x40]
006615348  ldp      x22, x21, [sp, #0x30]
00661534C  ldp      x30, x23, [sp, #0x20]
006615350  add      sp, sp, #0x50
006615354  ret      
006615358  bl       #0x89edb60 ; 

