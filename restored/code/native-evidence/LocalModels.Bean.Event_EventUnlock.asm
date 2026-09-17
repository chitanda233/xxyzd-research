; LocalModels.Bean.Event_EventUnlock$$readImpl
; RVA 0x6A7B628; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7B628  stp      x30, x21, [sp, #-0x20]!
006A7B62C  stp      x20, x19, [sp, #0x10]
006A7B630  adrp     x20, #0x959d000
006A7B634  adrp     x21, #0x8f37000
006A7B638  ldrb     w8, [x20, #0xebc]
006A7B63C  ldr      x21, [x21, #0xe28]
006A7B640  mov      x19, x0
006A7B644  tbnz     w8, #0, #0x6a7b65c
006A7B648  adrp     x0, #0x8f37000
006A7B64C  ldr      x0, [x0, #0xe28]
006A7B650  bl       #0x382bd14 ; 
006A7B654  mov      w8, #1
006A7B658  strb     w8, [x20, #0xebc]
006A7B65C  ldr      x1, [x21]
006A7B660  ldrb     w8, [x1, #0x53]
006A7B664  tbnz     w8, #5, #0x6a7b6b4
006A7B668  mov      x0, x19
006A7B66C  mov      x1, xzr
006A7B670  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7B674  adrp     x21, #0x959e000
006A7B678  ldrb     w8, [x21, #0x4cb]
006A7B67C  mov      w20, w0
006A7B680  cbnz     w8, #0x6a7b698
006A7B684  adrp     x0, #0x8f37000
006A7B688  ldr      x0, [x0, #0xe10]
006A7B68C  bl       #0x382bd14 ; 
006A7B690  mov      w8, #1
006A7B694  strb     w8, [x21, #0x4cb]
006A7B698  adrp     x8, #0x8f37000
006A7B69C  ldr      x8, [x8, #0xe10]
006A7B6A0  ldr      x2, [x8]
006A7B6A4  ldrb     w8, [x2, #0x53]
006A7B6A8  tbnz     w8, #5, #0x6a7b6c8
006A7B6AC  str      w20, [x19, #0x20]
006A7B6B0  b        #0x6a7b6d8 ; 
006A7B6B4  ldr      x2, [x1, #0x60]
006A7B6B8  mov      x0, x19
006A7B6BC  ldp      x20, x19, [sp, #0x10]
006A7B6C0  ldp      x30, x21, [sp], #0x20
006A7B6C4  br       x2
006A7B6C8  ldr      x8, [x2, #0x60]
006A7B6CC  mov      x0, x19
006A7B6D0  mov      w1, w20
006A7B6D4  blr      x8
006A7B6D8  mov      x0, x19
006A7B6DC  mov      x1, xzr
006A7B6E0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7B6E4  adrp     x21, #0x959e000
006A7B6E8  ldrb     w8, [x21, #0x4cc]
006A7B6EC  mov      x20, x0
006A7B6F0  cbnz     w8, #0x6a7b708
006A7B6F4  adrp     x0, #0x8f37000
006A7B6F8  ldr      x0, [x0, #0xe20]
006A7B6FC  bl       #0x382bd14 ; 
006A7B700  mov      w8, #1
006A7B704  strb     w8, [x21, #0x4cc]
006A7B708  adrp     x8, #0x8f37000
006A7B70C  ldr      x8, [x8, #0xe20]
006A7B710  ldr      x2, [x8]
006A7B714  ldrb     w8, [x2, #0x53]
006A7B718  tbnz     w8, #5, #0x6a7b730
006A7B71C  str      x20, [x19, #0x28]!
006A7B720  mov      x0, x19
006A7B724  mov      x1, x20
006A7B728  bl       #0x382bcb8 ; 
006A7B72C  b        #0x6a7b740 ; 
006A7B730  ldr      x8, [x2, #0x60]
006A7B734  mov      x0, x19
006A7B738  mov      x1, x20
006A7B73C  blr      x8
006A7B740  ldp      x20, x19, [sp, #0x10]
006A7B744  mov      w0, #1
006A7B748  ldp      x30, x21, [sp], #0x20
006A7B74C  ret      

