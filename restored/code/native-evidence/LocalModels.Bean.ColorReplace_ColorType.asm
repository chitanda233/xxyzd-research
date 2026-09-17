; LocalModels.Bean.ColorReplace_ColorType$$readImpl
; RVA 0x68CFD64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CFD64  stp      x30, x21, [sp, #-0x20]!
0068CFD68  stp      x20, x19, [sp, #0x10]
0068CFD6C  adrp     x20, #0x959c000
0068CFD70  adrp     x21, #0x8f28000
0068CFD74  ldrb     w8, [x20, #0x3a0]
0068CFD78  ldr      x21, [x21, #0x658]
0068CFD7C  mov      x19, x0
0068CFD80  tbnz     w8, #0, #0x68cfd98
0068CFD84  adrp     x0, #0x8f28000
0068CFD88  ldr      x0, [x0, #0x658]
0068CFD8C  bl       #0x382bd14 ; 
0068CFD90  mov      w8, #1
0068CFD94  strb     w8, [x20, #0x3a0]
0068CFD98  ldr      x1, [x21]
0068CFD9C  ldrb     w8, [x1, #0x53]
0068CFDA0  tbnz     w8, #5, #0x68cfdf0
0068CFDA4  mov      x0, x19
0068CFDA8  mov      x1, xzr
0068CFDAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CFDB0  adrp     x21, #0x959c000
0068CFDB4  ldrb     w8, [x21, #0x74e]
0068CFDB8  mov      w20, w0
0068CFDBC  cbnz     w8, #0x68cfdd4
0068CFDC0  adrp     x0, #0x8f28000
0068CFDC4  ldr      x0, [x0, #0x630]
0068CFDC8  bl       #0x382bd14 ; 
0068CFDCC  mov      w8, #1
0068CFDD0  strb     w8, [x21, #0x74e]
0068CFDD4  adrp     x8, #0x8f28000
0068CFDD8  ldr      x8, [x8, #0x630]
0068CFDDC  ldr      x2, [x8]
0068CFDE0  ldrb     w8, [x2, #0x53]
0068CFDE4  tbnz     w8, #5, #0x68cfe04
0068CFDE8  str      w20, [x19, #0x20]
0068CFDEC  b        #0x68cfe14 ; 
0068CFDF0  ldr      x2, [x1, #0x60]
0068CFDF4  mov      x0, x19
0068CFDF8  ldp      x20, x19, [sp, #0x10]
0068CFDFC  ldp      x30, x21, [sp], #0x20
0068CFE00  br       x2
0068CFE04  ldr      x8, [x2, #0x60]
0068CFE08  mov      x0, x19
0068CFE0C  mov      w1, w20
0068CFE10  blr      x8
0068CFE14  mov      x0, x19
0068CFE18  mov      x1, xzr
0068CFE1C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CFE20  adrp     x21, #0x959c000
0068CFE24  ldrb     w8, [x21, #0x74f]
0068CFE28  mov      x20, x0
0068CFE2C  cbnz     w8, #0x68cfe44
0068CFE30  adrp     x0, #0x8f28000
0068CFE34  ldr      x0, [x0, #0x640]
0068CFE38  bl       #0x382bd14 ; 
0068CFE3C  mov      w8, #1
0068CFE40  strb     w8, [x21, #0x74f]
0068CFE44  adrp     x8, #0x8f28000
0068CFE48  ldr      x8, [x8, #0x640]
0068CFE4C  ldr      x2, [x8]
0068CFE50  ldrb     w8, [x2, #0x53]
0068CFE54  tbnz     w8, #5, #0x68cfe6c
0068CFE58  mov      x0, x19
0068CFE5C  str      x20, [x0, #0x28]!
0068CFE60  mov      x1, x20
0068CFE64  bl       #0x382bcb8 ; 
0068CFE68  b        #0x68cfe7c ; 
0068CFE6C  ldr      x8, [x2, #0x60]
0068CFE70  mov      x0, x19
0068CFE74  mov      x1, x20
0068CFE78  blr      x8
0068CFE7C  mov      x0, x19
0068CFE80  mov      x1, xzr
0068CFE84  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CFE88  adrp     x21, #0x959c000
0068CFE8C  ldrb     w8, [x21, #0x750]
0068CFE90  mov      x20, x0
0068CFE94  cbnz     w8, #0x68cfeac
0068CFE98  adrp     x0, #0x8f28000
0068CFE9C  ldr      x0, [x0, #0x650]
0068CFEA0  bl       #0x382bd14 ; 
0068CFEA4  mov      w8, #1
0068CFEA8  strb     w8, [x21, #0x750]
0068CFEAC  adrp     x8, #0x8f28000
0068CFEB0  ldr      x8, [x8, #0x650]
0068CFEB4  ldr      x2, [x8]
0068CFEB8  ldrb     w8, [x2, #0x53]
0068CFEBC  tbnz     w8, #5, #0x68cfed4
0068CFEC0  str      x20, [x19, #0x30]!
0068CFEC4  mov      x0, x19
0068CFEC8  mov      x1, x20
0068CFECC  bl       #0x382bcb8 ; 
0068CFED0  b        #0x68cfee4 ; 
0068CFED4  ldr      x8, [x2, #0x60]
0068CFED8  mov      x0, x19
0068CFEDC  mov      x1, x20
0068CFEE0  blr      x8
0068CFEE4  ldp      x20, x19, [sp, #0x10]
0068CFEE8  mov      w0, #1
0068CFEEC  ldp      x30, x21, [sp], #0x20
0068CFEF0  ret      

