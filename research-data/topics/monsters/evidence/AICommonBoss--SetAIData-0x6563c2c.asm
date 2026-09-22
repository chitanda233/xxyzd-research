; HotFix.BattleLogic.AICommonBoss$$SetAIData
; RVA 0x6563C2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006563C2C  str      x30, [sp, #-0x30]!
006563C30  stp      x22, x21, [sp, #0x10]
006563C34  stp      x20, x19, [sp, #0x20]
006563C38  adrp     x21, #0x9598000
006563C3C  adrp     x22, #0x8f06000
006563C40  ldrb     w8, [x21, #0xf82]
006563C44  ldr      x22, [x22, #0x790] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.SetAIData()
006563C48  mov      x19, x1
006563C4C  mov      x20, x0
006563C50  tbnz     w8, #0, #0x6563c74
006563C54  adrp     x0, #0x8f06000
006563C58  ldr      x0, [x0, #0x790] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.SetAIData()
006563C5C  bl       #0x382bd14 ; 
006563C60  adrp     x0, #0x8f06000
006563C64  ldr      x0, [x0, #0x770] ; GLOBAL HotFix.BattleLogic.AICommonBoss.Data_TypeInfo
006563C68  bl       #0x382bd14 ; 
006563C6C  mov      w8, #1
006563C70  strb     w8, [x21, #0xf82]
006563C74  ldr      x2, [x22]
006563C78  ldrb     w8, [x2, #0x53]
006563C7C  tbnz     w8, #5, #0x6563ce4
006563C80  cbz      x19, #0x6563d00
006563C84  adrp     x8, #0x8f06000
006563C88  ldr      x8, [x8, #0x770] ; GLOBAL HotFix.BattleLogic.AICommonBoss.Data_TypeInfo
006563C8C  ldr      x9, [x19]
006563C90  ldr      x1, [x8]
006563C94  ldrb     w10, [x9, #0x130]
006563C98  ldrb     w8, [x1, #0x130]
006563C9C  cmp      w10, w8
006563CA0  b.lo     #0x6563d24
006563CA4  ldr      x10, [x9, #0xc8]
006563CA8  sub      x9, x8, #1
006563CAC  ldr      x10, [x10, x9, lsl #3]
006563CB0  cmp      x10, x1
006563CB4  b.ne     #0x6563d24
006563CB8  str      x19, [x20, #0x118]
006563CBC  ldr      x10, [x19]
006563CC0  ldrb     w11, [x10, #0x130]
006563CC4  cmp      w11, w8
006563CC8  b.lo     #0x6563d24
006563CCC  ldr      x8, [x10, #0xc8]
006563CD0  ldr      x8, [x8, x9, lsl #3]
006563CD4  cmp      x8, x1
006563CD8  b.ne     #0x6563d24
006563CDC  add      x0, x20, #0x118
006563CE0  b        #0x6563d08 ; 
006563CE4  ldr      x3, [x2, #0x60]
006563CE8  mov      x0, x20
006563CEC  mov      x1, x19
006563CF0  ldp      x20, x19, [sp, #0x20]
006563CF4  ldp      x22, x21, [sp, #0x10]
006563CF8  ldr      x30, [sp], #0x30
006563CFC  br       x3
006563D00  add      x0, x20, #0x118
006563D04  str      xzr, [x20, #0x118]
006563D08  mov      x1, x19
006563D0C  bl       #0x382bcb8 ; 
006563D10  mov      x0, x20
006563D14  ldp      x20, x19, [sp, #0x20]
006563D18  ldp      x22, x21, [sp, #0x10]
006563D1C  ldr      x30, [sp], #0x30
006563D20  b        #0x6563b3c ; HotFix.BattleLogic.AICommonBoss$$onGetDataParams
006563D24  mov      x0, x19
006563D28  bl       #0x382c354 ; 

