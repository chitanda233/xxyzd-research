; HotFix.BattleLogic.DankeSkillCreator$$GetOneStarRandomPool
; RVA 0x6865A48; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006865A48  stp      x30, x23, [sp, #-0x30]!
006865A4C  stp      x22, x21, [sp, #0x10]
006865A50  stp      x20, x19, [sp, #0x20]
006865A54  adrp     x22, #0x959b000
006865A58  adrp     x23, #0x8f23000
006865A5C  ldrb     w8, [x22, #0xa02]
006865A60  ldr      x23, [x23, #0xdd8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetOneStarRandomPool() @ 0x9259d50
006865A64  mov      x19, x2
006865A68  mov      x20, x1
006865A6C  mov      x21, x0
006865A70  tbnz     w8, #0, #0x6865a88
006865A74  adrp     x0, #0x8f23000
006865A78  ldr      x0, [x0, #0xdd8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetOneStarRandomPool() @ 0x9259d50
006865A7C  bl       #0x382bd14 ; 
006865A80  mov      w8, #1
006865A84  strb     w8, [x22, #0xa02]
006865A88  ldr      x3, [x23]
006865A8C  ldrb     w8, [x3, #0x53]
006865A90  tbnz     w8, #5, #0x6865afc
006865A94  cbz      x19, #0x6865b38
006865A98  ldr      w9, [x19, #0x18]
006865A9C  cmp      w9, #1
006865AA0  b.lt     #0x6865b1c
006865AA4  mov      w8, wzr
006865AA8  mov      w21, wzr
006865AAC  cmp      w8, w9
006865AB0  b.hs     #0x6865b34
006865AB4  cbz      x20, #0x6865b38
006865AB8  ldr      w9, [x20, #0x18]
006865ABC  sxtw     x22, w8
006865AC0  cmp      w22, w9
006865AC4  b.hs     #0x6865b34
006865AC8  add      x8, x19, x22, lsl #3
006865ACC  ldr      x0, [x8, #0x20]
006865AD0  cbz      x0, #0x6865b38
006865AD4  add      x8, x20, x22, lsl #3
006865AD8  ldr      x1, [x8, #0x20]
006865ADC  mov      x2, xzr
006865AE0  bl       #0x6635690 ; HotFix.BattleLogic.WeightRandom$$GetOneStarSkill
006865AE4  ldr      w9, [x19, #0x18]
006865AE8  add      w8, w22, #1
006865AEC  add      w21, w0, w21
006865AF0  cmp      w8, w9
006865AF4  b.lt     #0x6865aac
006865AF8  b        #0x6865b20 ; 
006865AFC  ldr      x4, [x3, #0x60]
006865B00  mov      x0, x21
006865B04  mov      x1, x20
006865B08  mov      x2, x19
006865B0C  ldp      x20, x19, [sp, #0x20]
006865B10  ldp      x22, x21, [sp, #0x10]
006865B14  ldp      x30, x23, [sp], #0x30
006865B18  br       x4
006865B1C  mov      w21, wzr
006865B20  mov      w0, w21
006865B24  ldp      x20, x19, [sp, #0x20]
006865B28  ldp      x22, x21, [sp, #0x10]
006865B2C  ldp      x30, x23, [sp], #0x30
006865B30  ret      
006865B34  bl       #0x382bfc0 ; 
006865B38  bl       #0x382bfb8 ; 

