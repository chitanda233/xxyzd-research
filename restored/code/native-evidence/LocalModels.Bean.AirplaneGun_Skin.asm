; LocalModels.Bean.AirplaneGun_Skin$$readImpl
; RVA 0x66FFA70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066FFA70  stp      x30, x21, [sp, #-0x20]!
0066FFA74  stp      x20, x19, [sp, #0x10]
0066FFA78  adrp     x20, #0x959a000
0066FFA7C  adrp     x21, #0x8f17000
0066FFA80  ldrb     w8, [x20, #0x87d]
0066FFA84  ldr      x21, [x21, #0x620]
0066FFA88  mov      x19, x0
0066FFA8C  tbnz     w8, #0, #0x66ffaa4
0066FFA90  adrp     x0, #0x8f17000
0066FFA94  ldr      x0, [x0, #0x620]
0066FFA98  bl       #0x382bd14 ; 
0066FFA9C  mov      w8, #1
0066FFAA0  strb     w8, [x20, #0x87d]
0066FFAA4  ldr      x1, [x21]
0066FFAA8  ldrb     w8, [x1, #0x53]
0066FFAAC  tbnz     w8, #5, #0x66ffafc
0066FFAB0  mov      x0, x19
0066FFAB4  mov      x1, xzr
0066FFAB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFABC  adrp     x21, #0x959a000
0066FFAC0  ldrb     w8, [x21, #0x941]
0066FFAC4  mov      w20, w0
0066FFAC8  cbnz     w8, #0x66ffae0
0066FFACC  adrp     x0, #0x8f17000
0066FFAD0  ldr      x0, [x0, #0x518]
0066FFAD4  bl       #0x382bd14 ; 
0066FFAD8  mov      w8, #1
0066FFADC  strb     w8, [x21, #0x941]
0066FFAE0  adrp     x8, #0x8f17000
0066FFAE4  ldr      x8, [x8, #0x518]
0066FFAE8  ldr      x2, [x8]
0066FFAEC  ldrb     w8, [x2, #0x53]
0066FFAF0  tbnz     w8, #5, #0x66ffb10
0066FFAF4  str      w20, [x19, #0x20]
0066FFAF8  b        #0x66ffb20 ; 
0066FFAFC  ldr      x2, [x1, #0x60]
0066FFB00  mov      x0, x19
0066FFB04  ldp      x20, x19, [sp, #0x10]
0066FFB08  ldp      x30, x21, [sp], #0x20
0066FFB0C  br       x2
0066FFB10  ldr      x8, [x2, #0x60]
0066FFB14  mov      x0, x19
0066FFB18  mov      w1, w20
0066FFB1C  blr      x8
0066FFB20  mov      x0, x19
0066FFB24  mov      x1, xzr
0066FFB28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFB2C  adrp     x21, #0x959a000
0066FFB30  ldrb     w8, [x21, #0x942]
0066FFB34  mov      w20, w0
0066FFB38  cbnz     w8, #0x66ffb50
0066FFB3C  adrp     x0, #0x8f17000
0066FFB40  ldr      x0, [x0, #0x528]
0066FFB44  bl       #0x382bd14 ; 
0066FFB48  mov      w8, #1
0066FFB4C  strb     w8, [x21, #0x942]
0066FFB50  adrp     x8, #0x8f17000
0066FFB54  ldr      x8, [x8, #0x528]
0066FFB58  ldr      x2, [x8]
0066FFB5C  ldrb     w8, [x2, #0x53]
0066FFB60  tbnz     w8, #5, #0x66ffb6c
0066FFB64  str      w20, [x19, #0x24]
0066FFB68  b        #0x66ffb7c ; 
0066FFB6C  ldr      x8, [x2, #0x60]
0066FFB70  mov      x0, x19
0066FFB74  mov      w1, w20
0066FFB78  blr      x8
0066FFB7C  mov      x0, x19
0066FFB80  mov      x1, xzr
0066FFB84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFB88  adrp     x21, #0x959a000
0066FFB8C  ldrb     w8, [x21, #0x943]
0066FFB90  mov      w20, w0
0066FFB94  cbnz     w8, #0x66ffbac
0066FFB98  adrp     x0, #0x8f17000
0066FFB9C  ldr      x0, [x0, #0x538]
0066FFBA0  bl       #0x382bd14 ; 
0066FFBA4  mov      w8, #1
0066FFBA8  strb     w8, [x21, #0x943]
0066FFBAC  adrp     x8, #0x8f17000
0066FFBB0  ldr      x8, [x8, #0x538]
0066FFBB4  ldr      x2, [x8]
0066FFBB8  ldrb     w8, [x2, #0x53]
0066FFBBC  tbnz     w8, #5, #0x66ffbc8
0066FFBC0  str      w20, [x19, #0x28]
0066FFBC4  b        #0x66ffbd8 ; 
0066FFBC8  ldr      x8, [x2, #0x60]
0066FFBCC  mov      x0, x19
0066FFBD0  mov      w1, w20
0066FFBD4  blr      x8
0066FFBD8  mov      x0, x19
0066FFBDC  mov      x1, xzr
0066FFBE0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FFBE4  adrp     x21, #0x959a000
0066FFBE8  ldrb     w8, [x21, #0x944]
0066FFBEC  mov      x20, x0
0066FFBF0  cbnz     w8, #0x66ffc08
0066FFBF4  adrp     x0, #0x8f17000
0066FFBF8  ldr      x0, [x0, #0x548]
0066FFBFC  bl       #0x382bd14 ; 
0066FFC00  mov      w8, #1
0066FFC04  strb     w8, [x21, #0x944]
0066FFC08  adrp     x8, #0x8f17000
0066FFC0C  ldr      x8, [x8, #0x548]
0066FFC10  ldr      x2, [x8]
0066FFC14  ldrb     w8, [x2, #0x53]
0066FFC18  tbnz     w8, #5, #0x66ffc30
0066FFC1C  mov      x0, x19
0066FFC20  str      x20, [x0, #0x30]!
0066FFC24  mov      x1, x20
0066FFC28  bl       #0x382bcb8 ; 
0066FFC2C  b        #0x66ffc40 ; 
0066FFC30  ldr      x8, [x2, #0x60]
0066FFC34  mov      x0, x19
0066FFC38  mov      x1, x20
0066FFC3C  blr      x8
0066FFC40  mov      x0, x19
0066FFC44  mov      x1, xzr
0066FFC48  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FFC4C  adrp     x21, #0x959a000
0066FFC50  ldrb     w8, [x21, #0x945]
0066FFC54  mov      x20, x0
0066FFC58  cbnz     w8, #0x66ffc70
0066FFC5C  adrp     x0, #0x8f17000
0066FFC60  ldr      x0, [x0, #0x558]
0066FFC64  bl       #0x382bd14 ; 
0066FFC68  mov      w8, #1
0066FFC6C  strb     w8, [x21, #0x945]
0066FFC70  adrp     x8, #0x8f17000
0066FFC74  ldr      x8, [x8, #0x558]
0066FFC78  ldr      x2, [x8]
0066FFC7C  ldrb     w8, [x2, #0x53]
0066FFC80  tbnz     w8, #5, #0x66ffc98
0066FFC84  mov      x0, x19
0066FFC88  str      x20, [x0, #0x38]!
0066FFC8C  mov      x1, x20
0066FFC90  bl       #0x382bcb8 ; 
0066FFC94  b        #0x66ffca8 ; 
0066FFC98  ldr      x8, [x2, #0x60]
0066FFC9C  mov      x0, x19
0066FFCA0  mov      x1, x20
0066FFCA4  blr      x8
0066FFCA8  mov      x0, x19
0066FFCAC  mov      x1, xzr
0066FFCB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFCB4  adrp     x21, #0x959a000
0066FFCB8  ldrb     w8, [x21, #0x946]
0066FFCBC  mov      w20, w0
0066FFCC0  cbnz     w8, #0x66ffcd8
0066FFCC4  adrp     x0, #0x8f17000
0066FFCC8  ldr      x0, [x0, #0x568]
0066FFCCC  bl       #0x382bd14 ; 
0066FFCD0  mov      w8, #1
0066FFCD4  strb     w8, [x21, #0x946]
0066FFCD8  adrp     x8, #0x8f17000
0066FFCDC  ldr      x8, [x8, #0x568]
0066FFCE0  ldr      x2, [x8]
0066FFCE4  ldrb     w8, [x2, #0x53]
0066FFCE8  tbnz     w8, #5, #0x66ffcf4
0066FFCEC  str      w20, [x19, #0x40]
0066FFCF0  b        #0x66ffd04 ; 
0066FFCF4  ldr      x8, [x2, #0x60]
0066FFCF8  mov      x0, x19
0066FFCFC  mov      w1, w20
0066FFD00  blr      x8
0066FFD04  mov      x0, x19
0066FFD08  mov      x1, xzr
0066FFD0C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FFD10  adrp     x21, #0x959a000
0066FFD14  ldrb     w8, [x21, #0x947]
0066FFD18  mov      x20, x0
0066FFD1C  cbnz     w8, #0x66ffd34
0066FFD20  adrp     x0, #0x8f17000
0066FFD24  ldr      x0, [x0, #0x578]
0066FFD28  bl       #0x382bd14 ; 
0066FFD2C  mov      w8, #1
0066FFD30  strb     w8, [x21, #0x947]
0066FFD34  adrp     x8, #0x8f17000
0066FFD38  ldr      x8, [x8, #0x578]
0066FFD3C  ldr      x2, [x8]
0066FFD40  ldrb     w8, [x2, #0x53]
0066FFD44  tbnz     w8, #5, #0x66ffd5c
0066FFD48  mov      x0, x19
0066FFD4C  str      x20, [x0, #0x48]!
0066FFD50  mov      x1, x20
0066FFD54  bl       #0x382bcb8 ; 
0066FFD58  b        #0x66ffd6c ; 
0066FFD5C  ldr      x8, [x2, #0x60]
0066FFD60  mov      x0, x19
0066FFD64  mov      x1, x20
0066FFD68  blr      x8
0066FFD6C  mov      x0, x19
0066FFD70  mov      x1, xzr
0066FFD74  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFD78  adrp     x21, #0x959a000
0066FFD7C  ldrb     w8, [x21, #0x948]
0066FFD80  mov      w20, w0
0066FFD84  cbnz     w8, #0x66ffd9c
0066FFD88  adrp     x0, #0x8f17000
0066FFD8C  ldr      x0, [x0, #0x588]
0066FFD90  bl       #0x382bd14 ; 
0066FFD94  mov      w8, #1
0066FFD98  strb     w8, [x21, #0x948]
0066FFD9C  adrp     x8, #0x8f17000
0066FFDA0  ldr      x8, [x8, #0x588]
0066FFDA4  ldr      x2, [x8]
0066FFDA8  ldrb     w8, [x2, #0x53]
0066FFDAC  tbnz     w8, #5, #0x66ffdb8
0066FFDB0  str      w20, [x19, #0x50]
0066FFDB4  b        #0x66ffdc8 ; 
0066FFDB8  ldr      x8, [x2, #0x60]
0066FFDBC  mov      x0, x19
0066FFDC0  mov      w1, w20
0066FFDC4  blr      x8
0066FFDC8  mov      x0, x19
0066FFDCC  mov      x1, xzr
0066FFDD0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FFDD4  adrp     x21, #0x959a000
0066FFDD8  ldrb     w8, [x21, #0x949]
0066FFDDC  mov      x20, x0
0066FFDE0  cbnz     w8, #0x66ffdf8
0066FFDE4  adrp     x0, #0x8f17000
0066FFDE8  ldr      x0, [x0, #0x598]
0066FFDEC  bl       #0x382bd14 ; 
0066FFDF0  mov      w8, #1
0066FFDF4  strb     w8, [x21, #0x949]
0066FFDF8  adrp     x8, #0x8f17000
0066FFDFC  ldr      x8, [x8, #0x598]
0066FFE00  ldr      x2, [x8]
0066FFE04  ldrb     w8, [x2, #0x53]
0066FFE08  tbnz     w8, #5, #0x66ffe20
0066FFE0C  mov      x0, x19
0066FFE10  str      x20, [x0, #0x58]!
0066FFE14  mov      x1, x20
0066FFE18  bl       #0x382bcb8 ; 
0066FFE1C  b        #0x66ffe30 ; 
0066FFE20  ldr      x8, [x2, #0x60]
0066FFE24  mov      x0, x19
0066FFE28  mov      x1, x20
0066FFE2C  blr      x8
0066FFE30  mov      x0, x19
0066FFE34  mov      x1, xzr
0066FFE38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFE3C  adrp     x21, #0x959a000
0066FFE40  ldrb     w8, [x21, #0x94a]
0066FFE44  mov      w20, w0
0066FFE48  cbnz     w8, #0x66ffe60
0066FFE4C  adrp     x0, #0x8f17000
0066FFE50  ldr      x0, [x0, #0x5a8]
0066FFE54  bl       #0x382bd14 ; 
0066FFE58  mov      w8, #1
0066FFE5C  strb     w8, [x21, #0x94a]
0066FFE60  adrp     x8, #0x8f17000
0066FFE64  ldr      x8, [x8, #0x5a8]
0066FFE68  ldr      x2, [x8]
0066FFE6C  ldrb     w8, [x2, #0x53]
0066FFE70  tbnz     w8, #5, #0x66ffe7c
0066FFE74  str      w20, [x19, #0x60]
0066FFE78  b        #0x66ffe8c ; 
0066FFE7C  ldr      x8, [x2, #0x60]
0066FFE80  mov      x0, x19
0066FFE84  mov      w1, w20
0066FFE88  blr      x8
0066FFE8C  mov      x0, x19
0066FFE90  mov      x1, xzr
0066FFE94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFE98  adrp     x21, #0x959a000
0066FFE9C  ldrb     w8, [x21, #0x94b]
0066FFEA0  mov      w20, w0
0066FFEA4  cbnz     w8, #0x66ffebc
0066FFEA8  adrp     x0, #0x8f17000
0066FFEAC  ldr      x0, [x0, #0x5b8]
0066FFEB0  bl       #0x382bd14 ; 
0066FFEB4  mov      w8, #1
0066FFEB8  strb     w8, [x21, #0x94b]
0066FFEBC  adrp     x8, #0x8f17000
0066FFEC0  ldr      x8, [x8, #0x5b8]
0066FFEC4  ldr      x2, [x8]
0066FFEC8  ldrb     w8, [x2, #0x53]
0066FFECC  tbnz     w8, #5, #0x66ffed8
0066FFED0  str      w20, [x19, #0x64]
0066FFED4  b        #0x66ffee8 ; 
0066FFED8  ldr      x8, [x2, #0x60]
0066FFEDC  mov      x0, x19
0066FFEE0  mov      w1, w20
0066FFEE4  blr      x8
0066FFEE8  mov      x0, x19
0066FFEEC  mov      x1, xzr
0066FFEF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFEF4  adrp     x21, #0x959a000
0066FFEF8  ldrb     w8, [x21, #0x94c]
0066FFEFC  mov      w20, w0
0066FFF00  cbnz     w8, #0x66fff18
0066FFF04  adrp     x0, #0x8f17000
0066FFF08  ldr      x0, [x0, #0x5c8]
0066FFF0C  bl       #0x382bd14 ; 
0066FFF10  mov      w8, #1
0066FFF14  strb     w8, [x21, #0x94c]
0066FFF18  adrp     x8, #0x8f17000
0066FFF1C  ldr      x8, [x8, #0x5c8]
0066FFF20  ldr      x2, [x8]
0066FFF24  ldrb     w8, [x2, #0x53]
0066FFF28  tbnz     w8, #5, #0x66fff34
0066FFF2C  str      w20, [x19, #0x68]
0066FFF30  b        #0x66fff44 ; 
0066FFF34  ldr      x8, [x2, #0x60]
0066FFF38  mov      x0, x19
0066FFF3C  mov      w1, w20
0066FFF40  blr      x8
0066FFF44  mov      x0, x19
0066FFF48  mov      x1, xzr
0066FFF4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFF50  adrp     x21, #0x959a000
0066FFF54  ldrb     w8, [x21, #0x94d]
0066FFF58  mov      w20, w0
0066FFF5C  cbnz     w8, #0x66fff74
0066FFF60  adrp     x0, #0x8f17000
0066FFF64  ldr      x0, [x0, #0x5d8]
0066FFF68  bl       #0x382bd14 ; 
0066FFF6C  mov      w8, #1
0066FFF70  strb     w8, [x21, #0x94d]
0066FFF74  adrp     x8, #0x8f17000
0066FFF78  ldr      x8, [x8, #0x5d8]
0066FFF7C  ldr      x2, [x8]
0066FFF80  ldrb     w8, [x2, #0x53]
0066FFF84  tbnz     w8, #5, #0x66fff90
0066FFF88  str      w20, [x19, #0x6c]
0066FFF8C  b        #0x66fffa0 ; 
0066FFF90  ldr      x8, [x2, #0x60]
0066FFF94  mov      x0, x19
0066FFF98  mov      w1, w20
0066FFF9C  blr      x8
0066FFFA0  mov      x0, x19
0066FFFA4  mov      x1, xzr
0066FFFA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FFFAC  adrp     x21, #0x959a000
0066FFFB0  ldrb     w8, [x21, #0x94e]
0066FFFB4  mov      w20, w0
0066FFFB8  cbnz     w8, #0x66fffd0
0066FFFBC  adrp     x0, #0x8f17000
0066FFFC0  ldr      x0, [x0, #0x5e8]
0066FFFC4  bl       #0x382bd14 ; 
0066FFFC8  mov      w8, #1
0066FFFCC  strb     w8, [x21, #0x94e]
0066FFFD0  adrp     x8, #0x8f17000
0066FFFD4  ldr      x8, [x8, #0x5e8]
0066FFFD8  ldr      x2, [x8]
0066FFFDC  ldrb     w8, [x2, #0x53]
0066FFFE0  tbnz     w8, #5, #0x66fffec
0066FFFE4  str      w20, [x19, #0x70]
0066FFFE8  b        #0x66ffffc ; 
0066FFFEC  ldr      x8, [x2, #0x60]
0066FFFF0  mov      x0, x19
0066FFFF4  mov      w1, w20
0066FFFF8  blr      x8
0066FFFFC  mov      x0, x19
006700000  mov      x1, xzr
006700004  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006700008  adrp     x21, #0x959a000
00670000C  ldrb     w8, [x21, #0x94f]
006700010  mov      x20, x0
006700014  cbnz     w8, #0x670002c
006700018  adrp     x0, #0x8f17000
00670001C  ldr      x0, [x0, #0x5f8]
006700020  bl       #0x382bd14 ; 
006700024  mov      w8, #1
006700028  strb     w8, [x21, #0x94f]
00670002C  adrp     x8, #0x8f17000
006700030  ldr      x8, [x8, #0x5f8]
006700034  ldr      x2, [x8]
006700038  ldrb     w8, [x2, #0x53]
00670003C  tbnz     w8, #5, #0x6700054
006700040  mov      x0, x19
006700044  str      x20, [x0, #0x78]!
006700048  mov      x1, x20
00670004C  bl       #0x382bcb8 ; 
006700050  b        #0x6700064 ; 
006700054  ldr      x8, [x2, #0x60]
006700058  mov      x0, x19
00670005C  mov      x1, x20
006700060  blr      x8
006700064  mov      x0, x19
006700068  mov      x1, xzr
00670006C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006700070  adrp     x21, #0x959a000
006700074  ldrb     w8, [x21, #0x950]
006700078  mov      x20, x0
00670007C  cbnz     w8, #0x6700094
006700080  adrp     x0, #0x8f17000
006700084  ldr      x0, [x0, #0x608]
006700088  bl       #0x382bd14 ; 
00670008C  mov      w8, #1
006700090  strb     w8, [x21, #0x950]
006700094  adrp     x8, #0x8f17000
006700098  ldr      x8, [x8, #0x608]
00670009C  ldr      x2, [x8]
0067000A0  ldrb     w8, [x2, #0x53]
0067000A4  tbnz     w8, #5, #0x67000bc
0067000A8  mov      x0, x19
0067000AC  str      x20, [x0, #0x80]!
0067000B0  mov      x1, x20
0067000B4  bl       #0x382bcb8 ; 
0067000B8  b        #0x67000cc ; 
0067000BC  ldr      x8, [x2, #0x60]
0067000C0  mov      x0, x19
0067000C4  mov      x1, x20
0067000C8  blr      x8
0067000CC  mov      x0, x19
0067000D0  mov      x1, xzr
0067000D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067000D8  adrp     x21, #0x959a000
0067000DC  ldrb     w8, [x21, #0x951]
0067000E0  mov      w20, w0
0067000E4  cbnz     w8, #0x67000fc
0067000E8  adrp     x0, #0x8f17000
0067000EC  ldr      x0, [x0, #0x618]
0067000F0  bl       #0x382bd14 ; 
0067000F4  mov      w8, #1
0067000F8  strb     w8, [x21, #0x951]
0067000FC  adrp     x8, #0x8f17000
006700100  ldr      x8, [x8, #0x618]
006700104  ldr      x2, [x8]
006700108  ldrb     w8, [x2, #0x53]
00670010C  tbnz     w8, #5, #0x6700118
006700110  str      w20, [x19, #0x88]
006700114  b        #0x6700128 ; 
006700118  ldr      x8, [x2, #0x60]
00670011C  mov      x0, x19
006700120  mov      w1, w20
006700124  blr      x8
006700128  ldp      x20, x19, [sp, #0x10]
00670012C  mov      w0, #1
006700130  ldp      x30, x21, [sp], #0x20
006700134  ret      

