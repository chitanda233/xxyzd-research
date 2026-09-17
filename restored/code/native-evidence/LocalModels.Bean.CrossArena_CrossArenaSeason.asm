; LocalModels.Bean.CrossArena_CrossArenaSeason$$readImpl
; RVA 0x6A57058; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A57058  stp      x30, x21, [sp, #-0x20]!
006A5705C  stp      x20, x19, [sp, #0x10]
006A57060  adrp     x20, #0x959d000
006A57064  adrp     x21, #0x8f36000
006A57068  ldrb     w8, [x20, #0xb03]
006A5706C  ldr      x21, [x21, #0x2f8]
006A57070  mov      x19, x0
006A57074  tbnz     w8, #0, #0x6a5708c
006A57078  adrp     x0, #0x8f36000
006A5707C  ldr      x0, [x0, #0x2f8]
006A57080  bl       #0x382bd14 ; 
006A57084  mov      w8, #1
006A57088  strb     w8, [x20, #0xb03]
006A5708C  ldr      x1, [x21]
006A57090  ldrb     w8, [x1, #0x53]
006A57094  tbnz     w8, #5, #0x6a570e4
006A57098  mov      x0, x19
006A5709C  mov      x1, xzr
006A570A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A570A4  adrp     x21, #0x959e000
006A570A8  ldrb     w8, [x21, #0x330]
006A570AC  mov      w20, w0
006A570B0  cbnz     w8, #0x6a570c8
006A570B4  adrp     x0, #0x8f36000
006A570B8  ldr      x0, [x0, #0x260]
006A570BC  bl       #0x382bd14 ; 
006A570C0  mov      w8, #1
006A570C4  strb     w8, [x21, #0x330]
006A570C8  adrp     x8, #0x8f36000
006A570CC  ldr      x8, [x8, #0x260]
006A570D0  ldr      x2, [x8]
006A570D4  ldrb     w8, [x2, #0x53]
006A570D8  tbnz     w8, #5, #0x6a570f8
006A570DC  str      w20, [x19, #0x20]
006A570E0  b        #0x6a57108 ; 
006A570E4  ldr      x2, [x1, #0x60]
006A570E8  mov      x0, x19
006A570EC  ldp      x20, x19, [sp, #0x10]
006A570F0  ldp      x30, x21, [sp], #0x20
006A570F4  br       x2
006A570F8  ldr      x8, [x2, #0x60]
006A570FC  mov      x0, x19
006A57100  mov      w1, w20
006A57104  blr      x8
006A57108  mov      x0, x19
006A5710C  mov      x1, xzr
006A57110  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A57114  adrp     x21, #0x959e000
006A57118  ldrb     w8, [x21, #0x331]
006A5711C  mov      w20, w0
006A57120  cbnz     w8, #0x6a57138
006A57124  adrp     x0, #0x8f36000
006A57128  ldr      x0, [x0, #0x270]
006A5712C  bl       #0x382bd14 ; 
006A57130  mov      w8, #1
006A57134  strb     w8, [x21, #0x331]
006A57138  adrp     x8, #0x8f36000
006A5713C  ldr      x8, [x8, #0x270]
006A57140  ldr      x2, [x8]
006A57144  ldrb     w8, [x2, #0x53]
006A57148  tbnz     w8, #5, #0x6a57154
006A5714C  str      w20, [x19, #0x24]
006A57150  b        #0x6a57164 ; 
006A57154  ldr      x8, [x2, #0x60]
006A57158  mov      x0, x19
006A5715C  mov      w1, w20
006A57160  blr      x8
006A57164  mov      x0, x19
006A57168  mov      x1, xzr
006A5716C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A57170  adrp     x21, #0x959e000
006A57174  ldrb     w8, [x21, #0x332]
006A57178  mov      x20, x0
006A5717C  cbnz     w8, #0x6a57194
006A57180  adrp     x0, #0x8f36000
006A57184  ldr      x0, [x0, #0x280]
006A57188  bl       #0x382bd14 ; 
006A5718C  mov      w8, #1
006A57190  strb     w8, [x21, #0x332]
006A57194  adrp     x8, #0x8f36000
006A57198  ldr      x8, [x8, #0x280]
006A5719C  ldr      x2, [x8]
006A571A0  ldrb     w8, [x2, #0x53]
006A571A4  tbnz     w8, #5, #0x6a571bc
006A571A8  mov      x0, x19
006A571AC  str      x20, [x0, #0x28]!
006A571B0  mov      x1, x20
006A571B4  bl       #0x382bcb8 ; 
006A571B8  b        #0x6a571cc ; 
006A571BC  ldr      x8, [x2, #0x60]
006A571C0  mov      x0, x19
006A571C4  mov      x1, x20
006A571C8  blr      x8
006A571CC  mov      x0, x19
006A571D0  mov      x1, xzr
006A571D4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A571D8  adrp     x21, #0x959e000
006A571DC  ldrb     w8, [x21, #0x333]
006A571E0  mov      x20, x0
006A571E4  cbnz     w8, #0x6a571fc
006A571E8  adrp     x0, #0x8f36000
006A571EC  ldr      x0, [x0, #0x290]
006A571F0  bl       #0x382bd14 ; 
006A571F4  mov      w8, #1
006A571F8  strb     w8, [x21, #0x333]
006A571FC  adrp     x8, #0x8f36000
006A57200  ldr      x8, [x8, #0x290]
006A57204  ldr      x2, [x8]
006A57208  ldrb     w8, [x2, #0x53]
006A5720C  tbnz     w8, #5, #0x6a57224
006A57210  mov      x0, x19
006A57214  str      x20, [x0, #0x30]!
006A57218  mov      x1, x20
006A5721C  bl       #0x382bcb8 ; 
006A57220  b        #0x6a57234 ; 
006A57224  ldr      x8, [x2, #0x60]
006A57228  mov      x0, x19
006A5722C  mov      x1, x20
006A57230  blr      x8
006A57234  mov      x0, x19
006A57238  mov      x1, xzr
006A5723C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A57240  adrp     x21, #0x959e000
006A57244  ldrb     w8, [x21, #0x334]
006A57248  mov      w20, w0
006A5724C  cbnz     w8, #0x6a57264
006A57250  adrp     x0, #0x8f36000
006A57254  ldr      x0, [x0, #0x2a0]
006A57258  bl       #0x382bd14 ; 
006A5725C  mov      w8, #1
006A57260  strb     w8, [x21, #0x334]
006A57264  adrp     x8, #0x8f36000
006A57268  ldr      x8, [x8, #0x2a0]
006A5726C  ldr      x2, [x8]
006A57270  ldrb     w8, [x2, #0x53]
006A57274  tbnz     w8, #5, #0x6a57280
006A57278  str      w20, [x19, #0x38]
006A5727C  b        #0x6a57290 ; 
006A57280  ldr      x8, [x2, #0x60]
006A57284  mov      x0, x19
006A57288  mov      w1, w20
006A5728C  blr      x8
006A57290  mov      x0, x19
006A57294  mov      x1, xzr
006A57298  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5729C  adrp     x21, #0x959e000
006A572A0  ldrb     w8, [x21, #0x335]
006A572A4  mov      w20, w0
006A572A8  cbnz     w8, #0x6a572c0
006A572AC  adrp     x0, #0x8f36000
006A572B0  ldr      x0, [x0, #0x2b0]
006A572B4  bl       #0x382bd14 ; 
006A572B8  mov      w8, #1
006A572BC  strb     w8, [x21, #0x335]
006A572C0  adrp     x8, #0x8f36000
006A572C4  ldr      x8, [x8, #0x2b0]
006A572C8  ldr      x2, [x8]
006A572CC  ldrb     w8, [x2, #0x53]
006A572D0  tbnz     w8, #5, #0x6a572dc
006A572D4  str      w20, [x19, #0x3c]
006A572D8  b        #0x6a572ec ; 
006A572DC  ldr      x8, [x2, #0x60]
006A572E0  mov      x0, x19
006A572E4  mov      w1, w20
006A572E8  blr      x8
006A572EC  mov      x0, x19
006A572F0  mov      x1, xzr
006A572F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A572F8  adrp     x21, #0x959e000
006A572FC  ldrb     w8, [x21, #0x336]
006A57300  mov      w20, w0
006A57304  cbnz     w8, #0x6a5731c
006A57308  adrp     x0, #0x8f36000
006A5730C  ldr      x0, [x0, #0x2c0]
006A57310  bl       #0x382bd14 ; 
006A57314  mov      w8, #1
006A57318  strb     w8, [x21, #0x336]
006A5731C  adrp     x8, #0x8f36000
006A57320  ldr      x8, [x8, #0x2c0]
006A57324  ldr      x2, [x8]
006A57328  ldrb     w8, [x2, #0x53]
006A5732C  tbnz     w8, #5, #0x6a57338
006A57330  str      w20, [x19, #0x40]
006A57334  b        #0x6a57348 ; 
006A57338  ldr      x8, [x2, #0x60]
006A5733C  mov      x0, x19
006A57340  mov      w1, w20
006A57344  blr      x8
006A57348  mov      x0, x19
006A5734C  mov      x1, xzr
006A57350  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A57354  adrp     x21, #0x959e000
006A57358  ldrb     w8, [x21, #0x337]
006A5735C  mov      x20, x0
006A57360  cbnz     w8, #0x6a57378
006A57364  adrp     x0, #0x8f36000
006A57368  ldr      x0, [x0, #0x2d0]
006A5736C  bl       #0x382bd14 ; 
006A57370  mov      w8, #1
006A57374  strb     w8, [x21, #0x337]
006A57378  adrp     x8, #0x8f36000
006A5737C  ldr      x8, [x8, #0x2d0]
006A57380  ldr      x2, [x8]
006A57384  ldrb     w8, [x2, #0x53]
006A57388  tbnz     w8, #5, #0x6a573a0
006A5738C  mov      x0, x19
006A57390  str      x20, [x0, #0x48]!
006A57394  mov      x1, x20
006A57398  bl       #0x382bcb8 ; 
006A5739C  b        #0x6a573b0 ; 
006A573A0  ldr      x8, [x2, #0x60]
006A573A4  mov      x0, x19
006A573A8  mov      x1, x20
006A573AC  blr      x8
006A573B0  mov      x0, x19
006A573B4  mov      x1, xzr
006A573B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A573BC  adrp     x21, #0x959e000
006A573C0  ldrb     w8, [x21, #0x338]
006A573C4  mov      w20, w0
006A573C8  cbnz     w8, #0x6a573e0
006A573CC  adrp     x0, #0x8f36000
006A573D0  ldr      x0, [x0, #0x2e0]
006A573D4  bl       #0x382bd14 ; 
006A573D8  mov      w8, #1
006A573DC  strb     w8, [x21, #0x338]
006A573E0  adrp     x8, #0x8f36000
006A573E4  ldr      x8, [x8, #0x2e0]
006A573E8  ldr      x2, [x8]
006A573EC  ldrb     w8, [x2, #0x53]
006A573F0  tbnz     w8, #5, #0x6a573fc
006A573F4  str      w20, [x19, #0x50]
006A573F8  b        #0x6a5740c ; 
006A573FC  ldr      x8, [x2, #0x60]
006A57400  mov      x0, x19
006A57404  mov      w1, w20
006A57408  blr      x8
006A5740C  mov      x0, x19
006A57410  mov      x1, xzr
006A57414  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A57418  adrp     x21, #0x959e000
006A5741C  ldrb     w8, [x21, #0x339]
006A57420  mov      w20, w0
006A57424  cbnz     w8, #0x6a5743c
006A57428  adrp     x0, #0x8f36000
006A5742C  ldr      x0, [x0, #0x2f0]
006A57430  bl       #0x382bd14 ; 
006A57434  mov      w8, #1
006A57438  strb     w8, [x21, #0x339]
006A5743C  adrp     x8, #0x8f36000
006A57440  ldr      x8, [x8, #0x2f0]
006A57444  ldr      x2, [x8]
006A57448  ldrb     w8, [x2, #0x53]
006A5744C  tbnz     w8, #5, #0x6a57458
006A57450  str      w20, [x19, #0x54]
006A57454  b        #0x6a57468 ; 
006A57458  ldr      x8, [x2, #0x60]
006A5745C  mov      x0, x19
006A57460  mov      w1, w20
006A57464  blr      x8
006A57468  ldp      x20, x19, [sp, #0x10]
006A5746C  mov      w0, #1
006A57470  ldp      x30, x21, [sp], #0x20
006A57474  ret      

