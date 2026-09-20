; HotFix.BattleLogic.WeightRandomData$$GetNeedSkills
; RVA 0x6631DDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631DDC  stp      x30, x21, [sp, #-0x20]!
006631DE0  stp      x20, x19, [sp, #0x10]
006631DE4  adrp     x20, #0x9599000
006631DE8  adrp     x21, #0x8f0c000
006631DEC  ldrb     w8, [x20, #0x9bd]
006631DF0  ldr      x21, [x21, #0xea8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedSkills() @ 0x92cbba0
006631DF4  mov      x19, x0
006631DF8  tbnz     w8, #0, #0x6631e10
006631DFC  adrp     x0, #0x8f0c000
006631E00  ldr      x0, [x0, #0xea8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedSkills() @ 0x92cbba0
006631E04  bl       #0x382bd14 ; 
006631E08  mov      w8, #1
006631E0C  strb     w8, [x20, #0x9bd]
006631E10  ldr      x1, [x21]
006631E14  ldrb     w8, [x1, #0x53]
006631E18  tbnz     w8, #5, #0x6631e2c
006631E1C  ldr      x0, [x19, #0x28]
006631E20  ldp      x20, x19, [sp, #0x10]
006631E24  ldp      x30, x21, [sp], #0x20
006631E28  ret      
006631E2C  ldr      x2, [x1, #0x60]
006631E30  mov      x0, x19
006631E34  ldp      x20, x19, [sp, #0x10]
006631E38  ldp      x30, x21, [sp], #0x20
006631E3C  br       x2

