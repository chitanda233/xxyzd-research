; HotFix.BattleLogic.BaseEndState$$OnEnter
; RVA 0x6598EB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006598EB4  sub      sp, sp, #0x50
006598EB8  stp      x30, x25, [sp, #0x10]
006598EBC  stp      x24, x23, [sp, #0x20]
006598EC0  stp      x22, x21, [sp, #0x30]
006598EC4  stp      x20, x19, [sp, #0x40]
006598EC8  adrp     x21, #0x9599000
006598ECC  adrp     x22, #0x8f08000
006598ED0  ldrb     w8, [x21, #0x2f7]
006598ED4  ldr      x22, [x22, #0xcd8] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.OnEnter() @ 0x923b0f0
006598ED8  mov      x20, x1
006598EDC  mov      x19, x0
006598EE0  tbnz     w8, #0, #0x6598f64
006598EE4  adrp     x0, #0x8ec1000
006598EE8  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
006598EEC  bl       #0x382bd14 ; 
006598EF0  adrp     x0, #0x8f08000
006598EF4  ldr      x0, [x0, #0xce0] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.EnterEnd() @ 0x923b0e8
006598EF8  bl       #0x382bd14 ; 
006598EFC  adrp     x0, #0x8f08000
006598F00  ldr      x0, [x0, #0xcd8] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.OnEnter() @ 0x923b0f0
006598F04  bl       #0x382bd14 ; 
006598F08  adrp     x0, #0x8f08000
006598F0C  ldr      x0, [x0, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.PlayFinishAnim() @ 0x923b110
006598F10  bl       #0x382bd14 ; 
006598F14  adrp     x0, #0x8f08000
006598F18  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.ShowVictoryPerformance() @ 0x923b128
006598F1C  bl       #0x382bd14 ; 
006598F20  adrp     x0, #0x8f08000
006598F24  ldr      x0, [x0, #0xcf8] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.<OnEnter>b__11_0() @ 0x923b0e0
006598F28  bl       #0x382bd14 ; 
006598F2C  adrp     x0, #0x8f08000
006598F30  ldr      x0, [x0, #0x968] ; GLOBAL HotFix.BattleLogic.BattleEndParam_TypeInfo @ 0x91e1348
006598F34  bl       #0x382bd14 ; 
006598F38  adrp     x0, #0x8ee6000
006598F3C  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006598F40  bl       #0x382bd14 ; 
006598F44  adrp     x0, #0x8ec2000
006598F48  ldr      x0, [x0, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo @ 0x91d3888
006598F4C  bl       #0x382bd14 ; 
006598F50  adrp     x0, #0x8f08000
006598F54  ldr      x0, [x0, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init() @ 0x922db10
006598F58  bl       #0x382bd14 ; 
006598F5C  mov      w8, #1
006598F60  strb     w8, [x21, #0x2f7]
006598F64  ldr      x2, [x22]
006598F68  ldrb     w8, [x2, #0x53]
006598F6C  tbnz     w8, #5, #0x6598fb8
006598F70  ldr      x21, [x19, #0x18]
006598F74  cbz      x21, #0x65993e8
006598F78  adrp     x22, #0x9599000
006598F7C  ldrb     w8, [x22, #0x4b0]
006598F80  cbnz     w8, #0x6598f98
006598F84  adrp     x0, #0x8f08000
006598F88  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
006598F8C  bl       #0x382bd14 ; 
006598F90  mov      w8, #1
006598F94  strb     w8, [x22, #0x4b0]
006598F98  adrp     x8, #0x8f08000
006598F9C  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
006598FA0  ldr      x2, [x8]
006598FA4  ldrb     w8, [x2, #0x53]
006598FA8  tbnz     w8, #5, #0x6598fdc
006598FAC  mov      w8, #1
006598FB0  strb     w8, [x21, #0x648]
006598FB4  b        #0x6598fec ; 
006598FB8  ldr      x3, [x2, #0x60]
006598FBC  mov      x0, x19
006598FC0  mov      x1, x20
006598FC4  ldp      x20, x19, [sp, #0x40]
006598FC8  ldp      x22, x21, [sp, #0x30]
006598FCC  ldp      x24, x23, [sp, #0x20]
006598FD0  ldp      x30, x25, [sp, #0x10]
006598FD4  add      sp, sp, #0x50
006598FD8  br       x3
006598FDC  ldr      x8, [x2, #0x60]
006598FE0  mov      w1, #1
006598FE4  mov      x0, x21
006598FE8  blr      x8
006598FEC  adrp     x23, #0x9599000
006598FF0  ldrb     w8, [x23, #0x4b1]
006598FF4  cbnz     w8, #0x659900c
006598FF8  adrp     x0, #0x8f08000
006598FFC  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006599000  bl       #0x382bd14 ; 
006599004  mov      w8, #1
006599008  strb     w8, [x23, #0x4b1]
00659900C  adrp     x24, #0x8f08000
006599010  ldr      x24, [x24, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006599014  ldr      x1, [x24]
006599018  ldrb     w8, [x1, #0x53]
00659901C  tbnz     w8, #5, #0x6599028
006599020  ldr      x0, [x19, #0x10]
006599024  b        #0x6599034 ; 
006599028  ldr      x8, [x1, #0x60]
00659902C  mov      x0, x19
006599030  blr      x8
006599034  cbz      x0, #0x65993e8
006599038  mov      w1, #1
00659903C  mov      x2, xzr
006599040  mov      w21, #1
006599044  bl       #0x6a00e84 ; HotFix.BattleLogic.BattleWorldContext$$SetDisableSlowGameSpeed
006599048  cbz      x20, #0x6599084
00659904C  adrp     x8, #0x8f08000
006599050  ldr      x8, [x8, #0x968] ; GLOBAL HotFix.BattleLogic.BattleEndParam_TypeInfo @ 0x91e1348
006599054  ldr      x9, [x20]
006599058  ldr      x8, [x8]
00659905C  ldrb     w11, [x9, #0x130]
006599060  ldrb     w10, [x8, #0x130]
006599064  cmp      w11, w10
006599068  b.lo     #0x6599080
00659906C  ldr      x9, [x9, #0xc8]
006599070  add      x9, x9, x10, lsl #3
006599074  ldur     x9, [x9, #-8]
006599078  cmp      x9, x8
00659907C  b.eq     #0x65993e0
006599080  mov      w21, #1
006599084  strb     w21, [x19, #0x3a]
006599088  ldrb     w8, [x23, #0x4b1]
00659908C  cbnz     w8, #0x65990a4
006599090  adrp     x0, #0x8f08000
006599094  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006599098  bl       #0x382bd14 ; 
00659909C  mov      w8, #1
0065990A0  strb     w8, [x23, #0x4b1]
0065990A4  ldr      x1, [x24]
0065990A8  ldrb     w8, [x1, #0x53]
0065990AC  tbnz     w8, #5, #0x65990b8
0065990B0  ldr      x20, [x19, #0x10]
0065990B4  b        #0x65990c8 ; 
0065990B8  ldr      x8, [x1, #0x60]
0065990BC  mov      x0, x19
0065990C0  blr      x8
0065990C4  mov      x20, x0
0065990C8  ldr      x21, [x19, #0x18]
0065990CC  cbz      x21, #0x65993e8
0065990D0  adrp     x8, #0x8ee6000
0065990D4  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065990D8  ldr      x1, [x8]
0065990DC  ldrb     w8, [x1, #0x53]
0065990E0  tbnz     w8, #5, #0x65990ec
0065990E4  ldr      x22, [x21, #0x38]
0065990E8  b        #0x65990fc ; 
0065990EC  ldr      x8, [x1, #0x60]
0065990F0  mov      x0, x21
0065990F4  blr      x8
0065990F8  mov      x22, x0
0065990FC  cbz      x22, #0x65993e8
006599100  adrp     x25, #0x9591000
006599104  ldrb     w8, [x25, #0xa7f]
006599108  cbnz     w8, #0x6599120
00659910C  adrp     x0, #0x8ee6000
006599110  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006599114  bl       #0x382bd14 ; 
006599118  mov      w8, #1
00659911C  strb     w8, [x25, #0xa7f]
006599120  adrp     x8, #0x8ee6000
006599124  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006599128  ldr      x1, [x8]
00659912C  ldrb     w8, [x1, #0x53]
006599130  tbnz     w8, #5, #0x659913c
006599134  ldr      x2, [x22, #0x178]
006599138  b        #0x659914c ; 
00659913C  ldr      x8, [x1, #0x60]
006599140  mov      x0, x22
006599144  blr      x8
006599148  mov      x2, x0
00659914C  cbz      x20, #0x65993e8
006599150  ldr      x3, [x19, #0x18]
006599154  mov      w4, #1
006599158  mov      w5, #0x10000
00659915C  mov      x0, x20
006599160  mov      x1, x21
006599164  mov      w6, wzr
006599168  mov      w7, wzr
00659916C  str      xzr, [sp]
006599170  bl       #0x6a0d17c ; HotFix.BattleLogic.BattleWorldContext$$AddBuffToEntity
006599174  ldr      x0, [x19, #0x20]
006599178  cbz      x0, #0x65993e8
00659917C  adrp     x8, #0x8f08000
006599180  ldr      x8, [x8, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init() @ 0x922db10
006599184  ldr      x1, [x8]
006599188  bl       #0x556fd48 ; HotFix.Common.TaskQueue<FP>$$Init
00659918C  ldrb     w8, [x19, #0x3a]
006599190  mov      w9, #-1
006599194  str      w9, [x19, #0x28]
006599198  strh     wzr, [x19, #0x38]
00659919C  cbz      w8, #0x6599308
0065991A0  ldr      x1, [x19, #0x20]
0065991A4  mov      w2, #0x10000
0065991A8  mov      x0, x19
0065991AC  bl       #0x65993ec ; HotFix.BattleLogic.BattleState$$AddTaskWait
0065991B0  ldr      x8, [x19]
0065991B4  mov      x0, x19
0065991B8  ldp      x9, x1, [x8, #0x1c8]
0065991BC  blr      x9
0065991C0  tbz      w0, #0, #0x6599248
0065991C4  adrp     x8, #0x8ec1000
0065991C8  ldr      x20, [x19, #0x20]
0065991CC  ldr      x8, [x8, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
0065991D0  ldr      x0, [x8]
0065991D4  bl       #0x382bfa0 ; 
0065991D8  adrp     x8, #0x8f08000
0065991DC  ldr      x8, [x8, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.ShowVictoryPerformance() @ 0x923b128
0065991E0  mov      x1, x19
0065991E4  mov      x3, xzr
0065991E8  mov      x21, x0
0065991EC  ldr      x2, [x8]
0065991F0  bl       #0x7ade578 ; System.Action$$.ctor
0065991F4  mov      x0, x19
0065991F8  mov      x1, x20
0065991FC  mov      x2, x21
006599200  bl       #0x6599550 ; HotFix.BattleLogic.BattleState$$AddEventAction
006599204  adrp     x8, #0x8ec2000
006599208  ldr      x20, [x19, #0x20]
00659920C  ldr      x8, [x8, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo @ 0x91d3888
006599210  ldr      x0, [x8]
006599214  bl       #0x382bfa0 ; 
006599218  adrp     x8, #0x8f08000
00659921C  ldr      x8, [x8, #0xcf8] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.<OnEnter>b__11_0() @ 0x923b0e0
006599220  mov      x1, x19
006599224  mov      x3, xzr
006599228  mov      x21, x0
00659922C  ldr      x2, [x8]
006599230  bl       #0x635ad78 ; System.Func<bool>$$.ctor
006599234  mov      x0, x19
006599238  mov      x1, x20
00659923C  mov      x2, x21
006599240  mov      x3, xzr
006599244  bl       #0x65996c0 ; HotFix.BattleLogic.BattleState$$AddConditional
006599248  adrp     x22, #0x8ec1000
00659924C  ldr      x20, [x19, #0x20]
006599250  ldr      x22, [x22, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
006599254  ldr      x0, [x22]
006599258  bl       #0x382bfa0 ; 
00659925C  adrp     x8, #0x8f08000
006599260  ldr      x8, [x8, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.PlayFinishAnim() @ 0x923b110
006599264  mov      x1, x19
006599268  mov      x3, xzr
00659926C  mov      x21, x0
006599270  ldr      x2, [x8]
006599274  bl       #0x7ade578 ; System.Action$$.ctor
006599278  mov      x0, x19
00659927C  mov      x1, x20
006599280  mov      x2, x21
006599284  bl       #0x6599550 ; HotFix.BattleLogic.BattleState$$AddEventAction
006599288  ldr      x0, [x22]
00659928C  ldr      x20, [x19, #0x20]
006599290  bl       #0x382bfa0 ; 
006599294  ldr      x8, [x19]
006599298  mov      x1, x19
00659929C  mov      x3, xzr
0065992A0  mov      x21, x0
0065992A4  ldr      x2, [x8, #0x1e0]
0065992A8  bl       #0x7ade578 ; System.Action$$.ctor
0065992AC  mov      x0, x19
0065992B0  mov      x1, x20
0065992B4  mov      x2, x21
0065992B8  bl       #0x6599550 ; HotFix.BattleLogic.BattleState$$AddEventAction
0065992BC  ldr      x0, [x22]
0065992C0  ldr      x20, [x19, #0x20]
0065992C4  bl       #0x382bfa0 ; 
0065992C8  adrp     x8, #0x8f08000
0065992CC  ldr      x8, [x8, #0xce0] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.EnterEnd() @ 0x923b0e8
0065992D0  mov      x1, x19
0065992D4  mov      x3, xzr
0065992D8  mov      x21, x0
0065992DC  ldr      x2, [x8]
0065992E0  bl       #0x7ade578 ; System.Action$$.ctor
0065992E4  mov      x0, x19
0065992E8  mov      x1, x20
0065992EC  mov      x2, x21
0065992F0  ldp      x20, x19, [sp, #0x40]
0065992F4  ldp      x22, x21, [sp, #0x30]
0065992F8  ldp      x24, x23, [sp, #0x20]
0065992FC  ldp      x30, x25, [sp, #0x10]
006599300  add      sp, sp, #0x50
006599304  b        #0x6599550 ; HotFix.BattleLogic.BattleState$$AddEventAction
006599308  ldr      x0, [x19, #0x18]
00659930C  cbz      x0, #0x65993e8
006599310  mov      w1, wzr
006599314  mov      x2, xzr
006599318  bl       #0x687d3f4 ; HotFix.BattleLogic.EntityHeroNormal$$set_DisableMoveInput
00659931C  ldrb     w8, [x23, #0x4b1]
006599320  cbnz     w8, #0x6599338
006599324  adrp     x0, #0x8f08000
006599328  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659932C  bl       #0x382bd14 ; 
006599330  mov      w8, #1
006599334  strb     w8, [x23, #0x4b1]
006599338  ldr      x1, [x24]
00659933C  ldrb     w8, [x1, #0x53]
006599340  tbnz     w8, #5, #0x659934c
006599344  ldr      x20, [x19, #0x10]
006599348  b        #0x659935c ; 
00659934C  ldr      x8, [x1, #0x60]
006599350  mov      x0, x19
006599354  blr      x8
006599358  mov      x20, x0
00659935C  cbz      x20, #0x65993e8
006599360  adrp     x21, #0x9598000
006599364  ldrb     w8, [x21, #0xfc4]
006599368  cbnz     w8, #0x6599380
00659936C  adrp     x0, #0x8f05000
006599370  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006599374  bl       #0x382bd14 ; 
006599378  mov      w8, #1
00659937C  strb     w8, [x21, #0xfc4]
006599380  adrp     x8, #0x8f05000
006599384  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006599388  ldr      x1, [x8]
00659938C  ldrb     w8, [x1, #0x53]
006599390  tbnz     w8, #5, #0x659939c
006599394  ldr      x0, [x20, #0x220]
006599398  b        #0x65993a8 ; 
00659939C  ldr      x8, [x1, #0x60]
0065993A0  mov      x0, x20
0065993A4  blr      x8
0065993A8  cbz      x0, #0x65993e8
0065993AC  ldr      x8, [x0]
0065993B0  mov      w1, wzr
0065993B4  ldr      x9, [x8, #0x258]
0065993B8  ldr      x2, [x8, #0x260]
0065993BC  blr      x9
0065993C0  mov      w8, #4
0065993C4  str      w8, [x19, #0x28]
0065993C8  ldp      x20, x19, [sp, #0x40]
0065993CC  ldp      x22, x21, [sp, #0x30]
0065993D0  ldp      x24, x23, [sp, #0x20]
0065993D4  ldp      x30, x25, [sp, #0x10]
0065993D8  add      sp, sp, #0x50
0065993DC  ret      
0065993E0  ldrb     w21, [x20, #0x14]
0065993E4  b        #0x6599084 ; 
0065993E8  bl       #0x382bfb8 ; 

