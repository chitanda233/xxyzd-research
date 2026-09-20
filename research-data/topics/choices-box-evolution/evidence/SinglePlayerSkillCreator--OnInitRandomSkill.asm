; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnInitRandomSkill
; RVA 0x6875BFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006875BFC  str      x30, [sp, #-0x30]!
006875C00  stp      x22, x21, [sp, #0x10]
006875C04  stp      x20, x19, [sp, #0x20]
006875C08  adrp     x21, #0x959b000
006875C0C  adrp     x22, #0x8f24000
006875C10  ldrb     w8, [x21, #0xaac]
006875C14  ldr      x22, [x22, #0x518] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnInitRandomSkill() @ 0x92aa9b0
006875C18  mov      x19, x1
006875C1C  mov      x20, x0
006875C20  tbnz     w8, #0, #0x6875c38
006875C24  adrp     x0, #0x8f24000
006875C28  ldr      x0, [x0, #0x518] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnInitRandomSkill() @ 0x92aa9b0
006875C2C  bl       #0x382bd14 ; 
006875C30  mov      w8, #1
006875C34  strb     w8, [x21, #0xaac]
006875C38  ldr      x2, [x22]
006875C3C  ldrb     w8, [x2, #0x53]
006875C40  tbnz     w8, #5, #0x6875c90
006875C44  mov      x0, x20
006875C48  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875C4C  cbz      x0, #0x6875d04
006875C50  adrp     x22, #0x9598000
006875C54  ldrb     w8, [x22, #0xfc4]
006875C58  mov      x21, x0
006875C5C  cbnz     w8, #0x6875c74
006875C60  adrp     x0, #0x8f05000
006875C64  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006875C68  bl       #0x382bd14 ; 
006875C6C  mov      w8, #1
006875C70  strb     w8, [x22, #0xfc4]
006875C74  adrp     x8, #0x8f05000
006875C78  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006875C7C  ldr      x1, [x8]
006875C80  ldrb     w8, [x1, #0x53]
006875C84  tbnz     w8, #5, #0x6875cac
006875C88  ldr      x0, [x21, #0x220]
006875C8C  b        #0x6875cb8 ; 
006875C90  ldr      x3, [x2, #0x60]
006875C94  mov      x0, x20
006875C98  mov      x1, x19
006875C9C  ldp      x20, x19, [sp, #0x20]
006875CA0  ldp      x22, x21, [sp, #0x10]
006875CA4  ldr      x30, [sp], #0x30
006875CA8  br       x3
006875CAC  ldr      x8, [x1, #0x60]
006875CB0  mov      x0, x21
006875CB4  blr      x8
006875CB8  cbz      x0, #0x6875d04
006875CBC  ldr      x8, [x0]
006875CC0  ldp      x9, x1, [x8, #0x198]
006875CC4  blr      x9
006875CC8  mov      w21, w0
006875CCC  mov      x0, x20
006875CD0  mov      w1, w21
006875CD4  mov      x2, x19
006875CD8  bl       #0x6875d08 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$InitRandoms
006875CDC  ldr      x8, [x20]
006875CE0  mov      x0, x20
006875CE4  mov      w1, w21
006875CE8  mov      x2, x19
006875CEC  ldr      x4, [x8, #0x2d8]
006875CF0  ldr      x3, [x8, #0x2e0]
006875CF4  ldp      x20, x19, [sp, #0x20]
006875CF8  ldp      x22, x21, [sp, #0x10]
006875CFC  ldr      x30, [sp], #0x30
006875D00  br       x4
006875D04  bl       #0x382bfb8 ; 

