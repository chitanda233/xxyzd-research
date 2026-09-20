; HotFix.BattleLogic.BattleManager$$CreatePunchboardNpc
; RVA 0x6592348; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006592348  sub      sp, sp, #0x90
00659234C  str      x30, [sp, #0x50]
006592350  stp      x24, x23, [sp, #0x60]
006592354  stp      x22, x21, [sp, #0x70]
006592358  stp      x20, x19, [sp, #0x80]
00659235C  mrs      x22, tpidr_el0
006592360  ldr      x8, [x22, #0x28]
006592364  adrp     x21, #0x9599000
006592368  adrp     x23, #0x8f08000
00659236C  mov      x20, x1
006592370  str      x8, [sp, #0x48]
006592374  ldrb     w8, [x21, #0x24d]
006592378  ldr      x23, [x23, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.CreatePunchboardNpc() @ 0x923cb40
00659237C  mov      x19, x0
006592380  tbnz     w8, #0, #0x6592398
006592384  adrp     x0, #0x8f08000
006592388  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.CreatePunchboardNpc() @ 0x923cb40
00659238C  bl       #0x382bd14 ; 
006592390  mov      w8, #1
006592394  strb     w8, [x21, #0x24d]
006592398  ldr      x2, [x23]
00659239C  ldrb     w8, [x2, #0x53]
0065923A0  tbnz     w8, #5, #0x65923e0
0065923A4  adrp     x23, #0x9599000
0065923A8  ldrb     w8, [x23, #0x286]
0065923AC  cbnz     w8, #0x65923c4
0065923B0  adrp     x0, #0x8f07000
0065923B4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065923B8  bl       #0x382bd14 ; 
0065923BC  mov      w8, #1
0065923C0  strb     w8, [x23, #0x286]
0065923C4  adrp     x24, #0x8f07000
0065923C8  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065923CC  ldr      x1, [x24]
0065923D0  ldrb     w8, [x1, #0x53]
0065923D4  tbnz     w8, #5, #0x6592404
0065923D8  ldr      x21, [x19, #0x80]
0065923DC  b        #0x6592414 ; 
0065923E0  ldr      x8, [x2, #0x60]
0065923E4  mov      x0, x19
0065923E8  mov      x1, x20
0065923EC  blr      x8
0065923F0  ldr      x8, [x22, #0x28]
0065923F4  ldr      x9, [sp, #0x48]
0065923F8  cmp      x8, x9
0065923FC  b.eq     #0x6592514
006592400  b        #0x6592530 ; 
006592404  ldr      x8, [x1, #0x60]
006592408  mov      x0, x19
00659240C  blr      x8
006592410  mov      x21, x0
006592414  add      x8, sp, #0x18
006592418  mov      x0, x19
00659241C  bl       #0x6592534 ; HotFix.BattleLogic.BattleManager$$GetPunchboardSpawnPos
006592420  ldur     q0, [sp, #0x18]
006592424  ldr      x8, [sp, #0x28]
006592428  str      q0, [sp, #0x30]
00659242C  str      x8, [sp, #0x40]
006592430  cbz      x21, #0x659252c
006592434  ldr      q0, [sp, #0x30]
006592438  ldr      x8, [sp, #0x40]
00659243C  mov      x4, sp
006592440  mov      w1, #8
006592444  mov      w2, #8
006592448  mov      x0, x21
00659244C  mov      w3, wzr
006592450  mov      x5, x20
006592454  mov      x6, xzr
006592458  str      q0, [sp]
00659245C  str      x8, [sp, #0x10]
006592460  bl       #0x6a16550 ; HotFix.BattleLogic.BattleWorldContext$$CreateNpc
006592464  ldrb     w8, [x23, #0x286]
006592468  mov      x20, x0
00659246C  cbnz     w8, #0x6592484
006592470  adrp     x0, #0x8f07000
006592474  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006592478  bl       #0x382bd14 ; 
00659247C  mov      w8, #1
006592480  strb     w8, [x23, #0x286]
006592484  ldr      x1, [x24]
006592488  ldrb     w8, [x1, #0x53]
00659248C  tbnz     w8, #5, #0x6592498
006592490  ldr      x19, [x19, #0x80]
006592494  b        #0x65924a8 ; 
006592498  ldr      x8, [x1, #0x60]
00659249C  mov      x0, x19
0065924A0  blr      x8
0065924A4  mov      x19, x0
0065924A8  cbz      x19, #0x659252c
0065924AC  adrp     x21, #0x9599000
0065924B0  ldrb     w8, [x21, #0x2c3]
0065924B4  cbnz     w8, #0x65924cc
0065924B8  adrp     x0, #0x8f08000
0065924BC  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionId() @ 0x923fe90
0065924C0  bl       #0x382bd14 ; 
0065924C4  mov      w8, #1
0065924C8  strb     w8, [x21, #0x2c3]
0065924CC  adrp     x8, #0x8f08000
0065924D0  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionId() @ 0x923fe90
0065924D4  ldr      x1, [x8]
0065924D8  ldrb     w8, [x1, #0x53]
0065924DC  tbnz     w8, #5, #0x65924ec
0065924E0  add      x0, x19, #0x290
0065924E4  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065924E8  b        #0x65924f8 ; 
0065924EC  ldr      x8, [x1, #0x60]
0065924F0  mov      x0, x19
0065924F4  blr      x8
0065924F8  cbz      x20, #0x659252c
0065924FC  str      w0, [x20, #0x644]
006592500  ldr      x8, [x22, #0x28]
006592504  ldr      x9, [sp, #0x48]
006592508  cmp      x8, x9
00659250C  b.ne     #0x6592530
006592510  mov      x0, x20
006592514  ldp      x20, x19, [sp, #0x80]
006592518  ldp      x22, x21, [sp, #0x70]
00659251C  ldp      x24, x23, [sp, #0x60]
006592520  ldr      x30, [sp, #0x50]
006592524  add      sp, sp, #0x90
006592528  ret      
00659252C  bl       #0x382bfb8 ; 
006592530  bl       #0x89edb60 ; 

