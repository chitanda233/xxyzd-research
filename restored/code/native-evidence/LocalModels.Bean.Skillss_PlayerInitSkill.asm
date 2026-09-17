; LocalModels.Bean.Skillss_PlayerInitSkill$$readImpl
; RVA 0x6B02500; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B02500  stp      x30, x21, [sp, #-0x20]!
006B02504  stp      x20, x19, [sp, #0x10]
006B02508  adrp     x20, #0x959f000
006B0250C  adrp     x21, #0x8f3e000
006B02510  ldrb     w8, [x20, #0x3c4]
006B02514  ldr      x21, [x21, #0x340]
006B02518  mov      x19, x0
006B0251C  tbnz     w8, #0, #0x6b02534
006B02520  adrp     x0, #0x8f3e000
006B02524  ldr      x0, [x0, #0x340]
006B02528  bl       #0x382bd14 ; 
006B0252C  mov      w8, #1
006B02530  strb     w8, [x20, #0x3c4]
006B02534  ldr      x1, [x21]
006B02538  ldrb     w8, [x1, #0x53]
006B0253C  tbnz     w8, #5, #0x6b0258c
006B02540  mov      x0, x19
006B02544  mov      x1, xzr
006B02548  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0254C  adrp     x21, #0x959f000
006B02550  ldrb     w8, [x21, #0x906]
006B02554  mov      w20, w0
006B02558  cbnz     w8, #0x6b02570
006B0255C  adrp     x0, #0x8f3e000
006B02560  ldr      x0, [x0, #0x328]
006B02564  bl       #0x382bd14 ; 
006B02568  mov      w8, #1
006B0256C  strb     w8, [x21, #0x906]
006B02570  adrp     x8, #0x8f3e000
006B02574  ldr      x8, [x8, #0x328]
006B02578  ldr      x2, [x8]
006B0257C  ldrb     w8, [x2, #0x53]
006B02580  tbnz     w8, #5, #0x6b025a0
006B02584  str      w20, [x19, #0x20]
006B02588  b        #0x6b025b0 ; 
006B0258C  ldr      x2, [x1, #0x60]
006B02590  mov      x0, x19
006B02594  ldp      x20, x19, [sp, #0x10]
006B02598  ldp      x30, x21, [sp], #0x20
006B0259C  br       x2
006B025A0  ldr      x8, [x2, #0x60]
006B025A4  mov      x0, x19
006B025A8  mov      w1, w20
006B025AC  blr      x8
006B025B0  mov      x0, x19
006B025B4  mov      x1, xzr
006B025B8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B025BC  adrp     x21, #0x959f000
006B025C0  ldrb     w8, [x21, #0x907]
006B025C4  mov      x20, x0
006B025C8  cbnz     w8, #0x6b025e0
006B025CC  adrp     x0, #0x8f3e000
006B025D0  ldr      x0, [x0, #0x338]
006B025D4  bl       #0x382bd14 ; 
006B025D8  mov      w8, #1
006B025DC  strb     w8, [x21, #0x907]
006B025E0  adrp     x8, #0x8f3e000
006B025E4  ldr      x8, [x8, #0x338]
006B025E8  ldr      x2, [x8]
006B025EC  ldrb     w8, [x2, #0x53]
006B025F0  tbnz     w8, #5, #0x6b02608
006B025F4  str      x20, [x19, #0x28]!
006B025F8  mov      x0, x19
006B025FC  mov      x1, x20
006B02600  bl       #0x382bcb8 ; 
006B02604  b        #0x6b02618 ; 
006B02608  ldr      x8, [x2, #0x60]
006B0260C  mov      x0, x19
006B02610  mov      x1, x20
006B02614  blr      x8
006B02618  ldp      x20, x19, [sp, #0x10]
006B0261C  mov      w0, #1
006B02620  ldp      x30, x21, [sp], #0x20
006B02624  ret      

