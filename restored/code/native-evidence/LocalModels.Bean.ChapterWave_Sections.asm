; LocalModels.Bean.ChapterWave_Sections$$readImpl
; RVA 0x689F428; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689F428  stp      x30, x21, [sp, #-0x20]!
00689F42C  stp      x20, x19, [sp, #0x10]
00689F430  adrp     x20, #0x959b000
00689F434  adrp     x21, #0x8f26000
00689F438  ldrb     w8, [x20, #0xeab]
00689F43C  ldr      x21, [x21, #0x288]
00689F440  mov      x19, x0
00689F444  tbnz     w8, #0, #0x689f45c
00689F448  adrp     x0, #0x8f26000
00689F44C  ldr      x0, [x0, #0x288]
00689F450  bl       #0x382bd14 ; 
00689F454  mov      w8, #1
00689F458  strb     w8, [x20, #0xeab]
00689F45C  ldr      x1, [x21]
00689F460  ldrb     w8, [x1, #0x53]
00689F464  tbnz     w8, #5, #0x689f4b4
00689F468  mov      x0, x19
00689F46C  mov      x1, xzr
00689F470  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689F474  adrp     x21, #0x959c000
00689F478  ldrb     w8, [x21, #0x509]
00689F47C  mov      w20, w0
00689F480  cbnz     w8, #0x689f498
00689F484  adrp     x0, #0x8f26000
00689F488  ldr      x0, [x0, #0x260]
00689F48C  bl       #0x382bd14 ; 
00689F490  mov      w8, #1
00689F494  strb     w8, [x21, #0x509]
00689F498  adrp     x8, #0x8f26000
00689F49C  ldr      x8, [x8, #0x260]
00689F4A0  ldr      x2, [x8]
00689F4A4  ldrb     w8, [x2, #0x53]
00689F4A8  tbnz     w8, #5, #0x689f4c8
00689F4AC  str      w20, [x19, #0x20]
00689F4B0  b        #0x689f4d8 ; 
00689F4B4  ldr      x2, [x1, #0x60]
00689F4B8  mov      x0, x19
00689F4BC  ldp      x20, x19, [sp, #0x10]
00689F4C0  ldp      x30, x21, [sp], #0x20
00689F4C4  br       x2
00689F4C8  ldr      x8, [x2, #0x60]
00689F4CC  mov      x0, x19
00689F4D0  mov      w1, w20
00689F4D4  blr      x8
00689F4D8  mov      x0, x19
00689F4DC  mov      x1, xzr
00689F4E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689F4E4  adrp     x21, #0x959c000
00689F4E8  ldrb     w8, [x21, #0x50a]
00689F4EC  mov      w20, w0
00689F4F0  cbnz     w8, #0x689f508
00689F4F4  adrp     x0, #0x8f26000
00689F4F8  ldr      x0, [x0, #0x270]
00689F4FC  bl       #0x382bd14 ; 
00689F500  mov      w8, #1
00689F504  strb     w8, [x21, #0x50a]
00689F508  adrp     x8, #0x8f26000
00689F50C  ldr      x8, [x8, #0x270]
00689F510  ldr      x2, [x8]
00689F514  ldrb     w8, [x2, #0x53]
00689F518  tbnz     w8, #5, #0x689f524
00689F51C  str      w20, [x19, #0x24]
00689F520  b        #0x689f534 ; 
00689F524  ldr      x8, [x2, #0x60]
00689F528  mov      x0, x19
00689F52C  mov      w1, w20
00689F530  blr      x8
00689F534  mov      x0, x19
00689F538  mov      x1, xzr
00689F53C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689F540  adrp     x21, #0x959c000
00689F544  ldrb     w8, [x21, #0x50b]
00689F548  mov      w20, w0
00689F54C  cbnz     w8, #0x689f564
00689F550  adrp     x0, #0x8f26000
00689F554  ldr      x0, [x0, #0x280]
00689F558  bl       #0x382bd14 ; 
00689F55C  mov      w8, #1
00689F560  strb     w8, [x21, #0x50b]
00689F564  adrp     x8, #0x8f26000
00689F568  ldr      x8, [x8, #0x280]
00689F56C  ldr      x2, [x8]
00689F570  ldrb     w8, [x2, #0x53]
00689F574  tbnz     w8, #5, #0x689f580
00689F578  str      w20, [x19, #0x28]
00689F57C  b        #0x689f590 ; 
00689F580  ldr      x8, [x2, #0x60]
00689F584  mov      x0, x19
00689F588  mov      w1, w20
00689F58C  blr      x8
00689F590  ldp      x20, x19, [sp, #0x10]
00689F594  mov      w0, #1
00689F598  ldp      x30, x21, [sp], #0x20
00689F59C  ret      

