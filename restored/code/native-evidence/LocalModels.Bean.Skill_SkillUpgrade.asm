; LocalModels.Bean.Skill_SkillUpgrade$$readImpl
; RVA 0x6B0C13C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0C13C  stp      x30, x21, [sp, #-0x20]!
006B0C140  stp      x20, x19, [sp, #0x10]
006B0C144  adrp     x20, #0x959f000
006B0C148  adrp     x21, #0x8f3e000
006B0C14C  ldrb     w8, [x20, #0x4c2]
006B0C150  ldr      x21, [x21, #0x978]
006B0C154  mov      x19, x0
006B0C158  tbnz     w8, #0, #0x6b0c170
006B0C15C  adrp     x0, #0x8f3e000
006B0C160  ldr      x0, [x0, #0x978]
006B0C164  bl       #0x382bd14 ; 
006B0C168  mov      w8, #1
006B0C16C  strb     w8, [x20, #0x4c2]
006B0C170  ldr      x1, [x21]
006B0C174  ldrb     w8, [x1, #0x53]
006B0C178  tbnz     w8, #5, #0x6b0c1c8
006B0C17C  mov      x0, x19
006B0C180  mov      x1, xzr
006B0C184  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C188  adrp     x21, #0x959f000
006B0C18C  ldrb     w8, [x21, #0x975]
006B0C190  mov      w20, w0
006B0C194  cbnz     w8, #0x6b0c1ac
006B0C198  adrp     x0, #0x8f3e000
006B0C19C  ldr      x0, [x0, #0x930]
006B0C1A0  bl       #0x382bd14 ; 
006B0C1A4  mov      w8, #1
006B0C1A8  strb     w8, [x21, #0x975]
006B0C1AC  adrp     x8, #0x8f3e000
006B0C1B0  ldr      x8, [x8, #0x930]
006B0C1B4  ldr      x2, [x8]
006B0C1B8  ldrb     w8, [x2, #0x53]
006B0C1BC  tbnz     w8, #5, #0x6b0c1dc
006B0C1C0  str      w20, [x19, #0x20]
006B0C1C4  b        #0x6b0c1ec ; 
006B0C1C8  ldr      x2, [x1, #0x60]
006B0C1CC  mov      x0, x19
006B0C1D0  ldp      x20, x19, [sp, #0x10]
006B0C1D4  ldp      x30, x21, [sp], #0x20
006B0C1D8  br       x2
006B0C1DC  ldr      x8, [x2, #0x60]
006B0C1E0  mov      x0, x19
006B0C1E4  mov      w1, w20
006B0C1E8  blr      x8
006B0C1EC  mov      x0, x19
006B0C1F0  mov      x1, xzr
006B0C1F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C1F8  adrp     x21, #0x959f000
006B0C1FC  ldrb     w8, [x21, #0x976]
006B0C200  mov      w20, w0
006B0C204  cbnz     w8, #0x6b0c21c
006B0C208  adrp     x0, #0x8f3e000
006B0C20C  ldr      x0, [x0, #0x940]
006B0C210  bl       #0x382bd14 ; 
006B0C214  mov      w8, #1
006B0C218  strb     w8, [x21, #0x976]
006B0C21C  adrp     x8, #0x8f3e000
006B0C220  ldr      x8, [x8, #0x940]
006B0C224  ldr      x2, [x8]
006B0C228  ldrb     w8, [x2, #0x53]
006B0C22C  tbnz     w8, #5, #0x6b0c238
006B0C230  str      w20, [x19, #0x24]
006B0C234  b        #0x6b0c248 ; 
006B0C238  ldr      x8, [x2, #0x60]
006B0C23C  mov      x0, x19
006B0C240  mov      w1, w20
006B0C244  blr      x8
006B0C248  mov      x0, x19
006B0C24C  mov      x1, xzr
006B0C250  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C254  adrp     x21, #0x959f000
006B0C258  ldrb     w8, [x21, #0x977]
006B0C25C  mov      w20, w0
006B0C260  cbnz     w8, #0x6b0c278
006B0C264  adrp     x0, #0x8f3e000
006B0C268  ldr      x0, [x0, #0x950]
006B0C26C  bl       #0x382bd14 ; 
006B0C270  mov      w8, #1
006B0C274  strb     w8, [x21, #0x977]
006B0C278  adrp     x8, #0x8f3e000
006B0C27C  ldr      x8, [x8, #0x950]
006B0C280  ldr      x2, [x8]
006B0C284  ldrb     w8, [x2, #0x53]
006B0C288  tbnz     w8, #5, #0x6b0c294
006B0C28C  str      w20, [x19, #0x28]
006B0C290  b        #0x6b0c2a4 ; 
006B0C294  ldr      x8, [x2, #0x60]
006B0C298  mov      x0, x19
006B0C29C  mov      w1, w20
006B0C2A0  blr      x8
006B0C2A4  mov      x0, x19
006B0C2A8  mov      x1, xzr
006B0C2AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C2B0  adrp     x21, #0x959f000
006B0C2B4  ldrb     w8, [x21, #0x978]
006B0C2B8  mov      w20, w0
006B0C2BC  cbnz     w8, #0x6b0c2d4
006B0C2C0  adrp     x0, #0x8f3e000
006B0C2C4  ldr      x0, [x0, #0x960]
006B0C2C8  bl       #0x382bd14 ; 
006B0C2CC  mov      w8, #1
006B0C2D0  strb     w8, [x21, #0x978]
006B0C2D4  adrp     x8, #0x8f3e000
006B0C2D8  ldr      x8, [x8, #0x960]
006B0C2DC  ldr      x2, [x8]
006B0C2E0  ldrb     w8, [x2, #0x53]
006B0C2E4  tbnz     w8, #5, #0x6b0c2f0
006B0C2E8  str      w20, [x19, #0x2c]
006B0C2EC  b        #0x6b0c300 ; 
006B0C2F0  ldr      x8, [x2, #0x60]
006B0C2F4  mov      x0, x19
006B0C2F8  mov      w1, w20
006B0C2FC  blr      x8
006B0C300  mov      x0, x19
006B0C304  mov      x1, xzr
006B0C308  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C30C  adrp     x21, #0x959f000
006B0C310  ldrb     w8, [x21, #0x979]
006B0C314  mov      w20, w0
006B0C318  cbnz     w8, #0x6b0c330
006B0C31C  adrp     x0, #0x8f3e000
006B0C320  ldr      x0, [x0, #0x970]
006B0C324  bl       #0x382bd14 ; 
006B0C328  mov      w8, #1
006B0C32C  strb     w8, [x21, #0x979]
006B0C330  adrp     x8, #0x8f3e000
006B0C334  ldr      x8, [x8, #0x970]
006B0C338  ldr      x2, [x8]
006B0C33C  ldrb     w8, [x2, #0x53]
006B0C340  tbnz     w8, #5, #0x6b0c34c
006B0C344  str      w20, [x19, #0x30]
006B0C348  b        #0x6b0c35c ; 
006B0C34C  ldr      x8, [x2, #0x60]
006B0C350  mov      x0, x19
006B0C354  mov      w1, w20
006B0C358  blr      x8
006B0C35C  ldp      x20, x19, [sp, #0x10]
006B0C360  mov      w0, #1
006B0C364  ldp      x30, x21, [sp], #0x20
006B0C368  ret      

