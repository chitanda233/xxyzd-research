; HotFix.BattleLogic.AI200007$$InitAttackLoop
; RVA 0x6B5594C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B5594C  sub      sp, sp, #0x80
006B55950  str      x30, [sp, #0x40]
006B55954  stp      x24, x23, [sp, #0x50]
006B55958  stp      x22, x21, [sp, #0x60]
006B5595C  stp      x20, x19, [sp, #0x70]
006B55960  mrs      x23, tpidr_el0
006B55964  ldr      x8, [x23, #0x28]
006B55968  adrp     x20, #0x959f000
006B5596C  adrp     x21, #0x8f41000
006B55970  mov      x19, x0
006B55974  str      x8, [sp, #0x38]
006B55978  ldrb     w8, [x20, #0xc5b]
006B5597C  ldr      x21, [x21, #0x788] ; GLOBAL Method$HotFix.BattleLogic.AI200007.InitAttackLoop()
006B55980  tbnz     w8, #0, #0x6b559a4
006B55984  adrp     x0, #0x8f41000
006B55988  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.AI200007.InitAttackLoop()
006B5598C  bl       #0x382bd14 ; 
006B55990  adrp     x0, #0x8ee6000
006B55994  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006B55998  bl       #0x382bd14 ; 
006B5599C  mov      w8, #1
006B559A0  strb     w8, [x20, #0xc5b]
006B559A4  ldr      x1, [x21]
006B559A8  ldrb     w8, [x1, #0x53]
006B559AC  tbnz     w8, #5, #0x6b559d4
006B559B0  ldr      x20, [x19, #0x58]
006B559B4  cbz      x20, #0x6b55b64
006B559B8  adrp     x8, #0x8ee6000
006B559BC  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006B559C0  ldr      x1, [x8]
006B559C4  ldrb     w8, [x1, #0x53]
006B559C8  tbnz     w8, #5, #0x6b559e4
006B559CC  ldr      x21, [x20, #0x38]
006B559D0  b        #0x6b559f8 ; 
006B559D4  ldr      x8, [x1, #0x60]
006B559D8  mov      x0, x19
006B559DC  blr      x8
006B559E0  b        #0x6b55b3c ; 
006B559E4  ldr      x8, [x1, #0x60]
006B559E8  mov      x0, x20
006B559EC  blr      x8
006B559F0  ldr      x20, [x19, #0x58]
006B559F4  mov      x21, x0
006B559F8  adrp     x22, #0x9591000
006B559FC  ldrb     w8, [x22, #0xa4b]
006B55A00  cbnz     w8, #0x6b55a18
006B55A04  adrp     x0, #0x8ee5000
006B55A08  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B55A0C  bl       #0x382bd14 ; 
006B55A10  mov      w8, #1
006B55A14  strb     w8, [x22, #0xa4b]
006B55A18  adrp     x8, #0x8ee5000
006B55A1C  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B55A20  ldr      x1, [x8]
006B55A24  ldrb     w8, [x1, #0x53]
006B55A28  tbnz     w8, #5, #0x6b55a34
006B55A2C  ldr      x22, [x19, #0x20]
006B55A30  b        #0x6b55a44 ; 
006B55A34  ldr      x8, [x1, #0x60]
006B55A38  mov      x0, x19
006B55A3C  blr      x8
006B55A40  mov      x22, x0
006B55A44  cbz      x22, #0x6b55b64
006B55A48  adrp     x24, #0x9598000
006B55A4C  ldrb     w8, [x24, #0xfc4]
006B55A50  cbnz     w8, #0x6b55a68
006B55A54  adrp     x0, #0x8f05000
006B55A58  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr()
006B55A5C  bl       #0x382bd14 ; 
006B55A60  mov      w8, #1
006B55A64  strb     w8, [x24, #0xfc4]
006B55A68  adrp     x8, #0x8f05000
006B55A6C  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr()
006B55A70  ldr      x1, [x8]
006B55A74  ldrb     w8, [x1, #0x53]
006B55A78  tbnz     w8, #5, #0x6b55a84
006B55A7C  ldr      x22, [x22, #0x220]
006B55A80  b        #0x6b55a94 ; 
006B55A84  ldr      x8, [x1, #0x60]
006B55A88  mov      x0, x22
006B55A8C  blr      x8
006B55A90  mov      x22, x0
006B55A94  cbz      x21, #0x6b55b64
006B55A98  add      x8, sp, #0x20
006B55A9C  mov      x0, x21
006B55AA0  mov      x1, xzr
006B55AA4  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006B55AA8  ldr      q0, [sp, #0x20]
006B55AAC  ldr      x8, [sp, #0x30]
006B55AB0  str      q0, [sp]
006B55AB4  str      x8, [sp, #0x10]
006B55AB8  ldr      x0, [x19, #0x58]
006B55ABC  cbz      x0, #0x6b55b64
006B55AC0  mov      x1, xzr
006B55AC4  bl       #0x67f70bc ; HotFix.BattleLogic.EntityCharacter$$GetAttackDistance
006B55AC8  cbz      x22, #0x6b55b64
006B55ACC  ldr      x8, [x22]
006B55AD0  ldr      q0, [sp]
006B55AD4  ldr      x9, [sp, #0x10]
006B55AD8  mov      x2, x0
006B55ADC  ldr      x10, [x8, #0x508]
006B55AE0  str      q0, [sp, #0x20]
006B55AE4  str      x9, [sp, #0x30]
006B55AE8  ldr      x3, [x8, #0x510]
006B55AEC  add      x1, sp, #0x20
006B55AF0  mov      x0, x22
006B55AF4  blr      x10
006B55AF8  cbz      x20, #0x6b55b64
006B55AFC  mov      x1, x0
006B55B00  mov      x0, x20
006B55B04  mov      x2, xzr
006B55B08  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
006B55B0C  ldr      x0, [x19, #0x58]
006B55B10  cbz      x0, #0x6b55b64
006B55B14  mov      x1, xzr
006B55B18  bl       #0x67d59a4 ; HotFix.BattleLogic.EntityCharacter$$get_Target
006B55B1C  cbz      x0, #0x6b55b2c
006B55B20  mov      x0, x19
006B55B24  bl       #0x6b55b6c ; HotFix.BattleLogic.AI200007$$AddAttack
006B55B28  b        #0x6b55b3c ; 
006B55B2C  mov      w1, #2
006B55B30  mov      x0, x19
006B55B34  mov      x2, xzr
006B55B38  bl       #0x6b7ecc4 ; HotFix.BattleLogic.AIStateController$$ActiveState
006B55B3C  ldr      x8, [x23, #0x28]
006B55B40  ldr      x9, [sp, #0x38]
006B55B44  cmp      x8, x9
006B55B48  b.ne     #0x6b55b68
006B55B4C  ldp      x20, x19, [sp, #0x70]
006B55B50  ldp      x22, x21, [sp, #0x60]
006B55B54  ldp      x24, x23, [sp, #0x50]
006B55B58  ldr      x30, [sp, #0x40]
006B55B5C  add      sp, sp, #0x80
006B55B60  ret      
006B55B64  bl       #0x382bfb8 ; 
006B55B68  bl       #0x89edb60 ; 

