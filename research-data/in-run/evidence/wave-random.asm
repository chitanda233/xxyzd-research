; HotFix.BattleLogic.WaterfallBattleManager$$CalRandomMonster
; RVA 0x65D2D9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D2D9C  sub      sp, sp, #0x80
0065D2DA0  stp      x29, x30, [sp, #0x20]
0065D2DA4  stp      x28, x27, [sp, #0x30]
0065D2DA8  stp      x26, x25, [sp, #0x40]
0065D2DAC  stp      x24, x23, [sp, #0x50]
0065D2DB0  stp      x22, x21, [sp, #0x60]
0065D2DB4  stp      x20, x19, [sp, #0x70]
0065D2DB8  str      w2, [sp, #0x14]
0065D2DBC  adrp     x19, #0x9599000
0065D2DC0  adrp     x21, #0x8f0a000
0065D2DC4  ldrb     w8, [x19, #0x58e]
0065D2DC8  ldr      x21, [x21, #0xa58]
0065D2DCC  mov      x23, x1
0065D2DD0  mov      x20, x0
0065D2DD4  tbnz     w8, #0, #0x65d2e7c
0065D2DD8  adrp     x0, #0x8f0a000
0065D2DDC  ldr      x0, [x0, #0x9f8]
0065D2DE0  bl       #0x382bd14 ; 
0065D2DE4  adrp     x0, #0x8f0a000
0065D2DE8  ldr      x0, [x0, #0xa00]
0065D2DEC  bl       #0x382bd14 ; 
0065D2DF0  adrp     x0, #0x8f0a000
0065D2DF4  ldr      x0, [x0, #0xa08]
0065D2DF8  bl       #0x382bd14 ; 
0065D2DFC  adrp     x0, #0x8f09000
0065D2E00  ldr      x0, [x0, #0xc08]
0065D2E04  bl       #0x382bd14 ; 
0065D2E08  adrp     x0, #0x8ec2000
0065D2E0C  ldr      x0, [x0, #0x260]
0065D2E10  bl       #0x382bd14 ; 
0065D2E14  adrp     x0, #0x8ec2000
0065D2E18  ldr      x0, [x0, #0x2b8]
0065D2E1C  bl       #0x382bd14 ; 
0065D2E20  adrp     x0, #0x8ec2000
0065D2E24  ldr      x0, [x0, #0x2d0]
0065D2E28  bl       #0x382bd14 ; 
0065D2E2C  adrp     x0, #0x8ee1000
0065D2E30  ldr      x0, [x0, #0x6e8]
0065D2E34  bl       #0x382bd14 ; 
0065D2E38  adrp     x0, #0x8f0a000
0065D2E3C  ldr      x0, [x0, #0xa58]
0065D2E40  bl       #0x382bd14 ; 
0065D2E44  adrp     x0, #0x8f0a000
0065D2E48  ldr      x0, [x0, #0xa10]
0065D2E4C  bl       #0x382bd14 ; 
0065D2E50  adrp     x0, #0x8f0a000
0065D2E54  ldr      x0, [x0, #0x8b8]
0065D2E58  bl       #0x382bd14 ; 
0065D2E5C  adrp     x0, #0x8f0a000
0065D2E60  ldr      x0, [x0, #0xa60]
0065D2E64  bl       #0x382bd14 ; 
0065D2E68  adrp     x0, #0x8f0a000
0065D2E6C  ldr      x0, [x0, #0x980]
0065D2E70  bl       #0x382bd14 ; 
0065D2E74  mov      w8, #1
0065D2E78  strb     w8, [x19, #0x58e]
0065D2E7C  ldr      x3, [x21]
0065D2E80  ldrb     w8, [x3, #0x53]
0065D2E84  tbnz     w8, #5, #0x65d2efc
0065D2E88  adrp     x8, #0x8f0a000
0065D2E8C  ldr      x8, [x8, #0x9f8]
0065D2E90  str      xzr, [sp, #0x18]
0065D2E94  ldr      x0, [x8]
0065D2E98  bl       #0x382bfa0 ; 
0065D2E9C  mov      x21, x0
0065D2EA0  bl       #0x65c7420 ; HotFix.BattleLogic.CalMonsterCountData$$.ctor
0065D2EA4  mov      x0, x20
0065D2EA8  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D2EAC  cbz      x23, #0x65d377c
0065D2EB0  adrp     x24, #0x8f09000
0065D2EB4  ldr      x8, [x23]
0065D2EB8  ldr      x24, [x24, #0xc08]
0065D2EBC  mov      w29, w0
0065D2EC0  ldrh     w9, [x8, #0x12e]
0065D2EC4  ldr      x1, [x24]
0065D2EC8  cbz      x9, #0x65d2eec
0065D2ECC  ldr      x10, [x8, #0xb0]
0065D2ED0  add      x10, x10, #8
0065D2ED4  ldur     x11, [x10, #-8]
0065D2ED8  cmp      x11, x1
0065D2EDC  b.eq     #0x65d2f2c
0065D2EE0  subs     x9, x9, #1
0065D2EE4  add      x10, x10, #0x10
0065D2EE8  b.ne     #0x65d2ed4
0065D2EEC  mov      w2, #0x18
0065D2EF0  mov      x0, x23
0065D2EF4  bl       #0x3a7e710 ; 
0065D2EF8  b        #0x65d2f3c ; 
0065D2EFC  ldr      x4, [x3, #0x60]
0065D2F00  mov      x0, x20
0065D2F04  mov      x1, x23
0065D2F08  ldr      w2, [sp, #0x14]
0065D2F0C  ldp      x20, x19, [sp, #0x70]
0065D2F10  ldp      x22, x21, [sp, #0x60]
0065D2F14  ldp      x24, x23, [sp, #0x50]
0065D2F18  ldp      x26, x25, [sp, #0x40]
0065D2F1C  ldp      x28, x27, [sp, #0x30]
0065D2F20  ldp      x29, x30, [sp, #0x20]
0065D2F24  add      sp, sp, #0x80
0065D2F28  br       x4
0065D2F2C  ldr      w9, [x10]
0065D2F30  add      w9, w9, #0x18
0065D2F34  add      x8, x8, w9, sxtw #4
0065D2F38  add      x0, x8, #0x138
0065D2F3C  ldp      x8, x1, [x0]
0065D2F40  mov      x0, x23
0065D2F44  blr      x8
0065D2F48  cmp      w0, #1
0065D2F4C  b.lt     #0x65d3758
0065D2F50  ldr      x8, [x23]
0065D2F54  ldr      x1, [x24]
0065D2F58  ldrh     w9, [x8, #0x12e]
0065D2F5C  cbz      x9, #0x65d2f80
0065D2F60  ldr      x10, [x8, #0xb0]
0065D2F64  add      x10, x10, #8
0065D2F68  ldur     x11, [x10, #-8]
0065D2F6C  cmp      x11, x1
0065D2F70  b.eq     #0x65d2f90
0065D2F74  subs     x9, x9, #1
0065D2F78  add      x10, x10, #0x10
0065D2F7C  b.ne     #0x65d2f68
0065D2F80  mov      w2, #0x16
0065D2F84  mov      x0, x23
0065D2F88  bl       #0x3a7e710 ; 
0065D2F8C  b        #0x65d2fa0 ; 
0065D2F90  ldr      w9, [x10]
0065D2F94  add      w9, w9, #0x16
0065D2F98  add      x8, x8, w9, sxtw #4
0065D2F9C  add      x0, x8, #0x138
0065D2FA0  ldp      x8, x1, [x0]
0065D2FA4  mov      x0, x23
0065D2FA8  blr      x8
0065D2FAC  cbz      x0, #0x65d3758
0065D2FB0  ldr      x8, [x23]
0065D2FB4  ldr      x1, [x24]
0065D2FB8  ldrh     w9, [x8, #0x12e]
0065D2FBC  cbz      x9, #0x65d2fe0
0065D2FC0  ldr      x10, [x8, #0xb0]
0065D2FC4  add      x10, x10, #8
0065D2FC8  ldur     x11, [x10, #-8]
0065D2FCC  cmp      x11, x1
0065D2FD0  b.eq     #0x65d2ff0
0065D2FD4  subs     x9, x9, #1
0065D2FD8  add      x10, x10, #0x10
0065D2FDC  b.ne     #0x65d2fc8
0065D2FE0  mov      w2, #0x16
0065D2FE4  mov      x0, x23
0065D2FE8  bl       #0x3a7e710 ; 
0065D2FEC  b        #0x65d3000 ; 
0065D2FF0  ldr      w9, [x10]
0065D2FF4  add      w9, w9, #0x16
0065D2FF8  add      x8, x8, w9, sxtw #4
0065D2FFC  add      x0, x8, #0x138
0065D3000  ldp      x8, x1, [x0]
0065D3004  mov      x0, x23
0065D3008  blr      x8
0065D300C  cbz      x0, #0x65d377c
0065D3010  ldr      x8, [x0, #0x18]
0065D3014  cbz      x8, #0x65d3758
0065D3018  ldr      x8, [x23]
0065D301C  ldr      x1, [x24]
0065D3020  ldrh     w9, [x8, #0x12e]
0065D3024  cbz      x9, #0x65d3048
0065D3028  ldr      x10, [x8, #0xb0]
0065D302C  add      x10, x10, #8
0065D3030  ldur     x11, [x10, #-8]
0065D3034  cmp      x11, x1
0065D3038  b.eq     #0x65d3058
0065D303C  subs     x9, x9, #1
0065D3040  add      x10, x10, #0x10
0065D3044  b.ne     #0x65d3030
0065D3048  mov      x0, x23
0065D304C  mov      w2, wzr
0065D3050  bl       #0x3a7e710 ; 
0065D3054  b        #0x65d3064 ; 
0065D3058  ldrsw    x9, [x10]
0065D305C  add      x8, x8, x9, lsl #4
0065D3060  add      x0, x8, #0x138
0065D3064  ldp      x8, x1, [x0]
0065D3068  mov      x0, x23
0065D306C  blr      x8
0065D3070  ldr      x8, [x20, #0x1f0]
0065D3074  cbz      x8, #0x65d377c
0065D3078  adrp     x9, #0x8f0a000
0065D307C  ldr      x9, [x9, #0xa08]
0065D3080  mov      w19, w0
0065D3084  add      x2, sp, #0x18
0065D3088  mov      x0, x8
0065D308C  ldr      x3, [x9]
0065D3090  mov      w1, w19
0065D3094  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
0065D3098  tbnz     w0, #0, #0x65d30d8
0065D309C  adrp     x8, #0x8f0a000
0065D30A0  ldr      x8, [x8, #0xa10]
0065D30A4  ldr      x0, [x8]
0065D30A8  bl       #0x382bfa0 ; 
0065D30AC  mov      x22, x0
0065D30B0  bl       #0x65c74f0 ; HotFix.BattleLogic.WaveMissionRandomData$$.ctor
0065D30B4  str      x22, [sp, #0x18]
0065D30B8  ldr      x0, [x20, #0x1f0]
0065D30BC  cbz      x0, #0x65d377c
0065D30C0  adrp     x8, #0x8f0a000
0065D30C4  ldr      x8, [x8, #0xa00]
0065D30C8  mov      w1, w19
0065D30CC  mov      x2, x22
0065D30D0  ldr      x3, [x8]
0065D30D4  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
0065D30D8  ldr      x19, [sp, #0x18]
0065D30DC  cbz      x19, #0x65d377c
0065D30E0  ldr      x8, [x19, #0x28]!
0065D30E4  cbnz     x8, #0x65d311c
0065D30E8  adrp     x8, #0x8ec2000
0065D30EC  ldr      x8, [x8, #0x2d0]
0065D30F0  ldr      x0, [x8]
0065D30F4  bl       #0x382bfa0 ; 
0065D30F8  adrp     x8, #0x8ec2000
0065D30FC  ldr      x8, [x8, #0x2b8]
0065D3100  mov      x22, x0
0065D3104  ldr      x1, [x8]
0065D3108  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
0065D310C  mov      x0, x19
0065D3110  mov      x1, x22
0065D3114  str      x22, [x19]
0065D3118  bl       #0x382bcb8 ; 
0065D311C  ldr      x8, [x23]
0065D3120  ldr      x1, [x24]
0065D3124  ldrh     w9, [x8, #0x12e]
0065D3128  cbz      x9, #0x65d314c
0065D312C  ldr      x10, [x8, #0xb0]
0065D3130  add      x10, x10, #8
0065D3134  ldur     x11, [x10, #-8]
0065D3138  cmp      x11, x1
0065D313C  b.eq     #0x65d315c
0065D3140  subs     x9, x9, #1
0065D3144  add      x10, x10, #0x10
0065D3148  b.ne     #0x65d3134
0065D314C  mov      w2, #0x18
0065D3150  mov      x0, x23
0065D3154  bl       #0x3a7e710 ; 
0065D3158  b        #0x65d316c ; 
0065D315C  ldr      w9, [x10]
0065D3160  add      w9, w9, #0x18
0065D3164  add      x8, x8, w9, sxtw #4
0065D3168  add      x0, x8, #0x138
0065D316C  ldp      x8, x1, [x0]
0065D3170  mov      x0, x23
0065D3174  blr      x8
0065D3178  ldr      x8, [x23]
0065D317C  ldr      x1, [x24]
0065D3180  str      w0, [sp, #0x10]
0065D3184  ldrh     w9, [x8, #0x12e]
0065D3188  cbz      x9, #0x65d31ac
0065D318C  ldr      x10, [x8, #0xb0]
0065D3190  add      x10, x10, #8
0065D3194  ldur     x11, [x10, #-8]
0065D3198  cmp      x11, x1
0065D319C  b.eq     #0x65d31bc
0065D31A0  subs     x9, x9, #1
0065D31A4  add      x10, x10, #0x10
0065D31A8  b.ne     #0x65d3194
0065D31AC  mov      w2, #0x16
0065D31B0  mov      x0, x23
0065D31B4  bl       #0x3a7e710 ; 
0065D31B8  b        #0x65d31cc ; 
0065D31BC  ldr      w9, [x10]
0065D31C0  add      w9, w9, #0x16
0065D31C4  add      x8, x8, w9, sxtw #4
0065D31C8  add      x0, x8, #0x138
0065D31CC  ldp      x8, x1, [x0]
0065D31D0  mov      x0, x23
0065D31D4  blr      x8
0065D31D8  str      wzr, [sp]
0065D31DC  adrp     x24, #0x8f07000
0065D31E0  adrp     x25, #0x8f06000
0065D31E4  ldr      x24, [x24, #0xc98]
0065D31E8  ldr      x25, [x25, #0x470]
0065D31EC  mov      x23, x0
0065D31F0  adrp     x27, #0x9599000
0065D31F4  mov      w28, #1
0065D31F8  and      w8, w29, #1
0065D31FC  str      w8, [sp, #4]
0065D3200  ldrb     w8, [x27, #0x286]
0065D3204  cbnz     w8, #0x65d3214
0065D3208  mov      x0, x24
0065D320C  bl       #0x382bd14 ; 
0065D3210  strb     w28, [x27, #0x286]
0065D3214  ldr      x1, [x24]
0065D3218  ldrb     w8, [x1, #0x53]
0065D321C  tbnz     w8, #5, #0x65d3228
0065D3220  ldr      x0, [x20, #0x80]
0065D3224  b        #0x65d3234 ; 
0065D3228  ldr      x8, [x1, #0x60]
0065D322C  mov      x0, x20
0065D3230  blr      x8
0065D3234  cbz      x23, #0x65d377c
0065D3238  cbz      x0, #0x65d377c
0065D323C  ldr      w2, [x23, #0x18]
0065D3240  mov      w1, wzr
0065D3244  mov      x3, xzr
0065D3248  bl       #0x54b65d8 ; 
0065D324C  ldr      x8, [sp, #0x18]
0065D3250  cbz      x8, #0x65d377c
0065D3254  mov      w19, w0
0065D3258  ldr      x0, [x8, #0x28]
0065D325C  cbz      x0, #0x65d377c
0065D3260  adrp     x9, #0x8ec2000
0065D3264  ldr      w10, [x0, #0x1c]
0065D3268  ldr      x8, [x0, #0x10]
0065D326C  ldr      x9, [x9, #0x260]
0065D3270  add      w10, w10, #1
0065D3274  ldr      x9, [x9]
0065D3278  str      w10, [x0, #0x1c]
0065D327C  cbz      x8, #0x65d377c
0065D3280  ldrsw    x10, [x0, #0x18]
0065D3284  ldr      w11, [x8, #0x18]
0065D3288  cmp      w10, w11
0065D328C  b.hs     #0x65d32a4
0065D3290  add      w9, w10, #1
0065D3294  add      x8, x8, x10, lsl #2
0065D3298  str      w9, [x0, #0x18]
0065D329C  str      w19, [x8, #0x20]
0065D32A0  b        #0x65d32b8 ; 
0065D32A4  ldr      x8, [x9, #0x20]
0065D32A8  mov      w1, w19
0065D32AC  ldr      x8, [x8, #0xc0]
0065D32B0  ldr      x2, [x8, #0x70]
0065D32B4  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0065D32B8  ldr      w8, [x23, #0x18]
0065D32BC  cmp      w19, w8
0065D32C0  b.hs     #0x65d3780
0065D32C4  add      x8, x23, w19, sxtw #2
0065D32C8  ldrb     w9, [x27, #0x286]
0065D32CC  ldr      w19, [x8, #0x20]
0065D32D0  cbnz     w9, #0x65d32e0
0065D32D4  mov      x0, x24
0065D32D8  bl       #0x382bd14 ; 
0065D32DC  strb     w28, [x27, #0x286]
0065D32E0  ldr      x1, [x24]
0065D32E4  ldrb     w8, [x1, #0x53]
0065D32E8  tbnz     w8, #5, #0x65d32f4
0065D32EC  ldr      x22, [x20, #0x80]
0065D32F0  b        #0x65d3304 ; 
0065D32F4  ldr      x8, [x1, #0x60]
0065D32F8  mov      x0, x20
0065D32FC  blr      x8
0065D3300  mov      x22, x0
0065D3304  cbz      x22, #0x65d377c
0065D3308  adrp     x8, #0x9598000
0065D330C  ldrb     w8, [x8, #0xfcc]
0065D3310  cbnz     w8, #0x65d3324
0065D3314  mov      x0, x25
0065D3318  bl       #0x382bd14 ; 
0065D331C  adrp     x8, #0x9598000
0065D3320  strb     w28, [x8, #0xfcc]
0065D3324  ldr      x1, [x25]
0065D3328  ldrb     w8, [x1, #0x53]
0065D332C  tbnz     w8, #5, #0x65d3338
0065D3330  ldr      x0, [x22, #0x200]
0065D3334  b        #0x65d3344 ; 
0065D3338  ldr      x8, [x1, #0x60]
0065D333C  mov      x0, x22
0065D3340  blr      x8
0065D3344  cbz      x0, #0x65d377c
0065D3348  mov      w1, w19
0065D334C  mov      x2, xzr
0065D3350  bl       #0x64e54f0 ; LocalModels.LocalModelManager$$GetMission_RandomMonsterFlushConfig
0065D3354  cbz      x0, #0x65d3200
0065D3358  adrp     x8, #0x9599000
0065D335C  ldrb     w8, [x8, #0x65e]
0065D3360  mov      x19, x0
0065D3364  cbnz     w8, #0x65d337c
0065D3368  adrp     x0, #0x8f0a000
0065D336C  ldr      x0, [x0, #0x988]
0065D3370  bl       #0x382bd14 ; 
0065D3374  adrp     x8, #0x9599000
0065D3378  strb     w28, [x8, #0x65e]
0065D337C  adrp     x8, #0x8f0a000
0065D3380  ldr      x8, [x8, #0x988]
0065D3384  ldr      x1, [x8]
0065D3388  ldrb     w8, [x1, #0x53]
0065D338C  tbnz     w8, #5, #0x65d3398
0065D3390  ldr      x0, [x19, #0x28]
0065D3394  b        #0x65d33a4 ; 
0065D3398  ldr      x8, [x1, #0x60]
0065D339C  mov      x0, x19
0065D33A0  blr      x8
0065D33A4  cbz      x0, #0x65d3710
0065D33A8  adrp     x8, #0x9599000
0065D33AC  ldrb     w8, [x8, #0x65e]
0065D33B0  cbnz     w8, #0x65d33c8
0065D33B4  adrp     x0, #0x8f0a000
0065D33B8  ldr      x0, [x0, #0x988]
0065D33BC  bl       #0x382bd14 ; 
0065D33C0  adrp     x8, #0x9599000
0065D33C4  strb     w28, [x8, #0x65e]
0065D33C8  adrp     x8, #0x8f0a000
0065D33CC  ldr      x8, [x8, #0x988]
0065D33D0  ldr      x1, [x8]
0065D33D4  ldrb     w8, [x1, #0x53]
0065D33D8  tbnz     w8, #5, #0x65d33e4
0065D33DC  ldr      x0, [x19, #0x28]
0065D33E0  b        #0x65d33f0 ; 
0065D33E4  ldr      x8, [x1, #0x60]
0065D33E8  mov      x0, x19
0065D33EC  blr      x8
0065D33F0  cbz      x0, #0x65d377c
0065D33F4  ldr      x8, [x0, #0x18]
0065D33F8  cbz      x8, #0x65d3710
0065D33FC  ldr      w8, [sp]
0065D3400  mov      x26, xzr
0065D3404  mov      w8, w8
0065D3408  str      x8, [sp, #8]
0065D340C  adrp     x8, #0x9599000
0065D3410  ldrb     w8, [x8, #0x65e]
0065D3414  cbnz     w8, #0x65d342c
0065D3418  adrp     x0, #0x8f0a000
0065D341C  ldr      x0, [x0, #0x988]
0065D3420  bl       #0x382bd14 ; 
0065D3424  adrp     x8, #0x9599000
0065D3428  strb     w28, [x8, #0x65e]
0065D342C  adrp     x8, #0x8f0a000
0065D3430  ldr      x8, [x8, #0x988]
0065D3434  ldr      x1, [x8]
0065D3438  ldrb     w8, [x1, #0x53]
0065D343C  tbnz     w8, #5, #0x65d3448
0065D3440  ldr      x0, [x19, #0x28]
0065D3444  b        #0x65d3454 ; 
0065D3448  ldr      x8, [x1, #0x60]
0065D344C  mov      x0, x19
0065D3450  blr      x8
0065D3454  cbz      x0, #0x65d377c
0065D3458  ldrsw    x8, [x0, #0x18]
0065D345C  cmp      x26, x8
0065D3460  b.ge     #0x65d36e8
0065D3464  adrp     x8, #0x9599000
0065D3468  ldrb     w8, [x8, #0x65e]
0065D346C  cbnz     w8, #0x65d3484
0065D3470  adrp     x0, #0x8f0a000
0065D3474  ldr      x0, [x0, #0x988]
0065D3478  bl       #0x382bd14 ; 
0065D347C  adrp     x8, #0x9599000
0065D3480  strb     w28, [x8, #0x65e]
0065D3484  adrp     x8, #0x8f0a000
0065D3488  ldr      x8, [x8, #0x988]
0065D348C  ldr      x1, [x8]
0065D3490  ldrb     w8, [x1, #0x53]
0065D3494  tbnz     w8, #5, #0x65d34a0
0065D3498  ldr      x0, [x19, #0x28]
0065D349C  b        #0x65d34ac ; 
0065D34A0  ldr      x8, [x1, #0x60]
0065D34A4  mov      x0, x19
0065D34A8  blr      x8
0065D34AC  cbz      x0, #0x65d377c
0065D34B0  ldr      w8, [x0, #0x18]
0065D34B4  cmp      x26, x8
0065D34B8  b.hs     #0x65d3780
0065D34BC  add      x8, x0, x26, lsl #2
0065D34C0  ldrb     w9, [x27, #0x286]
0065D34C4  ldr      w22, [x8, #0x20]
0065D34C8  cbnz     w9, #0x65d34d8
0065D34CC  mov      x0, x24
0065D34D0  bl       #0x382bd14 ; 
0065D34D4  strb     w28, [x27, #0x286]
0065D34D8  ldr      x1, [x24]
0065D34DC  ldrb     w8, [x1, #0x53]
0065D34E0  tbnz     w8, #5, #0x65d34ec
0065D34E4  ldr      x29, [x20, #0x80]
0065D34E8  b        #0x65d34fc ; 
0065D34EC  ldr      x8, [x1, #0x60]
0065D34F0  mov      x0, x20
0065D34F4  blr      x8
0065D34F8  mov      x29, x0
0065D34FC  cbz      x29, #0x65d377c
0065D3500  adrp     x8, #0x9598000
0065D3504  ldrb     w8, [x8, #0xfcc]
0065D3508  cbnz     w8, #0x65d351c
0065D350C  mov      x0, x25
0065D3510  bl       #0x382bd14 ; 
0065D3514  adrp     x8, #0x9598000
0065D3518  strb     w28, [x8, #0xfcc]
0065D351C  ldr      x1, [x25]
0065D3520  ldrb     w8, [x1, #0x53]
0065D3524  tbnz     w8, #5, #0x65d3530
0065D3528  ldr      x0, [x29, #0x200]
0065D352C  b        #0x65d353c ; 
0065D3530  ldr      x8, [x1, #0x60]
0065D3534  mov      x0, x29
0065D3538  blr      x8
0065D353C  cbz      x0, #0x65d377c
0065D3540  mov      w1, w22
0065D3544  mov      x2, xzr
0065D3548  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D354C  cbz      x0, #0x65d377c
0065D3550  adrp     x8, #0x9591000
0065D3554  ldrb     w8, [x8, #0xa75]
0065D3558  mov      x22, x0
0065D355C  cbnz     w8, #0x65d3574
0065D3560  adrp     x0, #0x8ee6000
0065D3564  ldr      x0, [x0, #0x290]
0065D3568  bl       #0x382bd14 ; 
0065D356C  adrp     x8, #0x9591000
0065D3570  strb     w28, [x8, #0xa75]
0065D3574  adrp     x8, #0x8ee6000
0065D3578  ldr      x8, [x8, #0x290]
0065D357C  ldr      x1, [x8]
0065D3580  ldrb     w8, [x1, #0x53]
0065D3584  tbnz     w8, #5, #0x65d3590
0065D3588  ldr      w0, [x22, #0x24]
0065D358C  b        #0x65d359c ; 
0065D3590  ldr      x8, [x1, #0x60]
0065D3594  mov      x0, x22
0065D3598  blr      x8
0065D359C  cmp      w0, #0xc9
0065D35A0  b.eq     #0x65d35f4
0065D35A4  adrp     x8, #0x9591000
0065D35A8  ldrb     w8, [x8, #0xa75]
0065D35AC  cbnz     w8, #0x65d35c4
0065D35B0  adrp     x0, #0x8ee6000
0065D35B4  ldr      x0, [x0, #0x290]
0065D35B8  bl       #0x382bd14 ; 
0065D35BC  adrp     x8, #0x9591000
0065D35C0  strb     w28, [x8, #0xa75]
0065D35C4  adrp     x8, #0x8ee6000
0065D35C8  ldr      x8, [x8, #0x290]
0065D35CC  ldr      x1, [x8]
0065D35D0  ldrb     w8, [x1, #0x53]
0065D35D4  tbnz     w8, #5, #0x65d35e0
0065D35D8  ldr      w0, [x22, #0x24]
0065D35DC  b        #0x65d35ec ; 
0065D35E0  ldr      x8, [x1, #0x60]
0065D35E4  mov      x0, x22
0065D35E8  blr      x8
0065D35EC  cmp      w0, #3
0065D35F0  b.ne     #0x65d3604
0065D35F4  cbz      x21, #0x65d377c
0065D35F8  ldr      w8, [x21, #0x14]
0065D35FC  add      w8, w8, #1
0065D3600  str      w8, [x21, #0x14]
0065D3604  adrp     x8, #0x9599000
0065D3608  ldrb     w8, [x8, #0x65d]
0065D360C  cbnz     w8, #0x65d3624
0065D3610  adrp     x0, #0x8f0a000
0065D3614  ldr      x0, [x0, #0xa20]
0065D3618  bl       #0x382bd14 ; 
0065D361C  adrp     x8, #0x9599000
0065D3620  strb     w28, [x8, #0x65d]
0065D3624  adrp     x8, #0x8f0a000
0065D3628  ldr      x8, [x8, #0xa20]
0065D362C  ldr      x1, [x8]
0065D3630  ldrb     w8, [x1, #0x53]
0065D3634  tbnz     w8, #5, #0x65d3640
0065D3638  ldr      w0, [x22, #0x24c]
0065D363C  b        #0x65d364c ; 
0065D3640  ldr      x8, [x1, #0x60]
0065D3644  mov      x0, x22
0065D3648  blr      x8
0065D364C  cmp      w0, #1
0065D3650  b.lt     #0x65d36b8
0065D3654  cbz      x21, #0x65d377c
0065D3658  ldr      w8, [x21, #0x10]
0065D365C  ldr      w29, [x21, #0x18]
0065D3660  add      w8, w8, #1
0065D3664  str      w8, [x21, #0x10]
0065D3668  adrp     x8, #0x9599000
0065D366C  ldrb     w8, [x8, #0x65d]
0065D3670  cbnz     w8, #0x65d3688
0065D3674  adrp     x0, #0x8f0a000
0065D3678  ldr      x0, [x0, #0xa20]
0065D367C  bl       #0x382bd14 ; 
0065D3680  adrp     x8, #0x9599000
0065D3684  strb     w28, [x8, #0x65d]
0065D3688  adrp     x8, #0x8f0a000
0065D368C  ldr      x8, [x8, #0xa20]
0065D3690  ldr      x1, [x8]
0065D3694  ldrb     w8, [x1, #0x53]
0065D3698  tbnz     w8, #5, #0x65d36a4
0065D369C  ldr      w0, [x22, #0x24c]
0065D36A0  b        #0x65d36b0 ; 
0065D36A4  ldr      x8, [x1, #0x60]
0065D36A8  mov      x0, x22
0065D36AC  blr      x8
0065D36B0  add      w8, w0, w29
0065D36B4  str      w8, [x21, #0x18]
0065D36B8  ldr      w2, [sp, #4]
0065D36BC  ldr      w3, [sp, #0x14]
0065D36C0  mov      x0, x20
0065D36C4  mov      x1, x22
0065D36C8  bl       #0x65d3844 ; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
0065D36CC  ldr      x8, [sp, #8]
0065D36D0  ldr      w9, [sp, #0x10]
0065D36D4  add      x26, x26, #1
0065D36D8  add      w8, w8, w26
0065D36DC  cmp      w9, w8
0065D36E0  b.gt     #0x65d340c
0065D36E4  b        #0x65d3758 ; 
0065D36E8  ldr      w9, [sp]
0065D36EC  ldr      w8, [sp, #0x10]
0065D36F0  add      w9, w9, w26
0065D36F4  cmp      w8, w9
0065D36F8  str      w9, [sp]
0065D36FC  b.le     #0x65d3758
0065D3700  ldr      w8, [sp]
0065D3704  cmp      w8, #0x1f5
0065D3708  b.lt     #0x65d3200
0065D370C  b        #0x65d3758 ; 
0065D3710  adrp     x8, #0x8ee1000
0065D3714  ldr      x8, [x8, #0x6e8]
0065D3718  ldr      x0, [x8]
0065D371C  ldr      w8, [x0, #0xe0]
0065D3720  cbnz     w8, #0x65d3728
0065D3724  bl       #0x382be8c ; 
0065D3728  adrp     x8, #0x8f0a000
0065D372C  adrp     x9, #0x8f0a000
0065D3730  adrp     x10, #0x8f0a000
0065D3734  ldr      x8, [x8, #0x980]
0065D3738  ldr      x9, [x9, #0xa60]
0065D373C  ldr      x10, [x10, #0x8b8]
0065D3740  mov      w3, #0x4e9
0065D3744  ldr      x0, [x8]
0065D3748  ldr      x1, [x9]
0065D374C  ldr      x2, [x10]
0065D3750  mov      x4, xzr
0065D3754  bl       #0x7997754 ; Logger$$LogError
0065D3758  mov      x0, x21
0065D375C  ldp      x20, x19, [sp, #0x70]
0065D3760  ldp      x22, x21, [sp, #0x60]
0065D3764  ldp      x24, x23, [sp, #0x50]
0065D3768  ldp      x26, x25, [sp, #0x40]
0065D376C  ldp      x28, x27, [sp, #0x30]
0065D3770  ldp      x29, x30, [sp, #0x20]
0065D3774  add      sp, sp, #0x80
0065D3778  ret      
0065D377C  bl       #0x382bfb8 ; 
0065D3780  bl       #0x382bfc0 ; 

