; HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills
; RVA 0x685B9C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685B9C4  sub      sp, sp, #0x80
00685B9C8  stp      x29, x30, [sp, #0x20]
00685B9CC  stp      x28, x27, [sp, #0x30]
00685B9D0  stp      x26, x25, [sp, #0x40]
00685B9D4  stp      x24, x23, [sp, #0x50]
00685B9D8  stp      x22, x21, [sp, #0x60]
00685B9DC  stp      x20, x19, [sp, #0x70]
00685B9E0  str      x2, [sp, #8]
00685B9E4  str      x1, [sp, #0x18]
00685B9E8  adrp     x19, #0x959b000
00685B9EC  adrp     x23, #0x8f23000
00685B9F0  ldrb     w8, [x19, #0xa8d]
00685B9F4  ldrb     w20, [sp, #0x80]
00685B9F8  ldr      x23, [x23, #0xa30] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.GetRandomSkills() @ 0x927fe50
00685B9FC  mov      w26, w7
00685BA00  mov      x27, x6
00685BA04  mov      x25, x5
00685BA08  mov      w22, w4
00685BA0C  mov      x21, x3
00685BA10  mov      x28, x0
00685BA14  tbnz     w8, #0, #0x685ba8c
00685BA18  adrp     x0, #0x8f23000
00685BA1C  ldr      x0, [x0, #0xa30] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.GetRandomSkills() @ 0x927fe50
00685BA20  bl       #0x382bd14 ; 
00685BA24  adrp     x0, #0x8ec2000
00685BA28  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
00685BA2C  bl       #0x382bd14 ; 
00685BA30  adrp     x0, #0x8ee1000
00685BA34  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
00685BA38  bl       #0x382bd14 ; 
00685BA3C  adrp     x0, #0x8ebf000
00685BA40  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685BA44  bl       #0x382bd14 ; 
00685BA48  adrp     x0, #0x8f08000
00685BA4C  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00685BA50  bl       #0x382bd14 ; 
00685BA54  adrp     x0, #0x8f08000
00685BA58  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00685BA5C  bl       #0x382bd14 ; 
00685BA60  adrp     x0, #0x8f23000
00685BA64  ldr      x0, [x0, #0xa38] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\HeroSkillCreator.cs @ 0x92f8040
00685BA68  bl       #0x382bd14 ; 
00685BA6C  adrp     x0, #0x8f23000
00685BA70  ldr      x0, [x0, #0xa40] ; GLOBAL GetRandomSkills @ 0x92fed68
00685BA74  bl       #0x382bd14 ; 
00685BA78  adrp     x0, #0x8f23000
00685BA7C  ldr      x0, [x0, #0xa48] ; GLOBAL 剩余技能数量不足 无法随机出需要的技能 @ 0x932cdd8
00685BA80  bl       #0x382bd14 ; 
00685BA84  mov      w8, #1
00685BA88  strb     w8, [x19, #0xa8d]
00685BA8C  ldr      x8, [x23]
00685BA90  ldrb     w9, [x8, #0x53]
00685BA94  tbnz     w9, #5, #0x685bae4
00685BA98  mov      x0, x28
00685BA9C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BAA0  cbz      x0, #0x685bf1c
00685BAA4  adrp     x19, #0x9591000
00685BAA8  ldrb     w8, [x19, #0xa90]
00685BAAC  mov      x24, x0
00685BAB0  cbnz     w8, #0x685bac8
00685BAB4  adrp     x0, #0x8ee6000
00685BAB8  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00685BABC  bl       #0x382bd14 ; 
00685BAC0  mov      w8, #1
00685BAC4  strb     w8, [x19, #0xa90]
00685BAC8  adrp     x8, #0x8ee6000
00685BACC  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00685BAD0  ldr      x1, [x8]
00685BAD4  ldrb     w8, [x1, #0x53]
00685BAD8  tbnz     w8, #5, #0x685bb34
00685BADC  ldr      x0, [x24, #0x230]
00685BAE0  b        #0x685bb40 ; 
00685BAE4  ldr      x9, [x8, #0x60]
00685BAE8  str      x8, [sp, #0x88]
00685BAEC  and      w8, w20, #1
00685BAF0  and      w7, w26, #1
00685BAF4  mov      x0, x28
00685BAF8  ldr      x1, [sp, #0x18]
00685BAFC  ldr      x2, [sp, #8]
00685BB00  mov      x3, x21
00685BB04  mov      w4, w22
00685BB08  mov      x5, x25
00685BB0C  mov      x6, x27
00685BB10  ldp      x20, x19, [sp, #0x70]
00685BB14  ldp      x22, x21, [sp, #0x60]
00685BB18  ldp      x24, x23, [sp, #0x50]
00685BB1C  ldp      x26, x25, [sp, #0x40]
00685BB20  ldp      x28, x27, [sp, #0x30]
00685BB24  ldp      x29, x30, [sp, #0x20]
00685BB28  strb     w8, [sp, #0x80]
00685BB2C  add      sp, sp, #0x80
00685BB30  br       x9
00685BB34  ldr      x8, [x1, #0x60]
00685BB38  mov      x0, x24
00685BB3C  blr      x8
00685BB40  cbz      x0, #0x685bf1c
00685BB44  adrp     x8, #0x8f08000
00685BB48  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00685BB4C  ldr      x1, [x8]
00685BB50  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
00685BB54  ldr      x2, [sp, #8]
00685BB58  mov      x1, x0
00685BB5C  mov      x0, x28
00685BB60  str      x1, [sp]
00685BB64  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
00685BB68  cbz      x27, #0x685bf1c
00685BB6C  ldr      x29, [x27, #0x18]
00685BB70  tbz      w20, #0, #0x685bb80
00685BB74  ldr      w8, [x25]
00685BB78  str      w8, [sp, #0x14]
00685BB7C  b        #0x685bcd4 ; 
00685BB80  mov      x20, x28
00685BB84  mov      w23, w26
00685BB88  cmp      w29, #1
00685BB8C  b.lt     #0x685bbb0
00685BB90  mov      w28, wzr
00685BB94  and      x8, x29, #0xffffffff
00685BB98  add      x9, x27, #0x20
00685BB9C  ldr      w10, [x9], #4
00685BBA0  subs     x8, x8, #1
00685BBA4  add      w28, w10, w28
00685BBA8  b.ne     #0x685bb9c
00685BBAC  b        #0x685bbb4 ; 
00685BBB0  mov      w28, wzr
00685BBB4  mov      x0, x20
00685BBB8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BBBC  cbz      x0, #0x685bf1c
00685BBC0  adrp     x19, #0x9599000
00685BBC4  ldrb     w8, [x19, #0xac6]
00685BBC8  mov      x26, x0
00685BBCC  cbnz     w8, #0x685bbe4
00685BBD0  adrp     x0, #0x8f0d000
00685BBD4  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
00685BBD8  bl       #0x382bd14 ; 
00685BBDC  mov      w8, #1
00685BBE0  strb     w8, [x19, #0xac6]
00685BBE4  adrp     x8, #0x8f0d000
00685BBE8  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
00685BBEC  ldr      x3, [x8]
00685BBF0  ldrb     w8, [x3, #0x53]
00685BBF4  tbnz     w8, #5, #0x685bc34
00685BBF8  adrp     x19, #0x9599000
00685BBFC  ldrb     w8, [x19, #0xac7]
00685BC00  cbnz     w8, #0x685bc18
00685BC04  adrp     x0, #0x8f0d000
00685BC08  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
00685BC0C  bl       #0x382bd14 ; 
00685BC10  mov      w8, #1
00685BC14  strb     w8, [x19, #0xac7]
00685BC18  adrp     x8, #0x8f0d000
00685BC1C  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
00685BC20  ldr      x1, [x8]
00685BC24  ldrb     w8, [x1, #0x53]
00685BC28  tbnz     w8, #5, #0x685bc4c
00685BC2C  ldr      x0, [x26, #0x260]
00685BC30  b        #0x685bc58 ; 
00685BC34  ldr      x8, [x3, #0x60]
00685BC38  mov      x0, x26
00685BC3C  mov      w1, wzr
00685BC40  mov      w2, w28
00685BC44  blr      x8
00685BC48  b        #0x685bc78 ; 
00685BC4C  ldr      x8, [x1, #0x60]
00685BC50  mov      x0, x26
00685BC54  blr      x8
00685BC58  cbz      x0, #0x685bf1c
00685BC5C  mov      w1, wzr
00685BC60  mov      w2, w28
00685BC64  mov      x3, xzr
00685BC68  bl       #0x416d068 ; XXRandom$$Next
00685BC6C  ldr      w8, [x26, #0x32c]
00685BC70  add      w8, w8, #1
00685BC74  str      w8, [x26, #0x32c]
00685BC78  subs     w8, w29, #1
00685BC7C  mov      x28, x20
00685BC80  b.lt     #0x685bcb8
00685BC84  ldr      w11, [x27, #0x18]
00685BC88  mov      w10, wzr
00685BC8C  mov      w9, wzr
00685BC90  cmp      w11, w9
00685BC94  b.eq     #0x685bf20
00685BC98  add      x12, x27, w9, sxtw #2
00685BC9C  ldr      w12, [x12, #0x20]
00685BCA0  add      w10, w12, w10
00685BCA4  cmp      w0, w10
00685BCA8  b.lt     #0x685bcbc
00685BCAC  add      w9, w9, #1
00685BCB0  cmp      w29, w9
00685BCB4  b.ne     #0x685bc90
00685BCB8  mov      w9, wzr
00685BCBC  cmp      w9, w8
00685BCC0  cset     w8, lt
00685BCC4  and      w8, w8, w23
00685BCC8  add      w8, w9, w8
00685BCCC  str      w8, [sp, #0x14]
00685BCD0  str      w8, [x25]
00685BCD4  mov      x0, x28
00685BCD8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BCDC  cbz      x0, #0x685bf1c
00685BCE0  ldrb     w8, [x0, #0x25]
00685BCE4  cbz      w8, #0x685bd04
00685BCE8  mov      x0, x28
00685BCEC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BCF0  cbz      x0, #0x685bf1c
00685BCF4  ldr      w8, [x0, #0x28]
00685BCF8  sub      w8, w8, #1
00685BCFC  str      w8, [sp, #0x14]
00685BD00  str      w8, [x25]
00685BD04  subs     w24, w29, #1
00685BD08  b.mi     #0x685be34
00685BD0C  cmp      w22, #1
00685BD10  b.lt     #0x685be34
00685BD14  cbz      x21, #0x685bf1c
00685BD18  mov      w20, wzr
00685BD1C  mov      w25, w22
00685BD20  ldr      w9, [sp, #0x14]
00685BD24  ldr      w8, [x21, #0x18]
00685BD28  add      w9, w9, w20
00685BD2C  sdiv     w10, w9, w29
00685BD30  msub     w19, w10, w29, w9
00685BD34  cmp      w19, w8
00685BD38  b.hs     #0x685bf20
00685BD3C  add      x8, x21, w19, sxtw #3
00685BD40  ldr      x26, [x8, #0x20]
00685BD44  cbz      x26, #0x685bf1c
00685BD48  ldr      x1, [sp, #0x18]
00685BD4C  mov      x0, x26
00685BD50  mov      x2, xzr
00685BD54  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685BD58  cmp      w0, #1
00685BD5C  b.lt     #0x685be14
00685BD60  mov      w27, w0
00685BD64  mov      x0, x28
00685BD68  mov      x23, x21
00685BD6C  mov      w21, w22
00685BD70  mov      x22, x28
00685BD74  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BD78  cbz      x0, #0x685bf1c
00685BD7C  mov      x1, xzr
00685BD80  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00685BD84  adrp     x8, #0x8ebf000
00685BD88  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685BD8C  mov      w28, w0
00685BD90  ldr      x8, [x8]
00685BD94  ldr      w9, [x8, #0xe0]
00685BD98  cbnz     w9, #0x685bda4
00685BD9C  mov      x0, x8
00685BDA0  bl       #0x382be8c ; 
00685BDA4  mov      w0, w27
00685BDA8  mov      w1, w25
00685BDAC  mov      x2, xzr
00685BDB0  bl       #0x7bd69a0 ; System.Math$$Min
00685BDB4  mov      w27, w0
00685BDB8  tbz      w28, #0, #0x685bde8
00685BDBC  ldr      x28, [sp, #0x18]
00685BDC0  mov      x0, x26
00685BDC4  mov      x2, xzr
00685BDC8  mov      x1, x28
00685BDCC  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685BDD0  mov      w1, w0
00685BDD4  mov      w0, w27
00685BDD8  mov      x2, xzr
00685BDDC  bl       #0x7bd69a0 ; System.Math$$Min
00685BDE0  mov      w27, w0
00685BDE4  b        #0x685bdec ; 
00685BDE8  ldr      x28, [sp, #0x18]
00685BDEC  ldp      x4, x3, [sp]
00685BDF0  mov      x0, x26
00685BDF4  mov      w1, w27
00685BDF8  mov      x2, x28
00685BDFC  mov      x5, xzr
00685BE00  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
00685BE04  sub      w25, w25, w27
00685BE08  mov      x28, x22
00685BE0C  mov      w22, w21
00685BE10  mov      x21, x23
00685BE14  cmp      w22, #1
00685BE18  b.ne     #0x685be20
00685BE1C  str      w19, [x28, #0x60]
00685BE20  add      w20, w20, #1
00685BE24  cmp      w20, w24
00685BE28  b.gt     #0x685be34
00685BE2C  cmp      w25, #0
00685BE30  b.gt     #0x685bd20
00685BE34  ldr      x8, [sp, #0x18]
00685BE38  cbz      x8, #0x685bf1c
00685BE3C  ldr      w8, [x8, #0x18]
00685BE40  adrp     x20, #0x9591000
00685BE44  cmp      w8, w22
00685BE48  b.ge     #0x685be94
00685BE4C  adrp     x8, #0x8ee1000
00685BE50  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
00685BE54  ldr      x0, [x8]
00685BE58  ldr      w8, [x0, #0xe0]
00685BE5C  cbnz     w8, #0x685be64
00685BE60  bl       #0x382be8c ; 
00685BE64  adrp     x8, #0x8f23000
00685BE68  adrp     x9, #0x8f23000
00685BE6C  adrp     x10, #0x8f23000
00685BE70  ldr      x8, [x8, #0xa48] ; GLOBAL 剩余技能数量不足 无法随机出需要的技能 @ 0x932cdd8
00685BE74  ldr      x9, [x9, #0xa40] ; GLOBAL GetRandomSkills @ 0x92fed68
00685BE78  ldr      x10, [x10, #0xa38] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\HeroSkillCreator.cs @ 0x92f8040
00685BE7C  mov      w3, #0x185
00685BE80  ldr      x0, [x8]
00685BE84  ldr      x1, [x9]
00685BE88  ldr      x2, [x10]
00685BE8C  mov      x4, xzr
00685BE90  bl       #0x7997754 ; Logger$$LogError
00685BE94  mov      x0, x28
00685BE98  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BE9C  cbz      x0, #0x685bf1c
00685BEA0  ldrb     w8, [x20, #0xa90]
00685BEA4  mov      x19, x0
00685BEA8  cbnz     w8, #0x685bec0
00685BEAC  adrp     x0, #0x8ee6000
00685BEB0  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00685BEB4  bl       #0x382bd14 ; 
00685BEB8  mov      w8, #1
00685BEBC  strb     w8, [x20, #0xa90]
00685BEC0  adrp     x8, #0x8ee6000
00685BEC4  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00685BEC8  ldr      x1, [x8]
00685BECC  ldrb     w8, [x1, #0x53]
00685BED0  tbnz     w8, #5, #0x685bedc
00685BED4  ldr      x0, [x19, #0x230]
00685BED8  b        #0x685bee8 ; 
00685BEDC  ldr      x8, [x1, #0x60]
00685BEE0  mov      x0, x19
00685BEE4  blr      x8
00685BEE8  cbz      x0, #0x685bf1c
00685BEEC  adrp     x8, #0x8f08000
00685BEF0  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00685BEF4  ldr      x1, [sp]
00685BEF8  ldp      x20, x19, [sp, #0x70]
00685BEFC  ldp      x22, x21, [sp, #0x60]
00685BF00  ldr      x2, [x8]
00685BF04  ldp      x24, x23, [sp, #0x50]
00685BF08  ldp      x26, x25, [sp, #0x40]
00685BF0C  ldp      x28, x27, [sp, #0x30]
00685BF10  ldp      x29, x30, [sp, #0x20]
00685BF14  add      sp, sp, #0x80
00685BF18  b        #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
00685BF1C  bl       #0x382bfb8 ; 
00685BF20  bl       #0x382bfc0 ; 

