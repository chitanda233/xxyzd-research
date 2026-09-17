; LocalModels.Bean.Task_DailyActive$$readImpl
; RVA 0x6B12B44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B12B44  stp      x30, x21, [sp, #-0x20]!
006B12B48  stp      x20, x19, [sp, #0x10]
006B12B4C  adrp     x20, #0x959f000
006B12B50  adrp     x21, #0x8f3e000
006B12B54  ldrb     w8, [x20, #0x573]
006B12B58  ldr      x21, [x21, #0xe08]
006B12B5C  mov      x19, x0
006B12B60  tbnz     w8, #0, #0x6b12b78
006B12B64  adrp     x0, #0x8f3e000
006B12B68  ldr      x0, [x0, #0xe08]
006B12B6C  bl       #0x382bd14 ; 
006B12B70  mov      w8, #1
006B12B74  strb     w8, [x20, #0x573]
006B12B78  ldr      x1, [x21]
006B12B7C  ldrb     w8, [x1, #0x53]
006B12B80  tbnz     w8, #5, #0x6b12bd0
006B12B84  mov      x0, x19
006B12B88  mov      x1, xzr
006B12B8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B12B90  adrp     x21, #0x959f000
006B12B94  ldrb     w8, [x21, #0x9bf]
006B12B98  mov      w20, w0
006B12B9C  cbnz     w8, #0x6b12bb4
006B12BA0  adrp     x0, #0x8f3e000
006B12BA4  ldr      x0, [x0, #0xde0]
006B12BA8  bl       #0x382bd14 ; 
006B12BAC  mov      w8, #1
006B12BB0  strb     w8, [x21, #0x9bf]
006B12BB4  adrp     x8, #0x8f3e000
006B12BB8  ldr      x8, [x8, #0xde0]
006B12BBC  ldr      x2, [x8]
006B12BC0  ldrb     w8, [x2, #0x53]
006B12BC4  tbnz     w8, #5, #0x6b12be4
006B12BC8  str      w20, [x19, #0x20]
006B12BCC  b        #0x6b12bf4 ; 
006B12BD0  ldr      x2, [x1, #0x60]
006B12BD4  mov      x0, x19
006B12BD8  ldp      x20, x19, [sp, #0x10]
006B12BDC  ldp      x30, x21, [sp], #0x20
006B12BE0  br       x2
006B12BE4  ldr      x8, [x2, #0x60]
006B12BE8  mov      x0, x19
006B12BEC  mov      w1, w20
006B12BF0  blr      x8
006B12BF4  mov      x0, x19
006B12BF8  mov      x1, xzr
006B12BFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B12C00  adrp     x21, #0x959f000
006B12C04  ldrb     w8, [x21, #0x9c0]
006B12C08  mov      w20, w0
006B12C0C  cbnz     w8, #0x6b12c24
006B12C10  adrp     x0, #0x8f3e000
006B12C14  ldr      x0, [x0, #0xdf0]
006B12C18  bl       #0x382bd14 ; 
006B12C1C  mov      w8, #1
006B12C20  strb     w8, [x21, #0x9c0]
006B12C24  adrp     x8, #0x8f3e000
006B12C28  ldr      x8, [x8, #0xdf0]
006B12C2C  ldr      x2, [x8]
006B12C30  ldrb     w8, [x2, #0x53]
006B12C34  tbnz     w8, #5, #0x6b12c40
006B12C38  str      w20, [x19, #0x24]
006B12C3C  b        #0x6b12c50 ; 
006B12C40  ldr      x8, [x2, #0x60]
006B12C44  mov      x0, x19
006B12C48  mov      w1, w20
006B12C4C  blr      x8
006B12C50  mov      x0, x19
006B12C54  mov      x1, xzr
006B12C58  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B12C5C  adrp     x21, #0x959f000
006B12C60  ldrb     w8, [x21, #0x9c1]
006B12C64  mov      x20, x0
006B12C68  cbnz     w8, #0x6b12c80
006B12C6C  adrp     x0, #0x8f3e000
006B12C70  ldr      x0, [x0, #0xe00]
006B12C74  bl       #0x382bd14 ; 
006B12C78  mov      w8, #1
006B12C7C  strb     w8, [x21, #0x9c1]
006B12C80  adrp     x8, #0x8f3e000
006B12C84  ldr      x8, [x8, #0xe00]
006B12C88  ldr      x2, [x8]
006B12C8C  ldrb     w8, [x2, #0x53]
006B12C90  tbnz     w8, #5, #0x6b12ca8
006B12C94  str      x20, [x19, #0x28]!
006B12C98  mov      x0, x19
006B12C9C  mov      x1, x20
006B12CA0  bl       #0x382bcb8 ; 
006B12CA4  b        #0x6b12cb8 ; 
006B12CA8  ldr      x8, [x2, #0x60]
006B12CAC  mov      x0, x19
006B12CB0  mov      x1, x20
006B12CB4  blr      x8
006B12CB8  ldp      x20, x19, [sp, #0x10]
006B12CBC  mov      w0, #1
006B12CC0  ldp      x30, x21, [sp], #0x20
006B12CC4  ret      

