; HotFix.BattleLogic.CharacterComponentDeath$$OnDeath
; RVA 0x669E050; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00669E050  sub      sp, sp, #0x150
00669E054  stp      x29, x30, [sp, #0xf0]
00669E058  stp      x28, x27, [sp, #0x100]
00669E05C  stp      x26, x25, [sp, #0x110]
00669E060  stp      x24, x23, [sp, #0x120]
00669E064  stp      x22, x21, [sp, #0x130]
00669E068  stp      x20, x19, [sp, #0x140]
00669E06C  mrs      x24, tpidr_el0
00669E070  ldr      x8, [x24, #0x28]
00669E074  adrp     x20, #0x959a000
00669E078  adrp     x21, #0x8f11000
00669E07C  mov      x22, x1
00669E080  str      x8, [sp, #0xe8]
00669E084  ldrb     w8, [x20, #0xbb]
00669E088  ldr      x21, [x21, #0x90] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentDeath.OnDeath() @ 0x924c9c0
00669E08C  mov      x19, x0
00669E090  tbnz     w8, #0, #0x669e0fc
00669E094  adrp     x0, #0x8ec1000
00669E098  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
00669E09C  bl       #0x382bd14 ; 
00669E0A0  adrp     x0, #0x8f11000
00669E0A4  ldr      x0, [x0, #0x90] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentDeath.OnDeath() @ 0x924c9c0
00669E0A8  bl       #0x382bd14 ; 
00669E0AC  adrp     x0, #0x8f11000
00669E0B0  ldr      x0, [x0, #0x98] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<CharacterComponentAI>() @ 0x9210008
00669E0B4  bl       #0x382bd14 ; 
00669E0B8  adrp     x0, #0x8ee6000
00669E0BC  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00669E0C0  bl       #0x382bd14 ; 
00669E0C4  adrp     x0, #0x8ee6000
00669E0C8  ldr      x0, [x0, #0x608] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Entity() @ 0x9210250
00669E0CC  bl       #0x382bd14 ; 
00669E0D0  adrp     x0, #0x8ee6000
00669E0D4  ldr      x0, [x0, #0x108] ; GLOBAL Method$HotFix.BattleLogic.EntityManager.GetEntity<EntityCharacter>() @ 0x9263bc0
00669E0D8  bl       #0x382bd14 ; 
00669E0DC  adrp     x0, #0x8f11000
00669E0E0  ldr      x0, [x0, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentDeath.<>c__DisplayClass11_0.<OnDeath>b__0() @ 0x92d41e0
00669E0E4  bl       #0x382bd14 ; 
00669E0E8  adrp     x0, #0x8f11000
00669E0EC  ldr      x0, [x0, #0xa8] ; GLOBAL HotFix.BattleLogic.CharacterComponentDeath.<>c__DisplayClass11_0_TypeInfo @ 0x91f7348
00669E0F0  bl       #0x382bd14 ; 
00669E0F4  mov      w8, #1
00669E0F8  strb     w8, [x20, #0xbb]
00669E0FC  ldr      x2, [x21]
00669E100  ldrb     w8, [x2, #0x53]
00669E104  tbnz     w8, #5, #0x669e168
00669E108  adrp     x8, #0x8f11000
00669E10C  ldr      x8, [x8, #0xa8] ; GLOBAL HotFix.BattleLogic.CharacterComponentDeath.<>c__DisplayClass11_0_TypeInfo @ 0x91f7348
00669E110  ldr      x0, [x8]
00669E114  bl       #0x382bfa0 ; 
00669E118  mov      x1, xzr
00669E11C  mov      x21, x0
00669E120  bl       #0x669f298 ; HotFix.BattleLogic.CharacterComponentDeath.<>c__DisplayClass11_0$$.ctor
00669E124  cbz      x21, #0x669eca0
00669E128  mov      x0, x21
00669E12C  str      x19, [x0, #0x10]!
00669E130  mov      x1, x19
00669E134  bl       #0x382bcb8 ; 
00669E138  mov      x20, x21
00669E13C  str      x22, [x20, #0x18]!
00669E140  mov      x0, x20
00669E144  mov      x1, x22
00669E148  bl       #0x382bcb8 ; 
00669E14C  adrp     x25, #0x8ee6000
00669E150  ldr      x25, [x25, #0x608] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Entity() @ 0x9210250
00669E154  ldr      x1, [x25]
00669E158  ldrb     w8, [x1, #0x53]
00669E15C  tbnz     w8, #5, #0x669e17c
00669E160  ldr      x0, [x19, #0x30]
00669E164  b        #0x669e188 ; 
00669E168  ldr      x8, [x2, #0x60]
00669E16C  mov      x0, x19
00669E170  mov      x1, x22
00669E174  blr      x8
00669E178  b        #0x669ec70 ; 
00669E17C  ldr      x8, [x1, #0x60]
00669E180  mov      x0, x19
00669E184  blr      x8
00669E188  cbz      x0, #0x669eca0
00669E18C  adrp     x8, #0x8f11000
00669E190  ldr      x8, [x8, #0x98] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<CharacterComponentAI>() @ 0x9210008
00669E194  ldr      x1, [x8]
00669E198  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00669E19C  cbz      x0, #0x669ec70
00669E1A0  bl       #0x6692dcc ; HotFix.BattleLogic.CharacterComponentAI$$OnDeathForAI
00669E1A4  ldr      x22, [x20]
00669E1A8  cbz      x22, #0x669eca0
00669E1AC  adrp     x23, #0x9599000
00669E1B0  ldrb     w8, [x23, #0x2b8]
00669E1B4  cbnz     w8, #0x669e1cc
00669E1B8  adrp     x0, #0x8f08000
00669E1BC  ldr      x0, [x0, #0xa70] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_AttackerType() @ 0x92b1868
00669E1C0  bl       #0x382bd14 ; 
00669E1C4  mov      w8, #1
00669E1C8  strb     w8, [x23, #0x2b8]
00669E1CC  adrp     x26, #0x8f08000
00669E1D0  ldr      x26, [x26, #0xa70] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_AttackerType() @ 0x92b1868
00669E1D4  ldr      x1, [x26]
00669E1D8  ldrb     w8, [x1, #0x53]
00669E1DC  tbnz     w8, #5, #0x669e1e8
00669E1E0  ldr      w0, [x22, #0x24]
00669E1E4  b        #0x669e1f4 ; 
00669E1E8  ldr      x8, [x1, #0x60]
00669E1EC  mov      x0, x22
00669E1F0  blr      x8
00669E1F4  cmp      w0, #6
00669E1F8  b.ne     #0x669e208
00669E1FC  mov      x0, x19
00669E200  bl       #0x669ed20 ; HotFix.BattleLogic.CharacterComponentDeath$$CreateExplodeDeath
00669E204  b        #0x669e258 ; 
00669E208  ldr      x22, [x20]
00669E20C  cbz      x22, #0x669eca0
00669E210  ldrb     w8, [x23, #0x2b8]
00669E214  cbnz     w8, #0x669e22c
00669E218  adrp     x0, #0x8f08000
00669E21C  ldr      x0, [x0, #0xa70] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_AttackerType() @ 0x92b1868
00669E220  bl       #0x382bd14 ; 
00669E224  mov      w8, #1
00669E228  strb     w8, [x23, #0x2b8]
00669E22C  ldr      x1, [x26]
00669E230  ldrb     w8, [x1, #0x53]
00669E234  tbnz     w8, #5, #0x669e240
00669E238  ldr      w1, [x22, #0x24]
00669E23C  b        #0x669e250 ; 
00669E240  ldr      x8, [x1, #0x60]
00669E244  mov      x0, x22
00669E248  blr      x8
00669E24C  mov      w1, w0
00669E250  mov      x0, x19
00669E254  bl       #0x669d510 ; HotFix.BattleLogic.CharacterComponentDeath$$CreateDeathByTable
00669E258  ldr      x1, [x25]
00669E25C  ldrb     w8, [x1, #0x53]
00669E260  tbnz     w8, #5, #0x669e26c
00669E264  ldr      x0, [x19, #0x30]
00669E268  b        #0x669e278 ; 
00669E26C  ldr      x8, [x1, #0x60]
00669E270  mov      x0, x19
00669E274  blr      x8
00669E278  cbz      x0, #0x669eca0
00669E27C  adrp     x26, #0x8ee6000
00669E280  ldr      x26, [x26, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00669E284  ldr      x1, [x26]
00669E288  ldrb     w8, [x1, #0x53]
00669E28C  tbnz     w8, #5, #0x669e298
00669E290  ldr      x22, [x0, #0x38]
00669E294  b        #0x669e2a4 ; 
00669E298  ldr      x8, [x1, #0x60]
00669E29C  blr      x8
00669E2A0  mov      x22, x0
00669E2A4  cbz      x22, #0x669eca0
00669E2A8  adrp     x23, #0x9599000
00669E2AC  ldrb     w8, [x23, #0x4d2]
00669E2B0  cbnz     w8, #0x669e2c8
00669E2B4  adrp     x0, #0x8f09000
00669E2B8  ldr      x0, [x0, #0x6f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsMonster() @ 0x92633a0
00669E2BC  bl       #0x382bd14 ; 
00669E2C0  mov      w8, #1
00669E2C4  strb     w8, [x23, #0x4d2]
00669E2C8  adrp     x8, #0x8f09000
00669E2CC  ldr      x8, [x8, #0x6f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsMonster() @ 0x92633a0
00669E2D0  ldr      x1, [x8]
00669E2D4  ldrb     w8, [x1, #0x53]
00669E2D8  tbnz     w8, #5, #0x669e34c
00669E2DC  adrp     x27, #0x9591000
00669E2E0  ldrb     w8, [x27, #0xa73]
00669E2E4  cbnz     w8, #0x669e2fc
00669E2E8  adrp     x0, #0x8ee6000
00669E2EC  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType() @ 0x9263340
00669E2F0  bl       #0x382bd14 ; 
00669E2F4  mov      w8, #1
00669E2F8  strb     w8, [x27, #0xa73]
00669E2FC  adrp     x28, #0x8ee6000
00669E300  ldr      x28, [x28, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType() @ 0x9263340
00669E304  ldr      x1, [x28]
00669E308  ldrb     w8, [x1, #0x53]
00669E30C  tbnz     w8, #5, #0x669e360
00669E310  adrp     x23, #0x9591000
00669E314  ldrb     w8, [x23, #0xa74]
00669E318  cbnz     w8, #0x669e330
00669E31C  adrp     x0, #0x8ee6000
00669E320  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
00669E324  bl       #0x382bd14 ; 
00669E328  mov      w8, #1
00669E32C  strb     w8, [x23, #0xa74]
00669E330  adrp     x8, #0x8ee6000
00669E334  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
00669E338  ldr      x1, [x8]
00669E33C  ldrb     w8, [x1, #0x53]
00669E340  tbnz     w8, #5, #0x669e36c
00669E344  ldr      x23, [x22, #0x170]
00669E348  b        #0x669e37c ; 
00669E34C  ldr      x8, [x1, #0x60]
00669E350  mov      x0, x22
00669E354  blr      x8
00669E358  tbnz     w0, #0, #0x669e56c
00669E35C  b        #0x669ea28 ; 
00669E360  ldr      x8, [x1, #0x60]
00669E364  mov      x0, x22
00669E368  b        #0x669e3c4 ; 
00669E36C  ldr      x8, [x1, #0x60]
00669E370  mov      x0, x22
00669E374  blr      x8
00669E378  mov      x23, x0
00669E37C  cbz      x23, #0x669eca0
00669E380  adrp     x29, #0x9591000
00669E384  ldrb     w8, [x29, #0xa75]
00669E388  cbnz     w8, #0x669e3a0
00669E38C  adrp     x0, #0x8ee6000
00669E390  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
00669E394  bl       #0x382bd14 ; 
00669E398  mov      w8, #1
00669E39C  strb     w8, [x29, #0xa75]
00669E3A0  adrp     x8, #0x8ee6000
00669E3A4  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
00669E3A8  ldr      x1, [x8]
00669E3AC  ldrb     w8, [x1, #0x53]
00669E3B0  tbnz     w8, #5, #0x669e3bc
00669E3B4  ldr      w0, [x23, #0x24]
00669E3B8  b        #0x669e3c8 ; 
00669E3BC  ldr      x8, [x1, #0x60]
00669E3C0  mov      x0, x23
00669E3C4  blr      x8
00669E3C8  cmp      w0, #2
00669E3CC  b.eq     #0x669e56c
00669E3D0  ldrb     w8, [x27, #0xa73]
00669E3D4  cbnz     w8, #0x669e3ec
00669E3D8  adrp     x0, #0x8ee6000
00669E3DC  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType() @ 0x9263340
00669E3E0  bl       #0x382bd14 ; 
00669E3E4  mov      w8, #1
00669E3E8  strb     w8, [x27, #0xa73]
00669E3EC  ldr      x1, [x28]
00669E3F0  ldrb     w8, [x1, #0x53]
00669E3F4  tbnz     w8, #5, #0x669e434
00669E3F8  adrp     x23, #0x9591000
00669E3FC  ldrb     w8, [x23, #0xa74]
00669E400  cbnz     w8, #0x669e418
00669E404  adrp     x0, #0x8ee6000
00669E408  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
00669E40C  bl       #0x382bd14 ; 
00669E410  mov      w8, #1
00669E414  strb     w8, [x23, #0xa74]
00669E418  adrp     x8, #0x8ee6000
00669E41C  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
00669E420  ldr      x1, [x8]
00669E424  ldrb     w8, [x1, #0x53]
00669E428  tbnz     w8, #5, #0x669e440
00669E42C  ldr      x23, [x22, #0x170]
00669E430  b        #0x669e450 ; 
00669E434  ldr      x8, [x1, #0x60]
00669E438  mov      x0, x22
00669E43C  b        #0x669e498 ; 
00669E440  ldr      x8, [x1, #0x60]
00669E444  mov      x0, x22
00669E448  blr      x8
00669E44C  mov      x23, x0
00669E450  cbz      x23, #0x669eca0
00669E454  adrp     x29, #0x9591000
00669E458  ldrb     w8, [x29, #0xa75]
00669E45C  cbnz     w8, #0x669e474
00669E460  adrp     x0, #0x8ee6000
00669E464  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
00669E468  bl       #0x382bd14 ; 
00669E46C  mov      w8, #1
00669E470  strb     w8, [x29, #0xa75]
00669E474  adrp     x8, #0x8ee6000
00669E478  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
00669E47C  ldr      x1, [x8]
00669E480  ldrb     w8, [x1, #0x53]
00669E484  tbnz     w8, #5, #0x669e490
00669E488  ldr      w0, [x23, #0x24]
00669E48C  b        #0x669e49c ; 
00669E490  ldr      x8, [x1, #0x60]
00669E494  mov      x0, x23
00669E498  blr      x8
00669E49C  cmp      w0, #0xc9
00669E4A0  b.eq     #0x669e56c
00669E4A4  ldrb     w8, [x27, #0xa73]
00669E4A8  cbnz     w8, #0x669e4c0
00669E4AC  adrp     x0, #0x8ee6000
00669E4B0  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType() @ 0x9263340
00669E4B4  bl       #0x382bd14 ; 
00669E4B8  mov      w8, #1
00669E4BC  strb     w8, [x27, #0xa73]
00669E4C0  ldr      x1, [x28]
00669E4C4  ldrb     w8, [x1, #0x53]
00669E4C8  tbnz     w8, #5, #0x669e558
00669E4CC  adrp     x23, #0x9591000
00669E4D0  ldrb     w8, [x23, #0xa74]
00669E4D4  cbnz     w8, #0x669e4ec
00669E4D8  adrp     x0, #0x8ee6000
00669E4DC  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
00669E4E0  bl       #0x382bd14 ; 
00669E4E4  mov      w8, #1
00669E4E8  strb     w8, [x23, #0xa74]
00669E4EC  adrp     x8, #0x8ee6000
00669E4F0  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
00669E4F4  ldr      x1, [x8]
00669E4F8  ldrb     w8, [x1, #0x53]
00669E4FC  tbnz     w8, #5, #0x669e508
00669E500  ldr      x22, [x22, #0x170]
00669E504  b        #0x669e518 ; 
00669E508  ldr      x8, [x1, #0x60]
00669E50C  mov      x0, x22
00669E510  blr      x8
00669E514  mov      x22, x0
00669E518  cbz      x22, #0x669eca0
00669E51C  adrp     x23, #0x9591000
00669E520  ldrb     w8, [x23, #0xa75]
00669E524  cbnz     w8, #0x669e53c
00669E528  adrp     x0, #0x8ee6000
00669E52C  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
00669E530  bl       #0x382bd14 ; 
00669E534  mov      w8, #1
00669E538  strb     w8, [x23, #0xa75]
00669E53C  adrp     x8, #0x8ee6000
00669E540  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
00669E544  ldr      x1, [x8]
00669E548  ldrb     w8, [x1, #0x53]
00669E54C  tbnz     w8, #5, #0x669e558
00669E550  ldr      w0, [x22, #0x24]
00669E554  b        #0x669e564 ; 
00669E558  ldr      x8, [x1, #0x60]
00669E55C  mov      x0, x22
00669E560  blr      x8
00669E564  cmp      w0, #3
00669E568  b.ne     #0x669ea28
00669E56C  ldr      x1, [x25]
00669E570  ldrb     w8, [x1, #0x53]
00669E574  tbnz     w8, #5, #0x669e580
00669E578  ldr      x0, [x19, #0x30]
00669E57C  b        #0x669e58c ; 
00669E580  ldr      x8, [x1, #0x60]
00669E584  mov      x0, x19
00669E588  blr      x8
00669E58C  cbz      x0, #0x669eca0
00669E590  ldr      x1, [x26]
00669E594  ldrb     w8, [x1, #0x53]
00669E598  tbnz     w8, #5, #0x669e5a4
00669E59C  ldr      x22, [x0, #0x38]
00669E5A0  b        #0x669e5b0 ; 
00669E5A4  ldr      x8, [x1, #0x60]
00669E5A8  blr      x8
00669E5AC  mov      x22, x0
00669E5B0  cbz      x22, #0x669eca0
00669E5B4  adrp     x23, #0x9591000
00669E5B8  ldrb     w8, [x23, #0xa92]
00669E5BC  cbnz     w8, #0x669e5d4
00669E5C0  adrp     x0, #0x8ee6000
00669E5C4  ldr      x0, [x0, #0x3f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Camp() @ 0x9263320
00669E5C8  bl       #0x382bd14 ; 
00669E5CC  mov      w8, #1
00669E5D0  strb     w8, [x23, #0xa92]
00669E5D4  adrp     x8, #0x8ee6000
00669E5D8  ldr      x8, [x8, #0x3f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Camp() @ 0x9263320
00669E5DC  ldr      x1, [x8]
00669E5E0  ldrb     w8, [x1, #0x53]
00669E5E4  tbnz     w8, #5, #0x669e5f0
00669E5E8  ldr      w0, [x22, #0x150]
00669E5EC  b        #0x669e5fc ; 
00669E5F0  ldr      x8, [x1, #0x60]
00669E5F4  mov      x0, x22
00669E5F8  blr      x8
00669E5FC  cmp      w0, #2
00669E600  b.ne     #0x669ea28
00669E604  ldr      x1, [x25]
00669E608  ldrb     w8, [x1, #0x53]
00669E60C  tbnz     w8, #5, #0x669e618
00669E610  ldr      x0, [x19, #0x30]
00669E614  b        #0x669e624 ; 
00669E618  ldr      x8, [x1, #0x60]
00669E61C  mov      x0, x19
00669E620  blr      x8
00669E624  cbz      x0, #0x669eca0
00669E628  ldr      x1, [x26]
00669E62C  ldrb     w8, [x1, #0x53]
00669E630  tbnz     w8, #5, #0x669e63c
00669E634  ldr      x0, [x0, #0x38]
00669E638  b        #0x669e644 ; 
00669E63C  ldr      x8, [x1, #0x60]
00669E640  blr      x8
00669E644  cbz      x0, #0x669eca0
00669E648  ldrb     w8, [x0, #0x250]
00669E64C  cbnz     w8, #0x669e844
00669E650  adrp     x27, #0x9591000
00669E654  ldrb     w8, [x27, #0xa4b]
00669E658  cbnz     w8, #0x669e670
00669E65C  adrp     x0, #0x8ee5000
00669E660  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00669E664  bl       #0x382bd14 ; 
00669E668  mov      w8, #1
00669E66C  strb     w8, [x27, #0xa4b]
00669E670  adrp     x28, #0x8ee5000
00669E674  ldr      x28, [x28, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00669E678  ldr      x1, [x28]
00669E67C  ldrb     w8, [x1, #0x53]
00669E680  tbnz     w8, #5, #0x669e68c
00669E684  ldr      x22, [x19, #0x20]
00669E688  b        #0x669e69c ; 
00669E68C  ldr      x8, [x1, #0x60]
00669E690  mov      x0, x19
00669E694  blr      x8
00669E698  mov      x22, x0
00669E69C  cbz      x22, #0x669eca0
00669E6A0  adrp     x23, #0x9591000
00669E6A4  ldrb     w8, [x23, #0xa62]
00669E6A8  cbnz     w8, #0x669e6c0
00669E6AC  adrp     x0, #0x8ee6000
00669E6B0  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
00669E6B4  bl       #0x382bd14 ; 
00669E6B8  mov      w8, #1
00669E6BC  strb     w8, [x23, #0xa62]
00669E6C0  adrp     x8, #0x8ee6000
00669E6C4  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
00669E6C8  ldr      x1, [x8]
00669E6CC  ldrb     w8, [x1, #0x53]
00669E6D0  tbnz     w8, #5, #0x669e6dc
00669E6D4  ldr      x22, [x22, #0x1f8]
00669E6D8  b        #0x669e6ec ; 
00669E6DC  ldr      x8, [x1, #0x60]
00669E6E0  mov      x0, x22
00669E6E4  blr      x8
00669E6E8  mov      x22, x0
00669E6EC  ldr      x23, [x20]
00669E6F0  cbz      x23, #0x669eca0
00669E6F4  adrp     x29, #0x959a000
00669E6F8  ldrb     w8, [x29, #0x10f]
00669E6FC  cbnz     w8, #0x669e714
00669E700  adrp     x0, #0x8f11000
00669E704  ldr      x0, [x0, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_Hero() @ 0x92b1888
00669E708  bl       #0x382bd14 ; 
00669E70C  mov      w8, #1
00669E710  strb     w8, [x29, #0x10f]
00669E714  adrp     x8, #0x8f11000
00669E718  ldr      x8, [x8, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_Hero() @ 0x92b1888
00669E71C  ldr      x1, [x8]
00669E720  ldrb     w8, [x1, #0x53]
00669E724  tbnz     w8, #5, #0x669e730
00669E728  ldr      x1, [x23, #0x30]
00669E72C  b        #0x669e740 ; 
00669E730  ldr      x8, [x1, #0x60]
00669E734  mov      x0, x23
00669E738  blr      x8
00669E73C  mov      x1, x0
00669E740  cbz      x22, #0x669eca0
00669E744  adrp     x8, #0x8ee6000
00669E748  ldr      x8, [x8, #0x108] ; GLOBAL Method$HotFix.BattleLogic.EntityManager.GetEntity<EntityCharacter>() @ 0x9263bc0
00669E74C  mov      x0, x22
00669E750  ldr      x2, [x8]
00669E754  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
00669E758  ldrb     w8, [x27, #0xa4b]
00669E75C  mov      x22, x0
00669E760  cbnz     w8, #0x669e778
00669E764  adrp     x0, #0x8ee5000
00669E768  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00669E76C  bl       #0x382bd14 ; 
00669E770  mov      w8, #1
00669E774  strb     w8, [x27, #0xa4b]
00669E778  ldr      x1, [x28]
00669E77C  ldrb     w8, [x1, #0x53]
00669E780  tbnz     w8, #5, #0x669e78c
00669E784  ldr      x23, [x19, #0x20]
00669E788  b        #0x669e79c ; 
00669E78C  ldr      x8, [x1, #0x60]
00669E790  mov      x0, x19
00669E794  blr      x8
00669E798  mov      x23, x0
00669E79C  cbz      x23, #0x669eca0
00669E7A0  adrp     x27, #0x9599000
00669E7A4  ldrb     w8, [x27, #0x287]
00669E7A8  cbnz     w8, #0x669e7c0
00669E7AC  adrp     x0, #0x8f07000
00669E7B0  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00669E7B4  bl       #0x382bd14 ; 
00669E7B8  mov      w8, #1
00669E7BC  strb     w8, [x27, #0x287]
00669E7C0  adrp     x8, #0x8f07000
00669E7C4  ldr      x8, [x8, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00669E7C8  ldr      x1, [x8]
00669E7CC  ldrb     w8, [x1, #0x53]
00669E7D0  tbnz     w8, #5, #0x669e7dc
00669E7D4  ldr      x23, [x23, #0x350]
00669E7D8  b        #0x669e7ec ; 
00669E7DC  ldr      x8, [x1, #0x60]
00669E7E0  mov      x0, x23
00669E7E4  blr      x8
00669E7E8  mov      x23, x0
00669E7EC  ldr      x1, [x25]
00669E7F0  ldrb     w8, [x1, #0x53]
00669E7F4  tbnz     w8, #5, #0x669e800
00669E7F8  ldr      x0, [x19, #0x30]
00669E7FC  b        #0x669e80c ; 
00669E800  ldr      x8, [x1, #0x60]
00669E804  mov      x0, x19
00669E808  blr      x8
00669E80C  cbz      x0, #0x669eca0
00669E810  ldr      x1, [x26]
00669E814  ldrb     w8, [x1, #0x53]
00669E818  tbnz     w8, #5, #0x669e824
00669E81C  ldr      x1, [x0, #0x38]
00669E820  b        #0x669e830 ; 
00669E824  ldr      x8, [x1, #0x60]
00669E828  blr      x8
00669E82C  mov      x1, x0
00669E830  cbz      x23, #0x669eca0
00669E834  mov      x0, x23
00669E838  mov      x2, x22
00669E83C  mov      x3, xzr
00669E840  bl       #0x666b0dc ; HotFix.BattleLogic.DropMgr$$DropItems
00669E844  ldr      x1, [x25]
00669E848  ldrb     w8, [x1, #0x53]
00669E84C  tbnz     w8, #5, #0x669e858
00669E850  ldr      x0, [x19, #0x30]
00669E854  b        #0x669e864 ; 
00669E858  ldr      x8, [x1, #0x60]
00669E85C  mov      x0, x19
00669E860  blr      x8
00669E864  cbz      x0, #0x669eca0
00669E868  ldr      x1, [x26]
00669E86C  ldrb     w8, [x1, #0x53]
00669E870  tbnz     w8, #5, #0x669e87c
00669E874  ldr      x22, [x0, #0x38]
00669E878  b        #0x669e888 ; 
00669E87C  ldr      x8, [x1, #0x60]
00669E880  blr      x8
00669E884  mov      x22, x0
00669E888  cbz      x22, #0x669eca0
00669E88C  adrp     x23, #0x9591000
00669E890  ldrb     w8, [x23, #0xa8f]
00669E894  cbnz     w8, #0x669e8ac
00669E898  adrp     x0, #0x8ee6000
00669E89C  ldr      x0, [x0, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
00669E8A0  bl       #0x382bd14 ; 
00669E8A4  mov      w8, #1
00669E8A8  strb     w8, [x23, #0xa8f]
00669E8AC  adrp     x8, #0x8ee6000
00669E8B0  ldr      x8, [x8, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
00669E8B4  ldr      x2, [x8]
00669E8B8  ldrb     w8, [x2, #0x53]
00669E8BC  tbnz     w8, #5, #0x669e8cc
00669E8C0  ldrb     w8, [x22, #0x223]
00669E8C4  tbz      w8, #1, #0x669e8e0
00669E8C8  b        #0x669ea28 ; 
00669E8CC  ldr      x8, [x2, #0x60]
00669E8D0  mov      w1, #0x19
00669E8D4  mov      x0, x22
00669E8D8  blr      x8
00669E8DC  tbnz     w0, #0, #0x669ea28
00669E8E0  ldr      x1, [x25]
00669E8E4  ldrb     w8, [x1, #0x53]
00669E8E8  tbnz     w8, #5, #0x669e8f4
00669E8EC  ldr      x22, [x19, #0x30]
00669E8F0  b        #0x669e904 ; 
00669E8F4  ldr      x8, [x1, #0x60]
00669E8F8  mov      x0, x19
00669E8FC  blr      x8
00669E900  mov      x22, x0
00669E904  cbz      x22, #0x669eca0
00669E908  adrp     x23, #0x9591000
00669E90C  ldrb     w8, [x23, #0xa4b]
00669E910  cbnz     w8, #0x669e928
00669E914  adrp     x0, #0x8ee5000
00669E918  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00669E91C  bl       #0x382bd14 ; 
00669E920  mov      w8, #1
00669E924  strb     w8, [x23, #0xa4b]
00669E928  adrp     x8, #0x8ee5000
00669E92C  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00669E930  ldr      x1, [x8]
00669E934  ldrb     w8, [x1, #0x53]
00669E938  tbnz     w8, #5, #0x669e944
00669E93C  ldr      x22, [x22, #0x20]
00669E940  b        #0x669e954 ; 
00669E944  ldr      x8, [x1, #0x60]
00669E948  mov      x0, x22
00669E94C  blr      x8
00669E950  mov      x22, x0
00669E954  cbz      x22, #0x669eca0
00669E958  adrp     x23, #0x9598000
00669E95C  ldrb     w8, [x23, #0xfc4]
00669E960  cbnz     w8, #0x669e978
00669E964  adrp     x0, #0x8f05000
00669E968  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00669E96C  bl       #0x382bd14 ; 
00669E970  mov      w8, #1
00669E974  strb     w8, [x23, #0xfc4]
00669E978  adrp     x8, #0x8f05000
00669E97C  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00669E980  ldr      x1, [x8]
00669E984  ldrb     w8, [x1, #0x53]
00669E988  tbnz     w8, #5, #0x669e994
00669E98C  ldr      x22, [x22, #0x220]
00669E990  b        #0x669e9a4 ; 
00669E994  ldr      x8, [x1, #0x60]
00669E998  mov      x0, x22
00669E99C  blr      x8
00669E9A0  mov      x22, x0
00669E9A4  ldr      x1, [x25]
00669E9A8  ldrb     w8, [x1, #0x53]
00669E9AC  tbnz     w8, #5, #0x669e9b8
00669E9B0  ldr      x1, [x19, #0x30]
00669E9B4  b        #0x669e9c8 ; 
00669E9B8  ldr      x8, [x1, #0x60]
00669E9BC  mov      x0, x19
00669E9C0  blr      x8
00669E9C4  mov      x1, x0
00669E9C8  cbz      x22, #0x669eca0
00669E9CC  ldr      x8, [x22]
00669E9D0  ldr      x2, [x21, #0x18]
00669E9D4  mov      x0, x22
00669E9D8  ldr      x9, [x8, #0x348]
00669E9DC  ldr      x3, [x8, #0x350]
00669E9E0  blr      x9
00669E9E4  adrp     x8, #0x8ec1000
00669E9E8  ldr      x22, [x19, #0x40]
00669E9EC  ldr      x8, [x8, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
00669E9F0  ldr      x0, [x8]
00669E9F4  bl       #0x382bfa0 ; 
00669E9F8  adrp     x8, #0x8f11000
00669E9FC  ldr      x8, [x8, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentDeath.<>c__DisplayClass11_0.<OnDeath>b__0() @ 0x92d41e0
00669EA00  mov      x1, x21
00669EA04  mov      x3, xzr
00669EA08  mov      x23, x0
00669EA0C  ldr      x2, [x8]
00669EA10  bl       #0x7ade578 ; System.Action$$.ctor
00669EA14  cbz      x22, #0x669eca0
00669EA18  str      x23, [x22, #0x28]!
00669EA1C  mov      x0, x22
00669EA20  mov      x1, x23
00669EA24  bl       #0x382bcb8 ; 
00669EA28  ldr      w8, [x19, #0x48]
00669EA2C  cmp      w8, #1
00669EA30  b.lt     #0x669eb70
00669EA34  ldr      x1, [x25]
00669EA38  ldrb     w8, [x1, #0x53]
00669EA3C  tbnz     w8, #5, #0x669ea48
00669EA40  ldr      x0, [x19, #0x30]
00669EA44  b        #0x669ea54 ; 
00669EA48  ldr      x8, [x1, #0x60]
00669EA4C  mov      x0, x19
00669EA50  blr      x8
00669EA54  cbz      x0, #0x669eca0
00669EA58  ldr      x1, [x26]
00669EA5C  ldrb     w8, [x1, #0x53]
00669EA60  tbnz     w8, #5, #0x669ea6c
00669EA64  ldr      x0, [x0, #0x38]
00669EA68  b        #0x669ea74 ; 
00669EA6C  ldr      x8, [x1, #0x60]
00669EA70  blr      x8
00669EA74  cbz      x0, #0x669eca0
00669EA78  add      x8, sp, #0xc0
00669EA7C  mov      x1, xzr
00669EA80  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00669EA84  ldr      x1, [x25]
00669EA88  ldp      x23, x28, [sp, #0xc0]
00669EA8C  ldr      x27, [sp, #0xd0]
00669EA90  ldrb     w8, [x1, #0x53]
00669EA94  tbnz     w8, #5, #0x669eaa0
00669EA98  ldr      x21, [x19, #0x30]
00669EA9C  b        #0x669eab8 ; 
00669EAA0  ldr      x8, [x1, #0x60]
00669EAA4  mov      x0, x19
00669EAA8  blr      x8
00669EAAC  ldr      x1, [x25]
00669EAB0  mov      x21, x0
00669EAB4  ldrb     w8, [x1, #0x53]
00669EAB8  ldr      w22, [x19, #0x48]
00669EABC  tbnz     w8, #5, #0x669eac8
00669EAC0  ldr      x0, [x19, #0x30]
00669EAC4  b        #0x669ead4 ; 
00669EAC8  ldr      x8, [x1, #0x60]
00669EACC  mov      x0, x19
00669EAD0  blr      x8
00669EAD4  cbz      x0, #0x669eca0
00669EAD8  ldr      x1, [x26]
00669EADC  ldrb     w8, [x1, #0x53]
00669EAE0  tbnz     w8, #5, #0x669eaec
00669EAE4  ldr      x0, [x0, #0x38]
00669EAE8  b        #0x669eaf4 ; 
00669EAEC  ldr      x8, [x1, #0x60]
00669EAF0  blr      x8
00669EAF4  cbz      x0, #0x669eca0
00669EAF8  add      x8, sp, #0xa0
00669EAFC  mov      x1, xzr
00669EB00  bl       #0x6b28de0 ; HotFix.EntityData$$get_Rotation
00669EB04  ldp      q1, q2, [sp, #0xa0]
00669EB08  movi     v0.2d, #0000000000000000
00669EB0C  stp      q0, q0, [sp, #0xa0]
00669EB10  stp      q1, q2, [sp, #0xc0]
00669EB14  cbz      x21, #0x669eca0
00669EB18  ldp      q1, q2, [sp, #0xc0]
00669EB1C  ldp      q3, q4, [sp, #0xa0]
00669EB20  add      x8, x28, #0xc, lsl #12
00669EB24  stp      x8, x27, [sp, #0x90]
00669EB28  mov      w8, #1
00669EB2C  add      x2, sp, #0x88
00669EB30  add      x3, sp, #0x60
00669EB34  add      x4, sp, #0x40
00669EB38  mov      x0, x21
00669EB3C  mov      w1, w22
00669EB40  mov      x5, xzr
00669EB44  mov      w6, wzr
00669EB48  mov      w7, wzr
00669EB4C  str      x23, [sp, #0x88]
00669EB50  stp      q1, q2, [sp, #0x60]
00669EB54  stp      q3, q4, [sp, #0x40]
00669EB58  stur     q0, [sp, #0x28]
00669EB5C  strb     wzr, [sp, #0x20]
00669EB60  str      xzr, [sp, #0x10]
00669EB64  strb     w8, [sp, #0x18]
00669EB68  str      q0, [sp]
00669EB6C  bl       #0x67fd4e0 ; HotFix.BattleLogic.EntityCharacter$$CreateWeaponAndFire
00669EB70  ldr      x0, [x19, #0x40]
00669EB74  cbz      x0, #0x669eca0
00669EB78  ldr      x8, [x0]
00669EB7C  ldr      x9, [x8, #0x208]
00669EB80  ldr      x1, [x8, #0x210]
00669EB84  blr      x9
00669EB88  ldr      x1, [x25]
00669EB8C  ldrb     w8, [x1, #0x53]
00669EB90  tbnz     w8, #5, #0x669eb9c
00669EB94  ldr      x0, [x19, #0x30]
00669EB98  b        #0x669eba8 ; 
00669EB9C  ldr      x8, [x1, #0x60]
00669EBA0  mov      x0, x19
00669EBA4  blr      x8
00669EBA8  cbz      x0, #0x669eca0
00669EBAC  mov      w1, wzr
00669EBB0  mov      x2, xzr
00669EBB4  bl       #0x67d8cc8 ; HotFix.BattleLogic.EntityCharacter$$SetHitAble
00669EBB8  ldr      x1, [x25]
00669EBBC  ldrb     w8, [x1, #0x53]
00669EBC0  tbnz     w8, #5, #0x669ebcc
00669EBC4  ldr      x21, [x19, #0x30]
00669EBC8  b        #0x669ebdc ; 
00669EBCC  ldr      x8, [x1, #0x60]
00669EBD0  mov      x0, x19
00669EBD4  blr      x8
00669EBD8  mov      x21, x0
00669EBDC  cbz      x21, #0x669eca0
00669EBE0  adrp     x22, #0x9599000
00669EBE4  ldrb     w8, [x22, #0x27e]
00669EBE8  cbnz     w8, #0x669ec00
00669EBEC  adrp     x0, #0x8f07000
00669EBF0  ldr      x0, [x0, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.SetChooseAble() @ 0x9262c18
00669EBF4  bl       #0x382bd14 ; 
00669EBF8  mov      w8, #1
00669EBFC  strb     w8, [x22, #0x27e]
00669EC00  adrp     x8, #0x8f07000
00669EC04  ldr      x8, [x8, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.SetChooseAble() @ 0x9262c18
00669EC08  ldr      x2, [x8]
00669EC0C  ldrb     w8, [x2, #0x53]
00669EC10  tbnz     w8, #5, #0x669ec1c
00669EC14  strb     wzr, [x21, #0x308]
00669EC18  b        #0x669ec2c ; 
00669EC1C  ldr      x8, [x2, #0x60]
00669EC20  mov      x0, x21
00669EC24  mov      w1, wzr
00669EC28  blr      x8
00669EC2C  ldr      x1, [x25]
00669EC30  ldrb     w8, [x1, #0x53]
00669EC34  tbnz     w8, #5, #0x669ec40
00669EC38  ldr      x0, [x19, #0x30]
00669EC3C  b        #0x669ec4c ; 
00669EC40  ldr      x8, [x1, #0x60]
00669EC44  mov      x0, x19
00669EC48  blr      x8
00669EC4C  cbz      x0, #0x669eca0
00669EC50  mov      x1, xzr
00669EC54  bl       #0x68037dc ; HotFix.BattleLogic.EntityCharacter$$ClearWeaponChainData
00669EC58  ldr      x8, [x20]
00669EC5C  cbz      x8, #0x669eca0
00669EC60  ldrb     w8, [x8, #0x20]
00669EC64  cbz      w8, #0x669ec70
00669EC68  mov      x0, x19
00669EC6C  bl       #0x669efbc ; HotFix.BattleLogic.CharacterComponentDeath$$PlayVibartion
00669EC70  ldr      x8, [x24, #0x28]
00669EC74  ldr      x9, [sp, #0xe8]
00669EC78  cmp      x8, x9
00669EC7C  b.ne     #0x669eca4
00669EC80  ldp      x20, x19, [sp, #0x140]
00669EC84  ldp      x22, x21, [sp, #0x130]
00669EC88  ldp      x24, x23, [sp, #0x120]
00669EC8C  ldp      x26, x25, [sp, #0x110]
00669EC90  ldp      x28, x27, [sp, #0x100]
00669EC94  ldp      x29, x30, [sp, #0xf0]
00669EC98  add      sp, sp, #0x150
00669EC9C  ret      
00669ECA0  bl       #0x382bfb8 ; 
00669ECA4  bl       #0x89edb60 ; 

