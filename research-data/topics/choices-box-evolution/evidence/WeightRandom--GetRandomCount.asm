; HotFix.BattleLogic.WeightRandom$$GetRandomCount
; RVA 0x6633C0C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006633C0C  stp      x29, x30, [sp, #-0x60]!
006633C10  stp      x28, x27, [sp, #0x10]
006633C14  stp      x26, x25, [sp, #0x20]
006633C18  stp      x24, x23, [sp, #0x30]
006633C1C  stp      x22, x21, [sp, #0x40]
006633C20  stp      x20, x19, [sp, #0x50]
006633C24  sub      sp, sp, #0x1d0
006633C28  adrp     x21, #0x9599000
006633C2C  adrp     x22, #0x8f0d000
006633C30  ldrb     w8, [x21, #0x9e6]
006633C34  ldr      x22, [x22] ; GLOBAL Method$HotFix.BattleLogic.WeightRandom.GetRandomCount() @ 0x92cba78
006633C38  mov      x25, x4
006633C3C  mov      x26, x3
006633C40  mov      x19, x2
006633C44  mov      w27, w1
006633C48  mov      x20, x0
006633C4C  tbnz     w8, #0, #0x6633cdc
006633C50  adrp     x0, #0x8ebf000
006633C54  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006633C58  bl       #0x382bd14 ; 
006633C5C  adrp     x0, #0x8ec2000
006633C60  ldr      x0, [x0, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006633C64  bl       #0x382bd14 ; 
006633C68  adrp     x0, #0x8f08000
006633C6C  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006633C70  bl       #0x382bd14 ; 
006633C74  adrp     x0, #0x8ee1000
006633C78  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006633C7C  bl       #0x382bd14 ; 
006633C80  adrp     x0, #0x8ec2000
006633C84  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
006633C88  bl       #0x382bd14 ; 
006633C8C  adrp     x0, #0x8f0d000
006633C90  ldr      x0, [x0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandom.GetRandomCount() @ 0x92cba78
006633C94  bl       #0x382bd14 ; 
006633C98  adrp     x0, #0x8f0d000
006633C9C  ldr      x0, [x0, #8]
006633CA0  bl       #0x382bd14 ; 
006633CA4  adrp     x0, #0x8f0c000
006633CA8  ldr      x0, [x0, #0xff8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\BehaviorTree\Wait\WeightRandom.cs @ 0x92f7e70
006633CAC  bl       #0x382bd14 ; 
006633CB0  adrp     x0, #0x8f0d000
006633CB4  ldr      x0, [x0, #0x10] ; GLOBAL GetRandomCount @ 0x92fed40
006633CB8  bl       #0x382bd14 ; 
006633CBC  adrp     x0, #0x8f0d000
006633CC0  ldr      x0, [x0, #0x18] ; GLOBAL -[RandomSkill]-ran = {0} id = {1} weight = {2} @ 0x92eabf8
006633CC4  bl       #0x382bd14 ; 
006633CC8  adrp     x0, #0x8f0d000
006633CCC  ldr      x0, [x0, #0x20] ; GLOBAL GetRandomCount   没有添加成功!! @ 0x92fed48
006633CD0  bl       #0x382bd14 ; 
006633CD4  mov      w8, #1
006633CD8  strb     w8, [x21, #0x9e6]
006633CDC  ldr      x5, [x22]
006633CE0  ldrb     w8, [x5, #0x53]
006633CE4  tbnz     w8, #5, #0x6633dac
006633CE8  movi     v0.2d, #0000000000000000
006633CEC  str      xzr, [sp, #0x1c0]
006633CF0  str      xzr, [sp, #0x180]
006633CF4  str      xzr, [sp, #0x140]
006633CF8  stp      q0, q0, [sp, #0x1a0]
006633CFC  str      q0, [sp, #0x190]
006633D00  stp      q0, q0, [sp, #0x160]
006633D04  str      q0, [sp, #0x150]
006633D08  stp      q0, q0, [sp, #0x120]
006633D0C  str      q0, [sp, #0x110]
006633D10  ldr      w24, [x20, #0x30]
006633D14  cmp      w24, #1
006633D18  b.lt     #0x6633de4
006633D1C  adrp     x23, #0x8f08000
006633D20  ldr      x23, [x23, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006633D24  mov      x21, xzr
006633D28  mov      w28, wzr
006633D2C  mov      w22, #0x20
006633D30  ldr      x8, [x20, #0x40]
006633D34  cbz      x8, #0x66345a0
006633D38  ldr      w9, [x8, #0x18]
006633D3C  cmp      x21, x9
006633D40  b.hs     #0x66345a4
006633D44  cbz      x19, #0x66345a0
006633D48  ldr      w1, [x8, x22]
006633D4C  ldr      x2, [x23]
006633D50  mov      x0, x19
006633D54  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006633D58  tbnz     w0, #0, #0x6633d98
006633D5C  ldr      x8, [x20, #0x40]
006633D60  cbz      x8, #0x66345a0
006633D64  ldr      w9, [x8, #0x18]
006633D68  cmp      x21, x9
006633D6C  b.hs     #0x66345a4
006633D70  add      x8, x8, x22
006633D74  ldr      x9, [x8, #0x30]
006633D78  ldp      q1, q0, [x8, #0x10]
006633D7C  ldr      q2, [x8]
006633D80  add      x0, sp, #0x190
006633D84  str      x9, [sp, #0x1c0]
006633D88  stp      q1, q0, [sp, #0x1a0]
006633D8C  str      q2, [sp, #0x190]
006633D90  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006633D94  add      w28, w0, w28
006633D98  add      x21, x21, #1
006633D9C  cmp      x24, x21
006633DA0  add      x22, x22, #0x38
006633DA4  b.ne     #0x6633d30
006633DA8  b        #0x6633de8 ; 
006633DAC  ldr      x6, [x5, #0x60]
006633DB0  mov      x0, x20
006633DB4  mov      w1, w27
006633DB8  mov      x2, x19
006633DBC  mov      x3, x26
006633DC0  mov      x4, x25
006633DC4  add      sp, sp, #0x1d0
006633DC8  ldp      x20, x19, [sp, #0x50]
006633DCC  ldp      x22, x21, [sp, #0x40]
006633DD0  ldp      x24, x23, [sp, #0x30]
006633DD4  ldp      x26, x25, [sp, #0x20]
006633DD8  ldp      x28, x27, [sp, #0x10]
006633DDC  ldp      x29, x30, [sp], #0x60
006633DE0  br       x6
006633DE4  mov      w28, wzr
006633DE8  cmp      w27, #1
006633DEC  stp      x26, x25, [sp, #0x10]
006633DF0  b.lt     #0x6634580
006633DF4  adrp     x26, #0x8ebf000
006633DF8  ldr      x26, [x26, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006633DFC  mov      w22, w28
006633E00  mov      w21, wzr
006633E04  str      w27, [sp, #0x2c]
006633E08  adrp     x8, #0x9591000
006633E0C  ldrb     w8, [x8, #0xa4b]
006633E10  cbnz     w8, #0x6633e2c
006633E14  adrp     x0, #0x8ee5000
006633E18  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006633E1C  bl       #0x382bd14 ; 
006633E20  adrp     x8, #0x9591000
006633E24  mov      w9, #1
006633E28  strb     w9, [x8, #0xa4b]
006633E2C  str      w21, [sp, #0x30]
006633E30  adrp     x8, #0x8ee5000
006633E34  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006633E38  ldr      x1, [x8]
006633E3C  ldrb     w8, [x1, #0x53]
006633E40  tbnz     w8, #5, #0x6633e4c
006633E44  ldr      x28, [x20, #0x20]
006633E48  b        #0x6633e5c ; 
006633E4C  ldr      x8, [x1, #0x60]
006633E50  mov      x0, x20
006633E54  blr      x8
006633E58  mov      x28, x0
006633E5C  cbz      x28, #0x66345a0
006633E60  adrp     x8, #0x9599000
006633E64  ldrb     w8, [x8, #0xac6]
006633E68  cbnz     w8, #0x6633e84
006633E6C  adrp     x0, #0x8f0d000
006633E70  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006633E74  bl       #0x382bd14 ; 
006633E78  mov      w8, #1
006633E7C  adrp     x9, #0x9599000
006633E80  strb     w8, [x9, #0xac6]
006633E84  adrp     x8, #0x8f0d000
006633E88  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006633E8C  ldr      x3, [x8]
006633E90  ldrb     w8, [x3, #0x53]
006633E94  tbnz     w8, #5, #0x6633ed8
006633E98  adrp     x8, #0x9599000
006633E9C  ldrb     w8, [x8, #0xac7]
006633EA0  cbnz     w8, #0x6633ebc
006633EA4  adrp     x0, #0x8f0d000
006633EA8  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006633EAC  bl       #0x382bd14 ; 
006633EB0  mov      w8, #1
006633EB4  adrp     x9, #0x9599000
006633EB8  strb     w8, [x9, #0xac7]
006633EBC  adrp     x8, #0x8f0d000
006633EC0  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006633EC4  ldr      x1, [x8]
006633EC8  ldrb     w8, [x1, #0x53]
006633ECC  tbnz     w8, #5, #0x6633ef4
006633ED0  ldr      x0, [x28, #0x260]
006633ED4  b        #0x6633f00 ; 
006633ED8  ldr      x8, [x3, #0x60]
006633EDC  mov      w1, #1
006633EE0  mov      x0, x28
006633EE4  mov      w2, w22
006633EE8  blr      x8
006633EEC  mov      w29, w0
006633EF0  b        #0x6633f24 ; 
006633EF4  ldr      x8, [x1, #0x60]
006633EF8  mov      x0, x28
006633EFC  blr      x8
006633F00  cbz      x0, #0x66345a0
006633F04  mov      w1, #1
006633F08  mov      w2, w22
006633F0C  mov      x3, xzr
006633F10  bl       #0x416d068 ; XXRandom$$Next
006633F14  ldr      w8, [x28, #0x32c]
006633F18  mov      w29, w0
006633F1C  add      w8, w8, #1
006633F20  str      w8, [x28, #0x32c]
006633F24  adrp     x8, #0x8ec2000
006633F28  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
006633F2C  mov      w1, #4
006633F30  ldr      x0, [x8]
006633F34  bl       #0x382bdfc ; 
006633F38  mov      x28, x0
006633F3C  ldr      x0, [x26]
006633F40  add      x1, sp, #0xc0
006633F44  str      w29, [sp, #0xc0]
006633F48  bl       #0x382be94 ; 
006633F4C  cbz      x28, #0x66345a0
006633F50  mov      x21, x0
006633F54  cbz      x0, #0x6633f6c
006633F58  ldr      x8, [x28]
006633F5C  mov      x0, x21
006633F60  ldr      x1, [x8, #0x40]
006633F64  bl       #0x382be90 ; 
006633F68  cbz      x0, #0x66345a8
006633F6C  ldr      w8, [x28, #0x18]
006633F70  cbz      w8, #0x66345a4
006633F74  mov      x0, x28
006633F78  str      x21, [x0, #0x20]!
006633F7C  mov      x1, x21
006633F80  bl       #0x382bcb8 ; 
006633F84  ldr      x0, [x26]
006633F88  add      x1, sp, #0x10c
006633F8C  str      w22, [sp, #0x10c]
006633F90  bl       #0x382be94 ; 
006633F94  mov      x21, x0
006633F98  cbz      x0, #0x6633fb0
006633F9C  ldr      x8, [x28]
006633FA0  mov      x0, x21
006633FA4  ldr      x1, [x8, #0x40]
006633FA8  bl       #0x382be90 ; 
006633FAC  cbz      x0, #0x66345a8
006633FB0  ldr      w8, [x28, #0x18]
006633FB4  cmp      w8, #1
006633FB8  b.ls     #0x66345a4
006633FBC  mov      x0, x28
006633FC0  str      x21, [x0, #0x28]!
006633FC4  mov      x1, x21
006633FC8  bl       #0x382bcb8 ; 
006633FCC  ldr      x0, [x26]
006633FD0  add      x1, sp, #0x108
006633FD4  str      w27, [sp, #0x108]
006633FD8  bl       #0x382be94 ; 
006633FDC  mov      x21, x0
006633FE0  cbz      x0, #0x6633ff8
006633FE4  ldr      x8, [x28]
006633FE8  mov      x0, x21
006633FEC  ldr      x1, [x8, #0x40]
006633FF0  bl       #0x382be90 ; 
006633FF4  cbz      x0, #0x66345a8
006633FF8  ldr      w8, [x28, #0x18]
006633FFC  cmp      w8, #2
006634000  b.ls     #0x66345a4
006634004  mov      x0, x28
006634008  str      x21, [x0, #0x30]!
00663400C  mov      x1, x21
006634010  bl       #0x382bcb8 ; 
006634014  ldr      x0, [x26]
006634018  add      x1, sp, #0x104
00663401C  str      w24, [sp, #0x104]
006634020  bl       #0x382be94 ; 
006634024  mov      x21, x0
006634028  cbz      x0, #0x6634040
00663402C  ldr      x8, [x28]
006634030  mov      x0, x21
006634034  ldr      x1, [x8, #0x40]
006634038  bl       #0x382be90 ; 
00663403C  cbz      x0, #0x66345a8
006634040  ldr      w8, [x28, #0x18]
006634044  str      w22, [sp, #0x34]
006634048  cmp      w8, #3
00663404C  b.ls     #0x66345a4
006634050  mov      x0, x28
006634054  str      x21, [x0, #0x38]!
006634058  mov      x1, x21
00663405C  bl       #0x382bcb8 ; 
006634060  adrp     x8, #0x8f0d000
006634064  ldr      x8, [x8, #8]
006634068  mov      x1, x28
00663406C  mov      x2, xzr
006634070  ldr      x0, [x8]
006634074  bl       #0x79e281c ; System.String$$Format
006634078  mov      x1, x0
00663407C  mov      x0, x20
006634080  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634084  subs     w8, w24, #1
006634088  str      x24, [sp, #0x38]
00663408C  str      x8, [sp, #0x20]
006634090  b.lt     #0x663416c
006634094  ldr      x8, [sp, #0x38]
006634098  mov      x25, xzr
00663409C  mov      w24, #0x20
0066340A0  mov      w23, w8
0066340A4  ldr      x27, [x20, #0x40]
0066340A8  cbz      x27, #0x66345a0
0066340AC  ldr      w8, [x27, #0x18]
0066340B0  cmp      x25, x8
0066340B4  b.hs     #0x66345a4
0066340B8  add      x21, x27, x24
0066340BC  mov      x0, x21
0066340C0  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066340C4  mov      w28, w0
0066340C8  ldr      x0, [x26]
0066340CC  add      x1, sp, #0xc0
0066340D0  str      w29, [sp, #0xc0]
0066340D4  bl       #0x382be94 ; 
0066340D8  mov      x22, x0
0066340DC  ldr      w8, [x21]
0066340E0  ldr      x0, [x26]
0066340E4  add      x1, sp, #0x10c
0066340E8  str      w8, [sp, #0x10c]
0066340EC  bl       #0x382be94 ; 
0066340F0  mov      x21, x0
0066340F4  ldr      x0, [x26]
0066340F8  add      x1, sp, #0x108
0066340FC  str      w28, [sp, #0x108]
006634100  bl       #0x382be94 ; 
006634104  adrp     x8, #0x8f0d000
006634108  ldr      x8, [x8, #0x18] ; GLOBAL -[RandomSkill]-ran = {0} id = {1} weight = {2} @ 0x92eabf8
00663410C  mov      x3, x0
006634110  mov      x1, x22
006634114  mov      x2, x21
006634118  ldr      x8, [x8]
00663411C  mov      x4, xzr
006634120  mov      x0, x8
006634124  bl       #0x79e27d8 ; System.String$$Format
006634128  mov      x1, x0
00663412C  mov      x0, x20
006634130  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634134  cbz      x19, #0x66345a0
006634138  adrp     x8, #0x8f08000
00663413C  ldr      w1, [x27, x24]
006634140  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006634144  mov      x0, x19
006634148  ldr      x2, [x8]
00663414C  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006634150  subs     w29, w29, w28
006634154  b.gt     #0x663415c
006634158  tbz      w0, #0, #0x663420c
00663415C  add      x25, x25, #1
006634160  cmp      x23, x25
006634164  add      x24, x24, #0x38
006634168  b.ne     #0x66340a4
00663416C  adrp     x8, #0x8ee1000
006634170  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006634174  ldr      x0, [x8]
006634178  ldr      w8, [x0, #0xe0]
00663417C  cbnz     w8, #0x6634184
006634180  bl       #0x382be8c ; 
006634184  adrp     x8, #0x8f0d000
006634188  ldr      x8, [x8, #0x20] ; GLOBAL GetRandomCount   没有添加成功!! @ 0x92fed48
00663418C  mov      w3, #0x202
006634190  mov      x4, xzr
006634194  ldr      x0, [x8]
006634198  adrp     x8, #0x8f0d000
00663419C  ldr      x8, [x8, #0x10] ; GLOBAL GetRandomCount @ 0x92fed40
0066341A0  ldr      x1, [x8]
0066341A4  adrp     x8, #0x8f0c000
0066341A8  ldr      x8, [x8, #0xff8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\BehaviorTree\Wait\WeightRandom.cs @ 0x92f7e70
0066341AC  ldr      x2, [x8]
0066341B0  bl       #0x7997754 ; Logger$$LogError
0066341B4  ldr      x8, [x20, #0x40]
0066341B8  ldr      w27, [sp, #0x2c]
0066341BC  ldr      w22, [sp, #0x34]
0066341C0  ldr      x24, [sp, #0x38]
0066341C4  cbz      x8, #0x66345a0
0066341C8  ldr      w9, [x8, #0x18]
0066341CC  cbz      w9, #0x66345a4
0066341D0  add      x28, x8, #0x20
0066341D4  mov      x0, x28
0066341D8  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066341DC  cbz      x19, #0x66345a0
0066341E0  adrp     x8, #0x8f08000
0066341E4  ldr      w1, [x28]
0066341E8  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
0066341EC  mov      w21, w0
0066341F0  mov      x0, x19
0066341F4  ldr      x2, [x8]
0066341F8  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0066341FC  cmp      w21, #1
006634200  b.lt     #0x6634434
006634204  tbnz     w0, #0, #0x6634434
006634208  b        #0x6634448 ; 
00663420C  ldr      x8, [x20, #0x40]
006634210  cbz      x8, #0x66345a0
006634214  ldr      w10, [x8, #0x18]
006634218  cmp      w25, w10
00663421C  b.hs     #0x66345a4
006634220  add      x9, x8, x24
006634224  ldr      x11, [sp, #0x38]
006634228  ldr      w29, [x27, x24]
00663422C  ldp      q0, q1, [x9]
006634230  ldr      x12, [x9, #0x30]
006634234  ldr      q2, [x9, #0x20]
006634238  ldr      w22, [sp, #0x34]
00663423C  sxtw     x11, w11
006634240  sub      x24, x11, #1
006634244  cmp      w24, w10
006634248  str      x12, [sp, #0x180]
00663424C  stp      q1, q2, [sp, #0x160]
006634250  str      q0, [sp, #0x150]
006634254  b.hs     #0x66345a4
006634258  mov      w10, #0x38
00663425C  madd     x8, x24, x10, x8
006634260  ldr      x10, [x8, #0x50]
006634264  ldp      q1, q0, [x8, #0x30]
006634268  ldr      q2, [x8, #0x20]
00663426C  add      x0, x9, #0x10
006634270  mov      x1, xzr
006634274  str      x10, [x9, #0x30]
006634278  stp      q1, q0, [x9, #0x10]
00663427C  str      q2, [x9]
006634280  bl       #0x382bcb8 ; 
006634284  ldr      x8, [x20, #0x40]
006634288  ldp      q0, q1, [sp, #0x150]
00663428C  ldr      q2, [sp, #0x170]
006634290  ldr      x9, [sp, #0x180]
006634294  ldr      w27, [sp, #0x2c]
006634298  stp      q0, q1, [sp, #0xc0]
00663429C  str      q2, [sp, #0xe0]
0066342A0  str      x9, [sp, #0xf0]
0066342A4  cbz      x8, #0x66345a0
0066342A8  ldp      q0, q1, [sp, #0xc0]
0066342AC  ldr      q2, [sp, #0xe0]
0066342B0  ldr      x9, [sp, #0xf0]
0066342B4  stp      q0, q1, [sp, #0x80]
0066342B8  str      q2, [sp, #0xa0]
0066342BC  str      x9, [sp, #0xb0]
0066342C0  ldr      w9, [x8, #0x18]
0066342C4  cmp      w24, w9
0066342C8  b.hs     #0x66345a4
0066342CC  ldp      q2, q0, [sp, #0x90]
0066342D0  ldr      x9, [sp, #0xb0]
0066342D4  ldr      q1, [sp, #0x80]
0066342D8  mov      w10, #0x38
0066342DC  madd     x8, x24, x10, x8
0066342E0  add      x0, x8, #0x30
0066342E4  mov      x1, xzr
0066342E8  str      x9, [x8, #0x50]
0066342EC  stp      q2, q0, [x8, #0x30]
0066342F0  str      q1, [x8, #0x20]
0066342F4  bl       #0x382bcb8 ; 
0066342F8  adrp     x8, #0x9591000
0066342FC  ldrb     w8, [x8, #0xa4b]
006634300  cbnz     w8, #0x663431c
006634304  adrp     x0, #0x8ee5000
006634308  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00663430C  bl       #0x382bd14 ; 
006634310  adrp     x8, #0x9591000
006634314  mov      w9, #1
006634318  strb     w9, [x8, #0xa4b]
00663431C  adrp     x8, #0x8ee5000
006634320  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006634324  ldr      x1, [x8]
006634328  ldrb     w8, [x1, #0x53]
00663432C  tbnz     w8, #5, #0x6634338
006634330  ldr      x21, [x20, #0x20]
006634334  b        #0x6634348 ; 
006634338  ldr      x8, [x1, #0x60]
00663433C  mov      x0, x20
006634340  blr      x8
006634344  mov      x21, x0
006634348  cbz      x21, #0x66345a0
00663434C  adrp     x8, #0x9598000
006634350  ldrb     w8, [x8, #0xfcc]
006634354  cbnz     w8, #0x6634370
006634358  adrp     x0, #0x8f06000
00663435C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006634360  bl       #0x382bd14 ; 
006634364  mov      w8, #1
006634368  adrp     x9, #0x9598000
00663436C  strb     w8, [x9, #0xfcc]
006634370  adrp     x8, #0x8f06000
006634374  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006634378  ldr      x1, [x8]
00663437C  ldrb     w8, [x1, #0x53]
006634380  tbnz     w8, #5, #0x663438c
006634384  ldr      x0, [x21, #0x200]
006634388  b        #0x6634398 ; 
00663438C  ldr      x8, [x1, #0x60]
006634390  mov      x0, x21
006634394  blr      x8
006634398  cbz      x0, #0x66345a0
00663439C  mov      w1, w29
0066343A0  mov      x2, xzr
0066343A4  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0066343A8  cbz      x0, #0x66345a0
0066343AC  mov      x1, xzr
0066343B0  bl       #0x6b0a2d4 ; LocalModels.Bean.Skill_Main$$GetIsUpgrade
0066343B4  cmp      w0, #2
0066343B8  b.ne     #0x66343d4
0066343BC  ldp      x3, x4, [sp, #0x10]
0066343C0  mov      x0, x20
0066343C4  mov      w1, w29
0066343C8  mov      x2, x19
0066343CC  bl       #0x66346a0 ; HotFix.BattleLogic.WeightRandom$$RandomOneSubSkillByParent
0066343D0  b        #0x6634434 ; 
0066343D4  adrp     x9, #0x8ec2000
0066343D8  ldr      w10, [x19, #0x1c]
0066343DC  ldr      x8, [x19, #0x10]
0066343E0  ldr      x9, [x9, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
0066343E4  add      w10, w10, #1
0066343E8  ldr      x9, [x9]
0066343EC  str      w10, [x19, #0x1c]
0066343F0  cbz      x8, #0x66345a0
0066343F4  ldrsw    x10, [x19, #0x18]
0066343F8  ldr      w11, [x8, #0x18]
0066343FC  sub      w22, w22, w28
006634400  cmp      w10, w11
006634404  b.hs     #0x663441c
006634408  add      w9, w10, #1
00663440C  add      x8, x8, x10, lsl #2
006634410  str      w9, [x19, #0x18]
006634414  str      w29, [x8, #0x20]
006634418  b        #0x6634434 ; 
00663441C  ldr      x8, [x9, #0x20]
006634420  mov      x0, x19
006634424  mov      w1, w29
006634428  ldr      x8, [x8, #0xc0]
00663442C  ldr      x2, [x8, #0x70]
006634430  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006634434  ldr      w21, [sp, #0x30]
006634438  add      w21, w21, #1
00663443C  cmp      w21, w27
006634440  b.ne     #0x6633e08
006634444  b        #0x6634580 ; 
006634448  ldr      x8, [x20, #0x40]
00663444C  cbz      x8, #0x66345a0
006634450  ldr      w9, [x8, #0x18]
006634454  ldr      x11, [sp, #0x20]
006634458  cbz      w9, #0x66345a4
00663445C  ldr      w21, [x28]
006634460  ldp      q2, q0, [x8, #0x30]
006634464  ldr      x10, [x8, #0x50]
006634468  ldr      q1, [x8, #0x20]
00663446C  cmp      w11, w9
006634470  stp      q2, q0, [sp, #0x120]
006634474  str      x10, [sp, #0x140]
006634478  str      q1, [sp, #0x110]
00663447C  b.hs     #0x66345a4
006634480  sxtw     x22, w11
006634484  mov      w9, #0x38
006634488  madd     x9, x22, x9, x8
00663448C  ldp      q2, q0, [x9, #0x30]
006634490  ldr      x10, [x9, #0x50]
006634494  ldr      q1, [x9, #0x20]
006634498  add      x9, x8, #0x20
00663449C  add      x0, x8, #0x30
0066344A0  mov      x1, xzr
0066344A4  str      x10, [x9, #0x30]
0066344A8  stp      q2, q0, [x9, #0x10]
0066344AC  str      q1, [x9]
0066344B0  bl       #0x382bcb8 ; 
0066344B4  ldr      x8, [x20, #0x40]
0066344B8  ldp      q0, q1, [sp, #0x110]
0066344BC  ldr      q2, [sp, #0x130]
0066344C0  ldr      x9, [sp, #0x140]
0066344C4  stp      q0, q1, [sp, #0xc0]
0066344C8  str      q2, [sp, #0xe0]
0066344CC  str      x9, [sp, #0xf0]
0066344D0  cbz      x8, #0x66345a0
0066344D4  ldp      q0, q1, [sp, #0xc0]
0066344D8  ldr      q2, [sp, #0xe0]
0066344DC  ldr      x9, [sp, #0xf0]
0066344E0  stp      q0, q1, [sp, #0x40]
0066344E4  str      q2, [sp, #0x60]
0066344E8  str      x9, [sp, #0x70]
0066344EC  ldr      w9, [x8, #0x18]
0066344F0  cmp      w22, w9
0066344F4  b.hs     #0x66345a4
0066344F8  ldp      q2, q0, [sp, #0x50]
0066344FC  ldr      x10, [sp, #0x70]
006634500  ldr      q1, [sp, #0x40]
006634504  mov      w9, #0x38
006634508  madd     x8, x22, x9, x8
00663450C  add      x0, x8, #0x30
006634510  mov      x1, xzr
006634514  str      x10, [x8, #0x50]
006634518  stp      q2, q0, [x8, #0x30]
00663451C  str      q1, [x8, #0x20]
006634520  bl       #0x382bcb8 ; 
006634524  adrp     x9, #0x8ec2000
006634528  ldr      w10, [x19, #0x1c]
00663452C  ldr      x8, [x19, #0x10]
006634530  ldr      x9, [x9, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006634534  add      w10, w10, #1
006634538  ldr      x9, [x9]
00663453C  str      w10, [x19, #0x1c]
006634540  cbz      x8, #0x66345a0
006634544  ldrsw    x10, [x19, #0x18]
006634548  ldr      w11, [x8, #0x18]
00663454C  cmp      w10, w11
006634550  b.hs     #0x6634568
006634554  add      w9, w10, #1
006634558  add      x8, x8, x10, lsl #2
00663455C  str      w9, [x19, #0x18]
006634560  str      w21, [x8, #0x20]
006634564  b        #0x6634580 ; 
006634568  ldr      x8, [x9, #0x20]
00663456C  mov      x0, x19
006634570  mov      w1, w21
006634574  ldr      x8, [x8, #0xc0]
006634578  ldr      x2, [x8, #0x70]
00663457C  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006634580  add      sp, sp, #0x1d0
006634584  ldp      x20, x19, [sp, #0x50]
006634588  ldp      x22, x21, [sp, #0x40]
00663458C  ldp      x24, x23, [sp, #0x30]
006634590  ldp      x26, x25, [sp, #0x20]
006634594  ldp      x28, x27, [sp, #0x10]
006634598  ldp      x29, x30, [sp], #0x60
00663459C  ret      
0066345A0  bl       #0x382bfb8 ; 
0066345A4  bl       #0x382bfc0 ; 
0066345A8  bl       #0x382bfdc ; 
0066345AC  mov      x1, xzr
0066345B0  bl       #0x382be7c ; 

