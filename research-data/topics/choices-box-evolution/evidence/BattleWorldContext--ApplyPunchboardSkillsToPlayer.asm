; HotFix.BattleLogic.BattleWorldContext$$ApplyPunchboardSkillsToPlayer
; RVA 0x6A1F3E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A1F3E0  stp      x29, x30, [sp, #-0x60]!
006A1F3E4  stp      x28, x27, [sp, #0x10]
006A1F3E8  stp      x26, x25, [sp, #0x20]
006A1F3EC  stp      x24, x23, [sp, #0x30]
006A1F3F0  stp      x22, x21, [sp, #0x40]
006A1F3F4  stp      x20, x19, [sp, #0x50]
006A1F3F8  adrp     x22, #0x959d000
006A1F3FC  adrp     x23, #0x8f33000
006A1F400  ldrb     w8, [x22, #0x61c]
006A1F404  ldr      x23, [x23, #0x3b0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.ApplyPunchboardSkillsToPlayer() @ 0x923f618
006A1F408  mov      x19, x2
006A1F40C  mov      x21, x1
006A1F410  mov      x20, x0
006A1F414  tbnz     w8, #0, #0x6a1f474
006A1F418  adrp     x0, #0x8f33000
006A1F41C  ldr      x0, [x0, #0x3b0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.ApplyPunchboardSkillsToPlayer() @ 0x923f618
006A1F420  bl       #0x382bd14 ; 
006A1F424  adrp     x0, #0x8f07000
006A1F428  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006A1F42C  bl       #0x382bd14 ; 
006A1F430  adrp     x0, #0x8ec2000
006A1F434  ldr      x0, [x0, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006A1F438  bl       #0x382bd14 ; 
006A1F43C  adrp     x0, #0x8f09000
006A1F440  ldr      x0, [x0, #0xa0] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Count() @ 0x921f560
006A1F444  bl       #0x382bd14 ; 
006A1F448  adrp     x0, #0x8f09000
006A1F44C  ldr      x0, [x0, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
006A1F450  bl       #0x382bd14 ; 
006A1F454  adrp     x0, #0x8f08000
006A1F458  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006A1F45C  bl       #0x382bd14 ; 
006A1F460  adrp     x0, #0x8f08000
006A1F464  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006A1F468  bl       #0x382bd14 ; 
006A1F46C  mov      w8, #1
006A1F470  strb     w8, [x22, #0x61c]
006A1F474  ldr      x3, [x23]
006A1F478  ldrb     w8, [x3, #0x53]
006A1F47C  tbnz     w8, #5, #0x6a1f4bc
006A1F480  adrp     x24, #0x9591000
006A1F484  ldrb     w8, [x24, #0xa90]
006A1F488  cbnz     w8, #0x6a1f4a0
006A1F48C  adrp     x0, #0x8ee6000
006A1F490  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006A1F494  bl       #0x382bd14 ; 
006A1F498  mov      w8, #1
006A1F49C  strb     w8, [x24, #0xa90]
006A1F4A0  adrp     x25, #0x8ee6000
006A1F4A4  ldr      x25, [x25, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006A1F4A8  ldr      x1, [x25]
006A1F4AC  ldrb     w8, [x1, #0x53]
006A1F4B0  tbnz     w8, #5, #0x6a1f4e8
006A1F4B4  ldr      x0, [x20, #0x230]
006A1F4B8  b        #0x6a1f4f4 ; 
006A1F4BC  ldr      x4, [x3, #0x60]
006A1F4C0  mov      x0, x20
006A1F4C4  mov      x1, x21
006A1F4C8  mov      x2, x19
006A1F4CC  ldp      x20, x19, [sp, #0x50]
006A1F4D0  ldp      x22, x21, [sp, #0x40]
006A1F4D4  ldp      x24, x23, [sp, #0x30]
006A1F4D8  ldp      x26, x25, [sp, #0x20]
006A1F4DC  ldp      x28, x27, [sp, #0x10]
006A1F4E0  ldp      x29, x30, [sp], #0x60
006A1F4E4  br       x4
006A1F4E8  ldr      x8, [x1, #0x60]
006A1F4EC  mov      x0, x20
006A1F4F0  blr      x8
006A1F4F4  cbz      x0, #0x6a1f894
006A1F4F8  adrp     x8, #0x8f08000
006A1F4FC  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006A1F500  ldr      x1, [x8]
006A1F504  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006A1F508  cbz      x19, #0x6a1f894
006A1F50C  ldr      w8, [x19, #0x18]
006A1F510  mov      x22, x0
006A1F514  cmp      w8, #1
006A1F518  b.lt     #0x6a1f5a8
006A1F51C  adrp     x26, #0x8f09000
006A1F520  adrp     x27, #0x8ec2000
006A1F524  ldr      x26, [x26, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
006A1F528  ldr      x27, [x27, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006A1F52C  mov      w23, wzr
006A1F530  ldr      x2, [x26]
006A1F534  mov      x0, x19
006A1F538  mov      w1, w23
006A1F53C  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006A1F540  cbz      x22, #0x6a1f894
006A1F544  ldr      w10, [x22, #0x1c]
006A1F548  ldr      x8, [x22, #0x10]
006A1F54C  ldr      x9, [x27]
006A1F550  add      w10, w10, #1
006A1F554  str      w10, [x22, #0x1c]
006A1F558  cbz      x8, #0x6a1f894
006A1F55C  ldrsw    x10, [x22, #0x18]
006A1F560  ldr      w11, [x8, #0x18]
006A1F564  lsr      x1, x0, #0x20
006A1F568  cmp      w10, w11
006A1F56C  b.hs     #0x6a1f584
006A1F570  add      w9, w10, #1
006A1F574  add      x8, x8, x10, lsl #2
006A1F578  str      w9, [x22, #0x18]
006A1F57C  str      w1, [x8, #0x20]
006A1F580  b        #0x6a1f598 ; 
006A1F584  ldr      x8, [x9, #0x20]
006A1F588  mov      x0, x22
006A1F58C  ldr      x8, [x8, #0xc0]
006A1F590  ldr      x2, [x8, #0x70]
006A1F594  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006A1F598  ldr      w8, [x19, #0x18]
006A1F59C  add      w23, w23, #1
006A1F5A0  cmp      w23, w8
006A1F5A4  b.lt     #0x6a1f530
006A1F5A8  cbz      x21, #0x6a1f894
006A1F5AC  mov      x0, x21
006A1F5B0  mov      x1, xzr
006A1F5B4  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
006A1F5B8  mov      w3, w0
006A1F5BC  mov      w1, #7
006A1F5C0  mov      x0, x20
006A1F5C4  mov      x2, x22
006A1F5C8  bl       #0x6a0857c ; HotFix.BattleLogic.BattleWorldContext$$DispatchCloseUIEvent
006A1F5CC  ldrb     w8, [x24, #0xa90]
006A1F5D0  cbnz     w8, #0x6a1f5e8
006A1F5D4  adrp     x0, #0x8ee6000
006A1F5D8  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006A1F5DC  bl       #0x382bd14 ; 
006A1F5E0  mov      w8, #1
006A1F5E4  strb     w8, [x24, #0xa90]
006A1F5E8  ldr      x1, [x25]
006A1F5EC  ldrb     w8, [x1, #0x53]
006A1F5F0  tbnz     w8, #5, #0x6a1f5fc
006A1F5F4  ldr      x0, [x20, #0x230]
006A1F5F8  b        #0x6a1f608 ; 
006A1F5FC  ldr      x8, [x1, #0x60]
006A1F600  mov      x0, x20
006A1F604  blr      x8
006A1F608  cbz      x0, #0x6a1f894
006A1F60C  adrp     x8, #0x8f08000
006A1F610  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006A1F614  mov      x1, x22
006A1F618  ldr      x2, [x8]
006A1F61C  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
006A1F620  adrp     x8, #0x8f07000
006A1F624  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006A1F628  mov      x0, x21
006A1F62C  ldr      x1, [x8]
006A1F630  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006A1F634  ldr      w8, [x19, #0x18]
006A1F638  cmp      w8, #1
006A1F63C  b.lt     #0x6a1f878
006A1F640  mov      x22, x0
006A1F644  cbz      x0, #0x6a1f894
006A1F648  adrp     x24, #0x8f09000
006A1F64C  adrp     x26, #0x8f09000
006A1F650  ldr      x24, [x24, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_SkillCreator() @ 0x927fb18
006A1F654  ldr      x26, [x26, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
006A1F658  mov      w23, wzr
006A1F65C  adrp     x27, #0x9599000
006A1F660  mov      w28, #1
006A1F664  ldrb     w8, [x27, #0x4c6]
006A1F668  cbnz     w8, #0x6a1f678
006A1F66C  mov      x0, x24
006A1F670  bl       #0x382bd14 ; 
006A1F674  strb     w28, [x27, #0x4c6]
006A1F678  ldr      x1, [x24]
006A1F67C  ldrb     w8, [x1, #0x53]
006A1F680  tbnz     w8, #5, #0x6a1f68c
006A1F684  ldr      x25, [x22, #0x88]
006A1F688  b        #0x6a1f69c ; 
006A1F68C  ldr      x8, [x1, #0x60]
006A1F690  mov      x0, x22
006A1F694  blr      x8
006A1F698  mov      x25, x0
006A1F69C  ldr      x2, [x26]
006A1F6A0  mov      x0, x19
006A1F6A4  mov      w1, w23
006A1F6A8  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006A1F6AC  cbz      x25, #0x6a1f894
006A1F6B0  ldr      x8, [x25]
006A1F6B4  mov      x1, x0
006A1F6B8  mov      x0, x25
006A1F6BC  ldr      x9, [x8, #0x258]
006A1F6C0  ldr      x2, [x8, #0x260]
006A1F6C4  blr      x9
006A1F6C8  ldr      w8, [x19, #0x18]
006A1F6CC  add      w23, w23, #1
006A1F6D0  cmp      w23, w8
006A1F6D4  b.lt     #0x6a1f664
006A1F6D8  cmp      w8, #1
006A1F6DC  b.lt     #0x6a1f878
006A1F6E0  adrp     x23, #0x8f06000
006A1F6E4  adrp     x24, #0x8ef9000
006A1F6E8  ldr      x23, [x23, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006A1F6EC  ldr      x24, [x24, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006A1F6F0  mov      w22, wzr
006A1F6F4  adrp     x27, #0x9598000
006A1F6F8  mov      w28, #1
006A1F6FC  adrp     x29, #0x9598000
006A1F700  ldrb     w8, [x27, #0xfcc]
006A1F704  cbnz     w8, #0x6a1f714
006A1F708  mov      x0, x23
006A1F70C  bl       #0x382bd14 ; 
006A1F710  strb     w28, [x27, #0xfcc]
006A1F714  ldr      x1, [x23]
006A1F718  ldrb     w8, [x1, #0x53]
006A1F71C  tbnz     w8, #5, #0x6a1f728
006A1F720  ldr      x25, [x20, #0x200]
006A1F724  b        #0x6a1f738 ; 
006A1F728  ldr      x8, [x1, #0x60]
006A1F72C  mov      x0, x20
006A1F730  blr      x8
006A1F734  mov      x25, x0
006A1F738  ldr      x2, [x26]
006A1F73C  mov      x0, x19
006A1F740  mov      w1, w22
006A1F744  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006A1F748  cbz      x25, #0x6a1f894
006A1F74C  mov      x1, x0
006A1F750  mov      x0, x25
006A1F754  mov      x2, xzr
006A1F758  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006A1F75C  cbz      x0, #0x6a1f894
006A1F760  ldrb     w8, [x29, #0x35e]
006A1F764  mov      x25, x0
006A1F768  cbnz     w8, #0x6a1f778
006A1F76C  mov      x0, x24
006A1F770  bl       #0x382bd14 ; 
006A1F774  strb     w28, [x29, #0x35e]
006A1F778  ldr      x1, [x24]
006A1F77C  ldrb     w8, [x1, #0x53]
006A1F780  tbnz     w8, #5, #0x6a1f78c
006A1F784  ldr      w0, [x25, #0x68]
006A1F788  b        #0x6a1f798 ; 
006A1F78C  ldr      x8, [x1, #0x60]
006A1F790  mov      x0, x25
006A1F794  blr      x8
006A1F798  cmp      w0, #4
006A1F79C  b.eq     #0x6a1f7dc
006A1F7A0  ldrb     w8, [x29, #0x35e]
006A1F7A4  cbnz     w8, #0x6a1f7b4
006A1F7A8  mov      x0, x24
006A1F7AC  bl       #0x382bd14 ; 
006A1F7B0  strb     w28, [x29, #0x35e]
006A1F7B4  ldr      x1, [x24]
006A1F7B8  ldrb     w8, [x1, #0x53]
006A1F7BC  tbnz     w8, #5, #0x6a1f7c8
006A1F7C0  ldr      w0, [x25, #0x68]
006A1F7C4  b        #0x6a1f7d4 ; 
006A1F7C8  ldr      x8, [x1, #0x60]
006A1F7CC  mov      x0, x25
006A1F7D0  blr      x8
006A1F7D4  cmp      w0, #5
006A1F7D8  b.ne     #0x6a1f830
006A1F7DC  ldr      x2, [x26]
006A1F7E0  mov      x0, x19
006A1F7E4  mov      w1, w22
006A1F7E8  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006A1F7EC  ldr      x2, [x26]
006A1F7F0  mov      x25, x0
006A1F7F4  mov      x0, x19
006A1F7F8  mov      w1, w22
006A1F7FC  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006A1F800  lsr      x8, x0, #0x20
006A1F804  cmp      w25, w8
006A1F808  b.eq     #0x6a1f830
006A1F80C  ldr      x2, [x26]
006A1F810  mov      x0, x19
006A1F814  mov      w1, w22
006A1F818  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006A1F81C  lsr      x2, x0, #0x20
006A1F820  mov      w3, #1
006A1F824  mov      x0, x20
006A1F828  mov      x1, x21
006A1F82C  bl       #0x6a0dd34 ; HotFix.BattleLogic.BattleWorldContext$$AddSkillToCharacter
006A1F830  ldr      x2, [x26]
006A1F834  mov      x0, x19
006A1F838  mov      w1, w22
006A1F83C  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006A1F840  mov      x2, x0
006A1F844  mov      w3, #1
006A1F848  mov      x0, x20
006A1F84C  mov      x1, x21
006A1F850  bl       #0x6a0dd34 ; HotFix.BattleLogic.BattleWorldContext$$AddSkillToCharacter
006A1F854  tbz      w0, #0, #0x6a1f86c
006A1F858  ldr      w8, [x19, #0x18]
006A1F85C  add      w22, w22, #1
006A1F860  cmp      w22, w8
006A1F864  b.lt     #0x6a1f700
006A1F868  b        #0x6a1f878 ; 
006A1F86C  ldr      w8, [x20, #0x284]
006A1F870  orr      w8, w8, #8
006A1F874  str      w8, [x20, #0x284]
006A1F878  ldp      x20, x19, [sp, #0x50]
006A1F87C  ldp      x22, x21, [sp, #0x40]
006A1F880  ldp      x24, x23, [sp, #0x30]
006A1F884  ldp      x26, x25, [sp, #0x20]
006A1F888  ldp      x28, x27, [sp, #0x10]
006A1F88C  ldp      x29, x30, [sp], #0x60
006A1F890  ret      
006A1F894  bl       #0x382bfb8 ; 

