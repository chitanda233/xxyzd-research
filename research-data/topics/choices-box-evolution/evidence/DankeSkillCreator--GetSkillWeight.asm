; HotFix.BattleLogic.DankeSkillCreator$$GetSkillWeight
; RVA 0x68654A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068654A8  str      x30, [sp, #-0x60]!
0068654AC  stp      x28, x27, [sp, #0x10]
0068654B0  stp      x26, x25, [sp, #0x20]
0068654B4  stp      x24, x23, [sp, #0x30]
0068654B8  stp      x22, x21, [sp, #0x40]
0068654BC  stp      x20, x19, [sp, #0x50]
0068654C0  adrp     x20, #0x959b000
0068654C4  str      w1, [sp, #0xc]
0068654C8  adrp     x21, #0x8f23000
0068654CC  ldrb     w8, [x20, #0x9fe]
0068654D0  ldr      x21, [x21, #0xda8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetSkillWeight() @ 0x9259d90
0068654D4  mov      w23, w1
0068654D8  mov      x19, x0
0068654DC  tbnz     w8, #0, #0x686553c
0068654E0  adrp     x0, #0x8f23000
0068654E4  ldr      x0, [x0, #0xda8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetSkillWeight() @ 0x9259d90
0068654E8  bl       #0x382bd14 ; 
0068654EC  adrp     x0, #0x8ebf000
0068654F0  ldr      x0, [x0, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
0068654F4  bl       #0x382bd14 ; 
0068654F8  adrp     x0, #0x8f23000
0068654FC  ldr      x0, [x0, #0xdb0] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d76c8
006865500  bl       #0x382bd14 ; 
006865504  adrp     x0, #0x8f23000
006865508  ldr      x0, [x0, #0xdb8] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d80e0
00686550C  bl       #0x382bd14 ; 
006865510  adrp     x0, #0x8ebf000
006865514  ldr      x0, [x0, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
006865518  bl       #0x382bd14 ; 
00686551C  adrp     x0, #0x8f23000
006865520  ldr      x0, [x0, #0xdc0] ; GLOBAL GetSkillWeight Error curSkillData == null skillId =  @ 0x92fee60
006865524  bl       #0x382bd14 ; 
006865528  adrp     x0, #0x8f23000
00686552C  ldr      x0, [x0, #0xdc8] ; GLOBAL GetSkillWeight Error  skillId =  @ 0x92fee58
006865530  bl       #0x382bd14 ; 
006865534  mov      w8, #1
006865538  strb     w8, [x20, #0x9fe]
00686553C  ldr      x2, [x21]
006865540  ldrb     w8, [x2, #0x53]
006865544  tbnz     w8, #5, #0x686564c
006865548  adrp     x20, #0x8f06000
00686554C  adrp     x21, #0x8f0d000
006865550  adrp     x22, #0x8f23000
006865554  ldr      x20, [x20, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006865558  ldr      x21, [x21, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
00686555C  ldr      x22, [x22, #0xda0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_CoverSkill() @ 0x92ac410
006865560  adrp     x25, #0x9598000
006865564  mov      w26, #1
006865568  adrp     x27, #0x9599000
00686556C  adrp     x28, #0x959b000
006865570  mov      x0, x19
006865574  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006865578  cbz      x0, #0x6865970
00686557C  ldrb     w8, [x25, #0xfcc]
006865580  mov      x24, x0
006865584  cbnz     w8, #0x6865594
006865588  mov      x0, x20
00686558C  bl       #0x382bd14 ; 
006865590  strb     w26, [x25, #0xfcc]
006865594  ldr      x1, [x20]
006865598  ldrb     w8, [x1, #0x53]
00686559C  tbnz     w8, #5, #0x68655a8
0068655A0  ldr      x0, [x24, #0x200]
0068655A4  b        #0x68655b4 ; 
0068655A8  ldr      x8, [x1, #0x60]
0068655AC  mov      x0, x24
0068655B0  blr      x8
0068655B4  cbz      x0, #0x6865970
0068655B8  mov      w1, w23
0068655BC  mov      x2, xzr
0068655C0  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0068655C4  cbz      x0, #0x6865674
0068655C8  ldrb     w8, [x27, #0xac8]
0068655CC  mov      x23, x0
0068655D0  cbnz     w8, #0x68655e0
0068655D4  mov      x0, x21
0068655D8  bl       #0x382bd14 ; 
0068655DC  strb     w26, [x27, #0xac8]
0068655E0  ldr      x1, [x21]
0068655E4  ldrb     w8, [x1, #0x53]
0068655E8  tbnz     w8, #5, #0x68655f4
0068655EC  ldr      w0, [x23, #0x58]
0068655F0  b        #0x6865600 ; 
0068655F4  ldr      x8, [x1, #0x60]
0068655F8  mov      x0, x23
0068655FC  blr      x8
006865600  cmp      w0, #1
006865604  b.eq     #0x68656b0
006865608  ldrb     w8, [x28, #0xb8b]
00686560C  cbnz     w8, #0x686561c
006865610  mov      x0, x22
006865614  bl       #0x382bd14 ; 
006865618  strb     w26, [x28, #0xb8b]
00686561C  ldr      x1, [x22]
006865620  ldrb     w8, [x1, #0x53]
006865624  tbnz     w8, #5, #0x6865630
006865628  ldr      w23, [x23, #0xa0]
00686562C  b        #0x6865640 ; 
006865630  ldr      x8, [x1, #0x60]
006865634  mov      x0, x23
006865638  blr      x8
00686563C  mov      w23, w0
006865640  str      w23, [sp, #0xc]
006865644  cbnz     w23, #0x6865570
006865648  b        #0x68656a8 ; 
00686564C  ldr      x3, [x2, #0x60]
006865650  mov      x0, x19
006865654  mov      w1, w23
006865658  ldp      x20, x19, [sp, #0x50]
00686565C  ldp      x22, x21, [sp, #0x40]
006865660  ldp      x24, x23, [sp, #0x30]
006865664  ldp      x26, x25, [sp, #0x20]
006865668  ldp      x28, x27, [sp, #0x10]
00686566C  ldr      x30, [sp], #0x60
006865670  br       x3
006865674  add      x0, sp, #0xc
006865678  mov      x1, xzr
00686567C  bl       #0x7bd22a0 ; System.Int32$$ToString
006865680  adrp     x8, #0x8f23000
006865684  ldr      x8, [x8, #0xdc0] ; GLOBAL GetSkillWeight Error curSkillData == null skillId =  @ 0x92fee60
006865688  mov      x1, x0
00686568C  mov      x2, xzr
006865690  ldr      x8, [x8]
006865694  mov      x0, x8
006865698  bl       #0x79d469c ; System.String$$Concat
00686569C  mov      x1, x0
0068656A0  mov      x0, x19
0068656A4  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
0068656A8  mov      w21, wzr
0068656AC  b        #0x6865950 ; 
0068656B0  mov      x0, x19
0068656B4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068656B8  cbz      x0, #0x6865970
0068656BC  ldrb     w8, [x25, #0xfcc]
0068656C0  mov      x21, x0
0068656C4  cbnz     w8, #0x68656dc
0068656C8  adrp     x0, #0x8f06000
0068656CC  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068656D0  bl       #0x382bd14 ; 
0068656D4  mov      w8, #1
0068656D8  strb     w8, [x25, #0xfcc]
0068656DC  ldr      x1, [x20]
0068656E0  ldrb     w8, [x1, #0x53]
0068656E4  tbnz     w8, #5, #0x68656f0
0068656E8  ldr      x0, [x21, #0x200]
0068656EC  b        #0x68656fc ; 
0068656F0  ldr      x8, [x1, #0x60]
0068656F4  mov      x0, x21
0068656F8  blr      x8
0068656FC  cbz      x0, #0x6865970
006865700  mov      x1, xzr
006865704  bl       #0x64d08d0 ; LocalModels.LocalModelManager$$GetSkillGroup_SurvivorGroupElements
006865708  cbz      x0, #0x6865970
00686570C  adrp     x10, #0x8f23000
006865710  ldr      x8, [x0]
006865714  ldr      x10, [x10, #0xdb0] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d76c8
006865718  mov      x20, x0
00686571C  ldrh     w9, [x8, #0x12e]
006865720  ldr      x1, [x10]
006865724  cbz      x9, #0x6865748
006865728  ldr      x10, [x8, #0xb0]
00686572C  add      x10, x10, #8
006865730  ldur     x11, [x10, #-8]
006865734  cmp      x11, x1
006865738  b.eq     #0x6865758
00686573C  subs     x9, x9, #1
006865740  add      x10, x10, #0x10
006865744  b.ne     #0x6865730
006865748  mov      x0, x20
00686574C  mov      w2, wzr
006865750  bl       #0x3a7e710 ; 
006865754  b        #0x6865764 ; 
006865758  ldrsw    x9, [x10]
00686575C  add      x8, x8, x9, lsl #4
006865760  add      x0, x8, #0x138
006865764  ldp      x8, x1, [x0]
006865768  mov      x0, x20
00686576C  blr      x8
006865770  adrp     x24, #0x8ebf000
006865774  adrp     x25, #0x8f23000
006865778  adrp     x22, #0x8f23000
00686577C  ldr      x24, [x24, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
006865780  ldr      x25, [x25, #0xdb8] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d80e0
006865784  ldr      x22, [x22, #0xdd0] ; GLOBAL Method$LocalModels.Bean.SkillGroup_SurvivorGroup.get_GetID() @ 0x92ab6a8
006865788  mov      x20, x0
00686578C  mov      w0, wzr
006865790  adrp     x26, #0x959b000
006865794  mov      w27, #1
006865798  mov      w21, w0
00686579C  cbz      x20, #0x6865974
0068657A0  ldr      x8, [x20]
0068657A4  ldr      x1, [x24]
0068657A8  ldrh     w9, [x8, #0x12e]
0068657AC  cbz      x9, #0x68657d0
0068657B0  ldr      x10, [x8, #0xb0]
0068657B4  add      x10, x10, #8
0068657B8  ldur     x11, [x10, #-8]
0068657BC  cmp      x11, x1
0068657C0  b.eq     #0x68657e0
0068657C4  subs     x9, x9, #1
0068657C8  add      x10, x10, #0x10
0068657CC  b.ne     #0x68657b8
0068657D0  mov      x0, x20
0068657D4  mov      w2, wzr
0068657D8  bl       #0x3a7e710 ; 
0068657DC  b        #0x68657ec ; 
0068657E0  ldrsw    x9, [x10]
0068657E4  add      x8, x8, x9, lsl #4
0068657E8  add      x0, x8, #0x138
0068657EC  ldp      x8, x1, [x0]
0068657F0  mov      x0, x20
0068657F4  blr      x8
0068657F8  tbz      w0, #0, #0x68658ac
0068657FC  ldr      x8, [x20]
006865800  ldr      x1, [x25]
006865804  ldrh     w9, [x8, #0x12e]
006865808  cbz      x9, #0x686582c
00686580C  ldr      x10, [x8, #0xb0]
006865810  add      x10, x10, #8
006865814  ldur     x11, [x10, #-8]
006865818  cmp      x11, x1
00686581C  b.eq     #0x686583c
006865820  subs     x9, x9, #1
006865824  add      x10, x10, #0x10
006865828  b.ne     #0x6865814
00686582C  mov      x0, x20
006865830  mov      w2, wzr
006865834  bl       #0x3a7e710 ; 
006865838  b        #0x6865848 ; 
00686583C  ldrsw    x9, [x10]
006865840  add      x8, x8, x9, lsl #4
006865844  add      x0, x8, #0x138
006865848  ldp      x8, x1, [x0]
00686584C  mov      x0, x20
006865850  blr      x8
006865854  mov      x23, x0
006865858  cbz      x0, #0x6865978
00686585C  ldrb     w8, [x26, #0xb8c]
006865860  cbnz     w8, #0x6865870
006865864  mov      x0, x22
006865868  bl       #0x382bd14 ; 
00686586C  strb     w27, [x26, #0xb8c]
006865870  ldr      x1, [x22]
006865874  ldrb     w8, [x1, #0x53]
006865878  tbnz     w8, #5, #0x6865884
00686587C  ldr      w0, [x23, #0x24]
006865880  b        #0x6865890 ; 
006865884  ldr      x8, [x1, #0x60]
006865888  mov      x0, x23
00686588C  blr      x8
006865890  ldr      w8, [sp, #0xc]
006865894  cmp      w0, w8
006865898  b.ne     #0x686579c
00686589C  mov      x0, x19
0068658A0  mov      x1, x23
0068658A4  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
0068658A8  b        #0x6865798 ; 
0068658AC  mov      x22, xzr
0068658B0  cbz      x20, #0x6865914
0068658B4  adrp     x10, #0x8ebf000
0068658B8  ldr      x8, [x20]
0068658BC  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
0068658C0  ldrh     w9, [x8, #0x12e]
0068658C4  ldr      x1, [x10]
0068658C8  cbz      x9, #0x68658ec
0068658CC  ldr      x10, [x8, #0xb0]
0068658D0  add      x10, x10, #8
0068658D4  ldur     x11, [x10, #-8]
0068658D8  cmp      x11, x1
0068658DC  b.eq     #0x68658fc
0068658E0  subs     x9, x9, #1
0068658E4  add      x10, x10, #0x10
0068658E8  b.ne     #0x68658d4
0068658EC  mov      x0, x20
0068658F0  mov      w2, wzr
0068658F4  bl       #0x3a7e710 ; 
0068658F8  b        #0x6865908 ; 
0068658FC  ldrsw    x9, [x10]
006865900  add      x8, x8, x9, lsl #4
006865904  add      x0, x8, #0x138
006865908  ldp      x8, x1, [x0]
00686590C  mov      x0, x20
006865910  blr      x8
006865914  cbnz     x22, #0x686597c
006865918  cbnz     w21, #0x6865950
00686591C  add      x0, sp, #0xc
006865920  mov      x1, xzr
006865924  bl       #0x7bd22a0 ; System.Int32$$ToString
006865928  adrp     x8, #0x8f23000
00686592C  ldr      x8, [x8, #0xdc8] ; GLOBAL GetSkillWeight Error  skillId =  @ 0x92fee58
006865930  mov      x1, x0
006865934  mov      x2, xzr
006865938  ldr      x8, [x8]
00686593C  mov      x0, x8
006865940  bl       #0x79d469c ; System.String$$Concat
006865944  mov      x1, x0
006865948  mov      x0, x19
00686594C  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006865950  mov      w0, w21
006865954  ldp      x20, x19, [sp, #0x50]
006865958  ldp      x22, x21, [sp, #0x40]
00686595C  ldp      x24, x23, [sp, #0x30]
006865960  ldp      x26, x25, [sp, #0x20]
006865964  ldp      x28, x27, [sp, #0x10]
006865968  ldr      x30, [sp], #0x60
00686596C  ret      
006865970  bl       #0x382bfb8 ; 
006865974  bl       #0x382bfb8 ; 
006865978  bl       #0x382bfb8 ; 
00686597C  mov      x0, x22
006865980  bl       #0x382bfb0 ; 
006865984  b        #0x68659a0 ; 
006865988  b        #0x68659a0 ; 
00686598C  b        #0x68659a0 ; 
006865990  mov      x23, x0
006865994  mov      w21, wzr
006865998  b        #0x68659a4 ; 
00686599C  b        #0x68659a0 ; 
0068659A0  mov      x23, x0
0068659A4  cmp      w1, #1
0068659A8  b.ne     #0x68659c0
0068659AC  mov      x0, x23
0068659B0  bl       #0x89eda50 ; 
0068659B4  ldr      x22, [x0]
0068659B8  bl       #0x89eda60 ; 
0068659BC  b        #0x68658b0 ; 
0068659C0  mov      x22, xzr
0068659C4  b        #0x68659cc ; 
0068659C8  mov      x23, x0
0068659CC  cbz      x20, #0x6865a30
0068659D0  adrp     x10, #0x8ebf000
0068659D4  ldr      x8, [x20]
0068659D8  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
0068659DC  ldrh     w9, [x8, #0x12e]
0068659E0  ldr      x1, [x10]
0068659E4  cbz      x9, #0x6865a08
0068659E8  ldr      x10, [x8, #0xb0]
0068659EC  add      x10, x10, #8
0068659F0  ldur     x11, [x10, #-8]
0068659F4  cmp      x11, x1
0068659F8  b.eq     #0x6865a18
0068659FC  subs     x9, x9, #1
006865A00  add      x10, x10, #0x10
006865A04  b.ne     #0x68659f0
006865A08  mov      x0, x20
006865A0C  mov      w2, wzr
006865A10  bl       #0x3a7e710 ; 
006865A14  b        #0x6865a24 ; 
006865A18  ldrsw    x9, [x10]
006865A1C  add      x8, x8, x9, lsl #4
006865A20  add      x0, x8, #0x138
006865A24  ldp      x8, x1, [x0]
006865A28  mov      x0, x20
006865A2C  blr      x8
006865A30  cbnz     x22, #0x6865a3c
006865A34  mov      x0, x23
006865A38  bl       #0x3b56bfc ; 
006865A3C  mov      x0, x22
006865A40  bl       #0x382bfb0 ; 
006865A44  bl       #0x3442448 ; 

