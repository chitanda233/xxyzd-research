; LocalModels.Bean.Skill_Synthesis$$readImpl
; RVA 0x6B0C8CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0C8CC  stp      x30, x21, [sp, #-0x20]!
006B0C8D0  stp      x20, x19, [sp, #0x10]
006B0C8D4  adrp     x20, #0x959f000
006B0C8D8  adrp     x21, #0x8f3e000
006B0C8DC  ldrb     w8, [x20, #0x4cf]
006B0C8E0  ldr      x21, [x21, #0x9b8]
006B0C8E4  mov      x19, x0
006B0C8E8  tbnz     w8, #0, #0x6b0c900
006B0C8EC  adrp     x0, #0x8f3e000
006B0C8F0  ldr      x0, [x0, #0x9b8]
006B0C8F4  bl       #0x382bd14 ; 
006B0C8F8  mov      w8, #1
006B0C8FC  strb     w8, [x20, #0x4cf]
006B0C900  ldr      x1, [x21]
006B0C904  ldrb     w8, [x1, #0x53]
006B0C908  tbnz     w8, #5, #0x6b0c958
006B0C90C  mov      x0, x19
006B0C910  mov      x1, xzr
006B0C914  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C918  adrp     x21, #0x959f000
006B0C91C  ldrb     w8, [x21, #0x97a]
006B0C920  mov      w20, w0
006B0C924  cbnz     w8, #0x6b0c93c
006B0C928  adrp     x0, #0x8f3e000
006B0C92C  ldr      x0, [x0, #0x990]
006B0C930  bl       #0x382bd14 ; 
006B0C934  mov      w8, #1
006B0C938  strb     w8, [x21, #0x97a]
006B0C93C  adrp     x8, #0x8f3e000
006B0C940  ldr      x8, [x8, #0x990]
006B0C944  ldr      x2, [x8]
006B0C948  ldrb     w8, [x2, #0x53]
006B0C94C  tbnz     w8, #5, #0x6b0c96c
006B0C950  str      w20, [x19, #0x20]
006B0C954  b        #0x6b0c97c ; 
006B0C958  ldr      x2, [x1, #0x60]
006B0C95C  mov      x0, x19
006B0C960  ldp      x20, x19, [sp, #0x10]
006B0C964  ldp      x30, x21, [sp], #0x20
006B0C968  br       x2
006B0C96C  ldr      x8, [x2, #0x60]
006B0C970  mov      x0, x19
006B0C974  mov      w1, w20
006B0C978  blr      x8
006B0C97C  mov      x0, x19
006B0C980  mov      x1, xzr
006B0C984  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C988  adrp     x21, #0x959f000
006B0C98C  ldrb     w8, [x21, #0x97b]
006B0C990  mov      w20, w0
006B0C994  cbnz     w8, #0x6b0c9ac
006B0C998  adrp     x0, #0x8f3e000
006B0C99C  ldr      x0, [x0, #0x998]
006B0C9A0  bl       #0x382bd14 ; 
006B0C9A4  mov      w8, #1
006B0C9A8  strb     w8, [x21, #0x97b]
006B0C9AC  adrp     x8, #0x8f3e000
006B0C9B0  ldr      x8, [x8, #0x998]
006B0C9B4  ldr      x2, [x8]
006B0C9B8  ldrb     w8, [x2, #0x53]
006B0C9BC  tbnz     w8, #5, #0x6b0c9c8
006B0C9C0  str      w20, [x19, #0x24]
006B0C9C4  b        #0x6b0c9d8 ; 
006B0C9C8  ldr      x8, [x2, #0x60]
006B0C9CC  mov      x0, x19
006B0C9D0  mov      w1, w20
006B0C9D4  blr      x8
006B0C9D8  mov      x0, x19
006B0C9DC  mov      x1, xzr
006B0C9E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0C9E4  adrp     x21, #0x959f000
006B0C9E8  ldrb     w8, [x21, #0x97c]
006B0C9EC  mov      w20, w0
006B0C9F0  cbnz     w8, #0x6b0ca08
006B0C9F4  adrp     x0, #0x8f3e000
006B0C9F8  ldr      x0, [x0, #0x9a0]
006B0C9FC  bl       #0x382bd14 ; 
006B0CA00  mov      w8, #1
006B0CA04  strb     w8, [x21, #0x97c]
006B0CA08  adrp     x8, #0x8f3e000
006B0CA0C  ldr      x8, [x8, #0x9a0]
006B0CA10  ldr      x2, [x8]
006B0CA14  ldrb     w8, [x2, #0x53]
006B0CA18  tbnz     w8, #5, #0x6b0ca24
006B0CA1C  str      w20, [x19, #0x28]
006B0CA20  b        #0x6b0ca34 ; 
006B0CA24  ldr      x8, [x2, #0x60]
006B0CA28  mov      x0, x19
006B0CA2C  mov      w1, w20
006B0CA30  blr      x8
006B0CA34  mov      x0, x19
006B0CA38  mov      x1, xzr
006B0CA3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0CA40  adrp     x21, #0x959f000
006B0CA44  ldrb     w8, [x21, #0x97d]
006B0CA48  mov      w20, w0
006B0CA4C  cbnz     w8, #0x6b0ca64
006B0CA50  adrp     x0, #0x8f3e000
006B0CA54  ldr      x0, [x0, #0x9a8]
006B0CA58  bl       #0x382bd14 ; 
006B0CA5C  mov      w8, #1
006B0CA60  strb     w8, [x21, #0x97d]
006B0CA64  adrp     x8, #0x8f3e000
006B0CA68  ldr      x8, [x8, #0x9a8]
006B0CA6C  ldr      x2, [x8]
006B0CA70  ldrb     w8, [x2, #0x53]
006B0CA74  tbnz     w8, #5, #0x6b0ca80
006B0CA78  str      w20, [x19, #0x2c]
006B0CA7C  b        #0x6b0ca90 ; 
006B0CA80  ldr      x8, [x2, #0x60]
006B0CA84  mov      x0, x19
006B0CA88  mov      w1, w20
006B0CA8C  blr      x8
006B0CA90  mov      x0, x19
006B0CA94  mov      x1, xzr
006B0CA98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0CA9C  adrp     x21, #0x959f000
006B0CAA0  ldrb     w8, [x21, #0x97e]
006B0CAA4  mov      w20, w0
006B0CAA8  cbnz     w8, #0x6b0cac0
006B0CAAC  adrp     x0, #0x8f3e000
006B0CAB0  ldr      x0, [x0, #0x9b0]
006B0CAB4  bl       #0x382bd14 ; 
006B0CAB8  mov      w8, #1
006B0CABC  strb     w8, [x21, #0x97e]
006B0CAC0  adrp     x8, #0x8f3e000
006B0CAC4  ldr      x8, [x8, #0x9b0]
006B0CAC8  ldr      x2, [x8]
006B0CACC  ldrb     w8, [x2, #0x53]
006B0CAD0  tbnz     w8, #5, #0x6b0cadc
006B0CAD4  str      w20, [x19, #0x30]
006B0CAD8  b        #0x6b0caec ; 
006B0CADC  ldr      x8, [x2, #0x60]
006B0CAE0  mov      x0, x19
006B0CAE4  mov      w1, w20
006B0CAE8  blr      x8
006B0CAEC  ldp      x20, x19, [sp, #0x10]
006B0CAF0  mov      w0, #1
006B0CAF4  ldp      x30, x21, [sp], #0x20
006B0CAF8  ret      

