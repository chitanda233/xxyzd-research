; LocalModels.Bean.ColorRelace_ColorReplace$$readImpl
; RVA 0x68CEF40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CEF40  stp      x30, x21, [sp, #-0x20]!
0068CEF44  stp      x20, x19, [sp, #0x10]
0068CEF48  adrp     x20, #0x959c000
0068CEF4C  adrp     x21, #0x8f28000
0068CEF50  ldrb     w8, [x20, #0x387]
0068CEF54  ldr      x21, [x21, #0x5a8]
0068CEF58  mov      x19, x0
0068CEF5C  tbnz     w8, #0, #0x68cef74
0068CEF60  adrp     x0, #0x8f28000
0068CEF64  ldr      x0, [x0, #0x5a8]
0068CEF68  bl       #0x382bd14 ; 
0068CEF6C  mov      w8, #1
0068CEF70  strb     w8, [x20, #0x387]
0068CEF74  ldr      x1, [x21]
0068CEF78  ldrb     w8, [x1, #0x53]
0068CEF7C  tbnz     w8, #5, #0x68cefcc
0068CEF80  mov      x0, x19
0068CEF84  mov      x1, xzr
0068CEF88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CEF8C  adrp     x21, #0x959c000
0068CEF90  ldrb     w8, [x21, #0x747]
0068CEF94  mov      w20, w0
0068CEF98  cbnz     w8, #0x68cefb0
0068CEF9C  adrp     x0, #0x8f28000
0068CEFA0  ldr      x0, [x0, #0x590]
0068CEFA4  bl       #0x382bd14 ; 
0068CEFA8  mov      w8, #1
0068CEFAC  strb     w8, [x21, #0x747]
0068CEFB0  adrp     x8, #0x8f28000
0068CEFB4  ldr      x8, [x8, #0x590]
0068CEFB8  ldr      x2, [x8]
0068CEFBC  ldrb     w8, [x2, #0x53]
0068CEFC0  tbnz     w8, #5, #0x68cefe0
0068CEFC4  str      w20, [x19, #0x20]
0068CEFC8  b        #0x68ceff0 ; 
0068CEFCC  ldr      x2, [x1, #0x60]
0068CEFD0  mov      x0, x19
0068CEFD4  ldp      x20, x19, [sp, #0x10]
0068CEFD8  ldp      x30, x21, [sp], #0x20
0068CEFDC  br       x2
0068CEFE0  ldr      x8, [x2, #0x60]
0068CEFE4  mov      x0, x19
0068CEFE8  mov      w1, w20
0068CEFEC  blr      x8
0068CEFF0  mov      x0, x19
0068CEFF4  mov      x1, xzr
0068CEFF8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068CEFFC  adrp     x21, #0x959c000
0068CF000  ldrb     w8, [x21, #0x748]
0068CF004  mov      x20, x0
0068CF008  cbnz     w8, #0x68cf020
0068CF00C  adrp     x0, #0x8f28000
0068CF010  ldr      x0, [x0, #0x5a0]
0068CF014  bl       #0x382bd14 ; 
0068CF018  mov      w8, #1
0068CF01C  strb     w8, [x21, #0x748]
0068CF020  adrp     x8, #0x8f28000
0068CF024  ldr      x8, [x8, #0x5a0]
0068CF028  ldr      x2, [x8]
0068CF02C  ldrb     w8, [x2, #0x53]
0068CF030  tbnz     w8, #5, #0x68cf048
0068CF034  str      x20, [x19, #0x28]!
0068CF038  mov      x0, x19
0068CF03C  mov      x1, x20
0068CF040  bl       #0x382bcb8 ; 
0068CF044  b        #0x68cf058 ; 
0068CF048  ldr      x8, [x2, #0x60]
0068CF04C  mov      x0, x19
0068CF050  mov      x1, x20
0068CF054  blr      x8
0068CF058  ldp      x20, x19, [sp, #0x10]
0068CF05C  mov      w0, #1
0068CF060  ldp      x30, x21, [sp], #0x20
0068CF064  ret      

