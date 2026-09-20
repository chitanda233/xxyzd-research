; HotFix.BattleLogic.MainDropManager$$CheckSpecialDrop
; RVA 0x6671C2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671C2C  stp      x30, x25, [sp, #-0x40]!
006671C30  stp      x24, x23, [sp, #0x10]
006671C34  stp      x22, x21, [sp, #0x20]
006671C38  stp      x20, x19, [sp, #0x30]
006671C3C  adrp     x24, #0x9599000
006671C40  adrp     x25, #0x8f0f000
006671C44  ldrb     w8, [x24, #0xde6]
006671C48  ldr      x25, [x25, #0x770] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.CheckSpecialDrop() @ 0x928dc08
006671C4C  mov      x19, x4
006671C50  mov      x20, x3
006671C54  mov      x21, x2
006671C58  mov      x22, x1
006671C5C  mov      x23, x0
006671C60  tbnz     w8, #0, #0x6671c78
006671C64  adrp     x0, #0x8f0f000
006671C68  ldr      x0, [x0, #0x770] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.CheckSpecialDrop() @ 0x928dc08
006671C6C  bl       #0x382bd14 ; 
006671C70  mov      w8, #1
006671C74  strb     w8, [x24, #0xde6]
006671C78  ldr      x5, [x25]
006671C7C  ldrb     w8, [x5, #0x53]
006671C80  tbnz     w8, #5, #0x6671c9c
006671C84  ldp      x20, x19, [sp, #0x30]
006671C88  ldp      x22, x21, [sp, #0x20]
006671C8C  ldp      x24, x23, [sp, #0x10]
006671C90  mov      w0, wzr
006671C94  ldp      x30, x25, [sp], #0x40
006671C98  ret      
006671C9C  ldr      x6, [x5, #0x60]
006671CA0  mov      x0, x23
006671CA4  mov      x1, x22
006671CA8  mov      x2, x21
006671CAC  mov      x3, x20
006671CB0  mov      x4, x19
006671CB4  ldp      x20, x19, [sp, #0x30]
006671CB8  ldp      x22, x21, [sp, #0x20]
006671CBC  ldp      x24, x23, [sp, #0x10]
006671CC0  ldp      x30, x25, [sp], #0x40
006671CC4  br       x6

