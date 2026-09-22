; HotFix.BattleLogic.EntityCharacterData$$SetShapeScale
; RVA 0x68252CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068252CC  sub      sp, sp, #0x180
0068252D0  str      x29, [sp, #0x120]
0068252D4  stp      x30, x27, [sp, #0x130]
0068252D8  stp      x26, x25, [sp, #0x140]
0068252DC  stp      x24, x23, [sp, #0x150]
0068252E0  stp      x22, x21, [sp, #0x160]
0068252E4  stp      x20, x19, [sp, #0x170]
0068252E8  mrs      x23, tpidr_el0
0068252EC  ldr      x8, [x23, #0x28]
0068252F0  adrp     x21, #0x959b000
0068252F4  adrp     x22, #0x8f22000
0068252F8  mov      x20, x1
0068252FC  str      x8, [sp, #0x118]
006825300  ldrb     w8, [x21, #0x6eb]
006825304  ldr      x22, [x22, #0x148] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetShapeScale()
006825308  mov      x19, x0
00682530C  tbnz     w8, #0, #0x6825324
006825310  adrp     x0, #0x8f22000
006825314  ldr      x0, [x0, #0x148] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetShapeScale()
006825318  bl       #0x382bd14 ; 
00682531C  mov      w8, #1
006825320  strb     w8, [x21, #0x6eb]
006825324  ldr      x2, [x22]
006825328  ldrb     w8, [x2, #0x53]
00682532C  tbnz     w8, #5, #0x682592c
006825330  adrp     x22, #0x9591000
006825334  ldrb     w8, [x22, #0xa74]
006825338  cbnz     w8, #0x6825350
00682533C  adrp     x0, #0x8ee6000
006825340  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825344  bl       #0x382bd14 ; 
006825348  mov      w8, #1
00682534C  strb     w8, [x22, #0xa74]
006825350  adrp     x26, #0x8ee6000
006825354  ldr      x26, [x26, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825358  ldr      x1, [x26]
00682535C  ldrb     w8, [x1, #0x53]
006825360  tbnz     w8, #5, #0x682536c
006825364  ldr      x21, [x19, #0x170]
006825368  b        #0x682537c ; 
00682536C  ldr      x8, [x1, #0x60]
006825370  mov      x0, x19
006825374  blr      x8
006825378  mov      x21, x0
00682537C  cbz      x21, #0x682596c
006825380  adrp     x24, #0x9598000
006825384  ldrb     w8, [x24, #0xfbb]
006825388  cbnz     w8, #0x68253a0
00682538C  adrp     x0, #0x8f05000
006825390  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825394  bl       #0x382bd14 ; 
006825398  mov      w8, #1
00682539C  strb     w8, [x24, #0xfbb]
0068253A0  adrp     x25, #0x8f05000
0068253A4  ldr      x25, [x25, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
0068253A8  ldr      x1, [x25]
0068253AC  ldrb     w8, [x1, #0x53]
0068253B0  tbnz     w8, #5, #0x68253bc
0068253B4  ldr      x0, [x21, #0x48]
0068253B8  b        #0x68253c8 ; 
0068253BC  ldr      x8, [x1, #0x60]
0068253C0  mov      x0, x21
0068253C4  blr      x8
0068253C8  cbz      x0, #0x682596c
0068253CC  ldrb     w8, [x22, #0xa74]
0068253D0  ldr      w27, [x0, #0x18]
0068253D4  cbnz     w8, #0x68253ec
0068253D8  adrp     x0, #0x8ee6000
0068253DC  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068253E0  bl       #0x382bd14 ; 
0068253E4  mov      w8, #1
0068253E8  strb     w8, [x22, #0xa74]
0068253EC  ldr      x1, [x26]
0068253F0  ldrb     w8, [x1, #0x53]
0068253F4  tbnz     w8, #5, #0x6825400
0068253F8  ldr      x21, [x19, #0x170]
0068253FC  b        #0x6825410 ; 
006825400  ldr      x8, [x1, #0x60]
006825404  mov      x0, x19
006825408  blr      x8
00682540C  mov      x21, x0
006825410  cbz      x21, #0x682596c
006825414  ldrb     w8, [x24, #0xfbb]
006825418  cbnz     w8, #0x6825430
00682541C  adrp     x0, #0x8f05000
006825420  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825424  bl       #0x382bd14 ; 
006825428  mov      w8, #1
00682542C  strb     w8, [x24, #0xfbb]
006825430  ldr      x1, [x25]
006825434  ldrb     w8, [x1, #0x53]
006825438  tbnz     w8, #5, #0x6825444
00682543C  ldr      x0, [x21, #0x48]
006825440  b        #0x6825450 ; 
006825444  ldr      x8, [x1, #0x60]
006825448  mov      x0, x21
00682544C  blr      x8
006825450  cbz      x0, #0x682596c
006825454  ldr      w8, [x0, #0x18]
006825458  cmp      w27, #2
00682545C  b.ne     #0x6825498
006825460  cbz      w8, #0x6825970
006825464  ldrb     w8, [x22, #0xa74]
006825468  ldr      x21, [x0, #0x20]
00682546C  cbnz     w8, #0x6825484
006825470  adrp     x0, #0x8ee6000
006825474  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825478  bl       #0x382bd14 ; 
00682547C  mov      w8, #1
006825480  strb     w8, [x22, #0xa74]
006825484  ldr      x1, [x26]
006825488  ldrb     w8, [x1, #0x53]
00682548C  tbnz     w8, #5, #0x6825540
006825490  ldr      x22, [x19, #0x170]
006825494  b        #0x6825550 ; 
006825498  cmp      w8, #1
00682549C  b.ne     #0x68254d0
0068254A0  ldrb     w8, [x22, #0xa74]
0068254A4  cbnz     w8, #0x68254bc
0068254A8  adrp     x0, #0x8ee6000
0068254AC  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068254B0  bl       #0x382bd14 ; 
0068254B4  mov      w8, #1
0068254B8  strb     w8, [x22, #0xa74]
0068254BC  ldr      x1, [x26]
0068254C0  ldrb     w8, [x1, #0x53]
0068254C4  tbnz     w8, #5, #0x6825744
0068254C8  ldr      x21, [x19, #0x170]
0068254CC  b        #0x6825754 ; 
0068254D0  mov      w8, #0xccb
0068254D4  mul      x8, x20, x8
0068254D8  asr      x0, x8, #0x10
0068254DC  add      x8, sp, #0xd0
0068254E0  mov      x1, xzr
0068254E4  mov      x2, xzr
0068254E8  mov      x3, xzr
0068254EC  bl       #0x7e29220 ; Quantum.Shape2D$$CreateCircle
0068254F0  adrp     x20, #0x959b000
0068254F4  ldp      q0, q1, [sp, #0xd0]
0068254F8  ldp      q2, q3, [sp, #0xf0]
0068254FC  ldrb     w8, [x20, #0x78d]
006825500  stp      q0, q1, [sp]
006825504  stp      q2, q3, [sp, #0x20]
006825508  cbnz     w8, #0x6825520
00682550C  adrp     x0, #0x8f22000
006825510  ldr      x0, [x0, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
006825514  bl       #0x382bd14 ; 
006825518  mov      w8, #1
00682551C  strb     w8, [x20, #0x78d]
006825520  adrp     x8, #0x8f22000
006825524  ldr      x8, [x8, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
006825528  ldr      x2, [x8]
00682552C  ldrb     w8, [x2, #0x53]
006825530  tbnz     w8, #5, #0x6825788
006825534  ldp      q1, q0, [sp, #0x20]
006825538  ldp      q3, q2, [sp]
00682553C  b        #0x682581c ; 
006825540  ldr      x8, [x1, #0x60]
006825544  mov      x0, x19
006825548  blr      x8
00682554C  mov      x22, x0
006825550  cbz      x22, #0x682596c
006825554  ldrb     w8, [x24, #0xfbb]
006825558  cbnz     w8, #0x6825570
00682555C  adrp     x0, #0x8f05000
006825560  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825564  bl       #0x382bd14 ; 
006825568  mov      w8, #1
00682556C  strb     w8, [x24, #0xfbb]
006825570  ldr      x1, [x25]
006825574  ldrb     w8, [x1, #0x53]
006825578  tbnz     w8, #5, #0x6825584
00682557C  ldr      x0, [x22, #0x48]
006825580  b        #0x6825590 ; 
006825584  ldr      x8, [x1, #0x60]
006825588  mov      x0, x22
00682558C  blr      x8
006825590  cbz      x0, #0x682596c
006825594  ldr      w8, [x0, #0x18]
006825598  cmp      w8, #1
00682559C  b.ls     #0x6825970
0068255A0  ldr      x2, [x0, #0x28]
0068255A4  add      x0, sp, #0xc0
0068255A8  mov      x1, x21
0068255AC  mov      x3, xzr
0068255B0  stp      xzr, xzr, [sp, #0xc0]
0068255B4  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
0068255B8  ldp      x8, x9, [sp, #0xc0]
0068255BC  mov      x2, xzr
0068255C0  mov      x3, xzr
0068255C4  mov      x4, xzr
0068255C8  mul      x8, x8, x20
0068255CC  mul      x9, x9, x20
0068255D0  asr      x0, x8, #0x10
0068255D4  asr      x1, x9, #0x10
0068255D8  add      x8, sp, #0xd0
0068255DC  mov      x5, xzr
0068255E0  bl       #0x7e292c4 ; Quantum.Shape2D$$CreateBox
0068255E4  adrp     x20, #0x959b000
0068255E8  ldp      q0, q1, [sp, #0xd0]
0068255EC  ldp      q2, q3, [sp, #0xf0]
0068255F0  ldrb     w8, [x20, #0x78d]
0068255F4  stp      q0, q1, [sp, #0x80]
0068255F8  stp      q2, q3, [sp, #0xa0]
0068255FC  cbnz     w8, #0x6825614
006825600  adrp     x0, #0x8f22000
006825604  ldr      x0, [x0, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
006825608  bl       #0x382bd14 ; 
00682560C  mov      w8, #1
006825610  strb     w8, [x20, #0x78d]
006825614  adrp     x8, #0x8f22000
006825618  ldr      x8, [x8, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
00682561C  ldr      x2, [x8]
006825620  ldrb     w8, [x2, #0x53]
006825624  tbnz     w8, #5, #0x682563c
006825628  ldp      q1, q0, [sp, #0xa0]
00682562C  ldp      q3, q2, [sp, #0x80]
006825630  stp      q1, q0, [x19, #0x1e0]
006825634  stp      q3, q2, [x19, #0x1c0]
006825638  b        #0x682565c ; 
00682563C  ldr      x8, [x2, #0x60]
006825640  ldp      q0, q1, [sp, #0x80]
006825644  ldp      q2, q3, [sp, #0xa0]
006825648  add      x1, sp, #0xd0
00682564C  mov      x0, x19
006825650  stp      q0, q1, [sp, #0xd0]
006825654  stp      q2, q3, [sp, #0xf0]
006825658  blr      x8
00682565C  adrp     x20, #0x9594000
006825660  ldrb     w8, [x20, #0x274]
006825664  cbnz     w8, #0x682567c
006825668  adrp     x0, #0x8ee9000
00682566C  ldr      x0, [x0, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
006825670  bl       #0x382bd14 ; 
006825674  mov      w8, #1
006825678  strb     w8, [x20, #0x274]
00682567C  adrp     x8, #0x8ee9000
006825680  ldr      x8, [x8, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
006825684  ldr      x1, [x8]
006825688  ldrb     w8, [x1, #0x53]
00682568C  tbnz     w8, #5, #0x68256a4
006825690  ldp      q1, q0, [x19, #0x1e0]
006825694  ldp      q3, q2, [x19, #0x1c0]
006825698  stp      q1, q0, [sp, #0xf0]
00682569C  stp      q3, q2, [sp, #0xd0]
0068256A0  b        #0x68256b4 ; 
0068256A4  ldr      x9, [x1, #0x60]
0068256A8  add      x8, sp, #0xd0
0068256AC  mov      x0, x19
0068256B0  blr      x9
0068256B4  ldp      x20, x21, [sp, #0xf8]
0068256B8  mov      x1, xzr
0068256BC  mul      x9, x21, x21
0068256C0  mul      x8, x20, x20
0068256C4  asr      x9, x9, #0x10
0068256C8  add      x0, x9, x8, asr #16
0068256CC  bl       #0x7d472cc ; Photon.Deterministic.FPMath$$SqrtRaw
0068256D0  adrp     x24, #0x959b000
0068256D4  ldrb     w8, [x24, #0x78e]
0068256D8  mov      x22, x0
0068256DC  cbnz     w8, #0x68256f4
0068256E0  adrp     x0, #0x8f22000
0068256E4  ldr      x0, [x0, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068256E8  bl       #0x382bd14 ; 
0068256EC  mov      w8, #1
0068256F0  strb     w8, [x24, #0x78e]
0068256F4  adrp     x8, #0x8f22000
0068256F8  ldr      x8, [x8, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068256FC  ldr      x2, [x8]
006825700  ldrb     w8, [x2, #0x53]
006825704  tbnz     w8, #5, #0x6825710
006825708  str      x22, [x19, #0x200]
00682570C  b        #0x6825720 ; 
006825710  ldr      x8, [x2, #0x60]
006825714  mov      x0, x19
006825718  mov      x1, x22
00682571C  blr      x8
006825720  mov      x0, x20
006825724  mov      x1, x21
006825728  mov      x2, xzr
00682572C  bl       #0x7d46f8c ; Photon.Deterministic.FPMath$$Min
006825730  adrp     x21, #0x959b000
006825734  ldrb     w8, [x21, #0x78f]
006825738  mov      x20, x0
00682573C  cbnz     w8, #0x6825910
006825740  b        #0x68258fc ; 
006825744  ldr      x8, [x1, #0x60]
006825748  mov      x0, x19
00682574C  blr      x8
006825750  mov      x21, x0
006825754  cbz      x21, #0x682596c
006825758  ldrb     w8, [x24, #0xfbb]
00682575C  cbnz     w8, #0x6825774
006825760  adrp     x0, #0x8f05000
006825764  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825768  bl       #0x382bd14 ; 
00682576C  mov      w8, #1
006825770  strb     w8, [x24, #0xfbb]
006825774  ldr      x1, [x25]
006825778  ldrb     w8, [x1, #0x53]
00682577C  tbnz     w8, #5, #0x6825798
006825780  ldr      x0, [x21, #0x48]
006825784  b        #0x68257a4 ; 
006825788  ldr      x8, [x2, #0x60]
00682578C  ldp      q0, q1, [sp]
006825790  ldp      q2, q3, [sp, #0x20]
006825794  b        #0x6825834 ; 
006825798  ldr      x8, [x1, #0x60]
00682579C  mov      x0, x21
0068257A0  blr      x8
0068257A4  cbz      x0, #0x682596c
0068257A8  ldr      w8, [x0, #0x18]
0068257AC  cbz      w8, #0x6825970
0068257B0  ldr      x8, [x0, #0x20]
0068257B4  mov      x1, xzr
0068257B8  mov      x2, xzr
0068257BC  mov      x3, xzr
0068257C0  mul      x8, x8, x20
0068257C4  asr      x0, x8, #0x10
0068257C8  add      x8, sp, #0xd0
0068257CC  bl       #0x7e29220 ; Quantum.Shape2D$$CreateCircle
0068257D0  adrp     x20, #0x959b000
0068257D4  ldp      q0, q1, [sp, #0xd0]
0068257D8  ldp      q2, q3, [sp, #0xf0]
0068257DC  ldrb     w8, [x20, #0x78d]
0068257E0  stp      q0, q1, [sp, #0x40]
0068257E4  stp      q2, q3, [sp, #0x60]
0068257E8  cbnz     w8, #0x6825800
0068257EC  adrp     x0, #0x8f22000
0068257F0  ldr      x0, [x0, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
0068257F4  bl       #0x382bd14 ; 
0068257F8  mov      w8, #1
0068257FC  strb     w8, [x20, #0x78d]
006825800  adrp     x8, #0x8f22000
006825804  ldr      x8, [x8, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
006825808  ldr      x2, [x8]
00682580C  ldrb     w8, [x2, #0x53]
006825810  tbnz     w8, #5, #0x6825828
006825814  ldp      q1, q0, [sp, #0x60]
006825818  ldp      q3, q2, [sp, #0x40]
00682581C  stp      q1, q0, [x19, #0x1e0]
006825820  stp      q3, q2, [x19, #0x1c0]
006825824  b        #0x6825848 ; 
006825828  ldr      x8, [x2, #0x60]
00682582C  ldp      q0, q1, [sp, #0x40]
006825830  ldp      q2, q3, [sp, #0x60]
006825834  add      x1, sp, #0xd0
006825838  mov      x0, x19
00682583C  stp      q0, q1, [sp, #0xd0]
006825840  stp      q2, q3, [sp, #0xf0]
006825844  blr      x8
006825848  adrp     x20, #0x9594000
00682584C  ldrb     w8, [x20, #0x274]
006825850  cbnz     w8, #0x6825868
006825854  adrp     x0, #0x8ee9000
006825858  ldr      x0, [x0, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
00682585C  bl       #0x382bd14 ; 
006825860  mov      w8, #1
006825864  strb     w8, [x20, #0x274]
006825868  adrp     x8, #0x8ee9000
00682586C  ldr      x8, [x8, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
006825870  ldr      x1, [x8]
006825874  ldrb     w8, [x1, #0x53]
006825878  tbnz     w8, #5, #0x6825890
00682587C  ldp      q1, q0, [x19, #0x1e0]
006825880  ldp      q3, q2, [x19, #0x1c0]
006825884  stp      q1, q0, [sp, #0xf0]
006825888  stp      q3, q2, [sp, #0xd0]
00682588C  b        #0x68258a0 ; 
006825890  ldr      x9, [x1, #0x60]
006825894  add      x8, sp, #0xd0
006825898  mov      x0, x19
00682589C  blr      x9
0068258A0  adrp     x21, #0x959b000
0068258A4  ldrb     w8, [x21, #0x78e]
0068258A8  ldr      x20, [sp, #0xf0]
0068258AC  cbnz     w8, #0x68258c4
0068258B0  adrp     x0, #0x8f22000
0068258B4  ldr      x0, [x0, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068258B8  bl       #0x382bd14 ; 
0068258BC  mov      w8, #1
0068258C0  strb     w8, [x21, #0x78e]
0068258C4  adrp     x8, #0x8f22000
0068258C8  ldr      x8, [x8, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068258CC  ldr      x2, [x8]
0068258D0  ldrb     w8, [x2, #0x53]
0068258D4  tbnz     w8, #5, #0x68258e0
0068258D8  str      x20, [x19, #0x200]
0068258DC  b        #0x68258f0 ; 
0068258E0  ldr      x8, [x2, #0x60]
0068258E4  mov      x0, x19
0068258E8  mov      x1, x20
0068258EC  blr      x8
0068258F0  adrp     x21, #0x959b000
0068258F4  ldrb     w8, [x21, #0x78f]
0068258F8  cbnz     w8, #0x6825910
0068258FC  adrp     x0, #0x8f22000
006825900  ldr      x0, [x0, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius2()
006825904  bl       #0x382bd14 ; 
006825908  mov      w8, #1
00682590C  strb     w8, [x21, #0x78f]
006825910  adrp     x8, #0x8f22000
006825914  ldr      x8, [x8, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius2()
006825918  ldr      x2, [x8]
00682591C  ldrb     w8, [x2, #0x53]
006825920  tbnz     w8, #5, #0x682592c
006825924  str      x20, [x19, #0x208]
006825928  b        #0x682593c ; 
00682592C  ldr      x8, [x2, #0x60]
006825930  mov      x0, x19
006825934  mov      x1, x20
006825938  blr      x8
00682593C  ldr      x8, [x23, #0x28]
006825940  ldr      x9, [sp, #0x118]
006825944  cmp      x8, x9
006825948  b.ne     #0x6825974
00682594C  ldp      x20, x19, [sp, #0x170]
006825950  ldp      x22, x21, [sp, #0x160]
006825954  ldp      x24, x23, [sp, #0x150]
006825958  ldp      x26, x25, [sp, #0x140]
00682595C  ldp      x30, x27, [sp, #0x130]
006825960  ldr      x29, [sp, #0x120]
006825964  add      sp, sp, #0x180
006825968  ret      
00682596C  bl       #0x382bfb8 ; 
006825970  bl       #0x382bfc0 ; 
006825974  bl       #0x89edb60 ; 

