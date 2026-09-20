; HotFix.BattleLogic.AIPunchboard$$OnUpdate
; RVA 0x6B8A420; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8A420  sub      sp, sp, #0xc0
006B8A424  stp      x30, x27, [sp, #0x70]
006B8A428  stp      x26, x25, [sp, #0x80]
006B8A42C  stp      x24, x23, [sp, #0x90]
006B8A430  stp      x22, x21, [sp, #0xa0]
006B8A434  stp      x20, x19, [sp, #0xb0]
006B8A438  mrs      x22, tpidr_el0
006B8A43C  ldr      x8, [x22, #0x28]
006B8A440  adrp     x21, #0x959f000
006B8A444  adrp     x23, #0x8f43000
006B8A448  mov      x20, x1
006B8A44C  str      x8, [sp, #0x68]
006B8A450  ldrb     w8, [x21, #0xf7d]
006B8A454  ldr      x23, [x23, #0x868] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnUpdate() @ 0x9232410
006B8A458  mov      x19, x0
006B8A45C  tbnz     w8, #0, #0x6b8a4ec
006B8A460  adrp     x0, #0x8f43000
006B8A464  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnUpdate() @ 0x9232410
006B8A468  bl       #0x382bd14 ; 
006B8A46C  adrp     x0, #0x8ee6000
006B8A470  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006B8A474  bl       #0x382bd14 ; 
006B8A478  adrp     x0, #0x8f33000
006B8A47C  ldr      x0, [x0, #0xe08] ; GLOBAL HotFix.BattleLogic.EntityNpc_TypeInfo @ 0x91e5b40
006B8A480  bl       #0x382bd14 ; 
006B8A484  adrp     x0, #0x8ee1000
006B8A488  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006B8A48C  bl       #0x382bd14 ; 
006B8A490  adrp     x0, #0x8f05000
006B8A494  ldr      x0, [x0, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo @ 0x91ebf60
006B8A498  bl       #0x382bd14 ; 
006B8A49C  adrp     x0, #0x8ee8000
006B8A4A0  ldr      x0, [x0, #0x838] ; GLOBAL Method$System.Nullable<FP>..ctor() @ 0x9227b20
006B8A4A4  bl       #0x382bd14 ; 
006B8A4A8  adrp     x0, #0x8f43000
006B8A4AC  ldr      x0, [x0, #0x870] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\AINew\AIPunchboard.cs @ 0x92f7da0
006B8A4B0  bl       #0x382bd14 ; 
006B8A4B4  adrp     x0, #0x8f43000
006B8A4B8  ldr      x0, [x0, #0x878] ; GLOBAL AIPunchboard  _pickupTimeFactor = 0 @ 0x92ef6f0
006B8A4BC  bl       #0x382bd14 ; 
006B8A4C0  adrp     x0, #0x8f05000
006B8A4C4  ldr      x0, [x0, #0x828] ; GLOBAL Idle @ 0x9301248
006B8A4C8  bl       #0x382bd14 ; 
006B8A4CC  adrp     x0, #0x8ee4000
006B8A4D0  ldr      x0, [x0, #0xae8] ; GLOBAL OnUpdate @ 0x9308068
006B8A4D4  bl       #0x382bd14 ; 
006B8A4D8  adrp     x0, #0x8f43000
006B8A4DC  ldr      x0, [x0, #0x880] ; GLOBAL Enter @ 0x92fb610
006B8A4E0  bl       #0x382bd14 ; 
006B8A4E4  mov      w8, #1
006B8A4E8  strb     w8, [x21, #0xf7d]
006B8A4EC  ldr      x2, [x23]
006B8A4F0  ldrb     w8, [x2, #0x53]
006B8A4F4  tbnz     w8, #5, #0x6b8a548
006B8A4F8  mov      x0, x19
006B8A4FC  mov      x1, x20
006B8A500  bl       #0x6b81b3c ; HotFix.BattleLogic.AIStateController$$OnUpdate
006B8A504  adrp     x23, #0x8ee5000
006B8A508  ldr      x8, [x19, #0x120]
006B8A50C  ldr      x23, [x23, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8A510  adrp     x24, #0x9591000
006B8A514  cbz      x8, #0x6b8a55c
006B8A518  ldrb     w8, [x24, #0xa4b]
006B8A51C  cbnz     w8, #0x6b8a534
006B8A520  adrp     x0, #0x8ee5000
006B8A524  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8A528  bl       #0x382bd14 ; 
006B8A52C  mov      w8, #1
006B8A530  strb     w8, [x24, #0xa4b]
006B8A534  ldr      x1, [x23]
006B8A538  ldrb     w8, [x1, #0x53]
006B8A53C  tbnz     w8, #5, #0x6b8a5b8
006B8A540  ldr      x21, [x19, #0x20]
006B8A544  b        #0x6b8a5c8 ; 
006B8A548  ldr      x8, [x2, #0x60]
006B8A54C  mov      x0, x19
006B8A550  mov      x1, x20
006B8A554  blr      x8
006B8A558  b        #0x6b8ab90 ; 
006B8A55C  ldr      x8, [x19, #0x130]
006B8A560  cmp      x8, #1
006B8A564  b.lt     #0x6b8a818
006B8A568  ldrb     w9, [x19, #0x149]
006B8A56C  cbnz     w9, #0x6b8a598
006B8A570  ldr      x0, [x19, #0x58]
006B8A574  cbz      x0, #0x6b8abbc
006B8A578  adrp     x8, #0x8f05000
006B8A57C  ldr      x8, [x8, #0x828] ; GLOBAL Idle @ 0x9301248
006B8A580  mov      x2, xzr
006B8A584  ldr      x1, [x8]
006B8A588  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
006B8A58C  ldr      x8, [x19, #0x130]
006B8A590  mov      w9, #1
006B8A594  strb     w9, [x19, #0x149]
006B8A598  ldr      x9, [x19, #0x140]
006B8A59C  ldr      x0, [x19, #0x58]
006B8A5A0  mul      x9, x9, x20
006B8A5A4  sub      x8, x8, x9, asr #16
006B8A5A8  bic      x1, x8, x8, asr #63
006B8A5AC  str      x1, [x19, #0x130]
006B8A5B0  cbnz     x0, #0x6b8a810
006B8A5B4  b        #0x6b8abbc ; 
006B8A5B8  ldr      x8, [x1, #0x60]
006B8A5BC  mov      x0, x19
006B8A5C0  blr      x8
006B8A5C4  mov      x21, x0
006B8A5C8  cbz      x21, #0x6b8abbc
006B8A5CC  adrp     x25, #0x9598000
006B8A5D0  ldrb     w8, [x25, #0xfc4]
006B8A5D4  cbnz     w8, #0x6b8a5ec
006B8A5D8  adrp     x0, #0x8f05000
006B8A5DC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006B8A5E0  bl       #0x382bd14 ; 
006B8A5E4  mov      w8, #1
006B8A5E8  strb     w8, [x25, #0xfc4]
006B8A5EC  adrp     x26, #0x8f05000
006B8A5F0  ldr      x26, [x26, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006B8A5F4  ldr      x1, [x26]
006B8A5F8  ldrb     w8, [x1, #0x53]
006B8A5FC  tbnz     w8, #5, #0x6b8a608
006B8A600  ldr      x21, [x21, #0x220]
006B8A604  b        #0x6b8a618 ; 
006B8A608  ldr      x8, [x1, #0x60]
006B8A60C  mov      x0, x21
006B8A610  blr      x8
006B8A614  mov      x21, x0
006B8A618  cbz      x21, #0x6b8abbc
006B8A61C  adrp     x27, #0x9599000
006B8A620  ldrb     w8, [x27, #0x28c]
006B8A624  cbnz     w8, #0x6b8a63c
006B8A628  adrp     x0, #0x8f07000
006B8A62C  ldr      x0, [x0, #0xdf0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_CurStateId() @ 0x923cca0
006B8A630  bl       #0x382bd14 ; 
006B8A634  mov      w8, #1
006B8A638  strb     w8, [x27, #0x28c]
006B8A63C  adrp     x8, #0x8f07000
006B8A640  ldr      x8, [x8, #0xdf0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_CurStateId() @ 0x923cca0
006B8A644  ldr      x1, [x8]
006B8A648  ldrb     w8, [x1, #0x53]
006B8A64C  tbnz     w8, #5, #0x6b8a658
006B8A650  ldr      w0, [x21, #0x28]
006B8A654  b        #0x6b8a664 ; 
006B8A658  ldr      x8, [x1, #0x60]
006B8A65C  mov      x0, x21
006B8A660  blr      x8
006B8A664  cmp      w0, #1
006B8A668  b.ne     #0x6b8ab90
006B8A66C  ldrb     w8, [x19, #0x149]
006B8A670  cbz      w8, #0x6b8a694
006B8A674  ldr      x0, [x19, #0x58]
006B8A678  cbz      x0, #0x6b8abbc
006B8A67C  adrp     x8, #0x8f43000
006B8A680  ldr      x8, [x8, #0x880] ; GLOBAL Enter @ 0x92fb610
006B8A684  mov      x2, xzr
006B8A688  ldr      x1, [x8]
006B8A68C  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
006B8A690  strb     wzr, [x19, #0x149]
006B8A694  ldr      x8, [x19, #0x138]
006B8A698  cbnz     x8, #0x6b8a718
006B8A69C  ldr      x8, [x19, #0x118]
006B8A6A0  cbz      x8, #0x6b8abbc
006B8A6A4  ldr      x9, [x8, #0x20]
006B8A6A8  cbz      x9, #0x6b8a6b4
006B8A6AC  mov      x10, #0x100000000
006B8A6B0  sdiv     x9, x10, x9
006B8A6B4  str      x9, [x19, #0x138]
006B8A6B8  ldr      x8, [x8, #0x28]
006B8A6BC  cbz      x8, #0x6b8a6c8
006B8A6C0  mov      x9, #0x100000000
006B8A6C4  sdiv     x8, x9, x8
006B8A6C8  str      x8, [x19, #0x140]
006B8A6CC  adrp     x8, #0x8ee1000
006B8A6D0  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006B8A6D4  ldr      x0, [x8]
006B8A6D8  ldr      w8, [x0, #0xe0]
006B8A6DC  cbnz     w8, #0x6b8a6e4
006B8A6E0  bl       #0x382be8c ; 
006B8A6E4  adrp     x8, #0x8f43000
006B8A6E8  adrp     x9, #0x8ee4000
006B8A6EC  adrp     x10, #0x8f43000
006B8A6F0  ldr      x8, [x8, #0x878] ; GLOBAL AIPunchboard  _pickupTimeFactor = 0 @ 0x92ef6f0
006B8A6F4  ldr      x9, [x9, #0xae8] ; GLOBAL OnUpdate @ 0x9308068
006B8A6F8  ldr      x10, [x10, #0x870] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\AINew\AIPunchboard.cs @ 0x92f7da0
006B8A6FC  mov      w3, #0x61
006B8A700  ldr      x0, [x8]
006B8A704  ldr      x1, [x9]
006B8A708  ldr      x2, [x10]
006B8A70C  mov      x4, xzr
006B8A710  bl       #0x7997754 ; Logger$$LogError
006B8A714  ldr      x8, [x19, #0x138]
006B8A718  ldr      x9, [x19, #0x130]
006B8A71C  mul      x8, x8, x20
006B8A720  add      x8, x9, x8, asr #16
006B8A724  cmp      x8, #0x10, lsl #12
006B8A728  str      x8, [x19, #0x130]
006B8A72C  b.le     #0x6b8a804
006B8A730  mov      w8, #0x10000
006B8A734  str      x8, [x19, #0x130]
006B8A738  ldrb     w8, [x24, #0xa4b]
006B8A73C  cbnz     w8, #0x6b8a754
006B8A740  adrp     x0, #0x8ee5000
006B8A744  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8A748  bl       #0x382bd14 ; 
006B8A74C  mov      w8, #1
006B8A750  strb     w8, [x24, #0xa4b]
006B8A754  ldr      x1, [x23]
006B8A758  ldrb     w8, [x1, #0x53]
006B8A75C  tbnz     w8, #5, #0x6b8a768
006B8A760  ldr      x20, [x19, #0x20]
006B8A764  b        #0x6b8a778 ; 
006B8A768  ldr      x8, [x1, #0x60]
006B8A76C  mov      x0, x19
006B8A770  blr      x8
006B8A774  mov      x20, x0
006B8A778  cbz      x20, #0x6b8abbc
006B8A77C  ldrb     w8, [x25, #0xfc4]
006B8A780  cbnz     w8, #0x6b8a798
006B8A784  adrp     x0, #0x8f05000
006B8A788  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006B8A78C  bl       #0x382bd14 ; 
006B8A790  mov      w8, #1
006B8A794  strb     w8, [x25, #0xfc4]
006B8A798  ldr      x1, [x26]
006B8A79C  ldrb     w8, [x1, #0x53]
006B8A7A0  tbnz     w8, #5, #0x6b8a7ac
006B8A7A4  ldr      x0, [x20, #0x220]
006B8A7A8  b        #0x6b8a7b8 ; 
006B8A7AC  ldr      x8, [x1, #0x60]
006B8A7B0  mov      x0, x20
006B8A7B4  blr      x8
006B8A7B8  cbz      x0, #0x6b8abbc
006B8A7BC  ldr      x2, [x19, #0x58]
006B8A7C0  ldr      x1, [x19, #0x120]
006B8A7C4  cbz      x2, #0x6b8a7fc
006B8A7C8  adrp     x8, #0x8f33000
006B8A7CC  ldr      x8, [x8, #0xe08] ; GLOBAL HotFix.BattleLogic.EntityNpc_TypeInfo @ 0x91e5b40
006B8A7D0  ldr      x9, [x2]
006B8A7D4  ldr      x8, [x8]
006B8A7D8  ldrb     w11, [x9, #0x130]
006B8A7DC  ldrb     w10, [x8, #0x130]
006B8A7E0  cmp      w11, w10
006B8A7E4  b.lo     #0x6b8abc8
006B8A7E8  ldr      x9, [x9, #0xc8]
006B8A7EC  add      x9, x9, x10, lsl #3
006B8A7F0  ldur     x9, [x9, #-8]
006B8A7F4  cmp      x9, x8
006B8A7F8  b.ne     #0x6b8abc8
006B8A7FC  mov      x3, xzr
006B8A800  bl       #0x6591b74 ; HotFix.BattleLogic.BattleManager$$OnHeroColliderWithNpc
006B8A804  ldr      x0, [x19, #0x58]
006B8A808  cbz      x0, #0x6b8abbc
006B8A80C  ldr      x1, [x19, #0x130]
006B8A810  mov      x2, xzr
006B8A814  bl       #0x67f63a4 ; HotFix.BattleLogic.EntityCharacter$$SetPickupProgress
006B8A818  ldrb     w8, [x24, #0xa4b]
006B8A81C  ldrb     w21, [x19, #0x148]
006B8A820  cbnz     w8, #0x6b8a838
006B8A824  adrp     x0, #0x8ee5000
006B8A828  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8A82C  bl       #0x382bd14 ; 
006B8A830  mov      w8, #1
006B8A834  strb     w8, [x24, #0xa4b]
006B8A838  ldr      x1, [x23]
006B8A83C  ldrb     w8, [x1, #0x53]
006B8A840  tbnz     w8, #5, #0x6b8a84c
006B8A844  ldr      x20, [x19, #0x20]
006B8A848  b        #0x6b8a85c ; 
006B8A84C  ldr      x8, [x1, #0x60]
006B8A850  mov      x0, x19
006B8A854  blr      x8
006B8A858  mov      x20, x0
006B8A85C  cbz      x20, #0x6b8abbc
006B8A860  adrp     x25, #0x9591000
006B8A864  ldrb     w8, [x25, #0xa9c]
006B8A868  cbnz     w8, #0x6b8a880
006B8A86C  adrp     x0, #0x8ee6000
006B8A870  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
006B8A874  bl       #0x382bd14 ; 
006B8A878  mov      w8, #1
006B8A87C  strb     w8, [x25, #0xa9c]
006B8A880  adrp     x8, #0x8ee6000
006B8A884  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
006B8A888  ldr      x1, [x8]
006B8A88C  ldrb     w8, [x1, #0x53]
006B8A890  tbnz     w8, #5, #0x6b8a89c
006B8A894  ldr      x20, [x20, #0x240]
006B8A898  b        #0x6b8a8ac ; 
006B8A89C  ldr      x8, [x1, #0x60]
006B8A8A0  mov      x0, x20
006B8A8A4  blr      x8
006B8A8A8  mov      x20, x0
006B8A8AC  ldr      x0, [x19, #0x58]
006B8A8B0  cbz      x0, #0x6b8abbc
006B8A8B4  adrp     x8, #0x8ee6000
006B8A8B8  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006B8A8BC  ldr      x1, [x8]
006B8A8C0  ldrb     w8, [x1, #0x53]
006B8A8C4  tbnz     w8, #5, #0x6b8a8d0
006B8A8C8  ldr      x0, [x0, #0x38]
006B8A8CC  b        #0x6b8a8d8 ; 
006B8A8D0  ldr      x8, [x1, #0x60]
006B8A8D4  blr      x8
006B8A8D8  cbz      x0, #0x6b8abbc
006B8A8DC  add      x8, sp, #0x38
006B8A8E0  mov      x1, xzr
006B8A8E4  cbz      w21, #0x6b8a994
006B8A8E8  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006B8A8EC  adrp     x21, #0x8f05000
006B8A8F0  ldur     q0, [sp, #0x38]
006B8A8F4  ldr      x8, [sp, #0x48]
006B8A8F8  ldr      x21, [x21, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo @ 0x91ebf60
006B8A8FC  str      q0, [sp, #0x50]
006B8A900  str      x8, [sp, #0x60]
006B8A904  ldr      x0, [x21]
006B8A908  ldr      w8, [x0, #0xe0]
006B8A90C  cbnz     w8, #0x6b8a918
006B8A910  bl       #0x382be8c ; 
006B8A914  ldr      x0, [x21]
006B8A918  adrp     x9, #0x8ee8000
006B8A91C  ldr      x8, [x0, #0xb8]
006B8A920  ldr      x9, [x9, #0x838] ; GLOBAL Method$System.Nullable<FP>..ctor() @ 0x9227b20
006B8A924  add      x0, sp, #0x38
006B8A928  ldr      x1, [x8, #0x28]
006B8A92C  ldr      x2, [x9]
006B8A930  stp      xzr, xzr, [sp, #0x38]
006B8A934  bl       #0x51328c0 ; System.Nullable<FP>$$.ctor
006B8A938  cbz      x20, #0x6b8abbc
006B8A93C  ldr      q0, [sp, #0x50]
006B8A940  ldr      x8, [sp, #0x60]
006B8A944  ldp      x2, x3, [sp, #0x38]
006B8A948  mov      x1, sp
006B8A94C  mov      x0, x20
006B8A950  mov      x4, xzr
006B8A954  str      q0, [sp]
006B8A958  str      x8, [sp, #0x10]
006B8A95C  bl       #0x69096f0 ; HotFix.BattleLogic.MapManager$$IsPosInCameraBounds
006B8A960  tbnz     w0, #0, #0x6b8ab90
006B8A964  ldrb     w8, [x24, #0xa4b]
006B8A968  cbnz     w8, #0x6b8a980
006B8A96C  adrp     x0, #0x8ee5000
006B8A970  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8A974  bl       #0x382bd14 ; 
006B8A978  mov      w8, #1
006B8A97C  strb     w8, [x24, #0xa4b]
006B8A980  ldr      x1, [x23]
006B8A984  ldrb     w8, [x1, #0x53]
006B8A988  tbnz     w8, #5, #0x6b8aa1c
006B8A98C  ldr      x20, [x19, #0x20]
006B8A990  b        #0x6b8aa2c ; 
006B8A994  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006B8A998  adrp     x21, #0x8f05000
006B8A99C  ldur     q0, [sp, #0x38]
006B8A9A0  ldr      x8, [sp, #0x48]
006B8A9A4  ldr      x21, [x21, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo @ 0x91ebf60
006B8A9A8  str      q0, [sp, #0x50]
006B8A9AC  str      x8, [sp, #0x60]
006B8A9B0  ldr      x0, [x21]
006B8A9B4  ldr      w8, [x0, #0xe0]
006B8A9B8  cbnz     w8, #0x6b8a9c4
006B8A9BC  bl       #0x382be8c ; 
006B8A9C0  ldr      x0, [x21]
006B8A9C4  adrp     x9, #0x8ee8000
006B8A9C8  ldr      x8, [x0, #0xb8]
006B8A9CC  ldr      x9, [x9, #0x838] ; GLOBAL Method$System.Nullable<FP>..ctor() @ 0x9227b20
006B8A9D0  add      x0, sp, #0x38
006B8A9D4  ldr      x1, [x8, #0x28]
006B8A9D8  ldr      x2, [x9]
006B8A9DC  stp      xzr, xzr, [sp, #0x38]
006B8A9E0  bl       #0x51328c0 ; System.Nullable<FP>$$.ctor
006B8A9E4  cbz      x20, #0x6b8abbc
006B8A9E8  ldr      q0, [sp, #0x50]
006B8A9EC  ldr      x8, [sp, #0x60]
006B8A9F0  ldp      x2, x3, [sp, #0x38]
006B8A9F4  add      x1, sp, #0x20
006B8A9F8  mov      x0, x20
006B8A9FC  mov      x4, xzr
006B8AA00  str      q0, [sp, #0x20]
006B8AA04  str      x8, [sp, #0x30]
006B8AA08  bl       #0x69096f0 ; HotFix.BattleLogic.MapManager$$IsPosInCameraBounds
006B8AA0C  tbz      w0, #0, #0x6b8ab90
006B8AA10  mov      w8, #1
006B8AA14  strb     w8, [x19, #0x148]
006B8AA18  b        #0x6b8ab90 ; 
006B8AA1C  ldr      x8, [x1, #0x60]
006B8AA20  mov      x0, x19
006B8AA24  blr      x8
006B8AA28  mov      x20, x0
006B8AA2C  cbz      x20, #0x6b8abbc
006B8AA30  adrp     x21, #0x9598000
006B8AA34  ldrb     w8, [x21, #0xfc4]
006B8AA38  cbnz     w8, #0x6b8aa50
006B8AA3C  adrp     x0, #0x8f05000
006B8AA40  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006B8AA44  bl       #0x382bd14 ; 
006B8AA48  mov      w8, #1
006B8AA4C  strb     w8, [x21, #0xfc4]
006B8AA50  adrp     x26, #0x8f05000
006B8AA54  ldr      x26, [x26, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006B8AA58  ldr      x1, [x26]
006B8AA5C  ldrb     w8, [x1, #0x53]
006B8AA60  tbnz     w8, #5, #0x6b8aa6c
006B8AA64  ldr      x0, [x20, #0x220]
006B8AA68  b        #0x6b8aa78 ; 
006B8AA6C  ldr      x8, [x1, #0x60]
006B8AA70  mov      x0, x20
006B8AA74  blr      x8
006B8AA78  cbz      x0, #0x6b8abbc
006B8AA7C  adrp     x25, #0x8f33000
006B8AA80  ldr      x1, [x19, #0x58]
006B8AA84  ldr      x25, [x25, #0xe08] ; GLOBAL HotFix.BattleLogic.EntityNpc_TypeInfo @ 0x91e5b40
006B8AA88  cbz      x1, #0x6b8aab8
006B8AA8C  ldr      x9, [x1]
006B8AA90  ldr      x8, [x25]
006B8AA94  ldrb     w11, [x9, #0x130]
006B8AA98  ldrb     w10, [x8, #0x130]
006B8AA9C  cmp      w11, w10
006B8AAA0  b.lo     #0x6b8abc0
006B8AAA4  ldr      x9, [x9, #0xc8]
006B8AAA8  add      x9, x9, x10, lsl #3
006B8AAAC  ldur     x9, [x9, #-8]
006B8AAB0  cmp      x9, x8
006B8AAB4  b.ne     #0x6b8abc0
006B8AAB8  ldr      x8, [x0]
006B8AABC  ldr      x9, [x8, #0x3b8]
006B8AAC0  ldr      x2, [x8, #0x3c0]
006B8AAC4  blr      x9
006B8AAC8  ldrb     w8, [x24, #0xa4b]
006B8AACC  cbnz     w8, #0x6b8aae4
006B8AAD0  adrp     x0, #0x8ee5000
006B8AAD4  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8AAD8  bl       #0x382bd14 ; 
006B8AADC  mov      w8, #1
006B8AAE0  strb     w8, [x24, #0xa4b]
006B8AAE4  ldr      x1, [x23]
006B8AAE8  ldrb     w8, [x1, #0x53]
006B8AAEC  tbnz     w8, #5, #0x6b8aaf8
006B8AAF0  ldr      x20, [x19, #0x20]
006B8AAF4  b        #0x6b8ab08 ; 
006B8AAF8  ldr      x8, [x1, #0x60]
006B8AAFC  mov      x0, x19
006B8AB00  blr      x8
006B8AB04  mov      x20, x0
006B8AB08  cbz      x20, #0x6b8abbc
006B8AB0C  ldrb     w8, [x21, #0xfc4]
006B8AB10  cbnz     w8, #0x6b8ab28
006B8AB14  adrp     x0, #0x8f05000
006B8AB18  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006B8AB1C  bl       #0x382bd14 ; 
006B8AB20  mov      w8, #1
006B8AB24  strb     w8, [x21, #0xfc4]
006B8AB28  ldr      x1, [x26]
006B8AB2C  ldrb     w8, [x1, #0x53]
006B8AB30  tbnz     w8, #5, #0x6b8ab3c
006B8AB34  ldr      x0, [x20, #0x220]
006B8AB38  b        #0x6b8ab48 ; 
006B8AB3C  ldr      x8, [x1, #0x60]
006B8AB40  mov      x0, x20
006B8AB44  blr      x8
006B8AB48  cbz      x0, #0x6b8abbc
006B8AB4C  ldr      x1, [x19, #0x58]
006B8AB50  cbz      x1, #0x6b8ab80
006B8AB54  ldr      x9, [x1]
006B8AB58  ldr      x8, [x25]
006B8AB5C  ldrb     w11, [x9, #0x130]
006B8AB60  ldrb     w10, [x8, #0x130]
006B8AB64  cmp      w11, w10
006B8AB68  b.lo     #0x6b8abc0
006B8AB6C  ldr      x9, [x9, #0xc8]
006B8AB70  add      x9, x9, x10, lsl #3
006B8AB74  ldur     x9, [x9, #-8]
006B8AB78  cmp      x9, x8
006B8AB7C  b.ne     #0x6b8abc0
006B8AB80  ldr      x8, [x0]
006B8AB84  ldr      x9, [x8, #0x3d8]
006B8AB88  ldr      x2, [x8, #0x3e0]
006B8AB8C  blr      x9
006B8AB90  ldr      x8, [x22, #0x28]
006B8AB94  ldr      x9, [sp, #0x68]
006B8AB98  cmp      x8, x9
006B8AB9C  b.ne     #0x6b8abd4
006B8ABA0  ldp      x20, x19, [sp, #0xb0]
006B8ABA4  ldp      x22, x21, [sp, #0xa0]
006B8ABA8  ldp      x24, x23, [sp, #0x90]
006B8ABAC  ldp      x26, x25, [sp, #0x80]
006B8ABB0  ldp      x30, x27, [sp, #0x70]
006B8ABB4  add      sp, sp, #0xc0
006B8ABB8  ret      
006B8ABBC  bl       #0x382bfb8 ; 
006B8ABC0  mov      x0, x1
006B8ABC4  b        #0x6b8abcc ; 
006B8ABC8  mov      x0, x2
006B8ABCC  mov      x1, x8
006B8ABD0  bl       #0x382c354 ; 
006B8ABD4  bl       #0x89edb60 ; 

