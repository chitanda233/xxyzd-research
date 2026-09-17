; LocalModels.Bean.Chapter_Sections$$readImpl
; RVA 0x68B5B50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B5B50  stp      x30, x21, [sp, #-0x20]!
0068B5B54  stp      x20, x19, [sp, #0x10]
0068B5B58  adrp     x20, #0x959c000
0068B5B5C  adrp     x21, #0x8f27000
0068B5B60  ldrb     w8, [x20, #0xef]
0068B5B64  ldr      x21, [x21, #0x340]
0068B5B68  mov      x19, x0
0068B5B6C  tbnz     w8, #0, #0x68b5b84
0068B5B70  adrp     x0, #0x8f27000
0068B5B74  ldr      x0, [x0, #0x340]
0068B5B78  bl       #0x382bd14 ; 
0068B5B7C  mov      w8, #1
0068B5B80  strb     w8, [x20, #0xef]
0068B5B84  ldr      x1, [x21]
0068B5B88  ldrb     w8, [x1, #0x53]
0068B5B8C  tbnz     w8, #5, #0x68b5bdc
0068B5B90  mov      x0, x19
0068B5B94  mov      x1, xzr
0068B5B98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B5B9C  adrp     x21, #0x959c000
0068B5BA0  ldrb     w8, [x21, #0x622]
0068B5BA4  mov      w20, w0
0068B5BA8  cbnz     w8, #0x68b5bc0
0068B5BAC  adrp     x0, #0x8f27000
0068B5BB0  ldr      x0, [x0, #0x318]
0068B5BB4  bl       #0x382bd14 ; 
0068B5BB8  mov      w8, #1
0068B5BBC  strb     w8, [x21, #0x622]
0068B5BC0  adrp     x8, #0x8f27000
0068B5BC4  ldr      x8, [x8, #0x318]
0068B5BC8  ldr      x2, [x8]
0068B5BCC  ldrb     w8, [x2, #0x53]
0068B5BD0  tbnz     w8, #5, #0x68b5bf0
0068B5BD4  str      w20, [x19, #0x20]
0068B5BD8  b        #0x68b5c00 ; 
0068B5BDC  ldr      x2, [x1, #0x60]
0068B5BE0  mov      x0, x19
0068B5BE4  ldp      x20, x19, [sp, #0x10]
0068B5BE8  ldp      x30, x21, [sp], #0x20
0068B5BEC  br       x2
0068B5BF0  ldr      x8, [x2, #0x60]
0068B5BF4  mov      x0, x19
0068B5BF8  mov      w1, w20
0068B5BFC  blr      x8
0068B5C00  mov      x0, x19
0068B5C04  mov      x1, xzr
0068B5C08  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068B5C0C  adrp     x21, #0x959c000
0068B5C10  ldrb     w8, [x21, #0x623]
0068B5C14  mov      x20, x0
0068B5C18  cbnz     w8, #0x68b5c30
0068B5C1C  adrp     x0, #0x8f27000
0068B5C20  ldr      x0, [x0, #0x328]
0068B5C24  bl       #0x382bd14 ; 
0068B5C28  mov      w8, #1
0068B5C2C  strb     w8, [x21, #0x623]
0068B5C30  adrp     x8, #0x8f27000
0068B5C34  ldr      x8, [x8, #0x328]
0068B5C38  ldr      x2, [x8]
0068B5C3C  ldrb     w8, [x2, #0x53]
0068B5C40  tbnz     w8, #5, #0x68b5c58
0068B5C44  mov      x0, x19
0068B5C48  str      x20, [x0, #0x28]!
0068B5C4C  mov      x1, x20
0068B5C50  bl       #0x382bcb8 ; 
0068B5C54  b        #0x68b5c68 ; 
0068B5C58  ldr      x8, [x2, #0x60]
0068B5C5C  mov      x0, x19
0068B5C60  mov      x1, x20
0068B5C64  blr      x8
0068B5C68  mov      x0, x19
0068B5C6C  mov      x1, xzr
0068B5C70  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B5C74  adrp     x21, #0x959c000
0068B5C78  ldrb     w8, [x21, #0x624]
0068B5C7C  mov      x20, x0
0068B5C80  cbnz     w8, #0x68b5c98
0068B5C84  adrp     x0, #0x8f27000
0068B5C88  ldr      x0, [x0, #0x338]
0068B5C8C  bl       #0x382bd14 ; 
0068B5C90  mov      w8, #1
0068B5C94  strb     w8, [x21, #0x624]
0068B5C98  adrp     x8, #0x8f27000
0068B5C9C  ldr      x8, [x8, #0x338]
0068B5CA0  ldr      x2, [x8]
0068B5CA4  ldrb     w8, [x2, #0x53]
0068B5CA8  tbnz     w8, #5, #0x68b5cc0
0068B5CAC  str      x20, [x19, #0x30]!
0068B5CB0  mov      x0, x19
0068B5CB4  mov      x1, x20
0068B5CB8  bl       #0x382bcb8 ; 
0068B5CBC  b        #0x68b5cd0 ; 
0068B5CC0  ldr      x8, [x2, #0x60]
0068B5CC4  mov      x0, x19
0068B5CC8  mov      x1, x20
0068B5CCC  blr      x8
0068B5CD0  ldp      x20, x19, [sp, #0x10]
0068B5CD4  mov      w0, #1
0068B5CD8  ldp      x30, x21, [sp], #0x20
0068B5CDC  ret      

