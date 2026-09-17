; LocalModels.Bean.IAP_FundTask$$readImpl
; RVA 0x6AA54E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA54E4  stp      x30, x21, [sp, #-0x20]!
006AA54E8  stp      x20, x19, [sp, #0x10]
006AA54EC  adrp     x20, #0x959e000
006AA54F0  adrp     x21, #0x8f39000
006AA54F4  ldrb     w8, [x20, #0x6a7]
006AA54F8  ldr      x21, [x21, #0xe18]
006AA54FC  mov      x19, x0
006AA5500  tbnz     w8, #0, #0x6aa5518
006AA5504  adrp     x0, #0x8f39000
006AA5508  ldr      x0, [x0, #0xe18]
006AA550C  bl       #0x382bd14 ; 
006AA5510  mov      w8, #1
006AA5514  strb     w8, [x20, #0x6a7]
006AA5518  ldr      x1, [x21]
006AA551C  ldrb     w8, [x1, #0x53]
006AA5520  tbnz     w8, #5, #0x6aa5570
006AA5524  mov      x0, x19
006AA5528  mov      x1, xzr
006AA552C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA5530  adrp     x21, #0x959e000
006AA5534  ldrb     w8, [x21, #0xef0]
006AA5538  mov      w20, w0
006AA553C  cbnz     w8, #0x6aa5554
006AA5540  adrp     x0, #0x8f39000
006AA5544  ldr      x0, [x0, #0xda0]
006AA5548  bl       #0x382bd14 ; 
006AA554C  mov      w8, #1
006AA5550  strb     w8, [x21, #0xef0]
006AA5554  adrp     x8, #0x8f39000
006AA5558  ldr      x8, [x8, #0xda0]
006AA555C  ldr      x2, [x8]
006AA5560  ldrb     w8, [x2, #0x53]
006AA5564  tbnz     w8, #5, #0x6aa5584
006AA5568  str      w20, [x19, #0x20]
006AA556C  b        #0x6aa5594 ; 
006AA5570  ldr      x2, [x1, #0x60]
006AA5574  mov      x0, x19
006AA5578  ldp      x20, x19, [sp, #0x10]
006AA557C  ldp      x30, x21, [sp], #0x20
006AA5580  br       x2
006AA5584  ldr      x8, [x2, #0x60]
006AA5588  mov      x0, x19
006AA558C  mov      w1, w20
006AA5590  blr      x8
006AA5594  mov      x0, x19
006AA5598  mov      x1, xzr
006AA559C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA55A0  adrp     x21, #0x959e000
006AA55A4  ldrb     w8, [x21, #0xef1]
006AA55A8  mov      w20, w0
006AA55AC  cbnz     w8, #0x6aa55c4
006AA55B0  adrp     x0, #0x8f39000
006AA55B4  ldr      x0, [x0, #0xdb0]
006AA55B8  bl       #0x382bd14 ; 
006AA55BC  mov      w8, #1
006AA55C0  strb     w8, [x21, #0xef1]
006AA55C4  adrp     x8, #0x8f39000
006AA55C8  ldr      x8, [x8, #0xdb0]
006AA55CC  ldr      x2, [x8]
006AA55D0  ldrb     w8, [x2, #0x53]
006AA55D4  tbnz     w8, #5, #0x6aa55e0
006AA55D8  str      w20, [x19, #0x24]
006AA55DC  b        #0x6aa55f0 ; 
006AA55E0  ldr      x8, [x2, #0x60]
006AA55E4  mov      x0, x19
006AA55E8  mov      w1, w20
006AA55EC  blr      x8
006AA55F0  mov      x0, x19
006AA55F4  mov      x1, xzr
006AA55F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA55FC  adrp     x21, #0x959e000
006AA5600  ldrb     w8, [x21, #0xef2]
006AA5604  mov      w20, w0
006AA5608  cbnz     w8, #0x6aa5620
006AA560C  adrp     x0, #0x8f39000
006AA5610  ldr      x0, [x0, #0xdc0]
006AA5614  bl       #0x382bd14 ; 
006AA5618  mov      w8, #1
006AA561C  strb     w8, [x21, #0xef2]
006AA5620  adrp     x8, #0x8f39000
006AA5624  ldr      x8, [x8, #0xdc0]
006AA5628  ldr      x2, [x8]
006AA562C  ldrb     w8, [x2, #0x53]
006AA5630  tbnz     w8, #5, #0x6aa563c
006AA5634  str      w20, [x19, #0x28]
006AA5638  b        #0x6aa564c ; 
006AA563C  ldr      x8, [x2, #0x60]
006AA5640  mov      x0, x19
006AA5644  mov      w1, w20
006AA5648  blr      x8
006AA564C  mov      x0, x19
006AA5650  mov      x1, xzr
006AA5654  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA5658  adrp     x21, #0x959e000
006AA565C  ldrb     w8, [x21, #0xef3]
006AA5660  mov      w20, w0
006AA5664  cbnz     w8, #0x6aa567c
006AA5668  adrp     x0, #0x8f39000
006AA566C  ldr      x0, [x0, #0xdd0]
006AA5670  bl       #0x382bd14 ; 
006AA5674  mov      w8, #1
006AA5678  strb     w8, [x21, #0xef3]
006AA567C  adrp     x8, #0x8f39000
006AA5680  ldr      x8, [x8, #0xdd0]
006AA5684  ldr      x2, [x8]
006AA5688  ldrb     w8, [x2, #0x53]
006AA568C  tbnz     w8, #5, #0x6aa5698
006AA5690  str      w20, [x19, #0x2c]
006AA5694  b        #0x6aa56a8 ; 
006AA5698  ldr      x8, [x2, #0x60]
006AA569C  mov      x0, x19
006AA56A0  mov      w1, w20
006AA56A4  blr      x8
006AA56A8  mov      x0, x19
006AA56AC  mov      x1, xzr
006AA56B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA56B4  adrp     x21, #0x959e000
006AA56B8  ldrb     w8, [x21, #0xef4]
006AA56BC  mov      w20, w0
006AA56C0  cbnz     w8, #0x6aa56d8
006AA56C4  adrp     x0, #0x8f39000
006AA56C8  ldr      x0, [x0, #0xde0]
006AA56CC  bl       #0x382bd14 ; 
006AA56D0  mov      w8, #1
006AA56D4  strb     w8, [x21, #0xef4]
006AA56D8  adrp     x8, #0x8f39000
006AA56DC  ldr      x8, [x8, #0xde0]
006AA56E0  ldr      x2, [x8]
006AA56E4  ldrb     w8, [x2, #0x53]
006AA56E8  tbnz     w8, #5, #0x6aa56f4
006AA56EC  str      w20, [x19, #0x30]
006AA56F0  b        #0x6aa5704 ; 
006AA56F4  ldr      x8, [x2, #0x60]
006AA56F8  mov      x0, x19
006AA56FC  mov      w1, w20
006AA5700  blr      x8
006AA5704  mov      x0, x19
006AA5708  mov      x1, xzr
006AA570C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA5710  adrp     x21, #0x959e000
006AA5714  ldrb     w8, [x21, #0xef5]
006AA5718  mov      x20, x0
006AA571C  cbnz     w8, #0x6aa5734
006AA5720  adrp     x0, #0x8f39000
006AA5724  ldr      x0, [x0, #0xdf0]
006AA5728  bl       #0x382bd14 ; 
006AA572C  mov      w8, #1
006AA5730  strb     w8, [x21, #0xef5]
006AA5734  adrp     x8, #0x8f39000
006AA5738  ldr      x8, [x8, #0xdf0]
006AA573C  ldr      x2, [x8]
006AA5740  ldrb     w8, [x2, #0x53]
006AA5744  tbnz     w8, #5, #0x6aa575c
006AA5748  mov      x0, x19
006AA574C  str      x20, [x0, #0x38]!
006AA5750  mov      x1, x20
006AA5754  bl       #0x382bcb8 ; 
006AA5758  b        #0x6aa576c ; 
006AA575C  ldr      x8, [x2, #0x60]
006AA5760  mov      x0, x19
006AA5764  mov      x1, x20
006AA5768  blr      x8
006AA576C  mov      x0, x19
006AA5770  mov      x1, xzr
006AA5774  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA5778  adrp     x21, #0x959e000
006AA577C  ldrb     w8, [x21, #0xef6]
006AA5780  mov      x20, x0
006AA5784  cbnz     w8, #0x6aa579c
006AA5788  adrp     x0, #0x8f39000
006AA578C  ldr      x0, [x0, #0xe00]
006AA5790  bl       #0x382bd14 ; 
006AA5794  mov      w8, #1
006AA5798  strb     w8, [x21, #0xef6]
006AA579C  adrp     x8, #0x8f39000
006AA57A0  ldr      x8, [x8, #0xe00]
006AA57A4  ldr      x2, [x8]
006AA57A8  ldrb     w8, [x2, #0x53]
006AA57AC  tbnz     w8, #5, #0x6aa57c4
006AA57B0  mov      x0, x19
006AA57B4  str      x20, [x0, #0x40]!
006AA57B8  mov      x1, x20
006AA57BC  bl       #0x382bcb8 ; 
006AA57C0  b        #0x6aa57d4 ; 
006AA57C4  ldr      x8, [x2, #0x60]
006AA57C8  mov      x0, x19
006AA57CC  mov      x1, x20
006AA57D0  blr      x8
006AA57D4  mov      x0, x19
006AA57D8  mov      x1, xzr
006AA57DC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA57E0  adrp     x21, #0x959e000
006AA57E4  ldrb     w8, [x21, #0xef7]
006AA57E8  mov      x20, x0
006AA57EC  cbnz     w8, #0x6aa5804
006AA57F0  adrp     x0, #0x8f39000
006AA57F4  ldr      x0, [x0, #0xe10]
006AA57F8  bl       #0x382bd14 ; 
006AA57FC  mov      w8, #1
006AA5800  strb     w8, [x21, #0xef7]
006AA5804  adrp     x8, #0x8f39000
006AA5808  ldr      x8, [x8, #0xe10]
006AA580C  ldr      x2, [x8]
006AA5810  ldrb     w8, [x2, #0x53]
006AA5814  tbnz     w8, #5, #0x6aa582c
006AA5818  str      x20, [x19, #0x48]!
006AA581C  mov      x0, x19
006AA5820  mov      x1, x20
006AA5824  bl       #0x382bcb8 ; 
006AA5828  b        #0x6aa583c ; 
006AA582C  ldr      x8, [x2, #0x60]
006AA5830  mov      x0, x19
006AA5834  mov      x1, x20
006AA5838  blr      x8
006AA583C  ldp      x20, x19, [sp, #0x10]
006AA5840  mov      w0, #1
006AA5844  ldp      x30, x21, [sp], #0x20
006AA5848  ret      

