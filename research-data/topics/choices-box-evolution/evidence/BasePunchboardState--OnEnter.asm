; HotFix.BattleLogic.BasePunchboardState$$OnEnter
; RVA 0x659F00C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659F00C  str      x30, [sp, #-0x30]!
00659F010  stp      x22, x21, [sp, #0x10]
00659F014  stp      x20, x19, [sp, #0x20]
00659F018  adrp     x21, #0x9599000
00659F01C  adrp     x22, #0x8f09000
00659F020  ldrb     w8, [x21, #0x334]
00659F024  ldr      x22, [x22, #0x48] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.OnEnter() @ 0x923b6b0
00659F028  mov      x20, x1
00659F02C  mov      x19, x0
00659F030  tbnz     w8, #0, #0x659f060
00659F034  adrp     x0, #0x8f09000
00659F038  ldr      x0, [x0, #0x48] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.OnEnter() @ 0x923b6b0
00659F03C  bl       #0x382bd14 ; 
00659F040  adrp     x0, #0x8f07000
00659F044  ldr      x0, [x0, #0xdd0] ; GLOBAL HotFix.BattleLogic.EnterPunchboardParam_TypeInfo @ 0x91e5a48
00659F048  bl       #0x382bd14 ; 
00659F04C  adrp     x0, #0x8f09000
00659F050  ldr      x0, [x0, #0x50] ; GLOBAL HotFix.BattleLogic.PlayerPunchboard_TypeInfo @ 0x91ee028
00659F054  bl       #0x382bd14 ; 
00659F058  mov      w8, #1
00659F05C  strb     w8, [x21, #0x334]
00659F060  ldr      x2, [x22]
00659F064  ldrb     w8, [x2, #0x53]
00659F068  tbnz     w8, #5, #0x659f0d4
00659F06C  cbz      x20, #0x659f0f0
00659F070  adrp     x8, #0x8f07000
00659F074  ldr      x8, [x8, #0xdd0] ; GLOBAL HotFix.BattleLogic.EnterPunchboardParam_TypeInfo @ 0x91e5a48
00659F078  ldr      x9, [x20]
00659F07C  ldr      x1, [x8]
00659F080  ldrb     w10, [x9, #0x130]
00659F084  ldrb     w8, [x1, #0x130]
00659F088  cmp      w10, w8
00659F08C  b.lo     #0x659f0cc
00659F090  ldr      x10, [x9, #0xc8]
00659F094  sub      x9, x8, #1
00659F098  ldr      x10, [x10, x9, lsl #3]
00659F09C  cmp      x10, x1
00659F0A0  b.ne     #0x659f0cc
00659F0A4  mov      x0, x19
00659F0A8  str      x20, [x0, #0x20]!
00659F0AC  ldr      x10, [x20]
00659F0B0  ldrb     w11, [x10, #0x130]
00659F0B4  cmp      w11, w8
00659F0B8  b.lo     #0x659f0cc
00659F0BC  ldr      x8, [x10, #0xc8]
00659F0C0  ldr      x8, [x8, x9, lsl #3]
00659F0C4  cmp      x8, x1
00659F0C8  b.eq     #0x659f0f8
00659F0CC  mov      x0, x20
00659F0D0  bl       #0x382c354 ; 
00659F0D4  ldr      x3, [x2, #0x60]
00659F0D8  mov      x0, x19
00659F0DC  mov      x1, x20
00659F0E0  ldp      x20, x19, [sp, #0x20]
00659F0E4  ldp      x22, x21, [sp, #0x10]
00659F0E8  ldr      x30, [sp], #0x30
00659F0EC  br       x3
00659F0F0  mov      x0, x19
00659F0F4  str      x20, [x0, #0x20]!
00659F0F8  mov      x1, x20
00659F0FC  bl       #0x382bcb8 ; 
00659F100  adrp     x21, #0x9599000
00659F104  ldrb     w8, [x21, #0x4b1]
00659F108  ldr      x20, [x19, #0x18]
00659F10C  cbnz     w8, #0x659f124
00659F110  adrp     x0, #0x8f08000
00659F114  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659F118  bl       #0x382bd14 ; 
00659F11C  mov      w8, #1
00659F120  strb     w8, [x21, #0x4b1]
00659F124  adrp     x8, #0x8f08000
00659F128  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659F12C  ldr      x1, [x8]
00659F130  ldrb     w8, [x1, #0x53]
00659F134  tbnz     w8, #5, #0x659f140
00659F138  ldr      x21, [x19, #0x10]
00659F13C  b        #0x659f150 ; 
00659F140  ldr      x8, [x1, #0x60]
00659F144  mov      x0, x19
00659F148  blr      x8
00659F14C  mov      x21, x0
00659F150  adrp     x8, #0x8f09000
00659F154  ldr      x8, [x8, #0x50] ; GLOBAL HotFix.BattleLogic.PlayerPunchboard_TypeInfo @ 0x91ee028
00659F158  ldr      x0, [x8]
00659F15C  bl       #0x382bfa0 ; 
00659F160  mov      x1, x20
00659F164  mov      x2, x21
00659F168  mov      x22, x0
00659F16C  bl       #0x659f1dc ; HotFix.BattleLogic.PlayerPunchboard$$.ctor
00659F170  mov      x20, x19
00659F174  str      x22, [x20, #0x28]!
00659F178  mov      x0, x20
00659F17C  mov      x1, x22
00659F180  bl       #0x382bcb8 ; 
00659F184  ldr      x0, [x20]
00659F188  cbz      x0, #0x659f1d8
00659F18C  bl       #0x659f280 ; HotFix.BattleLogic.PlayerPunchboard$$Init
00659F190  ldr      x8, [x19]
00659F194  ldr      x20, [x19, #0x28]
00659F198  mov      x0, x19
00659F19C  ldp      x9, x1, [x8, #0x1d8]
00659F1A0  blr      x9
00659F1A4  ldr      x8, [x19]
00659F1A8  mov      w21, w0
00659F1AC  mov      x0, x19
00659F1B0  ldp      x9, x1, [x8, #0x1c8]
00659F1B4  blr      x9
00659F1B8  cbz      x20, #0x659f1d8
00659F1BC  and      w2, w0, #1
00659F1C0  mov      x0, x20
00659F1C4  mov      w1, w21
00659F1C8  ldp      x20, x19, [sp, #0x20]
00659F1CC  ldp      x22, x21, [sp, #0x10]
00659F1D0  ldr      x30, [sp], #0x30
00659F1D4  b        #0x659f4c8 ; HotFix.BattleLogic.PlayerPunchboard$$Show
00659F1D8  bl       #0x382bfb8 ; 

