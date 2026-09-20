; HotFix.BattleLogic.SinglePlayerBattleManager$$OnHeroInteractWithNpc
; RVA 0x65C1C84; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C1C84  stp      x30, x21, [sp, #-0x20]!
0065C1C88  stp      x20, x19, [sp, #0x10]
0065C1C8C  adrp     x20, #0x9599000
0065C1C90  adrp     x21, #0x8f0a000
0065C1C94  ldrb     w8, [x20, #0x554]
0065C1C98  ldr      x21, [x21, #0x420] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.OnHeroInteractWithNpc() @ 0x92aa8b8
0065C1C9C  mov      x19, x0
0065C1CA0  tbnz     w8, #0, #0x65c1cc4
0065C1CA4  adrp     x0, #0x8f07000
0065C1CA8  ldr      x0, [x0, #0xdd0] ; GLOBAL HotFix.BattleLogic.EnterPunchboardParam_TypeInfo @ 0x91e5a48
0065C1CAC  bl       #0x382bd14 ; 
0065C1CB0  adrp     x0, #0x8f0a000
0065C1CB4  ldr      x0, [x0, #0x420] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.OnHeroInteractWithNpc() @ 0x92aa8b8
0065C1CB8  bl       #0x382bd14 ; 
0065C1CBC  mov      w8, #1
0065C1CC0  strb     w8, [x20, #0x554]
0065C1CC4  ldr      x1, [x21]
0065C1CC8  ldrb     w8, [x1, #0x53]
0065C1CCC  tbnz     w8, #5, #0x65c1d08
0065C1CD0  ldr      x8, [x19, #0x98]
0065C1CD4  cbz      x8, #0x65c1dac
0065C1CD8  ldr      w8, [x8, #0x624]
0065C1CDC  sub      w8, w8, #1
0065C1CE0  cmp      w8, #9
0065C1CE4  b.hi     #0x65c1d24
0065C1CE8  adrp     x9, #0x1a71000
0065C1CEC  add      x9, x9, #0xfc7
0065C1CF0  adr      x10, #0x65c1d00
0065C1CF4  ldrb     w11, [x9, x8]
0065C1CF8  add      x10, x10, x11, lsl #2
0065C1CFC  br       x10
0065C1D00  mov      w1, #7
0065C1D04  b        #0x65c1d90 ; 
0065C1D08  ldr      x2, [x1, #0x60]
0065C1D0C  mov      x0, x19
0065C1D10  ldp      x20, x19, [sp, #0x10]
0065C1D14  ldp      x30, x21, [sp], #0x20
0065C1D18  br       x2
0065C1D1C  mov      w1, #9
0065C1D20  b        #0x65c1d90 ; 
0065C1D24  ldp      x20, x19, [sp, #0x10]
0065C1D28  ldp      x30, x21, [sp], #0x20
0065C1D2C  ret      
0065C1D30  mov      w1, #4
0065C1D34  b        #0x65c1d90 ; 
0065C1D38  mov      w1, #5
0065C1D3C  b        #0x65c1d90 ; 
0065C1D40  mov      w1, #6
0065C1D44  b        #0x65c1d90 ; 
0065C1D48  adrp     x8, #0x8f07000
0065C1D4C  ldr      x8, [x8, #0xdd0] ; GLOBAL HotFix.BattleLogic.EnterPunchboardParam_TypeInfo @ 0x91e5a48
0065C1D50  ldr      x0, [x8]
0065C1D54  bl       #0x382bfa0 ; 
0065C1D58  mov      x1, xzr
0065C1D5C  mov      x20, x0
0065C1D60  bl       #0x65a5738 ; HotFix.BattleLogic.EnterPunchboardParam$$.ctor
0065C1D64  ldr      x8, [x19, #0x98]
0065C1D68  cbz      x8, #0x65c1dac
0065C1D6C  cbz      x20, #0x65c1dac
0065C1D70  ldr      w8, [x8, #0x644]
0065C1D74  mov      w1, #0xb
0065C1D78  mov      w3, #1
0065C1D7C  mov      x0, x19
0065C1D80  str      w8, [x20, #0x14]
0065C1D84  mov      x2, x20
0065C1D88  b        #0x65c1d9c ; 
0065C1D8C  mov      w1, #0xa
0065C1D90  mov      w3, #1
0065C1D94  mov      x0, x19
0065C1D98  mov      x2, xzr
0065C1D9C  ldp      x20, x19, [sp, #0x10]
0065C1DA0  mov      x4, xzr
0065C1DA4  ldp      x30, x21, [sp], #0x20
0065C1DA8  b        #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
0065C1DAC  bl       #0x382bfb8 ; 

