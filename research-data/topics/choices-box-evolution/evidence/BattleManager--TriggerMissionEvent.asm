; HotFix.BattleLogic.BattleManager$$TriggerMissionEvent
; RVA 0x6588780; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588780  stp      x30, x27, [sp, #-0x50]!
006588784  stp      x26, x25, [sp, #0x10]
006588788  stp      x24, x23, [sp, #0x20]
00658878C  stp      x22, x21, [sp, #0x30]
006588790  stp      x20, x19, [sp, #0x40]
006588794  adrp     x20, #0x9599000
006588798  adrp     x25, #0x8f08000
00658879C  ldrb     w8, [x20, #0x253]
0065887A0  ldr      x25, [x25, #0x230] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.TriggerMissionEvent() @ 0x923cc60
0065887A4  mov      x22, x4
0065887A8  mov      x21, x3
0065887AC  mov      w24, w2
0065887B0  mov      w23, w1
0065887B4  mov      x19, x0
0065887B8  tbnz     w8, #0, #0x6588848
0065887BC  adrp     x0, #0x8ec1000
0065887C0  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
0065887C4  bl       #0x382bd14 ; 
0065887C8  adrp     x0, #0x8f08000
0065887CC  ldr      x0, [x0, #0x230] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.TriggerMissionEvent() @ 0x923cc60
0065887D0  bl       #0x382bd14 ; 
0065887D4  adrp     x0, #0x8f08000
0065887D8  ldr      x0, [x0, #0x238] ; GLOBAL Method$HotFix.Common.BehaviorTaskFactory.GetTask<DoEventAction<FP>>() @ 0x92406d8
0065887DC  bl       #0x382bd14 ; 
0065887E0  adrp     x0, #0x8f08000
0065887E4  ldr      x0, [x0, #0x240] ; GLOBAL Method$HotFix.Common.BehaviorTaskFactory.GetTask<Wait>() @ 0x9240738
0065887E8  bl       #0x382bd14 ; 
0065887EC  adrp     x0, #0x8f08000
0065887F0  ldr      x0, [x0, #0x248] ; GLOBAL Method$System.Collections.Generic.List<TaskQueue<FP>>.Add() @ 0x9219308
0065887F4  bl       #0x382bd14 ; 
0065887F8  adrp     x0, #0x8f08000
0065887FC  ldr      x0, [x0, #0x250] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.AddTask() @ 0x922daf8
006588800  bl       #0x382bd14 ; 
006588804  adrp     x0, #0x8f08000
006588808  ldr      x0, [x0, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init() @ 0x922db10
00658880C  bl       #0x382bd14 ; 
006588810  adrp     x0, #0x8f08000
006588814  ldr      x0, [x0, #0x260] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>..ctor() @ 0x922daf0
006588818  bl       #0x382bd14 ; 
00658881C  adrp     x0, #0x8f08000
006588820  ldr      x0, [x0, #0x268] ; GLOBAL HotFix.Common.TaskQueue<FP>_TypeInfo @ 0x91de2b8
006588824  bl       #0x382bd14 ; 
006588828  adrp     x0, #0x8f08000
00658882C  ldr      x0, [x0, #0x270] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0.<TriggerMissionEvent>b__0() @ 0x92d2d48
006588830  bl       #0x382bd14 ; 
006588834  adrp     x0, #0x8f08000
006588838  ldr      x0, [x0, #0x278] ; GLOBAL HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0_TypeInfo @ 0x91f6a28
00658883C  bl       #0x382bd14 ; 
006588840  mov      w8, #1
006588844  strb     w8, [x20, #0x253]
006588848  ldr      x5, [x25]
00658884C  ldrb     w8, [x5, #0x53]
006588850  tbnz     w8, #5, #0x658892c
006588854  adrp     x8, #0x8f08000
006588858  ldr      x8, [x8, #0x278] ; GLOBAL HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0_TypeInfo @ 0x91f6a28
00658885C  ldr      x0, [x8]
006588860  bl       #0x382bfa0 ; 
006588864  mov      x1, xzr
006588868  mov      x20, x0
00658886C  bl       #0x6594e3c ; HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0$$.ctor
006588870  cbz      x20, #0x6588bdc
006588874  and      w25, w24, #1
006588878  mov      x24, x20
00658887C  str      x19, [x24, #0x18]!
006588880  mov      x0, x24
006588884  mov      x1, x19
006588888  stur     w23, [x24, #-8]
00658888C  bl       #0x382bcb8 ; 
006588890  strb     w25, [x24, #8]
006588894  str      x21, [x24, #0x10]
006588898  adrp     x8, #0x8f08000
00658889C  ldr      x8, [x8, #0x268] ; GLOBAL HotFix.Common.TaskQueue<FP>_TypeInfo @ 0x91de2b8
0065888A0  ldr      x0, [x8]
0065888A4  bl       #0x382bfa0 ; 
0065888A8  adrp     x8, #0x8f08000
0065888AC  ldr      x8, [x8, #0x260] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>..ctor() @ 0x922daf0
0065888B0  mov      x21, x0
0065888B4  ldr      x1, [x8]
0065888B8  bl       #0x557021c ; HotFix.Common.TaskQueue<FP>$$.ctor
0065888BC  cbz      x21, #0x6588bdc
0065888C0  adrp     x8, #0x8f08000
0065888C4  ldr      x8, [x8, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init() @ 0x922db10
0065888C8  mov      x0, x21
0065888CC  ldr      x1, [x8]
0065888D0  bl       #0x556fd48 ; HotFix.Common.TaskQueue<FP>$$Init
0065888D4  ldr      x0, [x19, #0x50]
0065888D8  cbz      x0, #0x6588bdc
0065888DC  adrp     x9, #0x8f08000
0065888E0  ldr      x9, [x9, #0x248] ; GLOBAL Method$System.Collections.Generic.List<TaskQueue<FP>>.Add() @ 0x9219308
0065888E4  ldr      w10, [x0, #0x1c]
0065888E8  ldr      x8, [x0, #0x10]
0065888EC  ldr      x9, [x9]
0065888F0  add      w10, w10, #1
0065888F4  str      w10, [x0, #0x1c]
0065888F8  cbz      x8, #0x6588bdc
0065888FC  ldrsw    x10, [x0, #0x18]
006588900  ldr      w11, [x8, #0x18]
006588904  cmp      w10, w11
006588908  b.hs     #0x658895c
00658890C  add      w9, w10, #1
006588910  add      x8, x8, x10, lsl #3
006588914  str      w9, [x0, #0x18]
006588918  str      x21, [x8, #0x20]!
00658891C  mov      x0, x8
006588920  mov      x1, x21
006588924  bl       #0x382bcb8 ; 
006588928  b        #0x6588970 ; 
00658892C  ldr      x6, [x5, #0x60]
006588930  and      w2, w24, #1
006588934  mov      x0, x19
006588938  mov      w1, w23
00658893C  mov      x3, x21
006588940  mov      x4, x22
006588944  ldp      x20, x19, [sp, #0x40]
006588948  ldp      x22, x21, [sp, #0x30]
00658894C  ldp      x24, x23, [sp, #0x20]
006588950  ldp      x26, x25, [sp, #0x10]
006588954  ldp      x30, x27, [sp], #0x50
006588958  br       x6
00658895C  ldr      x8, [x9, #0x20]
006588960  mov      x1, x21
006588964  ldr      x8, [x8, #0xc0]
006588968  ldr      x2, [x8, #0x70]
00658896C  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
006588970  adrp     x24, #0x9599000
006588974  ldrb     w8, [x24, #0x286]
006588978  cbnz     w8, #0x6588990
00658897C  adrp     x0, #0x8f07000
006588980  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006588984  bl       #0x382bd14 ; 
006588988  mov      w8, #1
00658898C  strb     w8, [x24, #0x286]
006588990  adrp     x25, #0x8f07000
006588994  ldr      x25, [x25, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006588998  ldr      x1, [x25]
00658899C  ldrb     w8, [x1, #0x53]
0065889A0  tbnz     w8, #5, #0x65889ac
0065889A4  ldr      x23, [x19, #0x80]
0065889A8  b        #0x65889bc ; 
0065889AC  ldr      x8, [x1, #0x60]
0065889B0  mov      x0, x19
0065889B4  blr      x8
0065889B8  mov      x23, x0
0065889BC  cbz      x23, #0x6588bdc
0065889C0  adrp     x26, #0x9599000
0065889C4  ldrb     w8, [x26, #0x2c3]
0065889C8  cbnz     w8, #0x65889e0
0065889CC  adrp     x0, #0x8f08000
0065889D0  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionId() @ 0x923fe90
0065889D4  bl       #0x382bd14 ; 
0065889D8  mov      w8, #1
0065889DC  strb     w8, [x26, #0x2c3]
0065889E0  adrp     x8, #0x8f08000
0065889E4  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionId() @ 0x923fe90
0065889E8  ldr      x1, [x8]
0065889EC  ldrb     w8, [x1, #0x53]
0065889F0  tbnz     w8, #5, #0x6588a00
0065889F4  add      x0, x23, #0x290
0065889F8  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065889FC  b        #0x6588a0c ; 
006588A00  ldr      x8, [x1, #0x60]
006588A04  mov      x0, x23
006588A08  blr      x8
006588A0C  str      w0, [x20, #0x30]
006588A10  adrp     x26, #0x8ee5000
006588A14  ldr      x26, [x26, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_TaskFactory() @ 0x923ffd0
006588A18  adrp     x27, #0x9591000
006588A1C  cbz      x22, #0x6588ad4
006588A20  ldrb     w8, [x24, #0x286]
006588A24  cbnz     w8, #0x6588a3c
006588A28  adrp     x0, #0x8f07000
006588A2C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006588A30  bl       #0x382bd14 ; 
006588A34  mov      w8, #1
006588A38  strb     w8, [x24, #0x286]
006588A3C  ldr      x1, [x25]
006588A40  ldrb     w8, [x1, #0x53]
006588A44  tbnz     w8, #5, #0x6588a50
006588A48  ldr      x23, [x19, #0x80]
006588A4C  b        #0x6588a60 ; 
006588A50  ldr      x8, [x1, #0x60]
006588A54  mov      x0, x19
006588A58  blr      x8
006588A5C  mov      x23, x0
006588A60  cbz      x23, #0x6588bdc
006588A64  ldrb     w8, [x27, #0xa5c]
006588A68  cbnz     w8, #0x6588a80
006588A6C  adrp     x0, #0x8ee5000
006588A70  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_TaskFactory() @ 0x923ffd0
006588A74  bl       #0x382bd14 ; 
006588A78  mov      w8, #1
006588A7C  strb     w8, [x27, #0xa5c]
006588A80  ldr      x1, [x26]
006588A84  ldrb     w8, [x1, #0x53]
006588A88  tbnz     w8, #5, #0x6588a94
006588A8C  ldr      x0, [x23, #0x218]
006588A90  b        #0x6588aa0 ; 
006588A94  ldr      x8, [x1, #0x60]
006588A98  mov      x0, x23
006588A9C  blr      x8
006588AA0  cbz      x0, #0x6588bdc
006588AA4  adrp     x8, #0x8f08000
006588AA8  ldr      x8, [x8, #0x240] ; GLOBAL Method$HotFix.Common.BehaviorTaskFactory.GetTask<Wait>() @ 0x9240738
006588AAC  ldr      x1, [x8]
006588AB0  bl       #0x454069c ; HotFix.Common.BehaviorTaskFactory$$GetTask<object>
006588AB4  cbz      x0, #0x6588bdc
006588AB8  str      x22, [x0, #0x58]
006588ABC  adrp     x8, #0x8f08000
006588AC0  ldr      x8, [x8, #0x250] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.AddTask() @ 0x922daf8
006588AC4  mov      x1, x0
006588AC8  mov      x0, x21
006588ACC  ldr      x2, [x8]
006588AD0  bl       #0x5570004 ; HotFix.Common.TaskQueue<FP>$$AddTask
006588AD4  ldrb     w8, [x24, #0x286]
006588AD8  cbnz     w8, #0x6588af0
006588ADC  adrp     x0, #0x8f07000
006588AE0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006588AE4  bl       #0x382bd14 ; 
006588AE8  mov      w8, #1
006588AEC  strb     w8, [x24, #0x286]
006588AF0  ldr      x1, [x25]
006588AF4  ldrb     w8, [x1, #0x53]
006588AF8  tbnz     w8, #5, #0x6588b04
006588AFC  ldr      x19, [x19, #0x80]
006588B00  b        #0x6588b14 ; 
006588B04  ldr      x8, [x1, #0x60]
006588B08  mov      x0, x19
006588B0C  blr      x8
006588B10  mov      x19, x0
006588B14  cbz      x19, #0x6588bdc
006588B18  ldrb     w8, [x27, #0xa5c]
006588B1C  cbnz     w8, #0x6588b34
006588B20  adrp     x0, #0x8ee5000
006588B24  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_TaskFactory() @ 0x923ffd0
006588B28  bl       #0x382bd14 ; 
006588B2C  mov      w8, #1
006588B30  strb     w8, [x27, #0xa5c]
006588B34  ldr      x1, [x26]
006588B38  ldrb     w8, [x1, #0x53]
006588B3C  tbnz     w8, #5, #0x6588b48
006588B40  ldr      x0, [x19, #0x218]
006588B44  b        #0x6588b54 ; 
006588B48  ldr      x8, [x1, #0x60]
006588B4C  mov      x0, x19
006588B50  blr      x8
006588B54  cbz      x0, #0x6588bdc
006588B58  adrp     x8, #0x8f08000
006588B5C  ldr      x8, [x8, #0x238] ; GLOBAL Method$HotFix.Common.BehaviorTaskFactory.GetTask<DoEventAction<FP>>() @ 0x92406d8
006588B60  ldr      x1, [x8]
006588B64  bl       #0x454069c ; HotFix.Common.BehaviorTaskFactory$$GetTask<object>
006588B68  adrp     x8, #0x8ec1000
006588B6C  ldr      x8, [x8, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
006588B70  mov      x19, x0
006588B74  ldr      x8, [x8]
006588B78  mov      x0, x8
006588B7C  bl       #0x382bfa0 ; 
006588B80  adrp     x8, #0x8f08000
006588B84  ldr      x8, [x8, #0x270] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0.<TriggerMissionEvent>b__0() @ 0x92d2d48
006588B88  mov      x1, x20
006588B8C  mov      x3, xzr
006588B90  mov      x22, x0
006588B94  ldr      x2, [x8]
006588B98  bl       #0x7ade578 ; System.Action$$.ctor
006588B9C  cbz      x19, #0x6588bdc
006588BA0  mov      x0, x19
006588BA4  str      x22, [x0, #0x50]!
006588BA8  mov      x1, x22
006588BAC  bl       #0x382bcb8 ; 
006588BB0  adrp     x8, #0x8f08000
006588BB4  ldr      x8, [x8, #0x250] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.AddTask() @ 0x922daf8
006588BB8  mov      x0, x21
006588BBC  mov      x1, x19
006588BC0  ldp      x20, x19, [sp, #0x40]
006588BC4  ldr      x2, [x8]
006588BC8  ldp      x22, x21, [sp, #0x30]
006588BCC  ldp      x24, x23, [sp, #0x20]
006588BD0  ldp      x26, x25, [sp, #0x10]
006588BD4  ldp      x30, x27, [sp], #0x50
006588BD8  b        #0x5570004 ; HotFix.Common.TaskQueue<FP>$$AddTask
006588BDC  bl       #0x382bfb8 ; 

