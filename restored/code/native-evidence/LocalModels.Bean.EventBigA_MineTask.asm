; LocalModels.Bean.EventBigA_MineTask$$readImpl
; RVA 0x6A6A760; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6A760  stp      x30, x21, [sp, #-0x20]!
006A6A764  stp      x20, x19, [sp, #0x10]
006A6A768  adrp     x20, #0x959d000
006A6A76C  adrp     x21, #0x8f37000
006A6A770  ldrb     w8, [x20, #0xcfa]
006A6A774  ldr      x21, [x21, #0xf8]
006A6A778  mov      x19, x0
006A6A77C  tbnz     w8, #0, #0x6a6a794
006A6A780  adrp     x0, #0x8f37000
006A6A784  ldr      x0, [x0, #0xf8]
006A6A788  bl       #0x382bd14 ; 
006A6A78C  mov      w8, #1
006A6A790  strb     w8, [x20, #0xcfa]
006A6A794  ldr      x1, [x21]
006A6A798  ldrb     w8, [x1, #0x53]
006A6A79C  tbnz     w8, #5, #0x6a6a7ec
006A6A7A0  mov      x0, x19
006A6A7A4  mov      x1, xzr
006A6A7A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6A7AC  adrp     x21, #0x959e000
006A6A7B0  ldrb     w8, [x21, #0x412]
006A6A7B4  mov      w20, w0
006A6A7B8  cbnz     w8, #0x6a6a7d0
006A6A7BC  adrp     x0, #0x8f37000
006A6A7C0  ldr      x0, [x0, #0xc0]
006A6A7C4  bl       #0x382bd14 ; 
006A6A7C8  mov      w8, #1
006A6A7CC  strb     w8, [x21, #0x412]
006A6A7D0  adrp     x8, #0x8f37000
006A6A7D4  ldr      x8, [x8, #0xc0]
006A6A7D8  ldr      x2, [x8]
006A6A7DC  ldrb     w8, [x2, #0x53]
006A6A7E0  tbnz     w8, #5, #0x6a6a800
006A6A7E4  str      w20, [x19, #0x20]
006A6A7E8  b        #0x6a6a810 ; 
006A6A7EC  ldr      x2, [x1, #0x60]
006A6A7F0  mov      x0, x19
006A6A7F4  ldp      x20, x19, [sp, #0x10]
006A6A7F8  ldp      x30, x21, [sp], #0x20
006A6A7FC  br       x2
006A6A800  ldr      x8, [x2, #0x60]
006A6A804  mov      x0, x19
006A6A808  mov      w1, w20
006A6A80C  blr      x8
006A6A810  mov      x0, x19
006A6A814  mov      x1, xzr
006A6A818  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6A81C  adrp     x21, #0x959e000
006A6A820  ldrb     w8, [x21, #0x413]
006A6A824  mov      w20, w0
006A6A828  cbnz     w8, #0x6a6a840
006A6A82C  adrp     x0, #0x8f37000
006A6A830  ldr      x0, [x0, #0xd0]
006A6A834  bl       #0x382bd14 ; 
006A6A838  mov      w8, #1
006A6A83C  strb     w8, [x21, #0x413]
006A6A840  adrp     x8, #0x8f37000
006A6A844  ldr      x8, [x8, #0xd0]
006A6A848  ldr      x2, [x8]
006A6A84C  ldrb     w8, [x2, #0x53]
006A6A850  tbnz     w8, #5, #0x6a6a85c
006A6A854  str      w20, [x19, #0x24]
006A6A858  b        #0x6a6a86c ; 
006A6A85C  ldr      x8, [x2, #0x60]
006A6A860  mov      x0, x19
006A6A864  mov      w1, w20
006A6A868  blr      x8
006A6A86C  mov      x0, x19
006A6A870  mov      x1, xzr
006A6A874  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6A878  adrp     x21, #0x959e000
006A6A87C  ldrb     w8, [x21, #0x414]
006A6A880  mov      w20, w0
006A6A884  cbnz     w8, #0x6a6a89c
006A6A888  adrp     x0, #0x8f37000
006A6A88C  ldr      x0, [x0, #0xe0]
006A6A890  bl       #0x382bd14 ; 
006A6A894  mov      w8, #1
006A6A898  strb     w8, [x21, #0x414]
006A6A89C  adrp     x8, #0x8f37000
006A6A8A0  ldr      x8, [x8, #0xe0]
006A6A8A4  ldr      x2, [x8]
006A6A8A8  ldrb     w8, [x2, #0x53]
006A6A8AC  tbnz     w8, #5, #0x6a6a8b8
006A6A8B0  str      w20, [x19, #0x28]
006A6A8B4  b        #0x6a6a8c8 ; 
006A6A8B8  ldr      x8, [x2, #0x60]
006A6A8BC  mov      x0, x19
006A6A8C0  mov      w1, w20
006A6A8C4  blr      x8
006A6A8C8  mov      x0, x19
006A6A8CC  mov      x1, xzr
006A6A8D0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6A8D4  adrp     x21, #0x959e000
006A6A8D8  ldrb     w8, [x21, #0x415]
006A6A8DC  mov      x20, x0
006A6A8E0  cbnz     w8, #0x6a6a8f8
006A6A8E4  adrp     x0, #0x8f37000
006A6A8E8  ldr      x0, [x0, #0xf0]
006A6A8EC  bl       #0x382bd14 ; 
006A6A8F0  mov      w8, #1
006A6A8F4  strb     w8, [x21, #0x415]
006A6A8F8  adrp     x8, #0x8f37000
006A6A8FC  ldr      x8, [x8, #0xf0]
006A6A900  ldr      x2, [x8]
006A6A904  ldrb     w8, [x2, #0x53]
006A6A908  tbnz     w8, #5, #0x6a6a920
006A6A90C  str      x20, [x19, #0x30]!
006A6A910  mov      x0, x19
006A6A914  mov      x1, x20
006A6A918  bl       #0x382bcb8 ; 
006A6A91C  b        #0x6a6a930 ; 
006A6A920  ldr      x8, [x2, #0x60]
006A6A924  mov      x0, x19
006A6A928  mov      x1, x20
006A6A92C  blr      x8
006A6A930  ldp      x20, x19, [sp, #0x10]
006A6A934  mov      w0, #1
006A6A938  ldp      x30, x21, [sp], #0x20
006A6A93C  ret      

