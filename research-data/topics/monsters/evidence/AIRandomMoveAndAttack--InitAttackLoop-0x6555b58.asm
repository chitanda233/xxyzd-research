; HotFix.BattleLogic.AIRandomMoveAndAttack$$InitAttackLoop
; RVA 0x6555B58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006555B58  stp      x30, x21, [sp, #-0x20]!
006555B5C  stp      x20, x19, [sp, #0x10]
006555B60  adrp     x20, #0x9598000
006555B64  adrp     x21, #0x8f05000
006555B68  ldrb     w8, [x20, #0xeb0]
006555B6C  ldr      x21, [x21, #0xe30] ; GLOBAL Method$HotFix.BattleLogic.AIRandomMoveAndAttack.InitAttackLoop()
006555B70  mov      x19, x0
006555B74  tbnz     w8, #0, #0x6555b98
006555B78  adrp     x0, #0x8f05000
006555B7C  ldr      x0, [x0, #0xe30] ; GLOBAL Method$HotFix.BattleLogic.AIRandomMoveAndAttack.InitAttackLoop()
006555B80  bl       #0x382bd14 ; 
006555B84  adrp     x0, #0x8eea000
006555B88  ldr      x0, [x0, #0xd90] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<CharacterComponentMovement>()
006555B8C  bl       #0x382bd14 ; 
006555B90  mov      w8, #1
006555B94  strb     w8, [x20, #0xeb0]
006555B98  ldr      x1, [x21]
006555B9C  ldrb     w8, [x1, #0x53]
006555BA0  tbnz     w8, #5, #0x6555c00
006555BA4  ldr      x0, [x19, #0x58]
006555BA8  cbz      x0, #0x6555c84
006555BAC  adrp     x8, #0x8eea000
006555BB0  ldr      x8, [x8, #0xd90] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<CharacterComponentMovement>()
006555BB4  ldr      x1, [x8]
006555BB8  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006555BBC  cbz      x0, #0x6555c84
006555BC0  adrp     x21, #0x9598000
006555BC4  ldrb     w8, [x21, #0xfc2]
006555BC8  mov      x20, x0
006555BCC  cbnz     w8, #0x6555be4
006555BD0  adrp     x0, #0x8f05000
006555BD4  ldr      x0, [x0, #0xe38] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentMovement.set_ControlForward()
006555BD8  bl       #0x382bd14 ; 
006555BDC  mov      w8, #1
006555BE0  strb     w8, [x21, #0xfc2]
006555BE4  adrp     x8, #0x8f05000
006555BE8  ldr      x8, [x8, #0xe38] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentMovement.set_ControlForward()
006555BEC  ldr      x2, [x8]
006555BF0  ldrb     w8, [x2, #0x53]
006555BF4  tbnz     w8, #5, #0x6555c14
006555BF8  strb     wzr, [x20, #0x80]
006555BFC  b        #0x6555c24 ; 
006555C00  ldr      x2, [x1, #0x60]
006555C04  mov      x0, x19
006555C08  ldp      x20, x19, [sp, #0x10]
006555C0C  ldp      x30, x21, [sp], #0x20
006555C10  br       x2
006555C14  ldr      x8, [x2, #0x60]
006555C18  mov      x0, x20
006555C1C  mov      w1, wzr
006555C20  blr      x8
006555C24  ldr      x20, [x19, #0x58]
006555C28  mov      x0, x19
006555C2C  mov      x1, xzr
006555C30  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
006555C34  cbz      x20, #0x6555c84
006555C38  mov      x1, x0
006555C3C  mov      x0, x20
006555C40  mov      x2, xzr
006555C44  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
006555C48  ldr      x8, [x19, #0x118]
006555C4C  cbz      x8, #0x6555c84
006555C50  ldp      x1, x2, [x8, #0x10]
006555C54  ldp      x3, x4, [x8, #0x20]
006555C58  mov      x0, x19
006555C5C  mov      x5, xzr
006555C60  bl       #0x6b92d64 ; HotFix.BattleLogic.AIStateController$$AddTaskAddAlertRandomWalk
006555C64  mov      x0, x19
006555C68  ldp      x20, x19, [sp, #0x10]
006555C6C  mov      w1, #1
006555C70  mov      x2, xzr
006555C74  mov      x3, xzr
006555C78  mov      x4, xzr
006555C7C  ldp      x30, x21, [sp], #0x20
006555C80  b        #0x6b7f374 ; HotFix.BattleLogic.AIStateController$$AddTaskAttack
006555C84  bl       #0x382bfb8 ; 

