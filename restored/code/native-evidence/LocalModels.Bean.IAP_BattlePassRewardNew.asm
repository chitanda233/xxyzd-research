; LocalModels.Bean.IAP_BattlePassRewardNew$$readImpl
; RVA 0x6A9CEE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A9CEE0  stp      x30, x21, [sp, #-0x20]!
006A9CEE4  stp      x20, x19, [sp, #0x10]
006A9CEE8  adrp     x20, #0x959e000
006A9CEEC  adrp     x21, #0x8f39000
006A9CEF0  ldrb     w8, [x20, #0x241]
006A9CEF4  ldr      x21, [x21, #0x7a0]
006A9CEF8  mov      x19, x0
006A9CEFC  tbnz     w8, #0, #0x6a9cf14
006A9CF00  adrp     x0, #0x8f39000
006A9CF04  ldr      x0, [x0, #0x7a0]
006A9CF08  bl       #0x382bd14 ; 
006A9CF0C  mov      w8, #1
006A9CF10  strb     w8, [x20, #0x241]
006A9CF14  ldr      x1, [x21]
006A9CF18  ldrb     w8, [x1, #0x53]
006A9CF1C  tbnz     w8, #5, #0x6a9cf6c
006A9CF20  mov      x0, x19
006A9CF24  mov      x1, xzr
006A9CF28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9CF2C  adrp     x21, #0x959e000
006A9CF30  ldrb     w8, [x21, #0x630]
006A9CF34  mov      w20, w0
006A9CF38  cbnz     w8, #0x6a9cf50
006A9CF3C  adrp     x0, #0x8f39000
006A9CF40  ldr      x0, [x0, #0x738]
006A9CF44  bl       #0x382bd14 ; 
006A9CF48  mov      w8, #1
006A9CF4C  strb     w8, [x21, #0x630]
006A9CF50  adrp     x8, #0x8f39000
006A9CF54  ldr      x8, [x8, #0x738]
006A9CF58  ldr      x2, [x8]
006A9CF5C  ldrb     w8, [x2, #0x53]
006A9CF60  tbnz     w8, #5, #0x6a9cf80
006A9CF64  str      w20, [x19, #0x20]
006A9CF68  b        #0x6a9cf90 ; 
006A9CF6C  ldr      x2, [x1, #0x60]
006A9CF70  mov      x0, x19
006A9CF74  ldp      x20, x19, [sp, #0x10]
006A9CF78  ldp      x30, x21, [sp], #0x20
006A9CF7C  br       x2
006A9CF80  ldr      x8, [x2, #0x60]
006A9CF84  mov      x0, x19
006A9CF88  mov      w1, w20
006A9CF8C  blr      x8
006A9CF90  mov      x0, x19
006A9CF94  mov      x1, xzr
006A9CF98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9CF9C  adrp     x21, #0x959e000
006A9CFA0  ldrb     w8, [x21, #0x631]
006A9CFA4  mov      w20, w0
006A9CFA8  cbnz     w8, #0x6a9cfc0
006A9CFAC  adrp     x0, #0x8f39000
006A9CFB0  ldr      x0, [x0, #0x748]
006A9CFB4  bl       #0x382bd14 ; 
006A9CFB8  mov      w8, #1
006A9CFBC  strb     w8, [x21, #0x631]
006A9CFC0  adrp     x8, #0x8f39000
006A9CFC4  ldr      x8, [x8, #0x748]
006A9CFC8  ldr      x2, [x8]
006A9CFCC  ldrb     w8, [x2, #0x53]
006A9CFD0  tbnz     w8, #5, #0x6a9cfdc
006A9CFD4  str      w20, [x19, #0x24]
006A9CFD8  b        #0x6a9cfec ; 
006A9CFDC  ldr      x8, [x2, #0x60]
006A9CFE0  mov      x0, x19
006A9CFE4  mov      w1, w20
006A9CFE8  blr      x8
006A9CFEC  mov      x0, x19
006A9CFF0  mov      x1, xzr
006A9CFF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9CFF8  adrp     x21, #0x959e000
006A9CFFC  ldrb     w8, [x21, #0x632]
006A9D000  mov      w20, w0
006A9D004  cbnz     w8, #0x6a9d01c
006A9D008  adrp     x0, #0x8f39000
006A9D00C  ldr      x0, [x0, #0x758]
006A9D010  bl       #0x382bd14 ; 
006A9D014  mov      w8, #1
006A9D018  strb     w8, [x21, #0x632]
006A9D01C  adrp     x8, #0x8f39000
006A9D020  ldr      x8, [x8, #0x758]
006A9D024  ldr      x2, [x8]
006A9D028  ldrb     w8, [x2, #0x53]
006A9D02C  tbnz     w8, #5, #0x6a9d038
006A9D030  str      w20, [x19, #0x28]
006A9D034  b        #0x6a9d048 ; 
006A9D038  ldr      x8, [x2, #0x60]
006A9D03C  mov      x0, x19
006A9D040  mov      w1, w20
006A9D044  blr      x8
006A9D048  mov      x0, x19
006A9D04C  mov      x1, xzr
006A9D050  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9D054  adrp     x21, #0x959e000
006A9D058  ldrb     w8, [x21, #0x633]
006A9D05C  mov      w20, w0
006A9D060  cbnz     w8, #0x6a9d078
006A9D064  adrp     x0, #0x8f39000
006A9D068  ldr      x0, [x0, #0x768]
006A9D06C  bl       #0x382bd14 ; 
006A9D070  mov      w8, #1
006A9D074  strb     w8, [x21, #0x633]
006A9D078  adrp     x8, #0x8f39000
006A9D07C  ldr      x8, [x8, #0x768]
006A9D080  ldr      x2, [x8]
006A9D084  ldrb     w8, [x2, #0x53]
006A9D088  tbnz     w8, #5, #0x6a9d094
006A9D08C  str      w20, [x19, #0x2c]
006A9D090  b        #0x6a9d0a4 ; 
006A9D094  ldr      x8, [x2, #0x60]
006A9D098  mov      x0, x19
006A9D09C  mov      w1, w20
006A9D0A0  blr      x8
006A9D0A4  mov      x0, x19
006A9D0A8  mov      x1, xzr
006A9D0AC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A9D0B0  adrp     x21, #0x959e000
006A9D0B4  ldrb     w8, [x21, #0x634]
006A9D0B8  mov      x20, x0
006A9D0BC  cbnz     w8, #0x6a9d0d4
006A9D0C0  adrp     x0, #0x8f39000
006A9D0C4  ldr      x0, [x0, #0x778]
006A9D0C8  bl       #0x382bd14 ; 
006A9D0CC  mov      w8, #1
006A9D0D0  strb     w8, [x21, #0x634]
006A9D0D4  adrp     x8, #0x8f39000
006A9D0D8  ldr      x8, [x8, #0x778]
006A9D0DC  ldr      x2, [x8]
006A9D0E0  ldrb     w8, [x2, #0x53]
006A9D0E4  tbnz     w8, #5, #0x6a9d0fc
006A9D0E8  mov      x0, x19
006A9D0EC  str      x20, [x0, #0x30]!
006A9D0F0  mov      x1, x20
006A9D0F4  bl       #0x382bcb8 ; 
006A9D0F8  b        #0x6a9d10c ; 
006A9D0FC  ldr      x8, [x2, #0x60]
006A9D100  mov      x0, x19
006A9D104  mov      x1, x20
006A9D108  blr      x8
006A9D10C  mov      x0, x19
006A9D110  mov      x1, xzr
006A9D114  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A9D118  adrp     x21, #0x959e000
006A9D11C  ldrb     w8, [x21, #0x635]
006A9D120  mov      x20, x0
006A9D124  cbnz     w8, #0x6a9d13c
006A9D128  adrp     x0, #0x8f39000
006A9D12C  ldr      x0, [x0, #0x788]
006A9D130  bl       #0x382bd14 ; 
006A9D134  mov      w8, #1
006A9D138  strb     w8, [x21, #0x635]
006A9D13C  adrp     x8, #0x8f39000
006A9D140  ldr      x8, [x8, #0x788]
006A9D144  ldr      x2, [x8]
006A9D148  ldrb     w8, [x2, #0x53]
006A9D14C  tbnz     w8, #5, #0x6a9d164
006A9D150  mov      x0, x19
006A9D154  str      x20, [x0, #0x38]!
006A9D158  mov      x1, x20
006A9D15C  bl       #0x382bcb8 ; 
006A9D160  b        #0x6a9d174 ; 
006A9D164  ldr      x8, [x2, #0x60]
006A9D168  mov      x0, x19
006A9D16C  mov      x1, x20
006A9D170  blr      x8
006A9D174  mov      x0, x19
006A9D178  mov      x1, xzr
006A9D17C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A9D180  adrp     x21, #0x959e000
006A9D184  ldrb     w8, [x21, #0x636]
006A9D188  mov      x20, x0
006A9D18C  cbnz     w8, #0x6a9d1a4
006A9D190  adrp     x0, #0x8f39000
006A9D194  ldr      x0, [x0, #0x798]
006A9D198  bl       #0x382bd14 ; 
006A9D19C  mov      w8, #1
006A9D1A0  strb     w8, [x21, #0x636]
006A9D1A4  adrp     x8, #0x8f39000
006A9D1A8  ldr      x8, [x8, #0x798]
006A9D1AC  ldr      x2, [x8]
006A9D1B0  ldrb     w8, [x2, #0x53]
006A9D1B4  tbnz     w8, #5, #0x6a9d1cc
006A9D1B8  str      x20, [x19, #0x40]!
006A9D1BC  mov      x0, x19
006A9D1C0  mov      x1, x20
006A9D1C4  bl       #0x382bcb8 ; 
006A9D1C8  b        #0x6a9d1dc ; 
006A9D1CC  ldr      x8, [x2, #0x60]
006A9D1D0  mov      x0, x19
006A9D1D4  mov      x1, x20
006A9D1D8  blr      x8
006A9D1DC  ldp      x20, x19, [sp, #0x10]
006A9D1E0  mov      w0, #1
006A9D1E4  ldp      x30, x21, [sp], #0x20
006A9D1E8  ret      

