; LocalModels.Bean.EventDiving_DiveInitialGrid$$readImpl
; RVA 0x6A6E324; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6E324  stp      x30, x21, [sp, #-0x20]!
006A6E328  stp      x20, x19, [sp, #0x10]
006A6E32C  adrp     x20, #0x959d000
006A6E330  adrp     x21, #0x8f37000
006A6E334  ldrb     w8, [x20, #0xd5c]
006A6E338  ldr      x21, [x21, #0x3d8]
006A6E33C  mov      x19, x0
006A6E340  tbnz     w8, #0, #0x6a6e358
006A6E344  adrp     x0, #0x8f37000
006A6E348  ldr      x0, [x0, #0x3d8]
006A6E34C  bl       #0x382bd14 ; 
006A6E350  mov      w8, #1
006A6E354  strb     w8, [x20, #0xd5c]
006A6E358  ldr      x1, [x21]
006A6E35C  ldrb     w8, [x1, #0x53]
006A6E360  tbnz     w8, #5, #0x6a6e3b0
006A6E364  mov      x0, x19
006A6E368  mov      x1, xzr
006A6E36C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6E370  adrp     x21, #0x959e000
006A6E374  ldrb     w8, [x21, #0x43c]
006A6E378  mov      w20, w0
006A6E37C  cbnz     w8, #0x6a6e394
006A6E380  adrp     x0, #0x8f37000
006A6E384  ldr      x0, [x0, #0x3c0]
006A6E388  bl       #0x382bd14 ; 
006A6E38C  mov      w8, #1
006A6E390  strb     w8, [x21, #0x43c]
006A6E394  adrp     x8, #0x8f37000
006A6E398  ldr      x8, [x8, #0x3c0]
006A6E39C  ldr      x2, [x8]
006A6E3A0  ldrb     w8, [x2, #0x53]
006A6E3A4  tbnz     w8, #5, #0x6a6e3c4
006A6E3A8  str      w20, [x19, #0x20]
006A6E3AC  b        #0x6a6e3d4 ; 
006A6E3B0  ldr      x2, [x1, #0x60]
006A6E3B4  mov      x0, x19
006A6E3B8  ldp      x20, x19, [sp, #0x10]
006A6E3BC  ldp      x30, x21, [sp], #0x20
006A6E3C0  br       x2
006A6E3C4  ldr      x8, [x2, #0x60]
006A6E3C8  mov      x0, x19
006A6E3CC  mov      w1, w20
006A6E3D0  blr      x8
006A6E3D4  mov      x0, x19
006A6E3D8  mov      x1, xzr
006A6E3DC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6E3E0  adrp     x21, #0x959e000
006A6E3E4  ldrb     w8, [x21, #0x43d]
006A6E3E8  mov      x20, x0
006A6E3EC  cbnz     w8, #0x6a6e404
006A6E3F0  adrp     x0, #0x8f37000
006A6E3F4  ldr      x0, [x0, #0x3d0]
006A6E3F8  bl       #0x382bd14 ; 
006A6E3FC  mov      w8, #1
006A6E400  strb     w8, [x21, #0x43d]
006A6E404  adrp     x8, #0x8f37000
006A6E408  ldr      x8, [x8, #0x3d0]
006A6E40C  ldr      x2, [x8]
006A6E410  ldrb     w8, [x2, #0x53]
006A6E414  tbnz     w8, #5, #0x6a6e42c
006A6E418  str      x20, [x19, #0x28]!
006A6E41C  mov      x0, x19
006A6E420  mov      x1, x20
006A6E424  bl       #0x382bcb8 ; 
006A6E428  b        #0x6a6e43c ; 
006A6E42C  ldr      x8, [x2, #0x60]
006A6E430  mov      x0, x19
006A6E434  mov      x1, x20
006A6E438  blr      x8
006A6E43C  ldp      x20, x19, [sp, #0x10]
006A6E440  mov      w0, #1
006A6E444  ldp      x30, x21, [sp], #0x20
006A6E448  ret      

