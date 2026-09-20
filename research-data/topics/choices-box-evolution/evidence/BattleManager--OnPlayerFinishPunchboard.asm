; HotFix.BattleLogic.BattleManager$$OnPlayerFinishPunchboard
; RVA 0x65937E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065937E8  str      x30, [sp, #-0x30]!
0065937EC  stp      x22, x21, [sp, #0x10]
0065937F0  stp      x20, x19, [sp, #0x20]
0065937F4  adrp     x21, #0x9599000
0065937F8  adrp     x22, #0x8f08000
0065937FC  ldrb     w8, [x21, #0x259]
006593800  ldr      x22, [x22, #0x958] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.OnPlayerFinishPunchboard() @ 0x923cc30
006593804  mov      w19, w1
006593808  mov      x20, x0
00659380C  tbnz     w8, #0, #0x6593824
006593810  adrp     x0, #0x8f08000
006593814  ldr      x0, [x0, #0x958] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.OnPlayerFinishPunchboard() @ 0x923cc30
006593818  bl       #0x382bd14 ; 
00659381C  mov      w8, #1
006593820  strb     w8, [x21, #0x259]
006593824  ldr      x2, [x22]
006593828  ldrb     w8, [x2, #0x53]
00659382C  tbnz     w8, #5, #0x659386c
006593830  adrp     x21, #0x9599000
006593834  ldrb     w8, [x21, #0x286]
006593838  cbnz     w8, #0x6593850
00659383C  adrp     x0, #0x8f07000
006593840  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006593844  bl       #0x382bd14 ; 
006593848  mov      w8, #1
00659384C  strb     w8, [x21, #0x286]
006593850  adrp     x8, #0x8f07000
006593854  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006593858  ldr      x1, [x8]
00659385C  ldrb     w8, [x1, #0x53]
006593860  tbnz     w8, #5, #0x6593888
006593864  ldr      x20, [x20, #0x80]
006593868  b        #0x6593898 ; 
00659386C  ldr      x3, [x2, #0x60]
006593870  mov      x0, x20
006593874  mov      w1, w19
006593878  ldp      x20, x19, [sp, #0x20]
00659387C  ldp      x22, x21, [sp, #0x10]
006593880  ldr      x30, [sp], #0x30
006593884  br       x3
006593888  ldr      x8, [x1, #0x60]
00659388C  mov      x0, x20
006593890  blr      x8
006593894  mov      x20, x0
006593898  cbz      x20, #0x659390c
00659389C  adrp     x21, #0x9598000
0065938A0  ldrb     w8, [x21, #0xfc4]
0065938A4  cbnz     w8, #0x65938bc
0065938A8  adrp     x0, #0x8f05000
0065938AC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065938B0  bl       #0x382bd14 ; 
0065938B4  mov      w8, #1
0065938B8  strb     w8, [x21, #0xfc4]
0065938BC  adrp     x8, #0x8f05000
0065938C0  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065938C4  ldr      x1, [x8]
0065938C8  ldrb     w8, [x1, #0x53]
0065938CC  tbnz     w8, #5, #0x65938d8
0065938D0  ldr      x0, [x20, #0x220]
0065938D4  b        #0x65938e4 ; 
0065938D8  ldr      x8, [x1, #0x60]
0065938DC  mov      x0, x20
0065938E0  blr      x8
0065938E4  cbz      x0, #0x659390c
0065938E8  ldr      x8, [x0]
0065938EC  mov      w1, w19
0065938F0  ldp      x20, x19, [sp, #0x20]
0065938F4  ldp      x22, x21, [sp, #0x10]
0065938F8  ldr      x4, [x8, #0x3c8]
0065938FC  ldr      x3, [x8, #0x3d0]
006593900  mov      w2, #1
006593904  ldr      x30, [sp], #0x30
006593908  br       x4
00659390C  bl       #0x382bfb8 ; 

