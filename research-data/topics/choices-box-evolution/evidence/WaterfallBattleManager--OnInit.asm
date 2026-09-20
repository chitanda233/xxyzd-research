; HotFix.BattleLogic.WaterfallBattleManager$$OnInit
; RVA 0x65C79A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C79A4  stp      x30, x27, [sp, #-0x50]!
0065C79A8  stp      x26, x25, [sp, #0x10]
0065C79AC  stp      x24, x23, [sp, #0x20]
0065C79B0  stp      x22, x21, [sp, #0x30]
0065C79B4  stp      x20, x19, [sp, #0x40]
0065C79B8  adrp     x20, #0x9599000
0065C79BC  adrp     x21, #0x8f0a000
0065C79C0  ldrb     w8, [x20, #0x569]
0065C79C4  ldr      x21, [x21, #0x6b8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.OnInit() @ 0x92c8158
0065C79C8  mov      x19, x0
0065C79CC  tbnz     w8, #0, #0x65c7aa4
0065C79D0  adrp     x0, #0x8f0a000
0065C79D4  ldr      x0, [x0, #0x68] ; GLOBAL HotFix.BattleLogic.BattleState[]_TypeInfo @ 0x91debd0
0065C79D8  bl       #0x382bd14 ; 
0065C79DC  adrp     x0, #0x8f0a000
0065C79E0  ldr      x0, [x0, #0x6b8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.OnInit() @ 0x92c8158
0065C79E4  bl       #0x382bd14 ; 
0065C79E8  adrp     x0, #0x8f05000
0065C79EC  ldr      x0, [x0, #0xfd0] ; GLOBAL HotFix.BattleLogic.WaterfallInitState_TypeInfo @ 0x91f48b8
0065C79F0  bl       #0x382bd14 ; 
0065C79F4  adrp     x0, #0x8f0a000
0065C79F8  ldr      x0, [x0, #0x6c0] ; GLOBAL HotFix.BattleLogic.WaterfallSpecialEndState_TypeInfo @ 0x91f48f8
0065C79FC  bl       #0x382bd14 ; 
0065C7A00  adrp     x0, #0x8f0a000
0065C7A04  ldr      x0, [x0, #0x6c8] ; GLOBAL HotFix.BattleLogic.WaterfallStateAngel_TypeInfo @ 0x91f4900
0065C7A08  bl       #0x382bd14 ; 
0065C7A0C  adrp     x0, #0x8f0a000
0065C7A10  ldr      x0, [x0, #0x6d0] ; GLOBAL HotFix.BattleLogic.WaterfallStateBattle_TypeInfo @ 0x91f4908
0065C7A14  bl       #0x382bd14 ; 
0065C7A18  adrp     x0, #0x8f0a000
0065C7A1C  ldr      x0, [x0, #0x6d8] ; GLOBAL HotFix.BattleLogic.WaterfallStateBox_TypeInfo @ 0x91f4910
0065C7A20  bl       #0x382bd14 ; 
0065C7A24  adrp     x0, #0x8f0a000
0065C7A28  ldr      x0, [x0, #0x6e0] ; GLOBAL HotFix.BattleLogic.WaterfallStateContractDevil_TypeInfo @ 0x91f4918
0065C7A2C  bl       #0x382bd14 ; 
0065C7A30  adrp     x0, #0x8f0a000
0065C7A34  ldr      x0, [x0, #0x6e8] ; GLOBAL HotFix.BattleLogic.WaterfallStateEnd_TypeInfo @ 0x91f4920
0065C7A38  bl       #0x382bd14 ; 
0065C7A3C  adrp     x0, #0x8f0a000
0065C7A40  ldr      x0, [x0, #0x6f0] ; GLOBAL HotFix.BattleLogic.WaterfallStateFortune_TypeInfo @ 0x91f4928
0065C7A44  bl       #0x382bd14 ; 
0065C7A48  adrp     x0, #0x8f0a000
0065C7A4C  ldr      x0, [x0, #0x6f8] ; GLOBAL HotFix.BattleLogic.WaterfallStateGoldFortune_TypeInfo @ 0x91f4930
0065C7A50  bl       #0x382bd14 ; 
0065C7A54  adrp     x0, #0x8f0a000
0065C7A58  ldr      x0, [x0, #0x700] ; GLOBAL HotFix.BattleLogic.WaterfallStateHeroDie_TypeInfo @ 0x91f4938
0065C7A5C  bl       #0x382bd14 ; 
0065C7A60  adrp     x0, #0x8f0a000
0065C7A64  ldr      x0, [x0, #0x708] ; GLOBAL HotFix.BattleLogic.WaterfallStateNpcDrop_TypeInfo @ 0x91f4940
0065C7A68  bl       #0x382bd14 ; 
0065C7A6C  adrp     x0, #0x8f0a000
0065C7A70  ldr      x0, [x0, #0x710] ; GLOBAL HotFix.BattleLogic.WaterfallStatePunchboard_TypeInfo @ 0x91f4948
0065C7A74  bl       #0x382bd14 ; 
0065C7A78  adrp     x0, #0x8f0a000
0065C7A7C  ldr      x0, [x0, #0x718] ; GLOBAL HotFix.BattleLogic.WaterfallStateSelectSkill_TypeInfo @ 0x91f4950
0065C7A80  bl       #0x382bd14 ; 
0065C7A84  adrp     x0, #0x8f0a000
0065C7A88  ldr      x0, [x0, #0x720] ; GLOBAL HotFix.BattleLogic.WaterfallStateSimpleGold_TypeInfo @ 0x91f4958
0065C7A8C  bl       #0x382bd14 ; 
0065C7A90  adrp     x0, #0x8f0a000
0065C7A94  ldr      x0, [x0, #0x728] ; GLOBAL HotFix.BattleLogic.WaterfallStateSpecialSelectSkill_TypeInfo @ 0x91f4960
0065C7A98  bl       #0x382bd14 ; 
0065C7A9C  mov      w8, #1
0065C7AA0  strb     w8, [x20, #0x569]
0065C7AA4  ldr      x1, [x21]
0065C7AA8  ldrb     w8, [x1, #0x53]
0065C7AAC  tbnz     w8, #5, #0x65c7b34
0065C7AB0  adrp     x8, #0x8f0a000
0065C7AB4  ldr      x8, [x8, #0x68] ; GLOBAL HotFix.BattleLogic.BattleState[]_TypeInfo @ 0x91debd0
0065C7AB8  adrp     x22, #0x8f05000
0065C7ABC  mov      w1, #0xf
0065C7AC0  ldr      x0, [x8]
0065C7AC4  ldr      x22, [x22, #0xfd0] ; GLOBAL HotFix.BattleLogic.WaterfallInitState_TypeInfo @ 0x91f48b8
0065C7AC8  bl       #0x382bdfc ; 
0065C7ACC  mov      x20, x19
0065C7AD0  str      x0, [x20, #0x10]!
0065C7AD4  mov      x1, x0
0065C7AD8  mov      x0, x20
0065C7ADC  bl       #0x382bcb8 ; 
0065C7AE0  ldr      x0, [x22]
0065C7AE4  ldr      x21, [x20]
0065C7AE8  bl       #0x382bfa0 ; 
0065C7AEC  mov      x1, xzr
0065C7AF0  mov      x22, x0
0065C7AF4  bl       #0x65a8cd4 ; HotFix.BattleLogic.WaterfallInitState$$.ctor
0065C7AF8  adrp     x24, #0x9599000
0065C7AFC  ldrb     w8, [x24, #0x286]
0065C7B00  cbnz     w8, #0x65c7b18
0065C7B04  adrp     x0, #0x8f07000
0065C7B08  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C7B0C  bl       #0x382bd14 ; 
0065C7B10  mov      w8, #1
0065C7B14  strb     w8, [x24, #0x286]
0065C7B18  adrp     x26, #0x8f07000
0065C7B1C  ldr      x26, [x26, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C7B20  ldr      x1, [x26]
0065C7B24  ldrb     w8, [x1, #0x53]
0065C7B28  tbnz     w8, #5, #0x65c7b54
0065C7B2C  ldr      x23, [x19, #0x80]
0065C7B30  b        #0x65c7b64 ; 
0065C7B34  ldr      x2, [x1, #0x60]
0065C7B38  mov      x0, x19
0065C7B3C  ldp      x20, x19, [sp, #0x40]
0065C7B40  ldp      x22, x21, [sp, #0x30]
0065C7B44  ldp      x24, x23, [sp, #0x20]
0065C7B48  ldp      x26, x25, [sp, #0x10]
0065C7B4C  ldp      x30, x27, [sp], #0x50
0065C7B50  br       x2
0065C7B54  ldr      x8, [x1, #0x60]
0065C7B58  mov      x0, x19
0065C7B5C  blr      x8
0065C7B60  mov      x23, x0
0065C7B64  cbz      x22, #0x65c887c
0065C7B68  adrp     x25, #0x9599000
0065C7B6C  ldrb     w8, [x25, #0x4f5]
0065C7B70  cbnz     w8, #0x65c7b88
0065C7B74  adrp     x0, #0x8f09000
0065C7B78  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C7B7C  bl       #0x382bd14 ; 
0065C7B80  mov      w8, #1
0065C7B84  strb     w8, [x25, #0x4f5]
0065C7B88  adrp     x27, #0x8f09000
0065C7B8C  ldr      x27, [x27, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C7B90  ldr      x2, [x27]
0065C7B94  ldrb     w8, [x2, #0x53]
0065C7B98  tbnz     w8, #5, #0x65c7bb0
0065C7B9C  mov      x0, x22
0065C7BA0  str      x23, [x0, #0x10]!
0065C7BA4  mov      x1, x23
0065C7BA8  bl       #0x382bcb8 ; 
0065C7BAC  b        #0x65c7bc0 ; 
0065C7BB0  ldr      x8, [x2, #0x60]
0065C7BB4  mov      x0, x22
0065C7BB8  mov      x1, x23
0065C7BBC  blr      x8
0065C7BC0  cbz      x21, #0x65c887c
0065C7BC4  ldr      x8, [x21]
0065C7BC8  mov      x0, x22
0065C7BCC  ldr      x1, [x8, #0x40]
0065C7BD0  bl       #0x382be90 ; 
0065C7BD4  cbz      x0, #0x65c8880
0065C7BD8  ldr      w8, [x21, #0x18]
0065C7BDC  cbz      w8, #0x65c888c
0065C7BE0  str      x22, [x21, #0x20]!
0065C7BE4  mov      x0, x21
0065C7BE8  mov      x1, x22
0065C7BEC  bl       #0x382bcb8 ; 
0065C7BF0  adrp     x8, #0x8f0a000
0065C7BF4  ldr      x21, [x20]
0065C7BF8  ldr      x8, [x8, #0x708] ; GLOBAL HotFix.BattleLogic.WaterfallStateNpcDrop_TypeInfo @ 0x91f4940
0065C7BFC  ldr      x0, [x8]
0065C7C00  bl       #0x382bfa0 ; 
0065C7C04  mov      x1, xzr
0065C7C08  mov      x22, x0
0065C7C0C  bl       #0x65b55d4 ; HotFix.BattleLogic.WaterfallStateNpcDrop$$.ctor
0065C7C10  ldrb     w8, [x24, #0x286]
0065C7C14  cbnz     w8, #0x65c7c2c
0065C7C18  adrp     x0, #0x8f07000
0065C7C1C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C7C20  bl       #0x382bd14 ; 
0065C7C24  mov      w8, #1
0065C7C28  strb     w8, [x24, #0x286]
0065C7C2C  ldr      x1, [x26]
0065C7C30  ldrb     w8, [x1, #0x53]
0065C7C34  tbnz     w8, #5, #0x65c7c40
0065C7C38  ldr      x23, [x19, #0x80]
0065C7C3C  b        #0x65c7c50 ; 
0065C7C40  ldr      x8, [x1, #0x60]
0065C7C44  mov      x0, x19
0065C7C48  blr      x8
0065C7C4C  mov      x23, x0
0065C7C50  cbz      x22, #0x65c887c
0065C7C54  ldrb     w8, [x25, #0x4f5]
0065C7C58  cbnz     w8, #0x65c7c70
0065C7C5C  adrp     x0, #0x8f09000
0065C7C60  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C7C64  bl       #0x382bd14 ; 
0065C7C68  mov      w8, #1
0065C7C6C  strb     w8, [x25, #0x4f5]
0065C7C70  ldr      x2, [x27]
0065C7C74  ldrb     w8, [x2, #0x53]
0065C7C78  tbnz     w8, #5, #0x65c7c90
0065C7C7C  mov      x0, x22
0065C7C80  str      x23, [x0, #0x10]!
0065C7C84  mov      x1, x23
0065C7C88  bl       #0x382bcb8 ; 
0065C7C8C  b        #0x65c7ca0 ; 
0065C7C90  ldr      x8, [x2, #0x60]
0065C7C94  mov      x0, x22
0065C7C98  mov      x1, x23
0065C7C9C  blr      x8
0065C7CA0  cbz      x21, #0x65c887c
0065C7CA4  ldr      x8, [x21]
0065C7CA8  mov      x0, x22
0065C7CAC  ldr      x1, [x8, #0x40]
0065C7CB0  bl       #0x382be90 ; 
0065C7CB4  cbz      x0, #0x65c8880
0065C7CB8  ldr      w8, [x21, #0x18]
0065C7CBC  cmp      w8, #2
0065C7CC0  b.ls     #0x65c888c
0065C7CC4  str      x22, [x21, #0x30]!
0065C7CC8  mov      x0, x21
0065C7CCC  mov      x1, x22
0065C7CD0  bl       #0x382bcb8 ; 
0065C7CD4  adrp     x8, #0x8f0a000
0065C7CD8  ldr      x21, [x20]
0065C7CDC  ldr      x8, [x8, #0x6d0] ; GLOBAL HotFix.BattleLogic.WaterfallStateBattle_TypeInfo @ 0x91f4908
0065C7CE0  ldr      x0, [x8]
0065C7CE4  bl       #0x382bfa0 ; 
0065C7CE8  mov      x1, xzr
0065C7CEC  mov      x22, x0
0065C7CF0  bl       #0x65b4f14 ; HotFix.BattleLogic.WaterfallStateBattle$$.ctor
0065C7CF4  ldrb     w8, [x24, #0x286]
0065C7CF8  cbnz     w8, #0x65c7d10
0065C7CFC  adrp     x0, #0x8f07000
0065C7D00  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C7D04  bl       #0x382bd14 ; 
0065C7D08  mov      w8, #1
0065C7D0C  strb     w8, [x24, #0x286]
0065C7D10  ldr      x1, [x26]
0065C7D14  ldrb     w8, [x1, #0x53]
0065C7D18  tbnz     w8, #5, #0x65c7d24
0065C7D1C  ldr      x23, [x19, #0x80]
0065C7D20  b        #0x65c7d34 ; 
0065C7D24  ldr      x8, [x1, #0x60]
0065C7D28  mov      x0, x19
0065C7D2C  blr      x8
0065C7D30  mov      x23, x0
0065C7D34  cbz      x22, #0x65c887c
0065C7D38  ldrb     w8, [x25, #0x4f5]
0065C7D3C  cbnz     w8, #0x65c7d54
0065C7D40  adrp     x0, #0x8f09000
0065C7D44  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C7D48  bl       #0x382bd14 ; 
0065C7D4C  mov      w8, #1
0065C7D50  strb     w8, [x25, #0x4f5]
0065C7D54  ldr      x2, [x27]
0065C7D58  ldrb     w8, [x2, #0x53]
0065C7D5C  tbnz     w8, #5, #0x65c7d74
0065C7D60  mov      x0, x22
0065C7D64  str      x23, [x0, #0x10]!
0065C7D68  mov      x1, x23
0065C7D6C  bl       #0x382bcb8 ; 
0065C7D70  b        #0x65c7d84 ; 
0065C7D74  ldr      x8, [x2, #0x60]
0065C7D78  mov      x0, x22
0065C7D7C  mov      x1, x23
0065C7D80  blr      x8
0065C7D84  cbz      x21, #0x65c887c
0065C7D88  ldr      x8, [x21]
0065C7D8C  mov      x0, x22
0065C7D90  ldr      x1, [x8, #0x40]
0065C7D94  bl       #0x382be90 ; 
0065C7D98  cbz      x0, #0x65c8880
0065C7D9C  ldr      w8, [x21, #0x18]
0065C7DA0  cmp      w8, #1
0065C7DA4  b.ls     #0x65c888c
0065C7DA8  str      x22, [x21, #0x28]!
0065C7DAC  mov      x0, x21
0065C7DB0  mov      x1, x22
0065C7DB4  bl       #0x382bcb8 ; 
0065C7DB8  adrp     x8, #0x8f0a000
0065C7DBC  ldr      x21, [x20]
0065C7DC0  ldr      x8, [x8, #0x728] ; GLOBAL HotFix.BattleLogic.WaterfallStateSpecialSelectSkill_TypeInfo @ 0x91f4960
0065C7DC4  ldr      x0, [x8]
0065C7DC8  bl       #0x382bfa0 ; 
0065C7DCC  mov      x1, xzr
0065C7DD0  mov      x22, x0
0065C7DD4  bl       #0x65a90f8 ; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$.ctor
0065C7DD8  ldrb     w8, [x24, #0x286]
0065C7DDC  cbnz     w8, #0x65c7df4
0065C7DE0  adrp     x0, #0x8f07000
0065C7DE4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C7DE8  bl       #0x382bd14 ; 
0065C7DEC  mov      w8, #1
0065C7DF0  strb     w8, [x24, #0x286]
0065C7DF4  ldr      x1, [x26]
0065C7DF8  ldrb     w8, [x1, #0x53]
0065C7DFC  tbnz     w8, #5, #0x65c7e08
0065C7E00  ldr      x23, [x19, #0x80]
0065C7E04  b        #0x65c7e18 ; 
0065C7E08  ldr      x8, [x1, #0x60]
0065C7E0C  mov      x0, x19
0065C7E10  blr      x8
0065C7E14  mov      x23, x0
0065C7E18  cbz      x22, #0x65c887c
0065C7E1C  ldrb     w8, [x25, #0x4f5]
0065C7E20  cbnz     w8, #0x65c7e38
0065C7E24  adrp     x0, #0x8f09000
0065C7E28  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C7E2C  bl       #0x382bd14 ; 
0065C7E30  mov      w8, #1
0065C7E34  strb     w8, [x25, #0x4f5]
0065C7E38  ldr      x2, [x27]
0065C7E3C  ldrb     w8, [x2, #0x53]
0065C7E40  tbnz     w8, #5, #0x65c7e58
0065C7E44  mov      x0, x22
0065C7E48  str      x23, [x0, #0x10]!
0065C7E4C  mov      x1, x23
0065C7E50  bl       #0x382bcb8 ; 
0065C7E54  b        #0x65c7e68 ; 
0065C7E58  ldr      x8, [x2, #0x60]
0065C7E5C  mov      x0, x22
0065C7E60  mov      x1, x23
0065C7E64  blr      x8
0065C7E68  cbz      x21, #0x65c887c
0065C7E6C  ldr      x8, [x21]
0065C7E70  mov      x0, x22
0065C7E74  ldr      x1, [x8, #0x40]
0065C7E78  bl       #0x382be90 ; 
0065C7E7C  cbz      x0, #0x65c8880
0065C7E80  ldr      w8, [x21, #0x18]
0065C7E84  cmp      w8, #0xc
0065C7E88  b.ls     #0x65c888c
0065C7E8C  str      x22, [x21, #0x80]!
0065C7E90  mov      x0, x21
0065C7E94  mov      x1, x22
0065C7E98  bl       #0x382bcb8 ; 
0065C7E9C  adrp     x8, #0x8f0a000
0065C7EA0  ldr      x21, [x20]
0065C7EA4  ldr      x8, [x8, #0x718] ; GLOBAL HotFix.BattleLogic.WaterfallStateSelectSkill_TypeInfo @ 0x91f4950
0065C7EA8  ldr      x0, [x8]
0065C7EAC  bl       #0x382bfa0 ; 
0065C7EB0  mov      x1, xzr
0065C7EB4  mov      x22, x0
0065C7EB8  bl       #0x65a8fe0 ; HotFix.BattleLogic.WaterfallStateSelectSkill$$.ctor
0065C7EBC  ldrb     w8, [x24, #0x286]
0065C7EC0  cbnz     w8, #0x65c7ed8
0065C7EC4  adrp     x0, #0x8f07000
0065C7EC8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C7ECC  bl       #0x382bd14 ; 
0065C7ED0  mov      w8, #1
0065C7ED4  strb     w8, [x24, #0x286]
0065C7ED8  ldr      x1, [x26]
0065C7EDC  ldrb     w8, [x1, #0x53]
0065C7EE0  tbnz     w8, #5, #0x65c7eec
0065C7EE4  ldr      x23, [x19, #0x80]
0065C7EE8  b        #0x65c7efc ; 
0065C7EEC  ldr      x8, [x1, #0x60]
0065C7EF0  mov      x0, x19
0065C7EF4  blr      x8
0065C7EF8  mov      x23, x0
0065C7EFC  cbz      x22, #0x65c887c
0065C7F00  ldrb     w8, [x25, #0x4f5]
0065C7F04  cbnz     w8, #0x65c7f1c
0065C7F08  adrp     x0, #0x8f09000
0065C7F0C  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C7F10  bl       #0x382bd14 ; 
0065C7F14  mov      w8, #1
0065C7F18  strb     w8, [x25, #0x4f5]
0065C7F1C  ldr      x2, [x27]
0065C7F20  ldrb     w8, [x2, #0x53]
0065C7F24  tbnz     w8, #5, #0x65c7f3c
0065C7F28  mov      x0, x22
0065C7F2C  str      x23, [x0, #0x10]!
0065C7F30  mov      x1, x23
0065C7F34  bl       #0x382bcb8 ; 
0065C7F38  b        #0x65c7f4c ; 
0065C7F3C  ldr      x8, [x2, #0x60]
0065C7F40  mov      x0, x22
0065C7F44  mov      x1, x23
0065C7F48  blr      x8
0065C7F4C  cbz      x21, #0x65c887c
0065C7F50  ldr      x8, [x21]
0065C7F54  mov      x0, x22
0065C7F58  ldr      x1, [x8, #0x40]
0065C7F5C  bl       #0x382be90 ; 
0065C7F60  cbz      x0, #0x65c8880
0065C7F64  ldr      w8, [x21, #0x18]
0065C7F68  cmp      w8, #3
0065C7F6C  b.ls     #0x65c888c
0065C7F70  str      x22, [x21, #0x38]!
0065C7F74  mov      x0, x21
0065C7F78  mov      x1, x22
0065C7F7C  bl       #0x382bcb8 ; 
0065C7F80  adrp     x8, #0x8f0a000
0065C7F84  ldr      x21, [x20]
0065C7F88  ldr      x8, [x8, #0x6c8] ; GLOBAL HotFix.BattleLogic.WaterfallStateAngel_TypeInfo @ 0x91f4900
0065C7F8C  ldr      x0, [x8]
0065C7F90  bl       #0x382bfa0 ; 
0065C7F94  mov      x1, xzr
0065C7F98  mov      x22, x0
0065C7F9C  bl       #0x65b49d0 ; HotFix.BattleLogic.WaterfallStateAngel$$.ctor
0065C7FA0  ldrb     w8, [x24, #0x286]
0065C7FA4  cbnz     w8, #0x65c7fbc
0065C7FA8  adrp     x0, #0x8f07000
0065C7FAC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C7FB0  bl       #0x382bd14 ; 
0065C7FB4  mov      w8, #1
0065C7FB8  strb     w8, [x24, #0x286]
0065C7FBC  ldr      x1, [x26]
0065C7FC0  ldrb     w8, [x1, #0x53]
0065C7FC4  tbnz     w8, #5, #0x65c7fd0
0065C7FC8  ldr      x23, [x19, #0x80]
0065C7FCC  b        #0x65c7fe0 ; 
0065C7FD0  ldr      x8, [x1, #0x60]
0065C7FD4  mov      x0, x19
0065C7FD8  blr      x8
0065C7FDC  mov      x23, x0
0065C7FE0  cbz      x22, #0x65c887c
0065C7FE4  ldrb     w8, [x25, #0x4f5]
0065C7FE8  cbnz     w8, #0x65c8000
0065C7FEC  adrp     x0, #0x8f09000
0065C7FF0  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C7FF4  bl       #0x382bd14 ; 
0065C7FF8  mov      w8, #1
0065C7FFC  strb     w8, [x25, #0x4f5]
0065C8000  ldr      x2, [x27]
0065C8004  ldrb     w8, [x2, #0x53]
0065C8008  tbnz     w8, #5, #0x65c8020
0065C800C  mov      x0, x22
0065C8010  str      x23, [x0, #0x10]!
0065C8014  mov      x1, x23
0065C8018  bl       #0x382bcb8 ; 
0065C801C  b        #0x65c8030 ; 
0065C8020  ldr      x8, [x2, #0x60]
0065C8024  mov      x0, x22
0065C8028  mov      x1, x23
0065C802C  blr      x8
0065C8030  cbz      x21, #0x65c887c
0065C8034  ldr      x8, [x21]
0065C8038  mov      x0, x22
0065C803C  ldr      x1, [x8, #0x40]
0065C8040  bl       #0x382be90 ; 
0065C8044  cbz      x0, #0x65c8880
0065C8048  ldr      w8, [x21, #0x18]
0065C804C  cmp      w8, #4
0065C8050  b.ls     #0x65c888c
0065C8054  str      x22, [x21, #0x40]!
0065C8058  mov      x0, x21
0065C805C  mov      x1, x22
0065C8060  bl       #0x382bcb8 ; 
0065C8064  adrp     x8, #0x8f0a000
0065C8068  ldr      x21, [x20]
0065C806C  ldr      x8, [x8, #0x6e0] ; GLOBAL HotFix.BattleLogic.WaterfallStateContractDevil_TypeInfo @ 0x91f4918
0065C8070  ldr      x0, [x8]
0065C8074  bl       #0x382bfa0 ; 
0065C8078  mov      x1, xzr
0065C807C  mov      x22, x0
0065C8080  bl       #0x65b4f78 ; HotFix.BattleLogic.WaterfallStateContractDevil$$.ctor
0065C8084  ldrb     w8, [x24, #0x286]
0065C8088  cbnz     w8, #0x65c80a0
0065C808C  adrp     x0, #0x8f07000
0065C8090  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C8094  bl       #0x382bd14 ; 
0065C8098  mov      w8, #1
0065C809C  strb     w8, [x24, #0x286]
0065C80A0  ldr      x1, [x26]
0065C80A4  ldrb     w8, [x1, #0x53]
0065C80A8  tbnz     w8, #5, #0x65c80b4
0065C80AC  ldr      x23, [x19, #0x80]
0065C80B0  b        #0x65c80c4 ; 
0065C80B4  ldr      x8, [x1, #0x60]
0065C80B8  mov      x0, x19
0065C80BC  blr      x8
0065C80C0  mov      x23, x0
0065C80C4  cbz      x22, #0x65c887c
0065C80C8  ldrb     w8, [x25, #0x4f5]
0065C80CC  cbnz     w8, #0x65c80e4
0065C80D0  adrp     x0, #0x8f09000
0065C80D4  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C80D8  bl       #0x382bd14 ; 
0065C80DC  mov      w8, #1
0065C80E0  strb     w8, [x25, #0x4f5]
0065C80E4  ldr      x2, [x27]
0065C80E8  ldrb     w8, [x2, #0x53]
0065C80EC  tbnz     w8, #5, #0x65c8104
0065C80F0  mov      x0, x22
0065C80F4  str      x23, [x0, #0x10]!
0065C80F8  mov      x1, x23
0065C80FC  bl       #0x382bcb8 ; 
0065C8100  b        #0x65c8114 ; 
0065C8104  ldr      x8, [x2, #0x60]
0065C8108  mov      x0, x22
0065C810C  mov      x1, x23
0065C8110  blr      x8
0065C8114  cbz      x21, #0x65c887c
0065C8118  ldr      x8, [x21]
0065C811C  mov      x0, x22
0065C8120  ldr      x1, [x8, #0x40]
0065C8124  bl       #0x382be90 ; 
0065C8128  cbz      x0, #0x65c8880
0065C812C  ldr      w8, [x21, #0x18]
0065C8130  cmp      w8, #5
0065C8134  b.ls     #0x65c888c
0065C8138  str      x22, [x21, #0x48]!
0065C813C  mov      x0, x21
0065C8140  mov      x1, x22
0065C8144  bl       #0x382bcb8 ; 
0065C8148  adrp     x8, #0x8f0a000
0065C814C  ldr      x21, [x20]
0065C8150  ldr      x8, [x8, #0x6d8] ; GLOBAL HotFix.BattleLogic.WaterfallStateBox_TypeInfo @ 0x91f4910
0065C8154  ldr      x0, [x8]
0065C8158  bl       #0x382bfa0 ; 
0065C815C  mov      x1, xzr
0065C8160  mov      x22, x0
0065C8164  bl       #0x65a8a7c ; HotFix.BattleLogic.WaterfallStateBox$$.ctor
0065C8168  ldrb     w8, [x24, #0x286]
0065C816C  cbnz     w8, #0x65c8184
0065C8170  adrp     x0, #0x8f07000
0065C8174  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C8178  bl       #0x382bd14 ; 
0065C817C  mov      w8, #1
0065C8180  strb     w8, [x24, #0x286]
0065C8184  ldr      x1, [x26]
0065C8188  ldrb     w8, [x1, #0x53]
0065C818C  tbnz     w8, #5, #0x65c8198
0065C8190  ldr      x23, [x19, #0x80]
0065C8194  b        #0x65c81a8 ; 
0065C8198  ldr      x8, [x1, #0x60]
0065C819C  mov      x0, x19
0065C81A0  blr      x8
0065C81A4  mov      x23, x0
0065C81A8  cbz      x22, #0x65c887c
0065C81AC  ldrb     w8, [x25, #0x4f5]
0065C81B0  cbnz     w8, #0x65c81c8
0065C81B4  adrp     x0, #0x8f09000
0065C81B8  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C81BC  bl       #0x382bd14 ; 
0065C81C0  mov      w8, #1
0065C81C4  strb     w8, [x25, #0x4f5]
0065C81C8  ldr      x2, [x27]
0065C81CC  ldrb     w8, [x2, #0x53]
0065C81D0  tbnz     w8, #5, #0x65c81e8
0065C81D4  mov      x0, x22
0065C81D8  str      x23, [x0, #0x10]!
0065C81DC  mov      x1, x23
0065C81E0  bl       #0x382bcb8 ; 
0065C81E4  b        #0x65c81f8 ; 
0065C81E8  ldr      x8, [x2, #0x60]
0065C81EC  mov      x0, x22
0065C81F0  mov      x1, x23
0065C81F4  blr      x8
0065C81F8  cbz      x21, #0x65c887c
0065C81FC  ldr      x8, [x21]
0065C8200  mov      x0, x22
0065C8204  ldr      x1, [x8, #0x40]
0065C8208  bl       #0x382be90 ; 
0065C820C  cbz      x0, #0x65c8880
0065C8210  ldr      w8, [x21, #0x18]
0065C8214  cmp      w8, #6
0065C8218  b.ls     #0x65c888c
0065C821C  str      x22, [x21, #0x50]!
0065C8220  mov      x0, x21
0065C8224  mov      x1, x22
0065C8228  bl       #0x382bcb8 ; 
0065C822C  adrp     x8, #0x8f0a000
0065C8230  ldr      x21, [x20]
0065C8234  ldr      x8, [x8, #0x6f0] ; GLOBAL HotFix.BattleLogic.WaterfallStateFortune_TypeInfo @ 0x91f4928
0065C8238  ldr      x0, [x8]
0065C823C  bl       #0x382bfa0 ; 
0065C8240  mov      x1, xzr
0065C8244  mov      x22, x0
0065C8248  bl       #0x65b514c ; HotFix.BattleLogic.WaterfallStateFortune$$.ctor
0065C824C  ldrb     w8, [x24, #0x286]
0065C8250  cbnz     w8, #0x65c8268
0065C8254  adrp     x0, #0x8f07000
0065C8258  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C825C  bl       #0x382bd14 ; 
0065C8260  mov      w8, #1
0065C8264  strb     w8, [x24, #0x286]
0065C8268  ldr      x1, [x26]
0065C826C  ldrb     w8, [x1, #0x53]
0065C8270  tbnz     w8, #5, #0x65c827c
0065C8274  ldr      x23, [x19, #0x80]
0065C8278  b        #0x65c828c ; 
0065C827C  ldr      x8, [x1, #0x60]
0065C8280  mov      x0, x19
0065C8284  blr      x8
0065C8288  mov      x23, x0
0065C828C  cbz      x22, #0x65c887c
0065C8290  ldrb     w8, [x25, #0x4f5]
0065C8294  cbnz     w8, #0x65c82ac
0065C8298  adrp     x0, #0x8f09000
0065C829C  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C82A0  bl       #0x382bd14 ; 
0065C82A4  mov      w8, #1
0065C82A8  strb     w8, [x25, #0x4f5]
0065C82AC  ldr      x2, [x27]
0065C82B0  ldrb     w8, [x2, #0x53]
0065C82B4  tbnz     w8, #5, #0x65c82cc
0065C82B8  mov      x0, x22
0065C82BC  str      x23, [x0, #0x10]!
0065C82C0  mov      x1, x23
0065C82C4  bl       #0x382bcb8 ; 
0065C82C8  b        #0x65c82dc ; 
0065C82CC  ldr      x8, [x2, #0x60]
0065C82D0  mov      x0, x22
0065C82D4  mov      x1, x23
0065C82D8  blr      x8
0065C82DC  cbz      x21, #0x65c887c
0065C82E0  ldr      x8, [x21]
0065C82E4  mov      x0, x22
0065C82E8  ldr      x1, [x8, #0x40]
0065C82EC  bl       #0x382be90 ; 
0065C82F0  cbz      x0, #0x65c8880
0065C82F4  ldr      w8, [x21, #0x18]
0065C82F8  cmp      w8, #7
0065C82FC  b.ls     #0x65c888c
0065C8300  str      x22, [x21, #0x58]!
0065C8304  mov      x0, x21
0065C8308  mov      x1, x22
0065C830C  bl       #0x382bcb8 ; 
0065C8310  adrp     x8, #0x8f0a000
0065C8314  ldr      x21, [x20]
0065C8318  ldr      x8, [x8, #0x6f8] ; GLOBAL HotFix.BattleLogic.WaterfallStateGoldFortune_TypeInfo @ 0x91f4930
0065C831C  ldr      x0, [x8]
0065C8320  bl       #0x382bfa0 ; 
0065C8324  mov      x1, xzr
0065C8328  mov      x22, x0
0065C832C  bl       #0x65b51b0 ; HotFix.BattleLogic.WaterfallStateGoldFortune$$.ctor
0065C8330  ldrb     w8, [x24, #0x286]
0065C8334  cbnz     w8, #0x65c834c
0065C8338  adrp     x0, #0x8f07000
0065C833C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C8340  bl       #0x382bd14 ; 
0065C8344  mov      w8, #1
0065C8348  strb     w8, [x24, #0x286]
0065C834C  ldr      x1, [x26]
0065C8350  ldrb     w8, [x1, #0x53]
0065C8354  tbnz     w8, #5, #0x65c8360
0065C8358  ldr      x23, [x19, #0x80]
0065C835C  b        #0x65c8370 ; 
0065C8360  ldr      x8, [x1, #0x60]
0065C8364  mov      x0, x19
0065C8368  blr      x8
0065C836C  mov      x23, x0
0065C8370  cbz      x22, #0x65c887c
0065C8374  ldrb     w8, [x25, #0x4f5]
0065C8378  cbnz     w8, #0x65c8390
0065C837C  adrp     x0, #0x8f09000
0065C8380  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C8384  bl       #0x382bd14 ; 
0065C8388  mov      w8, #1
0065C838C  strb     w8, [x25, #0x4f5]
0065C8390  ldr      x2, [x27]
0065C8394  ldrb     w8, [x2, #0x53]
0065C8398  tbnz     w8, #5, #0x65c83b0
0065C839C  mov      x0, x22
0065C83A0  str      x23, [x0, #0x10]!
0065C83A4  mov      x1, x23
0065C83A8  bl       #0x382bcb8 ; 
0065C83AC  b        #0x65c83c0 ; 
0065C83B0  ldr      x8, [x2, #0x60]
0065C83B4  mov      x0, x22
0065C83B8  mov      x1, x23
0065C83BC  blr      x8
0065C83C0  cbz      x21, #0x65c887c
0065C83C4  ldr      x8, [x21]
0065C83C8  mov      x0, x22
0065C83CC  ldr      x1, [x8, #0x40]
0065C83D0  bl       #0x382be90 ; 
0065C83D4  cbz      x0, #0x65c8880
0065C83D8  ldr      w8, [x21, #0x18]
0065C83DC  cmp      w8, #9
0065C83E0  b.ls     #0x65c888c
0065C83E4  str      x22, [x21, #0x68]!
0065C83E8  mov      x0, x21
0065C83EC  mov      x1, x22
0065C83F0  bl       #0x382bcb8 ; 
0065C83F4  adrp     x8, #0x8f0a000
0065C83F8  ldr      x21, [x20]
0065C83FC  ldr      x8, [x8, #0x700] ; GLOBAL HotFix.BattleLogic.WaterfallStateHeroDie_TypeInfo @ 0x91f4938
0065C8400  ldr      x0, [x8]
0065C8404  bl       #0x382bfa0 ; 
0065C8408  mov      x1, xzr
0065C840C  mov      x22, x0
0065C8410  bl       #0x65a8c0c ; HotFix.BattleLogic.WaterfallStateHeroDie$$.ctor
0065C8414  ldrb     w8, [x24, #0x286]
0065C8418  cbnz     w8, #0x65c8430
0065C841C  adrp     x0, #0x8f07000
0065C8420  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C8424  bl       #0x382bd14 ; 
0065C8428  mov      w8, #1
0065C842C  strb     w8, [x24, #0x286]
0065C8430  ldr      x1, [x26]
0065C8434  ldrb     w8, [x1, #0x53]
0065C8438  tbnz     w8, #5, #0x65c8444
0065C843C  ldr      x23, [x19, #0x80]
0065C8440  b        #0x65c8454 ; 
0065C8444  ldr      x8, [x1, #0x60]
0065C8448  mov      x0, x19
0065C844C  blr      x8
0065C8450  mov      x23, x0
0065C8454  cbz      x22, #0x65c887c
0065C8458  ldrb     w8, [x25, #0x4f5]
0065C845C  cbnz     w8, #0x65c8474
0065C8460  adrp     x0, #0x8f09000
0065C8464  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C8468  bl       #0x382bd14 ; 
0065C846C  mov      w8, #1
0065C8470  strb     w8, [x25, #0x4f5]
0065C8474  ldr      x2, [x27]
0065C8478  ldrb     w8, [x2, #0x53]
0065C847C  tbnz     w8, #5, #0x65c8494
0065C8480  mov      x0, x22
0065C8484  str      x23, [x0, #0x10]!
0065C8488  mov      x1, x23
0065C848C  bl       #0x382bcb8 ; 
0065C8490  b        #0x65c84a4 ; 
0065C8494  ldr      x8, [x2, #0x60]
0065C8498  mov      x0, x22
0065C849C  mov      x1, x23
0065C84A0  blr      x8
0065C84A4  cbz      x21, #0x65c887c
0065C84A8  ldr      x8, [x21]
0065C84AC  mov      x0, x22
0065C84B0  ldr      x1, [x8, #0x40]
0065C84B4  bl       #0x382be90 ; 
0065C84B8  cbz      x0, #0x65c8880
0065C84BC  ldr      w8, [x21, #0x18]
0065C84C0  cmp      w8, #8
0065C84C4  b.ls     #0x65c888c
0065C84C8  str      x22, [x21, #0x60]!
0065C84CC  mov      x0, x21
0065C84D0  mov      x1, x22
0065C84D4  bl       #0x382bcb8 ; 
0065C84D8  adrp     x8, #0x8f0a000
0065C84DC  ldr      x21, [x20]
0065C84E0  ldr      x8, [x8, #0x720] ; GLOBAL HotFix.BattleLogic.WaterfallStateSimpleGold_TypeInfo @ 0x91f4958
0065C84E4  ldr      x0, [x8]
0065C84E8  bl       #0x382bfa0 ; 
0065C84EC  mov      x1, xzr
0065C84F0  mov      x22, x0
0065C84F4  bl       #0x65b7318 ; HotFix.BattleLogic.WaterfallStateSimpleGold$$.ctor
0065C84F8  ldrb     w8, [x24, #0x286]
0065C84FC  cbnz     w8, #0x65c8514
0065C8500  adrp     x0, #0x8f07000
0065C8504  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C8508  bl       #0x382bd14 ; 
0065C850C  mov      w8, #1
0065C8510  strb     w8, [x24, #0x286]
0065C8514  ldr      x1, [x26]
0065C8518  ldrb     w8, [x1, #0x53]
0065C851C  tbnz     w8, #5, #0x65c8528
0065C8520  ldr      x23, [x19, #0x80]
0065C8524  b        #0x65c8538 ; 
0065C8528  ldr      x8, [x1, #0x60]
0065C852C  mov      x0, x19
0065C8530  blr      x8
0065C8534  mov      x23, x0
0065C8538  cbz      x22, #0x65c887c
0065C853C  ldrb     w8, [x25, #0x4f5]
0065C8540  cbnz     w8, #0x65c8558
0065C8544  adrp     x0, #0x8f09000
0065C8548  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C854C  bl       #0x382bd14 ; 
0065C8550  mov      w8, #1
0065C8554  strb     w8, [x25, #0x4f5]
0065C8558  ldr      x2, [x27]
0065C855C  ldrb     w8, [x2, #0x53]
0065C8560  tbnz     w8, #5, #0x65c8578
0065C8564  mov      x0, x22
0065C8568  str      x23, [x0, #0x10]!
0065C856C  mov      x1, x23
0065C8570  bl       #0x382bcb8 ; 
0065C8574  b        #0x65c8588 ; 
0065C8578  ldr      x8, [x2, #0x60]
0065C857C  mov      x0, x22
0065C8580  mov      x1, x23
0065C8584  blr      x8
0065C8588  cbz      x21, #0x65c887c
0065C858C  ldr      x8, [x21]
0065C8590  mov      x0, x22
0065C8594  ldr      x1, [x8, #0x40]
0065C8598  bl       #0x382be90 ; 
0065C859C  cbz      x0, #0x65c8880
0065C85A0  ldr      w8, [x21, #0x18]
0065C85A4  cmp      w8, #0xa
0065C85A8  b.ls     #0x65c888c
0065C85AC  str      x22, [x21, #0x70]!
0065C85B0  mov      x0, x21
0065C85B4  mov      x1, x22
0065C85B8  bl       #0x382bcb8 ; 
0065C85BC  adrp     x8, #0x8f0a000
0065C85C0  ldr      x21, [x20]
0065C85C4  ldr      x8, [x8, #0x710] ; GLOBAL HotFix.BattleLogic.WaterfallStatePunchboard_TypeInfo @ 0x91f4948
0065C85C8  ldr      x0, [x8]
0065C85CC  bl       #0x382bfa0 ; 
0065C85D0  mov      x1, xzr
0065C85D4  mov      x22, x0
0065C85D8  bl       #0x65a8f18 ; HotFix.BattleLogic.WaterfallStatePunchboard$$.ctor
0065C85DC  ldrb     w8, [x24, #0x286]
0065C85E0  cbnz     w8, #0x65c85f8
0065C85E4  adrp     x0, #0x8f07000
0065C85E8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C85EC  bl       #0x382bd14 ; 
0065C85F0  mov      w8, #1
0065C85F4  strb     w8, [x24, #0x286]
0065C85F8  ldr      x1, [x26]
0065C85FC  ldrb     w8, [x1, #0x53]
0065C8600  tbnz     w8, #5, #0x65c860c
0065C8604  ldr      x23, [x19, #0x80]
0065C8608  b        #0x65c861c ; 
0065C860C  ldr      x8, [x1, #0x60]
0065C8610  mov      x0, x19
0065C8614  blr      x8
0065C8618  mov      x23, x0
0065C861C  cbz      x22, #0x65c887c
0065C8620  ldrb     w8, [x25, #0x4f5]
0065C8624  cbnz     w8, #0x65c863c
0065C8628  adrp     x0, #0x8f09000
0065C862C  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C8630  bl       #0x382bd14 ; 
0065C8634  mov      w8, #1
0065C8638  strb     w8, [x25, #0x4f5]
0065C863C  ldr      x2, [x27]
0065C8640  ldrb     w8, [x2, #0x53]
0065C8644  tbnz     w8, #5, #0x65c865c
0065C8648  mov      x0, x22
0065C864C  str      x23, [x0, #0x10]!
0065C8650  mov      x1, x23
0065C8654  bl       #0x382bcb8 ; 
0065C8658  b        #0x65c866c ; 
0065C865C  ldr      x8, [x2, #0x60]
0065C8660  mov      x0, x22
0065C8664  mov      x1, x23
0065C8668  blr      x8
0065C866C  cbz      x21, #0x65c887c
0065C8670  ldr      x8, [x21]
0065C8674  mov      x0, x22
0065C8678  ldr      x1, [x8, #0x40]
0065C867C  bl       #0x382be90 ; 
0065C8680  cbz      x0, #0x65c8880
0065C8684  ldr      w8, [x21, #0x18]
0065C8688  cmp      w8, #0xb
0065C868C  b.ls     #0x65c888c
0065C8690  str      x22, [x21, #0x78]!
0065C8694  mov      x0, x21
0065C8698  mov      x1, x22
0065C869C  bl       #0x382bcb8 ; 
0065C86A0  adrp     x8, #0x8f0a000
0065C86A4  ldr      x21, [x20]
0065C86A8  ldr      x8, [x8, #0x6c0] ; GLOBAL HotFix.BattleLogic.WaterfallSpecialEndState_TypeInfo @ 0x91f48f8
0065C86AC  ldr      x0, [x8]
0065C86B0  bl       #0x382bfa0 ; 
0065C86B4  mov      x1, xzr
0065C86B8  mov      x22, x0
0065C86BC  bl       #0x65b496c ; HotFix.BattleLogic.WaterfallSpecialEndState$$.ctor
0065C86C0  ldrb     w8, [x24, #0x286]
0065C86C4  cbnz     w8, #0x65c86dc
0065C86C8  adrp     x0, #0x8f07000
0065C86CC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C86D0  bl       #0x382bd14 ; 
0065C86D4  mov      w8, #1
0065C86D8  strb     w8, [x24, #0x286]
0065C86DC  ldr      x1, [x26]
0065C86E0  ldrb     w8, [x1, #0x53]
0065C86E4  tbnz     w8, #5, #0x65c86f0
0065C86E8  ldr      x23, [x19, #0x80]
0065C86EC  b        #0x65c8700 ; 
0065C86F0  ldr      x8, [x1, #0x60]
0065C86F4  mov      x0, x19
0065C86F8  blr      x8
0065C86FC  mov      x23, x0
0065C8700  cbz      x22, #0x65c887c
0065C8704  ldrb     w8, [x25, #0x4f5]
0065C8708  cbnz     w8, #0x65c8720
0065C870C  adrp     x0, #0x8f09000
0065C8710  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C8714  bl       #0x382bd14 ; 
0065C8718  mov      w8, #1
0065C871C  strb     w8, [x25, #0x4f5]
0065C8720  ldr      x2, [x27]
0065C8724  ldrb     w8, [x2, #0x53]
0065C8728  tbnz     w8, #5, #0x65c8740
0065C872C  mov      x0, x22
0065C8730  str      x23, [x0, #0x10]!
0065C8734  mov      x1, x23
0065C8738  bl       #0x382bcb8 ; 
0065C873C  b        #0x65c8750 ; 
0065C8740  ldr      x8, [x2, #0x60]
0065C8744  mov      x0, x22
0065C8748  mov      x1, x23
0065C874C  blr      x8
0065C8750  cbz      x21, #0x65c887c
0065C8754  ldr      x8, [x21]
0065C8758  mov      x0, x22
0065C875C  ldr      x1, [x8, #0x40]
0065C8760  bl       #0x382be90 ; 
0065C8764  cbz      x0, #0x65c8880
0065C8768  ldr      w8, [x21, #0x18]
0065C876C  cmp      w8, #0xd
0065C8770  b.ls     #0x65c888c
0065C8774  str      x22, [x21, #0x88]!
0065C8778  mov      x0, x21
0065C877C  mov      x1, x22
0065C8780  bl       #0x382bcb8 ; 
0065C8784  adrp     x8, #0x8f0a000
0065C8788  ldr      x20, [x20]
0065C878C  ldr      x8, [x8, #0x6e8] ; GLOBAL HotFix.BattleLogic.WaterfallStateEnd_TypeInfo @ 0x91f4920
0065C8790  ldr      x0, [x8]
0065C8794  bl       #0x382bfa0 ; 
0065C8798  mov      x1, xzr
0065C879C  mov      x21, x0
0065C87A0  bl       #0x65a8b44 ; HotFix.BattleLogic.WaterfallStateEnd$$.ctor
0065C87A4  ldrb     w8, [x24, #0x286]
0065C87A8  cbnz     w8, #0x65c87c0
0065C87AC  adrp     x0, #0x8f07000
0065C87B0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C87B4  bl       #0x382bd14 ; 
0065C87B8  mov      w8, #1
0065C87BC  strb     w8, [x24, #0x286]
0065C87C0  ldr      x1, [x26]
0065C87C4  ldrb     w8, [x1, #0x53]
0065C87C8  tbnz     w8, #5, #0x65c87d4
0065C87CC  ldr      x19, [x19, #0x80]
0065C87D0  b        #0x65c87e4 ; 
0065C87D4  ldr      x8, [x1, #0x60]
0065C87D8  mov      x0, x19
0065C87DC  blr      x8
0065C87E0  mov      x19, x0
0065C87E4  cbz      x21, #0x65c887c
0065C87E8  ldrb     w8, [x25, #0x4f5]
0065C87EC  cbnz     w8, #0x65c8804
0065C87F0  adrp     x0, #0x8f09000
0065C87F4  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.BattleState.set_WorldContext() @ 0x923ea20
0065C87F8  bl       #0x382bd14 ; 
0065C87FC  mov      w8, #1
0065C8800  strb     w8, [x25, #0x4f5]
0065C8804  ldr      x2, [x27]
0065C8808  ldrb     w8, [x2, #0x53]
0065C880C  tbnz     w8, #5, #0x65c8824
0065C8810  mov      x0, x21
0065C8814  str      x19, [x0, #0x10]!
0065C8818  mov      x1, x19
0065C881C  bl       #0x382bcb8 ; 
0065C8820  b        #0x65c8834 ; 
0065C8824  ldr      x8, [x2, #0x60]
0065C8828  mov      x0, x21
0065C882C  mov      x1, x19
0065C8830  blr      x8
0065C8834  cbz      x20, #0x65c887c
0065C8838  ldr      x8, [x20]
0065C883C  mov      x0, x21
0065C8840  ldr      x1, [x8, #0x40]
0065C8844  bl       #0x382be90 ; 
0065C8848  cbz      x0, #0x65c8880
0065C884C  ldr      w8, [x20, #0x18]
0065C8850  cmp      w8, #0xe
0065C8854  b.ls     #0x65c888c
0065C8858  str      x21, [x20, #0x90]!
0065C885C  mov      x0, x20
0065C8860  mov      x1, x21
0065C8864  ldp      x20, x19, [sp, #0x40]
0065C8868  ldp      x22, x21, [sp, #0x30]
0065C886C  ldp      x24, x23, [sp, #0x20]
0065C8870  ldp      x26, x25, [sp, #0x10]
0065C8874  ldp      x30, x27, [sp], #0x50
0065C8878  b        #0x382bcb8 ; 
0065C887C  bl       #0x382bfb8 ; 
0065C8880  bl       #0x382bfdc ; 
0065C8884  mov      x1, xzr
0065C8888  bl       #0x382be7c ; 
0065C888C  bl       #0x382bfc0 ; 

