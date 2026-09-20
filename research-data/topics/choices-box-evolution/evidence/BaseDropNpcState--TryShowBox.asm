; HotFix.BattleLogic.BaseDropNpcState$$TryShowBox
; RVA 0x6598A20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006598A20  sub      sp, sp, #0xa0
006598A24  str      x30, [sp, #0x60]
006598A28  stp      x24, x23, [sp, #0x70]
006598A2C  stp      x22, x21, [sp, #0x80]
006598A30  stp      x20, x19, [sp, #0x90]
006598A34  mrs      x21, tpidr_el0
006598A38  ldr      x8, [x21, #0x28]
006598A3C  adrp     x20, #0x9599000
006598A40  adrp     x22, #0x8f08000
006598A44  mov      x19, x0
006598A48  str      x8, [sp, #0x58]
006598A4C  ldrb     w8, [x20, #0x2f3]
006598A50  ldr      x22, [x22, #0xcb0] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.TryShowBox() @ 0x923b0a0
006598A54  tbnz     w8, #0, #0x6598a84
006598A58  adrp     x0, #0x8f08000
006598A5C  ldr      x0, [x0, #0xcb0] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.TryShowBox() @ 0x923b0a0
006598A60  bl       #0x382bd14 ; 
006598A64  adrp     x0, #0x8ee6000
006598A68  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006598A6C  bl       #0x382bd14 ; 
006598A70  adrp     x0, #0x8ee6000
006598A74  ldr      x0, [x0, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_InstanceId() @ 0x9210188
006598A78  bl       #0x382bd14 ; 
006598A7C  mov      w8, #1
006598A80  strb     w8, [x20, #0x2f3]
006598A84  ldr      x1, [x22]
006598A88  ldrb     w8, [x1, #0x53]
006598A8C  tbnz     w8, #5, #0x6598acc
006598A90  adrp     x22, #0x9599000
006598A94  ldrb     w8, [x22, #0x4b1]
006598A98  cbnz     w8, #0x6598ab0
006598A9C  adrp     x0, #0x8f08000
006598AA0  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006598AA4  bl       #0x382bd14 ; 
006598AA8  mov      w8, #1
006598AAC  strb     w8, [x22, #0x4b1]
006598AB0  adrp     x23, #0x8f08000
006598AB4  ldr      x23, [x23, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006598AB8  ldr      x1, [x23]
006598ABC  ldrb     w8, [x1, #0x53]
006598AC0  tbnz     w8, #5, #0x6598adc
006598AC4  ldr      x20, [x19, #0x10]
006598AC8  b        #0x6598aec ; 
006598ACC  ldr      x8, [x1, #0x60]
006598AD0  mov      x0, x19
006598AD4  blr      x8
006598AD8  b        #0x6598c08 ; 
006598ADC  ldr      x8, [x1, #0x60]
006598AE0  mov      x0, x19
006598AE4  blr      x8
006598AE8  mov      x20, x0
006598AEC  ldr      x0, [x19, #0x18]
006598AF0  cbz      x0, #0x6598c30
006598AF4  adrp     x8, #0x8ee6000
006598AF8  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006598AFC  ldr      x1, [x8]
006598B00  ldrb     w8, [x1, #0x53]
006598B04  tbnz     w8, #5, #0x6598b10
006598B08  ldr      x0, [x0, #0x38]
006598B0C  b        #0x6598b18 ; 
006598B10  ldr      x8, [x1, #0x60]
006598B14  blr      x8
006598B18  cbz      x0, #0x6598c30
006598B1C  add      x8, sp, #0x28
006598B20  mov      x1, xzr
006598B24  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006598B28  ldur     q0, [sp, #0x28]
006598B2C  ldr      x8, [sp, #0x38]
006598B30  str      q0, [sp, #0x40]
006598B34  str      x8, [sp, #0x50]
006598B38  cbz      x20, #0x6598c30
006598B3C  ldr      q0, [sp, #0x40]
006598B40  ldr      x8, [sp, #0x50]
006598B44  add      x4, sp, #0x10
006598B48  mov      w1, #7
006598B4C  mov      w2, #7
006598B50  mov      w3, #1
006598B54  mov      x0, x20
006598B58  mov      x5, xzr
006598B5C  mov      x6, xzr
006598B60  str      q0, [sp, #0x10]
006598B64  str      x8, [sp, #0x20]
006598B68  mov      w24, #1
006598B6C  bl       #0x6a16550 ; HotFix.BattleLogic.BattleWorldContext$$CreateNpc
006598B70  ldrb     w8, [x22, #0x4b1]
006598B74  cbnz     w8, #0x6598b88
006598B78  adrp     x0, #0x8f08000
006598B7C  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006598B80  bl       #0x382bd14 ; 
006598B84  strb     w24, [x22, #0x4b1]
006598B88  ldr      x1, [x23]
006598B8C  ldrb     w8, [x1, #0x53]
006598B90  tbnz     w8, #5, #0x6598b9c
006598B94  ldr      x20, [x19, #0x10]
006598B98  b        #0x6598bac ; 
006598B9C  ldr      x8, [x1, #0x60]
006598BA0  mov      x0, x19
006598BA4  blr      x8
006598BA8  mov      x20, x0
006598BAC  ldr      x0, [x19, #0x18]
006598BB0  cbz      x0, #0x6598c30
006598BB4  adrp     x8, #0x8ee6000
006598BB8  ldr      x8, [x8, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_InstanceId() @ 0x9210188
006598BBC  ldr      x1, [x8]
006598BC0  ldrb     w8, [x1, #0x53]
006598BC4  tbnz     w8, #5, #0x6598bd0
006598BC8  ldr      x3, [x0, #0x28]
006598BCC  b        #0x6598bdc ; 
006598BD0  ldr      x8, [x1, #0x60]
006598BD4  blr      x8
006598BD8  mov      x3, x0
006598BDC  cbz      x20, #0x6598c30
006598BE0  mov      w1, #0x11
006598BE4  mov      w4, #0x10000
006598BE8  mov      x0, x20
006598BEC  mov      w2, wzr
006598BF0  mov      w5, wzr
006598BF4  mov      w6, wzr
006598BF8  mov      x7, xzr
006598BFC  str      xzr, [sp, #8]
006598C00  str      wzr, [sp]
006598C04  bl       #0x6a0ed24 ; HotFix.BattleLogic.BattleWorldContext$$ShowHoverEvent
006598C08  ldr      x8, [x21, #0x28]
006598C0C  ldr      x9, [sp, #0x58]
006598C10  cmp      x8, x9
006598C14  b.ne     #0x6598c34
006598C18  ldp      x20, x19, [sp, #0x90]
006598C1C  ldp      x22, x21, [sp, #0x80]
006598C20  ldp      x24, x23, [sp, #0x70]
006598C24  ldr      x30, [sp, #0x60]
006598C28  add      sp, sp, #0xa0
006598C2C  ret      
006598C30  bl       #0x382bfb8 ; 
006598C34  bl       #0x89edb60 ; 

