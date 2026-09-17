; LocalModels.Bean.Producer_DiamondProducer$$readImpl
; RVA 0x6AD3CF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD3CF8  stp      x30, x21, [sp, #-0x20]!
006AD3CFC  stp      x20, x19, [sp, #0x10]
006AD3D00  adrp     x20, #0x959e000
006AD3D04  adrp     x21, #0x8f3c000
006AD3D08  ldrb     w8, [x20, #0xb6a]
006AD3D0C  ldr      x21, [x21, #0x80]
006AD3D10  mov      x19, x0
006AD3D14  tbnz     w8, #0, #0x6ad3d2c
006AD3D18  adrp     x0, #0x8f3c000
006AD3D1C  ldr      x0, [x0, #0x80]
006AD3D20  bl       #0x382bd14 ; 
006AD3D24  mov      w8, #1
006AD3D28  strb     w8, [x20, #0xb6a]
006AD3D2C  ldr      x1, [x21]
006AD3D30  ldrb     w8, [x1, #0x53]
006AD3D34  tbnz     w8, #5, #0x6ad3d84
006AD3D38  mov      x0, x19
006AD3D3C  mov      x1, xzr
006AD3D40  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD3D44  adrp     x21, #0x959f000
006AD3D48  ldrb     w8, [x21, #0x109]
006AD3D4C  mov      w20, w0
006AD3D50  cbnz     w8, #0x6ad3d68
006AD3D54  adrp     x0, #0x8f3c000
006AD3D58  ldr      x0, [x0, #0x58]
006AD3D5C  bl       #0x382bd14 ; 
006AD3D60  mov      w8, #1
006AD3D64  strb     w8, [x21, #0x109]
006AD3D68  adrp     x8, #0x8f3c000
006AD3D6C  ldr      x8, [x8, #0x58]
006AD3D70  ldr      x2, [x8]
006AD3D74  ldrb     w8, [x2, #0x53]
006AD3D78  tbnz     w8, #5, #0x6ad3d98
006AD3D7C  str      w20, [x19, #0x20]
006AD3D80  b        #0x6ad3da8 ; 
006AD3D84  ldr      x2, [x1, #0x60]
006AD3D88  mov      x0, x19
006AD3D8C  ldp      x20, x19, [sp, #0x10]
006AD3D90  ldp      x30, x21, [sp], #0x20
006AD3D94  br       x2
006AD3D98  ldr      x8, [x2, #0x60]
006AD3D9C  mov      x0, x19
006AD3DA0  mov      w1, w20
006AD3DA4  blr      x8
006AD3DA8  mov      x0, x19
006AD3DAC  mov      x1, xzr
006AD3DB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD3DB4  adrp     x21, #0x959f000
006AD3DB8  ldrb     w8, [x21, #0x10a]
006AD3DBC  mov      w20, w0
006AD3DC0  cbnz     w8, #0x6ad3dd8
006AD3DC4  adrp     x0, #0x8f3c000
006AD3DC8  ldr      x0, [x0, #0x68]
006AD3DCC  bl       #0x382bd14 ; 
006AD3DD0  mov      w8, #1
006AD3DD4  strb     w8, [x21, #0x10a]
006AD3DD8  adrp     x8, #0x8f3c000
006AD3DDC  ldr      x8, [x8, #0x68]
006AD3DE0  ldr      x2, [x8]
006AD3DE4  ldrb     w8, [x2, #0x53]
006AD3DE8  tbnz     w8, #5, #0x6ad3df4
006AD3DEC  str      w20, [x19, #0x24]
006AD3DF0  b        #0x6ad3e04 ; 
006AD3DF4  ldr      x8, [x2, #0x60]
006AD3DF8  mov      x0, x19
006AD3DFC  mov      w1, w20
006AD3E00  blr      x8
006AD3E04  mov      x0, x19
006AD3E08  mov      x1, xzr
006AD3E0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD3E10  adrp     x21, #0x959f000
006AD3E14  ldrb     w8, [x21, #0x10b]
006AD3E18  mov      w20, w0
006AD3E1C  cbnz     w8, #0x6ad3e34
006AD3E20  adrp     x0, #0x8f3c000
006AD3E24  ldr      x0, [x0, #0x78]
006AD3E28  bl       #0x382bd14 ; 
006AD3E2C  mov      w8, #1
006AD3E30  strb     w8, [x21, #0x10b]
006AD3E34  adrp     x8, #0x8f3c000
006AD3E38  ldr      x8, [x8, #0x78]
006AD3E3C  ldr      x2, [x8]
006AD3E40  ldrb     w8, [x2, #0x53]
006AD3E44  tbnz     w8, #5, #0x6ad3e50
006AD3E48  str      w20, [x19, #0x28]
006AD3E4C  b        #0x6ad3e60 ; 
006AD3E50  ldr      x8, [x2, #0x60]
006AD3E54  mov      x0, x19
006AD3E58  mov      w1, w20
006AD3E5C  blr      x8
006AD3E60  ldp      x20, x19, [sp, #0x10]
006AD3E64  mov      w0, #1
006AD3E68  ldp      x30, x21, [sp], #0x20
006AD3E6C  ret      

