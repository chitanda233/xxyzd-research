; LocalModels.Bean.EventDiving_DiveBase$$readImpl
; RVA 0x6A6D07C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6D07C  stp      x30, x21, [sp, #-0x20]!
006A6D080  stp      x20, x19, [sp, #0x10]
006A6D084  adrp     x20, #0x959d000
006A6D088  adrp     x21, #0x8f37000
006A6D08C  ldrb     w8, [x20, #0xd46]
006A6D090  ldr      x21, [x21, #0x338]
006A6D094  mov      x19, x0
006A6D098  tbnz     w8, #0, #0x6a6d0b0
006A6D09C  adrp     x0, #0x8f37000
006A6D0A0  ldr      x0, [x0, #0x338]
006A6D0A4  bl       #0x382bd14 ; 
006A6D0A8  mov      w8, #1
006A6D0AC  strb     w8, [x20, #0xd46]
006A6D0B0  ldr      x1, [x21]
006A6D0B4  ldrb     w8, [x1, #0x53]
006A6D0B8  tbnz     w8, #5, #0x6a6d108
006A6D0BC  mov      x0, x19
006A6D0C0  mov      x1, xzr
006A6D0C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6D0C8  adrp     x21, #0x959e000
006A6D0CC  ldrb     w8, [x21, #0x425]
006A6D0D0  mov      w20, w0
006A6D0D4  cbnz     w8, #0x6a6d0ec
006A6D0D8  adrp     x0, #0x8f37000
006A6D0DC  ldr      x0, [x0, #0x230]
006A6D0E0  bl       #0x382bd14 ; 
006A6D0E4  mov      w8, #1
006A6D0E8  strb     w8, [x21, #0x425]
006A6D0EC  adrp     x8, #0x8f37000
006A6D0F0  ldr      x8, [x8, #0x230]
006A6D0F4  ldr      x2, [x8]
006A6D0F8  ldrb     w8, [x2, #0x53]
006A6D0FC  tbnz     w8, #5, #0x6a6d11c
006A6D100  str      w20, [x19, #0x20]
006A6D104  b        #0x6a6d12c ; 
006A6D108  ldr      x2, [x1, #0x60]
006A6D10C  mov      x0, x19
006A6D110  ldp      x20, x19, [sp, #0x10]
006A6D114  ldp      x30, x21, [sp], #0x20
006A6D118  br       x2
006A6D11C  ldr      x8, [x2, #0x60]
006A6D120  mov      x0, x19
006A6D124  mov      w1, w20
006A6D128  blr      x8
006A6D12C  mov      x0, x19
006A6D130  mov      x1, xzr
006A6D134  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6D138  adrp     x21, #0x959e000
006A6D13C  ldrb     w8, [x21, #0x426]
006A6D140  mov      x20, x0
006A6D144  cbnz     w8, #0x6a6d15c
006A6D148  adrp     x0, #0x8f37000
006A6D14C  ldr      x0, [x0, #0x240]
006A6D150  bl       #0x382bd14 ; 
006A6D154  mov      w8, #1
006A6D158  strb     w8, [x21, #0x426]
006A6D15C  adrp     x8, #0x8f37000
006A6D160  ldr      x8, [x8, #0x240]
006A6D164  ldr      x2, [x8]
006A6D168  ldrb     w8, [x2, #0x53]
006A6D16C  tbnz     w8, #5, #0x6a6d184
006A6D170  mov      x0, x19
006A6D174  str      x20, [x0, #0x28]!
006A6D178  mov      x1, x20
006A6D17C  bl       #0x382bcb8 ; 
006A6D180  b        #0x6a6d194 ; 
006A6D184  ldr      x8, [x2, #0x60]
006A6D188  mov      x0, x19
006A6D18C  mov      x1, x20
006A6D190  blr      x8
006A6D194  mov      x0, x19
006A6D198  mov      x1, xzr
006A6D19C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6D1A0  adrp     x21, #0x959e000
006A6D1A4  ldrb     w8, [x21, #0x427]
006A6D1A8  mov      x20, x0
006A6D1AC  cbnz     w8, #0x6a6d1c4
006A6D1B0  adrp     x0, #0x8f37000
006A6D1B4  ldr      x0, [x0, #0x250]
006A6D1B8  bl       #0x382bd14 ; 
006A6D1BC  mov      w8, #1
006A6D1C0  strb     w8, [x21, #0x427]
006A6D1C4  adrp     x8, #0x8f37000
006A6D1C8  ldr      x8, [x8, #0x250]
006A6D1CC  ldr      x2, [x8]
006A6D1D0  ldrb     w8, [x2, #0x53]
006A6D1D4  tbnz     w8, #5, #0x6a6d1ec
006A6D1D8  mov      x0, x19
006A6D1DC  str      x20, [x0, #0x30]!
006A6D1E0  mov      x1, x20
006A6D1E4  bl       #0x382bcb8 ; 
006A6D1E8  b        #0x6a6d1fc ; 
006A6D1EC  ldr      x8, [x2, #0x60]
006A6D1F0  mov      x0, x19
006A6D1F4  mov      x1, x20
006A6D1F8  blr      x8
006A6D1FC  mov      x0, x19
006A6D200  mov      x1, xzr
006A6D204  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6D208  adrp     x21, #0x959e000
006A6D20C  ldrb     w8, [x21, #0x428]
006A6D210  mov      x20, x0
006A6D214  cbnz     w8, #0x6a6d22c
006A6D218  adrp     x0, #0x8f37000
006A6D21C  ldr      x0, [x0, #0x260]
006A6D220  bl       #0x382bd14 ; 
006A6D224  mov      w8, #1
006A6D228  strb     w8, [x21, #0x428]
006A6D22C  adrp     x8, #0x8f37000
006A6D230  ldr      x8, [x8, #0x260]
006A6D234  ldr      x2, [x8]
006A6D238  ldrb     w8, [x2, #0x53]
006A6D23C  tbnz     w8, #5, #0x6a6d254
006A6D240  mov      x0, x19
006A6D244  str      x20, [x0, #0x38]!
006A6D248  mov      x1, x20
006A6D24C  bl       #0x382bcb8 ; 
006A6D250  b        #0x6a6d264 ; 
006A6D254  ldr      x8, [x2, #0x60]
006A6D258  mov      x0, x19
006A6D25C  mov      x1, x20
006A6D260  blr      x8
006A6D264  mov      x0, x19
006A6D268  mov      x1, xzr
006A6D26C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6D270  adrp     x21, #0x959e000
006A6D274  ldrb     w8, [x21, #0x429]
006A6D278  mov      w20, w0
006A6D27C  cbnz     w8, #0x6a6d294
006A6D280  adrp     x0, #0x8f37000
006A6D284  ldr      x0, [x0, #0x270]
006A6D288  bl       #0x382bd14 ; 
006A6D28C  mov      w8, #1
006A6D290  strb     w8, [x21, #0x429]
006A6D294  adrp     x8, #0x8f37000
006A6D298  ldr      x8, [x8, #0x270]
006A6D29C  ldr      x2, [x8]
006A6D2A0  ldrb     w8, [x2, #0x53]
006A6D2A4  tbnz     w8, #5, #0x6a6d2b0
006A6D2A8  str      w20, [x19, #0x40]
006A6D2AC  b        #0x6a6d2c0 ; 
006A6D2B0  ldr      x8, [x2, #0x60]
006A6D2B4  mov      x0, x19
006A6D2B8  mov      w1, w20
006A6D2BC  blr      x8
006A6D2C0  mov      x0, x19
006A6D2C4  mov      x1, xzr
006A6D2C8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6D2CC  adrp     x21, #0x959e000
006A6D2D0  ldrb     w8, [x21, #0x42a]
006A6D2D4  mov      x20, x0
006A6D2D8  cbnz     w8, #0x6a6d2f0
006A6D2DC  adrp     x0, #0x8f37000
006A6D2E0  ldr      x0, [x0, #0x280]
006A6D2E4  bl       #0x382bd14 ; 
006A6D2E8  mov      w8, #1
006A6D2EC  strb     w8, [x21, #0x42a]
006A6D2F0  adrp     x8, #0x8f37000
006A6D2F4  ldr      x8, [x8, #0x280]
006A6D2F8  ldr      x2, [x8]
006A6D2FC  ldrb     w8, [x2, #0x53]
006A6D300  tbnz     w8, #5, #0x6a6d318
006A6D304  mov      x0, x19
006A6D308  str      x20, [x0, #0x48]!
006A6D30C  mov      x1, x20
006A6D310  bl       #0x382bcb8 ; 
006A6D314  b        #0x6a6d328 ; 
006A6D318  ldr      x8, [x2, #0x60]
006A6D31C  mov      x0, x19
006A6D320  mov      x1, x20
006A6D324  blr      x8
006A6D328  mov      x0, x19
006A6D32C  mov      x1, xzr
006A6D330  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A6D334  adrp     x21, #0x959e000
006A6D338  ldrb     w8, [x21, #0x42b]
006A6D33C  mov      x20, x0
006A6D340  cbnz     w8, #0x6a6d358
006A6D344  adrp     x0, #0x8f37000
006A6D348  ldr      x0, [x0, #0x290]
006A6D34C  bl       #0x382bd14 ; 
006A6D350  mov      w8, #1
006A6D354  strb     w8, [x21, #0x42b]
006A6D358  adrp     x8, #0x8f37000
006A6D35C  ldr      x8, [x8, #0x290]
006A6D360  ldr      x2, [x8]
006A6D364  ldrb     w8, [x2, #0x53]
006A6D368  tbnz     w8, #5, #0x6a6d380
006A6D36C  mov      x0, x19
006A6D370  str      x20, [x0, #0x50]!
006A6D374  mov      x1, x20
006A6D378  bl       #0x382bcb8 ; 
006A6D37C  b        #0x6a6d390 ; 
006A6D380  ldr      x8, [x2, #0x60]
006A6D384  mov      x0, x19
006A6D388  mov      x1, x20
006A6D38C  blr      x8
006A6D390  mov      x0, x19
006A6D394  mov      x1, xzr
006A6D398  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6D39C  adrp     x21, #0x959e000
006A6D3A0  ldrb     w8, [x21, #0x42c]
006A6D3A4  mov      w20, w0
006A6D3A8  cbnz     w8, #0x6a6d3c0
006A6D3AC  adrp     x0, #0x8f37000
006A6D3B0  ldr      x0, [x0, #0x2a0]
006A6D3B4  bl       #0x382bd14 ; 
006A6D3B8  mov      w8, #1
006A6D3BC  strb     w8, [x21, #0x42c]
006A6D3C0  adrp     x8, #0x8f37000
006A6D3C4  ldr      x8, [x8, #0x2a0]
006A6D3C8  ldr      x2, [x8]
006A6D3CC  ldrb     w8, [x2, #0x53]
006A6D3D0  tbnz     w8, #5, #0x6a6d3dc
006A6D3D4  str      w20, [x19, #0x58]
006A6D3D8  b        #0x6a6d3ec ; 
006A6D3DC  ldr      x8, [x2, #0x60]
006A6D3E0  mov      x0, x19
006A6D3E4  mov      w1, w20
006A6D3E8  blr      x8
006A6D3EC  mov      x0, x19
006A6D3F0  mov      x1, xzr
006A6D3F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6D3F8  adrp     x21, #0x959e000
006A6D3FC  ldrb     w8, [x21, #0x42d]
006A6D400  mov      w20, w0
006A6D404  cbnz     w8, #0x6a6d41c
006A6D408  adrp     x0, #0x8f37000
006A6D40C  ldr      x0, [x0, #0x2b0]
006A6D410  bl       #0x382bd14 ; 
006A6D414  mov      w8, #1
006A6D418  strb     w8, [x21, #0x42d]
006A6D41C  adrp     x8, #0x8f37000
006A6D420  ldr      x8, [x8, #0x2b0]
006A6D424  ldr      x2, [x8]
006A6D428  ldrb     w8, [x2, #0x53]
006A6D42C  tbnz     w8, #5, #0x6a6d438
006A6D430  str      w20, [x19, #0x5c]
006A6D434  b        #0x6a6d448 ; 
006A6D438  ldr      x8, [x2, #0x60]
006A6D43C  mov      x0, x19
006A6D440  mov      w1, w20
006A6D444  blr      x8
006A6D448  mov      x0, x19
006A6D44C  mov      x1, xzr
006A6D450  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6D454  adrp     x21, #0x959e000
006A6D458  ldrb     w8, [x21, #0x42e]
006A6D45C  mov      x20, x0
006A6D460  cbnz     w8, #0x6a6d478
006A6D464  adrp     x0, #0x8f37000
006A6D468  ldr      x0, [x0, #0x2c0]
006A6D46C  bl       #0x382bd14 ; 
006A6D470  mov      w8, #1
006A6D474  strb     w8, [x21, #0x42e]
006A6D478  adrp     x8, #0x8f37000
006A6D47C  ldr      x8, [x8, #0x2c0]
006A6D480  ldr      x2, [x8]
006A6D484  ldrb     w8, [x2, #0x53]
006A6D488  tbnz     w8, #5, #0x6a6d4a0
006A6D48C  mov      x0, x19
006A6D490  str      x20, [x0, #0x60]!
006A6D494  mov      x1, x20
006A6D498  bl       #0x382bcb8 ; 
006A6D49C  b        #0x6a6d4b0 ; 
006A6D4A0  ldr      x8, [x2, #0x60]
006A6D4A4  mov      x0, x19
006A6D4A8  mov      x1, x20
006A6D4AC  blr      x8
006A6D4B0  mov      x0, x19
006A6D4B4  mov      x1, xzr
006A6D4B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6D4BC  adrp     x21, #0x959e000
006A6D4C0  ldrb     w8, [x21, #0x42f]
006A6D4C4  mov      w20, w0
006A6D4C8  cbnz     w8, #0x6a6d4e0
006A6D4CC  adrp     x0, #0x8f37000
006A6D4D0  ldr      x0, [x0, #0x2d0]
006A6D4D4  bl       #0x382bd14 ; 
006A6D4D8  mov      w8, #1
006A6D4DC  strb     w8, [x21, #0x42f]
006A6D4E0  adrp     x8, #0x8f37000
006A6D4E4  ldr      x8, [x8, #0x2d0]
006A6D4E8  ldr      x2, [x8]
006A6D4EC  ldrb     w8, [x2, #0x53]
006A6D4F0  tbnz     w8, #5, #0x6a6d4fc
006A6D4F4  str      w20, [x19, #0x68]
006A6D4F8  b        #0x6a6d50c ; 
006A6D4FC  ldr      x8, [x2, #0x60]
006A6D500  mov      x0, x19
006A6D504  mov      w1, w20
006A6D508  blr      x8
006A6D50C  mov      x0, x19
006A6D510  mov      x1, xzr
006A6D514  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6D518  adrp     x21, #0x959e000
006A6D51C  ldrb     w8, [x21, #0x430]
006A6D520  mov      x20, x0
006A6D524  cbnz     w8, #0x6a6d53c
006A6D528  adrp     x0, #0x8f37000
006A6D52C  ldr      x0, [x0, #0x2e0]
006A6D530  bl       #0x382bd14 ; 
006A6D534  mov      w8, #1
006A6D538  strb     w8, [x21, #0x430]
006A6D53C  adrp     x8, #0x8f37000
006A6D540  ldr      x8, [x8, #0x2e0]
006A6D544  ldr      x2, [x8]
006A6D548  ldrb     w8, [x2, #0x53]
006A6D54C  tbnz     w8, #5, #0x6a6d564
006A6D550  mov      x0, x19
006A6D554  str      x20, [x0, #0x70]!
006A6D558  mov      x1, x20
006A6D55C  bl       #0x382bcb8 ; 
006A6D560  b        #0x6a6d574 ; 
006A6D564  ldr      x8, [x2, #0x60]
006A6D568  mov      x0, x19
006A6D56C  mov      x1, x20
006A6D570  blr      x8
006A6D574  mov      x0, x19
006A6D578  mov      x1, xzr
006A6D57C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6D580  adrp     x21, #0x959e000
006A6D584  ldrb     w8, [x21, #0x431]
006A6D588  mov      w20, w0
006A6D58C  cbnz     w8, #0x6a6d5a4
006A6D590  adrp     x0, #0x8f37000
006A6D594  ldr      x0, [x0, #0x2f0]
006A6D598  bl       #0x382bd14 ; 
006A6D59C  mov      w8, #1
006A6D5A0  strb     w8, [x21, #0x431]
006A6D5A4  adrp     x8, #0x8f37000
006A6D5A8  ldr      x8, [x8, #0x2f0]
006A6D5AC  ldr      x2, [x8]
006A6D5B0  ldrb     w8, [x2, #0x53]
006A6D5B4  tbnz     w8, #5, #0x6a6d5c0
006A6D5B8  str      w20, [x19, #0x78]
006A6D5BC  b        #0x6a6d5d0 ; 
006A6D5C0  ldr      x8, [x2, #0x60]
006A6D5C4  mov      x0, x19
006A6D5C8  mov      w1, w20
006A6D5CC  blr      x8
006A6D5D0  mov      x0, x19
006A6D5D4  mov      x1, xzr
006A6D5D8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6D5DC  adrp     x21, #0x959e000
006A6D5E0  ldrb     w8, [x21, #0x432]
006A6D5E4  mov      x20, x0
006A6D5E8  cbnz     w8, #0x6a6d600
006A6D5EC  adrp     x0, #0x8f37000
006A6D5F0  ldr      x0, [x0, #0x300]
006A6D5F4  bl       #0x382bd14 ; 
006A6D5F8  mov      w8, #1
006A6D5FC  strb     w8, [x21, #0x432]
006A6D600  adrp     x8, #0x8f37000
006A6D604  ldr      x8, [x8, #0x300]
006A6D608  ldr      x2, [x8]
006A6D60C  ldrb     w8, [x2, #0x53]
006A6D610  tbnz     w8, #5, #0x6a6d628
006A6D614  mov      x0, x19
006A6D618  str      x20, [x0, #0x80]!
006A6D61C  mov      x1, x20
006A6D620  bl       #0x382bcb8 ; 
006A6D624  b        #0x6a6d638 ; 
006A6D628  ldr      x8, [x2, #0x60]
006A6D62C  mov      x0, x19
006A6D630  mov      x1, x20
006A6D634  blr      x8
006A6D638  mov      x0, x19
006A6D63C  mov      x1, xzr
006A6D640  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6D644  adrp     x21, #0x959e000
006A6D648  ldrb     w8, [x21, #0x433]
006A6D64C  mov      x20, x0
006A6D650  cbnz     w8, #0x6a6d668
006A6D654  adrp     x0, #0x8f37000
006A6D658  ldr      x0, [x0, #0x310]
006A6D65C  bl       #0x382bd14 ; 
006A6D660  mov      w8, #1
006A6D664  strb     w8, [x21, #0x433]
006A6D668  adrp     x8, #0x8f37000
006A6D66C  ldr      x8, [x8, #0x310]
006A6D670  ldr      x2, [x8]
006A6D674  ldrb     w8, [x2, #0x53]
006A6D678  tbnz     w8, #5, #0x6a6d690
006A6D67C  mov      x0, x19
006A6D680  str      x20, [x0, #0x88]!
006A6D684  mov      x1, x20
006A6D688  bl       #0x382bcb8 ; 
006A6D68C  b        #0x6a6d6a0 ; 
006A6D690  ldr      x8, [x2, #0x60]
006A6D694  mov      x0, x19
006A6D698  mov      x1, x20
006A6D69C  blr      x8
006A6D6A0  mov      x0, x19
006A6D6A4  mov      x1, xzr
006A6D6A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6D6AC  adrp     x21, #0x959e000
006A6D6B0  ldrb     w8, [x21, #0x434]
006A6D6B4  mov      w20, w0
006A6D6B8  cbnz     w8, #0x6a6d6d0
006A6D6BC  adrp     x0, #0x8f37000
006A6D6C0  ldr      x0, [x0, #0x320]
006A6D6C4  bl       #0x382bd14 ; 
006A6D6C8  mov      w8, #1
006A6D6CC  strb     w8, [x21, #0x434]
006A6D6D0  adrp     x8, #0x8f37000
006A6D6D4  ldr      x8, [x8, #0x320]
006A6D6D8  ldr      x2, [x8]
006A6D6DC  ldrb     w8, [x2, #0x53]
006A6D6E0  tbnz     w8, #5, #0x6a6d6ec
006A6D6E4  str      w20, [x19, #0x90]
006A6D6E8  b        #0x6a6d6fc ; 
006A6D6EC  ldr      x8, [x2, #0x60]
006A6D6F0  mov      x0, x19
006A6D6F4  mov      w1, w20
006A6D6F8  blr      x8
006A6D6FC  mov      x0, x19
006A6D700  mov      x1, xzr
006A6D704  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6D708  adrp     x21, #0x959e000
006A6D70C  ldrb     w8, [x21, #0x435]
006A6D710  mov      x20, x0
006A6D714  cbnz     w8, #0x6a6d72c
006A6D718  adrp     x0, #0x8f37000
006A6D71C  ldr      x0, [x0, #0x330]
006A6D720  bl       #0x382bd14 ; 
006A6D724  mov      w8, #1
006A6D728  strb     w8, [x21, #0x435]
006A6D72C  adrp     x8, #0x8f37000
006A6D730  ldr      x8, [x8, #0x330]
006A6D734  ldr      x2, [x8]
006A6D738  ldrb     w8, [x2, #0x53]
006A6D73C  tbnz     w8, #5, #0x6a6d754
006A6D740  str      x20, [x19, #0x98]!
006A6D744  mov      x0, x19
006A6D748  mov      x1, x20
006A6D74C  bl       #0x382bcb8 ; 
006A6D750  b        #0x6a6d764 ; 
006A6D754  ldr      x8, [x2, #0x60]
006A6D758  mov      x0, x19
006A6D75C  mov      x1, x20
006A6D760  blr      x8
006A6D764  ldp      x20, x19, [sp, #0x10]
006A6D768  mov      w0, #1
006A6D76C  ldp      x30, x21, [sp], #0x20
006A6D770  ret      

