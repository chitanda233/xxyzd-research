; HotFix.BattleLogic.BaseDropNpcState$$OnPush
; RVA 0x6598D40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006598D40  stp      x30, x23, [sp, #-0x30]!
006598D44  stp      x22, x21, [sp, #0x10]
006598D48  stp      x20, x19, [sp, #0x20]
006598D4C  adrp     x22, #0x9599000
006598D50  adrp     x23, #0x8f08000
006598D54  ldrb     w8, [x22, #0x2f5]
006598D58  ldr      x23, [x23, #0xcc8] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnPush() @ 0x923b090
006598D5C  mov      x20, x2
006598D60  mov      w21, w1
006598D64  mov      x19, x0
006598D68  tbnz     w8, #0, #0x6598d8c
006598D6C  adrp     x0, #0x8f08000
006598D70  ldr      x0, [x0, #0xcc8] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnPush() @ 0x923b090
006598D74  bl       #0x382bd14 ; 
006598D78  adrp     x0, #0x8ebf000
006598D7C  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006598D80  bl       #0x382bd14 ; 
006598D84  mov      w8, #1
006598D88  strb     w8, [x22, #0x2f5]
006598D8C  ldr      x3, [x23]
006598D90  ldrb     w8, [x3, #0x53]
006598D94  tbnz     w8, #5, #0x6598df0
006598D98  cmp      w21, #5
006598D9C  b.eq     #0x6598e10
006598DA0  cmp      w21, #9
006598DA4  b.ne     #0x6598e18
006598DA8  cbz      x20, #0x6598e48
006598DAC  adrp     x8, #0x8ebf000
006598DB0  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006598DB4  ldr      x9, [x20]
006598DB8  mov      x0, x20
006598DBC  ldr      x1, [x8]
006598DC0  ldr      x8, [x9, #0x40]
006598DC4  ldr      x9, [x1, #0x40]
006598DC8  cmp      x8, x9
006598DCC  b.ne     #0x6598e4c
006598DD0  bl       #0x382be98 ; 
006598DD4  ldr      w8, [x0]
006598DD8  cmp      w8, #0xa
006598DDC  b.eq     #0x6598e28
006598DE0  cmp      w8, #7
006598DE4  b.ne     #0x6598e34
006598DE8  add      x8, x19, #0x21
006598DEC  b        #0x6598e2c ; 
006598DF0  ldr      x4, [x3, #0x60]
006598DF4  mov      x0, x19
006598DF8  mov      w1, w21
006598DFC  mov      x2, x20
006598E00  ldp      x20, x19, [sp, #0x20]
006598E04  ldp      x22, x21, [sp, #0x10]
006598E08  ldp      x30, x23, [sp], #0x30
006598E0C  br       x4
006598E10  mov      w8, #1
006598E14  strb     w8, [x19, #0x24]
006598E18  ldp      x20, x19, [sp, #0x20]
006598E1C  ldp      x22, x21, [sp, #0x10]
006598E20  ldp      x30, x23, [sp], #0x30
006598E24  ret      
006598E28  add      x8, x19, #0x23
006598E2C  mov      w9, #1
006598E30  strb     w9, [x8]
006598E34  mov      x0, x19
006598E38  ldp      x20, x19, [sp, #0x20]
006598E3C  ldp      x22, x21, [sp, #0x10]
006598E40  ldp      x30, x23, [sp], #0x30
006598E44  b        #0x65989a4 ; HotFix.BattleLogic.BaseDropNpcState$$TryShowNpc
006598E48  bl       #0x382bfb8 ; 
006598E4C  bl       #0x382c354 ; 

