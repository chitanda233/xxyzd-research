; HotFix.BattleLogic.AIPunchboard$$OnEventHook
; RVA 0x6B8ABD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8ABD8  stp      x30, x23, [sp, #-0x30]!
006B8ABDC  stp      x22, x21, [sp, #0x10]
006B8ABE0  stp      x20, x19, [sp, #0x20]
006B8ABE4  adrp     x22, #0x959f000
006B8ABE8  adrp     x23, #0x8f43000
006B8ABEC  ldrb     w8, [x22, #0xf7e]
006B8ABF0  ldr      x23, [x23, #0x888] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnEventHook() @ 0x9232408
006B8ABF4  mov      x20, x2
006B8ABF8  mov      w21, w1
006B8ABFC  mov      x19, x0
006B8AC00  tbnz     w8, #0, #0x6b8ac30
006B8AC04  adrp     x0, #0x8f43000
006B8AC08  ldr      x0, [x0, #0x888] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnEventHook() @ 0x9232408
006B8AC0C  bl       #0x382bd14 ; 
006B8AC10  adrp     x0, #0x8ec0000
006B8AC14  ldr      x0, [x0, #0x98] ; GLOBAL bool_TypeInfo @ 0x91e1ca0
006B8AC18  bl       #0x382bd14 ; 
006B8AC1C  adrp     x0, #0x8ee6000
006B8AC20  ldr      x0, [x0, #0x610] ; GLOBAL HotFix.BattleLogic.EntityHero_TypeInfo @ 0x91e5ad0
006B8AC24  bl       #0x382bd14 ; 
006B8AC28  mov      w8, #1
006B8AC2C  strb     w8, [x22, #0xf7e]
006B8AC30  ldr      x3, [x23]
006B8AC34  ldrb     w8, [x3, #0x53]
006B8AC38  tbnz     w8, #5, #0x6b8acf8
006B8AC3C  cmp      w21, #6
006B8AC40  b.ne     #0x6b8ad18
006B8AC44  cbz      x20, #0x6b8ad50
006B8AC48  ldr      w8, [x20, #0x18]
006B8AC4C  cmp      w8, #1
006B8AC50  b.ls     #0x6b8ad54
006B8AC54  ldr      x0, [x20, #0x28]
006B8AC58  cbz      x0, #0x6b8ad50
006B8AC5C  adrp     x8, #0x8ec0000
006B8AC60  ldr      x8, [x8, #0x98] ; GLOBAL bool_TypeInfo @ 0x91e1ca0
006B8AC64  ldr      x9, [x0]
006B8AC68  ldr      x1, [x8]
006B8AC6C  ldr      x8, [x9, #0x40]
006B8AC70  ldr      x9, [x1, #0x40]
006B8AC74  cmp      x8, x9
006B8AC78  b.ne     #0x6b8ad60
006B8AC7C  bl       #0x382be98 ; 
006B8AC80  ldrb     w8, [x0]
006B8AC84  cbz      w8, #0x6b8ad28
006B8AC88  ldr      w8, [x20, #0x18]
006B8AC8C  cbz      w8, #0x6b8ad54
006B8AC90  ldr      x1, [x20, #0x20]
006B8AC94  cbz      x1, #0x6b8ad38
006B8AC98  adrp     x8, #0x8ee6000
006B8AC9C  ldr      x8, [x8, #0x610] ; GLOBAL HotFix.BattleLogic.EntityHero_TypeInfo @ 0x91e5ad0
006B8ACA0  ldr      x10, [x1]
006B8ACA4  ldr      x8, [x8]
006B8ACA8  ldrb     w11, [x10, #0x130]
006B8ACAC  ldrb     w9, [x8, #0x130]
006B8ACB0  cmp      w11, w9
006B8ACB4  b.lo     #0x6b8ad58
006B8ACB8  ldr      x11, [x10, #0xc8]
006B8ACBC  sub      x10, x9, #1
006B8ACC0  ldr      x11, [x11, x10, lsl #3]
006B8ACC4  cmp      x11, x8
006B8ACC8  b.ne     #0x6b8ad58
006B8ACCC  str      x1, [x19, #0x120]
006B8ACD0  ldr      x11, [x1]
006B8ACD4  ldrb     w12, [x11, #0x130]
006B8ACD8  cmp      w12, w9
006B8ACDC  b.lo     #0x6b8ad58
006B8ACE0  ldr      x9, [x11, #0xc8]
006B8ACE4  ldr      x9, [x9, x10, lsl #3]
006B8ACE8  cmp      x9, x8
006B8ACEC  b.ne     #0x6b8ad58
006B8ACF0  add      x0, x19, #0x120
006B8ACF4  b        #0x6b8ad40 ; 
006B8ACF8  ldr      x4, [x3, #0x60]
006B8ACFC  mov      x0, x19
006B8AD00  mov      w1, w21
006B8AD04  mov      x2, x20
006B8AD08  ldp      x20, x19, [sp, #0x20]
006B8AD0C  ldp      x22, x21, [sp, #0x10]
006B8AD10  ldp      x30, x23, [sp], #0x30
006B8AD14  br       x4
006B8AD18  ldp      x20, x19, [sp, #0x20]
006B8AD1C  ldp      x22, x21, [sp, #0x10]
006B8AD20  ldp      x30, x23, [sp], #0x30
006B8AD24  ret      
006B8AD28  add      x0, x19, #0x120
006B8AD2C  str      xzr, [x19, #0x120]
006B8AD30  mov      x1, xzr
006B8AD34  b        #0x6b8ad40 ; 
006B8AD38  add      x0, x19, #0x120
006B8AD3C  str      xzr, [x19, #0x120]
006B8AD40  ldp      x20, x19, [sp, #0x20]
006B8AD44  ldp      x22, x21, [sp, #0x10]
006B8AD48  ldp      x30, x23, [sp], #0x30
006B8AD4C  b        #0x382bcb8 ; 
006B8AD50  bl       #0x382bfb8 ; 
006B8AD54  bl       #0x382bfc0 ; 
006B8AD58  mov      x0, x1
006B8AD5C  mov      x1, x8
006B8AD60  bl       #0x382c354 ; 

