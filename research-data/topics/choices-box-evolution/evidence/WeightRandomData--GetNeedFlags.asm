; HotFix.BattleLogic.WeightRandomData$$GetNeedFlags
; RVA 0x6631D14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631D14  stp      x30, x21, [sp, #-0x20]!
006631D18  stp      x20, x19, [sp, #0x10]
006631D1C  adrp     x20, #0x9599000
006631D20  adrp     x21, #0x8f0c000
006631D24  ldrb     w8, [x20, #0x9b9]
006631D28  ldr      x21, [x21, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedFlags() @ 0x92cbb98
006631D2C  mov      x19, x0
006631D30  tbnz     w8, #0, #0x6631d48
006631D34  adrp     x0, #0x8f0c000
006631D38  ldr      x0, [x0, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedFlags() @ 0x92cbb98
006631D3C  bl       #0x382bd14 ; 
006631D40  mov      w8, #1
006631D44  strb     w8, [x20, #0x9b9]
006631D48  ldr      x1, [x21]
006631D4C  ldrb     w8, [x1, #0x53]
006631D50  tbnz     w8, #5, #0x6631d64
006631D54  ldr      w0, [x19, #0xc]
006631D58  ldp      x20, x19, [sp, #0x10]
006631D5C  ldp      x30, x21, [sp], #0x20
006631D60  ret      
006631D64  ldr      x2, [x1, #0x60]
006631D68  mov      x0, x19
006631D6C  ldp      x20, x19, [sp, #0x10]
006631D70  ldp      x30, x21, [sp], #0x20
006631D74  br       x2

