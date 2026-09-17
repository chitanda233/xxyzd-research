; LocalModels.Bean.UltimateCore_Core$$readImpl
; RVA 0x6B1A000; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B1A000  stp      x30, x21, [sp, #-0x20]!
006B1A004  stp      x20, x19, [sp, #0x10]
006B1A008  adrp     x20, #0x959f000
006B1A00C  adrp     x21, #0x8f3f000
006B1A010  ldrb     w8, [x20, #0x63f]
006B1A014  ldr      x21, [x21, #0x3c0]
006B1A018  mov      x19, x0
006B1A01C  tbnz     w8, #0, #0x6b1a034
006B1A020  adrp     x0, #0x8f3f000
006B1A024  ldr      x0, [x0, #0x3c0]
006B1A028  bl       #0x382bd14 ; 
006B1A02C  mov      w8, #1
006B1A030  strb     w8, [x20, #0x63f]
006B1A034  ldr      x1, [x21]
006B1A038  ldrb     w8, [x1, #0x53]
006B1A03C  tbnz     w8, #5, #0x6b1a08c
006B1A040  mov      x0, x19
006B1A044  mov      x1, xzr
006B1A048  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A04C  adrp     x21, #0x959f000
006B1A050  ldrb     w8, [x21, #0xa04]
006B1A054  mov      w20, w0
006B1A058  cbnz     w8, #0x6b1a070
006B1A05C  adrp     x0, #0x8f3f000
006B1A060  ldr      x0, [x0, #0x2a8]
006B1A064  bl       #0x382bd14 ; 
006B1A068  mov      w8, #1
006B1A06C  strb     w8, [x21, #0xa04]
006B1A070  adrp     x8, #0x8f3f000
006B1A074  ldr      x8, [x8, #0x2a8]
006B1A078  ldr      x2, [x8]
006B1A07C  ldrb     w8, [x2, #0x53]
006B1A080  tbnz     w8, #5, #0x6b1a0a0
006B1A084  str      w20, [x19, #0x20]
006B1A088  b        #0x6b1a0b0 ; 
006B1A08C  ldr      x2, [x1, #0x60]
006B1A090  mov      x0, x19
006B1A094  ldp      x20, x19, [sp, #0x10]
006B1A098  ldp      x30, x21, [sp], #0x20
006B1A09C  br       x2
006B1A0A0  ldr      x8, [x2, #0x60]
006B1A0A4  mov      x0, x19
006B1A0A8  mov      w1, w20
006B1A0AC  blr      x8
006B1A0B0  mov      x0, x19
006B1A0B4  mov      x1, xzr
006B1A0B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A0BC  adrp     x21, #0x959f000
006B1A0C0  ldrb     w8, [x21, #0xa05]
006B1A0C4  mov      w20, w0
006B1A0C8  cbnz     w8, #0x6b1a0e0
006B1A0CC  adrp     x0, #0x8f3f000
006B1A0D0  ldr      x0, [x0, #0x2b8]
006B1A0D4  bl       #0x382bd14 ; 
006B1A0D8  mov      w8, #1
006B1A0DC  strb     w8, [x21, #0xa05]
006B1A0E0  adrp     x8, #0x8f3f000
006B1A0E4  ldr      x8, [x8, #0x2b8]
006B1A0E8  ldr      x2, [x8]
006B1A0EC  ldrb     w8, [x2, #0x53]
006B1A0F0  tbnz     w8, #5, #0x6b1a0fc
006B1A0F4  str      w20, [x19, #0x24]
006B1A0F8  b        #0x6b1a10c ; 
006B1A0FC  ldr      x8, [x2, #0x60]
006B1A100  mov      x0, x19
006B1A104  mov      w1, w20
006B1A108  blr      x8
006B1A10C  mov      x0, x19
006B1A110  mov      x1, xzr
006B1A114  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A118  adrp     x21, #0x959f000
006B1A11C  ldrb     w8, [x21, #0xa06]
006B1A120  mov      w20, w0
006B1A124  cbnz     w8, #0x6b1a13c
006B1A128  adrp     x0, #0x8f3f000
006B1A12C  ldr      x0, [x0, #0x2c8]
006B1A130  bl       #0x382bd14 ; 
006B1A134  mov      w8, #1
006B1A138  strb     w8, [x21, #0xa06]
006B1A13C  adrp     x8, #0x8f3f000
006B1A140  ldr      x8, [x8, #0x2c8]
006B1A144  ldr      x2, [x8]
006B1A148  ldrb     w8, [x2, #0x53]
006B1A14C  tbnz     w8, #5, #0x6b1a158
006B1A150  str      w20, [x19, #0x28]
006B1A154  b        #0x6b1a168 ; 
006B1A158  ldr      x8, [x2, #0x60]
006B1A15C  mov      x0, x19
006B1A160  mov      w1, w20
006B1A164  blr      x8
006B1A168  mov      x0, x19
006B1A16C  mov      x1, xzr
006B1A170  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A174  adrp     x21, #0x959f000
006B1A178  ldrb     w8, [x21, #0xa07]
006B1A17C  mov      w20, w0
006B1A180  cbnz     w8, #0x6b1a198
006B1A184  adrp     x0, #0x8f3f000
006B1A188  ldr      x0, [x0, #0x2d8]
006B1A18C  bl       #0x382bd14 ; 
006B1A190  mov      w8, #1
006B1A194  strb     w8, [x21, #0xa07]
006B1A198  adrp     x8, #0x8f3f000
006B1A19C  ldr      x8, [x8, #0x2d8]
006B1A1A0  ldr      x2, [x8]
006B1A1A4  ldrb     w8, [x2, #0x53]
006B1A1A8  tbnz     w8, #5, #0x6b1a1b4
006B1A1AC  str      w20, [x19, #0x2c]
006B1A1B0  b        #0x6b1a1c4 ; 
006B1A1B4  ldr      x8, [x2, #0x60]
006B1A1B8  mov      x0, x19
006B1A1BC  mov      w1, w20
006B1A1C0  blr      x8
006B1A1C4  mov      x0, x19
006B1A1C8  mov      x1, xzr
006B1A1CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A1D0  adrp     x21, #0x959f000
006B1A1D4  ldrb     w8, [x21, #0xa08]
006B1A1D8  mov      w20, w0
006B1A1DC  cbnz     w8, #0x6b1a1f4
006B1A1E0  adrp     x0, #0x8f3f000
006B1A1E4  ldr      x0, [x0, #0x2e8]
006B1A1E8  bl       #0x382bd14 ; 
006B1A1EC  mov      w8, #1
006B1A1F0  strb     w8, [x21, #0xa08]
006B1A1F4  adrp     x8, #0x8f3f000
006B1A1F8  ldr      x8, [x8, #0x2e8]
006B1A1FC  ldr      x2, [x8]
006B1A200  ldrb     w8, [x2, #0x53]
006B1A204  tbnz     w8, #5, #0x6b1a210
006B1A208  str      w20, [x19, #0x30]
006B1A20C  b        #0x6b1a220 ; 
006B1A210  ldr      x8, [x2, #0x60]
006B1A214  mov      x0, x19
006B1A218  mov      w1, w20
006B1A21C  blr      x8
006B1A220  mov      x0, x19
006B1A224  mov      x1, xzr
006B1A228  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1A22C  adrp     x21, #0x959f000
006B1A230  ldrb     w8, [x21, #0xa09]
006B1A234  mov      x20, x0
006B1A238  cbnz     w8, #0x6b1a250
006B1A23C  adrp     x0, #0x8f3f000
006B1A240  ldr      x0, [x0, #0x2f8]
006B1A244  bl       #0x382bd14 ; 
006B1A248  mov      w8, #1
006B1A24C  strb     w8, [x21, #0xa09]
006B1A250  adrp     x8, #0x8f3f000
006B1A254  ldr      x8, [x8, #0x2f8]
006B1A258  ldr      x2, [x8]
006B1A25C  ldrb     w8, [x2, #0x53]
006B1A260  tbnz     w8, #5, #0x6b1a278
006B1A264  mov      x0, x19
006B1A268  str      x20, [x0, #0x38]!
006B1A26C  mov      x1, x20
006B1A270  bl       #0x382bcb8 ; 
006B1A274  b        #0x6b1a288 ; 
006B1A278  ldr      x8, [x2, #0x60]
006B1A27C  mov      x0, x19
006B1A280  mov      x1, x20
006B1A284  blr      x8
006B1A288  mov      x0, x19
006B1A28C  mov      x1, xzr
006B1A290  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A294  adrp     x21, #0x959f000
006B1A298  ldrb     w8, [x21, #0xa0a]
006B1A29C  mov      w20, w0
006B1A2A0  cbnz     w8, #0x6b1a2b8
006B1A2A4  adrp     x0, #0x8f3f000
006B1A2A8  ldr      x0, [x0, #0x308]
006B1A2AC  bl       #0x382bd14 ; 
006B1A2B0  mov      w8, #1
006B1A2B4  strb     w8, [x21, #0xa0a]
006B1A2B8  adrp     x8, #0x8f3f000
006B1A2BC  ldr      x8, [x8, #0x308]
006B1A2C0  ldr      x2, [x8]
006B1A2C4  ldrb     w8, [x2, #0x53]
006B1A2C8  tbnz     w8, #5, #0x6b1a2d4
006B1A2CC  str      w20, [x19, #0x40]
006B1A2D0  b        #0x6b1a2e4 ; 
006B1A2D4  ldr      x8, [x2, #0x60]
006B1A2D8  mov      x0, x19
006B1A2DC  mov      w1, w20
006B1A2E0  blr      x8
006B1A2E4  mov      x0, x19
006B1A2E8  mov      x1, xzr
006B1A2EC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1A2F0  adrp     x21, #0x959f000
006B1A2F4  ldrb     w8, [x21, #0xa0b]
006B1A2F8  mov      x20, x0
006B1A2FC  cbnz     w8, #0x6b1a314
006B1A300  adrp     x0, #0x8f3f000
006B1A304  ldr      x0, [x0, #0x318]
006B1A308  bl       #0x382bd14 ; 
006B1A30C  mov      w8, #1
006B1A310  strb     w8, [x21, #0xa0b]
006B1A314  adrp     x8, #0x8f3f000
006B1A318  ldr      x8, [x8, #0x318]
006B1A31C  ldr      x2, [x8]
006B1A320  ldrb     w8, [x2, #0x53]
006B1A324  tbnz     w8, #5, #0x6b1a33c
006B1A328  mov      x0, x19
006B1A32C  str      x20, [x0, #0x48]!
006B1A330  mov      x1, x20
006B1A334  bl       #0x382bcb8 ; 
006B1A338  b        #0x6b1a34c ; 
006B1A33C  ldr      x8, [x2, #0x60]
006B1A340  mov      x0, x19
006B1A344  mov      x1, x20
006B1A348  blr      x8
006B1A34C  mov      x0, x19
006B1A350  mov      x1, xzr
006B1A354  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A358  adrp     x21, #0x959f000
006B1A35C  ldrb     w8, [x21, #0xa0c]
006B1A360  mov      w20, w0
006B1A364  cbnz     w8, #0x6b1a37c
006B1A368  adrp     x0, #0x8f3f000
006B1A36C  ldr      x0, [x0, #0x328]
006B1A370  bl       #0x382bd14 ; 
006B1A374  mov      w8, #1
006B1A378  strb     w8, [x21, #0xa0c]
006B1A37C  adrp     x8, #0x8f3f000
006B1A380  ldr      x8, [x8, #0x328]
006B1A384  ldr      x2, [x8]
006B1A388  ldrb     w8, [x2, #0x53]
006B1A38C  tbnz     w8, #5, #0x6b1a398
006B1A390  str      w20, [x19, #0x50]
006B1A394  b        #0x6b1a3a8 ; 
006B1A398  ldr      x8, [x2, #0x60]
006B1A39C  mov      x0, x19
006B1A3A0  mov      w1, w20
006B1A3A4  blr      x8
006B1A3A8  mov      x0, x19
006B1A3AC  mov      x1, xzr
006B1A3B0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1A3B4  adrp     x21, #0x959f000
006B1A3B8  ldrb     w8, [x21, #0xa0d]
006B1A3BC  mov      x20, x0
006B1A3C0  cbnz     w8, #0x6b1a3d8
006B1A3C4  adrp     x0, #0x8f3f000
006B1A3C8  ldr      x0, [x0, #0x338]
006B1A3CC  bl       #0x382bd14 ; 
006B1A3D0  mov      w8, #1
006B1A3D4  strb     w8, [x21, #0xa0d]
006B1A3D8  adrp     x8, #0x8f3f000
006B1A3DC  ldr      x8, [x8, #0x338]
006B1A3E0  ldr      x2, [x8]
006B1A3E4  ldrb     w8, [x2, #0x53]
006B1A3E8  tbnz     w8, #5, #0x6b1a400
006B1A3EC  mov      x0, x19
006B1A3F0  str      x20, [x0, #0x58]!
006B1A3F4  mov      x1, x20
006B1A3F8  bl       #0x382bcb8 ; 
006B1A3FC  b        #0x6b1a410 ; 
006B1A400  ldr      x8, [x2, #0x60]
006B1A404  mov      x0, x19
006B1A408  mov      x1, x20
006B1A40C  blr      x8
006B1A410  mov      x0, x19
006B1A414  mov      x1, xzr
006B1A418  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1A41C  adrp     x21, #0x959f000
006B1A420  ldrb     w8, [x21, #0xa0e]
006B1A424  mov      x20, x0
006B1A428  cbnz     w8, #0x6b1a440
006B1A42C  adrp     x0, #0x8f3f000
006B1A430  ldr      x0, [x0, #0x348]
006B1A434  bl       #0x382bd14 ; 
006B1A438  mov      w8, #1
006B1A43C  strb     w8, [x21, #0xa0e]
006B1A440  adrp     x8, #0x8f3f000
006B1A444  ldr      x8, [x8, #0x348]
006B1A448  ldr      x2, [x8]
006B1A44C  ldrb     w8, [x2, #0x53]
006B1A450  tbnz     w8, #5, #0x6b1a468
006B1A454  mov      x0, x19
006B1A458  str      x20, [x0, #0x60]!
006B1A45C  mov      x1, x20
006B1A460  bl       #0x382bcb8 ; 
006B1A464  b        #0x6b1a478 ; 
006B1A468  ldr      x8, [x2, #0x60]
006B1A46C  mov      x0, x19
006B1A470  mov      x1, x20
006B1A474  blr      x8
006B1A478  mov      x0, x19
006B1A47C  mov      x1, xzr
006B1A480  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1A484  adrp     x21, #0x959f000
006B1A488  ldrb     w8, [x21, #0xa0f]
006B1A48C  mov      x20, x0
006B1A490  cbnz     w8, #0x6b1a4a8
006B1A494  adrp     x0, #0x8f3f000
006B1A498  ldr      x0, [x0, #0x358]
006B1A49C  bl       #0x382bd14 ; 
006B1A4A0  mov      w8, #1
006B1A4A4  strb     w8, [x21, #0xa0f]
006B1A4A8  adrp     x8, #0x8f3f000
006B1A4AC  ldr      x8, [x8, #0x358]
006B1A4B0  ldr      x2, [x8]
006B1A4B4  ldrb     w8, [x2, #0x53]
006B1A4B8  tbnz     w8, #5, #0x6b1a4d0
006B1A4BC  mov      x0, x19
006B1A4C0  str      x20, [x0, #0x68]!
006B1A4C4  mov      x1, x20
006B1A4C8  bl       #0x382bcb8 ; 
006B1A4CC  b        #0x6b1a4e0 ; 
006B1A4D0  ldr      x8, [x2, #0x60]
006B1A4D4  mov      x0, x19
006B1A4D8  mov      x1, x20
006B1A4DC  blr      x8
006B1A4E0  mov      x0, x19
006B1A4E4  mov      x1, xzr
006B1A4E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1A4EC  adrp     x21, #0x959f000
006B1A4F0  ldrb     w8, [x21, #0xa10]
006B1A4F4  mov      x20, x0
006B1A4F8  cbnz     w8, #0x6b1a510
006B1A4FC  adrp     x0, #0x8f3f000
006B1A500  ldr      x0, [x0, #0x368]
006B1A504  bl       #0x382bd14 ; 
006B1A508  mov      w8, #1
006B1A50C  strb     w8, [x21, #0xa10]
006B1A510  adrp     x8, #0x8f3f000
006B1A514  ldr      x8, [x8, #0x368]
006B1A518  ldr      x2, [x8]
006B1A51C  ldrb     w8, [x2, #0x53]
006B1A520  tbnz     w8, #5, #0x6b1a538
006B1A524  mov      x0, x19
006B1A528  str      x20, [x0, #0x70]!
006B1A52C  mov      x1, x20
006B1A530  bl       #0x382bcb8 ; 
006B1A534  b        #0x6b1a548 ; 
006B1A538  ldr      x8, [x2, #0x60]
006B1A53C  mov      x0, x19
006B1A540  mov      x1, x20
006B1A544  blr      x8
006B1A548  mov      x0, x19
006B1A54C  mov      x1, xzr
006B1A550  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A554  adrp     x21, #0x959f000
006B1A558  ldrb     w8, [x21, #0xa11]
006B1A55C  mov      w20, w0
006B1A560  cbnz     w8, #0x6b1a578
006B1A564  adrp     x0, #0x8f3f000
006B1A568  ldr      x0, [x0, #0x378]
006B1A56C  bl       #0x382bd14 ; 
006B1A570  mov      w8, #1
006B1A574  strb     w8, [x21, #0xa11]
006B1A578  adrp     x8, #0x8f3f000
006B1A57C  ldr      x8, [x8, #0x378]
006B1A580  ldr      x2, [x8]
006B1A584  ldrb     w8, [x2, #0x53]
006B1A588  tbnz     w8, #5, #0x6b1a594
006B1A58C  str      w20, [x19, #0x78]
006B1A590  b        #0x6b1a5a4 ; 
006B1A594  ldr      x8, [x2, #0x60]
006B1A598  mov      x0, x19
006B1A59C  mov      w1, w20
006B1A5A0  blr      x8
006B1A5A4  mov      x0, x19
006B1A5A8  mov      x1, xzr
006B1A5AC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B1A5B0  adrp     x21, #0x959f000
006B1A5B4  ldrb     w8, [x21, #0xa12]
006B1A5B8  mov      x20, x0
006B1A5BC  cbnz     w8, #0x6b1a5d4
006B1A5C0  adrp     x0, #0x8f3f000
006B1A5C4  ldr      x0, [x0, #0x388]
006B1A5C8  bl       #0x382bd14 ; 
006B1A5CC  mov      w8, #1
006B1A5D0  strb     w8, [x21, #0xa12]
006B1A5D4  adrp     x8, #0x8f3f000
006B1A5D8  ldr      x8, [x8, #0x388]
006B1A5DC  ldr      x2, [x8]
006B1A5E0  ldrb     w8, [x2, #0x53]
006B1A5E4  tbnz     w8, #5, #0x6b1a5fc
006B1A5E8  mov      x0, x19
006B1A5EC  str      x20, [x0, #0x80]!
006B1A5F0  mov      x1, x20
006B1A5F4  bl       #0x382bcb8 ; 
006B1A5F8  b        #0x6b1a60c ; 
006B1A5FC  ldr      x8, [x2, #0x60]
006B1A600  mov      x0, x19
006B1A604  mov      x1, x20
006B1A608  blr      x8
006B1A60C  mov      x0, x19
006B1A610  mov      x1, xzr
006B1A614  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1A618  adrp     x21, #0x959f000
006B1A61C  ldrb     w8, [x21, #0xa13]
006B1A620  mov      w20, w0
006B1A624  cbnz     w8, #0x6b1a63c
006B1A628  adrp     x0, #0x8f3f000
006B1A62C  ldr      x0, [x0, #0x398]
006B1A630  bl       #0x382bd14 ; 
006B1A634  mov      w8, #1
006B1A638  strb     w8, [x21, #0xa13]
006B1A63C  adrp     x8, #0x8f3f000
006B1A640  ldr      x8, [x8, #0x398]
006B1A644  ldr      x2, [x8]
006B1A648  ldrb     w8, [x2, #0x53]
006B1A64C  tbnz     w8, #5, #0x6b1a658
006B1A650  str      w20, [x19, #0x88]
006B1A654  b        #0x6b1a668 ; 
006B1A658  ldr      x8, [x2, #0x60]
006B1A65C  mov      x0, x19
006B1A660  mov      w1, w20
006B1A664  blr      x8
006B1A668  mov      x0, x19
006B1A66C  mov      x1, xzr
006B1A670  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B1A674  adrp     x21, #0x959f000
006B1A678  ldrb     w8, [x21, #0xa14]
006B1A67C  mov      x20, x0
006B1A680  cbnz     w8, #0x6b1a698
006B1A684  adrp     x0, #0x8f3f000
006B1A688  ldr      x0, [x0, #0x3a8]
006B1A68C  bl       #0x382bd14 ; 
006B1A690  mov      w8, #1
006B1A694  strb     w8, [x21, #0xa14]
006B1A698  adrp     x8, #0x8f3f000
006B1A69C  ldr      x8, [x8, #0x3a8]
006B1A6A0  ldr      x2, [x8]
006B1A6A4  ldrb     w8, [x2, #0x53]
006B1A6A8  tbnz     w8, #5, #0x6b1a6c0
006B1A6AC  mov      x0, x19
006B1A6B0  str      x20, [x0, #0x90]!
006B1A6B4  mov      x1, x20
006B1A6B8  bl       #0x382bcb8 ; 
006B1A6BC  b        #0x6b1a6d0 ; 
006B1A6C0  ldr      x8, [x2, #0x60]
006B1A6C4  mov      x0, x19
006B1A6C8  mov      x1, x20
006B1A6CC  blr      x8
006B1A6D0  mov      x0, x19
006B1A6D4  mov      x1, xzr
006B1A6D8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B1A6DC  adrp     x21, #0x959f000
006B1A6E0  ldrb     w8, [x21, #0xa15]
006B1A6E4  mov      x20, x0
006B1A6E8  cbnz     w8, #0x6b1a700
006B1A6EC  adrp     x0, #0x8f3f000
006B1A6F0  ldr      x0, [x0, #0x3b8]
006B1A6F4  bl       #0x382bd14 ; 
006B1A6F8  mov      w8, #1
006B1A6FC  strb     w8, [x21, #0xa15]
006B1A700  adrp     x8, #0x8f3f000
006B1A704  ldr      x8, [x8, #0x3b8]
006B1A708  ldr      x2, [x8]
006B1A70C  ldrb     w8, [x2, #0x53]
006B1A710  tbnz     w8, #5, #0x6b1a728
006B1A714  str      x20, [x19, #0x98]!
006B1A718  mov      x0, x19
006B1A71C  mov      x1, x20
006B1A720  bl       #0x382bcb8 ; 
006B1A724  b        #0x6b1a738 ; 
006B1A728  ldr      x8, [x2, #0x60]
006B1A72C  mov      x0, x19
006B1A730  mov      x1, x20
006B1A734  blr      x8
006B1A738  ldp      x20, x19, [sp, #0x10]
006B1A73C  mov      w0, #1
006B1A740  ldp      x30, x21, [sp], #0x20
006B1A744  ret      

