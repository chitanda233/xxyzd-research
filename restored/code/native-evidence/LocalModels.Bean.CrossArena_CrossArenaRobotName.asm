; LocalModels.Bean.CrossArena_CrossArenaRobotName$$readImpl
; RVA 0x6A5656C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5656C  stp      x30, x21, [sp, #-0x20]!
006A56570  stp      x20, x19, [sp, #0x10]
006A56574  adrp     x20, #0x959d000
006A56578  adrp     x21, #0x8f36000
006A5657C  ldrb     w8, [x20, #0xaec]
006A56580  ldr      x21, [x21, #0x248]
006A56584  mov      x19, x0
006A56588  tbnz     w8, #0, #0x6a565a0
006A5658C  adrp     x0, #0x8f36000
006A56590  ldr      x0, [x0, #0x248]
006A56594  bl       #0x382bd14 ; 
006A56598  mov      w8, #1
006A5659C  strb     w8, [x20, #0xaec]
006A565A0  ldr      x1, [x21]
006A565A4  ldrb     w8, [x1, #0x53]
006A565A8  tbnz     w8, #5, #0x6a565f8
006A565AC  mov      x0, x19
006A565B0  mov      x1, xzr
006A565B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A565B8  adrp     x21, #0x959e000
006A565BC  ldrb     w8, [x21, #0x32e]
006A565C0  mov      w20, w0
006A565C4  cbnz     w8, #0x6a565dc
006A565C8  adrp     x0, #0x8f36000
006A565CC  ldr      x0, [x0, #0x230]
006A565D0  bl       #0x382bd14 ; 
006A565D4  mov      w8, #1
006A565D8  strb     w8, [x21, #0x32e]
006A565DC  adrp     x8, #0x8f36000
006A565E0  ldr      x8, [x8, #0x230]
006A565E4  ldr      x2, [x8]
006A565E8  ldrb     w8, [x2, #0x53]
006A565EC  tbnz     w8, #5, #0x6a5660c
006A565F0  str      w20, [x19, #0x20]
006A565F4  b        #0x6a5661c ; 
006A565F8  ldr      x2, [x1, #0x60]
006A565FC  mov      x0, x19
006A56600  ldp      x20, x19, [sp, #0x10]
006A56604  ldp      x30, x21, [sp], #0x20
006A56608  br       x2
006A5660C  ldr      x8, [x2, #0x60]
006A56610  mov      x0, x19
006A56614  mov      w1, w20
006A56618  blr      x8
006A5661C  mov      x0, x19
006A56620  mov      x1, xzr
006A56624  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A56628  adrp     x21, #0x959e000
006A5662C  ldrb     w8, [x21, #0x32f]
006A56630  mov      x20, x0
006A56634  cbnz     w8, #0x6a5664c
006A56638  adrp     x0, #0x8f36000
006A5663C  ldr      x0, [x0, #0x240]
006A56640  bl       #0x382bd14 ; 
006A56644  mov      w8, #1
006A56648  strb     w8, [x21, #0x32f]
006A5664C  adrp     x8, #0x8f36000
006A56650  ldr      x8, [x8, #0x240]
006A56654  ldr      x2, [x8]
006A56658  ldrb     w8, [x2, #0x53]
006A5665C  tbnz     w8, #5, #0x6a56674
006A56660  str      x20, [x19, #0x28]!
006A56664  mov      x0, x19
006A56668  mov      x1, x20
006A5666C  bl       #0x382bcb8 ; 
006A56670  b        #0x6a56684 ; 
006A56674  ldr      x8, [x2, #0x60]
006A56678  mov      x0, x19
006A5667C  mov      x1, x20
006A56680  blr      x8
006A56684  ldp      x20, x19, [sp, #0x10]
006A56688  mov      w0, #1
006A5668C  ldp      x30, x21, [sp], #0x20
006A56690  ret      

