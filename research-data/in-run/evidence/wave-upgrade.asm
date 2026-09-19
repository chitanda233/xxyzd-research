; HotFix.BattleLogic.WaterfallBattleManager$$OnProgressFinish
; RVA 0x65CC838; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CC838  stp      x30, x25, [sp, #-0x40]!
0065CC83C  stp      x24, x23, [sp, #0x10]
0065CC840  stp      x22, x21, [sp, #0x20]
0065CC844  stp      x20, x19, [sp, #0x30]
0065CC848  adrp     x20, #0x9599000
0065CC84C  adrp     x21, #0x8f0a000
0065CC850  ldrb     w8, [x20, #0x57d]
0065CC854  ldr      x21, [x21, #0x878]
0065CC858  mov      x19, x0
0065CC85C  tbnz     w8, #0, #0x65cc88c
0065CC860  adrp     x0, #0x8f09000
0065CC864  ldr      x0, [x0, #0x540]
0065CC868  bl       #0x382bd14 ; 
0065CC86C  adrp     x0, #0x8f09000
0065CC870  ldr      x0, [x0, #0x548]
0065CC874  bl       #0x382bd14 ; 
0065CC878  adrp     x0, #0x8f0a000
0065CC87C  ldr      x0, [x0, #0x878]
0065CC880  bl       #0x382bd14 ; 
0065CC884  mov      w8, #1
0065CC888  strb     w8, [x20, #0x57d]
0065CC88C  ldr      x1, [x21]
0065CC890  ldrb     w8, [x1, #0x53]
0065CC894  tbnz     w8, #5, #0x65cc8d0
0065CC898  ldr      x8, [x19, #0x1e8]
0065CC89C  cbz      x8, #0x65cccf8
0065CC8A0  ldr      x9, [x8, #0x18]
0065CC8A4  cbz      x9, #0x65cccf8
0065CC8A8  ldrsw    x10, [x19, #0x198]
0065CC8AC  cmp      w10, w9
0065CC8B0  b.ne     #0x65cc8ec
0065CC8B4  mov      x0, x19
0065CC8B8  ldp      x20, x19, [sp, #0x30]
0065CC8BC  ldp      x22, x21, [sp, #0x20]
0065CC8C0  ldp      x24, x23, [sp, #0x10]
0065CC8C4  mov      x1, xzr
0065CC8C8  ldp      x30, x25, [sp], #0x40
0065CC8CC  b        #0x6587478 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$WaterfallProgressFinishGoNext
0065CC8D0  ldr      x2, [x1, #0x60]
0065CC8D4  mov      x0, x19
0065CC8D8  ldp      x20, x19, [sp, #0x30]
0065CC8DC  ldp      x22, x21, [sp, #0x20]
0065CC8E0  ldp      x24, x23, [sp, #0x10]
0065CC8E4  ldp      x30, x25, [sp], #0x40
0065CC8E8  br       x2
0065CC8EC  cmp      w10, w9
0065CC8F0  b.hs     #0x65cced8
0065CC8F4  add      x8, x8, x10, lsl #2
0065CC8F8  ldr      w23, [x8, #0x20]
0065CC8FC  sub      w8, w23, #2
0065CC900  cmp      w8, #4
0065CC904  b.hi     #0x65cccf8
0065CC908  adrp     x9, #0x1a71000
0065CC90C  add      x9, x9, #0xfd8
0065CC910  adr      x10, #0x65cc920
0065CC914  ldrb     w11, [x9, x8]
0065CC918  add      x10, x10, x11, lsl #2
0065CC91C  br       x10
0065CC920  adrp     x22, #0x9599000
0065CC924  ldrb     w8, [x22, #0x286]
0065CC928  cbnz     w8, #0x65cc940
0065CC92C  adrp     x0, #0x8f07000
0065CC930  ldr      x0, [x0, #0xc98]
0065CC934  bl       #0x382bd14 ; 
0065CC938  mov      w8, #1
0065CC93C  strb     w8, [x22, #0x286]
0065CC940  adrp     x24, #0x8f07000
0065CC944  ldr      x24, [x24, #0xc98]
0065CC948  ldr      x1, [x24]
0065CC94C  ldrb     w8, [x1, #0x53]
0065CC950  tbnz     w8, #5, #0x65cc95c
0065CC954  ldr      x21, [x19, #0x80]
0065CC958  b        #0x65cc96c ; 
0065CC95C  ldr      x8, [x1, #0x60]
0065CC960  mov      x0, x19
0065CC964  blr      x8
0065CC968  mov      x21, x0
0065CC96C  cbz      x21, #0x65cced4
0065CC970  adrp     x8, #0x8f09000
0065CC974  ldr      x8, [x8, #0x540]
0065CC978  ldr      x20, [x8]
0065CC97C  ldr      x8, [x20, #0x38]
0065CC980  cbnz     x8, #0x65cc98c
0065CC984  mov      x0, x20
0065CC988  bl       #0x3a7e668 ; 
0065CC98C  ldrb     w8, [x20, #0x53]
0065CC990  tbnz     w8, #5, #0x65cc9d0
0065CC994  adrp     x25, #0x9591000
0065CC998  ldrb     w8, [x25, #0xa61]
0065CC99C  cbnz     w8, #0x65cc9b4
0065CC9A0  adrp     x0, #0x8ee6000
0065CC9A4  ldr      x0, [x0, #0x308]
0065CC9A8  bl       #0x382bd14 ; 
0065CC9AC  mov      w8, #1
0065CC9B0  strb     w8, [x25, #0xa61]
0065CC9B4  adrp     x8, #0x8ee6000
0065CC9B8  ldr      x8, [x8, #0x308]
0065CC9BC  ldr      x1, [x8]
0065CC9C0  ldrb     w8, [x1, #0x53]
0065CC9C4  tbnz     w8, #5, #0x65cca70
0065CC9C8  ldr      x0, [x21, #0x1e8]
0065CC9CC  b        #0x65cca7c ; 
0065CC9D0  ldr      x8, [x20, #0x60]
0065CC9D4  mov      x0, x21
0065CC9D8  mov      x1, x20
0065CC9DC  blr      x8
0065CC9E0  b        #0x65cca8c ; 
0065CC9E4  mov      x0, x19
0065CC9E8  bl       #0x65c8d70 ; HotFix.BattleLogic.WaterfallBattleManager$$CanRunUpLevelProgress
0065CC9EC  tbz      w0, #0, #0x65cccf8
0065CC9F0  adrp     x21, #0x9599000
0065CC9F4  ldrb     w8, [x21, #0x286]
0065CC9F8  cbnz     w8, #0x65cca10
0065CC9FC  adrp     x0, #0x8f07000
0065CCA00  ldr      x0, [x0, #0xc98]
0065CCA04  bl       #0x382bd14 ; 
0065CCA08  mov      w8, #1
0065CCA0C  strb     w8, [x21, #0x286]
0065CCA10  adrp     x23, #0x8f07000
0065CCA14  ldr      x23, [x23, #0xc98]
0065CCA18  ldr      x1, [x23]
0065CCA1C  ldrb     w8, [x1, #0x53]
0065CCA20  tbnz     w8, #5, #0x65ccbac
0065CCA24  ldr      x20, [x19, #0x80]
0065CCA28  b        #0x65ccbbc ; 
0065CCA2C  mov      x0, x19
0065CCA30  bl       #0x65ccedc ; HotFix.BattleLogic.WaterfallBattleManager$$TriggerBossNoticeStart
0065CCA34  adrp     x22, #0x9599000
0065CCA38  ldrb     w8, [x22, #0x286]
0065CCA3C  cbnz     w8, #0x65cca54
0065CCA40  adrp     x0, #0x8f07000
0065CCA44  ldr      x0, [x0, #0xc98]
0065CCA48  bl       #0x382bd14 ; 
0065CCA4C  mov      w8, #1
0065CCA50  strb     w8, [x22, #0x286]
0065CCA54  adrp     x23, #0x8f07000
0065CCA58  ldr      x23, [x23, #0xc98]
0065CCA5C  ldr      x1, [x23]
0065CCA60  ldrb     w8, [x1, #0x53]
0065CCA64  tbnz     w8, #5, #0x65ccb24
0065CCA68  ldr      x21, [x19, #0x80]
0065CCA6C  b        #0x65ccb34 ; 
0065CCA70  ldr      x8, [x1, #0x60]
0065CCA74  mov      x0, x21
0065CCA78  blr      x8
0065CCA7C  cbz      x0, #0x65cced4
0065CCA80  ldr      x8, [x20, #0x38]
0065CCA84  ldr      x1, [x8]
0065CCA88  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065CCA8C  mov      x20, x0
0065CCA90  cbz      x0, #0x65cced4
0065CCA94  str      w23, [x20, #0x20]
0065CCA98  ldrb     w8, [x22, #0x286]
0065CCA9C  cbnz     w8, #0x65ccab4
0065CCAA0  adrp     x0, #0x8f07000
0065CCAA4  ldr      x0, [x0, #0xc98]
0065CCAA8  bl       #0x382bd14 ; 
0065CCAAC  mov      w8, #1
0065CCAB0  strb     w8, [x22, #0x286]
0065CCAB4  ldr      x1, [x24]
0065CCAB8  ldrb     w8, [x1, #0x53]
0065CCABC  tbnz     w8, #5, #0x65ccac8
0065CCAC0  ldr      x0, [x19, #0x80]
0065CCAC4  b        #0x65ccad4 ; 
0065CCAC8  ldr      x8, [x1, #0x60]
0065CCACC  mov      x0, x19
0065CCAD0  blr      x8
0065CCAD4  cbz      x0, #0x65cced4
0065CCAD8  ldr      x21, [x0, #0x1e0]
0065CCADC  cbz      x21, #0x65cced4
0065CCAE0  adrp     x9, #0x8f09000
0065CCAE4  ldr      x9, [x9, #0x548]
0065CCAE8  ldr      x8, [x21]
0065CCAEC  ldr      x22, [x9]
0065CCAF0  ldrh     w9, [x8, #0x12e]
0065CCAF4  ldr      x1, [x22, #0x20]
0065CCAF8  ldrh     w2, [x22, #0x50]
0065CCAFC  cbz      x9, #0x65cccb0
0065CCB00  ldr      x10, [x8, #0xb0]
0065CCB04  add      x10, x10, #8
0065CCB08  ldur     x11, [x10, #-8]
0065CCB0C  cmp      x11, x1
0065CCB10  b.eq     #0x65cccbc
0065CCB14  subs     x9, x9, #1
0065CCB18  add      x10, x10, #0x10
0065CCB1C  b.ne     #0x65ccb08
0065CCB20  b        #0x65cccb0 ; 
0065CCB24  ldr      x8, [x1, #0x60]
0065CCB28  mov      x0, x19
0065CCB2C  blr      x8
0065CCB30  mov      x21, x0
0065CCB34  cbz      x21, #0x65cced4
0065CCB38  adrp     x8, #0x8f09000
0065CCB3C  ldr      x8, [x8, #0x540]
0065CCB40  ldr      x20, [x8]
0065CCB44  ldr      x8, [x20, #0x38]
0065CCB48  cbnz     x8, #0x65ccb54
0065CCB4C  mov      x0, x20
0065CCB50  bl       #0x3a7e668 ; 
0065CCB54  ldrb     w8, [x20, #0x53]
0065CCB58  tbnz     w8, #5, #0x65ccb98
0065CCB5C  adrp     x24, #0x9591000
0065CCB60  ldrb     w8, [x24, #0xa61]
0065CCB64  cbnz     w8, #0x65ccb7c
0065CCB68  adrp     x0, #0x8ee6000
0065CCB6C  ldr      x0, [x0, #0x308]
0065CCB70  bl       #0x382bd14 ; 
0065CCB74  mov      w8, #1
0065CCB78  strb     w8, [x24, #0xa61]
0065CCB7C  adrp     x8, #0x8ee6000
0065CCB80  ldr      x8, [x8, #0x308]
0065CCB84  ldr      x1, [x8]
0065CCB88  ldrb     w8, [x1, #0x53]
0065CCB8C  tbnz     w8, #5, #0x65ccbfc
0065CCB90  ldr      x0, [x21, #0x1e8]
0065CCB94  b        #0x65ccc08 ; 
0065CCB98  ldr      x8, [x20, #0x60]
0065CCB9C  mov      x0, x21
0065CCBA0  mov      x1, x20
0065CCBA4  blr      x8
0065CCBA8  b        #0x65ccc18 ; 
0065CCBAC  ldr      x8, [x1, #0x60]
0065CCBB0  mov      x0, x19
0065CCBB4  blr      x8
0065CCBB8  mov      x20, x0
0065CCBBC  cbz      x20, #0x65cced4
0065CCBC0  adrp     x22, #0x9599000
0065CCBC4  ldrb     w8, [x22, #0x287]
0065CCBC8  cbnz     w8, #0x65ccbe0
0065CCBCC  adrp     x0, #0x8f07000
0065CCBD0  ldr      x0, [x0, #0xcf0]
0065CCBD4  bl       #0x382bd14 ; 
0065CCBD8  mov      w8, #1
0065CCBDC  strb     w8, [x22, #0x287]
0065CCBE0  adrp     x24, #0x8f07000
0065CCBE4  ldr      x24, [x24, #0xcf0]
0065CCBE8  ldr      x1, [x24]
0065CCBEC  ldrb     w8, [x1, #0x53]
0065CCBF0  tbnz     w8, #5, #0x65ccd0c
0065CCBF4  ldr      x0, [x20, #0x350]
0065CCBF8  b        #0x65ccd18 ; 
0065CCBFC  ldr      x8, [x1, #0x60]
0065CCC00  mov      x0, x21
0065CCC04  blr      x8
0065CCC08  cbz      x0, #0x65cced4
0065CCC0C  ldr      x8, [x20, #0x38]
0065CCC10  ldr      x1, [x8]
0065CCC14  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065CCC18  mov      x20, x0
0065CCC1C  cbz      x0, #0x65cced4
0065CCC20  mov      w8, #2
0065CCC24  str      w8, [x20, #0x20]
0065CCC28  ldrb     w8, [x22, #0x286]
0065CCC2C  cbnz     w8, #0x65ccc44
0065CCC30  adrp     x0, #0x8f07000
0065CCC34  ldr      x0, [x0, #0xc98]
0065CCC38  bl       #0x382bd14 ; 
0065CCC3C  mov      w8, #1
0065CCC40  strb     w8, [x22, #0x286]
0065CCC44  ldr      x1, [x23]
0065CCC48  ldrb     w8, [x1, #0x53]
0065CCC4C  tbnz     w8, #5, #0x65ccc58
0065CCC50  ldr      x0, [x19, #0x80]
0065CCC54  b        #0x65ccc64 ; 
0065CCC58  ldr      x8, [x1, #0x60]
0065CCC5C  mov      x0, x19
0065CCC60  blr      x8
0065CCC64  cbz      x0, #0x65cced4
0065CCC68  ldr      x21, [x0, #0x1e0]
0065CCC6C  cbz      x21, #0x65cced4
0065CCC70  adrp     x9, #0x8f09000
0065CCC74  ldr      x9, [x9, #0x548]
0065CCC78  ldr      x8, [x21]
0065CCC7C  ldr      x22, [x9]
0065CCC80  ldrh     w9, [x8, #0x12e]
0065CCC84  ldr      x1, [x22, #0x20]
0065CCC88  ldrh     w2, [x22, #0x50]
0065CCC8C  cbz      x9, #0x65cccb0
0065CCC90  ldr      x10, [x8, #0xb0]
0065CCC94  add      x10, x10, #8
0065CCC98  ldur     x11, [x10, #-8]
0065CCC9C  cmp      x11, x1
0065CCCA0  b.eq     #0x65cccbc
0065CCCA4  subs     x9, x9, #1
0065CCCA8  add      x10, x10, #0x10
0065CCCAC  b.ne     #0x65ccc98
0065CCCB0  mov      x0, x21
0065CCCB4  bl       #0x3a7e710 ; 
0065CCCB8  b        #0x65ccccc ; 
0065CCCBC  ldr      w9, [x10]
0065CCCC0  add      w9, w9, w2
0065CCCC4  add      x8, x8, w9, sxtw #4
0065CCCC8  add      x0, x8, #0x138
0065CCCCC  ldr      x0, [x0, #8]
0065CCCD0  mov      x1, x22
0065CCCD4  bl       #0x382be88 ; 
0065CCCD8  ldr      x8, [x0, #8]
0065CCCDC  mov      x2, x0
0065CCCE0  mov      x0, x21
0065CCCE4  mov      x1, x20
0065CCCE8  blr      x8
0065CCCEC  ldr      w8, [x19, #0x198]
0065CCCF0  add      w8, w8, #1
0065CCCF4  str      w8, [x19, #0x198]
0065CCCF8  ldp      x20, x19, [sp, #0x30]
0065CCCFC  ldp      x22, x21, [sp, #0x20]
0065CCD00  ldp      x24, x23, [sp, #0x10]
0065CCD04  ldp      x30, x25, [sp], #0x40
0065CCD08  ret      
0065CCD0C  ldr      x8, [x1, #0x60]
0065CCD10  mov      x0, x20
0065CCD14  blr      x8
0065CCD18  cbz      x0, #0x65cced4
0065CCD1C  mov      x1, xzr
0065CCD20  bl       #0x666fea8 ; HotFix.BattleLogic.DropMgr$$HasEquip
0065CCD24  tbnz     w0, #0, #0x65ccdcc
0065CCD28  ldrb     w8, [x21, #0x286]
0065CCD2C  cbnz     w8, #0x65ccd44
0065CCD30  adrp     x0, #0x8f07000
0065CCD34  ldr      x0, [x0, #0xc98]
0065CCD38  bl       #0x382bd14 ; 
0065CCD3C  mov      w8, #1
0065CCD40  strb     w8, [x21, #0x286]
0065CCD44  ldr      x1, [x23]
0065CCD48  ldrb     w8, [x1, #0x53]
0065CCD4C  tbnz     w8, #5, #0x65ccd58
0065CCD50  ldr      x20, [x19, #0x80]
0065CCD54  b        #0x65ccd68 ; 
0065CCD58  ldr      x8, [x1, #0x60]
0065CCD5C  mov      x0, x19
0065CCD60  blr      x8
0065CCD64  mov      x20, x0
0065CCD68  cbz      x20, #0x65cced4
0065CCD6C  ldrb     w8, [x22, #0x287]
0065CCD70  cbnz     w8, #0x65ccd88
0065CCD74  adrp     x0, #0x8f07000
0065CCD78  ldr      x0, [x0, #0xcf0]
0065CCD7C  bl       #0x382bd14 ; 
0065CCD80  mov      w8, #1
0065CCD84  strb     w8, [x22, #0x287]
0065CCD88  ldr      x1, [x24]
0065CCD8C  ldrb     w8, [x1, #0x53]
0065CCD90  tbnz     w8, #5, #0x65ccd9c
0065CCD94  ldr      x0, [x20, #0x350]
0065CCD98  b        #0x65ccda8 ; 
0065CCD9C  ldr      x8, [x1, #0x60]
0065CCDA0  mov      x0, x20
0065CCDA4  blr      x8
0065CCDA8  cbz      x0, #0x65cced4
0065CCDAC  mov      x1, xzr
0065CCDB0  bl       #0x666fd64 ; HotFix.BattleLogic.DropMgr$$HaveDropExp
0065CCDB4  tbnz     w0, #0, #0x65ccdcc
0065CCDB8  ldr      x0, [x19, #0x90]
0065CCDBC  cbz      x0, #0x65cced4
0065CCDC0  mov      x1, xzr
0065CCDC4  bl       #0x6851208 ; HotFix.BattleLogic.ExpAnimProcessor$$IsAdding
0065CCDC8  tbz      w0, #0, #0x65cce64
0065CCDCC  ldrb     w8, [x21, #0x286]
0065CCDD0  cbnz     w8, #0x65ccde8
0065CCDD4  adrp     x0, #0x8f07000
0065CCDD8  ldr      x0, [x0, #0xc98]
0065CCDDC  bl       #0x382bd14 ; 
0065CCDE0  mov      w8, #1
0065CCDE4  strb     w8, [x21, #0x286]
0065CCDE8  ldr      x1, [x23]
0065CCDEC  ldrb     w8, [x1, #0x53]
0065CCDF0  tbnz     w8, #5, #0x65ccdfc
0065CCDF4  ldr      x20, [x19, #0x80]
0065CCDF8  b        #0x65cce0c ; 
0065CCDFC  ldr      x8, [x1, #0x60]
0065CCE00  mov      x0, x19
0065CCE04  blr      x8
0065CCE08  mov      x20, x0
0065CCE0C  cbz      x20, #0x65cced4
0065CCE10  ldrb     w8, [x22, #0x287]
0065CCE14  cbnz     w8, #0x65cce2c
0065CCE18  adrp     x0, #0x8f07000
0065CCE1C  ldr      x0, [x0, #0xcf0]
0065CCE20  bl       #0x382bd14 ; 
0065CCE24  mov      w8, #1
0065CCE28  strb     w8, [x22, #0x287]
0065CCE2C  ldr      x1, [x24]
0065CCE30  ldrb     w8, [x1, #0x53]
0065CCE34  tbnz     w8, #5, #0x65cce40
0065CCE38  ldr      x0, [x20, #0x350]
0065CCE3C  b        #0x65cce4c ; 
0065CCE40  ldr      x8, [x1, #0x60]
0065CCE44  mov      x0, x20
0065CCE48  blr      x8
0065CCE4C  cbz      x0, #0x65cced4
0065CCE50  mov      x1, xzr
0065CCE54  bl       #0x666ff78 ; HotFix.BattleLogic.DropMgr$$AbsorbAll
0065CCE58  mov      w8, #1
0065CCE5C  strb     w8, [x19, #0x1d4]
0065CCE60  b        #0x65cccf8 ; 
0065CCE64  ldr      x0, [x19, #0x90]
0065CCE68  cbz      x0, #0x65cced4
0065CCE6C  mov      x1, xzr
0065CCE70  bl       #0x68510f8 ; HotFix.BattleLogic.ExpAnimProcessor$$IsIdle
0065CCE74  tbz      w0, #0, #0x65cce84
0065CCE78  ldr      w8, [x19, #0x1cc]
0065CCE7C  cbnz     w8, #0x65cce9c
0065CCE80  b        #0x65cceb8 ; 
0065CCE84  ldr      x0, [x19, #0x90]
0065CCE88  cbz      x0, #0x65cced4
0065CCE8C  mov      x1, xzr
0065CCE90  bl       #0x6850f28 ; HotFix.BattleLogic.ExpAnimProcessor$$CanLevelUp
0065CCE94  ldr      w8, [x19, #0x1cc]
0065CCE98  cbz      w8, #0x65cceb4
0065CCE9C  mov      x0, x19
0065CCEA0  ldp      x20, x19, [sp, #0x30]
0065CCEA4  ldp      x22, x21, [sp, #0x20]
0065CCEA8  ldp      x24, x23, [sp, #0x10]
0065CCEAC  ldp      x30, x25, [sp], #0x40
0065CCEB0  b        #0x65c8e98 ; HotFix.BattleLogic.WaterfallBattleManager$$QueueSelectSkill
0065CCEB4  tbnz     w0, #0, #0x65cccf8
0065CCEB8  ldr      w8, [x19, #0x198]
0065CCEBC  ldr      x9, [x19]
0065CCEC0  add      w8, w8, #1
0065CCEC4  str      w8, [x19, #0x198]
0065CCEC8  ldr      x2, [x9, #0x288]
0065CCECC  ldr      x1, [x9, #0x290]
0065CCED0  b        #0x65cc8d4 ; 
0065CCED4  bl       #0x382bfb8 ; 
0065CCED8  bl       #0x382bfc0 ; 

