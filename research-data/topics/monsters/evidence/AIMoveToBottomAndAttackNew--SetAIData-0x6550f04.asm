; HotFix.BattleLogic.AIMoveToBottomAndAttackNew$$SetAIData
; RVA 0x6550F04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006550F04  str      x30, [sp, #-0x30]!
006550F08  stp      x22, x21, [sp, #0x10]
006550F0C  stp      x20, x19, [sp, #0x20]
006550F10  adrp     x21, #0x9598000
006550F14  adrp     x22, #0x8f05000
006550F18  ldrb     w8, [x21, #0xe78]
006550F1C  ldr      x22, [x22, #0xb50] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.SetAIData()
006550F20  mov      x19, x1
006550F24  mov      x20, x0
006550F28  tbnz     w8, #0, #0x6550f4c
006550F2C  adrp     x0, #0x8f05000
006550F30  ldr      x0, [x0, #0xb50] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToBottomAndAttackNew.SetAIData()
006550F34  bl       #0x382bd14 ; 
006550F38  adrp     x0, #0x8f05000
006550F3C  ldr      x0, [x0, #0xb38] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttackNew.Data_TypeInfo
006550F40  bl       #0x382bd14 ; 
006550F44  mov      w8, #1
006550F48  strb     w8, [x21, #0xe78]
006550F4C  ldr      x2, [x22]
006550F50  ldrb     w8, [x2, #0x53]
006550F54  tbnz     w8, #5, #0x6550fbc
006550F58  cbz      x19, #0x6550fd8
006550F5C  adrp     x8, #0x8f05000
006550F60  ldr      x8, [x8, #0xb38] ; GLOBAL HotFix.BattleLogic.AIMoveToBottomAndAttackNew.Data_TypeInfo
006550F64  ldr      x9, [x19]
006550F68  ldr      x1, [x8]
006550F6C  ldrb     w10, [x9, #0x130]
006550F70  ldrb     w8, [x1, #0x130]
006550F74  cmp      w10, w8
006550F78  b.lo     #0x6550ff4
006550F7C  ldr      x10, [x9, #0xc8]
006550F80  sub      x9, x8, #1
006550F84  ldr      x10, [x10, x9, lsl #3]
006550F88  cmp      x10, x1
006550F8C  b.ne     #0x6550ff4
006550F90  str      x19, [x20, #0x118]
006550F94  ldr      x10, [x19]
006550F98  ldrb     w11, [x10, #0x130]
006550F9C  cmp      w11, w8
006550FA0  b.lo     #0x6550ff4
006550FA4  ldr      x8, [x10, #0xc8]
006550FA8  ldr      x8, [x8, x9, lsl #3]
006550FAC  cmp      x8, x1
006550FB0  b.ne     #0x6550ff4
006550FB4  add      x0, x20, #0x118
006550FB8  b        #0x6550fe0 ; 
006550FBC  ldr      x3, [x2, #0x60]
006550FC0  mov      x0, x20
006550FC4  mov      x1, x19
006550FC8  ldp      x20, x19, [sp, #0x20]
006550FCC  ldp      x22, x21, [sp, #0x10]
006550FD0  ldr      x30, [sp], #0x30
006550FD4  br       x3
006550FD8  add      x0, x20, #0x118
006550FDC  str      xzr, [x20, #0x118]
006550FE0  mov      x1, x19
006550FE4  ldp      x20, x19, [sp, #0x20]
006550FE8  ldp      x22, x21, [sp, #0x10]
006550FEC  ldr      x30, [sp], #0x30
006550FF0  b        #0x382bcb8 ; 
006550FF4  mov      x0, x19
006550FF8  bl       #0x382c354 ; 

