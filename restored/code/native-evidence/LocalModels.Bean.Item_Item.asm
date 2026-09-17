; LocalModels.Bean.Item_Item$$readImpl
; RVA 0x6AAEE48; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AAEE48  stp      x30, x21, [sp, #-0x20]!
006AAEE4C  stp      x20, x19, [sp, #0x10]
006AAEE50  adrp     x20, #0x959e000
006AAEE54  adrp     x21, #0x8f3a000
006AAEE58  ldrb     w8, [x20, #0x7b0]
006AAEE5C  ldr      x21, [x21, #0x598]
006AAEE60  mov      x19, x0
006AAEE64  tbnz     w8, #0, #0x6aaee7c
006AAEE68  adrp     x0, #0x8f3a000
006AAEE6C  ldr      x0, [x0, #0x598]
006AAEE70  bl       #0x382bd14 ; 
006AAEE74  mov      w8, #1
006AAEE78  strb     w8, [x20, #0x7b0]
006AAEE7C  ldr      x1, [x21]
006AAEE80  ldrb     w8, [x1, #0x53]
006AAEE84  tbnz     w8, #5, #0x6aaeed4
006AAEE88  mov      x0, x19
006AAEE8C  mov      x1, xzr
006AAEE90  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAEE94  adrp     x21, #0x959e000
006AAEE98  ldrb     w8, [x21, #0xf4f]
006AAEE9C  mov      w20, w0
006AAEEA0  cbnz     w8, #0x6aaeeb8
006AAEEA4  adrp     x0, #0x8f3a000
006AAEEA8  ldr      x0, [x0, #0x408]
006AAEEAC  bl       #0x382bd14 ; 
006AAEEB0  mov      w8, #1
006AAEEB4  strb     w8, [x21, #0xf4f]
006AAEEB8  adrp     x8, #0x8f3a000
006AAEEBC  ldr      x8, [x8, #0x408]
006AAEEC0  ldr      x2, [x8]
006AAEEC4  ldrb     w8, [x2, #0x53]
006AAEEC8  tbnz     w8, #5, #0x6aaeee8
006AAEECC  str      w20, [x19, #0x20]
006AAEED0  b        #0x6aaeef8 ; 
006AAEED4  ldr      x2, [x1, #0x60]
006AAEED8  mov      x0, x19
006AAEEDC  ldp      x20, x19, [sp, #0x10]
006AAEEE0  ldp      x30, x21, [sp], #0x20
006AAEEE4  br       x2
006AAEEE8  ldr      x8, [x2, #0x60]
006AAEEEC  mov      x0, x19
006AAEEF0  mov      w1, w20
006AAEEF4  blr      x8
006AAEEF8  mov      x0, x19
006AAEEFC  mov      x1, xzr
006AAEF00  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAEF04  adrp     x21, #0x959e000
006AAEF08  ldrb     w8, [x21, #0xf50]
006AAEF0C  mov      x20, x0
006AAEF10  cbnz     w8, #0x6aaef28
006AAEF14  adrp     x0, #0x8f3a000
006AAEF18  ldr      x0, [x0, #0x418]
006AAEF1C  bl       #0x382bd14 ; 
006AAEF20  mov      w8, #1
006AAEF24  strb     w8, [x21, #0xf50]
006AAEF28  adrp     x8, #0x8f3a000
006AAEF2C  ldr      x8, [x8, #0x418]
006AAEF30  ldr      x2, [x8]
006AAEF34  ldrb     w8, [x2, #0x53]
006AAEF38  tbnz     w8, #5, #0x6aaef50
006AAEF3C  mov      x0, x19
006AAEF40  str      x20, [x0, #0x28]!
006AAEF44  mov      x1, x20
006AAEF48  bl       #0x382bcb8 ; 
006AAEF4C  b        #0x6aaef60 ; 
006AAEF50  ldr      x8, [x2, #0x60]
006AAEF54  mov      x0, x19
006AAEF58  mov      x1, x20
006AAEF5C  blr      x8
006AAEF60  mov      x0, x19
006AAEF64  mov      x1, xzr
006AAEF68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAEF6C  adrp     x21, #0x959e000
006AAEF70  ldrb     w8, [x21, #0xf51]
006AAEF74  mov      w20, w0
006AAEF78  cbnz     w8, #0x6aaef90
006AAEF7C  adrp     x0, #0x8f3a000
006AAEF80  ldr      x0, [x0, #0x428]
006AAEF84  bl       #0x382bd14 ; 
006AAEF88  mov      w8, #1
006AAEF8C  strb     w8, [x21, #0xf51]
006AAEF90  adrp     x8, #0x8f3a000
006AAEF94  ldr      x8, [x8, #0x428]
006AAEF98  ldr      x2, [x8]
006AAEF9C  ldrb     w8, [x2, #0x53]
006AAEFA0  tbnz     w8, #5, #0x6aaefac
006AAEFA4  str      w20, [x19, #0x30]
006AAEFA8  b        #0x6aaefbc ; 
006AAEFAC  ldr      x8, [x2, #0x60]
006AAEFB0  mov      x0, x19
006AAEFB4  mov      w1, w20
006AAEFB8  blr      x8
006AAEFBC  mov      x0, x19
006AAEFC0  mov      x1, xzr
006AAEFC4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAEFC8  adrp     x21, #0x959e000
006AAEFCC  ldrb     w8, [x21, #0xf52]
006AAEFD0  mov      x20, x0
006AAEFD4  cbnz     w8, #0x6aaefec
006AAEFD8  adrp     x0, #0x8f3a000
006AAEFDC  ldr      x0, [x0, #0x438]
006AAEFE0  bl       #0x382bd14 ; 
006AAEFE4  mov      w8, #1
006AAEFE8  strb     w8, [x21, #0xf52]
006AAEFEC  adrp     x8, #0x8f3a000
006AAEFF0  ldr      x8, [x8, #0x438]
006AAEFF4  ldr      x2, [x8]
006AAEFF8  ldrb     w8, [x2, #0x53]
006AAEFFC  tbnz     w8, #5, #0x6aaf014
006AAF000  mov      x0, x19
006AAF004  str      x20, [x0, #0x38]!
006AAF008  mov      x1, x20
006AAF00C  bl       #0x382bcb8 ; 
006AAF010  b        #0x6aaf024 ; 
006AAF014  ldr      x8, [x2, #0x60]
006AAF018  mov      x0, x19
006AAF01C  mov      x1, x20
006AAF020  blr      x8
006AAF024  mov      x0, x19
006AAF028  mov      x1, xzr
006AAF02C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF030  adrp     x21, #0x959e000
006AAF034  ldrb     w8, [x21, #0xf53]
006AAF038  mov      w20, w0
006AAF03C  cbnz     w8, #0x6aaf054
006AAF040  adrp     x0, #0x8f3a000
006AAF044  ldr      x0, [x0, #0x448]
006AAF048  bl       #0x382bd14 ; 
006AAF04C  mov      w8, #1
006AAF050  strb     w8, [x21, #0xf53]
006AAF054  adrp     x8, #0x8f3a000
006AAF058  ldr      x8, [x8, #0x448]
006AAF05C  ldr      x2, [x8]
006AAF060  ldrb     w8, [x2, #0x53]
006AAF064  tbnz     w8, #5, #0x6aaf070
006AAF068  str      w20, [x19, #0x40]
006AAF06C  b        #0x6aaf080 ; 
006AAF070  ldr      x8, [x2, #0x60]
006AAF074  mov      x0, x19
006AAF078  mov      w1, w20
006AAF07C  blr      x8
006AAF080  mov      x0, x19
006AAF084  mov      x1, xzr
006AAF088  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF08C  adrp     x21, #0x959e000
006AAF090  ldrb     w8, [x21, #0xf54]
006AAF094  mov      w20, w0
006AAF098  cbnz     w8, #0x6aaf0b0
006AAF09C  adrp     x0, #0x8f3a000
006AAF0A0  ldr      x0, [x0, #0x458]
006AAF0A4  bl       #0x382bd14 ; 
006AAF0A8  mov      w8, #1
006AAF0AC  strb     w8, [x21, #0xf54]
006AAF0B0  adrp     x8, #0x8f3a000
006AAF0B4  ldr      x8, [x8, #0x458]
006AAF0B8  ldr      x2, [x8]
006AAF0BC  ldrb     w8, [x2, #0x53]
006AAF0C0  tbnz     w8, #5, #0x6aaf0cc
006AAF0C4  str      w20, [x19, #0x44]
006AAF0C8  b        #0x6aaf0dc ; 
006AAF0CC  ldr      x8, [x2, #0x60]
006AAF0D0  mov      x0, x19
006AAF0D4  mov      w1, w20
006AAF0D8  blr      x8
006AAF0DC  mov      x0, x19
006AAF0E0  mov      x1, xzr
006AAF0E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF0E8  adrp     x21, #0x959e000
006AAF0EC  ldrb     w8, [x21, #0xf55]
006AAF0F0  mov      w20, w0
006AAF0F4  cbnz     w8, #0x6aaf10c
006AAF0F8  adrp     x0, #0x8f3a000
006AAF0FC  ldr      x0, [x0, #0x468]
006AAF100  bl       #0x382bd14 ; 
006AAF104  mov      w8, #1
006AAF108  strb     w8, [x21, #0xf55]
006AAF10C  adrp     x8, #0x8f3a000
006AAF110  ldr      x8, [x8, #0x468]
006AAF114  ldr      x2, [x8]
006AAF118  ldrb     w8, [x2, #0x53]
006AAF11C  tbnz     w8, #5, #0x6aaf128
006AAF120  str      w20, [x19, #0x48]
006AAF124  b        #0x6aaf138 ; 
006AAF128  ldr      x8, [x2, #0x60]
006AAF12C  mov      x0, x19
006AAF130  mov      w1, w20
006AAF134  blr      x8
006AAF138  mov      x0, x19
006AAF13C  mov      x1, xzr
006AAF140  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF144  adrp     x21, #0x959e000
006AAF148  ldrb     w8, [x21, #0xf56]
006AAF14C  mov      w20, w0
006AAF150  cbnz     w8, #0x6aaf168
006AAF154  adrp     x0, #0x8f3a000
006AAF158  ldr      x0, [x0, #0x478]
006AAF15C  bl       #0x382bd14 ; 
006AAF160  mov      w8, #1
006AAF164  strb     w8, [x21, #0xf56]
006AAF168  adrp     x8, #0x8f3a000
006AAF16C  ldr      x8, [x8, #0x478]
006AAF170  ldr      x2, [x8]
006AAF174  ldrb     w8, [x2, #0x53]
006AAF178  tbnz     w8, #5, #0x6aaf184
006AAF17C  str      w20, [x19, #0x4c]
006AAF180  b        #0x6aaf194 ; 
006AAF184  ldr      x8, [x2, #0x60]
006AAF188  mov      x0, x19
006AAF18C  mov      w1, w20
006AAF190  blr      x8
006AAF194  mov      x0, x19
006AAF198  mov      x1, xzr
006AAF19C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF1A0  adrp     x21, #0x959e000
006AAF1A4  ldrb     w8, [x21, #0xf57]
006AAF1A8  mov      w20, w0
006AAF1AC  cbnz     w8, #0x6aaf1c4
006AAF1B0  adrp     x0, #0x8f3a000
006AAF1B4  ldr      x0, [x0, #0x488]
006AAF1B8  bl       #0x382bd14 ; 
006AAF1BC  mov      w8, #1
006AAF1C0  strb     w8, [x21, #0xf57]
006AAF1C4  adrp     x8, #0x8f3a000
006AAF1C8  ldr      x8, [x8, #0x488]
006AAF1CC  ldr      x2, [x8]
006AAF1D0  ldrb     w8, [x2, #0x53]
006AAF1D4  tbnz     w8, #5, #0x6aaf1e0
006AAF1D8  str      w20, [x19, #0x50]
006AAF1DC  b        #0x6aaf1f0 ; 
006AAF1E0  ldr      x8, [x2, #0x60]
006AAF1E4  mov      x0, x19
006AAF1E8  mov      w1, w20
006AAF1EC  blr      x8
006AAF1F0  mov      x0, x19
006AAF1F4  mov      x1, xzr
006AAF1F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAF1FC  adrp     x21, #0x959e000
006AAF200  ldrb     w8, [x21, #0xf58]
006AAF204  mov      x20, x0
006AAF208  cbnz     w8, #0x6aaf220
006AAF20C  adrp     x0, #0x8f3a000
006AAF210  ldr      x0, [x0, #0x490]
006AAF214  bl       #0x382bd14 ; 
006AAF218  mov      w8, #1
006AAF21C  strb     w8, [x21, #0xf58]
006AAF220  adrp     x8, #0x8f3a000
006AAF224  ldr      x8, [x8, #0x490]
006AAF228  ldr      x2, [x8]
006AAF22C  ldrb     w8, [x2, #0x53]
006AAF230  tbnz     w8, #5, #0x6aaf248
006AAF234  mov      x0, x19
006AAF238  str      x20, [x0, #0x58]!
006AAF23C  mov      x1, x20
006AAF240  bl       #0x382bcb8 ; 
006AAF244  b        #0x6aaf258 ; 
006AAF248  ldr      x8, [x2, #0x60]
006AAF24C  mov      x0, x19
006AAF250  mov      x1, x20
006AAF254  blr      x8
006AAF258  mov      x0, x19
006AAF25C  mov      x1, xzr
006AAF260  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAF264  adrp     x21, #0x959e000
006AAF268  ldrb     w8, [x21, #0xf59]
006AAF26C  mov      x20, x0
006AAF270  cbnz     w8, #0x6aaf288
006AAF274  adrp     x0, #0x8f3a000
006AAF278  ldr      x0, [x0, #0x4a0]
006AAF27C  bl       #0x382bd14 ; 
006AAF280  mov      w8, #1
006AAF284  strb     w8, [x21, #0xf59]
006AAF288  adrp     x8, #0x8f3a000
006AAF28C  ldr      x8, [x8, #0x4a0]
006AAF290  ldr      x2, [x8]
006AAF294  ldrb     w8, [x2, #0x53]
006AAF298  tbnz     w8, #5, #0x6aaf2b0
006AAF29C  mov      x0, x19
006AAF2A0  str      x20, [x0, #0x60]!
006AAF2A4  mov      x1, x20
006AAF2A8  bl       #0x382bcb8 ; 
006AAF2AC  b        #0x6aaf2c0 ; 
006AAF2B0  ldr      x8, [x2, #0x60]
006AAF2B4  mov      x0, x19
006AAF2B8  mov      x1, x20
006AAF2BC  blr      x8
006AAF2C0  mov      x0, x19
006AAF2C4  mov      x1, xzr
006AAF2C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF2CC  adrp     x21, #0x959e000
006AAF2D0  ldrb     w8, [x21, #0xf5a]
006AAF2D4  mov      w20, w0
006AAF2D8  cbnz     w8, #0x6aaf2f0
006AAF2DC  adrp     x0, #0x8f3a000
006AAF2E0  ldr      x0, [x0, #0x4b0]
006AAF2E4  bl       #0x382bd14 ; 
006AAF2E8  mov      w8, #1
006AAF2EC  strb     w8, [x21, #0xf5a]
006AAF2F0  adrp     x8, #0x8f3a000
006AAF2F4  ldr      x8, [x8, #0x4b0]
006AAF2F8  ldr      x2, [x8]
006AAF2FC  ldrb     w8, [x2, #0x53]
006AAF300  tbnz     w8, #5, #0x6aaf30c
006AAF304  str      w20, [x19, #0x68]
006AAF308  b        #0x6aaf31c ; 
006AAF30C  ldr      x8, [x2, #0x60]
006AAF310  mov      x0, x19
006AAF314  mov      w1, w20
006AAF318  blr      x8
006AAF31C  mov      x0, x19
006AAF320  mov      x1, xzr
006AAF324  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF328  adrp     x21, #0x959e000
006AAF32C  ldrb     w8, [x21, #0xf5b]
006AAF330  mov      w20, w0
006AAF334  cbnz     w8, #0x6aaf34c
006AAF338  adrp     x0, #0x8f3a000
006AAF33C  ldr      x0, [x0, #0x4c0]
006AAF340  bl       #0x382bd14 ; 
006AAF344  mov      w8, #1
006AAF348  strb     w8, [x21, #0xf5b]
006AAF34C  adrp     x8, #0x8f3a000
006AAF350  ldr      x8, [x8, #0x4c0]
006AAF354  ldr      x2, [x8]
006AAF358  ldrb     w8, [x2, #0x53]
006AAF35C  tbnz     w8, #5, #0x6aaf368
006AAF360  str      w20, [x19, #0x6c]
006AAF364  b        #0x6aaf378 ; 
006AAF368  ldr      x8, [x2, #0x60]
006AAF36C  mov      x0, x19
006AAF370  mov      w1, w20
006AAF374  blr      x8
006AAF378  mov      x0, x19
006AAF37C  mov      x1, xzr
006AAF380  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF384  adrp     x21, #0x959e000
006AAF388  ldrb     w8, [x21, #0xf5c]
006AAF38C  mov      w20, w0
006AAF390  cbnz     w8, #0x6aaf3a8
006AAF394  adrp     x0, #0x8f3a000
006AAF398  ldr      x0, [x0, #0x4d0]
006AAF39C  bl       #0x382bd14 ; 
006AAF3A0  mov      w8, #1
006AAF3A4  strb     w8, [x21, #0xf5c]
006AAF3A8  adrp     x8, #0x8f3a000
006AAF3AC  ldr      x8, [x8, #0x4d0]
006AAF3B0  ldr      x2, [x8]
006AAF3B4  ldrb     w8, [x2, #0x53]
006AAF3B8  tbnz     w8, #5, #0x6aaf3c4
006AAF3BC  str      w20, [x19, #0x70]
006AAF3C0  b        #0x6aaf3d4 ; 
006AAF3C4  ldr      x8, [x2, #0x60]
006AAF3C8  mov      x0, x19
006AAF3CC  mov      w1, w20
006AAF3D0  blr      x8
006AAF3D4  mov      x0, x19
006AAF3D8  mov      x1, xzr
006AAF3DC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AAF3E0  adrp     x21, #0x959e000
006AAF3E4  ldrb     w8, [x21, #0xf5d]
006AAF3E8  mov      x20, x0
006AAF3EC  cbnz     w8, #0x6aaf404
006AAF3F0  adrp     x0, #0x8f3a000
006AAF3F4  ldr      x0, [x0, #0x4e0]
006AAF3F8  bl       #0x382bd14 ; 
006AAF3FC  mov      w8, #1
006AAF400  strb     w8, [x21, #0xf5d]
006AAF404  adrp     x8, #0x8f3a000
006AAF408  ldr      x8, [x8, #0x4e0]
006AAF40C  ldr      x2, [x8]
006AAF410  ldrb     w8, [x2, #0x53]
006AAF414  tbnz     w8, #5, #0x6aaf42c
006AAF418  mov      x0, x19
006AAF41C  str      x20, [x0, #0x78]!
006AAF420  mov      x1, x20
006AAF424  bl       #0x382bcb8 ; 
006AAF428  b        #0x6aaf43c ; 
006AAF42C  ldr      x8, [x2, #0x60]
006AAF430  mov      x0, x19
006AAF434  mov      x1, x20
006AAF438  blr      x8
006AAF43C  mov      x0, x19
006AAF440  mov      x1, xzr
006AAF444  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAF448  adrp     x21, #0x959e000
006AAF44C  ldrb     w8, [x21, #0xf5e]
006AAF450  mov      x20, x0
006AAF454  cbnz     w8, #0x6aaf46c
006AAF458  adrp     x0, #0x8f3a000
006AAF45C  ldr      x0, [x0, #0x4f0]
006AAF460  bl       #0x382bd14 ; 
006AAF464  mov      w8, #1
006AAF468  strb     w8, [x21, #0xf5e]
006AAF46C  adrp     x8, #0x8f3a000
006AAF470  ldr      x8, [x8, #0x4f0]
006AAF474  ldr      x2, [x8]
006AAF478  ldrb     w8, [x2, #0x53]
006AAF47C  tbnz     w8, #5, #0x6aaf494
006AAF480  mov      x0, x19
006AAF484  str      x20, [x0, #0x80]!
006AAF488  mov      x1, x20
006AAF48C  bl       #0x382bcb8 ; 
006AAF490  b        #0x6aaf4a4 ; 
006AAF494  ldr      x8, [x2, #0x60]
006AAF498  mov      x0, x19
006AAF49C  mov      x1, x20
006AAF4A0  blr      x8
006AAF4A4  mov      x0, x19
006AAF4A8  mov      x1, xzr
006AAF4AC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAF4B0  adrp     x21, #0x959e000
006AAF4B4  ldrb     w8, [x21, #0xf5f]
006AAF4B8  mov      x20, x0
006AAF4BC  cbnz     w8, #0x6aaf4d4
006AAF4C0  adrp     x0, #0x8f3a000
006AAF4C4  ldr      x0, [x0, #0x500]
006AAF4C8  bl       #0x382bd14 ; 
006AAF4CC  mov      w8, #1
006AAF4D0  strb     w8, [x21, #0xf5f]
006AAF4D4  adrp     x8, #0x8f3a000
006AAF4D8  ldr      x8, [x8, #0x500]
006AAF4DC  ldr      x2, [x8]
006AAF4E0  ldrb     w8, [x2, #0x53]
006AAF4E4  tbnz     w8, #5, #0x6aaf4fc
006AAF4E8  mov      x0, x19
006AAF4EC  str      x20, [x0, #0x88]!
006AAF4F0  mov      x1, x20
006AAF4F4  bl       #0x382bcb8 ; 
006AAF4F8  b        #0x6aaf50c ; 
006AAF4FC  ldr      x8, [x2, #0x60]
006AAF500  mov      x0, x19
006AAF504  mov      x1, x20
006AAF508  blr      x8
006AAF50C  mov      x0, x19
006AAF510  mov      x1, xzr
006AAF514  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AAF518  adrp     x21, #0x959e000
006AAF51C  ldrb     w8, [x21, #0xf60]
006AAF520  mov      x20, x0
006AAF524  cbnz     w8, #0x6aaf53c
006AAF528  adrp     x0, #0x8f3a000
006AAF52C  ldr      x0, [x0, #0x510]
006AAF530  bl       #0x382bd14 ; 
006AAF534  mov      w8, #1
006AAF538  strb     w8, [x21, #0xf60]
006AAF53C  adrp     x8, #0x8f3a000
006AAF540  ldr      x8, [x8, #0x510]
006AAF544  ldr      x2, [x8]
006AAF548  ldrb     w8, [x2, #0x53]
006AAF54C  tbnz     w8, #5, #0x6aaf564
006AAF550  mov      x0, x19
006AAF554  str      x20, [x0, #0x90]!
006AAF558  mov      x1, x20
006AAF55C  bl       #0x382bcb8 ; 
006AAF560  b        #0x6aaf574 ; 
006AAF564  ldr      x8, [x2, #0x60]
006AAF568  mov      x0, x19
006AAF56C  mov      x1, x20
006AAF570  blr      x8
006AAF574  mov      x0, x19
006AAF578  mov      x1, xzr
006AAF57C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAF580  adrp     x21, #0x959e000
006AAF584  ldrb     w8, [x21, #0xf61]
006AAF588  mov      x20, x0
006AAF58C  cbnz     w8, #0x6aaf5a4
006AAF590  adrp     x0, #0x8f3a000
006AAF594  ldr      x0, [x0, #0x520]
006AAF598  bl       #0x382bd14 ; 
006AAF59C  mov      w8, #1
006AAF5A0  strb     w8, [x21, #0xf61]
006AAF5A4  adrp     x8, #0x8f3a000
006AAF5A8  ldr      x8, [x8, #0x520]
006AAF5AC  ldr      x2, [x8]
006AAF5B0  ldrb     w8, [x2, #0x53]
006AAF5B4  tbnz     w8, #5, #0x6aaf5cc
006AAF5B8  mov      x0, x19
006AAF5BC  str      x20, [x0, #0x98]!
006AAF5C0  mov      x1, x20
006AAF5C4  bl       #0x382bcb8 ; 
006AAF5C8  b        #0x6aaf5dc ; 
006AAF5CC  ldr      x8, [x2, #0x60]
006AAF5D0  mov      x0, x19
006AAF5D4  mov      x1, x20
006AAF5D8  blr      x8
006AAF5DC  mov      x0, x19
006AAF5E0  mov      x1, xzr
006AAF5E4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAF5E8  adrp     x21, #0x959e000
006AAF5EC  ldrb     w8, [x21, #0xf62]
006AAF5F0  mov      x20, x0
006AAF5F4  cbnz     w8, #0x6aaf60c
006AAF5F8  adrp     x0, #0x8f3a000
006AAF5FC  ldr      x0, [x0, #0x530]
006AAF600  bl       #0x382bd14 ; 
006AAF604  mov      w8, #1
006AAF608  strb     w8, [x21, #0xf62]
006AAF60C  adrp     x8, #0x8f3a000
006AAF610  ldr      x8, [x8, #0x530]
006AAF614  ldr      x2, [x8]
006AAF618  ldrb     w8, [x2, #0x53]
006AAF61C  tbnz     w8, #5, #0x6aaf634
006AAF620  mov      x0, x19
006AAF624  str      x20, [x0, #0xa0]!
006AAF628  mov      x1, x20
006AAF62C  bl       #0x382bcb8 ; 
006AAF630  b        #0x6aaf644 ; 
006AAF634  ldr      x8, [x2, #0x60]
006AAF638  mov      x0, x19
006AAF63C  mov      x1, x20
006AAF640  blr      x8
006AAF644  mov      x0, x19
006AAF648  mov      x1, xzr
006AAF64C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF650  adrp     x21, #0x959e000
006AAF654  ldrb     w8, [x21, #0xf63]
006AAF658  mov      w20, w0
006AAF65C  cbnz     w8, #0x6aaf674
006AAF660  adrp     x0, #0x8f3a000
006AAF664  ldr      x0, [x0, #0x540]
006AAF668  bl       #0x382bd14 ; 
006AAF66C  mov      w8, #1
006AAF670  strb     w8, [x21, #0xf63]
006AAF674  adrp     x8, #0x8f3a000
006AAF678  ldr      x8, [x8, #0x540]
006AAF67C  ldr      x2, [x8]
006AAF680  ldrb     w8, [x2, #0x53]
006AAF684  tbnz     w8, #5, #0x6aaf690
006AAF688  str      w20, [x19, #0xa8]
006AAF68C  b        #0x6aaf6a0 ; 
006AAF690  ldr      x8, [x2, #0x60]
006AAF694  mov      x0, x19
006AAF698  mov      w1, w20
006AAF69C  blr      x8
006AAF6A0  mov      x0, x19
006AAF6A4  mov      x1, xzr
006AAF6A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF6AC  adrp     x21, #0x959e000
006AAF6B0  ldrb     w8, [x21, #0xf64]
006AAF6B4  mov      w20, w0
006AAF6B8  cbnz     w8, #0x6aaf6d0
006AAF6BC  adrp     x0, #0x8f3a000
006AAF6C0  ldr      x0, [x0, #0x550]
006AAF6C4  bl       #0x382bd14 ; 
006AAF6C8  mov      w8, #1
006AAF6CC  strb     w8, [x21, #0xf64]
006AAF6D0  adrp     x8, #0x8f3a000
006AAF6D4  ldr      x8, [x8, #0x550]
006AAF6D8  ldr      x2, [x8]
006AAF6DC  ldrb     w8, [x2, #0x53]
006AAF6E0  tbnz     w8, #5, #0x6aaf6ec
006AAF6E4  str      w20, [x19, #0xac]
006AAF6E8  b        #0x6aaf6fc ; 
006AAF6EC  ldr      x8, [x2, #0x60]
006AAF6F0  mov      x0, x19
006AAF6F4  mov      w1, w20
006AAF6F8  blr      x8
006AAF6FC  mov      x0, x19
006AAF700  mov      x1, xzr
006AAF704  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAF708  adrp     x21, #0x959e000
006AAF70C  ldrb     w8, [x21, #0xf65]
006AAF710  mov      w20, w0
006AAF714  cbnz     w8, #0x6aaf72c
006AAF718  adrp     x0, #0x8f3a000
006AAF71C  ldr      x0, [x0, #0x560]
006AAF720  bl       #0x382bd14 ; 
006AAF724  mov      w8, #1
006AAF728  strb     w8, [x21, #0xf65]
006AAF72C  adrp     x8, #0x8f3a000
006AAF730  ldr      x8, [x8, #0x560]
006AAF734  ldr      x2, [x8]
006AAF738  ldrb     w8, [x2, #0x53]
006AAF73C  tbnz     w8, #5, #0x6aaf748
006AAF740  str      w20, [x19, #0xb0]
006AAF744  b        #0x6aaf758 ; 
006AAF748  ldr      x8, [x2, #0x60]
006AAF74C  mov      x0, x19
006AAF750  mov      w1, w20
006AAF754  blr      x8
006AAF758  mov      x0, x19
006AAF75C  mov      x1, xzr
006AAF760  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAF764  adrp     x21, #0x959e000
006AAF768  ldrb     w8, [x21, #0xf66]
006AAF76C  mov      x20, x0
006AAF770  cbnz     w8, #0x6aaf788
006AAF774  adrp     x0, #0x8f3a000
006AAF778  ldr      x0, [x0, #0x570]
006AAF77C  bl       #0x382bd14 ; 
006AAF780  mov      w8, #1
006AAF784  strb     w8, [x21, #0xf66]
006AAF788  adrp     x8, #0x8f3a000
006AAF78C  ldr      x8, [x8, #0x570]
006AAF790  ldr      x2, [x8]
006AAF794  ldrb     w8, [x2, #0x53]
006AAF798  tbnz     w8, #5, #0x6aaf7b0
006AAF79C  mov      x0, x19
006AAF7A0  str      x20, [x0, #0xb8]!
006AAF7A4  mov      x1, x20
006AAF7A8  bl       #0x382bcb8 ; 
006AAF7AC  b        #0x6aaf7c0 ; 
006AAF7B0  ldr      x8, [x2, #0x60]
006AAF7B4  mov      x0, x19
006AAF7B8  mov      x1, x20
006AAF7BC  blr      x8
006AAF7C0  mov      x0, x19
006AAF7C4  mov      x1, xzr
006AAF7C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAF7CC  adrp     x21, #0x959e000
006AAF7D0  ldrb     w8, [x21, #0xf67]
006AAF7D4  mov      x20, x0
006AAF7D8  cbnz     w8, #0x6aaf7f0
006AAF7DC  adrp     x0, #0x8f3a000
006AAF7E0  ldr      x0, [x0, #0x580]
006AAF7E4  bl       #0x382bd14 ; 
006AAF7E8  mov      w8, #1
006AAF7EC  strb     w8, [x21, #0xf67]
006AAF7F0  adrp     x8, #0x8f3a000
006AAF7F4  ldr      x8, [x8, #0x580]
006AAF7F8  ldr      x2, [x8]
006AAF7FC  ldrb     w8, [x2, #0x53]
006AAF800  tbnz     w8, #5, #0x6aaf818
006AAF804  mov      x0, x19
006AAF808  str      x20, [x0, #0xc0]!
006AAF80C  mov      x1, x20
006AAF810  bl       #0x382bcb8 ; 
006AAF814  b        #0x6aaf828 ; 
006AAF818  ldr      x8, [x2, #0x60]
006AAF81C  mov      x0, x19
006AAF820  mov      x1, x20
006AAF824  blr      x8
006AAF828  mov      x0, x19
006AAF82C  mov      x1, xzr
006AAF830  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAF834  adrp     x21, #0x959e000
006AAF838  ldrb     w8, [x21, #0xf68]
006AAF83C  mov      x20, x0
006AAF840  cbnz     w8, #0x6aaf858
006AAF844  adrp     x0, #0x8f3a000
006AAF848  ldr      x0, [x0, #0x590]
006AAF84C  bl       #0x382bd14 ; 
006AAF850  mov      w8, #1
006AAF854  strb     w8, [x21, #0xf68]
006AAF858  adrp     x8, #0x8f3a000
006AAF85C  ldr      x8, [x8, #0x590]
006AAF860  ldr      x2, [x8]
006AAF864  ldrb     w8, [x2, #0x53]
006AAF868  tbnz     w8, #5, #0x6aaf880
006AAF86C  str      x20, [x19, #0xc8]!
006AAF870  mov      x0, x19
006AAF874  mov      x1, x20
006AAF878  bl       #0x382bcb8 ; 
006AAF87C  b        #0x6aaf890 ; 
006AAF880  ldr      x8, [x2, #0x60]
006AAF884  mov      x0, x19
006AAF888  mov      x1, x20
006AAF88C  blr      x8
006AAF890  ldp      x20, x19, [sp, #0x10]
006AAF894  mov      w0, #1
006AAF898  ldp      x30, x21, [sp], #0x20
006AAF89C  ret      

