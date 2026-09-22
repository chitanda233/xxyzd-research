; HotFix.BattleLogic.CharacterBackDeathFireBullet$$OnReadParams
; RVA 0x6817BA4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006817BA4  sub      sp, sp, #0x40
006817BA8  stp      x30, x23, [sp, #0x10]
006817BAC  stp      x22, x21, [sp, #0x20]
006817BB0  stp      x20, x19, [sp, #0x30]
006817BB4  adrp     x22, #0x959b000
006817BB8  adrp     x23, #0x8f21000
006817BBC  ldrb     w8, [x22, #0x5f8]
006817BC0  ldr      x23, [x23, #0xab0] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet.OnReadParams()
006817BC4  mov      x21, x2
006817BC8  mov      w20, w1
006817BCC  mov      x19, x0
006817BD0  tbnz     w8, #0, #0x6817c24
006817BD4  adrp     x0, #0x8f21000
006817BD8  ldr      x0, [x0, #0xab0] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet.OnReadParams()
006817BDC  bl       #0x382bd14 ; 
006817BE0  adrp     x0, #0x8f21000
006817BE4  ldr      x0, [x0, #0xa08] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, object>.Add()
006817BE8  bl       #0x382bd14 ; 
006817BEC  adrp     x0, #0x8f21000
006817BF0  ldr      x0, [x0, #0xa10] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, object>.TryGetValue()
006817BF4  bl       #0x382bd14 ; 
006817BF8  adrp     x0, #0x8f21000
006817BFC  ldr      x0, [x0, #0xab8] ; GLOBAL HotFix.BattleLogic.CharacterBackDeathFireBullet.DieBulletData_TypeInfo
006817C00  bl       #0x382bd14 ; 
006817C04  adrp     x0, #0x8f21000
006817C08  ldr      x0, [x0, #0xac0] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<CharacterBackDeathFireBullet.DieBulletData>()
006817C0C  bl       #0x382bd14 ; 
006817C10  adrp     x0, #0x8ee2000
006817C14  ldr      x0, [x0, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
006817C18  bl       #0x382bd14 ; 
006817C1C  mov      w8, #1
006817C20  strb     w8, [x22, #0x5f8]
006817C24  ldr      x3, [x23]
006817C28  ldrb     w8, [x3, #0x53]
006817C2C  tbnz     w8, #5, #0x6817c70
006817C30  adrp     x22, #0x9591000
006817C34  ldrb     w8, [x22, #0xa4b]
006817C38  str      xzr, [sp, #8]
006817C3C  cbnz     w8, #0x6817c54
006817C40  adrp     x0, #0x8ee5000
006817C44  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006817C48  bl       #0x382bd14 ; 
006817C4C  mov      w8, #1
006817C50  strb     w8, [x22, #0xa4b]
006817C54  adrp     x23, #0x8ee5000
006817C58  ldr      x23, [x23, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006817C5C  ldr      x1, [x23]
006817C60  ldrb     w8, [x1, #0x53]
006817C64  tbnz     w8, #5, #0x6817c94
006817C68  ldr      x0, [x19, #0x20]
006817C6C  b        #0x6817ca0 ; 
006817C70  ldr      x4, [x3, #0x60]
006817C74  mov      x0, x19
006817C78  mov      w1, w20
006817C7C  mov      x2, x21
006817C80  ldp      x20, x19, [sp, #0x30]
006817C84  ldp      x22, x21, [sp, #0x20]
006817C88  ldp      x30, x23, [sp, #0x10]
006817C8C  add      sp, sp, #0x40
006817C90  br       x4
006817C94  ldr      x8, [x1, #0x60]
006817C98  mov      x0, x19
006817C9C  blr      x8
006817CA0  cbz      x0, #0x6817df0
006817CA4  ldr      x0, [x0, #0x70]
006817CA8  cbz      x0, #0x6817df0
006817CAC  adrp     x8, #0x8f21000
006817CB0  ldr      x8, [x8, #0xa10] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, object>.TryGetValue()
006817CB4  add      x2, sp, #8
006817CB8  mov      w1, w20
006817CBC  ldr      x3, [x8]
006817CC0  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
006817CC4  ldr      x1, [sp, #8]
006817CC8  cbz      x1, #0x6817d30
006817CCC  adrp     x8, #0x8f21000
006817CD0  ldr      x8, [x8, #0xab8] ; GLOBAL HotFix.BattleLogic.CharacterBackDeathFireBullet.DieBulletData_TypeInfo
006817CD4  ldr      x10, [x1]
006817CD8  ldr      x8, [x8]
006817CDC  ldrb     w11, [x10, #0x130]
006817CE0  ldrb     w9, [x8, #0x130]
006817CE4  cmp      w11, w9
006817CE8  b.lo     #0x6817de4
006817CEC  ldr      x11, [x10, #0xc8]
006817CF0  sub      x10, x9, #1
006817CF4  ldr      x11, [x11, x10, lsl #3]
006817CF8  cmp      x11, x8
006817CFC  b.ne     #0x6817de4
006817D00  str      x1, [x19, #0x80]!
006817D04  ldr      x11, [x1]
006817D08  ldrb     w12, [x11, #0x130]
006817D0C  cmp      w12, w9
006817D10  b.lo     #0x6817de4
006817D14  ldr      x9, [x11, #0xc8]
006817D18  ldr      x9, [x9, x10, lsl #3]
006817D1C  cmp      x9, x8
006817D20  b.ne     #0x6817de4
006817D24  mov      x0, x19
006817D28  bl       #0x382bcb8 ; 
006817D2C  b        #0x6817dd0 ; 
006817D30  adrp     x8, #0x8ee2000
006817D34  ldr      x8, [x8, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
006817D38  ldr      x0, [x8]
006817D3C  ldr      w8, [x0, #0xe0]
006817D40  cbnz     w8, #0x6817d48
006817D44  bl       #0x382be8c ; 
006817D48  adrp     x8, #0x8f21000
006817D4C  ldr      x8, [x8, #0xac0] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<CharacterBackDeathFireBullet.DieBulletData>()
006817D50  mov      x0, x21
006817D54  ldr      x1, [x8]
006817D58  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
006817D5C  mov      x21, x19
006817D60  str      x0, [x21, #0x80]!
006817D64  mov      x1, x0
006817D68  mov      x0, x21
006817D6C  bl       #0x382bcb8 ; 
006817D70  ldrb     w8, [x22, #0xa4b]
006817D74  cbnz     w8, #0x6817d8c
006817D78  adrp     x0, #0x8ee5000
006817D7C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006817D80  bl       #0x382bd14 ; 
006817D84  mov      w8, #1
006817D88  strb     w8, [x22, #0xa4b]
006817D8C  ldr      x1, [x23]
006817D90  ldrb     w8, [x1, #0x53]
006817D94  tbnz     w8, #5, #0x6817da0
006817D98  ldr      x0, [x19, #0x20]
006817D9C  b        #0x6817dac ; 
006817DA0  ldr      x8, [x1, #0x60]
006817DA4  mov      x0, x19
006817DA8  blr      x8
006817DAC  cbz      x0, #0x6817df0
006817DB0  ldr      x0, [x0, #0x70]
006817DB4  cbz      x0, #0x6817df0
006817DB8  adrp     x8, #0x8f21000
006817DBC  ldr      x2, [x21]
006817DC0  ldr      x8, [x8, #0xa08] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, object>.Add()
006817DC4  mov      w1, w20
006817DC8  ldr      x3, [x8]
006817DCC  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
006817DD0  ldp      x20, x19, [sp, #0x30]
006817DD4  ldp      x22, x21, [sp, #0x20]
006817DD8  ldp      x30, x23, [sp, #0x10]
006817DDC  add      sp, sp, #0x40
006817DE0  ret      
006817DE4  mov      x0, x1
006817DE8  mov      x1, x8
006817DEC  bl       #0x382c354 ; 
006817DF0  bl       #0x382bfb8 ; 

