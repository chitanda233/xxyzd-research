; LocalModels.Bean.ChapterReward_Star$$readImpl
; RVA 0x689CEA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689CEA8  stp      x30, x21, [sp, #-0x20]!
00689CEAC  stp      x20, x19, [sp, #0x10]
00689CEB0  adrp     x20, #0x959b000
00689CEB4  adrp     x21, #0x8f26000
00689CEB8  ldrb     w8, [x20, #0xe6d]
00689CEBC  ldr      x21, [x21, #0xb8]
00689CEC0  mov      x19, x0
00689CEC4  tbnz     w8, #0, #0x689cedc
00689CEC8  adrp     x0, #0x8f26000
00689CECC  ldr      x0, [x0, #0xb8]
00689CED0  bl       #0x382bd14 ; 
00689CED4  mov      w8, #1
00689CED8  strb     w8, [x20, #0xe6d]
00689CEDC  ldr      x1, [x21]
00689CEE0  ldrb     w8, [x1, #0x53]
00689CEE4  tbnz     w8, #5, #0x689cf34
00689CEE8  mov      x0, x19
00689CEEC  mov      x1, xzr
00689CEF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689CEF4  adrp     x21, #0x959c000
00689CEF8  ldrb     w8, [x21, #0x4ee]
00689CEFC  mov      w20, w0
00689CF00  cbnz     w8, #0x689cf18
00689CF04  adrp     x0, #0x8f26000
00689CF08  ldr      x0, [x0, #0x88]
00689CF0C  bl       #0x382bd14 ; 
00689CF10  mov      w8, #1
00689CF14  strb     w8, [x21, #0x4ee]
00689CF18  adrp     x8, #0x8f26000
00689CF1C  ldr      x8, [x8, #0x88]
00689CF20  ldr      x2, [x8]
00689CF24  ldrb     w8, [x2, #0x53]
00689CF28  tbnz     w8, #5, #0x689cf48
00689CF2C  str      w20, [x19, #0x20]
00689CF30  b        #0x689cf58 ; 
00689CF34  ldr      x2, [x1, #0x60]
00689CF38  mov      x0, x19
00689CF3C  ldp      x20, x19, [sp, #0x10]
00689CF40  ldp      x30, x21, [sp], #0x20
00689CF44  br       x2
00689CF48  ldr      x8, [x2, #0x60]
00689CF4C  mov      x0, x19
00689CF50  mov      w1, w20
00689CF54  blr      x8
00689CF58  mov      x0, x19
00689CF5C  mov      x1, xzr
00689CF60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689CF64  adrp     x21, #0x959c000
00689CF68  ldrb     w8, [x21, #0x4ef]
00689CF6C  mov      w20, w0
00689CF70  cbnz     w8, #0x689cf88
00689CF74  adrp     x0, #0x8f26000
00689CF78  ldr      x0, [x0, #0x90]
00689CF7C  bl       #0x382bd14 ; 
00689CF80  mov      w8, #1
00689CF84  strb     w8, [x21, #0x4ef]
00689CF88  adrp     x8, #0x8f26000
00689CF8C  ldr      x8, [x8, #0x90]
00689CF90  ldr      x2, [x8]
00689CF94  ldrb     w8, [x2, #0x53]
00689CF98  tbnz     w8, #5, #0x689cfa4
00689CF9C  str      w20, [x19, #0x24]
00689CFA0  b        #0x689cfb4 ; 
00689CFA4  ldr      x8, [x2, #0x60]
00689CFA8  mov      x0, x19
00689CFAC  mov      w1, w20
00689CFB0  blr      x8
00689CFB4  mov      x0, x19
00689CFB8  mov      x1, xzr
00689CFBC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689CFC0  adrp     x21, #0x959c000
00689CFC4  ldrb     w8, [x21, #0x4f0]
00689CFC8  mov      w20, w0
00689CFCC  cbnz     w8, #0x689cfe4
00689CFD0  adrp     x0, #0x8f26000
00689CFD4  ldr      x0, [x0, #0x98]
00689CFD8  bl       #0x382bd14 ; 
00689CFDC  mov      w8, #1
00689CFE0  strb     w8, [x21, #0x4f0]
00689CFE4  adrp     x8, #0x8f26000
00689CFE8  ldr      x8, [x8, #0x98]
00689CFEC  ldr      x2, [x8]
00689CFF0  ldrb     w8, [x2, #0x53]
00689CFF4  tbnz     w8, #5, #0x689d000
00689CFF8  str      w20, [x19, #0x28]
00689CFFC  b        #0x689d010 ; 
00689D000  ldr      x8, [x2, #0x60]
00689D004  mov      x0, x19
00689D008  mov      w1, w20
00689D00C  blr      x8
00689D010  mov      x0, x19
00689D014  mov      x1, xzr
00689D018  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689D01C  adrp     x21, #0x959c000
00689D020  ldrb     w8, [x21, #0x4f1]
00689D024  mov      w20, w0
00689D028  cbnz     w8, #0x689d040
00689D02C  adrp     x0, #0x8f26000
00689D030  ldr      x0, [x0, #0xa0]
00689D034  bl       #0x382bd14 ; 
00689D038  mov      w8, #1
00689D03C  strb     w8, [x21, #0x4f1]
00689D040  adrp     x8, #0x8f26000
00689D044  ldr      x8, [x8, #0xa0]
00689D048  ldr      x2, [x8]
00689D04C  ldrb     w8, [x2, #0x53]
00689D050  tbnz     w8, #5, #0x689d05c
00689D054  str      w20, [x19, #0x2c]
00689D058  b        #0x689d06c ; 
00689D05C  ldr      x8, [x2, #0x60]
00689D060  mov      x0, x19
00689D064  mov      w1, w20
00689D068  blr      x8
00689D06C  mov      x0, x19
00689D070  mov      x1, xzr
00689D074  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00689D078  adrp     x21, #0x959c000
00689D07C  ldrb     w8, [x21, #0x4f2]
00689D080  mov      x20, x0
00689D084  cbnz     w8, #0x689d09c
00689D088  adrp     x0, #0x8f26000
00689D08C  ldr      x0, [x0, #0xb0]
00689D090  bl       #0x382bd14 ; 
00689D094  mov      w8, #1
00689D098  strb     w8, [x21, #0x4f2]
00689D09C  adrp     x8, #0x8f26000
00689D0A0  ldr      x8, [x8, #0xb0]
00689D0A4  ldr      x2, [x8]
00689D0A8  ldrb     w8, [x2, #0x53]
00689D0AC  tbnz     w8, #5, #0x689d0c4
00689D0B0  str      x20, [x19, #0x30]!
00689D0B4  mov      x0, x19
00689D0B8  mov      x1, x20
00689D0BC  bl       #0x382bcb8 ; 
00689D0C0  b        #0x689d0d4 ; 
00689D0C4  ldr      x8, [x2, #0x60]
00689D0C8  mov      x0, x19
00689D0CC  mov      x1, x20
00689D0D0  blr      x8
00689D0D4  ldp      x20, x19, [sp, #0x10]
00689D0D8  mov      w0, #1
00689D0DC  ldp      x30, x21, [sp], #0x20
00689D0E0  ret      

