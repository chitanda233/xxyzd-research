; HotFix.BattleLogic.AICommonBoss2$$SetAIData
; RVA 0x6567D24; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006567D24  str      x30, [sp, #-0x30]!
006567D28  stp      x22, x21, [sp, #0x10]
006567D2C  stp      x20, x19, [sp, #0x20]
006567D30  adrp     x21, #0x9598000
006567D34  adrp     x22, #0x8f06000
006567D38  ldrb     w8, [x21, #0xfa4]
006567D3C  ldr      x22, [x22, #0x988] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss2.SetAIData()
006567D40  mov      x19, x1
006567D44  mov      x20, x0
006567D48  tbnz     w8, #0, #0x6567d6c
006567D4C  adrp     x0, #0x8f06000
006567D50  ldr      x0, [x0, #0x988] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss2.SetAIData()
006567D54  bl       #0x382bd14 ; 
006567D58  adrp     x0, #0x8f06000
006567D5C  ldr      x0, [x0, #0x770] ; GLOBAL HotFix.BattleLogic.AICommonBoss.Data_TypeInfo
006567D60  bl       #0x382bd14 ; 
006567D64  mov      w8, #1
006567D68  strb     w8, [x21, #0xfa4]
006567D6C  ldr      x2, [x22]
006567D70  ldrb     w8, [x2, #0x53]
006567D74  tbnz     w8, #5, #0x6567ddc
006567D78  cbz      x19, #0x6567df8
006567D7C  adrp     x8, #0x8f06000
006567D80  ldr      x8, [x8, #0x770] ; GLOBAL HotFix.BattleLogic.AICommonBoss.Data_TypeInfo
006567D84  ldr      x9, [x19]
006567D88  ldr      x1, [x8]
006567D8C  ldrb     w10, [x9, #0x130]
006567D90  ldrb     w8, [x1, #0x130]
006567D94  cmp      w10, w8
006567D98  b.lo     #0x6567e1c
006567D9C  ldr      x10, [x9, #0xc8]
006567DA0  sub      x9, x8, #1
006567DA4  ldr      x10, [x10, x9, lsl #3]
006567DA8  cmp      x10, x1
006567DAC  b.ne     #0x6567e1c
006567DB0  str      x19, [x20, #0x118]
006567DB4  ldr      x10, [x19]
006567DB8  ldrb     w11, [x10, #0x130]
006567DBC  cmp      w11, w8
006567DC0  b.lo     #0x6567e1c
006567DC4  ldr      x8, [x10, #0xc8]
006567DC8  ldr      x8, [x8, x9, lsl #3]
006567DCC  cmp      x8, x1
006567DD0  b.ne     #0x6567e1c
006567DD4  add      x0, x20, #0x118
006567DD8  b        #0x6567e00 ; 
006567DDC  ldr      x3, [x2, #0x60]
006567DE0  mov      x0, x20
006567DE4  mov      x1, x19
006567DE8  ldp      x20, x19, [sp, #0x20]
006567DEC  ldp      x22, x21, [sp, #0x10]
006567DF0  ldr      x30, [sp], #0x30
006567DF4  br       x3
006567DF8  add      x0, x20, #0x118
006567DFC  str      xzr, [x20, #0x118]
006567E00  mov      x1, x19
006567E04  bl       #0x382bcb8 ; 
006567E08  mov      x0, x20
006567E0C  ldp      x20, x19, [sp, #0x20]
006567E10  ldp      x22, x21, [sp, #0x10]
006567E14  ldr      x30, [sp], #0x30
006567E18  b        #0x6567164 ; HotFix.BattleLogic.AICommonBoss2$$onGetDataParams
006567E1C  mov      x0, x19
006567E20  bl       #0x382c354 ; 

