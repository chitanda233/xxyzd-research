; LocalModels.Bean.Skillss_SkillUpgrade$$readImpl
; RVA 0x6B03AE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B03AE4  stp      x30, x21, [sp, #-0x20]!
006B03AE8  stp      x20, x19, [sp, #0x10]
006B03AEC  adrp     x20, #0x959f000
006B03AF0  adrp     x21, #0x8f3e000
006B03AF4  ldrb     w8, [x20, #0x3eb]
006B03AF8  ldr      x21, [x21, #0x460]
006B03AFC  mov      x19, x0
006B03B00  tbnz     w8, #0, #0x6b03b18
006B03B04  adrp     x0, #0x8f3e000
006B03B08  ldr      x0, [x0, #0x460]
006B03B0C  bl       #0x382bd14 ; 
006B03B10  mov      w8, #1
006B03B14  strb     w8, [x20, #0x3eb]
006B03B18  ldr      x1, [x21]
006B03B1C  ldrb     w8, [x1, #0x53]
006B03B20  tbnz     w8, #5, #0x6b03b70
006B03B24  mov      x0, x19
006B03B28  mov      x1, xzr
006B03B2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03B30  adrp     x21, #0x959f000
006B03B34  ldrb     w8, [x21, #0x912]
006B03B38  mov      w20, w0
006B03B3C  cbnz     w8, #0x6b03b54
006B03B40  adrp     x0, #0x8f3e000
006B03B44  ldr      x0, [x0, #0x418]
006B03B48  bl       #0x382bd14 ; 
006B03B4C  mov      w8, #1
006B03B50  strb     w8, [x21, #0x912]
006B03B54  adrp     x8, #0x8f3e000
006B03B58  ldr      x8, [x8, #0x418]
006B03B5C  ldr      x2, [x8]
006B03B60  ldrb     w8, [x2, #0x53]
006B03B64  tbnz     w8, #5, #0x6b03b84
006B03B68  str      w20, [x19, #0x20]
006B03B6C  b        #0x6b03b94 ; 
006B03B70  ldr      x2, [x1, #0x60]
006B03B74  mov      x0, x19
006B03B78  ldp      x20, x19, [sp, #0x10]
006B03B7C  ldp      x30, x21, [sp], #0x20
006B03B80  br       x2
006B03B84  ldr      x8, [x2, #0x60]
006B03B88  mov      x0, x19
006B03B8C  mov      w1, w20
006B03B90  blr      x8
006B03B94  mov      x0, x19
006B03B98  mov      x1, xzr
006B03B9C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03BA0  adrp     x21, #0x959f000
006B03BA4  ldrb     w8, [x21, #0x913]
006B03BA8  mov      w20, w0
006B03BAC  cbnz     w8, #0x6b03bc4
006B03BB0  adrp     x0, #0x8f3e000
006B03BB4  ldr      x0, [x0, #0x428]
006B03BB8  bl       #0x382bd14 ; 
006B03BBC  mov      w8, #1
006B03BC0  strb     w8, [x21, #0x913]
006B03BC4  adrp     x8, #0x8f3e000
006B03BC8  ldr      x8, [x8, #0x428]
006B03BCC  ldr      x2, [x8]
006B03BD0  ldrb     w8, [x2, #0x53]
006B03BD4  tbnz     w8, #5, #0x6b03be0
006B03BD8  str      w20, [x19, #0x24]
006B03BDC  b        #0x6b03bf0 ; 
006B03BE0  ldr      x8, [x2, #0x60]
006B03BE4  mov      x0, x19
006B03BE8  mov      w1, w20
006B03BEC  blr      x8
006B03BF0  mov      x0, x19
006B03BF4  mov      x1, xzr
006B03BF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03BFC  adrp     x21, #0x959f000
006B03C00  ldrb     w8, [x21, #0x914]
006B03C04  mov      w20, w0
006B03C08  cbnz     w8, #0x6b03c20
006B03C0C  adrp     x0, #0x8f3e000
006B03C10  ldr      x0, [x0, #0x438]
006B03C14  bl       #0x382bd14 ; 
006B03C18  mov      w8, #1
006B03C1C  strb     w8, [x21, #0x914]
006B03C20  adrp     x8, #0x8f3e000
006B03C24  ldr      x8, [x8, #0x438]
006B03C28  ldr      x2, [x8]
006B03C2C  ldrb     w8, [x2, #0x53]
006B03C30  tbnz     w8, #5, #0x6b03c3c
006B03C34  str      w20, [x19, #0x28]
006B03C38  b        #0x6b03c4c ; 
006B03C3C  ldr      x8, [x2, #0x60]
006B03C40  mov      x0, x19
006B03C44  mov      w1, w20
006B03C48  blr      x8
006B03C4C  mov      x0, x19
006B03C50  mov      x1, xzr
006B03C54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03C58  adrp     x21, #0x959f000
006B03C5C  ldrb     w8, [x21, #0x915]
006B03C60  mov      w20, w0
006B03C64  cbnz     w8, #0x6b03c7c
006B03C68  adrp     x0, #0x8f3e000
006B03C6C  ldr      x0, [x0, #0x448]
006B03C70  bl       #0x382bd14 ; 
006B03C74  mov      w8, #1
006B03C78  strb     w8, [x21, #0x915]
006B03C7C  adrp     x8, #0x8f3e000
006B03C80  ldr      x8, [x8, #0x448]
006B03C84  ldr      x2, [x8]
006B03C88  ldrb     w8, [x2, #0x53]
006B03C8C  tbnz     w8, #5, #0x6b03c98
006B03C90  str      w20, [x19, #0x2c]
006B03C94  b        #0x6b03ca8 ; 
006B03C98  ldr      x8, [x2, #0x60]
006B03C9C  mov      x0, x19
006B03CA0  mov      w1, w20
006B03CA4  blr      x8
006B03CA8  mov      x0, x19
006B03CAC  mov      x1, xzr
006B03CB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03CB4  adrp     x21, #0x959f000
006B03CB8  ldrb     w8, [x21, #0x916]
006B03CBC  mov      w20, w0
006B03CC0  cbnz     w8, #0x6b03cd8
006B03CC4  adrp     x0, #0x8f3e000
006B03CC8  ldr      x0, [x0, #0x458]
006B03CCC  bl       #0x382bd14 ; 
006B03CD0  mov      w8, #1
006B03CD4  strb     w8, [x21, #0x916]
006B03CD8  adrp     x8, #0x8f3e000
006B03CDC  ldr      x8, [x8, #0x458]
006B03CE0  ldr      x2, [x8]
006B03CE4  ldrb     w8, [x2, #0x53]
006B03CE8  tbnz     w8, #5, #0x6b03cf4
006B03CEC  str      w20, [x19, #0x30]
006B03CF0  b        #0x6b03d04 ; 
006B03CF4  ldr      x8, [x2, #0x60]
006B03CF8  mov      x0, x19
006B03CFC  mov      w1, w20
006B03D00  blr      x8
006B03D04  ldp      x20, x19, [sp, #0x10]
006B03D08  mov      w0, #1
006B03D0C  ldp      x30, x21, [sp], #0x20
006B03D10  ret      

