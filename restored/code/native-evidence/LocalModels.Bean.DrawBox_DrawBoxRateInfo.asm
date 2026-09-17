; LocalModels.Bean.DrawBox_DrawBoxRateInfo$$readImpl
; RVA 0x6A5A5EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5A5EC  stp      x30, x21, [sp, #-0x20]!
006A5A5F0  stp      x20, x19, [sp, #0x10]
006A5A5F4  adrp     x20, #0x959d000
006A5A5F8  adrp     x21, #0x8f36000
006A5A5FC  ldrb     w8, [x20, #0xb57]
006A5A600  ldr      x21, [x21, #0x570]
006A5A604  mov      x19, x0
006A5A608  tbnz     w8, #0, #0x6a5a620
006A5A60C  adrp     x0, #0x8f36000
006A5A610  ldr      x0, [x0, #0x570]
006A5A614  bl       #0x382bd14 ; 
006A5A618  mov      w8, #1
006A5A61C  strb     w8, [x20, #0xb57]
006A5A620  ldr      x1, [x21]
006A5A624  ldrb     w8, [x1, #0x53]
006A5A628  tbnz     w8, #5, #0x6a5a678
006A5A62C  mov      x0, x19
006A5A630  mov      x1, xzr
006A5A634  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5A638  adrp     x21, #0x959e000
006A5A63C  ldrb     w8, [x21, #0x359]
006A5A640  mov      w20, w0
006A5A644  cbnz     w8, #0x6a5a65c
006A5A648  adrp     x0, #0x8f36000
006A5A64C  ldr      x0, [x0, #0x528]
006A5A650  bl       #0x382bd14 ; 
006A5A654  mov      w8, #1
006A5A658  strb     w8, [x21, #0x359]
006A5A65C  adrp     x8, #0x8f36000
006A5A660  ldr      x8, [x8, #0x528]
006A5A664  ldr      x2, [x8]
006A5A668  ldrb     w8, [x2, #0x53]
006A5A66C  tbnz     w8, #5, #0x6a5a68c
006A5A670  str      w20, [x19, #0x20]
006A5A674  b        #0x6a5a69c ; 
006A5A678  ldr      x2, [x1, #0x60]
006A5A67C  mov      x0, x19
006A5A680  ldp      x20, x19, [sp, #0x10]
006A5A684  ldp      x30, x21, [sp], #0x20
006A5A688  br       x2
006A5A68C  ldr      x8, [x2, #0x60]
006A5A690  mov      x0, x19
006A5A694  mov      w1, w20
006A5A698  blr      x8
006A5A69C  mov      x0, x19
006A5A6A0  mov      x1, xzr
006A5A6A4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5A6A8  adrp     x21, #0x959e000
006A5A6AC  ldrb     w8, [x21, #0x35a]
006A5A6B0  mov      x20, x0
006A5A6B4  cbnz     w8, #0x6a5a6cc
006A5A6B8  adrp     x0, #0x8f36000
006A5A6BC  ldr      x0, [x0, #0x538]
006A5A6C0  bl       #0x382bd14 ; 
006A5A6C4  mov      w8, #1
006A5A6C8  strb     w8, [x21, #0x35a]
006A5A6CC  adrp     x8, #0x8f36000
006A5A6D0  ldr      x8, [x8, #0x538]
006A5A6D4  ldr      x2, [x8]
006A5A6D8  ldrb     w8, [x2, #0x53]
006A5A6DC  tbnz     w8, #5, #0x6a5a6f4
006A5A6E0  mov      x0, x19
006A5A6E4  str      x20, [x0, #0x28]!
006A5A6E8  mov      x1, x20
006A5A6EC  bl       #0x382bcb8 ; 
006A5A6F0  b        #0x6a5a704 ; 
006A5A6F4  ldr      x8, [x2, #0x60]
006A5A6F8  mov      x0, x19
006A5A6FC  mov      x1, x20
006A5A700  blr      x8
006A5A704  mov      x0, x19
006A5A708  mov      x1, xzr
006A5A70C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5A710  adrp     x21, #0x959e000
006A5A714  ldrb     w8, [x21, #0x35b]
006A5A718  mov      w20, w0
006A5A71C  cbnz     w8, #0x6a5a734
006A5A720  adrp     x0, #0x8f36000
006A5A724  ldr      x0, [x0, #0x548]
006A5A728  bl       #0x382bd14 ; 
006A5A72C  mov      w8, #1
006A5A730  strb     w8, [x21, #0x35b]
006A5A734  adrp     x8, #0x8f36000
006A5A738  ldr      x8, [x8, #0x548]
006A5A73C  ldr      x2, [x8]
006A5A740  ldrb     w8, [x2, #0x53]
006A5A744  tbnz     w8, #5, #0x6a5a750
006A5A748  str      w20, [x19, #0x30]
006A5A74C  b        #0x6a5a760 ; 
006A5A750  ldr      x8, [x2, #0x60]
006A5A754  mov      x0, x19
006A5A758  mov      w1, w20
006A5A75C  blr      x8
006A5A760  mov      x0, x19
006A5A764  mov      x1, xzr
006A5A768  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5A76C  adrp     x21, #0x959e000
006A5A770  ldrb     w8, [x21, #0x35c]
006A5A774  mov      x20, x0
006A5A778  cbnz     w8, #0x6a5a790
006A5A77C  adrp     x0, #0x8f36000
006A5A780  ldr      x0, [x0, #0x558]
006A5A784  bl       #0x382bd14 ; 
006A5A788  mov      w8, #1
006A5A78C  strb     w8, [x21, #0x35c]
006A5A790  adrp     x8, #0x8f36000
006A5A794  ldr      x8, [x8, #0x558]
006A5A798  ldr      x2, [x8]
006A5A79C  ldrb     w8, [x2, #0x53]
006A5A7A0  tbnz     w8, #5, #0x6a5a7b8
006A5A7A4  mov      x0, x19
006A5A7A8  str      x20, [x0, #0x38]!
006A5A7AC  mov      x1, x20
006A5A7B0  bl       #0x382bcb8 ; 
006A5A7B4  b        #0x6a5a7c8 ; 
006A5A7B8  ldr      x8, [x2, #0x60]
006A5A7BC  mov      x0, x19
006A5A7C0  mov      x1, x20
006A5A7C4  blr      x8
006A5A7C8  mov      x0, x19
006A5A7CC  mov      x1, xzr
006A5A7D0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A5A7D4  adrp     x21, #0x959e000
006A5A7D8  ldrb     w8, [x21, #0x35d]
006A5A7DC  mov      x20, x0
006A5A7E0  cbnz     w8, #0x6a5a7f8
006A5A7E4  adrp     x0, #0x8f36000
006A5A7E8  ldr      x0, [x0, #0x568]
006A5A7EC  bl       #0x382bd14 ; 
006A5A7F0  mov      w8, #1
006A5A7F4  strb     w8, [x21, #0x35d]
006A5A7F8  adrp     x8, #0x8f36000
006A5A7FC  ldr      x8, [x8, #0x568]
006A5A800  ldr      x2, [x8]
006A5A804  ldrb     w8, [x2, #0x53]
006A5A808  tbnz     w8, #5, #0x6a5a820
006A5A80C  str      x20, [x19, #0x40]!
006A5A810  mov      x0, x19
006A5A814  mov      x1, x20
006A5A818  bl       #0x382bcb8 ; 
006A5A81C  b        #0x6a5a830 ; 
006A5A820  ldr      x8, [x2, #0x60]
006A5A824  mov      x0, x19
006A5A828  mov      x1, x20
006A5A82C  blr      x8
006A5A830  ldp      x20, x19, [sp, #0x10]
006A5A834  mov      w0, #1
006A5A838  ldp      x30, x21, [sp], #0x20
006A5A83C  ret      

