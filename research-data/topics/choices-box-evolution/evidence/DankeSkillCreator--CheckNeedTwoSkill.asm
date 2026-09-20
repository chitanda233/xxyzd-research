; HotFix.BattleLogic.DankeSkillCreator$$CheckNeedTwoSkill
; RVA 0x685D6D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685D6D8  str      x30, [sp, #-0x30]!
00685D6DC  stp      x22, x21, [sp, #0x10]
00685D6E0  stp      x20, x19, [sp, #0x20]
00685D6E4  adrp     x20, #0x959b000
00685D6E8  adrp     x21, #0x8f23000
00685D6EC  ldrb     w8, [x20, #0x9ec]
00685D6F0  ldr      x21, [x21, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckNeedTwoSkill() @ 0x9259d18
00685D6F4  mov      x19, x0
00685D6F8  tbnz     w8, #0, #0x685d71c
00685D6FC  adrp     x0, #0x8f23000
00685D700  ldr      x0, [x0, #0xb58] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckNeedTwoSkill() @ 0x9259d18
00685D704  bl       #0x382bd14 ; 
00685D708  adrp     x0, #0x8f09000
00685D70C  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00685D710  bl       #0x382bd14 ; 
00685D714  mov      w8, #1
00685D718  strb     w8, [x20, #0x9ec]
00685D71C  ldr      x1, [x21]
00685D720  ldrb     w8, [x1, #0x53]
00685D724  tbnz     w8, #5, #0x685d774
00685D728  mov      x0, x19
00685D72C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685D730  cbz      x0, #0x685d8a0
00685D734  adrp     x21, #0x9598000
00685D738  ldrb     w8, [x21, #0xfcc]
00685D73C  mov      x20, x0
00685D740  cbnz     w8, #0x685d758
00685D744  adrp     x0, #0x8f06000
00685D748  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685D74C  bl       #0x382bd14 ; 
00685D750  mov      w8, #1
00685D754  strb     w8, [x21, #0xfcc]
00685D758  adrp     x8, #0x8f06000
00685D75C  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685D760  ldr      x1, [x8]
00685D764  ldrb     w8, [x1, #0x53]
00685D768  tbnz     w8, #5, #0x685d78c
00685D76C  ldr      x20, [x20, #0x200]
00685D770  b        #0x685d79c ; 
00685D774  ldr      x2, [x1, #0x60]
00685D778  mov      x0, x19
00685D77C  ldp      x20, x19, [sp, #0x20]
00685D780  ldp      x22, x21, [sp, #0x10]
00685D784  ldr      x30, [sp], #0x30
00685D788  br       x2
00685D78C  ldr      x8, [x1, #0x60]
00685D790  mov      x0, x20
00685D794  blr      x8
00685D798  mov      x20, x0
00685D79C  mov      x0, x19
00685D7A0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685D7A4  cbz      x0, #0x685d8a0
00685D7A8  adrp     x22, #0x9599000
00685D7AC  ldrb     w8, [x22, #0x4d6]
00685D7B0  mov      x21, x0
00685D7B4  cbnz     w8, #0x685d7cc
00685D7B8  adrp     x0, #0x8f09000
00685D7BC  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
00685D7C0  bl       #0x382bd14 ; 
00685D7C4  mov      w8, #1
00685D7C8  strb     w8, [x22, #0x4d6]
00685D7CC  adrp     x8, #0x8f09000
00685D7D0  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
00685D7D4  ldr      x1, [x8]
00685D7D8  ldrb     w8, [x1, #0x53]
00685D7DC  tbnz     w8, #5, #0x685d7e8
00685D7E0  ldr      w1, [x21, #0x290]
00685D7E4  b        #0x685d7f8 ; 
00685D7E8  ldr      x8, [x1, #0x60]
00685D7EC  mov      x0, x21
00685D7F0  blr      x8
00685D7F4  mov      w1, w0
00685D7F8  cbz      x20, #0x685d8a0
00685D7FC  mov      x0, x20
00685D800  mov      x2, xzr
00685D804  bl       #0x64e3b1c ; LocalModels.LocalModelManager$$GetChapter_MainChapter
00685D808  ldr      x8, [x19, #0x58]
00685D80C  cbz      x8, #0x685d8a0
00685D810  adrp     x9, #0x8f09000
00685D814  ldr      x9, [x9, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00685D818  mov      x19, x0
00685D81C  mov      x0, x8
00685D820  ldr      x1, [x9]
00685D824  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00685D828  cbz      x0, #0x685d8a0
00685D82C  mov      x1, xzr
00685D830  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
00685D834  cbz      x19, #0x685d8a0
00685D838  adrp     x21, #0x959b000
00685D83C  ldrb     w8, [x21, #0xb82]
00685D840  mov      w20, w0
00685D844  cbnz     w8, #0x685d85c
00685D848  adrp     x0, #0x8f23000
00685D84C  ldr      x0, [x0, #0xb60] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_TwoSkillsProtectLevel() @ 0x924ae58
00685D850  bl       #0x382bd14 ; 
00685D854  mov      w8, #1
00685D858  strb     w8, [x21, #0xb82]
00685D85C  adrp     x8, #0x8f23000
00685D860  ldr      x8, [x8, #0xb60] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_TwoSkillsProtectLevel() @ 0x924ae58
00685D864  ldr      x1, [x8]
00685D868  ldrb     w8, [x1, #0x53]
00685D86C  tbnz     w8, #5, #0x685d878
00685D870  ldr      w0, [x19, #0x168]
00685D874  b        #0x685d884 ; 
00685D878  ldr      x8, [x1, #0x60]
00685D87C  mov      x0, x19
00685D880  blr      x8
00685D884  add      w8, w20, #1
00685D888  ldp      x20, x19, [sp, #0x20]
00685D88C  ldp      x22, x21, [sp, #0x10]
00685D890  cmp      w8, w0
00685D894  cset     w0, le
00685D898  ldr      x30, [sp], #0x30
00685D89C  ret      
00685D8A0  bl       #0x382bfb8 ; 

