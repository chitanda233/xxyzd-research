; LocalModels.Const$$SetSkillABTest
; RVA 0x64CB414; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CB414  sub      sp, sp, #0x30
0064CB418  stp      x30, x21, [sp, #0x10]
0064CB41C  stp      x20, x19, [sp, #0x20]
0064CB420  adrp     x20, #0x9597000
0064CB424  adrp     x21, #0x8efa000
0064CB428  ldrb     w8, [x20, #0xfdc]
0064CB42C  ldr      x21, [x21, #0x108]
0064CB430  mov      x19, x0
0064CB434  tbnz     w8, #0, #0x64cb464
0064CB438  adrp     x0, #0x8efa000
0064CB43C  ldr      x0, [x0, #0x108]
0064CB440  bl       #0x382bd14 ;
0064CB444  adrp     x0, #0x8ee8000
0064CB448  ldr      x0, [x0, #0x898]
0064CB44C  bl       #0x382bd14 ;
0064CB450  adrp     x0, #0x8efa000
0064CB454  ldr      x0, [x0, #0x110]
0064CB458  bl       #0x382bd14 ;
0064CB45C  mov      w8, #1
0064CB460  strb     w8, [x20, #0xfdc]
0064CB464  ldr      x1, [x21]
0064CB468  ldrb     w8, [x1, #0x53]
0064CB46C  tbnz     w8, #5, #0x64cb4c0
0064CB470  strb     wzr, [sp, #0xc]
0064CB474  cbz      x19, #0x64cb4d8
0064CB478  adrp     x10, #0x8efa000
0064CB47C  ldr      x8, [x19]
0064CB480  ldr      x10, [x10, #0x110]
0064CB484  ldrh     w9, [x8, #0x12e]
0064CB488  ldr      x1, [x10]
0064CB48C  cbz      x9, #0x64cb4b0
0064CB490  ldr      x10, [x8, #0xb0]
0064CB494  add      x10, x10, #8
0064CB498  ldur     x11, [x10, #-8]
0064CB49C  cmp      x11, x1
0064CB4A0  b.eq     #0x64cb500
0064CB4A4  subs     x9, x9, #1
0064CB4A8  add      x10, x10, #0x10
0064CB4AC  b.ne     #0x64cb498
0064CB4B0  mov      w2, #7
0064CB4B4  mov      x0, x19
0064CB4B8  bl       #0x3a7e710 ;
0064CB4BC  b        #0x64cb510 ;
0064CB4C0  ldr      x2, [x1, #0x60]
0064CB4C4  mov      x0, x19
0064CB4C8  ldp      x20, x19, [sp, #0x20]
0064CB4CC  ldp      x30, x21, [sp, #0x10]
0064CB4D0  add      sp, sp, #0x30
0064CB4D4  br       x2
0064CB4D8  adrp     x19, #0x8ee8000
0064CB4DC  ldr      x19, [x19, #0x898]
0064CB4E0  ldr      x8, [x19]
0064CB4E4  ldr      w9, [x8, #0xe0]
0064CB4E8  cbnz     w9, #0x64cb4f8
0064CB4EC  mov      x0, x8
0064CB4F0  bl       #0x382be8c ;
0064CB4F4  ldr      x8, [x19]
0064CB4F8  mov      w9, wzr
0064CB4FC  b        #0x64cb554 ;
0064CB500  ldr      w9, [x10]
0064CB504  add      w9, w9, #7
0064CB508  add      x8, x8, w9, sxtw #4
0064CB50C  add      x0, x8, #0x138
0064CB510  ldp      x8, x3, [x0]
0064CB514  add      x2, sp, #0xc
0064CB518  mov      w1, #0x7d1
0064CB51C  mov      x0, x19
0064CB520  blr      x8
0064CB524  adrp     x21, #0x8ee8000
0064CB528  ldr      x21, [x21, #0x898]
0064CB52C  ldrb     w20, [sp, #0xc]
0064CB530  mov      w19, w0
0064CB534  ldr      x8, [x21]
0064CB538  ldr      w9, [x8, #0xe0]
0064CB53C  cbnz     w9, #0x64cb54c
0064CB540  mov      x0, x8
0064CB544  bl       #0x382be8c ;
0064CB548  ldr      x8, [x21]
0064CB54C  and      w9, w19, w20
0064CB550  and      w9, w9, #1
0064CB554  ldr      x8, [x8, #0xb8]
0064CB558  ldp      x20, x19, [sp, #0x20]
0064CB55C  ldp      x30, x21, [sp, #0x10]
0064CB560  strb     w9, [x8, #0x530]
0064CB564  add      sp, sp, #0x30
0064CB568  ret
