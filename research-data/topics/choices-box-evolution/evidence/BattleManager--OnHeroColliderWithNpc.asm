; HotFix.BattleLogic.BattleManager$$OnHeroColliderWithNpc
; RVA 0x6591B74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006591B74  stp      x30, x25, [sp, #-0x40]!
006591B78  stp      x24, x23, [sp, #0x10]
006591B7C  stp      x22, x21, [sp, #0x20]
006591B80  stp      x20, x19, [sp, #0x30]
006591B84  adrp     x22, #0x9599000
006591B88  adrp     x23, #0x8f08000
006591B8C  ldrb     w8, [x22, #0x247]
006591B90  ldr      x23, [x23, #0x890] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.OnHeroColliderWithNpc() @ 0x923cc08
006591B94  mov      x19, x2
006591B98  mov      x20, x1
006591B9C  mov      x21, x0
006591BA0  tbnz     w8, #0, #0x6591bc4
006591BA4  adrp     x0, #0x8f08000
006591BA8  ldr      x0, [x0, #0x890] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.OnHeroColliderWithNpc() @ 0x923cc08
006591BAC  bl       #0x382bd14 ; 
006591BB0  adrp     x0, #0x8ee6000
006591BB4  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006591BB8  bl       #0x382bd14 ; 
006591BBC  mov      w8, #1
006591BC0  strb     w8, [x22, #0x247]
006591BC4  ldr      x3, [x23]
006591BC8  ldrb     w8, [x3, #0x53]
006591BCC  tbnz     w8, #5, #0x6591c20
006591BD0  ldr      w8, [x21, #0x28]
006591BD4  cmp      w8, #8
006591BD8  b.eq     #0x6591d50
006591BDC  cmp      w8, #0xe
006591BE0  b.eq     #0x6591d50
006591BE4  adrp     x23, #0x9599000
006591BE8  ldrb     w8, [x23, #0x286]
006591BEC  cbnz     w8, #0x6591c04
006591BF0  adrp     x0, #0x8f07000
006591BF4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006591BF8  bl       #0x382bd14 ; 
006591BFC  mov      w8, #1
006591C00  strb     w8, [x23, #0x286]
006591C04  adrp     x24, #0x8f07000
006591C08  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006591C0C  ldr      x1, [x24]
006591C10  ldrb     w8, [x1, #0x53]
006591C14  tbnz     w8, #5, #0x6591c44
006591C18  ldr      x0, [x21, #0x80]
006591C1C  b        #0x6591c50 ; 
006591C20  ldr      x4, [x3, #0x60]
006591C24  mov      x0, x21
006591C28  mov      x1, x20
006591C2C  mov      x2, x19
006591C30  ldp      x20, x19, [sp, #0x30]
006591C34  ldp      x22, x21, [sp, #0x20]
006591C38  ldp      x24, x23, [sp, #0x10]
006591C3C  ldp      x30, x25, [sp], #0x40
006591C40  br       x4
006591C44  ldr      x8, [x1, #0x60]
006591C48  mov      x0, x21
006591C4C  blr      x8
006591C50  cbz      x0, #0x6591d84
006591C54  mov      w1, #4
006591C58  mov      x2, xzr
006591C5C  bl       #0x69fcc24 ; HotFix.BattleLogic.BattleWorldContext$$CheckBattleFlag
006591C60  tbnz     w0, #0, #0x6591d50
006591C64  cbz      x19, #0x6591d84
006591C68  ldr      w8, [x19, #0x62c]
006591C6C  cmp      w8, #1
006591C70  b.lt     #0x6591d50
006591C74  cbz      x20, #0x6591d84
006591C78  adrp     x8, #0x8ee6000
006591C7C  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006591C80  ldr      x1, [x8]
006591C84  ldrb     w8, [x1, #0x53]
006591C88  tbnz     w8, #5, #0x6591c94
006591C8C  ldr      x22, [x20, #0x38]
006591C90  b        #0x6591ca4 ; 
006591C94  ldr      x8, [x1, #0x60]
006591C98  mov      x0, x20
006591C9C  blr      x8
006591CA0  mov      x22, x0
006591CA4  cbz      x22, #0x6591d84
006591CA8  adrp     x25, #0x9591000
006591CAC  ldrb     w8, [x25, #0xa8f]
006591CB0  cbnz     w8, #0x6591cc8
006591CB4  adrp     x0, #0x8ee6000
006591CB8  ldr      x0, [x0, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
006591CBC  bl       #0x382bd14 ; 
006591CC0  mov      w8, #1
006591CC4  strb     w8, [x25, #0xa8f]
006591CC8  adrp     x8, #0x8ee6000
006591CCC  ldr      x8, [x8, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
006591CD0  ldr      x2, [x8]
006591CD4  ldrb     w8, [x2, #0x53]
006591CD8  tbnz     w8, #5, #0x6591ce8
006591CDC  ldrb     w8, [x22, #0x221]
006591CE0  tbz      w8, #0, #0x6591cfc
006591CE4  b        #0x6591d50 ; 
006591CE8  ldr      x8, [x2, #0x60]
006591CEC  mov      w1, #8
006591CF0  mov      x0, x22
006591CF4  blr      x8
006591CF8  tbnz     w0, #0, #0x6591d50
006591CFC  ldrb     w8, [x23, #0x286]
006591D00  cbnz     w8, #0x6591d18
006591D04  adrp     x0, #0x8f07000
006591D08  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006591D0C  bl       #0x382bd14 ; 
006591D10  mov      w8, #1
006591D14  strb     w8, [x23, #0x286]
006591D18  ldr      x1, [x24]
006591D1C  ldrb     w8, [x1, #0x53]
006591D20  tbnz     w8, #5, #0x6591d2c
006591D24  ldr      x0, [x21, #0x80]
006591D28  b        #0x6591d38 ; 
006591D2C  ldr      x8, [x1, #0x60]
006591D30  mov      x0, x21
006591D34  blr      x8
006591D38  cbz      x0, #0x6591d84
006591D3C  ldr      x8, [x0, #0x128]
006591D40  ldr      x9, [x19, #0x630]
006591D44  sub      x8, x8, x9
006591D48  cmp      x8, #0x10, lsl #12
006591D4C  b.gt     #0x6591d64
006591D50  ldp      x20, x19, [sp, #0x30]
006591D54  ldp      x22, x21, [sp, #0x20]
006591D58  ldp      x24, x23, [sp, #0x10]
006591D5C  ldp      x30, x25, [sp], #0x40
006591D60  ret      
006591D64  mov      x0, x21
006591D68  mov      x1, x20
006591D6C  mov      x2, x19
006591D70  ldp      x20, x19, [sp, #0x30]
006591D74  ldp      x22, x21, [sp, #0x20]
006591D78  ldp      x24, x23, [sp, #0x10]
006591D7C  ldp      x30, x25, [sp], #0x40
006591D80  b        #0x6591d88 ; HotFix.BattleLogic.BattleManager$$CacheNpcCollider
006591D84  bl       #0x382bfb8 ; 

