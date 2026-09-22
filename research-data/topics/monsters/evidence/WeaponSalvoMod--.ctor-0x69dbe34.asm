; HotFix.BattleLogic.WeaponSalvoMod$$.ctor
; RVA 0x69DBE34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069DBE34  stp      x30, x21, [sp, #-0x20]!
0069DBE38  stp      x20, x19, [sp, #0x10]
0069DBE3C  adrp     x20, #0x959d000
0069DBE40  adrp     x21, #0x8f31000
0069DBE44  ldrb     w8, [x20, #0x3b1]
0069DBE48  ldr      x21, [x21, #0x620] ; GLOBAL Method$HotFix.BattleLogic.WeaponSalvoMod..ctor()
0069DBE4C  mov      x19, x0
0069DBE50  tbnz     w8, #0, #0x69dbe74
0069DBE54  adrp     x0, #0x8f31000
0069DBE58  ldr      x0, [x0, #0x628] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<SalvoModParams, SalvoModProcessorProcessor>..ctor()
0069DBE5C  bl       #0x382bd14 ; 
0069DBE60  adrp     x0, #0x8f31000
0069DBE64  ldr      x0, [x0, #0x620] ; GLOBAL Method$HotFix.BattleLogic.WeaponSalvoMod..ctor()
0069DBE68  bl       #0x382bd14 ; 
0069DBE6C  mov      w8, #1
0069DBE70  strb     w8, [x20, #0x3b1]
0069DBE74  ldr      x1, [x21]
0069DBE78  ldrb     w8, [x1, #0x53]
0069DBE7C  tbnz     w8, #5, #0x69dbe9c
0069DBE80  adrp     x8, #0x8f31000
0069DBE84  ldr      x8, [x8, #0x628] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<SalvoModParams, SalvoModProcessorProcessor>..ctor()
0069DBE88  mov      x0, x19
0069DBE8C  ldp      x20, x19, [sp, #0x10]
0069DBE90  ldr      x1, [x8]
0069DBE94  ldp      x30, x21, [sp], #0x20
0069DBE98  b        #0x58c8684 ; HotFix.BattleLogic.WeaponModBase<object, object>$$.ctor
0069DBE9C  ldr      x2, [x1, #0x60]
0069DBEA0  mov      x0, x19
0069DBEA4  ldp      x20, x19, [sp, #0x10]
0069DBEA8  ldp      x30, x21, [sp], #0x20
0069DBEAC  br       x2

