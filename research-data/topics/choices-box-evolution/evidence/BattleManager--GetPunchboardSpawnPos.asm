; HotFix.BattleLogic.BattleManager$$GetPunchboardSpawnPos
; RVA 0x6592534; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006592534  sub      sp, sp, #0x130
006592538  str      x29, [sp, #0xd0]
00659253C  stp      x30, x27, [sp, #0xe0]
006592540  stp      x26, x25, [sp, #0xf0]
006592544  stp      x24, x23, [sp, #0x100]
006592548  stp      x22, x21, [sp, #0x110]
00659254C  stp      x20, x19, [sp, #0x120]
006592550  mrs      x24, tpidr_el0
006592554  mov      x19, x8
006592558  ldr      x8, [x24, #0x28]
00659255C  adrp     x21, #0x9599000
006592560  adrp     x22, #0x8f08000
006592564  mov      x20, x0
006592568  str      x8, [sp, #0xc8]
00659256C  ldrb     w8, [x21, #0x24e]
006592570  ldr      x22, [x22, #0x8c8] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.GetPunchboardSpawnPos() @ 0x923cbb0
006592574  tbnz     w8, #0, #0x65925c8
006592578  adrp     x0, #0x8f08000
00659257C  ldr      x0, [x0, #0x8c8] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.GetPunchboardSpawnPos() @ 0x923cbb0
006592580  bl       #0x382bd14 ; 
006592584  adrp     x0, #0x8ee6000
006592588  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659258C  bl       #0x382bd14 ; 
006592590  adrp     x0, #0x8ee1000
006592594  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006592598  bl       #0x382bd14 ; 
00659259C  adrp     x0, #0x8f08000
0065925A0  ldr      x0, [x0, #0x8d0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\BattleManager.cs @ 0x92f7de8
0065925A4  bl       #0x382bd14 ; 
0065925A8  adrp     x0, #0x8f08000
0065925AC  ldr      x0, [x0, #0x8d8] ; GLOBAL GetPunchboardSpawnPos @ 0x92fed08
0065925B0  bl       #0x382bd14 ; 
0065925B4  adrp     x0, #0x8f08000
0065925B8  ldr      x0, [x0, #0x8e0] ; GLOBAL [Punchboard] AroundPlayerRandom has no available player, fallback to MissionNpcPos. @ 0x93189b0
0065925BC  bl       #0x382bd14 ; 
0065925C0  mov      w8, #1
0065925C4  strb     w8, [x21, #0x24e]
0065925C8  ldr      x1, [x22]
0065925CC  ldrb     w8, [x1, #0x53]
0065925D0  tbnz     w8, #5, #0x6592610
0065925D4  adrp     x26, #0x9599000
0065925D8  ldrb     w8, [x26, #0x286]
0065925DC  cbnz     w8, #0x65925f4
0065925E0  adrp     x0, #0x8f07000
0065925E4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065925E8  bl       #0x382bd14 ; 
0065925EC  mov      w8, #1
0065925F0  strb     w8, [x26, #0x286]
0065925F4  adrp     x27, #0x8f07000
0065925F8  ldr      x27, [x27, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065925FC  ldr      x1, [x27]
006592600  ldrb     w8, [x1, #0x53]
006592604  tbnz     w8, #5, #0x6592624
006592608  ldr      x0, [x20, #0x80]
00659260C  b        #0x6592630 ; 
006592610  ldr      x9, [x1, #0x60]
006592614  mov      x8, x19
006592618  mov      x0, x20
00659261C  blr      x9
006592620  b        #0x6592858 ; 
006592624  ldr      x8, [x1, #0x60]
006592628  mov      x0, x20
00659262C  blr      x8
006592630  cbz      x0, #0x6592888
006592634  add      x8, sp, #0x90
006592638  mov      x1, xzr
00659263C  add      x25, sp, #0x90
006592640  bl       #0x69ffac0 ; HotFix.BattleLogic.BattleWorldContext$$GetPunchboardGameplayRule
006592644  ldr      d0, [sp, #0x90]
006592648  ldur     q1, [x25, #0x18]
00659264C  ldur     q2, [x25, #0x28]
006592650  ldp      x22, x21, [sp, #0x98]
006592654  fmov     w8, s0
006592658  cmp      w8, #3
00659265C  stp      q1, q2, [sp, #0x40]
006592660  b.eq     #0x6592690
006592664  cmp      w8, #2
006592668  b.eq     #0x6592758
00659266C  ldp      q1, q2, [sp, #0x40]
006592670  add      x8, sp, #0x90
006592674  add      x1, sp, #8
006592678  mov      x0, x20
00659267C  str      d0, [sp, #8]
006592680  stp      q1, q2, [sp, #0x20]
006592684  stp      x22, x21, [sp, #0x10]
006592688  bl       #0x6592c08 ; HotFix.BattleLogic.BattleManager$$GetPunchboardScreenTopRandomPos
00659268C  b        #0x6592764 ; 
006592690  ldrb     w8, [x26, #0x286]
006592694  cbnz     w8, #0x65926ac
006592698  adrp     x0, #0x8f07000
00659269C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065926A0  bl       #0x382bd14 ; 
0065926A4  mov      w8, #1
0065926A8  strb     w8, [x26, #0x286]
0065926AC  ldr      x1, [x27]
0065926B0  ldrb     w8, [x1, #0x53]
0065926B4  tbnz     w8, #5, #0x65926c0
0065926B8  ldr      x0, [x20, #0x80]
0065926BC  b        #0x65926cc ; 
0065926C0  ldr      x8, [x1, #0x60]
0065926C4  mov      x0, x20
0065926C8  blr      x8
0065926CC  cbz      x0, #0x6592888
0065926D0  mov      x1, xzr
0065926D4  bl       #0x69ffbd0 ; HotFix.BattleLogic.BattleWorldContext$$GetPunchboardReferencePlayer
0065926D8  cbz      x0, #0x6592710
0065926DC  ldrb     w8, [x26, #0x286]
0065926E0  mov      x23, x0
0065926E4  cbnz     w8, #0x65926fc
0065926E8  adrp     x0, #0x8f07000
0065926EC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065926F0  bl       #0x382bd14 ; 
0065926F4  mov      w8, #1
0065926F8  strb     w8, [x26, #0x286]
0065926FC  ldr      x1, [x27]
006592700  ldrb     w8, [x1, #0x53]
006592704  tbnz     w8, #5, #0x6592770
006592708  ldr      x20, [x20, #0x80]
00659270C  b        #0x6592780 ; 
006592710  adrp     x8, #0x8ee1000
006592714  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006592718  ldr      x0, [x8]
00659271C  ldr      w8, [x0, #0xe0]
006592720  cbnz     w8, #0x6592728
006592724  bl       #0x382be8c ; 
006592728  adrp     x8, #0x8f08000
00659272C  adrp     x9, #0x8f08000
006592730  adrp     x10, #0x8f08000
006592734  ldr      x8, [x8, #0x8e0] ; GLOBAL [Punchboard] AroundPlayerRandom has no available player, fallback to MissionNpcPos. @ 0x93189b0
006592738  ldr      x9, [x9, #0x8d8] ; GLOBAL GetPunchboardSpawnPos @ 0x92fed08
00659273C  ldr      x10, [x10, #0x8d0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\BattleManager.cs @ 0x92f7de8
006592740  mov      w3, #0x2a1
006592744  ldr      x0, [x8]
006592748  ldr      x1, [x9]
00659274C  ldr      x2, [x10]
006592750  mov      x4, xzr
006592754  bl       #0x7997754 ; Logger$$LogError
006592758  add      x8, sp, #0x90
00659275C  mov      x0, x20
006592760  bl       #0x6592890 ; HotFix.BattleLogic.BattleManager$$GetPunchboardMissionNpcPos
006592764  ldr      x8, [sp, #0xa0]
006592768  ldr      q0, [x25]
00659276C  b        #0x6592850 ; 
006592770  ldr      x8, [x1, #0x60]
006592774  mov      x0, x20
006592778  blr      x8
00659277C  mov      x20, x0
006592780  cbz      x20, #0x6592888
006592784  adrp     x26, #0x9591000
006592788  ldrb     w8, [x26, #0xa9c]
00659278C  cbnz     w8, #0x65927a4
006592790  adrp     x0, #0x8ee6000
006592794  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
006592798  bl       #0x382bd14 ; 
00659279C  mov      w8, #1
0065927A0  strb     w8, [x26, #0xa9c]
0065927A4  adrp     x8, #0x8ee6000
0065927A8  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
0065927AC  ldr      x1, [x8]
0065927B0  ldrb     w8, [x1, #0x53]
0065927B4  tbnz     w8, #5, #0x65927c0
0065927B8  ldr      x20, [x20, #0x240]
0065927BC  b        #0x65927d0 ; 
0065927C0  ldr      x8, [x1, #0x60]
0065927C4  mov      x0, x20
0065927C8  blr      x8
0065927CC  mov      x20, x0
0065927D0  adrp     x8, #0x8ee6000
0065927D4  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065927D8  ldr      x1, [x8]
0065927DC  ldrb     w8, [x1, #0x53]
0065927E0  tbnz     w8, #5, #0x65927ec
0065927E4  ldr      x0, [x23, #0x38]
0065927E8  b        #0x65927f8 ; 
0065927EC  ldr      x8, [x1, #0x60]
0065927F0  mov      x0, x23
0065927F4  blr      x8
0065927F8  cbz      x0, #0x6592888
0065927FC  add      x8, sp, #0x78
006592800  mov      x1, xzr
006592804  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006592808  ldur     q0, [sp, #0x78]
00659280C  ldr      x8, [sp, #0x88]
006592810  str      q0, [x25]
006592814  str      x8, [sp, #0xa0]
006592818  cbz      x20, #0x6592888
00659281C  ldr      x8, [sp, #0xa0]
006592820  ldr      q0, [x25]
006592824  add      x1, sp, #0x60
006592828  mov      x0, x20
00659282C  str      x8, [sp, #0x70]
006592830  add      x8, sp, #0x78
006592834  mov      x2, x22
006592838  mov      x3, x21
00659283C  mov      x4, xzr
006592840  str      q0, [sp, #0x60]
006592844  bl       #0x690b3cc ; HotFix.BattleLogic.MapManager$$GetRandomPosAroundCenter
006592848  ldr      x8, [sp, #0x88]
00659284C  ldur     q0, [sp, #0x78]
006592850  str      x8, [x19, #0x10]
006592854  str      q0, [x19]
006592858  ldr      x8, [x24, #0x28]
00659285C  ldr      x9, [sp, #0xc8]
006592860  cmp      x8, x9
006592864  b.ne     #0x659288c
006592868  ldp      x20, x19, [sp, #0x120]
00659286C  ldp      x22, x21, [sp, #0x110]
006592870  ldp      x24, x23, [sp, #0x100]
006592874  ldp      x26, x25, [sp, #0xf0]
006592878  ldp      x30, x27, [sp, #0xe0]
00659287C  ldr      x29, [sp, #0xd0]
006592880  add      sp, sp, #0x130
006592884  ret      
006592888  bl       #0x382bfb8 ; 
00659288C  bl       #0x89edb60 ; 

