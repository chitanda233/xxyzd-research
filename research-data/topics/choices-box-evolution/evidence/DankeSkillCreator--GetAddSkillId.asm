; HotFix.BattleLogic.DankeSkillCreator$$GetAddSkillId
; RVA 0x6862418; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006862418  sub      sp, sp, #0x70
00686241C  stp      x29, x30, [sp, #0x10]
006862420  stp      x28, x27, [sp, #0x20]
006862424  stp      x26, x25, [sp, #0x30]
006862428  stp      x24, x23, [sp, #0x40]
00686242C  stp      x22, x21, [sp, #0x50]
006862430  stp      x20, x19, [sp, #0x60]
006862434  adrp     x19, #0x959b000
006862438  adrp     x20, #0x8f23000
00686243C  ldrb     w8, [x19, #0x9ff]
006862440  ldr      x20, [x20, #0xd00] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetAddSkillId() @ 0x9259d28
006862444  mov      x23, x4
006862448  mov      x22, x2
00686244C  mov      x26, x1
006862450  mov      x21, x0
006862454  str      x3, [sp]
006862458  tbnz     w8, #0, #0x686248c
00686245C  adrp     x0, #0x8f23000
006862460  ldr      x0, [x0, #0xd00] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetAddSkillId() @ 0x9259d28
006862464  bl       #0x382bd14 ; 
006862468  adrp     x0, #0x8eea000
00686246C  ldr      x0, [x0, #0x110] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.Add() @ 0x920b040
006862470  bl       #0x382bd14 ; 
006862474  adrp     x0, #0x8f08000
006862478  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00686247C  bl       #0x382bd14 ; 
006862480  ldr      x3, [sp]
006862484  mov      w8, #1
006862488  strb     w8, [x19, #0x9ff]
00686248C  ldr      x5, [x20]
006862490  ldrb     w8, [x5, #0x53]
006862494  tbnz     w8, #5, #0x68624f8
006862498  mov      w1, #1
00686249C  mov      x0, x26
0068624A0  mov      x2, xzr
0068624A4  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
0068624A8  sub      w8, w0, #2
0068624AC  cmp      w8, #2
0068624B0  str      x26, [sp, #8]
0068624B4  b.hs     #0x686252c
0068624B8  cbz      x26, #0x6862be0
0068624BC  adrp     x19, #0x9599000
0068624C0  ldrb     w8, [x19, #0xac8]
0068624C4  cbnz     w8, #0x68624dc
0068624C8  adrp     x0, #0x8f0d000
0068624CC  ldr      x0, [x0, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
0068624D0  bl       #0x382bd14 ; 
0068624D4  mov      w8, #1
0068624D8  strb     w8, [x19, #0xac8]
0068624DC  adrp     x8, #0x8f0d000
0068624E0  ldr      x8, [x8, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
0068624E4  ldr      x1, [x8]
0068624E8  ldrb     w8, [x1, #0x53]
0068624EC  tbnz     w8, #5, #0x6862574
0068624F0  ldr      w23, [x26, #0x58]
0068624F4  b        #0x6862584 ; 
0068624F8  ldr      x6, [x5, #0x60]
0068624FC  mov      x0, x21
006862500  mov      x1, x26
006862504  mov      x2, x22
006862508  mov      x4, x23
00686250C  ldp      x20, x19, [sp, #0x60]
006862510  ldp      x22, x21, [sp, #0x50]
006862514  ldp      x24, x23, [sp, #0x40]
006862518  ldp      x26, x25, [sp, #0x30]
00686251C  ldp      x28, x27, [sp, #0x20]
006862520  ldp      x29, x30, [sp, #0x10]
006862524  add      sp, sp, #0x70
006862528  br       x6
00686252C  cmp      w0, #1
006862530  b.ne     #0x6862ae4
006862534  cbz      x26, #0x6862be0
006862538  adrp     x19, #0x959b000
00686253C  ldrb     w8, [x19, #0xb8d]
006862540  cbnz     w8, #0x6862558
006862544  adrp     x0, #0x8f23000
006862548  ldr      x0, [x0, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
00686254C  bl       #0x382bd14 ; 
006862550  mov      w8, #1
006862554  strb     w8, [x19, #0xb8d]
006862558  adrp     x24, #0x8f23000
00686255C  ldr      x24, [x24, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
006862560  ldr      x1, [x24]
006862564  ldrb     w8, [x1, #0x53]
006862568  tbnz     w8, #5, #0x68625dc
00686256C  ldr      x0, [x26, #0x180]
006862570  b        #0x68625e8 ; 
006862574  ldr      x8, [x1, #0x60]
006862578  mov      x0, x26
00686257C  blr      x8
006862580  mov      w23, w0
006862584  mov      x0, x26
006862588  mov      x1, xzr
00686258C  bl       #0x6b0a07c ; LocalModels.Bean.Skill_Main$$GetMaxStar
006862590  sub      w8, w0, #1
006862594  cmp      w23, w8
006862598  b.ne     #0x6862a98
00686259C  adrp     x8, #0x959b000
0068625A0  ldrb     w8, [x8, #0xb8d]
0068625A4  cbnz     w8, #0x68625c0
0068625A8  adrp     x0, #0x8f23000
0068625AC  ldr      x0, [x0, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
0068625B0  bl       #0x382bd14 ; 
0068625B4  mov      w8, #1
0068625B8  adrp     x9, #0x959b000
0068625BC  strb     w8, [x9, #0xb8d]
0068625C0  adrp     x8, #0x8f23000
0068625C4  ldr      x8, [x8, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
0068625C8  ldr      x1, [x8]
0068625CC  ldrb     w8, [x1, #0x53]
0068625D0  tbnz     w8, #5, #0x6862824
0068625D4  ldr      x0, [x26, #0x180]
0068625D8  b        #0x6862830 ; 
0068625DC  ldr      x8, [x1, #0x60]
0068625E0  mov      x0, x26
0068625E4  blr      x8
0068625E8  adrp     x28, #0x959b000
0068625EC  cbz      x0, #0x68627dc
0068625F0  adrp     x23, #0x8f08000
0068625F4  adrp     x25, #0x8f06000
0068625F8  ldr      x23, [x23, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
0068625FC  ldr      x25, [x25, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862600  mov      x20, xzr
006862604  mov      w29, #1
006862608  ldrb     w8, [x19, #0xb8d]
00686260C  cbnz     w8, #0x686261c
006862610  mov      x0, x24
006862614  bl       #0x382bd14 ; 
006862618  strb     w29, [x19, #0xb8d]
00686261C  ldr      x1, [x24]
006862620  ldrb     w8, [x1, #0x53]
006862624  tbnz     w8, #5, #0x6862630
006862628  ldr      x0, [x26, #0x180]
00686262C  b        #0x686263c ; 
006862630  ldr      x8, [x1, #0x60]
006862634  mov      x0, x26
006862638  blr      x8
00686263C  cbz      x0, #0x6862be0
006862640  ldrsw    x8, [x0, #0x18]
006862644  cmp      x20, x8
006862648  b.ge     #0x68627dc
00686264C  ldrb     w8, [x19, #0xb8d]
006862650  cbnz     w8, #0x6862660
006862654  mov      x0, x24
006862658  bl       #0x382bd14 ; 
00686265C  strb     w29, [x19, #0xb8d]
006862660  ldr      x1, [x24]
006862664  ldrb     w8, [x1, #0x53]
006862668  tbnz     w8, #5, #0x6862674
00686266C  ldr      x0, [x26, #0x180]
006862670  b        #0x6862680 ; 
006862674  ldr      x8, [x1, #0x60]
006862678  mov      x0, x26
00686267C  blr      x8
006862680  cbz      x0, #0x6862be0
006862684  ldr      w8, [x0, #0x18]
006862688  cmp      x20, x8
00686268C  b.hs     #0x6862be4
006862690  cbz      x22, #0x6862be0
006862694  add      x8, x0, x20, lsl #2
006862698  ldr      w26, [x8, #0x20]
00686269C  ldr      x2, [x23]
0068626A0  mov      x0, x22
0068626A4  mov      w1, w26
0068626A8  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0068626AC  tbz      w0, #0, #0x68627d0
0068626B0  mov      x0, x21
0068626B4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068626B8  cbz      x0, #0x6862be0
0068626BC  adrp     x8, #0x9598000
0068626C0  ldrb     w8, [x8, #0xfcc]
0068626C4  mov      x27, x0
0068626C8  cbnz     w8, #0x68626dc
0068626CC  mov      x0, x25
0068626D0  bl       #0x382bd14 ; 
0068626D4  adrp     x8, #0x9598000
0068626D8  strb     w29, [x8, #0xfcc]
0068626DC  ldr      x1, [x25]
0068626E0  ldrb     w8, [x1, #0x53]
0068626E4  tbnz     w8, #5, #0x68626f0
0068626E8  ldr      x0, [x27, #0x200]
0068626EC  b        #0x68626fc ; 
0068626F0  ldr      x8, [x1, #0x60]
0068626F4  mov      x0, x27
0068626F8  blr      x8
0068626FC  cbz      x0, #0x6862be0
006862700  mov      w1, w26
006862704  mov      x2, xzr
006862708  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00686270C  cbz      x0, #0x6862be0
006862710  mov      x1, xzr
006862714  mov      x26, x0
006862718  bl       #0x6b09f68 ; LocalModels.Bean.Skill_Main$$get_HasNextSkill
00686271C  tbz      w0, #0, #0x68627d0
006862720  ldrb     w8, [x28, #0xb8e]
006862724  cbnz     w8, #0x6862738
006862728  adrp     x0, #0x8f23000
00686272C  ldr      x0, [x0, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862730  bl       #0x382bd14 ; 
006862734  strb     w29, [x28, #0xb8e]
006862738  adrp     x8, #0x8f23000
00686273C  ldr      x8, [x8, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862740  ldr      x1, [x8]
006862744  ldrb     w8, [x1, #0x53]
006862748  tbnz     w8, #5, #0x6862754
00686274C  ldr      w1, [x26, #0xa4]
006862750  b        #0x6862764 ; 
006862754  ldr      x8, [x1, #0x60]
006862758  mov      x0, x26
00686275C  blr      x8
006862760  mov      w1, w0
006862764  mov      x0, x21
006862768  bl       #0x68654a8 ; HotFix.BattleLogic.DankeSkillCreator$$GetSkillWeight
00686276C  ldrb     w8, [x28, #0xb8e]
006862770  mov      w27, w0
006862774  cbnz     w8, #0x6862788
006862778  adrp     x0, #0x8f23000
00686277C  ldr      x0, [x0, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862780  bl       #0x382bd14 ; 
006862784  strb     w29, [x28, #0xb8e]
006862788  adrp     x8, #0x8f23000
00686278C  ldr      x8, [x8, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862790  ldr      x1, [x8]
006862794  ldrb     w8, [x1, #0x53]
006862798  tbnz     w8, #5, #0x68627a4
00686279C  ldr      w1, [x26, #0xa4]
0068627A0  b        #0x68627b4 ; 
0068627A4  ldr      x8, [x1, #0x60]
0068627A8  mov      x0, x26
0068627AC  blr      x8
0068627B0  mov      w1, w0
0068627B4  ldr      x0, [sp]
0068627B8  cbz      x0, #0x6862be0
0068627BC  adrp     x8, #0x8eea000
0068627C0  ldr      x8, [x8, #0x110] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.Add() @ 0x920b040
0068627C4  mov      w2, w27
0068627C8  ldr      x3, [x8]
0068627CC  bl       #0x5e28160 ; System.Collections.Generic.Dictionary<int, int>$$Add
0068627D0  ldr      x26, [sp, #8]
0068627D4  add      x20, x20, #1
0068627D8  b        #0x6862608 ; 
0068627DC  mov      x0, x26
0068627E0  mov      x1, xzr
0068627E4  bl       #0x6b09f68 ; LocalModels.Bean.Skill_Main$$get_HasNextSkill
0068627E8  tbz      w0, #0, #0x6862ae4
0068627EC  ldrb     w8, [x28, #0xb8e]
0068627F0  cbnz     w8, #0x6862808
0068627F4  adrp     x0, #0x8f23000
0068627F8  ldr      x0, [x0, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
0068627FC  bl       #0x382bd14 ; 
006862800  mov      w8, #1
006862804  strb     w8, [x28, #0xb8e]
006862808  adrp     x8, #0x8f23000
00686280C  ldr      x8, [x8, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862810  ldr      x1, [x8]
006862814  ldrb     w8, [x1, #0x53]
006862818  tbnz     w8, #5, #0x6862b44
00686281C  ldr      w1, [x26, #0xa4]
006862820  b        #0x6862b54 ; 
006862824  ldr      x8, [x1, #0x60]
006862828  mov      x0, x26
00686282C  blr      x8
006862830  cbz      x0, #0x6862be0
006862834  ldr      x8, [x0, #0x18]
006862838  cbz      x8, #0x6862a98
00686283C  adrp     x28, #0x8f08000
006862840  adrp     x24, #0x8f23000
006862844  adrp     x25, #0x8f06000
006862848  ldr      x28, [x28, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00686284C  ldr      x24, [x24, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862850  ldr      x25, [x25, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862854  mov      x29, xzr
006862858  mov      w19, #1
00686285C  adrp     x23, #0x959b000
006862860  adrp     x20, #0x9598000
006862864  adrp     x8, #0x959b000
006862868  ldrb     w8, [x8, #0xb8d]
00686286C  cbnz     w8, #0x6862884
006862870  adrp     x0, #0x8f23000
006862874  ldr      x0, [x0, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
006862878  bl       #0x382bd14 ; 
00686287C  adrp     x8, #0x959b000
006862880  strb     w19, [x8, #0xb8d]
006862884  adrp     x8, #0x8f23000
006862888  ldr      x8, [x8, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
00686288C  ldr      x26, [sp, #8]
006862890  ldr      x1, [x8]
006862894  ldrb     w8, [x1, #0x53]
006862898  tbnz     w8, #5, #0x68628a4
00686289C  ldr      x0, [x26, #0x180]
0068628A0  b        #0x68628b0 ; 
0068628A4  ldr      x8, [x1, #0x60]
0068628A8  mov      x0, x26
0068628AC  blr      x8
0068628B0  cbz      x0, #0x6862be0
0068628B4  ldrsw    x8, [x0, #0x18]
0068628B8  cmp      x29, x8
0068628BC  b.ge     #0x6862ae4
0068628C0  adrp     x8, #0x959b000
0068628C4  ldrb     w8, [x8, #0xb8d]
0068628C8  cbnz     w8, #0x68628e0
0068628CC  adrp     x0, #0x8f23000
0068628D0  ldr      x0, [x0, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
0068628D4  bl       #0x382bd14 ; 
0068628D8  adrp     x8, #0x959b000
0068628DC  strb     w19, [x8, #0xb8d]
0068628E0  adrp     x8, #0x8f23000
0068628E4  ldr      x8, [x8, #0xd08] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SuperNeedSkill() @ 0x92ac550
0068628E8  ldr      x1, [x8]
0068628EC  ldrb     w8, [x1, #0x53]
0068628F0  tbnz     w8, #5, #0x68628fc
0068628F4  ldr      x0, [x26, #0x180]
0068628F8  b        #0x6862908 ; 
0068628FC  ldr      x8, [x1, #0x60]
006862900  mov      x0, x26
006862904  blr      x8
006862908  cbz      x0, #0x6862be0
00686290C  ldr      w8, [x0, #0x18]
006862910  cmp      x29, x8
006862914  b.hs     #0x6862be4
006862918  cbz      x22, #0x6862be0
00686291C  add      x8, x0, x29, lsl #2
006862920  ldr      w26, [x8, #0x20]
006862924  ldr      x2, [x28]
006862928  mov      x0, x22
00686292C  mov      w1, w26
006862930  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006862934  tbnz     w0, #0, #0x68629e4
006862938  mov      x0, x21
00686293C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006862940  cbz      x0, #0x6862be0
006862944  ldrb     w8, [x20, #0xfcc]
006862948  mov      x27, x0
00686294C  cbnz     w8, #0x686295c
006862950  mov      x0, x25
006862954  bl       #0x382bd14 ; 
006862958  strb     w19, [x20, #0xfcc]
00686295C  ldr      x1, [x25]
006862960  ldrb     w8, [x1, #0x53]
006862964  tbnz     w8, #5, #0x6862970
006862968  ldr      x0, [x27, #0x200]
00686296C  b        #0x686297c ; 
006862970  ldr      x8, [x1, #0x60]
006862974  mov      x0, x27
006862978  blr      x8
00686297C  cbz      x0, #0x6862be0
006862980  mov      w1, w26
006862984  mov      x2, xzr
006862988  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00686298C  cbz      x0, #0x6862be0
006862990  mov      x1, xzr
006862994  mov      x26, x0
006862998  bl       #0x6b09f68 ; LocalModels.Bean.Skill_Main$$get_HasNextSkill
00686299C  tbz      w0, #0, #0x6862a90
0068629A0  ldrb     w8, [x23, #0xb8e]
0068629A4  cbnz     w8, #0x68629b4
0068629A8  mov      x0, x24
0068629AC  bl       #0x382bd14 ; 
0068629B0  strb     w19, [x23, #0xb8e]
0068629B4  ldr      x1, [x24]
0068629B8  ldrb     w8, [x1, #0x53]
0068629BC  tbnz     w8, #5, #0x68629cc
0068629C0  ldr      w26, [x26, #0xa4]
0068629C4  cbnz     w26, #0x6862924
0068629C8  b        #0x6862a90 ; 
0068629CC  ldr      x8, [x1, #0x60]
0068629D0  mov      x0, x26
0068629D4  blr      x8
0068629D8  mov      w26, w0
0068629DC  cbnz     w26, #0x6862924
0068629E0  b        #0x6862a90 ; 
0068629E4  ldr      x0, [sp, #8]
0068629E8  mov      x1, xzr
0068629EC  bl       #0x6b09f68 ; LocalModels.Bean.Skill_Main$$get_HasNextSkill
0068629F0  tbz      w0, #0, #0x6862a90
0068629F4  ldrb     w8, [x23, #0xb8e]
0068629F8  cbnz     w8, #0x6862a08
0068629FC  mov      x0, x24
006862A00  bl       #0x382bd14 ; 
006862A04  strb     w19, [x23, #0xb8e]
006862A08  ldr      x1, [x24]
006862A0C  ldr      x0, [sp, #8]
006862A10  ldrb     w8, [x1, #0x53]
006862A14  tbnz     w8, #5, #0x6862a20
006862A18  ldr      w1, [x0, #0xa4]
006862A1C  b        #0x6862a2c ; 
006862A20  ldr      x8, [x1, #0x60]
006862A24  blr      x8
006862A28  mov      w1, w0
006862A2C  mov      x0, x21
006862A30  bl       #0x68654a8 ; HotFix.BattleLogic.DankeSkillCreator$$GetSkillWeight
006862A34  ldrb     w8, [x23, #0xb8e]
006862A38  mov      w26, w0
006862A3C  cbnz     w8, #0x6862a4c
006862A40  mov      x0, x24
006862A44  bl       #0x382bd14 ; 
006862A48  strb     w19, [x23, #0xb8e]
006862A4C  ldr      x1, [x24]
006862A50  ldrb     w8, [x1, #0x53]
006862A54  tbnz     w8, #5, #0x6862a64
006862A58  ldr      x8, [sp, #8]
006862A5C  ldr      w1, [x8, #0xa4]
006862A60  b        #0x6862a74 ; 
006862A64  ldr      x8, [x1, #0x60]
006862A68  ldr      x0, [sp, #8]
006862A6C  blr      x8
006862A70  mov      w1, w0
006862A74  ldr      x0, [sp]
006862A78  cbz      x0, #0x6862be0
006862A7C  adrp     x8, #0x8eea000
006862A80  ldr      x8, [x8, #0x110] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.Add() @ 0x920b040
006862A84  mov      w2, w26
006862A88  ldr      x3, [x8]
006862A8C  bl       #0x5e28160 ; System.Collections.Generic.Dictionary<int, int>$$Add
006862A90  add      x29, x29, #1
006862A94  b        #0x6862864 ; 
006862A98  mov      x0, x26
006862A9C  mov      x1, xzr
006862AA0  bl       #0x6b09f68 ; LocalModels.Bean.Skill_Main$$get_HasNextSkill
006862AA4  tbz      w0, #0, #0x6862ae4
006862AA8  adrp     x19, #0x959b000
006862AAC  ldrb     w8, [x19, #0xb8e]
006862AB0  cbnz     w8, #0x6862ac8
006862AB4  adrp     x0, #0x8f23000
006862AB8  ldr      x0, [x0, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862ABC  bl       #0x382bd14 ; 
006862AC0  mov      w8, #1
006862AC4  strb     w8, [x19, #0xb8e]
006862AC8  adrp     x20, #0x8f23000
006862ACC  ldr      x20, [x20, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862AD0  ldr      x1, [x20]
006862AD4  ldrb     w8, [x1, #0x53]
006862AD8  tbnz     w8, #5, #0x6862b04
006862ADC  ldr      w1, [x26, #0xa4]
006862AE0  b        #0x6862b14 ; 
006862AE4  ldp      x20, x19, [sp, #0x60]
006862AE8  ldp      x22, x21, [sp, #0x50]
006862AEC  ldp      x24, x23, [sp, #0x40]
006862AF0  ldp      x26, x25, [sp, #0x30]
006862AF4  ldp      x28, x27, [sp, #0x20]
006862AF8  ldp      x29, x30, [sp, #0x10]
006862AFC  add      sp, sp, #0x70
006862B00  ret      
006862B04  ldr      x8, [x1, #0x60]
006862B08  mov      x0, x26
006862B0C  blr      x8
006862B10  mov      w1, w0
006862B14  mov      x0, x21
006862B18  bl       #0x68654a8 ; HotFix.BattleLogic.DankeSkillCreator$$GetSkillWeight
006862B1C  ldrb     w8, [x19, #0xb8e]
006862B20  mov      w21, w0
006862B24  cbnz     w8, #0x6862b3c
006862B28  adrp     x0, #0x8f23000
006862B2C  ldr      x0, [x0, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862B30  bl       #0x382bd14 ; 
006862B34  mov      w8, #1
006862B38  strb     w8, [x19, #0xb8e]
006862B3C  ldr      x1, [x20]
006862B40  b        #0x6862b88 ; 
006862B44  ldr      x8, [x1, #0x60]
006862B48  mov      x0, x26
006862B4C  blr      x8
006862B50  mov      w1, w0
006862B54  mov      x0, x21
006862B58  bl       #0x68654a8 ; HotFix.BattleLogic.DankeSkillCreator$$GetSkillWeight
006862B5C  ldrb     w8, [x28, #0xb8e]
006862B60  mov      w21, w0
006862B64  cbnz     w8, #0x6862b7c
006862B68  adrp     x0, #0x8f23000
006862B6C  ldr      x0, [x0, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862B70  bl       #0x382bd14 ; 
006862B74  mov      w8, #1
006862B78  strb     w8, [x28, #0xb8e]
006862B7C  adrp     x8, #0x8f23000
006862B80  ldr      x8, [x8, #0xd10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NextSkill() @ 0x92ac4e8
006862B84  ldr      x1, [x8]
006862B88  ldrb     w8, [x1, #0x53]
006862B8C  tbnz     w8, #5, #0x6862b98
006862B90  ldr      w1, [x26, #0xa4]
006862B94  b        #0x6862ba8 ; 
006862B98  ldr      x8, [x1, #0x60]
006862B9C  mov      x0, x26
006862BA0  blr      x8
006862BA4  mov      w1, w0
006862BA8  ldr      x0, [sp]
006862BAC  cbz      x0, #0x6862be0
006862BB0  adrp     x8, #0x8eea000
006862BB4  ldr      x8, [x8, #0x110] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.Add() @ 0x920b040
006862BB8  mov      w2, w21
006862BBC  ldp      x20, x19, [sp, #0x60]
006862BC0  ldp      x22, x21, [sp, #0x50]
006862BC4  ldr      x3, [x8]
006862BC8  ldp      x24, x23, [sp, #0x40]
006862BCC  ldp      x26, x25, [sp, #0x30]
006862BD0  ldp      x28, x27, [sp, #0x20]
006862BD4  ldp      x29, x30, [sp, #0x10]
006862BD8  add      sp, sp, #0x70
006862BDC  b        #0x5e28160 ; System.Collections.Generic.Dictionary<int, int>$$Add
006862BE0  bl       #0x382bfb8 ; 
006862BE4  bl       #0x382bfc0 ; 

