; LocalModels.Bean.IAP_SignInPassReward$$readImpl
; RVA 0x6AA9F98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA9F98  stp      x30, x21, [sp, #-0x20]!
006AA9F9C  stp      x20, x19, [sp, #0x10]
006AA9FA0  adrp     x20, #0x959e000
006AA9FA4  adrp     x21, #0x8f3a000
006AA9FA8  ldrb     w8, [x20, #0x720]
006AA9FAC  ldr      x21, [x21, #0x1a8]
006AA9FB0  mov      x19, x0
006AA9FB4  tbnz     w8, #0, #0x6aa9fcc
006AA9FB8  adrp     x0, #0x8f3a000
006AA9FBC  ldr      x0, [x0, #0x1a8]
006AA9FC0  bl       #0x382bd14 ; 
006AA9FC4  mov      w8, #1
006AA9FC8  strb     w8, [x20, #0x720]
006AA9FCC  ldr      x1, [x21]
006AA9FD0  ldrb     w8, [x1, #0x53]
006AA9FD4  tbnz     w8, #5, #0x6aaa024
006AA9FD8  mov      x0, x19
006AA9FDC  mov      x1, xzr
006AA9FE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA9FE4  adrp     x21, #0x959e000
006AA9FE8  ldrb     w8, [x21, #0xf27]
006AA9FEC  mov      w20, w0
006AA9FF0  cbnz     w8, #0x6aaa008
006AA9FF4  adrp     x0, #0x8f3a000
006AA9FF8  ldr      x0, [x0, #0x180]
006AA9FFC  bl       #0x382bd14 ; 
006AAA000  mov      w8, #1
006AAA004  strb     w8, [x21, #0xf27]
006AAA008  adrp     x8, #0x8f3a000
006AAA00C  ldr      x8, [x8, #0x180]
006AAA010  ldr      x2, [x8]
006AAA014  ldrb     w8, [x2, #0x53]
006AAA018  tbnz     w8, #5, #0x6aaa038
006AAA01C  str      w20, [x19, #0x20]
006AAA020  b        #0x6aaa048 ; 
006AAA024  ldr      x2, [x1, #0x60]
006AAA028  mov      x0, x19
006AAA02C  ldp      x20, x19, [sp, #0x10]
006AAA030  ldp      x30, x21, [sp], #0x20
006AAA034  br       x2
006AAA038  ldr      x8, [x2, #0x60]
006AAA03C  mov      x0, x19
006AAA040  mov      w1, w20
006AAA044  blr      x8
006AAA048  mov      x0, x19
006AAA04C  mov      x1, xzr
006AAA050  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAA054  adrp     x21, #0x959e000
006AAA058  ldrb     w8, [x21, #0xf28]
006AAA05C  mov      x20, x0
006AAA060  cbnz     w8, #0x6aaa078
006AAA064  adrp     x0, #0x8f3a000
006AAA068  ldr      x0, [x0, #0x190]
006AAA06C  bl       #0x382bd14 ; 
006AAA070  mov      w8, #1
006AAA074  strb     w8, [x21, #0xf28]
006AAA078  adrp     x8, #0x8f3a000
006AAA07C  ldr      x8, [x8, #0x190]
006AAA080  ldr      x2, [x8]
006AAA084  ldrb     w8, [x2, #0x53]
006AAA088  tbnz     w8, #5, #0x6aaa0a0
006AAA08C  mov      x0, x19
006AAA090  str      x20, [x0, #0x28]!
006AAA094  mov      x1, x20
006AAA098  bl       #0x382bcb8 ; 
006AAA09C  b        #0x6aaa0b0 ; 
006AAA0A0  ldr      x8, [x2, #0x60]
006AAA0A4  mov      x0, x19
006AAA0A8  mov      x1, x20
006AAA0AC  blr      x8
006AAA0B0  mov      x0, x19
006AAA0B4  mov      x1, xzr
006AAA0B8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAA0BC  adrp     x21, #0x959e000
006AAA0C0  ldrb     w8, [x21, #0xf29]
006AAA0C4  mov      x20, x0
006AAA0C8  cbnz     w8, #0x6aaa0e0
006AAA0CC  adrp     x0, #0x8f3a000
006AAA0D0  ldr      x0, [x0, #0x1a0]
006AAA0D4  bl       #0x382bd14 ; 
006AAA0D8  mov      w8, #1
006AAA0DC  strb     w8, [x21, #0xf29]
006AAA0E0  adrp     x8, #0x8f3a000
006AAA0E4  ldr      x8, [x8, #0x1a0]
006AAA0E8  ldr      x2, [x8]
006AAA0EC  ldrb     w8, [x2, #0x53]
006AAA0F0  tbnz     w8, #5, #0x6aaa108
006AAA0F4  str      x20, [x19, #0x30]!
006AAA0F8  mov      x0, x19
006AAA0FC  mov      x1, x20
006AAA100  bl       #0x382bcb8 ; 
006AAA104  b        #0x6aaa118 ; 
006AAA108  ldr      x8, [x2, #0x60]
006AAA10C  mov      x0, x19
006AAA110  mov      x1, x20
006AAA114  blr      x8
006AAA118  ldp      x20, x19, [sp, #0x10]
006AAA11C  mov      w0, #1
006AAA120  ldp      x30, x21, [sp], #0x20
006AAA124  ret      

