; LocalModels.Bean.HangUp_MultiSweep$$readImpl
; RVA 0x6A978A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A978A4  stp      x30, x21, [sp, #-0x20]!
006A978A8  stp      x20, x19, [sp, #0x10]
006A978AC  adrp     x20, #0x959e000
006A978B0  adrp     x21, #0x8f39000
006A978B4  ldrb     w8, [x20, #0x1af]
006A978B8  ldr      x21, [x21, #0x360]
006A978BC  mov      x19, x0
006A978C0  tbnz     w8, #0, #0x6a978d8
006A978C4  adrp     x0, #0x8f39000
006A978C8  ldr      x0, [x0, #0x360]
006A978CC  bl       #0x382bd14 ; 
006A978D0  mov      w8, #1
006A978D4  strb     w8, [x20, #0x1af]
006A978D8  ldr      x1, [x21]
006A978DC  ldrb     w8, [x1, #0x53]
006A978E0  tbnz     w8, #5, #0x6a97930
006A978E4  mov      x0, x19
006A978E8  mov      x1, xzr
006A978EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A978F0  adrp     x21, #0x959e000
006A978F4  ldrb     w8, [x21, #0x5f8]
006A978F8  mov      w20, w0
006A978FC  cbnz     w8, #0x6a97914
006A97900  adrp     x0, #0x8f39000
006A97904  ldr      x0, [x0, #0x348]
006A97908  bl       #0x382bd14 ; 
006A9790C  mov      w8, #1
006A97910  strb     w8, [x21, #0x5f8]
006A97914  adrp     x8, #0x8f39000
006A97918  ldr      x8, [x8, #0x348]
006A9791C  ldr      x2, [x8]
006A97920  ldrb     w8, [x2, #0x53]
006A97924  tbnz     w8, #5, #0x6a97944
006A97928  str      w20, [x19, #0x20]
006A9792C  b        #0x6a97954 ; 
006A97930  ldr      x2, [x1, #0x60]
006A97934  mov      x0, x19
006A97938  ldp      x20, x19, [sp, #0x10]
006A9793C  ldp      x30, x21, [sp], #0x20
006A97940  br       x2
006A97944  ldr      x8, [x2, #0x60]
006A97948  mov      x0, x19
006A9794C  mov      w1, w20
006A97950  blr      x8
006A97954  mov      x0, x19
006A97958  mov      x1, xzr
006A9795C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A97960  adrp     x21, #0x959e000
006A97964  ldrb     w8, [x21, #0x5f9]
006A97968  mov      w20, w0
006A9796C  cbnz     w8, #0x6a97984
006A97970  adrp     x0, #0x8f39000
006A97974  ldr      x0, [x0, #0x358]
006A97978  bl       #0x382bd14 ; 
006A9797C  mov      w8, #1
006A97980  strb     w8, [x21, #0x5f9]
006A97984  adrp     x8, #0x8f39000
006A97988  ldr      x8, [x8, #0x358]
006A9798C  ldr      x2, [x8]
006A97990  ldrb     w8, [x2, #0x53]
006A97994  tbnz     w8, #5, #0x6a979a0
006A97998  str      w20, [x19, #0x24]
006A9799C  b        #0x6a979b0 ; 
006A979A0  ldr      x8, [x2, #0x60]
006A979A4  mov      x0, x19
006A979A8  mov      w1, w20
006A979AC  blr      x8
006A979B0  ldp      x20, x19, [sp, #0x10]
006A979B4  mov      w0, #1
006A979B8  ldp      x30, x21, [sp], #0x20
006A979BC  ret      

