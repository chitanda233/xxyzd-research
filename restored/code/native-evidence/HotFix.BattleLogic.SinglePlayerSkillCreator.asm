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

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnInitRandoms
; RVA 0x6875AAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006875AAC  stp      x30, x21, [sp, #-0x20]!
006875AB0  stp      x20, x19, [sp, #0x10]
006875AB4  adrp     x20, #0x959b000
006875AB8  adrp     x21, #0x8f24000
006875ABC  ldrb     w8, [x20, #0xaaa]
006875AC0  ldr      x21, [x21, #0x510]
006875AC4  mov      x19, x0
006875AC8  tbnz     w8, #0, #0x6875af8
006875ACC  adrp     x0, #0x8ee8000
006875AD0  ldr      x0, [x0, #0x898]
006875AD4  bl       #0x382bd14 ; 
006875AD8  adrp     x0, #0x8f24000
006875ADC  ldr      x0, [x0, #0x510]
006875AE0  bl       #0x382bd14 ; 
006875AE4  adrp     x0, #0x8f23000
006875AE8  ldr      x0, [x0, #0xb08]
006875AEC  bl       #0x382bd14 ; 
006875AF0  mov      w8, #1
006875AF4  strb     w8, [x20, #0xaaa]
006875AF8  ldr      x1, [x21]
006875AFC  ldrb     w8, [x1, #0x53]
006875B00  tbnz     w8, #5, #0x6875be8
006875B04  adrp     x21, #0x8ee8000
006875B08  adrp     x20, #0x8f23000
006875B0C  ldr      x21, [x21, #0x898]
006875B10  ldr      x20, [x20, #0xb08]
006875B14  mov      x0, x19
006875B18  bl       #0x6871dc0 ; HotFix.BattleLogic.HeroSkillCreator$$OnInitRandoms
006875B1C  ldr      x0, [x21]
006875B20  ldr      w8, [x0, #0xe0]
006875B24  cbnz     w8, #0x6875b30
006875B28  bl       #0x382be8c ; 
006875B2C  ldr      x0, [x21]
006875B30  ldr      x8, [x0, #0xb8]
006875B34  ldr      x0, [x20]
006875B38  ldr      w1, [x8, #0x2f0]
006875B3C  bl       #0x382bdfc ; 
006875B40  mov      x1, x0
006875B44  mov      x0, x19
006875B48  str      x1, [x0, #0x18]!
006875B4C  bl       #0x382bcb8 ; 
006875B50  ldr      x8, [x21]
006875B54  ldr      x0, [x20]
006875B58  ldr      x8, [x8, #0xb8]
006875B5C  ldr      w1, [x8, #0x2f0]
006875B60  bl       #0x382bdfc ; 
006875B64  mov      x1, x0
006875B68  mov      x0, x19
006875B6C  str      x1, [x0, #0x20]!
006875B70  bl       #0x382bcb8 ; 
006875B74  ldr      x8, [x21]
006875B78  ldr      x0, [x20]
006875B7C  ldr      x8, [x8, #0xb8]
006875B80  ldr      w1, [x8, #0x2f0]
006875B84  bl       #0x382bdfc ; 
006875B88  mov      x1, x0
006875B8C  mov      x0, x19
006875B90  str      x1, [x0, #0x30]!
006875B94  bl       #0x382bcb8 ; 
006875B98  ldr      x8, [x21]
006875B9C  ldr      x0, [x20]
006875BA0  ldr      x8, [x8, #0xb8]
006875BA4  ldr      w1, [x8, #0x2f0]
006875BA8  bl       #0x382bdfc ; 
006875BAC  mov      x1, x0
006875BB0  mov      x0, x19
006875BB4  str      x1, [x0, #0x38]!
006875BB8  bl       #0x382bcb8 ; 
006875BBC  ldr      x8, [x21]
006875BC0  ldr      x0, [x20]
006875BC4  ldr      x8, [x8, #0xb8]
006875BC8  ldr      w1, [x8, #0x2f0]
006875BCC  bl       #0x382bdfc ; 
006875BD0  str      x0, [x19, #0x28]!
006875BD4  mov      x1, x0
006875BD8  mov      x0, x19
006875BDC  ldp      x20, x19, [sp, #0x10]
006875BE0  ldp      x30, x21, [sp], #0x20
006875BE4  b        #0x382bcb8 ; 
006875BE8  ldr      x2, [x1, #0x60]
006875BEC  mov      x0, x19
006875BF0  ldp      x20, x19, [sp, #0x10]
006875BF4  ldp      x30, x21, [sp], #0x20
006875BF8  br       x2

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCreateRandoms
; RVA 0x68740D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068740D8  stp      x30, x21, [sp, #-0x20]!
0068740DC  stp      x20, x19, [sp, #0x10]
0068740E0  adrp     x20, #0x959b000
0068740E4  adrp     x21, #0x8f24000
0068740E8  ldrb     w8, [x20, #0xaab]
0068740EC  ldr      x21, [x21, #0x480]
0068740F0  mov      x19, x0
0068740F4  tbnz     w8, #0, #0x6874118
0068740F8  adrp     x0, #0x8f24000
0068740FC  ldr      x0, [x0, #0x480]
006874100  bl       #0x382bd14 ; 
006874104  adrp     x0, #0x8f23000
006874108  ldr      x0, [x0, #0xb20]
00687410C  bl       #0x382bd14 ; 
006874110  mov      w8, #1
006874114  strb     w8, [x20, #0xaab]
006874118  ldr      x1, [x21]
00687411C  ldrb     w8, [x1, #0x53]
006874120  tbnz     w8, #5, #0x6874170
006874124  mov      x0, x19
006874128  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00687412C  cbz      x0, #0x68741f8
006874130  adrp     x21, #0x9591000
006874134  ldrb     w8, [x21, #0xa4c]
006874138  mov      x20, x0
00687413C  cbnz     w8, #0x6874154
006874140  adrp     x0, #0x8ee5000
006874144  ldr      x0, [x0, #0xb30]
006874148  bl       #0x382bd14 ; 
00687414C  mov      w8, #1
006874150  strb     w8, [x21, #0xa4c]
006874154  adrp     x8, #0x8ee5000
006874158  ldr      x8, [x8, #0xb30]
00687415C  ldr      x1, [x8]
006874160  ldrb     w8, [x1, #0x53]
006874164  tbnz     w8, #5, #0x6874184
006874168  ldr      x0, [x20, #0x210]
00687416C  b        #0x6874190 ; 
006874170  ldr      x2, [x1, #0x60]
006874174  mov      x0, x19
006874178  ldp      x20, x19, [sp, #0x10]
00687417C  ldp      x30, x21, [sp], #0x20
006874180  br       x2
006874184  ldr      x8, [x1, #0x60]
006874188  mov      x0, x20
00687418C  blr      x8
006874190  cbz      x0, #0x68741f8
006874194  adrp     x8, #0x8f23000
006874198  ldr      x8, [x8, #0xb20]
00687419C  ldr      x1, [x8]
0068741A0  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0068741A4  mov      x1, x0
0068741A8  mov      x0, x19
0068741AC  str      x1, [x0, #0x40]!
0068741B0  bl       #0x382bcb8 ; 
0068741B4  ldr      x1, [x19, #0x18]
0068741B8  mov      x0, x19
0068741BC  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741C0  ldr      x1, [x19, #0x20]
0068741C4  mov      x0, x19
0068741C8  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741CC  ldr      x1, [x19, #0x30]
0068741D0  mov      x0, x19
0068741D4  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741D8  ldr      x1, [x19, #0x38]
0068741DC  mov      x0, x19
0068741E0  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741E4  ldr      x1, [x19, #0x28]
0068741E8  mov      x0, x19
0068741EC  ldp      x20, x19, [sp, #0x10]
0068741F0  ldp      x30, x21, [sp], #0x20
0068741F4  b        #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741F8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnInitRandomSkill
; RVA 0x6875BFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006875BFC  str      x30, [sp, #-0x30]!
006875C00  stp      x22, x21, [sp, #0x10]
006875C04  stp      x20, x19, [sp, #0x20]
006875C08  adrp     x21, #0x959b000
006875C0C  adrp     x22, #0x8f24000
006875C10  ldrb     w8, [x21, #0xaac]
006875C14  ldr      x22, [x22, #0x518]
006875C18  mov      x19, x1
006875C1C  mov      x20, x0
006875C20  tbnz     w8, #0, #0x6875c38
006875C24  adrp     x0, #0x8f24000
006875C28  ldr      x0, [x0, #0x518]
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
006875C64  ldr      x0, [x0, #0xfd8]
006875C68  bl       #0x382bd14 ; 
006875C6C  mov      w8, #1
006875C70  strb     w8, [x22, #0xfc4]
006875C74  adrp     x8, #0x8f05000
006875C78  ldr      x8, [x8, #0xfd8]
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

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnRemoveRandomSkill
; RVA 0x68744C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068744C4  str      x30, [sp, #-0x30]!
0068744C8  stp      x22, x21, [sp, #0x10]
0068744CC  stp      x20, x19, [sp, #0x20]
0068744D0  adrp     x21, #0x959b000
0068744D4  adrp     x22, #0x8f24000
0068744D8  ldrb     w8, [x21, #0xaad]
0068744DC  ldr      x22, [x22, #0x498]
0068744E0  mov      w19, w1
0068744E4  mov      x20, x0
0068744E8  tbnz     w8, #0, #0x6874500
0068744EC  adrp     x0, #0x8f24000
0068744F0  ldr      x0, [x0, #0x498]
0068744F4  bl       #0x382bd14 ; 
0068744F8  mov      w8, #1
0068744FC  strb     w8, [x21, #0xaad]
006874500  ldr      x2, [x22]
006874504  ldrb     w8, [x2, #0x53]
006874508  tbnz     w8, #5, #0x6874558
00687450C  mov      x0, x20
006874510  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006874514  cbz      x0, #0x6874634
006874518  adrp     x22, #0x959b000
00687451C  ldrb     w8, [x22, #0xb84]
006874520  mov      x21, x0
006874524  cbnz     w8, #0x687453c
006874528  adrp     x0, #0x8f23000
00687452C  ldr      x0, [x0, #0xb98]
006874530  bl       #0x382bd14 ; 
006874534  mov      w8, #1
006874538  strb     w8, [x22, #0xb84]
00687453C  adrp     x8, #0x8f23000
006874540  ldr      x8, [x8, #0xb98]
006874544  ldr      x1, [x8]
006874548  ldrb     w8, [x1, #0x53]
00687454C  tbnz     w8, #5, #0x6874574
006874550  ldr      w0, [x21, #0x2c4]
006874554  b        #0x6874580 ; 
006874558  ldr      x3, [x2, #0x60]
00687455C  mov      x0, x20
006874560  mov      w1, w19
006874564  ldp      x20, x19, [sp, #0x20]
006874568  ldp      x22, x21, [sp, #0x10]
00687456C  ldr      x30, [sp], #0x30
006874570  br       x3
006874574  ldr      x8, [x1, #0x60]
006874578  mov      x0, x21
00687457C  blr      x8
006874580  cmp      w0, #1
006874584  b.lt     #0x68745d4
006874588  ldr      x21, [x20, #0x18]
00687458C  cbz      x21, #0x6874634
006874590  ldr      w8, [x21, #0x18]
006874594  cmp      w8, #1
006874598  b.lt     #0x68745d4
00687459C  mov      w22, wzr
0068745A0  cmp      w22, w8
0068745A4  b.hs     #0x6874630
0068745A8  add      x8, x21, w22, sxtw #3
0068745AC  ldr      x0, [x8, #0x20]
0068745B0  cbz      x0, #0x6874634
0068745B4  mov      w1, w19
0068745B8  mov      w2, wzr
0068745BC  mov      x3, xzr
0068745C0  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
0068745C4  ldr      w8, [x21, #0x18]
0068745C8  add      w22, w22, #1
0068745CC  cmp      w22, w8
0068745D0  b.lt     #0x68745a0
0068745D4  ldr      x20, [x20, #0x20]
0068745D8  cbz      x20, #0x6874634
0068745DC  ldr      w8, [x20, #0x18]
0068745E0  cmp      w8, #1
0068745E4  b.lt     #0x6874620
0068745E8  mov      w21, wzr
0068745EC  cmp      w21, w8
0068745F0  b.hs     #0x6874630
0068745F4  add      x8, x20, w21, sxtw #3
0068745F8  ldr      x0, [x8, #0x20]
0068745FC  cbz      x0, #0x6874634
006874600  mov      w1, w19
006874604  mov      w2, wzr
006874608  mov      x3, xzr
00687460C  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006874610  ldr      w8, [x20, #0x18]
006874614  add      w21, w21, #1
006874618  cmp      w21, w8
00687461C  b.lt     #0x68745ec
006874620  ldp      x20, x19, [sp, #0x20]
006874624  ldp      x22, x21, [sp, #0x10]
006874628  ldr      x30, [sp], #0x30
00687462C  ret      
006874630  bl       #0x382bfc0 ; 
006874634  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnDeInit
; RVA 0x68746CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068746CC  stp      x30, x21, [sp, #-0x20]!
0068746D0  stp      x20, x19, [sp, #0x10]
0068746D4  adrp     x20, #0x959b000
0068746D8  adrp     x21, #0x8f24000
0068746DC  ldrb     w8, [x20, #0xaae]
0068746E0  ldr      x21, [x21, #0x4a8]
0068746E4  mov      x19, x0
0068746E8  tbnz     w8, #0, #0x6874700
0068746EC  adrp     x0, #0x8f24000
0068746F0  ldr      x0, [x0, #0x4a8]
0068746F4  bl       #0x382bd14 ; 
0068746F8  mov      w8, #1
0068746FC  strb     w8, [x20, #0xaae]
006874700  ldr      x1, [x21]
006874704  ldrb     w8, [x1, #0x53]
006874708  tbnz     w8, #5, #0x687472c
00687470C  ldr      x1, [x19, #0x18]
006874710  mov      x0, x19
006874714  bl       #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
006874718  ldr      x1, [x19, #0x20]
00687471C  mov      x0, x19
006874720  ldp      x20, x19, [sp, #0x10]
006874724  ldp      x30, x21, [sp], #0x20
006874728  b        #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
00687472C  ldr      x2, [x1, #0x60]
006874730  mov      x0, x19
006874734  ldp      x20, x19, [sp, #0x10]
006874738  ldp      x30, x21, [sp], #0x20
00687473C  br       x2

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddSkillFlag
; RVA 0x6874878; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874878  str      x30, [sp, #-0x30]!
00687487C  stp      x22, x21, [sp, #0x10]
006874880  stp      x20, x19, [sp, #0x20]
006874884  adrp     x21, #0x959b000
006874888  adrp     x22, #0x8f24000
00687488C  ldrb     w8, [x21, #0xaaf]
006874890  ldr      x22, [x22, #0x4b8]
006874894  mov      w19, w1
006874898  mov      x20, x0
00687489C  tbnz     w8, #0, #0x68748b4
0068748A0  adrp     x0, #0x8f24000
0068748A4  ldr      x0, [x0, #0x4b8]
0068748A8  bl       #0x382bd14 ; 
0068748AC  mov      w8, #1
0068748B0  strb     w8, [x21, #0xaaf]
0068748B4  ldr      x2, [x22]
0068748B8  ldrb     w8, [x2, #0x53]
0068748BC  tbnz     w8, #5, #0x6874960
0068748C0  ldr      x21, [x20, #0x18]
0068748C4  cbz      x21, #0x6874980
0068748C8  ldr      w8, [x21, #0x18]
0068748CC  cmp      w8, #1
0068748D0  b.lt     #0x6874908
0068748D4  mov      w22, wzr
0068748D8  cmp      w22, w8
0068748DC  b.hs     #0x687497c
0068748E0  add      x8, x21, w22, sxtw #3
0068748E4  ldr      x0, [x8, #0x20]
0068748E8  cbz      x0, #0x6874980
0068748EC  mov      w1, w19
0068748F0  mov      x2, xzr
0068748F4  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
0068748F8  ldr      w8, [x21, #0x18]
0068748FC  add      w22, w22, #1
006874900  cmp      w22, w8
006874904  b.lt     #0x68748d8
006874908  ldr      x20, [x20, #0x20]
00687490C  cbz      x20, #0x6874980
006874910  ldr      w8, [x20, #0x18]
006874914  cmp      w8, #1
006874918  b.lt     #0x6874950
00687491C  mov      w21, wzr
006874920  cmp      w21, w8
006874924  b.hs     #0x687497c
006874928  add      x8, x20, w21, sxtw #3
00687492C  ldr      x0, [x8, #0x20]
006874930  cbz      x0, #0x6874980
006874934  mov      w1, w19
006874938  mov      x2, xzr
00687493C  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
006874940  ldr      w8, [x20, #0x18]
006874944  add      w21, w21, #1
006874948  cmp      w21, w8
00687494C  b.lt     #0x6874920
006874950  ldp      x20, x19, [sp, #0x20]
006874954  ldp      x22, x21, [sp, #0x10]
006874958  ldr      x30, [sp], #0x30
00687495C  ret      
006874960  ldr      x3, [x2, #0x60]
006874964  mov      x0, x20
006874968  mov      w1, w19
00687496C  ldp      x20, x19, [sp, #0x20]
006874970  ldp      x22, x21, [sp, #0x10]
006874974  ldr      x30, [sp], #0x30
006874978  br       x3
00687497C  bl       #0x382bfc0 ; 
006874980  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectFlag
; RVA 0x6874ABC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874ABC  str      x30, [sp, #-0x30]!
006874AC0  stp      x22, x21, [sp, #0x10]
006874AC4  stp      x20, x19, [sp, #0x20]
006874AC8  adrp     x21, #0x959b000
006874ACC  adrp     x22, #0x8f24000
006874AD0  ldrb     w8, [x21, #0xab0]
006874AD4  ldr      x22, [x22, #0x4c8]
006874AD8  mov      w19, w1
006874ADC  mov      x20, x0
006874AE0  tbnz     w8, #0, #0x6874af8
006874AE4  adrp     x0, #0x8f24000
006874AE8  ldr      x0, [x0, #0x4c8]
006874AEC  bl       #0x382bd14 ; 
006874AF0  mov      w8, #1
006874AF4  strb     w8, [x21, #0xab0]
006874AF8  ldr      x2, [x22]
006874AFC  ldrb     w8, [x2, #0x53]
006874B00  tbnz     w8, #5, #0x6874ba4
006874B04  ldr      x21, [x20, #0x18]
006874B08  cbz      x21, #0x6874bc4
006874B0C  ldr      w8, [x21, #0x18]
006874B10  cmp      w8, #1
006874B14  b.lt     #0x6874b4c
006874B18  mov      w22, wzr
006874B1C  cmp      w22, w8
006874B20  b.hs     #0x6874bc0
006874B24  add      x8, x21, w22, sxtw #3
006874B28  ldr      x0, [x8, #0x20]
006874B2C  cbz      x0, #0x6874bc4
006874B30  mov      w1, w19
006874B34  mov      x2, xzr
006874B38  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874B3C  ldr      w8, [x21, #0x18]
006874B40  add      w22, w22, #1
006874B44  cmp      w22, w8
006874B48  b.lt     #0x6874b1c
006874B4C  ldr      x20, [x20, #0x20]
006874B50  cbz      x20, #0x6874bc4
006874B54  ldr      w8, [x20, #0x18]
006874B58  cmp      w8, #1
006874B5C  b.lt     #0x6874b94
006874B60  mov      w21, wzr
006874B64  cmp      w21, w8
006874B68  b.hs     #0x6874bc0
006874B6C  add      x8, x20, w21, sxtw #3
006874B70  ldr      x0, [x8, #0x20]
006874B74  cbz      x0, #0x6874bc4
006874B78  mov      w1, w19
006874B7C  mov      x2, xzr
006874B80  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874B84  ldr      w8, [x20, #0x18]
006874B88  add      w21, w21, #1
006874B8C  cmp      w21, w8
006874B90  b.lt     #0x6874b64
006874B94  ldp      x20, x19, [sp, #0x20]
006874B98  ldp      x22, x21, [sp, #0x10]
006874B9C  ldr      x30, [sp], #0x30
006874BA0  ret      
006874BA4  ldr      x3, [x2, #0x60]
006874BA8  mov      x0, x20
006874BAC  mov      w1, w19
006874BB0  ldp      x20, x19, [sp, #0x20]
006874BB4  ldp      x22, x21, [sp, #0x10]
006874BB8  ldr      x30, [sp], #0x30
006874BBC  br       x3
006874BC0  bl       #0x382bfc0 ; 
006874BC4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCheckNeedSkills
; RVA 0x6874BC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874BC8  str      x30, [sp, #-0x30]!
006874BCC  stp      x22, x21, [sp, #0x10]
006874BD0  stp      x20, x19, [sp, #0x20]
006874BD4  adrp     x21, #0x959b000
006874BD8  adrp     x22, #0x8f24000
006874BDC  ldrb     w8, [x21, #0xab1]
006874BE0  ldr      x22, [x22, #0x4d0]
006874BE4  mov      w19, w1
006874BE8  mov      x20, x0
006874BEC  tbnz     w8, #0, #0x6874c04
006874BF0  adrp     x0, #0x8f24000
006874BF4  ldr      x0, [x0, #0x4d0]
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

; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectSkills
; RVA 0x6874E2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874E2C  str      x30, [sp, #-0x30]!
006874E30  stp      x22, x21, [sp, #0x10]
006874E34  stp      x20, x19, [sp, #0x20]
006874E38  adrp     x21, #0x959b000
006874E3C  adrp     x22, #0x8f24000
006874E40  ldrb     w8, [x21, #0xab2]
006874E44  ldr      x22, [x22, #0x4e0]
006874E48  mov      x19, x1
006874E4C  mov      x20, x0
006874E50  tbnz     w8, #0, #0x6874e68
006874E54  adrp     x0, #0x8f24000
006874E58  ldr      x0, [x0, #0x4e0]
006874E5C  bl       #0x382bd14 ; 
006874E60  mov      w8, #1
006874E64  strb     w8, [x21, #0xab2]
006874E68  ldr      x2, [x22]
006874E6C  ldrb     w8, [x2, #0x53]
006874E70  tbnz     w8, #5, #0x6874f14
006874E74  ldr      x21, [x20, #0x18]
006874E78  cbz      x21, #0x6874f34
006874E7C  ldr      w8, [x21, #0x18]
006874E80  cmp      w8, #1
006874E84  b.lt     #0x6874ebc
006874E88  mov      w22, wzr
006874E8C  cmp      w22, w8
006874E90  b.hs     #0x6874f30
006874E94  add      x8, x21, w22, sxtw #3
006874E98  ldr      x0, [x8, #0x20]
006874E9C  cbz      x0, #0x6874f34
006874EA0  mov      x1, x19
006874EA4  mov      x2, xzr
006874EA8  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874EAC  ldr      w8, [x21, #0x18]
006874EB0  add      w22, w22, #1
006874EB4  cmp      w22, w8
006874EB8  b.lt     #0x6874e8c
006874EBC  ldr      x20, [x20, #0x20]
006874EC0  cbz      x20, #0x6874f34
006874EC4  ldr      w8, [x20, #0x18]
006874EC8  cmp      w8, #1
006874ECC  b.lt     #0x6874f04
006874ED0  mov      w21, wzr
006874ED4  cmp      w21, w8
006874ED8  b.hs     #0x6874f30
006874EDC  add      x8, x20, w21, sxtw #3
006874EE0  ldr      x0, [x8, #0x20]
006874EE4  cbz      x0, #0x6874f34
006874EE8  mov      x1, x19
006874EEC  mov      x2, xzr
006874EF0  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874EF4  ldr      w8, [x20, #0x18]
006874EF8  add      w21, w21, #1
006874EFC  cmp      w21, w8
006874F00  b.lt     #0x6874ed4
006874F04  ldp      x20, x19, [sp, #0x20]
006874F08  ldp      x22, x21, [sp, #0x10]
006874F0C  ldr      x30, [sp], #0x30
006874F10  ret      
006874F14  ldr      x3, [x2, #0x60]
006874F18  mov      x0, x20
006874F1C  mov      x1, x19
006874F20  ldp      x20, x19, [sp, #0x20]
006874F24  ldp      x22, x21, [sp, #0x10]
006874F28  ldr      x30, [sp], #0x30
006874F2C  br       x3
006874F30  bl       #0x382bfc0 ; 
006874F34  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.SinglePlayerSkillCreator$$InitRandoms
; RVA 0x6875D08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006875D08  stp      x29, x30, [sp, #-0x60]!
006875D0C  stp      x28, x27, [sp, #0x10]
006875D10  stp      x26, x25, [sp, #0x20]
006875D14  stp      x24, x23, [sp, #0x30]
006875D18  stp      x22, x21, [sp, #0x40]
006875D1C  stp      x20, x19, [sp, #0x50]
006875D20  adrp     x21, #0x959b000
006875D24  adrp     x23, #0x8f24000
006875D28  ldrb     w8, [x21, #0xab3]
006875D2C  ldr      x23, [x23, #0x520]
006875D30  mov      x20, x2
006875D34  mov      w22, w1
006875D38  mov      x19, x0
006875D3C  tbnz     w8, #0, #0x6875de4
006875D40  adrp     x0, #0x8ebf000
006875D44  ldr      x0, [x0, #0x4e8]
006875D48  bl       #0x382bd14 ; 
006875D4C  adrp     x0, #0x8f24000
006875D50  ldr      x0, [x0, #0x528]
006875D54  bl       #0x382bd14 ; 
006875D58  adrp     x0, #0x8f24000
006875D5C  ldr      x0, [x0, #0x530]
006875D60  bl       #0x382bd14 ; 
006875D64  adrp     x0, #0x8f23000
006875D68  ldr      x0, [x0, #0xdb0]
006875D6C  bl       #0x382bd14 ; 
006875D70  adrp     x0, #0x8f24000
006875D74  ldr      x0, [x0, #0x538]
006875D78  bl       #0x382bd14 ; 
006875D7C  adrp     x0, #0x8f24000
006875D80  ldr      x0, [x0, #0x540]
006875D84  bl       #0x382bd14 ; 
006875D88  adrp     x0, #0x8f23000
006875D8C  ldr      x0, [x0, #0xdb8]
006875D90  bl       #0x382bd14 ; 
006875D94  adrp     x0, #0x8f24000
006875D98  ldr      x0, [x0, #0x548]
006875D9C  bl       #0x382bd14 ; 
006875DA0  adrp     x0, #0x8f24000
006875DA4  ldr      x0, [x0, #0x550]
006875DA8  bl       #0x382bd14 ; 
006875DAC  adrp     x0, #0x8f24000
006875DB0  ldr      x0, [x0, #0x558]
006875DB4  bl       #0x382bd14 ; 
006875DB8  adrp     x0, #0x8f24000
006875DBC  ldr      x0, [x0, #0x560]
006875DC0  bl       #0x382bd14 ; 
006875DC4  adrp     x0, #0x8ebf000
006875DC8  ldr      x0, [x0, #0x4f0]
006875DCC  bl       #0x382bd14 ; 
006875DD0  adrp     x0, #0x8f24000
006875DD4  ldr      x0, [x0, #0x520]
006875DD8  bl       #0x382bd14 ; 
006875DDC  mov      w8, #1
006875DE0  strb     w8, [x21, #0xab3]
006875DE4  ldr      x3, [x23]
006875DE8  ldrb     w8, [x3, #0x53]
006875DEC  tbnz     w8, #5, #0x6875e70
006875DF0  cmp      w22, #8
006875DF4  adrp     x25, #0x9598000
006875DF8  b.hi     #0x68765f8
006875DFC  mov      w8, #1
006875E00  lsl      w8, w8, w22
006875E04  mov      w9, #0x190
006875E08  tst      w8, w9
006875E0C  b.eq     #0x68765f8
006875E10  mov      x0, x19
006875E14  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875E18  cbz      x0, #0x6876a64
006875E1C  mov      x1, xzr
006875E20  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
006875E24  tbz      w0, #0, #0x68765f8
006875E28  mov      x0, x19
006875E2C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875E30  cbz      x0, #0x6876a64
006875E34  ldrb     w8, [x25, #0xfcc]
006875E38  mov      x22, x0
006875E3C  cbnz     w8, #0x6875e54
006875E40  adrp     x0, #0x8f06000
006875E44  ldr      x0, [x0, #0x470]
006875E48  bl       #0x382bd14 ; 
006875E4C  mov      w8, #1
006875E50  strb     w8, [x25, #0xfcc]
006875E54  adrp     x8, #0x8f06000
006875E58  ldr      x8, [x8, #0x470]
006875E5C  ldr      x1, [x8]
006875E60  ldrb     w8, [x1, #0x53]
006875E64  tbnz     w8, #5, #0x6875e9c
006875E68  ldr      x0, [x22, #0x200]
006875E6C  b        #0x6875ea8 ; 
006875E70  ldr      x4, [x3, #0x60]
006875E74  mov      x0, x19
006875E78  mov      w1, w22
006875E7C  mov      x2, x20
006875E80  ldp      x20, x19, [sp, #0x50]
006875E84  ldp      x22, x21, [sp, #0x40]
006875E88  ldp      x24, x23, [sp, #0x30]
006875E8C  ldp      x26, x25, [sp, #0x20]
006875E90  ldp      x28, x27, [sp, #0x10]
006875E94  ldp      x29, x30, [sp], #0x60
006875E98  br       x4
006875E9C  ldr      x8, [x1, #0x60]
006875EA0  mov      x0, x22
006875EA4  blr      x8
006875EA8  cbz      x0, #0x6876a64
006875EAC  mov      x1, xzr
006875EB0  bl       #0x64d08d0 ; LocalModels.LocalModelManager$$GetSkillGroup_SurvivorGroupElements
006875EB4  cbz      x0, #0x6876a64
006875EB8  adrp     x10, #0x8f23000
006875EBC  ldr      x8, [x0]
006875EC0  ldr      x10, [x10, #0xdb0]
006875EC4  mov      x22, x0
006875EC8  ldrh     w9, [x8, #0x12e]
006875ECC  ldr      x1, [x10]
006875ED0  cbz      x9, #0x6875ef4
006875ED4  ldr      x10, [x8, #0xb0]
006875ED8  add      x10, x10, #8
006875EDC  ldur     x11, [x10, #-8]
006875EE0  cmp      x11, x1
006875EE4  b.eq     #0x6875f04
006875EE8  subs     x9, x9, #1
006875EEC  add      x10, x10, #0x10
006875EF0  b.ne     #0x6875edc
006875EF4  mov      x0, x22
006875EF8  mov      w2, wzr
006875EFC  bl       #0x3a7e710 ; 
006875F00  b        #0x6875f10 ; 
006875F04  ldrsw    x9, [x10]
006875F08  add      x8, x8, x9, lsl #4
006875F0C  add      x0, x8, #0x138
006875F10  ldp      x8, x1, [x0]
006875F14  mov      x0, x22
006875F18  blr      x8
006875F1C  mov      x22, x0
006875F20  cbz      x0, #0x6876a8c
006875F24  adrp     x21, #0x8ebf000
006875F28  adrp     x23, #0x8f23000
006875F2C  ldr      x21, [x21, #0x4f0]
006875F30  ldr      x23, [x23, #0xdb8]
006875F34  ldr      x8, [x22]
006875F38  ldr      x1, [x21]
006875F3C  ldrh     w9, [x8, #0x12e]
006875F40  cbz      x9, #0x6875f64
006875F44  ldr      x10, [x8, #0xb0]
006875F48  add      x10, x10, #8
006875F4C  ldur     x11, [x10, #-8]
006875F50  cmp      x11, x1
006875F54  b.eq     #0x6875f74
006875F58  subs     x9, x9, #1
006875F5C  add      x10, x10, #0x10
006875F60  b.ne     #0x6875f4c
006875F64  mov      x0, x22
006875F68  mov      w2, wzr
006875F6C  bl       #0x3a7e710 ; 
006875F70  b        #0x6875f80 ; 
006875F74  ldrsw    x9, [x10]
006875F78  add      x8, x8, x9, lsl #4
006875F7C  add      x0, x8, #0x138
006875F80  ldp      x8, x1, [x0]
006875F84  mov      x0, x22
006875F88  blr      x8
006875F8C  tbz      w0, #0, #0x6876000
006875F90  ldr      x8, [x22]
006875F94  ldr      x1, [x23]
006875F98  ldrh     w9, [x8, #0x12e]
006875F9C  cbz      x9, #0x6875fc0
006875FA0  ldr      x10, [x8, #0xb0]
006875FA4  add      x10, x10, #8
006875FA8  ldur     x11, [x10, #-8]
006875FAC  cmp      x11, x1
006875FB0  b.eq     #0x6875fd0
006875FB4  subs     x9, x9, #1
006875FB8  add      x10, x10, #0x10
006875FBC  b.ne     #0x6875fa8
006875FC0  mov      x0, x22
006875FC4  mov      w2, wzr
006875FC8  bl       #0x3a7e710 ; 
006875FCC  b        #0x6875fdc ; 
006875FD0  ldrsw    x9, [x10]
006875FD4  add      x8, x8, x9, lsl #4
006875FD8  add      x0, x8, #0x138
006875FDC  ldp      x8, x1, [x0]
006875FE0  mov      x0, x22
006875FE4  blr      x8
006875FE8  ldr      x1, [x19, #0x48]
006875FEC  mov      x2, x0
006875FF0  mov      x0, x19
006875FF4  mov      x3, x20
006875FF8  bl       #0x687260c ; HotFix.BattleLogic.HeroSkillCreator$$AddDankeSkillGroupToRandom
006875FFC  b        #0x6875f34 ; 
006876000  mov      x24, xzr
006876004  mov      w21, #6
006876008  cbz      x22, #0x687606c
00687600C  adrp     x10, #0x8ebf000
006876010  ldr      x8, [x22]
006876014  ldr      x10, [x10, #0x4e8]
006876018  ldrh     w9, [x8, #0x12e]
00687601C  ldr      x1, [x10]
006876020  cbz      x9, #0x6876044
006876024  ldr      x10, [x8, #0xb0]
006876028  add      x10, x10, #8
00687602C  ldur     x11, [x10, #-8]
006876030  cmp      x11, x1
006876034  b.eq     #0x6876054
006876038  subs     x9, x9, #1
00687603C  add      x10, x10, #0x10
006876040  b.ne     #0x687602c
006876044  mov      x0, x22
006876048  mov      w2, wzr
00687604C  bl       #0x3a7e710 ; 
006876050  b        #0x6876060 ; 
006876054  ldrsw    x9, [x10]
006876058  add      x8, x8, x9, lsl #4
00687605C  add      x0, x8, #0x138
006876060  ldp      x8, x1, [x0]
006876064  mov      x0, x22
006876068  blr      x8
00687606C  cbnz     x24, #0x6876a74
006876070  cmp      w21, #6
006876074  b.eq     #0x687607c
006876078  cbnz     w21, #0x6876a48
00687607C  mov      x0, x19
006876080  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006876084  cbz      x0, #0x6876a64
006876088  ldrb     w8, [x25, #0xfcc]
00687608C  mov      x22, x0
006876090  cbnz     w8, #0x68760a8
006876094  adrp     x0, #0x8f06000
006876098  ldr      x0, [x0, #0x470]
00687609C  bl       #0x382bd14 ; 
0068760A0  mov      w8, #1
0068760A4  strb     w8, [x25, #0xfcc]
0068760A8  adrp     x8, #0x8f06000
0068760AC  ldr      x8, [x8, #0x470]
0068760B0  ldr      x1, [x8]
0068760B4  ldrb     w8, [x1, #0x53]
0068760B8  tbnz     w8, #5, #0x68760c4
0068760BC  ldr      x0, [x22, #0x200]
0068760C0  b        #0x68760d0 ; 
0068760C4  ldr      x8, [x1, #0x60]
0068760C8  mov      x0, x22
0068760CC  blr      x8
0068760D0  cbz      x0, #0x6876a64
0068760D4  mov      x1, xzr
0068760D8  bl       #0x64d7434 ; LocalModels.LocalModelManager$$GetSkillGroup_InitSurvivorGroupElements
0068760DC  cbz      x0, #0x6876a64
0068760E0  adrp     x10, #0x8f24000
0068760E4  ldr      x8, [x0]
0068760E8  ldr      x10, [x10, #0x540]
0068760EC  mov      x22, x0
0068760F0  ldrh     w9, [x8, #0x12e]
0068760F4  ldr      x1, [x10]
0068760F8  cbz      x9, #0x687611c
0068760FC  ldr      x10, [x8, #0xb0]
006876100  add      x10, x10, #8
006876104  ldur     x11, [x10, #-8]
006876108  cmp      x11, x1
00687610C  b.eq     #0x687612c
006876110  subs     x9, x9, #1
006876114  add      x10, x10, #0x10
006876118  b.ne     #0x6876104
00687611C  mov      x0, x22
006876120  mov      w2, wzr
006876124  bl       #0x3a7e710 ; 
006876128  b        #0x6876138 ; 
00687612C  ldrsw    x9, [x10]
006876130  add      x8, x8, x9, lsl #4
006876134  add      x0, x8, #0x138
006876138  ldp      x8, x1, [x0]
00687613C  mov      x0, x22
006876140  blr      x8
006876144  mov      x22, x0
006876148  cbz      x0, #0x6876a90
00687614C  adrp     x21, #0x8ebf000
006876150  adrp     x23, #0x8f24000
006876154  ldr      x21, [x21, #0x4f0]
006876158  ldr      x23, [x23, #0x550]
00687615C  ldr      x8, [x22]
006876160  ldr      x1, [x21]
006876164  ldrh     w9, [x8, #0x12e]
006876168  cbz      x9, #0x687618c
00687616C  ldr      x10, [x8, #0xb0]
006876170  add      x10, x10, #8
006876174  ldur     x11, [x10, #-8]
006876178  cmp      x11, x1
00687617C  b.eq     #0x687619c
006876180  subs     x9, x9, #1
006876184  add      x10, x10, #0x10
006876188  b.ne     #0x6876174
00687618C  mov      x0, x22
006876190  mov      w2, wzr
006876194  bl       #0x3a7e710 ; 
006876198  b        #0x68761a8 ; 
00687619C  ldrsw    x9, [x10]
0068761A0  add      x8, x8, x9, lsl #4
0068761A4  add      x0, x8, #0x138
0068761A8  ldp      x8, x1, [x0]
0068761AC  mov      x0, x22
0068761B0  blr      x8
0068761B4  tbz      w0, #0, #0x6876228
0068761B8  ldr      x8, [x22]
0068761BC  ldr      x1, [x23]
0068761C0  ldrh     w9, [x8, #0x12e]
0068761C4  cbz      x9, #0x68761e8
0068761C8  ldr      x10, [x8, #0xb0]
0068761CC  add      x10, x10, #8
0068761D0  ldur     x11, [x10, #-8]
0068761D4  cmp      x11, x1
0068761D8  b.eq     #0x68761f8
0068761DC  subs     x9, x9, #1
0068761E0  add      x10, x10, #0x10
0068761E4  b.ne     #0x68761d0
0068761E8  mov      x0, x22
0068761EC  mov      w2, wzr
0068761F0  bl       #0x3a7e710 ; 
0068761F4  b        #0x6876204 ; 
0068761F8  ldrsw    x9, [x10]
0068761FC  add      x8, x8, x9, lsl #4
006876200  add      x0, x8, #0x138
006876204  ldp      x8, x1, [x0]
006876208  mov      x0, x22
00687620C  blr      x8
006876210  ldr      x1, [x19, #0x18]
006876214  mov      x2, x0
006876218  mov      x0, x19
00687621C  mov      x3, x20
006876220  bl       #0x687260c ; HotFix.BattleLogic.HeroSkillCreator$$AddDankeSkillGroupToRandom
006876224  b        #0x687615c ; 
006876228  mov      x24, xzr
00687622C  mov      w21, #9
006876230  cbz      x22, #0x6876294
006876234  adrp     x10, #0x8ebf000
006876238  ldr      x8, [x22]
00687623C  ldr      x10, [x10, #0x4e8]
006876240  ldrh     w9, [x8, #0x12e]
006876244  ldr      x1, [x10]
006876248  cbz      x9, #0x687626c
00687624C  ldr      x10, [x8, #0xb0]
006876250  add      x10, x10, #8
006876254  ldur     x11, [x10, #-8]
006876258  cmp      x11, x1
00687625C  b.eq     #0x687627c
006876260  subs     x9, x9, #1
006876264  add      x10, x10, #0x10
006876268  b.ne     #0x6876254
00687626C  mov      x0, x22
006876270  mov      w2, wzr
006876274  bl       #0x3a7e710 ; 
006876278  b        #0x6876288 ; 
00687627C  ldrsw    x9, [x10]
006876280  add      x8, x8, x9, lsl #4
006876284  add      x0, x8, #0x138
006876288  ldp      x8, x1, [x0]
00687628C  mov      x0, x22
006876290  blr      x8
006876294  cbnz     x24, #0x6876a74
006876298  cmp      w21, #9
00687629C  b.eq     #0x68762a4
0068762A0  cbnz     w21, #0x6876a48
0068762A4  mov      x0, x19
0068762A8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068762AC  cbz      x0, #0x6876a64
0068762B0  ldrb     w8, [x25, #0xfcc]
0068762B4  mov      x22, x0
0068762B8  cbnz     w8, #0x68762d0
0068762BC  adrp     x0, #0x8f06000
0068762C0  ldr      x0, [x0, #0x470]
0068762C4  bl       #0x382bd14 ; 
0068762C8  mov      w8, #1
0068762CC  strb     w8, [x25, #0xfcc]
0068762D0  adrp     x8, #0x8f06000
0068762D4  ldr      x8, [x8, #0x470]
0068762D8  ldr      x1, [x8]
0068762DC  ldrb     w8, [x1, #0x53]
0068762E0  tbnz     w8, #5, #0x68762ec
0068762E4  ldr      x0, [x22, #0x200]
0068762E8  b        #0x68762f8 ; 
0068762EC  ldr      x8, [x1, #0x60]
0068762F0  mov      x0, x22
0068762F4  blr      x8
0068762F8  cbz      x0, #0x6876a64
0068762FC  mov      x1, xzr
006876300  bl       #0x64e24ec ; LocalModels.LocalModelManager$$GetSkillGroup_InfinateSkillGroupElements
006876304  cbz      x0, #0x6876a64
006876308  adrp     x10, #0x8f24000
00687630C  ldr      x8, [x0]
006876310  ldr      x10, [x10, #0x530]
006876314  mov      x22, x0
006876318  ldrh     w9, [x8, #0x12e]
00687631C  ldr      x1, [x10]
006876320  cbz      x9, #0x6876344
006876324  ldr      x10, [x8, #0xb0]
006876328  add      x10, x10, #8
00687632C  ldur     x11, [x10, #-8]
006876330  cmp      x11, x1
006876334  b.eq     #0x6876354
006876338  subs     x9, x9, #1
00687633C  add      x10, x10, #0x10
006876340  b.ne     #0x687632c
006876344  mov      x0, x22
006876348  mov      w2, wzr
00687634C  bl       #0x3a7e710 ; 
006876350  b        #0x6876360 ; 
006876354  ldrsw    x9, [x10]
006876358  add      x8, x8, x9, lsl #4
00687635C  add      x0, x8, #0x138
006876360  ldp      x8, x1, [x0]
006876364  mov      x0, x22
006876368  mov      x24, x25
00687636C  blr      x8
006876370  mov      x22, x0
006876374  cbz      x0, #0x6876a94
006876378  adrp     x29, #0x8ebf000
00687637C  adrp     x21, #0x8f24000
006876380  adrp     x23, #0x8f24000
006876384  ldr      x29, [x29, #0x4f0]
006876388  ldr      x21, [x21, #0x560]
00687638C  ldr      x23, [x23, #0x568]
006876390  adrp     x28, #0x959b000
006876394  ldr      x8, [x22]
006876398  ldr      x1, [x29]
00687639C  ldrh     w9, [x8, #0x12e]
0068763A0  cbz      x9, #0x68763c4
0068763A4  ldr      x10, [x8, #0xb0]
0068763A8  add      x10, x10, #8
0068763AC  ldur     x11, [x10, #-8]
0068763B0  cmp      x11, x1
0068763B4  b.eq     #0x68763d4
0068763B8  subs     x9, x9, #1
0068763BC  add      x10, x10, #0x10
0068763C0  b.ne     #0x68763ac
0068763C4  mov      x0, x22
0068763C8  mov      w2, wzr
0068763CC  bl       #0x3a7e710 ; 
0068763D0  b        #0x68763e0 ; 
0068763D4  ldrsw    x9, [x10]
0068763D8  add      x8, x8, x9, lsl #4
0068763DC  add      x0, x8, #0x138
0068763E0  ldp      x8, x1, [x0]
0068763E4  mov      x0, x22
0068763E8  blr      x8
0068763EC  tbz      w0, #0, #0x6876580
0068763F0  ldr      x8, [x22]
0068763F4  ldr      x1, [x21]
0068763F8  ldrh     w9, [x8, #0x12e]
0068763FC  cbz      x9, #0x6876420
006876400  ldr      x10, [x8, #0xb0]
006876404  add      x10, x10, #8
006876408  ldur     x11, [x10, #-8]
00687640C  cmp      x11, x1
006876410  b.eq     #0x6876430
006876414  subs     x9, x9, #1
006876418  add      x10, x10, #0x10
00687641C  b.ne     #0x6876408
006876420  mov      x0, x22
006876424  mov      w2, wzr
006876428  bl       #0x3a7e710 ; 
00687642C  b        #0x687643c ; 
006876430  ldrsw    x9, [x10]
006876434  add      x8, x8, x9, lsl #4
006876438  add      x0, x8, #0x138
00687643C  ldp      x8, x1, [x0]
006876440  mov      x0, x22
006876444  blr      x8
006876448  mov      x25, x0
00687644C  cbz      x0, #0x6876a68
006876450  ldrb     w8, [x28, #0xbb8]
006876454  cbnz     w8, #0x6876468
006876458  mov      x0, x23
00687645C  bl       #0x382bd14 ; 
006876460  mov      w8, #1
006876464  strb     w8, [x28, #0xbb8]
006876468  ldr      x1, [x23]
00687646C  ldrb     w8, [x1, #0x53]
006876470  tbnz     w8, #5, #0x6876480
006876474  ldr      w26, [x25, #0x24]
006876478  cbnz     x20, #0x6876494
00687647C  b        #0x68764a4 ; 
006876480  ldr      x8, [x1, #0x60]
006876484  mov      x0, x25
006876488  blr      x8
00687648C  mov      w26, w0
006876490  cbz      x20, #0x68764a4
006876494  mov      x0, x20
006876498  mov      w1, w26
00687649C  bl       #0x685b6b8 ; HotFix.BattleLogic.HeroSkillCreator$$IsContain
0068764A0  tbnz     w0, #0, #0x6876394
0068764A4  mov      x0, x19
0068764A8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068764AC  mov      x27, x0
0068764B0  cbz      x0, #0x6876a6c
0068764B4  ldrb     w8, [x24, #0xfcc]
0068764B8  cbnz     w8, #0x68764d0
0068764BC  adrp     x0, #0x8f06000
0068764C0  ldr      x0, [x0, #0x470]
0068764C4  bl       #0x382bd14 ; 
0068764C8  mov      w8, #1
0068764CC  strb     w8, [x24, #0xfcc]
0068764D0  adrp     x8, #0x8f06000
0068764D4  ldr      x8, [x8, #0x470]
0068764D8  ldr      x1, [x8]
0068764DC  ldrb     w8, [x1, #0x53]
0068764E0  tbnz     w8, #5, #0x68764ec
0068764E4  ldr      x0, [x27, #0x200]
0068764E8  b        #0x68764f8 ; 
0068764EC  ldr      x8, [x1, #0x60]
0068764F0  mov      x0, x27
0068764F4  blr      x8
0068764F8  cbz      x0, #0x6876a70
0068764FC  mov      w1, w26
006876500  mov      x2, xzr
006876504  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006876508  adrp     x8, #0x959b000
00687650C  ldrb     w8, [x8, #0xbb9]
006876510  ldr      x27, [x19, #0x40]
006876514  cbnz     w8, #0x6876530
006876518  adrp     x0, #0x8f24000
00687651C  ldr      x0, [x0, #0x570]
006876520  bl       #0x382bd14 ; 
006876524  mov      w8, #1
006876528  adrp     x9, #0x959b000
00687652C  strb     w8, [x9, #0xbb9]
006876530  adrp     x8, #0x8f24000
006876534  ldr      x8, [x8, #0x570]
006876538  ldr      x1, [x8]
00687653C  ldrb     w8, [x1, #0x53]
006876540  tbnz     w8, #5, #0x687654c
006876544  ldr      w3, [x25, #0x28]
006876548  b        #0x687655c ; 
00687654C  ldr      x8, [x1, #0x60]
006876550  mov      x0, x25
006876554  blr      x8
006876558  mov      w3, w0
00687655C  ldr      x8, [x19]
006876560  ldr      x9, [x8, #0x228]
006876564  ldr      x5, [x8, #0x230]
006876568  mov      x0, x19
00687656C  mov      x1, x27
006876570  mov      w2, w26
006876574  mov      x4, xzr
006876578  blr      x9
00687657C  b        #0x6876394 ; 
006876580  mov      x26, xzr
006876584  mov      w21, wzr
006876588  mov      x25, x24
00687658C  cbz      x22, #0x68765f0
006876590  adrp     x10, #0x8ebf000
006876594  ldr      x8, [x22]
006876598  ldr      x10, [x10, #0x4e8]
00687659C  ldrh     w9, [x8, #0x12e]
0068765A0  ldr      x1, [x10]
0068765A4  cbz      x9, #0x68765c8
0068765A8  ldr      x10, [x8, #0xb0]
0068765AC  add      x10, x10, #8
0068765B0  ldur     x11, [x10, #-8]
0068765B4  cmp      x11, x1
0068765B8  b.eq     #0x68765d8
0068765BC  subs     x9, x9, #1
0068765C0  add      x10, x10, #0x10
0068765C4  b.ne     #0x68765b0
0068765C8  mov      x0, x22
0068765CC  mov      w2, wzr
0068765D0  bl       #0x3a7e710 ; 
0068765D4  b        #0x68765e4 ; 
0068765D8  ldrsw    x9, [x10]
0068765DC  add      x8, x8, x9, lsl #4
0068765E0  add      x0, x8, #0x138
0068765E4  ldp      x8, x1, [x0]
0068765E8  mov      x0, x22
0068765EC  blr      x8
0068765F0  cbnz     x26, #0x6876a98
0068765F4  cbz      w21, #0x6876a48
0068765F8  mov      x0, x19
0068765FC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006876600  cbz      x0, #0x6876a64
006876604  ldrb     w8, [x25, #0xfcc]
006876608  mov      x22, x0
00687660C  cbnz     w8, #0x6876624
006876610  adrp     x0, #0x8f06000
006876614  ldr      x0, [x0, #0x470]
006876618  bl       #0x382bd14 ; 
00687661C  mov      w8, #1
006876620  strb     w8, [x25, #0xfcc]
006876624  adrp     x8, #0x8f06000
006876628  ldr      x8, [x8, #0x470]
00687662C  ldr      x1, [x8]
006876630  ldrb     w8, [x1, #0x53]
006876634  tbnz     w8, #5, #0x6876640
006876638  ldr      x0, [x22, #0x200]
00687663C  b        #0x687664c ; 
006876640  ldr      x8, [x1, #0x60]
006876644  mov      x0, x22
006876648  blr      x8
00687664C  cbz      x0, #0x6876a64
006876650  mov      x1, xzr
006876654  bl       #0x64d22a4 ; LocalModels.LocalModelManager$$GetSkillGroup_BaseGroupElements
006876658  cbz      x0, #0x6876a64
00687665C  adrp     x10, #0x8f24000
006876660  ldr      x8, [x0]
006876664  ldr      x10, [x10, #0x538]
006876668  mov      x22, x0
00687666C  ldrh     w9, [x8, #0x12e]
006876670  ldr      x1, [x10]
006876674  cbz      x9, #0x6876698
006876678  ldr      x10, [x8, #0xb0]
00687667C  add      x10, x10, #8
006876680  ldur     x11, [x10, #-8]
006876684  cmp      x11, x1
006876688  b.eq     #0x68766a8
00687668C  subs     x9, x9, #1
006876690  add      x10, x10, #0x10
006876694  b.ne     #0x6876680
006876698  mov      x0, x22
00687669C  mov      w2, wzr
0068766A0  bl       #0x3a7e710 ; 
0068766A4  b        #0x68766b4 ; 
0068766A8  ldrsw    x9, [x10]
0068766AC  add      x8, x8, x9, lsl #4
0068766B0  add      x0, x8, #0x138
0068766B4  ldp      x8, x1, [x0]
0068766B8  mov      x0, x22
0068766BC  blr      x8
0068766C0  mov      x22, x0
0068766C4  cbz      x0, #0x6876a7c
0068766C8  adrp     x21, #0x8ebf000
0068766CC  adrp     x23, #0x8f24000
0068766D0  ldr      x21, [x21, #0x4f0]
0068766D4  ldr      x23, [x23, #0x558]
0068766D8  ldr      x8, [x22]
0068766DC  ldr      x1, [x21]
0068766E0  ldrh     w9, [x8, #0x12e]
0068766E4  cbz      x9, #0x6876708
0068766E8  ldr      x10, [x8, #0xb0]
0068766EC  add      x10, x10, #8
0068766F0  ldur     x11, [x10, #-8]
0068766F4  cmp      x11, x1
0068766F8  b.eq     #0x6876718
0068766FC  subs     x9, x9, #1
006876700  add      x10, x10, #0x10
006876704  b.ne     #0x68766f0
006876708  mov      x0, x22
00687670C  mov      w2, wzr
006876710  bl       #0x3a7e710 ; 
006876714  b        #0x6876724 ; 
006876718  ldrsw    x9, [x10]
00687671C  add      x8, x8, x9, lsl #4
006876720  add      x0, x8, #0x138
006876724  ldp      x8, x1, [x0]
006876728  mov      x0, x22
00687672C  blr      x8
006876730  tbz      w0, #0, #0x68767a4
006876734  ldr      x8, [x22]
006876738  ldr      x1, [x23]
00687673C  ldrh     w9, [x8, #0x12e]
006876740  cbz      x9, #0x6876764
006876744  ldr      x10, [x8, #0xb0]
006876748  add      x10, x10, #8
00687674C  ldur     x11, [x10, #-8]
006876750  cmp      x11, x1
006876754  b.eq     #0x6876774
006876758  subs     x9, x9, #1
00687675C  add      x10, x10, #0x10
006876760  b.ne     #0x687674c
006876764  mov      x0, x22
006876768  mov      w2, wzr
00687676C  bl       #0x3a7e710 ; 
006876770  b        #0x6876780 ; 
006876774  ldrsw    x9, [x10]
006876778  add      x8, x8, x9, lsl #4
00687677C  add      x0, x8, #0x138
006876780  ldp      x8, x1, [x0]
006876784  mov      x0, x22
006876788  blr      x8
00687678C  ldr      x1, [x19, #0x48]
006876790  mov      x2, x0
006876794  mov      x0, x19
006876798  mov      x3, x20
00687679C  bl       #0x6872370 ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToNormalRandom
0068767A0  b        #0x68766d8 ; 
0068767A4  mov      x24, xzr
0068767A8  cbz      x22, #0x687680c
0068767AC  adrp     x10, #0x8ebf000
0068767B0  ldr      x8, [x22]
0068767B4  ldr      x10, [x10, #0x4e8]
0068767B8  ldrh     w9, [x8, #0x12e]
0068767BC  ldr      x1, [x10]
0068767C0  cbz      x9, #0x68767e4
0068767C4  ldr      x10, [x8, #0xb0]
0068767C8  add      x10, x10, #8
0068767CC  ldur     x11, [x10, #-8]
0068767D0  cmp      x11, x1
0068767D4  b.eq     #0x68767f4
0068767D8  subs     x9, x9, #1
0068767DC  add      x10, x10, #0x10
0068767E0  b.ne     #0x68767cc
0068767E4  mov      x0, x22
0068767E8  mov      w2, wzr
0068767EC  bl       #0x3a7e710 ; 
0068767F0  b        #0x6876800 ; 
0068767F4  ldrsw    x9, [x10]
0068767F8  add      x8, x8, x9, lsl #4
0068767FC  add      x0, x8, #0x138
006876800  ldp      x8, x1, [x0]
006876804  mov      x0, x22
006876808  blr      x8
00687680C  cbnz     x24, #0x6876a74
006876810  ldr      x8, [x19, #0x48]
006876814  cbz      x8, #0x6876a64
006876818  mov      x0, x19
00687681C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006876820  cbz      x0, #0x6876a64
006876824  ldrb     w8, [x25, #0xfcc]
006876828  mov      x22, x0
00687682C  cbnz     w8, #0x6876844
006876830  adrp     x0, #0x8f06000
006876834  ldr      x0, [x0, #0x470]
006876838  bl       #0x382bd14 ; 
00687683C  mov      w8, #1
006876840  strb     w8, [x25, #0xfcc]
006876844  adrp     x8, #0x8f06000
006876848  ldr      x8, [x8, #0x470]
00687684C  ldr      x1, [x8]
006876850  ldrb     w8, [x1, #0x53]
006876854  tbnz     w8, #5, #0x6876860
006876858  ldr      x0, [x22, #0x200]
00687685C  b        #0x687686c ; 
006876860  ldr      x8, [x1, #0x60]
006876864  mov      x0, x22
006876868  blr      x8
00687686C  cbz      x0, #0x6876a64
006876870  mov      x1, xzr
006876874  bl       #0x64d3c78 ; LocalModels.LocalModelManager$$GetSkillGroup_InitBaseGroupElements
006876878  cbz      x0, #0x6876a64
00687687C  adrp     x10, #0x8f24000
006876880  ldr      x8, [x0]
006876884  ldr      x10, [x10, #0x528]
006876888  mov      x21, x0
00687688C  ldrh     w9, [x8, #0x12e]
006876890  ldr      x1, [x10]
006876894  cbz      x9, #0x68768b8
006876898  ldr      x10, [x8, #0xb0]
00687689C  add      x10, x10, #8
0068768A0  ldur     x11, [x10, #-8]
0068768A4  cmp      x11, x1
0068768A8  b.eq     #0x68768c8
0068768AC  subs     x9, x9, #1
0068768B0  add      x10, x10, #0x10
0068768B4  b.ne     #0x68768a0
0068768B8  mov      x0, x21
0068768BC  mov      w2, wzr
0068768C0  bl       #0x3a7e710 ; 
0068768C4  b        #0x68768d4 ; 
0068768C8  ldrsw    x9, [x10]
0068768CC  add      x8, x8, x9, lsl #4
0068768D0  add      x0, x8, #0x138
0068768D4  ldp      x8, x1, [x0]
0068768D8  mov      x0, x21
0068768DC  blr      x8
0068768E0  mov      x21, x0
0068768E4  cbz      x0, #0x6876a80
0068768E8  adrp     x22, #0x8ebf000
0068768EC  adrp     x23, #0x8f24000
0068768F0  ldr      x22, [x22, #0x4f0]
0068768F4  ldr      x23, [x23, #0x548]
0068768F8  ldr      x8, [x21]
0068768FC  ldr      x1, [x22]
006876900  ldrh     w9, [x8, #0x12e]
006876904  cbz      x9, #0x6876928
006876908  ldr      x10, [x8, #0xb0]
00687690C  add      x10, x10, #8
006876910  ldur     x11, [x10, #-8]
006876914  cmp      x11, x1
006876918  b.eq     #0x6876938
00687691C  subs     x9, x9, #1
006876920  add      x10, x10, #0x10
006876924  b.ne     #0x6876910
006876928  mov      x0, x21
00687692C  mov      w2, wzr
006876930  bl       #0x3a7e710 ; 
006876934  b        #0x6876944 ; 
006876938  ldrsw    x9, [x10]
00687693C  add      x8, x8, x9, lsl #4
006876940  add      x0, x8, #0x138
006876944  ldp      x8, x1, [x0]
006876948  mov      x0, x21
00687694C  blr      x8
006876950  tbz      w0, #0, #0x68769c4
006876954  ldr      x8, [x21]
006876958  ldr      x1, [x23]
00687695C  ldrh     w9, [x8, #0x12e]
006876960  cbz      x9, #0x6876984
006876964  ldr      x10, [x8, #0xb0]
006876968  add      x10, x10, #8
00687696C  ldur     x11, [x10, #-8]
006876970  cmp      x11, x1
006876974  b.eq     #0x6876994
006876978  subs     x9, x9, #1
00687697C  add      x10, x10, #0x10
006876980  b.ne     #0x687696c
006876984  mov      x0, x21
006876988  mov      w2, wzr
00687698C  bl       #0x3a7e710 ; 
006876990  b        #0x68769a0 ; 
006876994  ldrsw    x9, [x10]
006876998  add      x8, x8, x9, lsl #4
00687699C  add      x0, x8, #0x138
0068769A0  ldp      x8, x1, [x0]
0068769A4  mov      x0, x21
0068769A8  blr      x8
0068769AC  ldr      x1, [x19, #0x18]
0068769B0  mov      x2, x0
0068769B4  mov      x0, x19
0068769B8  mov      x3, x20
0068769BC  bl       #0x6872370 ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToNormalRandom
0068769C0  b        #0x68768f8 ; 
0068769C4  mov      x20, xzr
0068769C8  mov      w22, #0x15
0068769CC  cbz      x21, #0x6876a30
0068769D0  adrp     x10, #0x8ebf000
0068769D4  ldr      x8, [x21]
0068769D8  ldr      x10, [x10, #0x4e8]
0068769DC  ldrh     w9, [x8, #0x12e]
0068769E0  ldr      x1, [x10]
0068769E4  cbz      x9, #0x6876a08
0068769E8  ldr      x10, [x8, #0xb0]
0068769EC  add      x10, x10, #8
0068769F0  ldur     x11, [x10, #-8]
0068769F4  cmp      x11, x1
0068769F8  b.eq     #0x6876a18
0068769FC  subs     x9, x9, #1
006876A00  add      x10, x10, #0x10
006876A04  b.ne     #0x68769f0
006876A08  mov      x0, x21
006876A0C  mov      w2, wzr
006876A10  bl       #0x3a7e710 ; 
006876A14  b        #0x6876a24 ; 
006876A18  ldrsw    x9, [x10]
006876A1C  add      x8, x8, x9, lsl #4
006876A20  add      x0, x8, #0x138
006876A24  ldp      x8, x1, [x0]
006876A28  mov      x0, x21
006876A2C  blr      x8
006876A30  cbnz     x20, #0x6876a84
006876A34  cmp      w22, #0x15
006876A38  b.eq     #0x6876a40
006876A3C  cbnz     w22, #0x6876a48
006876A40  ldr      x8, [x19, #0x18]
006876A44  cbz      x8, #0x6876a64
006876A48  ldp      x20, x19, [sp, #0x50]
006876A4C  ldp      x22, x21, [sp, #0x40]
006876A50  ldp      x24, x23, [sp, #0x30]
006876A54  ldp      x26, x25, [sp, #0x20]
006876A58  ldp      x28, x27, [sp, #0x10]
006876A5C  ldp      x29, x30, [sp], #0x60
006876A60  ret      
006876A64  bl       #0x382bfb8 ; 
006876A68  bl       #0x382bfb8 ; 
006876A6C  bl       #0x382bfb8 ; 
006876A70  bl       #0x382bfb8 ; 
006876A74  mov      x0, x24
006876A78  bl       #0x382bfb0 ; 
006876A7C  bl       #0x382bfb8 ; 
006876A80  bl       #0x382bfb8 ; 
006876A84  mov      x0, x20
006876A88  bl       #0x382bfb0 ; 
006876A8C  bl       #0x382bfb8 ; 
006876A90  bl       #0x382bfb8 ; 
006876A94  bl       #0x382bfb8 ; 
006876A98  mov      x0, x26
006876A9C  bl       #0x382bfb0 ; 
006876AA0  b        #0x6876ae0 ; 
006876AA4  b        #0x6876b88 ; 
006876AA8  b        #0x6876c30 ; 
006876AAC  b        #0x6876ce4 ; 
006876AB0  b        #0x6876d88 ; 
006876AB4  b        #0x6876ae0 ; 
006876AB8  b        #0x6876ae0 ; 
006876ABC  b        #0x6876ae0 ; 
006876AC0  b        #0x6876ae0 ; 
006876AC4  b        #0x6876ae0 ; 
006876AC8  b        #0x6876ae0 ; 
006876ACC  b        #0x6876ae0 ; 
006876AD0  b        #0x6876ae0 ; 
006876AD4  b        #0x6876ae0 ; 
006876AD8  b        #0x6876b88 ; 
006876ADC  b        #0x6876ae0 ; 
006876AE0  mov      x23, x0
006876AE4  cmp      w1, #1
006876AE8  b.ne     #0x6876b04
006876AEC  mov      x0, x23
006876AF0  bl       #0x89eda50 ; 
006876AF4  ldr      x26, [x0]
006876AF8  bl       #0x89eda60 ; 
006876AFC  mov      w21, #1
006876B00  b        #0x6876588 ; 
006876B04  mov      x26, xzr
006876B08  b        #0x6876b10 ; 
006876B0C  mov      x23, x0
006876B10  cbz      x22, #0x6876b74
006876B14  adrp     x10, #0x8ebf000
006876B18  ldr      x8, [x22]
006876B1C  ldr      x10, [x10, #0x4e8]
006876B20  ldrh     w9, [x8, #0x12e]
006876B24  ldr      x1, [x10]
006876B28  cbz      x9, #0x6876b4c
006876B2C  ldr      x10, [x8, #0xb0]
006876B30  add      x10, x10, #8
006876B34  ldur     x11, [x10, #-8]
006876B38  cmp      x11, x1
006876B3C  b.eq     #0x6876b5c
006876B40  subs     x9, x9, #1
006876B44  add      x10, x10, #0x10
006876B48  b.ne     #0x6876b34
006876B4C  mov      x0, x22
006876B50  mov      w2, wzr
006876B54  bl       #0x3a7e710 ; 
006876B58  b        #0x6876b68 ; 
006876B5C  ldrsw    x9, [x10]
006876B60  add      x8, x8, x9, lsl #4
006876B64  add      x0, x8, #0x138
006876B68  ldp      x8, x1, [x0]
006876B6C  mov      x0, x22
006876B70  blr      x8
006876B74  cbz      x26, #0x6876e1c
006876B78  mov      x0, x26
006876B7C  bl       #0x382bfb0 ; 
006876B80  b        #0x6876c30 ; 
006876B84  b        #0x6876b88 ; 
006876B88  mov      x23, x0
006876B8C  cmp      w1, #1
006876B90  b.ne     #0x6876bb0
006876B94  mov      x0, x23
006876B98  bl       #0x89eda50 ; 
006876B9C  ldr      x24, [x0]
006876BA0  bl       #0x89eda60 ; 
006876BA4  mov      w21, wzr
006876BA8  cbnz     x22, #0x6876234
006876BAC  b        #0x6876294 ; 
006876BB0  mov      x24, xzr
006876BB4  b        #0x6876bbc ; 
006876BB8  mov      x23, x0
006876BBC  cbz      x22, #0x6876c20
006876BC0  adrp     x10, #0x8ebf000
006876BC4  ldr      x8, [x22]
006876BC8  ldr      x10, [x10, #0x4e8]
006876BCC  ldrh     w9, [x8, #0x12e]
006876BD0  ldr      x1, [x10]
006876BD4  cbz      x9, #0x6876bf8
006876BD8  ldr      x10, [x8, #0xb0]
006876BDC  add      x10, x10, #8
006876BE0  ldur     x11, [x10, #-8]
006876BE4  cmp      x11, x1
006876BE8  b.eq     #0x6876c08
006876BEC  subs     x9, x9, #1
006876BF0  add      x10, x10, #0x10
006876BF4  b.ne     #0x6876be0
006876BF8  mov      x0, x22
006876BFC  mov      w2, wzr
006876C00  bl       #0x3a7e710 ; 
006876C04  b        #0x6876c14 ; 
006876C08  ldrsw    x9, [x10]
006876C0C  add      x8, x8, x9, lsl #4
006876C10  add      x0, x8, #0x138
006876C14  ldp      x8, x1, [x0]
006876C18  mov      x0, x22
006876C1C  blr      x8
006876C20  cbz      x24, #0x6876e1c
006876C24  mov      x0, x24
006876C28  bl       #0x382bfb0 ; 
006876C2C  b        #0x6876c30 ; 
006876C30  mov      x23, x0
006876C34  cmp      w1, #1
006876C38  b.ne     #0x6876c58
006876C3C  mov      x0, x23
006876C40  bl       #0x89eda50 ; 
006876C44  ldr      x24, [x0]
006876C48  bl       #0x89eda60 ; 
006876C4C  mov      w21, wzr
006876C50  cbnz     x22, #0x687600c
006876C54  b        #0x687606c ; 
006876C58  mov      x24, xzr
006876C5C  b        #0x6876c64 ; 
006876C60  mov      x23, x0
006876C64  cbz      x22, #0x6876cc8
006876C68  adrp     x10, #0x8ebf000
006876C6C  ldr      x8, [x22]
006876C70  ldr      x10, [x10, #0x4e8]
006876C74  ldrh     w9, [x8, #0x12e]
006876C78  ldr      x1, [x10]
006876C7C  cbz      x9, #0x6876ca0
006876C80  ldr      x10, [x8, #0xb0]
006876C84  add      x10, x10, #8
006876C88  ldur     x11, [x10, #-8]
006876C8C  cmp      x11, x1
006876C90  b.eq     #0x6876cb0
006876C94  subs     x9, x9, #1
006876C98  add      x10, x10, #0x10
006876C9C  b.ne     #0x6876c88
006876CA0  mov      x0, x22
006876CA4  mov      w2, wzr
006876CA8  bl       #0x3a7e710 ; 
006876CAC  b        #0x6876cbc ; 
006876CB0  ldrsw    x9, [x10]
006876CB4  add      x8, x8, x9, lsl #4
006876CB8  add      x0, x8, #0x138
006876CBC  ldp      x8, x1, [x0]
006876CC0  mov      x0, x22
006876CC4  blr      x8
006876CC8  cbz      x24, #0x6876e1c
006876CCC  mov      x0, x24
006876CD0  bl       #0x382bfb0 ; 
006876CD4  b        #0x6876ce4 ; 
006876CD8  b        #0x6876d88 ; 
006876CDC  b        #0x6876ce4 ; 
006876CE0  b        #0x6876d88 ; 
006876CE4  mov      x23, x0
006876CE8  cmp      w1, #1
006876CEC  b.ne     #0x6876d0c
006876CF0  mov      x0, x23
006876CF4  bl       #0x89eda50 ; 
006876CF8  ldr      x20, [x0]
006876CFC  bl       #0x89eda60 ; 
006876D00  mov      w22, wzr
006876D04  cbnz     x21, #0x68769d0
006876D08  b        #0x6876a30 ; 
006876D0C  mov      x20, xzr
006876D10  b        #0x6876d18 ; 
006876D14  mov      x23, x0
006876D18  cbz      x21, #0x6876d7c
006876D1C  adrp     x10, #0x8ebf000
006876D20  ldr      x8, [x21]
006876D24  ldr      x10, [x10, #0x4e8]
006876D28  ldrh     w9, [x8, #0x12e]
006876D2C  ldr      x1, [x10]
006876D30  cbz      x9, #0x6876d54
006876D34  ldr      x10, [x8, #0xb0]
006876D38  add      x10, x10, #8
006876D3C  ldur     x11, [x10, #-8]
006876D40  cmp      x11, x1
006876D44  b.eq     #0x6876d64
006876D48  subs     x9, x9, #1
006876D4C  add      x10, x10, #0x10
006876D50  b.ne     #0x6876d3c
006876D54  mov      x0, x21
006876D58  mov      w2, wzr
006876D5C  bl       #0x3a7e710 ; 
006876D60  b        #0x6876d70 ; 
006876D64  ldrsw    x9, [x10]
006876D68  add      x8, x8, x9, lsl #4
006876D6C  add      x0, x8, #0x138
006876D70  ldp      x8, x1, [x0]
006876D74  mov      x0, x21
006876D78  blr      x8
006876D7C  cbz      x20, #0x6876e1c
006876D80  mov      x0, x20
006876D84  bl       #0x382bfb0 ; 
006876D88  mov      x23, x0
006876D8C  cmp      w1, #1
006876D90  b.ne     #0x6876da8
006876D94  mov      x0, x23
006876D98  bl       #0x89eda50 ; 
006876D9C  ldr      x24, [x0]
006876DA0  bl       #0x89eda60 ; 
006876DA4  b        #0x68767a8 ; 
006876DA8  mov      x24, xzr
006876DAC  b        #0x6876db4 ; 
006876DB0  mov      x23, x0
006876DB4  cbz      x22, #0x6876e18
006876DB8  adrp     x10, #0x8ebf000
006876DBC  ldr      x8, [x22]
006876DC0  ldr      x10, [x10, #0x4e8]
006876DC4  ldrh     w9, [x8, #0x12e]
006876DC8  ldr      x1, [x10]
006876DCC  cbz      x9, #0x6876df0
006876DD0  ldr      x10, [x8, #0xb0]
006876DD4  add      x10, x10, #8
006876DD8  ldur     x11, [x10, #-8]
006876DDC  cmp      x11, x1
006876DE0  b.eq     #0x6876e00
006876DE4  subs     x9, x9, #1
006876DE8  add      x10, x10, #0x10
006876DEC  b.ne     #0x6876dd8
006876DF0  mov      x0, x22
006876DF4  mov      w2, wzr
006876DF8  bl       #0x3a7e710 ; 
006876DFC  b        #0x6876e0c ; 
006876E00  ldrsw    x9, [x10]
006876E04  add      x8, x8, x9, lsl #4
006876E08  add      x0, x8, #0x138
006876E0C  ldp      x8, x1, [x0]
006876E10  mov      x0, x22
006876E14  blr      x8
006876E18  cbnz     x24, #0x6876e24
006876E1C  mov      x0, x23
006876E20  bl       #0x3b56bfc ; 
006876E24  mov      x0, x24
006876E28  bl       #0x382bfb0 ; 
006876E2C  bl       #0x3442448 ; 

; HotFix.BattleLogic.SinglePlayerSkillCreator$$GetInginiteSkill
; RVA 0x68606EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068606EC  stp      x30, x27, [sp, #-0x50]!
0068606F0  stp      x26, x25, [sp, #0x10]
0068606F4  stp      x24, x23, [sp, #0x20]
0068606F8  stp      x22, x21, [sp, #0x30]
0068606FC  stp      x20, x19, [sp, #0x40]
006860700  adrp     x23, #0x959b000
006860704  adrp     x24, #0x8f23000
006860708  ldrb     w8, [x23, #0xab4]
00686070C  ldr      x24, [x24, #0xc68]
006860710  mov      w19, w3
006860714  mov      x20, x2
006860718  mov      x22, x1
00686071C  mov      x21, x0
006860720  tbnz     w8, #0, #0x6860780
006860724  adrp     x0, #0x8ec2000
006860728  ldr      x0, [x0, #0x260]
00686072C  bl       #0x382bd14 ; 
006860730  adrp     x0, #0x8ec2000
006860734  ldr      x0, [x0, #0x240]
006860738  bl       #0x382bd14 ; 
00686073C  adrp     x0, #0x8ec2000
006860740  ldr      x0, [x0, #0x268]
006860744  bl       #0x382bd14 ; 
006860748  adrp     x0, #0x8ec2000
00686074C  ldr      x0, [x0, #0x270]
006860750  bl       #0x382bd14 ; 
006860754  adrp     x0, #0x8f23000
006860758  ldr      x0, [x0, #0xc68]
00686075C  bl       #0x382bd14 ; 
006860760  adrp     x0, #0x8f08000
006860764  ldr      x0, [x0, #0xbb8]
006860768  bl       #0x382bd14 ; 
00686076C  adrp     x0, #0x8f08000
006860770  ldr      x0, [x0, #0xbc0]
006860774  bl       #0x382bd14 ; 
006860778  mov      w8, #1
00686077C  strb     w8, [x23, #0xab4]
006860780  ldr      x4, [x24]
006860784  ldrb     w8, [x4, #0x53]
006860788  tbnz     w8, #5, #0x68607d8
00686078C  mov      x0, x21
006860790  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860794  cbz      x0, #0x6860974
006860798  adrp     x24, #0x9591000
00686079C  ldrb     w8, [x24, #0xa90]
0068607A0  mov      x23, x0
0068607A4  cbnz     w8, #0x68607bc
0068607A8  adrp     x0, #0x8ee6000
0068607AC  ldr      x0, [x0, #0x3e0]
0068607B0  bl       #0x382bd14 ; 
0068607B4  mov      w8, #1
0068607B8  strb     w8, [x24, #0xa90]
0068607BC  adrp     x25, #0x8ee6000
0068607C0  ldr      x25, [x25, #0x3e0]
0068607C4  ldr      x1, [x25]
0068607C8  ldrb     w8, [x1, #0x53]
0068607CC  tbnz     w8, #5, #0x6860804
0068607D0  ldr      x0, [x23, #0x230]
0068607D4  b        #0x6860810 ; 
0068607D8  ldr      x5, [x4, #0x60]
0068607DC  mov      x0, x21
0068607E0  mov      x1, x22
0068607E4  mov      x2, x20
0068607E8  mov      w3, w19
0068607EC  ldp      x20, x19, [sp, #0x40]
0068607F0  ldp      x22, x21, [sp, #0x30]
0068607F4  ldp      x24, x23, [sp, #0x20]
0068607F8  ldp      x26, x25, [sp, #0x10]
0068607FC  ldp      x30, x27, [sp], #0x50
006860800  br       x5
006860804  ldr      x8, [x1, #0x60]
006860808  mov      x0, x23
00686080C  blr      x8
006860810  cbz      x0, #0x6860974
006860814  adrp     x8, #0x8f08000
006860818  ldr      x8, [x8, #0xbb8]
00686081C  ldr      x1, [x8]
006860820  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006860824  mov      x23, x0
006860828  mov      x0, x21
00686082C  mov      x1, x23
006860830  mov      x2, x20
006860834  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
006860838  cmp      w19, #1
00686083C  b.lt     #0x68608fc
006860840  adrp     x26, #0x8ec2000
006860844  adrp     x27, #0x8ec2000
006860848  ldr      x26, [x26, #0x270]
00686084C  ldr      x27, [x27, #0x260]
006860850  ldr      x2, [x21, #0x68]
006860854  cbz      x2, #0x6860974
006860858  ldr      w8, [x2, #0x1c]
00686085C  add      w8, w8, #1
006860860  stp      wzr, w8, [x2, #0x18]
006860864  ldr      x0, [x21, #0x40]
006860868  cbz      x0, #0x6860974
00686086C  mov      w1, #1
006860870  mov      x3, x20
006860874  mov      x4, x23
006860878  mov      x5, xzr
00686087C  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
006860880  ldr      x0, [x21, #0x68]
006860884  cbz      x0, #0x6860974
006860888  ldr      w8, [x0, #0x18]
00686088C  cbz      w8, #0x68608fc
006860890  ldr      x2, [x26]
006860894  mov      w1, wzr
006860898  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00686089C  cbz      x22, #0x6860974
0068608A0  ldr      w10, [x22, #0x1c]
0068608A4  ldr      x8, [x22, #0x10]
0068608A8  ldr      x9, [x27]
0068608AC  add      w10, w10, #1
0068608B0  str      w10, [x22, #0x1c]
0068608B4  cbz      x8, #0x6860974
0068608B8  ldrsw    x10, [x22, #0x18]
0068608BC  ldr      w11, [x8, #0x18]
0068608C0  mov      w1, w0
0068608C4  cmp      w10, w11
0068608C8  b.hs     #0x68608e0
0068608CC  add      w9, w10, #1
0068608D0  add      x8, x8, x10, lsl #2
0068608D4  str      w9, [x22, #0x18]
0068608D8  str      w1, [x8, #0x20]
0068608DC  b        #0x68608f4 ; 
0068608E0  ldr      x8, [x9, #0x20]
0068608E4  mov      x0, x22
0068608E8  ldr      x8, [x8, #0xc0]
0068608EC  ldr      x2, [x8, #0x70]
0068608F0  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0068608F4  subs     w19, w19, #1
0068608F8  b.ne     #0x6860850
0068608FC  mov      x0, x21
006860900  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860904  cbz      x0, #0x6860974
006860908  ldrb     w8, [x24, #0xa90]
00686090C  mov      x19, x0
006860910  cbnz     w8, #0x6860928
006860914  adrp     x0, #0x8ee6000
006860918  ldr      x0, [x0, #0x3e0]
00686091C  bl       #0x382bd14 ; 
006860920  mov      w8, #1
006860924  strb     w8, [x24, #0xa90]
006860928  ldr      x1, [x25]
00686092C  ldrb     w8, [x1, #0x53]
006860930  tbnz     w8, #5, #0x686093c
006860934  ldr      x0, [x19, #0x230]
006860938  b        #0x6860948 ; 
00686093C  ldr      x8, [x1, #0x60]
006860940  mov      x0, x19
006860944  blr      x8
006860948  cbz      x0, #0x6860974
00686094C  adrp     x8, #0x8f08000
006860950  ldr      x8, [x8, #0xbc0]
006860954  mov      x1, x23
006860958  ldp      x20, x19, [sp, #0x40]
00686095C  ldp      x22, x21, [sp, #0x30]
006860960  ldr      x2, [x8]
006860964  ldp      x24, x23, [sp, #0x20]
006860968  ldp      x26, x25, [sp, #0x10]
00686096C  ldp      x30, x27, [sp], #0x50
006860970  b        #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
006860974  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.SinglePlayerSkillCreator$$.ctor
; RVA 0x685CB68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685CB68  str      x30, [sp, #-0x30]!
00685CB6C  stp      x22, x21, [sp, #0x10]
00685CB70  stp      x20, x19, [sp, #0x20]
00685CB74  adrp     x20, #0x959b000
00685CB78  adrp     x21, #0x8f23000
00685CB7C  ldrb     w8, [x20, #0xab5]
00685CB80  ldr      x21, [x21, #0xae8]
00685CB84  mov      x19, x0
00685CB88  tbnz     w8, #0, #0x685cbd0
00685CB8C  adrp     x0, #0x8ec2000
00685CB90  ldr      x0, [x0, #0x2b8]
00685CB94  bl       #0x382bd14 ; 
00685CB98  adrp     x0, #0x8f23000
00685CB9C  ldr      x0, [x0, #0xaf0]
00685CBA0  bl       #0x382bd14 ; 
00685CBA4  adrp     x0, #0x8ec2000
00685CBA8  ldr      x0, [x0, #0x2d0]
00685CBAC  bl       #0x382bd14 ; 
00685CBB0  adrp     x0, #0x8f23000
00685CBB4  ldr      x0, [x0, #0xaf8]
00685CBB8  bl       #0x382bd14 ; 
00685CBBC  adrp     x0, #0x8f23000
00685CBC0  ldr      x0, [x0, #0xae8]
00685CBC4  bl       #0x382bd14 ; 
00685CBC8  mov      w8, #1
00685CBCC  strb     w8, [x20, #0xab5]
00685CBD0  ldr      x1, [x21]
00685CBD4  ldrb     w8, [x1, #0x53]
00685CBD8  tbnz     w8, #5, #0x685cc58
00685CBDC  adrp     x8, #0x8ec2000
00685CBE0  ldr      x8, [x8, #0x2d0]
00685CBE4  adrp     x20, #0x8ec2000
00685CBE8  adrp     x21, #0x8f23000
00685CBEC  adrp     x22, #0x8f23000
00685CBF0  ldr      x0, [x8]
00685CBF4  ldr      x20, [x20, #0x2b8]
00685CBF8  ldr      x21, [x21, #0xaf8]
00685CBFC  ldr      x22, [x22, #0xaf0]
00685CC00  bl       #0x382bfa0 ; 
00685CC04  ldr      x1, [x20]
00685CC08  mov      x20, x0
00685CC0C  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
00685CC10  mov      x0, x19
00685CC14  str      x20, [x0, #0x68]!
00685CC18  mov      x1, x20
00685CC1C  bl       #0x382bcb8 ; 
00685CC20  ldr      x0, [x21]
00685CC24  bl       #0x382bfa0 ; 
00685CC28  ldr      x1, [x22]
00685CC2C  mov      x20, x0
00685CC30  bl       #0x4dac814 ; System.Collections.Generic.List<NewPlayerBoostRecord>$$.ctor
00685CC34  mov      x0, x19
00685CC38  str      x20, [x0, #0x70]!
00685CC3C  mov      x1, x20
00685CC40  bl       #0x382bcb8 ; 
00685CC44  mov      x0, x19
00685CC48  ldp      x20, x19, [sp, #0x20]
00685CC4C  ldp      x22, x21, [sp, #0x10]
00685CC50  ldr      x30, [sp], #0x30
00685CC54  b        #0x685c358 ; HotFix.BattleLogic.HeroSkillCreator$$.ctor
00685CC58  ldr      x2, [x1, #0x60]
00685CC5C  mov      x0, x19
00685CC60  ldp      x20, x19, [sp, #0x20]
00685CC64  ldp      x22, x21, [sp, #0x10]
00685CC68  ldr      x30, [sp], #0x30
00685CC6C  br       x2

