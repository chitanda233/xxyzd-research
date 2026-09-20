; HotFix.BattleLogic.NormalSkillCreator$$RandomDevilSkill
; RVA 0x6873E44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006873E44  sub      sp, sp, #0x60
006873E48  stp      x30, x27, [sp, #0x10]
006873E4C  stp      x26, x25, [sp, #0x20]
006873E50  stp      x24, x23, [sp, #0x30]
006873E54  stp      x22, x21, [sp, #0x40]
006873E58  stp      x20, x19, [sp, #0x50]
006873E5C  adrp     x22, #0x959b000
006873E60  adrp     x23, #0x8f24000
006873E64  ldrb     w8, [x22, #0xa9c]
006873E68  ldr      x23, [x23, #0x478] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.RandomDevilSkill() @ 0x9295ee8
006873E6C  mov      w21, w2
006873E70  mov      x20, x1
006873E74  mov      x19, x0
006873E78  tbnz     w8, #0, #0x6873ecc
006873E7C  adrp     x0, #0x8ee8000
006873E80  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006873E84  bl       #0x382bd14 ; 
006873E88  adrp     x0, #0x8f07000
006873E8C  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006873E90  bl       #0x382bd14 ; 
006873E94  adrp     x0, #0x8ec2000
006873E98  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006873E9C  bl       #0x382bd14 ; 
006873EA0  adrp     x0, #0x8f24000
006873EA4  ldr      x0, [x0, #0x478] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.RandomDevilSkill() @ 0x9295ee8
006873EA8  bl       #0x382bd14 ; 
006873EAC  adrp     x0, #0x8f08000
006873EB0  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006873EB4  bl       #0x382bd14 ; 
006873EB8  adrp     x0, #0x8f08000
006873EBC  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006873EC0  bl       #0x382bd14 ; 
006873EC4  mov      w8, #1
006873EC8  strb     w8, [x22, #0xa9c]
006873ECC  ldr      x3, [x23]
006873ED0  ldrb     w8, [x3, #0x53]
006873ED4  tbnz     w8, #5, #0x6873f24
006873ED8  mov      x0, x19
006873EDC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873EE0  cbz      x0, #0x68740d4
006873EE4  adrp     x25, #0x9591000
006873EE8  ldrb     w8, [x25, #0xa90]
006873EEC  mov      x22, x0
006873EF0  cbnz     w8, #0x6873f08
006873EF4  adrp     x0, #0x8ee6000
006873EF8  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006873EFC  bl       #0x382bd14 ; 
006873F00  mov      w8, #1
006873F04  strb     w8, [x25, #0xa90]
006873F08  adrp     x26, #0x8ee6000
006873F0C  ldr      x26, [x26, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006873F10  ldr      x1, [x26]
006873F14  ldrb     w8, [x1, #0x53]
006873F18  tbnz     w8, #5, #0x6873f50
006873F1C  ldr      x0, [x22, #0x230]
006873F20  b        #0x6873f5c ; 
006873F24  ldr      x4, [x3, #0x60]
006873F28  and      w2, w21, #1
006873F2C  mov      x0, x19
006873F30  mov      x1, x20
006873F34  ldp      x20, x19, [sp, #0x50]
006873F38  ldp      x22, x21, [sp, #0x40]
006873F3C  ldp      x24, x23, [sp, #0x30]
006873F40  ldp      x26, x25, [sp, #0x20]
006873F44  ldp      x30, x27, [sp, #0x10]
006873F48  add      sp, sp, #0x60
006873F4C  br       x4
006873F50  ldr      x8, [x1, #0x60]
006873F54  mov      x0, x22
006873F58  blr      x8
006873F5C  cbz      x0, #0x68740d4
006873F60  adrp     x8, #0x8f08000
006873F64  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006873F68  ldr      x1, [x8]
006873F6C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006873F70  ldr      x8, [x19, #0x58]
006873F74  cbz      x8, #0x68740d4
006873F78  adrp     x9, #0x8f07000
006873F7C  ldr      x9, [x9, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006873F80  mov      x22, x0
006873F84  mov      x0, x8
006873F88  ldr      x1, [x9]
006873F8C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006873F90  cbz      x0, #0x68740d4
006873F94  adrp     x24, #0x9599000
006873F98  ldrb     w8, [x24, #0x4c7]
006873F9C  mov      x23, x0
006873FA0  cbnz     w8, #0x6873fb8
006873FA4  adrp     x0, #0x8f09000
006873FA8  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
006873FAC  bl       #0x382bd14 ; 
006873FB0  mov      w8, #1
006873FB4  strb     w8, [x24, #0x4c7]
006873FB8  adrp     x8, #0x8f09000
006873FBC  ldr      x8, [x8, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
006873FC0  ldr      x1, [x8]
006873FC4  ldrb     w8, [x1, #0x53]
006873FC8  tbnz     w8, #5, #0x6873fd4
006873FCC  ldr      x23, [x23, #0x58]
006873FD0  b        #0x6873fe4 ; 
006873FD4  ldr      x8, [x1, #0x60]
006873FD8  mov      x0, x23
006873FDC  blr      x8
006873FE0  mov      x23, x0
006873FE4  adrp     x27, #0x8ee8000
006873FE8  ldr      x27, [x27, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006873FEC  ldr      x24, [x19, #0x88]
006873FF0  ldr      x0, [x27]
006873FF4  ldr      w8, [x0, #0xe0]
006873FF8  cbnz     w8, #0x6874004
006873FFC  bl       #0x382be8c ; 
006874000  ldr      x0, [x27]
006874004  ldr      x8, [x0, #0xb8]
006874008  and      w7, w21, #1
00687400C  mov      w4, #1
006874010  mov      x0, x19
006874014  ldr      x6, [x8, #0x1f0]
006874018  mov      x1, x22
00687401C  mov      x2, x23
006874020  mov      x3, x24
006874024  mov      x5, x20
006874028  strb     wzr, [sp]
00687402C  bl       #0x685b9c4 ; HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills
006874030  cbz      x22, #0x68740d4
006874034  adrp     x8, #0x8ec2000
006874038  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00687403C  mov      x0, x22
006874040  mov      w1, wzr
006874044  ldr      x2, [x8]
006874048  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00687404C  mov      w20, w0
006874050  mov      x0, x19
006874054  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006874058  cbz      x0, #0x68740d4
00687405C  ldrb     w8, [x25, #0xa90]
006874060  mov      x19, x0
006874064  cbnz     w8, #0x687407c
006874068  adrp     x0, #0x8ee6000
00687406C  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006874070  bl       #0x382bd14 ; 
006874074  mov      w8, #1
006874078  strb     w8, [x25, #0xa90]
00687407C  ldr      x1, [x26]
006874080  ldrb     w8, [x1, #0x53]
006874084  tbnz     w8, #5, #0x6874090
006874088  ldr      x0, [x19, #0x230]
00687408C  b        #0x687409c ; 
006874090  ldr      x8, [x1, #0x60]
006874094  mov      x0, x19
006874098  blr      x8
00687409C  cbz      x0, #0x68740d4
0068740A0  adrp     x8, #0x8f08000
0068740A4  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
0068740A8  mov      x1, x22
0068740AC  ldr      x2, [x8]
0068740B0  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
0068740B4  mov      w0, w20
0068740B8  ldp      x20, x19, [sp, #0x50]
0068740BC  ldp      x22, x21, [sp, #0x40]
0068740C0  ldp      x24, x23, [sp, #0x30]
0068740C4  ldp      x26, x25, [sp, #0x20]
0068740C8  ldp      x30, x27, [sp, #0x10]
0068740CC  add      sp, sp, #0x60
0068740D0  ret      
0068740D4  bl       #0x382bfb8 ; 

