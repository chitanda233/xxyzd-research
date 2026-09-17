; LocalModels.Bean.MissionMulti_WaterfallMission$$readImpl
; RVA 0x6ABAFD4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ABAFD4  stp      x30, x21, [sp, #-0x20]!
006ABAFD8  stp      x20, x19, [sp, #0x10]
006ABAFDC  adrp     x20, #0x959e000
006ABAFE0  adrp     x21, #0x8f3a000
006ABAFE4  ldrb     w8, [x20, #0x8e5]
006ABAFE8  ldr      x21, [x21, #0xe60]
006ABAFEC  mov      x19, x0
006ABAFF0  tbnz     w8, #0, #0x6abb008
006ABAFF4  adrp     x0, #0x8f3a000
006ABAFF8  ldr      x0, [x0, #0xe60]
006ABAFFC  bl       #0x382bd14 ; 
006ABB000  mov      w8, #1
006ABB004  strb     w8, [x20, #0x8e5]
006ABB008  ldr      x1, [x21]
006ABB00C  ldrb     w8, [x1, #0x53]
006ABB010  tbnz     w8, #5, #0x6abb060
006ABB014  mov      x0, x19
006ABB018  mov      x1, xzr
006ABB01C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB020  adrp     x21, #0x959e000
006ABB024  ldrb     w8, [x21, #0xfe1]
006ABB028  mov      w20, w0
006ABB02C  cbnz     w8, #0x6abb044
006ABB030  adrp     x0, #0x8f3a000
006ABB034  ldr      x0, [x0, #0xcf8]
006ABB038  bl       #0x382bd14 ; 
006ABB03C  mov      w8, #1
006ABB040  strb     w8, [x21, #0xfe1]
006ABB044  adrp     x8, #0x8f3a000
006ABB048  ldr      x8, [x8, #0xcf8]
006ABB04C  ldr      x2, [x8]
006ABB050  ldrb     w8, [x2, #0x53]
006ABB054  tbnz     w8, #5, #0x6abb074
006ABB058  str      w20, [x19, #0x20]
006ABB05C  b        #0x6abb084 ; 
006ABB060  ldr      x2, [x1, #0x60]
006ABB064  mov      x0, x19
006ABB068  ldp      x20, x19, [sp, #0x10]
006ABB06C  ldp      x30, x21, [sp], #0x20
006ABB070  br       x2
006ABB074  ldr      x8, [x2, #0x60]
006ABB078  mov      x0, x19
006ABB07C  mov      w1, w20
006ABB080  blr      x8
006ABB084  mov      x0, x19
006ABB088  mov      x1, xzr
006ABB08C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB090  adrp     x21, #0x959e000
006ABB094  ldrb     w8, [x21, #0xfe2]
006ABB098  mov      w20, w0
006ABB09C  cbnz     w8, #0x6abb0b4
006ABB0A0  adrp     x0, #0x8f3a000
006ABB0A4  ldr      x0, [x0, #0xd08]
006ABB0A8  bl       #0x382bd14 ; 
006ABB0AC  mov      w8, #1
006ABB0B0  strb     w8, [x21, #0xfe2]
006ABB0B4  adrp     x8, #0x8f3a000
006ABB0B8  ldr      x8, [x8, #0xd08]
006ABB0BC  ldr      x2, [x8]
006ABB0C0  ldrb     w8, [x2, #0x53]
006ABB0C4  tbnz     w8, #5, #0x6abb0d0
006ABB0C8  str      w20, [x19, #0x24]
006ABB0CC  b        #0x6abb0e0 ; 
006ABB0D0  ldr      x8, [x2, #0x60]
006ABB0D4  mov      x0, x19
006ABB0D8  mov      w1, w20
006ABB0DC  blr      x8
006ABB0E0  mov      x0, x19
006ABB0E4  mov      x1, xzr
006ABB0E8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABB0EC  adrp     x21, #0x959e000
006ABB0F0  ldrb     w8, [x21, #0xfe3]
006ABB0F4  mov      x20, x0
006ABB0F8  cbnz     w8, #0x6abb110
006ABB0FC  adrp     x0, #0x8f3a000
006ABB100  ldr      x0, [x0, #0xd18]
006ABB104  bl       #0x382bd14 ; 
006ABB108  mov      w8, #1
006ABB10C  strb     w8, [x21, #0xfe3]
006ABB110  adrp     x8, #0x8f3a000
006ABB114  ldr      x8, [x8, #0xd18]
006ABB118  ldr      x2, [x8]
006ABB11C  ldrb     w8, [x2, #0x53]
006ABB120  tbnz     w8, #5, #0x6abb12c
006ABB124  str      x20, [x19, #0x28]
006ABB128  b        #0x6abb13c ; 
006ABB12C  ldr      x8, [x2, #0x60]
006ABB130  mov      x0, x19
006ABB134  mov      x1, x20
006ABB138  blr      x8
006ABB13C  mov      x0, x19
006ABB140  mov      x1, xzr
006ABB144  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABB148  adrp     x21, #0x959e000
006ABB14C  ldrb     w8, [x21, #0xfe4]
006ABB150  mov      x20, x0
006ABB154  cbnz     w8, #0x6abb16c
006ABB158  adrp     x0, #0x8f3a000
006ABB15C  ldr      x0, [x0, #0xd28]
006ABB160  bl       #0x382bd14 ; 
006ABB164  mov      w8, #1
006ABB168  strb     w8, [x21, #0xfe4]
006ABB16C  adrp     x8, #0x8f3a000
006ABB170  ldr      x8, [x8, #0xd28]
006ABB174  ldr      x2, [x8]
006ABB178  ldrb     w8, [x2, #0x53]
006ABB17C  tbnz     w8, #5, #0x6abb188
006ABB180  str      x20, [x19, #0x30]
006ABB184  b        #0x6abb198 ; 
006ABB188  ldr      x8, [x2, #0x60]
006ABB18C  mov      x0, x19
006ABB190  mov      x1, x20
006ABB194  blr      x8
006ABB198  mov      x0, x19
006ABB19C  mov      x1, xzr
006ABB1A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB1A4  adrp     x21, #0x959e000
006ABB1A8  ldrb     w8, [x21, #0xfe5]
006ABB1AC  mov      w20, w0
006ABB1B0  cbnz     w8, #0x6abb1c8
006ABB1B4  adrp     x0, #0x8f3a000
006ABB1B8  ldr      x0, [x0, #0xd38]
006ABB1BC  bl       #0x382bd14 ; 
006ABB1C0  mov      w8, #1
006ABB1C4  strb     w8, [x21, #0xfe5]
006ABB1C8  adrp     x8, #0x8f3a000
006ABB1CC  ldr      x8, [x8, #0xd38]
006ABB1D0  ldr      x2, [x8]
006ABB1D4  ldrb     w8, [x2, #0x53]
006ABB1D8  tbnz     w8, #5, #0x6abb1e4
006ABB1DC  str      w20, [x19, #0x38]
006ABB1E0  b        #0x6abb1f4 ; 
006ABB1E4  ldr      x8, [x2, #0x60]
006ABB1E8  mov      x0, x19
006ABB1EC  mov      w1, w20
006ABB1F0  blr      x8
006ABB1F4  mov      x0, x19
006ABB1F8  mov      x1, xzr
006ABB1FC  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006ABB200  adrp     x21, #0x959e000
006ABB204  ldrb     w8, [x21, #0xfe6]
006ABB208  mov      x20, x0
006ABB20C  cbnz     w8, #0x6abb224
006ABB210  adrp     x0, #0x8f3a000
006ABB214  ldr      x0, [x0, #0xd48]
006ABB218  bl       #0x382bd14 ; 
006ABB21C  mov      w8, #1
006ABB220  strb     w8, [x21, #0xfe6]
006ABB224  adrp     x8, #0x8f3a000
006ABB228  ldr      x8, [x8, #0xd48]
006ABB22C  ldr      x2, [x8]
006ABB230  ldrb     w8, [x2, #0x53]
006ABB234  tbnz     w8, #5, #0x6abb24c
006ABB238  mov      x0, x19
006ABB23C  str      x20, [x0, #0x40]!
006ABB240  mov      x1, x20
006ABB244  bl       #0x382bcb8 ; 
006ABB248  b        #0x6abb25c ; 
006ABB24C  ldr      x8, [x2, #0x60]
006ABB250  mov      x0, x19
006ABB254  mov      x1, x20
006ABB258  blr      x8
006ABB25C  mov      x0, x19
006ABB260  mov      x1, xzr
006ABB264  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABB268  adrp     x21, #0x959e000
006ABB26C  ldrb     w8, [x21, #0xfe7]
006ABB270  mov      x20, x0
006ABB274  cbnz     w8, #0x6abb28c
006ABB278  adrp     x0, #0x8f3a000
006ABB27C  ldr      x0, [x0, #0xd58]
006ABB280  bl       #0x382bd14 ; 
006ABB284  mov      w8, #1
006ABB288  strb     w8, [x21, #0xfe7]
006ABB28C  adrp     x8, #0x8f3a000
006ABB290  ldr      x8, [x8, #0xd58]
006ABB294  ldr      x2, [x8]
006ABB298  ldrb     w8, [x2, #0x53]
006ABB29C  tbnz     w8, #5, #0x6abb2b4
006ABB2A0  mov      x0, x19
006ABB2A4  str      x20, [x0, #0x48]!
006ABB2A8  mov      x1, x20
006ABB2AC  bl       #0x382bcb8 ; 
006ABB2B0  b        #0x6abb2c4 ; 
006ABB2B4  ldr      x8, [x2, #0x60]
006ABB2B8  mov      x0, x19
006ABB2BC  mov      x1, x20
006ABB2C0  blr      x8
006ABB2C4  mov      x0, x19
006ABB2C8  mov      x1, xzr
006ABB2CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB2D0  adrp     x21, #0x959e000
006ABB2D4  ldrb     w8, [x21, #0xfe8]
006ABB2D8  mov      w20, w0
006ABB2DC  cbnz     w8, #0x6abb2f4
006ABB2E0  adrp     x0, #0x8f3a000
006ABB2E4  ldr      x0, [x0, #0xd68]
006ABB2E8  bl       #0x382bd14 ; 
006ABB2EC  mov      w8, #1
006ABB2F0  strb     w8, [x21, #0xfe8]
006ABB2F4  adrp     x8, #0x8f3a000
006ABB2F8  ldr      x8, [x8, #0xd68]
006ABB2FC  ldr      x2, [x8]
006ABB300  ldrb     w8, [x2, #0x53]
006ABB304  tbnz     w8, #5, #0x6abb310
006ABB308  str      w20, [x19, #0x50]
006ABB30C  b        #0x6abb320 ; 
006ABB310  ldr      x8, [x2, #0x60]
006ABB314  mov      x0, x19
006ABB318  mov      w1, w20
006ABB31C  blr      x8
006ABB320  mov      x0, x19
006ABB324  mov      x1, xzr
006ABB328  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABB32C  adrp     x21, #0x959e000
006ABB330  ldrb     w8, [x21, #0xfe9]
006ABB334  mov      x20, x0
006ABB338  cbnz     w8, #0x6abb350
006ABB33C  adrp     x0, #0x8f3a000
006ABB340  ldr      x0, [x0, #0xd78]
006ABB344  bl       #0x382bd14 ; 
006ABB348  mov      w8, #1
006ABB34C  strb     w8, [x21, #0xfe9]
006ABB350  adrp     x8, #0x8f3a000
006ABB354  ldr      x8, [x8, #0xd78]
006ABB358  ldr      x2, [x8]
006ABB35C  ldrb     w8, [x2, #0x53]
006ABB360  tbnz     w8, #5, #0x6abb378
006ABB364  mov      x0, x19
006ABB368  str      x20, [x0, #0x58]!
006ABB36C  mov      x1, x20
006ABB370  bl       #0x382bcb8 ; 
006ABB374  b        #0x6abb388 ; 
006ABB378  ldr      x8, [x2, #0x60]
006ABB37C  mov      x0, x19
006ABB380  mov      x1, x20
006ABB384  blr      x8
006ABB388  mov      x0, x19
006ABB38C  mov      x1, xzr
006ABB390  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABB394  adrp     x21, #0x959e000
006ABB398  ldrb     w8, [x21, #0xfea]
006ABB39C  mov      x20, x0
006ABB3A0  cbnz     w8, #0x6abb3b8
006ABB3A4  adrp     x0, #0x8f3a000
006ABB3A8  ldr      x0, [x0, #0xd88]
006ABB3AC  bl       #0x382bd14 ; 
006ABB3B0  mov      w8, #1
006ABB3B4  strb     w8, [x21, #0xfea]
006ABB3B8  adrp     x8, #0x8f3a000
006ABB3BC  ldr      x8, [x8, #0xd88]
006ABB3C0  ldr      x2, [x8]
006ABB3C4  ldrb     w8, [x2, #0x53]
006ABB3C8  tbnz     w8, #5, #0x6abb3e0
006ABB3CC  mov      x0, x19
006ABB3D0  str      x20, [x0, #0x60]!
006ABB3D4  mov      x1, x20
006ABB3D8  bl       #0x382bcb8 ; 
006ABB3DC  b        #0x6abb3f0 ; 
006ABB3E0  ldr      x8, [x2, #0x60]
006ABB3E4  mov      x0, x19
006ABB3E8  mov      x1, x20
006ABB3EC  blr      x8
006ABB3F0  mov      x0, x19
006ABB3F4  mov      x1, xzr
006ABB3F8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABB3FC  adrp     x21, #0x959e000
006ABB400  ldrb     w8, [x21, #0xfeb]
006ABB404  mov      x20, x0
006ABB408  cbnz     w8, #0x6abb420
006ABB40C  adrp     x0, #0x8f3a000
006ABB410  ldr      x0, [x0, #0xd98]
006ABB414  bl       #0x382bd14 ; 
006ABB418  mov      w8, #1
006ABB41C  strb     w8, [x21, #0xfeb]
006ABB420  adrp     x8, #0x8f3a000
006ABB424  ldr      x8, [x8, #0xd98]
006ABB428  ldr      x2, [x8]
006ABB42C  ldrb     w8, [x2, #0x53]
006ABB430  tbnz     w8, #5, #0x6abb448
006ABB434  mov      x0, x19
006ABB438  str      x20, [x0, #0x68]!
006ABB43C  mov      x1, x20
006ABB440  bl       #0x382bcb8 ; 
006ABB444  b        #0x6abb458 ; 
006ABB448  ldr      x8, [x2, #0x60]
006ABB44C  mov      x0, x19
006ABB450  mov      x1, x20
006ABB454  blr      x8
006ABB458  mov      x0, x19
006ABB45C  mov      x1, xzr
006ABB460  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABB464  adrp     x21, #0x959e000
006ABB468  ldrb     w8, [x21, #0xfec]
006ABB46C  mov      x20, x0
006ABB470  cbnz     w8, #0x6abb488
006ABB474  adrp     x0, #0x8f3a000
006ABB478  ldr      x0, [x0, #0xda8]
006ABB47C  bl       #0x382bd14 ; 
006ABB480  mov      w8, #1
006ABB484  strb     w8, [x21, #0xfec]
006ABB488  adrp     x8, #0x8f3a000
006ABB48C  ldr      x8, [x8, #0xda8]
006ABB490  ldr      x2, [x8]
006ABB494  ldrb     w8, [x2, #0x53]
006ABB498  tbnz     w8, #5, #0x6abb4b0
006ABB49C  mov      x0, x19
006ABB4A0  str      x20, [x0, #0x70]!
006ABB4A4  mov      x1, x20
006ABB4A8  bl       #0x382bcb8 ; 
006ABB4AC  b        #0x6abb4c0 ; 
006ABB4B0  ldr      x8, [x2, #0x60]
006ABB4B4  mov      x0, x19
006ABB4B8  mov      x1, x20
006ABB4BC  blr      x8
006ABB4C0  mov      x0, x19
006ABB4C4  mov      x1, xzr
006ABB4C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB4CC  adrp     x21, #0x959e000
006ABB4D0  ldrb     w8, [x21, #0xfed]
006ABB4D4  mov      w20, w0
006ABB4D8  cbnz     w8, #0x6abb4f0
006ABB4DC  adrp     x0, #0x8f3a000
006ABB4E0  ldr      x0, [x0, #0xdb8]
006ABB4E4  bl       #0x382bd14 ; 
006ABB4E8  mov      w8, #1
006ABB4EC  strb     w8, [x21, #0xfed]
006ABB4F0  adrp     x8, #0x8f3a000
006ABB4F4  ldr      x8, [x8, #0xdb8]
006ABB4F8  ldr      x2, [x8]
006ABB4FC  ldrb     w8, [x2, #0x53]
006ABB500  tbnz     w8, #5, #0x6abb50c
006ABB504  str      w20, [x19, #0x78]
006ABB508  b        #0x6abb51c ; 
006ABB50C  ldr      x8, [x2, #0x60]
006ABB510  mov      x0, x19
006ABB514  mov      w1, w20
006ABB518  blr      x8
006ABB51C  mov      x0, x19
006ABB520  mov      x1, xzr
006ABB524  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB528  adrp     x21, #0x959e000
006ABB52C  ldrb     w8, [x21, #0xfee]
006ABB530  mov      w20, w0
006ABB534  cbnz     w8, #0x6abb54c
006ABB538  adrp     x0, #0x8f3a000
006ABB53C  ldr      x0, [x0, #0xdc8]
006ABB540  bl       #0x382bd14 ; 
006ABB544  mov      w8, #1
006ABB548  strb     w8, [x21, #0xfee]
006ABB54C  adrp     x8, #0x8f3a000
006ABB550  ldr      x8, [x8, #0xdc8]
006ABB554  ldr      x2, [x8]
006ABB558  ldrb     w8, [x2, #0x53]
006ABB55C  tbnz     w8, #5, #0x6abb568
006ABB560  str      w20, [x19, #0x7c]
006ABB564  b        #0x6abb578 ; 
006ABB568  ldr      x8, [x2, #0x60]
006ABB56C  mov      x0, x19
006ABB570  mov      w1, w20
006ABB574  blr      x8
006ABB578  mov      x0, x19
006ABB57C  mov      x1, xzr
006ABB580  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABB584  adrp     x21, #0x959e000
006ABB588  ldrb     w8, [x21, #0xfef]
006ABB58C  mov      x20, x0
006ABB590  cbnz     w8, #0x6abb5a8
006ABB594  adrp     x0, #0x8f3a000
006ABB598  ldr      x0, [x0, #0xdd8]
006ABB59C  bl       #0x382bd14 ; 
006ABB5A0  mov      w8, #1
006ABB5A4  strb     w8, [x21, #0xfef]
006ABB5A8  adrp     x8, #0x8f3a000
006ABB5AC  ldr      x8, [x8, #0xdd8]
006ABB5B0  ldr      x2, [x8]
006ABB5B4  ldrb     w8, [x2, #0x53]
006ABB5B8  tbnz     w8, #5, #0x6abb5c4
006ABB5BC  str      x20, [x19, #0x80]
006ABB5C0  b        #0x6abb5d4 ; 
006ABB5C4  ldr      x8, [x2, #0x60]
006ABB5C8  mov      x0, x19
006ABB5CC  mov      x1, x20
006ABB5D0  blr      x8
006ABB5D4  mov      x0, x19
006ABB5D8  mov      x1, xzr
006ABB5DC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABB5E0  adrp     x21, #0x959e000
006ABB5E4  ldrb     w8, [x21, #0xff0]
006ABB5E8  mov      x20, x0
006ABB5EC  cbnz     w8, #0x6abb604
006ABB5F0  adrp     x0, #0x8f3a000
006ABB5F4  ldr      x0, [x0, #0xde8]
006ABB5F8  bl       #0x382bd14 ; 
006ABB5FC  mov      w8, #1
006ABB600  strb     w8, [x21, #0xff0]
006ABB604  adrp     x8, #0x8f3a000
006ABB608  ldr      x8, [x8, #0xde8]
006ABB60C  ldr      x2, [x8]
006ABB610  ldrb     w8, [x2, #0x53]
006ABB614  tbnz     w8, #5, #0x6abb620
006ABB618  str      x20, [x19, #0x88]
006ABB61C  b        #0x6abb630 ; 
006ABB620  ldr      x8, [x2, #0x60]
006ABB624  mov      x0, x19
006ABB628  mov      x1, x20
006ABB62C  blr      x8
006ABB630  mov      x0, x19
006ABB634  mov      x1, xzr
006ABB638  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABB63C  adrp     x21, #0x959e000
006ABB640  ldrb     w8, [x21, #0xff1]
006ABB644  mov      x20, x0
006ABB648  cbnz     w8, #0x6abb660
006ABB64C  adrp     x0, #0x8f3a000
006ABB650  ldr      x0, [x0, #0xdf8]
006ABB654  bl       #0x382bd14 ; 
006ABB658  mov      w8, #1
006ABB65C  strb     w8, [x21, #0xff1]
006ABB660  adrp     x8, #0x8f3a000
006ABB664  ldr      x8, [x8, #0xdf8]
006ABB668  ldr      x2, [x8]
006ABB66C  ldrb     w8, [x2, #0x53]
006ABB670  tbnz     w8, #5, #0x6abb67c
006ABB674  str      x20, [x19, #0x90]
006ABB678  b        #0x6abb68c ; 
006ABB67C  ldr      x8, [x2, #0x60]
006ABB680  mov      x0, x19
006ABB684  mov      x1, x20
006ABB688  blr      x8
006ABB68C  mov      x0, x19
006ABB690  mov      x1, xzr
006ABB694  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABB698  adrp     x21, #0x959e000
006ABB69C  ldrb     w8, [x21, #0xff2]
006ABB6A0  mov      x20, x0
006ABB6A4  cbnz     w8, #0x6abb6bc
006ABB6A8  adrp     x0, #0x8f3a000
006ABB6AC  ldr      x0, [x0, #0xe08]
006ABB6B0  bl       #0x382bd14 ; 
006ABB6B4  mov      w8, #1
006ABB6B8  strb     w8, [x21, #0xff2]
006ABB6BC  adrp     x8, #0x8f3a000
006ABB6C0  ldr      x8, [x8, #0xe08]
006ABB6C4  ldr      x2, [x8]
006ABB6C8  ldrb     w8, [x2, #0x53]
006ABB6CC  tbnz     w8, #5, #0x6abb6d8
006ABB6D0  str      x20, [x19, #0x98]
006ABB6D4  b        #0x6abb6e8 ; 
006ABB6D8  ldr      x8, [x2, #0x60]
006ABB6DC  mov      x0, x19
006ABB6E0  mov      x1, x20
006ABB6E4  blr      x8
006ABB6E8  mov      x0, x19
006ABB6EC  mov      x1, xzr
006ABB6F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB6F4  adrp     x21, #0x959e000
006ABB6F8  ldrb     w8, [x21, #0xff3]
006ABB6FC  mov      w20, w0
006ABB700  cbnz     w8, #0x6abb718
006ABB704  adrp     x0, #0x8f3a000
006ABB708  ldr      x0, [x0, #0xe18]
006ABB70C  bl       #0x382bd14 ; 
006ABB710  mov      w8, #1
006ABB714  strb     w8, [x21, #0xff3]
006ABB718  adrp     x8, #0x8f3a000
006ABB71C  ldr      x8, [x8, #0xe18]
006ABB720  ldr      x2, [x8]
006ABB724  ldrb     w8, [x2, #0x53]
006ABB728  tbnz     w8, #5, #0x6abb734
006ABB72C  str      w20, [x19, #0xa0]
006ABB730  b        #0x6abb744 ; 
006ABB734  ldr      x8, [x2, #0x60]
006ABB738  mov      x0, x19
006ABB73C  mov      w1, w20
006ABB740  blr      x8
006ABB744  mov      x0, x19
006ABB748  mov      x1, xzr
006ABB74C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABB750  adrp     x21, #0x959e000
006ABB754  ldrb     w8, [x21, #0xff4]
006ABB758  mov      x20, x0
006ABB75C  cbnz     w8, #0x6abb774
006ABB760  adrp     x0, #0x8f3a000
006ABB764  ldr      x0, [x0, #0xe28]
006ABB768  bl       #0x382bd14 ; 
006ABB76C  mov      w8, #1
006ABB770  strb     w8, [x21, #0xff4]
006ABB774  adrp     x8, #0x8f3a000
006ABB778  ldr      x8, [x8, #0xe28]
006ABB77C  ldr      x2, [x8]
006ABB780  ldrb     w8, [x2, #0x53]
006ABB784  tbnz     w8, #5, #0x6abb79c
006ABB788  mov      x0, x19
006ABB78C  str      x20, [x0, #0xa8]!
006ABB790  mov      x1, x20
006ABB794  bl       #0x382bcb8 ; 
006ABB798  b        #0x6abb7ac ; 
006ABB79C  ldr      x8, [x2, #0x60]
006ABB7A0  mov      x0, x19
006ABB7A4  mov      x1, x20
006ABB7A8  blr      x8
006ABB7AC  mov      x0, x19
006ABB7B0  mov      x1, xzr
006ABB7B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABB7B8  adrp     x21, #0x959e000
006ABB7BC  ldrb     w8, [x21, #0xff5]
006ABB7C0  mov      w20, w0
006ABB7C4  cbnz     w8, #0x6abb7dc
006ABB7C8  adrp     x0, #0x8f3a000
006ABB7CC  ldr      x0, [x0, #0xe38]
006ABB7D0  bl       #0x382bd14 ; 
006ABB7D4  mov      w8, #1
006ABB7D8  strb     w8, [x21, #0xff5]
006ABB7DC  adrp     x8, #0x8f3a000
006ABB7E0  ldr      x8, [x8, #0xe38]
006ABB7E4  ldr      x2, [x8]
006ABB7E8  ldrb     w8, [x2, #0x53]
006ABB7EC  tbnz     w8, #5, #0x6abb7f8
006ABB7F0  str      w20, [x19, #0xb0]
006ABB7F4  b        #0x6abb808 ; 
006ABB7F8  ldr      x8, [x2, #0x60]
006ABB7FC  mov      x0, x19
006ABB800  mov      w1, w20
006ABB804  blr      x8
006ABB808  mov      x0, x19
006ABB80C  mov      x1, xzr
006ABB810  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ABB814  adrp     x21, #0x959e000
006ABB818  ldrb     w8, [x21, #0xff6]
006ABB81C  mov      x20, x0
006ABB820  cbnz     w8, #0x6abb838
006ABB824  adrp     x0, #0x8f3a000
006ABB828  ldr      x0, [x0, #0xe48]
006ABB82C  bl       #0x382bd14 ; 
006ABB830  mov      w8, #1
006ABB834  strb     w8, [x21, #0xff6]
006ABB838  adrp     x8, #0x8f3a000
006ABB83C  ldr      x8, [x8, #0xe48]
006ABB840  ldr      x2, [x8]
006ABB844  ldrb     w8, [x2, #0x53]
006ABB848  tbnz     w8, #5, #0x6abb860
006ABB84C  mov      x0, x19
006ABB850  str      x20, [x0, #0xb8]!
006ABB854  mov      x1, x20
006ABB858  bl       #0x382bcb8 ; 
006ABB85C  b        #0x6abb870 ; 
006ABB860  ldr      x8, [x2, #0x60]
006ABB864  mov      x0, x19
006ABB868  mov      x1, x20
006ABB86C  blr      x8
006ABB870  mov      x0, x19
006ABB874  mov      x1, xzr
006ABB878  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ABB87C  adrp     x21, #0x959e000
006ABB880  ldrb     w8, [x21, #0xff7]
006ABB884  mov      x20, x0
006ABB888  cbnz     w8, #0x6abb8a0
006ABB88C  adrp     x0, #0x8f3a000
006ABB890  ldr      x0, [x0, #0xe58]
006ABB894  bl       #0x382bd14 ; 
006ABB898  mov      w8, #1
006ABB89C  strb     w8, [x21, #0xff7]
006ABB8A0  adrp     x8, #0x8f3a000
006ABB8A4  ldr      x8, [x8, #0xe58]
006ABB8A8  ldr      x2, [x8]
006ABB8AC  ldrb     w8, [x2, #0x53]
006ABB8B0  tbnz     w8, #5, #0x6abb8c8
006ABB8B4  str      x20, [x19, #0xc0]!
006ABB8B8  mov      x0, x19
006ABB8BC  mov      x1, x20
006ABB8C0  bl       #0x382bcb8 ; 
006ABB8C4  b        #0x6abb8d8 ; 
006ABB8C8  ldr      x8, [x2, #0x60]
006ABB8CC  mov      x0, x19
006ABB8D0  mov      x1, x20
006ABB8D4  blr      x8
006ABB8D8  ldp      x20, x19, [sp, #0x10]
006ABB8DC  mov      w0, #1
006ABB8E0  ldp      x30, x21, [sp], #0x20
006ABB8E4  ret      

