; HotFix.BattleLogic.EntityCharacterData$$get_IsOneShotWeaponActive
; RVA 0x6821C4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006821C4C  stp      x30, x21, [sp, #-0x20]!
006821C50  stp      x20, x19, [sp, #0x10]
006821C54  adrp     x20, #0x959b000
006821C58  adrp     x21, #0x8f1f000
006821C5C  ldrb     w8, [x20, #0x6ac]
006821C60  ldr      x21, [x21, #0xd38] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsOneShotWeaponActive()
006821C64  mov      x19, x0
006821C68  tbnz     w8, #0, #0x6821c80
006821C6C  adrp     x0, #0x8f1f000
006821C70  ldr      x0, [x0, #0xd38] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsOneShotWeaponActive()
006821C74  bl       #0x382bd14 ; 
006821C78  mov      w8, #1
006821C7C  strb     w8, [x20, #0x6ac]
006821C80  ldr      x1, [x21]
006821C84  ldrb     w8, [x1, #0x53]
006821C88  tbnz     w8, #5, #0x6821c9c
006821C8C  ldrb     w0, [x19, #0x189]
006821C90  ldp      x20, x19, [sp, #0x10]
006821C94  ldp      x30, x21, [sp], #0x20
006821C98  ret      
006821C9C  ldr      x2, [x1, #0x60]
006821CA0  mov      x0, x19
006821CA4  ldp      x20, x19, [sp, #0x10]
006821CA8  ldp      x30, x21, [sp], #0x20
006821CAC  br       x2

