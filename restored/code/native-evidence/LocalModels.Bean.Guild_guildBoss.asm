; LocalModels.Bean.Guild_guildBoss$$readImpl
; RVA 0x6A8D2B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8D2B8  stp      x30, x21, [sp, #-0x20]!
006A8D2BC  stp      x20, x19, [sp, #0x10]
006A8D2C0  adrp     x20, #0x959e000
006A8D2C4  adrp     x21, #0x8f38000
006A8D2C8  ldrb     w8, [x20, #0x9a]
006A8D2CC  ldr      x21, [x21, #0xb58]
006A8D2D0  mov      x19, x0
006A8D2D4  tbnz     w8, #0, #0x6a8d2ec
006A8D2D8  adrp     x0, #0x8f38000
006A8D2DC  ldr      x0, [x0, #0xb58]
006A8D2E0  bl       #0x382bd14 ; 
006A8D2E4  mov      w8, #1
006A8D2E8  strb     w8, [x20, #0x9a]
006A8D2EC  ldr      x1, [x21]
006A8D2F0  ldrb     w8, [x1, #0x53]
006A8D2F4  tbnz     w8, #5, #0x6a8d344
006A8D2F8  mov      x0, x19
006A8D2FC  mov      x1, xzr
006A8D300  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8D304  adrp     x21, #0x959e000
006A8D308  ldrb     w8, [x21, #0x589]
006A8D30C  mov      w20, w0
006A8D310  cbnz     w8, #0x6a8d328
006A8D314  adrp     x0, #0x8f38000
006A8D318  ldr      x0, [x0, #0xb30]
006A8D31C  bl       #0x382bd14 ; 
006A8D320  mov      w8, #1
006A8D324  strb     w8, [x21, #0x589]
006A8D328  adrp     x8, #0x8f38000
006A8D32C  ldr      x8, [x8, #0xb30]
006A8D330  ldr      x2, [x8]
006A8D334  ldrb     w8, [x2, #0x53]
006A8D338  tbnz     w8, #5, #0x6a8d358
006A8D33C  str      w20, [x19, #0x20]
006A8D340  b        #0x6a8d368 ; 
006A8D344  ldr      x2, [x1, #0x60]
006A8D348  mov      x0, x19
006A8D34C  ldp      x20, x19, [sp, #0x10]
006A8D350  ldp      x30, x21, [sp], #0x20
006A8D354  br       x2
006A8D358  ldr      x8, [x2, #0x60]
006A8D35C  mov      x0, x19
006A8D360  mov      w1, w20
006A8D364  blr      x8
006A8D368  mov      x0, x19
006A8D36C  mov      x1, xzr
006A8D370  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8D374  adrp     x21, #0x959e000
006A8D378  ldrb     w8, [x21, #0x58a]
006A8D37C  mov      w20, w0
006A8D380  cbnz     w8, #0x6a8d398
006A8D384  adrp     x0, #0x8f38000
006A8D388  ldr      x0, [x0, #0xb40]
006A8D38C  bl       #0x382bd14 ; 
006A8D390  mov      w8, #1
006A8D394  strb     w8, [x21, #0x58a]
006A8D398  adrp     x8, #0x8f38000
006A8D39C  ldr      x8, [x8, #0xb40]
006A8D3A0  ldr      x2, [x8]
006A8D3A4  ldrb     w8, [x2, #0x53]
006A8D3A8  tbnz     w8, #5, #0x6a8d3b4
006A8D3AC  str      w20, [x19, #0x24]
006A8D3B0  b        #0x6a8d3c4 ; 
006A8D3B4  ldr      x8, [x2, #0x60]
006A8D3B8  mov      x0, x19
006A8D3BC  mov      w1, w20
006A8D3C0  blr      x8
006A8D3C4  mov      x0, x19
006A8D3C8  mov      x1, xzr
006A8D3CC  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A8D3D0  adrp     x21, #0x959e000
006A8D3D4  ldrb     w8, [x21, #0x58b]
006A8D3D8  mov      x20, x0
006A8D3DC  cbnz     w8, #0x6a8d3f4
006A8D3E0  adrp     x0, #0x8f38000
006A8D3E4  ldr      x0, [x0, #0xb50]
006A8D3E8  bl       #0x382bd14 ; 
006A8D3EC  mov      w8, #1
006A8D3F0  strb     w8, [x21, #0x58b]
006A8D3F4  adrp     x8, #0x8f38000
006A8D3F8  ldr      x8, [x8, #0xb50]
006A8D3FC  ldr      x2, [x8]
006A8D400  ldrb     w8, [x2, #0x53]
006A8D404  tbnz     w8, #5, #0x6a8d410
006A8D408  str      x20, [x19, #0x28]
006A8D40C  b        #0x6a8d420 ; 
006A8D410  ldr      x8, [x2, #0x60]
006A8D414  mov      x0, x19
006A8D418  mov      x1, x20
006A8D41C  blr      x8
006A8D420  ldp      x20, x19, [sp, #0x10]
006A8D424  mov      w0, #1
006A8D428  ldp      x30, x21, [sp], #0x20
006A8D42C  ret      

