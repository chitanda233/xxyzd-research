; HotFix.BattleLogic.MonsterMoveToPoint$$SetData
; RVA 0x661BCAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661BCAC  stp      x30, x23, [sp, #-0x30]!
00661BCB0  stp      x22, x21, [sp, #0x10]
00661BCB4  stp      x20, x19, [sp, #0x20]
00661BCB8  adrp     x22, #0x9599000
00661BCBC  adrp     x23, #0x8f0c000
00661BCC0  ldrb     w8, [x22, #0x8b3]
00661BCC4  ldr      x23, [x23, #0x580] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.SetData()
00661BCC8  mov      w21, w2
00661BCCC  mov      x20, x1
00661BCD0  mov      x19, x0
00661BCD4  tbnz     w8, #0, #0x661bcec
00661BCD8  adrp     x0, #0x8f0c000
00661BCDC  ldr      x0, [x0, #0x580] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.SetData()
00661BCE0  bl       #0x382bd14 ; 
00661BCE4  mov      w8, #1
00661BCE8  strb     w8, [x22, #0x8b3]
00661BCEC  ldr      x3, [x23]
00661BCF0  ldrb     w8, [x3, #0x53]
00661BCF4  tbnz     w8, #5, #0x661bd20
00661BCF8  str      x20, [x19, #0xc0]!
00661BCFC  mov      x0, x19
00661BD00  mov      x1, x20
00661BD04  and      w21, w21, #1
00661BD08  bl       #0x382bcb8 ; 
00661BD0C  sturb    w21, [x19, #-8]
00661BD10  ldp      x20, x19, [sp, #0x20]
00661BD14  ldp      x22, x21, [sp, #0x10]
00661BD18  ldp      x30, x23, [sp], #0x30
00661BD1C  ret      
00661BD20  ldr      x4, [x3, #0x60]
00661BD24  and      w2, w21, #1
00661BD28  mov      x0, x19
00661BD2C  mov      x1, x20
00661BD30  ldp      x20, x19, [sp, #0x20]
00661BD34  ldp      x22, x21, [sp, #0x10]
00661BD38  ldp      x30, x23, [sp], #0x30
00661BD3C  br       x4

