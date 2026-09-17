; LocalModels.Bean.ABtestManager_manager$$readImpl
; RVA 0x66FC60C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066FC60C  stp      x30, x21, [sp, #-0x20]!
0066FC610  stp      x20, x19, [sp, #0x10]
0066FC614  adrp     x20, #0x959a000
0066FC618  adrp     x21, #0x8f17000
0066FC61C  ldrb     w8, [x20, #0x81f]
0066FC620  ldr      x21, [x21, #0x350]
0066FC624  mov      x19, x0
0066FC628  tbnz     w8, #0, #0x66fc640
0066FC62C  adrp     x0, #0x8f17000
0066FC630  ldr      x0, [x0, #0x350]
0066FC634  bl       #0x382bd14 ; 
0066FC638  mov      w8, #1
0066FC63C  strb     w8, [x20, #0x81f]
0066FC640  ldr      x1, [x21]
0066FC644  ldrb     w8, [x1, #0x53]
0066FC648  tbnz     w8, #5, #0x66fc698
0066FC64C  mov      x0, x19
0066FC650  mov      x1, xzr
0066FC654  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FC658  adrp     x21, #0x959a000
0066FC65C  ldrb     w8, [x21, #0x925]
0066FC660  mov      w20, w0
0066FC664  cbnz     w8, #0x66fc67c
0066FC668  adrp     x0, #0x8f17000
0066FC66C  ldr      x0, [x0, #0x318]
0066FC670  bl       #0x382bd14 ; 
0066FC674  mov      w8, #1
0066FC678  strb     w8, [x21, #0x925]
0066FC67C  adrp     x8, #0x8f17000
0066FC680  ldr      x8, [x8, #0x318]
0066FC684  ldr      x2, [x8]
0066FC688  ldrb     w8, [x2, #0x53]
0066FC68C  tbnz     w8, #5, #0x66fc6ac
0066FC690  str      w20, [x19, #0x20]
0066FC694  b        #0x66fc6bc ; 
0066FC698  ldr      x2, [x1, #0x60]
0066FC69C  mov      x0, x19
0066FC6A0  ldp      x20, x19, [sp, #0x10]
0066FC6A4  ldp      x30, x21, [sp], #0x20
0066FC6A8  br       x2
0066FC6AC  ldr      x8, [x2, #0x60]
0066FC6B0  mov      x0, x19
0066FC6B4  mov      w1, w20
0066FC6B8  blr      x8
0066FC6BC  mov      x0, x19
0066FC6C0  mov      x1, xzr
0066FC6C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FC6C8  adrp     x21, #0x959a000
0066FC6CC  ldrb     w8, [x21, #0x926]
0066FC6D0  mov      w20, w0
0066FC6D4  cbnz     w8, #0x66fc6ec
0066FC6D8  adrp     x0, #0x8f17000
0066FC6DC  ldr      x0, [x0, #0x328]
0066FC6E0  bl       #0x382bd14 ; 
0066FC6E4  mov      w8, #1
0066FC6E8  strb     w8, [x21, #0x926]
0066FC6EC  adrp     x8, #0x8f17000
0066FC6F0  ldr      x8, [x8, #0x328]
0066FC6F4  ldr      x2, [x8]
0066FC6F8  ldrb     w8, [x2, #0x53]
0066FC6FC  tbnz     w8, #5, #0x66fc708
0066FC700  str      w20, [x19, #0x24]
0066FC704  b        #0x66fc718 ; 
0066FC708  ldr      x8, [x2, #0x60]
0066FC70C  mov      x0, x19
0066FC710  mov      w1, w20
0066FC714  blr      x8
0066FC718  mov      x0, x19
0066FC71C  mov      x1, xzr
0066FC720  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0066FC724  adrp     x21, #0x959a000
0066FC728  ldrb     w8, [x21, #0x927]
0066FC72C  mov      x20, x0
0066FC730  cbnz     w8, #0x66fc748
0066FC734  adrp     x0, #0x8f17000
0066FC738  ldr      x0, [x0, #0x338]
0066FC73C  bl       #0x382bd14 ; 
0066FC740  mov      w8, #1
0066FC744  strb     w8, [x21, #0x927]
0066FC748  adrp     x8, #0x8f17000
0066FC74C  ldr      x8, [x8, #0x338]
0066FC750  ldr      x2, [x8]
0066FC754  ldrb     w8, [x2, #0x53]
0066FC758  tbnz     w8, #5, #0x66fc770
0066FC75C  mov      x0, x19
0066FC760  str      x20, [x0, #0x28]!
0066FC764  mov      x1, x20
0066FC768  bl       #0x382bcb8 ; 
0066FC76C  b        #0x66fc780 ; 
0066FC770  ldr      x8, [x2, #0x60]
0066FC774  mov      x0, x19
0066FC778  mov      x1, x20
0066FC77C  blr      x8
0066FC780  mov      x0, x19
0066FC784  mov      x1, xzr
0066FC788  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0066FC78C  adrp     x21, #0x959a000
0066FC790  ldrb     w8, [x21, #0x928]
0066FC794  mov      x20, x0
0066FC798  cbnz     w8, #0x66fc7b0
0066FC79C  adrp     x0, #0x8f17000
0066FC7A0  ldr      x0, [x0, #0x348]
0066FC7A4  bl       #0x382bd14 ; 
0066FC7A8  mov      w8, #1
0066FC7AC  strb     w8, [x21, #0x928]
0066FC7B0  adrp     x8, #0x8f17000
0066FC7B4  ldr      x8, [x8, #0x348]
0066FC7B8  ldr      x2, [x8]
0066FC7BC  ldrb     w8, [x2, #0x53]
0066FC7C0  tbnz     w8, #5, #0x66fc7d8
0066FC7C4  str      x20, [x19, #0x30]!
0066FC7C8  mov      x0, x19
0066FC7CC  mov      x1, x20
0066FC7D0  bl       #0x382bcb8 ; 
0066FC7D4  b        #0x66fc7e8 ; 
0066FC7D8  ldr      x8, [x2, #0x60]
0066FC7DC  mov      x0, x19
0066FC7E0  mov      x1, x20
0066FC7E4  blr      x8
0066FC7E8  ldp      x20, x19, [sp, #0x10]
0066FC7EC  mov      w0, #1
0066FC7F0  ldp      x30, x21, [sp], #0x20
0066FC7F4  ret      

