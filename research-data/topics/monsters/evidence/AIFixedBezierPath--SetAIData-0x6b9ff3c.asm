; HotFix.BattleLogic.AIFixedBezierPath$$SetAIData
; RVA 0x6B9FF3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B9FF3C  str      x30, [sp, #-0x30]!
006B9FF40  stp      x22, x21, [sp, #0x10]
006B9FF44  stp      x20, x19, [sp, #0x20]
006B9FF48  adrp     x21, #0x95a0000
006B9FF4C  adrp     x22, #0x8f44000
006B9FF50  ldrb     w8, [x21, #0xae]
006B9FF54  ldr      x22, [x22, #0x358] ; GLOBAL Method$HotFix.BattleLogic.AIFixedBezierPath.SetAIData()
006B9FF58  mov      x19, x1
006B9FF5C  mov      x20, x0
006B9FF60  tbnz     w8, #0, #0x6b9ff84
006B9FF64  adrp     x0, #0x8f44000
006B9FF68  ldr      x0, [x0, #0x358] ; GLOBAL Method$HotFix.BattleLogic.AIFixedBezierPath.SetAIData()
006B9FF6C  bl       #0x382bd14 ; 
006B9FF70  adrp     x0, #0x8f44000
006B9FF74  ldr      x0, [x0, #0x340] ; GLOBAL HotFix.BattleLogic.AIFixedBezierPath.Data_TypeInfo
006B9FF78  bl       #0x382bd14 ; 
006B9FF7C  mov      w8, #1
006B9FF80  strb     w8, [x21, #0xae]
006B9FF84  ldr      x2, [x22]
006B9FF88  ldrb     w8, [x2, #0x53]
006B9FF8C  tbnz     w8, #5, #0x6b9fff4
006B9FF90  cbz      x19, #0x6ba0010
006B9FF94  adrp     x8, #0x8f44000
006B9FF98  ldr      x8, [x8, #0x340] ; GLOBAL HotFix.BattleLogic.AIFixedBezierPath.Data_TypeInfo
006B9FF9C  ldr      x9, [x19]
006B9FFA0  ldr      x1, [x8]
006B9FFA4  ldrb     w10, [x9, #0x130]
006B9FFA8  ldrb     w8, [x1, #0x130]
006B9FFAC  cmp      w10, w8
006B9FFB0  b.lo     #0x6ba002c
006B9FFB4  ldr      x10, [x9, #0xc8]
006B9FFB8  sub      x9, x8, #1
006B9FFBC  ldr      x10, [x10, x9, lsl #3]
006B9FFC0  cmp      x10, x1
006B9FFC4  b.ne     #0x6ba002c
006B9FFC8  str      x19, [x20, #0x118]
006B9FFCC  ldr      x10, [x19]
006B9FFD0  ldrb     w11, [x10, #0x130]
006B9FFD4  cmp      w11, w8
006B9FFD8  b.lo     #0x6ba002c
006B9FFDC  ldr      x8, [x10, #0xc8]
006B9FFE0  ldr      x8, [x8, x9, lsl #3]
006B9FFE4  cmp      x8, x1
006B9FFE8  b.ne     #0x6ba002c
006B9FFEC  add      x0, x20, #0x118
006B9FFF0  b        #0x6ba0018 ; 
006B9FFF4  ldr      x3, [x2, #0x60]
006B9FFF8  mov      x0, x20
006B9FFFC  mov      x1, x19
006BA0000  ldp      x20, x19, [sp, #0x20]
006BA0004  ldp      x22, x21, [sp, #0x10]
006BA0008  ldr      x30, [sp], #0x30
006BA000C  br       x3
006BA0010  add      x0, x20, #0x118
006BA0014  str      xzr, [x20, #0x118]
006BA0018  mov      x1, x19
006BA001C  ldp      x20, x19, [sp, #0x20]
006BA0020  ldp      x22, x21, [sp, #0x10]
006BA0024  ldr      x30, [sp], #0x30
006BA0028  b        #0x382bcb8 ; 
006BA002C  mov      x0, x19
006BA0030  bl       #0x382c354 ; 

