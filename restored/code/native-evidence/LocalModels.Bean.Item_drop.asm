; LocalModels.Bean.Item_drop$$readImpl
; RVA 0x6AACF9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AACF9C  stp      x30, x21, [sp, #-0x20]!
006AACFA0  stp      x20, x19, [sp, #0x10]
006AACFA4  adrp     x20, #0x959e000
006AACFA8  adrp     x21, #0x8f3a000
006AACFAC  ldrb     w8, [x20, #0x770]
006AACFB0  ldr      x21, [x21, #0x3b0]
006AACFB4  mov      x19, x0
006AACFB8  tbnz     w8, #0, #0x6aacfd0
006AACFBC  adrp     x0, #0x8f3a000
006AACFC0  ldr      x0, [x0, #0x3b0]
006AACFC4  bl       #0x382bd14 ; 
006AACFC8  mov      w8, #1
006AACFCC  strb     w8, [x20, #0x770]
006AACFD0  ldr      x1, [x21]
006AACFD4  ldrb     w8, [x1, #0x53]
006AACFD8  tbnz     w8, #5, #0x6aad028
006AACFDC  mov      x0, x19
006AACFE0  mov      x1, xzr
006AACFE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AACFE8  adrp     x21, #0x959e000
006AACFEC  ldrb     w8, [x21, #0xf49]
006AACFF0  mov      w20, w0
006AACFF4  cbnz     w8, #0x6aad00c
006AACFF8  adrp     x0, #0x8f3a000
006AACFFC  ldr      x0, [x0, #0x388]
006AAD000  bl       #0x382bd14 ; 
006AAD004  mov      w8, #1
006AAD008  strb     w8, [x21, #0xf49]
006AAD00C  adrp     x8, #0x8f3a000
006AAD010  ldr      x8, [x8, #0x388]
006AAD014  ldr      x2, [x8]
006AAD018  ldrb     w8, [x2, #0x53]
006AAD01C  tbnz     w8, #5, #0x6aad03c
006AAD020  str      w20, [x19, #0x20]
006AAD024  b        #0x6aad04c ; 
006AAD028  ldr      x2, [x1, #0x60]
006AAD02C  mov      x0, x19
006AAD030  ldp      x20, x19, [sp, #0x10]
006AAD034  ldp      x30, x21, [sp], #0x20
006AAD038  br       x2
006AAD03C  ldr      x8, [x2, #0x60]
006AAD040  mov      x0, x19
006AAD044  mov      w1, w20
006AAD048  blr      x8
006AAD04C  mov      x0, x19
006AAD050  mov      x1, xzr
006AAD054  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AAD058  adrp     x21, #0x959e000
006AAD05C  ldrb     w8, [x21, #0xf4a]
006AAD060  mov      x20, x0
006AAD064  cbnz     w8, #0x6aad07c
006AAD068  adrp     x0, #0x8f3a000
006AAD06C  ldr      x0, [x0, #0x398]
006AAD070  bl       #0x382bd14 ; 
006AAD074  mov      w8, #1
006AAD078  strb     w8, [x21, #0xf4a]
006AAD07C  adrp     x8, #0x8f3a000
006AAD080  ldr      x8, [x8, #0x398]
006AAD084  ldr      x2, [x8]
006AAD088  ldrb     w8, [x2, #0x53]
006AAD08C  tbnz     w8, #5, #0x6aad0a4
006AAD090  mov      x0, x19
006AAD094  str      x20, [x0, #0x28]!
006AAD098  mov      x1, x20
006AAD09C  bl       #0x382bcb8 ; 
006AAD0A0  b        #0x6aad0b4 ; 
006AAD0A4  ldr      x8, [x2, #0x60]
006AAD0A8  mov      x0, x19
006AAD0AC  mov      x1, x20
006AAD0B0  blr      x8
006AAD0B4  mov      x0, x19
006AAD0B8  mov      x1, xzr
006AAD0BC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AAD0C0  adrp     x21, #0x959e000
006AAD0C4  ldrb     w8, [x21, #0xf4b]
006AAD0C8  mov      x20, x0
006AAD0CC  cbnz     w8, #0x6aad0e4
006AAD0D0  adrp     x0, #0x8f3a000
006AAD0D4  ldr      x0, [x0, #0x3a8]
006AAD0D8  bl       #0x382bd14 ; 
006AAD0DC  mov      w8, #1
006AAD0E0  strb     w8, [x21, #0xf4b]
006AAD0E4  adrp     x8, #0x8f3a000
006AAD0E8  ldr      x8, [x8, #0x3a8]
006AAD0EC  ldr      x2, [x8]
006AAD0F0  ldrb     w8, [x2, #0x53]
006AAD0F4  tbnz     w8, #5, #0x6aad10c
006AAD0F8  str      x20, [x19, #0x30]!
006AAD0FC  mov      x0, x19
006AAD100  mov      x1, x20
006AAD104  bl       #0x382bcb8 ; 
006AAD108  b        #0x6aad11c ; 
006AAD10C  ldr      x8, [x2, #0x60]
006AAD110  mov      x0, x19
006AAD114  mov      x1, x20
006AAD118  blr      x8
006AAD11C  ldp      x20, x19, [sp, #0x10]
006AAD120  mov      w0, #1
006AAD124  ldp      x30, x21, [sp], #0x20
006AAD128  ret      

