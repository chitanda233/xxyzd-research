; LocalModels.Bean.IAP_BattlePass$$readImpl
; RVA 0x6A9B340; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A9B340  stp      x30, x21, [sp, #-0x20]!
006A9B344  stp      x20, x19, [sp, #0x10]
006A9B348  adrp     x20, #0x959e000
006A9B34C  adrp     x21, #0x8f39000
006A9B350  ldrb     w8, [x20, #0x21f]
006A9B354  ldr      x21, [x21, #0x6a0]
006A9B358  mov      x19, x0
006A9B35C  tbnz     w8, #0, #0x6a9b374
006A9B360  adrp     x0, #0x8f39000
006A9B364  ldr      x0, [x0, #0x6a0]
006A9B368  bl       #0x382bd14 ; 
006A9B36C  mov      w8, #1
006A9B370  strb     w8, [x20, #0x21f]
006A9B374  ldr      x1, [x21]
006A9B378  ldrb     w8, [x1, #0x53]
006A9B37C  tbnz     w8, #5, #0x6a9b3cc
006A9B380  mov      x0, x19
006A9B384  mov      x1, xzr
006A9B388  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B38C  adrp     x21, #0x959e000
006A9B390  ldrb     w8, [x21, #0x60f]
006A9B394  mov      w20, w0
006A9B398  cbnz     w8, #0x6a9b3b0
006A9B39C  adrp     x0, #0x8f39000
006A9B3A0  ldr      x0, [x0, #0x508]
006A9B3A4  bl       #0x382bd14 ; 
006A9B3A8  mov      w8, #1
006A9B3AC  strb     w8, [x21, #0x60f]
006A9B3B0  adrp     x8, #0x8f39000
006A9B3B4  ldr      x8, [x8, #0x508]
006A9B3B8  ldr      x2, [x8]
006A9B3BC  ldrb     w8, [x2, #0x53]
006A9B3C0  tbnz     w8, #5, #0x6a9b3e0
006A9B3C4  str      w20, [x19, #0x20]
006A9B3C8  b        #0x6a9b3f0 ; 
006A9B3CC  ldr      x2, [x1, #0x60]
006A9B3D0  mov      x0, x19
006A9B3D4  ldp      x20, x19, [sp, #0x10]
006A9B3D8  ldp      x30, x21, [sp], #0x20
006A9B3DC  br       x2
006A9B3E0  ldr      x8, [x2, #0x60]
006A9B3E4  mov      x0, x19
006A9B3E8  mov      w1, w20
006A9B3EC  blr      x8
006A9B3F0  mov      x0, x19
006A9B3F4  mov      x1, xzr
006A9B3F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B3FC  adrp     x21, #0x959e000
006A9B400  ldrb     w8, [x21, #0x610]
006A9B404  mov      x20, x0
006A9B408  cbnz     w8, #0x6a9b420
006A9B40C  adrp     x0, #0x8f39000
006A9B410  ldr      x0, [x0, #0x518]
006A9B414  bl       #0x382bd14 ; 
006A9B418  mov      w8, #1
006A9B41C  strb     w8, [x21, #0x610]
006A9B420  adrp     x8, #0x8f39000
006A9B424  ldr      x8, [x8, #0x518]
006A9B428  ldr      x2, [x8]
006A9B42C  ldrb     w8, [x2, #0x53]
006A9B430  tbnz     w8, #5, #0x6a9b448
006A9B434  mov      x0, x19
006A9B438  str      x20, [x0, #0x28]!
006A9B43C  mov      x1, x20
006A9B440  bl       #0x382bcb8 ; 
006A9B444  b        #0x6a9b458 ; 
006A9B448  ldr      x8, [x2, #0x60]
006A9B44C  mov      x0, x19
006A9B450  mov      x1, x20
006A9B454  blr      x8
006A9B458  mov      x0, x19
006A9B45C  mov      x1, xzr
006A9B460  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B464  adrp     x21, #0x959e000
006A9B468  ldrb     w8, [x21, #0x611]
006A9B46C  mov      w20, w0
006A9B470  cbnz     w8, #0x6a9b488
006A9B474  adrp     x0, #0x8f39000
006A9B478  ldr      x0, [x0, #0x528]
006A9B47C  bl       #0x382bd14 ; 
006A9B480  mov      w8, #1
006A9B484  strb     w8, [x21, #0x611]
006A9B488  adrp     x8, #0x8f39000
006A9B48C  ldr      x8, [x8, #0x528]
006A9B490  ldr      x2, [x8]
006A9B494  ldrb     w8, [x2, #0x53]
006A9B498  tbnz     w8, #5, #0x6a9b4a4
006A9B49C  str      w20, [x19, #0x30]
006A9B4A0  b        #0x6a9b4b4 ; 
006A9B4A4  ldr      x8, [x2, #0x60]
006A9B4A8  mov      x0, x19
006A9B4AC  mov      w1, w20
006A9B4B0  blr      x8
006A9B4B4  mov      x0, x19
006A9B4B8  mov      x1, xzr
006A9B4BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B4C0  adrp     x21, #0x959e000
006A9B4C4  ldrb     w8, [x21, #0x612]
006A9B4C8  mov      w20, w0
006A9B4CC  cbnz     w8, #0x6a9b4e4
006A9B4D0  adrp     x0, #0x8f39000
006A9B4D4  ldr      x0, [x0, #0x538]
006A9B4D8  bl       #0x382bd14 ; 
006A9B4DC  mov      w8, #1
006A9B4E0  strb     w8, [x21, #0x612]
006A9B4E4  adrp     x8, #0x8f39000
006A9B4E8  ldr      x8, [x8, #0x538]
006A9B4EC  ldr      x2, [x8]
006A9B4F0  ldrb     w8, [x2, #0x53]
006A9B4F4  tbnz     w8, #5, #0x6a9b500
006A9B4F8  str      w20, [x19, #0x34]
006A9B4FC  b        #0x6a9b510 ; 
006A9B500  ldr      x8, [x2, #0x60]
006A9B504  mov      x0, x19
006A9B508  mov      w1, w20
006A9B50C  blr      x8
006A9B510  mov      x0, x19
006A9B514  mov      x1, xzr
006A9B518  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B51C  adrp     x21, #0x959e000
006A9B520  ldrb     w8, [x21, #0x613]
006A9B524  mov      x20, x0
006A9B528  cbnz     w8, #0x6a9b540
006A9B52C  adrp     x0, #0x8f39000
006A9B530  ldr      x0, [x0, #0x548]
006A9B534  bl       #0x382bd14 ; 
006A9B538  mov      w8, #1
006A9B53C  strb     w8, [x21, #0x613]
006A9B540  adrp     x8, #0x8f39000
006A9B544  ldr      x8, [x8, #0x548]
006A9B548  ldr      x2, [x8]
006A9B54C  ldrb     w8, [x2, #0x53]
006A9B550  tbnz     w8, #5, #0x6a9b568
006A9B554  mov      x0, x19
006A9B558  str      x20, [x0, #0x38]!
006A9B55C  mov      x1, x20
006A9B560  bl       #0x382bcb8 ; 
006A9B564  b        #0x6a9b578 ; 
006A9B568  ldr      x8, [x2, #0x60]
006A9B56C  mov      x0, x19
006A9B570  mov      x1, x20
006A9B574  blr      x8
006A9B578  mov      x0, x19
006A9B57C  mov      x1, xzr
006A9B580  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B584  adrp     x21, #0x959e000
006A9B588  ldrb     w8, [x21, #0x614]
006A9B58C  mov      x20, x0
006A9B590  cbnz     w8, #0x6a9b5a8
006A9B594  adrp     x0, #0x8f39000
006A9B598  ldr      x0, [x0, #0x558]
006A9B59C  bl       #0x382bd14 ; 
006A9B5A0  mov      w8, #1
006A9B5A4  strb     w8, [x21, #0x614]
006A9B5A8  adrp     x8, #0x8f39000
006A9B5AC  ldr      x8, [x8, #0x558]
006A9B5B0  ldr      x2, [x8]
006A9B5B4  ldrb     w8, [x2, #0x53]
006A9B5B8  tbnz     w8, #5, #0x6a9b5d0
006A9B5BC  mov      x0, x19
006A9B5C0  str      x20, [x0, #0x40]!
006A9B5C4  mov      x1, x20
006A9B5C8  bl       #0x382bcb8 ; 
006A9B5CC  b        #0x6a9b5e0 ; 
006A9B5D0  ldr      x8, [x2, #0x60]
006A9B5D4  mov      x0, x19
006A9B5D8  mov      x1, x20
006A9B5DC  blr      x8
006A9B5E0  mov      x0, x19
006A9B5E4  mov      x1, xzr
006A9B5E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B5EC  adrp     x21, #0x959e000
006A9B5F0  ldrb     w8, [x21, #0x615]
006A9B5F4  mov      w20, w0
006A9B5F8  cbnz     w8, #0x6a9b610
006A9B5FC  adrp     x0, #0x8f39000
006A9B600  ldr      x0, [x0, #0x568]
006A9B604  bl       #0x382bd14 ; 
006A9B608  mov      w8, #1
006A9B60C  strb     w8, [x21, #0x615]
006A9B610  adrp     x8, #0x8f39000
006A9B614  ldr      x8, [x8, #0x568]
006A9B618  ldr      x2, [x8]
006A9B61C  ldrb     w8, [x2, #0x53]
006A9B620  tbnz     w8, #5, #0x6a9b62c
006A9B624  str      w20, [x19, #0x48]
006A9B628  b        #0x6a9b63c ; 
006A9B62C  ldr      x8, [x2, #0x60]
006A9B630  mov      x0, x19
006A9B634  mov      w1, w20
006A9B638  blr      x8
006A9B63C  mov      x0, x19
006A9B640  mov      x1, xzr
006A9B644  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B648  adrp     x21, #0x959e000
006A9B64C  ldrb     w8, [x21, #0x616]
006A9B650  mov      x20, x0
006A9B654  cbnz     w8, #0x6a9b66c
006A9B658  adrp     x0, #0x8f39000
006A9B65C  ldr      x0, [x0, #0x578]
006A9B660  bl       #0x382bd14 ; 
006A9B664  mov      w8, #1
006A9B668  strb     w8, [x21, #0x616]
006A9B66C  adrp     x8, #0x8f39000
006A9B670  ldr      x8, [x8, #0x578]
006A9B674  ldr      x2, [x8]
006A9B678  ldrb     w8, [x2, #0x53]
006A9B67C  tbnz     w8, #5, #0x6a9b694
006A9B680  mov      x0, x19
006A9B684  str      x20, [x0, #0x50]!
006A9B688  mov      x1, x20
006A9B68C  bl       #0x382bcb8 ; 
006A9B690  b        #0x6a9b6a4 ; 
006A9B694  ldr      x8, [x2, #0x60]
006A9B698  mov      x0, x19
006A9B69C  mov      x1, x20
006A9B6A0  blr      x8
006A9B6A4  mov      x0, x19
006A9B6A8  mov      x1, xzr
006A9B6AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B6B0  adrp     x21, #0x959e000
006A9B6B4  ldrb     w8, [x21, #0x617]
006A9B6B8  mov      x20, x0
006A9B6BC  cbnz     w8, #0x6a9b6d4
006A9B6C0  adrp     x0, #0x8f39000
006A9B6C4  ldr      x0, [x0, #0x588]
006A9B6C8  bl       #0x382bd14 ; 
006A9B6CC  mov      w8, #1
006A9B6D0  strb     w8, [x21, #0x617]
006A9B6D4  adrp     x8, #0x8f39000
006A9B6D8  ldr      x8, [x8, #0x588]
006A9B6DC  ldr      x2, [x8]
006A9B6E0  ldrb     w8, [x2, #0x53]
006A9B6E4  tbnz     w8, #5, #0x6a9b6fc
006A9B6E8  mov      x0, x19
006A9B6EC  str      x20, [x0, #0x58]!
006A9B6F0  mov      x1, x20
006A9B6F4  bl       #0x382bcb8 ; 
006A9B6F8  b        #0x6a9b70c ; 
006A9B6FC  ldr      x8, [x2, #0x60]
006A9B700  mov      x0, x19
006A9B704  mov      x1, x20
006A9B708  blr      x8
006A9B70C  mov      x0, x19
006A9B710  mov      x1, xzr
006A9B714  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B718  adrp     x21, #0x959e000
006A9B71C  ldrb     w8, [x21, #0x618]
006A9B720  mov      x20, x0
006A9B724  cbnz     w8, #0x6a9b73c
006A9B728  adrp     x0, #0x8f39000
006A9B72C  ldr      x0, [x0, #0x598]
006A9B730  bl       #0x382bd14 ; 
006A9B734  mov      w8, #1
006A9B738  strb     w8, [x21, #0x618]
006A9B73C  adrp     x8, #0x8f39000
006A9B740  ldr      x8, [x8, #0x598]
006A9B744  ldr      x2, [x8]
006A9B748  ldrb     w8, [x2, #0x53]
006A9B74C  tbnz     w8, #5, #0x6a9b764
006A9B750  mov      x0, x19
006A9B754  str      x20, [x0, #0x60]!
006A9B758  mov      x1, x20
006A9B75C  bl       #0x382bcb8 ; 
006A9B760  b        #0x6a9b774 ; 
006A9B764  ldr      x8, [x2, #0x60]
006A9B768  mov      x0, x19
006A9B76C  mov      x1, x20
006A9B770  blr      x8
006A9B774  mov      x0, x19
006A9B778  mov      x1, xzr
006A9B77C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B780  adrp     x21, #0x959e000
006A9B784  ldrb     w8, [x21, #0x619]
006A9B788  mov      x20, x0
006A9B78C  cbnz     w8, #0x6a9b7a4
006A9B790  adrp     x0, #0x8f39000
006A9B794  ldr      x0, [x0, #0x5a8]
006A9B798  bl       #0x382bd14 ; 
006A9B79C  mov      w8, #1
006A9B7A0  strb     w8, [x21, #0x619]
006A9B7A4  adrp     x8, #0x8f39000
006A9B7A8  ldr      x8, [x8, #0x5a8]
006A9B7AC  ldr      x2, [x8]
006A9B7B0  ldrb     w8, [x2, #0x53]
006A9B7B4  tbnz     w8, #5, #0x6a9b7cc
006A9B7B8  mov      x0, x19
006A9B7BC  str      x20, [x0, #0x68]!
006A9B7C0  mov      x1, x20
006A9B7C4  bl       #0x382bcb8 ; 
006A9B7C8  b        #0x6a9b7dc ; 
006A9B7CC  ldr      x8, [x2, #0x60]
006A9B7D0  mov      x0, x19
006A9B7D4  mov      x1, x20
006A9B7D8  blr      x8
006A9B7DC  mov      x0, x19
006A9B7E0  mov      x1, xzr
006A9B7E4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B7E8  adrp     x21, #0x959e000
006A9B7EC  ldrb     w8, [x21, #0x61a]
006A9B7F0  mov      x20, x0
006A9B7F4  cbnz     w8, #0x6a9b80c
006A9B7F8  adrp     x0, #0x8f39000
006A9B7FC  ldr      x0, [x0, #0x5b8]
006A9B800  bl       #0x382bd14 ; 
006A9B804  mov      w8, #1
006A9B808  strb     w8, [x21, #0x61a]
006A9B80C  adrp     x8, #0x8f39000
006A9B810  ldr      x8, [x8, #0x5b8]
006A9B814  ldr      x2, [x8]
006A9B818  ldrb     w8, [x2, #0x53]
006A9B81C  tbnz     w8, #5, #0x6a9b834
006A9B820  mov      x0, x19
006A9B824  str      x20, [x0, #0x70]!
006A9B828  mov      x1, x20
006A9B82C  bl       #0x382bcb8 ; 
006A9B830  b        #0x6a9b844 ; 
006A9B834  ldr      x8, [x2, #0x60]
006A9B838  mov      x0, x19
006A9B83C  mov      x1, x20
006A9B840  blr      x8
006A9B844  mov      x0, x19
006A9B848  mov      x1, xzr
006A9B84C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9B850  adrp     x21, #0x959e000
006A9B854  ldrb     w8, [x21, #0x61b]
006A9B858  mov      x20, x0
006A9B85C  cbnz     w8, #0x6a9b874
006A9B860  adrp     x0, #0x8f39000
006A9B864  ldr      x0, [x0, #0x5c8]
006A9B868  bl       #0x382bd14 ; 
006A9B86C  mov      w8, #1
006A9B870  strb     w8, [x21, #0x61b]
006A9B874  adrp     x8, #0x8f39000
006A9B878  ldr      x8, [x8, #0x5c8]
006A9B87C  ldr      x2, [x8]
006A9B880  ldrb     w8, [x2, #0x53]
006A9B884  tbnz     w8, #5, #0x6a9b89c
006A9B888  mov      x0, x19
006A9B88C  str      x20, [x0, #0x78]!
006A9B890  mov      x1, x20
006A9B894  bl       #0x382bcb8 ; 
006A9B898  b        #0x6a9b8ac ; 
006A9B89C  ldr      x8, [x2, #0x60]
006A9B8A0  mov      x0, x19
006A9B8A4  mov      x1, x20
006A9B8A8  blr      x8
006A9B8AC  mov      x0, x19
006A9B8B0  mov      x1, xzr
006A9B8B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B8B8  adrp     x21, #0x959e000
006A9B8BC  ldrb     w8, [x21, #0x61c]
006A9B8C0  mov      w20, w0
006A9B8C4  cbnz     w8, #0x6a9b8dc
006A9B8C8  adrp     x0, #0x8f39000
006A9B8CC  ldr      x0, [x0, #0x5d8]
006A9B8D0  bl       #0x382bd14 ; 
006A9B8D4  mov      w8, #1
006A9B8D8  strb     w8, [x21, #0x61c]
006A9B8DC  adrp     x8, #0x8f39000
006A9B8E0  ldr      x8, [x8, #0x5d8]
006A9B8E4  ldr      x2, [x8]
006A9B8E8  ldrb     w8, [x2, #0x53]
006A9B8EC  tbnz     w8, #5, #0x6a9b8f8
006A9B8F0  str      w20, [x19, #0x80]
006A9B8F4  b        #0x6a9b908 ; 
006A9B8F8  ldr      x8, [x2, #0x60]
006A9B8FC  mov      x0, x19
006A9B900  mov      w1, w20
006A9B904  blr      x8
006A9B908  mov      x0, x19
006A9B90C  mov      x1, xzr
006A9B910  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B914  adrp     x21, #0x959e000
006A9B918  ldrb     w8, [x21, #0x61d]
006A9B91C  mov      w20, w0
006A9B920  cbnz     w8, #0x6a9b938
006A9B924  adrp     x0, #0x8f39000
006A9B928  ldr      x0, [x0, #0x5e8]
006A9B92C  bl       #0x382bd14 ; 
006A9B930  mov      w8, #1
006A9B934  strb     w8, [x21, #0x61d]
006A9B938  adrp     x8, #0x8f39000
006A9B93C  ldr      x8, [x8, #0x5e8]
006A9B940  ldr      x2, [x8]
006A9B944  ldrb     w8, [x2, #0x53]
006A9B948  tbnz     w8, #5, #0x6a9b954
006A9B94C  str      w20, [x19, #0x84]
006A9B950  b        #0x6a9b964 ; 
006A9B954  ldr      x8, [x2, #0x60]
006A9B958  mov      x0, x19
006A9B95C  mov      w1, w20
006A9B960  blr      x8
006A9B964  mov      x0, x19
006A9B968  mov      x1, xzr
006A9B96C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B970  adrp     x21, #0x959e000
006A9B974  ldrb     w8, [x21, #0x61e]
006A9B978  mov      w20, w0
006A9B97C  cbnz     w8, #0x6a9b994
006A9B980  adrp     x0, #0x8f39000
006A9B984  ldr      x0, [x0, #0x5f8]
006A9B988  bl       #0x382bd14 ; 
006A9B98C  mov      w8, #1
006A9B990  strb     w8, [x21, #0x61e]
006A9B994  adrp     x8, #0x8f39000
006A9B998  ldr      x8, [x8, #0x5f8]
006A9B99C  ldr      x2, [x8]
006A9B9A0  ldrb     w8, [x2, #0x53]
006A9B9A4  tbnz     w8, #5, #0x6a9b9b0
006A9B9A8  str      w20, [x19, #0x88]
006A9B9AC  b        #0x6a9b9c0 ; 
006A9B9B0  ldr      x8, [x2, #0x60]
006A9B9B4  mov      x0, x19
006A9B9B8  mov      w1, w20
006A9B9BC  blr      x8
006A9B9C0  mov      x0, x19
006A9B9C4  mov      x1, xzr
006A9B9C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9B9CC  adrp     x21, #0x959e000
006A9B9D0  ldrb     w8, [x21, #0x61f]
006A9B9D4  mov      w20, w0
006A9B9D8  cbnz     w8, #0x6a9b9f0
006A9B9DC  adrp     x0, #0x8f39000
006A9B9E0  ldr      x0, [x0, #0x608]
006A9B9E4  bl       #0x382bd14 ; 
006A9B9E8  mov      w8, #1
006A9B9EC  strb     w8, [x21, #0x61f]
006A9B9F0  adrp     x8, #0x8f39000
006A9B9F4  ldr      x8, [x8, #0x608]
006A9B9F8  ldr      x2, [x8]
006A9B9FC  ldrb     w8, [x2, #0x53]
006A9BA00  tbnz     w8, #5, #0x6a9ba0c
006A9BA04  str      w20, [x19, #0x8c]
006A9BA08  b        #0x6a9ba1c ; 
006A9BA0C  ldr      x8, [x2, #0x60]
006A9BA10  mov      x0, x19
006A9BA14  mov      w1, w20
006A9BA18  blr      x8
006A9BA1C  mov      x0, x19
006A9BA20  mov      x1, xzr
006A9BA24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BA28  adrp     x21, #0x959e000
006A9BA2C  ldrb     w8, [x21, #0x620]
006A9BA30  mov      w20, w0
006A9BA34  cbnz     w8, #0x6a9ba4c
006A9BA38  adrp     x0, #0x8f39000
006A9BA3C  ldr      x0, [x0, #0x618]
006A9BA40  bl       #0x382bd14 ; 
006A9BA44  mov      w8, #1
006A9BA48  strb     w8, [x21, #0x620]
006A9BA4C  adrp     x8, #0x8f39000
006A9BA50  ldr      x8, [x8, #0x618]
006A9BA54  ldr      x2, [x8]
006A9BA58  ldrb     w8, [x2, #0x53]
006A9BA5C  tbnz     w8, #5, #0x6a9ba68
006A9BA60  str      w20, [x19, #0x90]
006A9BA64  b        #0x6a9ba78 ; 
006A9BA68  ldr      x8, [x2, #0x60]
006A9BA6C  mov      x0, x19
006A9BA70  mov      w1, w20
006A9BA74  blr      x8
006A9BA78  mov      x0, x19
006A9BA7C  mov      x1, xzr
006A9BA80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BA84  adrp     x21, #0x959e000
006A9BA88  ldrb     w8, [x21, #0x621]
006A9BA8C  mov      w20, w0
006A9BA90  cbnz     w8, #0x6a9baa8
006A9BA94  adrp     x0, #0x8f39000
006A9BA98  ldr      x0, [x0, #0x628]
006A9BA9C  bl       #0x382bd14 ; 
006A9BAA0  mov      w8, #1
006A9BAA4  strb     w8, [x21, #0x621]
006A9BAA8  adrp     x8, #0x8f39000
006A9BAAC  ldr      x8, [x8, #0x628]
006A9BAB0  ldr      x2, [x8]
006A9BAB4  ldrb     w8, [x2, #0x53]
006A9BAB8  tbnz     w8, #5, #0x6a9bac4
006A9BABC  str      w20, [x19, #0x94]
006A9BAC0  b        #0x6a9bad4 ; 
006A9BAC4  ldr      x8, [x2, #0x60]
006A9BAC8  mov      x0, x19
006A9BACC  mov      w1, w20
006A9BAD0  blr      x8
006A9BAD4  mov      x0, x19
006A9BAD8  mov      x1, xzr
006A9BADC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BAE0  adrp     x21, #0x959e000
006A9BAE4  ldrb     w8, [x21, #0x622]
006A9BAE8  mov      w20, w0
006A9BAEC  cbnz     w8, #0x6a9bb04
006A9BAF0  adrp     x0, #0x8f39000
006A9BAF4  ldr      x0, [x0, #0x638]
006A9BAF8  bl       #0x382bd14 ; 
006A9BAFC  mov      w8, #1
006A9BB00  strb     w8, [x21, #0x622]
006A9BB04  adrp     x8, #0x8f39000
006A9BB08  ldr      x8, [x8, #0x638]
006A9BB0C  ldr      x2, [x8]
006A9BB10  ldrb     w8, [x2, #0x53]
006A9BB14  tbnz     w8, #5, #0x6a9bb20
006A9BB18  str      w20, [x19, #0x98]
006A9BB1C  b        #0x6a9bb30 ; 
006A9BB20  ldr      x8, [x2, #0x60]
006A9BB24  mov      x0, x19
006A9BB28  mov      w1, w20
006A9BB2C  blr      x8
006A9BB30  mov      x0, x19
006A9BB34  mov      x1, xzr
006A9BB38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BB3C  adrp     x21, #0x959e000
006A9BB40  ldrb     w8, [x21, #0x623]
006A9BB44  mov      w20, w0
006A9BB48  cbnz     w8, #0x6a9bb60
006A9BB4C  adrp     x0, #0x8f39000
006A9BB50  ldr      x0, [x0, #0x648]
006A9BB54  bl       #0x382bd14 ; 
006A9BB58  mov      w8, #1
006A9BB5C  strb     w8, [x21, #0x623]
006A9BB60  adrp     x8, #0x8f39000
006A9BB64  ldr      x8, [x8, #0x648]
006A9BB68  ldr      x2, [x8]
006A9BB6C  ldrb     w8, [x2, #0x53]
006A9BB70  tbnz     w8, #5, #0x6a9bb7c
006A9BB74  str      w20, [x19, #0x9c]
006A9BB78  b        #0x6a9bb8c ; 
006A9BB7C  ldr      x8, [x2, #0x60]
006A9BB80  mov      x0, x19
006A9BB84  mov      w1, w20
006A9BB88  blr      x8
006A9BB8C  mov      x0, x19
006A9BB90  mov      x1, xzr
006A9BB94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BB98  adrp     x21, #0x959e000
006A9BB9C  ldrb     w8, [x21, #0x624]
006A9BBA0  mov      w20, w0
006A9BBA4  cbnz     w8, #0x6a9bbbc
006A9BBA8  adrp     x0, #0x8f39000
006A9BBAC  ldr      x0, [x0, #0x658]
006A9BBB0  bl       #0x382bd14 ; 
006A9BBB4  mov      w8, #1
006A9BBB8  strb     w8, [x21, #0x624]
006A9BBBC  adrp     x8, #0x8f39000
006A9BBC0  ldr      x8, [x8, #0x658]
006A9BBC4  ldr      x2, [x8]
006A9BBC8  ldrb     w8, [x2, #0x53]
006A9BBCC  tbnz     w8, #5, #0x6a9bbd8
006A9BBD0  str      w20, [x19, #0xa0]
006A9BBD4  b        #0x6a9bbe8 ; 
006A9BBD8  ldr      x8, [x2, #0x60]
006A9BBDC  mov      x0, x19
006A9BBE0  mov      w1, w20
006A9BBE4  blr      x8
006A9BBE8  mov      x0, x19
006A9BBEC  mov      x1, xzr
006A9BBF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BBF4  adrp     x21, #0x959e000
006A9BBF8  ldrb     w8, [x21, #0x625]
006A9BBFC  mov      w20, w0
006A9BC00  cbnz     w8, #0x6a9bc18
006A9BC04  adrp     x0, #0x8f39000
006A9BC08  ldr      x0, [x0, #0x668]
006A9BC0C  bl       #0x382bd14 ; 
006A9BC10  mov      w8, #1
006A9BC14  strb     w8, [x21, #0x625]
006A9BC18  adrp     x8, #0x8f39000
006A9BC1C  ldr      x8, [x8, #0x668]
006A9BC20  ldr      x2, [x8]
006A9BC24  ldrb     w8, [x2, #0x53]
006A9BC28  tbnz     w8, #5, #0x6a9bc34
006A9BC2C  str      w20, [x19, #0xa4]
006A9BC30  b        #0x6a9bc44 ; 
006A9BC34  ldr      x8, [x2, #0x60]
006A9BC38  mov      x0, x19
006A9BC3C  mov      w1, w20
006A9BC40  blr      x8
006A9BC44  mov      x0, x19
006A9BC48  mov      x1, xzr
006A9BC4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BC50  adrp     x21, #0x959e000
006A9BC54  ldrb     w8, [x21, #0x626]
006A9BC58  mov      w20, w0
006A9BC5C  cbnz     w8, #0x6a9bc74
006A9BC60  adrp     x0, #0x8f39000
006A9BC64  ldr      x0, [x0, #0x678]
006A9BC68  bl       #0x382bd14 ; 
006A9BC6C  mov      w8, #1
006A9BC70  strb     w8, [x21, #0x626]
006A9BC74  adrp     x8, #0x8f39000
006A9BC78  ldr      x8, [x8, #0x678]
006A9BC7C  ldr      x2, [x8]
006A9BC80  ldrb     w8, [x2, #0x53]
006A9BC84  tbnz     w8, #5, #0x6a9bc90
006A9BC88  str      w20, [x19, #0xa8]
006A9BC8C  b        #0x6a9bca0 ; 
006A9BC90  ldr      x8, [x2, #0x60]
006A9BC94  mov      x0, x19
006A9BC98  mov      w1, w20
006A9BC9C  blr      x8
006A9BCA0  mov      x0, x19
006A9BCA4  mov      x1, xzr
006A9BCA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9BCAC  adrp     x21, #0x959e000
006A9BCB0  ldrb     w8, [x21, #0x627]
006A9BCB4  mov      w20, w0
006A9BCB8  cbnz     w8, #0x6a9bcd0
006A9BCBC  adrp     x0, #0x8f39000
006A9BCC0  ldr      x0, [x0, #0x688]
006A9BCC4  bl       #0x382bd14 ; 
006A9BCC8  mov      w8, #1
006A9BCCC  strb     w8, [x21, #0x627]
006A9BCD0  adrp     x8, #0x8f39000
006A9BCD4  ldr      x8, [x8, #0x688]
006A9BCD8  ldr      x2, [x8]
006A9BCDC  ldrb     w8, [x2, #0x53]
006A9BCE0  tbnz     w8, #5, #0x6a9bcec
006A9BCE4  str      w20, [x19, #0xac]
006A9BCE8  b        #0x6a9bcfc ; 
006A9BCEC  ldr      x8, [x2, #0x60]
006A9BCF0  mov      x0, x19
006A9BCF4  mov      w1, w20
006A9BCF8  blr      x8
006A9BCFC  mov      x0, x19
006A9BD00  mov      x1, xzr
006A9BD04  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A9BD08  adrp     x21, #0x959e000
006A9BD0C  ldrb     w8, [x21, #0x628]
006A9BD10  mov      x20, x0
006A9BD14  cbnz     w8, #0x6a9bd2c
006A9BD18  adrp     x0, #0x8f39000
006A9BD1C  ldr      x0, [x0, #0x698]
006A9BD20  bl       #0x382bd14 ; 
006A9BD24  mov      w8, #1
006A9BD28  strb     w8, [x21, #0x628]
006A9BD2C  adrp     x8, #0x8f39000
006A9BD30  ldr      x8, [x8, #0x698]
006A9BD34  ldr      x2, [x8]
006A9BD38  ldrb     w8, [x2, #0x53]
006A9BD3C  tbnz     w8, #5, #0x6a9bd54
006A9BD40  str      x20, [x19, #0xb0]!
006A9BD44  mov      x0, x19
006A9BD48  mov      x1, x20
006A9BD4C  bl       #0x382bcb8 ; 
006A9BD50  b        #0x6a9bd64 ; 
006A9BD54  ldr      x8, [x2, #0x60]
006A9BD58  mov      x0, x19
006A9BD5C  mov      x1, x20
006A9BD60  blr      x8
006A9BD64  ldp      x20, x19, [sp, #0x10]
006A9BD68  mov      w0, #1
006A9BD6C  ldp      x30, x21, [sp], #0x20
006A9BD70  ret      

