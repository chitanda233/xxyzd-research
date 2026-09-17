; LocalModels.Bean.Shop_LootBoxRate$$readImpl
; RVA 0x6AEC124; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEC124  stp      x30, x21, [sp, #-0x20]!
006AEC128  stp      x20, x19, [sp, #0x10]
006AEC12C  adrp     x20, #0x959e000
006AEC130  adrp     x21, #0x8f3d000
006AEC134  ldrb     w8, [x20, #0xdec]
006AEC138  ldr      x21, [x21, #0x2b8]
006AEC13C  mov      x19, x0
006AEC140  tbnz     w8, #0, #0x6aec158
006AEC144  adrp     x0, #0x8f3d000
006AEC148  ldr      x0, [x0, #0x2b8]
006AEC14C  bl       #0x382bd14 ; 
006AEC150  mov      w8, #1
006AEC154  strb     w8, [x20, #0xdec]
006AEC158  ldr      x1, [x21]
006AEC15C  ldrb     w8, [x1, #0x53]
006AEC160  tbnz     w8, #5, #0x6aec1b0
006AEC164  mov      x0, x19
006AEC168  mov      x1, xzr
006AEC16C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC170  adrp     x21, #0x959f000
006AEC174  ldrb     w8, [x21, #0x214]
006AEC178  mov      w20, w0
006AEC17C  cbnz     w8, #0x6aec194
006AEC180  adrp     x0, #0x8f3d000
006AEC184  ldr      x0, [x0, #0x260]
006AEC188  bl       #0x382bd14 ; 
006AEC18C  mov      w8, #1
006AEC190  strb     w8, [x21, #0x214]
006AEC194  adrp     x8, #0x8f3d000
006AEC198  ldr      x8, [x8, #0x260]
006AEC19C  ldr      x2, [x8]
006AEC1A0  ldrb     w8, [x2, #0x53]
006AEC1A4  tbnz     w8, #5, #0x6aec1c4
006AEC1A8  str      w20, [x19, #0x20]
006AEC1AC  b        #0x6aec1d4 ; 
006AEC1B0  ldr      x2, [x1, #0x60]
006AEC1B4  mov      x0, x19
006AEC1B8  ldp      x20, x19, [sp, #0x10]
006AEC1BC  ldp      x30, x21, [sp], #0x20
006AEC1C0  br       x2
006AEC1C4  ldr      x8, [x2, #0x60]
006AEC1C8  mov      x0, x19
006AEC1CC  mov      w1, w20
006AEC1D0  blr      x8
006AEC1D4  mov      x0, x19
006AEC1D8  mov      x1, xzr
006AEC1DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC1E0  adrp     x21, #0x959f000
006AEC1E4  ldrb     w8, [x21, #0x215]
006AEC1E8  mov      w20, w0
006AEC1EC  cbnz     w8, #0x6aec204
006AEC1F0  adrp     x0, #0x8f3d000
006AEC1F4  ldr      x0, [x0, #0x270]
006AEC1F8  bl       #0x382bd14 ; 
006AEC1FC  mov      w8, #1
006AEC200  strb     w8, [x21, #0x215]
006AEC204  adrp     x8, #0x8f3d000
006AEC208  ldr      x8, [x8, #0x270]
006AEC20C  ldr      x2, [x8]
006AEC210  ldrb     w8, [x2, #0x53]
006AEC214  tbnz     w8, #5, #0x6aec220
006AEC218  str      w20, [x19, #0x24]
006AEC21C  b        #0x6aec230 ; 
006AEC220  ldr      x8, [x2, #0x60]
006AEC224  mov      x0, x19
006AEC228  mov      w1, w20
006AEC22C  blr      x8
006AEC230  mov      x0, x19
006AEC234  mov      x1, xzr
006AEC238  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AEC23C  adrp     x21, #0x959f000
006AEC240  ldrb     w8, [x21, #0x216]
006AEC244  mov      x20, x0
006AEC248  cbnz     w8, #0x6aec260
006AEC24C  adrp     x0, #0x8f3d000
006AEC250  ldr      x0, [x0, #0x280]
006AEC254  bl       #0x382bd14 ; 
006AEC258  mov      w8, #1
006AEC25C  strb     w8, [x21, #0x216]
006AEC260  adrp     x8, #0x8f3d000
006AEC264  ldr      x8, [x8, #0x280]
006AEC268  ldr      x2, [x8]
006AEC26C  ldrb     w8, [x2, #0x53]
006AEC270  tbnz     w8, #5, #0x6aec288
006AEC274  mov      x0, x19
006AEC278  str      x20, [x0, #0x28]!
006AEC27C  mov      x1, x20
006AEC280  bl       #0x382bcb8 ; 
006AEC284  b        #0x6aec298 ; 
006AEC288  ldr      x8, [x2, #0x60]
006AEC28C  mov      x0, x19
006AEC290  mov      x1, x20
006AEC294  blr      x8
006AEC298  mov      x0, x19
006AEC29C  mov      x1, xzr
006AEC2A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC2A4  adrp     x21, #0x959f000
006AEC2A8  ldrb     w8, [x21, #0x217]
006AEC2AC  mov      w20, w0
006AEC2B0  cbnz     w8, #0x6aec2c8
006AEC2B4  adrp     x0, #0x8f3d000
006AEC2B8  ldr      x0, [x0, #0x290]
006AEC2BC  bl       #0x382bd14 ; 
006AEC2C0  mov      w8, #1
006AEC2C4  strb     w8, [x21, #0x217]
006AEC2C8  adrp     x8, #0x8f3d000
006AEC2CC  ldr      x8, [x8, #0x290]
006AEC2D0  ldr      x2, [x8]
006AEC2D4  ldrb     w8, [x2, #0x53]
006AEC2D8  tbnz     w8, #5, #0x6aec2e4
006AEC2DC  str      w20, [x19, #0x30]
006AEC2E0  b        #0x6aec2f4 ; 
006AEC2E4  ldr      x8, [x2, #0x60]
006AEC2E8  mov      x0, x19
006AEC2EC  mov      w1, w20
006AEC2F0  blr      x8
006AEC2F4  mov      x0, x19
006AEC2F8  mov      x1, xzr
006AEC2FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC300  adrp     x21, #0x959f000
006AEC304  ldrb     w8, [x21, #0x218]
006AEC308  mov      w20, w0
006AEC30C  cbnz     w8, #0x6aec324
006AEC310  adrp     x0, #0x8f3d000
006AEC314  ldr      x0, [x0, #0x2a0]
006AEC318  bl       #0x382bd14 ; 
006AEC31C  mov      w8, #1
006AEC320  strb     w8, [x21, #0x218]
006AEC324  adrp     x8, #0x8f3d000
006AEC328  ldr      x8, [x8, #0x2a0]
006AEC32C  ldr      x2, [x8]
006AEC330  ldrb     w8, [x2, #0x53]
006AEC334  tbnz     w8, #5, #0x6aec340
006AEC338  str      w20, [x19, #0x34]
006AEC33C  b        #0x6aec350 ; 
006AEC340  ldr      x8, [x2, #0x60]
006AEC344  mov      x0, x19
006AEC348  mov      w1, w20
006AEC34C  blr      x8
006AEC350  mov      x0, x19
006AEC354  mov      x1, xzr
006AEC358  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AEC35C  adrp     x21, #0x959f000
006AEC360  ldrb     w8, [x21, #0x219]
006AEC364  mov      x20, x0
006AEC368  cbnz     w8, #0x6aec380
006AEC36C  adrp     x0, #0x8f3d000
006AEC370  ldr      x0, [x0, #0x2b0]
006AEC374  bl       #0x382bd14 ; 
006AEC378  mov      w8, #1
006AEC37C  strb     w8, [x21, #0x219]
006AEC380  adrp     x8, #0x8f3d000
006AEC384  ldr      x8, [x8, #0x2b0]
006AEC388  ldr      x2, [x8]
006AEC38C  ldrb     w8, [x2, #0x53]
006AEC390  tbnz     w8, #5, #0x6aec3a8
006AEC394  str      x20, [x19, #0x38]!
006AEC398  mov      x0, x19
006AEC39C  mov      x1, x20
006AEC3A0  bl       #0x382bcb8 ; 
006AEC3A4  b        #0x6aec3b8 ; 
006AEC3A8  ldr      x8, [x2, #0x60]
006AEC3AC  mov      x0, x19
006AEC3B0  mov      x1, x20
006AEC3B4  blr      x8
006AEC3B8  ldp      x20, x19, [sp, #0x10]
006AEC3BC  mov      w0, #1
006AEC3C0  ldp      x30, x21, [sp], #0x20
006AEC3C4  ret      

