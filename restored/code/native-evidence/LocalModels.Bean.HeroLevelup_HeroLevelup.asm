; LocalModels.Bean.HeroLevelup_HeroLevelup$$readImpl
; RVA 0x6A985CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A985CC  stp      x30, x21, [sp, #-0x20]!
006A985D0  stp      x20, x19, [sp, #0x10]
006A985D4  adrp     x20, #0x959e000
006A985D8  adrp     x21, #0x8f39000
006A985DC  ldrb     w8, [x20, #0x1c7]
006A985E0  ldr      x21, [x21, #0x400]
006A985E4  mov      x19, x0
006A985E8  tbnz     w8, #0, #0x6a98600
006A985EC  adrp     x0, #0x8f39000
006A985F0  ldr      x0, [x0, #0x400]
006A985F4  bl       #0x382bd14 ; 
006A985F8  mov      w8, #1
006A985FC  strb     w8, [x20, #0x1c7]
006A98600  ldr      x1, [x21]
006A98604  ldrb     w8, [x1, #0x53]
006A98608  tbnz     w8, #5, #0x6a98658
006A9860C  mov      x0, x19
006A98610  mov      x1, xzr
006A98614  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A98618  adrp     x21, #0x959e000
006A9861C  ldrb     w8, [x21, #0x5fe]
006A98620  mov      w20, w0
006A98624  cbnz     w8, #0x6a9863c
006A98628  adrp     x0, #0x8f39000
006A9862C  ldr      x0, [x0, #0x3b8]
006A98630  bl       #0x382bd14 ; 
006A98634  mov      w8, #1
006A98638  strb     w8, [x21, #0x5fe]
006A9863C  adrp     x8, #0x8f39000
006A98640  ldr      x8, [x8, #0x3b8]
006A98644  ldr      x2, [x8]
006A98648  ldrb     w8, [x2, #0x53]
006A9864C  tbnz     w8, #5, #0x6a9866c
006A98650  str      w20, [x19, #0x20]
006A98654  b        #0x6a9867c ; 
006A98658  ldr      x2, [x1, #0x60]
006A9865C  mov      x0, x19
006A98660  ldp      x20, x19, [sp, #0x10]
006A98664  ldp      x30, x21, [sp], #0x20
006A98668  br       x2
006A9866C  ldr      x8, [x2, #0x60]
006A98670  mov      x0, x19
006A98674  mov      w1, w20
006A98678  blr      x8
006A9867C  mov      x0, x19
006A98680  mov      x1, xzr
006A98684  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A98688  adrp     x21, #0x959e000
006A9868C  ldrb     w8, [x21, #0x5ff]
006A98690  mov      w20, w0
006A98694  cbnz     w8, #0x6a986ac
006A98698  adrp     x0, #0x8f39000
006A9869C  ldr      x0, [x0, #0x3c8]
006A986A0  bl       #0x382bd14 ; 
006A986A4  mov      w8, #1
006A986A8  strb     w8, [x21, #0x5ff]
006A986AC  adrp     x8, #0x8f39000
006A986B0  ldr      x8, [x8, #0x3c8]
006A986B4  ldr      x2, [x8]
006A986B8  ldrb     w8, [x2, #0x53]
006A986BC  tbnz     w8, #5, #0x6a986c8
006A986C0  str      w20, [x19, #0x24]
006A986C4  b        #0x6a986d8 ; 
006A986C8  ldr      x8, [x2, #0x60]
006A986CC  mov      x0, x19
006A986D0  mov      w1, w20
006A986D4  blr      x8
006A986D8  mov      x0, x19
006A986DC  mov      x1, xzr
006A986E0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A986E4  adrp     x21, #0x959e000
006A986E8  ldrb     w8, [x21, #0x600]
006A986EC  mov      x20, x0
006A986F0  cbnz     w8, #0x6a98708
006A986F4  adrp     x0, #0x8f39000
006A986F8  ldr      x0, [x0, #0x3d8]
006A986FC  bl       #0x382bd14 ; 
006A98700  mov      w8, #1
006A98704  strb     w8, [x21, #0x600]
006A98708  adrp     x8, #0x8f39000
006A9870C  ldr      x8, [x8, #0x3d8]
006A98710  ldr      x2, [x8]
006A98714  ldrb     w8, [x2, #0x53]
006A98718  tbnz     w8, #5, #0x6a98730
006A9871C  mov      x0, x19
006A98720  str      x20, [x0, #0x28]!
006A98724  mov      x1, x20
006A98728  bl       #0x382bcb8 ; 
006A9872C  b        #0x6a98740 ; 
006A98730  ldr      x8, [x2, #0x60]
006A98734  mov      x0, x19
006A98738  mov      x1, x20
006A9873C  blr      x8
006A98740  mov      x0, x19
006A98744  mov      x1, xzr
006A98748  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A9874C  adrp     x21, #0x959e000
006A98750  ldrb     w8, [x21, #0x601]
006A98754  mov      x20, x0
006A98758  cbnz     w8, #0x6a98770
006A9875C  adrp     x0, #0x8f39000
006A98760  ldr      x0, [x0, #0x3e8]
006A98764  bl       #0x382bd14 ; 
006A98768  mov      w8, #1
006A9876C  strb     w8, [x21, #0x601]
006A98770  adrp     x8, #0x8f39000
006A98774  ldr      x8, [x8, #0x3e8]
006A98778  ldr      x2, [x8]
006A9877C  ldrb     w8, [x2, #0x53]
006A98780  tbnz     w8, #5, #0x6a98798
006A98784  mov      x0, x19
006A98788  str      x20, [x0, #0x30]!
006A9878C  mov      x1, x20
006A98790  bl       #0x382bcb8 ; 
006A98794  b        #0x6a987a8 ; 
006A98798  ldr      x8, [x2, #0x60]
006A9879C  mov      x0, x19
006A987A0  mov      x1, x20
006A987A4  blr      x8
006A987A8  mov      x0, x19
006A987AC  mov      x1, xzr
006A987B0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A987B4  adrp     x21, #0x959e000
006A987B8  ldrb     w8, [x21, #0x602]
006A987BC  mov      x20, x0
006A987C0  cbnz     w8, #0x6a987d8
006A987C4  adrp     x0, #0x8f39000
006A987C8  ldr      x0, [x0, #0x3f8]
006A987CC  bl       #0x382bd14 ; 
006A987D0  mov      w8, #1
006A987D4  strb     w8, [x21, #0x602]
006A987D8  adrp     x8, #0x8f39000
006A987DC  ldr      x8, [x8, #0x3f8]
006A987E0  ldr      x2, [x8]
006A987E4  ldrb     w8, [x2, #0x53]
006A987E8  tbnz     w8, #5, #0x6a98800
006A987EC  str      x20, [x19, #0x38]!
006A987F0  mov      x0, x19
006A987F4  mov      x1, x20
006A987F8  bl       #0x382bcb8 ; 
006A987FC  b        #0x6a98810 ; 
006A98800  ldr      x8, [x2, #0x60]
006A98804  mov      x0, x19
006A98808  mov      x1, x20
006A9880C  blr      x8
006A98810  ldp      x20, x19, [sp, #0x10]
006A98814  mov      w0, #1
006A98818  ldp      x30, x21, [sp], #0x20
006A9881C  ret      

