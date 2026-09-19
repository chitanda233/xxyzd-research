; HotFix.BattleLogic.BattleData$$InitFromSaveData
; RVA 0x658E3D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658E3D0  str      x30, [sp, #-0x30]!
00658E3D4  stp      x22, x21, [sp, #0x10]
00658E3D8  stp      x20, x19, [sp, #0x20]
00658E3DC  adrp     x21, #0x9599000
00658E3E0  adrp     x22, #0x8f08000
00658E3E4  ldrb     w8, [x21, #0x1fd]
00658E3E8  ldr      x22, [x22, #0x610] ; GLOBAL Method$HotFix.BattleLogic.BattleData.InitFromSaveData() @ 0x923c368
00658E3EC  mov      x19, x1
00658E3F0  mov      x20, x0
00658E3F4  tbnz     w8, #0, #0x658e40c
00658E3F8  adrp     x0, #0x8f08000
00658E3FC  ldr      x0, [x0, #0x610] ; GLOBAL Method$HotFix.BattleLogic.BattleData.InitFromSaveData() @ 0x923c368
00658E400  bl       #0x382bd14 ; 
00658E404  mov      w8, #1
00658E408  strb     w8, [x21, #0x1fd]
00658E40C  ldr      x2, [x22]
00658E410  ldrb     w8, [x2, #0x53]
00658E414  tbnz     w8, #5, #0x658e474
00658E418  cbz      x19, #0x658e600
00658E41C  ldr      w1, [x19, #0x38]
00658E420  mov      x0, x20
00658E424  bl       #0x658e1c4 ; HotFix.BattleLogic.BattleData$$set_Gold
00658E428  adrp     x22, #0x9599000
00658E42C  ldrb     w8, [x22, #0x2aa]
00658E430  ldr      x21, [x19, #0x78]
00658E434  cbnz     w8, #0x658e44c
00658E438  adrp     x0, #0x8f08000
00658E43C  ldr      x0, [x0, #0x5c0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_WaveGold() @ 0x923c3f8
00658E440  bl       #0x382bd14 ; 
00658E444  mov      w8, #1
00658E448  strb     w8, [x22, #0x2aa]
00658E44C  adrp     x8, #0x8f08000
00658E450  ldr      x8, [x8, #0x5c0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_WaveGold() @ 0x923c3f8
00658E454  ldr      x2, [x8]
00658E458  ldrb     w8, [x2, #0x53]
00658E45C  tbnz     w8, #5, #0x658e490
00658E460  mov      x0, x20
00658E464  str      x21, [x0, #0xa8]!
00658E468  mov      x1, x21
00658E46C  bl       #0x382bcb8 ; 
00658E470  b        #0x658e4a0 ; 
00658E474  ldr      x3, [x2, #0x60]
00658E478  mov      x0, x20
00658E47C  mov      x1, x19
00658E480  ldp      x20, x19, [sp, #0x20]
00658E484  ldp      x22, x21, [sp, #0x10]
00658E488  ldr      x30, [sp], #0x30
00658E48C  br       x3
00658E490  ldr      x8, [x2, #0x60]
00658E494  mov      x0, x20
00658E498  mov      x1, x21
00658E49C  blr      x8
00658E4A0  adrp     x22, #0x9599000
00658E4A4  ldrb     w8, [x22, #0x2a8]
00658E4A8  ldr      w21, [x19, #0x80]
00658E4AC  cbnz     w8, #0x658e4c4
00658E4B0  adrp     x0, #0x8f08000
00658E4B4  ldr      x0, [x0, #0x5b0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_DropGold() @ 0x923c3c8
00658E4B8  bl       #0x382bd14 ; 
00658E4BC  mov      w8, #1
00658E4C0  strb     w8, [x22, #0x2a8]
00658E4C4  adrp     x8, #0x8f08000
00658E4C8  ldr      x8, [x8, #0x5b0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_DropGold() @ 0x923c3c8
00658E4CC  ldr      x2, [x8]
00658E4D0  ldrb     w8, [x2, #0x53]
00658E4D4  tbnz     w8, #5, #0x658e4e0
00658E4D8  str      w21, [x20, #0xa4]
00658E4DC  b        #0x658e4f0 ; 
00658E4E0  ldr      x8, [x2, #0x60]
00658E4E4  mov      x0, x20
00658E4E8  mov      w1, w21
00658E4EC  blr      x8
00658E4F0  ldr      w1, [x19, #0x14]
00658E4F4  mov      x0, x20
00658E4F8  bl       #0x658dfc0 ; HotFix.BattleLogic.BattleData$$set_KillCount
00658E4FC  ldr      w8, [x19, #0x18]
00658E500  adrp     x22, #0x9599000
00658E504  str      w8, [x20, #0x30]
00658E508  ldr      w8, [x19, #0x84]
00658E50C  str      w8, [x20, #0x9c]
00658E510  ldr      q0, [x19, #0x20]
00658E514  ext      v1.16b, v0.16b, v0.16b, #4
00658E518  uzp2     v0.4s, v0.4s, v1.4s
00658E51C  ext      v0.16b, v1.16b, v0.16b, #0xc
00658E520  stur     q0, [x20, #0x34]
00658E524  ldr      d0, [x19, #0x30]
00658E528  stur     d0, [x20, #0x44]
00658E52C  ldrb     w8, [x22, #0x2ae]
00658E530  ldr      w21, [x19, #0x1c]
00658E534  cbnz     w8, #0x658e54c
00658E538  adrp     x0, #0x8f08000
00658E53C  ldr      x0, [x0, #0x5e0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_RealKillCount() @ 0x923c3e8
00658E540  bl       #0x382bd14 ; 
00658E544  mov      w8, #1
00658E548  strb     w8, [x22, #0x2ae]
00658E54C  adrp     x8, #0x8f08000
00658E550  ldr      x8, [x8, #0x5e0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_RealKillCount() @ 0x923c3e8
00658E554  ldr      x2, [x8]
00658E558  ldrb     w8, [x2, #0x53]
00658E55C  tbnz     w8, #5, #0x658e568
00658E560  str      w21, [x20, #0x98]
00658E564  b        #0x658e578 ; 
00658E568  ldr      x8, [x2, #0x60]
00658E56C  mov      x0, x20
00658E570  mov      w1, w21
00658E574  blr      x8
00658E578  ldr      w1, [x19, #0x3c]
00658E57C  mov      x0, x20
00658E580  bl       #0x658dec4 ; HotFix.BattleLogic.BattleData$$set_MissionIndex
00658E584  ldr      x8, [x19, #0x60]
00658E588  cbz      x8, #0x658e594
00658E58C  ldr      w21, [x8, #0x18]
00658E590  b        #0x658e598 ; 
00658E594  mov      w21, wzr
00658E598  str      w21, [x20, #0x8c]
00658E59C  adrp     x22, #0x9599000
00658E5A0  ldrb     w8, [x22, #0x2b0]
00658E5A4  cbnz     w8, #0x658e5bc
00658E5A8  adrp     x0, #0x8f08000
00658E5AC  ldr      x0, [x0, #0x600] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_SkillCount() @ 0x923c3f0
00658E5B0  bl       #0x382bd14 ; 
00658E5B4  mov      w8, #1
00658E5B8  strb     w8, [x22, #0x2b0]
00658E5BC  adrp     x8, #0x8f08000
00658E5C0  ldr      x8, [x8, #0x600] ; GLOBAL Method$HotFix.BattleLogic.BattleData.set_SkillCount() @ 0x923c3f0
00658E5C4  ldr      x2, [x8]
00658E5C8  ldrb     w8, [x2, #0x53]
00658E5CC  tbnz     w8, #5, #0x658e5d8
00658E5D0  str      w21, [x20, #0x8c]
00658E5D4  b        #0x658e5e8 ; 
00658E5D8  ldr      x8, [x2, #0x60]
00658E5DC  mov      x0, x20
00658E5E0  mov      w1, w21
00658E5E4  blr      x8
00658E5E8  ldr      w8, [x19, #0x88]
00658E5EC  ldp      x22, x21, [sp, #0x10]
00658E5F0  str      w8, [x20, #0xa0]
00658E5F4  ldp      x20, x19, [sp, #0x20]
00658E5F8  ldr      x30, [sp], #0x30
00658E5FC  ret      
00658E600  bl       #0x382bfb8 ; 

