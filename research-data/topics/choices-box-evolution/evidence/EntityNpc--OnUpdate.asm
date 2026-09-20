; HotFix.BattleLogic.EntityNpc$$OnUpdate
; RVA 0x68D2FBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D2FBC  str      x30, [sp, #-0x30]!
0068D2FC0  stp      x22, x21, [sp, #0x10]
0068D2FC4  stp      x20, x19, [sp, #0x20]
0068D2FC8  adrp     x21, #0x959c000
0068D2FCC  adrp     x22, #0x8f28000
0068D2FD0  ldrb     w8, [x21, #0x771]
0068D2FD4  ldr      x22, [x22, #0x858] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnUpdate() @ 0x9263dc8
0068D2FD8  mov      x20, x1
0068D2FDC  mov      x19, x0
0068D2FE0  tbnz     w8, #0, #0x68d2ff8
0068D2FE4  adrp     x0, #0x8f28000
0068D2FE8  ldr      x0, [x0, #0x858] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnUpdate() @ 0x9263dc8
0068D2FEC  bl       #0x382bd14 ; 
0068D2FF0  mov      w8, #1
0068D2FF4  strb     w8, [x21, #0x771]
0068D2FF8  ldr      x2, [x22]
0068D2FFC  ldrb     w8, [x2, #0x53]
0068D3000  tbnz     w8, #5, #0x68d3030
0068D3004  ldr      x8, [x19, #0x638]
0068D3008  cmp      x8, #1
0068D300C  b.lt     #0x68d3020
0068D3010  sub      x8, x8, x20
0068D3014  cmp      x8, #0
0068D3018  str      x8, [x19, #0x638]
0068D301C  b.le     #0x68d304c
0068D3020  ldp      x20, x19, [sp, #0x20]
0068D3024  ldp      x22, x21, [sp, #0x10]
0068D3028  ldr      x30, [sp], #0x30
0068D302C  ret      
0068D3030  ldr      x3, [x2, #0x60]
0068D3034  mov      x0, x19
0068D3038  mov      x1, x20
0068D303C  ldp      x20, x19, [sp, #0x20]
0068D3040  ldp      x22, x21, [sp, #0x10]
0068D3044  ldr      x30, [sp], #0x30
0068D3048  br       x3
0068D304C  adrp     x20, #0x9591000
0068D3050  ldrb     w8, [x20, #0xa4b]
0068D3054  cbnz     w8, #0x68d306c
0068D3058  adrp     x0, #0x8ee5000
0068D305C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D3060  bl       #0x382bd14 ; 
0068D3064  mov      w8, #1
0068D3068  strb     w8, [x20, #0xa4b]
0068D306C  adrp     x8, #0x8ee5000
0068D3070  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D3074  ldr      x1, [x8]
0068D3078  ldrb     w8, [x1, #0x53]
0068D307C  tbnz     w8, #5, #0x68d3088
0068D3080  ldr      x20, [x19, #0x20]
0068D3084  b        #0x68d3098 ; 
0068D3088  ldr      x8, [x1, #0x60]
0068D308C  mov      x0, x19
0068D3090  blr      x8
0068D3094  mov      x20, x0
0068D3098  cbz      x20, #0x68d30fc
0068D309C  adrp     x21, #0x9598000
0068D30A0  ldrb     w8, [x21, #0xfc4]
0068D30A4  cbnz     w8, #0x68d30bc
0068D30A8  adrp     x0, #0x8f05000
0068D30AC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0068D30B0  bl       #0x382bd14 ; 
0068D30B4  mov      w8, #1
0068D30B8  strb     w8, [x21, #0xfc4]
0068D30BC  adrp     x8, #0x8f05000
0068D30C0  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0068D30C4  ldr      x1, [x8]
0068D30C8  ldrb     w8, [x1, #0x53]
0068D30CC  tbnz     w8, #5, #0x68d30d8
0068D30D0  ldr      x0, [x20, #0x220]
0068D30D4  b        #0x68d30e4 ; 
0068D30D8  ldr      x8, [x1, #0x60]
0068D30DC  mov      x0, x20
0068D30E0  blr      x8
0068D30E4  cbz      x0, #0x68d30fc
0068D30E8  ldr      x8, [x0]
0068D30EC  mov      x1, x19
0068D30F0  ldr      x3, [x8, #0x3b8]
0068D30F4  ldr      x2, [x8, #0x3c0]
0068D30F8  b        #0x68d303c ; 
0068D30FC  bl       #0x382bfb8 ; 

