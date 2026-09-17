; LocalModels.Bean.Item_battle$$readImpl
; RVA 0x6AAC6D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AAC6D4  stp      x30, x21, [sp, #-0x20]!
006AAC6D8  stp      x20, x19, [sp, #0x10]
006AAC6DC  adrp     x20, #0x959e000
006AAC6E0  adrp     x21, #0x8f3a000
006AAC6E4  ldrb     w8, [x20, #0x767]
006AAC6E8  ldr      x21, [x21, #0x370]
006AAC6EC  mov      x19, x0
006AAC6F0  tbnz     w8, #0, #0x6aac708
006AAC6F4  adrp     x0, #0x8f3a000
006AAC6F8  ldr      x0, [x0, #0x370]
006AAC6FC  bl       #0x382bd14 ; 
006AAC700  mov      w8, #1
006AAC704  strb     w8, [x20, #0x767]
006AAC708  ldr      x1, [x21]
006AAC70C  ldrb     w8, [x1, #0x53]
006AAC710  tbnz     w8, #5, #0x6aac760
006AAC714  mov      x0, x19
006AAC718  mov      x1, xzr
006AAC71C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAC720  adrp     x21, #0x959e000
006AAC724  ldrb     w8, [x21, #0xf3c]
006AAC728  mov      w20, w0
006AAC72C  cbnz     w8, #0x6aac744
006AAC730  adrp     x0, #0x8f3a000
006AAC734  ldr      x0, [x0, #0x300]
006AAC738  bl       #0x382bd14 ; 
006AAC73C  mov      w8, #1
006AAC740  strb     w8, [x21, #0xf3c]
006AAC744  adrp     x8, #0x8f3a000
006AAC748  ldr      x8, [x8, #0x300]
006AAC74C  ldr      x2, [x8]
006AAC750  ldrb     w8, [x2, #0x53]
006AAC754  tbnz     w8, #5, #0x6aac774
006AAC758  str      w20, [x19, #0x20]
006AAC75C  b        #0x6aac784 ; 
006AAC760  ldr      x2, [x1, #0x60]
006AAC764  mov      x0, x19
006AAC768  ldp      x20, x19, [sp, #0x10]
006AAC76C  ldp      x30, x21, [sp], #0x20
006AAC770  br       x2
006AAC774  ldr      x8, [x2, #0x60]
006AAC778  mov      x0, x19
006AAC77C  mov      w1, w20
006AAC780  blr      x8
006AAC784  mov      x0, x19
006AAC788  mov      x1, xzr
006AAC78C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAC790  adrp     x21, #0x959e000
006AAC794  ldrb     w8, [x21, #0xf3d]
006AAC798  mov      w20, w0
006AAC79C  cbnz     w8, #0x6aac7b4
006AAC7A0  adrp     x0, #0x8f3a000
006AAC7A4  ldr      x0, [x0, #0x308]
006AAC7A8  bl       #0x382bd14 ; 
006AAC7AC  mov      w8, #1
006AAC7B0  strb     w8, [x21, #0xf3d]
006AAC7B4  adrp     x8, #0x8f3a000
006AAC7B8  ldr      x8, [x8, #0x308]
006AAC7BC  ldr      x2, [x8]
006AAC7C0  ldrb     w8, [x2, #0x53]
006AAC7C4  tbnz     w8, #5, #0x6aac7d0
006AAC7C8  str      w20, [x19, #0x24]
006AAC7CC  b        #0x6aac7e0 ; 
006AAC7D0  ldr      x8, [x2, #0x60]
006AAC7D4  mov      x0, x19
006AAC7D8  mov      w1, w20
006AAC7DC  blr      x8
006AAC7E0  mov      x0, x19
006AAC7E4  mov      x1, xzr
006AAC7E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAC7EC  adrp     x21, #0x959e000
006AAC7F0  ldrb     w8, [x21, #0xf3e]
006AAC7F4  mov      w20, w0
006AAC7F8  cbnz     w8, #0x6aac810
006AAC7FC  adrp     x0, #0x8f3a000
006AAC800  ldr      x0, [x0, #0x310]
006AAC804  bl       #0x382bd14 ; 
006AAC808  mov      w8, #1
006AAC80C  strb     w8, [x21, #0xf3e]
006AAC810  adrp     x8, #0x8f3a000
006AAC814  ldr      x8, [x8, #0x310]
006AAC818  ldr      x2, [x8]
006AAC81C  ldrb     w8, [x2, #0x53]
006AAC820  tbnz     w8, #5, #0x6aac82c
006AAC824  str      w20, [x19, #0x28]
006AAC828  b        #0x6aac83c ; 
006AAC82C  ldr      x8, [x2, #0x60]
006AAC830  mov      x0, x19
006AAC834  mov      w1, w20
006AAC838  blr      x8
006AAC83C  mov      x0, x19
006AAC840  mov      x1, xzr
006AAC844  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AAC848  adrp     x21, #0x959e000
006AAC84C  ldrb     w8, [x21, #0xf3f]
006AAC850  mov      x20, x0
006AAC854  cbnz     w8, #0x6aac86c
006AAC858  adrp     x0, #0x8f3a000
006AAC85C  ldr      x0, [x0, #0x318]
006AAC860  bl       #0x382bd14 ; 
006AAC864  mov      w8, #1
006AAC868  strb     w8, [x21, #0xf3f]
006AAC86C  adrp     x8, #0x8f3a000
006AAC870  ldr      x8, [x8, #0x318]
006AAC874  ldr      x2, [x8]
006AAC878  ldrb     w8, [x2, #0x53]
006AAC87C  tbnz     w8, #5, #0x6aac888
006AAC880  str      x20, [x19, #0x30]
006AAC884  b        #0x6aac898 ; 
006AAC888  ldr      x8, [x2, #0x60]
006AAC88C  mov      x0, x19
006AAC890  mov      x1, x20
006AAC894  blr      x8
006AAC898  mov      x0, x19
006AAC89C  mov      x1, xzr
006AAC8A0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AAC8A4  adrp     x21, #0x959e000
006AAC8A8  ldrb     w8, [x21, #0xf40]
006AAC8AC  mov      x20, x0
006AAC8B0  cbnz     w8, #0x6aac8c8
006AAC8B4  adrp     x0, #0x8f3a000
006AAC8B8  ldr      x0, [x0, #0x320]
006AAC8BC  bl       #0x382bd14 ; 
006AAC8C0  mov      w8, #1
006AAC8C4  strb     w8, [x21, #0xf40]
006AAC8C8  adrp     x8, #0x8f3a000
006AAC8CC  ldr      x8, [x8, #0x320]
006AAC8D0  ldr      x2, [x8]
006AAC8D4  ldrb     w8, [x2, #0x53]
006AAC8D8  tbnz     w8, #5, #0x6aac8e4
006AAC8DC  str      x20, [x19, #0x38]
006AAC8E0  b        #0x6aac8f4 ; 
006AAC8E4  ldr      x8, [x2, #0x60]
006AAC8E8  mov      x0, x19
006AAC8EC  mov      x1, x20
006AAC8F0  blr      x8
006AAC8F4  mov      x0, x19
006AAC8F8  mov      x1, xzr
006AAC8FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAC900  adrp     x21, #0x959e000
006AAC904  ldrb     w8, [x21, #0xf41]
006AAC908  mov      w20, w0
006AAC90C  cbnz     w8, #0x6aac924
006AAC910  adrp     x0, #0x8f3a000
006AAC914  ldr      x0, [x0, #0x330]
006AAC918  bl       #0x382bd14 ; 
006AAC91C  mov      w8, #1
006AAC920  strb     w8, [x21, #0xf41]
006AAC924  adrp     x8, #0x8f3a000
006AAC928  ldr      x8, [x8, #0x330]
006AAC92C  ldr      x2, [x8]
006AAC930  ldrb     w8, [x2, #0x53]
006AAC934  tbnz     w8, #5, #0x6aac940
006AAC938  str      w20, [x19, #0x40]
006AAC93C  b        #0x6aac950 ; 
006AAC940  ldr      x8, [x2, #0x60]
006AAC944  mov      x0, x19
006AAC948  mov      w1, w20
006AAC94C  blr      x8
006AAC950  mov      x0, x19
006AAC954  mov      x1, xzr
006AAC958  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAC95C  adrp     x21, #0x959e000
006AAC960  ldrb     w8, [x21, #0xf42]
006AAC964  mov      w20, w0
006AAC968  cbnz     w8, #0x6aac980
006AAC96C  adrp     x0, #0x8f3a000
006AAC970  ldr      x0, [x0, #0x338]
006AAC974  bl       #0x382bd14 ; 
006AAC978  mov      w8, #1
006AAC97C  strb     w8, [x21, #0xf42]
006AAC980  adrp     x8, #0x8f3a000
006AAC984  ldr      x8, [x8, #0x338]
006AAC988  ldr      x2, [x8]
006AAC98C  ldrb     w8, [x2, #0x53]
006AAC990  tbnz     w8, #5, #0x6aac99c
006AAC994  str      w20, [x19, #0x44]
006AAC998  b        #0x6aac9ac ; 
006AAC99C  ldr      x8, [x2, #0x60]
006AAC9A0  mov      x0, x19
006AAC9A4  mov      w1, w20
006AAC9A8  blr      x8
006AAC9AC  mov      x0, x19
006AAC9B0  mov      x1, xzr
006AAC9B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAC9B8  adrp     x21, #0x959e000
006AAC9BC  ldrb     w8, [x21, #0xf43]
006AAC9C0  mov      w20, w0
006AAC9C4  cbnz     w8, #0x6aac9dc
006AAC9C8  adrp     x0, #0x8f3a000
006AAC9CC  ldr      x0, [x0, #0x340]
006AAC9D0  bl       #0x382bd14 ; 
006AAC9D4  mov      w8, #1
006AAC9D8  strb     w8, [x21, #0xf43]
006AAC9DC  adrp     x8, #0x8f3a000
006AAC9E0  ldr      x8, [x8, #0x340]
006AAC9E4  ldr      x2, [x8]
006AAC9E8  ldrb     w8, [x2, #0x53]
006AAC9EC  tbnz     w8, #5, #0x6aac9f8
006AAC9F0  str      w20, [x19, #0x48]
006AAC9F4  b        #0x6aaca08 ; 
006AAC9F8  ldr      x8, [x2, #0x60]
006AAC9FC  mov      x0, x19
006AACA00  mov      w1, w20
006AACA04  blr      x8
006AACA08  mov      x0, x19
006AACA0C  mov      x1, xzr
006AACA10  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AACA14  adrp     x21, #0x959e000
006AACA18  ldrb     w8, [x21, #0xf44]
006AACA1C  mov      x20, x0
006AACA20  cbnz     w8, #0x6aaca38
006AACA24  adrp     x0, #0x8f3a000
006AACA28  ldr      x0, [x0, #0x348]
006AACA2C  bl       #0x382bd14 ; 
006AACA30  mov      w8, #1
006AACA34  strb     w8, [x21, #0xf44]
006AACA38  adrp     x8, #0x8f3a000
006AACA3C  ldr      x8, [x8, #0x348]
006AACA40  ldr      x2, [x8]
006AACA44  ldrb     w8, [x2, #0x53]
006AACA48  tbnz     w8, #5, #0x6aaca54
006AACA4C  str      x20, [x19, #0x50]
006AACA50  b        #0x6aaca64 ; 
006AACA54  ldr      x8, [x2, #0x60]
006AACA58  mov      x0, x19
006AACA5C  mov      x1, x20
006AACA60  blr      x8
006AACA64  mov      x0, x19
006AACA68  mov      x1, xzr
006AACA6C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AACA70  adrp     x21, #0x959e000
006AACA74  ldrb     w8, [x21, #0xf45]
006AACA78  mov      x20, x0
006AACA7C  cbnz     w8, #0x6aaca94
006AACA80  adrp     x0, #0x8f3a000
006AACA84  ldr      x0, [x0, #0x350]
006AACA88  bl       #0x382bd14 ; 
006AACA8C  mov      w8, #1
006AACA90  strb     w8, [x21, #0xf45]
006AACA94  adrp     x8, #0x8f3a000
006AACA98  ldr      x8, [x8, #0x350]
006AACA9C  ldr      x2, [x8]
006AACAA0  ldrb     w8, [x2, #0x53]
006AACAA4  tbnz     w8, #5, #0x6aacab0
006AACAA8  str      x20, [x19, #0x58]
006AACAAC  b        #0x6aacac0 ; 
006AACAB0  ldr      x8, [x2, #0x60]
006AACAB4  mov      x0, x19
006AACAB8  mov      x1, x20
006AACABC  blr      x8
006AACAC0  mov      x0, x19
006AACAC4  mov      x1, xzr
006AACAC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AACACC  adrp     x21, #0x959e000
006AACAD0  ldrb     w8, [x21, #0xf46]
006AACAD4  mov      w20, w0
006AACAD8  cbnz     w8, #0x6aacaf0
006AACADC  adrp     x0, #0x8f3a000
006AACAE0  ldr      x0, [x0, #0x358]
006AACAE4  bl       #0x382bd14 ; 
006AACAE8  mov      w8, #1
006AACAEC  strb     w8, [x21, #0xf46]
006AACAF0  adrp     x8, #0x8f3a000
006AACAF4  ldr      x8, [x8, #0x358]
006AACAF8  ldr      x2, [x8]
006AACAFC  ldrb     w8, [x2, #0x53]
006AACB00  tbnz     w8, #5, #0x6aacb0c
006AACB04  str      w20, [x19, #0x60]
006AACB08  b        #0x6aacb1c ; 
006AACB0C  ldr      x8, [x2, #0x60]
006AACB10  mov      x0, x19
006AACB14  mov      w1, w20
006AACB18  blr      x8
006AACB1C  mov      x0, x19
006AACB20  mov      x1, xzr
006AACB24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AACB28  adrp     x21, #0x959e000
006AACB2C  ldrb     w8, [x21, #0xf47]
006AACB30  mov      w20, w0
006AACB34  cbnz     w8, #0x6aacb4c
006AACB38  adrp     x0, #0x8f3a000
006AACB3C  ldr      x0, [x0, #0x360]
006AACB40  bl       #0x382bd14 ; 
006AACB44  mov      w8, #1
006AACB48  strb     w8, [x21, #0xf47]
006AACB4C  adrp     x8, #0x8f3a000
006AACB50  ldr      x8, [x8, #0x360]
006AACB54  ldr      x2, [x8]
006AACB58  ldrb     w8, [x2, #0x53]
006AACB5C  tbnz     w8, #5, #0x6aacb68
006AACB60  str      w20, [x19, #0x64]
006AACB64  b        #0x6aacb78 ; 
006AACB68  ldr      x8, [x2, #0x60]
006AACB6C  mov      x0, x19
006AACB70  mov      w1, w20
006AACB74  blr      x8
006AACB78  mov      x0, x19
006AACB7C  mov      x1, xzr
006AACB80  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AACB84  adrp     x21, #0x959e000
006AACB88  ldrb     w8, [x21, #0xf48]
006AACB8C  mov      x20, x0
006AACB90  cbnz     w8, #0x6aacba8
006AACB94  adrp     x0, #0x8f3a000
006AACB98  ldr      x0, [x0, #0x368]
006AACB9C  bl       #0x382bd14 ; 
006AACBA0  mov      w8, #1
006AACBA4  strb     w8, [x21, #0xf48]
006AACBA8  adrp     x8, #0x8f3a000
006AACBAC  ldr      x8, [x8, #0x368]
006AACBB0  ldr      x2, [x8]
006AACBB4  ldrb     w8, [x2, #0x53]
006AACBB8  tbnz     w8, #5, #0x6aacbc4
006AACBBC  str      x20, [x19, #0x68]
006AACBC0  b        #0x6aacbd4 ; 
006AACBC4  ldr      x8, [x2, #0x60]
006AACBC8  mov      x0, x19
006AACBCC  mov      x1, x20
006AACBD0  blr      x8
006AACBD4  ldp      x20, x19, [sp, #0x10]
006AACBD8  mov      w0, #1
006AACBDC  ldp      x30, x21, [sp], #0x20
006AACBE0  ret      

