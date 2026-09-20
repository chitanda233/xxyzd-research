; HotFix.BattleLogic.DankeSkillCreator$$CheckIsRightSkillType
; RVA 0x6865B3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006865B3C  stp      x30, x23, [sp, #-0x30]!
006865B40  stp      x22, x21, [sp, #0x10]
006865B44  stp      x20, x19, [sp, #0x20]
006865B48  adrp     x22, #0x959b000
006865B4C  adrp     x23, #0x8f23000
006865B50  ldrb     w8, [x22, #0xa04]
006865B54  ldr      x23, [x23, #0xde0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckIsRightSkillType() @ 0x9259d00
006865B58  mov      w19, w2
006865B5C  mov      w20, w1
006865B60  mov      x21, x0
006865B64  tbnz     w8, #0, #0x6865b7c
006865B68  adrp     x0, #0x8f23000
006865B6C  ldr      x0, [x0, #0xde0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckIsRightSkillType() @ 0x9259d00
006865B70  bl       #0x382bd14 ; 
006865B74  mov      w8, #1
006865B78  strb     w8, [x22, #0xa04]
006865B7C  ldr      x3, [x23]
006865B80  ldrb     w8, [x3, #0x53]
006865B84  tbnz     w8, #5, #0x6865ba0
006865B88  cmp      w20, #2
006865B8C  b.eq     #0x6865bc0
006865B90  cmp      w20, #1
006865B94  b.ne     #0x6865bd0
006865B98  cmp      w19, #1
006865B9C  b        #0x6865bc8 ; 
006865BA0  ldr      x4, [x3, #0x60]
006865BA4  mov      x0, x21
006865BA8  mov      w1, w20
006865BAC  mov      w2, w19
006865BB0  ldp      x20, x19, [sp, #0x20]
006865BB4  ldp      x22, x21, [sp, #0x10]
006865BB8  ldp      x30, x23, [sp], #0x30
006865BBC  br       x4
006865BC0  and      w8, w19, #0xfffffffe
006865BC4  cmp      w8, #2
006865BC8  cset     w0, eq
006865BCC  b        #0x6865bd4 ; 
006865BD0  mov      w0, #1
006865BD4  ldp      x20, x19, [sp, #0x20]
006865BD8  ldp      x22, x21, [sp, #0x10]
006865BDC  ldp      x30, x23, [sp], #0x30
006865BE0  ret      

