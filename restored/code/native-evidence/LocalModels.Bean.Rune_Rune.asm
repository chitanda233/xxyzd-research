; LocalModels.Bean.Rune_Rune$$readImpl
; RVA 0x6AE5368; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE5368  stp      x30, x21, [sp, #-0x20]!
006AE536C  stp      x20, x19, [sp, #0x10]
006AE5370  adrp     x20, #0x959e000
006AE5374  adrp     x21, #0x8f3c000
006AE5378  ldrb     w8, [x20, #0xd3a]
006AE537C  ldr      x21, [x21, #0xd88]
006AE5380  mov      x19, x0
006AE5384  tbnz     w8, #0, #0x6ae539c
006AE5388  adrp     x0, #0x8f3c000
006AE538C  ldr      x0, [x0, #0xd88]
006AE5390  bl       #0x382bd14 ; 
006AE5394  mov      w8, #1
006AE5398  strb     w8, [x20, #0xd3a]
006AE539C  ldr      x1, [x21]
006AE53A0  ldrb     w8, [x1, #0x53]
006AE53A4  tbnz     w8, #5, #0x6ae53f4
006AE53A8  mov      x0, x19
006AE53AC  mov      x1, xzr
006AE53B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE53B4  adrp     x21, #0x959f000
006AE53B8  ldrb     w8, [x21, #0x1c2]
006AE53BC  mov      w20, w0
006AE53C0  cbnz     w8, #0x6ae53d8
006AE53C4  adrp     x0, #0x8f3c000
006AE53C8  ldr      x0, [x0, #0xcc0]
006AE53CC  bl       #0x382bd14 ; 
006AE53D0  mov      w8, #1
006AE53D4  strb     w8, [x21, #0x1c2]
006AE53D8  adrp     x8, #0x8f3c000
006AE53DC  ldr      x8, [x8, #0xcc0]
006AE53E0  ldr      x2, [x8]
006AE53E4  ldrb     w8, [x2, #0x53]
006AE53E8  tbnz     w8, #5, #0x6ae5408
006AE53EC  str      w20, [x19, #0x20]
006AE53F0  b        #0x6ae5418 ; 
006AE53F4  ldr      x2, [x1, #0x60]
006AE53F8  mov      x0, x19
006AE53FC  ldp      x20, x19, [sp, #0x10]
006AE5400  ldp      x30, x21, [sp], #0x20
006AE5404  br       x2
006AE5408  ldr      x8, [x2, #0x60]
006AE540C  mov      x0, x19
006AE5410  mov      w1, w20
006AE5414  blr      x8
006AE5418  mov      x0, x19
006AE541C  mov      x1, xzr
006AE5420  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE5424  adrp     x21, #0x959f000
006AE5428  ldrb     w8, [x21, #0x1c3]
006AE542C  mov      w20, w0
006AE5430  cbnz     w8, #0x6ae5448
006AE5434  adrp     x0, #0x8f3c000
006AE5438  ldr      x0, [x0, #0xcd0]
006AE543C  bl       #0x382bd14 ; 
006AE5440  mov      w8, #1
006AE5444  strb     w8, [x21, #0x1c3]
006AE5448  adrp     x8, #0x8f3c000
006AE544C  ldr      x8, [x8, #0xcd0]
006AE5450  ldr      x2, [x8]
006AE5454  ldrb     w8, [x2, #0x53]
006AE5458  tbnz     w8, #5, #0x6ae5464
006AE545C  str      w20, [x19, #0x24]
006AE5460  b        #0x6ae5474 ; 
006AE5464  ldr      x8, [x2, #0x60]
006AE5468  mov      x0, x19
006AE546C  mov      w1, w20
006AE5470  blr      x8
006AE5474  mov      x0, x19
006AE5478  mov      x1, xzr
006AE547C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE5480  adrp     x21, #0x959f000
006AE5484  ldrb     w8, [x21, #0x1c4]
006AE5488  mov      x20, x0
006AE548C  cbnz     w8, #0x6ae54a4
006AE5490  adrp     x0, #0x8f3c000
006AE5494  ldr      x0, [x0, #0xce0]
006AE5498  bl       #0x382bd14 ; 
006AE549C  mov      w8, #1
006AE54A0  strb     w8, [x21, #0x1c4]
006AE54A4  adrp     x8, #0x8f3c000
006AE54A8  ldr      x8, [x8, #0xce0]
006AE54AC  ldr      x2, [x8]
006AE54B0  ldrb     w8, [x2, #0x53]
006AE54B4  tbnz     w8, #5, #0x6ae54cc
006AE54B8  mov      x0, x19
006AE54BC  str      x20, [x0, #0x28]!
006AE54C0  mov      x1, x20
006AE54C4  bl       #0x382bcb8 ; 
006AE54C8  b        #0x6ae54dc ; 
006AE54CC  ldr      x8, [x2, #0x60]
006AE54D0  mov      x0, x19
006AE54D4  mov      x1, x20
006AE54D8  blr      x8
006AE54DC  mov      x0, x19
006AE54E0  mov      x1, xzr
006AE54E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE54E8  adrp     x21, #0x959f000
006AE54EC  ldrb     w8, [x21, #0x1c5]
006AE54F0  mov      w20, w0
006AE54F4  cbnz     w8, #0x6ae550c
006AE54F8  adrp     x0, #0x8f3c000
006AE54FC  ldr      x0, [x0, #0xcf0]
006AE5500  bl       #0x382bd14 ; 
006AE5504  mov      w8, #1
006AE5508  strb     w8, [x21, #0x1c5]
006AE550C  adrp     x8, #0x8f3c000
006AE5510  ldr      x8, [x8, #0xcf0]
006AE5514  ldr      x2, [x8]
006AE5518  ldrb     w8, [x2, #0x53]
006AE551C  tbnz     w8, #5, #0x6ae5528
006AE5520  str      w20, [x19, #0x30]
006AE5524  b        #0x6ae5538 ; 
006AE5528  ldr      x8, [x2, #0x60]
006AE552C  mov      x0, x19
006AE5530  mov      w1, w20
006AE5534  blr      x8
006AE5538  mov      x0, x19
006AE553C  mov      x1, xzr
006AE5540  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE5544  adrp     x21, #0x959f000
006AE5548  ldrb     w8, [x21, #0x1c6]
006AE554C  mov      w20, w0
006AE5550  cbnz     w8, #0x6ae5568
006AE5554  adrp     x0, #0x8f3c000
006AE5558  ldr      x0, [x0, #0xd00]
006AE555C  bl       #0x382bd14 ; 
006AE5560  mov      w8, #1
006AE5564  strb     w8, [x21, #0x1c6]
006AE5568  adrp     x8, #0x8f3c000
006AE556C  ldr      x8, [x8, #0xd00]
006AE5570  ldr      x2, [x8]
006AE5574  ldrb     w8, [x2, #0x53]
006AE5578  tbnz     w8, #5, #0x6ae5584
006AE557C  str      w20, [x19, #0x34]
006AE5580  b        #0x6ae5594 ; 
006AE5584  ldr      x8, [x2, #0x60]
006AE5588  mov      x0, x19
006AE558C  mov      w1, w20
006AE5590  blr      x8
006AE5594  mov      x0, x19
006AE5598  mov      x1, xzr
006AE559C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE55A0  adrp     x21, #0x959f000
006AE55A4  ldrb     w8, [x21, #0x1c7]
006AE55A8  mov      x20, x0
006AE55AC  cbnz     w8, #0x6ae55c4
006AE55B0  adrp     x0, #0x8f3c000
006AE55B4  ldr      x0, [x0, #0xd08]
006AE55B8  bl       #0x382bd14 ; 
006AE55BC  mov      w8, #1
006AE55C0  strb     w8, [x21, #0x1c7]
006AE55C4  adrp     x8, #0x8f3c000
006AE55C8  ldr      x8, [x8, #0xd08]
006AE55CC  ldr      x2, [x8]
006AE55D0  ldrb     w8, [x2, #0x53]
006AE55D4  tbnz     w8, #5, #0x6ae55ec
006AE55D8  mov      x0, x19
006AE55DC  str      x20, [x0, #0x38]!
006AE55E0  mov      x1, x20
006AE55E4  bl       #0x382bcb8 ; 
006AE55E8  b        #0x6ae55fc ; 
006AE55EC  ldr      x8, [x2, #0x60]
006AE55F0  mov      x0, x19
006AE55F4  mov      x1, x20
006AE55F8  blr      x8
006AE55FC  mov      x0, x19
006AE5600  mov      x1, xzr
006AE5604  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE5608  adrp     x21, #0x959f000
006AE560C  ldrb     w8, [x21, #0x1c8]
006AE5610  mov      w20, w0
006AE5614  cbnz     w8, #0x6ae562c
006AE5618  adrp     x0, #0x8f3c000
006AE561C  ldr      x0, [x0, #0xd18]
006AE5620  bl       #0x382bd14 ; 
006AE5624  mov      w8, #1
006AE5628  strb     w8, [x21, #0x1c8]
006AE562C  adrp     x8, #0x8f3c000
006AE5630  ldr      x8, [x8, #0xd18]
006AE5634  ldr      x2, [x8]
006AE5638  ldrb     w8, [x2, #0x53]
006AE563C  tbnz     w8, #5, #0x6ae5648
006AE5640  str      w20, [x19, #0x40]
006AE5644  b        #0x6ae5658 ; 
006AE5648  ldr      x8, [x2, #0x60]
006AE564C  mov      x0, x19
006AE5650  mov      w1, w20
006AE5654  blr      x8
006AE5658  mov      x0, x19
006AE565C  mov      x1, xzr
006AE5660  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AE5664  adrp     x21, #0x959f000
006AE5668  ldrb     w8, [x21, #0x1c9]
006AE566C  mov      x20, x0
006AE5670  cbnz     w8, #0x6ae5688
006AE5674  adrp     x0, #0x8f3c000
006AE5678  ldr      x0, [x0, #0xd28]
006AE567C  bl       #0x382bd14 ; 
006AE5680  mov      w8, #1
006AE5684  strb     w8, [x21, #0x1c9]
006AE5688  adrp     x8, #0x8f3c000
006AE568C  ldr      x8, [x8, #0xd28]
006AE5690  ldr      x2, [x8]
006AE5694  ldrb     w8, [x2, #0x53]
006AE5698  tbnz     w8, #5, #0x6ae56b0
006AE569C  mov      x0, x19
006AE56A0  str      x20, [x0, #0x48]!
006AE56A4  mov      x1, x20
006AE56A8  bl       #0x382bcb8 ; 
006AE56AC  b        #0x6ae56c0 ; 
006AE56B0  ldr      x8, [x2, #0x60]
006AE56B4  mov      x0, x19
006AE56B8  mov      x1, x20
006AE56BC  blr      x8
006AE56C0  mov      x0, x19
006AE56C4  mov      x1, xzr
006AE56C8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE56CC  adrp     x21, #0x959f000
006AE56D0  ldrb     w8, [x21, #0x1ca]
006AE56D4  mov      x20, x0
006AE56D8  cbnz     w8, #0x6ae56f0
006AE56DC  adrp     x0, #0x8f3c000
006AE56E0  ldr      x0, [x0, #0xd30]
006AE56E4  bl       #0x382bd14 ; 
006AE56E8  mov      w8, #1
006AE56EC  strb     w8, [x21, #0x1ca]
006AE56F0  adrp     x8, #0x8f3c000
006AE56F4  ldr      x8, [x8, #0xd30]
006AE56F8  ldr      x2, [x8]
006AE56FC  ldrb     w8, [x2, #0x53]
006AE5700  tbnz     w8, #5, #0x6ae5718
006AE5704  mov      x0, x19
006AE5708  str      x20, [x0, #0x50]!
006AE570C  mov      x1, x20
006AE5710  bl       #0x382bcb8 ; 
006AE5714  b        #0x6ae5728 ; 
006AE5718  ldr      x8, [x2, #0x60]
006AE571C  mov      x0, x19
006AE5720  mov      x1, x20
006AE5724  blr      x8
006AE5728  mov      x0, x19
006AE572C  mov      x1, xzr
006AE5730  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE5734  adrp     x21, #0x959f000
006AE5738  ldrb     w8, [x21, #0x1cb]
006AE573C  mov      x20, x0
006AE5740  cbnz     w8, #0x6ae5758
006AE5744  adrp     x0, #0x8f3c000
006AE5748  ldr      x0, [x0, #0xd40]
006AE574C  bl       #0x382bd14 ; 
006AE5750  mov      w8, #1
006AE5754  strb     w8, [x21, #0x1cb]
006AE5758  adrp     x8, #0x8f3c000
006AE575C  ldr      x8, [x8, #0xd40]
006AE5760  ldr      x2, [x8]
006AE5764  ldrb     w8, [x2, #0x53]
006AE5768  tbnz     w8, #5, #0x6ae5780
006AE576C  mov      x0, x19
006AE5770  str      x20, [x0, #0x58]!
006AE5774  mov      x1, x20
006AE5778  bl       #0x382bcb8 ; 
006AE577C  b        #0x6ae5790 ; 
006AE5780  ldr      x8, [x2, #0x60]
006AE5784  mov      x0, x19
006AE5788  mov      x1, x20
006AE578C  blr      x8
006AE5790  mov      x0, x19
006AE5794  mov      x1, xzr
006AE5798  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE579C  adrp     x21, #0x959f000
006AE57A0  ldrb     w8, [x21, #0x1cc]
006AE57A4  mov      w20, w0
006AE57A8  cbnz     w8, #0x6ae57c0
006AE57AC  adrp     x0, #0x8f3c000
006AE57B0  ldr      x0, [x0, #0xd50]
006AE57B4  bl       #0x382bd14 ; 
006AE57B8  mov      w8, #1
006AE57BC  strb     w8, [x21, #0x1cc]
006AE57C0  adrp     x8, #0x8f3c000
006AE57C4  ldr      x8, [x8, #0xd50]
006AE57C8  ldr      x2, [x8]
006AE57CC  ldrb     w8, [x2, #0x53]
006AE57D0  tbnz     w8, #5, #0x6ae57dc
006AE57D4  str      w20, [x19, #0x60]
006AE57D8  b        #0x6ae57ec ; 
006AE57DC  ldr      x8, [x2, #0x60]
006AE57E0  mov      x0, x19
006AE57E4  mov      w1, w20
006AE57E8  blr      x8
006AE57EC  mov      x0, x19
006AE57F0  mov      x1, xzr
006AE57F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE57F8  adrp     x21, #0x959f000
006AE57FC  ldrb     w8, [x21, #0x1cd]
006AE5800  mov      x20, x0
006AE5804  cbnz     w8, #0x6ae581c
006AE5808  adrp     x0, #0x8f3c000
006AE580C  ldr      x0, [x0, #0xd60]
006AE5810  bl       #0x382bd14 ; 
006AE5814  mov      w8, #1
006AE5818  strb     w8, [x21, #0x1cd]
006AE581C  adrp     x8, #0x8f3c000
006AE5820  ldr      x8, [x8, #0xd60]
006AE5824  ldr      x2, [x8]
006AE5828  ldrb     w8, [x2, #0x53]
006AE582C  tbnz     w8, #5, #0x6ae5844
006AE5830  mov      x0, x19
006AE5834  str      x20, [x0, #0x68]!
006AE5838  mov      x1, x20
006AE583C  bl       #0x382bcb8 ; 
006AE5840  b        #0x6ae5854 ; 
006AE5844  ldr      x8, [x2, #0x60]
006AE5848  mov      x0, x19
006AE584C  mov      x1, x20
006AE5850  blr      x8
006AE5854  mov      x0, x19
006AE5858  mov      x1, xzr
006AE585C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE5860  adrp     x21, #0x959f000
006AE5864  ldrb     w8, [x21, #0x1ce]
006AE5868  mov      x20, x0
006AE586C  cbnz     w8, #0x6ae5884
006AE5870  adrp     x0, #0x8f3c000
006AE5874  ldr      x0, [x0, #0xd70]
006AE5878  bl       #0x382bd14 ; 
006AE587C  mov      w8, #1
006AE5880  strb     w8, [x21, #0x1ce]
006AE5884  adrp     x8, #0x8f3c000
006AE5888  ldr      x8, [x8, #0xd70]
006AE588C  ldr      x2, [x8]
006AE5890  ldrb     w8, [x2, #0x53]
006AE5894  tbnz     w8, #5, #0x6ae58ac
006AE5898  mov      x0, x19
006AE589C  str      x20, [x0, #0x70]!
006AE58A0  mov      x1, x20
006AE58A4  bl       #0x382bcb8 ; 
006AE58A8  b        #0x6ae58bc ; 
006AE58AC  ldr      x8, [x2, #0x60]
006AE58B0  mov      x0, x19
006AE58B4  mov      x1, x20
006AE58B8  blr      x8
006AE58BC  mov      x0, x19
006AE58C0  mov      x1, xzr
006AE58C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE58C8  adrp     x21, #0x959f000
006AE58CC  ldrb     w8, [x21, #0x1cf]
006AE58D0  mov      x20, x0
006AE58D4  cbnz     w8, #0x6ae58ec
006AE58D8  adrp     x0, #0x8f3c000
006AE58DC  ldr      x0, [x0, #0xd80]
006AE58E0  bl       #0x382bd14 ; 
006AE58E4  mov      w8, #1
006AE58E8  strb     w8, [x21, #0x1cf]
006AE58EC  adrp     x8, #0x8f3c000
006AE58F0  ldr      x8, [x8, #0xd80]
006AE58F4  ldr      x2, [x8]
006AE58F8  ldrb     w8, [x2, #0x53]
006AE58FC  tbnz     w8, #5, #0x6ae5914
006AE5900  str      x20, [x19, #0x78]!
006AE5904  mov      x0, x19
006AE5908  mov      x1, x20
006AE590C  bl       #0x382bcb8 ; 
006AE5910  b        #0x6ae5924 ; 
006AE5914  ldr      x8, [x2, #0x60]
006AE5918  mov      x0, x19
006AE591C  mov      x1, x20
006AE5920  blr      x8
006AE5924  ldp      x20, x19, [sp, #0x10]
006AE5928  mov      w0, #1
006AE592C  ldp      x30, x21, [sp], #0x20
006AE5930  ret      

