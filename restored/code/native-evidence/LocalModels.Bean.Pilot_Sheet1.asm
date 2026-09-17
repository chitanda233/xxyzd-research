; LocalModels.Bean.Pilot_Sheet1$$readImpl
; RVA 0x6AD2D34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD2D34  stp      x30, x21, [sp, #-0x20]!
006AD2D38  stp      x20, x19, [sp, #0x10]
006AD2D3C  adrp     x20, #0x959e000
006AD2D40  adrp     x21, #0x8f3b000
006AD2D44  ldrb     w8, [x20, #0xb50]
006AD2D48  ldr      x21, [x21, #0xfc0]
006AD2D4C  mov      x19, x0
006AD2D50  tbnz     w8, #0, #0x6ad2d68
006AD2D54  adrp     x0, #0x8f3b000
006AD2D58  ldr      x0, [x0, #0xfc0]
006AD2D5C  bl       #0x382bd14 ; 
006AD2D60  mov      w8, #1
006AD2D64  strb     w8, [x20, #0xb50]
006AD2D68  ldr      x1, [x21]
006AD2D6C  ldrb     w8, [x1, #0x53]
006AD2D70  tbnz     w8, #5, #0x6ad2dc0
006AD2D74  mov      x0, x19
006AD2D78  mov      x1, xzr
006AD2D7C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD2D80  adrp     x21, #0x959f000
006AD2D84  ldrb     w8, [x21, #0xfe]
006AD2D88  mov      w20, w0
006AD2D8C  cbnz     w8, #0x6ad2da4
006AD2D90  adrp     x0, #0x8f3b000
006AD2D94  ldr      x0, [x0, #0xf88]
006AD2D98  bl       #0x382bd14 ; 
006AD2D9C  mov      w8, #1
006AD2DA0  strb     w8, [x21, #0xfe]
006AD2DA4  adrp     x8, #0x8f3b000
006AD2DA8  ldr      x8, [x8, #0xf88]
006AD2DAC  ldr      x2, [x8]
006AD2DB0  ldrb     w8, [x2, #0x53]
006AD2DB4  tbnz     w8, #5, #0x6ad2dd4
006AD2DB8  str      w20, [x19, #0x20]
006AD2DBC  b        #0x6ad2de4 ; 
006AD2DC0  ldr      x2, [x1, #0x60]
006AD2DC4  mov      x0, x19
006AD2DC8  ldp      x20, x19, [sp, #0x10]
006AD2DCC  ldp      x30, x21, [sp], #0x20
006AD2DD0  br       x2
006AD2DD4  ldr      x8, [x2, #0x60]
006AD2DD8  mov      x0, x19
006AD2DDC  mov      w1, w20
006AD2DE0  blr      x8
006AD2DE4  mov      x0, x19
006AD2DE8  mov      x1, xzr
006AD2DEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD2DF0  adrp     x21, #0x959f000
006AD2DF4  ldrb     w8, [x21, #0xff]
006AD2DF8  mov      w20, w0
006AD2DFC  cbnz     w8, #0x6ad2e14
006AD2E00  adrp     x0, #0x8f3b000
006AD2E04  ldr      x0, [x0, #0xf98]
006AD2E08  bl       #0x382bd14 ; 
006AD2E0C  mov      w8, #1
006AD2E10  strb     w8, [x21, #0xff]
006AD2E14  adrp     x8, #0x8f3b000
006AD2E18  ldr      x8, [x8, #0xf98]
006AD2E1C  ldr      x2, [x8]
006AD2E20  ldrb     w8, [x2, #0x53]
006AD2E24  tbnz     w8, #5, #0x6ad2e30
006AD2E28  str      w20, [x19, #0x24]
006AD2E2C  b        #0x6ad2e40 ; 
006AD2E30  ldr      x8, [x2, #0x60]
006AD2E34  mov      x0, x19
006AD2E38  mov      w1, w20
006AD2E3C  blr      x8
006AD2E40  mov      x0, x19
006AD2E44  mov      x1, xzr
006AD2E48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD2E4C  adrp     x21, #0x959f000
006AD2E50  ldrb     w8, [x21, #0x100]
006AD2E54  mov      w20, w0
006AD2E58  cbnz     w8, #0x6ad2e70
006AD2E5C  adrp     x0, #0x8f3b000
006AD2E60  ldr      x0, [x0, #0xfa8]
006AD2E64  bl       #0x382bd14 ; 
006AD2E68  mov      w8, #1
006AD2E6C  strb     w8, [x21, #0x100]
006AD2E70  adrp     x8, #0x8f3b000
006AD2E74  ldr      x8, [x8, #0xfa8]
006AD2E78  ldr      x2, [x8]
006AD2E7C  ldrb     w8, [x2, #0x53]
006AD2E80  tbnz     w8, #5, #0x6ad2e8c
006AD2E84  str      w20, [x19, #0x28]
006AD2E88  b        #0x6ad2e9c ; 
006AD2E8C  ldr      x8, [x2, #0x60]
006AD2E90  mov      x0, x19
006AD2E94  mov      w1, w20
006AD2E98  blr      x8
006AD2E9C  mov      x0, x19
006AD2EA0  mov      x1, xzr
006AD2EA4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD2EA8  adrp     x21, #0x959f000
006AD2EAC  ldrb     w8, [x21, #0x101]
006AD2EB0  mov      x20, x0
006AD2EB4  cbnz     w8, #0x6ad2ecc
006AD2EB8  adrp     x0, #0x8f3b000
006AD2EBC  ldr      x0, [x0, #0xfb8]
006AD2EC0  bl       #0x382bd14 ; 
006AD2EC4  mov      w8, #1
006AD2EC8  strb     w8, [x21, #0x101]
006AD2ECC  adrp     x8, #0x8f3b000
006AD2ED0  ldr      x8, [x8, #0xfb8]
006AD2ED4  ldr      x2, [x8]
006AD2ED8  ldrb     w8, [x2, #0x53]
006AD2EDC  tbnz     w8, #5, #0x6ad2ef4
006AD2EE0  str      x20, [x19, #0x30]!
006AD2EE4  mov      x0, x19
006AD2EE8  mov      x1, x20
006AD2EEC  bl       #0x382bcb8 ; 
006AD2EF0  b        #0x6ad2f04 ; 
006AD2EF4  ldr      x8, [x2, #0x60]
006AD2EF8  mov      x0, x19
006AD2EFC  mov      x1, x20
006AD2F00  blr      x8
006AD2F04  ldp      x20, x19, [sp, #0x10]
006AD2F08  mov      w0, #1
006AD2F0C  ldp      x30, x21, [sp], #0x20
006AD2F10  ret      

