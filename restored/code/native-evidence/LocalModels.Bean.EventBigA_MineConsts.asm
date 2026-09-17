; LocalModels.Bean.EventBigA_MineConsts$$readImpl
; RVA 0x6A69B94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A69B94  stp      x30, x21, [sp, #-0x20]!
006A69B98  stp      x20, x19, [sp, #0x10]
006A69B9C  adrp     x20, #0x959d000
006A69BA0  adrp     x21, #0x8f37000
006A69BA4  ldrb     w8, [x20, #0xce6]
006A69BA8  ldr      x21, [x21, #0x68]
006A69BAC  mov      x19, x0
006A69BB0  tbnz     w8, #0, #0x6a69bc8
006A69BB4  adrp     x0, #0x8f37000
006A69BB8  ldr      x0, [x0, #0x68]
006A69BBC  bl       #0x382bd14 ; 
006A69BC0  mov      w8, #1
006A69BC4  strb     w8, [x20, #0xce6]
006A69BC8  ldr      x1, [x21]
006A69BCC  ldrb     w8, [x1, #0x53]
006A69BD0  tbnz     w8, #5, #0x6a69c20
006A69BD4  mov      x0, x19
006A69BD8  mov      x1, xzr
006A69BDC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A69BE0  adrp     x21, #0x959e000
006A69BE4  ldrb     w8, [x21, #0x40b]
006A69BE8  mov      w20, w0
006A69BEC  cbnz     w8, #0x6a69c04
006A69BF0  adrp     x0, #0x8f37000
006A69BF4  ldr      x0, [x0, #0x30]
006A69BF8  bl       #0x382bd14 ; 
006A69BFC  mov      w8, #1
006A69C00  strb     w8, [x21, #0x40b]
006A69C04  adrp     x8, #0x8f37000
006A69C08  ldr      x8, [x8, #0x30]
006A69C0C  ldr      x2, [x8]
006A69C10  ldrb     w8, [x2, #0x53]
006A69C14  tbnz     w8, #5, #0x6a69c34
006A69C18  str      w20, [x19, #0x20]
006A69C1C  b        #0x6a69c44 ; 
006A69C20  ldr      x2, [x1, #0x60]
006A69C24  mov      x0, x19
006A69C28  ldp      x20, x19, [sp, #0x10]
006A69C2C  ldp      x30, x21, [sp], #0x20
006A69C30  br       x2
006A69C34  ldr      x8, [x2, #0x60]
006A69C38  mov      x0, x19
006A69C3C  mov      w1, w20
006A69C40  blr      x8
006A69C44  mov      x0, x19
006A69C48  mov      x1, xzr
006A69C4C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A69C50  adrp     x21, #0x959e000
006A69C54  ldrb     w8, [x21, #0x40c]
006A69C58  mov      x20, x0
006A69C5C  cbnz     w8, #0x6a69c74
006A69C60  adrp     x0, #0x8f37000
006A69C64  ldr      x0, [x0, #0x40]
006A69C68  bl       #0x382bd14 ; 
006A69C6C  mov      w8, #1
006A69C70  strb     w8, [x21, #0x40c]
006A69C74  adrp     x8, #0x8f37000
006A69C78  ldr      x8, [x8, #0x40]
006A69C7C  ldr      x2, [x8]
006A69C80  ldrb     w8, [x2, #0x53]
006A69C84  tbnz     w8, #5, #0x6a69c9c
006A69C88  mov      x0, x19
006A69C8C  str      x20, [x0, #0x28]!
006A69C90  mov      x1, x20
006A69C94  bl       #0x382bcb8 ; 
006A69C98  b        #0x6a69cac ; 
006A69C9C  ldr      x8, [x2, #0x60]
006A69CA0  mov      x0, x19
006A69CA4  mov      x1, x20
006A69CA8  blr      x8
006A69CAC  mov      x0, x19
006A69CB0  mov      x1, xzr
006A69CB4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A69CB8  adrp     x21, #0x959e000
006A69CBC  ldrb     w8, [x21, #0x40d]
006A69CC0  mov      x20, x0
006A69CC4  cbnz     w8, #0x6a69cdc
006A69CC8  adrp     x0, #0x8f37000
006A69CCC  ldr      x0, [x0, #0x50]
006A69CD0  bl       #0x382bd14 ; 
006A69CD4  mov      w8, #1
006A69CD8  strb     w8, [x21, #0x40d]
006A69CDC  adrp     x8, #0x8f37000
006A69CE0  ldr      x8, [x8, #0x50]
006A69CE4  ldr      x2, [x8]
006A69CE8  ldrb     w8, [x2, #0x53]
006A69CEC  tbnz     w8, #5, #0x6a69d04
006A69CF0  mov      x0, x19
006A69CF4  str      x20, [x0, #0x30]!
006A69CF8  mov      x1, x20
006A69CFC  bl       #0x382bcb8 ; 
006A69D00  b        #0x6a69d14 ; 
006A69D04  ldr      x8, [x2, #0x60]
006A69D08  mov      x0, x19
006A69D0C  mov      x1, x20
006A69D10  blr      x8
006A69D14  mov      x0, x19
006A69D18  mov      x1, xzr
006A69D1C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A69D20  adrp     x21, #0x959e000
006A69D24  ldrb     w8, [x21, #0x40e]
006A69D28  mov      x20, x0
006A69D2C  cbnz     w8, #0x6a69d44
006A69D30  adrp     x0, #0x8f37000
006A69D34  ldr      x0, [x0, #0x60]
006A69D38  bl       #0x382bd14 ; 
006A69D3C  mov      w8, #1
006A69D40  strb     w8, [x21, #0x40e]
006A69D44  adrp     x8, #0x8f37000
006A69D48  ldr      x8, [x8, #0x60]
006A69D4C  ldr      x2, [x8]
006A69D50  ldrb     w8, [x2, #0x53]
006A69D54  tbnz     w8, #5, #0x6a69d6c
006A69D58  str      x20, [x19, #0x38]!
006A69D5C  mov      x0, x19
006A69D60  mov      x1, x20
006A69D64  bl       #0x382bcb8 ; 
006A69D68  b        #0x6a69d7c ; 
006A69D6C  ldr      x8, [x2, #0x60]
006A69D70  mov      x0, x19
006A69D74  mov      x1, x20
006A69D78  blr      x8
006A69D7C  ldp      x20, x19, [sp, #0x10]
006A69D80  mov      w0, #1
006A69D84  ldp      x30, x21, [sp], #0x20
006A69D88  ret      

