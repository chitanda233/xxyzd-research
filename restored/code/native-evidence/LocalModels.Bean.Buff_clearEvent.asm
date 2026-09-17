; LocalModels.Bean.Buff_clearEvent$$readImpl
; RVA 0x6887E3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006887E3C  stp      x30, x21, [sp, #-0x20]!
006887E40  stp      x20, x19, [sp, #0x10]
006887E44  adrp     x20, #0x959b000
006887E48  adrp     x21, #0x8f25000
006887E4C  ldrb     w8, [x20, #0xc43]
006887E50  ldr      x21, [x21, #0xf8]
006887E54  mov      x19, x0
006887E58  tbnz     w8, #0, #0x6887e70
006887E5C  adrp     x0, #0x8f25000
006887E60  ldr      x0, [x0, #0xf8]
006887E64  bl       #0x382bd14 ; 
006887E68  mov      w8, #1
006887E6C  strb     w8, [x20, #0xc43]
006887E70  ldr      x1, [x21]
006887E74  ldrb     w8, [x1, #0x53]
006887E78  tbnz     w8, #5, #0x6887ec8
006887E7C  mov      x0, x19
006887E80  mov      x1, xzr
006887E84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006887E88  adrp     x21, #0x959c000
006887E8C  ldrb     w8, [x21, #0x400]
006887E90  mov      w20, w0
006887E94  cbnz     w8, #0x6887eac
006887E98  adrp     x0, #0x8f25000
006887E9C  ldr      x0, [x0, #0xd8]
006887EA0  bl       #0x382bd14 ; 
006887EA4  mov      w8, #1
006887EA8  strb     w8, [x21, #0x400]
006887EAC  adrp     x8, #0x8f25000
006887EB0  ldr      x8, [x8, #0xd8]
006887EB4  ldr      x2, [x8]
006887EB8  ldrb     w8, [x2, #0x53]
006887EBC  tbnz     w8, #5, #0x6887edc
006887EC0  str      w20, [x19, #0x20]
006887EC4  b        #0x6887eec ; 
006887EC8  ldr      x2, [x1, #0x60]
006887ECC  mov      x0, x19
006887ED0  ldp      x20, x19, [sp, #0x10]
006887ED4  ldp      x30, x21, [sp], #0x20
006887ED8  br       x2
006887EDC  ldr      x8, [x2, #0x60]
006887EE0  mov      x0, x19
006887EE4  mov      w1, w20
006887EE8  blr      x8
006887EEC  mov      x0, x19
006887EF0  mov      x1, xzr
006887EF4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006887EF8  adrp     x21, #0x959c000
006887EFC  ldrb     w8, [x21, #0x401]
006887F00  mov      x20, x0
006887F04  cbnz     w8, #0x6887f1c
006887F08  adrp     x0, #0x8f25000
006887F0C  ldr      x0, [x0, #0xe8]
006887F10  bl       #0x382bd14 ; 
006887F14  mov      w8, #1
006887F18  strb     w8, [x21, #0x401]
006887F1C  adrp     x8, #0x8f25000
006887F20  ldr      x8, [x8, #0xe8]
006887F24  ldr      x2, [x8]
006887F28  ldrb     w8, [x2, #0x53]
006887F2C  tbnz     w8, #5, #0x6887f44
006887F30  mov      x0, x19
006887F34  str      x20, [x0, #0x28]!
006887F38  mov      x1, x20
006887F3C  bl       #0x382bcb8 ; 
006887F40  b        #0x6887f54 ; 
006887F44  ldr      x8, [x2, #0x60]
006887F48  mov      x0, x19
006887F4C  mov      x1, x20
006887F50  blr      x8
006887F54  mov      x0, x19
006887F58  mov      x1, xzr
006887F5C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006887F60  adrp     x21, #0x959c000
006887F64  ldrb     w8, [x21, #0x402]
006887F68  mov      x20, x0
006887F6C  cbnz     w8, #0x6887f84
006887F70  adrp     x0, #0x8f25000
006887F74  ldr      x0, [x0, #0xf0]
006887F78  bl       #0x382bd14 ; 
006887F7C  mov      w8, #1
006887F80  strb     w8, [x21, #0x402]
006887F84  adrp     x8, #0x8f25000
006887F88  ldr      x8, [x8, #0xf0]
006887F8C  ldr      x2, [x8]
006887F90  ldrb     w8, [x2, #0x53]
006887F94  tbnz     w8, #5, #0x6887fac
006887F98  str      x20, [x19, #0x30]!
006887F9C  mov      x0, x19
006887FA0  mov      x1, x20
006887FA4  bl       #0x382bcb8 ; 
006887FA8  b        #0x6887fbc ; 
006887FAC  ldr      x8, [x2, #0x60]
006887FB0  mov      x0, x19
006887FB4  mov      x1, x20
006887FB8  blr      x8
006887FBC  ldp      x20, x19, [sp, #0x10]
006887FC0  mov      w0, #1
006887FC4  ldp      x30, x21, [sp], #0x20
006887FC8  ret      

