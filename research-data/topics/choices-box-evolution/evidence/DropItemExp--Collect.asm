; HotFix.BattleLogic.DropItemExp$$Collect
; RVA 0x6666C30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006666C30  stp      x30, x21, [sp, #-0x20]!
006666C34  stp      x20, x19, [sp, #0x10]
006666C38  adrp     x20, #0x9599000
006666C3C  adrp     x21, #0x8f0f000
006666C40  ldrb     w8, [x20, #0xd75]
006666C44  ldr      x21, [x21, #0x2f0] ; GLOBAL Method$HotFix.BattleLogic.DropItemExp.Collect() @ 0x925fd48
006666C48  mov      x19, x0
006666C4C  tbnz     w8, #0, #0x6666c64
006666C50  adrp     x0, #0x8f0f000
006666C54  ldr      x0, [x0, #0x2f0] ; GLOBAL Method$HotFix.BattleLogic.DropItemExp.Collect() @ 0x925fd48
006666C58  bl       #0x382bd14 ; 
006666C5C  mov      w8, #1
006666C60  strb     w8, [x20, #0xd75]
006666C64  ldr      x1, [x21]
006666C68  ldrb     w8, [x1, #0x53]
006666C6C  tbnz     w8, #5, #0x6666c7c
006666C70  ldp      x20, x19, [sp, #0x10]
006666C74  ldp      x30, x21, [sp], #0x20
006666C78  ret      
006666C7C  ldr      x2, [x1, #0x60]
006666C80  mov      x0, x19
006666C84  ldp      x20, x19, [sp, #0x10]
006666C88  ldp      x30, x21, [sp], #0x20
006666C8C  br       x2

