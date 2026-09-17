; LocalModels.Bean.Bullet_Bullet$$readImpl
; RVA 0x688B368; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00688B368  stp      x30, x21, [sp, #-0x20]!
00688B36C  stp      x20, x19, [sp, #0x10]
00688B370  adrp     x20, #0x959b000
00688B374  adrp     x21, #0x8f25000
00688B378  ldrb     w8, [x20, #0xcb7]
00688B37C  ldr      x21, [x21, #0x3e0]
00688B380  mov      x19, x0
00688B384  tbnz     w8, #0, #0x688b39c
00688B388  adrp     x0, #0x8f25000
00688B38C  ldr      x0, [x0, #0x3e0]
00688B390  bl       #0x382bd14 ; 
00688B394  mov      w8, #1
00688B398  strb     w8, [x20, #0xcb7]
00688B39C  ldr      x1, [x21]
00688B3A0  ldrb     w8, [x1, #0x53]
00688B3A4  tbnz     w8, #5, #0x688b3f4
00688B3A8  mov      x0, x19
00688B3AC  mov      x1, xzr
00688B3B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B3B4  adrp     x21, #0x959c000
00688B3B8  ldrb     w8, [x21, #0x406]
00688B3BC  mov      w20, w0
00688B3C0  cbnz     w8, #0x688b3d8
00688B3C4  adrp     x0, #0x8f25000
00688B3C8  ldr      x0, [x0, #0x148]
00688B3CC  bl       #0x382bd14 ; 
00688B3D0  mov      w8, #1
00688B3D4  strb     w8, [x21, #0x406]
00688B3D8  adrp     x8, #0x8f25000
00688B3DC  ldr      x8, [x8, #0x148]
00688B3E0  ldr      x2, [x8]
00688B3E4  ldrb     w8, [x2, #0x53]
00688B3E8  tbnz     w8, #5, #0x688b408
00688B3EC  str      w20, [x19, #0x20]
00688B3F0  b        #0x688b418 ; 
00688B3F4  ldr      x2, [x1, #0x60]
00688B3F8  mov      x0, x19
00688B3FC  ldp      x20, x19, [sp, #0x10]
00688B400  ldp      x30, x21, [sp], #0x20
00688B404  br       x2
00688B408  ldr      x8, [x2, #0x60]
00688B40C  mov      x0, x19
00688B410  mov      w1, w20
00688B414  blr      x8
00688B418  mov      x0, x19
00688B41C  mov      x1, xzr
00688B420  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688B424  adrp     x21, #0x959c000
00688B428  ldrb     w8, [x21, #0x407]
00688B42C  mov      x20, x0
00688B430  cbnz     w8, #0x688b448
00688B434  adrp     x0, #0x8f25000
00688B438  ldr      x0, [x0, #0x158]
00688B43C  bl       #0x382bd14 ; 
00688B440  mov      w8, #1
00688B444  strb     w8, [x21, #0x407]
00688B448  adrp     x8, #0x8f25000
00688B44C  ldr      x8, [x8, #0x158]
00688B450  ldr      x2, [x8]
00688B454  ldrb     w8, [x2, #0x53]
00688B458  tbnz     w8, #5, #0x688b464
00688B45C  str      x20, [x19, #0x28]
00688B460  b        #0x688b474 ; 
00688B464  ldr      x8, [x2, #0x60]
00688B468  mov      x0, x19
00688B46C  mov      x1, x20
00688B470  blr      x8
00688B474  mov      x0, x19
00688B478  mov      x1, xzr
00688B47C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
00688B480  adrp     x21, #0x959c000
00688B484  ldrb     w8, [x21, #0x408]
00688B488  mov      x20, x0
00688B48C  cbnz     w8, #0x688b4a4
00688B490  adrp     x0, #0x8f25000
00688B494  ldr      x0, [x0, #0x168]
00688B498  bl       #0x382bd14 ; 
00688B49C  mov      w8, #1
00688B4A0  strb     w8, [x21, #0x408]
00688B4A4  adrp     x8, #0x8f25000
00688B4A8  ldr      x8, [x8, #0x168]
00688B4AC  ldr      x2, [x8]
00688B4B0  ldrb     w8, [x2, #0x53]
00688B4B4  tbnz     w8, #5, #0x688b4cc
00688B4B8  mov      x0, x19
00688B4BC  str      x20, [x0, #0x30]!
00688B4C0  mov      x1, x20
00688B4C4  bl       #0x382bcb8 ; 
00688B4C8  b        #0x688b4dc ; 
00688B4CC  ldr      x8, [x2, #0x60]
00688B4D0  mov      x0, x19
00688B4D4  mov      x1, x20
00688B4D8  blr      x8
00688B4DC  mov      x0, x19
00688B4E0  mov      x1, xzr
00688B4E4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688B4E8  adrp     x21, #0x959c000
00688B4EC  ldrb     w8, [x21, #0x409]
00688B4F0  mov      x20, x0
00688B4F4  cbnz     w8, #0x688b50c
00688B4F8  adrp     x0, #0x8f25000
00688B4FC  ldr      x0, [x0, #0x170]
00688B500  bl       #0x382bd14 ; 
00688B504  mov      w8, #1
00688B508  strb     w8, [x21, #0x409]
00688B50C  adrp     x8, #0x8f25000
00688B510  ldr      x8, [x8, #0x170]
00688B514  ldr      x2, [x8]
00688B518  ldrb     w8, [x2, #0x53]
00688B51C  tbnz     w8, #5, #0x688b528
00688B520  str      x20, [x19, #0x38]
00688B524  b        #0x688b538 ; 
00688B528  ldr      x8, [x2, #0x60]
00688B52C  mov      x0, x19
00688B530  mov      x1, x20
00688B534  blr      x8
00688B538  mov      x0, x19
00688B53C  mov      x1, xzr
00688B540  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688B544  adrp     x21, #0x959c000
00688B548  ldrb     w8, [x21, #0x40a]
00688B54C  mov      x20, x0
00688B550  cbnz     w8, #0x688b568
00688B554  adrp     x0, #0x8f25000
00688B558  ldr      x0, [x0, #0x180]
00688B55C  bl       #0x382bd14 ; 
00688B560  mov      w8, #1
00688B564  strb     w8, [x21, #0x40a]
00688B568  adrp     x8, #0x8f25000
00688B56C  ldr      x8, [x8, #0x180]
00688B570  ldr      x2, [x8]
00688B574  ldrb     w8, [x2, #0x53]
00688B578  tbnz     w8, #5, #0x688b584
00688B57C  str      x20, [x19, #0x40]
00688B580  b        #0x688b594 ; 
00688B584  ldr      x8, [x2, #0x60]
00688B588  mov      x0, x19
00688B58C  mov      x1, x20
00688B590  blr      x8
00688B594  mov      x0, x19
00688B598  mov      x1, xzr
00688B59C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688B5A0  adrp     x21, #0x959c000
00688B5A4  ldrb     w8, [x21, #0x40b]
00688B5A8  mov      x20, x0
00688B5AC  cbnz     w8, #0x688b5c4
00688B5B0  adrp     x0, #0x8f25000
00688B5B4  ldr      x0, [x0, #0x190]
00688B5B8  bl       #0x382bd14 ; 
00688B5BC  mov      w8, #1
00688B5C0  strb     w8, [x21, #0x40b]
00688B5C4  adrp     x8, #0x8f25000
00688B5C8  ldr      x8, [x8, #0x190]
00688B5CC  ldr      x2, [x8]
00688B5D0  ldrb     w8, [x2, #0x53]
00688B5D4  tbnz     w8, #5, #0x688b5e0
00688B5D8  str      x20, [x19, #0x48]
00688B5DC  b        #0x688b5f0 ; 
00688B5E0  ldr      x8, [x2, #0x60]
00688B5E4  mov      x0, x19
00688B5E8  mov      x1, x20
00688B5EC  blr      x8
00688B5F0  mov      x0, x19
00688B5F4  mov      x1, xzr
00688B5F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B5FC  adrp     x21, #0x959c000
00688B600  ldrb     w8, [x21, #0x40c]
00688B604  mov      w20, w0
00688B608  cbnz     w8, #0x688b620
00688B60C  adrp     x0, #0x8f25000
00688B610  ldr      x0, [x0, #0x198]
00688B614  bl       #0x382bd14 ; 
00688B618  mov      w8, #1
00688B61C  strb     w8, [x21, #0x40c]
00688B620  adrp     x8, #0x8f25000
00688B624  ldr      x8, [x8, #0x198]
00688B628  ldr      x2, [x8]
00688B62C  ldrb     w8, [x2, #0x53]
00688B630  tbnz     w8, #5, #0x688b63c
00688B634  str      w20, [x19, #0x50]
00688B638  b        #0x688b64c ; 
00688B63C  ldr      x8, [x2, #0x60]
00688B640  mov      x0, x19
00688B644  mov      w1, w20
00688B648  blr      x8
00688B64C  mov      x0, x19
00688B650  mov      x1, xzr
00688B654  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688B658  adrp     x21, #0x959c000
00688B65C  ldrb     w8, [x21, #0x40d]
00688B660  mov      x20, x0
00688B664  cbnz     w8, #0x688b67c
00688B668  adrp     x0, #0x8f25000
00688B66C  ldr      x0, [x0, #0x1a8]
00688B670  bl       #0x382bd14 ; 
00688B674  mov      w8, #1
00688B678  strb     w8, [x21, #0x40d]
00688B67C  adrp     x8, #0x8f25000
00688B680  ldr      x8, [x8, #0x1a8]
00688B684  ldr      x2, [x8]
00688B688  ldrb     w8, [x2, #0x53]
00688B68C  tbnz     w8, #5, #0x688b698
00688B690  str      x20, [x19, #0x58]
00688B694  b        #0x688b6a8 ; 
00688B698  ldr      x8, [x2, #0x60]
00688B69C  mov      x0, x19
00688B6A0  mov      x1, x20
00688B6A4  blr      x8
00688B6A8  mov      x0, x19
00688B6AC  mov      x1, xzr
00688B6B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B6B4  adrp     x21, #0x959c000
00688B6B8  ldrb     w8, [x21, #0x40e]
00688B6BC  mov      w20, w0
00688B6C0  cbnz     w8, #0x688b6d8
00688B6C4  adrp     x0, #0x8f25000
00688B6C8  ldr      x0, [x0, #0x1b0]
00688B6CC  bl       #0x382bd14 ; 
00688B6D0  mov      w8, #1
00688B6D4  strb     w8, [x21, #0x40e]
00688B6D8  adrp     x8, #0x8f25000
00688B6DC  ldr      x8, [x8, #0x1b0]
00688B6E0  ldr      x2, [x8]
00688B6E4  ldrb     w8, [x2, #0x53]
00688B6E8  tbnz     w8, #5, #0x688b6f4
00688B6EC  str      w20, [x19, #0x60]
00688B6F0  b        #0x688b704 ; 
00688B6F4  ldr      x8, [x2, #0x60]
00688B6F8  mov      x0, x19
00688B6FC  mov      w1, w20
00688B700  blr      x8
00688B704  mov      x0, x19
00688B708  mov      x1, xzr
00688B70C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B710  adrp     x21, #0x959c000
00688B714  ldrb     w8, [x21, #0x40f]
00688B718  mov      w20, w0
00688B71C  cbnz     w8, #0x688b734
00688B720  adrp     x0, #0x8f25000
00688B724  ldr      x0, [x0, #0x1b8]
00688B728  bl       #0x382bd14 ; 
00688B72C  mov      w8, #1
00688B730  strb     w8, [x21, #0x40f]
00688B734  adrp     x8, #0x8f25000
00688B738  ldr      x8, [x8, #0x1b8]
00688B73C  ldr      x2, [x8]
00688B740  ldrb     w8, [x2, #0x53]
00688B744  tbnz     w8, #5, #0x688b750
00688B748  str      w20, [x19, #0x64]
00688B74C  b        #0x688b760 ; 
00688B750  ldr      x8, [x2, #0x60]
00688B754  mov      x0, x19
00688B758  mov      w1, w20
00688B75C  blr      x8
00688B760  mov      x0, x19
00688B764  mov      x1, xzr
00688B768  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688B76C  adrp     x21, #0x959c000
00688B770  ldrb     w8, [x21, #0x410]
00688B774  mov      x20, x0
00688B778  cbnz     w8, #0x688b790
00688B77C  adrp     x0, #0x8f25000
00688B780  ldr      x0, [x0, #0x1c8]
00688B784  bl       #0x382bd14 ; 
00688B788  mov      w8, #1
00688B78C  strb     w8, [x21, #0x410]
00688B790  adrp     x8, #0x8f25000
00688B794  ldr      x8, [x8, #0x1c8]
00688B798  ldr      x2, [x8]
00688B79C  ldrb     w8, [x2, #0x53]
00688B7A0  tbnz     w8, #5, #0x688b7ac
00688B7A4  str      x20, [x19, #0x68]
00688B7A8  b        #0x688b7bc ; 
00688B7AC  ldr      x8, [x2, #0x60]
00688B7B0  mov      x0, x19
00688B7B4  mov      x1, x20
00688B7B8  blr      x8
00688B7BC  mov      x0, x19
00688B7C0  mov      x1, xzr
00688B7C4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688B7C8  adrp     x21, #0x959c000
00688B7CC  ldrb     w8, [x21, #0x411]
00688B7D0  mov      x20, x0
00688B7D4  cbnz     w8, #0x688b7ec
00688B7D8  adrp     x0, #0x8f25000
00688B7DC  ldr      x0, [x0, #0x1d8]
00688B7E0  bl       #0x382bd14 ; 
00688B7E4  mov      w8, #1
00688B7E8  strb     w8, [x21, #0x411]
00688B7EC  adrp     x8, #0x8f25000
00688B7F0  ldr      x8, [x8, #0x1d8]
00688B7F4  ldr      x2, [x8]
00688B7F8  ldrb     w8, [x2, #0x53]
00688B7FC  tbnz     w8, #5, #0x688b808
00688B800  str      x20, [x19, #0x70]
00688B804  b        #0x688b818 ; 
00688B808  ldr      x8, [x2, #0x60]
00688B80C  mov      x0, x19
00688B810  mov      x1, x20
00688B814  blr      x8
00688B818  mov      x0, x19
00688B81C  mov      x1, xzr
00688B820  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B824  adrp     x21, #0x959c000
00688B828  ldrb     w8, [x21, #0x412]
00688B82C  mov      w20, w0
00688B830  cbnz     w8, #0x688b848
00688B834  adrp     x0, #0x8f25000
00688B838  ldr      x0, [x0, #0x1e8]
00688B83C  bl       #0x382bd14 ; 
00688B840  mov      w8, #1
00688B844  strb     w8, [x21, #0x412]
00688B848  adrp     x8, #0x8f25000
00688B84C  ldr      x8, [x8, #0x1e8]
00688B850  ldr      x2, [x8]
00688B854  ldrb     w8, [x2, #0x53]
00688B858  tbnz     w8, #5, #0x688b864
00688B85C  str      w20, [x19, #0x78]
00688B860  b        #0x688b874 ; 
00688B864  ldr      x8, [x2, #0x60]
00688B868  mov      x0, x19
00688B86C  mov      w1, w20
00688B870  blr      x8
00688B874  mov      x0, x19
00688B878  mov      x1, xzr
00688B87C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688B880  adrp     x21, #0x959c000
00688B884  ldrb     w8, [x21, #0x413]
00688B888  mov      x20, x0
00688B88C  cbnz     w8, #0x688b8a4
00688B890  adrp     x0, #0x8f25000
00688B894  ldr      x0, [x0, #0x1f8]
00688B898  bl       #0x382bd14 ; 
00688B89C  mov      w8, #1
00688B8A0  strb     w8, [x21, #0x413]
00688B8A4  adrp     x8, #0x8f25000
00688B8A8  ldr      x8, [x8, #0x1f8]
00688B8AC  ldr      x2, [x8]
00688B8B0  ldrb     w8, [x2, #0x53]
00688B8B4  tbnz     w8, #5, #0x688b8cc
00688B8B8  mov      x0, x19
00688B8BC  str      x20, [x0, #0x80]!
00688B8C0  mov      x1, x20
00688B8C4  bl       #0x382bcb8 ; 
00688B8C8  b        #0x688b8dc ; 
00688B8CC  ldr      x8, [x2, #0x60]
00688B8D0  mov      x0, x19
00688B8D4  mov      x1, x20
00688B8D8  blr      x8
00688B8DC  mov      x0, x19
00688B8E0  mov      x1, xzr
00688B8E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B8E8  adrp     x21, #0x959c000
00688B8EC  ldrb     w8, [x21, #0x414]
00688B8F0  mov      w20, w0
00688B8F4  cbnz     w8, #0x688b90c
00688B8F8  adrp     x0, #0x8f25000
00688B8FC  ldr      x0, [x0, #0x208]
00688B900  bl       #0x382bd14 ; 
00688B904  mov      w8, #1
00688B908  strb     w8, [x21, #0x414]
00688B90C  adrp     x8, #0x8f25000
00688B910  ldr      x8, [x8, #0x208]
00688B914  ldr      x2, [x8]
00688B918  ldrb     w8, [x2, #0x53]
00688B91C  tbnz     w8, #5, #0x688b928
00688B920  str      w20, [x19, #0x88]
00688B924  b        #0x688b938 ; 
00688B928  ldr      x8, [x2, #0x60]
00688B92C  mov      x0, x19
00688B930  mov      w1, w20
00688B934  blr      x8
00688B938  mov      x0, x19
00688B93C  mov      x1, xzr
00688B940  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B944  adrp     x21, #0x959c000
00688B948  ldrb     w8, [x21, #0x415]
00688B94C  mov      w20, w0
00688B950  cbnz     w8, #0x688b968
00688B954  adrp     x0, #0x8f25000
00688B958  ldr      x0, [x0, #0x218]
00688B95C  bl       #0x382bd14 ; 
00688B960  mov      w8, #1
00688B964  strb     w8, [x21, #0x415]
00688B968  adrp     x8, #0x8f25000
00688B96C  ldr      x8, [x8, #0x218]
00688B970  ldr      x2, [x8]
00688B974  ldrb     w8, [x2, #0x53]
00688B978  tbnz     w8, #5, #0x688b984
00688B97C  str      w20, [x19, #0x8c]
00688B980  b        #0x688b994 ; 
00688B984  ldr      x8, [x2, #0x60]
00688B988  mov      x0, x19
00688B98C  mov      w1, w20
00688B990  blr      x8
00688B994  mov      x0, x19
00688B998  mov      x1, xzr
00688B99C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688B9A0  adrp     x21, #0x959c000
00688B9A4  ldrb     w8, [x21, #0x416]
00688B9A8  mov      w20, w0
00688B9AC  cbnz     w8, #0x688b9c4
00688B9B0  adrp     x0, #0x8f25000
00688B9B4  ldr      x0, [x0, #0x228]
00688B9B8  bl       #0x382bd14 ; 
00688B9BC  mov      w8, #1
00688B9C0  strb     w8, [x21, #0x416]
00688B9C4  adrp     x8, #0x8f25000
00688B9C8  ldr      x8, [x8, #0x228]
00688B9CC  ldr      x2, [x8]
00688B9D0  ldrb     w8, [x2, #0x53]
00688B9D4  tbnz     w8, #5, #0x688b9e0
00688B9D8  str      w20, [x19, #0x90]
00688B9DC  b        #0x688b9f0 ; 
00688B9E0  ldr      x8, [x2, #0x60]
00688B9E4  mov      x0, x19
00688B9E8  mov      w1, w20
00688B9EC  blr      x8
00688B9F0  mov      x0, x19
00688B9F4  mov      x1, xzr
00688B9F8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688B9FC  adrp     x21, #0x959c000
00688BA00  ldrb     w8, [x21, #0x417]
00688BA04  mov      x20, x0
00688BA08  cbnz     w8, #0x688ba20
00688BA0C  adrp     x0, #0x8f25000
00688BA10  ldr      x0, [x0, #0x238]
00688BA14  bl       #0x382bd14 ; 
00688BA18  mov      w8, #1
00688BA1C  strb     w8, [x21, #0x417]
00688BA20  adrp     x8, #0x8f25000
00688BA24  ldr      x8, [x8, #0x238]
00688BA28  ldr      x2, [x8]
00688BA2C  ldrb     w8, [x2, #0x53]
00688BA30  tbnz     w8, #5, #0x688ba48
00688BA34  mov      x0, x19
00688BA38  str      x20, [x0, #0x98]!
00688BA3C  mov      x1, x20
00688BA40  bl       #0x382bcb8 ; 
00688BA44  b        #0x688ba58 ; 
00688BA48  ldr      x8, [x2, #0x60]
00688BA4C  mov      x0, x19
00688BA50  mov      x1, x20
00688BA54  blr      x8
00688BA58  mov      x0, x19
00688BA5C  mov      x1, xzr
00688BA60  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688BA64  adrp     x21, #0x959c000
00688BA68  ldrb     w8, [x21, #0x418]
00688BA6C  mov      x20, x0
00688BA70  cbnz     w8, #0x688ba88
00688BA74  adrp     x0, #0x8f25000
00688BA78  ldr      x0, [x0, #0x248]
00688BA7C  bl       #0x382bd14 ; 
00688BA80  mov      w8, #1
00688BA84  strb     w8, [x21, #0x418]
00688BA88  adrp     x8, #0x8f25000
00688BA8C  ldr      x8, [x8, #0x248]
00688BA90  ldr      x2, [x8]
00688BA94  ldrb     w8, [x2, #0x53]
00688BA98  tbnz     w8, #5, #0x688bab0
00688BA9C  mov      x0, x19
00688BAA0  str      x20, [x0, #0xa0]!
00688BAA4  mov      x1, x20
00688BAA8  bl       #0x382bcb8 ; 
00688BAAC  b        #0x688bac0 ; 
00688BAB0  ldr      x8, [x2, #0x60]
00688BAB4  mov      x0, x19
00688BAB8  mov      x1, x20
00688BABC  blr      x8
00688BAC0  mov      x0, x19
00688BAC4  mov      x1, xzr
00688BAC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BACC  adrp     x21, #0x959c000
00688BAD0  ldrb     w8, [x21, #0x419]
00688BAD4  mov      w20, w0
00688BAD8  cbnz     w8, #0x688baf0
00688BADC  adrp     x0, #0x8f25000
00688BAE0  ldr      x0, [x0, #0x258]
00688BAE4  bl       #0x382bd14 ; 
00688BAE8  mov      w8, #1
00688BAEC  strb     w8, [x21, #0x419]
00688BAF0  adrp     x8, #0x8f25000
00688BAF4  ldr      x8, [x8, #0x258]
00688BAF8  ldr      x2, [x8]
00688BAFC  ldrb     w8, [x2, #0x53]
00688BB00  tbnz     w8, #5, #0x688bb0c
00688BB04  str      w20, [x19, #0xa8]
00688BB08  b        #0x688bb1c ; 
00688BB0C  ldr      x8, [x2, #0x60]
00688BB10  mov      x0, x19
00688BB14  mov      w1, w20
00688BB18  blr      x8
00688BB1C  mov      x0, x19
00688BB20  mov      x1, xzr
00688BB24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BB28  adrp     x21, #0x959c000
00688BB2C  ldrb     w8, [x21, #0x41a]
00688BB30  mov      w20, w0
00688BB34  cbnz     w8, #0x688bb4c
00688BB38  adrp     x0, #0x8f25000
00688BB3C  ldr      x0, [x0, #0x268]
00688BB40  bl       #0x382bd14 ; 
00688BB44  mov      w8, #1
00688BB48  strb     w8, [x21, #0x41a]
00688BB4C  adrp     x8, #0x8f25000
00688BB50  ldr      x8, [x8, #0x268]
00688BB54  ldr      x2, [x8]
00688BB58  ldrb     w8, [x2, #0x53]
00688BB5C  tbnz     w8, #5, #0x688bb68
00688BB60  str      w20, [x19, #0xac]
00688BB64  b        #0x688bb78 ; 
00688BB68  ldr      x8, [x2, #0x60]
00688BB6C  mov      x0, x19
00688BB70  mov      w1, w20
00688BB74  blr      x8
00688BB78  mov      x0, x19
00688BB7C  mov      x1, xzr
00688BB80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BB84  adrp     x21, #0x959c000
00688BB88  ldrb     w8, [x21, #0x41b]
00688BB8C  mov      w20, w0
00688BB90  cbnz     w8, #0x688bba8
00688BB94  adrp     x0, #0x8f25000
00688BB98  ldr      x0, [x0, #0x278]
00688BB9C  bl       #0x382bd14 ; 
00688BBA0  mov      w8, #1
00688BBA4  strb     w8, [x21, #0x41b]
00688BBA8  adrp     x8, #0x8f25000
00688BBAC  ldr      x8, [x8, #0x278]
00688BBB0  ldr      x2, [x8]
00688BBB4  ldrb     w8, [x2, #0x53]
00688BBB8  tbnz     w8, #5, #0x688bbc4
00688BBBC  str      w20, [x19, #0xb0]
00688BBC0  b        #0x688bbd4 ; 
00688BBC4  ldr      x8, [x2, #0x60]
00688BBC8  mov      x0, x19
00688BBCC  mov      w1, w20
00688BBD0  blr      x8
00688BBD4  mov      x0, x19
00688BBD8  mov      x1, xzr
00688BBDC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BBE0  adrp     x21, #0x959c000
00688BBE4  ldrb     w8, [x21, #0x41c]
00688BBE8  mov      w20, w0
00688BBEC  cbnz     w8, #0x688bc04
00688BBF0  adrp     x0, #0x8f25000
00688BBF4  ldr      x0, [x0, #0x288]
00688BBF8  bl       #0x382bd14 ; 
00688BBFC  mov      w8, #1
00688BC00  strb     w8, [x21, #0x41c]
00688BC04  adrp     x8, #0x8f25000
00688BC08  ldr      x8, [x8, #0x288]
00688BC0C  ldr      x2, [x8]
00688BC10  ldrb     w8, [x2, #0x53]
00688BC14  tbnz     w8, #5, #0x688bc20
00688BC18  str      w20, [x19, #0xb4]
00688BC1C  b        #0x688bc30 ; 
00688BC20  ldr      x8, [x2, #0x60]
00688BC24  mov      x0, x19
00688BC28  mov      w1, w20
00688BC2C  blr      x8
00688BC30  mov      x0, x19
00688BC34  mov      x1, xzr
00688BC38  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688BC3C  adrp     x21, #0x959c000
00688BC40  ldrb     w8, [x21, #0x41d]
00688BC44  mov      x20, x0
00688BC48  cbnz     w8, #0x688bc60
00688BC4C  adrp     x0, #0x8f25000
00688BC50  ldr      x0, [x0, #0x298]
00688BC54  bl       #0x382bd14 ; 
00688BC58  mov      w8, #1
00688BC5C  strb     w8, [x21, #0x41d]
00688BC60  adrp     x8, #0x8f25000
00688BC64  ldr      x8, [x8, #0x298]
00688BC68  ldr      x2, [x8]
00688BC6C  ldrb     w8, [x2, #0x53]
00688BC70  tbnz     w8, #5, #0x688bc88
00688BC74  mov      x0, x19
00688BC78  str      x20, [x0, #0xb8]!
00688BC7C  mov      x1, x20
00688BC80  bl       #0x382bcb8 ; 
00688BC84  b        #0x688bc98 ; 
00688BC88  ldr      x8, [x2, #0x60]
00688BC8C  mov      x0, x19
00688BC90  mov      x1, x20
00688BC94  blr      x8
00688BC98  mov      x0, x19
00688BC9C  mov      x1, xzr
00688BCA0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688BCA4  adrp     x21, #0x959c000
00688BCA8  ldrb     w8, [x21, #0x41e]
00688BCAC  mov      x20, x0
00688BCB0  cbnz     w8, #0x688bcc8
00688BCB4  adrp     x0, #0x8f25000
00688BCB8  ldr      x0, [x0, #0x2a8]
00688BCBC  bl       #0x382bd14 ; 
00688BCC0  mov      w8, #1
00688BCC4  strb     w8, [x21, #0x41e]
00688BCC8  adrp     x8, #0x8f25000
00688BCCC  ldr      x8, [x8, #0x2a8]
00688BCD0  ldr      x2, [x8]
00688BCD4  ldrb     w8, [x2, #0x53]
00688BCD8  tbnz     w8, #5, #0x688bcf0
00688BCDC  mov      x0, x19
00688BCE0  str      x20, [x0, #0xc0]!
00688BCE4  mov      x1, x20
00688BCE8  bl       #0x382bcb8 ; 
00688BCEC  b        #0x688bd00 ; 
00688BCF0  ldr      x8, [x2, #0x60]
00688BCF4  mov      x0, x19
00688BCF8  mov      x1, x20
00688BCFC  blr      x8
00688BD00  mov      x0, x19
00688BD04  mov      x1, xzr
00688BD08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BD0C  adrp     x21, #0x959c000
00688BD10  ldrb     w8, [x21, #0x41f]
00688BD14  mov      w20, w0
00688BD18  cbnz     w8, #0x688bd30
00688BD1C  adrp     x0, #0x8f25000
00688BD20  ldr      x0, [x0, #0x2b8]
00688BD24  bl       #0x382bd14 ; 
00688BD28  mov      w8, #1
00688BD2C  strb     w8, [x21, #0x41f]
00688BD30  adrp     x8, #0x8f25000
00688BD34  ldr      x8, [x8, #0x2b8]
00688BD38  ldr      x2, [x8]
00688BD3C  ldrb     w8, [x2, #0x53]
00688BD40  tbnz     w8, #5, #0x688bd4c
00688BD44  str      w20, [x19, #0xc8]
00688BD48  b        #0x688bd5c ; 
00688BD4C  ldr      x8, [x2, #0x60]
00688BD50  mov      x0, x19
00688BD54  mov      w1, w20
00688BD58  blr      x8
00688BD5C  mov      x0, x19
00688BD60  mov      x1, xzr
00688BD64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BD68  adrp     x21, #0x959c000
00688BD6C  ldrb     w8, [x21, #0x420]
00688BD70  mov      w20, w0
00688BD74  cbnz     w8, #0x688bd8c
00688BD78  adrp     x0, #0x8f25000
00688BD7C  ldr      x0, [x0, #0x2c8]
00688BD80  bl       #0x382bd14 ; 
00688BD84  mov      w8, #1
00688BD88  strb     w8, [x21, #0x420]
00688BD8C  adrp     x8, #0x8f25000
00688BD90  ldr      x8, [x8, #0x2c8]
00688BD94  ldr      x2, [x8]
00688BD98  ldrb     w8, [x2, #0x53]
00688BD9C  tbnz     w8, #5, #0x688bda8
00688BDA0  str      w20, [x19, #0xcc]
00688BDA4  b        #0x688bdb8 ; 
00688BDA8  ldr      x8, [x2, #0x60]
00688BDAC  mov      x0, x19
00688BDB0  mov      w1, w20
00688BDB4  blr      x8
00688BDB8  mov      x0, x19
00688BDBC  mov      x1, xzr
00688BDC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BDC4  adrp     x21, #0x959c000
00688BDC8  ldrb     w8, [x21, #0x421]
00688BDCC  mov      w20, w0
00688BDD0  cbnz     w8, #0x688bde8
00688BDD4  adrp     x0, #0x8f25000
00688BDD8  ldr      x0, [x0, #0x2d8]
00688BDDC  bl       #0x382bd14 ; 
00688BDE0  mov      w8, #1
00688BDE4  strb     w8, [x21, #0x421]
00688BDE8  adrp     x8, #0x8f25000
00688BDEC  ldr      x8, [x8, #0x2d8]
00688BDF0  ldr      x2, [x8]
00688BDF4  ldrb     w8, [x2, #0x53]
00688BDF8  tbnz     w8, #5, #0x688be04
00688BDFC  str      w20, [x19, #0xd0]
00688BE00  b        #0x688be14 ; 
00688BE04  ldr      x8, [x2, #0x60]
00688BE08  mov      x0, x19
00688BE0C  mov      w1, w20
00688BE10  blr      x8
00688BE14  mov      x0, x19
00688BE18  mov      x1, xzr
00688BE1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BE20  adrp     x21, #0x959c000
00688BE24  ldrb     w8, [x21, #0x422]
00688BE28  mov      w20, w0
00688BE2C  cbnz     w8, #0x688be44
00688BE30  adrp     x0, #0x8f25000
00688BE34  ldr      x0, [x0, #0x2e8]
00688BE38  bl       #0x382bd14 ; 
00688BE3C  mov      w8, #1
00688BE40  strb     w8, [x21, #0x422]
00688BE44  adrp     x8, #0x8f25000
00688BE48  ldr      x8, [x8, #0x2e8]
00688BE4C  ldr      x2, [x8]
00688BE50  ldrb     w8, [x2, #0x53]
00688BE54  tbnz     w8, #5, #0x688be60
00688BE58  str      w20, [x19, #0xd4]
00688BE5C  b        #0x688be70 ; 
00688BE60  ldr      x8, [x2, #0x60]
00688BE64  mov      x0, x19
00688BE68  mov      w1, w20
00688BE6C  blr      x8
00688BE70  mov      x0, x19
00688BE74  mov      x1, xzr
00688BE78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BE7C  adrp     x21, #0x959c000
00688BE80  ldrb     w8, [x21, #0x423]
00688BE84  mov      w20, w0
00688BE88  cbnz     w8, #0x688bea0
00688BE8C  adrp     x0, #0x8f25000
00688BE90  ldr      x0, [x0, #0x2f8]
00688BE94  bl       #0x382bd14 ; 
00688BE98  mov      w8, #1
00688BE9C  strb     w8, [x21, #0x423]
00688BEA0  adrp     x8, #0x8f25000
00688BEA4  ldr      x8, [x8, #0x2f8]
00688BEA8  ldr      x2, [x8]
00688BEAC  ldrb     w8, [x2, #0x53]
00688BEB0  tbnz     w8, #5, #0x688bebc
00688BEB4  str      w20, [x19, #0xd8]
00688BEB8  b        #0x688becc ; 
00688BEBC  ldr      x8, [x2, #0x60]
00688BEC0  mov      x0, x19
00688BEC4  mov      w1, w20
00688BEC8  blr      x8
00688BECC  mov      x0, x19
00688BED0  mov      x1, xzr
00688BED4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BED8  adrp     x21, #0x959c000
00688BEDC  ldrb     w8, [x21, #0x424]
00688BEE0  mov      w20, w0
00688BEE4  cbnz     w8, #0x688befc
00688BEE8  adrp     x0, #0x8f25000
00688BEEC  ldr      x0, [x0, #0x308]
00688BEF0  bl       #0x382bd14 ; 
00688BEF4  mov      w8, #1
00688BEF8  strb     w8, [x21, #0x424]
00688BEFC  adrp     x8, #0x8f25000
00688BF00  ldr      x8, [x8, #0x308]
00688BF04  ldr      x2, [x8]
00688BF08  ldrb     w8, [x2, #0x53]
00688BF0C  tbnz     w8, #5, #0x688bf18
00688BF10  str      w20, [x19, #0xdc]
00688BF14  b        #0x688bf28 ; 
00688BF18  ldr      x8, [x2, #0x60]
00688BF1C  mov      x0, x19
00688BF20  mov      w1, w20
00688BF24  blr      x8
00688BF28  mov      x0, x19
00688BF2C  mov      x1, xzr
00688BF30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688BF34  adrp     x21, #0x959c000
00688BF38  ldrb     w8, [x21, #0x425]
00688BF3C  mov      w20, w0
00688BF40  cbnz     w8, #0x688bf58
00688BF44  adrp     x0, #0x8f25000
00688BF48  ldr      x0, [x0, #0x310]
00688BF4C  bl       #0x382bd14 ; 
00688BF50  mov      w8, #1
00688BF54  strb     w8, [x21, #0x425]
00688BF58  adrp     x8, #0x8f25000
00688BF5C  ldr      x8, [x8, #0x310]
00688BF60  ldr      x2, [x8]
00688BF64  ldrb     w8, [x2, #0x53]
00688BF68  tbnz     w8, #5, #0x688bf74
00688BF6C  str      w20, [x19, #0xe0]
00688BF70  b        #0x688bf84 ; 
00688BF74  ldr      x8, [x2, #0x60]
00688BF78  mov      x0, x19
00688BF7C  mov      w1, w20
00688BF80  blr      x8
00688BF84  mov      x0, x19
00688BF88  mov      x1, xzr
00688BF8C  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
00688BF90  adrp     x21, #0x959c000
00688BF94  ldrb     w8, [x21, #0x426]
00688BF98  mov      x20, x0
00688BF9C  cbnz     w8, #0x688bfb4
00688BFA0  adrp     x0, #0x8f25000
00688BFA4  ldr      x0, [x0, #0x318]
00688BFA8  bl       #0x382bd14 ; 
00688BFAC  mov      w8, #1
00688BFB0  strb     w8, [x21, #0x426]
00688BFB4  adrp     x8, #0x8f25000
00688BFB8  ldr      x8, [x8, #0x318]
00688BFBC  ldr      x2, [x8]
00688BFC0  ldrb     w8, [x2, #0x53]
00688BFC4  tbnz     w8, #5, #0x688bfdc
00688BFC8  mov      x0, x19
00688BFCC  str      x20, [x0, #0xe8]!
00688BFD0  mov      x1, x20
00688BFD4  bl       #0x382bcb8 ; 
00688BFD8  b        #0x688bfec ; 
00688BFDC  ldr      x8, [x2, #0x60]
00688BFE0  mov      x0, x19
00688BFE4  mov      x1, x20
00688BFE8  blr      x8
00688BFEC  mov      x0, x19
00688BFF0  mov      x1, xzr
00688BFF4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688BFF8  adrp     x21, #0x959c000
00688BFFC  ldrb     w8, [x21, #0x427]
00688C000  mov      x20, x0
00688C004  cbnz     w8, #0x688c01c
00688C008  adrp     x0, #0x8f25000
00688C00C  ldr      x0, [x0, #0x328]
00688C010  bl       #0x382bd14 ; 
00688C014  mov      w8, #1
00688C018  strb     w8, [x21, #0x427]
00688C01C  adrp     x8, #0x8f25000
00688C020  ldr      x8, [x8, #0x328]
00688C024  ldr      x2, [x8]
00688C028  ldrb     w8, [x2, #0x53]
00688C02C  tbnz     w8, #5, #0x688c038
00688C030  str      x20, [x19, #0xf0]
00688C034  b        #0x688c048 ; 
00688C038  ldr      x8, [x2, #0x60]
00688C03C  mov      x0, x19
00688C040  mov      x1, x20
00688C044  blr      x8
00688C048  mov      x0, x19
00688C04C  mov      x1, xzr
00688C050  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C054  adrp     x21, #0x959c000
00688C058  ldrb     w8, [x21, #0x428]
00688C05C  mov      x20, x0
00688C060  cbnz     w8, #0x688c078
00688C064  adrp     x0, #0x8f25000
00688C068  ldr      x0, [x0, #0x338]
00688C06C  bl       #0x382bd14 ; 
00688C070  mov      w8, #1
00688C074  strb     w8, [x21, #0x428]
00688C078  adrp     x8, #0x8f25000
00688C07C  ldr      x8, [x8, #0x338]
00688C080  ldr      x2, [x8]
00688C084  ldrb     w8, [x2, #0x53]
00688C088  tbnz     w8, #5, #0x688c0a0
00688C08C  mov      x0, x19
00688C090  str      x20, [x0, #0xf8]!
00688C094  mov      x1, x20
00688C098  bl       #0x382bcb8 ; 
00688C09C  b        #0x688c0b0 ; 
00688C0A0  ldr      x8, [x2, #0x60]
00688C0A4  mov      x0, x19
00688C0A8  mov      x1, x20
00688C0AC  blr      x8
00688C0B0  mov      x0, x19
00688C0B4  mov      x1, xzr
00688C0B8  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
00688C0BC  adrp     x21, #0x959c000
00688C0C0  ldrb     w8, [x21, #0x429]
00688C0C4  mov      x20, x0
00688C0C8  cbnz     w8, #0x688c0e0
00688C0CC  adrp     x0, #0x8f25000
00688C0D0  ldr      x0, [x0, #0x340]
00688C0D4  bl       #0x382bd14 ; 
00688C0D8  mov      w8, #1
00688C0DC  strb     w8, [x21, #0x429]
00688C0E0  adrp     x8, #0x8f25000
00688C0E4  ldr      x8, [x8, #0x340]
00688C0E8  ldr      x2, [x8]
00688C0EC  ldrb     w8, [x2, #0x53]
00688C0F0  tbnz     w8, #5, #0x688c108
00688C0F4  add      x0, x19, #0x100
00688C0F8  mov      x1, x20
00688C0FC  str      x20, [x19, #0x100]
00688C100  bl       #0x382bcb8 ; 
00688C104  b        #0x688c118 ; 
00688C108  ldr      x8, [x2, #0x60]
00688C10C  mov      x0, x19
00688C110  mov      x1, x20
00688C114  blr      x8
00688C118  mov      x0, x19
00688C11C  mov      x1, xzr
00688C120  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688C124  adrp     x21, #0x959c000
00688C128  ldrb     w8, [x21, #0x42a]
00688C12C  mov      x20, x0
00688C130  cbnz     w8, #0x688c148
00688C134  adrp     x0, #0x8f25000
00688C138  ldr      x0, [x0, #0x348]
00688C13C  bl       #0x382bd14 ; 
00688C140  mov      w8, #1
00688C144  strb     w8, [x21, #0x42a]
00688C148  adrp     x8, #0x8f25000
00688C14C  ldr      x8, [x8, #0x348]
00688C150  ldr      x2, [x8]
00688C154  ldrb     w8, [x2, #0x53]
00688C158  tbnz     w8, #5, #0x688c164
00688C15C  str      x20, [x19, #0x108]
00688C160  b        #0x688c174 ; 
00688C164  ldr      x8, [x2, #0x60]
00688C168  mov      x0, x19
00688C16C  mov      x1, x20
00688C170  blr      x8
00688C174  mov      x0, x19
00688C178  mov      x1, xzr
00688C17C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688C180  adrp     x21, #0x959c000
00688C184  ldrb     w8, [x21, #0x42b]
00688C188  mov      w20, w0
00688C18C  cbnz     w8, #0x688c1a4
00688C190  adrp     x0, #0x8f25000
00688C194  ldr      x0, [x0, #0x350]
00688C198  bl       #0x382bd14 ; 
00688C19C  mov      w8, #1
00688C1A0  strb     w8, [x21, #0x42b]
00688C1A4  adrp     x8, #0x8f25000
00688C1A8  ldr      x8, [x8, #0x350]
00688C1AC  ldr      x2, [x8]
00688C1B0  ldrb     w8, [x2, #0x53]
00688C1B4  tbnz     w8, #5, #0x688c1c0
00688C1B8  str      w20, [x19, #0x110]
00688C1BC  b        #0x688c1d0 ; 
00688C1C0  ldr      x8, [x2, #0x60]
00688C1C4  mov      x0, x19
00688C1C8  mov      w1, w20
00688C1CC  blr      x8
00688C1D0  mov      x0, x19
00688C1D4  mov      x1, xzr
00688C1D8  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
00688C1DC  adrp     x21, #0x959c000
00688C1E0  ldrb     w8, [x21, #0x42c]
00688C1E4  mov      x20, x0
00688C1E8  cbnz     w8, #0x688c200
00688C1EC  adrp     x0, #0x8f25000
00688C1F0  ldr      x0, [x0, #0x358]
00688C1F4  bl       #0x382bd14 ; 
00688C1F8  mov      w8, #1
00688C1FC  strb     w8, [x21, #0x42c]
00688C200  adrp     x8, #0x8f25000
00688C204  ldr      x8, [x8, #0x358]
00688C208  ldr      x2, [x8]
00688C20C  ldrb     w8, [x2, #0x53]
00688C210  tbnz     w8, #5, #0x688c228
00688C214  add      x0, x19, #0x118
00688C218  mov      x1, x20
00688C21C  str      x20, [x19, #0x118]
00688C220  bl       #0x382bcb8 ; 
00688C224  b        #0x688c238 ; 
00688C228  ldr      x8, [x2, #0x60]
00688C22C  mov      x0, x19
00688C230  mov      x1, x20
00688C234  blr      x8
00688C238  mov      x0, x19
00688C23C  mov      x1, xzr
00688C240  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
00688C244  adrp     x21, #0x959c000
00688C248  ldrb     w8, [x21, #0x42d]
00688C24C  mov      x20, x0
00688C250  cbnz     w8, #0x688c268
00688C254  adrp     x0, #0x8f25000
00688C258  ldr      x0, [x0, #0x360]
00688C25C  bl       #0x382bd14 ; 
00688C260  mov      w8, #1
00688C264  strb     w8, [x21, #0x42d]
00688C268  adrp     x8, #0x8f25000
00688C26C  ldr      x8, [x8, #0x360]
00688C270  ldr      x2, [x8]
00688C274  ldrb     w8, [x2, #0x53]
00688C278  tbnz     w8, #5, #0x688c290
00688C27C  add      x0, x19, #0x120
00688C280  mov      x1, x20
00688C284  str      x20, [x19, #0x120]
00688C288  bl       #0x382bcb8 ; 
00688C28C  b        #0x688c2a0 ; 
00688C290  ldr      x8, [x2, #0x60]
00688C294  mov      x0, x19
00688C298  mov      x1, x20
00688C29C  blr      x8
00688C2A0  mov      x0, x19
00688C2A4  mov      x1, xzr
00688C2A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688C2AC  adrp     x21, #0x959c000
00688C2B0  ldrb     w8, [x21, #0x42e]
00688C2B4  mov      w20, w0
00688C2B8  cbnz     w8, #0x688c2d0
00688C2BC  adrp     x0, #0x8f25000
00688C2C0  ldr      x0, [x0, #0x370]
00688C2C4  bl       #0x382bd14 ; 
00688C2C8  mov      w8, #1
00688C2CC  strb     w8, [x21, #0x42e]
00688C2D0  adrp     x8, #0x8f25000
00688C2D4  ldr      x8, [x8, #0x370]
00688C2D8  ldr      x2, [x8]
00688C2DC  ldrb     w8, [x2, #0x53]
00688C2E0  tbnz     w8, #5, #0x688c2ec
00688C2E4  str      w20, [x19, #0x128]
00688C2E8  b        #0x688c2fc ; 
00688C2EC  ldr      x8, [x2, #0x60]
00688C2F0  mov      x0, x19
00688C2F4  mov      w1, w20
00688C2F8  blr      x8
00688C2FC  mov      x0, x19
00688C300  mov      x1, xzr
00688C304  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C308  adrp     x21, #0x959c000
00688C30C  ldrb     w8, [x21, #0x42f]
00688C310  mov      x20, x0
00688C314  cbnz     w8, #0x688c32c
00688C318  adrp     x0, #0x8f25000
00688C31C  ldr      x0, [x0, #0x378]
00688C320  bl       #0x382bd14 ; 
00688C324  mov      w8, #1
00688C328  strb     w8, [x21, #0x42f]
00688C32C  adrp     x8, #0x8f25000
00688C330  ldr      x8, [x8, #0x378]
00688C334  ldr      x2, [x8]
00688C338  ldrb     w8, [x2, #0x53]
00688C33C  tbnz     w8, #5, #0x688c354
00688C340  add      x0, x19, #0x130
00688C344  mov      x1, x20
00688C348  str      x20, [x19, #0x130]
00688C34C  bl       #0x382bcb8 ; 
00688C350  b        #0x688c364 ; 
00688C354  ldr      x8, [x2, #0x60]
00688C358  mov      x0, x19
00688C35C  mov      x1, x20
00688C360  blr      x8
00688C364  mov      x0, x19
00688C368  mov      x1, xzr
00688C36C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C370  adrp     x21, #0x959c000
00688C374  ldrb     w8, [x21, #0x430]
00688C378  mov      x20, x0
00688C37C  cbnz     w8, #0x688c394
00688C380  adrp     x0, #0x8f25000
00688C384  ldr      x0, [x0, #0x380]
00688C388  bl       #0x382bd14 ; 
00688C38C  mov      w8, #1
00688C390  strb     w8, [x21, #0x430]
00688C394  adrp     x8, #0x8f25000
00688C398  ldr      x8, [x8, #0x380]
00688C39C  ldr      x2, [x8]
00688C3A0  ldrb     w8, [x2, #0x53]
00688C3A4  tbnz     w8, #5, #0x688c3bc
00688C3A8  add      x0, x19, #0x138
00688C3AC  mov      x1, x20
00688C3B0  str      x20, [x19, #0x138]
00688C3B4  bl       #0x382bcb8 ; 
00688C3B8  b        #0x688c3cc ; 
00688C3BC  ldr      x8, [x2, #0x60]
00688C3C0  mov      x0, x19
00688C3C4  mov      x1, x20
00688C3C8  blr      x8
00688C3CC  mov      x0, x19
00688C3D0  mov      x1, xzr
00688C3D4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C3D8  adrp     x21, #0x959c000
00688C3DC  ldrb     w8, [x21, #0x431]
00688C3E0  mov      x20, x0
00688C3E4  cbnz     w8, #0x688c3fc
00688C3E8  adrp     x0, #0x8f25000
00688C3EC  ldr      x0, [x0, #0x388]
00688C3F0  bl       #0x382bd14 ; 
00688C3F4  mov      w8, #1
00688C3F8  strb     w8, [x21, #0x431]
00688C3FC  adrp     x8, #0x8f25000
00688C400  ldr      x8, [x8, #0x388]
00688C404  ldr      x2, [x8]
00688C408  ldrb     w8, [x2, #0x53]
00688C40C  tbnz     w8, #5, #0x688c424
00688C410  add      x0, x19, #0x140
00688C414  mov      x1, x20
00688C418  str      x20, [x19, #0x140]
00688C41C  bl       #0x382bcb8 ; 
00688C420  b        #0x688c434 ; 
00688C424  ldr      x8, [x2, #0x60]
00688C428  mov      x0, x19
00688C42C  mov      x1, x20
00688C430  blr      x8
00688C434  mov      x0, x19
00688C438  mov      x1, xzr
00688C43C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C440  adrp     x21, #0x959c000
00688C444  ldrb     w8, [x21, #0x432]
00688C448  mov      x20, x0
00688C44C  cbnz     w8, #0x688c464
00688C450  adrp     x0, #0x8f25000
00688C454  ldr      x0, [x0, #0x390]
00688C458  bl       #0x382bd14 ; 
00688C45C  mov      w8, #1
00688C460  strb     w8, [x21, #0x432]
00688C464  adrp     x8, #0x8f25000
00688C468  ldr      x8, [x8, #0x390]
00688C46C  ldr      x2, [x8]
00688C470  ldrb     w8, [x2, #0x53]
00688C474  tbnz     w8, #5, #0x688c48c
00688C478  add      x0, x19, #0x148
00688C47C  mov      x1, x20
00688C480  str      x20, [x19, #0x148]
00688C484  bl       #0x382bcb8 ; 
00688C488  b        #0x688c49c ; 
00688C48C  ldr      x8, [x2, #0x60]
00688C490  mov      x0, x19
00688C494  mov      x1, x20
00688C498  blr      x8
00688C49C  mov      x0, x19
00688C4A0  mov      x1, xzr
00688C4A4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C4A8  adrp     x21, #0x959c000
00688C4AC  ldrb     w8, [x21, #0x433]
00688C4B0  mov      x20, x0
00688C4B4  cbnz     w8, #0x688c4cc
00688C4B8  adrp     x0, #0x8f25000
00688C4BC  ldr      x0, [x0, #0x398]
00688C4C0  bl       #0x382bd14 ; 
00688C4C4  mov      w8, #1
00688C4C8  strb     w8, [x21, #0x433]
00688C4CC  adrp     x8, #0x8f25000
00688C4D0  ldr      x8, [x8, #0x398]
00688C4D4  ldr      x2, [x8]
00688C4D8  ldrb     w8, [x2, #0x53]
00688C4DC  tbnz     w8, #5, #0x688c4f4
00688C4E0  add      x0, x19, #0x150
00688C4E4  mov      x1, x20
00688C4E8  str      x20, [x19, #0x150]
00688C4EC  bl       #0x382bcb8 ; 
00688C4F0  b        #0x688c504 ; 
00688C4F4  ldr      x8, [x2, #0x60]
00688C4F8  mov      x0, x19
00688C4FC  mov      x1, x20
00688C500  blr      x8
00688C504  mov      x0, x19
00688C508  mov      x1, xzr
00688C50C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C510  adrp     x21, #0x959c000
00688C514  ldrb     w8, [x21, #0x434]
00688C518  mov      x20, x0
00688C51C  cbnz     w8, #0x688c534
00688C520  adrp     x0, #0x8f25000
00688C524  ldr      x0, [x0, #0x3a0]
00688C528  bl       #0x382bd14 ; 
00688C52C  mov      w8, #1
00688C530  strb     w8, [x21, #0x434]
00688C534  adrp     x8, #0x8f25000
00688C538  ldr      x8, [x8, #0x3a0]
00688C53C  ldr      x2, [x8]
00688C540  ldrb     w8, [x2, #0x53]
00688C544  tbnz     w8, #5, #0x688c55c
00688C548  add      x0, x19, #0x158
00688C54C  mov      x1, x20
00688C550  str      x20, [x19, #0x158]
00688C554  bl       #0x382bcb8 ; 
00688C558  b        #0x688c56c ; 
00688C55C  ldr      x8, [x2, #0x60]
00688C560  mov      x0, x19
00688C564  mov      x1, x20
00688C568  blr      x8
00688C56C  mov      x0, x19
00688C570  mov      x1, xzr
00688C574  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688C578  adrp     x21, #0x959c000
00688C57C  ldrb     w8, [x21, #0x435]
00688C580  mov      x20, x0
00688C584  cbnz     w8, #0x688c59c
00688C588  adrp     x0, #0x8f25000
00688C58C  ldr      x0, [x0, #0x3a8]
00688C590  bl       #0x382bd14 ; 
00688C594  mov      w8, #1
00688C598  strb     w8, [x21, #0x435]
00688C59C  adrp     x8, #0x8f25000
00688C5A0  ldr      x8, [x8, #0x3a8]
00688C5A4  ldr      x2, [x8]
00688C5A8  ldrb     w8, [x2, #0x53]
00688C5AC  tbnz     w8, #5, #0x688c5c4
00688C5B0  add      x0, x19, #0x160
00688C5B4  mov      x1, x20
00688C5B8  str      x20, [x19, #0x160]
00688C5BC  bl       #0x382bcb8 ; 
00688C5C0  b        #0x688c5d4 ; 
00688C5C4  ldr      x8, [x2, #0x60]
00688C5C8  mov      x0, x19
00688C5CC  mov      x1, x20
00688C5D0  blr      x8
00688C5D4  mov      x0, x19
00688C5D8  mov      x1, xzr
00688C5DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688C5E0  adrp     x21, #0x959c000
00688C5E4  ldrb     w8, [x21, #0x436]
00688C5E8  mov      w20, w0
00688C5EC  cbnz     w8, #0x688c604
00688C5F0  adrp     x0, #0x8f25000
00688C5F4  ldr      x0, [x0, #0x3b0]
00688C5F8  bl       #0x382bd14 ; 
00688C5FC  mov      w8, #1
00688C600  strb     w8, [x21, #0x436]
00688C604  adrp     x8, #0x8f25000
00688C608  ldr      x8, [x8, #0x3b0]
00688C60C  ldr      x2, [x8]
00688C610  ldrb     w8, [x2, #0x53]
00688C614  tbnz     w8, #5, #0x688c620
00688C618  str      w20, [x19, #0x168]
00688C61C  b        #0x688c630 ; 
00688C620  ldr      x8, [x2, #0x60]
00688C624  mov      x0, x19
00688C628  mov      w1, w20
00688C62C  blr      x8
00688C630  mov      x0, x19
00688C634  mov      x1, xzr
00688C638  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688C63C  adrp     x21, #0x959c000
00688C640  ldrb     w8, [x21, #0x437]
00688C644  mov      w20, w0
00688C648  cbnz     w8, #0x688c660
00688C64C  adrp     x0, #0x8f25000
00688C650  ldr      x0, [x0, #0x3c0]
00688C654  bl       #0x382bd14 ; 
00688C658  mov      w8, #1
00688C65C  strb     w8, [x21, #0x437]
00688C660  adrp     x8, #0x8f25000
00688C664  ldr      x8, [x8, #0x3c0]
00688C668  ldr      x2, [x8]
00688C66C  ldrb     w8, [x2, #0x53]
00688C670  tbnz     w8, #5, #0x688c67c
00688C674  str      w20, [x19, #0x16c]
00688C678  b        #0x688c68c ; 
00688C67C  ldr      x8, [x2, #0x60]
00688C680  mov      x0, x19
00688C684  mov      w1, w20
00688C688  blr      x8
00688C68C  mov      x0, x19
00688C690  mov      x1, xzr
00688C694  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688C698  adrp     x21, #0x959c000
00688C69C  ldrb     w8, [x21, #0x438]
00688C6A0  mov      x20, x0
00688C6A4  cbnz     w8, #0x688c6bc
00688C6A8  adrp     x0, #0x8f25000
00688C6AC  ldr      x0, [x0, #0x3d0]
00688C6B0  bl       #0x382bd14 ; 
00688C6B4  mov      w8, #1
00688C6B8  strb     w8, [x21, #0x438]
00688C6BC  adrp     x8, #0x8f25000
00688C6C0  ldr      x8, [x8, #0x3d0]
00688C6C4  ldr      x2, [x8]
00688C6C8  ldrb     w8, [x2, #0x53]
00688C6CC  tbnz     w8, #5, #0x688c6d8
00688C6D0  str      x20, [x19, #0x170]
00688C6D4  b        #0x688c6e8 ; 
00688C6D8  ldr      x8, [x2, #0x60]
00688C6DC  mov      x0, x19
00688C6E0  mov      x1, x20
00688C6E4  blr      x8
00688C6E8  mov      x0, x19
00688C6EC  mov      x1, xzr
00688C6F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688C6F4  adrp     x21, #0x959c000
00688C6F8  ldrb     w8, [x21, #0x439]
00688C6FC  mov      w20, w0
00688C700  cbnz     w8, #0x688c718
00688C704  adrp     x0, #0x8f25000
00688C708  ldr      x0, [x0, #0x3d8]
00688C70C  bl       #0x382bd14 ; 
00688C710  mov      w8, #1
00688C714  strb     w8, [x21, #0x439]
00688C718  adrp     x8, #0x8f25000
00688C71C  ldr      x8, [x8, #0x3d8]
00688C720  ldr      x2, [x8]
00688C724  ldrb     w8, [x2, #0x53]
00688C728  tbnz     w8, #5, #0x688c734
00688C72C  str      w20, [x19, #0x178]
00688C730  b        #0x688c744 ; 
00688C734  ldr      x8, [x2, #0x60]
00688C738  mov      x0, x19
00688C73C  mov      w1, w20
00688C740  blr      x8
00688C744  ldp      x20, x19, [sp, #0x10]
00688C748  mov      w0, #1
00688C74C  ldp      x30, x21, [sp], #0x20
00688C750  ret      

