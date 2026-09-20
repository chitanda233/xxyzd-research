; HotFix.BattleLogic.WaterfallBattleManager$$CreatePunchboardNpc
; RVA 0x65CD7C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CD7C4  stp      x30, x21, [sp, #-0x20]!
0065CD7C8  stp      x20, x19, [sp, #0x10]
0065CD7CC  adrp     x20, #0x9599000
0065CD7D0  adrp     x21, #0x8f0a000
0065CD7D4  ldrb     w8, [x20, #0x59f]
0065CD7D8  ldr      x21, [x21, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreatePunchboardNpc() @ 0x92c8090
0065CD7DC  mov      x19, x0
0065CD7E0  tbnz     w8, #0, #0x65cd804
0065CD7E4  adrp     x0, #0x8ee8000
0065CD7E8  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065CD7EC  bl       #0x382bd14 ; 
0065CD7F0  adrp     x0, #0x8f0a000
0065CD7F4  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreatePunchboardNpc() @ 0x92c8090
0065CD7F8  bl       #0x382bd14 ; 
0065CD7FC  mov      w8, #1
0065CD800  strb     w8, [x20, #0x59f]
0065CD804  ldr      x1, [x21]
0065CD808  ldrb     w8, [x1, #0x53]
0065CD80C  tbnz     w8, #5, #0x65cd858
0065CD810  ldr      w8, [x19, #0x128]
0065CD814  adrp     x20, #0x9599000
0065CD818  add      w8, w8, #1
0065CD81C  str      w8, [x19, #0x128]
0065CD820  ldrb     w8, [x20, #0x286]
0065CD824  cbnz     w8, #0x65cd83c
0065CD828  adrp     x0, #0x8f07000
0065CD82C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065CD830  bl       #0x382bd14 ; 
0065CD834  mov      w8, #1
0065CD838  strb     w8, [x20, #0x286]
0065CD83C  adrp     x8, #0x8f07000
0065CD840  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065CD844  ldr      x1, [x8]
0065CD848  ldrb     w8, [x1, #0x53]
0065CD84C  tbnz     w8, #5, #0x65cd86c
0065CD850  ldr      x20, [x19, #0x80]
0065CD854  b        #0x65cd87c ; 
0065CD858  ldr      x2, [x1, #0x60]
0065CD85C  mov      x0, x19
0065CD860  ldp      x20, x19, [sp, #0x10]
0065CD864  ldp      x30, x21, [sp], #0x20
0065CD868  br       x2
0065CD86C  ldr      x8, [x1, #0x60]
0065CD870  mov      x0, x19
0065CD874  blr      x8
0065CD878  mov      x20, x0
0065CD87C  adrp     x21, #0x8ee8000
0065CD880  ldr      x21, [x21, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065CD884  ldr      x0, [x21]
0065CD888  ldr      w8, [x0, #0xe0]
0065CD88C  cbnz     w8, #0x65cd894
0065CD890  bl       #0x382be8c ; 
0065CD894  cbz      x20, #0x65cd8e8
0065CD898  ldr      x8, [x21]
0065CD89C  mov      x0, x20
0065CD8A0  mov      w1, wzr
0065CD8A4  mov      x3, xzr
0065CD8A8  ldr      x8, [x8, #0xb8]
0065CD8AC  ldr      w2, [x8, #0x330]
0065CD8B0  bl       #0x54b65d8 ; 
0065CD8B4  mov      x9, #0xf7cf
0065CD8B8  movk     x9, #0xe353, lsl #16
0065CD8BC  movk     x9, #0x9ba5, lsl #32
0065CD8C0  lsl      x8, x0, #0x20
0065CD8C4  movk     x9, #0x20c4, lsl #48
0065CD8C8  mov      x0, x19
0065CD8CC  ldp      x20, x19, [sp, #0x10]
0065CD8D0  smulh    x8, x8, x9
0065CD8D4  asr      x9, x8, #0x17
0065CD8D8  add      x1, x9, x8, lsr #63
0065CD8DC  mov      x2, xzr
0065CD8E0  ldp      x30, x21, [sp], #0x20
0065CD8E4  b        #0x6588be0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreatePunchboard
0065CD8E8  bl       #0x382bfb8 ; 

