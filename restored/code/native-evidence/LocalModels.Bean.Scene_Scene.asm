; LocalModels.Bean.Scene_Scene$$readImpl
; RVA 0x6AE6F04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE6F04  stp      x30, x21, [sp, #-0x20]!
006AE6F08  stp      x20, x19, [sp, #0x10]
006AE6F0C  adrp     x20, #0x959e000
006AE6F10  adrp     x21, #0x8f3c000
006AE6F14  ldrb     w8, [x20, #0xd60]
006AE6F18  ldr      x21, [x21, #0xe98]
006AE6F1C  mov      x19, x0
006AE6F20  tbnz     w8, #0, #0x6ae6f38
006AE6F24  adrp     x0, #0x8f3c000
006AE6F28  ldr      x0, [x0, #0xe98]
006AE6F2C  bl       #0x382bd14 ; 
006AE6F30  mov      w8, #1
006AE6F34  strb     w8, [x20, #0xd60]
006AE6F38  ldr      x1, [x21]
006AE6F3C  ldrb     w8, [x1, #0x53]
006AE6F40  tbnz     w8, #5, #0x6ae6f90
006AE6F44  mov      x0, x19
006AE6F48  mov      x1, xzr
006AE6F4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE6F50  adrp     x21, #0x959f000
006AE6F54  ldrb     w8, [x21, #0x1de]
006AE6F58  mov      w20, w0
006AE6F5C  cbnz     w8, #0x6ae6f74
006AE6F60  adrp     x0, #0x8f3c000
006AE6F64  ldr      x0, [x0, #0xe80]
006AE6F68  bl       #0x382bd14 ; 
006AE6F6C  mov      w8, #1
006AE6F70  strb     w8, [x21, #0x1de]
006AE6F74  adrp     x8, #0x8f3c000
006AE6F78  ldr      x8, [x8, #0xe80]
006AE6F7C  ldr      x2, [x8]
006AE6F80  ldrb     w8, [x2, #0x53]
006AE6F84  tbnz     w8, #5, #0x6ae6fa4
006AE6F88  str      w20, [x19, #0x20]
006AE6F8C  b        #0x6ae6fb4 ; 
006AE6F90  ldr      x2, [x1, #0x60]
006AE6F94  mov      x0, x19
006AE6F98  ldp      x20, x19, [sp, #0x10]
006AE6F9C  ldp      x30, x21, [sp], #0x20
006AE6FA0  br       x2
006AE6FA4  ldr      x8, [x2, #0x60]
006AE6FA8  mov      x0, x19
006AE6FAC  mov      w1, w20
006AE6FB0  blr      x8
006AE6FB4  mov      x0, x19
006AE6FB8  mov      x1, xzr
006AE6FBC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE6FC0  adrp     x21, #0x959f000
006AE6FC4  ldrb     w8, [x21, #0x1df]
006AE6FC8  mov      x20, x0
006AE6FCC  cbnz     w8, #0x6ae6fe4
006AE6FD0  adrp     x0, #0x8f3c000
006AE6FD4  ldr      x0, [x0, #0xe90]
006AE6FD8  bl       #0x382bd14 ; 
006AE6FDC  mov      w8, #1
006AE6FE0  strb     w8, [x21, #0x1df]
006AE6FE4  adrp     x8, #0x8f3c000
006AE6FE8  ldr      x8, [x8, #0xe90]
006AE6FEC  ldr      x2, [x8]
006AE6FF0  ldrb     w8, [x2, #0x53]
006AE6FF4  tbnz     w8, #5, #0x6ae700c
006AE6FF8  str      x20, [x19, #0x28]!
006AE6FFC  mov      x0, x19
006AE7000  mov      x1, x20
006AE7004  bl       #0x382bcb8 ; 
006AE7008  b        #0x6ae701c ; 
006AE700C  ldr      x8, [x2, #0x60]
006AE7010  mov      x0, x19
006AE7014  mov      x1, x20
006AE7018  blr      x8
006AE701C  ldp      x20, x19, [sp, #0x10]
006AE7020  mov      w0, #1
006AE7024  ldp      x30, x21, [sp], #0x20
006AE7028  ret      

