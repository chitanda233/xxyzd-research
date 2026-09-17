; LocalModels.Bean.Vip_data$$readImpl
; RVA 0x6B1D200; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B1D200  stp      x30, x21, [sp, #-0x20]!
006B1D204  stp      x20, x19, [sp, #0x10]
006B1D208  adrp     x20, #0x959f000
006B1D20C  adrp     x21, #0x8f3f000
006B1D210  ldrb     w8, [x20, #0x689]
006B1D214  ldr      x21, [x21, #0x5c8]
006B1D218  mov      x19, x0
006B1D21C  tbnz     w8, #0, #0x6b1d234
006B1D220  adrp     x0, #0x8f3f000
006B1D224  ldr      x0, [x0, #0x5c8]
006B1D228  bl       #0x382bd14 ; 
006B1D22C  mov      w8, #1
006B1D230  strb     w8, [x20, #0x689]
006B1D234  ldr      x1, [x21]
006B1D238  ldrb     w8, [x1, #0x53]
006B1D23C  tbnz     w8, #5, #0x6b1d28c
006B1D240  mov      x0, x19
006B1D244  mov      x1, xzr
006B1D248  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1D24C  adrp     x21, #0x959f000
006B1D250  ldrb     w8, [x21, #0xa31]
006B1D254  mov      w20, w0
006B1D258  cbnz     w8, #0x6b1d270
006B1D25C  adrp     x0, #0x8f3f000
006B1D260  ldr      x0, [x0, #0x590]
006B1D264  bl       #0x382bd14 ; 
006B1D268  mov      w8, #1
006B1D26C  strb     w8, [x21, #0xa31]
006B1D270  adrp     x8, #0x8f3f000
006B1D274  ldr      x8, [x8, #0x590]
006B1D278  ldr      x2, [x8]
006B1D27C  ldrb     w8, [x2, #0x53]
006B1D280  tbnz     w8, #5, #0x6b1d2a0
006B1D284  str      w20, [x19, #0x20]
006B1D288  b        #0x6b1d2b0 ; 
006B1D28C  ldr      x2, [x1, #0x60]
006B1D290  mov      x0, x19
006B1D294  ldp      x20, x19, [sp, #0x10]
006B1D298  ldp      x30, x21, [sp], #0x20
006B1D29C  br       x2
006B1D2A0  ldr      x8, [x2, #0x60]
006B1D2A4  mov      x0, x19
006B1D2A8  mov      w1, w20
006B1D2AC  blr      x8
006B1D2B0  mov      x0, x19
006B1D2B4  mov      x1, xzr
006B1D2B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1D2BC  adrp     x21, #0x959f000
006B1D2C0  ldrb     w8, [x21, #0xa32]
006B1D2C4  mov      w20, w0
006B1D2C8  cbnz     w8, #0x6b1d2e0
006B1D2CC  adrp     x0, #0x8f3f000
006B1D2D0  ldr      x0, [x0, #0x5a0]
006B1D2D4  bl       #0x382bd14 ; 
006B1D2D8  mov      w8, #1
006B1D2DC  strb     w8, [x21, #0xa32]
006B1D2E0  adrp     x8, #0x8f3f000
006B1D2E4  ldr      x8, [x8, #0x5a0]
006B1D2E8  ldr      x2, [x8]
006B1D2EC  ldrb     w8, [x2, #0x53]
006B1D2F0  tbnz     w8, #5, #0x6b1d2fc
006B1D2F4  str      w20, [x19, #0x24]
006B1D2F8  b        #0x6b1d30c ; 
006B1D2FC  ldr      x8, [x2, #0x60]
006B1D300  mov      x0, x19
006B1D304  mov      w1, w20
006B1D308  blr      x8
006B1D30C  mov      x0, x19
006B1D310  mov      x1, xzr
006B1D314  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1D318  adrp     x21, #0x959f000
006B1D31C  ldrb     w8, [x21, #0xa33]
006B1D320  mov      w20, w0
006B1D324  cbnz     w8, #0x6b1d33c
006B1D328  adrp     x0, #0x8f3f000
006B1D32C  ldr      x0, [x0, #0x5b0]
006B1D330  bl       #0x382bd14 ; 
006B1D334  mov      w8, #1
006B1D338  strb     w8, [x21, #0xa33]
006B1D33C  adrp     x8, #0x8f3f000
006B1D340  ldr      x8, [x8, #0x5b0]
006B1D344  ldr      x2, [x8]
006B1D348  ldrb     w8, [x2, #0x53]
006B1D34C  tbnz     w8, #5, #0x6b1d358
006B1D350  str      w20, [x19, #0x28]
006B1D354  b        #0x6b1d368 ; 
006B1D358  ldr      x8, [x2, #0x60]
006B1D35C  mov      x0, x19
006B1D360  mov      w1, w20
006B1D364  blr      x8
006B1D368  mov      x0, x19
006B1D36C  mov      x1, xzr
006B1D370  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1D374  adrp     x21, #0x959f000
006B1D378  ldrb     w8, [x21, #0xa34]
006B1D37C  mov      x20, x0
006B1D380  cbnz     w8, #0x6b1d398
006B1D384  adrp     x0, #0x8f3f000
006B1D388  ldr      x0, [x0, #0x5c0]
006B1D38C  bl       #0x382bd14 ; 
006B1D390  mov      w8, #1
006B1D394  strb     w8, [x21, #0xa34]
006B1D398  adrp     x8, #0x8f3f000
006B1D39C  ldr      x8, [x8, #0x5c0]
006B1D3A0  ldr      x2, [x8]
006B1D3A4  ldrb     w8, [x2, #0x53]
006B1D3A8  tbnz     w8, #5, #0x6b1d3c0
006B1D3AC  str      x20, [x19, #0x30]!
006B1D3B0  mov      x0, x19
006B1D3B4  mov      x1, x20
006B1D3B8  bl       #0x382bcb8 ; 
006B1D3BC  b        #0x6b1d3d0 ; 
006B1D3C0  ldr      x8, [x2, #0x60]
006B1D3C4  mov      x0, x19
006B1D3C8  mov      x1, x20
006B1D3CC  blr      x8
006B1D3D0  ldp      x20, x19, [sp, #0x10]
006B1D3D4  mov      w0, #1
006B1D3D8  ldp      x30, x21, [sp], #0x20
006B1D3DC  ret      

