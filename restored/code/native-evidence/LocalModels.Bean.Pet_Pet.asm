; LocalModels.Bean.Pet_Pet$$readImpl
; RVA 0x6ACF6C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACF6C4  stp      x30, x21, [sp, #-0x20]!
006ACF6C8  stp      x20, x19, [sp, #0x10]
006ACF6CC  adrp     x20, #0x959e000
006ACF6D0  adrp     x21, #0x8f3b000
006ACF6D4  ldrb     w8, [x20, #0xb01]
006ACF6D8  ldr      x21, [x21, #0xd70]
006ACF6DC  mov      x19, x0
006ACF6E0  tbnz     w8, #0, #0x6acf6f8
006ACF6E4  adrp     x0, #0x8f3b000
006ACF6E8  ldr      x0, [x0, #0xd70]
006ACF6EC  bl       #0x382bd14 ; 
006ACF6F0  mov      w8, #1
006ACF6F4  strb     w8, [x20, #0xb01]
006ACF6F8  ldr      x1, [x21]
006ACF6FC  ldrb     w8, [x1, #0x53]
006ACF700  tbnz     w8, #5, #0x6acf750
006ACF704  mov      x0, x19
006ACF708  mov      x1, xzr
006ACF70C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACF710  adrp     x21, #0x959f000
006ACF714  ldrb     w8, [x21, #0xcd]
006ACF718  mov      w20, w0
006ACF71C  cbnz     w8, #0x6acf734
006ACF720  adrp     x0, #0x8f3b000
006ACF724  ldr      x0, [x0, #0xc28]
006ACF728  bl       #0x382bd14 ; 
006ACF72C  mov      w8, #1
006ACF730  strb     w8, [x21, #0xcd]
006ACF734  adrp     x8, #0x8f3b000
006ACF738  ldr      x8, [x8, #0xc28]
006ACF73C  ldr      x2, [x8]
006ACF740  ldrb     w8, [x2, #0x53]
006ACF744  tbnz     w8, #5, #0x6acf764
006ACF748  str      w20, [x19, #0x20]
006ACF74C  b        #0x6acf774 ; 
006ACF750  ldr      x2, [x1, #0x60]
006ACF754  mov      x0, x19
006ACF758  ldp      x20, x19, [sp, #0x10]
006ACF75C  ldp      x30, x21, [sp], #0x20
006ACF760  br       x2
006ACF764  ldr      x8, [x2, #0x60]
006ACF768  mov      x0, x19
006ACF76C  mov      w1, w20
006ACF770  blr      x8
006ACF774  mov      x0, x19
006ACF778  mov      x1, xzr
006ACF77C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACF780  adrp     x21, #0x959f000
006ACF784  ldrb     w8, [x21, #0xce]
006ACF788  mov      w20, w0
006ACF78C  cbnz     w8, #0x6acf7a4
006ACF790  adrp     x0, #0x8f3b000
006ACF794  ldr      x0, [x0, #0xc38]
006ACF798  bl       #0x382bd14 ; 
006ACF79C  mov      w8, #1
006ACF7A0  strb     w8, [x21, #0xce]
006ACF7A4  adrp     x8, #0x8f3b000
006ACF7A8  ldr      x8, [x8, #0xc38]
006ACF7AC  ldr      x2, [x8]
006ACF7B0  ldrb     w8, [x2, #0x53]
006ACF7B4  tbnz     w8, #5, #0x6acf7c0
006ACF7B8  str      w20, [x19, #0x24]
006ACF7BC  b        #0x6acf7d0 ; 
006ACF7C0  ldr      x8, [x2, #0x60]
006ACF7C4  mov      x0, x19
006ACF7C8  mov      w1, w20
006ACF7CC  blr      x8
006ACF7D0  mov      x0, x19
006ACF7D4  mov      x1, xzr
006ACF7D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACF7DC  adrp     x21, #0x959f000
006ACF7E0  ldrb     w8, [x21, #0xcf]
006ACF7E4  mov      w20, w0
006ACF7E8  cbnz     w8, #0x6acf800
006ACF7EC  adrp     x0, #0x8f3b000
006ACF7F0  ldr      x0, [x0, #0xc48]
006ACF7F4  bl       #0x382bd14 ; 
006ACF7F8  mov      w8, #1
006ACF7FC  strb     w8, [x21, #0xcf]
006ACF800  adrp     x8, #0x8f3b000
006ACF804  ldr      x8, [x8, #0xc48]
006ACF808  ldr      x2, [x8]
006ACF80C  ldrb     w8, [x2, #0x53]
006ACF810  tbnz     w8, #5, #0x6acf81c
006ACF814  str      w20, [x19, #0x28]
006ACF818  b        #0x6acf82c ; 
006ACF81C  ldr      x8, [x2, #0x60]
006ACF820  mov      x0, x19
006ACF824  mov      w1, w20
006ACF828  blr      x8
006ACF82C  mov      x0, x19
006ACF830  mov      x1, xzr
006ACF834  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACF838  adrp     x21, #0x959f000
006ACF83C  ldrb     w8, [x21, #0xd0]
006ACF840  mov      w20, w0
006ACF844  cbnz     w8, #0x6acf85c
006ACF848  adrp     x0, #0x8f3b000
006ACF84C  ldr      x0, [x0, #0xc58]
006ACF850  bl       #0x382bd14 ; 
006ACF854  mov      w8, #1
006ACF858  strb     w8, [x21, #0xd0]
006ACF85C  adrp     x8, #0x8f3b000
006ACF860  ldr      x8, [x8, #0xc58]
006ACF864  ldr      x2, [x8]
006ACF868  ldrb     w8, [x2, #0x53]
006ACF86C  tbnz     w8, #5, #0x6acf878
006ACF870  str      w20, [x19, #0x2c]
006ACF874  b        #0x6acf888 ; 
006ACF878  ldr      x8, [x2, #0x60]
006ACF87C  mov      x0, x19
006ACF880  mov      w1, w20
006ACF884  blr      x8
006ACF888  mov      x0, x19
006ACF88C  mov      x1, xzr
006ACF890  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACF894  adrp     x21, #0x959f000
006ACF898  ldrb     w8, [x21, #0xd1]
006ACF89C  mov      x20, x0
006ACF8A0  cbnz     w8, #0x6acf8b8
006ACF8A4  adrp     x0, #0x8f3b000
006ACF8A8  ldr      x0, [x0, #0xc68]
006ACF8AC  bl       #0x382bd14 ; 
006ACF8B0  mov      w8, #1
006ACF8B4  strb     w8, [x21, #0xd1]
006ACF8B8  adrp     x8, #0x8f3b000
006ACF8BC  ldr      x8, [x8, #0xc68]
006ACF8C0  ldr      x2, [x8]
006ACF8C4  ldrb     w8, [x2, #0x53]
006ACF8C8  tbnz     w8, #5, #0x6acf8e0
006ACF8CC  mov      x0, x19
006ACF8D0  str      x20, [x0, #0x30]!
006ACF8D4  mov      x1, x20
006ACF8D8  bl       #0x382bcb8 ; 
006ACF8DC  b        #0x6acf8f0 ; 
006ACF8E0  ldr      x8, [x2, #0x60]
006ACF8E4  mov      x0, x19
006ACF8E8  mov      x1, x20
006ACF8EC  blr      x8
006ACF8F0  mov      x0, x19
006ACF8F4  mov      x1, xzr
006ACF8F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACF8FC  adrp     x21, #0x959f000
006ACF900  ldrb     w8, [x21, #0xd2]
006ACF904  mov      w20, w0
006ACF908  cbnz     w8, #0x6acf920
006ACF90C  adrp     x0, #0x8f3b000
006ACF910  ldr      x0, [x0, #0xc78]
006ACF914  bl       #0x382bd14 ; 
006ACF918  mov      w8, #1
006ACF91C  strb     w8, [x21, #0xd2]
006ACF920  adrp     x8, #0x8f3b000
006ACF924  ldr      x8, [x8, #0xc78]
006ACF928  ldr      x2, [x8]
006ACF92C  ldrb     w8, [x2, #0x53]
006ACF930  tbnz     w8, #5, #0x6acf93c
006ACF934  str      w20, [x19, #0x38]
006ACF938  b        #0x6acf94c ; 
006ACF93C  ldr      x8, [x2, #0x60]
006ACF940  mov      x0, x19
006ACF944  mov      w1, w20
006ACF948  blr      x8
006ACF94C  mov      x0, x19
006ACF950  mov      x1, xzr
006ACF954  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACF958  adrp     x21, #0x959f000
006ACF95C  ldrb     w8, [x21, #0xd3]
006ACF960  mov      x20, x0
006ACF964  cbnz     w8, #0x6acf97c
006ACF968  adrp     x0, #0x8f3b000
006ACF96C  ldr      x0, [x0, #0xc88]
006ACF970  bl       #0x382bd14 ; 
006ACF974  mov      w8, #1
006ACF978  strb     w8, [x21, #0xd3]
006ACF97C  adrp     x8, #0x8f3b000
006ACF980  ldr      x8, [x8, #0xc88]
006ACF984  ldr      x2, [x8]
006ACF988  ldrb     w8, [x2, #0x53]
006ACF98C  tbnz     w8, #5, #0x6acf9a4
006ACF990  mov      x0, x19
006ACF994  str      x20, [x0, #0x40]!
006ACF998  mov      x1, x20
006ACF99C  bl       #0x382bcb8 ; 
006ACF9A0  b        #0x6acf9b4 ; 
006ACF9A4  ldr      x8, [x2, #0x60]
006ACF9A8  mov      x0, x19
006ACF9AC  mov      x1, x20
006ACF9B0  blr      x8
006ACF9B4  mov      x0, x19
006ACF9B8  mov      x1, xzr
006ACF9BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACF9C0  adrp     x21, #0x959f000
006ACF9C4  ldrb     w8, [x21, #0xd4]
006ACF9C8  mov      w20, w0
006ACF9CC  cbnz     w8, #0x6acf9e4
006ACF9D0  adrp     x0, #0x8f3b000
006ACF9D4  ldr      x0, [x0, #0xc98]
006ACF9D8  bl       #0x382bd14 ; 
006ACF9DC  mov      w8, #1
006ACF9E0  strb     w8, [x21, #0xd4]
006ACF9E4  adrp     x8, #0x8f3b000
006ACF9E8  ldr      x8, [x8, #0xc98]
006ACF9EC  ldr      x2, [x8]
006ACF9F0  ldrb     w8, [x2, #0x53]
006ACF9F4  tbnz     w8, #5, #0x6acfa00
006ACF9F8  str      w20, [x19, #0x48]
006ACF9FC  b        #0x6acfa10 ; 
006ACFA00  ldr      x8, [x2, #0x60]
006ACFA04  mov      x0, x19
006ACFA08  mov      w1, w20
006ACFA0C  blr      x8
006ACFA10  mov      x0, x19
006ACFA14  mov      x1, xzr
006ACFA18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACFA1C  adrp     x21, #0x959f000
006ACFA20  ldrb     w8, [x21, #0xd5]
006ACFA24  mov      w20, w0
006ACFA28  cbnz     w8, #0x6acfa40
006ACFA2C  adrp     x0, #0x8f3b000
006ACFA30  ldr      x0, [x0, #0xca8]
006ACFA34  bl       #0x382bd14 ; 
006ACFA38  mov      w8, #1
006ACFA3C  strb     w8, [x21, #0xd5]
006ACFA40  adrp     x8, #0x8f3b000
006ACFA44  ldr      x8, [x8, #0xca8]
006ACFA48  ldr      x2, [x8]
006ACFA4C  ldrb     w8, [x2, #0x53]
006ACFA50  tbnz     w8, #5, #0x6acfa5c
006ACFA54  str      w20, [x19, #0x4c]
006ACFA58  b        #0x6acfa6c ; 
006ACFA5C  ldr      x8, [x2, #0x60]
006ACFA60  mov      x0, x19
006ACFA64  mov      w1, w20
006ACFA68  blr      x8
006ACFA6C  mov      x0, x19
006ACFA70  mov      x1, xzr
006ACFA74  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ACFA78  adrp     x21, #0x959f000
006ACFA7C  ldrb     w8, [x21, #0xd6]
006ACFA80  mov      x20, x0
006ACFA84  cbnz     w8, #0x6acfa9c
006ACFA88  adrp     x0, #0x8f3b000
006ACFA8C  ldr      x0, [x0, #0xcb8]
006ACFA90  bl       #0x382bd14 ; 
006ACFA94  mov      w8, #1
006ACFA98  strb     w8, [x21, #0xd6]
006ACFA9C  adrp     x8, #0x8f3b000
006ACFAA0  ldr      x8, [x8, #0xcb8]
006ACFAA4  ldr      x2, [x8]
006ACFAA8  ldrb     w8, [x2, #0x53]
006ACFAAC  tbnz     w8, #5, #0x6acfac4
006ACFAB0  mov      x0, x19
006ACFAB4  str      x20, [x0, #0x50]!
006ACFAB8  mov      x1, x20
006ACFABC  bl       #0x382bcb8 ; 
006ACFAC0  b        #0x6acfad4 ; 
006ACFAC4  ldr      x8, [x2, #0x60]
006ACFAC8  mov      x0, x19
006ACFACC  mov      x1, x20
006ACFAD0  blr      x8
006ACFAD4  mov      x0, x19
006ACFAD8  mov      x1, xzr
006ACFADC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFAE0  adrp     x21, #0x959f000
006ACFAE4  ldrb     w8, [x21, #0xd7]
006ACFAE8  mov      x20, x0
006ACFAEC  cbnz     w8, #0x6acfb04
006ACFAF0  adrp     x0, #0x8f3b000
006ACFAF4  ldr      x0, [x0, #0xcc8]
006ACFAF8  bl       #0x382bd14 ; 
006ACFAFC  mov      w8, #1
006ACFB00  strb     w8, [x21, #0xd7]
006ACFB04  adrp     x8, #0x8f3b000
006ACFB08  ldr      x8, [x8, #0xcc8]
006ACFB0C  ldr      x2, [x8]
006ACFB10  ldrb     w8, [x2, #0x53]
006ACFB14  tbnz     w8, #5, #0x6acfb2c
006ACFB18  mov      x0, x19
006ACFB1C  str      x20, [x0, #0x58]!
006ACFB20  mov      x1, x20
006ACFB24  bl       #0x382bcb8 ; 
006ACFB28  b        #0x6acfb3c ; 
006ACFB2C  ldr      x8, [x2, #0x60]
006ACFB30  mov      x0, x19
006ACFB34  mov      x1, x20
006ACFB38  blr      x8
006ACFB3C  mov      x0, x19
006ACFB40  mov      x1, xzr
006ACFB44  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFB48  adrp     x21, #0x959f000
006ACFB4C  ldrb     w8, [x21, #0xd8]
006ACFB50  mov      x20, x0
006ACFB54  cbnz     w8, #0x6acfb6c
006ACFB58  adrp     x0, #0x8f3b000
006ACFB5C  ldr      x0, [x0, #0xcd8]
006ACFB60  bl       #0x382bd14 ; 
006ACFB64  mov      w8, #1
006ACFB68  strb     w8, [x21, #0xd8]
006ACFB6C  adrp     x8, #0x8f3b000
006ACFB70  ldr      x8, [x8, #0xcd8]
006ACFB74  ldr      x2, [x8]
006ACFB78  ldrb     w8, [x2, #0x53]
006ACFB7C  tbnz     w8, #5, #0x6acfb94
006ACFB80  mov      x0, x19
006ACFB84  str      x20, [x0, #0x60]!
006ACFB88  mov      x1, x20
006ACFB8C  bl       #0x382bcb8 ; 
006ACFB90  b        #0x6acfba4 ; 
006ACFB94  ldr      x8, [x2, #0x60]
006ACFB98  mov      x0, x19
006ACFB9C  mov      x1, x20
006ACFBA0  blr      x8
006ACFBA4  mov      x0, x19
006ACFBA8  mov      x1, xzr
006ACFBAC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFBB0  adrp     x21, #0x959f000
006ACFBB4  ldrb     w8, [x21, #0xd9]
006ACFBB8  mov      x20, x0
006ACFBBC  cbnz     w8, #0x6acfbd4
006ACFBC0  adrp     x0, #0x8f3b000
006ACFBC4  ldr      x0, [x0, #0xce8]
006ACFBC8  bl       #0x382bd14 ; 
006ACFBCC  mov      w8, #1
006ACFBD0  strb     w8, [x21, #0xd9]
006ACFBD4  adrp     x8, #0x8f3b000
006ACFBD8  ldr      x8, [x8, #0xce8]
006ACFBDC  ldr      x2, [x8]
006ACFBE0  ldrb     w8, [x2, #0x53]
006ACFBE4  tbnz     w8, #5, #0x6acfbfc
006ACFBE8  mov      x0, x19
006ACFBEC  str      x20, [x0, #0x68]!
006ACFBF0  mov      x1, x20
006ACFBF4  bl       #0x382bcb8 ; 
006ACFBF8  b        #0x6acfc0c ; 
006ACFBFC  ldr      x8, [x2, #0x60]
006ACFC00  mov      x0, x19
006ACFC04  mov      x1, x20
006ACFC08  blr      x8
006ACFC0C  mov      x0, x19
006ACFC10  mov      x1, xzr
006ACFC14  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFC18  adrp     x21, #0x959f000
006ACFC1C  ldrb     w8, [x21, #0xda]
006ACFC20  mov      x20, x0
006ACFC24  cbnz     w8, #0x6acfc3c
006ACFC28  adrp     x0, #0x8f3b000
006ACFC2C  ldr      x0, [x0, #0xcf8]
006ACFC30  bl       #0x382bd14 ; 
006ACFC34  mov      w8, #1
006ACFC38  strb     w8, [x21, #0xda]
006ACFC3C  adrp     x8, #0x8f3b000
006ACFC40  ldr      x8, [x8, #0xcf8]
006ACFC44  ldr      x2, [x8]
006ACFC48  ldrb     w8, [x2, #0x53]
006ACFC4C  tbnz     w8, #5, #0x6acfc64
006ACFC50  mov      x0, x19
006ACFC54  str      x20, [x0, #0x70]!
006ACFC58  mov      x1, x20
006ACFC5C  bl       #0x382bcb8 ; 
006ACFC60  b        #0x6acfc74 ; 
006ACFC64  ldr      x8, [x2, #0x60]
006ACFC68  mov      x0, x19
006ACFC6C  mov      x1, x20
006ACFC70  blr      x8
006ACFC74  mov      x0, x19
006ACFC78  mov      x1, xzr
006ACFC7C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFC80  adrp     x21, #0x959f000
006ACFC84  ldrb     w8, [x21, #0xdb]
006ACFC88  mov      x20, x0
006ACFC8C  cbnz     w8, #0x6acfca4
006ACFC90  adrp     x0, #0x8f3b000
006ACFC94  ldr      x0, [x0, #0xd08]
006ACFC98  bl       #0x382bd14 ; 
006ACFC9C  mov      w8, #1
006ACFCA0  strb     w8, [x21, #0xdb]
006ACFCA4  adrp     x8, #0x8f3b000
006ACFCA8  ldr      x8, [x8, #0xd08]
006ACFCAC  ldr      x2, [x8]
006ACFCB0  ldrb     w8, [x2, #0x53]
006ACFCB4  tbnz     w8, #5, #0x6acfccc
006ACFCB8  mov      x0, x19
006ACFCBC  str      x20, [x0, #0x78]!
006ACFCC0  mov      x1, x20
006ACFCC4  bl       #0x382bcb8 ; 
006ACFCC8  b        #0x6acfcdc ; 
006ACFCCC  ldr      x8, [x2, #0x60]
006ACFCD0  mov      x0, x19
006ACFCD4  mov      x1, x20
006ACFCD8  blr      x8
006ACFCDC  mov      x0, x19
006ACFCE0  mov      x1, xzr
006ACFCE4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFCE8  adrp     x21, #0x959f000
006ACFCEC  ldrb     w8, [x21, #0xdc]
006ACFCF0  mov      x20, x0
006ACFCF4  cbnz     w8, #0x6acfd0c
006ACFCF8  adrp     x0, #0x8f3b000
006ACFCFC  ldr      x0, [x0, #0xd18]
006ACFD00  bl       #0x382bd14 ; 
006ACFD04  mov      w8, #1
006ACFD08  strb     w8, [x21, #0xdc]
006ACFD0C  adrp     x8, #0x8f3b000
006ACFD10  ldr      x8, [x8, #0xd18]
006ACFD14  ldr      x2, [x8]
006ACFD18  ldrb     w8, [x2, #0x53]
006ACFD1C  tbnz     w8, #5, #0x6acfd34
006ACFD20  mov      x0, x19
006ACFD24  str      x20, [x0, #0x80]!
006ACFD28  mov      x1, x20
006ACFD2C  bl       #0x382bcb8 ; 
006ACFD30  b        #0x6acfd44 ; 
006ACFD34  ldr      x8, [x2, #0x60]
006ACFD38  mov      x0, x19
006ACFD3C  mov      x1, x20
006ACFD40  blr      x8
006ACFD44  mov      x0, x19
006ACFD48  mov      x1, xzr
006ACFD4C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFD50  adrp     x21, #0x959f000
006ACFD54  ldrb     w8, [x21, #0xdd]
006ACFD58  mov      x20, x0
006ACFD5C  cbnz     w8, #0x6acfd74
006ACFD60  adrp     x0, #0x8f3b000
006ACFD64  ldr      x0, [x0, #0xd28]
006ACFD68  bl       #0x382bd14 ; 
006ACFD6C  mov      w8, #1
006ACFD70  strb     w8, [x21, #0xdd]
006ACFD74  adrp     x8, #0x8f3b000
006ACFD78  ldr      x8, [x8, #0xd28]
006ACFD7C  ldr      x2, [x8]
006ACFD80  ldrb     w8, [x2, #0x53]
006ACFD84  tbnz     w8, #5, #0x6acfd9c
006ACFD88  mov      x0, x19
006ACFD8C  str      x20, [x0, #0x88]!
006ACFD90  mov      x1, x20
006ACFD94  bl       #0x382bcb8 ; 
006ACFD98  b        #0x6acfdac ; 
006ACFD9C  ldr      x8, [x2, #0x60]
006ACFDA0  mov      x0, x19
006ACFDA4  mov      x1, x20
006ACFDA8  blr      x8
006ACFDAC  mov      x0, x19
006ACFDB0  mov      x1, xzr
006ACFDB4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFDB8  adrp     x21, #0x959f000
006ACFDBC  ldrb     w8, [x21, #0xde]
006ACFDC0  mov      x20, x0
006ACFDC4  cbnz     w8, #0x6acfddc
006ACFDC8  adrp     x0, #0x8f3b000
006ACFDCC  ldr      x0, [x0, #0xd38]
006ACFDD0  bl       #0x382bd14 ; 
006ACFDD4  mov      w8, #1
006ACFDD8  strb     w8, [x21, #0xde]
006ACFDDC  adrp     x8, #0x8f3b000
006ACFDE0  ldr      x8, [x8, #0xd38]
006ACFDE4  ldr      x2, [x8]
006ACFDE8  ldrb     w8, [x2, #0x53]
006ACFDEC  tbnz     w8, #5, #0x6acfe04
006ACFDF0  mov      x0, x19
006ACFDF4  str      x20, [x0, #0x90]!
006ACFDF8  mov      x1, x20
006ACFDFC  bl       #0x382bcb8 ; 
006ACFE00  b        #0x6acfe14 ; 
006ACFE04  ldr      x8, [x2, #0x60]
006ACFE08  mov      x0, x19
006ACFE0C  mov      x1, x20
006ACFE10  blr      x8
006ACFE14  mov      x0, x19
006ACFE18  mov      x1, xzr
006ACFE1C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFE20  adrp     x21, #0x959f000
006ACFE24  ldrb     w8, [x21, #0xdf]
006ACFE28  mov      x20, x0
006ACFE2C  cbnz     w8, #0x6acfe44
006ACFE30  adrp     x0, #0x8f3b000
006ACFE34  ldr      x0, [x0, #0xd48]
006ACFE38  bl       #0x382bd14 ; 
006ACFE3C  mov      w8, #1
006ACFE40  strb     w8, [x21, #0xdf]
006ACFE44  adrp     x8, #0x8f3b000
006ACFE48  ldr      x8, [x8, #0xd48]
006ACFE4C  ldr      x2, [x8]
006ACFE50  ldrb     w8, [x2, #0x53]
006ACFE54  tbnz     w8, #5, #0x6acfe6c
006ACFE58  mov      x0, x19
006ACFE5C  str      x20, [x0, #0x98]!
006ACFE60  mov      x1, x20
006ACFE64  bl       #0x382bcb8 ; 
006ACFE68  b        #0x6acfe7c ; 
006ACFE6C  ldr      x8, [x2, #0x60]
006ACFE70  mov      x0, x19
006ACFE74  mov      x1, x20
006ACFE78  blr      x8
006ACFE7C  mov      x0, x19
006ACFE80  mov      x1, xzr
006ACFE84  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACFE88  adrp     x21, #0x959f000
006ACFE8C  ldrb     w8, [x21, #0xe0]
006ACFE90  mov      x20, x0
006ACFE94  cbnz     w8, #0x6acfeac
006ACFE98  adrp     x0, #0x8f3b000
006ACFE9C  ldr      x0, [x0, #0xd58]
006ACFEA0  bl       #0x382bd14 ; 
006ACFEA4  mov      w8, #1
006ACFEA8  strb     w8, [x21, #0xe0]
006ACFEAC  adrp     x8, #0x8f3b000
006ACFEB0  ldr      x8, [x8, #0xd58]
006ACFEB4  ldr      x2, [x8]
006ACFEB8  ldrb     w8, [x2, #0x53]
006ACFEBC  tbnz     w8, #5, #0x6acfed4
006ACFEC0  mov      x0, x19
006ACFEC4  str      x20, [x0, #0xa0]!
006ACFEC8  mov      x1, x20
006ACFECC  bl       #0x382bcb8 ; 
006ACFED0  b        #0x6acfee4 ; 
006ACFED4  ldr      x8, [x2, #0x60]
006ACFED8  mov      x0, x19
006ACFEDC  mov      x1, x20
006ACFEE0  blr      x8
006ACFEE4  mov      x0, x19
006ACFEE8  mov      x1, xzr
006ACFEEC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ACFEF0  adrp     x21, #0x959f000
006ACFEF4  ldrb     w8, [x21, #0xe1]
006ACFEF8  mov      x20, x0
006ACFEFC  cbnz     w8, #0x6acff14
006ACFF00  adrp     x0, #0x8f3b000
006ACFF04  ldr      x0, [x0, #0xd68]
006ACFF08  bl       #0x382bd14 ; 
006ACFF0C  mov      w8, #1
006ACFF10  strb     w8, [x21, #0xe1]
006ACFF14  adrp     x8, #0x8f3b000
006ACFF18  ldr      x8, [x8, #0xd68]
006ACFF1C  ldr      x2, [x8]
006ACFF20  ldrb     w8, [x2, #0x53]
006ACFF24  tbnz     w8, #5, #0x6acff3c
006ACFF28  str      x20, [x19, #0xa8]!
006ACFF2C  mov      x0, x19
006ACFF30  mov      x1, x20
006ACFF34  bl       #0x382bcb8 ; 
006ACFF38  b        #0x6acff4c ; 
006ACFF3C  ldr      x8, [x2, #0x60]
006ACFF40  mov      x0, x19
006ACFF44  mov      x1, x20
006ACFF48  blr      x8
006ACFF4C  ldp      x20, x19, [sp, #0x10]
006ACFF50  mov      w0, #1
006ACFF54  ldp      x30, x21, [sp], #0x20
006ACFF58  ret      

