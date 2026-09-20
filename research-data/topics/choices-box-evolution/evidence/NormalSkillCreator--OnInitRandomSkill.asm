; HotFix.BattleLogic.NormalSkillCreator$$OnInitRandomSkill
; RVA 0x6874F38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874F38  stp      x29, x30, [sp, #-0x60]!
006874F3C  stp      x28, x27, [sp, #0x10]
006874F40  stp      x26, x25, [sp, #0x20]
006874F44  stp      x24, x23, [sp, #0x30]
006874F48  stp      x22, x21, [sp, #0x40]
006874F4C  stp      x20, x19, [sp, #0x50]
006874F50  adrp     x22, #0x959b000
006874F54  adrp     x23, #0x8f24000
006874F58  ldrb     w8, [x22, #0xaa5]
006874F5C  ldr      x23, [x23, #0x4e8] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnInitRandomSkill() @ 0x9295ec8
006874F60  mov      x20, x2
006874F64  mov      w19, w1
006874F68  mov      x21, x0
006874F6C  tbnz     w8, #0, #0x6874fb4
006874F70  adrp     x0, #0x8ebf000
006874F74  ldr      x0, [x0, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006874F78  bl       #0x382bd14 ; 
006874F7C  adrp     x0, #0x8f24000
006874F80  ldr      x0, [x0, #0x4f0] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_Angel>_TypeInfo @ 0x91d7698
006874F84  bl       #0x382bd14 ; 
006874F88  adrp     x0, #0x8f24000
006874F8C  ldr      x0, [x0, #0x4f8] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_Angel>_TypeInfo @ 0x91d80b0
006874F90  bl       #0x382bd14 ; 
006874F94  adrp     x0, #0x8ebf000
006874F98  ldr      x0, [x0, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
006874F9C  bl       #0x382bd14 ; 
006874FA0  adrp     x0, #0x8f24000
006874FA4  ldr      x0, [x0, #0x4e8] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnInitRandomSkill() @ 0x9295ec8
006874FA8  bl       #0x382bd14 ; 
006874FAC  mov      w8, #1
006874FB0  strb     w8, [x22, #0xaa5]
006874FB4  ldr      x3, [x23]
006874FB8  ldrb     w8, [x3, #0x53]
006874FBC  tbnz     w8, #5, #0x6875010
006874FC0  mov      x0, x21
006874FC4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006874FC8  cbz      x0, #0x6875360
006874FCC  adrp     x8, #0x9598000
006874FD0  ldrb     w8, [x8, #0xfcc]
006874FD4  mov      x19, x0
006874FD8  cbnz     w8, #0x6874ff4
006874FDC  adrp     x0, #0x8f06000
006874FE0  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006874FE4  bl       #0x382bd14 ; 
006874FE8  mov      w8, #1
006874FEC  adrp     x9, #0x9598000
006874FF0  strb     w8, [x9, #0xfcc]
006874FF4  adrp     x8, #0x8f06000
006874FF8  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006874FFC  ldr      x1, [x8]
006875000  ldrb     w8, [x1, #0x53]
006875004  tbnz     w8, #5, #0x687503c
006875008  ldr      x0, [x19, #0x200]
00687500C  b        #0x6875048 ; 
006875010  ldr      x4, [x3, #0x60]
006875014  mov      x0, x21
006875018  mov      w1, w19
00687501C  mov      x2, x20
006875020  ldp      x20, x19, [sp, #0x50]
006875024  ldp      x22, x21, [sp, #0x40]
006875028  ldp      x24, x23, [sp, #0x30]
00687502C  ldp      x26, x25, [sp, #0x20]
006875030  ldp      x28, x27, [sp, #0x10]
006875034  ldp      x29, x30, [sp], #0x60
006875038  br       x4
00687503C  ldr      x8, [x1, #0x60]
006875040  mov      x0, x19
006875044  blr      x8
006875048  cbz      x0, #0x6875360
00687504C  mov      x1, xzr
006875050  bl       #0x64d6c0c ; LocalModels.LocalModelManager$$GetSkillGroup_AngelElements
006875054  cbz      x0, #0x6875360
006875058  adrp     x10, #0x8f24000
00687505C  ldr      x8, [x0]
006875060  ldr      x10, [x10, #0x4f0] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_Angel>_TypeInfo @ 0x91d7698
006875064  mov      x19, x0
006875068  ldrh     w9, [x8, #0x12e]
00687506C  ldr      x1, [x10]
006875070  cbz      x9, #0x6875094
006875074  ldr      x10, [x8, #0xb0]
006875078  add      x10, x10, #8
00687507C  ldur     x11, [x10, #-8]
006875080  cmp      x11, x1
006875084  b.eq     #0x68750a4
006875088  subs     x9, x9, #1
00687508C  add      x10, x10, #0x10
006875090  b.ne     #0x687507c
006875094  mov      x0, x19
006875098  mov      w2, wzr
00687509C  bl       #0x3a7e710 ; 
0068750A0  b        #0x68750b0 ; 
0068750A4  ldrsw    x9, [x10]
0068750A8  add      x8, x8, x9, lsl #4
0068750AC  add      x0, x8, #0x138
0068750B0  ldp      x8, x1, [x0]
0068750B4  mov      x0, x19
0068750B8  blr      x8
0068750BC  mov      x19, x0
0068750C0  cbz      x0, #0x6875364
0068750C4  adrp     x23, #0x8f24000
0068750C8  adrp     x24, #0x8f23000
0068750CC  ldr      x23, [x23, #0x500] ; GLOBAL Method$LocalModels.Bean.SkillGroup_Angel.get_GetID() @ 0x92aac80
0068750D0  ldr      x24, [x24, #0xa10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_Quality() @ 0x92ac518
0068750D4  mov      w29, #1
0068750D8  adrp     x28, #0x959b000
0068750DC  adrp     x27, #0x959b000
0068750E0  ldr      x8, [x19]
0068750E4  adrp     x10, #0x8ebf000
0068750E8  ldrh     w9, [x8, #0x12e]
0068750EC  ldr      x10, [x10, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
0068750F0  ldr      x1, [x10]
0068750F4  cbz      x9, #0x6875118
0068750F8  ldr      x10, [x8, #0xb0]
0068750FC  add      x10, x10, #8
006875100  ldur     x11, [x10, #-8]
006875104  cmp      x11, x1
006875108  b.eq     #0x6875128
00687510C  subs     x9, x9, #1
006875110  add      x10, x10, #0x10
006875114  b.ne     #0x6875100
006875118  mov      x0, x19
00687511C  mov      w2, wzr
006875120  bl       #0x3a7e710 ; 
006875124  b        #0x6875134 ; 
006875128  ldrsw    x9, [x10]
00687512C  add      x8, x8, x9, lsl #4
006875130  add      x0, x8, #0x138
006875134  ldp      x8, x1, [x0]
006875138  mov      x0, x19
00687513C  blr      x8
006875140  tbz      w0, #0, #0x68752c0
006875144  ldr      x8, [x19]
006875148  adrp     x10, #0x8f24000
00687514C  ldrh     w9, [x8, #0x12e]
006875150  ldr      x10, [x10, #0x4f8] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_Angel>_TypeInfo @ 0x91d80b0
006875154  ldr      x1, [x10]
006875158  cbz      x9, #0x687517c
00687515C  ldr      x10, [x8, #0xb0]
006875160  add      x10, x10, #8
006875164  ldur     x11, [x10, #-8]
006875168  cmp      x11, x1
00687516C  b.eq     #0x687518c
006875170  subs     x9, x9, #1
006875174  add      x10, x10, #0x10
006875178  b.ne     #0x6875164
00687517C  mov      x0, x19
006875180  mov      w2, wzr
006875184  bl       #0x3a7e710 ; 
006875188  b        #0x6875198 ; 
00687518C  ldrsw    x9, [x10]
006875190  add      x8, x8, x9, lsl #4
006875194  add      x0, x8, #0x138
006875198  ldp      x8, x1, [x0]
00687519C  mov      x0, x19
0068751A0  blr      x8
0068751A4  mov      x25, x0
0068751A8  mov      x0, x21
0068751AC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068751B0  mov      x26, x0
0068751B4  cbz      x0, #0x6875354
0068751B8  adrp     x8, #0x9598000
0068751BC  ldrb     w8, [x8, #0xfcc]
0068751C0  cbnz     w8, #0x68751d8
0068751C4  adrp     x0, #0x8f06000
0068751C8  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068751CC  bl       #0x382bd14 ; 
0068751D0  adrp     x8, #0x9598000
0068751D4  strb     w29, [x8, #0xfcc]
0068751D8  adrp     x8, #0x8f06000
0068751DC  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068751E0  ldr      x1, [x8]
0068751E4  ldrb     w8, [x1, #0x53]
0068751E8  tbnz     w8, #5, #0x68751f4
0068751EC  ldr      x26, [x26, #0x200]
0068751F0  b        #0x6875204 ; 
0068751F4  ldr      x8, [x1, #0x60]
0068751F8  mov      x0, x26
0068751FC  blr      x8
006875200  mov      x26, x0
006875204  cbz      x25, #0x6875358
006875208  ldrb     w8, [x28, #0xbb7]
00687520C  cbnz     w8, #0x687521c
006875210  mov      x0, x23
006875214  bl       #0x382bd14 ; 
006875218  strb     w29, [x28, #0xbb7]
00687521C  ldr      x1, [x23]
006875220  ldrb     w8, [x1, #0x53]
006875224  tbnz     w8, #5, #0x6875230
006875228  ldr      w1, [x25, #0x24]
00687522C  b        #0x6875240 ; 
006875230  ldr      x8, [x1, #0x60]
006875234  mov      x0, x25
006875238  blr      x8
00687523C  mov      w1, w0
006875240  cbz      x26, #0x687534c
006875244  mov      x0, x26
006875248  mov      x2, xzr
00687524C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006875250  mov      x26, x0
006875254  cbz      x0, #0x6875350
006875258  ldrb     w8, [x27, #0xb7f]
00687525C  ldr      x22, [x21, #0x78]
006875260  cbnz     w8, #0x6875270
006875264  mov      x0, x24
006875268  bl       #0x382bd14 ; 
00687526C  strb     w29, [x27, #0xb7f]
006875270  ldr      x1, [x24]
006875274  ldrb     w8, [x1, #0x53]
006875278  tbnz     w8, #5, #0x6875284
00687527C  ldr      w0, [x26, #0x30]
006875280  b        #0x6875290 ; 
006875284  ldr      x8, [x1, #0x60]
006875288  mov      x0, x26
00687528C  blr      x8
006875290  cbz      x22, #0x6875348
006875294  ldr      w9, [x22, #0x18]
006875298  sub      w8, w0, #1
00687529C  cmp      w8, w9
0068752A0  b.hs     #0x687535c
0068752A4  add      x8, x22, w8, sxtw #3
0068752A8  ldr      x1, [x8, #0x20]
0068752AC  mov      x0, x21
0068752B0  mov      x2, x25
0068752B4  mov      x3, x20
0068752B8  bl       #0x6872808 ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToRandom
0068752BC  b        #0x68750e0 ; 
0068752C0  mov      x21, xzr
0068752C4  cbz      x19, #0x6875328
0068752C8  adrp     x10, #0x8ebf000
0068752CC  ldr      x8, [x19]
0068752D0  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
0068752D4  ldrh     w9, [x8, #0x12e]
0068752D8  ldr      x1, [x10]
0068752DC  cbz      x9, #0x6875300
0068752E0  ldr      x10, [x8, #0xb0]
0068752E4  add      x10, x10, #8
0068752E8  ldur     x11, [x10, #-8]
0068752EC  cmp      x11, x1
0068752F0  b.eq     #0x6875310
0068752F4  subs     x9, x9, #1
0068752F8  add      x10, x10, #0x10
0068752FC  b.ne     #0x68752e8
006875300  mov      x0, x19
006875304  mov      w2, wzr
006875308  bl       #0x3a7e710 ; 
00687530C  b        #0x687531c ; 
006875310  ldrsw    x9, [x10]
006875314  add      x8, x8, x9, lsl #4
006875318  add      x0, x8, #0x138
00687531C  ldp      x8, x1, [x0]
006875320  mov      x0, x19
006875324  blr      x8
006875328  cbnz     x21, #0x6875368
00687532C  ldp      x20, x19, [sp, #0x50]
006875330  ldp      x22, x21, [sp, #0x40]
006875334  ldp      x24, x23, [sp, #0x30]
006875338  ldp      x26, x25, [sp, #0x20]
00687533C  ldp      x28, x27, [sp, #0x10]
006875340  ldp      x29, x30, [sp], #0x60
006875344  ret      
006875348  bl       #0x382bfb8 ; 
00687534C  bl       #0x382bfb8 ; 
006875350  bl       #0x382bfb8 ; 
006875354  bl       #0x382bfb8 ; 
006875358  bl       #0x382bfb8 ; 
00687535C  bl       #0x382bfc0 ; 
006875360  bl       #0x382bfb8 ; 
006875364  bl       #0x382bfb8 ; 
006875368  mov      x0, x21
00687536C  bl       #0x382bfb0 ; 
006875370  b        #0x68753a8 ; 
006875374  b        #0x68753a8 ; 
006875378  b        #0x68753a8 ; 
00687537C  b        #0x68753a8 ; 
006875380  b        #0x68753a8 ; 
006875384  b        #0x68753a8 ; 
006875388  b        #0x68753a8 ; 
00687538C  b        #0x68753a8 ; 
006875390  b        #0x68753a8 ; 
006875394  b        #0x68753a8 ; 
006875398  b        #0x68753a8 ; 
00687539C  b        #0x68753a8 ; 
0068753A0  b        #0x68753a8 ; 
0068753A4  b        #0x68753a8 ; 
0068753A8  mov      x20, x0
0068753AC  cmp      w1, #1
0068753B0  b.ne     #0x68753c8
0068753B4  mov      x0, x20
0068753B8  bl       #0x89eda50 ; 
0068753BC  ldr      x21, [x0]
0068753C0  bl       #0x89eda60 ; 
0068753C4  b        #0x68752c4 ; 
0068753C8  mov      x21, xzr
0068753CC  b        #0x68753d4 ; 
0068753D0  mov      x20, x0
0068753D4  cbz      x19, #0x6875438
0068753D8  adrp     x10, #0x8ebf000
0068753DC  ldr      x8, [x19]
0068753E0  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
0068753E4  ldrh     w9, [x8, #0x12e]
0068753E8  ldr      x1, [x10]
0068753EC  cbz      x9, #0x6875410
0068753F0  ldr      x10, [x8, #0xb0]
0068753F4  add      x10, x10, #8
0068753F8  ldur     x11, [x10, #-8]
0068753FC  cmp      x11, x1
006875400  b.eq     #0x6875420
006875404  subs     x9, x9, #1
006875408  add      x10, x10, #0x10
00687540C  b.ne     #0x68753f8
006875410  mov      x0, x19
006875414  mov      w2, wzr
006875418  bl       #0x3a7e710 ; 
00687541C  b        #0x687542c ; 
006875420  ldrsw    x9, [x10]
006875424  add      x8, x8, x9, lsl #4
006875428  add      x0, x8, #0x138
00687542C  ldp      x8, x1, [x0]
006875430  mov      x0, x19
006875434  blr      x8
006875438  cbnz     x21, #0x6875444
00687543C  mov      x0, x20
006875440  bl       #0x3b56bfc ; 
006875444  mov      x0, x21
006875448  bl       #0x382bfb0 ; 
00687544C  bl       #0x3442448 ; 

