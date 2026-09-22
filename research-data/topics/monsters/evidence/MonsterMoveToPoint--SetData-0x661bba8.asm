; HotFix.BattleLogic.MonsterMoveToPoint$$SetData
; RVA 0x661BBA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661BBA8  sub      sp, sp, #0x80
00661BBAC  stp      x30, x25, [sp, #0x40]
00661BBB0  stp      x24, x23, [sp, #0x50]
00661BBB4  stp      x22, x21, [sp, #0x60]
00661BBB8  stp      x20, x19, [sp, #0x70]
00661BBBC  mrs      x23, tpidr_el0
00661BBC0  ldr      x8, [x23, #0x28]
00661BBC4  adrp     x24, #0x9599000
00661BBC8  adrp     x25, #0x8f0c000
00661BBCC  mov      w20, w3
00661BBD0  str      x8, [sp, #0x38]
00661BBD4  ldrb     w8, [x24, #0x8b2]
00661BBD8  ldr      x25, [x25, #0x578] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.SetData()
00661BBDC  mov      x21, x2
00661BBE0  mov      x22, x1
00661BBE4  mov      x19, x0
00661BBE8  tbnz     w8, #0, #0x661bc00
00661BBEC  adrp     x0, #0x8f0c000
00661BBF0  ldr      x0, [x0, #0x578] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.SetData()
00661BBF4  bl       #0x382bd14 ; 
00661BBF8  mov      w8, #1
00661BBFC  strb     w8, [x24, #0x8b2]
00661BC00  ldr      x4, [x25]
00661BC04  ldrb     w8, [x4, #0x53]
00661BC08  tbnz     w8, #5, #0x661bc48
00661BC0C  ldr      x8, [x22, #0x10]
00661BC10  ldr      q0, [x22]
00661BC14  and      w9, w20, #1
00661BC18  mov      x1, xzr
00661BC1C  str      x8, [x19, #0x98]
00661BC20  stur     q0, [x19, #0x88]
00661BC24  ldr      x8, [x21, #0x10]
00661BC28  ldr      q0, [x21]
00661BC2C  str      xzr, [x19, #0xc0]!
00661BC30  mov      x0, x19
00661BC34  stur     x8, [x19, #-0x40]
00661BC38  stur     q0, [x19, #-0x50]
00661BC3C  sturb    w9, [x19, #-8]
00661BC40  bl       #0x382bcb8 ; 
00661BC44  b        #0x661bc80 ; 
00661BC48  ldr      x8, [x22, #0x10]
00661BC4C  ldr      q0, [x22]
00661BC50  ldr      x9, [x4, #0x60]
00661BC54  and      w3, w20, #1
00661BC58  str      x8, [sp, #0x30]
00661BC5C  str      q0, [sp, #0x20]
00661BC60  ldr      x8, [x21, #0x10]
00661BC64  ldr      q0, [x21]
00661BC68  add      x1, sp, #0x20
00661BC6C  mov      x2, sp
00661BC70  mov      x0, x19
00661BC74  str      x8, [sp, #0x10]
00661BC78  str      q0, [sp]
00661BC7C  blr      x9
00661BC80  ldr      x8, [x23, #0x28]
00661BC84  ldr      x9, [sp, #0x38]
00661BC88  cmp      x8, x9
00661BC8C  b.ne     #0x661bca8
00661BC90  ldp      x20, x19, [sp, #0x70]
00661BC94  ldp      x22, x21, [sp, #0x60]
00661BC98  ldp      x24, x23, [sp, #0x50]
00661BC9C  ldp      x30, x25, [sp, #0x40]
00661BCA0  add      sp, sp, #0x80
00661BCA4  ret      
00661BCA8  bl       #0x89edb60 ; 

