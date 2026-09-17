; LocalModels.Bean.EventDiving_DiveSpeical$$readImpl
; RVA 0x6A70264; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A70264  stp      x30, x21, [sp, #-0x20]!
006A70268  stp      x20, x19, [sp, #0x10]
006A7026C  adrp     x20, #0x959d000
006A70270  adrp     x21, #0x8f37000
006A70274  ldrb     w8, [x20, #0xd93]
006A70278  ldr      x21, [x21, #0x568]
006A7027C  mov      x19, x0
006A70280  tbnz     w8, #0, #0x6a70298
006A70284  adrp     x0, #0x8f37000
006A70288  ldr      x0, [x0, #0x568]
006A7028C  bl       #0x382bd14 ; 
006A70290  mov      w8, #1
006A70294  strb     w8, [x20, #0xd93]
006A70298  ldr      x1, [x21]
006A7029C  ldrb     w8, [x1, #0x53]
006A702A0  tbnz     w8, #5, #0x6a702f0
006A702A4  mov      x0, x19
006A702A8  mov      x1, xzr
006A702AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A702B0  adrp     x21, #0x959e000
006A702B4  ldrb     w8, [x21, #0x44d]
006A702B8  mov      w20, w0
006A702BC  cbnz     w8, #0x6a702d4
006A702C0  adrp     x0, #0x8f37000
006A702C4  ldr      x0, [x0, #0x520]
006A702C8  bl       #0x382bd14 ; 
006A702CC  mov      w8, #1
006A702D0  strb     w8, [x21, #0x44d]
006A702D4  adrp     x8, #0x8f37000
006A702D8  ldr      x8, [x8, #0x520]
006A702DC  ldr      x2, [x8]
006A702E0  ldrb     w8, [x2, #0x53]
006A702E4  tbnz     w8, #5, #0x6a70304
006A702E8  str      w20, [x19, #0x20]
006A702EC  b        #0x6a70314 ; 
006A702F0  ldr      x2, [x1, #0x60]
006A702F4  mov      x0, x19
006A702F8  ldp      x20, x19, [sp, #0x10]
006A702FC  ldp      x30, x21, [sp], #0x20
006A70300  br       x2
006A70304  ldr      x8, [x2, #0x60]
006A70308  mov      x0, x19
006A7030C  mov      w1, w20
006A70310  blr      x8
006A70314  mov      x0, x19
006A70318  mov      x1, xzr
006A7031C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A70320  adrp     x21, #0x959e000
006A70324  ldrb     w8, [x21, #0x44e]
006A70328  mov      x20, x0
006A7032C  cbnz     w8, #0x6a70344
006A70330  adrp     x0, #0x8f37000
006A70334  ldr      x0, [x0, #0x530]
006A70338  bl       #0x382bd14 ; 
006A7033C  mov      w8, #1
006A70340  strb     w8, [x21, #0x44e]
006A70344  adrp     x8, #0x8f37000
006A70348  ldr      x8, [x8, #0x530]
006A7034C  ldr      x2, [x8]
006A70350  ldrb     w8, [x2, #0x53]
006A70354  tbnz     w8, #5, #0x6a7036c
006A70358  mov      x0, x19
006A7035C  str      x20, [x0, #0x28]!
006A70360  mov      x1, x20
006A70364  bl       #0x382bcb8 ; 
006A70368  b        #0x6a7037c ; 
006A7036C  ldr      x8, [x2, #0x60]
006A70370  mov      x0, x19
006A70374  mov      x1, x20
006A70378  blr      x8
006A7037C  mov      x0, x19
006A70380  mov      x1, xzr
006A70384  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A70388  adrp     x21, #0x959e000
006A7038C  ldrb     w8, [x21, #0x44f]
006A70390  mov      x20, x0
006A70394  cbnz     w8, #0x6a703ac
006A70398  adrp     x0, #0x8f37000
006A7039C  ldr      x0, [x0, #0x540]
006A703A0  bl       #0x382bd14 ; 
006A703A4  mov      w8, #1
006A703A8  strb     w8, [x21, #0x44f]
006A703AC  adrp     x8, #0x8f37000
006A703B0  ldr      x8, [x8, #0x540]
006A703B4  ldr      x2, [x8]
006A703B8  ldrb     w8, [x2, #0x53]
006A703BC  tbnz     w8, #5, #0x6a703d4
006A703C0  mov      x0, x19
006A703C4  str      x20, [x0, #0x30]!
006A703C8  mov      x1, x20
006A703CC  bl       #0x382bcb8 ; 
006A703D0  b        #0x6a703e4 ; 
006A703D4  ldr      x8, [x2, #0x60]
006A703D8  mov      x0, x19
006A703DC  mov      x1, x20
006A703E0  blr      x8
006A703E4  mov      x0, x19
006A703E8  mov      x1, xzr
006A703EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A703F0  adrp     x21, #0x959e000
006A703F4  ldrb     w8, [x21, #0x450]
006A703F8  mov      w20, w0
006A703FC  cbnz     w8, #0x6a70414
006A70400  adrp     x0, #0x8f37000
006A70404  ldr      x0, [x0, #0x550]
006A70408  bl       #0x382bd14 ; 
006A7040C  mov      w8, #1
006A70410  strb     w8, [x21, #0x450]
006A70414  adrp     x8, #0x8f37000
006A70418  ldr      x8, [x8, #0x550]
006A7041C  ldr      x2, [x8]
006A70420  ldrb     w8, [x2, #0x53]
006A70424  tbnz     w8, #5, #0x6a70430
006A70428  str      w20, [x19, #0x38]
006A7042C  b        #0x6a70440 ; 
006A70430  ldr      x8, [x2, #0x60]
006A70434  mov      x0, x19
006A70438  mov      w1, w20
006A7043C  blr      x8
006A70440  mov      x0, x19
006A70444  mov      x1, xzr
006A70448  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7044C  adrp     x21, #0x959e000
006A70450  ldrb     w8, [x21, #0x451]
006A70454  mov      x20, x0
006A70458  cbnz     w8, #0x6a70470
006A7045C  adrp     x0, #0x8f37000
006A70460  ldr      x0, [x0, #0x560]
006A70464  bl       #0x382bd14 ; 
006A70468  mov      w8, #1
006A7046C  strb     w8, [x21, #0x451]
006A70470  adrp     x8, #0x8f37000
006A70474  ldr      x8, [x8, #0x560]
006A70478  ldr      x2, [x8]
006A7047C  ldrb     w8, [x2, #0x53]
006A70480  tbnz     w8, #5, #0x6a70498
006A70484  str      x20, [x19, #0x40]!
006A70488  mov      x0, x19
006A7048C  mov      x1, x20
006A70490  bl       #0x382bcb8 ; 
006A70494  b        #0x6a704a8 ; 
006A70498  ldr      x8, [x2, #0x60]
006A7049C  mov      x0, x19
006A704A0  mov      x1, x20
006A704A4  blr      x8
006A704A8  ldp      x20, x19, [sp, #0x10]
006A704AC  mov      w0, #1
006A704B0  ldp      x30, x21, [sp], #0x20
006A704B4  ret      

