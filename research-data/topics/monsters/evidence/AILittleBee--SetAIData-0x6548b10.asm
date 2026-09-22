; HotFix.BattleLogic.AILittleBee$$SetAIData
; RVA 0x6548B10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006548B10  str      x30, [sp, #-0x30]!
006548B14  stp      x22, x21, [sp, #0x10]
006548B18  stp      x20, x19, [sp, #0x20]
006548B1C  adrp     x21, #0x9598000
006548B20  adrp     x22, #0x8f05000
006548B24  ldrb     w8, [x21, #0xe12]
006548B28  ldr      x22, [x22, #0x638] ; GLOBAL Method$HotFix.BattleLogic.AILittleBee.SetAIData()
006548B2C  mov      x19, x1
006548B30  mov      x20, x0
006548B34  tbnz     w8, #0, #0x6548b58
006548B38  adrp     x0, #0x8f05000
006548B3C  ldr      x0, [x0, #0x638] ; GLOBAL Method$HotFix.BattleLogic.AILittleBee.SetAIData()
006548B40  bl       #0x382bd14 ; 
006548B44  adrp     x0, #0x8f05000
006548B48  ldr      x0, [x0, #0x620] ; GLOBAL HotFix.BattleLogic.AILittleBee.Data_TypeInfo
006548B4C  bl       #0x382bd14 ; 
006548B50  mov      w8, #1
006548B54  strb     w8, [x21, #0xe12]
006548B58  ldr      x2, [x22]
006548B5C  ldrb     w8, [x2, #0x53]
006548B60  tbnz     w8, #5, #0x6548bc8
006548B64  cbz      x19, #0x6548be4
006548B68  adrp     x8, #0x8f05000
006548B6C  ldr      x8, [x8, #0x620] ; GLOBAL HotFix.BattleLogic.AILittleBee.Data_TypeInfo
006548B70  ldr      x9, [x19]
006548B74  ldr      x1, [x8]
006548B78  ldrb     w10, [x9, #0x130]
006548B7C  ldrb     w8, [x1, #0x130]
006548B80  cmp      w10, w8
006548B84  b.lo     #0x6548c00
006548B88  ldr      x10, [x9, #0xc8]
006548B8C  sub      x9, x8, #1
006548B90  ldr      x10, [x10, x9, lsl #3]
006548B94  cmp      x10, x1
006548B98  b.ne     #0x6548c00
006548B9C  str      x19, [x20, #0x118]
006548BA0  ldr      x10, [x19]
006548BA4  ldrb     w11, [x10, #0x130]
006548BA8  cmp      w11, w8
006548BAC  b.lo     #0x6548c00
006548BB0  ldr      x8, [x10, #0xc8]
006548BB4  ldr      x8, [x8, x9, lsl #3]
006548BB8  cmp      x8, x1
006548BBC  b.ne     #0x6548c00
006548BC0  add      x0, x20, #0x118
006548BC4  b        #0x6548bec ; 
006548BC8  ldr      x3, [x2, #0x60]
006548BCC  mov      x0, x20
006548BD0  mov      x1, x19
006548BD4  ldp      x20, x19, [sp, #0x20]
006548BD8  ldp      x22, x21, [sp, #0x10]
006548BDC  ldr      x30, [sp], #0x30
006548BE0  br       x3
006548BE4  add      x0, x20, #0x118
006548BE8  str      xzr, [x20, #0x118]
006548BEC  mov      x1, x19
006548BF0  ldp      x20, x19, [sp, #0x20]
006548BF4  ldp      x22, x21, [sp, #0x10]
006548BF8  ldr      x30, [sp], #0x30
006548BFC  b        #0x382bcb8 ; 
006548C00  mov      x0, x19
006548C04  bl       #0x382c354 ; 

