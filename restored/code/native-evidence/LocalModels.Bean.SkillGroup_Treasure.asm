; LocalModels.Bean.SkillGroup_Treasure$$readImpl
; RVA 0x6AFCC6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFCC6C  stp      x30, x21, [sp, #-0x20]!
006AFCC70  stp      x20, x19, [sp, #0x10]
006AFCC74  adrp     x20, #0x959f000
006AFCC78  adrp     x21, #0x8f3d000
006AFCC7C  ldrb     w8, [x20, #0x335]
006AFCC80  ldr      x21, [x21, #0xf40]
006AFCC84  mov      x19, x0
006AFCC88  tbnz     w8, #0, #0x6afcca0
006AFCC8C  adrp     x0, #0x8f3d000
006AFCC90  ldr      x0, [x0, #0xf40]
006AFCC94  bl       #0x382bd14 ; 
006AFCC98  mov      w8, #1
006AFCC9C  strb     w8, [x20, #0x335]
006AFCCA0  ldr      x1, [x21]
006AFCCA4  ldrb     w8, [x1, #0x53]
006AFCCA8  tbnz     w8, #5, #0x6afccf8
006AFCCAC  mov      x0, x19
006AFCCB0  mov      x1, xzr
006AFCCB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFCCB8  adrp     x21, #0x959f000
006AFCCBC  ldrb     w8, [x21, #0x8bf]
006AFCCC0  mov      w20, w0
006AFCCC4  cbnz     w8, #0x6afccdc
006AFCCC8  adrp     x0, #0x8f3d000
006AFCCCC  ldr      x0, [x0, #0xf18]
006AFCCD0  bl       #0x382bd14 ; 
006AFCCD4  mov      w8, #1
006AFCCD8  strb     w8, [x21, #0x8bf]
006AFCCDC  adrp     x8, #0x8f3d000
006AFCCE0  ldr      x8, [x8, #0xf18]
006AFCCE4  ldr      x2, [x8]
006AFCCE8  ldrb     w8, [x2, #0x53]
006AFCCEC  tbnz     w8, #5, #0x6afcd0c
006AFCCF0  str      w20, [x19, #0x20]
006AFCCF4  b        #0x6afcd1c ; 
006AFCCF8  ldr      x2, [x1, #0x60]
006AFCCFC  mov      x0, x19
006AFCD00  ldp      x20, x19, [sp, #0x10]
006AFCD04  ldp      x30, x21, [sp], #0x20
006AFCD08  br       x2
006AFCD0C  ldr      x8, [x2, #0x60]
006AFCD10  mov      x0, x19
006AFCD14  mov      w1, w20
006AFCD18  blr      x8
006AFCD1C  mov      x0, x19
006AFCD20  mov      x1, xzr
006AFCD24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFCD28  adrp     x21, #0x959f000
006AFCD2C  ldrb     w8, [x21, #0x8c0]
006AFCD30  mov      w20, w0
006AFCD34  cbnz     w8, #0x6afcd4c
006AFCD38  adrp     x0, #0x8f3d000
006AFCD3C  ldr      x0, [x0, #0xf28]
006AFCD40  bl       #0x382bd14 ; 
006AFCD44  mov      w8, #1
006AFCD48  strb     w8, [x21, #0x8c0]
006AFCD4C  adrp     x8, #0x8f3d000
006AFCD50  ldr      x8, [x8, #0xf28]
006AFCD54  ldr      x2, [x8]
006AFCD58  ldrb     w8, [x2, #0x53]
006AFCD5C  tbnz     w8, #5, #0x6afcd68
006AFCD60  str      w20, [x19, #0x24]
006AFCD64  b        #0x6afcd78 ; 
006AFCD68  ldr      x8, [x2, #0x60]
006AFCD6C  mov      x0, x19
006AFCD70  mov      w1, w20
006AFCD74  blr      x8
006AFCD78  mov      x0, x19
006AFCD7C  mov      x1, xzr
006AFCD80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFCD84  adrp     x21, #0x959f000
006AFCD88  ldrb     w8, [x21, #0x8c1]
006AFCD8C  mov      w20, w0
006AFCD90  cbnz     w8, #0x6afcda8
006AFCD94  adrp     x0, #0x8f3d000
006AFCD98  ldr      x0, [x0, #0xf38]
006AFCD9C  bl       #0x382bd14 ; 
006AFCDA0  mov      w8, #1
006AFCDA4  strb     w8, [x21, #0x8c1]
006AFCDA8  adrp     x8, #0x8f3d000
006AFCDAC  ldr      x8, [x8, #0xf38]
006AFCDB0  ldr      x2, [x8]
006AFCDB4  ldrb     w8, [x2, #0x53]
006AFCDB8  tbnz     w8, #5, #0x6afcdc4
006AFCDBC  str      w20, [x19, #0x28]
006AFCDC0  b        #0x6afcdd4 ; 
006AFCDC4  ldr      x8, [x2, #0x60]
006AFCDC8  mov      x0, x19
006AFCDCC  mov      w1, w20
006AFCDD0  blr      x8
006AFCDD4  ldp      x20, x19, [sp, #0x10]
006AFCDD8  mov      w0, #1
006AFCDDC  ldp      x30, x21, [sp], #0x20
006AFCDE0  ret      

