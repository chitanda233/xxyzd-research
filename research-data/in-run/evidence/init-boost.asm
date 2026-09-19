; HotFix.BattleLogic.SinglePlayerSkillCreator$$GetNormalSkill
; RVA 0x6875450; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006875450  sub      sp, sp, #0xa0
006875454  stp      x29, x30, [sp, #0x40]
006875458  stp      x28, x27, [sp, #0x50]
00687545C  stp      x26, x25, [sp, #0x60]
006875460  stp      x24, x23, [sp, #0x70]
006875464  stp      x22, x21, [sp, #0x80]
006875468  stp      x20, x19, [sp, #0x90]
00687546C  adrp     x20, #0x959b000
006875470  adrp     x23, #0x8f24000
006875474  ldrb     w8, [x20, #0xaa9]
006875478  ldr      x23, [x23, #0x508]
00687547C  mov      x22, x7
006875480  mov      x26, x6
006875484  mov      x21, x5
006875488  mov      w29, w4
00687548C  mov      x27, x3
006875490  mov      w25, w2
006875494  mov      x28, x1
006875498  mov      x19, x0
00687549C  tbnz     w8, #0, #0x6875514
0068754A0  adrp     x0, #0x8f0c000
0068754A4  ldr      x0, [x0, #0x1c0]
0068754A8  bl       #0x382bd14 ; 
0068754AC  adrp     x0, #0x8ee8000
0068754B0  ldr      x0, [x0, #0x898]
0068754B4  bl       #0x382bd14 ; 
0068754B8  adrp     x0, #0x8f08000
0068754BC  ldr      x0, [x0, #0x40]
0068754C0  bl       #0x382bd14 ; 
0068754C4  adrp     x0, #0x8f23000
0068754C8  ldr      x0, [x0, #0xbb0]
0068754CC  bl       #0x382bd14 ; 
0068754D0  adrp     x0, #0x8f23000
0068754D4  ldr      x0, [x0, #0xbb8]
0068754D8  bl       #0x382bd14 ; 
0068754DC  adrp     x0, #0x8f08000
0068754E0  ldr      x0, [x0, #0x630]
0068754E4  bl       #0x382bd14 ; 
0068754E8  adrp     x0, #0x8f23000
0068754EC  ldr      x0, [x0, #0xbc0]
0068754F0  bl       #0x382bd14 ; 
0068754F4  adrp     x0, #0x8f23000
0068754F8  ldr      x0, [x0, #0xbc8]
0068754FC  bl       #0x382bd14 ; 
006875500  adrp     x0, #0x8f24000
006875504  ldr      x0, [x0, #0x508]
006875508  bl       #0x382bd14 ; 
00687550C  mov      w8, #1
006875510  strb     w8, [x20, #0xaa9]
006875514  ldr      x8, [x23]
006875518  ldrb     w9, [x8, #0x53]
00687551C  tbnz     w9, #5, #0x6875588
006875520  ldr      x22, [x19, #0x48]
006875524  mov      x0, x19
006875528  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00687552C  cbz      x0, #0x6875688
006875530  ldrb     w8, [x0, #0x25]
006875534  cbz      w8, #0x68756bc
006875538  mov      w20, wzr
00687553C  mov      x0, x19
006875540  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875544  cbz      x0, #0x6875688
006875548  adrp     x23, #0x9598000
00687554C  ldrb     w8, [x23, #0xfc4]
006875550  mov      x26, x0
006875554  cbnz     w8, #0x687556c
006875558  adrp     x0, #0x8f05000
00687555C  ldr      x0, [x0, #0xfd8]
006875560  bl       #0x382bd14 ; 
006875564  mov      w8, #1
006875568  strb     w8, [x23, #0xfc4]
00687556C  adrp     x8, #0x8f05000
006875570  ldr      x8, [x8, #0xfd8]
006875574  ldr      x1, [x8]
006875578  ldrb     w8, [x1, #0x53]
00687557C  tbnz     w8, #5, #0x68755d0
006875580  ldr      x0, [x26, #0x220]
006875584  b        #0x68755dc ; 
006875588  ldr      x9, [x8, #0x60]
00687558C  and      w2, w25, #1
006875590  and      w4, w29, #1
006875594  mov      x0, x19
006875598  mov      x1, x28
00687559C  mov      x3, x27
0068755A0  mov      x5, x21
0068755A4  mov      x6, x26
0068755A8  mov      x7, x22
0068755AC  ldp      x20, x19, [sp, #0x90]
0068755B0  ldp      x22, x21, [sp, #0x80]
0068755B4  ldp      x24, x23, [sp, #0x70]
0068755B8  ldp      x26, x25, [sp, #0x60]
0068755BC  ldp      x28, x27, [sp, #0x50]
0068755C0  ldp      x29, x30, [sp, #0x40]
0068755C4  str      x8, [sp, #0xa0]
0068755C8  add      sp, sp, #0xa0
0068755CC  br       x9
0068755D0  ldr      x8, [x1, #0x60]
0068755D4  mov      x0, x26
0068755D8  blr      x8
0068755DC  cbz      x0, #0x6875688
0068755E0  ldr      x8, [x0]
0068755E4  ldp      x9, x1, [x8, #0x1c8]
0068755E8  blr      x9
0068755EC  mov      w4, w0
0068755F0  add      x5, x19, #0x60
0068755F4  and      w8, w25, #1
0068755F8  and      w7, w29, #1
0068755FC  mov      x0, x19
006875600  mov      x1, x28
006875604  mov      x2, x21
006875608  mov      x3, x22
00687560C  mov      x6, x27
006875610  strb     w8, [sp]
006875614  bl       #0x685b9c4 ; HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills
006875618  cbz      w20, #0x6875698
00687561C  ldr      x0, [x19, #0x70]
006875620  cbz      x0, #0x6875688
006875624  adrp     x21, #0x8f23000
006875628  ldr      x21, [x21, #0xbc8]
00687562C  mov      w20, wzr
006875630  ldr      w8, [x0, #0x18]
006875634  cmp      w20, w8
006875638  b.ge     #0x687568c
00687563C  ldr      x2, [x21]
006875640  mov      w1, w20
006875644  bl       #0x4dacd78 ; System.Collections.Generic.List<NewPlayerBoostRecord>$$get_Item
006875648  cbz      x22, #0x6875688
00687564C  ldr      w8, [x22, #0x18]
006875650  cmp      w0, w8
006875654  b.hs     #0x6875aa8
006875658  lsl      x8, x0, #0x20
00687565C  add      x8, x22, x8, asr #29
006875660  ldr      x8, [x8, #0x20]
006875664  cbz      x8, #0x6875688
006875668  mov      x2, x1
00687566C  lsr      x1, x0, #0x20
006875670  mov      x0, x8
006875674  mov      x3, xzr
006875678  bl       #0x6633908 ; HotFix.BattleLogic.WeightRandom$$RevertWeightBoost
00687567C  ldr      x0, [x19, #0x70]
006875680  add      w20, w20, #1
006875684  cbnz     x0, #0x6875630
006875688  bl       #0x382bfb8 ; 
00687568C  ldr      w8, [x0, #0x1c]
006875690  add      w8, w8, #1
006875694  stp      wzr, w8, [x0, #0x18]
006875698  ldp      x20, x19, [sp, #0x90]
00687569C  ldp      x22, x21, [sp, #0x80]
0068756A0  ldp      x24, x23, [sp, #0x70]
0068756A4  ldp      x26, x25, [sp, #0x60]
0068756A8  ldp      x28, x27, [sp, #0x50]
0068756AC  ldp      x29, x30, [sp, #0x40]
0068756B0  mov      w0, wzr
0068756B4  add      sp, sp, #0xa0
0068756B8  ret      
0068756BC  mov      x0, x19
0068756C0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068756C4  cbz      x0, #0x6875688
0068756C8  adrp     x20, #0x959b000
0068756CC  ldrb     w8, [x20, #0xb84]
0068756D0  mov      x26, x0
0068756D4  cbnz     w8, #0x68756ec
0068756D8  adrp     x0, #0x8f23000
0068756DC  ldr      x0, [x0, #0xb98]
0068756E0  bl       #0x382bd14 ; 
0068756E4  mov      w8, #1
0068756E8  strb     w8, [x20, #0xb84]
0068756EC  adrp     x8, #0x8f23000
0068756F0  ldr      x8, [x8, #0xb98]
0068756F4  ldr      x1, [x8]
0068756F8  ldrb     w8, [x1, #0x53]
0068756FC  tbnz     w8, #5, #0x6875708
006875700  ldr      w0, [x26, #0x2c4]
006875704  b        #0x6875714 ; 
006875708  ldr      x8, [x1, #0x60]
00687570C  mov      x0, x26
006875710  blr      x8
006875714  cmp      w0, #1
006875718  b.lt     #0x6875538
00687571C  ldr      x22, [x19, #0x18]
006875720  mov      x0, x19
006875724  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875728  cbz      x0, #0x6875688
00687572C  adrp     x20, #0x959b000
006875730  ldrb     w8, [x20, #0xb83]
006875734  mov      x26, x0
006875738  cbnz     w8, #0x6875750
00687573C  adrp     x0, #0x8f23000
006875740  ldr      x0, [x0, #0xb80]
006875744  bl       #0x382bd14 ; 
006875748  mov      w8, #1
00687574C  strb     w8, [x20, #0xb83]
006875750  adrp     x8, #0x8f23000
006875754  ldr      x8, [x8, #0xb80]
006875758  ldr      x1, [x8]
00687575C  ldrb     w8, [x1, #0x53]
006875760  tbnz     w8, #5, #0x6875774
006875764  ldr      w8, [x26, #0x2c4]
006875768  sub      w8, w8, #1
00687576C  str      w8, [x26, #0x2c4]
006875770  b        #0x6875780 ; 
006875774  ldr      x8, [x1, #0x60]
006875778  mov      x0, x26
00687577C  blr      x8
006875780  mov      x0, x19
006875784  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875788  cbz      x0, #0x6875688
00687578C  ldr      w8, [x0, #0x1c8]
006875790  cmp      w8, #1
006875794  b.ne     #0x6875538
006875798  mov      x0, x19
00687579C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068757A0  cbz      x0, #0x6875688
0068757A4  ldr      x26, [x0, #0x3b8]
0068757A8  cbz      x26, #0x6875688
0068757AC  adrp     x20, #0x8f08000
0068757B0  ldr      x8, [x26]
0068757B4  ldr      x20, [x20, #0x40]
0068757B8  ldrh     w9, [x8, #0x12e]
0068757BC  ldr      x1, [x20]
0068757C0  cbz      x9, #0x68757e4
0068757C4  ldr      x10, [x8, #0xb0]
0068757C8  add      x10, x10, #8
0068757CC  ldur     x11, [x10, #-8]
0068757D0  cmp      x11, x1
0068757D4  b.eq     #0x68757f4
0068757D8  subs     x9, x9, #1
0068757DC  add      x10, x10, #0x10
0068757E0  b.ne     #0x68757cc
0068757E4  mov      w2, #0x1e
0068757E8  mov      x0, x26
0068757EC  bl       #0x3a7e710 ; 
0068757F0  b        #0x6875804 ; 
0068757F4  ldr      w9, [x10]
0068757F8  add      w9, w9, #0x1e
0068757FC  add      x8, x8, w9, sxtw #4
006875800  add      x0, x8, #0x138
006875804  ldp      x8, x1, [x0]
006875808  mov      x0, x26
00687580C  blr      x8
006875810  cbz      x0, #0x6875538
006875814  mov      x0, x19
006875818  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00687581C  cbz      x0, #0x6875688
006875820  ldr      x26, [x0, #0x3b8]
006875824  cbz      x26, #0x6875688
006875828  ldr      x8, [x26]
00687582C  ldr      x1, [x20]
006875830  ldrh     w9, [x8, #0x12e]
006875834  cbz      x9, #0x6875858
006875838  ldr      x10, [x8, #0xb0]
00687583C  add      x10, x10, #8
006875840  ldur     x11, [x10, #-8]
006875844  cmp      x11, x1
006875848  b.eq     #0x6875868
00687584C  subs     x9, x9, #1
006875850  add      x10, x10, #0x10
006875854  b.ne     #0x6875840
006875858  mov      w2, #0x1e
00687585C  mov      x0, x26
006875860  bl       #0x3a7e710 ; 
006875864  b        #0x6875878 ; 
006875868  ldr      w9, [x10]
00687586C  add      w9, w9, #0x1e
006875870  add      x8, x8, w9, sxtw #4
006875874  add      x0, x8, #0x138
006875878  ldp      x8, x1, [x0]
00687587C  mov      x0, x26
006875880  blr      x8
006875884  adrp     x8, #0x8f0c000
006875888  ldr      x8, [x8, #0x1c0]
00687588C  mov      w1, #3
006875890  ldr      x2, [x8]
006875894  bl       #0x47b3cd0 ; System.Array$$IndexOf<int>
006875898  tbnz     w0, #0x1f, #0x6875538
00687589C  adrp     x24, #0x8ee8000
0068758A0  ldr      x24, [x24, #0x898]
0068758A4  ldr      x0, [x24]
0068758A8  ldr      w8, [x0, #0xe0]
0068758AC  cbnz     w8, #0x68758b4
0068758B0  bl       #0x382be8c ; 
0068758B4  cbz      x21, #0x6875688
0068758B8  ldr      x8, [x24]
0068758BC  adrp     x9, #0x8f08000
0068758C0  mov      x0, x21
0068758C4  ldr      x8, [x8, #0xb8]
0068758C8  ldr      x9, [x9, #0x630]
0068758CC  ldr      w1, [x8, #0x490]
0068758D0  ldr      x2, [x9]
0068758D4  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0068758D8  tbnz     w0, #0, #0x6875538
0068758DC  ldr      x8, [x19, #0x70]
0068758E0  str      w29, [sp, #0x1c]
0068758E4  stp      x28, x27, [sp, #0x20]
0068758E8  cbz      x8, #0x6875688
0068758EC  ldr      w9, [x8, #0x1c]
0068758F0  adrp     x23, #0x8f23000
0068758F4  ldr      x23, [x23, #0xbb0]
0068758F8  mov      w20, wzr
0068758FC  add      w9, w9, #1
006875900  mov      w29, wzr
006875904  stp      wzr, w9, [x8, #0x18]
006875908  ldr      x0, [x24]
00687590C  ldr      w8, [x0, #0xe0]
006875910  cbnz     w8, #0x687591c
006875914  bl       #0x382be8c ; 
006875918  ldr      x0, [x24]
00687591C  ldr      x8, [x0, #0xb8]
006875920  ldr      x8, [x8, #0x498]
006875924  cbz      x8, #0x6875688
006875928  ldr      w9, [x8, #0x18]
00687592C  cmp      w20, w9
006875930  b.ge     #0x6875a98
006875934  ldr      w9, [x0, #0xe0]
006875938  cbnz     w9, #0x6875950
00687593C  bl       #0x382be8c ; 
006875940  ldr      x8, [x24]
006875944  ldr      x8, [x8, #0xb8]
006875948  ldr      x8, [x8, #0x498]
00687594C  cbz      x8, #0x6875688
006875950  ldr      w9, [x8, #0x18]
006875954  cmp      w20, w9
006875958  b.hs     #0x6875aa8
00687595C  add      x8, x8, w20, sxtw #3
006875960  ldr      x0, [x8, #0x20]
006875964  cbz      x0, #0x6875688
006875968  mov      w1, #0x7c
00687596C  mov      w2, wzr
006875970  mov      x3, xzr
006875974  bl       #0x79e4950 ; System.String$$Split
006875978  cbz      x0, #0x6875688
00687597C  ldr      w8, [x0, #0x18]
006875980  mov      x27, x0
006875984  cmp      w8, #2
006875988  b.lt     #0x6875a90
00687598C  ldr      x0, [x27, #0x20]
006875990  mov      x1, xzr
006875994  bl       #0x7bd25d0 ; System.Int32$$Parse
006875998  ldr      w8, [x27, #0x18]
00687599C  cmp      w8, #1
0068759A0  b.ls     #0x6875aa8
0068759A4  mov      w26, w0
0068759A8  ldr      x0, [x27, #0x28]
0068759AC  mov      x1, xzr
0068759B0  bl       #0x7bd25d0 ; System.Int32$$Parse
0068759B4  cbz      x22, #0x6875688
0068759B8  ldr      w8, [x22, #0x18]
0068759BC  cmp      w8, #1
0068759C0  b.lt     #0x6875a90
0068759C4  mov      w27, w0
0068759C8  mov      w28, wzr
0068759CC  cmp      w28, w8
0068759D0  b.hs     #0x6875aa8
0068759D4  add      x8, x22, w28, sxtw #3
0068759D8  ldr      x0, [x8, #0x20]
0068759DC  cbz      x0, #0x6875688
0068759E0  mov      w1, w26
0068759E4  mov      w2, w27
0068759E8  mov      x3, xzr
0068759EC  bl       #0x6633824 ; HotFix.BattleLogic.WeightRandom$$BoostWeightByPercent
0068759F0  cmp      w0, #1
0068759F4  b.lt     #0x6875a80
0068759F8  ldr      x29, [x19, #0x70]
0068759FC  mov      w3, w0
006875A00  add      x0, sp, #0x30
006875A04  mov      w1, w28
006875A08  mov      w2, w26
006875A0C  str      wzr, [sp, #0x38]
006875A10  str      xzr, [sp, #0x30]
006875A14  bl       #0x685ec60 ; HotFix.BattleLogic.NewPlayerBoostRecord$$.ctor
006875A18  cbz      x29, #0x6875688
006875A1C  ldr      w10, [x29, #0x1c]
006875A20  ldr      x1, [sp, #0x30]
006875A24  ldr      w2, [sp, #0x38]
006875A28  ldr      x8, [x29, #0x10]
006875A2C  ldr      x9, [x23]
006875A30  add      w10, w10, #1
006875A34  str      w10, [x29, #0x1c]
006875A38  cbz      x8, #0x6875688
006875A3C  ldrsw    x10, [x29, #0x18]
006875A40  ldr      w11, [x8, #0x18]
006875A44  cmp      w10, w11
006875A48  b.hs     #0x6875a68
006875A4C  mov      w11, #0xc
006875A50  add      w9, w10, #1
006875A54  madd     x8, x10, x11, x8
006875A58  str      w9, [x29, #0x18]
006875A5C  str      x1, [x8, #0x20]
006875A60  str      w2, [x8, #0x28]
006875A64  b        #0x6875a7c ; 
006875A68  ldr      x8, [x9, #0x20]
006875A6C  mov      x0, x29
006875A70  ldr      x8, [x8, #0xc0]
006875A74  ldr      x3, [x8, #0x70]
006875A78  bl       #0x4dad0a0 ; System.Collections.Generic.List<NewPlayerBoostRecord>$$AddWithResize
006875A7C  mov      w29, #1
006875A80  ldr      w8, [x22, #0x18]
006875A84  add      w28, w28, #1
006875A88  cmp      w28, w8
006875A8C  b.lt     #0x68759cc
006875A90  add      w20, w20, #1
006875A94  b        #0x6875908 ; 
006875A98  and      w20, w29, #1
006875A9C  ldp      x28, x27, [sp, #0x20]
006875AA0  ldr      w29, [sp, #0x1c]
006875AA4  b        #0x687553c ; 
006875AA8  bl       #0x382bfc0 ; 

