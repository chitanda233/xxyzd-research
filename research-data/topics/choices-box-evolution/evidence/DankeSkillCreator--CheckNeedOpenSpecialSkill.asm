; HotFix.BattleLogic.DankeSkillCreator$$CheckNeedOpenSpecialSkill
; RVA 0x6862BE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006862BE8  stp      x30, x21, [sp, #-0x20]!
006862BEC  stp      x20, x19, [sp, #0x10]
006862BF0  adrp     x20, #0x959b000
006862BF4  adrp     x21, #0x8f23000
006862BF8  ldrb     w8, [x20, #0x9f8]
006862BFC  ldr      x21, [x21, #0xd18] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckNeedOpenSpecialSkill() @ 0x9259d10
006862C00  mov      x19, x0
006862C04  tbnz     w8, #0, #0x6862c28
006862C08  adrp     x0, #0x8f23000
006862C0C  ldr      x0, [x0, #0xd18] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckNeedOpenSpecialSkill() @ 0x9259d10
006862C10  bl       #0x382bd14 ; 
006862C14  adrp     x0, #0x8ec2000
006862C18  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006862C1C  bl       #0x382bd14 ; 
006862C20  mov      w8, #1
006862C24  strb     w8, [x20, #0x9f8]
006862C28  ldr      x1, [x21]
006862C2C  ldrb     w8, [x1, #0x53]
006862C30  tbnz     w8, #5, #0x6862c54
006862C34  ldr      x8, [x19, #0xc0]
006862C38  cbz      x8, #0x6862c68
006862C3C  ldr      w8, [x8, #0x18]
006862C40  ldp      x20, x19, [sp, #0x10]
006862C44  cmp      w8, #0
006862C48  cset     w0, gt
006862C4C  ldp      x30, x21, [sp], #0x20
006862C50  ret      
006862C54  ldr      x2, [x1, #0x60]
006862C58  mov      x0, x19
006862C5C  ldp      x20, x19, [sp, #0x10]
006862C60  ldp      x30, x21, [sp], #0x20
006862C64  br       x2
006862C68  bl       #0x382bfb8 ; 

