; HotFix.BattleLogic.BaseDropNpcState$$OnUpdate
; RVA 0x6598C98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006598C98  str      x30, [sp, #-0x30]!
006598C9C  stp      x22, x21, [sp, #0x10]
006598CA0  stp      x20, x19, [sp, #0x20]
006598CA4  adrp     x21, #0x9599000
006598CA8  adrp     x22, #0x8f08000
006598CAC  ldrb     w8, [x21, #0x2f4]
006598CB0  ldr      x22, [x22, #0xcc0] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnUpdate() @ 0x923b098
006598CB4  mov      x20, x1
006598CB8  mov      x19, x0
006598CBC  tbnz     w8, #0, #0x6598cd4
006598CC0  adrp     x0, #0x8f08000
006598CC4  ldr      x0, [x0, #0xcc0] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnUpdate() @ 0x923b098
006598CC8  bl       #0x382bd14 ; 
006598CCC  mov      w8, #1
006598CD0  strb     w8, [x21, #0x2f4]
006598CD4  ldr      x2, [x22]
006598CD8  ldrb     w8, [x2, #0x53]
006598CDC  tbnz     w8, #5, #0x6598d14
006598CE0  ldrb     w8, [x19, #0x21]
006598CE4  cbz      w8, #0x6598cf0
006598CE8  ldrb     w8, [x19, #0x23]
006598CEC  cbnz     w8, #0x6598cf8
006598CF0  ldrb     w8, [x19, #0x24]
006598CF4  cbz      w8, #0x6598d30
006598CF8  ldr      x8, [x19]
006598CFC  mov      x0, x19
006598D00  ldp      x20, x19, [sp, #0x20]
006598D04  ldp      x22, x21, [sp, #0x10]
006598D08  ldp      x2, x1, [x8, #0x1c8]
006598D0C  ldr      x30, [sp], #0x30
006598D10  br       x2
006598D14  ldr      x3, [x2, #0x60]
006598D18  mov      x0, x19
006598D1C  mov      x1, x20
006598D20  ldp      x20, x19, [sp, #0x20]
006598D24  ldp      x22, x21, [sp, #0x10]
006598D28  ldr      x30, [sp], #0x30
006598D2C  br       x3
006598D30  ldp      x20, x19, [sp, #0x20]
006598D34  ldp      x22, x21, [sp, #0x10]
006598D38  ldr      x30, [sp], #0x30
006598D3C  ret      

