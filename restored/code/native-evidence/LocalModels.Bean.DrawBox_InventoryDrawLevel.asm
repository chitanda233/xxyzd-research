; LocalModels.Bean.DrawBox_InventoryDrawLevel$$readImpl
; RVA 0x6A5B584; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5B584  stp      x30, x21, [sp, #-0x20]!
006A5B588  stp      x20, x19, [sp, #0x10]
006A5B58C  adrp     x20, #0x959d000
006A5B590  adrp     x21, #0x8f36000
006A5B594  ldrb     w8, [x20, #0xb73]
006A5B598  ldr      x21, [x21, #0x640]
006A5B59C  mov      x19, x0
006A5B5A0  tbnz     w8, #0, #0x6a5b5b8
006A5B5A4  adrp     x0, #0x8f36000
006A5B5A8  ldr      x0, [x0, #0x640]
006A5B5AC  bl       #0x382bd14 ; 
006A5B5B0  mov      w8, #1
006A5B5B4  strb     w8, [x20, #0xb73]
006A5B5B8  ldr      x1, [x21]
006A5B5BC  ldrb     w8, [x1, #0x53]
006A5B5C0  tbnz     w8, #5, #0x6a5b610
006A5B5C4  mov      x0, x19
006A5B5C8  mov      x1, xzr
006A5B5CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5B5D0  adrp     x21, #0x959e000
006A5B5D4  ldrb     w8, [x21, #0x361]
006A5B5D8  mov      w20, w0
006A5B5DC  cbnz     w8, #0x6a5b5f4
006A5B5E0  adrp     x0, #0x8f36000
006A5B5E4  ldr      x0, [x0, #0x5c8]
006A5B5E8  bl       #0x382bd14 ; 
006A5B5EC  mov      w8, #1
006A5B5F0  strb     w8, [x21, #0x361]
006A5B5F4  adrp     x8, #0x8f36000
006A5B5F8  ldr      x8, [x8, #0x5c8]
006A5B5FC  ldr      x2, [x8]
006A5B600  ldrb     w8, [x2, #0x53]
006A5B604  tbnz     w8, #5, #0x6a5b624
006A5B608  str      w20, [x19, #0x20]
006A5B60C  b        #0x6a5b634 ; 
006A5B610  ldr      x2, [x1, #0x60]
006A5B614  mov      x0, x19
006A5B618  ldp      x20, x19, [sp, #0x10]
006A5B61C  ldp      x30, x21, [sp], #0x20
006A5B620  br       x2
006A5B624  ldr      x8, [x2, #0x60]
006A5B628  mov      x0, x19
006A5B62C  mov      w1, w20
006A5B630  blr      x8
006A5B634  mov      x0, x19
006A5B638  mov      x1, xzr
006A5B63C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5B640  adrp     x21, #0x959e000
006A5B644  ldrb     w8, [x21, #0x362]
006A5B648  mov      w20, w0
006A5B64C  cbnz     w8, #0x6a5b664
006A5B650  adrp     x0, #0x8f36000
006A5B654  ldr      x0, [x0, #0x5d8]
006A5B658  bl       #0x382bd14 ; 
006A5B65C  mov      w8, #1
006A5B660  strb     w8, [x21, #0x362]
006A5B664  adrp     x8, #0x8f36000
006A5B668  ldr      x8, [x8, #0x5d8]
006A5B66C  ldr      x2, [x8]
006A5B670  ldrb     w8, [x2, #0x53]
006A5B674  tbnz     w8, #5, #0x6a5b680
006A5B678  str      w20, [x19, #0x24]
006A5B67C  b        #0x6a5b690 ; 
006A5B680  ldr      x8, [x2, #0x60]
006A5B684  mov      x0, x19
006A5B688  mov      w1, w20
006A5B68C  blr      x8
006A5B690  mov      x0, x19
006A5B694  mov      x1, xzr
006A5B698  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A5B69C  adrp     x21, #0x959e000
006A5B6A0  ldrb     w8, [x21, #0x363]
006A5B6A4  mov      x20, x0
006A5B6A8  cbnz     w8, #0x6a5b6c0
006A5B6AC  adrp     x0, #0x8f36000
006A5B6B0  ldr      x0, [x0, #0x5e8]
006A5B6B4  bl       #0x382bd14 ; 
006A5B6B8  mov      w8, #1
006A5B6BC  strb     w8, [x21, #0x363]
006A5B6C0  adrp     x8, #0x8f36000
006A5B6C4  ldr      x8, [x8, #0x5e8]
006A5B6C8  ldr      x2, [x8]
006A5B6CC  ldrb     w8, [x2, #0x53]
006A5B6D0  tbnz     w8, #5, #0x6a5b6e8
006A5B6D4  mov      x0, x19
006A5B6D8  str      x20, [x0, #0x28]!
006A5B6DC  mov      x1, x20
006A5B6E0  bl       #0x382bcb8 ; 
006A5B6E4  b        #0x6a5b6f8 ; 
006A5B6E8  ldr      x8, [x2, #0x60]
006A5B6EC  mov      x0, x19
006A5B6F0  mov      x1, x20
006A5B6F4  blr      x8
006A5B6F8  mov      x0, x19
006A5B6FC  mov      x1, xzr
006A5B700  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A5B704  adrp     x21, #0x959e000
006A5B708  ldrb     w8, [x21, #0x364]
006A5B70C  mov      x20, x0
006A5B710  cbnz     w8, #0x6a5b728
006A5B714  adrp     x0, #0x8f36000
006A5B718  ldr      x0, [x0, #0x5f8]
006A5B71C  bl       #0x382bd14 ; 
006A5B720  mov      w8, #1
006A5B724  strb     w8, [x21, #0x364]
006A5B728  adrp     x8, #0x8f36000
006A5B72C  ldr      x8, [x8, #0x5f8]
006A5B730  ldr      x2, [x8]
006A5B734  ldrb     w8, [x2, #0x53]
006A5B738  tbnz     w8, #5, #0x6a5b750
006A5B73C  mov      x0, x19
006A5B740  str      x20, [x0, #0x30]!
006A5B744  mov      x1, x20
006A5B748  bl       #0x382bcb8 ; 
006A5B74C  b        #0x6a5b760 ; 
006A5B750  ldr      x8, [x2, #0x60]
006A5B754  mov      x0, x19
006A5B758  mov      x1, x20
006A5B75C  blr      x8
006A5B760  mov      x0, x19
006A5B764  mov      x1, xzr
006A5B768  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A5B76C  adrp     x21, #0x959e000
006A5B770  ldrb     w8, [x21, #0x365]
006A5B774  mov      x20, x0
006A5B778  cbnz     w8, #0x6a5b790
006A5B77C  adrp     x0, #0x8f36000
006A5B780  ldr      x0, [x0, #0x608]
006A5B784  bl       #0x382bd14 ; 
006A5B788  mov      w8, #1
006A5B78C  strb     w8, [x21, #0x365]
006A5B790  adrp     x8, #0x8f36000
006A5B794  ldr      x8, [x8, #0x608]
006A5B798  ldr      x2, [x8]
006A5B79C  ldrb     w8, [x2, #0x53]
006A5B7A0  tbnz     w8, #5, #0x6a5b7b8
006A5B7A4  mov      x0, x19
006A5B7A8  str      x20, [x0, #0x38]!
006A5B7AC  mov      x1, x20
006A5B7B0  bl       #0x382bcb8 ; 
006A5B7B4  b        #0x6a5b7c8 ; 
006A5B7B8  ldr      x8, [x2, #0x60]
006A5B7BC  mov      x0, x19
006A5B7C0  mov      x1, x20
006A5B7C4  blr      x8
006A5B7C8  mov      x0, x19
006A5B7CC  mov      x1, xzr
006A5B7D0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A5B7D4  adrp     x21, #0x959e000
006A5B7D8  ldrb     w8, [x21, #0x366]
006A5B7DC  mov      x20, x0
006A5B7E0  cbnz     w8, #0x6a5b7f8
006A5B7E4  adrp     x0, #0x8f36000
006A5B7E8  ldr      x0, [x0, #0x618]
006A5B7EC  bl       #0x382bd14 ; 
006A5B7F0  mov      w8, #1
006A5B7F4  strb     w8, [x21, #0x366]
006A5B7F8  adrp     x8, #0x8f36000
006A5B7FC  ldr      x8, [x8, #0x618]
006A5B800  ldr      x2, [x8]
006A5B804  ldrb     w8, [x2, #0x53]
006A5B808  tbnz     w8, #5, #0x6a5b820
006A5B80C  mov      x0, x19
006A5B810  str      x20, [x0, #0x40]!
006A5B814  mov      x1, x20
006A5B818  bl       #0x382bcb8 ; 
006A5B81C  b        #0x6a5b830 ; 
006A5B820  ldr      x8, [x2, #0x60]
006A5B824  mov      x0, x19
006A5B828  mov      x1, x20
006A5B82C  blr      x8
006A5B830  mov      x0, x19
006A5B834  mov      x1, xzr
006A5B838  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A5B83C  adrp     x21, #0x959e000
006A5B840  ldrb     w8, [x21, #0x367]
006A5B844  mov      x20, x0
006A5B848  cbnz     w8, #0x6a5b860
006A5B84C  adrp     x0, #0x8f36000
006A5B850  ldr      x0, [x0, #0x628]
006A5B854  bl       #0x382bd14 ; 
006A5B858  mov      w8, #1
006A5B85C  strb     w8, [x21, #0x367]
006A5B860  adrp     x8, #0x8f36000
006A5B864  ldr      x8, [x8, #0x628]
006A5B868  ldr      x2, [x8]
006A5B86C  ldrb     w8, [x2, #0x53]
006A5B870  tbnz     w8, #5, #0x6a5b888
006A5B874  mov      x0, x19
006A5B878  str      x20, [x0, #0x48]!
006A5B87C  mov      x1, x20
006A5B880  bl       #0x382bcb8 ; 
006A5B884  b        #0x6a5b898 ; 
006A5B888  ldr      x8, [x2, #0x60]
006A5B88C  mov      x0, x19
006A5B890  mov      x1, x20
006A5B894  blr      x8
006A5B898  mov      x0, x19
006A5B89C  mov      x1, xzr
006A5B8A0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A5B8A4  adrp     x21, #0x959e000
006A5B8A8  ldrb     w8, [x21, #0x368]
006A5B8AC  mov      x20, x0
006A5B8B0  cbnz     w8, #0x6a5b8c8
006A5B8B4  adrp     x0, #0x8f36000
006A5B8B8  ldr      x0, [x0, #0x638]
006A5B8BC  bl       #0x382bd14 ; 
006A5B8C0  mov      w8, #1
006A5B8C4  strb     w8, [x21, #0x368]
006A5B8C8  adrp     x8, #0x8f36000
006A5B8CC  ldr      x8, [x8, #0x638]
006A5B8D0  ldr      x2, [x8]
006A5B8D4  ldrb     w8, [x2, #0x53]
006A5B8D8  tbnz     w8, #5, #0x6a5b8f0
006A5B8DC  str      x20, [x19, #0x50]!
006A5B8E0  mov      x0, x19
006A5B8E4  mov      x1, x20
006A5B8E8  bl       #0x382bcb8 ; 
006A5B8EC  b        #0x6a5b900 ; 
006A5B8F0  ldr      x8, [x2, #0x60]
006A5B8F4  mov      x0, x19
006A5B8F8  mov      x1, x20
006A5B8FC  blr      x8
006A5B900  ldp      x20, x19, [sp, #0x10]
006A5B904  mov      w0, #1
006A5B908  ldp      x30, x21, [sp], #0x20
006A5B90C  ret      

