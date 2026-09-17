; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_BattleChapterType
; RVA 0x6585D60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006585D60  stp      x30, x21, [sp, #-0x20]!
006585D64  stp      x20, x19, [sp, #0x10]
006585D68  adrp     x20, #0x9599000
006585D6C  adrp     x21, #0x8f08000
006585D70  ldrb     w8, [x20, #0x162]
006585D74  ldr      x21, [x21, #0x28]
006585D78  mov      x19, x0
006585D7C  tbnz     w8, #0, #0x6585d94
006585D80  adrp     x0, #0x8f08000
006585D84  ldr      x0, [x0, #0x28]
006585D88  bl       #0x382bd14 ; 
006585D8C  mov      w8, #1
006585D90  strb     w8, [x20, #0x162]
006585D94  ldr      x1, [x21]
006585D98  ldrb     w8, [x1, #0x53]
006585D9C  tbnz     w8, #5, #0x6585db0
006585DA0  ldp      x20, x19, [sp, #0x10]
006585DA4  mov      w0, #7
006585DA8  ldp      x30, x21, [sp], #0x20
006585DAC  ret      
006585DB0  ldr      x2, [x1, #0x60]
006585DB4  mov      x0, x19
006585DB8  ldp      x20, x19, [sp, #0x10]
006585DBC  ldp      x30, x21, [sp], #0x20
006585DC0  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsLastBossWave
; RVA 0x6585DC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006585DC4  stp      x30, x21, [sp, #-0x20]!
006585DC8  stp      x20, x19, [sp, #0x10]
006585DCC  adrp     x20, #0x9599000
006585DD0  adrp     x21, #0x8f08000
006585DD4  ldrb     w8, [x20, #0x163]
006585DD8  ldr      x21, [x21, #0x30]
006585DDC  mov      x19, x0
006585DE0  tbnz     w8, #0, #0x6585df8
006585DE4  adrp     x0, #0x8f08000
006585DE8  ldr      x0, [x0, #0x30]
006585DEC  bl       #0x382bd14 ; 
006585DF0  mov      w8, #1
006585DF4  strb     w8, [x20, #0x163]
006585DF8  ldr      x1, [x21]
006585DFC  ldrb     w8, [x1, #0x53]
006585E00  tbnz     w8, #5, #0x6585e28
006585E04  ldr      w8, [x19, #0xe4]
006585E08  ldp      x20, x19, [sp, #0x10]
006585E0C  cmp      w8, #2
006585E10  cset     w9, eq
006585E14  cmp      w8, #8
006585E18  cset     w8, eq
006585E1C  orr      w0, w9, w8
006585E20  ldp      x30, x21, [sp], #0x20
006585E24  ret      
006585E28  ldr      x2, [x1, #0x60]
006585E2C  mov      x0, x19
006585E30  ldp      x20, x19, [sp, #0x10]
006585E34  ldp      x30, x21, [sp], #0x20
006585E38  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$GetRealChapterType
; RVA 0x6585E3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006585E3C  stp      x30, x21, [sp, #-0x20]!
006585E40  stp      x20, x19, [sp, #0x10]
006585E44  adrp     x20, #0x9599000
006585E48  adrp     x21, #0x8f08000
006585E4C  ldrb     w8, [x20, #0x164]
006585E50  ldr      x21, [x21, #0x38]
006585E54  mov      x19, x0
006585E58  tbnz     w8, #0, #0x6585e7c
006585E5C  adrp     x0, #0x8f08000
006585E60  ldr      x0, [x0, #0x38]
006585E64  bl       #0x382bd14 ; 
006585E68  adrp     x0, #0x8f08000
006585E6C  ldr      x0, [x0, #0x40]
006585E70  bl       #0x382bd14 ; 
006585E74  mov      w8, #1
006585E78  strb     w8, [x20, #0x164]
006585E7C  ldr      x1, [x21]
006585E80  ldrb     w8, [x1, #0x53]
006585E84  tbnz     w8, #5, #0x6585ec4
006585E88  adrp     x20, #0x9599000
006585E8C  ldrb     w8, [x20, #0x286]
006585E90  cbnz     w8, #0x6585ea8
006585E94  adrp     x0, #0x8f07000
006585E98  ldr      x0, [x0, #0xc98]
006585E9C  bl       #0x382bd14 ; 
006585EA0  mov      w8, #1
006585EA4  strb     w8, [x20, #0x286]
006585EA8  adrp     x8, #0x8f07000
006585EAC  ldr      x8, [x8, #0xc98]
006585EB0  ldr      x1, [x8]
006585EB4  ldrb     w8, [x1, #0x53]
006585EB8  tbnz     w8, #5, #0x6585ecc
006585EBC  ldr      x0, [x19, #0x80]
006585EC0  b        #0x6585ed8 ; 
006585EC4  ldr      x2, [x1, #0x60]
006585EC8  b        #0x6585f40 ; 
006585ECC  ldr      x8, [x1, #0x60]
006585ED0  mov      x0, x19
006585ED4  blr      x8
006585ED8  cbz      x0, #0x6585f50
006585EDC  ldr      x19, [x0, #0x3b8]
006585EE0  cbz      x19, #0x6585f50
006585EE4  adrp     x10, #0x8f08000
006585EE8  ldr      x8, [x19]
006585EEC  ldr      x10, [x10, #0x40]
006585EF0  ldrh     w9, [x8, #0x12e]
006585EF4  ldr      x1, [x10]
006585EF8  cbz      x9, #0x6585f1c
006585EFC  ldr      x10, [x8, #0xb0]
006585F00  add      x10, x10, #8
006585F04  ldur     x11, [x10, #-8]
006585F08  cmp      x11, x1
006585F0C  b.eq     #0x6585f2c
006585F10  subs     x9, x9, #1
006585F14  add      x10, x10, #0x10
006585F18  b.ne     #0x6585f04
006585F1C  mov      w2, #1
006585F20  mov      x0, x19
006585F24  bl       #0x3a7e710 ; 
006585F28  b        #0x6585f3c ; 
006585F2C  ldr      w9, [x10]
006585F30  add      w9, w9, #1
006585F34  add      x8, x8, w9, sxtw #4
006585F38  add      x0, x8, #0x138
006585F3C  ldp      x2, x1, [x0]
006585F40  mov      x0, x19
006585F44  ldp      x20, x19, [sp, #0x10]
006585F48  ldp      x30, x21, [sp], #0x20
006585F4C  br       x2
006585F50  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnChapterEnd
; RVA 0x6585F54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006585F54  stp      x30, x21, [sp, #-0x20]!
006585F58  stp      x20, x19, [sp, #0x10]
006585F5C  adrp     x20, #0x9599000
006585F60  adrp     x21, #0x8f08000
006585F64  ldrb     w8, [x20, #0x165]
006585F68  ldr      x21, [x21, #0x48]
006585F6C  mov      x19, x0
006585F70  tbnz     w8, #0, #0x6585f88
006585F74  adrp     x0, #0x8f08000
006585F78  ldr      x0, [x0, #0x48]
006585F7C  bl       #0x382bd14 ; 
006585F80  mov      w8, #1
006585F84  strb     w8, [x20, #0x165]
006585F88  ldr      x1, [x21]
006585F8C  ldrb     w8, [x1, #0x53]
006585F90  tbnz     w8, #5, #0x6585fb0
006585F94  mov      x0, x19
006585F98  ldp      x20, x19, [sp, #0x10]
006585F9C  mov      w1, #0xe
006585FA0  mov      w3, #1
006585FA4  mov      x2, xzr
006585FA8  ldp      x30, x21, [sp], #0x20
006585FAC  b        #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
006585FB0  ldr      x2, [x1, #0x60]
006585FB4  mov      x0, x19
006585FB8  ldp      x20, x19, [sp, #0x10]
006585FBC  ldp      x30, x21, [sp], #0x20
006585FC0  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnMissionClear
; RVA 0x6585FC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006585FC4  stp      x30, x21, [sp, #-0x20]!
006585FC8  stp      x20, x19, [sp, #0x10]
006585FCC  adrp     x20, #0x9599000
006585FD0  adrp     x21, #0x8f08000
006585FD4  ldrb     w8, [x20, #0x166]
006585FD8  ldr      x21, [x21, #0x50]
006585FDC  mov      x19, x0
006585FE0  tbnz     w8, #0, #0x6585ff8
006585FE4  adrp     x0, #0x8f08000
006585FE8  ldr      x0, [x0, #0x50]
006585FEC  bl       #0x382bd14 ; 
006585FF0  mov      w8, #1
006585FF4  strb     w8, [x20, #0x166]
006585FF8  ldr      x1, [x21]
006585FFC  ldrb     w8, [x1, #0x53]
006586000  tbnz     w8, #5, #0x6586010
006586004  ldp      x20, x19, [sp, #0x10]
006586008  ldp      x30, x21, [sp], #0x20
00658600C  ret      
006586010  ldr      x2, [x1, #0x60]
006586014  mov      x0, x19
006586018  ldp      x20, x19, [sp, #0x10]
00658601C  ldp      x30, x21, [sp], #0x20
006586020  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnProgressFinish
; RVA 0x6586024; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006586024  stp      x30, x21, [sp, #-0x20]!
006586028  stp      x20, x19, [sp, #0x10]
00658602C  adrp     x20, #0x9599000
006586030  adrp     x21, #0x8f08000
006586034  ldrb     w8, [x20, #0x167]
006586038  ldr      x21, [x21, #0x58]
00658603C  mov      x19, x0
006586040  tbnz     w8, #0, #0x6586058
006586044  adrp     x0, #0x8f08000
006586048  ldr      x0, [x0, #0x58]
00658604C  bl       #0x382bd14 ; 
006586050  mov      w8, #1
006586054  strb     w8, [x20, #0x167]
006586058  ldr      x1, [x21]
00658605C  ldrb     w8, [x1, #0x53]
006586060  tbnz     w8, #5, #0x6586070
006586064  ldp      x20, x19, [sp, #0x10]
006586068  ldp      x30, x21, [sp], #0x20
00658606C  ret      
006586070  ldr      x2, [x1, #0x60]
006586074  mov      x0, x19
006586078  ldp      x20, x19, [sp, #0x10]
00658607C  ldp      x30, x21, [sp], #0x20
006586080  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnUpdateHook
; RVA 0x6586084; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006586084  str      x30, [sp, #-0x40]!
006586088  stp      x24, x23, [sp, #0x10]
00658608C  stp      x22, x21, [sp, #0x20]
006586090  stp      x20, x19, [sp, #0x30]
006586094  adrp     x21, #0x9599000
006586098  adrp     x22, #0x8f08000
00658609C  ldrb     w8, [x21, #0x168]
0065860A0  ldr      x22, [x22, #0x60]
0065860A4  mov      x19, x1
0065860A8  mov      x20, x0
0065860AC  tbnz     w8, #0, #0x65860c4
0065860B0  adrp     x0, #0x8f08000
0065860B4  ldr      x0, [x0, #0x60]
0065860B8  bl       #0x382bd14 ; 
0065860BC  mov      w8, #1
0065860C0  strb     w8, [x21, #0x168]
0065860C4  ldr      x2, [x22]
0065860C8  ldrb     w8, [x2, #0x53]
0065860CC  tbnz     w8, #5, #0x658610c
0065860D0  adrp     x22, #0x9599000
0065860D4  ldrb     w8, [x22, #0x286]
0065860D8  cbnz     w8, #0x65860f0
0065860DC  adrp     x0, #0x8f07000
0065860E0  ldr      x0, [x0, #0xc98]
0065860E4  bl       #0x382bd14 ; 
0065860E8  mov      w8, #1
0065860EC  strb     w8, [x22, #0x286]
0065860F0  adrp     x23, #0x8f07000
0065860F4  ldr      x23, [x23, #0xc98]
0065860F8  ldr      x1, [x23]
0065860FC  ldrb     w8, [x1, #0x53]
006586100  tbnz     w8, #5, #0x658612c
006586104  ldr      x21, [x20, #0x80]
006586108  b        #0x658613c ; 
00658610C  ldr      x3, [x2, #0x60]
006586110  mov      x0, x20
006586114  mov      x1, x19
006586118  ldp      x20, x19, [sp, #0x30]
00658611C  ldp      x22, x21, [sp, #0x20]
006586120  ldp      x24, x23, [sp, #0x10]
006586124  ldr      x30, [sp], #0x40
006586128  br       x3
00658612C  ldr      x8, [x1, #0x60]
006586130  mov      x0, x20
006586134  blr      x8
006586138  mov      x21, x0
00658613C  cbz      x21, #0x65862f4
006586140  adrp     x24, #0x9599000
006586144  ldrb     w8, [x24, #0x29b]
006586148  cbnz     w8, #0x6586160
00658614C  adrp     x0, #0x8f08000
006586150  ldr      x0, [x0, #0x68]
006586154  bl       #0x382bd14 ; 
006586158  mov      w8, #1
00658615C  strb     w8, [x24, #0x29b]
006586160  adrp     x8, #0x8f08000
006586164  ldr      x8, [x8, #0x68]
006586168  ldr      x1, [x8]
00658616C  ldrb     w8, [x1, #0x53]
006586170  tbnz     w8, #5, #0x658617c
006586174  ldr      w0, [x21, #0x18c]
006586178  b        #0x6586188 ; 
00658617C  ldr      x8, [x1, #0x60]
006586180  mov      x0, x21
006586184  blr      x8
006586188  cmp      w0, #0
00658618C  b.gt     #0x65862e0
006586190  ldrb     w8, [x22, #0x286]
006586194  cbnz     w8, #0x65861ac
006586198  adrp     x0, #0x8f07000
00658619C  ldr      x0, [x0, #0xc98]
0065861A0  bl       #0x382bd14 ; 
0065861A4  mov      w8, #1
0065861A8  strb     w8, [x22, #0x286]
0065861AC  ldr      x1, [x23]
0065861B0  ldrb     w8, [x1, #0x53]
0065861B4  tbnz     w8, #5, #0x65861c0
0065861B8  ldr      x21, [x20, #0x80]
0065861BC  b        #0x65861d0 ; 
0065861C0  ldr      x8, [x1, #0x60]
0065861C4  mov      x0, x20
0065861C8  blr      x8
0065861CC  mov      x21, x0
0065861D0  cbz      x21, #0x65862f4
0065861D4  adrp     x22, #0x9599000
0065861D8  ldrb     w8, [x22, #0x29c]
0065861DC  cbnz     w8, #0x65861f4
0065861E0  adrp     x0, #0x8f08000
0065861E4  ldr      x0, [x0, #0x70]
0065861E8  bl       #0x382bd14 ; 
0065861EC  mov      w8, #1
0065861F0  strb     w8, [x22, #0x29c]
0065861F4  adrp     x8, #0x8f08000
0065861F8  ldr      x8, [x8, #0x70]
0065861FC  ldr      x1, [x8]
006586200  ldrb     w8, [x1, #0x53]
006586204  tbnz     w8, #5, #0x6586210
006586208  ldr      w0, [x21, #0x190]
00658620C  b        #0x658621c ; 
006586210  ldr      x8, [x1, #0x60]
006586214  mov      x0, x21
006586218  blr      x8
00658621C  cmp      w0, #0
006586220  b.gt     #0x6586238
006586224  ldr      x0, [x20, #0x90]
006586228  cbz      x0, #0x6586238
00658622C  mov      x1, x19
006586230  mov      x2, xzr
006586234  bl       #0x68501bc ; HotFix.BattleLogic.ExpAnimProcessor$$OnUpdate
006586238  adrp     x21, #0x9599000
00658623C  ldrb     w8, [x21, #0x28c]
006586240  cbnz     w8, #0x6586258
006586244  adrp     x0, #0x8f07000
006586248  ldr      x0, [x0, #0xdf0]
00658624C  bl       #0x382bd14 ; 
006586250  mov      w8, #1
006586254  strb     w8, [x21, #0x28c]
006586258  adrp     x8, #0x8f07000
00658625C  ldr      x8, [x8, #0xdf0]
006586260  ldr      x1, [x8]
006586264  ldrb     w8, [x1, #0x53]
006586268  tbnz     w8, #5, #0x6586274
00658626C  ldr      w0, [x20, #0x28]
006586270  b        #0x6586280 ; 
006586274  ldr      x8, [x1, #0x60]
006586278  mov      x0, x20
00658627C  blr      x8
006586280  cmp      w0, #1
006586284  b.ne     #0x65862e0
006586288  ldr      x8, [x20]
00658628C  mov      x0, x20
006586290  ldr      x9, [x8, #0x378]
006586294  ldr      x1, [x8, #0x380]
006586298  blr      x9
00658629C  tbz      w0, #0, #0x65862ac
0065862A0  mov      x0, x20
0065862A4  mov      x1, x19
0065862A8  bl       #0x65862f8 ; HotFix.BattleLogic.BattleManager$$UpdateTriggerTime
0065862AC  mov      x0, x20
0065862B0  mov      x1, x19
0065862B4  bl       #0x65863c8 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$UpdateRefreshTime
0065862B8  mov      x0, x20
0065862BC  mov      x1, x19
0065862C0  bl       #0x6586450 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$UpdateCreateMonsters
0065862C4  mov      x0, x20
0065862C8  mov      x1, x19
0065862CC  ldp      x20, x19, [sp, #0x30]
0065862D0  ldp      x22, x21, [sp, #0x20]
0065862D4  ldp      x24, x23, [sp, #0x10]
0065862D8  ldr      x30, [sp], #0x40
0065862DC  b        #0x6587048 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$UpdateBattleTime
0065862E0  ldp      x20, x19, [sp, #0x30]
0065862E4  ldp      x22, x21, [sp, #0x20]
0065862E8  ldp      x24, x23, [sp, #0x10]
0065862EC  ldr      x30, [sp], #0x40
0065862F0  ret      
0065862F4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$get__refreshState
; RVA 0x65871B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065871B0  stp      x30, x21, [sp, #-0x20]!
0065871B4  stp      x20, x19, [sp, #0x10]
0065871B8  adrp     x20, #0x9599000
0065871BC  adrp     x21, #0x8f08000
0065871C0  ldrb     w8, [x20, #0x169]
0065871C4  ldr      x21, [x21, #0xa0]
0065871C8  mov      x19, x0
0065871CC  tbnz     w8, #0, #0x65871e4
0065871D0  adrp     x0, #0x8f08000
0065871D4  ldr      x0, [x0, #0xa0]
0065871D8  bl       #0x382bd14 ; 
0065871DC  mov      w8, #1
0065871E0  strb     w8, [x20, #0x169]
0065871E4  ldr      x1, [x21]
0065871E8  ldrb     w8, [x1, #0x53]
0065871EC  tbnz     w8, #5, #0x658723c
0065871F0  ldr      x19, [x19, #0xd8]
0065871F4  cbz      x19, #0x6587250
0065871F8  adrp     x20, #0x9599000
0065871FC  ldrb     w8, [x20, #0x29d]
006587200  cbnz     w8, #0x6587218
006587204  adrp     x0, #0x8f08000
006587208  ldr      x0, [x0, #0xa8]
00658720C  bl       #0x382bd14 ; 
006587210  mov      w8, #1
006587214  strb     w8, [x20, #0x29d]
006587218  adrp     x8, #0x8f08000
00658721C  ldr      x8, [x8, #0xa8]
006587220  ldr      x1, [x8]
006587224  ldrb     w8, [x1, #0x53]
006587228  tbnz     w8, #5, #0x658723c
00658722C  ldr      w0, [x19, #0x28]
006587230  ldp      x20, x19, [sp, #0x10]
006587234  ldp      x30, x21, [sp], #0x20
006587238  ret      
00658723C  ldr      x2, [x1, #0x60]
006587240  mov      x0, x19
006587244  ldp      x20, x19, [sp, #0x10]
006587248  ldp      x30, x21, [sp], #0x20
00658724C  br       x2
006587250  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_InRefreshState
; RVA 0x6587254; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587254  stp      x30, x21, [sp, #-0x20]!
006587258  stp      x20, x19, [sp, #0x10]
00658725C  adrp     x20, #0x9599000
006587260  adrp     x21, #0x8f08000
006587264  ldrb     w8, [x20, #0x16a]
006587268  ldr      x21, [x21, #0xb0]
00658726C  mov      x19, x0
006587270  tbnz     w8, #0, #0x6587288
006587274  adrp     x0, #0x8f08000
006587278  ldr      x0, [x0, #0xb0]
00658727C  bl       #0x382bd14 ; 
006587280  mov      w8, #1
006587284  strb     w8, [x20, #0x16a]
006587288  ldr      x1, [x21]
00658728C  ldrb     w8, [x1, #0x53]
006587290  tbnz     w8, #5, #0x65872ac
006587294  ldr      x0, [x19, #0xd8]
006587298  cbz      x0, #0x65872c0
00658729C  ldp      x20, x19, [sp, #0x10]
0065872A0  mov      x1, xzr
0065872A4  ldp      x30, x21, [sp], #0x20
0065872A8  b        #0x65bf710 ; HotFix.BattleLogic.RefreshStateMachine$$get_InRefreshState
0065872AC  ldr      x2, [x1, #0x60]
0065872B0  mov      x0, x19
0065872B4  ldp      x20, x19, [sp, #0x10]
0065872B8  ldp      x30, x21, [sp], #0x20
0065872BC  br       x2
0065872C0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_IsFirstRefresh
; RVA 0x65872C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065872C4  stp      x30, x21, [sp, #-0x20]!
0065872C8  stp      x20, x19, [sp, #0x10]
0065872CC  adrp     x20, #0x9599000
0065872D0  adrp     x21, #0x8f08000
0065872D4  ldrb     w8, [x20, #0x16b]
0065872D8  ldr      x21, [x21, #0xb8]
0065872DC  mov      x19, x0
0065872E0  tbnz     w8, #0, #0x65872f8
0065872E4  adrp     x0, #0x8f08000
0065872E8  ldr      x0, [x0, #0xb8]
0065872EC  bl       #0x382bd14 ; 
0065872F0  mov      w8, #1
0065872F4  strb     w8, [x20, #0x16b]
0065872F8  ldr      x1, [x21]
0065872FC  ldrb     w8, [x1, #0x53]
006587300  tbnz     w8, #5, #0x658731c
006587304  ldr      x0, [x19, #0xd8]
006587308  cbz      x0, #0x6587330
00658730C  ldp      x20, x19, [sp, #0x10]
006587310  mov      x1, xzr
006587314  ldp      x30, x21, [sp], #0x20
006587318  b        #0x65bf77c ; HotFix.BattleLogic.RefreshStateMachine$$get_IsFirstRefresh
00658731C  ldr      x2, [x1, #0x60]
006587320  mov      x0, x19
006587324  ldp      x20, x19, [sp, #0x10]
006587328  ldp      x30, x21, [sp], #0x20
00658732C  br       x2
006587330  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_IsStateWaveShowEnd
; RVA 0x6587334; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587334  stp      x30, x21, [sp, #-0x20]!
006587338  stp      x20, x19, [sp, #0x10]
00658733C  adrp     x20, #0x9599000
006587340  adrp     x21, #0x8f08000
006587344  ldrb     w8, [x20, #0x16c]
006587348  ldr      x21, [x21, #0xc0]
00658734C  mov      x19, x0
006587350  tbnz     w8, #0, #0x6587368
006587354  adrp     x0, #0x8f08000
006587358  ldr      x0, [x0, #0xc0]
00658735C  bl       #0x382bd14 ; 
006587360  mov      w8, #1
006587364  strb     w8, [x20, #0x16c]
006587368  ldr      x1, [x21]
00658736C  ldrb     w8, [x1, #0x53]
006587370  tbnz     w8, #5, #0x658738c
006587374  ldr      x0, [x19, #0xd8]
006587378  cbz      x0, #0x65873a0
00658737C  ldp      x20, x19, [sp, #0x10]
006587380  mov      x1, xzr
006587384  ldp      x30, x21, [sp], #0x20
006587388  b        #0x65bf7e8 ; HotFix.BattleLogic.RefreshStateMachine$$get_IsStateWaveShowEnd
00658738C  ldr      x2, [x1, #0x60]
006587390  mov      x0, x19
006587394  ldp      x20, x19, [sp, #0x10]
006587398  ldp      x30, x21, [sp], #0x20
00658739C  br       x2
0065873A0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_IsWaitingForWaveStartUIProgress
; RVA 0x65873A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065873A4  stp      x30, x21, [sp, #-0x20]!
0065873A8  stp      x20, x19, [sp, #0x10]
0065873AC  adrp     x20, #0x9599000
0065873B0  adrp     x21, #0x8f08000
0065873B4  ldrb     w8, [x20, #0x16d]
0065873B8  ldr      x21, [x21, #0xc8]
0065873BC  mov      x19, x0
0065873C0  tbnz     w8, #0, #0x65873d8
0065873C4  adrp     x0, #0x8f08000
0065873C8  ldr      x0, [x0, #0xc8]
0065873CC  bl       #0x382bd14 ; 
0065873D0  mov      w8, #1
0065873D4  strb     w8, [x20, #0x16d]
0065873D8  ldr      x1, [x21]
0065873DC  ldrb     w8, [x1, #0x53]
0065873E0  tbnz     w8, #5, #0x6587400
0065873E4  mov      x0, x19
0065873E8  bl       #0x65871b0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get__refreshState
0065873EC  ldp      x20, x19, [sp, #0x10]
0065873F0  cmp      w0, #9
0065873F4  cset     w0, eq
0065873F8  ldp      x30, x21, [sp], #0x20
0065873FC  ret      
006587400  ldr      x2, [x1, #0x60]
006587404  mov      x0, x19
006587408  ldp      x20, x19, [sp, #0x10]
00658740C  ldp      x30, x21, [sp], #0x20
006587410  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckIsPauseState
; RVA 0x6587414; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587414  stp      x30, x21, [sp, #-0x20]!
006587418  stp      x20, x19, [sp, #0x10]
00658741C  adrp     x20, #0x9599000
006587420  adrp     x21, #0x8f08000
006587424  ldrb     w8, [x20, #0x16e]
006587428  ldr      x21, [x21, #0xd0]
00658742C  mov      x19, x0
006587430  tbnz     w8, #0, #0x6587448
006587434  adrp     x0, #0x8f08000
006587438  ldr      x0, [x0, #0xd0]
00658743C  bl       #0x382bd14 ; 
006587440  mov      w8, #1
006587444  strb     w8, [x20, #0x16e]
006587448  ldr      x1, [x21]
00658744C  ldrb     w8, [x1, #0x53]
006587450  tbnz     w8, #5, #0x6587464
006587454  ldp      x20, x19, [sp, #0x10]
006587458  mov      w0, wzr
00658745C  ldp      x30, x21, [sp], #0x20
006587460  ret      
006587464  ldr      x2, [x1, #0x60]
006587468  mov      x0, x19
00658746C  ldp      x20, x19, [sp, #0x10]
006587470  ldp      x30, x21, [sp], #0x20
006587474  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$WaterfallProgressFinishGoNext
; RVA 0x6587478; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587478  stp      x30, x21, [sp, #-0x20]!
00658747C  stp      x20, x19, [sp, #0x10]
006587480  adrp     x20, #0x9599000
006587484  adrp     x21, #0x8f08000
006587488  ldrb     w8, [x20, #0x16f]
00658748C  ldr      x21, [x21, #0xd8]
006587490  mov      x19, x0
006587494  tbnz     w8, #0, #0x65874ac
006587498  adrp     x0, #0x8f08000
00658749C  ldr      x0, [x0, #0xd8]
0065874A0  bl       #0x382bd14 ; 
0065874A4  mov      w8, #1
0065874A8  strb     w8, [x20, #0x16f]
0065874AC  ldr      x1, [x21]
0065874B0  ldrb     w8, [x1, #0x53]
0065874B4  tbnz     w8, #5, #0x65874d0
0065874B8  mov      x0, x19
0065874BC  bl       #0x65871b0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get__refreshState
0065874C0  cmp      w0, #9
0065874C4  b.ne     #0x65874e4
0065874C8  mov      w1, #1
0065874CC  b        #0x65874f8 ; 
0065874D0  ldr      x2, [x1, #0x60]
0065874D4  mov      x0, x19
0065874D8  ldp      x20, x19, [sp, #0x10]
0065874DC  ldp      x30, x21, [sp], #0x20
0065874E0  br       x2
0065874E4  mov      x0, x19
0065874E8  bl       #0x65871b0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get__refreshState
0065874EC  cmp      w0, #0xa
0065874F0  b.ne     #0x658750c
0065874F4  mov      w1, #2
0065874F8  mov      x0, x19
0065874FC  ldp      x20, x19, [sp, #0x10]
006587500  mov      w2, #1
006587504  ldp      x30, x21, [sp], #0x20
006587508  b        #0x6587518 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetRefreshState
00658750C  ldp      x20, x19, [sp, #0x10]
006587510  ldp      x30, x21, [sp], #0x20
006587514  ret      

; HotFix.BattleLogic.BaseSurvivalBattleManager$$EnemySpecialDie
; RVA 0x65875AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065875AC  stp      x30, x21, [sp, #-0x20]!
0065875B0  stp      x20, x19, [sp, #0x10]
0065875B4  adrp     x20, #0x9599000
0065875B8  adrp     x21, #0x8f08000
0065875BC  ldrb     w8, [x20, #0x170]
0065875C0  ldr      x21, [x21, #0xe8]
0065875C4  mov      x19, x0
0065875C8  tbnz     w8, #0, #0x65875e0
0065875CC  adrp     x0, #0x8f08000
0065875D0  ldr      x0, [x0, #0xe8]
0065875D4  bl       #0x382bd14 ; 
0065875D8  mov      w8, #1
0065875DC  strb     w8, [x20, #0x170]
0065875E0  ldr      x1, [x21]
0065875E4  ldrb     w8, [x1, #0x53]
0065875E8  tbnz     w8, #5, #0x6587604
0065875EC  mov      x0, x19
0065875F0  ldp      x20, x19, [sp, #0x10]
0065875F4  mov      w1, wzr
0065875F8  mov      w2, wzr
0065875FC  ldp      x30, x21, [sp], #0x20
006587600  b        #0x6587518 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetRefreshState
006587604  ldr      x2, [x1, #0x60]
006587608  mov      x0, x19
00658760C  ldp      x20, x19, [sp, #0x10]
006587610  ldp      x30, x21, [sp], #0x20
006587614  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetRefreshState
; RVA 0x6587518; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587518  stp      x30, x23, [sp, #-0x30]!
00658751C  stp      x22, x21, [sp, #0x10]
006587520  stp      x20, x19, [sp, #0x20]
006587524  adrp     x22, #0x9599000
006587528  adrp     x23, #0x8f08000
00658752C  ldrb     w8, [x22, #0x171]
006587530  ldr      x23, [x23, #0xe0]
006587534  mov      w20, w2
006587538  mov      w19, w1
00658753C  mov      x21, x0
006587540  tbnz     w8, #0, #0x6587558
006587544  adrp     x0, #0x8f08000
006587548  ldr      x0, [x0, #0xe0]
00658754C  bl       #0x382bd14 ; 
006587550  mov      w8, #1
006587554  strb     w8, [x22, #0x171]
006587558  ldr      x3, [x23]
00658755C  ldrb     w8, [x3, #0x53]
006587560  tbnz     w8, #5, #0x6587588
006587564  ldr      x0, [x21, #0xd8]
006587568  cbz      x0, #0x65875a8
00658756C  and      w2, w20, #1
006587570  mov      w1, w19
006587574  ldp      x20, x19, [sp, #0x20]
006587578  ldp      x22, x21, [sp, #0x10]
00658757C  mov      x3, xzr
006587580  ldp      x30, x23, [sp], #0x30
006587584  b        #0x65be430 ; HotFix.BattleLogic.RefreshStateMachine$$ChangeState
006587588  ldr      x4, [x3, #0x60]
00658758C  and      w2, w20, #1
006587590  mov      x0, x21
006587594  mov      w1, w19
006587598  ldp      x20, x19, [sp, #0x20]
00658759C  ldp      x22, x21, [sp, #0x10]
0065875A0  ldp      x30, x23, [sp], #0x30
0065875A4  br       x4
0065875A8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$UpdateBattleTime
; RVA 0x6587048; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587048  str      x30, [sp, #-0x30]!
00658704C  stp      x22, x21, [sp, #0x10]
006587050  stp      x20, x19, [sp, #0x20]
006587054  adrp     x21, #0x9599000
006587058  adrp     x22, #0x8f08000
00658705C  ldrb     w8, [x21, #0x172]
006587060  ldr      x22, [x22, #0x98]
006587064  mov      x20, x1
006587068  mov      x19, x0
00658706C  tbnz     w8, #0, #0x6587084
006587070  adrp     x0, #0x8f08000
006587074  ldr      x0, [x0, #0x98]
006587078  bl       #0x382bd14 ; 
00658707C  mov      w8, #1
006587080  strb     w8, [x21, #0x172]
006587084  ldr      x2, [x22]
006587088  ldrb     w8, [x2, #0x53]
00658708C  tbnz     w8, #5, #0x65870bc
006587090  ldr      x8, [x19, #0xe8]
006587094  ldr      w10, [x19, #0xf0]
006587098  add      x9, x8, x20
00658709C  cmp      w10, #1
0065870A0  str      x9, [x19, #0xe8]
0065870A4  b.ne     #0x65870d8
0065870A8  ldr      x8, [x19, #0xf8]
0065870AC  cmp      x9, x8
0065870B0  b.le     #0x65870e8
0065870B4  str      x8, [x19, #0xe8]
0065870B8  b        #0x65870ec ; 
0065870BC  ldr      x3, [x2, #0x60]
0065870C0  mov      x0, x19
0065870C4  mov      x1, x20
0065870C8  ldp      x20, x19, [sp, #0x20]
0065870CC  ldp      x22, x21, [sp, #0x10]
0065870D0  ldr      x30, [sp], #0x30
0065870D4  br       x3
0065870D8  ldp      x20, x19, [sp, #0x20]
0065870DC  ldp      x22, x21, [sp, #0x10]
0065870E0  ldr      x30, [sp], #0x30
0065870E4  ret      
0065870E8  b.lt     #0x6587198
0065870EC  adrp     x20, #0x9599000
0065870F0  ldrb     w8, [x20, #0x286]
0065870F4  cbnz     w8, #0x658710c
0065870F8  adrp     x0, #0x8f07000
0065870FC  ldr      x0, [x0, #0xc98]
006587100  bl       #0x382bd14 ; 
006587104  mov      w8, #1
006587108  strb     w8, [x20, #0x286]
00658710C  adrp     x8, #0x8f07000
006587110  ldr      x8, [x8, #0xc98]
006587114  ldr      x1, [x8]
006587118  ldrb     w8, [x1, #0x53]
00658711C  tbnz     w8, #5, #0x6587128
006587120  ldr      x20, [x19, #0x80]
006587124  b        #0x6587138 ; 
006587128  ldr      x8, [x1, #0x60]
00658712C  mov      x0, x19
006587130  blr      x8
006587134  mov      x20, x0
006587138  cbz      x20, #0x65871ac
00658713C  adrp     x21, #0x9598000
006587140  ldrb     w8, [x21, #0xfc4]
006587144  cbnz     w8, #0x658715c
006587148  adrp     x0, #0x8f05000
00658714C  ldr      x0, [x0, #0xfd8]
006587150  bl       #0x382bd14 ; 
006587154  mov      w8, #1
006587158  strb     w8, [x21, #0xfc4]
00658715C  adrp     x8, #0x8f05000
006587160  ldr      x8, [x8, #0xfd8]
006587164  ldr      x1, [x8]
006587168  ldrb     w8, [x1, #0x53]
00658716C  tbnz     w8, #5, #0x6587178
006587170  ldr      x0, [x20, #0x220]
006587174  b        #0x6587184 ; 
006587178  ldr      x8, [x1, #0x60]
00658717C  mov      x0, x20
006587180  blr      x8
006587184  cbz      x0, #0x65871ac
006587188  mov      w1, #0xd
00658718C  mov      x2, xzr
006587190  mov      w3, wzr
006587194  bl       #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
006587198  mov      x0, x19
00658719C  ldp      x20, x19, [sp, #0x20]
0065871A0  ldp      x22, x21, [sp, #0x10]
0065871A4  ldr      x30, [sp], #0x30
0065871A8  b        #0x6587618 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$DispatchTimeEvent
0065871AC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$DispatchTimeEvent
; RVA 0x6587618; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587618  stp      x30, x23, [sp, #-0x30]!
00658761C  stp      x22, x21, [sp, #0x10]
006587620  stp      x20, x19, [sp, #0x20]
006587624  adrp     x20, #0x9599000
006587628  adrp     x21, #0x8f08000
00658762C  ldrb     w8, [x20, #0x173]
006587630  ldr      x21, [x21, #0xf0]
006587634  mov      x19, x0
006587638  tbnz     w8, #0, #0x6587668
00658763C  adrp     x0, #0x8f08000
006587640  ldr      x0, [x0, #0xf0]
006587644  bl       #0x382bd14 ; 
006587648  adrp     x0, #0x8f08000
00658764C  ldr      x0, [x0, #0xf8]
006587650  bl       #0x382bd14 ; 
006587654  adrp     x0, #0x8f08000
006587658  ldr      x0, [x0, #0x100]
00658765C  bl       #0x382bd14 ; 
006587660  mov      w8, #1
006587664  strb     w8, [x20, #0x173]
006587668  ldr      x1, [x21]
00658766C  ldrb     w8, [x1, #0x53]
006587670  tbnz     w8, #5, #0x65876b0
006587674  adrp     x21, #0x9599000
006587678  ldrb     w8, [x21, #0x286]
00658767C  cbnz     w8, #0x6587694
006587680  adrp     x0, #0x8f07000
006587684  ldr      x0, [x0, #0xc98]
006587688  bl       #0x382bd14 ; 
00658768C  mov      w8, #1
006587690  strb     w8, [x21, #0x286]
006587694  adrp     x22, #0x8f07000
006587698  ldr      x22, [x22, #0xc98]
00658769C  ldr      x1, [x22]
0065876A0  ldrb     w8, [x1, #0x53]
0065876A4  tbnz     w8, #5, #0x65876c8
0065876A8  ldr      x20, [x19, #0x80]
0065876AC  b        #0x65876d8 ; 
0065876B0  ldr      x2, [x1, #0x60]
0065876B4  mov      x0, x19
0065876B8  ldp      x20, x19, [sp, #0x20]
0065876BC  ldp      x22, x21, [sp, #0x10]
0065876C0  ldp      x30, x23, [sp], #0x30
0065876C4  br       x2
0065876C8  ldr      x8, [x1, #0x60]
0065876CC  mov      x0, x19
0065876D0  blr      x8
0065876D4  mov      x20, x0
0065876D8  cbz      x20, #0x6587838
0065876DC  adrp     x23, #0x9591000
0065876E0  ldrb     w8, [x23, #0xa4c]
0065876E4  cbnz     w8, #0x65876fc
0065876E8  adrp     x0, #0x8ee5000
0065876EC  ldr      x0, [x0, #0xb30]
0065876F0  bl       #0x382bd14 ; 
0065876F4  mov      w8, #1
0065876F8  strb     w8, [x23, #0xa4c]
0065876FC  adrp     x8, #0x8ee5000
006587700  ldr      x8, [x8, #0xb30]
006587704  ldr      x1, [x8]
006587708  ldrb     w8, [x1, #0x53]
00658770C  tbnz     w8, #5, #0x6587718
006587710  ldr      x0, [x20, #0x210]
006587714  b        #0x6587724 ; 
006587718  ldr      x8, [x1, #0x60]
00658771C  mov      x0, x20
006587720  blr      x8
006587724  cbz      x0, #0x6587838
006587728  adrp     x8, #0x8f08000
00658772C  ldr      x8, [x8, #0x100]
006587730  ldr      x1, [x8]
006587734  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
006587738  cbz      x0, #0x6587838
00658773C  ldr      x8, [x19, #0xe8]
006587740  mov      w9, #0x37800000
006587744  fmov     s1, w9
006587748  mov      x20, x0
00658774C  scvtf    s0, x8
006587750  fmul     s0, s0, s1
006587754  str      s0, [x0, #0x20]
006587758  ldr      x8, [x19, #0xf8]
00658775C  scvtf    s0, x8
006587760  fmul     s0, s0, s1
006587764  str      s0, [x0, #0x24]
006587768  ldrb     w8, [x21, #0x286]
00658776C  cbnz     w8, #0x6587784
006587770  adrp     x0, #0x8f07000
006587774  ldr      x0, [x0, #0xc98]
006587778  bl       #0x382bd14 ; 
00658777C  mov      w8, #1
006587780  strb     w8, [x21, #0x286]
006587784  ldr      x1, [x22]
006587788  ldrb     w8, [x1, #0x53]
00658778C  tbnz     w8, #5, #0x6587798
006587790  ldr      x0, [x19, #0x80]
006587794  b        #0x65877a4 ; 
006587798  ldr      x8, [x1, #0x60]
00658779C  mov      x0, x19
0065877A0  blr      x8
0065877A4  cbz      x0, #0x6587838
0065877A8  ldr      x19, [x0, #0x1e0]
0065877AC  cbz      x19, #0x6587838
0065877B0  adrp     x9, #0x8f08000
0065877B4  ldr      x9, [x9, #0xf8]
0065877B8  ldr      x8, [x19]
0065877BC  ldr      x21, [x9]
0065877C0  ldrh     w9, [x8, #0x12e]
0065877C4  ldr      x1, [x21, #0x20]
0065877C8  ldrh     w2, [x21, #0x50]
0065877CC  cbz      x9, #0x65877f0
0065877D0  ldr      x10, [x8, #0xb0]
0065877D4  add      x10, x10, #8
0065877D8  ldur     x11, [x10, #-8]
0065877DC  cmp      x11, x1
0065877E0  b.eq     #0x65877fc
0065877E4  subs     x9, x9, #1
0065877E8  add      x10, x10, #0x10
0065877EC  b.ne     #0x65877d8
0065877F0  mov      x0, x19
0065877F4  bl       #0x3a7e710 ; 
0065877F8  b        #0x658780c ; 
0065877FC  ldr      w9, [x10]
006587800  add      w9, w9, w2
006587804  add      x8, x8, w9, sxtw #4
006587808  add      x0, x8, #0x138
00658780C  ldr      x0, [x0, #8]
006587810  mov      x1, x21
006587814  bl       #0x382be88 ; 
006587818  mov      x2, x0
00658781C  ldr      x3, [x0, #8]
006587820  mov      x0, x19
006587824  mov      x1, x20
006587828  ldp      x20, x19, [sp, #0x20]
00658782C  ldp      x22, x21, [sp, #0x10]
006587830  ldp      x30, x23, [sp], #0x30
006587834  br       x3
006587838  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$UpdateRefreshTime
; RVA 0x65863C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065863C8  str      x30, [sp, #-0x30]!
0065863CC  stp      x22, x21, [sp, #0x10]
0065863D0  stp      x20, x19, [sp, #0x20]
0065863D4  adrp     x21, #0x9599000
0065863D8  adrp     x22, #0x8f08000
0065863DC  ldrb     w8, [x21, #0x174]
0065863E0  ldr      x22, [x22, #0x80]
0065863E4  mov      x19, x1
0065863E8  mov      x20, x0
0065863EC  tbnz     w8, #0, #0x6586404
0065863F0  adrp     x0, #0x8f08000
0065863F4  ldr      x0, [x0, #0x80]
0065863F8  bl       #0x382bd14 ; 
0065863FC  mov      w8, #1
006586400  strb     w8, [x21, #0x174]
006586404  ldr      x2, [x22]
006586408  ldrb     w8, [x2, #0x53]
00658640C  tbnz     w8, #5, #0x6586430
006586410  ldr      x0, [x20, #0xd8]
006586414  cbz      x0, #0x658644c
006586418  mov      x1, x19
00658641C  ldp      x20, x19, [sp, #0x20]
006586420  ldp      x22, x21, [sp, #0x10]
006586424  mov      x2, xzr
006586428  ldr      x30, [sp], #0x30
00658642C  b        #0x65bfa74 ; HotFix.BattleLogic.RefreshStateMachine$$Update
006586430  ldr      x3, [x2, #0x60]
006586434  mov      x0, x20
006586438  mov      x1, x19
00658643C  ldp      x20, x19, [sp, #0x20]
006586440  ldp      x22, x21, [sp, #0x10]
006586444  ldr      x30, [sp], #0x30
006586448  br       x3
00658644C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$ClearMonsterCreateData
; RVA 0x658783C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658783C  stp      x30, x21, [sp, #-0x20]!
006587840  stp      x20, x19, [sp, #0x10]
006587844  adrp     x20, #0x9599000
006587848  adrp     x21, #0x8f08000
00658784C  ldrb     w8, [x20, #0x175]
006587850  ldr      x21, [x21, #0x108]
006587854  mov      x19, x0
006587858  tbnz     w8, #0, #0x6587870
00658785C  adrp     x0, #0x8f08000
006587860  ldr      x0, [x0, #0x108]
006587864  bl       #0x382bd14 ; 
006587868  mov      w8, #1
00658786C  strb     w8, [x20, #0x175]
006587870  ldr      x1, [x21]
006587874  ldrb     w8, [x1, #0x53]
006587878  tbnz     w8, #5, #0x658788c
00658787C  str      wzr, [x19, #0xa8]
006587880  ldp      x20, x19, [sp, #0x10]
006587884  ldp      x30, x21, [sp], #0x20
006587888  ret      
00658788C  ldr      x2, [x1, #0x60]
006587890  mov      x0, x19
006587894  ldp      x20, x19, [sp, #0x10]
006587898  ldp      x30, x21, [sp], #0x20
00658789C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$ResetLastMissionRefreshStarted
; RVA 0x65878A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065878A0  stp      x30, x21, [sp, #-0x20]!
0065878A4  stp      x20, x19, [sp, #0x10]
0065878A8  adrp     x20, #0x9599000
0065878AC  adrp     x21, #0x8f08000
0065878B0  ldrb     w8, [x20, #0x176]
0065878B4  ldr      x21, [x21, #0x110]
0065878B8  mov      x19, x0
0065878BC  tbnz     w8, #0, #0x65878d4
0065878C0  adrp     x0, #0x8f08000
0065878C4  ldr      x0, [x0, #0x110]
0065878C8  bl       #0x382bd14 ; 
0065878CC  mov      w8, #1
0065878D0  strb     w8, [x20, #0x176]
0065878D4  ldr      x1, [x21]
0065878D8  ldrb     w8, [x1, #0x53]
0065878DC  tbnz     w8, #5, #0x65878f0
0065878E0  strb     wzr, [x19, #0xd4]
0065878E4  ldp      x20, x19, [sp, #0x10]
0065878E8  ldp      x30, x21, [sp], #0x20
0065878EC  ret      
0065878F0  ldr      x2, [x1, #0x60]
0065878F4  mov      x0, x19
0065878F8  ldp      x20, x19, [sp, #0x10]
0065878FC  ldp      x30, x21, [sp], #0x20
006587900  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$MarkLastMissionRefreshStarted
; RVA 0x6587904; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587904  stp      x30, x21, [sp, #-0x20]!
006587908  stp      x20, x19, [sp, #0x10]
00658790C  adrp     x20, #0x9599000
006587910  adrp     x21, #0x8f08000
006587914  ldrb     w8, [x20, #0x177]
006587918  ldr      x21, [x21, #0x118]
00658791C  mov      x19, x0
006587920  tbnz     w8, #0, #0x6587938
006587924  adrp     x0, #0x8f08000
006587928  ldr      x0, [x0, #0x118]
00658792C  bl       #0x382bd14 ; 
006587930  mov      w8, #1
006587934  strb     w8, [x20, #0x177]
006587938  ldr      x1, [x21]
00658793C  ldrb     w8, [x1, #0x53]
006587940  tbnz     w8, #5, #0x6587960
006587944  ldrb     w8, [x19, #0x102]
006587948  cbz      w8, #0x6587954
00658794C  mov      w8, #1
006587950  strb     w8, [x19, #0xd4]
006587954  ldp      x20, x19, [sp, #0x10]
006587958  ldp      x30, x21, [sp], #0x20
00658795C  ret      
006587960  ldr      x2, [x1, #0x60]
006587964  mov      x0, x19
006587968  ldp      x20, x19, [sp, #0x10]
00658796C  ldp      x30, x21, [sp], #0x20
006587970  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$UpdateCreateMonsters
; RVA 0x6586450; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006586450  stp      x29, x30, [sp, #-0x60]!
006586454  stp      x28, x27, [sp, #0x10]
006586458  stp      x26, x25, [sp, #0x20]
00658645C  stp      x24, x23, [sp, #0x30]
006586460  stp      x22, x21, [sp, #0x40]
006586464  stp      x20, x19, [sp, #0x50]
006586468  sub      sp, sp, #0x350
00658646C  mrs      x29, tpidr_el0
006586470  ldr      x8, [x29, #0x28]
006586474  adrp     x21, #0x9599000
006586478  adrp     x22, #0x8f08000
00658647C  mov      x19, x1
006586480  str      x8, [sp, #0x348]
006586484  ldrb     w8, [x21, #0x178]
006586488  ldr      x22, [x22, #0x88]
00658648C  mov      x20, x0
006586490  tbnz     w8, #0, #0x65864b4
006586494  adrp     x0, #0x8f08000
006586498  ldr      x0, [x0, #0x88]
00658649C  bl       #0x382bd14 ; 
0065864A0  adrp     x0, #0x8ee8000
0065864A4  ldr      x0, [x0, #0x898]
0065864A8  bl       #0x382bd14 ; 
0065864AC  mov      w8, #1
0065864B0  strb     w8, [x21, #0x178]
0065864B4  ldr      x2, [x22]
0065864B8  ldrb     w8, [x2, #0x53]
0065864BC  tbnz     w8, #5, #0x6586ffc
0065864C0  ldr      w8, [x20, #0xa8]
0065864C4  cmp      w8, #1
0065864C8  b.lt     #0x658700c
0065864CC  ldrb     w8, [x20, #0x78]
0065864D0  cbnz     w8, #0x658700c
0065864D4  adrp     x27, #0x8f07000
0065864D8  adrp     x21, #0x8ee8000
0065864DC  ldr      x27, [x27, #0xc98]
0065864E0  ldr      x21, [x21, #0x898]
0065864E4  mov      w23, wzr
0065864E8  add      x28, sp, #0x2a8
0065864EC  adrp     x22, #0x9599000
0065864F0  ldr      x26, [x20, #0xa0]
0065864F4  cbz      x26, #0x658703c
0065864F8  ldr      w8, [x26, #0x18]
0065864FC  cmp      w23, w8
006586500  b.hs     #0x6587040
006586504  sxtw     x24, w23
006586508  add      x25, x26, x24, lsl #7
00658650C  mov      x8, x25
006586510  ldr      x9, [x8, #0x20]!
006586514  tbnz     x9, #0x3f, #0x6586570
006586518  sub      x9, x9, x19
00658651C  cmp      x9, #0
006586520  str      x9, [x8]
006586524  b.gt     #0x65868fc
006586528  ldr      w8, [x20, #0xe0]
00658652C  cmp      w8, #8
006586530  b.eq     #0x658653c
006586534  cmp      w8, #2
006586538  b.ne     #0x65866c0
00658653C  mov      x0, x20
006586540  bl       #0x6587974 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckSendAppearEvent
006586544  ldrb     w8, [x22, #0x286]
006586548  cbnz     w8, #0x658655c
00658654C  mov      x0, x27
006586550  bl       #0x382bd14 ; 
006586554  mov      w8, #1
006586558  strb     w8, [x22, #0x286]
00658655C  ldr      x1, [x27]
006586560  ldrb     w8, [x1, #0x53]
006586564  tbnz     w8, #5, #0x6586608
006586568  ldr      x25, [x20, #0x80]
00658656C  b        #0x6586618 ; 
006586570  ldr      x8, [x25, #0x78]!
006586574  cmp      x8, #1
006586578  b.lt     #0x65865b8
00658657C  sub      x8, x8, x19
006586580  cmp      x8, #0
006586584  str      x8, [x25]
006586588  b.gt     #0x65868fc
00658658C  ldrb     w8, [x22, #0x286]
006586590  cbnz     w8, #0x65865a4
006586594  mov      x0, x27
006586598  bl       #0x382bd14 ; 
00658659C  mov      w8, #1
0065865A0  strb     w8, [x22, #0x286]
0065865A4  ldr      x1, [x27]
0065865A8  ldrb     w8, [x1, #0x53]
0065865AC  tbnz     w8, #5, #0x658670c
0065865B0  ldr      x25, [x20, #0x80]
0065865B4  b        #0x658671c ; 
0065865B8  add      x8, x26, x24, lsl #7
0065865BC  ldr      x9, [x8, #0x28]
0065865C0  sub      x9, x9, x19
0065865C4  cmp      x9, #0
0065865C8  str      x9, [x8, #0x28]
0065865CC  b.gt     #0x65868fc
0065865D0  ldr      w8, [x20, #0xe0]
0065865D4  cmp      w8, #8
0065865D8  b.eq     #0x65865e4
0065865DC  cmp      w8, #2
0065865E0  b.ne     #0x6586910
0065865E4  ldr      x0, [x21]
0065865E8  ldr      w8, [x0, #0xe0]
0065865EC  cbnz     w8, #0x65865f8
0065865F0  bl       #0x382be8c ; 
0065865F4  ldr      x0, [x21]
0065865F8  ldr      x8, [x0, #0xb8]
0065865FC  ldr      x8, [x8, #0x1e8]
006586600  str      x8, [x25]
006586604  b        #0x65868fc ; 
006586608  ldr      x8, [x1, #0x60]
00658660C  mov      x0, x20
006586610  blr      x8
006586614  mov      x25, x0
006586618  ldr      x0, [x21]
00658661C  ldr      w8, [x0, #0xe0]
006586620  cbnz     w8, #0x658662c
006586624  bl       #0x382be8c ; 
006586628  ldr      x0, [x21]
00658662C  ldr      x8, [x0, #0xb8]
006586630  add      x21, x26, x24, lsl #7
006586634  ldr      x9, [x21, #0x40]
006586638  ldr      q0, [x21, #0x30]
00658663C  ldr      w26, [x8, #0x1c8]
006586640  add      x8, sp, #0x310
006586644  mov      x0, xzr
006586648  str      x9, [sp, #0x340]
00658664C  str      q0, [sp, #0x330]
006586650  bl       #0x7d4fddc ; Photon.Deterministic.FPVector3$$get_One
006586654  ldr      x8, [sp, #0x310]
006586658  ldr      x9, [sp, #0x318]
00658665C  ldr      x10, [sp, #0x320]
006586660  ldr      x11, [x21, #0x28]
006586664  str      xzr, [sp, #0x318]
006586668  str      xzr, [sp, #0x310]
00658666C  str      xzr, [sp, #0x320]
006586670  cbz      x25, #0x658703c
006586674  add      x4, x11, #0x20, lsl #12
006586678  ldr      q0, [sp, #0x330]
00658667C  ldr      x11, [sp, #0x340]
006586680  ldr      q1, [sp, #0x310]
006586684  ldr      x12, [sp, #0x320]
006586688  sbfiz    x10, x10, #2, #0x2e
00658668C  sbfiz    x9, x9, #2, #0x2e
006586690  sbfiz    x8, x8, #2, #0x2e
006586694  str      x8, [sp, #0x2d8]
006586698  str      x9, [sp, #0x2e0]
00658669C  str      x10, [sp, #0x2e8]
0065866A0  str      q0, [sp, #0x2f0]
0065866A4  str      x11, [sp, #0x300]
0065866A8  str      q1, [sp, #0x2c0]
0065866AC  str      x12, [sp, #0x2d0]
0065866B0  add      x2, sp, #0x2f0
0065866B4  add      x3, sp, #0x2d8
0065866B8  add      x6, sp, #0x2c0
0065866BC  b        #0x65868dc ; 
0065866C0  ldr      x0, [x21]
0065866C4  ldr      w8, [x0, #0xe0]
0065866C8  cbnz     w8, #0x65866d4
0065866CC  bl       #0x382be8c ; 
0065866D0  ldr      x0, [x21]
0065866D4  ldr      x8, [x0, #0xb8]
0065866D8  ldr      w8, [x8, #0xb8]
0065866DC  cbz      w8, #0x65868fc
0065866E0  ldrb     w8, [x22, #0x286]
0065866E4  cbnz     w8, #0x65866f8
0065866E8  mov      x0, x27
0065866EC  bl       #0x382bd14 ; 
0065866F0  mov      w8, #1
0065866F4  strb     w8, [x22, #0x286]
0065866F8  ldr      x1, [x27]
0065866FC  ldrb     w8, [x1, #0x53]
006586700  tbnz     w8, #5, #0x6586830
006586704  ldr      x25, [x20, #0x80]
006586708  b        #0x6586840 ; 
00658670C  ldr      x8, [x1, #0x60]
006586710  mov      x0, x20
006586714  blr      x8
006586718  mov      x25, x0
00658671C  add      x21, x26, x24, lsl #7
006586720  ldr      x8, [x21, #0x40]
006586724  ldr      q0, [x21, #0x30]
006586728  ldr      w26, [x21, #0x60]
00658672C  mov      x22, x21
006586730  str      x8, [sp, #0x340]
006586734  str      q0, [sp, #0x330]
006586738  ldr      w1, [x22, #0x98]!
00658673C  ldr      x8, [x20]
006586740  mov      x0, x20
006586744  ldur     x28, [x22, #-0x28]
006586748  ldr      x9, [x8, #0x588]
00658674C  ldr      x2, [x8, #0x590]
006586750  ldur     x27, [x22, #-0x10]
006586754  blr      x9
006586758  cbz      x25, #0x658703c
00658675C  ldr      x8, [x21, #0x90]
006586760  ldr      w9, [x22]
006586764  ldr      q0, [sp, #0x330]
006586768  ldr      x10, [sp, #0x340]
00658676C  ldrb     w7, [x21, #0x9c]
006586770  mov      x6, x0
006586774  add      x2, sp, #0x230
006586778  mov      x0, x25
00658677C  mov      w1, w26
006586780  mov      x3, x28
006586784  mov      x4, x27
006586788  mov      w5, wzr
00658678C  str      q0, [sp, #0x230]
006586790  str      x10, [sp, #0x240]
006586794  stp      x8, xzr, [sp, #8]
006586798  str      w9, [sp]
00658679C  bl       #0x6a15ea4 ; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
0065867A0  ldrb     w8, [x20, #0x101]
0065867A4  cbnz     w8, #0x65867b8
0065867A8  mov      w8, #1
0065867AC  mov      x0, x20
0065867B0  strb     w8, [x20, #0x101]
0065867B4  bl       #0x6587a40 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$TriggerEnemyFirstCreateInWaveEvent
0065867B8  ldr      w8, [x20, #0xa8]
0065867BC  adrp     x27, #0x8f07000
0065867C0  ldr      x22, [x20, #0xa0]
0065867C4  add      x28, sp, #0x2a8
0065867C8  sub      w8, w8, #1
0065867CC  str      w8, [x20, #0xa8]
0065867D0  ldr      x27, [x27, #0xc98]
0065867D4  cbz      x22, #0x658703c
0065867D8  ldr      w21, [x22, #0x18]
0065867DC  cmp      w8, w21
0065867E0  b.hs     #0x6587040
0065867E4  sxtw     x8, w8
0065867E8  add      x8, x22, x8, lsl #7
0065867EC  add      x1, x8, #0x20
0065867F0  add      x0, sp, #0x1b0
0065867F4  mov      w2, #0x80
0065867F8  bl       #0x89edad0 ; 
0065867FC  cmp      w23, w21
006586800  b.hs     #0x6587040
006586804  add      x21, x22, x24, lsl #7
006586808  sub      w23, w23, #1
00658680C  add      x0, x21, #0x20
006586810  add      x1, sp, #0x1b0
006586814  mov      w2, #0x80
006586818  bl       #0x89edad0 ; 
00658681C  add      x0, x21, #0x70
006586820  mov      x1, xzr
006586824  bl       #0x382bcb8 ; 
006586828  adrp     x22, #0x9599000
00658682C  b        #0x65868f4 ; 
006586830  ldr      x8, [x1, #0x60]
006586834  mov      x0, x20
006586838  blr      x8
00658683C  mov      x25, x0
006586840  ldr      x0, [x21]
006586844  ldr      w8, [x0, #0xe0]
006586848  cbnz     w8, #0x6586854
00658684C  bl       #0x382be8c ; 
006586850  ldr      x0, [x21]
006586854  ldr      x8, [x0, #0xb8]
006586858  add      x21, x26, x24, lsl #7
00658685C  ldr      x9, [x21, #0x40]
006586860  ldr      q0, [x21, #0x30]
006586864  ldr      w26, [x8, #0xb8]
006586868  add      x8, sp, #0x2a8
00658686C  mov      x0, xzr
006586870  str      x9, [sp, #0x340]
006586874  str      q0, [sp, #0x330]
006586878  bl       #0x7d4fddc ; Photon.Deterministic.FPVector3$$get_One
00658687C  ldr      q0, [x28]
006586880  ldr      x8, [sp, #0x2b8]
006586884  str      q0, [sp, #0x310]
006586888  str      x8, [sp, #0x320]
00658688C  ldr      x4, [x21, #0x28]
006586890  str      xzr, [sp, #0x2b0]
006586894  str      xzr, [sp, #0x2a8]
006586898  str      xzr, [sp, #0x2b8]
00658689C  cbz      x25, #0x658703c
0065868A0  ldr      q0, [sp, #0x330]
0065868A4  ldr      x8, [sp, #0x340]
0065868A8  ldr      q1, [sp, #0x310]
0065868AC  ldr      x9, [sp, #0x320]
0065868B0  ldr      q2, [x28]
0065868B4  ldr      x10, [sp, #0x2b8]
0065868B8  add      x2, sp, #0x290
0065868BC  add      x3, sp, #0x270
0065868C0  add      x6, sp, #0x250
0065868C4  str      q0, [sp, #0x290]
0065868C8  str      x8, [sp, #0x2a0]
0065868CC  str      q1, [sp, #0x270]
0065868D0  str      x9, [sp, #0x280]
0065868D4  str      q2, [sp, #0x250]
0065868D8  str      x10, [sp, #0x260]
0065868DC  mov      w5, #1
0065868E0  mov      x0, x25
0065868E4  mov      w1, w26
0065868E8  mov      x7, xzr
0065868EC  str      xzr, [sp]
0065868F0  bl       #0x6a07bf8 ; HotFix.BattleLogic.BattleWorldContext$$PlayMapEffectLife
0065868F4  adrp     x21, #0x8ee8000
0065868F8  ldr      x21, [x21, #0x898]
0065868FC  ldr      w8, [x20, #0xa8]
006586900  add      w23, w23, #1
006586904  cmp      w23, w8
006586908  b.lt     #0x65864f0
00658690C  b        #0x658700c ; 
006586910  ldrb     w8, [x20, #0x101]
006586914  cbnz     w8, #0x6586928
006586918  mov      w8, #1
00658691C  mov      x0, x20
006586920  strb     w8, [x20, #0x101]
006586924  bl       #0x6587a40 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$TriggerEnemyFirstCreateInWaveEvent
006586928  ldrb     w8, [x22, #0x286]
00658692C  cbnz     w8, #0x6586940
006586930  mov      x0, x27
006586934  bl       #0x382bd14 ; 
006586938  mov      w8, #1
00658693C  strb     w8, [x22, #0x286]
006586940  ldr      x1, [x27]
006586944  ldrb     w8, [x1, #0x53]
006586948  tbnz     w8, #5, #0x6586954
00658694C  ldr      x0, [x20, #0x80]
006586950  b        #0x6586960 ; 
006586954  ldr      x8, [x1, #0x60]
006586958  mov      x0, x20
00658695C  blr      x8
006586960  cbz      x0, #0x658703c
006586964  ldrb     w8, [x0, #0x14]
006586968  cbz      w8, #0x6586fa0
00658696C  adrp     x21, #0x8f07000
006586970  ldrb     w8, [x22, #0x286]
006586974  ldr      x21, [x21, #0xc98]
006586978  cbnz     w8, #0x658698c
00658697C  mov      x0, x21
006586980  bl       #0x382bd14 ; 
006586984  mov      w8, #1
006586988  strb     w8, [x22, #0x286]
00658698C  ldr      x1, [x21]
006586990  ldrb     w8, [x1, #0x53]
006586994  tbnz     w8, #5, #0x65869a0
006586998  ldr      x25, [x20, #0x80]
00658699C  b        #0x65869b0 ; 
0065869A0  ldr      x8, [x1, #0x60]
0065869A4  mov      x0, x20
0065869A8  blr      x8
0065869AC  mov      x25, x0
0065869B0  cbz      x25, #0x658703c
0065869B4  adrp     x8, #0x9598000
0065869B8  ldrb     w8, [x8, #0xfcc]
0065869BC  cbnz     w8, #0x65869d8
0065869C0  adrp     x0, #0x8f06000
0065869C4  ldr      x0, [x0, #0x470]
0065869C8  bl       #0x382bd14 ; 
0065869CC  mov      w8, #1
0065869D0  adrp     x9, #0x9598000
0065869D4  strb     w8, [x9, #0xfcc]
0065869D8  adrp     x8, #0x8f06000
0065869DC  ldr      x8, [x8, #0x470]
0065869E0  ldr      x1, [x8]
0065869E4  ldrb     w8, [x1, #0x53]
0065869E8  tbnz     w8, #5, #0x65869f4
0065869EC  ldr      x0, [x25, #0x200]
0065869F0  b        #0x6586a00 ; 
0065869F4  ldr      x8, [x1, #0x60]
0065869F8  mov      x0, x25
0065869FC  blr      x8
006586A00  cbz      x0, #0x658703c
006586A04  add      x8, x26, x24, lsl #7
006586A08  add      x27, x8, #0x60
006586A0C  ldr      w1, [x27]
006586A10  mov      x2, xzr
006586A14  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
006586A18  ldrb     w8, [x22, #0x286]
006586A1C  mov      x25, x0
006586A20  cbnz     w8, #0x6586a38
006586A24  adrp     x0, #0x8f07000
006586A28  ldr      x0, [x0, #0xc98]
006586A2C  bl       #0x382bd14 ; 
006586A30  mov      w8, #1
006586A34  strb     w8, [x22, #0x286]
006586A38  adrp     x8, #0x8f07000
006586A3C  ldr      x8, [x8, #0xc98]
006586A40  ldr      x1, [x8]
006586A44  ldrb     w8, [x1, #0x53]
006586A48  tbnz     w8, #5, #0x6586a54
006586A4C  ldr      x0, [x20, #0x80]
006586A50  b        #0x6586a60 ; 
006586A54  ldr      x8, [x1, #0x60]
006586A58  mov      x0, x20
006586A5C  blr      x8
006586A60  cbz      x0, #0x658703c
006586A64  ldrb     w8, [x0, #0x12]
006586A68  cbz      w8, #0x6586ab0
006586A6C  cbz      x25, #0x6586fa0
006586A70  adrp     x8, #0x9599000
006586A74  ldrb     w8, [x8, #0x29e]
006586A78  cbnz     w8, #0x6586a94
006586A7C  adrp     x0, #0x8f08000
006586A80  ldr      x0, [x0, #0x90]
006586A84  bl       #0x382bd14 ; 
006586A88  mov      w8, #1
006586A8C  adrp     x9, #0x9599000
006586A90  strb     w8, [x9, #0x29e]
006586A94  adrp     x8, #0x8f08000
006586A98  ldr      x8, [x8, #0x90]
006586A9C  ldr      x1, [x8]
006586AA0  ldrb     w8, [x1, #0x53]
006586AA4  tbnz     w8, #5, #0x6586ae8
006586AA8  ldr      w0, [x25, #0x120]
006586AAC  b        #0x6586af4 ; 
006586AB0  ldrb     w8, [x22, #0x286]
006586AB4  cbnz     w8, #0x6586acc
006586AB8  adrp     x0, #0x8f07000
006586ABC  ldr      x0, [x0, #0xc98]
006586AC0  bl       #0x382bd14 ; 
006586AC4  mov      w8, #1
006586AC8  strb     w8, [x22, #0x286]
006586ACC  adrp     x8, #0x8f07000
006586AD0  ldr      x8, [x8, #0xc98]
006586AD4  ldr      x1, [x8]
006586AD8  ldrb     w8, [x1, #0x53]
006586ADC  tbnz     w8, #5, #0x6586b34
006586AE0  ldr      x0, [x20, #0x80]
006586AE4  b        #0x6586b40 ; 
006586AE8  ldr      x8, [x1, #0x60]
006586AEC  mov      x0, x25
006586AF0  blr      x8
006586AF4  cmp      w0, #1
006586AF8  b.lt     #0x6586fa0
006586AFC  ldrb     w8, [x22, #0x286]
006586B00  cbnz     w8, #0x6586b18
006586B04  adrp     x0, #0x8f07000
006586B08  ldr      x0, [x0, #0xc98]
006586B0C  bl       #0x382bd14 ; 
006586B10  mov      w8, #1
006586B14  strb     w8, [x22, #0x286]
006586B18  adrp     x8, #0x8f07000
006586B1C  ldr      x8, [x8, #0xc98]
006586B20  ldr      x1, [x8]
006586B24  ldrb     w8, [x1, #0x53]
006586B28  tbnz     w8, #5, #0x6586bc8
006586B2C  ldr      x21, [x20, #0x80]
006586B30  b        #0x6586bd8 ; 
006586B34  ldr      x8, [x1, #0x60]
006586B38  mov      x0, x20
006586B3C  blr      x8
006586B40  cbz      x0, #0x658703c
006586B44  ldrb     w8, [x0, #0x11]
006586B48  cbz      w8, #0x6586b90
006586B4C  cbz      x25, #0x6586fa0
006586B50  adrp     x8, #0x9591000
006586B54  ldrb     w8, [x8, #0xa75]
006586B58  cbnz     w8, #0x6586b74
006586B5C  adrp     x0, #0x8ee6000
006586B60  ldr      x0, [x0, #0x290]
006586B64  bl       #0x382bd14 ; 
006586B68  mov      w8, #1
006586B6C  adrp     x9, #0x9591000
006586B70  strb     w8, [x9, #0xa75]
006586B74  adrp     x8, #0x8ee6000
006586B78  ldr      x8, [x8, #0x290]
006586B7C  ldr      x1, [x8]
006586B80  ldrb     w8, [x1, #0x53]
006586B84  tbnz     w8, #5, #0x6586c6c
006586B88  ldr      w0, [x25, #0x24]
006586B8C  b        #0x6586c78 ; 
006586B90  ldrb     w8, [x22, #0x286]
006586B94  cbnz     w8, #0x6586bac
006586B98  adrp     x0, #0x8f07000
006586B9C  ldr      x0, [x0, #0xc98]
006586BA0  bl       #0x382bd14 ; 
006586BA4  mov      w8, #1
006586BA8  strb     w8, [x22, #0x286]
006586BAC  adrp     x8, #0x8f07000
006586BB0  ldr      x8, [x8, #0xc98]
006586BB4  ldr      x1, [x8]
006586BB8  ldrb     w8, [x1, #0x53]
006586BBC  tbnz     w8, #5, #0x6586cb8
006586BC0  ldr      x0, [x20, #0x80]
006586BC4  b        #0x6586cc4 ; 
006586BC8  ldr      x8, [x1, #0x60]
006586BCC  mov      x0, x20
006586BD0  blr      x8
006586BD4  mov      x21, x0
006586BD8  add      x25, x26, x24, lsl #7
006586BDC  ldr      x8, [x25, #0x40]
006586BE0  ldr      q0, [x25, #0x30]
006586BE4  ldr      w26, [x27]
006586BE8  mov      x22, x25
006586BEC  str      x8, [sp, #0x340]
006586BF0  str      q0, [sp, #0x330]
006586BF4  ldr      x8, [x25, #0x58]
006586BF8  ldur     q0, [x25, #0x48]
006586BFC  mov      x0, x20
006586C00  str      x8, [sp, #0x320]
006586C04  str      q0, [sp, #0x310]
006586C08  ldr      w1, [x22, #0x98]!
006586C0C  ldr      x8, [x20]
006586C10  ldur     x28, [x22, #-0x28]
006586C14  ldr      x9, [x8, #0x588]
006586C18  ldr      x2, [x8, #0x590]
006586C1C  ldur     x27, [x22, #-0x10]
006586C20  blr      x9
006586C24  cbz      x21, #0x658703c
006586C28  ldr      x8, [x25, #0x90]
006586C2C  ldr      w9, [x22]
006586C30  ldr      q0, [sp, #0x330]
006586C34  ldr      x11, [sp, #0x340]
006586C38  ldr      q1, [sp, #0x310]
006586C3C  ldr      x12, [sp, #0x320]
006586C40  ldrb     w10, [x25, #0x9c]
006586C44  mov      x7, x0
006586C48  str      q0, [sp, #0x190]
006586C4C  str      x11, [sp, #0x1a0]
006586C50  str      q1, [sp, #0x170]
006586C54  str      x12, [sp, #0x180]
006586C58  stp      x8, xzr, [sp, #0x10]
006586C5C  str      w9, [sp, #8]
006586C60  add      x2, sp, #0x190
006586C64  add      x3, sp, #0x170
006586C68  b        #0x6586f80 ; 
006586C6C  ldr      x8, [x1, #0x60]
006586C70  mov      x0, x25
006586C74  blr      x8
006586C78  cmp      w0, #3
006586C7C  b.eq     #0x6586fa0
006586C80  ldrb     w8, [x22, #0x286]
006586C84  cbnz     w8, #0x6586c9c
006586C88  adrp     x0, #0x8f07000
006586C8C  ldr      x0, [x0, #0xc98]
006586C90  bl       #0x382bd14 ; 
006586C94  mov      w8, #1
006586C98  strb     w8, [x22, #0x286]
006586C9C  adrp     x8, #0x8f07000
006586CA0  ldr      x8, [x8, #0xc98]
006586CA4  ldr      x1, [x8]
006586CA8  ldrb     w8, [x1, #0x53]
006586CAC  tbnz     w8, #5, #0x6586d4c
006586CB0  ldr      x21, [x20, #0x80]
006586CB4  b        #0x6586d5c ; 
006586CB8  ldr      x8, [x1, #0x60]
006586CBC  mov      x0, x20
006586CC0  blr      x8
006586CC4  cbz      x0, #0x658703c
006586CC8  ldrb     w8, [x0, #0x10]
006586CCC  cbz      w8, #0x6586d14
006586CD0  cbz      x25, #0x6586fa0
006586CD4  adrp     x8, #0x9591000
006586CD8  ldrb     w8, [x8, #0xa75]
006586CDC  cbnz     w8, #0x6586cf8
006586CE0  adrp     x0, #0x8ee6000
006586CE4  ldr      x0, [x0, #0x290]
006586CE8  bl       #0x382bd14 ; 
006586CEC  mov      w8, #1
006586CF0  adrp     x9, #0x9591000
006586CF4  strb     w8, [x9, #0xa75]
006586CF8  adrp     x8, #0x8ee6000
006586CFC  ldr      x8, [x8, #0x290]
006586D00  ldr      x1, [x8]
006586D04  ldrb     w8, [x1, #0x53]
006586D08  tbnz     w8, #5, #0x6586df0
006586D0C  ldr      w0, [x25, #0x24]
006586D10  b        #0x6586dfc ; 
006586D14  ldrb     w8, [x22, #0x286]
006586D18  cbnz     w8, #0x6586d30
006586D1C  adrp     x0, #0x8f07000
006586D20  ldr      x0, [x0, #0xc98]
006586D24  bl       #0x382bd14 ; 
006586D28  mov      w8, #1
006586D2C  strb     w8, [x22, #0x286]
006586D30  adrp     x8, #0x8f07000
006586D34  ldr      x8, [x8, #0xc98]
006586D38  ldr      x1, [x8]
006586D3C  ldrb     w8, [x1, #0x53]
006586D40  tbnz     w8, #5, #0x6586e3c
006586D44  ldr      x21, [x20, #0x80]
006586D48  b        #0x6586e4c ; 
006586D4C  ldr      x8, [x1, #0x60]
006586D50  mov      x0, x20
006586D54  blr      x8
006586D58  mov      x21, x0
006586D5C  add      x25, x26, x24, lsl #7
006586D60  ldr      x8, [x25, #0x40]
006586D64  ldr      q0, [x25, #0x30]
006586D68  ldr      w26, [x27]
006586D6C  mov      x22, x25
006586D70  str      x8, [sp, #0x340]
006586D74  str      q0, [sp, #0x330]
006586D78  ldr      x8, [x25, #0x58]
006586D7C  ldur     q0, [x25, #0x48]
006586D80  mov      x0, x20
006586D84  str      x8, [sp, #0x320]
006586D88  str      q0, [sp, #0x310]
006586D8C  ldr      w1, [x22, #0x98]!
006586D90  ldr      x8, [x20]
006586D94  ldur     x28, [x22, #-0x28]
006586D98  ldr      x9, [x8, #0x588]
006586D9C  ldr      x2, [x8, #0x590]
006586DA0  ldur     x27, [x22, #-0x10]
006586DA4  blr      x9
006586DA8  cbz      x21, #0x658703c
006586DAC  ldr      x8, [x25, #0x90]
006586DB0  ldr      w9, [x22]
006586DB4  ldr      q0, [sp, #0x330]
006586DB8  ldr      x11, [sp, #0x340]
006586DBC  ldr      q1, [sp, #0x310]
006586DC0  ldr      x12, [sp, #0x320]
006586DC4  ldrb     w10, [x25, #0x9c]
006586DC8  mov      x7, x0
006586DCC  str      q0, [sp, #0x150]
006586DD0  str      x11, [sp, #0x160]
006586DD4  str      q1, [sp, #0x130]
006586DD8  str      x12, [sp, #0x140]
006586DDC  stp      x8, xzr, [sp, #0x10]
006586DE0  str      w9, [sp, #8]
006586DE4  add      x2, sp, #0x150
006586DE8  add      x3, sp, #0x130
006586DEC  b        #0x6586f80 ; 
006586DF0  ldr      x8, [x1, #0x60]
006586DF4  mov      x0, x25
006586DF8  blr      x8
006586DFC  cmp      w0, #3
006586E00  b.ne     #0x6586fa0
006586E04  ldrb     w8, [x22, #0x286]
006586E08  cbnz     w8, #0x6586e20
006586E0C  adrp     x0, #0x8f07000
006586E10  ldr      x0, [x0, #0xc98]
006586E14  bl       #0x382bd14 ; 
006586E18  mov      w8, #1
006586E1C  strb     w8, [x22, #0x286]
006586E20  adrp     x8, #0x8f07000
006586E24  ldr      x8, [x8, #0xc98]
006586E28  ldr      x1, [x8]
006586E2C  ldrb     w8, [x1, #0x53]
006586E30  tbnz     w8, #5, #0x6586ee0
006586E34  ldr      x21, [x20, #0x80]
006586E38  b        #0x6586ef0 ; 
006586E3C  ldr      x8, [x1, #0x60]
006586E40  mov      x0, x20
006586E44  blr      x8
006586E48  mov      x21, x0
006586E4C  add      x25, x26, x24, lsl #7
006586E50  ldr      x8, [x25, #0x40]
006586E54  ldr      q0, [x25, #0x30]
006586E58  ldr      w26, [x27]
006586E5C  mov      x22, x25
006586E60  str      x8, [sp, #0x340]
006586E64  str      q0, [sp, #0x330]
006586E68  ldr      x8, [x25, #0x58]
006586E6C  ldur     q0, [x25, #0x48]
006586E70  mov      x0, x20
006586E74  str      x8, [sp, #0x320]
006586E78  str      q0, [sp, #0x310]
006586E7C  ldr      w1, [x22, #0x98]!
006586E80  ldr      x8, [x20]
006586E84  ldur     x28, [x22, #-0x28]
006586E88  ldr      x9, [x8, #0x588]
006586E8C  ldr      x2, [x8, #0x590]
006586E90  ldur     x27, [x22, #-0x10]
006586E94  blr      x9
006586E98  cbz      x21, #0x658703c
006586E9C  ldr      x8, [x25, #0x90]
006586EA0  ldr      w9, [x22]
006586EA4  ldrb     w10, [x25, #0x9c]
006586EA8  ldr      q0, [sp, #0x330]
006586EAC  ldr      x11, [sp, #0x340]
006586EB0  ldr      q1, [sp, #0x310]
006586EB4  ldr      x12, [sp, #0x320]
006586EB8  mov      x7, x0
006586EBC  add      x2, sp, #0xd0
006586EC0  add      x3, sp, #0xb0
006586EC4  str      q0, [sp, #0xd0]
006586EC8  str      x11, [sp, #0xe0]
006586ECC  str      q1, [sp, #0xb0]
006586ED0  str      x12, [sp, #0xc0]
006586ED4  stp      x8, xzr, [sp, #0x10]
006586ED8  str      w9, [sp, #8]
006586EDC  b        #0x6586f80 ; 
006586EE0  ldr      x8, [x1, #0x60]
006586EE4  mov      x0, x20
006586EE8  blr      x8
006586EEC  mov      x21, x0
006586EF0  add      x25, x26, x24, lsl #7
006586EF4  ldr      x8, [x25, #0x40]
006586EF8  ldr      q0, [x25, #0x30]
006586EFC  ldr      w26, [x27]
006586F00  mov      x22, x25
006586F04  str      x8, [sp, #0x340]
006586F08  str      q0, [sp, #0x330]
006586F0C  ldr      x8, [x25, #0x58]
006586F10  ldur     q0, [x25, #0x48]
006586F14  mov      x0, x20
006586F18  str      x8, [sp, #0x320]
006586F1C  str      q0, [sp, #0x310]
006586F20  ldr      w1, [x22, #0x98]!
006586F24  ldr      x8, [x20]
006586F28  ldur     x28, [x22, #-0x28]
006586F2C  ldr      x9, [x8, #0x588]
006586F30  ldr      x2, [x8, #0x590]
006586F34  ldur     x27, [x22, #-0x10]
006586F38  blr      x9
006586F3C  cbz      x21, #0x658703c
006586F40  ldr      x8, [x25, #0x90]
006586F44  ldr      w9, [x22]
006586F48  ldr      q0, [sp, #0x330]
006586F4C  ldr      x11, [sp, #0x340]
006586F50  ldr      q1, [sp, #0x310]
006586F54  ldr      x12, [sp, #0x320]
006586F58  ldrb     w10, [x25, #0x9c]
006586F5C  mov      x7, x0
006586F60  str      q0, [sp, #0x110]
006586F64  str      x11, [sp, #0x120]
006586F68  str      q1, [sp, #0xf0]
006586F6C  str      x12, [sp, #0x100]
006586F70  stp      x8, xzr, [sp, #0x10]
006586F74  str      w9, [sp, #8]
006586F78  add      x2, sp, #0x110
006586F7C  add      x3, sp, #0xf0
006586F80  mov      x0, x21
006586F84  mov      w1, w26
006586F88  mov      x4, x28
006586F8C  mov      x5, x27
006586F90  mov      w6, wzr
006586F94  strb     w10, [sp]
006586F98  bl       #0x6a160a4 ; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
006586F9C  add      x28, sp, #0x2a8
006586FA0  ldr      w8, [x20, #0xa8]
006586FA4  ldr      x22, [x20, #0xa0]
006586FA8  sub      w8, w8, #1
006586FAC  str      w8, [x20, #0xa8]
006586FB0  cbz      x22, #0x658703c
006586FB4  ldr      w21, [x22, #0x18]
006586FB8  cmp      w8, w21
006586FBC  b.hs     #0x6587040
006586FC0  sxtw     x8, w8
006586FC4  add      x8, x22, x8, lsl #7
006586FC8  add      x1, x8, #0x20
006586FCC  add      x0, sp, #0x30
006586FD0  mov      w2, #0x80
006586FD4  bl       #0x89edad0 ; 
006586FD8  adrp     x27, #0x8f07000
006586FDC  ldr      x27, [x27, #0xc98]
006586FE0  cmp      w23, w21
006586FE4  b.hs     #0x6587040
006586FE8  add      x21, x22, x24, lsl #7
006586FEC  sub      w23, w23, #1
006586FF0  add      x0, x21, #0x20
006586FF4  add      x1, sp, #0x30
006586FF8  b        #0x6586814 ; 
006586FFC  ldr      x8, [x2, #0x60]
006587000  mov      x0, x20
006587004  mov      x1, x19
006587008  blr      x8
00658700C  ldr      x8, [x29, #0x28]
006587010  ldr      x9, [sp, #0x348]
006587014  cmp      x8, x9
006587018  b.ne     #0x6587044
00658701C  add      sp, sp, #0x350
006587020  ldp      x20, x19, [sp, #0x50]
006587024  ldp      x22, x21, [sp, #0x40]
006587028  ldp      x24, x23, [sp, #0x30]
00658702C  ldp      x26, x25, [sp, #0x20]
006587030  ldp      x28, x27, [sp, #0x10]
006587034  ldp      x29, x30, [sp], #0x60
006587038  ret      
00658703C  bl       #0x382bfb8 ; 
006587040  bl       #0x382bfc0 ; 
006587044  bl       #0x89edb60 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnLoadEnd
; RVA 0x6587AA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587AA8  stp      x30, x21, [sp, #-0x20]!
006587AAC  stp      x20, x19, [sp, #0x10]
006587AB0  adrp     x20, #0x9599000
006587AB4  adrp     x21, #0x8f08000
006587AB8  ldrb     w8, [x20, #0x179]
006587ABC  ldr      x21, [x21, #0x130]
006587AC0  mov      x19, x0
006587AC4  tbnz     w8, #0, #0x6587adc
006587AC8  adrp     x0, #0x8f08000
006587ACC  ldr      x0, [x0, #0x130]
006587AD0  bl       #0x382bd14 ; 
006587AD4  mov      w8, #1
006587AD8  strb     w8, [x20, #0x179]
006587ADC  ldr      x1, [x21]
006587AE0  ldrb     w8, [x1, #0x53]
006587AE4  tbnz     w8, #5, #0x6587af4
006587AE8  ldp      x20, x19, [sp, #0x10]
006587AEC  ldp      x30, x21, [sp], #0x20
006587AF0  ret      
006587AF4  ldr      x2, [x1, #0x60]
006587AF8  mov      x0, x19
006587AFC  ldp      x20, x19, [sp, #0x10]
006587B00  ldp      x30, x21, [sp], #0x20
006587B04  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$InitRefreshStateMachine
; RVA 0x6587B08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587B08  stp      x30, x21, [sp, #-0x20]!
006587B0C  stp      x20, x19, [sp, #0x10]
006587B10  adrp     x20, #0x9599000
006587B14  adrp     x21, #0x8f08000
006587B18  ldrb     w8, [x20, #0x17a]
006587B1C  ldr      x21, [x21, #0x138]
006587B20  mov      x19, x0
006587B24  tbnz     w8, #0, #0x6587bcc
006587B28  adrp     x0, #0x8f08000
006587B2C  ldr      x0, [x0, #0x138]
006587B30  bl       #0x382bd14 ; 
006587B34  adrp     x0, #0x8f08000
006587B38  ldr      x0, [x0, #0x140]
006587B3C  bl       #0x382bd14 ; 
006587B40  adrp     x0, #0x8f08000
006587B44  ldr      x0, [x0, #0x148]
006587B48  bl       #0x382bd14 ; 
006587B4C  adrp     x0, #0x8f08000
006587B50  ldr      x0, [x0, #0x150]
006587B54  bl       #0x382bd14 ; 
006587B58  adrp     x0, #0x8f08000
006587B5C  ldr      x0, [x0, #0x158]
006587B60  bl       #0x382bd14 ; 
006587B64  adrp     x0, #0x8f08000
006587B68  ldr      x0, [x0, #0x160]
006587B6C  bl       #0x382bd14 ; 
006587B70  adrp     x0, #0x8f08000
006587B74  ldr      x0, [x0, #0x168]
006587B78  bl       #0x382bd14 ; 
006587B7C  adrp     x0, #0x8f08000
006587B80  ldr      x0, [x0, #0x170]
006587B84  bl       #0x382bd14 ; 
006587B88  adrp     x0, #0x8f08000
006587B8C  ldr      x0, [x0, #0x178]
006587B90  bl       #0x382bd14 ; 
006587B94  adrp     x0, #0x8f08000
006587B98  ldr      x0, [x0, #0x180]
006587B9C  bl       #0x382bd14 ; 
006587BA0  adrp     x0, #0x8f08000
006587BA4  ldr      x0, [x0, #0x188]
006587BA8  bl       #0x382bd14 ; 
006587BAC  adrp     x0, #0x8f08000
006587BB0  ldr      x0, [x0, #0x190]
006587BB4  bl       #0x382bd14 ; 
006587BB8  adrp     x0, #0x8f08000
006587BBC  ldr      x0, [x0, #0x198]
006587BC0  bl       #0x382bd14 ; 
006587BC4  mov      w8, #1
006587BC8  strb     w8, [x20, #0x17a]
006587BCC  ldr      x1, [x21]
006587BD0  ldrb     w8, [x1, #0x53]
006587BD4  tbnz     w8, #5, #0x6587e4c
006587BD8  adrp     x8, #0x8f08000
006587BDC  ldr      x8, [x8, #0x170]
006587BE0  adrp     x21, #0x8f08000
006587BE4  ldr      x0, [x8]
006587BE8  ldr      x21, [x21, #0x158]
006587BEC  bl       #0x382bfa0 ; 
006587BF0  mov      x1, x19
006587BF4  mov      x2, xzr
006587BF8  mov      x20, x0
006587BFC  bl       #0x65bf854 ; HotFix.BattleLogic.RefreshStateMachine$$.ctor
006587C00  str      x20, [x19, #0xd8]!
006587C04  mov      x0, x19
006587C08  mov      x1, x20
006587C0C  bl       #0x382bcb8 ; 
006587C10  ldr      x0, [x21]
006587C14  ldr      x20, [x19]
006587C18  bl       #0x382bfa0 ; 
006587C1C  mov      x1, xzr
006587C20  mov      x21, x0
006587C24  bl       #0x65bdd08 ; HotFix.BattleLogic.RefreshNoneState$$.ctor
006587C28  cbz      x20, #0x6587e60
006587C2C  mov      x0, x20
006587C30  mov      x1, x21
006587C34  mov      x2, xzr
006587C38  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587C3C  adrp     x8, #0x8f08000
006587C40  ldr      x20, [x19]
006587C44  ldr      x8, [x8, #0x148]
006587C48  ldr      x0, [x8]
006587C4C  bl       #0x382bfa0 ; 
006587C50  mov      x1, xzr
006587C54  mov      x21, x0
006587C58  bl       #0x65bd9fc ; HotFix.BattleLogic.RefreshFirstState$$.ctor
006587C5C  cbz      x20, #0x6587e60
006587C60  mov      x0, x20
006587C64  mov      x1, x21
006587C68  mov      x2, xzr
006587C6C  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587C70  adrp     x8, #0x8f08000
006587C74  ldr      x20, [x19]
006587C78  ldr      x8, [x8, #0x178]
006587C7C  ldr      x0, [x8]
006587C80  bl       #0x382bfa0 ; 
006587C84  mov      x1, xzr
006587C88  mov      x21, x0
006587C8C  bl       #0x65bfe18 ; HotFix.BattleLogic.RefreshTimerState$$.ctor
006587C90  cbz      x20, #0x6587e60
006587C94  mov      x0, x20
006587C98  mov      x1, x21
006587C9C  mov      x2, xzr
006587CA0  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587CA4  adrp     x8, #0x8f08000
006587CA8  ldr      x20, [x19]
006587CAC  ldr      x8, [x8, #0x160]
006587CB0  ldr      x0, [x8]
006587CB4  bl       #0x382bfa0 ; 
006587CB8  mov      x1, xzr
006587CBC  mov      x21, x0
006587CC0  bl       #0x65bdfe4 ; HotFix.BattleLogic.RefreshNoticeState$$.ctor
006587CC4  cbz      x20, #0x6587e60
006587CC8  mov      x0, x20
006587CCC  mov      x1, x21
006587CD0  mov      x2, xzr
006587CD4  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587CD8  adrp     x8, #0x8f08000
006587CDC  ldr      x20, [x19]
006587CE0  ldr      x8, [x8, #0x140]
006587CE4  ldr      x0, [x8]
006587CE8  bl       #0x382bfa0 ; 
006587CEC  mov      x1, xzr
006587CF0  mov      x21, x0
006587CF4  bl       #0x65bd6f4 ; HotFix.BattleLogic.RefreshDevilState$$.ctor
006587CF8  cbz      x20, #0x6587e60
006587CFC  mov      x0, x20
006587D00  mov      x1, x21
006587D04  mov      x2, xzr
006587D08  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587D0C  adrp     x8, #0x8f08000
006587D10  ldr      x20, [x19]
006587D14  ldr      x8, [x8, #0x150]
006587D18  ldr      x0, [x8]
006587D1C  bl       #0x382bfa0 ; 
006587D20  mov      x1, xzr
006587D24  mov      x21, x0
006587D28  bl       #0x65bdc3c ; HotFix.BattleLogic.RefreshFortuneState$$.ctor
006587D2C  cbz      x20, #0x6587e60
006587D30  mov      x0, x20
006587D34  mov      x1, x21
006587D38  mov      x2, xzr
006587D3C  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587D40  adrp     x8, #0x8f08000
006587D44  ldr      x20, [x19]
006587D48  ldr      x8, [x8, #0x168]
006587D4C  ldr      x0, [x8]
006587D50  bl       #0x382bfa0 ; 
006587D54  mov      x1, xzr
006587D58  mov      x21, x0
006587D5C  bl       #0x65be0b0 ; HotFix.BattleLogic.RefreshPunchboardState$$.ctor
006587D60  cbz      x20, #0x6587e60
006587D64  mov      x0, x20
006587D68  mov      x1, x21
006587D6C  mov      x2, xzr
006587D70  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587D74  adrp     x8, #0x8f08000
006587D78  ldr      x20, [x19]
006587D7C  ldr      x8, [x8, #0x198]
006587D80  ldr      x0, [x8]
006587D84  bl       #0x382bfa0 ; 
006587D88  mov      x1, xzr
006587D8C  mov      x21, x0
006587D90  bl       #0x65c0224 ; HotFix.BattleLogic.RefreshWaveStartUIState$$.ctor
006587D94  cbz      x20, #0x6587e60
006587D98  mov      x0, x20
006587D9C  mov      x1, x21
006587DA0  mov      x2, xzr
006587DA4  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587DA8  adrp     x8, #0x8f08000
006587DAC  ldr      x20, [x19]
006587DB0  ldr      x8, [x8, #0x180]
006587DB4  ldr      x0, [x8]
006587DB8  bl       #0x382bfa0 ; 
006587DBC  mov      x1, xzr
006587DC0  mov      x21, x0
006587DC4  bl       #0x65bffb4 ; HotFix.BattleLogic.RefreshWaveEndState$$.ctor
006587DC8  cbz      x20, #0x6587e60
006587DCC  mov      x0, x20
006587DD0  mov      x1, x21
006587DD4  mov      x2, xzr
006587DD8  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587DDC  adrp     x8, #0x8f08000
006587DE0  ldr      x20, [x19]
006587DE4  ldr      x8, [x8, #0x190]
006587DE8  ldr      x0, [x8]
006587DEC  bl       #0x382bfa0 ; 
006587DF0  mov      x1, xzr
006587DF4  mov      x21, x0
006587DF8  bl       #0x65c02ec ; HotFix.BattleLogic.RefreshWaveStarUIState$$.ctor
006587DFC  cbz      x20, #0x6587e60
006587E00  mov      x0, x20
006587E04  mov      x1, x21
006587E08  mov      x2, xzr
006587E0C  bl       #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587E10  adrp     x8, #0x8f08000
006587E14  ldr      x19, [x19]
006587E18  ldr      x8, [x8, #0x188]
006587E1C  ldr      x0, [x8]
006587E20  bl       #0x382bfa0 ; 
006587E24  mov      x1, xzr
006587E28  mov      x20, x0
006587E2C  bl       #0x65c007c ; HotFix.BattleLogic.RefreshWaveEndUIState$$.ctor
006587E30  cbz      x19, #0x6587e60
006587E34  mov      x0, x19
006587E38  mov      x1, x20
006587E3C  ldp      x20, x19, [sp, #0x10]
006587E40  mov      x2, xzr
006587E44  ldp      x30, x21, [sp], #0x20
006587E48  b        #0x65bf944 ; HotFix.BattleLogic.RefreshStateMachine$$RegisterState
006587E4C  ldr      x2, [x1, #0x60]
006587E50  mov      x0, x19
006587E54  ldp      x20, x19, [sp, #0x10]
006587E58  ldp      x30, x21, [sp], #0x20
006587E5C  br       x2
006587E60  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckIsPauseStateInternal
; RVA 0x6587E64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587E64  stp      x30, x21, [sp, #-0x20]!
006587E68  stp      x20, x19, [sp, #0x10]
006587E6C  adrp     x20, #0x9599000
006587E70  adrp     x21, #0x8f08000
006587E74  ldrb     w8, [x20, #0x17b]
006587E78  ldr      x21, [x21, #0x1a0]
006587E7C  mov      x19, x0
006587E80  tbnz     w8, #0, #0x6587e98
006587E84  adrp     x0, #0x8f08000
006587E88  ldr      x0, [x0, #0x1a0]
006587E8C  bl       #0x382bd14 ; 
006587E90  mov      w8, #1
006587E94  strb     w8, [x20, #0x17b]
006587E98  ldr      x1, [x21]
006587E9C  ldrb     w8, [x1, #0x53]
006587EA0  tbnz     w8, #5, #0x6587eb4
006587EA4  ldr      x8, [x19]
006587EA8  ldr      x2, [x8, #0x5c8]
006587EAC  ldr      x1, [x8, #0x5d0]
006587EB0  b        #0x6587eb8 ; 
006587EB4  ldr      x2, [x1, #0x60]
006587EB8  mov      x0, x19
006587EBC  ldp      x20, x19, [sp, #0x10]
006587EC0  ldp      x30, x21, [sp], #0x20
006587EC4  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$GetNextNoticeTime
; RVA 0x6587EC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587EC8  stp      x30, x21, [sp, #-0x20]!
006587ECC  stp      x20, x19, [sp, #0x10]
006587ED0  adrp     x20, #0x9599000
006587ED4  adrp     x21, #0x8f08000
006587ED8  ldrb     w8, [x20, #0x17c]
006587EDC  ldr      x21, [x21, #0x1a8]
006587EE0  mov      x19, x0
006587EE4  tbnz     w8, #0, #0x6587efc
006587EE8  adrp     x0, #0x8f08000
006587EEC  ldr      x0, [x0, #0x1a8]
006587EF0  bl       #0x382bd14 ; 
006587EF4  mov      w8, #1
006587EF8  strb     w8, [x20, #0x17c]
006587EFC  ldr      x1, [x21]
006587F00  ldrb     w8, [x1, #0x53]
006587F04  tbnz     w8, #5, #0x6587f18
006587F08  ldr      x0, [x19, #0xb8]
006587F0C  ldp      x20, x19, [sp, #0x10]
006587F10  ldp      x30, x21, [sp], #0x20
006587F14  ret      
006587F18  ldr      x2, [x1, #0x60]
006587F1C  mov      x0, x19
006587F20  ldp      x20, x19, [sp, #0x10]
006587F24  ldp      x30, x21, [sp], #0x20
006587F28  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$GetCurrentIsLastMission
; RVA 0x6587F2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587F2C  stp      x30, x21, [sp, #-0x20]!
006587F30  stp      x20, x19, [sp, #0x10]
006587F34  adrp     x20, #0x9599000
006587F38  adrp     x21, #0x8f08000
006587F3C  ldrb     w8, [x20, #0x17d]
006587F40  ldr      x21, [x21, #0x1b0]
006587F44  mov      x19, x0
006587F48  tbnz     w8, #0, #0x6587f60
006587F4C  adrp     x0, #0x8f08000
006587F50  ldr      x0, [x0, #0x1b0]
006587F54  bl       #0x382bd14 ; 
006587F58  mov      w8, #1
006587F5C  strb     w8, [x20, #0x17d]
006587F60  ldr      x1, [x21]
006587F64  ldrb     w8, [x1, #0x53]
006587F68  tbnz     w8, #5, #0x6587f7c
006587F6C  ldrb     w0, [x19, #0x102]
006587F70  ldp      x20, x19, [sp, #0x10]
006587F74  ldp      x30, x21, [sp], #0x20
006587F78  ret      
006587F7C  ldr      x2, [x1, #0x60]
006587F80  mov      x0, x19
006587F84  ldp      x20, x19, [sp, #0x10]
006587F88  ldp      x30, x21, [sp], #0x20
006587F8C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$GetRefreshNextMissionTime
; RVA 0x6587F90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587F90  stp      x30, x21, [sp, #-0x20]!
006587F94  stp      x20, x19, [sp, #0x10]
006587F98  adrp     x20, #0x9599000
006587F9C  adrp     x21, #0x8f08000
006587FA0  ldrb     w8, [x20, #0x17e]
006587FA4  ldr      x21, [x21, #0x1b8]
006587FA8  mov      x19, x0
006587FAC  tbnz     w8, #0, #0x6587fc4
006587FB0  adrp     x0, #0x8f08000
006587FB4  ldr      x0, [x0, #0x1b8]
006587FB8  bl       #0x382bd14 ; 
006587FBC  mov      w8, #1
006587FC0  strb     w8, [x20, #0x17e]
006587FC4  ldr      x1, [x21]
006587FC8  ldrb     w8, [x1, #0x53]
006587FCC  tbnz     w8, #5, #0x6587fe0
006587FD0  ldr      x0, [x19, #0xb0]
006587FD4  ldp      x20, x19, [sp, #0x10]
006587FD8  ldp      x30, x21, [sp], #0x20
006587FDC  ret      
006587FE0  ldr      x2, [x1, #0x60]
006587FE4  mov      x0, x19
006587FE8  ldp      x20, x19, [sp, #0x10]
006587FEC  ldp      x30, x21, [sp], #0x20
006587FF0  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$GetCurMissionType
; RVA 0x6587FF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587FF4  stp      x30, x21, [sp, #-0x20]!
006587FF8  stp      x20, x19, [sp, #0x10]
006587FFC  adrp     x20, #0x9599000
006588000  adrp     x21, #0x8f08000
006588004  ldrb     w8, [x20, #0x17f]
006588008  ldr      x21, [x21, #0x1c0]
00658800C  mov      x19, x0
006588010  tbnz     w8, #0, #0x6588028
006588014  adrp     x0, #0x8f08000
006588018  ldr      x0, [x0, #0x1c0]
00658801C  bl       #0x382bd14 ; 
006588020  mov      w8, #1
006588024  strb     w8, [x20, #0x17f]
006588028  ldr      x1, [x21]
00658802C  ldrb     w8, [x1, #0x53]
006588030  tbnz     w8, #5, #0x6588044
006588034  ldr      w0, [x19, #0xe0]
006588038  ldp      x20, x19, [sp, #0x10]
00658803C  ldp      x30, x21, [sp], #0x20
006588040  ret      
006588044  ldr      x2, [x1, #0x60]
006588048  mov      x0, x19
00658804C  ldp      x20, x19, [sp, #0x10]
006588050  ldp      x30, x21, [sp], #0x20
006588054  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$NextWaveInternal
; RVA 0x6588058; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588058  stp      x30, x23, [sp, #-0x30]!
00658805C  stp      x22, x21, [sp, #0x10]
006588060  stp      x20, x19, [sp, #0x20]
006588064  adrp     x20, #0x9599000
006588068  adrp     x21, #0x8f08000
00658806C  ldrb     w8, [x20, #0x180]
006588070  ldr      x21, [x21, #0x1c8]
006588074  mov      x19, x0
006588078  tbnz     w8, #0, #0x6588090
00658807C  adrp     x0, #0x8f08000
006588080  ldr      x0, [x0, #0x1c8]
006588084  bl       #0x382bd14 ; 
006588088  mov      w8, #1
00658808C  strb     w8, [x20, #0x180]
006588090  ldr      x1, [x21]
006588094  ldrb     w8, [x1, #0x53]
006588098  tbnz     w8, #5, #0x65880d8
00658809C  adrp     x21, #0x9599000
0065880A0  ldrb     w8, [x21, #0x286]
0065880A4  cbnz     w8, #0x65880bc
0065880A8  adrp     x0, #0x8f07000
0065880AC  ldr      x0, [x0, #0xc98]
0065880B0  bl       #0x382bd14 ; 
0065880B4  mov      w8, #1
0065880B8  strb     w8, [x21, #0x286]
0065880BC  adrp     x22, #0x8f07000
0065880C0  ldr      x22, [x22, #0xc98]
0065880C4  ldr      x1, [x22]
0065880C8  ldrb     w8, [x1, #0x53]
0065880CC  tbnz     w8, #5, #0x65880e0
0065880D0  ldr      x20, [x19, #0x80]
0065880D4  b        #0x65880f0 ; 
0065880D8  ldr      x2, [x1, #0x60]
0065880DC  b        #0x658829c ; 
0065880E0  ldr      x8, [x1, #0x60]
0065880E4  mov      x0, x19
0065880E8  blr      x8
0065880EC  mov      x20, x0
0065880F0  cbz      x20, #0x65882b0
0065880F4  adrp     x23, #0x9599000
0065880F8  ldrb     w8, [x23, #0x287]
0065880FC  cbnz     w8, #0x6588114
006588100  adrp     x0, #0x8f07000
006588104  ldr      x0, [x0, #0xcf0]
006588108  bl       #0x382bd14 ; 
00658810C  mov      w8, #1
006588110  strb     w8, [x23, #0x287]
006588114  adrp     x8, #0x8f07000
006588118  ldr      x8, [x8, #0xcf0]
00658811C  ldr      x1, [x8]
006588120  ldrb     w8, [x1, #0x53]
006588124  tbnz     w8, #5, #0x6588130
006588128  ldr      x0, [x20, #0x350]
00658812C  b        #0x658813c ; 
006588130  ldr      x8, [x1, #0x60]
006588134  mov      x0, x20
006588138  blr      x8
00658813C  cbz      x0, #0x65882b0
006588140  mov      x1, xzr
006588144  bl       #0x66703e4 ; HotFix.BattleLogic.DropMgr$$AbsorbAllEquip
006588148  ldr      x8, [x19]
00658814C  mov      x0, x19
006588150  ldr      x9, [x8, #0x628]
006588154  ldr      x1, [x8, #0x630]
006588158  blr      x9
00658815C  ldr      x8, [x19]
006588160  strb     wzr, [x19, #0x101]
006588164  mov      x0, x19
006588168  ldr      x9, [x8, #0x3e8]
00658816C  ldr      x1, [x8, #0x3f0]
006588170  blr      x9
006588174  ldrb     w8, [x21, #0x286]
006588178  cbnz     w8, #0x6588190
00658817C  adrp     x0, #0x8f07000
006588180  ldr      x0, [x0, #0xc98]
006588184  bl       #0x382bd14 ; 
006588188  mov      w8, #1
00658818C  strb     w8, [x21, #0x286]
006588190  ldr      x1, [x22]
006588194  ldrb     w8, [x1, #0x53]
006588198  tbnz     w8, #5, #0x65881a4
00658819C  ldr      x20, [x19, #0x80]
0065881A0  b        #0x65881b4 ; 
0065881A4  ldr      x8, [x1, #0x60]
0065881A8  mov      x0, x19
0065881AC  blr      x8
0065881B0  mov      x20, x0
0065881B4  cbz      x20, #0x65882b0
0065881B8  adrp     x23, #0x9599000
0065881BC  ldrb     w8, [x23, #0x29f]
0065881C0  cbnz     w8, #0x65881d8
0065881C4  adrp     x0, #0x8f08000
0065881C8  ldr      x0, [x0, #0x1d0]
0065881CC  bl       #0x382bd14 ; 
0065881D0  mov      w8, #1
0065881D4  strb     w8, [x23, #0x29f]
0065881D8  adrp     x8, #0x8f08000
0065881DC  ldr      x8, [x8, #0x1d0]
0065881E0  ldr      x1, [x8]
0065881E4  ldrb     w8, [x1, #0x53]
0065881E8  tbnz     w8, #5, #0x65881f8
0065881EC  add      x0, x20, #0x290
0065881F0  bl       #0x658f4d0 ; HotFix.BattleLogic.BattleData$$ClearExBattleAttr
0065881F4  b        #0x6588204 ; 
0065881F8  ldr      x8, [x1, #0x60]
0065881FC  mov      x0, x20
006588200  blr      x8
006588204  ldrb     w8, [x21, #0x286]
006588208  cbnz     w8, #0x6588220
00658820C  adrp     x0, #0x8f07000
006588210  ldr      x0, [x0, #0xc98]
006588214  bl       #0x382bd14 ; 
006588218  mov      w8, #1
00658821C  strb     w8, [x21, #0x286]
006588220  ldr      x1, [x22]
006588224  ldrb     w8, [x1, #0x53]
006588228  tbnz     w8, #5, #0x6588234
00658822C  ldr      x20, [x19, #0x80]
006588230  b        #0x6588244 ; 
006588234  ldr      x8, [x1, #0x60]
006588238  mov      x0, x19
00658823C  blr      x8
006588240  mov      x20, x0
006588244  cbz      x20, #0x65882b0
006588248  adrp     x21, #0x9599000
00658824C  ldrb     w8, [x21, #0x2a0]
006588250  cbnz     w8, #0x6588268
006588254  adrp     x0, #0x8f08000
006588258  ldr      x0, [x0, #0x1d8]
00658825C  bl       #0x382bd14 ; 
006588260  mov      w8, #1
006588264  strb     w8, [x21, #0x2a0]
006588268  adrp     x8, #0x8f08000
00658826C  ldr      x8, [x8, #0x1d8]
006588270  ldr      x1, [x8]
006588274  ldrb     w8, [x1, #0x53]
006588278  tbnz     w8, #5, #0x6588284
00658827C  str      wzr, [x20, #0x2d8]
006588280  b        #0x6588290 ; 
006588284  ldr      x8, [x1, #0x60]
006588288  mov      x0, x20
00658828C  blr      x8
006588290  ldr      x8, [x19]
006588294  ldr      x2, [x8, #0x418]
006588298  ldr      x1, [x8, #0x420]
00658829C  mov      x0, x19
0065882A0  ldp      x20, x19, [sp, #0x20]
0065882A4  ldp      x22, x21, [sp, #0x10]
0065882A8  ldp      x30, x23, [sp], #0x30
0065882AC  br       x2
0065882B0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$ResetEnemyAppearFlag
; RVA 0x65882B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065882B4  stp      x30, x21, [sp, #-0x20]!
0065882B8  stp      x20, x19, [sp, #0x10]
0065882BC  adrp     x20, #0x9599000
0065882C0  adrp     x21, #0x8f08000
0065882C4  ldrb     w8, [x20, #0x181]
0065882C8  ldr      x21, [x21, #0x1e0]
0065882CC  mov      x19, x0
0065882D0  tbnz     w8, #0, #0x65882e8
0065882D4  adrp     x0, #0x8f08000
0065882D8  ldr      x0, [x0, #0x1e0]
0065882DC  bl       #0x382bd14 ; 
0065882E0  mov      w8, #1
0065882E4  strb     w8, [x20, #0x181]
0065882E8  ldr      x1, [x21]
0065882EC  ldrb     w8, [x1, #0x53]
0065882F0  tbnz     w8, #5, #0x6588304
0065882F4  strb     wzr, [x19, #0x101]
0065882F8  ldp      x20, x19, [sp, #0x10]
0065882FC  ldp      x30, x21, [sp], #0x20
006588300  ret      
006588304  ldr      x2, [x1, #0x60]
006588308  mov      x0, x19
00658830C  ldp      x20, x19, [sp, #0x10]
006588310  ldp      x30, x21, [sp], #0x20
006588314  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$GetCurPlayer
; RVA 0x6588318; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588318  stp      x30, x21, [sp, #-0x20]!
00658831C  stp      x20, x19, [sp, #0x10]
006588320  adrp     x20, #0x9599000
006588324  adrp     x21, #0x8f08000
006588328  ldrb     w8, [x20, #0x182]
00658832C  ldr      x21, [x21, #0x1e8]
006588330  mov      x19, x0
006588334  tbnz     w8, #0, #0x658834c
006588338  adrp     x0, #0x8f08000
00658833C  ldr      x0, [x0, #0x1e8]
006588340  bl       #0x382bd14 ; 
006588344  mov      w8, #1
006588348  strb     w8, [x20, #0x182]
00658834C  ldr      x1, [x21]
006588350  ldrb     w8, [x1, #0x53]
006588354  tbnz     w8, #5, #0x6588368
006588358  ldr      x0, [x19, #0x88]
00658835C  ldp      x20, x19, [sp, #0x10]
006588360  ldp      x30, x21, [sp], #0x20
006588364  ret      
006588368  ldr      x2, [x1, #0x60]
00658836C  mov      x0, x19
006588370  ldp      x20, x19, [sp, #0x10]
006588374  ldp      x30, x21, [sp], #0x20
006588378  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$TriggerWaveFinishEventInternal
; RVA 0x658837C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658837C  str      x30, [sp, #-0x30]!
006588380  stp      x22, x21, [sp, #0x10]
006588384  stp      x20, x19, [sp, #0x20]
006588388  adrp     x21, #0x9599000
00658838C  adrp     x22, #0x8f08000
006588390  ldrb     w8, [x21, #0x183]
006588394  ldr      x22, [x22, #0x1f0]
006588398  mov      w19, w1
00658839C  mov      x20, x0
0065883A0  tbnz     w8, #0, #0x65883b8
0065883A4  adrp     x0, #0x8f08000
0065883A8  ldr      x0, [x0, #0x1f0]
0065883AC  bl       #0x382bd14 ; 
0065883B0  mov      w8, #1
0065883B4  strb     w8, [x21, #0x183]
0065883B8  ldr      x2, [x22]
0065883BC  ldrb     w8, [x2, #0x53]
0065883C0  tbnz     w8, #5, #0x65883e0
0065883C4  mov      x0, x20
0065883C8  mov      w1, w19
0065883CC  ldp      x20, x19, [sp, #0x20]
0065883D0  ldp      x22, x21, [sp, #0x10]
0065883D4  mov      x2, xzr
0065883D8  ldr      x30, [sp], #0x30
0065883DC  b        #0x65c4d30 ; HotFix.BattleLogic.SinglePlayerBattleManager$$TriggerWaveFinishEvent
0065883E0  ldr      x3, [x2, #0x60]
0065883E4  mov      x0, x20
0065883E8  mov      w1, w19
0065883EC  ldp      x20, x19, [sp, #0x20]
0065883F0  ldp      x22, x21, [sp, #0x10]
0065883F4  ldr      x30, [sp], #0x30
0065883F8  br       x3

; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_MissionType
; RVA 0x65883FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065883FC  stp      x30, x21, [sp, #-0x20]!
006588400  stp      x20, x19, [sp, #0x10]
006588404  adrp     x20, #0x9599000
006588408  adrp     x21, #0x8f08000
00658840C  ldrb     w8, [x20, #0x184]
006588410  ldr      x21, [x21, #0x1f8]
006588414  mov      x19, x0
006588418  tbnz     w8, #0, #0x6588430
00658841C  adrp     x0, #0x8f08000
006588420  ldr      x0, [x0, #0x1f8]
006588424  bl       #0x382bd14 ; 
006588428  mov      w8, #1
00658842C  strb     w8, [x20, #0x184]
006588430  ldr      x1, [x21]
006588434  ldrb     w8, [x1, #0x53]
006588438  tbnz     w8, #5, #0x658844c
00658843C  ldr      w0, [x19, #0xe0]
006588440  ldp      x20, x19, [sp, #0x10]
006588444  ldp      x30, x21, [sp], #0x20
006588448  ret      
00658844C  ldr      x2, [x1, #0x60]
006588450  mov      x0, x19
006588454  ldp      x20, x19, [sp, #0x10]
006588458  ldp      x30, x21, [sp], #0x20
00658845C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetNextMissionData
; RVA 0x6588460; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588460  str      x30, [sp, #-0x30]!
006588464  stp      x22, x21, [sp, #0x10]
006588468  stp      x20, x19, [sp, #0x20]
00658846C  adrp     x21, #0x9599000
006588470  adrp     x22, #0x8f08000
006588474  ldrb     w8, [x21, #0x185]
006588478  ldr      x22, [x22, #0x200]
00658847C  mov      w19, w1
006588480  mov      x20, x0
006588484  tbnz     w8, #0, #0x658849c
006588488  adrp     x0, #0x8f08000
00658848C  ldr      x0, [x0, #0x200]
006588490  bl       #0x382bd14 ; 
006588494  mov      w8, #1
006588498  strb     w8, [x21, #0x185]
00658849C  ldr      x2, [x22]
0065884A0  ldrb     w8, [x2, #0x53]
0065884A4  tbnz     w8, #5, #0x65884bc
0065884A8  str      w19, [x20, #0xc0]
0065884AC  ldp      x20, x19, [sp, #0x20]
0065884B0  ldp      x22, x21, [sp, #0x10]
0065884B4  ldr      x30, [sp], #0x30
0065884B8  ret      
0065884BC  ldr      x3, [x2, #0x60]
0065884C0  mov      x0, x20
0065884C4  mov      w1, w19
0065884C8  ldp      x20, x19, [sp, #0x20]
0065884CC  ldp      x22, x21, [sp, #0x10]
0065884D0  ldr      x30, [sp], #0x30
0065884D4  br       x3

; HotFix.BattleLogic.BaseSurvivalBattleManager$$InitWaterfall
; RVA 0x65884D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065884D8  stp      x30, x21, [sp, #-0x20]!
0065884DC  stp      x20, x19, [sp, #0x10]
0065884E0  adrp     x20, #0x9599000
0065884E4  adrp     x21, #0x8f08000
0065884E8  ldrb     w8, [x20, #0x186]
0065884EC  ldr      x21, [x21, #0x208]
0065884F0  mov      x19, x0
0065884F4  tbnz     w8, #0, #0x658850c
0065884F8  adrp     x0, #0x8f08000
0065884FC  ldr      x0, [x0, #0x208]
006588500  bl       #0x382bd14 ; 
006588504  mov      w8, #1
006588508  strb     w8, [x20, #0x186]
00658850C  ldr      x1, [x21]
006588510  ldrb     w8, [x1, #0x53]
006588514  tbnz     w8, #5, #0x6588528
006588518  str      xzr, [x19, #0xe8]
00658851C  ldp      x20, x19, [sp, #0x10]
006588520  ldp      x30, x21, [sp], #0x20
006588524  ret      
006588528  ldr      x2, [x1, #0x60]
00658852C  mov      x0, x19
006588530  ldp      x20, x19, [sp, #0x10]
006588534  ldp      x30, x21, [sp], #0x20
006588538  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$InitNoticeTime
; RVA 0x658853C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658853C  stp      x30, x21, [sp, #-0x20]!
006588540  stp      x20, x19, [sp, #0x10]
006588544  adrp     x20, #0x9599000
006588548  adrp     x21, #0x8f08000
00658854C  ldrb     w8, [x20, #0x187]
006588550  ldr      x21, [x21, #0x210]
006588554  mov      x19, x0
006588558  tbnz     w8, #0, #0x6588570
00658855C  adrp     x0, #0x8f08000
006588560  ldr      x0, [x0, #0x210]
006588564  bl       #0x382bd14 ; 
006588568  mov      w8, #1
00658856C  strb     w8, [x20, #0x187]
006588570  ldr      x1, [x21]
006588574  ldrb     w8, [x1, #0x53]
006588578  tbnz     w8, #5, #0x658858c
00658857C  mov      x0, x19
006588580  ldp      x20, x19, [sp, #0x10]
006588584  ldp      x30, x21, [sp], #0x20
006588588  b        #0x65885a0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$InitNormalNoticeTime
00658858C  ldr      x2, [x1, #0x60]
006588590  mov      x0, x19
006588594  ldp      x20, x19, [sp, #0x10]
006588598  ldp      x30, x21, [sp], #0x20
00658859C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$InitNormalNoticeTime
; RVA 0x65885A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065885A0  stp      x30, x21, [sp, #-0x20]!
0065885A4  stp      x20, x19, [sp, #0x10]
0065885A8  adrp     x20, #0x9599000
0065885AC  adrp     x21, #0x8f08000
0065885B0  ldrb     w8, [x20, #0x188]
0065885B4  ldr      x21, [x21, #0x218]
0065885B8  mov      x19, x0
0065885BC  tbnz     w8, #0, #0x65885d4
0065885C0  adrp     x0, #0x8f08000
0065885C4  ldr      x0, [x0, #0x218]
0065885C8  bl       #0x382bd14 ; 
0065885CC  mov      w8, #1
0065885D0  strb     w8, [x20, #0x188]
0065885D4  ldr      x1, [x21]
0065885D8  ldrb     w8, [x1, #0x53]
0065885DC  tbnz     w8, #5, #0x6588608
0065885E0  mov      w8, #0x1c000
0065885E4  mov      x1, x19
0065885E8  str      x8, [x1, #0xb8]!
0065885EC  ldr      x8, [x19]
0065885F0  mov      x0, x19
0065885F4  ldp      x20, x19, [sp, #0x10]
0065885F8  ldr      x3, [x8, #0x5e8]
0065885FC  ldr      x2, [x8, #0x5f0]
006588600  ldp      x30, x21, [sp], #0x20
006588604  br       x3
006588608  ldr      x2, [x1, #0x60]
00658860C  mov      x0, x19
006588610  ldp      x20, x19, [sp, #0x10]
006588614  ldp      x30, x21, [sp], #0x20
006588618  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$FixNoticeTime
; RVA 0x658861C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658861C  str      x30, [sp, #-0x30]!
006588620  stp      x22, x21, [sp, #0x10]
006588624  stp      x20, x19, [sp, #0x20]
006588628  adrp     x21, #0x9599000
00658862C  adrp     x22, #0x8f08000
006588630  ldrb     w8, [x21, #0x189]
006588634  ldr      x22, [x22, #0x220]
006588638  mov      x19, x1
00658863C  mov      x20, x0
006588640  tbnz     w8, #0, #0x6588658
006588644  adrp     x0, #0x8f08000
006588648  ldr      x0, [x0, #0x220]
00658864C  bl       #0x382bd14 ; 
006588650  mov      w8, #1
006588654  strb     w8, [x21, #0x189]
006588658  ldr      x2, [x22]
00658865C  ldrb     w8, [x2, #0x53]
006588660  tbnz     w8, #5, #0x658867c
006588664  mov      w8, #0x8000
006588668  str      x8, [x19]
00658866C  ldp      x20, x19, [sp, #0x20]
006588670  ldp      x22, x21, [sp, #0x10]
006588674  ldr      x30, [sp], #0x30
006588678  ret      
00658867C  ldr      x3, [x2, #0x60]
006588680  mov      x0, x20
006588684  mov      x1, x19
006588688  ldp      x20, x19, [sp, #0x20]
00658868C  ldp      x22, x21, [sp, #0x10]
006588690  ldr      x30, [sp], #0x30
006588694  br       x3

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreateMissionNpc
; RVA 0x6588698; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588698  str      x30, [sp, #-0x30]!
00658869C  stp      x22, x21, [sp, #0x10]
0065886A0  stp      x20, x19, [sp, #0x20]
0065886A4  adrp     x21, #0x9599000
0065886A8  adrp     x22, #0x8f08000
0065886AC  ldrb     w8, [x21, #0x18a]
0065886B0  ldr      x22, [x22, #0x228]
0065886B4  mov      x20, x1
0065886B8  mov      x19, x0
0065886BC  tbnz     w8, #0, #0x65886d4
0065886C0  adrp     x0, #0x8f08000
0065886C4  ldr      x0, [x0, #0x228]
0065886C8  bl       #0x382bd14 ; 
0065886CC  mov      w8, #1
0065886D0  strb     w8, [x21, #0x18a]
0065886D4  ldr      x2, [x22]
0065886D8  ldrb     w8, [x2, #0x53]
0065886DC  tbnz     w8, #5, #0x6588710
0065886E0  ldr      w8, [x19, #0xe0]
0065886E4  sub      w8, w8, #3
0065886E8  cmp      w8, #6
0065886EC  b.hi     #0x6588734
0065886F0  adrp     x9, #0x1a71000
0065886F4  add      x9, x9, #0xf8d
0065886F8  adr      x10, #0x6588708
0065886FC  ldrb     w11, [x9, x8]
006588700  add      x10, x10, x11, lsl #2
006588704  br       x10
006588708  mov      w1, #4
00658870C  b        #0x6588748 ; 
006588710  ldr      x3, [x2, #0x60]
006588714  mov      x0, x19
006588718  mov      x1, x20
00658871C  ldp      x20, x19, [sp, #0x20]
006588720  ldp      x22, x21, [sp, #0x10]
006588724  ldr      x30, [sp], #0x30
006588728  br       x3
00658872C  mov      w1, #7
006588730  b        #0x6588748 ; 
006588734  ldp      x20, x19, [sp, #0x20]
006588738  ldp      x22, x21, [sp, #0x10]
00658873C  ldr      x30, [sp], #0x30
006588740  ret      
006588744  mov      w1, #2
006588748  mov      x0, x19
00658874C  ldp      x20, x19, [sp, #0x20]
006588750  ldp      x22, x21, [sp, #0x10]
006588754  mov      w2, #1
006588758  mov      x3, xzr
00658875C  mov      x4, xzr
006588760  ldr      x30, [sp], #0x30
006588764  b        #0x6588780 ; HotFix.BattleLogic.BattleManager$$TriggerMissionEvent
006588768  mov      x0, x19
00658876C  mov      x1, x20
006588770  ldp      x20, x19, [sp, #0x20]
006588774  ldp      x22, x21, [sp, #0x10]
006588778  ldr      x30, [sp], #0x30
00658877C  b        #0x6588be0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreatePunchboard

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreatePunchboard
; RVA 0x6588BE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588BE0  str      x30, [sp, #-0x30]!
006588BE4  stp      x22, x21, [sp, #0x10]
006588BE8  stp      x20, x19, [sp, #0x20]
006588BEC  adrp     x21, #0x9599000
006588BF0  adrp     x22, #0x8f08000
006588BF4  ldrb     w8, [x21, #0x18b]
006588BF8  ldr      x22, [x22, #0x288]
006588BFC  mov      x19, x1
006588C00  mov      x20, x0
006588C04  tbnz     w8, #0, #0x6588c1c
006588C08  adrp     x0, #0x8f08000
006588C0C  ldr      x0, [x0, #0x288]
006588C10  bl       #0x382bd14 ; 
006588C14  mov      w8, #1
006588C18  strb     w8, [x21, #0x18b]
006588C1C  ldr      x2, [x22]
006588C20  ldrb     w8, [x2, #0x53]
006588C24  tbnz     w8, #5, #0x6588c4c
006588C28  mov      x0, x20
006588C2C  mov      x4, x19
006588C30  ldp      x20, x19, [sp, #0x20]
006588C34  ldp      x22, x21, [sp, #0x10]
006588C38  mov      w1, #8
006588C3C  mov      w2, #1
006588C40  mov      x3, xzr
006588C44  ldr      x30, [sp], #0x30
006588C48  b        #0x6588780 ; HotFix.BattleLogic.BattleManager$$TriggerMissionEvent
006588C4C  ldr      x3, [x2, #0x60]
006588C50  mov      x0, x20
006588C54  mov      x1, x19
006588C58  ldp      x20, x19, [sp, #0x20]
006588C5C  ldp      x22, x21, [sp, #0x10]
006588C60  ldr      x30, [sp], #0x30
006588C64  br       x3

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnEnemyDie
; RVA 0x6588C68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588C68  stp      x30, x23, [sp, #-0x30]!
006588C6C  stp      x22, x21, [sp, #0x10]
006588C70  stp      x20, x19, [sp, #0x20]
006588C74  adrp     x22, #0x9599000
006588C78  adrp     x23, #0x8f08000
006588C7C  ldrb     w8, [x22, #0x18c]
006588C80  ldr      x23, [x23, #0x290]
006588C84  mov      x21, x2
006588C88  mov      x20, x1
006588C8C  mov      x19, x0
006588C90  tbnz     w8, #0, #0x6588ca8
006588C94  adrp     x0, #0x8f08000
006588C98  ldr      x0, [x0, #0x290]
006588C9C  bl       #0x382bd14 ; 
006588CA0  mov      w8, #1
006588CA4  strb     w8, [x22, #0x18c]
006588CA8  ldr      x3, [x23]
006588CAC  ldrb     w8, [x3, #0x53]
006588CB0  tbnz     w8, #5, #0x6588d48
006588CB4  mov      x0, x19
006588CB8  mov      x1, x20
006588CBC  mov      x2, x21
006588CC0  bl       #0x6588dcc ; HotFix.BattleLogic.BattleManager$$OnEnemyDie
006588CC4  adrp     x21, #0x9599000
006588CC8  ldrb     w8, [x21, #0x2a1]
006588CCC  cbnz     w8, #0x6588ce4
006588CD0  adrp     x0, #0x8f08000
006588CD4  ldr      x0, [x0, #0x298]
006588CD8  bl       #0x382bd14 ; 
006588CDC  mov      w8, #1
006588CE0  strb     w8, [x21, #0x2a1]
006588CE4  adrp     x8, #0x8f08000
006588CE8  ldr      x8, [x8, #0x298]
006588CEC  ldr      x1, [x8]
006588CF0  ldrb     w8, [x1, #0x53]
006588CF4  tbnz     w8, #5, #0x6588d68
006588CF8  ldrb     w8, [x19, #0x18]
006588CFC  cbz      w8, #0x6588d78
006588D00  adrp     x20, #0x9599000
006588D04  ldrb     w8, [x20, #0x2a2]
006588D08  cbnz     w8, #0x6588d20
006588D0C  adrp     x0, #0x8f08000
006588D10  ldr      x0, [x0, #0x2a0]
006588D14  bl       #0x382bd14 ; 
006588D18  mov      w8, #1
006588D1C  strb     w8, [x20, #0x2a2]
006588D20  adrp     x8, #0x8f08000
006588D24  ldr      x8, [x8, #0x2a0]
006588D28  ldr      x2, [x8]
006588D2C  ldrb     w8, [x2, #0x53]
006588D30  tbnz     w8, #5, #0x6588db0
006588D34  strb     wzr, [x19, #0x18]
006588D38  ldp      x20, x19, [sp, #0x20]
006588D3C  ldp      x22, x21, [sp, #0x10]
006588D40  ldp      x30, x23, [sp], #0x30
006588D44  ret      
006588D48  ldr      x4, [x3, #0x60]
006588D4C  mov      x0, x19
006588D50  mov      x1, x20
006588D54  mov      x2, x21
006588D58  ldp      x20, x19, [sp, #0x20]
006588D5C  ldp      x22, x21, [sp, #0x10]
006588D60  ldp      x30, x23, [sp], #0x30
006588D64  br       x4
006588D68  ldr      x8, [x1, #0x60]
006588D6C  mov      x0, x19
006588D70  blr      x8
006588D74  tbnz     w0, #0, #0x6588d00
006588D78  ldr      x8, [x19]
006588D7C  mov      x0, x19
006588D80  mov      x1, x20
006588D84  ldr      x9, [x8, #0x5f8]
006588D88  ldr      x2, [x8, #0x600]
006588D8C  blr      x9
006588D90  ldr      x8, [x19]
006588D94  mov      x0, x19
006588D98  ldp      x20, x19, [sp, #0x20]
006588D9C  ldp      x22, x21, [sp, #0x10]
006588DA0  ldr      x2, [x8, #0x218]
006588DA4  ldr      x1, [x8, #0x220]
006588DA8  ldp      x30, x23, [sp], #0x30
006588DAC  br       x2
006588DB0  ldr      x3, [x2, #0x60]
006588DB4  mov      x0, x19
006588DB8  ldp      x20, x19, [sp, #0x20]
006588DBC  ldp      x22, x21, [sp, #0x10]
006588DC0  mov      w1, wzr
006588DC4  ldp      x30, x23, [sp], #0x30
006588DC8  br       x3

; HotFix.BattleLogic.BaseSurvivalBattleManager$$EnemyDieSpecialLogic
; RVA 0x6588F5C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588F5C  str      x30, [sp, #-0x30]!
006588F60  stp      x22, x21, [sp, #0x10]
006588F64  stp      x20, x19, [sp, #0x20]
006588F68  adrp     x21, #0x9599000
006588F6C  adrp     x22, #0x8f08000
006588F70  ldrb     w8, [x21, #0x18d]
006588F74  ldr      x22, [x22, #0x2b0]
006588F78  mov      x20, x1
006588F7C  mov      x19, x0
006588F80  tbnz     w8, #0, #0x6588fa4
006588F84  adrp     x0, #0x8f08000
006588F88  ldr      x0, [x0, #0x2b0]
006588F8C  bl       #0x382bd14 ; 
006588F90  adrp     x0, #0x8ee6000
006588F94  ldr      x0, [x0, #0xd8]
006588F98  bl       #0x382bd14 ; 
006588F9C  mov      w8, #1
006588FA0  strb     w8, [x21, #0x18d]
006588FA4  ldr      x2, [x22]
006588FA8  ldrb     w8, [x2, #0x53]
006588FAC  tbnz     w8, #5, #0x6588fd0
006588FB0  cbz      x20, #0x65890c4
006588FB4  adrp     x8, #0x8ee6000
006588FB8  ldr      x8, [x8, #0xd8]
006588FBC  ldr      x1, [x8]
006588FC0  ldrb     w8, [x1, #0x53]
006588FC4  tbnz     w8, #5, #0x6588fec
006588FC8  ldr      x20, [x20, #0x38]
006588FCC  b        #0x6588ffc ; 
006588FD0  ldr      x3, [x2, #0x60]
006588FD4  mov      x0, x19
006588FD8  mov      x1, x20
006588FDC  ldp      x20, x19, [sp, #0x20]
006588FE0  ldp      x22, x21, [sp, #0x10]
006588FE4  ldr      x30, [sp], #0x30
006588FE8  br       x3
006588FEC  ldr      x8, [x1, #0x60]
006588FF0  mov      x0, x20
006588FF4  blr      x8
006588FF8  mov      x20, x0
006588FFC  cbz      x20, #0x65890c4
006589000  adrp     x21, #0x9591000
006589004  ldrb     w8, [x21, #0xa74]
006589008  cbnz     w8, #0x6589020
00658900C  adrp     x0, #0x8ee6000
006589010  ldr      x0, [x0, #0x288]
006589014  bl       #0x382bd14 ; 
006589018  mov      w8, #1
00658901C  strb     w8, [x21, #0xa74]
006589020  adrp     x8, #0x8ee6000
006589024  ldr      x8, [x8, #0x288]
006589028  ldr      x1, [x8]
00658902C  ldrb     w8, [x1, #0x53]
006589030  tbnz     w8, #5, #0x658903c
006589034  ldr      x20, [x20, #0x170]
006589038  b        #0x658904c ; 
00658903C  ldr      x8, [x1, #0x60]
006589040  mov      x0, x20
006589044  blr      x8
006589048  mov      x20, x0
00658904C  cbz      x20, #0x65890c4
006589050  adrp     x21, #0x9591000
006589054  ldrb     w8, [x21, #0xa75]
006589058  cbnz     w8, #0x6589070
00658905C  adrp     x0, #0x8ee6000
006589060  ldr      x0, [x0, #0x290]
006589064  bl       #0x382bd14 ; 
006589068  mov      w8, #1
00658906C  strb     w8, [x21, #0xa75]
006589070  adrp     x8, #0x8ee6000
006589074  ldr      x8, [x8, #0x290]
006589078  ldr      x1, [x8]
00658907C  ldrb     w8, [x1, #0x53]
006589080  tbnz     w8, #5, #0x658908c
006589084  ldr      w0, [x20, #0x24]
006589088  b        #0x6589098 ; 
00658908C  ldr      x8, [x1, #0x60]
006589090  mov      x0, x20
006589094  blr      x8
006589098  cmp      w0, #3
00658909C  b.ne     #0x65890b4
0065890A0  mov      x0, x19
0065890A4  ldp      x20, x19, [sp, #0x20]
0065890A8  ldp      x22, x21, [sp, #0x10]
0065890AC  ldr      x30, [sp], #0x30
0065890B0  b        #0x658783c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$ClearMonsterCreateData
0065890B4  ldp      x20, x19, [sp, #0x20]
0065890B8  ldp      x22, x21, [sp, #0x10]
0065890BC  ldr      x30, [sp], #0x30
0065890C0  ret      
0065890C4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckSendDisappearEvent
; RVA 0x65890C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065890C8  stp      x30, x21, [sp, #-0x20]!
0065890CC  stp      x20, x19, [sp, #0x10]
0065890D0  adrp     x20, #0x9599000
0065890D4  adrp     x21, #0x8f08000
0065890D8  ldrb     w8, [x20, #0x18e]
0065890DC  ldr      x21, [x21, #0x2b8]
0065890E0  mov      x19, x0
0065890E4  tbnz     w8, #0, #0x65890fc
0065890E8  adrp     x0, #0x8f08000
0065890EC  ldr      x0, [x0, #0x2b8]
0065890F0  bl       #0x382bd14 ; 
0065890F4  mov      w8, #1
0065890F8  strb     w8, [x20, #0x18e]
0065890FC  ldr      x1, [x21]
006589100  ldrb     w8, [x1, #0x53]
006589104  tbnz     w8, #5, #0x658914c
006589108  ldrb     w8, [x19, #0x100]
00658910C  cbz      w8, #0x658917c
006589110  adrp     x20, #0x9599000
006589114  ldrb     w8, [x20, #0x286]
006589118  cbnz     w8, #0x6589130
00658911C  adrp     x0, #0x8f07000
006589120  ldr      x0, [x0, #0xc98]
006589124  bl       #0x382bd14 ; 
006589128  mov      w8, #1
00658912C  strb     w8, [x20, #0x286]
006589130  adrp     x8, #0x8f07000
006589134  ldr      x8, [x8, #0xc98]
006589138  ldr      x1, [x8]
00658913C  ldrb     w8, [x1, #0x53]
006589140  tbnz     w8, #5, #0x6589160
006589144  ldr      x0, [x19, #0x80]
006589148  b        #0x658916c ; 
00658914C  ldr      x2, [x1, #0x60]
006589150  mov      x0, x19
006589154  ldp      x20, x19, [sp, #0x10]
006589158  ldp      x30, x21, [sp], #0x20
00658915C  br       x2
006589160  ldr      x8, [x1, #0x60]
006589164  mov      x0, x19
006589168  blr      x8
00658916C  cbz      x0, #0x6589188
006589170  mov      x1, xzr
006589174  bl       #0x6a02a10 ; HotFix.BattleLogic.BattleWorldContext$$DisPathBossDisAppearEvent
006589178  strb     wzr, [x19, #0x100]
00658917C  ldp      x20, x19, [sp, #0x10]
006589180  ldp      x30, x21, [sp], #0x20
006589184  ret      
006589188  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckSendAppearEvent
; RVA 0x6587974; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587974  stp      x30, x21, [sp, #-0x20]!
006587978  stp      x20, x19, [sp, #0x10]
00658797C  adrp     x20, #0x9599000
006587980  adrp     x21, #0x8f08000
006587984  ldrb     w8, [x20, #0x18f]
006587988  ldr      x21, [x21, #0x120]
00658798C  mov      x19, x0
006587990  tbnz     w8, #0, #0x65879a8
006587994  adrp     x0, #0x8f08000
006587998  ldr      x0, [x0, #0x120]
00658799C  bl       #0x382bd14 ; 
0065879A0  mov      w8, #1
0065879A4  strb     w8, [x20, #0x18f]
0065879A8  ldr      x1, [x21]
0065879AC  ldrb     w8, [x1, #0x53]
0065879B0  tbnz     w8, #5, #0x65879c8
0065879B4  ldrb     w8, [x19, #0x100]
0065879B8  cbz      w8, #0x65879dc
0065879BC  ldp      x20, x19, [sp, #0x10]
0065879C0  ldp      x30, x21, [sp], #0x20
0065879C4  ret      
0065879C8  ldr      x2, [x1, #0x60]
0065879CC  mov      x0, x19
0065879D0  ldp      x20, x19, [sp, #0x10]
0065879D4  ldp      x30, x21, [sp], #0x20
0065879D8  br       x2
0065879DC  mov      w20, #1
0065879E0  strb     w20, [x19, #0x100]
0065879E4  adrp     x21, #0x9599000
0065879E8  ldrb     w8, [x21, #0x286]
0065879EC  cbnz     w8, #0x6587a00
0065879F0  adrp     x0, #0x8f07000
0065879F4  ldr      x0, [x0, #0xc98]
0065879F8  bl       #0x382bd14 ; 
0065879FC  strb     w20, [x21, #0x286]
006587A00  adrp     x8, #0x8f07000
006587A04  ldr      x8, [x8, #0xc98]
006587A08  ldr      x1, [x8]
006587A0C  ldrb     w8, [x1, #0x53]
006587A10  tbnz     w8, #5, #0x6587a1c
006587A14  ldr      x0, [x19, #0x80]
006587A18  b        #0x6587a28 ; 
006587A1C  ldr      x8, [x1, #0x60]
006587A20  mov      x0, x19
006587A24  blr      x8
006587A28  cbz      x0, #0x6587a3c
006587A2C  ldp      x20, x19, [sp, #0x10]
006587A30  mov      x1, xzr
006587A34  ldp      x30, x21, [sp], #0x20
006587A38  b        #0x6a02880 ; HotFix.BattleLogic.BattleWorldContext$$DisPathBossAppearEvent
006587A3C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsPassed
; RVA 0x658918C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658918C  stp      x30, x23, [sp, #-0x30]!
006589190  stp      x22, x21, [sp, #0x10]
006589194  stp      x20, x19, [sp, #0x20]
006589198  adrp     x20, #0x9599000
00658919C  adrp     x21, #0x8f08000
0065891A0  ldrb     w8, [x20, #0x190]
0065891A4  ldr      x21, [x21, #0x2c0]
0065891A8  mov      x19, x0
0065891AC  tbnz     w8, #0, #0x65891c4
0065891B0  adrp     x0, #0x8f08000
0065891B4  ldr      x0, [x0, #0x2c0]
0065891B8  bl       #0x382bd14 ; 
0065891BC  mov      w8, #1
0065891C0  strb     w8, [x20, #0x190]
0065891C4  ldr      x1, [x21]
0065891C8  ldrb     w8, [x1, #0x53]
0065891CC  tbnz     w8, #5, #0x6589214
0065891D0  ldrb     w8, [x19, #0x102]
0065891D4  cbz      w8, #0x6589200
0065891D8  ldr      x0, [x19, #0x88]
0065891DC  cbz      x0, #0x65893a0
0065891E0  mov      x1, xzr
0065891E4  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0065891E8  tbnz     w0, #0, #0x6589200
0065891EC  ldrb     w8, [x19, #0xd4]
0065891F0  cbz      w8, #0x6589200
0065891F4  ldr      w8, [x19, #0xa8]
0065891F8  cmp      w8, #0
0065891FC  b.le     #0x658922c
006589200  mov      w0, wzr
006589204  ldp      x20, x19, [sp, #0x20]
006589208  ldp      x22, x21, [sp, #0x10]
00658920C  ldp      x30, x23, [sp], #0x30
006589210  ret      
006589214  ldr      x2, [x1, #0x60]
006589218  mov      x0, x19
00658921C  ldp      x20, x19, [sp, #0x20]
006589220  ldp      x22, x21, [sp, #0x10]
006589224  ldp      x30, x23, [sp], #0x30
006589228  br       x2
00658922C  adrp     x21, #0x9599000
006589230  ldrb     w8, [x21, #0x286]
006589234  cbnz     w8, #0x658924c
006589238  adrp     x0, #0x8f07000
00658923C  ldr      x0, [x0, #0xc98]
006589240  bl       #0x382bd14 ; 
006589244  mov      w8, #1
006589248  strb     w8, [x21, #0x286]
00658924C  adrp     x22, #0x8f07000
006589250  ldr      x22, [x22, #0xc98]
006589254  ldr      x1, [x22]
006589258  ldrb     w8, [x1, #0x53]
00658925C  tbnz     w8, #5, #0x6589268
006589260  ldr      x20, [x19, #0x80]
006589264  b        #0x6589278 ; 
006589268  ldr      x8, [x1, #0x60]
00658926C  mov      x0, x19
006589270  blr      x8
006589274  mov      x20, x0
006589278  cbz      x20, #0x65893a0
00658927C  adrp     x23, #0x9599000
006589280  ldrb     w8, [x23, #0x2a3]
006589284  cbnz     w8, #0x658929c
006589288  adrp     x0, #0x8f08000
00658928C  ldr      x0, [x0, #0x2c8]
006589290  bl       #0x382bd14 ; 
006589294  mov      w8, #1
006589298  strb     w8, [x23, #0x2a3]
00658929C  adrp     x8, #0x8f08000
0065892A0  ldr      x8, [x8, #0x2c8]
0065892A4  ldr      x1, [x8]
0065892A8  ldrb     w8, [x1, #0x53]
0065892AC  tbnz     w8, #5, #0x65892ec
0065892B0  adrp     x23, #0x9599000
0065892B4  ldrb     w8, [x23, #0x2ac]
0065892B8  cbnz     w8, #0x65892d0
0065892BC  adrp     x0, #0x8f08000
0065892C0  ldr      x0, [x0, #0x2d0]
0065892C4  bl       #0x382bd14 ; 
0065892C8  mov      w8, #1
0065892CC  strb     w8, [x23, #0x2ac]
0065892D0  adrp     x8, #0x8f08000
0065892D4  ldr      x8, [x8, #0x2d0]
0065892D8  ldr      x1, [x8]
0065892DC  ldrb     w8, [x1, #0x53]
0065892E0  tbnz     w8, #5, #0x65892f8
0065892E4  ldr      w20, [x20, #0x320]
0065892E8  b        #0x6589308 ; 
0065892EC  ldr      x8, [x1, #0x60]
0065892F0  mov      x0, x20
0065892F4  b        #0x6589300 ; 
0065892F8  ldr      x8, [x1, #0x60]
0065892FC  add      x0, x20, #0x290
006589300  blr      x8
006589304  mov      w20, w0
006589308  ldrb     w8, [x21, #0x286]
00658930C  cbnz     w8, #0x6589324
006589310  adrp     x0, #0x8f07000
006589314  ldr      x0, [x0, #0xc98]
006589318  bl       #0x382bd14 ; 
00658931C  mov      w8, #1
006589320  strb     w8, [x21, #0x286]
006589324  ldr      x1, [x22]
006589328  ldrb     w8, [x1, #0x53]
00658932C  tbnz     w8, #5, #0x6589338
006589330  ldr      x19, [x19, #0x80]
006589334  b        #0x6589348 ; 
006589338  ldr      x8, [x1, #0x60]
00658933C  mov      x0, x19
006589340  blr      x8
006589344  mov      x19, x0
006589348  cbz      x19, #0x65893a0
00658934C  adrp     x21, #0x9599000
006589350  ldrb     w8, [x21, #0x2a4]
006589354  cbnz     w8, #0x658936c
006589358  adrp     x0, #0x8f08000
00658935C  ldr      x0, [x0, #0x2d8]
006589360  bl       #0x382bd14 ; 
006589364  mov      w8, #1
006589368  strb     w8, [x21, #0x2a4]
00658936C  adrp     x8, #0x8f08000
006589370  ldr      x8, [x8, #0x2d8]
006589374  ldr      x1, [x8]
006589378  ldrb     w8, [x1, #0x53]
00658937C  tbnz     w8, #5, #0x6589388
006589380  ldr      w0, [x19, #0x2c0]
006589384  b        #0x6589394 ; 
006589388  ldr      x8, [x1, #0x60]
00658938C  mov      x0, x19
006589390  blr      x8
006589394  cmp      w20, w0
006589398  cset     w0, ge
00658939C  b        #0x6589204 ; 
0065893A0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnEnemeyDieStart
; RVA 0x65893A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065893A4  stp      x30, x23, [sp, #-0x30]!
0065893A8  stp      x22, x21, [sp, #0x10]
0065893AC  stp      x20, x19, [sp, #0x20]
0065893B0  adrp     x22, #0x9599000
0065893B4  adrp     x23, #0x8f08000
0065893B8  ldrb     w8, [x22, #0x191]
0065893BC  ldr      x23, [x23, #0x2e0]
0065893C0  mov      x20, x2
0065893C4  mov      x21, x1
0065893C8  mov      x19, x0
0065893CC  tbnz     w8, #0, #0x65893f0
0065893D0  adrp     x0, #0x8f08000
0065893D4  ldr      x0, [x0, #0x2e0]
0065893D8  bl       #0x382bd14 ; 
0065893DC  adrp     x0, #0x8ee6000
0065893E0  ldr      x0, [x0, #0xd8]
0065893E4  bl       #0x382bd14 ; 
0065893E8  mov      w8, #1
0065893EC  strb     w8, [x22, #0x191]
0065893F0  ldr      x3, [x23]
0065893F4  ldrb     w8, [x3, #0x53]
0065893F8  tbnz     w8, #5, #0x6589454
0065893FC  mov      x0, x19
006589400  mov      x1, x21
006589404  mov      x2, x20
006589408  bl       #0x65895a8 ; HotFix.BattleLogic.BattleManager$$OnEnemeyDieStart
00658940C  mov      x0, x19
006589410  bl       #0x658918c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsPassed
006589414  tbz      w0, #0, #0x6589590
006589418  adrp     x20, #0x9599000
00658941C  ldrb     w8, [x20, #0x286]
006589420  cbnz     w8, #0x6589438
006589424  adrp     x0, #0x8f07000
006589428  ldr      x0, [x0, #0xc98]
00658942C  bl       #0x382bd14 ; 
006589430  mov      w8, #1
006589434  strb     w8, [x20, #0x286]
006589438  adrp     x8, #0x8f07000
00658943C  ldr      x8, [x8, #0xc98]
006589440  ldr      x1, [x8]
006589444  ldrb     w8, [x1, #0x53]
006589448  tbnz     w8, #5, #0x6589474
00658944C  ldr      x19, [x19, #0x80]
006589450  b        #0x6589484 ; 
006589454  ldr      x4, [x3, #0x60]
006589458  mov      x0, x19
00658945C  mov      x1, x21
006589460  mov      x2, x20
006589464  ldp      x20, x19, [sp, #0x20]
006589468  ldp      x22, x21, [sp, #0x10]
00658946C  ldp      x30, x23, [sp], #0x30
006589470  br       x4
006589474  ldr      x8, [x1, #0x60]
006589478  mov      x0, x19
00658947C  blr      x8
006589480  mov      x19, x0
006589484  cbz      x19, #0x65895a0
006589488  adrp     x20, #0x9591000
00658948C  ldrb     w8, [x20, #0xa62]
006589490  cbnz     w8, #0x65894a8
006589494  adrp     x0, #0x8ee6000
006589498  ldr      x0, [x0, #0x1f8]
00658949C  bl       #0x382bd14 ; 
0065894A0  mov      w8, #1
0065894A4  strb     w8, [x20, #0xa62]
0065894A8  adrp     x8, #0x8ee6000
0065894AC  ldr      x8, [x8, #0x1f8]
0065894B0  ldr      x1, [x8]
0065894B4  ldrb     w8, [x1, #0x53]
0065894B8  tbnz     w8, #5, #0x65894c4
0065894BC  ldr      x19, [x19, #0x1f8]
0065894C0  b        #0x65894d4 ; 
0065894C4  ldr      x8, [x1, #0x60]
0065894C8  mov      x0, x19
0065894CC  blr      x8
0065894D0  mov      x19, x0
0065894D4  cbz      x19, #0x65895a0
0065894D8  adrp     x20, #0x9599000
0065894DC  ldrb     w8, [x20, #0x2a5]
0065894E0  cbnz     w8, #0x65894f8
0065894E4  adrp     x0, #0x8f08000
0065894E8  ldr      x0, [x0, #0x2e8]
0065894EC  bl       #0x382bd14 ; 
0065894F0  mov      w8, #1
0065894F4  strb     w8, [x20, #0x2a5]
0065894F8  adrp     x8, #0x8f08000
0065894FC  ldr      x8, [x8, #0x2e8]
006589500  ldr      x1, [x8]
006589504  ldrb     w8, [x1, #0x53]
006589508  tbnz     w8, #5, #0x6589514
00658950C  ldr      x19, [x19, #0x20]
006589510  b        #0x6589524 ; 
006589514  ldr      x8, [x1, #0x60]
006589518  mov      x0, x19
00658951C  blr      x8
006589520  mov      x19, x0
006589524  cbz      x19, #0x65895a0
006589528  ldr      w8, [x19, #0x18]
00658952C  cmp      w8, #1
006589530  b.lt     #0x6589590
006589534  adrp     x21, #0x8ee6000
006589538  ldr      x21, [x21, #0xd8]
00658953C  mov      w20, wzr
006589540  cmp      w20, w8
006589544  b.hs     #0x65895a4
006589548  add      x8, x19, w20, sxtw #3
00658954C  ldr      x0, [x8, #0x20]
006589550  cbz      x0, #0x65895a0
006589554  ldr      x1, [x21]
006589558  ldrb     w8, [x1, #0x53]
00658955C  tbnz     w8, #5, #0x6589568
006589560  ldr      x0, [x0, #0x38]
006589564  b        #0x6589570 ; 
006589568  ldr      x8, [x1, #0x60]
00658956C  blr      x8
006589570  cbz      x0, #0x65895a0
006589574  mov      w1, #0x22
006589578  mov      x2, xzr
00658957C  bl       #0x65947d4 ; 
006589580  ldr      w8, [x19, #0x18]
006589584  add      w20, w20, #1
006589588  cmp      w20, w8
00658958C  b.lt     #0x6589540
006589590  ldp      x20, x19, [sp, #0x20]
006589594  ldp      x22, x21, [sp, #0x10]
006589598  ldp      x30, x23, [sp], #0x30
00658959C  ret      
0065895A0  bl       #0x382bfb8 ; 
0065895A4  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckEnemyAllDie
; RVA 0x6589794; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006589794  stp      x30, x23, [sp, #-0x30]!
006589798  stp      x22, x21, [sp, #0x10]
00658979C  stp      x20, x19, [sp, #0x20]
0065897A0  adrp     x20, #0x9599000
0065897A4  adrp     x21, #0x8f08000
0065897A8  ldrb     w8, [x20, #0x192]
0065897AC  ldr      x21, [x21, #0x2f8]
0065897B0  mov      x19, x0
0065897B4  tbnz     w8, #0, #0x65897cc
0065897B8  adrp     x0, #0x8f08000
0065897BC  ldr      x0, [x0, #0x2f8]
0065897C0  bl       #0x382bd14 ; 
0065897C4  mov      w8, #1
0065897C8  strb     w8, [x20, #0x192]
0065897CC  ldr      x1, [x21]
0065897D0  ldrb     w8, [x1, #0x53]
0065897D4  tbnz     w8, #5, #0x65897f4
0065897D8  ldr      w8, [x19, #0xa8]
0065897DC  cmp      w8, #0
0065897E0  b.le     #0x658980c
0065897E4  ldp      x20, x19, [sp, #0x20]
0065897E8  ldp      x22, x21, [sp, #0x10]
0065897EC  ldp      x30, x23, [sp], #0x30
0065897F0  ret      
0065897F4  ldr      x2, [x1, #0x60]
0065897F8  mov      x0, x19
0065897FC  ldp      x20, x19, [sp, #0x20]
006589800  ldp      x22, x21, [sp, #0x10]
006589804  ldp      x30, x23, [sp], #0x30
006589808  br       x2
00658980C  mov      x0, x19
006589810  bl       #0x65871b0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get__refreshState
006589814  cbz      w0, #0x6589828
006589818  mov      x0, x19
00658981C  bl       #0x65871b0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get__refreshState
006589820  cmp      w0, #2
006589824  b.ne     #0x65897e4
006589828  ldrb     w8, [x19, #0x102]
00658982C  cbz      w8, #0x6589840
006589830  mov      x0, x19
006589834  bl       #0x658918c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsPassed
006589838  tbz      w0, #0, #0x65897e4
00658983C  b        #0x65899b8 ; 
006589840  adrp     x21, #0x9599000
006589844  ldrb     w8, [x21, #0x286]
006589848  cbnz     w8, #0x6589860
00658984C  adrp     x0, #0x8f07000
006589850  ldr      x0, [x0, #0xc98]
006589854  bl       #0x382bd14 ; 
006589858  mov      w8, #1
00658985C  strb     w8, [x21, #0x286]
006589860  adrp     x22, #0x8f07000
006589864  ldr      x22, [x22, #0xc98]
006589868  ldr      x1, [x22]
00658986C  ldrb     w8, [x1, #0x53]
006589870  tbnz     w8, #5, #0x658987c
006589874  ldr      x20, [x19, #0x80]
006589878  b        #0x658988c ; 
00658987C  ldr      x8, [x1, #0x60]
006589880  mov      x0, x19
006589884  blr      x8
006589888  mov      x20, x0
00658988C  cbz      x20, #0x6589ab8
006589890  adrp     x23, #0x9599000
006589894  ldrb     w8, [x23, #0x2a4]
006589898  cbnz     w8, #0x65898b0
00658989C  adrp     x0, #0x8f08000
0065898A0  ldr      x0, [x0, #0x2d8]
0065898A4  bl       #0x382bd14 ; 
0065898A8  mov      w8, #1
0065898AC  strb     w8, [x23, #0x2a4]
0065898B0  adrp     x8, #0x8f08000
0065898B4  ldr      x8, [x8, #0x2d8]
0065898B8  ldr      x1, [x8]
0065898BC  ldrb     w8, [x1, #0x53]
0065898C0  tbnz     w8, #5, #0x65898cc
0065898C4  ldr      w20, [x20, #0x2c0]
0065898C8  b        #0x65898dc ; 
0065898CC  ldr      x8, [x1, #0x60]
0065898D0  mov      x0, x20
0065898D4  blr      x8
0065898D8  mov      w20, w0
0065898DC  ldrb     w8, [x21, #0x286]
0065898E0  cbnz     w8, #0x65898f8
0065898E4  adrp     x0, #0x8f07000
0065898E8  ldr      x0, [x0, #0xc98]
0065898EC  bl       #0x382bd14 ; 
0065898F0  mov      w8, #1
0065898F4  strb     w8, [x21, #0x286]
0065898F8  ldr      x1, [x22]
0065898FC  ldrb     w8, [x1, #0x53]
006589900  tbnz     w8, #5, #0x658990c
006589904  ldr      x21, [x19, #0x80]
006589908  b        #0x658991c ; 
00658990C  ldr      x8, [x1, #0x60]
006589910  mov      x0, x19
006589914  blr      x8
006589918  mov      x21, x0
00658991C  cbz      x21, #0x6589ab8
006589920  adrp     x22, #0x9599000
006589924  ldrb     w8, [x22, #0x2a3]
006589928  cbnz     w8, #0x6589940
00658992C  adrp     x0, #0x8f08000
006589930  ldr      x0, [x0, #0x2c8]
006589934  bl       #0x382bd14 ; 
006589938  mov      w8, #1
00658993C  strb     w8, [x22, #0x2a3]
006589940  adrp     x8, #0x8f08000
006589944  ldr      x8, [x8, #0x2c8]
006589948  ldr      x1, [x8]
00658994C  ldrb     w8, [x1, #0x53]
006589950  tbnz     w8, #5, #0x6589990
006589954  adrp     x22, #0x9599000
006589958  ldrb     w8, [x22, #0x2ac]
00658995C  cbnz     w8, #0x6589974
006589960  adrp     x0, #0x8f08000
006589964  ldr      x0, [x0, #0x2d0]
006589968  bl       #0x382bd14 ; 
00658996C  mov      w8, #1
006589970  strb     w8, [x22, #0x2ac]
006589974  adrp     x8, #0x8f08000
006589978  ldr      x8, [x8, #0x2d0]
00658997C  ldr      x1, [x8]
006589980  ldrb     w8, [x1, #0x53]
006589984  tbnz     w8, #5, #0x658999c
006589988  ldr      w0, [x21, #0x320]
00658998C  b        #0x65899a8 ; 
006589990  ldr      x8, [x1, #0x60]
006589994  mov      x0, x21
006589998  b        #0x65899a4 ; 
00658999C  ldr      x8, [x1, #0x60]
0065899A0  add      x0, x21, #0x290
0065899A4  blr      x8
0065899A8  ldr      w8, [x19, #0xd0]
0065899AC  add      w8, w8, w0
0065899B0  cmp      w20, w8
0065899B4  b.gt     #0x65897e4
0065899B8  mov      x0, x19
0065899BC  bl       #0x65890c8 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckSendDisappearEvent
0065899C0  ldr      x0, [x19, #0x88]
0065899C4  cbz      x0, #0x6589ab8
0065899C8  mov      x1, xzr
0065899CC  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0065899D0  tbnz     w0, #0, #0x65897e4
0065899D4  ldrb     w8, [x19, #0x102]
0065899D8  cbz      w8, #0x65899ec
0065899DC  ldr      x8, [x19]
0065899E0  ldr      x2, [x8, #0x438]
0065899E4  ldr      x1, [x8, #0x440]
0065899E8  b        #0x65897f8 ; 
0065899EC  adrp     x20, #0x9599000
0065899F0  ldrb     w8, [x20, #0x286]
0065899F4  cbnz     w8, #0x6589a0c
0065899F8  adrp     x0, #0x8f07000
0065899FC  ldr      x0, [x0, #0xc98]
006589A00  bl       #0x382bd14 ; 
006589A04  mov      w8, #1
006589A08  strb     w8, [x20, #0x286]
006589A0C  adrp     x8, #0x8f07000
006589A10  ldr      x8, [x8, #0xc98]
006589A14  ldr      x1, [x8]
006589A18  ldrb     w8, [x1, #0x53]
006589A1C  tbnz     w8, #5, #0x6589a28
006589A20  ldr      x20, [x19, #0x80]
006589A24  b        #0x6589a38 ; 
006589A28  ldr      x8, [x1, #0x60]
006589A2C  mov      x0, x19
006589A30  blr      x8
006589A34  mov      x20, x0
006589A38  cbz      x20, #0x6589ab8
006589A3C  adrp     x21, #0x9591000
006589A40  ldrb     w8, [x21, #0xa9c]
006589A44  cbnz     w8, #0x6589a5c
006589A48  adrp     x0, #0x8ee6000
006589A4C  ldr      x0, [x0, #0xaf0]
006589A50  bl       #0x382bd14 ; 
006589A54  mov      w8, #1
006589A58  strb     w8, [x21, #0xa9c]
006589A5C  adrp     x8, #0x8ee6000
006589A60  ldr      x8, [x8, #0xaf0]
006589A64  ldr      x1, [x8]
006589A68  ldrb     w8, [x1, #0x53]
006589A6C  tbnz     w8, #5, #0x6589a78
006589A70  ldr      x0, [x20, #0x240]
006589A74  b        #0x6589a84 ; 
006589A78  ldr      x8, [x1, #0x60]
006589A7C  mov      x0, x20
006589A80  blr      x8
006589A84  cbz      x0, #0x6589ab8
006589A88  mov      x1, xzr
006589A8C  bl       #0x6902664 ; HotFix.BattleLogic.MapManager$$PlayBattleMusic
006589A90  ldr      x8, [x19]
006589A94  mov      x0, x19
006589A98  ldr      x9, [x8, #0x618]
006589A9C  ldr      x1, [x8, #0x620]
006589AA0  blr      x9
006589AA4  tbnz     w0, #0, #0x65897e4
006589AA8  ldr      x8, [x19]
006589AAC  ldr      x2, [x8, #0x608]
006589AB0  ldr      x1, [x8, #0x610]
006589AB4  b        #0x65897f8 ; 
006589AB8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckGoNextMission
; RVA 0x6589ABC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006589ABC  stp      x30, x21, [sp, #-0x20]!
006589AC0  stp      x20, x19, [sp, #0x10]
006589AC4  adrp     x20, #0x9599000
006589AC8  adrp     x21, #0x8f08000
006589ACC  ldrb     w8, [x20, #0x193]
006589AD0  ldr      x21, [x21, #0x300]
006589AD4  mov      x19, x0
006589AD8  tbnz     w8, #0, #0x6589af0
006589ADC  adrp     x0, #0x8f08000
006589AE0  ldr      x0, [x0, #0x300]
006589AE4  bl       #0x382bd14 ; 
006589AE8  mov      w8, #1
006589AEC  strb     w8, [x20, #0x193]
006589AF0  ldr      x1, [x21]
006589AF4  ldrb     w8, [x1, #0x53]
006589AF8  tbnz     w8, #5, #0x6589b38
006589AFC  adrp     x20, #0x9599000
006589B00  ldrb     w8, [x20, #0x286]
006589B04  cbnz     w8, #0x6589b1c
006589B08  adrp     x0, #0x8f07000
006589B0C  ldr      x0, [x0, #0xc98]
006589B10  bl       #0x382bd14 ; 
006589B14  mov      w8, #1
006589B18  strb     w8, [x20, #0x286]
006589B1C  adrp     x8, #0x8f07000
006589B20  ldr      x8, [x8, #0xc98]
006589B24  ldr      x1, [x8]
006589B28  ldrb     w8, [x1, #0x53]
006589B2C  tbnz     w8, #5, #0x6589b4c
006589B30  ldr      x20, [x19, #0x80]
006589B34  b        #0x6589b5c ; 
006589B38  ldr      x2, [x1, #0x60]
006589B3C  mov      x0, x19
006589B40  ldp      x20, x19, [sp, #0x10]
006589B44  ldp      x30, x21, [sp], #0x20
006589B48  br       x2
006589B4C  ldr      x8, [x1, #0x60]
006589B50  mov      x0, x19
006589B54  blr      x8
006589B58  mov      x20, x0
006589B5C  cbz      x20, #0x6589bc4
006589B60  adrp     x21, #0x9599000
006589B64  ldrb     w8, [x21, #0x287]
006589B68  cbnz     w8, #0x6589b80
006589B6C  adrp     x0, #0x8f07000
006589B70  ldr      x0, [x0, #0xcf0]
006589B74  bl       #0x382bd14 ; 
006589B78  mov      w8, #1
006589B7C  strb     w8, [x21, #0x287]
006589B80  adrp     x8, #0x8f07000
006589B84  ldr      x8, [x8, #0xcf0]
006589B88  ldr      x1, [x8]
006589B8C  ldrb     w8, [x1, #0x53]
006589B90  tbnz     w8, #5, #0x6589b9c
006589B94  ldr      x0, [x20, #0x350]
006589B98  b        #0x6589ba8 ; 
006589B9C  ldr      x8, [x1, #0x60]
006589BA0  mov      x0, x20
006589BA4  blr      x8
006589BA8  cbz      x0, #0x6589bc4
006589BAC  mov      x1, xzr
006589BB0  bl       #0x6670384 ; HotFix.BattleLogic.DropMgr$$AbsorbAllExp
006589BB4  mov      x0, x19
006589BB8  ldp      x20, x19, [sp, #0x10]
006589BBC  ldp      x30, x21, [sp], #0x20
006589BC0  b        #0x6589bc8 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$GoNextWave
006589BC4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$GoNextWave
; RVA 0x6589BC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006589BC8  stp      x30, x21, [sp, #-0x20]!
006589BCC  stp      x20, x19, [sp, #0x10]
006589BD0  adrp     x20, #0x9599000
006589BD4  adrp     x21, #0x8f08000
006589BD8  ldrb     w8, [x20, #0x194]
006589BDC  ldr      x21, [x21, #0x308]
006589BE0  mov      x19, x0
006589BE4  tbnz     w8, #0, #0x6589bfc
006589BE8  adrp     x0, #0x8f08000
006589BEC  ldr      x0, [x0, #0x308]
006589BF0  bl       #0x382bd14 ; 
006589BF4  mov      w8, #1
006589BF8  strb     w8, [x20, #0x194]
006589BFC  ldr      x1, [x21]
006589C00  ldrb     w8, [x1, #0x53]
006589C04  tbnz     w8, #5, #0x6589c28
006589C08  ldr      x8, [x19]
006589C0C  mov      x0, x19
006589C10  ldr      x9, [x8, #0x658]
006589C14  ldr      x1, [x8, #0x660]
006589C18  blr      x9
006589C1C  tbz      w0, #0, #0x6589c3c
006589C20  mov      w1, #8
006589C24  b        #0x6589c40 ; 
006589C28  ldr      x2, [x1, #0x60]
006589C2C  mov      x0, x19
006589C30  ldp      x20, x19, [sp, #0x10]
006589C34  ldp      x30, x21, [sp], #0x20
006589C38  br       x2
006589C3C  mov      w1, #1
006589C40  mov      x0, x19
006589C44  ldp      x20, x19, [sp, #0x10]
006589C48  mov      w2, wzr
006589C4C  ldp      x30, x21, [sp], #0x20
006589C50  b        #0x6587518 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetRefreshState

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckContractDevil
; RVA 0x6589C54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006589C54  stp      x30, x21, [sp, #-0x20]!
006589C58  stp      x20, x19, [sp, #0x10]
006589C5C  adrp     x20, #0x9599000
006589C60  adrp     x21, #0x8f08000
006589C64  ldrb     w8, [x20, #0x195]
006589C68  ldr      x21, [x21, #0x310]
006589C6C  mov      x19, x0
006589C70  tbnz     w8, #0, #0x6589c88
006589C74  adrp     x0, #0x8f08000
006589C78  ldr      x0, [x0, #0x310]
006589C7C  bl       #0x382bd14 ; 
006589C80  mov      w8, #1
006589C84  strb     w8, [x20, #0x195]
006589C88  ldr      x1, [x21]
006589C8C  ldrb     w8, [x1, #0x53]
006589C90  tbnz     w8, #5, #0x6589cdc
006589C94  ldr      w8, [x19, #0xe0]
006589C98  cmp      w8, #2
006589C9C  b.ne     #0x6589d90
006589CA0  adrp     x20, #0x9599000
006589CA4  ldrb     w8, [x20, #0x286]
006589CA8  cbnz     w8, #0x6589cc0
006589CAC  adrp     x0, #0x8f07000
006589CB0  ldr      x0, [x0, #0xc98]
006589CB4  bl       #0x382bd14 ; 
006589CB8  mov      w8, #1
006589CBC  strb     w8, [x20, #0x286]
006589CC0  adrp     x21, #0x8f07000
006589CC4  ldr      x21, [x21, #0xc98]
006589CC8  ldr      x1, [x21]
006589CCC  ldrb     w8, [x1, #0x53]
006589CD0  tbnz     w8, #5, #0x6589cf0
006589CD4  ldr      x0, [x19, #0x80]
006589CD8  b        #0x6589cfc ; 
006589CDC  ldr      x2, [x1, #0x60]
006589CE0  mov      x0, x19
006589CE4  ldp      x20, x19, [sp, #0x10]
006589CE8  ldp      x30, x21, [sp], #0x20
006589CEC  br       x2
006589CF0  ldr      x8, [x1, #0x60]
006589CF4  mov      x0, x19
006589CF8  blr      x8
006589CFC  cbz      x0, #0x6589de8
006589D00  ldr      w8, [x0, #0x1c8]
006589D04  cmp      w8, #2
006589D08  b.eq     #0x6589d90
006589D0C  ldrb     w8, [x20, #0x286]
006589D10  cbnz     w8, #0x6589d28
006589D14  adrp     x0, #0x8f07000
006589D18  ldr      x0, [x0, #0xc98]
006589D1C  bl       #0x382bd14 ; 
006589D20  mov      w8, #1
006589D24  strb     w8, [x20, #0x286]
006589D28  ldr      x1, [x21]
006589D2C  ldrb     w8, [x1, #0x53]
006589D30  tbnz     w8, #5, #0x6589d3c
006589D34  ldr      x20, [x19, #0x80]
006589D38  b        #0x6589d4c ; 
006589D3C  ldr      x8, [x1, #0x60]
006589D40  mov      x0, x19
006589D44  blr      x8
006589D48  mov      x20, x0
006589D4C  cbz      x20, #0x6589de8
006589D50  adrp     x21, #0x9599000
006589D54  ldrb     w8, [x21, #0x2a6]
006589D58  cbnz     w8, #0x6589d70
006589D5C  adrp     x0, #0x8f08000
006589D60  ldr      x0, [x0, #0x318]
006589D64  bl       #0x382bd14 ; 
006589D68  mov      w8, #1
006589D6C  strb     w8, [x21, #0x2a6]
006589D70  adrp     x8, #0x8f08000
006589D74  ldr      x8, [x8, #0x318]
006589D78  ldr      x1, [x8]
006589D7C  ldrb     w8, [x1, #0x53]
006589D80  tbnz     w8, #5, #0x6589da0
006589D84  add      x0, x20, #0x290
006589D88  bl       #0x658f8d8 ; HotFix.BattleLogic.BattleData$$GetNextMissionIndex
006589D8C  tbz      w0, #0x1f, #0x6589db0
006589D90  mov      w0, wzr
006589D94  ldp      x20, x19, [sp, #0x10]
006589D98  ldp      x30, x21, [sp], #0x20
006589D9C  ret      
006589DA0  ldr      x8, [x1, #0x60]
006589DA4  mov      x0, x20
006589DA8  blr      x8
006589DAC  tbnz     w0, #0x1f, #0x6589d90
006589DB0  ldr      x8, [x19]
006589DB4  mov      x0, x19
006589DB8  ldr      x9, [x8, #0x408]
006589DBC  ldr      x1, [x8, #0x410]
006589DC0  blr      x9
006589DC4  tst      w0, #1
006589DC8  mov      w8, #5
006589DCC  mov      w9, #3
006589DD0  csel     w1, w9, w8, ne
006589DD4  mov      x0, x19
006589DD8  mov      w2, wzr
006589DDC  bl       #0x6587518 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetRefreshState
006589DE0  mov      w0, #1
006589DE4  b        #0x6589d94 ; 
006589DE8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_CheckDropClear
; RVA 0x6589DEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006589DEC  stp      x30, x21, [sp, #-0x20]!
006589DF0  stp      x20, x19, [sp, #0x10]
006589DF4  adrp     x20, #0x9599000
006589DF8  adrp     x21, #0x8f08000
006589DFC  ldrb     w8, [x20, #0x196]
006589E00  ldr      x21, [x21, #0x320]
006589E04  mov      x19, x0
006589E08  tbnz     w8, #0, #0x6589e20
006589E0C  adrp     x0, #0x8f08000
006589E10  ldr      x0, [x0, #0x320]
006589E14  bl       #0x382bd14 ; 
006589E18  mov      w8, #1
006589E1C  strb     w8, [x20, #0x196]
006589E20  ldr      x1, [x21]
006589E24  ldrb     w8, [x1, #0x53]
006589E28  tbnz     w8, #5, #0x6589e3c
006589E2C  ldp      x20, x19, [sp, #0x10]
006589E30  mov      w0, #1
006589E34  ldp      x30, x21, [sp], #0x20
006589E38  ret      
006589E3C  ldr      x2, [x1, #0x60]
006589E40  mov      x0, x19
006589E44  ldp      x20, x19, [sp, #0x10]
006589E48  ldp      x30, x21, [sp], #0x20
006589E4C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnRemoveNpc
; RVA 0x6589E50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006589E50  stp      x30, x23, [sp, #-0x30]!
006589E54  stp      x22, x21, [sp, #0x10]
006589E58  stp      x20, x19, [sp, #0x20]
006589E5C  adrp     x21, #0x9599000
006589E60  adrp     x22, #0x8f08000
006589E64  ldrb     w8, [x21, #0x197]
006589E68  ldr      x22, [x22, #0x328]
006589E6C  mov      x20, x1
006589E70  mov      x19, x0
006589E74  tbnz     w8, #0, #0x6589e8c
006589E78  adrp     x0, #0x8f08000
006589E7C  ldr      x0, [x0, #0x328]
006589E80  bl       #0x382bd14 ; 
006589E84  mov      w8, #1
006589E88  strb     w8, [x21, #0x197]
006589E8C  ldr      x2, [x22]
006589E90  ldrb     w8, [x2, #0x53]
006589E94  tbnz     w8, #5, #0x6589edc
006589E98  ldr      x8, [x19]
006589E9C  ldr      x9, [x19, #0x98]
006589EA0  mov      x0, x19
006589EA4  ldr      x10, [x8, #0x298]
006589EA8  ldr      x1, [x8, #0x2a0]
006589EAC  cmp      x9, #0
006589EB0  csel     x21, x20, x9, eq
006589EB4  blr      x10
006589EB8  tbz      w0, #0, #0x6589ef8
006589EBC  cbz      x21, #0x6589ecc
006589EC0  ldr      w8, [x21, #0x624]
006589EC4  cmp      w8, #2
006589EC8  b.ne     #0x6589ef8
006589ECC  ldr      x8, [x19]
006589ED0  ldr      x2, [x8, #0x438]
006589ED4  ldr      x1, [x8, #0x440]
006589ED8  b        #0x6589fdc ; 
006589EDC  ldr      x3, [x2, #0x60]
006589EE0  mov      x0, x19
006589EE4  mov      x1, x20
006589EE8  ldp      x20, x19, [sp, #0x20]
006589EEC  ldp      x22, x21, [sp, #0x10]
006589EF0  ldp      x30, x23, [sp], #0x30
006589EF4  br       x3
006589EF8  mov      w1, #1
006589EFC  mov      w3, #1
006589F00  mov      x0, x19
006589F04  mov      x2, xzr
006589F08  mov      w20, #1
006589F0C  bl       #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
006589F10  adrp     x22, #0x9599000
006589F14  ldrb     w8, [x22, #0x286]
006589F18  cbnz     w8, #0x6589f2c
006589F1C  adrp     x0, #0x8f07000
006589F20  ldr      x0, [x0, #0xc98]
006589F24  bl       #0x382bd14 ; 
006589F28  strb     w20, [x22, #0x286]
006589F2C  adrp     x23, #0x8f07000
006589F30  ldr      x23, [x23, #0xc98]
006589F34  ldr      x1, [x23]
006589F38  ldrb     w8, [x1, #0x53]
006589F3C  tbnz     w8, #5, #0x6589f48
006589F40  ldr      x0, [x19, #0x80]
006589F44  b        #0x6589f54 ; 
006589F48  ldr      x8, [x1, #0x60]
006589F4C  mov      x0, x19
006589F50  blr      x8
006589F54  cbz      x0, #0x658a000
006589F58  mov      x1, xzr
006589F5C  bl       #0x6a048d0 ; HotFix.BattleLogic.BattleWorldContext$$GetChapterChestType
006589F60  cbz      x21, #0x658a000
006589F64  ldrb     w8, [x22, #0x286]
006589F68  ldr      w21, [x21, #0x624]
006589F6C  mov      w20, w0
006589F70  cbnz     w8, #0x6589f88
006589F74  adrp     x0, #0x8f07000
006589F78  ldr      x0, [x0, #0xc98]
006589F7C  bl       #0x382bd14 ; 
006589F80  mov      w8, #1
006589F84  strb     w8, [x22, #0x286]
006589F88  ldr      x1, [x23]
006589F8C  ldrb     w8, [x1, #0x53]
006589F90  tbnz     w8, #5, #0x6589f9c
006589F94  ldr      x0, [x19, #0x80]
006589F98  b        #0x6589fa8 ; 
006589F9C  ldr      x8, [x1, #0x60]
006589FA0  mov      x0, x19
006589FA4  blr      x8
006589FA8  cbz      x0, #0x658a000
006589FAC  cmp      w20, #1
006589FB0  cset     w20, ne
006589FB4  cmp      w21, #8
006589FB8  mov      x1, xzr
006589FBC  cset     w21, eq
006589FC0  bl       #0x6a16b50 ; HotFix.BattleLogic.BattleWorldContext$$HasNpc
006589FC4  and      w8, w20, w21
006589FC8  tbnz     w8, #0, #0x6589ff0
006589FCC  tbnz     w0, #0, #0x6589ff0
006589FD0  ldr      x8, [x19]
006589FD4  ldr      x2, [x8, #0x608]
006589FD8  ldr      x1, [x8, #0x610]
006589FDC  mov      x0, x19
006589FE0  ldp      x20, x19, [sp, #0x20]
006589FE4  ldp      x22, x21, [sp, #0x10]
006589FE8  ldp      x30, x23, [sp], #0x30
006589FEC  br       x2
006589FF0  ldp      x20, x19, [sp, #0x20]
006589FF4  ldp      x22, x21, [sp, #0x10]
006589FF8  ldp      x30, x23, [sp], #0x30
006589FFC  ret      
00658A000  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$SaveBattleRecord
; RVA 0x658A004; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A004  stp      x30, x21, [sp, #-0x20]!
00658A008  stp      x20, x19, [sp, #0x10]
00658A00C  adrp     x20, #0x9599000
00658A010  adrp     x21, #0x8f08000
00658A014  ldrb     w8, [x20, #0x198]
00658A018  b        #0x89ec65c ; 
00658A01C  mov      x19, x0
00658A020  tbnz     w8, #0, #0x658a044
00658A024  adrp     x0, #0x8f08000
00658A028  ldr      x0, [x0, #0x330]
00658A02C  bl       #0x382bd14 ; 
00658A030  adrp     x0, #0x8f08000
00658A034  ldr      x0, [x0, #0x338]
00658A038  bl       #0x382bd14 ; 
00658A03C  mov      w8, #1
00658A040  strb     w8, [x20, #0x198]
00658A044  ldr      x1, [x21]
00658A048  ldrb     w8, [x1, #0x53]
00658A04C  tbnz     w8, #5, #0x658a08c
00658A050  adrp     x20, #0x9599000
00658A054  ldrb     w8, [x20, #0x286]
00658A058  cbnz     w8, #0x658a070
00658A05C  adrp     x0, #0x8f07000
00658A060  ldr      x0, [x0, #0xc98]
00658A064  bl       #0x382bd14 ; 
00658A068  mov      w8, #1
00658A06C  strb     w8, [x20, #0x286]
00658A070  adrp     x8, #0x8f07000
00658A074  ldr      x8, [x8, #0xc98]
00658A078  ldr      x1, [x8]
00658A07C  ldrb     w8, [x1, #0x53]
00658A080  tbnz     w8, #5, #0x658a0a0
00658A084  ldr      x0, [x19, #0x80]
00658A088  b        #0x658a0ac ; 
00658A08C  ldr      x2, [x1, #0x60]
00658A090  mov      x0, x19
00658A094  ldp      x20, x19, [sp, #0x10]
00658A098  ldp      x30, x21, [sp], #0x20
00658A09C  br       x2
00658A0A0  ldr      x8, [x1, #0x60]
00658A0A4  mov      x0, x19
00658A0A8  blr      x8
00658A0AC  cbz      x0, #0x658a0e4
00658A0B0  adrp     x8, #0x8f08000
00658A0B4  ldr      x8, [x8, #0x338]
00658A0B8  mov      x2, xzr
00658A0BC  ldr      x1, [x8]
00658A0C0  bl       #0x6a22a9c ; HotFix.BattleLogic.BattleWorldContext$$DisPathBattleRecordEvent
00658A0C4  ldr      x8, [x19]
00658A0C8  mov      x0, x19
00658A0CC  ldp      x20, x19, [sp, #0x10]
00658A0D0  mov      w1, wzr
00658A0D4  ldr      x3, [x8, #0x638]
00658A0D8  ldr      x2, [x8, #0x640]
00658A0DC  ldp      x30, x21, [sp], #0x20
00658A0E0  br       x3
00658A0E4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$NextWave
; RVA 0x658A0E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A0E8  stp      x30, x21, [sp, #-0x20]!
00658A0EC  stp      x20, x19, [sp, #0x10]
00658A0F0  adrp     x20, #0x9599000
00658A0F4  adrp     x21, #0x8f08000
00658A0F8  ldrb     w8, [x20, #0x199]
00658A0FC  ldr      x21, [x21, #0x340]
00658A100  mov      x19, x0
00658A104  tbnz     w8, #0, #0x658a11c
00658A108  adrp     x0, #0x8f08000
00658A10C  ldr      x0, [x0, #0x340]
00658A110  bl       #0x382bd14 ; 
00658A114  mov      w8, #1
00658A118  strb     w8, [x20, #0x199]
00658A11C  ldr      x1, [x21]
00658A120  ldrb     w8, [x1, #0x53]
00658A124  tbnz     w8, #5, #0x658a138
00658A128  mov      x0, x19
00658A12C  ldp      x20, x19, [sp, #0x10]
00658A130  ldp      x30, x21, [sp], #0x20
00658A134  b        #0x6588058 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$NextWaveInternal
00658A138  ldr      x2, [x1, #0x60]
00658A13C  mov      x0, x19
00658A140  ldp      x20, x19, [sp, #0x10]
00658A144  ldp      x30, x21, [sp], #0x20
00658A148  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$TryClearBullet
; RVA 0x658A14C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A14C  stp      x30, x21, [sp, #-0x20]!
00658A150  stp      x20, x19, [sp, #0x10]
00658A154  adrp     x20, #0x9599000
00658A158  adrp     x21, #0x8f08000
00658A15C  ldrb     w8, [x20, #0x19a]
00658A160  ldr      x21, [x21, #0x348]
00658A164  mov      x19, x0
00658A168  tbnz     w8, #0, #0x658a180
00658A16C  adrp     x0, #0x8f08000
00658A170  ldr      x0, [x0, #0x348]
00658A174  bl       #0x382bd14 ; 
00658A178  mov      w8, #1
00658A17C  strb     w8, [x20, #0x19a]
00658A180  ldr      x1, [x21]
00658A184  ldrb     w8, [x1, #0x53]
00658A188  tbnz     w8, #5, #0x658a1c8
00658A18C  adrp     x20, #0x9599000
00658A190  ldrb     w8, [x20, #0x286]
00658A194  cbnz     w8, #0x658a1ac
00658A198  adrp     x0, #0x8f07000
00658A19C  ldr      x0, [x0, #0xc98]
00658A1A0  bl       #0x382bd14 ; 
00658A1A4  mov      w8, #1
00658A1A8  strb     w8, [x20, #0x286]
00658A1AC  adrp     x8, #0x8f07000
00658A1B0  ldr      x8, [x8, #0xc98]
00658A1B4  ldr      x1, [x8]
00658A1B8  ldrb     w8, [x1, #0x53]
00658A1BC  tbnz     w8, #5, #0x658a1dc
00658A1C0  ldr      x0, [x19, #0x80]
00658A1C4  b        #0x658a1e8 ; 
00658A1C8  ldr      x2, [x1, #0x60]
00658A1CC  mov      x0, x19
00658A1D0  ldp      x20, x19, [sp, #0x10]
00658A1D4  ldp      x30, x21, [sp], #0x20
00658A1D8  br       x2
00658A1DC  ldr      x8, [x1, #0x60]
00658A1E0  mov      x0, x19
00658A1E4  blr      x8
00658A1E8  cbz      x0, #0x658a200
00658A1EC  ldp      x20, x19, [sp, #0x10]
00658A1F0  mov      w1, wzr
00658A1F4  mov      x2, xzr
00658A1F8  ldp      x30, x21, [sp], #0x20
00658A1FC  b        #0x6a03e04 ; HotFix.BattleLogic.BattleWorldContext$$ClearAllBullet
00658A200  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$TriggerWaveEvent
; RVA 0x658A204; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A204  stp      x30, x21, [sp, #-0x20]!
00658A208  stp      x20, x19, [sp, #0x10]
00658A20C  adrp     x20, #0x9599000
00658A210  adrp     x21, #0x8f08000
00658A214  ldrb     w8, [x20, #0x19b]
00658A218  ldr      x21, [x21, #0x350]
00658A21C  mov      x19, x0
00658A220  tbnz     w8, #0, #0x658a238
00658A224  adrp     x0, #0x8f08000
00658A228  ldr      x0, [x0, #0x350]
00658A22C  bl       #0x382bd14 ; 
00658A230  mov      w8, #1
00658A234  strb     w8, [x20, #0x19b]
00658A238  ldr      x1, [x21]
00658A23C  ldrb     w8, [x1, #0x53]
00658A240  tbnz     w8, #5, #0x658a25c
00658A244  ldr      w1, [x19, #0xe0]
00658A248  mov      x0, x19
00658A24C  ldp      x20, x19, [sp, #0x10]
00658A250  mov      x2, xzr
00658A254  ldp      x30, x21, [sp], #0x20
00658A258  b        #0x65c4540 ; HotFix.BattleLogic.SinglePlayerBattleManager$$TriggerWaveEvent
00658A25C  ldr      x2, [x1, #0x60]
00658A260  mov      x0, x19
00658A264  ldp      x20, x19, [sp, #0x10]
00658A268  ldp      x30, x21, [sp], #0x20
00658A26C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$TriggerEnemyFirstCreateInWaveEvent
; RVA 0x6587A40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006587A40  stp      x30, x21, [sp, #-0x20]!
006587A44  stp      x20, x19, [sp, #0x10]
006587A48  adrp     x20, #0x9599000
006587A4C  adrp     x21, #0x8f08000
006587A50  ldrb     w8, [x20, #0x19c]
006587A54  ldr      x21, [x21, #0x128]
006587A58  mov      x19, x0
006587A5C  tbnz     w8, #0, #0x6587a74
006587A60  adrp     x0, #0x8f08000
006587A64  ldr      x0, [x0, #0x128]
006587A68  bl       #0x382bd14 ; 
006587A6C  mov      w8, #1
006587A70  strb     w8, [x20, #0x19c]
006587A74  ldr      x1, [x21]
006587A78  ldrb     w8, [x1, #0x53]
006587A7C  tbnz     w8, #5, #0x6587a94
006587A80  mov      x0, x19
006587A84  ldp      x20, x19, [sp, #0x10]
006587A88  mov      x1, xzr
006587A8C  ldp      x30, x21, [sp], #0x20
006587A90  b        #0x65c4b74 ; HotFix.BattleLogic.SinglePlayerBattleManager$$TriggerWaveFlushEnemyEvent
006587A94  ldr      x2, [x1, #0x60]
006587A98  mov      x0, x19
006587A9C  ldp      x20, x19, [sp, #0x10]
006587AA0  ldp      x30, x21, [sp], #0x20
006587AA4  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnFirstEnterBattle
; RVA 0x658A270; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A270  stp      x30, x21, [sp, #-0x20]!
00658A274  stp      x20, x19, [sp, #0x10]
00658A278  adrp     x20, #0x9599000
00658A27C  adrp     x21, #0x8f08000
00658A280  ldrb     w8, [x20, #0x19d]
00658A284  ldr      x21, [x21, #0x358]
00658A288  mov      x19, x0
00658A28C  tbnz     w8, #0, #0x658a2a4
00658A290  adrp     x0, #0x8f08000
00658A294  ldr      x0, [x0, #0x358]
00658A298  bl       #0x382bd14 ; 
00658A29C  mov      w8, #1
00658A2A0  strb     w8, [x20, #0x19d]
00658A2A4  ldr      x1, [x21]
00658A2A8  ldrb     w8, [x1, #0x53]
00658A2AC  tbnz     w8, #5, #0x658a308
00658A2B0  ldr      x8, [x19, #0xd8]
00658A2B4  cbnz     x8, #0x658a2cc
00658A2B8  ldr      x8, [x19]
00658A2BC  mov      x0, x19
00658A2C0  ldr      x9, [x8, #0x5d8]
00658A2C4  ldr      x1, [x8, #0x5e0]
00658A2C8  blr      x9
00658A2CC  adrp     x20, #0x9599000
00658A2D0  ldrb     w8, [x20, #0x286]
00658A2D4  cbnz     w8, #0x658a2ec
00658A2D8  adrp     x0, #0x8f07000
00658A2DC  ldr      x0, [x0, #0xc98]
00658A2E0  bl       #0x382bd14 ; 
00658A2E4  mov      w8, #1
00658A2E8  strb     w8, [x20, #0x286]
00658A2EC  adrp     x21, #0x8f07000
00658A2F0  ldr      x21, [x21, #0xc98]
00658A2F4  ldr      x1, [x21]
00658A2F8  ldrb     w8, [x1, #0x53]
00658A2FC  tbnz     w8, #5, #0x658a31c
00658A300  ldr      x0, [x19, #0x80]
00658A304  b        #0x658a328 ; 
00658A308  ldr      x2, [x1, #0x60]
00658A30C  mov      x0, x19
00658A310  ldp      x20, x19, [sp, #0x10]
00658A314  ldp      x30, x21, [sp], #0x20
00658A318  br       x2
00658A31C  ldr      x8, [x1, #0x60]
00658A320  mov      x0, x19
00658A324  blr      x8
00658A328  cbz      x0, #0x658a3a4
00658A32C  ldr      x0, [x0, #0x1d0]
00658A330  cbz      x0, #0x658a3a4
00658A334  ldr      x8, [x0]
00658A338  ldp      x9, x1, [x8, #0x198]
00658A33C  blr      x9
00658A340  tbz      w0, #0, #0x658a38c
00658A344  ldrb     w8, [x20, #0x286]
00658A348  cbnz     w8, #0x658a360
00658A34C  adrp     x0, #0x8f07000
00658A350  ldr      x0, [x0, #0xc98]
00658A354  bl       #0x382bd14 ; 
00658A358  mov      w8, #1
00658A35C  strb     w8, [x20, #0x286]
00658A360  ldr      x1, [x21]
00658A364  ldrb     w8, [x1, #0x53]
00658A368  tbnz     w8, #5, #0x658a374
00658A36C  ldr      x0, [x19, #0x80]
00658A370  b        #0x658a380 ; 
00658A374  ldr      x8, [x1, #0x60]
00658A378  mov      x0, x19
00658A37C  blr      x8
00658A380  cbz      x0, #0x658a3a4
00658A384  ldr      x8, [x0, #0x1b0]
00658A388  str      x8, [x19, #0xe8]
00658A38C  mov      x0, x19
00658A390  ldp      x20, x19, [sp, #0x10]
00658A394  mov      w1, #4
00658A398  mov      w2, wzr
00658A39C  ldp      x30, x21, [sp], #0x20
00658A3A0  b        #0x6587518 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetRefreshState
00658A3A4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsLastMission
; RVA 0x658A3A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A3A8  stp      x30, x21, [sp, #-0x20]!
00658A3AC  stp      x20, x19, [sp, #0x10]
00658A3B0  adrp     x20, #0x9599000
00658A3B4  adrp     x21, #0x8f08000
00658A3B8  ldrb     w8, [x20, #0x19e]
00658A3BC  ldr      x21, [x21, #0x360]
00658A3C0  mov      x19, x0
00658A3C4  tbnz     w8, #0, #0x658a3dc
00658A3C8  adrp     x0, #0x8f08000
00658A3CC  ldr      x0, [x0, #0x360]
00658A3D0  bl       #0x382bd14 ; 
00658A3D4  mov      w8, #1
00658A3D8  strb     w8, [x20, #0x19e]
00658A3DC  ldr      x1, [x21]
00658A3E0  ldrb     w8, [x1, #0x53]
00658A3E4  tbnz     w8, #5, #0x658a3f8
00658A3E8  ldrb     w0, [x19, #0x102]
00658A3EC  ldp      x20, x19, [sp, #0x10]
00658A3F0  ldp      x30, x21, [sp], #0x20
00658A3F4  ret      
00658A3F8  ldr      x2, [x1, #0x60]
00658A3FC  mov      x0, x19
00658A400  ldp      x20, x19, [sp, #0x10]
00658A404  ldp      x30, x21, [sp], #0x20
00658A408  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsWaveLastMission
; RVA 0x658A40C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A40C  stp      x30, x21, [sp, #-0x20]!
00658A410  stp      x20, x19, [sp, #0x10]
00658A414  adrp     x20, #0x9599000
00658A418  adrp     x21, #0x8f08000
00658A41C  ldrb     w8, [x20, #0x19f]
00658A420  ldr      x21, [x21, #0x368]
00658A424  mov      x19, x0
00658A428  tbnz     w8, #0, #0x658a440
00658A42C  adrp     x0, #0x8f08000
00658A430  ldr      x0, [x0, #0x368]
00658A434  bl       #0x382bd14 ; 
00658A438  mov      w8, #1
00658A43C  strb     w8, [x20, #0x19f]
00658A440  ldr      x1, [x21]
00658A444  ldrb     w8, [x1, #0x53]
00658A448  tbnz     w8, #5, #0x658a45c
00658A44C  ldp      x20, x19, [sp, #0x10]
00658A450  mov      w0, wzr
00658A454  ldp      x30, x21, [sp], #0x20
00658A458  ret      
00658A45C  ldr      x2, [x1, #0x60]
00658A460  mov      x0, x19
00658A464  ldp      x20, x19, [sp, #0x10]
00658A468  ldp      x30, x21, [sp], #0x20
00658A46C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsWaveShowStartUIMission
; RVA 0x658A470; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A470  stp      x30, x21, [sp, #-0x20]!
00658A474  stp      x20, x19, [sp, #0x10]
00658A478  adrp     x20, #0x9599000
00658A47C  adrp     x21, #0x8f08000
00658A480  ldrb     w8, [x20, #0x1a0]
00658A484  ldr      x21, [x21, #0x370]
00658A488  mov      x19, x0
00658A48C  tbnz     w8, #0, #0x658a4a4
00658A490  adrp     x0, #0x8f08000
00658A494  ldr      x0, [x0, #0x370]
00658A498  bl       #0x382bd14 ; 
00658A49C  mov      w8, #1
00658A4A0  strb     w8, [x20, #0x1a0]
00658A4A4  ldr      x1, [x21]
00658A4A8  ldrb     w8, [x1, #0x53]
00658A4AC  tbnz     w8, #5, #0x658a4c0
00658A4B0  ldp      x20, x19, [sp, #0x10]
00658A4B4  mov      w0, wzr
00658A4B8  ldp      x30, x21, [sp], #0x20
00658A4BC  ret      
00658A4C0  ldr      x2, [x1, #0x60]
00658A4C4  mov      x0, x19
00658A4C8  ldp      x20, x19, [sp, #0x10]
00658A4CC  ldp      x30, x21, [sp], #0x20
00658A4D0  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckWaveShowStartUI
; RVA 0x658A4D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A4D4  stp      x30, x21, [sp, #-0x20]!
00658A4D8  stp      x20, x19, [sp, #0x10]
00658A4DC  adrp     x20, #0x9599000
00658A4E0  adrp     x21, #0x8f08000
00658A4E4  ldrb     w8, [x20, #0x1a1]
00658A4E8  ldr      x21, [x21, #0x378]
00658A4EC  mov      x19, x0
00658A4F0  tbnz     w8, #0, #0x658a508
00658A4F4  adrp     x0, #0x8f08000
00658A4F8  ldr      x0, [x0, #0x378]
00658A4FC  bl       #0x382bd14 ; 
00658A500  mov      w8, #1
00658A504  strb     w8, [x20, #0x1a1]
00658A508  ldr      x1, [x21]
00658A50C  ldrb     w8, [x1, #0x53]
00658A510  tbnz     w8, #5, #0x658a524
00658A514  ldp      x20, x19, [sp, #0x10]
00658A518  mov      w0, wzr
00658A51C  ldp      x30, x21, [sp], #0x20
00658A520  ret      
00658A524  ldr      x2, [x1, #0x60]
00658A528  mov      x0, x19
00658A52C  ldp      x20, x19, [sp, #0x10]
00658A530  ldp      x30, x21, [sp], #0x20
00658A534  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckWaveShowEndUI
; RVA 0x658A538; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A538  stp      x30, x21, [sp, #-0x20]!
00658A53C  stp      x20, x19, [sp, #0x10]
00658A540  adrp     x20, #0x9599000
00658A544  adrp     x21, #0x8f08000
00658A548  ldrb     w8, [x20, #0x1a2]
00658A54C  ldr      x21, [x21, #0x380]
00658A550  mov      x19, x0
00658A554  tbnz     w8, #0, #0x658a56c
00658A558  adrp     x0, #0x8f08000
00658A55C  ldr      x0, [x0, #0x380]
00658A560  bl       #0x382bd14 ; 
00658A564  mov      w8, #1
00658A568  strb     w8, [x20, #0x1a2]
00658A56C  ldr      x1, [x21]
00658A570  ldrb     w8, [x1, #0x53]
00658A574  tbnz     w8, #5, #0x658a588
00658A578  ldp      x20, x19, [sp, #0x10]
00658A57C  mov      w0, wzr
00658A580  ldp      x30, x21, [sp], #0x20
00658A584  ret      
00658A588  ldr      x2, [x1, #0x60]
00658A58C  mov      x0, x19
00658A590  ldp      x20, x19, [sp, #0x10]
00658A594  ldp      x30, x21, [sp], #0x20
00658A598  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$WaveShowStartUIHandle
; RVA 0x658A59C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A59C  stp      x30, x21, [sp, #-0x20]!
00658A5A0  stp      x20, x19, [sp, #0x10]
00658A5A4  adrp     x20, #0x9599000
00658A5A8  adrp     x21, #0x8f08000
00658A5AC  ldrb     w8, [x20, #0x1a3]
00658A5B0  ldr      x21, [x21, #0x388]
00658A5B4  mov      x19, x0
00658A5B8  tbnz     w8, #0, #0x658a5d0
00658A5BC  adrp     x0, #0x8f08000
00658A5C0  ldr      x0, [x0, #0x388]
00658A5C4  bl       #0x382bd14 ; 
00658A5C8  mov      w8, #1
00658A5CC  strb     w8, [x20, #0x1a3]
00658A5D0  ldr      x1, [x21]
00658A5D4  ldrb     w8, [x1, #0x53]
00658A5D8  tbnz     w8, #5, #0x658a5ec
00658A5DC  ldp      x20, x19, [sp, #0x10]
00658A5E0  mov      w0, wzr
00658A5E4  ldp      x30, x21, [sp], #0x20
00658A5E8  ret      
00658A5EC  ldr      x2, [x1, #0x60]
00658A5F0  mov      x0, x19
00658A5F4  ldp      x20, x19, [sp, #0x10]
00658A5F8  ldp      x30, x21, [sp], #0x20
00658A5FC  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$WaveEndHandle
; RVA 0x658A600; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A600  stp      x30, x21, [sp, #-0x20]!
00658A604  stp      x20, x19, [sp, #0x10]
00658A608  adrp     x20, #0x9599000
00658A60C  adrp     x21, #0x8f08000
00658A610  ldrb     w8, [x20, #0x1a4]
00658A614  ldr      x21, [x21, #0x390]
00658A618  mov      x19, x0
00658A61C  tbnz     w8, #0, #0x658a634
00658A620  adrp     x0, #0x8f08000
00658A624  ldr      x0, [x0, #0x390]
00658A628  bl       #0x382bd14 ; 
00658A62C  mov      w8, #1
00658A630  strb     w8, [x20, #0x1a4]
00658A634  ldr      x1, [x21]
00658A638  ldrb     w8, [x1, #0x53]
00658A63C  tbnz     w8, #5, #0x658a64c
00658A640  ldp      x20, x19, [sp, #0x10]
00658A644  ldp      x30, x21, [sp], #0x20
00658A648  ret      
00658A64C  ldr      x2, [x1, #0x60]
00658A650  mov      x0, x19
00658A654  ldp      x20, x19, [sp, #0x10]
00658A658  ldp      x30, x21, [sp], #0x20
00658A65C  br       x2

; HotFix.BattleLogic.BaseSurvivalBattleManager$$.ctor
; RVA 0x658A660; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A660  stp      x30, x21, [sp, #-0x20]!
00658A664  stp      x20, x19, [sp, #0x10]
00658A668  adrp     x20, #0x9599000
00658A66C  adrp     x21, #0x8f08000
00658A670  ldrb     w8, [x20, #0x1a5]
00658A674  ldr      x21, [x21, #0x398]
00658A678  mov      x19, x0
00658A67C  tbnz     w8, #0, #0x658a6a0
00658A680  adrp     x0, #0x8f08000
00658A684  ldr      x0, [x0, #0x398]
00658A688  bl       #0x382bd14 ; 
00658A68C  adrp     x0, #0x8f08000
00658A690  ldr      x0, [x0, #0x3a0]
00658A694  bl       #0x382bd14 ; 
00658A698  mov      w8, #1
00658A69C  strb     w8, [x20, #0x1a5]
00658A6A0  ldr      x1, [x21]
00658A6A4  ldrb     w8, [x1, #0x53]
00658A6A8  tbnz     w8, #5, #0x658a6e4
00658A6AC  adrp     x8, #0x8f08000
00658A6B0  ldr      x8, [x8, #0x3a0]
00658A6B4  mov      w1, #0x258
00658A6B8  ldr      x0, [x8]
00658A6BC  bl       #0x382bdfc ; 
00658A6C0  mov      x1, x0
00658A6C4  mov      x0, x19
00658A6C8  str      x1, [x0, #0xa0]!
00658A6CC  bl       #0x382bcb8 ; 
00658A6D0  mov      x0, x19
00658A6D4  ldp      x20, x19, [sp, #0x10]
00658A6D8  mov      x1, xzr
00658A6DC  ldp      x30, x21, [sp], #0x20
00658A6E0  b        #0x65c7288 ; HotFix.BattleLogic.SinglePlayerBattleManager$$.ctor
00658A6E4  ldr      x2, [x1, #0x60]
00658A6E8  mov      x0, x19
00658A6EC  ldp      x20, x19, [sp, #0x10]
00658A6F0  ldp      x30, x21, [sp], #0x20
00658A6F4  br       x2

