; LocalModels.Bean.ChapterWaveMulti_Waves$$readImpl
; RVA 0x689EBB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689EBB4  stp      x30, x21, [sp, #-0x20]!
00689EBB8  stp      x20, x19, [sp, #0x10]
00689EBBC  adrp     x20, #0x959b000
00689EBC0  adrp     x21, #0x8f26000
00689EBC4  ldrb     w8, [x20, #0xea2]
00689EBC8  ldr      x21, [x21, #0x248]
00689EBCC  mov      x19, x0
00689EBD0  tbnz     w8, #0, #0x689ebe8
00689EBD4  adrp     x0, #0x8f26000
00689EBD8  ldr      x0, [x0, #0x248]
00689EBDC  bl       #0x382bd14 ; 
00689EBE0  mov      w8, #1
00689EBE4  strb     w8, [x20, #0xea2]
00689EBE8  ldr      x1, [x21]
00689EBEC  ldrb     w8, [x1, #0x53]
00689EBF0  tbnz     w8, #5, #0x689ec40
00689EBF4  mov      x0, x19
00689EBF8  mov      x1, xzr
00689EBFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689EC00  adrp     x21, #0x959c000
00689EC04  ldrb     w8, [x21, #0x4fd]
00689EC08  mov      w20, w0
00689EC0C  cbnz     w8, #0x689ec24
00689EC10  adrp     x0, #0x8f26000
00689EC14  ldr      x0, [x0, #0x190]
00689EC18  bl       #0x382bd14 ; 
00689EC1C  mov      w8, #1
00689EC20  strb     w8, [x21, #0x4fd]
00689EC24  adrp     x8, #0x8f26000
00689EC28  ldr      x8, [x8, #0x190]
00689EC2C  ldr      x2, [x8]
00689EC30  ldrb     w8, [x2, #0x53]
00689EC34  tbnz     w8, #5, #0x689ec54
00689EC38  str      w20, [x19, #0x20]
00689EC3C  b        #0x689ec64 ; 
00689EC40  ldr      x2, [x1, #0x60]
00689EC44  mov      x0, x19
00689EC48  ldp      x20, x19, [sp, #0x10]
00689EC4C  ldp      x30, x21, [sp], #0x20
00689EC50  br       x2
00689EC54  ldr      x8, [x2, #0x60]
00689EC58  mov      x0, x19
00689EC5C  mov      w1, w20
00689EC60  blr      x8
00689EC64  mov      x0, x19
00689EC68  mov      x1, xzr
00689EC6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689EC70  adrp     x21, #0x959c000
00689EC74  ldrb     w8, [x21, #0x4fe]
00689EC78  mov      w20, w0
00689EC7C  cbnz     w8, #0x689ec94
00689EC80  adrp     x0, #0x8f26000
00689EC84  ldr      x0, [x0, #0x1a0]
00689EC88  bl       #0x382bd14 ; 
00689EC8C  mov      w8, #1
00689EC90  strb     w8, [x21, #0x4fe]
00689EC94  adrp     x8, #0x8f26000
00689EC98  ldr      x8, [x8, #0x1a0]
00689EC9C  ldr      x2, [x8]
00689ECA0  ldrb     w8, [x2, #0x53]
00689ECA4  tbnz     w8, #5, #0x689ecb0
00689ECA8  str      w20, [x19, #0x24]
00689ECAC  b        #0x689ecc0 ; 
00689ECB0  ldr      x8, [x2, #0x60]
00689ECB4  mov      x0, x19
00689ECB8  mov      w1, w20
00689ECBC  blr      x8
00689ECC0  mov      x0, x19
00689ECC4  mov      x1, xzr
00689ECC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689ECCC  adrp     x21, #0x959c000
00689ECD0  ldrb     w8, [x21, #0x4ff]
00689ECD4  mov      w20, w0
00689ECD8  cbnz     w8, #0x689ecf0
00689ECDC  adrp     x0, #0x8f26000
00689ECE0  ldr      x0, [x0, #0x1b0]
00689ECE4  bl       #0x382bd14 ; 
00689ECE8  mov      w8, #1
00689ECEC  strb     w8, [x21, #0x4ff]
00689ECF0  adrp     x8, #0x8f26000
00689ECF4  ldr      x8, [x8, #0x1b0]
00689ECF8  ldr      x2, [x8]
00689ECFC  ldrb     w8, [x2, #0x53]
00689ED00  tbnz     w8, #5, #0x689ed0c
00689ED04  str      w20, [x19, #0x28]
00689ED08  b        #0x689ed1c ; 
00689ED0C  ldr      x8, [x2, #0x60]
00689ED10  mov      x0, x19
00689ED14  mov      w1, w20
00689ED18  blr      x8
00689ED1C  mov      x0, x19
00689ED20  mov      x1, xzr
00689ED24  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689ED28  adrp     x21, #0x959c000
00689ED2C  ldrb     w8, [x21, #0x500]
00689ED30  mov      x20, x0
00689ED34  cbnz     w8, #0x689ed4c
00689ED38  adrp     x0, #0x8f26000
00689ED3C  ldr      x0, [x0, #0x1c0]
00689ED40  bl       #0x382bd14 ; 
00689ED44  mov      w8, #1
00689ED48  strb     w8, [x21, #0x500]
00689ED4C  adrp     x8, #0x8f26000
00689ED50  ldr      x8, [x8, #0x1c0]
00689ED54  ldr      x2, [x8]
00689ED58  ldrb     w8, [x2, #0x53]
00689ED5C  tbnz     w8, #5, #0x689ed74
00689ED60  mov      x0, x19
00689ED64  str      x20, [x0, #0x30]!
00689ED68  mov      x1, x20
00689ED6C  bl       #0x382bcb8 ; 
00689ED70  b        #0x689ed84 ; 
00689ED74  ldr      x8, [x2, #0x60]
00689ED78  mov      x0, x19
00689ED7C  mov      x1, x20
00689ED80  blr      x8
00689ED84  mov      x0, x19
00689ED88  mov      x1, xzr
00689ED8C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689ED90  adrp     x21, #0x959c000
00689ED94  ldrb     w8, [x21, #0x501]
00689ED98  mov      x20, x0
00689ED9C  cbnz     w8, #0x689edb4
00689EDA0  adrp     x0, #0x8f26000
00689EDA4  ldr      x0, [x0, #0x1d0]
00689EDA8  bl       #0x382bd14 ; 
00689EDAC  mov      w8, #1
00689EDB0  strb     w8, [x21, #0x501]
00689EDB4  adrp     x8, #0x8f26000
00689EDB8  ldr      x8, [x8, #0x1d0]
00689EDBC  ldr      x2, [x8]
00689EDC0  ldrb     w8, [x2, #0x53]
00689EDC4  tbnz     w8, #5, #0x689eddc
00689EDC8  mov      x0, x19
00689EDCC  str      x20, [x0, #0x38]!
00689EDD0  mov      x1, x20
00689EDD4  bl       #0x382bcb8 ; 
00689EDD8  b        #0x689edec ; 
00689EDDC  ldr      x8, [x2, #0x60]
00689EDE0  mov      x0, x19
00689EDE4  mov      x1, x20
00689EDE8  blr      x8
00689EDEC  mov      x0, x19
00689EDF0  mov      x1, xzr
00689EDF4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689EDF8  adrp     x21, #0x959c000
00689EDFC  ldrb     w8, [x21, #0x502]
00689EE00  mov      x20, x0
00689EE04  cbnz     w8, #0x689ee1c
00689EE08  adrp     x0, #0x8f26000
00689EE0C  ldr      x0, [x0, #0x1e0]
00689EE10  bl       #0x382bd14 ; 
00689EE14  mov      w8, #1
00689EE18  strb     w8, [x21, #0x502]
00689EE1C  adrp     x8, #0x8f26000
00689EE20  ldr      x8, [x8, #0x1e0]
00689EE24  ldr      x2, [x8]
00689EE28  ldrb     w8, [x2, #0x53]
00689EE2C  tbnz     w8, #5, #0x689ee38
00689EE30  str      x20, [x19, #0x40]
00689EE34  b        #0x689ee48 ; 
00689EE38  ldr      x8, [x2, #0x60]
00689EE3C  mov      x0, x19
00689EE40  mov      x1, x20
00689EE44  blr      x8
00689EE48  mov      x0, x19
00689EE4C  mov      x1, xzr
00689EE50  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689EE54  adrp     x21, #0x959c000
00689EE58  ldrb     w8, [x21, #0x503]
00689EE5C  mov      x20, x0
00689EE60  cbnz     w8, #0x689ee78
00689EE64  adrp     x0, #0x8f26000
00689EE68  ldr      x0, [x0, #0x1f0]
00689EE6C  bl       #0x382bd14 ; 
00689EE70  mov      w8, #1
00689EE74  strb     w8, [x21, #0x503]
00689EE78  adrp     x8, #0x8f26000
00689EE7C  ldr      x8, [x8, #0x1f0]
00689EE80  ldr      x2, [x8]
00689EE84  ldrb     w8, [x2, #0x53]
00689EE88  tbnz     w8, #5, #0x689ee94
00689EE8C  str      x20, [x19, #0x48]
00689EE90  b        #0x689eea4 ; 
00689EE94  ldr      x8, [x2, #0x60]
00689EE98  mov      x0, x19
00689EE9C  mov      x1, x20
00689EEA0  blr      x8
00689EEA4  mov      x0, x19
00689EEA8  mov      x1, xzr
00689EEAC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689EEB0  adrp     x21, #0x959c000
00689EEB4  ldrb     w8, [x21, #0x504]
00689EEB8  mov      x20, x0
00689EEBC  cbnz     w8, #0x689eed4
00689EEC0  adrp     x0, #0x8f26000
00689EEC4  ldr      x0, [x0, #0x200]
00689EEC8  bl       #0x382bd14 ; 
00689EECC  mov      w8, #1
00689EED0  strb     w8, [x21, #0x504]
00689EED4  adrp     x8, #0x8f26000
00689EED8  ldr      x8, [x8, #0x200]
00689EEDC  ldr      x2, [x8]
00689EEE0  ldrb     w8, [x2, #0x53]
00689EEE4  tbnz     w8, #5, #0x689eef0
00689EEE8  str      x20, [x19, #0x50]
00689EEEC  b        #0x689ef00 ; 
00689EEF0  ldr      x8, [x2, #0x60]
00689EEF4  mov      x0, x19
00689EEF8  mov      x1, x20
00689EEFC  blr      x8
00689EF00  mov      x0, x19
00689EF04  mov      x1, xzr
00689EF08  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689EF0C  adrp     x21, #0x959c000
00689EF10  ldrb     w8, [x21, #0x505]
00689EF14  mov      x20, x0
00689EF18  cbnz     w8, #0x689ef30
00689EF1C  adrp     x0, #0x8f26000
00689EF20  ldr      x0, [x0, #0x210]
00689EF24  bl       #0x382bd14 ; 
00689EF28  mov      w8, #1
00689EF2C  strb     w8, [x21, #0x505]
00689EF30  adrp     x8, #0x8f26000
00689EF34  ldr      x8, [x8, #0x210]
00689EF38  ldr      x2, [x8]
00689EF3C  ldrb     w8, [x2, #0x53]
00689EF40  tbnz     w8, #5, #0x689ef4c
00689EF44  str      x20, [x19, #0x58]
00689EF48  b        #0x689ef5c ; 
00689EF4C  ldr      x8, [x2, #0x60]
00689EF50  mov      x0, x19
00689EF54  mov      x1, x20
00689EF58  blr      x8
00689EF5C  mov      x0, x19
00689EF60  mov      x1, xzr
00689EF64  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689EF68  adrp     x21, #0x959c000
00689EF6C  ldrb     w8, [x21, #0x506]
00689EF70  mov      x20, x0
00689EF74  cbnz     w8, #0x689ef8c
00689EF78  adrp     x0, #0x8f26000
00689EF7C  ldr      x0, [x0, #0x220]
00689EF80  bl       #0x382bd14 ; 
00689EF84  mov      w8, #1
00689EF88  strb     w8, [x21, #0x506]
00689EF8C  adrp     x8, #0x8f26000
00689EF90  ldr      x8, [x8, #0x220]
00689EF94  ldr      x2, [x8]
00689EF98  ldrb     w8, [x2, #0x53]
00689EF9C  tbnz     w8, #5, #0x689efa8
00689EFA0  str      x20, [x19, #0x60]
00689EFA4  b        #0x689efb8 ; 
00689EFA8  ldr      x8, [x2, #0x60]
00689EFAC  mov      x0, x19
00689EFB0  mov      x1, x20
00689EFB4  blr      x8
00689EFB8  mov      x0, x19
00689EFBC  mov      x1, xzr
00689EFC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689EFC4  adrp     x21, #0x959c000
00689EFC8  ldrb     w8, [x21, #0x507]
00689EFCC  mov      w20, w0
00689EFD0  cbnz     w8, #0x689efe8
00689EFD4  adrp     x0, #0x8f26000
00689EFD8  ldr      x0, [x0, #0x230]
00689EFDC  bl       #0x382bd14 ; 
00689EFE0  mov      w8, #1
00689EFE4  strb     w8, [x21, #0x507]
00689EFE8  adrp     x8, #0x8f26000
00689EFEC  ldr      x8, [x8, #0x230]
00689EFF0  ldr      x2, [x8]
00689EFF4  ldrb     w8, [x2, #0x53]
00689EFF8  tbnz     w8, #5, #0x689f004
00689EFFC  str      w20, [x19, #0x68]
00689F000  b        #0x689f014 ; 
00689F004  ldr      x8, [x2, #0x60]
00689F008  mov      x0, x19
00689F00C  mov      w1, w20
00689F010  blr      x8
00689F014  mov      x0, x19
00689F018  mov      x1, xzr
00689F01C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689F020  adrp     x21, #0x959c000
00689F024  ldrb     w8, [x21, #0x508]
00689F028  mov      w20, w0
00689F02C  cbnz     w8, #0x689f044
00689F030  adrp     x0, #0x8f26000
00689F034  ldr      x0, [x0, #0x240]
00689F038  bl       #0x382bd14 ; 
00689F03C  mov      w8, #1
00689F040  strb     w8, [x21, #0x508]
00689F044  adrp     x8, #0x8f26000
00689F048  ldr      x8, [x8, #0x240]
00689F04C  ldr      x2, [x8]
00689F050  ldrb     w8, [x2, #0x53]
00689F054  tbnz     w8, #5, #0x689f060
00689F058  str      w20, [x19, #0x6c]
00689F05C  b        #0x689f070 ; 
00689F060  ldr      x8, [x2, #0x60]
00689F064  mov      x0, x19
00689F068  mov      w1, w20
00689F06C  blr      x8
00689F070  ldp      x20, x19, [sp, #0x10]
00689F074  mov      w0, #1
00689F078  ldp      x30, x21, [sp], #0x20
00689F07C  ret      

