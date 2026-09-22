; HotFix.BattleLogic.WeaponMultiAngleMod$$.ctor
; RVA 0x69D7C10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7C10  stp      x30, x21, [sp, #-0x20]!
0069D7C14  stp      x20, x19, [sp, #0x10]
0069D7C18  adrp     x20, #0x959d000
0069D7C1C  adrp     x21, #0x8f31000
0069D7C20  ldrb     w8, [x20, #0x376]
0069D7C24  ldr      x21, [x21, #0x320] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleMod..ctor()
0069D7C28  mov      x19, x0
0069D7C2C  tbnz     w8, #0, #0x69d7c50
0069D7C30  adrp     x0, #0x8f31000
0069D7C34  ldr      x0, [x0, #0x328] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<MultiAngleModParams, WeaponMultiAngleModProcessor>..ctor()
0069D7C38  bl       #0x382bd14 ; 
0069D7C3C  adrp     x0, #0x8f31000
0069D7C40  ldr      x0, [x0, #0x320] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleMod..ctor()
0069D7C44  bl       #0x382bd14 ; 
0069D7C48  mov      w8, #1
0069D7C4C  strb     w8, [x20, #0x376]
0069D7C50  ldr      x1, [x21]
0069D7C54  ldrb     w8, [x1, #0x53]
0069D7C58  tbnz     w8, #5, #0x69d7c78
0069D7C5C  adrp     x8, #0x8f31000
0069D7C60  ldr      x8, [x8, #0x328] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<MultiAngleModParams, WeaponMultiAngleModProcessor>..ctor()
0069D7C64  mov      x0, x19
0069D7C68  ldp      x20, x19, [sp, #0x10]
0069D7C6C  ldr      x1, [x8]
0069D7C70  ldp      x30, x21, [sp], #0x20
0069D7C74  b        #0x58c8684 ; HotFix.BattleLogic.WeaponModBase<object, object>$$.ctor
0069D7C78  ldr      x2, [x1, #0x60]
0069D7C7C  mov      x0, x19
0069D7C80  ldp      x20, x19, [sp, #0x10]
0069D7C84  ldp      x30, x21, [sp], #0x20
0069D7C88  br       x2

