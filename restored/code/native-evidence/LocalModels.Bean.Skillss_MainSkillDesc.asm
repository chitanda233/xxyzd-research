; LocalModels.Bean.Skillss_MainSkillDesc$$readImpl
; RVA 0x6B02104; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B02104  stp      x30, x21, [sp, #-0x20]!
006B02108  stp      x20, x19, [sp, #0x10]
006B0210C  adrp     x20, #0x959f000
006B02110  adrp     x21, #0x8f3e000
006B02114  ldrb     w8, [x20, #0x3bd]
006B02118  ldr      x21, [x21, #0x310]
006B0211C  mov      x19, x0
006B02120  tbnz     w8, #0, #0x6b02138
006B02124  adrp     x0, #0x8f3e000
006B02128  ldr      x0, [x0, #0x310]
006B0212C  bl       #0x382bd14 ; 
006B02130  mov      w8, #1
006B02134  strb     w8, [x20, #0x3bd]
006B02138  ldr      x1, [x21]
006B0213C  ldrb     w8, [x1, #0x53]
006B02140  tbnz     w8, #5, #0x6b02190
006B02144  mov      x0, x19
006B02148  mov      x1, xzr
006B0214C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B02150  adrp     x21, #0x959f000
006B02154  ldrb     w8, [x21, #0x904]
006B02158  mov      w20, w0
006B0215C  cbnz     w8, #0x6b02174
006B02160  adrp     x0, #0x8f3e000
006B02164  ldr      x0, [x0, #0x2f8]
006B02168  bl       #0x382bd14 ; 
006B0216C  mov      w8, #1
006B02170  strb     w8, [x21, #0x904]
006B02174  adrp     x8, #0x8f3e000
006B02178  ldr      x8, [x8, #0x2f8]
006B0217C  ldr      x2, [x8]
006B02180  ldrb     w8, [x2, #0x53]
006B02184  tbnz     w8, #5, #0x6b021a4
006B02188  str      w20, [x19, #0x20]
006B0218C  b        #0x6b021b4 ; 
006B02190  ldr      x2, [x1, #0x60]
006B02194  mov      x0, x19
006B02198  ldp      x20, x19, [sp, #0x10]
006B0219C  ldp      x30, x21, [sp], #0x20
006B021A0  br       x2
006B021A4  ldr      x8, [x2, #0x60]
006B021A8  mov      x0, x19
006B021AC  mov      w1, w20
006B021B0  blr      x8
006B021B4  mov      x0, x19
006B021B8  mov      x1, xzr
006B021BC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B021C0  adrp     x21, #0x959f000
006B021C4  ldrb     w8, [x21, #0x905]
006B021C8  mov      x20, x0
006B021CC  cbnz     w8, #0x6b021e4
006B021D0  adrp     x0, #0x8f3e000
006B021D4  ldr      x0, [x0, #0x308]
006B021D8  bl       #0x382bd14 ; 
006B021DC  mov      w8, #1
006B021E0  strb     w8, [x21, #0x905]
006B021E4  adrp     x8, #0x8f3e000
006B021E8  ldr      x8, [x8, #0x308]
006B021EC  ldr      x2, [x8]
006B021F0  ldrb     w8, [x2, #0x53]
006B021F4  tbnz     w8, #5, #0x6b0220c
006B021F8  str      x20, [x19, #0x28]!
006B021FC  mov      x0, x19
006B02200  mov      x1, x20
006B02204  bl       #0x382bcb8 ; 
006B02208  b        #0x6b0221c ; 
006B0220C  ldr      x8, [x2, #0x60]
006B02210  mov      x0, x19
006B02214  mov      x1, x20
006B02218  blr      x8
006B0221C  ldp      x20, x19, [sp, #0x10]
006B02220  mov      w0, #1
006B02224  ldp      x30, x21, [sp], #0x20
006B02228  ret      

