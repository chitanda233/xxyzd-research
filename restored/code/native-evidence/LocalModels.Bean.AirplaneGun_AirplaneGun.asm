; LocalModels.Bean.AirplaneGun_AirplaneGun$$readImpl
; RVA 0x66FDB5C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066FDB5C  stp      x30, x21, [sp, #-0x20]!
0066FDB60  stp      x20, x19, [sp, #0x10]
0066FDB64  adrp     x20, #0x959a000
0066FDB68  adrp     x21, #0x8f17000
0066FDB6C  ldrb     w8, [x20, #0x849]
0066FDB70  ldr      x21, [x21, #0x490]
0066FDB74  mov      x19, x0
0066FDB78  tbnz     w8, #0, #0x66fdb90
0066FDB7C  adrp     x0, #0x8f17000
0066FDB80  ldr      x0, [x0, #0x490]
0066FDB84  bl       #0x382bd14 ; 
0066FDB88  mov      w8, #1
0066FDB8C  strb     w8, [x20, #0x849]
0066FDB90  ldr      x1, [x21]
0066FDB94  ldrb     w8, [x1, #0x53]
0066FDB98  tbnz     w8, #5, #0x66fdbe8
0066FDB9C  mov      x0, x19
0066FDBA0  mov      x1, xzr
0066FDBA4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FDBA8  adrp     x21, #0x959a000
0066FDBAC  ldrb     w8, [x21, #0x92c]
0066FDBB0  mov      w20, w0
0066FDBB4  cbnz     w8, #0x66fdbcc
0066FDBB8  adrp     x0, #0x8f17000
0066FDBBC  ldr      x0, [x0, #0x3a8]
0066FDBC0  bl       #0x382bd14 ; 
0066FDBC4  mov      w8, #1
0066FDBC8  strb     w8, [x21, #0x92c]
0066FDBCC  adrp     x8, #0x8f17000
0066FDBD0  ldr      x8, [x8, #0x3a8]
0066FDBD4  ldr      x2, [x8]
0066FDBD8  ldrb     w8, [x2, #0x53]
0066FDBDC  tbnz     w8, #5, #0x66fdbfc
0066FDBE0  str      w20, [x19, #0x20]
0066FDBE4  b        #0x66fdc0c ; 
0066FDBE8  ldr      x2, [x1, #0x60]
0066FDBEC  mov      x0, x19
0066FDBF0  ldp      x20, x19, [sp, #0x10]
0066FDBF4  ldp      x30, x21, [sp], #0x20
0066FDBF8  br       x2
0066FDBFC  ldr      x8, [x2, #0x60]
0066FDC00  mov      x0, x19
0066FDC04  mov      w1, w20
0066FDC08  blr      x8
0066FDC0C  mov      x0, x19
0066FDC10  mov      x1, xzr
0066FDC14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FDC18  adrp     x21, #0x959a000
0066FDC1C  ldrb     w8, [x21, #0x92d]
0066FDC20  mov      w20, w0
0066FDC24  cbnz     w8, #0x66fdc3c
0066FDC28  adrp     x0, #0x8f17000
0066FDC2C  ldr      x0, [x0, #0x3b8]
0066FDC30  bl       #0x382bd14 ; 
0066FDC34  mov      w8, #1
0066FDC38  strb     w8, [x21, #0x92d]
0066FDC3C  adrp     x8, #0x8f17000
0066FDC40  ldr      x8, [x8, #0x3b8]
0066FDC44  ldr      x2, [x8]
0066FDC48  ldrb     w8, [x2, #0x53]
0066FDC4C  tbnz     w8, #5, #0x66fdc58
0066FDC50  str      w20, [x19, #0x24]
0066FDC54  b        #0x66fdc68 ; 
0066FDC58  ldr      x8, [x2, #0x60]
0066FDC5C  mov      x0, x19
0066FDC60  mov      w1, w20
0066FDC64  blr      x8
0066FDC68  mov      x0, x19
0066FDC6C  mov      x1, xzr
0066FDC70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FDC74  adrp     x21, #0x959a000
0066FDC78  ldrb     w8, [x21, #0x92e]
0066FDC7C  mov      w20, w0
0066FDC80  cbnz     w8, #0x66fdc98
0066FDC84  adrp     x0, #0x8f17000
0066FDC88  ldr      x0, [x0, #0x3c8]
0066FDC8C  bl       #0x382bd14 ; 
0066FDC90  mov      w8, #1
0066FDC94  strb     w8, [x21, #0x92e]
0066FDC98  adrp     x8, #0x8f17000
0066FDC9C  ldr      x8, [x8, #0x3c8]
0066FDCA0  ldr      x2, [x8]
0066FDCA4  ldrb     w8, [x2, #0x53]
0066FDCA8  tbnz     w8, #5, #0x66fdcb4
0066FDCAC  str      w20, [x19, #0x28]
0066FDCB0  b        #0x66fdcc4 ; 
0066FDCB4  ldr      x8, [x2, #0x60]
0066FDCB8  mov      x0, x19
0066FDCBC  mov      w1, w20
0066FDCC0  blr      x8
0066FDCC4  mov      x0, x19
0066FDCC8  mov      x1, xzr
0066FDCCC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FDCD0  adrp     x21, #0x959a000
0066FDCD4  ldrb     w8, [x21, #0x92f]
0066FDCD8  mov      w20, w0
0066FDCDC  cbnz     w8, #0x66fdcf4
0066FDCE0  adrp     x0, #0x8f17000
0066FDCE4  ldr      x0, [x0, #0x3d8]
0066FDCE8  bl       #0x382bd14 ; 
0066FDCEC  mov      w8, #1
0066FDCF0  strb     w8, [x21, #0x92f]
0066FDCF4  adrp     x8, #0x8f17000
0066FDCF8  ldr      x8, [x8, #0x3d8]
0066FDCFC  ldr      x2, [x8]
0066FDD00  ldrb     w8, [x2, #0x53]
0066FDD04  tbnz     w8, #5, #0x66fdd10
0066FDD08  str      w20, [x19, #0x2c]
0066FDD0C  b        #0x66fdd20 ; 
0066FDD10  ldr      x8, [x2, #0x60]
0066FDD14  mov      x0, x19
0066FDD18  mov      w1, w20
0066FDD1C  blr      x8
0066FDD20  mov      x0, x19
0066FDD24  mov      x1, xzr
0066FDD28  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FDD2C  adrp     x21, #0x959a000
0066FDD30  ldrb     w8, [x21, #0x930]
0066FDD34  mov      x20, x0
0066FDD38  cbnz     w8, #0x66fdd50
0066FDD3C  adrp     x0, #0x8f17000
0066FDD40  ldr      x0, [x0, #0x3e8]
0066FDD44  bl       #0x382bd14 ; 
0066FDD48  mov      w8, #1
0066FDD4C  strb     w8, [x21, #0x930]
0066FDD50  adrp     x8, #0x8f17000
0066FDD54  ldr      x8, [x8, #0x3e8]
0066FDD58  ldr      x2, [x8]
0066FDD5C  ldrb     w8, [x2, #0x53]
0066FDD60  tbnz     w8, #5, #0x66fdd78
0066FDD64  mov      x0, x19
0066FDD68  str      x20, [x0, #0x30]!
0066FDD6C  mov      x1, x20
0066FDD70  bl       #0x382bcb8 ; 
0066FDD74  b        #0x66fdd88 ; 
0066FDD78  ldr      x8, [x2, #0x60]
0066FDD7C  mov      x0, x19
0066FDD80  mov      x1, x20
0066FDD84  blr      x8
0066FDD88  mov      x0, x19
0066FDD8C  mov      x1, xzr
0066FDD90  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FDD94  adrp     x21, #0x959a000
0066FDD98  ldrb     w8, [x21, #0x931]
0066FDD9C  mov      x20, x0
0066FDDA0  cbnz     w8, #0x66fddb8
0066FDDA4  adrp     x0, #0x8f17000
0066FDDA8  ldr      x0, [x0, #0x3f8]
0066FDDAC  bl       #0x382bd14 ; 
0066FDDB0  mov      w8, #1
0066FDDB4  strb     w8, [x21, #0x931]
0066FDDB8  adrp     x8, #0x8f17000
0066FDDBC  ldr      x8, [x8, #0x3f8]
0066FDDC0  ldr      x2, [x8]
0066FDDC4  ldrb     w8, [x2, #0x53]
0066FDDC8  tbnz     w8, #5, #0x66fdde0
0066FDDCC  mov      x0, x19
0066FDDD0  str      x20, [x0, #0x38]!
0066FDDD4  mov      x1, x20
0066FDDD8  bl       #0x382bcb8 ; 
0066FDDDC  b        #0x66fddf0 ; 
0066FDDE0  ldr      x8, [x2, #0x60]
0066FDDE4  mov      x0, x19
0066FDDE8  mov      x1, x20
0066FDDEC  blr      x8
0066FDDF0  mov      x0, x19
0066FDDF4  mov      x1, xzr
0066FDDF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FDDFC  adrp     x21, #0x959a000
0066FDE00  ldrb     w8, [x21, #0x932]
0066FDE04  mov      w20, w0
0066FDE08  cbnz     w8, #0x66fde20
0066FDE0C  adrp     x0, #0x8f17000
0066FDE10  ldr      x0, [x0, #0x408]
0066FDE14  bl       #0x382bd14 ; 
0066FDE18  mov      w8, #1
0066FDE1C  strb     w8, [x21, #0x932]
0066FDE20  adrp     x8, #0x8f17000
0066FDE24  ldr      x8, [x8, #0x408]
0066FDE28  ldr      x2, [x8]
0066FDE2C  ldrb     w8, [x2, #0x53]
0066FDE30  tbnz     w8, #5, #0x66fde3c
0066FDE34  str      w20, [x19, #0x40]
0066FDE38  b        #0x66fde4c ; 
0066FDE3C  ldr      x8, [x2, #0x60]
0066FDE40  mov      x0, x19
0066FDE44  mov      w1, w20
0066FDE48  blr      x8
0066FDE4C  mov      x0, x19
0066FDE50  mov      x1, xzr
0066FDE54  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FDE58  adrp     x21, #0x959a000
0066FDE5C  ldrb     w8, [x21, #0x933]
0066FDE60  mov      x20, x0
0066FDE64  cbnz     w8, #0x66fde7c
0066FDE68  adrp     x0, #0x8f17000
0066FDE6C  ldr      x0, [x0, #0x418]
0066FDE70  bl       #0x382bd14 ; 
0066FDE74  mov      w8, #1
0066FDE78  strb     w8, [x21, #0x933]
0066FDE7C  adrp     x8, #0x8f17000
0066FDE80  ldr      x8, [x8, #0x418]
0066FDE84  ldr      x2, [x8]
0066FDE88  ldrb     w8, [x2, #0x53]
0066FDE8C  tbnz     w8, #5, #0x66fdea4
0066FDE90  mov      x0, x19
0066FDE94  str      x20, [x0, #0x48]!
0066FDE98  mov      x1, x20
0066FDE9C  bl       #0x382bcb8 ; 
0066FDEA0  b        #0x66fdeb4 ; 
0066FDEA4  ldr      x8, [x2, #0x60]
0066FDEA8  mov      x0, x19
0066FDEAC  mov      x1, x20
0066FDEB0  blr      x8
0066FDEB4  mov      x0, x19
0066FDEB8  mov      x1, xzr
0066FDEBC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FDEC0  adrp     x21, #0x959a000
0066FDEC4  ldrb     w8, [x21, #0x934]
0066FDEC8  mov      x20, x0
0066FDECC  cbnz     w8, #0x66fdee4
0066FDED0  adrp     x0, #0x8f17000
0066FDED4  ldr      x0, [x0, #0x428]
0066FDED8  bl       #0x382bd14 ; 
0066FDEDC  mov      w8, #1
0066FDEE0  strb     w8, [x21, #0x934]
0066FDEE4  adrp     x8, #0x8f17000
0066FDEE8  ldr      x8, [x8, #0x428]
0066FDEEC  ldr      x2, [x8]
0066FDEF0  ldrb     w8, [x2, #0x53]
0066FDEF4  tbnz     w8, #5, #0x66fdf0c
0066FDEF8  mov      x0, x19
0066FDEFC  str      x20, [x0, #0x50]!
0066FDF00  mov      x1, x20
0066FDF04  bl       #0x382bcb8 ; 
0066FDF08  b        #0x66fdf1c ; 
0066FDF0C  ldr      x8, [x2, #0x60]
0066FDF10  mov      x0, x19
0066FDF14  mov      x1, x20
0066FDF18  blr      x8
0066FDF1C  mov      x0, x19
0066FDF20  mov      x1, xzr
0066FDF24  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0066FDF28  adrp     x21, #0x959a000
0066FDF2C  ldrb     w8, [x21, #0x935]
0066FDF30  mov      x20, x0
0066FDF34  cbnz     w8, #0x66fdf4c
0066FDF38  adrp     x0, #0x8f17000
0066FDF3C  ldr      x0, [x0, #0x438]
0066FDF40  bl       #0x382bd14 ; 
0066FDF44  mov      w8, #1
0066FDF48  strb     w8, [x21, #0x935]
0066FDF4C  adrp     x8, #0x8f17000
0066FDF50  ldr      x8, [x8, #0x438]
0066FDF54  ldr      x2, [x8]
0066FDF58  ldrb     w8, [x2, #0x53]
0066FDF5C  tbnz     w8, #5, #0x66fdf74
0066FDF60  mov      x0, x19
0066FDF64  str      x20, [x0, #0x58]!
0066FDF68  mov      x1, x20
0066FDF6C  bl       #0x382bcb8 ; 
0066FDF70  b        #0x66fdf84 ; 
0066FDF74  ldr      x8, [x2, #0x60]
0066FDF78  mov      x0, x19
0066FDF7C  mov      x1, x20
0066FDF80  blr      x8
0066FDF84  mov      x0, x19
0066FDF88  mov      x1, xzr
0066FDF8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FDF90  adrp     x21, #0x959a000
0066FDF94  ldrb     w8, [x21, #0x936]
0066FDF98  mov      w20, w0
0066FDF9C  cbnz     w8, #0x66fdfb4
0066FDFA0  adrp     x0, #0x8f17000
0066FDFA4  ldr      x0, [x0, #0x448]
0066FDFA8  bl       #0x382bd14 ; 
0066FDFAC  mov      w8, #1
0066FDFB0  strb     w8, [x21, #0x936]
0066FDFB4  adrp     x8, #0x8f17000
0066FDFB8  ldr      x8, [x8, #0x448]
0066FDFBC  ldr      x2, [x8]
0066FDFC0  ldrb     w8, [x2, #0x53]
0066FDFC4  tbnz     w8, #5, #0x66fdfd0
0066FDFC8  str      w20, [x19, #0x60]
0066FDFCC  b        #0x66fdfe0 ; 
0066FDFD0  ldr      x8, [x2, #0x60]
0066FDFD4  mov      x0, x19
0066FDFD8  mov      w1, w20
0066FDFDC  blr      x8
0066FDFE0  mov      x0, x19
0066FDFE4  mov      x1, xzr
0066FDFE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FDFEC  adrp     x21, #0x959a000
0066FDFF0  ldrb     w8, [x21, #0x937]
0066FDFF4  mov      w20, w0
0066FDFF8  cbnz     w8, #0x66fe010
0066FDFFC  adrp     x0, #0x8f17000
0066FE000  ldr      x0, [x0, #0x458]
0066FE004  bl       #0x382bd14 ; 
0066FE008  mov      w8, #1
0066FE00C  strb     w8, [x21, #0x937]
0066FE010  adrp     x8, #0x8f17000
0066FE014  ldr      x8, [x8, #0x458]
0066FE018  ldr      x2, [x8]
0066FE01C  ldrb     w8, [x2, #0x53]
0066FE020  tbnz     w8, #5, #0x66fe02c
0066FE024  str      w20, [x19, #0x64]
0066FE028  b        #0x66fe03c ; 
0066FE02C  ldr      x8, [x2, #0x60]
0066FE030  mov      x0, x19
0066FE034  mov      w1, w20
0066FE038  blr      x8
0066FE03C  mov      x0, x19
0066FE040  mov      x1, xzr
0066FE044  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FE048  adrp     x21, #0x959a000
0066FE04C  ldrb     w8, [x21, #0x938]
0066FE050  mov      w20, w0
0066FE054  cbnz     w8, #0x66fe06c
0066FE058  adrp     x0, #0x8f17000
0066FE05C  ldr      x0, [x0, #0x468]
0066FE060  bl       #0x382bd14 ; 
0066FE064  mov      w8, #1
0066FE068  strb     w8, [x21, #0x938]
0066FE06C  adrp     x8, #0x8f17000
0066FE070  ldr      x8, [x8, #0x468]
0066FE074  ldr      x2, [x8]
0066FE078  ldrb     w8, [x2, #0x53]
0066FE07C  tbnz     w8, #5, #0x66fe088
0066FE080  str      w20, [x19, #0x68]
0066FE084  b        #0x66fe098 ; 
0066FE088  ldr      x8, [x2, #0x60]
0066FE08C  mov      x0, x19
0066FE090  mov      w1, w20
0066FE094  blr      x8
0066FE098  mov      x0, x19
0066FE09C  mov      x1, xzr
0066FE0A0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FE0A4  adrp     x21, #0x959a000
0066FE0A8  ldrb     w8, [x21, #0x939]
0066FE0AC  mov      x20, x0
0066FE0B0  cbnz     w8, #0x66fe0c8
0066FE0B4  adrp     x0, #0x8f17000
0066FE0B8  ldr      x0, [x0, #0x478]
0066FE0BC  bl       #0x382bd14 ; 
0066FE0C0  mov      w8, #1
0066FE0C4  strb     w8, [x21, #0x939]
0066FE0C8  adrp     x8, #0x8f17000
0066FE0CC  ldr      x8, [x8, #0x478]
0066FE0D0  ldr      x2, [x8]
0066FE0D4  ldrb     w8, [x2, #0x53]
0066FE0D8  tbnz     w8, #5, #0x66fe0f0
0066FE0DC  mov      x0, x19
0066FE0E0  str      x20, [x0, #0x70]!
0066FE0E4  mov      x1, x20
0066FE0E8  bl       #0x382bcb8 ; 
0066FE0EC  b        #0x66fe100 ; 
0066FE0F0  ldr      x8, [x2, #0x60]
0066FE0F4  mov      x0, x19
0066FE0F8  mov      x1, x20
0066FE0FC  blr      x8
0066FE100  mov      x0, x19
0066FE104  mov      x1, xzr
0066FE108  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FE10C  adrp     x21, #0x959a000
0066FE110  ldrb     w8, [x21, #0x93a]
0066FE114  mov      x20, x0
0066FE118  cbnz     w8, #0x66fe130
0066FE11C  adrp     x0, #0x8f17000
0066FE120  ldr      x0, [x0, #0x488]
0066FE124  bl       #0x382bd14 ; 
0066FE128  mov      w8, #1
0066FE12C  strb     w8, [x21, #0x93a]
0066FE130  adrp     x8, #0x8f17000
0066FE134  ldr      x8, [x8, #0x488]
0066FE138  ldr      x2, [x8]
0066FE13C  ldrb     w8, [x2, #0x53]
0066FE140  tbnz     w8, #5, #0x66fe158
0066FE144  str      x20, [x19, #0x78]!
0066FE148  mov      x0, x19
0066FE14C  mov      x1, x20
0066FE150  bl       #0x382bcb8 ; 
0066FE154  b        #0x66fe168 ; 
0066FE158  ldr      x8, [x2, #0x60]
0066FE15C  mov      x0, x19
0066FE160  mov      x1, x20
0066FE164  blr      x8
0066FE168  ldp      x20, x19, [sp, #0x10]
0066FE16C  mov      w0, #1
0066FE170  ldp      x30, x21, [sp], #0x20
0066FE174  ret      

