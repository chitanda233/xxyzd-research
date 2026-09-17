; LocalModels.Bean.Skillss_Synthesis$$readImpl
; RVA 0x6B04274; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B04274  stp      x30, x21, [sp, #-0x20]!
006B04278  stp      x20, x19, [sp, #0x10]
006B0427C  adrp     x20, #0x959f000
006B04280  adrp     x21, #0x8f3e000
006B04284  ldrb     w8, [x20, #0x3f8]
006B04288  ldr      x21, [x21, #0x4c0]
006B0428C  mov      x19, x0
006B04290  tbnz     w8, #0, #0x6b042a8
006B04294  adrp     x0, #0x8f3e000
006B04298  ldr      x0, [x0, #0x4c0]
006B0429C  bl       #0x382bd14 ; 
006B042A0  mov      w8, #1
006B042A4  strb     w8, [x20, #0x3f8]
006B042A8  ldr      x1, [x21]
006B042AC  ldrb     w8, [x1, #0x53]
006B042B0  tbnz     w8, #5, #0x6b04300
006B042B4  mov      x0, x19
006B042B8  mov      x1, xzr
006B042BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B042C0  adrp     x21, #0x959f000
006B042C4  ldrb     w8, [x21, #0x917]
006B042C8  mov      w20, w0
006B042CC  cbnz     w8, #0x6b042e4
006B042D0  adrp     x0, #0x8f3e000
006B042D4  ldr      x0, [x0, #0x478]
006B042D8  bl       #0x382bd14 ; 
006B042DC  mov      w8, #1
006B042E0  strb     w8, [x21, #0x917]
006B042E4  adrp     x8, #0x8f3e000
006B042E8  ldr      x8, [x8, #0x478]
006B042EC  ldr      x2, [x8]
006B042F0  ldrb     w8, [x2, #0x53]
006B042F4  tbnz     w8, #5, #0x6b04314
006B042F8  str      w20, [x19, #0x20]
006B042FC  b        #0x6b04324 ; 
006B04300  ldr      x2, [x1, #0x60]
006B04304  mov      x0, x19
006B04308  ldp      x20, x19, [sp, #0x10]
006B0430C  ldp      x30, x21, [sp], #0x20
006B04310  br       x2
006B04314  ldr      x8, [x2, #0x60]
006B04318  mov      x0, x19
006B0431C  mov      w1, w20
006B04320  blr      x8
006B04324  mov      x0, x19
006B04328  mov      x1, xzr
006B0432C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B04330  adrp     x21, #0x959f000
006B04334  ldrb     w8, [x21, #0x918]
006B04338  mov      w20, w0
006B0433C  cbnz     w8, #0x6b04354
006B04340  adrp     x0, #0x8f3e000
006B04344  ldr      x0, [x0, #0x488]
006B04348  bl       #0x382bd14 ; 
006B0434C  mov      w8, #1
006B04350  strb     w8, [x21, #0x918]
006B04354  adrp     x8, #0x8f3e000
006B04358  ldr      x8, [x8, #0x488]
006B0435C  ldr      x2, [x8]
006B04360  ldrb     w8, [x2, #0x53]
006B04364  tbnz     w8, #5, #0x6b04370
006B04368  str      w20, [x19, #0x24]
006B0436C  b        #0x6b04380 ; 
006B04370  ldr      x8, [x2, #0x60]
006B04374  mov      x0, x19
006B04378  mov      w1, w20
006B0437C  blr      x8
006B04380  mov      x0, x19
006B04384  mov      x1, xzr
006B04388  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0438C  adrp     x21, #0x959f000
006B04390  ldrb     w8, [x21, #0x919]
006B04394  mov      w20, w0
006B04398  cbnz     w8, #0x6b043b0
006B0439C  adrp     x0, #0x8f3e000
006B043A0  ldr      x0, [x0, #0x498]
006B043A4  bl       #0x382bd14 ; 
006B043A8  mov      w8, #1
006B043AC  strb     w8, [x21, #0x919]
006B043B0  adrp     x8, #0x8f3e000
006B043B4  ldr      x8, [x8, #0x498]
006B043B8  ldr      x2, [x8]
006B043BC  ldrb     w8, [x2, #0x53]
006B043C0  tbnz     w8, #5, #0x6b043cc
006B043C4  str      w20, [x19, #0x28]
006B043C8  b        #0x6b043dc ; 
006B043CC  ldr      x8, [x2, #0x60]
006B043D0  mov      x0, x19
006B043D4  mov      w1, w20
006B043D8  blr      x8
006B043DC  mov      x0, x19
006B043E0  mov      x1, xzr
006B043E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B043E8  adrp     x21, #0x959f000
006B043EC  ldrb     w8, [x21, #0x91a]
006B043F0  mov      w20, w0
006B043F4  cbnz     w8, #0x6b0440c
006B043F8  adrp     x0, #0x8f3e000
006B043FC  ldr      x0, [x0, #0x4a8]
006B04400  bl       #0x382bd14 ; 
006B04404  mov      w8, #1
006B04408  strb     w8, [x21, #0x91a]
006B0440C  adrp     x8, #0x8f3e000
006B04410  ldr      x8, [x8, #0x4a8]
006B04414  ldr      x2, [x8]
006B04418  ldrb     w8, [x2, #0x53]
006B0441C  tbnz     w8, #5, #0x6b04428
006B04420  str      w20, [x19, #0x2c]
006B04424  b        #0x6b04438 ; 
006B04428  ldr      x8, [x2, #0x60]
006B0442C  mov      x0, x19
006B04430  mov      w1, w20
006B04434  blr      x8
006B04438  mov      x0, x19
006B0443C  mov      x1, xzr
006B04440  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B04444  adrp     x21, #0x959f000
006B04448  ldrb     w8, [x21, #0x91b]
006B0444C  mov      w20, w0
006B04450  cbnz     w8, #0x6b04468
006B04454  adrp     x0, #0x8f3e000
006B04458  ldr      x0, [x0, #0x4b8]
006B0445C  bl       #0x382bd14 ; 
006B04460  mov      w8, #1
006B04464  strb     w8, [x21, #0x91b]
006B04468  adrp     x8, #0x8f3e000
006B0446C  ldr      x8, [x8, #0x4b8]
006B04470  ldr      x2, [x8]
006B04474  ldrb     w8, [x2, #0x53]
006B04478  tbnz     w8, #5, #0x6b04484
006B0447C  str      w20, [x19, #0x30]
006B04480  b        #0x6b04494 ; 
006B04484  ldr      x8, [x2, #0x60]
006B04488  mov      x0, x19
006B0448C  mov      w1, w20
006B04490  blr      x8
006B04494  ldp      x20, x19, [sp, #0x10]
006B04498  mov      w0, #1
006B0449C  ldp      x30, x21, [sp], #0x20
006B044A0  ret      

