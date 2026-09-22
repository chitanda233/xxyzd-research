; HotFix.BattleLogic.EntityCharacter$$InitCurHp
; RVA 0x67E2E60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067E2E60  stp      x30, x21, [sp, #-0x20]!
0067E2E64  stp      x20, x19, [sp, #0x10]
0067E2E68  adrp     x20, #0x959b000
0067E2E6C  adrp     x21, #0x8f08000
0067E2E70  ldrb     w8, [x20, #0x215]
0067E2E74  ldr      x21, [x21, #0xa50] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitCurHp()
0067E2E78  mov      x19, x0
0067E2E7C  tbnz     w8, #0, #0x67e2ea0
0067E2E80  adrp     x0, #0x8ee6000
0067E2E84  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067E2E88  bl       #0x382bd14 ; 
0067E2E8C  adrp     x0, #0x8f08000
0067E2E90  ldr      x0, [x0, #0xa50] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitCurHp()
0067E2E94  bl       #0x382bd14 ; 
0067E2E98  mov      w8, #1
0067E2E9C  strb     w8, [x20, #0x215]
0067E2EA0  ldr      x1, [x21]
0067E2EA4  ldrb     w8, [x1, #0x53]
0067E2EA8  tbnz     w8, #5, #0x67e2ec8
0067E2EAC  adrp     x8, #0x8ee6000
0067E2EB0  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067E2EB4  ldr      x1, [x8]
0067E2EB8  ldrb     w8, [x1, #0x53]
0067E2EBC  tbnz     w8, #5, #0x67e2ed0
0067E2EC0  ldr      x20, [x19, #0x38]
0067E2EC4  b        #0x67e2ee0 ; 
0067E2EC8  ldr      x2, [x1, #0x60]
0067E2ECC  b        #0x67e2f5c ; 
0067E2ED0  ldr      x8, [x1, #0x60]
0067E2ED4  mov      x0, x19
0067E2ED8  blr      x8
0067E2EDC  mov      x20, x0
0067E2EE0  cbz      x20, #0x67e2f6c
0067E2EE4  adrp     x21, #0x9591000
0067E2EE8  ldrb     w8, [x21, #0xa7f]
0067E2EEC  cbnz     w8, #0x67e2f04
0067E2EF0  adrp     x0, #0x8ee6000
0067E2EF4  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
0067E2EF8  bl       #0x382bd14 ; 
0067E2EFC  mov      w8, #1
0067E2F00  strb     w8, [x21, #0xa7f]
0067E2F04  adrp     x8, #0x8ee6000
0067E2F08  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
0067E2F0C  ldr      x1, [x8]
0067E2F10  ldrb     w8, [x1, #0x53]
0067E2F14  tbnz     w8, #5, #0x67e2f20
0067E2F18  ldr      x0, [x20, #0x178]
0067E2F1C  b        #0x67e2f2c ; 
0067E2F20  ldr      x8, [x1, #0x60]
0067E2F24  mov      x0, x20
0067E2F28  blr      x8
0067E2F2C  cbz      x0, #0x67e2f6c
0067E2F30  mov      x1, xzr
0067E2F34  bl       #0x6b3c490 ; HotFix.Common.AttributeData$$GetHpMax
0067E2F38  ldr      x8, [x19]
0067E2F3C  mov      w1, w0
0067E2F40  mov      x0, x19
0067E2F44  ldr      x9, [x8, #0x488]
0067E2F48  ldr      x2, [x8, #0x490]
0067E2F4C  blr      x9
0067E2F50  ldr      x8, [x19]
0067E2F54  ldr      x2, [x8, #0x468]
0067E2F58  ldr      x1, [x8, #0x470]
0067E2F5C  mov      x0, x19
0067E2F60  ldp      x20, x19, [sp, #0x10]
0067E2F64  ldp      x30, x21, [sp], #0x20
0067E2F68  br       x2
0067E2F6C  bl       #0x382bfb8 ; 

