; LocalModels.Bean.SkillGroup_SurvivorFullGroup$$readImpl
; RVA 0x6AFB038; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFB038  stp      x30, x21, [sp, #-0x20]!
006AFB03C  stp      x20, x19, [sp, #0x10]
006AFB040  adrp     x20, #0x959f000
006AFB044  adrp     x21, #0x8f3d000
006AFB048  ldrb     w8, [x20, #0x30a]
006AFB04C  ldr      x21, [x21, #0xe00]
006AFB050  mov      x19, x0
006AFB054  tbnz     w8, #0, #0x6afb06c
006AFB058  adrp     x0, #0x8f3d000
006AFB05C  ldr      x0, [x0, #0xe00]
006AFB060  bl       #0x382bd14 ; 
006AFB064  mov      w8, #1
006AFB068  strb     w8, [x20, #0x30a]
006AFB06C  ldr      x1, [x21]
006AFB070  ldrb     w8, [x1, #0x53]
006AFB074  tbnz     w8, #5, #0x6afb0c4
006AFB078  mov      x0, x19
006AFB07C  mov      x1, xzr
006AFB080  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFB084  adrp     x21, #0x959f000
006AFB088  ldrb     w8, [x21, #0x8a2]
006AFB08C  mov      w20, w0
006AFB090  cbnz     w8, #0x6afb0a8
006AFB094  adrp     x0, #0x8f3d000
006AFB098  ldr      x0, [x0, #0xdd8]
006AFB09C  bl       #0x382bd14 ; 
006AFB0A0  mov      w8, #1
006AFB0A4  strb     w8, [x21, #0x8a2]
006AFB0A8  adrp     x8, #0x8f3d000
006AFB0AC  ldr      x8, [x8, #0xdd8]
006AFB0B0  ldr      x2, [x8]
006AFB0B4  ldrb     w8, [x2, #0x53]
006AFB0B8  tbnz     w8, #5, #0x6afb0d8
006AFB0BC  str      w20, [x19, #0x20]
006AFB0C0  b        #0x6afb0e8 ; 
006AFB0C4  ldr      x2, [x1, #0x60]
006AFB0C8  mov      x0, x19
006AFB0CC  ldp      x20, x19, [sp, #0x10]
006AFB0D0  ldp      x30, x21, [sp], #0x20
006AFB0D4  br       x2
006AFB0D8  ldr      x8, [x2, #0x60]
006AFB0DC  mov      x0, x19
006AFB0E0  mov      w1, w20
006AFB0E4  blr      x8
006AFB0E8  mov      x0, x19
006AFB0EC  mov      x1, xzr
006AFB0F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFB0F4  adrp     x21, #0x959f000
006AFB0F8  ldrb     w8, [x21, #0x8a3]
006AFB0FC  mov      w20, w0
006AFB100  cbnz     w8, #0x6afb118
006AFB104  adrp     x0, #0x8f3d000
006AFB108  ldr      x0, [x0, #0xde8]
006AFB10C  bl       #0x382bd14 ; 
006AFB110  mov      w8, #1
006AFB114  strb     w8, [x21, #0x8a3]
006AFB118  adrp     x8, #0x8f3d000
006AFB11C  ldr      x8, [x8, #0xde8]
006AFB120  ldr      x2, [x8]
006AFB124  ldrb     w8, [x2, #0x53]
006AFB128  tbnz     w8, #5, #0x6afb134
006AFB12C  str      w20, [x19, #0x24]
006AFB130  b        #0x6afb144 ; 
006AFB134  ldr      x8, [x2, #0x60]
006AFB138  mov      x0, x19
006AFB13C  mov      w1, w20
006AFB140  blr      x8
006AFB144  mov      x0, x19
006AFB148  mov      x1, xzr
006AFB14C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFB150  adrp     x21, #0x959f000
006AFB154  ldrb     w8, [x21, #0x8a4]
006AFB158  mov      w20, w0
006AFB15C  cbnz     w8, #0x6afb174
006AFB160  adrp     x0, #0x8f3d000
006AFB164  ldr      x0, [x0, #0xdf8]
006AFB168  bl       #0x382bd14 ; 
006AFB16C  mov      w8, #1
006AFB170  strb     w8, [x21, #0x8a4]
006AFB174  adrp     x8, #0x8f3d000
006AFB178  ldr      x8, [x8, #0xdf8]
006AFB17C  ldr      x2, [x8]
006AFB180  ldrb     w8, [x2, #0x53]
006AFB184  tbnz     w8, #5, #0x6afb190
006AFB188  str      w20, [x19, #0x28]
006AFB18C  b        #0x6afb1a0 ; 
006AFB190  ldr      x8, [x2, #0x60]
006AFB194  mov      x0, x19
006AFB198  mov      w1, w20
006AFB19C  blr      x8
006AFB1A0  ldp      x20, x19, [sp, #0x10]
006AFB1A4  mov      w0, #1
006AFB1A8  ldp      x30, x21, [sp], #0x20
006AFB1AC  ret      

