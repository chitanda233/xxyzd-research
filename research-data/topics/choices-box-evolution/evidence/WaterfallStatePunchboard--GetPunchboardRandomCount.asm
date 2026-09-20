; HotFix.BattleLogic.WaterfallStatePunchboard$$GetPunchboardRandomCount
; RVA 0x65B597C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B597C  stp      x30, x25, [sp, #-0x40]!
0065B5980  stp      x24, x23, [sp, #0x10]
0065B5984  stp      x22, x21, [sp, #0x20]
0065B5988  stp      x20, x19, [sp, #0x30]
0065B598C  adrp     x19, #0x9599000
0065B5990  adrp     x21, #0x8f09000
0065B5994  ldrb     w8, [x19, #0x433]
0065B5998  ldr      x21, [x21, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard.GetPunchboardRandomCount() @ 0x92c8850
0065B599C  mov      x20, x0
0065B59A0  tbnz     w8, #0, #0x65b59e8
0065B59A4  adrp     x0, #0x8f07000
0065B59A8  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B59AC  bl       #0x382bd14 ; 
0065B59B0  adrp     x0, #0x8f09000
0065B59B4  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065B59B8  bl       #0x382bd14 ; 
0065B59BC  adrp     x0, #0x8f09000
0065B59C0  ldr      x0, [x0, #0xc10] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<PunchboardParam>() @ 0x9286e70
0065B59C4  bl       #0x382bd14 ; 
0065B59C8  adrp     x0, #0x8ee2000
0065B59CC  ldr      x0, [x0, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo @ 0x91eb2e0
0065B59D0  bl       #0x382bd14 ; 
0065B59D4  adrp     x0, #0x8f09000
0065B59D8  ldr      x0, [x0, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard.GetPunchboardRandomCount() @ 0x92c8850
0065B59DC  bl       #0x382bd14 ; 
0065B59E0  mov      w8, #1
0065B59E4  strb     w8, [x19, #0x433]
0065B59E8  ldr      x1, [x21]
0065B59EC  ldrb     w8, [x1, #0x53]
0065B59F0  tbnz     w8, #5, #0x65b5a58
0065B59F4  ldr      x0, [x20, #0x18]
0065B59F8  cbz      x0, #0x65b5c6c
0065B59FC  adrp     x8, #0x8f07000
0065B5A00  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B5A04  ldr      x1, [x8]
0065B5A08  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065B5A0C  ldr      x8, [x20, #0x20]
0065B5A10  cbz      x8, #0x65b5c6c
0065B5A14  adrp     x23, #0x9599000
0065B5A18  ldrb     w9, [x23, #0x4b1]
0065B5A1C  ldr      w21, [x8, #0x14]
0065B5A20  mov      x19, x0
0065B5A24  cbnz     w9, #0x65b5a3c
0065B5A28  adrp     x0, #0x8f08000
0065B5A2C  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B5A30  bl       #0x382bd14 ; 
0065B5A34  mov      w8, #1
0065B5A38  strb     w8, [x23, #0x4b1]
0065B5A3C  adrp     x24, #0x8f08000
0065B5A40  ldr      x24, [x24, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B5A44  ldr      x1, [x24]
0065B5A48  ldrb     w8, [x1, #0x53]
0065B5A4C  tbnz     w8, #5, #0x65b5a74
0065B5A50  ldr      x22, [x20, #0x10]
0065B5A54  b        #0x65b5a84 ; 
0065B5A58  ldr      x2, [x1, #0x60]
0065B5A5C  mov      x0, x20
0065B5A60  ldp      x20, x19, [sp, #0x30]
0065B5A64  ldp      x22, x21, [sp, #0x20]
0065B5A68  ldp      x24, x23, [sp, #0x10]
0065B5A6C  ldp      x30, x25, [sp], #0x40
0065B5A70  br       x2
0065B5A74  ldr      x8, [x1, #0x60]
0065B5A78  mov      x0, x20
0065B5A7C  blr      x8
0065B5A80  mov      x22, x0
0065B5A84  cbz      x22, #0x65b5c6c
0065B5A88  adrp     x25, #0x9598000
0065B5A8C  ldrb     w8, [x25, #0xfcc]
0065B5A90  cbnz     w8, #0x65b5aa8
0065B5A94  adrp     x0, #0x8f06000
0065B5A98  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0065B5A9C  bl       #0x382bd14 ; 
0065B5AA0  mov      w8, #1
0065B5AA4  strb     w8, [x25, #0xfcc]
0065B5AA8  adrp     x8, #0x8f06000
0065B5AAC  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0065B5AB0  ldr      x1, [x8]
0065B5AB4  ldrb     w8, [x1, #0x53]
0065B5AB8  tbnz     w8, #5, #0x65b5ac4
0065B5ABC  ldr      x22, [x22, #0x200]
0065B5AC0  b        #0x65b5ad4 ; 
0065B5AC4  ldr      x8, [x1, #0x60]
0065B5AC8  mov      x0, x22
0065B5ACC  blr      x8
0065B5AD0  mov      x22, x0
0065B5AD4  ldrb     w8, [x23, #0x4b1]
0065B5AD8  cbnz     w8, #0x65b5af0
0065B5ADC  adrp     x0, #0x8f08000
0065B5AE0  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B5AE4  bl       #0x382bd14 ; 
0065B5AE8  mov      w8, #1
0065B5AEC  strb     w8, [x23, #0x4b1]
0065B5AF0  ldr      x1, [x24]
0065B5AF4  ldrb     w8, [x1, #0x53]
0065B5AF8  tbnz     w8, #5, #0x65b5b04
0065B5AFC  ldr      x0, [x20, #0x10]
0065B5B00  b        #0x65b5b10 ; 
0065B5B04  ldr      x8, [x1, #0x60]
0065B5B08  mov      x0, x20
0065B5B0C  blr      x8
0065B5B10  cbz      x0, #0x65b5c6c
0065B5B14  ldr      w1, [x0, #0x1c8]
0065B5B18  mov      x0, x22
0065B5B1C  mov      w2, w21
0065B5B20  mov      x3, xzr
0065B5B24  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065B5B28  cbz      x0, #0x65b5c4c
0065B5B2C  adrp     x21, #0x8f09000
0065B5B30  ldr      x8, [x0]
0065B5B34  ldr      x21, [x21, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065B5B38  mov      x20, x0
0065B5B3C  ldrh     w9, [x8, #0x12e]
0065B5B40  ldr      x1, [x21]
0065B5B44  cbz      x9, #0x65b5b68
0065B5B48  ldr      x10, [x8, #0xb0]
0065B5B4C  add      x10, x10, #8
0065B5B50  ldur     x11, [x10, #-8]
0065B5B54  cmp      x11, x1
0065B5B58  b.eq     #0x65b5b78
0065B5B5C  subs     x9, x9, #1
0065B5B60  add      x10, x10, #0x10
0065B5B64  b.ne     #0x65b5b50
0065B5B68  mov      w2, #8
0065B5B6C  mov      x0, x20
0065B5B70  bl       #0x3a7e710 ; 
0065B5B74  b        #0x65b5b88 ; 
0065B5B78  ldr      w9, [x10]
0065B5B7C  add      w9, w9, #8
0065B5B80  add      x8, x8, w9, sxtw #4
0065B5B84  add      x0, x8, #0x138
0065B5B88  ldp      x8, x1, [x0]
0065B5B8C  mov      x0, x20
0065B5B90  blr      x8
0065B5B94  cmp      w0, #9
0065B5B98  b.ne     #0x65b5c4c
0065B5B9C  ldr      x8, [x20]
0065B5BA0  ldr      x1, [x21]
0065B5BA4  ldrh     w9, [x8, #0x12e]
0065B5BA8  cbz      x9, #0x65b5bcc
0065B5BAC  ldr      x10, [x8, #0xb0]
0065B5BB0  add      x10, x10, #8
0065B5BB4  ldur     x11, [x10, #-8]
0065B5BB8  cmp      x11, x1
0065B5BBC  b.eq     #0x65b5bdc
0065B5BC0  subs     x9, x9, #1
0065B5BC4  add      x10, x10, #0x10
0065B5BC8  b.ne     #0x65b5bb4
0065B5BCC  mov      w2, #0x2a
0065B5BD0  mov      x0, x20
0065B5BD4  bl       #0x3a7e710 ; 
0065B5BD8  b        #0x65b5bec ; 
0065B5BDC  ldr      w9, [x10]
0065B5BE0  add      w9, w9, #0x2a
0065B5BE4  add      x8, x8, w9, sxtw #4
0065B5BE8  add      x0, x8, #0x138
0065B5BEC  ldp      x8, x1, [x0]
0065B5BF0  mov      x0, x20
0065B5BF4  blr      x8
0065B5BF8  adrp     x8, #0x8ee2000
0065B5BFC  ldr      x8, [x8, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo @ 0x91eb2e0
0065B5C00  mov      x20, x0
0065B5C04  ldr      x8, [x8]
0065B5C08  ldr      w9, [x8, #0xe0]
0065B5C0C  cbnz     w9, #0x65b5c18
0065B5C10  mov      x0, x8
0065B5C14  bl       #0x382be8c ; 
0065B5C18  adrp     x8, #0x8f09000
0065B5C1C  ldr      x8, [x8, #0xc10] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<PunchboardParam>() @ 0x9286e70
0065B5C20  mov      x0, x20
0065B5C24  ldr      x1, [x8]
0065B5C28  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
0065B5C2C  cbz      x0, #0x65b5c4c
0065B5C30  ldr      w0, [x0, #0x10]
0065B5C34  cbz      w0, #0x65b5c4c
0065B5C38  ldp      x20, x19, [sp, #0x30]
0065B5C3C  ldp      x22, x21, [sp, #0x20]
0065B5C40  ldp      x24, x23, [sp, #0x10]
0065B5C44  ldp      x30, x25, [sp], #0x40
0065B5C48  ret      
0065B5C4C  cbz      x19, #0x65b5c6c
0065B5C50  mov      x0, x19
0065B5C54  ldp      x20, x19, [sp, #0x30]
0065B5C58  ldp      x22, x21, [sp, #0x20]
0065B5C5C  ldp      x24, x23, [sp, #0x10]
0065B5C60  mov      x1, xzr
0065B5C64  ldp      x30, x25, [sp], #0x40
0065B5C68  b        #0x686f88c ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetPunchboardRandomCount
0065B5C6C  bl       #0x382bfb8 ; 

