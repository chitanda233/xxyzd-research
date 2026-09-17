; LocalModels.Bean.GameConfig_Config$$readImpl
; RVA 0x6A7E494; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7E494  str      d8, [sp, #-0x30]!
006A7E498  stp      x30, x21, [sp, #0x10]
006A7E49C  stp      x20, x19, [sp, #0x20]
006A7E4A0  adrp     x20, #0x959d000
006A7E4A4  adrp     x21, #0x8f38000
006A7E4A8  ldrb     w8, [x20, #0xf0d]
006A7E4AC  ldr      x21, [x21, #0x70]
006A7E4B0  mov      x19, x0
006A7E4B4  tbnz     w8, #0, #0x6a7e4cc
006A7E4B8  adrp     x0, #0x8f38000
006A7E4BC  ldr      x0, [x0, #0x70]
006A7E4C0  bl       #0x382bd14 ; 
006A7E4C4  mov      w8, #1
006A7E4C8  strb     w8, [x20, #0xf0d]
006A7E4CC  ldr      x1, [x21]
006A7E4D0  ldrb     w8, [x1, #0x53]
006A7E4D4  tbnz     w8, #5, #0x6a7e530
006A7E4D8  mov      x0, x19
006A7E4DC  mov      x1, xzr
006A7E4E0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7E4E4  adrp     x21, #0x959e000
006A7E4E8  ldrb     w8, [x21, #0x4e6]
006A7E4EC  mov      x20, x0
006A7E4F0  cbnz     w8, #0x6a7e508
006A7E4F4  adrp     x0, #0x8f37000
006A7E4F8  ldr      x0, [x0, #0xff8]
006A7E4FC  bl       #0x382bd14 ; 
006A7E500  mov      w8, #1
006A7E504  strb     w8, [x21, #0x4e6]
006A7E508  adrp     x8, #0x8f37000
006A7E50C  ldr      x8, [x8, #0xff8]
006A7E510  ldr      x2, [x8]
006A7E514  ldrb     w8, [x2, #0x53]
006A7E518  tbnz     w8, #5, #0x6a7e548
006A7E51C  mov      x0, x19
006A7E520  str      x20, [x0, #0x20]!
006A7E524  mov      x1, x20
006A7E528  bl       #0x382bcb8 ; 
006A7E52C  b        #0x6a7e558 ; 
006A7E530  ldr      x2, [x1, #0x60]
006A7E534  mov      x0, x19
006A7E538  ldp      x20, x19, [sp, #0x20]
006A7E53C  ldp      x30, x21, [sp, #0x10]
006A7E540  ldr      d8, [sp], #0x30
006A7E544  br       x2
006A7E548  ldr      x8, [x2, #0x60]
006A7E54C  mov      x0, x19
006A7E550  mov      x1, x20
006A7E554  blr      x8
006A7E558  mov      x0, x19
006A7E55C  mov      x1, xzr
006A7E560  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7E564  adrp     x21, #0x959e000
006A7E568  ldrb     w8, [x21, #0x4e7]
006A7E56C  mov      x20, x0
006A7E570  cbnz     w8, #0x6a7e588
006A7E574  adrp     x0, #0x8f38000
006A7E578  ldr      x0, [x0, #8]
006A7E57C  bl       #0x382bd14 ; 
006A7E580  mov      w8, #1
006A7E584  strb     w8, [x21, #0x4e7]
006A7E588  adrp     x8, #0x8f38000
006A7E58C  ldr      x8, [x8, #8]
006A7E590  ldr      x2, [x8]
006A7E594  ldrb     w8, [x2, #0x53]
006A7E598  tbnz     w8, #5, #0x6a7e5b0
006A7E59C  mov      x0, x19
006A7E5A0  str      x20, [x0, #0x28]!
006A7E5A4  mov      x1, x20
006A7E5A8  bl       #0x382bcb8 ; 
006A7E5AC  b        #0x6a7e5c0 ; 
006A7E5B0  ldr      x8, [x2, #0x60]
006A7E5B4  mov      x0, x19
006A7E5B8  mov      x1, x20
006A7E5BC  blr      x8
006A7E5C0  mov      x0, x19
006A7E5C4  mov      x1, xzr
006A7E5C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7E5CC  adrp     x21, #0x959e000
006A7E5D0  ldrb     w8, [x21, #0x4e8]
006A7E5D4  mov      w20, w0
006A7E5D8  cbnz     w8, #0x6a7e5f0
006A7E5DC  adrp     x0, #0x8f38000
006A7E5E0  ldr      x0, [x0, #0x18]
006A7E5E4  bl       #0x382bd14 ; 
006A7E5E8  mov      w8, #1
006A7E5EC  strb     w8, [x21, #0x4e8]
006A7E5F0  adrp     x8, #0x8f38000
006A7E5F4  ldr      x8, [x8, #0x18]
006A7E5F8  ldr      x2, [x8]
006A7E5FC  ldrb     w8, [x2, #0x53]
006A7E600  tbnz     w8, #5, #0x6a7e60c
006A7E604  str      w20, [x19, #0x30]
006A7E608  b        #0x6a7e61c ; 
006A7E60C  ldr      x8, [x2, #0x60]
006A7E610  mov      x0, x19
006A7E614  mov      w1, w20
006A7E618  blr      x8
006A7E61C  mov      x0, x19
006A7E620  mov      x1, xzr
006A7E624  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A7E628  adrp     x21, #0x959e000
006A7E62C  ldrb     w8, [x21, #0x4e9]
006A7E630  mov      x20, x0
006A7E634  cbnz     w8, #0x6a7e64c
006A7E638  adrp     x0, #0x8f38000
006A7E63C  ldr      x0, [x0, #0x28]
006A7E640  bl       #0x382bd14 ; 
006A7E644  mov      w8, #1
006A7E648  strb     w8, [x21, #0x4e9]
006A7E64C  adrp     x8, #0x8f38000
006A7E650  ldr      x8, [x8, #0x28]
006A7E654  ldr      x2, [x8]
006A7E658  ldrb     w8, [x2, #0x53]
006A7E65C  tbnz     w8, #5, #0x6a7e674
006A7E660  mov      x0, x19
006A7E664  str      x20, [x0, #0x38]!
006A7E668  mov      x1, x20
006A7E66C  bl       #0x382bcb8 ; 
006A7E670  b        #0x6a7e684 ; 
006A7E674  ldr      x8, [x2, #0x60]
006A7E678  mov      x0, x19
006A7E67C  mov      x1, x20
006A7E680  blr      x8
006A7E684  mov      x0, x19
006A7E688  mov      x1, xzr
006A7E68C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7E690  adrp     x21, #0x959e000
006A7E694  ldrb     w8, [x21, #0x4ea]
006A7E698  mov      x20, x0
006A7E69C  cbnz     w8, #0x6a7e6b4
006A7E6A0  adrp     x0, #0x8f38000
006A7E6A4  ldr      x0, [x0, #0x38]
006A7E6A8  bl       #0x382bd14 ; 
006A7E6AC  mov      w8, #1
006A7E6B0  strb     w8, [x21, #0x4ea]
006A7E6B4  adrp     x8, #0x8f38000
006A7E6B8  ldr      x8, [x8, #0x38]
006A7E6BC  ldr      x2, [x8]
006A7E6C0  ldrb     w8, [x2, #0x53]
006A7E6C4  tbnz     w8, #5, #0x6a7e6dc
006A7E6C8  mov      x0, x19
006A7E6CC  str      x20, [x0, #0x40]!
006A7E6D0  mov      x1, x20
006A7E6D4  bl       #0x382bcb8 ; 
006A7E6D8  b        #0x6a7e6ec ; 
006A7E6DC  ldr      x8, [x2, #0x60]
006A7E6E0  mov      x0, x19
006A7E6E4  mov      x1, x20
006A7E6E8  blr      x8
006A7E6EC  mov      x0, x19
006A7E6F0  mov      x1, xzr
006A7E6F4  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006A7E6F8  adrp     x20, #0x959e000
006A7E6FC  ldrb     w8, [x20, #0x4eb]
006A7E700  mov      v8.16b, v0.16b
006A7E704  cbnz     w8, #0x6a7e71c
006A7E708  adrp     x0, #0x8f38000
006A7E70C  ldr      x0, [x0, #0x48]
006A7E710  bl       #0x382bd14 ; 
006A7E714  mov      w8, #1
006A7E718  strb     w8, [x20, #0x4eb]
006A7E71C  adrp     x8, #0x8f38000
006A7E720  ldr      x8, [x8, #0x48]
006A7E724  ldr      x1, [x8]
006A7E728  ldrb     w8, [x1, #0x53]
006A7E72C  tbnz     w8, #5, #0x6a7e738
006A7E730  str      s8, [x19, #0x48]
006A7E734  b        #0x6a7e748 ; 
006A7E738  ldr      x8, [x1, #0x60]
006A7E73C  mov      x0, x19
006A7E740  mov      v0.16b, v8.16b
006A7E744  blr      x8
006A7E748  mov      x0, x19
006A7E74C  mov      x1, xzr
006A7E750  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
006A7E754  adrp     x21, #0x959e000
006A7E758  ldrb     w8, [x21, #0x4ec]
006A7E75C  mov      x20, x0
006A7E760  cbnz     w8, #0x6a7e778
006A7E764  adrp     x0, #0x8f38000
006A7E768  ldr      x0, [x0, #0x58]
006A7E76C  bl       #0x382bd14 ; 
006A7E770  mov      w8, #1
006A7E774  strb     w8, [x21, #0x4ec]
006A7E778  adrp     x8, #0x8f38000
006A7E77C  ldr      x8, [x8, #0x58]
006A7E780  ldr      x2, [x8]
006A7E784  ldrb     w8, [x2, #0x53]
006A7E788  tbnz     w8, #5, #0x6a7e7a0
006A7E78C  mov      x0, x19
006A7E790  str      x20, [x0, #0x50]!
006A7E794  mov      x1, x20
006A7E798  bl       #0x382bcb8 ; 
006A7E79C  b        #0x6a7e7b0 ; 
006A7E7A0  ldr      x8, [x2, #0x60]
006A7E7A4  mov      x0, x19
006A7E7A8  mov      x1, x20
006A7E7AC  blr      x8
006A7E7B0  mov      x0, x19
006A7E7B4  mov      x1, xzr
006A7E7B8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A7E7BC  adrp     x21, #0x959e000
006A7E7C0  ldrb     w8, [x21, #0x4ed]
006A7E7C4  mov      x20, x0
006A7E7C8  cbnz     w8, #0x6a7e7e0
006A7E7CC  adrp     x0, #0x8f38000
006A7E7D0  ldr      x0, [x0, #0x68]
006A7E7D4  bl       #0x382bd14 ; 
006A7E7D8  mov      w8, #1
006A7E7DC  strb     w8, [x21, #0x4ed]
006A7E7E0  adrp     x8, #0x8f38000
006A7E7E4  ldr      x8, [x8, #0x68]
006A7E7E8  ldr      x2, [x8]
006A7E7EC  ldrb     w8, [x2, #0x53]
006A7E7F0  tbnz     w8, #5, #0x6a7e808
006A7E7F4  str      x20, [x19, #0x58]!
006A7E7F8  mov      x0, x19
006A7E7FC  mov      x1, x20
006A7E800  bl       #0x382bcb8 ; 
006A7E804  b        #0x6a7e818 ; 
006A7E808  ldr      x8, [x2, #0x60]
006A7E80C  mov      x0, x19
006A7E810  mov      x1, x20
006A7E814  blr      x8
006A7E818  ldp      x20, x19, [sp, #0x20]
006A7E81C  ldp      x30, x21, [sp, #0x10]
006A7E820  mov      w0, #1
006A7E824  ldr      d8, [sp], #0x30
006A7E828  ret      

