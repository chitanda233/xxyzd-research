; LocalModels.Bean.EventBigA_MineTaskHangUp$$readImpl
; RVA 0x6A6AC0C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6AC0C  stp      x30, x21, [sp, #-0x20]!
006A6AC10  stp      x20, x19, [sp, #0x10]
006A6AC14  adrp     x20, #0x959d000
006A6AC18  adrp     x21, #0x8f37000
006A6AC1C  ldrb     w8, [x20, #0xd01]
006A6AC20  ldr      x21, [x21, #0x128]
006A6AC24  mov      x19, x0
006A6AC28  tbnz     w8, #0, #0x6a6ac40
006A6AC2C  adrp     x0, #0x8f37000
006A6AC30  ldr      x0, [x0, #0x128]
006A6AC34  bl       #0x382bd14 ; 
006A6AC38  mov      w8, #1
006A6AC3C  strb     w8, [x20, #0xd01]
006A6AC40  ldr      x1, [x21]
006A6AC44  ldrb     w8, [x1, #0x53]
006A6AC48  tbnz     w8, #5, #0x6a6ac98
006A6AC4C  mov      x0, x19
006A6AC50  mov      x1, xzr
006A6AC54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6AC58  adrp     x21, #0x959e000
006A6AC5C  ldrb     w8, [x21, #0x416]
006A6AC60  mov      w20, w0
006A6AC64  cbnz     w8, #0x6a6ac7c
006A6AC68  adrp     x0, #0x8f37000
006A6AC6C  ldr      x0, [x0, #0x110]
006A6AC70  bl       #0x382bd14 ; 
006A6AC74  mov      w8, #1
006A6AC78  strb     w8, [x21, #0x416]
006A6AC7C  adrp     x8, #0x8f37000
006A6AC80  ldr      x8, [x8, #0x110]
006A6AC84  ldr      x2, [x8]
006A6AC88  ldrb     w8, [x2, #0x53]
006A6AC8C  tbnz     w8, #5, #0x6a6acac
006A6AC90  str      w20, [x19, #0x20]
006A6AC94  b        #0x6a6acbc ; 
006A6AC98  ldr      x2, [x1, #0x60]
006A6AC9C  mov      x0, x19
006A6ACA0  ldp      x20, x19, [sp, #0x10]
006A6ACA4  ldp      x30, x21, [sp], #0x20
006A6ACA8  br       x2
006A6ACAC  ldr      x8, [x2, #0x60]
006A6ACB0  mov      x0, x19
006A6ACB4  mov      w1, w20
006A6ACB8  blr      x8
006A6ACBC  mov      x0, x19
006A6ACC0  mov      x1, xzr
006A6ACC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6ACC8  adrp     x21, #0x959e000
006A6ACCC  ldrb     w8, [x21, #0x417]
006A6ACD0  mov      w20, w0
006A6ACD4  cbnz     w8, #0x6a6acec
006A6ACD8  adrp     x0, #0x8f37000
006A6ACDC  ldr      x0, [x0, #0x120]
006A6ACE0  bl       #0x382bd14 ; 
006A6ACE4  mov      w8, #1
006A6ACE8  strb     w8, [x21, #0x417]
006A6ACEC  adrp     x8, #0x8f37000
006A6ACF0  ldr      x8, [x8, #0x120]
006A6ACF4  ldr      x2, [x8]
006A6ACF8  ldrb     w8, [x2, #0x53]
006A6ACFC  tbnz     w8, #5, #0x6a6ad08
006A6AD00  str      w20, [x19, #0x24]
006A6AD04  b        #0x6a6ad18 ; 
006A6AD08  ldr      x8, [x2, #0x60]
006A6AD0C  mov      x0, x19
006A6AD10  mov      w1, w20
006A6AD14  blr      x8
006A6AD18  ldp      x20, x19, [sp, #0x10]
006A6AD1C  mov      w0, #1
006A6AD20  ldp      x30, x21, [sp], #0x20
006A6AD24  ret      

