; LocalModels.Bean.Calendar_CalendarConfig$$readImpl
; RVA 0x688EB7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00688EB7C  str      d8, [sp, #-0x30]!
00688EB80  stp      x30, x21, [sp, #0x10]
00688EB84  stp      x20, x19, [sp, #0x20]
00688EB88  adrp     x20, #0x959b000
00688EB8C  adrp     x21, #0x8f25000
00688EB90  ldrb     w8, [x20, #0xcf8]
00688EB94  ldr      x21, [x21, #0x5c0]
00688EB98  mov      x19, x0
00688EB9C  tbnz     w8, #0, #0x688ebb4
00688EBA0  adrp     x0, #0x8f25000
00688EBA4  ldr      x0, [x0, #0x5c0]
00688EBA8  bl       #0x382bd14 ; 
00688EBAC  mov      w8, #1
00688EBB0  strb     w8, [x20, #0xcf8]
00688EBB4  ldr      x1, [x21]
00688EBB8  ldrb     w8, [x1, #0x53]
00688EBBC  tbnz     w8, #5, #0x688ec18
00688EBC0  mov      x0, x19
00688EBC4  mov      x1, xzr
00688EBC8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688EBCC  adrp     x21, #0x959c000
00688EBD0  ldrb     w8, [x21, #0x44e]
00688EBD4  mov      x20, x0
00688EBD8  cbnz     w8, #0x688ebf0
00688EBDC  adrp     x0, #0x8f25000
00688EBE0  ldr      x0, [x0, #0x548]
00688EBE4  bl       #0x382bd14 ; 
00688EBE8  mov      w8, #1
00688EBEC  strb     w8, [x21, #0x44e]
00688EBF0  adrp     x8, #0x8f25000
00688EBF4  ldr      x8, [x8, #0x548]
00688EBF8  ldr      x2, [x8]
00688EBFC  ldrb     w8, [x2, #0x53]
00688EC00  tbnz     w8, #5, #0x688ec30
00688EC04  mov      x0, x19
00688EC08  str      x20, [x0, #0x20]!
00688EC0C  mov      x1, x20
00688EC10  bl       #0x382bcb8 ; 
00688EC14  b        #0x688ec40 ; 
00688EC18  ldr      x2, [x1, #0x60]
00688EC1C  mov      x0, x19
00688EC20  ldp      x20, x19, [sp, #0x20]
00688EC24  ldp      x30, x21, [sp, #0x10]
00688EC28  ldr      d8, [sp], #0x30
00688EC2C  br       x2
00688EC30  ldr      x8, [x2, #0x60]
00688EC34  mov      x0, x19
00688EC38  mov      x1, x20
00688EC3C  blr      x8
00688EC40  mov      x0, x19
00688EC44  mov      x1, xzr
00688EC48  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688EC4C  adrp     x21, #0x959c000
00688EC50  ldrb     w8, [x21, #0x44f]
00688EC54  mov      x20, x0
00688EC58  cbnz     w8, #0x688ec70
00688EC5C  adrp     x0, #0x8f25000
00688EC60  ldr      x0, [x0, #0x558]
00688EC64  bl       #0x382bd14 ; 
00688EC68  mov      w8, #1
00688EC6C  strb     w8, [x21, #0x44f]
00688EC70  adrp     x8, #0x8f25000
00688EC74  ldr      x8, [x8, #0x558]
00688EC78  ldr      x2, [x8]
00688EC7C  ldrb     w8, [x2, #0x53]
00688EC80  tbnz     w8, #5, #0x688ec98
00688EC84  mov      x0, x19
00688EC88  str      x20, [x0, #0x28]!
00688EC8C  mov      x1, x20
00688EC90  bl       #0x382bcb8 ; 
00688EC94  b        #0x688eca8 ; 
00688EC98  ldr      x8, [x2, #0x60]
00688EC9C  mov      x0, x19
00688ECA0  mov      x1, x20
00688ECA4  blr      x8
00688ECA8  mov      x0, x19
00688ECAC  mov      x1, xzr
00688ECB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688ECB4  adrp     x21, #0x959c000
00688ECB8  ldrb     w8, [x21, #0x450]
00688ECBC  mov      w20, w0
00688ECC0  cbnz     w8, #0x688ecd8
00688ECC4  adrp     x0, #0x8f25000
00688ECC8  ldr      x0, [x0, #0x568]
00688ECCC  bl       #0x382bd14 ; 
00688ECD0  mov      w8, #1
00688ECD4  strb     w8, [x21, #0x450]
00688ECD8  adrp     x8, #0x8f25000
00688ECDC  ldr      x8, [x8, #0x568]
00688ECE0  ldr      x2, [x8]
00688ECE4  ldrb     w8, [x2, #0x53]
00688ECE8  tbnz     w8, #5, #0x688ecf4
00688ECEC  str      w20, [x19, #0x30]
00688ECF0  b        #0x688ed04 ; 
00688ECF4  ldr      x8, [x2, #0x60]
00688ECF8  mov      x0, x19
00688ECFC  mov      w1, w20
00688ED00  blr      x8
00688ED04  mov      x0, x19
00688ED08  mov      x1, xzr
00688ED0C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688ED10  adrp     x21, #0x959c000
00688ED14  ldrb     w8, [x21, #0x451]
00688ED18  mov      x20, x0
00688ED1C  cbnz     w8, #0x688ed34
00688ED20  adrp     x0, #0x8f25000
00688ED24  ldr      x0, [x0, #0x578]
00688ED28  bl       #0x382bd14 ; 
00688ED2C  mov      w8, #1
00688ED30  strb     w8, [x21, #0x451]
00688ED34  adrp     x8, #0x8f25000
00688ED38  ldr      x8, [x8, #0x578]
00688ED3C  ldr      x2, [x8]
00688ED40  ldrb     w8, [x2, #0x53]
00688ED44  tbnz     w8, #5, #0x688ed5c
00688ED48  mov      x0, x19
00688ED4C  str      x20, [x0, #0x38]!
00688ED50  mov      x1, x20
00688ED54  bl       #0x382bcb8 ; 
00688ED58  b        #0x688ed6c ; 
00688ED5C  ldr      x8, [x2, #0x60]
00688ED60  mov      x0, x19
00688ED64  mov      x1, x20
00688ED68  blr      x8
00688ED6C  mov      x0, x19
00688ED70  mov      x1, xzr
00688ED74  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688ED78  adrp     x21, #0x959c000
00688ED7C  ldrb     w8, [x21, #0x452]
00688ED80  mov      x20, x0
00688ED84  cbnz     w8, #0x688ed9c
00688ED88  adrp     x0, #0x8f25000
00688ED8C  ldr      x0, [x0, #0x588]
00688ED90  bl       #0x382bd14 ; 
00688ED94  mov      w8, #1
00688ED98  strb     w8, [x21, #0x452]
00688ED9C  adrp     x8, #0x8f25000
00688EDA0  ldr      x8, [x8, #0x588]
00688EDA4  ldr      x2, [x8]
00688EDA8  ldrb     w8, [x2, #0x53]
00688EDAC  tbnz     w8, #5, #0x688edc4
00688EDB0  mov      x0, x19
00688EDB4  str      x20, [x0, #0x40]!
00688EDB8  mov      x1, x20
00688EDBC  bl       #0x382bcb8 ; 
00688EDC0  b        #0x688edd4 ; 
00688EDC4  ldr      x8, [x2, #0x60]
00688EDC8  mov      x0, x19
00688EDCC  mov      x1, x20
00688EDD0  blr      x8
00688EDD4  mov      x0, x19
00688EDD8  mov      x1, xzr
00688EDDC  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
00688EDE0  adrp     x20, #0x959c000
00688EDE4  ldrb     w8, [x20, #0x453]
00688EDE8  mov      v8.16b, v0.16b
00688EDEC  cbnz     w8, #0x688ee04
00688EDF0  adrp     x0, #0x8f25000
00688EDF4  ldr      x0, [x0, #0x598]
00688EDF8  bl       #0x382bd14 ; 
00688EDFC  mov      w8, #1
00688EE00  strb     w8, [x20, #0x453]
00688EE04  adrp     x8, #0x8f25000
00688EE08  ldr      x8, [x8, #0x598]
00688EE0C  ldr      x1, [x8]
00688EE10  ldrb     w8, [x1, #0x53]
00688EE14  tbnz     w8, #5, #0x688ee20
00688EE18  str      s8, [x19, #0x48]
00688EE1C  b        #0x688ee30 ; 
00688EE20  ldr      x8, [x1, #0x60]
00688EE24  mov      x0, x19
00688EE28  mov      v0.16b, v8.16b
00688EE2C  blr      x8
00688EE30  mov      x0, x19
00688EE34  mov      x1, xzr
00688EE38  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
00688EE3C  adrp     x21, #0x959c000
00688EE40  ldrb     w8, [x21, #0x454]
00688EE44  mov      x20, x0
00688EE48  cbnz     w8, #0x688ee60
00688EE4C  adrp     x0, #0x8f25000
00688EE50  ldr      x0, [x0, #0x5a8]
00688EE54  bl       #0x382bd14 ; 
00688EE58  mov      w8, #1
00688EE5C  strb     w8, [x21, #0x454]
00688EE60  adrp     x8, #0x8f25000
00688EE64  ldr      x8, [x8, #0x5a8]
00688EE68  ldr      x2, [x8]
00688EE6C  ldrb     w8, [x2, #0x53]
00688EE70  tbnz     w8, #5, #0x688ee88
00688EE74  mov      x0, x19
00688EE78  str      x20, [x0, #0x50]!
00688EE7C  mov      x1, x20
00688EE80  bl       #0x382bcb8 ; 
00688EE84  b        #0x688ee98 ; 
00688EE88  ldr      x8, [x2, #0x60]
00688EE8C  mov      x0, x19
00688EE90  mov      x1, x20
00688EE94  blr      x8
00688EE98  mov      x0, x19
00688EE9C  mov      x1, xzr
00688EEA0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
00688EEA4  adrp     x21, #0x959c000
00688EEA8  ldrb     w8, [x21, #0x455]
00688EEAC  mov      x20, x0
00688EEB0  cbnz     w8, #0x688eec8
00688EEB4  adrp     x0, #0x8f25000
00688EEB8  ldr      x0, [x0, #0x5b8]
00688EEBC  bl       #0x382bd14 ; 
00688EEC0  mov      w8, #1
00688EEC4  strb     w8, [x21, #0x455]
00688EEC8  adrp     x8, #0x8f25000
00688EECC  ldr      x8, [x8, #0x5b8]
00688EED0  ldr      x2, [x8]
00688EED4  ldrb     w8, [x2, #0x53]
00688EED8  tbnz     w8, #5, #0x688eef0
00688EEDC  str      x20, [x19, #0x58]!
00688EEE0  mov      x0, x19
00688EEE4  mov      x1, x20
00688EEE8  bl       #0x382bcb8 ; 
00688EEEC  b        #0x688ef00 ; 
00688EEF0  ldr      x8, [x2, #0x60]
00688EEF4  mov      x0, x19
00688EEF8  mov      x1, x20
00688EEFC  blr      x8
00688EF00  ldp      x20, x19, [sp, #0x20]
00688EF04  ldp      x30, x21, [sp, #0x10]
00688EF08  mov      w0, #1
00688EF0C  ldr      d8, [sp], #0x30
00688EF10  ret      

