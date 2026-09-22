; HotFix.BattleLogic.EntityCharacter$$InitAnimator
; RVA 0x67D716C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067D716C  sub      sp, sp, #0x70
0067D7170  stp      x29, x30, [sp, #0x10]
0067D7174  stp      x28, x27, [sp, #0x20]
0067D7178  stp      x26, x25, [sp, #0x30]
0067D717C  stp      x24, x23, [sp, #0x40]
0067D7180  stp      x22, x21, [sp, #0x50]
0067D7184  stp      x20, x19, [sp, #0x60]
0067D7188  adrp     x20, #0x959b000
0067D718C  adrp     x21, #0x8f1e000
0067D7190  ldrb     w8, [x20, #0x1d9]
0067D7194  ldr      x21, [x21, #0x6a0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitAnimator()
0067D7198  mov      x19, x0
0067D719C  tbnz     w8, #0, #0x67d7298
0067D71A0  adrp     x0, #0x8ec5000
0067D71A4  ldr      x0, [x0, #0x880] ; GLOBAL System.IO.BinaryReader_TypeInfo
0067D71A8  bl       #0x382bd14 ; 
0067D71AC  adrp     x0, #0x8ee2000
0067D71B0  ldr      x0, [x0, #0xe68] ; GLOBAL Deterministic.Animation.DeterministicAnimationUtils_TypeInfo
0067D71B4  bl       #0x382bd14 ; 
0067D71B8  adrp     x0, #0x8f1e000
0067D71BC  ldr      x0, [x0, #0x6a8] ; GLOBAL Deterministic.Animation.DeterministicAnimator_TypeInfo
0067D71C0  bl       #0x382bd14 ; 
0067D71C4  adrp     x0, #0x8ee6000
0067D71C8  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D71CC  bl       #0x382bd14 ; 
0067D71D0  adrp     x0, #0x8f1e000
0067D71D4  ldr      x0, [x0, #0x6a0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitAnimator()
0067D71D8  bl       #0x382bd14 ; 
0067D71DC  adrp     x0, #0x8ebf000
0067D71E0  ldr      x0, [x0, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0067D71E4  bl       #0x382bd14 ; 
0067D71E8  adrp     x0, #0x8f1e000
0067D71EC  ldr      x0, [x0, #0x6b0] ; GLOBAL HotFix.BattleLogic.IResourceBridge_TypeInfo
0067D71F0  bl       #0x382bd14 ; 
0067D71F4  adrp     x0, #0x8ebf000
0067D71F8  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo
0067D71FC  bl       #0x382bd14 ; 
0067D7200  adrp     x0, #0x8ee1000
0067D7204  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
0067D7208  bl       #0x382bd14 ; 
0067D720C  adrp     x0, #0x8ec3000
0067D7210  ldr      x0, [x0, #0x2d0] ; GLOBAL System.IO.MemoryStream_TypeInfo
0067D7214  bl       #0x382bd14 ; 
0067D7218  adrp     x0, #0x8ec2000
0067D721C  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo
0067D7220  bl       #0x382bd14 ; 
0067D7224  adrp     x0, #0x8ec2000
0067D7228  ldr      x0, [x0, #0x420] ; GLOBAL string_TypeInfo
0067D722C  bl       #0x382bd14 ; 
0067D7230  adrp     x0, #0x8f1e000
0067D7234  ldr      x0, [x0, #0x6b8] ; GLOBAL InitAnimator
0067D7238  bl       #0x382bd14 ; 
0067D723C  adrp     x0, #0x8ee2000
0067D7240  ldr      x0, [x0, #0xfa0] ; GLOBAL SkillExit01
0067D7244  bl       #0x382bd14 ; 
0067D7248  adrp     x0, #0x8f1e000
0067D724C  ldr      x0, [x0, #0x6c0] ; GLOBAL SkillEnter01
0067D7250  bl       #0x382bd14 ; 
0067D7254  adrp     x0, #0x8f1e000
0067D7258  ldr      x0, [x0, #0x6c8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityCharacter\EntityCharacter.cs
0067D725C  bl       #0x382bd14 ; 
0067D7260  adrp     x0, #0x8f1e000
0067D7264  ldr      x0, [x0, #0x6d0] ; GLOBAL {0} Baked animation bytes missing entityId={1}, modelId={2}, path={3}, dataPath={4}
0067D7268  bl       #0x382bd14 ; 
0067D726C  adrp     x0, #0x8f1e000
0067D7270  ldr      x0, [x0, #0x6d8] ; GLOBAL {0} Model_model row missing entityId={1}, modelId={2}
0067D7274  bl       #0x382bd14 ; 
0067D7278  adrp     x0, #0x8f1e000
0067D727C  ldr      x0, [x0, #0x6e0] ; GLOBAL [WingPlaneAnimatorDebug]
0067D7280  bl       #0x382bd14 ; 
0067D7284  adrp     x0, #0x8f05000
0067D7288  ldr      x0, [x0, #0x828] ; GLOBAL Idle
0067D728C  bl       #0x382bd14 ; 
0067D7290  mov      w8, #1
0067D7294  strb     w8, [x20, #0x1d9]
0067D7298  ldr      x1, [x21]
0067D729C  ldrb     w8, [x1, #0x53]
0067D72A0  tbnz     w8, #5, #0x67d72f0
0067D72A4  adrp     x8, #0x8f1e000
0067D72A8  ldr      x8, [x8, #0x6a8] ; GLOBAL Deterministic.Animation.DeterministicAnimator_TypeInfo
0067D72AC  adrp     x28, #0x8ee6000
0067D72B0  ldr      x0, [x8]
0067D72B4  ldr      x28, [x28, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D72B8  bl       #0x382bfa0 ; 
0067D72BC  mov      x1, xzr
0067D72C0  mov      x21, x0
0067D72C4  bl       #0x4186880 ; Deterministic.Animation.DeterministicAnimator$$.ctor
0067D72C8  mov      x20, x19
0067D72CC  str      x21, [x20, #0x80]!
0067D72D0  mov      x0, x20
0067D72D4  mov      x1, x21
0067D72D8  bl       #0x382bcb8 ; 
0067D72DC  ldr      x1, [x28]
0067D72E0  ldrb     w8, [x1, #0x53]
0067D72E4  tbnz     w8, #5, #0x67d7318
0067D72E8  ldr      x21, [x19, #0x38]
0067D72EC  b        #0x67d7328 ; 
0067D72F0  ldr      x2, [x1, #0x60]
0067D72F4  mov      x0, x19
0067D72F8  ldp      x20, x19, [sp, #0x60]
0067D72FC  ldp      x22, x21, [sp, #0x50]
0067D7300  ldp      x24, x23, [sp, #0x40]
0067D7304  ldp      x26, x25, [sp, #0x30]
0067D7308  ldp      x28, x27, [sp, #0x20]
0067D730C  ldp      x29, x30, [sp, #0x10]
0067D7310  add      sp, sp, #0x70
0067D7314  br       x2
0067D7318  ldr      x8, [x1, #0x60]
0067D731C  mov      x0, x19
0067D7320  blr      x8
0067D7324  mov      x21, x0
0067D7328  cbz      x21, #0x67d8028
0067D732C  adrp     x22, #0x9591000
0067D7330  ldrb     w8, [x22, #0xa74]
0067D7334  cbnz     w8, #0x67d734c
0067D7338  adrp     x0, #0x8ee6000
0067D733C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D7340  bl       #0x382bd14 ; 
0067D7344  mov      w8, #1
0067D7348  strb     w8, [x22, #0xa74]
0067D734C  adrp     x8, #0x8ee6000
0067D7350  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0067D7354  ldr      x1, [x8]
0067D7358  ldrb     w8, [x1, #0x53]
0067D735C  tbnz     w8, #5, #0x67d7368
0067D7360  ldr      x0, [x21, #0x170]
0067D7364  b        #0x67d7374 ; 
0067D7368  ldr      x8, [x1, #0x60]
0067D736C  mov      x0, x21
0067D7370  blr      x8
0067D7374  cbz      x0, #0x67d8028
0067D7378  mov      x1, xzr
0067D737C  bl       #0x68c59d4 ; LocalModels.Bean.Character_entity$$get_ABModelID
0067D7380  adrp     x24, #0x9591000
0067D7384  ldrb     w8, [x24, #0xa4b]
0067D7388  mov      w21, w0
0067D738C  cbnz     w8, #0x67d73a4
0067D7390  adrp     x0, #0x8ee5000
0067D7394  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0067D7398  bl       #0x382bd14 ; 
0067D739C  mov      w8, #1
0067D73A0  strb     w8, [x24, #0xa4b]
0067D73A4  adrp     x25, #0x8ee5000
0067D73A8  ldr      x25, [x25, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0067D73AC  ldr      x1, [x25]
0067D73B0  ldrb     w8, [x1, #0x53]
0067D73B4  tbnz     w8, #5, #0x67d73c0
0067D73B8  ldr      x22, [x19, #0x20]
0067D73BC  b        #0x67d73d0 ; 
0067D73C0  ldr      x8, [x1, #0x60]
0067D73C4  mov      x0, x19
0067D73C8  blr      x8
0067D73CC  mov      x22, x0
0067D73D0  cbz      x22, #0x67d8028
0067D73D4  adrp     x23, #0x9598000
0067D73D8  ldrb     w8, [x23, #0xfcc]
0067D73DC  cbnz     w8, #0x67d73f4
0067D73E0  adrp     x0, #0x8f06000
0067D73E4  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0067D73E8  bl       #0x382bd14 ; 
0067D73EC  mov      w8, #1
0067D73F0  strb     w8, [x23, #0xfcc]
0067D73F4  adrp     x8, #0x8f06000
0067D73F8  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0067D73FC  ldr      x1, [x8]
0067D7400  ldrb     w8, [x1, #0x53]
0067D7404  tbnz     w8, #5, #0x67d7410
0067D7408  ldr      x22, [x22, #0x200]
0067D740C  b        #0x67d7420 ; 
0067D7410  ldr      x8, [x1, #0x60]
0067D7414  mov      x0, x22
0067D7418  blr      x8
0067D741C  mov      x22, x0
0067D7420  cbz      x22, #0x67d8028
0067D7424  adrp     x23, #0x959b000
0067D7428  ldrb     w8, [x23, #0x391]
0067D742C  cbnz     w8, #0x67d7444
0067D7430  adrp     x0, #0x8efa000
0067D7434  ldr      x0, [x0, #0xfe8] ; GLOBAL Method$LocalModels.LocalModelManager.GetModel_modelModelInstance()
0067D7438  bl       #0x382bd14 ; 
0067D743C  mov      w8, #1
0067D7440  strb     w8, [x23, #0x391]
0067D7444  adrp     x8, #0x8efa000
0067D7448  ldr      x8, [x8, #0xfe8] ; GLOBAL Method$LocalModels.LocalModelManager.GetModel_modelModelInstance()
0067D744C  ldr      x1, [x8]
0067D7450  ldrb     w8, [x1, #0x53]
0067D7454  tbnz     w8, #5, #0x67d7460
0067D7458  ldr      x0, [x22, #0x3e0]
0067D745C  b        #0x67d746c ; 
0067D7460  ldr      x8, [x1, #0x60]
0067D7464  mov      x0, x22
0067D7468  blr      x8
0067D746C  cbz      x0, #0x67d8028
0067D7470  sxtw     x1, w21
0067D7474  mov      x2, xzr
0067D7478  bl       #0x66d94e8 ; LocalModels.Model.Model_modelModel$$GetElementById
0067D747C  mov      x22, x0
0067D7480  mov      x0, x19
0067D7484  bl       #0x67d8264 ; HotFix.BattleLogic.EntityCharacter$$ShouldLogWingPlaneAnimatorDebug
0067D7488  cbz      x22, #0x67d74c8
0067D748C  adrp     x29, #0x959b000
0067D7490  ldrb     w8, [x29, #0x392]
0067D7494  cbnz     w8, #0x67d74ac
0067D7498  adrp     x0, #0x8f1e000
0067D749C  ldr      x0, [x0, #0x6e8] ; GLOBAL Method$LocalModels.Bean.Model_model.get_path()
0067D74A0  bl       #0x382bd14 ; 
0067D74A4  mov      w8, #1
0067D74A8  strb     w8, [x29, #0x392]
0067D74AC  adrp     x27, #0x8f1e000
0067D74B0  ldr      x27, [x27, #0x6e8] ; GLOBAL Method$LocalModels.Bean.Model_model.get_path()
0067D74B4  ldr      x1, [x27]
0067D74B8  ldrb     w8, [x1, #0x53]
0067D74BC  tbnz     w8, #5, #0x67d74ec
0067D74C0  ldr      x23, [x22, #0x28]
0067D74C4  b        #0x67d74fc ; 
0067D74C8  mov      x0, x19
0067D74CC  strb     wzr, [x19, #0x88]
0067D74D0  bl       #0x67d8264 ; HotFix.BattleLogic.EntityCharacter$$ShouldLogWingPlaneAnimatorDebug
0067D74D4  tbz      w0, #0, #0x67d7ba8
0067D74D8  ldr      x1, [x28]
0067D74DC  ldrb     w8, [x1, #0x53]
0067D74E0  tbnz     w8, #5, #0x67d77c4
0067D74E4  ldr      x22, [x19, #0x38]
0067D74E8  b        #0x67d77d4 ; 
0067D74EC  ldr      x8, [x1, #0x60]
0067D74F0  mov      x0, x22
0067D74F4  blr      x8
0067D74F8  mov      x23, x0
0067D74FC  adrp     x26, #0x8ee2000
0067D7500  ldr      x26, [x26, #0xe68] ; GLOBAL Deterministic.Animation.DeterministicAnimationUtils_TypeInfo
0067D7504  ldr      x0, [x26]
0067D7508  ldr      w8, [x0, #0xe0]
0067D750C  cbnz     w8, #0x67d7514
0067D7510  bl       #0x382be8c ; 
0067D7514  mov      x0, x23
0067D7518  mov      x1, xzr
0067D751C  bl       #0x4185334 ; Deterministic.Animation.DeterministicAnimationUtils$$HasAnimator
0067D7520  and      w8, w0, #1
0067D7524  strb     w8, [x19, #0x88]
0067D7528  tbz      w0, #0, #0x67d755c
0067D752C  ldrb     w8, [x29, #0x392]
0067D7530  cbnz     w8, #0x67d7548
0067D7534  adrp     x0, #0x8f1e000
0067D7538  ldr      x0, [x0, #0x6e8] ; GLOBAL Method$LocalModels.Bean.Model_model.get_path()
0067D753C  bl       #0x382bd14 ; 
0067D7540  mov      w8, #1
0067D7544  strb     w8, [x29, #0x392]
0067D7548  ldr      x1, [x27]
0067D754C  ldrb     w8, [x1, #0x53]
0067D7550  tbnz     w8, #5, #0x67d7574
0067D7554  ldr      x23, [x22, #0x28]
0067D7558  b        #0x67d7584 ; 
0067D755C  adrp     x8, #0x8ec2000
0067D7560  ldr      x8, [x8, #0x420] ; GLOBAL string_TypeInfo
0067D7564  ldr      x8, [x8]
0067D7568  ldr      x8, [x8, #0xb8]
0067D756C  ldr      x23, [x8]
0067D7570  b        #0x67d75a4 ; 
0067D7574  ldr      x8, [x1, #0x60]
0067D7578  mov      x0, x22
0067D757C  blr      x8
0067D7580  mov      x23, x0
0067D7584  ldr      x0, [x26]
0067D7588  ldr      w8, [x0, #0xe0]
0067D758C  cbnz     w8, #0x67d7594
0067D7590  bl       #0x382be8c ; 
0067D7594  mov      x0, x23
0067D7598  mov      x1, xzr
0067D759C  bl       #0x4185034 ; Deterministic.Animation.DeterministicAnimationUtils$$GetDataPath
0067D75A0  mov      x23, x0
0067D75A4  mov      x0, x19
0067D75A8  bl       #0x67d8264 ; HotFix.BattleLogic.EntityCharacter$$ShouldLogWingPlaneAnimatorDebug
0067D75AC  ldrb     w8, [x19, #0x88]
0067D75B0  cbz      w8, #0x67d7ba8
0067D75B4  ldrb     w8, [x24, #0xa4b]
0067D75B8  cbnz     w8, #0x67d75d0
0067D75BC  adrp     x0, #0x8ee5000
0067D75C0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0067D75C4  bl       #0x382bd14 ; 
0067D75C8  mov      w8, #1
0067D75CC  strb     w8, [x24, #0xa4b]
0067D75D0  ldr      x1, [x25]
0067D75D4  ldrb     w8, [x1, #0x53]
0067D75D8  tbnz     w8, #5, #0x67d75e4
0067D75DC  ldr      x24, [x19, #0x20]
0067D75E0  b        #0x67d75f4 ; 
0067D75E4  ldr      x8, [x1, #0x60]
0067D75E8  mov      x0, x19
0067D75EC  blr      x8
0067D75F0  mov      x24, x0
0067D75F4  cbz      x24, #0x67d7cb8
0067D75F8  adrp     x25, #0x959b000
0067D75FC  ldrb     w8, [x25, #0x393]
0067D7600  cbnz     w8, #0x67d7618
0067D7604  adrp     x0, #0x8f1e000
0067D7608  ldr      x0, [x0, #0x6f0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Resource()
0067D760C  bl       #0x382bd14 ; 
0067D7610  mov      w8, #1
0067D7614  strb     w8, [x25, #0x393]
0067D7618  adrp     x8, #0x8f1e000
0067D761C  ldr      x8, [x8, #0x6f0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Resource()
0067D7620  ldr      x1, [x8]
0067D7624  ldrb     w8, [x1, #0x53]
0067D7628  tbnz     w8, #5, #0x67d7634
0067D762C  ldr      x24, [x24, #0x208]
0067D7630  b        #0x67d7644 ; 
0067D7634  ldr      x8, [x1, #0x60]
0067D7638  mov      x0, x24
0067D763C  blr      x8
0067D7640  mov      x24, x0
0067D7644  cbz      x24, #0x67d7cbc
0067D7648  adrp     x10, #0x8f1e000
0067D764C  ldr      x8, [x24]
0067D7650  ldr      x10, [x10, #0x6b0] ; GLOBAL HotFix.BattleLogic.IResourceBridge_TypeInfo
0067D7654  ldrh     w9, [x8, #0x12e]
0067D7658  ldr      x1, [x10]
0067D765C  cbz      x9, #0x67d7680
0067D7660  ldr      x10, [x8, #0xb0]
0067D7664  add      x10, x10, #8
0067D7668  ldur     x11, [x10, #-8]
0067D766C  cmp      x11, x1
0067D7670  b.eq     #0x67d7690
0067D7674  subs     x9, x9, #1
0067D7678  add      x10, x10, #0x10
0067D767C  b.ne     #0x67d7668
0067D7680  mov      w2, #1
0067D7684  mov      x0, x24
0067D7688  bl       #0x3a7e710 ; 
0067D768C  b        #0x67d76a0 ; 
0067D7690  ldr      w9, [x10]
0067D7694  add      w9, w9, #1
0067D7698  add      x8, x8, w9, sxtw #4
0067D769C  add      x0, x8, #0x138
0067D76A0  ldp      x8, x2, [x0]
0067D76A4  mov      x0, x24
0067D76A8  mov      x1, x23
0067D76AC  blr      x8
0067D76B0  mov      x25, x0
0067D76B4  mov      x0, x19
0067D76B8  bl       #0x67d8264 ; HotFix.BattleLogic.EntityCharacter$$ShouldLogWingPlaneAnimatorDebug
0067D76BC  cbz      x25, #0x67d7770
0067D76C0  ldr      x8, [x25, #0x18]
0067D76C4  cbz      x8, #0x67d7770
0067D76C8  adrp     x8, #0x8ec3000
0067D76CC  ldr      x8, [x8, #0x2d0] ; GLOBAL System.IO.MemoryStream_TypeInfo
0067D76D0  ldr      x0, [x8]
0067D76D4  bl       #0x382bfa0 ; 
0067D76D8  mov      x24, x0
0067D76DC  mov      x1, x25
0067D76E0  mov      x2, xzr
0067D76E4  bl       #0x7b0cadc ; System.IO.MemoryStream$$.ctor
0067D76E8  adrp     x8, #0x8ec5000
0067D76EC  ldr      x8, [x8, #0x880] ; GLOBAL System.IO.BinaryReader_TypeInfo
0067D76F0  ldr      x0, [x8]
0067D76F4  bl       #0x382bfa0 ; 
0067D76F8  mov      x27, x0
0067D76FC  mov      x1, x24
0067D7700  mov      x2, xzr
0067D7704  bl       #0x7b416e8 ; System.IO.BinaryReader$$.ctor
0067D7708  ldr      x0, [x20]
0067D770C  cbz      x0, #0x67d7cc0
0067D7710  mov      x1, x27
0067D7714  mov      x2, xzr
0067D7718  bl       #0x418672c ; Deterministic.Animation.DeterministicAnimator$$DeSerialize
0067D771C  mov      x25, xzr
0067D7720  mov      w26, #0xa
0067D7724  cbz      x27, #0x67d7b10
0067D7728  adrp     x10, #0x8ebf000
0067D772C  ldr      x8, [x27]
0067D7730  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0067D7734  ldrh     w9, [x8, #0x12e]
0067D7738  ldr      x1, [x10]
0067D773C  cbz      x9, #0x67d7760
0067D7740  ldr      x10, [x8, #0xb0]
0067D7744  add      x10, x10, #8
0067D7748  ldur     x11, [x10, #-8]
0067D774C  cmp      x11, x1
0067D7750  b.eq     #0x67d7af8
0067D7754  subs     x9, x9, #1
0067D7758  add      x10, x10, #0x10
0067D775C  b.ne     #0x67d7748
0067D7760  mov      x0, x27
0067D7764  mov      w2, wzr
0067D7768  bl       #0x3a7e710 ; 
0067D776C  b        #0x67d7b04 ; 
0067D7770  strb     wzr, [x19, #0x88]
0067D7774  mov      x0, x19
0067D7778  bl       #0x67d8264 ; HotFix.BattleLogic.EntityCharacter$$ShouldLogWingPlaneAnimatorDebug
0067D777C  tbz      w0, #0, #0x67d7ba8
0067D7780  adrp     x8, #0x8ec2000
0067D7784  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo
0067D7788  ldr      x0, [x8]
0067D778C  mov      w1, #5
0067D7790  bl       #0x382bdfc ; 
0067D7794  mov      x24, x0
0067D7798  cbz      x0, #0x67d7cd4
0067D779C  adrp     x25, #0x8f1e000
0067D77A0  ldr      x25, [x25, #0x6e0] ; GLOBAL [WingPlaneAnimatorDebug]
0067D77A4  ldr      x0, [x25]
0067D77A8  cbz      x0, #0x67d78c8
0067D77AC  ldr      x8, [x24]
0067D77B0  ldr      x1, [x8, #0x40]
0067D77B4  bl       #0x382be90 ; 
0067D77B8  cbz      x0, #0x67d7cf0
0067D77BC  ldr      x1, [x25]
0067D77C0  b        #0x67d78cc ; 
0067D77C4  ldr      x8, [x1, #0x60]
0067D77C8  mov      x0, x19
0067D77CC  blr      x8
0067D77D0  mov      x22, x0
0067D77D4  cbz      x22, #0x67d8028
0067D77D8  adrp     x23, #0x9593000
0067D77DC  ldrb     w8, [x23, #0x9b2]
0067D77E0  cbnz     w8, #0x67d77f8
0067D77E4  adrp     x0, #0x8ee9000
0067D77E8  ldr      x0, [x0, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D77EC  bl       #0x382bd14 ; 
0067D77F0  mov      w8, #1
0067D77F4  strb     w8, [x23, #0x9b2]
0067D77F8  adrp     x8, #0x8ee9000
0067D77FC  ldr      x8, [x8, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D7800  ldr      x1, [x8]
0067D7804  ldrb     w8, [x1, #0x53]
0067D7808  tbnz     w8, #5, #0x67d7814
0067D780C  ldr      w0, [x22, #0x168]
0067D7810  b        #0x67d7820 ; 
0067D7814  ldr      x8, [x1, #0x60]
0067D7818  mov      x0, x22
0067D781C  blr      x8
0067D7820  adrp     x23, #0x8ebf000
0067D7824  ldr      x23, [x23, #0xba0] ; GLOBAL int_TypeInfo
0067D7828  str      w0, [sp, #0xc]
0067D782C  add      x1, sp, #0xc
0067D7830  ldr      x8, [x23]
0067D7834  mov      x0, x8
0067D7838  bl       #0x382be94 ; 
0067D783C  mov      x22, x0
0067D7840  ldr      x0, [x23]
0067D7844  add      x1, sp, #8
0067D7848  str      w21, [sp, #8]
0067D784C  bl       #0x382be94 ; 
0067D7850  adrp     x8, #0x8f1e000
0067D7854  ldr      x8, [x8, #0x6d8] ; GLOBAL {0} Model_model row missing entityId={1}, modelId={2}
0067D7858  adrp     x9, #0x8f1e000
0067D785C  ldr      x9, [x9, #0x6e0] ; GLOBAL [WingPlaneAnimatorDebug]
0067D7860  mov      x3, x0
0067D7864  ldr      x8, [x8]
0067D7868  mov      x2, x22
0067D786C  ldr      x1, [x9]
0067D7870  mov      x4, xzr
0067D7874  mov      x0, x8
0067D7878  bl       #0x79e27d8 ; System.String$$Format
0067D787C  adrp     x8, #0x8ee1000
0067D7880  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0067D7884  mov      x21, x0
0067D7888  ldr      x8, [x8]
0067D788C  ldr      w9, [x8, #0xe0]
0067D7890  cbnz     w9, #0x67d789c
0067D7894  mov      x0, x8
0067D7898  bl       #0x382be8c ; 
0067D789C  adrp     x8, #0x8f1e000
0067D78A0  adrp     x9, #0x8f1e000
0067D78A4  ldr      x8, [x8, #0x6b8] ; GLOBAL InitAnimator
0067D78A8  ldr      x9, [x9, #0x6c8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityCharacter\EntityCharacter.cs
0067D78AC  mov      w3, #0x152
0067D78B0  mov      x0, x21
0067D78B4  ldr      x1, [x8]
0067D78B8  ldr      x2, [x9]
0067D78BC  mov      x4, xzr
0067D78C0  bl       #0x7997754 ; Logger$$LogError
0067D78C4  b        #0x67d7ba8 ; 
0067D78C8  mov      x1, xzr
0067D78CC  ldr      w8, [x24, #0x18]
0067D78D0  cbz      w8, #0x67d7cd8
0067D78D4  mov      x0, x24
0067D78D8  str      x1, [x0, #0x20]!
0067D78DC  bl       #0x382bcb8 ; 
0067D78E0  ldr      x1, [x28]
0067D78E4  ldrb     w8, [x1, #0x53]
0067D78E8  tbnz     w8, #5, #0x67d78f4
0067D78EC  ldr      x25, [x19, #0x38]
0067D78F0  b        #0x67d7904 ; 
0067D78F4  ldr      x8, [x1, #0x60]
0067D78F8  mov      x0, x19
0067D78FC  blr      x8
0067D7900  mov      x25, x0
0067D7904  cbz      x25, #0x67d7cdc
0067D7908  adrp     x26, #0x9593000
0067D790C  ldrb     w8, [x26, #0x9b2]
0067D7910  cbnz     w8, #0x67d7928
0067D7914  adrp     x0, #0x8ee9000
0067D7918  ldr      x0, [x0, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D791C  bl       #0x382bd14 ; 
0067D7920  mov      w8, #1
0067D7924  strb     w8, [x26, #0x9b2]
0067D7928  adrp     x8, #0x8ee9000
0067D792C  ldr      x8, [x8, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D7930  ldr      x1, [x8]
0067D7934  ldrb     w8, [x1, #0x53]
0067D7938  tbnz     w8, #5, #0x67d7944
0067D793C  ldr      w0, [x25, #0x168]
0067D7940  b        #0x67d7950 ; 
0067D7944  ldr      x8, [x1, #0x60]
0067D7948  mov      x0, x25
0067D794C  blr      x8
0067D7950  adrp     x26, #0x8ebf000
0067D7954  ldr      x26, [x26, #0xba0] ; GLOBAL int_TypeInfo
0067D7958  str      w0, [sp, #0xc]
0067D795C  ldr      x8, [x26]
0067D7960  add      x1, sp, #0xc
0067D7964  mov      x0, x8
0067D7968  bl       #0x382be94 ; 
0067D796C  mov      x25, x0
0067D7970  cbz      x0, #0x67d7988
0067D7974  ldr      x8, [x24]
0067D7978  ldr      x1, [x8, #0x40]
0067D797C  mov      x0, x25
0067D7980  bl       #0x382be90 ; 
0067D7984  cbz      x0, #0x67d7cfc
0067D7988  ldr      w8, [x24, #0x18]
0067D798C  cmp      w8, #1
0067D7990  b.ls     #0x67d7ce0
0067D7994  mov      x0, x24
0067D7998  str      x25, [x0, #0x28]!
0067D799C  mov      x1, x25
0067D79A0  bl       #0x382bcb8 ; 
0067D79A4  ldr      x0, [x26]
0067D79A8  str      w21, [sp, #8]
0067D79AC  add      x1, sp, #8
0067D79B0  bl       #0x382be94 ; 
0067D79B4  mov      x25, x0
0067D79B8  cbz      x0, #0x67d79d0
0067D79BC  ldr      x8, [x24]
0067D79C0  ldr      x1, [x8, #0x40]
0067D79C4  mov      x0, x25
0067D79C8  bl       #0x382be90 ; 
0067D79CC  cbz      x0, #0x67d7d08
0067D79D0  ldr      w8, [x24, #0x18]
0067D79D4  cmp      w8, #2
0067D79D8  b.ls     #0x67d7ce4
0067D79DC  mov      x0, x24
0067D79E0  str      x25, [x0, #0x30]!
0067D79E4  mov      x1, x25
0067D79E8  bl       #0x382bcb8 ; 
0067D79EC  ldrb     w8, [x29, #0x392]
0067D79F0  cbnz     w8, #0x67d7a08
0067D79F4  adrp     x0, #0x8f1e000
0067D79F8  ldr      x0, [x0, #0x6e8] ; GLOBAL Method$LocalModels.Bean.Model_model.get_path()
0067D79FC  bl       #0x382bd14 ; 
0067D7A00  mov      w8, #1
0067D7A04  strb     w8, [x29, #0x392]
0067D7A08  ldr      x1, [x27]
0067D7A0C  ldrb     w8, [x1, #0x53]
0067D7A10  tbnz     w8, #5, #0x67d7a20
0067D7A14  ldr      x25, [x22, #0x28]
0067D7A18  cbnz     x25, #0x67d7a34
0067D7A1C  b        #0x67d7a48 ; 
0067D7A20  ldr      x8, [x1, #0x60]
0067D7A24  mov      x0, x22
0067D7A28  blr      x8
0067D7A2C  mov      x25, x0
0067D7A30  cbz      x25, #0x67d7a48
0067D7A34  ldr      x8, [x24]
0067D7A38  ldr      x1, [x8, #0x40]
0067D7A3C  mov      x0, x25
0067D7A40  bl       #0x382be90 ; 
0067D7A44  cbz      x0, #0x67d7d14
0067D7A48  ldr      w8, [x24, #0x18]
0067D7A4C  cmp      w8, #3
0067D7A50  b.ls     #0x67d7ce8
0067D7A54  mov      x0, x24
0067D7A58  str      x25, [x0, #0x38]!
0067D7A5C  mov      x1, x25
0067D7A60  bl       #0x382bcb8 ; 
0067D7A64  cbz      x23, #0x67d7a7c
0067D7A68  ldr      x8, [x24]
0067D7A6C  ldr      x1, [x8, #0x40]
0067D7A70  mov      x0, x23
0067D7A74  bl       #0x382be90 ; 
0067D7A78  cbz      x0, #0x67d7d20
0067D7A7C  ldr      w8, [x24, #0x18]
0067D7A80  cmp      w8, #4
0067D7A84  b.ls     #0x67d7cec
0067D7A88  mov      x0, x24
0067D7A8C  str      x23, [x0, #0x40]!
0067D7A90  mov      x1, x23
0067D7A94  bl       #0x382bcb8 ; 
0067D7A98  adrp     x8, #0x8f1e000
0067D7A9C  ldr      x8, [x8, #0x6d0] ; GLOBAL {0} Baked animation bytes missing entityId={1}, modelId={2}, path={3}, dataPath={4}
0067D7AA0  ldr      x0, [x8]
0067D7AA4  mov      x1, x24
0067D7AA8  mov      x2, xzr
0067D7AAC  bl       #0x79e281c ; System.String$$Format
0067D7AB0  adrp     x8, #0x8ee1000
0067D7AB4  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0067D7AB8  mov      x24, x0
0067D7ABC  ldr      x0, [x8]
0067D7AC0  ldr      w8, [x0, #0xe0]
0067D7AC4  cbnz     w8, #0x67d7acc
0067D7AC8  bl       #0x382be8c ; 
0067D7ACC  adrp     x8, #0x8f1e000
0067D7AD0  ldr      x8, [x8, #0x6b8] ; GLOBAL InitAnimator
0067D7AD4  adrp     x9, #0x8f1e000
0067D7AD8  ldr      x9, [x9, #0x6c8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityCharacter\EntityCharacter.cs
0067D7ADC  ldr      x1, [x8]
0067D7AE0  ldr      x2, [x9]
0067D7AE4  mov      w3, #0x171
0067D7AE8  mov      x0, x24
0067D7AEC  mov      x4, xzr
0067D7AF0  bl       #0x7997754 ; Logger$$LogError
0067D7AF4  b        #0x67d7ba8 ; 
0067D7AF8  ldrsw    x9, [x10]
0067D7AFC  add      x8, x8, x9, lsl #4
0067D7B00  add      x0, x8, #0x138
0067D7B04  ldp      x8, x1, [x0]
0067D7B08  mov      x0, x27
0067D7B0C  blr      x8
0067D7B10  cbnz     x25, #0x67d7ccc
0067D7B14  cmp      w26, #0xa
0067D7B18  b.eq     #0x67d7b20
0067D7B1C  cbnz     w26, #0x67d7b30
0067D7B20  mov      x27, xzr
0067D7B24  mov      w26, #9
0067D7B28  cbnz     x24, #0x67d7b38
0067D7B2C  b        #0x67d7b98 ; 
0067D7B30  mov      x27, xzr
0067D7B34  cbz      x24, #0x67d7b98
0067D7B38  adrp     x10, #0x8ebf000
0067D7B3C  ldr      x8, [x24]
0067D7B40  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0067D7B44  ldrh     w9, [x8, #0x12e]
0067D7B48  ldr      x1, [x10]
0067D7B4C  cbz      x9, #0x67d7b70
0067D7B50  ldr      x10, [x8, #0xb0]
0067D7B54  add      x10, x10, #8
0067D7B58  ldur     x11, [x10, #-8]
0067D7B5C  cmp      x11, x1
0067D7B60  b.eq     #0x67d7b80
0067D7B64  subs     x9, x9, #1
0067D7B68  add      x10, x10, #0x10
0067D7B6C  b.ne     #0x67d7b58
0067D7B70  mov      x0, x24
0067D7B74  mov      w2, wzr
0067D7B78  bl       #0x3a7e710 ; 
0067D7B7C  b        #0x67d7b8c ; 
0067D7B80  ldrsw    x9, [x10]
0067D7B84  add      x8, x8, x9, lsl #4
0067D7B88  add      x0, x8, #0x138
0067D7B8C  ldp      x8, x1, [x0]
0067D7B90  mov      x0, x24
0067D7B94  blr      x8
0067D7B98  cbnz     x27, #0x67d7cc4
0067D7B9C  cbz      w26, #0x67d7ba8
0067D7BA0  cmp      w26, #9
0067D7BA4  b.ne     #0x67d7c98
0067D7BA8  ldr      x0, [x20]
0067D7BAC  cbz      x0, #0x67d8028
0067D7BB0  mov      x1, xzr
0067D7BB4  bl       #0x4185b4c ; Deterministic.Animation.DeterministicAnimator$$Init
0067D7BB8  ldr      x1, [x28]
0067D7BBC  ldr      x20, [x20]
0067D7BC0  ldrb     w8, [x1, #0x53]
0067D7BC4  tbnz     w8, #5, #0x67d7bd0
0067D7BC8  ldr      x21, [x19, #0x38]
0067D7BCC  b        #0x67d7be0 ; 
0067D7BD0  ldr      x8, [x1, #0x60]
0067D7BD4  mov      x0, x19
0067D7BD8  blr      x8
0067D7BDC  mov      x21, x0
0067D7BE0  cbz      x21, #0x67d8028
0067D7BE4  adrp     x22, #0x9593000
0067D7BE8  ldrb     w8, [x22, #0x9b2]
0067D7BEC  cbnz     w8, #0x67d7c04
0067D7BF0  adrp     x0, #0x8ee9000
0067D7BF4  ldr      x0, [x0, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D7BF8  bl       #0x382bd14 ; 
0067D7BFC  mov      w8, #1
0067D7C00  strb     w8, [x22, #0x9b2]
0067D7C04  adrp     x8, #0x8ee9000
0067D7C08  ldr      x8, [x8, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D7C0C  ldr      x1, [x8]
0067D7C10  ldrb     w8, [x1, #0x53]
0067D7C14  tbnz     w8, #5, #0x67d7c20
0067D7C18  ldr      w1, [x21, #0x168]
0067D7C1C  b        #0x67d7c30 ; 
0067D7C20  ldr      x8, [x1, #0x60]
0067D7C24  mov      x0, x21
0067D7C28  blr      x8
0067D7C2C  mov      w1, w0
0067D7C30  cbz      x20, #0x67d8028
0067D7C34  mov      x0, x20
0067D7C38  mov      x2, xzr
0067D7C3C  bl       #0x4186174 ; Deterministic.Animation.DeterministicAnimator$$SetEntityId
0067D7C40  mov      x0, x19
0067D7C44  bl       #0x67d8264 ; HotFix.BattleLogic.EntityCharacter$$ShouldLogWingPlaneAnimatorDebug
0067D7C48  tbz      w0, #0, #0x67d7c98
0067D7C4C  adrp     x8, #0x8f05000
0067D7C50  ldr      x8, [x8, #0x828] ; GLOBAL Idle
0067D7C54  mov      x0, x19
0067D7C58  ldr      x1, [x8]
0067D7C5C  bl       #0x67d8364 ; HotFix.BattleLogic.EntityCharacter$$LogAnimatorStateDebug
0067D7C60  adrp     x8, #0x8f1e000
0067D7C64  ldr      x8, [x8, #0x6c0] ; GLOBAL SkillEnter01
0067D7C68  mov      x0, x19
0067D7C6C  ldr      x1, [x8]
0067D7C70  bl       #0x67d8364 ; HotFix.BattleLogic.EntityCharacter$$LogAnimatorStateDebug
0067D7C74  adrp     x8, #0x8ee2000
0067D7C78  ldr      x8, [x8, #0xfa0] ; GLOBAL SkillExit01
0067D7C7C  mov      x0, x19
0067D7C80  ldr      x1, [x8]
0067D7C84  bl       #0x67d8364 ; HotFix.BattleLogic.EntityCharacter$$LogAnimatorStateDebug
0067D7C88  ldr      x0, [x19, #0x80]
0067D7C8C  cbz      x0, #0x67d8028
0067D7C90  mov      x1, xzr
0067D7C94  bl       #0x4185f3c ; Deterministic.Animation.DeterministicAnimator$$GetFirePosList
0067D7C98  ldp      x20, x19, [sp, #0x60]
0067D7C9C  ldp      x22, x21, [sp, #0x50]
0067D7CA0  ldp      x24, x23, [sp, #0x40]
0067D7CA4  ldp      x26, x25, [sp, #0x30]
0067D7CA8  ldp      x28, x27, [sp, #0x20]
0067D7CAC  ldp      x29, x30, [sp, #0x10]
0067D7CB0  add      sp, sp, #0x70
0067D7CB4  ret      
0067D7CB8  bl       #0x382bfb8 ; 
0067D7CBC  bl       #0x382bfb8 ; 
0067D7CC0  bl       #0x382bfb8 ; 
0067D7CC4  mov      x0, x27
0067D7CC8  bl       #0x382bfb0 ; 
0067D7CCC  mov      x0, x25
0067D7CD0  bl       #0x382bfb0 ; 
0067D7CD4  bl       #0x382bfb8 ; 
0067D7CD8  bl       #0x382bfc0 ; 
0067D7CDC  bl       #0x382bfb8 ; 
0067D7CE0  bl       #0x382bfc0 ; 
0067D7CE4  bl       #0x382bfc0 ; 
0067D7CE8  bl       #0x382bfc0 ; 
0067D7CEC  bl       #0x382bfc0 ; 
0067D7CF0  bl       #0x382bfdc ; 
0067D7CF4  mov      x1, xzr
0067D7CF8  bl       #0x382be7c ; 
0067D7CFC  bl       #0x382bfdc ; 
0067D7D00  mov      x1, xzr
0067D7D04  bl       #0x382be7c ; 
0067D7D08  bl       #0x382bfdc ; 
0067D7D0C  mov      x1, xzr
0067D7D10  bl       #0x382be7c ; 
0067D7D14  bl       #0x382bfdc ; 
0067D7D18  mov      x1, xzr
0067D7D1C  bl       #0x382be7c ; 
0067D7D20  bl       #0x382bfdc ; 
0067D7D24  mov      x1, xzr
0067D7D28  bl       #0x382be7c ; 
0067D7D2C  b        #0x67d7edc ; 
0067D7D30  b        #0x67d7edc ; 
0067D7D34  b        #0x67d7edc ; 
0067D7D38  b        #0x67d7edc ; 
0067D7D3C  b        #0x67d7edc ; 
0067D7D40  mov      x25, x1
0067D7D44  cmp      w25, #1
0067D7D48  mov      x26, x0
0067D7D4C  b.ne     #0x67d7d74
0067D7D50  mov      x0, x26
0067D7D54  bl       #0x89eda50 ; 
0067D7D58  ldr      x8, [x0]
0067D7D5C  str      x8, [sp]
0067D7D60  bl       #0x89eda60 ; 
0067D7D64  ldr      x25, [sp]
0067D7D68  mov      w26, wzr
0067D7D6C  cbnz     x27, #0x67d7728
0067D7D70  b        #0x67d7b10 ; 
0067D7D74  str      xzr, [sp]
0067D7D78  cbz      x27, #0x67d7ddc
0067D7D7C  adrp     x10, #0x8ebf000
0067D7D80  ldr      x8, [x27]
0067D7D84  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0067D7D88  ldrh     w9, [x8, #0x12e]
0067D7D8C  ldr      x1, [x10]
0067D7D90  cbz      x9, #0x67d7db4
0067D7D94  ldr      x10, [x8, #0xb0]
0067D7D98  add      x10, x10, #8
0067D7D9C  ldur     x11, [x10, #-8]
0067D7DA0  cmp      x11, x1
0067D7DA4  b.eq     #0x67d7dc4
0067D7DA8  subs     x9, x9, #1
0067D7DAC  add      x10, x10, #0x10
0067D7DB0  b.ne     #0x67d7d9c
0067D7DB4  mov      x0, x27
0067D7DB8  mov      w2, wzr
0067D7DBC  bl       #0x3a7e710 ; 
0067D7DC0  b        #0x67d7dd0 ; 
0067D7DC4  ldrsw    x9, [x10]
0067D7DC8  add      x8, x8, x9, lsl #4
0067D7DCC  add      x0, x8, #0x138
0067D7DD0  ldp      x8, x1, [x0]
0067D7DD4  mov      x0, x27
0067D7DD8  blr      x8
0067D7DDC  ldr      x8, [sp]
0067D7DE0  cbz      x8, #0x67d7e0c
0067D7DE4  ldr      x0, [sp]
0067D7DE8  bl       #0x382bfb0 ; 
0067D7DEC  mov      x25, x1
0067D7DF0  mov      x26, x0
0067D7DF4  cbnz     x27, #0x67d7d7c
0067D7DF8  b        #0x67d7ddc ; 
0067D7DFC  b        #0x67d7e04 ; 
0067D7E00  b        #0x67d7edc ; 
0067D7E04  mov      x25, x1
0067D7E08  mov      x26, x0
0067D7E0C  cmp      w25, #1
0067D7E10  b.ne     #0x67d7e30
0067D7E14  mov      x0, x26
0067D7E18  bl       #0x89eda50 ; 
0067D7E1C  ldr      x27, [x0]
0067D7E20  bl       #0x89eda60 ; 
0067D7E24  mov      w26, wzr
0067D7E28  cbnz     x24, #0x67d7b38
0067D7E2C  b        #0x67d7b98 ; 
0067D7E30  mov      x27, xzr
0067D7E34  cbz      x24, #0x67d7e98
0067D7E38  adrp     x10, #0x8ebf000
0067D7E3C  ldr      x8, [x24]
0067D7E40  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0067D7E44  ldrh     w9, [x8, #0x12e]
0067D7E48  ldr      x1, [x10]
0067D7E4C  cbz      x9, #0x67d7e70
0067D7E50  ldr      x10, [x8, #0xb0]
0067D7E54  add      x10, x10, #8
0067D7E58  ldur     x11, [x10, #-8]
0067D7E5C  cmp      x11, x1
0067D7E60  b.eq     #0x67d7e80
0067D7E64  subs     x9, x9, #1
0067D7E68  add      x10, x10, #0x10
0067D7E6C  b.ne     #0x67d7e58
0067D7E70  mov      x0, x24
0067D7E74  mov      w2, wzr
0067D7E78  bl       #0x3a7e710 ; 
0067D7E7C  b        #0x67d7e8c ; 
0067D7E80  ldrsw    x9, [x10]
0067D7E84  add      x8, x8, x9, lsl #4
0067D7E88  add      x0, x8, #0x138
0067D7E8C  ldp      x8, x1, [x0]
0067D7E90  mov      x0, x24
0067D7E94  blr      x8
0067D7E98  cbz      x27, #0x67d7ee4
0067D7E9C  mov      x0, x27
0067D7EA0  bl       #0x382bfb0 ; 
0067D7EA4  mov      x25, x1
0067D7EA8  mov      x26, x0
0067D7EAC  cbnz     x24, #0x67d7e38
0067D7EB0  b        #0x67d7e98 ; 
0067D7EB4  b        #0x67d7edc ; 
0067D7EB8  b        #0x67d7edc ; 
0067D7EBC  b        #0x67d7edc ; 
0067D7EC0  b        #0x67d7edc ; 
0067D7EC4  b        #0x67d7edc ; 
0067D7EC8  b        #0x67d7edc ; 
0067D7ECC  b        #0x67d7edc ; 
0067D7ED0  b        #0x67d7edc ; 
0067D7ED4  b        #0x67d7edc ; 
0067D7ED8  b        #0x67d7edc ; 
0067D7EDC  mov      x25, x1
0067D7EE0  mov      x26, x0
0067D7EE4  cmp      w25, #1
0067D7EE8  b.ne     #0x67d8258
0067D7EEC  mov      x0, x26
0067D7EF0  bl       #0x89eda50 ; 
0067D7EF4  mov      x24, x0
0067D7EF8  adrp     x0, #0x8ebf000
0067D7EFC  ldr      x0, [x0, #0xc70] ; GLOBAL System.Exception_TypeInfo
0067D7F00  bl       #0x382bd28 ; 
0067D7F04  ldr      x8, [x24]
0067D7F08  ldr      x1, [x8]
0067D7F0C  bl       #0x382c3e4 ; 
0067D7F10  tbz      w0, #0, #0x67d8230
0067D7F14  ldr      x24, [x24]
0067D7F18  bl       #0x89eda60 ; 
0067D7F1C  strb     wzr, [x19, #0x88]
0067D7F20  adrp     x0, #0x8f1e000
0067D7F24  ldr      x0, [x0, #0x6a8] ; GLOBAL Deterministic.Animation.DeterministicAnimator_TypeInfo
0067D7F28  bl       #0x382bd28 ; 
0067D7F2C  bl       #0x382bfa0 ; 
0067D7F30  mov      x1, xzr
0067D7F34  mov      x25, x0
0067D7F38  bl       #0x4186880 ; Deterministic.Animation.DeterministicAnimator$$.ctor
0067D7F3C  mov      x0, x20
0067D7F40  mov      x1, x25
0067D7F44  str      x25, [x19, #0x80]
0067D7F48  bl       #0x382bcb8 ; 
0067D7F4C  mov      x0, x19
0067D7F50  bl       #0x67d8264 ; HotFix.BattleLogic.EntityCharacter$$ShouldLogWingPlaneAnimatorDebug
0067D7F54  tbz      w0, #0, #0x67d7ba8
0067D7F58  adrp     x0, #0x8ec2000
0067D7F5C  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo
0067D7F60  bl       #0x382bd28 ; 
0067D7F64  mov      w1, #6
0067D7F68  bl       #0x382bdfc ; 
0067D7F6C  cbz      x0, #0x67d8028
0067D7F70  mov      x25, x0
0067D7F74  adrp     x0, #0x8f1e000
0067D7F78  ldr      x0, [x0, #0x6e0] ; GLOBAL [WingPlaneAnimatorDebug]
0067D7F7C  bl       #0x382bd28 ; 
0067D7F80  cbz      x0, #0x67d7f94
0067D7F84  ldr      x8, [x25]
0067D7F88  ldr      x1, [x8, #0x40]
0067D7F8C  bl       #0x382be90 ; 
0067D7F90  cbz      x0, #0x67d8224
0067D7F94  adrp     x0, #0x8f1e000
0067D7F98  ldr      x0, [x0, #0x6e0] ; GLOBAL [WingPlaneAnimatorDebug]
0067D7F9C  bl       #0x382bd28 ; 
0067D7FA0  ldr      w8, [x25, #0x18]
0067D7FA4  cbz      w8, #0x67d8220
0067D7FA8  mov      x1, x0
0067D7FAC  mov      x0, x25
0067D7FB0  str      x1, [x0, #0x20]!
0067D7FB4  bl       #0x382bcb8 ; 
0067D7FB8  adrp     x0, #0x8ee6000
0067D7FBC  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0067D7FC0  bl       #0x382bd28 ; 
0067D7FC4  ldrb     w8, [x0, #0x53]
0067D7FC8  tbnz     w8, #5, #0x67d7fd4
0067D7FCC  ldr      x27, [x19, #0x38]
0067D7FD0  b        #0x67d7fe8 ; 
0067D7FD4  ldr      x8, [x0, #0x60]
0067D7FD8  mov      x1, x0
0067D7FDC  mov      x0, x19
0067D7FE0  blr      x8
0067D7FE4  mov      x27, x0
0067D7FE8  cbz      x27, #0x67d8028
0067D7FEC  adrp     x26, #0x9593000
0067D7FF0  ldrb     w8, [x26, #0x9b2]
0067D7FF4  cbnz     w8, #0x67d800c
0067D7FF8  adrp     x0, #0x8ee9000
0067D7FFC  ldr      x0, [x0, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D8000  bl       #0x382bd14 ; 
0067D8004  mov      w8, #1
0067D8008  strb     w8, [x26, #0x9b2]
0067D800C  adrp     x8, #0x8ee9000
0067D8010  ldr      x8, [x8, #0xc58] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityId()
0067D8014  ldr      x1, [x8]
0067D8018  ldrb     w8, [x1, #0x53]
0067D801C  tbnz     w8, #5, #0x67d802c
0067D8020  ldr      w0, [x27, #0x168]
0067D8024  b        #0x67d8038 ; 
0067D8028  bl       #0x382bfb8 ; 
0067D802C  ldr      x8, [x1, #0x60]
0067D8030  mov      x0, x27
0067D8034  blr      x8
0067D8038  str      w0, [sp, #0xc]
0067D803C  adrp     x0, #0x8ebf000
0067D8040  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo
0067D8044  bl       #0x382bd28 ; 
0067D8048  add      x1, sp, #0xc
0067D804C  bl       #0x382be94 ; 
0067D8050  mov      x27, x0
0067D8054  cbz      x0, #0x67d806c
0067D8058  ldr      x8, [x25]
0067D805C  mov      x0, x27
0067D8060  ldr      x1, [x8, #0x40]
0067D8064  bl       #0x382be90 ; 
0067D8068  cbz      x0, #0x67d8224
0067D806C  ldr      w8, [x25, #0x18]
0067D8070  cmp      w8, #1
0067D8074  b.ls     #0x67d8220
0067D8078  mov      x0, x25
0067D807C  str      x27, [x0, #0x28]!
0067D8080  mov      x1, x27
0067D8084  bl       #0x382bcb8 ; 
0067D8088  str      w21, [sp, #8]
0067D808C  adrp     x0, #0x8ebf000
0067D8090  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo
0067D8094  bl       #0x382bd28 ; 
0067D8098  add      x1, sp, #8
0067D809C  bl       #0x382be94 ; 
0067D80A0  mov      x21, x0
0067D80A4  cbz      x0, #0x67d80bc
0067D80A8  ldr      x8, [x25]
0067D80AC  mov      x0, x21
0067D80B0  ldr      x1, [x8, #0x40]
0067D80B4  bl       #0x382be90 ; 
0067D80B8  cbz      x0, #0x67d8224
0067D80BC  ldr      w8, [x25, #0x18]
0067D80C0  cmp      w8, #2
0067D80C4  b.ls     #0x67d8220
0067D80C8  mov      x0, x25
0067D80CC  str      x21, [x0, #0x30]!
0067D80D0  mov      x1, x21
0067D80D4  bl       #0x382bcb8 ; 
0067D80D8  ldrb     w8, [x29, #0x392]
0067D80DC  cbnz     w8, #0x67d80f4
0067D80E0  adrp     x0, #0x8f1e000
0067D80E4  ldr      x0, [x0, #0x6e8] ; GLOBAL Method$LocalModels.Bean.Model_model.get_path()
0067D80E8  bl       #0x382bd14 ; 
0067D80EC  mov      w8, #1
0067D80F0  strb     w8, [x29, #0x392]
0067D80F4  adrp     x8, #0x8f1e000
0067D80F8  ldr      x8, [x8, #0x6e8] ; GLOBAL Method$LocalModels.Bean.Model_model.get_path()
0067D80FC  ldr      x1, [x8]
0067D8100  ldrb     w8, [x1, #0x53]
0067D8104  tbnz     w8, #5, #0x67d8110
0067D8108  ldr      x21, [x22, #0x28]
0067D810C  b        #0x67d8120 ; 
0067D8110  ldr      x8, [x1, #0x60]
0067D8114  mov      x0, x22
0067D8118  blr      x8
0067D811C  mov      x21, x0
0067D8120  cbz      x21, #0x67d8138
0067D8124  ldr      x8, [x25]
0067D8128  mov      x0, x21
0067D812C  ldr      x1, [x8, #0x40]
0067D8130  bl       #0x382be90 ; 
0067D8134  cbz      x0, #0x67d8224
0067D8138  ldr      w8, [x25, #0x18]
0067D813C  cmp      w8, #3
0067D8140  b.ls     #0x67d8220
0067D8144  mov      x0, x25
0067D8148  str      x21, [x0, #0x38]!
0067D814C  mov      x1, x21
0067D8150  bl       #0x382bcb8 ; 
0067D8154  cbz      x23, #0x67d816c
0067D8158  ldr      x8, [x25]
0067D815C  mov      x0, x23
0067D8160  ldr      x1, [x8, #0x40]
0067D8164  bl       #0x382be90 ; 
0067D8168  cbz      x0, #0x67d8224
0067D816C  ldr      w8, [x25, #0x18]
0067D8170  cmp      w8, #4
0067D8174  b.ls     #0x67d8220
0067D8178  mov      x0, x25
0067D817C  str      x23, [x0, #0x40]!
0067D8180  mov      x1, x23
0067D8184  bl       #0x382bcb8 ; 
0067D8188  cbz      x24, #0x67d81a0
0067D818C  ldr      x8, [x25]
0067D8190  mov      x0, x24
0067D8194  ldr      x1, [x8, #0x40]
0067D8198  bl       #0x382be90 ; 
0067D819C  cbz      x0, #0x67d8224
0067D81A0  ldr      w8, [x25, #0x18]
0067D81A4  cmp      w8, #5
0067D81A8  b.ls     #0x67d8220
0067D81AC  mov      x0, x25
0067D81B0  str      x24, [x0, #0x48]!
0067D81B4  mov      x1, x24
0067D81B8  bl       #0x382bcb8 ; 
0067D81BC  adrp     x0, #0x8f1e000
0067D81C0  ldr      x0, [x0, #0x6f8] ; GLOBAL {0} Baked animation deserialize failed entityId={1}, modelId={2}, path={3}, dataPath={4}, exception={5}
0067D81C4  bl       #0x382bd28 ; 
0067D81C8  mov      x1, x25
0067D81CC  mov      x2, xzr
0067D81D0  bl       #0x79e281c ; System.String$$Format
0067D81D4  mov      x21, x0
0067D81D8  adrp     x0, #0x8ee1000
0067D81DC  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
0067D81E0  bl       #0x382bd28 ; 
0067D81E4  ldr      w8, [x0, #0xe0]
0067D81E8  cbnz     w8, #0x67d81f0
0067D81EC  bl       #0x382be8c ; 
0067D81F0  adrp     x0, #0x8f1e000
0067D81F4  ldr      x0, [x0, #0x6b8] ; GLOBAL InitAnimator
0067D81F8  bl       #0x382bd28 ; 
0067D81FC  mov      x22, x0
0067D8200  adrp     x0, #0x8f1e000
0067D8204  ldr      x0, [x0, #0x6c8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityCharacter\EntityCharacter.cs
0067D8208  bl       #0x382bd28 ; 
0067D820C  mov      x2, x0
0067D8210  mov      w3, #0x181
0067D8214  mov      x0, x21
0067D8218  mov      x1, x22
0067D821C  b        #0x67d78bc ; 
0067D8220  bl       #0x382bfc0 ; 
0067D8224  bl       #0x382bfdc ; 
0067D8228  mov      x1, xzr
0067D822C  bl       #0x382be7c ; 
0067D8230  mov      w0, #8
0067D8234  bl       #0x89eda70 ; 
0067D8238  ldr      x8, [x24]
0067D823C  str      x8, [x0]
0067D8240  adrp     x1, #0x89f3000
0067D8244  add      x1, x1, #0xf98
0067D8248  mov      x2, xzr
0067D824C  bl       #0x89eda80 ; 
0067D8250  mov      x26, x0
0067D8254  bl       #0x89eda60 ; 
0067D8258  mov      x0, x26
0067D825C  bl       #0x3b56bfc ; 
0067D8260  bl       #0x3442448 ; 

