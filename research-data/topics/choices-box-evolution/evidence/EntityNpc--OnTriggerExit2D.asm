; HotFix.BattleLogic.EntityNpc$$OnTriggerExit2D
; RVA 0x68D2D10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D2D10  str      x30, [sp, #-0x30]!
0068D2D14  stp      x22, x21, [sp, #0x10]
0068D2D18  stp      x20, x19, [sp, #0x20]
0068D2D1C  adrp     x21, #0x959c000
0068D2D20  adrp     x22, #0x8f28000
0068D2D24  ldrb     w8, [x21, #0x76f]
0068D2D28  ldr      x22, [x22, #0x848] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnTriggerExit2D() @ 0x9263dc0
0068D2D2C  mov      x20, x1
0068D2D30  mov      x19, x0
0068D2D34  tbnz     w8, #0, #0x68d2d64
0068D2D38  adrp     x0, #0x8ec0000
0068D2D3C  ldr      x0, [x0, #0x98] ; GLOBAL bool_TypeInfo @ 0x91e1ca0
0068D2D40  bl       #0x382bd14 ; 
0068D2D44  adrp     x0, #0x8f28000
0068D2D48  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnTriggerExit2D() @ 0x9263dc0
0068D2D4C  bl       #0x382bd14 ; 
0068D2D50  adrp     x0, #0x8ec2000
0068D2D54  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
0068D2D58  bl       #0x382bd14 ; 
0068D2D5C  mov      w8, #1
0068D2D60  strb     w8, [x21, #0x76f]
0068D2D64  ldr      x2, [x22]
0068D2D68  ldrb     w8, [x2, #0x53]
0068D2D6C  tbnz     w8, #5, #0x68d2e34
0068D2D70  ldr      x19, [x19, #0x648]
0068D2D74  cbz      x19, #0x68d2e24
0068D2D78  adrp     x8, #0x8ec2000
0068D2D7C  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
0068D2D80  mov      w1, #2
0068D2D84  ldr      x0, [x8]
0068D2D88  bl       #0x382bdfc ; 
0068D2D8C  cbz      x0, #0x68d2e60
0068D2D90  mov      x21, x0
0068D2D94  cbz      x20, #0x68d2dac
0068D2D98  ldr      x8, [x21]
0068D2D9C  mov      x0, x20
0068D2DA0  ldr      x1, [x8, #0x40]
0068D2DA4  bl       #0x382be90 ; 
0068D2DA8  cbz      x0, #0x68d2e54
0068D2DAC  ldr      w8, [x21, #0x18]
0068D2DB0  cbz      w8, #0x68d2e50
0068D2DB4  mov      x0, x21
0068D2DB8  str      x20, [x0, #0x20]!
0068D2DBC  mov      x1, x20
0068D2DC0  bl       #0x382bcb8 ; 
0068D2DC4  adrp     x8, #0x8ec0000
0068D2DC8  ldr      x8, [x8, #0x98] ; GLOBAL bool_TypeInfo @ 0x91e1ca0
0068D2DCC  add      x1, sp, #0xc
0068D2DD0  strb     wzr, [sp, #0xc]
0068D2DD4  ldr      x0, [x8]
0068D2DD8  bl       #0x382be94 ; 
0068D2DDC  mov      x20, x0
0068D2DE0  cbz      x0, #0x68d2df8
0068D2DE4  ldr      x8, [x21]
0068D2DE8  mov      x0, x20
0068D2DEC  ldr      x1, [x8, #0x40]
0068D2DF0  bl       #0x382be90 ; 
0068D2DF4  cbz      x0, #0x68d2e54
0068D2DF8  ldr      w8, [x21, #0x18]
0068D2DFC  cmp      w8, #1
0068D2E00  b.ls     #0x68d2e50
0068D2E04  mov      x0, x21
0068D2E08  str      x20, [x0, #0x28]!
0068D2E0C  mov      x1, x20
0068D2E10  bl       #0x382bcb8 ; 
0068D2E14  mov      x0, x19
0068D2E18  mov      x1, x21
0068D2E1C  mov      x2, xzr
0068D2E20  bl       #0x6693054 ; HotFix.BattleLogic.CharacterComponentAI$$SetExAIParam
0068D2E24  ldp      x20, x19, [sp, #0x20]
0068D2E28  ldp      x22, x21, [sp, #0x10]
0068D2E2C  ldr      x30, [sp], #0x30
0068D2E30  ret      
0068D2E34  ldr      x3, [x2, #0x60]
0068D2E38  mov      x0, x19
0068D2E3C  mov      x1, x20
0068D2E40  ldp      x20, x19, [sp, #0x20]
0068D2E44  ldp      x22, x21, [sp, #0x10]
0068D2E48  ldr      x30, [sp], #0x30
0068D2E4C  br       x3
0068D2E50  bl       #0x382bfc0 ; 
0068D2E54  bl       #0x382bfdc ; 
0068D2E58  mov      x1, xzr
0068D2E5C  bl       #0x382be7c ; 
0068D2E60  bl       #0x382bfb8 ; 

