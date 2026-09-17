; LocalModels.Bean.Collection_Equip$$readImpl
; RVA 0x68CAF08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CAF08  stp      x30, x21, [sp, #-0x20]!
0068CAF0C  stp      x20, x19, [sp, #0x10]
0068CAF10  adrp     x20, #0x959c000
0068CAF14  adrp     x21, #0x8f28000
0068CAF18  ldrb     w8, [x20, #0x31d]
0068CAF1C  ldr      x21, [x21, #0x288]
0068CAF20  mov      x19, x0
0068CAF24  tbnz     w8, #0, #0x68caf3c
0068CAF28  adrp     x0, #0x8f28000
0068CAF2C  ldr      x0, [x0, #0x288]
0068CAF30  bl       #0x382bd14 ; 
0068CAF34  mov      w8, #1
0068CAF38  strb     w8, [x20, #0x31d]
0068CAF3C  ldr      x1, [x21]
0068CAF40  ldrb     w8, [x1, #0x53]
0068CAF44  tbnz     w8, #5, #0x68caf94
0068CAF48  mov      x0, x19
0068CAF4C  mov      x1, xzr
0068CAF50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CAF54  adrp     x21, #0x959c000
0068CAF58  ldrb     w8, [x21, #0x719]
0068CAF5C  mov      w20, w0
0068CAF60  cbnz     w8, #0x68caf78
0068CAF64  adrp     x0, #0x8f28000
0068CAF68  ldr      x0, [x0, #0x250]
0068CAF6C  bl       #0x382bd14 ; 
0068CAF70  mov      w8, #1
0068CAF74  strb     w8, [x21, #0x719]
0068CAF78  adrp     x8, #0x8f28000
0068CAF7C  ldr      x8, [x8, #0x250]
0068CAF80  ldr      x2, [x8]
0068CAF84  ldrb     w8, [x2, #0x53]
0068CAF88  tbnz     w8, #5, #0x68cafa8
0068CAF8C  str      w20, [x19, #0x20]
0068CAF90  b        #0x68cafb8 ; 
0068CAF94  ldr      x2, [x1, #0x60]
0068CAF98  mov      x0, x19
0068CAF9C  ldp      x20, x19, [sp, #0x10]
0068CAFA0  ldp      x30, x21, [sp], #0x20
0068CAFA4  br       x2
0068CAFA8  ldr      x8, [x2, #0x60]
0068CAFAC  mov      x0, x19
0068CAFB0  mov      w1, w20
0068CAFB4  blr      x8
0068CAFB8  mov      x0, x19
0068CAFBC  mov      x1, xzr
0068CAFC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CAFC4  adrp     x21, #0x959c000
0068CAFC8  ldrb     w8, [x21, #0x71a]
0068CAFCC  mov      w20, w0
0068CAFD0  cbnz     w8, #0x68cafe8
0068CAFD4  adrp     x0, #0x8f28000
0068CAFD8  ldr      x0, [x0, #0x260]
0068CAFDC  bl       #0x382bd14 ; 
0068CAFE0  mov      w8, #1
0068CAFE4  strb     w8, [x21, #0x71a]
0068CAFE8  adrp     x8, #0x8f28000
0068CAFEC  ldr      x8, [x8, #0x260]
0068CAFF0  ldr      x2, [x8]
0068CAFF4  ldrb     w8, [x2, #0x53]
0068CAFF8  tbnz     w8, #5, #0x68cb004
0068CAFFC  str      w20, [x19, #0x24]
0068CB000  b        #0x68cb014 ; 
0068CB004  ldr      x8, [x2, #0x60]
0068CB008  mov      x0, x19
0068CB00C  mov      w1, w20
0068CB010  blr      x8
0068CB014  mov      x0, x19
0068CB018  mov      x1, xzr
0068CB01C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CB020  adrp     x21, #0x959c000
0068CB024  ldrb     w8, [x21, #0x71b]
0068CB028  mov      x20, x0
0068CB02C  cbnz     w8, #0x68cb044
0068CB030  adrp     x0, #0x8f28000
0068CB034  ldr      x0, [x0, #0x270]
0068CB038  bl       #0x382bd14 ; 
0068CB03C  mov      w8, #1
0068CB040  strb     w8, [x21, #0x71b]
0068CB044  adrp     x8, #0x8f28000
0068CB048  ldr      x8, [x8, #0x270]
0068CB04C  ldr      x2, [x8]
0068CB050  ldrb     w8, [x2, #0x53]
0068CB054  tbnz     w8, #5, #0x68cb06c
0068CB058  mov      x0, x19
0068CB05C  str      x20, [x0, #0x28]!
0068CB060  mov      x1, x20
0068CB064  bl       #0x382bcb8 ; 
0068CB068  b        #0x68cb07c ; 
0068CB06C  ldr      x8, [x2, #0x60]
0068CB070  mov      x0, x19
0068CB074  mov      x1, x20
0068CB078  blr      x8
0068CB07C  mov      x0, x19
0068CB080  mov      x1, xzr
0068CB084  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068CB088  adrp     x21, #0x959c000
0068CB08C  ldrb     w8, [x21, #0x71c]
0068CB090  mov      x20, x0
0068CB094  cbnz     w8, #0x68cb0ac
0068CB098  adrp     x0, #0x8f28000
0068CB09C  ldr      x0, [x0, #0x280]
0068CB0A0  bl       #0x382bd14 ; 
0068CB0A4  mov      w8, #1
0068CB0A8  strb     w8, [x21, #0x71c]
0068CB0AC  adrp     x8, #0x8f28000
0068CB0B0  ldr      x8, [x8, #0x280]
0068CB0B4  ldr      x2, [x8]
0068CB0B8  ldrb     w8, [x2, #0x53]
0068CB0BC  tbnz     w8, #5, #0x68cb0d4
0068CB0C0  str      x20, [x19, #0x30]!
0068CB0C4  mov      x0, x19
0068CB0C8  mov      x1, x20
0068CB0CC  bl       #0x382bcb8 ; 
0068CB0D0  b        #0x68cb0e4 ; 
0068CB0D4  ldr      x8, [x2, #0x60]
0068CB0D8  mov      x0, x19
0068CB0DC  mov      x1, x20
0068CB0E0  blr      x8
0068CB0E4  ldp      x20, x19, [sp, #0x10]
0068CB0E8  mov      w0, #1
0068CB0EC  ldp      x30, x21, [sp], #0x20
0068CB0F0  ret      

