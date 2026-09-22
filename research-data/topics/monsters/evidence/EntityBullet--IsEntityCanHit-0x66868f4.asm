; HotFix.BattleLogic.EntityBullet$$IsEntityCanHit
; RVA 0x66868F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066868F4  str      x30, [sp, #-0x30]!
0066868F8  stp      x22, x21, [sp, #0x10]
0066868FC  stp      x20, x19, [sp, #0x20]
006686900  adrp     x21, #0x9599000
006686904  adrp     x22, #0x8f10000
006686908  ldrb     w8, [x21, #0xfa4]
00668690C  ldr      x22, [x22, #0x358] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.IsEntityCanHit()
006686910  mov      x20, x1
006686914  mov      x19, x0
006686918  tbnz     w8, #0, #0x6686948
00668691C  adrp     x0, #0x8f10000
006686920  ldr      x0, [x0, #0x360] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityRef, FP>.TryGetValue()
006686924  bl       #0x382bd14 ; 
006686928  adrp     x0, #0x8ee6000
00668692C  ldr      x0, [x0, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_InstanceId()
006686930  bl       #0x382bd14 ; 
006686934  adrp     x0, #0x8f10000
006686938  ldr      x0, [x0, #0x358] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.IsEntityCanHit()
00668693C  bl       #0x382bd14 ; 
006686940  mov      w8, #1
006686944  strb     w8, [x21, #0xfa4]
006686948  ldr      x2, [x22]
00668694C  ldrb     w8, [x2, #0x53]
006686950  tbnz     w8, #5, #0x6686974
006686954  str      xzr, [sp, #8]
006686958  cbz      x20, #0x6686a38
00668695C  mov      x0, x20
006686960  mov      x1, xzr
006686964  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
006686968  tbz      w0, #0, #0x6686990
00668696C  mov      w0, wzr
006686970  b        #0x6686a28 ; 
006686974  ldr      x3, [x2, #0x60]
006686978  mov      x0, x19
00668697C  mov      x1, x20
006686980  ldp      x20, x19, [sp, #0x20]
006686984  ldp      x22, x21, [sp, #0x10]
006686988  ldr      x30, [sp], #0x30
00668698C  br       x3
006686990  adrp     x22, #0x8ee6000
006686994  ldr      x22, [x22, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_InstanceId()
006686998  ldr      x21, [x19, #0xd8]
00668699C  ldr      x1, [x22]
0066869A0  ldrb     w8, [x1, #0x53]
0066869A4  tbnz     w8, #5, #0x66869b0
0066869A8  ldr      x1, [x20, #0x28]
0066869AC  b        #0x66869c0 ; 
0066869B0  ldr      x8, [x1, #0x60]
0066869B4  mov      x0, x20
0066869B8  blr      x8
0066869BC  mov      x1, x0
0066869C0  cbz      x21, #0x6686a38
0066869C4  adrp     x8, #0x8f10000
0066869C8  ldr      x8, [x8, #0x360] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityRef, FP>.TryGetValue()
0066869CC  add      x2, sp, #8
0066869D0  mov      x0, x21
0066869D4  ldr      x3, [x8]
0066869D8  bl       #0x5dcb348 ; System.Collections.Generic.Dictionary<EntityRef, FP>$$TryGetValue
0066869DC  tbz      w0, #0, #0x66869f8
0066869E0  ldr      x8, [x19, #0x88]
0066869E4  ldr      x9, [sp, #8]
0066869E8  ldr      x10, [x19, #0xc8]
0066869EC  sub      x8, x8, x9
0066869F0  cmp      x8, x10
0066869F4  b.lt     #0x668696c
0066869F8  ldr      x1, [x22]
0066869FC  ldrb     w8, [x1, #0x53]
006686A00  tbnz     w8, #5, #0x6686a0c
006686A04  ldr      x1, [x20, #0x28]
006686A08  b        #0x6686a1c ; 
006686A0C  ldr      x8, [x1, #0x60]
006686A10  mov      x0, x20
006686A14  blr      x8
006686A18  mov      x1, x0
006686A1C  mov      x0, x19
006686A20  bl       #0x6686a3c ; HotFix.BattleLogic.EntityBullet$$SetHitEntity
006686A24  mov      w0, #1
006686A28  ldp      x20, x19, [sp, #0x20]
006686A2C  ldp      x22, x21, [sp, #0x10]
006686A30  ldr      x30, [sp], #0x30
006686A34  ret      
006686A38  bl       #0x382bfb8 ; 

