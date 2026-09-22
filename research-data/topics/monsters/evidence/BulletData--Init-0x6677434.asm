; HotFix.BattleLogic.BulletData$$Init
; RVA 0x6677434; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006677434  sub      sp, sp, #0x70
006677438  stp      x30, x23, [sp, #0x40]
00667743C  stp      x22, x21, [sp, #0x50]
006677440  stp      x20, x19, [sp, #0x60]
006677444  mrs      x21, tpidr_el0
006677448  ldr      x8, [x21, #0x28]
00667744C  adrp     x22, #0x9599000
006677450  adrp     x23, #0x8f0f000
006677454  mov      x20, x1
006677458  str      x8, [sp, #0x38]
00667745C  ldrb     w8, [x22, #0xe9f]
006677460  ldr      x23, [x23, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.Init()
006677464  mov      x19, x0
006677468  tbnz     w8, #0, #0x6677498
00667746C  adrp     x0, #0x8f0f000
006677470  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.Init()
006677474  bl       #0x382bd14 ; 
006677478  adrp     x0, #0x8ee9000
00667747C  ldr      x0, [x0, #0x970] ; GLOBAL Method$System.Collections.Generic.HashSet<EntityRef>.Clear()
006677480  bl       #0x382bd14 ; 
006677484  adrp     x0, #0x8ee8000
006677488  ldr      x0, [x0, #0x7c8] ; GLOBAL Method$System.Collections.Generic.List<EntityRef>.Clear()
00667748C  bl       #0x382bd14 ; 
006677490  mov      w8, #1
006677494  strb     w8, [x22, #0xe9f]
006677498  ldr      x2, [x23]
00667749C  ldrb     w8, [x2, #0x53]
0066774A0  tbnz     w8, #5, #0x66774f4
0066774A4  mov      x0, x19
0066774A8  mov      x1, x20
0066774AC  mov      x2, xzr
0066774B0  mov      x3, xzr
0066774B4  bl       #0x6678234 ; HotFix.BattleLogic.BulletData$$SetScaleShape
0066774B8  adrp     x20, #0x9592000
0066774BC  ldrb     w8, [x20, #0x474]
0066774C0  cbnz     w8, #0x66774d8
0066774C4  adrp     x0, #0x8ee8000
0066774C8  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
0066774CC  bl       #0x382bd14 ; 
0066774D0  mov      w8, #1
0066774D4  strb     w8, [x20, #0x474]
0066774D8  adrp     x8, #0x8ee8000
0066774DC  ldr      x8, [x8, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ScaleAllPercent()
0066774E0  ldr      x1, [x8]
0066774E4  ldrb     w8, [x1, #0x53]
0066774E8  tbnz     w8, #5, #0x6677504
0066774EC  ldr      x20, [x19, #0x148]
0066774F0  b        #0x6677514 ; 
0066774F4  ldr      x8, [x2, #0x60]
0066774F8  mov      x0, x19
0066774FC  mov      x1, x20
006677500  b        #0x6678204 ; 
006677504  ldr      x8, [x1, #0x60]
006677508  mov      x0, x19
00667750C  blr      x8
006677510  mov      x20, x0
006677514  adrp     x22, #0x9599000
006677518  ldrb     w8, [x22, #0xed8]
00667751C  cbnz     w8, #0x6677534
006677520  adrp     x0, #0x8f0f000
006677524  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_OriginScalePercent()
006677528  bl       #0x382bd14 ; 
00667752C  mov      w8, #1
006677530  strb     w8, [x22, #0xed8]
006677534  adrp     x8, #0x8f0f000
006677538  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_OriginScalePercent()
00667753C  ldr      x2, [x8]
006677540  ldrb     w8, [x2, #0x53]
006677544  tbnz     w8, #5, #0x6677550
006677548  str      x20, [x19, #0x408]
00667754C  b        #0x6677560 ; 
006677550  ldr      x8, [x2, #0x60]
006677554  mov      x0, x19
006677558  mov      x1, x20
00667755C  blr      x8
006677560  adrp     x20, #0x9599000
006677564  ldrb     w8, [x20, #0xed9]
006677568  cbnz     w8, #0x6677580
00667756C  adrp     x0, #0x8f0f000
006677570  ldr      x0, [x0, #0x960] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsWingMagic()
006677574  bl       #0x382bd14 ; 
006677578  mov      w8, #1
00667757C  strb     w8, [x20, #0xed9]
006677580  adrp     x8, #0x8f0f000
006677584  ldr      x8, [x8, #0x960] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsWingMagic()
006677588  ldr      x2, [x8]
00667758C  ldrb     w8, [x2, #0x53]
006677590  tbnz     w8, #5, #0x667759c
006677594  strb     wzr, [x19, #0x108]
006677598  b        #0x66775ac ; 
00667759C  ldr      x8, [x2, #0x60]
0066775A0  mov      x0, x19
0066775A4  mov      w1, wzr
0066775A8  blr      x8
0066775AC  adrp     x20, #0x9599000
0066775B0  ldrb     w8, [x20, #0xeda]
0066775B4  cbnz     w8, #0x66775cc
0066775B8  adrp     x0, #0x8f0f000
0066775BC  ldr      x0, [x0, #0x7f0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ReboundCount()
0066775C0  bl       #0x382bd14 ; 
0066775C4  mov      w8, #1
0066775C8  strb     w8, [x20, #0xeda]
0066775CC  adrp     x8, #0x8f0f000
0066775D0  ldr      x8, [x8, #0x7f0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ReboundCount()
0066775D4  ldr      x2, [x8]
0066775D8  ldrb     w8, [x2, #0x53]
0066775DC  tbnz     w8, #5, #0x66775e8
0066775E0  str      wzr, [x19, #0x78]
0066775E4  b        #0x66775f8 ; 
0066775E8  ldr      x8, [x2, #0x60]
0066775EC  mov      x0, x19
0066775F0  mov      w1, wzr
0066775F4  blr      x8
0066775F8  adrp     x20, #0x9594000
0066775FC  ldrb     w8, [x20, #0x279]
006677600  cbnz     w8, #0x6677618
006677604  adrp     x0, #0x8ee9000
006677608  ldr      x0, [x0, #0xf78] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ThroughCount()
00667760C  bl       #0x382bd14 ; 
006677610  mov      w8, #1
006677614  strb     w8, [x20, #0x279]
006677618  adrp     x8, #0x8ee9000
00667761C  ldr      x8, [x8, #0xf78] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ThroughCount()
006677620  ldr      x2, [x8]
006677624  ldrb     w8, [x2, #0x53]
006677628  tbnz     w8, #5, #0x6677634
00667762C  str      wzr, [x19, #0x80]
006677630  b        #0x6677644 ; 
006677634  ldr      x8, [x2, #0x60]
006677638  mov      x0, x19
00667763C  mov      w1, wzr
006677640  blr      x8
006677644  adrp     x20, #0x9599000
006677648  ldrb     w8, [x20, #0xedb]
00667764C  cbnz     w8, #0x6677664
006677650  adrp     x0, #0x8f0f000
006677654  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_AllOriginThroughCount()
006677658  bl       #0x382bd14 ; 
00667765C  mov      w8, #1
006677660  strb     w8, [x20, #0xedb]
006677664  adrp     x8, #0x8f0f000
006677668  ldr      x8, [x8, #0x810] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_AllOriginThroughCount()
00667766C  ldr      x2, [x8]
006677670  ldrb     w8, [x2, #0x53]
006677674  tbnz     w8, #5, #0x6677680
006677678  str      wzr, [x19, #0x84]
00667767C  b        #0x6677690 ; 
006677680  ldr      x8, [x2, #0x60]
006677684  mov      x0, x19
006677688  mov      w1, wzr
00667768C  blr      x8
006677690  adrp     x20, #0x9592000
006677694  ldrb     w8, [x20, #0x476]
006677698  cbnz     w8, #0x66776b0
00667769C  adrp     x0, #0x8ee8000
0066776A0  ldr      x0, [x0, #0x8d8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCurrentlyEjecting()
0066776A4  bl       #0x382bd14 ; 
0066776A8  mov      w8, #1
0066776AC  strb     w8, [x20, #0x476]
0066776B0  adrp     x8, #0x8ee8000
0066776B4  ldr      x8, [x8, #0x8d8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCurrentlyEjecting()
0066776B8  ldr      x2, [x8]
0066776BC  ldrb     w8, [x2, #0x53]
0066776C0  tbnz     w8, #5, #0x66776cc
0066776C4  strb     wzr, [x19, #0x94]
0066776C8  b        #0x66776dc ; 
0066776CC  ldr      x8, [x2, #0x60]
0066776D0  mov      x0, x19
0066776D4  mov      w1, wzr
0066776D8  blr      x8
0066776DC  adrp     x20, #0x9592000
0066776E0  ldrb     w8, [x20, #0x477]
0066776E4  cbnz     w8, #0x66776fc
0066776E8  adrp     x0, #0x8ee8000
0066776EC  ldr      x0, [x0, #0x8e0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCurrentlyThroughing()
0066776F0  bl       #0x382bd14 ; 
0066776F4  mov      w8, #1
0066776F8  strb     w8, [x20, #0x477]
0066776FC  adrp     x8, #0x8ee8000
006677700  ldr      x8, [x8, #0x8e0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCurrentlyThroughing()
006677704  ldr      x2, [x8]
006677708  ldrb     w8, [x2, #0x53]
00667770C  tbnz     w8, #5, #0x6677718
006677710  strb     wzr, [x19, #0x95]
006677714  b        #0x6677728 ; 
006677718  ldr      x8, [x2, #0x60]
00667771C  mov      x0, x19
006677720  mov      w1, wzr
006677724  blr      x8
006677728  adrp     x20, #0x9599000
00667772C  ldrb     w8, [x20, #0xedc]
006677730  cbnz     w8, #0x6677748
006677734  adrp     x0, #0x8f0f000
006677738  ldr      x0, [x0, #0x850] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCurrentlyRebounding()
00667773C  bl       #0x382bd14 ; 
006677740  mov      w8, #1
006677744  strb     w8, [x20, #0xedc]
006677748  adrp     x8, #0x8f0f000
00667774C  ldr      x8, [x8, #0x850] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCurrentlyRebounding()
006677750  ldr      x2, [x8]
006677754  ldrb     w8, [x2, #0x53]
006677758  tbnz     w8, #5, #0x6677764
00667775C  strb     wzr, [x19, #0x96]
006677760  b        #0x6677774 ; 
006677764  ldr      x8, [x2, #0x60]
006677768  mov      x0, x19
00667776C  mov      w1, wzr
006677770  blr      x8
006677774  adrp     x20, #0x9599000
006677778  ldrb     w8, [x20, #0xedd]
00667777C  cbnz     w8, #0x6677794
006677780  adrp     x0, #0x8f0f000
006677784  ldr      x0, [x0, #0x880] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectCountCumulated()
006677788  bl       #0x382bd14 ; 
00667778C  mov      w8, #1
006677790  strb     w8, [x20, #0xedd]
006677794  adrp     x8, #0x8f0f000
006677798  ldr      x8, [x8, #0x880] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectCountCumulated()
00667779C  ldr      x2, [x8]
0066777A0  ldrb     w8, [x2, #0x53]
0066777A4  tbnz     w8, #5, #0x66777b0
0066777A8  str      wzr, [x19, #0x9c]
0066777AC  b        #0x66777c0 ; 
0066777B0  ldr      x8, [x2, #0x60]
0066777B4  mov      x0, x19
0066777B8  mov      w1, wzr
0066777BC  blr      x8
0066777C0  adrp     x20, #0x9594000
0066777C4  ldrb     w8, [x20, #0x27d]
0066777C8  cbnz     w8, #0x66777e0
0066777CC  adrp     x0, #0x8ee9000
0066777D0  ldr      x0, [x0, #0xfc0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ThroughCountCumulated()
0066777D4  bl       #0x382bd14 ; 
0066777D8  mov      w8, #1
0066777DC  strb     w8, [x20, #0x27d]
0066777E0  adrp     x8, #0x8ee9000
0066777E4  ldr      x8, [x8, #0xfc0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ThroughCountCumulated()
0066777E8  ldr      x2, [x8]
0066777EC  ldrb     w8, [x2, #0x53]
0066777F0  tbnz     w8, #5, #0x66777fc
0066777F4  str      wzr, [x19, #0xa0]
0066777F8  b        #0x667780c ; 
0066777FC  ldr      x8, [x2, #0x60]
006677800  mov      x0, x19
006677804  mov      w1, wzr
006677808  blr      x8
00667780C  adrp     x20, #0x9599000
006677810  ldrb     w8, [x20, #0xede]
006677814  cbnz     w8, #0x667782c
006677818  adrp     x0, #0x8f0f000
00667781C  ldr      x0, [x0, #0x890] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ReboundCountCumulated()
006677820  bl       #0x382bd14 ; 
006677824  mov      w8, #1
006677828  strb     w8, [x20, #0xede]
00667782C  adrp     x8, #0x8f0f000
006677830  ldr      x8, [x8, #0x890] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ReboundCountCumulated()
006677834  ldr      x2, [x8]
006677838  ldrb     w8, [x2, #0x53]
00667783C  tbnz     w8, #5, #0x6677848
006677840  str      wzr, [x19, #0xa4]
006677844  b        #0x6677858 ; 
006677848  ldr      x8, [x2, #0x60]
00667784C  mov      x0, x19
006677850  mov      w1, wzr
006677854  blr      x8
006677858  adrp     x20, #0x9599000
00667785C  ldrb     w8, [x20, #0xedf]
006677860  cbnz     w8, #0x6677878
006677864  adrp     x0, #0x8f0f000
006677868  ldr      x0, [x0, #0x898] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_FollowTarget()
00667786C  bl       #0x382bd14 ; 
006677870  mov      w8, #1
006677874  strb     w8, [x20, #0xedf]
006677878  adrp     x8, #0x8f0f000
00667787C  ldr      x8, [x8, #0x898] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_FollowTarget()
006677880  ldr      x2, [x8]
006677884  ldrb     w8, [x2, #0x53]
006677888  tbnz     w8, #5, #0x6677894
00667788C  strb     wzr, [x19, #0xa8]
006677890  b        #0x66778a4 ; 
006677894  ldr      x8, [x2, #0x60]
006677898  mov      x0, x19
00667789C  mov      w1, wzr
0066778A0  blr      x8
0066778A4  adrp     x20, #0x9599000
0066778A8  ldrb     w8, [x20, #0xee0]
0066778AC  cbnz     w8, #0x66778c4
0066778B0  adrp     x0, #0x8f0f000
0066778B4  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_LaserLockTarget()
0066778B8  bl       #0x382bd14 ; 
0066778BC  mov      w8, #1
0066778C0  strb     w8, [x20, #0xee0]
0066778C4  adrp     x8, #0x8f0f000
0066778C8  ldr      x8, [x8, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_LaserLockTarget()
0066778CC  ldr      x2, [x8]
0066778D0  ldrb     w8, [x2, #0x53]
0066778D4  tbnz     w8, #5, #0x66778e0
0066778D8  strb     wzr, [x19, #0xa9]
0066778DC  b        #0x66778f0 ; 
0066778E0  ldr      x8, [x2, #0x60]
0066778E4  mov      x0, x19
0066778E8  mov      w1, wzr
0066778EC  blr      x8
0066778F0  adrp     x20, #0x9599000
0066778F4  ldrb     w8, [x20, #0xee1]
0066778F8  cbnz     w8, #0x6677910
0066778FC  adrp     x0, #0x8f0f000
006677900  ldr      x0, [x0, #0x8b0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableExplosion()
006677904  bl       #0x382bd14 ; 
006677908  mov      w8, #1
00667790C  strb     w8, [x20, #0xee1]
006677910  adrp     x8, #0x8f0f000
006677914  ldr      x8, [x8, #0x8b0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableExplosion()
006677918  ldr      x2, [x8]
00667791C  ldrb     w8, [x2, #0x53]
006677920  tbnz     w8, #5, #0x667792c
006677924  strb     wzr, [x19, #0xaa]
006677928  b        #0x667793c ; 
00667792C  ldr      x8, [x2, #0x60]
006677930  mov      x0, x19
006677934  mov      w1, wzr
006677938  blr      x8
00667793C  adrp     x20, #0x9599000
006677940  ldrb     w8, [x20, #0xee2]
006677944  cbnz     w8, #0x667795c
006677948  adrp     x0, #0x8f0f000
00667794C  ldr      x0, [x0, #0x8b8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableEject()
006677950  bl       #0x382bd14 ; 
006677954  mov      w8, #1
006677958  strb     w8, [x20, #0xee2]
00667795C  adrp     x8, #0x8f0f000
006677960  ldr      x8, [x8, #0x8b8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableEject()
006677964  ldr      x2, [x8]
006677968  ldrb     w8, [x2, #0x53]
00667796C  tbnz     w8, #5, #0x6677978
006677970  strb     wzr, [x19, #0xab]
006677974  b        #0x6677988 ; 
006677978  ldr      x8, [x2, #0x60]
00667797C  mov      x0, x19
006677980  mov      w1, wzr
006677984  blr      x8
006677988  adrp     x20, #0x9599000
00667798C  ldrb     w8, [x20, #0xee3]
006677990  cbnz     w8, #0x66779a8
006677994  adrp     x0, #0x8f0f000
006677998  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableFollowTarget()
00667799C  bl       #0x382bd14 ; 
0066779A0  mov      w8, #1
0066779A4  strb     w8, [x20, #0xee3]
0066779A8  adrp     x8, #0x8f0f000
0066779AC  ldr      x8, [x8, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableFollowTarget()
0066779B0  ldr      x2, [x8]
0066779B4  ldrb     w8, [x2, #0x53]
0066779B8  tbnz     w8, #5, #0x66779c4
0066779BC  strb     wzr, [x19, #0xac]
0066779C0  b        #0x66779d4 ; 
0066779C4  ldr      x8, [x2, #0x60]
0066779C8  mov      x0, x19
0066779CC  mov      w1, wzr
0066779D0  blr      x8
0066779D4  adrp     x20, #0x9599000
0066779D8  ldrb     w8, [x20, #0xee4]
0066779DC  cbnz     w8, #0x66779f4
0066779E0  adrp     x0, #0x8f0f000
0066779E4  ldr      x0, [x0, #0x8c8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableRebound()
0066779E8  bl       #0x382bd14 ; 
0066779EC  mov      w8, #1
0066779F0  strb     w8, [x20, #0xee4]
0066779F4  adrp     x8, #0x8f0f000
0066779F8  ldr      x8, [x8, #0x8c8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableRebound()
0066779FC  ldr      x2, [x8]
006677A00  ldrb     w8, [x2, #0x53]
006677A04  tbnz     w8, #5, #0x6677a10
006677A08  strb     wzr, [x19, #0xad]
006677A0C  b        #0x6677a20 ; 
006677A10  ldr      x8, [x2, #0x60]
006677A14  mov      x0, x19
006677A18  mov      w1, wzr
006677A1C  blr      x8
006677A20  adrp     x20, #0x9599000
006677A24  ldrb     w8, [x20, #0xee5]
006677A28  cbnz     w8, #0x6677a40
006677A2C  adrp     x0, #0x8f0f000
006677A30  ldr      x0, [x0, #0x8d8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableHitBehindFission()
006677A34  bl       #0x382bd14 ; 
006677A38  mov      w8, #1
006677A3C  strb     w8, [x20, #0xee5]
006677A40  adrp     x8, #0x8f0f000
006677A44  ldr      x8, [x8, #0x8d8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableHitBehindFission()
006677A48  ldr      x2, [x8]
006677A4C  ldrb     w8, [x2, #0x53]
006677A50  tbnz     w8, #5, #0x6677a5c
006677A54  strb     wzr, [x19, #0xae]
006677A58  b        #0x6677a6c ; 
006677A5C  ldr      x8, [x2, #0x60]
006677A60  mov      x0, x19
006677A64  mov      w1, wzr
006677A68  blr      x8
006677A6C  adrp     x20, #0x9599000
006677A70  ldrb     w8, [x20, #0xee6]
006677A74  cbnz     w8, #0x6677a8c
006677A78  adrp     x0, #0x8f0f000
006677A7C  ldr      x0, [x0, #0x8e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableThroughAttackPercentReduce()
006677A80  bl       #0x382bd14 ; 
006677A84  mov      w8, #1
006677A88  strb     w8, [x20, #0xee6]
006677A8C  adrp     x8, #0x8f0f000
006677A90  ldr      x8, [x8, #0x8e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_DisableThroughAttackPercentReduce()
006677A94  ldr      x2, [x8]
006677A98  ldrb     w8, [x2, #0x53]
006677A9C  tbnz     w8, #5, #0x6677aa8
006677AA0  strb     wzr, [x19, #0xaf]
006677AA4  b        #0x6677ab8 ; 
006677AA8  ldr      x8, [x2, #0x60]
006677AAC  mov      x0, x19
006677AB0  mov      w1, wzr
006677AB4  blr      x8
006677AB8  adrp     x20, #0x9599000
006677ABC  ldrb     w8, [x20, #0xee7]
006677AC0  cbnz     w8, #0x6677ad8
006677AC4  adrp     x0, #0x8f0f000
006677AC8  ldr      x0, [x0, #0x8f8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_FireOnExplosionWeaponId()
006677ACC  bl       #0x382bd14 ; 
006677AD0  mov      w8, #1
006677AD4  strb     w8, [x20, #0xee7]
006677AD8  adrp     x8, #0x8f0f000
006677ADC  ldr      x8, [x8, #0x8f8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_FireOnExplosionWeaponId()
006677AE0  ldr      x2, [x8]
006677AE4  ldrb     w8, [x2, #0x53]
006677AE8  tbnz     w8, #5, #0x6677af4
006677AEC  str      wzr, [x19, #0xb0]
006677AF0  b        #0x6677b04 ; 
006677AF4  ldr      x8, [x2, #0x60]
006677AF8  mov      x0, x19
006677AFC  mov      w1, wzr
006677B00  blr      x8
006677B04  adrp     x20, #0x9599000
006677B08  ldrb     w8, [x20, #0xee8]
006677B0C  cbnz     w8, #0x6677b24
006677B10  adrp     x0, #0x8f0f000
006677B14  ldr      x0, [x0, #0x908] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_FallThunderWeaponId()
006677B18  bl       #0x382bd14 ; 
006677B1C  mov      w8, #1
006677B20  strb     w8, [x20, #0xee8]
006677B24  adrp     x8, #0x8f0f000
006677B28  ldr      x8, [x8, #0x908] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_FallThunderWeaponId()
006677B2C  ldr      x2, [x8]
006677B30  ldrb     w8, [x2, #0x53]
006677B34  tbnz     w8, #5, #0x6677b40
006677B38  str      wzr, [x19, #0xb4]
006677B3C  b        #0x6677b50 ; 
006677B40  ldr      x8, [x2, #0x60]
006677B44  mov      x0, x19
006677B48  mov      w1, wzr
006677B4C  blr      x8
006677B50  adrp     x20, #0x9591000
006677B54  ldrb     w8, [x20, #0xa64]
006677B58  cbnz     w8, #0x6677b70
006677B5C  adrp     x0, #0x8ee6000
006677B60  ldr      x0, [x0, #0x208] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponId()
006677B64  bl       #0x382bd14 ; 
006677B68  mov      w8, #1
006677B6C  strb     w8, [x20, #0xa64]
006677B70  adrp     x8, #0x8ee6000
006677B74  ldr      x8, [x8, #0x208] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponId()
006677B78  ldr      x2, [x8]
006677B7C  ldrb     w8, [x2, #0x53]
006677B80  tbnz     w8, #5, #0x6677b8c
006677B84  str      wzr, [x19, #0xb8]
006677B88  b        #0x6677b9c ; 
006677B8C  ldr      x8, [x2, #0x60]
006677B90  mov      x0, x19
006677B94  mov      w1, wzr
006677B98  blr      x8
006677B9C  adrp     x20, #0x9591000
006677BA0  ldrb     w8, [x20, #0xa65]
006677BA4  cbnz     w8, #0x6677bbc
006677BA8  adrp     x0, #0x8ee6000
006677BAC  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponBulletSerialIndex()
006677BB0  bl       #0x382bd14 ; 
006677BB4  mov      w8, #1
006677BB8  strb     w8, [x20, #0xa65]
006677BBC  adrp     x8, #0x8ee6000
006677BC0  ldr      x8, [x8, #0x210] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponBulletSerialIndex()
006677BC4  ldr      x2, [x8]
006677BC8  ldrb     w8, [x2, #0x53]
006677BCC  tbnz     w8, #5, #0x6677bd8
006677BD0  str      wzr, [x19, #0xbc]
006677BD4  b        #0x6677be8 ; 
006677BD8  ldr      x8, [x2, #0x60]
006677BDC  mov      x0, x19
006677BE0  mov      w1, wzr
006677BE4  blr      x8
006677BE8  add      x8, sp, #0x20
006677BEC  mov      x0, xzr
006677BF0  bl       #0x7d4fd40 ; Photon.Deterministic.FPVector3$$get_Zero
006677BF4  adrp     x20, #0x9592000
006677BF8  ldr      q0, [sp, #0x20]
006677BFC  ldr      x8, [sp, #0x30]
006677C00  ldrb     w9, [x20, #0x471]
006677C04  str      q0, [sp]
006677C08  str      x8, [sp, #0x10]
006677C0C  cbnz     w9, #0x6677c24
006677C10  adrp     x0, #0x8ee8000
006677C14  ldr      x0, [x0, #0x850] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_LaserStartPos()
006677C18  bl       #0x382bd14 ; 
006677C1C  mov      w8, #1
006677C20  strb     w8, [x20, #0x471]
006677C24  adrp     x8, #0x8ee8000
006677C28  ldr      x8, [x8, #0x850] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_LaserStartPos()
006677C2C  ldr      x2, [x8]
006677C30  ldrb     w8, [x2, #0x53]
006677C34  tbnz     w8, #5, #0x6677c4c
006677C38  ldr      x8, [sp, #0x10]
006677C3C  ldr      q0, [sp]
006677C40  str      x8, [x19, #0x100]
006677C44  str      q0, [x19, #0xf0]
006677C48  b        #0x6677c6c ; 
006677C4C  ldr      q0, [sp]
006677C50  ldr      x8, [sp, #0x10]
006677C54  ldr      x9, [x2, #0x60]
006677C58  add      x1, sp, #0x20
006677C5C  mov      x0, x19
006677C60  str      q0, [sp, #0x20]
006677C64  str      x8, [sp, #0x30]
006677C68  blr      x9
006677C6C  adrp     x20, #0x9599000
006677C70  ldrb     w8, [x20, #0xee9]
006677C74  cbnz     w8, #0x6677c8c
006677C78  adrp     x0, #0x8f0f000
006677C7C  ldr      x0, [x0, #0x818] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectCount()
006677C80  bl       #0x382bd14 ; 
006677C84  mov      w8, #1
006677C88  strb     w8, [x20, #0xee9]
006677C8C  adrp     x8, #0x8f0f000
006677C90  ldr      x8, [x8, #0x818] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectCount()
006677C94  ldr      x2, [x8]
006677C98  ldrb     w8, [x2, #0x53]
006677C9C  tbnz     w8, #5, #0x6677ca8
006677CA0  str      wzr, [x19, #0x88]
006677CA4  b        #0x6677cb8 ; 
006677CA8  ldr      x8, [x2, #0x60]
006677CAC  mov      x0, x19
006677CB0  mov      w1, wzr
006677CB4  blr      x8
006677CB8  mov      w9, #0x10000
006677CBC  add      x8, x19, #0x288
006677CC0  dup      v0.2d, x9
006677CC4  str      wzr, [x19, #0x270]
006677CC8  str      q0, [x8]
006677CCC  str      x9, [x19, #0x2a0]
006677CD0  str      x9, [x19, #0x2b0]
006677CD4  adrp     x20, #0x9599000
006677CD8  ldrb     w8, [x20, #0xeea]
006677CDC  cbnz     w8, #0x6677cf4
006677CE0  adrp     x0, #0x8f0f000
006677CE4  ldr      x0, [x0, #0xa88] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExEjectAttackPercent()
006677CE8  bl       #0x382bd14 ; 
006677CEC  mov      w8, #1
006677CF0  strb     w8, [x20, #0xeea]
006677CF4  adrp     x8, #0x8f0f000
006677CF8  ldr      x8, [x8, #0xa88] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ExEjectAttackPercent()
006677CFC  ldr      x2, [x8]
006677D00  ldrb     w8, [x2, #0x53]
006677D04  tbnz     w8, #5, #0x6677d14
006677D08  mov      w8, #0x10000
006677D0C  str      x8, [x19, #0x2a8]
006677D10  b        #0x6677d24 ; 
006677D14  ldr      x8, [x2, #0x60]
006677D18  mov      w1, #0x10000
006677D1C  mov      x0, x19
006677D20  blr      x8
006677D24  adrp     x20, #0x9591000
006677D28  ldrb     w8, [x20, #0xa67]
006677D2C  cbnz     w8, #0x6677d44
006677D30  adrp     x0, #0x8ee6000
006677D34  ldr      x0, [x0, #0x220] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponBuffFlagAttributes()
006677D38  bl       #0x382bd14 ; 
006677D3C  mov      w8, #1
006677D40  strb     w8, [x20, #0xa67]
006677D44  adrp     x8, #0x8ee6000
006677D48  ldr      x8, [x8, #0x220] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponBuffFlagAttributes()
006677D4C  ldr      x2, [x8]
006677D50  ldrb     w8, [x2, #0x53]
006677D54  tbnz     w8, #5, #0x6677d6c
006677D58  add      x0, x19, #0x2c0
006677D5C  mov      x1, xzr
006677D60  str      xzr, [x19, #0x2c0]
006677D64  bl       #0x382bcb8 ; 
006677D68  b        #0x6677d7c ; 
006677D6C  ldr      x8, [x2, #0x60]
006677D70  mov      x0, x19
006677D74  mov      x1, xzr
006677D78  blr      x8
006677D7C  adrp     x20, #0x9591000
006677D80  ldrb     w8, [x20, #0xa66]
006677D84  cbnz     w8, #0x6677d9c
006677D88  adrp     x0, #0x8ee6000
006677D8C  ldr      x0, [x0, #0x218] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponBuffFlags()
006677D90  bl       #0x382bd14 ; 
006677D94  mov      w8, #1
006677D98  strb     w8, [x20, #0xa66]
006677D9C  adrp     x8, #0x8ee6000
006677DA0  ldr      x8, [x8, #0x218] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_WeaponBuffFlags()
006677DA4  ldr      x2, [x8]
006677DA8  ldrb     w8, [x2, #0x53]
006677DAC  tbnz     w8, #5, #0x6677dc4
006677DB0  add      x0, x19, #0x2c8
006677DB4  mov      x1, xzr
006677DB8  str      xzr, [x19, #0x2c8]
006677DBC  bl       #0x382bcb8 ; 
006677DC0  b        #0x6677dd4 ; 
006677DC4  ldr      x8, [x2, #0x60]
006677DC8  mov      x0, x19
006677DCC  mov      x1, xzr
006677DD0  blr      x8
006677DD4  adrp     x20, #0x9591000
006677DD8  ldrb     w8, [x20, #0xa68]
006677DDC  cbnz     w8, #0x6677df4
006677DE0  adrp     x0, #0x8ee6000
006677DE4  ldr      x0, [x0, #0x228] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ConditionAttrConfigs()
006677DE8  bl       #0x382bd14 ; 
006677DEC  mov      w8, #1
006677DF0  strb     w8, [x20, #0xa68]
006677DF4  adrp     x8, #0x8ee6000
006677DF8  ldr      x8, [x8, #0x228] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ConditionAttrConfigs()
006677DFC  ldr      x2, [x8]
006677E00  ldrb     w8, [x2, #0x53]
006677E04  tbnz     w8, #5, #0x6677e1c
006677E08  add      x0, x19, #0x2d0
006677E0C  mov      x1, xzr
006677E10  str      xzr, [x19, #0x2d0]
006677E14  bl       #0x382bcb8 ; 
006677E18  b        #0x6677e2c ; 
006677E1C  ldr      x8, [x2, #0x60]
006677E20  mov      x0, x19
006677E24  mov      x1, xzr
006677E28  blr      x8
006677E2C  mov      w8, #0x10000
006677E30  strb     wzr, [x19, #0x275]
006677E34  str      wzr, [x19, #0x328]
006677E38  str      wzr, [x19, #0x2e0]
006677E3C  str      x8, [x19, #0x2d8]
006677E40  adrp     x20, #0x9595000
006677E44  ldrb     w8, [x20, #0x73a]
006677E48  cbnz     w8, #0x6677e60
006677E4C  adrp     x0, #0x8eea000
006677E50  ldr      x0, [x0, #0xf38] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_EntitiesThatFailedToKillThisBullet()
006677E54  bl       #0x382bd14 ; 
006677E58  mov      w8, #1
006677E5C  strb     w8, [x20, #0x73a]
006677E60  adrp     x8, #0x8eea000
006677E64  ldr      x8, [x8, #0xf38] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_EntitiesThatFailedToKillThisBullet()
006677E68  ldr      x1, [x8]
006677E6C  ldrb     w8, [x1, #0x53]
006677E70  tbnz     w8, #5, #0x6677e7c
006677E74  ldr      x0, [x19, #0x318]
006677E78  b        #0x6677e88 ; 
006677E7C  ldr      x8, [x1, #0x60]
006677E80  mov      x0, x19
006677E84  blr      x8
006677E88  cbz      x0, #0x667822c
006677E8C  adrp     x8, #0x8ee9000
006677E90  ldr      x8, [x8, #0x970] ; GLOBAL Method$System.Collections.Generic.HashSet<EntityRef>.Clear()
006677E94  ldr      x1, [x8]
006677E98  bl       #0x4931c68 ; System.Collections.Generic.HashSet<EntityRef>$$Clear
006677E9C  ldr      x8, [x19, #0x320]
006677EA0  cbz      x8, #0x667822c
006677EA4  ldr      w9, [x8, #0x1c]
006677EA8  adrp     x20, #0x9599000
006677EAC  add      w9, w9, #1
006677EB0  stp      wzr, w9, [x8, #0x18]
006677EB4  ldrb     w8, [x20, #0xeeb]
006677EB8  cbnz     w8, #0x6677ed0
006677EBC  adrp     x0, #0x8f0f000
006677EC0  ldr      x0, [x0, #0xa40] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectDelayDuration()
006677EC4  bl       #0x382bd14 ; 
006677EC8  mov      w8, #1
006677ECC  strb     w8, [x20, #0xeeb]
006677ED0  adrp     x8, #0x8f0f000
006677ED4  ldr      x8, [x8, #0xa40] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectDelayDuration()
006677ED8  ldr      x2, [x8]
006677EDC  ldrb     w8, [x2, #0x53]
006677EE0  tbnz     w8, #5, #0x6677eec
006677EE4  str      xzr, [x19, #0x1b0]
006677EE8  b        #0x6677efc ; 
006677EEC  ldr      x8, [x2, #0x60]
006677EF0  mov      x0, x19
006677EF4  mov      x1, xzr
006677EF8  blr      x8
006677EFC  mov      x0, xzr
006677F00  str      xzr, [x19, #0x280]
006677F04  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
006677F08  adrp     x22, #0x9599000
006677F0C  ldrb     w8, [x22, #0xed4]
006677F10  mov      x20, x0
006677F14  cbnz     w8, #0x6677f2c
006677F18  adrp     x0, #0x8f0f000
006677F1C  ldr      x0, [x0, #0xb10] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ParentFlashChainModProcessorBulletRef()
006677F20  bl       #0x382bd14 ; 
006677F24  mov      w8, #1
006677F28  strb     w8, [x22, #0xed4]
006677F2C  adrp     x8, #0x8f0f000
006677F30  ldr      x8, [x8, #0xb10] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ParentFlashChainModProcessorBulletRef()
006677F34  ldr      x2, [x8]
006677F38  ldrb     w8, [x2, #0x53]
006677F3C  tbnz     w8, #5, #0x6677f48
006677F40  str      x20, [x19, #0x3d0]
006677F44  b        #0x6677f58 ; 
006677F48  ldr      x8, [x2, #0x60]
006677F4C  mov      x0, x19
006677F50  mov      x1, x20
006677F54  blr      x8
006677F58  adrp     x20, #0x9599000
006677F5C  ldrb     w8, [x20, #0xeec]
006677F60  cbnz     w8, #0x6677f78
006677F64  adrp     x0, #0x8f0f000
006677F68  ldr      x0, [x0, #0x830] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ReflectionCount()
006677F6C  bl       #0x382bd14 ; 
006677F70  mov      w8, #1
006677F74  strb     w8, [x20, #0xeec]
006677F78  adrp     x8, #0x8f0f000
006677F7C  ldr      x8, [x8, #0x830] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ReflectionCount()
006677F80  ldr      x2, [x8]
006677F84  ldrb     w8, [x2, #0x53]
006677F88  tbnz     w8, #5, #0x6677f94
006677F8C  str      wzr, [x19, #0x90]
006677F90  b        #0x6677fa4 ; 
006677F94  ldr      x8, [x2, #0x60]
006677F98  mov      x0, x19
006677F9C  mov      w1, wzr
006677FA0  blr      x8
006677FA4  str      xzr, [x19, #0x2b8]
006677FA8  adrp     x20, #0x9599000
006677FAC  ldrb     w8, [x20, #0xeed]
006677FB0  cbnz     w8, #0x6677fc8
006677FB4  adrp     x0, #0x8f0f000
006677FB8  ldr      x0, [x0, #0xa00] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_PullRadius()
006677FBC  bl       #0x382bd14 ; 
006677FC0  mov      w8, #1
006677FC4  strb     w8, [x20, #0xeed]
006677FC8  adrp     x8, #0x8f0f000
006677FCC  ldr      x8, [x8, #0xa00] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_PullRadius()
006677FD0  ldr      x2, [x8]
006677FD4  ldrb     w8, [x2, #0x53]
006677FD8  tbnz     w8, #5, #0x6677fe4
006677FDC  str      xzr, [x19, #0x190]
006677FE0  b        #0x6677ff4 ; 
006677FE4  ldr      x8, [x2, #0x60]
006677FE8  mov      x0, x19
006677FEC  mov      x1, xzr
006677FF0  blr      x8
006677FF4  adrp     x20, #0x9599000
006677FF8  ldrb     w8, [x20, #0xeee]
006677FFC  cbnz     w8, #0x6678014
006678000  adrp     x0, #0x8f0f000
006678004  ldr      x0, [x0, #0xa10] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_PullStrength()
006678008  bl       #0x382bd14 ; 
00667800C  mov      w8, #1
006678010  strb     w8, [x20, #0xeee]
006678014  adrp     x8, #0x8f0f000
006678018  ldr      x8, [x8, #0xa10] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_PullStrength()
00667801C  ldr      x2, [x8]
006678020  ldrb     w8, [x2, #0x53]
006678024  tbnz     w8, #5, #0x6678030
006678028  str      xzr, [x19, #0x198]
00667802C  b        #0x6678040 ; 
006678030  ldr      x8, [x2, #0x60]
006678034  mov      x0, x19
006678038  mov      x1, xzr
00667803C  blr      x8
006678040  adrp     x20, #0x9599000
006678044  ldrb     w8, [x20, #0xeef]
006678048  cbnz     w8, #0x6678060
00667804C  adrp     x0, #0x8f0f000
006678050  ldr      x0, [x0, #0xa20] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_PullBackToCenter()
006678054  bl       #0x382bd14 ; 
006678058  mov      w8, #1
00667805C  strb     w8, [x20, #0xeef]
006678060  adrp     x8, #0x8f0f000
006678064  ldr      x8, [x8, #0xa20] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_PullBackToCenter()
006678068  ldr      x2, [x8]
00667806C  ldrb     w8, [x2, #0x53]
006678070  tbnz     w8, #5, #0x667807c
006678074  strb     wzr, [x19, #0x1a0]
006678078  b        #0x667808c ; 
00667807C  ldr      x8, [x2, #0x60]
006678080  mov      x0, x19
006678084  mov      w1, wzr
006678088  blr      x8
00667808C  adrp     x20, #0x9599000
006678090  ldrb     w8, [x20, #0xef0]
006678094  cbnz     w8, #0x66780ac
006678098  adrp     x0, #0x8f0f000
00667809C  ldr      x0, [x0, #0x828] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectModRandomType()
0066780A0  bl       #0x382bd14 ; 
0066780A4  mov      w8, #1
0066780A8  strb     w8, [x20, #0xef0]
0066780AC  adrp     x8, #0x8f0f000
0066780B0  ldr      x8, [x8, #0x828] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_EjectModRandomType()
0066780B4  ldr      x2, [x8]
0066780B8  ldrb     w8, [x2, #0x53]
0066780BC  tbnz     w8, #5, #0x66780c8
0066780C0  str      wzr, [x19, #0x8c]
0066780C4  b        #0x66780d8 ; 
0066780C8  ldr      x8, [x2, #0x60]
0066780CC  mov      x0, x19
0066780D0  mov      w1, wzr
0066780D4  blr      x8
0066780D8  adrp     x20, #0x9599000
0066780DC  ldrb     w8, [x20, #0xef1]
0066780E0  cbnz     w8, #0x66780f8
0066780E4  adrp     x0, #0x8f0f000
0066780E8  ldr      x0, [x0, #0x9a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IgnoreNoReboundDie()
0066780EC  bl       #0x382bd14 ; 
0066780F0  mov      w8, #1
0066780F4  strb     w8, [x20, #0xef1]
0066780F8  adrp     x8, #0x8f0f000
0066780FC  ldr      x8, [x8, #0x9a0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IgnoreNoReboundDie()
006678100  ldr      x2, [x8]
006678104  ldrb     w8, [x2, #0x53]
006678108  tbnz     w8, #5, #0x6678114
00667810C  strb     wzr, [x19, #0x118]
006678110  b        #0x6678124 ; 
006678114  ldr      x8, [x2, #0x60]
006678118  mov      x0, x19
00667811C  mov      w1, wzr
006678120  blr      x8
006678124  adrp     x20, #0x9599000
006678128  ldrb     w8, [x20, #0xef2]
00667812C  cbnz     w8, #0x6678144
006678130  adrp     x0, #0x8f0f000
006678134  ldr      x0, [x0, #0xb38] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCircularSlash()
006678138  bl       #0x382bd14 ; 
00667813C  mov      w8, #1
006678140  strb     w8, [x20, #0xef2]
006678144  adrp     x8, #0x8f0f000
006678148  ldr      x8, [x8, #0xb38] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_IsCircularSlash()
00667814C  ldr      x2, [x8]
006678150  ldrb     w8, [x2, #0x53]
006678154  tbnz     w8, #5, #0x6678160
006678158  strb     wzr, [x19, #0x3e4]
00667815C  b        #0x6678170 ; 
006678160  ldr      x8, [x2, #0x60]
006678164  mov      x0, x19
006678168  mov      w1, wzr
00667816C  blr      x8
006678170  adrp     x20, #0x9599000
006678174  ldrb     w8, [x20, #0xef3]
006678178  cbnz     w8, #0x6678190
00667817C  adrp     x0, #0x8f0f000
006678180  ldr      x0, [x0, #0xb48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_CircularSlashTotalAngle()
006678184  bl       #0x382bd14 ; 
006678188  mov      w8, #1
00667818C  strb     w8, [x20, #0xef3]
006678190  adrp     x8, #0x8f0f000
006678194  ldr      x8, [x8, #0xb48] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_CircularSlashTotalAngle()
006678198  ldr      x2, [x8]
00667819C  ldrb     w8, [x2, #0x53]
0066781A0  tbnz     w8, #5, #0x66781ac
0066781A4  str      xzr, [x19, #0x3e8]
0066781A8  b        #0x66781bc ; 
0066781AC  ldr      x8, [x2, #0x60]
0066781B0  mov      x0, x19
0066781B4  mov      x1, xzr
0066781B8  blr      x8
0066781BC  adrp     x20, #0x9599000
0066781C0  ldrb     w8, [x20, #0xef4]
0066781C4  cbnz     w8, #0x66781dc
0066781C8  adrp     x0, #0x8f0f000
0066781CC  ldr      x0, [x0, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_CircularSlashRangeAddPercent()
0066781D0  bl       #0x382bd14 ; 
0066781D4  mov      w8, #1
0066781D8  strb     w8, [x20, #0xef4]
0066781DC  adrp     x8, #0x8f0f000
0066781E0  ldr      x8, [x8, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_CircularSlashRangeAddPercent()
0066781E4  ldr      x2, [x8]
0066781E8  ldrb     w8, [x2, #0x53]
0066781EC  tbnz     w8, #5, #0x66781f8
0066781F0  str      xzr, [x19, #0x3f0]
0066781F4  b        #0x6678208 ; 
0066781F8  ldr      x8, [x2, #0x60]
0066781FC  mov      x0, x19
006678200  mov      x1, xzr
006678204  blr      x8
006678208  ldr      x8, [x21, #0x28]
00667820C  ldr      x9, [sp, #0x38]
006678210  cmp      x8, x9
006678214  b.ne     #0x6678230
006678218  ldp      x20, x19, [sp, #0x60]
00667821C  ldp      x22, x21, [sp, #0x50]
006678220  ldp      x30, x23, [sp, #0x40]
006678224  add      sp, sp, #0x70
006678228  ret      
00667822C  bl       #0x382bfb8 ; 
006678230  bl       #0x89edb60 ; 

