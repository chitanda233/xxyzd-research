; HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew$$SetAIData
; RVA 0x654CD1C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654CD1C  str      x30, [sp, #-0x30]!
00654CD20  stp      x22, x21, [sp, #0x10]
00654CD24  stp      x20, x19, [sp, #0x20]
00654CD28  adrp     x21, #0x9598000
00654CD2C  adrp     x22, #0x8f05000
00654CD30  ldrb     w8, [x21, #0xe4d]
00654CD34  ldr      x22, [x22, #0x950] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.SetAIData()
00654CD38  mov      x19, x1
00654CD3C  mov      x20, x0
00654CD40  tbnz     w8, #0, #0x654cd64
00654CD44  adrp     x0, #0x8f05000
00654CD48  ldr      x0, [x0, #0x950] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.SetAIData()
00654CD4C  bl       #0x382bd14 ; 
00654CD50  adrp     x0, #0x8f05000
00654CD54  ldr      x0, [x0, #0x938] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.Data_TypeInfo
00654CD58  bl       #0x382bd14 ; 
00654CD5C  mov      w8, #1
00654CD60  strb     w8, [x21, #0xe4d]
00654CD64  ldr      x2, [x22]
00654CD68  ldrb     w8, [x2, #0x53]
00654CD6C  tbnz     w8, #5, #0x654cdd4
00654CD70  cbz      x19, #0x654cdf0
00654CD74  adrp     x8, #0x8f05000
00654CD78  ldr      x8, [x8, #0x938] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathAttackLoopBornNew.Data_TypeInfo
00654CD7C  ldr      x9, [x19]
00654CD80  ldr      x1, [x8]
00654CD84  ldrb     w10, [x9, #0x130]
00654CD88  ldrb     w8, [x1, #0x130]
00654CD8C  cmp      w10, w8
00654CD90  b.lo     #0x654ce0c
00654CD94  ldr      x10, [x9, #0xc8]
00654CD98  sub      x9, x8, #1
00654CD9C  ldr      x10, [x10, x9, lsl #3]
00654CDA0  cmp      x10, x1
00654CDA4  b.ne     #0x654ce0c
00654CDA8  str      x19, [x20, #0x118]
00654CDAC  ldr      x10, [x19]
00654CDB0  ldrb     w11, [x10, #0x130]
00654CDB4  cmp      w11, w8
00654CDB8  b.lo     #0x654ce0c
00654CDBC  ldr      x8, [x10, #0xc8]
00654CDC0  ldr      x8, [x8, x9, lsl #3]
00654CDC4  cmp      x8, x1
00654CDC8  b.ne     #0x654ce0c
00654CDCC  add      x0, x20, #0x118
00654CDD0  b        #0x654cdf8 ; 
00654CDD4  ldr      x3, [x2, #0x60]
00654CDD8  mov      x0, x20
00654CDDC  mov      x1, x19
00654CDE0  ldp      x20, x19, [sp, #0x20]
00654CDE4  ldp      x22, x21, [sp, #0x10]
00654CDE8  ldr      x30, [sp], #0x30
00654CDEC  br       x3
00654CDF0  add      x0, x20, #0x118
00654CDF4  str      xzr, [x20, #0x118]
00654CDF8  mov      x1, x19
00654CDFC  ldp      x20, x19, [sp, #0x20]
00654CE00  ldp      x22, x21, [sp, #0x10]
00654CE04  ldr      x30, [sp], #0x30
00654CE08  b        #0x382bcb8 ; 
00654CE0C  mov      x0, x19
00654CE10  bl       #0x382c354 ; 

