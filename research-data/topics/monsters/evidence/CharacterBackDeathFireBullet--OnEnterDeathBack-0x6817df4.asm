; HotFix.BattleLogic.CharacterBackDeathFireBullet$$OnEnterDeathBack
; RVA 0x6817DF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006817DF4  stp      x30, x21, [sp, #-0x20]!
006817DF8  stp      x20, x19, [sp, #0x10]
006817DFC  adrp     x20, #0x959b000
006817E00  adrp     x21, #0x8f21000
006817E04  ldrb     w8, [x20, #0x5f9]
006817E08  ldr      x21, [x21, #0xac8] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet.OnEnterDeathBack()
006817E0C  mov      x19, x0
006817E10  tbnz     w8, #0, #0x6817e28
006817E14  adrp     x0, #0x8f21000
006817E18  ldr      x0, [x0, #0xac8] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet.OnEnterDeathBack()
006817E1C  bl       #0x382bd14 ; 
006817E20  mov      w8, #1
006817E24  strb     w8, [x20, #0x5f9]
006817E28  ldr      x1, [x21]
006817E2C  ldrb     w8, [x1, #0x53]
006817E30  tbnz     w8, #5, #0x6817e40
006817E34  ldp      x20, x19, [sp, #0x10]
006817E38  ldp      x30, x21, [sp], #0x20
006817E3C  ret      
006817E40  ldr      x2, [x1, #0x60]
006817E44  mov      x0, x19
006817E48  ldp      x20, x19, [sp, #0x10]
006817E4C  ldp      x30, x21, [sp], #0x20
006817E50  br       x2

