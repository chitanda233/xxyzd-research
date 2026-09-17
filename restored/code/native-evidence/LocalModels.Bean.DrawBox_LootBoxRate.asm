; LocalModels.Bean.DrawBox_LootBoxRate$$readImpl
; RVA 0x6A5CD40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5CD40  stp      x30, x21, [sp, #-0x20]!
006A5CD44  stp      x20, x19, [sp, #0x10]
006A5CD48  adrp     x20, #0x959d000
006A5CD4C  adrp     x21, #0x8f36000
006A5CD50  ldrb     w8, [x20, #0xb99]
006A5CD54  ldr      x21, [x21, #0x760]
006A5CD58  mov      x19, x0
006A5CD5C  tbnz     w8, #0, #0x6a5cd74
006A5CD60  adrp     x0, #0x8f36000
006A5CD64  ldr      x0, [x0, #0x760]
006A5CD68  bl       #0x382bd14 ; 
006A5CD6C  mov      w8, #1
006A5CD70  strb     w8, [x20, #0xb99]
006A5CD74  ldr      x1, [x21]
006A5CD78  ldrb     w8, [x1, #0x53]
006A5CD7C  tbnz     w8, #5, #0x6a5cdcc
006A5CD80  mov      x0, x19
006A5CD84  mov      x1, xzr
006A5CD88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5CD8C  adrp     x21, #0x959e000
006A5CD90  ldrb     w8, [x21, #0x373]
006A5CD94  mov      w20, w0
006A5CD98  cbnz     w8, #0x6a5cdb0
006A5CD9C  adrp     x0, #0x8f36000
006A5CDA0  ldr      x0, [x0, #0x708]
006A5CDA4  bl       #0x382bd14 ; 
006A5CDA8  mov      w8, #1
006A5CDAC  strb     w8, [x21, #0x373]
006A5CDB0  adrp     x8, #0x8f36000
006A5CDB4  ldr      x8, [x8, #0x708]
006A5CDB8  ldr      x2, [x8]
006A5CDBC  ldrb     w8, [x2, #0x53]
006A5CDC0  tbnz     w8, #5, #0x6a5cde0
006A5CDC4  str      w20, [x19, #0x20]
006A5CDC8  b        #0x6a5cdf0 ; 
006A5CDCC  ldr      x2, [x1, #0x60]
006A5CDD0  mov      x0, x19
006A5CDD4  ldp      x20, x19, [sp, #0x10]
006A5CDD8  ldp      x30, x21, [sp], #0x20
006A5CDDC  br       x2
006A5CDE0  ldr      x8, [x2, #0x60]
006A5CDE4  mov      x0, x19
006A5CDE8  mov      w1, w20
006A5CDEC  blr      x8
006A5CDF0  mov      x0, x19
006A5CDF4  mov      x1, xzr
006A5CDF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5CDFC  adrp     x21, #0x959e000
006A5CE00  ldrb     w8, [x21, #0x374]
006A5CE04  mov      w20, w0
006A5CE08  cbnz     w8, #0x6a5ce20
006A5CE0C  adrp     x0, #0x8f36000
006A5CE10  ldr      x0, [x0, #0x718]
006A5CE14  bl       #0x382bd14 ; 
006A5CE18  mov      w8, #1
006A5CE1C  strb     w8, [x21, #0x374]
006A5CE20  adrp     x8, #0x8f36000
006A5CE24  ldr      x8, [x8, #0x718]
006A5CE28  ldr      x2, [x8]
006A5CE2C  ldrb     w8, [x2, #0x53]
006A5CE30  tbnz     w8, #5, #0x6a5ce3c
006A5CE34  str      w20, [x19, #0x24]
006A5CE38  b        #0x6a5ce4c ; 
006A5CE3C  ldr      x8, [x2, #0x60]
006A5CE40  mov      x0, x19
006A5CE44  mov      w1, w20
006A5CE48  blr      x8
006A5CE4C  mov      x0, x19
006A5CE50  mov      x1, xzr
006A5CE54  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5CE58  adrp     x21, #0x959e000
006A5CE5C  ldrb     w8, [x21, #0x375]
006A5CE60  mov      x20, x0
006A5CE64  cbnz     w8, #0x6a5ce7c
006A5CE68  adrp     x0, #0x8f36000
006A5CE6C  ldr      x0, [x0, #0x728]
006A5CE70  bl       #0x382bd14 ; 
006A5CE74  mov      w8, #1
006A5CE78  strb     w8, [x21, #0x375]
006A5CE7C  adrp     x8, #0x8f36000
006A5CE80  ldr      x8, [x8, #0x728]
006A5CE84  ldr      x2, [x8]
006A5CE88  ldrb     w8, [x2, #0x53]
006A5CE8C  tbnz     w8, #5, #0x6a5cea4
006A5CE90  mov      x0, x19
006A5CE94  str      x20, [x0, #0x28]!
006A5CE98  mov      x1, x20
006A5CE9C  bl       #0x382bcb8 ; 
006A5CEA0  b        #0x6a5ceb4 ; 
006A5CEA4  ldr      x8, [x2, #0x60]
006A5CEA8  mov      x0, x19
006A5CEAC  mov      x1, x20
006A5CEB0  blr      x8
006A5CEB4  mov      x0, x19
006A5CEB8  mov      x1, xzr
006A5CEBC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5CEC0  adrp     x21, #0x959e000
006A5CEC4  ldrb     w8, [x21, #0x376]
006A5CEC8  mov      w20, w0
006A5CECC  cbnz     w8, #0x6a5cee4
006A5CED0  adrp     x0, #0x8f36000
006A5CED4  ldr      x0, [x0, #0x738]
006A5CED8  bl       #0x382bd14 ; 
006A5CEDC  mov      w8, #1
006A5CEE0  strb     w8, [x21, #0x376]
006A5CEE4  adrp     x8, #0x8f36000
006A5CEE8  ldr      x8, [x8, #0x738]
006A5CEEC  ldr      x2, [x8]
006A5CEF0  ldrb     w8, [x2, #0x53]
006A5CEF4  tbnz     w8, #5, #0x6a5cf00
006A5CEF8  str      w20, [x19, #0x30]
006A5CEFC  b        #0x6a5cf10 ; 
006A5CF00  ldr      x8, [x2, #0x60]
006A5CF04  mov      x0, x19
006A5CF08  mov      w1, w20
006A5CF0C  blr      x8
006A5CF10  mov      x0, x19
006A5CF14  mov      x1, xzr
006A5CF18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5CF1C  adrp     x21, #0x959e000
006A5CF20  ldrb     w8, [x21, #0x377]
006A5CF24  mov      w20, w0
006A5CF28  cbnz     w8, #0x6a5cf40
006A5CF2C  adrp     x0, #0x8f36000
006A5CF30  ldr      x0, [x0, #0x748]
006A5CF34  bl       #0x382bd14 ; 
006A5CF38  mov      w8, #1
006A5CF3C  strb     w8, [x21, #0x377]
006A5CF40  adrp     x8, #0x8f36000
006A5CF44  ldr      x8, [x8, #0x748]
006A5CF48  ldr      x2, [x8]
006A5CF4C  ldrb     w8, [x2, #0x53]
006A5CF50  tbnz     w8, #5, #0x6a5cf5c
006A5CF54  str      w20, [x19, #0x34]
006A5CF58  b        #0x6a5cf6c ; 
006A5CF5C  ldr      x8, [x2, #0x60]
006A5CF60  mov      x0, x19
006A5CF64  mov      w1, w20
006A5CF68  blr      x8
006A5CF6C  mov      x0, x19
006A5CF70  mov      x1, xzr
006A5CF74  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A5CF78  adrp     x21, #0x959e000
006A5CF7C  ldrb     w8, [x21, #0x378]
006A5CF80  mov      x20, x0
006A5CF84  cbnz     w8, #0x6a5cf9c
006A5CF88  adrp     x0, #0x8f36000
006A5CF8C  ldr      x0, [x0, #0x758]
006A5CF90  bl       #0x382bd14 ; 
006A5CF94  mov      w8, #1
006A5CF98  strb     w8, [x21, #0x378]
006A5CF9C  adrp     x8, #0x8f36000
006A5CFA0  ldr      x8, [x8, #0x758]
006A5CFA4  ldr      x2, [x8]
006A5CFA8  ldrb     w8, [x2, #0x53]
006A5CFAC  tbnz     w8, #5, #0x6a5cfc4
006A5CFB0  str      x20, [x19, #0x38]!
006A5CFB4  mov      x0, x19
006A5CFB8  mov      x1, x20
006A5CFBC  bl       #0x382bcb8 ; 
006A5CFC0  b        #0x6a5cfd4 ; 
006A5CFC4  ldr      x8, [x2, #0x60]
006A5CFC8  mov      x0, x19
006A5CFCC  mov      x1, x20
006A5CFD0  blr      x8
006A5CFD4  ldp      x20, x19, [sp, #0x10]
006A5CFD8  mov      w0, #1
006A5CFDC  ldp      x30, x21, [sp], #0x20
006A5CFE0  ret      

