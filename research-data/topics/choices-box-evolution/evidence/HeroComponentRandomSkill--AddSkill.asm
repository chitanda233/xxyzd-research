; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkill
; RVA 0x686A53C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686A53C  sub      sp, sp, #0x70
00686A540  stp      x29, x30, [sp, #0x10]
00686A544  stp      x28, x27, [sp, #0x20]
00686A548  stp      x26, x25, [sp, #0x30]
00686A54C  stp      x24, x23, [sp, #0x40]
00686A550  stp      x22, x21, [sp, #0x50]
00686A554  stp      x20, x19, [sp, #0x60]
00686A558  adrp     x21, #0x959b000
00686A55C  adrp     x22, #0x8f24000
00686A560  ldrb     w8, [x21, #0xa41]
00686A564  ldr      x22, [x22, #0x60] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.AddSkill() @ 0x927f948
00686A568  mov      x20, x1
00686A56C  mov      x19, x0
00686A570  tbnz     w8, #0, #0x686a600
00686A574  adrp     x0, #0x8f23000
00686A578  ldr      x0, [x0, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686A57C  bl       #0x382bd14 ; 
00686A580  adrp     x0, #0x8f24000
00686A584  ldr      x0, [x0, #0x60] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.AddSkill() @ 0x927f948
00686A588  bl       #0x382bd14 ; 
00686A58C  adrp     x0, #0x8ebf000
00686A590  ldr      x0, [x0, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
00686A594  bl       #0x382bd14 ; 
00686A598  adrp     x0, #0x8f23000
00686A59C  ldr      x0, [x0, #0xfc0] ; GLOBAL System.Collections.Generic.IEnumerable<Skill_Synthesis>_TypeInfo @ 0x91d76e0
00686A5A0  bl       #0x382bd14 ; 
00686A5A4  adrp     x0, #0x8f23000
00686A5A8  ldr      x0, [x0, #0xfc8] ; GLOBAL System.Collections.Generic.IEnumerator<Skill_Synthesis>_TypeInfo @ 0x91d8100
00686A5AC  bl       #0x382bd14 ; 
00686A5B0  adrp     x0, #0x8ebf000
00686A5B4  ldr      x0, [x0, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
00686A5B8  bl       #0x382bd14 ; 
00686A5BC  adrp     x0, #0x8f23000
00686A5C0  ldr      x0, [x0, #0xf98] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.ContainsKey() @ 0x92288c8
00686A5C4  bl       #0x382bd14 ; 
00686A5C8  adrp     x0, #0x8f23000
00686A5CC  ldr      x0, [x0, #0xfa0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.get_Item() @ 0x92288e0
00686A5D0  bl       #0x382bd14 ; 
00686A5D4  adrp     x0, #0x8f23000
00686A5D8  ldr      x0, [x0, #0xfa8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.set_Item() @ 0x92288e8
00686A5DC  bl       #0x382bd14 ; 
00686A5E0  adrp     x0, #0x8f24000
00686A5E4  ldr      x0, [x0, #0x50] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.Add() @ 0x9228ca0
00686A5E8  bl       #0x382bd14 ; 
00686A5EC  adrp     x0, #0x8f23000
00686A5F0  ldr      x0, [x0, #0xfd0] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.Contains() @ 0x9228cb0
00686A5F4  bl       #0x382bd14 ; 
00686A5F8  mov      w8, #1
00686A5FC  strb     w8, [x21, #0xa41]
00686A600  ldr      x2, [x22]
00686A604  ldrb     w8, [x2, #0x53]
00686A608  tbnz     w8, #5, #0x686a650
00686A60C  stp      xzr, xzr, [sp]
00686A610  cbz      x20, #0x686adec
00686A614  adrp     x23, #0x9598000
00686A618  ldrb     w8, [x23, #0xde3]
00686A61C  cbnz     w8, #0x686a634
00686A620  adrp     x0, #0x8f00000
00686A624  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
00686A628  bl       #0x382bd14 ; 
00686A62C  mov      w8, #1
00686A630  strb     w8, [x23, #0xde3]
00686A634  adrp     x24, #0x8f00000
00686A638  ldr      x24, [x24, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
00686A63C  ldr      x1, [x24]
00686A640  ldrb     w8, [x1, #0x53]
00686A644  tbnz     w8, #5, #0x686a67c
00686A648  ldr      w21, [x20, #0x20]
00686A64C  b        #0x686a68c ; 
00686A650  ldr      x3, [x2, #0x60]
00686A654  mov      x0, x19
00686A658  mov      x1, x20
00686A65C  ldp      x20, x19, [sp, #0x60]
00686A660  ldp      x22, x21, [sp, #0x50]
00686A664  ldp      x24, x23, [sp, #0x40]
00686A668  ldp      x26, x25, [sp, #0x30]
00686A66C  ldp      x28, x27, [sp, #0x20]
00686A670  ldp      x29, x30, [sp, #0x10]
00686A674  add      sp, sp, #0x70
00686A678  br       x3
00686A67C  ldr      x8, [x1, #0x60]
00686A680  mov      x0, x20
00686A684  blr      x8
00686A688  mov      w21, w0
00686A68C  adrp     x22, #0x9598000
00686A690  ldrb     w8, [x22, #0x35e]
00686A694  cbnz     w8, #0x686a6ac
00686A698  adrp     x0, #0x8ef9000
00686A69C  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
00686A6A0  bl       #0x382bd14 ; 
00686A6A4  mov      w8, #1
00686A6A8  strb     w8, [x22, #0x35e]
00686A6AC  adrp     x8, #0x8ef9000
00686A6B0  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
00686A6B4  ldr      x1, [x8]
00686A6B8  ldrb     w8, [x1, #0x53]
00686A6BC  tbnz     w8, #5, #0x686a6c8
00686A6C0  ldr      w22, [x20, #0x68]
00686A6C4  b        #0x686a6d8 ; 
00686A6C8  ldr      x8, [x1, #0x60]
00686A6CC  mov      x0, x20
00686A6D0  blr      x8
00686A6D4  mov      w22, w0
00686A6D8  mov      x0, x19
00686A6DC  mov      w1, w22
00686A6E0  bl       #0x686aef4 ; HotFix.BattleLogic.HeroComponentRandomSkill$$UpdateLearnedSkillCount
00686A6E4  ldr      x0, [x19, #0x48]
00686A6E8  cbz      x0, #0x686adec
00686A6EC  adrp     x8, #0x8f23000
00686A6F0  ldr      x8, [x8, #0xf98] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.ContainsKey() @ 0x92288c8
00686A6F4  mov      w1, w21
00686A6F8  ldr      x2, [x8]
00686A6FC  bl       #0x521de14 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$ContainsKey
00686A700  tbz      w0, #0, #0x686a754
00686A704  ldr      x0, [x19, #0x48]
00686A708  cbz      x0, #0x686adec
00686A70C  adrp     x8, #0x8f23000
00686A710  ldr      x8, [x8, #0xfa0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.get_Item() @ 0x92288e0
00686A714  mov      w1, w21
00686A718  ldr      x2, [x8]
00686A71C  bl       #0x521db48 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$get_Item
00686A720  add      w8, w0, #1
00686A724  str      x0, [sp, #8]
00686A728  str      w8, [sp, #8]
00686A72C  ldr      x0, [x19, #0x48]
00686A730  cbz      x0, #0x686adec
00686A734  adrp     x8, #0x8f23000
00686A738  ldr      x2, [sp, #8]
00686A73C  ldr      x8, [x8, #0xfa8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.set_Item() @ 0x92288e8
00686A740  mov      w1, w21
00686A744  ldr      x3, [x8]
00686A748  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A74C  add      x0, sp, #8
00686A750  b        #0x686a90c ; 
00686A754  adrp     x25, #0x959b000
00686A758  ldrb     w8, [x25, #0xbac]
00686A75C  cbnz     w8, #0x686a774
00686A760  adrp     x0, #0x8f24000
00686A764  ldr      x0, [x0, #0x58] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_MaxCount() @ 0x92ac480
00686A768  bl       #0x382bd14 ; 
00686A76C  mov      w8, #1
00686A770  strb     w8, [x25, #0xbac]
00686A774  adrp     x8, #0x8f24000
00686A778  ldr      x8, [x8, #0x58] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_MaxCount() @ 0x92ac480
00686A77C  ldr      x1, [x8]
00686A780  ldrb     w8, [x1, #0x53]
00686A784  tbnz     w8, #5, #0x686a790
00686A788  ldr      w0, [x20, #0x64]
00686A78C  b        #0x686a79c ; 
00686A790  ldr      x8, [x1, #0x60]
00686A794  mov      x0, x20
00686A798  blr      x8
00686A79C  mov      w2, #1
00686A7A0  bfi      x2, x0, #0x20, #0x20
00686A7A4  str      x2, [sp]
00686A7A8  ldr      x0, [x19, #0x48]
00686A7AC  cbz      x0, #0x686adec
00686A7B0  adrp     x8, #0x8f23000
00686A7B4  ldr      x8, [x8, #0xfa8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.set_Item() @ 0x92288e8
00686A7B8  mov      w1, w21
00686A7BC  ldr      x3, [x8]
00686A7C0  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A7C4  adrp     x25, #0x959b000
00686A7C8  ldrb     w8, [x25, #0x9b4]
00686A7CC  cbnz     w8, #0x686a7e4
00686A7D0  adrp     x0, #0x8f23000
00686A7D4  ldr      x0, [x0, #0x90] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillFlag() @ 0x92ac538
00686A7D8  bl       #0x382bd14 ; 
00686A7DC  mov      w8, #1
00686A7E0  strb     w8, [x25, #0x9b4]
00686A7E4  adrp     x8, #0x8f23000
00686A7E8  ldr      x8, [x8, #0x90] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillFlag() @ 0x92ac538
00686A7EC  ldr      x1, [x8]
00686A7F0  ldrb     w8, [x1, #0x53]
00686A7F4  tbnz     w8, #5, #0x686a800
00686A7F8  ldr      x1, [x20, #0x170]
00686A7FC  b        #0x686a810 ; 
00686A800  ldr      x8, [x1, #0x60]
00686A804  mov      x0, x20
00686A808  blr      x8
00686A80C  mov      x1, x0
00686A810  mov      x0, x19
00686A814  bl       #0x686aff8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillFlags
00686A818  adrp     x25, #0x959b000
00686A81C  ldrb     w8, [x25, #0xbad]
00686A820  cbnz     w8, #0x686a838
00686A824  adrp     x0, #0x8f24000
00686A828  ldr      x0, [x0, #0x68] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_RejectFlag() @ 0x92ac520
00686A82C  bl       #0x382bd14 ; 
00686A830  mov      w8, #1
00686A834  strb     w8, [x25, #0xbad]
00686A838  adrp     x8, #0x8f24000
00686A83C  ldr      x8, [x8, #0x68] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_RejectFlag() @ 0x92ac520
00686A840  ldr      x1, [x8]
00686A844  ldrb     w8, [x1, #0x53]
00686A848  tbnz     w8, #5, #0x686a854
00686A84C  ldr      w1, [x20, #0x17c]
00686A850  b        #0x686a864 ; 
00686A854  ldr      x8, [x1, #0x60]
00686A858  mov      x0, x20
00686A85C  blr      x8
00686A860  mov      w1, w0
00686A864  mov      x0, x19
00686A868  bl       #0x686b0b8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillRejectFlags
00686A86C  ldrb     w8, [x23, #0xde3]
00686A870  cbnz     w8, #0x686a888
00686A874  adrp     x0, #0x8f00000
00686A878  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
00686A87C  bl       #0x382bd14 ; 
00686A880  mov      w8, #1
00686A884  strb     w8, [x23, #0xde3]
00686A888  ldr      x1, [x24]
00686A88C  ldrb     w8, [x1, #0x53]
00686A890  tbnz     w8, #5, #0x686a89c
00686A894  ldr      w1, [x20, #0x20]
00686A898  b        #0x686a8ac ; 
00686A89C  ldr      x8, [x1, #0x60]
00686A8A0  mov      x0, x20
00686A8A4  blr      x8
00686A8A8  mov      w1, w0
00686A8AC  mov      x0, x19
00686A8B0  bl       #0x686b13c ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddNeedSkill
00686A8B4  adrp     x23, #0x959b000
00686A8B8  ldrb     w8, [x23, #0xbae]
00686A8BC  cbnz     w8, #0x686a8d4
00686A8C0  adrp     x0, #0x8f23000
00686A8C4  ldr      x0, [x0, #0xd48] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_RejectSkills() @ 0x92ac528
00686A8C8  bl       #0x382bd14 ; 
00686A8CC  mov      w8, #1
00686A8D0  strb     w8, [x23, #0xbae]
00686A8D4  adrp     x8, #0x8f23000
00686A8D8  ldr      x8, [x8, #0xd48] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_RejectSkills() @ 0x92ac528
00686A8DC  ldr      x1, [x8]
00686A8E0  ldrb     w8, [x1, #0x53]
00686A8E4  tbnz     w8, #5, #0x686a8f0
00686A8E8  ldr      x1, [x20, #0x90]
00686A8EC  b        #0x686a900 ; 
00686A8F0  ldr      x8, [x1, #0x60]
00686A8F4  mov      x0, x20
00686A8F8  blr      x8
00686A8FC  mov      x1, x0
00686A900  mov      x0, x19
00686A904  bl       #0x686b1c0 ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddRejectSkills
00686A908  mov      x0, sp
00686A90C  bl       #0x6866604 ; HotFix.BattleLogic.HeroSkillCount$$IsMax
00686A910  tbz      w0, #0, #0x686a920
00686A914  mov      x0, x19
00686A918  mov      w1, w21
00686A91C  bl       #0x6869e18 ; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveRandomSkill
00686A920  ldr      x0, [x19, #0x50]
00686A924  cbz      x0, #0x686adec
00686A928  adrp     x8, #0x8f24000
00686A92C  ldr      x8, [x8, #0x50] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.Add() @ 0x9228ca0
00686A930  mov      w1, w21
00686A934  ldr      x2, [x8]
00686A938  bl       #0x524e0bc ; Rock.Collections.OrderedHashSet<int>$$Add
00686A93C  mov      x0, x19
00686A940  mov      w1, w22
00686A944  bl       #0x6869e9c ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetDeltaWeightPercent
00686A948  mov      x2, x0
00686A94C  mov      x0, x19
00686A950  mov      w1, w22
00686A954  bl       #0x686a17c ; HotFix.BattleLogic.HeroComponentRandomSkill$$AdjustWeightsForSkillGroup
00686A958  adrp     x8, #0x9591000
00686A95C  ldrb     w8, [x8, #0xa4b]
00686A960  cbnz     w8, #0x686a97c
00686A964  adrp     x0, #0x8ee5000
00686A968  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686A96C  bl       #0x382bd14 ; 
00686A970  mov      w8, #1
00686A974  adrp     x9, #0x9591000
00686A978  strb     w8, [x9, #0xa4b]
00686A97C  adrp     x8, #0x8ee5000
00686A980  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686A984  ldr      x1, [x8]
00686A988  ldrb     w8, [x1, #0x53]
00686A98C  tbnz     w8, #5, #0x686a998
00686A990  ldr      x20, [x19, #0x20]
00686A994  b        #0x686a9a8 ; 
00686A998  ldr      x8, [x1, #0x60]
00686A99C  mov      x0, x19
00686A9A0  blr      x8
00686A9A4  mov      x20, x0
00686A9A8  cbz      x20, #0x686adec
00686A9AC  adrp     x21, #0x9598000
00686A9B0  ldrb     w8, [x21, #0xfcc]
00686A9B4  cbnz     w8, #0x686a9cc
00686A9B8  adrp     x0, #0x8f06000
00686A9BC  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00686A9C0  bl       #0x382bd14 ; 
00686A9C4  mov      w8, #1
00686A9C8  strb     w8, [x21, #0xfcc]
00686A9CC  adrp     x8, #0x8f06000
00686A9D0  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00686A9D4  ldr      x1, [x8]
00686A9D8  ldrb     w8, [x1, #0x53]
00686A9DC  tbnz     w8, #5, #0x686a9e8
00686A9E0  ldr      x0, [x20, #0x200]
00686A9E4  b        #0x686a9f4 ; 
00686A9E8  ldr      x8, [x1, #0x60]
00686A9EC  mov      x0, x20
00686A9F0  blr      x8
00686A9F4  cbz      x0, #0x686adec
00686A9F8  mov      x1, xzr
00686A9FC  bl       #0x64d17c4 ; LocalModels.LocalModelManager$$GetSkill_SynthesisElements
00686AA00  cbz      x0, #0x686adec
00686AA04  adrp     x10, #0x8f23000
00686AA08  ldr      x8, [x0]
00686AA0C  ldr      x10, [x10, #0xfc0] ; GLOBAL System.Collections.Generic.IEnumerable<Skill_Synthesis>_TypeInfo @ 0x91d76e0
00686AA10  mov      x20, x0
00686AA14  ldrh     w9, [x8, #0x12e]
00686AA18  ldr      x1, [x10]
00686AA1C  cbz      x9, #0x686aa40
00686AA20  ldr      x10, [x8, #0xb0]
00686AA24  add      x10, x10, #8
00686AA28  ldur     x11, [x10, #-8]
00686AA2C  cmp      x11, x1
00686AA30  b.eq     #0x686aa50
00686AA34  subs     x9, x9, #1
00686AA38  add      x10, x10, #0x10
00686AA3C  b.ne     #0x686aa28
00686AA40  mov      x0, x20
00686AA44  mov      w2, wzr
00686AA48  bl       #0x3a7e710 ; 
00686AA4C  b        #0x686aa5c ; 
00686AA50  ldrsw    x9, [x10]
00686AA54  add      x8, x8, x9, lsl #4
00686AA58  add      x0, x8, #0x138
00686AA5C  ldp      x8, x1, [x0]
00686AA60  mov      x0, x20
00686AA64  blr      x8
00686AA68  mov      x20, x0
00686AA6C  cbz      x0, #0x686adf8
00686AA70  adrp     x28, #0x8ebf000
00686AA74  adrp     x21, #0x8f23000
00686AA78  adrp     x22, #0x8f23000
00686AA7C  adrp     x24, #0x8f23000
00686AA80  adrp     x23, #0x8f23000
00686AA84  ldr      x28, [x28, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
00686AA88  ldr      x21, [x21, #0xfc8] ; GLOBAL System.Collections.Generic.IEnumerator<Skill_Synthesis>_TypeInfo @ 0x91d8100
00686AA8C  ldr      x22, [x22, #0xfd8] ; GLOBAL Method$LocalModels.Bean.Skill_Synthesis.get_FinalSkill() @ 0x92acaa0
00686AA90  ldr      x24, [x24, #0xfd0] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.Contains() @ 0x9228cb0
00686AA94  ldr      x23, [x23, #0xfe0] ; GLOBAL Method$LocalModels.Bean.Skill_Synthesis.get_Skill1() @ 0x92acab0
00686AA98  adrp     x29, #0x959b000
00686AA9C  mov      w25, #1
00686AAA0  ldr      x8, [x20]
00686AAA4  ldr      x1, [x28]
00686AAA8  ldrh     w9, [x8, #0x12e]
00686AAAC  cbz      x9, #0x686aad0
00686AAB0  ldr      x10, [x8, #0xb0]
00686AAB4  add      x10, x10, #8
00686AAB8  ldur     x11, [x10, #-8]
00686AABC  cmp      x11, x1
00686AAC0  b.eq     #0x686aae0
00686AAC4  subs     x9, x9, #1
00686AAC8  add      x10, x10, #0x10
00686AACC  b.ne     #0x686aab8
00686AAD0  mov      x0, x20
00686AAD4  mov      w2, wzr
00686AAD8  bl       #0x3a7e710 ; 
00686AADC  b        #0x686aaec ; 
00686AAE0  ldrsw    x9, [x10]
00686AAE4  add      x8, x8, x9, lsl #4
00686AAE8  add      x0, x8, #0x138
00686AAEC  ldp      x8, x1, [x0]
00686AAF0  mov      x0, x20
00686AAF4  blr      x8
00686AAF8  tbz      w0, #0, #0x686ad58
00686AAFC  ldr      x8, [x20]
00686AB00  ldr      x1, [x21]
00686AB04  ldrh     w9, [x8, #0x12e]
00686AB08  cbz      x9, #0x686ab2c
00686AB0C  ldr      x10, [x8, #0xb0]
00686AB10  add      x10, x10, #8
00686AB14  ldur     x11, [x10, #-8]
00686AB18  cmp      x11, x1
00686AB1C  b.eq     #0x686ab3c
00686AB20  subs     x9, x9, #1
00686AB24  add      x10, x10, #0x10
00686AB28  b.ne     #0x686ab14
00686AB2C  mov      x0, x20
00686AB30  mov      w2, wzr
00686AB34  bl       #0x3a7e710 ; 
00686AB38  b        #0x686ab48 ; 
00686AB3C  ldrsw    x9, [x10]
00686AB40  add      x8, x8, x9, lsl #4
00686AB44  add      x0, x8, #0x138
00686AB48  ldp      x8, x1, [x0]
00686AB4C  mov      x0, x20
00686AB50  blr      x8
00686AB54  mov      x27, x0
00686AB58  cbz      x0, #0x686ade4
00686AB5C  ldrb     w8, [x29, #0xba8]
00686AB60  cbnz     w8, #0x686ab70
00686AB64  mov      x0, x22
00686AB68  bl       #0x382bd14 ; 
00686AB6C  strb     w25, [x29, #0xba8]
00686AB70  ldr      x1, [x22]
00686AB74  ldrb     w8, [x1, #0x53]
00686AB78  tbnz     w8, #5, #0x686ab84
00686AB7C  ldr      w26, [x27, #0x30]
00686AB80  b        #0x686ab94 ; 
00686AB84  ldr      x8, [x1, #0x60]
00686AB88  mov      x0, x27
00686AB8C  blr      x8
00686AB90  mov      w26, w0
00686AB94  ldr      x0, [x19, #0x50]
00686AB98  cbz      x0, #0x686ade8
00686AB9C  ldr      x2, [x24]
00686ABA0  mov      w1, w26
00686ABA4  bl       #0x524c9b0 ; Rock.Collections.OrderedHashSet<int>$$Contains
00686ABA8  tbnz     w0, #0, #0x686aaa0
00686ABAC  adrp     x8, #0x959b000
00686ABB0  ldrb     w8, [x8, #0xba9]
00686ABB4  cbnz     w8, #0x686abc8
00686ABB8  mov      x0, x23
00686ABBC  bl       #0x382bd14 ; 
00686ABC0  adrp     x8, #0x959b000
00686ABC4  strb     w25, [x8, #0xba9]
00686ABC8  ldr      x1, [x23]
00686ABCC  ldrb     w8, [x1, #0x53]
00686ABD0  tbnz     w8, #5, #0x686abdc
00686ABD4  ldr      w1, [x27, #0x24]
00686ABD8  b        #0x686abec ; 
00686ABDC  ldr      x8, [x1, #0x60]
00686ABE0  mov      x0, x27
00686ABE4  blr      x8
00686ABE8  mov      w1, w0
00686ABEC  mov      x0, x19
00686ABF0  bl       #0x686b244 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<AddSkill>g__SkillSuit|34_0
00686ABF4  tbz      w0, #0, #0x686aaa0
00686ABF8  adrp     x8, #0x959b000
00686ABFC  ldrb     w8, [x8, #0xbaa]
00686AC00  cbnz     w8, #0x686ac18
00686AC04  adrp     x0, #0x8f23000
00686AC08  ldr      x0, [x0, #0xfe8] ; GLOBAL Method$LocalModels.Bean.Skill_Synthesis.get_Skill2() @ 0x92acab8
00686AC0C  bl       #0x382bd14 ; 
00686AC10  adrp     x8, #0x959b000
00686AC14  strb     w25, [x8, #0xbaa]
00686AC18  adrp     x8, #0x8f23000
00686AC1C  ldr      x8, [x8, #0xfe8] ; GLOBAL Method$LocalModels.Bean.Skill_Synthesis.get_Skill2() @ 0x92acab8
00686AC20  ldr      x1, [x8]
00686AC24  ldrb     w8, [x1, #0x53]
00686AC28  tbnz     w8, #5, #0x686ac34
00686AC2C  ldr      w1, [x27, #0x28]
00686AC30  b        #0x686ac44 ; 
00686AC34  ldr      x8, [x1, #0x60]
00686AC38  mov      x0, x27
00686AC3C  blr      x8
00686AC40  mov      w1, w0
00686AC44  mov      x0, x19
00686AC48  bl       #0x686b244 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<AddSkill>g__SkillSuit|34_0
00686AC4C  tbz      w0, #0, #0x686aaa0
00686AC50  adrp     x8, #0x959b000
00686AC54  ldrb     w8, [x8, #0xbab]
00686AC58  cbnz     w8, #0x686ac70
00686AC5C  adrp     x0, #0x8f23000
00686AC60  ldr      x0, [x0, #0xff0] ; GLOBAL Method$LocalModels.Bean.Skill_Synthesis.get_Skill3() @ 0x92acac0
00686AC64  bl       #0x382bd14 ; 
00686AC68  adrp     x8, #0x959b000
00686AC6C  strb     w25, [x8, #0xbab]
00686AC70  adrp     x8, #0x8f23000
00686AC74  ldr      x8, [x8, #0xff0] ; GLOBAL Method$LocalModels.Bean.Skill_Synthesis.get_Skill3() @ 0x92acac0
00686AC78  ldr      x1, [x8]
00686AC7C  ldrb     w8, [x1, #0x53]
00686AC80  tbnz     w8, #5, #0x686ac8c
00686AC84  ldr      w1, [x27, #0x2c]
00686AC88  b        #0x686ac9c ; 
00686AC8C  ldr      x8, [x1, #0x60]
00686AC90  mov      x0, x27
00686AC94  blr      x8
00686AC98  mov      w1, w0
00686AC9C  mov      x0, x19
00686ACA0  bl       #0x686b244 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<AddSkill>g__SkillSuit|34_0
00686ACA4  tbz      w0, #0, #0x686aaa0
00686ACA8  ldr      x0, [x19, #0x50]
00686ACAC  cbz      x0, #0x686adf4
00686ACB0  adrp     x8, #0x8f24000
00686ACB4  ldr      x8, [x8, #0x50] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.Add() @ 0x9228ca0
00686ACB8  ldr      x2, [x8]
00686ACBC  mov      w1, w26
00686ACC0  bl       #0x524e0bc ; Rock.Collections.OrderedHashSet<int>$$Add
00686ACC4  adrp     x8, #0x9591000
00686ACC8  ldrb     w8, [x8, #0xa4b]
00686ACCC  cbnz     w8, #0x686ace4
00686ACD0  adrp     x0, #0x8ee5000
00686ACD4  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686ACD8  bl       #0x382bd14 ; 
00686ACDC  adrp     x8, #0x9591000
00686ACE0  strb     w25, [x8, #0xa4b]
00686ACE4  adrp     x8, #0x8ee5000
00686ACE8  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686ACEC  ldr      x1, [x8]
00686ACF0  ldrb     w8, [x1, #0x53]
00686ACF4  tbnz     w8, #5, #0x686ad00
00686ACF8  ldr      x27, [x19, #0x20]
00686ACFC  b        #0x686ad10 ; 
00686AD00  ldr      x8, [x1, #0x60]
00686AD04  mov      x0, x19
00686AD08  blr      x8
00686AD0C  mov      x27, x0
00686AD10  adrp     x8, #0x8f23000
00686AD14  ldr      x8, [x8, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686AD18  ldr      x1, [x8]
00686AD1C  ldrb     w8, [x1, #0x53]
00686AD20  tbnz     w8, #5, #0x686ad2c
00686AD24  ldr      x1, [x19, #0x30]
00686AD28  b        #0x686ad3c ; 
00686AD2C  ldr      x8, [x1, #0x60]
00686AD30  mov      x0, x19
00686AD34  blr      x8
00686AD38  mov      x1, x0
00686AD3C  cbz      x27, #0x686adf0
00686AD40  mov      x0, x27
00686AD44  mov      w2, w26
00686AD48  mov      w3, wzr
00686AD4C  mov      x4, xzr
00686AD50  bl       #0x6a0dd34 ; HotFix.BattleLogic.BattleWorldContext$$AddSkillToCharacter
00686AD54  b        #0x686aaa0 ; 
00686AD58  mov      x21, xzr
00686AD5C  cbz      x20, #0x686adc0
00686AD60  adrp     x10, #0x8ebf000
00686AD64  ldr      x8, [x20]
00686AD68  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
00686AD6C  ldrh     w9, [x8, #0x12e]
00686AD70  ldr      x1, [x10]
00686AD74  cbz      x9, #0x686ad98
00686AD78  ldr      x10, [x8, #0xb0]
00686AD7C  add      x10, x10, #8
00686AD80  ldur     x11, [x10, #-8]
00686AD84  cmp      x11, x1
00686AD88  b.eq     #0x686ada8
00686AD8C  subs     x9, x9, #1
00686AD90  add      x10, x10, #0x10
00686AD94  b.ne     #0x686ad80
00686AD98  mov      x0, x20
00686AD9C  mov      w2, wzr
00686ADA0  bl       #0x3a7e710 ; 
00686ADA4  b        #0x686adb4 ; 
00686ADA8  ldrsw    x9, [x10]
00686ADAC  add      x8, x8, x9, lsl #4
00686ADB0  add      x0, x8, #0x138
00686ADB4  ldp      x8, x1, [x0]
00686ADB8  mov      x0, x20
00686ADBC  blr      x8
00686ADC0  cbnz     x21, #0x686adfc
00686ADC4  ldp      x20, x19, [sp, #0x60]
00686ADC8  ldp      x22, x21, [sp, #0x50]
00686ADCC  ldp      x24, x23, [sp, #0x40]
00686ADD0  ldp      x26, x25, [sp, #0x30]
00686ADD4  ldp      x28, x27, [sp, #0x20]
00686ADD8  ldp      x29, x30, [sp, #0x10]
00686ADDC  add      sp, sp, #0x70
00686ADE0  ret      
00686ADE4  bl       #0x382bfb8 ; 
00686ADE8  bl       #0x382bfb8 ; 
00686ADEC  bl       #0x382bfb8 ; 
00686ADF0  bl       #0x382bfb8 ; 
00686ADF4  bl       #0x382bfb8 ; 
00686ADF8  bl       #0x382bfb8 ; 
00686ADFC  mov      x0, x21
00686AE00  bl       #0x382bfb0 ; 
00686AE04  b        #0x686ae4c ; 
00686AE08  b        #0x686ae4c ; 
00686AE0C  b        #0x686ae4c ; 
00686AE10  b        #0x686ae4c ; 
00686AE14  b        #0x686ae4c ; 
00686AE18  b        #0x686ae4c ; 
00686AE1C  b        #0x686ae4c ; 
00686AE20  b        #0x686ae4c ; 
00686AE24  b        #0x686ae4c ; 
00686AE28  b        #0x686ae4c ; 
00686AE2C  b        #0x686ae4c ; 
00686AE30  b        #0x686ae4c ; 
00686AE34  b        #0x686ae4c ; 
00686AE38  b        #0x686ae4c ; 
00686AE3C  b        #0x686ae4c ; 
00686AE40  b        #0x686ae4c ; 
00686AE44  b        #0x686ae4c ; 
00686AE48  b        #0x686ae4c ; 
00686AE4C  mov      x19, x0
00686AE50  cmp      w1, #1
00686AE54  b.ne     #0x686ae6c
00686AE58  mov      x0, x19
00686AE5C  bl       #0x89eda50 ; 
00686AE60  ldr      x21, [x0]
00686AE64  bl       #0x89eda60 ; 
00686AE68  b        #0x686ad5c ; 
00686AE6C  mov      x21, xzr
00686AE70  b        #0x686ae78 ; 
00686AE74  mov      x19, x0
00686AE78  cbz      x20, #0x686aedc
00686AE7C  adrp     x10, #0x8ebf000
00686AE80  ldr      x8, [x20]
00686AE84  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
00686AE88  ldrh     w9, [x8, #0x12e]
00686AE8C  ldr      x1, [x10]
00686AE90  cbz      x9, #0x686aeb4
00686AE94  ldr      x10, [x8, #0xb0]
00686AE98  add      x10, x10, #8
00686AE9C  ldur     x11, [x10, #-8]
00686AEA0  cmp      x11, x1
00686AEA4  b.eq     #0x686aec4
00686AEA8  subs     x9, x9, #1
00686AEAC  add      x10, x10, #0x10
00686AEB0  b.ne     #0x686ae9c
00686AEB4  mov      x0, x20
00686AEB8  mov      w2, wzr
00686AEBC  bl       #0x3a7e710 ; 
00686AEC0  b        #0x686aed0 ; 
00686AEC4  ldrsw    x9, [x10]
00686AEC8  add      x8, x8, x9, lsl #4
00686AECC  add      x0, x8, #0x138
00686AED0  ldp      x8, x1, [x0]
00686AED4  mov      x0, x20
00686AED8  blr      x8
00686AEDC  cbnz     x21, #0x686aee8
00686AEE0  mov      x0, x19
00686AEE4  bl       #0x3b56bfc ; 
00686AEE8  mov      x0, x21
00686AEEC  bl       #0x382bfb0 ; 
00686AEF0  bl       #0x3442448 ; 

