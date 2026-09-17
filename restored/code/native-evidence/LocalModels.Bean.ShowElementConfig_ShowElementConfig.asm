; LocalModels.Bean.ShowElementConfig_ShowElementConfig$$readImpl
; RVA 0x6AF2EF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF2EF0  stp      x30, x21, [sp, #-0x20]!
006AF2EF4  stp      x20, x19, [sp, #0x10]
006AF2EF8  adrp     x20, #0x959e000
006AF2EFC  adrp     x21, #0x8f3d000
006AF2F00  ldrb     w8, [x20, #0xea2]
006AF2F04  ldr      x21, [x21, #0x808]
006AF2F08  mov      x19, x0
006AF2F0C  tbnz     w8, #0, #0x6af2f24
006AF2F10  adrp     x0, #0x8f3d000
006AF2F14  ldr      x0, [x0, #0x808]
006AF2F18  bl       #0x382bd14 ; 
006AF2F1C  mov      w8, #1
006AF2F20  strb     w8, [x20, #0xea2]
006AF2F24  ldr      x1, [x21]
006AF2F28  ldrb     w8, [x1, #0x53]
006AF2F2C  tbnz     w8, #5, #0x6af2f7c
006AF2F30  mov      x0, x19
006AF2F34  mov      x1, xzr
006AF2F38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF2F3C  adrp     x21, #0x959f000
006AF2F40  ldrb     w8, [x21, #0x260]
006AF2F44  mov      w20, w0
006AF2F48  cbnz     w8, #0x6af2f60
006AF2F4C  adrp     x0, #0x8f3d000
006AF2F50  ldr      x0, [x0, #0x7e0]
006AF2F54  bl       #0x382bd14 ; 
006AF2F58  mov      w8, #1
006AF2F5C  strb     w8, [x21, #0x260]
006AF2F60  adrp     x8, #0x8f3d000
006AF2F64  ldr      x8, [x8, #0x7e0]
006AF2F68  ldr      x2, [x8]
006AF2F6C  ldrb     w8, [x2, #0x53]
006AF2F70  tbnz     w8, #5, #0x6af2f90
006AF2F74  str      w20, [x19, #0x20]
006AF2F78  b        #0x6af2fa0 ; 
006AF2F7C  ldr      x2, [x1, #0x60]
006AF2F80  mov      x0, x19
006AF2F84  ldp      x20, x19, [sp, #0x10]
006AF2F88  ldp      x30, x21, [sp], #0x20
006AF2F8C  br       x2
006AF2F90  ldr      x8, [x2, #0x60]
006AF2F94  mov      x0, x19
006AF2F98  mov      w1, w20
006AF2F9C  blr      x8
006AF2FA0  mov      x0, x19
006AF2FA4  mov      x1, xzr
006AF2FA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF2FAC  adrp     x21, #0x959f000
006AF2FB0  ldrb     w8, [x21, #0x261]
006AF2FB4  mov      w20, w0
006AF2FB8  cbnz     w8, #0x6af2fd0
006AF2FBC  adrp     x0, #0x8f3d000
006AF2FC0  ldr      x0, [x0, #0x7f0]
006AF2FC4  bl       #0x382bd14 ; 
006AF2FC8  mov      w8, #1
006AF2FCC  strb     w8, [x21, #0x261]
006AF2FD0  adrp     x8, #0x8f3d000
006AF2FD4  ldr      x8, [x8, #0x7f0]
006AF2FD8  ldr      x2, [x8]
006AF2FDC  ldrb     w8, [x2, #0x53]
006AF2FE0  tbnz     w8, #5, #0x6af2fec
006AF2FE4  str      w20, [x19, #0x24]
006AF2FE8  b        #0x6af2ffc ; 
006AF2FEC  ldr      x8, [x2, #0x60]
006AF2FF0  mov      x0, x19
006AF2FF4  mov      w1, w20
006AF2FF8  blr      x8
006AF2FFC  mov      x0, x19
006AF3000  mov      x1, xzr
006AF3004  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF3008  adrp     x21, #0x959f000
006AF300C  ldrb     w8, [x21, #0x262]
006AF3010  mov      x20, x0
006AF3014  cbnz     w8, #0x6af302c
006AF3018  adrp     x0, #0x8f3d000
006AF301C  ldr      x0, [x0, #0x800]
006AF3020  bl       #0x382bd14 ; 
006AF3024  mov      w8, #1
006AF3028  strb     w8, [x21, #0x262]
006AF302C  adrp     x8, #0x8f3d000
006AF3030  ldr      x8, [x8, #0x800]
006AF3034  ldr      x2, [x8]
006AF3038  ldrb     w8, [x2, #0x53]
006AF303C  tbnz     w8, #5, #0x6af3054
006AF3040  str      x20, [x19, #0x28]!
006AF3044  mov      x0, x19
006AF3048  mov      x1, x20
006AF304C  bl       #0x382bcb8 ; 
006AF3050  b        #0x6af3064 ; 
006AF3054  ldr      x8, [x2, #0x60]
006AF3058  mov      x0, x19
006AF305C  mov      x1, x20
006AF3060  blr      x8
006AF3064  ldp      x20, x19, [sp, #0x10]
006AF3068  mov      w0, #1
006AF306C  ldp      x30, x21, [sp], #0x20
006AF3070  ret      

