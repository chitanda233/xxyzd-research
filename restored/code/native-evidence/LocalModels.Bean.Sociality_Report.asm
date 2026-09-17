; LocalModels.Bean.Sociality_Report$$readImpl
; RVA 0x6B0E918; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0E918  stp      x30, x21, [sp, #-0x20]!
006B0E91C  stp      x20, x19, [sp, #0x10]
006B0E920  adrp     x20, #0x959f000
006B0E924  adrp     x21, #0x8f3e000
006B0E928  ldrb     w8, [x20, #0x507]
006B0E92C  ldr      x21, [x21, #0xaf8]
006B0E930  mov      x19, x0
006B0E934  tbnz     w8, #0, #0x6b0e94c
006B0E938  adrp     x0, #0x8f3e000
006B0E93C  ldr      x0, [x0, #0xaf8]
006B0E940  bl       #0x382bd14 ; 
006B0E944  mov      w8, #1
006B0E948  strb     w8, [x20, #0x507]
006B0E94C  ldr      x1, [x21]
006B0E950  ldrb     w8, [x1, #0x53]
006B0E954  tbnz     w8, #5, #0x6b0e9a4
006B0E958  mov      x0, x19
006B0E95C  mov      x1, xzr
006B0E960  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0E964  adrp     x21, #0x959f000
006B0E968  ldrb     w8, [x21, #0x98f]
006B0E96C  mov      w20, w0
006B0E970  cbnz     w8, #0x6b0e988
006B0E974  adrp     x0, #0x8f3e000
006B0E978  ldr      x0, [x0, #0xa70]
006B0E97C  bl       #0x382bd14 ; 
006B0E980  mov      w8, #1
006B0E984  strb     w8, [x21, #0x98f]
006B0E988  adrp     x8, #0x8f3e000
006B0E98C  ldr      x8, [x8, #0xa70]
006B0E990  ldr      x2, [x8]
006B0E994  ldrb     w8, [x2, #0x53]
006B0E998  tbnz     w8, #5, #0x6b0e9b8
006B0E99C  str      w20, [x19, #0x20]
006B0E9A0  b        #0x6b0e9c8 ; 
006B0E9A4  ldr      x2, [x1, #0x60]
006B0E9A8  mov      x0, x19
006B0E9AC  ldp      x20, x19, [sp, #0x10]
006B0E9B0  ldp      x30, x21, [sp], #0x20
006B0E9B4  br       x2
006B0E9B8  ldr      x8, [x2, #0x60]
006B0E9BC  mov      x0, x19
006B0E9C0  mov      w1, w20
006B0E9C4  blr      x8
006B0E9C8  mov      x0, x19
006B0E9CC  mov      x1, xzr
006B0E9D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0E9D4  adrp     x21, #0x959f000
006B0E9D8  ldrb     w8, [x21, #0x990]
006B0E9DC  mov      w20, w0
006B0E9E0  cbnz     w8, #0x6b0e9f8
006B0E9E4  adrp     x0, #0x8f3e000
006B0E9E8  ldr      x0, [x0, #0xa80]
006B0E9EC  bl       #0x382bd14 ; 
006B0E9F0  mov      w8, #1
006B0E9F4  strb     w8, [x21, #0x990]
006B0E9F8  adrp     x8, #0x8f3e000
006B0E9FC  ldr      x8, [x8, #0xa80]
006B0EA00  ldr      x2, [x8]
006B0EA04  ldrb     w8, [x2, #0x53]
006B0EA08  tbnz     w8, #5, #0x6b0ea14
006B0EA0C  str      w20, [x19, #0x24]
006B0EA10  b        #0x6b0ea24 ; 
006B0EA14  ldr      x8, [x2, #0x60]
006B0EA18  mov      x0, x19
006B0EA1C  mov      w1, w20
006B0EA20  blr      x8
006B0EA24  mov      x0, x19
006B0EA28  mov      x1, xzr
006B0EA2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0EA30  adrp     x21, #0x959f000
006B0EA34  ldrb     w8, [x21, #0x991]
006B0EA38  mov      w20, w0
006B0EA3C  cbnz     w8, #0x6b0ea54
006B0EA40  adrp     x0, #0x8f3e000
006B0EA44  ldr      x0, [x0, #0xa90]
006B0EA48  bl       #0x382bd14 ; 
006B0EA4C  mov      w8, #1
006B0EA50  strb     w8, [x21, #0x991]
006B0EA54  adrp     x8, #0x8f3e000
006B0EA58  ldr      x8, [x8, #0xa90]
006B0EA5C  ldr      x2, [x8]
006B0EA60  ldrb     w8, [x2, #0x53]
006B0EA64  tbnz     w8, #5, #0x6b0ea70
006B0EA68  str      w20, [x19, #0x28]
006B0EA6C  b        #0x6b0ea80 ; 
006B0EA70  ldr      x8, [x2, #0x60]
006B0EA74  mov      x0, x19
006B0EA78  mov      w1, w20
006B0EA7C  blr      x8
006B0EA80  mov      x0, x19
006B0EA84  mov      x1, xzr
006B0EA88  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0EA8C  adrp     x21, #0x959f000
006B0EA90  ldrb     w8, [x21, #0x992]
006B0EA94  mov      x20, x0
006B0EA98  cbnz     w8, #0x6b0eab0
006B0EA9C  adrp     x0, #0x8f3e000
006B0EAA0  ldr      x0, [x0, #0xaa0]
006B0EAA4  bl       #0x382bd14 ; 
006B0EAA8  mov      w8, #1
006B0EAAC  strb     w8, [x21, #0x992]
006B0EAB0  adrp     x8, #0x8f3e000
006B0EAB4  ldr      x8, [x8, #0xaa0]
006B0EAB8  ldr      x2, [x8]
006B0EABC  ldrb     w8, [x2, #0x53]
006B0EAC0  tbnz     w8, #5, #0x6b0ead8
006B0EAC4  mov      x0, x19
006B0EAC8  str      x20, [x0, #0x30]!
006B0EACC  mov      x1, x20
006B0EAD0  bl       #0x382bcb8 ; 
006B0EAD4  b        #0x6b0eae8 ; 
006B0EAD8  ldr      x8, [x2, #0x60]
006B0EADC  mov      x0, x19
006B0EAE0  mov      x1, x20
006B0EAE4  blr      x8
006B0EAE8  mov      x0, x19
006B0EAEC  mov      x1, xzr
006B0EAF0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0EAF4  adrp     x21, #0x959f000
006B0EAF8  ldrb     w8, [x21, #0x993]
006B0EAFC  mov      x20, x0
006B0EB00  cbnz     w8, #0x6b0eb18
006B0EB04  adrp     x0, #0x8f3e000
006B0EB08  ldr      x0, [x0, #0xab0]
006B0EB0C  bl       #0x382bd14 ; 
006B0EB10  mov      w8, #1
006B0EB14  strb     w8, [x21, #0x993]
006B0EB18  adrp     x8, #0x8f3e000
006B0EB1C  ldr      x8, [x8, #0xab0]
006B0EB20  ldr      x2, [x8]
006B0EB24  ldrb     w8, [x2, #0x53]
006B0EB28  tbnz     w8, #5, #0x6b0eb40
006B0EB2C  mov      x0, x19
006B0EB30  str      x20, [x0, #0x38]!
006B0EB34  mov      x1, x20
006B0EB38  bl       #0x382bcb8 ; 
006B0EB3C  b        #0x6b0eb50 ; 
006B0EB40  ldr      x8, [x2, #0x60]
006B0EB44  mov      x0, x19
006B0EB48  mov      x1, x20
006B0EB4C  blr      x8
006B0EB50  mov      x0, x19
006B0EB54  mov      x1, xzr
006B0EB58  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0EB5C  adrp     x21, #0x959f000
006B0EB60  ldrb     w8, [x21, #0x994]
006B0EB64  mov      x20, x0
006B0EB68  cbnz     w8, #0x6b0eb80
006B0EB6C  adrp     x0, #0x8f3e000
006B0EB70  ldr      x0, [x0, #0xac0]
006B0EB74  bl       #0x382bd14 ; 
006B0EB78  mov      w8, #1
006B0EB7C  strb     w8, [x21, #0x994]
006B0EB80  adrp     x8, #0x8f3e000
006B0EB84  ldr      x8, [x8, #0xac0]
006B0EB88  ldr      x2, [x8]
006B0EB8C  ldrb     w8, [x2, #0x53]
006B0EB90  tbnz     w8, #5, #0x6b0eba8
006B0EB94  mov      x0, x19
006B0EB98  str      x20, [x0, #0x40]!
006B0EB9C  mov      x1, x20
006B0EBA0  bl       #0x382bcb8 ; 
006B0EBA4  b        #0x6b0ebb8 ; 
006B0EBA8  ldr      x8, [x2, #0x60]
006B0EBAC  mov      x0, x19
006B0EBB0  mov      x1, x20
006B0EBB4  blr      x8
006B0EBB8  mov      x0, x19
006B0EBBC  mov      x1, xzr
006B0EBC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0EBC4  adrp     x21, #0x959f000
006B0EBC8  ldrb     w8, [x21, #0x995]
006B0EBCC  mov      w20, w0
006B0EBD0  cbnz     w8, #0x6b0ebe8
006B0EBD4  adrp     x0, #0x8f3e000
006B0EBD8  ldr      x0, [x0, #0xad0]
006B0EBDC  bl       #0x382bd14 ; 
006B0EBE0  mov      w8, #1
006B0EBE4  strb     w8, [x21, #0x995]
006B0EBE8  adrp     x8, #0x8f3e000
006B0EBEC  ldr      x8, [x8, #0xad0]
006B0EBF0  ldr      x2, [x8]
006B0EBF4  ldrb     w8, [x2, #0x53]
006B0EBF8  tbnz     w8, #5, #0x6b0ec04
006B0EBFC  str      w20, [x19, #0x48]
006B0EC00  b        #0x6b0ec14 ; 
006B0EC04  ldr      x8, [x2, #0x60]
006B0EC08  mov      x0, x19
006B0EC0C  mov      w1, w20
006B0EC10  blr      x8
006B0EC14  mov      x0, x19
006B0EC18  mov      x1, xzr
006B0EC1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0EC20  adrp     x21, #0x959f000
006B0EC24  ldrb     w8, [x21, #0x996]
006B0EC28  mov      w20, w0
006B0EC2C  cbnz     w8, #0x6b0ec44
006B0EC30  adrp     x0, #0x8f3e000
006B0EC34  ldr      x0, [x0, #0xae0]
006B0EC38  bl       #0x382bd14 ; 
006B0EC3C  mov      w8, #1
006B0EC40  strb     w8, [x21, #0x996]
006B0EC44  adrp     x8, #0x8f3e000
006B0EC48  ldr      x8, [x8, #0xae0]
006B0EC4C  ldr      x2, [x8]
006B0EC50  ldrb     w8, [x2, #0x53]
006B0EC54  tbnz     w8, #5, #0x6b0ec60
006B0EC58  str      w20, [x19, #0x4c]
006B0EC5C  b        #0x6b0ec70 ; 
006B0EC60  ldr      x8, [x2, #0x60]
006B0EC64  mov      x0, x19
006B0EC68  mov      w1, w20
006B0EC6C  blr      x8
006B0EC70  mov      x0, x19
006B0EC74  mov      x1, xzr
006B0EC78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0EC7C  adrp     x21, #0x959f000
006B0EC80  ldrb     w8, [x21, #0x997]
006B0EC84  mov      w20, w0
006B0EC88  cbnz     w8, #0x6b0eca0
006B0EC8C  adrp     x0, #0x8f3e000
006B0EC90  ldr      x0, [x0, #0xaf0]
006B0EC94  bl       #0x382bd14 ; 
006B0EC98  mov      w8, #1
006B0EC9C  strb     w8, [x21, #0x997]
006B0ECA0  adrp     x8, #0x8f3e000
006B0ECA4  ldr      x8, [x8, #0xaf0]
006B0ECA8  ldr      x2, [x8]
006B0ECAC  ldrb     w8, [x2, #0x53]
006B0ECB0  tbnz     w8, #5, #0x6b0ecbc
006B0ECB4  str      w20, [x19, #0x50]
006B0ECB8  b        #0x6b0eccc ; 
006B0ECBC  ldr      x8, [x2, #0x60]
006B0ECC0  mov      x0, x19
006B0ECC4  mov      w1, w20
006B0ECC8  blr      x8
006B0ECCC  ldp      x20, x19, [sp, #0x10]
006B0ECD0  mov      w0, #1
006B0ECD4  ldp      x30, x21, [sp], #0x20
006B0ECD8  ret      

