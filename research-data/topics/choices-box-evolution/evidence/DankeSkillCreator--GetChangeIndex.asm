; HotFix.BattleLogic.DankeSkillCreator$$GetChangeIndex
; RVA 0x6860978; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006860978  str      x30, [sp, #-0x60]!
00686097C  stp      x28, x27, [sp, #0x10]
006860980  stp      x26, x25, [sp, #0x20]
006860984  stp      x24, x23, [sp, #0x30]
006860988  stp      x22, x21, [sp, #0x40]
00686098C  stp      x20, x19, [sp, #0x50]
006860990  adrp     x21, #0x959b000
006860994  adrp     x22, #0x8f23000
006860998  ldrb     w8, [x21, #0x9f2]
00686099C  ldr      x22, [x22, #0xc70] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetChangeIndex() @ 0x9259d40
0068609A0  mov      x19, x1
0068609A4  mov      x20, x0
0068609A8  tbnz     w8, #0, #0x68609d8
0068609AC  adrp     x0, #0x8f23000
0068609B0  ldr      x0, [x0, #0xc70] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetChangeIndex() @ 0x9259d40
0068609B4  bl       #0x382bd14 ; 
0068609B8  adrp     x0, #0x8ec2000
0068609BC  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
0068609C0  bl       #0x382bd14 ; 
0068609C4  adrp     x0, #0x8ec2000
0068609C8  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
0068609CC  bl       #0x382bd14 ; 
0068609D0  mov      w8, #1
0068609D4  strb     w8, [x21, #0x9f2]
0068609D8  ldr      x2, [x22]
0068609DC  ldrb     w8, [x2, #0x53]
0068609E0  tbnz     w8, #5, #0x6860a6c
0068609E4  mov      x0, x20
0068609E8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068609EC  cbz      x19, #0x6860c30
0068609F0  mov      x22, x0
0068609F4  cbz      x0, #0x6860c30
0068609F8  adrp     x23, #0x9599000
0068609FC  ldrb     w8, [x23, #0xac6]
006860A00  ldr      w21, [x19, #0x18]
006860A04  cbnz     w8, #0x6860a1c
006860A08  adrp     x0, #0x8f0d000
006860A0C  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006860A10  bl       #0x382bd14 ; 
006860A14  mov      w8, #1
006860A18  strb     w8, [x23, #0xac6]
006860A1C  adrp     x8, #0x8f0d000
006860A20  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006860A24  ldr      x3, [x8]
006860A28  ldrb     w8, [x3, #0x53]
006860A2C  tbnz     w8, #5, #0x6860a94
006860A30  adrp     x23, #0x9599000
006860A34  ldrb     w8, [x23, #0xac7]
006860A38  cbnz     w8, #0x6860a50
006860A3C  adrp     x0, #0x8f0d000
006860A40  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006860A44  bl       #0x382bd14 ; 
006860A48  mov      w8, #1
006860A4C  strb     w8, [x23, #0xac7]
006860A50  adrp     x8, #0x8f0d000
006860A54  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006860A58  ldr      x1, [x8]
006860A5C  ldrb     w8, [x1, #0x53]
006860A60  tbnz     w8, #5, #0x6860ab0
006860A64  ldr      x0, [x22, #0x260]
006860A68  b        #0x6860abc ; 
006860A6C  ldr      x3, [x2, #0x60]
006860A70  mov      x0, x20
006860A74  mov      x1, x19
006860A78  ldp      x20, x19, [sp, #0x50]
006860A7C  ldp      x22, x21, [sp, #0x40]
006860A80  ldp      x24, x23, [sp, #0x30]
006860A84  ldp      x26, x25, [sp, #0x20]
006860A88  ldp      x28, x27, [sp, #0x10]
006860A8C  ldr      x30, [sp], #0x60
006860A90  br       x3
006860A94  ldr      x8, [x3, #0x60]
006860A98  mov      x0, x22
006860A9C  mov      w1, wzr
006860AA0  mov      w2, w21
006860AA4  blr      x8
006860AA8  mov      w21, w0
006860AAC  b        #0x6860ae0 ; 
006860AB0  ldr      x8, [x1, #0x60]
006860AB4  mov      x0, x22
006860AB8  blr      x8
006860ABC  cbz      x0, #0x6860c30
006860AC0  mov      w1, wzr
006860AC4  mov      w2, w21
006860AC8  mov      x3, xzr
006860ACC  bl       #0x416d068 ; XXRandom$$Next
006860AD0  ldr      w8, [x22, #0x32c]
006860AD4  mov      w21, w0
006860AD8  add      w8, w8, #1
006860ADC  str      w8, [x22, #0x32c]
006860AE0  mov      x0, x20
006860AE4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860AE8  cbz      x0, #0x6860c30
006860AEC  adrp     x24, #0x9598000
006860AF0  ldrb     w8, [x24, #0xfcc]
006860AF4  mov      x23, x0
006860AF8  cbnz     w8, #0x6860b10
006860AFC  adrp     x0, #0x8f06000
006860B00  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006860B04  bl       #0x382bd14 ; 
006860B08  mov      w8, #1
006860B0C  strb     w8, [x24, #0xfcc]
006860B10  adrp     x22, #0x8f06000
006860B14  ldr      x22, [x22, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006860B18  ldr      x1, [x22]
006860B1C  ldrb     w8, [x1, #0x53]
006860B20  tbnz     w8, #5, #0x6860b2c
006860B24  ldr      x23, [x23, #0x200]
006860B28  b        #0x6860b3c ; 
006860B2C  ldr      x8, [x1, #0x60]
006860B30  mov      x0, x23
006860B34  blr      x8
006860B38  mov      x23, x0
006860B3C  adrp     x25, #0x8ec2000
006860B40  ldr      x25, [x25, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006860B44  mov      x0, x19
006860B48  mov      w1, w21
006860B4C  ldr      x2, [x25]
006860B50  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006860B54  cbz      x23, #0x6860c30
006860B58  mov      w1, w0
006860B5C  mov      x0, x23
006860B60  mov      x2, xzr
006860B64  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006860B68  mov      w26, wzr
006860B6C  mov      w27, #1
006860B70  mov      w1, wzr
006860B74  mov      x2, xzr
006860B78  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
006860B7C  cmp      w0, #2
006860B80  b.ne     #0x6860c10
006860B84  ldr      w28, [x19, #0x18]
006860B88  mov      x0, x20
006860B8C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860B90  cbz      x0, #0x6860c30
006860B94  ldrb     w8, [x24, #0xfcc]
006860B98  mov      x23, x0
006860B9C  cbnz     w8, #0x6860bac
006860BA0  mov      x0, x22
006860BA4  bl       #0x382bd14 ; 
006860BA8  strb     w27, [x24, #0xfcc]
006860BAC  ldr      x1, [x22]
006860BB0  ldrb     w8, [x1, #0x53]
006860BB4  tbnz     w8, #5, #0x6860bc0
006860BB8  ldr      x23, [x23, #0x200]
006860BBC  b        #0x6860bd0 ; 
006860BC0  ldr      x8, [x1, #0x60]
006860BC4  mov      x0, x23
006860BC8  blr      x8
006860BCC  mov      x23, x0
006860BD0  ldr      x2, [x25]
006860BD4  add      w8, w21, #1
006860BD8  sdiv     w9, w8, w28
006860BDC  msub     w21, w9, w28, w8
006860BE0  mov      x0, x19
006860BE4  mov      w1, w21
006860BE8  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006860BEC  cbz      x23, #0x6860c30
006860BF0  mov      w1, w0
006860BF4  mov      x0, x23
006860BF8  mov      x2, xzr
006860BFC  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006860C00  ldr      w8, [x19, #0x18]
006860C04  add      w26, w26, #1
006860C08  cmp      w26, w8
006860C0C  b.le     #0x6860b70
006860C10  mov      w0, w21
006860C14  ldp      x20, x19, [sp, #0x50]
006860C18  ldp      x22, x21, [sp, #0x40]
006860C1C  ldp      x24, x23, [sp, #0x30]
006860C20  ldp      x26, x25, [sp, #0x20]
006860C24  ldp      x28, x27, [sp, #0x10]
006860C28  ldr      x30, [sp], #0x60
006860C2C  ret      
006860C30  bl       #0x382bfb8 ; 

