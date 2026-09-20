; HotFix.BattleLogic.PlayerPunchboard$$GetResultSkillList
; RVA 0x65A3FF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065A3FF4  stp      x29, x30, [sp, #-0x60]!
0065A3FF8  stp      x28, x27, [sp, #0x10]
0065A3FFC  stp      x26, x25, [sp, #0x20]
0065A4000  stp      x24, x23, [sp, #0x30]
0065A4004  stp      x22, x21, [sp, #0x40]
0065A4008  stp      x20, x19, [sp, #0x50]
0065A400C  adrp     x23, #0x9599000
0065A4010  adrp     x24, #0x8f09000
0065A4014  ldrb     w8, [x23, #0x363]
0065A4018  b        #0x89ec66c ; 
0065A401C  mov      x19, x3
0065A4020  mov      x20, x2
0065A4024  mov      x21, x1
0065A4028  mov      x22, x0
0065A402C  tbnz     w8, #0, #0x65a40a4
0065A4030  adrp     x0, #0x8f08000
0065A4034  ldr      x0, [x0, #0x640] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.ContainsKey() @ 0x920b050
0065A4038  bl       #0x382bd14 ; 
0065A403C  adrp     x0, #0x8f08000
0065A4040  ldr      x0, [x0, #0x648] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.get_Item() @ 0x920b088
0065A4044  bl       #0x382bd14 ; 
0065A4048  adrp     x0, #0x8f09000
0065A404C  ldr      x0, [x0, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
0065A4050  bl       #0x382bd14 ; 
0065A4054  adrp     x0, #0x8ed2000
0065A4058  ldr      x0, [x0, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
0065A405C  bl       #0x382bd14 ; 
0065A4060  adrp     x0, #0x8f09000
0065A4064  ldr      x0, [x0, #0xa0] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Count() @ 0x921f560
0065A4068  bl       #0x382bd14 ; 
0065A406C  adrp     x0, #0x8f09000
0065A4070  ldr      x0, [x0, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
0065A4074  bl       #0x382bd14 ; 
0065A4078  adrp     x0, #0x8ec2000
0065A407C  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
0065A4080  bl       #0x382bd14 ; 
0065A4084  adrp     x0, #0x8f09000
0065A4088  ldr      x0, [x0, #0xb0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, List<int>>.get_Item() @ 0x92286b0
0065A408C  bl       #0x382bd14 ; 
0065A4090  adrp     x0, #0x8f09000
0065A4094  ldr      x0, [x0, #0x2b0] ; GLOBAL Method$HotFix.BattleLogic.PlayerPunchboard.GetResultSkillList() @ 0x929a330
0065A4098  bl       #0x382bd14 ; 
0065A409C  mov      w8, #1
0065A40A0  strb     w8, [x23, #0x363]
0065A40A4  ldr      x4, [x24] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<ShowJoyStickEvent>() @ 0x923f470
0065A40A8  ldrb     w8, [x4, #0x53]
0065A40AC  tbnz     w8, #5, #0x65a43bc
0065A40B0  mov      w2, #1
0065A40B4  mov      x0, x22
0065A40B8  mov      x1, x19
0065A40BC  mov      x3, x21
0065A40C0  bl       #0x65a3264 ; HotFix.BattleLogic.PlayerPunchboard$$GetSkillGroup2Skills
0065A40C4  cbz      x21, #0x65a43ec
0065A40C8  ldr      w8, [x21, #0x18]
0065A40CC  cmp      w8, #1
0065A40D0  b.lt     #0x65a43a0
0065A40D4  adrp     x25, #0x8f06000
0065A40D8  adrp     x26, #0x8ef9000
0065A40DC  ldr      x25, [x25, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0065A40E0  ldr      x26, [x26, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0065A40E4  mov      x23, x0
0065A40E8  mov      w24, wzr
0065A40EC  adrp     x27, #0x9598000
0065A40F0  adrp     x8, #0x8f09000
0065A40F4  ldr      x8, [x8, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
0065A40F8  mov      x0, x21
0065A40FC  mov      w1, w24
0065A4100  ldr      x2, [x8]
0065A4104  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
0065A4108  ldr      x29, [x22, #0x18]
0065A410C  cbz      x29, #0x65a43ec
0065A4110  adrp     x8, #0x9598000
0065A4114  ldrb     w8, [x8, #0xfcc]
0065A4118  mov      x28, x0
0065A411C  cbnz     w8, #0x65a4134
0065A4120  mov      x0, x25
0065A4124  bl       #0x382bd14 ; 
0065A4128  adrp     x8, #0x9598000
0065A412C  mov      w9, #1
0065A4130  strb     w9, [x8, #0xfcc]
0065A4134  ldr      x1, [x25]
0065A4138  ldrb     w8, [x1, #0x53]
0065A413C  tbnz     w8, #5, #0x65a4148
0065A4140  ldr      x0, [x29, #0x200]
0065A4144  b        #0x65a4154 ; 
0065A4148  ldr      x8, [x1, #0x60]
0065A414C  mov      x0, x29
0065A4150  blr      x8
0065A4154  cbz      x0, #0x65a43ec
0065A4158  mov      w1, w28
0065A415C  mov      x2, xzr
0065A4160  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0065A4164  cbz      x0, #0x65a43ec
0065A4168  ldrb     w8, [x27, #0x35e]
0065A416C  mov      x29, x0
0065A4170  cbnz     w8, #0x65a4184
0065A4174  mov      x0, x26
0065A4178  bl       #0x382bd14 ; 
0065A417C  mov      w8, #1
0065A4180  strb     w8, [x27, #0x35e]
0065A4184  ldr      x1, [x26]
0065A4188  ldrb     w8, [x1, #0x53]
0065A418C  tbnz     w8, #5, #0x65a4198
0065A4190  ldr      w0, [x29, #0x68]
0065A4194  b        #0x65a41a4 ; 
0065A4198  ldr      x8, [x1, #0x60]
0065A419C  mov      x0, x29
0065A41A0  blr      x8
0065A41A4  cmp      w0, #4
0065A41A8  b.eq     #0x65a41ec
0065A41AC  ldrb     w8, [x27, #0x35e]
0065A41B0  cbnz     w8, #0x65a41c4
0065A41B4  mov      x0, x26
0065A41B8  bl       #0x382bd14 ; 
0065A41BC  mov      w8, #1
0065A41C0  strb     w8, [x27, #0x35e]
0065A41C4  ldr      x1, [x26]
0065A41C8  ldrb     w8, [x1, #0x53]
0065A41CC  tbnz     w8, #5, #0x65a41d8
0065A41D0  ldr      w0, [x29, #0x68]
0065A41D4  b        #0x65a41e4 ; 
0065A41D8  ldr      x8, [x1, #0x60]
0065A41DC  mov      x0, x29
0065A41E0  blr      x8
0065A41E4  cmp      w0, #5
0065A41E8  b.ne     #0x65a4328
0065A41EC  adrp     x8, #0x9599000
0065A41F0  ldrb     w8, [x8, #0x4c8]
0065A41F4  cbnz     w8, #0x65a4210
0065A41F8  adrp     x0, #0x8f09000
0065A41FC  ldr      x0, [x0, #0xd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_BattleSkillGroup() @ 0x92ac408
0065A4200  bl       #0x382bd14 ; 
0065A4204  mov      w8, #1
0065A4208  adrp     x9, #0x9599000
0065A420C  strb     w8, [x9, #0x4c8]
0065A4210  adrp     x8, #0x8f09000
0065A4214  ldr      x8, [x8, #0xd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_BattleSkillGroup() @ 0x92ac408
0065A4218  ldr      x1, [x8]
0065A421C  ldrb     w8, [x1, #0x53]
0065A4220  tbnz     w8, #5, #0x65a422c
0065A4224  ldr      w1, [x29, #0x120]
0065A4228  b        #0x65a423c ; 
0065A422C  ldr      x8, [x1, #0x60]
0065A4230  mov      x0, x29
0065A4234  blr      x8
0065A4238  mov      w1, w0
0065A423C  cbz      x23, #0x65a43ec
0065A4240  adrp     x8, #0x8f09000
0065A4244  ldr      x8, [x8, #0xb0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, List<int>>.get_Item() @ 0x92286b0
0065A4248  mov      x0, x23
0065A424C  ldr      x2, [x8]
0065A4250  bl       #0x5225a74 ; Rock.Collections.OrderedDictionary<int, object>$$get_Item
0065A4254  cbz      x0, #0x65a43ec
0065A4258  adrp     x8, #0x8ec2000
0065A425C  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
0065A4260  mov      w1, wzr
0065A4264  mov      x29, x0
0065A4268  ldr      x2, [x8]
0065A426C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065A4270  adrp     x8, #0x8ed2000
0065A4274  ldr      x8, [x8, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
0065A4278  mov      w28, w0
0065A427C  mov      x0, x29
0065A4280  mov      w1, wzr
0065A4284  ldr      x2, [x8]
0065A4288  bl       #0x4d6603c ; System.Collections.Generic.List<int>$$RemoveAt
0065A428C  cbz      x19, #0x65a43ec
0065A4290  adrp     x8, #0x8f08000
0065A4294  ldr      x8, [x8, #0x640] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.ContainsKey() @ 0x920b050
0065A4298  mov      x0, x19
0065A429C  mov      w1, w28
0065A42A0  ldr      x2, [x8]
0065A42A4  bl       #0x5e2834c ; System.Collections.Generic.Dictionary<int, int>$$ContainsKey
0065A42A8  tbz      w0, #0, #0x65a42c8
0065A42AC  adrp     x8, #0x8f08000
0065A42B0  ldr      x8, [x8, #0x648] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.get_Item() @ 0x920b088
0065A42B4  mov      x0, x19
0065A42B8  mov      w1, w28
0065A42BC  ldr      x2, [x8]
0065A42C0  bl       #0x5e280c4 ; System.Collections.Generic.Dictionary<int, int>$$get_Item
0065A42C4  b        #0x65a42cc ; 
0065A42C8  mov      w0, w28
0065A42CC  cbz      x20, #0x65a43ec
0065A42D0  adrp     x9, #0x8f09000
0065A42D4  ldr      w10, [x20, #0x1c]
0065A42D8  ldr      x8, [x20, #0x10]
0065A42DC  ldr      x9, [x9, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
0065A42E0  add      w10, w10, #1
0065A42E4  ldr      x9, [x9]
0065A42E8  str      w10, [x20, #0x1c]
0065A42EC  cbz      x8, #0x65a43ec
0065A42F0  ldrsw    x10, [x20, #0x18]
0065A42F4  ldr      w11, [x8, #0x18]
0065A42F8  mov      w1, w0
0065A42FC  bfi      x1, x28, #0x20, #0x20
0065A4300  cmp      w10, w11
0065A4304  b.hs     #0x65a431c
0065A4308  add      w9, w10, #1
0065A430C  add      x8, x8, x10, lsl #3
0065A4310  str      w9, [x20, #0x18]
0065A4314  str      x1, [x8, #0x20]
0065A4318  b        #0x65a4390 ; 
0065A431C  ldr      x8, [x9, #0x20]
0065A4320  mov      x0, x20
0065A4324  b        #0x65a4384 ; 
0065A4328  cbz      x20, #0x65a43ec
0065A432C  adrp     x9, #0x8f09000
0065A4330  ldr      w10, [x20, #0x1c]
0065A4334  ldr      x8, [x20, #0x10]
0065A4338  ldr      x9, [x9, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
0065A433C  add      w10, w10, #1
0065A4340  ldr      x9, [x9]
0065A4344  str      w10, [x20, #0x1c]
0065A4348  cbz      x8, #0x65a43ec
0065A434C  ldrsw    x10, [x20, #0x18]
0065A4350  ldr      w11, [x8, #0x18]
0065A4354  and      x12, x28, #0xffffffff
0065A4358  bfi      x28, x12, #0x20, #0x20
0065A435C  cmp      w10, w11
0065A4360  b.hs     #0x65a4378
0065A4364  add      w9, w10, #1
0065A4368  add      x8, x8, x10, lsl #3
0065A436C  str      w9, [x20, #0x18]
0065A4370  str      x28, [x8, #0x20]
0065A4374  b        #0x65a4390 ; 
0065A4378  ldr      x8, [x9, #0x20]
0065A437C  mov      x0, x20
0065A4380  mov      x1, x28
0065A4384  ldr      x8, [x8, #0xc0]
0065A4388  ldr      x2, [x8, #0x70]
0065A438C  bl       #0x4dd582c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$AddWithResize
0065A4390  ldr      w8, [x21, #0x18]
0065A4394  add      w24, w24, #1
0065A4398  cmp      w24, w8
0065A439C  b.lt     #0x65a40f0
0065A43A0  ldp      x20, x19, [sp, #0x50]
0065A43A4  ldp      x22, x21, [sp, #0x40]
0065A43A8  ldp      x24, x23, [sp, #0x30]
0065A43AC  ldp      x26, x25, [sp, #0x20]
0065A43B0  ldp      x28, x27, [sp, #0x10]
0065A43B4  ldp      x29, x30, [sp], #0x60
0065A43B8  ret      
0065A43BC  ldr      x5, [x4, #0x60]
0065A43C0  mov      x0, x22
0065A43C4  mov      x1, x21
0065A43C8  mov      x2, x20
0065A43CC  mov      x3, x19
0065A43D0  ldp      x20, x19, [sp, #0x50]
0065A43D4  ldp      x22, x21, [sp, #0x40]
0065A43D8  ldp      x24, x23, [sp, #0x30]
0065A43DC  ldp      x26, x25, [sp, #0x20]
0065A43E0  ldp      x28, x27, [sp, #0x10]
0065A43E4  ldp      x29, x30, [sp], #0x60
0065A43E8  br       x5
0065A43EC  bl       #0x382bfb8 ; 

