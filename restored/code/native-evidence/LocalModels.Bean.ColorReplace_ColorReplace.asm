; LocalModels.Bean.ColorReplace_ColorReplace$$readImpl
; RVA 0x68CF884; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CF884  stp      x30, x21, [sp, #-0x20]!
0068CF888  stp      x20, x19, [sp, #0x10]
0068CF88C  adrp     x20, #0x959c000
0068CF890  adrp     x21, #0x8f28000
0068CF894  ldrb     w8, [x20, #0x397]
0068CF898  ldr      x21, [x21, #0x618]
0068CF89C  mov      x19, x0
0068CF8A0  tbnz     w8, #0, #0x68cf8b8
0068CF8A4  adrp     x0, #0x8f28000
0068CF8A8  ldr      x0, [x0, #0x618]
0068CF8AC  bl       #0x382bd14 ; 
0068CF8B0  mov      w8, #1
0068CF8B4  strb     w8, [x20, #0x397]
0068CF8B8  ldr      x1, [x21]
0068CF8BC  ldrb     w8, [x1, #0x53]
0068CF8C0  tbnz     w8, #5, #0x68cf910
0068CF8C4  mov      x0, x19
0068CF8C8  mov      x1, xzr
0068CF8CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CF8D0  adrp     x21, #0x959c000
0068CF8D4  ldrb     w8, [x21, #0x74c]
0068CF8D8  mov      w20, w0
0068CF8DC  cbnz     w8, #0x68cf8f4
0068CF8E0  adrp     x0, #0x8f28000
0068CF8E4  ldr      x0, [x0, #0x600]
0068CF8E8  bl       #0x382bd14 ; 
0068CF8EC  mov      w8, #1
0068CF8F0  strb     w8, [x21, #0x74c]
0068CF8F4  adrp     x8, #0x8f28000
0068CF8F8  ldr      x8, [x8, #0x600]
0068CF8FC  ldr      x2, [x8]
0068CF900  ldrb     w8, [x2, #0x53]
0068CF904  tbnz     w8, #5, #0x68cf924
0068CF908  str      w20, [x19, #0x20]
0068CF90C  b        #0x68cf934 ; 
0068CF910  ldr      x2, [x1, #0x60]
0068CF914  mov      x0, x19
0068CF918  ldp      x20, x19, [sp, #0x10]
0068CF91C  ldp      x30, x21, [sp], #0x20
0068CF920  br       x2
0068CF924  ldr      x8, [x2, #0x60]
0068CF928  mov      x0, x19
0068CF92C  mov      w1, w20
0068CF930  blr      x8
0068CF934  mov      x0, x19
0068CF938  mov      x1, xzr
0068CF93C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068CF940  adrp     x21, #0x959c000
0068CF944  ldrb     w8, [x21, #0x74d]
0068CF948  mov      x20, x0
0068CF94C  cbnz     w8, #0x68cf964
0068CF950  adrp     x0, #0x8f28000
0068CF954  ldr      x0, [x0, #0x610]
0068CF958  bl       #0x382bd14 ; 
0068CF95C  mov      w8, #1
0068CF960  strb     w8, [x21, #0x74d]
0068CF964  adrp     x8, #0x8f28000
0068CF968  ldr      x8, [x8, #0x610]
0068CF96C  ldr      x2, [x8]
0068CF970  ldrb     w8, [x2, #0x53]
0068CF974  tbnz     w8, #5, #0x68cf98c
0068CF978  str      x20, [x19, #0x28]!
0068CF97C  mov      x0, x19
0068CF980  mov      x1, x20
0068CF984  bl       #0x382bcb8 ; 
0068CF988  b        #0x68cf99c ; 
0068CF98C  ldr      x8, [x2, #0x60]
0068CF990  mov      x0, x19
0068CF994  mov      x1, x20
0068CF998  blr      x8
0068CF99C  ldp      x20, x19, [sp, #0x10]
0068CF9A0  mov      w0, #1
0068CF9A4  ldp      x30, x21, [sp], #0x20
0068CF9A8  ret      

