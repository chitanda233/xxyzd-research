; HotFix.BattleLogic.DankeSkillCreator$$IsFirst
; RVA 0x685DEE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685DEE8  stp      x30, x21, [sp, #-0x20]!
00685DEEC  stp      x20, x19, [sp, #0x10]
00685DEF0  adrp     x20, #0x959b000
00685DEF4  adrp     x21, #0x8f23000
00685DEF8  ldrb     w8, [x20, #0x9f0]
00685DEFC  ldr      x21, [x21, #0xb90] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.IsFirst() @ 0x9259db0
00685DF00  mov      x19, x0
00685DF04  tbnz     w8, #0, #0x685df1c
00685DF08  adrp     x0, #0x8f23000
00685DF0C  ldr      x0, [x0, #0xb90] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.IsFirst() @ 0x9259db0
00685DF10  bl       #0x382bd14 ; 
00685DF14  mov      w8, #1
00685DF18  strb     w8, [x20, #0x9f0]
00685DF1C  ldr      x1, [x21]
00685DF20  ldrb     w8, [x1, #0x53]
00685DF24  tbnz     w8, #5, #0x685df74
00685DF28  mov      x0, x19
00685DF2C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685DF30  cbz      x0, #0x685dfa8
00685DF34  adrp     x20, #0x959b000
00685DF38  ldrb     w8, [x20, #0xb84]
00685DF3C  mov      x19, x0
00685DF40  cbnz     w8, #0x685df58
00685DF44  adrp     x0, #0x8f23000
00685DF48  ldr      x0, [x0, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685DF4C  bl       #0x382bd14 ; 
00685DF50  mov      w8, #1
00685DF54  strb     w8, [x20, #0xb84]
00685DF58  adrp     x8, #0x8f23000
00685DF5C  ldr      x8, [x8, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685DF60  ldr      x1, [x8]
00685DF64  ldrb     w8, [x1, #0x53]
00685DF68  tbnz     w8, #5, #0x685df88
00685DF6C  ldr      w0, [x19, #0x2c4]
00685DF70  b        #0x685df94 ; 
00685DF74  ldr      x2, [x1, #0x60]
00685DF78  mov      x0, x19
00685DF7C  ldp      x20, x19, [sp, #0x10]
00685DF80  ldp      x30, x21, [sp], #0x20
00685DF84  br       x2
00685DF88  ldr      x8, [x1, #0x60]
00685DF8C  mov      x0, x19
00685DF90  blr      x8
00685DF94  ldp      x20, x19, [sp, #0x10]
00685DF98  cmp      w0, #0
00685DF9C  cset     w0, gt
00685DFA0  ldp      x30, x21, [sp], #0x20
00685DFA4  ret      
00685DFA8  bl       #0x382bfb8 ; 

