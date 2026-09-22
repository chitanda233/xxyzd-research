; HotFix.BattleLogic.BulletData$$CreateCircleShape
; RVA 0x6679A50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006679A50  sub      sp, sp, #0x140
006679A54  stp      x29, x30, [sp, #0xe0]
006679A58  stp      x28, x27, [sp, #0xf0]
006679A5C  stp      x26, x25, [sp, #0x100]
006679A60  stp      x24, x23, [sp, #0x110]
006679A64  stp      x22, x21, [sp, #0x120]
006679A68  stp      x20, x19, [sp, #0x130]
006679A6C  mrs      x23, tpidr_el0
006679A70  ldr      x8, [x23, #0x28]
006679A74  adrp     x21, #0x9599000
006679A78  adrp     x22, #0x8f0f000
006679A7C  mov      x20, x1
006679A80  str      x8, [sp, #0xd8]
006679A84  ldrb     w8, [x21, #0xea4]
006679A88  ldr      x22, [x22, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.BulletData.CreateCircleShape()
006679A8C  mov      x19, x0
006679A90  tbnz     w8, #0, #0x6679aa8
006679A94  adrp     x0, #0x8f0f000
006679A98  ldr      x0, [x0, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.BulletData.CreateCircleShape()
006679A9C  bl       #0x382bd14 ; 
006679AA0  mov      w8, #1
006679AA4  strb     w8, [x21, #0xea4]
006679AA8  ldr      x2, [x22]
006679AAC  ldrb     w8, [x2, #0x53]
006679AB0  tbnz     w8, #5, #0x6679afc
006679AB4  adrp     x24, #0x9591000
006679AB8  ldrb     w8, [x24, #0xa81]
006679ABC  movi     v0.2d, #0000000000000000
006679AC0  stp      q0, q0, [sp, #0x70]
006679AC4  stp      q0, q0, [sp, #0x50]
006679AC8  cbnz     w8, #0x6679ae0
006679ACC  adrp     x0, #0x8ee6000
006679AD0  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679AD4  bl       #0x382bd14 ; 
006679AD8  mov      w8, #1
006679ADC  strb     w8, [x24, #0xa81]
006679AE0  adrp     x26, #0x8ee6000
006679AE4  ldr      x26, [x26, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679AE8  ldr      x1, [x26]
006679AEC  ldrb     w8, [x1, #0x53]
006679AF0  tbnz     w8, #5, #0x6679b0c
006679AF4  ldr      x21, [x19, #0x330]
006679AF8  b        #0x6679b1c ; 
006679AFC  ldr      x8, [x2, #0x60]
006679B00  mov      x0, x19
006679B04  mov      x1, x20
006679B08  b        #0x6679e0c ; 
006679B0C  ldr      x8, [x1, #0x60]
006679B10  mov      x0, x19
006679B14  blr      x8
006679B18  mov      x21, x0
006679B1C  cbz      x21, #0x6679e40
006679B20  adrp     x25, #0x9594000
006679B24  ldrb     w8, [x25, #0x277]
006679B28  cbnz     w8, #0x6679b40
006679B2C  adrp     x0, #0x8ee9000
006679B30  ldr      x0, [x0, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
006679B34  bl       #0x382bd14 ; 
006679B38  mov      w8, #1
006679B3C  strb     w8, [x25, #0x277]
006679B40  adrp     x27, #0x8ee9000
006679B44  ldr      x27, [x27, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
006679B48  ldr      x1, [x27]
006679B4C  ldrb     w8, [x1, #0x53]
006679B50  tbnz     w8, #5, #0x6679b5c
006679B54  ldr      x0, [x21, #0x100]
006679B58  b        #0x6679b68 ; 
006679B5C  ldr      x8, [x1, #0x60]
006679B60  mov      x0, x21
006679B64  blr      x8
006679B68  cbz      x0, #0x6679e40
006679B6C  ldrb     w8, [x24, #0xa81]
006679B70  ldr      x22, [x0, #0x18]
006679B74  cbnz     w8, #0x6679b8c
006679B78  adrp     x0, #0x8ee6000
006679B7C  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679B80  bl       #0x382bd14 ; 
006679B84  mov      w8, #1
006679B88  strb     w8, [x24, #0xa81]
006679B8C  ldr      x1, [x26]
006679B90  ldrb     w8, [x1, #0x53]
006679B94  tbnz     w8, #5, #0x6679ba0
006679B98  ldr      x21, [x19, #0x330]
006679B9C  b        #0x6679bb0 ; 
006679BA0  ldr      x8, [x1, #0x60]
006679BA4  mov      x0, x19
006679BA8  blr      x8
006679BAC  mov      x21, x0
006679BB0  cbz      x21, #0x6679e40
006679BB4  adrp     x28, #0x9594000
006679BB8  ldrb     w8, [x28, #0x276]
006679BBC  cbnz     w8, #0x6679bd4
006679BC0  adrp     x0, #0x8ee9000
006679BC4  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
006679BC8  bl       #0x382bd14 ; 
006679BCC  mov      w8, #1
006679BD0  strb     w8, [x28, #0x276]
006679BD4  adrp     x8, #0x8ee9000
006679BD8  ldr      x8, [x8, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
006679BDC  ldr      x1, [x8]
006679BE0  ldrb     w8, [x1, #0x53]
006679BE4  tbnz     w8, #5, #0x6679bf0
006679BE8  ldr      x0, [x21, #0xe8]
006679BEC  b        #0x6679bfc ; 
006679BF0  ldr      x8, [x1, #0x60]
006679BF4  mov      x0, x21
006679BF8  blr      x8
006679BFC  cbz      x0, #0x6679e40
006679C00  ldr      w8, [x0, #0x18]
006679C04  cbz      w8, #0x6679e44
006679C08  ldr      x8, [x0, #0x20]
006679C0C  mul      x8, x8, x20
006679C10  asr      x21, x8, #0x10
006679C14  cbz      x22, #0x6679c48
006679C18  ldrb     w8, [x24, #0xa81]
006679C1C  cbnz     w8, #0x6679c34
006679C20  adrp     x0, #0x8ee6000
006679C24  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679C28  bl       #0x382bd14 ; 
006679C2C  mov      w8, #1
006679C30  strb     w8, [x24, #0xa81]
006679C34  ldr      x1, [x26]
006679C38  ldrb     w8, [x1, #0x53]
006679C3C  tbnz     w8, #5, #0x6679c5c
006679C40  ldr      x22, [x19, #0x330]
006679C44  b        #0x6679c6c ; 
006679C48  add      x8, sp, #0x90
006679C4C  mov      x0, x21
006679C50  mov      x1, xzr
006679C54  mov      x2, xzr
006679C58  b        #0x6679d78 ; 
006679C5C  ldr      x8, [x1, #0x60]
006679C60  mov      x0, x19
006679C64  blr      x8
006679C68  mov      x22, x0
006679C6C  cbz      x22, #0x6679e40
006679C70  ldrb     w8, [x25, #0x277]
006679C74  cbnz     w8, #0x6679c8c
006679C78  adrp     x0, #0x8ee9000
006679C7C  ldr      x0, [x0, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
006679C80  bl       #0x382bd14 ; 
006679C84  mov      w8, #1
006679C88  strb     w8, [x25, #0x277]
006679C8C  ldr      x1, [x27]
006679C90  ldrb     w8, [x1, #0x53]
006679C94  tbnz     w8, #5, #0x6679ca0
006679C98  ldr      x0, [x22, #0x100]
006679C9C  b        #0x6679cac ; 
006679CA0  ldr      x8, [x1, #0x60]
006679CA4  mov      x0, x22
006679CA8  blr      x8
006679CAC  cbz      x0, #0x6679e40
006679CB0  ldr      w8, [x0, #0x18]
006679CB4  cbz      w8, #0x6679e44
006679CB8  ldrb     w8, [x24, #0xa81]
006679CBC  ldr      x28, [x0, #0x20]
006679CC0  cbnz     w8, #0x6679cd8
006679CC4  adrp     x0, #0x8ee6000
006679CC8  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679CCC  bl       #0x382bd14 ; 
006679CD0  mov      w8, #1
006679CD4  strb     w8, [x24, #0xa81]
006679CD8  ldr      x1, [x26]
006679CDC  ldrb     w8, [x1, #0x53]
006679CE0  tbnz     w8, #5, #0x6679cec
006679CE4  ldr      x22, [x19, #0x330]
006679CE8  b        #0x6679cfc ; 
006679CEC  ldr      x8, [x1, #0x60]
006679CF0  mov      x0, x19
006679CF4  blr      x8
006679CF8  mov      x22, x0
006679CFC  cbz      x22, #0x6679e40
006679D00  ldrb     w8, [x25, #0x277]
006679D04  cbnz     w8, #0x6679d1c
006679D08  adrp     x0, #0x8ee9000
006679D0C  ldr      x0, [x0, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ShapeOffset()
006679D10  bl       #0x382bd14 ; 
006679D14  mov      w8, #1
006679D18  strb     w8, [x25, #0x277]
006679D1C  ldr      x1, [x27]
006679D20  ldrb     w8, [x1, #0x53]
006679D24  tbnz     w8, #5, #0x6679d30
006679D28  ldr      x0, [x22, #0x100]
006679D2C  b        #0x6679d3c ; 
006679D30  ldr      x8, [x1, #0x60]
006679D34  mov      x0, x22
006679D38  blr      x8
006679D3C  cbz      x0, #0x6679e40
006679D40  ldr      w8, [x0, #0x18]
006679D44  cbz      w8, #0x6679e44
006679D48  ldr      x8, [x0, #0x20]
006679D4C  mul      x9, x28, x20
006679D50  asr      x1, x9, #0x10
006679D54  add      x0, sp, #0x40
006679D58  mul      x8, x8, x20
006679D5C  asr      x2, x8, #0x10
006679D60  mov      x3, xzr
006679D64  stp      xzr, xzr, [sp, #0x40]
006679D68  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
006679D6C  ldp      x1, x2, [sp, #0x40]
006679D70  add      x8, sp, #0x90
006679D74  mov      x0, x21
006679D78  mov      x3, xzr
006679D7C  bl       #0x7e29220 ; Quantum.Shape2D$$CreateCircle
006679D80  ldp      q0, q1, [sp, #0x90]
006679D84  ldp      q2, q3, [sp, #0xb0]
006679D88  stp      q0, q1, [sp, #0x50]
006679D8C  stp      q2, q3, [sp, #0x70]
006679D90  cbz      x19, #0x6679e40
006679D94  adrp     x20, #0x9599000
006679D98  ldp      q0, q1, [sp, #0x50]
006679D9C  ldp      q2, q3, [sp, #0x70]
006679DA0  ldrb     w8, [x20, #0xed7]
006679DA4  stp      q0, q1, [sp]
006679DA8  stp      q2, q3, [sp, #0x20]
006679DAC  cbnz     w8, #0x6679dc4
006679DB0  adrp     x0, #0x8f0f000
006679DB4  ldr      x0, [x0, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_Shape()
006679DB8  bl       #0x382bd14 ; 
006679DBC  mov      w8, #1
006679DC0  strb     w8, [x20, #0xed7]
006679DC4  adrp     x8, #0x8f0f000
006679DC8  ldr      x8, [x8, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_Shape()
006679DCC  ldr      x2, [x8]
006679DD0  ldrb     w8, [x2, #0x53]
006679DD4  tbnz     w8, #5, #0x6679df0
006679DD8  ldp      q0, q1, [sp, #0x20]
006679DDC  ldp      q2, q3, [sp]
006679DE0  add      x8, x19, #0x1c8
006679DE4  stp      q0, q1, [x8, #0x20]
006679DE8  stp      q2, q3, [x8]
006679DEC  b        #0x6679e10 ; 
006679DF0  ldp      q0, q1, [sp]
006679DF4  ldp      q2, q3, [sp, #0x20]
006679DF8  ldr      x8, [x2, #0x60]
006679DFC  add      x1, sp, #0x90
006679E00  stp      q0, q1, [sp, #0x90]
006679E04  stp      q2, q3, [sp, #0xb0]
006679E08  mov      x0, x19
006679E0C  blr      x8
006679E10  ldr      x8, [x23, #0x28]
006679E14  ldr      x9, [sp, #0xd8]
006679E18  cmp      x8, x9
006679E1C  b.ne     #0x6679e48
006679E20  ldp      x20, x19, [sp, #0x130]
006679E24  ldp      x22, x21, [sp, #0x120]
006679E28  ldp      x24, x23, [sp, #0x110]
006679E2C  ldp      x26, x25, [sp, #0x100]
006679E30  ldp      x28, x27, [sp, #0xf0]
006679E34  ldp      x29, x30, [sp, #0xe0]
006679E38  add      sp, sp, #0x140
006679E3C  ret      
006679E40  bl       #0x382bfb8 ; 
006679E44  bl       #0x382bfc0 ; 
006679E48  bl       #0x89edb60 ; 

