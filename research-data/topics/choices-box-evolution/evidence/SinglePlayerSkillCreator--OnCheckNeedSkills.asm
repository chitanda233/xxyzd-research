; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCheckNeedSkills
; RVA 0x6874BC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874BC8  str      x30, [sp, #-0x30]!
006874BCC  stp      x22, x21, [sp, #0x10]
006874BD0  stp      x20, x19, [sp, #0x20]
006874BD4  adrp     x21, #0x959b000
006874BD8  adrp     x22, #0x8f24000
006874BDC  ldrb     w8, [x21, #0xab1]
006874BE0  ldr      x22, [x22, #0x4d0] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnCheckNeedSkills() @ 0x92aa998
006874BE4  mov      w19, w1
006874BE8  mov      x20, x0
006874BEC  tbnz     w8, #0, #0x6874c04
006874BF0  adrp     x0, #0x8f24000
006874BF4  ldr      x0, [x0, #0x4d0] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnCheckNeedSkills() @ 0x92aa998
006874BF8  bl       #0x382bd14 ; 
006874BFC  mov      w8, #1
006874C00  strb     w8, [x21, #0xab1]
006874C04  ldr      x2, [x22]
006874C08  ldrb     w8, [x2, #0x53]
006874C0C  tbnz     w8, #5, #0x6874cc0
006874C10  ldr      x21, [x20, #0x18]
006874C14  cbz      x21, #0x6874cf0
006874C18  ldr      w8, [x21, #0x18]
006874C1C  cmp      w8, #1
006874C20  b.lt     #0x6874c58
006874C24  mov      w22, wzr
006874C28  cmp      w22, w8
006874C2C  b.hs     #0x6874cec
006874C30  add      x8, x21, w22, sxtw #3
006874C34  ldr      x0, [x8, #0x20]
006874C38  cbz      x0, #0x6874cf0
006874C3C  mov      w1, w19
006874C40  mov      x2, xzr
006874C44  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006874C48  ldr      w8, [x21, #0x18]
006874C4C  add      w22, w22, #1
006874C50  cmp      w22, w8
006874C54  b.lt     #0x6874c28
006874C58  ldr      x21, [x20, #0x20]
006874C5C  cbz      x21, #0x6874cf0
006874C60  ldr      w8, [x21, #0x18]
006874C64  cmp      w8, #1
006874C68  b.lt     #0x6874ca0
006874C6C  mov      w22, wzr
006874C70  cmp      w22, w8
006874C74  b.hs     #0x6874cec
006874C78  add      x8, x21, w22, sxtw #3
006874C7C  ldr      x0, [x8, #0x20]
006874C80  cbz      x0, #0x6874cf0
006874C84  mov      w1, w19
006874C88  mov      x2, xzr
006874C8C  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006874C90  ldr      w8, [x21, #0x18]
006874C94  add      w22, w22, #1
006874C98  cmp      w22, w8
006874C9C  b.lt     #0x6874c70
006874CA0  ldr      x0, [x20, #0x40]
006874CA4  cbz      x0, #0x6874cdc
006874CA8  mov      w1, w19
006874CAC  ldp      x20, x19, [sp, #0x20]
006874CB0  ldp      x22, x21, [sp, #0x10]
006874CB4  mov      x2, xzr
006874CB8  ldr      x30, [sp], #0x30
006874CBC  b        #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006874CC0  ldr      x3, [x2, #0x60]
006874CC4  mov      x0, x20
006874CC8  mov      w1, w19
006874CCC  ldp      x20, x19, [sp, #0x20]
006874CD0  ldp      x22, x21, [sp, #0x10]
006874CD4  ldr      x30, [sp], #0x30
006874CD8  br       x3
006874CDC  ldp      x20, x19, [sp, #0x20]
006874CE0  ldp      x22, x21, [sp, #0x10]
006874CE4  ldr      x30, [sp], #0x30
006874CE8  ret      
006874CEC  bl       #0x382bfc0 ; 
006874CF0  bl       #0x382bfb8 ; 

