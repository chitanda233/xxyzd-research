; HotFix.BattleLogic.WeaponSalvoMod$$get_UpdateOrder
; RVA 0x69DBD58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069DBD58  stp      x30, x21, [sp, #-0x20]!
0069DBD5C  stp      x20, x19, [sp, #0x10]
0069DBD60  adrp     x20, #0x959d000
0069DBD64  adrp     x21, #0x8f31000
0069DBD68  ldrb     w8, [x20, #0x3b0]
0069DBD6C  ldr      x21, [x21, #0x610] ; GLOBAL Method$HotFix.BattleLogic.WeaponSalvoMod.get_UpdateOrder()
0069DBD70  mov      x19, x0
0069DBD74  tbnz     w8, #0, #0x69dbd98
0069DBD78  adrp     x0, #0x8f31000
0069DBD7C  ldr      x0, [x0, #0x618] ; GLOBAL Method$HotFix.BattleLogic.ModBase<SalvoModParams, SalvoModProcessorProcessor>.get_Params()
0069DBD80  bl       #0x382bd14 ; 
0069DBD84  adrp     x0, #0x8f31000
0069DBD88  ldr      x0, [x0, #0x610] ; GLOBAL Method$HotFix.BattleLogic.WeaponSalvoMod.get_UpdateOrder()
0069DBD8C  bl       #0x382bd14 ; 
0069DBD90  mov      w8, #1
0069DBD94  strb     w8, [x20, #0x3b0]
0069DBD98  ldr      x1, [x21]
0069DBD9C  ldrb     w8, [x1, #0x53]
0069DBDA0  tbnz     w8, #5, #0x69dbdfc
0069DBDA4  adrp     x8, #0x8f31000
0069DBDA8  ldr      x8, [x8, #0x618] ; GLOBAL Method$HotFix.BattleLogic.ModBase<SalvoModParams, SalvoModProcessorProcessor>.get_Params()
0069DBDAC  ldr      x1, [x8]
0069DBDB0  ldrb     w8, [x1, #0x53]
0069DBDB4  tbnz     w8, #5, #0x69dbe10
0069DBDB8  ldr      x19, [x19, #0x30]
0069DBDBC  cbz      x19, #0x69dbe24
0069DBDC0  adrp     x20, #0x959d000
0069DBDC4  ldrb     w8, [x20, #0x487]
0069DBDC8  cbnz     w8, #0x69dbde0
0069DBDCC  adrp     x0, #0x8f31000
0069DBDD0  ldr      x0, [x0, #0x5e8] ; GLOBAL Method$HotFix.BattleLogic.SalvoModParams.get_UpdateOrder()
0069DBDD4  bl       #0x382bd14 ; 
0069DBDD8  mov      w8, #1
0069DBDDC  strb     w8, [x20, #0x487]
0069DBDE0  adrp     x8, #0x8f31000
0069DBDE4  ldr      x8, [x8, #0x5e8] ; GLOBAL Method$HotFix.BattleLogic.SalvoModParams.get_UpdateOrder()
0069DBDE8  ldr      x1, [x8]
0069DBDEC  ldrb     w8, [x1, #0x53]
0069DBDF0  tbnz     w8, #5, #0x69dbdfc
0069DBDF4  ldr      w0, [x19, #0x44]
0069DBDF8  b        #0x69dbe28 ; 
0069DBDFC  ldr      x2, [x1, #0x60]
0069DBE00  mov      x0, x19
0069DBE04  ldp      x20, x19, [sp, #0x10]
0069DBE08  ldp      x30, x21, [sp], #0x20
0069DBE0C  br       x2
0069DBE10  ldr      x8, [x1, #0x60]
0069DBE14  mov      x0, x19
0069DBE18  blr      x8
0069DBE1C  mov      x19, x0
0069DBE20  cbnz     x19, #0x69dbdc0
0069DBE24  mov      w0, wzr
0069DBE28  ldp      x20, x19, [sp, #0x10]
0069DBE2C  ldp      x30, x21, [sp], #0x20
0069DBE30  ret      

