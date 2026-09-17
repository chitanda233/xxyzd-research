; LocalModels.Bean.EventBigA_EventBigASignIn$$readImpl
; RVA 0x6A69574; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A69574  stp      x30, x21, [sp, #-0x20]!
006A69578  stp      x20, x19, [sp, #0x10]
006A6957C  adrp     x20, #0x959d000
006A69580  adrp     x21, #0x8f37000
006A69584  ldrb     w8, [x20, #0xcdb]
006A69588  ldr      x21, [x21, #0x18]
006A6958C  mov      x19, x0
006A69590  tbnz     w8, #0, #0x6a695a8
006A69594  adrp     x0, #0x8f37000
006A69598  ldr      x0, [x0, #0x18]
006A6959C  bl       #0x382bd14 ; 
006A695A0  mov      w8, #1
006A695A4  strb     w8, [x20, #0xcdb]
006A695A8  ldr      x1, [x21]
006A695AC  ldrb     w8, [x1, #0x53]
006A695B0  tbnz     w8, #5, #0x6a69600
006A695B4  mov      x0, x19
006A695B8  mov      x1, xzr
006A695BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A695C0  adrp     x21, #0x959e000
006A695C4  ldrb     w8, [x21, #0x408]
006A695C8  mov      w20, w0
006A695CC  cbnz     w8, #0x6a695e4
006A695D0  adrp     x0, #0x8f36000
006A695D4  ldr      x0, [x0, #0xff0]
006A695D8  bl       #0x382bd14 ; 
006A695DC  mov      w8, #1
006A695E0  strb     w8, [x21, #0x408]
006A695E4  adrp     x8, #0x8f36000
006A695E8  ldr      x8, [x8, #0xff0]
006A695EC  ldr      x2, [x8]
006A695F0  ldrb     w8, [x2, #0x53]
006A695F4  tbnz     w8, #5, #0x6a69614
006A695F8  str      w20, [x19, #0x20]
006A695FC  b        #0x6a69624 ; 
006A69600  ldr      x2, [x1, #0x60]
006A69604  mov      x0, x19
006A69608  ldp      x20, x19, [sp, #0x10]
006A6960C  ldp      x30, x21, [sp], #0x20
006A69610  br       x2
006A69614  ldr      x8, [x2, #0x60]
006A69618  mov      x0, x19
006A6961C  mov      w1, w20
006A69620  blr      x8
006A69624  mov      x0, x19
006A69628  mov      x1, xzr
006A6962C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A69630  adrp     x21, #0x959e000
006A69634  ldrb     w8, [x21, #0x409]
006A69638  mov      x20, x0
006A6963C  cbnz     w8, #0x6a69654
006A69640  adrp     x0, #0x8f37000
006A69644  ldr      x0, [x0]
006A69648  bl       #0x382bd14 ; 
006A6964C  mov      w8, #1
006A69650  strb     w8, [x21, #0x409]
006A69654  adrp     x8, #0x8f37000
006A69658  ldr      x8, [x8]
006A6965C  ldr      x2, [x8]
006A69660  ldrb     w8, [x2, #0x53]
006A69664  tbnz     w8, #5, #0x6a6967c
006A69668  mov      x0, x19
006A6966C  str      x20, [x0, #0x28]!
006A69670  mov      x1, x20
006A69674  bl       #0x382bcb8 ; 
006A69678  b        #0x6a6968c ; 
006A6967C  ldr      x8, [x2, #0x60]
006A69680  mov      x0, x19
006A69684  mov      x1, x20
006A69688  blr      x8
006A6968C  mov      x0, x19
006A69690  mov      x1, xzr
006A69694  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A69698  adrp     x21, #0x959e000
006A6969C  ldrb     w8, [x21, #0x40a]
006A696A0  mov      w20, w0
006A696A4  cbnz     w8, #0x6a696bc
006A696A8  adrp     x0, #0x8f37000
006A696AC  ldr      x0, [x0, #0x10]
006A696B0  bl       #0x382bd14 ; 
006A696B4  mov      w8, #1
006A696B8  strb     w8, [x21, #0x40a]
006A696BC  adrp     x8, #0x8f37000
006A696C0  ldr      x8, [x8, #0x10]
006A696C4  ldr      x2, [x8]
006A696C8  ldrb     w8, [x2, #0x53]
006A696CC  tbnz     w8, #5, #0x6a696d8
006A696D0  str      w20, [x19, #0x30]
006A696D4  b        #0x6a696e8 ; 
006A696D8  ldr      x8, [x2, #0x60]
006A696DC  mov      x0, x19
006A696E0  mov      w1, w20
006A696E4  blr      x8
006A696E8  ldp      x20, x19, [sp, #0x10]
006A696EC  mov      w0, #1
006A696F0  ldp      x30, x21, [sp], #0x20
006A696F4  ret      

