; LocalModels.Bean.Attribute_AttributeAbility$$readImpl
; RVA 0x6703770; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006703770  str      d8, [sp, #-0x30]!
006703774  stp      x30, x21, [sp, #0x10]
006703778  stp      x20, x19, [sp, #0x20]
00670377C  adrp     x20, #0x959a000
006703780  adrp     x21, #0x8f17000
006703784  ldrb     w8, [x20, #0x8da]
006703788  ldr      x21, [x21, #0x8d0]
00670378C  mov      x19, x0
006703790  tbnz     w8, #0, #0x67037a8
006703794  adrp     x0, #0x8f17000
006703798  ldr      x0, [x0, #0x8d0]
00670379C  bl       #0x382bd14 ; 
0067037A0  mov      w8, #1
0067037A4  strb     w8, [x20, #0x8da]
0067037A8  ldr      x1, [x21]
0067037AC  ldrb     w8, [x1, #0x53]
0067037B0  tbnz     w8, #5, #0x670380c
0067037B4  mov      x0, x19
0067037B8  mov      x1, xzr
0067037BC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0067037C0  adrp     x21, #0x959a000
0067037C4  ldrb     w8, [x21, #0x974]
0067037C8  mov      x20, x0
0067037CC  cbnz     w8, #0x67037e4
0067037D0  adrp     x0, #0x8f17000
0067037D4  ldr      x0, [x0, #0x8b8]
0067037D8  bl       #0x382bd14 ; 
0067037DC  mov      w8, #1
0067037E0  strb     w8, [x21, #0x974]
0067037E4  adrp     x8, #0x8f17000
0067037E8  ldr      x8, [x8, #0x8b8]
0067037EC  ldr      x2, [x8]
0067037F0  ldrb     w8, [x2, #0x53]
0067037F4  tbnz     w8, #5, #0x6703824
0067037F8  mov      x0, x19
0067037FC  str      x20, [x0, #0x20]!
006703800  mov      x1, x20
006703804  bl       #0x382bcb8 ; 
006703808  b        #0x6703834 ; 
00670380C  ldr      x2, [x1, #0x60]
006703810  mov      x0, x19
006703814  ldp      x20, x19, [sp, #0x20]
006703818  ldp      x30, x21, [sp, #0x10]
00670381C  ldr      d8, [sp], #0x30
006703820  br       x2
006703824  ldr      x8, [x2, #0x60]
006703828  mov      x0, x19
00670382C  mov      x1, x20
006703830  blr      x8
006703834  mov      x0, x19
006703838  mov      x1, xzr
00670383C  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006703840  adrp     x20, #0x959a000
006703844  ldrb     w8, [x20, #0x975]
006703848  mov      v8.16b, v0.16b
00670384C  cbnz     w8, #0x6703864
006703850  adrp     x0, #0x8f17000
006703854  ldr      x0, [x0, #0x8c8]
006703858  bl       #0x382bd14 ; 
00670385C  mov      w8, #1
006703860  strb     w8, [x20, #0x975]
006703864  adrp     x8, #0x8f17000
006703868  ldr      x8, [x8, #0x8c8]
00670386C  ldr      x1, [x8]
006703870  ldrb     w8, [x1, #0x53]
006703874  tbnz     w8, #5, #0x6703880
006703878  str      s8, [x19, #0x28]
00670387C  b        #0x6703890 ; 
006703880  ldr      x8, [x1, #0x60]
006703884  mov      x0, x19
006703888  mov      v0.16b, v8.16b
00670388C  blr      x8
006703890  ldp      x20, x19, [sp, #0x20]
006703894  ldp      x30, x21, [sp, #0x10]
006703898  mov      w0, #1
00670389C  ldr      d8, [sp], #0x30
0067038A0  ret      

