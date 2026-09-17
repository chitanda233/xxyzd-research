; LocalModels.Bean.EventDiving_DiveInsertGrid$$readImpl
; RVA 0x6A6E7FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6E7FC  stp      x30, x21, [sp, #-0x20]!
006A6E800  stp      x20, x19, [sp, #0x10]
006A6E804  adrp     x20, #0x959d000
006A6E808  adrp     x21, #0x8f37000
006A6E80C  ldrb     w8, [x20, #0xd65]
006A6E810  ldr      x21, [x21, #0x418]
006A6E814  mov      x19, x0
006A6E818  tbnz     w8, #0, #0x6a6e830
006A6E81C  adrp     x0, #0x8f37000
006A6E820  ldr      x0, [x0, #0x418]
006A6E824  bl       #0x382bd14 ; 
006A6E828  mov      w8, #1
006A6E82C  strb     w8, [x20, #0xd65]
006A6E830  ldr      x1, [x21]
006A6E834  ldrb     w8, [x1, #0x53]
006A6E838  tbnz     w8, #5, #0x6a6e888
006A6E83C  mov      x0, x19
006A6E840  mov      x1, xzr
006A6E844  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6E848  adrp     x21, #0x959e000
006A6E84C  ldrb     w8, [x21, #0x43e]
006A6E850  mov      w20, w0
006A6E854  cbnz     w8, #0x6a6e86c
006A6E858  adrp     x0, #0x8f37000
006A6E85C  ldr      x0, [x0, #0x3f0]
006A6E860  bl       #0x382bd14 ; 
006A6E864  mov      w8, #1
006A6E868  strb     w8, [x21, #0x43e]
006A6E86C  adrp     x8, #0x8f37000
006A6E870  ldr      x8, [x8, #0x3f0]
006A6E874  ldr      x2, [x8]
006A6E878  ldrb     w8, [x2, #0x53]
006A6E87C  tbnz     w8, #5, #0x6a6e89c
006A6E880  str      w20, [x19, #0x20]
006A6E884  b        #0x6a6e8ac ; 
006A6E888  ldr      x2, [x1, #0x60]
006A6E88C  mov      x0, x19
006A6E890  ldp      x20, x19, [sp, #0x10]
006A6E894  ldp      x30, x21, [sp], #0x20
006A6E898  br       x2
006A6E89C  ldr      x8, [x2, #0x60]
006A6E8A0  mov      x0, x19
006A6E8A4  mov      w1, w20
006A6E8A8  blr      x8
006A6E8AC  mov      x0, x19
006A6E8B0  mov      x1, xzr
006A6E8B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6E8B8  adrp     x21, #0x959e000
006A6E8BC  ldrb     w8, [x21, #0x43f]
006A6E8C0  mov      w20, w0
006A6E8C4  cbnz     w8, #0x6a6e8dc
006A6E8C8  adrp     x0, #0x8f37000
006A6E8CC  ldr      x0, [x0, #0x400]
006A6E8D0  bl       #0x382bd14 ; 
006A6E8D4  mov      w8, #1
006A6E8D8  strb     w8, [x21, #0x43f]
006A6E8DC  adrp     x8, #0x8f37000
006A6E8E0  ldr      x8, [x8, #0x400]
006A6E8E4  ldr      x2, [x8]
006A6E8E8  ldrb     w8, [x2, #0x53]
006A6E8EC  tbnz     w8, #5, #0x6a6e8f8
006A6E8F0  str      w20, [x19, #0x24]
006A6E8F4  b        #0x6a6e908 ; 
006A6E8F8  ldr      x8, [x2, #0x60]
006A6E8FC  mov      x0, x19
006A6E900  mov      w1, w20
006A6E904  blr      x8
006A6E908  mov      x0, x19
006A6E90C  mov      x1, xzr
006A6E910  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6E914  adrp     x21, #0x959e000
006A6E918  ldrb     w8, [x21, #0x440]
006A6E91C  mov      x20, x0
006A6E920  cbnz     w8, #0x6a6e938
006A6E924  adrp     x0, #0x8f37000
006A6E928  ldr      x0, [x0, #0x410]
006A6E92C  bl       #0x382bd14 ; 
006A6E930  mov      w8, #1
006A6E934  strb     w8, [x21, #0x440]
006A6E938  adrp     x8, #0x8f37000
006A6E93C  ldr      x8, [x8, #0x410]
006A6E940  ldr      x2, [x8]
006A6E944  ldrb     w8, [x2, #0x53]
006A6E948  tbnz     w8, #5, #0x6a6e960
006A6E94C  str      x20, [x19, #0x28]!
006A6E950  mov      x0, x19
006A6E954  mov      x1, x20
006A6E958  bl       #0x382bcb8 ; 
006A6E95C  b        #0x6a6e970 ; 
006A6E960  ldr      x8, [x2, #0x60]
006A6E964  mov      x0, x19
006A6E968  mov      x1, x20
006A6E96C  blr      x8
006A6E970  ldp      x20, x19, [sp, #0x10]
006A6E974  mov      w0, #1
006A6E978  ldp      x30, x21, [sp], #0x20
006A6E97C  ret      

