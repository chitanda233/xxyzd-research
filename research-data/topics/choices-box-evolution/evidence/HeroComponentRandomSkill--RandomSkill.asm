; HotFix.BattleLogic.HeroComponentRandomSkill$$RandomSkill
; RVA 0x686C998; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C998  sub      sp, sp, #0x80
00686C99C  stp      x29, x30, [sp, #0x20]
00686C9A0  stp      x28, x27, [sp, #0x30]
00686C9A4  stp      x26, x25, [sp, #0x40]
00686C9A8  stp      x24, x23, [sp, #0x50]
00686C9AC  stp      x22, x21, [sp, #0x60]
00686C9B0  stp      x20, x19, [sp, #0x70]
00686C9B4  adrp     x20, #0x959b000
00686C9B8  adrp     x21, #0x8f24000
00686C9BC  ldrb     w8, [x20, #0xa50]
00686C9C0  ldr      x21, [x21, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.RandomSkill() @ 0x927fa88
00686C9C4  mov      w24, w5
00686C9C8  mov      w29, w4
00686C9CC  mov      w28, w3
00686C9D0  mov      w25, w2
00686C9D4  mov      w26, w1
00686C9D8  mov      x19, x0
00686C9DC  tbnz     w8, #0, #0x686ca84
00686C9E0  adrp     x0, #0x8f09000
00686C9E4  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00686C9E8  bl       #0x382bd14 ; 
00686C9EC  adrp     x0, #0x8ee6000
00686C9F0  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686C9F4  bl       #0x382bd14 ; 
00686C9F8  adrp     x0, #0x8f23000
00686C9FC  ldr      x0, [x0, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686CA00  bl       #0x382bd14 ; 
00686CA04  adrp     x0, #0x8ee3000
00686CA08  ldr      x0, [x0, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
00686CA0C  bl       #0x382bd14 ; 
00686CA10  adrp     x0, #0x8f24000
00686CA14  ldr      x0, [x0, #0x1e8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.RandomSkill() @ 0x927fa88
00686CA18  bl       #0x382bd14 ; 
00686CA1C  adrp     x0, #0x8f08000
00686CA20  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
00686CA24  bl       #0x382bd14 ; 
00686CA28  adrp     x0, #0x8ee1000
00686CA2C  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
00686CA30  bl       #0x382bd14 ; 
00686CA34  adrp     x0, #0x8f08000
00686CA38  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00686CA3C  bl       #0x382bd14 ; 
00686CA40  adrp     x0, #0x8f08000
00686CA44  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00686CA48  bl       #0x382bd14 ; 
00686CA4C  adrp     x0, #0x8f0a000
00686CA50  ldr      x0, [x0, #0x618] ; GLOBAL RefreshCount @ 0x930b5a0
00686CA54  bl       #0x382bd14 ; 
00686CA58  adrp     x0, #0x8f08000
00686CA5C  ldr      x0, [x0, #0xf38] ; GLOBAL RandomSkill @ 0x930b040
00686CA60  bl       #0x382bd14 ; 
00686CA64  adrp     x0, #0x8f24000
00686CA68  ldr      x0, [x0, #0x1f0] ; GLOBAL 刷新次数不足 @ 0x932cdc0
00686CA6C  bl       #0x382bd14 ; 
00686CA70  adrp     x0, #0x8f24000
00686CA74  ldr      x0, [x0, #0x1f8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\HeroComponentRandomSkill.cs @ 0x92f8030
00686CA78  bl       #0x382bd14 ; 
00686CA7C  mov      w8, #1
00686CA80  strb     w8, [x20, #0xa50]
00686CA84  ldr      x6, [x21]
00686CA88  ldrb     w8, [x6, #0x53]
00686CA8C  tbnz     w8, #5, #0x686cab0
00686CA90  adrp     x27, #0x8f23000
00686CA94  ldr      x27, [x27, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686CA98  str      wzr, [sp, #0x1c]
00686CA9C  ldr      x1, [x27]
00686CAA0  ldrb     w8, [x1, #0x53]
00686CAA4  tbnz     w8, #5, #0x686caec
00686CAA8  ldr      x0, [x19, #0x30]
00686CAAC  b        #0x686caf8 ; 
00686CAB0  ldr      x7, [x6, #0x60]
00686CAB4  and      w1, w26, #1
00686CAB8  and      w5, w24, #1
00686CABC  mov      x0, x19
00686CAC0  mov      w2, w25
00686CAC4  mov      w3, w28
00686CAC8  mov      w4, w29
00686CACC  ldp      x20, x19, [sp, #0x70]
00686CAD0  ldp      x22, x21, [sp, #0x60]
00686CAD4  ldp      x24, x23, [sp, #0x50]
00686CAD8  ldp      x26, x25, [sp, #0x40]
00686CADC  ldp      x28, x27, [sp, #0x30]
00686CAE0  ldp      x29, x30, [sp, #0x20]
00686CAE4  add      sp, sp, #0x80
00686CAE8  br       x7
00686CAEC  ldr      x8, [x1, #0x60]
00686CAF0  mov      x0, x19
00686CAF4  blr      x8
00686CAF8  cbz      x0, #0x686de0c
00686CAFC  adrp     x8, #0x8ee6000
00686CB00  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686CB04  ldr      x1, [x8]
00686CB08  ldrb     w8, [x1, #0x53]
00686CB0C  tbnz     w8, #5, #0x686cb18
00686CB10  ldr      x23, [x0, #0x38]
00686CB14  b        #0x686cb24 ; 
00686CB18  ldr      x8, [x1, #0x60]
00686CB1C  blr      x8
00686CB20  mov      x23, x0
00686CB24  cbz      x23, #0x686de0c
00686CB28  adrp     x21, #0x9591000
00686CB2C  ldrb     w8, [x21, #0xa7f]
00686CB30  cbnz     w8, #0x686cb48
00686CB34  adrp     x0, #0x8ee6000
00686CB38  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686CB3C  bl       #0x382bd14 ; 
00686CB40  mov      w8, #1
00686CB44  strb     w8, [x21, #0xa7f]
00686CB48  adrp     x8, #0x8ee6000
00686CB4C  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686CB50  ldr      x1, [x8]
00686CB54  ldrb     w8, [x1, #0x53]
00686CB58  tbnz     w8, #5, #0x686cb64
00686CB5C  ldr      x0, [x23, #0x178]
00686CB60  b        #0x686cb70 ; 
00686CB64  ldr      x8, [x1, #0x60]
00686CB68  mov      x0, x23
00686CB6C  blr      x8
00686CB70  cbz      x0, #0x686de0c
00686CB74  adrp     x20, #0x8f0a000
00686CB78  ldr      x20, [x20, #0x618] ; GLOBAL RefreshCount @ 0x930b5a0
00686CB7C  mov      x2, xzr
00686CB80  ldr      x1, [x20]
00686CB84  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686CB88  lsr      x22, x0, #0x10
00686CB8C  tbz      w26, #0, #0x686cbac
00686CB90  cmp      w22, #0
00686CB94  b.le     #0x686cbc0
00686CB98  ldr      x1, [x27]
00686CB9C  ldrb     w8, [x1, #0x53]
00686CBA0  tbnz     w8, #5, #0x686cc0c
00686CBA4  ldr      x0, [x19, #0x30]
00686CBA8  b        #0x686cc18 ; 
00686CBAC  mov      x0, x19
00686CBB0  str      w28, [sp, #8]
00686CBB4  bl       #0x686de10 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckQualityUp
00686CBB8  mov      w28, w0
00686CBBC  b        #0x686ccb4 ; 
00686CBC0  adrp     x8, #0x8ee1000
00686CBC4  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
00686CBC8  ldr      x0, [x8]
00686CBCC  ldr      w8, [x0, #0xe0]
00686CBD0  cbnz     w8, #0x686cbd8
00686CBD4  bl       #0x382be8c ; 
00686CBD8  adrp     x8, #0x8f24000
00686CBDC  adrp     x9, #0x8f08000
00686CBE0  adrp     x10, #0x8f24000
00686CBE4  ldr      x8, [x8, #0x1f0] ; GLOBAL 刷新次数不足 @ 0x932cdc0
00686CBE8  ldr      x9, [x9, #0xf38] ; GLOBAL RandomSkill @ 0x930b040
00686CBEC  ldr      x10, [x10, #0x1f8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\HeroComponentRandomSkill.cs @ 0x92f8030
00686CBF0  mov      w3, #0x224
00686CBF4  ldr      x0, [x8]
00686CBF8  ldr      x1, [x9]
00686CBFC  ldr      x2, [x10]
00686CC00  mov      x4, xzr
00686CC04  bl       #0x7997754 ; Logger$$LogError
00686CC08  b        #0x686ddec ; 
00686CC0C  ldr      x8, [x1, #0x60]
00686CC10  mov      x0, x19
00686CC14  blr      x8
00686CC18  cbz      x0, #0x686de0c
00686CC1C  adrp     x8, #0x8ee6000
00686CC20  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686CC24  ldr      x1, [x8]
00686CC28  ldrb     w8, [x1, #0x53]
00686CC2C  tbnz     w8, #5, #0x686cc38
00686CC30  ldr      x23, [x0, #0x38]
00686CC34  b        #0x686cc44 ; 
00686CC38  ldr      x8, [x1, #0x60]
00686CC3C  blr      x8
00686CC40  mov      x23, x0
00686CC44  cbz      x23, #0x686de0c
00686CC48  ldrb     w8, [x21, #0xa7f]
00686CC4C  cbnz     w8, #0x686cc64
00686CC50  adrp     x0, #0x8ee6000
00686CC54  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686CC58  bl       #0x382bd14 ; 
00686CC5C  mov      w8, #1
00686CC60  strb     w8, [x21, #0xa7f]
00686CC64  adrp     x8, #0x8ee6000
00686CC68  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686CC6C  ldr      x1, [x8]
00686CC70  ldrb     w8, [x1, #0x53]
00686CC74  tbnz     w8, #5, #0x686cc80
00686CC78  ldr      x0, [x23, #0x178]
00686CC7C  b        #0x686cc8c ; 
00686CC80  ldr      x8, [x1, #0x60]
00686CC84  mov      x0, x23
00686CC88  blr      x8
00686CC8C  str      w28, [sp, #8]
00686CC90  cbz      x0, #0x686de0c
00686CC94  ldr      x8, [x0]
00686CC98  ldr      x1, [x20]
00686CC9C  sub      w22, w22, #1
00686CCA0  ldp      x9, x3, [x8, #0x178]
00686CCA4  mov      w8, w22
00686CCA8  lsl      x2, x8, #0x10
00686CCAC  blr      x9
00686CCB0  mov      w28, wzr
00686CCB4  adrp     x8, #0x9591000
00686CCB8  mov      x21, x8
00686CCBC  ldrb     w8, [x8, #0xa4b]
00686CCC0  cbnz     w8, #0x686ccd8
00686CCC4  adrp     x0, #0x8ee5000
00686CCC8  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CCCC  bl       #0x382bd14 ; 
00686CCD0  mov      w8, #1
00686CCD4  strb     w8, [x21, #0xa4b]
00686CCD8  adrp     x8, #0x8ee5000
00686CCDC  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CCE0  ldr      x1, [x8]
00686CCE4  ldrb     w8, [x1, #0x53]
00686CCE8  tbnz     w8, #5, #0x686ccf4
00686CCEC  ldr      x23, [x19, #0x20]
00686CCF0  b        #0x686cd04 ; 
00686CCF4  ldr      x8, [x1, #0x60]
00686CCF8  mov      x0, x19
00686CCFC  blr      x8
00686CD00  mov      x23, x0
00686CD04  cbz      x23, #0x686de0c
00686CD08  adrp     x8, #0x9591000
00686CD0C  ldrb     w8, [x8, #0xa90]
00686CD10  cbnz     w8, #0x686cd2c
00686CD14  adrp     x0, #0x8ee6000
00686CD18  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00686CD1C  bl       #0x382bd14 ; 
00686CD20  mov      w8, #1
00686CD24  adrp     x9, #0x9591000
00686CD28  strb     w8, [x9, #0xa90]
00686CD2C  adrp     x8, #0x8ee6000
00686CD30  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00686CD34  ldr      x1, [x8]
00686CD38  ldrb     w8, [x1, #0x53]
00686CD3C  tbnz     w8, #5, #0x686cd48
00686CD40  ldr      x0, [x23, #0x230]
00686CD44  b        #0x686cd54 ; 
00686CD48  ldr      x8, [x1, #0x60]
00686CD4C  mov      x0, x23
00686CD50  blr      x8
00686CD54  cbz      x0, #0x686de0c
00686CD58  adrp     x8, #0x8f08000
00686CD5C  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00686CD60  ldr      x1, [x8]
00686CD64  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
00686CD68  ldrb     w8, [x21, #0xa4b]
00686CD6C  mov      x23, x0
00686CD70  cbnz     w8, #0x686cd88
00686CD74  adrp     x0, #0x8ee5000
00686CD78  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CD7C  bl       #0x382bd14 ; 
00686CD80  mov      w8, #1
00686CD84  strb     w8, [x21, #0xa4b]
00686CD88  str      w24, [sp, #4]
00686CD8C  adrp     x8, #0x8ee5000
00686CD90  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CD94  ldr      x1, [x8]
00686CD98  ldrb     w8, [x1, #0x53]
00686CD9C  tbnz     w8, #5, #0x686cda8
00686CDA0  ldr      x24, [x19, #0x20]
00686CDA4  b        #0x686cdb8 ; 
00686CDA8  ldr      x8, [x1, #0x60]
00686CDAC  mov      x0, x19
00686CDB0  blr      x8
00686CDB4  mov      x24, x0
00686CDB8  cbz      x24, #0x686de0c
00686CDBC  adrp     x20, #0x9598000
00686CDC0  ldrb     w8, [x20, #0xfc4]
00686CDC4  cbnz     w8, #0x686cddc
00686CDC8  adrp     x0, #0x8f05000
00686CDCC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686CDD0  bl       #0x382bd14 ; 
00686CDD4  mov      w8, #1
00686CDD8  strb     w8, [x20, #0xfc4]
00686CDDC  adrp     x8, #0x8f05000
00686CDE0  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686CDE4  ldr      x1, [x8]
00686CDE8  ldrb     w8, [x1, #0x53]
00686CDEC  tbnz     w8, #5, #0x686cdf8
00686CDF0  ldr      x24, [x24, #0x220]
00686CDF4  b        #0x686ce08 ; 
00686CDF8  ldr      x8, [x1, #0x60]
00686CDFC  mov      x0, x24
00686CE00  blr      x8
00686CE04  mov      x24, x0
00686CE08  str      w29, [sp, #0xc]
00686CE0C  cbz      x24, #0x686de0c
00686CE10  adrp     x29, #0x959b000
00686CE14  ldrb     w8, [x29, #0xbb0]
00686CE18  str      x23, [sp, #0x10]
00686CE1C  cbnz     w8, #0x686ce34
00686CE20  adrp     x0, #0x8f08000
00686CE24  ldr      x0, [x0, #0x750] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_OverrideGuideRandomSkill() @ 0x923ccc0
00686CE28  bl       #0x382bd14 ; 
00686CE2C  mov      w8, #1
00686CE30  strb     w8, [x29, #0xbb0]
00686CE34  adrp     x23, #0x8f08000
00686CE38  ldr      x23, [x23, #0x750] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_OverrideGuideRandomSkill() @ 0x923ccc0
00686CE3C  ldr      x1, [x23]
00686CE40  ldrb     w8, [x1, #0x53]
00686CE44  tbnz     w8, #5, #0x686ce50
00686CE48  ldr      x24, [x24, #0x20]
00686CE4C  b        #0x686ce60 ; 
00686CE50  ldr      x8, [x1, #0x60]
00686CE54  mov      x0, x24
00686CE58  blr      x8
00686CE5C  mov      x24, x0
00686CE60  ldr      x1, [x27]
00686CE64  ldrb     w8, [x1, #0x53]
00686CE68  tbnz     w8, #5, #0x686ce74
00686CE6C  ldr      x0, [x19, #0x30]
00686CE70  b        #0x686ce80 ; 
00686CE74  ldr      x8, [x1, #0x60]
00686CE78  mov      x0, x19
00686CE7C  blr      x8
00686CE80  cbz      x0, #0x686de0c
00686CE84  adrp     x8, #0x8f09000
00686CE88  ldr      x8, [x8, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00686CE8C  ldr      x1, [x8]
00686CE90  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00686CE94  cbz      x0, #0x686de0c
00686CE98  mov      x1, xzr
00686CE9C  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
00686CEA0  mov      w27, w0
00686CEA4  str      wzr, [sp, #0x1c]
00686CEA8  cbz      x24, #0x686cee4
00686CEAC  ldrb     w8, [x21, #0xa4b]
00686CEB0  cbnz     w8, #0x686cec8
00686CEB4  adrp     x0, #0x8ee5000
00686CEB8  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CEBC  bl       #0x382bd14 ; 
00686CEC0  mov      w8, #1
00686CEC4  strb     w8, [x21, #0xa4b]
00686CEC8  adrp     x8, #0x8ee5000
00686CECC  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CED0  ldr      x1, [x8]
00686CED4  ldrb     w8, [x1, #0x53]
00686CED8  tbnz     w8, #5, #0x686cf0c
00686CEDC  ldr      x28, [x19, #0x20]
00686CEE0  b        #0x686cf1c ; 
00686CEE4  ldr      x1, [sp, #0x10]
00686CEE8  and      w2, w28, #1
00686CEEC  and      w3, w26, #1
00686CEF0  add      x5, sp, #0x1c
00686CEF4  mov      x0, x19
00686CEF8  mov      w4, w27
00686CEFC  bl       #0x686e0a0 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetNormalSkill
00686CF00  mov      w28, w0
00686CF04  mov      x29, x21
00686CF08  b        #0x686d0d0 ; 
00686CF0C  ldr      x8, [x1, #0x60]
00686CF10  mov      x0, x19
00686CF14  blr      x8
00686CF18  mov      x28, x0
00686CF1C  cbz      x28, #0x686de0c
00686CF20  ldrb     w8, [x20, #0xfc4]
00686CF24  cbnz     w8, #0x686cf3c
00686CF28  adrp     x0, #0x8f05000
00686CF2C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686CF30  bl       #0x382bd14 ; 
00686CF34  mov      w8, #1
00686CF38  strb     w8, [x20, #0xfc4]
00686CF3C  adrp     x8, #0x8f05000
00686CF40  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686CF44  ldr      x1, [x8]
00686CF48  ldrb     w8, [x1, #0x53]
00686CF4C  tbnz     w8, #5, #0x686cf58
00686CF50  ldr      x28, [x28, #0x220]
00686CF54  b        #0x686cf68 ; 
00686CF58  ldr      x8, [x1, #0x60]
00686CF5C  mov      x0, x28
00686CF60  blr      x8
00686CF64  mov      x28, x0
00686CF68  cbz      x28, #0x686de0c
00686CF6C  ldrb     w8, [x29, #0xbb0]
00686CF70  cbnz     w8, #0x686cf88
00686CF74  adrp     x0, #0x8f08000
00686CF78  ldr      x0, [x0, #0x750] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_OverrideGuideRandomSkill() @ 0x923ccc0
00686CF7C  bl       #0x382bd14 ; 
00686CF80  mov      w8, #1
00686CF84  strb     w8, [x29, #0xbb0]
00686CF88  ldr      x1, [x23]
00686CF8C  ldrb     w8, [x1, #0x53]
00686CF90  tbnz     w8, #5, #0x686cf9c
00686CF94  ldr      x1, [x28, #0x20]
00686CF98  b        #0x686cfac ; 
00686CF9C  ldr      x8, [x1, #0x60]
00686CFA0  mov      x0, x28
00686CFA4  blr      x8
00686CFA8  mov      x1, x0
00686CFAC  adrp     x23, #0x8f05000
00686CFB0  ldr      x0, [sp, #0x10]
00686CFB4  ldr      x23, [x23, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686CFB8  mov      x29, x21
00686CFBC  cbz      x0, #0x686de0c
00686CFC0  adrp     x8, #0x8f08000
00686CFC4  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
00686CFC8  ldr      x2, [x8]
00686CFCC  bl       #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
00686CFD0  ldrb     w8, [x29, #0xa4b]
00686CFD4  cbnz     w8, #0x686cfec
00686CFD8  adrp     x0, #0x8ee5000
00686CFDC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CFE0  bl       #0x382bd14 ; 
00686CFE4  mov      w8, #1
00686CFE8  strb     w8, [x29, #0xa4b]
00686CFEC  adrp     x8, #0x8ee5000
00686CFF0  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686CFF4  ldr      x1, [x8]
00686CFF8  ldrb     w8, [x1, #0x53]
00686CFFC  tbnz     w8, #5, #0x686d008
00686D000  ldr      x28, [x19, #0x20]
00686D004  b        #0x686d018 ; 
00686D008  ldr      x8, [x1, #0x60]
00686D00C  mov      x0, x19
00686D010  blr      x8
00686D014  mov      x28, x0
00686D018  cbz      x28, #0x686de0c
00686D01C  ldrb     w8, [x20, #0xfc4]
00686D020  cbnz     w8, #0x686d038
00686D024  adrp     x0, #0x8f05000
00686D028  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D02C  bl       #0x382bd14 ; 
00686D030  mov      w8, #1
00686D034  strb     w8, [x20, #0xfc4]
00686D038  ldr      x1, [x23]
00686D03C  ldrb     w8, [x1, #0x53]
00686D040  tbnz     w8, #5, #0x686d04c
00686D044  ldr      x28, [x28, #0x220]
00686D048  b        #0x686d05c ; 
00686D04C  ldr      x8, [x1, #0x60]
00686D050  mov      x0, x28
00686D054  blr      x8
00686D058  mov      x28, x0
00686D05C  cbz      x28, #0x686de0c
00686D060  adrp     x23, #0x9599000
00686D064  ldrb     w8, [x23, #0xeb2]
00686D068  cbnz     w8, #0x686d080
00686D06C  adrp     x0, #0x8f08000
00686D070  ldr      x0, [x0, #0x758] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.set_OverrideGuideRandomSkill() @ 0x923ccf0
00686D074  bl       #0x382bd14 ; 
00686D078  mov      w8, #1
00686D07C  strb     w8, [x23, #0xeb2]
00686D080  adrp     x8, #0x8f08000
00686D084  ldr      x8, [x8, #0x758] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.set_OverrideGuideRandomSkill() @ 0x923ccf0
00686D088  ldr      x2, [x8]
00686D08C  ldrb     w8, [x2, #0x53]
00686D090  tbnz     w8, #5, #0x686d0a8
00686D094  str      xzr, [x28, #0x20]!
00686D098  mov      x0, x28
00686D09C  mov      x1, xzr
00686D0A0  bl       #0x382bcb8 ; 
00686D0A4  b        #0x686d0b8 ; 
00686D0A8  ldr      x8, [x2, #0x60]
00686D0AC  mov      x0, x28
00686D0B0  mov      x1, xzr
00686D0B4  blr      x8
00686D0B8  ldr      x0, [x19, #0x88]
00686D0BC  cbz      x0, #0x686de0c
00686D0C0  ldr      x8, [x0]
00686D0C4  ldp      x9, x1, [x8, #0x188]
00686D0C8  blr      x9
00686D0CC  mov      w28, wzr
00686D0D0  ldr      x23, [x19, #0x80]
00686D0D4  cbz      x23, #0x686de0c
00686D0D8  ldr      w8, [x23, #0x14]
00686D0DC  add      w8, w8, #1
00686D0E0  str      w8, [x23, #0x14]
00686D0E4  ldrb     w8, [x29, #0xa4b]
00686D0E8  cbnz     w8, #0x686d100
00686D0EC  adrp     x0, #0x8ee5000
00686D0F0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D0F4  bl       #0x382bd14 ; 
00686D0F8  mov      w8, #1
00686D0FC  strb     w8, [x29, #0xa4b]
00686D100  adrp     x8, #0x8ee5000
00686D104  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D108  ldr      x1, [x8]
00686D10C  ldrb     w8, [x1, #0x53]
00686D110  tbnz     w8, #5, #0x686d11c
00686D114  ldr      x29, [x19, #0x20]
00686D118  b        #0x686d12c ; 
00686D11C  ldr      x8, [x1, #0x60]
00686D120  mov      x0, x19
00686D124  blr      x8
00686D128  mov      x29, x0
00686D12C  cbz      x29, #0x686de0c
00686D130  ldrb     w8, [x20, #0xfc4]
00686D134  cbnz     w8, #0x686d14c
00686D138  adrp     x0, #0x8f05000
00686D13C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D140  bl       #0x382bd14 ; 
00686D144  mov      w8, #1
00686D148  strb     w8, [x20, #0xfc4]
00686D14C  adrp     x8, #0x8f05000
00686D150  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D154  ldr      x1, [x8]
00686D158  ldrb     w8, [x1, #0x53]
00686D15C  tbnz     w8, #5, #0x686d168
00686D160  ldr      x0, [x29, #0x220]
00686D164  b        #0x686d174 ; 
00686D168  ldr      x8, [x1, #0x60]
00686D16C  mov      x0, x29
00686D170  blr      x8
00686D174  cbz      x0, #0x686de0c
00686D178  ldr      x8, [x0]
00686D17C  ldr      x9, [x8, #0x2e8]
00686D180  ldr      x1, [x8, #0x2f0]
00686D184  blr      x9
00686D188  and      w8, w0, #1
00686D18C  strb     w8, [x23, #0x25]
00686D190  ldr      x29, [x19, #0x80]
00686D194  cbz      x29, #0x686de0c
00686D198  and      w8, w28, #1
00686D19C  strb     w8, [x29, #0x24]
00686D1A0  ldr      w8, [sp, #0x1c]
00686D1A4  str      w22, [x29, #0x18]
00686D1A8  ldr      x23, [sp, #0x10]
00686D1AC  add      w8, w8, #1
00686D1B0  stp      w27, w8, [x29, #0x1c]
00686D1B4  ldr      x27, [x19, #0x88]
00686D1B8  cbz      x27, #0x686de0c
00686D1BC  adrp     x22, #0x959b000
00686D1C0  ldrb     w8, [x22, #0xbb1]
00686D1C4  cbnz     w8, #0x686d1dc
00686D1C8  adrp     x0, #0x8f24000
00686D1CC  ldr      x0, [x0, #0x200] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.get_RandomIndex() @ 0x927fea0
00686D1D0  bl       #0x382bd14 ; 
00686D1D4  mov      w8, #1
00686D1D8  strb     w8, [x22, #0xbb1]
00686D1DC  adrp     x8, #0x8f24000
00686D1E0  ldr      x8, [x8, #0x200] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.get_RandomIndex() @ 0x927fea0
00686D1E4  ldr      x1, [x8]
00686D1E8  ldrb     w8, [x1, #0x53]
00686D1EC  tbnz     w8, #5, #0x686d1f8
00686D1F0  ldr      w0, [x27, #0x60]
00686D1F4  b        #0x686d204 ; 
00686D1F8  ldr      x8, [x1, #0x60]
00686D1FC  mov      x0, x27
00686D200  blr      x8
00686D204  adrp     x22, #0x959b000
00686D208  ldrb     w8, [x22, #0xb91]
00686D20C  add      w27, w0, #1
00686D210  cbnz     w8, #0x686d228
00686D214  adrp     x0, #0x8f23000
00686D218  ldr      x0, [x0, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_SkillQuality() @ 0x929ce98
00686D21C  bl       #0x382bd14 ; 
00686D220  mov      w8, #1
00686D224  strb     w8, [x22, #0xb91]
00686D228  adrp     x8, #0x8f23000
00686D22C  ldr      x8, [x8, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_SkillQuality() @ 0x929ce98
00686D230  ldr      x2, [x8]
00686D234  ldrb     w8, [x2, #0x53]
00686D238  tbnz     w8, #5, #0x686d244
00686D23C  str      w27, [x29, #0x68]
00686D240  b        #0x686d254 ; 
00686D244  ldr      x8, [x2, #0x60]
00686D248  mov      x0, x29
00686D24C  mov      w1, w27
00686D250  blr      x8
00686D254  adrp     x27, #0x8f23000
00686D258  ldr      x8, [x19, #0x80]
00686D25C  ldr      x27, [x27, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686D260  ldr      w28, [sp, #0xc]
00686D264  cbz      x8, #0x686de0c
00686D268  and      w9, w26, #1
00686D26C  strb     w9, [x8, #0x26]
00686D270  mov      x29, x21
00686D274  ldrb     w8, [x21, #0xa4b]
00686D278  adrp     x21, #0x8ee5000
00686D27C  ldr      x21, [x21, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D280  cbnz     w8, #0x686d298
00686D284  adrp     x0, #0x8ee5000
00686D288  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D28C  bl       #0x382bd14 ; 
00686D290  mov      w8, #1
00686D294  strb     w8, [x29, #0xa4b]
00686D298  ldr      x1, [x21]
00686D29C  ldrb     w8, [x1, #0x53]
00686D2A0  tbnz     w8, #5, #0x686d2ac
00686D2A4  ldr      x0, [x19, #0x20]
00686D2A8  b        #0x686d2b8 ; 
00686D2AC  ldr      x8, [x1, #0x60]
00686D2B0  mov      x0, x19
00686D2B4  blr      x8
00686D2B8  cbz      x0, #0x686de0c
00686D2BC  mov      x1, xzr
00686D2C0  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00686D2C4  ldr      x26, [x19, #0x80]
00686D2C8  cbz      x26, #0x686de0c
00686D2CC  tbz      w0, #0, #0x686d2d8
00686D2D0  str      w25, [x26, #0x28]
00686D2D4  b        #0x686d324 ; 
00686D2D8  adrp     x22, #0x959b000
00686D2DC  ldrb     w8, [x22, #0xb93]
00686D2E0  cbnz     w8, #0x686d2f8
00686D2E4  adrp     x0, #0x8f23000
00686D2E8  ldr      x0, [x0, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_SkillType() @ 0x929cea0
00686D2EC  bl       #0x382bd14 ; 
00686D2F0  mov      w8, #1
00686D2F4  strb     w8, [x22, #0xb93]
00686D2F8  adrp     x8, #0x8f23000
00686D2FC  ldr      x8, [x8, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_SkillType() @ 0x929cea0
00686D300  ldr      x2, [x8]
00686D304  ldrb     w8, [x2, #0x53]
00686D308  tbnz     w8, #5, #0x686d314
00686D30C  str      w25, [x26, #0x44]
00686D310  b        #0x686d324 ; 
00686D314  ldr      x8, [x2, #0x60]
00686D318  mov      x0, x26
00686D31C  mov      w1, w25
00686D320  blr      x8
00686D324  adrp     x22, #0x9599000
00686D328  ldrb     w8, [x22, #0x4c7]
00686D32C  ldr      x25, [x19, #0x80]
00686D330  cbnz     w8, #0x686d348
00686D334  adrp     x0, #0x8f09000
00686D338  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
00686D33C  bl       #0x382bd14 ; 
00686D340  mov      w8, #1
00686D344  strb     w8, [x22, #0x4c7]
00686D348  adrp     x8, #0x8f09000
00686D34C  ldr      x8, [x8, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
00686D350  ldr      x1, [x8]
00686D354  ldrb     w8, [x1, #0x53]
00686D358  tbnz     w8, #5, #0x686d364
00686D35C  ldr      x1, [x19, #0x58]
00686D360  b        #0x686d374 ; 
00686D364  ldr      x8, [x1, #0x60]
00686D368  mov      x0, x19
00686D36C  blr      x8
00686D370  mov      x1, x0
00686D374  cbz      x25, #0x686de0c
00686D378  str      x1, [x25, #0x30]!
00686D37C  mov      x0, x25
00686D380  bl       #0x382bcb8 ; 
00686D384  ldr      x0, [x19, #0x80]
00686D388  cbz      x0, #0x686de0c
00686D38C  mov      x1, x23
00686D390  bl       #0x6866748 ; HotFix.BattleLogic.RandomSkillResult$$InitByList
00686D394  adrp     x8, #0x8ee3000
00686D398  ldr      x25, [x19, #0x80]
00686D39C  ldr      x0, [x19, #0x50]
00686D3A0  ldr      x8, [x8, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
00686D3A4  ldr      x1, [x8]
00686D3A8  bl       #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
00686D3AC  cbz      x25, #0x686de0c
00686D3B0  adrp     x22, #0x959b000
00686D3B4  adrp     x23, #0x8f05000
00686D3B8  ldrb     w8, [x22, #0xb95]
00686D3BC  ldr      x23, [x23, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D3C0  mov      x26, x0
00686D3C4  cbnz     w8, #0x686d3dc
00686D3C8  adrp     x0, #0x8f23000
00686D3CC  ldr      x0, [x0, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_OwnSkills() @ 0x929ce70
00686D3D0  bl       #0x382bd14 ; 
00686D3D4  mov      w8, #1
00686D3D8  strb     w8, [x22, #0xb95]
00686D3DC  adrp     x8, #0x8f23000
00686D3E0  ldr      x8, [x8, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_OwnSkills() @ 0x929ce70
00686D3E4  ldr      x2, [x8]
00686D3E8  ldrb     w8, [x2, #0x53]
00686D3EC  tbnz     w8, #5, #0x686d404
00686D3F0  str      x26, [x25, #0x58]!
00686D3F4  mov      x0, x25
00686D3F8  mov      x1, x26
00686D3FC  bl       #0x382bcb8 ; 
00686D400  b        #0x686d414 ; 
00686D404  ldr      x8, [x2, #0x60]
00686D408  mov      x0, x25
00686D40C  mov      x1, x26
00686D410  blr      x8
00686D414  ldrb     w8, [x29, #0xa4b]
00686D418  ldr      x25, [x19, #0x80]
00686D41C  cbnz     w8, #0x686d434
00686D420  adrp     x0, #0x8ee5000
00686D424  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D428  bl       #0x382bd14 ; 
00686D42C  mov      w8, #1
00686D430  strb     w8, [x29, #0xa4b]
00686D434  ldr      x1, [x21]
00686D438  ldrb     w8, [x1, #0x53]
00686D43C  tbnz     w8, #5, #0x686d448
00686D440  ldr      x26, [x19, #0x20]
00686D444  b        #0x686d458 ; 
00686D448  ldr      x8, [x1, #0x60]
00686D44C  mov      x0, x19
00686D450  blr      x8
00686D454  mov      x26, x0
00686D458  cbz      x26, #0x686de0c
00686D45C  ldrb     w8, [x20, #0xfc4]
00686D460  cbnz     w8, #0x686d478
00686D464  adrp     x0, #0x8f05000
00686D468  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D46C  bl       #0x382bd14 ; 
00686D470  mov      w8, #1
00686D474  strb     w8, [x20, #0xfc4]
00686D478  ldr      x1, [x23]
00686D47C  ldrb     w8, [x1, #0x53]
00686D480  tbnz     w8, #5, #0x686d48c
00686D484  ldr      x0, [x26, #0x220]
00686D488  b        #0x686d498 ; 
00686D48C  ldr      x8, [x1, #0x60]
00686D490  mov      x0, x26
00686D494  blr      x8
00686D498  cbz      x0, #0x686de0c
00686D49C  mov      x1, xzr
00686D4A0  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
00686D4A4  cbz      x25, #0x686de0c
00686D4A8  adrp     x22, #0x959b000
00686D4AC  ldrb     w8, [x22, #0xb97]
00686D4B0  mov      w26, w0
00686D4B4  cbnz     w8, #0x686d4cc
00686D4B8  adrp     x0, #0x8f23000
00686D4BC  ldr      x0, [x0, #0xe80] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsBossWave() @ 0x929ce50
00686D4C0  bl       #0x382bd14 ; 
00686D4C4  mov      w8, #1
00686D4C8  strb     w8, [x22, #0xb97]
00686D4CC  adrp     x8, #0x8f23000
00686D4D0  ldr      x8, [x8, #0xe80] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsBossWave() @ 0x929ce50
00686D4D4  ldr      x2, [x8]
00686D4D8  ldrb     w8, [x2, #0x53]
00686D4DC  tbnz     w8, #5, #0x686d4ec
00686D4E0  and      w8, w26, #1
00686D4E4  strb     w8, [x25, #0x3c]
00686D4E8  b        #0x686d4fc ; 
00686D4EC  ldr      x8, [x2, #0x60]
00686D4F0  and      w1, w26, #1
00686D4F4  mov      x0, x25
00686D4F8  blr      x8
00686D4FC  ldr      x25, [x19, #0x80]
00686D500  cbz      x25, #0x686de0c
00686D504  adrp     x22, #0x959b000
00686D508  ldrb     w8, [x22, #0xb99]
00686D50C  cbnz     w8, #0x686d524
00686D510  adrp     x0, #0x8f23000
00686D514  ldr      x0, [x0, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsChapterSurvivor() @ 0x929ce58
00686D518  bl       #0x382bd14 ; 
00686D51C  mov      w8, #1
00686D520  strb     w8, [x22, #0xb99]
00686D524  adrp     x8, #0x8f23000
00686D528  ldr      x8, [x8, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsChapterSurvivor() @ 0x929ce58
00686D52C  ldr      x2, [x8]
00686D530  ldrb     w8, [x2, #0x53]
00686D534  tbnz     w8, #5, #0x686d540
00686D538  strb     wzr, [x25, #0x48]
00686D53C  b        #0x686d550 ; 
00686D540  ldr      x8, [x2, #0x60]
00686D544  mov      x0, x25
00686D548  mov      w1, wzr
00686D54C  blr      x8
00686D550  ldrb     w8, [x29, #0xa4b]
00686D554  cbnz     w8, #0x686d56c
00686D558  adrp     x0, #0x8ee5000
00686D55C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D560  bl       #0x382bd14 ; 
00686D564  mov      w8, #1
00686D568  strb     w8, [x29, #0xa4b]
00686D56C  ldr      x1, [x21]
00686D570  ldrb     w8, [x1, #0x53]
00686D574  tbnz     w8, #5, #0x686d580
00686D578  ldr      x25, [x19, #0x20]
00686D57C  b        #0x686d590 ; 
00686D580  ldr      x8, [x1, #0x60]
00686D584  mov      x0, x19
00686D588  blr      x8
00686D58C  mov      x25, x0
00686D590  cbz      x25, #0x686de0c
00686D594  ldrb     w8, [x20, #0xfc4]
00686D598  cbnz     w8, #0x686d5b0
00686D59C  adrp     x0, #0x8f05000
00686D5A0  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D5A4  bl       #0x382bd14 ; 
00686D5A8  mov      w8, #1
00686D5AC  strb     w8, [x20, #0xfc4]
00686D5B0  ldr      x1, [x23]
00686D5B4  ldrb     w8, [x1, #0x53]
00686D5B8  tbnz     w8, #5, #0x686d5c4
00686D5BC  ldr      x0, [x25, #0x220]
00686D5C0  b        #0x686d5d0 ; 
00686D5C4  ldr      x8, [x1, #0x60]
00686D5C8  mov      x0, x25
00686D5CC  blr      x8
00686D5D0  cbz      x0, #0x686de0c
00686D5D4  ldr      x8, [x0]
00686D5D8  ldp      x9, x1, [x8, #0x1a8]
00686D5DC  blr      x9
00686D5E0  tbz      w0, #0, #0x686d6c0
00686D5E4  ldrb     w8, [x29, #0xa4b]
00686D5E8  cbnz     w8, #0x686d600
00686D5EC  adrp     x0, #0x8ee5000
00686D5F0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D5F4  bl       #0x382bd14 ; 
00686D5F8  mov      w8, #1
00686D5FC  strb     w8, [x29, #0xa4b]
00686D600  ldr      x1, [x21]
00686D604  ldrb     w8, [x1, #0x53]
00686D608  tbnz     w8, #5, #0x686d614
00686D60C  ldr      x25, [x19, #0x20]
00686D610  b        #0x686d624 ; 
00686D614  ldr      x8, [x1, #0x60]
00686D618  mov      x0, x19
00686D61C  blr      x8
00686D620  mov      x25, x0
00686D624  cbz      x25, #0x686de0c
00686D628  adrp     x22, #0x9599000
00686D62C  ldrb     w8, [x22, #0x29b]
00686D630  cbnz     w8, #0x686d648
00686D634  adrp     x0, #0x8f08000
00686D638  ldr      x0, [x0, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
00686D63C  bl       #0x382bd14 ; 
00686D640  mov      w8, #1
00686D644  strb     w8, [x22, #0x29b]
00686D648  adrp     x8, #0x8f08000
00686D64C  ldr      x8, [x8, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
00686D650  ldr      x1, [x8]
00686D654  ldrb     w8, [x1, #0x53]
00686D658  tbnz     w8, #5, #0x686d664
00686D65C  ldr      w0, [x25, #0x18c]
00686D660  b        #0x686d670 ; 
00686D664  ldr      x8, [x1, #0x60]
00686D668  mov      x0, x25
00686D66C  blr      x8
00686D670  adrp     x22, #0x9599000
00686D674  ldrb     w8, [x22, #0x4be]
00686D678  add      w26, w0, #1
00686D67C  cbnz     w8, #0x686d694
00686D680  adrp     x0, #0x8f08000
00686D684  ldr      x0, [x0, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseEntity() @ 0x9240110
00686D688  bl       #0x382bd14 ; 
00686D68C  mov      w8, #1
00686D690  strb     w8, [x22, #0x4be]
00686D694  adrp     x8, #0x8f08000
00686D698  ldr      x8, [x8, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseEntity() @ 0x9240110
00686D69C  ldr      x2, [x8]
00686D6A0  ldrb     w8, [x2, #0x53]
00686D6A4  tbnz     w8, #5, #0x686d6b0
00686D6A8  str      w26, [x25, #0x18c]
00686D6AC  b        #0x686d6c0 ; 
00686D6B0  ldr      x8, [x2, #0x60]
00686D6B4  mov      x0, x25
00686D6B8  mov      w1, w26
00686D6BC  blr      x8
00686D6C0  ldrb     w8, [x29, #0xa4b]
00686D6C4  cbnz     w8, #0x686d6dc
00686D6C8  adrp     x0, #0x8ee5000
00686D6CC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D6D0  bl       #0x382bd14 ; 
00686D6D4  mov      w8, #1
00686D6D8  strb     w8, [x29, #0xa4b]
00686D6DC  ldr      x1, [x21]
00686D6E0  ldrb     w8, [x1, #0x53]
00686D6E4  tbnz     w8, #5, #0x686d6f0
00686D6E8  ldr      x0, [x19, #0x20]
00686D6EC  b        #0x686d6fc ; 
00686D6F0  ldr      x8, [x1, #0x60]
00686D6F4  mov      x0, x19
00686D6F8  blr      x8
00686D6FC  cbz      x0, #0x686de0c
00686D700  mov      x1, xzr
00686D704  bl       #0x6a005a4 ; HotFix.BattleLogic.BattleWorldContext$$IsMultiPlayerBattle
00686D708  tbnz     w0, #0, #0x686d758
00686D70C  ldrb     w8, [x29, #0xa4b]
00686D710  cbnz     w8, #0x686d728
00686D714  adrp     x0, #0x8ee5000
00686D718  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D71C  bl       #0x382bd14 ; 
00686D720  mov      w8, #1
00686D724  strb     w8, [x29, #0xa4b]
00686D728  ldr      x1, [x21]
00686D72C  ldrb     w8, [x1, #0x53]
00686D730  tbnz     w8, #5, #0x686d73c
00686D734  ldr      x0, [x19, #0x20]
00686D738  b        #0x686d748 ; 
00686D73C  ldr      x8, [x1, #0x60]
00686D740  mov      x0, x19
00686D744  blr      x8
00686D748  cbz      x0, #0x686de0c
00686D74C  mov      w1, #4
00686D750  mov      x2, xzr
00686D754  bl       #0x6a052e4 ; HotFix.BattleLogic.BattleWorldContext$$SetBattleFlag
00686D758  ldrb     w8, [x29, #0xa4b]
00686D75C  ldr      x25, [x19, #0x80]
00686D760  cbnz     w8, #0x686d778
00686D764  adrp     x0, #0x8ee5000
00686D768  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D76C  bl       #0x382bd14 ; 
00686D770  mov      w8, #1
00686D774  strb     w8, [x29, #0xa4b]
00686D778  ldr      x1, [x21]
00686D77C  ldrb     w8, [x1, #0x53]
00686D780  tbnz     w8, #5, #0x686d78c
00686D784  ldr      x26, [x19, #0x20]
00686D788  b        #0x686d79c ; 
00686D78C  ldr      x8, [x1, #0x60]
00686D790  mov      x0, x19
00686D794  blr      x8
00686D798  mov      x26, x0
00686D79C  cbz      x26, #0x686de0c
00686D7A0  ldrb     w8, [x20, #0xfc4]
00686D7A4  cbnz     w8, #0x686d7bc
00686D7A8  adrp     x0, #0x8f05000
00686D7AC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D7B0  bl       #0x382bd14 ; 
00686D7B4  mov      w8, #1
00686D7B8  strb     w8, [x20, #0xfc4]
00686D7BC  ldr      x1, [x23]
00686D7C0  ldrb     w8, [x1, #0x53]
00686D7C4  tbnz     w8, #5, #0x686d7d0
00686D7C8  ldr      x0, [x26, #0x220]
00686D7CC  b        #0x686d7dc ; 
00686D7D0  ldr      x8, [x1, #0x60]
00686D7D4  mov      x0, x26
00686D7D8  blr      x8
00686D7DC  cbz      x0, #0x686de0c
00686D7E0  ldr      x8, [x0]
00686D7E4  ldr      x9, [x8, #0x518]
00686D7E8  ldr      x1, [x8, #0x520]
00686D7EC  blr      x9
00686D7F0  cbz      x25, #0x686de0c
00686D7F4  adrp     x22, #0x959b000
00686D7F8  ldrb     w8, [x22, #0xb9f]
00686D7FC  mov      w26, w0
00686D800  cbnz     w8, #0x686d818
00686D804  adrp     x0, #0x8f23000
00686D808  ldr      x0, [x0, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_Wave() @ 0x929cea8
00686D80C  bl       #0x382bd14 ; 
00686D810  mov      w8, #1
00686D814  strb     w8, [x22, #0xb9f]
00686D818  adrp     x8, #0x8f23000
00686D81C  ldr      x8, [x8, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_Wave() @ 0x929cea8
00686D820  ldr      x2, [x8]
00686D824  ldrb     w8, [x2, #0x53]
00686D828  tbnz     w8, #5, #0x686d834
00686D82C  str      w26, [x25, #0x40]
00686D830  b        #0x686d844 ; 
00686D834  ldr      x8, [x2, #0x60]
00686D838  mov      x0, x25
00686D83C  mov      w1, w26
00686D840  blr      x8
00686D844  ldrb     w8, [x29, #0xa4b]
00686D848  ldr      x25, [x19, #0x80]
00686D84C  cbnz     w8, #0x686d864
00686D850  adrp     x0, #0x8ee5000
00686D854  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686D858  bl       #0x382bd14 ; 
00686D85C  mov      w8, #1
00686D860  strb     w8, [x29, #0xa4b]
00686D864  ldr      x1, [x21]
00686D868  ldrb     w8, [x1, #0x53]
00686D86C  tbnz     w8, #5, #0x686d878
00686D870  ldr      x26, [x19, #0x20]
00686D874  b        #0x686d888 ; 
00686D878  ldr      x8, [x1, #0x60]
00686D87C  mov      x0, x19
00686D880  blr      x8
00686D884  mov      x26, x0
00686D888  adrp     x21, #0x9591000
00686D88C  cbz      x26, #0x686de0c
00686D890  ldrb     w8, [x20, #0xfc4]
00686D894  cbnz     w8, #0x686d8ac
00686D898  adrp     x0, #0x8f05000
00686D89C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00686D8A0  bl       #0x382bd14 ; 
00686D8A4  mov      w8, #1
00686D8A8  strb     w8, [x20, #0xfc4]
00686D8AC  ldr      x1, [x23]
00686D8B0  ldrb     w8, [x1, #0x53]
00686D8B4  tbnz     w8, #5, #0x686d8c0
00686D8B8  ldr      x0, [x26, #0x220]
00686D8BC  b        #0x686d8cc ; 
00686D8C0  ldr      x8, [x1, #0x60]
00686D8C4  mov      x0, x26
00686D8C8  blr      x8
00686D8CC  cbz      x0, #0x686de0c
00686D8D0  ldr      x8, [x0]
00686D8D4  ldr      x9, [x8, #0x528]
00686D8D8  ldr      x1, [x8, #0x530]
00686D8DC  blr      x9
00686D8E0  cbz      x25, #0x686de0c
00686D8E4  adrp     x20, #0x959b000
00686D8E8  ldrb     w8, [x20, #0xba1]
00686D8EC  mov      w26, w0
00686D8F0  cbnz     w8, #0x686d908
00686D8F4  adrp     x0, #0x8f23000
00686D8F8  ldr      x0, [x0, #0xe70] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_ShowWave() @ 0x929ce90
00686D8FC  bl       #0x382bd14 ; 
00686D900  mov      w8, #1
00686D904  strb     w8, [x20, #0xba1]
00686D908  adrp     x8, #0x8f23000
00686D90C  ldr      x8, [x8, #0xe70] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_ShowWave() @ 0x929ce90
00686D910  ldr      x2, [x8]
00686D914  ldrb     w8, [x2, #0x53]
00686D918  tbnz     w8, #5, #0x686d924
00686D91C  str      w26, [x25, #0x38]
00686D920  b        #0x686d934 ; 
00686D924  ldr      x8, [x2, #0x60]
00686D928  mov      x0, x25
00686D92C  mov      w1, w26
00686D930  blr      x8
00686D934  ldr      x1, [x27]
00686D938  ldr      x25, [x19, #0x80]
00686D93C  ldrb     w8, [x1, #0x53]
00686D940  tbnz     w8, #5, #0x686d94c
00686D944  ldr      x0, [x19, #0x30]
00686D948  b        #0x686d958 ; 
00686D94C  ldr      x8, [x1, #0x60]
00686D950  mov      x0, x19
00686D954  blr      x8
00686D958  cbz      x0, #0x686de0c
00686D95C  adrp     x8, #0x8ee6000
00686D960  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686D964  ldr      x1, [x8]
00686D968  ldrb     w8, [x1, #0x53]
00686D96C  tbnz     w8, #5, #0x686d978
00686D970  ldr      x26, [x0, #0x38]
00686D974  b        #0x686d984 ; 
00686D978  ldr      x8, [x1, #0x60]
00686D97C  blr      x8
00686D980  mov      x26, x0
00686D984  cbz      x26, #0x686de0c
00686D988  ldrb     w8, [x21, #0xa7f]
00686D98C  cbnz     w8, #0x686d9a4
00686D990  adrp     x0, #0x8ee6000
00686D994  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686D998  bl       #0x382bd14 ; 
00686D99C  mov      w8, #1
00686D9A0  strb     w8, [x21, #0xa7f]
00686D9A4  adrp     x8, #0x8ee6000
00686D9A8  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686D9AC  ldr      x1, [x8]
00686D9B0  ldrb     w8, [x1, #0x53]
00686D9B4  tbnz     w8, #5, #0x686d9c0
00686D9B8  ldr      x0, [x26, #0x178]
00686D9BC  b        #0x686d9cc ; 
00686D9C0  ldr      x8, [x1, #0x60]
00686D9C4  mov      x0, x26
00686D9C8  blr      x8
00686D9CC  cbz      x0, #0x686de0c
00686D9D0  mov      x1, xzr
00686D9D4  bl       #0x6b3cf00 ; HotFix.Common.AttributeData$$GetAttack
00686D9D8  cbz      x25, #0x686de0c
00686D9DC  adrp     x20, #0x959b000
00686D9E0  ldrb     w8, [x20, #0xb9b]
00686D9E4  lsr      x26, x0, #0x10
00686D9E8  cbnz     w8, #0x686da00
00686D9EC  adrp     x0, #0x8f23000
00686D9F0  ldr      x0, [x0, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurAttack() @ 0x929ce78
00686D9F4  bl       #0x382bd14 ; 
00686D9F8  mov      w8, #1
00686D9FC  strb     w8, [x20, #0xb9b]
00686DA00  adrp     x8, #0x8f23000
00686DA04  ldr      x8, [x8, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurAttack() @ 0x929ce78
00686DA08  ldr      x2, [x8]
00686DA0C  ldrb     w8, [x2, #0x53]
00686DA10  tbnz     w8, #5, #0x686da1c
00686DA14  str      w26, [x25, #0x4c]
00686DA18  b        #0x686da2c ; 
00686DA1C  ldr      x8, [x2, #0x60]
00686DA20  mov      x0, x25
00686DA24  mov      w1, w26
00686DA28  blr      x8
00686DA2C  ldr      x1, [x27]
00686DA30  ldr      x25, [x19, #0x80]
00686DA34  ldrb     w8, [x1, #0x53]
00686DA38  tbnz     w8, #5, #0x686da44
00686DA3C  ldr      x0, [x19, #0x30]
00686DA40  b        #0x686da50 ; 
00686DA44  ldr      x8, [x1, #0x60]
00686DA48  mov      x0, x19
00686DA4C  blr      x8
00686DA50  cbz      x0, #0x686de0c
00686DA54  ldr      x8, [x0]
00686DA58  ldr      x9, [x8, #0x498]
00686DA5C  ldr      x1, [x8, #0x4a0]
00686DA60  blr      x9
00686DA64  cbz      x25, #0x686de0c
00686DA68  adrp     x20, #0x959b000
00686DA6C  ldrb     w8, [x20, #0xb9d]
00686DA70  mov      w26, w0
00686DA74  cbnz     w8, #0x686da8c
00686DA78  adrp     x0, #0x8f23000
00686DA7C  ldr      x0, [x0, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurHp() @ 0x929ce80
00686DA80  bl       #0x382bd14 ; 
00686DA84  mov      w8, #1
00686DA88  strb     w8, [x20, #0xb9d]
00686DA8C  adrp     x8, #0x8f23000
00686DA90  ldr      x8, [x8, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurHp() @ 0x929ce80
00686DA94  ldr      x2, [x8]
00686DA98  ldrb     w8, [x2, #0x53]
00686DA9C  tbnz     w8, #5, #0x686daa8
00686DAA0  str      w26, [x25, #0x50]
00686DAA4  b        #0x686dab8 ; 
00686DAA8  ldr      x8, [x2, #0x60]
00686DAAC  mov      x0, x25
00686DAB0  mov      w1, w26
00686DAB4  blr      x8
00686DAB8  ldr      x25, [x19, #0x80]
00686DABC  cbz      x25, #0x686de0c
00686DAC0  adrp     x21, #0x959b000
00686DAC4  ldrb     w8, [x21, #0xba3]
00686DAC8  cmp      x24, #0
00686DACC  cset     w20, ne
00686DAD0  cbnz     w8, #0x686dae8
00686DAD4  adrp     x0, #0x8f23000
00686DAD8  ldr      x0, [x0, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsGuideOverride() @ 0x929ce60
00686DADC  bl       #0x382bd14 ; 
00686DAE0  mov      w8, #1
00686DAE4  strb     w8, [x21, #0xba3]
00686DAE8  adrp     x8, #0x8f23000
00686DAEC  ldr      x8, [x8, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsGuideOverride() @ 0x929ce60
00686DAF0  ldr      x2, [x8]
00686DAF4  ldrb     w8, [x2, #0x53]
00686DAF8  tbnz     w8, #5, #0x686db04
00686DAFC  strb     w20, [x25, #0x6c]
00686DB00  b        #0x686db18 ; 
00686DB04  ldr      x8, [x2, #0x60]
00686DB08  cmp      x24, #0
00686DB0C  cset     w1, ne
00686DB10  mov      x0, x25
00686DB14  blr      x8
00686DB18  adrp     x21, #0x8ee5000
00686DB1C  ldr      x21, [x21, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DB20  ldr      x24, [x19, #0x80]
00686DB24  cbz      x24, #0x686de0c
00686DB28  str      wzr, [x24, #0x10]
00686DB2C  adrp     x20, #0x959b000
00686DB30  ldrb     w8, [x20, #0xba5]
00686DB34  cbnz     w8, #0x686db4c
00686DB38  adrp     x0, #0x8f23000
00686DB3C  ldr      x0, [x0, #0xf10] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_LastSkillSelectCount() @ 0x929ce68
00686DB40  bl       #0x382bd14 ; 
00686DB44  mov      w8, #1
00686DB48  strb     w8, [x20, #0xba5]
00686DB4C  adrp     x8, #0x8f23000
00686DB50  ldr      x8, [x8, #0xf10] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_LastSkillSelectCount() @ 0x929ce68
00686DB54  ldr      x2, [x8]
00686DB58  ldrb     w8, [x2, #0x53]
00686DB5C  tbnz     w8, #5, #0x686db6c
00686DB60  ldr      w8, [sp, #8]
00686DB64  str      w8, [x24, #0x70]
00686DB68  b        #0x686db7c ; 
00686DB6C  ldr      x8, [x2, #0x60]
00686DB70  ldr      w1, [sp, #8]
00686DB74  mov      x0, x24
00686DB78  blr      x8
00686DB7C  ldr      x22, [x19, #0x80]
00686DB80  ldr      w23, [sp, #4]
00686DB84  cbz      x22, #0x686de0c
00686DB88  str      w28, [x22, #0x74]
00686DB8C  ldrb     w8, [x29, #0xa4b]
00686DB90  cbnz     w8, #0x686dba8
00686DB94  adrp     x0, #0x8ee5000
00686DB98  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DB9C  bl       #0x382bd14 ; 
00686DBA0  mov      w8, #1
00686DBA4  strb     w8, [x29, #0xa4b]
00686DBA8  ldr      x1, [x21]
00686DBAC  ldrb     w8, [x1, #0x53]
00686DBB0  tbnz     w8, #5, #0x686dbbc
00686DBB4  ldr      x0, [x19, #0x20]
00686DBB8  b        #0x686dbc8 ; 
00686DBBC  ldr      x8, [x1, #0x60]
00686DBC0  mov      x0, x19
00686DBC4  blr      x8
00686DBC8  cbz      x0, #0x686de0c
00686DBCC  ldr      x1, [x27]
00686DBD0  ldr      x21, [x0, #0x1d0]
00686DBD4  ldrb     w8, [x1, #0x53]
00686DBD8  tbnz     w8, #5, #0x686dbe4
00686DBDC  ldr      x0, [x19, #0x30]
00686DBE0  b        #0x686dbf0 ; 
00686DBE4  ldr      x8, [x1, #0x60]
00686DBE8  mov      x0, x19
00686DBEC  blr      x8
00686DBF0  cbz      x0, #0x686de0c
00686DBF4  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
00686DBF8  cbz      x21, #0x686de0c
00686DBFC  mov      w1, w0
00686DC00  mov      x0, x21
00686DC04  mov      x2, xzr
00686DC08  bl       #0x6a4802c ; HotFix.BattleLogic.WorldInitInfo$$GetPlayerInfoByPlayerID
00686DC0C  cbz      x0, #0x686de0c
00686DC10  adrp     x20, #0x9599000
00686DC14  ldrb     w8, [x20, #0x299]
00686DC18  mov      x21, x0
00686DC1C  cbnz     w8, #0x686dc34
00686DC20  adrp     x0, #0x8f07000
00686DC24  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_BanSkills() @ 0x923d9e8
00686DC28  bl       #0x382bd14 ; 
00686DC2C  mov      w8, #1
00686DC30  strb     w8, [x20, #0x299]
00686DC34  adrp     x8, #0x8f07000
00686DC38  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_BanSkills() @ 0x923d9e8
00686DC3C  ldr      x1, [x8]
00686DC40  ldrb     w8, [x1, #0x53]
00686DC44  tbnz     w8, #5, #0x686dc50
00686DC48  ldr      x1, [x21, #0x20]
00686DC4C  b        #0x686dc60 ; 
00686DC50  ldr      x8, [x1, #0x60]
00686DC54  mov      x0, x21
00686DC58  blr      x8
00686DC5C  mov      x1, x0
00686DC60  str      x1, [x22, #0x78]!
00686DC64  mov      x0, x22
00686DC68  bl       #0x382bcb8 ; 
00686DC6C  adrp     x21, #0x8ee5000
00686DC70  ldr      x21, [x21, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DC74  tbz      w23, #0, #0x686dd44
00686DC78  ldrb     w8, [x29, #0xa4b]
00686DC7C  cbnz     w8, #0x686dc94
00686DC80  adrp     x0, #0x8ee5000
00686DC84  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DC88  bl       #0x382bd14 ; 
00686DC8C  mov      w8, #1
00686DC90  strb     w8, [x29, #0xa4b]
00686DC94  ldr      x1, [x21]
00686DC98  ldrb     w8, [x1, #0x53]
00686DC9C  tbnz     w8, #5, #0x686dca8
00686DCA0  ldr      x0, [x19, #0x20]
00686DCA4  b        #0x686dcb4 ; 
00686DCA8  ldr      x8, [x1, #0x60]
00686DCAC  mov      x0, x19
00686DCB0  blr      x8
00686DCB4  cbz      x0, #0x686de0c
00686DCB8  mov      x1, xzr
00686DCBC  bl       #0x6a009e8 ; HotFix.BattleLogic.BattleWorldContext$$ResetGameSpeed
00686DCC0  ldrb     w8, [x29, #0xa4b]
00686DCC4  cbnz     w8, #0x686dcdc
00686DCC8  adrp     x0, #0x8ee5000
00686DCCC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DCD0  bl       #0x382bd14 ; 
00686DCD4  mov      w8, #1
00686DCD8  strb     w8, [x29, #0xa4b]
00686DCDC  ldr      x1, [x21]
00686DCE0  ldrb     w8, [x1, #0x53]
00686DCE4  tbnz     w8, #5, #0x686dcf0
00686DCE8  ldr      x20, [x19, #0x20]
00686DCEC  b        #0x686dd00 ; 
00686DCF0  ldr      x8, [x1, #0x60]
00686DCF4  mov      x0, x19
00686DCF8  blr      x8
00686DCFC  mov      x20, x0
00686DD00  ldr      x1, [x27]
00686DD04  ldrb     w8, [x1, #0x53]
00686DD08  tbnz     w8, #5, #0x686dd14
00686DD0C  ldr      x0, [x19, #0x30]
00686DD10  b        #0x686dd20 ; 
00686DD14  ldr      x8, [x1, #0x60]
00686DD18  mov      x0, x19
00686DD1C  blr      x8
00686DD20  cbz      x0, #0x686de0c
00686DD24  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
00686DD28  cbz      x20, #0x686de0c
00686DD2C  ldr      x3, [x19, #0x80]
00686DD30  mov      w1, w0
00686DD34  mov      w2, #1
00686DD38  mov      x0, x20
00686DD3C  mov      x4, xzr
00686DD40  bl       #0x6a0f95c ; HotFix.BattleLogic.BattleWorldContext$$DisPatchOpenViewEvent
00686DD44  ldrb     w8, [x29, #0xa4b]
00686DD48  cbnz     w8, #0x686dd60
00686DD4C  adrp     x0, #0x8ee5000
00686DD50  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DD54  bl       #0x382bd14 ; 
00686DD58  mov      w8, #1
00686DD5C  strb     w8, [x29, #0xa4b]
00686DD60  ldr      x1, [x21]
00686DD64  ldr      x21, [sp, #0x10]
00686DD68  adrp     x20, #0x9591000
00686DD6C  ldrb     w8, [x1, #0x53]
00686DD70  tbnz     w8, #5, #0x686dd7c
00686DD74  ldr      x19, [x19, #0x20]
00686DD78  b        #0x686dd8c ; 
00686DD7C  ldr      x8, [x1, #0x60]
00686DD80  mov      x0, x19
00686DD84  blr      x8
00686DD88  mov      x19, x0
00686DD8C  cbz      x19, #0x686de0c
00686DD90  ldrb     w8, [x20, #0xa90]
00686DD94  cbnz     w8, #0x686ddac
00686DD98  adrp     x0, #0x8ee6000
00686DD9C  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00686DDA0  bl       #0x382bd14 ; 
00686DDA4  mov      w8, #1
00686DDA8  strb     w8, [x20, #0xa90]
00686DDAC  adrp     x8, #0x8ee6000
00686DDB0  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00686DDB4  ldr      x1, [x8]
00686DDB8  ldrb     w8, [x1, #0x53]
00686DDBC  tbnz     w8, #5, #0x686ddc8
00686DDC0  ldr      x0, [x19, #0x230]
00686DDC4  b        #0x686ddd4 ; 
00686DDC8  ldr      x8, [x1, #0x60]
00686DDCC  mov      x0, x19
00686DDD0  blr      x8
00686DDD4  cbz      x0, #0x686de0c
00686DDD8  adrp     x8, #0x8f08000
00686DDDC  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00686DDE0  mov      x1, x21
00686DDE4  ldr      x2, [x8]
00686DDE8  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
00686DDEC  ldp      x20, x19, [sp, #0x70]
00686DDF0  ldp      x22, x21, [sp, #0x60]
00686DDF4  ldp      x24, x23, [sp, #0x50]
00686DDF8  ldp      x26, x25, [sp, #0x40]
00686DDFC  ldp      x28, x27, [sp, #0x30]
00686DE00  ldp      x29, x30, [sp, #0x20]
00686DE04  add      sp, sp, #0x80
00686DE08  ret      
00686DE0C  bl       #0x382bfb8 ; 

