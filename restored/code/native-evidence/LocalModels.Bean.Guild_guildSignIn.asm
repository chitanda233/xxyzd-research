; LocalModels.Bean.Guild_guildSignIn$$readImpl
; RVA 0x6A95774; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A95774  stp      x30, x21, [sp, #-0x20]!
006A95778  stp      x20, x19, [sp, #0x10]
006A9577C  adrp     x20, #0x959e000
006A95780  adrp     x21, #0x8f39000
006A95784  ldrb     w8, [x20, #0x179]
006A95788  ldr      x21, [x21, #0x1d0]
006A9578C  mov      x19, x0
006A95790  tbnz     w8, #0, #0x6a957a8
006A95794  adrp     x0, #0x8f39000
006A95798  ldr      x0, [x0, #0x1d0]
006A9579C  bl       #0x382bd14 ; 
006A957A0  mov      w8, #1
006A957A4  strb     w8, [x20, #0x179]
006A957A8  ldr      x1, [x21]
006A957AC  ldrb     w8, [x1, #0x53]
006A957B0  tbnz     w8, #5, #0x6a95800
006A957B4  mov      x0, x19
006A957B8  mov      x1, xzr
006A957BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A957C0  adrp     x21, #0x959e000
006A957C4  ldrb     w8, [x21, #0x5e0]
006A957C8  mov      w20, w0
006A957CC  cbnz     w8, #0x6a957e4
006A957D0  adrp     x0, #0x8f39000
006A957D4  ldr      x0, [x0, #0x188]
006A957D8  bl       #0x382bd14 ; 
006A957DC  mov      w8, #1
006A957E0  strb     w8, [x21, #0x5e0]
006A957E4  adrp     x8, #0x8f39000
006A957E8  ldr      x8, [x8, #0x188]
006A957EC  ldr      x2, [x8]
006A957F0  ldrb     w8, [x2, #0x53]
006A957F4  tbnz     w8, #5, #0x6a95814
006A957F8  str      w20, [x19, #0x20]
006A957FC  b        #0x6a95824 ; 
006A95800  ldr      x2, [x1, #0x60]
006A95804  mov      x0, x19
006A95808  ldp      x20, x19, [sp, #0x10]
006A9580C  ldp      x30, x21, [sp], #0x20
006A95810  br       x2
006A95814  ldr      x8, [x2, #0x60]
006A95818  mov      x0, x19
006A9581C  mov      w1, w20
006A95820  blr      x8
006A95824  mov      x0, x19
006A95828  mov      x1, xzr
006A9582C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A95830  adrp     x21, #0x959e000
006A95834  ldrb     w8, [x21, #0x5e1]
006A95838  mov      w20, w0
006A9583C  cbnz     w8, #0x6a95854
006A95840  adrp     x0, #0x8f39000
006A95844  ldr      x0, [x0, #0x198]
006A95848  bl       #0x382bd14 ; 
006A9584C  mov      w8, #1
006A95850  strb     w8, [x21, #0x5e1]
006A95854  adrp     x8, #0x8f39000
006A95858  ldr      x8, [x8, #0x198]
006A9585C  ldr      x2, [x8]
006A95860  ldrb     w8, [x2, #0x53]
006A95864  tbnz     w8, #5, #0x6a95870
006A95868  str      w20, [x19, #0x24]
006A9586C  b        #0x6a95880 ; 
006A95870  ldr      x8, [x2, #0x60]
006A95874  mov      x0, x19
006A95878  mov      w1, w20
006A9587C  blr      x8
006A95880  mov      x0, x19
006A95884  mov      x1, xzr
006A95888  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9588C  adrp     x21, #0x959e000
006A95890  ldrb     w8, [x21, #0x5e2]
006A95894  mov      w20, w0
006A95898  cbnz     w8, #0x6a958b0
006A9589C  adrp     x0, #0x8f39000
006A958A0  ldr      x0, [x0, #0x1a8]
006A958A4  bl       #0x382bd14 ; 
006A958A8  mov      w8, #1
006A958AC  strb     w8, [x21, #0x5e2]
006A958B0  adrp     x8, #0x8f39000
006A958B4  ldr      x8, [x8, #0x1a8]
006A958B8  ldr      x2, [x8]
006A958BC  ldrb     w8, [x2, #0x53]
006A958C0  tbnz     w8, #5, #0x6a958cc
006A958C4  str      w20, [x19, #0x28]
006A958C8  b        #0x6a958dc ; 
006A958CC  ldr      x8, [x2, #0x60]
006A958D0  mov      x0, x19
006A958D4  mov      w1, w20
006A958D8  blr      x8
006A958DC  mov      x0, x19
006A958E0  mov      x1, xzr
006A958E4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A958E8  adrp     x21, #0x959e000
006A958EC  ldrb     w8, [x21, #0x5e3]
006A958F0  mov      x20, x0
006A958F4  cbnz     w8, #0x6a9590c
006A958F8  adrp     x0, #0x8f39000
006A958FC  ldr      x0, [x0, #0x1b8]
006A95900  bl       #0x382bd14 ; 
006A95904  mov      w8, #1
006A95908  strb     w8, [x21, #0x5e3]
006A9590C  adrp     x8, #0x8f39000
006A95910  ldr      x8, [x8, #0x1b8]
006A95914  ldr      x2, [x8]
006A95918  ldrb     w8, [x2, #0x53]
006A9591C  tbnz     w8, #5, #0x6a95934
006A95920  mov      x0, x19
006A95924  str      x20, [x0, #0x30]!
006A95928  mov      x1, x20
006A9592C  bl       #0x382bcb8 ; 
006A95930  b        #0x6a95944 ; 
006A95934  ldr      x8, [x2, #0x60]
006A95938  mov      x0, x19
006A9593C  mov      x1, x20
006A95940  blr      x8
006A95944  mov      x0, x19
006A95948  mov      x1, xzr
006A9594C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A95950  adrp     x21, #0x959e000
006A95954  ldrb     w8, [x21, #0x5e4]
006A95958  mov      x20, x0
006A9595C  cbnz     w8, #0x6a95974
006A95960  adrp     x0, #0x8f39000
006A95964  ldr      x0, [x0, #0x1c8]
006A95968  bl       #0x382bd14 ; 
006A9596C  mov      w8, #1
006A95970  strb     w8, [x21, #0x5e4]
006A95974  adrp     x8, #0x8f39000
006A95978  ldr      x8, [x8, #0x1c8]
006A9597C  ldr      x2, [x8]
006A95980  ldrb     w8, [x2, #0x53]
006A95984  tbnz     w8, #5, #0x6a9599c
006A95988  str      x20, [x19, #0x38]!
006A9598C  mov      x0, x19
006A95990  mov      x1, x20
006A95994  bl       #0x382bcb8 ; 
006A95998  b        #0x6a959ac ; 
006A9599C  ldr      x8, [x2, #0x60]
006A959A0  mov      x0, x19
006A959A4  mov      x1, x20
006A959A8  blr      x8
006A959AC  ldp      x20, x19, [sp, #0x10]
006A959B0  mov      w0, #1
006A959B4  ldp      x30, x21, [sp], #0x20
006A959B8  ret      

