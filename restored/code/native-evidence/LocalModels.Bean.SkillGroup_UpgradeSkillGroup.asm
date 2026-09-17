; LocalModels.Bean.SkillGroup_UpgradeSkillGroup$$readImpl
; RVA 0x6AFD834; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFD834  stp      x30, x21, [sp, #-0x20]!
006AFD838  stp      x20, x19, [sp, #0x10]
006AFD83C  adrp     x20, #0x959f000
006AFD840  adrp     x21, #0x8f3d000
006AFD844  ldrb     w8, [x20, #0x349]
006AFD848  ldr      x21, [x21, #0xfc0]
006AFD84C  mov      x19, x0
006AFD850  tbnz     w8, #0, #0x6afd868
006AFD854  adrp     x0, #0x8f3d000
006AFD858  ldr      x0, [x0, #0xfc0]
006AFD85C  bl       #0x382bd14 ; 
006AFD860  mov      w8, #1
006AFD864  strb     w8, [x20, #0x349]
006AFD868  ldr      x1, [x21]
006AFD86C  ldrb     w8, [x1, #0x53]
006AFD870  tbnz     w8, #5, #0x6afd8c0
006AFD874  mov      x0, x19
006AFD878  mov      x1, xzr
006AFD87C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFD880  adrp     x21, #0x959f000
006AFD884  ldrb     w8, [x21, #0x8c7]
006AFD888  mov      w20, w0
006AFD88C  cbnz     w8, #0x6afd8a4
006AFD890  adrp     x0, #0x8f3d000
006AFD894  ldr      x0, [x0, #0xfa8]
006AFD898  bl       #0x382bd14 ; 
006AFD89C  mov      w8, #1
006AFD8A0  strb     w8, [x21, #0x8c7]
006AFD8A4  adrp     x8, #0x8f3d000
006AFD8A8  ldr      x8, [x8, #0xfa8]
006AFD8AC  ldr      x2, [x8]
006AFD8B0  ldrb     w8, [x2, #0x53]
006AFD8B4  tbnz     w8, #5, #0x6afd8d4
006AFD8B8  str      w20, [x19, #0x20]
006AFD8BC  b        #0x6afd8e4 ; 
006AFD8C0  ldr      x2, [x1, #0x60]
006AFD8C4  mov      x0, x19
006AFD8C8  ldp      x20, x19, [sp, #0x10]
006AFD8CC  ldp      x30, x21, [sp], #0x20
006AFD8D0  br       x2
006AFD8D4  ldr      x8, [x2, #0x60]
006AFD8D8  mov      x0, x19
006AFD8DC  mov      w1, w20
006AFD8E0  blr      x8
006AFD8E4  mov      x0, x19
006AFD8E8  mov      x1, xzr
006AFD8EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFD8F0  adrp     x21, #0x959f000
006AFD8F4  ldrb     w8, [x21, #0x8c8]
006AFD8F8  mov      w20, w0
006AFD8FC  cbnz     w8, #0x6afd914
006AFD900  adrp     x0, #0x8f3d000
006AFD904  ldr      x0, [x0, #0xfb0]
006AFD908  bl       #0x382bd14 ; 
006AFD90C  mov      w8, #1
006AFD910  strb     w8, [x21, #0x8c8]
006AFD914  adrp     x8, #0x8f3d000
006AFD918  ldr      x8, [x8, #0xfb0]
006AFD91C  ldr      x2, [x8]
006AFD920  ldrb     w8, [x2, #0x53]
006AFD924  tbnz     w8, #5, #0x6afd930
006AFD928  str      w20, [x19, #0x24]
006AFD92C  b        #0x6afd940 ; 
006AFD930  ldr      x8, [x2, #0x60]
006AFD934  mov      x0, x19
006AFD938  mov      w1, w20
006AFD93C  blr      x8
006AFD940  mov      x0, x19
006AFD944  mov      x1, xzr
006AFD948  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFD94C  adrp     x21, #0x959f000
006AFD950  ldrb     w8, [x21, #0x8c9]
006AFD954  mov      w20, w0
006AFD958  cbnz     w8, #0x6afd970
006AFD95C  adrp     x0, #0x8f3d000
006AFD960  ldr      x0, [x0, #0xfb8]
006AFD964  bl       #0x382bd14 ; 
006AFD968  mov      w8, #1
006AFD96C  strb     w8, [x21, #0x8c9]
006AFD970  adrp     x8, #0x8f3d000
006AFD974  ldr      x8, [x8, #0xfb8]
006AFD978  ldr      x2, [x8]
006AFD97C  ldrb     w8, [x2, #0x53]
006AFD980  tbnz     w8, #5, #0x6afd98c
006AFD984  str      w20, [x19, #0x28]
006AFD988  b        #0x6afd99c ; 
006AFD98C  ldr      x8, [x2, #0x60]
006AFD990  mov      x0, x19
006AFD994  mov      w1, w20
006AFD998  blr      x8
006AFD99C  ldp      x20, x19, [sp, #0x10]
006AFD9A0  mov      w0, #1
006AFD9A4  ldp      x30, x21, [sp], #0x20
006AFD9A8  ret      

