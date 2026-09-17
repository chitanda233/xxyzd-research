; LocalModels.Bean.IAP_BattlePassReward$$readImpl
; RVA 0x6A9C4A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A9C4A4  stp      x30, x21, [sp, #-0x20]!
006A9C4A8  stp      x20, x19, [sp, #0x10]
006A9C4AC  adrp     x20, #0x959e000
006A9C4B0  adrp     x21, #0x8f39000
006A9C4B4  ldrb     w8, [x20, #0x230]
006A9C4B8  ldr      x21, [x21, #0x720]
006A9C4BC  mov      x19, x0
006A9C4C0  tbnz     w8, #0, #0x6a9c4d8
006A9C4C4  adrp     x0, #0x8f39000
006A9C4C8  ldr      x0, [x0, #0x720]
006A9C4CC  bl       #0x382bd14 ; 
006A9C4D0  mov      w8, #1
006A9C4D4  strb     w8, [x20, #0x230]
006A9C4D8  ldr      x1, [x21]
006A9C4DC  ldrb     w8, [x1, #0x53]
006A9C4E0  tbnz     w8, #5, #0x6a9c530
006A9C4E4  mov      x0, x19
006A9C4E8  mov      x1, xzr
006A9C4EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9C4F0  adrp     x21, #0x959e000
006A9C4F4  ldrb     w8, [x21, #0x629]
006A9C4F8  mov      w20, w0
006A9C4FC  cbnz     w8, #0x6a9c514
006A9C500  adrp     x0, #0x8f39000
006A9C504  ldr      x0, [x0, #0x6b8]
006A9C508  bl       #0x382bd14 ; 
006A9C50C  mov      w8, #1
006A9C510  strb     w8, [x21, #0x629]
006A9C514  adrp     x8, #0x8f39000
006A9C518  ldr      x8, [x8, #0x6b8]
006A9C51C  ldr      x2, [x8]
006A9C520  ldrb     w8, [x2, #0x53]
006A9C524  tbnz     w8, #5, #0x6a9c544
006A9C528  str      w20, [x19, #0x20]
006A9C52C  b        #0x6a9c554 ; 
006A9C530  ldr      x2, [x1, #0x60]
006A9C534  mov      x0, x19
006A9C538  ldp      x20, x19, [sp, #0x10]
006A9C53C  ldp      x30, x21, [sp], #0x20
006A9C540  br       x2
006A9C544  ldr      x8, [x2, #0x60]
006A9C548  mov      x0, x19
006A9C54C  mov      w1, w20
006A9C550  blr      x8
006A9C554  mov      x0, x19
006A9C558  mov      x1, xzr
006A9C55C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9C560  adrp     x21, #0x959e000
006A9C564  ldrb     w8, [x21, #0x62a]
006A9C568  mov      w20, w0
006A9C56C  cbnz     w8, #0x6a9c584
006A9C570  adrp     x0, #0x8f39000
006A9C574  ldr      x0, [x0, #0x6c8]
006A9C578  bl       #0x382bd14 ; 
006A9C57C  mov      w8, #1
006A9C580  strb     w8, [x21, #0x62a]
006A9C584  adrp     x8, #0x8f39000
006A9C588  ldr      x8, [x8, #0x6c8]
006A9C58C  ldr      x2, [x8]
006A9C590  ldrb     w8, [x2, #0x53]
006A9C594  tbnz     w8, #5, #0x6a9c5a0
006A9C598  str      w20, [x19, #0x24]
006A9C59C  b        #0x6a9c5b0 ; 
006A9C5A0  ldr      x8, [x2, #0x60]
006A9C5A4  mov      x0, x19
006A9C5A8  mov      w1, w20
006A9C5AC  blr      x8
006A9C5B0  mov      x0, x19
006A9C5B4  mov      x1, xzr
006A9C5B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9C5BC  adrp     x21, #0x959e000
006A9C5C0  ldrb     w8, [x21, #0x62b]
006A9C5C4  mov      w20, w0
006A9C5C8  cbnz     w8, #0x6a9c5e0
006A9C5CC  adrp     x0, #0x8f39000
006A9C5D0  ldr      x0, [x0, #0x6d8]
006A9C5D4  bl       #0x382bd14 ; 
006A9C5D8  mov      w8, #1
006A9C5DC  strb     w8, [x21, #0x62b]
006A9C5E0  adrp     x8, #0x8f39000
006A9C5E4  ldr      x8, [x8, #0x6d8]
006A9C5E8  ldr      x2, [x8]
006A9C5EC  ldrb     w8, [x2, #0x53]
006A9C5F0  tbnz     w8, #5, #0x6a9c5fc
006A9C5F4  str      w20, [x19, #0x28]
006A9C5F8  b        #0x6a9c60c ; 
006A9C5FC  ldr      x8, [x2, #0x60]
006A9C600  mov      x0, x19
006A9C604  mov      w1, w20
006A9C608  blr      x8
006A9C60C  mov      x0, x19
006A9C610  mov      x1, xzr
006A9C614  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9C618  adrp     x21, #0x959e000
006A9C61C  ldrb     w8, [x21, #0x62c]
006A9C620  mov      w20, w0
006A9C624  cbnz     w8, #0x6a9c63c
006A9C628  adrp     x0, #0x8f39000
006A9C62C  ldr      x0, [x0, #0x6e8]
006A9C630  bl       #0x382bd14 ; 
006A9C634  mov      w8, #1
006A9C638  strb     w8, [x21, #0x62c]
006A9C63C  adrp     x8, #0x8f39000
006A9C640  ldr      x8, [x8, #0x6e8]
006A9C644  ldr      x2, [x8]
006A9C648  ldrb     w8, [x2, #0x53]
006A9C64C  tbnz     w8, #5, #0x6a9c658
006A9C650  str      w20, [x19, #0x2c]
006A9C654  b        #0x6a9c668 ; 
006A9C658  ldr      x8, [x2, #0x60]
006A9C65C  mov      x0, x19
006A9C660  mov      w1, w20
006A9C664  blr      x8
006A9C668  mov      x0, x19
006A9C66C  mov      x1, xzr
006A9C670  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A9C674  adrp     x21, #0x959e000
006A9C678  ldrb     w8, [x21, #0x62d]
006A9C67C  mov      x20, x0
006A9C680  cbnz     w8, #0x6a9c698
006A9C684  adrp     x0, #0x8f39000
006A9C688  ldr      x0, [x0, #0x6f8]
006A9C68C  bl       #0x382bd14 ; 
006A9C690  mov      w8, #1
006A9C694  strb     w8, [x21, #0x62d]
006A9C698  adrp     x8, #0x8f39000
006A9C69C  ldr      x8, [x8, #0x6f8]
006A9C6A0  ldr      x2, [x8]
006A9C6A4  ldrb     w8, [x2, #0x53]
006A9C6A8  tbnz     w8, #5, #0x6a9c6c0
006A9C6AC  mov      x0, x19
006A9C6B0  str      x20, [x0, #0x30]!
006A9C6B4  mov      x1, x20
006A9C6B8  bl       #0x382bcb8 ; 
006A9C6BC  b        #0x6a9c6d0 ; 
006A9C6C0  ldr      x8, [x2, #0x60]
006A9C6C4  mov      x0, x19
006A9C6C8  mov      x1, x20
006A9C6CC  blr      x8
006A9C6D0  mov      x0, x19
006A9C6D4  mov      x1, xzr
006A9C6D8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A9C6DC  adrp     x21, #0x959e000
006A9C6E0  ldrb     w8, [x21, #0x62e]
006A9C6E4  mov      x20, x0
006A9C6E8  cbnz     w8, #0x6a9c700
006A9C6EC  adrp     x0, #0x8f39000
006A9C6F0  ldr      x0, [x0, #0x708]
006A9C6F4  bl       #0x382bd14 ; 
006A9C6F8  mov      w8, #1
006A9C6FC  strb     w8, [x21, #0x62e]
006A9C700  adrp     x8, #0x8f39000
006A9C704  ldr      x8, [x8, #0x708]
006A9C708  ldr      x2, [x8]
006A9C70C  ldrb     w8, [x2, #0x53]
006A9C710  tbnz     w8, #5, #0x6a9c728
006A9C714  mov      x0, x19
006A9C718  str      x20, [x0, #0x38]!
006A9C71C  mov      x1, x20
006A9C720  bl       #0x382bcb8 ; 
006A9C724  b        #0x6a9c738 ; 
006A9C728  ldr      x8, [x2, #0x60]
006A9C72C  mov      x0, x19
006A9C730  mov      x1, x20
006A9C734  blr      x8
006A9C738  mov      x0, x19
006A9C73C  mov      x1, xzr
006A9C740  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A9C744  adrp     x21, #0x959e000
006A9C748  ldrb     w8, [x21, #0x62f]
006A9C74C  mov      x20, x0
006A9C750  cbnz     w8, #0x6a9c768
006A9C754  adrp     x0, #0x8f39000
006A9C758  ldr      x0, [x0, #0x718]
006A9C75C  bl       #0x382bd14 ; 
006A9C760  mov      w8, #1
006A9C764  strb     w8, [x21, #0x62f]
006A9C768  adrp     x8, #0x8f39000
006A9C76C  ldr      x8, [x8, #0x718]
006A9C770  ldr      x2, [x8]
006A9C774  ldrb     w8, [x2, #0x53]
006A9C778  tbnz     w8, #5, #0x6a9c790
006A9C77C  str      x20, [x19, #0x40]!
006A9C780  mov      x0, x19
006A9C784  mov      x1, x20
006A9C788  bl       #0x382bcb8 ; 
006A9C78C  b        #0x6a9c7a0 ; 
006A9C790  ldr      x8, [x2, #0x60]
006A9C794  mov      x0, x19
006A9C798  mov      x1, x20
006A9C79C  blr      x8
006A9C7A0  ldp      x20, x19, [sp, #0x10]
006A9C7A4  mov      w0, #1
006A9C7A8  ldp      x30, x21, [sp], #0x20
006A9C7AC  ret      

