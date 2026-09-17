; LocalModels.Bean.Task_ConditionType$$readImpl
; RVA 0x6B12678; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B12678  stp      x30, x21, [sp, #-0x20]!
006B1267C  stp      x20, x19, [sp, #0x10]
006B12680  adrp     x20, #0x959f000
006B12684  adrp     x21, #0x8f3e000
006B12688  ldrb     w8, [x20, #0x56a]
006B1268C  ldr      x21, [x21, #0xdc8]
006B12690  mov      x19, x0
006B12694  tbnz     w8, #0, #0x6b126ac
006B12698  adrp     x0, #0x8f3e000
006B1269C  ldr      x0, [x0, #0xdc8]
006B126A0  bl       #0x382bd14 ; 
006B126A4  mov      w8, #1
006B126A8  strb     w8, [x20, #0x56a]
006B126AC  ldr      x1, [x21]
006B126B0  ldrb     w8, [x1, #0x53]
006B126B4  tbnz     w8, #5, #0x6b12704
006B126B8  mov      x0, x19
006B126BC  mov      x1, xzr
006B126C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B126C4  adrp     x21, #0x959f000
006B126C8  ldrb     w8, [x21, #0x9bd]
006B126CC  mov      w20, w0
006B126D0  cbnz     w8, #0x6b126e8
006B126D4  adrp     x0, #0x8f3e000
006B126D8  ldr      x0, [x0, #0xdb0]
006B126DC  bl       #0x382bd14 ; 
006B126E0  mov      w8, #1
006B126E4  strb     w8, [x21, #0x9bd]
006B126E8  adrp     x8, #0x8f3e000
006B126EC  ldr      x8, [x8, #0xdb0]
006B126F0  ldr      x2, [x8]
006B126F4  ldrb     w8, [x2, #0x53]
006B126F8  tbnz     w8, #5, #0x6b12718
006B126FC  str      w20, [x19, #0x20]
006B12700  b        #0x6b12728 ; 
006B12704  ldr      x2, [x1, #0x60]
006B12708  mov      x0, x19
006B1270C  ldp      x20, x19, [sp, #0x10]
006B12710  ldp      x30, x21, [sp], #0x20
006B12714  br       x2
006B12718  ldr      x8, [x2, #0x60]
006B1271C  mov      x0, x19
006B12720  mov      w1, w20
006B12724  blr      x8
006B12728  mov      x0, x19
006B1272C  mov      x1, xzr
006B12730  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B12734  adrp     x21, #0x959f000
006B12738  ldrb     w8, [x21, #0x9be]
006B1273C  mov      w20, w0
006B12740  cbnz     w8, #0x6b12758
006B12744  adrp     x0, #0x8f3e000
006B12748  ldr      x0, [x0, #0xdc0]
006B1274C  bl       #0x382bd14 ; 
006B12750  mov      w8, #1
006B12754  strb     w8, [x21, #0x9be]
006B12758  adrp     x8, #0x8f3e000
006B1275C  ldr      x8, [x8, #0xdc0]
006B12760  ldr      x2, [x8]
006B12764  ldrb     w8, [x2, #0x53]
006B12768  tbnz     w8, #5, #0x6b12774
006B1276C  str      w20, [x19, #0x24]
006B12770  b        #0x6b12784 ; 
006B12774  ldr      x8, [x2, #0x60]
006B12778  mov      x0, x19
006B1277C  mov      w1, w20
006B12780  blr      x8
006B12784  ldp      x20, x19, [sp, #0x10]
006B12788  mov      w0, #1
006B1278C  ldp      x30, x21, [sp], #0x20
006B12790  ret      

