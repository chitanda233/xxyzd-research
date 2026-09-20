; HotFix.BattleLogic.HeroComponentRandomSkill$$GetPunchboardRandomCount
; RVA 0x686F88C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F88C  sub      sp, sp, #0x80
00686F890  stp      x29, x30, [sp, #0x20]
00686F894  stp      x28, x27, [sp, #0x30]
00686F898  stp      x26, x25, [sp, #0x40]
00686F89C  stp      x24, x23, [sp, #0x50]
00686F8A0  stp      x22, x21, [sp, #0x60]
00686F8A4  stp      x20, x19, [sp, #0x70]
00686F8A8  adrp     x20, #0x959b000
00686F8AC  adrp     x21, #0x8f24000
00686F8B0  ldrb     w8, [x20, #0xa5f]
00686F8B4  ldr      x21, [x21, #0x2d0] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetPunchboardRandomCount() @ 0x927f9e0
00686F8B8  mov      x19, x0
00686F8BC  tbnz     w8, #0, #0x686f958
00686F8C0  adrp     x0, #0x8ee8000
00686F8C4  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00686F8C8  bl       #0x382bd14 ; 
00686F8CC  adrp     x0, #0x8ee6000
00686F8D0  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686F8D4  bl       #0x382bd14 ; 
00686F8D8  adrp     x0, #0x8f23000
00686F8DC  ldr      x0, [x0, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686F8E0  bl       #0x382bd14 ; 
00686F8E4  adrp     x0, #0x8ede000
00686F8E8  ldr      x0, [x0, #0xd0] ; GLOBAL Method$System.Collections.Generic.HashSet<int>.Add() @ 0x9216b38
00686F8EC  bl       #0x382bd14 ; 
00686F8F0  adrp     x0, #0x8ee3000
00686F8F4  ldr      x0, [x0, #0xf18] ; GLOBAL Method$System.Collections.Generic.HashSet<int>.Contains() @ 0x9216b48
00686F8F8  bl       #0x382bd14 ; 
00686F8FC  adrp     x0, #0x8ede000
00686F900  ldr      x0, [x0, #0x108] ; GLOBAL Method$System.Collections.Generic.HashSet<int>..ctor() @ 0x9216b20
00686F904  bl       #0x382bd14 ; 
00686F908  adrp     x0, #0x8ede000
00686F90C  ldr      x0, [x0, #0x100] ; GLOBAL System.Collections.Generic.HashSet<int>_TypeInfo @ 0x91d6540
00686F910  bl       #0x382bd14 ; 
00686F914  adrp     x0, #0x8f24000
00686F918  ldr      x0, [x0, #0x2d0] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetPunchboardRandomCount() @ 0x927f9e0
00686F91C  bl       #0x382bd14 ; 
00686F920  adrp     x0, #0x8ec1000
00686F924  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
00686F928  bl       #0x382bd14 ; 
00686F92C  adrp     x0, #0x8ec2000
00686F930  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
00686F934  bl       #0x382bd14 ; 
00686F938  adrp     x0, #0x8ec2000
00686F93C  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00686F940  bl       #0x382bd14 ; 
00686F944  adrp     x0, #0x8f24000
00686F948  ldr      x0, [x0, #0x2d8] ; GLOBAL FiveSkillRate% @ 0x92fd9d0
00686F94C  bl       #0x382bd14 ; 
00686F950  mov      w8, #1
00686F954  strb     w8, [x20, #0xa5f]
00686F958  ldr      x1, [x21]
00686F95C  ldrb     w8, [x1, #0x53]
00686F960  tbnz     w8, #5, #0x686f980
00686F964  adrp     x8, #0x8f23000
00686F968  ldr      x8, [x8, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686F96C  ldr      x1, [x8]
00686F970  ldrb     w8, [x1, #0x53]
00686F974  tbnz     w8, #5, #0x686f9a8
00686F978  ldr      x0, [x19, #0x30]
00686F97C  b        #0x686f9b4 ; 
00686F980  ldr      x2, [x1, #0x60]
00686F984  mov      x0, x19
00686F988  ldp      x20, x19, [sp, #0x70]
00686F98C  ldp      x22, x21, [sp, #0x60]
00686F990  ldp      x24, x23, [sp, #0x50]
00686F994  ldp      x26, x25, [sp, #0x40]
00686F998  ldp      x28, x27, [sp, #0x30]
00686F99C  ldp      x29, x30, [sp, #0x20]
00686F9A0  add      sp, sp, #0x80
00686F9A4  br       x2
00686F9A8  ldr      x8, [x1, #0x60]
00686F9AC  mov      x0, x19
00686F9B0  blr      x8
00686F9B4  cbz      x0, #0x686ffa0
00686F9B8  adrp     x8, #0x8ee6000
00686F9BC  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686F9C0  ldr      x1, [x8]
00686F9C4  ldrb     w8, [x1, #0x53]
00686F9C8  tbnz     w8, #5, #0x686f9d4
00686F9CC  ldr      x20, [x0, #0x38]
00686F9D0  b        #0x686f9e0 ; 
00686F9D4  ldr      x8, [x1, #0x60]
00686F9D8  blr      x8
00686F9DC  mov      x20, x0
00686F9E0  cbz      x20, #0x686ffa0
00686F9E4  adrp     x21, #0x9591000
00686F9E8  ldrb     w8, [x21, #0xa7f]
00686F9EC  cbnz     w8, #0x686fa04
00686F9F0  adrp     x0, #0x8ee6000
00686F9F4  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686F9F8  bl       #0x382bd14 ; 
00686F9FC  mov      w8, #1
00686FA00  strb     w8, [x21, #0xa7f]
00686FA04  adrp     x8, #0x8ee6000
00686FA08  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686FA0C  ldr      x1, [x8]
00686FA10  ldrb     w8, [x1, #0x53]
00686FA14  tbnz     w8, #5, #0x686fa20
00686FA18  ldr      x0, [x20, #0x178]
00686FA1C  b        #0x686fa2c ; 
00686FA20  ldr      x8, [x1, #0x60]
00686FA24  mov      x0, x20
00686FA28  blr      x8
00686FA2C  cbz      x0, #0x686ffa0
00686FA30  adrp     x8, #0x8f24000
00686FA34  ldr      x8, [x8, #0x2d8] ; GLOBAL FiveSkillRate% @ 0x92fd9d0
00686FA38  mov      x2, xzr
00686FA3C  ldr      x1, [x8]
00686FA40  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686FA44  adrp     x28, #0x8ee8000
00686FA48  ldr      x28, [x28, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00686FA4C  mov      x22, x0
00686FA50  ldr      x8, [x28]
00686FA54  ldr      w9, [x8, #0xe0]
00686FA58  cbnz     w9, #0x686fa64
00686FA5C  mov      x0, x8
00686FA60  bl       #0x382be8c ; 
00686FA64  mov      x0, xzr
00686FA68  bl       #0x64cb808 ; LocalModels.Const$$GetPunchboardRandomSkillCountWeight
00686FA6C  cbz      x0, #0x686ffa0
00686FA70  adrp     x8, #0x8ec1000
00686FA74  ldr      x26, [x0, #0x18]
00686FA78  ldr      x8, [x8, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
00686FA7C  mov      w1, w26
00686FA80  ldr      x0, [x8]
00686FA84  bl       #0x382bdfc ; 
00686FA88  cmp      x22, #1
00686FA8C  mov      x27, x0
00686FA90  b.lt     #0x686fb38
00686FA94  cmp      w26, #1
00686FA98  b.lt     #0x686fb60
00686FA9C  sub      w21, w26, #1
00686FAA0  add      x24, x27, #0x20
00686FAA4  mov      x20, xzr
00686FAA8  add      x22, x22, #0x10, lsl #12
00686FAAC  and      x23, x26, #0xffffffff
00686FAB0  add      x25, x24, w21, uxtw #2
00686FAB4  ldr      x0, [x28]
00686FAB8  ldr      w8, [x0, #0xe0]
00686FABC  cbnz     w8, #0x686fac4
00686FAC0  bl       #0x382be8c ; 
00686FAC4  mov      x0, xzr
00686FAC8  bl       #0x64cb808 ; LocalModels.Const$$GetPunchboardRandomSkillCountWeight
00686FACC  cbz      x0, #0x686ffa0
00686FAD0  ldr      w8, [x0, #0x18]
00686FAD4  cmp      x20, x8
00686FAD8  b.hs     #0x686ffa4
00686FADC  add      x8, x0, x20, lsl #2
00686FAE0  ldr      w8, [x8, #0x20]
00686FAE4  cmp      x21, x20
00686FAE8  b.ne     #0x686fb14
00686FAEC  sxtw     x8, w8
00686FAF0  mul      x0, x22, x8
00686FAF4  mov      x1, xzr
00686FAF8  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686FAFC  cbz      x27, #0x686ffa0
00686FB00  ldr      w8, [x27, #0x18]
00686FB04  cmp      x21, x8
00686FB08  b.hs     #0x686ffa4
00686FB0C  str      w0, [x25]
00686FB10  b        #0x686fb28 ; 
00686FB14  cbz      x27, #0x686ffa0
00686FB18  ldr      w9, [x27, #0x18]
00686FB1C  cmp      x20, x9
00686FB20  b.hs     #0x686ffa4
00686FB24  str      w8, [x24, x20, lsl #2]
00686FB28  add      x20, x20, #1
00686FB2C  cmp      x23, x20
00686FB30  b.ne     #0x686fab4
00686FB34  b        #0x686fb60 ; 
00686FB38  ldr      x0, [x28]
00686FB3C  ldr      w8, [x0, #0xe0]
00686FB40  cbnz     w8, #0x686fb48
00686FB44  bl       #0x382be8c ; 
00686FB48  mov      x0, xzr
00686FB4C  bl       #0x64cb808 ; LocalModels.Const$$GetPunchboardRandomSkillCountWeight
00686FB50  mov      x1, x27
00686FB54  mov      w2, w26
00686FB58  mov      x3, xzr
00686FB5C  bl       #0x7c01418 ; System.Array$$Copy
00686FB60  stp      x27, x26, [sp, #8]
00686FB64  adrp     x8, #0x8ede000
00686FB68  ldr      x8, [x8, #0x100] ; GLOBAL System.Collections.Generic.HashSet<int>_TypeInfo @ 0x91d6540
00686FB6C  ldr      x0, [x8]
00686FB70  bl       #0x382bfa0 ; 
00686FB74  adrp     x8, #0x8ede000
00686FB78  ldr      x8, [x8, #0x108] ; GLOBAL Method$System.Collections.Generic.HashSet<int>..ctor() @ 0x9216b20
00686FB7C  mov      x23, x0
00686FB80  ldr      x1, [x8]
00686FB84  bl       #0x4936d3c ; System.Collections.Generic.HashSet<int>$$.ctor
00686FB88  ldr      x8, [x19, #0x58]
00686FB8C  cbz      x8, #0x686ffa0
00686FB90  str      wzr, [sp, #0x1c]
00686FB94  adrp     x25, #0x8f06000
00686FB98  adrp     x26, #0x8f09000
00686FB9C  adrp     x27, #0x8f09000
00686FBA0  ldr      x25, [x25, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00686FBA4  ldr      x26, [x26, #0x8c0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_IsBattleSkill() @ 0x92ac440
00686FBA8  ldr      x27, [x27, #0xd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_BattleSkillGroup() @ 0x92ac408
00686FBAC  mov      w24, wzr
00686FBB0  adrp     x21, #0x9591000
00686FBB4  mov      w20, #1
00686FBB8  adrp     x22, #0x9598000
00686FBBC  adrp     x29, #0x9599000
00686FBC0  ldr      w8, [x8, #0x18]
00686FBC4  cmp      w24, w8
00686FBC8  b.ge     #0x686fd8c
00686FBCC  ldrb     w8, [x21, #0xa4b]
00686FBD0  cbnz     w8, #0x686fbe4
00686FBD4  adrp     x0, #0x8ee5000
00686FBD8  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686FBDC  bl       #0x382bd14 ; 
00686FBE0  strb     w20, [x21, #0xa4b]
00686FBE4  adrp     x8, #0x8ee5000
00686FBE8  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686FBEC  ldr      x1, [x8]
00686FBF0  ldrb     w8, [x1, #0x53]
00686FBF4  tbnz     w8, #5, #0x686fc00
00686FBF8  ldr      x28, [x19, #0x20]
00686FBFC  b        #0x686fc10 ; 
00686FC00  ldr      x8, [x1, #0x60]
00686FC04  mov      x0, x19
00686FC08  blr      x8
00686FC0C  mov      x28, x0
00686FC10  cbz      x28, #0x686ffa0
00686FC14  ldrb     w8, [x22, #0xfcc]
00686FC18  cbnz     w8, #0x686fc28
00686FC1C  mov      x0, x25
00686FC20  bl       #0x382bd14 ; 
00686FC24  strb     w20, [x22, #0xfcc]
00686FC28  ldr      x1, [x25]
00686FC2C  ldrb     w8, [x1, #0x53]
00686FC30  tbnz     w8, #5, #0x686fc3c
00686FC34  ldr      x28, [x28, #0x200]
00686FC38  b        #0x686fc4c ; 
00686FC3C  ldr      x8, [x1, #0x60]
00686FC40  mov      x0, x28
00686FC44  blr      x8
00686FC48  mov      x28, x0
00686FC4C  ldr      x0, [x19, #0x58]
00686FC50  cbz      x0, #0x686ffa0
00686FC54  adrp     x8, #0x8ec2000
00686FC58  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00686FC5C  mov      w1, w24
00686FC60  ldr      x2, [x8]
00686FC64  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00686FC68  cbz      x28, #0x686ffa0
00686FC6C  mov      w1, w0
00686FC70  mov      x0, x28
00686FC74  mov      x2, xzr
00686FC78  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00686FC7C  cbz      x0, #0x686ffa0
00686FC80  ldrb     w8, [x29, #0x4dc]
00686FC84  mov      x28, x0
00686FC88  cbnz     w8, #0x686fc98
00686FC8C  mov      x0, x26
00686FC90  bl       #0x382bd14 ; 
00686FC94  strb     w20, [x29, #0x4dc]
00686FC98  ldr      x1, [x26]
00686FC9C  ldrb     w8, [x1, #0x53]
00686FCA0  tbnz     w8, #5, #0x686fcac
00686FCA4  ldr      w0, [x28, #0x24]
00686FCA8  b        #0x686fcb8 ; 
00686FCAC  ldr      x8, [x1, #0x60]
00686FCB0  mov      x0, x28
00686FCB4  blr      x8
00686FCB8  cmp      w0, #1
00686FCBC  b.ne     #0x686fd7c
00686FCC0  adrp     x8, #0x9599000
00686FCC4  ldrb     w8, [x8, #0x4c8]
00686FCC8  cbnz     w8, #0x686fcdc
00686FCCC  mov      x0, x27
00686FCD0  bl       #0x382bd14 ; 
00686FCD4  adrp     x8, #0x9599000
00686FCD8  strb     w20, [x8, #0x4c8]
00686FCDC  ldr      x1, [x27]
00686FCE0  ldrb     w8, [x1, #0x53]
00686FCE4  tbnz     w8, #5, #0x686fcf0
00686FCE8  ldr      w1, [x28, #0x120]
00686FCEC  b        #0x686fd00 ; 
00686FCF0  ldr      x8, [x1, #0x60]
00686FCF4  mov      x0, x28
00686FCF8  blr      x8
00686FCFC  mov      w1, w0
00686FD00  cbz      x23, #0x686ffa0
00686FD04  adrp     x8, #0x8ee3000
00686FD08  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.HashSet<int>.Contains() @ 0x9216b48
00686FD0C  mov      x0, x23
00686FD10  ldr      x2, [x8]
00686FD14  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
00686FD18  tbnz     w0, #0, #0x686fd7c
00686FD1C  adrp     x8, #0x9599000
00686FD20  ldrb     w8, [x8, #0x4c8]
00686FD24  cbnz     w8, #0x686fd38
00686FD28  mov      x0, x27
00686FD2C  bl       #0x382bd14 ; 
00686FD30  adrp     x8, #0x9599000
00686FD34  strb     w20, [x8, #0x4c8]
00686FD38  ldr      x1, [x27]
00686FD3C  ldrb     w8, [x1, #0x53]
00686FD40  tbnz     w8, #5, #0x686fd4c
00686FD44  ldr      w1, [x28, #0x120]
00686FD48  b        #0x686fd5c ; 
00686FD4C  ldr      x8, [x1, #0x60]
00686FD50  mov      x0, x28
00686FD54  blr      x8
00686FD58  mov      w1, w0
00686FD5C  adrp     x8, #0x8ede000
00686FD60  ldr      x8, [x8, #0xd0] ; GLOBAL Method$System.Collections.Generic.HashSet<int>.Add() @ 0x9216b38
00686FD64  mov      x0, x23
00686FD68  ldr      x2, [x8]
00686FD6C  bl       #0x4937f40 ; System.Collections.Generic.HashSet<int>$$Add
00686FD70  ldr      w8, [sp, #0x1c]
00686FD74  add      w8, w8, #1
00686FD78  str      w8, [sp, #0x1c]
00686FD7C  ldr      x8, [x19, #0x58]
00686FD80  add      w24, w24, #1
00686FD84  cbnz     x8, #0x686fbc0
00686FD88  b        #0x686ffa0 ; 
00686FD8C  adrp     x20, #0x8ee8000
00686FD90  ldr      x20, [x20, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00686FD94  ldr      x22, [sp, #0x10]
00686FD98  ldr      x0, [x20]
00686FD9C  ldr      w8, [x0, #0xe0]
00686FDA0  cbnz     w8, #0x686fdac
00686FDA4  bl       #0x382be8c ; 
00686FDA8  ldr      x0, [x20]
00686FDAC  ldr      x24, [sp, #8]
00686FDB0  cmp      w22, #5
00686FDB4  b.lt     #0x686fdec
00686FDB8  ldr      x8, [x0, #0xb8]
00686FDBC  ldr      w9, [sp, #0x1c]
00686FDC0  ldr      w8, [x8, #0x4a4]
00686FDC4  cmp      w9, w8
00686FDC8  b.gt     #0x686fdec
00686FDCC  cbz      x24, #0x686ffa0
00686FDD0  ldr      w9, [x24, #0x18]
00686FDD4  sub      w8, w22, #1
00686FDD8  cmp      w8, w9
00686FDDC  b.hs     #0x686ffa4
00686FDE0  add      x8, x24, w8, uxtw #2
00686FDE4  str      wzr, [x8, #0x20]
00686FDE8  b        #0x686fdf8 ; 
00686FDEC  cmp      w22, #1
00686FDF0  b.lt     #0x686ff94
00686FDF4  cbz      x24, #0x686ffa0
00686FDF8  ldr      w10, [x24, #0x18]
00686FDFC  mov      x9, xzr
00686FE00  mov      w8, wzr
00686FE04  and      x11, x22, #0xffffffff
00686FE08  add      x12, x24, #0x20
00686FE0C  cmp      x9, x10
00686FE10  b.hs     #0x686ffa4
00686FE14  ldr      w13, [x12, x9, lsl #2]
00686FE18  add      x9, x9, #1
00686FE1C  cmp      x11, x9
00686FE20  add      w8, w13, w8
00686FE24  b.ne     #0x686fe0c
00686FE28  add      w23, w8, #1
00686FE2C  mov      w20, #1
00686FE30  ldrb     w8, [x21, #0xa4b]
00686FE34  cbnz     w8, #0x686fe4c
00686FE38  adrp     x0, #0x8ee5000
00686FE3C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686FE40  bl       #0x382bd14 ; 
00686FE44  mov      w8, #1
00686FE48  strb     w8, [x21, #0xa4b]
00686FE4C  adrp     x8, #0x8ee5000
00686FE50  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686FE54  ldr      x1, [x8]
00686FE58  ldrb     w8, [x1, #0x53]
00686FE5C  tbnz     w8, #5, #0x686fe68
00686FE60  ldr      x19, [x19, #0x20]
00686FE64  b        #0x686fe78 ; 
00686FE68  ldr      x8, [x1, #0x60]
00686FE6C  mov      x0, x19
00686FE70  blr      x8
00686FE74  mov      x19, x0
00686FE78  cbz      x19, #0x686ffa0
00686FE7C  adrp     x21, #0x9599000
00686FE80  ldrb     w8, [x21, #0xac6]
00686FE84  cbnz     w8, #0x686fe9c
00686FE88  adrp     x0, #0x8f0d000
00686FE8C  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
00686FE90  bl       #0x382bd14 ; 
00686FE94  mov      w8, #1
00686FE98  strb     w8, [x21, #0xac6]
00686FE9C  adrp     x8, #0x8f0d000
00686FEA0  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
00686FEA4  ldr      x3, [x8]
00686FEA8  ldrb     w8, [x3, #0x53]
00686FEAC  tbnz     w8, #5, #0x686feec
00686FEB0  adrp     x21, #0x9599000
00686FEB4  ldrb     w8, [x21, #0xac7]
00686FEB8  cbnz     w8, #0x686fed0
00686FEBC  adrp     x0, #0x8f0d000
00686FEC0  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
00686FEC4  bl       #0x382bd14 ; 
00686FEC8  mov      w8, #1
00686FECC  strb     w8, [x21, #0xac7]
00686FED0  adrp     x8, #0x8f0d000
00686FED4  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
00686FED8  ldr      x1, [x8]
00686FEDC  ldrb     w8, [x1, #0x53]
00686FEE0  tbnz     w8, #5, #0x686ff08
00686FEE4  ldr      x0, [x19, #0x260]
00686FEE8  b        #0x686ff14 ; 
00686FEEC  ldr      x8, [x3, #0x60]
00686FEF0  mov      x0, x19
00686FEF4  mov      w1, wzr
00686FEF8  mov      w2, w23
00686FEFC  blr      x8
00686FF00  cbnz     w20, #0x686ff38
00686FF04  b        #0x686ff68 ; 
00686FF08  ldr      x8, [x1, #0x60]
00686FF0C  mov      x0, x19
00686FF10  blr      x8
00686FF14  cbz      x0, #0x686ffa0
00686FF18  mov      w1, wzr
00686FF1C  mov      w2, w23
00686FF20  mov      x3, xzr
00686FF24  bl       #0x416d068 ; XXRandom$$Next
00686FF28  ldr      w8, [x19, #0x32c]
00686FF2C  add      w8, w8, #1
00686FF30  str      w8, [x19, #0x32c]
00686FF34  cbz      w20, #0x686ff68
00686FF38  cbz      x24, #0x686ffa0
00686FF3C  ldr      w8, [x24, #0x18]
00686FF40  mov      w9, wzr
00686FF44  cmp      w9, w8
00686FF48  b.hs     #0x686ffa4
00686FF4C  add      x10, x24, w9, sxtw #2
00686FF50  ldr      w10, [x10, #0x20]
00686FF54  subs     w0, w0, w10
00686FF58  b.lt     #0x686ff70
00686FF5C  add      w9, w9, #1
00686FF60  cmp      w22, w9
00686FF64  b.ne     #0x686ff44
00686FF68  mov      w0, #1
00686FF6C  b        #0x686ff74 ; 
00686FF70  add      w0, w9, #1
00686FF74  ldp      x20, x19, [sp, #0x70]
00686FF78  ldp      x22, x21, [sp, #0x60]
00686FF7C  ldp      x24, x23, [sp, #0x50]
00686FF80  ldp      x26, x25, [sp, #0x40]
00686FF84  ldp      x28, x27, [sp, #0x30]
00686FF88  ldp      x29, x30, [sp, #0x20]
00686FF8C  add      sp, sp, #0x80
00686FF90  ret      
00686FF94  mov      w20, wzr
00686FF98  mov      w23, #1
00686FF9C  b        #0x686fe30 ; 
00686FFA0  bl       #0x382bfb8 ; 
00686FFA4  bl       #0x382bfc0 ; 

