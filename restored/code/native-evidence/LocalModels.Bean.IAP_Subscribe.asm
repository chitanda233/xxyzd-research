; LocalModels.Bean.IAP_Subscribe$$readImpl
; RVA 0x6AAAE74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AAAE74  stp      x30, x21, [sp, #-0x20]!
006AAAE78  stp      x20, x19, [sp, #0x10]
006AAAE7C  adrp     x20, #0x959e000
006AAAE80  adrp     x21, #0x8f3a000
006AAAE84  ldrb     w8, [x20, #0x73f]
006AAAE88  ldr      x21, [x21, #0x298]
006AAAE8C  mov      x19, x0
006AAAE90  tbnz     w8, #0, #0x6aaaea8
006AAAE94  adrp     x0, #0x8f3a000
006AAAE98  ldr      x0, [x0, #0x298]
006AAAE9C  bl       #0x382bd14 ; 
006AAAEA0  mov      w8, #1
006AAAEA4  strb     w8, [x20, #0x73f]
006AAAEA8  ldr      x1, [x21]
006AAAEAC  ldrb     w8, [x1, #0x53]
006AAAEB0  tbnz     w8, #5, #0x6aaaf00
006AAAEB4  mov      x0, x19
006AAAEB8  mov      x1, xzr
006AAAEBC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAAEC0  adrp     x21, #0x959e000
006AAAEC4  ldrb     w8, [x21, #0xf2a]
006AAAEC8  mov      w20, w0
006AAAECC  cbnz     w8, #0x6aaaee4
006AAAED0  adrp     x0, #0x8f3a000
006AAAED4  ldr      x0, [x0, #0x1c0]
006AAAED8  bl       #0x382bd14 ; 
006AAAEDC  mov      w8, #1
006AAAEE0  strb     w8, [x21, #0xf2a]
006AAAEE4  adrp     x8, #0x8f3a000
006AAAEE8  ldr      x8, [x8, #0x1c0]
006AAAEEC  ldr      x2, [x8]
006AAAEF0  ldrb     w8, [x2, #0x53]
006AAAEF4  tbnz     w8, #5, #0x6aaaf14
006AAAEF8  str      w20, [x19, #0x20]
006AAAEFC  b        #0x6aaaf24 ; 
006AAAF00  ldr      x2, [x1, #0x60]
006AAAF04  mov      x0, x19
006AAAF08  ldp      x20, x19, [sp, #0x10]
006AAAF0C  ldp      x30, x21, [sp], #0x20
006AAAF10  br       x2
006AAAF14  ldr      x8, [x2, #0x60]
006AAAF18  mov      x0, x19
006AAAF1C  mov      w1, w20
006AAAF20  blr      x8
006AAAF24  mov      x0, x19
006AAAF28  mov      x1, xzr
006AAAF2C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAAF30  adrp     x21, #0x959e000
006AAAF34  ldrb     w8, [x21, #0xf2b]
006AAAF38  mov      x20, x0
006AAAF3C  cbnz     w8, #0x6aaaf54
006AAAF40  adrp     x0, #0x8f3a000
006AAAF44  ldr      x0, [x0, #0x1d0]
006AAAF48  bl       #0x382bd14 ; 
006AAAF4C  mov      w8, #1
006AAAF50  strb     w8, [x21, #0xf2b]
006AAAF54  adrp     x8, #0x8f3a000
006AAAF58  ldr      x8, [x8, #0x1d0]
006AAAF5C  ldr      x2, [x8]
006AAAF60  ldrb     w8, [x2, #0x53]
006AAAF64  tbnz     w8, #5, #0x6aaaf7c
006AAAF68  mov      x0, x19
006AAAF6C  str      x20, [x0, #0x28]!
006AAAF70  mov      x1, x20
006AAAF74  bl       #0x382bcb8 ; 
006AAAF78  b        #0x6aaaf8c ; 
006AAAF7C  ldr      x8, [x2, #0x60]
006AAAF80  mov      x0, x19
006AAAF84  mov      x1, x20
006AAAF88  blr      x8
006AAAF8C  mov      x0, x19
006AAAF90  mov      x1, xzr
006AAAF94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAAF98  adrp     x21, #0x959e000
006AAAF9C  ldrb     w8, [x21, #0xf2c]
006AAAFA0  mov      w20, w0
006AAAFA4  cbnz     w8, #0x6aaafbc
006AAAFA8  adrp     x0, #0x8f3a000
006AAAFAC  ldr      x0, [x0, #0x1e0]
006AAAFB0  bl       #0x382bd14 ; 
006AAAFB4  mov      w8, #1
006AAAFB8  strb     w8, [x21, #0xf2c]
006AAAFBC  adrp     x8, #0x8f3a000
006AAAFC0  ldr      x8, [x8, #0x1e0]
006AAAFC4  ldr      x2, [x8]
006AAAFC8  ldrb     w8, [x2, #0x53]
006AAAFCC  tbnz     w8, #5, #0x6aaafd8
006AAAFD0  str      w20, [x19, #0x30]
006AAAFD4  b        #0x6aaafe8 ; 
006AAAFD8  ldr      x8, [x2, #0x60]
006AAAFDC  mov      x0, x19
006AAAFE0  mov      w1, w20
006AAAFE4  blr      x8
006AAAFE8  mov      x0, x19
006AAAFEC  mov      x1, xzr
006AAAFF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAAFF4  adrp     x21, #0x959e000
006AAAFF8  ldrb     w8, [x21, #0xf2d]
006AAAFFC  mov      w20, w0
006AAB000  cbnz     w8, #0x6aab018
006AAB004  adrp     x0, #0x8f3a000
006AAB008  ldr      x0, [x0, #0x1f0]
006AAB00C  bl       #0x382bd14 ; 
006AAB010  mov      w8, #1
006AAB014  strb     w8, [x21, #0xf2d]
006AAB018  adrp     x8, #0x8f3a000
006AAB01C  ldr      x8, [x8, #0x1f0]
006AAB020  ldr      x2, [x8]
006AAB024  ldrb     w8, [x2, #0x53]
006AAB028  tbnz     w8, #5, #0x6aab034
006AAB02C  str      w20, [x19, #0x34]
006AAB030  b        #0x6aab044 ; 
006AAB034  ldr      x8, [x2, #0x60]
006AAB038  mov      x0, x19
006AAB03C  mov      w1, w20
006AAB040  blr      x8
006AAB044  mov      x0, x19
006AAB048  mov      x1, xzr
006AAB04C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAB050  adrp     x21, #0x959e000
006AAB054  ldrb     w8, [x21, #0xf2e]
006AAB058  mov      x20, x0
006AAB05C  cbnz     w8, #0x6aab074
006AAB060  adrp     x0, #0x8f3a000
006AAB064  ldr      x0, [x0, #0x200]
006AAB068  bl       #0x382bd14 ; 
006AAB06C  mov      w8, #1
006AAB070  strb     w8, [x21, #0xf2e]
006AAB074  adrp     x8, #0x8f3a000
006AAB078  ldr      x8, [x8, #0x200]
006AAB07C  ldr      x2, [x8]
006AAB080  ldrb     w8, [x2, #0x53]
006AAB084  tbnz     w8, #5, #0x6aab09c
006AAB088  mov      x0, x19
006AAB08C  str      x20, [x0, #0x38]!
006AAB090  mov      x1, x20
006AAB094  bl       #0x382bcb8 ; 
006AAB098  b        #0x6aab0ac ; 
006AAB09C  ldr      x8, [x2, #0x60]
006AAB0A0  mov      x0, x19
006AAB0A4  mov      x1, x20
006AAB0A8  blr      x8
006AAB0AC  mov      x0, x19
006AAB0B0  mov      x1, xzr
006AAB0B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAB0B8  adrp     x21, #0x959e000
006AAB0BC  ldrb     w8, [x21, #0xf2f]
006AAB0C0  mov      w20, w0
006AAB0C4  cbnz     w8, #0x6aab0dc
006AAB0C8  adrp     x0, #0x8f3a000
006AAB0CC  ldr      x0, [x0, #0x210]
006AAB0D0  bl       #0x382bd14 ; 
006AAB0D4  mov      w8, #1
006AAB0D8  strb     w8, [x21, #0xf2f]
006AAB0DC  adrp     x8, #0x8f3a000
006AAB0E0  ldr      x8, [x8, #0x210]
006AAB0E4  ldr      x2, [x8]
006AAB0E8  ldrb     w8, [x2, #0x53]
006AAB0EC  tbnz     w8, #5, #0x6aab0f8
006AAB0F0  str      w20, [x19, #0x40]
006AAB0F4  b        #0x6aab108 ; 
006AAB0F8  ldr      x8, [x2, #0x60]
006AAB0FC  mov      x0, x19
006AAB100  mov      w1, w20
006AAB104  blr      x8
006AAB108  mov      x0, x19
006AAB10C  mov      x1, xzr
006AAB110  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAB114  adrp     x21, #0x959e000
006AAB118  ldrb     w8, [x21, #0xf30]
006AAB11C  mov      x20, x0
006AAB120  cbnz     w8, #0x6aab138
006AAB124  adrp     x0, #0x8f3a000
006AAB128  ldr      x0, [x0, #0x220]
006AAB12C  bl       #0x382bd14 ; 
006AAB130  mov      w8, #1
006AAB134  strb     w8, [x21, #0xf30]
006AAB138  adrp     x8, #0x8f3a000
006AAB13C  ldr      x8, [x8, #0x220]
006AAB140  ldr      x2, [x8]
006AAB144  ldrb     w8, [x2, #0x53]
006AAB148  tbnz     w8, #5, #0x6aab160
006AAB14C  mov      x0, x19
006AAB150  str      x20, [x0, #0x48]!
006AAB154  mov      x1, x20
006AAB158  bl       #0x382bcb8 ; 
006AAB15C  b        #0x6aab170 ; 
006AAB160  ldr      x8, [x2, #0x60]
006AAB164  mov      x0, x19
006AAB168  mov      x1, x20
006AAB16C  blr      x8
006AAB170  mov      x0, x19
006AAB174  mov      x1, xzr
006AAB178  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAB17C  adrp     x21, #0x959e000
006AAB180  ldrb     w8, [x21, #0xf31]
006AAB184  mov      x20, x0
006AAB188  cbnz     w8, #0x6aab1a0
006AAB18C  adrp     x0, #0x8f3a000
006AAB190  ldr      x0, [x0, #0x230]
006AAB194  bl       #0x382bd14 ; 
006AAB198  mov      w8, #1
006AAB19C  strb     w8, [x21, #0xf31]
006AAB1A0  adrp     x8, #0x8f3a000
006AAB1A4  ldr      x8, [x8, #0x230]
006AAB1A8  ldr      x2, [x8]
006AAB1AC  ldrb     w8, [x2, #0x53]
006AAB1B0  tbnz     w8, #5, #0x6aab1c8
006AAB1B4  mov      x0, x19
006AAB1B8  str      x20, [x0, #0x50]!
006AAB1BC  mov      x1, x20
006AAB1C0  bl       #0x382bcb8 ; 
006AAB1C4  b        #0x6aab1d8 ; 
006AAB1C8  ldr      x8, [x2, #0x60]
006AAB1CC  mov      x0, x19
006AAB1D0  mov      x1, x20
006AAB1D4  blr      x8
006AAB1D8  mov      x0, x19
006AAB1DC  mov      x1, xzr
006AAB1E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAB1E4  adrp     x21, #0x959e000
006AAB1E8  ldrb     w8, [x21, #0xf32]
006AAB1EC  mov      w20, w0
006AAB1F0  cbnz     w8, #0x6aab208
006AAB1F4  adrp     x0, #0x8f3a000
006AAB1F8  ldr      x0, [x0, #0x240]
006AAB1FC  bl       #0x382bd14 ; 
006AAB200  mov      w8, #1
006AAB204  strb     w8, [x21, #0xf32]
006AAB208  adrp     x8, #0x8f3a000
006AAB20C  ldr      x8, [x8, #0x240]
006AAB210  ldr      x2, [x8]
006AAB214  ldrb     w8, [x2, #0x53]
006AAB218  tbnz     w8, #5, #0x6aab224
006AAB21C  str      w20, [x19, #0x58]
006AAB220  b        #0x6aab234 ; 
006AAB224  ldr      x8, [x2, #0x60]
006AAB228  mov      x0, x19
006AAB22C  mov      w1, w20
006AAB230  blr      x8
006AAB234  mov      x0, x19
006AAB238  mov      x1, xzr
006AAB23C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAB240  adrp     x21, #0x959e000
006AAB244  ldrb     w8, [x21, #0xf33]
006AAB248  mov      x20, x0
006AAB24C  cbnz     w8, #0x6aab264
006AAB250  adrp     x0, #0x8f3a000
006AAB254  ldr      x0, [x0, #0x250]
006AAB258  bl       #0x382bd14 ; 
006AAB25C  mov      w8, #1
006AAB260  strb     w8, [x21, #0xf33]
006AAB264  adrp     x8, #0x8f3a000
006AAB268  ldr      x8, [x8, #0x250]
006AAB26C  ldr      x2, [x8]
006AAB270  ldrb     w8, [x2, #0x53]
006AAB274  tbnz     w8, #5, #0x6aab28c
006AAB278  mov      x0, x19
006AAB27C  str      x20, [x0, #0x60]!
006AAB280  mov      x1, x20
006AAB284  bl       #0x382bcb8 ; 
006AAB288  b        #0x6aab29c ; 
006AAB28C  ldr      x8, [x2, #0x60]
006AAB290  mov      x0, x19
006AAB294  mov      x1, x20
006AAB298  blr      x8
006AAB29C  mov      x0, x19
006AAB2A0  mov      x1, xzr
006AAB2A4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AAB2A8  adrp     x21, #0x959e000
006AAB2AC  ldrb     w8, [x21, #0xf34]
006AAB2B0  mov      x20, x0
006AAB2B4  cbnz     w8, #0x6aab2cc
006AAB2B8  adrp     x0, #0x8f3a000
006AAB2BC  ldr      x0, [x0, #0x260]
006AAB2C0  bl       #0x382bd14 ; 
006AAB2C4  mov      w8, #1
006AAB2C8  strb     w8, [x21, #0xf34]
006AAB2CC  adrp     x8, #0x8f3a000
006AAB2D0  ldr      x8, [x8, #0x260]
006AAB2D4  ldr      x2, [x8]
006AAB2D8  ldrb     w8, [x2, #0x53]
006AAB2DC  tbnz     w8, #5, #0x6aab2f4
006AAB2E0  mov      x0, x19
006AAB2E4  str      x20, [x0, #0x68]!
006AAB2E8  mov      x1, x20
006AAB2EC  bl       #0x382bcb8 ; 
006AAB2F0  b        #0x6aab304 ; 
006AAB2F4  ldr      x8, [x2, #0x60]
006AAB2F8  mov      x0, x19
006AAB2FC  mov      x1, x20
006AAB300  blr      x8
006AAB304  mov      x0, x19
006AAB308  mov      x1, xzr
006AAB30C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAB310  adrp     x21, #0x959e000
006AAB314  ldrb     w8, [x21, #0xf35]
006AAB318  mov      w20, w0
006AAB31C  cbnz     w8, #0x6aab334
006AAB320  adrp     x0, #0x8f3a000
006AAB324  ldr      x0, [x0, #0x270]
006AAB328  bl       #0x382bd14 ; 
006AAB32C  mov      w8, #1
006AAB330  strb     w8, [x21, #0xf35]
006AAB334  adrp     x8, #0x8f3a000
006AAB338  ldr      x8, [x8, #0x270]
006AAB33C  ldr      x2, [x8]
006AAB340  ldrb     w8, [x2, #0x53]
006AAB344  tbnz     w8, #5, #0x6aab350
006AAB348  str      w20, [x19, #0x70]
006AAB34C  b        #0x6aab360 ; 
006AAB350  ldr      x8, [x2, #0x60]
006AAB354  mov      x0, x19
006AAB358  mov      w1, w20
006AAB35C  blr      x8
006AAB360  mov      x0, x19
006AAB364  mov      x1, xzr
006AAB368  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAB36C  adrp     x21, #0x959e000
006AAB370  ldrb     w8, [x21, #0xf36]
006AAB374  mov      w20, w0
006AAB378  cbnz     w8, #0x6aab390
006AAB37C  adrp     x0, #0x8f3a000
006AAB380  ldr      x0, [x0, #0x280]
006AAB384  bl       #0x382bd14 ; 
006AAB388  mov      w8, #1
006AAB38C  strb     w8, [x21, #0xf36]
006AAB390  adrp     x8, #0x8f3a000
006AAB394  ldr      x8, [x8, #0x280]
006AAB398  ldr      x2, [x8]
006AAB39C  ldrb     w8, [x2, #0x53]
006AAB3A0  tbnz     w8, #5, #0x6aab3ac
006AAB3A4  str      w20, [x19, #0x74]
006AAB3A8  b        #0x6aab3bc ; 
006AAB3AC  ldr      x8, [x2, #0x60]
006AAB3B0  mov      x0, x19
006AAB3B4  mov      w1, w20
006AAB3B8  blr      x8
006AAB3BC  mov      x0, x19
006AAB3C0  mov      x1, xzr
006AAB3C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAB3C8  adrp     x21, #0x959e000
006AAB3CC  ldrb     w8, [x21, #0xf37]
006AAB3D0  mov      w20, w0
006AAB3D4  cbnz     w8, #0x6aab3ec
006AAB3D8  adrp     x0, #0x8f3a000
006AAB3DC  ldr      x0, [x0, #0x290]
006AAB3E0  bl       #0x382bd14 ; 
006AAB3E4  mov      w8, #1
006AAB3E8  strb     w8, [x21, #0xf37]
006AAB3EC  adrp     x8, #0x8f3a000
006AAB3F0  ldr      x8, [x8, #0x290]
006AAB3F4  ldr      x2, [x8]
006AAB3F8  ldrb     w8, [x2, #0x53]
006AAB3FC  tbnz     w8, #5, #0x6aab408
006AAB400  str      w20, [x19, #0x78]
006AAB404  b        #0x6aab418 ; 
006AAB408  ldr      x8, [x2, #0x60]
006AAB40C  mov      x0, x19
006AAB410  mov      w1, w20
006AAB414  blr      x8
006AAB418  ldp      x20, x19, [sp, #0x10]
006AAB41C  mov      w0, #1
006AAB420  ldp      x30, x21, [sp], #0x20
006AAB424  ret      

