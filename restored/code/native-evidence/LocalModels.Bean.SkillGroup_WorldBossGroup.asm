; LocalModels.Bean.SkillGroup_WorldBossGroup$$readImpl
; RVA 0x6AFF31C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFF31C  stp      x30, x21, [sp, #-0x20]!
006AFF320  stp      x20, x19, [sp, #0x10]
006AFF324  adrp     x20, #0x959f000
006AFF328  adrp     x21, #0x8f3e000
006AFF32C  ldrb     w8, [x20, #0x372]
006AFF330  ldr      x21, [x21, #0xf0]
006AFF334  mov      x19, x0
006AFF338  tbnz     w8, #0, #0x6aff350
006AFF33C  adrp     x0, #0x8f3e000
006AFF340  ldr      x0, [x0, #0xf0]
006AFF344  bl       #0x382bd14 ; 
006AFF348  mov      w8, #1
006AFF34C  strb     w8, [x20, #0x372]
006AFF350  ldr      x1, [x21]
006AFF354  ldrb     w8, [x1, #0x53]
006AFF358  tbnz     w8, #5, #0x6aff3a8
006AFF35C  mov      x0, x19
006AFF360  mov      x1, xzr
006AFF364  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFF368  adrp     x21, #0x959f000
006AFF36C  ldrb     w8, [x21, #0x8e3]
006AFF370  mov      w20, w0
006AFF374  cbnz     w8, #0x6aff38c
006AFF378  adrp     x0, #0x8f3e000
006AFF37C  ldr      x0, [x0, #0xc8]
006AFF380  bl       #0x382bd14 ; 
006AFF384  mov      w8, #1
006AFF388  strb     w8, [x21, #0x8e3]
006AFF38C  adrp     x8, #0x8f3e000
006AFF390  ldr      x8, [x8, #0xc8]
006AFF394  ldr      x2, [x8]
006AFF398  ldrb     w8, [x2, #0x53]
006AFF39C  tbnz     w8, #5, #0x6aff3bc
006AFF3A0  str      w20, [x19, #0x20]
006AFF3A4  b        #0x6aff3cc ; 
006AFF3A8  ldr      x2, [x1, #0x60]
006AFF3AC  mov      x0, x19
006AFF3B0  ldp      x20, x19, [sp, #0x10]
006AFF3B4  ldp      x30, x21, [sp], #0x20
006AFF3B8  br       x2
006AFF3BC  ldr      x8, [x2, #0x60]
006AFF3C0  mov      x0, x19
006AFF3C4  mov      w1, w20
006AFF3C8  blr      x8
006AFF3CC  mov      x0, x19
006AFF3D0  mov      x1, xzr
006AFF3D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFF3D8  adrp     x21, #0x959f000
006AFF3DC  ldrb     w8, [x21, #0x8e4]
006AFF3E0  mov      w20, w0
006AFF3E4  cbnz     w8, #0x6aff3fc
006AFF3E8  adrp     x0, #0x8f3e000
006AFF3EC  ldr      x0, [x0, #0xd8]
006AFF3F0  bl       #0x382bd14 ; 
006AFF3F4  mov      w8, #1
006AFF3F8  strb     w8, [x21, #0x8e4]
006AFF3FC  adrp     x8, #0x8f3e000
006AFF400  ldr      x8, [x8, #0xd8]
006AFF404  ldr      x2, [x8]
006AFF408  ldrb     w8, [x2, #0x53]
006AFF40C  tbnz     w8, #5, #0x6aff418
006AFF410  str      w20, [x19, #0x24]
006AFF414  b        #0x6aff428 ; 
006AFF418  ldr      x8, [x2, #0x60]
006AFF41C  mov      x0, x19
006AFF420  mov      w1, w20
006AFF424  blr      x8
006AFF428  mov      x0, x19
006AFF42C  mov      x1, xzr
006AFF430  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFF434  adrp     x21, #0x959f000
006AFF438  ldrb     w8, [x21, #0x8e5]
006AFF43C  mov      w20, w0
006AFF440  cbnz     w8, #0x6aff458
006AFF444  adrp     x0, #0x8f3e000
006AFF448  ldr      x0, [x0, #0xe8]
006AFF44C  bl       #0x382bd14 ; 
006AFF450  mov      w8, #1
006AFF454  strb     w8, [x21, #0x8e5]
006AFF458  adrp     x8, #0x8f3e000
006AFF45C  ldr      x8, [x8, #0xe8]
006AFF460  ldr      x2, [x8]
006AFF464  ldrb     w8, [x2, #0x53]
006AFF468  tbnz     w8, #5, #0x6aff474
006AFF46C  str      w20, [x19, #0x28]
006AFF470  b        #0x6aff484 ; 
006AFF474  ldr      x8, [x2, #0x60]
006AFF478  mov      x0, x19
006AFF47C  mov      w1, w20
006AFF480  blr      x8
006AFF484  ldp      x20, x19, [sp, #0x10]
006AFF488  mov      w0, #1
006AFF48C  ldp      x30, x21, [sp], #0x20
006AFF490  ret      

