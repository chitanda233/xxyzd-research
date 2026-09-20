; HotFix.BattleLogic.AIPunchboard$$InitDataByParams
; RVA 0x6B89D78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B89D78  stp      x30, x23, [sp, #-0x30]!
006B89D7C  stp      x22, x21, [sp, #0x10]
006B89D80  stp      x20, x19, [sp, #0x20]
006B89D84  adrp     x22, #0x959f000
006B89D88  adrp     x23, #0x8f43000
006B89D8C  ldrb     w8, [x22, #0xf78]
006B89D90  ldr      x23, [x23, #0x818] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.InitDataByParams() @ 0x92323f0
006B89D94  mov      x20, x2
006B89D98  mov      x21, x1
006B89D9C  mov      x19, x0
006B89DA0  tbnz     w8, #0, #0x6b89ddc
006B89DA4  adrp     x0, #0x8f43000
006B89DA8  ldr      x0, [x0, #0x818] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.InitDataByParams() @ 0x92323f0
006B89DAC  bl       #0x382bd14 ; 
006B89DB0  adrp     x0, #0x8f43000
006B89DB4  ldr      x0, [x0, #0x820] ; GLOBAL HotFix.BattleLogic.AIPunchboard.Data_TypeInfo @ 0x91f60c8
006B89DB8  bl       #0x382bd14 ; 
006B89DBC  adrp     x0, #0x8f43000
006B89DC0  ldr      x0, [x0, #0x828] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<AIPunchboard.Data>() @ 0x9287918
006B89DC4  bl       #0x382bd14 ; 
006B89DC8  adrp     x0, #0x8ee2000
006B89DCC  ldr      x0, [x0, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo @ 0x91eb2e0
006B89DD0  bl       #0x382bd14 ; 
006B89DD4  mov      w8, #1
006B89DD8  strb     w8, [x22, #0xf78]
006B89DDC  ldr      x3, [x23]
006B89DE0  ldrb     w8, [x3, #0x53]
006B89DE4  tbnz     w8, #5, #0x6b89e9c
006B89DE8  adrp     x8, #0x8ee2000
006B89DEC  ldr      x8, [x8, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo @ 0x91eb2e0
006B89DF0  adrp     x22, #0x8f43000
006B89DF4  ldr      x0, [x8]
006B89DF8  ldr      w8, [x0, #0xe0]
006B89DFC  ldr      x22, [x22, #0x828] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<AIPunchboard.Data>() @ 0x9287918
006B89E00  cbnz     w8, #0x6b89e08
006B89E04  bl       #0x382be8c ; 
006B89E08  ldr      x1, [x22]
006B89E0C  mov      x0, x21
006B89E10  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
006B89E14  mov      x21, x0
006B89E18  cbnz     x0, #0x6b89e34
006B89E1C  adrp     x8, #0x8f43000
006B89E20  ldr      x8, [x8, #0x820] ; GLOBAL HotFix.BattleLogic.AIPunchboard.Data_TypeInfo @ 0x91f60c8
006B89E24  ldr      x0, [x8]
006B89E28  bl       #0x382bfa0 ; 
006B89E2C  mov      x21, x0
006B89E30  bl       #0x6b89ec0 ; HotFix.BattleLogic.AIPunchboard.Data$$.ctor
006B89E34  cbz      x19, #0x6b89ebc
006B89E38  add      x0, x19, #0x118
006B89E3C  mov      x1, x21
006B89E40  str      x21, [x19, #0x118]
006B89E44  bl       #0x382bcb8 ; 
006B89E48  ldr      x1, [x19, #0x118]
006B89E4C  mov      x0, x20
006B89E50  str      x1, [x20]
006B89E54  bl       #0x382bcb8 ; 
006B89E58  ldr      x8, [x19, #0x118]
006B89E5C  str      xzr, [x19, #0x130]
006B89E60  cbz      x8, #0x6b89ebc
006B89E64  ldr      x9, [x8, #0x20]
006B89E68  cbz      x9, #0x6b89e74
006B89E6C  mov      x10, #0x100000000
006B89E70  sdiv     x9, x10, x9
006B89E74  str      x9, [x19, #0x138]
006B89E78  ldr      x8, [x8, #0x28]
006B89E7C  cbz      x8, #0x6b89e88
006B89E80  mov      x9, #0x100000000
006B89E84  sdiv     x8, x9, x8
006B89E88  str      x8, [x19, #0x140]
006B89E8C  ldp      x20, x19, [sp, #0x20]
006B89E90  ldp      x22, x21, [sp, #0x10]
006B89E94  ldp      x30, x23, [sp], #0x30
006B89E98  ret      
006B89E9C  ldr      x4, [x3, #0x60]
006B89EA0  mov      x0, x19
006B89EA4  mov      x1, x21
006B89EA8  mov      x2, x20
006B89EAC  ldp      x20, x19, [sp, #0x20]
006B89EB0  ldp      x22, x21, [sp, #0x10]
006B89EB4  ldp      x30, x23, [sp], #0x30
006B89EB8  br       x4
006B89EBC  bl       #0x382bfb8 ; 

