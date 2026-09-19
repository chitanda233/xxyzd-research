; HotFix.BattleLogic.WaterfallStateHeroDie$$OnPlayerRelive
; RVA 0x65B5238; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B5238  str      x30, [sp, #-0x40]!
0065B523C  stp      x24, x23, [sp, #0x10]
0065B5240  stp      x22, x21, [sp, #0x20]
0065B5244  stp      x20, x19, [sp, #0x30]
0065B5248  adrp     x20, #0x9599000
0065B524C  adrp     x21, #0x8f09000
0065B5250  ldrb     w8, [x20, #0x42c]
0065B5254  ldr      x21, [x21, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateHeroDie.OnPlayerRelive() @ 0x92c8830
0065B5258  mov      x19, x0
0065B525C  tbnz     w8, #0, #0x65b5280
0065B5260  adrp     x0, #0x8f08000
0065B5264  ldr      x0, [x0, #0xf48] ; GLOBAL HotFix.BattleLogic.WaterfallBattleManager_TypeInfo @ 0x91f48a8
0065B5268  bl       #0x382bd14 ; 
0065B526C  adrp     x0, #0x8f09000
0065B5270  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateHeroDie.OnPlayerRelive() @ 0x92c8830
0065B5274  bl       #0x382bd14 ; 
0065B5278  mov      w8, #1
0065B527C  strb     w8, [x20, #0x42c]
0065B5280  ldr      x1, [x21]
0065B5284  ldrb     w8, [x1, #0x53]
0065B5288  tbnz     w8, #5, #0x65b52c8
0065B528C  adrp     x21, #0x9599000
0065B5290  ldrb     w8, [x21, #0x4b1]
0065B5294  cbnz     w8, #0x65b52ac
0065B5298  adrp     x0, #0x8f08000
0065B529C  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B52A0  bl       #0x382bd14 ; 
0065B52A4  mov      w8, #1
0065B52A8  strb     w8, [x21, #0x4b1]
0065B52AC  adrp     x23, #0x8f08000
0065B52B0  ldr      x23, [x23, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B52B4  ldr      x1, [x23]
0065B52B8  ldrb     w8, [x1, #0x53]
0065B52BC  tbnz     w8, #5, #0x65b52e4
0065B52C0  ldr      x20, [x19, #0x10]
0065B52C4  b        #0x65b52f4 ; 
0065B52C8  ldr      x2, [x1, #0x60]
0065B52CC  mov      x0, x19
0065B52D0  ldp      x20, x19, [sp, #0x30]
0065B52D4  ldp      x22, x21, [sp, #0x20]
0065B52D8  ldp      x24, x23, [sp, #0x10]
0065B52DC  ldr      x30, [sp], #0x40
0065B52E0  br       x2
0065B52E4  ldr      x8, [x1, #0x60]
0065B52E8  mov      x0, x19
0065B52EC  blr      x8
0065B52F0  mov      x20, x0
0065B52F4  cbz      x20, #0x65b54bc
0065B52F8  adrp     x22, #0x9598000
0065B52FC  ldrb     w8, [x22, #0xfc4]
0065B5300  cbnz     w8, #0x65b5318
0065B5304  adrp     x0, #0x8f05000
0065B5308  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B530C  bl       #0x382bd14 ; 
0065B5310  mov      w8, #1
0065B5314  strb     w8, [x22, #0xfc4]
0065B5318  adrp     x24, #0x8f05000
0065B531C  ldr      x24, [x24, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B5320  ldr      x1, [x24]
0065B5324  ldrb     w8, [x1, #0x53]
0065B5328  tbnz     w8, #5, #0x65b5334
0065B532C  ldr      x0, [x20, #0x220]
0065B5330  b        #0x65b5340 ; 
0065B5334  ldr      x8, [x1, #0x60]
0065B5338  mov      x0, x20
0065B533C  blr      x8
0065B5340  cbz      x0, #0x65b54bc
0065B5344  mov      w1, #1
0065B5348  mov      w3, #1
0065B534C  mov      x2, xzr
0065B5350  mov      x4, xzr
0065B5354  mov      w20, #1
0065B5358  bl       #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
0065B535C  ldrb     w8, [x21, #0x4b1]
0065B5360  cbnz     w8, #0x65b5374
0065B5364  adrp     x0, #0x8f08000
0065B5368  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B536C  bl       #0x382bd14 ; 
0065B5370  strb     w20, [x21, #0x4b1]
0065B5374  ldr      x1, [x23]
0065B5378  ldrb     w8, [x1, #0x53]
0065B537C  tbnz     w8, #5, #0x65b5388
0065B5380  ldr      x20, [x19, #0x10]
0065B5384  b        #0x65b5398 ; 
0065B5388  ldr      x8, [x1, #0x60]
0065B538C  mov      x0, x19
0065B5390  blr      x8
0065B5394  mov      x20, x0
0065B5398  cbz      x20, #0x65b54bc
0065B539C  ldrb     w8, [x22, #0xfc4]
0065B53A0  cbnz     w8, #0x65b53b8
0065B53A4  adrp     x0, #0x8f05000
0065B53A8  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B53AC  bl       #0x382bd14 ; 
0065B53B0  mov      w8, #1
0065B53B4  strb     w8, [x22, #0xfc4]
0065B53B8  ldr      x1, [x24]
0065B53BC  ldrb     w8, [x1, #0x53]
0065B53C0  tbnz     w8, #5, #0x65b53cc
0065B53C4  ldr      x0, [x20, #0x220]
0065B53C8  b        #0x65b53d8 ; 
0065B53CC  ldr      x8, [x1, #0x60]
0065B53D0  mov      x0, x20
0065B53D4  blr      x8
0065B53D8  cbz      x0, #0x65b54bc
0065B53DC  ldr      x8, [x0]
0065B53E0  ldr      x9, [x8, #0x218]
0065B53E4  ldr      x1, [x8, #0x220]
0065B53E8  blr      x9
0065B53EC  ldrb     w8, [x21, #0x4b1]
0065B53F0  cbnz     w8, #0x65b5408
0065B53F4  adrp     x0, #0x8f08000
0065B53F8  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B53FC  bl       #0x382bd14 ; 
0065B5400  mov      w8, #1
0065B5404  strb     w8, [x21, #0x4b1]
0065B5408  ldr      x1, [x23]
0065B540C  ldrb     w8, [x1, #0x53]
0065B5410  tbnz     w8, #5, #0x65b541c
0065B5414  ldr      x19, [x19, #0x10]
0065B5418  b        #0x65b542c ; 
0065B541C  ldr      x8, [x1, #0x60]
0065B5420  mov      x0, x19
0065B5424  blr      x8
0065B5428  mov      x19, x0
0065B542C  cbz      x19, #0x65b54bc
0065B5430  ldrb     w8, [x22, #0xfc4]
0065B5434  cbnz     w8, #0x65b544c
0065B5438  adrp     x0, #0x8f05000
0065B543C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B5440  bl       #0x382bd14 ; 
0065B5444  mov      w8, #1
0065B5448  strb     w8, [x22, #0xfc4]
0065B544C  ldr      x1, [x24]
0065B5450  ldrb     w8, [x1, #0x53]
0065B5454  tbnz     w8, #5, #0x65b5460
0065B5458  ldr      x0, [x19, #0x220]
0065B545C  b        #0x65b546c ; 
0065B5460  ldr      x8, [x1, #0x60]
0065B5464  mov      x0, x19
0065B5468  blr      x8
0065B546C  cbz      x0, #0x65b54bc
0065B5470  adrp     x9, #0x8f08000
0065B5474  ldr      x9, [x9, #0xf48] ; GLOBAL HotFix.BattleLogic.WaterfallBattleManager_TypeInfo @ 0x91f48a8
0065B5478  ldr      x8, [x0]
0065B547C  ldr      x1, [x9]
0065B5480  ldrb     w10, [x8, #0x130]
0065B5484  ldrb     w9, [x1, #0x130]
0065B5488  cmp      w10, w9
0065B548C  b.lo     #0x65b54c0
0065B5490  ldr      x8, [x8, #0xc8]
0065B5494  add      x8, x8, x9, lsl #3
0065B5498  ldur     x8, [x8, #-8]
0065B549C  cmp      x8, x1
0065B54A0  b.ne     #0x65b54c0
0065B54A4  ldp      x20, x19, [sp, #0x30]
0065B54A8  ldp      x22, x21, [sp, #0x20]
0065B54AC  ldp      x24, x23, [sp, #0x10]
0065B54B0  mov      x1, xzr
0065B54B4  ldr      x30, [sp], #0x40
0065B54B8  b        #0x65c8c14 ; HotFix.BattleLogic.WaterfallBattleManager$$TryResumeWaveEndUpLevelProgress
0065B54BC  bl       #0x382bfb8 ; 
0065B54C0  bl       #0x382c354 ; 

