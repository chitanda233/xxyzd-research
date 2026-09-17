; LocalModels.Bean.Avatar_Avatar$$readImpl
; RVA 0x66FB960; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066FB960  stp      x30, x21, [sp, #-0x20]!
0066FB964  stp      x20, x19, [sp, #0x10]
0066FB968  adrp     x20, #0x959a000
0066FB96C  adrp     x21, #0x8f17000
0066FB970  ldrb     w8, [x20, #0x814]
0066FB974  ldr      x21, [x21, #0x300]
0066FB978  mov      x19, x0
0066FB97C  tbnz     w8, #0, #0x66fb994
0066FB980  adrp     x0, #0x8f17000
0066FB984  ldr      x0, [x0, #0x300]
0066FB988  bl       #0x382bd14 ; 
0066FB98C  mov      w8, #1
0066FB990  strb     w8, [x20, #0x814]
0066FB994  ldr      x1, [x21]
0066FB998  ldrb     w8, [x1, #0x53]
0066FB99C  tbnz     w8, #5, #0x66fb9ec
0066FB9A0  mov      x0, x19
0066FB9A4  mov      x1, xzr
0066FB9A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FB9AC  adrp     x21, #0x959a000
0066FB9B0  ldrb     w8, [x21, #0x911]
0066FB9B4  mov      w20, w0
0066FB9B8  cbnz     w8, #0x66fb9d0
0066FB9BC  adrp     x0, #0x8f17000
0066FB9C0  ldr      x0, [x0, #0x1d8]
0066FB9C4  bl       #0x382bd14 ; 
0066FB9C8  mov      w8, #1
0066FB9CC  strb     w8, [x21, #0x911]
0066FB9D0  adrp     x8, #0x8f17000
0066FB9D4  ldr      x8, [x8, #0x1d8]
0066FB9D8  ldr      x2, [x8]
0066FB9DC  ldrb     w8, [x2, #0x53]
0066FB9E0  tbnz     w8, #5, #0x66fba00
0066FB9E4  str      w20, [x19, #0x20]
0066FB9E8  b        #0x66fba10 ; 
0066FB9EC  ldr      x2, [x1, #0x60]
0066FB9F0  mov      x0, x19
0066FB9F4  ldp      x20, x19, [sp, #0x10]
0066FB9F8  ldp      x30, x21, [sp], #0x20
0066FB9FC  br       x2
0066FBA00  ldr      x8, [x2, #0x60]
0066FBA04  mov      x0, x19
0066FBA08  mov      w1, w20
0066FBA0C  blr      x8
0066FBA10  mov      x0, x19
0066FBA14  mov      x1, xzr
0066FBA18  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBA1C  adrp     x21, #0x959a000
0066FBA20  ldrb     w8, [x21, #0x912]
0066FBA24  mov      x20, x0
0066FBA28  cbnz     w8, #0x66fba40
0066FBA2C  adrp     x0, #0x8f17000
0066FBA30  ldr      x0, [x0, #0x1e8]
0066FBA34  bl       #0x382bd14 ; 
0066FBA38  mov      w8, #1
0066FBA3C  strb     w8, [x21, #0x912]
0066FBA40  adrp     x8, #0x8f17000
0066FBA44  ldr      x8, [x8, #0x1e8]
0066FBA48  ldr      x2, [x8]
0066FBA4C  ldrb     w8, [x2, #0x53]
0066FBA50  tbnz     w8, #5, #0x66fba68
0066FBA54  mov      x0, x19
0066FBA58  str      x20, [x0, #0x28]!
0066FBA5C  mov      x1, x20
0066FBA60  bl       #0x382bcb8 ; 
0066FBA64  b        #0x66fba78 ; 
0066FBA68  ldr      x8, [x2, #0x60]
0066FBA6C  mov      x0, x19
0066FBA70  mov      x1, x20
0066FBA74  blr      x8
0066FBA78  mov      x0, x19
0066FBA7C  mov      x1, xzr
0066FBA80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FBA84  adrp     x21, #0x959a000
0066FBA88  ldrb     w8, [x21, #0x913]
0066FBA8C  mov      w20, w0
0066FBA90  cbnz     w8, #0x66fbaa8
0066FBA94  adrp     x0, #0x8f17000
0066FBA98  ldr      x0, [x0, #0x1f8]
0066FBA9C  bl       #0x382bd14 ; 
0066FBAA0  mov      w8, #1
0066FBAA4  strb     w8, [x21, #0x913]
0066FBAA8  adrp     x8, #0x8f17000
0066FBAAC  ldr      x8, [x8, #0x1f8]
0066FBAB0  ldr      x2, [x8]
0066FBAB4  ldrb     w8, [x2, #0x53]
0066FBAB8  tbnz     w8, #5, #0x66fbac4
0066FBABC  str      w20, [x19, #0x30]
0066FBAC0  b        #0x66fbad4 ; 
0066FBAC4  ldr      x8, [x2, #0x60]
0066FBAC8  mov      x0, x19
0066FBACC  mov      w1, w20
0066FBAD0  blr      x8
0066FBAD4  mov      x0, x19
0066FBAD8  mov      x1, xzr
0066FBADC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FBAE0  adrp     x21, #0x959a000
0066FBAE4  ldrb     w8, [x21, #0x914]
0066FBAE8  mov      w20, w0
0066FBAEC  cbnz     w8, #0x66fbb04
0066FBAF0  adrp     x0, #0x8f17000
0066FBAF4  ldr      x0, [x0, #0x208]
0066FBAF8  bl       #0x382bd14 ; 
0066FBAFC  mov      w8, #1
0066FBB00  strb     w8, [x21, #0x914]
0066FBB04  adrp     x8, #0x8f17000
0066FBB08  ldr      x8, [x8, #0x208]
0066FBB0C  ldr      x2, [x8]
0066FBB10  ldrb     w8, [x2, #0x53]
0066FBB14  tbnz     w8, #5, #0x66fbb20
0066FBB18  str      w20, [x19, #0x34]
0066FBB1C  b        #0x66fbb30 ; 
0066FBB20  ldr      x8, [x2, #0x60]
0066FBB24  mov      x0, x19
0066FBB28  mov      w1, w20
0066FBB2C  blr      x8
0066FBB30  mov      x0, x19
0066FBB34  mov      x1, xzr
0066FBB38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FBB3C  adrp     x21, #0x959a000
0066FBB40  ldrb     w8, [x21, #0x915]
0066FBB44  mov      w20, w0
0066FBB48  cbnz     w8, #0x66fbb60
0066FBB4C  adrp     x0, #0x8f17000
0066FBB50  ldr      x0, [x0, #0x218]
0066FBB54  bl       #0x382bd14 ; 
0066FBB58  mov      w8, #1
0066FBB5C  strb     w8, [x21, #0x915]
0066FBB60  adrp     x8, #0x8f17000
0066FBB64  ldr      x8, [x8, #0x218]
0066FBB68  ldr      x2, [x8]
0066FBB6C  ldrb     w8, [x2, #0x53]
0066FBB70  tbnz     w8, #5, #0x66fbb7c
0066FBB74  str      w20, [x19, #0x38]
0066FBB78  b        #0x66fbb8c ; 
0066FBB7C  ldr      x8, [x2, #0x60]
0066FBB80  mov      x0, x19
0066FBB84  mov      w1, w20
0066FBB88  blr      x8
0066FBB8C  mov      x0, x19
0066FBB90  mov      x1, xzr
0066FBB94  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBB98  adrp     x21, #0x959a000
0066FBB9C  ldrb     w8, [x21, #0x916]
0066FBBA0  mov      x20, x0
0066FBBA4  cbnz     w8, #0x66fbbbc
0066FBBA8  adrp     x0, #0x8f17000
0066FBBAC  ldr      x0, [x0, #0x228]
0066FBBB0  bl       #0x382bd14 ; 
0066FBBB4  mov      w8, #1
0066FBBB8  strb     w8, [x21, #0x916]
0066FBBBC  adrp     x8, #0x8f17000
0066FBBC0  ldr      x8, [x8, #0x228]
0066FBBC4  ldr      x2, [x8]
0066FBBC8  ldrb     w8, [x2, #0x53]
0066FBBCC  tbnz     w8, #5, #0x66fbbe4
0066FBBD0  mov      x0, x19
0066FBBD4  str      x20, [x0, #0x40]!
0066FBBD8  mov      x1, x20
0066FBBDC  bl       #0x382bcb8 ; 
0066FBBE0  b        #0x66fbbf4 ; 
0066FBBE4  ldr      x8, [x2, #0x60]
0066FBBE8  mov      x0, x19
0066FBBEC  mov      x1, x20
0066FBBF0  blr      x8
0066FBBF4  mov      x0, x19
0066FBBF8  mov      x1, xzr
0066FBBFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FBC00  adrp     x21, #0x959a000
0066FBC04  ldrb     w8, [x21, #0x917]
0066FBC08  mov      w20, w0
0066FBC0C  cbnz     w8, #0x66fbc24
0066FBC10  adrp     x0, #0x8f17000
0066FBC14  ldr      x0, [x0, #0x238]
0066FBC18  bl       #0x382bd14 ; 
0066FBC1C  mov      w8, #1
0066FBC20  strb     w8, [x21, #0x917]
0066FBC24  adrp     x8, #0x8f17000
0066FBC28  ldr      x8, [x8, #0x238]
0066FBC2C  ldr      x2, [x8]
0066FBC30  ldrb     w8, [x2, #0x53]
0066FBC34  tbnz     w8, #5, #0x66fbc40
0066FBC38  str      w20, [x19, #0x48]
0066FBC3C  b        #0x66fbc50 ; 
0066FBC40  ldr      x8, [x2, #0x60]
0066FBC44  mov      x0, x19
0066FBC48  mov      w1, w20
0066FBC4C  blr      x8
0066FBC50  mov      x0, x19
0066FBC54  mov      x1, xzr
0066FBC58  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBC5C  adrp     x21, #0x959a000
0066FBC60  ldrb     w8, [x21, #0x918]
0066FBC64  mov      x20, x0
0066FBC68  cbnz     w8, #0x66fbc80
0066FBC6C  adrp     x0, #0x8f17000
0066FBC70  ldr      x0, [x0, #0x248]
0066FBC74  bl       #0x382bd14 ; 
0066FBC78  mov      w8, #1
0066FBC7C  strb     w8, [x21, #0x918]
0066FBC80  adrp     x8, #0x8f17000
0066FBC84  ldr      x8, [x8, #0x248]
0066FBC88  ldr      x2, [x8]
0066FBC8C  ldrb     w8, [x2, #0x53]
0066FBC90  tbnz     w8, #5, #0x66fbca8
0066FBC94  mov      x0, x19
0066FBC98  str      x20, [x0, #0x50]!
0066FBC9C  mov      x1, x20
0066FBCA0  bl       #0x382bcb8 ; 
0066FBCA4  b        #0x66fbcb8 ; 
0066FBCA8  ldr      x8, [x2, #0x60]
0066FBCAC  mov      x0, x19
0066FBCB0  mov      x1, x20
0066FBCB4  blr      x8
0066FBCB8  mov      x0, x19
0066FBCBC  mov      x1, xzr
0066FBCC0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBCC4  adrp     x21, #0x959a000
0066FBCC8  ldrb     w8, [x21, #0x919]
0066FBCCC  mov      x20, x0
0066FBCD0  cbnz     w8, #0x66fbce8
0066FBCD4  adrp     x0, #0x8f17000
0066FBCD8  ldr      x0, [x0, #0x258]
0066FBCDC  bl       #0x382bd14 ; 
0066FBCE0  mov      w8, #1
0066FBCE4  strb     w8, [x21, #0x919]
0066FBCE8  adrp     x8, #0x8f17000
0066FBCEC  ldr      x8, [x8, #0x258]
0066FBCF0  ldr      x2, [x8]
0066FBCF4  ldrb     w8, [x2, #0x53]
0066FBCF8  tbnz     w8, #5, #0x66fbd10
0066FBCFC  mov      x0, x19
0066FBD00  str      x20, [x0, #0x58]!
0066FBD04  mov      x1, x20
0066FBD08  bl       #0x382bcb8 ; 
0066FBD0C  b        #0x66fbd20 ; 
0066FBD10  ldr      x8, [x2, #0x60]
0066FBD14  mov      x0, x19
0066FBD18  mov      x1, x20
0066FBD1C  blr      x8
0066FBD20  mov      x0, x19
0066FBD24  mov      x1, xzr
0066FBD28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FBD2C  adrp     x21, #0x959a000
0066FBD30  ldrb     w8, [x21, #0x91a]
0066FBD34  mov      w20, w0
0066FBD38  cbnz     w8, #0x66fbd50
0066FBD3C  adrp     x0, #0x8f17000
0066FBD40  ldr      x0, [x0, #0x268]
0066FBD44  bl       #0x382bd14 ; 
0066FBD48  mov      w8, #1
0066FBD4C  strb     w8, [x21, #0x91a]
0066FBD50  adrp     x8, #0x8f17000
0066FBD54  ldr      x8, [x8, #0x268]
0066FBD58  ldr      x2, [x8]
0066FBD5C  ldrb     w8, [x2, #0x53]
0066FBD60  tbnz     w8, #5, #0x66fbd6c
0066FBD64  str      w20, [x19, #0x60]
0066FBD68  b        #0x66fbd7c ; 
0066FBD6C  ldr      x8, [x2, #0x60]
0066FBD70  mov      x0, x19
0066FBD74  mov      w1, w20
0066FBD78  blr      x8
0066FBD7C  mov      x0, x19
0066FBD80  mov      x1, xzr
0066FBD84  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0066FBD88  adrp     x21, #0x959a000
0066FBD8C  ldrb     w8, [x21, #0x91b]
0066FBD90  mov      x20, x0
0066FBD94  cbnz     w8, #0x66fbdac
0066FBD98  adrp     x0, #0x8f17000
0066FBD9C  ldr      x0, [x0, #0x278]
0066FBDA0  bl       #0x382bd14 ; 
0066FBDA4  mov      w8, #1
0066FBDA8  strb     w8, [x21, #0x91b]
0066FBDAC  adrp     x8, #0x8f17000
0066FBDB0  ldr      x8, [x8, #0x278]
0066FBDB4  ldr      x2, [x8]
0066FBDB8  ldrb     w8, [x2, #0x53]
0066FBDBC  tbnz     w8, #5, #0x66fbdd4
0066FBDC0  mov      x0, x19
0066FBDC4  str      x20, [x0, #0x68]!
0066FBDC8  mov      x1, x20
0066FBDCC  bl       #0x382bcb8 ; 
0066FBDD0  b        #0x66fbde4 ; 
0066FBDD4  ldr      x8, [x2, #0x60]
0066FBDD8  mov      x0, x19
0066FBDDC  mov      x1, x20
0066FBDE0  blr      x8
0066FBDE4  mov      x0, x19
0066FBDE8  mov      x1, xzr
0066FBDEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FBDF0  adrp     x21, #0x959a000
0066FBDF4  ldrb     w8, [x21, #0x91c]
0066FBDF8  mov      w20, w0
0066FBDFC  cbnz     w8, #0x66fbe14
0066FBE00  adrp     x0, #0x8f17000
0066FBE04  ldr      x0, [x0, #0x288]
0066FBE08  bl       #0x382bd14 ; 
0066FBE0C  mov      w8, #1
0066FBE10  strb     w8, [x21, #0x91c]
0066FBE14  adrp     x8, #0x8f17000
0066FBE18  ldr      x8, [x8, #0x288]
0066FBE1C  ldr      x2, [x8]
0066FBE20  ldrb     w8, [x2, #0x53]
0066FBE24  tbnz     w8, #5, #0x66fbe30
0066FBE28  str      w20, [x19, #0x70]
0066FBE2C  b        #0x66fbe40 ; 
0066FBE30  ldr      x8, [x2, #0x60]
0066FBE34  mov      x0, x19
0066FBE38  mov      w1, w20
0066FBE3C  blr      x8
0066FBE40  mov      x0, x19
0066FBE44  mov      x1, xzr
0066FBE48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FBE4C  adrp     x21, #0x959a000
0066FBE50  ldrb     w8, [x21, #0x91d]
0066FBE54  mov      w20, w0
0066FBE58  cbnz     w8, #0x66fbe70
0066FBE5C  adrp     x0, #0x8f17000
0066FBE60  ldr      x0, [x0, #0x298]
0066FBE64  bl       #0x382bd14 ; 
0066FBE68  mov      w8, #1
0066FBE6C  strb     w8, [x21, #0x91d]
0066FBE70  adrp     x8, #0x8f17000
0066FBE74  ldr      x8, [x8, #0x298]
0066FBE78  ldr      x2, [x8]
0066FBE7C  ldrb     w8, [x2, #0x53]
0066FBE80  tbnz     w8, #5, #0x66fbe8c
0066FBE84  str      w20, [x19, #0x74]
0066FBE88  b        #0x66fbe9c ; 
0066FBE8C  ldr      x8, [x2, #0x60]
0066FBE90  mov      x0, x19
0066FBE94  mov      w1, w20
0066FBE98  blr      x8
0066FBE9C  mov      x0, x19
0066FBEA0  mov      x1, xzr
0066FBEA4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBEA8  adrp     x21, #0x959a000
0066FBEAC  ldrb     w8, [x21, #0x91e]
0066FBEB0  mov      x20, x0
0066FBEB4  cbnz     w8, #0x66fbecc
0066FBEB8  adrp     x0, #0x8f17000
0066FBEBC  ldr      x0, [x0, #0x2a0]
0066FBEC0  bl       #0x382bd14 ; 
0066FBEC4  mov      w8, #1
0066FBEC8  strb     w8, [x21, #0x91e]
0066FBECC  adrp     x8, #0x8f17000
0066FBED0  ldr      x8, [x8, #0x2a0]
0066FBED4  ldr      x2, [x8]
0066FBED8  ldrb     w8, [x2, #0x53]
0066FBEDC  tbnz     w8, #5, #0x66fbef4
0066FBEE0  mov      x0, x19
0066FBEE4  str      x20, [x0, #0x78]!
0066FBEE8  mov      x1, x20
0066FBEEC  bl       #0x382bcb8 ; 
0066FBEF0  b        #0x66fbf04 ; 
0066FBEF4  ldr      x8, [x2, #0x60]
0066FBEF8  mov      x0, x19
0066FBEFC  mov      x1, x20
0066FBF00  blr      x8
0066FBF04  mov      x0, x19
0066FBF08  mov      x1, xzr
0066FBF0C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBF10  adrp     x21, #0x959a000
0066FBF14  ldrb     w8, [x21, #0x91f]
0066FBF18  mov      x20, x0
0066FBF1C  cbnz     w8, #0x66fbf34
0066FBF20  adrp     x0, #0x8f17000
0066FBF24  ldr      x0, [x0, #0x2a8]
0066FBF28  bl       #0x382bd14 ; 
0066FBF2C  mov      w8, #1
0066FBF30  strb     w8, [x21, #0x91f]
0066FBF34  adrp     x8, #0x8f17000
0066FBF38  ldr      x8, [x8, #0x2a8]
0066FBF3C  ldr      x2, [x8]
0066FBF40  ldrb     w8, [x2, #0x53]
0066FBF44  tbnz     w8, #5, #0x66fbf5c
0066FBF48  mov      x0, x19
0066FBF4C  str      x20, [x0, #0x80]!
0066FBF50  mov      x1, x20
0066FBF54  bl       #0x382bcb8 ; 
0066FBF58  b        #0x66fbf6c ; 
0066FBF5C  ldr      x8, [x2, #0x60]
0066FBF60  mov      x0, x19
0066FBF64  mov      x1, x20
0066FBF68  blr      x8
0066FBF6C  mov      x0, x19
0066FBF70  mov      x1, xzr
0066FBF74  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBF78  adrp     x21, #0x959a000
0066FBF7C  ldrb     w8, [x21, #0x920]
0066FBF80  mov      x20, x0
0066FBF84  cbnz     w8, #0x66fbf9c
0066FBF88  adrp     x0, #0x8f17000
0066FBF8C  ldr      x0, [x0, #0x2b8]
0066FBF90  bl       #0x382bd14 ; 
0066FBF94  mov      w8, #1
0066FBF98  strb     w8, [x21, #0x920]
0066FBF9C  adrp     x8, #0x8f17000
0066FBFA0  ldr      x8, [x8, #0x2b8]
0066FBFA4  ldr      x2, [x8]
0066FBFA8  ldrb     w8, [x2, #0x53]
0066FBFAC  tbnz     w8, #5, #0x66fbfc4
0066FBFB0  mov      x0, x19
0066FBFB4  str      x20, [x0, #0x88]!
0066FBFB8  mov      x1, x20
0066FBFBC  bl       #0x382bcb8 ; 
0066FBFC0  b        #0x66fbfd4 ; 
0066FBFC4  ldr      x8, [x2, #0x60]
0066FBFC8  mov      x0, x19
0066FBFCC  mov      x1, x20
0066FBFD0  blr      x8
0066FBFD4  mov      x0, x19
0066FBFD8  mov      x1, xzr
0066FBFDC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FBFE0  adrp     x21, #0x959a000
0066FBFE4  ldrb     w8, [x21, #0x921]
0066FBFE8  mov      x20, x0
0066FBFEC  cbnz     w8, #0x66fc004
0066FBFF0  adrp     x0, #0x8f17000
0066FBFF4  ldr      x0, [x0, #0x2c8]
0066FBFF8  bl       #0x382bd14 ; 
0066FBFFC  mov      w8, #1
0066FC000  strb     w8, [x21, #0x921]
0066FC004  adrp     x8, #0x8f17000
0066FC008  ldr      x8, [x8, #0x2c8]
0066FC00C  ldr      x2, [x8]
0066FC010  ldrb     w8, [x2, #0x53]
0066FC014  tbnz     w8, #5, #0x66fc02c
0066FC018  mov      x0, x19
0066FC01C  str      x20, [x0, #0x90]!
0066FC020  mov      x1, x20
0066FC024  bl       #0x382bcb8 ; 
0066FC028  b        #0x66fc03c ; 
0066FC02C  ldr      x8, [x2, #0x60]
0066FC030  mov      x0, x19
0066FC034  mov      x1, x20
0066FC038  blr      x8
0066FC03C  mov      x0, x19
0066FC040  mov      x1, xzr
0066FC044  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FC048  adrp     x21, #0x959a000
0066FC04C  ldrb     w8, [x21, #0x922]
0066FC050  mov      x20, x0
0066FC054  cbnz     w8, #0x66fc06c
0066FC058  adrp     x0, #0x8f17000
0066FC05C  ldr      x0, [x0, #0x2d8]
0066FC060  bl       #0x382bd14 ; 
0066FC064  mov      w8, #1
0066FC068  strb     w8, [x21, #0x922]
0066FC06C  adrp     x8, #0x8f17000
0066FC070  ldr      x8, [x8, #0x2d8]
0066FC074  ldr      x2, [x8]
0066FC078  ldrb     w8, [x2, #0x53]
0066FC07C  tbnz     w8, #5, #0x66fc094
0066FC080  mov      x0, x19
0066FC084  str      x20, [x0, #0x98]!
0066FC088  mov      x1, x20
0066FC08C  bl       #0x382bcb8 ; 
0066FC090  b        #0x66fc0a4 ; 
0066FC094  ldr      x8, [x2, #0x60]
0066FC098  mov      x0, x19
0066FC09C  mov      x1, x20
0066FC0A0  blr      x8
0066FC0A4  mov      x0, x19
0066FC0A8  mov      x1, xzr
0066FC0AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FC0B0  adrp     x21, #0x959a000
0066FC0B4  ldrb     w8, [x21, #0x923]
0066FC0B8  mov      x20, x0
0066FC0BC  cbnz     w8, #0x66fc0d4
0066FC0C0  adrp     x0, #0x8f17000
0066FC0C4  ldr      x0, [x0, #0x2e8]
0066FC0C8  bl       #0x382bd14 ; 
0066FC0CC  mov      w8, #1
0066FC0D0  strb     w8, [x21, #0x923]
0066FC0D4  adrp     x8, #0x8f17000
0066FC0D8  ldr      x8, [x8, #0x2e8]
0066FC0DC  ldr      x2, [x8]
0066FC0E0  ldrb     w8, [x2, #0x53]
0066FC0E4  tbnz     w8, #5, #0x66fc0fc
0066FC0E8  mov      x0, x19
0066FC0EC  str      x20, [x0, #0xa0]!
0066FC0F0  mov      x1, x20
0066FC0F4  bl       #0x382bcb8 ; 
0066FC0F8  b        #0x66fc10c ; 
0066FC0FC  ldr      x8, [x2, #0x60]
0066FC100  mov      x0, x19
0066FC104  mov      x1, x20
0066FC108  blr      x8
0066FC10C  mov      x0, x19
0066FC110  mov      x1, xzr
0066FC114  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FC118  adrp     x21, #0x959a000
0066FC11C  ldrb     w8, [x21, #0x924]
0066FC120  mov      w20, w0
0066FC124  cbnz     w8, #0x66fc13c
0066FC128  adrp     x0, #0x8f17000
0066FC12C  ldr      x0, [x0, #0x2f8]
0066FC130  bl       #0x382bd14 ; 
0066FC134  mov      w8, #1
0066FC138  strb     w8, [x21, #0x924]
0066FC13C  adrp     x8, #0x8f17000
0066FC140  ldr      x8, [x8, #0x2f8]
0066FC144  ldr      x2, [x8]
0066FC148  ldrb     w8, [x2, #0x53]
0066FC14C  tbnz     w8, #5, #0x66fc158
0066FC150  str      w20, [x19, #0xa8]
0066FC154  b        #0x66fc168 ; 
0066FC158  ldr      x8, [x2, #0x60]
0066FC15C  mov      x0, x19
0066FC160  mov      w1, w20
0066FC164  blr      x8
0066FC168  ldp      x20, x19, [sp, #0x10]
0066FC16C  mov      w0, #1
0066FC170  ldp      x30, x21, [sp], #0x20
0066FC174  ret      

