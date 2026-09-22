; HotFix.BattleLogic.EntityCharacter$$InitWeapon
; RVA 0x67D93D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067D93D4  stp      x29, x30, [sp, #-0x60]!
0067D93D8  stp      x28, x27, [sp, #0x10]
0067D93DC  stp      x26, x25, [sp, #0x20]
0067D93E0  stp      x24, x23, [sp, #0x30]
0067D93E4  stp      x22, x21, [sp, #0x40]
0067D93E8  stp      x20, x19, [sp, #0x50]
0067D93EC  adrp     x20, #0x959b000
0067D93F0  adrp     x21, #0x8f1e000
0067D93F4  ldrb     w8, [x20, #0x34d]
0067D93F8  ldr      x21, [x21, #0x808] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitWeapon()
0067D93FC  mov      x19, x0
0067D9400  tbnz     w8, #0, #0x67d9514
0067D9404  adrp     x0, #0x8ee2000
0067D9408  ldr      x0, [x0, #0xf30] ; GLOBAL System.Action<DeterministicAnimationEvent>_TypeInfo
0067D940C  bl       #0x382bd14 ; 
0067D9410  adrp     x0, #0x8ec3000
0067D9414  ldr      x0, [x0, #0xdc0] ; GLOBAL Method$System.Array.Empty<object>()
0067D9418  bl       #0x382bd14 ; 
0067D941C  adrp     x0, #0x8f1e000
0067D9420  ldr      x0, [x0, #0x810] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateCeaseFire_TypeInfo
0067D9424  bl       #0x382bd14 ; 
0067D9428  adrp     x0, #0x8f1e000
0067D942C  ldr      x0, [x0, #0x818] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateEnter_TypeInfo
0067D9430  bl       #0x382bd14 ; 
0067D9434  adrp     x0, #0x8f1e000
0067D9438  ldr      x0, [x0, #0x820] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateExit_TypeInfo
0067D943C  bl       #0x382bd14 ; 
0067D9440  adrp     x0, #0x8f1e000
0067D9444  ldr      x0, [x0, #0x828] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateFireHold_TypeInfo
0067D9448  bl       #0x382bd14 ; 
0067D944C  adrp     x0, #0x8f1e000
0067D9450  ldr      x0, [x0, #0x830] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateHold_TypeInfo
0067D9454  bl       #0x382bd14 ; 
0067D9458  adrp     x0, #0x8f1e000
0067D945C  ldr      x0, [x0, #0x838] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateIdle_TypeInfo
0067D9460  bl       #0x382bd14 ; 
0067D9464  adrp     x0, #0x8f1e000
0067D9468  ldr      x0, [x0, #0x840] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityRef, EntityRef>.Clear()
0067D946C  bl       #0x382bd14 ; 
0067D9470  adrp     x0, #0x8ee6000
0067D9474  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D9478  bl       #0x382bd14 ; 
0067D947C  adrp     x0, #0x8f1e000
0067D9480  ldr      x0, [x0, #0x808] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitWeapon()
0067D9484  bl       #0x382bd14 ; 
0067D9488  adrp     x0, #0x8f1e000
0067D948C  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnAnimatorEvent()
0067D9490  bl       #0x382bd14 ; 
0067D9494  adrp     x0, #0x8f1e000
0067D9498  ldr      x0, [x0, #0x850] ; GLOBAL Method$System.Linq.Enumerable.Select<FPVector3, FPVector3>()
0067D949C  bl       #0x382bd14 ; 
0067D94A0  adrp     x0, #0x8f1e000
0067D94A4  ldr      x0, [x0, #0x858] ; GLOBAL Method$System.Linq.Enumerable.ToList<FPVector3>()
0067D94A8  bl       #0x382bd14 ; 
0067D94AC  adrp     x0, #0x8f0b000
0067D94B0  ldr      x0, [x0, #0x720] ; GLOBAL HotFix.BattleLogic.FPStateController_TypeInfo
0067D94B4  bl       #0x382bd14 ; 
0067D94B8  adrp     x0, #0x8f09000
0067D94BC  ldr      x0, [x0, #0x820] ; GLOBAL System.Func<FPVector3, FPVector3>_TypeInfo
0067D94C0  bl       #0x382bd14 ; 
0067D94C4  adrp     x0, #0x8f0b000
0067D94C8  ldr      x0, [x0, #0x758] ; GLOBAL Method$HotFix.Common.StateController<int, FP>.ActiveState()
0067D94CC  bl       #0x382bd14 ; 
0067D94D0  adrp     x0, #0x8f1e000
0067D94D4  ldr      x0, [x0, #0x860] ; GLOBAL Method$HotFix.Common.StateController<int, FP>.Init()
0067D94D8  bl       #0x382bd14 ; 
0067D94DC  adrp     x0, #0x8f0b000
0067D94E0  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.Common.StateController<int, FP>.RegisterState()
0067D94E4  bl       #0x382bd14 ; 
0067D94E8  adrp     x0, #0x8f1e000
0067D94EC  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.<>c__DisplayClass613_0.<InitWeapon>b__0()
0067D94F0  bl       #0x382bd14 ; 
0067D94F4  adrp     x0, #0x8f1e000
0067D94F8  ldr      x0, [x0, #0x870] ; GLOBAL HotFix.BattleLogic.EntityCharacter.<>c__DisplayClass613_0_TypeInfo
0067D94FC  bl       #0x382bd14 ; 
0067D9500  adrp     x0, #0x8f10000
0067D9504  ldr      x0, [x0, #0xe00] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<Weapon>()
0067D9508  bl       #0x382bd14 ; 
0067D950C  mov      w8, #1
0067D9510  strb     w8, [x20, #0x34d]
0067D9514  ldr      x1, [x21]
0067D9518  ldrb     w8, [x1, #0x53]
0067D951C  tbnz     w8, #5, #0x67d9568
0067D9520  adrp     x8, #0x8f1e000
0067D9524  ldr      x8, [x8, #0x870] ; GLOBAL HotFix.BattleLogic.EntityCharacter.<>c__DisplayClass613_0_TypeInfo
0067D9528  adrp     x29, #0x8ee6000
0067D952C  ldr      x0, [x8]
0067D9530  ldr      x29, [x29, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D9534  bl       #0x382bfa0 ; 
0067D9538  mov      x1, xzr
0067D953C  mov      x20, x0
0067D9540  bl       #0x681ec08 ; HotFix.BattleLogic.EntityCharacter.<>c__DisplayClass613_0$$.ctor
0067D9544  add      x0, x19, #0x3f0
0067D9548  mov      w2, #0x200
0067D954C  mov      w1, wzr
0067D9550  bl       #0x89edb70 ; 
0067D9554  ldr      x1, [x29]
0067D9558  ldrb     w8, [x1, #0x53]
0067D955C  tbnz     w8, #5, #0x67d958c
0067D9560  ldr      x21, [x19, #0x38]
0067D9564  b        #0x67d959c ; 
0067D9568  ldr      x2, [x1, #0x60]
0067D956C  mov      x0, x19
0067D9570  ldp      x20, x19, [sp, #0x50]
0067D9574  ldp      x22, x21, [sp, #0x40]
0067D9578  ldp      x24, x23, [sp, #0x30]
0067D957C  ldp      x26, x25, [sp, #0x20]
0067D9580  ldp      x28, x27, [sp, #0x10]
0067D9584  ldp      x29, x30, [sp], #0x60
0067D9588  br       x2
0067D958C  ldr      x8, [x1, #0x60]
0067D9590  mov      x0, x19
0067D9594  blr      x8
0067D9598  mov      x21, x0
0067D959C  cbz      x21, #0x67da30c
0067D95A0  adrp     x22, #0x9598000
0067D95A4  ldrb     w8, [x22, #0xfca]
0067D95A8  cbnz     w8, #0x67d95c0
0067D95AC  adrp     x0, #0x8f06000
0067D95B0  ldr      x0, [x0, #0x350] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_CurWeaponId()
0067D95B4  bl       #0x382bd14 ; 
0067D95B8  mov      w8, #1
0067D95BC  strb     w8, [x22, #0xfca]
0067D95C0  adrp     x8, #0x8f06000
0067D95C4  ldr      x8, [x8, #0x350] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_CurWeaponId()
0067D95C8  ldr      x1, [x8]
0067D95CC  ldrb     w8, [x1, #0x53]
0067D95D0  tbnz     w8, #5, #0x67d95dc
0067D95D4  ldr      w21, [x21, #0x180]
0067D95D8  b        #0x67d95ec ; 
0067D95DC  ldr      x8, [x1, #0x60]
0067D95E0  mov      x0, x21
0067D95E4  blr      x8
0067D95E8  mov      w21, w0
0067D95EC  adrp     x26, #0x8ee6000
0067D95F0  ldr      x26, [x26, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D95F4  cmp      w21, #0
0067D95F8  adrp     x27, #0x9591000
0067D95FC  b.le     #0x67d9608
0067D9600  mov      w22, #1
0067D9604  b        #0x67d980c ; 
0067D9608  ldr      x1, [x29]
0067D960C  ldrb     w8, [x1, #0x53]
0067D9610  tbnz     w8, #5, #0x67d961c
0067D9614  ldr      x21, [x19, #0x38]
0067D9618  b        #0x67d962c ; 
0067D961C  ldr      x8, [x1, #0x60]
0067D9620  mov      x0, x19
0067D9624  blr      x8
0067D9628  mov      x21, x0
0067D962C  cbz      x21, #0x67da30c
0067D9630  ldrb     w8, [x27, #0xa74]
0067D9634  cbnz     w8, #0x67d964c
0067D9638  adrp     x0, #0x8ee6000
0067D963C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D9640  bl       #0x382bd14 ; 
0067D9644  mov      w8, #1
0067D9648  strb     w8, [x27, #0xa74]
0067D964C  ldr      x1, [x26]
0067D9650  ldrb     w8, [x1, #0x53]
0067D9654  tbnz     w8, #5, #0x67d9660
0067D9658  ldr      x21, [x21, #0x170]
0067D965C  b        #0x67d9670 ; 
0067D9660  ldr      x8, [x1, #0x60]
0067D9664  mov      x0, x21
0067D9668  blr      x8
0067D966C  mov      x21, x0
0067D9670  cbz      x21, #0x67da30c
0067D9674  adrp     x22, #0x9598000
0067D9678  ldrb     w8, [x22, #0xfbd]
0067D967C  cbnz     w8, #0x67d9694
0067D9680  adrp     x0, #0x8f05000
0067D9684  ldr      x0, [x0, #0xc50] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WeaponID()
0067D9688  bl       #0x382bd14 ; 
0067D968C  mov      w8, #1
0067D9690  strb     w8, [x22, #0xfbd]
0067D9694  adrp     x8, #0x8f05000
0067D9698  ldr      x8, [x8, #0xc50] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WeaponID()
0067D969C  ldr      x1, [x8]
0067D96A0  ldrb     w8, [x1, #0x53]
0067D96A4  tbnz     w8, #5, #0x67d96b0
0067D96A8  ldr      x0, [x21, #0x90]
0067D96AC  b        #0x67d96bc ; 
0067D96B0  ldr      x8, [x1, #0x60]
0067D96B4  mov      x0, x21
0067D96B8  blr      x8
0067D96BC  cbz      x0, #0x67da30c
0067D96C0  ldr      w8, [x0, #0x18]
0067D96C4  cbz      w8, #0x67da310
0067D96C8  ldr      x1, [x29]
0067D96CC  ldr      w21, [x0, #0x20]
0067D96D0  ldrb     w8, [x1, #0x53]
0067D96D4  tbnz     w8, #5, #0x67d96e0
0067D96D8  ldr      x22, [x19, #0x38]
0067D96DC  b        #0x67d96f0 ; 
0067D96E0  ldr      x8, [x1, #0x60]
0067D96E4  mov      x0, x19
0067D96E8  blr      x8
0067D96EC  mov      x22, x0
0067D96F0  cbz      x22, #0x67da30c
0067D96F4  ldrb     w8, [x27, #0xa74]
0067D96F8  cbnz     w8, #0x67d9710
0067D96FC  adrp     x0, #0x8ee6000
0067D9700  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D9704  bl       #0x382bd14 ; 
0067D9708  mov      w8, #1
0067D970C  strb     w8, [x27, #0xa74]
0067D9710  ldr      x1, [x26]
0067D9714  ldrb     w8, [x1, #0x53]
0067D9718  tbnz     w8, #5, #0x67d9724
0067D971C  ldr      x22, [x22, #0x170]
0067D9720  b        #0x67d9734 ; 
0067D9724  ldr      x8, [x1, #0x60]
0067D9728  mov      x0, x22
0067D972C  blr      x8
0067D9730  mov      x22, x0
0067D9734  cbz      x22, #0x67da30c
0067D9738  adrp     x23, #0x959b000
0067D973C  ldrb     w8, [x23, #0x3c0]
0067D9740  cbnz     w8, #0x67d9758
0067D9744  adrp     x0, #0x8f1e000
0067D9748  ldr      x0, [x0, #0x878] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_rotateWhenAttack()
0067D974C  bl       #0x382bd14 ; 
0067D9750  mov      w8, #1
0067D9754  strb     w8, [x23, #0x3c0]
0067D9758  adrp     x8, #0x8f1e000
0067D975C  ldr      x8, [x8, #0x878] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_rotateWhenAttack()
0067D9760  ldr      x1, [x8]
0067D9764  ldrb     w8, [x1, #0x53]
0067D9768  tbnz     w8, #5, #0x67d9774
0067D976C  ldr      x0, [x22, #0xc8]
0067D9770  b        #0x67d9780 ; 
0067D9774  ldr      x8, [x1, #0x60]
0067D9778  mov      x0, x22
0067D977C  blr      x8
0067D9780  cbz      x0, #0x67da30c
0067D9784  ldr      w8, [x0, #0x18]
0067D9788  cbz      w8, #0x67da310
0067D978C  ldr      x1, [x29]
0067D9790  ldr      w8, [x0, #0x20]
0067D9794  ldrb     w9, [x1, #0x53]
0067D9798  cmp      w8, #1
0067D979C  cset     w22, eq
0067D97A0  tbnz     w9, #5, #0x67d97ac
0067D97A4  ldr      x23, [x19, #0x38]
0067D97A8  b        #0x67d97bc ; 
0067D97AC  ldr      x8, [x1, #0x60]
0067D97B0  mov      x0, x19
0067D97B4  blr      x8
0067D97B8  mov      x23, x0
0067D97BC  cbz      x23, #0x67da30c
0067D97C0  adrp     x24, #0x959b000
0067D97C4  ldrb     w8, [x24, #0x3c1]
0067D97C8  cbnz     w8, #0x67d97e0
0067D97CC  adrp     x0, #0x8f1e000
0067D97D0  ldr      x0, [x0, #0x880] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_CurWeaponId()
0067D97D4  bl       #0x382bd14 ; 
0067D97D8  mov      w8, #1
0067D97DC  strb     w8, [x24, #0x3c1]
0067D97E0  adrp     x8, #0x8f1e000
0067D97E4  ldr      x8, [x8, #0x880] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_CurWeaponId()
0067D97E8  ldr      x2, [x8]
0067D97EC  ldrb     w8, [x2, #0x53]
0067D97F0  tbnz     w8, #5, #0x67d97fc
0067D97F4  str      w21, [x23, #0x180]
0067D97F8  b        #0x67d980c ; 
0067D97FC  ldr      x8, [x2, #0x60]
0067D9800  mov      x0, x23
0067D9804  mov      w1, w21
0067D9808  blr      x8
0067D980C  ldr      x1, [x29]
0067D9810  ldrb     w8, [x1, #0x53]
0067D9814  tbnz     w8, #5, #0x67d9820
0067D9818  ldr      x23, [x19, #0x38]
0067D981C  b        #0x67d9830 ; 
0067D9820  ldr      x8, [x1, #0x60]
0067D9824  mov      x0, x19
0067D9828  blr      x8
0067D982C  mov      x23, x0
0067D9830  cbz      x23, #0x67da30c
0067D9834  adrp     x24, #0x9591000
0067D9838  ldrb     w8, [x24, #0xa73]
0067D983C  cbnz     w8, #0x67d9854
0067D9840  adrp     x0, #0x8ee6000
0067D9844  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0067D9848  bl       #0x382bd14 ; 
0067D984C  mov      w8, #1
0067D9850  strb     w8, [x24, #0xa73]
0067D9854  adrp     x28, #0x8ee6000
0067D9858  ldr      x28, [x28, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0067D985C  ldr      x1, [x28]
0067D9860  ldrb     w8, [x1, #0x53]
0067D9864  tbnz     w8, #5, #0x67d9898
0067D9868  ldrb     w8, [x27, #0xa74]
0067D986C  cbnz     w8, #0x67d9884
0067D9870  adrp     x0, #0x8ee6000
0067D9874  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D9878  bl       #0x382bd14 ; 
0067D987C  mov      w8, #1
0067D9880  strb     w8, [x27, #0xa74]
0067D9884  ldr      x1, [x26]
0067D9888  ldrb     w8, [x1, #0x53]
0067D988C  tbnz     w8, #5, #0x67d98a8
0067D9890  ldr      x23, [x23, #0x170]
0067D9894  b        #0x67d98b8 ; 
0067D9898  ldr      x8, [x1, #0x60]
0067D989C  mov      x0, x23
0067D98A0  blr      x8
0067D98A4  b        #0x67d990c ; 
0067D98A8  ldr      x8, [x1, #0x60]
0067D98AC  mov      x0, x23
0067D98B0  blr      x8
0067D98B4  mov      x23, x0
0067D98B8  cbz      x23, #0x67da30c
0067D98BC  adrp     x29, #0x9591000
0067D98C0  ldrb     w8, [x29, #0xa75]
0067D98C4  cbnz     w8, #0x67d98dc
0067D98C8  adrp     x0, #0x8ee6000
0067D98CC  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0067D98D0  bl       #0x382bd14 ; 
0067D98D4  mov      w8, #1
0067D98D8  strb     w8, [x29, #0xa75]
0067D98DC  adrp     x8, #0x8ee6000
0067D98E0  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0067D98E4  ldr      x1, [x8]
0067D98E8  ldrb     w8, [x1, #0x53]
0067D98EC  tbnz     w8, #5, #0x67d98f8
0067D98F0  ldr      w0, [x23, #0x24]
0067D98F4  b        #0x67d9904 ; 
0067D98F8  ldr      x8, [x1, #0x60]
0067D98FC  mov      x0, x23
0067D9900  blr      x8
0067D9904  adrp     x29, #0x8ee6000
0067D9908  ldr      x29, [x29, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D990C  cmp      w0, #1
0067D9910  b.eq     #0x67d9af4
0067D9914  ldr      x1, [x29]
0067D9918  ldrb     w8, [x1, #0x53]
0067D991C  tbnz     w8, #5, #0x67d9928
0067D9920  ldr      x23, [x19, #0x38]
0067D9924  b        #0x67d9938 ; 
0067D9928  ldr      x8, [x1, #0x60]
0067D992C  mov      x0, x19
0067D9930  blr      x8
0067D9934  mov      x23, x0
0067D9938  cbz      x23, #0x67da30c
0067D993C  ldrb     w8, [x24, #0xa73]
0067D9940  cbnz     w8, #0x67d9958
0067D9944  adrp     x0, #0x8ee6000
0067D9948  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0067D994C  bl       #0x382bd14 ; 
0067D9950  mov      w8, #1
0067D9954  strb     w8, [x24, #0xa73]
0067D9958  ldr      x1, [x28]
0067D995C  ldrb     w8, [x1, #0x53]
0067D9960  tbnz     w8, #5, #0x67d9994
0067D9964  ldrb     w8, [x27, #0xa74]
0067D9968  cbnz     w8, #0x67d9980
0067D996C  adrp     x0, #0x8ee6000
0067D9970  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D9974  bl       #0x382bd14 ; 
0067D9978  mov      w8, #1
0067D997C  strb     w8, [x27, #0xa74]
0067D9980  ldr      x1, [x26]
0067D9984  ldrb     w8, [x1, #0x53]
0067D9988  tbnz     w8, #5, #0x67d99a4
0067D998C  ldr      x23, [x23, #0x170]
0067D9990  b        #0x67d99b4 ; 
0067D9994  ldr      x8, [x1, #0x60]
0067D9998  mov      x0, x23
0067D999C  blr      x8
0067D99A0  b        #0x67d9a08 ; 
0067D99A4  ldr      x8, [x1, #0x60]
0067D99A8  mov      x0, x23
0067D99AC  blr      x8
0067D99B0  mov      x23, x0
0067D99B4  cbz      x23, #0x67da30c
0067D99B8  adrp     x29, #0x9591000
0067D99BC  ldrb     w8, [x29, #0xa75]
0067D99C0  cbnz     w8, #0x67d99d8
0067D99C4  adrp     x0, #0x8ee6000
0067D99C8  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0067D99CC  bl       #0x382bd14 ; 
0067D99D0  mov      w8, #1
0067D99D4  strb     w8, [x29, #0xa75]
0067D99D8  adrp     x8, #0x8ee6000
0067D99DC  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0067D99E0  ldr      x1, [x8]
0067D99E4  ldrb     w8, [x1, #0x53]
0067D99E8  tbnz     w8, #5, #0x67d99f4
0067D99EC  ldr      w0, [x23, #0x24]
0067D99F0  b        #0x67d9a00 ; 
0067D99F4  ldr      x8, [x1, #0x60]
0067D99F8  mov      x0, x23
0067D99FC  blr      x8
0067D9A00  adrp     x29, #0x8ee6000
0067D9A04  ldr      x29, [x29, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D9A08  cmp      w0, #0xc
0067D9A0C  b.eq     #0x67d9af4
0067D9A10  ldr      x1, [x29]
0067D9A14  ldrb     w8, [x1, #0x53]
0067D9A18  tbnz     w8, #5, #0x67d9a24
0067D9A1C  ldr      x23, [x19, #0x38]
0067D9A20  b        #0x67d9a34 ; 
0067D9A24  ldr      x8, [x1, #0x60]
0067D9A28  mov      x0, x19
0067D9A2C  blr      x8
0067D9A30  mov      x23, x0
0067D9A34  cbz      x23, #0x67da30c
0067D9A38  ldrb     w8, [x24, #0xa73]
0067D9A3C  cbnz     w8, #0x67d9a54
0067D9A40  adrp     x0, #0x8ee6000
0067D9A44  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0067D9A48  bl       #0x382bd14 ; 
0067D9A4C  mov      w8, #1
0067D9A50  strb     w8, [x24, #0xa73]
0067D9A54  ldr      x1, [x28]
0067D9A58  ldrb     w8, [x1, #0x53]
0067D9A5C  tbnz     w8, #5, #0x67d9ae0
0067D9A60  ldrb     w8, [x27, #0xa74]
0067D9A64  cbnz     w8, #0x67d9a7c
0067D9A68  adrp     x0, #0x8ee6000
0067D9A6C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D9A70  bl       #0x382bd14 ; 
0067D9A74  mov      w8, #1
0067D9A78  strb     w8, [x27, #0xa74]
0067D9A7C  ldr      x1, [x26]
0067D9A80  ldrb     w8, [x1, #0x53]
0067D9A84  tbnz     w8, #5, #0x67d9a90
0067D9A88  ldr      x23, [x23, #0x170]
0067D9A8C  b        #0x67d9aa0 ; 
0067D9A90  ldr      x8, [x1, #0x60]
0067D9A94  mov      x0, x23
0067D9A98  blr      x8
0067D9A9C  mov      x23, x0
0067D9AA0  cbz      x23, #0x67da30c
0067D9AA4  adrp     x24, #0x9591000
0067D9AA8  ldrb     w8, [x24, #0xa75]
0067D9AAC  cbnz     w8, #0x67d9ac4
0067D9AB0  adrp     x0, #0x8ee6000
0067D9AB4  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0067D9AB8  bl       #0x382bd14 ; 
0067D9ABC  mov      w8, #1
0067D9AC0  strb     w8, [x24, #0xa75]
0067D9AC4  adrp     x8, #0x8ee6000
0067D9AC8  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0067D9ACC  ldr      x1, [x8]
0067D9AD0  ldrb     w8, [x1, #0x53]
0067D9AD4  tbnz     w8, #5, #0x67d9ae0
0067D9AD8  ldr      w0, [x23, #0x24]
0067D9ADC  b        #0x67d9aec ; 
0067D9AE0  ldr      x8, [x1, #0x60]
0067D9AE4  mov      x0, x23
0067D9AE8  blr      x8
0067D9AEC  cmp      w0, #0xe
0067D9AF0  b.ne     #0x67d9af8
0067D9AF4  mov      w22, wzr
0067D9AF8  adrp     x23, #0x9591000
0067D9AFC  ldrb     w8, [x23, #0xa4b]
0067D9B00  cbnz     w8, #0x67d9b18
0067D9B04  adrp     x0, #0x8ee5000
0067D9B08  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0067D9B0C  bl       #0x382bd14 ; 
0067D9B10  mov      w8, #1
0067D9B14  strb     w8, [x23, #0xa4b]
0067D9B18  adrp     x8, #0x8ee5000
0067D9B1C  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0067D9B20  ldr      x1, [x8]
0067D9B24  ldrb     w8, [x1, #0x53]
0067D9B28  tbnz     w8, #5, #0x67d9b34
0067D9B2C  ldr      x23, [x19, #0x20]
0067D9B30  b        #0x67d9b44 ; 
0067D9B34  ldr      x8, [x1, #0x60]
0067D9B38  mov      x0, x19
0067D9B3C  blr      x8
0067D9B40  mov      x23, x0
0067D9B44  cbz      x23, #0x67da30c
0067D9B48  adrp     x24, #0x9591000
0067D9B4C  ldrb     w8, [x24, #0xa4c]
0067D9B50  cbnz     w8, #0x67d9b68
0067D9B54  adrp     x0, #0x8ee5000
0067D9B58  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0067D9B5C  bl       #0x382bd14 ; 
0067D9B60  mov      w8, #1
0067D9B64  strb     w8, [x24, #0xa4c]
0067D9B68  adrp     x8, #0x8ee5000
0067D9B6C  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0067D9B70  ldr      x1, [x8]
0067D9B74  ldrb     w8, [x1, #0x53]
0067D9B78  tbnz     w8, #5, #0x67d9b84
0067D9B7C  ldr      x0, [x23, #0x210]
0067D9B80  b        #0x67d9b90 ; 
0067D9B84  ldr      x8, [x1, #0x60]
0067D9B88  mov      x0, x23
0067D9B8C  blr      x8
0067D9B90  cbz      x0, #0x67da30c
0067D9B94  adrp     x8, #0x8f10000
0067D9B98  ldr      x8, [x8, #0xe00] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<Weapon>()
0067D9B9C  ldr      x1, [x8]
0067D9BA0  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0067D9BA4  adrp     x24, #0x959b000
0067D9BA8  ldrb     w8, [x24, #0x3c2]
0067D9BAC  mov      x23, x0
0067D9BB0  cbnz     w8, #0x67d9bc8
0067D9BB4  adrp     x0, #0x8f1e000
0067D9BB8  ldr      x0, [x0, #0x888] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_Weapon()
0067D9BBC  bl       #0x382bd14 ; 
0067D9BC0  mov      w8, #1
0067D9BC4  strb     w8, [x24, #0x3c2]
0067D9BC8  adrp     x8, #0x8f1e000
0067D9BCC  ldr      x8, [x8, #0x888] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_Weapon()
0067D9BD0  ldr      x2, [x8]
0067D9BD4  ldrb     w8, [x2, #0x53]
0067D9BD8  tbnz     w8, #5, #0x67d9bf0
0067D9BDC  add      x0, x19, #0x358
0067D9BE0  mov      x1, x23
0067D9BE4  str      x23, [x19, #0x358]
0067D9BE8  bl       #0x382bcb8 ; 
0067D9BEC  b        #0x67d9c00 ; 
0067D9BF0  ldr      x8, [x2, #0x60]
0067D9BF4  mov      x0, x19
0067D9BF8  mov      x1, x23
0067D9BFC  blr      x8
0067D9C00  adrp     x28, #0x9598000
0067D9C04  ldrb     w8, [x28, #0xfc0]
0067D9C08  cbnz     w8, #0x67d9c20
0067D9C0C  adrp     x0, #0x8f05000
0067D9C10  ldr      x0, [x0, #0xda0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Weapon()
0067D9C14  bl       #0x382bd14 ; 
0067D9C18  mov      w8, #1
0067D9C1C  strb     w8, [x28, #0xfc0]
0067D9C20  adrp     x25, #0x8f05000
0067D9C24  ldr      x25, [x25, #0xda0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Weapon()
0067D9C28  ldr      x1, [x25]
0067D9C2C  ldrb     w8, [x1, #0x53]
0067D9C30  tbnz     w8, #5, #0x67d9c3c
0067D9C34  ldr      x23, [x19, #0x358]
0067D9C38  b        #0x67d9c4c ; 
0067D9C3C  ldr      x8, [x1, #0x60]
0067D9C40  mov      x0, x19
0067D9C44  blr      x8
0067D9C48  mov      x23, x0
0067D9C4C  ldr      x1, [x29]
0067D9C50  ldrb     w8, [x1, #0x53]
0067D9C54  tbnz     w8, #5, #0x67d9c60
0067D9C58  ldr      x24, [x19, #0x38]
0067D9C5C  b        #0x67d9c70 ; 
0067D9C60  ldr      x8, [x1, #0x60]
0067D9C64  mov      x0, x19
0067D9C68  blr      x8
0067D9C6C  mov      x24, x0
0067D9C70  cbz      x24, #0x67da30c
0067D9C74  mov      x29, x26
0067D9C78  adrp     x26, #0x959b000
0067D9C7C  ldrb     w8, [x26, #0x3c3]
0067D9C80  cbnz     w8, #0x67d9c98
0067D9C84  adrp     x0, #0x8f1e000
0067D9C88  ldr      x0, [x0, #0x890] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_NativeWeaponId()
0067D9C8C  bl       #0x382bd14 ; 
0067D9C90  mov      w8, #1
0067D9C94  strb     w8, [x26, #0x3c3]
0067D9C98  adrp     x8, #0x8f1e000
0067D9C9C  ldr      x8, [x8, #0x890] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_NativeWeaponId()
0067D9CA0  ldr      x1, [x8]
0067D9CA4  ldrb     w8, [x1, #0x53]
0067D9CA8  tbnz     w8, #5, #0x67d9cb4
0067D9CAC  ldr      w4, [x24, #0x1a4]
0067D9CB0  b        #0x67d9cc4 ; 
0067D9CB4  ldr      x8, [x1, #0x60]
0067D9CB8  mov      x0, x24
0067D9CBC  blr      x8
0067D9CC0  mov      w4, w0
0067D9CC4  mov      x26, x27
0067D9CC8  adrp     x27, #0x8ee6000
0067D9CCC  ldr      x27, [x27, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D9CD0  cbz      x23, #0x67da30c
0067D9CD4  mov      x0, x23
0067D9CD8  mov      w1, w21
0067D9CDC  mov      w2, w22
0067D9CE0  mov      x3, x19
0067D9CE4  mov      x5, xzr
0067D9CE8  bl       #0x69e1acc ; HotFix.BattleLogic.Weapon$$Init
0067D9CEC  adrp     x8, #0x8ee2000
0067D9CF0  ldr      x21, [x19, #0x80]
0067D9CF4  ldr      x8, [x8, #0xf30] ; GLOBAL System.Action<DeterministicAnimationEvent>_TypeInfo
0067D9CF8  ldr      x0, [x8]
0067D9CFC  bl       #0x382bfa0 ; 
0067D9D00  adrp     x8, #0x8f1e000
0067D9D04  ldr      x8, [x8, #0x848] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnAnimatorEvent()
0067D9D08  mov      x1, x19
0067D9D0C  mov      x3, xzr
0067D9D10  mov      x22, x0
0067D9D14  ldr      x2, [x8]
0067D9D18  bl       #0x5f44014 ; System.Action<object>$$.ctor
0067D9D1C  cbz      x21, #0x67da30c
0067D9D20  mov      x0, x21
0067D9D24  mov      x1, x22
0067D9D28  mov      x2, xzr
0067D9D2C  bl       #0x418587c ; Deterministic.Animation.DeterministicAnimator$$add_OnEvent
0067D9D30  ldr      x0, [x19, #0x80]
0067D9D34  cbz      x0, #0x67da30c
0067D9D38  mov      x1, xzr
0067D9D3C  bl       #0x4185f3c ; Deterministic.Animation.DeterministicAnimator$$GetFirePosList
0067D9D40  add      x21, x19, #0x5f8
0067D9D44  mov      x1, x0
0067D9D48  str      x0, [x19, #0x5f8]
0067D9D4C  mov      x0, x21
0067D9D50  bl       #0x382bcb8 ; 
0067D9D54  ldr      x1, [x27]
0067D9D58  ldrb     w8, [x1, #0x53]
0067D9D5C  tbnz     w8, #5, #0x67d9d68
0067D9D60  ldr      x22, [x19, #0x38]
0067D9D64  b        #0x67d9d78 ; 
0067D9D68  ldr      x8, [x1, #0x60]
0067D9D6C  mov      x0, x19
0067D9D70  blr      x8
0067D9D74  mov      x22, x0
0067D9D78  cbz      x22, #0x67da30c
0067D9D7C  ldrb     w8, [x26, #0xa74]
0067D9D80  cbnz     w8, #0x67d9d98
0067D9D84  adrp     x0, #0x8ee6000
0067D9D88  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D9D8C  bl       #0x382bd14 ; 
0067D9D90  mov      w8, #1
0067D9D94  strb     w8, [x26, #0xa74]
0067D9D98  ldr      x1, [x29]
0067D9D9C  ldrb     w8, [x1, #0x53]
0067D9DA0  tbnz     w8, #5, #0x67d9dac
0067D9DA4  ldr      x22, [x22, #0x170]
0067D9DA8  b        #0x67d9dbc ; 
0067D9DAC  ldr      x8, [x1, #0x60]
0067D9DB0  mov      x0, x22
0067D9DB4  blr      x8
0067D9DB8  mov      x22, x0
0067D9DBC  cbz      x22, #0x67da30c
0067D9DC0  adrp     x23, #0x959b000
0067D9DC4  ldrb     w8, [x23, #0x3c4]
0067D9DC8  cbnz     w8, #0x67d9de0
0067D9DCC  adrp     x0, #0x8f1e000
0067D9DD0  ldr      x0, [x0, #0x898] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ModelScale()
0067D9DD4  bl       #0x382bd14 ; 
0067D9DD8  mov      w8, #1
0067D9DDC  strb     w8, [x23, #0x3c4]
0067D9DE0  adrp     x8, #0x8f1e000
0067D9DE4  ldr      x8, [x8, #0x898] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ModelScale()
0067D9DE8  ldr      x1, [x8]
0067D9DEC  ldrb     w8, [x1, #0x53]
0067D9DF0  tbnz     w8, #5, #0x67d9dfc
0067D9DF4  ldr      x0, [x22, #0x50]
0067D9DF8  b        #0x67d9e08 ; 
0067D9DFC  ldr      x8, [x1, #0x60]
0067D9E00  mov      x0, x22
0067D9E04  blr      x8
0067D9E08  cbz      x20, #0x67da30c
0067D9E0C  str      x0, [x20, #0x10]
0067D9E10  adrp     x8, #0x8f09000
0067D9E14  ldr      x8, [x8, #0x820] ; GLOBAL System.Func<FPVector3, FPVector3>_TypeInfo
0067D9E18  ldr      x22, [x19, #0x5f8]
0067D9E1C  ldr      x0, [x8]
0067D9E20  bl       #0x382bfa0 ; 
0067D9E24  adrp     x8, #0x8f1e000
0067D9E28  ldr      x8, [x8, #0x868] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.<>c__DisplayClass613_0.<InitWeapon>b__0()
0067D9E2C  mov      x1, x20
0067D9E30  mov      x3, xzr
0067D9E34  mov      x23, x0
0067D9E38  ldr      x2, [x8]
0067D9E3C  bl       #0x48c97f8 ; System.Func<FPVector3, FPVector3>$$.ctor
0067D9E40  adrp     x8, #0x8f1e000
0067D9E44  ldr      x8, [x8, #0x850] ; GLOBAL Method$System.Linq.Enumerable.Select<FPVector3, FPVector3>()
0067D9E48  mov      x0, x22
0067D9E4C  mov      x1, x23
0067D9E50  ldr      x2, [x8]
0067D9E54  bl       #0x45cc7d8 ; System.Linq.Enumerable$$Select<FPVector3, FPVector3>
0067D9E58  adrp     x8, #0x8f1e000
0067D9E5C  ldr      x8, [x8, #0x858] ; GLOBAL Method$System.Linq.Enumerable.ToList<FPVector3>()
0067D9E60  ldr      x1, [x8]
0067D9E64  bl       #0x45dbf64 ; System.Linq.Enumerable$$ToList<FPVector3>
0067D9E68  mov      x1, x0
0067D9E6C  str      x0, [x19, #0x5f8]
0067D9E70  mov      x0, x21
0067D9E74  bl       #0x382bcb8 ; 
0067D9E78  adrp     x8, #0x8f0b000
0067D9E7C  ldr      x8, [x8, #0x720] ; GLOBAL HotFix.BattleLogic.FPStateController_TypeInfo
0067D9E80  ldr      x0, [x8]
0067D9E84  bl       #0x382bfa0 ; 
0067D9E88  mov      x1, xzr
0067D9E8C  mov      x21, x0
0067D9E90  bl       #0x691e544 ; HotFix.BattleLogic.FPStateController$$.ctor
0067D9E94  add      x20, x19, #0x3d0
0067D9E98  mov      x0, x20
0067D9E9C  mov      x1, x21
0067D9EA0  str      x21, [x19, #0x3d0]
0067D9EA4  bl       #0x382bcb8 ; 
0067D9EA8  adrp     x8, #0x8f1e000
0067D9EAC  ldr      x21, [x19, #0x3d0]
0067D9EB0  ldr      x8, [x8, #0x838] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateIdle_TypeInfo
0067D9EB4  ldr      x0, [x8]
0067D9EB8  bl       #0x382bfa0 ; 
0067D9EBC  mov      x1, x19
0067D9EC0  mov      x2, xzr
0067D9EC4  mov      x22, x0
0067D9EC8  bl       #0x6838558 ; HotFix.BattleLogic.CharacterWeaponStateIdle$$.ctor
0067D9ECC  cbz      x21, #0x67da30c
0067D9ED0  adrp     x23, #0x8f0b000
0067D9ED4  ldr      x23, [x23, #0x730] ; GLOBAL Method$HotFix.Common.StateController<int, FP>.RegisterState()
0067D9ED8  mov      x0, x21
0067D9EDC  mov      x1, x22
0067D9EE0  ldr      x2, [x23]
0067D9EE4  bl       #0x5527400 ; HotFix.Common.StateController<int, FP>$$RegisterState
0067D9EE8  adrp     x8, #0x8f1e000
0067D9EEC  ldr      x21, [x19, #0x3d0]
0067D9EF0  ldr      x8, [x8, #0x818] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateEnter_TypeInfo
0067D9EF4  ldr      x0, [x8]
0067D9EF8  bl       #0x382bfa0 ; 
0067D9EFC  mov      x1, x19
0067D9F00  mov      x2, xzr
0067D9F04  mov      x22, x0
0067D9F08  bl       #0x6832444 ; HotFix.BattleLogic.CharacterWeaponStateEnter$$.ctor
0067D9F0C  cbz      x21, #0x67da30c
0067D9F10  ldr      x2, [x23]
0067D9F14  mov      x0, x21
0067D9F18  mov      x1, x22
0067D9F1C  bl       #0x5527400 ; HotFix.Common.StateController<int, FP>$$RegisterState
0067D9F20  adrp     x8, #0x8f1e000
0067D9F24  ldr      x21, [x19, #0x3d0]
0067D9F28  ldr      x8, [x8, #0x830] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateHold_TypeInfo
0067D9F2C  ldr      x0, [x8]
0067D9F30  bl       #0x382bfa0 ; 
0067D9F34  mov      x1, x19
0067D9F38  mov      x2, xzr
0067D9F3C  mov      x22, x0
0067D9F40  bl       #0x6836a14 ; HotFix.BattleLogic.CharacterWeaponStateHold$$.ctor
0067D9F44  cbz      x21, #0x67da30c
0067D9F48  ldr      x2, [x23]
0067D9F4C  mov      x0, x21
0067D9F50  mov      x1, x22
0067D9F54  bl       #0x5527400 ; HotFix.Common.StateController<int, FP>$$RegisterState
0067D9F58  adrp     x8, #0x8f1e000
0067D9F5C  ldr      x21, [x19, #0x3d0]
0067D9F60  ldr      x8, [x8, #0x828] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateFireHold_TypeInfo
0067D9F64  ldr      x0, [x8]
0067D9F68  bl       #0x382bfa0 ; 
0067D9F6C  mov      x1, x19
0067D9F70  mov      x2, xzr
0067D9F74  mov      x22, x0
0067D9F78  bl       #0x6835fb0 ; HotFix.BattleLogic.CharacterWeaponStateFireHold$$.ctor
0067D9F7C  cbz      x21, #0x67da30c
0067D9F80  ldr      x2, [x23]
0067D9F84  mov      x0, x21
0067D9F88  mov      x1, x22
0067D9F8C  bl       #0x5527400 ; HotFix.Common.StateController<int, FP>$$RegisterState
0067D9F90  adrp     x8, #0x8f1e000
0067D9F94  ldr      x21, [x19, #0x3d0]
0067D9F98  ldr      x8, [x8, #0x820] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateExit_TypeInfo
0067D9F9C  ldr      x0, [x8]
0067D9FA0  bl       #0x382bfa0 ; 
0067D9FA4  mov      x1, x19
0067D9FA8  mov      x2, xzr
0067D9FAC  mov      x22, x0
0067D9FB0  bl       #0x6833278 ; HotFix.BattleLogic.CharacterWeaponStateExit$$.ctor
0067D9FB4  cbz      x21, #0x67da30c
0067D9FB8  ldr      x2, [x23]
0067D9FBC  mov      x0, x21
0067D9FC0  mov      x1, x22
0067D9FC4  bl       #0x5527400 ; HotFix.Common.StateController<int, FP>$$RegisterState
0067D9FC8  adrp     x8, #0x8f1e000
0067D9FCC  ldr      x21, [x19, #0x3d0]
0067D9FD0  ldr      x8, [x8, #0x810] ; GLOBAL HotFix.BattleLogic.CharacterWeaponStateCeaseFire_TypeInfo
0067D9FD4  ldr      x0, [x8]
0067D9FD8  bl       #0x382bfa0 ; 
0067D9FDC  mov      x1, x19
0067D9FE0  mov      x2, xzr
0067D9FE4  mov      x22, x0
0067D9FE8  bl       #0x6831a78 ; HotFix.BattleLogic.CharacterWeaponStateCeaseFire$$.ctor
0067D9FEC  cbz      x21, #0x67da30c
0067D9FF0  ldr      x2, [x23]
0067D9FF4  mov      x0, x21
0067D9FF8  mov      x1, x22
0067D9FFC  bl       #0x5527400 ; HotFix.Common.StateController<int, FP>$$RegisterState
0067DA000  ldr      x0, [x20]
0067DA004  cbz      x0, #0x67da30c
0067DA008  adrp     x8, #0x8f1e000
0067DA00C  ldr      x8, [x8, #0x860] ; GLOBAL Method$HotFix.Common.StateController<int, FP>.Init()
0067DA010  ldr      x1, [x8]
0067DA014  bl       #0x5526f14 ; HotFix.Common.StateController<int, FP>$$Init
0067DA018  adrp     x8, #0x8ec3000
0067DA01C  ldr      x8, [x8, #0xdc0] ; GLOBAL Method$System.Array.Empty<object>()
0067DA020  ldr      x20, [x20]
0067DA024  ldr      x21, [x8]
0067DA028  ldr      x8, [x21, #0x38]
0067DA02C  cbnz     x8, #0x67da03c
0067DA030  mov      x0, x21
0067DA034  bl       #0x3a7e668 ; 
0067DA038  ldr      x8, [x21, #0x38]
0067DA03C  ldr      x0, [x8, #0x10]
0067DA040  ldrb     w8, [x0, #0x135]
0067DA044  tbnz     w8, #0, #0x67da04c
0067DA048  bl       #0x3a7e60c ; 
0067DA04C  ldr      w8, [x0, #0xe0]
0067DA050  cbnz     w8, #0x67da058
0067DA054  bl       #0x382be8c ; 
0067DA058  ldr      x8, [x21, #0x38]
0067DA05C  ldr      x0, [x8, #0x10]
0067DA060  ldrb     w8, [x0, #0x135]
0067DA064  tbnz     w8, #0, #0x67da06c
0067DA068  bl       #0x3a7e60c ; 
0067DA06C  cbz      x20, #0x67da30c
0067DA070  adrp     x9, #0x8f0b000
0067DA074  ldr      x8, [x0, #0xb8]
0067DA078  ldr      x9, [x9, #0x758] ; GLOBAL Method$HotFix.Common.StateController<int, FP>.ActiveState()
0067DA07C  mov      x0, x20
0067DA080  mov      w1, wzr
0067DA084  ldr      x2, [x8]
0067DA088  ldr      x3, [x9]
0067DA08C  bl       #0x5527a88 ; HotFix.Common.StateController<int, FP>$$ActiveState
0067DA090  ldrb     w8, [x28, #0xfc0]
0067DA094  cbnz     w8, #0x67da0ac
0067DA098  adrp     x0, #0x8f05000
0067DA09C  ldr      x0, [x0, #0xda0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Weapon()
0067DA0A0  bl       #0x382bd14 ; 
0067DA0A4  mov      w8, #1
0067DA0A8  strb     w8, [x28, #0xfc0]
0067DA0AC  ldr      x1, [x25]
0067DA0B0  ldrb     w8, [x1, #0x53]
0067DA0B4  tbnz     w8, #5, #0x67da0c0
0067DA0B8  ldr      x20, [x19, #0x358]
0067DA0BC  b        #0x67da0d0 ; 
0067DA0C0  ldr      x8, [x1, #0x60]
0067DA0C4  mov      x0, x19
0067DA0C8  blr      x8
0067DA0CC  mov      x20, x0
0067DA0D0  cbz      x20, #0x67da30c
0067DA0D4  adrp     x21, #0x9599000
0067DA0D8  ldrb     w8, [x21, #0x913]
0067DA0DC  cbnz     w8, #0x67da0f4
0067DA0E0  adrp     x0, #0x8f0c000
0067DA0E4  ldr      x0, [x0, #0x770] ; GLOBAL Method$HotFix.BattleLogic.Weapon.get_TableData()
0067DA0E8  bl       #0x382bd14 ; 
0067DA0EC  mov      w8, #1
0067DA0F0  strb     w8, [x21, #0x913]
0067DA0F4  adrp     x22, #0x8f0c000
0067DA0F8  ldr      x22, [x22, #0x770] ; GLOBAL Method$HotFix.BattleLogic.Weapon.get_TableData()
0067DA0FC  ldr      x1, [x22]
0067DA100  ldrb     w8, [x1, #0x53]
0067DA104  tbnz     w8, #5, #0x67da110
0067DA108  ldr      x20, [x20, #0x48]
0067DA10C  b        #0x67da120 ; 
0067DA110  ldr      x8, [x1, #0x60]
0067DA114  mov      x0, x20
0067DA118  blr      x8
0067DA11C  mov      x20, x0
0067DA120  cbz      x20, #0x67da30c
0067DA124  adrp     x23, #0x959b000
0067DA128  ldrb     w8, [x23, #0x3c5]
0067DA12C  cbnz     w8, #0x67da144
0067DA130  adrp     x0, #0x8f1e000
0067DA134  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_HoldEffect()
0067DA138  bl       #0x382bd14 ; 
0067DA13C  mov      w8, #1
0067DA140  strb     w8, [x23, #0x3c5]
0067DA144  adrp     x8, #0x8f1e000
0067DA148  ldr      x8, [x8, #0x8a0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_HoldEffect()
0067DA14C  ldr      x1, [x8]
0067DA150  ldrb     w8, [x1, #0x53]
0067DA154  tbnz     w8, #5, #0x67da160
0067DA158  ldr      w20, [x20, #0x24]
0067DA15C  b        #0x67da170 ; 
0067DA160  ldr      x8, [x1, #0x60]
0067DA164  mov      x0, x20
0067DA168  blr      x8
0067DA16C  mov      w20, w0
0067DA170  adrp     x23, #0x959b000
0067DA174  ldrb     w8, [x23, #0x3c6]
0067DA178  cbnz     w8, #0x67da190
0067DA17C  adrp     x0, #0x8f1e000
0067DA180  ldr      x0, [x0, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_HoldEffect()
0067DA184  bl       #0x382bd14 ; 
0067DA188  mov      w8, #1
0067DA18C  strb     w8, [x23, #0x3c6]
0067DA190  adrp     x8, #0x8f1e000
0067DA194  ldr      x8, [x8, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_HoldEffect()
0067DA198  ldr      x2, [x8]
0067DA19C  ldrb     w8, [x2, #0x53]
0067DA1A0  tbnz     w8, #5, #0x67da1ac
0067DA1A4  str      w20, [x19, #0x3e8]
0067DA1A8  b        #0x67da1bc ; 
0067DA1AC  ldr      x8, [x2, #0x60]
0067DA1B0  mov      x0, x19
0067DA1B4  mov      w1, w20
0067DA1B8  blr      x8
0067DA1BC  ldrb     w8, [x28, #0xfc0]
0067DA1C0  cbnz     w8, #0x67da1d8
0067DA1C4  adrp     x0, #0x8f05000
0067DA1C8  ldr      x0, [x0, #0xda0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Weapon()
0067DA1CC  bl       #0x382bd14 ; 
0067DA1D0  mov      w8, #1
0067DA1D4  strb     w8, [x28, #0xfc0]
0067DA1D8  ldr      x1, [x25]
0067DA1DC  ldrb     w8, [x1, #0x53]
0067DA1E0  tbnz     w8, #5, #0x67da1ec
0067DA1E4  ldr      x20, [x19, #0x358]
0067DA1E8  b        #0x67da1fc ; 
0067DA1EC  ldr      x8, [x1, #0x60]
0067DA1F0  mov      x0, x19
0067DA1F4  blr      x8
0067DA1F8  mov      x20, x0
0067DA1FC  cbz      x20, #0x67da30c
0067DA200  ldrb     w8, [x21, #0x913]
0067DA204  cbnz     w8, #0x67da21c
0067DA208  adrp     x0, #0x8f0c000
0067DA20C  ldr      x0, [x0, #0x770] ; GLOBAL Method$HotFix.BattleLogic.Weapon.get_TableData()
0067DA210  bl       #0x382bd14 ; 
0067DA214  mov      w8, #1
0067DA218  strb     w8, [x21, #0x913]
0067DA21C  ldr      x1, [x22]
0067DA220  ldrb     w8, [x1, #0x53]
0067DA224  tbnz     w8, #5, #0x67da230
0067DA228  ldr      x20, [x20, #0x48]
0067DA22C  b        #0x67da240 ; 
0067DA230  ldr      x8, [x1, #0x60]
0067DA234  mov      x0, x20
0067DA238  blr      x8
0067DA23C  mov      x20, x0
0067DA240  cbz      x20, #0x67da30c
0067DA244  adrp     x21, #0x959b000
0067DA248  ldrb     w8, [x21, #0x3c7]
0067DA24C  cbnz     w8, #0x67da264
0067DA250  adrp     x0, #0x8f1e000
0067DA254  ldr      x0, [x0, #0x8b0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_HoldCompleteEffect()
0067DA258  bl       #0x382bd14 ; 
0067DA25C  mov      w8, #1
0067DA260  strb     w8, [x21, #0x3c7]
0067DA264  adrp     x8, #0x8f1e000
0067DA268  ldr      x8, [x8, #0x8b0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_HoldCompleteEffect()
0067DA26C  ldr      x1, [x8]
0067DA270  ldrb     w8, [x1, #0x53]
0067DA274  tbnz     w8, #5, #0x67da280
0067DA278  ldr      w20, [x20, #0x28]
0067DA27C  b        #0x67da290 ; 
0067DA280  ldr      x8, [x1, #0x60]
0067DA284  mov      x0, x20
0067DA288  blr      x8
0067DA28C  mov      w20, w0
0067DA290  adrp     x21, #0x959b000
0067DA294  ldrb     w8, [x21, #0x3c8]
0067DA298  cbnz     w8, #0x67da2b0
0067DA29C  adrp     x0, #0x8f1e000
0067DA2A0  ldr      x0, [x0, #0x8b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_HoldCompleteEffect()
0067DA2A4  bl       #0x382bd14 ; 
0067DA2A8  mov      w8, #1
0067DA2AC  strb     w8, [x21, #0x3c8]
0067DA2B0  adrp     x8, #0x8f1e000
0067DA2B4  ldr      x8, [x8, #0x8b8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.set_HoldCompleteEffect()
0067DA2B8  ldr      x2, [x8]
0067DA2BC  ldrb     w8, [x2, #0x53]
0067DA2C0  tbnz     w8, #5, #0x67da2cc
0067DA2C4  str      w20, [x19, #0x3ec]
0067DA2C8  b        #0x67da2dc ; 
0067DA2CC  ldr      x8, [x2, #0x60]
0067DA2D0  mov      x0, x19
0067DA2D4  mov      w1, w20
0067DA2D8  blr      x8
0067DA2DC  ldr      x0, [x19, #0x5f0]
0067DA2E0  cbz      x0, #0x67da30c
0067DA2E4  adrp     x8, #0x8f1e000
0067DA2E8  ldr      x8, [x8, #0x840] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityRef, EntityRef>.Clear()
0067DA2EC  ldp      x20, x19, [sp, #0x50]
0067DA2F0  ldp      x22, x21, [sp, #0x40]
0067DA2F4  ldp      x24, x23, [sp, #0x30]
0067DA2F8  ldr      x1, [x8]
0067DA2FC  ldp      x26, x25, [sp, #0x20]
0067DA300  ldp      x28, x27, [sp, #0x10]
0067DA304  ldp      x29, x30, [sp], #0x60
0067DA308  b        #0x5dc62a4 ; System.Collections.Generic.Dictionary<EntityRef, EntityRef>$$Clear
0067DA30C  bl       #0x382bfb8 ; 
0067DA310  bl       #0x382bfc0 ; 

