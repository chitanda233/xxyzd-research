; LocalModels.Bean.Skill_MainSkillDesc$$readImpl
; RVA 0x6B0A75C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0A75C  stp      x30, x21, [sp, #-0x20]!
006B0A760  stp      x20, x19, [sp, #0x10]
006B0A764  adrp     x20, #0x959f000
006B0A768  adrp     x21, #0x8f3e000
006B0A76C  ldrb     w8, [x20, #0x494]
006B0A770  ldr      x21, [x21, #0x870]
006B0A774  mov      x19, x0
006B0A778  tbnz     w8, #0, #0x6b0a790
006B0A77C  adrp     x0, #0x8f3e000
006B0A780  ldr      x0, [x0, #0x870]
006B0A784  bl       #0x382bd14 ; 
006B0A788  mov      w8, #1
006B0A78C  strb     w8, [x20, #0x494]
006B0A790  ldr      x1, [x21]
006B0A794  ldrb     w8, [x1, #0x53]
006B0A798  tbnz     w8, #5, #0x6b0a7e8
006B0A79C  mov      x0, x19
006B0A7A0  mov      x1, xzr
006B0A7A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0A7A8  adrp     x21, #0x959f000
006B0A7AC  ldrb     w8, [x21, #0x967]
006B0A7B0  mov      w20, w0
006B0A7B4  cbnz     w8, #0x6b0a7cc
006B0A7B8  adrp     x0, #0x8f3e000
006B0A7BC  ldr      x0, [x0, #0x858]
006B0A7C0  bl       #0x382bd14 ; 
006B0A7C4  mov      w8, #1
006B0A7C8  strb     w8, [x21, #0x967]
006B0A7CC  adrp     x8, #0x8f3e000
006B0A7D0  ldr      x8, [x8, #0x858]
006B0A7D4  ldr      x2, [x8]
006B0A7D8  ldrb     w8, [x2, #0x53]
006B0A7DC  tbnz     w8, #5, #0x6b0a7fc
006B0A7E0  str      w20, [x19, #0x20]
006B0A7E4  b        #0x6b0a80c ; 
006B0A7E8  ldr      x2, [x1, #0x60]
006B0A7EC  mov      x0, x19
006B0A7F0  ldp      x20, x19, [sp, #0x10]
006B0A7F4  ldp      x30, x21, [sp], #0x20
006B0A7F8  br       x2
006B0A7FC  ldr      x8, [x2, #0x60]
006B0A800  mov      x0, x19
006B0A804  mov      w1, w20
006B0A808  blr      x8
006B0A80C  mov      x0, x19
006B0A810  mov      x1, xzr
006B0A814  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0A818  adrp     x21, #0x959f000
006B0A81C  ldrb     w8, [x21, #0x968]
006B0A820  mov      x20, x0
006B0A824  cbnz     w8, #0x6b0a83c
006B0A828  adrp     x0, #0x8f3e000
006B0A82C  ldr      x0, [x0, #0x868]
006B0A830  bl       #0x382bd14 ; 
006B0A834  mov      w8, #1
006B0A838  strb     w8, [x21, #0x968]
006B0A83C  adrp     x8, #0x8f3e000
006B0A840  ldr      x8, [x8, #0x868]
006B0A844  ldr      x2, [x8]
006B0A848  ldrb     w8, [x2, #0x53]
006B0A84C  tbnz     w8, #5, #0x6b0a864
006B0A850  str      x20, [x19, #0x28]!
006B0A854  mov      x0, x19
006B0A858  mov      x1, x20
006B0A85C  bl       #0x382bcb8 ; 
006B0A860  b        #0x6b0a874 ; 
006B0A864  ldr      x8, [x2, #0x60]
006B0A868  mov      x0, x19
006B0A86C  mov      x1, x20
006B0A870  blr      x8
006B0A874  ldp      x20, x19, [sp, #0x10]
006B0A878  mov      w0, #1
006B0A87C  ldp      x30, x21, [sp], #0x20
006B0A880  ret      

