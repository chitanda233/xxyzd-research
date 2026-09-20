; HotFix.BattleLogic.MainDropManager$$AddDropItemFromGroup
; RVA 0x6671CC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671CC8  stp      x30, x25, [sp, #-0x40]!
006671CCC  stp      x24, x23, [sp, #0x10]
006671CD0  stp      x22, x21, [sp, #0x20]
006671CD4  stp      x20, x19, [sp, #0x30]
006671CD8  adrp     x24, #0x9599000
006671CDC  adrp     x25, #0x8f0f000
006671CE0  ldrb     w8, [x24, #0xde7]
006671CE4  ldr      x25, [x25, #0x778] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.AddDropItemFromGroup() @ 0x928dc00
006671CE8  mov      x19, x4
006671CEC  mov      x20, x3
006671CF0  mov      x21, x2
006671CF4  mov      x22, x1
006671CF8  mov      x23, x0
006671CFC  tbnz     w8, #0, #0x6671d14
006671D00  adrp     x0, #0x8f0f000
006671D04  ldr      x0, [x0, #0x778] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.AddDropItemFromGroup() @ 0x928dc00
006671D08  bl       #0x382bd14 ; 
006671D0C  mov      w8, #1
006671D10  strb     w8, [x24, #0xde7]
006671D14  ldr      x5, [x25]
006671D18  ldrb     w8, [x5, #0x53]
006671D1C  tbnz     w8, #5, #0x6671d34
006671D20  ldp      x20, x19, [sp, #0x30]
006671D24  ldp      x22, x21, [sp, #0x20]
006671D28  ldp      x24, x23, [sp, #0x10]
006671D2C  ldp      x30, x25, [sp], #0x40
006671D30  ret      
006671D34  ldr      x6, [x5, #0x60]
006671D38  mov      x0, x23
006671D3C  mov      x1, x22
006671D40  mov      x2, x21
006671D44  mov      x3, x20
006671D48  mov      x4, x19
006671D4C  ldp      x20, x19, [sp, #0x30]
006671D50  ldp      x22, x21, [sp, #0x20]
006671D54  ldp      x24, x23, [sp, #0x10]
006671D58  ldp      x30, x25, [sp], #0x40
006671D5C  br       x6

