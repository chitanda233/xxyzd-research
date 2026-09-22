; HotFix.BattleLogic.BulletData$$SetScaleShape
; RVA 0x6678234; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006678234  stp      x29, x30, [sp, #-0x60]!
006678238  stp      x28, x27, [sp, #0x10]
00667823C  stp      x26, x25, [sp, #0x20]
006678240  stp      x24, x23, [sp, #0x30]
006678244  stp      x22, x21, [sp, #0x40]
006678248  stp      x20, x19, [sp, #0x50]
00667824C  sub      sp, sp, #0x210
006678250  mrs      x25, tpidr_el0
006678254  ldr      x8, [x25, #0x28]
006678258  adrp     x23, #0x9599000
00667825C  adrp     x24, #0x8f0f000
006678260  mov      x20, x3
006678264  str      x8, [sp, #0x208]
006678268  ldrb     w8, [x23, #0xea3]
00667826C  ldr      x24, [x24, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.SetScaleShape()
006678270  mov      x21, x2
006678274  mov      x22, x1
006678278  mov      x19, x0
00667827C  tbnz     w8, #0, #0x6678294
006678280  adrp     x0, #0x8f0f000
006678284  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.SetScaleShape()
006678288  bl       #0x382bd14 ; 
00667828C  mov      w8, #1
006678290  strb     w8, [x23, #0xea3]
006678294  ldr      x4, [x24]
006678298  ldrb     w8, [x4, #0x53]
00667829C  tbnz     w8, #5, #0x66782e8
0066782A0  adrp     x23, #0x9599000
0066782A4  ldrb     w8, [x23, #0xef5]
0066782A8  movi     v0.2d, #0000000000000000
0066782AC  stp      q0, q0, [sp, #0x1a0]
0066782B0  stp      q0, q0, [sp, #0x180]
0066782B4  cbnz     w8, #0x66782cc
0066782B8  adrp     x0, #0x8f0f000
0066782BC  ldr      x0, [x0, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius()
0066782C0  bl       #0x382bd14 ; 
0066782C4  mov      w8, #1
0066782C8  strb     w8, [x23, #0xef5]
0066782CC  adrp     x8, #0x8f0f000
0066782D0  ldr      x8, [x8, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius()
0066782D4  ldr      x2, [x8]
0066782D8  ldrb     w8, [x2, #0x53]
0066782DC  tbnz     w8, #5, #0x6678304
0066782E0  str      xzr, [x19, #0x3f8]
0066782E4  b        #0x6678314 ; 
0066782E8  ldr      x8, [x4, #0x60]
0066782EC  mov      x0, x19
0066782F0  mov      x1, x22
0066782F4  mov      x2, x21
0066782F8  mov      x3, x20
0066782FC  blr      x8
006678300  b        #0x6679380 ; 
006678304  ldr      x8, [x2, #0x60]
006678308  mov      x0, x19
00667830C  mov      x1, xzr
006678310  blr      x8
006678314  adrp     x23, #0x9599000
006678318  ldrb     w8, [x23, #0xef6]
00667831C  cbnz     w8, #0x6678334
006678320  adrp     x0, #0x8f0f000
006678324  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius2()
006678328  bl       #0x382bd14 ; 
00667832C  mov      w8, #1
006678330  strb     w8, [x23, #0xef6]
006678334  adrp     x8, #0x8f0f000
006678338  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius2()
00667833C  ldr      x2, [x8]
006678340  ldrb     w8, [x2, #0x53]
006678344  tbnz     w8, #5, #0x6678350
006678348  str      xzr, [x19, #0x400]
00667834C  b        #0x6678360 ; 
006678350  ldr      x8, [x2, #0x60]
006678354  mov      x0, x19
006678358  mov      x1, xzr
00667835C  blr      x8
006678360  adrp     x23, #0x9599000
006678364  ldrb     w8, [x23, #0xef7]
006678368  cbnz     w8, #0x6678380
00667836C  adrp     x0, #0x8f0f000
006678370  ldr      x0, [x0, #0x9d0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ScalePercent()
006678374  bl       #0x382bd14 ; 
006678378  mov      w8, #1
00667837C  strb     w8, [x23, #0xef7]
006678380  adrp     x8, #0x8f0f000
006678384  ldr      x8, [x8, #0x9d0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ScalePercent()
006678388  ldr      x2, [x8]
00667838C  ldrb     w8, [x2, #0x53]
006678390  tbnz     w8, #5, #0x667839c
006678394  str      x22, [x19, #0x140]
006678398  b        #0x66783ac ; 
00667839C  ldr      x8, [x2, #0x60]
0066783A0  mov      x0, x19
0066783A4  mov      x1, x22
0066783A8  blr      x8
0066783AC  adrp     x23, #0x9591000
0066783B0  ldrb     w8, [x23, #0xa89]
0066783B4  cbnz     w8, #0x66783cc
0066783B8  adrp     x0, #0x8ee6000
0066783BC  ldr      x0, [x0, #0x330] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScalePercent()
0066783C0  bl       #0x382bd14 ; 
0066783C4  mov      w8, #1
0066783C8  strb     w8, [x23, #0xa89]
0066783CC  adrp     x24, #0x8ee6000
0066783D0  ldr      x24, [x24, #0x330] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScalePercent()
0066783D4  ldr      x1, [x24]
0066783D8  ldrb     w8, [x1, #0x53]
0066783DC  tbnz     w8, #5, #0x66783e8
0066783E0  ldr      x22, [x19, #0x140]
0066783E4  b        #0x66783f8 ; 
0066783E8  ldr      x8, [x1, #0x60]
0066783EC  mov      x0, x19
0066783F0  blr      x8
0066783F4  mov      x22, x0
0066783F8  adrp     x27, #0x9599000
0066783FC  ldrb     w8, [x27, #0xef8]
006678400  add      x26, x20, x21
006678404  cbnz     w8, #0x667841c
006678408  adrp     x0, #0x8f0f000
00667840C  ldr      x0, [x0, #0x9d8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ScaleAllPercent()
006678410  bl       #0x382bd14 ; 
006678414  mov      w8, #1
006678418  strb     w8, [x27, #0xef8]
00667841C  adrp     x8, #0x8f0f000
006678420  ldr      x8, [x8, #0x9d8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ScaleAllPercent()
006678424  add      x1, x26, x22
006678428  ldr      x2, [x8]
00667842C  ldrb     w8, [x2, #0x53]
006678430  tbnz     w8, #5, #0x667843c
006678434  str      x1, [x19, #0x148]
006678438  b        #0x6678448 ; 
00667843C  ldr      x8, [x2, #0x60]
006678440  mov      x0, x19
006678444  blr      x8
006678448  ldrb     w8, [x23, #0xa89]
00667844C  cbnz     w8, #0x6678464
006678450  adrp     x0, #0x8ee6000
006678454  ldr      x0, [x0, #0x330] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScalePercent()
006678458  bl       #0x382bd14 ; 
00667845C  mov      w8, #1
006678460  strb     w8, [x23, #0xa89]
006678464  ldr      x1, [x24]
006678468  ldrb     w8, [x1, #0x53]
00667846C  tbnz     w8, #5, #0x6678478
006678470  ldr      x22, [x19, #0x140]
006678474  b        #0x66784a4 ; 
006678478  ldr      x8, [x1, #0x60]
00667847C  mov      x0, x19
006678480  blr      x8
006678484  ldrb     w8, [x23, #0xa89]
006678488  mov      x22, x0
00667848C  cbnz     w8, #0x66784a4
006678490  adrp     x0, #0x8ee6000
006678494  ldr      x0, [x0, #0x330] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScalePercent()
006678498  bl       #0x382bd14 ; 
00667849C  mov      w8, #1
0066784A0  strb     w8, [x23, #0xa89]
0066784A4  ldr      x1, [x24]
0066784A8  ldrb     w8, [x1, #0x53]
0066784AC  tbnz     w8, #5, #0x66784b8
0066784B0  ldr      x23, [x19, #0x140]
0066784B4  b        #0x66784c8 ; 
0066784B8  ldr      x8, [x1, #0x60]
0066784BC  mov      x0, x19
0066784C0  blr      x8
0066784C4  mov      x23, x0
0066784C8  adrp     x26, #0x9591000
0066784CC  ldrb     w8, [x26, #0xa81]
0066784D0  cbnz     w8, #0x66784e8
0066784D4  adrp     x0, #0x8ee6000
0066784D8  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
0066784DC  bl       #0x382bd14 ; 
0066784E0  mov      w8, #1
0066784E4  strb     w8, [x26, #0xa81]
0066784E8  adrp     x27, #0x8ee6000
0066784EC  ldr      x27, [x27, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
0066784F0  ldr      x1, [x27]
0066784F4  ldrb     w8, [x1, #0x53]
0066784F8  tbnz     w8, #5, #0x6678504
0066784FC  ldr      x24, [x19, #0x330]
006678500  b        #0x6678514 ; 
006678504  ldr      x8, [x1, #0x60]
006678508  mov      x0, x19
00667850C  blr      x8
006678510  mov      x24, x0
006678514  cbz      x24, #0x6679680
006678518  adrp     x28, #0x9594000
00667851C  ldrb     w8, [x28, #0x276]
006678520  cbnz     w8, #0x6678538
006678524  adrp     x0, #0x8ee9000
006678528  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
00667852C  bl       #0x382bd14 ; 
006678530  mov      w8, #1
006678534  strb     w8, [x28, #0x276]
006678538  adrp     x29, #0x8ee9000
00667853C  ldr      x29, [x29, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
006678540  ldr      x1, [x29]
006678544  ldrb     w8, [x1, #0x53]
006678548  tbnz     w8, #5, #0x6678554
00667854C  ldr      x0, [x24, #0xe8]
006678550  b        #0x6678560 ; 
006678554  ldr      x8, [x1, #0x60]
006678558  mov      x0, x24
00667855C  blr      x8
006678560  cbz      x0, #0x6679680
006678564  ldr      w8, [x0, #0x18]
006678568  add      x9, x22, x21
00667856C  cmp      w8, #2
006678570  add      x8, x23, x20
006678574  stp      x8, x9, [sp, #0x10]
006678578  b.ne     #0x66785c8
00667857C  mov      x0, x19
006678580  bl       #0x66770b4 ; HotFix.BattleLogic.BulletData$$get_BulletType
006678584  cmp      w0, #3
006678588  b.ne     #0x66785f8
00667858C  adrp     x23, #0x9592000
006678590  ldrb     w8, [x23, #0x474]
006678594  cbnz     w8, #0x66785ac
006678598  adrp     x0, #0x8ee8000
00667859C  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
0066785A0  bl       #0x382bd14 ; 
0066785A4  mov      w8, #1
0066785A8  strb     w8, [x23, #0x474]
0066785AC  adrp     x24, #0x8ee8000
0066785B0  ldr      x24, [x24, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
0066785B4  ldr      x1, [x24]
0066785B8  ldrb     w8, [x1, #0x53]
0066785BC  tbnz     w8, #5, #0x667873c
0066785C0  ldr      x1, [x19, #0x148]
0066785C4  b        #0x667874c ; 
0066785C8  ldrb     w8, [x26, #0xa81]
0066785CC  cbnz     w8, #0x66785e4
0066785D0  adrp     x0, #0x8ee6000
0066785D4  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
0066785D8  bl       #0x382bd14 ; 
0066785DC  mov      w8, #1
0066785E0  strb     w8, [x26, #0xa81]
0066785E4  ldr      x1, [x27]
0066785E8  ldrb     w8, [x1, #0x53]
0066785EC  tbnz     w8, #5, #0x6678628
0066785F0  ldr      x22, [x19, #0x330]
0066785F4  b        #0x6678638 ; 
0066785F8  ldrb     w8, [x26, #0xa81]
0066785FC  cbnz     w8, #0x6678614
006678600  adrp     x0, #0x8ee6000
006678604  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678608  bl       #0x382bd14 ; 
00667860C  mov      w8, #1
006678610  strb     w8, [x26, #0xa81]
006678614  ldr      x1, [x27]
006678618  ldrb     w8, [x1, #0x53]
00667861C  tbnz     w8, #5, #0x6678784
006678620  ldr      x22, [x19, #0x330]
006678624  b        #0x6678794 ; 
006678628  ldr      x8, [x1, #0x60]
00667862C  mov      x0, x19
006678630  blr      x8
006678634  mov      x22, x0
006678638  cbz      x22, #0x6679680
00667863C  ldrb     w8, [x28, #0x276]
006678640  cbnz     w8, #0x6678658
006678644  adrp     x0, #0x8ee9000
006678648  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
00667864C  bl       #0x382bd14 ; 
006678650  mov      w8, #1
006678654  strb     w8, [x28, #0x276]
006678658  ldr      x1, [x29]
00667865C  ldrb     w8, [x1, #0x53]
006678660  tbnz     w8, #5, #0x667866c
006678664  ldr      x0, [x22, #0xe8]
006678668  b        #0x6678678 ; 
00667866C  ldr      x8, [x1, #0x60]
006678670  mov      x0, x22
006678674  blr      x8
006678678  cbz      x0, #0x6679680
00667867C  ldr      w8, [x0, #0x18]
006678680  adrp     x23, #0x8ee8000
006678684  ldr      x23, [x23, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
006678688  adrp     x24, #0x9592000
00667868C  cmp      w8, #1
006678690  b.ne     #0x66786c4
006678694  ldrb     w8, [x24, #0x474]
006678698  cbnz     w8, #0x66786b0
00667869C  adrp     x0, #0x8ee8000
0066786A0  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
0066786A4  bl       #0x382bd14 ; 
0066786A8  mov      w8, #1
0066786AC  strb     w8, [x24, #0x474]
0066786B0  ldr      x1, [x23]
0066786B4  ldrb     w8, [x1, #0x53]
0066786B8  tbnz     w8, #5, #0x66788a4
0066786BC  ldr      x1, [x19, #0x148]
0066786C0  b        #0x66788b4 ; 
0066786C4  add      x8, sp, #0x1c0
0066786C8  mov      w0, #0xccb
0066786CC  mov      x1, xzr
0066786D0  mov      x2, xzr
0066786D4  mov      x3, xzr
0066786D8  bl       #0x7e29220 ; Quantum.Shape2D$$CreateCircle
0066786DC  adrp     x22, #0x9599000
0066786E0  ldp      q0, q1, [sp, #0x1c0]
0066786E4  ldp      q2, q3, [sp, #0x1e0]
0066786E8  ldrb     w8, [x22, #0xed7]
0066786EC  stp      q0, q1, [sp, #0xe0]
0066786F0  stp      q2, q3, [sp, #0x100]
0066786F4  cbnz     w8, #0x667870c
0066786F8  adrp     x0, #0x8f0f000
0066786FC  ldr      x0, [x0, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_Shape()
006678700  bl       #0x382bd14 ; 
006678704  mov      w8, #1
006678708  strb     w8, [x22, #0xed7]
00667870C  adrp     x8, #0x8f0f000
006678710  ldr      x8, [x8, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_Shape()
006678714  adrp     x28, #0x9599000
006678718  ldr      x2, [x8]
00667871C  ldrb     w8, [x2, #0x53]
006678720  tbnz     w8, #5, #0x66788ec
006678724  ldp      q0, q1, [sp, #0x100]
006678728  ldp      q2, q3, [sp, #0xe0]
00667872C  add      x8, x19, #0x1c8
006678730  stp      q0, q1, [x8, #0x20]
006678734  stp      q2, q3, [x8]
006678738  b        #0x667890c ; 
00667873C  ldr      x8, [x1, #0x60]
006678740  mov      x0, x19
006678744  blr      x8
006678748  mov      x1, x0
00667874C  mov      x0, x19
006678750  bl       #0x6679a50 ; HotFix.BattleLogic.BulletData$$CreateCircleShape
006678754  ldrb     w8, [x26, #0xa81]
006678758  cbnz     w8, #0x6678770
00667875C  adrp     x0, #0x8ee6000
006678760  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678764  bl       #0x382bd14 ; 
006678768  mov      w8, #1
00667876C  strb     w8, [x26, #0xa81]
006678770  ldr      x1, [x27]
006678774  ldrb     w8, [x1, #0x53]
006678778  tbnz     w8, #5, #0x66787d4
00667877C  ldr      x22, [x19, #0x330]
006678780  b        #0x66787e4 ; 
006678784  ldr      x8, [x1, #0x60]
006678788  mov      x0, x19
00667878C  blr      x8
006678790  mov      x22, x0
006678794  cbz      x22, #0x6679680
006678798  adrp     x23, #0x9594000
00667879C  ldrb     w8, [x23, #0x277]
0066787A0  cbnz     w8, #0x66787b8
0066787A4  adrp     x0, #0x8ee9000
0066787A8  ldr      x0, [x0, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
0066787AC  bl       #0x382bd14 ; 
0066787B0  mov      w8, #1
0066787B4  strb     w8, [x23, #0x277]
0066787B8  adrp     x8, #0x8ee9000
0066787BC  ldr      x8, [x8, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
0066787C0  ldr      x1, [x8]
0066787C4  ldrb     w8, [x1, #0x53]
0066787C8  tbnz     w8, #5, #0x6678818
0066787CC  ldr      x0, [x22, #0x100]
0066787D0  b        #0x6678824 ; 
0066787D4  ldr      x8, [x1, #0x60]
0066787D8  mov      x0, x19
0066787DC  blr      x8
0066787E0  mov      x22, x0
0066787E4  cbz      x22, #0x6679680
0066787E8  ldrb     w8, [x28, #0x276]
0066787EC  cbnz     w8, #0x6678804
0066787F0  adrp     x0, #0x8ee9000
0066787F4  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
0066787F8  bl       #0x382bd14 ; 
0066787FC  mov      w8, #1
006678800  strb     w8, [x28, #0x276]
006678804  ldr      x1, [x29]
006678808  ldrb     w8, [x1, #0x53]
00667880C  tbnz     w8, #5, #0x667885c
006678810  ldr      x0, [x22, #0xe8]
006678814  b        #0x6678868 ; 
006678818  ldr      x8, [x1, #0x60]
00667881C  mov      x0, x22
006678820  blr      x8
006678824  cbz      x0, #0x6679680
006678828  ldrb     w8, [x26, #0xa81]
00667882C  ldr      x24, [x0, #0x18]
006678830  cbnz     w8, #0x6678848
006678834  adrp     x0, #0x8ee6000
006678838  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
00667883C  bl       #0x382bd14 ; 
006678840  mov      w8, #1
006678844  strb     w8, [x26, #0xa81]
006678848  ldr      x1, [x27]
00667884C  ldrb     w8, [x1, #0x53]
006678850  tbnz     w8, #5, #0x6678958
006678854  ldr      x22, [x19, #0x330]
006678858  b        #0x6678968 ; 
00667885C  ldr      x8, [x1, #0x60]
006678860  mov      x0, x22
006678864  blr      x8
006678868  adrp     x28, #0x9599000
00667886C  cbz      x0, #0x6679680
006678870  ldr      w8, [x0, #0x18]
006678874  cmp      w8, #1
006678878  b.ls     #0x6679684
00667887C  ldrb     w8, [x23, #0x474]
006678880  ldr      x22, [x0, #0x28]
006678884  cbnz     w8, #0x667889c
006678888  adrp     x0, #0x8ee8000
00667888C  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
006678890  bl       #0x382bd14 ; 
006678894  mov      w8, #1
006678898  strb     w8, [x23, #0x474]
00667889C  ldr      x1, [x24]
0066788A0  b        #0x6678a14 ; 
0066788A4  ldr      x8, [x1, #0x60]
0066788A8  mov      x0, x19
0066788AC  blr      x8
0066788B0  mov      x1, x0
0066788B4  mov      x0, x19
0066788B8  bl       #0x6679a50 ; HotFix.BattleLogic.BulletData$$CreateCircleShape
0066788BC  ldrb     w8, [x26, #0xa81]
0066788C0  cbnz     w8, #0x66788d8
0066788C4  adrp     x0, #0x8ee6000
0066788C8  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
0066788CC  bl       #0x382bd14 ; 
0066788D0  mov      w8, #1
0066788D4  strb     w8, [x26, #0xa81]
0066788D8  ldr      x1, [x27]
0066788DC  ldrb     w8, [x1, #0x53]
0066788E0  tbnz     w8, #5, #0x667899c
0066788E4  ldr      x22, [x19, #0x330]
0066788E8  b        #0x66789ac ; 
0066788EC  ldr      x8, [x2, #0x60]
0066788F0  ldp      q0, q1, [sp, #0xe0]
0066788F4  ldp      q2, q3, [sp, #0x100]
0066788F8  add      x1, sp, #0x1c0
0066788FC  mov      x0, x19
006678900  stp      q0, q1, [sp, #0x1c0]
006678904  stp      q2, q3, [sp, #0x1e0]
006678908  blr      x8
00667890C  adrp     x22, #0x9592000
006678910  ldrb     w8, [x22, #0x46a]
006678914  cbnz     w8, #0x667892c
006678918  adrp     x0, #0x8ee8000
00667891C  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
006678920  bl       #0x382bd14 ; 
006678924  mov      w8, #1
006678928  strb     w8, [x22, #0x46a]
00667892C  adrp     x8, #0x8ee8000
006678930  ldr      x8, [x8, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
006678934  ldr      x1, [x8]
006678938  ldrb     w8, [x1, #0x53]
00667893C  tbnz     w8, #5, #0x66789e0
006678940  add      x8, x19, #0x1c8
006678944  ldp      q1, q0, [x8, #0x20]
006678948  ldp      q3, q2, [x8]
00667894C  stp      q1, q0, [sp, #0x1e0]
006678950  stp      q3, q2, [sp, #0x1c0]
006678954  b        #0x66789f0 ; 
006678958  ldr      x8, [x1, #0x60]
00667895C  mov      x0, x19
006678960  blr      x8
006678964  mov      x22, x0
006678968  cbz      x22, #0x6679680
00667896C  ldrb     w8, [x28, #0x276]
006678970  cbnz     w8, #0x6678988
006678974  adrp     x0, #0x8ee9000
006678978  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
00667897C  bl       #0x382bd14 ; 
006678980  mov      w8, #1
006678984  strb     w8, [x28, #0x276]
006678988  ldr      x1, [x29]
00667898C  ldrb     w8, [x1, #0x53]
006678990  tbnz     w8, #5, #0x6678dd0
006678994  ldr      x0, [x22, #0xe8]
006678998  b        #0x6678ddc ; 
00667899C  ldr      x8, [x1, #0x60]
0066789A0  mov      x0, x19
0066789A4  blr      x8
0066789A8  mov      x22, x0
0066789AC  cbz      x22, #0x6679680
0066789B0  ldrb     w8, [x28, #0x276]
0066789B4  cbnz     w8, #0x66789cc
0066789B8  adrp     x0, #0x8ee9000
0066789BC  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
0066789C0  bl       #0x382bd14 ; 
0066789C4  mov      w8, #1
0066789C8  strb     w8, [x28, #0x276]
0066789CC  ldr      x1, [x29]
0066789D0  ldrb     w8, [x1, #0x53]
0066789D4  tbnz     w8, #5, #0x6678e1c
0066789D8  ldr      x0, [x22, #0xe8]
0066789DC  b        #0x6678e28 ; 
0066789E0  ldr      x9, [x1, #0x60]
0066789E4  add      x8, sp, #0x1c0
0066789E8  mov      x0, x19
0066789EC  blr      x9
0066789F0  ldrb     w8, [x24, #0x474]
0066789F4  ldr      x22, [sp, #0x1e0]
0066789F8  cbnz     w8, #0x6678a10
0066789FC  adrp     x0, #0x8ee8000
006678A00  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
006678A04  bl       #0x382bd14 ; 
006678A08  mov      w8, #1
006678A0C  strb     w8, [x24, #0x474]
006678A10  ldr      x1, [x23]
006678A14  ldrb     w8, [x1, #0x53]
006678A18  tbnz     w8, #5, #0x6678a24
006678A1C  ldr      x0, [x19, #0x148]
006678A20  b        #0x6678a30 ; 
006678A24  ldr      x8, [x1, #0x60]
006678A28  mov      x0, x19
006678A2C  blr      x8
006678A30  ldrb     w8, [x28, #0xef5]
006678A34  adrp     x23, #0x9599000
006678A38  mul      x22, x0, x22
006678A3C  cbnz     w8, #0x6678a54
006678A40  adrp     x0, #0x8f0f000
006678A44  ldr      x0, [x0, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius()
006678A48  bl       #0x382bd14 ; 
006678A4C  mov      w8, #1
006678A50  strb     w8, [x28, #0xef5]
006678A54  adrp     x8, #0x8f0f000
006678A58  ldr      x8, [x8, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius()
006678A5C  asr      x22, x22, #0x10
006678A60  ldr      x2, [x8]
006678A64  ldrb     w8, [x2, #0x53]
006678A68  tbnz     w8, #5, #0x6678a74
006678A6C  str      x22, [x19, #0x3f8]
006678A70  b        #0x6678a84 ; 
006678A74  ldr      x8, [x2, #0x60]
006678A78  mov      x0, x19
006678A7C  mov      x1, x22
006678A80  blr      x8
006678A84  ldrb     w8, [x23, #0xef6]
006678A88  cbnz     w8, #0x6678aa0
006678A8C  adrp     x0, #0x8f0f000
006678A90  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius2()
006678A94  bl       #0x382bd14 ; 
006678A98  mov      w8, #1
006678A9C  strb     w8, [x23, #0xef6]
006678AA0  adrp     x8, #0x8f0f000
006678AA4  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius2()
006678AA8  ldr      x2, [x8]
006678AAC  ldrb     w8, [x2, #0x53]
006678AB0  tbnz     w8, #5, #0x6678abc
006678AB4  str      x22, [x19, #0x400]
006678AB8  b        #0x6678acc ; 
006678ABC  ldr      x8, [x2, #0x60]
006678AC0  mov      x0, x19
006678AC4  mov      x1, x22
006678AC8  blr      x8
006678ACC  ldrb     w8, [x26, #0xa81]
006678AD0  cbnz     w8, #0x6678ae8
006678AD4  adrp     x0, #0x8ee6000
006678AD8  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678ADC  bl       #0x382bd14 ; 
006678AE0  mov      w8, #1
006678AE4  strb     w8, [x26, #0xa81]
006678AE8  ldr      x1, [x27]
006678AEC  ldrb     w8, [x1, #0x53]
006678AF0  tbnz     w8, #5, #0x6678afc
006678AF4  ldr      x22, [x19, #0x330]
006678AF8  b        #0x6678b0c ; 
006678AFC  ldr      x8, [x1, #0x60]
006678B00  mov      x0, x19
006678B04  blr      x8
006678B08  mov      x22, x0
006678B0C  cbz      x22, #0x6679680
006678B10  adrp     x23, #0x9599000
006678B14  ldrb     w8, [x23, #0xef9]
006678B18  cbnz     w8, #0x6678b30
006678B1C  adrp     x0, #0x8f0f000
006678B20  ldr      x0, [x0, #0xbd8] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingShape()
006678B24  bl       #0x382bd14 ; 
006678B28  mov      w8, #1
006678B2C  strb     w8, [x23, #0xef9]
006678B30  adrp     x24, #0x8f0f000
006678B34  ldr      x24, [x24, #0xbd8] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingShape()
006678B38  ldr      x1, [x24]
006678B3C  ldrb     w8, [x1, #0x53]
006678B40  tbnz     w8, #5, #0x6678b4c
006678B44  ldr      x0, [x22, #0x118]
006678B48  b        #0x6678b58 ; 
006678B4C  ldr      x8, [x1, #0x60]
006678B50  mov      x0, x22
006678B54  blr      x8
006678B58  cbz      x0, #0x6679680
006678B5C  ldrb     w8, [x26, #0xa81]
006678B60  ldr      w28, [x0, #0x18]
006678B64  cbnz     w8, #0x6678b7c
006678B68  adrp     x0, #0x8ee6000
006678B6C  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678B70  bl       #0x382bd14 ; 
006678B74  mov      w8, #1
006678B78  strb     w8, [x26, #0xa81]
006678B7C  ldr      x1, [x27]
006678B80  ldrb     w8, [x1, #0x53]
006678B84  tbnz     w8, #5, #0x6678b90
006678B88  ldr      x22, [x19, #0x330]
006678B8C  b        #0x6678ba0 ; 
006678B90  ldr      x8, [x1, #0x60]
006678B94  mov      x0, x19
006678B98  blr      x8
006678B9C  mov      x22, x0
006678BA0  cbz      x22, #0x6679680
006678BA4  ldrb     w8, [x23, #0xef9]
006678BA8  cbnz     w8, #0x6678bc0
006678BAC  adrp     x0, #0x8f0f000
006678BB0  ldr      x0, [x0, #0xbd8] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingShape()
006678BB4  bl       #0x382bd14 ; 
006678BB8  mov      w8, #1
006678BBC  strb     w8, [x23, #0xef9]
006678BC0  ldr      x1, [x24]
006678BC4  ldrb     w8, [x1, #0x53]
006678BC8  tbnz     w8, #5, #0x6678bd4
006678BCC  ldr      x0, [x22, #0x118]
006678BD0  b        #0x6678be0 ; 
006678BD4  ldr      x8, [x1, #0x60]
006678BD8  mov      x0, x22
006678BDC  blr      x8
006678BE0  cbz      x0, #0x6679680
006678BE4  ldr      w8, [x0, #0x18]
006678BE8  cmp      w28, #2
006678BEC  b.ne     #0x6678c28
006678BF0  cbz      w8, #0x6679684
006678BF4  ldrb     w8, [x26, #0xa81]
006678BF8  ldr      x28, [x0, #0x20]
006678BFC  cbnz     w8, #0x6678c14
006678C00  adrp     x0, #0x8ee6000
006678C04  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678C08  bl       #0x382bd14 ; 
006678C0C  mov      w8, #1
006678C10  strb     w8, [x26, #0xa81]
006678C14  ldr      x1, [x27]
006678C18  ldrb     w8, [x1, #0x53]
006678C1C  tbnz     w8, #5, #0x6678cc8
006678C20  ldr      x22, [x19, #0x330]
006678C24  b        #0x6678cd8 ; 
006678C28  cmp      w8, #1
006678C2C  b.ne     #0x6678c60
006678C30  ldrb     w8, [x26, #0xa81]
006678C34  cbnz     w8, #0x6678c4c
006678C38  adrp     x0, #0x8ee6000
006678C3C  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678C40  bl       #0x382bd14 ; 
006678C44  mov      w8, #1
006678C48  strb     w8, [x26, #0xa81]
006678C4C  ldr      x1, [x27]
006678C50  ldrb     w8, [x1, #0x53]
006678C54  tbnz     w8, #5, #0x6678f18
006678C58  ldr      x22, [x19, #0x330]
006678C5C  b        #0x6678f28 ; 
006678C60  add      x8, sp, #0x1c0
006678C64  mov      x0, xzr
006678C68  mov      x1, xzr
006678C6C  mov      x2, xzr
006678C70  mov      x3, xzr
006678C74  bl       #0x7e29220 ; Quantum.Shape2D$$CreateCircle
006678C78  adrp     x22, #0x9599000
006678C7C  ldp      q0, q1, [sp, #0x1c0]
006678C80  ldp      q2, q3, [sp, #0x1e0]
006678C84  ldrb     w8, [x22, #0xefa]
006678C88  stp      q0, q1, [sp, #0x20]
006678C8C  stp      q2, q3, [sp, #0x40]
006678C90  cbnz     w8, #0x6678ca8
006678C94  adrp     x0, #0x8f0f000
006678C98  ldr      x0, [x0, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingShape()
006678C9C  bl       #0x382bd14 ; 
006678CA0  mov      w8, #1
006678CA4  strb     w8, [x22, #0xefa]
006678CA8  adrp     x8, #0x8f0f000
006678CAC  ldr      x8, [x8, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingShape()
006678CB0  ldr      x2, [x8]
006678CB4  ldrb     w8, [x2, #0x53]
006678CB8  tbnz     w8, #5, #0x6678f5c
006678CBC  ldp      q0, q1, [sp, #0x40]
006678CC0  ldp      q2, q3, [sp, #0x20]
006678CC4  b        #0x6679038 ; 
006678CC8  ldr      x8, [x1, #0x60]
006678CCC  mov      x0, x19
006678CD0  blr      x8
006678CD4  mov      x22, x0
006678CD8  cbz      x22, #0x6679680
006678CDC  ldrb     w8, [x23, #0xef9]
006678CE0  cbnz     w8, #0x6678cf8
006678CE4  adrp     x0, #0x8f0f000
006678CE8  ldr      x0, [x0, #0xbd8] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingShape()
006678CEC  bl       #0x382bd14 ; 
006678CF0  mov      w8, #1
006678CF4  strb     w8, [x23, #0xef9]
006678CF8  ldr      x1, [x24]
006678CFC  ldrb     w8, [x1, #0x53]
006678D00  tbnz     w8, #5, #0x6678d0c
006678D04  ldr      x0, [x22, #0x118]
006678D08  b        #0x6678d18 ; 
006678D0C  ldr      x8, [x1, #0x60]
006678D10  mov      x0, x22
006678D14  blr      x8
006678D18  cbz      x0, #0x6679680
006678D1C  ldr      w8, [x0, #0x18]
006678D20  cmp      w8, #1
006678D24  b.ls     #0x6679684
006678D28  ldr      x9, [sp, #0x18]
006678D2C  ldr      x8, [x0, #0x28]
006678D30  add      x0, sp, #0x170
006678D34  mov      x3, xzr
006678D38  mul      x9, x28, x9
006678D3C  asr      x1, x9, #0x10
006678D40  ldr      x9, [sp, #0x10]
006678D44  stp      xzr, xzr, [sp, #0x170]
006678D48  mul      x8, x8, x9
006678D4C  asr      x2, x8, #0x10
006678D50  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
006678D54  ldp      x0, x1, [sp, #0x170]
006678D58  add      x8, sp, #0x1c0
006678D5C  mov      x2, xzr
006678D60  mov      x3, xzr
006678D64  mov      x4, xzr
006678D68  mov      x5, xzr
006678D6C  bl       #0x7e292c4 ; Quantum.Shape2D$$CreateBox
006678D70  adrp     x22, #0x9599000
006678D74  ldp      q0, q1, [sp, #0x1c0]
006678D78  ldp      q2, q3, [sp, #0x1e0]
006678D7C  ldrb     w8, [x22, #0xefa]
006678D80  stp      q0, q1, [sp, #0xa0]
006678D84  stp      q2, q3, [sp, #0xc0]
006678D88  cbnz     w8, #0x6678da0
006678D8C  adrp     x0, #0x8f0f000
006678D90  ldr      x0, [x0, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingShape()
006678D94  bl       #0x382bd14 ; 
006678D98  mov      w8, #1
006678D9C  strb     w8, [x22, #0xefa]
006678DA0  adrp     x8, #0x8f0f000
006678DA4  ldr      x8, [x8, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingShape()
006678DA8  ldr      x2, [x8]
006678DAC  ldrb     w8, [x2, #0x53]
006678DB0  tbnz     w8, #5, #0x6678dc0
006678DB4  ldp      q0, q1, [sp, #0xc0]
006678DB8  ldp      q2, q3, [sp, #0xa0]
006678DBC  b        #0x6679038 ; 
006678DC0  ldr      x8, [x2, #0x60]
006678DC4  ldp      q0, q1, [sp, #0xa0]
006678DC8  ldp      q2, q3, [sp, #0xc0]
006678DCC  b        #0x6679054 ; 
006678DD0  ldr      x8, [x1, #0x60]
006678DD4  mov      x0, x22
006678DD8  blr      x8
006678DDC  cbz      x0, #0x6679680
006678DE0  ldr      w8, [x0, #0x18]
006678DE4  cbz      w8, #0x6679684
006678DE8  ldrb     w8, [x26, #0xa81]
006678DEC  ldr      x23, [x0, #0x20]
006678DF0  cbnz     w8, #0x6678e08
006678DF4  adrp     x0, #0x8ee6000
006678DF8  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678DFC  bl       #0x382bd14 ; 
006678E00  mov      w8, #1
006678E04  strb     w8, [x26, #0xa81]
006678E08  ldr      x1, [x27]
006678E0C  ldrb     w8, [x1, #0x53]
006678E10  tbnz     w8, #5, #0x6678e48
006678E14  ldr      x22, [x19, #0x330]
006678E18  b        #0x6678e58 ; 
006678E1C  ldr      x8, [x1, #0x60]
006678E20  mov      x0, x22
006678E24  blr      x8
006678E28  adrp     x28, #0x9599000
006678E2C  cbz      x0, #0x6679680
006678E30  ldr      w8, [x0, #0x18]
006678E34  cbz      w8, #0x6679684
006678E38  ldrb     w8, [x24, #0x474]
006678E3C  ldr      x22, [x0, #0x20]
006678E40  cbnz     w8, #0x6678a10
006678E44  b        #0x66789fc ; 
006678E48  ldr      x8, [x1, #0x60]
006678E4C  mov      x0, x19
006678E50  blr      x8
006678E54  mov      x22, x0
006678E58  cbz      x22, #0x6679680
006678E5C  ldrb     w8, [x28, #0x276]
006678E60  cbnz     w8, #0x6678e78
006678E64  adrp     x0, #0x8ee9000
006678E68  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
006678E6C  bl       #0x382bd14 ; 
006678E70  mov      w8, #1
006678E74  strb     w8, [x28, #0x276]
006678E78  ldr      x1, [x29]
006678E7C  ldrb     w8, [x1, #0x53]
006678E80  tbnz     w8, #5, #0x6678e8c
006678E84  ldr      x0, [x22, #0xe8]
006678E88  b        #0x6678e98 ; 
006678E8C  ldr      x8, [x1, #0x60]
006678E90  mov      x0, x22
006678E94  blr      x8
006678E98  adrp     x29, #0x8ee9000
006678E9C  ldr      x29, [x29, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
006678EA0  adrp     x28, #0x9599000
006678EA4  cbz      x0, #0x6679680
006678EA8  ldr      w8, [x0, #0x18]
006678EAC  cmp      w8, #1
006678EB0  b.ls     #0x6679684
006678EB4  ldr      x9, [sp, #0x18]
006678EB8  ldr      x8, [x0, #0x28]
006678EBC  mul      x9, x23, x9
006678EC0  asr      x1, x9, #0x10
006678EC4  ldr      x9, [sp, #0x10]
006678EC8  mul      x8, x8, x9
006678ECC  asr      x2, x8, #0x10
006678ED0  cbz      x24, #0x66793b0
006678ED4  add      x0, sp, #0x170
006678ED8  mov      x3, xzr
006678EDC  stp      xzr, xzr, [sp, #0x170]
006678EE0  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
006678EE4  ldrb     w8, [x26, #0xa81]
006678EE8  cbnz     w8, #0x6678f00
006678EEC  adrp     x0, #0x8ee6000
006678EF0  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006678EF4  bl       #0x382bd14 ; 
006678EF8  mov      w8, #1
006678EFC  strb     w8, [x26, #0xa81]
006678F00  ldr      x1, [x27]
006678F04  adrp     x24, #0x9594000
006678F08  ldrb     w8, [x1, #0x53]
006678F0C  tbnz     w8, #5, #0x66793d4
006678F10  ldr      x22, [x19, #0x330]
006678F14  b        #0x66793e4 ; 
006678F18  ldr      x8, [x1, #0x60]
006678F1C  mov      x0, x19
006678F20  blr      x8
006678F24  mov      x22, x0
006678F28  cbz      x22, #0x6679680
006678F2C  ldrb     w8, [x23, #0xef9]
006678F30  cbnz     w8, #0x6678f48
006678F34  adrp     x0, #0x8f0f000
006678F38  ldr      x0, [x0, #0xbd8] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingShape()
006678F3C  bl       #0x382bd14 ; 
006678F40  mov      w8, #1
006678F44  strb     w8, [x23, #0xef9]
006678F48  ldr      x1, [x24]
006678F4C  ldrb     w8, [x1, #0x53]
006678F50  tbnz     w8, #5, #0x6678f6c
006678F54  ldr      x0, [x22, #0x118]
006678F58  b        #0x6678f78 ; 
006678F5C  ldr      x8, [x2, #0x60]
006678F60  ldp      q0, q1, [sp, #0x20]
006678F64  ldp      q2, q3, [sp, #0x40]
006678F68  b        #0x6679054 ; 
006678F6C  ldr      x8, [x1, #0x60]
006678F70  mov      x0, x22
006678F74  blr      x8
006678F78  cbz      x0, #0x6679680
006678F7C  ldr      w8, [x0, #0x18]
006678F80  cbz      w8, #0x6679684
006678F84  adrp     x23, #0x9592000
006678F88  ldrb     w8, [x23, #0x474]
006678F8C  ldr      x22, [x0, #0x20]
006678F90  cbnz     w8, #0x6678fa8
006678F94  adrp     x0, #0x8ee8000
006678F98  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
006678F9C  bl       #0x382bd14 ; 
006678FA0  mov      w8, #1
006678FA4  strb     w8, [x23, #0x474]
006678FA8  adrp     x8, #0x8ee8000
006678FAC  ldr      x8, [x8, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
006678FB0  ldr      x1, [x8]
006678FB4  ldrb     w8, [x1, #0x53]
006678FB8  tbnz     w8, #5, #0x6678fc4
006678FBC  ldr      x0, [x19, #0x148]
006678FC0  b        #0x6678fd0 ; 
006678FC4  ldr      x8, [x1, #0x60]
006678FC8  mov      x0, x19
006678FCC  blr      x8
006678FD0  mul      x8, x0, x22
006678FD4  asr      x0, x8, #0x10
006678FD8  add      x8, sp, #0x1c0
006678FDC  mov      x1, xzr
006678FE0  mov      x2, xzr
006678FE4  mov      x3, xzr
006678FE8  bl       #0x7e29220 ; Quantum.Shape2D$$CreateCircle
006678FEC  adrp     x22, #0x9599000
006678FF0  ldp      q0, q1, [sp, #0x1c0]
006678FF4  ldp      q2, q3, [sp, #0x1e0]
006678FF8  ldrb     w8, [x22, #0xefa]
006678FFC  stp      q0, q1, [sp, #0x60]
006679000  stp      q2, q3, [sp, #0x80]
006679004  cbnz     w8, #0x667901c
006679008  adrp     x0, #0x8f0f000
00667900C  ldr      x0, [x0, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingShape()
006679010  bl       #0x382bd14 ; 
006679014  mov      w8, #1
006679018  strb     w8, [x22, #0xefa]
00667901C  adrp     x8, #0x8f0f000
006679020  ldr      x8, [x8, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingShape()
006679024  ldr      x2, [x8]
006679028  ldrb     w8, [x2, #0x53]
00667902C  tbnz     w8, #5, #0x6679048
006679030  ldp      q0, q1, [sp, #0x80]
006679034  ldp      q2, q3, [sp, #0x60]
006679038  add      x8, x19, #0x208
00667903C  stp      q0, q1, [x8, #0x20]
006679040  stp      q2, q3, [x8]
006679044  b        #0x6679068 ; 
006679048  ldr      x8, [x2, #0x60]
00667904C  ldp      q0, q1, [sp, #0x60]
006679050  ldp      q2, q3, [sp, #0x80]
006679054  add      x1, sp, #0x1c0
006679058  mov      x0, x19
00667905C  stp      q0, q1, [sp, #0x1c0]
006679060  stp      q2, q3, [sp, #0x1e0]
006679064  blr      x8
006679068  ldrb     w8, [x26, #0xa81]
00667906C  cbnz     w8, #0x6679084
006679070  adrp     x0, #0x8ee6000
006679074  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679078  bl       #0x382bd14 ; 
00667907C  mov      w8, #1
006679080  strb     w8, [x26, #0xa81]
006679084  ldr      x1, [x27]
006679088  ldrb     w8, [x1, #0x53]
00667908C  tbnz     w8, #5, #0x6679098
006679090  ldr      x22, [x19, #0x330]
006679094  b        #0x66790a8 ; 
006679098  ldr      x8, [x1, #0x60]
00667909C  mov      x0, x19
0066790A0  blr      x8
0066790A4  mov      x22, x0
0066790A8  cbz      x22, #0x6679680
0066790AC  adrp     x23, #0x9599000
0066790B0  ldrb     w8, [x23, #0xefb]
0066790B4  cbnz     w8, #0x66790cc
0066790B8  adrp     x0, #0x8f0f000
0066790BC  ldr      x0, [x0, #0xbe0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingCoordinate()
0066790C0  bl       #0x382bd14 ; 
0066790C4  mov      w8, #1
0066790C8  strb     w8, [x23, #0xefb]
0066790CC  adrp     x24, #0x8f0f000
0066790D0  ldr      x24, [x24, #0xbe0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingCoordinate()
0066790D4  ldr      x1, [x24]
0066790D8  ldrb     w8, [x1, #0x53]
0066790DC  tbnz     w8, #5, #0x66790e8
0066790E0  ldr      x0, [x22, #0x120]
0066790E4  b        #0x66790f4 ; 
0066790E8  ldr      x8, [x1, #0x60]
0066790EC  mov      x0, x22
0066790F0  blr      x8
0066790F4  cbz      x0, #0x6679680
0066790F8  ldr      w8, [x0, #0x18]
0066790FC  cmp      w8, #3
006679100  b.lt     #0x6679380
006679104  ldrb     w8, [x26, #0xa81]
006679108  cbnz     w8, #0x6679120
00667910C  adrp     x0, #0x8ee6000
006679110  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679114  bl       #0x382bd14 ; 
006679118  mov      w8, #1
00667911C  strb     w8, [x26, #0xa81]
006679120  ldr      x1, [x27]
006679124  ldrb     w8, [x1, #0x53]
006679128  tbnz     w8, #5, #0x6679134
00667912C  ldr      x22, [x19, #0x330]
006679130  b        #0x6679144 ; 
006679134  ldr      x8, [x1, #0x60]
006679138  mov      x0, x19
00667913C  blr      x8
006679140  mov      x22, x0
006679144  cbz      x22, #0x6679680
006679148  ldrb     w8, [x23, #0xefb]
00667914C  cbnz     w8, #0x6679164
006679150  adrp     x0, #0x8f0f000
006679154  ldr      x0, [x0, #0xbe0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingCoordinate()
006679158  bl       #0x382bd14 ; 
00667915C  mov      w8, #1
006679160  strb     w8, [x23, #0xefb]
006679164  ldr      x1, [x24]
006679168  ldrb     w8, [x1, #0x53]
00667916C  tbnz     w8, #5, #0x6679178
006679170  ldr      x0, [x22, #0x120]
006679174  b        #0x6679184 ; 
006679178  ldr      x8, [x1, #0x60]
00667917C  mov      x0, x22
006679180  blr      x8
006679184  cbz      x0, #0x6679680
006679188  ldr      w8, [x0, #0x18]
00667918C  cbz      w8, #0x6679684
006679190  ldrb     w8, [x26, #0xa81]
006679194  ldr      x28, [x0, #0x20]
006679198  cbnz     w8, #0x66791b0
00667919C  adrp     x0, #0x8ee6000
0066791A0  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
0066791A4  bl       #0x382bd14 ; 
0066791A8  mov      w8, #1
0066791AC  strb     w8, [x26, #0xa81]
0066791B0  ldr      x1, [x27]
0066791B4  ldrb     w8, [x1, #0x53]
0066791B8  tbnz     w8, #5, #0x66791c4
0066791BC  ldr      x22, [x19, #0x330]
0066791C0  b        #0x66791d4 ; 
0066791C4  ldr      x8, [x1, #0x60]
0066791C8  mov      x0, x19
0066791CC  blr      x8
0066791D0  mov      x22, x0
0066791D4  cbz      x22, #0x6679680
0066791D8  ldrb     w8, [x23, #0xefb]
0066791DC  cbnz     w8, #0x66791f4
0066791E0  adrp     x0, #0x8f0f000
0066791E4  ldr      x0, [x0, #0xbe0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingCoordinate()
0066791E8  bl       #0x382bd14 ; 
0066791EC  mov      w8, #1
0066791F0  strb     w8, [x23, #0xefb]
0066791F4  ldr      x1, [x24]
0066791F8  ldrb     w8, [x1, #0x53]
0066791FC  tbnz     w8, #5, #0x6679208
006679200  ldr      x0, [x22, #0x120]
006679204  b        #0x6679214 ; 
006679208  ldr      x8, [x1, #0x60]
00667920C  mov      x0, x22
006679210  blr      x8
006679214  cbz      x0, #0x6679680
006679218  ldr      w8, [x0, #0x18]
00667921C  cmp      w8, #1
006679220  b.ls     #0x6679684
006679224  ldr      x8, [x0, #0x28]
006679228  mul      x9, x28, x21
00667922C  asr      x1, x9, #0x10
006679230  add      x0, sp, #0x1c0
006679234  mul      x8, x8, x20
006679238  asr      x2, x8, #0x10
00667923C  mov      x3, xzr
006679240  stp      xzr, xzr, [sp, #0x1c0]
006679244  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
006679248  adrp     x22, #0x9599000
00667924C  ldrb     w8, [x22, #0xefc]
006679250  ldp      x21, x20, [sp, #0x1c0]
006679254  cbnz     w8, #0x667926c
006679258  adrp     x0, #0x8f0f000
00667925C  ldr      x0, [x0, #0xa68] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingPos()
006679260  bl       #0x382bd14 ; 
006679264  mov      w8, #1
006679268  strb     w8, [x22, #0xefc]
00667926C  adrp     x8, #0x8f0f000
006679270  ldr      x8, [x8, #0xa68] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingPos()
006679274  ldr      x3, [x8]
006679278  ldrb     w8, [x3, #0x53]
00667927C  tbnz     w8, #5, #0x667928c
006679280  str      x21, [x19, #0x248]
006679284  str      x20, [x19, #0x250]
006679288  b        #0x66792a0 ; 
00667928C  ldr      x8, [x3, #0x60]
006679290  mov      x0, x19
006679294  mov      x1, x21
006679298  mov      x2, x20
00667929C  blr      x8
0066792A0  ldrb     w8, [x26, #0xa81]
0066792A4  cbnz     w8, #0x66792bc
0066792A8  adrp     x0, #0x8ee6000
0066792AC  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
0066792B0  bl       #0x382bd14 ; 
0066792B4  mov      w8, #1
0066792B8  strb     w8, [x26, #0xa81]
0066792BC  ldr      x1, [x27]
0066792C0  ldrb     w8, [x1, #0x53]
0066792C4  tbnz     w8, #5, #0x66792d0
0066792C8  ldr      x20, [x19, #0x330]
0066792CC  b        #0x66792e0 ; 
0066792D0  ldr      x8, [x1, #0x60]
0066792D4  mov      x0, x19
0066792D8  blr      x8
0066792DC  mov      x20, x0
0066792E0  cbz      x20, #0x6679680
0066792E4  ldrb     w8, [x23, #0xefb]
0066792E8  cbnz     w8, #0x6679300
0066792EC  adrp     x0, #0x8f0f000
0066792F0  ldr      x0, [x0, #0xbe0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_WingCoordinate()
0066792F4  bl       #0x382bd14 ; 
0066792F8  mov      w8, #1
0066792FC  strb     w8, [x23, #0xefb]
006679300  ldr      x1, [x24]
006679304  ldrb     w8, [x1, #0x53]
006679308  tbnz     w8, #5, #0x6679314
00667930C  ldr      x0, [x20, #0x120]
006679310  b        #0x6679320 ; 
006679314  ldr      x8, [x1, #0x60]
006679318  mov      x0, x20
00667931C  blr      x8
006679320  cbz      x0, #0x6679680
006679324  ldr      w8, [x0, #0x18]
006679328  cmp      w8, #2
00667932C  b.ls     #0x6679684
006679330  adrp     x21, #0x9599000
006679334  ldrb     w8, [x21, #0xefd]
006679338  ldr      x20, [x0, #0x30]
00667933C  cbnz     w8, #0x6679354
006679340  adrp     x0, #0x8f0f000
006679344  ldr      x0, [x0, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingRotation()
006679348  bl       #0x382bd14 ; 
00667934C  mov      w8, #1
006679350  strb     w8, [x21, #0xefd]
006679354  adrp     x8, #0x8f0f000
006679358  ldr      x8, [x8, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WingRotation()
00667935C  ldr      x2, [x8]
006679360  ldrb     w8, [x2, #0x53]
006679364  tbnz     w8, #5, #0x6679370
006679368  str      x20, [x19, #0x258]
00667936C  b        #0x6679380 ; 
006679370  ldr      x8, [x2, #0x60]
006679374  mov      x0, x19
006679378  mov      x1, x20
00667937C  blr      x8
006679380  ldr      x8, [x25, #0x28]
006679384  ldr      x9, [sp, #0x208]
006679388  cmp      x8, x9
00667938C  b.ne     #0x6679688
006679390  add      sp, sp, #0x210
006679394  ldp      x20, x19, [sp, #0x50]
006679398  ldp      x22, x21, [sp, #0x40]
00667939C  ldp      x24, x23, [sp, #0x30]
0066793A0  ldp      x26, x25, [sp, #0x20]
0066793A4  ldp      x28, x27, [sp, #0x10]
0066793A8  ldp      x29, x30, [sp], #0x60
0066793AC  ret      
0066793B0  add      x0, sp, #0x170
0066793B4  mov      x3, xzr
0066793B8  stp      xzr, xzr, [sp, #0x170]
0066793BC  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
0066793C0  ldp      x0, x1, [sp, #0x170]
0066793C4  add      x8, sp, #0x1c0
0066793C8  mov      x2, xzr
0066793CC  mov      x3, xzr
0066793D0  b        #0x66794fc ; 
0066793D4  ldr      x8, [x1, #0x60]
0066793D8  mov      x0, x19
0066793DC  blr      x8
0066793E0  mov      x22, x0
0066793E4  cbz      x22, #0x6679680
0066793E8  ldrb     w8, [x24, #0x277]
0066793EC  cbnz     w8, #0x6679404
0066793F0  adrp     x0, #0x8ee9000
0066793F4  ldr      x0, [x0, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
0066793F8  bl       #0x382bd14 ; 
0066793FC  mov      w8, #1
006679400  strb     w8, [x24, #0x277]
006679404  ldr      x1, [x29]
006679408  ldrb     w8, [x1, #0x53]
00667940C  tbnz     w8, #5, #0x6679418
006679410  ldr      x0, [x22, #0x100]
006679414  b        #0x6679424 ; 
006679418  ldr      x8, [x1, #0x60]
00667941C  mov      x0, x22
006679420  blr      x8
006679424  cbz      x0, #0x6679680
006679428  ldr      w8, [x0, #0x18]
00667942C  cbz      w8, #0x6679684
006679430  ldrb     w8, [x26, #0xa81]
006679434  ldr      x23, [x0, #0x20]
006679438  cbnz     w8, #0x6679450
00667943C  adrp     x0, #0x8ee6000
006679440  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679444  bl       #0x382bd14 ; 
006679448  mov      w8, #1
00667944C  strb     w8, [x26, #0xa81]
006679450  ldr      x1, [x27]
006679454  ldrb     w8, [x1, #0x53]
006679458  tbnz     w8, #5, #0x6679464
00667945C  ldr      x22, [x19, #0x330]
006679460  b        #0x6679474 ; 
006679464  ldr      x8, [x1, #0x60]
006679468  mov      x0, x19
00667946C  blr      x8
006679470  mov      x22, x0
006679474  cbz      x22, #0x6679680
006679478  ldrb     w8, [x24, #0x277]
00667947C  cbnz     w8, #0x6679494
006679480  adrp     x0, #0x8ee9000
006679484  ldr      x0, [x0, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
006679488  bl       #0x382bd14 ; 
00667948C  mov      w8, #1
006679490  strb     w8, [x24, #0x277]
006679494  ldr      x1, [x29]
006679498  ldrb     w8, [x1, #0x53]
00667949C  tbnz     w8, #5, #0x66794a8
0066794A0  ldr      x0, [x22, #0x100]
0066794A4  b        #0x66794b4 ; 
0066794A8  ldr      x8, [x1, #0x60]
0066794AC  mov      x0, x22
0066794B0  blr      x8
0066794B4  cbz      x0, #0x6679680
0066794B8  ldr      w8, [x0, #0x18]
0066794BC  cmp      w8, #1
0066794C0  b.ls     #0x6679684
0066794C4  ldr      x9, [sp, #0x18]
0066794C8  ldr      x8, [x0, #0x28]
0066794CC  add      x0, sp, #0x160
0066794D0  mov      x3, xzr
0066794D4  mul      x9, x23, x9
0066794D8  asr      x1, x9, #0x10
0066794DC  ldr      x9, [sp, #0x10]
0066794E0  stp      xzr, xzr, [sp, #0x160]
0066794E4  mul      x8, x8, x9
0066794E8  asr      x2, x8, #0x10
0066794EC  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
0066794F0  ldp      x0, x1, [sp, #0x170]
0066794F4  ldp      x2, x3, [sp, #0x160]
0066794F8  add      x8, sp, #0x1c0
0066794FC  mov      x4, xzr
006679500  mov      x5, xzr
006679504  bl       #0x7e292c4 ; Quantum.Shape2D$$CreateBox
006679508  ldp      q0, q1, [sp, #0x1c0]
00667950C  ldp      q2, q3, [sp, #0x1e0]
006679510  stp      q0, q1, [sp, #0x180]
006679514  stp      q2, q3, [sp, #0x1a0]
006679518  cbz      x19, #0x6679680
00667951C  adrp     x22, #0x9599000
006679520  ldp      q0, q1, [sp, #0x180]
006679524  ldp      q2, q3, [sp, #0x1a0]
006679528  ldrb     w8, [x22, #0xed7]
00667952C  stp      q0, q1, [sp, #0x120]
006679530  stp      q2, q3, [sp, #0x140]
006679534  cbnz     w8, #0x667954c
006679538  adrp     x0, #0x8f0f000
00667953C  ldr      x0, [x0, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_Shape()
006679540  bl       #0x382bd14 ; 
006679544  mov      w8, #1
006679548  strb     w8, [x22, #0xed7]
00667954C  adrp     x8, #0x8f0f000
006679550  ldr      x8, [x8, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_Shape()
006679554  ldr      x2, [x8]
006679558  ldrb     w8, [x2, #0x53]
00667955C  tbnz     w8, #5, #0x6679578
006679560  ldp      q0, q1, [sp, #0x140]
006679564  ldp      q2, q3, [sp, #0x120]
006679568  add      x8, x19, #0x1c8
00667956C  stp      q0, q1, [x8, #0x20]
006679570  stp      q2, q3, [x8]
006679574  b        #0x6679598 ; 
006679578  ldr      x8, [x2, #0x60]
00667957C  ldp      q0, q1, [sp, #0x120]
006679580  ldp      q2, q3, [sp, #0x140]
006679584  add      x1, sp, #0x1c0
006679588  mov      x0, x19
00667958C  stp      q0, q1, [sp, #0x1c0]
006679590  stp      q2, q3, [sp, #0x1e0]
006679594  blr      x8
006679598  adrp     x22, #0x9592000
00667959C  ldrb     w8, [x22, #0x46a]
0066795A0  cbnz     w8, #0x66795b8
0066795A4  adrp     x0, #0x8ee8000
0066795A8  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
0066795AC  bl       #0x382bd14 ; 
0066795B0  mov      w8, #1
0066795B4  strb     w8, [x22, #0x46a]
0066795B8  adrp     x8, #0x8ee8000
0066795BC  ldr      x8, [x8, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
0066795C0  ldr      x1, [x8]
0066795C4  ldrb     w8, [x1, #0x53]
0066795C8  tbnz     w8, #5, #0x66795e4
0066795CC  add      x8, x19, #0x1c8
0066795D0  ldp      q1, q0, [x8, #0x20]
0066795D4  ldp      q3, q2, [x8]
0066795D8  stp      q1, q0, [sp, #0x1e0]
0066795DC  stp      q3, q2, [sp, #0x1c0]
0066795E0  b        #0x66795f4 ; 
0066795E4  ldr      x9, [x1, #0x60]
0066795E8  add      x8, sp, #0x1c0
0066795EC  mov      x0, x19
0066795F0  blr      x9
0066795F4  ldp      x22, x23, [sp, #0x1e8]
0066795F8  mov      x1, xzr
0066795FC  mul      x9, x23, x23
006679600  mul      x8, x22, x22
006679604  asr      x9, x9, #0x10
006679608  add      x0, x9, x8, asr #16
00667960C  bl       #0x7d472cc ; Photon.Deterministic.FPMath$$SqrtRaw
006679610  ldrb     w8, [x28, #0xef5]
006679614  mov      x24, x0
006679618  cbnz     w8, #0x6679630
00667961C  adrp     x0, #0x8f0f000
006679620  ldr      x0, [x0, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius()
006679624  bl       #0x382bd14 ; 
006679628  mov      w8, #1
00667962C  strb     w8, [x28, #0xef5]
006679630  adrp     x8, #0x8f0f000
006679634  ldr      x8, [x8, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExShapeRadius()
006679638  ldr      x2, [x8]
00667963C  ldrb     w8, [x2, #0x53]
006679640  tbnz     w8, #5, #0x667964c
006679644  str      x24, [x19, #0x3f8]
006679648  b        #0x667965c ; 
00667964C  ldr      x8, [x2, #0x60]
006679650  mov      x0, x19
006679654  mov      x1, x24
006679658  blr      x8
00667965C  mov      x0, x22
006679660  mov      x1, x23
006679664  mov      x2, xzr
006679668  bl       #0x7d46f8c ; Photon.Deterministic.FPMath$$Min
00667966C  adrp     x23, #0x9599000
006679670  ldrb     w8, [x23, #0xef6]
006679674  mov      x22, x0
006679678  cbnz     w8, #0x6678aa0
00667967C  b        #0x6678a8c ; 
006679680  bl       #0x382bfb8 ; 
006679684  bl       #0x382bfc0 ; 
006679688  bl       #0x89edb60 ; 

