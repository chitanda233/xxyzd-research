; LocalModels.Bean.Skill_SkillTypeWeight$$readImpl
; RVA 0x6B0BA64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0BA64  stp      x30, x21, [sp, #-0x20]!
006B0BA68  stp      x20, x19, [sp, #0x10]
006B0BA6C  adrp     x20, #0x959f000
006B0BA70  adrp     x21, #0x8f3e000
006B0BA74  ldrb     w8, [x20, #0x4b5]
006B0BA78  ldr      x21, [x21, #0x918]
006B0BA7C  mov      x19, x0
006B0BA80  tbnz     w8, #0, #0x6b0ba98
006B0BA84  adrp     x0, #0x8f3e000
006B0BA88  ldr      x0, [x0, #0x918]
006B0BA8C  bl       #0x382bd14 ; 
006B0BA90  mov      w8, #1
006B0BA94  strb     w8, [x20, #0x4b5]
006B0BA98  ldr      x1, [x21]
006B0BA9C  ldrb     w8, [x1, #0x53]
006B0BAA0  tbnz     w8, #5, #0x6b0baf0
006B0BAA4  mov      x0, x19
006B0BAA8  mov      x1, xzr
006B0BAAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0BAB0  adrp     x21, #0x959f000
006B0BAB4  ldrb     w8, [x21, #0x972]
006B0BAB8  mov      w20, w0
006B0BABC  cbnz     w8, #0x6b0bad4
006B0BAC0  adrp     x0, #0x8f3e000
006B0BAC4  ldr      x0, [x0, #0x900]
006B0BAC8  bl       #0x382bd14 ; 
006B0BACC  mov      w8, #1
006B0BAD0  strb     w8, [x21, #0x972]
006B0BAD4  adrp     x8, #0x8f3e000
006B0BAD8  ldr      x8, [x8, #0x900]
006B0BADC  ldr      x2, [x8]
006B0BAE0  ldrb     w8, [x2, #0x53]
006B0BAE4  tbnz     w8, #5, #0x6b0bb04
006B0BAE8  str      w20, [x19, #0x20]
006B0BAEC  b        #0x6b0bb14 ; 
006B0BAF0  ldr      x2, [x1, #0x60]
006B0BAF4  mov      x0, x19
006B0BAF8  ldp      x20, x19, [sp, #0x10]
006B0BAFC  ldp      x30, x21, [sp], #0x20
006B0BB00  br       x2
006B0BB04  ldr      x8, [x2, #0x60]
006B0BB08  mov      x0, x19
006B0BB0C  mov      w1, w20
006B0BB10  blr      x8
006B0BB14  mov      x0, x19
006B0BB18  mov      x1, xzr
006B0BB1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0BB20  adrp     x21, #0x959f000
006B0BB24  ldrb     w8, [x21, #0x973]
006B0BB28  mov      w20, w0
006B0BB2C  cbnz     w8, #0x6b0bb44
006B0BB30  adrp     x0, #0x8f3e000
006B0BB34  ldr      x0, [x0, #0x908]
006B0BB38  bl       #0x382bd14 ; 
006B0BB3C  mov      w8, #1
006B0BB40  strb     w8, [x21, #0x973]
006B0BB44  adrp     x8, #0x8f3e000
006B0BB48  ldr      x8, [x8, #0x908]
006B0BB4C  ldr      x2, [x8]
006B0BB50  ldrb     w8, [x2, #0x53]
006B0BB54  tbnz     w8, #5, #0x6b0bb60
006B0BB58  str      w20, [x19, #0x24]
006B0BB5C  b        #0x6b0bb70 ; 
006B0BB60  ldr      x8, [x2, #0x60]
006B0BB64  mov      x0, x19
006B0BB68  mov      w1, w20
006B0BB6C  blr      x8
006B0BB70  mov      x0, x19
006B0BB74  mov      x1, xzr
006B0BB78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0BB7C  adrp     x21, #0x959f000
006B0BB80  ldrb     w8, [x21, #0x974]
006B0BB84  mov      w20, w0
006B0BB88  cbnz     w8, #0x6b0bba0
006B0BB8C  adrp     x0, #0x8f3e000
006B0BB90  ldr      x0, [x0, #0x910]
006B0BB94  bl       #0x382bd14 ; 
006B0BB98  mov      w8, #1
006B0BB9C  strb     w8, [x21, #0x974]
006B0BBA0  adrp     x8, #0x8f3e000
006B0BBA4  ldr      x8, [x8, #0x910]
006B0BBA8  ldr      x2, [x8]
006B0BBAC  ldrb     w8, [x2, #0x53]
006B0BBB0  tbnz     w8, #5, #0x6b0bbbc
006B0BBB4  str      w20, [x19, #0x28]
006B0BBB8  b        #0x6b0bbcc ; 
006B0BBBC  ldr      x8, [x2, #0x60]
006B0BBC0  mov      x0, x19
006B0BBC4  mov      w1, w20
006B0BBC8  blr      x8
006B0BBCC  ldp      x20, x19, [sp, #0x10]
006B0BBD0  mov      w0, #1
006B0BBD4  ldp      x30, x21, [sp], #0x20
006B0BBD8  ret      

