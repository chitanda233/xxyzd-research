; HotFix.BattleLogic.WeightRandom$$GetAlreadyStudySkill
; RVA 0x6634F18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006634F18  sub      sp, sp, #0x70
006634F1C  stp      x29, x30, [sp, #0x10]
006634F20  stp      x28, x27, [sp, #0x20]
006634F24  stp      x26, x25, [sp, #0x30]
006634F28  stp      x24, x23, [sp, #0x40]
006634F2C  stp      x22, x21, [sp, #0x50]
006634F30  stp      x20, x19, [sp, #0x60]
006634F34  adrp     x19, #0x9599000
006634F38  adrp     x21, #0x8f0d000
006634F3C  ldrb     w8, [x19, #0x9e7]
006634F40  ldr      x21, [x21, #0x70] ; GLOBAL Method$HotFix.BattleLogic.WeightRandom.GetAlreadyStudySkill()
006634F44  mov      x22, x1
006634F48  mov      x20, x0
006634F4C  tbnz     w8, #0, #0x6634f70
006634F50  adrp     x0, #0x8eea000
006634F54  ldr      x0, [x0, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray()
006634F58  bl       #0x382bd14 ; 
006634F5C  adrp     x0, #0x8f0d000
006634F60  ldr      x0, [x0, #0x70] ; GLOBAL Method$HotFix.BattleLogic.WeightRandom.GetAlreadyStudySkill()
006634F64  bl       #0x382bd14 ; 
006634F68  mov      w8, #1
006634F6C  strb     w8, [x19, #0x9e7]
006634F70  ldr      x2, [x21]
006634F74  ldrb     w8, [x2, #0x53]
006634F78  tbnz     w8, #5, #0x6635254
006634F7C  cbz      x22, #0x66352a8
006634F80  mov      x0, x22
006634F84  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006634F88  ldr      w8, [x20, #0x30]
006634F8C  cmp      w8, #1
006634F90  b.lt     #0x6635280
006634F94  str      x22, [sp]
006634F98  str      wzr, [sp, #0xc]
006634F9C  adrp     x21, #0x8ee5000
006634FA0  ldr      x21, [x21, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006634FA4  mov      x22, xzr
006634FA8  mov      x23, xzr
006634FAC  adrp     x27, #0x9591000
006634FB0  ldr      x24, [x20, #0x40]
006634FB4  cbz      x24, #0x66352a8
006634FB8  ldr      w8, [x24, #0x18]
006634FBC  cmp      x23, x8
006634FC0  b.hs     #0x66352ac
006634FC4  add      x26, x24, x22
006634FC8  ldr      w28, [x26, #0x20]!
006634FCC  ldrb     w8, [x27, #0xa4b]
006634FD0  cbnz     w8, #0x6634fe4
006634FD4  mov      x0, x21
006634FD8  bl       #0x382bd14 ; 
006634FDC  mov      w8, #1
006634FE0  strb     w8, [x27, #0xa4b]
006634FE4  ldr      x1, [x21]
006634FE8  ldrb     w8, [x1, #0x53]
006634FEC  tbnz     w8, #5, #0x6634ff8
006634FF0  ldr      x19, [x20, #0x20]
006634FF4  b        #0x6635008 ; 
006634FF8  ldr      x8, [x1, #0x60]
006634FFC  mov      x0, x20
006635000  blr      x8
006635004  mov      x19, x0
006635008  cbz      x19, #0x66352a8
00663500C  adrp     x8, #0x9598000
006635010  ldrb     w8, [x8, #0xfcc]
006635014  cbnz     w8, #0x6635030
006635018  adrp     x0, #0x8f06000
00663501C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006635020  bl       #0x382bd14 ; 
006635024  mov      w8, #1
006635028  adrp     x9, #0x9598000
00663502C  strb     w8, [x9, #0xfcc]
006635030  adrp     x8, #0x8f06000
006635034  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006635038  ldr      x1, [x8]
00663503C  ldrb     w8, [x1, #0x53]
006635040  tbnz     w8, #5, #0x663504c
006635044  ldr      x0, [x19, #0x200]
006635048  b        #0x6635058 ; 
00663504C  ldr      x8, [x1, #0x60]
006635050  mov      x0, x19
006635054  blr      x8
006635058  cbz      x0, #0x66352a8
00663505C  mov      w1, w28
006635060  mov      x2, xzr
006635064  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006635068  cbz      x0, #0x66352a8
00663506C  adrp     x8, #0x9599000
006635070  ldrb     w8, [x8, #0xac8]
006635074  mov      x29, x0
006635078  cbnz     w8, #0x6635094
00663507C  adrp     x0, #0x8f0d000
006635080  ldr      x0, [x0, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar()
006635084  bl       #0x382bd14 ; 
006635088  mov      w8, #1
00663508C  adrp     x9, #0x9599000
006635090  strb     w8, [x9, #0xac8]
006635094  adrp     x8, #0x8f0d000
006635098  ldr      x8, [x8, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar()
00663509C  ldr      x1, [x8]
0066350A0  ldrb     w8, [x1, #0x53]
0066350A4  tbnz     w8, #5, #0x66350b0
0066350A8  ldr      w25, [x29, #0x58]
0066350AC  b        #0x66350c0 ; 
0066350B0  ldr      x8, [x1, #0x60]
0066350B4  mov      x0, x29
0066350B8  blr      x8
0066350BC  mov      w25, w0
0066350C0  cmp      w25, #2
0066350C4  b.lt     #0x663523c
0066350C8  mov      x0, x26
0066350CC  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066350D0  adrp     x8, #0x9599000
0066350D4  ldrb     w8, [x8, #0xac2]
0066350D8  mov      w26, w0
0066350DC  cbnz     w8, #0x66350f8
0066350E0  adrp     x0, #0x8f0c000
0066350E4  ldr      x0, [x0, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedFlags()
0066350E8  bl       #0x382bd14 ; 
0066350EC  mov      w8, #1
0066350F0  adrp     x9, #0x9599000
0066350F4  strb     w8, [x9, #0xac2]
0066350F8  adrp     x8, #0x8f0c000
0066350FC  ldr      x8, [x8, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedFlags()
006635100  mov      x21, x27
006635104  ldr      x1, [x8]
006635108  ldrb     w8, [x1, #0x53]
00663510C  tbnz     w8, #5, #0x663511c
006635110  add      x8, x24, x22
006635114  ldr      w27, [x8, #0x2c]
006635118  b        #0x6635130 ; 
00663511C  ldr      x8, [x1, #0x60]
006635120  add      x9, x24, x22
006635124  add      x0, x9, #0x20
006635128  blr      x8
00663512C  mov      w27, w0
006635130  adrp     x8, #0x9599000
006635134  ldrb     w8, [x8, #0xac3]
006635138  cbnz     w8, #0x6635154
00663513C  adrp     x0, #0x8f0c000
006635140  ldr      x0, [x0, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetSkillFlags()
006635144  bl       #0x382bd14 ; 
006635148  mov      w8, #1
00663514C  adrp     x9, #0x9599000
006635150  strb     w8, [x9, #0xac3]
006635154  adrp     x8, #0x8f0c000
006635158  ldr      x8, [x8, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetSkillFlags()
00663515C  ldr      x1, [x8]
006635160  ldrb     w8, [x1, #0x53]
006635164  tbnz     w8, #5, #0x6635174
006635168  add      x8, x24, x22
00663516C  ldr      x19, [x8, #0x30]
006635170  b        #0x6635188 ; 
006635174  ldr      x8, [x1, #0x60]
006635178  add      x9, x24, x22
00663517C  add      x0, x9, #0x20
006635180  blr      x8
006635184  mov      x19, x0
006635188  adrp     x8, #0x9599000
00663518C  ldrb     w8, [x8, #0xac4]
006635190  cbnz     w8, #0x66351ac
006635194  adrp     x0, #0x8f0c000
006635198  ldr      x0, [x0, #0xea8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedSkills()
00663519C  bl       #0x382bd14 ; 
0066351A0  mov      w8, #1
0066351A4  adrp     x9, #0x9599000
0066351A8  strb     w8, [x9, #0xac4]
0066351AC  adrp     x8, #0x8f0c000
0066351B0  ldr      x8, [x8, #0xea8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetNeedSkills()
0066351B4  ldr      x1, [x8]
0066351B8  ldrb     w8, [x1, #0x53]
0066351BC  tbnz     w8, #5, #0x66351cc
0066351C0  add      x8, x24, x22
0066351C4  ldr      x0, [x8, #0x48]
0066351C8  b        #0x66351dc ; 
0066351CC  ldr      x8, [x1, #0x60]
0066351D0  add      x9, x24, x22
0066351D4  add      x0, x9, #0x20
0066351D8  blr      x8
0066351DC  cbz      x0, #0x66352a8
0066351E0  adrp     x8, #0x8eea000
0066351E4  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray()
0066351E8  ldr      x1, [x8]
0066351EC  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
0066351F0  mov      x5, x0
0066351F4  ldr      x0, [sp]
0066351F8  mov      w1, w28
0066351FC  mov      w2, w26
006635200  mov      w3, w27
006635204  mov      x4, x19
006635208  mov      x6, xzr
00663520C  bl       #0x6632e88 ; HotFix.BattleLogic.WeightRandom$$Add
006635210  mov      x0, x29
006635214  mov      x1, xzr
006635218  bl       #0x6b0a07c ; LocalModels.Bean.Skill_Main$$GetMaxStar
00663521C  ldr      w8, [sp, #0xc]
006635220  mov      x27, x21
006635224  adrp     x21, #0x8ee5000
006635228  sub      w8, w8, w25
00663522C  add      w8, w8, w0
006635230  add      w8, w8, #1
006635234  str      w8, [sp, #0xc]
006635238  ldr      x21, [x21, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
00663523C  ldrsw    x8, [x20, #0x30]
006635240  add      x23, x23, #1
006635244  add      x22, x22, #0x38
006635248  cmp      x23, x8
00663524C  b.lt     #0x6634fb0
006635250  b        #0x6635284 ; 
006635254  ldr      x3, [x2, #0x60]
006635258  mov      x0, x20
00663525C  mov      x1, x22
006635260  ldp      x20, x19, [sp, #0x60]
006635264  ldp      x22, x21, [sp, #0x50]
006635268  ldp      x24, x23, [sp, #0x40]
00663526C  ldp      x26, x25, [sp, #0x30]
006635270  ldp      x28, x27, [sp, #0x20]
006635274  ldp      x29, x30, [sp, #0x10]
006635278  add      sp, sp, #0x70
00663527C  br       x3
006635280  str      wzr, [sp, #0xc]
006635284  ldr      w0, [sp, #0xc]
006635288  ldp      x20, x19, [sp, #0x60]
00663528C  ldp      x22, x21, [sp, #0x50]
006635290  ldp      x24, x23, [sp, #0x40]
006635294  ldp      x26, x25, [sp, #0x30]
006635298  ldp      x28, x27, [sp, #0x20]
00663529C  ldp      x29, x30, [sp, #0x10]
0066352A0  add      sp, sp, #0x70
0066352A4  ret      
0066352A8  bl       #0x382bfb8 ; 
0066352AC  bl       #0x382bfc0 ; 

