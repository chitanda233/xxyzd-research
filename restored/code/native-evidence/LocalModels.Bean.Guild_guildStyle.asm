; LocalModels.Bean.Guild_guildStyle$$readImpl
; RVA 0x6A95D6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A95D6C  stp      x30, x21, [sp, #-0x20]!
006A95D70  stp      x20, x19, [sp, #0x10]
006A95D74  adrp     x20, #0x959e000
006A95D78  adrp     x21, #0x8f39000
006A95D7C  ldrb     w8, [x20, #0x182]
006A95D80  ldr      x21, [x21, #0x210]
006A95D84  mov      x19, x0
006A95D88  tbnz     w8, #0, #0x6a95da0
006A95D8C  adrp     x0, #0x8f39000
006A95D90  ldr      x0, [x0, #0x210]
006A95D94  bl       #0x382bd14 ; 
006A95D98  mov      w8, #1
006A95D9C  strb     w8, [x20, #0x182]
006A95DA0  ldr      x1, [x21]
006A95DA4  ldrb     w8, [x1, #0x53]
006A95DA8  tbnz     w8, #5, #0x6a95df8
006A95DAC  mov      x0, x19
006A95DB0  mov      x1, xzr
006A95DB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A95DB8  adrp     x21, #0x959e000
006A95DBC  ldrb     w8, [x21, #0x5e5]
006A95DC0  mov      w20, w0
006A95DC4  cbnz     w8, #0x6a95ddc
006A95DC8  adrp     x0, #0x8f39000
006A95DCC  ldr      x0, [x0, #0x1e8]
006A95DD0  bl       #0x382bd14 ; 
006A95DD4  mov      w8, #1
006A95DD8  strb     w8, [x21, #0x5e5]
006A95DDC  adrp     x8, #0x8f39000
006A95DE0  ldr      x8, [x8, #0x1e8]
006A95DE4  ldr      x2, [x8]
006A95DE8  ldrb     w8, [x2, #0x53]
006A95DEC  tbnz     w8, #5, #0x6a95e0c
006A95DF0  str      w20, [x19, #0x20]
006A95DF4  b        #0x6a95e1c ; 
006A95DF8  ldr      x2, [x1, #0x60]
006A95DFC  mov      x0, x19
006A95E00  ldp      x20, x19, [sp, #0x10]
006A95E04  ldp      x30, x21, [sp], #0x20
006A95E08  br       x2
006A95E0C  ldr      x8, [x2, #0x60]
006A95E10  mov      x0, x19
006A95E14  mov      w1, w20
006A95E18  blr      x8
006A95E1C  mov      x0, x19
006A95E20  mov      x1, xzr
006A95E24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A95E28  adrp     x21, #0x959e000
006A95E2C  ldrb     w8, [x21, #0x5e6]
006A95E30  mov      w20, w0
006A95E34  cbnz     w8, #0x6a95e4c
006A95E38  adrp     x0, #0x8f39000
006A95E3C  ldr      x0, [x0, #0x1f8]
006A95E40  bl       #0x382bd14 ; 
006A95E44  mov      w8, #1
006A95E48  strb     w8, [x21, #0x5e6]
006A95E4C  adrp     x8, #0x8f39000
006A95E50  ldr      x8, [x8, #0x1f8]
006A95E54  ldr      x2, [x8]
006A95E58  ldrb     w8, [x2, #0x53]
006A95E5C  tbnz     w8, #5, #0x6a95e68
006A95E60  str      w20, [x19, #0x24]
006A95E64  b        #0x6a95e78 ; 
006A95E68  ldr      x8, [x2, #0x60]
006A95E6C  mov      x0, x19
006A95E70  mov      w1, w20
006A95E74  blr      x8
006A95E78  mov      x0, x19
006A95E7C  mov      x1, xzr
006A95E80  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A95E84  adrp     x21, #0x959e000
006A95E88  ldrb     w8, [x21, #0x5e7]
006A95E8C  mov      x20, x0
006A95E90  cbnz     w8, #0x6a95ea8
006A95E94  adrp     x0, #0x8f39000
006A95E98  ldr      x0, [x0, #0x208]
006A95E9C  bl       #0x382bd14 ; 
006A95EA0  mov      w8, #1
006A95EA4  strb     w8, [x21, #0x5e7]
006A95EA8  adrp     x8, #0x8f39000
006A95EAC  ldr      x8, [x8, #0x208]
006A95EB0  ldr      x2, [x8]
006A95EB4  ldrb     w8, [x2, #0x53]
006A95EB8  tbnz     w8, #5, #0x6a95ed0
006A95EBC  str      x20, [x19, #0x28]!
006A95EC0  mov      x0, x19
006A95EC4  mov      x1, x20
006A95EC8  bl       #0x382bcb8 ; 
006A95ECC  b        #0x6a95ee0 ; 
006A95ED0  ldr      x8, [x2, #0x60]
006A95ED4  mov      x0, x19
006A95ED8  mov      x1, x20
006A95EDC  blr      x8
006A95EE0  ldp      x20, x19, [sp, #0x10]
006A95EE4  mov      w0, #1
006A95EE8  ldp      x30, x21, [sp], #0x20
006A95EEC  ret      

