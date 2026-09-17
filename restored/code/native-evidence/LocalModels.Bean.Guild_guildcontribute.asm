; LocalModels.Bean.Guild_guildcontribute$$readImpl
; RVA 0x6A8FC20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8FC20  stp      x30, x21, [sp, #-0x20]!
006A8FC24  stp      x20, x19, [sp, #0x10]
006A8FC28  adrp     x20, #0x959e000
006A8FC2C  adrp     x21, #0x8f38000
006A8FC30  ldrb     w8, [x20, #0xdf]
006A8FC34  ldr      x21, [x21, #0xd50]
006A8FC38  mov      x19, x0
006A8FC3C  tbnz     w8, #0, #0x6a8fc54
006A8FC40  adrp     x0, #0x8f38000
006A8FC44  ldr      x0, [x0, #0xd50]
006A8FC48  bl       #0x382bd14 ; 
006A8FC4C  mov      w8, #1
006A8FC50  strb     w8, [x20, #0xdf]
006A8FC54  ldr      x1, [x21]
006A8FC58  ldrb     w8, [x1, #0x53]
006A8FC5C  tbnz     w8, #5, #0x6a8fcac
006A8FC60  mov      x0, x19
006A8FC64  mov      x1, xzr
006A8FC68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8FC6C  adrp     x21, #0x959e000
006A8FC70  ldrb     w8, [x21, #0x5a4]
006A8FC74  mov      w20, w0
006A8FC78  cbnz     w8, #0x6a8fc90
006A8FC7C  adrp     x0, #0x8f38000
006A8FC80  ldr      x0, [x0, #0xd28]
006A8FC84  bl       #0x382bd14 ; 
006A8FC88  mov      w8, #1
006A8FC8C  strb     w8, [x21, #0x5a4]
006A8FC90  adrp     x8, #0x8f38000
006A8FC94  ldr      x8, [x8, #0xd28]
006A8FC98  ldr      x2, [x8]
006A8FC9C  ldrb     w8, [x2, #0x53]
006A8FCA0  tbnz     w8, #5, #0x6a8fcc0
006A8FCA4  str      w20, [x19, #0x20]
006A8FCA8  b        #0x6a8fcd0 ; 
006A8FCAC  ldr      x2, [x1, #0x60]
006A8FCB0  mov      x0, x19
006A8FCB4  ldp      x20, x19, [sp, #0x10]
006A8FCB8  ldp      x30, x21, [sp], #0x20
006A8FCBC  br       x2
006A8FCC0  ldr      x8, [x2, #0x60]
006A8FCC4  mov      x0, x19
006A8FCC8  mov      w1, w20
006A8FCCC  blr      x8
006A8FCD0  mov      x0, x19
006A8FCD4  mov      x1, xzr
006A8FCD8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A8FCDC  adrp     x21, #0x959e000
006A8FCE0  ldrb     w8, [x21, #0x5a5]
006A8FCE4  mov      x20, x0
006A8FCE8  cbnz     w8, #0x6a8fd00
006A8FCEC  adrp     x0, #0x8f38000
006A8FCF0  ldr      x0, [x0, #0xd38]
006A8FCF4  bl       #0x382bd14 ; 
006A8FCF8  mov      w8, #1
006A8FCFC  strb     w8, [x21, #0x5a5]
006A8FD00  adrp     x8, #0x8f38000
006A8FD04  ldr      x8, [x8, #0xd38]
006A8FD08  ldr      x2, [x8]
006A8FD0C  ldrb     w8, [x2, #0x53]
006A8FD10  tbnz     w8, #5, #0x6a8fd28
006A8FD14  mov      x0, x19
006A8FD18  str      x20, [x0, #0x28]!
006A8FD1C  mov      x1, x20
006A8FD20  bl       #0x382bcb8 ; 
006A8FD24  b        #0x6a8fd38 ; 
006A8FD28  ldr      x8, [x2, #0x60]
006A8FD2C  mov      x0, x19
006A8FD30  mov      x1, x20
006A8FD34  blr      x8
006A8FD38  mov      x0, x19
006A8FD3C  mov      x1, xzr
006A8FD40  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A8FD44  adrp     x21, #0x959e000
006A8FD48  ldrb     w8, [x21, #0x5a6]
006A8FD4C  mov      x20, x0
006A8FD50  cbnz     w8, #0x6a8fd68
006A8FD54  adrp     x0, #0x8f38000
006A8FD58  ldr      x0, [x0, #0xd48]
006A8FD5C  bl       #0x382bd14 ; 
006A8FD60  mov      w8, #1
006A8FD64  strb     w8, [x21, #0x5a6]
006A8FD68  adrp     x8, #0x8f38000
006A8FD6C  ldr      x8, [x8, #0xd48]
006A8FD70  ldr      x2, [x8]
006A8FD74  ldrb     w8, [x2, #0x53]
006A8FD78  tbnz     w8, #5, #0x6a8fd90
006A8FD7C  str      x20, [x19, #0x30]!
006A8FD80  mov      x0, x19
006A8FD84  mov      x1, x20
006A8FD88  bl       #0x382bcb8 ; 
006A8FD8C  b        #0x6a8fda0 ; 
006A8FD90  ldr      x8, [x2, #0x60]
006A8FD94  mov      x0, x19
006A8FD98  mov      x1, x20
006A8FD9C  blr      x8
006A8FDA0  ldp      x20, x19, [sp, #0x10]
006A8FDA4  mov      w0, #1
006A8FDA8  ldp      x30, x21, [sp], #0x20
006A8FDAC  ret      

