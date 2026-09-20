; HotFix.BattleLogic.DankeSkillCreator$$CheckIsSpecialSkill
; RVA 0x6861B78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006861B78  str      x30, [sp, #-0x30]!
006861B7C  stp      x22, x21, [sp, #0x10]
006861B80  stp      x20, x19, [sp, #0x20]
006861B84  adrp     x21, #0x959b000
006861B88  adrp     x22, #0x8f23000
006861B8C  ldrb     w8, [x21, #0x9f4]
006861B90  ldr      x22, [x22, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckIsSpecialSkill() @ 0x9259d08
006861B94  mov      w20, w1
006861B98  mov      x19, x0
006861B9C  tbnz     w8, #0, #0x6861bc0
006861BA0  adrp     x0, #0x8f23000
006861BA4  ldr      x0, [x0, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.CheckIsSpecialSkill() @ 0x9259d08
006861BA8  bl       #0x382bd14 ; 
006861BAC  adrp     x0, #0x8ec2000
006861BB0  ldr      x0, [x0, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006861BB4  bl       #0x382bd14 ; 
006861BB8  mov      w8, #1
006861BBC  strb     w8, [x21, #0x9f4]
006861BC0  ldr      x2, [x22]
006861BC4  ldrb     w8, [x2, #0x53]
006861BC8  tbnz     w8, #5, #0x6861c18
006861BCC  mov      x0, x19
006861BD0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006861BD4  cbz      x0, #0x6861d2c
006861BD8  adrp     x22, #0x9598000
006861BDC  ldrb     w8, [x22, #0xfcc]
006861BE0  mov      x21, x0
006861BE4  cbnz     w8, #0x6861bfc
006861BE8  adrp     x0, #0x8f06000
006861BEC  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006861BF0  bl       #0x382bd14 ; 
006861BF4  mov      w8, #1
006861BF8  strb     w8, [x22, #0xfcc]
006861BFC  adrp     x8, #0x8f06000
006861C00  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006861C04  ldr      x1, [x8]
006861C08  ldrb     w8, [x1, #0x53]
006861C0C  tbnz     w8, #5, #0x6861c34
006861C10  ldr      x0, [x21, #0x200]
006861C14  b        #0x6861c40 ; 
006861C18  ldr      x3, [x2, #0x60]
006861C1C  mov      x0, x19
006861C20  mov      w1, w20
006861C24  ldp      x20, x19, [sp, #0x20]
006861C28  ldp      x22, x21, [sp, #0x10]
006861C2C  ldr      x30, [sp], #0x30
006861C30  br       x3
006861C34  ldr      x8, [x1, #0x60]
006861C38  mov      x0, x21
006861C3C  blr      x8
006861C40  cbz      x0, #0x6861d2c
006861C44  mov      w1, w20
006861C48  mov      x2, xzr
006861C4C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006861C50  cbz      x0, #0x6861d2c
006861C54  mov      x1, xzr
006861C58  mov      x20, x0
006861C5C  bl       #0x6b0a2d4 ; LocalModels.Bean.Skill_Main$$GetIsUpgrade
006861C60  cmp      w0, #1
006861C64  b.ne     #0x6861cfc
006861C68  adrp     x21, #0x9598000
006861C6C  ldrb     w8, [x21, #0xde3]
006861C70  ldr      x19, [x19, #0xc0]
006861C74  cbnz     w8, #0x6861c8c
006861C78  adrp     x0, #0x8f00000
006861C7C  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
006861C80  bl       #0x382bd14 ; 
006861C84  mov      w8, #1
006861C88  strb     w8, [x21, #0xde3]
006861C8C  adrp     x8, #0x8f00000
006861C90  ldr      x8, [x8, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
006861C94  ldr      x1, [x8]
006861C98  ldrb     w8, [x1, #0x53]
006861C9C  tbnz     w8, #5, #0x6861ca8
006861CA0  ldr      w1, [x20, #0x20]
006861CA4  b        #0x6861cb8 ; 
006861CA8  ldr      x8, [x1, #0x60]
006861CAC  mov      x0, x20
006861CB0  blr      x8
006861CB4  mov      w1, w0
006861CB8  cbz      x19, #0x6861d2c
006861CBC  adrp     x9, #0x8ec2000
006861CC0  ldr      x9, [x9, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006861CC4  ldr      w10, [x19, #0x1c]
006861CC8  ldr      x8, [x19, #0x10]
006861CCC  ldr      x9, [x9]
006861CD0  add      w10, w10, #1
006861CD4  str      w10, [x19, #0x1c]
006861CD8  cbz      x8, #0x6861d2c
006861CDC  ldrsw    x10, [x19, #0x18]
006861CE0  ldr      w11, [x8, #0x18]
006861CE4  cmp      w10, w11
006861CE8  b.hs     #0x6861d0c
006861CEC  add      w9, w10, #1
006861CF0  add      x8, x8, x10, lsl #2
006861CF4  str      w9, [x19, #0x18]
006861CF8  str      w1, [x8, #0x20]
006861CFC  ldp      x20, x19, [sp, #0x20]
006861D00  ldp      x22, x21, [sp, #0x10]
006861D04  ldr      x30, [sp], #0x30
006861D08  ret      
006861D0C  ldr      x8, [x9, #0x20]
006861D10  mov      x0, x19
006861D14  ldp      x20, x19, [sp, #0x20]
006861D18  ldp      x22, x21, [sp, #0x10]
006861D1C  ldr      x8, [x8, #0xc0]
006861D20  ldr      x2, [x8, #0x70]
006861D24  ldr      x30, [sp], #0x30
006861D28  b        #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006861D2C  bl       #0x382bfb8 ; 

