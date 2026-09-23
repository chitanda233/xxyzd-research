; HotFix.BattleLogic.SinglePlayerBattleManager$$CreatePlayer
; RVA 0x65C64AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C64AC  stp      x30, x27, [sp, #-0x50]!
0065C64B0  stp      x26, x25, [sp, #0x10]
0065C64B4  stp      x24, x23, [sp, #0x20]
0065C64B8  stp      x22, x21, [sp, #0x30]
0065C64BC  stp      x20, x19, [sp, #0x40]
0065C64C0  adrp     x20, #0x9599000
0065C64C4  adrp     x22, #0x8f0a000
0065C64C8  ldrb     w8, [x20, #0x558]
0065C64CC  ldr      x22, [x22, #0x5f8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.CreatePlayer() @ 0x92aa840
0065C64D0  mov      x21, x1
0065C64D4  mov      x19, x0
0065C64D8  tbnz     w8, #0, #0x65c6514
0065C64DC  adrp     x0, #0x8f07000
0065C64E0  ldr      x0, [x0, #0xfc8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacter<EntityHeroNormal>() @ 0x923f0f0
0065C64E4  bl       #0x382bd14 ;
0065C64E8  adrp     x0, #0x8ee8000
0065C64EC  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065C64F0  bl       #0x382bd14 ;
0065C64F4  adrp     x0, #0x8f07000
0065C64F8  ldr      x0, [x0, #0xfd0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent() @ 0x9210160
0065C64FC  bl       #0x382bd14 ;
0065C6500  adrp     x0, #0x8f0a000
0065C6504  ldr      x0, [x0, #0x5f8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.CreatePlayer() @ 0x92aa840
0065C6508  bl       #0x382bd14 ;
0065C650C  mov      w8, #1
0065C6510  strb     w8, [x20, #0x558]
0065C6514  ldr      x2, [x22]
0065C6518  ldrb     w8, [x2, #0x53]
0065C651C  tbnz     w8, #5, #0x65c655c
0065C6520  adrp     x25, #0x9599000
0065C6524  ldrb     w8, [x25, #0x286]
0065C6528  cbnz     w8, #0x65c6540
0065C652C  adrp     x0, #0x8f07000
0065C6530  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C6534  bl       #0x382bd14 ;
0065C6538  mov      w8, #1
0065C653C  strb     w8, [x25, #0x286]
0065C6540  adrp     x26, #0x8f07000
0065C6544  ldr      x26, [x26, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C6548  ldr      x1, [x26]
0065C654C  ldrb     w8, [x1, #0x53]
0065C6550  tbnz     w8, #5, #0x65c6580
0065C6554  ldr      x0, [x19, #0x80]
0065C6558  b        #0x65c658c ;
0065C655C  ldr      x3, [x2, #0x60]
0065C6560  mov      x0, x19
0065C6564  mov      x1, x21
0065C6568  ldp      x20, x19, [sp, #0x40]
0065C656C  ldp      x22, x21, [sp, #0x30]
0065C6570  ldp      x24, x23, [sp, #0x20]
0065C6574  ldp      x26, x25, [sp, #0x10]
0065C6578  ldp      x30, x27, [sp], #0x50
0065C657C  br       x3
0065C6580  ldr      x8, [x1, #0x60]
0065C6584  mov      x0, x19
0065C6588  blr      x8
0065C658C  cbz      x0, #0x65c6a00
0065C6590  mov      w2, #1
0065C6594  mov      x1, x21
0065C6598  mov      x3, xzr
0065C659C  mov      w20, #1
0065C65A0  bl       #0x6a101bc ; HotFix.BattleLogic.BattleWorldContext$$CreatePlayerData
0065C65A4  ldrb     w8, [x25, #0x286]
0065C65A8  mov      x22, x0
0065C65AC  cbnz     w8, #0x65c65c0
0065C65B0  adrp     x0, #0x8f07000
0065C65B4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C65B8  bl       #0x382bd14 ;
0065C65BC  strb     w20, [x25, #0x286]
0065C65C0  ldr      x1, [x26]
0065C65C4  ldrb     w8, [x1, #0x53]
0065C65C8  tbnz     w8, #5, #0x65c65d4
0065C65CC  ldr      x0, [x19, #0x80]
0065C65D0  b        #0x65c65e0 ;
0065C65D4  ldr      x8, [x1, #0x60]
0065C65D8  mov      x0, x19
0065C65DC  blr      x8
0065C65E0  cbz      x0, #0x65c6a00
0065C65E4  adrp     x8, #0x8f07000
0065C65E8  ldr      x8, [x8, #0xfc8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacter<EntityHeroNormal>() @ 0x923f0f0
0065C65EC  mov      x1, x22
0065C65F0  ldr      x2, [x8]
0065C65F4  bl       #0x453ffcc ; HotFix.BattleLogic.BattleWorldContext$$CreateCharacter<object>
0065C65F8  cbz      x0, #0x65c6a00
0065C65FC  mov      x1, xzr
0065C6600  mov      x20, x0
0065C6604  bl       #0x6594ab4 ;
0065C6608  ldrb     w8, [x25, #0x286]
0065C660C  cbnz     w8, #0x65c6624
0065C6610  adrp     x0, #0x8f07000
0065C6614  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C6618  bl       #0x382bd14 ;
0065C661C  mov      w8, #1
0065C6620  strb     w8, [x25, #0x286]
0065C6624  ldr      x1, [x26]
0065C6628  ldrb     w8, [x1, #0x53]
0065C662C  tbnz     w8, #5, #0x65c6638
0065C6630  ldr      x23, [x19, #0x80]
0065C6634  b        #0x65c6648 ;
0065C6638  ldr      x8, [x1, #0x60]
0065C663C  mov      x0, x19
0065C6640  blr      x8
0065C6644  mov      x23, x0
0065C6648  cbz      x21, #0x65c6a00
0065C664C  adrp     x24, #0x9599000
0065C6650  ldrb     w8, [x24, #0x297]
0065C6654  cbnz     w8, #0x65c666c
0065C6658  adrp     x0, #0x8f07000
0065C665C  ldr      x0, [x0, #0xca8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_PlayerId() @ 0x923da08
0065C6660  bl       #0x382bd14 ;
0065C6664  mov      w8, #1
0065C6668  strb     w8, [x24, #0x297]
0065C666C  adrp     x8, #0x8f07000
0065C6670  ldr      x8, [x8, #0xca8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_PlayerId() @ 0x923da08
0065C6674  ldr      x1, [x8]
0065C6678  ldrb     w8, [x1, #0x53]
0065C667C  tbnz     w8, #5, #0x65c6688
0065C6680  ldr      w2, [x21, #0x10]
0065C6684  b        #0x65c6698 ;
0065C6688  ldr      x8, [x1, #0x60]
0065C668C  mov      x0, x21
0065C6690  blr      x8
0065C6694  mov      w2, w0
0065C6698  cbz      x23, #0x65c6a00
0065C669C  mov      x0, x23
0065C66A0  mov      x1, x20
0065C66A4  mov      x3, xzr
0065C66A8  bl       #0x6a107c4 ; HotFix.BattleLogic.BattleWorldContext$$SetPlayerId
0065C66AC  ldrb     w8, [x25, #0x286]
0065C66B0  cbnz     w8, #0x65c66c8
0065C66B4  adrp     x0, #0x8f07000
0065C66B8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C66BC  bl       #0x382bd14 ;
0065C66C0  mov      w8, #1
0065C66C4  strb     w8, [x25, #0x286]
0065C66C8  ldr      x1, [x26]
0065C66CC  ldrb     w8, [x1, #0x53]
0065C66D0  tbnz     w8, #5, #0x65c66dc
0065C66D4  ldr      x0, [x19, #0x80]
0065C66D8  b        #0x65c66e8 ;
0065C66DC  ldr      x8, [x1, #0x60]
0065C66E0  mov      x0, x19
0065C66E4  blr      x8
0065C66E8  cbz      x0, #0x65c6a00
0065C66EC  mov      x1, x20
0065C66F0  mov      x2, xzr
0065C66F4  bl       #0x6a1089c ; HotFix.BattleLogic.BattleWorldContext$$DisPatchCreatePlayerEvent
0065C66F8  ldrb     w8, [x25, #0x286]
0065C66FC  cbnz     w8, #0x65c6714
0065C6700  adrp     x0, #0x8f07000
0065C6704  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C6708  bl       #0x382bd14 ;
0065C670C  mov      w8, #1
0065C6710  strb     w8, [x25, #0x286]
0065C6714  ldr      x1, [x26]
0065C6718  ldrb     w8, [x1, #0x53]
0065C671C  tbnz     w8, #5, #0x65c6728
0065C6720  ldr      x23, [x19, #0x80]
0065C6724  b        #0x65c6738 ;
0065C6728  ldr      x8, [x1, #0x60]
0065C672C  mov      x0, x19
0065C6730  blr      x8
0065C6734  mov      x23, x0
0065C6738  adrp     x24, #0x8ee8000
0065C673C  ldr      x24, [x24, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065C6740  ldr      x0, [x24]
0065C6744  ldr      w8, [x0, #0xe0]
0065C6748  cbnz     w8, #0x65c6754
0065C674C  bl       #0x382be8c ;
0065C6750  ldr      x0, [x24]
0065C6754  cbz      x23, #0x65c6a00
0065C6758  ldr      x8, [x0, #0xb8]
0065C675C  adrp     x27, #0x9599000
0065C6760  ldrb     w9, [x27, #0x64b]
0065C6764  ldr      w24, [x8, #0x208]
0065C6768  cbnz     w9, #0x65c6780
0065C676C  adrp     x0, #0x8f0a000
0065C6770  ldr      x0, [x0, #0x600] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroupCount() @ 0x923f8c0
0065C6774  bl       #0x382bd14 ;
0065C6778  mov      w8, #1
0065C677C  strb     w8, [x27, #0x64b]
0065C6780  adrp     x8, #0x8f0a000
0065C6784  ldr      x8, [x8, #0x600] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroupCount() @ 0x923f8c0
0065C6788  ldr      x2, [x8]
0065C678C  ldrb     w8, [x2, #0x53]
0065C6790  tbnz     w8, #5, #0x65c67b4
0065C6794  ldr      x0, [x23, #0x1d0]
0065C6798  cbz      x0, #0x65c6a00
0065C679C  ldr      x8, [x0]
0065C67A0  ldp      x9, x1, [x8, #0x198]
0065C67A4  blr      x9
0065C67A8  tbnz     w0, #0, #0x65c67c4
0065C67AC  str      w24, [x23, #0x2c4]
0065C67B0  b        #0x65c67c4 ;
0065C67B4  ldr      x8, [x2, #0x60]
0065C67B8  mov      x0, x23
0065C67BC  mov      w1, w24
0065C67C0  blr      x8
0065C67C4  adrp     x23, #0x9599000
0065C67C8  ldrb     w8, [x23, #0x299]
0065C67CC  cbnz     w8, #0x65c67e4
0065C67D0  adrp     x0, #0x8f07000
0065C67D4  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_BanSkills() @ 0x923d9e8
0065C67D8  bl       #0x382bd14 ;
0065C67DC  mov      w8, #1
0065C67E0  strb     w8, [x23, #0x299]
0065C67E4  adrp     x8, #0x8f07000
0065C67E8  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_BanSkills() @ 0x923d9e8
0065C67EC  ldr      x1, [x8]
0065C67F0  ldrb     w8, [x1, #0x53]
0065C67F4  tbnz     w8, #5, #0x65c6800
0065C67F8  ldr      x23, [x21, #0x20]
0065C67FC  b        #0x65c6810 ;
0065C6800  ldr      x8, [x1, #0x60]
0065C6804  mov      x0, x21
0065C6808  blr      x8
0065C680C  mov      x23, x0
0065C6810  adrp     x24, #0x9599000
0065C6814  ldrb     w8, [x24, #0x29a]
0065C6818  cbnz     w8, #0x65c6830
0065C681C  adrp     x0, #0x8f07000
0065C6820  ldr      x0, [x0, #0xfe0] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_InitSkills() @ 0x923d9f8
0065C6824  bl       #0x382bd14 ;
0065C6828  mov      w8, #1
0065C682C  strb     w8, [x24, #0x29a]
0065C6830  adrp     x8, #0x8f07000
0065C6834  ldr      x8, [x8, #0xfe0] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_InitSkills() @ 0x923d9f8
0065C6838  ldr      x1, [x8]
0065C683C  ldrb     w8, [x1, #0x53]
0065C6840  tbnz     w8, #5, #0x65c684c
0065C6844  ldr      x2, [x21, #0x18]
0065C6848  b        #0x65c685c ;
0065C684C  ldr      x8, [x1, #0x60]
0065C6850  mov      x0, x21
0065C6854  blr      x8
0065C6858  mov      x2, x0
0065C685C  mov      x0, x20
0065C6860  mov      x1, x23
0065C6864  mov      x3, xzr
0065C6868  bl       #0x6877220 ; HotFix.BattleLogic.EntityHero$$InitSkills
0065C686C  cbz      x22, #0x65c6a00
0065C6870  adrp     x21, #0x9591000
0065C6874  ldrb     w8, [x21, #0xa7f]
0065C6878  cbnz     w8, #0x65c6890
0065C687C  adrp     x0, #0x8ee6000
0065C6880  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
0065C6884  bl       #0x382bd14 ;
0065C6888  mov      w8, #1
0065C688C  strb     w8, [x21, #0xa7f]
0065C6890  adrp     x8, #0x8ee6000
0065C6894  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
0065C6898  ldr      x1, [x8]
0065C689C  ldrb     w8, [x1, #0x53]
0065C68A0  tbnz     w8, #5, #0x65c68ac
0065C68A4  ldr      x2, [x22, #0x178]
0065C68A8  b        #0x65c68bc ;
0065C68AC  ldr      x8, [x1, #0x60]
0065C68B0  mov      x0, x22
0065C68B4  blr      x8
0065C68B8  mov      x2, x0
0065C68BC  mov      x0, x19
0065C68C0  mov      x1, x20
0065C68C4  bl       #0x65c6a04 ; HotFix.BattleLogic.SinglePlayerBattleManager$$ChangePlayerByWorldInfo
0065C68C8  mov      x0, x20
0065C68CC  mov      x1, xzr
0065C68D0  bl       #0x6878538 ; HotFix.BattleLogic.EntityHero$$AfterCreate
0065C68D4  adrp     x8, #0x8f07000
0065C68D8  ldr      x8, [x8, #0xfd0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent() @ 0x9210160
0065C68DC  mov      w1, #1
0065C68E0  mov      x0, x20
0065C68E4  mov      w21, #1
0065C68E8  ldr      x2, [x8]
0065C68EC  bl       #0x60b34ec ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0065C68F0  ldrb     w8, [x25, #0x286]
0065C68F4  cbnz     w8, #0x65c6908
0065C68F8  adrp     x0, #0x8f07000
0065C68FC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C6900  bl       #0x382bd14 ;
0065C6904  strb     w21, [x25, #0x286]
0065C6908  ldr      x1, [x26]
0065C690C  ldrb     w8, [x1, #0x53]
0065C6910  tbnz     w8, #5, #0x65c691c
0065C6914  ldr      x0, [x19, #0x80]
0065C6918  b        #0x65c6928 ;
0065C691C  ldr      x8, [x1, #0x60]
0065C6920  mov      x0, x19
0065C6924  blr      x8
0065C6928  cbz      x0, #0x65c6a00
0065C692C  ldr      w8, [x0, #0x1c8]
0065C6930  cmp      w8, #4
0065C6934  b.ne     #0x65c6968
0065C6938  ldrb     w8, [x25, #0x286]
0065C693C  cbnz     w8, #0x65c6954
0065C6940  adrp     x0, #0x8f07000
0065C6944  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C6948  bl       #0x382bd14 ;
0065C694C  mov      w8, #1
0065C6950  strb     w8, [x25, #0x286]
0065C6954  ldr      x1, [x26]
0065C6958  ldrb     w8, [x1, #0x53]
0065C695C  tbnz     w8, #5, #0x65c6980
0065C6960  ldr      x19, [x19, #0x80]
0065C6964  b        #0x65c6990 ;
0065C6968  ldp      x20, x19, [sp, #0x40]
0065C696C  ldp      x22, x21, [sp, #0x30]
0065C6970  ldp      x24, x23, [sp, #0x20]
0065C6974  ldp      x26, x25, [sp, #0x10]
0065C6978  ldp      x30, x27, [sp], #0x50
0065C697C  ret
0065C6980  ldr      x8, [x1, #0x60]
0065C6984  mov      x0, x19
0065C6988  blr      x8
0065C698C  mov      x19, x0
0065C6990  cbz      x19, #0x65c6a00
0065C6994  adrp     x21, #0x9599000
0065C6998  ldrb     w8, [x21, #0x64c]
0065C699C  cbnz     w8, #0x65c69b4
0065C69A0  adrp     x0, #0x8f0a000
0065C69A4  ldr      x0, [x0, #0x608] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_TermManger() @ 0x923ffd8
0065C69A8  bl       #0x382bd14 ;
0065C69AC  mov      w8, #1
0065C69B0  strb     w8, [x21, #0x64c]
0065C69B4  adrp     x8, #0x8f0a000
0065C69B8  ldr      x8, [x8, #0x608] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_TermManger() @ 0x923ffd8
0065C69BC  ldr      x1, [x8]
0065C69C0  ldrb     w8, [x1, #0x53]
0065C69C4  tbnz     w8, #5, #0x65c69d0
0065C69C8  ldr      x0, [x19, #0x248]
0065C69CC  b        #0x65c69dc ;
0065C69D0  ldr      x8, [x1, #0x60]
0065C69D4  mov      x0, x19
0065C69D8  blr      x8
0065C69DC  cbz      x0, #0x65c6a00
0065C69E0  mov      x1, x20
0065C69E4  ldp      x20, x19, [sp, #0x40]
0065C69E8  ldp      x22, x21, [sp, #0x30]
0065C69EC  ldp      x24, x23, [sp, #0x20]
0065C69F0  ldp      x26, x25, [sp, #0x10]
0065C69F4  mov      x2, xzr
0065C69F8  ldp      x30, x27, [sp], #0x50
0065C69FC  b        #0x65b9630 ; HotFix.BattleLogic.BattleTermManger$$OnPlayerCreate
0065C6A00  bl       #0x382bfb8 ;
