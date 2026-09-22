; HotFix.BattleLogic.AIMoveOnPathAttack$$SetAIData
; RVA 0x654BD3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654BD3C  str      x30, [sp, #-0x30]!
00654BD40  stp      x22, x21, [sp, #0x10]
00654BD44  stp      x20, x19, [sp, #0x20]
00654BD48  adrp     x21, #0x9598000
00654BD4C  adrp     x22, #0x8f05000
00654BD50  ldrb     w8, [x21, #0xe3f]
00654BD54  ldr      x22, [x22, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttack.SetAIData()
00654BD58  mov      x19, x1
00654BD5C  mov      x20, x0
00654BD60  tbnz     w8, #0, #0x654bd84
00654BD64  adrp     x0, #0x8f05000
00654BD68  ldr      x0, [x0, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttack.SetAIData()
00654BD6C  bl       #0x382bd14 ; 
00654BD70  adrp     x0, #0x8f05000
00654BD74  ldr      x0, [x0, #0x890] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathAttack.Data_TypeInfo
00654BD78  bl       #0x382bd14 ; 
00654BD7C  mov      w8, #1
00654BD80  strb     w8, [x21, #0xe3f]
00654BD84  ldr      x2, [x22]
00654BD88  ldrb     w8, [x2, #0x53]
00654BD8C  tbnz     w8, #5, #0x654bdf4
00654BD90  cbz      x19, #0x654be10
00654BD94  adrp     x8, #0x8f05000
00654BD98  ldr      x8, [x8, #0x890] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathAttack.Data_TypeInfo
00654BD9C  ldr      x9, [x19]
00654BDA0  ldr      x1, [x8]
00654BDA4  ldrb     w10, [x9, #0x130]
00654BDA8  ldrb     w8, [x1, #0x130]
00654BDAC  cmp      w10, w8
00654BDB0  b.lo     #0x654be2c
00654BDB4  ldr      x10, [x9, #0xc8]
00654BDB8  sub      x9, x8, #1
00654BDBC  ldr      x10, [x10, x9, lsl #3]
00654BDC0  cmp      x10, x1
00654BDC4  b.ne     #0x654be2c
00654BDC8  str      x19, [x20, #0x118]
00654BDCC  ldr      x10, [x19]
00654BDD0  ldrb     w11, [x10, #0x130]
00654BDD4  cmp      w11, w8
00654BDD8  b.lo     #0x654be2c
00654BDDC  ldr      x8, [x10, #0xc8]
00654BDE0  ldr      x8, [x8, x9, lsl #3]
00654BDE4  cmp      x8, x1
00654BDE8  b.ne     #0x654be2c
00654BDEC  add      x0, x20, #0x118
00654BDF0  b        #0x654be18 ; 
00654BDF4  ldr      x3, [x2, #0x60]
00654BDF8  mov      x0, x20
00654BDFC  mov      x1, x19
00654BE00  ldp      x20, x19, [sp, #0x20]
00654BE04  ldp      x22, x21, [sp, #0x10]
00654BE08  ldr      x30, [sp], #0x30
00654BE0C  br       x3
00654BE10  add      x0, x20, #0x118
00654BE14  str      xzr, [x20, #0x118]
00654BE18  mov      x1, x19
00654BE1C  ldp      x20, x19, [sp, #0x20]
00654BE20  ldp      x22, x21, [sp, #0x10]
00654BE24  ldr      x30, [sp], #0x30
00654BE28  b        #0x382bcb8 ; 
00654BE2C  mov      x0, x19
00654BE30  bl       #0x382c354 ; 

