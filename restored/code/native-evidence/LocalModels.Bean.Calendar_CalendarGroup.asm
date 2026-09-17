; LocalModels.Bean.Calendar_CalendarGroup$$readImpl
; RVA 0x6890F14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006890F14  stp      x30, x21, [sp, #-0x20]!
006890F18  stp      x20, x19, [sp, #0x10]
006890F1C  adrp     x20, #0x959b000
006890F20  adrp     x21, #0x8f25000
006890F24  ldrb     w8, [x20, #0xd30]
006890F28  ldr      x21, [x21, #0x760]
006890F2C  mov      x19, x0
006890F30  tbnz     w8, #0, #0x6890f48
006890F34  adrp     x0, #0x8f25000
006890F38  ldr      x0, [x0, #0x760]
006890F3C  bl       #0x382bd14 ; 
006890F40  mov      w8, #1
006890F44  strb     w8, [x20, #0xd30]
006890F48  ldr      x1, [x21]
006890F4C  ldrb     w8, [x1, #0x53]
006890F50  tbnz     w8, #5, #0x6890fa0
006890F54  mov      x0, x19
006890F58  mov      x1, xzr
006890F5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006890F60  adrp     x21, #0x959c000
006890F64  ldrb     w8, [x21, #0x468]
006890F68  mov      w20, w0
006890F6C  cbnz     w8, #0x6890f84
006890F70  adrp     x0, #0x8f25000
006890F74  ldr      x0, [x0, #0x728]
006890F78  bl       #0x382bd14 ; 
006890F7C  mov      w8, #1
006890F80  strb     w8, [x21, #0x468]
006890F84  adrp     x8, #0x8f25000
006890F88  ldr      x8, [x8, #0x728]
006890F8C  ldr      x2, [x8]
006890F90  ldrb     w8, [x2, #0x53]
006890F94  tbnz     w8, #5, #0x6890fb4
006890F98  str      w20, [x19, #0x20]
006890F9C  b        #0x6890fc4 ; 
006890FA0  ldr      x2, [x1, #0x60]
006890FA4  mov      x0, x19
006890FA8  ldp      x20, x19, [sp, #0x10]
006890FAC  ldp      x30, x21, [sp], #0x20
006890FB0  br       x2
006890FB4  ldr      x8, [x2, #0x60]
006890FB8  mov      x0, x19
006890FBC  mov      w1, w20
006890FC0  blr      x8
006890FC4  mov      x0, x19
006890FC8  mov      x1, xzr
006890FCC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006890FD0  adrp     x21, #0x959c000
006890FD4  ldrb     w8, [x21, #0x469]
006890FD8  mov      x20, x0
006890FDC  cbnz     w8, #0x6890ff4
006890FE0  adrp     x0, #0x8f25000
006890FE4  ldr      x0, [x0, #0x738]
006890FE8  bl       #0x382bd14 ; 
006890FEC  mov      w8, #1
006890FF0  strb     w8, [x21, #0x469]
006890FF4  adrp     x8, #0x8f25000
006890FF8  ldr      x8, [x8, #0x738]
006890FFC  ldr      x2, [x8]
006891000  ldrb     w8, [x2, #0x53]
006891004  tbnz     w8, #5, #0x689101c
006891008  mov      x0, x19
00689100C  str      x20, [x0, #0x28]!
006891010  mov      x1, x20
006891014  bl       #0x382bcb8 ; 
006891018  b        #0x689102c ; 
00689101C  ldr      x8, [x2, #0x60]
006891020  mov      x0, x19
006891024  mov      x1, x20
006891028  blr      x8
00689102C  mov      x0, x19
006891030  mov      x1, xzr
006891034  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006891038  adrp     x21, #0x959c000
00689103C  ldrb     w8, [x21, #0x46a]
006891040  mov      w20, w0
006891044  cbnz     w8, #0x689105c
006891048  adrp     x0, #0x8f25000
00689104C  ldr      x0, [x0, #0x748]
006891050  bl       #0x382bd14 ; 
006891054  mov      w8, #1
006891058  strb     w8, [x21, #0x46a]
00689105C  adrp     x8, #0x8f25000
006891060  ldr      x8, [x8, #0x748]
006891064  ldr      x2, [x8]
006891068  ldrb     w8, [x2, #0x53]
00689106C  tbnz     w8, #5, #0x6891078
006891070  str      w20, [x19, #0x30]
006891074  b        #0x6891088 ; 
006891078  ldr      x8, [x2, #0x60]
00689107C  mov      x0, x19
006891080  mov      w1, w20
006891084  blr      x8
006891088  mov      x0, x19
00689108C  mov      x1, xzr
006891090  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006891094  adrp     x21, #0x959c000
006891098  ldrb     w8, [x21, #0x46b]
00689109C  mov      w20, w0
0068910A0  cbnz     w8, #0x68910b8
0068910A4  adrp     x0, #0x8f25000
0068910A8  ldr      x0, [x0, #0x758]
0068910AC  bl       #0x382bd14 ; 
0068910B0  mov      w8, #1
0068910B4  strb     w8, [x21, #0x46b]
0068910B8  adrp     x8, #0x8f25000
0068910BC  ldr      x8, [x8, #0x758]
0068910C0  ldr      x2, [x8]
0068910C4  ldrb     w8, [x2, #0x53]
0068910C8  tbnz     w8, #5, #0x68910d4
0068910CC  str      w20, [x19, #0x34]
0068910D0  b        #0x68910e4 ; 
0068910D4  ldr      x8, [x2, #0x60]
0068910D8  mov      x0, x19
0068910DC  mov      w1, w20
0068910E0  blr      x8
0068910E4  ldp      x20, x19, [sp, #0x10]
0068910E8  mov      w0, #1
0068910EC  ldp      x30, x21, [sp], #0x20
0068910F0  ret      

