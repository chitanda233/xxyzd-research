; HotFix.BattleLogic.BattleWorldContext$$CreateCharacterData
; RVA 0x69FE730; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069FE730  str      x30, [sp, #-0x50]!
0069FE734  stp      x26, x25, [sp, #0x10]
0069FE738  stp      x24, x23, [sp, #0x20]
0069FE73C  stp      x22, x21, [sp, #0x30]
0069FE740  stp      x20, x19, [sp, #0x40]
0069FE744  adrp     x25, #0x959d000
0069FE748  adrp     x26, #0x8f32000
0069FE74C  ldrb     w8, [x25, #0x51e]
0069FE750  ldr      x26, [x26, #0x4c0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacterData()
0069FE754  mov      x21, x5
0069FE758  mov      x22, x4
0069FE75C  mov      x20, x3
0069FE760  mov      w24, w2
0069FE764  mov      x19, x1
0069FE768  mov      x23, x0
0069FE76C  tbnz     w8, #0, #0x69fe790
0069FE770  adrp     x0, #0x8f32000
0069FE774  ldr      x0, [x0, #0x4c0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacterData()
0069FE778  bl       #0x382bd14 ; 
0069FE77C  adrp     x0, #0x8f32000
0069FE780  ldr      x0, [x0, #0x4c8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEntityData<EntityCharacterData>()
0069FE784  bl       #0x382bd14 ; 
0069FE788  mov      w8, #1
0069FE78C  strb     w8, [x25, #0x51e]
0069FE790  ldr      x6, [x26]
0069FE794  ldrb     w8, [x6, #0x53]
0069FE798  tbnz     w8, #5, #0x69fe804
0069FE79C  adrp     x8, #0x8f32000
0069FE7A0  ldr      x8, [x8, #0x4c8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEntityData<EntityCharacterData>()
0069FE7A4  mov      x0, x23
0069FE7A8  mov      x1, x19
0069FE7AC  ldr      x2, [x8]
0069FE7B0  bl       #0x4540144 ; HotFix.BattleLogic.BattleWorldContext$$CreateEntityData<object>
0069FE7B4  cbz      x0, #0x69feaf4
0069FE7B8  mov      w1, w24
0069FE7BC  mov      x2, xzr
0069FE7C0  mov      x19, x0
0069FE7C4  bl       #0x68265c4 ; HotFix.BattleLogic.EntityCharacterData$$SetCamp
0069FE7C8  adrp     x24, #0x9598000
0069FE7CC  ldrb     w8, [x24, #0xfcc]
0069FE7D0  cbnz     w8, #0x69fe7e8
0069FE7D4  adrp     x0, #0x8f06000
0069FE7D8  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0069FE7DC  bl       #0x382bd14 ; 
0069FE7E0  mov      w8, #1
0069FE7E4  strb     w8, [x24, #0xfcc]
0069FE7E8  adrp     x8, #0x8f06000
0069FE7EC  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0069FE7F0  ldr      x1, [x8]
0069FE7F4  ldrb     w8, [x1, #0x53]
0069FE7F8  tbnz     w8, #5, #0x69fe838
0069FE7FC  ldr      x23, [x23, #0x200]
0069FE800  b        #0x69fe848 ; 
0069FE804  ldr      x7, [x6, #0x60]
0069FE808  mov      x0, x23
0069FE80C  mov      x1, x19
0069FE810  mov      w2, w24
0069FE814  mov      x3, x20
0069FE818  mov      x4, x22
0069FE81C  mov      x5, x21
0069FE820  ldp      x20, x19, [sp, #0x40]
0069FE824  ldp      x22, x21, [sp, #0x30]
0069FE828  ldp      x24, x23, [sp, #0x20]
0069FE82C  ldp      x26, x25, [sp, #0x10]
0069FE830  ldr      x30, [sp], #0x50
0069FE834  br       x7
0069FE838  ldr      x8, [x1, #0x60]
0069FE83C  mov      x0, x23
0069FE840  blr      x8
0069FE844  mov      x23, x0
0069FE848  cbz      x23, #0x69feaf4
0069FE84C  adrp     x24, #0x959d000
0069FE850  ldrb     w8, [x24, #0x64b]
0069FE854  cbnz     w8, #0x69fe86c
0069FE858  adrp     x0, #0x8efb000
0069FE85C  ldr      x0, [x0, #0xad0] ; GLOBAL Method$LocalModels.LocalModelManager.GetAttributeString_stringModelInstance()
0069FE860  bl       #0x382bd14 ; 
0069FE864  mov      w8, #1
0069FE868  strb     w8, [x24, #0x64b]
0069FE86C  adrp     x8, #0x8efb000
0069FE870  ldr      x8, [x8, #0xad0] ; GLOBAL Method$LocalModels.LocalModelManager.GetAttributeString_stringModelInstance()
0069FE874  ldr      x1, [x8]
0069FE878  ldrb     w8, [x1, #0x53]
0069FE87C  tbnz     w8, #5, #0x69fe888
0069FE880  ldr      x0, [x23, #0x798]
0069FE884  b        #0x69fe894 ; 
0069FE888  ldr      x8, [x1, #0x60]
0069FE88C  mov      x0, x23
0069FE890  blr      x8
0069FE894  cbz      x0, #0x69feaf4
0069FE898  mov      x1, xzr
0069FE89C  bl       #0x6521cec ; LocalModels.Model.AttributeString_stringModel$$GetAllElements
0069FE8A0  mov      x2, x0
0069FE8A4  mov      x0, x19
0069FE8A8  mov      x1, x20
0069FE8AC  mov      x3, xzr
0069FE8B0  bl       #0x6824c3c ; HotFix.BattleLogic.EntityCharacterData$$SetTableData
0069FE8B4  mov      x0, x19
0069FE8B8  mov      x1, x22
0069FE8BC  mov      x2, xzr
0069FE8C0  bl       #0x681f958 ; HotFix.BattleLogic.EntityCharacterData$$SetWeaponSkins
0069FE8C4  adrp     x22, #0x959d000
0069FE8C8  ldrb     w8, [x22, #0x651]
0069FE8CC  cbnz     w8, #0x69fe8e4
0069FE8D0  adrp     x0, #0x8f21000
0069FE8D4  ldr      x0, [x0, #0xf38] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetWingPlaneSlots()
0069FE8D8  bl       #0x382bd14 ; 
0069FE8DC  mov      w8, #1
0069FE8E0  strb     w8, [x22, #0x651]
0069FE8E4  adrp     x8, #0x8f21000
0069FE8E8  ldr      x8, [x8, #0xf38] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetWingPlaneSlots()
0069FE8EC  ldr      x2, [x8]
0069FE8F0  ldrb     w8, [x2, #0x53]
0069FE8F4  tbnz     w8, #5, #0x69fe90c
0069FE8F8  mov      x0, x19
0069FE8FC  str      x21, [x0, #0x90]!
0069FE900  mov      x1, x21
0069FE904  bl       #0x382bcb8 ; 
0069FE908  b        #0x69fe91c ; 
0069FE90C  ldr      x8, [x2, #0x60]
0069FE910  mov      x0, x19
0069FE914  mov      x1, x21
0069FE918  blr      x8
0069FE91C  cbz      x20, #0x69feaf4
0069FE920  adrp     x21, #0x959a000
0069FE924  ldrb     w8, [x21, #0x277]
0069FE928  cbnz     w8, #0x69fe940
0069FE92C  adrp     x0, #0x8f12000
0069FE930  ldr      x0, [x0, #0x68] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_SecondWeapenType()
0069FE934  bl       #0x382bd14 ; 
0069FE938  mov      w8, #1
0069FE93C  strb     w8, [x21, #0x277]
0069FE940  adrp     x8, #0x8f12000
0069FE944  ldr      x8, [x8, #0x68] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_SecondWeapenType()
0069FE948  ldr      x1, [x8]
0069FE94C  ldrb     w8, [x1, #0x53]
0069FE950  tbnz     w8, #5, #0x69fe95c
0069FE954  ldr      w20, [x20, #0x30]
0069FE958  b        #0x69fe96c ; 
0069FE95C  ldr      x8, [x1, #0x60]
0069FE960  mov      x0, x20
0069FE964  blr      x8
0069FE968  mov      w20, w0
0069FE96C  adrp     x21, #0x9591000
0069FE970  ldrb     w8, [x21, #0xa73]
0069FE974  cbnz     w8, #0x69fe98c
0069FE978  adrp     x0, #0x8ee6000
0069FE97C  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0069FE980  bl       #0x382bd14 ; 
0069FE984  mov      w8, #1
0069FE988  strb     w8, [x21, #0xa73]
0069FE98C  adrp     x8, #0x8ee6000
0069FE990  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0069FE994  ldr      x1, [x8]
0069FE998  ldrb     w8, [x1, #0x53]
0069FE99C  tbnz     w8, #5, #0x69fe9dc
0069FE9A0  adrp     x21, #0x9591000
0069FE9A4  ldrb     w8, [x21, #0xa74]
0069FE9A8  cbnz     w8, #0x69fe9c0
0069FE9AC  adrp     x0, #0x8ee6000
0069FE9B0  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0069FE9B4  bl       #0x382bd14 ; 
0069FE9B8  mov      w8, #1
0069FE9BC  strb     w8, [x21, #0xa74]
0069FE9C0  adrp     x8, #0x8ee6000
0069FE9C4  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0069FE9C8  ldr      x1, [x8]
0069FE9CC  ldrb     w8, [x1, #0x53]
0069FE9D0  tbnz     w8, #5, #0x69fe9e8
0069FE9D4  ldr      x21, [x19, #0x170]
0069FE9D8  b        #0x69fe9f8 ; 
0069FE9DC  ldr      x8, [x1, #0x60]
0069FE9E0  mov      x0, x19
0069FE9E4  b        #0x69fea40 ; 
0069FE9E8  ldr      x8, [x1, #0x60]
0069FE9EC  mov      x0, x19
0069FE9F0  blr      x8
0069FE9F4  mov      x21, x0
0069FE9F8  cbz      x21, #0x69feaf4
0069FE9FC  adrp     x22, #0x9591000
0069FEA00  ldrb     w8, [x22, #0xa75]
0069FEA04  cbnz     w8, #0x69fea1c
0069FEA08  adrp     x0, #0x8ee6000
0069FEA0C  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0069FEA10  bl       #0x382bd14 ; 
0069FEA14  mov      w8, #1
0069FEA18  strb     w8, [x22, #0xa75]
0069FEA1C  adrp     x8, #0x8ee6000
0069FEA20  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0069FEA24  ldr      x1, [x8]
0069FEA28  ldrb     w8, [x1, #0x53]
0069FEA2C  tbnz     w8, #5, #0x69fea38
0069FEA30  ldr      w0, [x21, #0x24]
0069FEA34  b        #0x69fea44 ; 
0069FEA38  ldr      x8, [x1, #0x60]
0069FEA3C  mov      x0, x21
0069FEA40  blr      x8
0069FEA44  cmp      w0, #0xc
0069FEA48  b.ne     #0x69fead8
0069FEA4C  mov      w0, w20
0069FEA50  mov      x1, xzr
0069FEA54  bl       #0x6a4d038 ; HotFix.BattleLogic.EntitySubCharacterTypeUtils$$IsSecondWeaponTypeValue
0069FEA58  tbz      w0, #0, #0x69fead8
0069FEA5C  mov      x0, x19
0069FEA60  mov      w1, w20
0069FEA64  mov      x2, xzr
0069FEA68  bl       #0x681f89c ; HotFix.BattleLogic.EntityCharacterData$$GetWeaponSkinId
0069FEA6C  mov      w1, w0
0069FEA70  mov      w0, w20
0069FEA74  mov      x2, xzr
0069FEA78  bl       #0x6b295c0 ; HotFix.WeaponSkinSnapshot$$Create
0069FEA7C  adrp     x21, #0x959d000
0069FEA80  ldrb     w8, [x21, #0x650]
0069FEA84  mov      x20, x0
0069FEA88  cbnz     w8, #0x69feaa0
0069FEA8C  adrp     x0, #0x8f32000
0069FEA90  ldr      x0, [x0, #0x4b8] ; GLOBAL Method$HotFix.EntityData.set_WeaponSkin()
0069FEA94  bl       #0x382bd14 ; 
0069FEA98  mov      w8, #1
0069FEA9C  strb     w8, [x21, #0x650]
0069FEAA0  adrp     x8, #0x8f32000
0069FEAA4  ldr      x8, [x8, #0x4b8] ; GLOBAL Method$HotFix.EntityData.set_WeaponSkin()
0069FEAA8  ldr      x2, [x8]
0069FEAAC  ldrb     w8, [x2, #0x53]
0069FEAB0  tbnz     w8, #5, #0x69feac8
0069FEAB4  mov      x0, x19
0069FEAB8  str      x20, [x0, #0x28]!
0069FEABC  mov      x1, x20
0069FEAC0  bl       #0x382bcb8 ; 
0069FEAC4  b        #0x69fead8 ; 
0069FEAC8  ldr      x8, [x2, #0x60]
0069FEACC  mov      x0, x19
0069FEAD0  mov      x1, x20
0069FEAD4  blr      x8
0069FEAD8  mov      x0, x19
0069FEADC  ldp      x20, x19, [sp, #0x40]
0069FEAE0  ldp      x22, x21, [sp, #0x30]
0069FEAE4  ldp      x24, x23, [sp, #0x20]
0069FEAE8  ldp      x26, x25, [sp, #0x10]
0069FEAEC  ldr      x30, [sp], #0x50
0069FEAF0  ret      
0069FEAF4  bl       #0x382bfb8 ; 

