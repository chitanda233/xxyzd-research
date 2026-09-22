; HotFix.BattleLogic.Weapon$$onCreateCircleShape
; RVA 0x69F5464; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069F5464  stp      x29, x30, [sp, #-0x60]!
0069F5468  stp      x28, x27, [sp, #0x10]
0069F546C  stp      x26, x25, [sp, #0x20]
0069F5470  stp      x24, x23, [sp, #0x30]
0069F5474  stp      x22, x21, [sp, #0x40]
0069F5478  stp      x20, x19, [sp, #0x50]
0069F547C  sub      sp, sp, #0x530
0069F5480  stp      x3, x4, [sp, #0x48]
0069F5484  str      x2, [sp, #0x58]
0069F5488  mrs      x22, tpidr_el0
0069F548C  ldr      x8, [x22, #0x28]
0069F5490  adrp     x19, #0x959d000
0069F5494  adrp     x20, #0x8f32000
0069F5498  mov      x21, x1
0069F549C  str      x8, [sp, #0x528]
0069F54A0  ldrb     w8, [x19, #0x46f]
0069F54A4  ldr      x20, [x20, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.Weapon.onCreateCircleShape()
0069F54A8  mov      x24, x0
0069F54AC  tbnz     w8, #0, #0x69f54d0
0069F54B0  adrp     x0, #0x8f31000
0069F54B4  ldr      x0, [x0, #0x468] ; GLOBAL Method$System.Collections.Generic.Queue<Weapon.FireData>.Enqueue()
0069F54B8  bl       #0x382bd14 ; 
0069F54BC  adrp     x0, #0x8f32000
0069F54C0  ldr      x0, [x0, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.Weapon.onCreateCircleShape()
0069F54C4  bl       #0x382bd14 ; 
0069F54C8  mov      w8, #1
0069F54CC  strb     w8, [x19, #0x46f]
0069F54D0  ldr      x23, [x20]
0069F54D4  ldrb     w8, [x23, #0x53]
0069F54D8  tbnz     w8, #5, #0x69f558c
0069F54DC  add      x8, sp, #0x248
0069F54E0  movi     v0.2d, #0000000000000000
0069F54E4  adrp     x19, #0x9591000
0069F54E8  stp      q0, q0, [sp, #0x260]
0069F54EC  stur     xzr, [x8, #0x37]
0069F54F0  ldrb     w8, [x19, #0xa4b]
0069F54F4  str      xzr, [sp, #0x388]
0069F54F8  str      xzr, [sp, #0x380]
0069F54FC  str      xzr, [sp, #0x390]
0069F5500  str      xzr, [sp, #0x368]
0069F5504  str      xzr, [sp, #0x360]
0069F5508  str      xzr, [sp, #0x370]
0069F550C  str      xzr, [sp, #0x308]
0069F5510  str      xzr, [sp, #0x300]
0069F5514  str      xzr, [sp, #0x310]
0069F5518  str      xzr, [sp, #0x2f0]
0069F551C  str      xzr, [sp, #0x2b0]
0069F5520  str      xzr, [sp, #0x258]
0069F5524  str      xzr, [sp, #0x248]
0069F5528  str      xzr, [sp, #0x250]
0069F552C  str      xzr, [sp, #0x80]
0069F5530  stp      q0, q0, [sp, #0x3a0]
0069F5534  stp      q0, q0, [sp, #0x340]
0069F5538  stp      q0, q0, [sp, #0x320]
0069F553C  stp      q0, q0, [sp, #0x2c0]
0069F5540  str      q0, [sp, #0x2e0]
0069F5544  stp      q0, q0, [sp, #0x290]
0069F5548  stp      q0, q0, [sp, #0x60]
0069F554C  str      xzr, [sp, #0x238]
0069F5550  str      xzr, [sp, #0x230]
0069F5554  str      xzr, [sp, #0x240]
0069F5558  cbnz     w8, #0x69f5570
0069F555C  adrp     x0, #0x8ee5000
0069F5560  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069F5564  bl       #0x382bd14 ; 
0069F5568  mov      w8, #1
0069F556C  strb     w8, [x19, #0xa4b]
0069F5570  adrp     x8, #0x8ee5000
0069F5574  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069F5578  ldr      x1, [x8]
0069F557C  ldrb     w8, [x1, #0x53]
0069F5580  tbnz     w8, #5, #0x69f55bc
0069F5584  ldr      x0, [x24, #0x20]
0069F5588  b        #0x69f55c8 ; 
0069F558C  ldr      x1, [sp, #0x58]
0069F5590  ldr      x19, [x23, #0x60]
0069F5594  add      x0, sp, #0x3c0
0069F5598  mov      w2, #0x70
0069F559C  bl       #0x89edad0 ; 
0069F55A0  ldp      x3, x4, [sp, #0x48]
0069F55A4  add      x2, sp, #0x3c0
0069F55A8  mov      x0, x24
0069F55AC  mov      x1, x21
0069F55B0  mov      x5, x23
0069F55B4  blr      x19
0069F55B8  b        #0x69f5b08 ; 
0069F55BC  ldr      x8, [x1, #0x60]
0069F55C0  mov      x0, x24
0069F55C4  blr      x8
0069F55C8  cbz      x0, #0x69f5b38
0069F55CC  mov      x1, xzr
0069F55D0  bl       #0x69fcf48 ; HotFix.BattleLogic.BattleWorldContext$$CreateGuid
0069F55D4  ldr      x1, [sp, #0x58]
0069F55D8  str      x0, [sp, #0x30]
0069F55DC  add      x0, sp, #0x430
0069F55E0  mov      w2, #0x70
0069F55E4  bl       #0x89edad0 ; 
0069F55E8  ldr      q0, [sp, #0x450]
0069F55EC  ldr      q1, [sp, #0x460]
0069F55F0  adrp     x19, #0x9599000
0069F55F4  ldrb     w8, [x19, #0x913]
0069F55F8  stp      q0, q1, [sp, #0x3a0]
0069F55FC  ldr      q0, [x21, #0x10]
0069F5600  ldr      x9, [x21, #0x20]
0069F5604  str      q0, [sp, #0x380]
0069F5608  str      x9, [sp, #0x390]
0069F560C  cbnz     w8, #0x69f5624
0069F5610  adrp     x0, #0x8f0c000
0069F5614  ldr      x0, [x0, #0x770] ; GLOBAL Method$HotFix.BattleLogic.Weapon.get_TableData()
0069F5618  bl       #0x382bd14 ; 
0069F561C  mov      w8, #1
0069F5620  strb     w8, [x19, #0x913]
0069F5624  adrp     x8, #0x8f0c000
0069F5628  ldr      x8, [x8, #0x770] ; GLOBAL Method$HotFix.BattleLogic.Weapon.get_TableData()
0069F562C  ldr      x1, [x8]
0069F5630  ldrb     w8, [x1, #0x53]
0069F5634  tbnz     w8, #5, #0x69f5640
0069F5638  ldr      x24, [x24, #0x48]
0069F563C  b        #0x69f5650 ; 
0069F5640  ldr      x8, [x1, #0x60]
0069F5644  mov      x0, x24
0069F5648  blr      x8
0069F564C  mov      x24, x0
0069F5650  cbz      x24, #0x69f5b38
0069F5654  adrp     x19, #0x959b000
0069F5658  ldrb     w8, [x19, #0x3dd]
0069F565C  cbnz     w8, #0x69f5674
0069F5660  adrp     x0, #0x8f1f000
0069F5664  ldr      x0, [x0, #0xed0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_BulletRotate2Target()
0069F5668  bl       #0x382bd14 ; 
0069F566C  mov      w8, #1
0069F5670  strb     w8, [x19, #0x3dd]
0069F5674  adrp     x8, #0x8f1f000
0069F5678  ldr      x8, [x8, #0xed0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_BulletRotate2Target()
0069F567C  ldr      x1, [x8]
0069F5680  ldrb     w8, [x1, #0x53]
0069F5684  tbnz     w8, #5, #0x69f5690
0069F5688  ldr      w0, [x24, #0xb8]
0069F568C  b        #0x69f569c ; 
0069F5690  ldr      x8, [x1, #0x60]
0069F5694  mov      x0, x24
0069F5698  blr      x8
0069F569C  cmp      w0, #1
0069F56A0  b.ne     #0x69f56fc
0069F56A4  ldr      x9, [sp, #0x58]
0069F56A8  ldr      x8, [x21, #0x20]
0069F56AC  ldr      q0, [x21, #0x10]
0069F56B0  add      x0, sp, #0x210
0069F56B4  ldur     q1, [x9, #8]
0069F56B8  ldr      x9, [x9, #0x18]
0069F56BC  mov      w1, wzr
0069F56C0  mov      x2, xzr
0069F56C4  sub      v0.2d, v0.2d, v1.2d
0069F56C8  sub      x8, x8, x9
0069F56CC  str      x8, [sp, #0x220]
0069F56D0  add      x8, sp, #0x430
0069F56D4  add      x19, x21, #0x10
0069F56D8  str      q0, [sp, #0x210]
0069F56DC  bl       #0x7d4c564 ; Photon.Deterministic.FPQuaternion$$LookRotation
0069F56E0  ldr      q0, [sp, #0x430]
0069F56E4  ldr      q1, [sp, #0x440]
0069F56E8  stp      q0, q1, [sp, #0x3a0]
0069F56EC  ldr      x8, [x19, #0x10]
0069F56F0  ldr      q0, [x19]
0069F56F4  str      x8, [sp, #0x390]
0069F56F8  str      q0, [sp, #0x380]
0069F56FC  ldp      q0, q1, [sp, #0x3a0]
0069F5700  add      x8, sp, #0x430
0069F5704  add      x0, sp, #0x1f0
0069F5708  mov      x1, xzr
0069F570C  stp      q0, q1, [sp, #0x1f0]
0069F5710  bl       #0x6b5203c ; HotFix.Common.DxxFPMath$$GetForward
0069F5714  ldr      q0, [sp, #0x430]
0069F5718  ldr      x8, [sp, #0x440]
0069F571C  str      x22, [sp, #8]
0069F5720  str      q0, [sp, #0x360]
0069F5724  str      x8, [sp, #0x370]
0069F5728  ldr      w8, [x21, #0x38]
0069F572C  cbz      w8, #0x69f5744
0069F5730  mov      w9, #0x1680000
0069F5734  sdiv     w8, w9, w8
0069F5738  sxtw     x8, w8
0069F573C  str      x8, [sp, #0x28]
0069F5740  b        #0x69f5748 ; 
0069F5744  str      xzr, [sp, #0x28]
0069F5748  ldr      x19, [sp, #0x58]
0069F574C  add      x0, sp, #0x3a0
0069F5750  mov      x1, xzr
0069F5754  ldrb     w8, [x19, #0x54]
0069F5758  str      w8, [sp, #0x3c]
0069F575C  add      x8, sp, #0x430
0069F5760  bl       #0x7d4bb5c ; Photon.Deterministic.FPQuaternion$$get_AsEuler
0069F5764  ldr      x10, [sp, #0x438]
0069F5768  ldp      x11, x12, [x21, #0xb8]
0069F576C  ldrsw    x8, [x19, #0x58]
0069F5770  ldr      w9, [x21, #0x11c]
0069F5774  add      x10, x11, x10
0069F5778  madd     x10, x12, x8, x10
0069F577C  cmp      w9, #1
0069F5780  str      x10, [sp, #0x40]
0069F5784  b.le     #0x69f57a0
0069F5788  ldr      x10, [x21, #0x120]
0069F578C  sdiv     w8, w8, w9
0069F5790  ldr      x9, [sp, #0x40]
0069F5794  sxtw     x8, w8
0069F5798  madd     x9, x10, x8, x9
0069F579C  str      x9, [sp, #0x40]
0069F57A0  ldr      w8, [x21, #0x38]
0069F57A4  cmp      w8, #1
0069F57A8  b.lt     #0x69f5b04
0069F57AC  add      x8, sp, #0x60
0069F57B0  add      x10, sp, #0x430
0069F57B4  add      x9, sp, #0x2c0
0069F57B8  orr      x11, x8, #1
0069F57BC  add      x8, x10, #0x78
0069F57C0  mov      x25, xzr
0069F57C4  mov      x19, xzr
0069F57C8  mov      x20, xzr
0069F57CC  add      x26, x9, #0x18
0069F57D0  add      x28, x10, #0x48
0069F57D4  stp      x8, x11, [sp, #0x18]
0069F57D8  add      x22, x10, #0x91
0069F57DC  add      x8, x10, #0xd8
0069F57E0  str      x8, [sp, #0x10]
0069F57E4  ldr      w8, [sp, #0x3c]
0069F57E8  ldr      x9, [sp, #0x40]
0069F57EC  ldp      q0, q1, [sp, #0x3a0]
0069F57F0  mov      x0, xzr
0069F57F4  tst      w8, #1
0069F57F8  csel     x8, x25, x19, eq
0069F57FC  add      x24, x8, x9
0069F5800  add      x8, sp, #0x430
0069F5804  stp      q0, q1, [sp, #0xb0]
0069F5808  bl       #0x7d4fd6c ; Photon.Deterministic.FPVector3$$get_Up
0069F580C  ldr      x8, [sp, #0x440]
0069F5810  ldr      q0, [sp, #0x430]
0069F5814  ldp      q1, q2, [sp, #0xb0]
0069F5818  add      x0, sp, #0x1d0
0069F581C  str      x8, [sp, #0x1c0]
0069F5820  add      x8, sp, #0x430
0069F5824  add      x1, sp, #0x1b0
0069F5828  mov      x2, xzr
0069F582C  str      q0, [sp, #0x1b0]
0069F5830  stp      q1, q2, [sp, #0x1d0]
0069F5834  bl       #0x7d4d6a4 ; Photon.Deterministic.FPQuaternion$$op_Multiply
0069F5838  ldr      x8, [sp, #0x440]
0069F583C  ldr      q0, [sp, #0x430]
0069F5840  add      x1, sp, #0x190
0069F5844  mov      x0, x24
0069F5848  str      x8, [sp, #0x1a0]
0069F584C  add      x8, sp, #0x430
0069F5850  mov      x2, xzr
0069F5854  str      q0, [sp, #0x190]
0069F5858  bl       #0x7d4cbc0 ; Photon.Deterministic.FPQuaternion$$AngleAxis
0069F585C  ldr      q0, [sp, #0x440]
0069F5860  ldr      q1, [sp, #0x430]
0069F5864  ldp      q2, q3, [sp, #0x3a0]
0069F5868  add      x8, sp, #0x430
0069F586C  add      x0, sp, #0x130
0069F5870  add      x1, sp, #0x100
0069F5874  mov      x2, xzr
0069F5878  stp      q1, q0, [sp, #0x340]
0069F587C  stp      q2, q3, [sp, #0x130]
0069F5880  stp      q1, q0, [sp, #0x100]
0069F5884  bl       #0x7d4bce4 ; Photon.Deterministic.FPQuaternion$$Product
0069F5888  ldr      q0, [sp, #0x430]
0069F588C  ldr      q1, [sp, #0x440]
0069F5890  add      x8, sp, #0x430
0069F5894  add      x0, sp, #0x320
0069F5898  mov      x1, xzr
0069F589C  stp      q0, q1, [sp, #0x320]
0069F58A0  bl       #0x7d4bb5c ; Photon.Deterministic.FPQuaternion$$get_AsEuler
0069F58A4  ldr      x0, [sp, #0x438]
0069F58A8  add      x8, sp, #0x430
0069F58AC  mov      x1, xzr
0069F58B0  bl       #0x6b51a1c ; HotFix.Common.DxxFPMath$$GetDirection
0069F58B4  ldr      x8, [sp, #0x440]
0069F58B8  ldr      q0, [sp, #0x430]
0069F58BC  add      x0, sp, #0x130
0069F58C0  mov      x1, xzr
0069F58C4  str      x8, [sp, #0x310]
0069F58C8  str      x8, [sp, #0x140]
0069F58CC  add      x8, sp, #0x430
0069F58D0  str      q0, [sp, #0x300]
0069F58D4  str      q0, [sp, #0x130]
0069F58D8  bl       #0x7d4fef8 ; Photon.Deterministic.FPVector3$$Normalize
0069F58DC  ldr      x12, [sp, #0x58]
0069F58E0  ldr      x11, [x21, #0xa8]
0069F58E4  ldr      x13, [x21, #0xc8]
0069F58E8  movi     v0.2d, #0000000000000000
0069F58EC  ldrsw    x12, [x12, #0x58]
0069F58F0  str      xzr, [sp, #0x80]
0069F58F4  stp      q0, q0, [sp, #0x60]
0069F58F8  ldr      x8, [sp, #0x430]
0069F58FC  nop      
0069F5900  madd     x11, x13, x12, x11
0069F5904  ldr      x12, [sp, #0x20]
0069F5908  ldr      w24, [x21, #0xa0]
0069F590C  stp      q0, q0, [x26]
0069F5910  stp      q0, q0, [sp, #0x290]
0069F5914  ldp      q0, q1, [x12]
0069F5918  ldur     x12, [x12, #0x1f]
0069F591C  ldr      x9, [sp, #0x438]
0069F5920  ldr      x10, [sp, #0x440]
0069F5924  add      x13, sp, #0x248
0069F5928  str      xzr, [sp, #0x2b0]
0069F592C  str      xzr, [sp, #0x258]
0069F5930  str      xzr, [sp, #0x248]
0069F5934  str      xzr, [sp, #0x250]
0069F5938  mul      x8, x11, x8
0069F593C  stur     x12, [x13, #0x37]
0069F5940  stp      q0, q1, [sp, #0x260]
0069F5944  asr      x29, x8, #0x10
0069F5948  ldrb     w8, [x21, #0xb0]
0069F594C  mul      x9, x11, x9
0069F5950  asr      x23, x9, #0x10
0069F5954  mul      x9, x11, x10
0069F5958  mov      x27, x21
0069F595C  asr      x21, x9, #0x10
0069F5960  cbz      w8, #0x69f59b4
0069F5964  add      x8, sp, #0x430
0069F5968  add      x0, sp, #0x130
0069F596C  mov      x1, xzr
0069F5970  stp      x29, x23, [sp, #0x130]
0069F5974  str      x21, [sp, #0x140]
0069F5978  bl       #0x7d4fef8 ; Photon.Deterministic.FPVector3$$Normalize
0069F597C  ldr      x8, [sp, #0x440]
0069F5980  ldr      q0, [sp, #0x430]
0069F5984  add      x0, sp, #0x170
0069F5988  mov      w1, wzr
0069F598C  str      x8, [sp, #0x240]
0069F5990  str      x8, [sp, #0x180]
0069F5994  add      x8, sp, #0x430
0069F5998  mov      x2, xzr
0069F599C  str      q0, [sp, #0x230]
0069F59A0  str      q0, [sp, #0x170]
0069F59A4  bl       #0x7d4c564 ; Photon.Deterministic.FPQuaternion$$LookRotation
0069F59A8  ldr      q0, [sp, #0x440]
0069F59AC  ldr      q1, [sp, #0x430]
0069F59B0  b        #0x69f59b8 ; 
0069F59B4  ldp      q1, q0, [sp, #0x3a0]
0069F59B8  ldr      x8, [sp, #0x390]
0069F59BC  stp      q1, q0, [x26]
0069F59C0  ldr      q0, [sp, #0x380]
0069F59C4  ldp      q1, q2, [sp, #0x290]
0069F59C8  str      x8, [sp, #0x2d0]
0069F59CC  ldp      x12, x8, [sp, #0x50]
0069F59D0  ldr      x11, [sp, #0x2b0]
0069F59D4  str      q0, [sp, #0x2c0]
0069F59D8  ldr      q3, [sp, #0x360]
0069F59DC  ldr      x0, [x12]
0069F59E0  add      x12, sp, #0x248
0069F59E4  ldr      x8, [x8]
0069F59E8  ldr      x9, [x27, #0x60]
0069F59EC  str      x11, [sp, #0x120]
0069F59F0  ldur     x11, [x12, #0x37]
0069F59F4  stp      q1, q2, [sp, #0x100]
0069F59F8  ldp      q1, q2, [sp, #0x260]
0069F59FC  ldr      x10, [sp, #0x2f0]
0069F5A00  stur     x11, [sp, #0xcf]
0069F5A04  str      q3, [sp, #0xe0]
0069F5A08  stp      q1, q2, [sp, #0xb0]
0069F5A0C  ldp      q3, q1, [sp, #0x2d0]
0069F5A10  str      x10, [sp, #0x160]
0069F5A14  ldr      x10, [sp, #0x370]
0069F5A18  ldr      x11, [sp, #0x258]
0069F5A1C  stp      q0, q3, [sp, #0x130]
0069F5A20  ldr      q0, [x12]
0069F5A24  str      x10, [sp, #0xf0]
0069F5A28  str      x11, [sp, #0xa0]
0069F5A2C  str      q1, [sp, #0x150]
0069F5A30  str      q0, [sp, #0x90]
0069F5A34  cbz      x0, #0x69f5b38
0069F5A38  madd     x8, x9, x20, x8
0069F5A3C  adrp     x9, #0x8f31000
0069F5A40  ldr      x9, [x9, #0x468] ; GLOBAL Method$System.Collections.Generic.Queue<Weapon.FireData>.Enqueue()
0069F5A44  ldr      x10, [sp, #0x48]
0069F5A48  ldp      q0, q1, [sp, #0x130]
0069F5A4C  ldr      q2, [sp, #0x150]
0069F5A50  ldr      x2, [x9]
0069F5A54  ldr      x9, [sp, #0x160]
0069F5A58  str      x10, [sp, #0x470]
0069F5A5C  ldr      x10, [sp, #0x120]
0069F5A60  str      q0, [sp, #0x430]
0069F5A64  str      q1, [sp, #0x440]
0069F5A68  ldp      q0, q1, [sp, #0x100]
0069F5A6C  str      q2, [sp, #0x450]
0069F5A70  str      x9, [sp, #0x460]
0069F5A74  str      x8, [sp, #0x468]
0069F5A78  str      x10, [x28, #0x20]
0069F5A7C  ldr      x10, [sp, #0x30]
0069F5A80  ldr      q2, [sp, #0xe0]
0069F5A84  ldr      x8, [sp, #0xf0]
0069F5A88  stp      q0, q1, [x28]
0069F5A8C  str      x10, [sp, #0x4a0]
0069F5A90  ldr      x10, [sp, #0x18]
0069F5A94  ldur     x9, [sp, #0xcf]
0069F5A98  ldp      q0, q1, [sp, #0xb0]
0069F5A9C  add      x1, sp, #0x430
0069F5AA0  str      q2, [x10]
0069F5AA4  str      x8, [x10, #0x10]
0069F5AA8  mov      w10, #1
0069F5AAC  ldr      q2, [sp, #0x90]
0069F5AB0  ldr      x8, [sp, #0xa0]
0069F5AB4  strb     w10, [sp, #0x4c0]
0069F5AB8  stur     x9, [x22, #0x1f]
0069F5ABC  ldr      x9, [sp, #0x10]
0069F5AC0  stp      q0, q1, [x22]
0069F5AC4  str      w24, [sp, #0x4e8]
0069F5AC8  str      wzr, [sp, #0x4ec]
0069F5ACC  str      x29, [sp, #0x4f0]
0069F5AD0  str      x23, [sp, #0x4f8]
0069F5AD4  str      x21, [sp, #0x500]
0069F5AD8  str      x8, [x9, #0x10]
0069F5ADC  str      q2, [x9]
0069F5AE0  bl       #0x52ed200 ; System.Collections.Generic.Queue<Weapon.FireData>$$Enqueue
0069F5AE4  ldrsw    x8, [x27, #0x38]
0069F5AE8  ldr      x9, [sp, #0x28]
0069F5AEC  add      x20, x20, #1
0069F5AF0  mov      x21, x27
0069F5AF4  cmp      x20, x8
0069F5AF8  add      x19, x19, x9
0069F5AFC  sub      x25, x25, x9
0069F5B00  b.lt     #0x69f57e4
0069F5B04  ldr      x22, [sp, #8]
0069F5B08  ldr      x8, [x22, #0x28]
0069F5B0C  ldr      x9, [sp, #0x528]
0069F5B10  cmp      x8, x9
0069F5B14  b.ne     #0x69f5b3c
0069F5B18  add      sp, sp, #0x530
0069F5B1C  ldp      x20, x19, [sp, #0x50]
0069F5B20  ldp      x22, x21, [sp, #0x40]
0069F5B24  ldp      x24, x23, [sp, #0x30]
0069F5B28  ldp      x26, x25, [sp, #0x20]
0069F5B2C  ldp      x28, x27, [sp, #0x10]
0069F5B30  ldp      x29, x30, [sp], #0x60
0069F5B34  ret      
0069F5B38  bl       #0x382bfb8 ; 
0069F5B3C  bl       #0x89edb60 ; 

