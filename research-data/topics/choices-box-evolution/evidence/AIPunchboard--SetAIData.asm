; HotFix.BattleLogic.AIPunchboard$$SetAIData
; RVA 0x6B89F28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B89F28  str      x30, [sp, #-0x30]!
006B89F2C  stp      x22, x21, [sp, #0x10]
006B89F30  stp      x20, x19, [sp, #0x20]
006B89F34  adrp     x21, #0x959f000
006B89F38  adrp     x22, #0x8f43000
006B89F3C  ldrb     w8, [x21, #0xf79]
006B89F40  ldr      x22, [x22, #0x838] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.SetAIData() @ 0x9232418
006B89F44  mov      x20, x1
006B89F48  mov      x19, x0
006B89F4C  tbnz     w8, #0, #0x6b89f70
006B89F50  adrp     x0, #0x8f43000
006B89F54  ldr      x0, [x0, #0x838] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.SetAIData() @ 0x9232418
006B89F58  bl       #0x382bd14 ; 
006B89F5C  adrp     x0, #0x8f43000
006B89F60  ldr      x0, [x0, #0x820] ; GLOBAL HotFix.BattleLogic.AIPunchboard.Data_TypeInfo @ 0x91f60c8
006B89F64  bl       #0x382bd14 ; 
006B89F68  mov      w8, #1
006B89F6C  strb     w8, [x21, #0xf79]
006B89F70  ldr      x2, [x22]
006B89F74  ldrb     w8, [x2, #0x53]
006B89F78  tbnz     w8, #5, #0x6b89fe0
006B89F7C  cbz      x20, #0x6b89ffc
006B89F80  adrp     x8, #0x8f43000
006B89F84  ldr      x8, [x8, #0x820] ; GLOBAL HotFix.BattleLogic.AIPunchboard.Data_TypeInfo @ 0x91f60c8
006B89F88  ldr      x9, [x20]
006B89F8C  ldr      x1, [x8]
006B89F90  ldrb     w10, [x9, #0x130]
006B89F94  ldrb     w8, [x1, #0x130]
006B89F98  cmp      w10, w8
006B89F9C  b.lo     #0x6b8a050
006B89FA0  ldr      x10, [x9, #0xc8]
006B89FA4  sub      x9, x8, #1
006B89FA8  ldr      x10, [x10, x9, lsl #3]
006B89FAC  cmp      x10, x1
006B89FB0  b.ne     #0x6b8a050
006B89FB4  str      x20, [x19, #0x118]
006B89FB8  ldr      x10, [x20]
006B89FBC  ldrb     w11, [x10, #0x130]
006B89FC0  cmp      w11, w8
006B89FC4  b.lo     #0x6b8a050
006B89FC8  ldr      x8, [x10, #0xc8]
006B89FCC  ldr      x8, [x8, x9, lsl #3]
006B89FD0  cmp      x8, x1
006B89FD4  b.ne     #0x6b8a050
006B89FD8  add      x0, x19, #0x118
006B89FDC  b        #0x6b8a004 ; 
006B89FE0  ldr      x3, [x2, #0x60]
006B89FE4  mov      x0, x19
006B89FE8  mov      x1, x20
006B89FEC  ldp      x20, x19, [sp, #0x20]
006B89FF0  ldp      x22, x21, [sp, #0x10]
006B89FF4  ldr      x30, [sp], #0x30
006B89FF8  br       x3
006B89FFC  add      x0, x19, #0x118
006B8A000  str      xzr, [x19, #0x118]
006B8A004  mov      x1, x20
006B8A008  bl       #0x382bcb8 ; 
006B8A00C  ldr      x8, [x19, #0x118]
006B8A010  str      xzr, [x19, #0x130]
006B8A014  cbz      x8, #0x6b8a058
006B8A018  ldr      x9, [x8, #0x20]
006B8A01C  cbz      x9, #0x6b8a028
006B8A020  mov      x10, #0x100000000
006B8A024  sdiv     x9, x10, x9
006B8A028  str      x9, [x19, #0x138]
006B8A02C  ldr      x8, [x8, #0x28]
006B8A030  cbz      x8, #0x6b8a03c
006B8A034  mov      x9, #0x100000000
006B8A038  sdiv     x8, x9, x8
006B8A03C  str      x8, [x19, #0x140]
006B8A040  ldp      x20, x19, [sp, #0x20]
006B8A044  ldp      x22, x21, [sp, #0x10]
006B8A048  ldr      x30, [sp], #0x30
006B8A04C  ret      
006B8A050  mov      x0, x20
006B8A054  bl       #0x382c354 ; 
006B8A058  bl       #0x382bfb8 ; 

