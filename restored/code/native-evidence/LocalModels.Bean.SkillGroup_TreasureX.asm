; LocalModels.Bean.SkillGroup_TreasureX$$readImpl
; RVA 0x6AFD250; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFD250  stp      x30, x21, [sp, #-0x20]!
006AFD254  stp      x20, x19, [sp, #0x10]
006AFD258  adrp     x20, #0x959f000
006AFD25C  adrp     x21, #0x8f3d000
006AFD260  ldrb     w8, [x20, #0x33f]
006AFD264  ldr      x21, [x21, #0xf88]
006AFD268  mov      x19, x0
006AFD26C  tbnz     w8, #0, #0x6afd284
006AFD270  adrp     x0, #0x8f3d000
006AFD274  ldr      x0, [x0, #0xf88]
006AFD278  bl       #0x382bd14 ; 
006AFD27C  mov      w8, #1
006AFD280  strb     w8, [x20, #0x33f]
006AFD284  ldr      x1, [x21]
006AFD288  ldrb     w8, [x1, #0x53]
006AFD28C  tbnz     w8, #5, #0x6afd2dc
006AFD290  mov      x0, x19
006AFD294  mov      x1, xzr
006AFD298  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFD29C  adrp     x21, #0x959f000
006AFD2A0  ldrb     w8, [x21, #0x8c3]
006AFD2A4  mov      w20, w0
006AFD2A8  cbnz     w8, #0x6afd2c0
006AFD2AC  adrp     x0, #0x8f3d000
006AFD2B0  ldr      x0, [x0, #0xf60]
006AFD2B4  bl       #0x382bd14 ; 
006AFD2B8  mov      w8, #1
006AFD2BC  strb     w8, [x21, #0x8c3]
006AFD2C0  adrp     x8, #0x8f3d000
006AFD2C4  ldr      x8, [x8, #0xf60]
006AFD2C8  ldr      x2, [x8]
006AFD2CC  ldrb     w8, [x2, #0x53]
006AFD2D0  tbnz     w8, #5, #0x6afd2f0
006AFD2D4  str      w20, [x19, #0x20]
006AFD2D8  b        #0x6afd300 ; 
006AFD2DC  ldr      x2, [x1, #0x60]
006AFD2E0  mov      x0, x19
006AFD2E4  ldp      x20, x19, [sp, #0x10]
006AFD2E8  ldp      x30, x21, [sp], #0x20
006AFD2EC  br       x2
006AFD2F0  ldr      x8, [x2, #0x60]
006AFD2F4  mov      x0, x19
006AFD2F8  mov      w1, w20
006AFD2FC  blr      x8
006AFD300  mov      x0, x19
006AFD304  mov      x1, xzr
006AFD308  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFD30C  adrp     x21, #0x959f000
006AFD310  ldrb     w8, [x21, #0x8c4]
006AFD314  mov      w20, w0
006AFD318  cbnz     w8, #0x6afd330
006AFD31C  adrp     x0, #0x8f3d000
006AFD320  ldr      x0, [x0, #0xf70]
006AFD324  bl       #0x382bd14 ; 
006AFD328  mov      w8, #1
006AFD32C  strb     w8, [x21, #0x8c4]
006AFD330  adrp     x8, #0x8f3d000
006AFD334  ldr      x8, [x8, #0xf70]
006AFD338  ldr      x2, [x8]
006AFD33C  ldrb     w8, [x2, #0x53]
006AFD340  tbnz     w8, #5, #0x6afd34c
006AFD344  str      w20, [x19, #0x24]
006AFD348  b        #0x6afd35c ; 
006AFD34C  ldr      x8, [x2, #0x60]
006AFD350  mov      x0, x19
006AFD354  mov      w1, w20
006AFD358  blr      x8
006AFD35C  mov      x0, x19
006AFD360  mov      x1, xzr
006AFD364  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFD368  adrp     x21, #0x959f000
006AFD36C  ldrb     w8, [x21, #0x8c5]
006AFD370  mov      w20, w0
006AFD374  cbnz     w8, #0x6afd38c
006AFD378  adrp     x0, #0x8f3d000
006AFD37C  ldr      x0, [x0, #0xf80]
006AFD380  bl       #0x382bd14 ; 
006AFD384  mov      w8, #1
006AFD388  strb     w8, [x21, #0x8c5]
006AFD38C  adrp     x8, #0x8f3d000
006AFD390  ldr      x8, [x8, #0xf80]
006AFD394  ldr      x2, [x8]
006AFD398  ldrb     w8, [x2, #0x53]
006AFD39C  tbnz     w8, #5, #0x6afd3a8
006AFD3A0  str      w20, [x19, #0x28]
006AFD3A4  b        #0x6afd3b8 ; 
006AFD3A8  ldr      x8, [x2, #0x60]
006AFD3AC  mov      x0, x19
006AFD3B0  mov      w1, w20
006AFD3B4  blr      x8
006AFD3B8  ldp      x20, x19, [sp, #0x10]
006AFD3BC  mov      w0, #1
006AFD3C0  ldp      x30, x21, [sp], #0x20
006AFD3C4  ret      

