; HotFix.BattleLogic.EntityCharacter$$InitCharacterComponent
; RVA 0x67DA314; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067DA314  stp      x30, x21, [sp, #-0x20]!
0067DA318  stp      x20, x19, [sp, #0x10]
0067DA31C  adrp     x20, #0x959b000
0067DA320  adrp     x21, #0x8f1e000
0067DA324  ldrb     w8, [x20, #0x1e4]
0067DA328  ldr      x21, [x21, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitCharacterComponent()
0067DA32C  mov      x19, x0
0067DA330  tbnz     w8, #0, #0x67da3b4
0067DA334  adrp     x0, #0x8f1e000
0067DA338  ldr      x0, [x0, #0x8c8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentBuff>()
0067DA33C  bl       #0x382bd14 ; 
0067DA340  adrp     x0, #0x8f1e000
0067DA344  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentCeaseFireLaserTracker>()
0067DA348  bl       #0x382bd14 ; 
0067DA34C  adrp     x0, #0x8f1e000
0067DA350  ldr      x0, [x0, #0x8d8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentCollider>()
0067DA354  bl       #0x382bd14 ; 
0067DA358  adrp     x0, #0x8f1e000
0067DA35C  ldr      x0, [x0, #0x8e0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentDeath>()
0067DA360  bl       #0x382bd14 ; 
0067DA364  adrp     x0, #0x8f1e000
0067DA368  ldr      x0, [x0, #0x8e8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentOnHit>()
0067DA36C  bl       #0x382bd14 ; 
0067DA370  adrp     x0, #0x8f1e000
0067DA374  ldr      x0, [x0, #0x8f0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentScaleAni>()
0067DA378  bl       #0x382bd14 ; 
0067DA37C  adrp     x0, #0x8f1e000
0067DA380  ldr      x0, [x0, #0x8f8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentTransform>()
0067DA384  bl       #0x382bd14 ; 
0067DA388  adrp     x0, #0x8f1e000
0067DA38C  ldr      x0, [x0, #0x900] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentTrigger>()
0067DA390  bl       #0x382bd14 ; 
0067DA394  adrp     x0, #0x8ee6000
0067DA398  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067DA39C  bl       #0x382bd14 ; 
0067DA3A0  adrp     x0, #0x8f1e000
0067DA3A4  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitCharacterComponent()
0067DA3A8  bl       #0x382bd14 ; 
0067DA3AC  mov      w8, #1
0067DA3B0  strb     w8, [x20, #0x1e4]
0067DA3B4  ldr      x1, [x21]
0067DA3B8  ldrb     w8, [x1, #0x53]
0067DA3BC  tbnz     w8, #5, #0x67da420
0067DA3C0  adrp     x8, #0x8f1e000
0067DA3C4  ldr      x8, [x8, #0x8f8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentTransform>()
0067DA3C8  mov      x0, x19
0067DA3CC  ldr      x1, [x8]
0067DA3D0  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA3D4  adrp     x21, #0x959b000
0067DA3D8  ldrb     w8, [x21, #0x394]
0067DA3DC  mov      x20, x0
0067DA3E0  cbnz     w8, #0x67da3f8
0067DA3E4  adrp     x0, #0x8f1e000
0067DA3E8  ldr      x0, [x0, #0x588] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_Transform()
0067DA3EC  bl       #0x382bd14 ; 
0067DA3F0  mov      w8, #1
0067DA3F4  strb     w8, [x21, #0x394]
0067DA3F8  adrp     x8, #0x8f1e000
0067DA3FC  ldr      x8, [x8, #0x588] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_Transform()
0067DA400  ldr      x2, [x8]
0067DA404  ldrb     w8, [x2, #0x53]
0067DA408  tbnz     w8, #5, #0x67da434
0067DA40C  add      x0, x19, #0x118
0067DA410  mov      x1, x20
0067DA414  str      x20, [x19, #0x118]
0067DA418  bl       #0x382bcb8 ; 
0067DA41C  b        #0x67da444 ; 
0067DA420  ldr      x2, [x1, #0x60]
0067DA424  mov      x0, x19
0067DA428  ldp      x20, x19, [sp, #0x10]
0067DA42C  ldp      x30, x21, [sp], #0x20
0067DA430  br       x2
0067DA434  ldr      x8, [x2, #0x60]
0067DA438  mov      x0, x19
0067DA43C  mov      x1, x20
0067DA440  blr      x8
0067DA444  adrp     x8, #0x8f1e000
0067DA448  ldr      x8, [x8, #0x8d8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentCollider>()
0067DA44C  mov      x0, x19
0067DA450  ldr      x1, [x8]
0067DA454  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA458  adrp     x8, #0x8ee6000
0067DA45C  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067DA460  ldr      x1, [x8]
0067DA464  ldrb     w8, [x1, #0x53]
0067DA468  tbnz     w8, #5, #0x67da474
0067DA46C  ldr      x0, [x19, #0x38]
0067DA470  b        #0x67da480 ; 
0067DA474  ldr      x8, [x1, #0x60]
0067DA478  mov      x0, x19
0067DA47C  blr      x8
0067DA480  cbz      x0, #0x67da530
0067DA484  mov      x1, xzr
0067DA488  bl       #0x6804d8c ; 
0067DA48C  tbnz     w0, #0, #0x67da4ec
0067DA490  adrp     x8, #0x8f1e000
0067DA494  ldr      x8, [x8, #0x8e8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentOnHit>()
0067DA498  mov      x0, x19
0067DA49C  ldr      x1, [x8]
0067DA4A0  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA4A4  mov      x1, x0
0067DA4A8  add      x0, x19, #0x158
0067DA4AC  str      x1, [x19, #0x158]
0067DA4B0  bl       #0x382bcb8 ; 
0067DA4B4  adrp     x8, #0x8f1e000
0067DA4B8  ldr      x8, [x8, #0x8e0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentDeath>()
0067DA4BC  mov      x0, x19
0067DA4C0  ldr      x1, [x8]
0067DA4C4  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA4C8  adrp     x8, #0x8f1e000
0067DA4CC  ldr      x8, [x8, #0x900] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentTrigger>()
0067DA4D0  mov      x0, x19
0067DA4D4  ldr      x1, [x8]
0067DA4D8  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA4DC  mov      x1, x0
0067DA4E0  add      x0, x19, #0x150
0067DA4E4  str      x1, [x19, #0x150]
0067DA4E8  bl       #0x382bcb8 ; 
0067DA4EC  adrp     x8, #0x8f1e000
0067DA4F0  ldr      x8, [x8, #0x8c8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentBuff>()
0067DA4F4  mov      x0, x19
0067DA4F8  ldr      x1, [x8]
0067DA4FC  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA500  adrp     x8, #0x8f1e000
0067DA504  ldr      x8, [x8, #0x8f0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentScaleAni>()
0067DA508  mov      x0, x19
0067DA50C  ldr      x1, [x8]
0067DA510  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA514  adrp     x8, #0x8f1e000
0067DA518  ldr      x8, [x8, #0x8d0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentCeaseFireLaserTracker>()
0067DA51C  mov      x0, x19
0067DA520  ldp      x20, x19, [sp, #0x10]
0067DA524  ldr      x1, [x8]
0067DA528  ldp      x30, x21, [sp], #0x20
0067DA52C  b        #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0067DA530  bl       #0x382bfb8 ; 

