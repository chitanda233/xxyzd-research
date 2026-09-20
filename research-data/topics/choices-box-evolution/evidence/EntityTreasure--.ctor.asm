; HotFix.BattleLogic.EntityTreasure$$.ctor
; RVA 0x68D35F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D35F0  stp      x30, x21, [sp, #-0x20]!
0068D35F4  stp      x20, x19, [sp, #0x10]
0068D35F8  adrp     x20, #0x959c000
0068D35FC  adrp     x21, #0x8f28000
0068D3600  ldrb     w8, [x20, #0x778]
0068D3604  ldr      x21, [x21, #0x898] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure..ctor() @ 0x9264408
0068D3608  mov      x19, x0
0068D360C  tbnz     w8, #0, #0x68d3630
0068D3610  adrp     x0, #0x8ee6000
0068D3614  ldr      x0, [x0, #0xf8] ; GLOBAL HotFix.BattleLogic.EntityCharacter_TypeInfo @ 0x91e5a90
0068D3618  bl       #0x382bd14 ; 
0068D361C  adrp     x0, #0x8f28000
0068D3620  ldr      x0, [x0, #0x898] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure..ctor() @ 0x9264408
0068D3624  bl       #0x382bd14 ; 
0068D3628  mov      w8, #1
0068D362C  strb     w8, [x20, #0x778]
0068D3630  ldr      x1, [x21]
0068D3634  ldrb     w8, [x1, #0x53]
0068D3638  tbnz     w8, #5, #0x68d3668
0068D363C  adrp     x8, #0x8ee6000
0068D3640  ldr      x8, [x8, #0xf8] ; GLOBAL HotFix.BattleLogic.EntityCharacter_TypeInfo @ 0x91e5a90
0068D3644  ldr      x0, [x8]
0068D3648  ldr      w8, [x0, #0xe0]
0068D364C  cbnz     w8, #0x68d3654
0068D3650  bl       #0x382be8c ; 
0068D3654  mov      x0, x19
0068D3658  ldp      x20, x19, [sp, #0x10]
0068D365C  mov      x1, xzr
0068D3660  ldp      x30, x21, [sp], #0x20
0068D3664  b        #0x6804954 ; HotFix.BattleLogic.EntityCharacter$$.ctor
0068D3668  ldr      x2, [x1, #0x60]
0068D366C  mov      x0, x19
0068D3670  ldp      x20, x19, [sp, #0x10]
0068D3674  ldp      x30, x21, [sp], #0x20
0068D3678  br       x2

