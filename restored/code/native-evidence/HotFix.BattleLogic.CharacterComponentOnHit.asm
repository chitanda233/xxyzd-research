; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitByBullet
; RVA 0x66B6858; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B6858  sub      sp, sp, #0x90
0066B685C  stp      x29, x30, [sp, #0x30]
0066B6860  stp      x28, x27, [sp, #0x40]
0066B6864  stp      x26, x25, [sp, #0x50]
0066B6868  stp      x24, x23, [sp, #0x60]
0066B686C  stp      x22, x21, [sp, #0x70]
0066B6870  stp      x20, x19, [sp, #0x80]
0066B6874  adrp     x21, #0x959a000
0066B6878  adrp     x22, #0x8f11000
0066B687C  ldrb     w8, [x21, #0x202]
0066B6880  ldr      x22, [x22, #0x910]
0066B6884  mov      x19, x1
0066B6888  mov      x20, x0
0066B688C  tbnz     w8, #0, #0x66b68bc
0066B6890  adrp     x0, #0x8f11000
0066B6894  ldr      x0, [x0, #0x910]
0066B6898  bl       #0x382bd14 ; 
0066B689C  adrp     x0, #0x8ee6000
0066B68A0  ldr      x0, [x0, #0x608]
0066B68A4  bl       #0x382bd14 ; 
0066B68A8  adrp     x0, #0x8ee6000
0066B68AC  ldr      x0, [x0, #0x108]
0066B68B0  bl       #0x382bd14 ; 
0066B68B4  mov      w8, #1
0066B68B8  strb     w8, [x21, #0x202]
0066B68BC  ldr      x2, [x22]
0066B68C0  ldrb     w8, [x2, #0x53]
0066B68C4  tbnz     w8, #5, #0x66b68e4
0066B68C8  adrp     x29, #0x8ee6000
0066B68CC  ldr      x29, [x29, #0x608]
0066B68D0  ldr      x1, [x29]
0066B68D4  ldrb     w8, [x1, #0x53]
0066B68D8  tbnz     w8, #5, #0x66b6910
0066B68DC  ldr      x21, [x20, #0x30]
0066B68E0  b        #0x66b6920 ; 
0066B68E4  ldr      x3, [x2, #0x60]
0066B68E8  mov      x0, x20
0066B68EC  mov      x1, x19
0066B68F0  ldp      x20, x19, [sp, #0x80]
0066B68F4  ldp      x22, x21, [sp, #0x70]
0066B68F8  ldp      x24, x23, [sp, #0x60]
0066B68FC  ldp      x26, x25, [sp, #0x50]
0066B6900  ldp      x28, x27, [sp, #0x40]
0066B6904  ldp      x29, x30, [sp, #0x30]
0066B6908  add      sp, sp, #0x90
0066B690C  br       x3
0066B6910  ldr      x8, [x1, #0x60]
0066B6914  mov      x0, x20
0066B6918  blr      x8
0066B691C  mov      x21, x0
0066B6920  cbz      x21, #0x66b6d7c
0066B6924  adrp     x28, #0x9591000
0066B6928  ldrb     w8, [x28, #0xa4b]
0066B692C  cbnz     w8, #0x66b6944
0066B6930  adrp     x0, #0x8ee5000
0066B6934  ldr      x0, [x0, #0xb28]
0066B6938  bl       #0x382bd14 ; 
0066B693C  mov      w8, #1
0066B6940  strb     w8, [x28, #0xa4b]
0066B6944  adrp     x25, #0x8ee5000
0066B6948  ldr      x25, [x25, #0xb28]
0066B694C  ldr      x1, [x25]
0066B6950  ldrb     w8, [x1, #0x53]
0066B6954  tbnz     w8, #5, #0x66b6960
0066B6958  ldr      x21, [x21, #0x20]
0066B695C  b        #0x66b6970 ; 
0066B6960  ldr      x8, [x1, #0x60]
0066B6964  mov      x0, x21
0066B6968  blr      x8
0066B696C  mov      x21, x0
0066B6970  cbz      x21, #0x66b6d80
0066B6974  adrp     x22, #0x9599000
0066B6978  ldrb     w8, [x22, #0x4c3]
0066B697C  cbnz     w8, #0x66b6994
0066B6980  adrp     x0, #0x8f08000
0066B6984  ldr      x0, [x0, #0xfe0]
0066B6988  bl       #0x382bd14 ; 
0066B698C  mov      w8, #1
0066B6990  strb     w8, [x22, #0x4c3]
0066B6994  adrp     x8, #0x8f08000
0066B6998  ldr      x8, [x8, #0xfe0]
0066B699C  ldr      x1, [x8]
0066B69A0  ldrb     w8, [x1, #0x53]
0066B69A4  tbnz     w8, #5, #0x66b69b4
0066B69A8  ldrb     w8, [x21, #0x120]
0066B69AC  cbnz     w8, #0x66b6d5c
0066B69B0  b        #0x66b69c4 ; 
0066B69B4  ldr      x8, [x1, #0x60]
0066B69B8  mov      x0, x21
0066B69BC  blr      x8
0066B69C0  tbnz     w0, #0, #0x66b6d5c
0066B69C4  cbz      x19, #0x66b6d84
0066B69C8  adrp     x21, #0x959a000
0066B69CC  ldrb     w8, [x21, #0x269]
0066B69D0  cbnz     w8, #0x66b69e8
0066B69D4  adrp     x0, #0x8f0f000
0066B69D8  ldr      x0, [x0, #0xc78]
0066B69DC  bl       #0x382bd14 ; 
0066B69E0  mov      w8, #1
0066B69E4  strb     w8, [x21, #0x269]
0066B69E8  adrp     x8, #0x8f0f000
0066B69EC  ldr      x8, [x8, #0xc78]
0066B69F0  ldr      x1, [x8]
0066B69F4  ldrb     w8, [x1, #0x53]
0066B69F8  tbnz     w8, #5, #0x66b6a04
0066B69FC  ldr      x21, [x19, #0x80]
0066B6A00  b        #0x66b6a14 ; 
0066B6A04  ldr      x8, [x1, #0x60]
0066B6A08  mov      x0, x19
0066B6A0C  blr      x8
0066B6A10  mov      x21, x0
0066B6A14  mov      x0, x20
0066B6A18  mov      x1, x21
0066B6A1C  bl       #0x66b6e54 ; HotFix.BattleLogic.CharacterComponentOnHit$$TryInterceptHeroBoundBulletByWingPlaneResist
0066B6A20  tbnz     w0, #0, #0x66b6d5c
0066B6A24  mov      w1, #1
0066B6A28  mov      x0, x20
0066B6A2C  bl       #0x66b7188 ; HotFix.BattleLogic.CharacterComponentOnHit$$dispatchHittedTriggerEvent
0066B6A30  mov      x0, x20
0066B6A34  bl       #0x66b7518 ; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndUpdateHitTime
0066B6A38  tbz      w0, #0, #0x66b6d5c
0066B6A3C  adrp     x22, #0x959a000
0066B6A40  ldrb     w8, [x22, #0x26a]
0066B6A44  cbnz     w8, #0x66b6a5c
0066B6A48  adrp     x0, #0x8f0f000
0066B6A4C  ldr      x0, [x0, #0xc80]
0066B6A50  bl       #0x382bd14 ; 
0066B6A54  mov      w8, #1
0066B6A58  strb     w8, [x22, #0x26a]
0066B6A5C  adrp     x8, #0x8f0f000
0066B6A60  ldr      x8, [x8, #0xc80]
0066B6A64  ldr      x1, [x8]
0066B6A68  ldrb     w8, [x1, #0x53]
0066B6A6C  tbnz     w8, #5, #0x66b6a78
0066B6A70  ldr      x22, [x19, #0x88]
0066B6A74  b        #0x66b6a88 ; 
0066B6A78  ldr      x8, [x1, #0x60]
0066B6A7C  mov      x0, x19
0066B6A80  blr      x8
0066B6A84  mov      x22, x0
0066B6A88  cbz      x22, #0x66b6d88
0066B6A8C  adrp     x23, #0x9591000
0066B6A90  ldrb     w8, [x23, #0xa6f]
0066B6A94  cbnz     w8, #0x66b6aac
0066B6A98  adrp     x0, #0x8ee6000
0066B6A9C  ldr      x0, [x0, #0x260]
0066B6AA0  bl       #0x382bd14 ; 
0066B6AA4  mov      w8, #1
0066B6AA8  strb     w8, [x23, #0xa6f]
0066B6AAC  adrp     x8, #0x8ee6000
0066B6AB0  ldr      x8, [x8, #0x260]
0066B6AB4  ldr      x1, [x8]
0066B6AB8  ldrb     w8, [x1, #0x53]
0066B6ABC  tbnz     w8, #5, #0x66b6acc
0066B6AC0  ldr      x8, [x22, #0x1b8]
0066B6AC4  str      x8, [sp, #0x20]
0066B6AC8  b        #0x66b6adc ; 
0066B6ACC  ldr      x8, [x1, #0x60]
0066B6AD0  mov      x0, x22
0066B6AD4  blr      x8
0066B6AD8  str      x0, [sp, #0x20]
0066B6ADC  cbz      x21, #0x66b6d8c
0066B6AE0  mov      x0, x21
0066B6AE4  mov      x1, xzr
0066B6AE8  bl       #0x6688cd8 ; HotFix.BattleLogic.EntityBullet$$GetBulletFlag
0066B6AEC  mov      w23, w0
0066B6AF0  mov      x0, x21
0066B6AF4  mov      x1, xzr
0066B6AF8  bl       #0x6681634 ; HotFix.BattleLogic.EntityBullet$$get_BulletType
0066B6AFC  str      w0, [sp, #0x1c]
0066B6B00  mov      x0, x19
0066B6B04  mov      x1, xzr
0066B6B08  bl       #0x667b13c ; HotFix.BattleLogic.BulletHurtInfo$$TriggerInstanceId
0066B6B0C  str      x0, [sp, #0x28]
0066B6B10  ldrb     w8, [x28, #0xa4b]
0066B6B14  cbnz     w8, #0x66b6b2c
0066B6B18  adrp     x0, #0x8ee5000
0066B6B1C  ldr      x0, [x0, #0xb28]
0066B6B20  bl       #0x382bd14 ; 
0066B6B24  mov      w8, #1
0066B6B28  strb     w8, [x28, #0xa4b]
0066B6B2C  ldr      x1, [x25]
0066B6B30  ldrb     w8, [x1, #0x53]
0066B6B34  tbnz     w8, #5, #0x66b6b40
0066B6B38  ldr      x27, [x20, #0x20]
0066B6B3C  b        #0x66b6b50 ; 
0066B6B40  ldr      x8, [x1, #0x60]
0066B6B44  mov      x0, x20
0066B6B48  blr      x8
0066B6B4C  mov      x27, x0
0066B6B50  cbz      x27, #0x66b6d90
0066B6B54  adrp     x26, #0x9591000
0066B6B58  ldrb     w8, [x26, #0xa62]
0066B6B5C  cbnz     w8, #0x66b6b74
0066B6B60  adrp     x0, #0x8ee6000
0066B6B64  ldr      x0, [x0, #0x1f8]
0066B6B68  bl       #0x382bd14 ; 
0066B6B6C  mov      w8, #1
0066B6B70  strb     w8, [x26, #0xa62]
0066B6B74  adrp     x24, #0x8ee6000
0066B6B78  ldr      x24, [x24, #0x1f8]
0066B6B7C  ldr      x1, [x24]
0066B6B80  ldrb     w8, [x1, #0x53]
0066B6B84  tbnz     w8, #5, #0x66b6b90
0066B6B88  ldr      x0, [x27, #0x1f8]
0066B6B8C  b        #0x66b6b9c ; 
0066B6B90  ldr      x8, [x1, #0x60]
0066B6B94  mov      x0, x27
0066B6B98  blr      x8
0066B6B9C  cbz      x0, #0x66b6d94
0066B6BA0  adrp     x8, #0x8ee6000
0066B6BA4  ldr      x8, [x8, #0x108]
0066B6BA8  ldr      x2, [x8]
0066B6BAC  ldr      x1, [sp, #0x28]
0066B6BB0  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066B6BB4  ldrb     w8, [x28, #0xa4b]
0066B6BB8  mov      x27, x0
0066B6BBC  cbnz     w8, #0x66b6bd4
0066B6BC0  adrp     x0, #0x8ee5000
0066B6BC4  ldr      x0, [x0, #0xb28]
0066B6BC8  bl       #0x382bd14 ; 
0066B6BCC  mov      w8, #1
0066B6BD0  strb     w8, [x28, #0xa4b]
0066B6BD4  ldr      x1, [x25]
0066B6BD8  ldrb     w8, [x1, #0x53]
0066B6BDC  tbnz     w8, #5, #0x66b6be8
0066B6BE0  ldr      x28, [x20, #0x20]
0066B6BE4  b        #0x66b6bf8 ; 
0066B6BE8  ldr      x8, [x1, #0x60]
0066B6BEC  mov      x0, x20
0066B6BF0  blr      x8
0066B6BF4  mov      x28, x0
0066B6BF8  cbz      x28, #0x66b6d98
0066B6BFC  ldrb     w8, [x26, #0xa62]
0066B6C00  cbnz     w8, #0x66b6c18
0066B6C04  adrp     x0, #0x8ee6000
0066B6C08  ldr      x0, [x0, #0x1f8]
0066B6C0C  bl       #0x382bd14 ; 
0066B6C10  mov      w8, #1
0066B6C14  strb     w8, [x26, #0xa62]
0066B6C18  ldr      x1, [x24]
0066B6C1C  ldrb     w8, [x1, #0x53]
0066B6C20  tbnz     w8, #5, #0x66b6c2c
0066B6C24  ldr      x28, [x28, #0x1f8]
0066B6C28  b        #0x66b6c3c ; 
0066B6C2C  ldr      x8, [x1, #0x60]
0066B6C30  mov      x0, x28
0066B6C34  blr      x8
0066B6C38  mov      x28, x0
0066B6C3C  mov      x0, x19
0066B6C40  mov      x1, xzr
0066B6C44  bl       #0x667b324 ; HotFix.BattleLogic.BulletHurtInfo$$OwnerInstanceId
0066B6C48  mov      x1, x0
0066B6C4C  cbz      x28, #0x66b6d9c
0066B6C50  adrp     x8, #0x8ee6000
0066B6C54  ldr      x8, [x8, #0x108]
0066B6C58  ldr      x2, [x8]
0066B6C5C  mov      x0, x28
0066B6C60  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066B6C64  mov      x28, x0
0066B6C68  ldr      x5, [sp, #0x28]
0066B6C6C  mov      x0, x20
0066B6C70  mov      x1, x19
0066B6C74  mov      x2, x21
0066B6C78  mov      x3, x22
0066B6C7C  mov      w4, w23
0066B6C80  mov      x6, x27
0066B6C84  mov      x7, x28
0066B6C88  bl       #0x66b7a34 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleOwnerAndTriggerOnBulletHit
0066B6C8C  ldr      x1, [x29]
0066B6C90  ldrb     w8, [x1, #0x53]
0066B6C94  tbnz     w8, #5, #0x66b6ca0
0066B6C98  ldr      x1, [x20, #0x30]
0066B6C9C  b        #0x66b6cb0 ; 
0066B6CA0  ldr      x8, [x1, #0x60]
0066B6CA4  mov      x0, x20
0066B6CA8  blr      x8
0066B6CAC  mov      x1, x0
0066B6CB0  mov      x0, x19
0066B6CB4  mov      x2, xzr
0066B6CB8  bl       #0x68df108 ; HotFix.BattleLogic.AttackSourceInfo$$FromBulletAttack
0066B6CBC  mov      x29, x0
0066B6CC0  ldr      x3, [sp, #0x20]
0066B6CC4  mov      x0, x20
0066B6CC8  mov      x1, x19
0066B6CCC  mov      w2, w23
0066B6CD0  mov      x4, x29
0066B6CD4  bl       #0x66b7bc4 ; HotFix.BattleLogic.CharacterComponentOnHit$$CreateBulletHurtSourceData
0066B6CD8  mov      x25, x0
0066B6CDC  mov      x0, x20
0066B6CE0  mov      x1, x19
0066B6CE4  mov      x2, x25
0066B6CE8  mov      x3, x29
0066B6CEC  bl       #0x66b7edc ; HotFix.BattleLogic.CharacterComponentOnHit$$BuildBulletHurtDataArray
0066B6CF0  mov      x29, x0
0066B6CF4  ldr      w1, [sp, #0x1c]
0066B6CF8  mov      x0, x20
0066B6CFC  mov      x2, x28
0066B6D00  bl       #0x66b7fb8 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleLaserStacking
0066B6D04  mov      x0, x20
0066B6D08  mov      x1, x27
0066B6D0C  mov      x2, x29
0066B6D10  bl       #0x66b8228 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBeforeHurtTarget
0066B6D14  mov      w1, #0x18
0066B6D18  mov      x0, x20
0066B6D1C  mov      x2, x19
0066B6D20  mov      x3, x21
0066B6D24  mov      w4, w23
0066B6D28  mov      w5, wzr
0066B6D2C  mov      x6, x25
0066B6D30  bl       #0x66b8350 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBulletHitEventToBullet
0066B6D34  ldr      x7, [sp, #0x28]
0066B6D38  mov      x0, x20
0066B6D3C  mov      x1, x19
0066B6D40  mov      x2, x21
0066B6D44  mov      x3, x22
0066B6D48  mov      w4, w23
0066B6D4C  mov      x5, x25
0066B6D50  mov      x6, x29
0066B6D54  stp      x27, x28, [sp]
0066B6D58  bl       #0x66b862c ; HotFix.BattleLogic.CharacterComponentOnHit$$ApplyBulletDamageAndEffects
0066B6D5C  ldp      x20, x19, [sp, #0x80]
0066B6D60  ldp      x22, x21, [sp, #0x70]
0066B6D64  ldp      x24, x23, [sp, #0x60]
0066B6D68  ldp      x26, x25, [sp, #0x50]
0066B6D6C  ldp      x28, x27, [sp, #0x40]
0066B6D70  ldp      x29, x30, [sp, #0x30]
0066B6D74  add      sp, sp, #0x90
0066B6D78  ret      
0066B6D7C  bl       #0x382bfb8 ; 
0066B6D80  bl       #0x382bfb8 ; 
0066B6D84  bl       #0x382bfb8 ; 
0066B6D88  bl       #0x382bfb8 ; 
0066B6D8C  bl       #0x382bfb8 ; 
0066B6D90  bl       #0x382bfb8 ; 
0066B6D94  bl       #0x382bfb8 ; 
0066B6D98  bl       #0x382bfb8 ; 
0066B6D9C  bl       #0x382bfb8 ; 
0066B6DA0  b        #0x66b6e20 ; 
0066B6DA4  b        #0x66b6e20 ; 
0066B6DA8  b        #0x66b6e20 ; 
0066B6DAC  b        #0x66b6e20 ; 
0066B6DB0  b        #0x66b6e20 ; 
0066B6DB4  b        #0x66b6e20 ; 
0066B6DB8  b        #0x66b6e20 ; 
0066B6DBC  b        #0x66b6e20 ; 
0066B6DC0  b        #0x66b6e20 ; 
0066B6DC4  b        #0x66b6e20 ; 
0066B6DC8  b        #0x66b6e20 ; 
0066B6DCC  b        #0x66b6e20 ; 
0066B6DD0  b        #0x66b6e20 ; 
0066B6DD4  b        #0x66b6e20 ; 
0066B6DD8  b        #0x66b6e20 ; 
0066B6DDC  b        #0x66b6e20 ; 
0066B6DE0  b        #0x66b6e20 ; 
0066B6DE4  b        #0x66b6e20 ; 
0066B6DE8  b        #0x66b6e20 ; 
0066B6DEC  b        #0x66b6e20 ; 
0066B6DF0  b        #0x66b6e20 ; 
0066B6DF4  b        #0x66b6e20 ; 
0066B6DF8  b        #0x66b6e20 ; 
0066B6DFC  b        #0x66b6e20 ; 
0066B6E00  b        #0x66b6e20 ; 
0066B6E04  b        #0x66b6e20 ; 
0066B6E08  b        #0x66b6e20 ; 
0066B6E0C  b        #0x66b6e20 ; 
0066B6E10  b        #0x66b6e20 ; 
0066B6E14  b        #0x66b6e20 ; 
0066B6E18  b        #0x66b6e20 ; 
0066B6E1C  b        #0x66b6e20 ; 
0066B6E20  cmp      w1, #1
0066B6E24  b.ne     #0x66b6e44
0066B6E28  bl       #0x89eda50 ; 
0066B6E2C  ldr      x19, [x0]
0066B6E30  bl       #0x89eda60 ; 
0066B6E34  cbz      x19, #0x66b6d5c
0066B6E38  mov      x0, x19
0066B6E3C  bl       #0x382bfb0 ; 
0066B6E40  cbnz     x19, #0x66b6e48
0066B6E44  bl       #0x3b56bfc ; 
0066B6E48  mov      x0, x19
0066B6E4C  bl       #0x382bfb0 ; 
0066B6E50  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$TryInterceptHeroBoundBulletByWingPlaneResist
; RVA 0x66B6E54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B6E54  str      x30, [sp, #-0x30]!
0066B6E58  stp      x22, x21, [sp, #0x10]
0066B6E5C  stp      x20, x19, [sp, #0x20]
0066B6E60  adrp     x21, #0x959a000
0066B6E64  adrp     x22, #0x8f11000
0066B6E68  ldrb     w8, [x21, #0x203]
0066B6E6C  ldr      x22, [x22, #0x918]
0066B6E70  mov      x19, x1
0066B6E74  mov      x20, x0
0066B6E78  tbnz     w8, #0, #0x66b6ecc
0066B6E7C  adrp     x0, #0x8f11000
0066B6E80  ldr      x0, [x0, #0x918]
0066B6E84  bl       #0x382bd14 ; 
0066B6E88  adrp     x0, #0x8eea000
0066B6E8C  ldr      x0, [x0, #0xef8]
0066B6E90  bl       #0x382bd14 ; 
0066B6E94  adrp     x0, #0x8ee6000
0066B6E98  ldr      x0, [x0, #0xd8]
0066B6E9C  bl       #0x382bd14 ; 
0066B6EA0  adrp     x0, #0x8ee6000
0066B6EA4  ldr      x0, [x0, #0xe8]
0066B6EA8  bl       #0x382bd14 ; 
0066B6EAC  adrp     x0, #0x8ee6000
0066B6EB0  ldr      x0, [x0, #0x608]
0066B6EB4  bl       #0x382bd14 ; 
0066B6EB8  adrp     x0, #0x8f06000
0066B6EBC  ldr      x0, [x0, #0x1d0]
0066B6EC0  bl       #0x382bd14 ; 
0066B6EC4  mov      w8, #1
0066B6EC8  strb     w8, [x21, #0x203]
0066B6ECC  ldr      x2, [x22]
0066B6ED0  ldrb     w8, [x2, #0x53]
0066B6ED4  tbnz     w8, #5, #0x66b6ef8
0066B6ED8  adrp     x8, #0x8ee6000
0066B6EDC  ldr      x8, [x8, #0x608]
0066B6EE0  ldr      x1, [x8]
0066B6EE4  ldrb     w8, [x1, #0x53]
0066B6EE8  tbnz     w8, #5, #0x66b6f14
0066B6EEC  ldr      x0, [x20, #0x30]
0066B6EF0  cbnz     x0, #0x66b6f24
0066B6EF4  b        #0x66b6f5c ; 
0066B6EF8  ldr      x3, [x2, #0x60]
0066B6EFC  mov      x0, x20
0066B6F00  mov      x1, x19
0066B6F04  ldp      x20, x19, [sp, #0x20]
0066B6F08  ldp      x22, x21, [sp, #0x10]
0066B6F0C  ldr      x30, [sp], #0x30
0066B6F10  br       x3
0066B6F14  ldr      x8, [x1, #0x60]
0066B6F18  mov      x0, x20
0066B6F1C  blr      x8
0066B6F20  cbz      x0, #0x66b6f5c
0066B6F24  adrp     x8, #0x8f06000
0066B6F28  ldr      x8, [x8, #0x1d0]
0066B6F2C  ldr      x9, [x0]
0066B6F30  ldr      x8, [x8]
0066B6F34  ldrb     w11, [x9, #0x130]
0066B6F38  ldrb     w10, [x8, #0x130]
0066B6F3C  cmp      w11, w10
0066B6F40  b.lo     #0x66b6f5c
0066B6F44  ldr      x9, [x9, #0xc8]
0066B6F48  add      x9, x9, x10, lsl #3
0066B6F4C  ldur     x9, [x9, #-8]
0066B6F50  cmp      x9, x8
0066B6F54  csel     x20, x0, xzr, eq
0066B6F58  b.eq     #0x66b6f74
0066B6F5C  mov      w20, wzr
0066B6F60  mov      w0, w20
0066B6F64  ldp      x20, x19, [sp, #0x20]
0066B6F68  ldp      x22, x21, [sp, #0x10]
0066B6F6C  ldr      x30, [sp], #0x30
0066B6F70  ret      
0066B6F74  cbz      x20, #0x66b7184
0066B6F78  adrp     x21, #0x959a000
0066B6F7C  ldrb     w8, [x21, #0x26b]
0066B6F80  cbnz     w8, #0x66b6f98
0066B6F84  adrp     x0, #0x8f11000
0066B6F88  ldr      x0, [x0, #0x920]
0066B6F8C  bl       #0x382bd14 ; 
0066B6F90  mov      w8, #1
0066B6F94  strb     w8, [x21, #0x26b]
0066B6F98  adrp     x8, #0x8f11000
0066B6F9C  ldr      x8, [x8, #0x920]
0066B6FA0  ldr      x1, [x8]
0066B6FA4  ldrb     w8, [x1, #0x53]
0066B6FA8  tbnz     w8, #5, #0x66b6fb8
0066B6FAC  ldrb     w8, [x20, #0x6fc]
0066B6FB0  cbnz     w8, #0x66b6fc8
0066B6FB4  b        #0x66b6f5c ; 
0066B6FB8  ldr      x8, [x1, #0x60]
0066B6FBC  mov      x0, x20
0066B6FC0  blr      x8
0066B6FC4  tbz      w0, #0, #0x66b6f5c
0066B6FC8  cbz      x19, #0x66b7008
0066B6FCC  adrp     x21, #0x9595000
0066B6FD0  ldrb     w8, [x21, #0x73b]
0066B6FD4  cbnz     w8, #0x66b6fec
0066B6FD8  adrp     x0, #0x8eea000
0066B6FDC  ldr      x0, [x0, #0xf40]
0066B6FE0  bl       #0x382bd14 ; 
0066B6FE4  mov      w8, #1
0066B6FE8  strb     w8, [x21, #0x73b]
0066B6FEC  adrp     x8, #0x8eea000
0066B6FF0  ldr      x8, [x8, #0xf40]
0066B6FF4  ldr      x1, [x8]
0066B6FF8  ldrb     w8, [x1, #0x53]
0066B6FFC  tbnz     w8, #5, #0x66b7010
0066B7000  ldrb     w8, [x19, #0x60]
0066B7004  cbz      w8, #0x66b7020
0066B7008  mov      w20, #1
0066B700C  b        #0x66b6f60 ; 
0066B7010  ldr      x8, [x1, #0x60]
0066B7014  mov      x0, x19
0066B7018  blr      x8
0066B701C  tbnz     w0, #0, #0x66b7008
0066B7020  adrp     x8, #0x8ee6000
0066B7024  ldr      x8, [x8, #0xd8]
0066B7028  ldr      x1, [x8]
0066B702C  ldrb     w8, [x1, #0x53]
0066B7030  tbnz     w8, #5, #0x66b703c
0066B7034  ldr      x21, [x20, #0x38]
0066B7038  b        #0x66b704c ; 
0066B703C  ldr      x8, [x1, #0x60]
0066B7040  mov      x0, x20
0066B7044  blr      x8
0066B7048  mov      x21, x0
0066B704C  cbz      x21, #0x66b7184
0066B7050  adrp     x22, #0x9591000
0066B7054  ldrb     w8, [x22, #0xa92]
0066B7058  cbnz     w8, #0x66b7070
0066B705C  adrp     x0, #0x8ee6000
0066B7060  ldr      x0, [x0, #0x3f0]
0066B7064  bl       #0x382bd14 ; 
0066B7068  mov      w8, #1
0066B706C  strb     w8, [x22, #0xa92]
0066B7070  adrp     x8, #0x8ee6000
0066B7074  ldr      x8, [x8, #0x3f0]
0066B7078  ldr      x1, [x8]
0066B707C  ldrb     w8, [x1, #0x53]
0066B7080  tbnz     w8, #5, #0x66b708c
0066B7084  ldr      w0, [x21, #0x150]
0066B7088  b        #0x66b7098 ; 
0066B708C  ldr      x8, [x1, #0x60]
0066B7090  mov      x0, x21
0066B7094  blr      x8
0066B7098  ldr      w1, [x19, #0x58]
0066B709C  mov      x2, xzr
0066B70A0  bl       #0x691ef3c ; HotFix.BattleLogic.GameUtils$$IsEnemyCamp
0066B70A4  tbz      w0, #0, #0x66b6f5c
0066B70A8  mov      w1, #1
0066B70AC  mov      x0, x19
0066B70B0  mov      x2, xzr
0066B70B4  bl       #0x66895fc ; HotFix.BattleLogic.EntityBullet$$HaveBulletTrait
0066B70B8  tbnz     w0, #0, #0x66b6f5c
0066B70BC  mov      w1, #8
0066B70C0  mov      x0, x19
0066B70C4  mov      x2, xzr
0066B70C8  bl       #0x66895fc ; HotFix.BattleLogic.EntityBullet$$HaveBulletTrait
0066B70CC  tbnz     w0, #0, #0x66b6f5c
0066B70D0  adrp     x8, #0x8ee6000
0066B70D4  ldr      x8, [x8, #0xe8]
0066B70D8  ldr      x1, [x8]
0066B70DC  ldrb     w8, [x1, #0x53]
0066B70E0  tbnz     w8, #5, #0x66b70ec
0066B70E4  ldr      x20, [x20, #0x28]
0066B70E8  b        #0x66b70fc ; 
0066B70EC  ldr      x8, [x1, #0x60]
0066B70F0  mov      x0, x20
0066B70F4  blr      x8
0066B70F8  mov      x20, x0
0066B70FC  adrp     x21, #0x9595000
0066B7100  ldrb     w8, [x21, #0x737]
0066B7104  cbnz     w8, #0x66b711c
0066B7108  adrp     x0, #0x8eea000
0066B710C  ldr      x0, [x0, #0xf48]
0066B7110  bl       #0x382bd14 ; 
0066B7114  mov      w8, #1
0066B7118  strb     w8, [x21, #0x737]
0066B711C  adrp     x8, #0x8eea000
0066B7120  ldr      x8, [x8, #0xf48]
0066B7124  ldr      x2, [x8]
0066B7128  ldrb     w8, [x2, #0x53]
0066B712C  tbnz     w8, #5, #0x66b7138
0066B7130  str      x20, [x19, #0xf8]
0066B7134  b        #0x66b7148 ; 
0066B7138  ldr      x8, [x2, #0x60]
0066B713C  mov      x0, x19
0066B7140  mov      x1, x20
0066B7144  blr      x8
0066B7148  adrp     x8, #0x8eea000
0066B714C  ldr      x8, [x8, #0xef8]
0066B7150  mov      x0, x19
0066B7154  ldr      x1, [x8]
0066B7158  bl       #0x60b2780 ; HotFix.BattleLogic.EntityBase<object>$$DispatchBulletBeKilledHoverEvent
0066B715C  mov      w3, #1
0066B7160  mov      x0, x19
0066B7164  mov      w1, wzr
0066B7168  mov      w2, wzr
0066B716C  mov      x4, xzr
0066B7170  mov      x5, xzr
0066B7174  mov      x6, xzr
0066B7178  mov      w20, #1
0066B717C  bl       #0x66858e0 ; HotFix.BattleLogic.EntityBullet$$OnDie
0066B7180  b        #0x66b6f60 ; 
0066B7184  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBeforeHurtTarget
; RVA 0x66B8228; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B8228  stp      x30, x23, [sp, #-0x30]!
0066B822C  stp      x22, x21, [sp, #0x10]
0066B8230  stp      x20, x19, [sp, #0x20]
0066B8234  adrp     x22, #0x959a000
0066B8238  adrp     x23, #0x8f11000
0066B823C  ldrb     w8, [x22, #0x204]
0066B8240  ldr      x23, [x23, #0x9a8]
0066B8244  mov      x19, x2
0066B8248  mov      x20, x1
0066B824C  mov      x21, x0
0066B8250  tbnz     w8, #0, #0x66b8280
0066B8254  adrp     x0, #0x8f11000
0066B8258  ldr      x0, [x0, #0x9a8]
0066B825C  bl       #0x382bd14 ; 
0066B8260  adrp     x0, #0x8ee6000
0066B8264  ldr      x0, [x0, #0xd8]
0066B8268  bl       #0x382bd14 ; 
0066B826C  adrp     x0, #0x8ee6000
0066B8270  ldr      x0, [x0, #0x608]
0066B8274  bl       #0x382bd14 ; 
0066B8278  mov      w8, #1
0066B827C  strb     w8, [x22, #0x204]
0066B8280  ldr      x3, [x23]
0066B8284  ldrb     w8, [x3, #0x53]
0066B8288  tbnz     w8, #5, #0x66b82bc
0066B828C  cbz      x20, #0x66b8314
0066B8290  mov      x0, x20
0066B8294  mov      x1, xzr
0066B8298  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0066B829C  tbnz     w0, #0, #0x66b8314
0066B82A0  adrp     x8, #0x8ee6000
0066B82A4  ldr      x8, [x8, #0xd8]
0066B82A8  ldr      x1, [x8]
0066B82AC  ldrb     w8, [x1, #0x53]
0066B82B0  tbnz     w8, #5, #0x66b82dc
0066B82B4  ldr      x0, [x20, #0x38]
0066B82B8  b        #0x66b82e8 ; 
0066B82BC  ldr      x4, [x3, #0x60]
0066B82C0  mov      x0, x21
0066B82C4  mov      x1, x20
0066B82C8  mov      x2, x19
0066B82CC  ldp      x20, x19, [sp, #0x20]
0066B82D0  ldp      x22, x21, [sp, #0x10]
0066B82D4  ldp      x30, x23, [sp], #0x30
0066B82D8  br       x4
0066B82DC  ldr      x8, [x1, #0x60]
0066B82E0  mov      x0, x20
0066B82E4  blr      x8
0066B82E8  cbz      x0, #0x66b834c
0066B82EC  mov      x1, xzr
0066B82F0  bl       #0x45616a8 ; 
0066B82F4  tbz      w0, #0, #0x66b8314
0066B82F8  adrp     x8, #0x8ee6000
0066B82FC  ldr      x8, [x8, #0x608]
0066B8300  ldr      x1, [x8]
0066B8304  ldrb     w8, [x1, #0x53]
0066B8308  tbnz     w8, #5, #0x66b8324
0066B830C  ldr      x2, [x21, #0x30]
0066B8310  b        #0x66b8334 ; 
0066B8314  ldp      x20, x19, [sp, #0x20]
0066B8318  ldp      x22, x21, [sp, #0x10]
0066B831C  ldp      x30, x23, [sp], #0x30
0066B8320  ret      
0066B8324  ldr      x8, [x1, #0x60]
0066B8328  mov      x0, x21
0066B832C  blr      x8
0066B8330  mov      x2, x0
0066B8334  ldr      x8, [x20]
0066B8338  mov      x0, x20
0066B833C  mov      x1, x19
0066B8340  ldr      x4, [x8, #0x378]
0066B8344  ldr      x3, [x8, #0x380]
0066B8348  b        #0x66b82cc ; 
0066B834C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CreateBulletHurtSourceData
; RVA 0x66B7BC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B7BC4  stp      x30, x25, [sp, #-0x40]!
0066B7BC8  stp      x24, x23, [sp, #0x10]
0066B7BCC  stp      x22, x21, [sp, #0x20]
0066B7BD0  stp      x20, x19, [sp, #0x30]
0066B7BD4  adrp     x24, #0x959a000
0066B7BD8  adrp     x25, #0x8f11000
0066B7BDC  ldrb     w8, [x24, #0x205]
0066B7BE0  ldr      x25, [x25, #0x950]
0066B7BE4  mov      x20, x4
0066B7BE8  mov      x21, x3
0066B7BEC  mov      w19, w2
0066B7BF0  mov      x22, x1
0066B7BF4  mov      x23, x0
0066B7BF8  tbnz     w8, #0, #0x66b7c64
0066B7BFC  adrp     x0, #0x8f11000
0066B7C00  ldr      x0, [x0, #0x950]
0066B7C04  bl       #0x382bd14 ; 
0066B7C08  adrp     x0, #0x8eea000
0066B7C0C  ldr      x0, [x0, #0xf00]
0066B7C10  bl       #0x382bd14 ; 
0066B7C14  adrp     x0, #0x8ee6000
0066B7C18  ldr      x0, [x0, #0x608]
0066B7C1C  bl       #0x382bd14 ; 
0066B7C20  adrp     x0, #0x8ee1000
0066B7C24  ldr      x0, [x0, #0x6e8]
0066B7C28  bl       #0x382bd14 ; 
0066B7C2C  adrp     x0, #0x8f11000
0066B7C30  ldr      x0, [x0, #0x958]
0066B7C34  bl       #0x382bd14 ; 
0066B7C38  adrp     x0, #0x8f11000
0066B7C3C  ldr      x0, [x0, #0x960]
0066B7C40  bl       #0x382bd14 ; 
0066B7C44  adrp     x0, #0x8f11000
0066B7C48  ldr      x0, [x0, #0x968]
0066B7C4C  bl       #0x382bd14 ; 
0066B7C50  adrp     x0, #0x8f11000
0066B7C54  ldr      x0, [x0, #0x970]
0066B7C58  bl       #0x382bd14 ; 
0066B7C5C  mov      w8, #1
0066B7C60  strb     w8, [x24, #0x205]
0066B7C64  ldr      x5, [x25]
0066B7C68  ldrb     w8, [x5, #0x53]
0066B7C6C  tbnz     w8, #5, #0x66b7ca0
0066B7C70  mov      x0, x23
0066B7C74  mov      x1, x20
0066B7C78  bl       #0x66b8ab0 ; HotFix.BattleLogic.CharacterComponentOnHit$$CreateHurtSourceDataFromAttackInfo
0066B7C7C  mov      x21, x0
0066B7C80  cbz      x0, #0x66b7ccc
0066B7C84  adrp     x8, #0x8ee6000
0066B7C88  ldr      x8, [x8, #0x608]
0066B7C8C  ldr      x1, [x8]
0066B7C90  ldrb     w8, [x1, #0x53]
0066B7C94  tbnz     w8, #5, #0x66b7d1c
0066B7C98  ldr      x0, [x23, #0x30]
0066B7C9C  b        #0x66b7d28 ; 
0066B7CA0  ldr      x6, [x5, #0x60]
0066B7CA4  mov      x0, x23
0066B7CA8  mov      x1, x22
0066B7CAC  mov      w2, w19
0066B7CB0  mov      x3, x21
0066B7CB4  mov      x4, x20
0066B7CB8  ldp      x20, x19, [sp, #0x30]
0066B7CBC  ldp      x22, x21, [sp, #0x20]
0066B7CC0  ldp      x24, x23, [sp, #0x10]
0066B7CC4  ldp      x30, x25, [sp], #0x40
0066B7CC8  br       x6
0066B7CCC  adrp     x8, #0x8ee1000
0066B7CD0  ldr      x8, [x8, #0x6e8]
0066B7CD4  ldr      x0, [x8]
0066B7CD8  ldr      w8, [x0, #0xe0]
0066B7CDC  cbnz     w8, #0x66b7ce4
0066B7CE0  bl       #0x382be8c ; 
0066B7CE4  adrp     x8, #0x8f11000
0066B7CE8  adrp     x9, #0x8f11000
0066B7CEC  ldr      x8, [x8, #0x960]
0066B7CF0  ldr      x9, [x9, #0x968]
0066B7CF4  adrp     x10, #0x8f11000
0066B7CF8  ldr      x10, [x10, #0x970]
0066B7CFC  ldr      x0, [x8]
0066B7D00  ldr      x1, [x9]
0066B7D04  ldr      x2, [x10]
0066B7D08  mov      w3, #0xa7
0066B7D0C  mov      x4, xzr
0066B7D10  bl       #0x7997754 ; Logger$$LogError
0066B7D14  mov      x21, xzr
0066B7D18  b        #0x66b7e40 ; 
0066B7D1C  ldr      x8, [x1, #0x60]
0066B7D20  mov      x0, x23
0066B7D24  blr      x8
0066B7D28  cbz      x0, #0x66b7e58
0066B7D2C  adrp     x8, #0x8eea000
0066B7D30  ldr      x8, [x8, #0xf00]
0066B7D34  ldr      x1, [x8]
0066B7D38  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0066B7D3C  cbz      x0, #0x66b7e5c
0066B7D40  mov      w1, #2
0066B7D44  mov      x2, xzr
0066B7D48  bl       #0x6694280 ; HotFix.BattleLogic.CharacterComponentBuff$$CheckBuffFLag
0066B7D4C  tbz      w0, #0, #0x66b7d60
0066B7D50  mov      w1, #1
0066B7D54  mov      x0, x21
0066B7D58  mov      x2, xzr
0066B7D5C  bl       #0x6901138 ; HotFix.BattleLogic.HurtSourceData$$MarkGameConditionOccurred
0066B7D60  cbz      x22, #0x66b7e60
0066B7D64  adrp     x23, #0x959a000
0066B7D68  ldrb     w8, [x23, #0x26c]
0066B7D6C  ldr      w22, [x22, #0x78]
0066B7D70  cbnz     w8, #0x66b7d88
0066B7D74  adrp     x0, #0x8f11000
0066B7D78  ldr      x0, [x0, #0x978]
0066B7D7C  bl       #0x382bd14 ; 
0066B7D80  mov      w8, #1
0066B7D84  strb     w8, [x23, #0x26c]
0066B7D88  adrp     x8, #0x8f11000
0066B7D8C  ldr      x8, [x8, #0x978]
0066B7D90  ldr      x2, [x8]
0066B7D94  ldrb     w8, [x2, #0x53]
0066B7D98  tbnz     w8, #5, #0x66b7da4
0066B7D9C  str      w22, [x21, #0x130]
0066B7DA0  b        #0x66b7db4 ; 
0066B7DA4  ldr      x8, [x2, #0x60]
0066B7DA8  mov      x0, x21
0066B7DAC  mov      w1, w22
0066B7DB0  blr      x8
0066B7DB4  tbz      w19, #0xc, #0x66b7e2c
0066B7DB8  cbz      x20, #0x66b7e64
0066B7DBC  adrp     x22, #0x959a000
0066B7DC0  ldrb     w8, [x22, #0x26d]
0066B7DC4  cbnz     w8, #0x66b7ddc
0066B7DC8  adrp     x0, #0x8f11000
0066B7DCC  ldr      x0, [x0, #0x980]
0066B7DD0  bl       #0x382bd14 ; 
0066B7DD4  mov      w8, #1
0066B7DD8  strb     w8, [x22, #0x26d]
0066B7DDC  adrp     x8, #0x8f11000
0066B7DE0  ldr      x8, [x8, #0x980]
0066B7DE4  ldr      x1, [x8]
0066B7DE8  ldrb     w8, [x1, #0x53]
0066B7DEC  tbnz     w8, #5, #0x66b7df8
0066B7DF0  ldr      x0, [x20, #0x20]
0066B7DF4  b        #0x66b7e04 ; 
0066B7DF8  ldr      x8, [x1, #0x60]
0066B7DFC  mov      x0, x20
0066B7E00  blr      x8
0066B7E04  cbz      x0, #0x66b7e68
0066B7E08  adrp     x8, #0x8f11000
0066B7E0C  ldr      x8, [x8, #0x958]
0066B7E10  ldr      x1, [x8]
0066B7E14  mov      x2, xzr
0066B7E18  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
0066B7E1C  mov      x1, x0
0066B7E20  mov      x0, x21
0066B7E24  mov      x2, xzr
0066B7E28  bl       #0x68f0608 ; HotFix.BattleLogic.HurtSourceData$$ResetCri
0066B7E2C  tbz      w19, #0x13, #0x66b7e40
0066B7E30  mov      x0, x21
0066B7E34  mov      x1, xzr
0066B7E38  mov      x2, xzr
0066B7E3C  bl       #0x68f0608 ; HotFix.BattleLogic.HurtSourceData$$ResetCri
0066B7E40  mov      x0, x21
0066B7E44  ldp      x20, x19, [sp, #0x30]
0066B7E48  ldp      x22, x21, [sp, #0x20]
0066B7E4C  ldp      x24, x23, [sp, #0x10]
0066B7E50  ldp      x30, x25, [sp], #0x40
0066B7E54  ret      
0066B7E58  bl       #0x382bfb8 ; 
0066B7E5C  bl       #0x382bfb8 ; 
0066B7E60  bl       #0x382bfb8 ; 
0066B7E64  bl       #0x382bfb8 ; 
0066B7E68  bl       #0x382bfb8 ; 
0066B7E6C  b        #0x66b7ea0 ; 
0066B7E70  b        #0x66b7ea0 ; 
0066B7E74  b        #0x66b7ea0 ; 
0066B7E78  b        #0x66b7ea0 ; 
0066B7E7C  b        #0x66b7ea0 ; 
0066B7E80  b        #0x66b7ea0 ; 
0066B7E84  b        #0x66b7ea0 ; 
0066B7E88  b        #0x66b7ea0 ; 
0066B7E8C  b        #0x66b7ea0 ; 
0066B7E90  b        #0x66b7ea0 ; 
0066B7E94  b        #0x66b7ea0 ; 
0066B7E98  b        #0x66b7ea0 ; 
0066B7E9C  b        #0x66b7ea0 ; 
0066B7EA0  cmp      w1, #1
0066B7EA4  b.ne     #0x66b7ecc
0066B7EA8  bl       #0x89eda50 ; 
0066B7EAC  ldr      x19, [x0]
0066B7EB0  bl       #0x89eda60 ; 
0066B7EB4  cbnz     x19, #0x66b7ec0
0066B7EB8  mov      x21, xzr
0066B7EBC  b        #0x66b7e40 ; 
0066B7EC0  mov      x0, x19
0066B7EC4  bl       #0x382bfb0 ; 
0066B7EC8  cbnz     x19, #0x66b7ed0
0066B7ECC  bl       #0x3b56bfc ; 
0066B7ED0  mov      x0, x19
0066B7ED4  bl       #0x382bfb0 ; 
0066B7ED8  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$BuildBulletHurtDataArray
; RVA 0x66B7EDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B7EDC  str      x30, [sp, #-0x40]!
0066B7EE0  stp      x24, x23, [sp, #0x10]
0066B7EE4  stp      x22, x21, [sp, #0x20]
0066B7EE8  stp      x20, x19, [sp, #0x30]
0066B7EEC  adrp     x23, #0x959a000
0066B7EF0  adrp     x24, #0x8f11000
0066B7EF4  ldrb     w8, [x23, #0x206]
0066B7EF8  ldr      x24, [x24, #0x988]
0066B7EFC  mov      x19, x3
0066B7F00  mov      x20, x2
0066B7F04  mov      x22, x1
0066B7F08  mov      x21, x0
0066B7F0C  tbnz     w8, #0, #0x66b7f24
0066B7F10  adrp     x0, #0x8f11000
0066B7F14  ldr      x0, [x0, #0x988]
0066B7F18  bl       #0x382bd14 ; 
0066B7F1C  mov      w8, #1
0066B7F20  strb     w8, [x23, #0x206]
0066B7F24  ldr      x4, [x24]
0066B7F28  ldrb     w8, [x4, #0x53]
0066B7F2C  tbnz     w8, #5, #0x66b7f54
0066B7F30  mov      x0, x21
0066B7F34  mov      x1, x20
0066B7F38  mov      x2, x19
0066B7F3C  bl       #0x66b8c7c ; HotFix.BattleLogic.CharacterComponentOnHit$$BuildHurtDataArray
0066B7F40  ldp      x20, x19, [sp, #0x30]
0066B7F44  ldp      x22, x21, [sp, #0x20]
0066B7F48  ldp      x24, x23, [sp, #0x10]
0066B7F4C  ldr      x30, [sp], #0x40
0066B7F50  ret      
0066B7F54  ldr      x5, [x4, #0x60]
0066B7F58  mov      x0, x21
0066B7F5C  mov      x1, x22
0066B7F60  mov      x2, x20
0066B7F64  mov      x3, x19
0066B7F68  ldp      x20, x19, [sp, #0x30]
0066B7F6C  ldp      x22, x21, [sp, #0x20]
0066B7F70  ldp      x24, x23, [sp, #0x10]
0066B7F74  ldr      x30, [sp], #0x40
0066B7F78  br       x5
0066B7F7C  cmp      w1, #1
0066B7F80  b.ne     #0x66b7fa8
0066B7F84  bl       #0x89eda50 ; 
0066B7F88  ldr      x19, [x0]
0066B7F8C  bl       #0x89eda60 ; 
0066B7F90  cbnz     x19, #0x66b7f9c
0066B7F94  mov      x0, xzr
0066B7F98  b        #0x66b7f40 ; 
0066B7F9C  mov      x0, x19
0066B7FA0  bl       #0x382bfb0 ; 
0066B7FA4  cbnz     x19, #0x66b7fac
0066B7FA8  bl       #0x3b56bfc ; 
0066B7FAC  mov      x0, x19
0066B7FB0  bl       #0x382bfb0 ; 
0066B7FB4  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CalcBulletGrowthHurt
; RVA 0x66B8EAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B8EAC  sub      sp, sp, #0xa0
0066B8EB0  stp      x29, x30, [sp, #0x40]
0066B8EB4  stp      x28, x27, [sp, #0x50]
0066B8EB8  stp      x26, x25, [sp, #0x60]
0066B8EBC  stp      x24, x23, [sp, #0x70]
0066B8EC0  stp      x22, x21, [sp, #0x80]
0066B8EC4  stp      x20, x19, [sp, #0x90]
0066B8EC8  adrp     x20, #0x959a000
0066B8ECC  adrp     x23, #0x8f11000
0066B8ED0  ldrb     w8, [x20, #0x207]
0066B8ED4  ldr      x23, [x23, #0xa00]
0066B8ED8  mov      w21, w2
0066B8EDC  mov      x22, x1
0066B8EE0  mov      x19, x0
0066B8EE4  tbnz     w8, #0, #0x66b8f68
0066B8EE8  adrp     x0, #0x8f11000
0066B8EEC  ldr      x0, [x0, #0xa00]
0066B8EF0  bl       #0x382bd14 ; 
0066B8EF4  adrp     x0, #0x8f07000
0066B8EF8  ldr      x0, [x0, #0xe68]
0066B8EFC  bl       #0x382bd14 ; 
0066B8F00  adrp     x0, #0x8ee6000
0066B8F04  ldr      x0, [x0, #0x100]
0066B8F08  bl       #0x382bd14 ; 
0066B8F0C  adrp     x0, #0x8ee6000
0066B8F10  ldr      x0, [x0, #0x108]
0066B8F14  bl       #0x382bd14 ; 
0066B8F18  adrp     x0, #0x8ee5000
0066B8F1C  ldr      x0, [x0, #0x768]
0066B8F20  bl       #0x382bd14 ; 
0066B8F24  adrp     x0, #0x8ee5000
0066B8F28  ldr      x0, [x0, #0x770]
0066B8F2C  bl       #0x382bd14 ; 
0066B8F30  adrp     x0, #0x8ee5000
0066B8F34  ldr      x0, [x0, #0x788]
0066B8F38  bl       #0x382bd14 ; 
0066B8F3C  adrp     x0, #0x8f11000
0066B8F40  ldr      x0, [x0, #0xa08]
0066B8F44  bl       #0x382bd14 ; 
0066B8F48  adrp     x0, #0x8f11000
0066B8F4C  ldr      x0, [x0, #0xa10]
0066B8F50  bl       #0x382bd14 ; 
0066B8F54  adrp     x0, #0x8ee5000
0066B8F58  ldr      x0, [x0, #0x7a0]
0066B8F5C  bl       #0x382bd14 ; 
0066B8F60  mov      w8, #1
0066B8F64  strb     w8, [x20, #0x207]
0066B8F68  ldr      x3, [x23]
0066B8F6C  ldrb     w8, [x3, #0x53]
0066B8F70  tbnz     w8, #5, #0x66b8fb8
0066B8F74  adrp     x27, #0x9591000
0066B8F78  ldrb     w8, [x27, #0xa4b]
0066B8F7C  stp      xzr, xzr, [sp, #0x20]
0066B8F80  str      xzr, [sp, #0x30]
0066B8F84  cbnz     w8, #0x66b8f9c
0066B8F88  adrp     x0, #0x8ee5000
0066B8F8C  ldr      x0, [x0, #0xb28]
0066B8F90  bl       #0x382bd14 ; 
0066B8F94  mov      w8, #1
0066B8F98  strb     w8, [x27, #0xa4b]
0066B8F9C  adrp     x20, #0x8ee5000
0066B8FA0  ldr      x20, [x20, #0xb28]
0066B8FA4  ldr      x1, [x20]
0066B8FA8  ldrb     w8, [x1, #0x53]
0066B8FAC  tbnz     w8, #5, #0x66b8fe8
0066B8FB0  ldr      x23, [x19, #0x20]
0066B8FB4  b        #0x66b8ff8 ; 
0066B8FB8  ldr      x4, [x3, #0x60]
0066B8FBC  mov      x0, x19
0066B8FC0  mov      x1, x22
0066B8FC4  mov      w2, w21
0066B8FC8  ldp      x20, x19, [sp, #0x90]
0066B8FCC  ldp      x22, x21, [sp, #0x80]
0066B8FD0  ldp      x24, x23, [sp, #0x70]
0066B8FD4  ldp      x26, x25, [sp, #0x60]
0066B8FD8  ldp      x28, x27, [sp, #0x50]
0066B8FDC  ldp      x29, x30, [sp, #0x40]
0066B8FE0  add      sp, sp, #0xa0
0066B8FE4  br       x4
0066B8FE8  ldr      x8, [x1, #0x60]
0066B8FEC  mov      x0, x19
0066B8FF0  blr      x8
0066B8FF4  mov      x23, x0
0066B8FF8  cbz      x23, #0x66b96a4
0066B8FFC  adrp     x24, #0x9591000
0066B9000  ldrb     w8, [x24, #0xa62]
0066B9004  cbnz     w8, #0x66b901c
0066B9008  adrp     x0, #0x8ee6000
0066B900C  ldr      x0, [x0, #0x1f8]
0066B9010  bl       #0x382bd14 ; 
0066B9014  mov      w8, #1
0066B9018  strb     w8, [x24, #0xa62]
0066B901C  adrp     x8, #0x8ee6000
0066B9020  ldr      x8, [x8, #0x1f8]
0066B9024  ldr      x1, [x8]
0066B9028  ldrb     w8, [x1, #0x53]
0066B902C  tbnz     w8, #5, #0x66b9038
0066B9030  ldr      x0, [x23, #0x1f8]
0066B9034  b        #0x66b9044 ; 
0066B9038  ldr      x8, [x1, #0x60]
0066B903C  mov      x0, x23
0066B9040  blr      x8
0066B9044  cbz      x0, #0x66b96a4
0066B9048  adrp     x8, #0x8ee6000
0066B904C  ldr      x8, [x8, #0x108]
0066B9050  mov      x1, x22
0066B9054  ldr      x2, [x8]
0066B9058  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066B905C  mov      x22, x0
0066B9060  cbz      x0, #0x66b90d0
0066B9064  adrp     x8, #0x8ee6000
0066B9068  ldr      x8, [x8, #0x100]
0066B906C  ldr      x9, [x22]
0066B9070  ldr      x8, [x8]
0066B9074  ldrb     w11, [x9, #0x130]
0066B9078  ldrb     w10, [x8, #0x130]
0066B907C  cmp      w11, w10
0066B9080  b.lo     #0x66b90d4
0066B9084  ldr      x9, [x9, #0xc8]
0066B9088  add      x9, x9, x10, lsl #3
0066B908C  ldur     x9, [x9, #-8]
0066B9090  cmp      x9, x8
0066B9094  b.ne     #0x66b90d4
0066B9098  adrp     x23, #0x9591000
0066B909C  ldrb     w8, [x23, #0xa7e]
0066B90A0  cbnz     w8, #0x66b90b8
0066B90A4  adrp     x0, #0x8ee6000
0066B90A8  ldr      x0, [x0, #0x2d0]
0066B90AC  bl       #0x382bd14 ; 
0066B90B0  mov      w8, #1
0066B90B4  strb     w8, [x23, #0xa7e]
0066B90B8  adrp     x8, #0x8ee6000
0066B90BC  ldr      x8, [x8, #0x2d0]
0066B90C0  ldr      x1, [x8]
0066B90C4  ldrb     w8, [x1, #0x53]
0066B90C8  tbnz     w8, #5, #0x66b9578
0066B90CC  ldr      x22, [x22, #0x628]
0066B90D0  cbz      x22, #0x66b9678
0066B90D4  adrp     x8, #0x8f07000
0066B90D8  ldr      x8, [x8, #0xe68]
0066B90DC  mov      x0, x22
0066B90E0  ldr      x1, [x8]
0066B90E4  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0066B90E8  cbz      x0, #0x66b9678
0066B90EC  adrp     x23, #0x9599000
0066B90F0  ldrb     w8, [x23, #0x4c7]
0066B90F4  mov      x22, x0
0066B90F8  cbnz     w8, #0x66b9110
0066B90FC  adrp     x0, #0x8f09000
0066B9100  ldr      x0, [x0, #0xc8]
0066B9104  bl       #0x382bd14 ; 
0066B9108  mov      w8, #1
0066B910C  strb     w8, [x23, #0x4c7]
0066B9110  adrp     x8, #0x8f09000
0066B9114  ldr      x8, [x8, #0xc8]
0066B9118  ldr      x1, [x8]
0066B911C  ldrb     w8, [x1, #0x53]
0066B9120  tbnz     w8, #5, #0x66b912c
0066B9124  ldr      x0, [x22, #0x58]
0066B9128  b        #0x66b9138 ; 
0066B912C  ldr      x8, [x1, #0x60]
0066B9130  mov      x0, x22
0066B9134  blr      x8
0066B9138  cbz      x0, #0x66b96a4
0066B913C  adrp     x8, #0x8ee5000
0066B9140  ldr      x8, [x8, #0x7a0]
0066B9144  ldr      x1, [x8]
0066B9148  add      x8, sp, #8
0066B914C  bl       #0x4d65168 ; System.Collections.Generic.List<int>$$GetEnumerator
0066B9150  ldur     q0, [sp, #8]
0066B9154  ldr      x8, [sp, #0x18]
0066B9158  adrp     x29, #0x8ee5000
0066B915C  adrp     x22, #0x8f06000
0066B9160  ldr      x29, [x29, #0x770]
0066B9164  ldr      x22, [x22, #0x470]
0066B9168  mov      w23, wzr
0066B916C  mov      w24, #1
0066B9170  adrp     x28, #0x9598000
0066B9174  str      q0, [sp, #0x20]
0066B9178  str      x8, [sp, #0x30]
0066B917C  ldr      x1, [x29]
0066B9180  add      x0, sp, #0x20
0066B9184  bl       #0x60e2380 ; System.Collections.Generic.List.Enumerator<int>$$MoveNext
0066B9188  tbz      w0, #0, #0x66b9268
0066B918C  ldrb     w8, [x27, #0xa4b]
0066B9190  ldr      w25, [sp, #0x30]
0066B9194  cbnz     w8, #0x66b91a4
0066B9198  mov      x0, x20
0066B919C  bl       #0x382bd14 ; 
0066B91A0  strb     w24, [x27, #0xa4b]
0066B91A4  ldr      x1, [x20]
0066B91A8  ldrb     w8, [x1, #0x53]
0066B91AC  tbnz     w8, #5, #0x66b91b8
0066B91B0  ldr      x26, [x19, #0x20]
0066B91B4  b        #0x66b91c8 ; 
0066B91B8  ldr      x8, [x1, #0x60]
0066B91BC  mov      x0, x19
0066B91C0  blr      x8
0066B91C4  mov      x26, x0
0066B91C8  cbz      x26, #0x66b969c
0066B91CC  ldrb     w8, [x28, #0xfcc]
0066B91D0  cbnz     w8, #0x66b91e0
0066B91D4  mov      x0, x22
0066B91D8  bl       #0x382bd14 ; 
0066B91DC  strb     w24, [x28, #0xfcc]
0066B91E0  ldr      x1, [x22]
0066B91E4  ldrb     w8, [x1, #0x53]
0066B91E8  tbnz     w8, #5, #0x66b91f4
0066B91EC  ldr      x0, [x26, #0x200]
0066B91F0  b        #0x66b9200 ; 
0066B91F4  ldr      x8, [x1, #0x60]
0066B91F8  mov      x0, x26
0066B91FC  blr      x8
0066B9200  cbz      x0, #0x66b96a0
0066B9204  mov      w1, w25
0066B9208  mov      x2, xzr
0066B920C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0066B9210  mov      x25, x0
0066B9214  cbz      x0, #0x66b917c
0066B9218  adrp     x8, #0x9599000
0066B921C  ldrb     w8, [x8, #0xac8]
0066B9220  cbnz     w8, #0x66b9238
0066B9224  adrp     x0, #0x8f0d000
0066B9228  ldr      x0, [x0, #0x78]
0066B922C  bl       #0x382bd14 ; 
0066B9230  adrp     x8, #0x9599000
0066B9234  strb     w24, [x8, #0xac8]
0066B9238  adrp     x8, #0x8f0d000
0066B923C  ldr      x8, [x8, #0x78]
0066B9240  ldr      x1, [x8]
0066B9244  ldrb     w8, [x1, #0x53]
0066B9248  tbnz     w8, #5, #0x66b9254
0066B924C  ldr      w0, [x25, #0x58]
0066B9250  b        #0x66b9260 ; 
0066B9254  ldr      x8, [x1, #0x60]
0066B9258  mov      x0, x25
0066B925C  blr      x8
0066B9260  add      w23, w0, w23
0066B9264  b        #0x66b917c ; 
0066B9268  adrp     x8, #0x8ee5000
0066B926C  ldr      x8, [x8, #0x768]
0066B9270  add      x0, sp, #0x20
0066B9274  ldr      x1, [x8]
0066B9278  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
0066B927C  ldrb     w8, [x27, #0xa4b]
0066B9280  cbnz     w8, #0x66b9298
0066B9284  adrp     x0, #0x8ee5000
0066B9288  ldr      x0, [x0, #0xb28]
0066B928C  bl       #0x382bd14 ; 
0066B9290  mov      w8, #1
0066B9294  strb     w8, [x27, #0xa4b]
0066B9298  ldr      x1, [x20]
0066B929C  ldrb     w8, [x1, #0x53]
0066B92A0  tbnz     w8, #5, #0x66b92ac
0066B92A4  ldr      x24, [x19, #0x20]
0066B92A8  b        #0x66b92bc ; 
0066B92AC  ldr      x8, [x1, #0x60]
0066B92B0  mov      x0, x19
0066B92B4  blr      x8
0066B92B8  mov      x24, x0
0066B92BC  cbz      x24, #0x66b96a4
0066B92C0  ldrb     w8, [x28, #0xfcc]
0066B92C4  cbnz     w8, #0x66b92dc
0066B92C8  adrp     x0, #0x8f06000
0066B92CC  ldr      x0, [x0, #0x470]
0066B92D0  bl       #0x382bd14 ; 
0066B92D4  mov      w8, #1
0066B92D8  strb     w8, [x28, #0xfcc]
0066B92DC  ldr      x1, [x22]
0066B92E0  ldrb     w8, [x1, #0x53]
0066B92E4  tbnz     w8, #5, #0x66b92f0
0066B92E8  ldr      x0, [x24, #0x200]
0066B92EC  b        #0x66b92fc ; 
0066B92F0  ldr      x8, [x1, #0x60]
0066B92F4  mov      x0, x24
0066B92F8  blr      x8
0066B92FC  cbz      x0, #0x66b96a4
0066B9300  mov      w1, w21
0066B9304  mov      x2, xzr
0066B9308  bl       #0x64e5904 ; LocalModels.LocalModelManager$$GetBullet_Bullet
0066B930C  cbz      x0, #0x66b96a4
0066B9310  adrp     x24, #0x959a000
0066B9314  ldrb     w8, [x24, #0x26e]
0066B9318  mov      x21, x0
0066B931C  cbnz     w8, #0x66b9334
0066B9320  adrp     x0, #0x8f11000
0066B9324  ldr      x0, [x0, #0xa18]
0066B9328  bl       #0x382bd14 ; 
0066B932C  mov      w8, #1
0066B9330  strb     w8, [x24, #0x26e]
0066B9334  adrp     x8, #0x8f11000
0066B9338  ldr      x8, [x8, #0xa18]
0066B933C  ldr      x1, [x8]
0066B9340  ldrb     w8, [x1, #0x53]
0066B9344  tbnz     w8, #5, #0x66b9354
0066B9348  ldr      w21, [x21, #0x178]
0066B934C  cbnz     w21, #0x66b9368
0066B9350  b        #0x66b9678 ; 
0066B9354  ldr      x8, [x1, #0x60]
0066B9358  mov      x0, x21
0066B935C  blr      x8
0066B9360  mov      w21, w0
0066B9364  cbz      w21, #0x66b9678
0066B9368  ldrb     w8, [x27, #0xa4b]
0066B936C  cbnz     w8, #0x66b9384
0066B9370  adrp     x0, #0x8ee5000
0066B9374  ldr      x0, [x0, #0xb28]
0066B9378  bl       #0x382bd14 ; 
0066B937C  mov      w8, #1
0066B9380  strb     w8, [x27, #0xa4b]
0066B9384  ldr      x1, [x20]
0066B9388  ldrb     w8, [x1, #0x53]
0066B938C  tbnz     w8, #5, #0x66b9398
0066B9390  ldr      x24, [x19, #0x20]
0066B9394  b        #0x66b93a8 ; 
0066B9398  ldr      x8, [x1, #0x60]
0066B939C  mov      x0, x19
0066B93A0  blr      x8
0066B93A4  mov      x24, x0
0066B93A8  cbz      x24, #0x66b96a4
0066B93AC  ldrb     w8, [x28, #0xfcc]
0066B93B0  cbnz     w8, #0x66b93c8
0066B93B4  adrp     x0, #0x8f06000
0066B93B8  ldr      x0, [x0, #0x470]
0066B93BC  bl       #0x382bd14 ; 
0066B93C0  mov      w8, #1
0066B93C4  strb     w8, [x28, #0xfcc]
0066B93C8  ldr      x1, [x22]
0066B93CC  ldrb     w8, [x1, #0x53]
0066B93D0  tbnz     w8, #5, #0x66b93dc
0066B93D4  ldr      x0, [x24, #0x200]
0066B93D8  b        #0x66b93e8 ; 
0066B93DC  ldr      x8, [x1, #0x60]
0066B93E0  mov      x0, x24
0066B93E4  blr      x8
0066B93E8  cbz      x0, #0x66b96a4
0066B93EC  mov      w1, w23
0066B93F0  mov      x2, xzr
0066B93F4  bl       #0x64d2df4 ; LocalModels.LocalModelManager$$GetBullet_OutsideBulletHurtGrowth
0066B93F8  mov      x23, x0
0066B93FC  cbz      x0, #0x66b944c
0066B9400  cmp      w21, #2
0066B9404  b.eq     #0x66b947c
0066B9408  cmp      w21, #1
0066B940C  b.ne     #0x66b9678
0066B9410  adrp     x19, #0x959a000
0066B9414  ldrb     w8, [x19, #0x26f]
0066B9418  cbnz     w8, #0x66b9430
0066B941C  adrp     x0, #0x8f11000
0066B9420  ldr      x0, [x0, #0xa20]
0066B9424  bl       #0x382bd14 ; 
0066B9428  mov      w8, #1
0066B942C  strb     w8, [x19, #0x26f]
0066B9430  adrp     x8, #0x8f11000
0066B9434  ldr      x8, [x8, #0xa20]
0066B9438  ldr      x1, [x8]
0066B943C  ldrb     w8, [x1, #0x53]
0066B9440  tbnz     w8, #5, #0x66b94b8
0066B9444  ldr      x0, [x23, #0x28]
0066B9448  b        #0x66b94c4 ; 
0066B944C  ldrb     w8, [x27, #0xa4b]
0066B9450  cbnz     w8, #0x66b9468
0066B9454  adrp     x0, #0x8ee5000
0066B9458  ldr      x0, [x0, #0xb28]
0066B945C  bl       #0x382bd14 ; 
0066B9460  mov      w8, #1
0066B9464  strb     w8, [x27, #0xa4b]
0066B9468  ldr      x1, [x20]
0066B946C  ldrb     w8, [x1, #0x53]
0066B9470  tbnz     w8, #5, #0x66b94cc
0066B9474  ldr      x19, [x19, #0x20]
0066B9478  b        #0x66b94dc ; 
0066B947C  adrp     x19, #0x959a000
0066B9480  ldrb     w8, [x19, #0x270]
0066B9484  cbnz     w8, #0x66b949c
0066B9488  adrp     x0, #0x8f11000
0066B948C  ldr      x0, [x0, #0xa28]
0066B9490  bl       #0x382bd14 ; 
0066B9494  mov      w8, #1
0066B9498  strb     w8, [x19, #0x270]
0066B949C  adrp     x8, #0x8f11000
0066B94A0  ldr      x8, [x8, #0xa28]
0066B94A4  ldr      x1, [x8]
0066B94A8  ldrb     w8, [x1, #0x53]
0066B94AC  tbnz     w8, #5, #0x66b94b8
0066B94B0  ldr      x0, [x23, #0x30]
0066B94B4  b        #0x66b94c4 ; 
0066B94B8  ldr      x8, [x1, #0x60]
0066B94BC  mov      x0, x23
0066B94C0  blr      x8
0066B94C4  add      x0, x0, #0x10, lsl #12
0066B94C8  b        #0x66b967c ; 
0066B94CC  ldr      x8, [x1, #0x60]
0066B94D0  mov      x0, x19
0066B94D4  blr      x8
0066B94D8  mov      x19, x0
0066B94DC  cbz      x19, #0x66b96a4
0066B94E0  ldrb     w8, [x28, #0xfcc]
0066B94E4  cbnz     w8, #0x66b94fc
0066B94E8  adrp     x0, #0x8f06000
0066B94EC  ldr      x0, [x0, #0x470]
0066B94F0  bl       #0x382bd14 ; 
0066B94F4  mov      w8, #1
0066B94F8  strb     w8, [x28, #0xfcc]
0066B94FC  ldr      x1, [x22]
0066B9500  ldrb     w8, [x1, #0x53]
0066B9504  tbnz     w8, #5, #0x66b9510
0066B9508  ldr      x0, [x19, #0x200]
0066B950C  b        #0x66b951c ; 
0066B9510  ldr      x8, [x1, #0x60]
0066B9514  mov      x0, x19
0066B9518  blr      x8
0066B951C  cbz      x0, #0x66b96a4
0066B9520  mov      x1, xzr
0066B9524  bl       #0x64d2d84 ; LocalModels.LocalModelManager$$GetBullet_OutsideBulletHurtGrowthElements
0066B9528  cbz      x0, #0x66b9678
0066B952C  adrp     x20, #0x8f11000
0066B9530  ldr      x8, [x0]
0066B9534  ldr      x20, [x20, #0xa08]
0066B9538  mov      x19, x0
0066B953C  ldrh     w9, [x8, #0x12e]
0066B9540  ldr      x1, [x20]
0066B9544  cbz      x9, #0x66b9568
0066B9548  ldr      x10, [x8, #0xb0]
0066B954C  add      x10, x10, #8
0066B9550  ldur     x11, [x10, #-8]
0066B9554  cmp      x11, x1
0066B9558  b.eq     #0x66b9590
0066B955C  subs     x9, x9, #1
0066B9560  add      x10, x10, #0x10
0066B9564  b.ne     #0x66b9550
0066B9568  mov      x0, x19
0066B956C  mov      w2, wzr
0066B9570  bl       #0x3a7e710 ; 
0066B9574  b        #0x66b959c ; 
0066B9578  ldr      x8, [x1, #0x60]
0066B957C  mov      x0, x22
0066B9580  blr      x8
0066B9584  mov      x22, x0
0066B9588  cbnz     x22, #0x66b90d4
0066B958C  b        #0x66b9678 ; 
0066B9590  ldrsw    x9, [x10]
0066B9594  add      x8, x8, x9, lsl #4
0066B9598  add      x0, x8, #0x138
0066B959C  ldp      x8, x1, [x0]
0066B95A0  mov      x0, x19
0066B95A4  blr      x8
0066B95A8  cmp      w0, #1
0066B95AC  b.lt     #0x66b9678
0066B95B0  ldr      x8, [x19]
0066B95B4  ldr      x1, [x20]
0066B95B8  ldrh     w9, [x8, #0x12e]
0066B95BC  cbz      x9, #0x66b95e0
0066B95C0  ldr      x10, [x8, #0xb0]
0066B95C4  add      x10, x10, #8
0066B95C8  ldur     x11, [x10, #-8]
0066B95CC  cmp      x11, x1
0066B95D0  b.eq     #0x66b95f0
0066B95D4  subs     x9, x9, #1
0066B95D8  add      x10, x10, #0x10
0066B95DC  b.ne     #0x66b95c8
0066B95E0  mov      x0, x19
0066B95E4  mov      w2, wzr
0066B95E8  bl       #0x3a7e710 ; 
0066B95EC  b        #0x66b95fc ; 
0066B95F0  ldrsw    x9, [x10]
0066B95F4  add      x8, x8, x9, lsl #4
0066B95F8  add      x0, x8, #0x138
0066B95FC  ldp      x8, x1, [x0]
0066B9600  mov      x0, x19
0066B9604  blr      x8
0066B9608  adrp     x10, #0x8f11000
0066B960C  ldr      x8, [x19]
0066B9610  ldr      x10, [x10, #0xa10]
0066B9614  sub      w20, w0, #1
0066B9618  ldrh     w9, [x8, #0x12e]
0066B961C  ldr      x1, [x10]
0066B9620  cbz      x9, #0x66b9644
0066B9624  ldr      x10, [x8, #0xb0]
0066B9628  add      x10, x10, #8
0066B962C  ldur     x11, [x10, #-8]
0066B9630  cmp      x11, x1
0066B9634  b.eq     #0x66b9654
0066B9638  subs     x9, x9, #1
0066B963C  add      x10, x10, #0x10
0066B9640  b.ne     #0x66b962c
0066B9644  mov      x0, x19
0066B9648  mov      w2, wzr
0066B964C  bl       #0x3a7e710 ; 
0066B9650  b        #0x66b9660 ; 
0066B9654  ldrsw    x9, [x10]
0066B9658  add      x8, x8, x9, lsl #4
0066B965C  add      x0, x8, #0x138
0066B9660  ldp      x8, x2, [x0]
0066B9664  mov      x0, x19
0066B9668  mov      w1, w20
0066B966C  blr      x8
0066B9670  mov      x23, x0
0066B9674  cbnz     x0, #0x66b9400
0066B9678  mov      w0, #0x10000
0066B967C  ldp      x20, x19, [sp, #0x90]
0066B9680  ldp      x22, x21, [sp, #0x80]
0066B9684  ldp      x24, x23, [sp, #0x70]
0066B9688  ldp      x26, x25, [sp, #0x60]
0066B968C  ldp      x28, x27, [sp, #0x50]
0066B9690  ldp      x29, x30, [sp, #0x40]
0066B9694  add      sp, sp, #0xa0
0066B9698  ret      
0066B969C  bl       #0x382bfb8 ; 
0066B96A0  bl       #0x382bfb8 ; 
0066B96A4  bl       #0x382bfb8 ; 
0066B96A8  b        #0x66b96c0 ; 
0066B96AC  b        #0x66b96c0 ; 
0066B96B0  b        #0x66b96c0 ; 
0066B96B4  b        #0x66b96c0 ; 
0066B96B8  b        #0x66b96c0 ; 
0066B96BC  b        #0x66b96c0 ; 
0066B96C0  mov      x24, x0
0066B96C4  cmp      w1, #1
0066B96C8  b.ne     #0x66b96fc
0066B96CC  mov      x0, x24
0066B96D0  bl       #0x89eda50 ; 
0066B96D4  ldr      x25, [x0]
0066B96D8  bl       #0x89eda60 ; 
0066B96DC  adrp     x8, #0x8ee5000
0066B96E0  ldr      x8, [x8, #0x768]
0066B96E4  add      x0, sp, #0x20
0066B96E8  ldr      x1, [x8]
0066B96EC  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
0066B96F0  cbz      x25, #0x66b927c
0066B96F4  mov      x0, x25
0066B96F8  bl       #0x382bfb0 ; 
0066B96FC  mov      x25, xzr
0066B9700  b        #0x66b9708 ; 
0066B9704  mov      x24, x0
0066B9708  adrp     x8, #0x8ee5000
0066B970C  ldr      x8, [x8, #0x768]
0066B9710  ldr      x1, [x8]
0066B9714  add      x0, sp, #0x20
0066B9718  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
0066B971C  cbnz     x25, #0x66b9728
0066B9720  mov      x0, x24
0066B9724  bl       #0x3b56bfc ; 
0066B9728  mov      x0, x25
0066B972C  bl       #0x382bfb0 ; 
0066B9730  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleLaserStacking
; RVA 0x66B7FB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B7FB8  stp      x30, x23, [sp, #-0x30]!
0066B7FBC  stp      x22, x21, [sp, #0x10]
0066B7FC0  stp      x20, x19, [sp, #0x20]
0066B7FC4  adrp     x22, #0x959a000
0066B7FC8  adrp     x23, #0x8f11000
0066B7FCC  ldrb     w8, [x22, #0x208]
0066B7FD0  ldr      x23, [x23, #0x990]
0066B7FD4  mov      x20, x2
0066B7FD8  mov      w21, w1
0066B7FDC  mov      x19, x0
0066B7FE0  tbnz     w8, #0, #0x66b8010
0066B7FE4  adrp     x0, #0x8f11000
0066B7FE8  ldr      x0, [x0, #0x990]
0066B7FEC  bl       #0x382bd14 ; 
0066B7FF0  adrp     x0, #0x8ee6000
0066B7FF4  ldr      x0, [x0, #0xd8]
0066B7FF8  bl       #0x382bd14 ; 
0066B7FFC  adrp     x0, #0x8ee6000
0066B8000  ldr      x0, [x0, #0x600]
0066B8004  bl       #0x382bd14 ; 
0066B8008  mov      w8, #1
0066B800C  strb     w8, [x22, #0x208]
0066B8010  ldr      x3, [x23]
0066B8014  ldrb     w8, [x3, #0x53]
0066B8018  tbnz     w8, #5, #0x66b804c
0066B801C  mov      x0, x19
0066B8020  mov      w1, w21
0066B8024  bl       #0x66b9734 ; HotFix.BattleLogic.CharacterComponentOnHit$$IsLaserBullet
0066B8028  tbz      w0, #0, #0x66b806c
0066B802C  cbz      x20, #0x66b8114
0066B8030  adrp     x8, #0x8ee6000
0066B8034  ldr      x8, [x8, #0xd8]
0066B8038  ldr      x1, [x8]
0066B803C  ldrb     w8, [x1, #0x53]
0066B8040  tbnz     w8, #5, #0x66b80ac
0066B8044  ldr      x20, [x20, #0x38]
0066B8048  b        #0x66b80bc ; 
0066B804C  ldr      x4, [x3, #0x60]
0066B8050  mov      x0, x19
0066B8054  mov      w1, w21
0066B8058  mov      x2, x20
0066B805C  ldp      x20, x19, [sp, #0x20]
0066B8060  ldp      x22, x21, [sp, #0x10]
0066B8064  ldp      x30, x23, [sp], #0x30
0066B8068  br       x4
0066B806C  adrp     x8, #0x8ee6000
0066B8070  ldr      x8, [x8, #0x600]
0066B8074  ldr      x1, [x8]
0066B8078  ldrb     w8, [x1, #0x53]
0066B807C  tbnz     w8, #5, #0x66b8088
0066B8080  ldr      x0, [x19, #0x38]
0066B8084  b        #0x66b8094 ; 
0066B8088  ldr      x8, [x1, #0x60]
0066B808C  mov      x0, x19
0066B8090  blr      x8
0066B8094  cbz      x0, #0x66b8224
0066B8098  ldp      x20, x19, [sp, #0x20]
0066B809C  ldp      x22, x21, [sp, #0x10]
0066B80A0  mov      x1, xzr
0066B80A4  ldp      x30, x23, [sp], #0x30
0066B80A8  b        #0x6826c24 ; HotFix.BattleLogic.EntityCharacterData$$ResetLaserStack
0066B80AC  ldr      x8, [x1, #0x60]
0066B80B0  mov      x0, x20
0066B80B4  blr      x8
0066B80B8  mov      x20, x0
0066B80BC  cbz      x20, #0x66b8224
0066B80C0  adrp     x21, #0x959a000
0066B80C4  ldrb     w8, [x21, #0x271]
0066B80C8  cbnz     w8, #0x66b80e0
0066B80CC  adrp     x0, #0x8f11000
0066B80D0  ldr      x0, [x0, #0x998]
0066B80D4  bl       #0x382bd14 ; 
0066B80D8  mov      w8, #1
0066B80DC  strb     w8, [x21, #0x271]
0066B80E0  adrp     x8, #0x8f11000
0066B80E4  ldr      x8, [x8, #0x998]
0066B80E8  ldr      x1, [x8]
0066B80EC  ldrb     w8, [x1, #0x53]
0066B80F0  tbnz     w8, #5, #0x66b8104
0066B80F4  ldrb     w8, [x20, #0x298]
0066B80F8  cmp      w8, #0
0066B80FC  cset     w20, ne
0066B8100  b        #0x66b8114 ; 
0066B8104  ldr      x8, [x1, #0x60]
0066B8108  mov      x0, x20
0066B810C  blr      x8
0066B8110  mov      w20, w0
0066B8114  adrp     x22, #0x8ee6000
0066B8118  ldr      x22, [x22, #0x600]
0066B811C  ldr      x1, [x22]
0066B8120  ldrb     w8, [x1, #0x53]
0066B8124  tbnz     w8, #5, #0x66b8130
0066B8128  ldr      x21, [x19, #0x38]
0066B812C  b        #0x66b8140 ; 
0066B8130  ldr      x8, [x1, #0x60]
0066B8134  mov      x0, x19
0066B8138  blr      x8
0066B813C  mov      x21, x0
0066B8140  cbz      x21, #0x66b8224
0066B8144  adrp     x23, #0x959a000
0066B8148  ldrb     w8, [x23, #0x272]
0066B814C  cbnz     w8, #0x66b8164
0066B8150  adrp     x0, #0x8f11000
0066B8154  ldr      x0, [x0, #0x9a0]
0066B8158  bl       #0x382bd14 ; 
0066B815C  mov      w8, #1
0066B8160  strb     w8, [x23, #0x272]
0066B8164  adrp     x8, #0x8f11000
0066B8168  ldr      x8, [x8, #0x9a0]
0066B816C  ldr      x1, [x8]
0066B8170  ldrb     w8, [x1, #0x53]
0066B8174  tbnz     w8, #5, #0x66b8184
0066B8178  ldr      w0, [x21, #0x288]
0066B817C  cbnz     w0, #0x66b81e8
0066B8180  b        #0x66b8194 ; 
0066B8184  ldr      x8, [x1, #0x60]
0066B8188  mov      x0, x21
0066B818C  blr      x8
0066B8190  cbnz     w0, #0x66b81e8
0066B8194  adrp     x21, #0x9591000
0066B8198  ldrb     w8, [x21, #0xa4b]
0066B819C  cbnz     w8, #0x66b81b4
0066B81A0  adrp     x0, #0x8ee5000
0066B81A4  ldr      x0, [x0, #0xb28]
0066B81A8  bl       #0x382bd14 ; 
0066B81AC  mov      w8, #1
0066B81B0  strb     w8, [x21, #0xa4b]
0066B81B4  adrp     x8, #0x8ee5000
0066B81B8  ldr      x8, [x8, #0xb28]
0066B81BC  ldr      x1, [x8]
0066B81C0  ldrb     w8, [x1, #0x53]
0066B81C4  tbnz     w8, #5, #0x66b81d0
0066B81C8  ldr      x0, [x19, #0x20]
0066B81CC  b        #0x66b81dc ; 
0066B81D0  ldr      x8, [x1, #0x60]
0066B81D4  mov      x0, x19
0066B81D8  blr      x8
0066B81DC  cbz      x0, #0x66b8224
0066B81E0  ldr      x8, [x0, #0x128]
0066B81E4  str      x8, [x19, #0x48]
0066B81E8  ldr      x1, [x22]
0066B81EC  ldrb     w8, [x1, #0x53]
0066B81F0  tbnz     w8, #5, #0x66b81fc
0066B81F4  ldr      x0, [x19, #0x38]
0066B81F8  b        #0x66b8208 ; 
0066B81FC  ldr      x8, [x1, #0x60]
0066B8200  mov      x0, x19
0066B8204  blr      x8
0066B8208  cbz      x0, #0x66b8224
0066B820C  and      w1, w20, #1
0066B8210  ldp      x20, x19, [sp, #0x20]
0066B8214  ldp      x22, x21, [sp, #0x10]
0066B8218  mov      x2, xzr
0066B821C  ldp      x30, x23, [sp], #0x30
0066B8220  b        #0x6826c90 ; HotFix.BattleLogic.EntityCharacterData$$ApplyLaserStack
0066B8224  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleOwnerAndTriggerOnBulletHit
; RVA 0x66B7A34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B7A34  str      x30, [sp, #-0x60]!
0066B7A38  stp      x28, x27, [sp, #0x10]
0066B7A3C  stp      x26, x25, [sp, #0x20]
0066B7A40  stp      x24, x23, [sp, #0x30]
0066B7A44  stp      x22, x21, [sp, #0x40]
0066B7A48  stp      x20, x19, [sp, #0x50]
0066B7A4C  adrp     x27, #0x959a000
0066B7A50  adrp     x28, #0x8f11000
0066B7A54  ldrb     w8, [x27, #0x209]
0066B7A58  ldr      x28, [x28, #0x948]
0066B7A5C  mov      x24, x7
0066B7A60  mov      x19, x6
0066B7A64  mov      x22, x5
0066B7A68  mov      w25, w4
0066B7A6C  mov      x26, x3
0066B7A70  mov      x20, x2
0066B7A74  mov      x21, x1
0066B7A78  mov      x23, x0
0066B7A7C  tbnz     w8, #0, #0x66b7a94
0066B7A80  adrp     x0, #0x8f11000
0066B7A84  ldr      x0, [x0, #0x948]
0066B7A88  bl       #0x382bd14 ; 
0066B7A8C  mov      w8, #1
0066B7A90  strb     w8, [x27, #0x209]
0066B7A94  ldr      x8, [x28]
0066B7A98  ldrb     w9, [x8, #0x53]
0066B7A9C  tbnz     w9, #5, #0x66b7b3c
0066B7AA0  cbz      x19, #0x66b7b20
0066B7AA4  mov      x0, x19
0066B7AA8  mov      x1, xzr
0066B7AAC  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0066B7AB0  tbnz     w0, #0, #0x66b7b20
0066B7AB4  cbz      x24, #0x66b7ad8
0066B7AB8  mov      x0, x23
0066B7ABC  mov      x1, x21
0066B7AC0  mov      x2, x26
0066B7AC4  mov      x3, x22
0066B7AC8  mov      x4, x19
0066B7ACC  mov      x5, x24
0066B7AD0  mov      x6, x20
0066B7AD4  bl       #0x66b97b4 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleOwnerHitCountsAndAnyWeaponEvents
0066B7AD8  mov      x0, x23
0066B7ADC  mov      x1, x21
0066B7AE0  mov      x2, x20
0066B7AE4  mov      x3, x26
0066B7AE8  mov      w4, w25
0066B7AEC  mov      x5, x22
0066B7AF0  mov      x6, x24
0066B7AF4  bl       #0x66ba928 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleGenericHitTrigger
0066B7AF8  mov      x0, x23
0066B7AFC  mov      x1, x21
0066B7B00  mov      x2, x22
0066B7B04  mov      x3, x19
0066B7B08  bl       #0x66bb1a4 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBatterLogic
0066B7B0C  mov      x0, x23
0066B7B10  mov      x1, x21
0066B7B14  mov      x2, x20
0066B7B18  mov      x3, x19
0066B7B1C  bl       #0x66bb5e0 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleHitHealIfHero
0066B7B20  ldp      x20, x19, [sp, #0x50]
0066B7B24  ldp      x22, x21, [sp, #0x40]
0066B7B28  ldp      x24, x23, [sp, #0x30]
0066B7B2C  ldp      x26, x25, [sp, #0x20]
0066B7B30  ldp      x28, x27, [sp, #0x10]
0066B7B34  ldr      x30, [sp], #0x60
0066B7B38  ret      
0066B7B3C  ldr      x9, [x8, #0x60]
0066B7B40  mov      x0, x23
0066B7B44  mov      x1, x21
0066B7B48  mov      x2, x20
0066B7B4C  mov      x3, x26
0066B7B50  mov      w4, w25
0066B7B54  mov      x5, x22
0066B7B58  mov      x6, x19
0066B7B5C  mov      x7, x24
0066B7B60  ldp      x20, x19, [sp, #0x50]
0066B7B64  ldp      x22, x21, [sp, #0x40]
0066B7B68  ldp      x24, x23, [sp, #0x30]
0066B7B6C  ldp      x26, x25, [sp, #0x20]
0066B7B70  ldp      x28, x27, [sp, #0x10]
0066B7B74  str      x8, [sp, #0x60]
0066B7B78  ldr      x30, [sp], #0x60
0066B7B7C  br       x9
0066B7B80  b        #0x66b7b90 ; 
0066B7B84  b        #0x66b7b90 ; 
0066B7B88  b        #0x66b7b90 ; 
0066B7B8C  b        #0x66b7b90 ; 
0066B7B90  cmp      w1, #1
0066B7B94  b.ne     #0x66b7bb4
0066B7B98  bl       #0x89eda50 ; 
0066B7B9C  ldr      x19, [x0]
0066B7BA0  bl       #0x89eda60 ; 
0066B7BA4  cbz      x19, #0x66b7b20
0066B7BA8  mov      x0, x19
0066B7BAC  bl       #0x382bfb0 ; 
0066B7BB0  cbnz     x19, #0x66b7bb8
0066B7BB4  bl       #0x3b56bfc ; 
0066B7BB8  mov      x0, x19
0066B7BBC  bl       #0x382bfb0 ; 
0066B7BC0  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleOwnerHitCountsAndAnyWeaponEvents
; RVA 0x66B97B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B97B4  sub      sp, sp, #0xc0
0066B97B8  stp      x29, x30, [sp, #0x60]
0066B97BC  stp      x28, x27, [sp, #0x70]
0066B97C0  stp      x26, x25, [sp, #0x80]
0066B97C4  stp      x24, x23, [sp, #0x90]
0066B97C8  stp      x22, x21, [sp, #0xa0]
0066B97CC  stp      x20, x19, [sp, #0xb0]
0066B97D0  str      x3, [sp, #0x18]
0066B97D4  mrs      x26, tpidr_el0
0066B97D8  ldr      x8, [x26, #0x28]
0066B97DC  adrp     x22, #0x959a000
0066B97E0  adrp     x25, #0x8f11000
0066B97E4  mov      x29, x6
0066B97E8  str      x8, [sp, #0x58]
0066B97EC  ldrb     w8, [x22, #0x20a]
0066B97F0  ldr      x25, [x25, #0xa38]
0066B97F4  mov      x19, x5
0066B97F8  mov      x20, x4
0066B97FC  mov      x23, x2
0066B9800  mov      x24, x1
0066B9804  mov      x21, x0
0066B9808  tbnz     w8, #0, #0x66b98c8
0066B980C  adrp     x0, #0x8f11000
0066B9810  ldr      x0, [x0, #0xa38]
0066B9814  bl       #0x382bd14 ; 
0066B9818  adrp     x0, #0x8f11000
0066B981C  ldr      x0, [x0, #0xa40]
0066B9820  bl       #0x382bd14 ; 
0066B9824  adrp     x0, #0x8eea000
0066B9828  ldr      x0, [x0, #0xf00]
0066B982C  bl       #0x382bd14 ; 
0066B9830  adrp     x0, #0x8ee6000
0066B9834  ldr      x0, [x0, #0xe8]
0066B9838  bl       #0x382bd14 ; 
0066B983C  adrp     x0, #0x8ee6000
0066B9840  ldr      x0, [x0, #0xf0]
0066B9844  bl       #0x382bd14 ; 
0066B9848  adrp     x0, #0x8ee6000
0066B984C  ldr      x0, [x0, #0x608]
0066B9850  bl       #0x382bd14 ; 
0066B9854  adrp     x0, #0x8ec2000
0066B9858  ldr      x0, [x0, #0x260]
0066B985C  bl       #0x382bd14 ; 
0066B9860  adrp     x0, #0x8ec2000
0066B9864  ldr      x0, [x0, #0x240]
0066B9868  bl       #0x382bd14 ; 
0066B986C  adrp     x0, #0x8eea000
0066B9870  ldr      x0, [x0, #0xf18]
0066B9874  bl       #0x382bd14 ; 
0066B9878  adrp     x0, #0x8ec2000
0066B987C  ldr      x0, [x0, #0x268]
0066B9880  bl       #0x382bd14 ; 
0066B9884  adrp     x0, #0x8f11000
0066B9888  ldr      x0, [x0, #0xa48]
0066B988C  bl       #0x382bd14 ; 
0066B9890  adrp     x0, #0x8f11000
0066B9894  ldr      x0, [x0, #0xa50]
0066B9898  bl       #0x382bd14 ; 
0066B989C  adrp     x0, #0x8f11000
0066B98A0  ldr      x0, [x0, #0xa58]
0066B98A4  bl       #0x382bd14 ; 
0066B98A8  adrp     x0, #0x8f11000
0066B98AC  ldr      x0, [x0, #0xa60]
0066B98B0  bl       #0x382bd14 ; 
0066B98B4  adrp     x0, #0x8f08000
0066B98B8  ldr      x0, [x0, #0xbb8]
0066B98BC  bl       #0x382bd14 ; 
0066B98C0  mov      w8, #1
0066B98C4  strb     w8, [x22, #0x20a]
0066B98C8  ldr      x7, [x25]
0066B98CC  ldrb     w8, [x7, #0x53]
0066B98D0  tbnz     w8, #5, #0x66b992c
0066B98D4  adrp     x8, #0x8f11000
0066B98D8  ldr      x8, [x8, #0xa40]
0066B98DC  str      x26, [sp, #0x10]
0066B98E0  ldr      x0, [x8]
0066B98E4  ldr      w8, [x0, #0xe0]
0066B98E8  cbnz     w8, #0x66b98f0
0066B98EC  bl       #0x382be8c ; 
0066B98F0  mov      x0, x19
0066B98F4  bl       #0x66bb9dc ; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCountKey
0066B98F8  cbz      x19, #0x66ba720
0066B98FC  mov      x25, x0
0066B9900  mov      x0, x19
0066B9904  mov      x1, xzr
0066B9908  bl       #0x67e4f78 ; HotFix.BattleLogic.EntityCharacter$$GetRootCharacter
0066B990C  cbz      x0, #0x66ba724
0066B9910  adrp     x22, #0x8ee6000
0066B9914  ldr      x22, [x22, #0xe8]
0066B9918  ldr      x1, [x22]
0066B991C  ldrb     w8, [x1, #0x53]
0066B9920  tbnz     w8, #5, #0x66b9958
0066B9924  ldr      x26, [x0, #0x28]
0066B9928  b        #0x66b9964 ; 
0066B992C  ldr      x8, [x7, #0x60]
0066B9930  ldr      x3, [sp, #0x18]
0066B9934  mov      x0, x21
0066B9938  mov      x1, x24
0066B993C  mov      x2, x23
0066B9940  mov      x4, x20
0066B9944  mov      x5, x19
0066B9948  mov      x6, x29
0066B994C  blr      x8
0066B9950  ldr      x8, [x26, #0x28]
0066B9954  b        #0x66ba6ec ; 
0066B9958  ldr      x8, [x1, #0x60]
0066B995C  blr      x8
0066B9960  mov      x26, x0
0066B9964  cbz      x23, #0x66ba728
0066B9968  adrp     x8, #0x9591000
0066B996C  ldrb     w8, [x8, #0xa85]
0066B9970  cbnz     w8, #0x66b998c
0066B9974  adrp     x0, #0x8ee6000
0066B9978  ldr      x0, [x0, #0x310]
0066B997C  bl       #0x382bd14 ; 
0066B9980  mov      w8, #1
0066B9984  adrp     x9, #0x9591000
0066B9988  strb     w8, [x9, #0xa85]
0066B998C  adrp     x8, #0x8ee6000
0066B9990  ldr      x8, [x8, #0x310]
0066B9994  ldr      x1, [x8]
0066B9998  ldrb     w8, [x1, #0x53]
0066B999C  tbnz     w8, #5, #0x66b99a8
0066B99A0  ldr      w3, [x23, #0xb8]
0066B99A4  b        #0x66b99b8 ; 
0066B99A8  ldr      x8, [x1, #0x60]
0066B99AC  mov      x0, x23
0066B99B0  blr      x8
0066B99B4  mov      w3, w0
0066B99B8  mov      x0, x21
0066B99BC  mov      x1, x19
0066B99C0  mov      x2, x25
0066B99C4  mov      x4, x29
0066B99C8  bl       #0x66bbad0 ; HotFix.BattleLogic.CharacterComponentOnHit$$IsSameEnemyMilestoneExplosionHit
0066B99CC  tbz      w0, #0, #0x66b99dc
0066B99D0  mov      w28, wzr
0066B99D4  mov      w27, wzr
0066B99D8  b        #0x66b9a04 ; 
0066B99DC  mov      x0, x21
0066B99E0  mov      x1, x26
0066B99E4  mov      x2, x25
0066B99E8  bl       #0x66bbbd8 ; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponHittedCount
0066B99EC  mov      w27, w0
0066B99F0  mov      x0, x21
0066B99F4  mov      x1, x26
0066B99F8  mov      x2, x25
0066B99FC  bl       #0x66bbe1c ; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponHittedCount1s
0066B9A00  mov      w28, w0
0066B9A04  mov      x0, x19
0066B9A08  mov      x1, xzr
0066B9A0C  bl       #0x67e4f78 ; HotFix.BattleLogic.EntityCharacter$$GetRootCharacter
0066B9A10  cbz      x0, #0x66ba72c
0066B9A14  ldr      x1, [x22]
0066B9A18  ldrb     w8, [x1, #0x53]
0066B9A1C  tbnz     w8, #5, #0x66b9a28
0066B9A20  ldr      x20, [x0, #0x28]
0066B9A24  b        #0x66b9a34 ; 
0066B9A28  ldr      x8, [x1, #0x60]
0066B9A2C  blr      x8
0066B9A30  mov      x20, x0
0066B9A34  adrp     x8, #0x9591000
0066B9A38  ldrb     w8, [x8, #0xa85]
0066B9A3C  cbnz     w8, #0x66b9a58
0066B9A40  adrp     x0, #0x8ee6000
0066B9A44  ldr      x0, [x0, #0x310]
0066B9A48  bl       #0x382bd14 ; 
0066B9A4C  mov      w8, #1
0066B9A50  adrp     x9, #0x9591000
0066B9A54  strb     w8, [x9, #0xa85]
0066B9A58  adrp     x8, #0x8ee6000
0066B9A5C  ldr      x8, [x8, #0x310]
0066B9A60  ldr      x1, [x8]
0066B9A64  ldrb     w8, [x1, #0x53]
0066B9A68  tbnz     w8, #5, #0x66b9a74
0066B9A6C  ldr      w2, [x23, #0xb8]
0066B9A70  b        #0x66b9a84 ; 
0066B9A74  ldr      x8, [x1, #0x60]
0066B9A78  mov      x0, x23
0066B9A7C  blr      x8
0066B9A80  mov      w2, w0
0066B9A84  mov      x0, x21
0066B9A88  mov      x1, x20
0066B9A8C  bl       #0x66bc060 ; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponIdHittedCount
0066B9A90  mov      x0, x19
0066B9A94  mov      x1, xzr
0066B9A98  bl       #0x67e4f78 ; HotFix.BattleLogic.EntityCharacter$$GetRootCharacter
0066B9A9C  cbz      x0, #0x66ba730
0066B9AA0  ldr      x1, [x22]
0066B9AA4  ldrb     w8, [x1, #0x53]
0066B9AA8  tbnz     w8, #5, #0x66b9ab4
0066B9AAC  ldr      x20, [x0, #0x28]
0066B9AB0  b        #0x66b9ac0 ; 
0066B9AB4  ldr      x8, [x1, #0x60]
0066B9AB8  blr      x8
0066B9ABC  mov      x20, x0
0066B9AC0  adrp     x8, #0x9591000
0066B9AC4  ldrb     w8, [x8, #0xa85]
0066B9AC8  cbnz     w8, #0x66b9ae4
0066B9ACC  adrp     x0, #0x8ee6000
0066B9AD0  ldr      x0, [x0, #0x310]
0066B9AD4  bl       #0x382bd14 ; 
0066B9AD8  mov      w8, #1
0066B9ADC  adrp     x9, #0x9591000
0066B9AE0  strb     w8, [x9, #0xa85]
0066B9AE4  adrp     x8, #0x8ee6000
0066B9AE8  ldr      x8, [x8, #0x310]
0066B9AEC  ldr      x1, [x8]
0066B9AF0  ldrb     w8, [x1, #0x53]
0066B9AF4  tbnz     w8, #5, #0x66b9b00
0066B9AF8  ldr      w2, [x23, #0xb8]
0066B9AFC  b        #0x66b9b10 ; 
0066B9B00  ldr      x8, [x1, #0x60]
0066B9B04  mov      x0, x23
0066B9B08  blr      x8
0066B9B0C  mov      w2, w0
0066B9B10  mov      x0, x21
0066B9B14  mov      x1, x20
0066B9B18  bl       #0x66bc294 ; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponIdHittedCount1s
0066B9B1C  str      x29, [sp, #8]
0066B9B20  adrp     x8, #0x8ee6000
0066B9B24  ldr      x8, [x8, #0x608]
0066B9B28  ldr      x1, [x8]
0066B9B2C  ldrb     w8, [x1, #0x53]
0066B9B30  tbnz     w8, #5, #0x66b9b3c
0066B9B34  ldr      x29, [x21, #0x30]
0066B9B38  b        #0x66b9b4c ; 
0066B9B3C  ldr      x8, [x1, #0x60]
0066B9B40  mov      x0, x21
0066B9B44  blr      x8
0066B9B48  mov      x29, x0
0066B9B4C  ldr      x1, [x22]
0066B9B50  ldrb     w8, [x1, #0x53]
0066B9B54  tbnz     w8, #5, #0x66b9b60
0066B9B58  ldr      x20, [x19, #0x28]
0066B9B5C  b        #0x66b9b70 ; 
0066B9B60  ldr      x8, [x1, #0x60]
0066B9B64  mov      x0, x19
0066B9B68  blr      x8
0066B9B6C  mov      x20, x0
0066B9B70  adrp     x8, #0x9591000
0066B9B74  ldrb     w8, [x8, #0xa85]
0066B9B78  cbnz     w8, #0x66b9b94
0066B9B7C  adrp     x0, #0x8ee6000
0066B9B80  ldr      x0, [x0, #0x310]
0066B9B84  bl       #0x382bd14 ; 
0066B9B88  mov      w8, #1
0066B9B8C  adrp     x9, #0x9591000
0066B9B90  strb     w8, [x9, #0xa85]
0066B9B94  adrp     x8, #0x8ee6000
0066B9B98  ldr      x8, [x8, #0x310]
0066B9B9C  ldr      x1, [x8]
0066B9BA0  ldrb     w8, [x1, #0x53]
0066B9BA4  tbnz     w8, #5, #0x66b9bb0
0066B9BA8  ldr      w22, [x23, #0xb8]
0066B9BAC  b        #0x66b9bc0 ; 
0066B9BB0  ldr      x8, [x1, #0x60]
0066B9BB4  mov      x0, x23
0066B9BB8  blr      x8
0066B9BBC  mov      w22, w0
0066B9BC0  adrp     x8, #0x9591000
0066B9BC4  ldrb     w8, [x8, #0xa4b]
0066B9BC8  cbnz     w8, #0x66b9be4
0066B9BCC  adrp     x0, #0x8ee5000
0066B9BD0  ldr      x0, [x0, #0xb28]
0066B9BD4  bl       #0x382bd14 ; 
0066B9BD8  mov      w8, #1
0066B9BDC  adrp     x9, #0x9591000
0066B9BE0  strb     w8, [x9, #0xa4b]
0066B9BE4  adrp     x8, #0x8ee5000
0066B9BE8  ldr      x8, [x8, #0xb28]
0066B9BEC  ldr      x1, [x8]
0066B9BF0  ldrb     w8, [x1, #0x53]
0066B9BF4  tbnz     w8, #5, #0x66b9c00
0066B9BF8  ldr      x0, [x21, #0x20]
0066B9BFC  b        #0x66b9c0c ; 
0066B9C00  ldr      x8, [x1, #0x60]
0066B9C04  mov      x0, x21
0066B9C08  blr      x8
0066B9C0C  cbz      x0, #0x66ba734
0066B9C10  cbz      x29, #0x66ba738
0066B9C14  ldr      x4, [x0, #0x198]
0066B9C18  mov      w3, #1
0066B9C1C  mov      x0, x29
0066B9C20  mov      x1, x20
0066B9C24  mov      w2, w22
0066B9C28  mov      x5, xzr
0066B9C2C  bl       #0x67f41e4 ; HotFix.BattleLogic.EntityCharacter$$SetHurtByEnemyCountData
0066B9C30  ldr      x29, [sp, #0x10]
0066B9C34  cbz      x24, #0x66ba73c
0066B9C38  ldr      x8, [x24, #0x38]
0066B9C3C  ldur     q0, [x24, #0x28]
0066B9C40  str      x8, [sp, #0x50]
0066B9C44  str      q0, [sp, #0x40]
0066B9C48  add      x4, sp, #0x40
0066B9C4C  mov      x0, x21
0066B9C50  mov      x1, x19
0066B9C54  mov      x2, x26
0066B9C58  mov      x3, x25
0066B9C5C  mov      w5, w27
0066B9C60  mov      w6, w28
0066B9C64  bl       #0x66bc4c8 ; HotFix.BattleLogic.CharacterComponentOnHit$$TryFireSameEnemyMilestoneExplosion
0066B9C68  adrp     x26, #0x9591000
0066B9C6C  ldrb     w8, [x26, #0xa86]
0066B9C70  cbnz     w8, #0x66b9c94
0066B9C74  adrp     x0, #0x8ee6000
0066B9C78  ldr      x0, [x0, #0x318]
0066B9C7C  bl       #0x382bd14 ; 
0066B9C80  adrp     x0, #0x8ee3000
0066B9C84  ldr      x0, [x0, #0xf18]
0066B9C88  bl       #0x382bd14 ; 
0066B9C8C  mov      w8, #1
0066B9C90  strb     w8, [x26, #0xa86]
0066B9C94  adrp     x27, #0x8ee6000
0066B9C98  ldr      x27, [x27, #0x318]
0066B9C9C  add      x22, x24, #0x28
0066B9CA0  ldr      x2, [x27]
0066B9CA4  ldrb     w8, [x2, #0x53]
0066B9CA8  tbnz     w8, #5, #0x66b9ccc
0066B9CAC  ldr      x0, [x19, #0x190]
0066B9CB0  cbz      x0, #0x66b9e60
0066B9CB4  adrp     x8, #0x8ee3000
0066B9CB8  ldr      x8, [x8, #0xf18]
0066B9CBC  ldr      x2, [x8]
0066B9CC0  mov      w1, #0x19
0066B9CC4  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066B9CC8  b        #0x66b9cdc ; 
0066B9CCC  ldr      x8, [x2, #0x60]
0066B9CD0  mov      w1, #0x19
0066B9CD4  mov      x0, x19
0066B9CD8  blr      x8
0066B9CDC  tbz      w0, #0, #0x66b9e60
0066B9CE0  mov      x0, x19
0066B9CE4  mov      x1, xzr
0066B9CE8  bl       #0x67da598 ; HotFix.BattleLogic.EntityCharacter$$IncrementHitCount
0066B9CEC  adrp     x8, #0x9591000
0066B9CF0  ldrb     w8, [x8, #0xa4b]
0066B9CF4  mov      x24, x0
0066B9CF8  cbnz     w8, #0x66b9d14
0066B9CFC  adrp     x0, #0x8ee5000
0066B9D00  ldr      x0, [x0, #0xb28]
0066B9D04  bl       #0x382bd14 ; 
0066B9D08  mov      w8, #1
0066B9D0C  adrp     x9, #0x9591000
0066B9D10  strb     w8, [x9, #0xa4b]
0066B9D14  adrp     x8, #0x8ee5000
0066B9D18  ldr      x8, [x8, #0xb28]
0066B9D1C  ldr      x1, [x8]
0066B9D20  ldrb     w8, [x1, #0x53]
0066B9D24  tbnz     w8, #5, #0x66b9d30
0066B9D28  ldr      x20, [x21, #0x20]
0066B9D2C  b        #0x66b9d40 ; 
0066B9D30  ldr      x8, [x1, #0x60]
0066B9D34  mov      x0, x21
0066B9D38  blr      x8
0066B9D3C  mov      x20, x0
0066B9D40  cbz      x20, #0x66ba740
0066B9D44  adrp     x25, #0x9591000
0066B9D48  ldrb     w8, [x25, #0xa4c]
0066B9D4C  cbnz     w8, #0x66b9d64
0066B9D50  adrp     x0, #0x8ee5000
0066B9D54  ldr      x0, [x0, #0xb30]
0066B9D58  bl       #0x382bd14 ; 
0066B9D5C  mov      w8, #1
0066B9D60  strb     w8, [x25, #0xa4c]
0066B9D64  adrp     x8, #0x8ee5000
0066B9D68  ldr      x8, [x8, #0xb30]
0066B9D6C  ldr      x1, [x8]
0066B9D70  ldrb     w8, [x1, #0x53]
0066B9D74  tbnz     w8, #5, #0x66b9d80
0066B9D78  ldr      x0, [x20, #0x210]
0066B9D7C  b        #0x66b9d8c ; 
0066B9D80  ldr      x8, [x1, #0x60]
0066B9D84  mov      x0, x20
0066B9D88  blr      x8
0066B9D8C  cbz      x0, #0x66ba744
0066B9D90  adrp     x8, #0x8f11000
0066B9D94  ldr      x8, [x8, #0xa58]
0066B9D98  ldr      x1, [x8]
0066B9D9C  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066B9DA0  ldr      x8, [x22, #0x10]
0066B9DA4  ldr      q0, [x22]
0066B9DA8  mov      x20, x0
0066B9DAC  str      x8, [sp, #0x30]
0066B9DB0  str      q0, [sp, #0x20]
0066B9DB4  cbz      x0, #0x66ba748
0066B9DB8  ldr      q0, [sp, #0x20]
0066B9DBC  ldr      x9, [sp, #0x30]
0066B9DC0  ldr      x8, [sp, #0x18]
0066B9DC4  str      q0, [x20, #0x20]
0066B9DC8  stp      x9, x8, [x20, #0x30]
0066B9DCC  adrp     x8, #0x8ee6000
0066B9DD0  ldr      x8, [x8, #0xe8]
0066B9DD4  ldr      x1, [x8]
0066B9DD8  ldrb     w8, [x1, #0x53]
0066B9DDC  tbnz     w8, #5, #0x66b9de8
0066B9DE0  ldr      x0, [x19, #0x28]
0066B9DE4  b        #0x66b9df4 ; 
0066B9DE8  ldr      x8, [x1, #0x60]
0066B9DEC  mov      x0, x19
0066B9DF0  blr      x8
0066B9DF4  str      x0, [x20, #0x40]
0066B9DF8  adrp     x8, #0x8ee6000
0066B9DFC  ldr      x8, [x8, #0x608]
0066B9E00  ldr      x1, [x8]
0066B9E04  ldrb     w8, [x1, #0x53]
0066B9E08  tbnz     w8, #5, #0x66b9e14
0066B9E0C  ldr      x0, [x21, #0x30]
0066B9E10  b        #0x66b9e20 ; 
0066B9E14  ldr      x8, [x1, #0x60]
0066B9E18  mov      x0, x21
0066B9E1C  blr      x8
0066B9E20  cbz      x0, #0x66ba750
0066B9E24  adrp     x8, #0x8ee6000
0066B9E28  ldr      x8, [x8, #0xe8]
0066B9E2C  ldr      x1, [x8]
0066B9E30  ldrb     w8, [x1, #0x53]
0066B9E34  tbnz     w8, #5, #0x66b9e40
0066B9E38  ldr      x0, [x0, #0x28]
0066B9E3C  b        #0x66b9e48 ; 
0066B9E40  ldr      x8, [x1, #0x60]
0066B9E44  blr      x8
0066B9E48  stp      x0, x24, [x20, #0x48]
0066B9E4C  ldr      x0, [x19, #0x150]
0066B9E50  cbz      x0, #0x66ba758
0066B9E54  mov      x1, x20
0066B9E58  mov      x2, xzr
0066B9E5C  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066B9E60  ldrb     w8, [x26, #0xa86]
0066B9E64  cbnz     w8, #0x66b9e88
0066B9E68  adrp     x0, #0x8ee6000
0066B9E6C  ldr      x0, [x0, #0x318]
0066B9E70  bl       #0x382bd14 ; 
0066B9E74  adrp     x0, #0x8ee3000
0066B9E78  ldr      x0, [x0, #0xf18]
0066B9E7C  bl       #0x382bd14 ; 
0066B9E80  mov      w8, #1
0066B9E84  strb     w8, [x26, #0xa86]
0066B9E88  ldr      x2, [x27]
0066B9E8C  ldrb     w8, [x2, #0x53]
0066B9E90  tbnz     w8, #5, #0x66b9eb4
0066B9E94  ldr      x0, [x19, #0x190]
0066B9E98  cbz      x0, #0x66ba088
0066B9E9C  adrp     x8, #0x8ee3000
0066B9EA0  ldr      x8, [x8, #0xf18]
0066B9EA4  ldr      x2, [x8]
0066B9EA8  mov      w1, #0x3d
0066B9EAC  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066B9EB0  b        #0x66b9ec4 ; 
0066B9EB4  ldr      x8, [x2, #0x60]
0066B9EB8  mov      w1, #0x3d
0066B9EBC  mov      x0, x19
0066B9EC0  blr      x8
0066B9EC4  tbz      w0, #0, #0x66ba088
0066B9EC8  adrp     x8, #0x9591000
0066B9ECC  ldrb     w8, [x8, #0xa4b]
0066B9ED0  cbnz     w8, #0x66b9eec
0066B9ED4  adrp     x0, #0x8ee5000
0066B9ED8  ldr      x0, [x0, #0xb28]
0066B9EDC  bl       #0x382bd14 ; 
0066B9EE0  mov      w8, #1
0066B9EE4  adrp     x9, #0x9591000
0066B9EE8  strb     w8, [x9, #0xa4b]
0066B9EEC  adrp     x8, #0x8ee5000
0066B9EF0  ldr      x8, [x8, #0xb28]
0066B9EF4  ldr      x1, [x8]
0066B9EF8  ldrb     w8, [x1, #0x53]
0066B9EFC  tbnz     w8, #5, #0x66b9f08
0066B9F00  ldr      x20, [x21, #0x20]
0066B9F04  b        #0x66b9f18 ; 
0066B9F08  ldr      x8, [x1, #0x60]
0066B9F0C  mov      x0, x21
0066B9F10  blr      x8
0066B9F14  mov      x20, x0
0066B9F18  cbz      x20, #0x66ba74c
0066B9F1C  adrp     x24, #0x9591000
0066B9F20  ldrb     w8, [x24, #0xa4c]
0066B9F24  cbnz     w8, #0x66b9f3c
0066B9F28  adrp     x0, #0x8ee5000
0066B9F2C  ldr      x0, [x0, #0xb30]
0066B9F30  bl       #0x382bd14 ; 
0066B9F34  mov      w8, #1
0066B9F38  strb     w8, [x24, #0xa4c]
0066B9F3C  adrp     x8, #0x8ee5000
0066B9F40  ldr      x8, [x8, #0xb30]
0066B9F44  ldr      x1, [x8]
0066B9F48  ldrb     w8, [x1, #0x53]
0066B9F4C  tbnz     w8, #5, #0x66b9f58
0066B9F50  ldr      x0, [x20, #0x210]
0066B9F54  b        #0x66b9f64 ; 
0066B9F58  ldr      x8, [x1, #0x60]
0066B9F5C  mov      x0, x20
0066B9F60  blr      x8
0066B9F64  cbz      x0, #0x66ba754
0066B9F68  adrp     x8, #0x8f11000
0066B9F6C  ldr      x8, [x8, #0xa50]
0066B9F70  ldr      x1, [x8]
0066B9F74  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066B9F78  ldr      x8, [x22, #0x10]
0066B9F7C  ldr      q0, [x22]
0066B9F80  mov      x24, x0
0066B9F84  str      x8, [sp, #0x30]
0066B9F88  str      q0, [sp, #0x20]
0066B9F8C  cbz      x0, #0x66ba75c
0066B9F90  ldr      q0, [sp, #0x20]
0066B9F94  ldr      x9, [sp, #0x30]
0066B9F98  ldr      x8, [sp, #0x18]
0066B9F9C  str      q0, [x24, #0x20]
0066B9FA0  stp      x9, x8, [x24, #0x30]
0066B9FA4  adrp     x8, #0x8ee6000
0066B9FA8  ldr      x8, [x8, #0xe8]
0066B9FAC  ldr      x1, [x8]
0066B9FB0  ldrb     w8, [x1, #0x53]
0066B9FB4  tbnz     w8, #5, #0x66b9fc0
0066B9FB8  ldr      x0, [x19, #0x28]
0066B9FBC  b        #0x66b9fcc ; 
0066B9FC0  ldr      x8, [x1, #0x60]
0066B9FC4  mov      x0, x19
0066B9FC8  blr      x8
0066B9FCC  str      x0, [x24, #0x40]
0066B9FD0  adrp     x8, #0x8ee6000
0066B9FD4  ldr      x8, [x8, #0x608]
0066B9FD8  ldr      x1, [x8]
0066B9FDC  ldrb     w8, [x1, #0x53]
0066B9FE0  tbnz     w8, #5, #0x66b9fec
0066B9FE4  ldr      x0, [x21, #0x30]
0066B9FE8  b        #0x66b9ff8 ; 
0066B9FEC  ldr      x8, [x1, #0x60]
0066B9FF0  mov      x0, x21
0066B9FF4  blr      x8
0066B9FF8  cbz      x0, #0x66ba760
0066B9FFC  adrp     x8, #0x8ee6000
0066BA000  ldr      x8, [x8, #0xe8]
0066BA004  ldr      x1, [x8]
0066BA008  ldrb     w8, [x1, #0x53]
0066BA00C  tbnz     w8, #5, #0x66ba018
0066BA010  ldr      x0, [x0, #0x28]
0066BA014  b        #0x66ba020 ; 
0066BA018  ldr      x8, [x1, #0x60]
0066BA01C  blr      x8
0066BA020  str      x0, [x24, #0x48]
0066BA024  adrp     x8, #0x9591000
0066BA028  ldrb     w8, [x8, #0xa85]
0066BA02C  cbnz     w8, #0x66ba048
0066BA030  adrp     x0, #0x8ee6000
0066BA034  ldr      x0, [x0, #0x310]
0066BA038  bl       #0x382bd14 ; 
0066BA03C  mov      w8, #1
0066BA040  adrp     x9, #0x9591000
0066BA044  strb     w8, [x9, #0xa85]
0066BA048  adrp     x8, #0x8ee6000
0066BA04C  ldr      x8, [x8, #0x310]
0066BA050  ldr      x1, [x8]
0066BA054  ldrb     w8, [x1, #0x53]
0066BA058  tbnz     w8, #5, #0x66ba064
0066BA05C  ldr      w0, [x23, #0xb8]
0066BA060  b        #0x66ba070 ; 
0066BA064  ldr      x8, [x1, #0x60]
0066BA068  mov      x0, x23
0066BA06C  blr      x8
0066BA070  str      w0, [x24, #0x50]
0066BA074  ldr      x0, [x19, #0x150]
0066BA078  cbz      x0, #0x66ba768
0066BA07C  mov      x1, x24
0066BA080  mov      x2, xzr
0066BA084  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BA088  ldrb     w8, [x26, #0xa86]
0066BA08C  cbnz     w8, #0x66ba0b0
0066BA090  adrp     x0, #0x8ee6000
0066BA094  ldr      x0, [x0, #0x318]
0066BA098  bl       #0x382bd14 ; 
0066BA09C  adrp     x0, #0x8ee3000
0066BA0A0  ldr      x0, [x0, #0xf18]
0066BA0A4  bl       #0x382bd14 ; 
0066BA0A8  mov      w8, #1
0066BA0AC  strb     w8, [x26, #0xa86]
0066BA0B0  ldr      x2, [x27]
0066BA0B4  ldrb     w8, [x2, #0x53]
0066BA0B8  tbnz     w8, #5, #0x66ba0dc
0066BA0BC  ldr      x0, [x19, #0x190]
0066BA0C0  cbz      x0, #0x66ba2c8
0066BA0C4  adrp     x8, #0x8ee3000
0066BA0C8  ldr      x8, [x8, #0xf18]
0066BA0CC  ldr      x2, [x8]
0066BA0D0  mov      w1, #0x1a
0066BA0D4  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066BA0D8  b        #0x66ba0ec ; 
0066BA0DC  ldr      x8, [x2, #0x60]
0066BA0E0  mov      w1, #0x1a
0066BA0E4  mov      x0, x19
0066BA0E8  blr      x8
0066BA0EC  tbz      w0, #0, #0x66ba2c8
0066BA0F0  adrp     x8, #0x9591000
0066BA0F4  ldrb     w8, [x8, #0xa85]
0066BA0F8  cbnz     w8, #0x66ba114
0066BA0FC  adrp     x0, #0x8ee6000
0066BA100  ldr      x0, [x0, #0x310]
0066BA104  bl       #0x382bd14 ; 
0066BA108  mov      w8, #1
0066BA10C  adrp     x9, #0x9591000
0066BA110  strb     w8, [x9, #0xa85]
0066BA114  adrp     x8, #0x8ee6000
0066BA118  ldr      x8, [x8, #0x310]
0066BA11C  ldr      x1, [x8]
0066BA120  ldrb     w8, [x1, #0x53]
0066BA124  tbnz     w8, #5, #0x66ba130
0066BA128  ldr      w24, [x23, #0xb8]
0066BA12C  b        #0x66ba140 ; 
0066BA130  ldr      x8, [x1, #0x60]
0066BA134  mov      x0, x23
0066BA138  blr      x8
0066BA13C  mov      w24, w0
0066BA140  mov      x0, x19
0066BA144  mov      w1, w24
0066BA148  mov      x2, xzr
0066BA14C  bl       #0x67edea8 ; HotFix.BattleLogic.EntityCharacter$$IncrementSkillHitCount
0066BA150  adrp     x8, #0x9591000
0066BA154  ldrb     w8, [x8, #0xa4b]
0066BA158  mov      x25, x0
0066BA15C  cbnz     w8, #0x66ba178
0066BA160  adrp     x0, #0x8ee5000
0066BA164  ldr      x0, [x0, #0xb28]
0066BA168  bl       #0x382bd14 ; 
0066BA16C  mov      w8, #1
0066BA170  adrp     x9, #0x9591000
0066BA174  strb     w8, [x9, #0xa4b]
0066BA178  adrp     x8, #0x8ee5000
0066BA17C  ldr      x8, [x8, #0xb28]
0066BA180  ldr      x1, [x8]
0066BA184  ldrb     w8, [x1, #0x53]
0066BA188  tbnz     w8, #5, #0x66ba194
0066BA18C  ldr      x20, [x21, #0x20]
0066BA190  b        #0x66ba1a4 ; 
0066BA194  ldr      x8, [x1, #0x60]
0066BA198  mov      x0, x21
0066BA19C  blr      x8
0066BA1A0  mov      x20, x0
0066BA1A4  cbz      x20, #0x66ba764
0066BA1A8  adrp     x28, #0x9591000
0066BA1AC  ldrb     w8, [x28, #0xa4c]
0066BA1B0  cbnz     w8, #0x66ba1c8
0066BA1B4  adrp     x0, #0x8ee5000
0066BA1B8  ldr      x0, [x0, #0xb30]
0066BA1BC  bl       #0x382bd14 ; 
0066BA1C0  mov      w8, #1
0066BA1C4  strb     w8, [x28, #0xa4c]
0066BA1C8  adrp     x8, #0x8ee5000
0066BA1CC  ldr      x8, [x8, #0xb30]
0066BA1D0  ldr      x1, [x8]
0066BA1D4  ldrb     w8, [x1, #0x53]
0066BA1D8  tbnz     w8, #5, #0x66ba1e4
0066BA1DC  ldr      x0, [x20, #0x210]
0066BA1E0  b        #0x66ba1f0 ; 
0066BA1E4  ldr      x8, [x1, #0x60]
0066BA1E8  mov      x0, x20
0066BA1EC  blr      x8
0066BA1F0  cbz      x0, #0x66ba76c
0066BA1F4  adrp     x8, #0x8f11000
0066BA1F8  ldr      x8, [x8, #0xa60]
0066BA1FC  ldr      x1, [x8]
0066BA200  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BA204  ldr      x8, [x22, #0x10]
0066BA208  ldr      q0, [x22]
0066BA20C  mov      x20, x0
0066BA210  str      x8, [sp, #0x30]
0066BA214  str      q0, [sp, #0x20]
0066BA218  cbz      x0, #0x66ba770
0066BA21C  ldr      q0, [sp, #0x20]
0066BA220  ldr      x9, [sp, #0x30]
0066BA224  ldr      x8, [sp, #0x18]
0066BA228  str      q0, [x20, #0x20]
0066BA22C  stp      x9, x8, [x20, #0x30]
0066BA230  adrp     x8, #0x8ee6000
0066BA234  ldr      x8, [x8, #0xe8]
0066BA238  ldr      x1, [x8]
0066BA23C  ldrb     w8, [x1, #0x53]
0066BA240  tbnz     w8, #5, #0x66ba24c
0066BA244  ldr      x0, [x19, #0x28]
0066BA248  b        #0x66ba258 ; 
0066BA24C  ldr      x8, [x1, #0x60]
0066BA250  mov      x0, x19
0066BA254  blr      x8
0066BA258  str      x0, [x20, #0x40]
0066BA25C  adrp     x8, #0x8ee6000
0066BA260  ldr      x8, [x8, #0x608]
0066BA264  ldr      x1, [x8]
0066BA268  ldrb     w8, [x1, #0x53]
0066BA26C  tbnz     w8, #5, #0x66ba278
0066BA270  ldr      x0, [x21, #0x30]
0066BA274  b        #0x66ba284 ; 
0066BA278  ldr      x8, [x1, #0x60]
0066BA27C  mov      x0, x21
0066BA280  blr      x8
0066BA284  cbz      x0, #0x66ba778
0066BA288  adrp     x8, #0x8ee6000
0066BA28C  ldr      x8, [x8, #0xe8]
0066BA290  ldr      x1, [x8]
0066BA294  ldrb     w8, [x1, #0x53]
0066BA298  tbnz     w8, #5, #0x66ba2a4
0066BA29C  ldr      x0, [x0, #0x28]
0066BA2A0  b        #0x66ba2ac ; 
0066BA2A4  ldr      x8, [x1, #0x60]
0066BA2A8  blr      x8
0066BA2AC  stp      x0, x25, [x20, #0x48]
0066BA2B0  str      w24, [x20, #0x58]
0066BA2B4  ldr      x0, [x19, #0x150]
0066BA2B8  cbz      x0, #0x66ba77c
0066BA2BC  mov      x1, x20
0066BA2C0  mov      x2, xzr
0066BA2C4  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BA2C8  ldrb     w8, [x26, #0xa86]
0066BA2CC  cbnz     w8, #0x66ba2f0
0066BA2D0  adrp     x0, #0x8ee6000
0066BA2D4  ldr      x0, [x0, #0x318]
0066BA2D8  bl       #0x382bd14 ; 
0066BA2DC  adrp     x0, #0x8ee3000
0066BA2E0  ldr      x0, [x0, #0xf18]
0066BA2E4  bl       #0x382bd14 ; 
0066BA2E8  mov      w8, #1
0066BA2EC  strb     w8, [x26, #0xa86]
0066BA2F0  ldr      x2, [x27]
0066BA2F4  ldrb     w8, [x2, #0x53]
0066BA2F8  tbnz     w8, #5, #0x66ba31c
0066BA2FC  ldr      x0, [x19, #0x190]
0066BA300  cbz      x0, #0x66ba6e8
0066BA304  adrp     x8, #0x8ee3000
0066BA308  ldr      x8, [x8, #0xf18]
0066BA30C  ldr      x2, [x8]
0066BA310  mov      w1, #0x1f
0066BA314  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066BA318  b        #0x66ba32c ; 
0066BA31C  ldr      x8, [x2, #0x60]
0066BA320  mov      w1, #0x1f
0066BA324  mov      x0, x19
0066BA328  blr      x8
0066BA32C  tbz      w0, #0, #0x66ba6e8
0066BA330  adrp     x8, #0x9591000
0066BA334  ldrb     w8, [x8, #0xa85]
0066BA338  cbnz     w8, #0x66ba354
0066BA33C  adrp     x0, #0x8ee6000
0066BA340  ldr      x0, [x0, #0x310]
0066BA344  bl       #0x382bd14 ; 
0066BA348  mov      w8, #1
0066BA34C  adrp     x9, #0x9591000
0066BA350  strb     w8, [x9, #0xa85]
0066BA354  adrp     x8, #0x8ee6000
0066BA358  ldr      x8, [x8, #0x310]
0066BA35C  ldr      x1, [x8]
0066BA360  ldrb     w8, [x1, #0x53]
0066BA364  tbnz     w8, #5, #0x66ba370
0066BA368  ldr      w23, [x23, #0xb8]
0066BA36C  b        #0x66ba380 ; 
0066BA370  ldr      x8, [x1, #0x60]
0066BA374  mov      x0, x23
0066BA378  blr      x8
0066BA37C  mov      w23, w0
0066BA380  adrp     x8, #0x8ee6000
0066BA384  ldr      x8, [x8, #0x608]
0066BA388  ldr      x1, [x8]
0066BA38C  ldrb     w8, [x1, #0x53]
0066BA390  tbnz     w8, #5, #0x66ba39c
0066BA394  ldr      x0, [x21, #0x30]
0066BA398  b        #0x66ba3a8 ; 
0066BA39C  ldr      x8, [x1, #0x60]
0066BA3A0  mov      x0, x21
0066BA3A4  blr      x8
0066BA3A8  cbz      x0, #0x66ba774
0066BA3AC  adrp     x8, #0x8eea000
0066BA3B0  ldr      x8, [x8, #0xf00]
0066BA3B4  ldr      x1, [x8]
0066BA3B8  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0066BA3BC  adrp     x8, #0x9591000
0066BA3C0  ldrb     w8, [x8, #0xa4b]
0066BA3C4  mov      x25, x0
0066BA3C8  cbnz     w8, #0x66ba3e4
0066BA3CC  adrp     x0, #0x8ee5000
0066BA3D0  ldr      x0, [x0, #0xb28]
0066BA3D4  bl       #0x382bd14 ; 
0066BA3D8  mov      w8, #1
0066BA3DC  adrp     x9, #0x9591000
0066BA3E0  strb     w8, [x9, #0xa4b]
0066BA3E4  adrp     x8, #0x8ee5000
0066BA3E8  ldr      x8, [x8, #0xb28]
0066BA3EC  ldr      x1, [x8]
0066BA3F0  ldrb     w8, [x1, #0x53]
0066BA3F4  tbnz     w8, #5, #0x66ba400
0066BA3F8  ldr      x20, [x21, #0x20]
0066BA3FC  b        #0x66ba410 ; 
0066BA400  ldr      x8, [x1, #0x60]
0066BA404  mov      x0, x21
0066BA408  blr      x8
0066BA40C  mov      x20, x0
0066BA410  cbz      x20, #0x66ba780
0066BA414  adrp     x24, #0x9591000
0066BA418  ldrb     w8, [x24, #0xa90]
0066BA41C  cbnz     w8, #0x66ba434
0066BA420  adrp     x0, #0x8ee6000
0066BA424  ldr      x0, [x0, #0x3e0]
0066BA428  bl       #0x382bd14 ; 
0066BA42C  mov      w8, #1
0066BA430  strb     w8, [x24, #0xa90]
0066BA434  adrp     x8, #0x8ee6000
0066BA438  ldr      x8, [x8, #0x3e0]
0066BA43C  ldr      x1, [x8]
0066BA440  ldrb     w8, [x1, #0x53]
0066BA444  tbnz     w8, #5, #0x66ba450
0066BA448  ldr      x0, [x20, #0x230]
0066BA44C  b        #0x66ba45c ; 
0066BA450  ldr      x8, [x1, #0x60]
0066BA454  mov      x0, x20
0066BA458  blr      x8
0066BA45C  cbz      x0, #0x66ba784
0066BA460  adrp     x8, #0x8f08000
0066BA464  ldr      x8, [x8, #0xbb8]
0066BA468  ldr      x1, [x8]
0066BA46C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
0066BA470  mov      x24, x0
0066BA474  cbz      x25, #0x66ba4fc
0066BA478  adrp     x26, #0x8ec2000
0066BA47C  ldr      x26, [x26, #0x260]
0066BA480  mov      w20, wzr
0066BA484  mov      x0, x25
0066BA488  mov      w1, w20
0066BA48C  mov      x2, xzr
0066BA490  bl       #0x6694280 ; HotFix.BattleLogic.CharacterComponentBuff$$CheckBuffFLag
0066BA494  tbz      w0, #0, #0x66ba4f0
0066BA498  cbz      x24, #0x66ba718
0066BA49C  ldr      w10, [x24, #0x1c]
0066BA4A0  ldr      x8, [x24, #0x10]
0066BA4A4  ldr      x9, [x26]
0066BA4A8  add      w10, w10, #1
0066BA4AC  str      w10, [x24, #0x1c]
0066BA4B0  cbz      x8, #0x66ba71c
0066BA4B4  ldrsw    x10, [x24, #0x18]
0066BA4B8  ldr      w11, [x8, #0x18]
0066BA4BC  cmp      w10, w11
0066BA4C0  b.hs     #0x66ba4d8
0066BA4C4  add      w9, w10, #1
0066BA4C8  add      x8, x8, x10, lsl #2
0066BA4CC  str      w9, [x24, #0x18]
0066BA4D0  str      w20, [x8, #0x20]
0066BA4D4  b        #0x66ba4f0 ; 
0066BA4D8  ldr      x8, [x9, #0x20]
0066BA4DC  ldr      x8, [x8, #0xc0]
0066BA4E0  ldr      x2, [x8, #0x70]
0066BA4E4  mov      x0, x24
0066BA4E8  mov      w1, w20
0066BA4EC  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0066BA4F0  add      w20, w20, #1
0066BA4F4  cmp      w20, #8
0066BA4F8  b.ne     #0x66ba484
0066BA4FC  adrp     x8, #0x9591000
0066BA500  ldrb     w8, [x8, #0xa4b]
0066BA504  cbnz     w8, #0x66ba520
0066BA508  adrp     x0, #0x8ee5000
0066BA50C  ldr      x0, [x0, #0xb28]
0066BA510  bl       #0x382bd14 ; 
0066BA514  mov      w8, #1
0066BA518  adrp     x9, #0x9591000
0066BA51C  strb     w8, [x9, #0xa4b]
0066BA520  adrp     x8, #0x8ee5000
0066BA524  ldr      x8, [x8, #0xb28]
0066BA528  ldr      x1, [x8]
0066BA52C  ldrb     w8, [x1, #0x53]
0066BA530  tbnz     w8, #5, #0x66ba53c
0066BA534  ldr      x20, [x21, #0x20]
0066BA538  b        #0x66ba54c ; 
0066BA53C  ldr      x8, [x1, #0x60]
0066BA540  mov      x0, x21
0066BA544  blr      x8
0066BA548  mov      x20, x0
0066BA54C  cbz      x20, #0x66ba788
0066BA550  adrp     x25, #0x9591000
0066BA554  ldrb     w8, [x25, #0xa4c]
0066BA558  cbnz     w8, #0x66ba570
0066BA55C  adrp     x0, #0x8ee5000
0066BA560  ldr      x0, [x0, #0xb30]
0066BA564  bl       #0x382bd14 ; 
0066BA568  mov      w8, #1
0066BA56C  strb     w8, [x25, #0xa4c]
0066BA570  adrp     x8, #0x8ee5000
0066BA574  ldr      x8, [x8, #0xb30]
0066BA578  ldr      x1, [x8]
0066BA57C  ldrb     w8, [x1, #0x53]
0066BA580  tbnz     w8, #5, #0x66ba58c
0066BA584  ldr      x0, [x20, #0x210]
0066BA588  b        #0x66ba598 ; 
0066BA58C  ldr      x8, [x1, #0x60]
0066BA590  mov      x0, x20
0066BA594  blr      x8
0066BA598  cbz      x0, #0x66ba78c
0066BA59C  adrp     x8, #0x8f11000
0066BA5A0  ldr      x8, [x8, #0xa48]
0066BA5A4  ldr      x1, [x8]
0066BA5A8  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BA5AC  ldr      x8, [x22, #0x10]
0066BA5B0  ldr      q0, [x22]
0066BA5B4  mov      x25, x0
0066BA5B8  str      x8, [sp, #0x30]
0066BA5BC  str      q0, [sp, #0x20]
0066BA5C0  cbz      x0, #0x66ba790
0066BA5C4  ldr      q0, [sp, #0x20]
0066BA5C8  ldr      x9, [sp, #0x30]
0066BA5CC  ldr      x8, [sp, #0x18]
0066BA5D0  adrp     x20, #0x8ee6000
0066BA5D4  str      q0, [x25, #0x20]
0066BA5D8  stp      x9, x8, [x25, #0x30]
0066BA5DC  ldr      x20, [x20, #0xe8]
0066BA5E0  ldr      x1, [x20]
0066BA5E4  ldrb     w8, [x1, #0x53]
0066BA5E8  tbnz     w8, #5, #0x66ba5f4
0066BA5EC  ldr      x0, [x19, #0x28]
0066BA5F0  b        #0x66ba600 ; 
0066BA5F4  ldr      x8, [x1, #0x60]
0066BA5F8  mov      x0, x19
0066BA5FC  blr      x8
0066BA600  str      x0, [x25, #0x40]
0066BA604  adrp     x8, #0x8ee6000
0066BA608  ldr      x8, [x8, #0x608]
0066BA60C  ldr      x1, [x8]
0066BA610  ldrb     w8, [x1, #0x53]
0066BA614  tbnz     w8, #5, #0x66ba620
0066BA618  ldr      x0, [x21, #0x30]
0066BA61C  b        #0x66ba62c ; 
0066BA620  ldr      x8, [x1, #0x60]
0066BA624  mov      x0, x21
0066BA628  blr      x8
0066BA62C  cbz      x0, #0x66ba794
0066BA630  ldr      x1, [x20]
0066BA634  ldrb     w8, [x1, #0x53]
0066BA638  tbnz     w8, #5, #0x66ba644
0066BA63C  ldr      x0, [x0, #0x28]
0066BA640  b        #0x66ba64c ; 
0066BA644  ldr      x8, [x1, #0x60]
0066BA648  blr      x8
0066BA64C  ldr      x8, [sp, #8]
0066BA650  str      x0, [x25, #0x48]
0066BA654  str      w23, [x25, #0x50]
0066BA658  cbz      x8, #0x66ba798
0066BA65C  adrp     x8, #0x8ee6000
0066BA660  ldr      x8, [x8, #0xf0]
0066BA664  ldr      x1, [x8]
0066BA668  ldrb     w8, [x1, #0x53]
0066BA66C  tbnz     w8, #5, #0x66ba67c
0066BA670  ldr      x8, [sp, #8]
0066BA674  ldr      x0, [x8, #0x28]
0066BA678  b        #0x66ba688 ; 
0066BA67C  ldr      x8, [x1, #0x60]
0066BA680  ldr      x0, [sp, #8]
0066BA684  blr      x8
0066BA688  str      x0, [x25, #0x60]
0066BA68C  cbz      x24, #0x66ba79c
0066BA690  ldr      w8, [x24, #0x18]
0066BA694  cmp      w8, #0
0066BA698  b.le     #0x66ba6b8
0066BA69C  adrp     x8, #0x8eea000
0066BA6A0  ldr      x8, [x8, #0xf18]
0066BA6A4  ldr      x1, [x8]
0066BA6A8  mov      x0, x24
0066BA6AC  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
0066BA6B0  mov      x1, x0
0066BA6B4  b        #0x66ba6bc ; 
0066BA6B8  mov      x1, xzr
0066BA6BC  mov      x0, x25
0066BA6C0  str      x1, [x0, #0x58]!
0066BA6C4  bl       #0x382bcb8 ; 
0066BA6C8  ldr      x0, [x19, #0x150]
0066BA6CC  cbz      x0, #0x66ba7a0
0066BA6D0  mov      x1, x25
0066BA6D4  mov      x2, xzr
0066BA6D8  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BA6DC  ldr      w8, [x24, #0x1c]
0066BA6E0  add      w8, w8, #1
0066BA6E4  stp      wzr, w8, [x24, #0x18]
0066BA6E8  ldr      x8, [x29, #0x28]
0066BA6EC  ldr      x9, [sp, #0x58]
0066BA6F0  cmp      x8, x9
0066BA6F4  b.ne     #0x66ba7a4
0066BA6F8  ldp      x20, x19, [sp, #0xb0]
0066BA6FC  ldp      x22, x21, [sp, #0xa0]
0066BA700  ldp      x24, x23, [sp, #0x90]
0066BA704  ldp      x26, x25, [sp, #0x80]
0066BA708  ldp      x28, x27, [sp, #0x70]
0066BA70C  ldp      x29, x30, [sp, #0x60]
0066BA710  add      sp, sp, #0xc0
0066BA714  ret      
0066BA718  bl       #0x382bfb8 ; 
0066BA71C  bl       #0x382bfb8 ; 
0066BA720  bl       #0x382bfb8 ; 
0066BA724  bl       #0x382bfb8 ; 
0066BA728  bl       #0x382bfb8 ; 
0066BA72C  bl       #0x382bfb8 ; 
0066BA730  bl       #0x382bfb8 ; 
0066BA734  bl       #0x382bfb8 ; 
0066BA738  bl       #0x382bfb8 ; 
0066BA73C  bl       #0x382bfb8 ; 
0066BA740  bl       #0x382bfb8 ; 
0066BA744  bl       #0x382bfb8 ; 
0066BA748  bl       #0x382bfb8 ; 
0066BA74C  bl       #0x382bfb8 ; 
0066BA750  bl       #0x382bfb8 ; 
0066BA754  bl       #0x382bfb8 ; 
0066BA758  bl       #0x382bfb8 ; 
0066BA75C  bl       #0x382bfb8 ; 
0066BA760  bl       #0x382bfb8 ; 
0066BA764  bl       #0x382bfb8 ; 
0066BA768  bl       #0x382bfb8 ; 
0066BA76C  bl       #0x382bfb8 ; 
0066BA770  bl       #0x382bfb8 ; 
0066BA774  bl       #0x382bfb8 ; 
0066BA778  bl       #0x382bfb8 ; 
0066BA77C  bl       #0x382bfb8 ; 
0066BA780  bl       #0x382bfb8 ; 
0066BA784  bl       #0x382bfb8 ; 
0066BA788  bl       #0x382bfb8 ; 
0066BA78C  bl       #0x382bfb8 ; 
0066BA790  bl       #0x382bfb8 ; 
0066BA794  bl       #0x382bfb8 ; 
0066BA798  bl       #0x382bfb8 ; 
0066BA79C  bl       #0x382bfb8 ; 
0066BA7A0  bl       #0x382bfb8 ; 
0066BA7A4  bl       #0x89edb60 ; 
0066BA7A8  b        #0x66ba8f0 ; 
0066BA7AC  b        #0x66ba8f0 ; 
0066BA7B0  b        #0x66ba8f0 ; 
0066BA7B4  b        #0x66ba8f0 ; 
0066BA7B8  b        #0x66ba8f0 ; 
0066BA7BC  b        #0x66ba8f0 ; 
0066BA7C0  b        #0x66ba8f0 ; 
0066BA7C4  b        #0x66ba8f0 ; 
0066BA7C8  b        #0x66ba8f0 ; 
0066BA7CC  b        #0x66ba8f0 ; 
0066BA7D0  b        #0x66ba8f0 ; 
0066BA7D4  b        #0x66ba8f0 ; 
0066BA7D8  b        #0x66ba8f0 ; 
0066BA7DC  b        #0x66ba8f0 ; 
0066BA7E0  b        #0x66ba8f0 ; 
0066BA7E4  b        #0x66ba8f0 ; 
0066BA7E8  b        #0x66ba8f0 ; 
0066BA7EC  b        #0x66ba8f0 ; 
0066BA7F0  b        #0x66ba8f0 ; 
0066BA7F4  b        #0x66ba8f0 ; 
0066BA7F8  b        #0x66ba8f0 ; 
0066BA7FC  b        #0x66ba8f0 ; 
0066BA800  b        #0x66ba8f0 ; 
0066BA804  b        #0x66ba8f0 ; 
0066BA808  b        #0x66ba8f0 ; 
0066BA80C  b        #0x66ba8f0 ; 
0066BA810  b        #0x66ba8f0 ; 
0066BA814  b        #0x66ba8f0 ; 
0066BA818  b        #0x66ba8f0 ; 
0066BA81C  b        #0x66ba8f0 ; 
0066BA820  b        #0x66ba8f0 ; 
0066BA824  b        #0x66ba8f0 ; 
0066BA828  b        #0x66ba8f0 ; 
0066BA82C  b        #0x66ba8f0 ; 
0066BA830  b        #0x66ba8f0 ; 
0066BA834  b        #0x66ba8f0 ; 
0066BA838  b        #0x66ba8f0 ; 
0066BA83C  b        #0x66ba8f0 ; 
0066BA840  b        #0x66ba8f0 ; 
0066BA844  b        #0x66ba8f0 ; 
0066BA848  b        #0x66ba8f0 ; 
0066BA84C  b        #0x66ba8f0 ; 
0066BA850  b        #0x66ba8f0 ; 
0066BA854  b        #0x66ba8f0 ; 
0066BA858  b        #0x66ba8f0 ; 
0066BA85C  b        #0x66ba8f0 ; 
0066BA860  b        #0x66ba8f0 ; 
0066BA864  b        #0x66ba8f0 ; 
0066BA868  b        #0x66ba8f0 ; 
0066BA86C  b        #0x66ba8f0 ; 
0066BA870  b        #0x66ba8f0 ; 
0066BA874  b        #0x66ba8f0 ; 
0066BA878  b        #0x66ba8f0 ; 
0066BA87C  b        #0x66ba8f0 ; 
0066BA880  b        #0x66ba8f0 ; 
0066BA884  b        #0x66ba8f0 ; 
0066BA888  b        #0x66ba8f0 ; 
0066BA88C  b        #0x66ba8f0 ; 
0066BA890  b        #0x66ba8f0 ; 
0066BA894  b        #0x66ba8f0 ; 
0066BA898  b        #0x66ba8f0 ; 
0066BA89C  b        #0x66ba8f0 ; 
0066BA8A0  b        #0x66ba8f0 ; 
0066BA8A4  b        #0x66ba8f0 ; 
0066BA8A8  b        #0x66ba8f0 ; 
0066BA8AC  b        #0x66ba8f0 ; 
0066BA8B0  b        #0x66ba8f0 ; 
0066BA8B4  b        #0x66ba8f0 ; 
0066BA8B8  b        #0x66ba8f0 ; 
0066BA8BC  b        #0x66ba8f0 ; 
0066BA8C0  b        #0x66ba8f0 ; 
0066BA8C4  b        #0x66ba8f0 ; 
0066BA8C8  b        #0x66ba8f0 ; 
0066BA8CC  b        #0x66ba8f0 ; 
0066BA8D0  b        #0x66ba8f0 ; 
0066BA8D4  b        #0x66ba8f0 ; 
0066BA8D8  b        #0x66ba8f0 ; 
0066BA8DC  b        #0x66ba8f0 ; 
0066BA8E0  b        #0x66ba8f0 ; 
0066BA8E4  b        #0x66ba8f0 ; 
0066BA8E8  b        #0x66ba8f0 ; 
0066BA8EC  b        #0x66ba8f0 ; 
0066BA8F0  cmp      w1, #1
0066BA8F4  b.ne     #0x66ba918
0066BA8F8  bl       #0x89eda50 ; 
0066BA8FC  ldr      x19, [x0]
0066BA900  bl       #0x89eda60 ; 
0066BA904  ldr      x29, [sp, #0x10]
0066BA908  cbz      x19, #0x66ba6e8
0066BA90C  mov      x0, x19
0066BA910  bl       #0x382bfb0 ; 
0066BA914  cbnz     x19, #0x66ba91c
0066BA918  bl       #0x3b56bfc ; 
0066BA91C  mov      x0, x19
0066BA920  bl       #0x382bfb0 ; 
0066BA924  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$IsSameEnemyMilestoneExplosionHit
; RVA 0x66BBAD0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BBAD0  sub      sp, sp, #0x50
0066BBAD4  stp      x30, x25, [sp, #0x10]
0066BBAD8  stp      x24, x23, [sp, #0x20]
0066BBADC  stp      x22, x21, [sp, #0x30]
0066BBAE0  stp      x20, x19, [sp, #0x40]
0066BBAE4  adrp     x24, #0x959a000
0066BBAE8  adrp     x25, #0x8f11000
0066BBAEC  ldrb     w8, [x24, #0x20b]
0066BBAF0  ldr      x25, [x25, #0xaa8]
0066BBAF4  mov      x22, x4
0066BBAF8  mov      w19, w3
0066BBAFC  mov      x20, x2
0066BBB00  mov      x21, x1
0066BBB04  mov      x23, x0
0066BBB08  tbnz     w8, #0, #0x66bbb20
0066BBB0C  adrp     x0, #0x8f11000
0066BBB10  ldr      x0, [x0, #0xaa8]
0066BBB14  bl       #0x382bd14 ; 
0066BBB18  mov      w8, #1
0066BBB1C  strb     w8, [x24, #0x20b]
0066BBB20  ldr      x5, [x25]
0066BBB24  ldrb     w8, [x5, #0x53]
0066BBB28  tbnz     w8, #5, #0x66bbb88
0066BBB2C  mov      w0, wzr
0066BBB30  str      xzr, [sp, #8]
0066BBB34  cbz      x21, #0x66bbbbc
0066BBB38  cmp      w19, #1
0066BBB3C  b.lt     #0x66bbbbc
0066BBB40  cbz      x22, #0x66bbbbc
0066BBB44  mov      w1, #8
0066BBB48  mov      x0, x22
0066BBB4C  mov      x2, xzr
0066BBB50  bl       #0x6681fc4 ; HotFix.BattleLogic.EntityBullet$$HaveBulletFlag
0066BBB54  tbz      w0, #0, #0x66bbbb8
0066BBB58  add      x2, sp, #8
0066BBB5C  mov      x0, x21
0066BBB60  mov      x1, x20
0066BBB64  mov      x3, xzr
0066BBB68  bl       #0x67f1990 ; HotFix.BattleLogic.EntityCharacter$$TryGetSameEnemyMilestoneExplosionConfig
0066BBB6C  tbz      w0, #0, #0x66bbbb8
0066BBB70  ldr      x8, [sp, #8]
0066BBB74  cbz      x8, #0x66bbbd4
0066BBB78  ldr      w8, [x8, #0x14]
0066BBB7C  cmp      w8, w19
0066BBB80  cset     w0, eq
0066BBB84  b        #0x66bbbbc ; 
0066BBB88  ldr      x6, [x5, #0x60]
0066BBB8C  mov      x0, x23
0066BBB90  mov      x1, x21
0066BBB94  mov      x2, x20
0066BBB98  mov      w3, w19
0066BBB9C  mov      x4, x22
0066BBBA0  ldp      x20, x19, [sp, #0x40]
0066BBBA4  ldp      x22, x21, [sp, #0x30]
0066BBBA8  ldp      x24, x23, [sp, #0x20]
0066BBBAC  ldp      x30, x25, [sp, #0x10]
0066BBBB0  add      sp, sp, #0x50
0066BBBB4  br       x6
0066BBBB8  mov      w0, wzr
0066BBBBC  ldp      x20, x19, [sp, #0x40]
0066BBBC0  ldp      x22, x21, [sp, #0x30]
0066BBBC4  ldp      x24, x23, [sp, #0x20]
0066BBBC8  ldp      x30, x25, [sp, #0x10]
0066BBBCC  add      sp, sp, #0x50
0066BBBD0  ret      
0066BBBD4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$TryFireSameEnemyMilestoneExplosion
; RVA 0x66BC4C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BC4C8  sub      sp, sp, #0x180
0066BC4CC  stp      x29, x30, [sp, #0x120]
0066BC4D0  stp      x28, x27, [sp, #0x130]
0066BC4D4  stp      x26, x25, [sp, #0x140]
0066BC4D8  stp      x24, x23, [sp, #0x150]
0066BC4DC  stp      x22, x21, [sp, #0x160]
0066BC4E0  stp      x20, x19, [sp, #0x170]
0066BC4E4  mrs      x26, tpidr_el0
0066BC4E8  ldr      x8, [x26, #0x28]
0066BC4EC  adrp     x28, #0x959a000
0066BC4F0  adrp     x27, #0x8f11000
0066BC4F4  mov      w24, w6
0066BC4F8  str      x8, [sp, #0x118]
0066BC4FC  ldrb     w8, [x28, #0x20c]
0066BC500  ldr      x27, [x27, #0xb08]
0066BC504  mov      w25, w5
0066BC508  mov      x20, x4
0066BC50C  mov      x22, x3
0066BC510  mov      x23, x2
0066BC514  mov      x19, x1
0066BC518  mov      x21, x0
0066BC51C  tbnz     w8, #0, #0x66bc540
0066BC520  adrp     x0, #0x8f11000
0066BC524  ldr      x0, [x0, #0xb08]
0066BC528  bl       #0x382bd14 ; 
0066BC52C  adrp     x0, #0x8f06000
0066BC530  ldr      x0, [x0, #0x348]
0066BC534  bl       #0x382bd14 ; 
0066BC538  mov      w8, #1
0066BC53C  strb     w8, [x28, #0x20c]
0066BC540  ldr      x7, [x27]
0066BC544  add      x27, sp, #0xc0
0066BC548  ldrb     w8, [x7, #0x53]
0066BC54C  tbnz     w8, #5, #0x66bc600
0066BC550  str      xzr, [sp, #0x38]
0066BC554  cbz      x19, #0x66bc634
0066BC558  add      x2, sp, #0x38
0066BC55C  mov      x0, x19
0066BC560  mov      x1, x22
0066BC564  mov      x3, xzr
0066BC568  bl       #0x67f1990 ; HotFix.BattleLogic.EntityCharacter$$TryGetSameEnemyMilestoneExplosionConfig
0066BC56C  tbz      w0, #0, #0x66bc634
0066BC570  ldr      x9, [sp, #0x38]
0066BC574  cbz      x9, #0x66bc7e0
0066BC578  ldr      w8, [x9, #0x10]
0066BC57C  cmp      w8, #1
0066BC580  b.lt     #0x66bc634
0066BC584  ldr      w10, [x9, #0x14]
0066BC588  cmp      w10, #1
0066BC58C  b.lt     #0x66bc634
0066BC590  ldr      w3, [x9, #0x24]
0066BC594  cmp      w3, #1
0066BC598  csel     w4, w24, w25, eq
0066BC59C  cmp      w4, #1
0066BC5A0  b.lt     #0x66bc634
0066BC5A4  udiv     w9, w4, w8
0066BC5A8  msub     w8, w9, w8, w4
0066BC5AC  cbnz     w8, #0x66bc634
0066BC5B0  mov      x0, x21
0066BC5B4  mov      x1, x23
0066BC5B8  mov      x2, x22
0066BC5BC  bl       #0x66bc7e8 ; HotFix.BattleLogic.CharacterComponentOnHit$$TryMarkSameEnemyMilestoneExplosionFired
0066BC5C0  tbz      w0, #0, #0x66bc634
0066BC5C4  adrp     x22, #0x9591000
0066BC5C8  ldrb     w8, [x22, #0xa4b]
0066BC5CC  cbnz     w8, #0x66bc5e4
0066BC5D0  adrp     x0, #0x8ee5000
0066BC5D4  ldr      x0, [x0, #0xb28]
0066BC5D8  bl       #0x382bd14 ; 
0066BC5DC  mov      w8, #1
0066BC5E0  strb     w8, [x22, #0xa4b]
0066BC5E4  adrp     x8, #0x8ee5000
0066BC5E8  ldr      x8, [x8, #0xb28]
0066BC5EC  ldr      x1, [x8]
0066BC5F0  ldrb     w8, [x1, #0x53]
0066BC5F4  tbnz     w8, #5, #0x66bc664
0066BC5F8  ldr      x21, [x21, #0x20]
0066BC5FC  b        #0x66bc674 ; 
0066BC600  ldr      x8, [x20, #0x10]
0066BC604  ldr      q0, [x20]
0066BC608  ldr      x9, [x7, #0x60]
0066BC60C  add      x4, sp, #0x100
0066BC610  mov      x0, x21
0066BC614  mov      x1, x19
0066BC618  mov      x2, x23
0066BC61C  mov      x3, x22
0066BC620  mov      w5, w25
0066BC624  mov      w6, w24
0066BC628  str      x8, [sp, #0x110]
0066BC62C  str      q0, [x27, #0x40]
0066BC630  blr      x9
0066BC634  ldr      x8, [x26, #0x28]
0066BC638  ldr      x9, [sp, #0x118]
0066BC63C  cmp      x8, x9
0066BC640  b.ne     #0x66bc7e4
0066BC644  ldp      x20, x19, [sp, #0x170]
0066BC648  ldp      x22, x21, [sp, #0x160]
0066BC64C  ldp      x24, x23, [sp, #0x150]
0066BC650  ldp      x26, x25, [sp, #0x140]
0066BC654  ldp      x28, x27, [sp, #0x130]
0066BC658  ldp      x29, x30, [sp, #0x120]
0066BC65C  add      sp, sp, #0x180
0066BC660  ret      
0066BC664  ldr      x8, [x1, #0x60]
0066BC668  mov      x0, x21
0066BC66C  blr      x8
0066BC670  mov      x21, x0
0066BC674  cbz      x21, #0x66bc7e0
0066BC678  adrp     x22, #0x9591000
0066BC67C  ldrb     w8, [x22, #0xa4c]
0066BC680  cbnz     w8, #0x66bc698
0066BC684  adrp     x0, #0x8ee5000
0066BC688  ldr      x0, [x0, #0xb30]
0066BC68C  bl       #0x382bd14 ; 
0066BC690  mov      w8, #1
0066BC694  strb     w8, [x22, #0xa4c]
0066BC698  adrp     x8, #0x8ee5000
0066BC69C  ldr      x8, [x8, #0xb30]
0066BC6A0  ldr      x1, [x8]
0066BC6A4  ldrb     w8, [x1, #0x53]
0066BC6A8  tbnz     w8, #5, #0x66bc6b4
0066BC6AC  ldr      x0, [x21, #0x210]
0066BC6B0  b        #0x66bc6c0 ; 
0066BC6B4  ldr      x8, [x1, #0x60]
0066BC6B8  mov      x0, x21
0066BC6BC  blr      x8
0066BC6C0  cbz      x0, #0x66bc7e0
0066BC6C4  adrp     x8, #0x8f06000
0066BC6C8  ldr      x8, [x8, #0x348]
0066BC6CC  ldr      x1, [x8]
0066BC6D0  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BC6D4  ldr      x8, [sp, #0x38]
0066BC6D8  cbz      x8, #0x66bc7e0
0066BC6DC  mov      x21, x0
0066BC6E0  cbz      x0, #0x66bc7e0
0066BC6E4  ldr      x8, [x8, #0x18]
0066BC6E8  mov      w9, #0x10000
0066BC6EC  mov      x0, xzr
0066BC6F0  cmp      x8, #0
0066BC6F4  csel     x8, x8, x9, gt
0066BC6F8  str      x8, [x21, #0x20]
0066BC6FC  add      x8, sp, #0xc0
0066BC700  bl       #0x7d4fddc ; Photon.Deterministic.FPVector3$$get_One
0066BC704  ldr      x8, [x21, #0x20]
0066BC708  ldp      x9, x10, [sp, #0xc0]
0066BC70C  ldr      x11, [sp, #0xd0]
0066BC710  mul      x9, x8, x9
0066BC714  mul      x10, x8, x10
0066BC718  mul      x8, x8, x11
0066BC71C  asr      x9, x9, #0x10
0066BC720  asr      x10, x10, #0x10
0066BC724  asr      x8, x8, #0x10
0066BC728  stp      x9, x10, [x21, #0x28]
0066BC72C  str      x8, [x21, #0x38]
0066BC730  ldr      x8, [sp, #0x38]
0066BC734  cbz      x8, #0x66bc7e0
0066BC738  ldr      x9, [x20, #0x10]
0066BC73C  ldr      q0, [x20]
0066BC740  ldr      w20, [x8, #0x14]
0066BC744  add      x8, sp, #0xa0
0066BC748  mov      x0, xzr
0066BC74C  str      x9, [sp, #0xf0]
0066BC750  str      q0, [x27, #0x20]
0066BC754  bl       #0x7d4b8bc ; Photon.Deterministic.FPQuaternion$$get_Identity
0066BC758  ldp      q1, q2, [sp, #0xa0]
0066BC75C  ldr      x8, [sp, #0x38]
0066BC760  movi     v0.2d, #0000000000000000
0066BC764  stp      q0, q0, [sp, #0xa0]
0066BC768  stp      q1, q2, [x27]
0066BC76C  cbz      x8, #0x66bc7e0
0066BC770  ldr      w8, [x8, #0x20]
0066BC774  ldp      q3, q1, [x27, #0x10]
0066BC778  ldr      x9, [sp, #0xf0]
0066BC77C  ldr      q2, [x27]
0066BC780  ldp      q4, q5, [sp, #0xa0]
0066BC784  orr      w6, w8, #8
0066BC788  mov      w8, #1
0066BC78C  add      x2, sp, #0x80
0066BC790  add      x3, sp, #0x60
0066BC794  add      x4, sp, #0x40
0066BC798  mov      x0, x19
0066BC79C  mov      w1, w20
0066BC7A0  mov      x5, xzr
0066BC7A4  mov      w7, wzr
0066BC7A8  stp      q3, q1, [sp, #0x70]
0066BC7AC  str      x9, [sp, #0x90]
0066BC7B0  stp      q5, q2, [sp, #0x50]
0066BC7B4  str      q4, [sp, #0x40]
0066BC7B8  stur     q0, [sp, #0x28]
0066BC7BC  strb     wzr, [sp, #0x20]
0066BC7C0  str      x21, [sp, #0x10]
0066BC7C4  strb     w8, [sp, #0x18]
0066BC7C8  str      q0, [sp]
0066BC7CC  bl       #0x67fd4e0 ; HotFix.BattleLogic.EntityCharacter$$CreateWeaponAndFire
0066BC7D0  mov      x0, x21
0066BC7D4  mov      x1, xzr
0066BC7D8  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066BC7DC  b        #0x66bc634 ; 
0066BC7E0  bl       #0x382bfb8 ; 
0066BC7E4  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleGenericHitTrigger
; RVA 0x66BA928; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BA928  sub      sp, sp, #0x80
0066BA92C  stp      x29, x30, [sp, #0x20]
0066BA930  stp      x28, x27, [sp, #0x30]
0066BA934  stp      x26, x25, [sp, #0x40]
0066BA938  stp      x24, x23, [sp, #0x50]
0066BA93C  stp      x22, x21, [sp, #0x60]
0066BA940  stp      x20, x19, [sp, #0x70]
0066BA944  mrs      x27, tpidr_el0
0066BA948  ldr      x8, [x27, #0x28]
0066BA94C  adrp     x26, #0x959a000
0066BA950  adrp     x28, #0x8f11000
0066BA954  mov      x24, x6
0066BA958  str      x8, [sp, #0x18]
0066BA95C  ldrb     w8, [x26, #0x20d]
0066BA960  ldr      x28, [x28, #0xa68]
0066BA964  mov      x22, x5
0066BA968  mov      w25, w4
0066BA96C  mov      x20, x3
0066BA970  mov      x19, x2
0066BA974  mov      x23, x1
0066BA978  mov      x21, x0
0066BA97C  tbnz     w8, #0, #0x66ba9e8
0066BA980  adrp     x0, #0x8f11000
0066BA984  ldr      x0, [x0, #0xa68]
0066BA988  bl       #0x382bd14 ; 
0066BA98C  adrp     x0, #0x8ee6000
0066BA990  ldr      x0, [x0, #0xd8]
0066BA994  bl       #0x382bd14 ; 
0066BA998  adrp     x0, #0x8ee6000
0066BA99C  ldr      x0, [x0, #0xe8]
0066BA9A0  bl       #0x382bd14 ; 
0066BA9A4  adrp     x0, #0x8ee6000
0066BA9A8  ldr      x0, [x0, #0xf0]
0066BA9AC  bl       #0x382bd14 ; 
0066BA9B0  adrp     x0, #0x8ee6000
0066BA9B4  ldr      x0, [x0, #0x608]
0066BA9B8  bl       #0x382bd14 ; 
0066BA9BC  adrp     x0, #0x8ee9000
0066BA9C0  ldr      x0, [x0, #0x968]
0066BA9C4  bl       #0x382bd14 ; 
0066BA9C8  adrp     x0, #0x8ee9000
0066BA9CC  ldr      x0, [x0, #0x978]
0066BA9D0  bl       #0x382bd14 ; 
0066BA9D4  adrp     x0, #0x8f11000
0066BA9D8  ldr      x0, [x0, #0xa70]
0066BA9DC  bl       #0x382bd14 ; 
0066BA9E0  mov      w8, #1
0066BA9E4  strb     w8, [x26, #0x20d]
0066BA9E8  ldr      x7, [x28]
0066BA9EC  ldrb     w8, [x7, #0x53]
0066BA9F0  tbnz     w8, #5, #0x66baa30
0066BA9F4  tbnz     w25, #3, #0x66baa54
0066BA9F8  cbz      x24, #0x66baa54
0066BA9FC  tbz      w25, #0x18, #0x66bab34
0066BAA00  cbz      x19, #0x66bb074
0066BAA04  mov      x0, x19
0066BAA08  mov      x1, xzr
0066BAA0C  bl       #0x6681ae0 ; HotFix.BattleLogic.EntityBullet$$get_HitEntitySet
0066BAA10  adrp     x28, #0x8ee6000
0066BAA14  ldr      x28, [x28, #0x608]
0066BAA18  mov      x25, x0
0066BAA1C  ldr      x1, [x28]
0066BAA20  ldrb     w8, [x1, #0x53]
0066BAA24  tbnz     w8, #5, #0x66baa84
0066BAA28  ldr      x0, [x21, #0x30]
0066BAA2C  b        #0x66baa90 ; 
0066BAA30  ldr      x8, [x7, #0x60]
0066BAA34  mov      x0, x21
0066BAA38  mov      x1, x23
0066BAA3C  mov      x2, x19
0066BAA40  mov      x3, x20
0066BAA44  mov      w4, w25
0066BAA48  mov      x5, x22
0066BAA4C  mov      x6, x24
0066BAA50  blr      x8
0066BAA54  ldr      x8, [x27, #0x28]
0066BAA58  ldr      x9, [sp, #0x18]
0066BAA5C  cmp      x8, x9
0066BAA60  b.ne     #0x66bb0c8
0066BAA64  ldp      x20, x19, [sp, #0x70]
0066BAA68  ldp      x22, x21, [sp, #0x60]
0066BAA6C  ldp      x24, x23, [sp, #0x50]
0066BAA70  ldp      x26, x25, [sp, #0x40]
0066BAA74  ldp      x28, x27, [sp, #0x30]
0066BAA78  ldp      x29, x30, [sp, #0x20]
0066BAA7C  add      sp, sp, #0x80
0066BAA80  ret      
0066BAA84  ldr      x8, [x1, #0x60]
0066BAA88  mov      x0, x21
0066BAA8C  blr      x8
0066BAA90  cbz      x0, #0x66bb078
0066BAA94  adrp     x29, #0x8ee6000
0066BAA98  ldr      x29, [x29, #0xe8]
0066BAA9C  ldr      x1, [x29]
0066BAAA0  ldrb     w8, [x1, #0x53]
0066BAAA4  tbnz     w8, #5, #0x66baab0
0066BAAA8  ldr      x26, [x0, #0x28]
0066BAAAC  b        #0x66baabc ; 
0066BAAB0  ldr      x8, [x1, #0x60]
0066BAAB4  blr      x8
0066BAAB8  mov      x26, x0
0066BAABC  ldr      x1, [x28]
0066BAAC0  ldrb     w8, [x1, #0x53]
0066BAAC4  tbnz     w8, #5, #0x66baad0
0066BAAC8  ldr      x0, [x21, #0x30]
0066BAACC  b        #0x66baadc ; 
0066BAAD0  ldr      x8, [x1, #0x60]
0066BAAD4  mov      x0, x21
0066BAAD8  blr      x8
0066BAADC  cbz      x0, #0x66bb07c
0066BAAE0  ldr      x1, [x29]
0066BAAE4  ldrb     w8, [x1, #0x53]
0066BAAE8  tbnz     w8, #5, #0x66baaf4
0066BAAEC  ldr      x1, [x0, #0x28]
0066BAAF0  b        #0x66bab00 ; 
0066BAAF4  ldr      x8, [x1, #0x60]
0066BAAF8  blr      x8
0066BAAFC  mov      x1, x0
0066BAB00  cbz      x25, #0x66bb080
0066BAB04  adrp     x8, #0x8ee9000
0066BAB08  ldr      x8, [x8, #0x978]
0066BAB0C  ldr      x2, [x8]
0066BAB10  mov      x0, x25
0066BAB14  bl       #0x4931cc8 ; System.Collections.Generic.HashSet<EntityRef>$$Contains
0066BAB18  tbnz     w0, #0, #0x66baa54
0066BAB1C  adrp     x8, #0x8ee9000
0066BAB20  ldr      x8, [x8, #0x968]
0066BAB24  ldr      x2, [x8]
0066BAB28  mov      x0, x25
0066BAB2C  mov      x1, x26
0066BAB30  bl       #0x49327b4 ; System.Collections.Generic.HashSet<EntityRef>$$Add
0066BAB34  adrp     x26, #0x9591000
0066BAB38  ldrb     w8, [x26, #0xa86]
0066BAB3C  cbnz     w8, #0x66bab60
0066BAB40  adrp     x0, #0x8ee6000
0066BAB44  ldr      x0, [x0, #0x318]
0066BAB48  bl       #0x382bd14 ; 
0066BAB4C  adrp     x0, #0x8ee3000
0066BAB50  ldr      x0, [x0, #0xf18]
0066BAB54  bl       #0x382bd14 ; 
0066BAB58  mov      w8, #1
0066BAB5C  strb     w8, [x26, #0xa86]
0066BAB60  adrp     x28, #0x8ee6000
0066BAB64  ldr      x28, [x28, #0x318]
0066BAB68  ldr      x2, [x28]
0066BAB6C  ldrb     w8, [x2, #0x53]
0066BAB70  tbnz     w8, #5, #0x66bab94
0066BAB74  ldr      x0, [x24, #0x190]
0066BAB78  cbz      x0, #0x66badac
0066BAB7C  adrp     x8, #0x8ee3000
0066BAB80  ldr      x8, [x8, #0xf18]
0066BAB84  ldr      x2, [x8]
0066BAB88  mov      w1, #4
0066BAB8C  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066BAB90  b        #0x66baba4 ; 
0066BAB94  ldr      x8, [x2, #0x60]
0066BAB98  mov      w1, #4
0066BAB9C  mov      x0, x24
0066BABA0  blr      x8
0066BABA4  tbz      w0, #0, #0x66badac
0066BABA8  adrp     x25, #0x9591000
0066BABAC  ldrb     w8, [x25, #0xa4b]
0066BABB0  cbnz     w8, #0x66babc8
0066BABB4  adrp     x0, #0x8ee5000
0066BABB8  ldr      x0, [x0, #0xb28]
0066BABBC  bl       #0x382bd14 ; 
0066BABC0  mov      w8, #1
0066BABC4  strb     w8, [x25, #0xa4b]
0066BABC8  adrp     x8, #0x8ee5000
0066BABCC  ldr      x8, [x8, #0xb28]
0066BABD0  ldr      x1, [x8]
0066BABD4  ldrb     w8, [x1, #0x53]
0066BABD8  tbnz     w8, #5, #0x66babe4
0066BABDC  ldr      x25, [x21, #0x20]
0066BABE0  b        #0x66babf4 ; 
0066BABE4  ldr      x8, [x1, #0x60]
0066BABE8  mov      x0, x21
0066BABEC  blr      x8
0066BABF0  mov      x25, x0
0066BABF4  cbz      x25, #0x66bb088
0066BABF8  adrp     x29, #0x9591000
0066BABFC  ldrb     w8, [x29, #0xa4c]
0066BAC00  cbnz     w8, #0x66bac18
0066BAC04  adrp     x0, #0x8ee5000
0066BAC08  ldr      x0, [x0, #0xb30]
0066BAC0C  bl       #0x382bd14 ; 
0066BAC10  mov      w8, #1
0066BAC14  strb     w8, [x29, #0xa4c]
0066BAC18  adrp     x8, #0x8ee5000
0066BAC1C  ldr      x8, [x8, #0xb30]
0066BAC20  ldr      x1, [x8]
0066BAC24  ldrb     w8, [x1, #0x53]
0066BAC28  tbnz     w8, #5, #0x66bac34
0066BAC2C  ldr      x0, [x25, #0x210]
0066BAC30  b        #0x66bac40 ; 
0066BAC34  ldr      x8, [x1, #0x60]
0066BAC38  mov      x0, x25
0066BAC3C  blr      x8
0066BAC40  cbz      x0, #0x66bb08c
0066BAC44  adrp     x8, #0x8f11000
0066BAC48  ldr      x8, [x8, #0xa70]
0066BAC4C  ldr      x1, [x8]
0066BAC50  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BAC54  cbz      x23, #0x66bb090
0066BAC58  ldr      x8, [x23, #0x38]
0066BAC5C  ldur     q0, [x23, #0x28]
0066BAC60  mov      x25, x0
0066BAC64  str      x8, [sp, #0x10]
0066BAC68  str      q0, [sp]
0066BAC6C  cbz      x0, #0x66bb094
0066BAC70  ldr      x8, [sp, #0x10]
0066BAC74  ldr      q0, [sp]
0066BAC78  add      x9, x23, #0x28
0066BAC7C  adrp     x29, #0x8ee6000
0066BAC80  str      x8, [x25, #0x30]
0066BAC84  str      q0, [x25, #0x20]
0066BAC88  ldr      x8, [x9, #0x10]
0066BAC8C  ldr      q0, [x9]
0066BAC90  str      x22, [x25, #0x38]
0066BAC94  str      x8, [x25, #0x68]
0066BAC98  stur     q0, [x25, #0x58]
0066BAC9C  ldr      x29, [x29, #0xe8]
0066BACA0  ldr      x1, [x29]
0066BACA4  ldrb     w8, [x1, #0x53]
0066BACA8  tbnz     w8, #5, #0x66bacb4
0066BACAC  ldr      x0, [x24, #0x28]
0066BACB0  b        #0x66bacc0 ; 
0066BACB4  ldr      x8, [x1, #0x60]
0066BACB8  mov      x0, x24
0066BACBC  blr      x8
0066BACC0  str      x0, [x25, #0x40]
0066BACC4  adrp     x8, #0x8ee6000
0066BACC8  ldr      x8, [x8, #0x608]
0066BACCC  ldr      x1, [x8]
0066BACD0  ldrb     w8, [x1, #0x53]
0066BACD4  tbnz     w8, #5, #0x66bace0
0066BACD8  ldr      x0, [x21, #0x30]
0066BACDC  b        #0x66bacec ; 
0066BACE0  ldr      x8, [x1, #0x60]
0066BACE4  mov      x0, x21
0066BACE8  blr      x8
0066BACEC  cbz      x0, #0x66bb098
0066BACF0  ldr      x1, [x29]
0066BACF4  ldrb     w8, [x1, #0x53]
0066BACF8  tbnz     w8, #5, #0x66bad04
0066BACFC  ldr      x0, [x0, #0x28]
0066BAD00  b        #0x66bad0c ; 
0066BAD04  ldr      x8, [x1, #0x60]
0066BAD08  blr      x8
0066BAD0C  mov      w8, #1
0066BAD10  str      x0, [x25, #0x48]
0066BAD14  str      w8, [x25, #0x70]
0066BAD18  cbz      x20, #0x66bb09c
0066BAD1C  adrp     x29, #0x959a000
0066BAD20  ldrb     w8, [x29, #0xc2]
0066BAD24  cbnz     w8, #0x66bad3c
0066BAD28  adrp     x0, #0x8f0f000
0066BAD2C  ldr      x0, [x0, #0x9a8]
0066BAD30  bl       #0x382bd14 ; 
0066BAD34  mov      w8, #1
0066BAD38  strb     w8, [x29, #0xc2]
0066BAD3C  adrp     x8, #0x8f0f000
0066BAD40  ldr      x8, [x8, #0x9a8]
0066BAD44  ldr      x1, [x8]
0066BAD48  ldrb     w8, [x1, #0x53]
0066BAD4C  tbnz     w8, #5, #0x66bad58
0066BAD50  ldr      w0, [x20, #0x11c]
0066BAD54  b        #0x66bad64 ; 
0066BAD58  ldr      x8, [x1, #0x60]
0066BAD5C  mov      x0, x20
0066BAD60  blr      x8
0066BAD64  str      w0, [x25, #0x74]
0066BAD68  cbz      x19, #0x66bb0a0
0066BAD6C  adrp     x8, #0x8ee6000
0066BAD70  ldr      x8, [x8, #0xf0]
0066BAD74  ldr      x1, [x8]
0066BAD78  ldrb     w8, [x1, #0x53]
0066BAD7C  tbnz     w8, #5, #0x66bad88
0066BAD80  ldr      x0, [x19, #0x28]
0066BAD84  b        #0x66bad94 ; 
0066BAD88  ldr      x8, [x1, #0x60]
0066BAD8C  mov      x0, x19
0066BAD90  blr      x8
0066BAD94  str      x0, [x25, #0x50]
0066BAD98  ldr      x0, [x24, #0x150]
0066BAD9C  cbz      x0, #0x66bb0a4
0066BADA0  mov      x1, x25
0066BADA4  mov      x2, xzr
0066BADA8  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BADAC  mov      x0, x24
0066BADB0  mov      x1, xzr
0066BADB4  bl       #0x67e4f78 ; HotFix.BattleLogic.EntityCharacter$$GetRootCharacter
0066BADB8  mov      x25, x0
0066BADBC  cbz      x0, #0x66baa54
0066BADC0  adrp     x8, #0x8ee6000
0066BADC4  ldr      x8, [x8, #0xd8]
0066BADC8  ldr      x1, [x8]
0066BADCC  ldrb     w8, [x1, #0x53]
0066BADD0  tbnz     w8, #5, #0x66baddc
0066BADD4  ldr      x0, [x25, #0x38]
0066BADD8  b        #0x66bade8 ; 
0066BADDC  ldr      x8, [x1, #0x60]
0066BADE0  mov      x0, x25
0066BADE4  blr      x8
0066BADE8  cbz      x0, #0x66bb084
0066BADEC  mov      x1, xzr
0066BADF0  bl       #0x45616a8 ; 
0066BADF4  cmp      x25, x24
0066BADF8  b.eq     #0x66baa54
0066BADFC  eor      w8, w0, #1
0066BAE00  tbnz     w8, #0, #0x66baa54
0066BAE04  ldrb     w8, [x26, #0xa86]
0066BAE08  cbnz     w8, #0x66bae2c
0066BAE0C  adrp     x0, #0x8ee6000
0066BAE10  ldr      x0, [x0, #0x318]
0066BAE14  bl       #0x382bd14 ; 
0066BAE18  adrp     x0, #0x8ee3000
0066BAE1C  ldr      x0, [x0, #0xf18]
0066BAE20  bl       #0x382bd14 ; 
0066BAE24  mov      w8, #1
0066BAE28  strb     w8, [x26, #0xa86]
0066BAE2C  ldr      x2, [x28]
0066BAE30  ldrb     w8, [x2, #0x53]
0066BAE34  tbnz     w8, #5, #0x66bae58
0066BAE38  ldr      x0, [x25, #0x190]
0066BAE3C  cbz      x0, #0x66baa54
0066BAE40  adrp     x8, #0x8ee3000
0066BAE44  ldr      x8, [x8, #0xf18]
0066BAE48  ldr      x2, [x8]
0066BAE4C  mov      w1, #4
0066BAE50  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066BAE54  b        #0x66bae68 ; 
0066BAE58  ldr      x8, [x2, #0x60]
0066BAE5C  mov      w1, #4
0066BAE60  mov      x0, x25
0066BAE64  blr      x8
0066BAE68  tbz      w0, #0, #0x66baa54
0066BAE6C  adrp     x24, #0x9591000
0066BAE70  ldrb     w8, [x24, #0xa4b]
0066BAE74  cbnz     w8, #0x66bae8c
0066BAE78  adrp     x0, #0x8ee5000
0066BAE7C  ldr      x0, [x0, #0xb28]
0066BAE80  bl       #0x382bd14 ; 
0066BAE84  mov      w8, #1
0066BAE88  strb     w8, [x24, #0xa4b]
0066BAE8C  adrp     x8, #0x8ee5000
0066BAE90  ldr      x8, [x8, #0xb28]
0066BAE94  ldr      x1, [x8]
0066BAE98  ldrb     w8, [x1, #0x53]
0066BAE9C  tbnz     w8, #5, #0x66baea8
0066BAEA0  ldr      x24, [x21, #0x20]
0066BAEA4  b        #0x66baeb8 ; 
0066BAEA8  ldr      x8, [x1, #0x60]
0066BAEAC  mov      x0, x21
0066BAEB0  blr      x8
0066BAEB4  mov      x24, x0
0066BAEB8  cbz      x24, #0x66bb0a8
0066BAEBC  adrp     x26, #0x9591000
0066BAEC0  ldrb     w8, [x26, #0xa4c]
0066BAEC4  cbnz     w8, #0x66baedc
0066BAEC8  adrp     x0, #0x8ee5000
0066BAECC  ldr      x0, [x0, #0xb30]
0066BAED0  bl       #0x382bd14 ; 
0066BAED4  mov      w8, #1
0066BAED8  strb     w8, [x26, #0xa4c]
0066BAEDC  adrp     x8, #0x8ee5000
0066BAEE0  ldr      x8, [x8, #0xb30]
0066BAEE4  ldr      x1, [x8]
0066BAEE8  ldrb     w8, [x1, #0x53]
0066BAEEC  tbnz     w8, #5, #0x66baef8
0066BAEF0  ldr      x0, [x24, #0x210]
0066BAEF4  b        #0x66baf04 ; 
0066BAEF8  ldr      x8, [x1, #0x60]
0066BAEFC  mov      x0, x24
0066BAF00  blr      x8
0066BAF04  cbz      x0, #0x66bb0ac
0066BAF08  adrp     x8, #0x8f11000
0066BAF0C  ldr      x8, [x8, #0xa70]
0066BAF10  ldr      x1, [x8]
0066BAF14  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BAF18  cbz      x23, #0x66bb0b0
0066BAF1C  ldr      x8, [x23, #0x38]
0066BAF20  ldur     q0, [x23, #0x28]
0066BAF24  mov      x24, x0
0066BAF28  str      x8, [sp, #0x10]
0066BAF2C  str      q0, [sp]
0066BAF30  cbz      x0, #0x66bb0b4
0066BAF34  ldr      x8, [sp, #0x10]
0066BAF38  ldr      q0, [sp]
0066BAF3C  add      x9, x23, #0x28
0066BAF40  str      x8, [x24, #0x30]
0066BAF44  str      q0, [x24, #0x20]
0066BAF48  ldr      x8, [x9, #0x10]
0066BAF4C  ldr      q0, [x9]
0066BAF50  str      x22, [x24, #0x38]
0066BAF54  adrp     x22, #0x8ee6000
0066BAF58  str      x8, [x24, #0x68]
0066BAF5C  stur     q0, [x24, #0x58]
0066BAF60  ldr      x22, [x22, #0xe8]
0066BAF64  ldr      x1, [x22]
0066BAF68  ldrb     w8, [x1, #0x53]
0066BAF6C  tbnz     w8, #5, #0x66baf78
0066BAF70  ldr      x0, [x25, #0x28]
0066BAF74  b        #0x66baf84 ; 
0066BAF78  ldr      x8, [x1, #0x60]
0066BAF7C  mov      x0, x25
0066BAF80  blr      x8
0066BAF84  str      x0, [x24, #0x40]
0066BAF88  adrp     x8, #0x8ee6000
0066BAF8C  ldr      x8, [x8, #0x608]
0066BAF90  ldr      x1, [x8]
0066BAF94  ldrb     w8, [x1, #0x53]
0066BAF98  tbnz     w8, #5, #0x66bafa4
0066BAF9C  ldr      x0, [x21, #0x30]
0066BAFA0  b        #0x66bafb0 ; 
0066BAFA4  ldr      x8, [x1, #0x60]
0066BAFA8  mov      x0, x21
0066BAFAC  blr      x8
0066BAFB0  cbz      x0, #0x66bb0b8
0066BAFB4  ldr      x1, [x22]
0066BAFB8  ldrb     w8, [x1, #0x53]
0066BAFBC  tbnz     w8, #5, #0x66bafc8
0066BAFC0  ldr      x0, [x0, #0x28]
0066BAFC4  b        #0x66bafd0 ; 
0066BAFC8  ldr      x8, [x1, #0x60]
0066BAFCC  blr      x8
0066BAFD0  mov      w8, #1
0066BAFD4  str      x0, [x24, #0x48]
0066BAFD8  str      w8, [x24, #0x70]
0066BAFDC  cbz      x20, #0x66bb0bc
0066BAFE0  adrp     x21, #0x959a000
0066BAFE4  ldrb     w8, [x21, #0xc2]
0066BAFE8  cbnz     w8, #0x66bb000
0066BAFEC  adrp     x0, #0x8f0f000
0066BAFF0  ldr      x0, [x0, #0x9a8]
0066BAFF4  bl       #0x382bd14 ; 
0066BAFF8  mov      w8, #1
0066BAFFC  strb     w8, [x21, #0xc2]
0066BB000  adrp     x8, #0x8f0f000
0066BB004  ldr      x8, [x8, #0x9a8]
0066BB008  ldr      x1, [x8]
0066BB00C  ldrb     w8, [x1, #0x53]
0066BB010  tbnz     w8, #5, #0x66bb01c
0066BB014  ldr      w0, [x20, #0x11c]
0066BB018  b        #0x66bb028 ; 
0066BB01C  ldr      x8, [x1, #0x60]
0066BB020  mov      x0, x20
0066BB024  blr      x8
0066BB028  str      w0, [x24, #0x74]
0066BB02C  cbz      x19, #0x66bb0c0
0066BB030  adrp     x8, #0x8ee6000
0066BB034  ldr      x8, [x8, #0xf0]
0066BB038  ldr      x1, [x8]
0066BB03C  ldrb     w8, [x1, #0x53]
0066BB040  tbnz     w8, #5, #0x66bb04c
0066BB044  ldr      x0, [x19, #0x28]
0066BB048  b        #0x66bb058 ; 
0066BB04C  ldr      x8, [x1, #0x60]
0066BB050  mov      x0, x19
0066BB054  blr      x8
0066BB058  str      x0, [x24, #0x50]
0066BB05C  ldr      x0, [x25, #0x150]
0066BB060  cbz      x0, #0x66bb0c4
0066BB064  mov      x1, x24
0066BB068  mov      x2, xzr
0066BB06C  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BB070  b        #0x66baa54 ; 
0066BB074  bl       #0x382bfb8 ; 
0066BB078  bl       #0x382bfb8 ; 
0066BB07C  bl       #0x382bfb8 ; 
0066BB080  bl       #0x382bfb8 ; 
0066BB084  bl       #0x382bfb8 ; 
0066BB088  bl       #0x382bfb8 ; 
0066BB08C  bl       #0x382bfb8 ; 
0066BB090  bl       #0x382bfb8 ; 
0066BB094  bl       #0x382bfb8 ; 
0066BB098  bl       #0x382bfb8 ; 
0066BB09C  bl       #0x382bfb8 ; 
0066BB0A0  bl       #0x382bfb8 ; 
0066BB0A4  bl       #0x382bfb8 ; 
0066BB0A8  bl       #0x382bfb8 ; 
0066BB0AC  bl       #0x382bfb8 ; 
0066BB0B0  bl       #0x382bfb8 ; 
0066BB0B4  bl       #0x382bfb8 ; 
0066BB0B8  bl       #0x382bfb8 ; 
0066BB0BC  bl       #0x382bfb8 ; 
0066BB0C0  bl       #0x382bfb8 ; 
0066BB0C4  bl       #0x382bfb8 ; 
0066BB0C8  bl       #0x89edb60 ; 
0066BB0CC  b        #0x66bb170 ; 
0066BB0D0  b        #0x66bb170 ; 
0066BB0D4  b        #0x66bb170 ; 
0066BB0D8  b        #0x66bb170 ; 
0066BB0DC  b        #0x66bb170 ; 
0066BB0E0  b        #0x66bb170 ; 
0066BB0E4  b        #0x66bb170 ; 
0066BB0E8  b        #0x66bb170 ; 
0066BB0EC  b        #0x66bb170 ; 
0066BB0F0  b        #0x66bb170 ; 
0066BB0F4  b        #0x66bb170 ; 
0066BB0F8  b        #0x66bb170 ; 
0066BB0FC  b        #0x66bb170 ; 
0066BB100  b        #0x66bb170 ; 
0066BB104  b        #0x66bb170 ; 
0066BB108  b        #0x66bb170 ; 
0066BB10C  b        #0x66bb170 ; 
0066BB110  b        #0x66bb170 ; 
0066BB114  b        #0x66bb170 ; 
0066BB118  b        #0x66bb170 ; 
0066BB11C  b        #0x66bb170 ; 
0066BB120  b        #0x66bb170 ; 
0066BB124  b        #0x66bb170 ; 
0066BB128  b        #0x66bb170 ; 
0066BB12C  b        #0x66bb170 ; 
0066BB130  b        #0x66bb170 ; 
0066BB134  b        #0x66bb170 ; 
0066BB138  b        #0x66bb170 ; 
0066BB13C  b        #0x66bb170 ; 
0066BB140  b        #0x66bb170 ; 
0066BB144  b        #0x66bb170 ; 
0066BB148  b        #0x66bb170 ; 
0066BB14C  b        #0x66bb170 ; 
0066BB150  b        #0x66bb170 ; 
0066BB154  b        #0x66bb170 ; 
0066BB158  b        #0x66bb170 ; 
0066BB15C  b        #0x66bb170 ; 
0066BB160  b        #0x66bb170 ; 
0066BB164  b        #0x66bb170 ; 
0066BB168  b        #0x66bb170 ; 
0066BB16C  b        #0x66bb170 ; 
0066BB170  cmp      w1, #1
0066BB174  b.ne     #0x66bb194
0066BB178  bl       #0x89eda50 ; 
0066BB17C  ldr      x19, [x0]
0066BB180  bl       #0x89eda60 ; 
0066BB184  cbz      x19, #0x66baa54
0066BB188  mov      x0, x19
0066BB18C  bl       #0x382bfb0 ; 
0066BB190  cbnz     x19, #0x66bb198
0066BB194  bl       #0x3b56bfc ; 
0066BB198  mov      x0, x19
0066BB19C  bl       #0x382bfb0 ; 
0066BB1A0  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBatterLogic
; RVA 0x66BB1A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BB1A4  sub      sp, sp, #0x70
0066BB1A8  stp      x30, x27, [sp, #0x20]
0066BB1AC  stp      x26, x25, [sp, #0x30]
0066BB1B0  stp      x24, x23, [sp, #0x40]
0066BB1B4  stp      x22, x21, [sp, #0x50]
0066BB1B8  stp      x20, x19, [sp, #0x60]
0066BB1BC  mrs      x24, tpidr_el0
0066BB1C0  ldr      x8, [x24, #0x28]
0066BB1C4  adrp     x23, #0x959a000
0066BB1C8  adrp     x25, #0x8f11000
0066BB1CC  mov      x19, x3
0066BB1D0  str      x8, [sp, #0x18]
0066BB1D4  ldrb     w8, [x23, #0x20e]
0066BB1D8  ldr      x25, [x25, #0xa78]
0066BB1DC  mov      x21, x2
0066BB1E0  mov      x22, x1
0066BB1E4  mov      x20, x0
0066BB1E8  tbnz     w8, #0, #0x66bb23c
0066BB1EC  adrp     x0, #0x8f11000
0066BB1F0  ldr      x0, [x0, #0xa78]
0066BB1F4  bl       #0x382bd14 ; 
0066BB1F8  adrp     x0, #0x8ee6000
0066BB1FC  ldr      x0, [x0, #0xd8]
0066BB200  bl       #0x382bd14 ; 
0066BB204  adrp     x0, #0x8ee6000
0066BB208  ldr      x0, [x0, #0xe8]
0066BB20C  bl       #0x382bd14 ; 
0066BB210  adrp     x0, #0x8ee6000
0066BB214  ldr      x0, [x0, #0x608]
0066BB218  bl       #0x382bd14 ; 
0066BB21C  adrp     x0, #0x8ee6000
0066BB220  ldr      x0, [x0, #0x610]
0066BB224  bl       #0x382bd14 ; 
0066BB228  adrp     x0, #0x8f11000
0066BB22C  ldr      x0, [x0, #0xa80]
0066BB230  bl       #0x382bd14 ; 
0066BB234  mov      w8, #1
0066BB238  strb     w8, [x23, #0x20e]
0066BB23C  ldr      x4, [x25]
0066BB240  ldrb     w8, [x4, #0x53]
0066BB244  tbnz     w8, #5, #0x66bb268
0066BB248  cbz      x19, #0x66bb53c
0066BB24C  adrp     x8, #0x8ee6000
0066BB250  ldr      x8, [x8, #0xd8]
0066BB254  ldr      x1, [x8]
0066BB258  ldrb     w8, [x1, #0x53]
0066BB25C  tbnz     w8, #5, #0x66bb284
0066BB260  ldr      x23, [x19, #0x38]
0066BB264  b        #0x66bb294 ; 
0066BB268  ldr      x8, [x4, #0x60]
0066BB26C  mov      x0, x20
0066BB270  mov      x1, x22
0066BB274  mov      x2, x21
0066BB278  mov      x3, x19
0066BB27C  blr      x8
0066BB280  b        #0x66bb510 ; 
0066BB284  ldr      x8, [x1, #0x60]
0066BB288  mov      x0, x19
0066BB28C  blr      x8
0066BB290  mov      x23, x0
0066BB294  cbz      x23, #0x66bb540
0066BB298  adrp     x25, #0x9591000
0066BB29C  ldrb     w8, [x25, #0xa8f]
0066BB2A0  cbnz     w8, #0x66bb2b8
0066BB2A4  adrp     x0, #0x8ee6000
0066BB2A8  ldr      x0, [x0, #0x3d8]
0066BB2AC  bl       #0x382bd14 ; 
0066BB2B0  mov      w8, #1
0066BB2B4  strb     w8, [x25, #0xa8f]
0066BB2B8  adrp     x8, #0x8ee6000
0066BB2BC  ldr      x8, [x8, #0x3d8]
0066BB2C0  ldr      x2, [x8]
0066BB2C4  ldrb     w8, [x2, #0x53]
0066BB2C8  tbnz     w8, #5, #0x66bb2d8
0066BB2CC  ldrb     w8, [x23, #0x221]
0066BB2D0  tbnz     w8, #1, #0x66bb2ec
0066BB2D4  b        #0x66bb510 ; 
0066BB2D8  ldr      x8, [x2, #0x60]
0066BB2DC  mov      w1, #9
0066BB2E0  mov      x0, x23
0066BB2E4  blr      x8
0066BB2E8  tbz      w0, #0, #0x66bb510
0066BB2EC  adrp     x9, #0x8ee6000
0066BB2F0  ldr      x9, [x9, #0x610]
0066BB2F4  ldr      x8, [x19]
0066BB2F8  ldr      x1, [x9]
0066BB2FC  ldrb     w10, [x8, #0x130]
0066BB300  ldrb     w9, [x1, #0x130]
0066BB304  cmp      w10, w9
0066BB308  b.lo     #0x66bb544
0066BB30C  ldr      x8, [x8, #0xc8]
0066BB310  add      x8, x8, x9, lsl #3
0066BB314  ldur     x8, [x8, #-8]
0066BB318  cmp      x8, x1
0066BB31C  b.ne     #0x66bb544
0066BB320  mov      x0, x19
0066BB324  mov      x1, xzr
0066BB328  bl       #0x6879c78 ; HotFix.BattleLogic.EntityHero$$get_IsInBatter
0066BB32C  adrp     x25, #0x8ee5000
0066BB330  ldr      x25, [x25, #0xb28]
0066BB334  adrp     x26, #0x9591000
0066BB338  tbz      w0, #0, #0x66bb4c8
0066BB33C  mov      x0, x19
0066BB340  mov      x1, xzr
0066BB344  bl       #0x6879568 ; HotFix.BattleLogic.EntityHero$$IncBatterCount
0066BB348  ldrb     w8, [x26, #0xa4b]
0066BB34C  cbnz     w8, #0x66bb364
0066BB350  adrp     x0, #0x8ee5000
0066BB354  ldr      x0, [x0, #0xb28]
0066BB358  bl       #0x382bd14 ; 
0066BB35C  mov      w8, #1
0066BB360  strb     w8, [x26, #0xa4b]
0066BB364  ldr      x1, [x25]
0066BB368  ldrb     w8, [x1, #0x53]
0066BB36C  tbnz     w8, #5, #0x66bb378
0066BB370  ldr      x23, [x20, #0x20]
0066BB374  b        #0x66bb388 ; 
0066BB378  ldr      x8, [x1, #0x60]
0066BB37C  mov      x0, x20
0066BB380  blr      x8
0066BB384  mov      x23, x0
0066BB388  cbz      x23, #0x66bb550
0066BB38C  adrp     x27, #0x9591000
0066BB390  ldrb     w8, [x27, #0xa4c]
0066BB394  cbnz     w8, #0x66bb3ac
0066BB398  adrp     x0, #0x8ee5000
0066BB39C  ldr      x0, [x0, #0xb30]
0066BB3A0  bl       #0x382bd14 ; 
0066BB3A4  mov      w8, #1
0066BB3A8  strb     w8, [x27, #0xa4c]
0066BB3AC  adrp     x8, #0x8ee5000
0066BB3B0  ldr      x8, [x8, #0xb30]
0066BB3B4  ldr      x1, [x8]
0066BB3B8  ldrb     w8, [x1, #0x53]
0066BB3BC  tbnz     w8, #5, #0x66bb3c8
0066BB3C0  ldr      x0, [x23, #0x210]
0066BB3C4  b        #0x66bb3d4 ; 
0066BB3C8  ldr      x8, [x1, #0x60]
0066BB3CC  mov      x0, x23
0066BB3D0  blr      x8
0066BB3D4  cbz      x0, #0x66bb554
0066BB3D8  adrp     x8, #0x8f11000
0066BB3DC  ldr      x8, [x8, #0xa80]
0066BB3E0  ldr      x1, [x8]
0066BB3E4  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BB3E8  cbz      x22, #0x66bb558
0066BB3EC  ldr      x8, [x22, #0x38]
0066BB3F0  ldur     q0, [x22, #0x28]
0066BB3F4  mov      x23, x0
0066BB3F8  str      x8, [sp, #0x10]
0066BB3FC  str      q0, [sp]
0066BB400  cbz      x0, #0x66bb55c
0066BB404  ldr      q0, [sp]
0066BB408  ldr      x8, [sp, #0x10]
0066BB40C  str      q0, [x23, #0x20]
0066BB410  stp      x8, x21, [x23, #0x30]
0066BB414  adrp     x8, #0x8ee6000
0066BB418  ldr      x8, [x8, #0x608]
0066BB41C  ldr      x1, [x8]
0066BB420  ldrb     w8, [x1, #0x53]
0066BB424  tbnz     w8, #5, #0x66bb430
0066BB428  ldr      x0, [x20, #0x30]
0066BB42C  b        #0x66bb43c ; 
0066BB430  ldr      x8, [x1, #0x60]
0066BB434  mov      x0, x20
0066BB438  blr      x8
0066BB43C  cbz      x0, #0x66bb560
0066BB440  adrp     x8, #0x8ee6000
0066BB444  ldr      x8, [x8, #0xe8]
0066BB448  ldr      x1, [x8]
0066BB44C  ldrb     w8, [x1, #0x53]
0066BB450  tbnz     w8, #5, #0x66bb45c
0066BB454  ldr      x0, [x0, #0x28]
0066BB458  b        #0x66bb464 ; 
0066BB45C  ldr      x8, [x1, #0x60]
0066BB460  blr      x8
0066BB464  str      x0, [x23, #0x48]
0066BB468  adrp     x21, #0x959a000
0066BB46C  ldrb     w8, [x21, #0x273]
0066BB470  cbnz     w8, #0x66bb488
0066BB474  adrp     x0, #0x8f11000
0066BB478  ldr      x0, [x0, #0xa88]
0066BB47C  bl       #0x382bd14 ; 
0066BB480  mov      w8, #1
0066BB484  strb     w8, [x21, #0x273]
0066BB488  adrp     x8, #0x8f11000
0066BB48C  ldr      x8, [x8, #0xa88]
0066BB490  ldr      x1, [x8]
0066BB494  ldrb     w8, [x1, #0x53]
0066BB498  tbnz     w8, #5, #0x66bb4a4
0066BB49C  ldr      w0, [x19, #0x668]
0066BB4A0  b        #0x66bb4b0 ; 
0066BB4A4  ldr      x8, [x1, #0x60]
0066BB4A8  mov      x0, x19
0066BB4AC  blr      x8
0066BB4B0  str      w0, [x23, #0x50]
0066BB4B4  ldr      x0, [x19, #0x150]
0066BB4B8  cbz      x0, #0x66bb564
0066BB4BC  mov      x1, x23
0066BB4C0  mov      x2, xzr
0066BB4C4  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BB4C8  ldrb     w8, [x26, #0xa4b]
0066BB4CC  cbnz     w8, #0x66bb4e4
0066BB4D0  adrp     x0, #0x8ee5000
0066BB4D4  ldr      x0, [x0, #0xb28]
0066BB4D8  bl       #0x382bd14 ; 
0066BB4DC  mov      w8, #1
0066BB4E0  strb     w8, [x26, #0xa4b]
0066BB4E4  ldr      x1, [x25]
0066BB4E8  ldrb     w8, [x1, #0x53]
0066BB4EC  tbnz     w8, #5, #0x66bb4f8
0066BB4F0  ldr      x0, [x20, #0x20]
0066BB4F4  b        #0x66bb504 ; 
0066BB4F8  ldr      x8, [x1, #0x60]
0066BB4FC  mov      x0, x20
0066BB500  blr      x8
0066BB504  cbz      x0, #0x66bb54c
0066BB508  ldr      x8, [x0, #0x128]
0066BB50C  str      x8, [x19, #0x660]
0066BB510  ldr      x8, [x24, #0x28]
0066BB514  ldr      x9, [sp, #0x18]
0066BB518  cmp      x8, x9
0066BB51C  b.ne     #0x66bb568
0066BB520  ldp      x20, x19, [sp, #0x60]
0066BB524  ldp      x22, x21, [sp, #0x50]
0066BB528  ldp      x24, x23, [sp, #0x40]
0066BB52C  ldp      x26, x25, [sp, #0x30]
0066BB530  ldp      x30, x27, [sp, #0x20]
0066BB534  add      sp, sp, #0x70
0066BB538  ret      
0066BB53C  bl       #0x382bfb8 ; 
0066BB540  bl       #0x382bfb8 ; 
0066BB544  mov      x0, x19
0066BB548  bl       #0x382c354 ; 
0066BB54C  bl       #0x382bfb8 ; 
0066BB550  bl       #0x382bfb8 ; 
0066BB554  bl       #0x382bfb8 ; 
0066BB558  bl       #0x382bfb8 ; 
0066BB55C  bl       #0x382bfb8 ; 
0066BB560  bl       #0x382bfb8 ; 
0066BB564  bl       #0x382bfb8 ; 
0066BB568  bl       #0x89edb60 ; 
0066BB56C  b        #0x66bb5ac ; 
0066BB570  b        #0x66bb5ac ; 
0066BB574  b        #0x66bb5ac ; 
0066BB578  b        #0x66bb5ac ; 
0066BB57C  b        #0x66bb5ac ; 
0066BB580  b        #0x66bb5ac ; 
0066BB584  b        #0x66bb5ac ; 
0066BB588  b        #0x66bb5ac ; 
0066BB58C  b        #0x66bb5ac ; 
0066BB590  b        #0x66bb5ac ; 
0066BB594  b        #0x66bb5ac ; 
0066BB598  b        #0x66bb5ac ; 
0066BB59C  b        #0x66bb5ac ; 
0066BB5A0  b        #0x66bb5ac ; 
0066BB5A4  b        #0x66bb5ac ; 
0066BB5A8  b        #0x66bb5ac ; 
0066BB5AC  cmp      w1, #1
0066BB5B0  b.ne     #0x66bb5d0
0066BB5B4  bl       #0x89eda50 ; 
0066BB5B8  ldr      x19, [x0]
0066BB5BC  bl       #0x89eda60 ; 
0066BB5C0  cbz      x19, #0x66bb510
0066BB5C4  mov      x0, x19
0066BB5C8  bl       #0x382bfb0 ; 
0066BB5CC  cbnz     x19, #0x66bb5d4
0066BB5D0  bl       #0x3b56bfc ; 
0066BB5D4  mov      x0, x19
0066BB5D8  bl       #0x382bfb0 ; 
0066BB5DC  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleHitHealIfHero
; RVA 0x66BB5E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BB5E0  sub      sp, sp, #0xa0
0066BB5E4  str      x30, [sp, #0x50]
0066BB5E8  stp      x26, x25, [sp, #0x60]
0066BB5EC  stp      x24, x23, [sp, #0x70]
0066BB5F0  stp      x22, x21, [sp, #0x80]
0066BB5F4  stp      x20, x19, [sp, #0x90]
0066BB5F8  adrp     x23, #0x959a000
0066BB5FC  adrp     x24, #0x8f11000
0066BB600  ldrb     w8, [x23, #0x20f]
0066BB604  ldr      x24, [x24, #0xa90]
0066BB608  mov      x21, x3
0066BB60C  mov      x19, x2
0066BB610  mov      x22, x1
0066BB614  mov      x20, x0
0066BB618  tbnz     w8, #0, #0x66bb660
0066BB61C  adrp     x0, #0x8f11000
0066BB620  ldr      x0, [x0, #0xa90]
0066BB624  bl       #0x382bd14 ; 
0066BB628  adrp     x0, #0x8ee6000
0066BB62C  ldr      x0, [x0, #0xd8]
0066BB630  bl       #0x382bd14 ; 
0066BB634  adrp     x0, #0x8ee6000
0066BB638  ldr      x0, [x0, #0xe0]
0066BB63C  bl       #0x382bd14 ; 
0066BB640  adrp     x0, #0x8f09000
0066BB644  ldr      x0, [x0, #0x178]
0066BB648  bl       #0x382bd14 ; 
0066BB64C  adrp     x0, #0x8f11000
0066BB650  ldr      x0, [x0, #0xa98]
0066BB654  bl       #0x382bd14 ; 
0066BB658  mov      w8, #1
0066BB65C  strb     w8, [x23, #0x20f]
0066BB660  ldr      x4, [x24]
0066BB664  ldrb     w8, [x4, #0x53]
0066BB668  tbnz     w8, #5, #0x66bb68c
0066BB66C  cbz      x21, #0x66bb940
0066BB670  adrp     x8, #0x8ee6000
0066BB674  ldr      x8, [x8, #0xd8]
0066BB678  ldr      x1, [x8]
0066BB67C  ldrb     w8, [x1, #0x53]
0066BB680  tbnz     w8, #5, #0x66bb6bc
0066BB684  ldr      x0, [x21, #0x38]
0066BB688  b        #0x66bb6c8 ; 
0066BB68C  ldr      x5, [x4, #0x60]
0066BB690  mov      x0, x20
0066BB694  mov      x1, x22
0066BB698  mov      x2, x19
0066BB69C  mov      x3, x21
0066BB6A0  ldp      x20, x19, [sp, #0x90]
0066BB6A4  ldp      x22, x21, [sp, #0x80]
0066BB6A8  ldp      x24, x23, [sp, #0x70]
0066BB6AC  ldp      x26, x25, [sp, #0x60]
0066BB6B0  ldr      x30, [sp, #0x50]
0066BB6B4  add      sp, sp, #0xa0
0066BB6B8  br       x5
0066BB6BC  ldr      x8, [x1, #0x60]
0066BB6C0  mov      x0, x21
0066BB6C4  blr      x8
0066BB6C8  cbz      x0, #0x66bb944
0066BB6CC  mov      x1, xzr
0066BB6D0  bl       #0x45616a8 ; 
0066BB6D4  tbz      w0, #0, #0x66bb924
0066BB6D8  cbz      x22, #0x66bb948
0066BB6DC  mov      x0, x22
0066BB6E0  mov      x1, xzr
0066BB6E4  bl       #0x667ad78 ; HotFix.BattleLogic.BulletHurtInfo$$HitHealPercent
0066BB6E8  mov      x22, x0
0066BB6EC  cmp      x0, #1
0066BB6F0  b.lt     #0x66bb924
0066BB6F4  cbz      x19, #0x66bb94c
0066BB6F8  adrp     x8, #0x8ee6000
0066BB6FC  ldr      x8, [x8, #0xe0]
0066BB700  ldr      x1, [x8]
0066BB704  ldrb     w8, [x1, #0x53]
0066BB708  tbnz     w8, #5, #0x66bb714
0066BB70C  ldr      x23, [x19, #0x38]
0066BB710  b        #0x66bb724 ; 
0066BB714  ldr      x8, [x1, #0x60]
0066BB718  mov      x0, x19
0066BB71C  blr      x8
0066BB720  mov      x23, x0
0066BB724  cbz      x23, #0x66bb950
0066BB728  adrp     x24, #0x9591000
0066BB72C  ldrb     w8, [x24, #0xa72]
0066BB730  cbnz     w8, #0x66bb748
0066BB734  adrp     x0, #0x8ee6000
0066BB738  ldr      x0, [x0, #0x278]
0066BB73C  bl       #0x382bd14 ; 
0066BB740  mov      w8, #1
0066BB744  strb     w8, [x24, #0xa72]
0066BB748  adrp     x8, #0x8ee6000
0066BB74C  ldr      x8, [x8, #0x278]
0066BB750  ldr      x1, [x8]
0066BB754  ldrb     w8, [x1, #0x53]
0066BB758  tbnz     w8, #5, #0x66bb764
0066BB75C  ldr      x0, [x23, #0x180]
0066BB760  b        #0x66bb770 ; 
0066BB764  ldr      x8, [x1, #0x60]
0066BB768  mov      x0, x23
0066BB76C  blr      x8
0066BB770  cbz      x0, #0x66bb954
0066BB774  adrp     x8, #0x8f11000
0066BB778  ldr      x8, [x8, #0xa98]
0066BB77C  ldr      x1, [x8]
0066BB780  mov      x2, xzr
0066BB784  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
0066BB788  mov      x23, x0
0066BB78C  cmp      x0, #0
0066BB790  b.le     #0x66bb7e4
0066BB794  mov      x0, x19
0066BB798  mov      w1, wzr
0066BB79C  mov      x2, xzr
0066BB7A0  bl       #0x6681e24 ; HotFix.BattleLogic.EntityBullet$$GetExAttr
0066BB7A4  adrp     x25, #0x9591000
0066BB7A8  ldrb     w8, [x25, #0xa4b]
0066BB7AC  mov      x24, x0
0066BB7B0  cbnz     w8, #0x66bb7c8
0066BB7B4  adrp     x0, #0x8ee5000
0066BB7B8  ldr      x0, [x0, #0xb28]
0066BB7BC  bl       #0x382bd14 ; 
0066BB7C0  mov      w8, #1
0066BB7C4  strb     w8, [x25, #0xa4b]
0066BB7C8  adrp     x26, #0x8ee5000
0066BB7CC  ldr      x26, [x26, #0xb28]
0066BB7D0  ldr      x1, [x26]
0066BB7D4  ldrb     w8, [x1, #0x53]
0066BB7D8  tbnz     w8, #5, #0x66bb84c
0066BB7DC  ldr      x0, [x20, #0x20]
0066BB7E0  b        #0x66bb858 ; 
0066BB7E4  ldr      x19, [x21, #0x158]
0066BB7E8  mov      w0, #0xa
0066BB7EC  mov      x1, xzr
0066BB7F0  bl       #0x68e8874 ; HotFix.BattleLogic.HurtDeltaHpSourceInfo$$FromKind
0066BB7F4  adrp     x8, #0x8f09000
0066BB7F8  ldr      x8, [x8, #0x178]
0066BB7FC  mov      x2, x0
0066BB800  mov      x4, x1
0066BB804  stp      xzr, xzr, [sp, #0x38]
0066BB808  ldr      x3, [x8]
0066BB80C  str      xzr, [sp, #0x48]
0066BB810  add      x0, sp, #0x38
0066BB814  mov      x1, x2
0066BB818  mov      x2, x4
0066BB81C  bl       #0x51360ac ; System.Nullable<HurtDeltaHpSourceInfo>$$.ctor
0066BB820  cbz      x19, #0x66bb95c
0066BB824  ldur     q0, [sp, #0x38]
0066BB828  ldr      x8, [sp, #0x48]
0066BB82C  str      q0, [sp]
0066BB830  str      x8, [sp, #0x10]
0066BB834  mov      x3, sp
0066BB838  mov      x0, x19
0066BB83C  mov      x1, xzr
0066BB840  mov      x2, x22
0066BB844  bl       #0x66bc928 ; HotFix.BattleLogic.CharacterComponentOnHit$$HealSelfByPercent
0066BB848  b        #0x66bb924 ; 
0066BB84C  ldr      x8, [x1, #0x60]
0066BB850  mov      x0, x20
0066BB854  blr      x8
0066BB858  cbz      x0, #0x66bb958
0066BB85C  ldr      x8, [x0, #0x128]
0066BB860  sub      x8, x8, x24
0066BB864  cmp      x8, x23
0066BB868  b.le     #0x66bb924
0066BB86C  ldr      x21, [x21, #0x158]
0066BB870  mov      w0, #0xa
0066BB874  mov      x1, xzr
0066BB878  bl       #0x68e8874 ; HotFix.BattleLogic.HurtDeltaHpSourceInfo$$FromKind
0066BB87C  adrp     x8, #0x8f09000
0066BB880  ldr      x8, [x8, #0x178]
0066BB884  mov      x2, x0
0066BB888  mov      x4, x1
0066BB88C  stp      xzr, xzr, [sp, #0x38]
0066BB890  ldr      x3, [x8]
0066BB894  str      xzr, [sp, #0x48]
0066BB898  add      x0, sp, #0x38
0066BB89C  mov      x1, x2
0066BB8A0  mov      x2, x4
0066BB8A4  bl       #0x51360ac ; System.Nullable<HurtDeltaHpSourceInfo>$$.ctor
0066BB8A8  cbz      x21, #0x66bb960
0066BB8AC  ldur     q0, [sp, #0x38]
0066BB8B0  ldr      x8, [sp, #0x48]
0066BB8B4  str      q0, [sp, #0x20]
0066BB8B8  str      x8, [sp, #0x30]
0066BB8BC  add      x3, sp, #0x20
0066BB8C0  mov      x0, x21
0066BB8C4  mov      x1, xzr
0066BB8C8  mov      x2, x22
0066BB8CC  bl       #0x66bc928 ; HotFix.BattleLogic.CharacterComponentOnHit$$HealSelfByPercent
0066BB8D0  ldrb     w8, [x25, #0xa4b]
0066BB8D4  cbnz     w8, #0x66bb8ec
0066BB8D8  adrp     x0, #0x8ee5000
0066BB8DC  ldr      x0, [x0, #0xb28]
0066BB8E0  bl       #0x382bd14 ; 
0066BB8E4  mov      w8, #1
0066BB8E8  strb     w8, [x25, #0xa4b]
0066BB8EC  ldr      x1, [x26]
0066BB8F0  ldrb     w8, [x1, #0x53]
0066BB8F4  tbnz     w8, #5, #0x66bb900
0066BB8F8  ldr      x0, [x20, #0x20]
0066BB8FC  b        #0x66bb90c ; 
0066BB900  ldr      x8, [x1, #0x60]
0066BB904  mov      x0, x20
0066BB908  blr      x8
0066BB90C  cbz      x0, #0x66bb964
0066BB910  ldr      x2, [x0, #0x128]
0066BB914  mov      x0, x19
0066BB918  mov      w1, wzr
0066BB91C  mov      x3, xzr
0066BB920  bl       #0x6681ebc ; HotFix.BattleLogic.EntityBullet$$SetExAttr
0066BB924  ldp      x20, x19, [sp, #0x90]
0066BB928  ldp      x22, x21, [sp, #0x80]
0066BB92C  ldp      x24, x23, [sp, #0x70]
0066BB930  ldp      x26, x25, [sp, #0x60]
0066BB934  ldr      x30, [sp, #0x50]
0066BB938  add      sp, sp, #0xa0
0066BB93C  ret      
0066BB940  bl       #0x382bfb8 ; 
0066BB944  bl       #0x382bfb8 ; 
0066BB948  bl       #0x382bfb8 ; 
0066BB94C  bl       #0x382bfb8 ; 
0066BB950  bl       #0x382bfb8 ; 
0066BB954  bl       #0x382bfb8 ; 
0066BB958  bl       #0x382bfb8 ; 
0066BB95C  bl       #0x382bfb8 ; 
0066BB960  bl       #0x382bfb8 ; 
0066BB964  bl       #0x382bfb8 ; 
0066BB968  b        #0x66bb9a8 ; 
0066BB96C  b        #0x66bb9a8 ; 
0066BB970  b        #0x66bb9a8 ; 
0066BB974  b        #0x66bb9a8 ; 
0066BB978  b        #0x66bb9a8 ; 
0066BB97C  b        #0x66bb9a8 ; 
0066BB980  b        #0x66bb9a8 ; 
0066BB984  b        #0x66bb9a8 ; 
0066BB988  b        #0x66bb9a8 ; 
0066BB98C  b        #0x66bb9a8 ; 
0066BB990  b        #0x66bb9a8 ; 
0066BB994  b        #0x66bb9a8 ; 
0066BB998  b        #0x66bb9a8 ; 
0066BB99C  b        #0x66bb9a8 ; 
0066BB9A0  b        #0x66bb9a8 ; 
0066BB9A4  b        #0x66bb9a8 ; 
0066BB9A8  cmp      w1, #1
0066BB9AC  b.ne     #0x66bb9cc
0066BB9B0  bl       #0x89eda50 ; 
0066BB9B4  ldr      x19, [x0]
0066BB9B8  bl       #0x89eda60 ; 
0066BB9BC  cbz      x19, #0x66bb924
0066BB9C0  mov      x0, x19
0066BB9C4  bl       #0x382bfb0 ; 
0066BB9C8  cbnz     x19, #0x66bb9d0
0066BB9CC  bl       #0x3b56bfc ; 
0066BB9D0  mov      x0, x19
0066BB9D4  bl       #0x382bfb0 ; 
0066BB9D8  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$ApplyBulletDamageAndEffects
; RVA 0x66B862C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B862C  sub      sp, sp, #0x110
0066B8630  stp      x29, x30, [sp, #0xb0]
0066B8634  stp      x28, x27, [sp, #0xc0]
0066B8638  stp      x26, x25, [sp, #0xd0]
0066B863C  stp      x24, x23, [sp, #0xe0]
0066B8640  stp      x22, x21, [sp, #0xf0]
0066B8644  stp      x20, x19, [sp, #0x100]
0066B8648  mrs      x8, tpidr_el0
0066B864C  stp      x7, x8, [sp, #0x28]
0066B8650  ldr      x8, [x8, #0x28]
0066B8654  adrp     x25, #0x959a000
0066B8658  adrp     x24, #0x8f11000
0066B865C  mov      x27, x6
0066B8660  str      x8, [sp, #0xa8]
0066B8664  ldrb     w8, [x25, #0x210]
0066B8668  ldr      x24, [x24, #0x9b8]
0066B866C  mov      x19, x5
0066B8670  mov      w23, w4
0066B8674  mov      x28, x3
0066B8678  mov      x21, x2
0066B867C  mov      x20, x1
0066B8680  mov      x22, x0
0066B8684  tbnz     w8, #0, #0x66b86c0
0066B8688  adrp     x0, #0x8f11000
0066B868C  ldr      x0, [x0, #0x9b8]
0066B8690  bl       #0x382bd14 ; 
0066B8694  adrp     x0, #0x8ee6000
0066B8698  ldr      x0, [x0, #0xe0]
0066B869C  bl       #0x382bd14 ; 
0066B86A0  adrp     x0, #0x8ee6000
0066B86A4  ldr      x0, [x0, #0xf0]
0066B86A8  bl       #0x382bd14 ; 
0066B86AC  adrp     x0, #0x8ee6000
0066B86B0  ldr      x0, [x0, #0x600]
0066B86B4  bl       #0x382bd14 ; 
0066B86B8  mov      w8, #1
0066B86BC  strb     w8, [x25, #0x210]
0066B86C0  ldr      x8, [x24]
0066B86C4  ldp      x26, x25, [sp, #0x110]
0066B86C8  ldrb     w9, [x8, #0x53]
0066B86CC  tbnz     w9, #5, #0x66b86f8
0066B86D0  strb     wzr, [sp, #0x3c]
0066B86D4  str      wzr, [sp, #0x38]
0066B86D8  cbz      x21, #0x66b8a00
0066B86DC  adrp     x24, #0x8ee6000
0066B86E0  ldr      x24, [x24, #0xe0]
0066B86E4  ldr      x1, [x24]
0066B86E8  ldrb     w8, [x1, #0x53]
0066B86EC  tbnz     w8, #5, #0x66b872c
0066B86F0  ldr      x0, [x21, #0x38]
0066B86F4  b        #0x66b8738 ; 
0066B86F8  ldr      x9, [x8, #0x60]
0066B86FC  ldr      x7, [sp, #0x28]
0066B8700  mov      x0, x22
0066B8704  mov      x1, x20
0066B8708  mov      x2, x21
0066B870C  mov      x3, x28
0066B8710  mov      w4, w23
0066B8714  mov      x5, x19
0066B8718  mov      x6, x27
0066B871C  stp      x25, x8, [sp, #8]
0066B8720  str      x26, [sp]
0066B8724  blr      x9
0066B8728  b        #0x66b89cc ; 
0066B872C  ldr      x8, [x1, #0x60]
0066B8730  mov      x0, x21
0066B8734  blr      x8
0066B8738  cbz      x0, #0x66b8a04
0066B873C  add      x8, sp, #0x78
0066B8740  mov      x1, xzr
0066B8744  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066B8748  adrp     x9, #0x8ee6000
0066B874C  ldur     q0, [sp, #0x78]
0066B8750  ldr      x8, [sp, #0x88]
0066B8754  ldr      x9, [x9, #0xf0]
0066B8758  str      q0, [sp, #0x90]
0066B875C  str      x8, [sp, #0xa0]
0066B8760  ldr      x1, [x9]
0066B8764  ldrb     w8, [x1, #0x53]
0066B8768  tbnz     w8, #5, #0x66b8774
0066B876C  ldr      x28, [x21, #0x28]
0066B8770  b        #0x66b8784 ; 
0066B8774  ldr      x8, [x1, #0x60]
0066B8778  mov      x0, x21
0066B877C  blr      x8
0066B8780  mov      x28, x0
0066B8784  ldr      x1, [x24]
0066B8788  ldrb     w8, [x1, #0x53]
0066B878C  tbnz     w8, #5, #0x66b8798
0066B8790  ldr      x29, [x21, #0x38]
0066B8794  b        #0x66b87a8 ; 
0066B8798  ldr      x8, [x1, #0x60]
0066B879C  mov      x0, x21
0066B87A0  blr      x8
0066B87A4  mov      x29, x0
0066B87A8  cbz      x29, #0x66b8a08
0066B87AC  adrp     x24, #0x959a000
0066B87B0  ldrb     w8, [x24, #0xc2]
0066B87B4  cbnz     w8, #0x66b87cc
0066B87B8  adrp     x0, #0x8f0f000
0066B87BC  ldr      x0, [x0, #0x9a8]
0066B87C0  bl       #0x382bd14 ; 
0066B87C4  mov      w8, #1
0066B87C8  strb     w8, [x24, #0xc2]
0066B87CC  adrp     x8, #0x8f0f000
0066B87D0  ldr      x8, [x8, #0x9a8]
0066B87D4  ldr      x1, [x8]
0066B87D8  ldrb     w8, [x1, #0x53]
0066B87DC  tbnz     w8, #5, #0x66b87e8
0066B87E0  ldr      w0, [x29, #0x11c]
0066B87E4  b        #0x66b87f4 ; 
0066B87E8  ldr      x8, [x1, #0x60]
0066B87EC  mov      x0, x29
0066B87F0  blr      x8
0066B87F4  ldr      q0, [sp, #0x90]
0066B87F8  ldr      x8, [sp, #0xa0]
0066B87FC  ubfx     w3, w23, #0xd, #1
0066B8800  str      q0, [sp, #0x60]
0066B8804  str      x8, [sp, #0x70]
0066B8808  add      x4, sp, #0x3c
0066B880C  add      x5, sp, #0x38
0066B8810  add      x6, sp, #0x60
0066B8814  str      w0, [sp]
0066B8818  mov      x0, x22
0066B881C  mov      x1, x19
0066B8820  mov      x2, x27
0066B8824  mov      x7, x28
0066B8828  bl       #0x66bca88 ; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitUpdateHP
0066B882C  adrp     x29, #0x9591000
0066B8830  ldrb     w8, [x29, #0xa4b]
0066B8834  mov      w28, w0
0066B8838  cbnz     w8, #0x66b8850
0066B883C  adrp     x0, #0x8ee5000
0066B8840  ldr      x0, [x0, #0xb28]
0066B8844  bl       #0x382bd14 ; 
0066B8848  mov      w8, #1
0066B884C  strb     w8, [x29, #0xa4b]
0066B8850  adrp     x24, #0x8ee5000
0066B8854  ldr      x24, [x24, #0xb28]
0066B8858  ldr      x1, [x24]
0066B885C  ldrb     w8, [x1, #0x53]
0066B8860  tbnz     w8, #5, #0x66b886c
0066B8864  ldr      x0, [x22, #0x20]
0066B8868  b        #0x66b8878 ; 
0066B886C  ldr      x8, [x1, #0x60]
0066B8870  mov      x0, x22
0066B8874  blr      x8
0066B8878  cbz      x0, #0x66b8a0c
0066B887C  mov      x1, x27
0066B8880  mov      x2, xzr
0066B8884  bl       #0x69faa68 ; HotFix.BattleLogic.BattleWorldContext$$PushHurtDataArray
0066B8888  tbz      w28, #0, #0x66b88ac
0066B888C  mov      x0, x22
0066B8890  mov      x1, x20
0066B8894  bl       #0x66bcf3c ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleMissTriggerOnBullet
0066B8898  cbz      x19, #0x66b8a14
0066B889C  mov      x0, x19
0066B88A0  mov      x1, xzr
0066B88A4  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066B88A8  b        #0x66b89cc ; 
0066B88AC  adrp     x8, #0x8ee6000
0066B88B0  ldr      x8, [x8, #0x600]
0066B88B4  ldr      x1, [x8]
0066B88B8  ldrb     w8, [x1, #0x53]
0066B88BC  tbnz     w8, #5, #0x66b88c8
0066B88C0  ldr      x0, [x22, #0x38]
0066B88C4  b        #0x66b88d4 ; 
0066B88C8  ldr      x8, [x1, #0x60]
0066B88CC  mov      x0, x22
0066B88D0  blr      x8
0066B88D4  cbz      x0, #0x66b8a10
0066B88D8  mov      x1, xzr
0066B88DC  bl       #0x45616a8 ; 
0066B88E0  tbz      w0, #0, #0x66b892c
0066B88E4  ldrb     w8, [x29, #0xa4b]
0066B88E8  cbnz     w8, #0x66b8900
0066B88EC  adrp     x0, #0x8ee5000
0066B88F0  ldr      x0, [x0, #0xb28]
0066B88F4  bl       #0x382bd14 ; 
0066B88F8  mov      w8, #1
0066B88FC  strb     w8, [x29, #0xa4b]
0066B8900  ldr      x1, [x24]
0066B8904  ldrb     w8, [x1, #0x53]
0066B8908  tbnz     w8, #5, #0x66b8914
0066B890C  ldr      x0, [x22, #0x20]
0066B8910  b        #0x66b8920 ; 
0066B8914  ldr      x8, [x1, #0x60]
0066B8918  mov      x0, x22
0066B891C  blr      x8
0066B8920  cbz      x0, #0x66b8a20
0066B8924  mov      x1, xzr
0066B8928  bl       #0x66c6138 ; 
0066B892C  mov      x0, x22
0066B8930  mov      x1, x20
0066B8934  bl       #0x66bd474 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePostHitVisuals
0066B8938  ldrb     w6, [sp, #0x3c]
0066B893C  ldr      x2, [sp, #0x28]
0066B8940  mov      x0, x22
0066B8944  mov      x1, x20
0066B8948  mov      x3, x26
0066B894C  mov      x4, x25
0066B8950  mov      x5, x21
0066B8954  bl       #0x66bd524 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleCritLogic
0066B8958  cbz      x20, #0x66b8a18
0066B895C  ldr      x8, [x20, #0x68]
0066B8960  ldur     q0, [x20, #0x58]
0066B8964  str      x8, [sp, #0x50]
0066B8968  str      q0, [sp, #0x40]
0066B896C  add      x1, sp, #0x40
0066B8970  mov      w2, #1
0066B8974  mov      x0, x22
0066B8978  bl       #0x66bda9c ; HotFix.BattleLogic.CharacterComponentOnHit$$DispatchDamageRenderEvent
0066B897C  mov      x0, x22
0066B8980  mov      x1, x20
0066B8984  mov      x2, x21
0066B8988  bl       #0x66bddd0 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBulletHitEnemy
0066B898C  ldr      w5, [sp, #0x38]
0066B8990  mov      w1, #0x19
0066B8994  mov      x0, x22
0066B8998  mov      x2, x20
0066B899C  mov      x3, x21
0066B89A0  mov      w4, w23
0066B89A4  mov      x6, x19
0066B89A8  bl       #0x66b8350 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBulletHitEventToBullet
0066B89AC  cbz      x19, #0x66b8a1c
0066B89B0  mov      x0, x19
0066B89B4  mov      x1, xzr
0066B89B8  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066B89BC  mov      x0, x22
0066B89C0  mov      x1, x20
0066B89C4  mov      x2, x21
0066B89C8  bl       #0x66be064 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandleHitBack
0066B89CC  ldr      x8, [sp, #0x30]
0066B89D0  ldr      x8, [x8, #0x28]
0066B89D4  ldr      x9, [sp, #0xa8]
0066B89D8  cmp      x8, x9
0066B89DC  b.ne     #0x66b8a24
0066B89E0  ldp      x20, x19, [sp, #0x100]
0066B89E4  ldp      x22, x21, [sp, #0xf0]
0066B89E8  ldp      x24, x23, [sp, #0xe0]
0066B89EC  ldp      x26, x25, [sp, #0xd0]
0066B89F0  ldp      x28, x27, [sp, #0xc0]
0066B89F4  ldp      x29, x30, [sp, #0xb0]
0066B89F8  add      sp, sp, #0x110
0066B89FC  ret      
0066B8A00  bl       #0x382bfb8 ; 
0066B8A04  bl       #0x382bfb8 ; 
0066B8A08  bl       #0x382bfb8 ; 
0066B8A0C  bl       #0x382bfb8 ; 
0066B8A10  bl       #0x382bfb8 ; 
0066B8A14  bl       #0x382bfb8 ; 
0066B8A18  bl       #0x382bfb8 ; 
0066B8A1C  bl       #0x382bfb8 ; 
0066B8A20  bl       #0x382bfb8 ; 
0066B8A24  bl       #0x89edb60 ; 
0066B8A28  b        #0x66b8a7c ; 
0066B8A2C  b        #0x66b8a7c ; 
0066B8A30  b        #0x66b8a7c ; 
0066B8A34  b        #0x66b8a7c ; 
0066B8A38  b        #0x66b8a7c ; 
0066B8A3C  b        #0x66b8a7c ; 
0066B8A40  b        #0x66b8a7c ; 
0066B8A44  b        #0x66b8a7c ; 
0066B8A48  b        #0x66b8a7c ; 
0066B8A4C  b        #0x66b8a7c ; 
0066B8A50  b        #0x66b8a7c ; 
0066B8A54  b        #0x66b8a7c ; 
0066B8A58  b        #0x66b8a7c ; 
0066B8A5C  b        #0x66b8a7c ; 
0066B8A60  b        #0x66b8a7c ; 
0066B8A64  b        #0x66b8a7c ; 
0066B8A68  b        #0x66b8a7c ; 
0066B8A6C  b        #0x66b8a7c ; 
0066B8A70  b        #0x66b8a7c ; 
0066B8A74  b        #0x66b8a7c ; 
0066B8A78  b        #0x66b8a7c ; 
0066B8A7C  cmp      w1, #1
0066B8A80  b.ne     #0x66b8aa0
0066B8A84  bl       #0x89eda50 ; 
0066B8A88  ldr      x19, [x0]
0066B8A8C  bl       #0x89eda60 ; 
0066B8A90  cbz      x19, #0x66b89cc
0066B8A94  mov      x0, x19
0066B8A98  bl       #0x382bfb0 ; 
0066B8A9C  cbnz     x19, #0x66b8aa4
0066B8AA0  bl       #0x3b56bfc ; 
0066B8AA4  mov      x0, x19
0066B8AA8  bl       #0x382bfb0 ; 
0066B8AAC  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleMissTriggerOnBullet
; RVA 0x66BCF3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BCF3C  sub      sp, sp, #0x80
0066BCF40  stp      x30, x25, [sp, #0x40]
0066BCF44  stp      x24, x23, [sp, #0x50]
0066BCF48  stp      x22, x21, [sp, #0x60]
0066BCF4C  stp      x20, x19, [sp, #0x70]
0066BCF50  mrs      x23, tpidr_el0
0066BCF54  ldr      x8, [x23, #0x28]
0066BCF58  adrp     x21, #0x959a000
0066BCF5C  adrp     x22, #0x8f11000
0066BCF60  mov      x20, x1
0066BCF64  str      x8, [sp, #0x38]
0066BCF68  ldrb     w8, [x21, #0x211]
0066BCF6C  ldr      x22, [x22, #0xb38]
0066BCF70  mov      x19, x0
0066BCF74  tbnz     w8, #0, #0x66bcfb0
0066BCF78  adrp     x0, #0x8f11000
0066BCF7C  ldr      x0, [x0, #0xb38]
0066BCF80  bl       #0x382bd14 ; 
0066BCF84  adrp     x0, #0x8ee6000
0066BCF88  ldr      x0, [x0, #0x600]
0066BCF8C  bl       #0x382bd14 ; 
0066BCF90  adrp     x0, #0x8ee6000
0066BCF94  ldr      x0, [x0, #0x608]
0066BCF98  bl       #0x382bd14 ; 
0066BCF9C  adrp     x0, #0x8f11000
0066BCFA0  ldr      x0, [x0, #0xb40]
0066BCFA4  bl       #0x382bd14 ; 
0066BCFA8  mov      w8, #1
0066BCFAC  strb     w8, [x21, #0x211]
0066BCFB0  ldr      x2, [x22]
0066BCFB4  ldrb     w8, [x2, #0x53]
0066BCFB8  tbnz     w8, #5, #0x66bcfd8
0066BCFBC  adrp     x24, #0x8ee6000
0066BCFC0  ldr      x24, [x24, #0x608]
0066BCFC4  ldr      x1, [x24]
0066BCFC8  ldrb     w8, [x1, #0x53]
0066BCFCC  tbnz     w8, #5, #0x66bcfec
0066BCFD0  ldr      x21, [x19, #0x30]
0066BCFD4  b        #0x66bcffc ; 
0066BCFD8  ldr      x8, [x2, #0x60]
0066BCFDC  mov      x0, x19
0066BCFE0  mov      x1, x20
0066BCFE4  blr      x8
0066BCFE8  b        #0x66bd444 ; 
0066BCFEC  ldr      x8, [x1, #0x60]
0066BCFF0  mov      x0, x19
0066BCFF4  blr      x8
0066BCFF8  mov      x21, x0
0066BCFFC  cbz      x21, #0x66bd46c
0066BD000  adrp     x22, #0x9591000
0066BD004  ldrb     w8, [x22, #0xa86]
0066BD008  cbnz     w8, #0x66bd02c
0066BD00C  adrp     x0, #0x8ee6000
0066BD010  ldr      x0, [x0, #0x318]
0066BD014  bl       #0x382bd14 ; 
0066BD018  adrp     x0, #0x8ee3000
0066BD01C  ldr      x0, [x0, #0xf18]
0066BD020  bl       #0x382bd14 ; 
0066BD024  mov      w8, #1
0066BD028  strb     w8, [x22, #0xa86]
0066BD02C  adrp     x8, #0x8ee6000
0066BD030  ldr      x8, [x8, #0x318]
0066BD034  ldr      x2, [x8]
0066BD038  ldrb     w8, [x2, #0x53]
0066BD03C  tbnz     w8, #5, #0x66bd064
0066BD040  ldr      x0, [x21, #0x190]
0066BD044  cbz      x0, #0x66bd244
0066BD048  adrp     x8, #0x8ee3000
0066BD04C  ldr      x8, [x8, #0xf18]
0066BD050  mov      w1, #0xd
0066BD054  ldr      x2, [x8]
0066BD058  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066BD05C  tbnz     w0, #0, #0x66bd078
0066BD060  b        #0x66bd244 ; 
0066BD064  ldr      x8, [x2, #0x60]
0066BD068  mov      w1, #0xd
0066BD06C  mov      x0, x21
0066BD070  blr      x8
0066BD074  tbz      w0, #0, #0x66bd244
0066BD078  adrp     x21, #0x9591000
0066BD07C  ldrb     w8, [x21, #0xa4b]
0066BD080  cbnz     w8, #0x66bd098
0066BD084  adrp     x0, #0x8ee5000
0066BD088  ldr      x0, [x0, #0xb28]
0066BD08C  bl       #0x382bd14 ; 
0066BD090  mov      w8, #1
0066BD094  strb     w8, [x21, #0xa4b]
0066BD098  adrp     x8, #0x8ee5000
0066BD09C  ldr      x8, [x8, #0xb28]
0066BD0A0  ldr      x1, [x8]
0066BD0A4  ldrb     w8, [x1, #0x53]
0066BD0A8  tbnz     w8, #5, #0x66bd0b4
0066BD0AC  ldr      x21, [x19, #0x20]
0066BD0B0  b        #0x66bd0c4 ; 
0066BD0B4  ldr      x8, [x1, #0x60]
0066BD0B8  mov      x0, x19
0066BD0BC  blr      x8
0066BD0C0  mov      x21, x0
0066BD0C4  cbz      x21, #0x66bd46c
0066BD0C8  adrp     x22, #0x9591000
0066BD0CC  ldrb     w8, [x22, #0xa4c]
0066BD0D0  cbnz     w8, #0x66bd0e8
0066BD0D4  adrp     x0, #0x8ee5000
0066BD0D8  ldr      x0, [x0, #0xb30]
0066BD0DC  bl       #0x382bd14 ; 
0066BD0E0  mov      w8, #1
0066BD0E4  strb     w8, [x22, #0xa4c]
0066BD0E8  adrp     x8, #0x8ee5000
0066BD0EC  ldr      x8, [x8, #0xb30]
0066BD0F0  ldr      x1, [x8]
0066BD0F4  ldrb     w8, [x1, #0x53]
0066BD0F8  tbnz     w8, #5, #0x66bd104
0066BD0FC  ldr      x0, [x21, #0x210]
0066BD100  b        #0x66bd110 ; 
0066BD104  ldr      x8, [x1, #0x60]
0066BD108  mov      x0, x21
0066BD10C  blr      x8
0066BD110  cbz      x0, #0x66bd46c
0066BD114  adrp     x8, #0x8f11000
0066BD118  ldr      x8, [x8, #0xb40]
0066BD11C  ldr      x1, [x8]
0066BD120  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BD124  adrp     x22, #0x8ee6000
0066BD128  ldr      x22, [x22, #0x600]
0066BD12C  mov      x21, x0
0066BD130  ldr      x1, [x22]
0066BD134  ldrb     w8, [x1, #0x53]
0066BD138  tbnz     w8, #5, #0x66bd144
0066BD13C  ldr      x0, [x19, #0x38]
0066BD140  b        #0x66bd150 ; 
0066BD144  ldr      x8, [x1, #0x60]
0066BD148  mov      x0, x19
0066BD14C  blr      x8
0066BD150  cbz      x0, #0x66bd46c
0066BD154  add      x8, sp, #8
0066BD158  mov      x1, xzr
0066BD15C  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066BD160  ldur     q0, [sp, #8]
0066BD164  ldr      x8, [sp, #0x18]
0066BD168  str      q0, [sp, #0x20]
0066BD16C  str      x8, [sp, #0x30]
0066BD170  cbz      x21, #0x66bd46c
0066BD174  ldr      x8, [sp, #0x30]
0066BD178  ldr      q0, [sp, #0x20]
0066BD17C  str      x8, [x21, #0x30]
0066BD180  str      q0, [x21, #0x20]
0066BD184  cbz      x20, #0x66bd46c
0066BD188  mov      x0, x20
0066BD18C  mov      x1, xzr
0066BD190  bl       #0x667b324 ; HotFix.BattleLogic.BulletHurtInfo$$OwnerInstanceId
0066BD194  str      x0, [x21, #0x38]
0066BD198  ldr      x1, [x22]
0066BD19C  ldrb     w8, [x1, #0x53]
0066BD1A0  tbnz     w8, #5, #0x66bd1ac
0066BD1A4  ldr      x22, [x19, #0x38]
0066BD1A8  b        #0x66bd1bc ; 
0066BD1AC  ldr      x8, [x1, #0x60]
0066BD1B0  mov      x0, x19
0066BD1B4  blr      x8
0066BD1B8  mov      x22, x0
0066BD1BC  cbz      x22, #0x66bd46c
0066BD1C0  adrp     x25, #0x9592000
0066BD1C4  ldrb     w8, [x25, #0x473]
0066BD1C8  cbnz     w8, #0x66bd1e0
0066BD1CC  adrp     x0, #0x8ee8000
0066BD1D0  ldr      x0, [x0, #0x890]
0066BD1D4  bl       #0x382bd14 ; 
0066BD1D8  mov      w8, #1
0066BD1DC  strb     w8, [x25, #0x473]
0066BD1E0  adrp     x8, #0x8ee8000
0066BD1E4  ldr      x8, [x8, #0x890]
0066BD1E8  ldr      x1, [x8]
0066BD1EC  ldrb     w8, [x1, #0x53]
0066BD1F0  tbnz     w8, #5, #0x66bd1fc
0066BD1F4  ldr      x0, [x22, #0x20]
0066BD1F8  b        #0x66bd208 ; 
0066BD1FC  ldr      x8, [x1, #0x60]
0066BD200  mov      x0, x22
0066BD204  blr      x8
0066BD208  str      x0, [x21, #0x48]
0066BD20C  ldr      x1, [x24]
0066BD210  ldrb     w8, [x1, #0x53]
0066BD214  tbnz     w8, #5, #0x66bd220
0066BD218  ldr      x0, [x19, #0x30]
0066BD21C  b        #0x66bd22c ; 
0066BD220  ldr      x8, [x1, #0x60]
0066BD224  mov      x0, x19
0066BD228  blr      x8
0066BD22C  cbz      x0, #0x66bd46c
0066BD230  ldr      x0, [x0, #0x150]
0066BD234  cbz      x0, #0x66bd46c
0066BD238  mov      x1, x21
0066BD23C  mov      x2, xzr
0066BD240  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BD244  adrp     x22, #0x8ee6000
0066BD248  ldr      x22, [x22, #0x600]
0066BD24C  ldr      x1, [x22]
0066BD250  ldrb     w8, [x1, #0x53]
0066BD254  tbnz     w8, #5, #0x66bd260
0066BD258  ldr      x0, [x19, #0x38]
0066BD25C  b        #0x66bd26c ; 
0066BD260  ldr      x8, [x1, #0x60]
0066BD264  mov      x0, x19
0066BD268  blr      x8
0066BD26C  cbz      x0, #0x66bd46c
0066BD270  mov      x1, xzr
0066BD274  bl       #0x45616a8 ; 
0066BD278  tbz      w0, #0, #0x66bd444
0066BD27C  adrp     x21, #0x9591000
0066BD280  ldrb     w8, [x21, #0xa4b]
0066BD284  cbnz     w8, #0x66bd29c
0066BD288  adrp     x0, #0x8ee5000
0066BD28C  ldr      x0, [x0, #0xb28]
0066BD290  bl       #0x382bd14 ; 
0066BD294  mov      w8, #1
0066BD298  strb     w8, [x21, #0xa4b]
0066BD29C  adrp     x8, #0x8ee5000
0066BD2A0  ldr      x8, [x8, #0xb28]
0066BD2A4  ldr      x1, [x8]
0066BD2A8  ldrb     w8, [x1, #0x53]
0066BD2AC  tbnz     w8, #5, #0x66bd2b8
0066BD2B0  ldr      x21, [x19, #0x20]
0066BD2B4  b        #0x66bd2c8 ; 
0066BD2B8  ldr      x8, [x1, #0x60]
0066BD2BC  mov      x0, x19
0066BD2C0  blr      x8
0066BD2C4  mov      x21, x0
0066BD2C8  cbz      x21, #0x66bd46c
0066BD2CC  adrp     x25, #0x9591000
0066BD2D0  ldrb     w8, [x25, #0xa4c]
0066BD2D4  cbnz     w8, #0x66bd2ec
0066BD2D8  adrp     x0, #0x8ee5000
0066BD2DC  ldr      x0, [x0, #0xb30]
0066BD2E0  bl       #0x382bd14 ; 
0066BD2E4  mov      w8, #1
0066BD2E8  strb     w8, [x25, #0xa4c]
0066BD2EC  adrp     x8, #0x8ee5000
0066BD2F0  ldr      x8, [x8, #0xb30]
0066BD2F4  ldr      x1, [x8]
0066BD2F8  ldrb     w8, [x1, #0x53]
0066BD2FC  tbnz     w8, #5, #0x66bd308
0066BD300  ldr      x0, [x21, #0x210]
0066BD304  b        #0x66bd314 ; 
0066BD308  ldr      x8, [x1, #0x60]
0066BD30C  mov      x0, x21
0066BD310  blr      x8
0066BD314  cbz      x0, #0x66bd46c
0066BD318  adrp     x8, #0x8f11000
0066BD31C  ldr      x8, [x8, #0xb40]
0066BD320  ldr      x1, [x8]
0066BD324  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BD328  ldr      x1, [x22]
0066BD32C  mov      x21, x0
0066BD330  ldrb     w8, [x1, #0x53]
0066BD334  tbnz     w8, #5, #0x66bd340
0066BD338  ldr      x0, [x19, #0x38]
0066BD33C  b        #0x66bd34c ; 
0066BD340  ldr      x8, [x1, #0x60]
0066BD344  mov      x0, x19
0066BD348  blr      x8
0066BD34C  cbz      x0, #0x66bd46c
0066BD350  add      x8, sp, #8
0066BD354  mov      x1, xzr
0066BD358  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066BD35C  ldur     q0, [sp, #8]
0066BD360  ldr      x8, [sp, #0x18]
0066BD364  str      q0, [sp, #0x20]
0066BD368  str      x8, [sp, #0x30]
0066BD36C  cbz      x21, #0x66bd46c
0066BD370  ldr      x8, [sp, #0x30]
0066BD374  ldr      q0, [sp, #0x20]
0066BD378  str      x8, [x21, #0x30]
0066BD37C  str      q0, [x21, #0x20]
0066BD380  cbz      x20, #0x66bd46c
0066BD384  mov      x0, x20
0066BD388  mov      x1, xzr
0066BD38C  bl       #0x667b324 ; HotFix.BattleLogic.BulletHurtInfo$$OwnerInstanceId
0066BD390  str      x0, [x21, #0x38]
0066BD394  ldr      x1, [x22]
0066BD398  ldrb     w8, [x1, #0x53]
0066BD39C  tbnz     w8, #5, #0x66bd3a8
0066BD3A0  ldr      x20, [x19, #0x38]
0066BD3A4  b        #0x66bd3b8 ; 
0066BD3A8  ldr      x8, [x1, #0x60]
0066BD3AC  mov      x0, x19
0066BD3B0  blr      x8
0066BD3B4  mov      x20, x0
0066BD3B8  cbz      x20, #0x66bd46c
0066BD3BC  adrp     x22, #0x9592000
0066BD3C0  ldrb     w8, [x22, #0x473]
0066BD3C4  cbnz     w8, #0x66bd3dc
0066BD3C8  adrp     x0, #0x8ee8000
0066BD3CC  ldr      x0, [x0, #0x890]
0066BD3D0  bl       #0x382bd14 ; 
0066BD3D4  mov      w8, #1
0066BD3D8  strb     w8, [x22, #0x473]
0066BD3DC  adrp     x8, #0x8ee8000
0066BD3E0  ldr      x8, [x8, #0x890]
0066BD3E4  ldr      x1, [x8]
0066BD3E8  ldrb     w8, [x1, #0x53]
0066BD3EC  tbnz     w8, #5, #0x66bd3f8
0066BD3F0  ldr      x0, [x20, #0x20]
0066BD3F4  b        #0x66bd404 ; 
0066BD3F8  ldr      x8, [x1, #0x60]
0066BD3FC  mov      x0, x20
0066BD400  blr      x8
0066BD404  str      x0, [x21, #0x48]
0066BD408  ldr      x1, [x24]
0066BD40C  ldrb     w8, [x1, #0x53]
0066BD410  tbnz     w8, #5, #0x66bd41c
0066BD414  ldr      x0, [x19, #0x30]
0066BD418  b        #0x66bd428 ; 
0066BD41C  ldr      x8, [x1, #0x60]
0066BD420  mov      x0, x19
0066BD424  blr      x8
0066BD428  cbz      x0, #0x66bd46c
0066BD42C  mov      x1, x21
0066BD430  mov      x2, xzr
0066BD434  bl       #0x67e4278 ; HotFix.BattleLogic.EntityCharacter$$RaiseHeroMissEvent
0066BD438  mov      x0, x19
0066BD43C  mov      x1, x21
0066BD440  bl       #0x66be50c ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroMiss
0066BD444  ldr      x8, [x23, #0x28]
0066BD448  ldr      x9, [sp, #0x38]
0066BD44C  cmp      x8, x9
0066BD450  b.ne     #0x66bd470
0066BD454  ldp      x20, x19, [sp, #0x70]
0066BD458  ldp      x22, x21, [sp, #0x60]
0066BD45C  ldp      x24, x23, [sp, #0x50]
0066BD460  ldp      x30, x25, [sp, #0x40]
0066BD464  add      sp, sp, #0x80
0066BD468  ret      
0066BD46C  bl       #0x382bfb8 ; 
0066BD470  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePostHitVisuals
; RVA 0x66BD474; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BD474  str      x30, [sp, #-0x30]!
0066BD478  stp      x22, x21, [sp, #0x10]
0066BD47C  stp      x20, x19, [sp, #0x20]
0066BD480  adrp     x21, #0x959a000
0066BD484  adrp     x22, #0x8f11000
0066BD488  ldrb     w8, [x21, #0x212]
0066BD48C  ldr      x22, [x22, #0xb48]
0066BD490  mov      x20, x1
0066BD494  mov      x19, x0
0066BD498  tbnz     w8, #0, #0x66bd4b0
0066BD49C  adrp     x0, #0x8f11000
0066BD4A0  ldr      x0, [x0, #0xb48]
0066BD4A4  bl       #0x382bd14 ; 
0066BD4A8  mov      w8, #1
0066BD4AC  strb     w8, [x21, #0x212]
0066BD4B0  ldr      x2, [x22]
0066BD4B4  ldrb     w8, [x2, #0x53]
0066BD4B8  tbnz     w8, #5, #0x66bd4e0
0066BD4BC  cbz      x20, #0x66bd520
0066BD4C0  mov      x0, x20
0066BD4C4  mov      x1, xzr
0066BD4C8  bl       #0x667aa54 ; HotFix.BattleLogic.BulletHurtInfo$$get_OnlyHurt
0066BD4CC  tbz      w0, #0, #0x66bd4fc
0066BD4D0  ldp      x20, x19, [sp, #0x20]
0066BD4D4  ldp      x22, x21, [sp, #0x10]
0066BD4D8  ldr      x30, [sp], #0x30
0066BD4DC  ret      
0066BD4E0  ldr      x3, [x2, #0x60]
0066BD4E4  mov      x0, x19
0066BD4E8  mov      x1, x20
0066BD4EC  ldp      x20, x19, [sp, #0x20]
0066BD4F0  ldp      x22, x21, [sp, #0x10]
0066BD4F4  ldr      x30, [sp], #0x30
0066BD4F8  br       x3
0066BD4FC  mov      x0, x19
0066BD500  bl       #0x66be654 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayEntityHitSound
0066BD504  mov      x0, x19
0066BD508  bl       #0x66be8c4 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayVibartion
0066BD50C  mov      x0, x19
0066BD510  ldp      x20, x19, [sp, #0x20]
0066BD514  ldp      x22, x21, [sp, #0x10]
0066BD518  ldr      x30, [sp], #0x30
0066BD51C  b        #0x66bec34 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayerHitAnimation
0066BD520  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleCritLogic
; RVA 0x66BD524; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BD524  sub      sp, sp, #0xa0
0066BD528  stp      x29, x30, [sp, #0x40]
0066BD52C  stp      x28, x27, [sp, #0x50]
0066BD530  stp      x26, x25, [sp, #0x60]
0066BD534  stp      x24, x23, [sp, #0x70]
0066BD538  stp      x22, x21, [sp, #0x80]
0066BD53C  stp      x20, x19, [sp, #0x90]
0066BD540  mrs      x26, tpidr_el0
0066BD544  ldr      x8, [x26, #0x28]
0066BD548  adrp     x27, #0x959a000
0066BD54C  adrp     x28, #0x8f11000
0066BD550  mov      w24, w6
0066BD554  str      x8, [sp, #0x38]
0066BD558  ldrb     w8, [x27, #0x213]
0066BD55C  ldr      x28, [x28, #0xb50]
0066BD560  mov      x21, x5
0066BD564  mov      x22, x4
0066BD568  mov      x25, x3
0066BD56C  mov      x23, x2
0066BD570  mov      x19, x1
0066BD574  mov      x20, x0
0066BD578  tbnz     w8, #0, #0x66bd5fc
0066BD57C  adrp     x0, #0x8f11000
0066BD580  ldr      x0, [x0, #0xb50]
0066BD584  bl       #0x382bd14 ; 
0066BD588  adrp     x0, #0x8ee9000
0066BD58C  ldr      x0, [x0, #0x9f8]
0066BD590  bl       #0x382bd14 ; 
0066BD594  adrp     x0, #0x8ee6000
0066BD598  ldr      x0, [x0, #0xd8]
0066BD59C  bl       #0x382bd14 ; 
0066BD5A0  adrp     x0, #0x8ee6000
0066BD5A4  ldr      x0, [x0, #0xe0]
0066BD5A8  bl       #0x382bd14 ; 
0066BD5AC  adrp     x0, #0x8ee6000
0066BD5B0  ldr      x0, [x0, #0x608]
0066BD5B4  bl       #0x382bd14 ; 
0066BD5B8  adrp     x0, #0x8ee6000
0066BD5BC  ldr      x0, [x0, #0x100]
0066BD5C0  bl       #0x382bd14 ; 
0066BD5C4  adrp     x0, #0x8ee6000
0066BD5C8  ldr      x0, [x0, #0x610]
0066BD5CC  bl       #0x382bd14 ; 
0066BD5D0  adrp     x0, #0x8eea000
0066BD5D4  ldr      x0, [x0, #0xf08]
0066BD5D8  bl       #0x382bd14 ; 
0066BD5DC  adrp     x0, #0x8ee8000
0066BD5E0  ldr      x0, [x0, #0x350]
0066BD5E4  bl       #0x382bd14 ; 
0066BD5E8  adrp     x0, #0x8ec2000
0066BD5EC  ldr      x0, [x0, #0xbc8]
0066BD5F0  bl       #0x382bd14 ; 
0066BD5F4  mov      w8, #1
0066BD5F8  strb     w8, [x27, #0x213]
0066BD5FC  ldr      x7, [x28]
0066BD600  ldrb     w8, [x7, #0x53]
0066BD604  tbnz     w8, #5, #0x66bd678
0066BD608  tbz      w24, #0, #0x66bd69c
0066BD60C  cbz      x22, #0x66bd644
0066BD610  adrp     x8, #0x8ee6000
0066BD614  ldr      x8, [x8, #0x100]
0066BD618  ldr      x9, [x22]
0066BD61C  ldr      x8, [x8]
0066BD620  ldrb     w11, [x9, #0x130]
0066BD624  ldrb     w10, [x8, #0x130]
0066BD628  cmp      w11, w10
0066BD62C  b.lo     #0x66bd644
0066BD630  ldr      x9, [x9, #0xc8]
0066BD634  add      x9, x9, x10, lsl #3
0066BD638  ldur     x9, [x9, #-8]
0066BD63C  cmp      x9, x8
0066BD640  b.eq     #0x66bd9f0
0066BD644  adrp     x28, #0x8ec2000
0066BD648  ldr      x28, [x28, #0xbc8]
0066BD64C  mov      w1, #1
0066BD650  ldr      x0, [x28]
0066BD654  bl       #0x382bdfc ; 
0066BD658  adrp     x24, #0x8ee6000
0066BD65C  ldr      x24, [x24, #0x608]
0066BD660  mov      x22, x0
0066BD664  ldr      x1, [x24]
0066BD668  ldrb     w8, [x1, #0x53]
0066BD66C  tbnz     w8, #5, #0x66bd6cc
0066BD670  ldr      x0, [x20, #0x30]
0066BD674  b        #0x66bd6d8 ; 
0066BD678  ldr      x8, [x7, #0x60]
0066BD67C  and      w6, w24, #1
0066BD680  mov      x0, x20
0066BD684  mov      x1, x19
0066BD688  mov      x2, x23
0066BD68C  mov      x3, x25
0066BD690  mov      x4, x22
0066BD694  mov      x5, x21
0066BD698  blr      x8
0066BD69C  ldr      x8, [x26, #0x28]
0066BD6A0  ldr      x9, [sp, #0x38]
0066BD6A4  cmp      x8, x9
0066BD6A8  b.ne     #0x66bda98
0066BD6AC  ldp      x20, x19, [sp, #0x90]
0066BD6B0  ldp      x22, x21, [sp, #0x80]
0066BD6B4  ldp      x24, x23, [sp, #0x70]
0066BD6B8  ldp      x26, x25, [sp, #0x60]
0066BD6BC  ldp      x28, x27, [sp, #0x50]
0066BD6C0  ldp      x29, x30, [sp, #0x40]
0066BD6C4  add      sp, sp, #0xa0
0066BD6C8  ret      
0066BD6CC  ldr      x8, [x1, #0x60]
0066BD6D0  mov      x0, x20
0066BD6D4  blr      x8
0066BD6D8  cbz      x0, #0x66bda84
0066BD6DC  adrp     x8, #0x8ee6000
0066BD6E0  ldr      x8, [x8, #0xd8]
0066BD6E4  ldr      x1, [x8]
0066BD6E8  ldrb     w8, [x1, #0x53]
0066BD6EC  tbnz     w8, #5, #0x66bd6f8
0066BD6F0  ldr      x0, [x0, #0x38]
0066BD6F4  b        #0x66bd700 ; 
0066BD6F8  ldr      x8, [x1, #0x60]
0066BD6FC  blr      x8
0066BD700  cbz      x0, #0x66bda84
0066BD704  mov      x8, sp
0066BD708  mov      x1, xzr
0066BD70C  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066BD710  adrp     x25, #0x8ee8000
0066BD714  ldr      q0, [sp]
0066BD718  ldr      x8, [sp, #0x10]
0066BD71C  ldr      x25, [x25, #0x350]
0066BD720  mov      x1, sp
0066BD724  str      q0, [sp, #0x20]
0066BD728  str      x8, [sp, #0x30]
0066BD72C  ldr      x0, [x25]
0066BD730  str      q0, [sp]
0066BD734  str      x8, [sp, #0x10]
0066BD738  bl       #0x382be94 ; 
0066BD73C  cbz      x22, #0x66bda84
0066BD740  mov      x23, x0
0066BD744  cbz      x0, #0x66bd75c
0066BD748  ldr      x8, [x22]
0066BD74C  mov      x0, x23
0066BD750  ldr      x1, [x8, #0x40]
0066BD754  bl       #0x382be90 ; 
0066BD758  cbz      x0, #0x66bda8c
0066BD75C  ldr      w8, [x22, #0x18]
0066BD760  cbz      w8, #0x66bda88
0066BD764  mov      x0, x22
0066BD768  str      x23, [x0, #0x20]!
0066BD76C  mov      x1, x23
0066BD770  bl       #0x382bcb8 ; 
0066BD774  cbz      x21, #0x66bda84
0066BD778  adrp     x27, #0x8ee9000
0066BD77C  ldr      x27, [x27, #0x9f8]
0066BD780  mov      w1, #0x23
0066BD784  mov      x0, x21
0066BD788  mov      x2, x22
0066BD78C  ldr      x3, [x27]
0066BD790  bl       #0x60b3770 ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0066BD794  adrp     x8, #0x8ee6000
0066BD798  ldr      x8, [x8, #0xe0]
0066BD79C  ldr      x1, [x8]
0066BD7A0  ldrb     w8, [x1, #0x53]
0066BD7A4  tbnz     w8, #5, #0x66bd7b0
0066BD7A8  ldr      x22, [x21, #0x38]
0066BD7AC  b        #0x66bd7c0 ; 
0066BD7B0  ldr      x8, [x1, #0x60]
0066BD7B4  mov      x0, x21
0066BD7B8  blr      x8
0066BD7BC  mov      x22, x0
0066BD7C0  cbz      x22, #0x66bda84
0066BD7C4  adrp     x23, #0x959a000
0066BD7C8  ldrb     w8, [x23, #0x275]
0066BD7CC  cbnz     w8, #0x66bd7e4
0066BD7D0  adrp     x0, #0x8f0f000
0066BD7D4  ldr      x0, [x0, #0xb08]
0066BD7D8  bl       #0x382bd14 ; 
0066BD7DC  mov      w8, #1
0066BD7E0  strb     w8, [x23, #0x275]
0066BD7E4  adrp     x8, #0x8f0f000
0066BD7E8  ldr      x8, [x8, #0xb08]
0066BD7EC  ldr      x1, [x8]
0066BD7F0  ldrb     w8, [x1, #0x53]
0066BD7F4  tbnz     w8, #5, #0x66bd800
0066BD7F8  ldr      x22, [x22, #0x3d0]
0066BD7FC  b        #0x66bd810 ; 
0066BD800  ldr      x8, [x1, #0x60]
0066BD804  mov      x0, x22
0066BD808  blr      x8
0066BD80C  mov      x22, x0
0066BD810  mov      x0, xzr
0066BD814  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
0066BD818  mov      x1, x0
0066BD81C  mov      x0, x22
0066BD820  mov      x2, xzr
0066BD824  bl       #0x7db81fc ; Quantum.EntityRef$$op_Inequality
0066BD828  tbz      w0, #0, #0x66bd69c
0066BD82C  adrp     x23, #0x9591000
0066BD830  ldrb     w8, [x23, #0xa4b]
0066BD834  cbnz     w8, #0x66bd84c
0066BD838  adrp     x0, #0x8ee5000
0066BD83C  ldr      x0, [x0, #0xb28]
0066BD840  bl       #0x382bd14 ; 
0066BD844  mov      w8, #1
0066BD848  strb     w8, [x23, #0xa4b]
0066BD84C  adrp     x8, #0x8ee5000
0066BD850  ldr      x8, [x8, #0xb28]
0066BD854  ldr      x1, [x8]
0066BD858  ldrb     w8, [x1, #0x53]
0066BD85C  tbnz     w8, #5, #0x66bd868
0066BD860  ldr      x23, [x21, #0x20]
0066BD864  b        #0x66bd878 ; 
0066BD868  ldr      x8, [x1, #0x60]
0066BD86C  mov      x0, x21
0066BD870  blr      x8
0066BD874  mov      x23, x0
0066BD878  cbz      x23, #0x66bda84
0066BD87C  adrp     x29, #0x9591000
0066BD880  ldrb     w8, [x29, #0xa62]
0066BD884  cbnz     w8, #0x66bd89c
0066BD888  adrp     x0, #0x8ee6000
0066BD88C  ldr      x0, [x0, #0x1f8]
0066BD890  bl       #0x382bd14 ; 
0066BD894  mov      w8, #1
0066BD898  strb     w8, [x29, #0xa62]
0066BD89C  adrp     x8, #0x8ee6000
0066BD8A0  ldr      x8, [x8, #0x1f8]
0066BD8A4  ldr      x1, [x8]
0066BD8A8  ldrb     w8, [x1, #0x53]
0066BD8AC  tbnz     w8, #5, #0x66bd8b8
0066BD8B0  ldr      x0, [x23, #0x1f8]
0066BD8B4  b        #0x66bd8c4 ; 
0066BD8B8  ldr      x8, [x1, #0x60]
0066BD8BC  mov      x0, x23
0066BD8C0  blr      x8
0066BD8C4  cbz      x0, #0x66bda84
0066BD8C8  adrp     x8, #0x8eea000
0066BD8CC  ldr      x8, [x8, #0xf08]
0066BD8D0  mov      x1, x22
0066BD8D4  ldr      x2, [x8]
0066BD8D8  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066BD8DC  cbz      x0, #0x66bd69c
0066BD8E0  mov      x22, x0
0066BD8E4  ldr      x0, [x28]
0066BD8E8  mov      w1, #3
0066BD8EC  bl       #0x382bdfc ; 
0066BD8F0  cbz      x0, #0x66bda84
0066BD8F4  ldr      x8, [x0]
0066BD8F8  mov      x23, x0
0066BD8FC  mov      x0, x21
0066BD900  ldr      x1, [x8, #0x40]
0066BD904  bl       #0x382be90 ; 
0066BD908  cbz      x0, #0x66bda8c
0066BD90C  ldr      w8, [x23, #0x18]
0066BD910  cbz      w8, #0x66bda88
0066BD914  mov      x0, x23
0066BD918  str      x21, [x0, #0x20]!
0066BD91C  mov      x1, x21
0066BD920  bl       #0x382bcb8 ; 
0066BD924  ldr      x1, [x24]
0066BD928  ldrb     w8, [x1, #0x53]
0066BD92C  tbnz     w8, #5, #0x66bd93c
0066BD930  ldr      x20, [x20, #0x30]
0066BD934  cbnz     x20, #0x66bd950
0066BD938  b        #0x66bd964 ; 
0066BD93C  ldr      x8, [x1, #0x60]
0066BD940  mov      x0, x20
0066BD944  blr      x8
0066BD948  mov      x20, x0
0066BD94C  cbz      x20, #0x66bd964
0066BD950  ldr      x8, [x23]
0066BD954  mov      x0, x20
0066BD958  ldr      x1, [x8, #0x40]
0066BD95C  bl       #0x382be90 ; 
0066BD960  cbz      x0, #0x66bda8c
0066BD964  ldr      w8, [x23, #0x18]
0066BD968  cmp      w8, #1
0066BD96C  b.ls     #0x66bda88
0066BD970  mov      x0, x23
0066BD974  str      x20, [x0, #0x28]!
0066BD978  mov      x1, x20
0066BD97C  bl       #0x382bcb8 ; 
0066BD980  cbz      x19, #0x66bda84
0066BD984  ldr      x8, [x19, #0x38]
0066BD988  ldur     q0, [x19, #0x28]
0066BD98C  ldr      x0, [x25]
0066BD990  add      x1, sp, #0x20
0066BD994  str      x8, [sp, #0x30]
0066BD998  str      q0, [sp, #0x20]
0066BD99C  bl       #0x382be94 ; 
0066BD9A0  mov      x19, x0
0066BD9A4  cbz      x0, #0x66bd9bc
0066BD9A8  ldr      x8, [x23]
0066BD9AC  mov      x0, x19
0066BD9B0  ldr      x1, [x8, #0x40]
0066BD9B4  bl       #0x382be90 ; 
0066BD9B8  cbz      x0, #0x66bda8c
0066BD9BC  ldr      w8, [x23, #0x18]
0066BD9C0  cmp      w8, #2
0066BD9C4  b.ls     #0x66bda88
0066BD9C8  mov      x0, x23
0066BD9CC  str      x19, [x0, #0x30]!
0066BD9D0  mov      x1, x19
0066BD9D4  bl       #0x382bcb8 ; 
0066BD9D8  ldr      x3, [x27]
0066BD9DC  mov      w1, #0x24
0066BD9E0  mov      x0, x22
0066BD9E4  mov      x2, x23
0066BD9E8  bl       #0x60b3770 ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0066BD9EC  b        #0x66bd69c ; 
0066BD9F0  adrp     x24, #0x9591000
0066BD9F4  ldrb     w8, [x24, #0xa86]
0066BD9F8  cbnz     w8, #0x66bda1c
0066BD9FC  adrp     x0, #0x8ee6000
0066BDA00  ldr      x0, [x0, #0x318]
0066BDA04  bl       #0x382bd14 ; 
0066BDA08  adrp     x0, #0x8ee3000
0066BDA0C  ldr      x0, [x0, #0xf18]
0066BDA10  bl       #0x382bd14 ; 
0066BDA14  mov      w8, #1
0066BDA18  strb     w8, [x24, #0xa86]
0066BDA1C  adrp     x8, #0x8ee6000
0066BDA20  ldr      x8, [x8, #0x318]
0066BDA24  ldr      x2, [x8]
0066BDA28  ldrb     w8, [x2, #0x53]
0066BDA2C  tbnz     w8, #5, #0x66bda54
0066BDA30  ldr      x0, [x22, #0x190]
0066BDA34  cbz      x0, #0x66bd644
0066BDA38  adrp     x8, #0x8ee3000
0066BDA3C  ldr      x8, [x8, #0xf18]
0066BDA40  mov      w1, #0x10
0066BDA44  ldr      x2, [x8]
0066BDA48  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066BDA4C  tbz      w0, #0, #0x66bd644
0066BDA50  b        #0x66bda68 ; 
0066BDA54  ldr      x8, [x2, #0x60]
0066BDA58  mov      w1, #0x10
0066BDA5C  mov      x0, x22
0066BDA60  blr      x8
0066BDA64  tbz      w0, #0, #0x66bd644
0066BDA68  mov      x0, x20
0066BDA6C  mov      x1, x22
0066BDA70  mov      x2, x19
0066BDA74  mov      x3, x23
0066BDA78  mov      x4, x21
0066BDA7C  bl       #0x66bef20 ; HotFix.BattleLogic.CharacterComponentOnHit$$ProcessCritTrigger
0066BDA80  b        #0x66bd644 ; 
0066BDA84  bl       #0x382bfb8 ; 
0066BDA88  bl       #0x382bfc0 ; 
0066BDA8C  bl       #0x382bfdc ; 
0066BDA90  mov      x1, xzr
0066BDA94  bl       #0x382be7c ; 
0066BDA98  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBulletHitEnemy
; RVA 0x66BDDD0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BDDD0  sub      sp, sp, #0x80
0066BDDD4  str      x30, [sp, #0x40]
0066BDDD8  stp      x24, x23, [sp, #0x50]
0066BDDDC  stp      x22, x21, [sp, #0x60]
0066BDDE0  stp      x20, x19, [sp, #0x70]
0066BDDE4  mrs      x23, tpidr_el0
0066BDDE8  ldr      x8, [x23, #0x28]
0066BDDEC  adrp     x22, #0x959a000
0066BDDF0  adrp     x24, #0x8f11000
0066BDDF4  mov      x19, x2
0066BDDF8  str      x8, [sp, #0x38]
0066BDDFC  ldrb     w8, [x22, #0x214]
0066BDE00  ldr      x24, [x24, #0xb70]
0066BDE04  mov      x20, x1
0066BDE08  mov      x21, x0
0066BDE0C  tbnz     w8, #0, #0x66bde60
0066BDE10  adrp     x0, #0x8f11000
0066BDE14  ldr      x0, [x0, #0xb70]
0066BDE18  bl       #0x382bd14 ; 
0066BDE1C  adrp     x0, #0x8ee9000
0066BDE20  ldr      x0, [x0, #0x9f8]
0066BDE24  bl       #0x382bd14 ; 
0066BDE28  adrp     x0, #0x8ee6000
0066BDE2C  ldr      x0, [x0, #0x608]
0066BDE30  bl       #0x382bd14 ; 
0066BDE34  adrp     x0, #0x8f06000
0066BDE38  ldr      x0, [x0, #0x340]
0066BDE3C  bl       #0x382bd14 ; 
0066BDE40  adrp     x0, #0x8ec2000
0066BDE44  ldr      x0, [x0, #0xbc8]
0066BDE48  bl       #0x382bd14 ; 
0066BDE4C  adrp     x0, #0x8f11000
0066BDE50  ldr      x0, [x0, #0xb78]
0066BDE54  bl       #0x382bd14 ; 
0066BDE58  mov      w8, #1
0066BDE5C  strb     w8, [x22, #0x214]
0066BDE60  ldr      x3, [x24]
0066BDE64  ldrb     w8, [x3, #0x53]
0066BDE68  tbnz     w8, #5, #0x66bdea8
0066BDE6C  adrp     x22, #0x9591000
0066BDE70  ldrb     w8, [x22, #0xa4b]
0066BDE74  cbnz     w8, #0x66bde8c
0066BDE78  adrp     x0, #0x8ee5000
0066BDE7C  ldr      x0, [x0, #0xb28]
0066BDE80  bl       #0x382bd14 ; 
0066BDE84  mov      w8, #1
0066BDE88  strb     w8, [x22, #0xa4b]
0066BDE8C  adrp     x8, #0x8ee5000
0066BDE90  ldr      x8, [x8, #0xb28]
0066BDE94  ldr      x1, [x8]
0066BDE98  ldrb     w8, [x1, #0x53]
0066BDE9C  tbnz     w8, #5, #0x66bdec0
0066BDEA0  ldr      x22, [x21, #0x20]
0066BDEA4  b        #0x66bded0 ; 
0066BDEA8  ldr      x8, [x3, #0x60]
0066BDEAC  mov      x0, x21
0066BDEB0  mov      x1, x20
0066BDEB4  mov      x2, x19
0066BDEB8  blr      x8
0066BDEBC  b        #0x66be024 ; 
0066BDEC0  ldr      x8, [x1, #0x60]
0066BDEC4  mov      x0, x21
0066BDEC8  blr      x8
0066BDECC  mov      x22, x0
0066BDED0  cbz      x22, #0x66be04c
0066BDED4  adrp     x24, #0x9591000
0066BDED8  ldrb     w8, [x24, #0xa4c]
0066BDEDC  cbnz     w8, #0x66bdef4
0066BDEE0  adrp     x0, #0x8ee5000
0066BDEE4  ldr      x0, [x0, #0xb30]
0066BDEE8  bl       #0x382bd14 ; 
0066BDEEC  mov      w8, #1
0066BDEF0  strb     w8, [x24, #0xa4c]
0066BDEF4  adrp     x8, #0x8ee5000
0066BDEF8  ldr      x8, [x8, #0xb30]
0066BDEFC  ldr      x1, [x8]
0066BDF00  ldrb     w8, [x1, #0x53]
0066BDF04  tbnz     w8, #5, #0x66bdf10
0066BDF08  ldr      x0, [x22, #0x210]
0066BDF0C  b        #0x66bdf1c ; 
0066BDF10  ldr      x8, [x1, #0x60]
0066BDF14  mov      x0, x22
0066BDF18  blr      x8
0066BDF1C  cbz      x0, #0x66be04c
0066BDF20  adrp     x8, #0x8f11000
0066BDF24  ldr      x8, [x8, #0xb78]
0066BDF28  ldr      x1, [x8]
0066BDF2C  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BDF30  adrp     x8, #0x8ee6000
0066BDF34  ldr      x8, [x8, #0x608]
0066BDF38  mov      x22, x0
0066BDF3C  ldr      x1, [x8]
0066BDF40  ldrb     w8, [x1, #0x53]
0066BDF44  tbnz     w8, #5, #0x66bdf50
0066BDF48  ldr      x1, [x21, #0x30]
0066BDF4C  b        #0x66bdf60 ; 
0066BDF50  ldr      x8, [x1, #0x60]
0066BDF54  mov      x0, x21
0066BDF58  blr      x8
0066BDF5C  mov      x1, x0
0066BDF60  cbz      x22, #0x66be04c
0066BDF64  mov      x0, x22
0066BDF68  str      x1, [x0, #0x20]!
0066BDF6C  bl       #0x382bcb8 ; 
0066BDF70  cbz      x20, #0x66be04c
0066BDF74  adrp     x8, #0x8f06000
0066BDF78  ldr      x8, [x8, #0x340]
0066BDF7C  movi     v0.2d, #0000000000000000
0066BDF80  stp      q0, q0, [sp]
0066BDF84  ldr      x9, [x20, #0x38]
0066BDF88  ldur     q0, [x20, #0x28]
0066BDF8C  ldr      x2, [x8]
0066BDF90  mov      x0, sp
0066BDF94  add      x1, sp, #0x20
0066BDF98  str      x9, [sp, #0x30]
0066BDF9C  str      q0, [sp, #0x20]
0066BDFA0  bl       #0x5133758 ; System.Nullable<FPVector3>$$.ctor
0066BDFA4  ldp      q0, q1, [sp]
0066BDFA8  adrp     x8, #0x8ec2000
0066BDFAC  mov      w1, #1
0066BDFB0  stur     q0, [x22, #0x28]
0066BDFB4  stur     q1, [x22, #0x38]
0066BDFB8  ldr      x8, [x8, #0xbc8]
0066BDFBC  ldr      x0, [x8]
0066BDFC0  bl       #0x382bdfc ; 
0066BDFC4  cbz      x0, #0x66be04c
0066BDFC8  ldr      x8, [x0]
0066BDFCC  mov      x20, x0
0066BDFD0  mov      x0, x22
0066BDFD4  ldr      x1, [x8, #0x40]
0066BDFD8  bl       #0x382be90 ; 
0066BDFDC  cbz      x0, #0x66be050
0066BDFE0  ldr      w8, [x20, #0x18]
0066BDFE4  cbz      w8, #0x66be05c
0066BDFE8  mov      x0, x20
0066BDFEC  str      x22, [x0, #0x20]!
0066BDFF0  mov      x1, x22
0066BDFF4  bl       #0x382bcb8 ; 
0066BDFF8  cbz      x19, #0x66be04c
0066BDFFC  adrp     x8, #0x8ee9000
0066BE000  ldr      x8, [x8, #0x9f8]
0066BE004  mov      w1, #0x1a
0066BE008  mov      x0, x19
0066BE00C  mov      x2, x20
0066BE010  ldr      x3, [x8]
0066BE014  bl       #0x60b3770 ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0066BE018  mov      x0, x22
0066BE01C  mov      x1, xzr
0066BE020  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066BE024  ldr      x8, [x23, #0x28]
0066BE028  ldr      x9, [sp, #0x38]
0066BE02C  cmp      x8, x9
0066BE030  b.ne     #0x66be060
0066BE034  ldp      x20, x19, [sp, #0x70]
0066BE038  ldp      x22, x21, [sp, #0x60]
0066BE03C  ldp      x24, x23, [sp, #0x50]
0066BE040  ldr      x30, [sp, #0x40]
0066BE044  add      sp, sp, #0x80
0066BE048  ret      
0066BE04C  bl       #0x382bfb8 ; 
0066BE050  bl       #0x382bfdc ; 
0066BE054  mov      x1, xzr
0066BE058  bl       #0x382be7c ; 
0066BE05C  bl       #0x382bfc0 ; 
0066BE060  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleBulletHitEventToBullet
; RVA 0x66B8350; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B8350  sub      sp, sp, #0xa0
0066B8354  str      x30, [sp, #0x40]
0066B8358  stp      x28, x27, [sp, #0x50]
0066B835C  stp      x26, x25, [sp, #0x60]
0066B8360  stp      x24, x23, [sp, #0x70]
0066B8364  stp      x22, x21, [sp, #0x80]
0066B8368  stp      x20, x19, [sp, #0x90]
0066B836C  mrs      x26, tpidr_el0
0066B8370  ldr      x8, [x26, #0x28]
0066B8374  adrp     x27, #0x959a000
0066B8378  adrp     x28, #0x8f11000
0066B837C  mov      x21, x6
0066B8380  str      x8, [sp, #0x38]
0066B8384  ldrb     w8, [x27, #0x215]
0066B8388  ldr      x28, [x28, #0x9b0]
0066B838C  mov      w23, w5
0066B8390  mov      w25, w4
0066B8394  mov      x19, x3
0066B8398  mov      x22, x2
0066B839C  mov      w20, w1
0066B83A0  mov      x24, x0
0066B83A4  tbnz     w8, #0, #0x66b83f8
0066B83A8  adrp     x0, #0x8f11000
0066B83AC  ldr      x0, [x0, #0x9b0]
0066B83B0  bl       #0x382bd14 ; 
0066B83B4  adrp     x0, #0x8ee9000
0066B83B8  ldr      x0, [x0, #0x9f8]
0066B83BC  bl       #0x382bd14 ; 
0066B83C0  adrp     x0, #0x8ee6000
0066B83C4  ldr      x0, [x0, #0x608]
0066B83C8  bl       #0x382bd14 ; 
0066B83CC  adrp     x0, #0x8f06000
0066B83D0  ldr      x0, [x0, #0x340]
0066B83D4  bl       #0x382bd14 ; 
0066B83D8  adrp     x0, #0x8ec2000
0066B83DC  ldr      x0, [x0, #0xbc8]
0066B83E0  bl       #0x382bd14 ; 
0066B83E4  adrp     x0, #0x8eea000
0066B83E8  ldr      x0, [x0, #0xf20]
0066B83EC  bl       #0x382bd14 ; 
0066B83F0  mov      w8, #1
0066B83F4  strb     w8, [x27, #0x215]
0066B83F8  ldr      x7, [x28]
0066B83FC  ldrb     w8, [x7, #0x53]
0066B8400  tbnz     w8, #5, #0x66b8444
0066B8404  tbz      w25, #0x14, #0x66b85e4
0066B8408  adrp     x25, #0x9591000
0066B840C  ldrb     w8, [x25, #0xa4b]
0066B8410  cbnz     w8, #0x66b8428
0066B8414  adrp     x0, #0x8ee5000
0066B8418  ldr      x0, [x0, #0xb28]
0066B841C  bl       #0x382bd14 ; 
0066B8420  mov      w8, #1
0066B8424  strb     w8, [x25, #0xa4b]
0066B8428  adrp     x8, #0x8ee5000
0066B842C  ldr      x8, [x8, #0xb28]
0066B8430  ldr      x1, [x8]
0066B8434  ldrb     w8, [x1, #0x53]
0066B8438  tbnz     w8, #5, #0x66b846c
0066B843C  ldr      x25, [x24, #0x20]
0066B8440  b        #0x66b847c ; 
0066B8444  ldr      x8, [x7, #0x60]
0066B8448  mov      x0, x24
0066B844C  mov      w1, w20
0066B8450  mov      x2, x22
0066B8454  mov      x3, x19
0066B8458  mov      w4, w25
0066B845C  mov      w5, w23
0066B8460  mov      x6, x21
0066B8464  blr      x8
0066B8468  b        #0x66b85e4 ; 
0066B846C  ldr      x8, [x1, #0x60]
0066B8470  mov      x0, x24
0066B8474  blr      x8
0066B8478  mov      x25, x0
0066B847C  cbz      x25, #0x66b8614
0066B8480  adrp     x27, #0x9591000
0066B8484  ldrb     w8, [x27, #0xa4c]
0066B8488  cbnz     w8, #0x66b84a0
0066B848C  adrp     x0, #0x8ee5000
0066B8490  ldr      x0, [x0, #0xb30]
0066B8494  bl       #0x382bd14 ; 
0066B8498  mov      w8, #1
0066B849C  strb     w8, [x27, #0xa4c]
0066B84A0  adrp     x8, #0x8ee5000
0066B84A4  ldr      x8, [x8, #0xb30]
0066B84A8  ldr      x1, [x8]
0066B84AC  ldrb     w8, [x1, #0x53]
0066B84B0  tbnz     w8, #5, #0x66b84bc
0066B84B4  ldr      x0, [x25, #0x210]
0066B84B8  b        #0x66b84c8 ; 
0066B84BC  ldr      x8, [x1, #0x60]
0066B84C0  mov      x0, x25
0066B84C4  blr      x8
0066B84C8  cbz      x0, #0x66b8614
0066B84CC  adrp     x8, #0x8eea000
0066B84D0  ldr      x8, [x8, #0xf20]
0066B84D4  ldr      x1, [x8]
0066B84D8  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066B84DC  adrp     x8, #0x8ee6000
0066B84E0  ldr      x8, [x8, #0x608]
0066B84E4  mov      x25, x0
0066B84E8  ldr      x1, [x8]
0066B84EC  ldrb     w8, [x1, #0x53]
0066B84F0  tbnz     w8, #5, #0x66b84fc
0066B84F4  ldr      x1, [x24, #0x30]
0066B84F8  b        #0x66b850c ; 
0066B84FC  ldr      x8, [x1, #0x60]
0066B8500  mov      x0, x24
0066B8504  blr      x8
0066B8508  mov      x1, x0
0066B850C  cbz      x25, #0x66b8614
0066B8510  mov      x24, x25
0066B8514  str      x1, [x24, #0x20]!
0066B8518  mov      x0, x24
0066B851C  bl       #0x382bcb8 ; 
0066B8520  str      w23, [x24, #8]
0066B8524  cbz      x22, #0x66b8614
0066B8528  adrp     x8, #0x8f06000
0066B852C  ldr      x8, [x8, #0x340]
0066B8530  movi     v0.2d, #0000000000000000
0066B8534  stp      q0, q0, [sp]
0066B8538  ldr      x9, [x22, #0x38]
0066B853C  ldur     q0, [x22, #0x28]
0066B8540  ldr      x2, [x8]
0066B8544  mov      x0, sp
0066B8548  add      x1, sp, #0x20
0066B854C  str      x9, [sp, #0x30]
0066B8550  str      q0, [sp, #0x20]
0066B8554  bl       #0x5133758 ; System.Nullable<FPVector3>$$.ctor
0066B8558  ldp      q1, q0, [sp]
0066B855C  mov      x0, x25
0066B8560  str      x21, [x0, #0x50]!
0066B8564  mov      x1, x21
0066B8568  stp      q1, q0, [x0, #-0x20]
0066B856C  bl       #0x382bcb8 ; 
0066B8570  adrp     x8, #0x8ec2000
0066B8574  ldr      x8, [x8, #0xbc8]
0066B8578  mov      w1, #1
0066B857C  ldr      x0, [x8]
0066B8580  bl       #0x382bdfc ; 
0066B8584  cbz      x0, #0x66b8614
0066B8588  ldr      x8, [x0]
0066B858C  mov      x21, x0
0066B8590  mov      x0, x25
0066B8594  ldr      x1, [x8, #0x40]
0066B8598  bl       #0x382be90 ; 
0066B859C  cbz      x0, #0x66b8618
0066B85A0  ldr      w8, [x21, #0x18]
0066B85A4  cbz      w8, #0x66b8624
0066B85A8  mov      x0, x21
0066B85AC  str      x25, [x0, #0x20]!
0066B85B0  mov      x1, x25
0066B85B4  bl       #0x382bcb8 ; 
0066B85B8  cbz      x19, #0x66b8614
0066B85BC  adrp     x8, #0x8ee9000
0066B85C0  ldr      x8, [x8, #0x9f8]
0066B85C4  mov      x0, x19
0066B85C8  mov      w1, w20
0066B85CC  mov      x2, x21
0066B85D0  ldr      x3, [x8]
0066B85D4  bl       #0x60b3770 ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0066B85D8  mov      x0, x25
0066B85DC  mov      x1, xzr
0066B85E0  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066B85E4  ldr      x8, [x26, #0x28]
0066B85E8  ldr      x9, [sp, #0x38]
0066B85EC  cmp      x8, x9
0066B85F0  b.ne     #0x66b8628
0066B85F4  ldp      x20, x19, [sp, #0x90]
0066B85F8  ldp      x22, x21, [sp, #0x80]
0066B85FC  ldp      x24, x23, [sp, #0x70]
0066B8600  ldp      x26, x25, [sp, #0x60]
0066B8604  ldp      x28, x27, [sp, #0x50]
0066B8608  ldr      x30, [sp, #0x40]
0066B860C  add      sp, sp, #0xa0
0066B8610  ret      
0066B8614  bl       #0x382bfb8 ; 
0066B8618  bl       #0x382bfdc ; 
0066B861C  mov      x1, xzr
0066B8620  bl       #0x382be7c ; 
0066B8624  bl       #0x382bfc0 ; 
0066B8628  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandleHitBack
; RVA 0x66BE064; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BE064  sub      sp, sp, #0x90
0066BE068  str      x30, [sp, #0x40]
0066BE06C  stp      x26, x25, [sp, #0x50]
0066BE070  stp      x24, x23, [sp, #0x60]
0066BE074  stp      x22, x21, [sp, #0x70]
0066BE078  stp      x20, x19, [sp, #0x80]
0066BE07C  mrs      x23, tpidr_el0
0066BE080  ldr      x8, [x23, #0x28]
0066BE084  adrp     x22, #0x959a000
0066BE088  adrp     x24, #0x8f11000
0066BE08C  mov      x21, x2
0066BE090  str      x8, [sp, #0x38]
0066BE094  ldrb     w8, [x22, #0x216]
0066BE098  ldr      x24, [x24, #0xb80]
0066BE09C  mov      x20, x1
0066BE0A0  mov      x19, x0
0066BE0A4  tbnz     w8, #0, #0x66be11c
0066BE0A8  adrp     x0, #0x8f11000
0066BE0AC  ldr      x0, [x0, #0xb80]
0066BE0B0  bl       #0x382bd14 ; 
0066BE0B4  adrp     x0, #0x8ee6000
0066BE0B8  ldr      x0, [x0, #0xab0]
0066BE0BC  bl       #0x382bd14 ; 
0066BE0C0  adrp     x0, #0x8ee6000
0066BE0C4  ldr      x0, [x0, #0xd8]
0066BE0C8  bl       #0x382bd14 ; 
0066BE0CC  adrp     x0, #0x8ee6000
0066BE0D0  ldr      x0, [x0, #0xe0]
0066BE0D4  bl       #0x382bd14 ; 
0066BE0D8  adrp     x0, #0x8ee6000
0066BE0DC  ldr      x0, [x0, #0x600]
0066BE0E0  bl       #0x382bd14 ; 
0066BE0E4  adrp     x0, #0x8ee6000
0066BE0E8  ldr      x0, [x0, #0x608]
0066BE0EC  bl       #0x382bd14 ; 
0066BE0F0  adrp     x0, #0x8ee8000
0066BE0F4  ldr      x0, [x0, #0x350]
0066BE0F8  bl       #0x382bd14 ; 
0066BE0FC  adrp     x0, #0x8ee2000
0066BE100  ldr      x0, [x0, #0x970]
0066BE104  bl       #0x382bd14 ; 
0066BE108  adrp     x0, #0x8ec2000
0066BE10C  ldr      x0, [x0, #0xbc8]
0066BE110  bl       #0x382bd14 ; 
0066BE114  mov      w8, #1
0066BE118  strb     w8, [x22, #0x216]
0066BE11C  ldr      x3, [x24]
0066BE120  ldrb     w8, [x3, #0x53]
0066BE124  tbnz     w8, #5, #0x66be154
0066BE128  cbz      x20, #0x66be4f4
0066BE12C  cbz      x21, #0x66be4f4
0066BE130  adrp     x25, #0x8ee6000
0066BE134  ldr      x25, [x25, #0xe0]
0066BE138  ldr      x22, [x20, #0x58]
0066BE13C  ldr      x24, [x20, #0x68]
0066BE140  ldr      x1, [x25]
0066BE144  ldrb     w8, [x1, #0x53]
0066BE148  tbnz     w8, #5, #0x66be194
0066BE14C  ldr      x0, [x21, #0x38]
0066BE150  b        #0x66be1a0 ; 
0066BE154  ldr      x8, [x3, #0x60]
0066BE158  mov      x0, x19
0066BE15C  mov      x1, x20
0066BE160  mov      x2, x21
0066BE164  blr      x8
0066BE168  ldr      x8, [x23, #0x28]
0066BE16C  ldr      x9, [sp, #0x38]
0066BE170  cmp      x8, x9
0066BE174  b.ne     #0x66be508
0066BE178  ldp      x20, x19, [sp, #0x80]
0066BE17C  ldp      x22, x21, [sp, #0x70]
0066BE180  ldp      x24, x23, [sp, #0x60]
0066BE184  ldp      x26, x25, [sp, #0x50]
0066BE188  ldr      x30, [sp, #0x40]
0066BE18C  add      sp, sp, #0x90
0066BE190  ret      
0066BE194  ldr      x8, [x1, #0x60]
0066BE198  mov      x0, x21
0066BE19C  blr      x8
0066BE1A0  cbz      x0, #0x66be4f4
0066BE1A4  mov      x1, xzr
0066BE1A8  bl       #0x66770b4 ; HotFix.BattleLogic.BulletData$$get_BulletType
0066BE1AC  cmp      w0, #3
0066BE1B0  b.ne     #0x66be258
0066BE1B4  adrp     x8, #0x8ee6000
0066BE1B8  ldr      x8, [x8, #0x600]
0066BE1BC  ldr      x1, [x8]
0066BE1C0  ldrb     w8, [x1, #0x53]
0066BE1C4  tbnz     w8, #5, #0x66be1d0
0066BE1C8  ldr      x0, [x19, #0x38]
0066BE1CC  b        #0x66be1dc ; 
0066BE1D0  ldr      x8, [x1, #0x60]
0066BE1D4  mov      x0, x19
0066BE1D8  blr      x8
0066BE1DC  cbz      x0, #0x66be4f4
0066BE1E0  add      x8, sp, #0x20
0066BE1E4  mov      x1, xzr
0066BE1E8  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066BE1EC  ldr      x1, [x25]
0066BE1F0  ldp      x25, x22, [sp, #0x20]
0066BE1F4  ldr      x24, [sp, #0x30]
0066BE1F8  ldrb     w8, [x1, #0x53]
0066BE1FC  tbnz     w8, #5, #0x66be208
0066BE200  ldr      x0, [x21, #0x38]
0066BE204  b        #0x66be214 ; 
0066BE208  ldr      x8, [x1, #0x60]
0066BE20C  mov      x0, x21
0066BE210  blr      x8
0066BE214  cbz      x0, #0x66be4f4
0066BE218  add      x8, sp, #0x20
0066BE21C  mov      x1, xzr
0066BE220  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066BE224  ldp      x8, x9, [sp, #0x20]
0066BE228  ldr      x10, [sp, #0x30]
0066BE22C  add      x0, sp, #8
0066BE230  mov      x1, xzr
0066BE234  sub      x8, x25, x8
0066BE238  sub      x9, x22, x9
0066BE23C  sub      x10, x24, x10
0066BE240  stp      x8, x9, [sp, #8]
0066BE244  add      x8, sp, #0x20
0066BE248  str      x10, [sp, #0x18]
0066BE24C  bl       #0x7d4fef8 ; Photon.Deterministic.FPVector3$$Normalize
0066BE250  ldr      x22, [sp, #0x20]
0066BE254  ldr      x24, [sp, #0x30]
0066BE258  adrp     x25, #0x8ee6000
0066BE25C  ldr      x25, [x25, #0x608]
0066BE260  ldr      x1, [x25]
0066BE264  ldrb     w8, [x1, #0x53]
0066BE268  tbnz     w8, #5, #0x66be274
0066BE26C  ldr      x0, [x19, #0x30]
0066BE270  b        #0x66be280 ; 
0066BE274  ldr      x8, [x1, #0x60]
0066BE278  mov      x0, x19
0066BE27C  blr      x8
0066BE280  cbz      x0, #0x66be4f4
0066BE284  adrp     x8, #0x8ee6000
0066BE288  ldr      x8, [x8, #0xd8]
0066BE28C  ldr      x1, [x8]
0066BE290  ldrb     w8, [x1, #0x53]
0066BE294  tbnz     w8, #5, #0x66be2a0
0066BE298  ldr      x21, [x0, #0x38]
0066BE29C  b        #0x66be2ac ; 
0066BE2A0  ldr      x8, [x1, #0x60]
0066BE2A4  blr      x8
0066BE2A8  mov      x21, x0
0066BE2AC  cbz      x21, #0x66be4f4
0066BE2B0  adrp     x26, #0x9591000
0066BE2B4  ldrb     w8, [x26, #0xa8f]
0066BE2B8  cbnz     w8, #0x66be2d0
0066BE2BC  adrp     x0, #0x8ee6000
0066BE2C0  ldr      x0, [x0, #0x3d8]
0066BE2C4  bl       #0x382bd14 ; 
0066BE2C8  mov      w8, #1
0066BE2CC  strb     w8, [x26, #0xa8f]
0066BE2D0  adrp     x8, #0x8ee6000
0066BE2D4  ldr      x8, [x8, #0x3d8]
0066BE2D8  ldr      x2, [x8]
0066BE2DC  ldrb     w8, [x2, #0x53]
0066BE2E0  tbnz     w8, #5, #0x66be2f0
0066BE2E4  ldrb     w8, [x21, #0x220]
0066BE2E8  tbnz     w8, #7, #0x66be168
0066BE2EC  b        #0x66be304 ; 
0066BE2F0  ldr      x8, [x2, #0x60]
0066BE2F4  mov      w1, #7
0066BE2F8  mov      x0, x21
0066BE2FC  blr      x8
0066BE300  tbnz     w0, #0, #0x66be168
0066BE304  adrp     x8, #0x8ee6000
0066BE308  ldr      x8, [x8, #0x600]
0066BE30C  ldr      x1, [x8]
0066BE310  ldrb     w8, [x1, #0x53]
0066BE314  tbnz     w8, #5, #0x66be320
0066BE318  ldr      x21, [x19, #0x38]
0066BE31C  b        #0x66be330 ; 
0066BE320  ldr      x8, [x1, #0x60]
0066BE324  mov      x0, x19
0066BE328  blr      x8
0066BE32C  mov      x21, x0
0066BE330  cbz      x21, #0x66be4f4
0066BE334  adrp     x26, #0x9591000
0066BE338  ldrb     w8, [x26, #0xa74]
0066BE33C  cbnz     w8, #0x66be354
0066BE340  adrp     x0, #0x8ee6000
0066BE344  ldr      x0, [x0, #0x288]
0066BE348  bl       #0x382bd14 ; 
0066BE34C  mov      w8, #1
0066BE350  strb     w8, [x26, #0xa74]
0066BE354  adrp     x8, #0x8ee6000
0066BE358  ldr      x8, [x8, #0x288]
0066BE35C  ldr      x1, [x8]
0066BE360  ldrb     w8, [x1, #0x53]
0066BE364  tbnz     w8, #5, #0x66be370
0066BE368  ldr      x21, [x21, #0x170]
0066BE36C  b        #0x66be380 ; 
0066BE370  ldr      x8, [x1, #0x60]
0066BE374  mov      x0, x21
0066BE378  blr      x8
0066BE37C  mov      x21, x0
0066BE380  cbz      x21, #0x66be4f4
0066BE384  adrp     x26, #0x9599000
0066BE388  ldrb     w8, [x26, #0x90d]
0066BE38C  cbnz     w8, #0x66be3a4
0066BE390  adrp     x0, #0x8f0c000
0066BE394  ldr      x0, [x0, #0x90]
0066BE398  bl       #0x382bd14 ; 
0066BE39C  mov      w8, #1
0066BE3A0  strb     w8, [x26, #0x90d]
0066BE3A4  adrp     x8, #0x8f0c000
0066BE3A8  ldr      x8, [x8, #0x90]
0066BE3AC  ldr      x1, [x8]
0066BE3B0  ldrb     w8, [x1, #0x53]
0066BE3B4  tbnz     w8, #5, #0x66be3c0
0066BE3B8  ldr      w21, [x21, #0x5c]
0066BE3BC  b        #0x66be3d0 ; 
0066BE3C0  ldr      x8, [x1, #0x60]
0066BE3C4  mov      x0, x21
0066BE3C8  blr      x8
0066BE3CC  mov      w21, w0
0066BE3D0  mov      w9, #0x423d
0066BE3D4  sub      w8, w21, #1
0066BE3D8  movk     w9, #0xf, lsl #16
0066BE3DC  cmp      w8, w9
0066BE3E0  b.hi     #0x66be168
0066BE3E4  ldr      x1, [x25]
0066BE3E8  ldr      x25, [x20, #0x70]
0066BE3EC  ldrb     w8, [x1, #0x53]
0066BE3F0  tbnz     w8, #5, #0x66be3fc
0066BE3F4  ldr      x19, [x19, #0x30]
0066BE3F8  b        #0x66be40c ; 
0066BE3FC  ldr      x8, [x1, #0x60]
0066BE400  mov      x0, x19
0066BE404  blr      x8
0066BE408  mov      x19, x0
0066BE40C  adrp     x8, #0x8ec2000
0066BE410  ldr      x8, [x8, #0xbc8]
0066BE414  mov      w1, #2
0066BE418  ldr      x0, [x8]
0066BE41C  bl       #0x382bdfc ; 
0066BE420  adrp     x8, #0x8ee8000
0066BE424  ldr      x8, [x8, #0x350]
0066BE428  mov      x20, x0
0066BE42C  add      x1, sp, #0x20
0066BE430  stp      x22, xzr, [sp, #0x20]
0066BE434  ldr      x0, [x8]
0066BE438  str      x24, [sp, #0x30]
0066BE43C  bl       #0x382be94 ; 
0066BE440  cbz      x20, #0x66be4f4
0066BE444  mov      x22, x0
0066BE448  cbz      x0, #0x66be460
0066BE44C  ldr      x8, [x20]
0066BE450  mov      x0, x22
0066BE454  ldr      x1, [x8, #0x40]
0066BE458  bl       #0x382be90 ; 
0066BE45C  cbz      x0, #0x66be4fc
0066BE460  ldr      w8, [x20, #0x18]
0066BE464  cbz      w8, #0x66be4f8
0066BE468  mov      x0, x20
0066BE46C  mov      w8, w21
0066BE470  str      x22, [x0, #0x20]!
0066BE474  mov      x1, x22
0066BE478  sdiv     x21, x25, x8
0066BE47C  bl       #0x382bcb8 ; 
0066BE480  adrp     x8, #0x8ee2000
0066BE484  ldr      x8, [x8, #0x970]
0066BE488  add      x1, sp, #8
0066BE48C  str      x21, [sp, #8]
0066BE490  ldr      x0, [x8]
0066BE494  bl       #0x382be94 ; 
0066BE498  mov      x21, x0
0066BE49C  cbz      x0, #0x66be4b4
0066BE4A0  ldr      x8, [x20]
0066BE4A4  mov      x0, x21
0066BE4A8  ldr      x1, [x8, #0x40]
0066BE4AC  bl       #0x382be90 ; 
0066BE4B0  cbz      x0, #0x66be4fc
0066BE4B4  ldr      w8, [x20, #0x18]
0066BE4B8  cmp      w8, #1
0066BE4BC  b.ls     #0x66be4f8
0066BE4C0  mov      x0, x20
0066BE4C4  str      x21, [x0, #0x28]!
0066BE4C8  mov      x1, x21
0066BE4CC  bl       #0x382bcb8 ; 
0066BE4D0  cbz      x19, #0x66be4f4
0066BE4D4  adrp     x8, #0x8ee6000
0066BE4D8  ldr      x8, [x8, #0xab0]
0066BE4DC  mov      w1, #0xa
0066BE4E0  mov      x0, x19
0066BE4E4  mov      x2, x20
0066BE4E8  ldr      x3, [x8]
0066BE4EC  bl       #0x60b3770 ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0066BE4F0  b        #0x66be168 ; 
0066BE4F4  bl       #0x382bfb8 ; 
0066BE4F8  bl       #0x382bfc0 ; 
0066BE4FC  bl       #0x382bfdc ; 
0066BE500  mov      x1, xzr
0066BE504  bl       #0x382be7c ; 
0066BE508  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCountDict
; RVA 0x66BF220; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BF220  stp      x30, x21, [sp, #-0x20]!
0066BF224  stp      x20, x19, [sp, #0x10]
0066BF228  adrp     x20, #0x959a000
0066BF22C  adrp     x21, #0x8f11000
0066BF230  ldrb     w8, [x20, #0x217]
0066BF234  ldr      x21, [x21, #0xbf8]
0066BF238  mov      x19, x0
0066BF23C  tbnz     w8, #0, #0x66bf254
0066BF240  adrp     x0, #0x8f11000
0066BF244  ldr      x0, [x0, #0xbf8]
0066BF248  bl       #0x382bd14 ; 
0066BF24C  mov      w8, #1
0066BF250  strb     w8, [x20, #0x217]
0066BF254  ldr      x1, [x21]
0066BF258  ldrb     w8, [x1, #0x53]
0066BF25C  tbnz     w8, #5, #0x66bf270
0066BF260  ldr      x0, [x19, #0x50]
0066BF264  ldp      x20, x19, [sp, #0x10]
0066BF268  ldp      x30, x21, [sp], #0x20
0066BF26C  ret      
0066BF270  ldr      x2, [x1, #0x60]
0066BF274  mov      x0, x19
0066BF278  ldp      x20, x19, [sp, #0x10]
0066BF27C  ldp      x30, x21, [sp], #0x20
0066BF280  br       x2

; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponHittedCount
; RVA 0x66BBBD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BBBD8  sub      sp, sp, #0x50
0066BBBDC  stp      x30, x23, [sp, #0x20]
0066BBBE0  stp      x22, x21, [sp, #0x30]
0066BBBE4  stp      x20, x19, [sp, #0x40]
0066BBBE8  adrp     x22, #0x959a000
0066BBBEC  str      x2, [sp, #0x18]
0066BBBF0  adrp     x23, #0x8f11000
0066BBBF4  ldrb     w8, [x22, #0x218]
0066BBBF8  ldr      x23, [x23, #0xab0]
0066BBBFC  mov      x21, x2
0066BBC00  mov      x20, x1
0066BBC04  mov      x19, x0
0066BBC08  tbnz     w8, #0, #0x66bbc5c
0066BBC0C  adrp     x0, #0x8f11000
0066BBC10  ldr      x0, [x0, #0xab0]
0066BBC14  bl       #0x382bd14 ; 
0066BBC18  adrp     x0, #0x8f11000
0066BBC1C  ldr      x0, [x0, #0xa40]
0066BBC20  bl       #0x382bd14 ; 
0066BBC24  adrp     x0, #0x8f11000
0066BBC28  ldr      x0, [x0, #0xab8]
0066BBC2C  bl       #0x382bd14 ; 
0066BBC30  adrp     x0, #0x8f11000
0066BBC34  ldr      x0, [x0, #0xac0]
0066BBC38  bl       #0x382bd14 ; 
0066BBC3C  adrp     x0, #0x8f11000
0066BBC40  ldr      x0, [x0, #0xac8]
0066BBC44  bl       #0x382bd14 ; 
0066BBC48  adrp     x0, #0x8f11000
0066BBC4C  ldr      x0, [x0, #0xad0]
0066BBC50  bl       #0x382bd14 ; 
0066BBC54  mov      w8, #1
0066BBC58  strb     w8, [x22, #0x218]
0066BBC5C  ldr      x3, [x23]
0066BBC60  ldrb     w8, [x3, #0x53]
0066BBC64  tbnz     w8, #5, #0x66bbd5c
0066BBC68  add      x0, sp, #0x18
0066BBC6C  mov      x1, xzr
0066BBC70  str      xzr, [sp, #0x10]
0066BBC74  bl       #0x6a4c788 ; HotFix.BattleLogic.EntityCharacterTypeKey$$get_IsValid
0066BBC78  tbz      w0, #0, #0x66bbd80
0066BBC7C  adrp     x22, #0x8f11000
0066BBC80  ldr      x21, [x19, #0x50]
0066BBC84  ldr      x2, [sp, #0x18]
0066BBC88  ldr      x22, [x22, #0xac8]
0066BBC8C  mov      x0, sp
0066BBC90  mov      x1, x20
0066BBC94  stp      xzr, xzr, [sp]
0066BBC98  ldr      x3, [x22]
0066BBC9C  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BBCA0  cbz      x21, #0x66bbe18
0066BBCA4  adrp     x8, #0x8f11000
0066BBCA8  ldp      x1, x2, [sp]
0066BBCAC  ldr      x8, [x8, #0xab8]
0066BBCB0  add      x3, sp, #0x10
0066BBCB4  mov      x0, x21
0066BBCB8  ldr      x4, [x8]
0066BBCBC  bl       #0x5d68d54 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$TryGetValue
0066BBCC0  tbnz     w0, #0, #0x66bbd20
0066BBCC4  adrp     x8, #0x8f11000
0066BBCC8  ldr      x8, [x8, #0xad0]
0066BBCCC  ldr      x0, [x8]
0066BBCD0  bl       #0x382bfa0 ; 
0066BBCD4  mov      x1, xzr
0066BBCD8  mov      x21, x0
0066BBCDC  bl       #0x670570c ; HotFix.BattleLogic.CharacterComponentOnHit.WeaponHittedCountData$$.ctor
0066BBCE0  stp      xzr, x21, [sp, #8]
0066BBCE4  ldr      x2, [sp, #0x18]
0066BBCE8  ldr      x3, [x22]
0066BBCEC  ldr      x21, [x19, #0x50]
0066BBCF0  mov      x0, sp
0066BBCF4  mov      x1, x20
0066BBCF8  str      xzr, [sp]
0066BBCFC  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BBD00  cbz      x21, #0x66bbe18
0066BBD04  adrp     x8, #0x8f11000
0066BBD08  ldp      x2, x3, [sp, #8]
0066BBD0C  ldr      x1, [sp]
0066BBD10  ldr      x8, [x8, #0xac0]
0066BBD14  mov      x0, x21
0066BBD18  ldr      x4, [x8]
0066BBD1C  bl       #0x5d672b4 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$set_Item
0066BBD20  adrp     x20, #0x9591000
0066BBD24  ldrb     w8, [x20, #0xa4b]
0066BBD28  cbnz     w8, #0x66bbd40
0066BBD2C  adrp     x0, #0x8ee5000
0066BBD30  ldr      x0, [x0, #0xb28]
0066BBD34  bl       #0x382bd14 ; 
0066BBD38  mov      w8, #1
0066BBD3C  strb     w8, [x20, #0xa4b]
0066BBD40  adrp     x8, #0x8ee5000
0066BBD44  ldr      x8, [x8, #0xb28]
0066BBD48  ldr      x1, [x8]
0066BBD4C  ldrb     w8, [x1, #0x53]
0066BBD50  tbnz     w8, #5, #0x66bbd88
0066BBD54  ldr      x0, [x19, #0x20]
0066BBD58  b        #0x66bbd94 ; 
0066BBD5C  ldr      x4, [x3, #0x60]
0066BBD60  mov      x0, x19
0066BBD64  mov      x1, x20
0066BBD68  mov      x2, x21
0066BBD6C  ldp      x20, x19, [sp, #0x40]
0066BBD70  ldp      x22, x21, [sp, #0x30]
0066BBD74  ldp      x30, x23, [sp, #0x20]
0066BBD78  add      sp, sp, #0x50
0066BBD7C  br       x4
0066BBD80  mov      w0, wzr
0066BBD84  b        #0x66bbe04 ; 
0066BBD88  ldr      x8, [x1, #0x60]
0066BBD8C  mov      x0, x19
0066BBD90  blr      x8
0066BBD94  cbz      x0, #0x66bbe18
0066BBD98  ldr      x9, [sp, #0x10]
0066BBD9C  cbz      x9, #0x66bbe18
0066BBDA0  adrp     x21, #0x8f11000
0066BBDA4  ldr      x21, [x21, #0xa40]
0066BBDA8  ldr      x19, [x0, #0x128]
0066BBDAC  ldr      x9, [x9, #0x18]
0066BBDB0  ldr      x8, [x21]
0066BBDB4  sub      x20, x19, x9
0066BBDB8  ldr      w10, [x8, #0xe0]
0066BBDBC  cbnz     w10, #0x66bbdcc
0066BBDC0  mov      x0, x8
0066BBDC4  bl       #0x382be8c ; 
0066BBDC8  ldr      x8, [x21]
0066BBDCC  ldr      x8, [x8, #0xb8]
0066BBDD0  ldr      x9, [x8]
0066BBDD4  ldr      x8, [sp, #0x10]
0066BBDD8  cmp      x20, x9
0066BBDDC  b.le     #0x66bbdf0
0066BBDE0  cbz      x8, #0x66bbe18
0066BBDE4  str      wzr, [x8, #0x10]
0066BBDE8  str      wzr, [x8, #0x20]
0066BBDEC  b        #0x66bbdf4 ; 
0066BBDF0  cbz      x8, #0x66bbe18
0066BBDF4  ldr      w9, [x8, #0x10]
0066BBDF8  str      x19, [x8, #0x18]
0066BBDFC  add      w0, w9, #1
0066BBE00  str      w0, [x8, #0x10]
0066BBE04  ldp      x20, x19, [sp, #0x40]
0066BBE08  ldp      x22, x21, [sp, #0x30]
0066BBE0C  ldp      x30, x23, [sp, #0x20]
0066BBE10  add      sp, sp, #0x50
0066BBE14  ret      
0066BBE18  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponHittedCount1s
; RVA 0x66BBE1C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BBE1C  sub      sp, sp, #0x50
0066BBE20  stp      x30, x23, [sp, #0x20]
0066BBE24  stp      x22, x21, [sp, #0x30]
0066BBE28  stp      x20, x19, [sp, #0x40]
0066BBE2C  adrp     x22, #0x959a000
0066BBE30  str      x2, [sp, #0x18]
0066BBE34  adrp     x23, #0x8f11000
0066BBE38  ldrb     w8, [x22, #0x219]
0066BBE3C  ldr      x23, [x23, #0xad8]
0066BBE40  mov      x21, x2
0066BBE44  mov      x20, x1
0066BBE48  mov      x19, x0
0066BBE4C  tbnz     w8, #0, #0x66bbea0
0066BBE50  adrp     x0, #0x8f11000
0066BBE54  ldr      x0, [x0, #0xad8]
0066BBE58  bl       #0x382bd14 ; 
0066BBE5C  adrp     x0, #0x8f11000
0066BBE60  ldr      x0, [x0, #0xa40]
0066BBE64  bl       #0x382bd14 ; 
0066BBE68  adrp     x0, #0x8f11000
0066BBE6C  ldr      x0, [x0, #0xab8]
0066BBE70  bl       #0x382bd14 ; 
0066BBE74  adrp     x0, #0x8f11000
0066BBE78  ldr      x0, [x0, #0xac0]
0066BBE7C  bl       #0x382bd14 ; 
0066BBE80  adrp     x0, #0x8f11000
0066BBE84  ldr      x0, [x0, #0xac8]
0066BBE88  bl       #0x382bd14 ; 
0066BBE8C  adrp     x0, #0x8f11000
0066BBE90  ldr      x0, [x0, #0xad0]
0066BBE94  bl       #0x382bd14 ; 
0066BBE98  mov      w8, #1
0066BBE9C  strb     w8, [x22, #0x219]
0066BBEA0  ldr      x3, [x23]
0066BBEA4  ldrb     w8, [x3, #0x53]
0066BBEA8  tbnz     w8, #5, #0x66bbfa0
0066BBEAC  add      x0, sp, #0x18
0066BBEB0  mov      x1, xzr
0066BBEB4  str      xzr, [sp, #0x10]
0066BBEB8  bl       #0x6a4c788 ; HotFix.BattleLogic.EntityCharacterTypeKey$$get_IsValid
0066BBEBC  tbz      w0, #0, #0x66bbfc4
0066BBEC0  adrp     x22, #0x8f11000
0066BBEC4  ldr      x21, [x19, #0x58]
0066BBEC8  ldr      x2, [sp, #0x18]
0066BBECC  ldr      x22, [x22, #0xac8]
0066BBED0  mov      x0, sp
0066BBED4  mov      x1, x20
0066BBED8  stp      xzr, xzr, [sp]
0066BBEDC  ldr      x3, [x22]
0066BBEE0  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BBEE4  cbz      x21, #0x66bc05c
0066BBEE8  adrp     x8, #0x8f11000
0066BBEEC  ldp      x1, x2, [sp]
0066BBEF0  ldr      x8, [x8, #0xab8]
0066BBEF4  add      x3, sp, #0x10
0066BBEF8  mov      x0, x21
0066BBEFC  ldr      x4, [x8]
0066BBF00  bl       #0x5d68d54 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$TryGetValue
0066BBF04  tbnz     w0, #0, #0x66bbf64
0066BBF08  adrp     x8, #0x8f11000
0066BBF0C  ldr      x8, [x8, #0xad0]
0066BBF10  ldr      x0, [x8]
0066BBF14  bl       #0x382bfa0 ; 
0066BBF18  mov      x1, xzr
0066BBF1C  mov      x21, x0
0066BBF20  bl       #0x670570c ; HotFix.BattleLogic.CharacterComponentOnHit.WeaponHittedCountData$$.ctor
0066BBF24  stp      xzr, x21, [sp, #8]
0066BBF28  ldr      x2, [sp, #0x18]
0066BBF2C  ldr      x3, [x22]
0066BBF30  ldr      x21, [x19, #0x58]
0066BBF34  mov      x0, sp
0066BBF38  mov      x1, x20
0066BBF3C  str      xzr, [sp]
0066BBF40  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BBF44  cbz      x21, #0x66bc05c
0066BBF48  adrp     x8, #0x8f11000
0066BBF4C  ldp      x2, x3, [sp, #8]
0066BBF50  ldr      x1, [sp]
0066BBF54  ldr      x8, [x8, #0xac0]
0066BBF58  mov      x0, x21
0066BBF5C  ldr      x4, [x8]
0066BBF60  bl       #0x5d672b4 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$set_Item
0066BBF64  adrp     x20, #0x9591000
0066BBF68  ldrb     w8, [x20, #0xa4b]
0066BBF6C  cbnz     w8, #0x66bbf84
0066BBF70  adrp     x0, #0x8ee5000
0066BBF74  ldr      x0, [x0, #0xb28]
0066BBF78  bl       #0x382bd14 ; 
0066BBF7C  mov      w8, #1
0066BBF80  strb     w8, [x20, #0xa4b]
0066BBF84  adrp     x8, #0x8ee5000
0066BBF88  ldr      x8, [x8, #0xb28]
0066BBF8C  ldr      x1, [x8]
0066BBF90  ldrb     w8, [x1, #0x53]
0066BBF94  tbnz     w8, #5, #0x66bbfcc
0066BBF98  ldr      x0, [x19, #0x20]
0066BBF9C  b        #0x66bbfd8 ; 
0066BBFA0  ldr      x4, [x3, #0x60]
0066BBFA4  mov      x0, x19
0066BBFA8  mov      x1, x20
0066BBFAC  mov      x2, x21
0066BBFB0  ldp      x20, x19, [sp, #0x40]
0066BBFB4  ldp      x22, x21, [sp, #0x30]
0066BBFB8  ldp      x30, x23, [sp, #0x20]
0066BBFBC  add      sp, sp, #0x50
0066BBFC0  br       x4
0066BBFC4  mov      w0, wzr
0066BBFC8  b        #0x66bc048 ; 
0066BBFCC  ldr      x8, [x1, #0x60]
0066BBFD0  mov      x0, x19
0066BBFD4  blr      x8
0066BBFD8  cbz      x0, #0x66bc05c
0066BBFDC  ldr      x9, [sp, #0x10]
0066BBFE0  cbz      x9, #0x66bc05c
0066BBFE4  adrp     x21, #0x8f11000
0066BBFE8  ldr      x21, [x21, #0xa40]
0066BBFEC  ldr      x19, [x0, #0x128]
0066BBFF0  ldr      x9, [x9, #0x18]
0066BBFF4  ldr      x8, [x21]
0066BBFF8  sub      x20, x19, x9
0066BBFFC  ldr      w10, [x8, #0xe0]
0066BC000  cbnz     w10, #0x66bc010
0066BC004  mov      x0, x8
0066BC008  bl       #0x382be8c ; 
0066BC00C  ldr      x8, [x21]
0066BC010  ldr      x8, [x8, #0xb8]
0066BC014  ldr      x9, [x8, #8]
0066BC018  ldr      x8, [sp, #0x10]
0066BC01C  cmp      x20, x9
0066BC020  b.le     #0x66bc034
0066BC024  cbz      x8, #0x66bc05c
0066BC028  str      wzr, [x8, #0x10]
0066BC02C  str      wzr, [x8, #0x20]
0066BC030  b        #0x66bc038 ; 
0066BC034  cbz      x8, #0x66bc05c
0066BC038  ldr      w9, [x8, #0x10]
0066BC03C  str      x19, [x8, #0x18]
0066BC040  add      w0, w9, #1
0066BC044  str      w0, [x8, #0x10]
0066BC048  ldp      x20, x19, [sp, #0x40]
0066BC04C  ldp      x22, x21, [sp, #0x30]
0066BC050  ldp      x30, x23, [sp, #0x20]
0066BC054  add      sp, sp, #0x50
0066BC058  ret      
0066BC05C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCount
; RVA 0x66BF284; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BF284  sub      sp, sp, #0x50
0066BF288  stp      x30, x23, [sp, #0x20]
0066BF28C  stp      x22, x21, [sp, #0x30]
0066BF290  stp      x20, x19, [sp, #0x40]
0066BF294  adrp     x22, #0x959a000
0066BF298  adrp     x23, #0x8f11000
0066BF29C  ldrb     w8, [x22, #0x21a]
0066BF2A0  ldr      x23, [x23, #0xc00]
0066BF2A4  mov      x20, x2
0066BF2A8  mov      x21, x1
0066BF2AC  mov      x19, x0
0066BF2B0  tbnz     w8, #0, #0x66bf2ec
0066BF2B4  adrp     x0, #0x8f11000
0066BF2B8  ldr      x0, [x0, #0xc00]
0066BF2BC  bl       #0x382bd14 ; 
0066BF2C0  adrp     x0, #0x8f11000
0066BF2C4  ldr      x0, [x0, #0xa40]
0066BF2C8  bl       #0x382bd14 ; 
0066BF2CC  adrp     x0, #0x8f11000
0066BF2D0  ldr      x0, [x0, #0xab8]
0066BF2D4  bl       #0x382bd14 ; 
0066BF2D8  adrp     x0, #0x8f11000
0066BF2DC  ldr      x0, [x0, #0xac8]
0066BF2E0  bl       #0x382bd14 ; 
0066BF2E4  mov      w8, #1
0066BF2E8  strb     w8, [x22, #0x21a]
0066BF2EC  ldr      x3, [x23]
0066BF2F0  ldrb     w8, [x3, #0x53]
0066BF2F4  tbnz     w8, #5, #0x66bf380
0066BF2F8  adrp     x8, #0x8f11000
0066BF2FC  ldr      x8, [x8, #0xac8]
0066BF300  stp      xzr, xzr, [sp, #0x10]
0066BF304  ldr      x22, [x19, #0x50]
0066BF308  add      x0, sp, #8
0066BF30C  ldr      x3, [x8]
0066BF310  mov      x1, x21
0066BF314  mov      x2, x20
0066BF318  str      xzr, [sp, #8]
0066BF31C  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BF320  cbz      x22, #0x66bf430
0066BF324  adrp     x8, #0x8f11000
0066BF328  ldp      x1, x2, [sp, #8]
0066BF32C  ldr      x8, [x8, #0xab8]
0066BF330  add      x3, sp, #0x18
0066BF334  mov      x0, x22
0066BF338  ldr      x4, [x8]
0066BF33C  bl       #0x5d68d54 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$TryGetValue
0066BF340  tbz      w0, #0, #0x66bf3a4
0066BF344  adrp     x20, #0x9591000
0066BF348  ldrb     w8, [x20, #0xa4b]
0066BF34C  cbnz     w8, #0x66bf364
0066BF350  adrp     x0, #0x8ee5000
0066BF354  ldr      x0, [x0, #0xb28]
0066BF358  bl       #0x382bd14 ; 
0066BF35C  mov      w8, #1
0066BF360  strb     w8, [x20, #0xa4b]
0066BF364  adrp     x8, #0x8ee5000
0066BF368  ldr      x8, [x8, #0xb28]
0066BF36C  ldr      x1, [x8]
0066BF370  ldrb     w8, [x1, #0x53]
0066BF374  tbnz     w8, #5, #0x66bf3ac
0066BF378  ldr      x0, [x19, #0x20]
0066BF37C  b        #0x66bf3b8 ; 
0066BF380  ldr      x4, [x3, #0x60]
0066BF384  mov      x0, x19
0066BF388  mov      x1, x21
0066BF38C  mov      x2, x20
0066BF390  ldp      x20, x19, [sp, #0x40]
0066BF394  ldp      x22, x21, [sp, #0x30]
0066BF398  ldp      x30, x23, [sp, #0x20]
0066BF39C  add      sp, sp, #0x50
0066BF3A0  br       x4
0066BF3A4  mov      w0, wzr
0066BF3A8  b        #0x66bf41c ; 
0066BF3AC  ldr      x8, [x1, #0x60]
0066BF3B0  mov      x0, x19
0066BF3B4  blr      x8
0066BF3B8  cbz      x0, #0x66bf430
0066BF3BC  ldr      x9, [sp, #0x18]
0066BF3C0  cbz      x9, #0x66bf430
0066BF3C4  adrp     x20, #0x8f11000
0066BF3C8  ldr      x20, [x20, #0xa40]
0066BF3CC  ldr      x10, [x0, #0x128]
0066BF3D0  ldr      x9, [x9, #0x18]
0066BF3D4  ldr      x8, [x20]
0066BF3D8  sub      x19, x10, x9
0066BF3DC  ldr      w11, [x8, #0xe0]
0066BF3E0  cbnz     w11, #0x66bf3f0
0066BF3E4  mov      x0, x8
0066BF3E8  bl       #0x382be8c ; 
0066BF3EC  ldr      x8, [x20]
0066BF3F0  ldr      x8, [x8, #0xb8]
0066BF3F4  ldr      x9, [x8]
0066BF3F8  ldr      x8, [sp, #0x18]
0066BF3FC  cmp      x19, x9
0066BF400  b.le     #0x66bf414
0066BF404  cbz      x8, #0x66bf430
0066BF408  str      wzr, [x8, #0x10]
0066BF40C  str      wzr, [x8, #0x20]
0066BF410  b        #0x66bf418 ; 
0066BF414  cbz      x8, #0x66bf430
0066BF418  ldr      w0, [x8, #0x10]
0066BF41C  ldp      x20, x19, [sp, #0x40]
0066BF420  ldp      x22, x21, [sp, #0x30]
0066BF424  ldp      x30, x23, [sp, #0x20]
0066BF428  add      sp, sp, #0x50
0066BF42C  ret      
0066BF430  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCount1s
; RVA 0x66BF434; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BF434  sub      sp, sp, #0x50
0066BF438  stp      x30, x23, [sp, #0x20]
0066BF43C  stp      x22, x21, [sp, #0x30]
0066BF440  stp      x20, x19, [sp, #0x40]
0066BF444  adrp     x22, #0x959a000
0066BF448  adrp     x23, #0x8f11000
0066BF44C  ldrb     w8, [x22, #0x21b]
0066BF450  ldr      x23, [x23, #0xc08]
0066BF454  mov      x20, x2
0066BF458  mov      x21, x1
0066BF45C  mov      x19, x0
0066BF460  tbnz     w8, #0, #0x66bf49c
0066BF464  adrp     x0, #0x8f11000
0066BF468  ldr      x0, [x0, #0xc08]
0066BF46C  bl       #0x382bd14 ; 
0066BF470  adrp     x0, #0x8f11000
0066BF474  ldr      x0, [x0, #0xa40]
0066BF478  bl       #0x382bd14 ; 
0066BF47C  adrp     x0, #0x8f11000
0066BF480  ldr      x0, [x0, #0xab8]
0066BF484  bl       #0x382bd14 ; 
0066BF488  adrp     x0, #0x8f11000
0066BF48C  ldr      x0, [x0, #0xac8]
0066BF490  bl       #0x382bd14 ; 
0066BF494  mov      w8, #1
0066BF498  strb     w8, [x22, #0x21b]
0066BF49C  ldr      x3, [x23]
0066BF4A0  ldrb     w8, [x3, #0x53]
0066BF4A4  tbnz     w8, #5, #0x66bf530
0066BF4A8  adrp     x8, #0x8f11000
0066BF4AC  ldr      x8, [x8, #0xac8]
0066BF4B0  stp      xzr, xzr, [sp, #0x10]
0066BF4B4  ldr      x22, [x19, #0x58]
0066BF4B8  add      x0, sp, #8
0066BF4BC  ldr      x3, [x8]
0066BF4C0  mov      x1, x21
0066BF4C4  mov      x2, x20
0066BF4C8  str      xzr, [sp, #8]
0066BF4CC  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BF4D0  cbz      x22, #0x66bf5e0
0066BF4D4  adrp     x8, #0x8f11000
0066BF4D8  ldp      x1, x2, [sp, #8]
0066BF4DC  ldr      x8, [x8, #0xab8]
0066BF4E0  add      x3, sp, #0x18
0066BF4E4  mov      x0, x22
0066BF4E8  ldr      x4, [x8]
0066BF4EC  bl       #0x5d68d54 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$TryGetValue
0066BF4F0  tbz      w0, #0, #0x66bf554
0066BF4F4  adrp     x20, #0x9591000
0066BF4F8  ldrb     w8, [x20, #0xa4b]
0066BF4FC  cbnz     w8, #0x66bf514
0066BF500  adrp     x0, #0x8ee5000
0066BF504  ldr      x0, [x0, #0xb28]
0066BF508  bl       #0x382bd14 ; 
0066BF50C  mov      w8, #1
0066BF510  strb     w8, [x20, #0xa4b]
0066BF514  adrp     x8, #0x8ee5000
0066BF518  ldr      x8, [x8, #0xb28]
0066BF51C  ldr      x1, [x8]
0066BF520  ldrb     w8, [x1, #0x53]
0066BF524  tbnz     w8, #5, #0x66bf55c
0066BF528  ldr      x0, [x19, #0x20]
0066BF52C  b        #0x66bf568 ; 
0066BF530  ldr      x4, [x3, #0x60]
0066BF534  mov      x0, x19
0066BF538  mov      x1, x21
0066BF53C  mov      x2, x20
0066BF540  ldp      x20, x19, [sp, #0x40]
0066BF544  ldp      x22, x21, [sp, #0x30]
0066BF548  ldp      x30, x23, [sp, #0x20]
0066BF54C  add      sp, sp, #0x50
0066BF550  br       x4
0066BF554  mov      w0, wzr
0066BF558  b        #0x66bf5cc ; 
0066BF55C  ldr      x8, [x1, #0x60]
0066BF560  mov      x0, x19
0066BF564  blr      x8
0066BF568  cbz      x0, #0x66bf5e0
0066BF56C  ldr      x9, [sp, #0x18]
0066BF570  cbz      x9, #0x66bf5e0
0066BF574  adrp     x20, #0x8f11000
0066BF578  ldr      x20, [x20, #0xa40]
0066BF57C  ldr      x10, [x0, #0x128]
0066BF580  ldr      x9, [x9, #0x18]
0066BF584  ldr      x8, [x20]
0066BF588  sub      x19, x10, x9
0066BF58C  ldr      w11, [x8, #0xe0]
0066BF590  cbnz     w11, #0x66bf5a0
0066BF594  mov      x0, x8
0066BF598  bl       #0x382be8c ; 
0066BF59C  ldr      x8, [x20]
0066BF5A0  ldr      x8, [x8, #0xb8]
0066BF5A4  ldr      x9, [x8, #8]
0066BF5A8  ldr      x8, [sp, #0x18]
0066BF5AC  cmp      x19, x9
0066BF5B0  b.le     #0x66bf5c4
0066BF5B4  cbz      x8, #0x66bf5e0
0066BF5B8  str      wzr, [x8, #0x10]
0066BF5BC  str      wzr, [x8, #0x20]
0066BF5C0  b        #0x66bf5c8 ; 
0066BF5C4  cbz      x8, #0x66bf5e0
0066BF5C8  ldr      w0, [x8, #0x10]
0066BF5CC  ldp      x20, x19, [sp, #0x40]
0066BF5D0  ldp      x22, x21, [sp, #0x30]
0066BF5D4  ldp      x30, x23, [sp, #0x20]
0066BF5D8  add      sp, sp, #0x50
0066BF5DC  ret      
0066BF5E0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCountByComboInterval
; RVA 0x66BF5E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BF5E4  str      x30, [sp, #-0x40]!
0066BF5E8  stp      x24, x23, [sp, #0x10]
0066BF5EC  stp      x22, x21, [sp, #0x20]
0066BF5F0  stp      x20, x19, [sp, #0x30]
0066BF5F4  adrp     x23, #0x959a000
0066BF5F8  adrp     x24, #0x8f11000
0066BF5FC  ldrb     w8, [x23, #0x21c]
0066BF600  ldr      x24, [x24, #0xc10]
0066BF604  mov      w21, w3
0066BF608  mov      x19, x2
0066BF60C  mov      x20, x1
0066BF610  mov      x22, x0
0066BF614  tbnz     w8, #0, #0x66bf62c
0066BF618  adrp     x0, #0x8f11000
0066BF61C  ldr      x0, [x0, #0xc10]
0066BF620  bl       #0x382bd14 ; 
0066BF624  mov      w8, #1
0066BF628  strb     w8, [x23, #0x21c]
0066BF62C  ldr      x4, [x24]
0066BF630  ldrb     w8, [x4, #0x53]
0066BF634  tbnz     w8, #5, #0x66bf660
0066BF638  mov      x0, x22
0066BF63C  mov      x1, x20
0066BF640  mov      x2, x19
0066BF644  cmp      w21, #1
0066BF648  b.ne     #0x66bf688
0066BF64C  ldp      x20, x19, [sp, #0x30]
0066BF650  ldp      x22, x21, [sp, #0x20]
0066BF654  ldp      x24, x23, [sp, #0x10]
0066BF658  ldr      x30, [sp], #0x40
0066BF65C  b        #0x66bf434 ; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCount1s
0066BF660  ldr      x5, [x4, #0x60]
0066BF664  mov      x0, x22
0066BF668  mov      x1, x20
0066BF66C  mov      x2, x19
0066BF670  mov      w3, w21
0066BF674  ldp      x20, x19, [sp, #0x30]
0066BF678  ldp      x22, x21, [sp, #0x20]
0066BF67C  ldp      x24, x23, [sp, #0x10]
0066BF680  ldr      x30, [sp], #0x40
0066BF684  br       x5
0066BF688  ldp      x20, x19, [sp, #0x30]
0066BF68C  ldp      x22, x21, [sp, #0x20]
0066BF690  ldp      x24, x23, [sp, #0x10]
0066BF694  ldr      x30, [sp], #0x40
0066BF698  b        #0x66bf284 ; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCount

; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponIdHittedCount
; RVA 0x66BC060; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BC060  sub      sp, sp, #0x50
0066BC064  stp      x30, x23, [sp, #0x20]
0066BC068  stp      x22, x21, [sp, #0x30]
0066BC06C  stp      x20, x19, [sp, #0x40]
0066BC070  adrp     x22, #0x959a000
0066BC074  adrp     x23, #0x8f11000
0066BC078  ldrb     w8, [x22, #0x21d]
0066BC07C  ldr      x23, [x23, #0xae0]
0066BC080  mov      w20, w2
0066BC084  mov      x21, x1
0066BC088  mov      x19, x0
0066BC08C  tbnz     w8, #0, #0x66bc0e0
0066BC090  adrp     x0, #0x8f11000
0066BC094  ldr      x0, [x0, #0xae0]
0066BC098  bl       #0x382bd14 ; 
0066BC09C  adrp     x0, #0x8f11000
0066BC0A0  ldr      x0, [x0, #0xa40]
0066BC0A4  bl       #0x382bd14 ; 
0066BC0A8  adrp     x0, #0x8f11000
0066BC0AC  ldr      x0, [x0, #0xae8]
0066BC0B0  bl       #0x382bd14 ; 
0066BC0B4  adrp     x0, #0x8f11000
0066BC0B8  ldr      x0, [x0, #0xaf0]
0066BC0BC  bl       #0x382bd14 ; 
0066BC0C0  adrp     x0, #0x8f11000
0066BC0C4  ldr      x0, [x0, #0xaf8]
0066BC0C8  bl       #0x382bd14 ; 
0066BC0CC  adrp     x0, #0x8f11000
0066BC0D0  ldr      x0, [x0, #0xad0]
0066BC0D4  bl       #0x382bd14 ; 
0066BC0D8  mov      w8, #1
0066BC0DC  strb     w8, [x22, #0x21d]
0066BC0E0  ldr      x3, [x23]
0066BC0E4  ldrb     w8, [x3, #0x53]
0066BC0E8  tbnz     w8, #5, #0x66bc1d8
0066BC0EC  cmp      w20, #1
0066BC0F0  str      xzr, [sp, #0x18]
0066BC0F4  b.lt     #0x66bc1fc
0066BC0F8  adrp     x23, #0x8f11000
0066BC0FC  ldr      x22, [x19, #0x60]
0066BC100  ldr      x23, [x23, #0xaf8]
0066BC104  add      x0, sp, #8
0066BC108  mov      x1, x21
0066BC10C  mov      w2, w20
0066BC110  ldr      x3, [x23]
0066BC114  stp      xzr, xzr, [sp, #8]
0066BC118  bl       #0x57d6bf8 ; System.ValueTuple<EntityRef, int>$$.ctor
0066BC11C  cbz      x22, #0x66bc290
0066BC120  adrp     x8, #0x8f11000
0066BC124  ldp      x1, x2, [sp, #8]
0066BC128  ldr      x8, [x8, #0xae8]
0066BC12C  add      x3, sp, #0x18
0066BC130  mov      x0, x22
0066BC134  ldr      x4, [x8]
0066BC138  bl       #0x5d6c70c ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$TryGetValue
0066BC13C  tbnz     w0, #0, #0x66bc19c
0066BC140  adrp     x8, #0x8f11000
0066BC144  ldr      x8, [x8, #0xad0]
0066BC148  ldr      x0, [x8]
0066BC14C  bl       #0x382bfa0 ; 
0066BC150  mov      x1, xzr
0066BC154  mov      x22, x0
0066BC158  bl       #0x670570c ; HotFix.BattleLogic.CharacterComponentOnHit.WeaponHittedCountData$$.ctor
0066BC15C  stp      xzr, x22, [sp, #0x10]
0066BC160  ldr      x3, [x23]
0066BC164  ldr      x22, [x19, #0x60]
0066BC168  add      x0, sp, #8
0066BC16C  mov      x1, x21
0066BC170  mov      w2, w20
0066BC174  str      xzr, [sp, #8]
0066BC178  bl       #0x57d6bf8 ; System.ValueTuple<EntityRef, int>$$.ctor
0066BC17C  cbz      x22, #0x66bc290
0066BC180  adrp     x8, #0x8f11000
0066BC184  ldp      x2, x3, [sp, #0x10]
0066BC188  ldr      x1, [sp, #8]
0066BC18C  ldr      x8, [x8, #0xaf0]
0066BC190  mov      x0, x22
0066BC194  ldr      x4, [x8]
0066BC198  bl       #0x5d6ac6c ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$set_Item
0066BC19C  adrp     x20, #0x9591000
0066BC1A0  ldrb     w8, [x20, #0xa4b]
0066BC1A4  cbnz     w8, #0x66bc1bc
0066BC1A8  adrp     x0, #0x8ee5000
0066BC1AC  ldr      x0, [x0, #0xb28]
0066BC1B0  bl       #0x382bd14 ; 
0066BC1B4  mov      w8, #1
0066BC1B8  strb     w8, [x20, #0xa4b]
0066BC1BC  adrp     x8, #0x8ee5000
0066BC1C0  ldr      x8, [x8, #0xb28]
0066BC1C4  ldr      x1, [x8]
0066BC1C8  ldrb     w8, [x1, #0x53]
0066BC1CC  tbnz     w8, #5, #0x66bc204
0066BC1D0  ldr      x0, [x19, #0x20]
0066BC1D4  b        #0x66bc210 ; 
0066BC1D8  ldr      x4, [x3, #0x60]
0066BC1DC  mov      x0, x19
0066BC1E0  mov      x1, x21
0066BC1E4  mov      w2, w20
0066BC1E8  ldp      x20, x19, [sp, #0x40]
0066BC1EC  ldp      x22, x21, [sp, #0x30]
0066BC1F0  ldp      x30, x23, [sp, #0x20]
0066BC1F4  add      sp, sp, #0x50
0066BC1F8  br       x4
0066BC1FC  mov      w0, wzr
0066BC200  b        #0x66bc27c ; 
0066BC204  ldr      x8, [x1, #0x60]
0066BC208  mov      x0, x19
0066BC20C  blr      x8
0066BC210  cbz      x0, #0x66bc290
0066BC214  ldr      x9, [sp, #0x18]
0066BC218  cbz      x9, #0x66bc290
0066BC21C  adrp     x21, #0x8f11000
0066BC220  ldr      x21, [x21, #0xa40]
0066BC224  ldr      x19, [x0, #0x128]
0066BC228  ldr      x9, [x9, #0x18]
0066BC22C  ldr      x8, [x21]
0066BC230  sub      x20, x19, x9
0066BC234  ldr      w10, [x8, #0xe0]
0066BC238  cbnz     w10, #0x66bc248
0066BC23C  mov      x0, x8
0066BC240  bl       #0x382be8c ; 
0066BC244  ldr      x8, [x21]
0066BC248  ldr      x8, [x8, #0xb8]
0066BC24C  ldr      x9, [x8]
0066BC250  ldr      x8, [sp, #0x18]
0066BC254  cmp      x20, x9
0066BC258  b.le     #0x66bc268
0066BC25C  cbz      x8, #0x66bc290
0066BC260  str      wzr, [x8, #0x10]
0066BC264  b        #0x66bc26c ; 
0066BC268  cbz      x8, #0x66bc290
0066BC26C  ldr      w9, [x8, #0x10]
0066BC270  str      x19, [x8, #0x18]
0066BC274  add      w0, w9, #1
0066BC278  str      w0, [x8, #0x10]
0066BC27C  ldp      x20, x19, [sp, #0x40]
0066BC280  ldp      x22, x21, [sp, #0x30]
0066BC284  ldp      x30, x23, [sp, #0x20]
0066BC288  add      sp, sp, #0x50
0066BC28C  ret      
0066BC290  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateWeaponIdHittedCount1s
; RVA 0x66BC294; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BC294  sub      sp, sp, #0x50
0066BC298  stp      x30, x23, [sp, #0x20]
0066BC29C  stp      x22, x21, [sp, #0x30]
0066BC2A0  stp      x20, x19, [sp, #0x40]
0066BC2A4  adrp     x22, #0x959a000
0066BC2A8  adrp     x23, #0x8f11000
0066BC2AC  ldrb     w8, [x22, #0x21e]
0066BC2B0  ldr      x23, [x23, #0xb00]
0066BC2B4  mov      w20, w2
0066BC2B8  mov      x21, x1
0066BC2BC  mov      x19, x0
0066BC2C0  tbnz     w8, #0, #0x66bc314
0066BC2C4  adrp     x0, #0x8f11000
0066BC2C8  ldr      x0, [x0, #0xb00]
0066BC2CC  bl       #0x382bd14 ; 
0066BC2D0  adrp     x0, #0x8f11000
0066BC2D4  ldr      x0, [x0, #0xa40]
0066BC2D8  bl       #0x382bd14 ; 
0066BC2DC  adrp     x0, #0x8f11000
0066BC2E0  ldr      x0, [x0, #0xae8]
0066BC2E4  bl       #0x382bd14 ; 
0066BC2E8  adrp     x0, #0x8f11000
0066BC2EC  ldr      x0, [x0, #0xaf0]
0066BC2F0  bl       #0x382bd14 ; 
0066BC2F4  adrp     x0, #0x8f11000
0066BC2F8  ldr      x0, [x0, #0xaf8]
0066BC2FC  bl       #0x382bd14 ; 
0066BC300  adrp     x0, #0x8f11000
0066BC304  ldr      x0, [x0, #0xad0]
0066BC308  bl       #0x382bd14 ; 
0066BC30C  mov      w8, #1
0066BC310  strb     w8, [x22, #0x21e]
0066BC314  ldr      x3, [x23]
0066BC318  ldrb     w8, [x3, #0x53]
0066BC31C  tbnz     w8, #5, #0x66bc40c
0066BC320  cmp      w20, #1
0066BC324  str      xzr, [sp, #0x18]
0066BC328  b.lt     #0x66bc430
0066BC32C  adrp     x23, #0x8f11000
0066BC330  ldr      x22, [x19, #0x68]
0066BC334  ldr      x23, [x23, #0xaf8]
0066BC338  add      x0, sp, #8
0066BC33C  mov      x1, x21
0066BC340  mov      w2, w20
0066BC344  ldr      x3, [x23]
0066BC348  stp      xzr, xzr, [sp, #8]
0066BC34C  bl       #0x57d6bf8 ; System.ValueTuple<EntityRef, int>$$.ctor
0066BC350  cbz      x22, #0x66bc4c4
0066BC354  adrp     x8, #0x8f11000
0066BC358  ldp      x1, x2, [sp, #8]
0066BC35C  ldr      x8, [x8, #0xae8]
0066BC360  add      x3, sp, #0x18
0066BC364  mov      x0, x22
0066BC368  ldr      x4, [x8]
0066BC36C  bl       #0x5d6c70c ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$TryGetValue
0066BC370  tbnz     w0, #0, #0x66bc3d0
0066BC374  adrp     x8, #0x8f11000
0066BC378  ldr      x8, [x8, #0xad0]
0066BC37C  ldr      x0, [x8]
0066BC380  bl       #0x382bfa0 ; 
0066BC384  mov      x1, xzr
0066BC388  mov      x22, x0
0066BC38C  bl       #0x670570c ; HotFix.BattleLogic.CharacterComponentOnHit.WeaponHittedCountData$$.ctor
0066BC390  stp      xzr, x22, [sp, #0x10]
0066BC394  ldr      x3, [x23]
0066BC398  ldr      x22, [x19, #0x68]
0066BC39C  add      x0, sp, #8
0066BC3A0  mov      x1, x21
0066BC3A4  mov      w2, w20
0066BC3A8  str      xzr, [sp, #8]
0066BC3AC  bl       #0x57d6bf8 ; System.ValueTuple<EntityRef, int>$$.ctor
0066BC3B0  cbz      x22, #0x66bc4c4
0066BC3B4  adrp     x8, #0x8f11000
0066BC3B8  ldp      x2, x3, [sp, #0x10]
0066BC3BC  ldr      x1, [sp, #8]
0066BC3C0  ldr      x8, [x8, #0xaf0]
0066BC3C4  mov      x0, x22
0066BC3C8  ldr      x4, [x8]
0066BC3CC  bl       #0x5d6ac6c ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$set_Item
0066BC3D0  adrp     x20, #0x9591000
0066BC3D4  ldrb     w8, [x20, #0xa4b]
0066BC3D8  cbnz     w8, #0x66bc3f0
0066BC3DC  adrp     x0, #0x8ee5000
0066BC3E0  ldr      x0, [x0, #0xb28]
0066BC3E4  bl       #0x382bd14 ; 
0066BC3E8  mov      w8, #1
0066BC3EC  strb     w8, [x20, #0xa4b]
0066BC3F0  adrp     x8, #0x8ee5000
0066BC3F4  ldr      x8, [x8, #0xb28]
0066BC3F8  ldr      x1, [x8]
0066BC3FC  ldrb     w8, [x1, #0x53]
0066BC400  tbnz     w8, #5, #0x66bc438
0066BC404  ldr      x0, [x19, #0x20]
0066BC408  b        #0x66bc444 ; 
0066BC40C  ldr      x4, [x3, #0x60]
0066BC410  mov      x0, x19
0066BC414  mov      x1, x21
0066BC418  mov      w2, w20
0066BC41C  ldp      x20, x19, [sp, #0x40]
0066BC420  ldp      x22, x21, [sp, #0x30]
0066BC424  ldp      x30, x23, [sp, #0x20]
0066BC428  add      sp, sp, #0x50
0066BC42C  br       x4
0066BC430  mov      w0, wzr
0066BC434  b        #0x66bc4b0 ; 
0066BC438  ldr      x8, [x1, #0x60]
0066BC43C  mov      x0, x19
0066BC440  blr      x8
0066BC444  cbz      x0, #0x66bc4c4
0066BC448  ldr      x9, [sp, #0x18]
0066BC44C  cbz      x9, #0x66bc4c4
0066BC450  adrp     x21, #0x8f11000
0066BC454  ldr      x21, [x21, #0xa40]
0066BC458  ldr      x19, [x0, #0x128]
0066BC45C  ldr      x9, [x9, #0x18]
0066BC460  ldr      x8, [x21]
0066BC464  sub      x20, x19, x9
0066BC468  ldr      w10, [x8, #0xe0]
0066BC46C  cbnz     w10, #0x66bc47c
0066BC470  mov      x0, x8
0066BC474  bl       #0x382be8c ; 
0066BC478  ldr      x8, [x21]
0066BC47C  ldr      x8, [x8, #0xb8]
0066BC480  ldr      x9, [x8, #8]
0066BC484  ldr      x8, [sp, #0x18]
0066BC488  cmp      x20, x9
0066BC48C  b.le     #0x66bc49c
0066BC490  cbz      x8, #0x66bc4c4
0066BC494  str      wzr, [x8, #0x10]
0066BC498  b        #0x66bc4a0 ; 
0066BC49C  cbz      x8, #0x66bc4c4
0066BC4A0  ldr      w9, [x8, #0x10]
0066BC4A4  str      x19, [x8, #0x18]
0066BC4A8  add      w0, w9, #1
0066BC4AC  str      w0, [x8, #0x10]
0066BC4B0  ldp      x20, x19, [sp, #0x40]
0066BC4B4  ldp      x22, x21, [sp, #0x30]
0066BC4B8  ldp      x30, x23, [sp, #0x20]
0066BC4BC  add      sp, sp, #0x50
0066BC4C0  ret      
0066BC4C4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponIdHittedCount
; RVA 0x66BF69C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BF69C  sub      sp, sp, #0x50
0066BF6A0  stp      x30, x23, [sp, #0x20]
0066BF6A4  stp      x22, x21, [sp, #0x30]
0066BF6A8  stp      x20, x19, [sp, #0x40]
0066BF6AC  adrp     x22, #0x959a000
0066BF6B0  adrp     x23, #0x8f11000
0066BF6B4  ldrb     w8, [x22, #0x21f]
0066BF6B8  ldr      x23, [x23, #0xc18]
0066BF6BC  mov      w20, w2
0066BF6C0  mov      x21, x1
0066BF6C4  mov      x19, x0
0066BF6C8  tbnz     w8, #0, #0x66bf704
0066BF6CC  adrp     x0, #0x8f11000
0066BF6D0  ldr      x0, [x0, #0xc18]
0066BF6D4  bl       #0x382bd14 ; 
0066BF6D8  adrp     x0, #0x8f11000
0066BF6DC  ldr      x0, [x0, #0xa40]
0066BF6E0  bl       #0x382bd14 ; 
0066BF6E4  adrp     x0, #0x8f11000
0066BF6E8  ldr      x0, [x0, #0xae8]
0066BF6EC  bl       #0x382bd14 ; 
0066BF6F0  adrp     x0, #0x8f11000
0066BF6F4  ldr      x0, [x0, #0xaf8]
0066BF6F8  bl       #0x382bd14 ; 
0066BF6FC  mov      w8, #1
0066BF700  strb     w8, [x22, #0x21f]
0066BF704  ldr      x3, [x23]
0066BF708  ldrb     w8, [x3, #0x53]
0066BF70C  tbnz     w8, #5, #0x66bf798
0066BF710  adrp     x8, #0x8f11000
0066BF714  ldr      x8, [x8, #0xaf8]
0066BF718  stp      xzr, xzr, [sp, #0x10]
0066BF71C  ldr      x22, [x19, #0x60]
0066BF720  add      x0, sp, #8
0066BF724  ldr      x3, [x8]
0066BF728  mov      x1, x21
0066BF72C  mov      w2, w20
0066BF730  str      xzr, [sp, #8]
0066BF734  bl       #0x57d6bf8 ; System.ValueTuple<EntityRef, int>$$.ctor
0066BF738  cbz      x22, #0x66bf844
0066BF73C  adrp     x8, #0x8f11000
0066BF740  ldp      x1, x2, [sp, #8]
0066BF744  ldr      x8, [x8, #0xae8]
0066BF748  add      x3, sp, #0x18
0066BF74C  mov      x0, x22
0066BF750  ldr      x4, [x8]
0066BF754  bl       #0x5d6c70c ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$TryGetValue
0066BF758  tbz      w0, #0, #0x66bf7bc
0066BF75C  adrp     x20, #0x9591000
0066BF760  ldrb     w8, [x20, #0xa4b]
0066BF764  cbnz     w8, #0x66bf77c
0066BF768  adrp     x0, #0x8ee5000
0066BF76C  ldr      x0, [x0, #0xb28]
0066BF770  bl       #0x382bd14 ; 
0066BF774  mov      w8, #1
0066BF778  strb     w8, [x20, #0xa4b]
0066BF77C  adrp     x8, #0x8ee5000
0066BF780  ldr      x8, [x8, #0xb28]
0066BF784  ldr      x1, [x8]
0066BF788  ldrb     w8, [x1, #0x53]
0066BF78C  tbnz     w8, #5, #0x66bf7c4
0066BF790  ldr      x0, [x19, #0x20]
0066BF794  b        #0x66bf7d0 ; 
0066BF798  ldr      x4, [x3, #0x60]
0066BF79C  mov      x0, x19
0066BF7A0  mov      x1, x21
0066BF7A4  mov      w2, w20
0066BF7A8  ldp      x20, x19, [sp, #0x40]
0066BF7AC  ldp      x22, x21, [sp, #0x30]
0066BF7B0  ldp      x30, x23, [sp, #0x20]
0066BF7B4  add      sp, sp, #0x50
0066BF7B8  br       x4
0066BF7BC  mov      w0, wzr
0066BF7C0  b        #0x66bf830 ; 
0066BF7C4  ldr      x8, [x1, #0x60]
0066BF7C8  mov      x0, x19
0066BF7CC  blr      x8
0066BF7D0  cbz      x0, #0x66bf844
0066BF7D4  ldr      x9, [sp, #0x18]
0066BF7D8  cbz      x9, #0x66bf844
0066BF7DC  adrp     x20, #0x8f11000
0066BF7E0  ldr      x20, [x20, #0xa40]
0066BF7E4  ldr      x10, [x0, #0x128]
0066BF7E8  ldr      x9, [x9, #0x18]
0066BF7EC  ldr      x8, [x20]
0066BF7F0  sub      x19, x10, x9
0066BF7F4  ldr      w11, [x8, #0xe0]
0066BF7F8  cbnz     w11, #0x66bf808
0066BF7FC  mov      x0, x8
0066BF800  bl       #0x382be8c ; 
0066BF804  ldr      x8, [x20]
0066BF808  ldr      x8, [x8, #0xb8]
0066BF80C  ldr      x9, [x8]
0066BF810  ldr      x8, [sp, #0x18]
0066BF814  cmp      x19, x9
0066BF818  b.le     #0x66bf828
0066BF81C  cbz      x8, #0x66bf844
0066BF820  str      wzr, [x8, #0x10]
0066BF824  b        #0x66bf82c ; 
0066BF828  cbz      x8, #0x66bf844
0066BF82C  ldr      w0, [x8, #0x10]
0066BF830  ldp      x20, x19, [sp, #0x40]
0066BF834  ldp      x22, x21, [sp, #0x30]
0066BF838  ldp      x30, x23, [sp, #0x20]
0066BF83C  add      sp, sp, #0x50
0066BF840  ret      
0066BF844  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponIdHittedCount1s
; RVA 0x66BF848; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BF848  sub      sp, sp, #0x50
0066BF84C  stp      x30, x23, [sp, #0x20]
0066BF850  stp      x22, x21, [sp, #0x30]
0066BF854  stp      x20, x19, [sp, #0x40]
0066BF858  adrp     x22, #0x959a000
0066BF85C  adrp     x23, #0x8f11000
0066BF860  ldrb     w8, [x22, #0x220]
0066BF864  ldr      x23, [x23, #0xc20]
0066BF868  mov      w20, w2
0066BF86C  mov      x21, x1
0066BF870  mov      x19, x0
0066BF874  tbnz     w8, #0, #0x66bf8b0
0066BF878  adrp     x0, #0x8f11000
0066BF87C  ldr      x0, [x0, #0xc20]
0066BF880  bl       #0x382bd14 ; 
0066BF884  adrp     x0, #0x8f11000
0066BF888  ldr      x0, [x0, #0xa40]
0066BF88C  bl       #0x382bd14 ; 
0066BF890  adrp     x0, #0x8f11000
0066BF894  ldr      x0, [x0, #0xae8]
0066BF898  bl       #0x382bd14 ; 
0066BF89C  adrp     x0, #0x8f11000
0066BF8A0  ldr      x0, [x0, #0xaf8]
0066BF8A4  bl       #0x382bd14 ; 
0066BF8A8  mov      w8, #1
0066BF8AC  strb     w8, [x22, #0x220]
0066BF8B0  ldr      x3, [x23]
0066BF8B4  ldrb     w8, [x3, #0x53]
0066BF8B8  tbnz     w8, #5, #0x66bf944
0066BF8BC  adrp     x8, #0x8f11000
0066BF8C0  ldr      x8, [x8, #0xaf8]
0066BF8C4  stp      xzr, xzr, [sp, #0x10]
0066BF8C8  ldr      x22, [x19, #0x68]
0066BF8CC  add      x0, sp, #8
0066BF8D0  ldr      x3, [x8]
0066BF8D4  mov      x1, x21
0066BF8D8  mov      w2, w20
0066BF8DC  str      xzr, [sp, #8]
0066BF8E0  bl       #0x57d6bf8 ; System.ValueTuple<EntityRef, int>$$.ctor
0066BF8E4  cbz      x22, #0x66bf9f0
0066BF8E8  adrp     x8, #0x8f11000
0066BF8EC  ldp      x1, x2, [sp, #8]
0066BF8F0  ldr      x8, [x8, #0xae8]
0066BF8F4  add      x3, sp, #0x18
0066BF8F8  mov      x0, x22
0066BF8FC  ldr      x4, [x8]
0066BF900  bl       #0x5d6c70c ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$TryGetValue
0066BF904  tbz      w0, #0, #0x66bf968
0066BF908  adrp     x20, #0x9591000
0066BF90C  ldrb     w8, [x20, #0xa4b]
0066BF910  cbnz     w8, #0x66bf928
0066BF914  adrp     x0, #0x8ee5000
0066BF918  ldr      x0, [x0, #0xb28]
0066BF91C  bl       #0x382bd14 ; 
0066BF920  mov      w8, #1
0066BF924  strb     w8, [x20, #0xa4b]
0066BF928  adrp     x8, #0x8ee5000
0066BF92C  ldr      x8, [x8, #0xb28]
0066BF930  ldr      x1, [x8]
0066BF934  ldrb     w8, [x1, #0x53]
0066BF938  tbnz     w8, #5, #0x66bf970
0066BF93C  ldr      x0, [x19, #0x20]
0066BF940  b        #0x66bf97c ; 
0066BF944  ldr      x4, [x3, #0x60]
0066BF948  mov      x0, x19
0066BF94C  mov      x1, x21
0066BF950  mov      w2, w20
0066BF954  ldp      x20, x19, [sp, #0x40]
0066BF958  ldp      x22, x21, [sp, #0x30]
0066BF95C  ldp      x30, x23, [sp, #0x20]
0066BF960  add      sp, sp, #0x50
0066BF964  br       x4
0066BF968  mov      w0, wzr
0066BF96C  b        #0x66bf9dc ; 
0066BF970  ldr      x8, [x1, #0x60]
0066BF974  mov      x0, x19
0066BF978  blr      x8
0066BF97C  cbz      x0, #0x66bf9f0
0066BF980  ldr      x9, [sp, #0x18]
0066BF984  cbz      x9, #0x66bf9f0
0066BF988  adrp     x20, #0x8f11000
0066BF98C  ldr      x20, [x20, #0xa40]
0066BF990  ldr      x10, [x0, #0x128]
0066BF994  ldr      x9, [x9, #0x18]
0066BF998  ldr      x8, [x20]
0066BF99C  sub      x19, x10, x9
0066BF9A0  ldr      w11, [x8, #0xe0]
0066BF9A4  cbnz     w11, #0x66bf9b4
0066BF9A8  mov      x0, x8
0066BF9AC  bl       #0x382be8c ; 
0066BF9B0  ldr      x8, [x20]
0066BF9B4  ldr      x8, [x8, #0xb8]
0066BF9B8  ldr      x9, [x8, #8]
0066BF9BC  ldr      x8, [sp, #0x18]
0066BF9C0  cmp      x19, x9
0066BF9C4  b.le     #0x66bf9d4
0066BF9C8  cbz      x8, #0x66bf9f0
0066BF9CC  str      wzr, [x8, #0x10]
0066BF9D0  b        #0x66bf9d8 ; 
0066BF9D4  cbz      x8, #0x66bf9f0
0066BF9D8  ldr      w0, [x8, #0x10]
0066BF9DC  ldp      x20, x19, [sp, #0x40]
0066BF9E0  ldp      x22, x21, [sp, #0x30]
0066BF9E4  ldp      x30, x23, [sp, #0x20]
0066BF9E8  add      sp, sp, #0x50
0066BF9EC  ret      
0066BF9F0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponIdHittedCountByComboInterval
; RVA 0x66BF9F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BF9F4  str      x30, [sp, #-0x40]!
0066BF9F8  stp      x24, x23, [sp, #0x10]
0066BF9FC  stp      x22, x21, [sp, #0x20]
0066BFA00  stp      x20, x19, [sp, #0x30]
0066BFA04  adrp     x23, #0x959a000
0066BFA08  adrp     x24, #0x8f11000
0066BFA0C  ldrb     w8, [x23, #0x221]
0066BFA10  ldr      x24, [x24, #0xc28]
0066BFA14  mov      w21, w3
0066BFA18  mov      w19, w2
0066BFA1C  mov      x20, x1
0066BFA20  mov      x22, x0
0066BFA24  tbnz     w8, #0, #0x66bfa3c
0066BFA28  adrp     x0, #0x8f11000
0066BFA2C  ldr      x0, [x0, #0xc28]
0066BFA30  bl       #0x382bd14 ; 
0066BFA34  mov      w8, #1
0066BFA38  strb     w8, [x23, #0x221]
0066BFA3C  ldr      x4, [x24]
0066BFA40  ldrb     w8, [x4, #0x53]
0066BFA44  tbnz     w8, #5, #0x66bfa70
0066BFA48  mov      x0, x22
0066BFA4C  mov      x1, x20
0066BFA50  mov      w2, w19
0066BFA54  cmp      w21, #1
0066BFA58  b.ne     #0x66bfa98
0066BFA5C  ldp      x20, x19, [sp, #0x30]
0066BFA60  ldp      x22, x21, [sp, #0x20]
0066BFA64  ldp      x24, x23, [sp, #0x10]
0066BFA68  ldr      x30, [sp], #0x40
0066BFA6C  b        #0x66bf848 ; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponIdHittedCount1s
0066BFA70  ldr      x5, [x4, #0x60]
0066BFA74  mov      x0, x22
0066BFA78  mov      x1, x20
0066BFA7C  mov      w2, w19
0066BFA80  mov      w3, w21
0066BFA84  ldp      x20, x19, [sp, #0x30]
0066BFA88  ldp      x22, x21, [sp, #0x20]
0066BFA8C  ldp      x24, x23, [sp, #0x10]
0066BFA90  ldr      x30, [sp], #0x40
0066BFA94  br       x5
0066BFA98  ldp      x20, x19, [sp, #0x30]
0066BFA9C  ldp      x22, x21, [sp, #0x20]
0066BFAA0  ldp      x24, x23, [sp, #0x10]
0066BFAA4  ldr      x30, [sp], #0x40
0066BFAA8  b        #0x66bf69c ; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponIdHittedCount

; HotFix.BattleLogic.CharacterComponentOnHit$$ClearWeaponHittedCountOnce
; RVA 0x66BFAAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BFAAC  sub      sp, sp, #0x50
0066BFAB0  stp      x30, x23, [sp, #0x20]
0066BFAB4  stp      x22, x21, [sp, #0x30]
0066BFAB8  stp      x20, x19, [sp, #0x40]
0066BFABC  adrp     x22, #0x959a000
0066BFAC0  str      x2, [sp, #0x18]
0066BFAC4  adrp     x23, #0x8f11000
0066BFAC8  ldrb     w8, [x22, #0x222]
0066BFACC  ldr      x23, [x23, #0xc30]
0066BFAD0  mov      x21, x2
0066BFAD4  mov      x19, x1
0066BFAD8  mov      x20, x0
0066BFADC  tbnz     w8, #0, #0x66bfb24
0066BFAE0  adrp     x0, #0x8f11000
0066BFAE4  ldr      x0, [x0, #0xc30]
0066BFAE8  bl       #0x382bd14 ; 
0066BFAEC  adrp     x0, #0x8f11000
0066BFAF0  ldr      x0, [x0, #0xab8]
0066BFAF4  bl       #0x382bd14 ; 
0066BFAF8  adrp     x0, #0x8f11000
0066BFAFC  ldr      x0, [x0, #0xc38]
0066BFB00  bl       #0x382bd14 ; 
0066BFB04  adrp     x0, #0x8f11000
0066BFB08  ldr      x0, [x0, #0xc40]
0066BFB0C  bl       #0x382bd14 ; 
0066BFB10  adrp     x0, #0x8f11000
0066BFB14  ldr      x0, [x0, #0xac8]
0066BFB18  bl       #0x382bd14 ; 
0066BFB1C  mov      w8, #1
0066BFB20  strb     w8, [x22, #0x222]
0066BFB24  ldr      x3, [x23]
0066BFB28  ldrb     w8, [x3, #0x53]
0066BFB2C  tbnz     w8, #5, #0x66bfc24
0066BFB30  add      x0, sp, #0x18
0066BFB34  mov      x1, xzr
0066BFB38  str      xzr, [sp, #0x10]
0066BFB3C  bl       #0x6a4c788 ; HotFix.BattleLogic.EntityCharacterTypeKey$$get_IsValid
0066BFB40  tbz      w0, #0, #0x66bfc10
0066BFB44  adrp     x22, #0x8f11000
0066BFB48  ldr      x21, [x20, #0x70]
0066BFB4C  ldr      x2, [sp, #0x18]
0066BFB50  ldr      x22, [x22, #0xac8]
0066BFB54  mov      x0, sp
0066BFB58  mov      x1, x19
0066BFB5C  stp      xzr, xzr, [sp]
0066BFB60  ldr      x3, [x22]
0066BFB64  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BFB68  cbz      x21, #0x66bfc48
0066BFB6C  adrp     x8, #0x8f11000
0066BFB70  ldp      x1, x2, [sp]
0066BFB74  ldr      x8, [x8, #0xc40]
0066BFB78  mov      x0, x21
0066BFB7C  ldr      x3, [x8]
0066BFB80  bl       #0x4915700 ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$Contains
0066BFB84  tbnz     w0, #0, #0x66bfc10
0066BFB88  ldr      x2, [sp, #0x18]
0066BFB8C  ldr      x3, [x22]
0066BFB90  ldr      x21, [x20, #0x50]
0066BFB94  mov      x0, sp
0066BFB98  mov      x1, x19
0066BFB9C  stp      xzr, xzr, [sp]
0066BFBA0  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BFBA4  cbz      x21, #0x66bfc48
0066BFBA8  adrp     x8, #0x8f11000
0066BFBAC  ldp      x1, x2, [sp]
0066BFBB0  ldr      x8, [x8, #0xab8]
0066BFBB4  add      x3, sp, #0x10
0066BFBB8  mov      x0, x21
0066BFBBC  ldr      x4, [x8]
0066BFBC0  bl       #0x5d68d54 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$TryGetValue
0066BFBC4  tbz      w0, #0, #0x66bfbd8
0066BFBC8  ldr      x8, [sp, #0x10]
0066BFBCC  cbz      x8, #0x66bfc48
0066BFBD0  str      wzr, [x8, #0x10]
0066BFBD4  str      wzr, [x8, #0x20]
0066BFBD8  ldr      x2, [sp, #0x18]
0066BFBDC  ldr      x3, [x22]
0066BFBE0  ldr      x20, [x20, #0x70]
0066BFBE4  mov      x0, sp
0066BFBE8  mov      x1, x19
0066BFBEC  stp      xzr, xzr, [sp]
0066BFBF0  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BFBF4  cbz      x20, #0x66bfc48
0066BFBF8  adrp     x8, #0x8f11000
0066BFBFC  ldp      x1, x2, [sp]
0066BFC00  ldr      x8, [x8, #0xc38]
0066BFC04  mov      x0, x20
0066BFC08  ldr      x3, [x8]
0066BFC0C  bl       #0x4916240 ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$Add
0066BFC10  ldp      x20, x19, [sp, #0x40]
0066BFC14  ldp      x22, x21, [sp, #0x30]
0066BFC18  ldp      x30, x23, [sp, #0x20]
0066BFC1C  add      sp, sp, #0x50
0066BFC20  ret      
0066BFC24  ldr      x4, [x3, #0x60]
0066BFC28  mov      x0, x20
0066BFC2C  mov      x1, x19
0066BFC30  mov      x2, x21
0066BFC34  ldp      x20, x19, [sp, #0x40]
0066BFC38  ldp      x22, x21, [sp, #0x30]
0066BFC3C  ldp      x30, x23, [sp, #0x20]
0066BFC40  add      sp, sp, #0x50
0066BFC44  br       x4
0066BFC48  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$ClearWeaponHittedCountOnce1s
; RVA 0x66BFC4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BFC4C  sub      sp, sp, #0x50
0066BFC50  stp      x30, x23, [sp, #0x20]
0066BFC54  stp      x22, x21, [sp, #0x30]
0066BFC58  stp      x20, x19, [sp, #0x40]
0066BFC5C  adrp     x22, #0x959a000
0066BFC60  str      x2, [sp, #0x18]
0066BFC64  adrp     x23, #0x8f11000
0066BFC68  ldrb     w8, [x22, #0x223]
0066BFC6C  ldr      x23, [x23, #0xc48]
0066BFC70  mov      x21, x2
0066BFC74  mov      x19, x1
0066BFC78  mov      x20, x0
0066BFC7C  tbnz     w8, #0, #0x66bfcc4
0066BFC80  adrp     x0, #0x8f11000
0066BFC84  ldr      x0, [x0, #0xc48]
0066BFC88  bl       #0x382bd14 ; 
0066BFC8C  adrp     x0, #0x8f11000
0066BFC90  ldr      x0, [x0, #0xab8]
0066BFC94  bl       #0x382bd14 ; 
0066BFC98  adrp     x0, #0x8f11000
0066BFC9C  ldr      x0, [x0, #0xc38]
0066BFCA0  bl       #0x382bd14 ; 
0066BFCA4  adrp     x0, #0x8f11000
0066BFCA8  ldr      x0, [x0, #0xc40]
0066BFCAC  bl       #0x382bd14 ; 
0066BFCB0  adrp     x0, #0x8f11000
0066BFCB4  ldr      x0, [x0, #0xac8]
0066BFCB8  bl       #0x382bd14 ; 
0066BFCBC  mov      w8, #1
0066BFCC0  strb     w8, [x22, #0x223]
0066BFCC4  ldr      x3, [x23]
0066BFCC8  ldrb     w8, [x3, #0x53]
0066BFCCC  tbnz     w8, #5, #0x66bfdc4
0066BFCD0  add      x0, sp, #0x18
0066BFCD4  mov      x1, xzr
0066BFCD8  str      xzr, [sp, #0x10]
0066BFCDC  bl       #0x6a4c788 ; HotFix.BattleLogic.EntityCharacterTypeKey$$get_IsValid
0066BFCE0  tbz      w0, #0, #0x66bfdb0
0066BFCE4  adrp     x22, #0x8f11000
0066BFCE8  ldr      x21, [x20, #0x78]
0066BFCEC  ldr      x2, [sp, #0x18]
0066BFCF0  ldr      x22, [x22, #0xac8]
0066BFCF4  mov      x0, sp
0066BFCF8  mov      x1, x19
0066BFCFC  stp      xzr, xzr, [sp]
0066BFD00  ldr      x3, [x22]
0066BFD04  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BFD08  cbz      x21, #0x66bfde8
0066BFD0C  adrp     x8, #0x8f11000
0066BFD10  ldp      x1, x2, [sp]
0066BFD14  ldr      x8, [x8, #0xc40]
0066BFD18  mov      x0, x21
0066BFD1C  ldr      x3, [x8]
0066BFD20  bl       #0x4915700 ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$Contains
0066BFD24  tbnz     w0, #0, #0x66bfdb0
0066BFD28  ldr      x2, [sp, #0x18]
0066BFD2C  ldr      x3, [x22]
0066BFD30  ldr      x21, [x20, #0x58]
0066BFD34  mov      x0, sp
0066BFD38  mov      x1, x19
0066BFD3C  stp      xzr, xzr, [sp]
0066BFD40  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BFD44  cbz      x21, #0x66bfde8
0066BFD48  adrp     x8, #0x8f11000
0066BFD4C  ldp      x1, x2, [sp]
0066BFD50  ldr      x8, [x8, #0xab8]
0066BFD54  add      x3, sp, #0x10
0066BFD58  mov      x0, x21
0066BFD5C  ldr      x4, [x8]
0066BFD60  bl       #0x5d68d54 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$TryGetValue
0066BFD64  tbz      w0, #0, #0x66bfd78
0066BFD68  ldr      x8, [sp, #0x10]
0066BFD6C  cbz      x8, #0x66bfde8
0066BFD70  str      wzr, [x8, #0x10]
0066BFD74  str      wzr, [x8, #0x20]
0066BFD78  ldr      x2, [sp, #0x18]
0066BFD7C  ldr      x3, [x22]
0066BFD80  ldr      x20, [x20, #0x78]
0066BFD84  mov      x0, sp
0066BFD88  mov      x1, x19
0066BFD8C  stp      xzr, xzr, [sp]
0066BFD90  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BFD94  cbz      x20, #0x66bfde8
0066BFD98  adrp     x8, #0x8f11000
0066BFD9C  ldp      x1, x2, [sp]
0066BFDA0  ldr      x8, [x8, #0xc38]
0066BFDA4  mov      x0, x20
0066BFDA8  ldr      x3, [x8]
0066BFDAC  bl       #0x4916240 ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$Add
0066BFDB0  ldp      x20, x19, [sp, #0x40]
0066BFDB4  ldp      x22, x21, [sp, #0x30]
0066BFDB8  ldp      x30, x23, [sp, #0x20]
0066BFDBC  add      sp, sp, #0x50
0066BFDC0  ret      
0066BFDC4  ldr      x4, [x3, #0x60]
0066BFDC8  mov      x0, x20
0066BFDCC  mov      x1, x19
0066BFDD0  mov      x2, x21
0066BFDD4  ldp      x20, x19, [sp, #0x40]
0066BFDD8  ldp      x22, x21, [sp, #0x30]
0066BFDDC  ldp      x30, x23, [sp, #0x20]
0066BFDE0  add      sp, sp, #0x50
0066BFDE4  br       x4
0066BFDE8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$TryMarkSameEnemyMilestoneExplosionFired
; RVA 0x66BC7E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BC7E8  sub      sp, sp, #0x60
0066BC7EC  stp      x30, x25, [sp, #0x20]
0066BC7F0  stp      x24, x23, [sp, #0x30]
0066BC7F4  stp      x22, x21, [sp, #0x40]
0066BC7F8  stp      x20, x19, [sp, #0x50]
0066BC7FC  adrp     x24, #0x959a000
0066BC800  adrp     x25, #0x8f11000
0066BC804  ldrb     w8, [x24, #0x224]
0066BC808  ldr      x25, [x25, #0xb10]
0066BC80C  mov      w19, w4
0066BC810  mov      w23, w3
0066BC814  mov      x20, x2
0066BC818  mov      x21, x1
0066BC81C  mov      x22, x0
0066BC820  tbnz     w8, #0, #0x66bc850
0066BC824  adrp     x0, #0x8f11000
0066BC828  ldr      x0, [x0, #0xb10]
0066BC82C  bl       #0x382bd14 ; 
0066BC830  adrp     x0, #0x8f11000
0066BC834  ldr      x0, [x0, #0xab8]
0066BC838  bl       #0x382bd14 ; 
0066BC83C  adrp     x0, #0x8f11000
0066BC840  ldr      x0, [x0, #0xac8]
0066BC844  bl       #0x382bd14 ; 
0066BC848  mov      w8, #1
0066BC84C  strb     w8, [x24, #0x224]
0066BC850  ldr      x5, [x25]
0066BC854  ldrb     w8, [x5, #0x53]
0066BC858  tbnz     w8, #5, #0x66bc8d8
0066BC85C  adrp     x8, #0x8f11000
0066BC860  ldr      x8, [x8, #0xac8]
0066BC864  cmp      w23, #1
0066BC868  mov      w9, #0x50
0066BC86C  mov      w10, #0x58
0066BC870  stp      xzr, xzr, [sp, #0x10]
0066BC874  csel     x9, x10, x9, eq
0066BC878  ldr      x3, [x8]
0066BC87C  ldr      x22, [x22, x9]
0066BC880  add      x0, sp, #8
0066BC884  mov      x1, x21
0066BC888  mov      x2, x20
0066BC88C  str      xzr, [sp, #8]
0066BC890  bl       #0x57d5d1c ; System.ValueTuple<EntityRef, EntityCharacterTypeKey>$$.ctor
0066BC894  cbz      x22, #0x66bc924
0066BC898  adrp     x8, #0x8f11000
0066BC89C  ldp      x1, x2, [sp, #8]
0066BC8A0  ldr      x8, [x8, #0xab8]
0066BC8A4  add      x3, sp, #0x18
0066BC8A8  mov      x0, x22
0066BC8AC  ldr      x4, [x8]
0066BC8B0  bl       #0x5d68d54 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$TryGetValue
0066BC8B4  tbz      w0, #0, #0x66bc908
0066BC8B8  ldr      x8, [sp, #0x18]
0066BC8BC  cbz      x8, #0x66bc924
0066BC8C0  ldr      w9, [x8, #0x20]
0066BC8C4  cmp      w9, w19
0066BC8C8  b.ge     #0x66bc908
0066BC8CC  mov      w0, #1
0066BC8D0  str      w19, [x8, #0x20]
0066BC8D4  b        #0x66bc90c ; 
0066BC8D8  ldr      x6, [x5, #0x60]
0066BC8DC  mov      x0, x22
0066BC8E0  mov      x1, x21
0066BC8E4  mov      x2, x20
0066BC8E8  mov      w3, w23
0066BC8EC  mov      w4, w19
0066BC8F0  ldp      x20, x19, [sp, #0x50]
0066BC8F4  ldp      x22, x21, [sp, #0x40]
0066BC8F8  ldp      x24, x23, [sp, #0x30]
0066BC8FC  ldp      x30, x25, [sp, #0x20]
0066BC900  add      sp, sp, #0x60
0066BC904  br       x6
0066BC908  mov      w0, wzr
0066BC90C  ldp      x20, x19, [sp, #0x50]
0066BC910  ldp      x22, x21, [sp, #0x40]
0066BC914  ldp      x24, x23, [sp, #0x30]
0066BC918  ldp      x30, x25, [sp, #0x20]
0066BC91C  add      sp, sp, #0x60
0066BC920  ret      
0066BC924  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCountKey
; RVA 0x66BB9DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BB9DC  sub      sp, sp, #0x30
0066BB9E0  stp      x30, x21, [sp, #0x10]
0066BB9E4  stp      x20, x19, [sp, #0x20]
0066BB9E8  adrp     x20, #0x959a000
0066BB9EC  adrp     x21, #0x8f11000
0066BB9F0  ldrb     w8, [x20, #0x225]
0066BB9F4  ldr      x21, [x21, #0xaa0]
0066BB9F8  mov      x19, x0
0066BB9FC  tbnz     w8, #0, #0x66bba20
0066BBA00  adrp     x0, #0x8f11000
0066BBA04  ldr      x0, [x0, #0xaa0]
0066BBA08  bl       #0x382bd14 ; 
0066BBA0C  adrp     x0, #0x8ee6000
0066BBA10  ldr      x0, [x0, #0xd8]
0066BBA14  bl       #0x382bd14 ; 
0066BBA18  mov      w8, #1
0066BBA1C  strb     w8, [x20, #0x225]
0066BBA20  ldr      x1, [x21]
0066BBA24  ldrb     w8, [x1, #0x53]
0066BBA28  tbnz     w8, #5, #0x66bba60
0066BBA2C  cbz      x19, #0x66bba80
0066BBA30  adrp     x20, #0x8ee6000
0066BBA34  ldr      x20, [x20, #0xd8]
0066BBA38  ldr      x1, [x20]
0066BBA3C  ldrb     w8, [x1, #0x53]
0066BBA40  tbnz     w8, #5, #0x66bba70
0066BBA44  ldr      x0, [x19, #0x38]
0066BBA48  cbz      x0, #0x66bba80
0066BBA4C  ldr      x1, [x20]
0066BBA50  ldrb     w8, [x1, #0x53]
0066BBA54  tbnz     w8, #5, #0x66bbaa0
0066BBA58  ldr      x0, [x19, #0x38]
0066BBA5C  b        #0x66bbaac ; 
0066BBA60  ldr      x8, [x1, #0x60]
0066BBA64  mov      x0, x19
0066BBA68  blr      x8
0066BBA6C  b        #0x66bbab8 ; 
0066BBA70  ldr      x8, [x1, #0x60]
0066BBA74  mov      x0, x19
0066BBA78  blr      x8
0066BBA7C  cbnz     x0, #0x66bba4c
0066BBA80  add      x0, sp, #8
0066BBA84  mov      w2, #-0xffffffff80000000
0066BBA88  mov      w1, wzr
0066BBA8C  mov      x3, xzr
0066BBA90  str      xzr, [sp, #8]
0066BBA94  bl       #0x6a4c708 ; HotFix.BattleLogic.EntityCharacterTypeKey$$.ctor
0066BBA98  ldr      x0, [sp, #8]
0066BBA9C  b        #0x66bbabc ; 
0066BBAA0  ldr      x8, [x1, #0x60]
0066BBAA4  mov      x0, x19
0066BBAA8  blr      x8
0066BBAAC  cbz      x0, #0x66bbacc
0066BBAB0  mov      x1, xzr
0066BBAB4  bl       #0x66c621c ; 
0066BBAB8  str      x0, [sp, #8]
0066BBABC  ldp      x20, x19, [sp, #0x20]
0066BBAC0  ldp      x30, x21, [sp, #0x10]
0066BBAC4  add      sp, sp, #0x30
0066BBAC8  ret      
0066BBACC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetWeaponHittedCountKey
; RVA 0x66BFDEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BFDEC  str      x30, [sp, #-0x30]!
0066BFDF0  stp      x22, x21, [sp, #0x10]
0066BFDF4  stp      x20, x19, [sp, #0x20]
0066BFDF8  adrp     x21, #0x959a000
0066BFDFC  adrp     x22, #0x8f11000
0066BFE00  ldrb     w8, [x21, #0x226]
0066BFE04  ldr      x22, [x22, #0xc50]
0066BFE08  mov      w19, w1
0066BFE0C  mov      w20, w0
0066BFE10  tbnz     w8, #0, #0x66bfe28
0066BFE14  adrp     x0, #0x8f11000
0066BFE18  ldr      x0, [x0, #0xc50]
0066BFE1C  bl       #0x382bd14 ; 
0066BFE20  mov      w8, #1
0066BFE24  strb     w8, [x21, #0x226]
0066BFE28  ldr      x2, [x22]
0066BFE2C  ldrb     w8, [x2, #0x53]
0066BFE30  tbnz     w8, #5, #0x66bfe50
0066BFE34  mov      w0, w20
0066BFE38  mov      w1, w19
0066BFE3C  ldp      x20, x19, [sp, #0x20]
0066BFE40  ldp      x22, x21, [sp, #0x10]
0066BFE44  mov      x2, xzr
0066BFE48  ldr      x30, [sp], #0x30
0066BFE4C  b        #0x6a4d294 ; HotFix.BattleLogic.EntityCharacterTypeUtils$$GetCharacterTypeKey
0066BFE50  ldr      x3, [x2, #0x60]
0066BFE54  mov      w0, w20
0066BFE58  mov      w1, w19
0066BFE5C  ldp      x20, x19, [sp, #0x20]
0066BFE60  ldp      x22, x21, [sp, #0x10]
0066BFE64  ldr      x30, [sp], #0x30
0066BFE68  br       x3

; HotFix.BattleLogic.CharacterComponentOnHit$$Init
; RVA 0x66BFE6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BFE6C  stp      x30, x21, [sp, #-0x20]!
0066BFE70  stp      x20, x19, [sp, #0x10]
0066BFE74  adrp     x20, #0x959a000
0066BFE78  adrp     x21, #0x8f11000
0066BFE7C  ldrb     w8, [x20, #0x227]
0066BFE80  ldr      x21, [x21, #0xc58]
0066BFE84  mov      x19, x0
0066BFE88  tbnz     w8, #0, #0x66bfeac
0066BFE8C  adrp     x0, #0x8f11000
0066BFE90  ldr      x0, [x0, #0xc58]
0066BFE94  bl       #0x382bd14 ; 
0066BFE98  adrp     x0, #0x8ee6000
0066BFE9C  ldr      x0, [x0, #0x600]
0066BFEA0  bl       #0x382bd14 ; 
0066BFEA4  mov      w8, #1
0066BFEA8  strb     w8, [x20, #0x227]
0066BFEAC  ldr      x1, [x21]
0066BFEB0  ldrb     w8, [x1, #0x53]
0066BFEB4  tbnz     w8, #5, #0x66bfedc
0066BFEB8  mov      w8, #1
0066BFEBC  str      w8, [x19, #0xa0]
0066BFEC0  adrp     x8, #0x8ee6000
0066BFEC4  ldr      x8, [x8, #0x600]
0066BFEC8  ldr      x1, [x8]
0066BFECC  ldrb     w8, [x1, #0x53]
0066BFED0  tbnz     w8, #5, #0x66bfef0
0066BFED4  ldr      x0, [x19, #0x38]
0066BFED8  b        #0x66bfefc ; 
0066BFEDC  ldr      x2, [x1, #0x60]
0066BFEE0  mov      x0, x19
0066BFEE4  ldp      x20, x19, [sp, #0x10]
0066BFEE8  ldp      x30, x21, [sp], #0x20
0066BFEEC  br       x2
0066BFEF0  ldr      x8, [x1, #0x60]
0066BFEF4  mov      x0, x19
0066BFEF8  blr      x8
0066BFEFC  cbz      x0, #0x66bff10
0066BFF00  ldp      x20, x19, [sp, #0x10]
0066BFF04  mov      x1, xzr
0066BFF08  ldp      x30, x21, [sp], #0x20
0066BFF0C  b        #0x6826c24 ; HotFix.BattleLogic.EntityCharacterData$$ResetLaserStack
0066BFF10  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$DeInit
; RVA 0x66BFF14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BFF14  stp      x30, x21, [sp, #-0x20]!
0066BFF18  stp      x20, x19, [sp, #0x10]
0066BFF1C  adrp     x20, #0x959a000
0066BFF20  adrp     x21, #0x8f11000
0066BFF24  ldrb     w8, [x20, #0x228]
0066BFF28  ldr      x21, [x21, #0xc60]
0066BFF2C  mov      x19, x0
0066BFF30  tbnz     w8, #0, #0x66bff78
0066BFF34  adrp     x0, #0x8f11000
0066BFF38  ldr      x0, [x0, #0xc60]
0066BFF3C  bl       #0x382bd14 ; 
0066BFF40  adrp     x0, #0x8f11000
0066BFF44  ldr      x0, [x0, #0xc68]
0066BFF48  bl       #0x382bd14 ; 
0066BFF4C  adrp     x0, #0x8f11000
0066BFF50  ldr      x0, [x0, #0xc70]
0066BFF54  bl       #0x382bd14 ; 
0066BFF58  adrp     x0, #0x8ee6000
0066BFF5C  ldr      x0, [x0, #0x600]
0066BFF60  bl       #0x382bd14 ; 
0066BFF64  adrp     x0, #0x8f11000
0066BFF68  ldr      x0, [x0, #0xc78]
0066BFF6C  bl       #0x382bd14 ; 
0066BFF70  mov      w8, #1
0066BFF74  strb     w8, [x20, #0x228]
0066BFF78  ldr      x1, [x21]
0066BFF7C  ldrb     w8, [x1, #0x53]
0066BFF80  tbnz     w8, #5, #0x66bffa8
0066BFF84  adrp     x8, #0x8ee6000
0066BFF88  ldr      x8, [x8, #0x600]
0066BFF8C  mov      w9, #1
0066BFF90  str      w9, [x19, #0xa0]
0066BFF94  ldr      x1, [x8]
0066BFF98  ldrb     w8, [x1, #0x53]
0066BFF9C  tbnz     w8, #5, #0x66bffbc
0066BFFA0  ldr      x0, [x19, #0x38]
0066BFFA4  b        #0x66bffc8 ; 
0066BFFA8  ldr      x2, [x1, #0x60]
0066BFFAC  mov      x0, x19
0066BFFB0  ldp      x20, x19, [sp, #0x10]
0066BFFB4  ldp      x30, x21, [sp], #0x20
0066BFFB8  br       x2
0066BFFBC  ldr      x8, [x1, #0x60]
0066BFFC0  mov      x0, x19
0066BFFC4  blr      x8
0066BFFC8  cbz      x0, #0x66c0054
0066BFFCC  mov      x1, xzr
0066BFFD0  bl       #0x6826c24 ; HotFix.BattleLogic.EntityCharacterData$$ResetLaserStack
0066BFFD4  ldr      x0, [x19, #0x50]
0066BFFD8  cbz      x0, #0x66c0054
0066BFFDC  adrp     x20, #0x8f11000
0066BFFE0  ldr      x20, [x20, #0xc68]
0066BFFE4  ldr      x1, [x20]
0066BFFE8  bl       #0x5d67468 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$Clear
0066BFFEC  ldr      x0, [x19, #0x58]
0066BFFF0  cbz      x0, #0x66c0054
0066BFFF4  ldr      x1, [x20]
0066BFFF8  bl       #0x5d67468 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$Clear
0066BFFFC  ldr      x0, [x19, #0x60]
0066C0000  cbz      x0, #0x66c0054
0066C0004  adrp     x20, #0x8f11000
0066C0008  ldr      x20, [x20, #0xc70]
0066C000C  ldr      x1, [x20]
0066C0010  bl       #0x5d6ae20 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$Clear
0066C0014  ldr      x0, [x19, #0x68]
0066C0018  cbz      x0, #0x66c0054
0066C001C  ldr      x1, [x20]
0066C0020  bl       #0x5d6ae20 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$Clear
0066C0024  ldr      x0, [x19, #0x70]
0066C0028  cbz      x0, #0x66c0054
0066C002C  adrp     x20, #0x8f11000
0066C0030  ldr      x20, [x20, #0xc78]
0066C0034  ldr      x1, [x20]
0066C0038  bl       #0x49156a0 ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$Clear
0066C003C  ldr      x0, [x19, #0x78]
0066C0040  cbz      x0, #0x66c0054
0066C0044  ldr      x1, [x20]
0066C0048  ldp      x20, x19, [sp, #0x10]
0066C004C  ldp      x30, x21, [sp], #0x20
0066C0050  b        #0x49156a0 ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$Clear
0066C0054  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$IsLaserBullet
; RVA 0x66B9734; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B9734  str      x30, [sp, #-0x30]!
0066B9738  stp      x22, x21, [sp, #0x10]
0066B973C  stp      x20, x19, [sp, #0x20]
0066B9740  adrp     x21, #0x959a000
0066B9744  adrp     x22, #0x8f11000
0066B9748  ldrb     w8, [x21, #0x229]
0066B974C  ldr      x22, [x22, #0xa30]
0066B9750  mov      w19, w1
0066B9754  mov      x20, x0
0066B9758  tbnz     w8, #0, #0x66b9770
0066B975C  adrp     x0, #0x8f11000
0066B9760  ldr      x0, [x0, #0xa30]
0066B9764  bl       #0x382bd14 ; 
0066B9768  mov      w8, #1
0066B976C  strb     w8, [x21, #0x229]
0066B9770  ldr      x2, [x22]
0066B9774  ldrb     w8, [x2, #0x53]
0066B9778  tbnz     w8, #5, #0x66b9798
0066B977C  and      w8, w19, #0xfffffffb
0066B9780  ldp      x20, x19, [sp, #0x20]
0066B9784  ldp      x22, x21, [sp, #0x10]
0066B9788  cmp      w8, #2
0066B978C  cset     w0, eq
0066B9790  ldr      x30, [sp], #0x30
0066B9794  ret      
0066B9798  ldr      x3, [x2, #0x60]
0066B979C  mov      x0, x20
0066B97A0  mov      w1, w19
0066B97A4  ldp      x20, x19, [sp, #0x20]
0066B97A8  ldp      x22, x21, [sp, #0x10]
0066B97AC  ldr      x30, [sp], #0x30
0066B97B0  br       x3

; HotFix.BattleLogic.CharacterComponentOnHit$$CheckLaserStackCooldown
; RVA 0x66C0058; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0058  str      x30, [sp, #-0x40]!
0066C005C  stp      x24, x23, [sp, #0x10]
0066C0060  stp      x22, x21, [sp, #0x20]
0066C0064  stp      x20, x19, [sp, #0x30]
0066C0068  adrp     x20, #0x959a000
0066C006C  adrp     x21, #0x8f11000
0066C0070  ldrb     w8, [x20, #0x22a]
0066C0074  ldr      x21, [x21, #0xc80]
0066C0078  mov      x19, x0
0066C007C  tbnz     w8, #0, #0x66c00a0
0066C0080  adrp     x0, #0x8f11000
0066C0084  ldr      x0, [x0, #0xc80]
0066C0088  bl       #0x382bd14 ; 
0066C008C  adrp     x0, #0x8ee6000
0066C0090  ldr      x0, [x0, #0x600]
0066C0094  bl       #0x382bd14 ; 
0066C0098  mov      w8, #1
0066C009C  strb     w8, [x20, #0x22a]
0066C00A0  ldr      x1, [x21]
0066C00A4  ldrb     w8, [x1, #0x53]
0066C00A8  tbnz     w8, #5, #0x66c00c8
0066C00AC  adrp     x21, #0x8ee6000
0066C00B0  ldr      x21, [x21, #0x600]
0066C00B4  ldr      x1, [x21]
0066C00B8  ldrb     w8, [x1, #0x53]
0066C00BC  tbnz     w8, #5, #0x66c00e4
0066C00C0  ldr      x20, [x19, #0x38]
0066C00C4  b        #0x66c00f4 ; 
0066C00C8  ldr      x2, [x1, #0x60]
0066C00CC  mov      x0, x19
0066C00D0  ldp      x20, x19, [sp, #0x30]
0066C00D4  ldp      x22, x21, [sp, #0x20]
0066C00D8  ldp      x24, x23, [sp, #0x10]
0066C00DC  ldr      x30, [sp], #0x40
0066C00E0  br       x2
0066C00E4  ldr      x8, [x1, #0x60]
0066C00E8  mov      x0, x19
0066C00EC  blr      x8
0066C00F0  mov      x20, x0
0066C00F4  cbz      x20, #0x66c0294
0066C00F8  adrp     x22, #0x959a000
0066C00FC  ldrb     w8, [x22, #0x272]
0066C0100  cbnz     w8, #0x66c0118
0066C0104  adrp     x0, #0x8f11000
0066C0108  ldr      x0, [x0, #0x9a0]
0066C010C  bl       #0x382bd14 ; 
0066C0110  mov      w8, #1
0066C0114  strb     w8, [x22, #0x272]
0066C0118  adrp     x8, #0x8f11000
0066C011C  ldr      x8, [x8, #0x9a0]
0066C0120  ldr      x1, [x8]
0066C0124  ldrb     w8, [x1, #0x53]
0066C0128  tbnz     w8, #5, #0x66c0134
0066C012C  ldr      w0, [x20, #0x288]
0066C0130  b        #0x66c0140 ; 
0066C0134  ldr      x8, [x1, #0x60]
0066C0138  mov      x0, x20
0066C013C  blr      x8
0066C0140  cmp      w0, #1
0066C0144  b.lt     #0x66c0258
0066C0148  adrp     x20, #0x9591000
0066C014C  ldrb     w8, [x20, #0xa4b]
0066C0150  cbnz     w8, #0x66c0168
0066C0154  adrp     x0, #0x8ee5000
0066C0158  ldr      x0, [x0, #0xb28]
0066C015C  bl       #0x382bd14 ; 
0066C0160  mov      w8, #1
0066C0164  strb     w8, [x20, #0xa4b]
0066C0168  adrp     x8, #0x8ee5000
0066C016C  ldr      x8, [x8, #0xb28]
0066C0170  ldr      x1, [x8]
0066C0174  ldrb     w8, [x1, #0x53]
0066C0178  tbnz     w8, #5, #0x66c0184
0066C017C  ldr      x0, [x19, #0x20]
0066C0180  b        #0x66c0190 ; 
0066C0184  ldr      x8, [x1, #0x60]
0066C0188  mov      x0, x19
0066C018C  blr      x8
0066C0190  cbz      x0, #0x66c0294
0066C0194  ldr      x1, [x21]
0066C0198  ldr      x22, [x0, #0x128]
0066C019C  ldr      x23, [x19, #0x48]
0066C01A0  ldrb     w8, [x1, #0x53]
0066C01A4  tbnz     w8, #5, #0x66c01b0
0066C01A8  ldr      x20, [x19, #0x38]
0066C01AC  b        #0x66c01c0 ; 
0066C01B0  ldr      x8, [x1, #0x60]
0066C01B4  mov      x0, x19
0066C01B8  blr      x8
0066C01BC  mov      x20, x0
0066C01C0  cbz      x20, #0x66c0294
0066C01C4  adrp     x24, #0x959a000
0066C01C8  ldrb     w8, [x24, #0x278]
0066C01CC  cbnz     w8, #0x66c01f0
0066C01D0  adrp     x0, #0x8f11000
0066C01D4  ldr      x0, [x0, #0xc88]
0066C01D8  bl       #0x382bd14 ; 
0066C01DC  adrp     x0, #0x8f11000
0066C01E0  ldr      x0, [x0, #0xc90]
0066C01E4  bl       #0x382bd14 ; 
0066C01E8  mov      w8, #1
0066C01EC  strb     w8, [x24, #0x278]
0066C01F0  adrp     x8, #0x8f11000
0066C01F4  ldr      x8, [x8, #0xc88]
0066C01F8  sub      x22, x22, x23
0066C01FC  ldr      x1, [x8]
0066C0200  ldrb     w8, [x1, #0x53]
0066C0204  tbnz     w8, #5, #0x66c0230
0066C0208  adrp     x20, #0x8f11000
0066C020C  ldr      x20, [x20, #0xc90]
0066C0210  ldr      x0, [x20]
0066C0214  ldr      w8, [x0, #0xe0]
0066C0218  cbnz     w8, #0x66c0224
0066C021C  bl       #0x382be8c ; 
0066C0220  ldr      x0, [x20]
0066C0224  ldr      x8, [x0, #0xb8]
0066C0228  ldr      x0, [x8, #0x10]
0066C022C  b        #0x66c023c ; 
0066C0230  ldr      x8, [x1, #0x60]
0066C0234  mov      x0, x20
0066C0238  blr      x8
0066C023C  cmp      x22, x0
0066C0240  b.le     #0x66c0258
0066C0244  ldr      x1, [x21]
0066C0248  ldrb     w8, [x1, #0x53]
0066C024C  tbnz     w8, #5, #0x66c026c
0066C0250  ldr      x0, [x19, #0x38]
0066C0254  b        #0x66c0278 ; 
0066C0258  ldp      x20, x19, [sp, #0x30]
0066C025C  ldp      x22, x21, [sp, #0x20]
0066C0260  ldp      x24, x23, [sp, #0x10]
0066C0264  ldr      x30, [sp], #0x40
0066C0268  ret      
0066C026C  ldr      x8, [x1, #0x60]
0066C0270  mov      x0, x19
0066C0274  blr      x8
0066C0278  cbz      x0, #0x66c0294
0066C027C  ldp      x20, x19, [sp, #0x30]
0066C0280  ldp      x22, x21, [sp, #0x20]
0066C0284  ldp      x24, x23, [sp, #0x10]
0066C0288  mov      x1, xzr
0066C028C  ldr      x30, [sp], #0x40
0066C0290  b        #0x6826c24 ; HotFix.BattleLogic.EntityCharacterData$$ResetLaserStack
0066C0294  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$SetLaserStackCooldown
; RVA 0x66C0298; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0298  str      x30, [sp, #-0x30]!
0066C029C  stp      x22, x21, [sp, #0x10]
0066C02A0  stp      x20, x19, [sp, #0x20]
0066C02A4  adrp     x21, #0x959a000
0066C02A8  adrp     x22, #0x8f11000
0066C02AC  ldrb     w8, [x21, #0x22b]
0066C02B0  ldr      x22, [x22, #0xc98]
0066C02B4  mov      x19, x1
0066C02B8  mov      x20, x0
0066C02BC  tbnz     w8, #0, #0x66c02e0
0066C02C0  adrp     x0, #0x8f11000
0066C02C4  ldr      x0, [x0, #0xc98]
0066C02C8  bl       #0x382bd14 ; 
0066C02CC  adrp     x0, #0x8ee6000
0066C02D0  ldr      x0, [x0, #0x600]
0066C02D4  bl       #0x382bd14 ; 
0066C02D8  mov      w8, #1
0066C02DC  strb     w8, [x21, #0x22b]
0066C02E0  ldr      x2, [x22]
0066C02E4  ldrb     w8, [x2, #0x53]
0066C02E8  tbnz     w8, #5, #0x66c0308
0066C02EC  adrp     x8, #0x8ee6000
0066C02F0  ldr      x8, [x8, #0x600]
0066C02F4  ldr      x1, [x8]
0066C02F8  ldrb     w8, [x1, #0x53]
0066C02FC  tbnz     w8, #5, #0x66c0324
0066C0300  ldr      x0, [x20, #0x38]
0066C0304  b        #0x66c0330 ; 
0066C0308  ldr      x3, [x2, #0x60]
0066C030C  mov      x0, x20
0066C0310  mov      x1, x19
0066C0314  ldp      x20, x19, [sp, #0x20]
0066C0318  ldp      x22, x21, [sp, #0x10]
0066C031C  ldr      x30, [sp], #0x30
0066C0320  br       x3
0066C0324  ldr      x8, [x1, #0x60]
0066C0328  mov      x0, x20
0066C032C  blr      x8
0066C0330  cbz      x0, #0x66c034c
0066C0334  mov      x1, x19
0066C0338  ldp      x20, x19, [sp, #0x20]
0066C033C  ldp      x22, x21, [sp, #0x10]
0066C0340  mov      x2, xzr
0066C0344  ldr      x30, [sp], #0x30
0066C0348  b        #0x6826fc8 ; HotFix.BattleLogic.EntityCharacterData$$SetLaserStackCooldown
0066C034C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$GetLaserStackCooldown
; RVA 0x66C0350; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0350  stp      x30, x21, [sp, #-0x20]!
0066C0354  stp      x20, x19, [sp, #0x10]
0066C0358  adrp     x20, #0x959a000
0066C035C  adrp     x21, #0x8f11000
0066C0360  ldrb     w8, [x20, #0x22c]
0066C0364  ldr      x21, [x21, #0xca0]
0066C0368  mov      x19, x0
0066C036C  tbnz     w8, #0, #0x66c0390
0066C0370  adrp     x0, #0x8f11000
0066C0374  ldr      x0, [x0, #0xca0]
0066C0378  bl       #0x382bd14 ; 
0066C037C  adrp     x0, #0x8ee6000
0066C0380  ldr      x0, [x0, #0x600]
0066C0384  bl       #0x382bd14 ; 
0066C0388  mov      w8, #1
0066C038C  strb     w8, [x20, #0x22c]
0066C0390  ldr      x1, [x21]
0066C0394  ldrb     w8, [x1, #0x53]
0066C0398  tbnz     w8, #5, #0x66c043c
0066C039C  adrp     x8, #0x8ee6000
0066C03A0  ldr      x8, [x8, #0x600]
0066C03A4  ldr      x1, [x8]
0066C03A8  ldrb     w8, [x1, #0x53]
0066C03AC  tbnz     w8, #5, #0x66c03b8
0066C03B0  ldr      x19, [x19, #0x38]
0066C03B4  b        #0x66c03c8 ; 
0066C03B8  ldr      x8, [x1, #0x60]
0066C03BC  mov      x0, x19
0066C03C0  blr      x8
0066C03C4  mov      x19, x0
0066C03C8  cbz      x19, #0x66c0450
0066C03CC  adrp     x20, #0x959a000
0066C03D0  ldrb     w8, [x20, #0x278]
0066C03D4  cbnz     w8, #0x66c03f8
0066C03D8  adrp     x0, #0x8f11000
0066C03DC  ldr      x0, [x0, #0xc88]
0066C03E0  bl       #0x382bd14 ; 
0066C03E4  adrp     x0, #0x8f11000
0066C03E8  ldr      x0, [x0, #0xc90]
0066C03EC  bl       #0x382bd14 ; 
0066C03F0  mov      w8, #1
0066C03F4  strb     w8, [x20, #0x278]
0066C03F8  adrp     x8, #0x8f11000
0066C03FC  ldr      x8, [x8, #0xc88]
0066C0400  ldr      x1, [x8]
0066C0404  ldrb     w8, [x1, #0x53]
0066C0408  tbnz     w8, #5, #0x66c043c
0066C040C  adrp     x19, #0x8f11000
0066C0410  ldr      x19, [x19, #0xc90]
0066C0414  ldr      x0, [x19]
0066C0418  ldr      w8, [x0, #0xe0]
0066C041C  cbnz     w8, #0x66c0428
0066C0420  bl       #0x382be8c ; 
0066C0424  ldr      x0, [x19]
0066C0428  ldr      x8, [x0, #0xb8]
0066C042C  ldp      x20, x19, [sp, #0x10]
0066C0430  ldr      x0, [x8, #0x10]
0066C0434  ldp      x30, x21, [sp], #0x20
0066C0438  ret      
0066C043C  ldr      x2, [x1, #0x60]
0066C0440  mov      x0, x19
0066C0444  ldp      x20, x19, [sp, #0x10]
0066C0448  ldp      x30, x21, [sp], #0x20
0066C044C  br       x2
0066C0450  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$add_OnHurtElapsedTimeChanged
; RVA 0x66C0454; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0454  str      x30, [sp, #-0x40]!
0066C0458  stp      x24, x23, [sp, #0x10]
0066C045C  stp      x22, x21, [sp, #0x20]
0066C0460  stp      x20, x19, [sp, #0x30]
0066C0464  adrp     x21, #0x959a000
0066C0468  adrp     x22, #0x8f11000
0066C046C  ldrb     w8, [x21, #0x22d]
0066C0470  ldr      x22, [x22, #0xca8]
0066C0474  mov      x19, x1
0066C0478  mov      x20, x0
0066C047C  tbnz     w8, #0, #0x66c04a0
0066C0480  adrp     x0, #0x8f05000
0066C0484  ldr      x0, [x0, #0x8c8]
0066C0488  bl       #0x382bd14 ; 
0066C048C  adrp     x0, #0x8f11000
0066C0490  ldr      x0, [x0, #0xca8]
0066C0494  bl       #0x382bd14 ; 
0066C0498  mov      w8, #1
0066C049C  strb     w8, [x21, #0x22d]
0066C04A0  ldr      x2, [x22]
0066C04A4  ldrb     w8, [x2, #0x53]
0066C04A8  tbnz     w8, #5, #0x66c0518
0066C04AC  adrp     x24, #0x8f05000
0066C04B0  ldr      x21, [x20, #0x98]!
0066C04B4  ldr      x24, [x24, #0x8c8]
0066C04B8  mov      x0, x21
0066C04BC  mov      x1, x19
0066C04C0  mov      x2, xzr
0066C04C4  bl       #0x7c275cc ; System.Delegate$$Combine
0066C04C8  cbz      x0, #0x66c04e8
0066C04CC  ldr      x23, [x24]
0066C04D0  mov      x22, x0
0066C04D4  mov      x1, x23
0066C04D8  bl       #0x382be90 ; 
0066C04DC  mov      x1, x0
0066C04E0  cbnz     x0, #0x66c04ec
0066C04E4  b        #0x66c0538 ; 
0066C04E8  mov      x1, xzr
0066C04EC  mov      x0, x20
0066C04F0  mov      x2, x21
0066C04F4  bl       #0x3ad5fac ; 
0066C04F8  cmp      x21, x0
0066C04FC  mov      x21, x0
0066C0500  b.ne     #0x66c04b8
0066C0504  ldp      x20, x19, [sp, #0x30]
0066C0508  ldp      x22, x21, [sp, #0x20]
0066C050C  ldp      x24, x23, [sp, #0x10]
0066C0510  ldr      x30, [sp], #0x40
0066C0514  ret      
0066C0518  ldr      x3, [x2, #0x60]
0066C051C  mov      x0, x20
0066C0520  mov      x1, x19
0066C0524  ldp      x20, x19, [sp, #0x30]
0066C0528  ldp      x22, x21, [sp, #0x20]
0066C052C  ldp      x24, x23, [sp, #0x10]
0066C0530  ldr      x30, [sp], #0x40
0066C0534  br       x3
0066C0538  mov      x0, x22
0066C053C  mov      x1, x23
0066C0540  bl       #0x382c354 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$remove_OnHurtElapsedTimeChanged
; RVA 0x66C0544; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0544  str      x30, [sp, #-0x40]!
0066C0548  stp      x24, x23, [sp, #0x10]
0066C054C  stp      x22, x21, [sp, #0x20]
0066C0550  stp      x20, x19, [sp, #0x30]
0066C0554  adrp     x21, #0x959a000
0066C0558  adrp     x22, #0x8f11000
0066C055C  ldrb     w8, [x21, #0x22e]
0066C0560  ldr      x22, [x22, #0xcb0]
0066C0564  mov      x19, x1
0066C0568  mov      x20, x0
0066C056C  tbnz     w8, #0, #0x66c0590
0066C0570  adrp     x0, #0x8f05000
0066C0574  ldr      x0, [x0, #0x8c8]
0066C0578  bl       #0x382bd14 ; 
0066C057C  adrp     x0, #0x8f11000
0066C0580  ldr      x0, [x0, #0xcb0]
0066C0584  bl       #0x382bd14 ; 
0066C0588  mov      w8, #1
0066C058C  strb     w8, [x21, #0x22e]
0066C0590  ldr      x2, [x22]
0066C0594  ldrb     w8, [x2, #0x53]
0066C0598  tbnz     w8, #5, #0x66c0608
0066C059C  adrp     x24, #0x8f05000
0066C05A0  ldr      x21, [x20, #0x98]!
0066C05A4  ldr      x24, [x24, #0x8c8]
0066C05A8  mov      x0, x21
0066C05AC  mov      x1, x19
0066C05B0  mov      x2, xzr
0066C05B4  bl       #0x7c277d4 ; System.Delegate$$Remove
0066C05B8  cbz      x0, #0x66c05d8
0066C05BC  ldr      x23, [x24]
0066C05C0  mov      x22, x0
0066C05C4  mov      x1, x23
0066C05C8  bl       #0x382be90 ; 
0066C05CC  mov      x1, x0
0066C05D0  cbnz     x0, #0x66c05dc
0066C05D4  b        #0x66c0628 ; 
0066C05D8  mov      x1, xzr
0066C05DC  mov      x0, x20
0066C05E0  mov      x2, x21
0066C05E4  bl       #0x3ad5fac ; 
0066C05E8  cmp      x21, x0
0066C05EC  mov      x21, x0
0066C05F0  b.ne     #0x66c05a8
0066C05F4  ldp      x20, x19, [sp, #0x30]
0066C05F8  ldp      x22, x21, [sp, #0x20]
0066C05FC  ldp      x24, x23, [sp, #0x10]
0066C0600  ldr      x30, [sp], #0x40
0066C0604  ret      
0066C0608  ldr      x3, [x2, #0x60]
0066C060C  mov      x0, x20
0066C0610  mov      x1, x19
0066C0614  ldp      x20, x19, [sp, #0x30]
0066C0618  ldp      x22, x21, [sp, #0x20]
0066C061C  ldp      x24, x23, [sp, #0x10]
0066C0620  ldr      x30, [sp], #0x40
0066C0624  br       x3
0066C0628  mov      x0, x22
0066C062C  mov      x1, x23
0066C0630  bl       #0x382c354 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$get_LastHurtTimestamp
; RVA 0x66C0634; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0634  stp      x30, x21, [sp, #-0x20]!
0066C0638  stp      x20, x19, [sp, #0x10]
0066C063C  adrp     x20, #0x959a000
0066C0640  adrp     x21, #0x8f11000
0066C0644  ldrb     w8, [x20, #0x22f]
0066C0648  ldr      x21, [x21, #0xcb8]
0066C064C  mov      x19, x0
0066C0650  tbnz     w8, #0, #0x66c0668
0066C0654  adrp     x0, #0x8f11000
0066C0658  ldr      x0, [x0, #0xcb8]
0066C065C  bl       #0x382bd14 ; 
0066C0660  mov      w8, #1
0066C0664  strb     w8, [x20, #0x22f]
0066C0668  ldr      x1, [x21]
0066C066C  ldrb     w8, [x1, #0x53]
0066C0670  tbnz     w8, #5, #0x66c0684
0066C0674  ldr      x0, [x19, #0x80]
0066C0678  ldp      x20, x19, [sp, #0x10]
0066C067C  ldp      x30, x21, [sp], #0x20
0066C0680  ret      
0066C0684  ldr      x2, [x1, #0x60]
0066C0688  mov      x0, x19
0066C068C  ldp      x20, x19, [sp, #0x10]
0066C0690  ldp      x30, x21, [sp], #0x20
0066C0694  br       x2

; HotFix.BattleLogic.CharacterComponentOnHit$$get_ElapsedSinceLastHurt
; RVA 0x66C0698; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0698  stp      x30, x21, [sp, #-0x20]!
0066C069C  stp      x20, x19, [sp, #0x10]
0066C06A0  adrp     x20, #0x959a000
0066C06A4  adrp     x21, #0x8f11000
0066C06A8  ldrb     w8, [x20, #0x230]
0066C06AC  ldr      x21, [x21, #0xcc0]
0066C06B0  mov      x19, x0
0066C06B4  tbnz     w8, #0, #0x66c06cc
0066C06B8  adrp     x0, #0x8f11000
0066C06BC  ldr      x0, [x0, #0xcc0]
0066C06C0  bl       #0x382bd14 ; 
0066C06C4  mov      w8, #1
0066C06C8  strb     w8, [x20, #0x230]
0066C06CC  ldr      x1, [x21]
0066C06D0  ldrb     w8, [x1, #0x53]
0066C06D4  tbnz     w8, #5, #0x66c06e8
0066C06D8  ldr      x0, [x19, #0x88]
0066C06DC  ldp      x20, x19, [sp, #0x10]
0066C06E0  ldp      x30, x21, [sp], #0x20
0066C06E4  ret      
0066C06E8  ldr      x2, [x1, #0x60]
0066C06EC  mov      x0, x19
0066C06F0  ldp      x20, x19, [sp, #0x10]
0066C06F4  ldp      x30, x21, [sp], #0x20
0066C06F8  br       x2

; HotFix.BattleLogic.CharacterComponentOnHit$$OnUpdate
; RVA 0x66C06FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C06FC  str      x30, [sp, #-0x30]!
0066C0700  stp      x22, x21, [sp, #0x10]
0066C0704  stp      x20, x19, [sp, #0x20]
0066C0708  adrp     x21, #0x959a000
0066C070C  adrp     x22, #0x8f11000
0066C0710  ldrb     w8, [x21, #0x231]
0066C0714  ldr      x22, [x22, #0xcc8]
0066C0718  mov      x20, x1
0066C071C  mov      x19, x0
0066C0720  tbnz     w8, #0, #0x66c0738
0066C0724  adrp     x0, #0x8f11000
0066C0728  ldr      x0, [x0, #0xcc8]
0066C072C  bl       #0x382bd14 ; 
0066C0730  mov      w8, #1
0066C0734  strb     w8, [x21, #0x231]
0066C0738  ldr      x2, [x22]
0066C073C  ldrb     w8, [x2, #0x53]
0066C0740  tbnz     w8, #5, #0x66c0760
0066C0744  mov      x0, x19
0066C0748  bl       #0x66c0058 ; HotFix.BattleLogic.CharacterComponentOnHit$$CheckLaserStackCooldown
0066C074C  mov      x0, x19
0066C0750  ldp      x20, x19, [sp, #0x20]
0066C0754  ldp      x22, x21, [sp, #0x10]
0066C0758  ldr      x30, [sp], #0x30
0066C075C  b        #0x66c077c ; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateHurtElapsedTime
0066C0760  ldr      x3, [x2, #0x60]
0066C0764  mov      x0, x19
0066C0768  mov      x1, x20
0066C076C  ldp      x20, x19, [sp, #0x20]
0066C0770  ldp      x22, x21, [sp, #0x10]
0066C0774  ldr      x30, [sp], #0x30
0066C0778  br       x3

; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateHurtElapsedTime
; RVA 0x66C077C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C077C  stp      x30, x21, [sp, #-0x20]!
0066C0780  stp      x20, x19, [sp, #0x10]
0066C0784  adrp     x20, #0x959a000
0066C0788  adrp     x21, #0x8f11000
0066C078C  ldrb     w8, [x20, #0x232]
0066C0790  ldr      x21, [x21, #0xcd0]
0066C0794  mov      x19, x0
0066C0798  tbnz     w8, #0, #0x66c07b0
0066C079C  adrp     x0, #0x8f11000
0066C07A0  ldr      x0, [x0, #0xcd0]
0066C07A4  bl       #0x382bd14 ; 
0066C07A8  mov      w8, #1
0066C07AC  strb     w8, [x20, #0x232]
0066C07B0  ldr      x1, [x21]
0066C07B4  ldrb     w8, [x1, #0x53]
0066C07B8  tbnz     w8, #5, #0x66c07f8
0066C07BC  adrp     x20, #0x9591000
0066C07C0  ldrb     w8, [x20, #0xa4b]
0066C07C4  cbnz     w8, #0x66c07dc
0066C07C8  adrp     x0, #0x8ee5000
0066C07CC  ldr      x0, [x0, #0xb28]
0066C07D0  bl       #0x382bd14 ; 
0066C07D4  mov      w8, #1
0066C07D8  strb     w8, [x20, #0xa4b]
0066C07DC  adrp     x8, #0x8ee5000
0066C07E0  ldr      x8, [x8, #0xb28]
0066C07E4  ldr      x1, [x8]
0066C07E8  ldrb     w8, [x1, #0x53]
0066C07EC  tbnz     w8, #5, #0x66c080c
0066C07F0  ldr      x0, [x19, #0x20]
0066C07F4  b        #0x66c0818 ; 
0066C07F8  ldr      x2, [x1, #0x60]
0066C07FC  mov      x0, x19
0066C0800  ldp      x20, x19, [sp, #0x10]
0066C0804  ldp      x30, x21, [sp], #0x20
0066C0808  br       x2
0066C080C  ldr      x8, [x1, #0x60]
0066C0810  mov      x0, x19
0066C0814  blr      x8
0066C0818  cbz      x0, #0x66c0850
0066C081C  ldr      x8, [x0, #0x128]
0066C0820  ldp      x9, x10, [x19, #0x80]
0066C0824  sub      x1, x8, x9
0066C0828  cmp      x1, x10
0066C082C  b.ne     #0x66c083c
0066C0830  ldp      x20, x19, [sp, #0x10]
0066C0834  ldp      x30, x21, [sp], #0x20
0066C0838  ret      
0066C083C  str      x1, [x19, #0x88]
0066C0840  mov      x0, x19
0066C0844  ldp      x20, x19, [sp, #0x10]
0066C0848  ldp      x30, x21, [sp], #0x20
0066C084C  b        #0x66c0854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyHurtElapsedTimeChanged
0066C0850  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$ResetHurtTimestamp
; RVA 0x66C08F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C08F0  stp      x30, x21, [sp, #-0x20]!
0066C08F4  stp      x20, x19, [sp, #0x10]
0066C08F8  adrp     x20, #0x959a000
0066C08FC  adrp     x21, #0x8f11000
0066C0900  ldrb     w8, [x20, #0x233]
0066C0904  ldr      x21, [x21, #0xce0]
0066C0908  mov      x19, x0
0066C090C  tbnz     w8, #0, #0x66c0924
0066C0910  adrp     x0, #0x8f11000
0066C0914  ldr      x0, [x0, #0xce0]
0066C0918  bl       #0x382bd14 ; 
0066C091C  mov      w8, #1
0066C0920  strb     w8, [x20, #0x233]
0066C0924  ldr      x1, [x21]
0066C0928  ldrb     w8, [x1, #0x53]
0066C092C  tbnz     w8, #5, #0x66c096c
0066C0930  adrp     x20, #0x9591000
0066C0934  ldrb     w8, [x20, #0xa4b]
0066C0938  cbnz     w8, #0x66c0950
0066C093C  adrp     x0, #0x8ee5000
0066C0940  ldr      x0, [x0, #0xb28]
0066C0944  bl       #0x382bd14 ; 
0066C0948  mov      w8, #1
0066C094C  strb     w8, [x20, #0xa4b]
0066C0950  adrp     x8, #0x8ee5000
0066C0954  ldr      x8, [x8, #0xb28]
0066C0958  ldr      x1, [x8]
0066C095C  ldrb     w8, [x1, #0x53]
0066C0960  tbnz     w8, #5, #0x66c0980
0066C0964  ldr      x0, [x19, #0x20]
0066C0968  b        #0x66c098c ; 
0066C096C  ldr      x2, [x1, #0x60]
0066C0970  mov      x0, x19
0066C0974  ldp      x20, x19, [sp, #0x10]
0066C0978  ldp      x30, x21, [sp], #0x20
0066C097C  br       x2
0066C0980  ldr      x8, [x1, #0x60]
0066C0984  mov      x0, x19
0066C0988  blr      x8
0066C098C  cbz      x0, #0x66c09ac
0066C0990  ldr      x8, [x0, #0x128]
0066C0994  mov      x0, x19
0066C0998  mov      x1, xzr
0066C099C  stp      x8, xzr, [x19, #0x80]
0066C09A0  ldp      x20, x19, [sp, #0x10]
0066C09A4  ldp      x30, x21, [sp], #0x20
0066C09A8  b        #0x66c0854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyHurtElapsedTimeChanged
0066C09AC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyHurtElapsedTimeChanged
; RVA 0x66C0854; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0854  str      x30, [sp, #-0x30]!
0066C0858  stp      x22, x21, [sp, #0x10]
0066C085C  stp      x20, x19, [sp, #0x20]
0066C0860  adrp     x21, #0x959a000
0066C0864  adrp     x22, #0x8f11000
0066C0868  ldrb     w8, [x21, #0x234]
0066C086C  ldr      x22, [x22, #0xcd8]
0066C0870  mov      x19, x1
0066C0874  mov      x20, x0
0066C0878  tbnz     w8, #0, #0x66c0890
0066C087C  adrp     x0, #0x8f11000
0066C0880  ldr      x0, [x0, #0xcd8]
0066C0884  bl       #0x382bd14 ; 
0066C0888  mov      w8, #1
0066C088C  strb     w8, [x21, #0x234]
0066C0890  ldr      x2, [x22]
0066C0894  ldrb     w8, [x2, #0x53]
0066C0898  tbnz     w8, #5, #0x66c08c4
0066C089C  ldr      x8, [x20, #0x90]
0066C08A0  cmp      x8, x19
0066C08A4  b.eq     #0x66c08e0
0066C08A8  ldr      x8, [x20, #0x98]
0066C08AC  str      x19, [x20, #0x90]
0066C08B0  cbz      x8, #0x66c08e0
0066C08B4  ldr      x3, [x8, #0x18]
0066C08B8  ldr      x0, [x8, #0x40]
0066C08BC  ldr      x2, [x8, #0x28]
0066C08C0  b        #0x66c08cc ; 
0066C08C4  ldr      x3, [x2, #0x60]
0066C08C8  mov      x0, x20
0066C08CC  mov      x1, x19
0066C08D0  ldp      x20, x19, [sp, #0x20]
0066C08D4  ldp      x22, x21, [sp, #0x10]
0066C08D8  ldr      x30, [sp], #0x30
0066C08DC  br       x3
0066C08E0  ldp      x20, x19, [sp, #0x20]
0066C08E4  ldp      x22, x21, [sp, #0x10]
0066C08E8  ldr      x30, [sp], #0x30
0066C08EC  ret      

; HotFix.BattleLogic.CharacterComponentOnHit$$OnLateUpdate
; RVA 0x66C09B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C09B0  str      x30, [sp, #-0x30]!
0066C09B4  stp      x22, x21, [sp, #0x10]
0066C09B8  stp      x20, x19, [sp, #0x20]
0066C09BC  adrp     x21, #0x959a000
0066C09C0  adrp     x22, #0x8f11000
0066C09C4  ldrb     w8, [x21, #0x235]
0066C09C8  ldr      x22, [x22, #0xce8]
0066C09CC  mov      x19, x1
0066C09D0  mov      x20, x0
0066C09D4  tbnz     w8, #0, #0x66c09ec
0066C09D8  adrp     x0, #0x8f11000
0066C09DC  ldr      x0, [x0, #0xce8]
0066C09E0  bl       #0x382bd14 ; 
0066C09E4  mov      w8, #1
0066C09E8  strb     w8, [x21, #0x235]
0066C09EC  ldr      x2, [x22]
0066C09F0  ldrb     w8, [x2, #0x53]
0066C09F4  tbnz     w8, #5, #0x66c0a08
0066C09F8  ldp      x20, x19, [sp, #0x20]
0066C09FC  ldp      x22, x21, [sp, #0x10]
0066C0A00  ldr      x30, [sp], #0x30
0066C0A04  ret      
0066C0A08  ldr      x3, [x2, #0x60]
0066C0A0C  mov      x0, x20
0066C0A10  mov      x1, x19
0066C0A14  ldp      x20, x19, [sp, #0x20]
0066C0A18  ldp      x22, x21, [sp, #0x10]
0066C0A1C  ldr      x30, [sp], #0x30
0066C0A20  br       x3

; HotFix.BattleLogic.CharacterComponentOnHit$$BodyHit
; RVA 0x66C0A24; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0A24  str      x30, [sp, #-0x30]!
0066C0A28  stp      x22, x21, [sp, #0x10]
0066C0A2C  stp      x20, x19, [sp, #0x20]
0066C0A30  adrp     x21, #0x959a000
0066C0A34  adrp     x22, #0x8f11000
0066C0A38  ldrb     w8, [x21, #0x236]
0066C0A3C  ldr      x22, [x22, #0xcf0]
0066C0A40  mov      x19, x1
0066C0A44  mov      x20, x0
0066C0A48  tbnz     w8, #0, #0x66c0a60
0066C0A4C  adrp     x0, #0x8f11000
0066C0A50  ldr      x0, [x0, #0xcf0]
0066C0A54  bl       #0x382bd14 ; 
0066C0A58  mov      w8, #1
0066C0A5C  strb     w8, [x21, #0x236]
0066C0A60  ldr      x2, [x22]
0066C0A64  ldrb     w8, [x2, #0x53]
0066C0A68  tbnz     w8, #5, #0x66c0a84
0066C0A6C  mov      x0, x20
0066C0A70  mov      x1, x19
0066C0A74  ldp      x20, x19, [sp, #0x20]
0066C0A78  ldp      x22, x21, [sp, #0x10]
0066C0A7C  ldr      x30, [sp], #0x30
0066C0A80  b        #0x66c0aa0 ; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitByBody
0066C0A84  ldr      x3, [x2, #0x60]
0066C0A88  mov      x0, x20
0066C0A8C  mov      x1, x19
0066C0A90  ldp      x20, x19, [sp, #0x20]
0066C0A94  ldp      x22, x21, [sp, #0x10]
0066C0A98  ldr      x30, [sp], #0x30
0066C0A9C  br       x3

; HotFix.BattleLogic.CharacterComponentOnHit$$OnEvent
; RVA 0x66C14C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C14C0  sub      sp, sp, #0xb0
0066C14C4  str      x30, [sp, #0x70]
0066C14C8  stp      x24, x23, [sp, #0x80]
0066C14CC  stp      x22, x21, [sp, #0x90]
0066C14D0  stp      x20, x19, [sp, #0xa0]
0066C14D4  mrs      x24, tpidr_el0
0066C14D8  ldr      x8, [x24, #0x28]
0066C14DC  adrp     x22, #0x959a000
0066C14E0  adrp     x23, #0x8f11000
0066C14E4  mov      x20, x2
0066C14E8  str      x8, [sp, #0x68]
0066C14EC  ldrb     w8, [x22, #0x237]
0066C14F0  ldr      x23, [x23, #0xd18]
0066C14F4  mov      w21, w1
0066C14F8  mov      x19, x0
0066C14FC  tbnz     w8, #0, #0x66c1550
0066C1500  adrp     x0, #0x8f10000
0066C1504  ldr      x0, [x0, #0xb68]
0066C1508  bl       #0x382bd14 ; 
0066C150C  adrp     x0, #0x8f11000
0066C1510  ldr      x0, [x0, #0xd20]
0066C1514  bl       #0x382bd14 ; 
0066C1518  adrp     x0, #0x8f11000
0066C151C  ldr      x0, [x0, #0xd18]
0066C1520  bl       #0x382bd14 ; 
0066C1524  adrp     x0, #0x8ee6000
0066C1528  ldr      x0, [x0, #0x608]
0066C152C  bl       #0x382bd14 ; 
0066C1530  adrp     x0, #0x8ebf000
0066C1534  ldr      x0, [x0, #0xba0]
0066C1538  bl       #0x382bd14 ; 
0066C153C  adrp     x0, #0x8f09000
0066C1540  ldr      x0, [x0, #0x178]
0066C1544  bl       #0x382bd14 ; 
0066C1548  mov      w8, #1
0066C154C  strb     w8, [x22, #0x237]
0066C1550  ldr      x3, [x23]
0066C1554  ldrb     w8, [x3, #0x53]
0066C1558  tbnz     w8, #5, #0x66c15d4
0066C155C  cmp      w21, #0x14
0066C1560  strb     wzr, [sp, #0x4c]
0066C1564  str      wzr, [sp, #0x48]
0066C1568  b.eq     #0x66c1684
0066C156C  cmp      w21, #5
0066C1570  b.eq     #0x66c15ec
0066C1574  cmp      w21, #2
0066C1578  b.ne     #0x66c17f8
0066C157C  cbz      x20, #0x66c1820
0066C1580  ldr      w8, [x20, #0x18]
0066C1584  cbz      w8, #0x66c1824
0066C1588  ldr      x20, [x20, #0x20]
0066C158C  cbz      x20, #0x66c1838
0066C1590  adrp     x9, #0x8f11000
0066C1594  ldr      x9, [x9, #0xd20]
0066C1598  ldr      x8, [x20]
0066C159C  ldr      x1, [x9]
0066C15A0  ldrb     w10, [x8, #0x130]
0066C15A4  ldrb     w9, [x1, #0x130]
0066C15A8  cmp      w10, w9
0066C15AC  b.lo     #0x66c1828
0066C15B0  ldr      x8, [x8, #0xc8]
0066C15B4  add      x8, x8, x9, lsl #3
0066C15B8  ldur     x8, [x8, #-8]
0066C15BC  cmp      x8, x1
0066C15C0  b.ne     #0x66c1828
0066C15C4  mov      x0, x19
0066C15C8  mov      x1, x20
0066C15CC  bl       #0x66b6858 ; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitByBullet
0066C15D0  b        #0x66c17ec ; 
0066C15D4  ldr      x8, [x3, #0x60]
0066C15D8  mov      x0, x19
0066C15DC  mov      w1, w21
0066C15E0  mov      x2, x20
0066C15E4  blr      x8
0066C15E8  b        #0x66c17f8 ; 
0066C15EC  cbz      x20, #0x66c1820
0066C15F0  ldr      w8, [x20, #0x18]
0066C15F4  cbz      w8, #0x66c1824
0066C15F8  ldr      x0, [x20, #0x20]
0066C15FC  cbz      x0, #0x66c1820
0066C1600  adrp     x8, #0x8ebf000
0066C1604  ldr      x8, [x8, #0xba0]
0066C1608  ldr      x9, [x0]
0066C160C  ldr      x1, [x8]
0066C1610  ldr      x8, [x9, #0x40]
0066C1614  ldr      x9, [x1, #0x40]
0066C1618  cmp      x8, x9
0066C161C  b.ne     #0x66c1848
0066C1620  bl       #0x382be98 ; 
0066C1624  ldr      w20, [x0]
0066C1628  mov      w0, #0x19
0066C162C  mov      x1, xzr
0066C1630  bl       #0x68e8874 ; HotFix.BattleLogic.HurtDeltaHpSourceInfo$$FromKind
0066C1634  adrp     x8, #0x8f09000
0066C1638  ldr      x8, [x8, #0x178]
0066C163C  mov      x2, x0
0066C1640  mov      x4, x1
0066C1644  add      x0, sp, #0x30
0066C1648  ldr      x3, [x8]
0066C164C  mov      x1, x2
0066C1650  mov      x2, x4
0066C1654  stp      xzr, xzr, [sp, #0x30]
0066C1658  str      xzr, [sp, #0x40]
0066C165C  bl       #0x51360ac ; System.Nullable<HurtDeltaHpSourceInfo>$$.ctor
0066C1660  ldr      q0, [sp, #0x30]
0066C1664  ldr      x8, [sp, #0x40]
0066C1668  add      x2, sp, #0x10
0066C166C  mov      x0, x19
0066C1670  mov      w1, w20
0066C1674  str      q0, [sp, #0x10]
0066C1678  str      x8, [sp, #0x20]
0066C167C  bl       #0x66c1850 ; HotFix.BattleLogic.CharacterComponentOnHit$$RecoverHp
0066C1680  b        #0x66c17f8 ; 
0066C1684  cbz      x20, #0x66c1820
0066C1688  ldr      w8, [x20, #0x18]
0066C168C  cbz      w8, #0x66c1824
0066C1690  ldr      x21, [x20, #0x20]
0066C1694  cbz      x21, #0x66c16cc
0066C1698  adrp     x9, #0x8f10000
0066C169C  ldr      x9, [x9, #0xb68]
0066C16A0  ldr      x8, [x21]
0066C16A4  ldr      x1, [x9]
0066C16A8  ldrb     w10, [x8, #0x130]
0066C16AC  ldrb     w9, [x1, #0x130]
0066C16B0  cmp      w10, w9
0066C16B4  b.lo     #0x66c1830
0066C16B8  ldr      x8, [x8, #0xc8]
0066C16BC  add      x8, x8, x9, lsl #3
0066C16C0  ldur     x8, [x8, #-8]
0066C16C4  cmp      x8, x1
0066C16C8  b.ne     #0x66c1830
0066C16CC  adrp     x8, #0x8ee6000
0066C16D0  ldr      x8, [x8, #0x608]
0066C16D4  ldr      x1, [x8]
0066C16D8  ldrb     w8, [x1, #0x53]
0066C16DC  tbnz     w8, #5, #0x66c16e8
0066C16E0  ldr      x1, [x19, #0x30]
0066C16E4  b        #0x66c16f8 ; 
0066C16E8  ldr      x8, [x1, #0x60]
0066C16EC  mov      x0, x19
0066C16F0  blr      x8
0066C16F4  mov      x1, x0
0066C16F8  mov      x0, x21
0066C16FC  mov      x2, xzr
0066C1700  bl       #0x68e0080 ; HotFix.BattleLogic.AttackSourceInfo$$FromBuffAttack
0066C1704  mov      x22, x0
0066C1708  mov      x0, x19
0066C170C  mov      x1, x22
0066C1710  bl       #0x66b8ab0 ; HotFix.BattleLogic.CharacterComponentOnHit$$CreateHurtSourceDataFromAttackInfo
0066C1714  cbz      x0, #0x66c17f8
0066C1718  cbz      x21, #0x66c1820
0066C171C  mov      x20, x0
0066C1720  mov      x0, x21
0066C1724  mov      x1, xzr
0066C1728  bl       #0x663b208 ; HotFix.BattleLogic.BuffBase$$GetElementCriRate
0066C172C  mov      x23, x0
0066C1730  mov      x0, x21
0066C1734  mov      x1, xzr
0066C1738  bl       #0x663b26c ; HotFix.BattleLogic.BuffBase$$GetElementCriValue
0066C173C  mov      x2, x0
0066C1740  mov      x0, x20
0066C1744  mov      x1, x23
0066C1748  mov      x3, xzr
0066C174C  bl       #0x68f06b4 ; HotFix.BattleLogic.HurtSourceData$$SetElementCriData
0066C1750  mov      x0, x19
0066C1754  mov      x1, x20
0066C1758  mov      x2, x22
0066C175C  bl       #0x66b8c7c ; HotFix.BattleLogic.CharacterComponentOnHit$$BuildHurtDataArray
0066C1760  mov      x21, x0
0066C1764  add      x4, sp, #0x4c
0066C1768  add      x5, sp, #0x48
0066C176C  add      x6, sp, #0x50
0066C1770  mov      x0, x19
0066C1774  mov      x1, x20
0066C1778  mov      x2, x21
0066C177C  mov      w3, wzr
0066C1780  mov      x7, xzr
0066C1784  stp      xzr, xzr, [sp, #0x58]
0066C1788  str      xzr, [sp, #0x50]
0066C178C  str      wzr, [sp]
0066C1790  bl       #0x66bca88 ; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitUpdateHP
0066C1794  adrp     x22, #0x9591000
0066C1798  ldrb     w8, [x22, #0xa4b]
0066C179C  cbnz     w8, #0x66c17b4
0066C17A0  adrp     x0, #0x8ee5000
0066C17A4  ldr      x0, [x0, #0xb28]
0066C17A8  bl       #0x382bd14 ; 
0066C17AC  mov      w8, #1
0066C17B0  strb     w8, [x22, #0xa4b]
0066C17B4  adrp     x8, #0x8ee5000
0066C17B8  ldr      x8, [x8, #0xb28]
0066C17BC  ldr      x1, [x8]
0066C17C0  ldrb     w8, [x1, #0x53]
0066C17C4  tbnz     w8, #5, #0x66c17d0
0066C17C8  ldr      x0, [x19, #0x20]
0066C17CC  b        #0x66c17dc ; 
0066C17D0  ldr      x8, [x1, #0x60]
0066C17D4  mov      x0, x19
0066C17D8  blr      x8
0066C17DC  cbz      x0, #0x66c1820
0066C17E0  mov      x1, x21
0066C17E4  mov      x2, xzr
0066C17E8  bl       #0x69faa68 ; HotFix.BattleLogic.BattleWorldContext$$PushHurtDataArray
0066C17EC  mov      x0, x20
0066C17F0  mov      x1, xzr
0066C17F4  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066C17F8  ldr      x8, [x24, #0x28]
0066C17FC  ldr      x9, [sp, #0x68]
0066C1800  cmp      x8, x9
0066C1804  b.ne     #0x66c184c
0066C1808  ldp      x20, x19, [sp, #0xa0]
0066C180C  ldp      x22, x21, [sp, #0x90]
0066C1810  ldp      x24, x23, [sp, #0x80]
0066C1814  ldr      x30, [sp, #0x70]
0066C1818  add      sp, sp, #0xb0
0066C181C  ret      
0066C1820  bl       #0x382bfb8 ; 
0066C1824  bl       #0x382bfc0 ; 
0066C1828  mov      x0, x20
0066C182C  bl       #0x382c354 ; 
0066C1830  mov      x0, x21
0066C1834  bl       #0x382c354 ; 
0066C1838  mov      x0, x19
0066C183C  mov      x1, x20
0066C1840  bl       #0x66b6858 ; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitByBullet
0066C1844  bl       #0x382bfb8 ; 
0066C1848  bl       #0x382c354 ; 
0066C184C  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateHitTime
; RVA 0x66C1B58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C1B58  stp      x30, x21, [sp, #-0x20]!
0066C1B5C  stp      x20, x19, [sp, #0x10]
0066C1B60  adrp     x20, #0x959a000
0066C1B64  adrp     x21, #0x8f11000
0066C1B68  ldrb     w8, [x20, #0x238]
0066C1B6C  ldr      x21, [x21, #0xd30]
0066C1B70  mov      x19, x0
0066C1B74  tbnz     w8, #0, #0x66c1b8c
0066C1B78  adrp     x0, #0x8f11000
0066C1B7C  ldr      x0, [x0, #0xd30]
0066C1B80  bl       #0x382bd14 ; 
0066C1B84  mov      w8, #1
0066C1B88  strb     w8, [x20, #0x238]
0066C1B8C  ldr      x1, [x21]
0066C1B90  ldrb     w8, [x1, #0x53]
0066C1B94  tbnz     w8, #5, #0x66c1bd4
0066C1B98  adrp     x20, #0x9591000
0066C1B9C  ldrb     w8, [x20, #0xa4b]
0066C1BA0  cbnz     w8, #0x66c1bb8
0066C1BA4  adrp     x0, #0x8ee5000
0066C1BA8  ldr      x0, [x0, #0xb28]
0066C1BAC  bl       #0x382bd14 ; 
0066C1BB0  mov      w8, #1
0066C1BB4  strb     w8, [x20, #0xa4b]
0066C1BB8  adrp     x8, #0x8ee5000
0066C1BBC  ldr      x8, [x8, #0xb28]
0066C1BC0  ldr      x1, [x8]
0066C1BC4  ldrb     w8, [x1, #0x53]
0066C1BC8  tbnz     w8, #5, #0x66c1be8
0066C1BCC  ldr      x0, [x19, #0x20]
0066C1BD0  b        #0x66c1bf4 ; 
0066C1BD4  ldr      x2, [x1, #0x60]
0066C1BD8  mov      x0, x19
0066C1BDC  ldp      x20, x19, [sp, #0x10]
0066C1BE0  ldp      x30, x21, [sp], #0x20
0066C1BE4  br       x2
0066C1BE8  ldr      x8, [x1, #0x60]
0066C1BEC  mov      x0, x19
0066C1BF0  blr      x8
0066C1BF4  cbz      x0, #0x66c1c0c
0066C1BF8  ldr      x8, [x0, #0x128]
0066C1BFC  str      x8, [x19, #0x40]
0066C1C00  ldp      x20, x19, [sp, #0x10]
0066C1C04  ldp      x30, x21, [sp], #0x20
0066C1C08  ret      
0066C1C0C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$IsHitTimeOk
; RVA 0x66C1C10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C1C10  stp      x30, x21, [sp, #-0x20]!
0066C1C14  stp      x20, x19, [sp, #0x10]
0066C1C18  adrp     x20, #0x959a000
0066C1C1C  adrp     x21, #0x8f11000
0066C1C20  ldrb     w8, [x20, #0x239]
0066C1C24  ldr      x21, [x21, #0xd38]
0066C1C28  mov      x19, x0
0066C1C2C  tbnz     w8, #0, #0x66c1c5c
0066C1C30  adrp     x0, #0x8f11000
0066C1C34  ldr      x0, [x0, #0xd38]
0066C1C38  bl       #0x382bd14 ; 
0066C1C3C  adrp     x0, #0x8ee6000
0066C1C40  ldr      x0, [x0, #0x600]
0066C1C44  bl       #0x382bd14 ; 
0066C1C48  adrp     x0, #0x8f11000
0066C1C4C  ldr      x0, [x0, #0xd40]
0066C1C50  bl       #0x382bd14 ; 
0066C1C54  mov      w8, #1
0066C1C58  strb     w8, [x20, #0x239]
0066C1C5C  ldr      x1, [x21]
0066C1C60  ldrb     w8, [x1, #0x53]
0066C1C64  tbnz     w8, #5, #0x66c1c84
0066C1C68  adrp     x8, #0x8ee6000
0066C1C6C  ldr      x8, [x8, #0x600]
0066C1C70  ldr      x1, [x8]
0066C1C74  ldrb     w8, [x1, #0x53]
0066C1C78  tbnz     w8, #5, #0x66c1c98
0066C1C7C  ldr      x20, [x19, #0x38]
0066C1C80  b        #0x66c1ca8 ; 
0066C1C84  ldr      x2, [x1, #0x60]
0066C1C88  mov      x0, x19
0066C1C8C  ldp      x20, x19, [sp, #0x10]
0066C1C90  ldp      x30, x21, [sp], #0x20
0066C1C94  br       x2
0066C1C98  ldr      x8, [x1, #0x60]
0066C1C9C  mov      x0, x19
0066C1CA0  blr      x8
0066C1CA4  mov      x20, x0
0066C1CA8  cbz      x20, #0x66c1d7c
0066C1CAC  adrp     x21, #0x9591000
0066C1CB0  ldrb     w8, [x21, #0xa7f]
0066C1CB4  cbnz     w8, #0x66c1ccc
0066C1CB8  adrp     x0, #0x8ee6000
0066C1CBC  ldr      x0, [x0, #0x2d8]
0066C1CC0  bl       #0x382bd14 ; 
0066C1CC4  mov      w8, #1
0066C1CC8  strb     w8, [x21, #0xa7f]
0066C1CCC  adrp     x8, #0x8ee6000
0066C1CD0  ldr      x8, [x8, #0x2d8]
0066C1CD4  ldr      x1, [x8]
0066C1CD8  ldrb     w8, [x1, #0x53]
0066C1CDC  tbnz     w8, #5, #0x66c1ce8
0066C1CE0  ldr      x0, [x20, #0x178]
0066C1CE4  b        #0x66c1cf4 ; 
0066C1CE8  ldr      x8, [x1, #0x60]
0066C1CEC  mov      x0, x20
0066C1CF0  blr      x8
0066C1CF4  cbz      x0, #0x66c1d7c
0066C1CF8  adrp     x8, #0x8f11000
0066C1CFC  ldr      x8, [x8, #0xd40]
0066C1D00  mov      x2, xzr
0066C1D04  ldr      x1, [x8]
0066C1D08  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
0066C1D0C  adrp     x21, #0x9591000
0066C1D10  ldrb     w8, [x21, #0xa4b]
0066C1D14  mov      x20, x0
0066C1D18  cbnz     w8, #0x66c1d30
0066C1D1C  adrp     x0, #0x8ee5000
0066C1D20  ldr      x0, [x0, #0xb28]
0066C1D24  bl       #0x382bd14 ; 
0066C1D28  mov      w8, #1
0066C1D2C  strb     w8, [x21, #0xa4b]
0066C1D30  adrp     x8, #0x8ee5000
0066C1D34  ldr      x8, [x8, #0xb28]
0066C1D38  ldr      x1, [x8]
0066C1D3C  ldrb     w8, [x1, #0x53]
0066C1D40  tbnz     w8, #5, #0x66c1d4c
0066C1D44  ldr      x0, [x19, #0x20]
0066C1D48  b        #0x66c1d58 ; 
0066C1D4C  ldr      x8, [x1, #0x60]
0066C1D50  mov      x0, x19
0066C1D54  blr      x8
0066C1D58  cbz      x0, #0x66c1d7c
0066C1D5C  ldr      x8, [x0, #0x128]
0066C1D60  ldr      x9, [x19, #0x40]
0066C1D64  sub      x8, x8, x9
0066C1D68  cmp      x8, x20
0066C1D6C  ldp      x20, x19, [sp, #0x10]
0066C1D70  cset     w0, ge
0066C1D74  ldp      x30, x21, [sp], #0x20
0066C1D78  ret      
0066C1D7C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndUpdateHitTime
; RVA 0x66B7518; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B7518  sub      sp, sp, #0xa0
0066B751C  str      x30, [sp, #0x50]
0066B7520  stp      x26, x25, [sp, #0x60]
0066B7524  stp      x24, x23, [sp, #0x70]
0066B7528  stp      x22, x21, [sp, #0x80]
0066B752C  stp      x20, x19, [sp, #0x90]
0066B7530  mrs      x22, tpidr_el0
0066B7534  ldr      x8, [x22, #0x28]
0066B7538  adrp     x20, #0x959a000
0066B753C  adrp     x21, #0x8f11000
0066B7540  mov      x19, x0
0066B7544  str      x8, [sp, #0x48]
0066B7548  ldrb     w8, [x20, #0x23a]
0066B754C  ldr      x21, [x21, #0x938]
0066B7550  tbnz     w8, #0, #0x66b75a4
0066B7554  adrp     x0, #0x8f11000
0066B7558  ldr      x0, [x0, #0x938]
0066B755C  bl       #0x382bd14 ; 
0066B7560  adrp     x0, #0x8ee6000
0066B7564  ldr      x0, [x0, #0xd8]
0066B7568  bl       #0x382bd14 ; 
0066B756C  adrp     x0, #0x8ee6000
0066B7570  ldr      x0, [x0, #0xe8]
0066B7574  bl       #0x382bd14 ; 
0066B7578  adrp     x0, #0x8ee6000
0066B757C  ldr      x0, [x0, #0x600]
0066B7580  bl       #0x382bd14 ; 
0066B7584  adrp     x0, #0x8ee6000
0066B7588  ldr      x0, [x0, #0x608]
0066B758C  bl       #0x382bd14 ; 
0066B7590  adrp     x0, #0x8f11000
0066B7594  ldr      x0, [x0, #0x940]
0066B7598  bl       #0x382bd14 ; 
0066B759C  mov      w8, #1
0066B75A0  strb     w8, [x20, #0x23a]
0066B75A4  ldr      x1, [x21]
0066B75A8  ldrb     w8, [x1, #0x53]
0066B75AC  tbnz     w8, #5, #0x66b75cc
0066B75B0  adrp     x23, #0x8ee6000
0066B75B4  ldr      x23, [x23, #0x608]
0066B75B8  ldr      x1, [x23]
0066B75BC  ldrb     w8, [x1, #0x53]
0066B75C0  tbnz     w8, #5, #0x66b75f0
0066B75C4  ldr      x0, [x19, #0x30]
0066B75C8  b        #0x66b75fc ; 
0066B75CC  ldr      x8, [x1, #0x60]
0066B75D0  mov      x0, x19
0066B75D4  blr      x8
0066B75D8  ldr      x8, [x22, #0x28]
0066B75DC  ldr      x9, [sp, #0x48]
0066B75E0  cmp      x8, x9
0066B75E4  b.ne     #0x66b7a30
0066B75E8  and      w0, w0, #1
0066B75EC  b        #0x66b7a10 ; 
0066B75F0  ldr      x8, [x1, #0x60]
0066B75F4  mov      x0, x19
0066B75F8  blr      x8
0066B75FC  cbz      x0, #0x66b7a2c
0066B7600  mov      x1, xzr
0066B7604  bl       #0x67f7da8 ; HotFix.BattleLogic.EntityCharacter$$get_IsInvincible
0066B7608  tbz      w0, #0, #0x66b7648
0066B760C  adrp     x21, #0x9591000
0066B7610  ldrb     w8, [x21, #0xa4b]
0066B7614  cbnz     w8, #0x66b762c
0066B7618  adrp     x0, #0x8ee5000
0066B761C  ldr      x0, [x0, #0xb28]
0066B7620  bl       #0x382bd14 ; 
0066B7624  mov      w8, #1
0066B7628  strb     w8, [x21, #0xa4b]
0066B762C  adrp     x24, #0x8ee5000
0066B7630  ldr      x24, [x24, #0xb28]
0066B7634  ldr      x1, [x24]
0066B7638  ldrb     w8, [x1, #0x53]
0066B763C  tbnz     w8, #5, #0x66b7664
0066B7640  ldr      x20, [x19, #0x20]
0066B7644  b        #0x66b7674 ; 
0066B7648  mov      x0, x19
0066B764C  bl       #0x66c1c10 ; HotFix.BattleLogic.CharacterComponentOnHit$$IsHitTimeOk
0066B7650  tbz      w0, #0, #0x66b79fc
0066B7654  mov      x0, x19
0066B7658  bl       #0x66c1b58 ; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateHitTime
0066B765C  mov      w0, #1
0066B7660  b        #0x66b7a00 ; 
0066B7664  ldr      x8, [x1, #0x60]
0066B7668  mov      x0, x19
0066B766C  blr      x8
0066B7670  mov      x20, x0
0066B7674  ldr      x1, [x23]
0066B7678  ldrb     w8, [x1, #0x53]
0066B767C  tbnz     w8, #5, #0x66b7688
0066B7680  ldr      x0, [x19, #0x30]
0066B7684  b        #0x66b7694 ; 
0066B7688  ldr      x8, [x1, #0x60]
0066B768C  mov      x0, x19
0066B7690  blr      x8
0066B7694  cbz      x0, #0x66b7a2c
0066B7698  adrp     x8, #0x8ee6000
0066B769C  ldr      x8, [x8, #0xe8]
0066B76A0  ldr      x1, [x8]
0066B76A4  ldrb     w8, [x1, #0x53]
0066B76A8  tbnz     w8, #5, #0x66b76b4
0066B76AC  ldr      x3, [x0, #0x28]
0066B76B0  b        #0x66b76c0 ; 
0066B76B4  ldr      x8, [x1, #0x60]
0066B76B8  blr      x8
0066B76BC  mov      x3, x0
0066B76C0  cbz      x20, #0x66b7a2c
0066B76C4  mov      w1, #0x10
0066B76C8  mov      w4, #0x10000
0066B76CC  mov      x0, x20
0066B76D0  mov      w2, wzr
0066B76D4  mov      w5, wzr
0066B76D8  mov      w6, wzr
0066B76DC  mov      x7, xzr
0066B76E0  str      xzr, [sp, #8]
0066B76E4  str      wzr, [sp]
0066B76E8  bl       #0x6a0ed24 ; HotFix.BattleLogic.BattleWorldContext$$ShowHoverEvent
0066B76EC  ldrb     w8, [x21, #0xa4b]
0066B76F0  cbnz     w8, #0x66b7708
0066B76F4  adrp     x0, #0x8ee5000
0066B76F8  ldr      x0, [x0, #0xb28]
0066B76FC  bl       #0x382bd14 ; 
0066B7700  mov      w8, #1
0066B7704  strb     w8, [x21, #0xa4b]
0066B7708  ldr      x1, [x24]
0066B770C  ldrb     w8, [x1, #0x53]
0066B7710  tbnz     w8, #5, #0x66b771c
0066B7714  ldr      x20, [x19, #0x20]
0066B7718  b        #0x66b772c ; 
0066B771C  ldr      x8, [x1, #0x60]
0066B7720  mov      x0, x19
0066B7724  blr      x8
0066B7728  mov      x20, x0
0066B772C  cbz      x20, #0x66b7a2c
0066B7730  adrp     x21, #0x9591000
0066B7734  ldrb     w8, [x21, #0xa4c]
0066B7738  cbnz     w8, #0x66b7750
0066B773C  adrp     x0, #0x8ee5000
0066B7740  ldr      x0, [x0, #0xb30]
0066B7744  bl       #0x382bd14 ; 
0066B7748  mov      w8, #1
0066B774C  strb     w8, [x21, #0xa4c]
0066B7750  adrp     x8, #0x8ee5000
0066B7754  ldr      x8, [x8, #0xb30]
0066B7758  ldr      x1, [x8]
0066B775C  ldrb     w8, [x1, #0x53]
0066B7760  tbnz     w8, #5, #0x66b776c
0066B7764  ldr      x0, [x20, #0x210]
0066B7768  b        #0x66b7778 ; 
0066B776C  ldr      x8, [x1, #0x60]
0066B7770  mov      x0, x20
0066B7774  blr      x8
0066B7778  cbz      x0, #0x66b7a2c
0066B777C  adrp     x8, #0x8f11000
0066B7780  ldr      x8, [x8, #0x940]
0066B7784  ldr      x1, [x8]
0066B7788  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066B778C  adrp     x24, #0x8ee6000
0066B7790  ldr      x24, [x24, #0x600]
0066B7794  mov      x20, x0
0066B7798  ldr      x1, [x24]
0066B779C  ldrb     w8, [x1, #0x53]
0066B77A0  tbnz     w8, #5, #0x66b77ac
0066B77A4  ldr      x21, [x19, #0x38]
0066B77A8  b        #0x66b77bc ; 
0066B77AC  ldr      x8, [x1, #0x60]
0066B77B0  mov      x0, x19
0066B77B4  blr      x8
0066B77B8  mov      x21, x0
0066B77BC  cbz      x21, #0x66b7a2c
0066B77C0  adrp     x25, #0x9592000
0066B77C4  ldrb     w8, [x25, #0x473]
0066B77C8  cbnz     w8, #0x66b77e0
0066B77CC  adrp     x0, #0x8ee8000
0066B77D0  ldr      x0, [x0, #0x890]
0066B77D4  bl       #0x382bd14 ; 
0066B77D8  mov      w8, #1
0066B77DC  strb     w8, [x25, #0x473]
0066B77E0  adrp     x26, #0x8ee8000
0066B77E4  ldr      x26, [x26, #0x890]
0066B77E8  ldr      x1, [x26]
0066B77EC  ldrb     w8, [x1, #0x53]
0066B77F0  tbnz     w8, #5, #0x66b77fc
0066B77F4  ldr      x0, [x21, #0x20]
0066B77F8  b        #0x66b7808 ; 
0066B77FC  ldr      x8, [x1, #0x60]
0066B7800  mov      x0, x21
0066B7804  blr      x8
0066B7808  cbz      x20, #0x66b7a2c
0066B780C  str      x0, [x20, #0x38]
0066B7810  ldr      x1, [x24]
0066B7814  ldrb     w8, [x1, #0x53]
0066B7818  tbnz     w8, #5, #0x66b7824
0066B781C  ldr      x21, [x19, #0x38]
0066B7820  b        #0x66b7834 ; 
0066B7824  ldr      x8, [x1, #0x60]
0066B7828  mov      x0, x19
0066B782C  blr      x8
0066B7830  mov      x21, x0
0066B7834  cbz      x21, #0x66b7a2c
0066B7838  ldrb     w8, [x25, #0x473]
0066B783C  cbnz     w8, #0x66b7854
0066B7840  adrp     x0, #0x8ee8000
0066B7844  ldr      x0, [x0, #0x890]
0066B7848  bl       #0x382bd14 ; 
0066B784C  mov      w8, #1
0066B7850  strb     w8, [x25, #0x473]
0066B7854  ldr      x1, [x26]
0066B7858  ldrb     w8, [x1, #0x53]
0066B785C  tbnz     w8, #5, #0x66b7868
0066B7860  ldr      x0, [x21, #0x20]
0066B7864  b        #0x66b7874 ; 
0066B7868  ldr      x8, [x1, #0x60]
0066B786C  mov      x0, x21
0066B7870  blr      x8
0066B7874  str      x0, [x20, #0x48]
0066B7878  ldr      x1, [x24]
0066B787C  ldrb     w8, [x1, #0x53]
0066B7880  tbnz     w8, #5, #0x66b788c
0066B7884  ldr      x0, [x19, #0x38]
0066B7888  b        #0x66b7898 ; 
0066B788C  ldr      x8, [x1, #0x60]
0066B7890  mov      x0, x19
0066B7894  blr      x8
0066B7898  cbz      x0, #0x66b7a2c
0066B789C  add      x8, sp, #0x18
0066B78A0  mov      x1, xzr
0066B78A4  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066B78A8  ldr      x8, [sp, #0x28]
0066B78AC  ldur     q0, [sp, #0x18]
0066B78B0  str      x8, [sp, #0x40]
0066B78B4  str      q0, [sp, #0x30]
0066B78B8  str      x8, [x20, #0x30]
0066B78BC  str      q0, [x20, #0x20]
0066B78C0  ldr      x1, [x23]
0066B78C4  ldrb     w8, [x1, #0x53]
0066B78C8  tbnz     w8, #5, #0x66b78d4
0066B78CC  ldr      x21, [x19, #0x30]
0066B78D0  b        #0x66b78e4 ; 
0066B78D4  ldr      x8, [x1, #0x60]
0066B78D8  mov      x0, x19
0066B78DC  blr      x8
0066B78E0  mov      x21, x0
0066B78E4  cbz      x21, #0x66b7a2c
0066B78E8  adrp     x24, #0x9591000
0066B78EC  ldrb     w8, [x24, #0xa86]
0066B78F0  cbnz     w8, #0x66b7914
0066B78F4  adrp     x0, #0x8ee6000
0066B78F8  ldr      x0, [x0, #0x318]
0066B78FC  bl       #0x382bd14 ; 
0066B7900  adrp     x0, #0x8ee3000
0066B7904  ldr      x0, [x0, #0xf18]
0066B7908  bl       #0x382bd14 ; 
0066B790C  mov      w8, #1
0066B7910  strb     w8, [x24, #0xa86]
0066B7914  adrp     x8, #0x8ee6000
0066B7918  ldr      x8, [x8, #0x318]
0066B791C  ldr      x2, [x8]
0066B7920  ldrb     w8, [x2, #0x53]
0066B7924  tbnz     w8, #5, #0x66b794c
0066B7928  ldr      x0, [x21, #0x190]
0066B792C  cbz      x0, #0x66b7998
0066B7930  adrp     x8, #0x8ee3000
0066B7934  ldr      x8, [x8, #0xf18]
0066B7938  mov      w1, #0xc
0066B793C  ldr      x2, [x8]
0066B7940  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066B7944  tbnz     w0, #0, #0x66b7960
0066B7948  b        #0x66b7998 ; 
0066B794C  ldr      x8, [x2, #0x60]
0066B7950  mov      w1, #0xc
0066B7954  mov      x0, x21
0066B7958  blr      x8
0066B795C  tbz      w0, #0, #0x66b7998
0066B7960  ldr      x1, [x23]
0066B7964  ldrb     w8, [x1, #0x53]
0066B7968  tbnz     w8, #5, #0x66b7974
0066B796C  ldr      x0, [x19, #0x30]
0066B7970  b        #0x66b7980 ; 
0066B7974  ldr      x8, [x1, #0x60]
0066B7978  mov      x0, x19
0066B797C  blr      x8
0066B7980  cbz      x0, #0x66b7a2c
0066B7984  ldr      x0, [x0, #0x150]
0066B7988  cbz      x0, #0x66b7a2c
0066B798C  mov      x1, x20
0066B7990  mov      x2, xzr
0066B7994  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066B7998  ldr      x1, [x23]
0066B799C  ldrb     w8, [x1, #0x53]
0066B79A0  tbnz     w8, #5, #0x66b79ac
0066B79A4  ldr      x0, [x19, #0x30]
0066B79A8  b        #0x66b79b8 ; 
0066B79AC  ldr      x8, [x1, #0x60]
0066B79B0  mov      x0, x19
0066B79B4  blr      x8
0066B79B8  cbz      x0, #0x66b7a2c
0066B79BC  adrp     x8, #0x8ee6000
0066B79C0  ldr      x8, [x8, #0xd8]
0066B79C4  ldr      x1, [x8]
0066B79C8  ldrb     w8, [x1, #0x53]
0066B79CC  tbnz     w8, #5, #0x66b79d8
0066B79D0  ldr      x0, [x0, #0x38]
0066B79D4  b        #0x66b79e0 ; 
0066B79D8  ldr      x8, [x1, #0x60]
0066B79DC  blr      x8
0066B79E0  cbz      x0, #0x66b7a2c
0066B79E4  mov      x1, xzr
0066B79E8  bl       #0x45616a8 ; 
0066B79EC  tbz      w0, #0, #0x66b79fc
0066B79F0  mov      x0, x19
0066B79F4  mov      x1, x20
0066B79F8  bl       #0x66c1d80 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroInvHurt
0066B79FC  mov      w0, wzr
0066B7A00  ldr      x8, [x22, #0x28]
0066B7A04  ldr      x9, [sp, #0x48]
0066B7A08  cmp      x8, x9
0066B7A0C  b.ne     #0x66b7a30
0066B7A10  ldp      x20, x19, [sp, #0x90]
0066B7A14  ldp      x22, x21, [sp, #0x80]
0066B7A18  ldp      x24, x23, [sp, #0x70]
0066B7A1C  ldp      x26, x25, [sp, #0x60]
0066B7A20  ldr      x30, [sp, #0x50]
0066B7A24  add      sp, sp, #0xa0
0066B7A28  ret      
0066B7A2C  bl       #0x382bfb8 ; 
0066B7A30  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$DispatchDamageRenderEvent
; RVA 0x66BDA9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BDA9C  sub      sp, sp, #0x70
0066BDAA0  stp      x30, x27, [sp, #0x20]
0066BDAA4  stp      x26, x25, [sp, #0x30]
0066BDAA8  stp      x24, x23, [sp, #0x40]
0066BDAAC  stp      x22, x21, [sp, #0x50]
0066BDAB0  stp      x20, x19, [sp, #0x60]
0066BDAB4  mrs      x24, tpidr_el0
0066BDAB8  ldr      x8, [x24, #0x28]
0066BDABC  adrp     x22, #0x959a000
0066BDAC0  adrp     x23, #0x8f11000
0066BDAC4  mov      w20, w2
0066BDAC8  str      x8, [sp, #0x18]
0066BDACC  ldrb     w8, [x22, #0x23b]
0066BDAD0  ldr      x23, [x23, #0xb58]
0066BDAD4  mov      x21, x1
0066BDAD8  mov      x19, x0
0066BDADC  tbnz     w8, #0, #0x66bdb24
0066BDAE0  adrp     x0, #0x8f11000
0066BDAE4  ldr      x0, [x0, #0xb58]
0066BDAE8  bl       #0x382bd14 ; 
0066BDAEC  adrp     x0, #0x8ee6000
0066BDAF0  ldr      x0, [x0, #0x600]
0066BDAF4  bl       #0x382bd14 ; 
0066BDAF8  adrp     x0, #0x8ee6000
0066BDAFC  ldr      x0, [x0, #0x608]
0066BDB00  bl       #0x382bd14 ; 
0066BDB04  adrp     x0, #0x8f11000
0066BDB08  ldr      x0, [x0, #0xb60]
0066BDB0C  bl       #0x382bd14 ; 
0066BDB10  adrp     x0, #0x8f11000
0066BDB14  ldr      x0, [x0, #0xb68]
0066BDB18  bl       #0x382bd14 ; 
0066BDB1C  mov      w8, #1
0066BDB20  strb     w8, [x22, #0x23b]
0066BDB24  ldr      x3, [x23]
0066BDB28  ldrb     w8, [x3, #0x53]
0066BDB2C  tbnz     w8, #5, #0x66bdb6c
0066BDB30  adrp     x25, #0x9591000
0066BDB34  ldrb     w8, [x25, #0xa4b]
0066BDB38  cbnz     w8, #0x66bdb50
0066BDB3C  adrp     x0, #0x8ee5000
0066BDB40  ldr      x0, [x0, #0xb28]
0066BDB44  bl       #0x382bd14 ; 
0066BDB48  mov      w8, #1
0066BDB4C  strb     w8, [x25, #0xa4b]
0066BDB50  adrp     x26, #0x8ee5000
0066BDB54  ldr      x26, [x26, #0xb28]
0066BDB58  ldr      x1, [x26]
0066BDB5C  ldrb     w8, [x1, #0x53]
0066BDB60  tbnz     w8, #5, #0x66bdb94
0066BDB64  ldr      x22, [x19, #0x20]
0066BDB68  b        #0x66bdba4 ; 
0066BDB6C  ldr      x8, [x21, #0x10]
0066BDB70  ldr      q0, [x21]
0066BDB74  ldr      x9, [x3, #0x60]
0066BDB78  mov      x1, sp
0066BDB7C  mov      x0, x19
0066BDB80  mov      w2, w20
0066BDB84  str      x8, [sp, #0x10]
0066BDB88  str      q0, [sp]
0066BDB8C  blr      x9
0066BDB90  b        #0x66bdd9c ; 
0066BDB94  ldr      x8, [x1, #0x60]
0066BDB98  mov      x0, x19
0066BDB9C  blr      x8
0066BDBA0  mov      x22, x0
0066BDBA4  cbz      x22, #0x66bddc8
0066BDBA8  adrp     x23, #0x9591000
0066BDBAC  ldrb     w8, [x23, #0xa61]
0066BDBB0  cbnz     w8, #0x66bdbc8
0066BDBB4  adrp     x0, #0x8ee6000
0066BDBB8  ldr      x0, [x0, #0x308]
0066BDBBC  bl       #0x382bd14 ; 
0066BDBC0  mov      w8, #1
0066BDBC4  strb     w8, [x23, #0xa61]
0066BDBC8  adrp     x8, #0x8ee6000
0066BDBCC  ldr      x8, [x8, #0x308]
0066BDBD0  ldr      x1, [x8]
0066BDBD4  ldrb     w8, [x1, #0x53]
0066BDBD8  tbnz     w8, #5, #0x66bdbe4
0066BDBDC  ldr      x0, [x22, #0x1e8]
0066BDBE0  b        #0x66bdbf0 ; 
0066BDBE4  ldr      x8, [x1, #0x60]
0066BDBE8  mov      x0, x22
0066BDBEC  blr      x8
0066BDBF0  cbz      x0, #0x66bddc8
0066BDBF4  adrp     x8, #0x8f11000
0066BDBF8  ldr      x8, [x8, #0xb68]
0066BDBFC  ldr      x1, [x8]
0066BDC00  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0066BDC04  adrp     x8, #0x8ee6000
0066BDC08  ldr      x8, [x8, #0x600]
0066BDC0C  mov      x22, x0
0066BDC10  ldr      x1, [x8]
0066BDC14  ldrb     w8, [x1, #0x53]
0066BDC18  tbnz     w8, #5, #0x66bdc24
0066BDC1C  ldr      x23, [x19, #0x38]
0066BDC20  b        #0x66bdc34 ; 
0066BDC24  ldr      x8, [x1, #0x60]
0066BDC28  mov      x0, x19
0066BDC2C  blr      x8
0066BDC30  mov      x23, x0
0066BDC34  cbz      x23, #0x66bddc8
0066BDC38  adrp     x27, #0x9592000
0066BDC3C  ldrb     w8, [x27, #0x473]
0066BDC40  cbnz     w8, #0x66bdc58
0066BDC44  adrp     x0, #0x8ee8000
0066BDC48  ldr      x0, [x0, #0x890]
0066BDC4C  bl       #0x382bd14 ; 
0066BDC50  mov      w8, #1
0066BDC54  strb     w8, [x27, #0x473]
0066BDC58  adrp     x8, #0x8ee8000
0066BDC5C  ldr      x8, [x8, #0x890]
0066BDC60  ldr      x1, [x8]
0066BDC64  ldrb     w8, [x1, #0x53]
0066BDC68  tbnz     w8, #5, #0x66bdc74
0066BDC6C  ldr      x0, [x23, #0x20]
0066BDC70  b        #0x66bdc80 ; 
0066BDC74  ldr      x8, [x1, #0x60]
0066BDC78  mov      x0, x23
0066BDC7C  blr      x8
0066BDC80  cbz      x22, #0x66bddc8
0066BDC84  str      x0, [x22, #0x20]
0066BDC88  adrp     x8, #0x8ee6000
0066BDC8C  ldr      x8, [x8, #0x608]
0066BDC90  ldr      x1, [x8]
0066BDC94  ldrb     w8, [x1, #0x53]
0066BDC98  tbnz     w8, #5, #0x66bdca4
0066BDC9C  ldr      x0, [x19, #0x30]
0066BDCA0  b        #0x66bdcb0 ; 
0066BDCA4  ldr      x8, [x1, #0x60]
0066BDCA8  mov      x0, x19
0066BDCAC  blr      x8
0066BDCB0  cbz      x0, #0x66bddc8
0066BDCB4  mov      x1, xzr
0066BDCB8  bl       #0x67f7788 ; HotFix.BattleLogic.EntityCharacter$$get_IsFrozen
0066BDCBC  and      w8, w0, #1
0066BDCC0  strb     w8, [x22, #0x40]
0066BDCC4  ldr      q0, [x21]
0066BDCC8  ldr      x8, [x21, #0x10]
0066BDCCC  str      w20, [x22, #0x44]
0066BDCD0  stur     q0, [x22, #0x28]
0066BDCD4  str      x8, [x22, #0x38]
0066BDCD8  ldrb     w8, [x25, #0xa4b]
0066BDCDC  cbnz     w8, #0x66bdcf4
0066BDCE0  adrp     x0, #0x8ee5000
0066BDCE4  ldr      x0, [x0, #0xb28]
0066BDCE8  bl       #0x382bd14 ; 
0066BDCEC  mov      w8, #1
0066BDCF0  strb     w8, [x25, #0xa4b]
0066BDCF4  ldr      x1, [x26]
0066BDCF8  ldrb     w8, [x1, #0x53]
0066BDCFC  tbnz     w8, #5, #0x66bdd08
0066BDD00  ldr      x0, [x19, #0x20]
0066BDD04  b        #0x66bdd14 ; 
0066BDD08  ldr      x8, [x1, #0x60]
0066BDD0C  mov      x0, x19
0066BDD10  blr      x8
0066BDD14  cbz      x0, #0x66bddc8
0066BDD18  ldr      x19, [x0, #0x1e0]
0066BDD1C  cbz      x19, #0x66bddc8
0066BDD20  adrp     x9, #0x8f11000
0066BDD24  ldr      x9, [x9, #0xb60]
0066BDD28  ldr      x8, [x19]
0066BDD2C  ldr      x20, [x9]
0066BDD30  ldrh     w9, [x8, #0x12e]
0066BDD34  ldr      x1, [x20, #0x20]
0066BDD38  ldrh     w2, [x20, #0x50]
0066BDD3C  cbz      x9, #0x66bdd60
0066BDD40  ldr      x10, [x8, #0xb0]
0066BDD44  add      x10, x10, #8
0066BDD48  ldur     x11, [x10, #-8]
0066BDD4C  cmp      x11, x1
0066BDD50  b.eq     #0x66bdd6c
0066BDD54  subs     x9, x9, #1
0066BDD58  add      x10, x10, #0x10
0066BDD5C  b.ne     #0x66bdd48
0066BDD60  mov      x0, x19
0066BDD64  bl       #0x3a7e710 ; 
0066BDD68  b        #0x66bdd7c ; 
0066BDD6C  ldr      w9, [x10]
0066BDD70  add      w9, w9, w2
0066BDD74  add      x8, x8, w9, sxtw #4
0066BDD78  add      x0, x8, #0x138
0066BDD7C  ldr      x0, [x0, #8]
0066BDD80  mov      x1, x20
0066BDD84  bl       #0x382be88 ; 
0066BDD88  ldr      x8, [x0, #8]
0066BDD8C  mov      x2, x0
0066BDD90  mov      x0, x19
0066BDD94  mov      x1, x22
0066BDD98  blr      x8
0066BDD9C  ldr      x8, [x24, #0x28]
0066BDDA0  ldr      x9, [sp, #0x18]
0066BDDA4  cmp      x8, x9
0066BDDA8  b.ne     #0x66bddcc
0066BDDAC  ldp      x20, x19, [sp, #0x60]
0066BDDB0  ldp      x22, x21, [sp, #0x50]
0066BDDB4  ldp      x24, x23, [sp, #0x40]
0066BDDB8  ldp      x26, x25, [sp, #0x30]
0066BDDBC  ldp      x30, x27, [sp, #0x20]
0066BDDC0  add      sp, sp, #0x70
0066BDDC4  ret      
0066BDDC8  bl       #0x382bfb8 ; 
0066BDDCC  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$DoSimpleHurt
; RVA 0x66C1EC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C1EC8  sub      sp, sp, #0x90
0066C1ECC  stp      x30, x27, [sp, #0x40]
0066C1ED0  stp      x26, x25, [sp, #0x50]
0066C1ED4  stp      x24, x23, [sp, #0x60]
0066C1ED8  stp      x22, x21, [sp, #0x70]
0066C1EDC  stp      x20, x19, [sp, #0x80]
0066C1EE0  mrs      x25, tpidr_el0
0066C1EE4  ldr      x8, [x25, #0x28]
0066C1EE8  adrp     x26, #0x959a000
0066C1EEC  adrp     x27, #0x8f11000
0066C1EF0  mov      w24, w5
0066C1EF4  str      x8, [sp, #0x38]
0066C1EF8  ldrb     w8, [x26, #0x23c]
0066C1EFC  ldr      x27, [x27, #0xd68]
0066C1F00  mov      x19, x4
0066C1F04  mov      x23, x3
0066C1F08  mov      x20, x2
0066C1F0C  mov      w21, w1
0066C1F10  mov      x22, x0
0066C1F14  tbnz     w8, #0, #0x66c1f2c
0066C1F18  adrp     x0, #0x8f11000
0066C1F1C  ldr      x0, [x0, #0xd68]
0066C1F20  bl       #0x382bd14 ; 
0066C1F24  mov      w8, #1
0066C1F28  strb     w8, [x26, #0x23c]
0066C1F2C  ldr      x6, [x27]
0066C1F30  ldrb     w8, [x6, #0x53]
0066C1F34  tbnz     w8, #5, #0x66c1f98
0066C1F38  mov      x0, x22
0066C1F3C  bl       #0x66b7518 ; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndUpdateHitTime
0066C1F40  tbz      w0, #0, #0x66c1fc8
0066C1F44  tbnz     w24, #0, #0x66c1f58
0066C1F48  mov      x0, x22
0066C1F4C  bl       #0x66bec34 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayerHitAnimation
0066C1F50  mov      x0, x22
0066C1F54  bl       #0x66be8c4 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayVibartion
0066C1F58  mov      x0, x22
0066C1F5C  bl       #0x66be654 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayEntityHitSound
0066C1F60  ldr      x8, [x23, #0x10]
0066C1F64  ldr      q0, [x23]
0066C1F68  mov      x1, sp
0066C1F6C  mov      x0, x22
0066C1F70  mov      w2, w21
0066C1F74  str      x8, [sp, #0x10]
0066C1F78  str      q0, [sp]
0066C1F7C  bl       #0x66bda9c ; HotFix.BattleLogic.CharacterComponentOnHit$$DispatchDamageRenderEvent
0066C1F80  mov      x0, x22
0066C1F84  mov      w1, w21
0066C1F88  mov      x2, x20
0066C1F8C  mov      x3, x19
0066C1F90  bl       #0x66c1ff8 ; HotFix.BattleLogic.CharacterComponentOnHit$$DoSimpleHurt
0066C1F94  b        #0x66c1fc8 ; 
0066C1F98  ldr      x8, [x23, #0x10]
0066C1F9C  ldr      q0, [x23]
0066C1FA0  ldr      x9, [x6, #0x60]
0066C1FA4  and      w5, w24, #1
0066C1FA8  add      x3, sp, #0x20
0066C1FAC  mov      x0, x22
0066C1FB0  mov      w1, w21
0066C1FB4  mov      x2, x20
0066C1FB8  mov      x4, x19
0066C1FBC  str      x8, [sp, #0x30]
0066C1FC0  str      q0, [sp, #0x20]
0066C1FC4  blr      x9
0066C1FC8  ldr      x8, [x25, #0x28]
0066C1FCC  ldr      x9, [sp, #0x38]
0066C1FD0  cmp      x8, x9
0066C1FD4  b.ne     #0x66c1ff4
0066C1FD8  ldp      x20, x19, [sp, #0x80]
0066C1FDC  ldp      x22, x21, [sp, #0x70]
0066C1FE0  ldp      x24, x23, [sp, #0x60]
0066C1FE4  ldp      x26, x25, [sp, #0x50]
0066C1FE8  ldp      x30, x27, [sp, #0x40]
0066C1FEC  add      sp, sp, #0x90
0066C1FF0  ret      
0066C1FF4  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$FixDamage
; RVA 0x66C235C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C235C  stp      x30, x25, [sp, #-0x40]!
0066C2360  stp      x24, x23, [sp, #0x10]
0066C2364  stp      x22, x21, [sp, #0x20]
0066C2368  stp      x20, x19, [sp, #0x30]
0066C236C  adrp     x21, #0x959a000
0066C2370  adrp     x22, #0x8f11000
0066C2374  ldrb     w8, [x21, #0x23d]
0066C2378  ldr      x22, [x22, #0xd80]
0066C237C  mov      x19, x1
0066C2380  mov      x20, x0
0066C2384  tbnz     w8, #0, #0x66c23b4
0066C2388  adrp     x0, #0x8f11000
0066C238C  ldr      x0, [x0, #0xd80]
0066C2390  bl       #0x382bd14 ; 
0066C2394  adrp     x0, #0x8ee6000
0066C2398  ldr      x0, [x0, #0xd8]
0066C239C  bl       #0x382bd14 ; 
0066C23A0  adrp     x0, #0x8ee6000
0066C23A4  ldr      x0, [x0, #0x608]
0066C23A8  bl       #0x382bd14 ; 
0066C23AC  mov      w8, #1
0066C23B0  strb     w8, [x21, #0x23d]
0066C23B4  ldr      x2, [x22]
0066C23B8  ldrb     w8, [x2, #0x53]
0066C23BC  tbnz     w8, #5, #0x66c23dc
0066C23C0  adrp     x23, #0x8ee6000
0066C23C4  ldr      x23, [x23, #0x608]
0066C23C8  ldr      x1, [x23]
0066C23CC  ldrb     w8, [x1, #0x53]
0066C23D0  tbnz     w8, #5, #0x66c23fc
0066C23D4  ldr      x0, [x20, #0x30]
0066C23D8  b        #0x66c2408 ; 
0066C23DC  ldr      x3, [x2, #0x60]
0066C23E0  mov      x0, x20
0066C23E4  mov      x1, x19
0066C23E8  ldp      x20, x19, [sp, #0x30]
0066C23EC  ldp      x22, x21, [sp, #0x20]
0066C23F0  ldp      x24, x23, [sp, #0x10]
0066C23F4  ldp      x30, x25, [sp], #0x40
0066C23F8  br       x3
0066C23FC  ldr      x8, [x1, #0x60]
0066C2400  mov      x0, x20
0066C2404  blr      x8
0066C2408  cbz      x0, #0x66c2550
0066C240C  adrp     x24, #0x8ee6000
0066C2410  ldr      x24, [x24, #0xd8]
0066C2414  ldr      x1, [x24]
0066C2418  ldrb     w8, [x1, #0x53]
0066C241C  tbnz     w8, #5, #0x66c2428
0066C2420  ldr      x21, [x0, #0x38]
0066C2424  b        #0x66c2434 ; 
0066C2428  ldr      x8, [x1, #0x60]
0066C242C  blr      x8
0066C2430  mov      x21, x0
0066C2434  cbz      x21, #0x66c2550
0066C2438  adrp     x22, #0x9591000
0066C243C  ldrb     w8, [x22, #0xa7f]
0066C2440  cbnz     w8, #0x66c2458
0066C2444  adrp     x0, #0x8ee6000
0066C2448  ldr      x0, [x0, #0x2d8]
0066C244C  bl       #0x382bd14 ; 
0066C2450  mov      w8, #1
0066C2454  strb     w8, [x22, #0xa7f]
0066C2458  adrp     x25, #0x8ee6000
0066C245C  ldr      x25, [x25, #0x2d8]
0066C2460  ldr      x1, [x25]
0066C2464  ldrb     w8, [x1, #0x53]
0066C2468  tbnz     w8, #5, #0x66c2474
0066C246C  ldr      x0, [x21, #0x178]
0066C2470  b        #0x66c2480 ; 
0066C2474  ldr      x8, [x1, #0x60]
0066C2478  mov      x0, x21
0066C247C  blr      x8
0066C2480  cbz      x0, #0x66c2550
0066C2484  mov      x1, xzr
0066C2488  bl       #0x6b3db88 ; HotFix.Common.AttributeData$$GetHurtDecrease
0066C248C  ldr      x1, [x23]
0066C2490  mov      x21, x0
0066C2494  ldrb     w8, [x1, #0x53]
0066C2498  tbnz     w8, #5, #0x66c24a4
0066C249C  ldr      x0, [x20, #0x30]
0066C24A0  b        #0x66c24b0 ; 
0066C24A4  ldr      x8, [x1, #0x60]
0066C24A8  mov      x0, x20
0066C24AC  blr      x8
0066C24B0  cbz      x0, #0x66c2550
0066C24B4  ldr      x1, [x24]
0066C24B8  ldrb     w8, [x1, #0x53]
0066C24BC  tbnz     w8, #5, #0x66c24c8
0066C24C0  ldr      x20, [x0, #0x38]
0066C24C4  b        #0x66c24d4 ; 
0066C24C8  ldr      x8, [x1, #0x60]
0066C24CC  blr      x8
0066C24D0  mov      x20, x0
0066C24D4  cbz      x20, #0x66c2550
0066C24D8  ldrb     w8, [x22, #0xa7f]
0066C24DC  cbnz     w8, #0x66c24f4
0066C24E0  adrp     x0, #0x8ee6000
0066C24E4  ldr      x0, [x0, #0x2d8]
0066C24E8  bl       #0x382bd14 ; 
0066C24EC  mov      w8, #1
0066C24F0  strb     w8, [x22, #0xa7f]
0066C24F4  ldr      x1, [x25]
0066C24F8  ldrb     w8, [x1, #0x53]
0066C24FC  tbnz     w8, #5, #0x66c2508
0066C2500  ldr      x0, [x20, #0x178]
0066C2504  b        #0x66c2514 ; 
0066C2508  ldr      x8, [x1, #0x60]
0066C250C  mov      x0, x20
0066C2510  blr      x8
0066C2514  cbz      x0, #0x66c2550
0066C2518  mov      x1, xzr
0066C251C  sub      x19, x19, x21
0066C2520  bl       #0x6b3dc04 ; HotFix.Common.AttributeData$$GetHurtDecreasePercent
0066C2524  mul      x8, x0, x19
0066C2528  ldp      x20, x19, [sp, #0x30]
0066C252C  ldp      x22, x21, [sp, #0x20]
0066C2530  ldp      x24, x23, [sp, #0x10]
0066C2534  asr      x8, x8, #0x10
0066C2538  cmp      x8, #0x10, lsl #12
0066C253C  mov      w9, #0x10000
0066C2540  csel     x0, x8, x9, gt
0066C2544  mov      x1, xzr
0066C2548  ldp      x30, x25, [sp], #0x40
0066C254C  b        #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
0066C2550  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$DoSimpleHurt
; RVA 0x66C1FF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C1FF8  sub      sp, sp, #0xb0
0066C1FFC  stp      x30, x27, [sp, #0x60]
0066C2000  stp      x26, x25, [sp, #0x70]
0066C2004  stp      x24, x23, [sp, #0x80]
0066C2008  stp      x22, x21, [sp, #0x90]
0066C200C  stp      x20, x19, [sp, #0xa0]
0066C2010  mrs      x24, tpidr_el0
0066C2014  ldr      x8, [x24, #0x28]
0066C2018  adrp     x21, #0x959a000
0066C201C  adrp     x25, #0x8f11000
0066C2020  mov      x22, x3
0066C2024  str      x8, [sp, #0x58]
0066C2028  ldrb     w8, [x21, #0x23e]
0066C202C  ldr      x25, [x25, #0xd70]
0066C2030  mov      x20, x2
0066C2034  mov      w23, w1
0066C2038  mov      x19, x0
0066C203C  tbnz     w8, #0, #0x66c2084
0066C2040  adrp     x0, #0x8f11000
0066C2044  ldr      x0, [x0, #0xd70]
0066C2048  bl       #0x382bd14 ; 
0066C204C  adrp     x0, #0x8ee6000
0066C2050  ldr      x0, [x0, #0xd8]
0066C2054  bl       #0x382bd14 ; 
0066C2058  adrp     x0, #0x8ee6000
0066C205C  ldr      x0, [x0, #0xe8]
0066C2060  bl       #0x382bd14 ; 
0066C2064  adrp     x0, #0x8ee6000
0066C2068  ldr      x0, [x0, #0x608]
0066C206C  bl       #0x382bd14 ; 
0066C2070  adrp     x0, #0x8f11000
0066C2074  ldr      x0, [x0, #0xd78]
0066C2078  bl       #0x382bd14 ; 
0066C207C  mov      w8, #1
0066C2080  strb     w8, [x21, #0x23e]
0066C2084  ldr      x4, [x25]
0066C2088  ldrb     w8, [x4, #0x53]
0066C208C  tbnz     w8, #5, #0x66c20dc
0066C2090  mov      x0, x19
0066C2094  mov      x1, x20
0066C2098  bl       #0x66c235c ; HotFix.BattleLogic.CharacterComponentOnHit$$FixDamage
0066C209C  adrp     x25, #0x9591000
0066C20A0  ldrb     w8, [x25, #0xa4b]
0066C20A4  mov      w21, w0
0066C20A8  cbnz     w8, #0x66c20c0
0066C20AC  adrp     x0, #0x8ee5000
0066C20B0  ldr      x0, [x0, #0xb28]
0066C20B4  bl       #0x382bd14 ; 
0066C20B8  mov      w8, #1
0066C20BC  strb     w8, [x25, #0xa4b]
0066C20C0  adrp     x26, #0x8ee5000
0066C20C4  ldr      x26, [x26, #0xb28]
0066C20C8  ldr      x1, [x26]
0066C20CC  ldrb     w8, [x1, #0x53]
0066C20D0  tbnz     w8, #5, #0x66c20f8
0066C20D4  ldr      x20, [x19, #0x20]
0066C20D8  b        #0x66c2108 ; 
0066C20DC  ldr      x8, [x4, #0x60]
0066C20E0  mov      x0, x19
0066C20E4  mov      w1, w23
0066C20E8  mov      x2, x20
0066C20EC  mov      x3, x22
0066C20F0  blr      x8
0066C20F4  b        #0x66c2328 ; 
0066C20F8  ldr      x8, [x1, #0x60]
0066C20FC  mov      x0, x19
0066C2100  blr      x8
0066C2104  mov      x20, x0
0066C2108  cbz      x20, #0x66c2354
0066C210C  adrp     x27, #0x9591000
0066C2110  ldrb     w8, [x27, #0xa4c]
0066C2114  cbnz     w8, #0x66c212c
0066C2118  adrp     x0, #0x8ee5000
0066C211C  ldr      x0, [x0, #0xb30]
0066C2120  bl       #0x382bd14 ; 
0066C2124  mov      w8, #1
0066C2128  strb     w8, [x27, #0xa4c]
0066C212C  adrp     x8, #0x8ee5000
0066C2130  ldr      x8, [x8, #0xb30]
0066C2134  ldr      x1, [x8]
0066C2138  ldrb     w8, [x1, #0x53]
0066C213C  tbnz     w8, #5, #0x66c2148
0066C2140  ldr      x0, [x20, #0x210]
0066C2144  b        #0x66c2154 ; 
0066C2148  ldr      x8, [x1, #0x60]
0066C214C  mov      x0, x20
0066C2150  blr      x8
0066C2154  cbz      x0, #0x66c2354
0066C2158  adrp     x8, #0x8f11000
0066C215C  ldr      x8, [x8, #0xd78]
0066C2160  ldr      x1, [x8]
0066C2164  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C2168  mov      x20, x0
0066C216C  mov      x0, xzr
0066C2170  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
0066C2174  stp      xzr, xzr, [sp, #0x40]
0066C2178  str      xzr, [sp, #0x50]
0066C217C  cbz      x20, #0x66c2354
0066C2180  ldr      q0, [sp, #0x40]
0066C2184  ldr      x8, [sp, #0x50]
0066C2188  neg      w21, w21
0066C218C  mov      x4, x0
0066C2190  add      x7, sp, #0x20
0066C2194  mov      w6, #1
0066C2198  mov      x0, x20
0066C219C  mov      w1, w23
0066C21A0  mov      w2, w21
0066C21A4  mov      x3, x22
0066C21A8  mov      w5, wzr
0066C21AC  str      q0, [sp, #0x20]
0066C21B0  str      x8, [sp, #0x30]
0066C21B4  str      xzr, [sp, #0x10]
0066C21B8  str      wzr, [sp, #8]
0066C21BC  str      xzr, [sp]
0066C21C0  bl       #0x682fa78 ; HotFix.BattleLogic.TakeDamageData$$Init
0066C21C4  adrp     x27, #0x8ee6000
0066C21C8  ldr      x27, [x27, #0x608]
0066C21CC  ldr      x1, [x27]
0066C21D0  ldrb     w8, [x1, #0x53]
0066C21D4  tbnz     w8, #5, #0x66c21e0
0066C21D8  ldr      x0, [x19, #0x30]
0066C21DC  b        #0x66c21ec ; 
0066C21E0  ldr      x8, [x1, #0x60]
0066C21E4  mov      x0, x19
0066C21E8  blr      x8
0066C21EC  cbz      x0, #0x66c2354
0066C21F0  ldr      x8, [x0]
0066C21F4  mov      x1, x20
0066C21F8  ldr      x9, [x8, #0x3b8]
0066C21FC  ldr      x2, [x8, #0x3c0]
0066C2200  blr      x9
0066C2204  ldr      x1, [x27]
0066C2208  ldrb     w8, [x1, #0x53]
0066C220C  tbnz     w8, #5, #0x66c2218
0066C2210  ldr      x0, [x19, #0x30]
0066C2214  b        #0x66c2224 ; 
0066C2218  ldr      x8, [x1, #0x60]
0066C221C  mov      x0, x19
0066C2220  blr      x8
0066C2224  cbz      x0, #0x66c2354
0066C2228  adrp     x8, #0x8ee6000
0066C222C  ldr      x8, [x8, #0xd8]
0066C2230  ldr      x1, [x8]
0066C2234  ldrb     w8, [x1, #0x53]
0066C2238  tbnz     w8, #5, #0x66c2244
0066C223C  ldr      x0, [x0, #0x38]
0066C2240  b        #0x66c224c ; 
0066C2244  ldr      x8, [x1, #0x60]
0066C2248  blr      x8
0066C224C  cbz      x0, #0x66c2354
0066C2250  mov      x1, xzr
0066C2254  bl       #0x45616a8 ; 
0066C2258  ldrb     w8, [x25, #0xa4b]
0066C225C  tst      w0, #1
0066C2260  mov      w9, #0xe
0066C2264  csinc    w22, w9, wzr, ne
0066C2268  cbnz     w8, #0x66c2280
0066C226C  adrp     x0, #0x8ee5000
0066C2270  ldr      x0, [x0, #0xb28]
0066C2274  bl       #0x382bd14 ; 
0066C2278  mov      w8, #1
0066C227C  strb     w8, [x25, #0xa4b]
0066C2280  ldr      x1, [x26]
0066C2284  ldrb     w8, [x1, #0x53]
0066C2288  tbnz     w8, #5, #0x66c2294
0066C228C  ldr      x23, [x19, #0x20]
0066C2290  b        #0x66c22a4 ; 
0066C2294  ldr      x8, [x1, #0x60]
0066C2298  mov      x0, x19
0066C229C  blr      x8
0066C22A0  mov      x23, x0
0066C22A4  ldr      x1, [x27]
0066C22A8  ldrb     w8, [x1, #0x53]
0066C22AC  tbnz     w8, #5, #0x66c22b8
0066C22B0  ldr      x0, [x19, #0x30]
0066C22B4  b        #0x66c22c4 ; 
0066C22B8  ldr      x8, [x1, #0x60]
0066C22BC  mov      x0, x19
0066C22C0  blr      x8
0066C22C4  cbz      x0, #0x66c2354
0066C22C8  adrp     x8, #0x8ee6000
0066C22CC  ldr      x8, [x8, #0xe8]
0066C22D0  ldr      x1, [x8]
0066C22D4  ldrb     w8, [x1, #0x53]
0066C22D8  tbnz     w8, #5, #0x66c22e4
0066C22DC  ldr      x3, [x0, #0x28]
0066C22E0  b        #0x66c22f0 ; 
0066C22E4  ldr      x8, [x1, #0x60]
0066C22E8  blr      x8
0066C22EC  mov      x3, x0
0066C22F0  cbz      x23, #0x66c2354
0066C22F4  mov      w4, #0x10000
0066C22F8  mov      x0, x23
0066C22FC  mov      w1, w22
0066C2300  mov      w2, w21
0066C2304  mov      w5, wzr
0066C2308  mov      w6, wzr
0066C230C  mov      x7, xzr
0066C2310  str      xzr, [sp, #8]
0066C2314  str      wzr, [sp]
0066C2318  bl       #0x6a0ed24 ; HotFix.BattleLogic.BattleWorldContext$$ShowHoverEvent
0066C231C  mov      x0, x20
0066C2320  mov      x1, xzr
0066C2324  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066C2328  ldr      x8, [x24, #0x28]
0066C232C  ldr      x9, [sp, #0x58]
0066C2330  cmp      x8, x9
0066C2334  b.ne     #0x66c2358
0066C2338  ldp      x20, x19, [sp, #0xa0]
0066C233C  ldp      x22, x21, [sp, #0x90]
0066C2340  ldp      x24, x23, [sp, #0x80]
0066C2344  ldp      x26, x25, [sp, #0x70]
0066C2348  ldp      x30, x27, [sp, #0x60]
0066C234C  add      sp, sp, #0xb0
0066C2350  ret      
0066C2354  bl       #0x382bfb8 ; 
0066C2358  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$PlayerHitAnimation
; RVA 0x66BEC34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BEC34  str      x30, [sp, #-0x30]!
0066BEC38  stp      x22, x21, [sp, #0x10]
0066BEC3C  stp      x20, x19, [sp, #0x20]
0066BEC40  adrp     x20, #0x959a000
0066BEC44  adrp     x21, #0x8f11000
0066BEC48  ldrb     w8, [x20, #0x23f]
0066BEC4C  ldr      x21, [x21, #0xbd8]
0066BEC50  mov      x19, x0
0066BEC54  tbnz     w8, #0, #0x66bec90
0066BEC58  adrp     x0, #0x8f11000
0066BEC5C  ldr      x0, [x0, #0xbd8]
0066BEC60  bl       #0x382bd14 ; 
0066BEC64  adrp     x0, #0x8ee6000
0066BEC68  ldr      x0, [x0, #0x600]
0066BEC6C  bl       #0x382bd14 ; 
0066BEC70  adrp     x0, #0x8ee6000
0066BEC74  ldr      x0, [x0, #0x608]
0066BEC78  bl       #0x382bd14 ; 
0066BEC7C  adrp     x0, #0x8f11000
0066BEC80  ldr      x0, [x0, #0xbe0]
0066BEC84  bl       #0x382bd14 ; 
0066BEC88  mov      w8, #1
0066BEC8C  strb     w8, [x20, #0x23f]
0066BEC90  ldr      x1, [x21]
0066BEC94  ldrb     w8, [x1, #0x53]
0066BEC98  tbnz     w8, #5, #0x66becb8
0066BEC9C  adrp     x21, #0x8ee6000
0066BECA0  ldr      x21, [x21, #0x608]
0066BECA4  ldr      x1, [x21]
0066BECA8  ldrb     w8, [x1, #0x53]
0066BECAC  tbnz     w8, #5, #0x66becd0
0066BECB0  ldr      x0, [x19, #0x30]
0066BECB4  b        #0x66becdc ; 
0066BECB8  ldr      x2, [x1, #0x60]
0066BECBC  mov      x0, x19
0066BECC0  ldp      x20, x19, [sp, #0x20]
0066BECC4  ldp      x22, x21, [sp, #0x10]
0066BECC8  ldr      x30, [sp], #0x30
0066BECCC  br       x2
0066BECD0  ldr      x8, [x1, #0x60]
0066BECD4  mov      x0, x19
0066BECD8  blr      x8
0066BECDC  cbz      x0, #0x66bef1c
0066BECE0  mov      x1, xzr
0066BECE4  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0066BECE8  tbnz     w0, #0, #0x66bed54
0066BECEC  ldr      x1, [x21]
0066BECF0  ldrb     w8, [x1, #0x53]
0066BECF4  tbnz     w8, #5, #0x66bed00
0066BECF8  ldr      x0, [x19, #0x30]
0066BECFC  b        #0x66bed0c ; 
0066BED00  ldr      x8, [x1, #0x60]
0066BED04  mov      x0, x19
0066BED08  blr      x8
0066BED0C  cbz      x0, #0x66bef1c
0066BED10  mov      x1, xzr
0066BED14  bl       #0x67f7788 ; HotFix.BattleLogic.EntityCharacter$$get_IsFrozen
0066BED18  tbnz     w0, #0, #0x66bed54
0066BED1C  adrp     x20, #0x8ee6000
0066BED20  ldr      x20, [x20, #0x600]
0066BED24  ldr      x1, [x20]
0066BED28  ldrb     w8, [x1, #0x53]
0066BED2C  tbnz     w8, #5, #0x66bed38
0066BED30  ldr      x0, [x19, #0x38]
0066BED34  b        #0x66bed44 ; 
0066BED38  ldr      x8, [x1, #0x60]
0066BED3C  mov      x0, x19
0066BED40  blr      x8
0066BED44  cbz      x0, #0x66bef1c
0066BED48  mov      x1, xzr
0066BED4C  bl       #0x45616a8 ; 
0066BED50  tbz      w0, #0, #0x66bed64
0066BED54  ldp      x20, x19, [sp, #0x20]
0066BED58  ldp      x22, x21, [sp, #0x10]
0066BED5C  ldr      x30, [sp], #0x30
0066BED60  ret      
0066BED64  ldr      x1, [x20]
0066BED68  ldrb     w8, [x1, #0x53]
0066BED6C  tbnz     w8, #5, #0x66bed78
0066BED70  ldr      x20, [x19, #0x38]
0066BED74  b        #0x66bed88 ; 
0066BED78  ldr      x8, [x1, #0x60]
0066BED7C  mov      x0, x19
0066BED80  blr      x8
0066BED84  mov      x20, x0
0066BED88  cbz      x20, #0x66bef1c
0066BED8C  adrp     x22, #0x9599000
0066BED90  ldrb     w8, [x22, #0xece]
0066BED94  cbnz     w8, #0x66bedac
0066BED98  adrp     x0, #0x8f0f000
0066BED9C  ldr      x0, [x0, #0x600]
0066BEDA0  bl       #0x382bd14 ; 
0066BEDA4  mov      w8, #1
0066BEDA8  strb     w8, [x22, #0xece]
0066BEDAC  adrp     x8, #0x8f0f000
0066BEDB0  ldr      x8, [x8, #0x600]
0066BEDB4  ldr      x1, [x8]
0066BEDB8  ldrb     w8, [x1, #0x53]
0066BEDBC  tbnz     w8, #5, #0x66bee30
0066BEDC0  adrp     x22, #0x9591000
0066BEDC4  ldrb     w8, [x22, #0xa73]
0066BEDC8  cbnz     w8, #0x66bede0
0066BEDCC  adrp     x0, #0x8ee6000
0066BEDD0  ldr      x0, [x0, #0x280]
0066BEDD4  bl       #0x382bd14 ; 
0066BEDD8  mov      w8, #1
0066BEDDC  strb     w8, [x22, #0xa73]
0066BEDE0  adrp     x8, #0x8ee6000
0066BEDE4  ldr      x8, [x8, #0x280]
0066BEDE8  ldr      x1, [x8]
0066BEDEC  ldrb     w8, [x1, #0x53]
0066BEDF0  tbnz     w8, #5, #0x66bee94
0066BEDF4  adrp     x22, #0x9591000
0066BEDF8  ldrb     w8, [x22, #0xa74]
0066BEDFC  cbnz     w8, #0x66bee14
0066BEE00  adrp     x0, #0x8ee6000
0066BEE04  ldr      x0, [x0, #0x288]
0066BEE08  bl       #0x382bd14 ; 
0066BEE0C  mov      w8, #1
0066BEE10  strb     w8, [x22, #0xa74]
0066BEE14  adrp     x8, #0x8ee6000
0066BEE18  ldr      x8, [x8, #0x288]
0066BEE1C  ldr      x1, [x8]
0066BEE20  ldrb     w8, [x1, #0x53]
0066BEE24  tbnz     w8, #5, #0x66bee44
0066BEE28  ldr      x20, [x20, #0x170]
0066BEE2C  b        #0x66bee54 ; 
0066BEE30  ldr      x8, [x1, #0x60]
0066BEE34  mov      x0, x20
0066BEE38  blr      x8
0066BEE3C  tbnz     w0, #0, #0x66bed54
0066BEE40  b        #0x66beea8 ; 
0066BEE44  ldr      x8, [x1, #0x60]
0066BEE48  mov      x0, x20
0066BEE4C  blr      x8
0066BEE50  mov      x20, x0
0066BEE54  cbz      x20, #0x66bef1c
0066BEE58  adrp     x22, #0x9591000
0066BEE5C  ldrb     w8, [x22, #0xa75]
0066BEE60  cbnz     w8, #0x66bee78
0066BEE64  adrp     x0, #0x8ee6000
0066BEE68  ldr      x0, [x0, #0x290]
0066BEE6C  bl       #0x382bd14 ; 
0066BEE70  mov      w8, #1
0066BEE74  strb     w8, [x22, #0xa75]
0066BEE78  adrp     x8, #0x8ee6000
0066BEE7C  ldr      x8, [x8, #0x290]
0066BEE80  ldr      x1, [x8]
0066BEE84  ldrb     w8, [x1, #0x53]
0066BEE88  tbnz     w8, #5, #0x66bee94
0066BEE8C  ldr      w0, [x20, #0x24]
0066BEE90  b        #0x66beea0 ; 
0066BEE94  ldr      x8, [x1, #0x60]
0066BEE98  mov      x0, x20
0066BEE9C  blr      x8
0066BEEA0  cmp      w0, #3
0066BEEA4  b.eq     #0x66bed54
0066BEEA8  ldr      x1, [x21]
0066BEEAC  ldrb     w8, [x1, #0x53]
0066BEEB0  tbnz     w8, #5, #0x66beebc
0066BEEB4  ldr      x0, [x19, #0x30]
0066BEEB8  b        #0x66beec8 ; 
0066BEEBC  ldr      x8, [x1, #0x60]
0066BEEC0  mov      x0, x19
0066BEEC4  blr      x8
0066BEEC8  cbz      x0, #0x66bef1c
0066BEECC  mov      x1, xzr
0066BEED0  bl       #0x67f7b54 ; HotFix.BattleLogic.EntityCharacter$$get_IsPara
0066BEED4  tbnz     w0, #0, #0x66bed54
0066BEED8  ldr      x1, [x21]
0066BEEDC  ldrb     w8, [x1, #0x53]
0066BEEE0  tbnz     w8, #5, #0x66beeec
0066BEEE4  ldr      x0, [x19, #0x30]
0066BEEE8  b        #0x66beef8 ; 
0066BEEEC  ldr      x8, [x1, #0x60]
0066BEEF0  mov      x0, x19
0066BEEF4  blr      x8
0066BEEF8  cbz      x0, #0x66bef1c
0066BEEFC  adrp     x8, #0x8f11000
0066BEF00  ldr      x8, [x8, #0xbe0]
0066BEF04  ldp      x20, x19, [sp, #0x20]
0066BEF08  ldp      x22, x21, [sp, #0x10]
0066BEF0C  mov      x2, xzr
0066BEF10  ldr      x1, [x8]
0066BEF14  ldr      x30, [sp], #0x30
0066BEF18  b        #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
0066BEF1C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$dispatchHittedTriggerEvent
; RVA 0x66B7188; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B7188  sub      sp, sp, #0x80
0066B718C  stp      x30, x25, [sp, #0x40]
0066B7190  stp      x24, x23, [sp, #0x50]
0066B7194  stp      x22, x21, [sp, #0x60]
0066B7198  stp      x20, x19, [sp, #0x70]
0066B719C  mrs      x23, tpidr_el0
0066B71A0  ldr      x8, [x23, #0x28]
0066B71A4  adrp     x20, #0x959a000
0066B71A8  adrp     x22, #0x8f11000
0066B71AC  mov      w21, w1
0066B71B0  str      x8, [sp, #0x38]
0066B71B4  ldrb     w8, [x20, #0x240]
0066B71B8  ldr      x22, [x22, #0x928]
0066B71BC  mov      x19, x0
0066B71C0  tbnz     w8, #0, #0x66b7208
0066B71C4  adrp     x0, #0x8f11000
0066B71C8  ldr      x0, [x0, #0x928]
0066B71CC  bl       #0x382bd14 ; 
0066B71D0  adrp     x0, #0x8ee6000
0066B71D4  ldr      x0, [x0, #0xd8]
0066B71D8  bl       #0x382bd14 ; 
0066B71DC  adrp     x0, #0x8ee6000
0066B71E0  ldr      x0, [x0, #0x600]
0066B71E4  bl       #0x382bd14 ; 
0066B71E8  adrp     x0, #0x8ee6000
0066B71EC  ldr      x0, [x0, #0x608]
0066B71F0  bl       #0x382bd14 ; 
0066B71F4  adrp     x0, #0x8f11000
0066B71F8  ldr      x0, [x0, #0x930]
0066B71FC  bl       #0x382bd14 ; 
0066B7200  mov      w8, #1
0066B7204  strb     w8, [x20, #0x240]
0066B7208  ldr      x2, [x22]
0066B720C  ldrb     w8, [x2, #0x53]
0066B7210  tbnz     w8, #5, #0x66b7250
0066B7214  adrp     x20, #0x9591000
0066B7218  ldrb     w8, [x20, #0xa4b]
0066B721C  cbnz     w8, #0x66b7234
0066B7220  adrp     x0, #0x8ee5000
0066B7224  ldr      x0, [x0, #0xb28]
0066B7228  bl       #0x382bd14 ; 
0066B722C  mov      w8, #1
0066B7230  strb     w8, [x20, #0xa4b]
0066B7234  adrp     x8, #0x8ee5000
0066B7238  ldr      x8, [x8, #0xb28]
0066B723C  ldr      x1, [x8]
0066B7240  ldrb     w8, [x1, #0x53]
0066B7244  tbnz     w8, #5, #0x66b7264
0066B7248  ldr      x20, [x19, #0x20]
0066B724C  b        #0x66b7274 ; 
0066B7250  ldr      x8, [x2, #0x60]
0066B7254  mov      x0, x19
0066B7258  mov      w1, w21
0066B725C  blr      x8
0066B7260  b        #0x66b74e8 ; 
0066B7264  ldr      x8, [x1, #0x60]
0066B7268  mov      x0, x19
0066B726C  blr      x8
0066B7270  mov      x20, x0
0066B7274  cbz      x20, #0x66b7510
0066B7278  adrp     x22, #0x9591000
0066B727C  ldrb     w8, [x22, #0xa4c]
0066B7280  cbnz     w8, #0x66b7298
0066B7284  adrp     x0, #0x8ee5000
0066B7288  ldr      x0, [x0, #0xb30]
0066B728C  bl       #0x382bd14 ; 
0066B7290  mov      w8, #1
0066B7294  strb     w8, [x22, #0xa4c]
0066B7298  adrp     x8, #0x8ee5000
0066B729C  ldr      x8, [x8, #0xb30]
0066B72A0  ldr      x1, [x8]
0066B72A4  ldrb     w8, [x1, #0x53]
0066B72A8  tbnz     w8, #5, #0x66b72b4
0066B72AC  ldr      x0, [x20, #0x210]
0066B72B0  b        #0x66b72c0 ; 
0066B72B4  ldr      x8, [x1, #0x60]
0066B72B8  mov      x0, x20
0066B72BC  blr      x8
0066B72C0  cbz      x0, #0x66b7510
0066B72C4  adrp     x8, #0x8f11000
0066B72C8  ldr      x8, [x8, #0x930]
0066B72CC  ldr      x1, [x8]
0066B72D0  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066B72D4  adrp     x24, #0x8ee6000
0066B72D8  ldr      x24, [x24, #0x600]
0066B72DC  mov      x20, x0
0066B72E0  ldr      x1, [x24]
0066B72E4  ldrb     w8, [x1, #0x53]
0066B72E8  tbnz     w8, #5, #0x66b72f4
0066B72EC  ldr      x22, [x19, #0x38]
0066B72F0  b        #0x66b7304 ; 
0066B72F4  ldr      x8, [x1, #0x60]
0066B72F8  mov      x0, x19
0066B72FC  blr      x8
0066B7300  mov      x22, x0
0066B7304  cbz      x22, #0x66b7510
0066B7308  adrp     x25, #0x9592000
0066B730C  ldrb     w8, [x25, #0x473]
0066B7310  cbnz     w8, #0x66b7328
0066B7314  adrp     x0, #0x8ee8000
0066B7318  ldr      x0, [x0, #0x890]
0066B731C  bl       #0x382bd14 ; 
0066B7320  mov      w8, #1
0066B7324  strb     w8, [x25, #0x473]
0066B7328  adrp     x8, #0x8ee8000
0066B732C  ldr      x8, [x8, #0x890]
0066B7330  ldr      x1, [x8]
0066B7334  ldrb     w8, [x1, #0x53]
0066B7338  tbnz     w8, #5, #0x66b7344
0066B733C  ldr      x0, [x22, #0x20]
0066B7340  b        #0x66b7350 ; 
0066B7344  ldr      x8, [x1, #0x60]
0066B7348  mov      x0, x22
0066B734C  blr      x8
0066B7350  cbz      x20, #0x66b7510
0066B7354  str      x0, [x20, #0x48]
0066B7358  ldr      x1, [x24]
0066B735C  ldrb     w8, [x1, #0x53]
0066B7360  tbnz     w8, #5, #0x66b736c
0066B7364  ldr      x0, [x19, #0x38]
0066B7368  b        #0x66b7378 ; 
0066B736C  ldr      x8, [x1, #0x60]
0066B7370  mov      x0, x19
0066B7374  blr      x8
0066B7378  cbz      x0, #0x66b7510
0066B737C  add      x8, sp, #8
0066B7380  mov      x1, xzr
0066B7384  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066B7388  ldr      x8, [sp, #0x18]
0066B738C  ldur     q0, [sp, #8]
0066B7390  adrp     x22, #0x8ee6000
0066B7394  str      x8, [sp, #0x30]
0066B7398  str      q0, [sp, #0x20]
0066B739C  str      x8, [x20, #0x30]
0066B73A0  str      q0, [x20, #0x20]
0066B73A4  str      w21, [x20, #0x50]
0066B73A8  ldr      x22, [x22, #0x608]
0066B73AC  ldr      x1, [x22]
0066B73B0  ldrb     w8, [x1, #0x53]
0066B73B4  tbnz     w8, #5, #0x66b73c0
0066B73B8  ldr      x21, [x19, #0x30]
0066B73BC  b        #0x66b73d0 ; 
0066B73C0  ldr      x8, [x1, #0x60]
0066B73C4  mov      x0, x19
0066B73C8  blr      x8
0066B73CC  mov      x21, x0
0066B73D0  cbz      x21, #0x66b7510
0066B73D4  adrp     x24, #0x9591000
0066B73D8  ldrb     w8, [x24, #0xa86]
0066B73DC  cbnz     w8, #0x66b7400
0066B73E0  adrp     x0, #0x8ee6000
0066B73E4  ldr      x0, [x0, #0x318]
0066B73E8  bl       #0x382bd14 ; 
0066B73EC  adrp     x0, #0x8ee3000
0066B73F0  ldr      x0, [x0, #0xf18]
0066B73F4  bl       #0x382bd14 ; 
0066B73F8  mov      w8, #1
0066B73FC  strb     w8, [x24, #0xa86]
0066B7400  adrp     x8, #0x8ee6000
0066B7404  ldr      x8, [x8, #0x318]
0066B7408  ldr      x2, [x8]
0066B740C  ldrb     w8, [x2, #0x53]
0066B7410  tbnz     w8, #5, #0x66b7438
0066B7414  ldr      x0, [x21, #0x190]
0066B7418  cbz      x0, #0x66b7484
0066B741C  adrp     x8, #0x8ee3000
0066B7420  ldr      x8, [x8, #0xf18]
0066B7424  mov      w1, #0x13
0066B7428  ldr      x2, [x8]
0066B742C  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066B7430  tbnz     w0, #0, #0x66b744c
0066B7434  b        #0x66b7484 ; 
0066B7438  ldr      x8, [x2, #0x60]
0066B743C  mov      w1, #0x13
0066B7440  mov      x0, x21
0066B7444  blr      x8
0066B7448  tbz      w0, #0, #0x66b7484
0066B744C  ldr      x1, [x22]
0066B7450  ldrb     w8, [x1, #0x53]
0066B7454  tbnz     w8, #5, #0x66b7460
0066B7458  ldr      x0, [x19, #0x30]
0066B745C  b        #0x66b746c ; 
0066B7460  ldr      x8, [x1, #0x60]
0066B7464  mov      x0, x19
0066B7468  blr      x8
0066B746C  cbz      x0, #0x66b7510
0066B7470  ldr      x0, [x0, #0x150]
0066B7474  cbz      x0, #0x66b7510
0066B7478  mov      x1, x20
0066B747C  mov      x2, xzr
0066B7480  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066B7484  ldr      x1, [x22]
0066B7488  ldrb     w8, [x1, #0x53]
0066B748C  tbnz     w8, #5, #0x66b7498
0066B7490  ldr      x0, [x19, #0x30]
0066B7494  b        #0x66b74a4 ; 
0066B7498  ldr      x8, [x1, #0x60]
0066B749C  mov      x0, x19
0066B74A0  blr      x8
0066B74A4  cbz      x0, #0x66b7510
0066B74A8  adrp     x8, #0x8ee6000
0066B74AC  ldr      x8, [x8, #0xd8]
0066B74B0  ldr      x1, [x8]
0066B74B4  ldrb     w8, [x1, #0x53]
0066B74B8  tbnz     w8, #5, #0x66b74c4
0066B74BC  ldr      x0, [x0, #0x38]
0066B74C0  b        #0x66b74cc ; 
0066B74C4  ldr      x8, [x1, #0x60]
0066B74C8  blr      x8
0066B74CC  cbz      x0, #0x66b7510
0066B74D0  mov      x1, xzr
0066B74D4  bl       #0x45616a8 ; 
0066B74D8  tbz      w0, #0, #0x66b74e8
0066B74DC  mov      x0, x19
0066B74E0  mov      x1, x20
0066B74E4  bl       #0x66c2554 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroHitted
0066B74E8  ldr      x8, [x23, #0x28]
0066B74EC  ldr      x9, [sp, #0x38]
0066B74F0  cmp      x8, x9
0066B74F4  b.ne     #0x66b7514
0066B74F8  ldp      x20, x19, [sp, #0x70]
0066B74FC  ldp      x22, x21, [sp, #0x60]
0066B7500  ldp      x24, x23, [sp, #0x50]
0066B7504  ldp      x30, x25, [sp, #0x40]
0066B7508  add      sp, sp, #0x80
0066B750C  ret      
0066B7510  bl       #0x382bfb8 ; 
0066B7514  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$BuildHurtDataArray
; RVA 0x66B8C7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B8C7C  sub      sp, sp, #0x80
0066B8C80  stp      x30, x23, [sp, #0x50]
0066B8C84  stp      x22, x21, [sp, #0x60]
0066B8C88  stp      x20, x19, [sp, #0x70]
0066B8C8C  adrp     x22, #0x959a000
0066B8C90  adrp     x23, #0x8f11000
0066B8C94  ldrb     w8, [x22, #0x241]
0066B8C98  ldr      x23, [x23, #0x9e8]
0066B8C9C  mov      x21, x2
0066B8CA0  mov      x19, x1
0066B8CA4  mov      x20, x0
0066B8CA8  tbnz     w8, #0, #0x66b8cc0
0066B8CAC  adrp     x0, #0x8f11000
0066B8CB0  ldr      x0, [x0, #0x9e8]
0066B8CB4  bl       #0x382bd14 ; 
0066B8CB8  mov      w8, #1
0066B8CBC  strb     w8, [x22, #0x241]
0066B8CC0  ldr      x3, [x23]
0066B8CC4  ldrb     w8, [x3, #0x53]
0066B8CC8  tbnz     w8, #5, #0x66b8d08
0066B8CCC  adrp     x21, #0x9591000
0066B8CD0  ldrb     w8, [x21, #0xa4b]
0066B8CD4  cbnz     w8, #0x66b8cec
0066B8CD8  adrp     x0, #0x8ee5000
0066B8CDC  ldr      x0, [x0, #0xb28]
0066B8CE0  bl       #0x382bd14 ; 
0066B8CE4  mov      w8, #1
0066B8CE8  strb     w8, [x21, #0xa4b]
0066B8CEC  adrp     x8, #0x8ee5000
0066B8CF0  ldr      x8, [x8, #0xb28]
0066B8CF4  ldr      x1, [x8]
0066B8CF8  ldrb     w8, [x1, #0x53]
0066B8CFC  tbnz     w8, #5, #0x66b8d2c
0066B8D00  ldr      x0, [x20, #0x20]
0066B8D04  b        #0x66b8d38 ; 
0066B8D08  ldr      x4, [x3, #0x60]
0066B8D0C  mov      x0, x20
0066B8D10  mov      x1, x19
0066B8D14  mov      x2, x21
0066B8D18  ldp      x20, x19, [sp, #0x70]
0066B8D1C  ldp      x22, x21, [sp, #0x60]
0066B8D20  ldp      x30, x23, [sp, #0x50]
0066B8D24  add      sp, sp, #0x80
0066B8D28  br       x4
0066B8D2C  ldr      x8, [x1, #0x60]
0066B8D30  mov      x0, x20
0066B8D34  blr      x8
0066B8D38  cbz      x0, #0x66b8ea4
0066B8D3C  mov      x1, xzr
0066B8D40  bl       #0x69fa994 ; HotFix.BattleLogic.BattleWorldContext$$GetHurtDataArray
0066B8D44  cbz      x19, #0x66b8ea4
0066B8D48  adrp     x21, #0x959a000
0066B8D4C  ldrb     w8, [x21, #0x279]
0066B8D50  mov      x20, x0
0066B8D54  cbnz     w8, #0x66b8d6c
0066B8D58  adrp     x0, #0x8f11000
0066B8D5C  ldr      x0, [x0, #0x9f0]
0066B8D60  bl       #0x382bd14 ; 
0066B8D64  mov      w8, #1
0066B8D68  strb     w8, [x21, #0x279]
0066B8D6C  adrp     x8, #0x8f11000
0066B8D70  ldr      x8, [x8, #0x9f0]
0066B8D74  ldr      x1, [x8]
0066B8D78  ldrb     w8, [x1, #0x53]
0066B8D7C  tbnz     w8, #5, #0x66b8d8c
0066B8D80  ldr      x0, [x19, #0x298]
0066B8D84  cbnz     x0, #0x66b8d9c
0066B8D88  b        #0x66b8e8c ; 
0066B8D8C  ldr      x8, [x1, #0x60]
0066B8D90  mov      x0, x19
0066B8D94  blr      x8
0066B8D98  cbz      x0, #0x66b8e8c
0066B8D9C  ldr      x8, [x0, #0x18]
0066B8DA0  cbz      x8, #0x66b8e8c
0066B8DA4  cbz      w8, #0x66b8ea8
0066B8DA8  ldr      q0, [x0, #0x20]
0066B8DAC  str      q0, [sp, #0x40]
0066B8DB0  cbz      x20, #0x66b8ea4
0066B8DB4  ldp      w22, w23, [x0, #0x30]
0066B8DB8  mov      x0, x20
0066B8DBC  mov      x2, xzr
0066B8DC0  mov      w1, w22
0066B8DC4  bl       #0x68e8594 ; HotFix.BattleLogic.HurtDataArray$$AddOrGet
0066B8DC8  cmp      w23, #2
0066B8DCC  mov      x21, x0
0066B8DD0  b.eq     #0x66b8e04
0066B8DD4  cmp      w23, #1
0066B8DD8  b.ne     #0x66b8e28
0066B8DDC  ldr      q0, [sp, #0x40]
0066B8DE0  mov      w8, #1
0066B8DE4  add      x1, sp, #0x20
0066B8DE8  mov      x0, x19
0066B8DEC  mov      x2, xzr
0066B8DF0  str      q0, [sp, #0x20]
0066B8DF4  stp      w22, w8, [sp, #0x30]
0066B8DF8  bl       #0x68f2314 ; HotFix.BattleLogic.HurtSourceData$$GetHurtDataDeltaHP
0066B8DFC  str      w0, [x21, #4]
0066B8E00  b        #0x66b8e28 ; 
0066B8E04  ldr      q0, [sp, #0x40]
0066B8E08  mov      w8, #2
0066B8E0C  mov      x1, sp
0066B8E10  mov      x0, x19
0066B8E14  mov      x2, xzr
0066B8E18  str      q0, [sp]
0066B8E1C  stp      w22, w8, [sp, #0x10]
0066B8E20  bl       #0x68f2314 ; HotFix.BattleLogic.HurtSourceData$$GetHurtDataDeltaHP
0066B8E24  str      w0, [x21, #8]
0066B8E28  adrp     x22, #0x959a000
0066B8E2C  ldrb     w8, [x22, #0x27a]
0066B8E30  cbnz     w8, #0x66b8e48
0066B8E34  adrp     x0, #0x8f11000
0066B8E38  ldr      x0, [x0, #0x9f8]
0066B8E3C  bl       #0x382bd14 ; 
0066B8E40  mov      w8, #1
0066B8E44  strb     w8, [x22, #0x27a]
0066B8E48  adrp     x8, #0x8f11000
0066B8E4C  ldr      x8, [x8, #0x9f8]
0066B8E50  ldr      x1, [x8]
0066B8E54  ldrb     w8, [x1, #0x53]
0066B8E58  tbnz     w8, #5, #0x66b8e64
0066B8E5C  ldr      w0, [x19, #0x28]
0066B8E60  b        #0x66b8e70 ; 
0066B8E64  ldr      x8, [x1, #0x60]
0066B8E68  mov      x0, x19
0066B8E6C  blr      x8
0066B8E70  mov      x1, xzr
0066B8E74  bl       #0x68e88d8 ; HotFix.BattleLogic.HurtDeltaHpSourceInfo$$FromAttackerType
0066B8E78  str      x1, [x21, #0x18]!
0066B8E7C  stur     x0, [x21, #-8]
0066B8E80  mov      x0, x21
0066B8E84  mov      x1, xzr
0066B8E88  bl       #0x382bcb8 ; 
0066B8E8C  mov      x0, x20
0066B8E90  ldp      x20, x19, [sp, #0x70]
0066B8E94  ldp      x22, x21, [sp, #0x60]
0066B8E98  ldp      x30, x23, [sp, #0x50]
0066B8E9C  add      sp, sp, #0x80
0066B8EA0  ret      
0066B8EA4  bl       #0x382bfb8 ; 
0066B8EA8  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CreateHurtSourceDataFromAttackInfo
; RVA 0x66B8AB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066B8AB0  str      x30, [sp, #-0x30]!
0066B8AB4  stp      x22, x21, [sp, #0x10]
0066B8AB8  stp      x20, x19, [sp, #0x20]
0066B8ABC  adrp     x21, #0x959a000
0066B8AC0  adrp     x22, #0x8f11000
0066B8AC4  ldrb     w8, [x21, #0x242]
0066B8AC8  ldr      x22, [x22, #0x9c0]
0066B8ACC  mov      x19, x1
0066B8AD0  mov      x20, x0
0066B8AD4  tbnz     w8, #0, #0x66b8b28
0066B8AD8  adrp     x0, #0x8f11000
0066B8ADC  ldr      x0, [x0, #0x9c0]
0066B8AE0  bl       #0x382bd14 ; 
0066B8AE4  adrp     x0, #0x8ee1000
0066B8AE8  ldr      x0, [x0, #0x6e8]
0066B8AEC  bl       #0x382bd14 ; 
0066B8AF0  adrp     x0, #0x8f11000
0066B8AF4  ldr      x0, [x0, #0x9c8]
0066B8AF8  bl       #0x382bd14 ; 
0066B8AFC  adrp     x0, #0x8f11000
0066B8B00  ldr      x0, [x0, #0x9d0]
0066B8B04  bl       #0x382bd14 ; 
0066B8B08  adrp     x0, #0x8f11000
0066B8B0C  ldr      x0, [x0, #0x9d8]
0066B8B10  bl       #0x382bd14 ; 
0066B8B14  adrp     x0, #0x8f11000
0066B8B18  ldr      x0, [x0, #0x9e0]
0066B8B1C  bl       #0x382bd14 ; 
0066B8B20  mov      w8, #1
0066B8B24  strb     w8, [x21, #0x242]
0066B8B28  ldr      x2, [x22]
0066B8B2C  ldrb     w8, [x2, #0x53]
0066B8B30  tbnz     w8, #5, #0x66b8b74
0066B8B34  cbz      x19, #0x66b8b90
0066B8B38  adrp     x21, #0x9591000
0066B8B3C  ldrb     w8, [x21, #0xa4b]
0066B8B40  cbnz     w8, #0x66b8b58
0066B8B44  adrp     x0, #0x8ee5000
0066B8B48  ldr      x0, [x0, #0xb28]
0066B8B4C  bl       #0x382bd14 ; 
0066B8B50  mov      w8, #1
0066B8B54  strb     w8, [x21, #0xa4b]
0066B8B58  adrp     x8, #0x8ee5000
0066B8B5C  ldr      x8, [x8, #0xb28]
0066B8B60  ldr      x1, [x8]
0066B8B64  ldrb     w8, [x1, #0x53]
0066B8B68  tbnz     w8, #5, #0x66b8be0
0066B8B6C  ldr      x20, [x20, #0x20]
0066B8B70  b        #0x66b8bf0 ; 
0066B8B74  ldr      x3, [x2, #0x60]
0066B8B78  mov      x0, x20
0066B8B7C  mov      x1, x19
0066B8B80  ldp      x20, x19, [sp, #0x20]
0066B8B84  ldp      x22, x21, [sp, #0x10]
0066B8B88  ldr      x30, [sp], #0x30
0066B8B8C  br       x3
0066B8B90  adrp     x8, #0x8ee1000
0066B8B94  ldr      x8, [x8, #0x6e8]
0066B8B98  ldr      x0, [x8]
0066B8B9C  ldr      w8, [x0, #0xe0]
0066B8BA0  cbnz     w8, #0x66b8ba8
0066B8BA4  bl       #0x382be8c ; 
0066B8BA8  adrp     x8, #0x8f11000
0066B8BAC  adrp     x9, #0x8f11000
0066B8BB0  adrp     x10, #0x8f11000
0066B8BB4  ldr      x8, [x8, #0x9d8]
0066B8BB8  ldr      x9, [x9, #0x9d0]
0066B8BBC  ldr      x10, [x10, #0x9e0]
0066B8BC0  mov      w3, #0x294
0066B8BC4  ldr      x0, [x8]
0066B8BC8  ldr      x1, [x9]
0066B8BCC  ldr      x2, [x10]
0066B8BD0  mov      x4, xzr
0066B8BD4  bl       #0x7997754 ; Logger$$LogError
0066B8BD8  mov      x20, xzr
0066B8BDC  b        #0x66b8c64 ; 
0066B8BE0  ldr      x8, [x1, #0x60]
0066B8BE4  mov      x0, x20
0066B8BE8  blr      x8
0066B8BEC  mov      x20, x0
0066B8BF0  cbz      x20, #0x66b8c78
0066B8BF4  adrp     x21, #0x9591000
0066B8BF8  ldrb     w8, [x21, #0xa4c]
0066B8BFC  cbnz     w8, #0x66b8c14
0066B8C00  adrp     x0, #0x8ee5000
0066B8C04  ldr      x0, [x0, #0xb30]
0066B8C08  bl       #0x382bd14 ; 
0066B8C0C  mov      w8, #1
0066B8C10  strb     w8, [x21, #0xa4c]
0066B8C14  adrp     x8, #0x8ee5000
0066B8C18  ldr      x8, [x8, #0xb30]
0066B8C1C  ldr      x1, [x8]
0066B8C20  ldrb     w8, [x1, #0x53]
0066B8C24  tbnz     w8, #5, #0x66b8c30
0066B8C28  ldr      x0, [x20, #0x210]
0066B8C2C  b        #0x66b8c3c ; 
0066B8C30  ldr      x8, [x1, #0x60]
0066B8C34  mov      x0, x20
0066B8C38  blr      x8
0066B8C3C  cbz      x0, #0x66b8c78
0066B8C40  adrp     x8, #0x8f11000
0066B8C44  ldr      x8, [x8, #0x9c8]
0066B8C48  ldr      x1, [x8]
0066B8C4C  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0066B8C50  cbz      x0, #0x66b8c78
0066B8C54  mov      x1, x19
0066B8C58  mov      x2, xzr
0066B8C5C  mov      x20, x0
0066B8C60  bl       #0x68ec254 ; HotFix.BattleLogic.HurtSourceData$$SetFromAttackSourceInfo
0066B8C64  mov      x0, x20
0066B8C68  ldp      x20, x19, [sp, #0x20]
0066B8C6C  ldp      x22, x21, [sp, #0x10]
0066B8C70  ldr      x30, [sp], #0x30
0066B8C74  ret      
0066B8C78  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitByBody
; RVA 0x66C0AA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C0AA0  sub      sp, sp, #0xe0
0066C0AA4  stp      x29, x30, [sp, #0x80]
0066C0AA8  stp      x28, x27, [sp, #0x90]
0066C0AAC  stp      x26, x25, [sp, #0xa0]
0066C0AB0  stp      x24, x23, [sp, #0xb0]
0066C0AB4  stp      x22, x21, [sp, #0xc0]
0066C0AB8  stp      x20, x19, [sp, #0xd0]
0066C0ABC  mrs      x25, tpidr_el0
0066C0AC0  ldr      x8, [x25, #0x28]
0066C0AC4  adrp     x21, #0x959a000
0066C0AC8  adrp     x22, #0x8f11000
0066C0ACC  mov      x20, x1
0066C0AD0  str      x8, [sp, #0x78]
0066C0AD4  ldrb     w8, [x21, #0x243]
0066C0AD8  ldr      x22, [x22, #0xcf8]
0066C0ADC  mov      x19, x0
0066C0AE0  tbnz     w8, #0, #0x66c0b7c
0066C0AE4  adrp     x0, #0x8f11000
0066C0AE8  ldr      x0, [x0, #0xcf8]
0066C0AEC  bl       #0x382bd14 ; 
0066C0AF0  adrp     x0, #0x8ee6000
0066C0AF4  ldr      x0, [x0, #0xd8]
0066C0AF8  bl       #0x382bd14 ; 
0066C0AFC  adrp     x0, #0x8ee6000
0066C0B00  ldr      x0, [x0, #0xe8]
0066C0B04  bl       #0x382bd14 ; 
0066C0B08  adrp     x0, #0x8ee6000
0066C0B0C  ldr      x0, [x0, #0x600]
0066C0B10  bl       #0x382bd14 ; 
0066C0B14  adrp     x0, #0x8ee6000
0066C0B18  ldr      x0, [x0, #0x608]
0066C0B1C  bl       #0x382bd14 ; 
0066C0B20  adrp     x0, #0x8f10000
0066C0B24  ldr      x0, [x0, #0x950]
0066C0B28  bl       #0x382bd14 ; 
0066C0B2C  adrp     x0, #0x8ee1000
0066C0B30  ldr      x0, [x0, #0x6e8]
0066C0B34  bl       #0x382bd14 ; 
0066C0B38  adrp     x0, #0x8f11000
0066C0B3C  ldr      x0, [x0, #0xb40]
0066C0B40  bl       #0x382bd14 ; 
0066C0B44  adrp     x0, #0x8f11000
0066C0B48  ldr      x0, [x0, #0xd00]
0066C0B4C  bl       #0x382bd14 ; 
0066C0B50  adrp     x0, #0x8f11000
0066C0B54  ldr      x0, [x0, #0xd08]
0066C0B58  bl       #0x382bd14 ; 
0066C0B5C  adrp     x0, #0x8f11000
0066C0B60  ldr      x0, [x0, #0xd10]
0066C0B64  bl       #0x382bd14 ; 
0066C0B68  adrp     x0, #0x8f11000
0066C0B6C  ldr      x0, [x0, #0x9e0]
0066C0B70  bl       #0x382bd14 ; 
0066C0B74  mov      w8, #1
0066C0B78  strb     w8, [x21, #0x243]
0066C0B7C  ldr      x2, [x22]
0066C0B80  ldrb     w8, [x2, #0x53]
0066C0B84  tbnz     w8, #5, #0x66c0bcc
0066C0B88  strb     wzr, [sp, #0x14]
0066C0B8C  str      wzr, [sp, #0x10]
0066C0B90  cbz      x20, #0x66c14b4
0066C0B94  mov      x0, x20
0066C0B98  mov      x1, xzr
0066C0B9C  bl       #0x67e3ac4 ; HotFix.BattleLogic.EntityCharacter$$IsInBornState
0066C0BA0  tbnz     w0, #0, #0x66c0bdc
0066C0BA4  mov      w1, #3
0066C0BA8  mov      x0, x19
0066C0BAC  bl       #0x66b7188 ; HotFix.BattleLogic.CharacterComponentOnHit$$dispatchHittedTriggerEvent
0066C0BB0  adrp     x26, #0x8ee6000
0066C0BB4  ldr      x26, [x26, #0x608]
0066C0BB8  ldr      x1, [x26]
0066C0BBC  ldrb     w8, [x1, #0x53]
0066C0BC0  tbnz     w8, #5, #0x66c0c0c
0066C0BC4  ldr      x0, [x19, #0x30]
0066C0BC8  b        #0x66c0c18 ; 
0066C0BCC  ldr      x8, [x2, #0x60]
0066C0BD0  mov      x0, x19
0066C0BD4  mov      x1, x20
0066C0BD8  blr      x8
0066C0BDC  ldr      x8, [x25, #0x28]
0066C0BE0  ldr      x9, [sp, #0x78]
0066C0BE4  cmp      x8, x9
0066C0BE8  b.ne     #0x66c14bc
0066C0BEC  ldp      x20, x19, [sp, #0xd0]
0066C0BF0  ldp      x22, x21, [sp, #0xc0]
0066C0BF4  ldp      x24, x23, [sp, #0xb0]
0066C0BF8  ldp      x26, x25, [sp, #0xa0]
0066C0BFC  ldp      x28, x27, [sp, #0x90]
0066C0C00  ldp      x29, x30, [sp, #0x80]
0066C0C04  add      sp, sp, #0xe0
0066C0C08  ret      
0066C0C0C  ldr      x8, [x1, #0x60]
0066C0C10  mov      x0, x19
0066C0C14  blr      x8
0066C0C18  cbz      x0, #0x66c14b4
0066C0C1C  ldr      x8, [x0]
0066C0C20  ldr      x9, [x8, #0x458]
0066C0C24  ldr      x1, [x8, #0x460]
0066C0C28  blr      x9
0066C0C2C  tbz      w0, #0, #0x66c0bdc
0066C0C30  mov      x0, x19
0066C0C34  bl       #0x66b7518 ; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndUpdateHitTime
0066C0C38  tbz      w0, #0, #0x66c0bdc
0066C0C3C  mov      x0, x19
0066C0C40  bl       #0x66be654 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayEntityHitSound
0066C0C44  mov      x0, x19
0066C0C48  bl       #0x66be8c4 ; HotFix.BattleLogic.CharacterComponentOnHit$$PlayVibartion
0066C0C4C  ldr      x1, [x26]
0066C0C50  ldrb     w8, [x1, #0x53]
0066C0C54  tbnz     w8, #5, #0x66c0c60
0066C0C58  ldr      x0, [x19, #0x30]
0066C0C5C  b        #0x66c0c6c ; 
0066C0C60  ldr      x8, [x1, #0x60]
0066C0C64  mov      x0, x19
0066C0C68  blr      x8
0066C0C6C  cbz      x0, #0x66c14b4
0066C0C70  adrp     x21, #0x8ee6000
0066C0C74  ldr      x21, [x21, #0xd8]
0066C0C78  ldr      x1, [x21]
0066C0C7C  ldrb     w8, [x1, #0x53]
0066C0C80  tbnz     w8, #5, #0x66c0c8c
0066C0C84  ldr      x0, [x0, #0x38]
0066C0C88  b        #0x66c0c94 ; 
0066C0C8C  ldr      x8, [x1, #0x60]
0066C0C90  blr      x8
0066C0C94  cbz      x0, #0x66c14b4
0066C0C98  add      x8, sp, #0x60
0066C0C9C  mov      x1, xzr
0066C0CA0  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C0CA4  ldr      x1, [x21]
0066C0CA8  ldp      x23, x21, [sp, #0x60]
0066C0CAC  ldr      x22, [sp, #0x70]
0066C0CB0  ldrb     w8, [x1, #0x53]
0066C0CB4  tbnz     w8, #5, #0x66c0cc0
0066C0CB8  ldr      x0, [x20, #0x38]
0066C0CBC  b        #0x66c0ccc ; 
0066C0CC0  ldr      x8, [x1, #0x60]
0066C0CC4  mov      x0, x20
0066C0CC8  blr      x8
0066C0CCC  cbz      x0, #0x66c14b4
0066C0CD0  add      x8, sp, #0x60
0066C0CD4  mov      x1, xzr
0066C0CD8  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C0CDC  ldp      x8, x9, [sp, #0x60]
0066C0CE0  ldr      x10, [sp, #0x70]
0066C0CE4  add      x1, sp, #0x48
0066C0CE8  mov      w2, #3
0066C0CEC  sub      x8, x23, x8
0066C0CF0  sub      x9, x21, x9
0066C0CF4  sub      x10, x22, x10
0066C0CF8  mov      x0, x19
0066C0CFC  stp      x8, x9, [sp, #0x48]
0066C0D00  str      x10, [sp, #0x58]
0066C0D04  bl       #0x66bda9c ; HotFix.BattleLogic.CharacterComponentOnHit$$DispatchDamageRenderEvent
0066C0D08  ldr      x1, [x26]
0066C0D0C  ldrb     w8, [x1, #0x53]
0066C0D10  tbnz     w8, #5, #0x66c0d1c
0066C0D14  ldr      x1, [x19, #0x30]
0066C0D18  b        #0x66c0d2c ; 
0066C0D1C  ldr      x8, [x1, #0x60]
0066C0D20  mov      x0, x19
0066C0D24  blr      x8
0066C0D28  mov      x1, x0
0066C0D2C  mov      x0, x20
0066C0D30  mov      x2, xzr
0066C0D34  bl       #0x68de868 ; HotFix.BattleLogic.AttackSourceInfo$$FromBodyAttack
0066C0D38  cbz      x0, #0x66c0d90
0066C0D3C  mov      x22, x0
0066C0D40  mov      x0, x19
0066C0D44  mov      x1, x22
0066C0D48  bl       #0x66b8ab0 ; HotFix.BattleLogic.CharacterComponentOnHit$$CreateHurtSourceDataFromAttackInfo
0066C0D4C  cbz      x0, #0x66c0dc8
0066C0D50  adrp     x27, #0x9591000
0066C0D54  ldrb     w8, [x27, #0xa4b]
0066C0D58  mov      x21, x0
0066C0D5C  cbnz     w8, #0x66c0d74
0066C0D60  adrp     x0, #0x8ee5000
0066C0D64  ldr      x0, [x0, #0xb28]
0066C0D68  bl       #0x382bd14 ; 
0066C0D6C  mov      w8, #1
0066C0D70  strb     w8, [x27, #0xa4b]
0066C0D74  adrp     x28, #0x8ee5000
0066C0D78  ldr      x28, [x28, #0xb28]
0066C0D7C  ldr      x1, [x28]
0066C0D80  ldrb     w8, [x1, #0x53]
0066C0D84  tbnz     w8, #5, #0x66c0e14
0066C0D88  ldr      x0, [x19, #0x20]
0066C0D8C  b        #0x66c0e20 ; 
0066C0D90  adrp     x8, #0x8ee1000
0066C0D94  ldr      x8, [x8, #0x6e8]
0066C0D98  ldr      x0, [x8]
0066C0D9C  ldr      w8, [x0, #0xe0]
0066C0DA0  cbnz     w8, #0x66c0da8
0066C0DA4  bl       #0x382be8c ; 
0066C0DA8  adrp     x8, #0x8f11000
0066C0DAC  adrp     x9, #0x8f11000
0066C0DB0  adrp     x10, #0x8f11000
0066C0DB4  ldr      x8, [x8, #0xd00]
0066C0DB8  ldr      x9, [x9, #0xd10]
0066C0DBC  ldr      x10, [x10, #0x9e0]
0066C0DC0  mov      w3, #0x2b9
0066C0DC4  b        #0x66c0dfc ; 
0066C0DC8  adrp     x8, #0x8ee1000
0066C0DCC  ldr      x8, [x8, #0x6e8]
0066C0DD0  ldr      x0, [x8]
0066C0DD4  ldr      w8, [x0, #0xe0]
0066C0DD8  cbnz     w8, #0x66c0de0
0066C0DDC  bl       #0x382be8c ; 
0066C0DE0  adrp     x8, #0x8f11000
0066C0DE4  adrp     x9, #0x8f11000
0066C0DE8  adrp     x10, #0x8f11000
0066C0DEC  ldr      x8, [x8, #0xd08]
0066C0DF0  ldr      x9, [x9, #0xd10]
0066C0DF4  ldr      x10, [x10, #0x9e0]
0066C0DF8  mov      w3, #0x2c0
0066C0DFC  ldr      x0, [x8]
0066C0E00  ldr      x1, [x9]
0066C0E04  ldr      x2, [x10]
0066C0E08  mov      x4, xzr
0066C0E0C  bl       #0x7997754 ; Logger$$LogError
0066C0E10  b        #0x66c0bdc ; 
0066C0E14  ldr      x8, [x1, #0x60]
0066C0E18  mov      x0, x19
0066C0E1C  blr      x8
0066C0E20  cbz      x0, #0x66c14b4
0066C0E24  mov      x1, xzr
0066C0E28  bl       #0x69fa20c ; HotFix.BattleLogic.BattleWorldContext$$get_BodyAttackAttributeNameTable
0066C0E2C  cbz      x0, #0x66c14b4
0066C0E30  adrp     x23, #0x959a000
0066C0E34  ldrb     w8, [x23, #0xff]
0066C0E38  mov      x24, x0
0066C0E3C  cbnz     w8, #0x66c0e54
0066C0E40  adrp     x0, #0x8f10000
0066C0E44  ldr      x0, [x0, #0x930]
0066C0E48  bl       #0x382bd14 ; 
0066C0E4C  mov      w8, #1
0066C0E50  strb     w8, [x23, #0xff]
0066C0E54  adrp     x8, #0x8f10000
0066C0E58  ldr      x8, [x8, #0x930]
0066C0E5C  ldr      x1, [x8]
0066C0E60  ldrb     w8, [x1, #0x53]
0066C0E64  tbnz     w8, #5, #0x66c0e70
0066C0E68  ldr      w23, [x24, #0x34]
0066C0E6C  b        #0x66c0e80 ; 
0066C0E70  ldr      x8, [x1, #0x60]
0066C0E74  mov      x0, x24
0066C0E78  blr      x8
0066C0E7C  mov      w23, w0
0066C0E80  adrp     x29, #0x959a000
0066C0E84  ldrb     w8, [x29, #0x100]
0066C0E88  cbnz     w8, #0x66c0ea0
0066C0E8C  adrp     x0, #0x8f10000
0066C0E90  ldr      x0, [x0, #0x938]
0066C0E94  bl       #0x382bd14 ; 
0066C0E98  mov      w8, #1
0066C0E9C  strb     w8, [x29, #0x100]
0066C0EA0  adrp     x8, #0x8f10000
0066C0EA4  ldr      x8, [x8, #0x938]
0066C0EA8  ldr      x1, [x8]
0066C0EAC  ldrb     w8, [x1, #0x53]
0066C0EB0  tbnz     w8, #5, #0x66c0ebc
0066C0EB4  ldr      w24, [x24, #0x30]
0066C0EB8  b        #0x66c0ecc ; 
0066C0EBC  ldr      x8, [x1, #0x60]
0066C0EC0  mov      x0, x24
0066C0EC4  blr      x8
0066C0EC8  mov      w24, w0
0066C0ECC  adrp     x8, #0x8f10000
0066C0ED0  ldr      x8, [x8, #0x950]
0066C0ED4  mov      w1, #1
0066C0ED8  ldr      x0, [x8]
0066C0EDC  bl       #0x382bdfc ; 
0066C0EE0  cbz      x0, #0x66c14b4
0066C0EE4  ldr      w8, [x0, #0x18]
0066C0EE8  cbz      w8, #0x66c14b8
0066C0EEC  adrp     x8, #0x197f000
0066C0EF0  ldr      d0, [x8, #0xc70]
0066C0EF4  mov      w8, #0x10000
0066C0EF8  str      x8, [x0, #0x28]
0066C0EFC  stp      w23, w24, [x0, #0x30]
0066C0F00  str      d0, [x0, #0x20]
0066C0F04  mov      x0, x19
0066C0F08  mov      x1, x21
0066C0F0C  mov      x2, x22
0066C0F10  bl       #0x66b8c7c ; HotFix.BattleLogic.CharacterComponentOnHit$$BuildHurtDataArray
0066C0F14  mov      x22, x0
0066C0F18  add      x4, sp, #0x14
0066C0F1C  add      x5, sp, #0x10
0066C0F20  add      x6, sp, #0x30
0066C0F24  mov      x0, x19
0066C0F28  mov      x1, x21
0066C0F2C  mov      x2, x22
0066C0F30  mov      w3, wzr
0066C0F34  mov      x7, xzr
0066C0F38  stp      xzr, xzr, [sp, #0x38]
0066C0F3C  str      xzr, [sp, #0x30]
0066C0F40  str      wzr, [sp]
0066C0F44  bl       #0x66bca88 ; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitUpdateHP
0066C0F48  mov      w23, w0
0066C0F4C  mov      x0, x21
0066C0F50  mov      x1, xzr
0066C0F54  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066C0F58  ldrb     w8, [x27, #0xa4b]
0066C0F5C  cbnz     w8, #0x66c0f74
0066C0F60  adrp     x0, #0x8ee5000
0066C0F64  ldr      x0, [x0, #0xb28]
0066C0F68  bl       #0x382bd14 ; 
0066C0F6C  mov      w8, #1
0066C0F70  strb     w8, [x27, #0xa4b]
0066C0F74  ldr      x1, [x28]
0066C0F78  ldrb     w8, [x1, #0x53]
0066C0F7C  tbnz     w8, #5, #0x66c0f88
0066C0F80  ldr      x0, [x19, #0x20]
0066C0F84  b        #0x66c0f94 ; 
0066C0F88  ldr      x8, [x1, #0x60]
0066C0F8C  mov      x0, x19
0066C0F90  blr      x8
0066C0F94  cbz      x0, #0x66c14b4
0066C0F98  mov      x1, x22
0066C0F9C  mov      x2, xzr
0066C0FA0  bl       #0x69faa68 ; HotFix.BattleLogic.BattleWorldContext$$PushHurtDataArray
0066C0FA4  tbz      w23, #0, #0x66c0fbc
0066C0FA8  ldr      x1, [x26]
0066C0FAC  ldrb     w8, [x1, #0x53]
0066C0FB0  tbnz     w8, #5, #0x66c0fd8
0066C0FB4  ldr      x21, [x19, #0x30]
0066C0FB8  b        #0x66c0fe8 ; 
0066C0FBC  adrp     x8, #0x8ee6000
0066C0FC0  ldr      x8, [x8, #0x600]
0066C0FC4  ldr      x1, [x8]
0066C0FC8  ldrb     w8, [x1, #0x53]
0066C0FCC  tbnz     w8, #5, #0x66c1050
0066C0FD0  ldr      x0, [x19, #0x38]
0066C0FD4  b        #0x66c105c ; 
0066C0FD8  ldr      x8, [x1, #0x60]
0066C0FDC  mov      x0, x19
0066C0FE0  blr      x8
0066C0FE4  mov      x21, x0
0066C0FE8  cbz      x21, #0x66c14b4
0066C0FEC  adrp     x22, #0x9591000
0066C0FF0  ldrb     w8, [x22, #0xa86]
0066C0FF4  cbnz     w8, #0x66c1018
0066C0FF8  adrp     x0, #0x8ee6000
0066C0FFC  ldr      x0, [x0, #0x318]
0066C1000  bl       #0x382bd14 ; 
0066C1004  adrp     x0, #0x8ee3000
0066C1008  ldr      x0, [x0, #0xf18]
0066C100C  bl       #0x382bd14 ; 
0066C1010  mov      w8, #1
0066C1014  strb     w8, [x22, #0xa86]
0066C1018  adrp     x8, #0x8ee6000
0066C101C  ldr      x8, [x8, #0x318]
0066C1020  ldr      x2, [x8]
0066C1024  ldrb     w8, [x2, #0x53]
0066C1028  tbnz     w8, #5, #0x66c109c
0066C102C  ldr      x0, [x21, #0x190]
0066C1030  cbz      x0, #0x66c12a4
0066C1034  adrp     x8, #0x8ee3000
0066C1038  ldr      x8, [x8, #0xf18]
0066C103C  mov      w1, #0xd
0066C1040  ldr      x2, [x8]
0066C1044  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066C1048  tbnz     w0, #0, #0x66c10b0
0066C104C  b        #0x66c12a4 ; 
0066C1050  ldr      x8, [x1, #0x60]
0066C1054  mov      x0, x19
0066C1058  blr      x8
0066C105C  cbz      x0, #0x66c14b4
0066C1060  mov      x1, xzr
0066C1064  bl       #0x45616a8 ; 
0066C1068  tbz      w0, #0, #0x66c0bdc
0066C106C  ldrb     w8, [x27, #0xa4b]
0066C1070  cbnz     w8, #0x66c1088
0066C1074  adrp     x0, #0x8ee5000
0066C1078  ldr      x0, [x0, #0xb28]
0066C107C  bl       #0x382bd14 ; 
0066C1080  mov      w8, #1
0066C1084  strb     w8, [x27, #0xa4b]
0066C1088  ldr      x1, [x28]
0066C108C  ldrb     w8, [x1, #0x53]
0066C1090  tbnz     w8, #5, #0x66c10e0
0066C1094  ldr      x0, [x19, #0x20]
0066C1098  b        #0x66c10ec ; 
0066C109C  ldr      x8, [x2, #0x60]
0066C10A0  mov      w1, #0xd
0066C10A4  mov      x0, x21
0066C10A8  blr      x8
0066C10AC  tbz      w0, #0, #0x66c12a4
0066C10B0  ldrb     w8, [x27, #0xa4b]
0066C10B4  cbnz     w8, #0x66c10cc
0066C10B8  adrp     x0, #0x8ee5000
0066C10BC  ldr      x0, [x0, #0xb28]
0066C10C0  bl       #0x382bd14 ; 
0066C10C4  mov      w8, #1
0066C10C8  strb     w8, [x27, #0xa4b]
0066C10CC  ldr      x1, [x28]
0066C10D0  ldrb     w8, [x1, #0x53]
0066C10D4  tbnz     w8, #5, #0x66c10fc
0066C10D8  ldr      x21, [x19, #0x20]
0066C10DC  b        #0x66c110c ; 
0066C10E0  ldr      x8, [x1, #0x60]
0066C10E4  mov      x0, x19
0066C10E8  blr      x8
0066C10EC  cbz      x0, #0x66c14b4
0066C10F0  mov      x1, xzr
0066C10F4  bl       #0x66c6138 ; 
0066C10F8  b        #0x66c0bdc ; 
0066C10FC  ldr      x8, [x1, #0x60]
0066C1100  mov      x0, x19
0066C1104  blr      x8
0066C1108  mov      x21, x0
0066C110C  cbz      x21, #0x66c14b4
0066C1110  adrp     x22, #0x9591000
0066C1114  ldrb     w8, [x22, #0xa4c]
0066C1118  cbnz     w8, #0x66c1130
0066C111C  adrp     x0, #0x8ee5000
0066C1120  ldr      x0, [x0, #0xb30]
0066C1124  bl       #0x382bd14 ; 
0066C1128  mov      w8, #1
0066C112C  strb     w8, [x22, #0xa4c]
0066C1130  adrp     x8, #0x8ee5000
0066C1134  ldr      x8, [x8, #0xb30]
0066C1138  ldr      x1, [x8]
0066C113C  ldrb     w8, [x1, #0x53]
0066C1140  tbnz     w8, #5, #0x66c114c
0066C1144  ldr      x0, [x21, #0x210]
0066C1148  b        #0x66c1158 ; 
0066C114C  ldr      x8, [x1, #0x60]
0066C1150  mov      x0, x21
0066C1154  blr      x8
0066C1158  cbz      x0, #0x66c14b4
0066C115C  adrp     x8, #0x8f11000
0066C1160  ldr      x8, [x8, #0xb40]
0066C1164  ldr      x1, [x8]
0066C1168  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C116C  adrp     x22, #0x8ee6000
0066C1170  ldr      x22, [x22, #0x600]
0066C1174  mov      x21, x0
0066C1178  ldr      x1, [x22]
0066C117C  ldrb     w8, [x1, #0x53]
0066C1180  tbnz     w8, #5, #0x66c118c
0066C1184  ldr      x0, [x19, #0x38]
0066C1188  b        #0x66c1198 ; 
0066C118C  ldr      x8, [x1, #0x60]
0066C1190  mov      x0, x19
0066C1194  blr      x8
0066C1198  cbz      x0, #0x66c14b4
0066C119C  add      x8, sp, #0x18
0066C11A0  mov      x1, xzr
0066C11A4  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C11A8  ldur     q0, [sp, #0x18]
0066C11AC  ldr      x8, [sp, #0x28]
0066C11B0  str      q0, [sp, #0x60]
0066C11B4  str      x8, [sp, #0x70]
0066C11B8  cbz      x21, #0x66c14b4
0066C11BC  ldr      x8, [sp, #0x70]
0066C11C0  ldr      q0, [sp, #0x60]
0066C11C4  str      x8, [x21, #0x30]
0066C11C8  str      q0, [x21, #0x20]
0066C11CC  adrp     x8, #0x8ee6000
0066C11D0  ldr      x8, [x8, #0xe8]
0066C11D4  ldr      x1, [x8]
0066C11D8  ldrb     w8, [x1, #0x53]
0066C11DC  tbnz     w8, #5, #0x66c11e8
0066C11E0  ldr      x0, [x20, #0x28]
0066C11E4  b        #0x66c11f4 ; 
0066C11E8  ldr      x8, [x1, #0x60]
0066C11EC  mov      x0, x20
0066C11F0  blr      x8
0066C11F4  str      x0, [x21, #0x38]
0066C11F8  ldr      x1, [x22]
0066C11FC  ldrb     w8, [x1, #0x53]
0066C1200  tbnz     w8, #5, #0x66c120c
0066C1204  ldr      x22, [x19, #0x38]
0066C1208  b        #0x66c121c ; 
0066C120C  ldr      x8, [x1, #0x60]
0066C1210  mov      x0, x19
0066C1214  blr      x8
0066C1218  mov      x22, x0
0066C121C  cbz      x22, #0x66c14b4
0066C1220  adrp     x23, #0x9592000
0066C1224  ldrb     w8, [x23, #0x473]
0066C1228  cbnz     w8, #0x66c1240
0066C122C  adrp     x0, #0x8ee8000
0066C1230  ldr      x0, [x0, #0x890]
0066C1234  bl       #0x382bd14 ; 
0066C1238  mov      w8, #1
0066C123C  strb     w8, [x23, #0x473]
0066C1240  adrp     x8, #0x8ee8000
0066C1244  ldr      x8, [x8, #0x890]
0066C1248  ldr      x1, [x8]
0066C124C  ldrb     w8, [x1, #0x53]
0066C1250  tbnz     w8, #5, #0x66c125c
0066C1254  ldr      x0, [x22, #0x20]
0066C1258  b        #0x66c1268 ; 
0066C125C  ldr      x8, [x1, #0x60]
0066C1260  mov      x0, x22
0066C1264  blr      x8
0066C1268  str      x0, [x21, #0x48]
0066C126C  ldr      x1, [x26]
0066C1270  ldrb     w8, [x1, #0x53]
0066C1274  tbnz     w8, #5, #0x66c1280
0066C1278  ldr      x0, [x19, #0x30]
0066C127C  b        #0x66c128c ; 
0066C1280  ldr      x8, [x1, #0x60]
0066C1284  mov      x0, x19
0066C1288  blr      x8
0066C128C  cbz      x0, #0x66c14b4
0066C1290  ldr      x0, [x0, #0x150]
0066C1294  cbz      x0, #0x66c14b4
0066C1298  mov      x1, x21
0066C129C  mov      x2, xzr
0066C12A0  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066C12A4  adrp     x22, #0x8ee6000
0066C12A8  ldr      x22, [x22, #0x600]
0066C12AC  ldr      x1, [x22]
0066C12B0  ldrb     w8, [x1, #0x53]
0066C12B4  tbnz     w8, #5, #0x66c12c0
0066C12B8  ldr      x0, [x19, #0x38]
0066C12BC  b        #0x66c12cc ; 
0066C12C0  ldr      x8, [x1, #0x60]
0066C12C4  mov      x0, x19
0066C12C8  blr      x8
0066C12CC  cbz      x0, #0x66c14b4
0066C12D0  mov      x1, xzr
0066C12D4  bl       #0x45616a8 ; 
0066C12D8  tbz      w0, #0, #0x66c0bdc
0066C12DC  ldrb     w8, [x27, #0xa4b]
0066C12E0  cbnz     w8, #0x66c12f8
0066C12E4  adrp     x0, #0x8ee5000
0066C12E8  ldr      x0, [x0, #0xb28]
0066C12EC  bl       #0x382bd14 ; 
0066C12F0  mov      w8, #1
0066C12F4  strb     w8, [x27, #0xa4b]
0066C12F8  ldr      x1, [x28]
0066C12FC  ldrb     w8, [x1, #0x53]
0066C1300  tbnz     w8, #5, #0x66c130c
0066C1304  ldr      x21, [x19, #0x20]
0066C1308  b        #0x66c131c ; 
0066C130C  ldr      x8, [x1, #0x60]
0066C1310  mov      x0, x19
0066C1314  blr      x8
0066C1318  mov      x21, x0
0066C131C  cbz      x21, #0x66c14b4
0066C1320  adrp     x23, #0x9591000
0066C1324  ldrb     w8, [x23, #0xa4c]
0066C1328  cbnz     w8, #0x66c1340
0066C132C  adrp     x0, #0x8ee5000
0066C1330  ldr      x0, [x0, #0xb30]
0066C1334  bl       #0x382bd14 ; 
0066C1338  mov      w8, #1
0066C133C  strb     w8, [x23, #0xa4c]
0066C1340  adrp     x8, #0x8ee5000
0066C1344  ldr      x8, [x8, #0xb30]
0066C1348  ldr      x1, [x8]
0066C134C  ldrb     w8, [x1, #0x53]
0066C1350  tbnz     w8, #5, #0x66c135c
0066C1354  ldr      x0, [x21, #0x210]
0066C1358  b        #0x66c1368 ; 
0066C135C  ldr      x8, [x1, #0x60]
0066C1360  mov      x0, x21
0066C1364  blr      x8
0066C1368  cbz      x0, #0x66c14b4
0066C136C  adrp     x8, #0x8f11000
0066C1370  ldr      x8, [x8, #0xb40]
0066C1374  ldr      x1, [x8]
0066C1378  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C137C  ldr      x1, [x22]
0066C1380  mov      x21, x0
0066C1384  ldrb     w8, [x1, #0x53]
0066C1388  tbnz     w8, #5, #0x66c1394
0066C138C  ldr      x0, [x19, #0x38]
0066C1390  b        #0x66c13a0 ; 
0066C1394  ldr      x8, [x1, #0x60]
0066C1398  mov      x0, x19
0066C139C  blr      x8
0066C13A0  cbz      x0, #0x66c14b4
0066C13A4  add      x8, sp, #0x18
0066C13A8  mov      x1, xzr
0066C13AC  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C13B0  ldur     q0, [sp, #0x18]
0066C13B4  ldr      x8, [sp, #0x28]
0066C13B8  str      q0, [sp, #0x60]
0066C13BC  str      x8, [sp, #0x70]
0066C13C0  cbz      x21, #0x66c14b4
0066C13C4  ldr      x8, [sp, #0x70]
0066C13C8  ldr      q0, [sp, #0x60]
0066C13CC  str      x8, [x21, #0x30]
0066C13D0  str      q0, [x21, #0x20]
0066C13D4  adrp     x8, #0x8ee6000
0066C13D8  ldr      x8, [x8, #0xe8]
0066C13DC  ldr      x1, [x8]
0066C13E0  ldrb     w8, [x1, #0x53]
0066C13E4  tbnz     w8, #5, #0x66c13f0
0066C13E8  ldr      x0, [x20, #0x28]
0066C13EC  b        #0x66c13fc ; 
0066C13F0  ldr      x8, [x1, #0x60]
0066C13F4  mov      x0, x20
0066C13F8  blr      x8
0066C13FC  str      x0, [x21, #0x38]
0066C1400  ldr      x1, [x22]
0066C1404  ldrb     w8, [x1, #0x53]
0066C1408  tbnz     w8, #5, #0x66c1414
0066C140C  ldr      x20, [x19, #0x38]
0066C1410  b        #0x66c1424 ; 
0066C1414  ldr      x8, [x1, #0x60]
0066C1418  mov      x0, x19
0066C141C  blr      x8
0066C1420  mov      x20, x0
0066C1424  cbz      x20, #0x66c14b4
0066C1428  adrp     x22, #0x9592000
0066C142C  ldrb     w8, [x22, #0x473]
0066C1430  cbnz     w8, #0x66c1448
0066C1434  adrp     x0, #0x8ee8000
0066C1438  ldr      x0, [x0, #0x890]
0066C143C  bl       #0x382bd14 ; 
0066C1440  mov      w8, #1
0066C1444  strb     w8, [x22, #0x473]
0066C1448  adrp     x8, #0x8ee8000
0066C144C  ldr      x8, [x8, #0x890]
0066C1450  ldr      x1, [x8]
0066C1454  ldrb     w8, [x1, #0x53]
0066C1458  tbnz     w8, #5, #0x66c1464
0066C145C  ldr      x0, [x20, #0x20]
0066C1460  b        #0x66c1470 ; 
0066C1464  ldr      x8, [x1, #0x60]
0066C1468  mov      x0, x20
0066C146C  blr      x8
0066C1470  str      x0, [x21, #0x48]
0066C1474  ldr      x1, [x26]
0066C1478  ldrb     w8, [x1, #0x53]
0066C147C  tbnz     w8, #5, #0x66c1488
0066C1480  ldr      x0, [x19, #0x30]
0066C1484  b        #0x66c1494 ; 
0066C1488  ldr      x8, [x1, #0x60]
0066C148C  mov      x0, x19
0066C1490  blr      x8
0066C1494  cbz      x0, #0x66c14b4
0066C1498  mov      x1, x21
0066C149C  mov      x2, xzr
0066C14A0  bl       #0x67e4278 ; HotFix.BattleLogic.EntityCharacter$$RaiseHeroMissEvent
0066C14A4  mov      x0, x19
0066C14A8  mov      x1, x21
0066C14AC  bl       #0x66be50c ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroMiss
0066C14B0  b        #0x66c0bdc ; 
0066C14B4  bl       #0x382bfb8 ; 
0066C14B8  bl       #0x382bfc0 ; 
0066C14BC  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$RecoverHp
; RVA 0x66C1850; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C1850  sub      sp, sp, #0xd0
0066C1854  stp      x30, x25, [sp, #0x90]
0066C1858  stp      x24, x23, [sp, #0xa0]
0066C185C  stp      x22, x21, [sp, #0xb0]
0066C1860  stp      x20, x19, [sp, #0xc0]
0066C1864  mrs      x23, tpidr_el0
0066C1868  ldr      x8, [x23, #0x28]
0066C186C  adrp     x20, #0x959a000
0066C1870  adrp     x24, #0x8f11000
0066C1874  mov      x22, x2
0066C1878  str      x8, [sp, #0x88]
0066C187C  ldrb     w8, [x20, #0x244]
0066C1880  ldr      x24, [x24, #0xd28]
0066C1884  mov      w21, w1
0066C1888  mov      x19, x0
0066C188C  tbnz     w8, #0, #0x66c18bc
0066C1890  adrp     x0, #0x8f0d000
0066C1894  ldr      x0, [x0, #0x1d8]
0066C1898  bl       #0x382bd14 ; 
0066C189C  adrp     x0, #0x8f11000
0066C18A0  ldr      x0, [x0, #0xd28]
0066C18A4  bl       #0x382bd14 ; 
0066C18A8  adrp     x0, #0x8f11000
0066C18AC  ldr      x0, [x0, #0x9c8]
0066C18B0  bl       #0x382bd14 ; 
0066C18B4  mov      w8, #1
0066C18B8  strb     w8, [x20, #0x244]
0066C18BC  ldr      x3, [x24]
0066C18C0  ldrb     w8, [x3, #0x53]
0066C18C4  tbnz     w8, #5, #0x66c1914
0066C18C8  cmp      w21, #1
0066C18CC  strb     wzr, [sp, #0x4c]
0066C18D0  str      wzr, [sp, #0x48]
0066C18D4  b.lt     #0x66c1b28
0066C18D8  adrp     x24, #0x9591000
0066C18DC  ldrb     w8, [x24, #0xa4b]
0066C18E0  cbnz     w8, #0x66c18f8
0066C18E4  adrp     x0, #0x8ee5000
0066C18E8  ldr      x0, [x0, #0xb28]
0066C18EC  bl       #0x382bd14 ; 
0066C18F0  mov      w8, #1
0066C18F4  strb     w8, [x24, #0xa4b]
0066C18F8  adrp     x25, #0x8ee5000
0066C18FC  ldr      x25, [x25, #0xb28]
0066C1900  ldr      x1, [x25]
0066C1904  ldrb     w8, [x1, #0x53]
0066C1908  tbnz     w8, #5, #0x66c193c
0066C190C  ldr      x0, [x19, #0x20]
0066C1910  b        #0x66c1948 ; 
0066C1914  ldr      x8, [x22, #0x10]
0066C1918  ldr      q0, [x22]
0066C191C  ldr      x9, [x3, #0x60]
0066C1920  add      x2, sp, #0x50
0066C1924  mov      x0, x19
0066C1928  mov      w1, w21
0066C192C  str      x8, [sp, #0x60]
0066C1930  str      q0, [sp, #0x50]
0066C1934  blr      x9
0066C1938  b        #0x66c1b28 ; 
0066C193C  ldr      x8, [x1, #0x60]
0066C1940  mov      x0, x19
0066C1944  blr      x8
0066C1948  cbz      x0, #0x66c1b50
0066C194C  mov      x1, xzr
0066C1950  bl       #0x69fa994 ; HotFix.BattleLogic.BattleWorldContext$$GetHurtDataArray
0066C1954  ldrb     w8, [x24, #0xa4b]
0066C1958  mov      x20, x0
0066C195C  cbnz     w8, #0x66c1974
0066C1960  adrp     x0, #0x8ee5000
0066C1964  ldr      x0, [x0, #0xb28]
0066C1968  bl       #0x382bd14 ; 
0066C196C  mov      w8, #1
0066C1970  strb     w8, [x24, #0xa4b]
0066C1974  ldr      x1, [x25]
0066C1978  ldrb     w8, [x1, #0x53]
0066C197C  tbnz     w8, #5, #0x66c1988
0066C1980  ldr      x0, [x19, #0x20]
0066C1984  b        #0x66c1994 ; 
0066C1988  ldr      x8, [x1, #0x60]
0066C198C  mov      x0, x19
0066C1990  blr      x8
0066C1994  cbz      x0, #0x66c1b50
0066C1998  mov      x1, xzr
0066C199C  bl       #0x69fa094 ; HotFix.BattleLogic.BattleWorldContext$$get_ReCoverAttributeNameTable
0066C19A0  adrp     x8, #0x8f0d000
0066C19A4  ldr      q0, [x22]
0066C19A8  ldr      x9, [x22, #0x10]
0066C19AC  ldr      x8, [x8, #0x1d8]
0066C19B0  mov      x22, x0
0066C19B4  str      q0, [sp, #0x30]
0066C19B8  str      x9, [sp, #0x40]
0066C19BC  ldr      x8, [x8]
0066C19C0  ldr      w9, [x8, #0xe0]
0066C19C4  cbnz     w9, #0x66c19d0
0066C19C8  mov      x0, x8
0066C19CC  bl       #0x382be8c ; 
0066C19D0  ldr      q0, [sp, #0x30]
0066C19D4  ldr      x8, [sp, #0x40]
0066C19D8  add      x3, sp, #0x10
0066C19DC  mov      w0, w21
0066C19E0  mov      x1, x22
0066C19E4  mov      x2, x20
0066C19E8  mov      x4, xzr
0066C19EC  str      q0, [sp, #0x10]
0066C19F0  str      x8, [sp, #0x20]
0066C19F4  bl       #0x66916e4 ; HotFix.BattleLogic.AttributeDataUtils$$ToSimpleHurtDataAttribute
0066C19F8  ldrb     w8, [x24, #0xa4b]
0066C19FC  cbnz     w8, #0x66c1a14
0066C1A00  adrp     x0, #0x8ee5000
0066C1A04  ldr      x0, [x0, #0xb28]
0066C1A08  bl       #0x382bd14 ; 
0066C1A0C  mov      w8, #1
0066C1A10  strb     w8, [x24, #0xa4b]
0066C1A14  ldr      x1, [x25]
0066C1A18  ldrb     w8, [x1, #0x53]
0066C1A1C  tbnz     w8, #5, #0x66c1a28
0066C1A20  ldr      x21, [x19, #0x20]
0066C1A24  b        #0x66c1a38 ; 
0066C1A28  ldr      x8, [x1, #0x60]
0066C1A2C  mov      x0, x19
0066C1A30  blr      x8
0066C1A34  mov      x21, x0
0066C1A38  cbz      x21, #0x66c1b50
0066C1A3C  adrp     x22, #0x9591000
0066C1A40  ldrb     w8, [x22, #0xa4c]
0066C1A44  cbnz     w8, #0x66c1a5c
0066C1A48  adrp     x0, #0x8ee5000
0066C1A4C  ldr      x0, [x0, #0xb30]
0066C1A50  bl       #0x382bd14 ; 
0066C1A54  mov      w8, #1
0066C1A58  strb     w8, [x22, #0xa4c]
0066C1A5C  adrp     x8, #0x8ee5000
0066C1A60  ldr      x8, [x8, #0xb30]
0066C1A64  ldr      x1, [x8]
0066C1A68  ldrb     w8, [x1, #0x53]
0066C1A6C  tbnz     w8, #5, #0x66c1a78
0066C1A70  ldr      x0, [x21, #0x210]
0066C1A74  b        #0x66c1a84 ; 
0066C1A78  ldr      x8, [x1, #0x60]
0066C1A7C  mov      x0, x21
0066C1A80  blr      x8
0066C1A84  cbz      x0, #0x66c1b50
0066C1A88  adrp     x8, #0x8f11000
0066C1A8C  ldr      x8, [x8, #0x9c8]
0066C1A90  ldr      x1, [x8]
0066C1A94  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0066C1A98  mov      x21, x0
0066C1A9C  add      x4, sp, #0x4c
0066C1AA0  add      x5, sp, #0x48
0066C1AA4  add      x6, sp, #0x70
0066C1AA8  mov      x0, x19
0066C1AAC  mov      x1, x21
0066C1AB0  mov      x2, x20
0066C1AB4  mov      w3, wzr
0066C1AB8  mov      x7, xzr
0066C1ABC  stp      xzr, xzr, [sp, #0x78]
0066C1AC0  str      xzr, [sp, #0x70]
0066C1AC4  str      wzr, [sp]
0066C1AC8  bl       #0x66bca88 ; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitUpdateHP
0066C1ACC  cbz      x21, #0x66c1b50
0066C1AD0  mov      x0, x21
0066C1AD4  mov      x1, xzr
0066C1AD8  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066C1ADC  ldrb     w8, [x24, #0xa4b]
0066C1AE0  cbnz     w8, #0x66c1af8
0066C1AE4  adrp     x0, #0x8ee5000
0066C1AE8  ldr      x0, [x0, #0xb28]
0066C1AEC  bl       #0x382bd14 ; 
0066C1AF0  mov      w8, #1
0066C1AF4  strb     w8, [x24, #0xa4b]
0066C1AF8  ldr      x1, [x25]
0066C1AFC  ldrb     w8, [x1, #0x53]
0066C1B00  tbnz     w8, #5, #0x66c1b0c
0066C1B04  ldr      x0, [x19, #0x20]
0066C1B08  b        #0x66c1b18 ; 
0066C1B0C  ldr      x8, [x1, #0x60]
0066C1B10  mov      x0, x19
0066C1B14  blr      x8
0066C1B18  cbz      x0, #0x66c1b50
0066C1B1C  mov      x1, x20
0066C1B20  mov      x2, xzr
0066C1B24  bl       #0x69faa68 ; HotFix.BattleLogic.BattleWorldContext$$PushHurtDataArray
0066C1B28  ldr      x8, [x23, #0x28]
0066C1B2C  ldr      x9, [sp, #0x88]
0066C1B30  cmp      x8, x9
0066C1B34  b.ne     #0x66c1b54
0066C1B38  ldp      x20, x19, [sp, #0xc0]
0066C1B3C  ldp      x22, x21, [sp, #0xb0]
0066C1B40  ldp      x24, x23, [sp, #0xa0]
0066C1B44  ldp      x30, x25, [sp, #0x90]
0066C1B48  add      sp, sp, #0xd0
0066C1B4C  ret      
0066C1B50  bl       #0x382bfb8 ; 
0066C1B54  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$Heal
; RVA 0x66C269C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C269C  sub      sp, sp, #0x70
0066C26A0  stp      x30, x23, [sp, #0x40]
0066C26A4  stp      x22, x21, [sp, #0x50]
0066C26A8  stp      x20, x19, [sp, #0x60]
0066C26AC  adrp     x22, #0x959a000
0066C26B0  adrp     x23, #0x8f11000
0066C26B4  ldrb     w8, [x22, #0x245]
0066C26B8  ldr      x23, [x23, #0xda8]
0066C26BC  mov      x20, x2
0066C26C0  mov      x21, x1
0066C26C4  mov      x19, x0
0066C26C8  tbnz     w8, #0, #0x66c26e0
0066C26CC  adrp     x0, #0x8f11000
0066C26D0  ldr      x0, [x0, #0xda8]
0066C26D4  bl       #0x382bd14 ; 
0066C26D8  mov      w8, #1
0066C26DC  strb     w8, [x22, #0x245]
0066C26E0  ldr      x3, [x23]
0066C26E4  ldrb     w8, [x3, #0x53]
0066C26E8  tbnz     w8, #5, #0x66c271c
0066C26EC  mov      x0, x21
0066C26F0  mov      x1, xzr
0066C26F4  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
0066C26F8  ldr      q0, [x20]
0066C26FC  ldr      x8, [x20, #0x10]
0066C2700  mov      w1, w0
0066C2704  mov      x2, sp
0066C2708  mov      x0, x19
0066C270C  str      q0, [sp]
0066C2710  str      x8, [sp, #0x10]
0066C2714  bl       #0x66c1850 ; HotFix.BattleLogic.CharacterComponentOnHit$$RecoverHp
0066C2718  b        #0x66c2740 ; 
0066C271C  ldr      x8, [x20, #0x10]
0066C2720  ldr      q0, [x20]
0066C2724  ldr      x9, [x3, #0x60]
0066C2728  add      x2, sp, #0x20
0066C272C  mov      x0, x19
0066C2730  mov      x1, x21
0066C2734  str      x8, [sp, #0x30]
0066C2738  str      q0, [sp, #0x20]
0066C273C  blr      x9
0066C2740  ldp      x20, x19, [sp, #0x60]
0066C2744  ldp      x22, x21, [sp, #0x50]
0066C2748  ldp      x30, x23, [sp, #0x40]
0066C274C  add      sp, sp, #0x70
0066C2750  ret      

; HotFix.BattleLogic.CharacterComponentOnHit$$HealSelfByPercent
; RVA 0x66BC928; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BC928  sub      sp, sp, #0x80
0066BC92C  str      x30, [sp, #0x40]
0066BC930  stp      x24, x23, [sp, #0x50]
0066BC934  stp      x22, x21, [sp, #0x60]
0066BC938  stp      x20, x19, [sp, #0x70]
0066BC93C  adrp     x23, #0x959a000
0066BC940  adrp     x24, #0x8f11000
0066BC944  ldrb     w8, [x23, #0x246]
0066BC948  ldr      x24, [x24, #0xb18]
0066BC94C  mov      x20, x3
0066BC950  mov      x21, x2
0066BC954  mov      x22, x1
0066BC958  mov      x19, x0
0066BC95C  tbnz     w8, #0, #0x66bc980
0066BC960  adrp     x0, #0x8f11000
0066BC964  ldr      x0, [x0, #0xb18]
0066BC968  bl       #0x382bd14 ; 
0066BC96C  adrp     x0, #0x8ee6000
0066BC970  ldr      x0, [x0, #0x600]
0066BC974  bl       #0x382bd14 ; 
0066BC978  mov      w8, #1
0066BC97C  strb     w8, [x23, #0x246]
0066BC980  ldr      x4, [x24]
0066BC984  ldrb     w8, [x4, #0x53]
0066BC988  tbnz     w8, #5, #0x66bc9a8
0066BC98C  adrp     x8, #0x8ee6000
0066BC990  ldr      x8, [x8, #0x600]
0066BC994  ldr      x1, [x8]
0066BC998  ldrb     w8, [x1, #0x53]
0066BC99C  tbnz     w8, #5, #0x66bc9d4
0066BC9A0  ldr      x23, [x19, #0x38]
0066BC9A4  b        #0x66bc9e4 ; 
0066BC9A8  ldr      x8, [x20, #0x10]
0066BC9AC  ldr      q0, [x20]
0066BC9B0  ldr      x9, [x4, #0x60]
0066BC9B4  add      x3, sp, #0x20
0066BC9B8  mov      x0, x19
0066BC9BC  mov      x1, x22
0066BC9C0  mov      x2, x21
0066BC9C4  str      x8, [sp, #0x30]
0066BC9C8  str      q0, [sp, #0x20]
0066BC9CC  blr      x9
0066BC9D0  b        #0x66bca6c ; 
0066BC9D4  ldr      x8, [x1, #0x60]
0066BC9D8  mov      x0, x19
0066BC9DC  blr      x8
0066BC9E0  mov      x23, x0
0066BC9E4  cbz      x23, #0x66bca84
0066BC9E8  adrp     x24, #0x9591000
0066BC9EC  ldrb     w8, [x24, #0xa7f]
0066BC9F0  cbnz     w8, #0x66bca08
0066BC9F4  adrp     x0, #0x8ee6000
0066BC9F8  ldr      x0, [x0, #0x2d8]
0066BC9FC  bl       #0x382bd14 ; 
0066BCA00  mov      w8, #1
0066BCA04  strb     w8, [x24, #0xa7f]
0066BCA08  adrp     x8, #0x8ee6000
0066BCA0C  ldr      x8, [x8, #0x2d8]
0066BCA10  ldr      x1, [x8]
0066BCA14  ldrb     w8, [x1, #0x53]
0066BCA18  tbnz     w8, #5, #0x66bca24
0066BCA1C  ldr      x0, [x23, #0x178]
0066BCA20  b        #0x66bca30 ; 
0066BCA24  ldr      x8, [x1, #0x60]
0066BCA28  mov      x0, x23
0066BCA2C  blr      x8
0066BCA30  cbz      x0, #0x66bca84
0066BCA34  mov      x1, xzr
0066BCA38  bl       #0x6b3c490 ; HotFix.Common.AttributeData$$GetHpMax
0066BCA3C  sxtw     x8, w0
0066BCA40  madd     x0, x8, x21, x22
0066BCA44  mov      x1, xzr
0066BCA48  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
0066BCA4C  ldr      q0, [x20]
0066BCA50  ldr      x8, [x20, #0x10]
0066BCA54  mov      w1, w0
0066BCA58  mov      x2, sp
0066BCA5C  mov      x0, x19
0066BCA60  str      q0, [sp]
0066BCA64  str      x8, [sp, #0x10]
0066BCA68  bl       #0x66c1850 ; HotFix.BattleLogic.CharacterComponentOnHit$$RecoverHp
0066BCA6C  ldp      x20, x19, [sp, #0x70]
0066BCA70  ldp      x22, x21, [sp, #0x60]
0066BCA74  ldp      x24, x23, [sp, #0x50]
0066BCA78  ldr      x30, [sp, #0x40]
0066BCA7C  add      sp, sp, #0x80
0066BCA80  ret      
0066BCA84  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$SetDyingHp
; RVA 0x66C2754; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C2754  str      x30, [sp, #-0x30]!
0066C2758  stp      x22, x21, [sp, #0x10]
0066C275C  stp      x20, x19, [sp, #0x20]
0066C2760  adrp     x21, #0x959a000
0066C2764  adrp     x22, #0x8f11000
0066C2768  ldrb     w8, [x21, #0x247]
0066C276C  ldr      x22, [x22, #0xdb0]
0066C2770  mov      w19, w1
0066C2774  mov      x20, x0
0066C2778  tbnz     w8, #0, #0x66c279c
0066C277C  adrp     x0, #0x8f11000
0066C2780  ldr      x0, [x0, #0xdb0]
0066C2784  bl       #0x382bd14 ; 
0066C2788  adrp     x0, #0x8ee6000
0066C278C  ldr      x0, [x0, #0x608]
0066C2790  bl       #0x382bd14 ; 
0066C2794  mov      w8, #1
0066C2798  strb     w8, [x21, #0x247]
0066C279C  ldr      x2, [x22]
0066C27A0  ldrb     w8, [x2, #0x53]
0066C27A4  tbnz     w8, #5, #0x66c27c4
0066C27A8  adrp     x8, #0x8ee6000
0066C27AC  ldr      x8, [x8, #0x608]
0066C27B0  ldr      x1, [x8]
0066C27B4  ldrb     w8, [x1, #0x53]
0066C27B8  tbnz     w8, #5, #0x66c27e0
0066C27BC  ldr      x0, [x20, #0x30]
0066C27C0  b        #0x66c27ec ; 
0066C27C4  ldr      x3, [x2, #0x60]
0066C27C8  mov      x0, x20
0066C27CC  mov      w1, w19
0066C27D0  ldp      x20, x19, [sp, #0x20]
0066C27D4  ldp      x22, x21, [sp, #0x10]
0066C27D8  ldr      x30, [sp], #0x30
0066C27DC  br       x3
0066C27E0  ldr      x8, [x1, #0x60]
0066C27E4  mov      x0, x20
0066C27E8  blr      x8
0066C27EC  cbz      x0, #0x66c281c
0066C27F0  ldr      x8, [x0]
0066C27F4  ldr      x9, [x8, #0x498]
0066C27F8  ldr      x1, [x8, #0x4a0]
0066C27FC  blr      x9
0066C2800  cmp      w0, w19
0066C2804  csel     w8, w0, w19, lt
0066C2808  str      w8, [x20, #0xa0]
0066C280C  ldp      x20, x19, [sp, #0x20]
0066C2810  ldp      x22, x21, [sp, #0x10]
0066C2814  ldr      x30, [sp], #0x30
0066C2818  ret      
0066C281C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$OnHitUpdateHP
; RVA 0x66BCA88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BCA88  sub      sp, sp, #0x100
0066BCA8C  stp      x29, x30, [sp, #0xa0]
0066BCA90  stp      x28, x27, [sp, #0xb0]
0066BCA94  stp      x26, x25, [sp, #0xc0]
0066BCA98  stp      x24, x23, [sp, #0xd0]
0066BCA9C  stp      x22, x21, [sp, #0xe0]
0066BCAA0  stp      x20, x19, [sp, #0xf0]
0066BCAA4  mrs      x29, tpidr_el0
0066BCAA8  ldr      x8, [x29, #0x28]
0066BCAAC  adrp     x28, #0x959a000
0066BCAB0  adrp     x25, #0x8f11000
0066BCAB4  mov      x19, x7
0066BCAB8  str      x8, [sp, #0x98]
0066BCABC  ldrb     w8, [x28, #0x248]
0066BCAC0  ldr      x25, [x25, #0xb20]
0066BCAC4  mov      x24, x6
0066BCAC8  mov      x20, x5
0066BCACC  mov      x23, x4
0066BCAD0  mov      w26, w3
0066BCAD4  mov      x27, x2
0066BCAD8  mov      x21, x1
0066BCADC  mov      x22, x0
0066BCAE0  tbnz     w8, #0, #0x66bcb10
0066BCAE4  adrp     x0, #0x8f11000
0066BCAE8  ldr      x0, [x0, #0xb20]
0066BCAEC  bl       #0x382bd14 ; 
0066BCAF0  adrp     x0, #0x8ee6000
0066BCAF4  ldr      x0, [x0, #0x608]
0066BCAF8  bl       #0x382bd14 ; 
0066BCAFC  adrp     x0, #0x8f11000
0066BCB00  ldr      x0, [x0, #0xb28]
0066BCB04  bl       #0x382bd14 ; 
0066BCB08  mov      w8, #1
0066BCB0C  strb     w8, [x28, #0x248]
0066BCB10  ldr      x8, [x25]
0066BCB14  ldr      w11, [sp, #0x100]
0066BCB18  ldrb     w9, [x8, #0x53]
0066BCB1C  tbnz     w9, #5, #0x66bcb44
0066BCB20  adrp     x8, #0x8ee6000
0066BCB24  ldr      x8, [x8, #0x608]
0066BCB28  strb     wzr, [sp, #0x1c]
0066BCB2C  str      w11, [sp, #0x18]
0066BCB30  ldr      x1, [x8]
0066BCB34  ldrb     w8, [x1, #0x53]
0066BCB38  tbnz     w8, #5, #0x66bcb8c
0066BCB3C  ldr      x28, [x22, #0x30]
0066BCB40  b        #0x66bcb9c ; 
0066BCB44  ldr      x9, [x24, #0x10]
0066BCB48  ldr      q0, [x24]
0066BCB4C  ldr      x10, [x8, #0x60]
0066BCB50  and      w3, w26, #1
0066BCB54  add      x6, sp, #0x80
0066BCB58  mov      x0, x22
0066BCB5C  mov      x1, x21
0066BCB60  mov      x2, x27
0066BCB64  mov      x4, x23
0066BCB68  mov      x5, x20
0066BCB6C  mov      x7, x19
0066BCB70  str      x9, [sp, #0x90]
0066BCB74  str      q0, [sp, #0x80]
0066BCB78  str      x8, [sp, #8]
0066BCB7C  str      w11, [sp]
0066BCB80  blr      x10
0066BCB84  mov      w26, w0
0066BCB88  b        #0x66bcf00 ; 
0066BCB8C  ldr      x8, [x1, #0x60]
0066BCB90  mov      x0, x22
0066BCB94  blr      x8
0066BCB98  mov      x28, x0
0066BCB9C  cbz      x28, #0x66bcf34
0066BCBA0  mov      x25, x19
0066BCBA4  adrp     x19, #0x9591000
0066BCBA8  ldrb     w8, [x19, #0xa4b]
0066BCBAC  cbnz     w8, #0x66bcbc4
0066BCBB0  adrp     x0, #0x8ee5000
0066BCBB4  ldr      x0, [x0, #0xb28]
0066BCBB8  bl       #0x382bd14 ; 
0066BCBBC  mov      w8, #1
0066BCBC0  strb     w8, [x19, #0xa4b]
0066BCBC4  adrp     x8, #0x8ee5000
0066BCBC8  ldr      x8, [x8, #0xb28]
0066BCBCC  ldr      x1, [x8]
0066BCBD0  ldrb     w8, [x1, #0x53]
0066BCBD4  tbnz     w8, #5, #0x66bcbe0
0066BCBD8  ldr      x28, [x28, #0x20]
0066BCBDC  b        #0x66bcbf0 ; 
0066BCBE0  ldr      x8, [x1, #0x60]
0066BCBE4  mov      x0, x28
0066BCBE8  blr      x8
0066BCBEC  mov      x28, x0
0066BCBF0  cbz      x28, #0x66bcf34
0066BCBF4  adrp     x19, #0x9599000
0066BCBF8  ldrb     w8, [x19, #0x4c3]
0066BCBFC  cbnz     w8, #0x66bcc14
0066BCC00  adrp     x0, #0x8f08000
0066BCC04  ldr      x0, [x0, #0xfe0]
0066BCC08  bl       #0x382bd14 ; 
0066BCC0C  mov      w8, #1
0066BCC10  strb     w8, [x19, #0x4c3]
0066BCC14  adrp     x8, #0x8f08000
0066BCC18  ldr      x8, [x8, #0xfe0]
0066BCC1C  ldr      x1, [x8]
0066BCC20  ldrb     w8, [x1, #0x53]
0066BCC24  tbnz     w8, #5, #0x66bcc44
0066BCC28  ldrb     w8, [x28, #0x120]
0066BCC2C  mov      x19, x25
0066BCC30  cbz      w8, #0x66bcc58
0066BCC34  mov      w26, wzr
0066BCC38  strb     wzr, [x23]
0066BCC3C  str      wzr, [x20]
0066BCC40  b        #0x66bcf00 ; 
0066BCC44  ldr      x8, [x1, #0x60]
0066BCC48  mov      x0, x28
0066BCC4C  blr      x8
0066BCC50  mov      x19, x25
0066BCC54  tbnz     w0, #0, #0x66bcc34
0066BCC58  add      x4, sp, #0x1c
0066BCC5C  mov      x0, x22
0066BCC60  mov      x1, x21
0066BCC64  mov      x2, x27
0066BCC68  mov      x3, x23
0066BCC6C  bl       #0x66c2820 ; HotFix.BattleLogic.CharacterComponentOnHit$$CalculateDamage
0066BCC70  mov      x27, x0
0066BCC74  str      w27, [x20]
0066BCC78  tbnz     x0, #0x20, #0x66bccb4
0066BCC7C  ldrb     w9, [x23]
0066BCC80  ldr      x8, [x24, #0x10]
0066BCC84  ldr      q0, [x24]
0066BCC88  ldr      w6, [sp, #0x18]
0066BCC8C  cmp      w9, #0
0066BCC90  cset     w3, ne
0066BCC94  add      x4, sp, #0x60
0066BCC98  mov      x0, x22
0066BCC9C  mov      x1, x21
0066BCCA0  mov      x2, x20
0066BCCA4  mov      x5, x19
0066BCCA8  str      x8, [sp, #0x70]
0066BCCAC  str      q0, [sp, #0x60]
0066BCCB0  bl       #0x66c2c94 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePreHpUpdateTriggers
0066BCCB4  cbz      x21, #0x66bcf34
0066BCCB8  adrp     x28, #0x959a000
0066BCCBC  ldrb     w8, [x28, #0x27a]
0066BCCC0  cbnz     w8, #0x66bccd8
0066BCCC4  adrp     x0, #0x8f11000
0066BCCC8  ldr      x0, [x0, #0x9f8]
0066BCCCC  bl       #0x382bd14 ; 
0066BCCD0  mov      w8, #1
0066BCCD4  strb     w8, [x28, #0x27a]
0066BCCD8  adrp     x8, #0x8f11000
0066BCCDC  ldr      x8, [x8, #0x9f8]
0066BCCE0  ldr      x1, [x8]
0066BCCE4  ldrb     w8, [x1, #0x53]
0066BCCE8  tbnz     w8, #5, #0x66bccf4
0066BCCEC  ldr      w0, [x21, #0x28]
0066BCCF0  b        #0x66bcd00 ; 
0066BCCF4  ldr      x8, [x1, #0x60]
0066BCCF8  mov      x0, x21
0066BCCFC  blr      x8
0066BCD00  cmp      w0, #1
0066BCD04  b.ne     #0x66bcd8c
0066BCD08  adrp     x19, #0x959a000
0066BCD0C  ldrb     w8, [x19, #0x27b]
0066BCD10  cbnz     w8, #0x66bcd28
0066BCD14  adrp     x0, #0x8f11000
0066BCD18  ldr      x0, [x0, #0xb30]
0066BCD1C  bl       #0x382bd14 ; 
0066BCD20  mov      w8, #1
0066BCD24  strb     w8, [x19, #0x27b]
0066BCD28  adrp     x8, #0x8f11000
0066BCD2C  ldr      x8, [x8, #0xb30]
0066BCD30  ldr      x1, [x8]
0066BCD34  ldrb     w8, [x1, #0x53]
0066BCD38  tbnz     w8, #5, #0x66bcd4c
0066BCD3C  ldrb     w8, [x21, #0xa0]
0066BCD40  mov      x19, x25
0066BCD44  cbnz     w8, #0x66bcd60
0066BCD48  b        #0x66bcd8c ; 
0066BCD4C  ldr      x8, [x1, #0x60]
0066BCD50  mov      x0, x21
0066BCD54  blr      x8
0066BCD58  mov      x19, x25
0066BCD5C  tbz      w0, #0, #0x66bcd8c
0066BCD60  mov      x0, xzr
0066BCD64  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
0066BCD68  mov      x1, x0
0066BCD6C  mov      x0, x19
0066BCD70  mov      x2, xzr
0066BCD74  bl       #0x7db81fc ; Quantum.EntityRef$$op_Inequality
0066BCD78  tbz      w0, #0, #0x66bcd8c
0066BCD7C  mov      x0, x22
0066BCD80  mov      x1, x21
0066BCD84  mov      x2, x19
0066BCD88  bl       #0x66c3de0 ; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndSetPreventEjectCountFlags
0066BCD8C  ldr      w2, [x20]
0066BCD90  ldr      w25, [sp, #0x18]
0066BCD94  and      x28, x27, #0x100000000
0066BCD98  cbz      w2, #0x66bcea8
0066BCD9C  ldr      x8, [x24, #0x10]
0066BCDA0  ldr      q0, [x24]
0066BCDA4  and      w3, w26, #1
0066BCDA8  add      x4, sp, #0x40
0066BCDAC  mov      x0, x22
0066BCDB0  mov      x1, x21
0066BCDB4  mov      x5, x19
0066BCDB8  mov      w6, w25
0066BCDBC  str      x8, [sp, #0x50]
0066BCDC0  str      q0, [sp, #0x40]
0066BCDC4  bl       #0x66c40e0 ; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateEntityHp
0066BCDC8  cbnz     x28, #0x66bcea8
0066BCDCC  adrp     x26, #0x959a000
0066BCDD0  ldrb     w8, [x26, #0x27a]
0066BCDD4  cbnz     w8, #0x66bcdec
0066BCDD8  adrp     x0, #0x8f11000
0066BCDDC  ldr      x0, [x0, #0x9f8]
0066BCDE0  bl       #0x382bd14 ; 
0066BCDE4  mov      w8, #1
0066BCDE8  strb     w8, [x26, #0x27a]
0066BCDEC  adrp     x8, #0x8f11000
0066BCDF0  ldr      x8, [x8, #0x9f8]
0066BCDF4  ldr      x1, [x8]
0066BCDF8  ldrb     w8, [x1, #0x53]
0066BCDFC  tbnz     w8, #5, #0x66bce08
0066BCE00  ldr      w0, [x21, #0x28]
0066BCE04  b        #0x66bce14 ; 
0066BCE08  ldr      x8, [x1, #0x60]
0066BCE0C  mov      x0, x21
0066BCE10  blr      x8
0066BCE14  cmp      w0, #1
0066BCE18  b.ne     #0x66bcea8
0066BCE1C  adrp     x8, #0x8ee6000
0066BCE20  ldr      x8, [x8, #0x608]
0066BCE24  ldr      x1, [x8]
0066BCE28  ldrb     w8, [x1, #0x53]
0066BCE2C  tbnz     w8, #5, #0x66bce38
0066BCE30  ldr      x0, [x22, #0x30]
0066BCE34  b        #0x66bce44 ; 
0066BCE38  ldr      x8, [x1, #0x60]
0066BCE3C  mov      x0, x22
0066BCE40  blr      x8
0066BCE44  cbz      x0, #0x66bcf34
0066BCE48  mov      x1, xzr
0066BCE4C  bl       #0x67f524c ; HotFix.BattleLogic.EntityCharacter$$UpdateBulletHurtCount
0066BCE50  mov      x0, x21
0066BCE54  mov      x1, xzr
0066BCE58  bl       #0x69007a4 ; HotFix.BattleLogic.HurtSourceData$$GetAllBulletTraits
0066BCE5C  cbz      x0, #0x66bcea8
0066BCE60  ldr      w8, [x0, #0x18]
0066BCE64  mov      x26, x0
0066BCE68  cmp      w8, #1
0066BCE6C  b.lt     #0x66bcea8
0066BCE70  adrp     x8, #0x8ee6000
0066BCE74  ldr      x8, [x8, #0x608]
0066BCE78  ldr      x1, [x8]
0066BCE7C  ldrb     w8, [x1, #0x53]
0066BCE80  tbnz     w8, #5, #0x66bce8c
0066BCE84  ldr      x0, [x22, #0x30]
0066BCE88  b        #0x66bce98 ; 
0066BCE8C  ldr      x8, [x1, #0x60]
0066BCE90  mov      x0, x22
0066BCE94  blr      x8
0066BCE98  cbz      x0, #0x66bcf34
0066BCE9C  mov      x1, x26
0066BCEA0  mov      x2, xzr
0066BCEA4  bl       #0x67f4f98 ; HotFix.BattleLogic.EntityCharacter$$UpdateBulletTraitHurtStats
0066BCEA8  ldrb     w8, [sp, #0x1c]
0066BCEAC  lsr      x9, x28, #0x20
0066BCEB0  ubfx     x26, x27, #0x20, #1
0066BCEB4  bics     wzr, w8, w9
0066BCEB8  b.eq     #0x66bcec8
0066BCEBC  mov      x0, x22
0066BCEC0  mov      x1, x21
0066BCEC4  bl       #0x66c4528 ; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePostHpUpdateEffects
0066BCEC8  ldrb     w9, [x23]
0066BCECC  ldr      x8, [x24, #0x10]
0066BCED0  ldr      q0, [x24]
0066BCED4  add      x4, sp, #0x20
0066BCED8  cmp      w9, #0
0066BCEDC  cset     w3, ne
0066BCEE0  mov      x0, x22
0066BCEE4  mov      x1, x21
0066BCEE8  mov      x2, x20
0066BCEEC  mov      x5, x19
0066BCEF0  mov      w6, w25
0066BCEF4  str      x8, [sp, #0x30]
0066BCEF8  str      q0, [sp, #0x20]
0066BCEFC  bl       #0x66c481c ; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePostHpUpdateTriggers
0066BCF00  ldr      x8, [x29, #0x28]
0066BCF04  ldr      x9, [sp, #0x98]
0066BCF08  cmp      x8, x9
0066BCF0C  b.ne     #0x66bcf38
0066BCF10  and      w0, w26, #1
0066BCF14  ldp      x20, x19, [sp, #0xf0]
0066BCF18  ldp      x22, x21, [sp, #0xe0]
0066BCF1C  ldp      x24, x23, [sp, #0xd0]
0066BCF20  ldp      x26, x25, [sp, #0xc0]
0066BCF24  ldp      x28, x27, [sp, #0xb0]
0066BCF28  ldp      x29, x30, [sp, #0xa0]
0066BCF2C  add      sp, sp, #0x100
0066BCF30  ret      
0066BCF34  bl       #0x382bfb8 ; 
0066BCF38  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CalculateDamage
; RVA 0x66C2820; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C2820  sub      sp, sp, #0x70
0066C2824  str      x30, [sp, #0x10]
0066C2828  stp      x28, x27, [sp, #0x20]
0066C282C  stp      x26, x25, [sp, #0x30]
0066C2830  stp      x24, x23, [sp, #0x40]
0066C2834  stp      x22, x21, [sp, #0x50]
0066C2838  stp      x20, x19, [sp, #0x60]
0066C283C  adrp     x24, #0x959a000
0066C2840  adrp     x25, #0x8f11000
0066C2844  ldrb     w8, [x24, #0x249]
0066C2848  ldr      x25, [x25, #0xdb8]
0066C284C  mov      x19, x4
0066C2850  mov      x20, x3
0066C2854  mov      x23, x2
0066C2858  mov      x22, x1
0066C285C  mov      x21, x0
0066C2860  tbnz     w8, #0, #0x66c2890
0066C2864  adrp     x0, #0x8f11000
0066C2868  ldr      x0, [x0, #0xdb8]
0066C286C  bl       #0x382bd14 ; 
0066C2870  adrp     x0, #0x8ee6000
0066C2874  ldr      x0, [x0, #0xe8]
0066C2878  bl       #0x382bd14 ; 
0066C287C  adrp     x0, #0x8ee6000
0066C2880  ldr      x0, [x0, #0x608]
0066C2884  bl       #0x382bd14 ; 
0066C2888  mov      w8, #1
0066C288C  strb     w8, [x24, #0x249]
0066C2890  ldr      x5, [x25]
0066C2894  ldrb     w8, [x5, #0x53]
0066C2898  tbnz     w8, #5, #0x66c28e8
0066C289C  str      wzr, [sp, #0x1c]
0066C28A0  strb     wzr, [x19]
0066C28A4  strb     wzr, [x20]
0066C28A8  cbz      x23, #0x66c2c90
0066C28AC  adrp     x24, #0x9599000
0066C28B0  ldrb     w8, [x24, #0xad8]
0066C28B4  cbnz     w8, #0x66c28cc
0066C28B8  adrp     x0, #0x8f0d000
0066C28BC  ldr      x0, [x0, #0x4e0]
0066C28C0  bl       #0x382bd14 ; 
0066C28C4  mov      w8, #1
0066C28C8  strb     w8, [x24, #0xad8]
0066C28CC  adrp     x8, #0x8f0d000
0066C28D0  ldr      x8, [x8, #0x4e0]
0066C28D4  ldr      x1, [x8]
0066C28D8  ldrb     w8, [x1, #0x53]
0066C28DC  tbnz     w8, #5, #0x66c2920
0066C28E0  ldr      w0, [x23, #0x18]
0066C28E4  b        #0x66c292c ; 
0066C28E8  ldr      x6, [x5, #0x60]
0066C28EC  mov      x0, x21
0066C28F0  mov      x1, x22
0066C28F4  mov      x2, x23
0066C28F8  mov      x3, x20
0066C28FC  mov      x4, x19
0066C2900  ldp      x20, x19, [sp, #0x60]
0066C2904  ldp      x22, x21, [sp, #0x50]
0066C2908  ldp      x24, x23, [sp, #0x40]
0066C290C  ldp      x26, x25, [sp, #0x30]
0066C2910  ldp      x28, x27, [sp, #0x20]
0066C2914  ldr      x30, [sp, #0x10]
0066C2918  add      sp, sp, #0x70
0066C291C  br       x6
0066C2920  ldr      x8, [x1, #0x60]
0066C2924  mov      x0, x23
0066C2928  blr      x8
0066C292C  cmp      w0, #1
0066C2930  b.lt     #0x66c2b0c
0066C2934  mov      x0, x23
0066C2938  mov      w1, wzr
0066C293C  mov      x2, xzr
0066C2940  bl       #0x68e84f8 ; HotFix.BattleLogic.HurtDataArray$$get_Item
0066C2944  adrp     x26, #0x9591000
0066C2948  ldrb     w8, [x26, #0xa4b]
0066C294C  ldr      w24, [x0]
0066C2950  mov      x23, x0
0066C2954  cbnz     w8, #0x66c296c
0066C2958  adrp     x0, #0x8ee5000
0066C295C  ldr      x0, [x0, #0xb28]
0066C2960  bl       #0x382bd14 ; 
0066C2964  mov      w8, #1
0066C2968  strb     w8, [x26, #0xa4b]
0066C296C  adrp     x27, #0x8ee5000
0066C2970  ldr      x27, [x27, #0xb28]
0066C2974  ldr      x1, [x27]
0066C2978  ldrb     w8, [x1, #0x53]
0066C297C  tbnz     w8, #5, #0x66c2988
0066C2980  ldr      x25, [x21, #0x20]
0066C2984  b        #0x66c2998 ; 
0066C2988  ldr      x8, [x1, #0x60]
0066C298C  mov      x0, x21
0066C2990  blr      x8
0066C2994  mov      x25, x0
0066C2998  cbz      x25, #0x66c2c90
0066C299C  adrp     x28, #0x9598000
0066C29A0  ldrb     w8, [x28, #0xfcc]
0066C29A4  cbnz     w8, #0x66c29bc
0066C29A8  adrp     x0, #0x8f06000
0066C29AC  ldr      x0, [x0, #0x470]
0066C29B0  bl       #0x382bd14 ; 
0066C29B4  mov      w8, #1
0066C29B8  strb     w8, [x28, #0xfcc]
0066C29BC  adrp     x8, #0x8f06000
0066C29C0  ldr      x8, [x8, #0x470]
0066C29C4  ldr      x1, [x8]
0066C29C8  ldrb     w8, [x1, #0x53]
0066C29CC  tbnz     w8, #5, #0x66c29d8
0066C29D0  ldr      x0, [x25, #0x200]
0066C29D4  b        #0x66c29e4 ; 
0066C29D8  ldr      x8, [x1, #0x60]
0066C29DC  mov      x0, x25
0066C29E0  blr      x8
0066C29E4  cbz      x0, #0x66c2c90
0066C29E8  mov      w1, w24
0066C29EC  mov      x2, xzr
0066C29F0  bl       #0x64dbb54 ; LocalModels.LocalModelManager$$GetCharacter_hurtType
0066C29F4  ldrb     w8, [x26, #0xa4b]
0066C29F8  mov      x24, x0
0066C29FC  cbnz     w8, #0x66c2a14
0066C2A00  adrp     x0, #0x8ee5000
0066C2A04  ldr      x0, [x0, #0xb28]
0066C2A08  bl       #0x382bd14 ; 
0066C2A0C  mov      w8, #1
0066C2A10  strb     w8, [x26, #0xa4b]
0066C2A14  ldr      x1, [x27]
0066C2A18  ldrb     w8, [x1, #0x53]
0066C2A1C  tbnz     w8, #5, #0x66c2a28
0066C2A20  ldr      x25, [x21, #0x20]
0066C2A24  b        #0x66c2a38 ; 
0066C2A28  ldr      x8, [x1, #0x60]
0066C2A2C  mov      x0, x21
0066C2A30  blr      x8
0066C2A34  mov      x25, x0
0066C2A38  cbz      x25, #0x66c2c90
0066C2A3C  adrp     x28, #0x9591000
0066C2A40  ldrb     w8, [x28, #0xa4c]
0066C2A44  cbnz     w8, #0x66c2a5c
0066C2A48  adrp     x0, #0x8ee5000
0066C2A4C  ldr      x0, [x0, #0xb30]
0066C2A50  bl       #0x382bd14 ; 
0066C2A54  mov      w8, #1
0066C2A58  strb     w8, [x28, #0xa4c]
0066C2A5C  adrp     x8, #0x8ee5000
0066C2A60  ldr      x8, [x8, #0xb30]
0066C2A64  ldr      x1, [x8]
0066C2A68  ldrb     w8, [x1, #0x53]
0066C2A6C  tbnz     w8, #5, #0x66c2a78
0066C2A70  ldr      x25, [x25, #0x210]
0066C2A74  b        #0x66c2a88 ; 
0066C2A78  ldr      x8, [x1, #0x60]
0066C2A7C  mov      x0, x25
0066C2A80  blr      x8
0066C2A84  mov      x25, x0
0066C2A88  cbz      x24, #0x66c2c90
0066C2A8C  adrp     x28, #0x959a000
0066C2A90  ldrb     w8, [x28, #0x27c]
0066C2A94  cbnz     w8, #0x66c2aac
0066C2A98  adrp     x0, #0x8f11000
0066C2A9C  ldr      x0, [x0, #0xdc0]
0066C2AA0  bl       #0x382bd14 ; 
0066C2AA4  mov      w8, #1
0066C2AA8  strb     w8, [x28, #0x27c]
0066C2AAC  adrp     x8, #0x8f11000
0066C2AB0  ldr      x8, [x8, #0xdc0]
0066C2AB4  ldr      x1, [x8]
0066C2AB8  ldrb     w8, [x1, #0x53]
0066C2ABC  tbnz     w8, #5, #0x66c2ac8
0066C2AC0  ldr      x1, [x24, #0x28]
0066C2AC4  b        #0x66c2ad8 ; 
0066C2AC8  ldr      x8, [x1, #0x60]
0066C2ACC  mov      x0, x24
0066C2AD0  blr      x8
0066C2AD4  mov      x1, x0
0066C2AD8  cbz      x25, #0x66c2c90
0066C2ADC  mov      x0, x25
0066C2AE0  mov      x2, xzr
0066C2AE4  bl       #0x6a45ed8 ; HotFix.BattleLogic.WorldElementCreator$$CreateHurt
0066C2AE8  cbz      x0, #0x66c2b0c
0066C2AEC  adrp     x25, #0x8ee6000
0066C2AF0  ldr      x25, [x25, #0x608]
0066C2AF4  mov      x24, x0
0066C2AF8  ldr      x1, [x25]
0066C2AFC  ldrb     w8, [x1, #0x53]
0066C2B00  tbnz     w8, #5, #0x66c2b18
0066C2B04  ldr      x3, [x21, #0x30]
0066C2B08  b        #0x66c2b28 ; 
0066C2B0C  mov      x8, xzr
0066C2B10  mov      x21, xzr
0066C2B14  b        #0x66c2c4c ; 
0066C2B18  ldr      x8, [x1, #0x60]
0066C2B1C  mov      x0, x21
0066C2B20  blr      x8
0066C2B24  mov      x3, x0
0066C2B28  mov      x0, x24
0066C2B2C  mov      x1, x22
0066C2B30  mov      x2, x23
0066C2B34  mov      x4, xzr
0066C2B38  bl       #0x68e0d28 ; HotFix.BattleLogic.HurtBase$$SetHurt
0066C2B3C  ldr      x8, [x24]
0066C2B40  mov      x0, x24
0066C2B44  ldp      x9, x1, [x8, #0x1d8]
0066C2B48  blr      x9
0066C2B4C  ldrb     w8, [x24, #0x69]
0066C2B50  cbz      w8, #0x66c2b84
0066C2B54  ldrb     w8, [x26, #0xa4b]
0066C2B58  cbnz     w8, #0x66c2b70
0066C2B5C  adrp     x0, #0x8ee5000
0066C2B60  ldr      x0, [x0, #0xb28]
0066C2B64  bl       #0x382bd14 ; 
0066C2B68  mov      w8, #1
0066C2B6C  strb     w8, [x26, #0xa4b]
0066C2B70  ldr      x1, [x27]
0066C2B74  ldrb     w8, [x1, #0x53]
0066C2B78  tbnz     w8, #5, #0x66c2bbc
0066C2B7C  ldr      x22, [x21, #0x20]
0066C2B80  b        #0x66c2bcc ; 
0066C2B84  add      x1, sp, #0x1c
0066C2B88  mov      x0, x24
0066C2B8C  mov      x2, xzr
0066C2B90  bl       #0x68e5c4c ; HotFix.BattleLogic.HurtBase$$Run
0066C2B94  ldrb     w8, [x24, #0x6a]
0066C2B98  mov      x0, x24
0066C2B9C  mov      x1, xzr
0066C2BA0  strb     w8, [x19]
0066C2BA4  ldrb     w8, [x24, #0x68]
0066C2BA8  strb     w8, [x20]
0066C2BAC  ldr      w21, [sp, #0x1c]
0066C2BB0  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066C2BB4  mov      x8, xzr
0066C2BB8  b        #0x66c2c4c ; 
0066C2BBC  ldr      x8, [x1, #0x60]
0066C2BC0  mov      x0, x21
0066C2BC4  blr      x8
0066C2BC8  mov      x22, x0
0066C2BCC  ldr      x1, [x25]
0066C2BD0  ldrb     w8, [x1, #0x53]
0066C2BD4  tbnz     w8, #5, #0x66c2be0
0066C2BD8  ldr      x0, [x21, #0x30]
0066C2BDC  b        #0x66c2bec ; 
0066C2BE0  ldr      x8, [x1, #0x60]
0066C2BE4  mov      x0, x21
0066C2BE8  blr      x8
0066C2BEC  cbz      x0, #0x66c2c90
0066C2BF0  adrp     x8, #0x8ee6000
0066C2BF4  ldr      x8, [x8, #0xe8]
0066C2BF8  ldr      x1, [x8]
0066C2BFC  ldrb     w8, [x1, #0x53]
0066C2C00  tbnz     w8, #5, #0x66c2c0c
0066C2C04  ldr      x3, [x0, #0x28]
0066C2C08  b        #0x66c2c18 ; 
0066C2C0C  ldr      x8, [x1, #0x60]
0066C2C10  blr      x8
0066C2C14  mov      x3, x0
0066C2C18  cbz      x22, #0x66c2c90
0066C2C1C  mov      w1, #3
0066C2C20  mov      w4, #0x10000
0066C2C24  mov      x0, x22
0066C2C28  mov      w2, wzr
0066C2C2C  mov      w5, wzr
0066C2C30  mov      w6, wzr
0066C2C34  mov      x7, xzr
0066C2C38  str      xzr, [sp, #8]
0066C2C3C  str      wzr, [sp]
0066C2C40  bl       #0x6a0ed24 ; HotFix.BattleLogic.BattleWorldContext$$ShowHoverEvent
0066C2C44  mov      x21, xzr
0066C2C48  mov      x8, #0x100000000
0066C2C4C  ldrb     w9, [x20]
0066C2C50  ldrb     w10, [x19]
0066C2C54  orr      x0, x8, x21
0066C2C58  ldp      x20, x19, [sp, #0x60]
0066C2C5C  cmp      w9, #0
0066C2C60  ldp      x22, x21, [sp, #0x50]
0066C2C64  ldp      x24, x23, [sp, #0x40]
0066C2C68  ldp      x26, x25, [sp, #0x30]
0066C2C6C  ldp      x28, x27, [sp, #0x20]
0066C2C70  ldr      x30, [sp, #0x10]
0066C2C74  cset     w8, ne
0066C2C78  cmp      w10, #0
0066C2C7C  cset     w9, ne
0066C2C80  bfi      x0, x8, #0x28, #1
0066C2C84  bfi      x0, x9, #0x30, #1
0066C2C88  add      sp, sp, #0x70
0066C2C8C  ret      
0066C2C90  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePreHpUpdateTriggers
; RVA 0x66C2C94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C2C94  sub      sp, sp, #0x110
0066C2C98  stp      x29, x30, [sp, #0xb0]
0066C2C9C  stp      x28, x27, [sp, #0xc0]
0066C2CA0  stp      x26, x25, [sp, #0xd0]
0066C2CA4  stp      x24, x23, [sp, #0xe0]
0066C2CA8  stp      x22, x21, [sp, #0xf0]
0066C2CAC  stp      x20, x19, [sp, #0x100]
0066C2CB0  mrs      x28, tpidr_el0
0066C2CB4  ldr      x8, [x28, #0x28]
0066C2CB8  adrp     x19, #0x959a000
0066C2CBC  adrp     x20, #0x8f11000
0066C2CC0  mov      w27, w6
0066C2CC4  str      x8, [sp, #0xa8]
0066C2CC8  ldrb     w8, [x19, #0x24a]
0066C2CCC  ldr      x20, [x20, #0xdc8]
0066C2CD0  mov      x26, x5
0066C2CD4  mov      x23, x4
0066C2CD8  mov      w25, w3
0066C2CDC  mov      x24, x2
0066C2CE0  mov      x21, x1
0066C2CE4  mov      x22, x0
0066C2CE8  tbnz     w8, #0, #0x66c2d6c
0066C2CEC  adrp     x0, #0x8f11000
0066C2CF0  ldr      x0, [x0, #0xdc8]
0066C2CF4  bl       #0x382bd14 ; 
0066C2CF8  adrp     x0, #0x8f07000
0066C2CFC  ldr      x0, [x0, #0xfd0]
0066C2D00  bl       #0x382bd14 ; 
0066C2D04  adrp     x0, #0x8ee6000
0066C2D08  ldr      x0, [x0, #0xd8]
0066C2D0C  bl       #0x382bd14 ; 
0066C2D10  adrp     x0, #0x8ee6000
0066C2D14  ldr      x0, [x0, #0xe8]
0066C2D18  bl       #0x382bd14 ; 
0066C2D1C  adrp     x0, #0x8ee6000
0066C2D20  ldr      x0, [x0, #0x600]
0066C2D24  bl       #0x382bd14 ; 
0066C2D28  adrp     x0, #0x8ee6000
0066C2D2C  ldr      x0, [x0, #0x608]
0066C2D30  bl       #0x382bd14 ; 
0066C2D34  adrp     x0, #0x8ee6000
0066C2D38  ldr      x0, [x0, #0x108]
0066C2D3C  bl       #0x382bd14 ; 
0066C2D40  adrp     x0, #0x8f11000
0066C2D44  ldr      x0, [x0, #0xdd0]
0066C2D48  bl       #0x382bd14 ; 
0066C2D4C  adrp     x0, #0x8f11000
0066C2D50  ldr      x0, [x0, #0xdd8]
0066C2D54  bl       #0x382bd14 ; 
0066C2D58  adrp     x0, #0x8f11000
0066C2D5C  ldr      x0, [x0, #0xde0]
0066C2D60  bl       #0x382bd14 ; 
0066C2D64  mov      w8, #1
0066C2D68  strb     w8, [x19, #0x24a]
0066C2D6C  ldr      x7, [x20]
0066C2D70  ldrb     w8, [x7, #0x53]
0066C2D74  tbnz     w8, #5, #0x66c2db8
0066C2D78  stp      xzr, xzr, [sp, #0x70]
0066C2D7C  str      xzr, [sp, #0x80]
0066C2D80  stp      xzr, xzr, [sp, #0x50]
0066C2D84  str      xzr, [sp, #0x60]
0066C2D88  ldr      w19, [x24]
0066C2D8C  adrp     x20, #0x9591000
0066C2D90  str      x26, [sp, #0x10]
0066C2D94  cmp      w19, #1
0066C2D98  b.lt     #0x66c32d4
0066C2D9C  adrp     x29, #0x8ee6000
0066C2DA0  ldr      x29, [x29, #0x608]
0066C2DA4  ldr      x1, [x29]
0066C2DA8  ldrb     w8, [x1, #0x53]
0066C2DAC  tbnz     w8, #5, #0x66c2df0
0066C2DB0  ldr      x0, [x22, #0x30]
0066C2DB4  b        #0x66c2dfc ; 
0066C2DB8  ldr      x8, [x23, #0x10]
0066C2DBC  ldr      q0, [x23]
0066C2DC0  ldr      x9, [x7, #0x60]
0066C2DC4  and      w3, w25, #1
0066C2DC8  add      x4, sp, #0x90
0066C2DCC  mov      x0, x22
0066C2DD0  mov      x1, x21
0066C2DD4  mov      x2, x24
0066C2DD8  mov      x5, x26
0066C2DDC  mov      w6, w27
0066C2DE0  str      x8, [sp, #0xa0]
0066C2DE4  str      q0, [sp, #0x90]
0066C2DE8  blr      x9
0066C2DEC  b        #0x66c3da8 ; 
0066C2DF0  ldr      x8, [x1, #0x60]
0066C2DF4  mov      x0, x22
0066C2DF8  blr      x8
0066C2DFC  cbz      x0, #0x66c3dd8
0066C2E00  ldr      w8, [x0, #0xd0]
0066C2E04  add      w8, w8, #1
0066C2E08  str      w8, [x0, #0xd0]
0066C2E0C  ldr      x1, [x29]
0066C2E10  ldrb     w8, [x1, #0x53]
0066C2E14  tbnz     w8, #5, #0x66c2e20
0066C2E18  ldr      x26, [x22, #0x30]
0066C2E1C  b        #0x66c2e30 ; 
0066C2E20  ldr      x8, [x1, #0x60]
0066C2E24  mov      x0, x22
0066C2E28  blr      x8
0066C2E2C  mov      x26, x0
0066C2E30  cbz      x21, #0x66c3dd8
0066C2E34  adrp     x19, #0x959a000
0066C2E38  ldrb     w8, [x19, #0x27d]
0066C2E3C  cbnz     w8, #0x66c2e54
0066C2E40  adrp     x0, #0x8f11000
0066C2E44  ldr      x0, [x0, #0xde8]
0066C2E48  bl       #0x382bd14 ; 
0066C2E4C  mov      w8, #1
0066C2E50  strb     w8, [x19, #0x27d]
0066C2E54  adrp     x20, #0x8f11000
0066C2E58  ldr      x20, [x20, #0xde8]
0066C2E5C  ldr      x1, [x20]
0066C2E60  ldrb     w8, [x1, #0x53]
0066C2E64  tbnz     w8, #5, #0x66c2e70
0066C2E68  ldr      x0, [x21, #0xf8]
0066C2E6C  b        #0x66c2e7c ; 
0066C2E70  ldr      x8, [x1, #0x60]
0066C2E74  mov      x0, x21
0066C2E78  blr      x8
0066C2E7C  cbz      x26, #0x66c3dd8
0066C2E80  str      x0, [x26, #0xd8]
0066C2E84  mov      x0, x22
0066C2E88  bl       #0x66c08f0 ; HotFix.BattleLogic.CharacterComponentOnHit$$ResetHurtTimestamp
0066C2E8C  adrp     x26, #0x9591000
0066C2E90  ldrb     w8, [x26, #0xa4b]
0066C2E94  cbnz     w8, #0x66c2eac
0066C2E98  adrp     x0, #0x8ee5000
0066C2E9C  ldr      x0, [x0, #0xb28]
0066C2EA0  bl       #0x382bd14 ; 
0066C2EA4  mov      w8, #1
0066C2EA8  strb     w8, [x26, #0xa4b]
0066C2EAC  adrp     x8, #0x8ee5000
0066C2EB0  ldr      x8, [x8, #0xb28]
0066C2EB4  ldr      x1, [x8]
0066C2EB8  ldrb     w8, [x1, #0x53]
0066C2EBC  tbnz     w8, #5, #0x66c2ec8
0066C2EC0  ldr      x26, [x22, #0x20]
0066C2EC4  b        #0x66c2ed8 ; 
0066C2EC8  ldr      x8, [x1, #0x60]
0066C2ECC  mov      x0, x22
0066C2ED0  blr      x8
0066C2ED4  mov      x26, x0
0066C2ED8  cbz      x26, #0x66c3dd8
0066C2EDC  adrp     x8, #0x9591000
0066C2EE0  ldrb     w8, [x8, #0xa4c]
0066C2EE4  cbnz     w8, #0x66c2f00
0066C2EE8  adrp     x0, #0x8ee5000
0066C2EEC  ldr      x0, [x0, #0xb30]
0066C2EF0  bl       #0x382bd14 ; 
0066C2EF4  mov      w8, #1
0066C2EF8  adrp     x9, #0x9591000
0066C2EFC  strb     w8, [x9, #0xa4c]
0066C2F00  adrp     x8, #0x8ee5000
0066C2F04  ldr      x8, [x8, #0xb30]
0066C2F08  ldr      x1, [x8]
0066C2F0C  ldrb     w8, [x1, #0x53]
0066C2F10  tbnz     w8, #5, #0x66c2f1c
0066C2F14  ldr      x0, [x26, #0x210]
0066C2F18  b        #0x66c2f28 ; 
0066C2F1C  ldr      x8, [x1, #0x60]
0066C2F20  mov      x0, x26
0066C2F24  blr      x8
0066C2F28  cbz      x0, #0x66c3dd8
0066C2F2C  adrp     x8, #0x8f11000
0066C2F30  ldr      x8, [x8, #0xde0]
0066C2F34  ldr      x1, [x8]
0066C2F38  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C2F3C  adrp     x8, #0x8ee6000
0066C2F40  ldr      x8, [x8, #0x600]
0066C2F44  mov      x26, x0
0066C2F48  ldr      x1, [x8]
0066C2F4C  ldrb     w8, [x1, #0x53]
0066C2F50  tbnz     w8, #5, #0x66c2f5c
0066C2F54  ldr      x0, [x22, #0x38]
0066C2F58  b        #0x66c2f68 ; 
0066C2F5C  ldr      x8, [x1, #0x60]
0066C2F60  mov      x0, x22
0066C2F64  blr      x8
0066C2F68  cbz      x0, #0x66c3dd8
0066C2F6C  add      x8, sp, #0x18
0066C2F70  mov      x1, xzr
0066C2F74  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C2F78  ldur     q0, [sp, #0x18]
0066C2F7C  ldr      x8, [sp, #0x28]
0066C2F80  str      q0, [sp, #0x30]
0066C2F84  str      x8, [sp, #0x40]
0066C2F88  cbz      x26, #0x66c3dd8
0066C2F8C  ldr      x8, [sp, #0x40]
0066C2F90  ldr      q0, [sp, #0x30]
0066C2F94  str      x8, [x26, #0x30]
0066C2F98  str      q0, [x26, #0x20]
0066C2F9C  ldr      w8, [x24]
0066C2FA0  str      w8, [x26, #0x50]
0066C2FA4  ldr      x1, [x29]
0066C2FA8  ldrb     w8, [x1, #0x53]
0066C2FAC  tbnz     w8, #5, #0x66c2fb8
0066C2FB0  ldr      x0, [x22, #0x30]
0066C2FB4  b        #0x66c2fc4 ; 
0066C2FB8  ldr      x8, [x1, #0x60]
0066C2FBC  mov      x0, x22
0066C2FC0  blr      x8
0066C2FC4  cbz      x0, #0x66c3dd8
0066C2FC8  adrp     x8, #0x8ee6000
0066C2FCC  ldr      x8, [x8, #0xe8]
0066C2FD0  ldr      x1, [x8]
0066C2FD4  ldrb     w8, [x1, #0x53]
0066C2FD8  tbnz     w8, #5, #0x66c2fe4
0066C2FDC  ldr      x0, [x0, #0x28]
0066C2FE0  b        #0x66c2fec ; 
0066C2FE4  ldr      x8, [x1, #0x60]
0066C2FE8  blr      x8
0066C2FEC  str      x0, [x26, #0x48]
0066C2FF0  ldrb     w8, [x19, #0x27d]
0066C2FF4  cbnz     w8, #0x66c300c
0066C2FF8  adrp     x0, #0x8f11000
0066C2FFC  ldr      x0, [x0, #0xde8]
0066C3000  bl       #0x382bd14 ; 
0066C3004  mov      w8, #1
0066C3008  strb     w8, [x19, #0x27d]
0066C300C  ldr      x1, [x20]
0066C3010  ldrb     w8, [x1, #0x53]
0066C3014  tbnz     w8, #5, #0x66c3020
0066C3018  ldr      x0, [x21, #0xf8]
0066C301C  b        #0x66c302c ; 
0066C3020  ldr      x8, [x1, #0x60]
0066C3024  mov      x0, x21
0066C3028  blr      x8
0066C302C  str      x0, [x26, #0x38]
0066C3030  ldr      x1, [x29]
0066C3034  adrp     x20, #0x9591000
0066C3038  ldrb     w8, [x1, #0x53]
0066C303C  tbnz     w8, #5, #0x66c3048
0066C3040  ldr      x0, [x22, #0x30]
0066C3044  b        #0x66c3054 ; 
0066C3048  ldr      x8, [x1, #0x60]
0066C304C  mov      x0, x22
0066C3050  blr      x8
0066C3054  cbz      x0, #0x66c3dd8
0066C3058  ldr      w8, [x0, #0xd0]
0066C305C  adrp     x19, #0x959a000
0066C3060  str      w8, [x26, #0x54]
0066C3064  ldrb     w8, [x19, #0x27a]
0066C3068  cbnz     w8, #0x66c3080
0066C306C  adrp     x0, #0x8f11000
0066C3070  ldr      x0, [x0, #0x9f8]
0066C3074  bl       #0x382bd14 ; 
0066C3078  mov      w8, #1
0066C307C  strb     w8, [x19, #0x27a]
0066C3080  adrp     x8, #0x8f11000
0066C3084  ldr      x8, [x8, #0x9f8]
0066C3088  ldr      x1, [x8]
0066C308C  ldrb     w8, [x1, #0x53]
0066C3090  tbnz     w8, #5, #0x66c309c
0066C3094  ldr      w0, [x21, #0x28]
0066C3098  b        #0x66c30a8 ; 
0066C309C  ldr      x8, [x1, #0x60]
0066C30A0  mov      x0, x21
0066C30A4  blr      x8
0066C30A8  str      w0, [x26, #0x58]
0066C30AC  adrp     x19, #0x959a000
0066C30B0  ldrb     w8, [x19, #0x27e]
0066C30B4  cbnz     w8, #0x66c30cc
0066C30B8  adrp     x0, #0x8f11000
0066C30BC  ldr      x0, [x0, #0xdf0]
0066C30C0  bl       #0x382bd14 ; 
0066C30C4  mov      w8, #1
0066C30C8  strb     w8, [x19, #0x27e]
0066C30CC  adrp     x8, #0x8f11000
0066C30D0  ldr      x8, [x8, #0xdf0]
0066C30D4  ldr      x1, [x8]
0066C30D8  ldrb     w8, [x1, #0x53]
0066C30DC  tbnz     w8, #5, #0x66c30e8
0066C30E0  ldr      x0, [x21, #0x118]
0066C30E4  b        #0x66c30f4 ; 
0066C30E8  ldr      x8, [x1, #0x60]
0066C30EC  mov      x0, x21
0066C30F0  blr      x8
0066C30F4  str      x0, [x26, #0x60]
0066C30F8  ldr      x1, [x29]
0066C30FC  mov      w19, w27
0066C3100  ldrb     w8, [x1, #0x53]
0066C3104  tbnz     w8, #5, #0x66c3110
0066C3108  ldr      x27, [x22, #0x30]
0066C310C  b        #0x66c3120 ; 
0066C3110  ldr      x8, [x1, #0x60]
0066C3114  mov      x0, x22
0066C3118  blr      x8
0066C311C  mov      x27, x0
0066C3120  cbz      x27, #0x66c3dd8
0066C3124  ldrb     w8, [x20, #0xa86]
0066C3128  cbnz     w8, #0x66c314c
0066C312C  adrp     x0, #0x8ee6000
0066C3130  ldr      x0, [x0, #0x318]
0066C3134  bl       #0x382bd14 ; 
0066C3138  adrp     x0, #0x8ee3000
0066C313C  ldr      x0, [x0, #0xf18]
0066C3140  bl       #0x382bd14 ; 
0066C3144  mov      w8, #1
0066C3148  strb     w8, [x20, #0xa86]
0066C314C  adrp     x8, #0x8ee6000
0066C3150  ldr      x8, [x8, #0x318]
0066C3154  ldr      x2, [x8]
0066C3158  ldrb     w8, [x2, #0x53]
0066C315C  tbnz     w8, #5, #0x66c3180
0066C3160  ldr      x0, [x27, #0x190]
0066C3164  cbz      x0, #0x66c31e8
0066C3168  adrp     x8, #0x8ee3000
0066C316C  ldr      x8, [x8, #0xf18]
0066C3170  mov      w1, #3
0066C3174  ldr      x2, [x8]
0066C3178  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066C317C  b        #0x66c3190 ; 
0066C3180  ldr      x8, [x2, #0x60]
0066C3184  mov      w1, #3
0066C3188  mov      x0, x27
0066C318C  blr      x8
0066C3190  mov      w27, w19
0066C3194  tbz      w0, #0, #0x66c3204
0066C3198  ldr      x1, [x29]
0066C319C  ldrb     w8, [x1, #0x53]
0066C31A0  tbnz     w8, #5, #0x66c31ac
0066C31A4  ldr      x0, [x22, #0x30]
0066C31A8  b        #0x66c31b8 ; 
0066C31AC  ldr      x8, [x1, #0x60]
0066C31B0  mov      x0, x22
0066C31B4  blr      x8
0066C31B8  cbz      x0, #0x66c3dd8
0066C31BC  ldr      x0, [x0, #0x150]
0066C31C0  cbz      x0, #0x66c3dd8
0066C31C4  mov      x1, x26
0066C31C8  mov      x2, xzr
0066C31CC  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066C31D0  tbz      w0, #0, #0x66c3204
0066C31D4  ldr      x1, [x29]
0066C31D8  ldrb     w8, [x1, #0x53]
0066C31DC  tbnz     w8, #5, #0x66c31f0
0066C31E0  ldr      x0, [x22, #0x30]
0066C31E4  b        #0x66c31fc ; 
0066C31E8  mov      w27, w19
0066C31EC  b        #0x66c3204 ; 
0066C31F0  ldr      x8, [x1, #0x60]
0066C31F4  mov      x0, x22
0066C31F8  blr      x8
0066C31FC  cbz      x0, #0x66c3dd8
0066C3200  str      wzr, [x0, #0xd0]
0066C3204  ldr      x1, [x29]
0066C3208  ldrb     w8, [x1, #0x53]
0066C320C  tbnz     w8, #5, #0x66c3218
0066C3210  ldr      x0, [x22, #0x30]
0066C3214  b        #0x66c3224 ; 
0066C3218  ldr      x8, [x1, #0x60]
0066C321C  mov      x0, x22
0066C3220  blr      x8
0066C3224  cbz      x0, #0x66c3dd8
0066C3228  adrp     x8, #0x8ee6000
0066C322C  ldr      x8, [x8, #0xd8]
0066C3230  ldr      x1, [x8]
0066C3234  ldrb     w8, [x1, #0x53]
0066C3238  tbnz     w8, #5, #0x66c3244
0066C323C  ldr      x0, [x0, #0x38]
0066C3240  b        #0x66c324c ; 
0066C3244  ldr      x8, [x1, #0x60]
0066C3248  blr      x8
0066C324C  cbz      x0, #0x66c3dd8
0066C3250  mov      x1, xzr
0066C3254  bl       #0x45616a8 ; 
0066C3258  tbz      w0, #0, #0x66c3298
0066C325C  mov      x0, x22
0066C3260  mov      x1, x26
0066C3264  bl       #0x66c4d6c ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroHurt
0066C3268  ldr      x1, [x29]
0066C326C  ldrb     w8, [x1, #0x53]
0066C3270  tbnz     w8, #5, #0x66c327c
0066C3274  ldr      x0, [x22, #0x30]
0066C3278  b        #0x66c3288 ; 
0066C327C  ldr      x8, [x1, #0x60]
0066C3280  mov      x0, x22
0066C3284  blr      x8
0066C3288  cbz      x0, #0x66c3dd8
0066C328C  mov      x1, x26
0066C3290  mov      x2, xzr
0066C3294  bl       #0x67e4004 ; HotFix.BattleLogic.EntityCharacter$$RaiseHeroHurtEvent
0066C3298  ldr      x1, [x29]
0066C329C  ldrb     w8, [x1, #0x53]
0066C32A0  tbnz     w8, #5, #0x66c32ac
0066C32A4  ldr      x0, [x22, #0x30]
0066C32A8  b        #0x66c32b8 ; 
0066C32AC  ldr      x8, [x1, #0x60]
0066C32B0  mov      x0, x22
0066C32B4  blr      x8
0066C32B8  cbz      x0, #0x66c3dd8
0066C32BC  adrp     x8, #0x8f07000
0066C32C0  ldr      x8, [x8, #0xfd0]
0066C32C4  mov      w1, #0x2f
0066C32C8  ldr      x2, [x8]
0066C32CC  bl       #0x60b34ec ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0066C32D0  ldr      w19, [x24]
0066C32D4  adrp     x8, #0x8ee6000
0066C32D8  ldr      x8, [x8, #0x608]
0066C32DC  ldr      x1, [x8]
0066C32E0  ldrb     w8, [x1, #0x53]
0066C32E4  tbnz     w8, #5, #0x66c32f0
0066C32E8  ldr      x0, [x22, #0x30]
0066C32EC  b        #0x66c32fc ; 
0066C32F0  ldr      x8, [x1, #0x60]
0066C32F4  mov      x0, x22
0066C32F8  blr      x8
0066C32FC  str      w27, [sp, #0xc]
0066C3300  cbz      x0, #0x66c3dd8
0066C3304  ldr      x8, [x0]
0066C3308  ldr      x9, [x8, #0x498]
0066C330C  ldr      x1, [x8, #0x4a0]
0066C3310  blr      x9
0066C3314  cmp      w19, w0
0066C3318  b.lt     #0x66c3da8
0066C331C  adrp     x19, #0x9591000
0066C3320  ldrb     w8, [x19, #0xa4b]
0066C3324  cbnz     w8, #0x66c333c
0066C3328  adrp     x0, #0x8ee5000
0066C332C  ldr      x0, [x0, #0xb28]
0066C3330  bl       #0x382bd14 ; 
0066C3334  mov      w8, #1
0066C3338  strb     w8, [x19, #0xa4b]
0066C333C  adrp     x8, #0x8ee5000
0066C3340  ldr      x8, [x8, #0xb28]
0066C3344  adrp     x19, #0x9591000
0066C3348  ldr      x1, [x8]
0066C334C  ldrb     w8, [x1, #0x53]
0066C3350  tbnz     w8, #5, #0x66c335c
0066C3354  ldr      x26, [x22, #0x20]
0066C3358  b        #0x66c336c ; 
0066C335C  ldr      x8, [x1, #0x60]
0066C3360  mov      x0, x22
0066C3364  blr      x8
0066C3368  mov      x26, x0
0066C336C  cbz      x26, #0x66c3dd8
0066C3370  ldrb     w8, [x19, #0xa4c]
0066C3374  cbnz     w8, #0x66c338c
0066C3378  adrp     x0, #0x8ee5000
0066C337C  ldr      x0, [x0, #0xb30]
0066C3380  bl       #0x382bd14 ; 
0066C3384  mov      w8, #1
0066C3388  strb     w8, [x19, #0xa4c]
0066C338C  adrp     x8, #0x8ee5000
0066C3390  ldr      x8, [x8, #0xb30]
0066C3394  ldr      x1, [x8]
0066C3398  ldrb     w8, [x1, #0x53]
0066C339C  tbnz     w8, #5, #0x66c33a8
0066C33A0  ldr      x0, [x26, #0x210]
0066C33A4  b        #0x66c33b4 ; 
0066C33A8  ldr      x8, [x1, #0x60]
0066C33AC  mov      x0, x26
0066C33B0  blr      x8
0066C33B4  cbz      x0, #0x66c3dd8
0066C33B8  adrp     x8, #0x8f11000
0066C33BC  ldr      x8, [x8, #0xdd8]
0066C33C0  ldr      x1, [x8]
0066C33C4  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C33C8  adrp     x8, #0x8ee6000
0066C33CC  ldr      x8, [x8, #0x600]
0066C33D0  mov      x26, x0
0066C33D4  ldr      x1, [x8]
0066C33D8  ldrb     w8, [x1, #0x53]
0066C33DC  tbnz     w8, #5, #0x66c33e8
0066C33E0  ldr      x0, [x22, #0x38]
0066C33E4  b        #0x66c33f4 ; 
0066C33E8  ldr      x8, [x1, #0x60]
0066C33EC  mov      x0, x22
0066C33F0  blr      x8
0066C33F4  cbz      x0, #0x66c3dd8
0066C33F8  add      x8, sp, #0x18
0066C33FC  mov      x1, xzr
0066C3400  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C3404  ldur     q0, [sp, #0x18]
0066C3408  ldr      x8, [sp, #0x28]
0066C340C  str      q0, [sp, #0x30]
0066C3410  str      x8, [sp, #0x40]
0066C3414  cbz      x26, #0x66c3dd8
0066C3418  ldr      x8, [sp, #0x40]
0066C341C  ldr      q0, [sp, #0x30]
0066C3420  str      x8, [x26, #0x30]
0066C3424  str      q0, [x26, #0x20]
0066C3428  adrp     x8, #0x8ee6000
0066C342C  ldr      x8, [x8, #0x600]
0066C3430  ldr      x1, [x8]
0066C3434  ldrb     w8, [x1, #0x53]
0066C3438  tbnz     w8, #5, #0x66c3444
0066C343C  ldr      x27, [x22, #0x38]
0066C3440  b        #0x66c3454 ; 
0066C3444  ldr      x8, [x1, #0x60]
0066C3448  mov      x0, x22
0066C344C  blr      x8
0066C3450  mov      x27, x0
0066C3454  cbz      x27, #0x66c3dd8
0066C3458  adrp     x19, #0x9592000
0066C345C  ldrb     w8, [x19, #0x473]
0066C3460  cbnz     w8, #0x66c3478
0066C3464  adrp     x0, #0x8ee8000
0066C3468  ldr      x0, [x0, #0x890]
0066C346C  bl       #0x382bd14 ; 
0066C3470  mov      w8, #1
0066C3474  strb     w8, [x19, #0x473]
0066C3478  adrp     x8, #0x8ee8000
0066C347C  ldr      x8, [x8, #0x890]
0066C3480  ldr      x1, [x8]
0066C3484  ldrb     w8, [x1, #0x53]
0066C3488  tbnz     w8, #5, #0x66c3494
0066C348C  ldr      x0, [x27, #0x20]
0066C3490  b        #0x66c34a0 ; 
0066C3494  ldr      x8, [x1, #0x60]
0066C3498  mov      x0, x27
0066C349C  blr      x8
0066C34A0  str      x0, [x26, #0x38]
0066C34A4  adrp     x8, #0x8ee6000
0066C34A8  ldr      x8, [x8, #0x600]
0066C34AC  ldr      x1, [x8]
0066C34B0  ldrb     w8, [x1, #0x53]
0066C34B4  tbnz     w8, #5, #0x66c34c0
0066C34B8  ldr      x27, [x22, #0x38]
0066C34BC  b        #0x66c34d0 ; 
0066C34C0  ldr      x8, [x1, #0x60]
0066C34C4  mov      x0, x22
0066C34C8  blr      x8
0066C34CC  mov      x27, x0
0066C34D0  cbz      x27, #0x66c3dd8
0066C34D4  adrp     x29, #0x959a000
0066C34D8  ldrb     w8, [x29, #0x27f]
0066C34DC  cbnz     w8, #0x66c34f4
0066C34E0  adrp     x0, #0x8f11000
0066C34E4  ldr      x0, [x0, #0xdf8]
0066C34E8  bl       #0x382bd14 ; 
0066C34EC  mov      w8, #1
0066C34F0  strb     w8, [x29, #0x27f]
0066C34F4  adrp     x8, #0x8f11000
0066C34F8  ldr      x8, [x8, #0xdf8]
0066C34FC  ldr      x1, [x8]
0066C3500  ldrb     w8, [x1, #0x53]
0066C3504  tbnz     w8, #5, #0x66c3510
0066C3508  ldr      x0, [x27, #0x158]
0066C350C  b        #0x66c351c ; 
0066C3510  ldr      x8, [x1, #0x60]
0066C3514  mov      x0, x27
0066C3518  blr      x8
0066C351C  str      x0, [x26, #0x48]
0066C3520  adrp     x8, #0x8ee6000
0066C3524  ldr      x8, [x8, #0x608]
0066C3528  adrp     x27, #0x9591000
0066C352C  ldr      x1, [x8]
0066C3530  ldrb     w8, [x1, #0x53]
0066C3534  tbnz     w8, #5, #0x66c3540
0066C3538  ldr      x0, [x22, #0x30]
0066C353C  b        #0x66c354c ; 
0066C3540  ldr      x8, [x1, #0x60]
0066C3544  mov      x0, x22
0066C3548  blr      x8
0066C354C  cbz      x0, #0x66c3dd8
0066C3550  adrp     x8, #0x8ee6000
0066C3554  ldr      x8, [x8, #0xd8]
0066C3558  ldr      x1, [x8]
0066C355C  ldrb     w8, [x1, #0x53]
0066C3560  tbnz     w8, #5, #0x66c356c
0066C3564  ldr      x0, [x0, #0x38]
0066C3568  b        #0x66c3574 ; 
0066C356C  ldr      x8, [x1, #0x60]
0066C3570  blr      x8
0066C3574  cbz      x0, #0x66c3dd8
0066C3578  mov      x1, xzr
0066C357C  bl       #0x45616a8 ; 
0066C3580  tbz      w0, #0, #0x66c3590
0066C3584  mov      x0, x22
0066C3588  mov      x1, x26
0066C358C  bl       #0x66c4eb4 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroDying
0066C3590  adrp     x26, #0x9591000
0066C3594  ldrb     w8, [x26, #0xa4b]
0066C3598  cbnz     w8, #0x66c35b0
0066C359C  adrp     x0, #0x8ee5000
0066C35A0  ldr      x0, [x0, #0xb28]
0066C35A4  bl       #0x382bd14 ; 
0066C35A8  mov      w8, #1
0066C35AC  strb     w8, [x26, #0xa4b]
0066C35B0  adrp     x8, #0x8ee5000
0066C35B4  ldr      x8, [x8, #0xb28]
0066C35B8  ldr      x1, [x8]
0066C35BC  ldrb     w8, [x1, #0x53]
0066C35C0  tbnz     w8, #5, #0x66c35cc
0066C35C4  ldr      x26, [x22, #0x20]
0066C35C8  b        #0x66c35dc ; 
0066C35CC  ldr      x8, [x1, #0x60]
0066C35D0  mov      x0, x22
0066C35D4  blr      x8
0066C35D8  mov      x26, x0
0066C35DC  cbz      x26, #0x66c3dd8
0066C35E0  ldrb     w8, [x27, #0xa4c]
0066C35E4  cbnz     w8, #0x66c35fc
0066C35E8  adrp     x0, #0x8ee5000
0066C35EC  ldr      x0, [x0, #0xb30]
0066C35F0  bl       #0x382bd14 ; 
0066C35F4  mov      w8, #1
0066C35F8  strb     w8, [x27, #0xa4c]
0066C35FC  adrp     x8, #0x8ee5000
0066C3600  ldr      x8, [x8, #0xb30]
0066C3604  ldr      x1, [x8]
0066C3608  ldrb     w8, [x1, #0x53]
0066C360C  tbnz     w8, #5, #0x66c3618
0066C3610  ldr      x0, [x26, #0x210]
0066C3614  b        #0x66c3624 ; 
0066C3618  ldr      x8, [x1, #0x60]
0066C361C  mov      x0, x26
0066C3620  blr      x8
0066C3624  cbz      x0, #0x66c3dd8
0066C3628  adrp     x8, #0x8f11000
0066C362C  ldr      x8, [x8, #0xdd8]
0066C3630  ldr      x1, [x8]
0066C3634  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C3638  adrp     x8, #0x8ee6000
0066C363C  ldr      x8, [x8, #0x600]
0066C3640  mov      x26, x0
0066C3644  ldr      x1, [x8]
0066C3648  ldrb     w8, [x1, #0x53]
0066C364C  tbnz     w8, #5, #0x66c3658
0066C3650  ldr      x0, [x22, #0x38]
0066C3654  b        #0x66c3664 ; 
0066C3658  ldr      x8, [x1, #0x60]
0066C365C  mov      x0, x22
0066C3660  blr      x8
0066C3664  cbz      x0, #0x66c3dd8
0066C3668  add      x8, sp, #0x18
0066C366C  mov      x1, xzr
0066C3670  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C3674  ldur     q0, [sp, #0x18]
0066C3678  ldr      x8, [sp, #0x28]
0066C367C  str      q0, [sp, #0x30]
0066C3680  str      x8, [sp, #0x40]
0066C3684  cbz      x26, #0x66c3dd8
0066C3688  ldr      x8, [sp, #0x40]
0066C368C  ldr      q0, [sp, #0x30]
0066C3690  str      x8, [x26, #0x30]
0066C3694  str      q0, [x26, #0x20]
0066C3698  adrp     x8, #0x8ee6000
0066C369C  ldr      x8, [x8, #0x600]
0066C36A0  ldr      x1, [x8]
0066C36A4  ldrb     w8, [x1, #0x53]
0066C36A8  tbnz     w8, #5, #0x66c36b4
0066C36AC  ldr      x27, [x22, #0x38]
0066C36B0  b        #0x66c36c4 ; 
0066C36B4  ldr      x8, [x1, #0x60]
0066C36B8  mov      x0, x22
0066C36BC  blr      x8
0066C36C0  mov      x27, x0
0066C36C4  cbz      x27, #0x66c3dd8
0066C36C8  ldrb     w8, [x19, #0x473]
0066C36CC  cbnz     w8, #0x66c36e4
0066C36D0  adrp     x0, #0x8ee8000
0066C36D4  ldr      x0, [x0, #0x890]
0066C36D8  bl       #0x382bd14 ; 
0066C36DC  mov      w8, #1
0066C36E0  strb     w8, [x19, #0x473]
0066C36E4  adrp     x8, #0x8ee8000
0066C36E8  ldr      x8, [x8, #0x890]
0066C36EC  ldr      x1, [x8]
0066C36F0  ldrb     w8, [x1, #0x53]
0066C36F4  tbnz     w8, #5, #0x66c3700
0066C36F8  ldr      x0, [x27, #0x20]
0066C36FC  b        #0x66c370c ; 
0066C3700  ldr      x8, [x1, #0x60]
0066C3704  mov      x0, x27
0066C3708  blr      x8
0066C370C  str      x0, [x26, #0x38]
0066C3710  adrp     x8, #0x8ee6000
0066C3714  ldr      x8, [x8, #0x600]
0066C3718  ldr      x1, [x8]
0066C371C  ldrb     w8, [x1, #0x53]
0066C3720  tbnz     w8, #5, #0x66c372c
0066C3724  ldr      x27, [x22, #0x38]
0066C3728  b        #0x66c373c ; 
0066C372C  ldr      x8, [x1, #0x60]
0066C3730  mov      x0, x22
0066C3734  blr      x8
0066C3738  mov      x27, x0
0066C373C  cbz      x27, #0x66c3dd8
0066C3740  ldrb     w8, [x29, #0x27f]
0066C3744  cbnz     w8, #0x66c375c
0066C3748  adrp     x0, #0x8f11000
0066C374C  ldr      x0, [x0, #0xdf8]
0066C3750  bl       #0x382bd14 ; 
0066C3754  mov      w8, #1
0066C3758  strb     w8, [x29, #0x27f]
0066C375C  adrp     x8, #0x8f11000
0066C3760  ldr      x8, [x8, #0xdf8]
0066C3764  ldr      x1, [x8]
0066C3768  ldrb     w8, [x1, #0x53]
0066C376C  tbnz     w8, #5, #0x66c3778
0066C3770  ldr      x0, [x27, #0x158]
0066C3774  b        #0x66c3784 ; 
0066C3778  ldr      x8, [x1, #0x60]
0066C377C  mov      x0, x27
0066C3780  blr      x8
0066C3784  adrp     x19, #0x8ee6000
0066C3788  ldr      x19, [x19, #0x608]
0066C378C  str      x0, [x26, #0x48]
0066C3790  ldr      x1, [x19]
0066C3794  ldrb     w8, [x1, #0x53]
0066C3798  tbnz     w8, #5, #0x66c37a4
0066C379C  ldr      x27, [x22, #0x30]
0066C37A0  b        #0x66c37b4 ; 
0066C37A4  ldr      x8, [x1, #0x60]
0066C37A8  mov      x0, x22
0066C37AC  blr      x8
0066C37B0  mov      x27, x0
0066C37B4  cbz      x27, #0x66c3dd8
0066C37B8  ldrb     w8, [x20, #0xa86]
0066C37BC  cbnz     w8, #0x66c37e0
0066C37C0  adrp     x0, #0x8ee6000
0066C37C4  ldr      x0, [x0, #0x318]
0066C37C8  bl       #0x382bd14 ; 
0066C37CC  adrp     x0, #0x8ee3000
0066C37D0  ldr      x0, [x0, #0xf18]
0066C37D4  bl       #0x382bd14 ; 
0066C37D8  mov      w8, #1
0066C37DC  strb     w8, [x20, #0xa86]
0066C37E0  adrp     x8, #0x8ee6000
0066C37E4  ldr      x8, [x8, #0x318]
0066C37E8  ldr      x2, [x8]
0066C37EC  ldrb     w8, [x2, #0x53]
0066C37F0  tbnz     w8, #5, #0x66c3818
0066C37F4  ldr      x0, [x27, #0x190]
0066C37F8  cbz      x0, #0x66c387c
0066C37FC  adrp     x8, #0x8ee3000
0066C3800  ldr      x8, [x8, #0xf18]
0066C3804  mov      w1, #9
0066C3808  ldr      x2, [x8]
0066C380C  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066C3810  tbnz     w0, #0, #0x66c382c
0066C3814  b        #0x66c387c ; 
0066C3818  ldr      x8, [x2, #0x60]
0066C381C  mov      w1, #9
0066C3820  mov      x0, x27
0066C3824  blr      x8
0066C3828  tbz      w0, #0, #0x66c387c
0066C382C  ldr      x1, [x19]
0066C3830  ldrb     w8, [x1, #0x53]
0066C3834  tbnz     w8, #5, #0x66c3840
0066C3838  ldr      x0, [x22, #0x30]
0066C383C  b        #0x66c384c ; 
0066C3840  ldr      x8, [x1, #0x60]
0066C3844  mov      x0, x22
0066C3848  blr      x8
0066C384C  cbz      x0, #0x66c3dd8
0066C3850  ldr      x0, [x0, #0x150]
0066C3854  cbz      x0, #0x66c3dd8
0066C3858  mov      x1, x26
0066C385C  mov      x2, xzr
0066C3860  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066C3864  tbz      w0, #0, #0x66c387c
0066C3868  ldr      x1, [x19]
0066C386C  ldrb     w8, [x1, #0x53]
0066C3870  tbnz     w8, #5, #0x66c39f4
0066C3874  ldr      x0, [x22, #0x30]
0066C3878  b        #0x66c3a00 ; 
0066C387C  tbz      w25, #0, #0x66c3da8
0066C3880  adrp     x19, #0x9591000
0066C3884  ldrb     w8, [x19, #0xa4b]
0066C3888  cbnz     w8, #0x66c38a0
0066C388C  adrp     x0, #0x8ee5000
0066C3890  ldr      x0, [x0, #0xb28]
0066C3894  bl       #0x382bd14 ; 
0066C3898  mov      w8, #1
0066C389C  strb     w8, [x19, #0xa4b]
0066C38A0  adrp     x8, #0x8ee5000
0066C38A4  ldr      x8, [x8, #0xb28]
0066C38A8  ldr      x1, [x8]
0066C38AC  ldrb     w8, [x1, #0x53]
0066C38B0  tbnz     w8, #5, #0x66c38bc
0066C38B4  ldr      x24, [x22, #0x20]
0066C38B8  b        #0x66c38cc ; 
0066C38BC  ldr      x8, [x1, #0x60]
0066C38C0  mov      x0, x22
0066C38C4  blr      x8
0066C38C8  mov      x24, x0
0066C38CC  cbz      x24, #0x66c3dd8
0066C38D0  adrp     x19, #0x9591000
0066C38D4  ldrb     w8, [x19, #0xa62]
0066C38D8  cbnz     w8, #0x66c38f0
0066C38DC  adrp     x0, #0x8ee6000
0066C38E0  ldr      x0, [x0, #0x1f8]
0066C38E4  bl       #0x382bd14 ; 
0066C38E8  mov      w8, #1
0066C38EC  strb     w8, [x19, #0xa62]
0066C38F0  adrp     x8, #0x8ee6000
0066C38F4  ldr      x8, [x8, #0x1f8]
0066C38F8  ldr      x1, [x8]
0066C38FC  ldrb     w8, [x1, #0x53]
0066C3900  tbnz     w8, #5, #0x66c390c
0066C3904  ldr      x24, [x24, #0x1f8]
0066C3908  b        #0x66c391c ; 
0066C390C  ldr      x8, [x1, #0x60]
0066C3910  mov      x0, x24
0066C3914  blr      x8
0066C3918  mov      x24, x0
0066C391C  cbz      x21, #0x66c3dd8
0066C3920  adrp     x26, #0x959a000
0066C3924  ldrb     w8, [x26, #0x27d]
0066C3928  cbnz     w8, #0x66c3940
0066C392C  adrp     x0, #0x8f11000
0066C3930  ldr      x0, [x0, #0xde8]
0066C3934  bl       #0x382bd14 ; 
0066C3938  mov      w8, #1
0066C393C  strb     w8, [x26, #0x27d]
0066C3940  adrp     x27, #0x8f11000
0066C3944  ldr      x27, [x27, #0xde8]
0066C3948  ldr      x1, [x27]
0066C394C  ldrb     w8, [x1, #0x53]
0066C3950  tbnz     w8, #5, #0x66c395c
0066C3954  ldr      x1, [x21, #0xf8]
0066C3958  b        #0x66c396c ; 
0066C395C  ldr      x8, [x1, #0x60]
0066C3960  mov      x0, x21
0066C3964  blr      x8
0066C3968  mov      x1, x0
0066C396C  cbz      x24, #0x66c3dd8
0066C3970  adrp     x8, #0x8ee6000
0066C3974  ldr      x8, [x8, #0x108]
0066C3978  mov      x0, x24
0066C397C  ldr      x2, [x8]
0066C3980  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066C3984  cbz      x0, #0x66c3da8
0066C3988  ldr      x8, [x0, #0x150]
0066C398C  mov      x24, x0
0066C3990  cbz      x8, #0x66c3da8
0066C3994  ldrb     w8, [x20, #0xa86]
0066C3998  cbnz     w8, #0x66c39bc
0066C399C  adrp     x0, #0x8ee6000
0066C39A0  ldr      x0, [x0, #0x318]
0066C39A4  bl       #0x382bd14 ; 
0066C39A8  adrp     x0, #0x8ee3000
0066C39AC  ldr      x0, [x0, #0xf18]
0066C39B0  bl       #0x382bd14 ; 
0066C39B4  mov      w8, #1
0066C39B8  strb     w8, [x20, #0xa86]
0066C39BC  adrp     x8, #0x8ee6000
0066C39C0  ldr      x8, [x8, #0x318]
0066C39C4  ldr      x2, [x8]
0066C39C8  ldrb     w8, [x2, #0x53]
0066C39CC  tbnz     w8, #5, #0x66c3a2c
0066C39D0  ldr      x0, [x24, #0x190]
0066C39D4  cbz      x0, #0x66c3da8
0066C39D8  adrp     x8, #0x8ee3000
0066C39DC  ldr      x8, [x8, #0xf18]
0066C39E0  mov      w1, #0x25
0066C39E4  ldr      x2, [x8]
0066C39E8  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066C39EC  tbnz     w0, #0, #0x66c3a40
0066C39F0  b        #0x66c3da8 ; 
0066C39F4  ldr      x8, [x1, #0x60]
0066C39F8  mov      x0, x22
0066C39FC  blr      x8
0066C3A00  cbz      x0, #0x66c3dd8
0066C3A04  ldr      x8, [x0]
0066C3A08  ldr      x9, [x8, #0x498]
0066C3A0C  ldr      x1, [x8, #0x4a0]
0066C3A10  blr      x9
0066C3A14  ldr      w8, [x22, #0xa0]
0066C3A18  mov      w9, #1
0066C3A1C  sub      w8, w0, w8
0066C3A20  str      w8, [x24]
0066C3A24  str      w9, [x22, #0xa0]
0066C3A28  b        #0x66c3da8 ; 
0066C3A2C  ldr      x8, [x2, #0x60]
0066C3A30  mov      w1, #0x25
0066C3A34  mov      x0, x24
0066C3A38  blr      x8
0066C3A3C  tbz      w0, #0, #0x66c3da8
0066C3A40  adrp     x19, #0x9591000
0066C3A44  ldrb     w8, [x19, #0xa4b]
0066C3A48  cbnz     w8, #0x66c3a60
0066C3A4C  adrp     x0, #0x8ee5000
0066C3A50  ldr      x0, [x0, #0xb28]
0066C3A54  bl       #0x382bd14 ; 
0066C3A58  mov      w8, #1
0066C3A5C  strb     w8, [x19, #0xa4b]
0066C3A60  adrp     x8, #0x8ee5000
0066C3A64  ldr      x8, [x8, #0xb28]
0066C3A68  ldr      x1, [x8]
0066C3A6C  ldrb     w8, [x1, #0x53]
0066C3A70  tbnz     w8, #5, #0x66c3a7c
0066C3A74  ldr      x25, [x22, #0x20]
0066C3A78  b        #0x66c3a8c ; 
0066C3A7C  ldr      x8, [x1, #0x60]
0066C3A80  mov      x0, x22
0066C3A84  blr      x8
0066C3A88  mov      x25, x0
0066C3A8C  cbz      x25, #0x66c3dd8
0066C3A90  adrp     x19, #0x9591000
0066C3A94  ldrb     w8, [x19, #0xa4c]
0066C3A98  cbnz     w8, #0x66c3ab0
0066C3A9C  adrp     x0, #0x8ee5000
0066C3AA0  ldr      x0, [x0, #0xb30]
0066C3AA4  bl       #0x382bd14 ; 
0066C3AA8  mov      w8, #1
0066C3AAC  strb     w8, [x19, #0xa4c]
0066C3AB0  adrp     x8, #0x8ee5000
0066C3AB4  ldr      x8, [x8, #0xb30]
0066C3AB8  ldr      x1, [x8]
0066C3ABC  ldrb     w8, [x1, #0x53]
0066C3AC0  tbnz     w8, #5, #0x66c3acc
0066C3AC4  ldr      x0, [x25, #0x210]
0066C3AC8  b        #0x66c3ad8 ; 
0066C3ACC  ldr      x8, [x1, #0x60]
0066C3AD0  mov      x0, x25
0066C3AD4  blr      x8
0066C3AD8  cbz      x0, #0x66c3dd8
0066C3ADC  adrp     x8, #0x8f11000
0066C3AE0  ldr      x8, [x8, #0xdd0]
0066C3AE4  ldr      x1, [x8]
0066C3AE8  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C3AEC  ldp      x29, x20, [x23]
0066C3AF0  ldr      x19, [x23, #0x10]
0066C3AF4  mov      x25, x0
0066C3AF8  add      x8, sp, #0x30
0066C3AFC  mov      x0, xzr
0066C3B00  bl       #0x7d4fd40 ; Photon.Deterministic.FPVector3$$get_Zero
0066C3B04  ldr      x8, [sp, #0x30]
0066C3B08  cmp      x29, x8
0066C3B0C  b.ne     #0x66c3b44
0066C3B10  ldr      x8, [sp, #0x38]
0066C3B14  cmp      x20, x8
0066C3B18  b.ne     #0x66c3b44
0066C3B1C  ldr      x8, [sp, #0x40]
0066C3B20  cmp      x19, x8
0066C3B24  b.ne     #0x66c3b44
0066C3B28  adrp     x8, #0x8ee6000
0066C3B2C  ldr      x8, [x8, #0x600]
0066C3B30  ldr      x1, [x8]
0066C3B34  ldrb     w8, [x1, #0x53]
0066C3B38  tbnz     w8, #5, #0x66c3b60
0066C3B3C  ldr      x0, [x22, #0x38]
0066C3B40  b        #0x66c3b6c ; 
0066C3B44  ldr      x8, [x23, #0x10]
0066C3B48  ldr      q0, [x23]
0066C3B4C  adrp     x29, #0x8ee6000
0066C3B50  str      x8, [sp, #0x60]
0066C3B54  str      q0, [sp, #0x50]
0066C3B58  ldr      x29, [x29, #0x608]
0066C3B5C  b        #0x66c3b94 ; 
0066C3B60  ldr      x8, [x1, #0x60]
0066C3B64  mov      x0, x22
0066C3B68  blr      x8
0066C3B6C  adrp     x29, #0x8ee6000
0066C3B70  ldr      x29, [x29, #0x608]
0066C3B74  cbz      x0, #0x66c3dd8
0066C3B78  add      x8, sp, #0x30
0066C3B7C  mov      x1, xzr
0066C3B80  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C3B84  ldr      q0, [sp, #0x30]
0066C3B88  ldr      x8, [sp, #0x40]
0066C3B8C  str      q0, [sp, #0x50]
0066C3B90  str      x8, [sp, #0x60]
0066C3B94  ldr      q0, [sp, #0x50]
0066C3B98  ldr      x8, [sp, #0x60]
0066C3B9C  str      q0, [sp, #0x70]
0066C3BA0  str      x8, [sp, #0x80]
0066C3BA4  str      q0, [sp, #0x30]
0066C3BA8  str      x8, [sp, #0x40]
0066C3BAC  cbz      x25, #0x66c3dd8
0066C3BB0  ldr      x8, [sp, #0x40]
0066C3BB4  ldr      q0, [sp, #0x30]
0066C3BB8  adrp     x19, #0x959a000
0066C3BBC  str      x8, [x25, #0x30]
0066C3BC0  str      q0, [x25, #0x20]
0066C3BC4  ldr      x8, [sp, #0x80]
0066C3BC8  ldr      q0, [sp, #0x70]
0066C3BCC  str      x8, [x25, #0x68]
0066C3BD0  stur     q0, [x25, #0x58]
0066C3BD4  ldrb     w8, [x19, #0x280]
0066C3BD8  cbnz     w8, #0x66c3bf0
0066C3BDC  adrp     x0, #0x8f11000
0066C3BE0  ldr      x0, [x0, #0xe00]
0066C3BE4  bl       #0x382bd14 ; 
0066C3BE8  mov      w8, #1
0066C3BEC  strb     w8, [x19, #0x280]
0066C3BF0  adrp     x20, #0x8f11000
0066C3BF4  ldr      x20, [x20, #0xe00]
0066C3BF8  ldr      x1, [x20]
0066C3BFC  ldrb     w8, [x1, #0x53]
0066C3C00  tbnz     w8, #5, #0x66c3c0c
0066C3C04  ldr      x23, [x21, #0x100]
0066C3C08  b        #0x66c3c1c ; 
0066C3C0C  ldr      x8, [x1, #0x60]
0066C3C10  mov      x0, x21
0066C3C14  blr      x8
0066C3C18  mov      x23, x0
0066C3C1C  mov      x0, xzr
0066C3C20  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
0066C3C24  mov      x1, x0
0066C3C28  mov      x0, x23
0066C3C2C  mov      x2, xzr
0066C3C30  bl       #0x7db81fc ; Quantum.EntityRef$$op_Inequality
0066C3C34  tbz      w0, #0, #0x66c3c68
0066C3C38  ldrb     w8, [x19, #0x280]
0066C3C3C  cbnz     w8, #0x66c3c54
0066C3C40  adrp     x0, #0x8f11000
0066C3C44  ldr      x0, [x0, #0xe00]
0066C3C48  bl       #0x382bd14 ; 
0066C3C4C  mov      w8, #1
0066C3C50  strb     w8, [x19, #0x280]
0066C3C54  ldr      x1, [x20]
0066C3C58  ldrb     w8, [x1, #0x53]
0066C3C5C  tbnz     w8, #5, #0x66c3c98
0066C3C60  ldr      x0, [x21, #0x100]
0066C3C64  b        #0x66c3ca4 ; 
0066C3C68  ldrb     w8, [x26, #0x27d]
0066C3C6C  cbnz     w8, #0x66c3c84
0066C3C70  adrp     x0, #0x8f11000
0066C3C74  ldr      x0, [x0, #0xde8]
0066C3C78  bl       #0x382bd14 ; 
0066C3C7C  mov      w8, #1
0066C3C80  strb     w8, [x26, #0x27d]
0066C3C84  ldr      x1, [x27]
0066C3C88  ldrb     w8, [x1, #0x53]
0066C3C8C  tbnz     w8, #5, #0x66c3c98
0066C3C90  ldr      x0, [x21, #0xf8]
0066C3C94  b        #0x66c3ca4 ; 
0066C3C98  ldr      x8, [x1, #0x60]
0066C3C9C  mov      x0, x21
0066C3CA0  blr      x8
0066C3CA4  str      x0, [x25, #0x38]
0066C3CA8  ldrb     w8, [x26, #0x27d]
0066C3CAC  cbnz     w8, #0x66c3cc4
0066C3CB0  adrp     x0, #0x8f11000
0066C3CB4  ldr      x0, [x0, #0xde8]
0066C3CB8  bl       #0x382bd14 ; 
0066C3CBC  mov      w8, #1
0066C3CC0  strb     w8, [x26, #0x27d]
0066C3CC4  ldr      x1, [x27]
0066C3CC8  ldrb     w8, [x1, #0x53]
0066C3CCC  tbnz     w8, #5, #0x66c3cd8
0066C3CD0  ldr      x0, [x21, #0xf8]
0066C3CD4  b        #0x66c3ce4 ; 
0066C3CD8  ldr      x8, [x1, #0x60]
0066C3CDC  mov      x0, x21
0066C3CE0  blr      x8
0066C3CE4  str      x0, [x25, #0x40]
0066C3CE8  ldr      x1, [x29]
0066C3CEC  ldr      w20, [sp, #0xc]
0066C3CF0  ldr      x23, [sp, #0x10]
0066C3CF4  ldrb     w8, [x1, #0x53]
0066C3CF8  tbnz     w8, #5, #0x66c3d04
0066C3CFC  ldr      x0, [x22, #0x30]
0066C3D00  b        #0x66c3d10 ; 
0066C3D04  ldr      x8, [x1, #0x60]
0066C3D08  mov      x0, x22
0066C3D0C  blr      x8
0066C3D10  cbz      x0, #0x66c3dd8
0066C3D14  adrp     x8, #0x8ee6000
0066C3D18  ldr      x8, [x8, #0xe8]
0066C3D1C  ldr      x1, [x8]
0066C3D20  ldrb     w8, [x1, #0x53]
0066C3D24  tbnz     w8, #5, #0x66c3d30
0066C3D28  ldr      x0, [x0, #0x28]
0066C3D2C  b        #0x66c3d38 ; 
0066C3D30  ldr      x8, [x1, #0x60]
0066C3D34  blr      x8
0066C3D38  str      x0, [x25, #0x48]
0066C3D3C  adrp     x19, #0x959a000
0066C3D40  ldrb     w8, [x19, #0x281]
0066C3D44  cbnz     w8, #0x66c3d5c
0066C3D48  adrp     x0, #0x8f11000
0066C3D4C  ldr      x0, [x0, #0xe08]
0066C3D50  bl       #0x382bd14 ; 
0066C3D54  mov      w8, #1
0066C3D58  strb     w8, [x19, #0x281]
0066C3D5C  adrp     x8, #0x8f11000
0066C3D60  ldr      x8, [x8, #0xe08]
0066C3D64  ldr      x1, [x8]
0066C3D68  ldrb     w8, [x1, #0x53]
0066C3D6C  tbnz     w8, #5, #0x66c3d78
0066C3D70  ldr      w0, [x21, #0x110]
0066C3D74  b        #0x66c3d84 ; 
0066C3D78  ldr      x8, [x1, #0x60]
0066C3D7C  mov      x0, x21
0066C3D80  blr      x8
0066C3D84  mov      w8, #1
0066C3D88  stp      w0, w20, [x25, #0x70]
0066C3D8C  str      x23, [x25, #0x50]
0066C3D90  strb     w8, [x25, #0x78]
0066C3D94  ldr      x0, [x24, #0x150]
0066C3D98  cbz      x0, #0x66c3dd8
0066C3D9C  mov      x1, x25
0066C3DA0  mov      x2, xzr
0066C3DA4  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066C3DA8  ldr      x8, [x28, #0x28]
0066C3DAC  ldr      x9, [sp, #0xa8]
0066C3DB0  cmp      x8, x9
0066C3DB4  b.ne     #0x66c3ddc
0066C3DB8  ldp      x20, x19, [sp, #0x100]
0066C3DBC  ldp      x22, x21, [sp, #0xf0]
0066C3DC0  ldp      x24, x23, [sp, #0xe0]
0066C3DC4  ldp      x26, x25, [sp, #0xd0]
0066C3DC8  ldp      x28, x27, [sp, #0xc0]
0066C3DCC  ldp      x29, x30, [sp, #0xb0]
0066C3DD0  add      sp, sp, #0x110
0066C3DD4  ret      
0066C3DD8  bl       #0x382bfb8 ; 
0066C3DDC  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePostHpUpdateTriggers
; RVA 0x66C481C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C481C  sub      sp, sp, #0xc0
0066C4820  str      x30, [sp, #0x60]
0066C4824  stp      x28, x27, [sp, #0x70]
0066C4828  stp      x26, x25, [sp, #0x80]
0066C482C  stp      x24, x23, [sp, #0x90]
0066C4830  stp      x22, x21, [sp, #0xa0]
0066C4834  stp      x20, x19, [sp, #0xb0]
0066C4838  mrs      x26, tpidr_el0
0066C483C  ldr      x8, [x26, #0x28]
0066C4840  adrp     x27, #0x959a000
0066C4844  adrp     x28, #0x8f11000
0066C4848  mov      w21, w6
0066C484C  str      x8, [sp, #0x58]
0066C4850  ldrb     w8, [x27, #0x24b]
0066C4854  ldr      x28, [x28, #0xe38]
0066C4858  mov      x23, x5
0066C485C  mov      x25, x4
0066C4860  mov      w24, w3
0066C4864  mov      x22, x2
0066C4868  mov      x20, x1
0066C486C  mov      x19, x0
0066C4870  tbnz     w8, #0, #0x66c48c4
0066C4874  adrp     x0, #0x8f11000
0066C4878  ldr      x0, [x0, #0xe38]
0066C487C  bl       #0x382bd14 ; 
0066C4880  adrp     x0, #0x8ee6000
0066C4884  ldr      x0, [x0, #0xd8]
0066C4888  bl       #0x382bd14 ; 
0066C488C  adrp     x0, #0x8ee6000
0066C4890  ldr      x0, [x0, #0xe8]
0066C4894  bl       #0x382bd14 ; 
0066C4898  adrp     x0, #0x8ee6000
0066C489C  ldr      x0, [x0, #0x600]
0066C48A0  bl       #0x382bd14 ; 
0066C48A4  adrp     x0, #0x8ee6000
0066C48A8  ldr      x0, [x0, #0x608]
0066C48AC  bl       #0x382bd14 ; 
0066C48B0  adrp     x0, #0x8f11000
0066C48B4  ldr      x0, [x0, #0xe40]
0066C48B8  bl       #0x382bd14 ; 
0066C48BC  mov      w8, #1
0066C48C0  strb     w8, [x27, #0x24b]
0066C48C4  ldr      x7, [x28]
0066C48C8  ldrb     w8, [x7, #0x53]
0066C48CC  tbnz     w8, #5, #0x66c48f8
0066C48D0  ldr      w8, [x22]
0066C48D4  cmp      w8, #1
0066C48D8  b.lt     #0x66c4d34
0066C48DC  adrp     x23, #0x8ee6000
0066C48E0  ldr      x23, [x23, #0x608]
0066C48E4  ldr      x1, [x23]
0066C48E8  ldrb     w8, [x1, #0x53]
0066C48EC  tbnz     w8, #5, #0x66c4930
0066C48F0  ldr      x21, [x19, #0x30]
0066C48F4  b        #0x66c4940 ; 
0066C48F8  ldr      x8, [x25, #0x10]
0066C48FC  ldr      q0, [x25]
0066C4900  ldr      x9, [x7, #0x60]
0066C4904  and      w3, w24, #1
0066C4908  add      x4, sp, #0x40
0066C490C  mov      x0, x19
0066C4910  mov      x1, x20
0066C4914  mov      x2, x22
0066C4918  mov      x5, x23
0066C491C  mov      w6, w21
0066C4920  str      x8, [sp, #0x50]
0066C4924  str      q0, [sp, #0x40]
0066C4928  blr      x9
0066C492C  b        #0x66c4d34 ; 
0066C4930  ldr      x8, [x1, #0x60]
0066C4934  mov      x0, x19
0066C4938  blr      x8
0066C493C  mov      x21, x0
0066C4940  cbz      x20, #0x66c4d64
0066C4944  adrp     x24, #0x959a000
0066C4948  ldrb     w8, [x24, #0x27d]
0066C494C  cbnz     w8, #0x66c4964
0066C4950  adrp     x0, #0x8f11000
0066C4954  ldr      x0, [x0, #0xde8]
0066C4958  bl       #0x382bd14 ; 
0066C495C  mov      w8, #1
0066C4960  strb     w8, [x24, #0x27d]
0066C4964  adrp     x25, #0x8f11000
0066C4968  ldr      x25, [x25, #0xde8]
0066C496C  ldr      x1, [x25]
0066C4970  ldrb     w8, [x1, #0x53]
0066C4974  tbnz     w8, #5, #0x66c4980
0066C4978  ldr      x0, [x20, #0xf8]
0066C497C  b        #0x66c498c ; 
0066C4980  ldr      x8, [x1, #0x60]
0066C4984  mov      x0, x20
0066C4988  blr      x8
0066C498C  cbz      x21, #0x66c4d64
0066C4990  str      x0, [x21, #0xd8]
0066C4994  adrp     x21, #0x9591000
0066C4998  ldrb     w8, [x21, #0xa4b]
0066C499C  cbnz     w8, #0x66c49b4
0066C49A0  adrp     x0, #0x8ee5000
0066C49A4  ldr      x0, [x0, #0xb28]
0066C49A8  bl       #0x382bd14 ; 
0066C49AC  mov      w8, #1
0066C49B0  strb     w8, [x21, #0xa4b]
0066C49B4  adrp     x8, #0x8ee5000
0066C49B8  ldr      x8, [x8, #0xb28]
0066C49BC  ldr      x1, [x8]
0066C49C0  ldrb     w8, [x1, #0x53]
0066C49C4  tbnz     w8, #5, #0x66c49d0
0066C49C8  ldr      x21, [x19, #0x20]
0066C49CC  b        #0x66c49e0 ; 
0066C49D0  ldr      x8, [x1, #0x60]
0066C49D4  mov      x0, x19
0066C49D8  blr      x8
0066C49DC  mov      x21, x0
0066C49E0  cbz      x21, #0x66c4d64
0066C49E4  adrp     x27, #0x9591000
0066C49E8  ldrb     w8, [x27, #0xa4c]
0066C49EC  cbnz     w8, #0x66c4a04
0066C49F0  adrp     x0, #0x8ee5000
0066C49F4  ldr      x0, [x0, #0xb30]
0066C49F8  bl       #0x382bd14 ; 
0066C49FC  mov      w8, #1
0066C4A00  strb     w8, [x27, #0xa4c]
0066C4A04  adrp     x8, #0x8ee5000
0066C4A08  ldr      x8, [x8, #0xb30]
0066C4A0C  ldr      x1, [x8]
0066C4A10  ldrb     w8, [x1, #0x53]
0066C4A14  tbnz     w8, #5, #0x66c4a20
0066C4A18  ldr      x0, [x21, #0x210]
0066C4A1C  b        #0x66c4a2c ; 
0066C4A20  ldr      x8, [x1, #0x60]
0066C4A24  mov      x0, x21
0066C4A28  blr      x8
0066C4A2C  cbz      x0, #0x66c4d64
0066C4A30  adrp     x8, #0x8f11000
0066C4A34  ldr      x8, [x8, #0xe40]
0066C4A38  ldr      x1, [x8]
0066C4A3C  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C4A40  adrp     x8, #0x8ee6000
0066C4A44  ldr      x8, [x8, #0x600]
0066C4A48  mov      x21, x0
0066C4A4C  ldr      x1, [x8]
0066C4A50  ldrb     w8, [x1, #0x53]
0066C4A54  tbnz     w8, #5, #0x66c4a60
0066C4A58  ldr      x0, [x19, #0x38]
0066C4A5C  b        #0x66c4a6c ; 
0066C4A60  ldr      x8, [x1, #0x60]
0066C4A64  mov      x0, x19
0066C4A68  blr      x8
0066C4A6C  cbz      x0, #0x66c4d64
0066C4A70  add      x8, sp, #8
0066C4A74  mov      x1, xzr
0066C4A78  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066C4A7C  ldur     q0, [sp, #8]
0066C4A80  ldr      x8, [sp, #0x18]
0066C4A84  str      q0, [sp, #0x20]
0066C4A88  str      x8, [sp, #0x30]
0066C4A8C  cbz      x21, #0x66c4d64
0066C4A90  ldr      x8, [sp, #0x30]
0066C4A94  ldr      q0, [sp, #0x20]
0066C4A98  str      x8, [x21, #0x30]
0066C4A9C  str      q0, [x21, #0x20]
0066C4AA0  ldr      w8, [x22]
0066C4AA4  str      w8, [x21, #0x50]
0066C4AA8  ldr      x1, [x23]
0066C4AAC  ldrb     w8, [x1, #0x53]
0066C4AB0  tbnz     w8, #5, #0x66c4abc
0066C4AB4  ldr      x0, [x19, #0x30]
0066C4AB8  b        #0x66c4ac8 ; 
0066C4ABC  ldr      x8, [x1, #0x60]
0066C4AC0  mov      x0, x19
0066C4AC4  blr      x8
0066C4AC8  cbz      x0, #0x66c4d64
0066C4ACC  adrp     x8, #0x8ee6000
0066C4AD0  ldr      x8, [x8, #0xe8]
0066C4AD4  ldr      x1, [x8]
0066C4AD8  ldrb     w8, [x1, #0x53]
0066C4ADC  tbnz     w8, #5, #0x66c4ae8
0066C4AE0  ldr      x0, [x0, #0x28]
0066C4AE4  b        #0x66c4af0 ; 
0066C4AE8  ldr      x8, [x1, #0x60]
0066C4AEC  blr      x8
0066C4AF0  str      x0, [x21, #0x48]
0066C4AF4  ldrb     w8, [x24, #0x27d]
0066C4AF8  cbnz     w8, #0x66c4b10
0066C4AFC  adrp     x0, #0x8f11000
0066C4B00  ldr      x0, [x0, #0xde8]
0066C4B04  bl       #0x382bd14 ; 
0066C4B08  mov      w8, #1
0066C4B0C  strb     w8, [x24, #0x27d]
0066C4B10  ldr      x1, [x25]
0066C4B14  ldrb     w8, [x1, #0x53]
0066C4B18  tbnz     w8, #5, #0x66c4b24
0066C4B1C  ldr      x0, [x20, #0xf8]
0066C4B20  b        #0x66c4b30 ; 
0066C4B24  ldr      x8, [x1, #0x60]
0066C4B28  mov      x0, x20
0066C4B2C  blr      x8
0066C4B30  str      x0, [x21, #0x38]
0066C4B34  ldr      x1, [x23]
0066C4B38  ldrb     w8, [x1, #0x53]
0066C4B3C  tbnz     w8, #5, #0x66c4b48
0066C4B40  ldr      x0, [x19, #0x30]
0066C4B44  b        #0x66c4b54 ; 
0066C4B48  ldr      x8, [x1, #0x60]
0066C4B4C  mov      x0, x19
0066C4B50  blr      x8
0066C4B54  cbz      x0, #0x66c4d64
0066C4B58  ldr      w8, [x0, #0xd0]
0066C4B5C  adrp     x22, #0x959a000
0066C4B60  str      w8, [x21, #0x54]
0066C4B64  ldrb     w8, [x22, #0x27a]
0066C4B68  cbnz     w8, #0x66c4b80
0066C4B6C  adrp     x0, #0x8f11000
0066C4B70  ldr      x0, [x0, #0x9f8]
0066C4B74  bl       #0x382bd14 ; 
0066C4B78  mov      w8, #1
0066C4B7C  strb     w8, [x22, #0x27a]
0066C4B80  adrp     x8, #0x8f11000
0066C4B84  ldr      x8, [x8, #0x9f8]
0066C4B88  ldr      x1, [x8]
0066C4B8C  ldrb     w8, [x1, #0x53]
0066C4B90  tbnz     w8, #5, #0x66c4b9c
0066C4B94  ldr      w0, [x20, #0x28]
0066C4B98  b        #0x66c4ba8 ; 
0066C4B9C  ldr      x8, [x1, #0x60]
0066C4BA0  mov      x0, x20
0066C4BA4  blr      x8
0066C4BA8  str      w0, [x21, #0x58]
0066C4BAC  adrp     x22, #0x959a000
0066C4BB0  ldrb     w8, [x22, #0x27e]
0066C4BB4  cbnz     w8, #0x66c4bcc
0066C4BB8  adrp     x0, #0x8f11000
0066C4BBC  ldr      x0, [x0, #0xdf0]
0066C4BC0  bl       #0x382bd14 ; 
0066C4BC4  mov      w8, #1
0066C4BC8  strb     w8, [x22, #0x27e]
0066C4BCC  adrp     x8, #0x8f11000
0066C4BD0  ldr      x8, [x8, #0xdf0]
0066C4BD4  ldr      x1, [x8]
0066C4BD8  ldrb     w8, [x1, #0x53]
0066C4BDC  tbnz     w8, #5, #0x66c4be8
0066C4BE0  ldr      x0, [x20, #0x118]
0066C4BE4  b        #0x66c4bf4 ; 
0066C4BE8  ldr      x8, [x1, #0x60]
0066C4BEC  mov      x0, x20
0066C4BF0  blr      x8
0066C4BF4  str      x0, [x21, #0x60]
0066C4BF8  ldr      x1, [x23]
0066C4BFC  ldrb     w8, [x1, #0x53]
0066C4C00  tbnz     w8, #5, #0x66c4c0c
0066C4C04  ldr      x20, [x19, #0x30]
0066C4C08  b        #0x66c4c1c ; 
0066C4C0C  ldr      x8, [x1, #0x60]
0066C4C10  mov      x0, x19
0066C4C14  blr      x8
0066C4C18  mov      x20, x0
0066C4C1C  cbz      x20, #0x66c4d64
0066C4C20  adrp     x22, #0x9591000
0066C4C24  ldrb     w8, [x22, #0xa86]
0066C4C28  cbnz     w8, #0x66c4c4c
0066C4C2C  adrp     x0, #0x8ee6000
0066C4C30  ldr      x0, [x0, #0x318]
0066C4C34  bl       #0x382bd14 ; 
0066C4C38  adrp     x0, #0x8ee3000
0066C4C3C  ldr      x0, [x0, #0xf18]
0066C4C40  bl       #0x382bd14 ; 
0066C4C44  mov      w8, #1
0066C4C48  strb     w8, [x22, #0xa86]
0066C4C4C  adrp     x8, #0x8ee6000
0066C4C50  ldr      x8, [x8, #0x318]
0066C4C54  ldr      x2, [x8]
0066C4C58  ldrb     w8, [x2, #0x53]
0066C4C5C  tbnz     w8, #5, #0x66c4c84
0066C4C60  ldr      x0, [x20, #0x190]
0066C4C64  cbz      x0, #0x66c4cd0
0066C4C68  adrp     x8, #0x8ee3000
0066C4C6C  ldr      x8, [x8, #0xf18]
0066C4C70  mov      w1, #0x3e
0066C4C74  ldr      x2, [x8]
0066C4C78  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
0066C4C7C  tbnz     w0, #0, #0x66c4c98
0066C4C80  b        #0x66c4cd0 ; 
0066C4C84  ldr      x8, [x2, #0x60]
0066C4C88  mov      w1, #0x3e
0066C4C8C  mov      x0, x20
0066C4C90  blr      x8
0066C4C94  tbz      w0, #0, #0x66c4cd0
0066C4C98  ldr      x1, [x23]
0066C4C9C  ldrb     w8, [x1, #0x53]
0066C4CA0  tbnz     w8, #5, #0x66c4cac
0066C4CA4  ldr      x0, [x19, #0x30]
0066C4CA8  b        #0x66c4cb8 ; 
0066C4CAC  ldr      x8, [x1, #0x60]
0066C4CB0  mov      x0, x19
0066C4CB4  blr      x8
0066C4CB8  cbz      x0, #0x66c4d64
0066C4CBC  ldr      x0, [x0, #0x150]
0066C4CC0  cbz      x0, #0x66c4d64
0066C4CC4  mov      x1, x21
0066C4CC8  mov      x2, xzr
0066C4CCC  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066C4CD0  ldr      x1, [x23]
0066C4CD4  ldrb     w8, [x1, #0x53]
0066C4CD8  tbnz     w8, #5, #0x66c4ce4
0066C4CDC  ldr      x0, [x19, #0x30]
0066C4CE0  b        #0x66c4cf0 ; 
0066C4CE4  ldr      x8, [x1, #0x60]
0066C4CE8  mov      x0, x19
0066C4CEC  blr      x8
0066C4CF0  cbz      x0, #0x66c4d64
0066C4CF4  adrp     x8, #0x8ee6000
0066C4CF8  ldr      x8, [x8, #0xd8]
0066C4CFC  ldr      x1, [x8]
0066C4D00  ldrb     w8, [x1, #0x53]
0066C4D04  tbnz     w8, #5, #0x66c4d10
0066C4D08  ldr      x0, [x0, #0x38]
0066C4D0C  b        #0x66c4d18 ; 
0066C4D10  ldr      x8, [x1, #0x60]
0066C4D14  blr      x8
0066C4D18  cbz      x0, #0x66c4d64
0066C4D1C  mov      x1, xzr
0066C4D20  bl       #0x45616a8 ; 
0066C4D24  tbz      w0, #0, #0x66c4d34
0066C4D28  mov      x0, x19
0066C4D2C  mov      x1, x21
0066C4D30  bl       #0x66c4ffc ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroHurtAfterHPChange
0066C4D34  ldr      x8, [x26, #0x28]
0066C4D38  ldr      x9, [sp, #0x58]
0066C4D3C  cmp      x8, x9
0066C4D40  b.ne     #0x66c4d68
0066C4D44  ldp      x20, x19, [sp, #0xb0]
0066C4D48  ldp      x22, x21, [sp, #0xa0]
0066C4D4C  ldp      x24, x23, [sp, #0x90]
0066C4D50  ldp      x26, x25, [sp, #0x80]
0066C4D54  ldp      x28, x27, [sp, #0x70]
0066C4D58  ldr      x30, [sp, #0x60]
0066C4D5C  add      sp, sp, #0xc0
0066C4D60  ret      
0066C4D64  bl       #0x382bfb8 ; 
0066C4D68  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$UpdateEntityHp
; RVA 0x66C40E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C40E0  sub      sp, sp, #0x120
0066C40E4  stp      x29, x30, [sp, #0xc0]
0066C40E8  stp      x28, x27, [sp, #0xd0]
0066C40EC  stp      x26, x25, [sp, #0xe0]
0066C40F0  stp      x24, x23, [sp, #0xf0]
0066C40F4  stp      x22, x21, [sp, #0x100]
0066C40F8  stp      x20, x19, [sp, #0x110]
0066C40FC  mrs      x20, tpidr_el0
0066C4100  ldr      x8, [x20, #0x28]
0066C4104  adrp     x21, #0x959a000
0066C4108  adrp     x22, #0x8f11000
0066C410C  mov      w23, w6
0066C4110  str      x8, [sp, #0xb8]
0066C4114  ldrb     w8, [x21, #0x24c]
0066C4118  ldr      x22, [x22, #0xe18]
0066C411C  mov      x27, x5
0066C4120  mov      x24, x4
0066C4124  mov      w28, w3
0066C4128  mov      w29, w2
0066C412C  mov      x25, x1
0066C4130  mov      x19, x0
0066C4134  tbnz     w8, #0, #0x66c4164
0066C4138  adrp     x0, #0x8f11000
0066C413C  ldr      x0, [x0, #0xe18]
0066C4140  bl       #0x382bd14 ; 
0066C4144  adrp     x0, #0x8ee6000
0066C4148  ldr      x0, [x0, #0x608]
0066C414C  bl       #0x382bd14 ; 
0066C4150  adrp     x0, #0x8f11000
0066C4154  ldr      x0, [x0, #0xd78]
0066C4158  bl       #0x382bd14 ; 
0066C415C  mov      w8, #1
0066C4160  strb     w8, [x21, #0x24c]
0066C4164  ldr      x7, [x22]
0066C4168  ldrb     w8, [x7, #0x53]
0066C416C  tbnz     w8, #5, #0x66c41ac
0066C4170  adrp     x21, #0x9591000
0066C4174  ldrb     w8, [x21, #0xa4b]
0066C4178  cbnz     w8, #0x66c4190
0066C417C  adrp     x0, #0x8ee5000
0066C4180  ldr      x0, [x0, #0xb28]
0066C4184  bl       #0x382bd14 ; 
0066C4188  mov      w8, #1
0066C418C  strb     w8, [x21, #0xa4b]
0066C4190  adrp     x8, #0x8ee5000
0066C4194  ldr      x8, [x8, #0xb28]
0066C4198  ldr      x1, [x8]
0066C419C  ldrb     w8, [x1, #0x53]
0066C41A0  tbnz     w8, #5, #0x66c41e4
0066C41A4  ldr      x26, [x19, #0x20]
0066C41A8  b        #0x66c41f4 ; 
0066C41AC  ldr      x8, [x24, #0x10]
0066C41B0  ldr      q0, [x24]
0066C41B4  ldr      x9, [x7, #0x60]
0066C41B8  and      w3, w28, #1
0066C41BC  add      x4, sp, #0xa0
0066C41C0  mov      x0, x19
0066C41C4  mov      x1, x25
0066C41C8  mov      w2, w29
0066C41CC  mov      x5, x27
0066C41D0  mov      w6, w23
0066C41D4  str      x8, [sp, #0xb0]
0066C41D8  str      q0, [sp, #0xa0]
0066C41DC  blr      x9
0066C41E0  b        #0x66c44f0 ; 
0066C41E4  ldr      x8, [x1, #0x60]
0066C41E8  mov      x0, x19
0066C41EC  blr      x8
0066C41F0  mov      x26, x0
0066C41F4  cbz      x26, #0x66c4520
0066C41F8  adrp     x21, #0x9591000
0066C41FC  ldrb     w8, [x21, #0xa4c]
0066C4200  cbnz     w8, #0x66c4218
0066C4204  adrp     x0, #0x8ee5000
0066C4208  ldr      x0, [x0, #0xb30]
0066C420C  bl       #0x382bd14 ; 
0066C4210  mov      w8, #1
0066C4214  strb     w8, [x21, #0xa4c]
0066C4218  adrp     x8, #0x8ee5000
0066C421C  ldr      x8, [x8, #0xb30]
0066C4220  ldr      x1, [x8]
0066C4224  ldrb     w8, [x1, #0x53]
0066C4228  tbnz     w8, #5, #0x66c4234
0066C422C  ldr      x0, [x26, #0x210]
0066C4230  b        #0x66c4240 ; 
0066C4234  ldr      x8, [x1, #0x60]
0066C4238  mov      x0, x26
0066C423C  blr      x8
0066C4240  cbz      x0, #0x66c4520
0066C4244  adrp     x8, #0x8f11000
0066C4248  ldr      x8, [x8, #0xd78]
0066C424C  ldr      x1, [x8]
0066C4250  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066C4254  cbz      x25, #0x66c4520
0066C4258  adrp     x21, #0x959a000
0066C425C  ldrb     w8, [x21, #0x282]
0066C4260  mov      x26, x0
0066C4264  cbnz     w8, #0x66c427c
0066C4268  adrp     x0, #0x8f11000
0066C426C  ldr      x0, [x0, #0xe20]
0066C4270  bl       #0x382bd14 ; 
0066C4274  mov      w8, #1
0066C4278  strb     w8, [x21, #0x282]
0066C427C  str      x27, [sp, #0x30]
0066C4280  adrp     x8, #0x8f11000
0066C4284  ldr      x8, [x8, #0xe20]
0066C4288  ldr      x1, [x8]
0066C428C  ldrb     w8, [x1, #0x53]
0066C4290  tbnz     w8, #5, #0x66c429c
0066C4294  ldr      x27, [x25, #0x108]
0066C4298  b        #0x66c42ac ; 
0066C429C  ldr      x8, [x1, #0x60]
0066C42A0  mov      x0, x25
0066C42A4  blr      x8
0066C42A8  mov      x27, x0
0066C42AC  mov      x0, xzr
0066C42B0  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
0066C42B4  mov      x1, x0
0066C42B8  mov      x0, x27
0066C42BC  mov      x2, xzr
0066C42C0  bl       #0x7db81f0 ; Quantum.EntityRef$$op_Equality
0066C42C4  adrp     x21, #0x8f11000
0066C42C8  ldr      x21, [x21, #0xde8]
0066C42CC  adrp     x22, #0x959a000
0066C42D0  tbz      w0, #0, #0x66c4314
0066C42D4  ldrb     w8, [x22, #0x27d]
0066C42D8  cbnz     w8, #0x66c42f0
0066C42DC  adrp     x0, #0x8f11000
0066C42E0  ldr      x0, [x0, #0xde8]
0066C42E4  bl       #0x382bd14 ; 
0066C42E8  mov      w8, #1
0066C42EC  strb     w8, [x22, #0x27d]
0066C42F0  ldr      x1, [x21]
0066C42F4  ldrb     w8, [x1, #0x53]
0066C42F8  tbnz     w8, #5, #0x66c4304
0066C42FC  ldr      x27, [x25, #0xf8]
0066C4300  b        #0x66c4314 ; 
0066C4304  ldr      x8, [x1, #0x60]
0066C4308  mov      x0, x25
0066C430C  blr      x8
0066C4310  mov      x27, x0
0066C4314  str      w28, [sp, #0x3c]
0066C4318  adrp     x28, #0x959a000
0066C431C  ldrb     w8, [x28, #0x27a]
0066C4320  str      w23, [sp, #0x2c]
0066C4324  cbnz     w8, #0x66c433c
0066C4328  adrp     x0, #0x8f11000
0066C432C  ldr      x0, [x0, #0x9f8]
0066C4330  bl       #0x382bd14 ; 
0066C4334  mov      w8, #1
0066C4338  strb     w8, [x28, #0x27a]
0066C433C  adrp     x21, #0x8f11000
0066C4340  ldr      x21, [x21, #0x9f8]
0066C4344  mov      w22, w29
0066C4348  ldr      x1, [x21]
0066C434C  ldrb     w8, [x1, #0x53]
0066C4350  tbnz     w8, #5, #0x66c435c
0066C4354  ldr      w29, [x25, #0x28]
0066C4358  b        #0x66c4388 ; 
0066C435C  ldr      x8, [x1, #0x60]
0066C4360  mov      x0, x25
0066C4364  blr      x8
0066C4368  ldrb     w8, [x28, #0x27a]
0066C436C  mov      w29, w0
0066C4370  cbnz     w8, #0x66c4388
0066C4374  adrp     x0, #0x8f11000
0066C4378  ldr      x0, [x0, #0x9f8]
0066C437C  bl       #0x382bd14 ; 
0066C4380  mov      w8, #1
0066C4384  strb     w8, [x28, #0x27a]
0066C4388  ldr      x1, [x21]
0066C438C  ldrb     w8, [x1, #0x53]
0066C4390  tbnz     w8, #5, #0x66c43a0
0066C4394  ldr      w28, [x25, #0x28]
0066C4398  mov      x23, x19
0066C439C  b        #0x66c43b4 ; 
0066C43A0  ldr      x8, [x1, #0x60]
0066C43A4  mov      x0, x25
0066C43A8  mov      x23, x19
0066C43AC  blr      x8
0066C43B0  mov      w28, w0
0066C43B4  adrp     x21, #0x8f11000
0066C43B8  adrp     x19, #0x959a000
0066C43BC  ldr      x21, [x21, #0xde8]
0066C43C0  ldrb     w8, [x19, #0x27d]
0066C43C4  cbnz     w8, #0x66c43dc
0066C43C8  adrp     x0, #0x8f11000
0066C43CC  ldr      x0, [x0, #0xde8]
0066C43D0  bl       #0x382bd14 ; 
0066C43D4  mov      w8, #1
0066C43D8  strb     w8, [x19, #0x27d]
0066C43DC  ldr      x1, [x21]
0066C43E0  ldrb     w8, [x1, #0x53]
0066C43E4  tbnz     w8, #5, #0x66c43f0
0066C43E8  ldr      x4, [x25, #0xf8]
0066C43EC  b        #0x66c4400 ; 
0066C43F0  ldr      x8, [x1, #0x60]
0066C43F4  mov      x0, x25
0066C43F8  blr      x8
0066C43FC  mov      x4, x0
0066C4400  cmp      w29, #1
0066C4404  b.ne     #0x66c4458
0066C4408  ldr      x8, [x24, #0x10]
0066C440C  ldr      q0, [x24]
0066C4410  str      x8, [sp, #0x90]
0066C4414  str      q0, [sp, #0x80]
0066C4418  cbz      x26, #0x66c4520
0066C441C  ldr      x8, [sp, #0x90]
0066C4420  ldr      q0, [sp, #0x80]
0066C4424  neg      w2, w22
0066C4428  str      xzr, [sp, #0x10]
0066C442C  str      x8, [sp, #0x70]
0066C4430  ldr      w8, [sp, #0x2c]
0066C4434  str      q0, [sp, #0x60]
0066C4438  add      x7, sp, #0x60
0066C443C  mov      w6, #1
0066C4440  str      w8, [sp, #8]
0066C4444  ldr      w8, [sp, #0x3c]
0066C4448  and      w5, w8, #1
0066C444C  ldr      x8, [sp, #0x30]
0066C4450  str      x8, [sp]
0066C4454  b        #0x66c4494 ; 
0066C4458  stp      xzr, xzr, [sp, #0x80]
0066C445C  str      xzr, [sp, #0x90]
0066C4460  cbz      x26, #0x66c4520
0066C4464  ldr      x8, [sp, #0x90]
0066C4468  ldr      q0, [sp, #0x80]
0066C446C  neg      w2, w22
0066C4470  add      x7, sp, #0x40
0066C4474  str      x8, [sp, #0x50]
0066C4478  ldr      w8, [sp, #0x3c]
0066C447C  mov      w6, #1
0066C4480  str      q0, [sp, #0x40]
0066C4484  str      xzr, [sp, #0x10]
0066C4488  and      w5, w8, #1
0066C448C  str      wzr, [sp, #8]
0066C4490  str      xzr, [sp]
0066C4494  mov      x0, x26
0066C4498  mov      w1, w28
0066C449C  mov      x3, x27
0066C44A0  bl       #0x682fa78 ; HotFix.BattleLogic.TakeDamageData$$Init
0066C44A4  adrp     x8, #0x8ee6000
0066C44A8  ldr      x8, [x8, #0x608]
0066C44AC  ldr      x1, [x8]
0066C44B0  ldrb     w8, [x1, #0x53]
0066C44B4  tbnz     w8, #5, #0x66c44c0
0066C44B8  ldr      x0, [x23, #0x30]
0066C44BC  b        #0x66c44cc ; 
0066C44C0  ldr      x8, [x1, #0x60]
0066C44C4  mov      x0, x23
0066C44C8  blr      x8
0066C44CC  cbz      x0, #0x66c4520
0066C44D0  ldr      x8, [x0]
0066C44D4  mov      x1, x26
0066C44D8  ldr      x9, [x8, #0x3b8]
0066C44DC  ldr      x2, [x8, #0x3c0]
0066C44E0  blr      x9
0066C44E4  mov      x0, x26
0066C44E8  mov      x1, xzr
0066C44EC  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0066C44F0  ldr      x8, [x20, #0x28]
0066C44F4  ldr      x9, [sp, #0xb8]
0066C44F8  cmp      x8, x9
0066C44FC  b.ne     #0x66c4524
0066C4500  ldp      x20, x19, [sp, #0x110]
0066C4504  ldp      x22, x21, [sp, #0x100]
0066C4508  ldp      x24, x23, [sp, #0xf0]
0066C450C  ldp      x26, x25, [sp, #0xe0]
0066C4510  ldp      x28, x27, [sp, #0xd0]
0066C4514  ldp      x29, x30, [sp, #0xc0]
0066C4518  add      sp, sp, #0x120
0066C451C  ret      
0066C4520  bl       #0x382bfb8 ; 
0066C4524  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$HandlePostHpUpdateEffects
; RVA 0x66C4528; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C4528  sub      sp, sp, #0x60
0066C452C  str      x30, [sp, #0x30]
0066C4530  stp      x22, x21, [sp, #0x40]
0066C4534  stp      x20, x19, [sp, #0x50]
0066C4538  adrp     x19, #0x959a000
0066C453C  adrp     x22, #0x8f11000
0066C4540  ldrb     w8, [x19, #0x24d]
0066C4544  ldr      x22, [x22, #0xe28]
0066C4548  mov      x20, x1
0066C454C  mov      x21, x0
0066C4550  tbnz     w8, #0, #0x66c458c
0066C4554  adrp     x0, #0x8f11000
0066C4558  ldr      x0, [x0, #0xe28]
0066C455C  bl       #0x382bd14 ; 
0066C4560  adrp     x0, #0x8ee6000
0066C4564  ldr      x0, [x0, #0xd8]
0066C4568  bl       #0x382bd14 ; 
0066C456C  adrp     x0, #0x8ee6000
0066C4570  ldr      x0, [x0, #0x108]
0066C4574  bl       #0x382bd14 ; 
0066C4578  adrp     x0, #0x8f09000
0066C457C  ldr      x0, [x0, #0x178]
0066C4580  bl       #0x382bd14 ; 
0066C4584  mov      w8, #1
0066C4588  strb     w8, [x19, #0x24d]
0066C458C  ldr      x2, [x22]
0066C4590  ldrb     w8, [x2, #0x53]
0066C4594  tbnz     w8, #5, #0x66c45d8
0066C4598  cbz      x20, #0x66c4818
0066C459C  adrp     x19, #0x959a000
0066C45A0  ldrb     w8, [x19, #0x283]
0066C45A4  cbnz     w8, #0x66c45bc
0066C45A8  adrp     x0, #0x8f11000
0066C45AC  ldr      x0, [x0, #0xe30]
0066C45B0  bl       #0x382bd14 ; 
0066C45B4  mov      w8, #1
0066C45B8  strb     w8, [x19, #0x283]
0066C45BC  adrp     x8, #0x8f11000
0066C45C0  ldr      x8, [x8, #0xe30]
0066C45C4  ldr      x1, [x8]
0066C45C8  ldrb     w8, [x1, #0x53]
0066C45CC  tbnz     w8, #5, #0x66c45f8
0066C45D0  ldr      x19, [x20, #0x88]
0066C45D4  b        #0x66c4608 ; 
0066C45D8  ldr      x3, [x2, #0x60]
0066C45DC  mov      x0, x21
0066C45E0  mov      x1, x20
0066C45E4  ldp      x20, x19, [sp, #0x50]
0066C45E8  ldp      x22, x21, [sp, #0x40]
0066C45EC  ldr      x30, [sp, #0x30]
0066C45F0  add      sp, sp, #0x60
0066C45F4  br       x3
0066C45F8  ldr      x8, [x1, #0x60]
0066C45FC  mov      x0, x20
0066C4600  blr      x8
0066C4604  mov      x19, x0
0066C4608  cmp      x19, #1
0066C460C  b.lt     #0x66c4804
0066C4610  adrp     x22, #0x9591000
0066C4614  ldrb     w8, [x22, #0xa4b]
0066C4618  cbnz     w8, #0x66c4630
0066C461C  adrp     x0, #0x8ee5000
0066C4620  ldr      x0, [x0, #0xb28]
0066C4624  bl       #0x382bd14 ; 
0066C4628  mov      w8, #1
0066C462C  strb     w8, [x22, #0xa4b]
0066C4630  adrp     x8, #0x8ee5000
0066C4634  ldr      x8, [x8, #0xb28]
0066C4638  ldr      x1, [x8]
0066C463C  ldrb     w8, [x1, #0x53]
0066C4640  tbnz     w8, #5, #0x66c464c
0066C4644  ldr      x21, [x21, #0x20]
0066C4648  b        #0x66c465c ; 
0066C464C  ldr      x8, [x1, #0x60]
0066C4650  mov      x0, x21
0066C4654  blr      x8
0066C4658  mov      x21, x0
0066C465C  cbz      x21, #0x66c4818
0066C4660  adrp     x22, #0x9591000
0066C4664  ldrb     w8, [x22, #0xa62]
0066C4668  cbnz     w8, #0x66c4680
0066C466C  adrp     x0, #0x8ee6000
0066C4670  ldr      x0, [x0, #0x1f8]
0066C4674  bl       #0x382bd14 ; 
0066C4678  mov      w8, #1
0066C467C  strb     w8, [x22, #0xa62]
0066C4680  adrp     x8, #0x8ee6000
0066C4684  ldr      x8, [x8, #0x1f8]
0066C4688  ldr      x1, [x8]
0066C468C  ldrb     w8, [x1, #0x53]
0066C4690  tbnz     w8, #5, #0x66c469c
0066C4694  ldr      x21, [x21, #0x1f8]
0066C4698  b        #0x66c46ac ; 
0066C469C  ldr      x8, [x1, #0x60]
0066C46A0  mov      x0, x21
0066C46A4  blr      x8
0066C46A8  mov      x21, x0
0066C46AC  adrp     x22, #0x959a000
0066C46B0  ldrb     w8, [x22, #0x280]
0066C46B4  cbnz     w8, #0x66c46cc
0066C46B8  adrp     x0, #0x8f11000
0066C46BC  ldr      x0, [x0, #0xe00]
0066C46C0  bl       #0x382bd14 ; 
0066C46C4  mov      w8, #1
0066C46C8  strb     w8, [x22, #0x280]
0066C46CC  adrp     x8, #0x8f11000
0066C46D0  ldr      x8, [x8, #0xe00]
0066C46D4  ldr      x1, [x8]
0066C46D8  ldrb     w8, [x1, #0x53]
0066C46DC  tbnz     w8, #5, #0x66c46e8
0066C46E0  ldr      x1, [x20, #0x100]
0066C46E4  b        #0x66c46f8 ; 
0066C46E8  ldr      x8, [x1, #0x60]
0066C46EC  mov      x0, x20
0066C46F0  blr      x8
0066C46F4  mov      x1, x0
0066C46F8  cbz      x21, #0x66c4818
0066C46FC  adrp     x8, #0x8ee6000
0066C4700  ldr      x8, [x8, #0x108]
0066C4704  mov      x0, x21
0066C4708  ldr      x2, [x8]
0066C470C  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066C4710  cbz      x0, #0x66c4804
0066C4714  adrp     x8, #0x8ee6000
0066C4718  ldr      x8, [x8, #0xd8]
0066C471C  mov      x20, x0
0066C4720  ldr      x1, [x8]
0066C4724  ldrb     w8, [x1, #0x53]
0066C4728  tbnz     w8, #5, #0x66c4734
0066C472C  ldr      x21, [x20, #0x38]
0066C4730  b        #0x66c4744 ; 
0066C4734  ldr      x8, [x1, #0x60]
0066C4738  mov      x0, x20
0066C473C  blr      x8
0066C4740  mov      x21, x0
0066C4744  cbz      x21, #0x66c4818
0066C4748  adrp     x22, #0x9591000
0066C474C  ldrb     w8, [x22, #0xa7f]
0066C4750  cbnz     w8, #0x66c4768
0066C4754  adrp     x0, #0x8ee6000
0066C4758  ldr      x0, [x0, #0x2d8]
0066C475C  bl       #0x382bd14 ; 
0066C4760  mov      w8, #1
0066C4764  strb     w8, [x22, #0xa7f]
0066C4768  adrp     x8, #0x8ee6000
0066C476C  ldr      x8, [x8, #0x2d8]
0066C4770  ldr      x1, [x8]
0066C4774  ldrb     w8, [x1, #0x53]
0066C4778  tbnz     w8, #5, #0x66c4784
0066C477C  ldr      x0, [x21, #0x178]
0066C4780  b        #0x66c4790 ; 
0066C4784  ldr      x8, [x1, #0x60]
0066C4788  mov      x0, x21
0066C478C  blr      x8
0066C4790  cbz      x0, #0x66c4818
0066C4794  mov      x1, x19
0066C4798  mov      x2, xzr
0066C479C  bl       #0x6b3c40c ; HotFix.Common.AttributeData$$GetHealHp
0066C47A0  ldr      x19, [x20, #0x158]
0066C47A4  mov      x20, x0
0066C47A8  mov      w0, #8
0066C47AC  mov      x1, xzr
0066C47B0  bl       #0x68e8874 ; HotFix.BattleLogic.HurtDeltaHpSourceInfo$$FromKind
0066C47B4  adrp     x8, #0x8f09000
0066C47B8  ldr      x8, [x8, #0x178]
0066C47BC  mov      x2, x0
0066C47C0  mov      x4, x1
0066C47C4  add      x0, sp, #0x18
0066C47C8  ldr      x3, [x8]
0066C47CC  mov      x1, x2
0066C47D0  mov      x2, x4
0066C47D4  stp      xzr, xzr, [sp, #0x18]
0066C47D8  str      xzr, [sp, #0x28]
0066C47DC  bl       #0x51360ac ; System.Nullable<HurtDeltaHpSourceInfo>$$.ctor
0066C47E0  cbz      x19, #0x66c4818
0066C47E4  ldur     q0, [sp, #0x18]
0066C47E8  ldr      x8, [sp, #0x28]
0066C47EC  mov      x2, sp
0066C47F0  mov      x0, x19
0066C47F4  mov      x1, x20
0066C47F8  str      q0, [sp]
0066C47FC  str      x8, [sp, #0x10]
0066C4800  bl       #0x66c269c ; HotFix.BattleLogic.CharacterComponentOnHit$$Heal
0066C4804  ldp      x20, x19, [sp, #0x50]
0066C4808  ldp      x22, x21, [sp, #0x40]
0066C480C  ldr      x30, [sp, #0x30]
0066C4810  add      sp, sp, #0x60
0066C4814  ret      
0066C4818  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndSetPreventEjectCountFlagsForNonHurtHit
; RVA 0x66C5144; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5144  str      x30, [sp, #-0x30]!
0066C5148  stp      x22, x21, [sp, #0x10]
0066C514C  stp      x20, x19, [sp, #0x20]
0066C5150  adrp     x21, #0x959a000
0066C5154  adrp     x22, #0x8f11000
0066C5158  ldrb     w8, [x21, #0x24e]
0066C515C  ldr      x22, [x22, #0xea8]
0066C5160  mov      x19, x1
0066C5164  mov      x20, x0
0066C5168  tbnz     w8, #0, #0x66c5198
0066C516C  adrp     x0, #0x8f11000
0066C5170  ldr      x0, [x0, #0xea8]
0066C5174  bl       #0x382bd14 ; 
0066C5178  adrp     x0, #0x8ee6000
0066C517C  ldr      x0, [x0, #0xe0]
0066C5180  bl       #0x382bd14 ; 
0066C5184  adrp     x0, #0x8ee6000
0066C5188  ldr      x0, [x0, #0x608]
0066C518C  bl       #0x382bd14 ; 
0066C5190  mov      w8, #1
0066C5194  strb     w8, [x21, #0x24e]
0066C5198  ldr      x2, [x22]
0066C519C  ldrb     w8, [x2, #0x53]
0066C51A0  tbnz     w8, #5, #0x66c51c8
0066C51A4  cbz      x19, #0x66c5240
0066C51A8  adrp     x8, #0x8ee6000
0066C51AC  ldr      x8, [x8, #0xe0]
0066C51B0  ldr      x1, [x8]
0066C51B4  ldrb     w8, [x1, #0x53]
0066C51B8  tbnz     w8, #5, #0x66c51e4
0066C51BC  ldr      x0, [x19, #0x38]
0066C51C0  cbnz     x0, #0x66c51f4
0066C51C4  b        #0x66c5240 ; 
0066C51C8  ldr      x3, [x2, #0x60]
0066C51CC  mov      x0, x20
0066C51D0  mov      x1, x19
0066C51D4  ldp      x20, x19, [sp, #0x20]
0066C51D8  ldp      x22, x21, [sp, #0x10]
0066C51DC  ldr      x30, [sp], #0x30
0066C51E0  br       x3
0066C51E4  ldr      x8, [x1, #0x60]
0066C51E8  mov      x0, x19
0066C51EC  blr      x8
0066C51F0  cbz      x0, #0x66c5240
0066C51F4  mov      x0, x19
0066C51F8  mov      x1, xzr
0066C51FC  bl       #0x6680c30 ; HotFix.BattleLogic.EntityBullet$$get_OwnerEntity
0066C5200  cbz      x0, #0x66c5240
0066C5204  adrp     x8, #0x8ee6000
0066C5208  ldr      x8, [x8, #0x608]
0066C520C  mov      x21, x0
0066C5210  ldr      x1, [x8]
0066C5214  ldrb     w8, [x1, #0x53]
0066C5218  tbnz     w8, #5, #0x66c5224
0066C521C  ldr      x0, [x20, #0x30]
0066C5220  b        #0x66c5230 ; 
0066C5224  ldr      x8, [x1, #0x60]
0066C5228  mov      x0, x20
0066C522C  blr      x8
0066C5230  cbz      x0, #0x66c526c
0066C5234  mov      x1, xzr
0066C5238  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0066C523C  tbz      w0, #0, #0x66c5250
0066C5240  ldp      x20, x19, [sp, #0x20]
0066C5244  ldp      x22, x21, [sp, #0x10]
0066C5248  ldr      x30, [sp], #0x30
0066C524C  ret      
0066C5250  mov      x0, x20
0066C5254  mov      x1, x19
0066C5258  mov      x2, x21
0066C525C  ldp      x20, x19, [sp, #0x20]
0066C5260  ldp      x22, x21, [sp, #0x10]
0066C5264  ldr      x30, [sp], #0x30
0066C5268  b        #0x66c5270 ; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndSetPreventEjectCountFlagsCore
0066C526C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndSetPreventEjectCountFlags
; RVA 0x66C3DE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C3DE0  str      x30, [sp, #-0x50]!
0066C3DE4  stp      x26, x25, [sp, #0x10]
0066C3DE8  stp      x24, x23, [sp, #0x20]
0066C3DEC  stp      x22, x21, [sp, #0x30]
0066C3DF0  stp      x20, x19, [sp, #0x40]
0066C3DF4  adrp     x22, #0x959a000
0066C3DF8  adrp     x23, #0x8f11000
0066C3DFC  ldrb     w8, [x22, #0x24f]
0066C3E00  ldr      x23, [x23, #0xe10]
0066C3E04  mov      x21, x2
0066C3E08  mov      x20, x1
0066C3E0C  mov      x19, x0
0066C3E10  tbnz     w8, #0, #0x66c3e58
0066C3E14  adrp     x0, #0x8f11000
0066C3E18  ldr      x0, [x0, #0xe10]
0066C3E1C  bl       #0x382bd14 ; 
0066C3E20  adrp     x0, #0x8ee6000
0066C3E24  ldr      x0, [x0, #0xe0]
0066C3E28  bl       #0x382bd14 ; 
0066C3E2C  adrp     x0, #0x8ee6000
0066C3E30  ldr      x0, [x0, #0x608]
0066C3E34  bl       #0x382bd14 ; 
0066C3E38  adrp     x0, #0x8eea000
0066C3E3C  ldr      x0, [x0, #0xf08]
0066C3E40  bl       #0x382bd14 ; 
0066C3E44  adrp     x0, #0x8ee6000
0066C3E48  ldr      x0, [x0, #0x108]
0066C3E4C  bl       #0x382bd14 ; 
0066C3E50  mov      w8, #1
0066C3E54  strb     w8, [x22, #0x24f]
0066C3E58  ldr      x3, [x23]
0066C3E5C  ldrb     w8, [x3, #0x53]
0066C3E60  tbnz     w8, #5, #0x66c3ea0
0066C3E64  adrp     x23, #0x9591000
0066C3E68  ldrb     w8, [x23, #0xa4b]
0066C3E6C  cbnz     w8, #0x66c3e84
0066C3E70  adrp     x0, #0x8ee5000
0066C3E74  ldr      x0, [x0, #0xb28]
0066C3E78  bl       #0x382bd14 ; 
0066C3E7C  mov      w8, #1
0066C3E80  strb     w8, [x23, #0xa4b]
0066C3E84  adrp     x25, #0x8ee5000
0066C3E88  ldr      x25, [x25, #0xb28]
0066C3E8C  ldr      x1, [x25]
0066C3E90  ldrb     w8, [x1, #0x53]
0066C3E94  tbnz     w8, #5, #0x66c3ec8
0066C3E98  ldr      x22, [x19, #0x20]
0066C3E9C  b        #0x66c3ed8 ; 
0066C3EA0  ldr      x4, [x3, #0x60]
0066C3EA4  mov      x0, x19
0066C3EA8  mov      x1, x20
0066C3EAC  mov      x2, x21
0066C3EB0  ldp      x20, x19, [sp, #0x40]
0066C3EB4  ldp      x22, x21, [sp, #0x30]
0066C3EB8  ldp      x24, x23, [sp, #0x20]
0066C3EBC  ldp      x26, x25, [sp, #0x10]
0066C3EC0  ldr      x30, [sp], #0x50
0066C3EC4  br       x4
0066C3EC8  ldr      x8, [x1, #0x60]
0066C3ECC  mov      x0, x19
0066C3ED0  blr      x8
0066C3ED4  mov      x22, x0
0066C3ED8  cbz      x22, #0x66c40dc
0066C3EDC  adrp     x24, #0x9591000
0066C3EE0  ldrb     w8, [x24, #0xa62]
0066C3EE4  cbnz     w8, #0x66c3efc
0066C3EE8  adrp     x0, #0x8ee6000
0066C3EEC  ldr      x0, [x0, #0x1f8]
0066C3EF0  bl       #0x382bd14 ; 
0066C3EF4  mov      w8, #1
0066C3EF8  strb     w8, [x24, #0xa62]
0066C3EFC  adrp     x26, #0x8ee6000
0066C3F00  ldr      x26, [x26, #0x1f8]
0066C3F04  ldr      x1, [x26]
0066C3F08  ldrb     w8, [x1, #0x53]
0066C3F0C  tbnz     w8, #5, #0x66c3f18
0066C3F10  ldr      x0, [x22, #0x1f8]
0066C3F14  b        #0x66c3f24 ; 
0066C3F18  ldr      x8, [x1, #0x60]
0066C3F1C  mov      x0, x22
0066C3F20  blr      x8
0066C3F24  cbz      x0, #0x66c40dc
0066C3F28  adrp     x8, #0x8eea000
0066C3F2C  ldr      x8, [x8, #0xf08]
0066C3F30  mov      x1, x21
0066C3F34  ldr      x2, [x8]
0066C3F38  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066C3F3C  ldrb     w8, [x23, #0xa4b]
0066C3F40  mov      x21, x0
0066C3F44  cbnz     w8, #0x66c3f5c
0066C3F48  adrp     x0, #0x8ee5000
0066C3F4C  ldr      x0, [x0, #0xb28]
0066C3F50  bl       #0x382bd14 ; 
0066C3F54  mov      w8, #1
0066C3F58  strb     w8, [x23, #0xa4b]
0066C3F5C  ldr      x1, [x25]
0066C3F60  ldrb     w8, [x1, #0x53]
0066C3F64  tbnz     w8, #5, #0x66c3f70
0066C3F68  ldr      x22, [x19, #0x20]
0066C3F6C  b        #0x66c3f80 ; 
0066C3F70  ldr      x8, [x1, #0x60]
0066C3F74  mov      x0, x19
0066C3F78  blr      x8
0066C3F7C  mov      x22, x0
0066C3F80  cbz      x22, #0x66c40dc
0066C3F84  ldrb     w8, [x24, #0xa62]
0066C3F88  cbnz     w8, #0x66c3fa0
0066C3F8C  adrp     x0, #0x8ee6000
0066C3F90  ldr      x0, [x0, #0x1f8]
0066C3F94  bl       #0x382bd14 ; 
0066C3F98  mov      w8, #1
0066C3F9C  strb     w8, [x24, #0xa62]
0066C3FA0  ldr      x1, [x26]
0066C3FA4  ldrb     w8, [x1, #0x53]
0066C3FA8  tbnz     w8, #5, #0x66c3fb4
0066C3FAC  ldr      x22, [x22, #0x1f8]
0066C3FB0  b        #0x66c3fc4 ; 
0066C3FB4  ldr      x8, [x1, #0x60]
0066C3FB8  mov      x0, x22
0066C3FBC  blr      x8
0066C3FC0  mov      x22, x0
0066C3FC4  cbz      x20, #0x66c40dc
0066C3FC8  adrp     x23, #0x959a000
0066C3FCC  ldrb     w8, [x23, #0x27d]
0066C3FD0  cbnz     w8, #0x66c3fe8
0066C3FD4  adrp     x0, #0x8f11000
0066C3FD8  ldr      x0, [x0, #0xde8]
0066C3FDC  bl       #0x382bd14 ; 
0066C3FE0  mov      w8, #1
0066C3FE4  strb     w8, [x23, #0x27d]
0066C3FE8  adrp     x8, #0x8f11000
0066C3FEC  ldr      x8, [x8, #0xde8]
0066C3FF0  ldr      x1, [x8]
0066C3FF4  ldrb     w8, [x1, #0x53]
0066C3FF8  tbnz     w8, #5, #0x66c4004
0066C3FFC  ldr      x1, [x20, #0xf8]
0066C4000  b        #0x66c4014 ; 
0066C4004  ldr      x8, [x1, #0x60]
0066C4008  mov      x0, x20
0066C400C  blr      x8
0066C4010  mov      x1, x0
0066C4014  cbz      x22, #0x66c40dc
0066C4018  adrp     x8, #0x8ee6000
0066C401C  ldr      x8, [x8, #0x108]
0066C4020  mov      x0, x22
0066C4024  ldr      x2, [x8]
0066C4028  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0066C402C  cbz      x21, #0x66c40a0
0066C4030  adrp     x8, #0x8ee6000
0066C4034  ldr      x8, [x8, #0xe0]
0066C4038  mov      x20, x0
0066C403C  ldr      x1, [x8]
0066C4040  ldrb     w8, [x1, #0x53]
0066C4044  tbnz     w8, #5, #0x66c4054
0066C4048  ldr      x0, [x21, #0x38]
0066C404C  cbnz     x20, #0x66c4064
0066C4050  b        #0x66c40a0 ; 
0066C4054  ldr      x8, [x1, #0x60]
0066C4058  mov      x0, x21
0066C405C  blr      x8
0066C4060  cbz      x20, #0x66c40a0
0066C4064  cbz      x0, #0x66c40a0
0066C4068  adrp     x8, #0x8ee6000
0066C406C  ldr      x8, [x8, #0x608]
0066C4070  ldr      x1, [x8]
0066C4074  ldrb     w8, [x1, #0x53]
0066C4078  tbnz     w8, #5, #0x66c4084
0066C407C  ldr      x0, [x19, #0x30]
0066C4080  b        #0x66c4090 ; 
0066C4084  ldr      x8, [x1, #0x60]
0066C4088  mov      x0, x19
0066C408C  blr      x8
0066C4090  cbz      x0, #0x66c40dc
0066C4094  mov      x1, xzr
0066C4098  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0066C409C  tbz      w0, #0, #0x66c40b8
0066C40A0  ldp      x20, x19, [sp, #0x40]
0066C40A4  ldp      x22, x21, [sp, #0x30]
0066C40A8  ldp      x24, x23, [sp, #0x20]
0066C40AC  ldp      x26, x25, [sp, #0x10]
0066C40B0  ldr      x30, [sp], #0x50
0066C40B4  ret      
0066C40B8  mov      x0, x19
0066C40BC  mov      x1, x21
0066C40C0  mov      x2, x20
0066C40C4  ldp      x20, x19, [sp, #0x40]
0066C40C8  ldp      x22, x21, [sp, #0x30]
0066C40CC  ldp      x24, x23, [sp, #0x20]
0066C40D0  ldp      x26, x25, [sp, #0x10]
0066C40D4  ldr      x30, [sp], #0x50
0066C40D8  b        #0x66c5270 ; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndSetPreventEjectCountFlagsCore
0066C40DC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CheckAndSetPreventEjectCountFlagsCore
; RVA 0x66C5270; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5270  stp      x29, x30, [sp, #-0x60]!
0066C5274  stp      x28, x27, [sp, #0x10]
0066C5278  stp      x26, x25, [sp, #0x20]
0066C527C  stp      x24, x23, [sp, #0x30]
0066C5280  stp      x22, x21, [sp, #0x40]
0066C5284  stp      x20, x19, [sp, #0x50]
0066C5288  adrp     x22, #0x959a000
0066C528C  adrp     x23, #0x8f11000
0066C5290  ldrb     w8, [x22, #0x250]
0066C5294  ldr      x23, [x23, #0xeb0]
0066C5298  mov      x19, x2
0066C529C  mov      x20, x1
0066C52A0  mov      x21, x0
0066C52A4  tbnz     w8, #0, #0x66c52ec
0066C52A8  adrp     x0, #0x8f11000
0066C52AC  ldr      x0, [x0, #0xeb0]
0066C52B0  bl       #0x382bd14 ; 
0066C52B4  adrp     x0, #0x8eea000
0066C52B8  ldr      x0, [x0, #0xf00]
0066C52BC  bl       #0x382bd14 ; 
0066C52C0  adrp     x0, #0x8ee6000
0066C52C4  ldr      x0, [x0, #0xd8]
0066C52C8  bl       #0x382bd14 ; 
0066C52CC  adrp     x0, #0x8ee6000
0066C52D0  ldr      x0, [x0, #0xe0]
0066C52D4  bl       #0x382bd14 ; 
0066C52D8  adrp     x0, #0x8ee6000
0066C52DC  ldr      x0, [x0, #0x608]
0066C52E0  bl       #0x382bd14 ; 
0066C52E4  mov      w8, #1
0066C52E8  strb     w8, [x22, #0x250]
0066C52EC  ldr      x3, [x23]
0066C52F0  ldrb     w8, [x3, #0x53]
0066C52F4  tbnz     w8, #5, #0x66c5314
0066C52F8  adrp     x8, #0x8ee6000
0066C52FC  ldr      x8, [x8, #0x608]
0066C5300  ldr      x1, [x8]
0066C5304  ldrb     w8, [x1, #0x53]
0066C5308  tbnz     w8, #5, #0x66c5340
0066C530C  ldr      x0, [x21, #0x30]
0066C5310  b        #0x66c534c ; 
0066C5314  ldr      x4, [x3, #0x60]
0066C5318  mov      x0, x21
0066C531C  mov      x1, x20
0066C5320  mov      x2, x19
0066C5324  ldp      x20, x19, [sp, #0x50]
0066C5328  ldp      x22, x21, [sp, #0x40]
0066C532C  ldp      x24, x23, [sp, #0x30]
0066C5330  ldp      x26, x25, [sp, #0x20]
0066C5334  ldp      x28, x27, [sp, #0x10]
0066C5338  ldp      x29, x30, [sp], #0x60
0066C533C  br       x4
0066C5340  ldr      x8, [x1, #0x60]
0066C5344  mov      x0, x21
0066C5348  blr      x8
0066C534C  cbz      x0, #0x66c5690
0066C5350  adrp     x8, #0x8eea000
0066C5354  ldr      x8, [x8, #0xf00]
0066C5358  ldr      x1, [x8]
0066C535C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0066C5360  cbz      x0, #0x66c5674
0066C5364  cbz      x20, #0x66c5690
0066C5368  adrp     x28, #0x8ee6000
0066C536C  ldr      x28, [x28, #0xe0]
0066C5370  mov      x22, x0
0066C5374  ldr      x1, [x28]
0066C5378  ldrb     w8, [x1, #0x53]
0066C537C  tbnz     w8, #5, #0x66c5388
0066C5380  ldr      x24, [x20, #0x38]
0066C5384  b        #0x66c5398 ; 
0066C5388  ldr      x8, [x1, #0x60]
0066C538C  mov      x0, x20
0066C5390  blr      x8
0066C5394  mov      x24, x0
0066C5398  cbz      x24, #0x66c5690
0066C539C  adrp     x8, #0x959a000
0066C53A0  ldrb     w8, [x8, #0x284]
0066C53A4  cbnz     w8, #0x66c53c0
0066C53A8  adrp     x0, #0x8f0f000
0066C53AC  ldr      x0, [x0, #0x860]
0066C53B0  bl       #0x382bd14 ; 
0066C53B4  mov      w8, #1
0066C53B8  adrp     x9, #0x959a000
0066C53BC  strb     w8, [x9, #0x284]
0066C53C0  adrp     x8, #0x8f0f000
0066C53C4  ldr      x8, [x8, #0x860]
0066C53C8  ldr      x2, [x8]
0066C53CC  ldrb     w8, [x2, #0x53]
0066C53D0  tbnz     w8, #5, #0x66c53dc
0066C53D4  strb     wzr, [x24, #0x97]
0066C53D8  b        #0x66c53ec ; 
0066C53DC  ldr      x8, [x2, #0x60]
0066C53E0  mov      x0, x24
0066C53E4  mov      w1, wzr
0066C53E8  blr      x8
0066C53EC  ldr      x1, [x28]
0066C53F0  ldrb     w8, [x1, #0x53]
0066C53F4  tbnz     w8, #5, #0x66c5400
0066C53F8  ldr      x25, [x20, #0x38]
0066C53FC  b        #0x66c5410 ; 
0066C5400  ldr      x8, [x1, #0x60]
0066C5404  mov      x0, x20
0066C5408  blr      x8
0066C540C  mov      x25, x0
0066C5410  cbz      x25, #0x66c5690
0066C5414  adrp     x8, #0x959a000
0066C5418  ldrb     w8, [x8, #0x285]
0066C541C  cbnz     w8, #0x66c5438
0066C5420  adrp     x0, #0x8f0f000
0066C5424  ldr      x0, [x0, #0x870]
0066C5428  bl       #0x382bd14 ; 
0066C542C  mov      w8, #1
0066C5430  adrp     x9, #0x959a000
0066C5434  strb     w8, [x9, #0x285]
0066C5438  adrp     x8, #0x8f0f000
0066C543C  ldr      x8, [x8, #0x870]
0066C5440  ldr      x2, [x8]
0066C5444  ldrb     w8, [x2, #0x53]
0066C5448  tbnz     w8, #5, #0x66c5454
0066C544C  strb     wzr, [x25, #0x98]
0066C5450  b        #0x66c5464 ; 
0066C5454  ldr      x8, [x2, #0x60]
0066C5458  mov      x0, x25
0066C545C  mov      w1, wzr
0066C5460  blr      x8
0066C5464  adrp     x23, #0x8ee6000
0066C5468  adrp     x26, #0x8ee5000
0066C546C  ldr      x23, [x23, #0xd8]
0066C5470  ldr      x26, [x26, #0xb28]
0066C5474  mov      w25, wzr
0066C5478  adrp     x29, #0x9591000
0066C547C  mov      w24, #1
0066C5480  mov      x0, x22
0066C5484  mov      w1, w25
0066C5488  mov      x2, xzr
0066C548C  bl       #0x6694280 ; HotFix.BattleLogic.CharacterComponentBuff$$CheckBuffFLag
0066C5490  tbz      w0, #0, #0x66c5668
0066C5494  cbz      x19, #0x66c5690
0066C5498  ldr      x1, [x23]
0066C549C  ldrb     w8, [x1, #0x53]
0066C54A0  tbnz     w8, #5, #0x66c54ac
0066C54A4  ldr      x27, [x19, #0x38]
0066C54A8  b        #0x66c54bc ; 
0066C54AC  ldr      x8, [x1, #0x60]
0066C54B0  mov      x0, x19
0066C54B4  blr      x8
0066C54B8  mov      x27, x0
0066C54BC  ldrb     w8, [x29, #0xa4b]
0066C54C0  cbnz     w8, #0x66c54d0
0066C54C4  mov      x0, x26
0066C54C8  bl       #0x382bd14 ; 
0066C54CC  strb     w24, [x29, #0xa4b]
0066C54D0  ldr      x1, [x26]
0066C54D4  ldrb     w8, [x1, #0x53]
0066C54D8  tbnz     w8, #5, #0x66c54e4
0066C54DC  ldr      x2, [x21, #0x20]
0066C54E0  b        #0x66c54f4 ; 
0066C54E4  ldr      x8, [x1, #0x60]
0066C54E8  mov      x0, x21
0066C54EC  blr      x8
0066C54F0  mov      x2, x0
0066C54F4  cbz      x27, #0x66c5690
0066C54F8  mov      x0, x27
0066C54FC  mov      w1, w25
0066C5500  mov      x3, xzr
0066C5504  bl       #0x681fcc0 ; HotFix.BattleLogic.EntityCharacterData$$ShouldPreventEjectCount
0066C5508  tbz      w0, #0, #0x66c5580
0066C550C  ldr      x1, [x28]
0066C5510  ldrb     w8, [x1, #0x53]
0066C5514  tbnz     w8, #5, #0x66c5520
0066C5518  ldr      x27, [x20, #0x38]
0066C551C  b        #0x66c5530 ; 
0066C5520  ldr      x8, [x1, #0x60]
0066C5524  mov      x0, x20
0066C5528  blr      x8
0066C552C  mov      x27, x0
0066C5530  cbz      x27, #0x66c5690
0066C5534  adrp     x8, #0x959a000
0066C5538  ldrb     w8, [x8, #0x284]
0066C553C  cbnz     w8, #0x66c5554
0066C5540  adrp     x0, #0x8f0f000
0066C5544  ldr      x0, [x0, #0x860]
0066C5548  bl       #0x382bd14 ; 
0066C554C  adrp     x8, #0x959a000
0066C5550  strb     w24, [x8, #0x284]
0066C5554  adrp     x8, #0x8f0f000
0066C5558  ldr      x8, [x8, #0x860]
0066C555C  ldr      x2, [x8]
0066C5560  ldrb     w8, [x2, #0x53]
0066C5564  tbnz     w8, #5, #0x66c5570
0066C5568  strb     w24, [x27, #0x97]
0066C556C  b        #0x66c5580 ; 
0066C5570  ldr      x8, [x2, #0x60]
0066C5574  mov      w1, #1
0066C5578  mov      x0, x27
0066C557C  blr      x8
0066C5580  ldr      x1, [x23]
0066C5584  ldrb     w8, [x1, #0x53]
0066C5588  tbnz     w8, #5, #0x66c5594
0066C558C  ldr      x27, [x19, #0x38]
0066C5590  b        #0x66c55a4 ; 
0066C5594  ldr      x8, [x1, #0x60]
0066C5598  mov      x0, x19
0066C559C  blr      x8
0066C55A0  mov      x27, x0
0066C55A4  ldrb     w8, [x29, #0xa4b]
0066C55A8  cbnz     w8, #0x66c55b8
0066C55AC  mov      x0, x26
0066C55B0  bl       #0x382bd14 ; 
0066C55B4  strb     w24, [x29, #0xa4b]
0066C55B8  ldr      x1, [x26]
0066C55BC  ldrb     w8, [x1, #0x53]
0066C55C0  tbnz     w8, #5, #0x66c55cc
0066C55C4  ldr      x2, [x21, #0x20]
0066C55C8  b        #0x66c55dc ; 
0066C55CC  ldr      x8, [x1, #0x60]
0066C55D0  mov      x0, x21
0066C55D4  blr      x8
0066C55D8  mov      x2, x0
0066C55DC  cbz      x27, #0x66c5690
0066C55E0  mov      x0, x27
0066C55E4  mov      w1, w25
0066C55E8  mov      x3, xzr
0066C55EC  bl       #0x681ff80 ; HotFix.BattleLogic.EntityCharacterData$$ShouldPreventFlashChainEjectCount
0066C55F0  tbz      w0, #0, #0x66c5668
0066C55F4  ldr      x1, [x28]
0066C55F8  ldrb     w8, [x1, #0x53]
0066C55FC  tbnz     w8, #5, #0x66c5608
0066C5600  ldr      x27, [x20, #0x38]
0066C5604  b        #0x66c5618 ; 
0066C5608  ldr      x8, [x1, #0x60]
0066C560C  mov      x0, x20
0066C5610  blr      x8
0066C5614  mov      x27, x0
0066C5618  cbz      x27, #0x66c5690
0066C561C  adrp     x8, #0x959a000
0066C5620  ldrb     w8, [x8, #0x285]
0066C5624  cbnz     w8, #0x66c563c
0066C5628  adrp     x0, #0x8f0f000
0066C562C  ldr      x0, [x0, #0x870]
0066C5630  bl       #0x382bd14 ; 
0066C5634  adrp     x8, #0x959a000
0066C5638  strb     w24, [x8, #0x285]
0066C563C  adrp     x8, #0x8f0f000
0066C5640  ldr      x8, [x8, #0x870]
0066C5644  ldr      x2, [x8]
0066C5648  ldrb     w8, [x2, #0x53]
0066C564C  tbnz     w8, #5, #0x66c5658
0066C5650  strb     w24, [x27, #0x98]
0066C5654  b        #0x66c5668 ; 
0066C5658  ldr      x8, [x2, #0x60]
0066C565C  mov      w1, #1
0066C5660  mov      x0, x27
0066C5664  blr      x8
0066C5668  add      w25, w25, #1
0066C566C  cmp      w25, #8
0066C5670  b.ne     #0x66c5480
0066C5674  ldp      x20, x19, [sp, #0x50]
0066C5678  ldp      x22, x21, [sp, #0x40]
0066C567C  ldp      x24, x23, [sp, #0x30]
0066C5680  ldp      x26, x25, [sp, #0x20]
0066C5684  ldp      x28, x27, [sp, #0x10]
0066C5688  ldp      x29, x30, [sp], #0x60
0066C568C  ret      
0066C5690  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$CheckHurtReduce
; RVA 0x66C5694; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5694  str      x30, [sp, #-0x40]!
0066C5698  stp      x24, x23, [sp, #0x10]
0066C569C  stp      x22, x21, [sp, #0x20]
0066C56A0  stp      x20, x19, [sp, #0x30]
0066C56A4  adrp     x23, #0x959a000
0066C56A8  adrp     x24, #0x8f11000
0066C56AC  ldrb     w8, [x23, #0x251]
0066C56B0  ldr      x24, [x24, #0xeb8]
0066C56B4  mov      x20, x3
0066C56B8  mov      x21, x2
0066C56BC  mov      x19, x1
0066C56C0  mov      x22, x0
0066C56C4  tbnz     w8, #0, #0x66c56dc
0066C56C8  adrp     x0, #0x8f11000
0066C56CC  ldr      x0, [x0, #0xeb8]
0066C56D0  bl       #0x382bd14 ; 
0066C56D4  mov      w8, #1
0066C56D8  strb     w8, [x23, #0x251]
0066C56DC  ldr      x4, [x24]
0066C56E0  ldrb     w8, [x4, #0x53]
0066C56E4  tbnz     w8, #5, #0x66c5728
0066C56E8  cbz      x21, #0x66c5750
0066C56EC  mov      x0, x21
0066C56F0  mov      x1, x20
0066C56F4  mov      x2, xzr
0066C56F8  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
0066C56FC  cmp      x0, #0x10, lsl #12
0066C5700  b.eq     #0x66c5714
0066C5704  ldr      x8, [x19]
0066C5708  mul      x8, x8, x0
0066C570C  asr      x8, x8, #0x10
0066C5710  str      x8, [x19]
0066C5714  ldp      x20, x19, [sp, #0x30]
0066C5718  ldp      x22, x21, [sp, #0x20]
0066C571C  ldp      x24, x23, [sp, #0x10]
0066C5720  ldr      x30, [sp], #0x40
0066C5724  ret      
0066C5728  ldr      x5, [x4, #0x60]
0066C572C  mov      x0, x22
0066C5730  mov      x1, x19
0066C5734  mov      x2, x21
0066C5738  mov      x3, x20
0066C573C  ldp      x20, x19, [sp, #0x30]
0066C5740  ldp      x22, x21, [sp, #0x20]
0066C5744  ldp      x24, x23, [sp, #0x10]
0066C5748  ldr      x30, [sp], #0x40
0066C574C  br       x5
0066C5750  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$PlayEntityHitSound
; RVA 0x66BE654; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BE654  stp      x30, x25, [sp, #-0x40]!
0066BE658  stp      x24, x23, [sp, #0x10]
0066BE65C  stp      x22, x21, [sp, #0x20]
0066BE660  stp      x20, x19, [sp, #0x30]
0066BE664  adrp     x20, #0x959a000
0066BE668  adrp     x21, #0x8f11000
0066BE66C  ldrb     w8, [x20, #0x252]
0066BE670  ldr      x21, [x21, #0xbb0]
0066BE674  mov      x19, x0
0066BE678  tbnz     w8, #0, #0x66be69c
0066BE67C  adrp     x0, #0x8f11000
0066BE680  ldr      x0, [x0, #0xbb0]
0066BE684  bl       #0x382bd14 ; 
0066BE688  adrp     x0, #0x8ee6000
0066BE68C  ldr      x0, [x0, #0x600]
0066BE690  bl       #0x382bd14 ; 
0066BE694  mov      w8, #1
0066BE698  strb     w8, [x20, #0x252]
0066BE69C  ldr      x1, [x21]
0066BE6A0  ldrb     w8, [x1, #0x53]
0066BE6A4  tbnz     w8, #5, #0x66be6c4
0066BE6A8  adrp     x23, #0x8ee6000
0066BE6AC  ldr      x23, [x23, #0x600]
0066BE6B0  ldr      x1, [x23]
0066BE6B4  ldrb     w8, [x1, #0x53]
0066BE6B8  tbnz     w8, #5, #0x66be6e0
0066BE6BC  ldr      x20, [x19, #0x38]
0066BE6C0  b        #0x66be6f0 ; 
0066BE6C4  ldr      x2, [x1, #0x60]
0066BE6C8  mov      x0, x19
0066BE6CC  ldp      x20, x19, [sp, #0x30]
0066BE6D0  ldp      x22, x21, [sp, #0x20]
0066BE6D4  ldp      x24, x23, [sp, #0x10]
0066BE6D8  ldp      x30, x25, [sp], #0x40
0066BE6DC  br       x2
0066BE6E0  ldr      x8, [x1, #0x60]
0066BE6E4  mov      x0, x19
0066BE6E8  blr      x8
0066BE6EC  mov      x20, x0
0066BE6F0  cbz      x20, #0x66be8c0
0066BE6F4  adrp     x21, #0x9591000
0066BE6F8  ldrb     w8, [x21, #0xa74]
0066BE6FC  cbnz     w8, #0x66be714
0066BE700  adrp     x0, #0x8ee6000
0066BE704  ldr      x0, [x0, #0x288]
0066BE708  bl       #0x382bd14 ; 
0066BE70C  mov      w8, #1
0066BE710  strb     w8, [x21, #0xa74]
0066BE714  adrp     x24, #0x8ee6000
0066BE718  ldr      x24, [x24, #0x288]
0066BE71C  ldr      x1, [x24]
0066BE720  ldrb     w8, [x1, #0x53]
0066BE724  tbnz     w8, #5, #0x66be730
0066BE728  ldr      x20, [x20, #0x170]
0066BE72C  b        #0x66be740 ; 
0066BE730  ldr      x8, [x1, #0x60]
0066BE734  mov      x0, x20
0066BE738  blr      x8
0066BE73C  mov      x20, x0
0066BE740  cbz      x20, #0x66be8c0
0066BE744  adrp     x22, #0x959a000
0066BE748  ldrb     w8, [x22, #0x286]
0066BE74C  cbnz     w8, #0x66be764
0066BE750  adrp     x0, #0x8f11000
0066BE754  ldr      x0, [x0, #0xbb8]
0066BE758  bl       #0x382bd14 ; 
0066BE75C  mov      w8, #1
0066BE760  strb     w8, [x22, #0x286]
0066BE764  adrp     x25, #0x8f11000
0066BE768  ldr      x25, [x25, #0xbb8]
0066BE76C  ldr      x1, [x25]
0066BE770  ldrb     w8, [x1, #0x53]
0066BE774  tbnz     w8, #5, #0x66be780
0066BE778  ldr      w0, [x20, #0x1e8]
0066BE77C  b        #0x66be78c ; 
0066BE780  ldr      x8, [x1, #0x60]
0066BE784  mov      x0, x20
0066BE788  blr      x8
0066BE78C  cmp      w0, #1
0066BE790  b.lt     #0x66be7d0
0066BE794  adrp     x20, #0x9591000
0066BE798  ldrb     w8, [x20, #0xa4b]
0066BE79C  cbnz     w8, #0x66be7b4
0066BE7A0  adrp     x0, #0x8ee5000
0066BE7A4  ldr      x0, [x0, #0xb28]
0066BE7A8  bl       #0x382bd14 ; 
0066BE7AC  mov      w8, #1
0066BE7B0  strb     w8, [x20, #0xa4b]
0066BE7B4  adrp     x8, #0x8ee5000
0066BE7B8  ldr      x8, [x8, #0xb28]
0066BE7BC  ldr      x1, [x8]
0066BE7C0  ldrb     w8, [x1, #0x53]
0066BE7C4  tbnz     w8, #5, #0x66be7e4
0066BE7C8  ldr      x20, [x19, #0x20]
0066BE7CC  b        #0x66be7f4 ; 
0066BE7D0  ldp      x20, x19, [sp, #0x30]
0066BE7D4  ldp      x22, x21, [sp, #0x20]
0066BE7D8  ldp      x24, x23, [sp, #0x10]
0066BE7DC  ldp      x30, x25, [sp], #0x40
0066BE7E0  ret      
0066BE7E4  ldr      x8, [x1, #0x60]
0066BE7E8  mov      x0, x19
0066BE7EC  blr      x8
0066BE7F0  mov      x20, x0
0066BE7F4  ldr      x1, [x23]
0066BE7F8  ldrb     w8, [x1, #0x53]
0066BE7FC  tbnz     w8, #5, #0x66be808
0066BE800  ldr      x19, [x19, #0x38]
0066BE804  b        #0x66be818 ; 
0066BE808  ldr      x8, [x1, #0x60]
0066BE80C  mov      x0, x19
0066BE810  blr      x8
0066BE814  mov      x19, x0
0066BE818  cbz      x19, #0x66be8c0
0066BE81C  ldrb     w8, [x21, #0xa74]
0066BE820  cbnz     w8, #0x66be838
0066BE824  adrp     x0, #0x8ee6000
0066BE828  ldr      x0, [x0, #0x288]
0066BE82C  bl       #0x382bd14 ; 
0066BE830  mov      w8, #1
0066BE834  strb     w8, [x21, #0xa74]
0066BE838  ldr      x1, [x24]
0066BE83C  ldrb     w8, [x1, #0x53]
0066BE840  tbnz     w8, #5, #0x66be84c
0066BE844  ldr      x19, [x19, #0x170]
0066BE848  b        #0x66be85c ; 
0066BE84C  ldr      x8, [x1, #0x60]
0066BE850  mov      x0, x19
0066BE854  blr      x8
0066BE858  mov      x19, x0
0066BE85C  cbz      x19, #0x66be8c0
0066BE860  ldrb     w8, [x22, #0x286]
0066BE864  cbnz     w8, #0x66be87c
0066BE868  adrp     x0, #0x8f11000
0066BE86C  ldr      x0, [x0, #0xbb8]
0066BE870  bl       #0x382bd14 ; 
0066BE874  mov      w8, #1
0066BE878  strb     w8, [x22, #0x286]
0066BE87C  ldr      x1, [x25]
0066BE880  ldrb     w8, [x1, #0x53]
0066BE884  tbnz     w8, #5, #0x66be890
0066BE888  ldr      w1, [x19, #0x1e8]
0066BE88C  b        #0x66be8a0 ; 
0066BE890  ldr      x8, [x1, #0x60]
0066BE894  mov      x0, x19
0066BE898  blr      x8
0066BE89C  mov      w1, w0
0066BE8A0  cbz      x20, #0x66be8c0
0066BE8A4  mov      x0, x20
0066BE8A8  ldp      x20, x19, [sp, #0x30]
0066BE8AC  ldp      x22, x21, [sp, #0x20]
0066BE8B0  ldp      x24, x23, [sp, #0x10]
0066BE8B4  mov      x2, xzr
0066BE8B8  ldp      x30, x25, [sp], #0x40
0066BE8BC  b        #0x6a074b4 ; HotFix.BattleLogic.BattleWorldContext$$PlaySound
0066BE8C0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$PlayVibartion
; RVA 0x66BE8C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BE8C4  str      x30, [sp, #-0x40]!
0066BE8C8  stp      x24, x23, [sp, #0x10]
0066BE8CC  stp      x22, x21, [sp, #0x20]
0066BE8D0  stp      x20, x19, [sp, #0x30]
0066BE8D4  adrp     x20, #0x959a000
0066BE8D8  adrp     x21, #0x8f11000
0066BE8DC  ldrb     w8, [x20, #0x253]
0066BE8E0  ldr      x21, [x21, #0xbc0]
0066BE8E4  mov      x19, x0
0066BE8E8  tbnz     w8, #0, #0x66be93c
0066BE8EC  adrp     x0, #0x8f11000
0066BE8F0  ldr      x0, [x0, #0xbc8]
0066BE8F4  bl       #0x382bd14 ; 
0066BE8F8  adrp     x0, #0x8f11000
0066BE8FC  ldr      x0, [x0, #0xbc0]
0066BE900  bl       #0x382bd14 ; 
0066BE904  adrp     x0, #0x8ee6000
0066BE908  ldr      x0, [x0, #0x600]
0066BE90C  bl       #0x382bd14 ; 
0066BE910  adrp     x0, #0x8ee6000
0066BE914  ldr      x0, [x0, #0x608]
0066BE918  bl       #0x382bd14 ; 
0066BE91C  adrp     x0, #0x8ee6000
0066BE920  ldr      x0, [x0, #0x610]
0066BE924  bl       #0x382bd14 ; 
0066BE928  adrp     x0, #0x8f11000
0066BE92C  ldr      x0, [x0, #0xbd0]
0066BE930  bl       #0x382bd14 ; 
0066BE934  mov      w8, #1
0066BE938  strb     w8, [x20, #0x253]
0066BE93C  ldr      x1, [x21]
0066BE940  ldrb     w8, [x1, #0x53]
0066BE944  tbnz     w8, #5, #0x66be964
0066BE948  adrp     x8, #0x8ee6000
0066BE94C  ldr      x8, [x8, #0x600]
0066BE950  ldr      x1, [x8]
0066BE954  ldrb     w8, [x1, #0x53]
0066BE958  tbnz     w8, #5, #0x66be980
0066BE95C  ldr      x0, [x19, #0x38]
0066BE960  b        #0x66be98c ; 
0066BE964  ldr      x2, [x1, #0x60]
0066BE968  mov      x0, x19
0066BE96C  ldp      x20, x19, [sp, #0x30]
0066BE970  ldp      x22, x21, [sp, #0x20]
0066BE974  ldp      x24, x23, [sp, #0x10]
0066BE978  ldr      x30, [sp], #0x40
0066BE97C  br       x2
0066BE980  ldr      x8, [x1, #0x60]
0066BE984  mov      x0, x19
0066BE988  blr      x8
0066BE98C  cbz      x0, #0x66bec30
0066BE990  mov      x1, xzr
0066BE994  bl       #0x45616a8 ; 
0066BE998  tbz      w0, #0, #0x66bea04
0066BE99C  adrp     x8, #0x8ee6000
0066BE9A0  ldr      x8, [x8, #0x608]
0066BE9A4  ldr      x1, [x8]
0066BE9A8  ldrb     w8, [x1, #0x53]
0066BE9AC  tbnz     w8, #5, #0x66be9bc
0066BE9B0  ldr      x0, [x19, #0x30]
0066BE9B4  cbnz     x0, #0x66be9cc
0066BE9B8  b        #0x66bea04 ; 
0066BE9BC  ldr      x8, [x1, #0x60]
0066BE9C0  mov      x0, x19
0066BE9C4  blr      x8
0066BE9C8  cbz      x0, #0x66bea04
0066BE9CC  adrp     x8, #0x8ee6000
0066BE9D0  ldr      x8, [x8, #0x610]
0066BE9D4  ldr      x9, [x0]
0066BE9D8  ldr      x8, [x8]
0066BE9DC  ldrb     w11, [x9, #0x130]
0066BE9E0  ldrb     w10, [x8, #0x130]
0066BE9E4  cmp      w11, w10
0066BE9E8  b.lo     #0x66bea04
0066BE9EC  ldr      x9, [x9, #0xc8]
0066BE9F0  add      x9, x9, x10, lsl #3
0066BE9F4  ldur     x9, [x9, #-8]
0066BE9F8  cmp      x9, x8
0066BE9FC  csel     x0, x0, xzr, eq
0066BEA00  b.eq     #0x66bea18
0066BEA04  ldp      x20, x19, [sp, #0x30]
0066BEA08  ldp      x22, x21, [sp, #0x20]
0066BEA0C  ldp      x24, x23, [sp, #0x10]
0066BEA10  ldr      x30, [sp], #0x40
0066BEA14  ret      
0066BEA18  cbz      x0, #0x66bec30
0066BEA1C  mov      x1, xzr
0066BEA20  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
0066BEA24  adrp     x22, #0x9591000
0066BEA28  ldrb     w8, [x22, #0xa4b]
0066BEA2C  mov      w20, w0
0066BEA30  cbnz     w8, #0x66bea48
0066BEA34  adrp     x0, #0x8ee5000
0066BEA38  ldr      x0, [x0, #0xb28]
0066BEA3C  bl       #0x382bd14 ; 
0066BEA40  mov      w8, #1
0066BEA44  strb     w8, [x22, #0xa4b]
0066BEA48  adrp     x23, #0x8ee5000
0066BEA4C  ldr      x23, [x23, #0xb28]
0066BEA50  ldr      x1, [x23]
0066BEA54  ldrb     w8, [x1, #0x53]
0066BEA58  tbnz     w8, #5, #0x66bea64
0066BEA5C  ldr      x0, [x19, #0x20]
0066BEA60  b        #0x66bea70 ; 
0066BEA64  ldr      x8, [x1, #0x60]
0066BEA68  mov      x0, x19
0066BEA6C  blr      x8
0066BEA70  cbz      x0, #0x66bec30
0066BEA74  mov      w1, wzr
0066BEA78  mov      w2, w20
0066BEA7C  mov      x3, xzr
0066BEA80  bl       #0x6a0d600 ; HotFix.BattleLogic.BattleWorldContext$$Vibration
0066BEA84  ldrb     w8, [x22, #0xa4b]
0066BEA88  cbnz     w8, #0x66beaa0
0066BEA8C  adrp     x0, #0x8ee5000
0066BEA90  ldr      x0, [x0, #0xb28]
0066BEA94  bl       #0x382bd14 ; 
0066BEA98  mov      w8, #1
0066BEA9C  strb     w8, [x22, #0xa4b]
0066BEAA0  ldr      x1, [x23]
0066BEAA4  ldrb     w8, [x1, #0x53]
0066BEAA8  tbnz     w8, #5, #0x66beab4
0066BEAAC  ldr      x21, [x19, #0x20]
0066BEAB0  b        #0x66beac4 ; 
0066BEAB4  ldr      x8, [x1, #0x60]
0066BEAB8  mov      x0, x19
0066BEABC  blr      x8
0066BEAC0  mov      x21, x0
0066BEAC4  cbz      x21, #0x66bec30
0066BEAC8  adrp     x8, #0x8f11000
0066BEACC  ldr      x8, [x8, #0xbc8]
0066BEAD0  ldr      x20, [x8]
0066BEAD4  ldr      x8, [x20, #0x38]
0066BEAD8  cbnz     x8, #0x66beae4
0066BEADC  mov      x0, x20
0066BEAE0  bl       #0x3a7e668 ; 
0066BEAE4  ldrb     w8, [x20, #0x53]
0066BEAE8  tbnz     w8, #5, #0x66beb28
0066BEAEC  adrp     x24, #0x9591000
0066BEAF0  ldrb     w8, [x24, #0xa61]
0066BEAF4  cbnz     w8, #0x66beb0c
0066BEAF8  adrp     x0, #0x8ee6000
0066BEAFC  ldr      x0, [x0, #0x308]
0066BEB00  bl       #0x382bd14 ; 
0066BEB04  mov      w8, #1
0066BEB08  strb     w8, [x24, #0xa61]
0066BEB0C  adrp     x8, #0x8ee6000
0066BEB10  ldr      x8, [x8, #0x308]
0066BEB14  ldr      x1, [x8]
0066BEB18  ldrb     w8, [x1, #0x53]
0066BEB1C  tbnz     w8, #5, #0x66beb3c
0066BEB20  ldr      x0, [x21, #0x1e8]
0066BEB24  b        #0x66beb48 ; 
0066BEB28  ldr      x8, [x20, #0x60]
0066BEB2C  mov      x0, x21
0066BEB30  mov      x1, x20
0066BEB34  blr      x8
0066BEB38  b        #0x66beb58 ; 
0066BEB3C  ldr      x8, [x1, #0x60]
0066BEB40  mov      x0, x21
0066BEB44  blr      x8
0066BEB48  cbz      x0, #0x66bec30
0066BEB4C  ldr      x8, [x20, #0x38]
0066BEB50  ldr      x1, [x8]
0066BEB54  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0066BEB58  ldrb     w8, [x22, #0xa4b]
0066BEB5C  mov      x20, x0
0066BEB60  cbnz     w8, #0x66beb78
0066BEB64  adrp     x0, #0x8ee5000
0066BEB68  ldr      x0, [x0, #0xb28]
0066BEB6C  bl       #0x382bd14 ; 
0066BEB70  mov      w8, #1
0066BEB74  strb     w8, [x22, #0xa4b]
0066BEB78  ldr      x1, [x23]
0066BEB7C  ldrb     w8, [x1, #0x53]
0066BEB80  tbnz     w8, #5, #0x66beb8c
0066BEB84  ldr      x0, [x19, #0x20]
0066BEB88  b        #0x66beb98 ; 
0066BEB8C  ldr      x8, [x1, #0x60]
0066BEB90  mov      x0, x19
0066BEB94  blr      x8
0066BEB98  cbz      x0, #0x66bec30
0066BEB9C  ldr      x19, [x0, #0x1e0]
0066BEBA0  cbz      x19, #0x66bec30
0066BEBA4  adrp     x9, #0x8f11000
0066BEBA8  ldr      x9, [x9, #0xbd0]
0066BEBAC  ldr      x8, [x19]
0066BEBB0  ldr      x21, [x9]
0066BEBB4  ldrh     w9, [x8, #0x12e]
0066BEBB8  ldr      x1, [x21, #0x20]
0066BEBBC  ldrh     w2, [x21, #0x50]
0066BEBC0  cbz      x9, #0x66bebe4
0066BEBC4  ldr      x10, [x8, #0xb0]
0066BEBC8  add      x10, x10, #8
0066BEBCC  ldur     x11, [x10, #-8]
0066BEBD0  cmp      x11, x1
0066BEBD4  b.eq     #0x66bebf0
0066BEBD8  subs     x9, x9, #1
0066BEBDC  add      x10, x10, #0x10
0066BEBE0  b.ne     #0x66bebcc
0066BEBE4  mov      x0, x19
0066BEBE8  bl       #0x3a7e710 ; 
0066BEBEC  b        #0x66bec00 ; 
0066BEBF0  ldr      w9, [x10]
0066BEBF4  add      w9, w9, w2
0066BEBF8  add      x8, x8, w9, sxtw #4
0066BEBFC  add      x0, x8, #0x138
0066BEC00  ldr      x0, [x0, #8]
0066BEC04  mov      x1, x21
0066BEC08  bl       #0x382be88 ; 
0066BEC0C  mov      x2, x0
0066BEC10  ldr      x3, [x0, #8]
0066BEC14  mov      x0, x19
0066BEC18  mov      x1, x20
0066BEC1C  ldp      x20, x19, [sp, #0x30]
0066BEC20  ldp      x22, x21, [sp, #0x20]
0066BEC24  ldp      x24, x23, [sp, #0x10]
0066BEC28  ldr      x30, [sp], #0x40
0066BEC2C  br       x3
0066BEC30  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
; RVA 0x454D854; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00454D854  sub      sp, sp, #0xb0
00454D858  stp      x30, x25, [sp, #0x70]
00454D85C  stp      x24, x23, [sp, #0x80]
00454D860  stp      x22, x21, [sp, #0x90]
00454D864  stp      x20, x19, [sp, #0xa0]
00454D868  ldr      x8, [x4, #0x38]
00454D86C  mov      x23, x4
00454D870  mov      x20, x3
00454D874  mov      x21, x2
00454D878  mov      x19, x1
00454D87C  mov      x22, x0
00454D880  cbnz     x8, #0x454d96c
00454D884  adrp     x0, #0x8ee6000
00454D888  ldr      x0, [x0, #0x5e8]
00454D88C  bl       #0x382bd14 ; 
00454D890  adrp     x0, #0x8ee6000
00454D894  ldr      x0, [x0, #0x5f0]
00454D898  bl       #0x382bd14 ; 
00454D89C  adrp     x0, #0x8ee6000
00454D8A0  ldr      x0, [x0, #0x5f8]
00454D8A4  bl       #0x382bd14 ; 
00454D8A8  adrp     x0, #0x8ee6000
00454D8AC  ldr      x0, [x0, #0x600]
00454D8B0  bl       #0x382bd14 ; 
00454D8B4  adrp     x0, #0x8ee6000
00454D8B8  ldr      x0, [x0, #0x608]
00454D8BC  bl       #0x382bd14 ; 
00454D8C0  adrp     x0, #0x8ee6000
00454D8C4  ldr      x0, [x0, #0x610]
00454D8C8  bl       #0x382bd14 ; 
00454D8CC  adrp     x0, #0x8ee6000
00454D8D0  ldr      x0, [x0, #0x618]
00454D8D4  bl       #0x382bd14 ; 
00454D8D8  adrp     x0, #0x8ee6000
00454D8DC  ldr      x0, [x0, #0x620]
00454D8E0  bl       #0x382bd14 ; 
00454D8E4  adrp     x0, #0x8ee6000
00454D8E8  ldr      x0, [x0, #0x628]
00454D8EC  bl       #0x382bd14 ; 
00454D8F0  adrp     x0, #0x8ee6000
00454D8F4  ldr      x0, [x0, #0x630]
00454D8F8  bl       #0x382bd14 ; 
00454D8FC  adrp     x0, #0x8ee6000
00454D900  ldr      x0, [x0, #0x638]
00454D904  bl       #0x382bd14 ; 
00454D908  adrp     x0, #0x8ee6000
00454D90C  ldr      x0, [x0, #0x640]
00454D910  bl       #0x382bd14 ; 
00454D914  adrp     x0, #0x8ee6000
00454D918  ldr      x0, [x0, #0x648]
00454D91C  bl       #0x382bd14 ; 
00454D920  adrp     x0, #0x8ee6000
00454D924  ldr      x0, [x0, #0x650]
00454D928  bl       #0x382bd14 ; 
00454D92C  adrp     x0, #0x8ee6000
00454D930  ldr      x0, [x0, #0x658]
00454D934  bl       #0x382bd14 ; 
00454D938  adrp     x0, #0x8ee6000
00454D93C  ldr      x0, [x0, #0x660]
00454D940  bl       #0x382bd14 ; 
00454D944  adrp     x0, #0x8ee6000
00454D948  ldr      x0, [x0, #0x668]
00454D94C  bl       #0x382bd14 ; 
00454D950  adrp     x0, #0x8ee6000
00454D954  ldr      x0, [x0, #0x670]
00454D958  bl       #0x382bd14 ; 
00454D95C  ldr      x8, [x23, #0x38]
00454D960  cbnz     x8, #0x454d96c
00454D964  mov      x0, x23
00454D968  bl       #0x3a7e668 ; 
00454D96C  ldrb     w8, [x23, #0x53]
00454D970  tbnz     w8, #5, #0x454d9ac
00454D974  stp      xzr, xzr, [sp, #0x50]
00454D978  str      xzr, [sp, #0x60]
00454D97C  stp      xzr, xzr, [sp, #0x30]
00454D980  str      xzr, [sp, #0x40]
00454D984  stp      xzr, xzr, [sp, #0x18]
00454D988  str      xzr, [sp, #0x28]
00454D98C  cbz      x22, #0x454dc44
00454D990  adrp     x8, #0x8ee6000
00454D994  ldr      x8, [x8, #0x600]
00454D998  ldr      x1, [x8]
00454D99C  ldrb     w8, [x1, #0x53]
00454D9A0  tbnz     w8, #5, #0x454d9dc
00454D9A4  ldr      x0, [x22, #0x38]
00454D9A8  b        #0x454d9e8 ; 
00454D9AC  ldr      x5, [x23, #0x60]
00454D9B0  mov      x0, x22
00454D9B4  mov      x1, x19
00454D9B8  mov      x2, x21
00454D9BC  mov      x3, x20
00454D9C0  mov      x4, x23
00454D9C4  ldp      x20, x19, [sp, #0xa0]
00454D9C8  ldp      x22, x21, [sp, #0x90]
00454D9CC  ldp      x24, x23, [sp, #0x80]
00454D9D0  ldp      x30, x25, [sp, #0x70]
00454D9D4  add      sp, sp, #0xb0
00454D9D8  br       x5
00454D9DC  ldr      x8, [x1, #0x60]
00454D9E0  mov      x0, x22
00454D9E4  blr      x8
00454D9E8  cbz      x0, #0x454dc44
00454D9EC  mov      x1, xzr
00454D9F0  bl       #0x45616a8 ; 
00454D9F4  tbz      w0, #0, #0x454dc2c
00454D9F8  adrp     x8, #0x8ee6000
00454D9FC  ldr      x8, [x8, #0x608]
00454DA00  ldr      x1, [x8]
00454DA04  ldrb     w8, [x1, #0x53]
00454DA08  tbnz     w8, #5, #0x454da18
00454DA0C  ldr      x0, [x22, #0x30]
00454DA10  cbnz     x0, #0x454da28
00454DA14  b        #0x454dc2c ; 
00454DA18  ldr      x8, [x1, #0x60]
00454DA1C  mov      x0, x22
00454DA20  blr      x8
00454DA24  cbz      x0, #0x454dc2c
00454DA28  adrp     x8, #0x8ee6000
00454DA2C  ldr      x8, [x8, #0x610]
00454DA30  ldr      x9, [x0]
00454DA34  ldr      x8, [x8]
00454DA38  ldrb     w11, [x9, #0x130]
00454DA3C  ldrb     w10, [x8, #0x130]
00454DA40  cmp      w11, w10
00454DA44  b.lo     #0x454dc2c
00454DA48  ldr      x9, [x9, #0xc8]
00454DA4C  add      x9, x9, x10, lsl #3
00454DA50  ldur     x9, [x9, #-8]
00454DA54  cmp      x9, x8
00454DA58  csel     x22, x0, xzr, eq
00454DA5C  b.ne     #0x454dc2c
00454DA60  cbz      x22, #0x454dc44
00454DA64  adrp     x8, #0x8ee6000
00454DA68  ldr      x8, [x8, #0x5e8]
00454DA6C  mov      x0, x22
00454DA70  ldr      x1, [x8]
00454DA74  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00454DA78  cbz      x0, #0x454daf8
00454DA7C  mov      x1, xzr
00454DA80  bl       #0x684d120 ; HotFix.BattleLogic.CharacterComponentSecondWeapons$$GetAllSecondWeaponEntities
00454DA84  cbz      x0, #0x454dc44
00454DA88  adrp     x8, #0x8ee6000
00454DA8C  ldr      x8, [x8, #0x670]
00454DA90  ldr      x1, [x8]
00454DA94  mov      x8, sp
00454DA98  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
00454DA9C  ldr      q0, [sp]
00454DAA0  ldr      x8, [sp, #0x10]
00454DAA4  adrp     x23, #0x8ee6000
00454DAA8  str      q0, [sp, #0x50]
00454DAAC  str      x8, [sp, #0x60]
00454DAB0  ldr      x23, [x23, #0x638]
00454DAB4  ldr      x1, [x23]
00454DAB8  add      x0, sp, #0x50
00454DABC  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
00454DAC0  tbz      w0, #0, #0x454dae4
00454DAC4  cbz      x21, #0x454dab4
00454DAC8  ldr      x1, [sp, #0x60]
00454DACC  ldr      x0, [x21, #0x40]
00454DAD0  ldr      x8, [x21, #0x18]
00454DAD4  ldr      x3, [x21, #0x28]
00454DAD8  mov      x2, x19
00454DADC  blr      x8
00454DAE0  b        #0x454dab4 ; 
00454DAE4  adrp     x8, #0x8ee6000
00454DAE8  ldr      x8, [x8, #0x628]
00454DAEC  add      x0, sp, #0x50
00454DAF0  ldr      x1, [x8]
00454DAF4  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DAF8  adrp     x8, #0x8ee6000
00454DAFC  ldr      x8, [x8, #0x5f0]
00454DB00  mov      x0, x22
00454DB04  ldr      x1, [x8]
00454DB08  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00454DB0C  cbz      x0, #0x454db8c
00454DB10  mov      x1, xzr
00454DB14  bl       #0x672558c ; HotFix.BattleLogic.CharacterComponentSprite$$GetAllSprites
00454DB18  cbz      x0, #0x454dc44
00454DB1C  adrp     x8, #0x8ee6000
00454DB20  ldr      x8, [x8, #0x660]
00454DB24  ldr      x1, [x8]
00454DB28  mov      x8, sp
00454DB2C  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
00454DB30  ldr      q0, [sp]
00454DB34  ldr      x8, [sp, #0x10]
00454DB38  adrp     x23, #0x8ee6000
00454DB3C  str      q0, [sp, #0x30]
00454DB40  str      x8, [sp, #0x40]
00454DB44  ldr      x23, [x23, #0x640]
00454DB48  ldr      x1, [x23]
00454DB4C  add      x0, sp, #0x30
00454DB50  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
00454DB54  tbz      w0, #0, #0x454db78
00454DB58  cbz      x21, #0x454db48
00454DB5C  ldr      x1, [sp, #0x40]
00454DB60  ldr      x0, [x21, #0x40]
00454DB64  ldr      x8, [x21, #0x18]
00454DB68  ldr      x3, [x21, #0x28]
00454DB6C  mov      x2, x19
00454DB70  blr      x8
00454DB74  b        #0x454db48 ; 
00454DB78  adrp     x8, #0x8ee6000
00454DB7C  ldr      x8, [x8, #0x618]
00454DB80  add      x0, sp, #0x30
00454DB84  ldr      x1, [x8]
00454DB88  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DB8C  adrp     x8, #0x8ee6000
00454DB90  ldr      x8, [x8, #0x5f8]
00454DB94  mov      x0, x22
00454DB98  ldr      x1, [x8]
00454DB9C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00454DBA0  cbz      x0, #0x454dc10
00454DBA4  mov      x1, xzr
00454DBA8  bl       #0x67302b8 ; HotFix.BattleLogic.CharacterComponentWingPlane$$GetAllWingPlanes
00454DBAC  cbz      x0, #0x454dc44
00454DBB0  adrp     x8, #0x8ee6000
00454DBB4  ldr      x8, [x8, #0x668]
00454DBB8  ldr      x1, [x8]
00454DBBC  add      x8, sp, #0x18
00454DBC0  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
00454DBC4  adrp     x23, #0x8ee6000
00454DBC8  ldr      x23, [x23, #0x630]
00454DBCC  ldr      x1, [x23]
00454DBD0  add      x0, sp, #0x18
00454DBD4  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
00454DBD8  tbz      w0, #0, #0x454dbfc
00454DBDC  cbz      x21, #0x454dbcc
00454DBE0  ldr      x1, [sp, #0x28]
00454DBE4  ldr      x0, [x21, #0x40]
00454DBE8  ldr      x8, [x21, #0x18]
00454DBEC  ldr      x3, [x21, #0x28]
00454DBF0  mov      x2, x19
00454DBF4  blr      x8
00454DBF8  b        #0x454dbcc ; 
00454DBFC  adrp     x8, #0x8ee6000
00454DC00  ldr      x8, [x8, #0x620]
00454DC04  add      x0, sp, #0x18
00454DC08  ldr      x1, [x8]
00454DC0C  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DC10  cbz      x20, #0x454dc2c
00454DC14  ldr      x8, [x20, #0x18]
00454DC18  ldr      x0, [x20, #0x40]
00454DC1C  ldr      x3, [x20, #0x28]
00454DC20  mov      x1, x22
00454DC24  mov      x2, x19
00454DC28  blr      x8
00454DC2C  ldp      x20, x19, [sp, #0xa0]
00454DC30  ldp      x22, x21, [sp, #0x90]
00454DC34  ldp      x24, x23, [sp, #0x80]
00454DC38  ldp      x30, x25, [sp, #0x70]
00454DC3C  add      sp, sp, #0xb0
00454DC40  ret      
00454DC44  bl       #0x382bfb8 ; 
00454DC48  b        #0x454dc54 ; 
00454DC4C  b        #0x454dcbc ; 
00454DC50  b        #0x454dd20 ; 
00454DC54  mov      x23, x0
00454DC58  cmp      w1, #1
00454DC5C  b.ne     #0x454dc90
00454DC60  mov      x0, x23
00454DC64  bl       #0x89eda50 ; 
00454DC68  ldr      x21, [x0]
00454DC6C  bl       #0x89eda60 ; 
00454DC70  adrp     x8, #0x8ee6000
00454DC74  ldr      x8, [x8, #0x620]
00454DC78  add      x0, sp, #0x18
00454DC7C  ldr      x1, [x8]
00454DC80  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DC84  cbz      x21, #0x454dc10
00454DC88  mov      x0, x21
00454DC8C  bl       #0x382bfb0 ; 
00454DC90  mov      x21, xzr
00454DC94  b        #0x454dc9c ; 
00454DC98  mov      x23, x0
00454DC9C  adrp     x8, #0x8ee6000
00454DCA0  ldr      x8, [x8, #0x620]
00454DCA4  ldr      x1, [x8]
00454DCA8  add      x0, sp, #0x18
00454DCAC  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DCB0  cbz      x21, #0x454dd78
00454DCB4  mov      x0, x21
00454DCB8  bl       #0x382bfb0 ; 
00454DCBC  mov      x23, x0
00454DCC0  cmp      w1, #1
00454DCC4  b.ne     #0x454dcf4
00454DCC8  mov      x0, x23
00454DCCC  bl       #0x89eda50 ; 
00454DCD0  ldr      x24, [x0]
00454DCD4  bl       #0x89eda60 ; 
00454DCD8  adrp     x8, #0x8ee6000
00454DCDC  ldr      x8, [x8, #0x618]
00454DCE0  add      x0, sp, #0x30
00454DCE4  ldr      x1, [x8]
00454DCE8  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DCEC  cbz      x24, #0x454db8c
00454DCF0  b        #0x454dd54 ; 
00454DCF4  mov      x24, xzr
00454DCF8  b        #0x454dd00 ; 
00454DCFC  mov      x23, x0
00454DD00  adrp     x8, #0x8ee6000
00454DD04  ldr      x8, [x8, #0x618]
00454DD08  ldr      x1, [x8]
00454DD0C  add      x0, sp, #0x30
00454DD10  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DD14  cbz      x24, #0x454dd78
00454DD18  mov      x0, x24
00454DD1C  bl       #0x382bfb0 ; 
00454DD20  adrp     x25, #0x8ee6000
00454DD24  ldr      x25, [x25, #0x628]
00454DD28  mov      x23, x0
00454DD2C  cmp      w1, #1
00454DD30  b.ne     #0x454dd5c
00454DD34  mov      x0, x23
00454DD38  bl       #0x89eda50 ; 
00454DD3C  ldr      x24, [x0]
00454DD40  bl       #0x89eda60 ; 
00454DD44  ldr      x1, [x25]
00454DD48  add      x0, sp, #0x50
00454DD4C  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DD50  cbz      x24, #0x454daf8
00454DD54  mov      x0, x24
00454DD58  bl       #0x382bfb0 ; 
00454DD5C  mov      x24, xzr
00454DD60  b        #0x454dd68 ; 
00454DD64  mov      x23, x0
00454DD68  ldr      x1, [x25]
00454DD6C  add      x0, sp, #0x50
00454DD70  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
00454DD74  cbnz     x24, #0x454dd80
00454DD78  mov      x0, x23
00454DD7C  bl       #0x3b56bfc ; 
00454DD80  mov      x0, x24
00454DD84  bl       #0x382bfb0 ; 
00454DD88  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroHurt
; RVA 0x66C4D6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C4D6C  stp      x30, x23, [sp, #-0x30]!
0066C4D70  stp      x22, x21, [sp, #0x10]
0066C4D74  stp      x20, x19, [sp, #0x20]
0066C4D78  adrp     x21, #0x959a000
0066C4D7C  adrp     x22, #0x8f11000
0066C4D80  ldrb     w8, [x21, #0x254]
0066C4D84  ldr      x22, [x22, #0xe48]
0066C4D88  mov      x19, x1
0066C4D8C  mov      x20, x0
0066C4D90  tbnz     w8, #0, #0x66c4dd8
0066C4D94  adrp     x0, #0x8f11000
0066C4D98  ldr      x0, [x0, #0xe50]
0066C4D9C  bl       #0x382bd14 ; 
0066C4DA0  adrp     x0, #0x8f11000
0066C4DA4  ldr      x0, [x0, #0xe48]
0066C4DA8  bl       #0x382bd14 ; 
0066C4DAC  adrp     x0, #0x8f11000
0066C4DB0  ldr      x0, [x0, #0xe58]
0066C4DB4  bl       #0x382bd14 ; 
0066C4DB8  adrp     x0, #0x8f11000
0066C4DBC  ldr      x0, [x0, #0xe60]
0066C4DC0  bl       #0x382bd14 ; 
0066C4DC4  adrp     x0, #0x8f11000
0066C4DC8  ldr      x0, [x0, #0xba8]
0066C4DCC  bl       #0x382bd14 ; 
0066C4DD0  mov      w8, #1
0066C4DD4  strb     w8, [x21, #0x254]
0066C4DD8  ldr      x2, [x22]
0066C4DDC  ldrb     w8, [x2, #0x53]
0066C4DE0  tbnz     w8, #5, #0x66c4e94
0066C4DE4  adrp     x23, #0x8f11000
0066C4DE8  ldr      x23, [x23, #0xba8]
0066C4DEC  ldr      x0, [x23]
0066C4DF0  ldr      w8, [x0, #0xe0]
0066C4DF4  cbnz     w8, #0x66c4e00
0066C4DF8  bl       #0x382be8c ; 
0066C4DFC  ldr      x0, [x23]
0066C4E00  ldr      x8, [x0, #0xb8]
0066C4E04  ldr      x21, [x8, #8]
0066C4E08  cbnz     x21, #0x66c4e64
0066C4E0C  ldr      w8, [x0, #0xe0]
0066C4E10  cbnz     w8, #0x66c4e1c
0066C4E14  bl       #0x382be8c ; 
0066C4E18  ldr      x0, [x23]
0066C4E1C  adrp     x9, #0x8f11000
0066C4E20  ldr      x8, [x0, #0xb8]
0066C4E24  ldr      x9, [x9, #0xe50]
0066C4E28  ldr      x22, [x8]
0066C4E2C  ldr      x0, [x9]
0066C4E30  bl       #0x382bfa0 ; 
0066C4E34  adrp     x8, #0x8f11000
0066C4E38  ldr      x8, [x8, #0xe60]
0066C4E3C  mov      x1, x22
0066C4E40  mov      x3, xzr
0066C4E44  mov      x21, x0
0066C4E48  ldr      x2, [x8]
0066C4E4C  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C4E50  ldr      x8, [x23]
0066C4E54  mov      x1, x21
0066C4E58  ldr      x0, [x8, #0xb8]
0066C4E5C  str      x21, [x0, #8]!
0066C4E60  bl       #0x382bcb8 ; 
0066C4E64  cbz      x20, #0x66c4eb0
0066C4E68  adrp     x8, #0x8f11000
0066C4E6C  ldr      x8, [x8, #0xe58]
0066C4E70  mov      x0, x20
0066C4E74  mov      x1, x19
0066C4E78  mov      x2, x21
0066C4E7C  ldr      x4, [x8]
0066C4E80  ldp      x20, x19, [sp, #0x20]
0066C4E84  ldp      x22, x21, [sp, #0x10]
0066C4E88  mov      x3, xzr
0066C4E8C  ldp      x30, x23, [sp], #0x30
0066C4E90  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C4E94  ldr      x3, [x2, #0x60]
0066C4E98  mov      x0, x20
0066C4E9C  mov      x1, x19
0066C4EA0  ldp      x20, x19, [sp, #0x20]
0066C4EA4  ldp      x22, x21, [sp, #0x10]
0066C4EA8  ldp      x30, x23, [sp], #0x30
0066C4EAC  br       x3
0066C4EB0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroHurtAfterHPChange
; RVA 0x66C4FFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C4FFC  stp      x30, x23, [sp, #-0x30]!
0066C5000  stp      x22, x21, [sp, #0x10]
0066C5004  stp      x20, x19, [sp, #0x20]
0066C5008  adrp     x21, #0x959a000
0066C500C  adrp     x22, #0x8f11000
0066C5010  ldrb     w8, [x21, #0x255]
0066C5014  ldr      x22, [x22, #0xe88]
0066C5018  mov      x19, x1
0066C501C  mov      x20, x0
0066C5020  tbnz     w8, #0, #0x66c5068
0066C5024  adrp     x0, #0x8f11000
0066C5028  ldr      x0, [x0, #0xe90]
0066C502C  bl       #0x382bd14 ; 
0066C5030  adrp     x0, #0x8f11000
0066C5034  ldr      x0, [x0, #0xe88]
0066C5038  bl       #0x382bd14 ; 
0066C503C  adrp     x0, #0x8f11000
0066C5040  ldr      x0, [x0, #0xe98]
0066C5044  bl       #0x382bd14 ; 
0066C5048  adrp     x0, #0x8f11000
0066C504C  ldr      x0, [x0, #0xea0]
0066C5050  bl       #0x382bd14 ; 
0066C5054  adrp     x0, #0x8f11000
0066C5058  ldr      x0, [x0, #0xba8]
0066C505C  bl       #0x382bd14 ; 
0066C5060  mov      w8, #1
0066C5064  strb     w8, [x21, #0x255]
0066C5068  ldr      x2, [x22]
0066C506C  ldrb     w8, [x2, #0x53]
0066C5070  tbnz     w8, #5, #0x66c5124
0066C5074  adrp     x23, #0x8f11000
0066C5078  ldr      x23, [x23, #0xba8]
0066C507C  ldr      x0, [x23]
0066C5080  ldr      w8, [x0, #0xe0]
0066C5084  cbnz     w8, #0x66c5090
0066C5088  bl       #0x382be8c ; 
0066C508C  ldr      x0, [x23]
0066C5090  ldr      x8, [x0, #0xb8]
0066C5094  ldr      x21, [x8, #0x10]
0066C5098  cbnz     x21, #0x66c50f4
0066C509C  ldr      w8, [x0, #0xe0]
0066C50A0  cbnz     w8, #0x66c50ac
0066C50A4  bl       #0x382be8c ; 
0066C50A8  ldr      x0, [x23]
0066C50AC  adrp     x9, #0x8f11000
0066C50B0  ldr      x8, [x0, #0xb8]
0066C50B4  ldr      x9, [x9, #0xe90]
0066C50B8  ldr      x22, [x8]
0066C50BC  ldr      x0, [x9]
0066C50C0  bl       #0x382bfa0 ; 
0066C50C4  adrp     x8, #0x8f11000
0066C50C8  ldr      x8, [x8, #0xea0]
0066C50CC  mov      x1, x22
0066C50D0  mov      x3, xzr
0066C50D4  mov      x21, x0
0066C50D8  ldr      x2, [x8]
0066C50DC  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C50E0  ldr      x8, [x23]
0066C50E4  mov      x1, x21
0066C50E8  ldr      x0, [x8, #0xb8]
0066C50EC  str      x21, [x0, #0x10]!
0066C50F0  bl       #0x382bcb8 ; 
0066C50F4  cbz      x20, #0x66c5140
0066C50F8  adrp     x8, #0x8f11000
0066C50FC  ldr      x8, [x8, #0xe98]
0066C5100  mov      x0, x20
0066C5104  mov      x1, x19
0066C5108  mov      x2, x21
0066C510C  ldr      x4, [x8]
0066C5110  ldp      x20, x19, [sp, #0x20]
0066C5114  ldp      x22, x21, [sp, #0x10]
0066C5118  mov      x3, xzr
0066C511C  ldp      x30, x23, [sp], #0x30
0066C5120  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C5124  ldr      x3, [x2, #0x60]
0066C5128  mov      x0, x20
0066C512C  mov      x1, x19
0066C5130  ldp      x20, x19, [sp, #0x20]
0066C5134  ldp      x22, x21, [sp, #0x10]
0066C5138  ldp      x30, x23, [sp], #0x30
0066C513C  br       x3
0066C5140  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroInvHurt
; RVA 0x66C1D80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C1D80  stp      x30, x23, [sp, #-0x30]!
0066C1D84  stp      x22, x21, [sp, #0x10]
0066C1D88  stp      x20, x19, [sp, #0x20]
0066C1D8C  adrp     x21, #0x959a000
0066C1D90  adrp     x22, #0x8f11000
0066C1D94  ldrb     w8, [x21, #0x256]
0066C1D98  ldr      x22, [x22, #0xd48]
0066C1D9C  mov      x19, x1
0066C1DA0  mov      x20, x0
0066C1DA4  tbnz     w8, #0, #0x66c1dec
0066C1DA8  adrp     x0, #0x8f11000
0066C1DAC  ldr      x0, [x0, #0xd50]
0066C1DB0  bl       #0x382bd14 ; 
0066C1DB4  adrp     x0, #0x8f11000
0066C1DB8  ldr      x0, [x0, #0xd48]
0066C1DBC  bl       #0x382bd14 ; 
0066C1DC0  adrp     x0, #0x8f11000
0066C1DC4  ldr      x0, [x0, #0xd58]
0066C1DC8  bl       #0x382bd14 ; 
0066C1DCC  adrp     x0, #0x8f11000
0066C1DD0  ldr      x0, [x0, #0xd60]
0066C1DD4  bl       #0x382bd14 ; 
0066C1DD8  adrp     x0, #0x8f11000
0066C1DDC  ldr      x0, [x0, #0xba8]
0066C1DE0  bl       #0x382bd14 ; 
0066C1DE4  mov      w8, #1
0066C1DE8  strb     w8, [x21, #0x256]
0066C1DEC  ldr      x2, [x22]
0066C1DF0  ldrb     w8, [x2, #0x53]
0066C1DF4  tbnz     w8, #5, #0x66c1ea8
0066C1DF8  adrp     x23, #0x8f11000
0066C1DFC  ldr      x23, [x23, #0xba8]
0066C1E00  ldr      x0, [x23]
0066C1E04  ldr      w8, [x0, #0xe0]
0066C1E08  cbnz     w8, #0x66c1e14
0066C1E0C  bl       #0x382be8c ; 
0066C1E10  ldr      x0, [x23]
0066C1E14  ldr      x8, [x0, #0xb8]
0066C1E18  ldr      x21, [x8, #0x18]
0066C1E1C  cbnz     x21, #0x66c1e78
0066C1E20  ldr      w8, [x0, #0xe0]
0066C1E24  cbnz     w8, #0x66c1e30
0066C1E28  bl       #0x382be8c ; 
0066C1E2C  ldr      x0, [x23]
0066C1E30  adrp     x9, #0x8f11000
0066C1E34  ldr      x8, [x0, #0xb8]
0066C1E38  ldr      x9, [x9, #0xd50]
0066C1E3C  ldr      x22, [x8]
0066C1E40  ldr      x0, [x9]
0066C1E44  bl       #0x382bfa0 ; 
0066C1E48  adrp     x8, #0x8f11000
0066C1E4C  ldr      x8, [x8, #0xd60]
0066C1E50  mov      x1, x22
0066C1E54  mov      x3, xzr
0066C1E58  mov      x21, x0
0066C1E5C  ldr      x2, [x8]
0066C1E60  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C1E64  ldr      x8, [x23]
0066C1E68  mov      x1, x21
0066C1E6C  ldr      x0, [x8, #0xb8]
0066C1E70  str      x21, [x0, #0x18]!
0066C1E74  bl       #0x382bcb8 ; 
0066C1E78  cbz      x20, #0x66c1ec4
0066C1E7C  adrp     x8, #0x8f11000
0066C1E80  ldr      x8, [x8, #0xd58]
0066C1E84  mov      x0, x20
0066C1E88  mov      x1, x19
0066C1E8C  mov      x2, x21
0066C1E90  ldr      x4, [x8]
0066C1E94  ldp      x20, x19, [sp, #0x20]
0066C1E98  ldp      x22, x21, [sp, #0x10]
0066C1E9C  mov      x3, xzr
0066C1EA0  ldp      x30, x23, [sp], #0x30
0066C1EA4  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C1EA8  ldr      x3, [x2, #0x60]
0066C1EAC  mov      x0, x20
0066C1EB0  mov      x1, x19
0066C1EB4  ldp      x20, x19, [sp, #0x20]
0066C1EB8  ldp      x22, x21, [sp, #0x10]
0066C1EBC  ldp      x30, x23, [sp], #0x30
0066C1EC0  br       x3
0066C1EC4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroDying
; RVA 0x66C4EB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C4EB4  stp      x30, x23, [sp, #-0x30]!
0066C4EB8  stp      x22, x21, [sp, #0x10]
0066C4EBC  stp      x20, x19, [sp, #0x20]
0066C4EC0  adrp     x21, #0x959a000
0066C4EC4  adrp     x22, #0x8f11000
0066C4EC8  ldrb     w8, [x21, #0x257]
0066C4ECC  ldr      x22, [x22, #0xe68]
0066C4ED0  mov      x19, x1
0066C4ED4  mov      x20, x0
0066C4ED8  tbnz     w8, #0, #0x66c4f20
0066C4EDC  adrp     x0, #0x8f11000
0066C4EE0  ldr      x0, [x0, #0xe70]
0066C4EE4  bl       #0x382bd14 ; 
0066C4EE8  adrp     x0, #0x8f11000
0066C4EEC  ldr      x0, [x0, #0xe68]
0066C4EF0  bl       #0x382bd14 ; 
0066C4EF4  adrp     x0, #0x8f11000
0066C4EF8  ldr      x0, [x0, #0xe78]
0066C4EFC  bl       #0x382bd14 ; 
0066C4F00  adrp     x0, #0x8f11000
0066C4F04  ldr      x0, [x0, #0xe80]
0066C4F08  bl       #0x382bd14 ; 
0066C4F0C  adrp     x0, #0x8f11000
0066C4F10  ldr      x0, [x0, #0xba8]
0066C4F14  bl       #0x382bd14 ; 
0066C4F18  mov      w8, #1
0066C4F1C  strb     w8, [x21, #0x257]
0066C4F20  ldr      x2, [x22]
0066C4F24  ldrb     w8, [x2, #0x53]
0066C4F28  tbnz     w8, #5, #0x66c4fdc
0066C4F2C  adrp     x23, #0x8f11000
0066C4F30  ldr      x23, [x23, #0xba8]
0066C4F34  ldr      x0, [x23]
0066C4F38  ldr      w8, [x0, #0xe0]
0066C4F3C  cbnz     w8, #0x66c4f48
0066C4F40  bl       #0x382be8c ; 
0066C4F44  ldr      x0, [x23]
0066C4F48  ldr      x8, [x0, #0xb8]
0066C4F4C  ldr      x21, [x8, #0x20]
0066C4F50  cbnz     x21, #0x66c4fac
0066C4F54  ldr      w8, [x0, #0xe0]
0066C4F58  cbnz     w8, #0x66c4f64
0066C4F5C  bl       #0x382be8c ; 
0066C4F60  ldr      x0, [x23]
0066C4F64  adrp     x9, #0x8f11000
0066C4F68  ldr      x8, [x0, #0xb8]
0066C4F6C  ldr      x9, [x9, #0xe70]
0066C4F70  ldr      x22, [x8]
0066C4F74  ldr      x0, [x9]
0066C4F78  bl       #0x382bfa0 ; 
0066C4F7C  adrp     x8, #0x8f11000
0066C4F80  ldr      x8, [x8, #0xe80]
0066C4F84  mov      x1, x22
0066C4F88  mov      x3, xzr
0066C4F8C  mov      x21, x0
0066C4F90  ldr      x2, [x8]
0066C4F94  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C4F98  ldr      x8, [x23]
0066C4F9C  mov      x1, x21
0066C4FA0  ldr      x0, [x8, #0xb8]
0066C4FA4  str      x21, [x0, #0x20]!
0066C4FA8  bl       #0x382bcb8 ; 
0066C4FAC  cbz      x20, #0x66c4ff8
0066C4FB0  adrp     x8, #0x8f11000
0066C4FB4  ldr      x8, [x8, #0xe78]
0066C4FB8  mov      x0, x20
0066C4FBC  mov      x1, x19
0066C4FC0  mov      x2, x21
0066C4FC4  ldr      x4, [x8]
0066C4FC8  ldp      x20, x19, [sp, #0x20]
0066C4FCC  ldp      x22, x21, [sp, #0x10]
0066C4FD0  mov      x3, xzr
0066C4FD4  ldp      x30, x23, [sp], #0x30
0066C4FD8  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C4FDC  ldr      x3, [x2, #0x60]
0066C4FE0  mov      x0, x20
0066C4FE4  mov      x1, x19
0066C4FE8  ldp      x20, x19, [sp, #0x20]
0066C4FEC  ldp      x22, x21, [sp, #0x10]
0066C4FF0  ldp      x30, x23, [sp], #0x30
0066C4FF4  br       x3
0066C4FF8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroHpChange
; RVA 0x66C5754; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5754  stp      x30, x23, [sp, #-0x30]!
0066C5758  stp      x22, x21, [sp, #0x10]
0066C575C  stp      x20, x19, [sp, #0x20]
0066C5760  adrp     x21, #0x959a000
0066C5764  adrp     x22, #0x8f11000
0066C5768  ldrb     w8, [x21, #0x258]
0066C576C  ldr      x22, [x22, #0xec0]
0066C5770  mov      x19, x1
0066C5774  mov      x20, x0
0066C5778  tbnz     w8, #0, #0x66c57c0
0066C577C  adrp     x0, #0x8f11000
0066C5780  ldr      x0, [x0, #0xec8]
0066C5784  bl       #0x382bd14 ; 
0066C5788  adrp     x0, #0x8f11000
0066C578C  ldr      x0, [x0, #0xec0]
0066C5790  bl       #0x382bd14 ; 
0066C5794  adrp     x0, #0x8f11000
0066C5798  ldr      x0, [x0, #0xed0]
0066C579C  bl       #0x382bd14 ; 
0066C57A0  adrp     x0, #0x8f11000
0066C57A4  ldr      x0, [x0, #0xed8]
0066C57A8  bl       #0x382bd14 ; 
0066C57AC  adrp     x0, #0x8f11000
0066C57B0  ldr      x0, [x0, #0xba8]
0066C57B4  bl       #0x382bd14 ; 
0066C57B8  mov      w8, #1
0066C57BC  strb     w8, [x21, #0x258]
0066C57C0  ldr      x2, [x22]
0066C57C4  ldrb     w8, [x2, #0x53]
0066C57C8  tbnz     w8, #5, #0x66c587c
0066C57CC  adrp     x23, #0x8f11000
0066C57D0  ldr      x23, [x23, #0xba8]
0066C57D4  ldr      x0, [x23]
0066C57D8  ldr      w8, [x0, #0xe0]
0066C57DC  cbnz     w8, #0x66c57e8
0066C57E0  bl       #0x382be8c ; 
0066C57E4  ldr      x0, [x23]
0066C57E8  ldr      x8, [x0, #0xb8]
0066C57EC  ldr      x21, [x8, #0x28]
0066C57F0  cbnz     x21, #0x66c584c
0066C57F4  ldr      w8, [x0, #0xe0]
0066C57F8  cbnz     w8, #0x66c5804
0066C57FC  bl       #0x382be8c ; 
0066C5800  ldr      x0, [x23]
0066C5804  adrp     x9, #0x8f11000
0066C5808  ldr      x8, [x0, #0xb8]
0066C580C  ldr      x9, [x9, #0xec8]
0066C5810  ldr      x22, [x8]
0066C5814  ldr      x0, [x9]
0066C5818  bl       #0x382bfa0 ; 
0066C581C  adrp     x8, #0x8f11000
0066C5820  ldr      x8, [x8, #0xed8]
0066C5824  mov      x1, x22
0066C5828  mov      x3, xzr
0066C582C  mov      x21, x0
0066C5830  ldr      x2, [x8]
0066C5834  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C5838  ldr      x8, [x23]
0066C583C  mov      x1, x21
0066C5840  ldr      x0, [x8, #0xb8]
0066C5844  str      x21, [x0, #0x28]!
0066C5848  bl       #0x382bcb8 ; 
0066C584C  cbz      x20, #0x66c5898
0066C5850  adrp     x8, #0x8f11000
0066C5854  ldr      x8, [x8, #0xed0]
0066C5858  mov      x0, x20
0066C585C  mov      x1, x19
0066C5860  mov      x2, x21
0066C5864  ldr      x4, [x8]
0066C5868  ldp      x20, x19, [sp, #0x20]
0066C586C  ldp      x22, x21, [sp, #0x10]
0066C5870  mov      x3, xzr
0066C5874  ldp      x30, x23, [sp], #0x30
0066C5878  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C587C  ldr      x3, [x2, #0x60]
0066C5880  mov      x0, x20
0066C5884  mov      x1, x19
0066C5888  ldp      x20, x19, [sp, #0x20]
0066C588C  ldp      x22, x21, [sp, #0x10]
0066C5890  ldp      x30, x23, [sp], #0x30
0066C5894  br       x3
0066C5898  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroMaxHpChange
; RVA 0x66C589C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C589C  stp      x30, x23, [sp, #-0x30]!
0066C58A0  stp      x22, x21, [sp, #0x10]
0066C58A4  stp      x20, x19, [sp, #0x20]
0066C58A8  adrp     x21, #0x959a000
0066C58AC  adrp     x22, #0x8f11000
0066C58B0  ldrb     w8, [x21, #0x259]
0066C58B4  ldr      x22, [x22, #0xee0]
0066C58B8  mov      x19, x1
0066C58BC  mov      x20, x0
0066C58C0  tbnz     w8, #0, #0x66c5908
0066C58C4  adrp     x0, #0x8f11000
0066C58C8  ldr      x0, [x0, #0xee8]
0066C58CC  bl       #0x382bd14 ; 
0066C58D0  adrp     x0, #0x8f11000
0066C58D4  ldr      x0, [x0, #0xee0]
0066C58D8  bl       #0x382bd14 ; 
0066C58DC  adrp     x0, #0x8f11000
0066C58E0  ldr      x0, [x0, #0xef0]
0066C58E4  bl       #0x382bd14 ; 
0066C58E8  adrp     x0, #0x8f11000
0066C58EC  ldr      x0, [x0, #0xef8]
0066C58F0  bl       #0x382bd14 ; 
0066C58F4  adrp     x0, #0x8f11000
0066C58F8  ldr      x0, [x0, #0xba8]
0066C58FC  bl       #0x382bd14 ; 
0066C5900  mov      w8, #1
0066C5904  strb     w8, [x21, #0x259]
0066C5908  ldr      x2, [x22]
0066C590C  ldrb     w8, [x2, #0x53]
0066C5910  tbnz     w8, #5, #0x66c59c4
0066C5914  adrp     x23, #0x8f11000
0066C5918  ldr      x23, [x23, #0xba8]
0066C591C  ldr      x0, [x23]
0066C5920  ldr      w8, [x0, #0xe0]
0066C5924  cbnz     w8, #0x66c5930
0066C5928  bl       #0x382be8c ; 
0066C592C  ldr      x0, [x23]
0066C5930  ldr      x8, [x0, #0xb8]
0066C5934  ldr      x21, [x8, #0x30]
0066C5938  cbnz     x21, #0x66c5994
0066C593C  ldr      w8, [x0, #0xe0]
0066C5940  cbnz     w8, #0x66c594c
0066C5944  bl       #0x382be8c ; 
0066C5948  ldr      x0, [x23]
0066C594C  adrp     x9, #0x8f11000
0066C5950  ldr      x8, [x0, #0xb8]
0066C5954  ldr      x9, [x9, #0xee8]
0066C5958  ldr      x22, [x8]
0066C595C  ldr      x0, [x9]
0066C5960  bl       #0x382bfa0 ; 
0066C5964  adrp     x8, #0x8f11000
0066C5968  ldr      x8, [x8, #0xef8]
0066C596C  mov      x1, x22
0066C5970  mov      x3, xzr
0066C5974  mov      x21, x0
0066C5978  ldr      x2, [x8]
0066C597C  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C5980  ldr      x8, [x23]
0066C5984  mov      x1, x21
0066C5988  ldr      x0, [x8, #0xb8]
0066C598C  str      x21, [x0, #0x30]!
0066C5990  bl       #0x382bcb8 ; 
0066C5994  cbz      x20, #0x66c59e0
0066C5998  adrp     x8, #0x8f11000
0066C599C  ldr      x8, [x8, #0xef0]
0066C59A0  mov      x0, x20
0066C59A4  mov      x1, x19
0066C59A8  mov      x2, x21
0066C59AC  ldr      x4, [x8]
0066C59B0  ldp      x20, x19, [sp, #0x20]
0066C59B4  ldp      x22, x21, [sp, #0x10]
0066C59B8  mov      x3, xzr
0066C59BC  ldp      x30, x23, [sp], #0x30
0066C59C0  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C59C4  ldr      x3, [x2, #0x60]
0066C59C8  mov      x0, x20
0066C59CC  mov      x1, x19
0066C59D0  ldp      x20, x19, [sp, #0x20]
0066C59D4  ldp      x22, x21, [sp, #0x10]
0066C59D8  ldp      x30, x23, [sp], #0x30
0066C59DC  br       x3
0066C59E0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroHitted
; RVA 0x66C2554; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C2554  stp      x30, x23, [sp, #-0x30]!
0066C2558  stp      x22, x21, [sp, #0x10]
0066C255C  stp      x20, x19, [sp, #0x20]
0066C2560  adrp     x21, #0x959a000
0066C2564  adrp     x22, #0x8f11000
0066C2568  ldrb     w8, [x21, #0x25a]
0066C256C  ldr      x22, [x22, #0xd88]
0066C2570  mov      x19, x1
0066C2574  mov      x20, x0
0066C2578  tbnz     w8, #0, #0x66c25c0
0066C257C  adrp     x0, #0x8f11000
0066C2580  ldr      x0, [x0, #0xd90]
0066C2584  bl       #0x382bd14 ; 
0066C2588  adrp     x0, #0x8f11000
0066C258C  ldr      x0, [x0, #0xd88]
0066C2590  bl       #0x382bd14 ; 
0066C2594  adrp     x0, #0x8f11000
0066C2598  ldr      x0, [x0, #0xd98]
0066C259C  bl       #0x382bd14 ; 
0066C25A0  adrp     x0, #0x8f11000
0066C25A4  ldr      x0, [x0, #0xda0]
0066C25A8  bl       #0x382bd14 ; 
0066C25AC  adrp     x0, #0x8f11000
0066C25B0  ldr      x0, [x0, #0xba8]
0066C25B4  bl       #0x382bd14 ; 
0066C25B8  mov      w8, #1
0066C25BC  strb     w8, [x21, #0x25a]
0066C25C0  ldr      x2, [x22]
0066C25C4  ldrb     w8, [x2, #0x53]
0066C25C8  tbnz     w8, #5, #0x66c267c
0066C25CC  adrp     x23, #0x8f11000
0066C25D0  ldr      x23, [x23, #0xba8]
0066C25D4  ldr      x0, [x23]
0066C25D8  ldr      w8, [x0, #0xe0]
0066C25DC  cbnz     w8, #0x66c25e8
0066C25E0  bl       #0x382be8c ; 
0066C25E4  ldr      x0, [x23]
0066C25E8  ldr      x8, [x0, #0xb8]
0066C25EC  ldr      x21, [x8, #0x38]
0066C25F0  cbnz     x21, #0x66c264c
0066C25F4  ldr      w8, [x0, #0xe0]
0066C25F8  cbnz     w8, #0x66c2604
0066C25FC  bl       #0x382be8c ; 
0066C2600  ldr      x0, [x23]
0066C2604  adrp     x9, #0x8f11000
0066C2608  ldr      x8, [x0, #0xb8]
0066C260C  ldr      x9, [x9, #0xd90]
0066C2610  ldr      x22, [x8]
0066C2614  ldr      x0, [x9]
0066C2618  bl       #0x382bfa0 ; 
0066C261C  adrp     x8, #0x8f11000
0066C2620  ldr      x8, [x8, #0xda0]
0066C2624  mov      x1, x22
0066C2628  mov      x3, xzr
0066C262C  mov      x21, x0
0066C2630  ldr      x2, [x8]
0066C2634  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C2638  ldr      x8, [x23]
0066C263C  mov      x1, x21
0066C2640  ldr      x0, [x8, #0xb8]
0066C2644  str      x21, [x0, #0x38]!
0066C2648  bl       #0x382bcb8 ; 
0066C264C  cbz      x20, #0x66c2698
0066C2650  adrp     x8, #0x8f11000
0066C2654  ldr      x8, [x8, #0xd98]
0066C2658  mov      x0, x20
0066C265C  mov      x1, x19
0066C2660  mov      x2, x21
0066C2664  ldr      x4, [x8]
0066C2668  ldp      x20, x19, [sp, #0x20]
0066C266C  ldp      x22, x21, [sp, #0x10]
0066C2670  mov      x3, xzr
0066C2674  ldp      x30, x23, [sp], #0x30
0066C2678  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C267C  ldr      x3, [x2, #0x60]
0066C2680  mov      x0, x20
0066C2684  mov      x1, x19
0066C2688  ldp      x20, x19, [sp, #0x20]
0066C268C  ldp      x22, x21, [sp, #0x10]
0066C2690  ldp      x30, x23, [sp], #0x30
0066C2694  br       x3
0066C2698  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroDiscreteDistance
; RVA 0x66C59E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C59E4  stp      x30, x23, [sp, #-0x30]!
0066C59E8  stp      x22, x21, [sp, #0x10]
0066C59EC  stp      x20, x19, [sp, #0x20]
0066C59F0  adrp     x21, #0x959a000
0066C59F4  adrp     x22, #0x8f11000
0066C59F8  ldrb     w8, [x21, #0x25b]
0066C59FC  ldr      x22, [x22, #0xf00]
0066C5A00  mov      x19, x1
0066C5A04  mov      x20, x0
0066C5A08  tbnz     w8, #0, #0x66c5a50
0066C5A0C  adrp     x0, #0x8f11000
0066C5A10  ldr      x0, [x0, #0xf08]
0066C5A14  bl       #0x382bd14 ; 
0066C5A18  adrp     x0, #0x8f11000
0066C5A1C  ldr      x0, [x0, #0xf00]
0066C5A20  bl       #0x382bd14 ; 
0066C5A24  adrp     x0, #0x8f11000
0066C5A28  ldr      x0, [x0, #0xf10]
0066C5A2C  bl       #0x382bd14 ; 
0066C5A30  adrp     x0, #0x8f11000
0066C5A34  ldr      x0, [x0, #0xf18]
0066C5A38  bl       #0x382bd14 ; 
0066C5A3C  adrp     x0, #0x8f11000
0066C5A40  ldr      x0, [x0, #0xba8]
0066C5A44  bl       #0x382bd14 ; 
0066C5A48  mov      w8, #1
0066C5A4C  strb     w8, [x21, #0x25b]
0066C5A50  ldr      x2, [x22]
0066C5A54  ldrb     w8, [x2, #0x53]
0066C5A58  tbnz     w8, #5, #0x66c5b0c
0066C5A5C  adrp     x23, #0x8f11000
0066C5A60  ldr      x23, [x23, #0xba8]
0066C5A64  ldr      x0, [x23]
0066C5A68  ldr      w8, [x0, #0xe0]
0066C5A6C  cbnz     w8, #0x66c5a78
0066C5A70  bl       #0x382be8c ; 
0066C5A74  ldr      x0, [x23]
0066C5A78  ldr      x8, [x0, #0xb8]
0066C5A7C  ldr      x21, [x8, #0x40]
0066C5A80  cbnz     x21, #0x66c5adc
0066C5A84  ldr      w8, [x0, #0xe0]
0066C5A88  cbnz     w8, #0x66c5a94
0066C5A8C  bl       #0x382be8c ; 
0066C5A90  ldr      x0, [x23]
0066C5A94  adrp     x9, #0x8f11000
0066C5A98  ldr      x8, [x0, #0xb8]
0066C5A9C  ldr      x9, [x9, #0xf08]
0066C5AA0  ldr      x22, [x8]
0066C5AA4  ldr      x0, [x9]
0066C5AA8  bl       #0x382bfa0 ; 
0066C5AAC  adrp     x8, #0x8f11000
0066C5AB0  ldr      x8, [x8, #0xf18]
0066C5AB4  mov      x1, x22
0066C5AB8  mov      x3, xzr
0066C5ABC  mov      x21, x0
0066C5AC0  ldr      x2, [x8]
0066C5AC4  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C5AC8  ldr      x8, [x23]
0066C5ACC  mov      x1, x21
0066C5AD0  ldr      x0, [x8, #0xb8]
0066C5AD4  str      x21, [x0, #0x40]!
0066C5AD8  bl       #0x382bcb8 ; 
0066C5ADC  cbz      x20, #0x66c5b28
0066C5AE0  adrp     x8, #0x8f11000
0066C5AE4  ldr      x8, [x8, #0xf10]
0066C5AE8  mov      x0, x20
0066C5AEC  mov      x1, x19
0066C5AF0  mov      x2, x21
0066C5AF4  ldr      x4, [x8]
0066C5AF8  ldp      x20, x19, [sp, #0x20]
0066C5AFC  ldp      x22, x21, [sp, #0x10]
0066C5B00  mov      x3, xzr
0066C5B04  ldp      x30, x23, [sp], #0x30
0066C5B08  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C5B0C  ldr      x3, [x2, #0x60]
0066C5B10  mov      x0, x20
0066C5B14  mov      x1, x19
0066C5B18  ldp      x20, x19, [sp, #0x20]
0066C5B1C  ldp      x22, x21, [sp, #0x10]
0066C5B20  ldp      x30, x23, [sp], #0x30
0066C5B24  br       x3
0066C5B28  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroDropItem
; RVA 0x66C5B2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5B2C  stp      x30, x23, [sp, #-0x30]!
0066C5B30  stp      x22, x21, [sp, #0x10]
0066C5B34  stp      x20, x19, [sp, #0x20]
0066C5B38  adrp     x21, #0x959a000
0066C5B3C  adrp     x22, #0x8f11000
0066C5B40  ldrb     w8, [x21, #0x25c]
0066C5B44  ldr      x22, [x22, #0xf20]
0066C5B48  mov      x19, x1
0066C5B4C  mov      x20, x0
0066C5B50  tbnz     w8, #0, #0x66c5b98
0066C5B54  adrp     x0, #0x8f11000
0066C5B58  ldr      x0, [x0, #0xf28]
0066C5B5C  bl       #0x382bd14 ; 
0066C5B60  adrp     x0, #0x8f11000
0066C5B64  ldr      x0, [x0, #0xf20]
0066C5B68  bl       #0x382bd14 ; 
0066C5B6C  adrp     x0, #0x8f11000
0066C5B70  ldr      x0, [x0, #0xf30]
0066C5B74  bl       #0x382bd14 ; 
0066C5B78  adrp     x0, #0x8f11000
0066C5B7C  ldr      x0, [x0, #0xf38]
0066C5B80  bl       #0x382bd14 ; 
0066C5B84  adrp     x0, #0x8f11000
0066C5B88  ldr      x0, [x0, #0xba8]
0066C5B8C  bl       #0x382bd14 ; 
0066C5B90  mov      w8, #1
0066C5B94  strb     w8, [x21, #0x25c]
0066C5B98  ldr      x2, [x22]
0066C5B9C  ldrb     w8, [x2, #0x53]
0066C5BA0  tbnz     w8, #5, #0x66c5c54
0066C5BA4  adrp     x23, #0x8f11000
0066C5BA8  ldr      x23, [x23, #0xba8]
0066C5BAC  ldr      x0, [x23]
0066C5BB0  ldr      w8, [x0, #0xe0]
0066C5BB4  cbnz     w8, #0x66c5bc0
0066C5BB8  bl       #0x382be8c ; 
0066C5BBC  ldr      x0, [x23]
0066C5BC0  ldr      x8, [x0, #0xb8]
0066C5BC4  ldr      x21, [x8, #0x48]
0066C5BC8  cbnz     x21, #0x66c5c24
0066C5BCC  ldr      w8, [x0, #0xe0]
0066C5BD0  cbnz     w8, #0x66c5bdc
0066C5BD4  bl       #0x382be8c ; 
0066C5BD8  ldr      x0, [x23]
0066C5BDC  adrp     x9, #0x8f11000
0066C5BE0  ldr      x8, [x0, #0xb8]
0066C5BE4  ldr      x9, [x9, #0xf28]
0066C5BE8  ldr      x22, [x8]
0066C5BEC  ldr      x0, [x9]
0066C5BF0  bl       #0x382bfa0 ; 
0066C5BF4  adrp     x8, #0x8f11000
0066C5BF8  ldr      x8, [x8, #0xf38]
0066C5BFC  mov      x1, x22
0066C5C00  mov      x3, xzr
0066C5C04  mov      x21, x0
0066C5C08  ldr      x2, [x8]
0066C5C0C  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C5C10  ldr      x8, [x23]
0066C5C14  mov      x1, x21
0066C5C18  ldr      x0, [x8, #0xb8]
0066C5C1C  str      x21, [x0, #0x48]!
0066C5C20  bl       #0x382bcb8 ; 
0066C5C24  cbz      x20, #0x66c5c70
0066C5C28  adrp     x8, #0x8f11000
0066C5C2C  ldr      x8, [x8, #0xf30]
0066C5C30  mov      x0, x20
0066C5C34  mov      x1, x19
0066C5C38  mov      x2, x21
0066C5C3C  ldr      x4, [x8]
0066C5C40  ldp      x20, x19, [sp, #0x20]
0066C5C44  ldp      x22, x21, [sp, #0x10]
0066C5C48  mov      x3, xzr
0066C5C4C  ldp      x30, x23, [sp], #0x30
0066C5C50  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C5C54  ldr      x3, [x2, #0x60]
0066C5C58  mov      x0, x20
0066C5C5C  mov      x1, x19
0066C5C60  ldp      x20, x19, [sp, #0x20]
0066C5C64  ldp      x22, x21, [sp, #0x10]
0066C5C68  ldp      x30, x23, [sp], #0x30
0066C5C6C  br       x3
0066C5C70  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroMiss
; RVA 0x66BE50C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BE50C  stp      x30, x23, [sp, #-0x30]!
0066BE510  stp      x22, x21, [sp, #0x10]
0066BE514  stp      x20, x19, [sp, #0x20]
0066BE518  adrp     x21, #0x959a000
0066BE51C  adrp     x22, #0x8f11000
0066BE520  ldrb     w8, [x21, #0x25d]
0066BE524  ldr      x22, [x22, #0xb88]
0066BE528  mov      x19, x1
0066BE52C  mov      x20, x0
0066BE530  tbnz     w8, #0, #0x66be578
0066BE534  adrp     x0, #0x8f11000
0066BE538  ldr      x0, [x0, #0xb90]
0066BE53C  bl       #0x382bd14 ; 
0066BE540  adrp     x0, #0x8f11000
0066BE544  ldr      x0, [x0, #0xb88]
0066BE548  bl       #0x382bd14 ; 
0066BE54C  adrp     x0, #0x8f11000
0066BE550  ldr      x0, [x0, #0xb98]
0066BE554  bl       #0x382bd14 ; 
0066BE558  adrp     x0, #0x8f11000
0066BE55C  ldr      x0, [x0, #0xba0]
0066BE560  bl       #0x382bd14 ; 
0066BE564  adrp     x0, #0x8f11000
0066BE568  ldr      x0, [x0, #0xba8]
0066BE56C  bl       #0x382bd14 ; 
0066BE570  mov      w8, #1
0066BE574  strb     w8, [x21, #0x25d]
0066BE578  ldr      x2, [x22]
0066BE57C  ldrb     w8, [x2, #0x53]
0066BE580  tbnz     w8, #5, #0x66be634
0066BE584  adrp     x23, #0x8f11000
0066BE588  ldr      x23, [x23, #0xba8]
0066BE58C  ldr      x0, [x23]
0066BE590  ldr      w8, [x0, #0xe0]
0066BE594  cbnz     w8, #0x66be5a0
0066BE598  bl       #0x382be8c ; 
0066BE59C  ldr      x0, [x23]
0066BE5A0  ldr      x8, [x0, #0xb8]
0066BE5A4  ldr      x21, [x8, #0x50]
0066BE5A8  cbnz     x21, #0x66be604
0066BE5AC  ldr      w8, [x0, #0xe0]
0066BE5B0  cbnz     w8, #0x66be5bc
0066BE5B4  bl       #0x382be8c ; 
0066BE5B8  ldr      x0, [x23]
0066BE5BC  adrp     x9, #0x8f11000
0066BE5C0  ldr      x8, [x0, #0xb8]
0066BE5C4  ldr      x9, [x9, #0xb90]
0066BE5C8  ldr      x22, [x8]
0066BE5CC  ldr      x0, [x9]
0066BE5D0  bl       #0x382bfa0 ; 
0066BE5D4  adrp     x8, #0x8f11000
0066BE5D8  ldr      x8, [x8, #0xba0]
0066BE5DC  mov      x1, x22
0066BE5E0  mov      x3, xzr
0066BE5E4  mov      x21, x0
0066BE5E8  ldr      x2, [x8]
0066BE5EC  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066BE5F0  ldr      x8, [x23]
0066BE5F4  mov      x1, x21
0066BE5F8  ldr      x0, [x8, #0xb8]
0066BE5FC  str      x21, [x0, #0x50]!
0066BE600  bl       #0x382bcb8 ; 
0066BE604  cbz      x20, #0x66be650
0066BE608  adrp     x8, #0x8f11000
0066BE60C  ldr      x8, [x8, #0xb98]
0066BE610  mov      x0, x20
0066BE614  mov      x1, x19
0066BE618  mov      x2, x21
0066BE61C  ldr      x4, [x8]
0066BE620  ldp      x20, x19, [sp, #0x20]
0066BE624  ldp      x22, x21, [sp, #0x10]
0066BE628  mov      x3, xzr
0066BE62C  ldp      x30, x23, [sp], #0x30
0066BE630  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066BE634  ldr      x3, [x2, #0x60]
0066BE638  mov      x0, x20
0066BE63C  mov      x1, x19
0066BE640  ldp      x20, x19, [sp, #0x20]
0066BE644  ldp      x22, x21, [sp, #0x10]
0066BE648  ldp      x30, x23, [sp], #0x30
0066BE64C  br       x3
0066BE650  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroAddBuff
; RVA 0x66C5C74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5C74  stp      x30, x23, [sp, #-0x30]!
0066C5C78  stp      x22, x21, [sp, #0x10]
0066C5C7C  stp      x20, x19, [sp, #0x20]
0066C5C80  adrp     x21, #0x959a000
0066C5C84  adrp     x22, #0x8f11000
0066C5C88  ldrb     w8, [x21, #0x25e]
0066C5C8C  ldr      x22, [x22, #0xf40]
0066C5C90  mov      x19, x1
0066C5C94  mov      x20, x0
0066C5C98  tbnz     w8, #0, #0x66c5ce0
0066C5C9C  adrp     x0, #0x8f11000
0066C5CA0  ldr      x0, [x0, #0xf48]
0066C5CA4  bl       #0x382bd14 ; 
0066C5CA8  adrp     x0, #0x8f11000
0066C5CAC  ldr      x0, [x0, #0xf40]
0066C5CB0  bl       #0x382bd14 ; 
0066C5CB4  adrp     x0, #0x8f11000
0066C5CB8  ldr      x0, [x0, #0xf50]
0066C5CBC  bl       #0x382bd14 ; 
0066C5CC0  adrp     x0, #0x8f11000
0066C5CC4  ldr      x0, [x0, #0xf58]
0066C5CC8  bl       #0x382bd14 ; 
0066C5CCC  adrp     x0, #0x8f11000
0066C5CD0  ldr      x0, [x0, #0xba8]
0066C5CD4  bl       #0x382bd14 ; 
0066C5CD8  mov      w8, #1
0066C5CDC  strb     w8, [x21, #0x25e]
0066C5CE0  ldr      x2, [x22]
0066C5CE4  ldrb     w8, [x2, #0x53]
0066C5CE8  tbnz     w8, #5, #0x66c5d9c
0066C5CEC  adrp     x23, #0x8f11000
0066C5CF0  ldr      x23, [x23, #0xba8]
0066C5CF4  ldr      x0, [x23]
0066C5CF8  ldr      w8, [x0, #0xe0]
0066C5CFC  cbnz     w8, #0x66c5d08
0066C5D00  bl       #0x382be8c ; 
0066C5D04  ldr      x0, [x23]
0066C5D08  ldr      x8, [x0, #0xb8]
0066C5D0C  ldr      x21, [x8, #0x58]
0066C5D10  cbnz     x21, #0x66c5d6c
0066C5D14  ldr      w8, [x0, #0xe0]
0066C5D18  cbnz     w8, #0x66c5d24
0066C5D1C  bl       #0x382be8c ; 
0066C5D20  ldr      x0, [x23]
0066C5D24  adrp     x9, #0x8f11000
0066C5D28  ldr      x8, [x0, #0xb8]
0066C5D2C  ldr      x9, [x9, #0xf48]
0066C5D30  ldr      x22, [x8]
0066C5D34  ldr      x0, [x9]
0066C5D38  bl       #0x382bfa0 ; 
0066C5D3C  adrp     x8, #0x8f11000
0066C5D40  ldr      x8, [x8, #0xf58]
0066C5D44  mov      x1, x22
0066C5D48  mov      x3, xzr
0066C5D4C  mov      x21, x0
0066C5D50  ldr      x2, [x8]
0066C5D54  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C5D58  ldr      x8, [x23]
0066C5D5C  mov      x1, x21
0066C5D60  ldr      x0, [x8, #0xb8]
0066C5D64  str      x21, [x0, #0x58]!
0066C5D68  bl       #0x382bcb8 ; 
0066C5D6C  cbz      x20, #0x66c5db8
0066C5D70  adrp     x8, #0x8f11000
0066C5D74  ldr      x8, [x8, #0xf50]
0066C5D78  mov      x0, x20
0066C5D7C  mov      x1, x19
0066C5D80  mov      x2, x21
0066C5D84  ldr      x4, [x8]
0066C5D88  ldp      x20, x19, [sp, #0x20]
0066C5D8C  ldp      x22, x21, [sp, #0x10]
0066C5D90  mov      x3, xzr
0066C5D94  ldp      x30, x23, [sp], #0x30
0066C5D98  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C5D9C  ldr      x3, [x2, #0x60]
0066C5DA0  mov      x0, x20
0066C5DA4  mov      x1, x19
0066C5DA8  ldp      x20, x19, [sp, #0x20]
0066C5DAC  ldp      x22, x21, [sp, #0x10]
0066C5DB0  ldp      x30, x23, [sp], #0x30
0066C5DB4  br       x3
0066C5DB8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroSkillSelected
; RVA 0x66C5DBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5DBC  str      x30, [sp, #-0x30]!
0066C5DC0  stp      x22, x21, [sp, #0x10]
0066C5DC4  stp      x20, x19, [sp, #0x20]
0066C5DC8  adrp     x20, #0x959a000
0066C5DCC  adrp     x21, #0x8f11000
0066C5DD0  ldrb     w8, [x20, #0x25f]
0066C5DD4  ldr      x21, [x21, #0xf60]
0066C5DD8  mov      x19, x0
0066C5DDC  tbnz     w8, #0, #0x66c5e24
0066C5DE0  adrp     x0, #0x8f11000
0066C5DE4  ldr      x0, [x0, #0xf68]
0066C5DE8  bl       #0x382bd14 ; 
0066C5DEC  adrp     x0, #0x8f11000
0066C5DF0  ldr      x0, [x0, #0xf60]
0066C5DF4  bl       #0x382bd14 ; 
0066C5DF8  adrp     x0, #0x8f11000
0066C5DFC  ldr      x0, [x0, #0xf70]
0066C5E00  bl       #0x382bd14 ; 
0066C5E04  adrp     x0, #0x8f11000
0066C5E08  ldr      x0, [x0, #0xf78]
0066C5E0C  bl       #0x382bd14 ; 
0066C5E10  adrp     x0, #0x8f11000
0066C5E14  ldr      x0, [x0, #0xba8]
0066C5E18  bl       #0x382bd14 ; 
0066C5E1C  mov      w8, #1
0066C5E20  strb     w8, [x20, #0x25f]
0066C5E24  ldr      x1, [x21]
0066C5E28  ldrb     w8, [x1, #0x53]
0066C5E2C  tbnz     w8, #5, #0x66c5ee0
0066C5E30  adrp     x22, #0x8f11000
0066C5E34  ldr      x22, [x22, #0xba8]
0066C5E38  ldr      x0, [x22]
0066C5E3C  ldr      w8, [x0, #0xe0]
0066C5E40  cbnz     w8, #0x66c5e4c
0066C5E44  bl       #0x382be8c ; 
0066C5E48  ldr      x0, [x22]
0066C5E4C  ldr      x8, [x0, #0xb8]
0066C5E50  ldr      x20, [x8, #0x60]
0066C5E54  cbnz     x20, #0x66c5eb0
0066C5E58  ldr      w8, [x0, #0xe0]
0066C5E5C  cbnz     w8, #0x66c5e68
0066C5E60  bl       #0x382be8c ; 
0066C5E64  ldr      x0, [x22]
0066C5E68  adrp     x9, #0x8f11000
0066C5E6C  ldr      x8, [x0, #0xb8]
0066C5E70  ldr      x9, [x9, #0xf68]
0066C5E74  ldr      x21, [x8]
0066C5E78  ldr      x0, [x9]
0066C5E7C  bl       #0x382bfa0 ; 
0066C5E80  adrp     x8, #0x8f11000
0066C5E84  ldr      x8, [x8, #0xf78]
0066C5E88  mov      x1, x21
0066C5E8C  mov      x3, xzr
0066C5E90  mov      x20, x0
0066C5E94  ldr      x2, [x8]
0066C5E98  bl       #0x6043f64 ; System.Action<object, object>$$.ctor
0066C5E9C  ldr      x8, [x22]
0066C5EA0  mov      x1, x20
0066C5EA4  ldr      x0, [x8, #0xb8]
0066C5EA8  str      x20, [x0, #0x60]!
0066C5EAC  bl       #0x382bcb8 ; 
0066C5EB0  cbz      x19, #0x66c5ef8
0066C5EB4  adrp     x8, #0x8f11000
0066C5EB8  ldr      x8, [x8, #0xf70]
0066C5EBC  mov      x0, x19
0066C5EC0  mov      x2, x20
0066C5EC4  ldp      x20, x19, [sp, #0x20]
0066C5EC8  ldr      x4, [x8]
0066C5ECC  ldp      x22, x21, [sp, #0x10]
0066C5ED0  mov      x1, xzr
0066C5ED4  mov      x3, xzr
0066C5ED8  ldr      x30, [sp], #0x30
0066C5EDC  b        #0x454d854 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowers<object>
0066C5EE0  ldr      x2, [x1, #0x60]
0066C5EE4  mov      x0, x19
0066C5EE8  ldp      x20, x19, [sp, #0x20]
0066C5EEC  ldp      x22, x21, [sp, #0x10]
0066C5EF0  ldr      x30, [sp], #0x30
0066C5EF4  br       x2
0066C5EF8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$ProcessCritTrigger
; RVA 0x66BEF20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066BEF20  sub      sp, sp, #0x70
0066BEF24  str      x30, [sp, #0x20]
0066BEF28  stp      x26, x25, [sp, #0x30]
0066BEF2C  stp      x24, x23, [sp, #0x40]
0066BEF30  stp      x22, x21, [sp, #0x50]
0066BEF34  stp      x20, x19, [sp, #0x60]
0066BEF38  mrs      x25, tpidr_el0
0066BEF3C  ldr      x8, [x25, #0x28]
0066BEF40  adrp     x22, #0x959a000
0066BEF44  adrp     x26, #0x8f11000
0066BEF48  mov      x20, x4
0066BEF4C  str      x8, [sp, #0x18]
0066BEF50  ldrb     w8, [x22, #0x260]
0066BEF54  ldr      x26, [x26, #0xbe8]
0066BEF58  mov      x24, x3
0066BEF5C  mov      x21, x2
0066BEF60  mov      x19, x1
0066BEF64  mov      x23, x0
0066BEF68  tbnz     w8, #0, #0x66befbc
0066BEF6C  adrp     x0, #0x8f11000
0066BEF70  ldr      x0, [x0, #0xbe8]
0066BEF74  bl       #0x382bd14 ; 
0066BEF78  adrp     x0, #0x8ee6000
0066BEF7C  ldr      x0, [x0, #0xe0]
0066BEF80  bl       #0x382bd14 ; 
0066BEF84  adrp     x0, #0x8ee6000
0066BEF88  ldr      x0, [x0, #0xe8]
0066BEF8C  bl       #0x382bd14 ; 
0066BEF90  adrp     x0, #0x8ee6000
0066BEF94  ldr      x0, [x0, #0xf0]
0066BEF98  bl       #0x382bd14 ; 
0066BEF9C  adrp     x0, #0x8ee6000
0066BEFA0  ldr      x0, [x0, #0x608]
0066BEFA4  bl       #0x382bd14 ; 
0066BEFA8  adrp     x0, #0x8f11000
0066BEFAC  ldr      x0, [x0, #0xbf0]
0066BEFB0  bl       #0x382bd14 ; 
0066BEFB4  mov      w8, #1
0066BEFB8  strb     w8, [x22, #0x260]
0066BEFBC  ldr      x5, [x26]
0066BEFC0  ldrb     w8, [x5, #0x53]
0066BEFC4  tbnz     w8, #5, #0x66bf004
0066BEFC8  adrp     x22, #0x9591000
0066BEFCC  ldrb     w8, [x22, #0xa4b]
0066BEFD0  cbnz     w8, #0x66befe8
0066BEFD4  adrp     x0, #0x8ee5000
0066BEFD8  ldr      x0, [x0, #0xb28]
0066BEFDC  bl       #0x382bd14 ; 
0066BEFE0  mov      w8, #1
0066BEFE4  strb     w8, [x22, #0xa4b]
0066BEFE8  adrp     x8, #0x8ee5000
0066BEFEC  ldr      x8, [x8, #0xb28]
0066BEFF0  ldr      x1, [x8]
0066BEFF4  ldrb     w8, [x1, #0x53]
0066BEFF8  tbnz     w8, #5, #0x66bf024
0066BEFFC  ldr      x22, [x23, #0x20]
0066BF000  b        #0x66bf034 ; 
0066BF004  ldr      x8, [x5, #0x60]
0066BF008  mov      x0, x23
0066BF00C  mov      x1, x19
0066BF010  mov      x2, x21
0066BF014  mov      x3, x24
0066BF018  mov      x4, x20
0066BF01C  blr      x8
0066BF020  b        #0x66bf1ec ; 
0066BF024  ldr      x8, [x1, #0x60]
0066BF028  mov      x0, x23
0066BF02C  blr      x8
0066BF030  mov      x22, x0
0066BF034  cbz      x22, #0x66bf218
0066BF038  adrp     x26, #0x9591000
0066BF03C  ldrb     w8, [x26, #0xa4c]
0066BF040  cbnz     w8, #0x66bf058
0066BF044  adrp     x0, #0x8ee5000
0066BF048  ldr      x0, [x0, #0xb30]
0066BF04C  bl       #0x382bd14 ; 
0066BF050  mov      w8, #1
0066BF054  strb     w8, [x26, #0xa4c]
0066BF058  adrp     x8, #0x8ee5000
0066BF05C  ldr      x8, [x8, #0xb30]
0066BF060  ldr      x1, [x8]
0066BF064  ldrb     w8, [x1, #0x53]
0066BF068  tbnz     w8, #5, #0x66bf074
0066BF06C  ldr      x0, [x22, #0x210]
0066BF070  b        #0x66bf080 ; 
0066BF074  ldr      x8, [x1, #0x60]
0066BF078  mov      x0, x22
0066BF07C  blr      x8
0066BF080  cbz      x0, #0x66bf218
0066BF084  adrp     x8, #0x8f11000
0066BF088  ldr      x8, [x8, #0xbf0]
0066BF08C  ldr      x1, [x8]
0066BF090  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0066BF094  cbz      x21, #0x66bf218
0066BF098  ldr      x8, [x21, #0x38]
0066BF09C  ldur     q0, [x21, #0x28]
0066BF0A0  mov      x22, x0
0066BF0A4  str      x8, [sp, #0x10]
0066BF0A8  str      q0, [sp]
0066BF0AC  cbz      x0, #0x66bf218
0066BF0B0  ldr      q0, [sp]
0066BF0B4  ldr      x8, [sp, #0x10]
0066BF0B8  str      q0, [x22, #0x20]
0066BF0BC  stp      x8, x24, [x22, #0x30]
0066BF0C0  adrp     x8, #0x8ee6000
0066BF0C4  ldr      x8, [x8, #0x608]
0066BF0C8  ldr      x1, [x8]
0066BF0CC  ldrb     w8, [x1, #0x53]
0066BF0D0  tbnz     w8, #5, #0x66bf0dc
0066BF0D4  ldr      x0, [x23, #0x30]
0066BF0D8  b        #0x66bf0e8 ; 
0066BF0DC  ldr      x8, [x1, #0x60]
0066BF0E0  mov      x0, x23
0066BF0E4  blr      x8
0066BF0E8  cbz      x0, #0x66bf218
0066BF0EC  adrp     x8, #0x8ee6000
0066BF0F0  ldr      x8, [x8, #0xe8]
0066BF0F4  ldr      x1, [x8]
0066BF0F8  ldrb     w8, [x1, #0x53]
0066BF0FC  tbnz     w8, #5, #0x66bf108
0066BF100  ldr      x0, [x0, #0x28]
0066BF104  b        #0x66bf110 ; 
0066BF108  ldr      x8, [x1, #0x60]
0066BF10C  blr      x8
0066BF110  str      x0, [x22, #0x48]
0066BF114  cbz      x20, #0x66bf218
0066BF118  adrp     x8, #0x8ee6000
0066BF11C  ldr      x8, [x8, #0xe0]
0066BF120  ldr      x1, [x8]
0066BF124  ldrb     w8, [x1, #0x53]
0066BF128  tbnz     w8, #5, #0x66bf134
0066BF12C  ldr      x23, [x20, #0x38]
0066BF130  b        #0x66bf144 ; 
0066BF134  ldr      x8, [x1, #0x60]
0066BF138  mov      x0, x20
0066BF13C  blr      x8
0066BF140  mov      x23, x0
0066BF144  cbz      x23, #0x66bf218
0066BF148  adrp     x24, #0x9591000
0066BF14C  ldrb     w8, [x24, #0xa85]
0066BF150  cbnz     w8, #0x66bf168
0066BF154  adrp     x0, #0x8ee6000
0066BF158  ldr      x0, [x0, #0x310]
0066BF15C  bl       #0x382bd14 ; 
0066BF160  mov      w8, #1
0066BF164  strb     w8, [x24, #0xa85]
0066BF168  adrp     x8, #0x8ee6000
0066BF16C  ldr      x8, [x8, #0x310]
0066BF170  add      x21, x21, #0x28
0066BF174  ldr      x1, [x8]
0066BF178  ldrb     w8, [x1, #0x53]
0066BF17C  tbnz     w8, #5, #0x66bf188
0066BF180  ldr      w0, [x23, #0xb8]
0066BF184  b        #0x66bf194 ; 
0066BF188  ldr      x8, [x1, #0x60]
0066BF18C  mov      x0, x23
0066BF190  blr      x8
0066BF194  str      w0, [x22, #0x70]
0066BF198  ldr      x8, [x21, #0x10]
0066BF19C  ldr      q0, [x21]
0066BF1A0  str      x8, [x22, #0x68]
0066BF1A4  stur     q0, [x22, #0x58]
0066BF1A8  adrp     x8, #0x8ee6000
0066BF1AC  ldr      x8, [x8, #0xf0]
0066BF1B0  ldr      x1, [x8]
0066BF1B4  ldrb     w8, [x1, #0x53]
0066BF1B8  tbnz     w8, #5, #0x66bf1c4
0066BF1BC  ldr      x0, [x20, #0x28]
0066BF1C0  b        #0x66bf1d0 ; 
0066BF1C4  ldr      x8, [x1, #0x60]
0066BF1C8  mov      x0, x20
0066BF1CC  blr      x8
0066BF1D0  str      x0, [x22, #0x50]
0066BF1D4  cbz      x19, #0x66bf218
0066BF1D8  ldr      x0, [x19, #0x150]
0066BF1DC  cbz      x0, #0x66bf218
0066BF1E0  mov      x1, x22
0066BF1E4  mov      x2, xzr
0066BF1E8  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
0066BF1EC  ldr      x8, [x25, #0x28]
0066BF1F0  ldr      x9, [sp, #0x18]
0066BF1F4  cmp      x8, x9
0066BF1F8  b.ne     #0x66bf21c
0066BF1FC  ldp      x20, x19, [sp, #0x60]
0066BF200  ldp      x22, x21, [sp, #0x50]
0066BF204  ldp      x24, x23, [sp, #0x40]
0066BF208  ldp      x26, x25, [sp, #0x30]
0066BF20C  ldr      x30, [sp, #0x20]
0066BF210  add      sp, sp, #0x70
0066BF214  ret      
0066BF218  bl       #0x382bfb8 ; 
0066BF21C  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentOnHit$$.ctor
; RVA 0x66C5EFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C5EFC  str      x30, [sp, #-0x50]!
0066C5F00  stp      x26, x25, [sp, #0x10]
0066C5F04  stp      x24, x23, [sp, #0x20]
0066C5F08  stp      x22, x21, [sp, #0x30]
0066C5F0C  stp      x20, x19, [sp, #0x40]
0066C5F10  adrp     x20, #0x959a000
0066C5F14  adrp     x21, #0x8f11000
0066C5F18  ldrb     w8, [x20, #0x261]
0066C5F1C  ldr      x21, [x21, #0xf80]
0066C5F20  mov      x19, x0
0066C5F24  tbnz     w8, #0, #0x66c5f84
0066C5F28  adrp     x0, #0x8f11000
0066C5F2C  ldr      x0, [x0, #0xf80]
0066C5F30  bl       #0x382bd14 ; 
0066C5F34  adrp     x0, #0x8f11000
0066C5F38  ldr      x0, [x0, #0xf88]
0066C5F3C  bl       #0x382bd14 ; 
0066C5F40  adrp     x0, #0x8f11000
0066C5F44  ldr      x0, [x0, #0xf90]
0066C5F48  bl       #0x382bd14 ; 
0066C5F4C  adrp     x0, #0x8f11000
0066C5F50  ldr      x0, [x0, #0xf98]
0066C5F54  bl       #0x382bd14 ; 
0066C5F58  adrp     x0, #0x8f11000
0066C5F5C  ldr      x0, [x0, #0xfa0]
0066C5F60  bl       #0x382bd14 ; 
0066C5F64  adrp     x0, #0x8f11000
0066C5F68  ldr      x0, [x0, #0xfa8]
0066C5F6C  bl       #0x382bd14 ; 
0066C5F70  adrp     x0, #0x8f11000
0066C5F74  ldr      x0, [x0, #0xfb0]
0066C5F78  bl       #0x382bd14 ; 
0066C5F7C  mov      w8, #1
0066C5F80  strb     w8, [x20, #0x261]
0066C5F84  ldr      x1, [x21]
0066C5F88  ldrb     w8, [x1, #0x53]
0066C5F8C  tbnz     w8, #5, #0x66c60bc
0066C5F90  adrp     x24, #0x8f11000
0066C5F94  ldr      x24, [x24, #0xfa0]
0066C5F98  adrp     x25, #0x8f11000
0066C5F9C  adrp     x23, #0x8f11000
0066C5FA0  ldr      x25, [x25, #0xf88]
0066C5FA4  ldr      x23, [x23, #0xf98]
0066C5FA8  str      xzr, [x19, #0x48]
0066C5FAC  ldr      x0, [x24]
0066C5FB0  adrp     x26, #0x8f11000
0066C5FB4  adrp     x22, #0x8f11000
0066C5FB8  adrp     x21, #0x8f11000
0066C5FBC  ldr      x26, [x26, #0xf90]
0066C5FC0  ldr      x22, [x22, #0xfb0]
0066C5FC4  ldr      x21, [x21, #0xfa8]
0066C5FC8  bl       #0x382bfa0 ; 
0066C5FCC  ldr      x1, [x25]
0066C5FD0  mov      x20, x0
0066C5FD4  bl       #0x5d664b8 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$.ctor
0066C5FD8  mov      x0, x19
0066C5FDC  str      x20, [x0, #0x50]!
0066C5FE0  mov      x1, x20
0066C5FE4  bl       #0x382bcb8 ; 
0066C5FE8  ldr      x0, [x24]
0066C5FEC  bl       #0x382bfa0 ; 
0066C5FF0  ldr      x1, [x25]
0066C5FF4  mov      x20, x0
0066C5FF8  bl       #0x5d664b8 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, object>$$.ctor
0066C5FFC  mov      x0, x19
0066C6000  str      x20, [x0, #0x58]!
0066C6004  mov      x1, x20
0066C6008  bl       #0x382bcb8 ; 
0066C600C  ldr      x0, [x23]
0066C6010  bl       #0x382bfa0 ; 
0066C6014  ldr      x1, [x26]
0066C6018  mov      x20, x0
0066C601C  bl       #0x5d69e70 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$.ctor
0066C6020  mov      x0, x19
0066C6024  str      x20, [x0, #0x60]!
0066C6028  mov      x1, x20
0066C602C  bl       #0x382bcb8 ; 
0066C6030  ldr      x0, [x23]
0066C6034  bl       #0x382bfa0 ; 
0066C6038  ldr      x1, [x26]
0066C603C  mov      x20, x0
0066C6040  bl       #0x5d69e70 ; System.Collections.Generic.Dictionary<ValueTuple<EntityRef, int>, object>$$.ctor
0066C6044  mov      x0, x19
0066C6048  str      x20, [x0, #0x68]!
0066C604C  mov      x1, x20
0066C6050  bl       #0x382bcb8 ; 
0066C6054  ldr      x0, [x22]
0066C6058  bl       #0x382bfa0 ; 
0066C605C  ldr      x1, [x21]
0066C6060  mov      x20, x0
0066C6064  bl       #0x491500c ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$.ctor
0066C6068  mov      x0, x19
0066C606C  str      x20, [x0, #0x70]!
0066C6070  mov      x1, x20
0066C6074  bl       #0x382bcb8 ; 
0066C6078  ldr      x0, [x22]
0066C607C  bl       #0x382bfa0 ; 
0066C6080  ldr      x1, [x21]
0066C6084  mov      x20, x0
0066C6088  bl       #0x491500c ; System.Collections.Generic.HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>>$$.ctor
0066C608C  mov      x0, x19
0066C6090  str      x20, [x0, #0x78]!
0066C6094  mov      x1, x20
0066C6098  bl       #0x382bcb8 ; 
0066C609C  mov      x0, x19
0066C60A0  ldp      x20, x19, [sp, #0x40]
0066C60A4  ldp      x22, x21, [sp, #0x30]
0066C60A8  ldp      x24, x23, [sp, #0x20]
0066C60AC  ldp      x26, x25, [sp, #0x10]
0066C60B0  mov      x1, xzr
0066C60B4  ldr      x30, [sp], #0x50
0066C60B8  b        #0x6693378 ; HotFix.BattleLogic.CharacterComponentBase$$.ctor
0066C60BC  ldr      x2, [x1, #0x60]
0066C60C0  mov      x0, x19
0066C60C4  ldp      x20, x19, [sp, #0x40]
0066C60C8  ldp      x22, x21, [sp, #0x30]
0066C60CC  ldp      x24, x23, [sp, #0x20]
0066C60D0  ldp      x26, x25, [sp, #0x10]
0066C60D4  ldr      x30, [sp], #0x50
0066C60D8  br       x2

; HotFix.BattleLogic.CharacterComponentOnHit$$.cctor
; RVA 0x66C60DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066C60DC  str      x30, [sp, #-0x20]!
0066C60E0  stp      x20, x19, [sp, #0x10]
0066C60E4  adrp     x20, #0x959a000
0066C60E8  adrp     x19, #0x8f11000
0066C60EC  ldrb     w8, [x20, #0x262]
0066C60F0  ldr      x19, [x19, #0xa40]
0066C60F4  tbnz     w8, #0, #0x66c610c
0066C60F8  adrp     x0, #0x8f11000
0066C60FC  ldr      x0, [x0, #0xa40]
0066C6100  bl       #0x382bd14 ; 
0066C6104  mov      w8, #1
0066C6108  strb     w8, [x20, #0x262]
0066C610C  ldr      x8, [x19]
0066C6110  mov      w9, #0x8000
0066C6114  ldr      x8, [x8, #0xb8]
0066C6118  str      x9, [x8]
0066C611C  ldr      x8, [x19]
0066C6120  ldp      x20, x19, [sp, #0x10]
0066C6124  mov      w9, #0x10000
0066C6128  ldr      x8, [x8, #0xb8]
0066C612C  str      x9, [x8, #8]
0066C6130  ldr      x30, [sp], #0x20
0066C6134  ret      
0066C6138  str      x30, [sp, #-0x20]!
0066C613C  stp      x20, x19, [sp, #0x10]
0066C6140  adrp     x20, #0x959a000
0066C6144  ldrb     w8, [x20, #0x274]
0066C6148  mov      x19, x0
0066C614C  cbnz     w8, #0x66c6164
0066C6150  adrp     x0, #0x8f12000
0066C6154  ldr      x0, [x0, #0x58]
0066C6158  bl       #0x382bd14 ; 
0066C615C  mov      w8, #1
0066C6160  strb     w8, [x20, #0x274]
0066C6164  adrp     x8, #0x8f12000
0066C6168  ldr      x8, [x8, #0x58]
0066C616C  ldr      x1, [x8]
0066C6170  ldrb     w8, [x1, #0x53]
0066C6174  tbnz     w8, #5, #0x66c61d8
0066C6178  ldr      d0, [x19, #0x2d8]
0066C617C  movi     v1.2s, #1
0066C6180  mov      w1, #0x13
0066C6184  mov      x0, x19
0066C6188  add      v0.2s, v0.2s, v1.2s
0066C618C  mov      x2, xzr
0066C6190  str      d0, [x19, #0x2d8]
0066C6194  bl       #0x69fcc24 ; HotFix.BattleLogic.BattleWorldContext$$CheckBattleFlag
0066C6198  tbz      w0, #0, #0x66c61ec
0066C619C  adrp     x20, #0x9599000
0066C61A0  ldrb     w8, [x20, #0x2b9]
0066C61A4  cbnz     w8, #0x66c61bc
0066C61A8  adrp     x0, #0x8f08000
0066C61AC  ldr      x0, [x0, #0xa78]
0066C61B0  bl       #0x382bd14 ; 
0066C61B4  mov      w8, #1
0066C61B8  strb     w8, [x20, #0x2b9]
0066C61BC  adrp     x8, #0x8f08000
0066C61C0  ldr      x8, [x8, #0xa78]
0066C61C4  ldr      x1, [x8]
0066C61C8  ldrb     w8, [x1, #0x53]
0066C61CC  tbnz     w8, #5, #0x66c61f8
0066C61D0  ldr      x0, [x19, #0x228]
0066C61D4  b        #0x66c6204 ; 
0066C61D8  ldr      x2, [x1, #0x60]
0066C61DC  mov      x0, x19
0066C61E0  ldp      x20, x19, [sp, #0x10]
0066C61E4  ldr      x30, [sp], #0x20
0066C61E8  br       x2
0066C61EC  ldp      x20, x19, [sp, #0x10]
0066C61F0  ldr      x30, [sp], #0x20
0066C61F4  ret      
0066C61F8  ldr      x8, [x1, #0x60]
0066C61FC  mov      x0, x19
0066C6200  blr      x8
0066C6204  cbz      x0, #0x66c6218
0066C6208  ldp      x20, x19, [sp, #0x10]
0066C620C  mov      x1, xzr
0066C6210  ldr      x30, [sp], #0x20
0066C6214  b        #0x65963c0 ; HotFix.BattleLogic.BattleStarManager$$OnPlayerBeHit
0066C6218  bl       #0x382bfb8 ; 
0066C621C  sub      sp, sp, #0x40
0066C6220  stp      x30, x23, [sp, #0x10]
0066C6224  stp      x22, x21, [sp, #0x20]
0066C6228  stp      x20, x19, [sp, #0x30]
0066C622C  adrp     x20, #0x959a000
0066C6230  ldrb     w8, [x20, #0x276]
0066C6234  mov      x19, x0
0066C6238  cbnz     w8, #0x66c6250
0066C623C  adrp     x0, #0x8f12000
0066C6240  ldr      x0, [x0, #0x60]
0066C6244  bl       #0x382bd14 ; 
0066C6248  mov      w8, #1
0066C624C  strb     w8, [x20, #0x276]
0066C6250  adrp     x8, #0x8f12000
0066C6254  ldr      x8, [x8, #0x60]
0066C6258  ldr      x1, [x8]
0066C625C  ldrb     w8, [x1, #0x53]
0066C6260  tbnz     w8, #5, #0x66c6304
0066C6264  adrp     x21, #0x9591000
0066C6268  ldrb     w8, [x21, #0xa74]
0066C626C  cbnz     w8, #0x66c6284
0066C6270  adrp     x0, #0x8ee6000
0066C6274  ldr      x0, [x0, #0x288]
0066C6278  bl       #0x382bd14 ; 
0066C627C  mov      w8, #1
0066C6280  strb     w8, [x21, #0xa74]
0066C6284  adrp     x22, #0x8ee6000
0066C6288  ldr      x22, [x22, #0x288]
0066C628C  ldr      x1, [x22]
0066C6290  ldrb     w8, [x1, #0x53]
0066C6294  tbnz     w8, #5, #0x66c6314
0066C6298  ldr      x0, [x19, #0x170]
0066C629C  cbz      x0, #0x66c6324
0066C62A0  adrp     x20, #0x9591000
0066C62A4  ldrb     w8, [x20, #0xa73]
0066C62A8  cbnz     w8, #0x66c62c0
0066C62AC  adrp     x0, #0x8ee6000
0066C62B0  ldr      x0, [x0, #0x280]
0066C62B4  bl       #0x382bd14 ; 
0066C62B8  mov      w8, #1
0066C62BC  strb     w8, [x20, #0xa73]
0066C62C0  adrp     x8, #0x8ee6000
0066C62C4  ldr      x8, [x8, #0x280]
0066C62C8  ldr      x1, [x8]
0066C62CC  ldrb     w8, [x1, #0x53]
0066C62D0  tbnz     w8, #5, #0x66c6344
0066C62D4  ldrb     w8, [x21, #0xa74]
0066C62D8  cbnz     w8, #0x66c62f0
0066C62DC  adrp     x0, #0x8ee6000
0066C62E0  ldr      x0, [x0, #0x288]
0066C62E4  bl       #0x382bd14 ; 
0066C62E8  mov      w8, #1
0066C62EC  strb     w8, [x21, #0xa74]
0066C62F0  ldr      x1, [x22]
0066C62F4  ldrb     w8, [x1, #0x53]
0066C62F8  tbnz     w8, #5, #0x66c6350
0066C62FC  ldr      x20, [x19, #0x170]
0066C6300  b        #0x66c6360 ; 
0066C6304  ldr      x8, [x1, #0x60]
0066C6308  mov      x0, x19
0066C630C  blr      x8
0066C6310  b        #0x66c644c ; 
0066C6314  ldr      x8, [x1, #0x60]
0066C6318  mov      x0, x19
0066C631C  blr      x8
0066C6320  cbnz     x0, #0x66c62a0
0066C6324  add      x0, sp, #8
0066C6328  mov      w2, #-0xffffffff80000000
0066C632C  mov      w1, wzr
0066C6330  mov      x3, xzr
0066C6334  str      xzr, [sp, #8]
0066C6338  bl       #0x6a4c708 ; HotFix.BattleLogic.EntityCharacterTypeKey$$.ctor
0066C633C  ldr      x0, [sp, #8]
0066C6340  b        #0x66c6450 ; 
0066C6344  ldr      x8, [x1, #0x60]
0066C6348  mov      x0, x19
0066C634C  b        #0x66c63a8 ; 
0066C6350  ldr      x8, [x1, #0x60]
0066C6354  mov      x0, x19
0066C6358  blr      x8
0066C635C  mov      x20, x0
0066C6360  cbz      x20, #0x66c6464
0066C6364  adrp     x23, #0x9591000
0066C6368  ldrb     w8, [x23, #0xa75]
0066C636C  cbnz     w8, #0x66c6384
0066C6370  adrp     x0, #0x8ee6000
0066C6374  ldr      x0, [x0, #0x290]
0066C6378  bl       #0x382bd14 ; 
0066C637C  mov      w8, #1
0066C6380  strb     w8, [x23, #0xa75]
0066C6384  adrp     x8, #0x8ee6000
0066C6388  ldr      x8, [x8, #0x290]
0066C638C  ldr      x1, [x8]
0066C6390  ldrb     w8, [x1, #0x53]
0066C6394  tbnz     w8, #5, #0x66c63a0
0066C6398  ldr      w20, [x20, #0x24]
0066C639C  b        #0x66c63b0 ; 
0066C63A0  ldr      x8, [x1, #0x60]
0066C63A4  mov      x0, x20
0066C63A8  blr      x8
0066C63AC  mov      w20, w0
0066C63B0  ldrb     w8, [x21, #0xa74]
0066C63B4  cbnz     w8, #0x66c63cc
0066C63B8  adrp     x0, #0x8ee6000
0066C63BC  ldr      x0, [x0, #0x288]
0066C63C0  bl       #0x382bd14 ; 
0066C63C4  mov      w8, #1
0066C63C8  strb     w8, [x21, #0xa74]
0066C63CC  ldr      x1, [x22]
0066C63D0  ldrb     w8, [x1, #0x53]
0066C63D4  tbnz     w8, #5, #0x66c63e0
0066C63D8  ldr      x19, [x19, #0x170]
0066C63DC  b        #0x66c63f0 ; 
0066C63E0  ldr      x8, [x1, #0x60]
0066C63E4  mov      x0, x19
0066C63E8  blr      x8
0066C63EC  mov      x19, x0
0066C63F0  cbz      x19, #0x66c6464
0066C63F4  adrp     x21, #0x959a000
0066C63F8  ldrb     w8, [x21, #0x277]
0066C63FC  cbnz     w8, #0x66c6414
0066C6400  adrp     x0, #0x8f12000
0066C6404  ldr      x0, [x0, #0x68]
0066C6408  bl       #0x382bd14 ; 
0066C640C  mov      w8, #1
0066C6410  strb     w8, [x21, #0x277]
0066C6414  adrp     x8, #0x8f12000
0066C6418  ldr      x8, [x8, #0x68]
0066C641C  ldr      x1, [x8]
0066C6420  ldrb     w8, [x1, #0x53]
0066C6424  tbnz     w8, #5, #0x66c6430
0066C6428  ldr      w1, [x19, #0x30]
0066C642C  b        #0x66c6440 ; 
0066C6430  ldr      x8, [x1, #0x60]
0066C6434  mov      x0, x19
0066C6438  blr      x8
0066C643C  mov      w1, w0
0066C6440  mov      w0, w20
0066C6444  mov      x2, xzr
0066C6448  bl       #0x6a4d294 ; HotFix.BattleLogic.EntityCharacterTypeUtils$$GetCharacterTypeKey
0066C644C  str      x0, [sp, #8]
0066C6450  ldp      x20, x19, [sp, #0x30]
0066C6454  ldp      x22, x21, [sp, #0x20]
0066C6458  ldp      x30, x23, [sp, #0x10]
0066C645C  add      sp, sp, #0x40
0066C6460  ret      
0066C6464  bl       #0x382bfb8 ; 

