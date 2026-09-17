; HotFix.BattleLogic.CharacterComponentOnHit.WeaponHittedCountData$$.ctor
; RVA 0x670570C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00670570C  stp      x30, x21, [sp, #-0x20]!
006705710  stp      x20, x19, [sp, #0x10]
006705714  adrp     x20, #0x959a000
006705718  adrp     x21, #0x8f17000
00670571C  ldrb     w8, [x20, #0x98a]
006705720  ldr      x21, [x21, #0xa58]
006705724  mov      x19, x0
006705728  tbnz     w8, #0, #0x6705740
00670572C  adrp     x0, #0x8f17000
006705730  ldr      x0, [x0, #0xa58]
006705734  bl       #0x382bd14 ; 
006705738  mov      w8, #1
00670573C  strb     w8, [x20, #0x98a]
006705740  ldr      x1, [x21]
006705744  ldrb     w8, [x1, #0x53]
006705748  tbnz     w8, #5, #0x6705760
00670574C  mov      x0, x19
006705750  ldp      x20, x19, [sp, #0x10]
006705754  mov      x1, xzr
006705758  ldp      x30, x21, [sp], #0x20
00670575C  b        #0x7c335dc ; System.Object$$.ctor
006705760  ldr      x2, [x1, #0x60]
006705764  mov      x0, x19
006705768  ldp      x20, x19, [sp, #0x10]
00670576C  ldp      x30, x21, [sp], #0x20
006705770  br       x2

