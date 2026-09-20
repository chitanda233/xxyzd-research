; HotFix.BattleLogic.DankeSkillCreator$$GetSkillCountOnType
; RVA 0x685EFB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685EFB0  sub      sp, sp, #0x80
00685EFB4  stp      x29, x30, [sp, #0x20]
00685EFB8  stp      x28, x27, [sp, #0x30]
00685EFBC  stp      x26, x25, [sp, #0x40]
00685EFC0  stp      x24, x23, [sp, #0x50]
00685EFC4  stp      x22, x21, [sp, #0x60]
00685EFC8  stp      x20, x19, [sp, #0x70]
00685EFCC  adrp     x20, #0x959b000
00685EFD0  adrp     x21, #0x8f23000
00685EFD4  ldrb     w8, [x20, #0xa03]
00685EFD8  ldr      x21, [x21, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetSkillCountOnType() @ 0x9259d88
00685EFDC  mov      x23, x3
00685EFE0  mov      x24, x2
00685EFE4  mov      x22, x1
00685EFE8  mov      x19, x0
00685EFEC  tbnz     w8, #0, #0x685f07c
00685EFF0  adrp     x0, #0x8f23000
00685EFF4  ldr      x0, [x0, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetSkillCountOnType() @ 0x9259d88
00685EFF8  bl       #0x382bd14 ; 
00685EFFC  adrp     x0, #0x8ebf000
00685F000  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685F004  bl       #0x382bd14 ; 
00685F008  adrp     x0, #0x8f09000
00685F00C  ldr      x0, [x0, #0x9a8] ; GLOBAL Method$ListPool<int>.Get() @ 0x9218bd0
00685F010  bl       #0x382bd14 ; 
00685F014  adrp     x0, #0x8f09000
00685F018  ldr      x0, [x0, #0x9b0] ; GLOBAL Method$ListPool<int>.Release() @ 0x9218bd8
00685F01C  bl       #0x382bd14 ; 
00685F020  adrp     x0, #0x8f09000
00685F024  ldr      x0, [x0, #0x9b8] ; GLOBAL ListPool<int>_TypeInfo @ 0x91d8fc0
00685F028  bl       #0x382bd14 ; 
00685F02C  adrp     x0, #0x8ec2000
00685F030  ldr      x0, [x0, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
00685F034  bl       #0x382bd14 ; 
00685F038  adrp     x0, #0x8f08000
00685F03C  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00685F040  bl       #0x382bd14 ; 
00685F044  adrp     x0, #0x8ec2000
00685F048  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
00685F04C  bl       #0x382bd14 ; 
00685F050  adrp     x0, #0x8ec2000
00685F054  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00685F058  bl       #0x382bd14 ; 
00685F05C  adrp     x0, #0x8ebf000
00685F060  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685F064  bl       #0x382bd14 ; 
00685F068  adrp     x0, #0x8f23000
00685F06C  ldr      x0, [x0, #0xc00] ; GLOBAL -[RandomSkill]-[Danke]  passiveSkillCount = {0}, weaponSkillCount = {1} @ 0x92eabd8
00685F070  bl       #0x382bd14 ; 
00685F074  mov      w8, #1
00685F078  strb     w8, [x20, #0xa03]
00685F07C  ldr      x4, [x21]
00685F080  ldrb     w8, [x4, #0x53]
00685F084  tbnz     w8, #5, #0x685f3fc
00685F088  mov      x0, x19
00685F08C  bl       #0x685db38 ; HotFix.BattleLogic.DankeSkillCreator$$GetPassiveCanStudyCount
00685F090  str      w0, [x24]
00685F094  mov      x0, x19
00685F098  bl       #0x685d8a4 ; HotFix.BattleLogic.DankeSkillCreator$$GetCanStudyCount
00685F09C  str      x23, [sp, #0x10]
00685F0A0  str      w0, [x23]
00685F0A4  adrp     x8, #0x8f09000
00685F0A8  ldr      x8, [x8, #0x9b8] ; GLOBAL ListPool<int>_TypeInfo @ 0x91d8fc0
00685F0AC  ldr      x0, [x8]
00685F0B0  ldr      w8, [x0, #0xe0]
00685F0B4  cbnz     w8, #0x685f0bc
00685F0B8  bl       #0x382be8c ; 
00685F0BC  str      x24, [sp, #8]
00685F0C0  adrp     x8, #0x8f09000
00685F0C4  ldr      x8, [x8, #0x9a8] ; GLOBAL Method$ListPool<int>.Get() @ 0x9218bd0
00685F0C8  ldr      x0, [x8]
00685F0CC  bl       #0x4b686ec ; ListPool<int>$$Get
00685F0D0  cbz      x22, #0x685f430
00685F0D4  ldr      w8, [x22, #0x18]
00685F0D8  mov      x23, x0
00685F0DC  cmp      w8, #1
00685F0E0  b.lt     #0x685f304
00685F0E4  adrp     x25, #0x8f06000
00685F0E8  adrp     x26, #0x8f09000
00685F0EC  adrp     x27, #0x8f09000
00685F0F0  ldr      x25, [x25, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685F0F4  ldr      x26, [x26, #0x8c0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_IsBattleSkill() @ 0x92ac440
00685F0F8  ldr      x27, [x27, #0xd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_BattleSkillGroup() @ 0x92ac408
00685F0FC  mov      w24, wzr
00685F100  adrp     x29, #0x9598000
00685F104  adrp     x20, #0x9599000
00685F108  adrp     x21, #0x9599000
00685F10C  mov      x0, x19
00685F110  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685F114  cbz      x0, #0x685f430
00685F118  ldrb     w8, [x29, #0xfcc]
00685F11C  mov      x28, x0
00685F120  cbnz     w8, #0x685f134
00685F124  mov      x0, x25
00685F128  bl       #0x382bd14 ; 
00685F12C  mov      w8, #1
00685F130  strb     w8, [x29, #0xfcc]
00685F134  ldr      x1, [x25]
00685F138  ldrb     w8, [x1, #0x53]
00685F13C  tbnz     w8, #5, #0x685f148
00685F140  ldr      x28, [x28, #0x200]
00685F144  b        #0x685f158 ; 
00685F148  ldr      x8, [x1, #0x60]
00685F14C  mov      x0, x28
00685F150  blr      x8
00685F154  mov      x28, x0
00685F158  adrp     x8, #0x8ec2000
00685F15C  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00685F160  mov      x0, x22
00685F164  mov      w1, w24
00685F168  ldr      x2, [x8]
00685F16C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00685F170  cbz      x28, #0x685f430
00685F174  mov      w1, w0
00685F178  mov      x0, x28
00685F17C  mov      x2, xzr
00685F180  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00685F184  cbz      x0, #0x685f430
00685F188  ldrb     w8, [x20, #0x4dc]
00685F18C  mov      x28, x0
00685F190  cbnz     w8, #0x685f1a4
00685F194  mov      x0, x26
00685F198  bl       #0x382bd14 ; 
00685F19C  mov      w8, #1
00685F1A0  strb     w8, [x20, #0x4dc]
00685F1A4  ldr      x1, [x26]
00685F1A8  ldrb     w8, [x1, #0x53]
00685F1AC  tbnz     w8, #5, #0x685f1b8
00685F1B0  ldr      w0, [x28, #0x24]
00685F1B4  b        #0x685f1c4 ; 
00685F1B8  ldr      x8, [x1, #0x60]
00685F1BC  mov      x0, x28
00685F1C0  blr      x8
00685F1C4  cmp      w0, #1
00685F1C8  b.ne     #0x685f2f4
00685F1CC  ldrb     w8, [x21, #0x4c8]
00685F1D0  cbnz     w8, #0x685f1e4
00685F1D4  mov      x0, x27
00685F1D8  bl       #0x382bd14 ; 
00685F1DC  mov      w8, #1
00685F1E0  strb     w8, [x21, #0x4c8]
00685F1E4  ldr      x1, [x27]
00685F1E8  ldrb     w8, [x1, #0x53]
00685F1EC  tbnz     w8, #5, #0x685f1f8
00685F1F0  ldr      w1, [x28, #0x120]
00685F1F4  b        #0x685f208 ; 
00685F1F8  ldr      x8, [x1, #0x60]
00685F1FC  mov      x0, x28
00685F200  blr      x8
00685F204  mov      w1, w0
00685F208  cbz      x23, #0x685f430
00685F20C  adrp     x8, #0x8f08000
00685F210  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00685F214  mov      x0, x23
00685F218  ldr      x2, [x8]
00685F21C  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
00685F220  tbnz     w0, #0, #0x685f2f4
00685F224  ldrb     w8, [x21, #0x4c8]
00685F228  cbnz     w8, #0x685f23c
00685F22C  mov      x0, x27
00685F230  bl       #0x382bd14 ; 
00685F234  mov      w8, #1
00685F238  strb     w8, [x21, #0x4c8]
00685F23C  ldr      x1, [x27]
00685F240  ldrb     w8, [x1, #0x53]
00685F244  tbnz     w8, #5, #0x685f250
00685F248  ldr      w1, [x28, #0x120]
00685F24C  b        #0x685f260 ; 
00685F250  ldr      x8, [x1, #0x60]
00685F254  mov      x0, x28
00685F258  blr      x8
00685F25C  mov      w1, w0
00685F260  adrp     x9, #0x8ec2000
00685F264  ldr      w10, [x23, #0x1c]
00685F268  ldr      x8, [x23, #0x10]
00685F26C  ldr      x9, [x9, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
00685F270  add      w10, w10, #1
00685F274  ldr      x9, [x9]
00685F278  str      w10, [x23, #0x1c]
00685F27C  cbz      x8, #0x685f430
00685F280  ldrsw    x10, [x23, #0x18]
00685F284  ldr      w11, [x8, #0x18]
00685F288  cmp      w10, w11
00685F28C  b.hs     #0x685f2a4
00685F290  add      w9, w10, #1
00685F294  add      x8, x8, x10, lsl #2
00685F298  str      w9, [x23, #0x18]
00685F29C  str      w1, [x8, #0x20]
00685F2A0  b        #0x685f2b8 ; 
00685F2A4  ldr      x8, [x9, #0x20]
00685F2A8  mov      x0, x23
00685F2AC  ldr      x8, [x8, #0xc0]
00685F2B0  ldr      x2, [x8, #0x70]
00685F2B4  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
00685F2B8  mov      x0, x28
00685F2BC  mov      w1, wzr
00685F2C0  mov      x2, xzr
00685F2C4  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
00685F2C8  sub      w8, w0, #2
00685F2CC  cmp      w8, #2
00685F2D0  b.hs     #0x685f2dc
00685F2D4  ldr      x9, [sp, #0x10]
00685F2D8  b        #0x685f2e8 ; 
00685F2DC  cmp      w0, #1
00685F2E0  b.ne     #0x685f2f4
00685F2E4  ldr      x9, [sp, #8]
00685F2E8  ldr      w8, [x9]
00685F2EC  sub      w8, w8, #1
00685F2F0  str      w8, [x9]
00685F2F4  ldr      w8, [x22, #0x18]
00685F2F8  add      w24, w24, #1
00685F2FC  cmp      w24, w8
00685F300  b.lt     #0x685f10c
00685F304  adrp     x8, #0x8f09000
00685F308  ldr      x8, [x8, #0x9b8] ; GLOBAL ListPool<int>_TypeInfo @ 0x91d8fc0
00685F30C  ldr      x0, [x8]
00685F310  ldr      w8, [x0, #0xe0]
00685F314  cbnz     w8, #0x685f31c
00685F318  bl       #0x382be8c ; 
00685F31C  adrp     x8, #0x8f09000
00685F320  ldr      x8, [x8, #0x9b0] ; GLOBAL Method$ListPool<int>.Release() @ 0x9218bd8
00685F324  mov      x0, x23
00685F328  ldr      x1, [x8]
00685F32C  bl       #0x4b687a0 ; ListPool<int>$$Release
00685F330  adrp     x8, #0x8ebf000
00685F334  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685F338  ldr      x20, [sp, #8]
00685F33C  ldr      x0, [x8]
00685F340  ldr      w22, [x20]
00685F344  ldr      w8, [x0, #0xe0]
00685F348  cbnz     w8, #0x685f350
00685F34C  bl       #0x382be8c ; 
00685F350  mov      w0, w22
00685F354  mov      w1, wzr
00685F358  mov      x2, xzr
00685F35C  bl       #0x7bd6858 ; System.Math$$Max
00685F360  ldr      x22, [sp, #0x10]
00685F364  str      w0, [x20]
00685F368  mov      w1, wzr
00685F36C  mov      x2, xzr
00685F370  ldr      w0, [x22]
00685F374  bl       #0x7bd6858 ; System.Math$$Max
00685F378  str      w0, [x22]
00685F37C  ldr      w8, [x20]
00685F380  adrp     x20, #0x8ebf000
00685F384  ldr      x20, [x20, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685F388  add      x1, sp, #0x1c
00685F38C  str      w8, [sp, #0x1c]
00685F390  ldr      x0, [x20]
00685F394  bl       #0x382be94 ; 
00685F398  mov      x21, x0
00685F39C  ldr      w8, [x22]
00685F3A0  ldr      x0, [x20]
00685F3A4  add      x1, sp, #0x18
00685F3A8  str      w8, [sp, #0x18]
00685F3AC  bl       #0x382be94 ; 
00685F3B0  adrp     x8, #0x8f23000
00685F3B4  ldr      x8, [x8, #0xc00] ; GLOBAL -[RandomSkill]-[Danke]  passiveSkillCount = {0}, weaponSkillCount = {1} @ 0x92eabd8
00685F3B8  mov      x2, x0
00685F3BC  mov      x1, x21
00685F3C0  mov      x3, xzr
00685F3C4  ldr      x8, [x8]
00685F3C8  mov      x0, x8
00685F3CC  bl       #0x79e2794 ; System.String$$Format
00685F3D0  mov      x1, x0
00685F3D4  mov      x0, x19
00685F3D8  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685F3DC  ldp      x20, x19, [sp, #0x70]
00685F3E0  ldp      x22, x21, [sp, #0x60]
00685F3E4  ldp      x24, x23, [sp, #0x50]
00685F3E8  ldp      x26, x25, [sp, #0x40]
00685F3EC  ldp      x28, x27, [sp, #0x30]
00685F3F0  ldp      x29, x30, [sp, #0x20]
00685F3F4  add      sp, sp, #0x80
00685F3F8  ret      
00685F3FC  ldr      x5, [x4, #0x60]
00685F400  mov      x0, x19
00685F404  mov      x1, x22
00685F408  mov      x2, x24
00685F40C  mov      x3, x23
00685F410  ldp      x20, x19, [sp, #0x70]
00685F414  ldp      x22, x21, [sp, #0x60]
00685F418  ldp      x24, x23, [sp, #0x50]
00685F41C  ldp      x26, x25, [sp, #0x40]
00685F420  ldp      x28, x27, [sp, #0x30]
00685F424  ldp      x29, x30, [sp, #0x20]
00685F428  add      sp, sp, #0x80
00685F42C  br       x5
00685F430  bl       #0x382bfb8 ; 

