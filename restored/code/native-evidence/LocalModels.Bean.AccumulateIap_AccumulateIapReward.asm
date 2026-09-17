; LocalModels.Bean.AccumulateIap_AccumulateIapReward$$readImpl
; RVA 0x66FCBA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066FCBA8  stp      x30, x21, [sp, #-0x20]!
0066FCBAC  stp      x20, x19, [sp, #0x10]
0066FCBB0  adrp     x20, #0x959a000
0066FCBB4  adrp     x21, #0x8f17000
0066FCBB8  ldrb     w8, [x20, #0x828]
0066FCBBC  ldr      x21, [x21, #0x390]
0066FCBC0  mov      x19, x0
0066FCBC4  tbnz     w8, #0, #0x66fcbdc
0066FCBC8  adrp     x0, #0x8f17000
0066FCBCC  ldr      x0, [x0, #0x390]
0066FCBD0  bl       #0x382bd14 ; 
0066FCBD4  mov      w8, #1
0066FCBD8  strb     w8, [x20, #0x828]
0066FCBDC  ldr      x1, [x21]
0066FCBE0  ldrb     w8, [x1, #0x53]
0066FCBE4  tbnz     w8, #5, #0x66fcc34
0066FCBE8  mov      x0, x19
0066FCBEC  mov      x1, xzr
0066FCBF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FCBF4  adrp     x21, #0x959a000
0066FCBF8  ldrb     w8, [x21, #0x929]
0066FCBFC  mov      w20, w0
0066FCC00  cbnz     w8, #0x66fcc18
0066FCC04  adrp     x0, #0x8f17000
0066FCC08  ldr      x0, [x0, #0x368]
0066FCC0C  bl       #0x382bd14 ; 
0066FCC10  mov      w8, #1
0066FCC14  strb     w8, [x21, #0x929]
0066FCC18  adrp     x8, #0x8f17000
0066FCC1C  ldr      x8, [x8, #0x368]
0066FCC20  ldr      x2, [x8]
0066FCC24  ldrb     w8, [x2, #0x53]
0066FCC28  tbnz     w8, #5, #0x66fcc48
0066FCC2C  str      w20, [x19, #0x20]
0066FCC30  b        #0x66fcc58 ; 
0066FCC34  ldr      x2, [x1, #0x60]
0066FCC38  mov      x0, x19
0066FCC3C  ldp      x20, x19, [sp, #0x10]
0066FCC40  ldp      x30, x21, [sp], #0x20
0066FCC44  br       x2
0066FCC48  ldr      x8, [x2, #0x60]
0066FCC4C  mov      x0, x19
0066FCC50  mov      w1, w20
0066FCC54  blr      x8
0066FCC58  mov      x0, x19
0066FCC5C  mov      x1, xzr
0066FCC60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FCC64  adrp     x21, #0x959a000
0066FCC68  ldrb     w8, [x21, #0x92a]
0066FCC6C  mov      w20, w0
0066FCC70  cbnz     w8, #0x66fcc88
0066FCC74  adrp     x0, #0x8f17000
0066FCC78  ldr      x0, [x0, #0x378]
0066FCC7C  bl       #0x382bd14 ; 
0066FCC80  mov      w8, #1
0066FCC84  strb     w8, [x21, #0x92a]
0066FCC88  adrp     x8, #0x8f17000
0066FCC8C  ldr      x8, [x8, #0x378]
0066FCC90  ldr      x2, [x8]
0066FCC94  ldrb     w8, [x2, #0x53]
0066FCC98  tbnz     w8, #5, #0x66fcca4
0066FCC9C  str      w20, [x19, #0x24]
0066FCCA0  b        #0x66fccb4 ; 
0066FCCA4  ldr      x8, [x2, #0x60]
0066FCCA8  mov      x0, x19
0066FCCAC  mov      w1, w20
0066FCCB0  blr      x8
0066FCCB4  mov      x0, x19
0066FCCB8  mov      x1, xzr
0066FCCBC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0066FCCC0  adrp     x21, #0x959a000
0066FCCC4  ldrb     w8, [x21, #0x92b]
0066FCCC8  mov      x20, x0
0066FCCCC  cbnz     w8, #0x66fcce4
0066FCCD0  adrp     x0, #0x8f17000
0066FCCD4  ldr      x0, [x0, #0x388]
0066FCCD8  bl       #0x382bd14 ; 
0066FCCDC  mov      w8, #1
0066FCCE0  strb     w8, [x21, #0x92b]
0066FCCE4  adrp     x8, #0x8f17000
0066FCCE8  ldr      x8, [x8, #0x388]
0066FCCEC  ldr      x2, [x8]
0066FCCF0  ldrb     w8, [x2, #0x53]
0066FCCF4  tbnz     w8, #5, #0x66fcd0c
0066FCCF8  str      x20, [x19, #0x28]!
0066FCCFC  mov      x0, x19
0066FCD00  mov      x1, x20
0066FCD04  bl       #0x382bcb8 ; 
0066FCD08  b        #0x66fcd1c ; 
0066FCD0C  ldr      x8, [x2, #0x60]
0066FCD10  mov      x0, x19
0066FCD14  mov      x1, x20
0066FCD18  blr      x8
0066FCD1C  ldp      x20, x19, [sp, #0x10]
0066FCD20  mov      w0, #1
0066FCD24  ldp      x30, x21, [sp], #0x20
0066FCD28  ret      

