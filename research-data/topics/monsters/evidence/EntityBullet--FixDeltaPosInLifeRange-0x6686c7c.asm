; HotFix.BattleLogic.EntityBullet$$FixDeltaPosInLifeRange
; RVA 0x6686C7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006686C7C  sub      sp, sp, #0x120
006686C80  str      x29, [sp, #0xc0]
006686C84  stp      x30, x27, [sp, #0xd0]
006686C88  stp      x26, x25, [sp, #0xe0]
006686C8C  stp      x24, x23, [sp, #0xf0]
006686C90  stp      x22, x21, [sp, #0x100]
006686C94  stp      x20, x19, [sp, #0x110]
006686C98  mrs      x22, tpidr_el0
006686C9C  mov      x19, x8
006686CA0  ldr      x8, [x22, #0x28]
006686CA4  adrp     x23, #0x9599000
006686CA8  adrp     x24, #0x8f10000
006686CAC  mov      x21, x1
006686CB0  str      x8, [sp, #0xb8]
006686CB4  ldrb     w8, [x23, #0xfa8]
006686CB8  ldr      x24, [x24, #0x398] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.FixDeltaPosInLifeRange()
006686CBC  mov      x20, x0
006686CC0  tbnz     w8, #0, #0x6686ce4
006686CC4  adrp     x0, #0x8ee6000
006686CC8  ldr      x0, [x0, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<BulletData>.get_Data()
006686CCC  bl       #0x382bd14 ; 
006686CD0  adrp     x0, #0x8f10000
006686CD4  ldr      x0, [x0, #0x398] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.FixDeltaPosInLifeRange()
006686CD8  bl       #0x382bd14 ; 
006686CDC  mov      w8, #1
006686CE0  strb     w8, [x23, #0xfa8]
006686CE4  ldr      x2, [x24]
006686CE8  ldrb     w8, [x2, #0x53]
006686CEC  tbnz     w8, #5, #0x6686d28
006686CF0  mov      x0, x20
006686CF4  bl       #0x6682530 ; HotFix.BattleLogic.EntityBullet$$get_IgnoreDisCheck
006686CF8  tbnz     w0, #0, #0x6686e24
006686CFC  mov      x0, x20
006686D00  bl       #0x6681f5c ; HotFix.BattleLogic.EntityBullet$$get_Persistence
006686D04  tbnz     w0, #0, #0x6686e24
006686D08  str      xzr, [x21, #8]
006686D0C  adrp     x23, #0x8ee6000
006686D10  ldr      x23, [x23, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<BulletData>.get_Data()
006686D14  ldr      x1, [x23]
006686D18  ldrb     w8, [x1, #0x53]
006686D1C  tbnz     w8, #5, #0x6686d50
006686D20  ldr      x0, [x20, #0x38]
006686D24  b        #0x6686d5c ; 
006686D28  ldr      x8, [x21, #0x10]
006686D2C  ldr      q0, [x21]
006686D30  ldr      x9, [x2, #0x60]
006686D34  add      x1, sp, #0x60
006686D38  str      x8, [sp, #0x70]
006686D3C  mov      x8, x19
006686D40  mov      x0, x20
006686D44  str      q0, [sp, #0x60]
006686D48  blr      x9
006686D4C  b        #0x6686e34 ; 
006686D50  ldr      x8, [x1, #0x60]
006686D54  mov      x0, x20
006686D58  blr      x8
006686D5C  cbz      x0, #0x6686ed8
006686D60  add      x8, sp, #0xa0
006686D64  mov      x1, xzr
006686D68  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006686D6C  ldr      x1, [x23]
006686D70  ldr      x25, [sp, #0xa0]
006686D74  ldr      x24, [sp, #0xb0]
006686D78  ldr      x26, [x21]
006686D7C  ldrb     w8, [x1, #0x53]
006686D80  ldr      x27, [x21, #0x10]
006686D84  tbnz     w8, #5, #0x6686d90
006686D88  ldr      x0, [x20, #0x38]
006686D8C  b        #0x6686d9c ; 
006686D90  ldr      x8, [x1, #0x60]
006686D94  mov      x0, x20
006686D98  blr      x8
006686D9C  cbz      x0, #0x6686ed8
006686DA0  ldr      x10, [x0, #0x260]
006686DA4  ldr      q0, [x20, #0x90]
006686DA8  ldr      x12, [x20, #0xa0]
006686DAC  add      x8, x26, x25
006686DB0  add      x9, x27, x24
006686DB4  mov      w11, #0x3333
006686DB8  add      x0, sp, #0x48
006686DBC  add      x1, sp, #0x30
006686DC0  mov      x2, xzr
006686DC4  stp      x8, xzr, [sp, #0x48]
006686DC8  add      x24, x10, x11
006686DCC  str      x12, [sp, #0x40]
006686DD0  str      q0, [sp, #0x30]
006686DD4  str      x9, [sp, #0x58]
006686DD8  bl       #0x7d5077c ; Photon.Deterministic.FPVector3$$DistanceSquared
006686DDC  mul      x8, x24, x24
006686DE0  cmp      x0, x8, asr #16
006686DE4  b.le     #0x6686e24
006686DE8  ldr      x8, [x21, #0x10]
006686DEC  ldr      q0, [x21]
006686DF0  add      x0, sp, #0x80
006686DF4  mov      x1, xzr
006686DF8  str      x8, [sp, #0x90]
006686DFC  add      x8, sp, #0xa0
006686E00  str      q0, [sp, #0x80]
006686E04  bl       #0x7d4fef8 ; Photon.Deterministic.FPVector3$$Normalize
006686E08  ldr      x1, [x23]
006686E0C  ldp      x25, x23, [sp, #0xa0]
006686E10  ldr      x21, [sp, #0xb0]
006686E14  ldrb     w8, [x1, #0x53]
006686E18  tbnz     w8, #5, #0x6686e64
006686E1C  ldr      x0, [x20, #0x38]
006686E20  b        #0x6686e70 ; 
006686E24  ldr      x8, [x21, #0x10]
006686E28  ldr      q0, [x21]
006686E2C  str      x8, [x19, #0x10]
006686E30  str      q0, [x19]
006686E34  ldr      x8, [x22, #0x28]
006686E38  ldr      x9, [sp, #0xb8]
006686E3C  cmp      x8, x9
006686E40  b.ne     #0x6686edc
006686E44  ldp      x20, x19, [sp, #0x110]
006686E48  ldp      x22, x21, [sp, #0x100]
006686E4C  ldp      x24, x23, [sp, #0xf0]
006686E50  ldp      x26, x25, [sp, #0xe0]
006686E54  ldp      x30, x27, [sp, #0xd0]
006686E58  ldr      x29, [sp, #0xc0]
006686E5C  add      sp, sp, #0x120
006686E60  ret      
006686E64  ldr      x8, [x1, #0x60]
006686E68  mov      x0, x20
006686E6C  blr      x8
006686E70  cbz      x0, #0x6686ed8
006686E74  add      x8, sp, #0xa0
006686E78  mov      x1, xzr
006686E7C  add      x20, x20, #0x90
006686E80  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006686E84  ldr      x8, [x20, #0x10]
006686E88  ldr      q0, [x20]
006686E8C  ldr      x9, [sp, #0xa0]
006686E90  ldr      x10, [sp, #0xb0]
006686E94  add      x0, sp, #0x18
006686E98  mov      x1, sp
006686E9C  mov      x2, xzr
006686EA0  stp      x8, x9, [sp, #0x10]
006686EA4  str      q0, [sp]
006686EA8  stp      xzr, x10, [sp, #0x20]
006686EAC  bl       #0x7d5071c ; Photon.Deterministic.FPVector3$$Distance
006686EB0  sub      x8, x24, x0
006686EB4  mul      x9, x8, x25
006686EB8  mul      x10, x8, x23
006686EBC  mul      x8, x8, x21
006686EC0  asr      x9, x9, #0x10
006686EC4  asr      x10, x10, #0x10
006686EC8  asr      x8, x8, #0x10
006686ECC  stp      x9, x10, [x19]
006686ED0  str      x8, [x19, #0x10]
006686ED4  b        #0x6686e34 ; 
006686ED8  bl       #0x382bfb8 ; 
006686EDC  bl       #0x89edb60 ; 

