; HotFix.BattleLogic.BaseHeroDieState$$OnPush
; RVA 0x659CC38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659CC38  stp      x30, x23, [sp, #-0x30]!
00659CC3C  stp      x22, x21, [sp, #0x10]
00659CC40  stp      x20, x19, [sp, #0x20]
00659CC44  adrp     x22, #0x9599000
00659CC48  adrp     x23, #0x8f08000
00659CC4C  ldrb     w8, [x22, #0x314]
00659CC50  ldr      x23, [x23, #0xee8] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.OnPush() @ 0x923b240
00659CC54  mov      x20, x2
00659CC58  mov      w21, w1
00659CC5C  mov      x19, x0
00659CC60  tbnz     w8, #0, #0x659cc84
00659CC64  adrp     x0, #0x8f08000
00659CC68  ldr      x0, [x0, #0xee8] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.OnPush() @ 0x923b240
00659CC6C  bl       #0x382bd14 ; 
00659CC70  adrp     x0, #0x8ebf000
00659CC74  ldr      x0, [x0, #0x838] ; GLOBAL byte_TypeInfo @ 0x91e2188
00659CC78  bl       #0x382bd14 ; 
00659CC7C  mov      w8, #1
00659CC80  strb     w8, [x22, #0x314]
00659CC84  ldr      x3, [x23]
00659CC88  ldrb     w8, [x3, #0x53]
00659CC8C  tbnz     w8, #5, #0x659ccf4
00659CC90  cmp      w21, #7
00659CC94  b.ne     #0x659cd14
00659CC98  cbz      x20, #0x659cdb0
00659CC9C  adrp     x8, #0x8ebf000
00659CCA0  ldr      x8, [x8, #0x838] ; GLOBAL byte_TypeInfo @ 0x91e2188
00659CCA4  ldr      x9, [x20]
00659CCA8  mov      x0, x20
00659CCAC  ldr      x1, [x8]
00659CCB0  ldr      x8, [x9, #0x40]
00659CCB4  ldr      x9, [x1, #0x40]
00659CCB8  cmp      x8, x9
00659CCBC  b.ne     #0x659cdb4
00659CCC0  bl       #0x382be98 ; 
00659CCC4  ldrb     w20, [x0]
00659CCC8  cmp      w20, #2
00659CCCC  b.eq     #0x659cd3c
00659CCD0  cmp      w20, #1
00659CCD4  b.eq     #0x659cd24
00659CCD8  cbnz     w20, #0x659cd4c
00659CCDC  adrp     x8, #0x197f000
00659CCE0  ldr      d0, [x8, #0x450]
00659CCE4  mov      w8, #0x3333
00659CCE8  str      x8, [x19, #0x28]
00659CCEC  str      d0, [x19, #0x20]
00659CCF0  b        #0x659cd4c ; 
00659CCF4  ldr      x4, [x3, #0x60]
00659CCF8  mov      x0, x19
00659CCFC  mov      w1, w21
00659CD00  mov      x2, x20
00659CD04  ldp      x20, x19, [sp, #0x20]
00659CD08  ldp      x22, x21, [sp, #0x10]
00659CD0C  ldp      x30, x23, [sp], #0x30
00659CD10  br       x4
00659CD14  ldp      x20, x19, [sp, #0x20]
00659CD18  ldp      x22, x21, [sp, #0x10]
00659CD1C  ldp      x30, x23, [sp], #0x30
00659CD20  ret      
00659CD24  mov      w8, #2
00659CD28  mov      w1, #3
00659CD2C  mov      x0, x19
00659CD30  str      w8, [x19, #0x24]
00659CD34  bl       #0x659c4e8 ; HotFix.BattleLogic.BaseHeroDieState$$PlayerRelive
00659CD38  b        #0x659cd4c ; 
00659CD3C  mov      w8, #2
00659CD40  mov      x0, x19
00659CD44  str      w8, [x19, #0x24]
00659CD48  bl       #0x659c428 ; HotFix.BattleLogic.BaseHeroDieState$$PlayerReliveByAd
00659CD4C  adrp     x21, #0x9599000
00659CD50  ldrb     w8, [x21, #0x4b1]
00659CD54  cbnz     w8, #0x659cd6c
00659CD58  adrp     x0, #0x8f08000
00659CD5C  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659CD60  bl       #0x382bd14 ; 
00659CD64  mov      w8, #1
00659CD68  strb     w8, [x21, #0x4b1]
00659CD6C  adrp     x8, #0x8f08000
00659CD70  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659CD74  ldr      x1, [x8]
00659CD78  ldrb     w8, [x1, #0x53]
00659CD7C  tbnz     w8, #5, #0x659cd88
00659CD80  ldr      x0, [x19, #0x10]
00659CD84  b        #0x659cd94 ; 
00659CD88  ldr      x8, [x1, #0x60]
00659CD8C  mov      x0, x19
00659CD90  blr      x8
00659CD94  cbz      x0, #0x659cdb0
00659CD98  mov      w1, w20
00659CD9C  ldp      x20, x19, [sp, #0x20]
00659CDA0  ldp      x22, x21, [sp, #0x10]
00659CDA4  mov      x2, xzr
00659CDA8  ldp      x30, x23, [sp], #0x30
00659CDAC  b        #0x6a0fe54 ; HotFix.BattleLogic.BattleWorldContext$$SetReliveType
00659CDB0  bl       #0x382bfb8 ; 
00659CDB4  bl       #0x382c354 ; 

