; LocalModels.Bean.Collection_TreasureSuit$$readImpl
; RVA 0x68CE96C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CE96C  stp      x30, x21, [sp, #-0x20]!
0068CE970  stp      x20, x19, [sp, #0x10]
0068CE974  adrp     x20, #0x959c000
0068CE978  adrp     x21, #0x8f28000
0068CE97C  ldrb     w8, [x20, #0x380]
0068CE980  ldr      x21, [x21, #0x578]
0068CE984  mov      x19, x0
0068CE988  tbnz     w8, #0, #0x68ce9a0
0068CE98C  adrp     x0, #0x8f28000
0068CE990  ldr      x0, [x0, #0x578]
0068CE994  bl       #0x382bd14 ; 
0068CE998  mov      w8, #1
0068CE99C  strb     w8, [x20, #0x380]
0068CE9A0  ldr      x1, [x21]
0068CE9A4  ldrb     w8, [x1, #0x53]
0068CE9A8  tbnz     w8, #5, #0x68ce9f8
0068CE9AC  mov      x0, x19
0068CE9B0  mov      x1, xzr
0068CE9B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CE9B8  adrp     x21, #0x959c000
0068CE9BC  ldrb     w8, [x21, #0x740]
0068CE9C0  mov      w20, w0
0068CE9C4  cbnz     w8, #0x68ce9dc
0068CE9C8  adrp     x0, #0x8f28000
0068CE9CC  ldr      x0, [x0, #0x510]
0068CE9D0  bl       #0x382bd14 ; 
0068CE9D4  mov      w8, #1
0068CE9D8  strb     w8, [x21, #0x740]
0068CE9DC  adrp     x8, #0x8f28000
0068CE9E0  ldr      x8, [x8, #0x510]
0068CE9E4  ldr      x2, [x8]
0068CE9E8  ldrb     w8, [x2, #0x53]
0068CE9EC  tbnz     w8, #5, #0x68cea0c
0068CE9F0  str      w20, [x19, #0x20]
0068CE9F4  b        #0x68cea1c ; 
0068CE9F8  ldr      x2, [x1, #0x60]
0068CE9FC  mov      x0, x19
0068CEA00  ldp      x20, x19, [sp, #0x10]
0068CEA04  ldp      x30, x21, [sp], #0x20
0068CEA08  br       x2
0068CEA0C  ldr      x8, [x2, #0x60]
0068CEA10  mov      x0, x19
0068CEA14  mov      w1, w20
0068CEA18  blr      x8
0068CEA1C  mov      x0, x19
0068CEA20  mov      x1, xzr
0068CEA24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CEA28  adrp     x21, #0x959c000
0068CEA2C  ldrb     w8, [x21, #0x741]
0068CEA30  mov      w20, w0
0068CEA34  cbnz     w8, #0x68cea4c
0068CEA38  adrp     x0, #0x8f28000
0068CEA3C  ldr      x0, [x0, #0x520]
0068CEA40  bl       #0x382bd14 ; 
0068CEA44  mov      w8, #1
0068CEA48  strb     w8, [x21, #0x741]
0068CEA4C  adrp     x8, #0x8f28000
0068CEA50  ldr      x8, [x8, #0x520]
0068CEA54  ldr      x2, [x8]
0068CEA58  ldrb     w8, [x2, #0x53]
0068CEA5C  tbnz     w8, #5, #0x68cea68
0068CEA60  str      w20, [x19, #0x24]
0068CEA64  b        #0x68cea78 ; 
0068CEA68  ldr      x8, [x2, #0x60]
0068CEA6C  mov      x0, x19
0068CEA70  mov      w1, w20
0068CEA74  blr      x8
0068CEA78  mov      x0, x19
0068CEA7C  mov      x1, xzr
0068CEA80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CEA84  adrp     x21, #0x959c000
0068CEA88  ldrb     w8, [x21, #0x742]
0068CEA8C  mov      w20, w0
0068CEA90  cbnz     w8, #0x68ceaa8
0068CEA94  adrp     x0, #0x8f28000
0068CEA98  ldr      x0, [x0, #0x530]
0068CEA9C  bl       #0x382bd14 ; 
0068CEAA0  mov      w8, #1
0068CEAA4  strb     w8, [x21, #0x742]
0068CEAA8  adrp     x8, #0x8f28000
0068CEAAC  ldr      x8, [x8, #0x530]
0068CEAB0  ldr      x2, [x8]
0068CEAB4  ldrb     w8, [x2, #0x53]
0068CEAB8  tbnz     w8, #5, #0x68ceac4
0068CEABC  str      w20, [x19, #0x28]
0068CEAC0  b        #0x68cead4 ; 
0068CEAC4  ldr      x8, [x2, #0x60]
0068CEAC8  mov      x0, x19
0068CEACC  mov      w1, w20
0068CEAD0  blr      x8
0068CEAD4  mov      x0, x19
0068CEAD8  mov      x1, xzr
0068CEADC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CEAE0  adrp     x21, #0x959c000
0068CEAE4  ldrb     w8, [x21, #0x743]
0068CEAE8  mov      w20, w0
0068CEAEC  cbnz     w8, #0x68ceb04
0068CEAF0  adrp     x0, #0x8f28000
0068CEAF4  ldr      x0, [x0, #0x540]
0068CEAF8  bl       #0x382bd14 ; 
0068CEAFC  mov      w8, #1
0068CEB00  strb     w8, [x21, #0x743]
0068CEB04  adrp     x8, #0x8f28000
0068CEB08  ldr      x8, [x8, #0x540]
0068CEB0C  ldr      x2, [x8]
0068CEB10  ldrb     w8, [x2, #0x53]
0068CEB14  tbnz     w8, #5, #0x68ceb20
0068CEB18  str      w20, [x19, #0x2c]
0068CEB1C  b        #0x68ceb30 ; 
0068CEB20  ldr      x8, [x2, #0x60]
0068CEB24  mov      x0, x19
0068CEB28  mov      w1, w20
0068CEB2C  blr      x8
0068CEB30  mov      x0, x19
0068CEB34  mov      x1, xzr
0068CEB38  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068CEB3C  adrp     x21, #0x959c000
0068CEB40  ldrb     w8, [x21, #0x744]
0068CEB44  mov      x20, x0
0068CEB48  cbnz     w8, #0x68ceb60
0068CEB4C  adrp     x0, #0x8f28000
0068CEB50  ldr      x0, [x0, #0x550]
0068CEB54  bl       #0x382bd14 ; 
0068CEB58  mov      w8, #1
0068CEB5C  strb     w8, [x21, #0x744]
0068CEB60  adrp     x8, #0x8f28000
0068CEB64  ldr      x8, [x8, #0x550]
0068CEB68  ldr      x2, [x8]
0068CEB6C  ldrb     w8, [x2, #0x53]
0068CEB70  tbnz     w8, #5, #0x68ceb88
0068CEB74  mov      x0, x19
0068CEB78  str      x20, [x0, #0x30]!
0068CEB7C  mov      x1, x20
0068CEB80  bl       #0x382bcb8 ; 
0068CEB84  b        #0x68ceb98 ; 
0068CEB88  ldr      x8, [x2, #0x60]
0068CEB8C  mov      x0, x19
0068CEB90  mov      x1, x20
0068CEB94  blr      x8
0068CEB98  mov      x0, x19
0068CEB9C  mov      x1, xzr
0068CEBA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CEBA4  adrp     x21, #0x959c000
0068CEBA8  ldrb     w8, [x21, #0x745]
0068CEBAC  mov      w20, w0
0068CEBB0  cbnz     w8, #0x68cebc8
0068CEBB4  adrp     x0, #0x8f28000
0068CEBB8  ldr      x0, [x0, #0x560]
0068CEBBC  bl       #0x382bd14 ; 
0068CEBC0  mov      w8, #1
0068CEBC4  strb     w8, [x21, #0x745]
0068CEBC8  adrp     x8, #0x8f28000
0068CEBCC  ldr      x8, [x8, #0x560]
0068CEBD0  ldr      x2, [x8]
0068CEBD4  ldrb     w8, [x2, #0x53]
0068CEBD8  tbnz     w8, #5, #0x68cebe4
0068CEBDC  str      w20, [x19, #0x38]
0068CEBE0  b        #0x68cebf4 ; 
0068CEBE4  ldr      x8, [x2, #0x60]
0068CEBE8  mov      x0, x19
0068CEBEC  mov      w1, w20
0068CEBF0  blr      x8
0068CEBF4  mov      x0, x19
0068CEBF8  mov      x1, xzr
0068CEBFC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068CEC00  adrp     x21, #0x959c000
0068CEC04  ldrb     w8, [x21, #0x746]
0068CEC08  mov      x20, x0
0068CEC0C  cbnz     w8, #0x68cec24
0068CEC10  adrp     x0, #0x8f28000
0068CEC14  ldr      x0, [x0, #0x570]
0068CEC18  bl       #0x382bd14 ; 
0068CEC1C  mov      w8, #1
0068CEC20  strb     w8, [x21, #0x746]
0068CEC24  adrp     x8, #0x8f28000
0068CEC28  ldr      x8, [x8, #0x570]
0068CEC2C  ldr      x2, [x8]
0068CEC30  ldrb     w8, [x2, #0x53]
0068CEC34  tbnz     w8, #5, #0x68cec4c
0068CEC38  str      x20, [x19, #0x40]!
0068CEC3C  mov      x0, x19
0068CEC40  mov      x1, x20
0068CEC44  bl       #0x382bcb8 ; 
0068CEC48  b        #0x68cec5c ; 
0068CEC4C  ldr      x8, [x2, #0x60]
0068CEC50  mov      x0, x19
0068CEC54  mov      x1, x20
0068CEC58  blr      x8
0068CEC5C  ldp      x20, x19, [sp, #0x10]
0068CEC60  mov      w0, #1
0068CEC64  ldp      x30, x21, [sp], #0x20
0068CEC68  ret      

