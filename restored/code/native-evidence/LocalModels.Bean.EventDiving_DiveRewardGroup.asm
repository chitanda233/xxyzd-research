; LocalModels.Bean.EventDiving_DiveRewardGroup$$readImpl
; RVA 0x6A6F710; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6F710  stp      x30, x21, [sp, #-0x20]!
006A6F714  stp      x20, x19, [sp, #0x10]
006A6F718  adrp     x20, #0x959d000
006A6F71C  adrp     x21, #0x8f37000
006A6F720  ldrb     w8, [x20, #0xd7f]
006A6F724  ldr      x21, [x21, #0x4d8]
006A6F728  mov      x19, x0
006A6F72C  tbnz     w8, #0, #0x6a6f744
006A6F730  adrp     x0, #0x8f37000
006A6F734  ldr      x0, [x0, #0x4d8]
006A6F738  bl       #0x382bd14 ; 
006A6F73C  mov      w8, #1
006A6F740  strb     w8, [x20, #0xd7f]
006A6F744  ldr      x1, [x21]
006A6F748  ldrb     w8, [x1, #0x53]
006A6F74C  tbnz     w8, #5, #0x6a6f79c
006A6F750  mov      x0, x19
006A6F754  mov      x1, xzr
006A6F758  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6F75C  adrp     x21, #0x959e000
006A6F760  ldrb     w8, [x21, #0x447]
006A6F764  mov      w20, w0
006A6F768  cbnz     w8, #0x6a6f780
006A6F76C  adrp     x0, #0x8f37000
006A6F770  ldr      x0, [x0, #0x4a0]
006A6F774  bl       #0x382bd14 ; 
006A6F778  mov      w8, #1
006A6F77C  strb     w8, [x21, #0x447]
006A6F780  adrp     x8, #0x8f37000
006A6F784  ldr      x8, [x8, #0x4a0]
006A6F788  ldr      x2, [x8]
006A6F78C  ldrb     w8, [x2, #0x53]
006A6F790  tbnz     w8, #5, #0x6a6f7b0
006A6F794  str      w20, [x19, #0x20]
006A6F798  b        #0x6a6f7c0 ; 
006A6F79C  ldr      x2, [x1, #0x60]
006A6F7A0  mov      x0, x19
006A6F7A4  ldp      x20, x19, [sp, #0x10]
006A6F7A8  ldp      x30, x21, [sp], #0x20
006A6F7AC  br       x2
006A6F7B0  ldr      x8, [x2, #0x60]
006A6F7B4  mov      x0, x19
006A6F7B8  mov      w1, w20
006A6F7BC  blr      x8
006A6F7C0  mov      x0, x19
006A6F7C4  mov      x1, xzr
006A6F7C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6F7CC  adrp     x21, #0x959e000
006A6F7D0  ldrb     w8, [x21, #0x448]
006A6F7D4  mov      w20, w0
006A6F7D8  cbnz     w8, #0x6a6f7f0
006A6F7DC  adrp     x0, #0x8f37000
006A6F7E0  ldr      x0, [x0, #0x4b0]
006A6F7E4  bl       #0x382bd14 ; 
006A6F7E8  mov      w8, #1
006A6F7EC  strb     w8, [x21, #0x448]
006A6F7F0  adrp     x8, #0x8f37000
006A6F7F4  ldr      x8, [x8, #0x4b0]
006A6F7F8  ldr      x2, [x8]
006A6F7FC  ldrb     w8, [x2, #0x53]
006A6F800  tbnz     w8, #5, #0x6a6f80c
006A6F804  str      w20, [x19, #0x24]
006A6F808  b        #0x6a6f81c ; 
006A6F80C  ldr      x8, [x2, #0x60]
006A6F810  mov      x0, x19
006A6F814  mov      w1, w20
006A6F818  blr      x8
006A6F81C  mov      x0, x19
006A6F820  mov      x1, xzr
006A6F824  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6F828  adrp     x21, #0x959e000
006A6F82C  ldrb     w8, [x21, #0x449]
006A6F830  mov      w20, w0
006A6F834  cbnz     w8, #0x6a6f84c
006A6F838  adrp     x0, #0x8f37000
006A6F83C  ldr      x0, [x0, #0x4c0]
006A6F840  bl       #0x382bd14 ; 
006A6F844  mov      w8, #1
006A6F848  strb     w8, [x21, #0x449]
006A6F84C  adrp     x8, #0x8f37000
006A6F850  ldr      x8, [x8, #0x4c0]
006A6F854  ldr      x2, [x8]
006A6F858  ldrb     w8, [x2, #0x53]
006A6F85C  tbnz     w8, #5, #0x6a6f868
006A6F860  str      w20, [x19, #0x28]
006A6F864  b        #0x6a6f878 ; 
006A6F868  ldr      x8, [x2, #0x60]
006A6F86C  mov      x0, x19
006A6F870  mov      w1, w20
006A6F874  blr      x8
006A6F878  mov      x0, x19
006A6F87C  mov      x1, xzr
006A6F880  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A6F884  adrp     x21, #0x959e000
006A6F888  ldrb     w8, [x21, #0x44a]
006A6F88C  mov      x20, x0
006A6F890  cbnz     w8, #0x6a6f8a8
006A6F894  adrp     x0, #0x8f37000
006A6F898  ldr      x0, [x0, #0x4d0]
006A6F89C  bl       #0x382bd14 ; 
006A6F8A0  mov      w8, #1
006A6F8A4  strb     w8, [x21, #0x44a]
006A6F8A8  adrp     x8, #0x8f37000
006A6F8AC  ldr      x8, [x8, #0x4d0]
006A6F8B0  ldr      x2, [x8]
006A6F8B4  ldrb     w8, [x2, #0x53]
006A6F8B8  tbnz     w8, #5, #0x6a6f8d0
006A6F8BC  str      x20, [x19, #0x30]!
006A6F8C0  mov      x0, x19
006A6F8C4  mov      x1, x20
006A6F8C8  bl       #0x382bcb8 ; 
006A6F8CC  b        #0x6a6f8e0 ; 
006A6F8D0  ldr      x8, [x2, #0x60]
006A6F8D4  mov      x0, x19
006A6F8D8  mov      x1, x20
006A6F8DC  blr      x8
006A6F8E0  ldp      x20, x19, [sp, #0x10]
006A6F8E4  mov      w0, #1
006A6F8E8  ldp      x30, x21, [sp], #0x20
006A6F8EC  ret      

