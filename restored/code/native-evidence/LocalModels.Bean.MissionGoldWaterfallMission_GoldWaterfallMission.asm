; LocalModels.Bean.MissionGoldWaterfallMission_GoldWaterfallMission$$readImpl
; RVA 0x6AB5538; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AB5538  stp      x30, x21, [sp, #-0x20]!
006AB553C  stp      x20, x19, [sp, #0x10]
006AB5540  adrp     x20, #0x959e000
006AB5544  adrp     x21, #0x8f3a000
006AB5548  ldrb     w8, [x20, #0x852]
006AB554C  ldr      x21, [x21, #0xa70]
006AB5550  mov      x19, x0
006AB5554  tbnz     w8, #0, #0x6ab556c
006AB5558  adrp     x0, #0x8f3a000
006AB555C  ldr      x0, [x0, #0xa70]
006AB5560  bl       #0x382bd14 ; 
006AB5564  mov      w8, #1
006AB5568  strb     w8, [x20, #0x852]
006AB556C  ldr      x1, [x21]
006AB5570  ldrb     w8, [x1, #0x53]
006AB5574  tbnz     w8, #5, #0x6ab55c4
006AB5578  mov      x0, x19
006AB557C  mov      x1, xzr
006AB5580  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB5584  adrp     x21, #0x959e000
006AB5588  ldrb     w8, [x21, #0xf9c]
006AB558C  mov      w20, w0
006AB5590  cbnz     w8, #0x6ab55a8
006AB5594  adrp     x0, #0x8f3a000
006AB5598  ldr      x0, [x0, #0x908]
006AB559C  bl       #0x382bd14 ; 
006AB55A0  mov      w8, #1
006AB55A4  strb     w8, [x21, #0xf9c]
006AB55A8  adrp     x8, #0x8f3a000
006AB55AC  ldr      x8, [x8, #0x908]
006AB55B0  ldr      x2, [x8]
006AB55B4  ldrb     w8, [x2, #0x53]
006AB55B8  tbnz     w8, #5, #0x6ab55d8
006AB55BC  str      w20, [x19, #0x20]
006AB55C0  b        #0x6ab55e8 ; 
006AB55C4  ldr      x2, [x1, #0x60]
006AB55C8  mov      x0, x19
006AB55CC  ldp      x20, x19, [sp, #0x10]
006AB55D0  ldp      x30, x21, [sp], #0x20
006AB55D4  br       x2
006AB55D8  ldr      x8, [x2, #0x60]
006AB55DC  mov      x0, x19
006AB55E0  mov      w1, w20
006AB55E4  blr      x8
006AB55E8  mov      x0, x19
006AB55EC  mov      x1, xzr
006AB55F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB55F4  adrp     x21, #0x959e000
006AB55F8  ldrb     w8, [x21, #0xf9d]
006AB55FC  mov      w20, w0
006AB5600  cbnz     w8, #0x6ab5618
006AB5604  adrp     x0, #0x8f3a000
006AB5608  ldr      x0, [x0, #0x918]
006AB560C  bl       #0x382bd14 ; 
006AB5610  mov      w8, #1
006AB5614  strb     w8, [x21, #0xf9d]
006AB5618  adrp     x8, #0x8f3a000
006AB561C  ldr      x8, [x8, #0x918]
006AB5620  ldr      x2, [x8]
006AB5624  ldrb     w8, [x2, #0x53]
006AB5628  tbnz     w8, #5, #0x6ab5634
006AB562C  str      w20, [x19, #0x24]
006AB5630  b        #0x6ab5644 ; 
006AB5634  ldr      x8, [x2, #0x60]
006AB5638  mov      x0, x19
006AB563C  mov      w1, w20
006AB5640  blr      x8
006AB5644  mov      x0, x19
006AB5648  mov      x1, xzr
006AB564C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB5650  adrp     x21, #0x959e000
006AB5654  ldrb     w8, [x21, #0xf9e]
006AB5658  mov      x20, x0
006AB565C  cbnz     w8, #0x6ab5674
006AB5660  adrp     x0, #0x8f3a000
006AB5664  ldr      x0, [x0, #0x928]
006AB5668  bl       #0x382bd14 ; 
006AB566C  mov      w8, #1
006AB5670  strb     w8, [x21, #0xf9e]
006AB5674  adrp     x8, #0x8f3a000
006AB5678  ldr      x8, [x8, #0x928]
006AB567C  ldr      x2, [x8]
006AB5680  ldrb     w8, [x2, #0x53]
006AB5684  tbnz     w8, #5, #0x6ab5690
006AB5688  str      x20, [x19, #0x28]
006AB568C  b        #0x6ab56a0 ; 
006AB5690  ldr      x8, [x2, #0x60]
006AB5694  mov      x0, x19
006AB5698  mov      x1, x20
006AB569C  blr      x8
006AB56A0  mov      x0, x19
006AB56A4  mov      x1, xzr
006AB56A8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB56AC  adrp     x21, #0x959e000
006AB56B0  ldrb     w8, [x21, #0xf9f]
006AB56B4  mov      x20, x0
006AB56B8  cbnz     w8, #0x6ab56d0
006AB56BC  adrp     x0, #0x8f3a000
006AB56C0  ldr      x0, [x0, #0x938]
006AB56C4  bl       #0x382bd14 ; 
006AB56C8  mov      w8, #1
006AB56CC  strb     w8, [x21, #0xf9f]
006AB56D0  adrp     x8, #0x8f3a000
006AB56D4  ldr      x8, [x8, #0x938]
006AB56D8  ldr      x2, [x8]
006AB56DC  ldrb     w8, [x2, #0x53]
006AB56E0  tbnz     w8, #5, #0x6ab56ec
006AB56E4  str      x20, [x19, #0x30]
006AB56E8  b        #0x6ab56fc ; 
006AB56EC  ldr      x8, [x2, #0x60]
006AB56F0  mov      x0, x19
006AB56F4  mov      x1, x20
006AB56F8  blr      x8
006AB56FC  mov      x0, x19
006AB5700  mov      x1, xzr
006AB5704  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB5708  adrp     x21, #0x959e000
006AB570C  ldrb     w8, [x21, #0xfa0]
006AB5710  mov      w20, w0
006AB5714  cbnz     w8, #0x6ab572c
006AB5718  adrp     x0, #0x8f3a000
006AB571C  ldr      x0, [x0, #0x948]
006AB5720  bl       #0x382bd14 ; 
006AB5724  mov      w8, #1
006AB5728  strb     w8, [x21, #0xfa0]
006AB572C  adrp     x8, #0x8f3a000
006AB5730  ldr      x8, [x8, #0x948]
006AB5734  ldr      x2, [x8]
006AB5738  ldrb     w8, [x2, #0x53]
006AB573C  tbnz     w8, #5, #0x6ab5748
006AB5740  str      w20, [x19, #0x38]
006AB5744  b        #0x6ab5758 ; 
006AB5748  ldr      x8, [x2, #0x60]
006AB574C  mov      x0, x19
006AB5750  mov      w1, w20
006AB5754  blr      x8
006AB5758  mov      x0, x19
006AB575C  mov      x1, xzr
006AB5760  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006AB5764  adrp     x21, #0x959e000
006AB5768  ldrb     w8, [x21, #0xfa1]
006AB576C  mov      x20, x0
006AB5770  cbnz     w8, #0x6ab5788
006AB5774  adrp     x0, #0x8f3a000
006AB5778  ldr      x0, [x0, #0x958]
006AB577C  bl       #0x382bd14 ; 
006AB5780  mov      w8, #1
006AB5784  strb     w8, [x21, #0xfa1]
006AB5788  adrp     x8, #0x8f3a000
006AB578C  ldr      x8, [x8, #0x958]
006AB5790  ldr      x2, [x8]
006AB5794  ldrb     w8, [x2, #0x53]
006AB5798  tbnz     w8, #5, #0x6ab57b0
006AB579C  mov      x0, x19
006AB57A0  str      x20, [x0, #0x40]!
006AB57A4  mov      x1, x20
006AB57A8  bl       #0x382bcb8 ; 
006AB57AC  b        #0x6ab57c0 ; 
006AB57B0  ldr      x8, [x2, #0x60]
006AB57B4  mov      x0, x19
006AB57B8  mov      x1, x20
006AB57BC  blr      x8
006AB57C0  mov      x0, x19
006AB57C4  mov      x1, xzr
006AB57C8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB57CC  adrp     x21, #0x959e000
006AB57D0  ldrb     w8, [x21, #0xfa2]
006AB57D4  mov      x20, x0
006AB57D8  cbnz     w8, #0x6ab57f0
006AB57DC  adrp     x0, #0x8f3a000
006AB57E0  ldr      x0, [x0, #0x968]
006AB57E4  bl       #0x382bd14 ; 
006AB57E8  mov      w8, #1
006AB57EC  strb     w8, [x21, #0xfa2]
006AB57F0  adrp     x8, #0x8f3a000
006AB57F4  ldr      x8, [x8, #0x968]
006AB57F8  ldr      x2, [x8]
006AB57FC  ldrb     w8, [x2, #0x53]
006AB5800  tbnz     w8, #5, #0x6ab5818
006AB5804  mov      x0, x19
006AB5808  str      x20, [x0, #0x48]!
006AB580C  mov      x1, x20
006AB5810  bl       #0x382bcb8 ; 
006AB5814  b        #0x6ab5828 ; 
006AB5818  ldr      x8, [x2, #0x60]
006AB581C  mov      x0, x19
006AB5820  mov      x1, x20
006AB5824  blr      x8
006AB5828  mov      x0, x19
006AB582C  mov      x1, xzr
006AB5830  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB5834  adrp     x21, #0x959e000
006AB5838  ldrb     w8, [x21, #0xfa3]
006AB583C  mov      w20, w0
006AB5840  cbnz     w8, #0x6ab5858
006AB5844  adrp     x0, #0x8f3a000
006AB5848  ldr      x0, [x0, #0x978]
006AB584C  bl       #0x382bd14 ; 
006AB5850  mov      w8, #1
006AB5854  strb     w8, [x21, #0xfa3]
006AB5858  adrp     x8, #0x8f3a000
006AB585C  ldr      x8, [x8, #0x978]
006AB5860  ldr      x2, [x8]
006AB5864  ldrb     w8, [x2, #0x53]
006AB5868  tbnz     w8, #5, #0x6ab5874
006AB586C  str      w20, [x19, #0x50]
006AB5870  b        #0x6ab5884 ; 
006AB5874  ldr      x8, [x2, #0x60]
006AB5878  mov      x0, x19
006AB587C  mov      w1, w20
006AB5880  blr      x8
006AB5884  mov      x0, x19
006AB5888  mov      x1, xzr
006AB588C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB5890  adrp     x21, #0x959e000
006AB5894  ldrb     w8, [x21, #0xfa4]
006AB5898  mov      x20, x0
006AB589C  cbnz     w8, #0x6ab58b4
006AB58A0  adrp     x0, #0x8f3a000
006AB58A4  ldr      x0, [x0, #0x988]
006AB58A8  bl       #0x382bd14 ; 
006AB58AC  mov      w8, #1
006AB58B0  strb     w8, [x21, #0xfa4]
006AB58B4  adrp     x8, #0x8f3a000
006AB58B8  ldr      x8, [x8, #0x988]
006AB58BC  ldr      x2, [x8]
006AB58C0  ldrb     w8, [x2, #0x53]
006AB58C4  tbnz     w8, #5, #0x6ab58dc
006AB58C8  mov      x0, x19
006AB58CC  str      x20, [x0, #0x58]!
006AB58D0  mov      x1, x20
006AB58D4  bl       #0x382bcb8 ; 
006AB58D8  b        #0x6ab58ec ; 
006AB58DC  ldr      x8, [x2, #0x60]
006AB58E0  mov      x0, x19
006AB58E4  mov      x1, x20
006AB58E8  blr      x8
006AB58EC  mov      x0, x19
006AB58F0  mov      x1, xzr
006AB58F4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB58F8  adrp     x21, #0x959e000
006AB58FC  ldrb     w8, [x21, #0xfa5]
006AB5900  mov      x20, x0
006AB5904  cbnz     w8, #0x6ab591c
006AB5908  adrp     x0, #0x8f3a000
006AB590C  ldr      x0, [x0, #0x998]
006AB5910  bl       #0x382bd14 ; 
006AB5914  mov      w8, #1
006AB5918  strb     w8, [x21, #0xfa5]
006AB591C  adrp     x8, #0x8f3a000
006AB5920  ldr      x8, [x8, #0x998]
006AB5924  ldr      x2, [x8]
006AB5928  ldrb     w8, [x2, #0x53]
006AB592C  tbnz     w8, #5, #0x6ab5944
006AB5930  mov      x0, x19
006AB5934  str      x20, [x0, #0x60]!
006AB5938  mov      x1, x20
006AB593C  bl       #0x382bcb8 ; 
006AB5940  b        #0x6ab5954 ; 
006AB5944  ldr      x8, [x2, #0x60]
006AB5948  mov      x0, x19
006AB594C  mov      x1, x20
006AB5950  blr      x8
006AB5954  mov      x0, x19
006AB5958  mov      x1, xzr
006AB595C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB5960  adrp     x21, #0x959e000
006AB5964  ldrb     w8, [x21, #0xfa6]
006AB5968  mov      x20, x0
006AB596C  cbnz     w8, #0x6ab5984
006AB5970  adrp     x0, #0x8f3a000
006AB5974  ldr      x0, [x0, #0x9a8]
006AB5978  bl       #0x382bd14 ; 
006AB597C  mov      w8, #1
006AB5980  strb     w8, [x21, #0xfa6]
006AB5984  adrp     x8, #0x8f3a000
006AB5988  ldr      x8, [x8, #0x9a8]
006AB598C  ldr      x2, [x8]
006AB5990  ldrb     w8, [x2, #0x53]
006AB5994  tbnz     w8, #5, #0x6ab59ac
006AB5998  mov      x0, x19
006AB599C  str      x20, [x0, #0x68]!
006AB59A0  mov      x1, x20
006AB59A4  bl       #0x382bcb8 ; 
006AB59A8  b        #0x6ab59bc ; 
006AB59AC  ldr      x8, [x2, #0x60]
006AB59B0  mov      x0, x19
006AB59B4  mov      x1, x20
006AB59B8  blr      x8
006AB59BC  mov      x0, x19
006AB59C0  mov      x1, xzr
006AB59C4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB59C8  adrp     x21, #0x959e000
006AB59CC  ldrb     w8, [x21, #0xfa7]
006AB59D0  mov      x20, x0
006AB59D4  cbnz     w8, #0x6ab59ec
006AB59D8  adrp     x0, #0x8f3a000
006AB59DC  ldr      x0, [x0, #0x9b8]
006AB59E0  bl       #0x382bd14 ; 
006AB59E4  mov      w8, #1
006AB59E8  strb     w8, [x21, #0xfa7]
006AB59EC  adrp     x8, #0x8f3a000
006AB59F0  ldr      x8, [x8, #0x9b8]
006AB59F4  ldr      x2, [x8]
006AB59F8  ldrb     w8, [x2, #0x53]
006AB59FC  tbnz     w8, #5, #0x6ab5a14
006AB5A00  mov      x0, x19
006AB5A04  str      x20, [x0, #0x70]!
006AB5A08  mov      x1, x20
006AB5A0C  bl       #0x382bcb8 ; 
006AB5A10  b        #0x6ab5a24 ; 
006AB5A14  ldr      x8, [x2, #0x60]
006AB5A18  mov      x0, x19
006AB5A1C  mov      x1, x20
006AB5A20  blr      x8
006AB5A24  mov      x0, x19
006AB5A28  mov      x1, xzr
006AB5A2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB5A30  adrp     x21, #0x959e000
006AB5A34  ldrb     w8, [x21, #0xfa8]
006AB5A38  mov      w20, w0
006AB5A3C  cbnz     w8, #0x6ab5a54
006AB5A40  adrp     x0, #0x8f3a000
006AB5A44  ldr      x0, [x0, #0x9c8]
006AB5A48  bl       #0x382bd14 ; 
006AB5A4C  mov      w8, #1
006AB5A50  strb     w8, [x21, #0xfa8]
006AB5A54  adrp     x8, #0x8f3a000
006AB5A58  ldr      x8, [x8, #0x9c8]
006AB5A5C  ldr      x2, [x8]
006AB5A60  ldrb     w8, [x2, #0x53]
006AB5A64  tbnz     w8, #5, #0x6ab5a70
006AB5A68  str      w20, [x19, #0x78]
006AB5A6C  b        #0x6ab5a80 ; 
006AB5A70  ldr      x8, [x2, #0x60]
006AB5A74  mov      x0, x19
006AB5A78  mov      w1, w20
006AB5A7C  blr      x8
006AB5A80  mov      x0, x19
006AB5A84  mov      x1, xzr
006AB5A88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB5A8C  adrp     x21, #0x959e000
006AB5A90  ldrb     w8, [x21, #0xfa9]
006AB5A94  mov      w20, w0
006AB5A98  cbnz     w8, #0x6ab5ab0
006AB5A9C  adrp     x0, #0x8f3a000
006AB5AA0  ldr      x0, [x0, #0x9d8]
006AB5AA4  bl       #0x382bd14 ; 
006AB5AA8  mov      w8, #1
006AB5AAC  strb     w8, [x21, #0xfa9]
006AB5AB0  adrp     x8, #0x8f3a000
006AB5AB4  ldr      x8, [x8, #0x9d8]
006AB5AB8  ldr      x2, [x8]
006AB5ABC  ldrb     w8, [x2, #0x53]
006AB5AC0  tbnz     w8, #5, #0x6ab5acc
006AB5AC4  str      w20, [x19, #0x7c]
006AB5AC8  b        #0x6ab5adc ; 
006AB5ACC  ldr      x8, [x2, #0x60]
006AB5AD0  mov      x0, x19
006AB5AD4  mov      w1, w20
006AB5AD8  blr      x8
006AB5ADC  mov      x0, x19
006AB5AE0  mov      x1, xzr
006AB5AE4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB5AE8  adrp     x21, #0x959e000
006AB5AEC  ldrb     w8, [x21, #0xfaa]
006AB5AF0  mov      x20, x0
006AB5AF4  cbnz     w8, #0x6ab5b0c
006AB5AF8  adrp     x0, #0x8f3a000
006AB5AFC  ldr      x0, [x0, #0x9e8]
006AB5B00  bl       #0x382bd14 ; 
006AB5B04  mov      w8, #1
006AB5B08  strb     w8, [x21, #0xfaa]
006AB5B0C  adrp     x8, #0x8f3a000
006AB5B10  ldr      x8, [x8, #0x9e8]
006AB5B14  ldr      x2, [x8]
006AB5B18  ldrb     w8, [x2, #0x53]
006AB5B1C  tbnz     w8, #5, #0x6ab5b28
006AB5B20  str      x20, [x19, #0x80]
006AB5B24  b        #0x6ab5b38 ; 
006AB5B28  ldr      x8, [x2, #0x60]
006AB5B2C  mov      x0, x19
006AB5B30  mov      x1, x20
006AB5B34  blr      x8
006AB5B38  mov      x0, x19
006AB5B3C  mov      x1, xzr
006AB5B40  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB5B44  adrp     x21, #0x959e000
006AB5B48  ldrb     w8, [x21, #0xfab]
006AB5B4C  mov      x20, x0
006AB5B50  cbnz     w8, #0x6ab5b68
006AB5B54  adrp     x0, #0x8f3a000
006AB5B58  ldr      x0, [x0, #0x9f8]
006AB5B5C  bl       #0x382bd14 ; 
006AB5B60  mov      w8, #1
006AB5B64  strb     w8, [x21, #0xfab]
006AB5B68  adrp     x8, #0x8f3a000
006AB5B6C  ldr      x8, [x8, #0x9f8]
006AB5B70  ldr      x2, [x8]
006AB5B74  ldrb     w8, [x2, #0x53]
006AB5B78  tbnz     w8, #5, #0x6ab5b84
006AB5B7C  str      x20, [x19, #0x88]
006AB5B80  b        #0x6ab5b94 ; 
006AB5B84  ldr      x8, [x2, #0x60]
006AB5B88  mov      x0, x19
006AB5B8C  mov      x1, x20
006AB5B90  blr      x8
006AB5B94  mov      x0, x19
006AB5B98  mov      x1, xzr
006AB5B9C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB5BA0  adrp     x21, #0x959e000
006AB5BA4  ldrb     w8, [x21, #0xfac]
006AB5BA8  mov      x20, x0
006AB5BAC  cbnz     w8, #0x6ab5bc4
006AB5BB0  adrp     x0, #0x8f3a000
006AB5BB4  ldr      x0, [x0, #0xa08]
006AB5BB8  bl       #0x382bd14 ; 
006AB5BBC  mov      w8, #1
006AB5BC0  strb     w8, [x21, #0xfac]
006AB5BC4  adrp     x8, #0x8f3a000
006AB5BC8  ldr      x8, [x8, #0xa08]
006AB5BCC  ldr      x2, [x8]
006AB5BD0  ldrb     w8, [x2, #0x53]
006AB5BD4  tbnz     w8, #5, #0x6ab5be0
006AB5BD8  str      x20, [x19, #0x90]
006AB5BDC  b        #0x6ab5bf0 ; 
006AB5BE0  ldr      x8, [x2, #0x60]
006AB5BE4  mov      x0, x19
006AB5BE8  mov      x1, x20
006AB5BEC  blr      x8
006AB5BF0  mov      x0, x19
006AB5BF4  mov      x1, xzr
006AB5BF8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB5BFC  adrp     x21, #0x959e000
006AB5C00  ldrb     w8, [x21, #0xfad]
006AB5C04  mov      x20, x0
006AB5C08  cbnz     w8, #0x6ab5c20
006AB5C0C  adrp     x0, #0x8f3a000
006AB5C10  ldr      x0, [x0, #0xa18]
006AB5C14  bl       #0x382bd14 ; 
006AB5C18  mov      w8, #1
006AB5C1C  strb     w8, [x21, #0xfad]
006AB5C20  adrp     x8, #0x8f3a000
006AB5C24  ldr      x8, [x8, #0xa18]
006AB5C28  ldr      x2, [x8]
006AB5C2C  ldrb     w8, [x2, #0x53]
006AB5C30  tbnz     w8, #5, #0x6ab5c3c
006AB5C34  str      x20, [x19, #0x98]
006AB5C38  b        #0x6ab5c4c ; 
006AB5C3C  ldr      x8, [x2, #0x60]
006AB5C40  mov      x0, x19
006AB5C44  mov      x1, x20
006AB5C48  blr      x8
006AB5C4C  mov      x0, x19
006AB5C50  mov      x1, xzr
006AB5C54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB5C58  adrp     x21, #0x959e000
006AB5C5C  ldrb     w8, [x21, #0xfae]
006AB5C60  mov      w20, w0
006AB5C64  cbnz     w8, #0x6ab5c7c
006AB5C68  adrp     x0, #0x8f3a000
006AB5C6C  ldr      x0, [x0, #0xa28]
006AB5C70  bl       #0x382bd14 ; 
006AB5C74  mov      w8, #1
006AB5C78  strb     w8, [x21, #0xfae]
006AB5C7C  adrp     x8, #0x8f3a000
006AB5C80  ldr      x8, [x8, #0xa28]
006AB5C84  ldr      x2, [x8]
006AB5C88  ldrb     w8, [x2, #0x53]
006AB5C8C  tbnz     w8, #5, #0x6ab5c98
006AB5C90  str      w20, [x19, #0xa0]
006AB5C94  b        #0x6ab5ca8 ; 
006AB5C98  ldr      x8, [x2, #0x60]
006AB5C9C  mov      x0, x19
006AB5CA0  mov      w1, w20
006AB5CA4  blr      x8
006AB5CA8  mov      x0, x19
006AB5CAC  mov      x1, xzr
006AB5CB0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB5CB4  adrp     x21, #0x959e000
006AB5CB8  ldrb     w8, [x21, #0xfaf]
006AB5CBC  mov      x20, x0
006AB5CC0  cbnz     w8, #0x6ab5cd8
006AB5CC4  adrp     x0, #0x8f3a000
006AB5CC8  ldr      x0, [x0, #0xa38]
006AB5CCC  bl       #0x382bd14 ; 
006AB5CD0  mov      w8, #1
006AB5CD4  strb     w8, [x21, #0xfaf]
006AB5CD8  adrp     x8, #0x8f3a000
006AB5CDC  ldr      x8, [x8, #0xa38]
006AB5CE0  ldr      x2, [x8]
006AB5CE4  ldrb     w8, [x2, #0x53]
006AB5CE8  tbnz     w8, #5, #0x6ab5d00
006AB5CEC  mov      x0, x19
006AB5CF0  str      x20, [x0, #0xa8]!
006AB5CF4  mov      x1, x20
006AB5CF8  bl       #0x382bcb8 ; 
006AB5CFC  b        #0x6ab5d10 ; 
006AB5D00  ldr      x8, [x2, #0x60]
006AB5D04  mov      x0, x19
006AB5D08  mov      x1, x20
006AB5D0C  blr      x8
006AB5D10  mov      x0, x19
006AB5D14  mov      x1, xzr
006AB5D18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB5D1C  adrp     x21, #0x959e000
006AB5D20  ldrb     w8, [x21, #0xfb0]
006AB5D24  mov      w20, w0
006AB5D28  cbnz     w8, #0x6ab5d40
006AB5D2C  adrp     x0, #0x8f3a000
006AB5D30  ldr      x0, [x0, #0xa48]
006AB5D34  bl       #0x382bd14 ; 
006AB5D38  mov      w8, #1
006AB5D3C  strb     w8, [x21, #0xfb0]
006AB5D40  adrp     x8, #0x8f3a000
006AB5D44  ldr      x8, [x8, #0xa48]
006AB5D48  ldr      x2, [x8]
006AB5D4C  ldrb     w8, [x2, #0x53]
006AB5D50  tbnz     w8, #5, #0x6ab5d5c
006AB5D54  str      w20, [x19, #0xb0]
006AB5D58  b        #0x6ab5d6c ; 
006AB5D5C  ldr      x8, [x2, #0x60]
006AB5D60  mov      x0, x19
006AB5D64  mov      w1, w20
006AB5D68  blr      x8
006AB5D6C  mov      x0, x19
006AB5D70  mov      x1, xzr
006AB5D74  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB5D78  adrp     x21, #0x959e000
006AB5D7C  ldrb     w8, [x21, #0xfb1]
006AB5D80  mov      x20, x0
006AB5D84  cbnz     w8, #0x6ab5d9c
006AB5D88  adrp     x0, #0x8f3a000
006AB5D8C  ldr      x0, [x0, #0xa58]
006AB5D90  bl       #0x382bd14 ; 
006AB5D94  mov      w8, #1
006AB5D98  strb     w8, [x21, #0xfb1]
006AB5D9C  adrp     x8, #0x8f3a000
006AB5DA0  ldr      x8, [x8, #0xa58]
006AB5DA4  ldr      x2, [x8]
006AB5DA8  ldrb     w8, [x2, #0x53]
006AB5DAC  tbnz     w8, #5, #0x6ab5dc4
006AB5DB0  mov      x0, x19
006AB5DB4  str      x20, [x0, #0xb8]!
006AB5DB8  mov      x1, x20
006AB5DBC  bl       #0x382bcb8 ; 
006AB5DC0  b        #0x6ab5dd4 ; 
006AB5DC4  ldr      x8, [x2, #0x60]
006AB5DC8  mov      x0, x19
006AB5DCC  mov      x1, x20
006AB5DD0  blr      x8
006AB5DD4  mov      x0, x19
006AB5DD8  mov      x1, xzr
006AB5DDC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AB5DE0  adrp     x21, #0x959e000
006AB5DE4  ldrb     w8, [x21, #0xfb2]
006AB5DE8  mov      x20, x0
006AB5DEC  cbnz     w8, #0x6ab5e04
006AB5DF0  adrp     x0, #0x8f3a000
006AB5DF4  ldr      x0, [x0, #0xa68]
006AB5DF8  bl       #0x382bd14 ; 
006AB5DFC  mov      w8, #1
006AB5E00  strb     w8, [x21, #0xfb2]
006AB5E04  adrp     x8, #0x8f3a000
006AB5E08  ldr      x8, [x8, #0xa68]
006AB5E0C  ldr      x2, [x8]
006AB5E10  ldrb     w8, [x2, #0x53]
006AB5E14  tbnz     w8, #5, #0x6ab5e2c
006AB5E18  str      x20, [x19, #0xc0]!
006AB5E1C  mov      x0, x19
006AB5E20  mov      x1, x20
006AB5E24  bl       #0x382bcb8 ; 
006AB5E28  b        #0x6ab5e3c ; 
006AB5E2C  ldr      x8, [x2, #0x60]
006AB5E30  mov      x0, x19
006AB5E34  mov      x1, x20
006AB5E38  blr      x8
006AB5E3C  ldp      x20, x19, [sp, #0x10]
006AB5E40  mov      w0, #1
006AB5E44  ldp      x30, x21, [sp], #0x20
006AB5E48  ret      

