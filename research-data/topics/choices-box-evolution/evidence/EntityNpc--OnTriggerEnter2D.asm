; HotFix.BattleLogic.EntityNpc$$OnTriggerEnter2D
; RVA 0x68D2E64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D2E64  str      x30, [sp, #-0x30]!
0068D2E68  stp      x22, x21, [sp, #0x10]
0068D2E6C  stp      x20, x19, [sp, #0x20]
0068D2E70  adrp     x21, #0x959c000
0068D2E74  adrp     x22, #0x8f28000
0068D2E78  ldrb     w8, [x21, #0x770]
0068D2E7C  ldr      x22, [x22, #0x850] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnTriggerEnter2D() @ 0x9263db8
0068D2E80  mov      x20, x1
0068D2E84  mov      x19, x0
0068D2E88  tbnz     w8, #0, #0x68d2eb8
0068D2E8C  adrp     x0, #0x8ec0000
0068D2E90  ldr      x0, [x0, #0x98] ; GLOBAL bool_TypeInfo @ 0x91e1ca0
0068D2E94  bl       #0x382bd14 ; 
0068D2E98  adrp     x0, #0x8f28000
0068D2E9C  ldr      x0, [x0, #0x850] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnTriggerEnter2D() @ 0x9263db8
0068D2EA0  bl       #0x382bd14 ; 
0068D2EA4  adrp     x0, #0x8ec2000
0068D2EA8  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
0068D2EAC  bl       #0x382bd14 ; 
0068D2EB0  mov      w8, #1
0068D2EB4  strb     w8, [x21, #0x770]
0068D2EB8  ldr      x2, [x22]
0068D2EBC  ldrb     w8, [x2, #0x53]
0068D2EC0  tbnz     w8, #5, #0x68d2f8c
0068D2EC4  ldr      x19, [x19, #0x648]
0068D2EC8  cbz      x19, #0x68d2f7c
0068D2ECC  adrp     x8, #0x8ec2000
0068D2ED0  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
0068D2ED4  mov      w1, #2
0068D2ED8  ldr      x0, [x8]
0068D2EDC  bl       #0x382bdfc ; 
0068D2EE0  cbz      x0, #0x68d2fb8
0068D2EE4  mov      x21, x0
0068D2EE8  cbz      x20, #0x68d2f00
0068D2EEC  ldr      x8, [x21]
0068D2EF0  mov      x0, x20
0068D2EF4  ldr      x1, [x8, #0x40]
0068D2EF8  bl       #0x382be90 ; 
0068D2EFC  cbz      x0, #0x68d2fac
0068D2F00  ldr      w8, [x21, #0x18]
0068D2F04  cbz      w8, #0x68d2fa8
0068D2F08  mov      x0, x21
0068D2F0C  str      x20, [x0, #0x20]!
0068D2F10  mov      x1, x20
0068D2F14  bl       #0x382bcb8 ; 
0068D2F18  adrp     x8, #0x8ec0000
0068D2F1C  ldr      x8, [x8, #0x98] ; GLOBAL bool_TypeInfo @ 0x91e1ca0
0068D2F20  add      x1, sp, #0xc
0068D2F24  ldr      x0, [x8]
0068D2F28  mov      w8, #1
0068D2F2C  strb     w8, [sp, #0xc]
0068D2F30  bl       #0x382be94 ; 
0068D2F34  mov      x20, x0
0068D2F38  cbz      x0, #0x68d2f50
0068D2F3C  ldr      x8, [x21]
0068D2F40  mov      x0, x20
0068D2F44  ldr      x1, [x8, #0x40]
0068D2F48  bl       #0x382be90 ; 
0068D2F4C  cbz      x0, #0x68d2fac
0068D2F50  ldr      w8, [x21, #0x18]
0068D2F54  cmp      w8, #1
0068D2F58  b.ls     #0x68d2fa8
0068D2F5C  mov      x0, x21
0068D2F60  str      x20, [x0, #0x28]!
0068D2F64  mov      x1, x20
0068D2F68  bl       #0x382bcb8 ; 
0068D2F6C  mov      x0, x19
0068D2F70  mov      x1, x21
0068D2F74  mov      x2, xzr
0068D2F78  bl       #0x6693054 ; HotFix.BattleLogic.CharacterComponentAI$$SetExAIParam
0068D2F7C  ldp      x20, x19, [sp, #0x20]
0068D2F80  ldp      x22, x21, [sp, #0x10]
0068D2F84  ldr      x30, [sp], #0x30
0068D2F88  ret      
0068D2F8C  ldr      x3, [x2, #0x60]
0068D2F90  mov      x0, x19
0068D2F94  mov      x1, x20
0068D2F98  ldp      x20, x19, [sp, #0x20]
0068D2F9C  ldp      x22, x21, [sp, #0x10]
0068D2FA0  ldr      x30, [sp], #0x30
0068D2FA4  br       x3
0068D2FA8  bl       #0x382bfc0 ; 
0068D2FAC  bl       #0x382bfdc ; 
0068D2FB0  mov      x1, xzr
0068D2FB4  bl       #0x382be7c ; 
0068D2FB8  bl       #0x382bfb8 ; 

