; HotFix.BattleLogic.BattleStarManager$$CheckHpPercent
; RVA 0x659586C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659586C  str      x30, [sp, #-0x40]!
006595870  stp      x24, x23, [sp, #0x10]
006595874  stp      x22, x21, [sp, #0x20]
006595878  stp      x20, x19, [sp, #0x30]
00659587C  adrp     x21, #0x9599000
006595880  adrp     x22, #0x8f08000
006595884  ldrb     w8, [x21, #0x2d2]
006595888  ldr      x22, [x22, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.CheckHpPercent() @ 0x923e920
00659588C  mov      w20, w1
006595890  mov      x19, x0
006595894  tbnz     w8, #0, #0x65958ac
006595898  adrp     x0, #0x8f08000
00659589C  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.CheckHpPercent() @ 0x923e920
0065958A0  bl       #0x382bd14 ; 
0065958A4  mov      w8, #1
0065958A8  strb     w8, [x21, #0x2d2]
0065958AC  ldr      x2, [x22]
0065958B0  ldrb     w8, [x2, #0x53]
0065958B4  tbnz     w8, #5, #0x65958f4
0065958B8  adrp     x21, #0x9599000
0065958BC  ldrb     w8, [x21, #0x4aa]
0065958C0  cbnz     w8, #0x65958d8
0065958C4  adrp     x0, #0x8f08000
0065958C8  ldr      x0, [x0, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
0065958CC  bl       #0x382bd14 ; 
0065958D0  mov      w8, #1
0065958D4  strb     w8, [x21, #0x4aa]
0065958D8  adrp     x8, #0x8f08000
0065958DC  ldr      x8, [x8, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
0065958E0  ldr      x1, [x8]
0065958E4  ldrb     w8, [x1, #0x53]
0065958E8  tbnz     w8, #5, #0x6595914
0065958EC  ldr      x0, [x19, #0x10]
0065958F0  b        #0x6595920 ; 
0065958F4  ldr      x3, [x2, #0x60]
0065958F8  mov      x0, x19
0065958FC  mov      w1, w20
006595900  ldp      x20, x19, [sp, #0x30]
006595904  ldp      x22, x21, [sp, #0x20]
006595908  ldp      x24, x23, [sp, #0x10]
00659590C  ldr      x30, [sp], #0x40
006595910  br       x3
006595914  ldr      x8, [x1, #0x60]
006595918  mov      x0, x19
00659591C  blr      x8
006595920  cbz      x0, #0x65959f4
006595924  mov      w1, w20
006595928  mov      x2, xzr
00659592C  bl       #0x69ff9f4 ; HotFix.BattleLogic.BattleWorldContext$$GetPlayer
006595930  cbz      x0, #0x65959f4
006595934  mov      x1, xzr
006595938  bl       #0x453e438 ; 
00659593C  mov      x24, #0xd70b
006595940  movk     x24, #0x70a3, lsl #16
006595944  movk     x24, #0xa3d, lsl #32
006595948  mov      x20, x0
00659594C  mov      x23, xzr
006595950  mov      x21, xzr
006595954  lsr      x22, x0, #0x10
006595958  movk     x24, #0xa3d7, lsl #48
00659595C  ldr      x9, [x19, #0x18]
006595960  cbz      x9, #0x65959f4
006595964  ldr      w8, [x9, #0x18]
006595968  cmp      x21, x8
00659596C  b.hs     #0x65959f8
006595970  add      x8, x9, x23
006595974  ldr      w10, [x8, #0x20]
006595978  cmp      w10, #5
00659597C  b.ne     #0x65959d0
006595980  ldr      w10, [x8, #0x2c]
006595984  cmp      w10, #1
006595988  b.ne     #0x65959c0
00659598C  add      x9, x9, x23
006595990  ldr      w9, [x9, #0x24]
006595994  lsl      x10, x9, #0x20
006595998  smulh    x10, x10, x24
00659599C  add      x9, x10, x9, lsl #32
0065959A0  asr      x10, x9, #0x16
0065959A4  add      x9, x10, x9, lsr #63
0065959A8  cmp      x20, x9
0065959AC  b.ge     #0x65959c0
0065959B0  mov      x0, x19
0065959B4  mov      w1, w21
0065959B8  str      wzr, [x8, #0x2c]
0065959BC  bl       #0x65961ac ; HotFix.BattleLogic.BattleStarManager$$SendStarHideEvent
0065959C0  mov      x0, x19
0065959C4  mov      w1, w21
0065959C8  mov      w2, w22
0065959CC  bl       #0x6595f90 ; HotFix.BattleLogic.BattleStarManager$$SendUpdateStarEvent
0065959D0  add      x21, x21, #1
0065959D4  cmp      x21, #3
0065959D8  add      x23, x23, #0x10
0065959DC  b.ne     #0x659595c
0065959E0  ldp      x20, x19, [sp, #0x30]
0065959E4  ldp      x22, x21, [sp, #0x20]
0065959E8  ldp      x24, x23, [sp, #0x10]
0065959EC  ldr      x30, [sp], #0x40
0065959F0  ret      
0065959F4  bl       #0x382bfb8 ; 
0065959F8  bl       #0x382bfc0 ; 

