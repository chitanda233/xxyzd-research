; HotFix.ShowPunchboardMsgProcessor$$OnExec
; RVA 0x6FBD920; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006FBD920  stp      x30, x27, [sp, #-0x50]!
006FBD924  stp      x26, x25, [sp, #0x10]
006FBD928  stp      x24, x23, [sp, #0x20]
006FBD92C  stp      x22, x21, [sp, #0x30]
006FBD930  stp      x20, x19, [sp, #0x40]
006FBD934  adrp     x21, #0x95a4000
006FBD938  adrp     x22, #0x8f6e000
006FBD93C  ldrb     w8, [x21, #0x5c8]
006FBD940  ldr      x22, [x22, #0x4c0] ; GLOBAL Method$HotFix.ShowPunchboardMsgProcessor.OnExec() @ 0x92a9938
006FBD944  mov      x20, x1
006FBD948  mov      x19, x0
006FBD94C  tbnz     w8, #0, #0x6fbd9e8
006FBD950  adrp     x0, #0x8f6e000
006FBD954  ldr      x0, [x0, #0x4c8] ; GLOBAL Method$System.Linq.Enumerable.Select<PunchboardSkillRandomData, int>() @ 0x9265598
006FBD958  bl       #0x382bd14 ; 
006FBD95C  adrp     x0, #0x8f06000
006FBD960  ldr      x0, [x0, #0x4a8] ; GLOBAL Method$System.Linq.Enumerable.ToList<int>() @ 0x9265be8
006FBD964  bl       #0x382bd14 ; 
006FBD968  adrp     x0, #0x8f6e000
006FBD96C  ldr      x0, [x0, #0x4d0] ; GLOBAL System.Func<PunchboardSkillRandomData, int>_TypeInfo @ 0x91d5e30
006FBD970  bl       #0x382bd14 ; 
006FBD974  adrp     x0, #0x8ee1000
006FBD978  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
006FBD97C  bl       #0x382bd14 ; 
006FBD980  adrp     x0, #0x8ee6000
006FBD984  ldr      x0, [x0, #0x680] ; GLOBAL HotFix.Game_TypeInfo @ 0x91e70a0
006FBD988  bl       #0x382bd14 ; 
006FBD98C  adrp     x0, #0x8ec1000
006FBD990  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
006FBD994  bl       #0x382bd14 ; 
006FBD998  adrp     x0, #0x8f09000
006FBD99C  ldr      x0, [x0, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
006FBD9A0  bl       #0x382bd14 ; 
006FBD9A4  adrp     x0, #0x8f6e000
006FBD9A8  ldr      x0, [x0, #0x4d8] ; GLOBAL HotFix.PunchboardViewModule_TypeInfo @ 0x91ee730
006FBD9AC  bl       #0x382bd14 ; 
006FBD9B0  adrp     x0, #0x8f6e000
006FBD9B4  ldr      x0, [x0, #0x4e0] ; GLOBAL Method$HotFix.RenderMsgProcessor.GetEvent<ShowPunchboadEvent>() @ 0x929fe30
006FBD9B8  bl       #0x382bd14 ; 
006FBD9BC  adrp     x0, #0x8f6e000
006FBD9C0  ldr      x0, [x0, #0x4c0] ; GLOBAL Method$HotFix.ShowPunchboardMsgProcessor.OnExec() @ 0x92a9938
006FBD9C4  bl       #0x382bd14 ; 
006FBD9C8  adrp     x0, #0x8f6e000
006FBD9CC  ldr      x0, [x0, #0x4e8] ; GLOBAL Method$HotFix.ShowPunchboardMsgProcessor.<>c.<OnExec>b__0_0() @ 0x92df2f8
006FBD9D0  bl       #0x382bd14 ; 
006FBD9D4  adrp     x0, #0x8f6e000
006FBD9D8  ldr      x0, [x0, #0x4f0] ; GLOBAL HotFix.ShowPunchboardMsgProcessor.<>c_TypeInfo @ 0x91fcea8
006FBD9DC  bl       #0x382bd14 ; 
006FBD9E0  mov      w8, #1
006FBD9E4  strb     w8, [x21, #0x5c8]
006FBD9E8  ldr      x2, [x22]
006FBD9EC  ldrb     w8, [x2, #0x53]
006FBD9F0  tbnz     w8, #5, #0x6fbdb4c
006FBD9F4  cbz      x20, #0x6fbe1f8
006FBD9F8  ldrb     w8, [x20, #0x69]
006FBD9FC  cbnz     w8, #0x6fbdba8
006FBDA00  adrp     x8, #0x8f6e000
006FBDA04  ldr      x8, [x8, #0x4e0] ; GLOBAL Method$HotFix.RenderMsgProcessor.GetEvent<ShowPunchboadEvent>() @ 0x929fe30
006FBDA08  mov      x0, x19
006FBDA0C  ldr      x1, [x8]
006FBDA10  bl       #0x46be474 ; HotFix.RenderMsgProcessor$$GetEvent<object>
006FBDA14  mov      x19, x0
006FBDA18  mov      x0, x20
006FBDA1C  mov      x1, xzr
006FBDA20  bl       #0x704d364 ; HotFix.WorldBattle$$get_IsOnlineBattle
006FBDA24  tbz      w0, #0, #0x6fbdaf4
006FBDA28  cbz      x19, #0x6fbe1f8
006FBDA2C  adrp     x24, #0x8f6e000
006FBDA30  ldr      x24, [x24, #0x4f0] ; GLOBAL HotFix.ShowPunchboardMsgProcessor.<>c_TypeInfo @ 0x91fcea8
006FBDA34  ldr      x21, [x19, #0x28]
006FBDA38  ldr      x0, [x24]
006FBDA3C  ldr      w8, [x0, #0xe0]
006FBDA40  cbnz     w8, #0x6fbda4c
006FBDA44  bl       #0x382be8c ; 
006FBDA48  ldr      x0, [x24]
006FBDA4C  ldr      x8, [x0, #0xb8]
006FBDA50  ldr      x22, [x8, #8]
006FBDA54  cbnz     x22, #0x6fbdab0
006FBDA58  ldr      w8, [x0, #0xe0]
006FBDA5C  cbnz     w8, #0x6fbda68
006FBDA60  bl       #0x382be8c ; 
006FBDA64  ldr      x0, [x24]
006FBDA68  adrp     x9, #0x8f6e000
006FBDA6C  ldr      x8, [x0, #0xb8]
006FBDA70  ldr      x9, [x9, #0x4d0] ; GLOBAL System.Func<PunchboardSkillRandomData, int>_TypeInfo @ 0x91d5e30
006FBDA74  ldr      x23, [x8]
006FBDA78  ldr      x0, [x9]
006FBDA7C  bl       #0x382bfa0 ; 
006FBDA80  adrp     x8, #0x8f6e000
006FBDA84  ldr      x8, [x8, #0x4e8] ; GLOBAL Method$HotFix.ShowPunchboardMsgProcessor.<>c.<OnExec>b__0_0() @ 0x92df2f8
006FBDA88  mov      x1, x23
006FBDA8C  mov      x3, xzr
006FBDA90  mov      x22, x0
006FBDA94  ldr      x2, [x8]
006FBDA98  bl       #0x48d612c ; System.Func<PunchboardSkillRandomData, int>$$.ctor
006FBDA9C  ldr      x8, [x24]
006FBDAA0  mov      x1, x22
006FBDAA4  ldr      x0, [x8, #0xb8]
006FBDAA8  str      x22, [x0, #8]!
006FBDAAC  bl       #0x382bcb8 ; 
006FBDAB0  adrp     x8, #0x8f6e000
006FBDAB4  ldr      x8, [x8, #0x4c8] ; GLOBAL Method$System.Linq.Enumerable.Select<PunchboardSkillRandomData, int>() @ 0x9265598
006FBDAB8  mov      x0, x21
006FBDABC  mov      x1, x22
006FBDAC0  ldr      x2, [x8]
006FBDAC4  bl       #0x45d0bc4 ; System.Linq.Enumerable$$Select<PunchboardSkillRandomData, int>
006FBDAC8  adrp     x8, #0x8f06000
006FBDACC  ldr      x8, [x8, #0x4a8] ; GLOBAL Method$System.Linq.Enumerable.ToList<int>() @ 0x9265be8
006FBDAD0  ldr      x1, [x8]
006FBDAD4  bl       #0x45dc05c ; System.Linq.Enumerable$$ToList<int>
006FBDAD8  mov      x1, x0
006FBDADC  mov      x0, x20
006FBDAE0  mov      x2, xzr
006FBDAE4  bl       #0x70504d0 ; HotFix.WorldBattle$$AddSkillsToPreLoad
006FBDAE8  mov      x0, x20
006FBDAEC  mov      x1, xzr
006FBDAF0  bl       #0x7050a90 ; HotFix.WorldBattle$$PreLoadSkillsNow
006FBDAF4  adrp     x21, #0x95a4000
006FBDAF8  ldrb     w8, [x21, #0x459]
006FBDAFC  cbnz     w8, #0x6fbdb20
006FBDB00  adrp     x0, #0x8f6c000
006FBDB04  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
006FBDB08  bl       #0x382bd14 ; 
006FBDB0C  adrp     x0, #0x8f6c000
006FBDB10  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
006FBDB14  bl       #0x382bd14 ; 
006FBDB18  mov      w8, #1
006FBDB1C  strb     w8, [x21, #0x459]
006FBDB20  adrp     x8, #0x8f6c000
006FBDB24  ldr      x8, [x8, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
006FBDB28  ldr      x0, [x8]
006FBDB2C  ldrb     w8, [x0, #0x53]
006FBDB30  tbnz     w8, #5, #0x6fbdb70
006FBDB34  adrp     x8, #0x8f6c000
006FBDB38  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
006FBDB3C  ldr      x8, [x8]
006FBDB40  ldr      x8, [x8, #0xb8]
006FBDB44  ldr      x0, [x8]
006FBDB48  b        #0x6fbdb78 ; 
006FBDB4C  ldr      x3, [x2, #0x60]
006FBDB50  mov      x0, x19
006FBDB54  mov      x1, x20
006FBDB58  ldp      x20, x19, [sp, #0x40]
006FBDB5C  ldp      x22, x21, [sp, #0x30]
006FBDB60  ldp      x24, x23, [sp, #0x20]
006FBDB64  ldp      x26, x25, [sp, #0x10]
006FBDB68  ldp      x30, x27, [sp], #0x50
006FBDB6C  br       x3
006FBDB70  ldr      x8, [x0, #0x60]
006FBDB74  blr      x8
006FBDB78  cbz      x0, #0x6fbe1f8
006FBDB7C  cbz      x19, #0x6fbe1f8
006FBDB80  ldr      w8, [x0, #0x6c]
006FBDB84  ldr      w9, [x19, #0x20]
006FBDB88  cmp      w8, w9
006FBDB8C  b.ne     #0x6fbdba8
006FBDB90  ldr      x8, [x20]
006FBDB94  mov      x0, x20
006FBDB98  ldr      x9, [x8, #0x218]
006FBDB9C  ldr      x1, [x8, #0x220]
006FBDBA0  blr      x9
006FBDBA4  tbz      w0, #0, #0x6fbdbc0
006FBDBA8  ldp      x20, x19, [sp, #0x40]
006FBDBAC  ldp      x22, x21, [sp, #0x30]
006FBDBB0  ldp      x24, x23, [sp, #0x20]
006FBDBB4  ldp      x26, x25, [sp, #0x10]
006FBDBB8  ldp      x30, x27, [sp], #0x50
006FBDBBC  ret      
006FBDBC0  mov      x0, x20
006FBDBC4  mov      x1, xzr
006FBDBC8  bl       #0x7056a2c ; HotFix.WorldBattle$$DoBlur
006FBDBCC  mov      x0, x20
006FBDBD0  mov      x1, xzr
006FBDBD4  bl       #0x704d364 ; HotFix.WorldBattle$$get_IsOnlineBattle
006FBDBD8  tbnz     w0, #0, #0x6fbdbe8
006FBDBDC  mov      x0, x20
006FBDBE0  mov      x1, xzr
006FBDBE4  bl       #0x704d670 ; HotFix.WorldBattle$$StopTime
006FBDBE8  adrp     x22, #0x8f6e000
006FBDBEC  ldr      x22, [x22, #0x4d8] ; GLOBAL HotFix.PunchboardViewModule_TypeInfo @ 0x91ee730
006FBDBF0  ldr      x0, [x22]
006FBDBF4  ldr      w8, [x0, #0xe0]
006FBDBF8  cbnz     w8, #0x6fbdc04
006FBDBFC  bl       #0x382be8c ; 
006FBDC00  ldr      x0, [x22]
006FBDC04  ldr      x8, [x0, #0xb8]
006FBDC08  ldr      x0, [x8]
006FBDC0C  cbz      x0, #0x6fbe1f8
006FBDC10  ldr      w8, [x19, #0x3c]
006FBDC14  str      w8, [x0, #0x28]
006FBDC18  ldr      x1, [x19, #0x30]
006FBDC1C  str      x1, [x0, #0x18]!
006FBDC20  bl       #0x382bcb8 ; 
006FBDC24  ldr      x8, [x22]
006FBDC28  ldr      x8, [x8, #0xb8]
006FBDC2C  ldr      x0, [x8]
006FBDC30  cbz      x0, #0x6fbe1f8
006FBDC34  ldr      x1, [x19, #0x28]
006FBDC38  str      x1, [x0, #0x10]!
006FBDC3C  bl       #0x382bcb8 ; 
006FBDC40  ldr      x8, [x22]
006FBDC44  ldr      x8, [x8, #0xb8]
006FBDC48  ldr      x20, [x8]
006FBDC4C  cbz      x20, #0x6fbe1f8
006FBDC50  ldr      w8, [x19, #0x38]
006FBDC54  mov      w23, #1
006FBDC58  strb     w23, [x20, #0x30]
006FBDC5C  adrp     x24, #0x95a4000
006FBDC60  str      w8, [x20, #0x2c]
006FBDC64  ldrb     w8, [x24, #0x6f8]
006FBDC68  ldrb     w21, [x19, #0x42]
006FBDC6C  cbnz     w8, #0x6fbdc80
006FBDC70  adrp     x0, #0x8f6e000
006FBDC74  ldr      x0, [x0, #0x4f8] ; GLOBAL Method$HotFix.PunchboardViewData.set_IsChapterSurvivor() @ 0x929ba78
006FBDC78  bl       #0x382bd14 ; 
006FBDC7C  strb     w23, [x24, #0x6f8]
006FBDC80  adrp     x8, #0x8f6e000
006FBDC84  ldr      x8, [x8, #0x4f8] ; GLOBAL Method$HotFix.PunchboardViewData.set_IsChapterSurvivor() @ 0x929ba78
006FBDC88  ldr      x2, [x8]
006FBDC8C  ldrb     w8, [x2, #0x53]
006FBDC90  tbnz     w8, #5, #0x6fbdc9c
006FBDC94  strb     w21, [x20, #0x58]
006FBDC98  b        #0x6fbdcb0 ; 
006FBDC9C  ldr      x8, [x2, #0x60]
006FBDCA0  cmp      w21, #0
006FBDCA4  cset     w1, ne
006FBDCA8  mov      x0, x20
006FBDCAC  blr      x8
006FBDCB0  ldr      x8, [x22]
006FBDCB4  ldr      x8, [x8, #0xb8]
006FBDCB8  ldr      x20, [x8]
006FBDCBC  cbz      x20, #0x6fbe1f8
006FBDCC0  adrp     x23, #0x95a4000
006FBDCC4  ldrb     w8, [x23, #0x6f9]
006FBDCC8  ldrb     w21, [x19, #0x41]
006FBDCCC  cbnz     w8, #0x6fbdce4
006FBDCD0  adrp     x0, #0x8f6e000
006FBDCD4  ldr      x0, [x0, #0x500] ; GLOBAL Method$HotFix.PunchboardViewData.set_IsBossWave() @ 0x929ba70
006FBDCD8  bl       #0x382bd14 ; 
006FBDCDC  mov      w8, #1
006FBDCE0  strb     w8, [x23, #0x6f9]
006FBDCE4  adrp     x8, #0x8f6e000
006FBDCE8  ldr      x8, [x8, #0x500] ; GLOBAL Method$HotFix.PunchboardViewData.set_IsBossWave() @ 0x929ba70
006FBDCEC  ldr      x2, [x8]
006FBDCF0  ldrb     w8, [x2, #0x53]
006FBDCF4  tbnz     w8, #5, #0x6fbdd00
006FBDCF8  strb     w21, [x20, #0x38]
006FBDCFC  b        #0x6fbdd14 ; 
006FBDD00  ldr      x8, [x2, #0x60]
006FBDD04  cmp      w21, #0
006FBDD08  cset     w1, ne
006FBDD0C  mov      x0, x20
006FBDD10  blr      x8
006FBDD14  ldr      x8, [x19, #0x48]
006FBDD18  cbz      x8, #0x6fbe1f8
006FBDD1C  ldr      x9, [x22]
006FBDD20  adrp     x10, #0x8ec1000
006FBDD24  ldr      x9, [x9, #0xb8]
006FBDD28  ldr      x10, [x10, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
006FBDD2C  ldr      w1, [x8, #0x18]
006FBDD30  ldr      x20, [x9]
006FBDD34  ldr      x0, [x10]
006FBDD38  bl       #0x382bdfc ; 
006FBDD3C  cbz      x20, #0x6fbe1f8
006FBDD40  adrp     x23, #0x95a4000
006FBDD44  ldrb     w8, [x23, #0x6fa]
006FBDD48  mov      x21, x0
006FBDD4C  cbnz     w8, #0x6fbdd64
006FBDD50  adrp     x0, #0x8f6e000
006FBDD54  ldr      x0, [x0, #0x508] ; GLOBAL Method$HotFix.PunchboardViewData.set_OwnSkills() @ 0x929ba80
006FBDD58  bl       #0x382bd14 ; 
006FBDD5C  mov      w8, #1
006FBDD60  strb     w8, [x23, #0x6fa]
006FBDD64  adrp     x8, #0x8f6e000
006FBDD68  ldr      x8, [x8, #0x508] ; GLOBAL Method$HotFix.PunchboardViewData.set_OwnSkills() @ 0x929ba80
006FBDD6C  ldr      x2, [x8]
006FBDD70  ldrb     w8, [x2, #0x53]
006FBDD74  tbnz     w8, #5, #0x6fbdd8c
006FBDD78  str      x21, [x20, #0x40]!
006FBDD7C  mov      x0, x20
006FBDD80  mov      x1, x21
006FBDD84  bl       #0x382bcb8 ; 
006FBDD88  b        #0x6fbdd9c ; 
006FBDD8C  ldr      x8, [x2, #0x60]
006FBDD90  mov      x0, x20
006FBDD94  mov      x1, x21
006FBDD98  blr      x8
006FBDD9C  ldr      x8, [x19, #0x48]
006FBDDA0  cbz      x8, #0x6fbe1f8
006FBDDA4  adrp     x21, #0x8f6e000
006FBDDA8  ldr      x27, [x8, #0x18]
006FBDDAC  ldr      x21, [x21, #0x510] ; GLOBAL Method$HotFix.PunchboardViewData.get_OwnSkills() @ 0x929ba30
006FBDDB0  mov      w23, #8
006FBDDB4  adrp     x24, #0x95a4000
006FBDDB8  mov      w25, #1
006FBDDBC  ldr      x0, [x22]
006FBDDC0  sub      x26, x23, #8
006FBDDC4  ldr      w8, [x0, #0xe0]
006FBDDC8  cbnz     w8, #0x6fbddd4
006FBDDCC  bl       #0x382be8c ; 
006FBDDD0  ldr      x0, [x22]
006FBDDD4  ldr      x8, [x0, #0xb8]
006FBDDD8  ldr      x20, [x8]
006FBDDDC  sxtw     x8, w27
006FBDDE0  cmp      x26, x8
006FBDDE4  b.ge     #0x6fbde54
006FBDDE8  cbz      x20, #0x6fbe1f8
006FBDDEC  ldrb     w8, [x24, #0x6fb]
006FBDDF0  cbnz     w8, #0x6fbde00
006FBDDF4  mov      x0, x21
006FBDDF8  bl       #0x382bd14 ; 
006FBDDFC  strb     w25, [x24, #0x6fb]
006FBDE00  ldr      x1, [x21]
006FBDE04  ldrb     w8, [x1, #0x53]
006FBDE08  tbnz     w8, #5, #0x6fbde14
006FBDE0C  ldr      x0, [x20, #0x40]
006FBDE10  b        #0x6fbde20 ; 
006FBDE14  ldr      x8, [x1, #0x60]
006FBDE18  mov      x0, x20
006FBDE1C  blr      x8
006FBDE20  ldr      x8, [x19, #0x48]
006FBDE24  cbz      x8, #0x6fbe1f8
006FBDE28  ldr      w27, [x8, #0x18]
006FBDE2C  cmp      x26, x27
006FBDE30  b.hs     #0x6fbe1fc
006FBDE34  cbz      x0, #0x6fbe1f8
006FBDE38  ldr      w9, [x0, #0x18]
006FBDE3C  cmp      x26, x9
006FBDE40  b.hs     #0x6fbe1fc
006FBDE44  ldr      w8, [x8, x23, lsl #2]
006FBDE48  str      w8, [x0, x23, lsl #2]
006FBDE4C  add      x23, x23, #1
006FBDE50  b        #0x6fbddbc ; 
006FBDE54  adrp     x8, #0x8ee6000
006FBDE58  ldr      x8, [x8, #0x680] ; GLOBAL HotFix.Game_TypeInfo @ 0x91e70a0
006FBDE5C  ldr      x0, [x8]
006FBDE60  ldr      w8, [x0, #0xe0]
006FBDE64  cbnz     w8, #0x6fbde6c
006FBDE68  bl       #0x382be8c ; 
006FBDE6C  mov      x0, xzr
006FBDE70  bl       #0x7091c90 ; HotFix.Game$$get_Table
006FBDE74  ldr      x8, [x19, #0x28]
006FBDE78  cbz      x8, #0x6fbe1f8
006FBDE7C  adrp     x23, #0x8f09000
006FBDE80  ldr      x23, [x23, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
006FBDE84  mov      x21, x0
006FBDE88  mov      x0, x8
006FBDE8C  mov      w1, wzr
006FBDE90  ldr      x2, [x23]
006FBDE94  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006FBDE98  cbz      x21, #0x6fbe1f8
006FBDE9C  mov      x1, x0
006FBDEA0  mov      x0, x21
006FBDEA4  mov      x2, xzr
006FBDEA8  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006FBDEAC  cbz      x0, #0x6fbe1f8
006FBDEB0  adrp     x24, #0x959b000
006FBDEB4  ldrb     w8, [x24, #0xb7f]
006FBDEB8  mov      x21, x0
006FBDEBC  cbnz     w8, #0x6fbded4
006FBDEC0  adrp     x0, #0x8f23000
006FBDEC4  ldr      x0, [x0, #0xa10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_Quality() @ 0x92ac518
006FBDEC8  bl       #0x382bd14 ; 
006FBDECC  mov      w8, #1
006FBDED0  strb     w8, [x24, #0xb7f]
006FBDED4  adrp     x8, #0x8f23000
006FBDED8  ldr      x8, [x8, #0xa10] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_Quality() @ 0x92ac518
006FBDEDC  ldr      x1, [x8]
006FBDEE0  ldrb     w8, [x1, #0x53]
006FBDEE4  tbnz     w8, #5, #0x6fbdef0
006FBDEE8  ldr      w21, [x21, #0x30]
006FBDEEC  b        #0x6fbdf00 ; 
006FBDEF0  ldr      x8, [x1, #0x60]
006FBDEF4  mov      x0, x21
006FBDEF8  blr      x8
006FBDEFC  mov      w21, w0
006FBDF00  cbz      x20, #0x6fbe1f8
006FBDF04  adrp     x24, #0x95a4000
006FBDF08  ldrb     w8, [x24, #0x6fc]
006FBDF0C  cbnz     w8, #0x6fbdf24
006FBDF10  adrp     x0, #0x8f6e000
006FBDF14  ldr      x0, [x0, #0x518] ; GLOBAL Method$HotFix.PunchboardViewData.set_SkillQuality() @ 0x929baa8
006FBDF18  bl       #0x382bd14 ; 
006FBDF1C  mov      w8, #1
006FBDF20  strb     w8, [x24, #0x6fc]
006FBDF24  adrp     x8, #0x8f6e000
006FBDF28  ldr      x8, [x8, #0x518] ; GLOBAL Method$HotFix.PunchboardViewData.set_SkillQuality() @ 0x929baa8
006FBDF2C  ldr      x2, [x8]
006FBDF30  ldrb     w8, [x2, #0x53]
006FBDF34  tbnz     w8, #5, #0x6fbdf40
006FBDF38  str      w21, [x20, #0x50]
006FBDF3C  b        #0x6fbdf50 ; 
006FBDF40  ldr      x8, [x2, #0x60]
006FBDF44  mov      x0, x20
006FBDF48  mov      w1, w21
006FBDF4C  blr      x8
006FBDF50  ldr      x8, [x22]
006FBDF54  mov      x0, xzr
006FBDF58  ldr      x8, [x8, #0xb8]
006FBDF5C  ldr      x20, [x8]
006FBDF60  bl       #0x7091c90 ; HotFix.Game$$get_Table
006FBDF64  ldr      x8, [x19, #0x28]
006FBDF68  cbz      x8, #0x6fbe1f8
006FBDF6C  ldr      x2, [x23]
006FBDF70  mov      x21, x0
006FBDF74  mov      x0, x8
006FBDF78  mov      w1, wzr
006FBDF7C  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
006FBDF80  cbz      x21, #0x6fbe1f8
006FBDF84  mov      x1, x0
006FBDF88  mov      x0, x21
006FBDF8C  mov      x2, xzr
006FBDF90  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006FBDF94  mov      w1, wzr
006FBDF98  mov      x2, xzr
006FBDF9C  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
006FBDFA0  cbz      x20, #0x6fbe1f8
006FBDFA4  adrp     x23, #0x95a4000
006FBDFA8  ldrb     w8, [x23, #0x6fd]
006FBDFAC  mov      w21, w0
006FBDFB0  cbnz     w8, #0x6fbdfc8
006FBDFB4  adrp     x0, #0x8f6e000
006FBDFB8  ldr      x0, [x0, #0x520] ; GLOBAL Method$HotFix.PunchboardViewData.set_SkillType() @ 0x929bab0
006FBDFBC  bl       #0x382bd14 ; 
006FBDFC0  mov      w8, #1
006FBDFC4  strb     w8, [x23, #0x6fd]
006FBDFC8  adrp     x8, #0x8f6e000
006FBDFCC  ldr      x8, [x8, #0x520] ; GLOBAL Method$HotFix.PunchboardViewData.set_SkillType() @ 0x929bab0
006FBDFD0  ldr      x2, [x8]
006FBDFD4  ldrb     w8, [x2, #0x53]
006FBDFD8  tbnz     w8, #5, #0x6fbdfe4
006FBDFDC  str      w21, [x20, #0x54]
006FBDFE0  b        #0x6fbdff4 ; 
006FBDFE4  ldr      x8, [x2, #0x60]
006FBDFE8  mov      x0, x20
006FBDFEC  mov      w1, w21
006FBDFF0  blr      x8
006FBDFF4  ldr      x8, [x22]
006FBDFF8  ldr      x8, [x8, #0xb8]
006FBDFFC  ldr      x20, [x8]
006FBE000  cbz      x20, #0x6fbe1f8
006FBE004  adrp     x23, #0x95a4000
006FBE008  ldrb     w8, [x23, #0x6fe]
006FBE00C  ldr      w21, [x19, #0x50]
006FBE010  cbnz     w8, #0x6fbe028
006FBE014  adrp     x0, #0x8f6e000
006FBE018  ldr      x0, [x0, #0x528] ; GLOBAL Method$HotFix.PunchboardViewData.set_Wave() @ 0x929bab8
006FBE01C  bl       #0x382bd14 ; 
006FBE020  mov      w8, #1
006FBE024  strb     w8, [x23, #0x6fe]
006FBE028  adrp     x8, #0x8f6e000
006FBE02C  ldr      x8, [x8, #0x528] ; GLOBAL Method$HotFix.PunchboardViewData.set_Wave() @ 0x929bab8
006FBE030  ldr      x2, [x8]
006FBE034  ldrb     w8, [x2, #0x53]
006FBE038  tbnz     w8, #5, #0x6fbe044
006FBE03C  str      w21, [x20, #0x3c]
006FBE040  b        #0x6fbe054 ; 
006FBE044  ldr      x8, [x2, #0x60]
006FBE048  mov      x0, x20
006FBE04C  mov      w1, w21
006FBE050  blr      x8
006FBE054  ldr      x8, [x22]
006FBE058  ldr      x8, [x8, #0xb8]
006FBE05C  ldr      x20, [x8]
006FBE060  cbz      x20, #0x6fbe1f8
006FBE064  adrp     x23, #0x95a4000
006FBE068  ldrb     w8, [x23, #0x6ff]
006FBE06C  ldr      w21, [x19, #0x54]
006FBE070  cbnz     w8, #0x6fbe088
006FBE074  adrp     x0, #0x8f6e000
006FBE078  ldr      x0, [x0, #0x530] ; GLOBAL Method$HotFix.PunchboardViewData.set_ShowWave() @ 0x929baa0
006FBE07C  bl       #0x382bd14 ; 
006FBE080  mov      w8, #1
006FBE084  strb     w8, [x23, #0x6ff]
006FBE088  adrp     x8, #0x8f6e000
006FBE08C  ldr      x8, [x8, #0x530] ; GLOBAL Method$HotFix.PunchboardViewData.set_ShowWave() @ 0x929baa0
006FBE090  ldr      x2, [x8]
006FBE094  ldrb     w8, [x2, #0x53]
006FBE098  tbnz     w8, #5, #0x6fbe0a4
006FBE09C  str      w21, [x20, #0x34]
006FBE0A0  b        #0x6fbe0b4 ; 
006FBE0A4  ldr      x8, [x2, #0x60]
006FBE0A8  mov      x0, x20
006FBE0AC  mov      w1, w21
006FBE0B0  blr      x8
006FBE0B4  ldr      x8, [x22]
006FBE0B8  ldr      x8, [x8, #0xb8]
006FBE0BC  ldr      x20, [x8]
006FBE0C0  cbz      x20, #0x6fbe1f8
006FBE0C4  adrp     x23, #0x95a4000
006FBE0C8  ldrb     w8, [x23, #0x700]
006FBE0CC  ldr      w21, [x19, #0x5c]
006FBE0D0  cbnz     w8, #0x6fbe0e8
006FBE0D4  adrp     x0, #0x8f6e000
006FBE0D8  ldr      x0, [x0, #0x538] ; GLOBAL Method$HotFix.PunchboardViewData.set_PlayerCurHp() @ 0x929ba90
006FBE0DC  bl       #0x382bd14 ; 
006FBE0E0  mov      w8, #1
006FBE0E4  strb     w8, [x23, #0x700]
006FBE0E8  adrp     x8, #0x8f6e000
006FBE0EC  ldr      x8, [x8, #0x538] ; GLOBAL Method$HotFix.PunchboardViewData.set_PlayerCurHp() @ 0x929ba90
006FBE0F0  ldr      x2, [x8]
006FBE0F4  ldrb     w8, [x2, #0x53]
006FBE0F8  tbnz     w8, #5, #0x6fbe104
006FBE0FC  str      w21, [x20, #0x60]
006FBE100  b        #0x6fbe114 ; 
006FBE104  ldr      x8, [x2, #0x60]
006FBE108  mov      x0, x20
006FBE10C  mov      w1, w21
006FBE110  blr      x8
006FBE114  ldr      x8, [x22]
006FBE118  ldr      x8, [x8, #0xb8]
006FBE11C  ldr      x20, [x8]
006FBE120  cbz      x20, #0x6fbe1f8
006FBE124  adrp     x21, #0x95a4000
006FBE128  ldrb     w8, [x21, #0x701]
006FBE12C  ldr      w19, [x19, #0x58]
006FBE130  cbnz     w8, #0x6fbe148
006FBE134  adrp     x0, #0x8f6e000
006FBE138  ldr      x0, [x0, #0x540] ; GLOBAL Method$HotFix.PunchboardViewData.set_PlayerCurAttack() @ 0x929ba88
006FBE13C  bl       #0x382bd14 ; 
006FBE140  mov      w8, #1
006FBE144  strb     w8, [x21, #0x701]
006FBE148  adrp     x8, #0x8f6e000
006FBE14C  ldr      x8, [x8, #0x540] ; GLOBAL Method$HotFix.PunchboardViewData.set_PlayerCurAttack() @ 0x929ba88
006FBE150  ldr      x2, [x8]
006FBE154  ldrb     w8, [x2, #0x53]
006FBE158  tbnz     w8, #5, #0x6fbe164
006FBE15C  str      w19, [x20, #0x5c]
006FBE160  b        #0x6fbe174 ; 
006FBE164  ldr      x8, [x2, #0x60]
006FBE168  mov      x0, x20
006FBE16C  mov      w1, w19
006FBE170  blr      x8
006FBE174  adrp     x19, #0x8ee1000
006FBE178  ldr      x19, [x19, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
006FBE17C  ldr      x0, [x19]
006FBE180  ldr      w8, [x0, #0xe0]
006FBE184  cbnz     w8, #0x6fbe18c
006FBE188  bl       #0x382be8c ; 
006FBE18C  adrp     x20, #0x9591000
006FBE190  ldrb     w8, [x20, #0x59d]
006FBE194  cbnz     w8, #0x6fbe1ac
006FBE198  adrp     x0, #0x8ee1000
006FBE19C  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
006FBE1A0  bl       #0x382bd14 ; 
006FBE1A4  mov      w8, #1
006FBE1A8  strb     w8, [x20, #0x59d]
006FBE1AC  ldr      x0, [x19]
006FBE1B0  ldr      w8, [x0, #0xe0]
006FBE1B4  cbnz     w8, #0x6fbe1c0
006FBE1B8  bl       #0x382be8c ; 
006FBE1BC  ldr      x0, [x19]
006FBE1C0  ldr      x8, [x0, #0xb8]
006FBE1C4  ldp      x20, x19, [sp, #0x40]
006FBE1C8  ldp      x22, x21, [sp, #0x30]
006FBE1CC  ldp      x24, x23, [sp, #0x20]
006FBE1D0  ldr      x0, [x8, #0x28]
006FBE1D4  ldp      x26, x25, [sp, #0x10]
006FBE1D8  mov      w1, #0x1d
006FBE1DC  mov      w3, #1
006FBE1E0  mov      x2, xzr
006FBE1E4  mov      x4, xzr
006FBE1E8  mov      x5, xzr
006FBE1EC  mov      x6, xzr
006FBE1F0  ldp      x30, x27, [sp], #0x50
006FBE1F4  b        #0x7257458 ; HotFix.FrameworkExpand$$OpenView
006FBE1F8  bl       #0x382bfb8 ; 
006FBE1FC  bl       #0x382bfc0 ; 

