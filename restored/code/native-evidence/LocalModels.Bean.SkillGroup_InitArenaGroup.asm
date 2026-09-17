; LocalModels.Bean.SkillGroup_InitArenaGroup$$readImpl
; RVA 0x6AF7CFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF7CFC  stp      x30, x21, [sp, #-0x20]!
006AF7D00  stp      x20, x19, [sp, #0x10]
006AF7D04  adrp     x20, #0x959f000
006AF7D08  adrp     x21, #0x8f3d000
006AF7D0C  ldrb     w8, [x20, #0x2b8]
006AF7D10  ldr      x21, [x21, #0xba0]
006AF7D14  mov      x19, x0
006AF7D18  tbnz     w8, #0, #0x6af7d30
006AF7D1C  adrp     x0, #0x8f3d000
006AF7D20  ldr      x0, [x0, #0xba0]
006AF7D24  bl       #0x382bd14 ; 
006AF7D28  mov      w8, #1
006AF7D2C  strb     w8, [x20, #0x2b8]
006AF7D30  ldr      x1, [x21]
006AF7D34  ldrb     w8, [x1, #0x53]
006AF7D38  tbnz     w8, #5, #0x6af7d88
006AF7D3C  mov      x0, x19
006AF7D40  mov      x1, xzr
006AF7D44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF7D48  adrp     x21, #0x959f000
006AF7D4C  ldrb     w8, [x21, #0x875]
006AF7D50  mov      w20, w0
006AF7D54  cbnz     w8, #0x6af7d6c
006AF7D58  adrp     x0, #0x8f3d000
006AF7D5C  ldr      x0, [x0, #0xb78]
006AF7D60  bl       #0x382bd14 ; 
006AF7D64  mov      w8, #1
006AF7D68  strb     w8, [x21, #0x875]
006AF7D6C  adrp     x8, #0x8f3d000
006AF7D70  ldr      x8, [x8, #0xb78]
006AF7D74  ldr      x2, [x8]
006AF7D78  ldrb     w8, [x2, #0x53]
006AF7D7C  tbnz     w8, #5, #0x6af7d9c
006AF7D80  str      w20, [x19, #0x20]
006AF7D84  b        #0x6af7dac ; 
006AF7D88  ldr      x2, [x1, #0x60]
006AF7D8C  mov      x0, x19
006AF7D90  ldp      x20, x19, [sp, #0x10]
006AF7D94  ldp      x30, x21, [sp], #0x20
006AF7D98  br       x2
006AF7D9C  ldr      x8, [x2, #0x60]
006AF7DA0  mov      x0, x19
006AF7DA4  mov      w1, w20
006AF7DA8  blr      x8
006AF7DAC  mov      x0, x19
006AF7DB0  mov      x1, xzr
006AF7DB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF7DB8  adrp     x21, #0x959f000
006AF7DBC  ldrb     w8, [x21, #0x876]
006AF7DC0  mov      w20, w0
006AF7DC4  cbnz     w8, #0x6af7ddc
006AF7DC8  adrp     x0, #0x8f3d000
006AF7DCC  ldr      x0, [x0, #0xb88]
006AF7DD0  bl       #0x382bd14 ; 
006AF7DD4  mov      w8, #1
006AF7DD8  strb     w8, [x21, #0x876]
006AF7DDC  adrp     x8, #0x8f3d000
006AF7DE0  ldr      x8, [x8, #0xb88]
006AF7DE4  ldr      x2, [x8]
006AF7DE8  ldrb     w8, [x2, #0x53]
006AF7DEC  tbnz     w8, #5, #0x6af7df8
006AF7DF0  str      w20, [x19, #0x24]
006AF7DF4  b        #0x6af7e08 ; 
006AF7DF8  ldr      x8, [x2, #0x60]
006AF7DFC  mov      x0, x19
006AF7E00  mov      w1, w20
006AF7E04  blr      x8
006AF7E08  mov      x0, x19
006AF7E0C  mov      x1, xzr
006AF7E10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF7E14  adrp     x21, #0x959f000
006AF7E18  ldrb     w8, [x21, #0x877]
006AF7E1C  mov      w20, w0
006AF7E20  cbnz     w8, #0x6af7e38
006AF7E24  adrp     x0, #0x8f3d000
006AF7E28  ldr      x0, [x0, #0xb98]
006AF7E2C  bl       #0x382bd14 ; 
006AF7E30  mov      w8, #1
006AF7E34  strb     w8, [x21, #0x877]
006AF7E38  adrp     x8, #0x8f3d000
006AF7E3C  ldr      x8, [x8, #0xb98]
006AF7E40  ldr      x2, [x8]
006AF7E44  ldrb     w8, [x2, #0x53]
006AF7E48  tbnz     w8, #5, #0x6af7e54
006AF7E4C  str      w20, [x19, #0x28]
006AF7E50  b        #0x6af7e64 ; 
006AF7E54  ldr      x8, [x2, #0x60]
006AF7E58  mov      x0, x19
006AF7E5C  mov      w1, w20
006AF7E60  blr      x8
006AF7E64  ldp      x20, x19, [sp, #0x10]
006AF7E68  mov      w0, #1
006AF7E6C  ldp      x30, x21, [sp], #0x20
006AF7E70  ret      

