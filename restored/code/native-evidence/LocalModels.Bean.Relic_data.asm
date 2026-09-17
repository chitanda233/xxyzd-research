; LocalModels.Bean.Relic_data$$readImpl
; RVA 0x6AD8178; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD8178  stp      x30, x21, [sp, #-0x20]!
006AD817C  stp      x20, x19, [sp, #0x10]
006AD8180  adrp     x20, #0x959e000
006AD8184  adrp     x21, #0x8f3c000
006AD8188  ldrb     w8, [x20, #0xbdd]
006AD818C  ldr      x21, [x21, #0x3d0]
006AD8190  mov      x19, x0
006AD8194  tbnz     w8, #0, #0x6ad81ac
006AD8198  adrp     x0, #0x8f3c000
006AD819C  ldr      x0, [x0, #0x3d0]
006AD81A0  bl       #0x382bd14 ; 
006AD81A4  mov      w8, #1
006AD81A8  strb     w8, [x20, #0xbdd]
006AD81AC  ldr      x1, [x21]
006AD81B0  ldrb     w8, [x1, #0x53]
006AD81B4  tbnz     w8, #5, #0x6ad8204
006AD81B8  mov      x0, x19
006AD81BC  mov      x1, xzr
006AD81C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD81C4  adrp     x21, #0x959f000
006AD81C8  ldrb     w8, [x21, #0x135]
006AD81CC  mov      w20, w0
006AD81D0  cbnz     w8, #0x6ad81e8
006AD81D4  adrp     x0, #0x8f3c000
006AD81D8  ldr      x0, [x0, #0x3a8]
006AD81DC  bl       #0x382bd14 ; 
006AD81E0  mov      w8, #1
006AD81E4  strb     w8, [x21, #0x135]
006AD81E8  adrp     x8, #0x8f3c000
006AD81EC  ldr      x8, [x8, #0x3a8]
006AD81F0  ldr      x2, [x8]
006AD81F4  ldrb     w8, [x2, #0x53]
006AD81F8  tbnz     w8, #5, #0x6ad8218
006AD81FC  str      w20, [x19, #0x20]
006AD8200  b        #0x6ad8228 ; 
006AD8204  ldr      x2, [x1, #0x60]
006AD8208  mov      x0, x19
006AD820C  ldp      x20, x19, [sp, #0x10]
006AD8210  ldp      x30, x21, [sp], #0x20
006AD8214  br       x2
006AD8218  ldr      x8, [x2, #0x60]
006AD821C  mov      x0, x19
006AD8220  mov      w1, w20
006AD8224  blr      x8
006AD8228  mov      x0, x19
006AD822C  mov      x1, xzr
006AD8230  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD8234  adrp     x21, #0x959f000
006AD8238  ldrb     w8, [x21, #0x136]
006AD823C  mov      w20, w0
006AD8240  cbnz     w8, #0x6ad8258
006AD8244  adrp     x0, #0x8f3c000
006AD8248  ldr      x0, [x0, #0x3b8]
006AD824C  bl       #0x382bd14 ; 
006AD8250  mov      w8, #1
006AD8254  strb     w8, [x21, #0x136]
006AD8258  adrp     x8, #0x8f3c000
006AD825C  ldr      x8, [x8, #0x3b8]
006AD8260  ldr      x2, [x8]
006AD8264  ldrb     w8, [x2, #0x53]
006AD8268  tbnz     w8, #5, #0x6ad8274
006AD826C  str      w20, [x19, #0x24]
006AD8270  b        #0x6ad8284 ; 
006AD8274  ldr      x8, [x2, #0x60]
006AD8278  mov      x0, x19
006AD827C  mov      w1, w20
006AD8280  blr      x8
006AD8284  mov      x0, x19
006AD8288  mov      x1, xzr
006AD828C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD8290  adrp     x21, #0x959f000
006AD8294  ldrb     w8, [x21, #0x137]
006AD8298  mov      w20, w0
006AD829C  cbnz     w8, #0x6ad82b4
006AD82A0  adrp     x0, #0x8f3c000
006AD82A4  ldr      x0, [x0, #0x3c8]
006AD82A8  bl       #0x382bd14 ; 
006AD82AC  mov      w8, #1
006AD82B0  strb     w8, [x21, #0x137]
006AD82B4  adrp     x8, #0x8f3c000
006AD82B8  ldr      x8, [x8, #0x3c8]
006AD82BC  ldr      x2, [x8]
006AD82C0  ldrb     w8, [x2, #0x53]
006AD82C4  tbnz     w8, #5, #0x6ad82d0
006AD82C8  str      w20, [x19, #0x28]
006AD82CC  b        #0x6ad82e0 ; 
006AD82D0  ldr      x8, [x2, #0x60]
006AD82D4  mov      x0, x19
006AD82D8  mov      w1, w20
006AD82DC  blr      x8
006AD82E0  ldp      x20, x19, [sp, #0x10]
006AD82E4  mov      w0, #1
006AD82E8  ldp      x30, x21, [sp], #0x20
006AD82EC  ret      

