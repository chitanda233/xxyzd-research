; LocalModels.Bean.Card_drawCardCost$$readImpl
; RVA 0x6895ED0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006895ED0  stp      x30, x21, [sp, #-0x20]!
006895ED4  stp      x20, x19, [sp, #0x10]
006895ED8  adrp     x20, #0x959b000
006895EDC  adrp     x21, #0x8f25000
006895EE0  ldrb     w8, [x20, #0xdb5]
006895EE4  ldr      x21, [x21, #0xb50]
006895EE8  mov      x19, x0
006895EEC  tbnz     w8, #0, #0x6895f04
006895EF0  adrp     x0, #0x8f25000
006895EF4  ldr      x0, [x0, #0xb50]
006895EF8  bl       #0x382bd14 ; 
006895EFC  mov      w8, #1
006895F00  strb     w8, [x20, #0xdb5]
006895F04  ldr      x1, [x21]
006895F08  ldrb     w8, [x1, #0x53]
006895F0C  tbnz     w8, #5, #0x6895f5c
006895F10  mov      x0, x19
006895F14  mov      x1, xzr
006895F18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006895F1C  adrp     x21, #0x959c000
006895F20  ldrb     w8, [x21, #0x49f]
006895F24  mov      w20, w0
006895F28  cbnz     w8, #0x6895f40
006895F2C  adrp     x0, #0x8f25000
006895F30  ldr      x0, [x0, #0xb08]
006895F34  bl       #0x382bd14 ; 
006895F38  mov      w8, #1
006895F3C  strb     w8, [x21, #0x49f]
006895F40  adrp     x8, #0x8f25000
006895F44  ldr      x8, [x8, #0xb08]
006895F48  ldr      x2, [x8]
006895F4C  ldrb     w8, [x2, #0x53]
006895F50  tbnz     w8, #5, #0x6895f70
006895F54  str      w20, [x19, #0x20]
006895F58  b        #0x6895f80 ; 
006895F5C  ldr      x2, [x1, #0x60]
006895F60  mov      x0, x19
006895F64  ldp      x20, x19, [sp, #0x10]
006895F68  ldp      x30, x21, [sp], #0x20
006895F6C  br       x2
006895F70  ldr      x8, [x2, #0x60]
006895F74  mov      x0, x19
006895F78  mov      w1, w20
006895F7C  blr      x8
006895F80  mov      x0, x19
006895F84  mov      x1, xzr
006895F88  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006895F8C  adrp     x21, #0x959c000
006895F90  ldrb     w8, [x21, #0x4a0]
006895F94  mov      x20, x0
006895F98  cbnz     w8, #0x6895fb0
006895F9C  adrp     x0, #0x8f25000
006895FA0  ldr      x0, [x0, #0xb18]
006895FA4  bl       #0x382bd14 ; 
006895FA8  mov      w8, #1
006895FAC  strb     w8, [x21, #0x4a0]
006895FB0  adrp     x8, #0x8f25000
006895FB4  ldr      x8, [x8, #0xb18]
006895FB8  ldr      x2, [x8]
006895FBC  ldrb     w8, [x2, #0x53]
006895FC0  tbnz     w8, #5, #0x6895fd8
006895FC4  mov      x0, x19
006895FC8  str      x20, [x0, #0x28]!
006895FCC  mov      x1, x20
006895FD0  bl       #0x382bcb8 ; 
006895FD4  b        #0x6895fe8 ; 
006895FD8  ldr      x8, [x2, #0x60]
006895FDC  mov      x0, x19
006895FE0  mov      x1, x20
006895FE4  blr      x8
006895FE8  mov      x0, x19
006895FEC  mov      x1, xzr
006895FF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006895FF4  adrp     x21, #0x959c000
006895FF8  ldrb     w8, [x21, #0x4a1]
006895FFC  mov      w20, w0
006896000  cbnz     w8, #0x6896018
006896004  adrp     x0, #0x8f25000
006896008  ldr      x0, [x0, #0xb28]
00689600C  bl       #0x382bd14 ; 
006896010  mov      w8, #1
006896014  strb     w8, [x21, #0x4a1]
006896018  adrp     x8, #0x8f25000
00689601C  ldr      x8, [x8, #0xb28]
006896020  ldr      x2, [x8]
006896024  ldrb     w8, [x2, #0x53]
006896028  tbnz     w8, #5, #0x6896034
00689602C  str      w20, [x19, #0x30]
006896030  b        #0x6896044 ; 
006896034  ldr      x8, [x2, #0x60]
006896038  mov      x0, x19
00689603C  mov      w1, w20
006896040  blr      x8
006896044  mov      x0, x19
006896048  mov      x1, xzr
00689604C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006896050  adrp     x21, #0x959c000
006896054  ldrb     w8, [x21, #0x4a2]
006896058  mov      w20, w0
00689605C  cbnz     w8, #0x6896074
006896060  adrp     x0, #0x8f25000
006896064  ldr      x0, [x0, #0xb38]
006896068  bl       #0x382bd14 ; 
00689606C  mov      w8, #1
006896070  strb     w8, [x21, #0x4a2]
006896074  adrp     x8, #0x8f25000
006896078  ldr      x8, [x8, #0xb38]
00689607C  ldr      x2, [x8]
006896080  ldrb     w8, [x2, #0x53]
006896084  tbnz     w8, #5, #0x6896090
006896088  str      w20, [x19, #0x34]
00689608C  b        #0x68960a0 ; 
006896090  ldr      x8, [x2, #0x60]
006896094  mov      x0, x19
006896098  mov      w1, w20
00689609C  blr      x8
0068960A0  mov      x0, x19
0068960A4  mov      x1, xzr
0068960A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068960AC  adrp     x21, #0x959c000
0068960B0  ldrb     w8, [x21, #0x4a3]
0068960B4  mov      w20, w0
0068960B8  cbnz     w8, #0x68960d0
0068960BC  adrp     x0, #0x8f25000
0068960C0  ldr      x0, [x0, #0xb48]
0068960C4  bl       #0x382bd14 ; 
0068960C8  mov      w8, #1
0068960CC  strb     w8, [x21, #0x4a3]
0068960D0  adrp     x8, #0x8f25000
0068960D4  ldr      x8, [x8, #0xb48]
0068960D8  ldr      x2, [x8]
0068960DC  ldrb     w8, [x2, #0x53]
0068960E0  tbnz     w8, #5, #0x68960ec
0068960E4  str      w20, [x19, #0x38]
0068960E8  b        #0x68960fc ; 
0068960EC  ldr      x8, [x2, #0x60]
0068960F0  mov      x0, x19
0068960F4  mov      w1, w20
0068960F8  blr      x8
0068960FC  ldp      x20, x19, [sp, #0x10]
006896100  mov      w0, #1
006896104  ldp      x30, x21, [sp], #0x20
006896108  ret      

