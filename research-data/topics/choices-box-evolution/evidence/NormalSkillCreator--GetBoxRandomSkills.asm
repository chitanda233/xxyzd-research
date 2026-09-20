; HotFix.BattleLogic.NormalSkillCreator$$GetBoxRandomSkills
; RVA 0x6872D70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872D70  sub      sp, sp, #0x80
006872D74  stp      x29, x30, [sp, #0x20]
006872D78  stp      x28, x27, [sp, #0x30]
006872D7C  stp      x26, x25, [sp, #0x40]
006872D80  stp      x24, x23, [sp, #0x50]
006872D84  stp      x22, x21, [sp, #0x60]
006872D88  stp      x20, x19, [sp, #0x70]
006872D8C  adrp     x23, #0x959b000
006872D90  adrp     x24, #0x8f24000
006872D94  ldrb     w8, [x23, #0xa94]
006872D98  ldr      x24, [x24, #0x428] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.GetBoxRandomSkills() @ 0x9295e80
006872D9C  mov      w22, w3
006872DA0  mov      x21, x2
006872DA4  mov      x20, x1
006872DA8  mov      x19, x0
006872DAC  tbnz     w8, #0, #0x6872df4
006872DB0  adrp     x0, #0x8f07000
006872DB4  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006872DB8  bl       #0x382bd14 ; 
006872DBC  adrp     x0, #0x8ec2000
006872DC0  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006872DC4  bl       #0x382bd14 ; 
006872DC8  adrp     x0, #0x8f24000
006872DCC  ldr      x0, [x0, #0x428] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.GetBoxRandomSkills() @ 0x9295e80
006872DD0  bl       #0x382bd14 ; 
006872DD4  adrp     x0, #0x8f08000
006872DD8  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006872DDC  bl       #0x382bd14 ; 
006872DE0  adrp     x0, #0x8f08000
006872DE4  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006872DE8  bl       #0x382bd14 ; 
006872DEC  mov      w8, #1
006872DF0  strb     w8, [x23, #0xa94]
006872DF4  ldr      x4, [x24]
006872DF8  ldrb     w8, [x4, #0x53]
006872DFC  tbnz     w8, #5, #0x6872e4c
006872E00  mov      x0, x19
006872E04  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006872E08  cbz      x0, #0x68730ec
006872E0C  adrp     x27, #0x9591000
006872E10  ldrb     w8, [x27, #0xa90]
006872E14  mov      x23, x0
006872E18  cbnz     w8, #0x6872e30
006872E1C  adrp     x0, #0x8ee6000
006872E20  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006872E24  bl       #0x382bd14 ; 
006872E28  mov      w8, #1
006872E2C  strb     w8, [x27, #0xa90]
006872E30  adrp     x28, #0x8ee6000
006872E34  ldr      x28, [x28, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006872E38  ldr      x1, [x28]
006872E3C  ldrb     w8, [x1, #0x53]
006872E40  tbnz     w8, #5, #0x6872e80
006872E44  ldr      x0, [x23, #0x230]
006872E48  b        #0x6872e8c ; 
006872E4C  ldr      x5, [x4, #0x60]
006872E50  and      w3, w22, #1
006872E54  mov      x0, x19
006872E58  mov      x1, x20
006872E5C  mov      x2, x21
006872E60  ldp      x20, x19, [sp, #0x70]
006872E64  ldp      x22, x21, [sp, #0x60]
006872E68  ldp      x24, x23, [sp, #0x50]
006872E6C  ldp      x26, x25, [sp, #0x40]
006872E70  ldp      x28, x27, [sp, #0x30]
006872E74  ldp      x29, x30, [sp, #0x20]
006872E78  add      sp, sp, #0x80
006872E7C  br       x5
006872E80  ldr      x8, [x1, #0x60]
006872E84  mov      x0, x23
006872E88  blr      x8
006872E8C  cbz      x0, #0x68730ec
006872E90  adrp     x8, #0x8f08000
006872E94  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006872E98  ldr      x1, [x8]
006872E9C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006872EA0  ldr      x8, [x19]
006872EA4  ldr      x24, [x19, #0x20]
006872EA8  mov      x23, x0
006872EAC  mov      x0, x19
006872EB0  ldr      x9, [x8, #0x2e8]
006872EB4  ldr      x1, [x8, #0x2f0]
006872EB8  blr      x9
006872EBC  mov      w25, w0
006872EC0  str      wzr, [sp, #0x1c]
006872EC4  tbz      w0, #0, #0x6872f94
006872EC8  ldr      x24, [x19, #0x80]
006872ECC  mov      x0, x19
006872ED0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006872ED4  cbz      x0, #0x68730ec
006872ED8  adrp     x29, #0x9599000
006872EDC  ldrb     w8, [x29, #0xac6]
006872EE0  mov      x26, x0
006872EE4  cbnz     w8, #0x6872efc
006872EE8  adrp     x0, #0x8f0d000
006872EEC  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006872EF0  bl       #0x382bd14 ; 
006872EF4  mov      w8, #1
006872EF8  strb     w8, [x29, #0xac6]
006872EFC  adrp     x8, #0x8f0d000
006872F00  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006872F04  ldr      x3, [x8]
006872F08  ldrb     w8, [x3, #0x53]
006872F0C  tbnz     w8, #5, #0x6872f4c
006872F10  adrp     x29, #0x9599000
006872F14  ldrb     w8, [x29, #0xac7]
006872F18  cbnz     w8, #0x6872f30
006872F1C  adrp     x0, #0x8f0d000
006872F20  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006872F24  bl       #0x382bd14 ; 
006872F28  mov      w8, #1
006872F2C  strb     w8, [x29, #0xac7]
006872F30  adrp     x8, #0x8f0d000
006872F34  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006872F38  ldr      x1, [x8]
006872F3C  ldrb     w8, [x1, #0x53]
006872F40  tbnz     w8, #5, #0x6872f64
006872F44  ldr      x0, [x26, #0x260]
006872F48  b        #0x6872f70 ; 
006872F4C  ldr      x8, [x3, #0x60]
006872F50  mov      w1, #1
006872F54  mov      w2, #3
006872F58  mov      x0, x26
006872F5C  blr      x8
006872F60  b        #0x6872f90 ; 
006872F64  ldr      x8, [x1, #0x60]
006872F68  mov      x0, x26
006872F6C  blr      x8
006872F70  cbz      x0, #0x68730ec
006872F74  mov      w1, #1
006872F78  mov      w2, #3
006872F7C  mov      x3, xzr
006872F80  bl       #0x416d068 ; XXRandom$$Next
006872F84  ldr      w8, [x26, #0x32c]
006872F88  add      w8, w8, #1
006872F8C  str      w8, [x26, #0x32c]
006872F90  str      w0, [sp, #0x1c]
006872F94  ldr      x0, [x19, #0x58]
006872F98  cbz      x0, #0x68730ec
006872F9C  adrp     x8, #0x8f07000
006872FA0  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006872FA4  ldr      x1, [x8]
006872FA8  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006872FAC  cbz      x0, #0x68730ec
006872FB0  adrp     x29, #0x9599000
006872FB4  ldrb     w8, [x29, #0x4c7]
006872FB8  mov      x26, x0
006872FBC  cbnz     w8, #0x6872fd4
006872FC0  adrp     x0, #0x8f09000
006872FC4  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
006872FC8  bl       #0x382bd14 ; 
006872FCC  mov      w8, #1
006872FD0  strb     w8, [x29, #0x4c7]
006872FD4  adrp     x8, #0x8f09000
006872FD8  ldr      x8, [x8, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
006872FDC  ldr      x1, [x8]
006872FE0  ldrb     w8, [x1, #0x53]
006872FE4  tbnz     w8, #5, #0x6872ff0
006872FE8  ldr      x2, [x26, #0x58]
006872FEC  b        #0x6873000 ; 
006872FF0  ldr      x8, [x1, #0x60]
006872FF4  mov      x0, x26
006872FF8  blr      x8
006872FFC  mov      x2, x0
006873000  and      w8, w25, #1
006873004  and      w7, w22, #1
006873008  add      x5, sp, #0x1c
00687300C  mov      w4, #2
006873010  mov      x0, x19
006873014  mov      x1, x23
006873018  mov      x3, x24
00687301C  mov      x6, x21
006873020  strb     w8, [sp]
006873024  bl       #0x685b9c4 ; HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills
006873028  ldr      w8, [sp, #0x1c]
00687302C  add      w8, w8, #2
006873030  str      w8, [x20]
006873034  cbz      x23, #0x68730ec
006873038  adrp     x21, #0x8ec2000
00687303C  ldr      x21, [x21, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006873040  mov      x0, x23
006873044  mov      w1, wzr
006873048  ldr      x2, [x21]
00687304C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873050  str      w0, [x20, #4]
006873054  ldr      x2, [x21]
006873058  mov      w1, #1
00687305C  mov      x0, x23
006873060  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873064  str      w0, [x20, #8]
006873068  mov      x0, x19
00687306C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873070  cbz      x0, #0x68730ec
006873074  ldrb     w8, [x27, #0xa90]
006873078  mov      x19, x0
00687307C  cbnz     w8, #0x6873094
006873080  adrp     x0, #0x8ee6000
006873084  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006873088  bl       #0x382bd14 ; 
00687308C  mov      w8, #1
006873090  strb     w8, [x27, #0xa90]
006873094  ldr      x1, [x28]
006873098  ldrb     w8, [x1, #0x53]
00687309C  tbnz     w8, #5, #0x68730a8
0068730A0  ldr      x0, [x19, #0x230]
0068730A4  b        #0x68730b4 ; 
0068730A8  ldr      x8, [x1, #0x60]
0068730AC  mov      x0, x19
0068730B0  blr      x8
0068730B4  cbz      x0, #0x68730ec
0068730B8  adrp     x8, #0x8f08000
0068730BC  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
0068730C0  mov      x1, x23
0068730C4  ldr      x2, [x8]
0068730C8  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
0068730CC  ldp      x20, x19, [sp, #0x70]
0068730D0  ldp      x22, x21, [sp, #0x60]
0068730D4  ldp      x24, x23, [sp, #0x50]
0068730D8  ldp      x26, x25, [sp, #0x40]
0068730DC  ldp      x28, x27, [sp, #0x30]
0068730E0  ldp      x29, x30, [sp, #0x20]
0068730E4  add      sp, sp, #0x80
0068730E8  ret      
0068730EC  bl       #0x382bfb8 ; 

