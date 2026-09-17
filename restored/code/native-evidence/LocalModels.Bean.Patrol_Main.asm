; LocalModels.Bean.Patrol_Main$$readImpl
; RVA 0x6ACDCF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACDCF0  stp      x30, x21, [sp, #-0x20]!
006ACDCF4  stp      x20, x19, [sp, #0x10]
006ACDCF8  adrp     x20, #0x959e000
006ACDCFC  adrp     x21, #0x8f3b000
006ACDD00  ldrb     w8, [x20, #0xacd]
006ACDD04  ldr      x21, [x21, #0xbe0]
006ACDD08  mov      x19, x0
006ACDD0C  tbnz     w8, #0, #0x6acdd24
006ACDD10  adrp     x0, #0x8f3b000
006ACDD14  ldr      x0, [x0, #0xbe0]
006ACDD18  bl       #0x382bd14 ; 
006ACDD1C  mov      w8, #1
006ACDD20  strb     w8, [x20, #0xacd]
006ACDD24  ldr      x1, [x21]
006ACDD28  ldrb     w8, [x1, #0x53]
006ACDD2C  tbnz     w8, #5, #0x6acdd7c
006ACDD30  mov      x0, x19
006ACDD34  mov      x1, xzr
006ACDD38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACDD3C  adrp     x21, #0x959f000
006ACDD40  ldrb     w8, [x21, #0xc6]
006ACDD44  mov      w20, w0
006ACDD48  cbnz     w8, #0x6acdd60
006ACDD4C  adrp     x0, #0x8f3b000
006ACDD50  ldr      x0, [x0, #0xb98]
006ACDD54  bl       #0x382bd14 ; 
006ACDD58  mov      w8, #1
006ACDD5C  strb     w8, [x21, #0xc6]
006ACDD60  adrp     x8, #0x8f3b000
006ACDD64  ldr      x8, [x8, #0xb98]
006ACDD68  ldr      x2, [x8]
006ACDD6C  ldrb     w8, [x2, #0x53]
006ACDD70  tbnz     w8, #5, #0x6acdd90
006ACDD74  str      w20, [x19, #0x20]
006ACDD78  b        #0x6acdda0 ; 
006ACDD7C  ldr      x2, [x1, #0x60]
006ACDD80  mov      x0, x19
006ACDD84  ldp      x20, x19, [sp, #0x10]
006ACDD88  ldp      x30, x21, [sp], #0x20
006ACDD8C  br       x2
006ACDD90  ldr      x8, [x2, #0x60]
006ACDD94  mov      x0, x19
006ACDD98  mov      w1, w20
006ACDD9C  blr      x8
006ACDDA0  mov      x0, x19
006ACDDA4  mov      x1, xzr
006ACDDA8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ACDDAC  adrp     x21, #0x959f000
006ACDDB0  ldrb     w8, [x21, #0xc7]
006ACDDB4  mov      x20, x0
006ACDDB8  cbnz     w8, #0x6acddd0
006ACDDBC  adrp     x0, #0x8f3b000
006ACDDC0  ldr      x0, [x0, #0xba8]
006ACDDC4  bl       #0x382bd14 ; 
006ACDDC8  mov      w8, #1
006ACDDCC  strb     w8, [x21, #0xc7]
006ACDDD0  adrp     x8, #0x8f3b000
006ACDDD4  ldr      x8, [x8, #0xba8]
006ACDDD8  ldr      x2, [x8]
006ACDDDC  ldrb     w8, [x2, #0x53]
006ACDDE0  tbnz     w8, #5, #0x6acddf8
006ACDDE4  mov      x0, x19
006ACDDE8  str      x20, [x0, #0x28]!
006ACDDEC  mov      x1, x20
006ACDDF0  bl       #0x382bcb8 ; 
006ACDDF4  b        #0x6acde08 ; 
006ACDDF8  ldr      x8, [x2, #0x60]
006ACDDFC  mov      x0, x19
006ACDE00  mov      x1, x20
006ACDE04  blr      x8
006ACDE08  mov      x0, x19
006ACDE0C  mov      x1, xzr
006ACDE10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACDE14  adrp     x21, #0x959f000
006ACDE18  ldrb     w8, [x21, #0xc8]
006ACDE1C  mov      w20, w0
006ACDE20  cbnz     w8, #0x6acde38
006ACDE24  adrp     x0, #0x8f3b000
006ACDE28  ldr      x0, [x0, #0xbb8]
006ACDE2C  bl       #0x382bd14 ; 
006ACDE30  mov      w8, #1
006ACDE34  strb     w8, [x21, #0xc8]
006ACDE38  adrp     x8, #0x8f3b000
006ACDE3C  ldr      x8, [x8, #0xbb8]
006ACDE40  ldr      x2, [x8]
006ACDE44  ldrb     w8, [x2, #0x53]
006ACDE48  tbnz     w8, #5, #0x6acde54
006ACDE4C  str      w20, [x19, #0x30]
006ACDE50  b        #0x6acde64 ; 
006ACDE54  ldr      x8, [x2, #0x60]
006ACDE58  mov      x0, x19
006ACDE5C  mov      w1, w20
006ACDE60  blr      x8
006ACDE64  mov      x0, x19
006ACDE68  mov      x1, xzr
006ACDE6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACDE70  adrp     x21, #0x959f000
006ACDE74  ldrb     w8, [x21, #0xc9]
006ACDE78  mov      w20, w0
006ACDE7C  cbnz     w8, #0x6acde94
006ACDE80  adrp     x0, #0x8f3b000
006ACDE84  ldr      x0, [x0, #0xbc8]
006ACDE88  bl       #0x382bd14 ; 
006ACDE8C  mov      w8, #1
006ACDE90  strb     w8, [x21, #0xc9]
006ACDE94  adrp     x8, #0x8f3b000
006ACDE98  ldr      x8, [x8, #0xbc8]
006ACDE9C  ldr      x2, [x8]
006ACDEA0  ldrb     w8, [x2, #0x53]
006ACDEA4  tbnz     w8, #5, #0x6acdeb0
006ACDEA8  str      w20, [x19, #0x34]
006ACDEAC  b        #0x6acdec0 ; 
006ACDEB0  ldr      x8, [x2, #0x60]
006ACDEB4  mov      x0, x19
006ACDEB8  mov      w1, w20
006ACDEBC  blr      x8
006ACDEC0  mov      x0, x19
006ACDEC4  mov      x1, xzr
006ACDEC8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006ACDECC  adrp     x21, #0x959f000
006ACDED0  ldrb     w8, [x21, #0xca]
006ACDED4  mov      x20, x0
006ACDED8  cbnz     w8, #0x6acdef0
006ACDEDC  adrp     x0, #0x8f3b000
006ACDEE0  ldr      x0, [x0, #0xbd8]
006ACDEE4  bl       #0x382bd14 ; 
006ACDEE8  mov      w8, #1
006ACDEEC  strb     w8, [x21, #0xca]
006ACDEF0  adrp     x8, #0x8f3b000
006ACDEF4  ldr      x8, [x8, #0xbd8]
006ACDEF8  ldr      x2, [x8]
006ACDEFC  ldrb     w8, [x2, #0x53]
006ACDF00  tbnz     w8, #5, #0x6acdf18
006ACDF04  str      x20, [x19, #0x38]!
006ACDF08  mov      x0, x19
006ACDF0C  mov      x1, x20
006ACDF10  bl       #0x382bcb8 ; 
006ACDF14  b        #0x6acdf28 ; 
006ACDF18  ldr      x8, [x2, #0x60]
006ACDF1C  mov      x0, x19
006ACDF20  mov      x1, x20
006ACDF24  blr      x8
006ACDF28  ldp      x20, x19, [sp, #0x10]
006ACDF2C  mov      w0, #1
006ACDF30  ldp      x30, x21, [sp], #0x20
006ACDF34  ret      

