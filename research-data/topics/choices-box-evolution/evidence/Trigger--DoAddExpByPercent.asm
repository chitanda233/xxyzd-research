; HotFix.BattleLogic.Trigger$$DoAddExpByPercent
; RVA 0x67C447C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067C447C  sub      sp, sp, #0xe0
0067C4480  stp      x29, x30, [sp, #0x80]
0067C4484  stp      x28, x27, [sp, #0x90]
0067C4488  stp      x26, x25, [sp, #0xa0]
0067C448C  stp      x24, x23, [sp, #0xb0]
0067C4490  stp      x22, x21, [sp, #0xc0]
0067C4494  stp      x20, x19, [sp, #0xd0]
0067C4498  mrs      x25, tpidr_el0
0067C449C  ldr      x8, [x25, #0x28]
0067C44A0  adrp     x21, #0x959b000
0067C44A4  adrp     x23, #0x8f1d000
0067C44A8  mov      x20, x2
0067C44AC  str      x8, [sp, #0x78]
0067C44B0  ldrb     w8, [x21, #0xf3]
0067C44B4  ldr      x23, [x23, #0xc10] ; GLOBAL Method$HotFix.BattleLogic.Trigger.DoAddExpByPercent() @ 0x92b64a0
0067C44B8  mov      x22, x1
0067C44BC  mov      x19, x0
0067C44C0  tbnz     w8, #0, #0x67c4514
0067C44C4  adrp     x0, #0x8f1d000
0067C44C8  ldr      x0, [x0, #0xc18] ; GLOBAL HotFix.BattleLogic.AddExpByPercentParam_TypeInfo @ 0x91e0338
0067C44CC  bl       #0x382bd14 ; 
0067C44D0  adrp     x0, #0x8ee6000
0067C44D4  ldr      x0, [x0, #0x608] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Entity() @ 0x9210250
0067C44D8  bl       #0x382bd14 ; 
0067C44DC  adrp     x0, #0x8f0f000
0067C44E0  ldr      x0, [x0, #0x5b8] ; GLOBAL Method$System.Collections.Generic.List<DropItemData>.Add() @ 0x921ba90
0067C44E4  bl       #0x382bd14 ; 
0067C44E8  adrp     x0, #0x8f1d000
0067C44EC  ldr      x0, [x0, #0xc10] ; GLOBAL Method$HotFix.BattleLogic.Trigger.DoAddExpByPercent() @ 0x92b64a0
0067C44F0  bl       #0x382bd14 ; 
0067C44F4  adrp     x0, #0x8f0f000
0067C44F8  ldr      x0, [x0, #0x570] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<DropItemData>() @ 0x92cfd18
0067C44FC  bl       #0x382bd14 ; 
0067C4500  adrp     x0, #0x8f0f000
0067C4504  ldr      x0, [x0, #0x578] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<DropItemData>() @ 0x92cfdb8
0067C4508  bl       #0x382bd14 ; 
0067C450C  mov      w8, #1
0067C4510  strb     w8, [x21, #0xf3]
0067C4514  ldr      x3, [x23]
0067C4518  ldrb     w8, [x3, #0x53]
0067C451C  tbnz     w8, #5, #0x67c4548
0067C4520  ldr      x0, [x19, #0x48]
0067C4524  cbz      x0, #0x67c49e8
0067C4528  adrp     x8, #0x8ee6000
0067C452C  ldr      x8, [x8, #0x608] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Entity() @ 0x9210250
0067C4530  ldr      x1, [x8]
0067C4534  ldrb     w8, [x1, #0x53]
0067C4538  tbnz     w8, #5, #0x67c4560
0067C453C  ldr      x0, [x0, #0x30]
0067C4540  cbnz     x0, #0x67c456c
0067C4544  b        #0x67c49b8 ; 
0067C4548  ldr      x8, [x3, #0x60]
0067C454C  mov      x0, x19
0067C4550  mov      x1, x22
0067C4554  mov      x2, x20
0067C4558  blr      x8
0067C455C  b        #0x67c49b8 ; 
0067C4560  ldr      x8, [x1, #0x60]
0067C4564  blr      x8
0067C4568  cbz      x0, #0x67c49b8
0067C456C  mov      x1, xzr
0067C4570  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0067C4574  tbnz     w0, #0, #0x67c49b8
0067C4578  cbz      x20, #0x67c49e8
0067C457C  adrp     x9, #0x8f1d000
0067C4580  ldr      x9, [x9, #0xc18] ; GLOBAL HotFix.BattleLogic.AddExpByPercentParam_TypeInfo @ 0x91e0338
0067C4584  ldr      x8, [x20]
0067C4588  ldr      x1, [x9]
0067C458C  ldrb     w10, [x8, #0x130]
0067C4590  ldrb     w9, [x1, #0x130]
0067C4594  cmp      w10, w9
0067C4598  b.lo     #0x67c49ec
0067C459C  ldr      x8, [x8, #0xc8]
0067C45A0  add      x8, x8, x9, lsl #3
0067C45A4  ldur     x8, [x8, #-8]
0067C45A8  cmp      x8, x1
0067C45AC  b.ne     #0x67c49ec
0067C45B0  adrp     x27, #0x9591000
0067C45B4  ldrb     w8, [x27, #0xa4b]
0067C45B8  ldp      w24, w21, [x20, #0x10]
0067C45BC  cbnz     w8, #0x67c45d4
0067C45C0  adrp     x0, #0x8ee5000
0067C45C4  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C45C8  bl       #0x382bd14 ; 
0067C45CC  mov      w8, #1
0067C45D0  strb     w8, [x27, #0xa4b]
0067C45D4  adrp     x8, #0x8ee5000
0067C45D8  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C45DC  ldr      x1, [x8]
0067C45E0  ldrb     w8, [x1, #0x53]
0067C45E4  tbnz     w8, #5, #0x67c45f0
0067C45E8  ldr      x23, [x19, #0x20]
0067C45EC  b        #0x67c4600 ; 
0067C45F0  ldr      x8, [x1, #0x60]
0067C45F4  mov      x0, x19
0067C45F8  blr      x8
0067C45FC  mov      x23, x0
0067C4600  cbz      x23, #0x67c49e8
0067C4604  adrp     x20, #0x9598000
0067C4608  ldrb     w8, [x20, #0xfcc]
0067C460C  cbnz     w8, #0x67c4624
0067C4610  adrp     x0, #0x8f06000
0067C4614  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0067C4618  bl       #0x382bd14 ; 
0067C461C  mov      w8, #1
0067C4620  strb     w8, [x20, #0xfcc]
0067C4624  adrp     x8, #0x8f06000
0067C4628  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0067C462C  ldr      x1, [x8]
0067C4630  ldrb     w8, [x1, #0x53]
0067C4634  tbnz     w8, #5, #0x67c4640
0067C4638  ldr      x0, [x23, #0x200]
0067C463C  b        #0x67c464c ; 
0067C4640  ldr      x8, [x1, #0x60]
0067C4644  mov      x0, x23
0067C4648  blr      x8
0067C464C  cbz      x0, #0x67c49e8
0067C4650  mov      w1, w21
0067C4654  mov      x2, xzr
0067C4658  bl       #0x64e3708 ; LocalModels.LocalModelManager$$GetItem_battle
0067C465C  cbz      x22, #0x67c49e8
0067C4660  ldr      q0, [x22, #0x20]
0067C4664  ldr      x8, [x22, #0x30]
0067C4668  ldrb     w9, [x27, #0xa4b]
0067C466C  mov      x21, x0
0067C4670  str      q0, [sp, #0x60]
0067C4674  str      x8, [sp, #0x70]
0067C4678  cbnz     w9, #0x67c4690
0067C467C  adrp     x0, #0x8ee5000
0067C4680  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C4684  bl       #0x382bd14 ; 
0067C4688  mov      w8, #1
0067C468C  strb     w8, [x27, #0xa4b]
0067C4690  adrp     x8, #0x8ee5000
0067C4694  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C4698  ldr      x1, [x8]
0067C469C  ldrb     w8, [x1, #0x53]
0067C46A0  tbnz     w8, #5, #0x67c46ac
0067C46A4  ldr      x22, [x19, #0x20]
0067C46A8  b        #0x67c46bc ; 
0067C46AC  ldr      x8, [x1, #0x60]
0067C46B0  mov      x0, x19
0067C46B4  blr      x8
0067C46B8  mov      x22, x0
0067C46BC  cbz      x22, #0x67c49e8
0067C46C0  adrp     x20, #0x9591000
0067C46C4  ldrb     w8, [x20, #0xa90]
0067C46C8  cbnz     w8, #0x67c46e0
0067C46CC  adrp     x0, #0x8ee6000
0067C46D0  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0067C46D4  bl       #0x382bd14 ; 
0067C46D8  mov      w8, #1
0067C46DC  strb     w8, [x20, #0xa90]
0067C46E0  adrp     x8, #0x8ee6000
0067C46E4  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0067C46E8  ldr      x1, [x8]
0067C46EC  ldrb     w8, [x1, #0x53]
0067C46F0  tbnz     w8, #5, #0x67c46fc
0067C46F4  ldr      x0, [x22, #0x230]
0067C46F8  b        #0x67c4708 ; 
0067C46FC  ldr      x8, [x1, #0x60]
0067C4700  mov      x0, x22
0067C4704  blr      x8
0067C4708  str      x25, [sp, #8]
0067C470C  cbz      x0, #0x67c49e8
0067C4710  adrp     x8, #0x8f0f000
0067C4714  ldr      x8, [x8, #0x570] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<DropItemData>() @ 0x92cfd18
0067C4718  ldr      x1, [x8]
0067C471C  bl       #0x4784cec ; HotFix.Common.XListPoolHelper$$Get<object>
0067C4720  adrp     x8, #0x1980000
0067C4724  ldr      q0, [x8, #0xbc0]
0067C4728  bic      w29, w24, w24, asr #31
0067C472C  adrp     x24, #0x8f07000
0067C4730  ldr      x24, [x24, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
0067C4734  str      q0, [sp, #0x10]
0067C4738  adrp     x25, #0x8f0f000
0067C473C  ldr      x25, [x25, #0x48] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_parameter() @ 0x9285d98
0067C4740  mov      x22, x0
0067C4744  mov      w23, wzr
0067C4748  adrp     x28, #0x9599000
0067C474C  adrp     x20, #0x9599000
0067C4750  ldrb     w8, [x27, #0xa4b]
0067C4754  cbnz     w8, #0x67c476c
0067C4758  adrp     x0, #0x8ee5000
0067C475C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C4760  bl       #0x382bd14 ; 
0067C4764  mov      w8, #1
0067C4768  strb     w8, [x27, #0xa4b]
0067C476C  adrp     x8, #0x8ee5000
0067C4770  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C4774  ldr      x1, [x8]
0067C4778  ldrb     w8, [x1, #0x53]
0067C477C  tbnz     w8, #5, #0x67c4788
0067C4780  ldr      x26, [x19, #0x20]
0067C4784  b        #0x67c4798 ; 
0067C4788  ldr      x8, [x1, #0x60]
0067C478C  mov      x0, x19
0067C4790  blr      x8
0067C4794  mov      x26, x0
0067C4798  cbz      x26, #0x67c49e8
0067C479C  ldrb     w8, [x28, #0x287]
0067C47A0  cbnz     w8, #0x67c47b4
0067C47A4  mov      x0, x24
0067C47A8  bl       #0x382bd14 ; 
0067C47AC  mov      w8, #1
0067C47B0  strb     w8, [x28, #0x287]
0067C47B4  ldr      x1, [x24]
0067C47B8  ldrb     w8, [x1, #0x53]
0067C47BC  tbnz     w8, #5, #0x67c47c8
0067C47C0  ldr      x0, [x26, #0x350]
0067C47C4  b        #0x67c47d4 ; 
0067C47C8  ldr      x8, [x1, #0x60]
0067C47CC  mov      x0, x26
0067C47D0  blr      x8
0067C47D4  cmp      w29, w23
0067C47D8  b.eq     #0x67c48f8
0067C47DC  ldr      q0, [sp, #0x60]
0067C47E0  ldr      x8, [sp, #0x70]
0067C47E4  str      q0, [sp, #0x40]
0067C47E8  str      x8, [sp, #0x50]
0067C47EC  cbz      x0, #0x67c49e8
0067C47F0  ldr      q0, [sp, #0x40]
0067C47F4  ldr      x8, [sp, #0x50]
0067C47F8  add      x2, sp, #0x20
0067C47FC  mov      w1, #1
0067C4800  mov      w5, #0x10000
0067C4804  mov      w6, #0x10000
0067C4808  mov      w7, #1
0067C480C  mov      x3, x21
0067C4810  mov      w4, w23
0067C4814  str      q0, [sp, #0x20]
0067C4818  str      x8, [sp, #0x30]
0067C481C  str      xzr, [sp]
0067C4820  bl       #0x666cb60 ; HotFix.BattleLogic.DropMgr$$CreteDropData
0067C4824  cbz      x21, #0x67c49e8
0067C4828  ldrb     w8, [x20, #0xebc]
0067C482C  mov      x26, x0
0067C4830  cbnz     w8, #0x67c4844
0067C4834  mov      x0, x25
0067C4838  bl       #0x382bd14 ; 
0067C483C  mov      w8, #1
0067C4840  strb     w8, [x20, #0xebc]
0067C4844  ldr      x1, [x25]
0067C4848  ldrb     w8, [x1, #0x53]
0067C484C  tbnz     w8, #5, #0x67c4858
0067C4850  ldr      w0, [x21, #0x28]
0067C4854  b        #0x67c4864 ; 
0067C4858  ldr      x8, [x1, #0x60]
0067C485C  mov      x0, x21
0067C4860  blr      x8
0067C4864  cbz      x26, #0x67c49e8
0067C4868  sbfiz    x1, x0, #0x10, #0x20
0067C486C  mov      x0, xzr
0067C4870  mov      x2, xzr
0067C4874  str      x1, [x26, #0xc0]
0067C4878  bl       #0x7d46f68 ; Photon.Deterministic.FPMath$$Max
0067C487C  ldr      q0, [sp, #0x10]
0067C4880  str      x0, [x26, #0xc0]
0067C4884  str      q0, [x26, #0xd0]
0067C4888  cbz      x22, #0x67c49e8
0067C488C  adrp     x9, #0x8f0f000
0067C4890  ldr      w10, [x22, #0x1c]
0067C4894  ldr      x8, [x22, #0x10]
0067C4898  ldr      x9, [x9, #0x5b8] ; GLOBAL Method$System.Collections.Generic.List<DropItemData>.Add() @ 0x921ba90
0067C489C  add      w10, w10, #1
0067C48A0  ldr      x9, [x9]
0067C48A4  str      w10, [x22, #0x1c]
0067C48A8  cbz      x8, #0x67c49e8
0067C48AC  ldrsw    x10, [x22, #0x18]
0067C48B0  ldr      w11, [x8, #0x18]
0067C48B4  cmp      w10, w11
0067C48B8  b.hs     #0x67c48d8
0067C48BC  add      w9, w10, #1
0067C48C0  add      x0, x8, x10, lsl #3
0067C48C4  str      w9, [x22, #0x18]
0067C48C8  str      x26, [x0, #0x20]!
0067C48CC  mov      x1, x26
0067C48D0  bl       #0x382bcb8 ; 
0067C48D4  b        #0x67c48f0 ; 
0067C48D8  ldr      x8, [x9, #0x20]
0067C48DC  mov      x0, x22
0067C48E0  mov      x1, x26
0067C48E4  ldr      x8, [x8, #0xc0]
0067C48E8  ldr      x2, [x8, #0x70]
0067C48EC  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0067C48F0  add      w23, w23, #1
0067C48F4  b        #0x67c4750 ; 
0067C48F8  cbz      x0, #0x67c49e8
0067C48FC  mov      x1, x22
0067C4900  mov      x2, xzr
0067C4904  bl       #0x666a808 ; HotFix.BattleLogic.DropMgr$$DropItems
0067C4908  ldrb     w8, [x27, #0xa4b]
0067C490C  ldr      x25, [sp, #8]
0067C4910  adrp     x20, #0x9591000
0067C4914  cbnz     w8, #0x67c492c
0067C4918  adrp     x0, #0x8ee5000
0067C491C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C4920  bl       #0x382bd14 ; 
0067C4924  mov      w8, #1
0067C4928  strb     w8, [x27, #0xa4b]
0067C492C  adrp     x8, #0x8ee5000
0067C4930  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067C4934  ldr      x1, [x8]
0067C4938  ldrb     w8, [x1, #0x53]
0067C493C  tbnz     w8, #5, #0x67c4948
0067C4940  ldr      x19, [x19, #0x20]
0067C4944  b        #0x67c4958 ; 
0067C4948  ldr      x8, [x1, #0x60]
0067C494C  mov      x0, x19
0067C4950  blr      x8
0067C4954  mov      x19, x0
0067C4958  cbz      x19, #0x67c49e8
0067C495C  ldrb     w8, [x20, #0xa90]
0067C4960  cbnz     w8, #0x67c4978
0067C4964  adrp     x0, #0x8ee6000
0067C4968  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0067C496C  bl       #0x382bd14 ; 
0067C4970  mov      w8, #1
0067C4974  strb     w8, [x20, #0xa90]
0067C4978  adrp     x8, #0x8ee6000
0067C497C  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0067C4980  ldr      x1, [x8]
0067C4984  ldrb     w8, [x1, #0x53]
0067C4988  tbnz     w8, #5, #0x67c4994
0067C498C  ldr      x0, [x19, #0x230]
0067C4990  b        #0x67c49a0 ; 
0067C4994  ldr      x8, [x1, #0x60]
0067C4998  mov      x0, x19
0067C499C  blr      x8
0067C49A0  cbz      x0, #0x67c49e8
0067C49A4  adrp     x8, #0x8f0f000
0067C49A8  ldr      x8, [x8, #0x578] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<DropItemData>() @ 0x92cfdb8
0067C49AC  mov      x1, x22
0067C49B0  ldr      x2, [x8]
0067C49B4  bl       #0x47866c4 ; HotFix.Common.XListPoolHelper$$Push<object>
0067C49B8  ldr      x8, [x25, #0x28]
0067C49BC  ldr      x9, [sp, #0x78]
0067C49C0  cmp      x8, x9
0067C49C4  b.ne     #0x67c49f4
0067C49C8  ldp      x20, x19, [sp, #0xd0]
0067C49CC  ldp      x22, x21, [sp, #0xc0]
0067C49D0  ldp      x24, x23, [sp, #0xb0]
0067C49D4  ldp      x26, x25, [sp, #0xa0]
0067C49D8  ldp      x28, x27, [sp, #0x90]
0067C49DC  ldp      x29, x30, [sp, #0x80]
0067C49E0  add      sp, sp, #0xe0
0067C49E4  ret      
0067C49E8  bl       #0x382bfb8 ; 
0067C49EC  mov      x0, x20
0067C49F0  bl       #0x382c354 ; 
0067C49F4  bl       #0x89edb60 ; 

