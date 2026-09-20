; HotFix.BattleLogic.PunchboardGameplayCustomTable$$.cctor
; RVA 0x65BD2CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BD2CC  sub      sp, sp, #0x1f0
0065BD2D0  stp      x29, x30, [sp, #0x1c0]
0065BD2D4  stp      x22, x21, [sp, #0x1d0]
0065BD2D8  stp      x20, x19, [sp, #0x1e0]
0065BD2DC  adrp     x22, #0x9599000
0065BD2E0  adrp     x20, #0x8f0a000
0065BD2E4  adrp     x21, #0x8f0a000
0065BD2E8  adrp     x19, #0x8f0a000
0065BD2EC  ldrb     w8, [x22, #0x497]
0065BD2F0  ldr      x20, [x20, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD2F4  ldr      x21, [x21, #0x108] ; GLOBAL System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>_TypeInfo @ 0x91d1cf0
0065BD2F8  ldr      x19, [x19, #0x110] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>..ctor() @ 0x920b400
0065BD2FC  tbnz     w8, #0, #0x65bd338
0065BD300  adrp     x0, #0x8f0a000
0065BD304  ldr      x0, [x0, #0x118] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>.Add() @ 0x920b408
0065BD308  bl       #0x382bd14 ; 
0065BD30C  adrp     x0, #0x8f0a000
0065BD310  ldr      x0, [x0, #0x110] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>..ctor() @ 0x920b400
0065BD314  bl       #0x382bd14 ; 
0065BD318  adrp     x0, #0x8f0a000
0065BD31C  ldr      x0, [x0, #0x108] ; GLOBAL System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>_TypeInfo @ 0x91d1cf0
0065BD320  bl       #0x382bd14 ; 
0065BD324  adrp     x0, #0x8f0a000
0065BD328  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD32C  bl       #0x382bd14 ; 
0065BD330  mov      w8, #1
0065BD334  strb     w8, [x22, #0x497]
0065BD338  add      x8, sp, #0x180
0065BD33C  bl       #0x65bcd7c ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateDefaultRule
0065BD340  ldr      x8, [sp, #0x1b0]
0065BD344  ldp      q1, q0, [sp, #0x190]
0065BD348  ldr      q2, [sp, #0x180]
0065BD34C  ldr      x9, [x20]
0065BD350  str      x8, [sp, #0x170]
0065BD354  stp      q1, q0, [sp, #0x150]
0065BD358  str      q2, [sp, #0x140]
0065BD35C  ldr      x9, [x9, #0xb8]
0065BD360  str      x8, [x9, #0x30]
0065BD364  add      x8, sp, #0x180
0065BD368  stp      q1, q0, [x9, #0x10]
0065BD36C  str      q2, [x9]
0065BD370  bl       #0x65bcf6c ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateAroundPlayerRule
0065BD374  ldr      x8, [sp, #0x1b0]
0065BD378  ldp      q1, q0, [sp, #0x190]
0065BD37C  ldr      q2, [sp, #0x180]
0065BD380  ldr      x9, [x20]
0065BD384  str      x8, [sp, #0x130]
0065BD388  stp      q1, q0, [sp, #0x110]
0065BD38C  str      q2, [sp, #0x100]
0065BD390  ldr      x9, [x9, #0xb8]
0065BD394  str      x8, [x9, #0x68]
0065BD398  add      x8, sp, #0x180
0065BD39C  stur     q0, [x9, #0x58]
0065BD3A0  stur     q1, [x9, #0x48]
0065BD3A4  stur     q2, [x9, #0x38]
0065BD3A8  bl       #0x65bd044 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateScreenTopMoveRule
0065BD3AC  ldr      x8, [sp, #0x1b0]
0065BD3B0  ldp      q1, q0, [sp, #0x190]
0065BD3B4  ldr      q2, [sp, #0x180]
0065BD3B8  ldr      x9, [x20]
0065BD3BC  str      x8, [sp, #0xf0]
0065BD3C0  stp      q1, q0, [sp, #0xd0]
0065BD3C4  str      q2, [sp, #0xc0]
0065BD3C8  ldr      x9, [x9, #0xb8]
0065BD3CC  str      x8, [x9, #0xa0]
0065BD3D0  add      x8, sp, #0x180
0065BD3D4  stp      q1, q0, [x9, #0x80]
0065BD3D8  str      q2, [x9, #0x70]
0065BD3DC  bl       #0x65bd11c ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateMissionNpcMoveRule
0065BD3E0  ldr      x8, [sp, #0x1b0]
0065BD3E4  ldp      q1, q0, [sp, #0x190]
0065BD3E8  ldr      q2, [sp, #0x180]
0065BD3EC  ldr      x9, [x20]
0065BD3F0  str      x8, [sp, #0xb0]
0065BD3F4  stp      q1, q0, [sp, #0x90]
0065BD3F8  str      q2, [sp, #0x80]
0065BD3FC  ldr      x9, [x9, #0xb8]
0065BD400  str      x8, [x9, #0xd8]
0065BD404  add      x8, sp, #0x180
0065BD408  stur     q0, [x9, #0xc8]
0065BD40C  stur     q1, [x9, #0xb8]
0065BD410  stur     q2, [x9, #0xa8]
0065BD414  bl       #0x65bd1f4 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateAroundPlayerMoveRule
0065BD418  ldr      x8, [sp, #0x1b0]
0065BD41C  ldp      q1, q0, [sp, #0x190]
0065BD420  ldr      q2, [sp, #0x180]
0065BD424  ldr      x9, [x20]
0065BD428  str      x8, [sp, #0x70]
0065BD42C  stp      q1, q0, [sp, #0x50]
0065BD430  str      q2, [sp, #0x40]
0065BD434  ldr      x9, [x9, #0xb8]
0065BD438  stp      q1, q0, [x9, #0xf0]
0065BD43C  str      x8, [x9, #0x110]
0065BD440  str      q2, [x9, #0xe0]
0065BD444  ldr      x0, [x21]
0065BD448  bl       #0x382bfa0 ; 
0065BD44C  ldr      x1, [x19]
0065BD450  mov      x19, x0
0065BD454  bl       #0x5e62530 ; System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>$$.ctor
0065BD458  ldr      x8, [x20]
0065BD45C  ldr      x8, [x8, #0xb8]
0065BD460  ldr      x9, [x8, #0x68]
0065BD464  ldur     q0, [x8, #0x58]
0065BD468  ldur     q1, [x8, #0x38]
0065BD46C  ldur     q2, [x8, #0x48]
0065BD470  str      x9, [sp, #0x30]
0065BD474  str      q1, [sp]
0065BD478  stp      q2, q0, [sp, #0x10]
0065BD47C  cbz      x19, #0x65bd518
0065BD480  adrp     x21, #0x8f0a000
0065BD484  ldr      x21, [x21, #0x118] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>.Add() @ 0x920b408
0065BD488  ldp      q0, q1, [sp]
0065BD48C  ldr      q2, [sp, #0x20]
0065BD490  ldr      x8, [sp, #0x30]
0065BD494  ldr      x3, [x21]
0065BD498  add      x2, sp, #0x180
0065BD49C  mov      w1, #6
0065BD4A0  mov      x0, x19
0065BD4A4  stp      q0, q1, [sp, #0x180]
0065BD4A8  str      q2, [sp, #0x1a0]
0065BD4AC  str      x8, [sp, #0x1b0]
0065BD4B0  bl       #0x5e634ac ; System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>$$Add
0065BD4B4  ldr      x8, [x20]
0065BD4B8  ldr      x3, [x21]
0065BD4BC  add      x2, sp, #0x180
0065BD4C0  mov      w1, #7
0065BD4C4  ldr      x8, [x8, #0xb8]
0065BD4C8  mov      x0, x19
0065BD4CC  ldr      x9, [x8, #0x68]
0065BD4D0  ldur     q0, [x8, #0x58]
0065BD4D4  ldur     q1, [x8, #0x48]
0065BD4D8  ldur     q2, [x8, #0x38]
0065BD4DC  str      x9, [sp, #0x1b0]
0065BD4E0  stp      q1, q0, [sp, #0x190]
0065BD4E4  str      q2, [sp, #0x180]
0065BD4E8  bl       #0x5e634ac ; System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>$$Add
0065BD4EC  ldr      x8, [x20]
0065BD4F0  mov      x1, x19
0065BD4F4  ldr      x8, [x8, #0xb8]
0065BD4F8  add      x0, x8, #0x118
0065BD4FC  str      x19, [x8, #0x118]
0065BD500  bl       #0x382bcb8 ; 
0065BD504  ldp      x20, x19, [sp, #0x1e0]
0065BD508  ldp      x22, x21, [sp, #0x1d0]
0065BD50C  ldp      x29, x30, [sp, #0x1c0]
0065BD510  add      sp, sp, #0x1f0
0065BD514  ret      
0065BD518  bl       #0x382bfb8 ; 

