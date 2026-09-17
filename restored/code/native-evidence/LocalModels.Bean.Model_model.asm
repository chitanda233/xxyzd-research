; LocalModels.Bean.Model_model$$readImpl
; RVA 0x6ACA5D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACA5D4  stp      x30, x21, [sp, #-0x20]!
006ACA5D8  stp      x20, x19, [sp, #0x10]
006ACA5DC  adrp     x20, #0x959e000
006ACA5E0  adrp     x21, #0x8f3b000
006ACA5E4  ldrb     w8, [x20, #0xa6f]
006ACA5E8  ldr      x21, [x21, #0x9c8]
006ACA5EC  mov      x19, x0
006ACA5F0  tbnz     w8, #0, #0x6aca608
006ACA5F4  adrp     x0, #0x8f3b000
006ACA5F8  ldr      x0, [x0, #0x9c8]
006ACA5FC  bl       #0x382bd14 ; 
006ACA600  mov      w8, #1
006ACA604  strb     w8, [x20, #0xa6f]
006ACA608  ldr      x1, [x21]
006ACA60C  ldrb     w8, [x1, #0x53]
006ACA610  tbnz     w8, #5, #0x6aca660
006ACA614  mov      x0, x19
006ACA618  mov      x1, xzr
006ACA61C  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006ACA620  adrp     x21, #0x959f000
006ACA624  ldrb     w8, [x21, #0xa2]
006ACA628  mov      x20, x0
006ACA62C  cbnz     w8, #0x6aca644
006ACA630  adrp     x0, #0x8f3b000
006ACA634  ldr      x0, [x0, #0x9a8]
006ACA638  bl       #0x382bd14 ; 
006ACA63C  mov      w8, #1
006ACA640  strb     w8, [x21, #0xa2]
006ACA644  adrp     x8, #0x8f3b000
006ACA648  ldr      x8, [x8, #0x9a8]
006ACA64C  ldr      x2, [x8]
006ACA650  ldrb     w8, [x2, #0x53]
006ACA654  tbnz     w8, #5, #0x6aca674
006ACA658  str      x20, [x19, #0x20]
006ACA65C  b        #0x6aca684 ; 
006ACA660  ldr      x2, [x1, #0x60]
006ACA664  mov      x0, x19
006ACA668  ldp      x20, x19, [sp, #0x10]
006ACA66C  ldp      x30, x21, [sp], #0x20
006ACA670  br       x2
006ACA674  ldr      x8, [x2, #0x60]
006ACA678  mov      x0, x19
006ACA67C  mov      x1, x20
006ACA680  blr      x8
006ACA684  mov      x0, x19
006ACA688  mov      x1, xzr
006ACA68C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACA690  adrp     x21, #0x959f000
006ACA694  ldrb     w8, [x21, #0xa3]
006ACA698  mov      x20, x0
006ACA69C  cbnz     w8, #0x6aca6b4
006ACA6A0  adrp     x0, #0x8f3b000
006ACA6A4  ldr      x0, [x0, #0x9b0]
006ACA6A8  bl       #0x382bd14 ; 
006ACA6AC  mov      w8, #1
006ACA6B0  strb     w8, [x21, #0xa3]
006ACA6B4  adrp     x8, #0x8f3b000
006ACA6B8  ldr      x8, [x8, #0x9b0]
006ACA6BC  ldr      x2, [x8]
006ACA6C0  ldrb     w8, [x2, #0x53]
006ACA6C4  tbnz     w8, #5, #0x6aca6dc
006ACA6C8  mov      x0, x19
006ACA6CC  str      x20, [x0, #0x28]!
006ACA6D0  mov      x1, x20
006ACA6D4  bl       #0x382bcb8 ; 
006ACA6D8  b        #0x6aca6ec ; 
006ACA6DC  ldr      x8, [x2, #0x60]
006ACA6E0  mov      x0, x19
006ACA6E4  mov      x1, x20
006ACA6E8  blr      x8
006ACA6EC  mov      x0, x19
006ACA6F0  mov      x1, xzr
006ACA6F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACA6F8  adrp     x21, #0x959f000
006ACA6FC  ldrb     w8, [x21, #0xa4]
006ACA700  mov      x20, x0
006ACA704  cbnz     w8, #0x6aca71c
006ACA708  adrp     x0, #0x8f3b000
006ACA70C  ldr      x0, [x0, #0x9c0]
006ACA710  bl       #0x382bd14 ; 
006ACA714  mov      w8, #1
006ACA718  strb     w8, [x21, #0xa4]
006ACA71C  adrp     x8, #0x8f3b000
006ACA720  ldr      x8, [x8, #0x9c0]
006ACA724  ldr      x2, [x8]
006ACA728  ldrb     w8, [x2, #0x53]
006ACA72C  tbnz     w8, #5, #0x6aca744
006ACA730  str      x20, [x19, #0x30]!
006ACA734  mov      x0, x19
006ACA738  mov      x1, x20
006ACA73C  bl       #0x382bcb8 ; 
006ACA740  b        #0x6aca754 ; 
006ACA744  ldr      x8, [x2, #0x60]
006ACA748  mov      x0, x19
006ACA74C  mov      x1, x20
006ACA750  blr      x8
006ACA754  ldp      x20, x19, [sp, #0x10]
006ACA758  mov      w0, #1
006ACA75C  ldp      x30, x21, [sp], #0x20
006ACA760  ret      

