; HotFix.BattleLogic.BattleStarManager$$CheckAliveCount
; RVA 0x6595624; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006595624  str      x30, [sp, #-0x40]!
006595628  stp      x24, x23, [sp, #0x10]
00659562C  stp      x22, x21, [sp, #0x20]
006595630  stp      x20, x19, [sp, #0x30]
006595634  adrp     x20, #0x9599000
006595638  adrp     x22, #0x8f08000
00659563C  ldrb     w8, [x20, #0x2d7]
006595640  ldr      x22, [x22, #0xae0] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.CheckAliveCount() @ 0x923e918
006595644  mov      w21, w1
006595648  mov      x19, x0
00659564C  tbnz     w8, #0, #0x6595664
006595650  adrp     x0, #0x8f08000
006595654  ldr      x0, [x0, #0xae0] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.CheckAliveCount() @ 0x923e918
006595658  bl       #0x382bd14 ; 
00659565C  mov      w8, #1
006595660  strb     w8, [x20, #0x2d7]
006595664  ldr      x2, [x22]
006595668  ldrb     w8, [x2, #0x53]
00659566C  tbnz     w8, #5, #0x65956ac
006595670  ldr      x9, [x19, #0x18]
006595674  cbz      x9, #0x6595868
006595678  ldr      w8, [x9, #0x18]
00659567C  mov      x20, xzr
006595680  add      x23, x9, #0x2c
006595684  cmp      x20, x8
006595688  b.hs     #0x6595864
00659568C  ldur     w9, [x23, #-0xc]
006595690  cmp      w9, #3
006595694  b.eq     #0x65956cc
006595698  add      x20, x20, #1
00659569C  cmp      x20, #3
0065956A0  add      x23, x23, #0x10
0065956A4  b.ne     #0x6595684
0065956A8  b        #0x65957d4 ; 
0065956AC  ldr      x3, [x2, #0x60]
0065956B0  and      w1, w21, #1
0065956B4  mov      x0, x19
0065956B8  ldp      x20, x19, [sp, #0x30]
0065956BC  ldp      x22, x21, [sp, #0x20]
0065956C0  ldp      x24, x23, [sp, #0x10]
0065956C4  ldr      x30, [sp], #0x40
0065956C8  br       x3
0065956CC  ldr      w8, [x23]
0065956D0  cmp      w8, #1
0065956D4  b.ne     #0x6595794
0065956D8  adrp     x22, #0x9599000
0065956DC  ldrb     w8, [x22, #0x4aa]
0065956E0  cbnz     w8, #0x65956f8
0065956E4  adrp     x0, #0x8f08000
0065956E8  ldr      x0, [x0, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
0065956EC  bl       #0x382bd14 ; 
0065956F0  mov      w8, #1
0065956F4  strb     w8, [x22, #0x4aa]
0065956F8  adrp     x8, #0x8f08000
0065956FC  ldr      x8, [x8, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
006595700  ldr      x1, [x8]
006595704  ldrb     w8, [x1, #0x53]
006595708  tbnz     w8, #5, #0x6595714
00659570C  ldr      x22, [x19, #0x10]
006595710  b        #0x6595724 ; 
006595714  ldr      x8, [x1, #0x60]
006595718  mov      x0, x19
00659571C  blr      x8
006595720  mov      x22, x0
006595724  cbz      x22, #0x6595868
006595728  adrp     x24, #0x9599000
00659572C  ldrb     w8, [x24, #0x4af]
006595730  cbnz     w8, #0x6595748
006595734  adrp     x0, #0x8f08000
006595738  ldr      x0, [x0, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
00659573C  bl       #0x382bd14 ; 
006595740  mov      w8, #1
006595744  strb     w8, [x24, #0x4af]
006595748  adrp     x8, #0x8f08000
00659574C  ldr      x8, [x8, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
006595750  ldr      x1, [x8]
006595754  ldrb     w8, [x1, #0x53]
006595758  tbnz     w8, #5, #0x6595764
00659575C  ldr      w0, [x22, #0x2d0]
006595760  b        #0x6595770 ; 
006595764  ldr      x8, [x1, #0x60]
006595768  mov      x0, x22
00659576C  blr      x8
006595770  ldur     w8, [x23, #-8]
006595774  cmp      w0, w8
006595778  b.le     #0x6595794
00659577C  str      wzr, [x23]
006595780  tbz      w21, #0, #0x65957d4
006595784  mov      x0, x19
006595788  mov      w1, w20
00659578C  bl       #0x65961ac ; HotFix.BattleLogic.BattleStarManager$$SendStarHideEvent
006595790  b        #0x6595798 ; 
006595794  tbz      w21, #0, #0x65957d4
006595798  adrp     x21, #0x9599000
00659579C  ldrb     w8, [x21, #0x4aa]
0065957A0  cbnz     w8, #0x65957b8
0065957A4  adrp     x0, #0x8f08000
0065957A8  ldr      x0, [x0, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
0065957AC  bl       #0x382bd14 ; 
0065957B0  mov      w8, #1
0065957B4  strb     w8, [x21, #0x4aa]
0065957B8  adrp     x8, #0x8f08000
0065957BC  ldr      x8, [x8, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
0065957C0  ldr      x1, [x8]
0065957C4  ldrb     w8, [x1, #0x53]
0065957C8  tbnz     w8, #5, #0x65957e8
0065957CC  ldr      x21, [x19, #0x10]
0065957D0  b        #0x65957f8 ; 
0065957D4  ldp      x20, x19, [sp, #0x30]
0065957D8  ldp      x22, x21, [sp, #0x20]
0065957DC  ldp      x24, x23, [sp, #0x10]
0065957E0  ldr      x30, [sp], #0x40
0065957E4  ret      
0065957E8  ldr      x8, [x1, #0x60]
0065957EC  mov      x0, x19
0065957F0  blr      x8
0065957F4  mov      x21, x0
0065957F8  cbz      x21, #0x6595868
0065957FC  adrp     x22, #0x9599000
006595800  ldrb     w8, [x22, #0x4af]
006595804  cbnz     w8, #0x659581c
006595808  adrp     x0, #0x8f08000
00659580C  ldr      x0, [x0, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
006595810  bl       #0x382bd14 ; 
006595814  mov      w8, #1
006595818  strb     w8, [x22, #0x4af]
00659581C  adrp     x8, #0x8f08000
006595820  ldr      x8, [x8, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
006595824  ldr      x1, [x8]
006595828  ldrb     w8, [x1, #0x53]
00659582C  tbnz     w8, #5, #0x6595838
006595830  ldr      w2, [x21, #0x2d0]
006595834  b        #0x6595848 ; 
006595838  ldr      x8, [x1, #0x60]
00659583C  mov      x0, x21
006595840  blr      x8
006595844  mov      w2, w0
006595848  mov      x0, x19
00659584C  mov      w1, w20
006595850  ldp      x20, x19, [sp, #0x30]
006595854  ldp      x22, x21, [sp, #0x20]
006595858  ldp      x24, x23, [sp, #0x10]
00659585C  ldr      x30, [sp], #0x40
006595860  b        #0x6595f90 ; HotFix.BattleLogic.BattleStarManager$$SendUpdateStarEvent
006595864  bl       #0x382bfc0 ; 
006595868  bl       #0x382bfb8 ; 

