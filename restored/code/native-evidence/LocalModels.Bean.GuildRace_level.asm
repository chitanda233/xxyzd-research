; LocalModels.Bean.GuildRace_level$$readImpl
; RVA 0x6A8B468; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8B468  stp      x30, x21, [sp, #-0x20]!
006A8B46C  stp      x20, x19, [sp, #0x10]
006A8B470  adrp     x20, #0x959e000
006A8B474  adrp     x21, #0x8f38000
006A8B478  ldrb     w8, [x20, #0x6e]
006A8B47C  ldr      x21, [x21, #0xa78]
006A8B480  mov      x19, x0
006A8B484  tbnz     w8, #0, #0x6a8b49c
006A8B488  adrp     x0, #0x8f38000
006A8B48C  ldr      x0, [x0, #0xa78]
006A8B490  bl       #0x382bd14 ; 
006A8B494  mov      w8, #1
006A8B498  strb     w8, [x20, #0x6e]
006A8B49C  ldr      x1, [x21]
006A8B4A0  ldrb     w8, [x1, #0x53]
006A8B4A4  tbnz     w8, #5, #0x6a8b4f4
006A8B4A8  mov      x0, x19
006A8B4AC  mov      x1, xzr
006A8B4B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B4B4  adrp     x21, #0x959e000
006A8B4B8  ldrb     w8, [x21, #0x56b]
006A8B4BC  mov      w20, w0
006A8B4C0  cbnz     w8, #0x6a8b4d8
006A8B4C4  adrp     x0, #0x8f38000
006A8B4C8  ldr      x0, [x0, #0x9b8]
006A8B4CC  bl       #0x382bd14 ; 
006A8B4D0  mov      w8, #1
006A8B4D4  strb     w8, [x21, #0x56b]
006A8B4D8  adrp     x8, #0x8f38000
006A8B4DC  ldr      x8, [x8, #0x9b8]
006A8B4E0  ldr      x2, [x8]
006A8B4E4  ldrb     w8, [x2, #0x53]
006A8B4E8  tbnz     w8, #5, #0x6a8b508
006A8B4EC  str      w20, [x19, #0x20]
006A8B4F0  b        #0x6a8b518 ; 
006A8B4F4  ldr      x2, [x1, #0x60]
006A8B4F8  mov      x0, x19
006A8B4FC  ldp      x20, x19, [sp, #0x10]
006A8B500  ldp      x30, x21, [sp], #0x20
006A8B504  br       x2
006A8B508  ldr      x8, [x2, #0x60]
006A8B50C  mov      x0, x19
006A8B510  mov      w1, w20
006A8B514  blr      x8
006A8B518  mov      x0, x19
006A8B51C  mov      x1, xzr
006A8B520  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B524  adrp     x21, #0x959e000
006A8B528  ldrb     w8, [x21, #0x56c]
006A8B52C  mov      w20, w0
006A8B530  cbnz     w8, #0x6a8b548
006A8B534  adrp     x0, #0x8f38000
006A8B538  ldr      x0, [x0, #0x9c8]
006A8B53C  bl       #0x382bd14 ; 
006A8B540  mov      w8, #1
006A8B544  strb     w8, [x21, #0x56c]
006A8B548  adrp     x8, #0x8f38000
006A8B54C  ldr      x8, [x8, #0x9c8]
006A8B550  ldr      x2, [x8]
006A8B554  ldrb     w8, [x2, #0x53]
006A8B558  tbnz     w8, #5, #0x6a8b564
006A8B55C  str      w20, [x19, #0x24]
006A8B560  b        #0x6a8b574 ; 
006A8B564  ldr      x8, [x2, #0x60]
006A8B568  mov      x0, x19
006A8B56C  mov      w1, w20
006A8B570  blr      x8
006A8B574  mov      x0, x19
006A8B578  mov      x1, xzr
006A8B57C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B580  adrp     x21, #0x959e000
006A8B584  ldrb     w8, [x21, #0x56d]
006A8B588  mov      w20, w0
006A8B58C  cbnz     w8, #0x6a8b5a4
006A8B590  adrp     x0, #0x8f38000
006A8B594  ldr      x0, [x0, #0x9d8]
006A8B598  bl       #0x382bd14 ; 
006A8B59C  mov      w8, #1
006A8B5A0  strb     w8, [x21, #0x56d]
006A8B5A4  adrp     x8, #0x8f38000
006A8B5A8  ldr      x8, [x8, #0x9d8]
006A8B5AC  ldr      x2, [x8]
006A8B5B0  ldrb     w8, [x2, #0x53]
006A8B5B4  tbnz     w8, #5, #0x6a8b5c0
006A8B5B8  str      w20, [x19, #0x28]
006A8B5BC  b        #0x6a8b5d0 ; 
006A8B5C0  ldr      x8, [x2, #0x60]
006A8B5C4  mov      x0, x19
006A8B5C8  mov      w1, w20
006A8B5CC  blr      x8
006A8B5D0  mov      x0, x19
006A8B5D4  mov      x1, xzr
006A8B5D8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8B5DC  adrp     x21, #0x959e000
006A8B5E0  ldrb     w8, [x21, #0x56e]
006A8B5E4  mov      x20, x0
006A8B5E8  cbnz     w8, #0x6a8b600
006A8B5EC  adrp     x0, #0x8f38000
006A8B5F0  ldr      x0, [x0, #0x9e8]
006A8B5F4  bl       #0x382bd14 ; 
006A8B5F8  mov      w8, #1
006A8B5FC  strb     w8, [x21, #0x56e]
006A8B600  adrp     x8, #0x8f38000
006A8B604  ldr      x8, [x8, #0x9e8]
006A8B608  ldr      x2, [x8]
006A8B60C  ldrb     w8, [x2, #0x53]
006A8B610  tbnz     w8, #5, #0x6a8b628
006A8B614  mov      x0, x19
006A8B618  str      x20, [x0, #0x30]!
006A8B61C  mov      x1, x20
006A8B620  bl       #0x382bcb8 ; 
006A8B624  b        #0x6a8b638 ; 
006A8B628  ldr      x8, [x2, #0x60]
006A8B62C  mov      x0, x19
006A8B630  mov      x1, x20
006A8B634  blr      x8
006A8B638  mov      x0, x19
006A8B63C  mov      x1, xzr
006A8B640  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B644  adrp     x21, #0x959e000
006A8B648  ldrb     w8, [x21, #0x56f]
006A8B64C  mov      w20, w0
006A8B650  cbnz     w8, #0x6a8b668
006A8B654  adrp     x0, #0x8f38000
006A8B658  ldr      x0, [x0, #0x9f8]
006A8B65C  bl       #0x382bd14 ; 
006A8B660  mov      w8, #1
006A8B664  strb     w8, [x21, #0x56f]
006A8B668  adrp     x8, #0x8f38000
006A8B66C  ldr      x8, [x8, #0x9f8]
006A8B670  ldr      x2, [x8]
006A8B674  ldrb     w8, [x2, #0x53]
006A8B678  tbnz     w8, #5, #0x6a8b684
006A8B67C  str      w20, [x19, #0x38]
006A8B680  b        #0x6a8b694 ; 
006A8B684  ldr      x8, [x2, #0x60]
006A8B688  mov      x0, x19
006A8B68C  mov      w1, w20
006A8B690  blr      x8
006A8B694  mov      x0, x19
006A8B698  mov      x1, xzr
006A8B69C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B6A0  adrp     x21, #0x959e000
006A8B6A4  ldrb     w8, [x21, #0x570]
006A8B6A8  mov      w20, w0
006A8B6AC  cbnz     w8, #0x6a8b6c4
006A8B6B0  adrp     x0, #0x8f38000
006A8B6B4  ldr      x0, [x0, #0xa08]
006A8B6B8  bl       #0x382bd14 ; 
006A8B6BC  mov      w8, #1
006A8B6C0  strb     w8, [x21, #0x570]
006A8B6C4  adrp     x8, #0x8f38000
006A8B6C8  ldr      x8, [x8, #0xa08]
006A8B6CC  ldr      x2, [x8]
006A8B6D0  ldrb     w8, [x2, #0x53]
006A8B6D4  tbnz     w8, #5, #0x6a8b6e0
006A8B6D8  str      w20, [x19, #0x3c]
006A8B6DC  b        #0x6a8b6f0 ; 
006A8B6E0  ldr      x8, [x2, #0x60]
006A8B6E4  mov      x0, x19
006A8B6E8  mov      w1, w20
006A8B6EC  blr      x8
006A8B6F0  mov      x0, x19
006A8B6F4  mov      x1, xzr
006A8B6F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B6FC  adrp     x21, #0x959e000
006A8B700  ldrb     w8, [x21, #0x571]
006A8B704  mov      w20, w0
006A8B708  cbnz     w8, #0x6a8b720
006A8B70C  adrp     x0, #0x8f38000
006A8B710  ldr      x0, [x0, #0xa18]
006A8B714  bl       #0x382bd14 ; 
006A8B718  mov      w8, #1
006A8B71C  strb     w8, [x21, #0x571]
006A8B720  adrp     x8, #0x8f38000
006A8B724  ldr      x8, [x8, #0xa18]
006A8B728  ldr      x2, [x8]
006A8B72C  ldrb     w8, [x2, #0x53]
006A8B730  tbnz     w8, #5, #0x6a8b73c
006A8B734  str      w20, [x19, #0x40]
006A8B738  b        #0x6a8b74c ; 
006A8B73C  ldr      x8, [x2, #0x60]
006A8B740  mov      x0, x19
006A8B744  mov      w1, w20
006A8B748  blr      x8
006A8B74C  mov      x0, x19
006A8B750  mov      x1, xzr
006A8B754  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B758  adrp     x21, #0x959e000
006A8B75C  ldrb     w8, [x21, #0x572]
006A8B760  mov      w20, w0
006A8B764  cbnz     w8, #0x6a8b77c
006A8B768  adrp     x0, #0x8f38000
006A8B76C  ldr      x0, [x0, #0xa20]
006A8B770  bl       #0x382bd14 ; 
006A8B774  mov      w8, #1
006A8B778  strb     w8, [x21, #0x572]
006A8B77C  adrp     x8, #0x8f38000
006A8B780  ldr      x8, [x8, #0xa20]
006A8B784  ldr      x2, [x8]
006A8B788  ldrb     w8, [x2, #0x53]
006A8B78C  tbnz     w8, #5, #0x6a8b798
006A8B790  str      w20, [x19, #0x44]
006A8B794  b        #0x6a8b7a8 ; 
006A8B798  ldr      x8, [x2, #0x60]
006A8B79C  mov      x0, x19
006A8B7A0  mov      w1, w20
006A8B7A4  blr      x8
006A8B7A8  mov      x0, x19
006A8B7AC  mov      x1, xzr
006A8B7B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B7B4  adrp     x21, #0x959e000
006A8B7B8  ldrb     w8, [x21, #0x573]
006A8B7BC  mov      w20, w0
006A8B7C0  cbnz     w8, #0x6a8b7d8
006A8B7C4  adrp     x0, #0x8f38000
006A8B7C8  ldr      x0, [x0, #0xa28]
006A8B7CC  bl       #0x382bd14 ; 
006A8B7D0  mov      w8, #1
006A8B7D4  strb     w8, [x21, #0x573]
006A8B7D8  adrp     x8, #0x8f38000
006A8B7DC  ldr      x8, [x8, #0xa28]
006A8B7E0  ldr      x2, [x8]
006A8B7E4  ldrb     w8, [x2, #0x53]
006A8B7E8  tbnz     w8, #5, #0x6a8b7f4
006A8B7EC  str      w20, [x19, #0x48]
006A8B7F0  b        #0x6a8b804 ; 
006A8B7F4  ldr      x8, [x2, #0x60]
006A8B7F8  mov      x0, x19
006A8B7FC  mov      w1, w20
006A8B800  blr      x8
006A8B804  mov      x0, x19
006A8B808  mov      x1, xzr
006A8B80C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B810  adrp     x21, #0x959e000
006A8B814  ldrb     w8, [x21, #0x574]
006A8B818  mov      w20, w0
006A8B81C  cbnz     w8, #0x6a8b834
006A8B820  adrp     x0, #0x8f38000
006A8B824  ldr      x0, [x0, #0xa30]
006A8B828  bl       #0x382bd14 ; 
006A8B82C  mov      w8, #1
006A8B830  strb     w8, [x21, #0x574]
006A8B834  adrp     x8, #0x8f38000
006A8B838  ldr      x8, [x8, #0xa30]
006A8B83C  ldr      x2, [x8]
006A8B840  ldrb     w8, [x2, #0x53]
006A8B844  tbnz     w8, #5, #0x6a8b850
006A8B848  str      w20, [x19, #0x4c]
006A8B84C  b        #0x6a8b860 ; 
006A8B850  ldr      x8, [x2, #0x60]
006A8B854  mov      x0, x19
006A8B858  mov      w1, w20
006A8B85C  blr      x8
006A8B860  mov      x0, x19
006A8B864  mov      x1, xzr
006A8B868  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A8B86C  adrp     x21, #0x959e000
006A8B870  ldrb     w8, [x21, #0x575]
006A8B874  mov      x20, x0
006A8B878  cbnz     w8, #0x6a8b890
006A8B87C  adrp     x0, #0x8f38000
006A8B880  ldr      x0, [x0, #0xa40]
006A8B884  bl       #0x382bd14 ; 
006A8B888  mov      w8, #1
006A8B88C  strb     w8, [x21, #0x575]
006A8B890  adrp     x8, #0x8f38000
006A8B894  ldr      x8, [x8, #0xa40]
006A8B898  ldr      x2, [x8]
006A8B89C  ldrb     w8, [x2, #0x53]
006A8B8A0  tbnz     w8, #5, #0x6a8b8b8
006A8B8A4  mov      x0, x19
006A8B8A8  str      x20, [x0, #0x50]!
006A8B8AC  mov      x1, x20
006A8B8B0  bl       #0x382bcb8 ; 
006A8B8B4  b        #0x6a8b8c8 ; 
006A8B8B8  ldr      x8, [x2, #0x60]
006A8B8BC  mov      x0, x19
006A8B8C0  mov      x1, x20
006A8B8C4  blr      x8
006A8B8C8  mov      x0, x19
006A8B8CC  mov      x1, xzr
006A8B8D0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A8B8D4  adrp     x21, #0x959e000
006A8B8D8  ldrb     w8, [x21, #0x576]
006A8B8DC  mov      x20, x0
006A8B8E0  cbnz     w8, #0x6a8b8f8
006A8B8E4  adrp     x0, #0x8f38000
006A8B8E8  ldr      x0, [x0, #0xa50]
006A8B8EC  bl       #0x382bd14 ; 
006A8B8F0  mov      w8, #1
006A8B8F4  strb     w8, [x21, #0x576]
006A8B8F8  adrp     x8, #0x8f38000
006A8B8FC  ldr      x8, [x8, #0xa50]
006A8B900  ldr      x2, [x8]
006A8B904  ldrb     w8, [x2, #0x53]
006A8B908  tbnz     w8, #5, #0x6a8b920
006A8B90C  mov      x0, x19
006A8B910  str      x20, [x0, #0x58]!
006A8B914  mov      x1, x20
006A8B918  bl       #0x382bcb8 ; 
006A8B91C  b        #0x6a8b930 ; 
006A8B920  ldr      x8, [x2, #0x60]
006A8B924  mov      x0, x19
006A8B928  mov      x1, x20
006A8B92C  blr      x8
006A8B930  mov      x0, x19
006A8B934  mov      x1, xzr
006A8B938  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8B93C  adrp     x21, #0x959e000
006A8B940  ldrb     w8, [x21, #0x577]
006A8B944  mov      w20, w0
006A8B948  cbnz     w8, #0x6a8b960
006A8B94C  adrp     x0, #0x8f38000
006A8B950  ldr      x0, [x0, #0xa60]
006A8B954  bl       #0x382bd14 ; 
006A8B958  mov      w8, #1
006A8B95C  strb     w8, [x21, #0x577]
006A8B960  adrp     x8, #0x8f38000
006A8B964  ldr      x8, [x8, #0xa60]
006A8B968  ldr      x2, [x8]
006A8B96C  ldrb     w8, [x2, #0x53]
006A8B970  tbnz     w8, #5, #0x6a8b97c
006A8B974  str      w20, [x19, #0x60]
006A8B978  b        #0x6a8b98c ; 
006A8B97C  ldr      x8, [x2, #0x60]
006A8B980  mov      x0, x19
006A8B984  mov      w1, w20
006A8B988  blr      x8
006A8B98C  mov      x0, x19
006A8B990  mov      x1, xzr
006A8B994  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8B998  adrp     x21, #0x959e000
006A8B99C  ldrb     w8, [x21, #0x578]
006A8B9A0  mov      x20, x0
006A8B9A4  cbnz     w8, #0x6a8b9bc
006A8B9A8  adrp     x0, #0x8f38000
006A8B9AC  ldr      x0, [x0, #0xa70]
006A8B9B0  bl       #0x382bd14 ; 
006A8B9B4  mov      w8, #1
006A8B9B8  strb     w8, [x21, #0x578]
006A8B9BC  adrp     x8, #0x8f38000
006A8B9C0  ldr      x8, [x8, #0xa70]
006A8B9C4  ldr      x2, [x8]
006A8B9C8  ldrb     w8, [x2, #0x53]
006A8B9CC  tbnz     w8, #5, #0x6a8b9e4
006A8B9D0  str      x20, [x19, #0x68]!
006A8B9D4  mov      x0, x19
006A8B9D8  mov      x1, x20
006A8B9DC  bl       #0x382bcb8 ; 
006A8B9E0  b        #0x6a8b9f4 ; 
006A8B9E4  ldr      x8, [x2, #0x60]
006A8B9E8  mov      x0, x19
006A8B9EC  mov      x1, x20
006A8B9F0  blr      x8
006A8B9F4  ldp      x20, x19, [sp, #0x10]
006A8B9F8  mov      w0, #1
006A8B9FC  ldp      x30, x21, [sp], #0x20
006A8BA00  ret      

