; LocalModels.Bean.Drone_Drone$$readImpl
; RVA 0x6A5EBB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5EBB0  stp      x30, x21, [sp, #-0x20]!
006A5EBB4  stp      x20, x19, [sp, #0x10]
006A5EBB8  adrp     x20, #0x959d000
006A5EBBC  adrp     x21, #0x8f36000
006A5EBC0  ldrb     w8, [x20, #0xbd0]
006A5EBC4  ldr      x21, [x21, #0x8e8]
006A5EBC8  mov      x19, x0
006A5EBCC  tbnz     w8, #0, #0x6a5ebe4
006A5EBD0  adrp     x0, #0x8f36000
006A5EBD4  ldr      x0, [x0, #0x8e8]
006A5EBD8  bl       #0x382bd14 ; 
006A5EBDC  mov      w8, #1
006A5EBE0  strb     w8, [x20, #0xbd0]
006A5EBE4  ldr      x1, [x21]
006A5EBE8  ldrb     w8, [x1, #0x53]
006A5EBEC  tbnz     w8, #5, #0x6a5ec3c
006A5EBF0  mov      x0, x19
006A5EBF4  mov      x1, xzr
006A5EBF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5EBFC  adrp     x21, #0x959e000
006A5EC00  ldrb     w8, [x21, #0x383]
006A5EC04  mov      w20, w0
006A5EC08  cbnz     w8, #0x6a5ec20
006A5EC0C  adrp     x0, #0x8f36000
006A5EC10  ldr      x0, [x0, #0x830]
006A5EC14  bl       #0x382bd14 ; 
006A5EC18  mov      w8, #1
006A5EC1C  strb     w8, [x21, #0x383]
006A5EC20  adrp     x8, #0x8f36000
006A5EC24  ldr      x8, [x8, #0x830]
006A5EC28  ldr      x2, [x8]
006A5EC2C  ldrb     w8, [x2, #0x53]
006A5EC30  tbnz     w8, #5, #0x6a5ec50
006A5EC34  str      w20, [x19, #0x20]
006A5EC38  b        #0x6a5ec60 ; 
006A5EC3C  ldr      x2, [x1, #0x60]
006A5EC40  mov      x0, x19
006A5EC44  ldp      x20, x19, [sp, #0x10]
006A5EC48  ldp      x30, x21, [sp], #0x20
006A5EC4C  br       x2
006A5EC50  ldr      x8, [x2, #0x60]
006A5EC54  mov      x0, x19
006A5EC58  mov      w1, w20
006A5EC5C  blr      x8
006A5EC60  mov      x0, x19
006A5EC64  mov      x1, xzr
006A5EC68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5EC6C  adrp     x21, #0x959e000
006A5EC70  ldrb     w8, [x21, #0x384]
006A5EC74  mov      w20, w0
006A5EC78  cbnz     w8, #0x6a5ec90
006A5EC7C  adrp     x0, #0x8f36000
006A5EC80  ldr      x0, [x0, #0x840]
006A5EC84  bl       #0x382bd14 ; 
006A5EC88  mov      w8, #1
006A5EC8C  strb     w8, [x21, #0x384]
006A5EC90  adrp     x8, #0x8f36000
006A5EC94  ldr      x8, [x8, #0x840]
006A5EC98  ldr      x2, [x8]
006A5EC9C  ldrb     w8, [x2, #0x53]
006A5ECA0  tbnz     w8, #5, #0x6a5ecac
006A5ECA4  str      w20, [x19, #0x24]
006A5ECA8  b        #0x6a5ecbc ; 
006A5ECAC  ldr      x8, [x2, #0x60]
006A5ECB0  mov      x0, x19
006A5ECB4  mov      w1, w20
006A5ECB8  blr      x8
006A5ECBC  mov      x0, x19
006A5ECC0  mov      x1, xzr
006A5ECC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5ECC8  adrp     x21, #0x959e000
006A5ECCC  ldrb     w8, [x21, #0x385]
006A5ECD0  mov      w20, w0
006A5ECD4  cbnz     w8, #0x6a5ecec
006A5ECD8  adrp     x0, #0x8f36000
006A5ECDC  ldr      x0, [x0, #0x850]
006A5ECE0  bl       #0x382bd14 ; 
006A5ECE4  mov      w8, #1
006A5ECE8  strb     w8, [x21, #0x385]
006A5ECEC  adrp     x8, #0x8f36000
006A5ECF0  ldr      x8, [x8, #0x850]
006A5ECF4  ldr      x2, [x8]
006A5ECF8  ldrb     w8, [x2, #0x53]
006A5ECFC  tbnz     w8, #5, #0x6a5ed08
006A5ED00  str      w20, [x19, #0x28]
006A5ED04  b        #0x6a5ed18 ; 
006A5ED08  ldr      x8, [x2, #0x60]
006A5ED0C  mov      x0, x19
006A5ED10  mov      w1, w20
006A5ED14  blr      x8
006A5ED18  mov      x0, x19
006A5ED1C  mov      x1, xzr
006A5ED20  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5ED24  adrp     x21, #0x959e000
006A5ED28  ldrb     w8, [x21, #0x386]
006A5ED2C  mov      x20, x0
006A5ED30  cbnz     w8, #0x6a5ed48
006A5ED34  adrp     x0, #0x8f36000
006A5ED38  ldr      x0, [x0, #0x860]
006A5ED3C  bl       #0x382bd14 ; 
006A5ED40  mov      w8, #1
006A5ED44  strb     w8, [x21, #0x386]
006A5ED48  adrp     x8, #0x8f36000
006A5ED4C  ldr      x8, [x8, #0x860]
006A5ED50  ldr      x2, [x8]
006A5ED54  ldrb     w8, [x2, #0x53]
006A5ED58  tbnz     w8, #5, #0x6a5ed70
006A5ED5C  mov      x0, x19
006A5ED60  str      x20, [x0, #0x30]!
006A5ED64  mov      x1, x20
006A5ED68  bl       #0x382bcb8 ; 
006A5ED6C  b        #0x6a5ed80 ; 
006A5ED70  ldr      x8, [x2, #0x60]
006A5ED74  mov      x0, x19
006A5ED78  mov      x1, x20
006A5ED7C  blr      x8
006A5ED80  mov      x0, x19
006A5ED84  mov      x1, xzr
006A5ED88  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5ED8C  adrp     x21, #0x959e000
006A5ED90  ldrb     w8, [x21, #0x387]
006A5ED94  mov      x20, x0
006A5ED98  cbnz     w8, #0x6a5edb0
006A5ED9C  adrp     x0, #0x8f36000
006A5EDA0  ldr      x0, [x0, #0x868]
006A5EDA4  bl       #0x382bd14 ; 
006A5EDA8  mov      w8, #1
006A5EDAC  strb     w8, [x21, #0x387]
006A5EDB0  adrp     x8, #0x8f36000
006A5EDB4  ldr      x8, [x8, #0x868]
006A5EDB8  ldr      x2, [x8]
006A5EDBC  ldrb     w8, [x2, #0x53]
006A5EDC0  tbnz     w8, #5, #0x6a5edd8
006A5EDC4  mov      x0, x19
006A5EDC8  str      x20, [x0, #0x38]!
006A5EDCC  mov      x1, x20
006A5EDD0  bl       #0x382bcb8 ; 
006A5EDD4  b        #0x6a5ede8 ; 
006A5EDD8  ldr      x8, [x2, #0x60]
006A5EDDC  mov      x0, x19
006A5EDE0  mov      x1, x20
006A5EDE4  blr      x8
006A5EDE8  mov      x0, x19
006A5EDEC  mov      x1, xzr
006A5EDF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5EDF4  adrp     x21, #0x959e000
006A5EDF8  ldrb     w8, [x21, #0x388]
006A5EDFC  mov      w20, w0
006A5EE00  cbnz     w8, #0x6a5ee18
006A5EE04  adrp     x0, #0x8f36000
006A5EE08  ldr      x0, [x0, #0x878]
006A5EE0C  bl       #0x382bd14 ; 
006A5EE10  mov      w8, #1
006A5EE14  strb     w8, [x21, #0x388]
006A5EE18  adrp     x8, #0x8f36000
006A5EE1C  ldr      x8, [x8, #0x878]
006A5EE20  ldr      x2, [x8]
006A5EE24  ldrb     w8, [x2, #0x53]
006A5EE28  tbnz     w8, #5, #0x6a5ee34
006A5EE2C  str      w20, [x19, #0x40]
006A5EE30  b        #0x6a5ee44 ; 
006A5EE34  ldr      x8, [x2, #0x60]
006A5EE38  mov      x0, x19
006A5EE3C  mov      w1, w20
006A5EE40  blr      x8
006A5EE44  mov      x0, x19
006A5EE48  mov      x1, xzr
006A5EE4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5EE50  adrp     x21, #0x959e000
006A5EE54  ldrb     w8, [x21, #0x389]
006A5EE58  mov      w20, w0
006A5EE5C  cbnz     w8, #0x6a5ee74
006A5EE60  adrp     x0, #0x8f36000
006A5EE64  ldr      x0, [x0, #0x888]
006A5EE68  bl       #0x382bd14 ; 
006A5EE6C  mov      w8, #1
006A5EE70  strb     w8, [x21, #0x389]
006A5EE74  adrp     x8, #0x8f36000
006A5EE78  ldr      x8, [x8, #0x888]
006A5EE7C  ldr      x2, [x8]
006A5EE80  ldrb     w8, [x2, #0x53]
006A5EE84  tbnz     w8, #5, #0x6a5ee90
006A5EE88  str      w20, [x19, #0x44]
006A5EE8C  b        #0x6a5eea0 ; 
006A5EE90  ldr      x8, [x2, #0x60]
006A5EE94  mov      x0, x19
006A5EE98  mov      w1, w20
006A5EE9C  blr      x8
006A5EEA0  mov      x0, x19
006A5EEA4  mov      x1, xzr
006A5EEA8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5EEAC  adrp     x21, #0x959e000
006A5EEB0  ldrb     w8, [x21, #0x38a]
006A5EEB4  mov      x20, x0
006A5EEB8  cbnz     w8, #0x6a5eed0
006A5EEBC  adrp     x0, #0x8f36000
006A5EEC0  ldr      x0, [x0, #0x898]
006A5EEC4  bl       #0x382bd14 ; 
006A5EEC8  mov      w8, #1
006A5EECC  strb     w8, [x21, #0x38a]
006A5EED0  adrp     x8, #0x8f36000
006A5EED4  ldr      x8, [x8, #0x898]
006A5EED8  ldr      x2, [x8]
006A5EEDC  ldrb     w8, [x2, #0x53]
006A5EEE0  tbnz     w8, #5, #0x6a5eef8
006A5EEE4  mov      x0, x19
006A5EEE8  str      x20, [x0, #0x48]!
006A5EEEC  mov      x1, x20
006A5EEF0  bl       #0x382bcb8 ; 
006A5EEF4  b        #0x6a5ef08 ; 
006A5EEF8  ldr      x8, [x2, #0x60]
006A5EEFC  mov      x0, x19
006A5EF00  mov      x1, x20
006A5EF04  blr      x8
006A5EF08  mov      x0, x19
006A5EF0C  mov      x1, xzr
006A5EF10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5EF14  adrp     x21, #0x959e000
006A5EF18  ldrb     w8, [x21, #0x38b]
006A5EF1C  mov      w20, w0
006A5EF20  cbnz     w8, #0x6a5ef38
006A5EF24  adrp     x0, #0x8f36000
006A5EF28  ldr      x0, [x0, #0x8a8]
006A5EF2C  bl       #0x382bd14 ; 
006A5EF30  mov      w8, #1
006A5EF34  strb     w8, [x21, #0x38b]
006A5EF38  adrp     x8, #0x8f36000
006A5EF3C  ldr      x8, [x8, #0x8a8]
006A5EF40  ldr      x2, [x8]
006A5EF44  ldrb     w8, [x2, #0x53]
006A5EF48  tbnz     w8, #5, #0x6a5ef54
006A5EF4C  str      w20, [x19, #0x50]
006A5EF50  b        #0x6a5ef64 ; 
006A5EF54  ldr      x8, [x2, #0x60]
006A5EF58  mov      x0, x19
006A5EF5C  mov      w1, w20
006A5EF60  blr      x8
006A5EF64  mov      x0, x19
006A5EF68  mov      x1, xzr
006A5EF6C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5EF70  adrp     x21, #0x959e000
006A5EF74  ldrb     w8, [x21, #0x38c]
006A5EF78  mov      x20, x0
006A5EF7C  cbnz     w8, #0x6a5ef94
006A5EF80  adrp     x0, #0x8f36000
006A5EF84  ldr      x0, [x0, #0x8b8]
006A5EF88  bl       #0x382bd14 ; 
006A5EF8C  mov      w8, #1
006A5EF90  strb     w8, [x21, #0x38c]
006A5EF94  adrp     x8, #0x8f36000
006A5EF98  ldr      x8, [x8, #0x8b8]
006A5EF9C  ldr      x2, [x8]
006A5EFA0  ldrb     w8, [x2, #0x53]
006A5EFA4  tbnz     w8, #5, #0x6a5efbc
006A5EFA8  mov      x0, x19
006A5EFAC  str      x20, [x0, #0x58]!
006A5EFB0  mov      x1, x20
006A5EFB4  bl       #0x382bcb8 ; 
006A5EFB8  b        #0x6a5efcc ; 
006A5EFBC  ldr      x8, [x2, #0x60]
006A5EFC0  mov      x0, x19
006A5EFC4  mov      x1, x20
006A5EFC8  blr      x8
006A5EFCC  mov      x0, x19
006A5EFD0  mov      x1, xzr
006A5EFD4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5EFD8  adrp     x21, #0x959e000
006A5EFDC  ldrb     w8, [x21, #0x38d]
006A5EFE0  mov      w20, w0
006A5EFE4  cbnz     w8, #0x6a5effc
006A5EFE8  adrp     x0, #0x8f36000
006A5EFEC  ldr      x0, [x0, #0x8c0]
006A5EFF0  bl       #0x382bd14 ; 
006A5EFF4  mov      w8, #1
006A5EFF8  strb     w8, [x21, #0x38d]
006A5EFFC  adrp     x8, #0x8f36000
006A5F000  ldr      x8, [x8, #0x8c0]
006A5F004  ldr      x2, [x8]
006A5F008  ldrb     w8, [x2, #0x53]
006A5F00C  tbnz     w8, #5, #0x6a5f018
006A5F010  str      w20, [x19, #0x60]
006A5F014  b        #0x6a5f028 ; 
006A5F018  ldr      x8, [x2, #0x60]
006A5F01C  mov      x0, x19
006A5F020  mov      w1, w20
006A5F024  blr      x8
006A5F028  mov      x0, x19
006A5F02C  mov      x1, xzr
006A5F030  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5F034  adrp     x21, #0x959e000
006A5F038  ldrb     w8, [x21, #0x38e]
006A5F03C  mov      x20, x0
006A5F040  cbnz     w8, #0x6a5f058
006A5F044  adrp     x0, #0x8f36000
006A5F048  ldr      x0, [x0, #0x8d0]
006A5F04C  bl       #0x382bd14 ; 
006A5F050  mov      w8, #1
006A5F054  strb     w8, [x21, #0x38e]
006A5F058  adrp     x8, #0x8f36000
006A5F05C  ldr      x8, [x8, #0x8d0]
006A5F060  ldr      x2, [x8]
006A5F064  ldrb     w8, [x2, #0x53]
006A5F068  tbnz     w8, #5, #0x6a5f080
006A5F06C  mov      x0, x19
006A5F070  str      x20, [x0, #0x68]!
006A5F074  mov      x1, x20
006A5F078  bl       #0x382bcb8 ; 
006A5F07C  b        #0x6a5f090 ; 
006A5F080  ldr      x8, [x2, #0x60]
006A5F084  mov      x0, x19
006A5F088  mov      x1, x20
006A5F08C  blr      x8
006A5F090  mov      x0, x19
006A5F094  mov      x1, xzr
006A5F098  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5F09C  adrp     x21, #0x959e000
006A5F0A0  ldrb     w8, [x21, #0x38f]
006A5F0A4  mov      x20, x0
006A5F0A8  cbnz     w8, #0x6a5f0c0
006A5F0AC  adrp     x0, #0x8f36000
006A5F0B0  ldr      x0, [x0, #0x8e0]
006A5F0B4  bl       #0x382bd14 ; 
006A5F0B8  mov      w8, #1
006A5F0BC  strb     w8, [x21, #0x38f]
006A5F0C0  adrp     x8, #0x8f36000
006A5F0C4  ldr      x8, [x8, #0x8e0]
006A5F0C8  ldr      x2, [x8]
006A5F0CC  ldrb     w8, [x2, #0x53]
006A5F0D0  tbnz     w8, #5, #0x6a5f0e8
006A5F0D4  str      x20, [x19, #0x70]!
006A5F0D8  mov      x0, x19
006A5F0DC  mov      x1, x20
006A5F0E0  bl       #0x382bcb8 ; 
006A5F0E4  b        #0x6a5f0f8 ; 
006A5F0E8  ldr      x8, [x2, #0x60]
006A5F0EC  mov      x0, x19
006A5F0F0  mov      x1, x20
006A5F0F4  blr      x8
006A5F0F8  ldp      x20, x19, [sp, #0x10]
006A5F0FC  mov      w0, #1
006A5F100  ldp      x30, x21, [sp], #0x20
006A5F104  ret      

