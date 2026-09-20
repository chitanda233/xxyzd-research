; HotFix.BattleLogic.DankeSkillCreator$$GetCanStudyCount
; RVA 0x685D8A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685D8A4  stp      x30, x23, [sp, #-0x30]!
00685D8A8  stp      x22, x21, [sp, #0x10]
00685D8AC  stp      x20, x19, [sp, #0x20]
00685D8B0  adrp     x19, #0x959b000
00685D8B4  adrp     x21, #0x8f23000
00685D8B8  ldrb     w8, [x19, #0x9ed]
00685D8BC  ldr      x21, [x21, #0xb68] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetCanStudyCount() @ 0x9259d38
00685D8C0  mov      x20, x0
00685D8C4  tbnz     w8, #0, #0x685d918
00685D8C8  adrp     x0, #0x8f0c000
00685D8CC  ldr      x0, [x0, #0x1c0] ; GLOBAL Method$System.Array.IndexOf<int>() @ 0x92370c8
00685D8D0  bl       #0x382bd14 ; 
00685D8D4  adrp     x0, #0x8ee8000
00685D8D8  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685D8DC  bl       #0x382bd14 ; 
00685D8E0  adrp     x0, #0x8f23000
00685D8E4  ldr      x0, [x0, #0xb68] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetCanStudyCount() @ 0x9259d38
00685D8E8  bl       #0x382bd14 ; 
00685D8EC  adrp     x0, #0x8f09000
00685D8F0  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00685D8F4  bl       #0x382bd14 ; 
00685D8F8  adrp     x0, #0x8f08000
00685D8FC  ldr      x0, [x0, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
00685D900  bl       #0x382bd14 ; 
00685D904  adrp     x0, #0x8ebf000
00685D908  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685D90C  bl       #0x382bd14 ; 
00685D910  mov      w8, #1
00685D914  strb     w8, [x19, #0x9ed]
00685D918  ldr      x1, [x21]
00685D91C  ldrb     w8, [x1, #0x53]
00685D920  tbnz     w8, #5, #0x685d99c
00685D924  ldr      x0, [x20, #0x58]
00685D928  cbz      x0, #0x685db34
00685D92C  adrp     x8, #0x8f09000
00685D930  ldr      x8, [x8, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00685D934  ldr      x1, [x8]
00685D938  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00685D93C  cbz      x0, #0x685db34
00685D940  mov      x1, xzr
00685D944  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
00685D948  adrp     x23, #0x8ee8000
00685D94C  ldr      x23, [x23, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685D950  mov      w21, wzr
00685D954  mov      w19, wzr
00685D958  add      w22, w0, #1
00685D95C  ldr      x0, [x23]
00685D960  ldr      w8, [x0, #0xe0]
00685D964  cbnz     w8, #0x685d96c
00685D968  bl       #0x382be8c ; 
00685D96C  mov      x0, xzr
00685D970  bl       #0x64cb8c8 ; LocalModels.Const$$GetDankeMainSkillMaxCount
00685D974  cmp      w21, w0
00685D978  b.ge     #0x685d9b4
00685D97C  mov      w0, w21
00685D980  mov      w1, w22
00685D984  mov      x2, xzr
00685D988  bl       #0x64c97a8 ; LocalModelEx$$CheckSkillIndexIsOpen
00685D98C  and      w8, w0, #1
00685D990  add      w19, w19, w8
00685D994  add      w21, w21, #1
00685D998  b        #0x685d95c ; 
00685D99C  ldr      x2, [x1, #0x60]
00685D9A0  mov      x0, x20
00685D9A4  ldp      x20, x19, [sp, #0x20]
00685D9A8  ldp      x22, x21, [sp, #0x10]
00685D9AC  ldp      x30, x23, [sp], #0x30
00685D9B0  br       x2
00685D9B4  mov      x0, x20
00685D9B8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685D9BC  cbz      x0, #0x685db34
00685D9C0  ldr      w8, [x0, #0x1c8]
00685D9C4  cmp      w8, #2
00685D9C8  b.ne     #0x685d9e8
00685D9CC  ldr      x0, [x23]
00685D9D0  ldr      w8, [x0, #0xe0]
00685D9D4  cbnz     w8, #0x685d9dc
00685D9D8  bl       #0x382be8c ; 
00685D9DC  mov      x0, xzr
00685D9E0  bl       #0x64cb8c8 ; LocalModels.Const$$GetDankeMainSkillMaxCount
00685D9E4  mov      w19, w0
00685D9E8  mov      x0, x20
00685D9EC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685D9F0  cbz      x0, #0x685db34
00685D9F4  ldr      x21, [x0, #0x3b8]
00685D9F8  cbz      x21, #0x685db34
00685D9FC  adrp     x22, #0x8f08000
00685DA00  ldr      x8, [x21]
00685DA04  ldr      x22, [x22, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
00685DA08  ldrh     w9, [x8, #0x12e]
00685DA0C  ldr      x1, [x22]
00685DA10  cbz      x9, #0x685da34
00685DA14  ldr      x10, [x8, #0xb0]
00685DA18  add      x10, x10, #8
00685DA1C  ldur     x11, [x10, #-8]
00685DA20  cmp      x11, x1
00685DA24  b.eq     #0x685da44
00685DA28  subs     x9, x9, #1
00685DA2C  add      x10, x10, #0x10
00685DA30  b.ne     #0x685da1c
00685DA34  mov      w2, #0x1e
00685DA38  mov      x0, x21
00685DA3C  bl       #0x3a7e710 ; 
00685DA40  b        #0x685da54 ; 
00685DA44  ldr      w9, [x10]
00685DA48  add      w9, w9, #0x1e
00685DA4C  add      x8, x8, w9, sxtw #4
00685DA50  add      x0, x8, #0x138
00685DA54  ldp      x8, x1, [x0]
00685DA58  mov      x0, x21
00685DA5C  blr      x8
00685DA60  cbz      x0, #0x685db20
00685DA64  mov      x0, x20
00685DA68  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685DA6C  cbz      x0, #0x685db34
00685DA70  ldr      x20, [x0, #0x3b8]
00685DA74  cbz      x20, #0x685db34
00685DA78  ldr      x8, [x20]
00685DA7C  ldr      x1, [x22]
00685DA80  ldrh     w9, [x8, #0x12e]
00685DA84  cbz      x9, #0x685daa8
00685DA88  ldr      x10, [x8, #0xb0]
00685DA8C  add      x10, x10, #8
00685DA90  ldur     x11, [x10, #-8]
00685DA94  cmp      x11, x1
00685DA98  b.eq     #0x685dab8
00685DA9C  subs     x9, x9, #1
00685DAA0  add      x10, x10, #0x10
00685DAA4  b.ne     #0x685da90
00685DAA8  mov      w2, #0x1e
00685DAAC  mov      x0, x20
00685DAB0  bl       #0x3a7e710 ; 
00685DAB4  b        #0x685dac8 ; 
00685DAB8  ldr      w9, [x10]
00685DABC  add      w9, w9, #0x1e
00685DAC0  add      x8, x8, w9, sxtw #4
00685DAC4  add      x0, x8, #0x138
00685DAC8  ldp      x8, x1, [x0]
00685DACC  mov      x0, x20
00685DAD0  blr      x8
00685DAD4  adrp     x8, #0x8f0c000
00685DAD8  ldr      x8, [x8, #0x1c0] ; GLOBAL Method$System.Array.IndexOf<int>() @ 0x92370c8
00685DADC  mov      w1, #2
00685DAE0  ldr      x2, [x8]
00685DAE4  bl       #0x47b3cd0 ; System.Array$$IndexOf<int>
00685DAE8  tbnz     w0, #0x1f, #0x685db20
00685DAEC  adrp     x8, #0x8ebf000
00685DAF0  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685DAF4  ldr      x0, [x8]
00685DAF8  ldr      w8, [x0, #0xe0]
00685DAFC  cbnz     w8, #0x685db04
00685DB00  bl       #0x382be8c ; 
00685DB04  mov      w0, w19
00685DB08  ldp      x20, x19, [sp, #0x20]
00685DB0C  ldp      x22, x21, [sp, #0x10]
00685DB10  mov      w1, #5
00685DB14  mov      x2, xzr
00685DB18  ldp      x30, x23, [sp], #0x30
00685DB1C  b        #0x7bd69a0 ; System.Math$$Min
00685DB20  mov      w0, w19
00685DB24  ldp      x20, x19, [sp, #0x20]
00685DB28  ldp      x22, x21, [sp, #0x10]
00685DB2C  ldp      x30, x23, [sp], #0x30
00685DB30  ret      
00685DB34  bl       #0x382bfb8 ; 

