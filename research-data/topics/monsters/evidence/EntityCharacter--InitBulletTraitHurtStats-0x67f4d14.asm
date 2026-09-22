; HotFix.BattleLogic.EntityCharacter$$InitBulletTraitHurtStats
; RVA 0x67F4D14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067F4D14  stp      x30, x21, [sp, #-0x20]!
0067F4D18  stp      x20, x19, [sp, #0x10]
0067F4D1C  adrp     x20, #0x959b000
0067F4D20  adrp     x21, #0x8f1f000
0067F4D24  ldrb     w8, [x20, #0x2ee]
0067F4D28  ldr      x21, [x21, #0x930] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitBulletTraitHurtStats()
0067F4D2C  mov      x19, x0
0067F4D30  tbnz     w8, #0, #0x67f4d60
0067F4D34  adrp     x0, #0x8f1f000
0067F4D38  ldr      x0, [x0, #0x930] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitBulletTraitHurtStats()
0067F4D3C  bl       #0x382bd14 ; 
0067F4D40  adrp     x0, #0x8f1f000
0067F4D44  ldr      x0, [x0, #0x938] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, BulletTraitHurtStatsVO>..ctor()
0067F4D48  bl       #0x382bd14 ; 
0067F4D4C  adrp     x0, #0x8f1f000
0067F4D50  ldr      x0, [x0, #0x940] ; GLOBAL Rock.Collections.OrderedDictionary<int, BulletTraitHurtStatsVO>_TypeInfo
0067F4D54  bl       #0x382bd14 ; 
0067F4D58  mov      w8, #1
0067F4D5C  strb     w8, [x20, #0x2ee]
0067F4D60  ldr      x1, [x21]
0067F4D64  ldrb     w8, [x1, #0x53]
0067F4D68  tbnz     w8, #5, #0x67f4dc0
0067F4D6C  adrp     x20, #0x8f1f000
0067F4D70  adrp     x21, #0x8f1f000
0067F4D74  ldr      x20, [x20, #0x940] ; GLOBAL Rock.Collections.OrderedDictionary<int, BulletTraitHurtStatsVO>_TypeInfo
0067F4D78  ldr      x21, [x21, #0x938] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, BulletTraitHurtStatsVO>..ctor()
0067F4D7C  mov      x0, xzr
0067F4D80  str      wzr, [x19, #0x2d0]
0067F4D84  bl       #0x416d554 ; Rock.Collections.Custom.OrderedDictionaryIntComparer$$get_Default
0067F4D88  ldr      x8, [x20]
0067F4D8C  mov      x20, x0
0067F4D90  mov      x0, x8
0067F4D94  bl       #0x382bfa0 ; 
0067F4D98  ldr      x2, [x21]
0067F4D9C  mov      x1, x20
0067F4DA0  mov      x21, x0
0067F4DA4  bl       #0x5224fcc ; Rock.Collections.OrderedDictionary<int, object>$$.ctor
0067F4DA8  add      x0, x19, #0x2d8
0067F4DAC  str      x21, [x19, #0x2d8]
0067F4DB0  ldp      x20, x19, [sp, #0x10]
0067F4DB4  mov      x1, x21
0067F4DB8  ldp      x30, x21, [sp], #0x20
0067F4DBC  b        #0x382bcb8 ; 
0067F4DC0  ldr      x2, [x1, #0x60]
0067F4DC4  mov      x0, x19
0067F4DC8  ldp      x20, x19, [sp, #0x10]
0067F4DCC  ldp      x30, x21, [sp], #0x20
0067F4DD0  br       x2

