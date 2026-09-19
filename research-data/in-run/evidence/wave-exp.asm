; HotFix.BattleLogic.WaterfallBattleManager$$InitNewWaveData
; RVA 0x65CB634; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CB634  sub      sp, sp, #0x80
0065CB638  stp      x29, x30, [sp, #0x20]
0065CB63C  stp      x28, x27, [sp, #0x30]
0065CB640  stp      x26, x25, [sp, #0x40]
0065CB644  stp      x24, x23, [sp, #0x50]
0065CB648  stp      x22, x21, [sp, #0x60]
0065CB64C  stp      x20, x19, [sp, #0x70]
0065CB650  adrp     x20, #0x9599000
0065CB654  adrp     x21, #0x8f0a000
0065CB658  ldrb     w8, [x20, #0x587]
0065CB65C  ldr      x21, [x21, #0x7f8]
0065CB660  mov      x19, x0
0065CB664  tbnz     w8, #0, #0x65cb6ac
0065CB668  adrp     x0, #0x8f0a000
0065CB66C  ldr      x0, [x0, #0x800]
0065CB670  bl       #0x382bd14 ; 
0065CB674  adrp     x0, #0x8ee6000
0065CB678  ldr      x0, [x0, #0xd8]
0065CB67C  bl       #0x382bd14 ; 
0065CB680  adrp     x0, #0x8f09000
0065CB684  ldr      x0, [x0, #0xc08]
0065CB688  bl       #0x382bd14 ; 
0065CB68C  adrp     x0, #0x8f0a000
0065CB690  ldr      x0, [x0, #0x808]
0065CB694  bl       #0x382bd14 ; 
0065CB698  adrp     x0, #0x8f0a000
0065CB69C  ldr      x0, [x0, #0x7f8]
0065CB6A0  bl       #0x382bd14 ; 
0065CB6A4  mov      w8, #1
0065CB6A8  strb     w8, [x20, #0x587]
0065CB6AC  ldr      x1, [x21]
0065CB6B0  ldrb     w8, [x1, #0x53]
0065CB6B4  tbnz     w8, #5, #0x65cb70c
0065CB6B8  ldr      x20, [x19, #0x188]
0065CB6BC  cbz      x20, #0x65cc058
0065CB6C0  adrp     x29, #0x8f09000
0065CB6C4  ldr      x8, [x20]
0065CB6C8  ldr      w21, [x19, #0x130]
0065CB6CC  ldr      x29, [x29, #0xc08]
0065CB6D0  ldrh     w9, [x8, #0x12e]
0065CB6D4  ldr      x1, [x29]
0065CB6D8  cbz      x9, #0x65cb6fc
0065CB6DC  ldr      x10, [x8, #0xb0]
0065CB6E0  add      x10, x10, #8
0065CB6E4  ldur     x11, [x10, #-8]
0065CB6E8  cmp      x11, x1
0065CB6EC  b.eq     #0x65cb734
0065CB6F0  subs     x9, x9, #1
0065CB6F4  add      x10, x10, #0x10
0065CB6F8  b.ne     #0x65cb6e4
0065CB6FC  mov      w2, #2
0065CB700  mov      x0, x20
0065CB704  bl       #0x3a7e710 ; 
0065CB708  b        #0x65cb744 ; 
0065CB70C  ldr      x2, [x1, #0x60]
0065CB710  mov      x0, x19
0065CB714  ldp      x20, x19, [sp, #0x70]
0065CB718  ldp      x22, x21, [sp, #0x60]
0065CB71C  ldp      x24, x23, [sp, #0x50]
0065CB720  ldp      x26, x25, [sp, #0x40]
0065CB724  ldp      x28, x27, [sp, #0x30]
0065CB728  ldp      x29, x30, [sp, #0x20]
0065CB72C  add      sp, sp, #0x80
0065CB730  br       x2
0065CB734  ldr      w9, [x10]
0065CB738  add      w9, w9, #2
0065CB73C  add      x8, x8, w9, sxtw #4
0065CB740  add      x0, x8, #0x138
0065CB744  ldp      x8, x1, [x0]
0065CB748  mov      x0, x20
0065CB74C  blr      x8
0065CB750  cmp      w21, w0
0065CB754  b.ne     #0x65cb778
0065CB758  ldp      x20, x19, [sp, #0x70]
0065CB75C  ldp      x22, x21, [sp, #0x60]
0065CB760  ldp      x24, x23, [sp, #0x50]
0065CB764  ldp      x26, x25, [sp, #0x40]
0065CB768  ldp      x28, x27, [sp, #0x30]
0065CB76C  ldp      x29, x30, [sp, #0x20]
0065CB770  add      sp, sp, #0x80
0065CB774  ret      
0065CB778  ldr      x20, [x19, #0x188]
0065CB77C  str      xzr, [x19, #0x208]
0065CB780  cbz      x20, #0x65cc058
0065CB784  ldr      x8, [x20]
0065CB788  ldr      x1, [x29]
0065CB78C  ldrh     w9, [x8, #0x12e]
0065CB790  cbz      x9, #0x65cb7b4
0065CB794  ldr      x10, [x8, #0xb0]
0065CB798  add      x10, x10, #8
0065CB79C  ldur     x11, [x10, #-8]
0065CB7A0  cmp      x11, x1
0065CB7A4  b.eq     #0x65cb7c4
0065CB7A8  subs     x9, x9, #1
0065CB7AC  add      x10, x10, #0x10
0065CB7B0  b.ne     #0x65cb79c
0065CB7B4  mov      w2, #2
0065CB7B8  mov      x0, x20
0065CB7BC  bl       #0x3a7e710 ; 
0065CB7C0  b        #0x65cb7d4 ; 
0065CB7C4  ldr      w9, [x10]
0065CB7C8  add      w9, w9, #2
0065CB7CC  add      x8, x8, w9, sxtw #4
0065CB7D0  add      x0, x8, #0x138
0065CB7D4  ldp      x8, x1, [x0]
0065CB7D8  mov      x0, x20
0065CB7DC  blr      x8
0065CB7E0  mov      w20, #1
0065CB7E4  str      w0, [x19, #0x130]
0065CB7E8  str      wzr, [x19, #0x148]
0065CB7EC  str      wzr, [x19, #0x1c8]
0065CB7F0  str      wzr, [x19, #0x17c]
0065CB7F4  strb     w20, [x19, #0x210]
0065CB7F8  adrp     x26, #0x9599000
0065CB7FC  ldrb     w8, [x26, #0x286]
0065CB800  cbnz     w8, #0x65cb814
0065CB804  adrp     x0, #0x8f07000
0065CB808  ldr      x0, [x0, #0xc98]
0065CB80C  bl       #0x382bd14 ; 
0065CB810  strb     w20, [x26, #0x286]
0065CB814  adrp     x20, #0x8f07000
0065CB818  ldr      x20, [x20, #0xc98]
0065CB81C  ldr      x1, [x20]
0065CB820  ldrb     w8, [x1, #0x53]
0065CB824  tbnz     w8, #5, #0x65cb830
0065CB828  ldr      x0, [x19, #0x80]
0065CB82C  b        #0x65cb83c ; 
0065CB830  ldr      x8, [x1, #0x60]
0065CB834  mov      x0, x19
0065CB838  blr      x8
0065CB83C  cbz      x0, #0x65cc058
0065CB840  ldr      x0, [x0, #0x3b8]
0065CB844  mov      x1, xzr
0065CB848  bl       #0x6b26cc8 ; LocalModels.Bean.ChapterABTestExtension$$GetABWaveId
0065CB84C  ldr      x22, [x19, #0x188]
0065CB850  cbz      x22, #0x65cc058
0065CB854  ldr      x8, [x22]
0065CB858  ldr      x1, [x29]
0065CB85C  mov      w21, w0
0065CB860  ldrh     w9, [x8, #0x12e]
0065CB864  cbz      x9, #0x65cb888
0065CB868  ldr      x10, [x8, #0xb0]
0065CB86C  add      x10, x10, #8
0065CB870  ldur     x11, [x10, #-8]
0065CB874  cmp      x11, x1
0065CB878  b.eq     #0x65cb898
0065CB87C  subs     x9, x9, #1
0065CB880  add      x10, x10, #0x10
0065CB884  b.ne     #0x65cb870
0065CB888  mov      w2, #2
0065CB88C  mov      x0, x22
0065CB890  bl       #0x3a7e710 ; 
0065CB894  b        #0x65cb8a8 ; 
0065CB898  ldr      w9, [x10]
0065CB89C  add      w9, w9, #2
0065CB8A0  add      x8, x8, w9, sxtw #4
0065CB8A4  add      x0, x8, #0x138
0065CB8A8  ldp      x8, x1, [x0]
0065CB8AC  mov      x0, x22
0065CB8B0  blr      x8
0065CB8B4  ldrb     w8, [x26, #0x286]
0065CB8B8  mov      w23, w0
0065CB8BC  cbnz     w8, #0x65cb8d4
0065CB8C0  adrp     x0, #0x8f07000
0065CB8C4  ldr      x0, [x0, #0xc98]
0065CB8C8  bl       #0x382bd14 ; 
0065CB8CC  mov      w8, #1
0065CB8D0  strb     w8, [x26, #0x286]
0065CB8D4  ldr      x1, [x20]
0065CB8D8  ldrb     w8, [x1, #0x53]
0065CB8DC  tbnz     w8, #5, #0x65cb8e8
0065CB8E0  ldr      x24, [x19, #0x80]
0065CB8E4  b        #0x65cb8f8 ; 
0065CB8E8  ldr      x8, [x1, #0x60]
0065CB8EC  mov      x0, x19
0065CB8F0  blr      x8
0065CB8F4  mov      x24, x0
0065CB8F8  cbz      x24, #0x65cc058
0065CB8FC  adrp     x27, #0x9598000
0065CB900  ldrb     w8, [x27, #0xfcc]
0065CB904  cbnz     w8, #0x65cb91c
0065CB908  adrp     x0, #0x8f06000
0065CB90C  ldr      x0, [x0, #0x470]
0065CB910  bl       #0x382bd14 ; 
0065CB914  mov      w8, #1
0065CB918  strb     w8, [x27, #0xfcc]
0065CB91C  adrp     x22, #0x8f06000
0065CB920  ldr      x22, [x22, #0x470]
0065CB924  ldr      x1, [x22]
0065CB928  ldrb     w8, [x1, #0x53]
0065CB92C  tbnz     w8, #5, #0x65cb938
0065CB930  ldr      x0, [x24, #0x200]
0065CB934  b        #0x65cb944 ; 
0065CB938  ldr      x8, [x1, #0x60]
0065CB93C  mov      x0, x24
0065CB940  blr      x8
0065CB944  cbz      x0, #0x65cc058
0065CB948  add      w1, w23, w21
0065CB94C  mov      x2, xzr
0065CB950  bl       #0x64ce48c ; LocalModels.LocalModelManager$$GetChapterWave_Waves
0065CB954  add      x28, x19, #0x140
0065CB958  mov      x1, x0
0065CB95C  str      x0, [x19, #0x140]
0065CB960  mov      x0, x28
0065CB964  bl       #0x382bcb8 ; 
0065CB968  ldr      x0, [x19, #0x168]
0065CB96C  cbz      x0, #0x65cc058
0065CB970  adrp     x8, #0x8f0a000
0065CB974  ldr      x8, [x8, #0x808]
0065CB978  ldr      x1, [x8]
0065CB97C  bl       #0x5221e6c ; Rock.Collections.OrderedDictionary<int, int>$$Clear
0065CB980  ldr      x0, [x19, #0x1f0]
0065CB984  mov      w8, #-1
0065CB988  str      wzr, [x19, #0x150]
0065CB98C  str      wzr, [x19, #0x14c]
0065CB990  stp      xzr, xzr, [x19, #0x158]
0065CB994  str      w8, [x19, #0x13c]
0065CB998  str      w8, [x19, #0x134]
0065CB99C  cbz      x0, #0x65cc058
0065CB9A0  adrp     x8, #0x8f0a000
0065CB9A4  ldr      x8, [x8, #0x800]
0065CB9A8  ldr      x1, [x8]
0065CB9AC  bl       #0x5e5fbc4 ; System.Collections.Generic.Dictionary<int, object>$$Clear
0065CB9B0  ldr      x1, [x19, #0x140]
0065CB9B4  mov      x0, x19
0065CB9B8  mov      x2, xzr
0065CB9BC  bl       #0x6591480 ; HotFix.BattleLogic.BattleManager$$AddExBattleWaveAttr
0065CB9C0  ldrb     w8, [x26, #0x286]
0065CB9C4  cbnz     w8, #0x65cb9dc
0065CB9C8  adrp     x0, #0x8f07000
0065CB9CC  ldr      x0, [x0, #0xc98]
0065CB9D0  bl       #0x382bd14 ; 
0065CB9D4  mov      w8, #1
0065CB9D8  strb     w8, [x26, #0x286]
0065CB9DC  ldr      x1, [x20]
0065CB9E0  ldrb     w8, [x1, #0x53]
0065CB9E4  tbnz     w8, #5, #0x65cb9f0
0065CB9E8  ldr      x23, [x19, #0x80]
0065CB9EC  b        #0x65cba00 ; 
0065CB9F0  ldr      x8, [x1, #0x60]
0065CB9F4  mov      x0, x19
0065CB9F8  blr      x8
0065CB9FC  mov      x23, x0
0065CBA00  cbz      x23, #0x65cc058
0065CBA04  adrp     x21, #0x9599000
0065CBA08  ldrb     w8, [x21, #0x2c3]
0065CBA0C  cbnz     w8, #0x65cba24
0065CBA10  adrp     x0, #0x8f08000
0065CBA14  ldr      x0, [x0, #0x280]
0065CBA18  bl       #0x382bd14 ; 
0065CBA1C  mov      w8, #1
0065CBA20  strb     w8, [x21, #0x2c3]
0065CBA24  adrp     x8, #0x8f08000
0065CBA28  ldr      x8, [x8, #0x280]
0065CBA2C  ldr      x1, [x8]
0065CBA30  ldrb     w8, [x1, #0x53]
0065CBA34  tbnz     w8, #5, #0x65cba48
0065CBA38  add      x0, x23, #0x290
0065CBA3C  mov      x1, xzr
0065CBA40  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065CBA44  b        #0x65cba54 ; 
0065CBA48  ldr      x8, [x1, #0x60]
0065CBA4C  mov      x0, x23
0065CBA50  blr      x8
0065CBA54  ldrb     w8, [x26, #0x286]
0065CBA58  mov      w23, w0
0065CBA5C  cbnz     w8, #0x65cba74
0065CBA60  adrp     x0, #0x8f07000
0065CBA64  ldr      x0, [x0, #0xc98]
0065CBA68  bl       #0x382bd14 ; 
0065CBA6C  mov      w8, #1
0065CBA70  strb     w8, [x26, #0x286]
0065CBA74  ldr      x1, [x20]
0065CBA78  ldrb     w8, [x1, #0x53]
0065CBA7C  tbnz     w8, #5, #0x65cba88
0065CBA80  ldr      x24, [x19, #0x80]
0065CBA84  b        #0x65cba98 ; 
0065CBA88  ldr      x8, [x1, #0x60]
0065CBA8C  mov      x0, x19
0065CBA90  blr      x8
0065CBA94  mov      x24, x0
0065CBA98  cbz      x24, #0x65cc058
0065CBA9C  ldrb     w8, [x27, #0xfcc]
0065CBAA0  cbnz     w8, #0x65cbab8
0065CBAA4  adrp     x0, #0x8f06000
0065CBAA8  ldr      x0, [x0, #0x470]
0065CBAAC  bl       #0x382bd14 ; 
0065CBAB0  mov      w8, #1
0065CBAB4  strb     w8, [x27, #0xfcc]
0065CBAB8  ldr      x1, [x22]
0065CBABC  ldrb     w8, [x1, #0x53]
0065CBAC0  tbnz     w8, #5, #0x65cbacc
0065CBAC4  ldr      x24, [x24, #0x200]
0065CBAC8  b        #0x65cbadc ; 
0065CBACC  ldr      x8, [x1, #0x60]
0065CBAD0  mov      x0, x24
0065CBAD4  blr      x8
0065CBAD8  mov      x24, x0
0065CBADC  ldrb     w8, [x26, #0x286]
0065CBAE0  cbnz     w8, #0x65cbaf8
0065CBAE4  adrp     x0, #0x8f07000
0065CBAE8  ldr      x0, [x0, #0xc98]
0065CBAEC  bl       #0x382bd14 ; 
0065CBAF0  mov      w8, #1
0065CBAF4  strb     w8, [x26, #0x286]
0065CBAF8  ldr      x1, [x20]
0065CBAFC  ldrb     w8, [x1, #0x53]
0065CBB00  tbnz     w8, #5, #0x65cbb0c
0065CBB04  ldr      x0, [x19, #0x80]
0065CBB08  b        #0x65cbb18 ; 
0065CBB0C  ldr      x8, [x1, #0x60]
0065CBB10  mov      x0, x19
0065CBB14  blr      x8
0065CBB18  cbz      x0, #0x65cc058
0065CBB1C  ldr      w1, [x0, #0x1c8]
0065CBB20  mov      x0, x24
0065CBB24  mov      w2, w23
0065CBB28  mov      x3, xzr
0065CBB2C  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065CBB30  cbz      x0, #0x65cc058
0065CBB34  ldr      x8, [x0]
0065CBB38  ldr      w21, [x19, #0x130]
0065CBB3C  ldr      x1, [x29]
0065CBB40  mov      x24, x0
0065CBB44  ldrh     w9, [x8, #0x12e]
0065CBB48  cbz      x9, #0x65cbb6c
0065CBB4C  ldr      x10, [x8, #0xb0]
0065CBB50  add      x10, x10, #8
0065CBB54  ldur     x11, [x10, #-8]
0065CBB58  cmp      x11, x1
0065CBB5C  b.eq     #0x65cbb7c
0065CBB60  subs     x9, x9, #1
0065CBB64  add      x10, x10, #0x10
0065CBB68  b.ne     #0x65cbb54
0065CBB6C  mov      w2, #2
0065CBB70  mov      x0, x24
0065CBB74  bl       #0x3a7e710 ; 
0065CBB78  b        #0x65cbb8c ; 
0065CBB7C  ldr      w9, [x10]
0065CBB80  add      w9, w9, #2
0065CBB84  add      x8, x8, w9, sxtw #4
0065CBB88  add      x0, x8, #0x138
0065CBB8C  ldp      x8, x1, [x0]
0065CBB90  mov      x0, x24
0065CBB94  blr      x8
0065CBB98  mov      w25, w0
0065CBB9C  cmp      w0, #4
0065CBBA0  b.ne     #0x65cbd2c
0065CBBA4  ldrb     w8, [x26, #0x286]
0065CBBA8  cbnz     w8, #0x65cbbc0
0065CBBAC  adrp     x0, #0x8f07000
0065CBBB0  ldr      x0, [x0, #0xc98]
0065CBBB4  bl       #0x382bd14 ; 
0065CBBB8  mov      w8, #1
0065CBBBC  strb     w8, [x26, #0x286]
0065CBBC0  ldr      x1, [x20]
0065CBBC4  ldrb     w8, [x1, #0x53]
0065CBBC8  tbnz     w8, #5, #0x65cbbd4
0065CBBCC  ldr      x0, [x19, #0x80]
0065CBBD0  b        #0x65cbbe0 ; 
0065CBBD4  ldr      x8, [x1, #0x60]
0065CBBD8  mov      x0, x19
0065CBBDC  blr      x8
0065CBBE0  cbz      x0, #0x65cc058
0065CBBE4  ldr      w8, [x0, #0x1c8]
0065CBBE8  cmp      w8, #2
0065CBBEC  b.ne     #0x65cbd2c
0065CBBF0  ldrb     w8, [x26, #0x286]
0065CBBF4  cbnz     w8, #0x65cbc0c
0065CBBF8  adrp     x0, #0x8f07000
0065CBBFC  ldr      x0, [x0, #0xc98]
0065CBC00  bl       #0x382bd14 ; 
0065CBC04  mov      w8, #1
0065CBC08  strb     w8, [x26, #0x286]
0065CBC0C  ldr      x1, [x20]
0065CBC10  ldrb     w8, [x1, #0x53]
0065CBC14  tbnz     w8, #5, #0x65cbc20
0065CBC18  ldr      x0, [x19, #0x80]
0065CBC1C  b        #0x65cbc2c ; 
0065CBC20  ldr      x8, [x1, #0x60]
0065CBC24  mov      x0, x19
0065CBC28  blr      x8
0065CBC2C  cbz      x0, #0x65cc058
0065CBC30  mov      x1, xzr
0065CBC34  bl       #0x6a0fcc4 ; HotFix.BattleLogic.BattleWorldContext$$DispatchAccelerateMapMovement
0065CBC38  ldrb     w8, [x26, #0x286]
0065CBC3C  cbnz     w8, #0x65cbc54
0065CBC40  adrp     x0, #0x8f07000
0065CBC44  ldr      x0, [x0, #0xc98]
0065CBC48  bl       #0x382bd14 ; 
0065CBC4C  mov      w8, #1
0065CBC50  strb     w8, [x26, #0x286]
0065CBC54  ldr      x1, [x20]
0065CBC58  ldrb     w8, [x1, #0x53]
0065CBC5C  tbnz     w8, #5, #0x65cbc68
0065CBC60  ldr      x0, [x19, #0x80]
0065CBC64  b        #0x65cbc74 ; 
0065CBC68  ldr      x8, [x1, #0x60]
0065CBC6C  mov      x0, x19
0065CBC70  blr      x8
0065CBC74  ldr      x9, [x19, #0x88]
0065CBC78  cbz      x9, #0x65cc058
0065CBC7C  str      x28, [sp, #0x18]
0065CBC80  adrp     x8, #0x8ee6000
0065CBC84  ldr      x8, [x8, #0xd8]
0065CBC88  stp      x9, x0, [sp, #8]
0065CBC8C  ldr      x1, [x8]
0065CBC90  ldrb     w8, [x1, #0x53]
0065CBC94  tbnz     w8, #5, #0x65cbca0
0065CBC98  ldr      x28, [x9, #0x38]
0065CBC9C  b        #0x65cbcb0 ; 
0065CBCA0  ldr      x8, [x1, #0x60]
0065CBCA4  mov      x0, x9
0065CBCA8  blr      x8
0065CBCAC  mov      x28, x0
0065CBCB0  cbz      x28, #0x65cc058
0065CBCB4  adrp     x8, #0x9591000
0065CBCB8  ldrb     w8, [x8, #0xa7f]
0065CBCBC  cbnz     w8, #0x65cbcd8
0065CBCC0  adrp     x0, #0x8ee6000
0065CBCC4  ldr      x0, [x0, #0x2d8]
0065CBCC8  bl       #0x382bd14 ; 
0065CBCCC  mov      w8, #1
0065CBCD0  adrp     x9, #0x9591000
0065CBCD4  strb     w8, [x9, #0xa7f]
0065CBCD8  adrp     x8, #0x8ee6000
0065CBCDC  ldr      x8, [x8, #0x2d8]
0065CBCE0  ldr      x1, [x8]
0065CBCE4  ldrb     w8, [x1, #0x53]
0065CBCE8  tbnz     w8, #5, #0x65cbcf4
0065CBCEC  ldr      x2, [x28, #0x178]
0065CBCF0  b        #0x65cbd04 ; 
0065CBCF4  ldr      x8, [x1, #0x60]
0065CBCF8  mov      x0, x28
0065CBCFC  blr      x8
0065CBD00  mov      x2, x0
0065CBD04  ldp      x0, x28, [sp, #0x10]
0065CBD08  cbz      x0, #0x65cc058
0065CBD0C  ldr      x3, [x19, #0x88]
0065CBD10  ldr      x1, [sp, #8]
0065CBD14  mov      w4, #0xd
0065CBD18  mov      w5, #0x10000
0065CBD1C  mov      w6, wzr
0065CBD20  mov      w7, wzr
0065CBD24  str      xzr, [sp]
0065CBD28  bl       #0x6a0d17c ; HotFix.BattleLogic.BattleWorldContext$$AddBuffToEntity
0065CBD2C  cmp      w21, w25
0065CBD30  b.ne     #0x65cbf68
0065CBD34  mov      w25, #1
0065CBD38  ldr      w8, [x19, #0x134]
0065CBD3C  cmn      w8, #1
0065CBD40  b.ne     #0x65cbd48
0065CBD44  str      w23, [x19, #0x134]
0065CBD48  mov      x0, x19
0065CBD4C  mov      x1, x24
0065CBD50  str      w23, [x19, #0x138]
0065CBD54  bl       #0x65d0c70 ; HotFix.BattleLogic.WaterfallBattleManager$$CalSpecialMonsterCount
0065CBD58  cbz      x24, #0x65cc058
0065CBD5C  ldr      x8, [x24]
0065CBD60  ldr      x1, [x29]
0065CBD64  ldrh     w9, [x8, #0x12e]
0065CBD68  cbz      x9, #0x65cbd8c
0065CBD6C  ldr      x10, [x8, #0xb0]
0065CBD70  add      x10, x10, #8
0065CBD74  ldur     x11, [x10, #-8]
0065CBD78  cmp      x11, x1
0065CBD7C  b.eq     #0x65cbd9c
0065CBD80  subs     x9, x9, #1
0065CBD84  add      x10, x10, #0x10
0065CBD88  b.ne     #0x65cbd74
0065CBD8C  mov      w2, #8
0065CBD90  mov      x0, x24
0065CBD94  bl       #0x3a7e710 ; 
0065CBD98  b        #0x65cbdac ; 
0065CBD9C  ldr      w9, [x10]
0065CBDA0  add      w9, w9, #8
0065CBDA4  add      x8, x8, w9, sxtw #4
0065CBDA8  add      x0, x8, #0x138
0065CBDAC  ldp      x8, x1, [x0]
0065CBDB0  mov      x0, x24
0065CBDB4  blr      x8
0065CBDB8  cbz      w0, #0x65cbe20
0065CBDBC  ldr      x8, [x24]
0065CBDC0  ldr      x1, [x29]
0065CBDC4  ldrh     w9, [x8, #0x12e]
0065CBDC8  cbz      x9, #0x65cbdec
0065CBDCC  ldr      x10, [x8, #0xb0]
0065CBDD0  add      x10, x10, #8
0065CBDD4  ldur     x11, [x10, #-8]
0065CBDD8  cmp      x11, x1
0065CBDDC  b.eq     #0x65cbdfc
0065CBDE0  subs     x9, x9, #1
0065CBDE4  add      x10, x10, #0x10
0065CBDE8  b.ne     #0x65cbdd4
0065CBDEC  mov      w2, #8
0065CBDF0  mov      x0, x24
0065CBDF4  bl       #0x3a7e710 ; 
0065CBDF8  b        #0x65cbe0c ; 
0065CBDFC  ldr      w9, [x10]
0065CBE00  add      w9, w9, #8
0065CBE04  add      x8, x8, w9, sxtw #4
0065CBE08  add      x0, x8, #0x138
0065CBE0C  ldp      x8, x1, [x0]
0065CBE10  mov      x0, x24
0065CBE14  blr      x8
0065CBE18  cmp      w0, #2
0065CBE1C  b.ne     #0x65cbe30
0065CBE20  ldr      w8, [x19, #0x13c]
0065CBE24  cmn      w8, #1
0065CBE28  b.ne     #0x65cbe30
0065CBE2C  str      w23, [x19, #0x13c]
0065CBE30  ldrb     w8, [x26, #0x286]
0065CBE34  cbnz     w8, #0x65cbe44
0065CBE38  mov      x0, x20
0065CBE3C  bl       #0x382bd14 ; 
0065CBE40  strb     w25, [x26, #0x286]
0065CBE44  ldr      x1, [x20]
0065CBE48  ldrb     w8, [x1, #0x53]
0065CBE4C  tbnz     w8, #5, #0x65cbe58
0065CBE50  ldr      x24, [x19, #0x80]
0065CBE54  b        #0x65cbe68 ; 
0065CBE58  ldr      x8, [x1, #0x60]
0065CBE5C  mov      x0, x19
0065CBE60  blr      x8
0065CBE64  mov      x24, x0
0065CBE68  cbz      x24, #0x65cc058
0065CBE6C  ldrb     w8, [x27, #0xfcc]
0065CBE70  cbnz     w8, #0x65cbe80
0065CBE74  mov      x0, x22
0065CBE78  bl       #0x382bd14 ; 
0065CBE7C  strb     w25, [x27, #0xfcc]
0065CBE80  ldr      x1, [x22]
0065CBE84  ldrb     w8, [x1, #0x53]
0065CBE88  tbnz     w8, #5, #0x65cbe94
0065CBE8C  ldr      x24, [x24, #0x200]
0065CBE90  b        #0x65cbea4 ; 
0065CBE94  ldr      x8, [x1, #0x60]
0065CBE98  mov      x0, x24
0065CBE9C  blr      x8
0065CBEA0  mov      x24, x0
0065CBEA4  ldrb     w8, [x26, #0x286]
0065CBEA8  cbnz     w8, #0x65cbeb8
0065CBEAC  mov      x0, x20
0065CBEB0  bl       #0x382bd14 ; 
0065CBEB4  strb     w25, [x26, #0x286]
0065CBEB8  ldr      x1, [x20]
0065CBEBC  ldrb     w8, [x1, #0x53]
0065CBEC0  tbnz     w8, #5, #0x65cbecc
0065CBEC4  ldr      x0, [x19, #0x80]
0065CBEC8  b        #0x65cbed8 ; 
0065CBECC  ldr      x8, [x1, #0x60]
0065CBED0  mov      x0, x19
0065CBED4  blr      x8
0065CBED8  cbz      x0, #0x65cc058
0065CBEDC  ldr      w1, [x0, #0x1c8]
0065CBEE0  add      w23, w23, #1
0065CBEE4  mov      x0, x24
0065CBEE8  mov      w2, w23
0065CBEEC  mov      x3, xzr
0065CBEF0  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065CBEF4  mov      x24, x0
0065CBEF8  cbz      x0, #0x65cbf3c
0065CBEFC  ldr      x8, [x24]
0065CBF00  ldr      x1, [x29]
0065CBF04  ldrh     w9, [x8, #0x12e]
0065CBF08  cbz      x9, #0x65cbf2c
0065CBF0C  ldr      x10, [x8, #0xb0]
0065CBF10  add      x10, x10, #8
0065CBF14  ldur     x11, [x10, #-8]
0065CBF18  cmp      x11, x1
0065CBF1C  b.eq     #0x65cbf44
0065CBF20  subs     x9, x9, #1
0065CBF24  add      x10, x10, #0x10
0065CBF28  b.ne     #0x65cbf14
0065CBF2C  mov      w2, #2
0065CBF30  mov      x0, x24
0065CBF34  bl       #0x3a7e710 ; 
0065CBF38  b        #0x65cbf54 ; 
0065CBF3C  mov      w0, #-1
0065CBF40  b        #0x65cbf60 ; 
0065CBF44  ldr      w9, [x10]
0065CBF48  add      w9, w9, #2
0065CBF4C  add      x8, x8, w9, sxtw #4
0065CBF50  add      x0, x8, #0x138
0065CBF54  ldp      x8, x1, [x0]
0065CBF58  mov      x0, x24
0065CBF5C  blr      x8
0065CBF60  cmp      w21, w0
0065CBF64  b.eq     #0x65cbd38
0065CBF68  ldr      x20, [x28]
0065CBF6C  cbz      x20, #0x65cc058
0065CBF70  adrp     x21, #0x9599000
0065CBF74  ldrb     w8, [x21, #0x658]
0065CBF78  cbnz     w8, #0x65cbf90
0065CBF7C  adrp     x0, #0x8f0a000
0065CBF80  ldr      x0, [x0, #0x810]
0065CBF84  bl       #0x382bd14 ; 
0065CBF88  mov      w8, #1
0065CBF8C  strb     w8, [x21, #0x658]
0065CBF90  adrp     x22, #0x8f0a000
0065CBF94  ldr      x22, [x22, #0x810]
0065CBF98  ldr      x1, [x22]
0065CBF9C  ldrb     w8, [x1, #0x53]
0065CBFA0  tbnz     w8, #5, #0x65cbfac
0065CBFA4  ldr      w0, [x20, #0x28]
0065CBFA8  b        #0x65cbfb8 ; 
0065CBFAC  ldr      x8, [x1, #0x60]
0065CBFB0  mov      x0, x20
0065CBFB4  blr      x8
0065CBFB8  cmp      w0, #1
0065CBFBC  b.lt     #0x65cc034
0065CBFC0  ldr      x20, [x28]
0065CBFC4  cbz      x20, #0x65cc058
0065CBFC8  ldrb     w8, [x21, #0x658]
0065CBFCC  cbnz     w8, #0x65cbfe4
0065CBFD0  adrp     x0, #0x8f0a000
0065CBFD4  ldr      x0, [x0, #0x810]
0065CBFD8  bl       #0x382bd14 ; 
0065CBFDC  mov      w8, #1
0065CBFE0  strb     w8, [x21, #0x658]
0065CBFE4  ldr      x1, [x22]
0065CBFE8  ldrb     w8, [x1, #0x53]
0065CBFEC  tbnz     w8, #5, #0x65cbff8
0065CBFF0  ldr      w0, [x20, #0x28]
0065CBFF4  b        #0x65cc004 ; 
0065CBFF8  ldr      x8, [x1, #0x60]
0065CBFFC  mov      x0, x20
0065CC000  blr      x8
0065CC004  ldrsw    x8, [x19, #0x150]
0065CC008  add      x20, x19, #0x158
0065CC00C  cbz      w8, #0x65cc01c
0065CC010  sbfiz    x9, x0, #0x10, #0x20
0065CC014  sdiv     x1, x9, x8
0065CC018  b        #0x65cc020 ; 
0065CC01C  mov      x1, xzr
0065CC020  mov      w0, #0x10000
0065CC024  mov      x2, xzr
0065CC028  str      x1, [x20]
0065CC02C  bl       #0x7d46f68 ; Photon.Deterministic.FPMath$$Max
0065CC030  str      x0, [x20]
0065CC034  mov      x0, x19
0065CC038  ldp      x20, x19, [sp, #0x70]
0065CC03C  ldp      x22, x21, [sp, #0x60]
0065CC040  ldp      x24, x23, [sp, #0x50]
0065CC044  ldp      x26, x25, [sp, #0x40]
0065CC048  ldp      x28, x27, [sp, #0x30]
0065CC04C  ldp      x29, x30, [sp, #0x20]
0065CC050  add      sp, sp, #0x80
0065CC054  b        #0x65d0ec0 ; HotFix.BattleLogic.WaterfallBattleManager$$InitWaveGoldData
0065CC058  bl       #0x382bfb8 ; 

