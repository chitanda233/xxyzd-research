; LocalModels.Bean.ItemGift_ItemGift$$readImpl
; RVA 0x6AAB8B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AAB8B4  stp      x30, x21, [sp, #-0x20]!
006AAB8B8  stp      x20, x19, [sp, #0x10]
006AAB8BC  adrp     x20, #0x959e000
006AAB8C0  adrp     x21, #0x8f3a000
006AAB8C4  ldrb     w8, [x20, #0x74a]
006AAB8C8  ldr      x21, [x21, #0x2e8]
006AAB8CC  mov      x19, x0
006AAB8D0  tbnz     w8, #0, #0x6aab8e8
006AAB8D4  adrp     x0, #0x8f3a000
006AAB8D8  ldr      x0, [x0, #0x2e8]
006AAB8DC  bl       #0x382bd14 ; 
006AAB8E0  mov      w8, #1
006AAB8E4  strb     w8, [x20, #0x74a]
006AAB8E8  ldr      x1, [x21]
006AAB8EC  ldrb     w8, [x1, #0x53]
006AAB8F0  tbnz     w8, #5, #0x6aab940
006AAB8F4  mov      x0, x19
006AAB8F8  mov      x1, xzr
006AAB8FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAB900  adrp     x21, #0x959e000
006AAB904  ldrb     w8, [x21, #0xf38]
006AAB908  mov      w20, w0
006AAB90C  cbnz     w8, #0x6aab924
006AAB910  adrp     x0, #0x8f3a000
006AAB914  ldr      x0, [x0, #0x2b0]
006AAB918  bl       #0x382bd14 ; 
006AAB91C  mov      w8, #1
006AAB920  strb     w8, [x21, #0xf38]
006AAB924  adrp     x8, #0x8f3a000
006AAB928  ldr      x8, [x8, #0x2b0]
006AAB92C  ldr      x2, [x8]
006AAB930  ldrb     w8, [x2, #0x53]
006AAB934  tbnz     w8, #5, #0x6aab954
006AAB938  str      w20, [x19, #0x20]
006AAB93C  b        #0x6aab964 ; 
006AAB940  ldr      x2, [x1, #0x60]
006AAB944  mov      x0, x19
006AAB948  ldp      x20, x19, [sp, #0x10]
006AAB94C  ldp      x30, x21, [sp], #0x20
006AAB950  br       x2
006AAB954  ldr      x8, [x2, #0x60]
006AAB958  mov      x0, x19
006AAB95C  mov      w1, w20
006AAB960  blr      x8
006AAB964  mov      x0, x19
006AAB968  mov      x1, xzr
006AAB96C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAB970  adrp     x21, #0x959e000
006AAB974  ldrb     w8, [x21, #0xf39]
006AAB978  mov      w20, w0
006AAB97C  cbnz     w8, #0x6aab994
006AAB980  adrp     x0, #0x8f3a000
006AAB984  ldr      x0, [x0, #0x2c0]
006AAB988  bl       #0x382bd14 ; 
006AAB98C  mov      w8, #1
006AAB990  strb     w8, [x21, #0xf39]
006AAB994  adrp     x8, #0x8f3a000
006AAB998  ldr      x8, [x8, #0x2c0]
006AAB99C  ldr      x2, [x8]
006AAB9A0  ldrb     w8, [x2, #0x53]
006AAB9A4  tbnz     w8, #5, #0x6aab9b0
006AAB9A8  str      w20, [x19, #0x24]
006AAB9AC  b        #0x6aab9c0 ; 
006AAB9B0  ldr      x8, [x2, #0x60]
006AAB9B4  mov      x0, x19
006AAB9B8  mov      w1, w20
006AAB9BC  blr      x8
006AAB9C0  mov      x0, x19
006AAB9C4  mov      x1, xzr
006AAB9C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AAB9CC  adrp     x21, #0x959e000
006AAB9D0  ldrb     w8, [x21, #0xf3a]
006AAB9D4  mov      x20, x0
006AAB9D8  cbnz     w8, #0x6aab9f0
006AAB9DC  adrp     x0, #0x8f3a000
006AAB9E0  ldr      x0, [x0, #0x2d0]
006AAB9E4  bl       #0x382bd14 ; 
006AAB9E8  mov      w8, #1
006AAB9EC  strb     w8, [x21, #0xf3a]
006AAB9F0  adrp     x8, #0x8f3a000
006AAB9F4  ldr      x8, [x8, #0x2d0]
006AAB9F8  ldr      x2, [x8]
006AAB9FC  ldrb     w8, [x2, #0x53]
006AABA00  tbnz     w8, #5, #0x6aaba18
006AABA04  mov      x0, x19
006AABA08  str      x20, [x0, #0x28]!
006AABA0C  mov      x1, x20
006AABA10  bl       #0x382bcb8 ; 
006AABA14  b        #0x6aaba28 ; 
006AABA18  ldr      x8, [x2, #0x60]
006AABA1C  mov      x0, x19
006AABA20  mov      x1, x20
006AABA24  blr      x8
006AABA28  mov      x0, x19
006AABA2C  mov      x1, xzr
006AABA30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AABA34  adrp     x21, #0x959e000
006AABA38  ldrb     w8, [x21, #0xf3b]
006AABA3C  mov      w20, w0
006AABA40  cbnz     w8, #0x6aaba58
006AABA44  adrp     x0, #0x8f3a000
006AABA48  ldr      x0, [x0, #0x2e0]
006AABA4C  bl       #0x382bd14 ; 
006AABA50  mov      w8, #1
006AABA54  strb     w8, [x21, #0xf3b]
006AABA58  adrp     x8, #0x8f3a000
006AABA5C  ldr      x8, [x8, #0x2e0]
006AABA60  ldr      x2, [x8]
006AABA64  ldrb     w8, [x2, #0x53]
006AABA68  tbnz     w8, #5, #0x6aaba74
006AABA6C  str      w20, [x19, #0x30]
006AABA70  b        #0x6aaba84 ; 
006AABA74  ldr      x8, [x2, #0x60]
006AABA78  mov      x0, x19
006AABA7C  mov      w1, w20
006AABA80  blr      x8
006AABA84  ldp      x20, x19, [sp, #0x10]
006AABA88  mov      w0, #1
006AABA8C  ldp      x30, x21, [sp], #0x20
006AABA90  ret      

