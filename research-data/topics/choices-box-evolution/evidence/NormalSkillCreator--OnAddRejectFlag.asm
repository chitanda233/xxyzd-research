; HotFix.BattleLogic.NormalSkillCreator$$OnAddRejectFlag
; RVA 0x6874984; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874984  str      x30, [sp, #-0x30]!
006874988  stp      x22, x21, [sp, #0x10]
00687498C  stp      x20, x19, [sp, #0x20]
006874990  adrp     x21, #0x959b000
006874994  adrp     x22, #0x8f24000
006874998  ldrb     w8, [x21, #0xaa1]
00687499C  ldr      x22, [x22, #0x4c0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnAddRejectFlag() @ 0x9295e98
0068749A0  mov      w19, w1
0068749A4  mov      x20, x0
0068749A8  tbnz     w8, #0, #0x68749c0
0068749AC  adrp     x0, #0x8f24000
0068749B0  ldr      x0, [x0, #0x4c0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnAddRejectFlag() @ 0x9295e98
0068749B4  bl       #0x382bd14 ; 
0068749B8  mov      w8, #1
0068749BC  strb     w8, [x21, #0xaa1]
0068749C0  ldr      x2, [x22]
0068749C4  ldrb     w8, [x2, #0x53]
0068749C8  tbnz     w8, #5, #0x6874a98
0068749CC  mov      x0, x20
0068749D0  mov      w1, w19
0068749D4  bl       #0x6874abc ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectFlag
0068749D8  ldr      x8, [x20, #0x80]
0068749DC  cbz      x8, #0x6874a40
0068749E0  ldr      x8, [x20]
0068749E4  mov      x0, x20
0068749E8  ldr      x9, [x8, #0x2e8]
0068749EC  ldr      x1, [x8, #0x2f0]
0068749F0  blr      x9
0068749F4  tbz      w0, #0, #0x6874a40
0068749F8  ldr      x21, [x20, #0x80]
0068749FC  cbz      x21, #0x6874ab4
006874A00  ldr      w8, [x21, #0x18]
006874A04  cmp      w8, #1
006874A08  b.lt     #0x6874a40
006874A0C  mov      w22, wzr
006874A10  cmp      w22, w8
006874A14  b.hs     #0x6874ab8
006874A18  add      x8, x21, w22, sxtw #3
006874A1C  ldr      x0, [x8, #0x20]
006874A20  cbz      x0, #0x6874ab4
006874A24  mov      w1, w19
006874A28  mov      x2, xzr
006874A2C  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874A30  ldr      w8, [x21, #0x18]
006874A34  add      w22, w22, #1
006874A38  cmp      w22, w8
006874A3C  b.lt     #0x6874a10
006874A40  ldr      x20, [x20, #0x88]
006874A44  cbz      x20, #0x6874ab4
006874A48  ldr      w8, [x20, #0x18]
006874A4C  cmp      w8, #1
006874A50  b.lt     #0x6874a88
006874A54  mov      w21, wzr
006874A58  cmp      w21, w8
006874A5C  b.hs     #0x6874ab8
006874A60  add      x8, x20, w21, sxtw #3
006874A64  ldr      x0, [x8, #0x20]
006874A68  cbz      x0, #0x6874ab4
006874A6C  mov      w1, w19
006874A70  mov      x2, xzr
006874A74  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874A78  ldr      w8, [x20, #0x18]
006874A7C  add      w21, w21, #1
006874A80  cmp      w21, w8
006874A84  b.lt     #0x6874a58
006874A88  ldp      x20, x19, [sp, #0x20]
006874A8C  ldp      x22, x21, [sp, #0x10]
006874A90  ldr      x30, [sp], #0x30
006874A94  ret      
006874A98  ldr      x3, [x2, #0x60]
006874A9C  mov      x0, x20
006874AA0  mov      w1, w19
006874AA4  ldp      x20, x19, [sp, #0x20]
006874AA8  ldp      x22, x21, [sp, #0x10]
006874AAC  ldr      x30, [sp], #0x30
006874AB0  br       x3
006874AB4  bl       #0x382bfb8 ; 
006874AB8  bl       #0x382bfc0 ; 

