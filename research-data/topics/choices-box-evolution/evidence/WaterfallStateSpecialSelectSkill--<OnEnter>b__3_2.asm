; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$<OnEnter>b__3_2
; RVA 0x65B7ED4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B7ED4  stp      x30, x25, [sp, #-0x40]!
0065B7ED8  stp      x24, x23, [sp, #0x10]
0065B7EDC  stp      x22, x21, [sp, #0x20]
0065B7EE0  stp      x20, x19, [sp, #0x30]
0065B7EE4  adrp     x20, #0x9599000
0065B7EE8  adrp     x21, #0x8f09000
0065B7EEC  ldrb     w8, [x20, #0x44f]
0065B7EF0  ldr      x21, [x21, #0xcc8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_2() @ 0x92c88d8
0065B7EF4  mov      x19, x0
0065B7EF8  tbnz     w8, #0, #0x65b7f34
0065B7EFC  adrp     x0, #0x8f07000
0065B7F00  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B7F04  bl       #0x382bd14 ; 
0065B7F08  adrp     x0, #0x8f08000
0065B7F0C  ldr      x0, [x0, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
0065B7F10  bl       #0x382bd14 ; 
0065B7F14  adrp     x0, #0x8f08000
0065B7F18  ldr      x0, [x0, #0xf48] ; GLOBAL HotFix.BattleLogic.WaterfallBattleManager_TypeInfo @ 0x91f48a8
0065B7F1C  bl       #0x382bd14 ; 
0065B7F20  adrp     x0, #0x8f09000
0065B7F24  ldr      x0, [x0, #0xcc8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_2() @ 0x92c88d8
0065B7F28  bl       #0x382bd14 ; 
0065B7F2C  mov      w8, #1
0065B7F30  strb     w8, [x20, #0x44f]
0065B7F34  ldr      x1, [x21]
0065B7F38  ldrb     w8, [x1, #0x53]
0065B7F3C  tbnz     w8, #5, #0x65b7f7c
0065B7F40  adrp     x24, #0x9599000
0065B7F44  ldrb     w8, [x24, #0x4b1]
0065B7F48  cbnz     w8, #0x65b7f60
0065B7F4C  adrp     x0, #0x8f08000
0065B7F50  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B7F54  bl       #0x382bd14 ; 
0065B7F58  mov      w8, #1
0065B7F5C  strb     w8, [x24, #0x4b1]
0065B7F60  adrp     x25, #0x8f08000
0065B7F64  ldr      x25, [x25, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B7F68  ldr      x1, [x25]
0065B7F6C  ldrb     w8, [x1, #0x53]
0065B7F70  tbnz     w8, #5, #0x65b7f98
0065B7F74  ldr      x20, [x19, #0x10]
0065B7F78  b        #0x65b7fa8 ; 
0065B7F7C  ldr      x2, [x1, #0x60]
0065B7F80  mov      x0, x19
0065B7F84  ldp      x20, x19, [sp, #0x30]
0065B7F88  ldp      x22, x21, [sp, #0x20]
0065B7F8C  ldp      x24, x23, [sp, #0x10]
0065B7F90  ldp      x30, x25, [sp], #0x40
0065B7F94  br       x2
0065B7F98  ldr      x8, [x1, #0x60]
0065B7F9C  mov      x0, x19
0065B7FA0  blr      x8
0065B7FA4  mov      x20, x0
0065B7FA8  cbz      x20, #0x65b822c
0065B7FAC  adrp     x22, #0x9598000
0065B7FB0  ldrb     w8, [x22, #0xfc4]
0065B7FB4  cbnz     w8, #0x65b7fcc
0065B7FB8  adrp     x0, #0x8f05000
0065B7FBC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B7FC0  bl       #0x382bd14 ; 
0065B7FC4  mov      w8, #1
0065B7FC8  strb     w8, [x22, #0xfc4]
0065B7FCC  adrp     x23, #0x8f05000
0065B7FD0  ldr      x23, [x23, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B7FD4  ldr      x1, [x23]
0065B7FD8  ldrb     w8, [x1, #0x53]
0065B7FDC  tbnz     w8, #5, #0x65b7fe8
0065B7FE0  ldr      x0, [x20, #0x220]
0065B7FE4  b        #0x65b7ff4 ; 
0065B7FE8  ldr      x8, [x1, #0x60]
0065B7FEC  mov      x0, x20
0065B7FF0  blr      x8
0065B7FF4  cbz      x0, #0x65b822c
0065B7FF8  mov      w1, #1
0065B7FFC  mov      w3, #1
0065B8000  mov      x2, xzr
0065B8004  mov      x4, xzr
0065B8008  bl       #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
0065B800C  ldr      x0, [x19, #0x18]
0065B8010  cbz      x0, #0x65b822c
0065B8014  adrp     x8, #0x8f07000
0065B8018  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B801C  ldr      x1, [x8]
0065B8020  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065B8024  cbz      x0, #0x65b822c
0065B8028  mov      x1, xzr
0065B802C  bl       #0x6870404 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckNeedOpenSpecialSkill
0065B8030  ldrb     w8, [x24, #0x4b1]
0065B8034  mov      w21, w0
0065B8038  cbnz     w8, #0x65b8050
0065B803C  adrp     x0, #0x8f08000
0065B8040  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B8044  bl       #0x382bd14 ; 
0065B8048  mov      w8, #1
0065B804C  strb     w8, [x24, #0x4b1]
0065B8050  ldr      x1, [x25]
0065B8054  ldrb     w8, [x1, #0x53]
0065B8058  tbnz     w8, #5, #0x65b8064
0065B805C  ldr      x20, [x19, #0x10]
0065B8060  b        #0x65b8074 ; 
0065B8064  ldr      x8, [x1, #0x60]
0065B8068  mov      x0, x19
0065B806C  blr      x8
0065B8070  mov      x20, x0
0065B8074  cbz      x20, #0x65b822c
0065B8078  tbz      w21, #0, #0x65b80ac
0065B807C  ldrb     w8, [x22, #0xfc4]
0065B8080  cbnz     w8, #0x65b8098
0065B8084  adrp     x0, #0x8f05000
0065B8088  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B808C  bl       #0x382bd14 ; 
0065B8090  mov      w8, #1
0065B8094  strb     w8, [x22, #0xfc4]
0065B8098  ldr      x1, [x23]
0065B809C  ldrb     w8, [x1, #0x53]
0065B80A0  tbnz     w8, #5, #0x65b80fc
0065B80A4  ldr      x0, [x20, #0x220]
0065B80A8  b        #0x65b8108 ; 
0065B80AC  ldr      x20, [x20, #0x3b8]
0065B80B0  cbz      x20, #0x65b822c
0065B80B4  adrp     x10, #0x8f08000
0065B80B8  ldr      x8, [x20]
0065B80BC  ldr      x10, [x10, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
0065B80C0  ldrh     w9, [x8, #0x12e]
0065B80C4  ldr      x1, [x10]
0065B80C8  cbz      x9, #0x65b80ec
0065B80CC  ldr      x10, [x8, #0xb0]
0065B80D0  add      x10, x10, #8
0065B80D4  ldur     x11, [x10, #-8]
0065B80D8  cmp      x11, x1
0065B80DC  b.eq     #0x65b8130
0065B80E0  subs     x9, x9, #1
0065B80E4  add      x10, x10, #0x10
0065B80E8  b.ne     #0x65b80d4
0065B80EC  mov      w2, #0xd
0065B80F0  mov      x0, x20
0065B80F4  bl       #0x3a7e710 ; 
0065B80F8  b        #0x65b8140 ; 
0065B80FC  ldr      x8, [x1, #0x60]
0065B8100  mov      x0, x20
0065B8104  blr      x8
0065B8108  cbz      x0, #0x65b822c
0065B810C  ldp      x20, x19, [sp, #0x30]
0065B8110  ldp      x22, x21, [sp, #0x20]
0065B8114  ldp      x24, x23, [sp, #0x10]
0065B8118  mov      w1, #0xc
0065B811C  mov      x2, xzr
0065B8120  mov      w3, wzr
0065B8124  mov      x4, xzr
0065B8128  ldp      x30, x25, [sp], #0x40
0065B812C  b        #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
0065B8130  ldr      w9, [x10]
0065B8134  add      w9, w9, #0xd
0065B8138  add      x8, x8, w9, sxtw #4
0065B813C  add      x0, x8, #0x138
0065B8140  ldp      x8, x1, [x0]
0065B8144  mov      x0, x20
0065B8148  blr      x8
0065B814C  cmp      w0, #1
0065B8150  b.ne     #0x65b8184
0065B8154  ldrb     w8, [x24, #0x4b1]
0065B8158  cbnz     w8, #0x65b8170
0065B815C  adrp     x0, #0x8f08000
0065B8160  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B8164  bl       #0x382bd14 ; 
0065B8168  mov      w8, #1
0065B816C  strb     w8, [x24, #0x4b1]
0065B8170  ldr      x1, [x25]
0065B8174  ldrb     w8, [x1, #0x53]
0065B8178  tbnz     w8, #5, #0x65b8198
0065B817C  ldr      x19, [x19, #0x10]
0065B8180  b        #0x65b81a8 ; 
0065B8184  ldp      x20, x19, [sp, #0x30]
0065B8188  ldp      x22, x21, [sp, #0x20]
0065B818C  ldp      x24, x23, [sp, #0x10]
0065B8190  ldp      x30, x25, [sp], #0x40
0065B8194  ret      
0065B8198  ldr      x8, [x1, #0x60]
0065B819C  mov      x0, x19
0065B81A0  blr      x8
0065B81A4  mov      x19, x0
0065B81A8  cbz      x19, #0x65b822c
0065B81AC  ldrb     w8, [x22, #0xfc4]
0065B81B0  cbnz     w8, #0x65b81c8
0065B81B4  adrp     x0, #0x8f05000
0065B81B8  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B81BC  bl       #0x382bd14 ; 
0065B81C0  mov      w8, #1
0065B81C4  strb     w8, [x22, #0xfc4]
0065B81C8  ldr      x1, [x23]
0065B81CC  ldrb     w8, [x1, #0x53]
0065B81D0  tbnz     w8, #5, #0x65b81dc
0065B81D4  ldr      x0, [x19, #0x220]
0065B81D8  b        #0x65b81e8 ; 
0065B81DC  ldr      x8, [x1, #0x60]
0065B81E0  mov      x0, x19
0065B81E4  blr      x8
0065B81E8  cbz      x0, #0x65b822c
0065B81EC  adrp     x9, #0x8f08000
0065B81F0  ldr      x9, [x9, #0xf48] ; GLOBAL HotFix.BattleLogic.WaterfallBattleManager_TypeInfo @ 0x91f48a8
0065B81F4  ldr      x8, [x0]
0065B81F8  ldr      x1, [x9]
0065B81FC  ldrb     w10, [x8, #0x130]
0065B8200  ldrb     w9, [x1, #0x130]
0065B8204  cmp      w10, w9
0065B8208  b.lo     #0x65b8230
0065B820C  ldr      x10, [x8, #0xc8]
0065B8210  add      x9, x10, x9, lsl #3
0065B8214  ldur     x9, [x9, #-8]
0065B8218  cmp      x9, x1
0065B821C  b.ne     #0x65b8230
0065B8220  ldr      x2, [x8, #0x288]
0065B8224  ldr      x1, [x8, #0x290]
0065B8228  b        #0x65b7f84 ; 
0065B822C  bl       #0x382bfb8 ; 
0065B8230  bl       #0x382c354 ; 

