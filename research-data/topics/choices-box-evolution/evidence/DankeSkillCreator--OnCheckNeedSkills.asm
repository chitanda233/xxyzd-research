; HotFix.BattleLogic.DankeSkillCreator$$OnCheckNeedSkills
; RVA 0x6865BE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006865BE4  stp      x30, x23, [sp, #-0x30]!
006865BE8  stp      x22, x21, [sp, #0x10]
006865BEC  stp      x20, x19, [sp, #0x20]
006865BF0  adrp     x21, #0x959b000
006865BF4  adrp     x22, #0x8f23000
006865BF8  ldrb     w8, [x21, #0xa06]
006865BFC  ldr      x22, [x22, #0xde8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OnCheckNeedSkills() @ 0x9259dc0
006865C00  mov      w19, w1
006865C04  mov      x20, x0
006865C08  tbnz     w8, #0, #0x6865c20
006865C0C  adrp     x0, #0x8f23000
006865C10  ldr      x0, [x0, #0xde8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OnCheckNeedSkills() @ 0x9259dc0
006865C14  bl       #0x382bd14 ; 
006865C18  mov      w8, #1
006865C1C  strb     w8, [x21, #0xa06]
006865C20  ldr      x2, [x22]
006865C24  ldrb     w8, [x2, #0x53]
006865C28  tbnz     w8, #5, #0x6865d20
006865C2C  mov      x0, x20
006865C30  mov      w1, w19
006865C34  bl       #0x6865d44 ; HotFix.BattleLogic.NormalSkillCreator$$OnCheckNeedSkills
006865C38  ldr      x21, [x20, #0x30]
006865C3C  cbz      x21, #0x6865c80
006865C40  ldr      w8, [x21, #0x18]
006865C44  cmp      w8, #1
006865C48  b.lt     #0x6865c80
006865C4C  mov      x22, xzr
006865C50  add      x23, x21, #0x20
006865C54  cmp      w22, w8
006865C58  b.hs     #0x6865d3c
006865C5C  ldr      x0, [x23, x22, lsl #3]
006865C60  cbz      x0, #0x6865d40
006865C64  mov      w1, w19
006865C68  mov      x2, xzr
006865C6C  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006865C70  ldr      w8, [x21, #0x18]
006865C74  add      x22, x22, #1
006865C78  cmp      w22, w8
006865C7C  b.lt     #0x6865c54
006865C80  ldr      x21, [x20, #0x38]
006865C84  cbz      x21, #0x6865cc8
006865C88  ldr      w8, [x21, #0x18]
006865C8C  cmp      w8, #1
006865C90  b.lt     #0x6865cc8
006865C94  mov      x22, xzr
006865C98  add      x23, x21, #0x20
006865C9C  cmp      w22, w8
006865CA0  b.hs     #0x6865d3c
006865CA4  ldr      x0, [x23, x22, lsl #3]
006865CA8  cbz      x0, #0x6865d40
006865CAC  mov      w1, w19
006865CB0  mov      x2, xzr
006865CB4  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006865CB8  ldr      w8, [x21, #0x18]
006865CBC  add      x22, x22, #1
006865CC0  cmp      w22, w8
006865CC4  b.lt     #0x6865c9c
006865CC8  ldr      x20, [x20, #0x28]
006865CCC  cbz      x20, #0x6865d10
006865CD0  ldr      w8, [x20, #0x18]
006865CD4  cmp      w8, #1
006865CD8  b.lt     #0x6865d10
006865CDC  mov      x21, xzr
006865CE0  add      x22, x20, #0x20
006865CE4  cmp      w21, w8
006865CE8  b.hs     #0x6865d3c
006865CEC  ldr      x0, [x22, x21, lsl #3]
006865CF0  cbz      x0, #0x6865d40
006865CF4  mov      w1, w19
006865CF8  mov      x2, xzr
006865CFC  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006865D00  ldr      w8, [x20, #0x18]
006865D04  add      x21, x21, #1
006865D08  cmp      w21, w8
006865D0C  b.lt     #0x6865ce4
006865D10  ldp      x20, x19, [sp, #0x20]
006865D14  ldp      x22, x21, [sp, #0x10]
006865D18  ldp      x30, x23, [sp], #0x30
006865D1C  ret      
006865D20  ldr      x3, [x2, #0x60]
006865D24  mov      x0, x20
006865D28  mov      w1, w19
006865D2C  ldp      x20, x19, [sp, #0x20]
006865D30  ldp      x22, x21, [sp, #0x10]
006865D34  ldp      x30, x23, [sp], #0x30
006865D38  br       x3
006865D3C  bl       #0x382bfc0 ; 
006865D40  bl       #0x382bfb8 ; 

