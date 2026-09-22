; HotFix.BattleLogic.EntityCharacter$$Init
; RVA 0x67D8A24; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067D8A24  str      x30, [sp, #-0x30]!
0067D8A28  stp      x22, x21, [sp, #0x10]
0067D8A2C  stp      x20, x19, [sp, #0x20]
0067D8A30  adrp     x20, #0x959b000
0067D8A34  adrp     x21, #0x8f1e000
0067D8A38  ldrb     w8, [x20, #0x1df]
0067D8A3C  ldr      x21, [x21, #0x768] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.Init()
0067D8A40  mov      x19, x0
0067D8A44  tbnz     w8, #0, #0x67d8ab0
0067D8A48  adrp     x0, #0x8f05000
0067D8A4C  ldr      x0, [x0, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
0067D8A50  bl       #0x382bd14 ; 
0067D8A54  adrp     x0, #0x8ec1000
0067D8A58  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo
0067D8A5C  bl       #0x382bd14 ; 
0067D8A60  adrp     x0, #0x8ee6000
0067D8A64  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D8A68  bl       #0x382bd14 ; 
0067D8A6C  adrp     x0, #0x8f1e000
0067D8A70  ldr      x0, [x0, #0x768] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.Init()
0067D8A74  bl       #0x382bd14 ; 
0067D8A78  adrp     x0, #0x8f1e000
0067D8A7C  ldr      x0, [x0, #0x750] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnScaleUpdate()
0067D8A80  bl       #0x382bd14 ; 
0067D8A84  adrp     x0, #0x8f08000
0067D8A88  ldr      x0, [x0, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init()
0067D8A8C  bl       #0x382bd14 ; 
0067D8A90  adrp     x0, #0x8f08000
0067D8A94  ldr      x0, [x0, #0x260] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>..ctor()
0067D8A98  bl       #0x382bd14 ; 
0067D8A9C  adrp     x0, #0x8f08000
0067D8AA0  ldr      x0, [x0, #0x268] ; GLOBAL HotFix.Common.TaskQueue<FP>_TypeInfo
0067D8AA4  bl       #0x382bd14 ; 
0067D8AA8  mov      w8, #1
0067D8AAC  strb     w8, [x20, #0x1df]
0067D8AB0  ldr      x1, [x21]
0067D8AB4  ldrb     w8, [x1, #0x53]
0067D8AB8  tbnz     w8, #5, #0x67d8b04
0067D8ABC  adrp     x20, #0x9599000
0067D8AC0  ldrb     w8, [x20, #0x27e]
0067D8AC4  cbnz     w8, #0x67d8adc
0067D8AC8  adrp     x0, #0x8f07000
0067D8ACC  ldr      x0, [x0, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.SetChooseAble()
0067D8AD0  bl       #0x382bd14 ; 
0067D8AD4  mov      w8, #1
0067D8AD8  strb     w8, [x20, #0x27e]
0067D8ADC  adrp     x8, #0x8f07000
0067D8AE0  ldr      x8, [x8, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.SetChooseAble()
0067D8AE4  adrp     x20, #0x8ee6000
0067D8AE8  ldr      x2, [x8]
0067D8AEC  ldrb     w8, [x2, #0x53]
0067D8AF0  ldr      x20, [x20, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D8AF4  tbnz     w8, #5, #0x67d8b0c
0067D8AF8  mov      w8, #1
0067D8AFC  strb     w8, [x19, #0x308]
0067D8B00  b        #0x67d8b1c ; 
0067D8B04  ldr      x2, [x1, #0x60]
0067D8B08  b        #0x67d8cb0 ; 
0067D8B0C  ldr      x8, [x2, #0x60]
0067D8B10  mov      w1, #1
0067D8B14  mov      x0, x19
0067D8B18  blr      x8
0067D8B1C  mov      w1, #1
0067D8B20  mov      x0, x19
0067D8B24  bl       #0x67d8cc8 ; HotFix.BattleLogic.EntityCharacter$$SetHitAble
0067D8B28  ldr      x1, [x20]
0067D8B2C  ldrb     w8, [x1, #0x53]
0067D8B30  tbnz     w8, #5, #0x67d8b3c
0067D8B34  ldr      x0, [x19, #0x38]
0067D8B38  b        #0x67d8b48 ; 
0067D8B3C  ldr      x8, [x1, #0x60]
0067D8B40  mov      x0, x19
0067D8B44  blr      x8
0067D8B48  cbz      x0, #0x67d8cc4
0067D8B4C  mov      x1, xzr
0067D8B50  bl       #0x6804d8c ; 
0067D8B54  ldr      x1, [x20]
0067D8B58  mov      w21, w0
0067D8B5C  ldrb     w8, [x1, #0x53]
0067D8B60  tbnz     w8, #5, #0x67d8be0
0067D8B64  ldr      x20, [x19, #0x38]
0067D8B68  tbnz     w21, #0, #0x67d8bf4
0067D8B6C  adrp     x8, #0x8f05000
0067D8B70  ldr      x8, [x8, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
0067D8B74  ldr      x0, [x8]
0067D8B78  bl       #0x382bfa0 ; 
0067D8B7C  cbz      x19, #0x67d8cc4
0067D8B80  ldr      x8, [x19]
0067D8B84  mov      x1, x19
0067D8B88  mov      x3, xzr
0067D8B8C  mov      x21, x0
0067D8B90  ldr      x2, [x8, #0x340]
0067D8B94  bl       #0x5f40564 ; System.Action<FP>$$.ctor
0067D8B98  adrp     x8, #0x8ec1000
0067D8B9C  ldr      x8, [x8, #0x6e8] ; GLOBAL System.Action_TypeInfo
0067D8BA0  ldr      x0, [x8]
0067D8BA4  bl       #0x382bfa0 ; 
0067D8BA8  adrp     x8, #0x8f1e000
0067D8BAC  ldr      x8, [x8, #0x750] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnScaleUpdate()
0067D8BB0  mov      x1, x19
0067D8BB4  mov      x3, xzr
0067D8BB8  mov      x22, x0
0067D8BBC  ldr      x2, [x8]
0067D8BC0  bl       #0x7ade578 ; System.Action$$.ctor
0067D8BC4  cbz      x20, #0x67d8cc4
0067D8BC8  mov      x0, x20
0067D8BCC  mov      x1, x21
0067D8BD0  mov      x2, x22
0067D8BD4  mov      x3, xzr
0067D8BD8  bl       #0x6821484 ; HotFix.BattleLogic.EntityCharacterData$$AddHpAndScaleAction
0067D8BDC  b        #0x67d8c34 ; 
0067D8BE0  ldr      x8, [x1, #0x60]
0067D8BE4  mov      x0, x19
0067D8BE8  blr      x8
0067D8BEC  mov      x20, x0
0067D8BF0  tbz      w21, #0, #0x67d8b6c
0067D8BF4  adrp     x8, #0x8ec1000
0067D8BF8  ldr      x8, [x8, #0x6e8] ; GLOBAL System.Action_TypeInfo
0067D8BFC  ldr      x0, [x8]
0067D8C00  bl       #0x382bfa0 ; 
0067D8C04  adrp     x8, #0x8f1e000
0067D8C08  ldr      x8, [x8, #0x750] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnScaleUpdate()
0067D8C0C  mov      x1, x19
0067D8C10  mov      x3, xzr
0067D8C14  mov      x21, x0
0067D8C18  ldr      x2, [x8]
0067D8C1C  bl       #0x7ade578 ; System.Action$$.ctor
0067D8C20  cbz      x20, #0x67d8cc4
0067D8C24  mov      x0, x20
0067D8C28  mov      x1, x21
0067D8C2C  mov      x2, xzr
0067D8C30  bl       #0x68215a4 ; HotFix.BattleLogic.EntityCharacterData$$AddScaleAction
0067D8C34  adrp     x8, #0x8f08000
0067D8C38  ldr      x8, [x8, #0x268] ; GLOBAL HotFix.Common.TaskQueue<FP>_TypeInfo
0067D8C3C  ldr      x0, [x8]
0067D8C40  bl       #0x382bfa0 ; 
0067D8C44  adrp     x8, #0x8f08000
0067D8C48  ldr      x8, [x8, #0x260] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>..ctor()
0067D8C4C  mov      x20, x0
0067D8C50  ldr      x1, [x8]
0067D8C54  bl       #0x557021c ; HotFix.Common.TaskQueue<FP>$$.ctor
0067D8C58  add      x0, x19, #0x128
0067D8C5C  mov      x1, x20
0067D8C60  str      x20, [x19, #0x128]
0067D8C64  bl       #0x382bcb8 ; 
0067D8C68  ldr      x0, [x19, #0x128]
0067D8C6C  cbz      x0, #0x67d8cc4
0067D8C70  adrp     x8, #0x8f08000
0067D8C74  ldr      x8, [x8, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init()
0067D8C78  ldr      x1, [x8]
0067D8C7C  bl       #0x556fd48 ; HotFix.Common.TaskQueue<FP>$$Init
0067D8C80  mov      x0, x19
0067D8C84  str      xzr, [x19, #0x170]
0067D8C88  bl       #0x67d8f58 ; HotFix.BattleLogic.EntityCharacter$$InitSkillStorage
0067D8C8C  mov      x0, x19
0067D8C90  bl       #0x67d716c ; HotFix.BattleLogic.EntityCharacter$$InitAnimator
0067D8C94  mov      x0, x19
0067D8C98  bl       #0x67d93d4 ; HotFix.BattleLogic.EntityCharacter$$InitWeapon
0067D8C9C  mov      x0, x19
0067D8CA0  bl       #0x67da314 ; HotFix.BattleLogic.EntityCharacter$$InitCharacterComponent
0067D8CA4  ldr      x8, [x19]
0067D8CA8  ldr      x2, [x8, #0x348]
0067D8CAC  ldr      x1, [x8, #0x350]
0067D8CB0  mov      x0, x19
0067D8CB4  ldp      x20, x19, [sp, #0x20]
0067D8CB8  ldp      x22, x21, [sp, #0x10]
0067D8CBC  ldr      x30, [sp], #0x30
0067D8CC0  br       x2
0067D8CC4  bl       #0x382bfb8 ; 

