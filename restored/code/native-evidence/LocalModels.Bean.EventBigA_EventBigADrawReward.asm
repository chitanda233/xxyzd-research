; LocalModels.Bean.EventBigA_EventBigADrawReward$$readImpl
; RVA 0x6A69040; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A69040  stp      x30, x21, [sp, #-0x20]!
006A69044  stp      x20, x19, [sp, #0x10]
006A69048  adrp     x20, #0x959d000
006A6904C  adrp     x21, #0x8f36000
006A69050  ldrb     w8, [x20, #0xcd2]
006A69054  ldr      x21, [x21, #0xfd8]
006A69058  mov      x19, x0
006A6905C  tbnz     w8, #0, #0x6a69074
006A69060  adrp     x0, #0x8f36000
006A69064  ldr      x0, [x0, #0xfd8]
006A69068  bl       #0x382bd14 ; 
006A6906C  mov      w8, #1
006A69070  strb     w8, [x20, #0xcd2]
006A69074  ldr      x1, [x21]
006A69078  ldrb     w8, [x1, #0x53]
006A6907C  tbnz     w8, #5, #0x6a690cc
006A69080  mov      x0, x19
006A69084  mov      x1, xzr
006A69088  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6908C  adrp     x21, #0x959e000
006A69090  ldrb     w8, [x21, #0x405]
006A69094  mov      w20, w0
006A69098  cbnz     w8, #0x6a690b0
006A6909C  adrp     x0, #0x8f36000
006A690A0  ldr      x0, [x0, #0xfb0]
006A690A4  bl       #0x382bd14 ; 
006A690A8  mov      w8, #1
006A690AC  strb     w8, [x21, #0x405]
006A690B0  adrp     x8, #0x8f36000
006A690B4  ldr      x8, [x8, #0xfb0]
006A690B8  ldr      x2, [x8]
006A690BC  ldrb     w8, [x2, #0x53]
006A690C0  tbnz     w8, #5, #0x6a690e0
006A690C4  str      w20, [x19, #0x20]
006A690C8  b        #0x6a690f0 ; 
006A690CC  ldr      x2, [x1, #0x60]
006A690D0  mov      x0, x19
006A690D4  ldp      x20, x19, [sp, #0x10]
006A690D8  ldp      x30, x21, [sp], #0x20
006A690DC  br       x2
006A690E0  ldr      x8, [x2, #0x60]
006A690E4  mov      x0, x19
006A690E8  mov      w1, w20
006A690EC  blr      x8
006A690F0  mov      x0, x19
006A690F4  mov      x1, xzr
006A690F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A690FC  adrp     x21, #0x959e000
006A69100  ldrb     w8, [x21, #0x406]
006A69104  mov      w20, w0
006A69108  cbnz     w8, #0x6a69120
006A6910C  adrp     x0, #0x8f36000
006A69110  ldr      x0, [x0, #0xfc0]
006A69114  bl       #0x382bd14 ; 
006A69118  mov      w8, #1
006A6911C  strb     w8, [x21, #0x406]
006A69120  adrp     x8, #0x8f36000
006A69124  ldr      x8, [x8, #0xfc0]
006A69128  ldr      x2, [x8]
006A6912C  ldrb     w8, [x2, #0x53]
006A69130  tbnz     w8, #5, #0x6a6913c
006A69134  str      w20, [x19, #0x24]
006A69138  b        #0x6a6914c ; 
006A6913C  ldr      x8, [x2, #0x60]
006A69140  mov      x0, x19
006A69144  mov      w1, w20
006A69148  blr      x8
006A6914C  mov      x0, x19
006A69150  mov      x1, xzr
006A69154  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A69158  adrp     x21, #0x959e000
006A6915C  ldrb     w8, [x21, #0x407]
006A69160  mov      x20, x0
006A69164  cbnz     w8, #0x6a6917c
006A69168  adrp     x0, #0x8f36000
006A6916C  ldr      x0, [x0, #0xfd0]
006A69170  bl       #0x382bd14 ; 
006A69174  mov      w8, #1
006A69178  strb     w8, [x21, #0x407]
006A6917C  adrp     x8, #0x8f36000
006A69180  ldr      x8, [x8, #0xfd0]
006A69184  ldr      x2, [x8]
006A69188  ldrb     w8, [x2, #0x53]
006A6918C  tbnz     w8, #5, #0x6a691a4
006A69190  str      x20, [x19, #0x28]!
006A69194  mov      x0, x19
006A69198  mov      x1, x20
006A6919C  bl       #0x382bcb8 ; 
006A691A0  b        #0x6a691b4 ; 
006A691A4  ldr      x8, [x2, #0x60]
006A691A8  mov      x0, x19
006A691AC  mov      x1, x20
006A691B0  blr      x8
006A691B4  ldp      x20, x19, [sp, #0x10]
006A691B8  mov      w0, #1
006A691BC  ldp      x30, x21, [sp], #0x20
006A691C0  ret      

