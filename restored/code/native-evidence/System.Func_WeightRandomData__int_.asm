; System.Func<WeightRandomData, int>$$.ctor
; RVA 0x48DB3D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB3D4  str      x30, [sp, #-0x30]!
0048DB3D8  stp      x22, x21, [sp, #0x10]
0048DB3DC  stp      x20, x19, [sp, #0x20]
0048DB3E0  ldr      x8, [x2, #8]
0048DB3E4  mov      x19, x0
0048DB3E8  str      x2, [x0, #0x28]
0048DB3EC  mov      x21, x2
0048DB3F0  str      x8, [x0, #0x10]
0048DB3F4  str      x1, [x0, #0x20]!
0048DB3F8  mov      x20, x1
0048DB3FC  bl       #0x382bcb8 ; 
0048DB400  ldrb     w22, [x21, #0x52]
0048DB404  mov      x0, x21
0048DB408  str      x19, [x19, #0x40]
0048DB40C  bl       #0x382be14 ; 
0048DB410  tbz      w0, #0, #0x48db42c
0048DB414  cmp      w22, #1
0048DB418  b.ne     #0x48db430
0048DB41C  adrp     x8, #0x3475000
0048DB420  add      x8, x8, #0xcc
0048DB424  str      x8, [x19, #0x18]
0048DB428  b        #0x48db440 ; 
0048DB42C  cbz      x20, #0x48db45c
0048DB430  ldr      x8, [x19, #0x10]
0048DB434  ldr      x9, [x19, #0x20]
0048DB438  str      x8, [x19, #0x18]
0048DB43C  str      x9, [x19, #0x40]
0048DB440  adrp     x8, #0x3475000
0048DB444  add      x8, x8, #0x5c
0048DB448  str      x8, [x19, #0x38]
0048DB44C  ldp      x20, x19, [sp, #0x20]
0048DB450  ldp      x22, x21, [sp, #0x10]
0048DB454  ldr      x30, [sp], #0x30
0048DB458  ret      
0048DB45C  adrp     x1, #0x1a2d000
0048DB460  add      x1, x1, #0x4e9
0048DB464  mov      x0, xzr
0048DB468  bl       #0x382bfd4 ; 
0048DB46C  mov      x1, xzr
0048DB470  bl       #0x382be7c ; 

; System.Func<WeightRandomData, int>$$Invoke
; RVA 0x48DB474; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB474  sub      sp, sp, #0x50
0048DB478  str      x30, [sp, #0x40]
0048DB47C  ldp      q2, q0, [x1, #0x10]
0048DB480  ldr      x10, [x1, #0x30]
0048DB484  ldr      q1, [x1]
0048DB488  ldr      x9, [x0, #0x18]
0048DB48C  ldr      x8, [x0, #0x40]
0048DB490  str      x10, [sp, #0x30]
0048DB494  stp      q2, q0, [sp, #0x10]
0048DB498  str      q1, [sp]
0048DB49C  ldr      x2, [x0, #0x28]
0048DB4A0  mov      x1, sp
0048DB4A4  mov      x0, x8
0048DB4A8  blr      x9
0048DB4AC  ldr      x30, [sp, #0x40]
0048DB4B0  add      sp, sp, #0x50
0048DB4B4  ret      

; System.Func<WeightRandomData, int>$$BeginInvoke
; RVA 0x48DB4B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB4B8  sub      sp, sp, #0x50
0048DB4BC  str      x30, [sp, #0x10]
0048DB4C0  stp      x24, x23, [sp, #0x20]
0048DB4C4  stp      x22, x21, [sp, #0x30]
0048DB4C8  stp      x20, x19, [sp, #0x40]
0048DB4CC  adrp     x24, #0x9591000
0048DB4D0  adrp     x23, #0x8ee8000
0048DB4D4  ldrb     w8, [x24, #0xfa6]
0048DB4D8  ldr      x23, [x23, #0x3d8]
0048DB4DC  mov      x19, x3
0048DB4E0  mov      x20, x2
0048DB4E4  mov      x22, x1
0048DB4E8  mov      x21, x0
0048DB4EC  tbnz     w8, #0, #0x48db504
0048DB4F0  adrp     x0, #0x8ee8000
0048DB4F4  ldr      x0, [x0, #0x3d8]
0048DB4F8  bl       #0x382bd14 ; 
0048DB4FC  mov      w8, #1
0048DB500  strb     w8, [x24, #0xfa6]
0048DB504  ldr      x0, [x23]
0048DB508  mov      x1, x22
0048DB50C  str      xzr, [sp, #8]
0048DB510  bl       #0x382be94 ; 
0048DB514  str      x0, [sp]
0048DB518  mov      x1, sp
0048DB51C  mov      x0, x21
0048DB520  mov      x2, x20
0048DB524  mov      x3, x19
0048DB528  bl       #0x382bcc8 ; 
0048DB52C  ldp      x20, x19, [sp, #0x40]
0048DB530  ldp      x22, x21, [sp, #0x30]
0048DB534  ldp      x24, x23, [sp, #0x20]
0048DB538  ldr      x30, [sp, #0x10]
0048DB53C  add      sp, sp, #0x50
0048DB540  ret      

; System.Func<WeightRandomData, int>$$EndInvoke
; RVA 0x48DB544; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB544  str      x30, [sp, #-0x10]!
0048DB548  mov      x0, x1
0048DB54C  mov      x1, xzr
0048DB550  bl       #0x382bccc ; 
0048DB554  cbz      x0, #0x48db568
0048DB558  bl       #0x382be98 ; 
0048DB55C  ldr      w0, [x0]
0048DB560  ldr      x30, [sp], #0x10
0048DB564  ret      
0048DB568  bl       #0x382bfb8 ; 

