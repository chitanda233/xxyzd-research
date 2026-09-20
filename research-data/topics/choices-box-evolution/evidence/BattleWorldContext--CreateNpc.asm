; HotFix.BattleLogic.BattleWorldContext$$CreateNpc
; RVA 0x6A16550; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A16550  sub      sp, sp, #0xb0
006A16554  stp      x30, x27, [sp, #0x60]
006A16558  stp      x26, x25, [sp, #0x70]
006A1655C  stp      x24, x23, [sp, #0x80]
006A16560  stp      x22, x21, [sp, #0x90]
006A16564  stp      x20, x19, [sp, #0xa0]
006A16568  mrs      x26, tpidr_el0
006A1656C  ldr      x8, [x26, #0x28]
006A16570  adrp     x25, #0x959d000
006A16574  adrp     x27, #0x8f33000
006A16578  mov      x20, x5
006A1657C  str      x8, [sp, #0x58]
006A16580  ldrb     w8, [x25, #0x5e3]
006A16584  ldr      x27, [x27, #0x10] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateNpc() @ 0x923f758
006A16588  mov      x22, x4
006A1658C  mov      w24, w3
006A16590  mov      w21, w2
006A16594  mov      w23, w1
006A16598  mov      x19, x0
006A1659C  tbnz     w8, #0, #0x6a165f0
006A165A0  adrp     x0, #0x8f33000
006A165A4  ldr      x0, [x0, #0x18] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacter<EntityNpc>() @ 0x923f100
006A165A8  bl       #0x382bd14 ; 
006A165AC  adrp     x0, #0x8f33000
006A165B0  ldr      x0, [x0, #0x10] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateNpc() @ 0x923f758
006A165B4  bl       #0x382bd14 ; 
006A165B8  adrp     x0, #0x8f33000
006A165BC  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<CreateNpcEvent>() @ 0x923f2a0
006A165C0  bl       #0x382bd14 ; 
006A165C4  adrp     x0, #0x8ee6000
006A165C8  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006A165CC  bl       #0x382bd14 ; 
006A165D0  adrp     x0, #0x8f33000
006A165D4  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<CreateNpcEvent>() @ 0x92846d0
006A165D8  bl       #0x382bd14 ; 
006A165DC  adrp     x0, #0x8f0b000
006A165E0  ldr      x0, [x0, #0x490] ; GLOBAL Born @ 0x92f3130
006A165E4  bl       #0x382bd14 ; 
006A165E8  mov      w8, #1
006A165EC  strb     w8, [x25, #0x5e3]
006A165F0  ldr      x6, [x27]
006A165F4  ldrb     w8, [x6, #0x53]
006A165F8  tbnz     w8, #5, #0x6a16678
006A165FC  mov      x0, x19
006A16600  bl       #0x69fd868 ; HotFix.BattleLogic.BattleWorldContext$$CreateQNpcEntity
006A16604  adrp     x27, #0x959d000
006A16608  ldrb     w8, [x27, #0x68d]
006A1660C  mov      x25, x0
006A16610  cbnz     w8, #0x6a16628
006A16614  adrp     x0, #0x8f32000
006A16618  ldr      x0, [x0, #0x650] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.GetCharacterEntity() @ 0x923f968
006A1661C  bl       #0x382bd14 ; 
006A16620  mov      w8, #1
006A16624  strb     w8, [x27, #0x68d]
006A16628  adrp     x8, #0x8f32000
006A1662C  ldr      x8, [x8, #0x650] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.GetCharacterEntity() @ 0x923f968
006A16630  ldr      x2, [x8]
006A16634  ldrb     w8, [x2, #0x53]
006A16638  tbnz     w8, #5, #0x6a166b0
006A1663C  adrp     x27, #0x9598000
006A16640  ldrb     w8, [x27, #0xfcc]
006A16644  cbnz     w8, #0x6a1665c
006A16648  adrp     x0, #0x8f06000
006A1664C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006A16650  bl       #0x382bd14 ; 
006A16654  mov      w8, #1
006A16658  strb     w8, [x27, #0xfcc]
006A1665C  adrp     x8, #0x8f06000
006A16660  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006A16664  ldr      x1, [x8]
006A16668  ldrb     w8, [x1, #0x53]
006A1666C  tbnz     w8, #5, #0x6a166c4
006A16670  ldr      x0, [x19, #0x200]
006A16674  b        #0x6a166d0 ; 
006A16678  ldr      x8, [x22, #0x10]
006A1667C  ldr      q0, [x22]
006A16680  ldr      x9, [x6, #0x60]
006A16684  and      w3, w24, #1
006A16688  add      x4, sp, #0x40
006A1668C  mov      x0, x19
006A16690  mov      w1, w23
006A16694  mov      w2, w21
006A16698  mov      x5, x20
006A1669C  str      x8, [sp, #0x50]
006A166A0  str      q0, [sp, #0x40]
006A166A4  blr      x9
006A166A8  mov      x22, x0
006A166AC  b        #0x6a16aac ; 
006A166B0  ldr      x8, [x2, #0x60]
006A166B4  mov      x0, x19
006A166B8  mov      w1, w23
006A166BC  blr      x8
006A166C0  b        #0x6a166e0 ; 
006A166C4  ldr      x8, [x1, #0x60]
006A166C8  mov      x0, x19
006A166CC  blr      x8
006A166D0  cbz      x0, #0x6a16adc
006A166D4  mov      w1, w23
006A166D8  mov      x2, xzr
006A166DC  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
006A166E0  mov      x3, x0
006A166E4  mov      w2, #4
006A166E8  mov      x0, x19
006A166EC  mov      x1, x25
006A166F0  mov      x4, xzr
006A166F4  mov      x5, xzr
006A166F8  bl       #0x69fe730 ; HotFix.BattleLogic.BattleWorldContext$$CreateCharacterData
006A166FC  ldr      x8, [x22, #0x10]
006A16700  ldr      q0, [x22]
006A16704  str      x8, [sp, #0x30]
006A16708  str      q0, [sp, #0x20]
006A1670C  cbz      x0, #0x6a16adc
006A16710  ldr      q0, [sp, #0x20]
006A16714  ldr      x8, [sp, #0x30]
006A16718  mov      x1, sp
006A1671C  mov      x2, xzr
006A16720  mov      x23, x0
006A16724  str      q0, [sp]
006A16728  str      x8, [sp, #0x10]
006A1672C  bl       #0x6b29288 ; HotFix.EntityData$$set_Position
006A16730  adrp     x22, #0x959b000
006A16734  ldrb     w8, [x22, #0x794]
006A16738  cbnz     w8, #0x6a16750
006A1673C  adrp     x0, #0x8f21000
006A16740  ldr      x0, [x0, #0xfe0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_InitAngle() @ 0x92634e0
006A16744  bl       #0x382bd14 ; 
006A16748  mov      w8, #1
006A1674C  strb     w8, [x22, #0x794]
006A16750  adrp     x8, #0x8f21000
006A16754  ldr      x8, [x8, #0xfe0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_InitAngle() @ 0x92634e0
006A16758  ldr      x2, [x8]
006A1675C  ldrb     w8, [x2, #0x53]
006A16760  tbnz     w8, #5, #0x6a16770
006A16764  mov      w8, #0xb40000
006A16768  str      x8, [x23, #0x160]
006A1676C  b        #0x6a16780 ; 
006A16770  ldr      x8, [x2, #0x60]
006A16774  mov      w1, #0xb40000
006A16778  mov      x0, x23
006A1677C  blr      x8
006A16780  adrp     x8, #0x8f33000
006A16784  ldr      x8, [x8, #0x18] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacter<EntityNpc>() @ 0x923f100
006A16788  mov      x0, x19
006A1678C  mov      x1, x23
006A16790  ldr      x2, [x8]
006A16794  bl       #0x453ffcc ; HotFix.BattleLogic.BattleWorldContext$$CreateCharacter<object>
006A16798  cbz      x0, #0x6a16adc
006A1679C  cmp      w21, #8
006A167A0  and      w27, w24, #1
006A167A4  mov      w24, #1
006A167A8  cset     w8, eq
006A167AC  str      w21, [x0, #0x624]
006A167B0  str      w24, [x0, #0x62c]
006A167B4  strb     w27, [x0, #0x640]
006A167B8  strb     w8, [x0, #0x628]
006A167BC  adrp     x25, #0x9599000
006A167C0  ldrb     w8, [x25, #0x27e]
006A167C4  mov      x22, x0
006A167C8  cbnz     w8, #0x6a167dc
006A167CC  adrp     x0, #0x8f07000
006A167D0  ldr      x0, [x0, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.SetChooseAble() @ 0x9262c18
006A167D4  bl       #0x382bd14 ; 
006A167D8  strb     w24, [x25, #0x27e]
006A167DC  adrp     x8, #0x8f07000
006A167E0  ldr      x8, [x8, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.SetChooseAble() @ 0x9262c18
006A167E4  ldr      x2, [x8]
006A167E8  ldrb     w8, [x2, #0x53]
006A167EC  tbnz     w8, #5, #0x6a167f8
006A167F0  strb     wzr, [x22, #0x308]
006A167F4  b        #0x6a16808 ; 
006A167F8  ldr      x8, [x2, #0x60]
006A167FC  mov      x0, x22
006A16800  mov      w1, wzr
006A16804  blr      x8
006A16808  mov      w1, #1
006A1680C  mov      x0, x22
006A16810  mov      x2, xzr
006A16814  bl       #0x67f7800 ; HotFix.BattleLogic.EntityCharacter$$TrySetInvincible
006A16818  mov      x0, x22
006A1681C  mov      x1, xzr
006A16820  str      x20, [x22, #0x638]
006A16824  bl       #0x6594ab4 ; 
006A16828  adrp     x8, #0x8f33000
006A1682C  ldr      x8, [x8, #0x20] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<CreateNpcEvent>() @ 0x923f2a0
006A16830  ldr      x24, [x8]
006A16834  ldr      x8, [x24, #0x38]
006A16838  cbnz     x8, #0x6a16844
006A1683C  mov      x0, x24
006A16840  bl       #0x3a7e668 ; 
006A16844  ldrb     w8, [x24, #0x53]
006A16848  tbnz     w8, #5, #0x6a16888
006A1684C  adrp     x25, #0x9591000
006A16850  ldrb     w8, [x25, #0xa61]
006A16854  cbnz     w8, #0x6a1686c
006A16858  adrp     x0, #0x8ee6000
006A1685C  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
006A16860  bl       #0x382bd14 ; 
006A16864  mov      w8, #1
006A16868  strb     w8, [x25, #0xa61]
006A1686C  adrp     x8, #0x8ee6000
006A16870  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
006A16874  ldr      x1, [x8]
006A16878  ldrb     w8, [x1, #0x53]
006A1687C  tbnz     w8, #5, #0x6a1689c
006A16880  ldr      x0, [x19, #0x1e8]
006A16884  b        #0x6a168a8 ; 
006A16888  ldr      x8, [x24, #0x60]
006A1688C  mov      x0, x19
006A16890  mov      x1, x24
006A16894  blr      x8
006A16898  b        #0x6a168b8 ; 
006A1689C  ldr      x8, [x1, #0x60]
006A168A0  mov      x0, x19
006A168A4  blr      x8
006A168A8  cbz      x0, #0x6a16adc
006A168AC  ldr      x8, [x24, #0x38]
006A168B0  ldr      x1, [x8]
006A168B4  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
006A168B8  adrp     x8, #0x8ee6000
006A168BC  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006A168C0  mov      x24, x0
006A168C4  ldr      x1, [x8]
006A168C8  ldrb     w8, [x1, #0x53]
006A168CC  tbnz     w8, #5, #0x6a168d8
006A168D0  ldr      x1, [x22, #0x38]
006A168D4  b        #0x6a168e8 ; 
006A168D8  ldr      x8, [x1, #0x60]
006A168DC  mov      x0, x22
006A168E0  blr      x8
006A168E4  mov      x1, x0
006A168E8  cbz      x24, #0x6a16adc
006A168EC  mov      x25, x24
006A168F0  str      x1, [x25, #0x20]!
006A168F4  mov      x0, x25
006A168F8  bl       #0x382bcb8 ; 
006A168FC  str      w21, [x25, #0x18]
006A16900  adrp     x21, #0x959d000
006A16904  ldrb     w8, [x21, #0x694]
006A16908  cbnz     w8, #0x6a16920
006A1690C  adrp     x0, #0x8f1e000
006A16910  ldr      x0, [x0, #0x5b0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.GetAnimator() @ 0x9262630
006A16914  bl       #0x382bd14 ; 
006A16918  mov      w8, #1
006A1691C  strb     w8, [x21, #0x694]
006A16920  adrp     x8, #0x8f1e000
006A16924  ldr      x8, [x8, #0x5b0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.GetAnimator() @ 0x9262630
006A16928  ldr      x1, [x8]
006A1692C  ldrb     w8, [x1, #0x53]
006A16930  tbnz     w8, #5, #0x6a1693c
006A16934  ldr      x1, [x22, #0x80]
006A16938  b        #0x6a1694c ; 
006A1693C  ldr      x8, [x1, #0x60]
006A16940  mov      x0, x22
006A16944  blr      x8
006A16948  mov      x1, x0
006A1694C  mov      x21, x24
006A16950  str      x1, [x21, #0x28]!
006A16954  mov      x0, x21
006A16958  bl       #0x382bcb8 ; 
006A1695C  str      x20, [x21, #8]
006A16960  strb     w27, [x21, #0x14]
006A16964  ldr      x20, [x19, #0x1e0]
006A16968  cbz      x20, #0x6a16adc
006A1696C  adrp     x9, #0x8f33000
006A16970  ldr      x9, [x9, #0x28] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<CreateNpcEvent>() @ 0x92846d0
006A16974  ldr      x8, [x20]
006A16978  ldr      x21, [x9]
006A1697C  ldrh     w9, [x8, #0x12e]
006A16980  ldr      x1, [x21, #0x20]
006A16984  ldrh     w2, [x21, #0x50]
006A16988  cbz      x9, #0x6a169ac
006A1698C  ldr      x10, [x8, #0xb0]
006A16990  add      x10, x10, #8
006A16994  ldur     x11, [x10, #-8]
006A16998  cmp      x11, x1
006A1699C  b.eq     #0x6a169b8
006A169A0  subs     x9, x9, #1
006A169A4  add      x10, x10, #0x10
006A169A8  b.ne     #0x6a16994
006A169AC  mov      x0, x20
006A169B0  bl       #0x3a7e710 ; 
006A169B4  b        #0x6a169c8 ; 
006A169B8  ldr      w9, [x10]
006A169BC  add      w9, w9, w2
006A169C0  add      x8, x8, w9, sxtw #4
006A169C4  add      x0, x8, #0x138
006A169C8  ldr      x0, [x0, #8]
006A169CC  mov      x1, x21
006A169D0  bl       #0x382be88 ; 
006A169D4  ldr      x8, [x0, #8]
006A169D8  mov      x2, x0
006A169DC  mov      x0, x20
006A169E0  mov      x1, x24
006A169E4  blr      x8
006A169E8  adrp     x20, #0x9591000
006A169EC  ldrb     w8, [x20, #0xa74]
006A169F0  cbnz     w8, #0x6a16a08
006A169F4  adrp     x0, #0x8ee6000
006A169F8  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
006A169FC  bl       #0x382bd14 ; 
006A16A00  mov      w8, #1
006A16A04  strb     w8, [x20, #0xa74]
006A16A08  adrp     x8, #0x8ee6000
006A16A0C  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
006A16A10  ldr      x1, [x8]
006A16A14  ldrb     w8, [x1, #0x53]
006A16A18  tbnz     w8, #5, #0x6a16a24
006A16A1C  ldr      x20, [x23, #0x170]
006A16A20  b        #0x6a16a34 ; 
006A16A24  ldr      x8, [x1, #0x60]
006A16A28  mov      x0, x23
006A16A2C  blr      x8
006A16A30  mov      x20, x0
006A16A34  cbz      x20, #0x6a16adc
006A16A38  adrp     x21, #0x9598000
006A16A3C  ldrb     w8, [x21, #0xcbd]
006A16A40  cbnz     w8, #0x6a16a58
006A16A44  adrp     x0, #0x8efd000
006A16A48  ldr      x0, [x0, #0x600] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ID() @ 0x924f728
006A16A4C  bl       #0x382bd14 ; 
006A16A50  mov      w8, #1
006A16A54  strb     w8, [x21, #0xcbd]
006A16A58  adrp     x8, #0x8efd000
006A16A5C  ldr      x8, [x8, #0x600] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ID() @ 0x924f728
006A16A60  ldr      x1, [x8]
006A16A64  ldrb     w8, [x1, #0x53]
006A16A68  tbnz     w8, #5, #0x6a16a74
006A16A6C  ldr      w0, [x20, #0x20]
006A16A70  b        #0x6a16a80 ; 
006A16A74  ldr      x8, [x1, #0x60]
006A16A78  mov      x0, x20
006A16A7C  blr      x8
006A16A80  cmp      w0, #7
006A16A84  b.eq     #0x6a16aa0
006A16A88  adrp     x8, #0x8f0b000
006A16A8C  ldr      x8, [x8, #0x490] ; GLOBAL Born @ 0x92f3130
006A16A90  mov      x0, x22
006A16A94  mov      x2, xzr
006A16A98  ldr      x1, [x8]
006A16A9C  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
006A16AA0  ldr      w8, [x19, #0x3d0]
006A16AA4  add      w8, w8, #1
006A16AA8  str      w8, [x19, #0x3d0]
006A16AAC  ldr      x8, [x26, #0x28]
006A16AB0  ldr      x9, [sp, #0x58]
006A16AB4  cmp      x8, x9
006A16AB8  b.ne     #0x6a16ae0
006A16ABC  mov      x0, x22
006A16AC0  ldp      x20, x19, [sp, #0xa0]
006A16AC4  ldp      x22, x21, [sp, #0x90]
006A16AC8  ldp      x24, x23, [sp, #0x80]
006A16ACC  ldp      x26, x25, [sp, #0x70]
006A16AD0  ldp      x30, x27, [sp, #0x60]
006A16AD4  add      sp, sp, #0xb0
006A16AD8  ret      
006A16ADC  bl       #0x382bfb8 ; 
006A16AE0  bl       #0x89edb60 ; 

