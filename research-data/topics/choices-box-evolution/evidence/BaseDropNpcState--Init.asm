; HotFix.BattleLogic.BaseDropNpcState$$Init
; RVA 0x6598614; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006598614  stp      x30, x23, [sp, #-0x30]!
006598618  stp      x22, x21, [sp, #0x10]
00659861C  stp      x20, x19, [sp, #0x20]
006598620  adrp     x20, #0x9599000
006598624  adrp     x21, #0x8f08000
006598628  ldrb     w8, [x20, #0x2f0]
00659862C  ldr      x21, [x21, #0xc88] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.Init() @ 0x923b078
006598630  mov      x19, x0
006598634  tbnz     w8, #0, #0x6598664
006598638  adrp     x0, #0x8f08000
00659863C  ldr      x0, [x0, #0xc88] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.Init() @ 0x923b078
006598640  bl       #0x382bd14 ; 
006598644  adrp     x0, #0x8ee6000
006598648  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659864C  bl       #0x382bd14 ; 
006598650  adrp     x0, #0x8f08000
006598654  ldr      x0, [x0, #0xc90] ; GLOBAL InitSelectBoxRate% @ 0x93019c0
006598658  bl       #0x382bd14 ; 
00659865C  mov      w8, #1
006598660  strb     w8, [x20, #0x2f0]
006598664  ldr      x1, [x21]
006598668  ldrb     w8, [x1, #0x53]
00659866C  tbnz     w8, #5, #0x65986ac
006598670  adrp     x21, #0x9599000
006598674  ldrb     w8, [x21, #0x4b1]
006598678  cbnz     w8, #0x6598690
00659867C  adrp     x0, #0x8f08000
006598680  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006598684  bl       #0x382bd14 ; 
006598688  mov      w8, #1
00659868C  strb     w8, [x21, #0x4b1]
006598690  adrp     x22, #0x8f08000
006598694  ldr      x22, [x22, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006598698  ldr      x1, [x22]
00659869C  ldrb     w8, [x1, #0x53]
0065986A0  tbnz     w8, #5, #0x65986c4
0065986A4  ldr      x0, [x19, #0x10]
0065986A8  b        #0x65986d0 ; 
0065986AC  ldr      x2, [x1, #0x60]
0065986B0  mov      x0, x19
0065986B4  ldp      x20, x19, [sp, #0x20]
0065986B8  ldp      x22, x21, [sp, #0x10]
0065986BC  ldp      x30, x23, [sp], #0x30
0065986C0  br       x2
0065986C4  ldr      x8, [x1, #0x60]
0065986C8  mov      x0, x19
0065986CC  blr      x8
0065986D0  cbz      x0, #0x6598808
0065986D4  ldr      w8, [x0, #0x1c8]
0065986D8  cmp      w8, #2
0065986DC  b.ne     #0x65986f8
0065986E0  mov      w8, #1
0065986E4  strb     w8, [x19, #0x21]
0065986E8  ldp      x20, x19, [sp, #0x20]
0065986EC  ldp      x22, x21, [sp, #0x10]
0065986F0  ldp      x30, x23, [sp], #0x30
0065986F4  ret      
0065986F8  ldr      x0, [x19, #0x18]
0065986FC  strb     wzr, [x19, #0x21]
006598700  cbz      x0, #0x6598808
006598704  adrp     x8, #0x8ee6000
006598708  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659870C  ldr      x1, [x8]
006598710  ldrb     w8, [x1, #0x53]
006598714  tbnz     w8, #5, #0x6598720
006598718  ldr      x20, [x0, #0x38]
00659871C  b        #0x659872c ; 
006598720  ldr      x8, [x1, #0x60]
006598724  blr      x8
006598728  mov      x20, x0
00659872C  cbz      x20, #0x6598808
006598730  adrp     x23, #0x9591000
006598734  ldrb     w8, [x23, #0xa7f]
006598738  cbnz     w8, #0x6598750
00659873C  adrp     x0, #0x8ee6000
006598740  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006598744  bl       #0x382bd14 ; 
006598748  mov      w8, #1
00659874C  strb     w8, [x23, #0xa7f]
006598750  adrp     x8, #0x8ee6000
006598754  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006598758  ldr      x1, [x8]
00659875C  ldrb     w8, [x1, #0x53]
006598760  tbnz     w8, #5, #0x659876c
006598764  ldr      x0, [x20, #0x178]
006598768  b        #0x6598778 ; 
00659876C  ldr      x8, [x1, #0x60]
006598770  mov      x0, x20
006598774  blr      x8
006598778  cbz      x0, #0x6598808
00659877C  adrp     x8, #0x8f08000
006598780  ldr      x8, [x8, #0xc90] ; GLOBAL InitSelectBoxRate% @ 0x93019c0
006598784  mov      x2, xzr
006598788  ldr      x1, [x8]
00659878C  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
006598790  ldrb     w8, [x21, #0x4b1]
006598794  mov      x20, x0
006598798  cbnz     w8, #0x65987b0
00659879C  adrp     x0, #0x8f08000
0065987A0  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065987A4  bl       #0x382bd14 ; 
0065987A8  mov      w8, #1
0065987AC  strb     w8, [x21, #0x4b1]
0065987B0  ldr      x1, [x22]
0065987B4  ldrb     w8, [x1, #0x53]
0065987B8  tbnz     w8, #5, #0x65987c4
0065987BC  ldr      x0, [x19, #0x10]
0065987C0  b        #0x65987d0 ; 
0065987C4  ldr      x8, [x1, #0x60]
0065987C8  mov      x0, x19
0065987CC  blr      x8
0065987D0  cbz      x0, #0x6598808
0065987D4  mov      x1, x20
0065987D8  mov      x2, xzr
0065987DC  bl       #0x69ff0b0 ; HotFix.BattleLogic.BattleWorldContext$$RandomNextBool
0065987E0  and      w8, w0, #1
0065987E4  strb     w8, [x19, #0x22]
0065987E8  tbnz     w0, #0, #0x65987f4
0065987EC  mov      w8, #1
0065987F0  strb     w8, [x19, #0x21]
0065987F4  mov      x0, x19
0065987F8  ldp      x20, x19, [sp, #0x20]
0065987FC  ldp      x22, x21, [sp, #0x10]
006598800  ldp      x30, x23, [sp], #0x30
006598804  b        #0x65989a4 ; HotFix.BattleLogic.BaseDropNpcState$$TryShowNpc
006598808  bl       #0x382bfb8 ; 

