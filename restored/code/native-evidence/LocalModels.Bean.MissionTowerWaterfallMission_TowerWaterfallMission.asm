; LocalModels.Bean.MissionTowerWaterfallMission_TowerWaterfallMission$$readImpl
; RVA 0x6ABCE08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ABCE08  stp      x30, x21, [sp, #-0x20]!
006ABCE0C  stp      x20, x19, [sp, #0x10]
006ABCE10  adrp     x20, #0x959e000
006ABCE14  adrp     x21, #0x8f3a000
006ABCE18  ldrb     w8, [x20, #0x916]
006ABCE1C  ldr      x21, [x21, #0xfe0]
006ABCE20  mov      x19, x0
006ABCE24  tbnz     w8, #0, #0x6abce3c
006ABCE28  adrp     x0, #0x8f3a000
006ABCE2C  ldr      x0, [x0, #0xfe0]
006ABCE30  bl       #0x382bd14 ; 
006ABCE34  mov      w8, #1
006ABCE38  strb     w8, [x20, #0x916]
006ABCE3C  ldr      x1, [x21]
006ABCE40  ldrb     w8, [x1, #0x53]
006ABCE44  tbnz     w8, #5, #0x6abce94
006ABCE48  mov      x0, x19
006ABCE4C  mov      x1, xzr
006ABCE50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABCE54  adrp     x21, #0x959e000
006ABCE58  ldrb     w8, [x21, #0xff8]
006ABCE5C  mov      w20, w0
006ABCE60  cbnz     w8, #0x6abce78
006ABCE64  adrp     x0, #0x8f3a000
006ABCE68  ldr      x0, [x0, #0xe78]
006ABCE6C  bl       #0x382bd14 ; 
006ABCE70  mov      w8, #1
006ABCE74  strb     w8, [x21, #0xff8]
006ABCE78  adrp     x8, #0x8f3a000
006ABCE7C  ldr      x8, [x8, #0xe78]
006ABCE80  ldr      x2, [x8]
006ABCE84  ldrb     w8, [x2, #0x53]
006ABCE88  tbnz     w8, #5, #0x6abcea8
006ABCE8C  str      w20, [x19, #0x20]
006ABCE90  b        #0x6abceb8 ; 
006ABCE94  ldr      x2, [x1, #0x60]
006ABCE98  mov      x0, x19
006ABCE9C  ldp      x20, x19, [sp, #0x10]
006ABCEA0  ldp      x30, x21, [sp], #0x20
006ABCEA4  br       x2
006ABCEA8  ldr      x8, [x2, #0x60]
006ABCEAC  mov      x0, x19
006ABCEB0  mov      w1, w20
006ABCEB4  blr      x8
006ABCEB8  mov      x0, x19
006ABCEBC  mov      x1, xzr
006ABCEC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABCEC4  adrp     x21, #0x959e000
006ABCEC8  ldrb     w8, [x21, #0xff9]
006ABCECC  mov      w20, w0
006ABCED0  cbnz     w8, #0x6abcee8
006ABCED4  adrp     x0, #0x8f3a000
006ABCED8  ldr      x0, [x0, #0xe88]
006ABCEDC  bl       #0x382bd14 ; 
006ABCEE0  mov      w8, #1
006ABCEE4  strb     w8, [x21, #0xff9]
006ABCEE8  adrp     x8, #0x8f3a000
006ABCEEC  ldr      x8, [x8, #0xe88]
006ABCEF0  ldr      x2, [x8]
006ABCEF4  ldrb     w8, [x2, #0x53]
006ABCEF8  tbnz     w8, #5, #0x6abcf04
006ABCEFC  str      w20, [x19, #0x24]
006ABCF00  b        #0x6abcf14 ; 
006ABCF04  ldr      x8, [x2, #0x60]
006ABCF08  mov      x0, x19
006ABCF0C  mov      w1, w20
006ABCF10  blr      x8
006ABCF14  mov      x0, x19
006ABCF18  mov      x1, xzr
006ABCF1C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABCF20  adrp     x21, #0x959e000
006ABCF24  ldrb     w8, [x21, #0xffa]
006ABCF28  mov      x20, x0
006ABCF2C  cbnz     w8, #0x6abcf44
006ABCF30  adrp     x0, #0x8f3a000
006ABCF34  ldr      x0, [x0, #0xe98]
006ABCF38  bl       #0x382bd14 ; 
006ABCF3C  mov      w8, #1
006ABCF40  strb     w8, [x21, #0xffa]
006ABCF44  adrp     x8, #0x8f3a000
006ABCF48  ldr      x8, [x8, #0xe98]
006ABCF4C  ldr      x2, [x8]
006ABCF50  ldrb     w8, [x2, #0x53]
006ABCF54  tbnz     w8, #5, #0x6abcf60
006ABCF58  str      x20, [x19, #0x28]
006ABCF5C  b        #0x6abcf70 ; 
006ABCF60  ldr      x8, [x2, #0x60]
006ABCF64  mov      x0, x19
006ABCF68  mov      x1, x20
006ABCF6C  blr      x8
006ABCF70  mov      x0, x19
006ABCF74  mov      x1, xzr
006ABCF78  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABCF7C  adrp     x21, #0x959e000
006ABCF80  ldrb     w8, [x21, #0xffb]
006ABCF84  mov      x20, x0
006ABCF88  cbnz     w8, #0x6abcfa0
006ABCF8C  adrp     x0, #0x8f3a000
006ABCF90  ldr      x0, [x0, #0xea8]
006ABCF94  bl       #0x382bd14 ; 
006ABCF98  mov      w8, #1
006ABCF9C  strb     w8, [x21, #0xffb]
006ABCFA0  adrp     x8, #0x8f3a000
006ABCFA4  ldr      x8, [x8, #0xea8]
006ABCFA8  ldr      x2, [x8]
006ABCFAC  ldrb     w8, [x2, #0x53]
006ABCFB0  tbnz     w8, #5, #0x6abcfbc
006ABCFB4  str      x20, [x19, #0x30]
006ABCFB8  b        #0x6abcfcc ; 
006ABCFBC  ldr      x8, [x2, #0x60]
006ABCFC0  mov      x0, x19
006ABCFC4  mov      x1, x20
006ABCFC8  blr      x8
006ABCFCC  mov      x0, x19
006ABCFD0  mov      x1, xzr
006ABCFD4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABCFD8  adrp     x21, #0x959e000
006ABCFDC  ldrb     w8, [x21, #0xffc]
006ABCFE0  mov      w20, w0
006ABCFE4  cbnz     w8, #0x6abcffc
006ABCFE8  adrp     x0, #0x8f3a000
006ABCFEC  ldr      x0, [x0, #0xeb8]
006ABCFF0  bl       #0x382bd14 ; 
006ABCFF4  mov      w8, #1
006ABCFF8  strb     w8, [x21, #0xffc]
006ABCFFC  adrp     x8, #0x8f3a000
006ABD000  ldr      x8, [x8, #0xeb8]
006ABD004  ldr      x2, [x8]
006ABD008  ldrb     w8, [x2, #0x53]
006ABD00C  tbnz     w8, #5, #0x6abd018
006ABD010  str      w20, [x19, #0x38]
006ABD014  b        #0x6abd028 ; 
006ABD018  ldr      x8, [x2, #0x60]
006ABD01C  mov      x0, x19
006ABD020  mov      w1, w20
006ABD024  blr      x8
006ABD028  mov      x0, x19
006ABD02C  mov      x1, xzr
006ABD030  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006ABD034  adrp     x21, #0x959e000
006ABD038  ldrb     w8, [x21, #0xffd]
006ABD03C  mov      x20, x0
006ABD040  cbnz     w8, #0x6abd058
006ABD044  adrp     x0, #0x8f3a000
006ABD048  ldr      x0, [x0, #0xec8]
006ABD04C  bl       #0x382bd14 ; 
006ABD050  mov      w8, #1
006ABD054  strb     w8, [x21, #0xffd]
006ABD058  adrp     x8, #0x8f3a000
006ABD05C  ldr      x8, [x8, #0xec8]
006ABD060  ldr      x2, [x8]
006ABD064  ldrb     w8, [x2, #0x53]
006ABD068  tbnz     w8, #5, #0x6abd080
006ABD06C  mov      x0, x19
006ABD070  str      x20, [x0, #0x40]!
006ABD074  mov      x1, x20
006ABD078  bl       #0x382bcb8 ; 
006ABD07C  b        #0x6abd090 ; 
006ABD080  ldr      x8, [x2, #0x60]
006ABD084  mov      x0, x19
006ABD088  mov      x1, x20
006ABD08C  blr      x8
006ABD090  mov      x0, x19
006ABD094  mov      x1, xzr
006ABD098  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABD09C  adrp     x21, #0x959e000
006ABD0A0  ldrb     w8, [x21, #0xffe]
006ABD0A4  mov      x20, x0
006ABD0A8  cbnz     w8, #0x6abd0c0
006ABD0AC  adrp     x0, #0x8f3a000
006ABD0B0  ldr      x0, [x0, #0xed8]
006ABD0B4  bl       #0x382bd14 ; 
006ABD0B8  mov      w8, #1
006ABD0BC  strb     w8, [x21, #0xffe]
006ABD0C0  adrp     x8, #0x8f3a000
006ABD0C4  ldr      x8, [x8, #0xed8]
006ABD0C8  ldr      x2, [x8]
006ABD0CC  ldrb     w8, [x2, #0x53]
006ABD0D0  tbnz     w8, #5, #0x6abd0e8
006ABD0D4  mov      x0, x19
006ABD0D8  str      x20, [x0, #0x48]!
006ABD0DC  mov      x1, x20
006ABD0E0  bl       #0x382bcb8 ; 
006ABD0E4  b        #0x6abd0f8 ; 
006ABD0E8  ldr      x8, [x2, #0x60]
006ABD0EC  mov      x0, x19
006ABD0F0  mov      x1, x20
006ABD0F4  blr      x8
006ABD0F8  mov      x0, x19
006ABD0FC  mov      x1, xzr
006ABD100  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABD104  adrp     x21, #0x959e000
006ABD108  ldrb     w8, [x21, #0xfff]
006ABD10C  mov      w20, w0
006ABD110  cbnz     w8, #0x6abd128
006ABD114  adrp     x0, #0x8f3a000
006ABD118  ldr      x0, [x0, #0xee8]
006ABD11C  bl       #0x382bd14 ; 
006ABD120  mov      w8, #1
006ABD124  strb     w8, [x21, #0xfff]
006ABD128  adrp     x8, #0x8f3a000
006ABD12C  ldr      x8, [x8, #0xee8]
006ABD130  ldr      x2, [x8]
006ABD134  ldrb     w8, [x2, #0x53]
006ABD138  tbnz     w8, #5, #0x6abd144
006ABD13C  str      w20, [x19, #0x50]
006ABD140  b        #0x6abd154 ; 
006ABD144  ldr      x8, [x2, #0x60]
006ABD148  mov      x0, x19
006ABD14C  mov      w1, w20
006ABD150  blr      x8
006ABD154  mov      x0, x19
006ABD158  mov      x1, xzr
006ABD15C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABD160  adrp     x21, #0x959f000
006ABD164  ldrb     w8, [x21]
006ABD168  mov      x20, x0
006ABD16C  cbnz     w8, #0x6abd184
006ABD170  adrp     x0, #0x8f3a000
006ABD174  ldr      x0, [x0, #0xef8]
006ABD178  bl       #0x382bd14 ; 
006ABD17C  mov      w8, #1
006ABD180  strb     w8, [x21]
006ABD184  adrp     x8, #0x8f3a000
006ABD188  ldr      x8, [x8, #0xef8]
006ABD18C  ldr      x2, [x8]
006ABD190  ldrb     w8, [x2, #0x53]
006ABD194  tbnz     w8, #5, #0x6abd1ac
006ABD198  mov      x0, x19
006ABD19C  str      x20, [x0, #0x58]!
006ABD1A0  mov      x1, x20
006ABD1A4  bl       #0x382bcb8 ; 
006ABD1A8  b        #0x6abd1bc ; 
006ABD1AC  ldr      x8, [x2, #0x60]
006ABD1B0  mov      x0, x19
006ABD1B4  mov      x1, x20
006ABD1B8  blr      x8
006ABD1BC  mov      x0, x19
006ABD1C0  mov      x1, xzr
006ABD1C4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABD1C8  adrp     x21, #0x959f000
006ABD1CC  ldrb     w8, [x21, #1]
006ABD1D0  mov      x20, x0
006ABD1D4  cbnz     w8, #0x6abd1ec
006ABD1D8  adrp     x0, #0x8f3a000
006ABD1DC  ldr      x0, [x0, #0xf08]
006ABD1E0  bl       #0x382bd14 ; 
006ABD1E4  mov      w8, #1
006ABD1E8  strb     w8, [x21, #1]
006ABD1EC  adrp     x8, #0x8f3a000
006ABD1F0  ldr      x8, [x8, #0xf08]
006ABD1F4  ldr      x2, [x8]
006ABD1F8  ldrb     w8, [x2, #0x53]
006ABD1FC  tbnz     w8, #5, #0x6abd214
006ABD200  mov      x0, x19
006ABD204  str      x20, [x0, #0x60]!
006ABD208  mov      x1, x20
006ABD20C  bl       #0x382bcb8 ; 
006ABD210  b        #0x6abd224 ; 
006ABD214  ldr      x8, [x2, #0x60]
006ABD218  mov      x0, x19
006ABD21C  mov      x1, x20
006ABD220  blr      x8
006ABD224  mov      x0, x19
006ABD228  mov      x1, xzr
006ABD22C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABD230  adrp     x21, #0x959f000
006ABD234  ldrb     w8, [x21, #2]
006ABD238  mov      x20, x0
006ABD23C  cbnz     w8, #0x6abd254
006ABD240  adrp     x0, #0x8f3a000
006ABD244  ldr      x0, [x0, #0xf18]
006ABD248  bl       #0x382bd14 ; 
006ABD24C  mov      w8, #1
006ABD250  strb     w8, [x21, #2]
006ABD254  adrp     x8, #0x8f3a000
006ABD258  ldr      x8, [x8, #0xf18]
006ABD25C  ldr      x2, [x8]
006ABD260  ldrb     w8, [x2, #0x53]
006ABD264  tbnz     w8, #5, #0x6abd27c
006ABD268  mov      x0, x19
006ABD26C  str      x20, [x0, #0x68]!
006ABD270  mov      x1, x20
006ABD274  bl       #0x382bcb8 ; 
006ABD278  b        #0x6abd28c ; 
006ABD27C  ldr      x8, [x2, #0x60]
006ABD280  mov      x0, x19
006ABD284  mov      x1, x20
006ABD288  blr      x8
006ABD28C  mov      x0, x19
006ABD290  mov      x1, xzr
006ABD294  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABD298  adrp     x21, #0x959f000
006ABD29C  ldrb     w8, [x21, #3]
006ABD2A0  mov      x20, x0
006ABD2A4  cbnz     w8, #0x6abd2bc
006ABD2A8  adrp     x0, #0x8f3a000
006ABD2AC  ldr      x0, [x0, #0xf28]
006ABD2B0  bl       #0x382bd14 ; 
006ABD2B4  mov      w8, #1
006ABD2B8  strb     w8, [x21, #3]
006ABD2BC  adrp     x8, #0x8f3a000
006ABD2C0  ldr      x8, [x8, #0xf28]
006ABD2C4  ldr      x2, [x8]
006ABD2C8  ldrb     w8, [x2, #0x53]
006ABD2CC  tbnz     w8, #5, #0x6abd2e4
006ABD2D0  mov      x0, x19
006ABD2D4  str      x20, [x0, #0x70]!
006ABD2D8  mov      x1, x20
006ABD2DC  bl       #0x382bcb8 ; 
006ABD2E0  b        #0x6abd2f4 ; 
006ABD2E4  ldr      x8, [x2, #0x60]
006ABD2E8  mov      x0, x19
006ABD2EC  mov      x1, x20
006ABD2F0  blr      x8
006ABD2F4  mov      x0, x19
006ABD2F8  mov      x1, xzr
006ABD2FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABD300  adrp     x21, #0x959f000
006ABD304  ldrb     w8, [x21, #4]
006ABD308  mov      w20, w0
006ABD30C  cbnz     w8, #0x6abd324
006ABD310  adrp     x0, #0x8f3a000
006ABD314  ldr      x0, [x0, #0xf38]
006ABD318  bl       #0x382bd14 ; 
006ABD31C  mov      w8, #1
006ABD320  strb     w8, [x21, #4]
006ABD324  adrp     x8, #0x8f3a000
006ABD328  ldr      x8, [x8, #0xf38]
006ABD32C  ldr      x2, [x8]
006ABD330  ldrb     w8, [x2, #0x53]
006ABD334  tbnz     w8, #5, #0x6abd340
006ABD338  str      w20, [x19, #0x78]
006ABD33C  b        #0x6abd350 ; 
006ABD340  ldr      x8, [x2, #0x60]
006ABD344  mov      x0, x19
006ABD348  mov      w1, w20
006ABD34C  blr      x8
006ABD350  mov      x0, x19
006ABD354  mov      x1, xzr
006ABD358  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABD35C  adrp     x21, #0x959f000
006ABD360  ldrb     w8, [x21, #5]
006ABD364  mov      w20, w0
006ABD368  cbnz     w8, #0x6abd380
006ABD36C  adrp     x0, #0x8f3a000
006ABD370  ldr      x0, [x0, #0xf48]
006ABD374  bl       #0x382bd14 ; 
006ABD378  mov      w8, #1
006ABD37C  strb     w8, [x21, #5]
006ABD380  adrp     x8, #0x8f3a000
006ABD384  ldr      x8, [x8, #0xf48]
006ABD388  ldr      x2, [x8]
006ABD38C  ldrb     w8, [x2, #0x53]
006ABD390  tbnz     w8, #5, #0x6abd39c
006ABD394  str      w20, [x19, #0x7c]
006ABD398  b        #0x6abd3ac ; 
006ABD39C  ldr      x8, [x2, #0x60]
006ABD3A0  mov      x0, x19
006ABD3A4  mov      w1, w20
006ABD3A8  blr      x8
006ABD3AC  mov      x0, x19
006ABD3B0  mov      x1, xzr
006ABD3B4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABD3B8  adrp     x21, #0x959f000
006ABD3BC  ldrb     w8, [x21, #6]
006ABD3C0  mov      x20, x0
006ABD3C4  cbnz     w8, #0x6abd3dc
006ABD3C8  adrp     x0, #0x8f3a000
006ABD3CC  ldr      x0, [x0, #0xf58]
006ABD3D0  bl       #0x382bd14 ; 
006ABD3D4  mov      w8, #1
006ABD3D8  strb     w8, [x21, #6]
006ABD3DC  adrp     x8, #0x8f3a000
006ABD3E0  ldr      x8, [x8, #0xf58]
006ABD3E4  ldr      x2, [x8]
006ABD3E8  ldrb     w8, [x2, #0x53]
006ABD3EC  tbnz     w8, #5, #0x6abd3f8
006ABD3F0  str      x20, [x19, #0x80]
006ABD3F4  b        #0x6abd408 ; 
006ABD3F8  ldr      x8, [x2, #0x60]
006ABD3FC  mov      x0, x19
006ABD400  mov      x1, x20
006ABD404  blr      x8
006ABD408  mov      x0, x19
006ABD40C  mov      x1, xzr
006ABD410  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABD414  adrp     x21, #0x959f000
006ABD418  ldrb     w8, [x21, #7]
006ABD41C  mov      x20, x0
006ABD420  cbnz     w8, #0x6abd438
006ABD424  adrp     x0, #0x8f3a000
006ABD428  ldr      x0, [x0, #0xf68]
006ABD42C  bl       #0x382bd14 ; 
006ABD430  mov      w8, #1
006ABD434  strb     w8, [x21, #7]
006ABD438  adrp     x8, #0x8f3a000
006ABD43C  ldr      x8, [x8, #0xf68]
006ABD440  ldr      x2, [x8]
006ABD444  ldrb     w8, [x2, #0x53]
006ABD448  tbnz     w8, #5, #0x6abd454
006ABD44C  str      x20, [x19, #0x88]
006ABD450  b        #0x6abd464 ; 
006ABD454  ldr      x8, [x2, #0x60]
006ABD458  mov      x0, x19
006ABD45C  mov      x1, x20
006ABD460  blr      x8
006ABD464  mov      x0, x19
006ABD468  mov      x1, xzr
006ABD46C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABD470  adrp     x21, #0x959f000
006ABD474  ldrb     w8, [x21, #8]
006ABD478  mov      x20, x0
006ABD47C  cbnz     w8, #0x6abd494
006ABD480  adrp     x0, #0x8f3a000
006ABD484  ldr      x0, [x0, #0xf78]
006ABD488  bl       #0x382bd14 ; 
006ABD48C  mov      w8, #1
006ABD490  strb     w8, [x21, #8]
006ABD494  adrp     x8, #0x8f3a000
006ABD498  ldr      x8, [x8, #0xf78]
006ABD49C  ldr      x2, [x8]
006ABD4A0  ldrb     w8, [x2, #0x53]
006ABD4A4  tbnz     w8, #5, #0x6abd4b0
006ABD4A8  str      x20, [x19, #0x90]
006ABD4AC  b        #0x6abd4c0 ; 
006ABD4B0  ldr      x8, [x2, #0x60]
006ABD4B4  mov      x0, x19
006ABD4B8  mov      x1, x20
006ABD4BC  blr      x8
006ABD4C0  mov      x0, x19
006ABD4C4  mov      x1, xzr
006ABD4C8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABD4CC  adrp     x21, #0x959f000
006ABD4D0  ldrb     w8, [x21, #9]
006ABD4D4  mov      x20, x0
006ABD4D8  cbnz     w8, #0x6abd4f0
006ABD4DC  adrp     x0, #0x8f3a000
006ABD4E0  ldr      x0, [x0, #0xf88]
006ABD4E4  bl       #0x382bd14 ; 
006ABD4E8  mov      w8, #1
006ABD4EC  strb     w8, [x21, #9]
006ABD4F0  adrp     x8, #0x8f3a000
006ABD4F4  ldr      x8, [x8, #0xf88]
006ABD4F8  ldr      x2, [x8]
006ABD4FC  ldrb     w8, [x2, #0x53]
006ABD500  tbnz     w8, #5, #0x6abd50c
006ABD504  str      x20, [x19, #0x98]
006ABD508  b        #0x6abd51c ; 
006ABD50C  ldr      x8, [x2, #0x60]
006ABD510  mov      x0, x19
006ABD514  mov      x1, x20
006ABD518  blr      x8
006ABD51C  mov      x0, x19
006ABD520  mov      x1, xzr
006ABD524  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABD528  adrp     x21, #0x959f000
006ABD52C  ldrb     w8, [x21, #0xa]
006ABD530  mov      w20, w0
006ABD534  cbnz     w8, #0x6abd54c
006ABD538  adrp     x0, #0x8f3a000
006ABD53C  ldr      x0, [x0, #0xf98]
006ABD540  bl       #0x382bd14 ; 
006ABD544  mov      w8, #1
006ABD548  strb     w8, [x21, #0xa]
006ABD54C  adrp     x8, #0x8f3a000
006ABD550  ldr      x8, [x8, #0xf98]
006ABD554  ldr      x2, [x8]
006ABD558  ldrb     w8, [x2, #0x53]
006ABD55C  tbnz     w8, #5, #0x6abd568
006ABD560  str      w20, [x19, #0xa0]
006ABD564  b        #0x6abd578 ; 
006ABD568  ldr      x8, [x2, #0x60]
006ABD56C  mov      x0, x19
006ABD570  mov      w1, w20
006ABD574  blr      x8
006ABD578  mov      x0, x19
006ABD57C  mov      x1, xzr
006ABD580  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABD584  adrp     x21, #0x959f000
006ABD588  ldrb     w8, [x21, #0xb]
006ABD58C  mov      x20, x0
006ABD590  cbnz     w8, #0x6abd5a8
006ABD594  adrp     x0, #0x8f3a000
006ABD598  ldr      x0, [x0, #0xfa8]
006ABD59C  bl       #0x382bd14 ; 
006ABD5A0  mov      w8, #1
006ABD5A4  strb     w8, [x21, #0xb]
006ABD5A8  adrp     x8, #0x8f3a000
006ABD5AC  ldr      x8, [x8, #0xfa8]
006ABD5B0  ldr      x2, [x8]
006ABD5B4  ldrb     w8, [x2, #0x53]
006ABD5B8  tbnz     w8, #5, #0x6abd5d0
006ABD5BC  mov      x0, x19
006ABD5C0  str      x20, [x0, #0xa8]!
006ABD5C4  mov      x1, x20
006ABD5C8  bl       #0x382bcb8 ; 
006ABD5CC  b        #0x6abd5e0 ; 
006ABD5D0  ldr      x8, [x2, #0x60]
006ABD5D4  mov      x0, x19
006ABD5D8  mov      x1, x20
006ABD5DC  blr      x8
006ABD5E0  mov      x0, x19
006ABD5E4  mov      x1, xzr
006ABD5E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABD5EC  adrp     x21, #0x959f000
006ABD5F0  ldrb     w8, [x21, #0xc]
006ABD5F4  mov      w20, w0
006ABD5F8  cbnz     w8, #0x6abd610
006ABD5FC  adrp     x0, #0x8f3a000
006ABD600  ldr      x0, [x0, #0xfb8]
006ABD604  bl       #0x382bd14 ; 
006ABD608  mov      w8, #1
006ABD60C  strb     w8, [x21, #0xc]
006ABD610  adrp     x8, #0x8f3a000
006ABD614  ldr      x8, [x8, #0xfb8]
006ABD618  ldr      x2, [x8]
006ABD61C  ldrb     w8, [x2, #0x53]
006ABD620  tbnz     w8, #5, #0x6abd62c
006ABD624  str      w20, [x19, #0xb0]
006ABD628  b        #0x6abd63c ; 
006ABD62C  ldr      x8, [x2, #0x60]
006ABD630  mov      x0, x19
006ABD634  mov      w1, w20
006ABD638  blr      x8
006ABD63C  mov      x0, x19
006ABD640  mov      x1, xzr
006ABD644  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ABD648  adrp     x21, #0x959f000
006ABD64C  ldrb     w8, [x21, #0xd]
006ABD650  mov      x20, x0
006ABD654  cbnz     w8, #0x6abd66c
006ABD658  adrp     x0, #0x8f3a000
006ABD65C  ldr      x0, [x0, #0xfc8]
006ABD660  bl       #0x382bd14 ; 
006ABD664  mov      w8, #1
006ABD668  strb     w8, [x21, #0xd]
006ABD66C  adrp     x8, #0x8f3a000
006ABD670  ldr      x8, [x8, #0xfc8]
006ABD674  ldr      x2, [x8]
006ABD678  ldrb     w8, [x2, #0x53]
006ABD67C  tbnz     w8, #5, #0x6abd694
006ABD680  mov      x0, x19
006ABD684  str      x20, [x0, #0xb8]!
006ABD688  mov      x1, x20
006ABD68C  bl       #0x382bcb8 ; 
006ABD690  b        #0x6abd6a4 ; 
006ABD694  ldr      x8, [x2, #0x60]
006ABD698  mov      x0, x19
006ABD69C  mov      x1, x20
006ABD6A0  blr      x8
006ABD6A4  mov      x0, x19
006ABD6A8  mov      x1, xzr
006ABD6AC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ABD6B0  adrp     x21, #0x959f000
006ABD6B4  ldrb     w8, [x21, #0xe]
006ABD6B8  mov      x20, x0
006ABD6BC  cbnz     w8, #0x6abd6d4
006ABD6C0  adrp     x0, #0x8f3a000
006ABD6C4  ldr      x0, [x0, #0xfd8]
006ABD6C8  bl       #0x382bd14 ; 
006ABD6CC  mov      w8, #1
006ABD6D0  strb     w8, [x21, #0xe]
006ABD6D4  adrp     x8, #0x8f3a000
006ABD6D8  ldr      x8, [x8, #0xfd8]
006ABD6DC  ldr      x2, [x8]
006ABD6E0  ldrb     w8, [x2, #0x53]
006ABD6E4  tbnz     w8, #5, #0x6abd6fc
006ABD6E8  str      x20, [x19, #0xc0]!
006ABD6EC  mov      x0, x19
006ABD6F0  mov      x1, x20
006ABD6F4  bl       #0x382bcb8 ; 
006ABD6F8  b        #0x6abd70c ; 
006ABD6FC  ldr      x8, [x2, #0x60]
006ABD700  mov      x0, x19
006ABD704  mov      x1, x20
006ABD708  blr      x8
006ABD70C  ldp      x20, x19, [sp, #0x10]
006ABD710  mov      w0, #1
006ABD714  ldp      x30, x21, [sp], #0x20
006ABD718  ret      

