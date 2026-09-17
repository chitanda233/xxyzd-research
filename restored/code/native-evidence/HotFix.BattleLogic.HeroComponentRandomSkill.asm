; HotFix.BattleLogic.HeroComponentRandomSkill$$get_ReplaceSkillDic
; RVA 0x6867E70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006867E70  stp      x30, x21, [sp, #-0x20]!
006867E74  stp      x20, x19, [sp, #0x10]
006867E78  adrp     x20, #0x959b000
006867E7C  adrp     x21, #0x8f1d000
006867E80  ldrb     w8, [x20, #0xa2e]
006867E84  ldr      x21, [x21, #0xb78]
006867E88  mov      x19, x0
006867E8C  tbnz     w8, #0, #0x6867ea4
006867E90  adrp     x0, #0x8f1d000
006867E94  ldr      x0, [x0, #0xb78]
006867E98  bl       #0x382bd14 ; 
006867E9C  mov      w8, #1
006867EA0  strb     w8, [x20, #0xa2e]
006867EA4  ldr      x1, [x21]
006867EA8  ldrb     w8, [x1, #0x53]
006867EAC  tbnz     w8, #5, #0x6867ec0
006867EB0  ldr      x0, [x19, #0x40]
006867EB4  ldp      x20, x19, [sp, #0x10]
006867EB8  ldp      x30, x21, [sp], #0x20
006867EBC  ret      
006867EC0  ldr      x2, [x1, #0x60]
006867EC4  mov      x0, x19
006867EC8  ldp      x20, x19, [sp, #0x10]
006867ECC  ldp      x30, x21, [sp], #0x20
006867ED0  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$get_RandomSkillResult
; RVA 0x6867ED4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006867ED4  stp      x30, x21, [sp, #-0x20]!
006867ED8  stp      x20, x19, [sp, #0x10]
006867EDC  adrp     x20, #0x959b000
006867EE0  adrp     x21, #0x8f09000
006867EE4  ldrb     w8, [x20, #0xa2f]
006867EE8  ldr      x21, [x21, #0x8e0]
006867EEC  mov      x19, x0
006867EF0  tbnz     w8, #0, #0x6867f08
006867EF4  adrp     x0, #0x8f09000
006867EF8  ldr      x0, [x0, #0x8e0]
006867EFC  bl       #0x382bd14 ; 
006867F00  mov      w8, #1
006867F04  strb     w8, [x20, #0xa2f]
006867F08  ldr      x1, [x21]
006867F0C  ldrb     w8, [x1, #0x53]
006867F10  tbnz     w8, #5, #0x6867f24
006867F14  ldr      x0, [x19, #0x80]
006867F18  ldp      x20, x19, [sp, #0x10]
006867F1C  ldp      x30, x21, [sp], #0x20
006867F20  ret      
006867F24  ldr      x2, [x1, #0x60]
006867F28  mov      x0, x19
006867F2C  ldp      x20, x19, [sp, #0x10]
006867F30  ldp      x30, x21, [sp], #0x20
006867F34  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$get_SkillCreator
; RVA 0x6867F38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006867F38  stp      x30, x21, [sp, #-0x20]!
006867F3C  stp      x20, x19, [sp, #0x10]
006867F40  adrp     x20, #0x959b000
006867F44  adrp     x21, #0x8f09000
006867F48  ldrb     w8, [x20, #0xa30]
006867F4C  ldr      x21, [x21, #0xc0]
006867F50  mov      x19, x0
006867F54  tbnz     w8, #0, #0x6867f6c
006867F58  adrp     x0, #0x8f09000
006867F5C  ldr      x0, [x0, #0xc0]
006867F60  bl       #0x382bd14 ; 
006867F64  mov      w8, #1
006867F68  strb     w8, [x20, #0xa30]
006867F6C  ldr      x1, [x21]
006867F70  ldrb     w8, [x1, #0x53]
006867F74  tbnz     w8, #5, #0x6867f88
006867F78  ldr      x0, [x19, #0x88]
006867F7C  ldp      x20, x19, [sp, #0x10]
006867F80  ldp      x30, x21, [sp], #0x20
006867F84  ret      
006867F88  ldr      x2, [x1, #0x60]
006867F8C  mov      x0, x19
006867F90  ldp      x20, x19, [sp, #0x10]
006867F94  ldp      x30, x21, [sp], #0x20
006867F98  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$get_BoxSkillResult
; RVA 0x6867F9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006867F9C  stp      x30, x21, [sp, #-0x20]!
006867FA0  stp      x20, x19, [sp, #0x10]
006867FA4  adrp     x20, #0x959b000
006867FA8  adrp     x21, #0x8f23000
006867FAC  ldrb     w8, [x20, #0xa31]
006867FB0  ldr      x21, [x21, #0xf28]
006867FB4  mov      x19, x0
006867FB8  tbnz     w8, #0, #0x6867fd0
006867FBC  adrp     x0, #0x8f23000
006867FC0  ldr      x0, [x0, #0xf28]
006867FC4  bl       #0x382bd14 ; 
006867FC8  mov      w8, #1
006867FCC  strb     w8, [x20, #0xa31]
006867FD0  ldr      x1, [x21]
006867FD4  ldrb     w8, [x1, #0x53]
006867FD8  tbnz     w8, #5, #0x6867fec
006867FDC  add      x0, x19, #0x60
006867FE0  ldp      x20, x19, [sp, #0x10]
006867FE4  ldp      x30, x21, [sp], #0x20
006867FE8  ret      
006867FEC  ldr      x2, [x1, #0x60]
006867FF0  mov      x0, x19
006867FF4  ldp      x20, x19, [sp, #0x10]
006867FF8  ldp      x30, x21, [sp], #0x20
006867FFC  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$get_AllSkills
; RVA 0x6868000; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006868000  stp      x30, x21, [sp, #-0x20]!
006868004  stp      x20, x19, [sp, #0x10]
006868008  adrp     x20, #0x959b000
00686800C  adrp     x21, #0x8f09000
006868010  ldrb     w8, [x20, #0xa32]
006868014  ldr      x21, [x21, #0xc8]
006868018  mov      x19, x0
00686801C  tbnz     w8, #0, #0x6868034
006868020  adrp     x0, #0x8f09000
006868024  ldr      x0, [x0, #0xc8]
006868028  bl       #0x382bd14 ; 
00686802C  mov      w8, #1
006868030  strb     w8, [x20, #0xa32]
006868034  ldr      x1, [x21]
006868038  ldrb     w8, [x1, #0x53]
00686803C  tbnz     w8, #5, #0x6868050
006868040  ldr      x0, [x19, #0x58]
006868044  ldp      x20, x19, [sp, #0x10]
006868048  ldp      x30, x21, [sp], #0x20
00686804C  ret      
006868050  ldr      x2, [x1, #0x60]
006868054  mov      x0, x19
006868058  ldp      x20, x19, [sp, #0x10]
00686805C  ldp      x30, x21, [sp], #0x20
006868060  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$get_MaxStarSkill
; RVA 0x6868064; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006868064  stp      x30, x21, [sp, #-0x20]!
006868068  stp      x20, x19, [sp, #0x10]
00686806C  adrp     x20, #0x959b000
006868070  adrp     x21, #0x8f23000
006868074  ldrb     w8, [x20, #0xa33]
006868078  ldr      x21, [x21, #0xf30]
00686807C  mov      x19, x0
006868080  tbnz     w8, #0, #0x6868098
006868084  adrp     x0, #0x8f23000
006868088  ldr      x0, [x0, #0xf30]
00686808C  bl       #0x382bd14 ; 
006868090  mov      w8, #1
006868094  strb     w8, [x20, #0xa33]
006868098  ldr      x1, [x21]
00686809C  ldrb     w8, [x1, #0x53]
0068680A0  tbnz     w8, #5, #0x68680b4
0068680A4  ldr      x0, [x19, #0x98]
0068680A8  ldp      x20, x19, [sp, #0x10]
0068680AC  ldp      x30, x21, [sp], #0x20
0068680B0  ret      
0068680B4  ldr      x2, [x1, #0x60]
0068680B8  mov      x0, x19
0068680BC  ldp      x20, x19, [sp, #0x10]
0068680C0  ldp      x30, x21, [sp], #0x20
0068680C4  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$set_MaxStarSkill
; RVA 0x68680C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068680C8  str      x30, [sp, #-0x30]!
0068680CC  stp      x22, x21, [sp, #0x10]
0068680D0  stp      x20, x19, [sp, #0x20]
0068680D4  adrp     x21, #0x959b000
0068680D8  adrp     x22, #0x8f23000
0068680DC  ldrb     w8, [x21, #0xa34]
0068680E0  ldr      x22, [x22, #0xf38]
0068680E4  mov      x19, x1
0068680E8  mov      x20, x0
0068680EC  tbnz     w8, #0, #0x6868104
0068680F0  adrp     x0, #0x8f23000
0068680F4  ldr      x0, [x0, #0xf38]
0068680F8  bl       #0x382bd14 ; 
0068680FC  mov      w8, #1
006868100  strb     w8, [x21, #0xa34]
006868104  ldr      x2, [x22]
006868108  ldrb     w8, [x2, #0x53]
00686810C  tbnz     w8, #5, #0x686812c
006868110  str      x19, [x20, #0x98]!
006868114  mov      x0, x20
006868118  mov      x1, x19
00686811C  ldp      x20, x19, [sp, #0x20]
006868120  ldp      x22, x21, [sp, #0x10]
006868124  ldr      x30, [sp], #0x30
006868128  b        #0x382bcb8 ; 
00686812C  ldr      x3, [x2, #0x60]
006868130  mov      x0, x20
006868134  mov      x1, x19
006868138  ldp      x20, x19, [sp, #0x20]
00686813C  ldp      x22, x21, [sp, #0x10]
006868140  ldr      x30, [sp], #0x30
006868144  br       x3

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetBoxSkillByIndex
; RVA 0x6868148; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006868148  str      x30, [sp, #-0x30]!
00686814C  stp      x22, x21, [sp, #0x10]
006868150  stp      x20, x19, [sp, #0x20]
006868154  adrp     x21, #0x959b000
006868158  adrp     x22, #0x8f23000
00686815C  ldrb     w8, [x21, #0xa35]
006868160  ldr      x22, [x22, #0xf40]
006868164  mov      w20, w1
006868168  mov      x19, x0
00686816C  tbnz     w8, #0, #0x6868184
006868170  adrp     x0, #0x8f23000
006868174  ldr      x0, [x0, #0xf40]
006868178  bl       #0x382bd14 ; 
00686817C  mov      w8, #1
006868180  strb     w8, [x21, #0xa35]
006868184  ldr      x2, [x22]
006868188  ldrb     w8, [x2, #0x53]
00686818C  tbnz     w8, #5, #0x686819c
006868190  cbz      w20, #0x68681b8
006868194  ldr      w0, [x19, #0x68]
006868198  b        #0x68681bc ; 
00686819C  ldr      x3, [x2, #0x60]
0068681A0  mov      x0, x19
0068681A4  mov      w1, w20
0068681A8  ldp      x20, x19, [sp, #0x20]
0068681AC  ldp      x22, x21, [sp, #0x10]
0068681B0  ldr      x30, [sp], #0x30
0068681B4  br       x3
0068681B8  ldr      w0, [x19, #0x64]
0068681BC  ldp      x20, x19, [sp, #0x20]
0068681C0  ldp      x22, x21, [sp, #0x10]
0068681C4  ldr      x30, [sp], #0x30
0068681C8  ret      

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddReplaceSkill
; RVA 0x68681CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068681CC  stp      x30, x23, [sp, #-0x30]!
0068681D0  stp      x22, x21, [sp, #0x10]
0068681D4  stp      x20, x19, [sp, #0x20]
0068681D8  adrp     x22, #0x959b000
0068681DC  adrp     x23, #0x8f23000
0068681E0  ldrb     w8, [x22, #0xa36]
0068681E4  ldr      x23, [x23, #0xf48]
0068681E8  mov      w19, w2
0068681EC  mov      w20, w1
0068681F0  mov      x21, x0
0068681F4  tbnz     w8, #0, #0x6868218
0068681F8  adrp     x0, #0x8ee3000
0068681FC  ldr      x0, [x0, #0xfa0]
006868200  bl       #0x382bd14 ; 
006868204  adrp     x0, #0x8f23000
006868208  ldr      x0, [x0, #0xf48]
00686820C  bl       #0x382bd14 ; 
006868210  mov      w8, #1
006868214  strb     w8, [x22, #0xa36]
006868218  ldr      x3, [x23]
00686821C  ldrb     w8, [x3, #0x53]
006868220  tbnz     w8, #5, #0x6868250
006868224  ldr      x0, [x21, #0x40]
006868228  cbz      x0, #0x6868270
00686822C  adrp     x8, #0x8ee3000
006868230  ldr      x8, [x8, #0xfa0]
006868234  mov      w1, w20
006868238  mov      w2, w19
00686823C  ldp      x20, x19, [sp, #0x20]
006868240  ldr      x3, [x8]
006868244  ldp      x22, x21, [sp, #0x10]
006868248  ldp      x30, x23, [sp], #0x30
00686824C  b        #0x5e2814c ; System.Collections.Generic.Dictionary<int, int>$$set_Item
006868250  ldr      x4, [x3, #0x60]
006868254  mov      x0, x21
006868258  mov      w1, w20
00686825C  mov      w2, w19
006868260  ldp      x20, x19, [sp, #0x20]
006868264  ldp      x22, x21, [sp, #0x10]
006868268  ldp      x30, x23, [sp], #0x30
00686826C  br       x4
006868270  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$OnAddSkill
; RVA 0x6868274; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006868274  stp      x30, x27, [sp, #-0x50]!
006868278  stp      x26, x25, [sp, #0x10]
00686827C  stp      x24, x23, [sp, #0x20]
006868280  stp      x22, x21, [sp, #0x30]
006868284  stp      x20, x19, [sp, #0x40]
006868288  adrp     x21, #0x959b000
00686828C  adrp     x22, #0x8f23000
006868290  ldrb     w8, [x21, #0xa37]
006868294  ldr      x22, [x22, #0xf50]
006868298  mov      w20, w1
00686829C  mov      x19, x0
0068682A0  tbnz     w8, #0, #0x68682d0
0068682A4  adrp     x0, #0x8f23000
0068682A8  ldr      x0, [x0, #0x140]
0068682AC  bl       #0x382bd14 ; 
0068682B0  adrp     x0, #0x8f23000
0068682B4  ldr      x0, [x0, #0xf50]
0068682B8  bl       #0x382bd14 ; 
0068682BC  adrp     x0, #0x8f23000
0068682C0  ldr      x0, [x0, #0xf58]
0068682C4  bl       #0x382bd14 ; 
0068682C8  mov      w8, #1
0068682CC  strb     w8, [x21, #0xa37]
0068682D0  ldr      x2, [x22]
0068682D4  ldrb     w8, [x2, #0x53]
0068682D8  tbnz     w8, #5, #0x6868318
0068682DC  adrp     x23, #0x9591000
0068682E0  ldrb     w8, [x23, #0xa4b]
0068682E4  cbnz     w8, #0x68682fc
0068682E8  adrp     x0, #0x8ee5000
0068682EC  ldr      x0, [x0, #0xb28]
0068682F0  bl       #0x382bd14 ; 
0068682F4  mov      w8, #1
0068682F8  strb     w8, [x23, #0xa4b]
0068682FC  adrp     x24, #0x8ee5000
006868300  ldr      x24, [x24, #0xb28]
006868304  ldr      x1, [x24]
006868308  ldrb     w8, [x1, #0x53]
00686830C  tbnz     w8, #5, #0x686833c
006868310  ldr      x21, [x19, #0x20]
006868314  b        #0x686834c ; 
006868318  ldr      x3, [x2, #0x60]
00686831C  mov      x0, x19
006868320  mov      w1, w20
006868324  ldp      x20, x19, [sp, #0x40]
006868328  ldp      x22, x21, [sp, #0x30]
00686832C  ldp      x24, x23, [sp, #0x20]
006868330  ldp      x26, x25, [sp, #0x10]
006868334  ldp      x30, x27, [sp], #0x50
006868338  br       x3
00686833C  ldr      x8, [x1, #0x60]
006868340  mov      x0, x19
006868344  blr      x8
006868348  mov      x21, x0
00686834C  cbz      x21, #0x6868728
006868350  adrp     x22, #0x9598000
006868354  ldrb     w8, [x22, #0xfcc]
006868358  cbnz     w8, #0x6868370
00686835C  adrp     x0, #0x8f06000
006868360  ldr      x0, [x0, #0x470]
006868364  bl       #0x382bd14 ; 
006868368  mov      w8, #1
00686836C  strb     w8, [x22, #0xfcc]
006868370  adrp     x8, #0x8f06000
006868374  ldr      x8, [x8, #0x470]
006868378  ldr      x1, [x8]
00686837C  ldrb     w8, [x1, #0x53]
006868380  tbnz     w8, #5, #0x686838c
006868384  ldr      x0, [x21, #0x200]
006868388  b        #0x6868398 ; 
00686838C  ldr      x8, [x1, #0x60]
006868390  mov      x0, x21
006868394  blr      x8
006868398  cbz      x0, #0x6868728
00686839C  mov      w1, w20
0068683A0  mov      x2, xzr
0068683A4  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0068683A8  cbz      x0, #0x6868728
0068683AC  adrp     x21, #0x9599000
0068683B0  ldrb     w8, [x21, #0x4dc]
0068683B4  mov      x20, x0
0068683B8  cbnz     w8, #0x68683d0
0068683BC  adrp     x0, #0x8f09000
0068683C0  ldr      x0, [x0, #0x8c0]
0068683C4  bl       #0x382bd14 ; 
0068683C8  mov      w8, #1
0068683CC  strb     w8, [x21, #0x4dc]
0068683D0  adrp     x8, #0x8f09000
0068683D4  ldr      x8, [x8, #0x8c0]
0068683D8  ldr      x1, [x8]
0068683DC  ldrb     w8, [x1, #0x53]
0068683E0  tbnz     w8, #5, #0x68683ec
0068683E4  ldr      w0, [x20, #0x24]
0068683E8  b        #0x68683f8 ; 
0068683EC  ldr      x8, [x1, #0x60]
0068683F0  mov      x0, x20
0068683F4  blr      x8
0068683F8  cmp      w0, #1
0068683FC  b.ne     #0x686860c
006868400  adrp     x22, #0x959b000
006868404  ldrb     w8, [x22, #0xba6]
006868408  cbnz     w8, #0x6868420
00686840C  adrp     x0, #0x8f23000
006868410  ldr      x0, [x0, #0xf30]
006868414  bl       #0x382bd14 ; 
006868418  mov      w8, #1
00686841C  strb     w8, [x22, #0xba6]
006868420  adrp     x26, #0x8f23000
006868424  ldr      x26, [x26, #0xf30]
006868428  ldr      x1, [x26]
00686842C  ldrb     w8, [x1, #0x53]
006868430  tbnz     w8, #5, #0x6868440
006868434  ldr      x0, [x19, #0x98]
006868438  cbnz     x0, #0x6868450
00686843C  b        #0x6868524 ; 
006868440  ldr      x8, [x1, #0x60]
006868444  mov      x0, x19
006868448  blr      x8
00686844C  cbz      x0, #0x6868524
006868450  adrp     x25, #0x9599000
006868454  ldrb     w8, [x25, #0xac8]
006868458  cbnz     w8, #0x6868470
00686845C  adrp     x0, #0x8f0d000
006868460  ldr      x0, [x0, #0x78]
006868464  bl       #0x382bd14 ; 
006868468  mov      w8, #1
00686846C  strb     w8, [x25, #0xac8]
006868470  adrp     x27, #0x8f0d000
006868474  ldr      x27, [x27, #0x78]
006868478  ldr      x1, [x27]
00686847C  ldrb     w8, [x1, #0x53]
006868480  tbnz     w8, #5, #0x686848c
006868484  ldr      w21, [x20, #0x58]
006868488  b        #0x686849c ; 
00686848C  ldr      x8, [x1, #0x60]
006868490  mov      x0, x20
006868494  blr      x8
006868498  mov      w21, w0
00686849C  ldrb     w8, [x22, #0xba6]
0068684A0  cbnz     w8, #0x68684b8
0068684A4  adrp     x0, #0x8f23000
0068684A8  ldr      x0, [x0, #0xf30]
0068684AC  bl       #0x382bd14 ; 
0068684B0  mov      w8, #1
0068684B4  strb     w8, [x22, #0xba6]
0068684B8  ldr      x1, [x26]
0068684BC  ldrb     w8, [x1, #0x53]
0068684C0  tbnz     w8, #5, #0x68684cc
0068684C4  ldr      x22, [x19, #0x98]
0068684C8  b        #0x68684dc ; 
0068684CC  ldr      x8, [x1, #0x60]
0068684D0  mov      x0, x19
0068684D4  blr      x8
0068684D8  mov      x22, x0
0068684DC  cbz      x22, #0x6868728
0068684E0  ldrb     w8, [x25, #0xac8]
0068684E4  cbnz     w8, #0x68684fc
0068684E8  adrp     x0, #0x8f0d000
0068684EC  ldr      x0, [x0, #0x78]
0068684F0  bl       #0x382bd14 ; 
0068684F4  mov      w8, #1
0068684F8  strb     w8, [x25, #0xac8]
0068684FC  ldr      x1, [x27]
006868500  ldrb     w8, [x1, #0x53]
006868504  tbnz     w8, #5, #0x6868510
006868508  ldr      w0, [x22, #0x58]
00686850C  b        #0x686851c ; 
006868510  ldr      x8, [x1, #0x60]
006868514  mov      x0, x22
006868518  blr      x8
00686851C  cmp      w21, w0
006868520  b.le     #0x686860c
006868524  adrp     x21, #0x959b000
006868528  ldrb     w8, [x21, #0xba7]
00686852C  cbnz     w8, #0x6868544
006868530  adrp     x0, #0x8f23000
006868534  ldr      x0, [x0, #0xf38]
006868538  bl       #0x382bd14 ; 
00686853C  mov      w8, #1
006868540  strb     w8, [x21, #0xba7]
006868544  adrp     x8, #0x8f23000
006868548  ldr      x8, [x8, #0xf38]
00686854C  ldr      x2, [x8]
006868550  ldrb     w8, [x2, #0x53]
006868554  tbnz     w8, #5, #0x686856c
006868558  mov      x0, x19
00686855C  str      x20, [x0, #0x98]!
006868560  mov      x1, x20
006868564  bl       #0x382bcb8 ; 
006868568  b        #0x686857c ; 
00686856C  ldr      x8, [x2, #0x60]
006868570  mov      x0, x19
006868574  mov      x1, x20
006868578  blr      x8
00686857C  adrp     x21, #0x8f23000
006868580  ldr      x21, [x21, #0x140]
006868584  ldr      x1, [x21]
006868588  ldrb     w8, [x1, #0x53]
00686858C  tbnz     w8, #5, #0x6868598
006868590  ldr      x20, [x19, #0x30]
006868594  b        #0x68685a8 ; 
006868598  ldr      x8, [x1, #0x60]
00686859C  mov      x0, x19
0068685A0  blr      x8
0068685A4  mov      x20, x0
0068685A8  cbz      x20, #0x6868728
0068685AC  adrp     x22, #0x9591000
0068685B0  ldrb     w8, [x22, #0xa86]
0068685B4  cbnz     w8, #0x68685d8
0068685B8  adrp     x0, #0x8ee6000
0068685BC  ldr      x0, [x0, #0x318]
0068685C0  bl       #0x382bd14 ; 
0068685C4  adrp     x0, #0x8ee3000
0068685C8  ldr      x0, [x0, #0xf18]
0068685CC  bl       #0x382bd14 ; 
0068685D0  mov      w8, #1
0068685D4  strb     w8, [x22, #0xa86]
0068685D8  adrp     x8, #0x8ee6000
0068685DC  ldr      x8, [x8, #0x318]
0068685E0  ldr      x2, [x8]
0068685E4  ldrb     w8, [x2, #0x53]
0068685E8  tbnz     w8, #5, #0x6868624
0068685EC  ldr      x0, [x20, #0x190]
0068685F0  cbz      x0, #0x686860c
0068685F4  adrp     x8, #0x8ee3000
0068685F8  ldr      x8, [x8, #0xf18]
0068685FC  mov      w1, #0x3f
006868600  ldr      x2, [x8]
006868604  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
006868608  tbnz     w0, #0, #0x6868638
00686860C  ldp      x20, x19, [sp, #0x40]
006868610  ldp      x22, x21, [sp, #0x30]
006868614  ldp      x24, x23, [sp, #0x20]
006868618  ldp      x26, x25, [sp, #0x10]
00686861C  ldp      x30, x27, [sp], #0x50
006868620  ret      
006868624  ldr      x8, [x2, #0x60]
006868628  mov      w1, #0x3f
00686862C  mov      x0, x20
006868630  blr      x8
006868634  tbz      w0, #0, #0x686860c
006868638  ldrb     w8, [x23, #0xa4b]
00686863C  cbnz     w8, #0x6868654
006868640  adrp     x0, #0x8ee5000
006868644  ldr      x0, [x0, #0xb28]
006868648  bl       #0x382bd14 ; 
00686864C  mov      w8, #1
006868650  strb     w8, [x23, #0xa4b]
006868654  ldr      x1, [x24]
006868658  ldrb     w8, [x1, #0x53]
00686865C  tbnz     w8, #5, #0x6868668
006868660  ldr      x20, [x19, #0x20]
006868664  b        #0x6868678 ; 
006868668  ldr      x8, [x1, #0x60]
00686866C  mov      x0, x19
006868670  blr      x8
006868674  mov      x20, x0
006868678  cbz      x20, #0x6868728
00686867C  adrp     x22, #0x9591000
006868680  ldrb     w8, [x22, #0xa4c]
006868684  cbnz     w8, #0x686869c
006868688  adrp     x0, #0x8ee5000
00686868C  ldr      x0, [x0, #0xb30]
006868690  bl       #0x382bd14 ; 
006868694  mov      w8, #1
006868698  strb     w8, [x22, #0xa4c]
00686869C  adrp     x8, #0x8ee5000
0068686A0  ldr      x8, [x8, #0xb30]
0068686A4  ldr      x1, [x8]
0068686A8  ldrb     w8, [x1, #0x53]
0068686AC  tbnz     w8, #5, #0x68686b8
0068686B0  ldr      x0, [x20, #0x210]
0068686B4  b        #0x68686c4 ; 
0068686B8  ldr      x8, [x1, #0x60]
0068686BC  mov      x0, x20
0068686C0  blr      x8
0068686C4  cbz      x0, #0x6868728
0068686C8  adrp     x8, #0x8f23000
0068686CC  ldr      x8, [x8, #0xf58]
0068686D0  ldr      x1, [x8]
0068686D4  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0068686D8  ldr      x1, [x21]
0068686DC  mov      x20, x0
0068686E0  ldrb     w8, [x1, #0x53]
0068686E4  tbnz     w8, #5, #0x68686f0
0068686E8  ldr      x0, [x19, #0x30]
0068686EC  b        #0x68686fc ; 
0068686F0  ldr      x8, [x1, #0x60]
0068686F4  mov      x0, x19
0068686F8  blr      x8
0068686FC  cbz      x0, #0x6868728
006868700  ldr      x0, [x0, #0x150]
006868704  cbz      x0, #0x6868728
006868708  mov      x1, x20
00686870C  ldp      x20, x19, [sp, #0x40]
006868710  ldp      x22, x21, [sp, #0x30]
006868714  ldp      x24, x23, [sp, #0x20]
006868718  ldp      x26, x25, [sp, #0x10]
00686871C  mov      x2, xzr
006868720  ldp      x30, x27, [sp], #0x50
006868724  b        #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
006868728  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$OnRemoveSkill
; RVA 0x686872C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686872C  sub      sp, sp, #0xa0
006868730  stp      x29, x30, [sp, #0x40]
006868734  stp      x28, x27, [sp, #0x50]
006868738  stp      x26, x25, [sp, #0x60]
00686873C  stp      x24, x23, [sp, #0x70]
006868740  stp      x22, x21, [sp, #0x80]
006868744  stp      x20, x19, [sp, #0x90]
006868748  adrp     x20, #0x959b000
00686874C  adrp     x21, #0x8f23000
006868750  ldrb     w8, [x20, #0xa38]
006868754  ldr      x21, [x21, #0xf60]
006868758  mov      w22, w1
00686875C  mov      x19, x0
006868760  tbnz     w8, #0, #0x68687c0
006868764  adrp     x0, #0x8f23000
006868768  ldr      x0, [x0, #0x140]
00686876C  bl       #0x382bd14 ; 
006868770  adrp     x0, #0x8ee5000
006868774  ldr      x0, [x0, #0x768]
006868778  bl       #0x382bd14 ; 
00686877C  adrp     x0, #0x8ee5000
006868780  ldr      x0, [x0, #0x770]
006868784  bl       #0x382bd14 ; 
006868788  adrp     x0, #0x8ee5000
00686878C  ldr      x0, [x0, #0x788]
006868790  bl       #0x382bd14 ; 
006868794  adrp     x0, #0x8f23000
006868798  ldr      x0, [x0, #0xf60]
00686879C  bl       #0x382bd14 ; 
0068687A0  adrp     x0, #0x8ee5000
0068687A4  ldr      x0, [x0, #0x7a0]
0068687A8  bl       #0x382bd14 ; 
0068687AC  adrp     x0, #0x8f23000
0068687B0  ldr      x0, [x0, #0xf58]
0068687B4  bl       #0x382bd14 ; 
0068687B8  mov      w8, #1
0068687BC  strb     w8, [x20, #0xa38]
0068687C0  ldr      x2, [x21]
0068687C4  ldrb     w8, [x2, #0x53]
0068687C8  tbnz     w8, #5, #0x6868814
0068687CC  adrp     x8, #0x9591000
0068687D0  ldrb     w8, [x8, #0xa4b]
0068687D4  stp      xzr, xzr, [sp, #0x20]
0068687D8  str      xzr, [sp, #0x30]
0068687DC  cbnz     w8, #0x68687f8
0068687E0  adrp     x0, #0x8ee5000
0068687E4  ldr      x0, [x0, #0xb28]
0068687E8  bl       #0x382bd14 ; 
0068687EC  mov      w8, #1
0068687F0  adrp     x9, #0x9591000
0068687F4  strb     w8, [x9, #0xa4b]
0068687F8  adrp     x8, #0x8ee5000
0068687FC  ldr      x8, [x8, #0xb28]
006868800  ldr      x1, [x8]
006868804  ldrb     w8, [x1, #0x53]
006868808  tbnz     w8, #5, #0x6868840
00686880C  ldr      x23, [x19, #0x20]
006868810  b        #0x6868850 ; 
006868814  ldr      x3, [x2, #0x60]
006868818  mov      x0, x19
00686881C  mov      w1, w22
006868820  ldp      x20, x19, [sp, #0x90]
006868824  ldp      x22, x21, [sp, #0x80]
006868828  ldp      x24, x23, [sp, #0x70]
00686882C  ldp      x26, x25, [sp, #0x60]
006868830  ldp      x28, x27, [sp, #0x50]
006868834  ldp      x29, x30, [sp, #0x40]
006868838  add      sp, sp, #0xa0
00686883C  br       x3
006868840  ldr      x8, [x1, #0x60]
006868844  mov      x0, x19
006868848  blr      x8
00686884C  mov      x23, x0
006868850  cbz      x23, #0x6868f68
006868854  adrp     x20, #0x9598000
006868858  ldrb     w8, [x20, #0xfcc]
00686885C  cbnz     w8, #0x6868874
006868860  adrp     x0, #0x8f06000
006868864  ldr      x0, [x0, #0x470]
006868868  bl       #0x382bd14 ; 
00686886C  mov      w8, #1
006868870  strb     w8, [x20, #0xfcc]
006868874  adrp     x21, #0x8f06000
006868878  ldr      x21, [x21, #0x470]
00686887C  ldr      x1, [x21]
006868880  ldrb     w8, [x1, #0x53]
006868884  tbnz     w8, #5, #0x6868890
006868888  ldr      x0, [x23, #0x200]
00686888C  b        #0x686889c ; 
006868890  ldr      x8, [x1, #0x60]
006868894  mov      x0, x23
006868898  blr      x8
00686889C  cbz      x0, #0x6868f68
0068688A0  mov      w1, w22
0068688A4  mov      x2, xzr
0068688A8  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0068688AC  cbz      x0, #0x6868f68
0068688B0  adrp     x23, #0x9599000
0068688B4  ldrb     w8, [x23, #0x4dc]
0068688B8  mov      x24, x0
0068688BC  cbnz     w8, #0x68688d4
0068688C0  adrp     x0, #0x8f09000
0068688C4  ldr      x0, [x0, #0x8c0]
0068688C8  bl       #0x382bd14 ; 
0068688CC  mov      w8, #1
0068688D0  strb     w8, [x23, #0x4dc]
0068688D4  adrp     x22, #0x8f09000
0068688D8  ldr      x22, [x22, #0x8c0]
0068688DC  ldr      x1, [x22]
0068688E0  ldrb     w8, [x1, #0x53]
0068688E4  tbnz     w8, #5, #0x68688f0
0068688E8  ldr      w0, [x24, #0x24]
0068688EC  b        #0x68688fc ; 
0068688F0  ldr      x8, [x1, #0x60]
0068688F4  mov      x0, x24
0068688F8  blr      x8
0068688FC  cmp      w0, #1
006868900  b.ne     #0x6868f3c
006868904  adrp     x8, #0x959b000
006868908  ldrb     w8, [x8, #0xba6]
00686890C  cbnz     w8, #0x6868928
006868910  adrp     x0, #0x8f23000
006868914  ldr      x0, [x0, #0xf30]
006868918  bl       #0x382bd14 ; 
00686891C  mov      w8, #1
006868920  adrp     x9, #0x959b000
006868924  strb     w8, [x9, #0xba6]
006868928  adrp     x8, #0x8f23000
00686892C  ldr      x8, [x8, #0xf30]
006868930  ldr      x1, [x8]
006868934  ldrb     w8, [x1, #0x53]
006868938  tbnz     w8, #5, #0x6868948
00686893C  ldr      x0, [x19, #0x98]
006868940  cbnz     x0, #0x6868958
006868944  b        #0x6868f3c ; 
006868948  ldr      x8, [x1, #0x60]
00686894C  mov      x0, x19
006868950  blr      x8
006868954  cbz      x0, #0x6868f3c
006868958  adrp     x26, #0x9598000
00686895C  ldrb     w8, [x26, #0xde3]
006868960  cbnz     w8, #0x6868978
006868964  adrp     x0, #0x8f00000
006868968  ldr      x0, [x0, #0xd98]
00686896C  bl       #0x382bd14 ; 
006868970  mov      w8, #1
006868974  strb     w8, [x26, #0xde3]
006868978  adrp     x27, #0x8f00000
00686897C  ldr      x27, [x27, #0xd98]
006868980  ldr      x1, [x27]
006868984  ldrb     w8, [x1, #0x53]
006868988  tbnz     w8, #5, #0x6868994
00686898C  ldr      w24, [x24, #0x20]
006868990  b        #0x68689a4 ; 
006868994  ldr      x8, [x1, #0x60]
006868998  mov      x0, x24
00686899C  blr      x8
0068689A0  mov      w24, w0
0068689A4  adrp     x8, #0x959b000
0068689A8  ldrb     w8, [x8, #0xba6]
0068689AC  cbnz     w8, #0x68689c8
0068689B0  adrp     x0, #0x8f23000
0068689B4  ldr      x0, [x0, #0xf30]
0068689B8  bl       #0x382bd14 ; 
0068689BC  mov      w8, #1
0068689C0  adrp     x9, #0x959b000
0068689C4  strb     w8, [x9, #0xba6]
0068689C8  adrp     x8, #0x8f23000
0068689CC  ldr      x8, [x8, #0xf30]
0068689D0  ldr      x1, [x8]
0068689D4  ldrb     w8, [x1, #0x53]
0068689D8  tbnz     w8, #5, #0x68689e4
0068689DC  ldr      x25, [x19, #0x98]
0068689E0  b        #0x68689f4 ; 
0068689E4  ldr      x8, [x1, #0x60]
0068689E8  mov      x0, x19
0068689EC  blr      x8
0068689F0  mov      x25, x0
0068689F4  cbz      x25, #0x6868f68
0068689F8  ldrb     w8, [x26, #0xde3]
0068689FC  cbnz     w8, #0x6868a14
006868A00  adrp     x0, #0x8f00000
006868A04  ldr      x0, [x0, #0xd98]
006868A08  bl       #0x382bd14 ; 
006868A0C  mov      w8, #1
006868A10  strb     w8, [x26, #0xde3]
006868A14  ldr      x1, [x27]
006868A18  ldrb     w8, [x1, #0x53]
006868A1C  tbnz     w8, #5, #0x6868a28
006868A20  ldr      w0, [x25, #0x20]
006868A24  b        #0x6868a34 ; 
006868A28  ldr      x8, [x1, #0x60]
006868A2C  mov      x0, x25
006868A30  blr      x8
006868A34  cmp      w24, w0
006868A38  b.ne     #0x6868f3c
006868A3C  adrp     x8, #0x959b000
006868A40  ldrb     w8, [x8, #0xba7]
006868A44  cbnz     w8, #0x6868a60
006868A48  adrp     x0, #0x8f23000
006868A4C  ldr      x0, [x0, #0xf38]
006868A50  bl       #0x382bd14 ; 
006868A54  mov      w8, #1
006868A58  adrp     x9, #0x959b000
006868A5C  strb     w8, [x9, #0xba7]
006868A60  adrp     x8, #0x8f23000
006868A64  ldr      x8, [x8, #0xf38]
006868A68  ldr      x2, [x8]
006868A6C  ldrb     w8, [x2, #0x53]
006868A70  tbnz     w8, #5, #0x6868a88
006868A74  mov      x0, x19
006868A78  str      xzr, [x0, #0x98]!
006868A7C  mov      x1, xzr
006868A80  bl       #0x382bcb8 ; 
006868A84  b        #0x6868a98 ; 
006868A88  ldr      x8, [x2, #0x60]
006868A8C  mov      x0, x19
006868A90  mov      x1, xzr
006868A94  blr      x8
006868A98  adrp     x24, #0x9599000
006868A9C  ldrb     w8, [x24, #0x4c7]
006868AA0  cbnz     w8, #0x6868ab8
006868AA4  adrp     x0, #0x8f09000
006868AA8  ldr      x0, [x0, #0xc8]
006868AAC  bl       #0x382bd14 ; 
006868AB0  mov      w8, #1
006868AB4  strb     w8, [x24, #0x4c7]
006868AB8  adrp     x8, #0x8f09000
006868ABC  ldr      x8, [x8, #0xc8]
006868AC0  ldr      x1, [x8]
006868AC4  ldrb     w8, [x1, #0x53]
006868AC8  tbnz     w8, #5, #0x6868ad4
006868ACC  ldr      x0, [x19, #0x58]
006868AD0  b        #0x6868ae0 ; 
006868AD4  ldr      x8, [x1, #0x60]
006868AD8  mov      x0, x19
006868ADC  blr      x8
006868AE0  cbz      x0, #0x6868f68
006868AE4  adrp     x8, #0x8ee5000
006868AE8  ldr      x8, [x8, #0x7a0]
006868AEC  ldr      x1, [x8]
006868AF0  add      x8, sp, #8
006868AF4  bl       #0x4d65168 ; System.Collections.Generic.List<int>$$GetEnumerator
006868AF8  ldur     q0, [sp, #8]
006868AFC  ldr      x8, [sp, #0x18]
006868B00  adrp     x24, #0x8ee5000
006868B04  ldr      x24, [x24, #0x770]
006868B08  add      x25, x19, #0x98
006868B0C  mov      w26, #1
006868B10  str      q0, [sp, #0x20]
006868B14  str      x8, [sp, #0x30]
006868B18  ldr      x1, [x24]
006868B1C  add      x0, sp, #0x20
006868B20  bl       #0x60e2380 ; System.Collections.Generic.List.Enumerator<int>$$MoveNext
006868B24  tbz      w0, #0, #0x6868d98
006868B28  adrp     x8, #0x9591000
006868B2C  ldrb     w8, [x8, #0xa4b]
006868B30  ldr      w27, [sp, #0x30]
006868B34  cbnz     w8, #0x6868b4c
006868B38  adrp     x0, #0x8ee5000
006868B3C  ldr      x0, [x0, #0xb28]
006868B40  bl       #0x382bd14 ; 
006868B44  adrp     x8, #0x9591000
006868B48  strb     w26, [x8, #0xa4b]
006868B4C  adrp     x8, #0x8ee5000
006868B50  ldr      x8, [x8, #0xb28]
006868B54  ldr      x1, [x8]
006868B58  ldrb     w8, [x1, #0x53]
006868B5C  tbnz     w8, #5, #0x6868b68
006868B60  ldr      x28, [x19, #0x20]
006868B64  b        #0x6868b78 ; 
006868B68  ldr      x8, [x1, #0x60]
006868B6C  mov      x0, x19
006868B70  blr      x8
006868B74  mov      x28, x0
006868B78  cbz      x28, #0x6868f60
006868B7C  ldrb     w8, [x20, #0xfcc]
006868B80  cbnz     w8, #0x6868b90
006868B84  mov      x0, x21
006868B88  bl       #0x382bd14 ; 
006868B8C  strb     w26, [x20, #0xfcc]
006868B90  ldr      x1, [x21]
006868B94  ldrb     w8, [x1, #0x53]
006868B98  tbnz     w8, #5, #0x6868ba4
006868B9C  ldr      x0, [x28, #0x200]
006868BA0  b        #0x6868bb0 ; 
006868BA4  ldr      x8, [x1, #0x60]
006868BA8  mov      x0, x28
006868BAC  blr      x8
006868BB0  cbz      x0, #0x6868f64
006868BB4  mov      w1, w27
006868BB8  mov      x2, xzr
006868BBC  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006868BC0  mov      x27, x0
006868BC4  cbz      x0, #0x6868f5c
006868BC8  ldrb     w8, [x23, #0x4dc]
006868BCC  cbnz     w8, #0x6868bdc
006868BD0  mov      x0, x22
006868BD4  bl       #0x382bd14 ; 
006868BD8  strb     w26, [x23, #0x4dc]
006868BDC  ldr      x1, [x22]
006868BE0  ldrb     w8, [x1, #0x53]
006868BE4  tbnz     w8, #5, #0x6868bf0
006868BE8  ldr      w0, [x27, #0x24]
006868BEC  b        #0x6868bfc ; 
006868BF0  ldr      x8, [x1, #0x60]
006868BF4  mov      x0, x27
006868BF8  blr      x8
006868BFC  cmp      w0, #1
006868C00  b.ne     #0x6868b18
006868C04  adrp     x8, #0x959b000
006868C08  ldrb     w8, [x8, #0xba6]
006868C0C  cbnz     w8, #0x6868c24
006868C10  adrp     x0, #0x8f23000
006868C14  ldr      x0, [x0, #0xf30]
006868C18  bl       #0x382bd14 ; 
006868C1C  adrp     x8, #0x959b000
006868C20  strb     w26, [x8, #0xba6]
006868C24  adrp     x8, #0x8f23000
006868C28  ldr      x8, [x8, #0xf30]
006868C2C  ldr      x1, [x8]
006868C30  ldrb     w8, [x1, #0x53]
006868C34  tbnz     w8, #5, #0x6868c40
006868C38  ldr      x0, [x25]
006868C3C  b        #0x6868c4c ; 
006868C40  ldr      x8, [x1, #0x60]
006868C44  mov      x0, x19
006868C48  blr      x8
006868C4C  cbz      x0, #0x6868d3c
006868C50  adrp     x8, #0x9599000
006868C54  ldrb     w8, [x8, #0xac8]
006868C58  cbnz     w8, #0x6868c70
006868C5C  adrp     x0, #0x8f0d000
006868C60  ldr      x0, [x0, #0x78]
006868C64  bl       #0x382bd14 ; 
006868C68  adrp     x8, #0x9599000
006868C6C  strb     w26, [x8, #0xac8]
006868C70  adrp     x8, #0x8f0d000
006868C74  ldr      x8, [x8, #0x78]
006868C78  ldr      x1, [x8]
006868C7C  ldrb     w8, [x1, #0x53]
006868C80  tbnz     w8, #5, #0x6868c8c
006868C84  ldr      w28, [x27, #0x58]
006868C88  b        #0x6868c9c ; 
006868C8C  ldr      x8, [x1, #0x60]
006868C90  mov      x0, x27
006868C94  blr      x8
006868C98  mov      w28, w0
006868C9C  adrp     x8, #0x959b000
006868CA0  ldrb     w8, [x8, #0xba6]
006868CA4  cbnz     w8, #0x6868cbc
006868CA8  adrp     x0, #0x8f23000
006868CAC  ldr      x0, [x0, #0xf30]
006868CB0  bl       #0x382bd14 ; 
006868CB4  adrp     x8, #0x959b000
006868CB8  strb     w26, [x8, #0xba6]
006868CBC  adrp     x8, #0x8f23000
006868CC0  ldr      x8, [x8, #0xf30]
006868CC4  ldr      x1, [x8]
006868CC8  ldrb     w8, [x1, #0x53]
006868CCC  tbnz     w8, #5, #0x6868cd8
006868CD0  ldr      x29, [x25]
006868CD4  b        #0x6868ce8 ; 
006868CD8  ldr      x8, [x1, #0x60]
006868CDC  mov      x0, x19
006868CE0  blr      x8
006868CE4  mov      x29, x0
006868CE8  cbz      x29, #0x6868f6c
006868CEC  adrp     x8, #0x9599000
006868CF0  ldrb     w8, [x8, #0xac8]
006868CF4  cbnz     w8, #0x6868d0c
006868CF8  adrp     x0, #0x8f0d000
006868CFC  ldr      x0, [x0, #0x78]
006868D00  bl       #0x382bd14 ; 
006868D04  adrp     x8, #0x9599000
006868D08  strb     w26, [x8, #0xac8]
006868D0C  adrp     x8, #0x8f0d000
006868D10  ldr      x8, [x8, #0x78]
006868D14  ldr      x1, [x8]
006868D18  ldrb     w8, [x1, #0x53]
006868D1C  tbnz     w8, #5, #0x6868d28
006868D20  ldr      w0, [x29, #0x58]
006868D24  b        #0x6868d34 ; 
006868D28  ldr      x8, [x1, #0x60]
006868D2C  mov      x0, x29
006868D30  blr      x8
006868D34  cmp      w28, w0
006868D38  b.le     #0x6868b18
006868D3C  adrp     x8, #0x959b000
006868D40  ldrb     w8, [x8, #0xba7]
006868D44  cbnz     w8, #0x6868d5c
006868D48  adrp     x0, #0x8f23000
006868D4C  ldr      x0, [x0, #0xf38]
006868D50  bl       #0x382bd14 ; 
006868D54  adrp     x8, #0x959b000
006868D58  strb     w26, [x8, #0xba7]
006868D5C  adrp     x8, #0x8f23000
006868D60  ldr      x8, [x8, #0xf38]
006868D64  ldr      x2, [x8]
006868D68  ldrb     w8, [x2, #0x53]
006868D6C  tbnz     w8, #5, #0x6868d84
006868D70  str      x27, [x25]
006868D74  mov      x0, x25
006868D78  mov      x1, x27
006868D7C  bl       #0x382bcb8 ; 
006868D80  b        #0x6868b18 ; 
006868D84  ldr      x8, [x2, #0x60]
006868D88  mov      x0, x19
006868D8C  mov      x1, x27
006868D90  blr      x8
006868D94  b        #0x6868b18 ; 
006868D98  adrp     x8, #0x8ee5000
006868D9C  ldr      x8, [x8, #0x768]
006868DA0  add      x0, sp, #0x20
006868DA4  ldr      x1, [x8]
006868DA8  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
006868DAC  adrp     x22, #0x8f23000
006868DB0  ldr      x22, [x22, #0x140]
006868DB4  ldr      x1, [x22]
006868DB8  ldrb     w8, [x1, #0x53]
006868DBC  tbnz     w8, #5, #0x6868dc8
006868DC0  ldr      x21, [x19, #0x30]
006868DC4  b        #0x6868dd8 ; 
006868DC8  ldr      x8, [x1, #0x60]
006868DCC  mov      x0, x19
006868DD0  blr      x8
006868DD4  mov      x21, x0
006868DD8  cbz      x21, #0x6868f68
006868DDC  adrp     x20, #0x9591000
006868DE0  ldrb     w8, [x20, #0xa86]
006868DE4  cbnz     w8, #0x6868e08
006868DE8  adrp     x0, #0x8ee6000
006868DEC  ldr      x0, [x0, #0x318]
006868DF0  bl       #0x382bd14 ; 
006868DF4  adrp     x0, #0x8ee3000
006868DF8  ldr      x0, [x0, #0xf18]
006868DFC  bl       #0x382bd14 ; 
006868E00  mov      w8, #1
006868E04  strb     w8, [x20, #0xa86]
006868E08  adrp     x8, #0x8ee6000
006868E0C  ldr      x8, [x8, #0x318]
006868E10  ldr      x2, [x8]
006868E14  ldrb     w8, [x2, #0x53]
006868E18  tbnz     w8, #5, #0x6868e40
006868E1C  ldr      x0, [x21, #0x190]
006868E20  cbz      x0, #0x6868f3c
006868E24  adrp     x8, #0x8ee3000
006868E28  ldr      x8, [x8, #0xf18]
006868E2C  mov      w1, #0x3f
006868E30  ldr      x2, [x8]
006868E34  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
006868E38  tbnz     w0, #0, #0x6868e54
006868E3C  b        #0x6868f3c ; 
006868E40  ldr      x8, [x2, #0x60]
006868E44  mov      w1, #0x3f
006868E48  mov      x0, x21
006868E4C  blr      x8
006868E50  tbz      w0, #0, #0x6868f3c
006868E54  adrp     x20, #0x9591000
006868E58  ldrb     w8, [x20, #0xa4b]
006868E5C  cbnz     w8, #0x6868e74
006868E60  adrp     x0, #0x8ee5000
006868E64  ldr      x0, [x0, #0xb28]
006868E68  bl       #0x382bd14 ; 
006868E6C  mov      w8, #1
006868E70  strb     w8, [x20, #0xa4b]
006868E74  adrp     x8, #0x8ee5000
006868E78  ldr      x8, [x8, #0xb28]
006868E7C  ldr      x1, [x8]
006868E80  ldrb     w8, [x1, #0x53]
006868E84  tbnz     w8, #5, #0x6868e90
006868E88  ldr      x20, [x19, #0x20]
006868E8C  b        #0x6868ea0 ; 
006868E90  ldr      x8, [x1, #0x60]
006868E94  mov      x0, x19
006868E98  blr      x8
006868E9C  mov      x20, x0
006868EA0  cbz      x20, #0x6868f68
006868EA4  adrp     x21, #0x9591000
006868EA8  ldrb     w8, [x21, #0xa4c]
006868EAC  cbnz     w8, #0x6868ec4
006868EB0  adrp     x0, #0x8ee5000
006868EB4  ldr      x0, [x0, #0xb30]
006868EB8  bl       #0x382bd14 ; 
006868EBC  mov      w8, #1
006868EC0  strb     w8, [x21, #0xa4c]
006868EC4  adrp     x8, #0x8ee5000
006868EC8  ldr      x8, [x8, #0xb30]
006868ECC  ldr      x1, [x8]
006868ED0  ldrb     w8, [x1, #0x53]
006868ED4  tbnz     w8, #5, #0x6868ee0
006868ED8  ldr      x0, [x20, #0x210]
006868EDC  b        #0x6868eec ; 
006868EE0  ldr      x8, [x1, #0x60]
006868EE4  mov      x0, x20
006868EE8  blr      x8
006868EEC  cbz      x0, #0x6868f68
006868EF0  adrp     x8, #0x8f23000
006868EF4  ldr      x8, [x8, #0xf58]
006868EF8  ldr      x1, [x8]
006868EFC  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
006868F00  ldr      x1, [x22]
006868F04  mov      x20, x0
006868F08  ldrb     w8, [x1, #0x53]
006868F0C  tbnz     w8, #5, #0x6868f18
006868F10  ldr      x0, [x19, #0x30]
006868F14  b        #0x6868f24 ; 
006868F18  ldr      x8, [x1, #0x60]
006868F1C  mov      x0, x19
006868F20  blr      x8
006868F24  cbz      x0, #0x6868f68
006868F28  ldr      x0, [x0, #0x150]
006868F2C  cbz      x0, #0x6868f68
006868F30  mov      x1, x20
006868F34  mov      x2, xzr
006868F38  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
006868F3C  ldp      x20, x19, [sp, #0x90]
006868F40  ldp      x22, x21, [sp, #0x80]
006868F44  ldp      x24, x23, [sp, #0x70]
006868F48  ldp      x26, x25, [sp, #0x60]
006868F4C  ldp      x28, x27, [sp, #0x50]
006868F50  ldp      x29, x30, [sp, #0x40]
006868F54  add      sp, sp, #0xa0
006868F58  ret      
006868F5C  bl       #0x382bfb8 ; 
006868F60  bl       #0x382bfb8 ; 
006868F64  bl       #0x382bfb8 ; 
006868F68  bl       #0x382bfb8 ; 
006868F6C  bl       #0x382bfb8 ; 
006868F70  b        #0x6868fa4 ; 
006868F74  b        #0x6868fa4 ; 
006868F78  b        #0x6868fa4 ; 
006868F7C  b        #0x6868fa4 ; 
006868F80  b        #0x6868fa4 ; 
006868F84  b        #0x6868fa4 ; 
006868F88  b        #0x6868fa4 ; 
006868F8C  b        #0x6868fa4 ; 
006868F90  b        #0x6868fa4 ; 
006868F94  b        #0x6868fa4 ; 
006868F98  b        #0x6868fa4 ; 
006868F9C  b        #0x6868fa4 ; 
006868FA0  b        #0x6868fa4 ; 
006868FA4  mov      x21, x0
006868FA8  cmp      w1, #1
006868FAC  b.ne     #0x6868fe0
006868FB0  mov      x0, x21
006868FB4  bl       #0x89eda50 ; 
006868FB8  ldr      x22, [x0]
006868FBC  bl       #0x89eda60 ; 
006868FC0  adrp     x8, #0x8ee5000
006868FC4  ldr      x8, [x8, #0x768]
006868FC8  add      x0, sp, #0x20
006868FCC  ldr      x1, [x8]
006868FD0  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
006868FD4  cbz      x22, #0x6868dac
006868FD8  mov      x0, x22
006868FDC  bl       #0x382bfb0 ; 
006868FE0  mov      x22, xzr
006868FE4  b        #0x6868fec ; 
006868FE8  mov      x21, x0
006868FEC  adrp     x8, #0x8ee5000
006868FF0  ldr      x8, [x8, #0x768]
006868FF4  ldr      x1, [x8]
006868FF8  add      x0, sp, #0x20
006868FFC  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
006869000  cbnz     x22, #0x686900c
006869004  mov      x0, x21
006869008  bl       #0x3b56bfc ; 
00686900C  mov      x0, x22
006869010  bl       #0x382bfb0 ; 
006869014  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkill
; RVA 0x6869018; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869018  str      x30, [sp, #-0x30]!
00686901C  stp      x22, x21, [sp, #0x10]
006869020  stp      x20, x19, [sp, #0x20]
006869024  adrp     x21, #0x959b000
006869028  adrp     x22, #0x8f23000
00686902C  ldrb     w8, [x21, #0xa39]
006869030  ldr      x22, [x22, #0xf68]
006869034  mov      w19, w1
006869038  mov      x20, x0
00686903C  tbnz     w8, #0, #0x6869060
006869040  adrp     x0, #0x8f23000
006869044  ldr      x0, [x0, #0xf68]
006869048  bl       #0x382bd14 ; 
00686904C  adrp     x0, #0x8ec2000
006869050  ldr      x0, [x0, #0x260]
006869054  bl       #0x382bd14 ; 
006869058  mov      w8, #1
00686905C  strb     w8, [x21, #0xa39]
006869060  ldr      x2, [x22]
006869064  ldrb     w8, [x2, #0x53]
006869068  tbnz     w8, #5, #0x68690b8
00686906C  ldr      x0, [x20, #0x58]
006869070  cbz      x0, #0x6869100
006869074  adrp     x9, #0x8ec2000
006869078  ldr      x9, [x9, #0x260]
00686907C  ldr      w10, [x0, #0x1c]
006869080  ldr      x8, [x0, #0x10]
006869084  ldr      x9, [x9]
006869088  add      w10, w10, #1
00686908C  str      w10, [x0, #0x1c]
006869090  cbz      x8, #0x6869100
006869094  ldrsw    x10, [x0, #0x18]
006869098  ldr      w11, [x8, #0x18]
00686909C  cmp      w10, w11
0068690A0  b.hs     #0x68690d4
0068690A4  add      w9, w10, #1
0068690A8  add      x8, x8, x10, lsl #2
0068690AC  str      w9, [x0, #0x18]
0068690B0  str      w19, [x8, #0x20]
0068690B4  b        #0x68690e8 ; 
0068690B8  ldr      x3, [x2, #0x60]
0068690BC  mov      x0, x20
0068690C0  mov      w1, w19
0068690C4  ldp      x20, x19, [sp, #0x20]
0068690C8  ldp      x22, x21, [sp, #0x10]
0068690CC  ldr      x30, [sp], #0x30
0068690D0  br       x3
0068690D4  ldr      x8, [x9, #0x20]
0068690D8  mov      w1, w19
0068690DC  ldr      x8, [x8, #0xc0]
0068690E0  ldr      x2, [x8, #0x70]
0068690E4  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0068690E8  mov      x0, x20
0068690EC  mov      w1, w19
0068690F0  ldp      x20, x19, [sp, #0x20]
0068690F4  ldp      x22, x21, [sp, #0x10]
0068690F8  ldr      x30, [sp], #0x30
0068690FC  b        #0x6868274 ; HotFix.BattleLogic.HeroComponentRandomSkill$$OnAddSkill
006869100  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillSurvior
; RVA 0x6869104; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869104  str      x30, [sp, #-0x30]!
006869108  stp      x22, x21, [sp, #0x10]
00686910C  stp      x20, x19, [sp, #0x20]
006869110  adrp     x21, #0x959b000
006869114  adrp     x22, #0x8f23000
006869118  ldrb     w8, [x21, #0xa3a]
00686911C  ldr      x22, [x22, #0xf70]
006869120  mov      w19, w1
006869124  mov      x20, x0
006869128  tbnz     w8, #0, #0x686914c
00686912C  adrp     x0, #0x8f23000
006869130  ldr      x0, [x0, #0xf70]
006869134  bl       #0x382bd14 ; 
006869138  adrp     x0, #0x8ec2000
00686913C  ldr      x0, [x0, #0x260]
006869140  bl       #0x382bd14 ; 
006869144  mov      w8, #1
006869148  strb     w8, [x21, #0xa3a]
00686914C  ldr      x2, [x22]
006869150  ldrb     w8, [x2, #0x53]
006869154  tbnz     w8, #5, #0x68691a4
006869158  ldr      x0, [x20, #0x58]
00686915C  cbz      x0, #0x68691ec
006869160  adrp     x9, #0x8ec2000
006869164  ldr      x9, [x9, #0x260]
006869168  ldr      w10, [x0, #0x1c]
00686916C  ldr      x8, [x0, #0x10]
006869170  ldr      x9, [x9]
006869174  add      w10, w10, #1
006869178  str      w10, [x0, #0x1c]
00686917C  cbz      x8, #0x68691ec
006869180  ldrsw    x10, [x0, #0x18]
006869184  ldr      w11, [x8, #0x18]
006869188  cmp      w10, w11
00686918C  b.hs     #0x68691c0
006869190  add      w9, w10, #1
006869194  add      x8, x8, x10, lsl #2
006869198  str      w9, [x0, #0x18]
00686919C  str      w19, [x8, #0x20]
0068691A0  b        #0x68691d4 ; 
0068691A4  ldr      x3, [x2, #0x60]
0068691A8  mov      x0, x20
0068691AC  mov      w1, w19
0068691B0  ldp      x20, x19, [sp, #0x20]
0068691B4  ldp      x22, x21, [sp, #0x10]
0068691B8  ldr      x30, [sp], #0x30
0068691BC  br       x3
0068691C0  ldr      x8, [x9, #0x20]
0068691C4  mov      w1, w19
0068691C8  ldr      x8, [x8, #0xc0]
0068691CC  ldr      x2, [x8, #0x70]
0068691D0  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0068691D4  mov      x0, x20
0068691D8  mov      w1, w19
0068691DC  ldp      x20, x19, [sp, #0x20]
0068691E0  ldp      x22, x21, [sp, #0x10]
0068691E4  ldr      x30, [sp], #0x30
0068691E8  b        #0x6868274 ; HotFix.BattleLogic.HeroComponentRandomSkill$$OnAddSkill
0068691EC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveSkillInSTG
; RVA 0x68691F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068691F0  str      x30, [sp, #-0x30]!
0068691F4  stp      x22, x21, [sp, #0x10]
0068691F8  stp      x20, x19, [sp, #0x20]
0068691FC  adrp     x21, #0x959b000
006869200  adrp     x22, #0x8f23000
006869204  ldrb     w8, [x21, #0xa3b]
006869208  ldr      x22, [x22, #0xf78]
00686920C  mov      w19, w1
006869210  mov      x20, x0
006869214  tbnz     w8, #0, #0x6869238
006869218  adrp     x0, #0x8f23000
00686921C  ldr      x0, [x0, #0xf78]
006869220  bl       #0x382bd14 ; 
006869224  adrp     x0, #0x8edb000
006869228  ldr      x0, [x0, #0x180]
00686922C  bl       #0x382bd14 ; 
006869230  mov      w8, #1
006869234  strb     w8, [x21, #0xa3b]
006869238  ldr      x2, [x22]
00686923C  ldrb     w8, [x2, #0x53]
006869240  tbnz     w8, #5, #0x6869278
006869244  ldr      x0, [x20, #0x58]
006869248  cbz      x0, #0x6869294
00686924C  adrp     x8, #0x8edb000
006869250  ldr      x8, [x8, #0x180]
006869254  mov      w1, w19
006869258  ldr      x2, [x8]
00686925C  bl       #0x4d65db8 ; System.Collections.Generic.List<int>$$Remove
006869260  mov      x0, x20
006869264  mov      w1, w19
006869268  ldp      x20, x19, [sp, #0x20]
00686926C  ldp      x22, x21, [sp, #0x10]
006869270  ldr      x30, [sp], #0x30
006869274  b        #0x686872c ; HotFix.BattleLogic.HeroComponentRandomSkill$$OnRemoveSkill
006869278  ldr      x3, [x2, #0x60]
00686927C  mov      x0, x20
006869280  mov      w1, w19
006869284  ldp      x20, x19, [sp, #0x20]
006869288  ldp      x22, x21, [sp, #0x10]
00686928C  ldr      x30, [sp], #0x30
006869290  br       x3
006869294  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveSkillInSurvior
; RVA 0x6869298; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869298  str      x30, [sp, #-0x30]!
00686929C  stp      x22, x21, [sp, #0x10]
0068692A0  stp      x20, x19, [sp, #0x20]
0068692A4  adrp     x21, #0x959b000
0068692A8  adrp     x22, #0x8f23000
0068692AC  ldrb     w8, [x21, #0xa3c]
0068692B0  ldr      x22, [x22, #0xf80]
0068692B4  mov      w19, w1
0068692B8  mov      x20, x0
0068692BC  tbnz     w8, #0, #0x68692e0
0068692C0  adrp     x0, #0x8f23000
0068692C4  ldr      x0, [x0, #0xf80]
0068692C8  bl       #0x382bd14 ; 
0068692CC  adrp     x0, #0x8edb000
0068692D0  ldr      x0, [x0, #0x180]
0068692D4  bl       #0x382bd14 ; 
0068692D8  mov      w8, #1
0068692DC  strb     w8, [x21, #0xa3c]
0068692E0  ldr      x2, [x22]
0068692E4  ldrb     w8, [x2, #0x53]
0068692E8  tbnz     w8, #5, #0x6869320
0068692EC  ldr      x0, [x20, #0x58]
0068692F0  cbz      x0, #0x686933c
0068692F4  adrp     x8, #0x8edb000
0068692F8  ldr      x8, [x8, #0x180]
0068692FC  mov      w1, w19
006869300  ldr      x2, [x8]
006869304  bl       #0x4d65db8 ; System.Collections.Generic.List<int>$$Remove
006869308  mov      x0, x20
00686930C  mov      w1, w19
006869310  ldp      x20, x19, [sp, #0x20]
006869314  ldp      x22, x21, [sp, #0x10]
006869318  ldr      x30, [sp], #0x30
00686931C  b        #0x686872c ; HotFix.BattleLogic.HeroComponentRandomSkill$$OnRemoveSkill
006869320  ldr      x3, [x2, #0x60]
006869324  mov      x0, x20
006869328  mov      w1, w19
00686932C  ldp      x20, x19, [sp, #0x20]
006869330  ldp      x22, x21, [sp, #0x10]
006869334  ldr      x30, [sp], #0x30
006869338  br       x3
00686933C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$HasSkill
; RVA 0x6869340; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869340  str      x30, [sp, #-0x30]!
006869344  stp      x22, x21, [sp, #0x10]
006869348  stp      x20, x19, [sp, #0x20]
00686934C  adrp     x21, #0x959b000
006869350  adrp     x22, #0x8f23000
006869354  ldrb     w8, [x21, #0xa3d]
006869358  ldr      x22, [x22, #0xf88]
00686935C  mov      w19, w1
006869360  mov      x20, x0
006869364  tbnz     w8, #0, #0x6869388
006869368  adrp     x0, #0x8f23000
00686936C  ldr      x0, [x0, #0xf88]
006869370  bl       #0x382bd14 ; 
006869374  adrp     x0, #0x8f08000
006869378  ldr      x0, [x0, #0x630]
00686937C  bl       #0x382bd14 ; 
006869380  mov      w8, #1
006869384  strb     w8, [x21, #0xa3d]
006869388  ldr      x2, [x22]
00686938C  ldrb     w8, [x2, #0x53]
006869390  tbnz     w8, #5, #0x68693bc
006869394  ldr      x0, [x20, #0x58]
006869398  cbz      x0, #0x68693d8
00686939C  adrp     x8, #0x8f08000
0068693A0  ldr      x8, [x8, #0x630]
0068693A4  mov      w1, w19
0068693A8  ldp      x20, x19, [sp, #0x20]
0068693AC  ldp      x22, x21, [sp, #0x10]
0068693B0  ldr      x2, [x8]
0068693B4  ldr      x30, [sp], #0x30
0068693B8  b        #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0068693BC  ldr      x3, [x2, #0x60]
0068693C0  mov      x0, x20
0068693C4  mov      w1, w19
0068693C8  ldp      x20, x19, [sp, #0x20]
0068693CC  ldp      x22, x21, [sp, #0x10]
0068693D0  ldr      x30, [sp], #0x30
0068693D4  br       x3
0068693D8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveSkillInSurvior
; RVA 0x68693DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068693DC  str      x30, [sp, #-0x30]!
0068693E0  stp      x22, x21, [sp, #0x10]
0068693E4  stp      x20, x19, [sp, #0x20]
0068693E8  adrp     x21, #0x959b000
0068693EC  adrp     x22, #0x8f23000
0068693F0  ldrb     w8, [x21, #0xa3e]
0068693F4  ldr      x22, [x22, #0xf90]
0068693F8  mov      x20, x1
0068693FC  mov      x19, x0
006869400  tbnz     w8, #0, #0x6869448
006869404  adrp     x0, #0x8f23000
006869408  ldr      x0, [x0, #0xf90]
00686940C  bl       #0x382bd14 ; 
006869410  adrp     x0, #0x8f23000
006869414  ldr      x0, [x0, #0xf98]
006869418  bl       #0x382bd14 ; 
00686941C  adrp     x0, #0x8f23000
006869420  ldr      x0, [x0, #0xfa0]
006869424  bl       #0x382bd14 ; 
006869428  adrp     x0, #0x8f23000
00686942C  ldr      x0, [x0, #0xfa8]
006869430  bl       #0x382bd14 ; 
006869434  adrp     x0, #0x8f23000
006869438  ldr      x0, [x0, #0xfb0]
00686943C  bl       #0x382bd14 ; 
006869440  mov      w8, #1
006869444  strb     w8, [x21, #0xa3e]
006869448  ldr      x2, [x22]
00686944C  ldrb     w8, [x2, #0x53]
006869450  tbnz     w8, #5, #0x6869494
006869454  cbz      x20, #0x6869550
006869458  adrp     x21, #0x9598000
00686945C  ldrb     w8, [x21, #0xde3]
006869460  cbnz     w8, #0x6869478
006869464  adrp     x0, #0x8f00000
006869468  ldr      x0, [x0, #0xd98]
00686946C  bl       #0x382bd14 ; 
006869470  mov      w8, #1
006869474  strb     w8, [x21, #0xde3]
006869478  adrp     x8, #0x8f00000
00686947C  ldr      x8, [x8, #0xd98]
006869480  ldr      x1, [x8]
006869484  ldrb     w8, [x1, #0x53]
006869488  tbnz     w8, #5, #0x68694b0
00686948C  ldr      w20, [x20, #0x20]
006869490  b        #0x68694c0 ; 
006869494  ldr      x3, [x2, #0x60]
006869498  mov      x0, x19
00686949C  mov      x1, x20
0068694A0  ldp      x20, x19, [sp, #0x20]
0068694A4  ldp      x22, x21, [sp, #0x10]
0068694A8  ldr      x30, [sp], #0x30
0068694AC  br       x3
0068694B0  ldr      x8, [x1, #0x60]
0068694B4  mov      x0, x20
0068694B8  blr      x8
0068694BC  mov      w20, w0
0068694C0  ldr      x0, [x19, #0x48]
0068694C4  cbz      x0, #0x6869550
0068694C8  adrp     x8, #0x8f23000
0068694CC  ldr      x8, [x8, #0xf98]
0068694D0  mov      w1, w20
0068694D4  ldr      x2, [x8]
0068694D8  bl       #0x521de14 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$ContainsKey
0068694DC  tbz      w0, #0, #0x6869528
0068694E0  ldr      x0, [x19, #0x48]
0068694E4  cbz      x0, #0x6869550
0068694E8  adrp     x8, #0x8f23000
0068694EC  ldr      x8, [x8, #0xfa0]
0068694F0  mov      w1, w20
0068694F4  ldr      x2, [x8]
0068694F8  bl       #0x521db48 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$get_Item
0068694FC  ldr      x8, [x19, #0x48]
006869500  cbz      x8, #0x6869550
006869504  adrp     x9, #0x8f23000
006869508  ldr      x9, [x9, #0xfa8]
00686950C  sub      w10, w0, #1
006869510  mov      w1, w20
006869514  ldr      x3, [x9]
006869518  and      x9, x0, #0xffffffff00000000
00686951C  orr      x2, x10, x9
006869520  mov      x0, x8
006869524  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
006869528  ldr      x0, [x19, #0x50]
00686952C  cbz      x0, #0x6869550
006869530  adrp     x8, #0x8f23000
006869534  ldr      x8, [x8, #0xfb0]
006869538  mov      w1, w20
00686953C  ldp      x20, x19, [sp, #0x20]
006869540  ldp      x22, x21, [sp, #0x10]
006869544  ldr      x2, [x8]
006869548  ldr      x30, [sp], #0x30
00686954C  b        #0x524cfc8 ; Rock.Collections.OrderedHashSet<int>$$Remove
006869550  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveSkillInSTG
; RVA 0x6869554; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869554  stp      x29, x30, [sp, #-0x60]!
006869558  stp      x28, x27, [sp, #0x10]
00686955C  stp      x26, x25, [sp, #0x20]
006869560  stp      x24, x23, [sp, #0x30]
006869564  stp      x22, x21, [sp, #0x40]
006869568  stp      x20, x19, [sp, #0x50]
00686956C  adrp     x21, #0x959b000
006869570  adrp     x22, #0x8f23000
006869574  ldrb     w8, [x21, #0xa3f]
006869578  ldr      x22, [x22, #0xfb8]
00686957C  mov      x20, x1
006869580  mov      x19, x0
006869584  tbnz     w8, #0, #0x6869614
006869588  adrp     x0, #0x8f23000
00686958C  ldr      x0, [x0, #0x140]
006869590  bl       #0x382bd14 ; 
006869594  adrp     x0, #0x8f23000
006869598  ldr      x0, [x0, #0xfb8]
00686959C  bl       #0x382bd14 ; 
0068695A0  adrp     x0, #0x8ebf000
0068695A4  ldr      x0, [x0, #0x4e8]
0068695A8  bl       #0x382bd14 ; 
0068695AC  adrp     x0, #0x8f23000
0068695B0  ldr      x0, [x0, #0xfc0]
0068695B4  bl       #0x382bd14 ; 
0068695B8  adrp     x0, #0x8f23000
0068695BC  ldr      x0, [x0, #0xfc8]
0068695C0  bl       #0x382bd14 ; 
0068695C4  adrp     x0, #0x8ebf000
0068695C8  ldr      x0, [x0, #0x4f0]
0068695CC  bl       #0x382bd14 ; 
0068695D0  adrp     x0, #0x8f23000
0068695D4  ldr      x0, [x0, #0xf98]
0068695D8  bl       #0x382bd14 ; 
0068695DC  adrp     x0, #0x8f23000
0068695E0  ldr      x0, [x0, #0xfa0]
0068695E4  bl       #0x382bd14 ; 
0068695E8  adrp     x0, #0x8f23000
0068695EC  ldr      x0, [x0, #0xfa8]
0068695F0  bl       #0x382bd14 ; 
0068695F4  adrp     x0, #0x8f23000
0068695F8  ldr      x0, [x0, #0xfd0]
0068695FC  bl       #0x382bd14 ; 
006869600  adrp     x0, #0x8f23000
006869604  ldr      x0, [x0, #0xfb0]
006869608  bl       #0x382bd14 ; 
00686960C  mov      w8, #1
006869610  strb     w8, [x21, #0xa3f]
006869614  ldr      x2, [x22]
006869618  ldrb     w8, [x2, #0x53]
00686961C  tbnz     w8, #5, #0x6869660
006869620  cbz      x20, #0x6869c1c
006869624  adrp     x21, #0x9598000
006869628  ldrb     w8, [x21, #0xde3]
00686962C  cbnz     w8, #0x6869644
006869630  adrp     x0, #0x8f00000
006869634  ldr      x0, [x0, #0xd98]
006869638  bl       #0x382bd14 ; 
00686963C  mov      w8, #1
006869640  strb     w8, [x21, #0xde3]
006869644  adrp     x8, #0x8f00000
006869648  ldr      x8, [x8, #0xd98]
00686964C  ldr      x1, [x8]
006869650  ldrb     w8, [x1, #0x53]
006869654  tbnz     w8, #5, #0x6869688
006869658  ldr      w21, [x20, #0x20]
00686965C  b        #0x6869698 ; 
006869660  ldr      x3, [x2, #0x60]
006869664  mov      x0, x19
006869668  mov      x1, x20
00686966C  ldp      x20, x19, [sp, #0x50]
006869670  ldp      x22, x21, [sp, #0x40]
006869674  ldp      x24, x23, [sp, #0x30]
006869678  ldp      x26, x25, [sp, #0x20]
00686967C  ldp      x28, x27, [sp, #0x10]
006869680  ldp      x29, x30, [sp], #0x60
006869684  br       x3
006869688  ldr      x8, [x1, #0x60]
00686968C  mov      x0, x20
006869690  blr      x8
006869694  mov      w21, w0
006869698  adrp     x22, #0x9598000
00686969C  ldrb     w8, [x22, #0x35e]
0068696A0  cbnz     w8, #0x68696b8
0068696A4  adrp     x0, #0x8ef9000
0068696A8  ldr      x0, [x0, #0xf30]
0068696AC  bl       #0x382bd14 ; 
0068696B0  mov      w8, #1
0068696B4  strb     w8, [x22, #0x35e]
0068696B8  adrp     x8, #0x8ef9000
0068696BC  ldr      x8, [x8, #0xf30]
0068696C0  ldr      x1, [x8]
0068696C4  ldrb     w8, [x1, #0x53]
0068696C8  tbnz     w8, #5, #0x68696d4
0068696CC  ldr      w20, [x20, #0x68]
0068696D0  b        #0x68696e4 ; 
0068696D4  ldr      x8, [x1, #0x60]
0068696D8  mov      x0, x20
0068696DC  blr      x8
0068696E0  mov      w20, w0
0068696E4  mov      x0, x19
0068696E8  mov      w1, w20
0068696EC  bl       #0x6869d14 ; HotFix.BattleLogic.HeroComponentRandomSkill$$DecreaseLearnedSkillCount
0068696F0  ldr      x0, [x19, #0x48]
0068696F4  cbz      x0, #0x6869c1c
0068696F8  adrp     x8, #0x8f23000
0068696FC  ldr      x8, [x8, #0xf98]
006869700  mov      w1, w21
006869704  ldr      x2, [x8]
006869708  bl       #0x521de14 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$ContainsKey
00686970C  tbz      w0, #0, #0x6869770
006869710  ldr      x0, [x19, #0x48]
006869714  cbz      x0, #0x6869c1c
006869718  adrp     x8, #0x8f23000
00686971C  ldr      x8, [x8, #0xfa0]
006869720  mov      w1, w21
006869724  ldr      x2, [x8]
006869728  bl       #0x521db48 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$get_Item
00686972C  ldr      x8, [x19, #0x48]
006869730  cbz      x8, #0x6869c1c
006869734  adrp     x9, #0x8f23000
006869738  ldr      x9, [x9, #0xfa8]
00686973C  sub      w22, w0, #1
006869740  mov      w10, w22
006869744  mov      w1, w21
006869748  ldr      x3, [x9]
00686974C  and      x9, x0, #0xffffffff00000000
006869750  orr      x2, x9, x10
006869754  mov      x0, x8
006869758  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686975C  cmp      w22, #0
006869760  b.gt     #0x6869770
006869764  mov      x0, x19
006869768  mov      w1, w21
00686976C  bl       #0x6869e18 ; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveRandomSkill
006869770  ldr      x0, [x19, #0x50]
006869774  cbz      x0, #0x6869c1c
006869778  adrp     x8, #0x8f23000
00686977C  ldr      x8, [x8, #0xfb0]
006869780  mov      w1, w21
006869784  ldr      x2, [x8]
006869788  bl       #0x524cfc8 ; Rock.Collections.OrderedHashSet<int>$$Remove
00686978C  mov      x0, x19
006869790  mov      w1, w20
006869794  bl       #0x6869e9c ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetDeltaWeightPercent
006869798  mov      x2, x0
00686979C  mov      x0, x19
0068697A0  mov      w1, w20
0068697A4  bl       #0x686a17c ; HotFix.BattleLogic.HeroComponentRandomSkill$$AdjustWeightsForSkillGroup
0068697A8  adrp     x8, #0x9591000
0068697AC  ldrb     w8, [x8, #0xa4b]
0068697B0  cbnz     w8, #0x68697cc
0068697B4  adrp     x0, #0x8ee5000
0068697B8  ldr      x0, [x0, #0xb28]
0068697BC  bl       #0x382bd14 ; 
0068697C0  mov      w8, #1
0068697C4  adrp     x9, #0x9591000
0068697C8  strb     w8, [x9, #0xa4b]
0068697CC  adrp     x8, #0x8ee5000
0068697D0  ldr      x8, [x8, #0xb28]
0068697D4  ldr      x1, [x8]
0068697D8  ldrb     w8, [x1, #0x53]
0068697DC  tbnz     w8, #5, #0x68697e8
0068697E0  ldr      x20, [x19, #0x20]
0068697E4  b        #0x68697f8 ; 
0068697E8  ldr      x8, [x1, #0x60]
0068697EC  mov      x0, x19
0068697F0  blr      x8
0068697F4  mov      x20, x0
0068697F8  cbz      x20, #0x6869c1c
0068697FC  adrp     x21, #0x9598000
006869800  ldrb     w8, [x21, #0xfcc]
006869804  cbnz     w8, #0x686981c
006869808  adrp     x0, #0x8f06000
00686980C  ldr      x0, [x0, #0x470]
006869810  bl       #0x382bd14 ; 
006869814  mov      w8, #1
006869818  strb     w8, [x21, #0xfcc]
00686981C  adrp     x8, #0x8f06000
006869820  ldr      x8, [x8, #0x470]
006869824  ldr      x1, [x8]
006869828  ldrb     w8, [x1, #0x53]
00686982C  tbnz     w8, #5, #0x6869838
006869830  ldr      x0, [x20, #0x200]
006869834  b        #0x6869844 ; 
006869838  ldr      x8, [x1, #0x60]
00686983C  mov      x0, x20
006869840  blr      x8
006869844  cbz      x0, #0x6869c1c
006869848  mov      x1, xzr
00686984C  bl       #0x64d17c4 ; LocalModels.LocalModelManager$$GetSkill_SynthesisElements
006869850  cbz      x0, #0x6869c1c
006869854  adrp     x10, #0x8f23000
006869858  ldr      x8, [x0]
00686985C  ldr      x10, [x10, #0xfc0]
006869860  mov      x20, x0
006869864  ldrh     w9, [x8, #0x12e]
006869868  ldr      x1, [x10]
00686986C  cbz      x9, #0x6869890
006869870  ldr      x10, [x8, #0xb0]
006869874  add      x10, x10, #8
006869878  ldur     x11, [x10, #-8]
00686987C  cmp      x11, x1
006869880  b.eq     #0x68698a0
006869884  subs     x9, x9, #1
006869888  add      x10, x10, #0x10
00686988C  b.ne     #0x6869878
006869890  mov      x0, x20
006869894  mov      w2, wzr
006869898  bl       #0x3a7e710 ; 
00686989C  b        #0x68698ac ; 
0068698A0  ldrsw    x9, [x10]
0068698A4  add      x8, x8, x9, lsl #4
0068698A8  add      x0, x8, #0x138
0068698AC  ldp      x8, x1, [x0]
0068698B0  mov      x0, x20
0068698B4  blr      x8
0068698B8  mov      x20, x0
0068698BC  cbz      x0, #0x6869c20
0068698C0  adrp     x29, #0x8ebf000
0068698C4  adrp     x25, #0x8f23000
0068698C8  adrp     x22, #0x8f23000
0068698CC  adrp     x23, #0x8f23000
0068698D0  ldr      x29, [x29, #0x4f0]
0068698D4  ldr      x25, [x25, #0xfc8]
0068698D8  ldr      x22, [x22, #0xfd8]
0068698DC  ldr      x23, [x23, #0xfe0]
0068698E0  adrp     x28, #0x959b000
0068698E4  mov      w21, #1
0068698E8  adrp     x24, #0x959b000
0068698EC  ldr      x8, [x20]
0068698F0  ldr      x1, [x29]
0068698F4  ldrh     w9, [x8, #0x12e]
0068698F8  cbz      x9, #0x686991c
0068698FC  ldr      x10, [x8, #0xb0]
006869900  add      x10, x10, #8
006869904  ldur     x11, [x10, #-8]
006869908  cmp      x11, x1
00686990C  b.eq     #0x686992c
006869910  subs     x9, x9, #1
006869914  add      x10, x10, #0x10
006869918  b.ne     #0x6869904
00686991C  mov      x0, x20
006869920  mov      w2, wzr
006869924  bl       #0x3a7e710 ; 
006869928  b        #0x6869938 ; 
00686992C  ldrsw    x9, [x10]
006869930  add      x8, x8, x9, lsl #4
006869934  add      x0, x8, #0x138
006869938  ldp      x8, x1, [x0]
00686993C  mov      x0, x20
006869940  blr      x8
006869944  tbz      w0, #0, #0x6869b88
006869948  ldr      x8, [x20]
00686994C  ldr      x1, [x25]
006869950  ldrh     w9, [x8, #0x12e]
006869954  cbz      x9, #0x6869978
006869958  ldr      x10, [x8, #0xb0]
00686995C  add      x10, x10, #8
006869960  ldur     x11, [x10, #-8]
006869964  cmp      x11, x1
006869968  b.eq     #0x6869988
00686996C  subs     x9, x9, #1
006869970  add      x10, x10, #0x10
006869974  b.ne     #0x6869960
006869978  mov      x0, x20
00686997C  mov      w2, wzr
006869980  bl       #0x3a7e710 ; 
006869984  b        #0x6869994 ; 
006869988  ldrsw    x9, [x10]
00686998C  add      x8, x8, x9, lsl #4
006869990  add      x0, x8, #0x138
006869994  ldp      x8, x1, [x0]
006869998  mov      x0, x20
00686999C  blr      x8
0068699A0  mov      x27, x0
0068699A4  cbz      x0, #0x6869c10
0068699A8  ldrb     w8, [x28, #0xba8]
0068699AC  cbnz     w8, #0x68699bc
0068699B0  mov      x0, x22
0068699B4  bl       #0x382bd14 ; 
0068699B8  strb     w21, [x28, #0xba8]
0068699BC  ldr      x1, [x22]
0068699C0  ldrb     w8, [x1, #0x53]
0068699C4  tbnz     w8, #5, #0x68699d0
0068699C8  ldr      w26, [x27, #0x30]
0068699CC  b        #0x68699e0 ; 
0068699D0  ldr      x8, [x1, #0x60]
0068699D4  mov      x0, x27
0068699D8  blr      x8
0068699DC  mov      w26, w0
0068699E0  ldrb     w8, [x24, #0xba9]
0068699E4  cbnz     w8, #0x68699f4
0068699E8  mov      x0, x23
0068699EC  bl       #0x382bd14 ; 
0068699F0  strb     w21, [x24, #0xba9]
0068699F4  ldr      x1, [x23]
0068699F8  ldrb     w8, [x1, #0x53]
0068699FC  tbnz     w8, #5, #0x6869a08
006869A00  ldr      w1, [x27, #0x24]
006869A04  b        #0x6869a18 ; 
006869A08  ldr      x8, [x1, #0x60]
006869A0C  mov      x0, x27
006869A10  blr      x8
006869A14  mov      w1, w0
006869A18  mov      x0, x19
006869A1C  bl       #0x686a1f8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<RemoveSkillInSTG>g__SkillSuit|32_0
006869A20  tbz      w0, #0, #0x6869ad4
006869A24  adrp     x8, #0x959b000
006869A28  ldrb     w8, [x8, #0xbaa]
006869A2C  cbnz     w8, #0x6869a44
006869A30  adrp     x0, #0x8f23000
006869A34  ldr      x0, [x0, #0xfe8]
006869A38  bl       #0x382bd14 ; 
006869A3C  adrp     x8, #0x959b000
006869A40  strb     w21, [x8, #0xbaa]
006869A44  adrp     x8, #0x8f23000
006869A48  ldr      x8, [x8, #0xfe8]
006869A4C  ldr      x1, [x8]
006869A50  ldrb     w8, [x1, #0x53]
006869A54  tbnz     w8, #5, #0x6869a60
006869A58  ldr      w1, [x27, #0x28]
006869A5C  b        #0x6869a70 ; 
006869A60  ldr      x8, [x1, #0x60]
006869A64  mov      x0, x27
006869A68  blr      x8
006869A6C  mov      w1, w0
006869A70  mov      x0, x19
006869A74  bl       #0x686a1f8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<RemoveSkillInSTG>g__SkillSuit|32_0
006869A78  tbz      w0, #0, #0x6869ad4
006869A7C  adrp     x8, #0x959b000
006869A80  ldrb     w8, [x8, #0xbab]
006869A84  cbnz     w8, #0x6869a9c
006869A88  adrp     x0, #0x8f23000
006869A8C  ldr      x0, [x0, #0xff0]
006869A90  bl       #0x382bd14 ; 
006869A94  adrp     x8, #0x959b000
006869A98  strb     w21, [x8, #0xbab]
006869A9C  adrp     x8, #0x8f23000
006869AA0  ldr      x8, [x8, #0xff0]
006869AA4  ldr      x1, [x8]
006869AA8  ldrb     w8, [x1, #0x53]
006869AAC  tbnz     w8, #5, #0x6869ab8
006869AB0  ldr      w1, [x27, #0x2c]
006869AB4  b        #0x6869ac8 ; 
006869AB8  ldr      x8, [x1, #0x60]
006869ABC  mov      x0, x27
006869AC0  blr      x8
006869AC4  mov      w1, w0
006869AC8  mov      x0, x19
006869ACC  bl       #0x686a1f8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<RemoveSkillInSTG>g__SkillSuit|32_0
006869AD0  tbnz     w0, #0, #0x68698ec
006869AD4  ldr      x0, [x19, #0x50]
006869AD8  cbz      x0, #0x6869c14
006869ADC  adrp     x8, #0x8f23000
006869AE0  ldr      x8, [x8, #0xfd0]
006869AE4  ldr      x2, [x8]
006869AE8  mov      w1, w26
006869AEC  bl       #0x524c9b0 ; Rock.Collections.OrderedHashSet<int>$$Contains
006869AF0  tbz      w0, #0, #0x68698ec
006869AF4  adrp     x8, #0x9591000
006869AF8  ldrb     w8, [x8, #0xa4b]
006869AFC  cbnz     w8, #0x6869b14
006869B00  adrp     x0, #0x8ee5000
006869B04  ldr      x0, [x0, #0xb28]
006869B08  bl       #0x382bd14 ; 
006869B0C  adrp     x8, #0x9591000
006869B10  strb     w21, [x8, #0xa4b]
006869B14  adrp     x8, #0x8ee5000
006869B18  ldr      x8, [x8, #0xb28]
006869B1C  ldr      x1, [x8]
006869B20  ldrb     w8, [x1, #0x53]
006869B24  tbnz     w8, #5, #0x6869b30
006869B28  ldr      x27, [x19, #0x20]
006869B2C  b        #0x6869b40 ; 
006869B30  ldr      x8, [x1, #0x60]
006869B34  mov      x0, x19
006869B38  blr      x8
006869B3C  mov      x27, x0
006869B40  adrp     x8, #0x8f23000
006869B44  ldr      x8, [x8, #0x140]
006869B48  ldr      x1, [x8]
006869B4C  ldrb     w8, [x1, #0x53]
006869B50  tbnz     w8, #5, #0x6869b5c
006869B54  ldr      x1, [x19, #0x30]
006869B58  b        #0x6869b6c ; 
006869B5C  ldr      x8, [x1, #0x60]
006869B60  mov      x0, x19
006869B64  blr      x8
006869B68  mov      x1, x0
006869B6C  cbz      x27, #0x6869c18
006869B70  mov      w3, #1
006869B74  mov      x0, x27
006869B78  mov      w2, w26
006869B7C  mov      x4, xzr
006869B80  bl       #0x6a240cc ; HotFix.BattleLogic.BattleWorldContext$$RemoveSkillFromCharacterInSTG
006869B84  b        #0x68698ec ; 
006869B88  mov      x21, xzr
006869B8C  cbz      x20, #0x6869bf0
006869B90  adrp     x10, #0x8ebf000
006869B94  ldr      x8, [x20]
006869B98  ldr      x10, [x10, #0x4e8]
006869B9C  ldrh     w9, [x8, #0x12e]
006869BA0  ldr      x1, [x10]
006869BA4  cbz      x9, #0x6869bc8
006869BA8  ldr      x10, [x8, #0xb0]
006869BAC  add      x10, x10, #8
006869BB0  ldur     x11, [x10, #-8]
006869BB4  cmp      x11, x1
006869BB8  b.eq     #0x6869bd8
006869BBC  subs     x9, x9, #1
006869BC0  add      x10, x10, #0x10
006869BC4  b.ne     #0x6869bb0
006869BC8  mov      x0, x20
006869BCC  mov      w2, wzr
006869BD0  bl       #0x3a7e710 ; 
006869BD4  b        #0x6869be4 ; 
006869BD8  ldrsw    x9, [x10]
006869BDC  add      x8, x8, x9, lsl #4
006869BE0  add      x0, x8, #0x138
006869BE4  ldp      x8, x1, [x0]
006869BE8  mov      x0, x20
006869BEC  blr      x8
006869BF0  cbnz     x21, #0x6869c24
006869BF4  ldp      x20, x19, [sp, #0x50]
006869BF8  ldp      x22, x21, [sp, #0x40]
006869BFC  ldp      x24, x23, [sp, #0x30]
006869C00  ldp      x26, x25, [sp, #0x20]
006869C04  ldp      x28, x27, [sp, #0x10]
006869C08  ldp      x29, x30, [sp], #0x60
006869C0C  ret      
006869C10  bl       #0x382bfb8 ; 
006869C14  bl       #0x382bfb8 ; 
006869C18  bl       #0x382bfb8 ; 
006869C1C  bl       #0x382bfb8 ; 
006869C20  bl       #0x382bfb8 ; 
006869C24  mov      x0, x21
006869C28  bl       #0x382bfb0 ; 
006869C2C  b        #0x6869c6c ; 
006869C30  b        #0x6869c6c ; 
006869C34  b        #0x6869c6c ; 
006869C38  b        #0x6869c6c ; 
006869C3C  b        #0x6869c6c ; 
006869C40  b        #0x6869c6c ; 
006869C44  b        #0x6869c6c ; 
006869C48  b        #0x6869c6c ; 
006869C4C  b        #0x6869c6c ; 
006869C50  b        #0x6869c6c ; 
006869C54  b        #0x6869c6c ; 
006869C58  b        #0x6869c6c ; 
006869C5C  b        #0x6869c6c ; 
006869C60  b        #0x6869c6c ; 
006869C64  b        #0x6869c6c ; 
006869C68  b        #0x6869c6c ; 
006869C6C  mov      x19, x0
006869C70  cmp      w1, #1
006869C74  b.ne     #0x6869c8c
006869C78  mov      x0, x19
006869C7C  bl       #0x89eda50 ; 
006869C80  ldr      x21, [x0]
006869C84  bl       #0x89eda60 ; 
006869C88  b        #0x6869b8c ; 
006869C8C  mov      x21, xzr
006869C90  b        #0x6869c98 ; 
006869C94  mov      x19, x0
006869C98  cbz      x20, #0x6869cfc
006869C9C  adrp     x10, #0x8ebf000
006869CA0  ldr      x8, [x20]
006869CA4  ldr      x10, [x10, #0x4e8]
006869CA8  ldrh     w9, [x8, #0x12e]
006869CAC  ldr      x1, [x10]
006869CB0  cbz      x9, #0x6869cd4
006869CB4  ldr      x10, [x8, #0xb0]
006869CB8  add      x10, x10, #8
006869CBC  ldur     x11, [x10, #-8]
006869CC0  cmp      x11, x1
006869CC4  b.eq     #0x6869ce4
006869CC8  subs     x9, x9, #1
006869CCC  add      x10, x10, #0x10
006869CD0  b.ne     #0x6869cbc
006869CD4  mov      x0, x20
006869CD8  mov      w2, wzr
006869CDC  bl       #0x3a7e710 ; 
006869CE0  b        #0x6869cf0 ; 
006869CE4  ldrsw    x9, [x10]
006869CE8  add      x8, x8, x9, lsl #4
006869CEC  add      x0, x8, #0x138
006869CF0  ldp      x8, x1, [x0]
006869CF4  mov      x0, x20
006869CF8  blr      x8
006869CFC  cbnz     x21, #0x6869d08
006869D00  mov      x0, x19
006869D04  bl       #0x3b56bfc ; 
006869D08  mov      x0, x21
006869D0C  bl       #0x382bfb0 ; 
006869D10  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillSurvior
; RVA 0x686A2AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686A2AC  sub      sp, sp, #0x40
00686A2B0  str      x30, [sp, #0x10]
00686A2B4  stp      x22, x21, [sp, #0x20]
00686A2B8  stp      x20, x19, [sp, #0x30]
00686A2BC  adrp     x21, #0x959b000
00686A2C0  adrp     x22, #0x8f24000
00686A2C4  ldrb     w8, [x21, #0xa40]
00686A2C8  ldr      x22, [x22, #0x48]
00686A2CC  mov      x20, x1
00686A2D0  mov      x19, x0
00686A2D4  tbnz     w8, #0, #0x686a31c
00686A2D8  adrp     x0, #0x8f24000
00686A2DC  ldr      x0, [x0, #0x48]
00686A2E0  bl       #0x382bd14 ; 
00686A2E4  adrp     x0, #0x8f23000
00686A2E8  ldr      x0, [x0, #0xf98]
00686A2EC  bl       #0x382bd14 ; 
00686A2F0  adrp     x0, #0x8f23000
00686A2F4  ldr      x0, [x0, #0xfa0]
00686A2F8  bl       #0x382bd14 ; 
00686A2FC  adrp     x0, #0x8f23000
00686A300  ldr      x0, [x0, #0xfa8]
00686A304  bl       #0x382bd14 ; 
00686A308  adrp     x0, #0x8f24000
00686A30C  ldr      x0, [x0, #0x50]
00686A310  bl       #0x382bd14 ; 
00686A314  mov      w8, #1
00686A318  strb     w8, [x21, #0xa40]
00686A31C  ldr      x2, [x22]
00686A320  ldrb     w8, [x2, #0x53]
00686A324  tbnz     w8, #5, #0x686a370
00686A328  str      xzr, [sp, #0x18]
00686A32C  str      xzr, [sp, #8]
00686A330  cbz      x20, #0x686a538
00686A334  adrp     x21, #0x9598000
00686A338  ldrb     w8, [x21, #0xde3]
00686A33C  cbnz     w8, #0x686a354
00686A340  adrp     x0, #0x8f00000
00686A344  ldr      x0, [x0, #0xd98]
00686A348  bl       #0x382bd14 ; 
00686A34C  mov      w8, #1
00686A350  strb     w8, [x21, #0xde3]
00686A354  adrp     x8, #0x8f00000
00686A358  ldr      x8, [x8, #0xd98]
00686A35C  ldr      x1, [x8]
00686A360  ldrb     w8, [x1, #0x53]
00686A364  tbnz     w8, #5, #0x686a390
00686A368  ldr      w21, [x20, #0x20]
00686A36C  b        #0x686a3a0 ; 
00686A370  ldr      x3, [x2, #0x60]
00686A374  mov      x0, x19
00686A378  mov      x1, x20
00686A37C  ldp      x20, x19, [sp, #0x30]
00686A380  ldp      x22, x21, [sp, #0x20]
00686A384  ldr      x30, [sp, #0x10]
00686A388  add      sp, sp, #0x40
00686A38C  br       x3
00686A390  ldr      x8, [x1, #0x60]
00686A394  mov      x0, x20
00686A398  blr      x8
00686A39C  mov      w21, w0
00686A3A0  adrp     x22, #0x9598000
00686A3A4  ldrb     w8, [x22, #0x35e]
00686A3A8  cbnz     w8, #0x686a3c0
00686A3AC  adrp     x0, #0x8ef9000
00686A3B0  ldr      x0, [x0, #0xf30]
00686A3B4  bl       #0x382bd14 ; 
00686A3B8  mov      w8, #1
00686A3BC  strb     w8, [x22, #0x35e]
00686A3C0  adrp     x8, #0x8ef9000
00686A3C4  ldr      x8, [x8, #0xf30]
00686A3C8  ldr      x1, [x8]
00686A3CC  ldrb     w8, [x1, #0x53]
00686A3D0  tbz      w8, #5, #0x686a3e0
00686A3D4  ldr      x8, [x1, #0x60]
00686A3D8  mov      x0, x20
00686A3DC  blr      x8
00686A3E0  ldr      x0, [x19, #0x48]
00686A3E4  cbz      x0, #0x686a538
00686A3E8  adrp     x8, #0x8f23000
00686A3EC  ldr      x8, [x8, #0xf98]
00686A3F0  mov      w1, w21
00686A3F4  ldr      x2, [x8]
00686A3F8  bl       #0x521de14 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$ContainsKey
00686A3FC  tbz      w0, #0, #0x686a450
00686A400  ldr      x0, [x19, #0x48]
00686A404  cbz      x0, #0x686a538
00686A408  adrp     x8, #0x8f23000
00686A40C  ldr      x8, [x8, #0xfa0]
00686A410  mov      w1, w21
00686A414  ldr      x2, [x8]
00686A418  bl       #0x521db48 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$get_Item
00686A41C  add      w8, w0, #1
00686A420  str      x0, [sp, #0x18]
00686A424  str      w8, [sp, #0x18]
00686A428  ldr      x0, [x19, #0x48]
00686A42C  cbz      x0, #0x686a538
00686A430  adrp     x8, #0x8f23000
00686A434  ldr      x2, [sp, #0x18]
00686A438  ldr      x8, [x8, #0xfa8]
00686A43C  mov      w1, w21
00686A440  ldr      x3, [x8]
00686A444  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A448  add      x0, sp, #0x18
00686A44C  b        #0x686a504 ; 
00686A450  adrp     x22, #0x959b000
00686A454  ldrb     w8, [x22, #0xbac]
00686A458  cbnz     w8, #0x686a470
00686A45C  adrp     x0, #0x8f24000
00686A460  ldr      x0, [x0, #0x58]
00686A464  bl       #0x382bd14 ; 
00686A468  mov      w8, #1
00686A46C  strb     w8, [x22, #0xbac]
00686A470  adrp     x8, #0x8f24000
00686A474  ldr      x8, [x8, #0x58]
00686A478  ldr      x1, [x8]
00686A47C  ldrb     w8, [x1, #0x53]
00686A480  tbnz     w8, #5, #0x686a48c
00686A484  ldr      w0, [x20, #0x64]
00686A488  b        #0x686a498 ; 
00686A48C  ldr      x8, [x1, #0x60]
00686A490  mov      x0, x20
00686A494  blr      x8
00686A498  mov      w2, #1
00686A49C  bfi      x2, x0, #0x20, #0x20
00686A4A0  str      x2, [sp, #8]
00686A4A4  ldr      x0, [x19, #0x48]
00686A4A8  cbz      x0, #0x686a538
00686A4AC  adrp     x8, #0x8f23000
00686A4B0  ldr      x8, [x8, #0xfa8]
00686A4B4  mov      w1, w21
00686A4B8  ldr      x3, [x8]
00686A4BC  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A4C0  adrp     x22, #0x959b000
00686A4C4  ldrb     w8, [x22, #0x9b4]
00686A4C8  cbnz     w8, #0x686a4e0
00686A4CC  adrp     x0, #0x8f23000
00686A4D0  ldr      x0, [x0, #0x90]
00686A4D4  bl       #0x382bd14 ; 
00686A4D8  mov      w8, #1
00686A4DC  strb     w8, [x22, #0x9b4]
00686A4E0  adrp     x8, #0x8f23000
00686A4E4  ldr      x8, [x8, #0x90]
00686A4E8  ldr      x1, [x8]
00686A4EC  ldrb     w8, [x1, #0x53]
00686A4F0  tbz      w8, #5, #0x686a500
00686A4F4  ldr      x8, [x1, #0x60]
00686A4F8  mov      x0, x20
00686A4FC  blr      x8
00686A500  add      x0, sp, #8
00686A504  bl       #0x6866604 ; HotFix.BattleLogic.HeroSkillCount$$IsMax
00686A508  ldr      x0, [x19, #0x50]
00686A50C  cbz      x0, #0x686a538
00686A510  adrp     x8, #0x8f24000
00686A514  ldr      x8, [x8, #0x50]
00686A518  mov      w1, w21
00686A51C  ldr      x2, [x8]
00686A520  bl       #0x524e0bc ; Rock.Collections.OrderedHashSet<int>$$Add
00686A524  ldp      x20, x19, [sp, #0x30]
00686A528  ldp      x22, x21, [sp, #0x20]
00686A52C  ldr      x30, [sp, #0x10]
00686A530  add      sp, sp, #0x40
00686A534  ret      
00686A538  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkill
; RVA 0x686A53C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686A53C  sub      sp, sp, #0x70
00686A540  stp      x29, x30, [sp, #0x10]
00686A544  stp      x28, x27, [sp, #0x20]
00686A548  stp      x26, x25, [sp, #0x30]
00686A54C  stp      x24, x23, [sp, #0x40]
00686A550  stp      x22, x21, [sp, #0x50]
00686A554  stp      x20, x19, [sp, #0x60]
00686A558  adrp     x21, #0x959b000
00686A55C  adrp     x22, #0x8f24000
00686A560  ldrb     w8, [x21, #0xa41]
00686A564  ldr      x22, [x22, #0x60]
00686A568  mov      x20, x1
00686A56C  mov      x19, x0
00686A570  tbnz     w8, #0, #0x686a600
00686A574  adrp     x0, #0x8f23000
00686A578  ldr      x0, [x0, #0x140]
00686A57C  bl       #0x382bd14 ; 
00686A580  adrp     x0, #0x8f24000
00686A584  ldr      x0, [x0, #0x60]
00686A588  bl       #0x382bd14 ; 
00686A58C  adrp     x0, #0x8ebf000
00686A590  ldr      x0, [x0, #0x4e8]
00686A594  bl       #0x382bd14 ; 
00686A598  adrp     x0, #0x8f23000
00686A59C  ldr      x0, [x0, #0xfc0]
00686A5A0  bl       #0x382bd14 ; 
00686A5A4  adrp     x0, #0x8f23000
00686A5A8  ldr      x0, [x0, #0xfc8]
00686A5AC  bl       #0x382bd14 ; 
00686A5B0  adrp     x0, #0x8ebf000
00686A5B4  ldr      x0, [x0, #0x4f0]
00686A5B8  bl       #0x382bd14 ; 
00686A5BC  adrp     x0, #0x8f23000
00686A5C0  ldr      x0, [x0, #0xf98]
00686A5C4  bl       #0x382bd14 ; 
00686A5C8  adrp     x0, #0x8f23000
00686A5CC  ldr      x0, [x0, #0xfa0]
00686A5D0  bl       #0x382bd14 ; 
00686A5D4  adrp     x0, #0x8f23000
00686A5D8  ldr      x0, [x0, #0xfa8]
00686A5DC  bl       #0x382bd14 ; 
00686A5E0  adrp     x0, #0x8f24000
00686A5E4  ldr      x0, [x0, #0x50]
00686A5E8  bl       #0x382bd14 ; 
00686A5EC  adrp     x0, #0x8f23000
00686A5F0  ldr      x0, [x0, #0xfd0]
00686A5F4  bl       #0x382bd14 ; 
00686A5F8  mov      w8, #1
00686A5FC  strb     w8, [x21, #0xa41]
00686A600  ldr      x2, [x22]
00686A604  ldrb     w8, [x2, #0x53]
00686A608  tbnz     w8, #5, #0x686a650
00686A60C  stp      xzr, xzr, [sp]
00686A610  cbz      x20, #0x686adec
00686A614  adrp     x23, #0x9598000
00686A618  ldrb     w8, [x23, #0xde3]
00686A61C  cbnz     w8, #0x686a634
00686A620  adrp     x0, #0x8f00000
00686A624  ldr      x0, [x0, #0xd98]
00686A628  bl       #0x382bd14 ; 
00686A62C  mov      w8, #1
00686A630  strb     w8, [x23, #0xde3]
00686A634  adrp     x24, #0x8f00000
00686A638  ldr      x24, [x24, #0xd98]
00686A63C  ldr      x1, [x24]
00686A640  ldrb     w8, [x1, #0x53]
00686A644  tbnz     w8, #5, #0x686a67c
00686A648  ldr      w21, [x20, #0x20]
00686A64C  b        #0x686a68c ; 
00686A650  ldr      x3, [x2, #0x60]
00686A654  mov      x0, x19
00686A658  mov      x1, x20
00686A65C  ldp      x20, x19, [sp, #0x60]
00686A660  ldp      x22, x21, [sp, #0x50]
00686A664  ldp      x24, x23, [sp, #0x40]
00686A668  ldp      x26, x25, [sp, #0x30]
00686A66C  ldp      x28, x27, [sp, #0x20]
00686A670  ldp      x29, x30, [sp, #0x10]
00686A674  add      sp, sp, #0x70
00686A678  br       x3
00686A67C  ldr      x8, [x1, #0x60]
00686A680  mov      x0, x20
00686A684  blr      x8
00686A688  mov      w21, w0
00686A68C  adrp     x22, #0x9598000
00686A690  ldrb     w8, [x22, #0x35e]
00686A694  cbnz     w8, #0x686a6ac
00686A698  adrp     x0, #0x8ef9000
00686A69C  ldr      x0, [x0, #0xf30]
00686A6A0  bl       #0x382bd14 ; 
00686A6A4  mov      w8, #1
00686A6A8  strb     w8, [x22, #0x35e]
00686A6AC  adrp     x8, #0x8ef9000
00686A6B0  ldr      x8, [x8, #0xf30]
00686A6B4  ldr      x1, [x8]
00686A6B8  ldrb     w8, [x1, #0x53]
00686A6BC  tbnz     w8, #5, #0x686a6c8
00686A6C0  ldr      w22, [x20, #0x68]
00686A6C4  b        #0x686a6d8 ; 
00686A6C8  ldr      x8, [x1, #0x60]
00686A6CC  mov      x0, x20
00686A6D0  blr      x8
00686A6D4  mov      w22, w0
00686A6D8  mov      x0, x19
00686A6DC  mov      w1, w22
00686A6E0  bl       #0x686aef4 ; HotFix.BattleLogic.HeroComponentRandomSkill$$UpdateLearnedSkillCount
00686A6E4  ldr      x0, [x19, #0x48]
00686A6E8  cbz      x0, #0x686adec
00686A6EC  adrp     x8, #0x8f23000
00686A6F0  ldr      x8, [x8, #0xf98]
00686A6F4  mov      w1, w21
00686A6F8  ldr      x2, [x8]
00686A6FC  bl       #0x521de14 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$ContainsKey
00686A700  tbz      w0, #0, #0x686a754
00686A704  ldr      x0, [x19, #0x48]
00686A708  cbz      x0, #0x686adec
00686A70C  adrp     x8, #0x8f23000
00686A710  ldr      x8, [x8, #0xfa0]
00686A714  mov      w1, w21
00686A718  ldr      x2, [x8]
00686A71C  bl       #0x521db48 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$get_Item
00686A720  add      w8, w0, #1
00686A724  str      x0, [sp, #8]
00686A728  str      w8, [sp, #8]
00686A72C  ldr      x0, [x19, #0x48]
00686A730  cbz      x0, #0x686adec
00686A734  adrp     x8, #0x8f23000
00686A738  ldr      x2, [sp, #8]
00686A73C  ldr      x8, [x8, #0xfa8]
00686A740  mov      w1, w21
00686A744  ldr      x3, [x8]
00686A748  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A74C  add      x0, sp, #8
00686A750  b        #0x686a90c ; 
00686A754  adrp     x25, #0x959b000
00686A758  ldrb     w8, [x25, #0xbac]
00686A75C  cbnz     w8, #0x686a774
00686A760  adrp     x0, #0x8f24000
00686A764  ldr      x0, [x0, #0x58]
00686A768  bl       #0x382bd14 ; 
00686A76C  mov      w8, #1
00686A770  strb     w8, [x25, #0xbac]
00686A774  adrp     x8, #0x8f24000
00686A778  ldr      x8, [x8, #0x58]
00686A77C  ldr      x1, [x8]
00686A780  ldrb     w8, [x1, #0x53]
00686A784  tbnz     w8, #5, #0x686a790
00686A788  ldr      w0, [x20, #0x64]
00686A78C  b        #0x686a79c ; 
00686A790  ldr      x8, [x1, #0x60]
00686A794  mov      x0, x20
00686A798  blr      x8
00686A79C  mov      w2, #1
00686A7A0  bfi      x2, x0, #0x20, #0x20
00686A7A4  str      x2, [sp]
00686A7A8  ldr      x0, [x19, #0x48]
00686A7AC  cbz      x0, #0x686adec
00686A7B0  adrp     x8, #0x8f23000
00686A7B4  ldr      x8, [x8, #0xfa8]
00686A7B8  mov      w1, w21
00686A7BC  ldr      x3, [x8]
00686A7C0  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A7C4  adrp     x25, #0x959b000
00686A7C8  ldrb     w8, [x25, #0x9b4]
00686A7CC  cbnz     w8, #0x686a7e4
00686A7D0  adrp     x0, #0x8f23000
00686A7D4  ldr      x0, [x0, #0x90]
00686A7D8  bl       #0x382bd14 ; 
00686A7DC  mov      w8, #1
00686A7E0  strb     w8, [x25, #0x9b4]
00686A7E4  adrp     x8, #0x8f23000
00686A7E8  ldr      x8, [x8, #0x90]
00686A7EC  ldr      x1, [x8]
00686A7F0  ldrb     w8, [x1, #0x53]
00686A7F4  tbnz     w8, #5, #0x686a800
00686A7F8  ldr      x1, [x20, #0x170]
00686A7FC  b        #0x686a810 ; 
00686A800  ldr      x8, [x1, #0x60]
00686A804  mov      x0, x20
00686A808  blr      x8
00686A80C  mov      x1, x0
00686A810  mov      x0, x19
00686A814  bl       #0x686aff8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillFlags
00686A818  adrp     x25, #0x959b000
00686A81C  ldrb     w8, [x25, #0xbad]
00686A820  cbnz     w8, #0x686a838
00686A824  adrp     x0, #0x8f24000
00686A828  ldr      x0, [x0, #0x68]
00686A82C  bl       #0x382bd14 ; 
00686A830  mov      w8, #1
00686A834  strb     w8, [x25, #0xbad]
00686A838  adrp     x8, #0x8f24000
00686A83C  ldr      x8, [x8, #0x68]
00686A840  ldr      x1, [x8]
00686A844  ldrb     w8, [x1, #0x53]
00686A848  tbnz     w8, #5, #0x686a854
00686A84C  ldr      w1, [x20, #0x17c]
00686A850  b        #0x686a864 ; 
00686A854  ldr      x8, [x1, #0x60]
00686A858  mov      x0, x20
00686A85C  blr      x8
00686A860  mov      w1, w0
00686A864  mov      x0, x19
00686A868  bl       #0x686b0b8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillRejectFlags
00686A86C  ldrb     w8, [x23, #0xde3]
00686A870  cbnz     w8, #0x686a888
00686A874  adrp     x0, #0x8f00000
00686A878  ldr      x0, [x0, #0xd98]
00686A87C  bl       #0x382bd14 ; 
00686A880  mov      w8, #1
00686A884  strb     w8, [x23, #0xde3]
00686A888  ldr      x1, [x24]
00686A88C  ldrb     w8, [x1, #0x53]
00686A890  tbnz     w8, #5, #0x686a89c
00686A894  ldr      w1, [x20, #0x20]
00686A898  b        #0x686a8ac ; 
00686A89C  ldr      x8, [x1, #0x60]
00686A8A0  mov      x0, x20
00686A8A4  blr      x8
00686A8A8  mov      w1, w0
00686A8AC  mov      x0, x19
00686A8B0  bl       #0x686b13c ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddNeedSkill
00686A8B4  adrp     x23, #0x959b000
00686A8B8  ldrb     w8, [x23, #0xbae]
00686A8BC  cbnz     w8, #0x686a8d4
00686A8C0  adrp     x0, #0x8f23000
00686A8C4  ldr      x0, [x0, #0xd48]
00686A8C8  bl       #0x382bd14 ; 
00686A8CC  mov      w8, #1
00686A8D0  strb     w8, [x23, #0xbae]
00686A8D4  adrp     x8, #0x8f23000
00686A8D8  ldr      x8, [x8, #0xd48]
00686A8DC  ldr      x1, [x8]
00686A8E0  ldrb     w8, [x1, #0x53]
00686A8E4  tbnz     w8, #5, #0x686a8f0
00686A8E8  ldr      x1, [x20, #0x90]
00686A8EC  b        #0x686a900 ; 
00686A8F0  ldr      x8, [x1, #0x60]
00686A8F4  mov      x0, x20
00686A8F8  blr      x8
00686A8FC  mov      x1, x0
00686A900  mov      x0, x19
00686A904  bl       #0x686b1c0 ; HotFix.BattleLogic.HeroComponentRandomSkill$$AddRejectSkills
00686A908  mov      x0, sp
00686A90C  bl       #0x6866604 ; HotFix.BattleLogic.HeroSkillCount$$IsMax
00686A910  tbz      w0, #0, #0x686a920
00686A914  mov      x0, x19
00686A918  mov      w1, w21
00686A91C  bl       #0x6869e18 ; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveRandomSkill
00686A920  ldr      x0, [x19, #0x50]
00686A924  cbz      x0, #0x686adec
00686A928  adrp     x8, #0x8f24000
00686A92C  ldr      x8, [x8, #0x50]
00686A930  mov      w1, w21
00686A934  ldr      x2, [x8]
00686A938  bl       #0x524e0bc ; Rock.Collections.OrderedHashSet<int>$$Add
00686A93C  mov      x0, x19
00686A940  mov      w1, w22
00686A944  bl       #0x6869e9c ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetDeltaWeightPercent
00686A948  mov      x2, x0
00686A94C  mov      x0, x19
00686A950  mov      w1, w22
00686A954  bl       #0x686a17c ; HotFix.BattleLogic.HeroComponentRandomSkill$$AdjustWeightsForSkillGroup
00686A958  adrp     x8, #0x9591000
00686A95C  ldrb     w8, [x8, #0xa4b]
00686A960  cbnz     w8, #0x686a97c
00686A964  adrp     x0, #0x8ee5000
00686A968  ldr      x0, [x0, #0xb28]
00686A96C  bl       #0x382bd14 ; 
00686A970  mov      w8, #1
00686A974  adrp     x9, #0x9591000
00686A978  strb     w8, [x9, #0xa4b]
00686A97C  adrp     x8, #0x8ee5000
00686A980  ldr      x8, [x8, #0xb28]
00686A984  ldr      x1, [x8]
00686A988  ldrb     w8, [x1, #0x53]
00686A98C  tbnz     w8, #5, #0x686a998
00686A990  ldr      x20, [x19, #0x20]
00686A994  b        #0x686a9a8 ; 
00686A998  ldr      x8, [x1, #0x60]
00686A99C  mov      x0, x19
00686A9A0  blr      x8
00686A9A4  mov      x20, x0
00686A9A8  cbz      x20, #0x686adec
00686A9AC  adrp     x21, #0x9598000
00686A9B0  ldrb     w8, [x21, #0xfcc]
00686A9B4  cbnz     w8, #0x686a9cc
00686A9B8  adrp     x0, #0x8f06000
00686A9BC  ldr      x0, [x0, #0x470]
00686A9C0  bl       #0x382bd14 ; 
00686A9C4  mov      w8, #1
00686A9C8  strb     w8, [x21, #0xfcc]
00686A9CC  adrp     x8, #0x8f06000
00686A9D0  ldr      x8, [x8, #0x470]
00686A9D4  ldr      x1, [x8]
00686A9D8  ldrb     w8, [x1, #0x53]
00686A9DC  tbnz     w8, #5, #0x686a9e8
00686A9E0  ldr      x0, [x20, #0x200]
00686A9E4  b        #0x686a9f4 ; 
00686A9E8  ldr      x8, [x1, #0x60]
00686A9EC  mov      x0, x20
00686A9F0  blr      x8
00686A9F4  cbz      x0, #0x686adec
00686A9F8  mov      x1, xzr
00686A9FC  bl       #0x64d17c4 ; LocalModels.LocalModelManager$$GetSkill_SynthesisElements
00686AA00  cbz      x0, #0x686adec
00686AA04  adrp     x10, #0x8f23000
00686AA08  ldr      x8, [x0]
00686AA0C  ldr      x10, [x10, #0xfc0]
00686AA10  mov      x20, x0
00686AA14  ldrh     w9, [x8, #0x12e]
00686AA18  ldr      x1, [x10]
00686AA1C  cbz      x9, #0x686aa40
00686AA20  ldr      x10, [x8, #0xb0]
00686AA24  add      x10, x10, #8
00686AA28  ldur     x11, [x10, #-8]
00686AA2C  cmp      x11, x1
00686AA30  b.eq     #0x686aa50
00686AA34  subs     x9, x9, #1
00686AA38  add      x10, x10, #0x10
00686AA3C  b.ne     #0x686aa28
00686AA40  mov      x0, x20
00686AA44  mov      w2, wzr
00686AA48  bl       #0x3a7e710 ; 
00686AA4C  b        #0x686aa5c ; 
00686AA50  ldrsw    x9, [x10]
00686AA54  add      x8, x8, x9, lsl #4
00686AA58  add      x0, x8, #0x138
00686AA5C  ldp      x8, x1, [x0]
00686AA60  mov      x0, x20
00686AA64  blr      x8
00686AA68  mov      x20, x0
00686AA6C  cbz      x0, #0x686adf8
00686AA70  adrp     x28, #0x8ebf000
00686AA74  adrp     x21, #0x8f23000
00686AA78  adrp     x22, #0x8f23000
00686AA7C  adrp     x24, #0x8f23000
00686AA80  adrp     x23, #0x8f23000
00686AA84  ldr      x28, [x28, #0x4f0]
00686AA88  ldr      x21, [x21, #0xfc8]
00686AA8C  ldr      x22, [x22, #0xfd8]
00686AA90  ldr      x24, [x24, #0xfd0]
00686AA94  ldr      x23, [x23, #0xfe0]
00686AA98  adrp     x29, #0x959b000
00686AA9C  mov      w25, #1
00686AAA0  ldr      x8, [x20]
00686AAA4  ldr      x1, [x28]
00686AAA8  ldrh     w9, [x8, #0x12e]
00686AAAC  cbz      x9, #0x686aad0
00686AAB0  ldr      x10, [x8, #0xb0]
00686AAB4  add      x10, x10, #8
00686AAB8  ldur     x11, [x10, #-8]
00686AABC  cmp      x11, x1
00686AAC0  b.eq     #0x686aae0
00686AAC4  subs     x9, x9, #1
00686AAC8  add      x10, x10, #0x10
00686AACC  b.ne     #0x686aab8
00686AAD0  mov      x0, x20
00686AAD4  mov      w2, wzr
00686AAD8  bl       #0x3a7e710 ; 
00686AADC  b        #0x686aaec ; 
00686AAE0  ldrsw    x9, [x10]
00686AAE4  add      x8, x8, x9, lsl #4
00686AAE8  add      x0, x8, #0x138
00686AAEC  ldp      x8, x1, [x0]
00686AAF0  mov      x0, x20
00686AAF4  blr      x8
00686AAF8  tbz      w0, #0, #0x686ad58
00686AAFC  ldr      x8, [x20]
00686AB00  ldr      x1, [x21]
00686AB04  ldrh     w9, [x8, #0x12e]
00686AB08  cbz      x9, #0x686ab2c
00686AB0C  ldr      x10, [x8, #0xb0]
00686AB10  add      x10, x10, #8
00686AB14  ldur     x11, [x10, #-8]
00686AB18  cmp      x11, x1
00686AB1C  b.eq     #0x686ab3c
00686AB20  subs     x9, x9, #1
00686AB24  add      x10, x10, #0x10
00686AB28  b.ne     #0x686ab14
00686AB2C  mov      x0, x20
00686AB30  mov      w2, wzr
00686AB34  bl       #0x3a7e710 ; 
00686AB38  b        #0x686ab48 ; 
00686AB3C  ldrsw    x9, [x10]
00686AB40  add      x8, x8, x9, lsl #4
00686AB44  add      x0, x8, #0x138
00686AB48  ldp      x8, x1, [x0]
00686AB4C  mov      x0, x20
00686AB50  blr      x8
00686AB54  mov      x27, x0
00686AB58  cbz      x0, #0x686ade4
00686AB5C  ldrb     w8, [x29, #0xba8]
00686AB60  cbnz     w8, #0x686ab70
00686AB64  mov      x0, x22
00686AB68  bl       #0x382bd14 ; 
00686AB6C  strb     w25, [x29, #0xba8]
00686AB70  ldr      x1, [x22]
00686AB74  ldrb     w8, [x1, #0x53]
00686AB78  tbnz     w8, #5, #0x686ab84
00686AB7C  ldr      w26, [x27, #0x30]
00686AB80  b        #0x686ab94 ; 
00686AB84  ldr      x8, [x1, #0x60]
00686AB88  mov      x0, x27
00686AB8C  blr      x8
00686AB90  mov      w26, w0
00686AB94  ldr      x0, [x19, #0x50]
00686AB98  cbz      x0, #0x686ade8
00686AB9C  ldr      x2, [x24]
00686ABA0  mov      w1, w26
00686ABA4  bl       #0x524c9b0 ; Rock.Collections.OrderedHashSet<int>$$Contains
00686ABA8  tbnz     w0, #0, #0x686aaa0
00686ABAC  adrp     x8, #0x959b000
00686ABB0  ldrb     w8, [x8, #0xba9]
00686ABB4  cbnz     w8, #0x686abc8
00686ABB8  mov      x0, x23
00686ABBC  bl       #0x382bd14 ; 
00686ABC0  adrp     x8, #0x959b000
00686ABC4  strb     w25, [x8, #0xba9]
00686ABC8  ldr      x1, [x23]
00686ABCC  ldrb     w8, [x1, #0x53]
00686ABD0  tbnz     w8, #5, #0x686abdc
00686ABD4  ldr      w1, [x27, #0x24]
00686ABD8  b        #0x686abec ; 
00686ABDC  ldr      x8, [x1, #0x60]
00686ABE0  mov      x0, x27
00686ABE4  blr      x8
00686ABE8  mov      w1, w0
00686ABEC  mov      x0, x19
00686ABF0  bl       #0x686b244 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<AddSkill>g__SkillSuit|34_0
00686ABF4  tbz      w0, #0, #0x686aaa0
00686ABF8  adrp     x8, #0x959b000
00686ABFC  ldrb     w8, [x8, #0xbaa]
00686AC00  cbnz     w8, #0x686ac18
00686AC04  adrp     x0, #0x8f23000
00686AC08  ldr      x0, [x0, #0xfe8]
00686AC0C  bl       #0x382bd14 ; 
00686AC10  adrp     x8, #0x959b000
00686AC14  strb     w25, [x8, #0xbaa]
00686AC18  adrp     x8, #0x8f23000
00686AC1C  ldr      x8, [x8, #0xfe8]
00686AC20  ldr      x1, [x8]
00686AC24  ldrb     w8, [x1, #0x53]
00686AC28  tbnz     w8, #5, #0x686ac34
00686AC2C  ldr      w1, [x27, #0x28]
00686AC30  b        #0x686ac44 ; 
00686AC34  ldr      x8, [x1, #0x60]
00686AC38  mov      x0, x27
00686AC3C  blr      x8
00686AC40  mov      w1, w0
00686AC44  mov      x0, x19
00686AC48  bl       #0x686b244 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<AddSkill>g__SkillSuit|34_0
00686AC4C  tbz      w0, #0, #0x686aaa0
00686AC50  adrp     x8, #0x959b000
00686AC54  ldrb     w8, [x8, #0xbab]
00686AC58  cbnz     w8, #0x686ac70
00686AC5C  adrp     x0, #0x8f23000
00686AC60  ldr      x0, [x0, #0xff0]
00686AC64  bl       #0x382bd14 ; 
00686AC68  adrp     x8, #0x959b000
00686AC6C  strb     w25, [x8, #0xbab]
00686AC70  adrp     x8, #0x8f23000
00686AC74  ldr      x8, [x8, #0xff0]
00686AC78  ldr      x1, [x8]
00686AC7C  ldrb     w8, [x1, #0x53]
00686AC80  tbnz     w8, #5, #0x686ac8c
00686AC84  ldr      w1, [x27, #0x2c]
00686AC88  b        #0x686ac9c ; 
00686AC8C  ldr      x8, [x1, #0x60]
00686AC90  mov      x0, x27
00686AC94  blr      x8
00686AC98  mov      w1, w0
00686AC9C  mov      x0, x19
00686ACA0  bl       #0x686b244 ; HotFix.BattleLogic.HeroComponentRandomSkill$$<AddSkill>g__SkillSuit|34_0
00686ACA4  tbz      w0, #0, #0x686aaa0
00686ACA8  ldr      x0, [x19, #0x50]
00686ACAC  cbz      x0, #0x686adf4
00686ACB0  adrp     x8, #0x8f24000
00686ACB4  ldr      x8, [x8, #0x50]
00686ACB8  ldr      x2, [x8]
00686ACBC  mov      w1, w26
00686ACC0  bl       #0x524e0bc ; Rock.Collections.OrderedHashSet<int>$$Add
00686ACC4  adrp     x8, #0x9591000
00686ACC8  ldrb     w8, [x8, #0xa4b]
00686ACCC  cbnz     w8, #0x686ace4
00686ACD0  adrp     x0, #0x8ee5000
00686ACD4  ldr      x0, [x0, #0xb28]
00686ACD8  bl       #0x382bd14 ; 
00686ACDC  adrp     x8, #0x9591000
00686ACE0  strb     w25, [x8, #0xa4b]
00686ACE4  adrp     x8, #0x8ee5000
00686ACE8  ldr      x8, [x8, #0xb28]
00686ACEC  ldr      x1, [x8]
00686ACF0  ldrb     w8, [x1, #0x53]
00686ACF4  tbnz     w8, #5, #0x686ad00
00686ACF8  ldr      x27, [x19, #0x20]
00686ACFC  b        #0x686ad10 ; 
00686AD00  ldr      x8, [x1, #0x60]
00686AD04  mov      x0, x19
00686AD08  blr      x8
00686AD0C  mov      x27, x0
00686AD10  adrp     x8, #0x8f23000
00686AD14  ldr      x8, [x8, #0x140]
00686AD18  ldr      x1, [x8]
00686AD1C  ldrb     w8, [x1, #0x53]
00686AD20  tbnz     w8, #5, #0x686ad2c
00686AD24  ldr      x1, [x19, #0x30]
00686AD28  b        #0x686ad3c ; 
00686AD2C  ldr      x8, [x1, #0x60]
00686AD30  mov      x0, x19
00686AD34  blr      x8
00686AD38  mov      x1, x0
00686AD3C  cbz      x27, #0x686adf0
00686AD40  mov      x0, x27
00686AD44  mov      w2, w26
00686AD48  mov      w3, wzr
00686AD4C  mov      x4, xzr
00686AD50  bl       #0x6a0dd34 ; HotFix.BattleLogic.BattleWorldContext$$AddSkillToCharacter
00686AD54  b        #0x686aaa0 ; 
00686AD58  mov      x21, xzr
00686AD5C  cbz      x20, #0x686adc0
00686AD60  adrp     x10, #0x8ebf000
00686AD64  ldr      x8, [x20]
00686AD68  ldr      x10, [x10, #0x4e8]
00686AD6C  ldrh     w9, [x8, #0x12e]
00686AD70  ldr      x1, [x10]
00686AD74  cbz      x9, #0x686ad98
00686AD78  ldr      x10, [x8, #0xb0]
00686AD7C  add      x10, x10, #8
00686AD80  ldur     x11, [x10, #-8]
00686AD84  cmp      x11, x1
00686AD88  b.eq     #0x686ada8
00686AD8C  subs     x9, x9, #1
00686AD90  add      x10, x10, #0x10
00686AD94  b.ne     #0x686ad80
00686AD98  mov      x0, x20
00686AD9C  mov      w2, wzr
00686ADA0  bl       #0x3a7e710 ; 
00686ADA4  b        #0x686adb4 ; 
00686ADA8  ldrsw    x9, [x10]
00686ADAC  add      x8, x8, x9, lsl #4
00686ADB0  add      x0, x8, #0x138
00686ADB4  ldp      x8, x1, [x0]
00686ADB8  mov      x0, x20
00686ADBC  blr      x8
00686ADC0  cbnz     x21, #0x686adfc
00686ADC4  ldp      x20, x19, [sp, #0x60]
00686ADC8  ldp      x22, x21, [sp, #0x50]
00686ADCC  ldp      x24, x23, [sp, #0x40]
00686ADD0  ldp      x26, x25, [sp, #0x30]
00686ADD4  ldp      x28, x27, [sp, #0x20]
00686ADD8  ldp      x29, x30, [sp, #0x10]
00686ADDC  add      sp, sp, #0x70
00686ADE0  ret      
00686ADE4  bl       #0x382bfb8 ; 
00686ADE8  bl       #0x382bfb8 ; 
00686ADEC  bl       #0x382bfb8 ; 
00686ADF0  bl       #0x382bfb8 ; 
00686ADF4  bl       #0x382bfb8 ; 
00686ADF8  bl       #0x382bfb8 ; 
00686ADFC  mov      x0, x21
00686AE00  bl       #0x382bfb0 ; 
00686AE04  b        #0x686ae4c ; 
00686AE08  b        #0x686ae4c ; 
00686AE0C  b        #0x686ae4c ; 
00686AE10  b        #0x686ae4c ; 
00686AE14  b        #0x686ae4c ; 
00686AE18  b        #0x686ae4c ; 
00686AE1C  b        #0x686ae4c ; 
00686AE20  b        #0x686ae4c ; 
00686AE24  b        #0x686ae4c ; 
00686AE28  b        #0x686ae4c ; 
00686AE2C  b        #0x686ae4c ; 
00686AE30  b        #0x686ae4c ; 
00686AE34  b        #0x686ae4c ; 
00686AE38  b        #0x686ae4c ; 
00686AE3C  b        #0x686ae4c ; 
00686AE40  b        #0x686ae4c ; 
00686AE44  b        #0x686ae4c ; 
00686AE48  b        #0x686ae4c ; 
00686AE4C  mov      x19, x0
00686AE50  cmp      w1, #1
00686AE54  b.ne     #0x686ae6c
00686AE58  mov      x0, x19
00686AE5C  bl       #0x89eda50 ; 
00686AE60  ldr      x21, [x0]
00686AE64  bl       #0x89eda60 ; 
00686AE68  b        #0x686ad5c ; 
00686AE6C  mov      x21, xzr
00686AE70  b        #0x686ae78 ; 
00686AE74  mov      x19, x0
00686AE78  cbz      x20, #0x686aedc
00686AE7C  adrp     x10, #0x8ebf000
00686AE80  ldr      x8, [x20]
00686AE84  ldr      x10, [x10, #0x4e8]
00686AE88  ldrh     w9, [x8, #0x12e]
00686AE8C  ldr      x1, [x10]
00686AE90  cbz      x9, #0x686aeb4
00686AE94  ldr      x10, [x8, #0xb0]
00686AE98  add      x10, x10, #8
00686AE9C  ldur     x11, [x10, #-8]
00686AEA0  cmp      x11, x1
00686AEA4  b.eq     #0x686aec4
00686AEA8  subs     x9, x9, #1
00686AEAC  add      x10, x10, #0x10
00686AEB0  b.ne     #0x686ae9c
00686AEB4  mov      x0, x20
00686AEB8  mov      w2, wzr
00686AEBC  bl       #0x3a7e710 ; 
00686AEC0  b        #0x686aed0 ; 
00686AEC4  ldrsw    x9, [x10]
00686AEC8  add      x8, x8, x9, lsl #4
00686AECC  add      x0, x8, #0x138
00686AED0  ldp      x8, x1, [x0]
00686AED4  mov      x0, x20
00686AED8  blr      x8
00686AEDC  cbnz     x21, #0x686aee8
00686AEE0  mov      x0, x19
00686AEE4  bl       #0x3b56bfc ; 
00686AEE8  mov      x0, x21
00686AEEC  bl       #0x382bfb0 ; 
00686AEF0  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$TryRemoveSkill
; RVA 0x686B2F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B2F8  str      x30, [sp, #-0x30]!
00686B2FC  stp      x22, x21, [sp, #0x10]
00686B300  stp      x20, x19, [sp, #0x20]
00686B304  adrp     x21, #0x959b000
00686B308  adrp     x22, #0x8f24000
00686B30C  ldrb     w8, [x21, #0xa42]
00686B310  ldr      x22, [x22, #0xa0]
00686B314  mov      w19, w1
00686B318  mov      x20, x0
00686B31C  tbnz     w8, #0, #0x686b34c
00686B320  adrp     x0, #0x8f24000
00686B324  ldr      x0, [x0, #0xa0]
00686B328  bl       #0x382bd14 ; 
00686B32C  adrp     x0, #0x8f23000
00686B330  ldr      x0, [x0, #0xfd0]
00686B334  bl       #0x382bd14 ; 
00686B338  adrp     x0, #0x8f23000
00686B33C  ldr      x0, [x0, #0xfb0]
00686B340  bl       #0x382bd14 ; 
00686B344  mov      w8, #1
00686B348  strb     w8, [x21, #0xa42]
00686B34C  ldr      x2, [x22]
00686B350  ldrb     w8, [x2, #0x53]
00686B354  tbnz     w8, #5, #0x686b3b0
00686B358  cbz      w19, #0x686b3cc
00686B35C  ldr      x0, [x20, #0x50]
00686B360  cbz      x0, #0x686b3f0
00686B364  adrp     x8, #0x8f23000
00686B368  ldr      x8, [x8, #0xfd0]
00686B36C  mov      w1, w19
00686B370  ldr      x2, [x8]
00686B374  bl       #0x524c9b0 ; Rock.Collections.OrderedHashSet<int>$$Contains
00686B378  tbz      w0, #0, #0x686b3e0
00686B37C  mov      x0, x20
00686B380  mov      w1, w19
00686B384  bl       #0x686b5a0 ; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveSkill
00686B388  ldr      x0, [x20, #0x50]
00686B38C  cbz      x0, #0x686b3f0
00686B390  adrp     x8, #0x8f23000
00686B394  ldr      x8, [x8, #0xfb0]
00686B398  mov      w1, w19
00686B39C  ldp      x20, x19, [sp, #0x20]
00686B3A0  ldp      x22, x21, [sp, #0x10]
00686B3A4  ldr      x2, [x8]
00686B3A8  ldr      x30, [sp], #0x30
00686B3AC  b        #0x524cfc8 ; Rock.Collections.OrderedHashSet<int>$$Remove
00686B3B0  ldr      x3, [x2, #0x60]
00686B3B4  mov      x0, x20
00686B3B8  mov      w1, w19
00686B3BC  ldp      x20, x19, [sp, #0x20]
00686B3C0  ldp      x22, x21, [sp, #0x10]
00686B3C4  ldr      x30, [sp], #0x30
00686B3C8  br       x3
00686B3CC  mov      x0, x20
00686B3D0  ldp      x20, x19, [sp, #0x20]
00686B3D4  ldp      x22, x21, [sp, #0x10]
00686B3D8  ldr      x30, [sp], #0x30
00686B3DC  b        #0x686b3f4 ; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveAllSkill
00686B3E0  ldp      x20, x19, [sp, #0x20]
00686B3E4  ldp      x22, x21, [sp, #0x10]
00686B3E8  ldr      x30, [sp], #0x30
00686B3EC  ret      
00686B3F0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveSkill
; RVA 0x686B5A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B5A0  str      x30, [sp, #-0x30]!
00686B5A4  stp      x22, x21, [sp, #0x10]
00686B5A8  stp      x20, x19, [sp, #0x20]
00686B5AC  adrp     x21, #0x959b000
00686B5B0  adrp     x22, #0x8f24000
00686B5B4  ldrb     w8, [x21, #0xa43]
00686B5B8  ldr      x22, [x22, #0xd8]
00686B5BC  mov      w19, w1
00686B5C0  mov      x20, x0
00686B5C4  tbnz     w8, #0, #0x686b600
00686B5C8  adrp     x0, #0x8f23000
00686B5CC  ldr      x0, [x0, #0x140]
00686B5D0  bl       #0x382bd14 ; 
00686B5D4  adrp     x0, #0x8f24000
00686B5D8  ldr      x0, [x0, #0xd8]
00686B5DC  bl       #0x382bd14 ; 
00686B5E0  adrp     x0, #0x8edb000
00686B5E4  ldr      x0, [x0, #0x180]
00686B5E8  bl       #0x382bd14 ; 
00686B5EC  adrp     x0, #0x8f24000
00686B5F0  ldr      x0, [x0, #0xe0]
00686B5F4  bl       #0x382bd14 ; 
00686B5F8  mov      w8, #1
00686B5FC  strb     w8, [x21, #0xa43]
00686B600  ldr      x2, [x22]
00686B604  ldrb     w8, [x2, #0x53]
00686B608  tbnz     w8, #5, #0x686b650
00686B60C  adrp     x21, #0x9591000
00686B610  ldrb     w8, [x21, #0xa4b]
00686B614  cbnz     w8, #0x686b62c
00686B618  adrp     x0, #0x8ee5000
00686B61C  ldr      x0, [x0, #0xb28]
00686B620  bl       #0x382bd14 ; 
00686B624  mov      w8, #1
00686B628  strb     w8, [x21, #0xa4b]
00686B62C  adrp     x8, #0x8ee5000
00686B630  ldr      x8, [x8, #0xb28]
00686B634  adrp     x22, #0x8f23000
00686B638  ldr      x1, [x8]
00686B63C  ldrb     w8, [x1, #0x53]
00686B640  ldr      x22, [x22, #0x140]
00686B644  tbnz     w8, #5, #0x686b66c
00686B648  ldr      x21, [x20, #0x20]
00686B64C  b        #0x686b67c ; 
00686B650  ldr      x3, [x2, #0x60]
00686B654  mov      x0, x20
00686B658  mov      w1, w19
00686B65C  ldp      x20, x19, [sp, #0x20]
00686B660  ldp      x22, x21, [sp, #0x10]
00686B664  ldr      x30, [sp], #0x30
00686B668  br       x3
00686B66C  ldr      x8, [x1, #0x60]
00686B670  mov      x0, x20
00686B674  blr      x8
00686B678  mov      x21, x0
00686B67C  ldr      x1, [x22]
00686B680  ldrb     w8, [x1, #0x53]
00686B684  tbnz     w8, #5, #0x686b690
00686B688  ldr      x1, [x20, #0x30]
00686B68C  b        #0x686b6a0 ; 
00686B690  ldr      x8, [x1, #0x60]
00686B694  mov      x0, x20
00686B698  blr      x8
00686B69C  mov      x1, x0
00686B6A0  cbz      x21, #0x686b6f8
00686B6A4  mov      x0, x21
00686B6A8  mov      w2, w19
00686B6AC  mov      x3, xzr
00686B6B0  bl       #0x6a0d960 ; HotFix.BattleLogic.BattleWorldContext$$RemoveSkillForCharacter
00686B6B4  ldr      x0, [x20, #0x48]
00686B6B8  cbz      x0, #0x686b6f8
00686B6BC  adrp     x8, #0x8f24000
00686B6C0  ldr      x8, [x8, #0xe0]
00686B6C4  mov      w1, w19
00686B6C8  ldr      x2, [x8]
00686B6CC  bl       #0x521f6bc ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$Remove
00686B6D0  ldr      x0, [x20, #0x58]
00686B6D4  cbz      x0, #0x686b6f8
00686B6D8  adrp     x8, #0x8edb000
00686B6DC  ldr      x8, [x8, #0x180]
00686B6E0  mov      w1, w19
00686B6E4  ldp      x20, x19, [sp, #0x20]
00686B6E8  ldp      x22, x21, [sp, #0x10]
00686B6EC  ldr      x2, [x8]
00686B6F0  ldr      x30, [sp], #0x30
00686B6F4  b        #0x4d65db8 ; System.Collections.Generic.List<int>$$Remove
00686B6F8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveAllSkill
; RVA 0x686B3F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B3F4  sub      sp, sp, #0x60
00686B3F8  stp      x30, x21, [sp, #0x40]
00686B3FC  stp      x20, x19, [sp, #0x50]
00686B400  adrp     x20, #0x959b000
00686B404  adrp     x21, #0x8f24000
00686B408  ldrb     w8, [x20, #0xa44]
00686B40C  ldr      x21, [x21, #0xa8]
00686B410  mov      x19, x0
00686B414  tbnz     w8, #0, #0x686b468
00686B418  adrp     x0, #0x8f24000
00686B41C  ldr      x0, [x0, #0xb0]
00686B420  bl       #0x382bd14 ; 
00686B424  adrp     x0, #0x8f24000
00686B428  ldr      x0, [x0, #0xb8]
00686B42C  bl       #0x382bd14 ; 
00686B430  adrp     x0, #0x8f24000
00686B434  ldr      x0, [x0, #0xc0]
00686B438  bl       #0x382bd14 ; 
00686B43C  adrp     x0, #0x8f24000
00686B440  ldr      x0, [x0, #0xa8]
00686B444  bl       #0x382bd14 ; 
00686B448  adrp     x0, #0x8f24000
00686B44C  ldr      x0, [x0, #0xc8]
00686B450  bl       #0x382bd14 ; 
00686B454  adrp     x0, #0x8f24000
00686B458  ldr      x0, [x0, #0xd0]
00686B45C  bl       #0x382bd14 ; 
00686B460  mov      w8, #1
00686B464  strb     w8, [x20, #0xa44]
00686B468  ldr      x1, [x21]
00686B46C  ldrb     w8, [x1, #0x53]
00686B470  tbnz     w8, #5, #0x686b4d0
00686B474  stp      xzr, xzr, [sp, #0x20]
00686B478  str      xzr, [sp, #0x30]
00686B47C  ldr      x0, [x19, #0x50]
00686B480  cbz      x0, #0x686b524
00686B484  adrp     x8, #0x8f24000
00686B488  ldr      x8, [x8, #0xd0]
00686B48C  ldr      x1, [x8]
00686B490  add      x8, sp, #8
00686B494  bl       #0x524d2d4 ; Rock.Collections.OrderedHashSet<int>$$GetEnumerator
00686B498  ldur     q0, [sp, #8]
00686B49C  ldr      x8, [sp, #0x18]
00686B4A0  adrp     x20, #0x8f24000
00686B4A4  str      q0, [sp, #0x20]
00686B4A8  str      x8, [sp, #0x30]
00686B4AC  ldr      x20, [x20, #0xb0]
00686B4B0  ldr      x1, [x20]
00686B4B4  add      x0, sp, #0x20
00686B4B8  bl       #0x60e26a8 ; Rock.Collections.OrderedHashSet.Enumerator<int>$$MoveNext
00686B4BC  tbz      w0, #0, #0x686b4e8
00686B4C0  ldr      w1, [sp, #0x30]
00686B4C4  mov      x0, x19
00686B4C8  bl       #0x686b5a0 ; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveSkill
00686B4CC  b        #0x686b4b0 ; 
00686B4D0  ldr      x2, [x1, #0x60]
00686B4D4  mov      x0, x19
00686B4D8  ldp      x20, x19, [sp, #0x50]
00686B4DC  ldp      x30, x21, [sp, #0x40]
00686B4E0  add      sp, sp, #0x60
00686B4E4  br       x2
00686B4E8  adrp     x8, #0x8f24000
00686B4EC  ldr      x8, [x8, #0xb8]
00686B4F0  add      x0, sp, #0x20
00686B4F4  ldr      x1, [x8]
00686B4F8  bl       #0x60e2764 ; Rock.Collections.OrderedHashSet.Enumerator<int>$$System.IDisposable.Dispose
00686B4FC  ldr      x0, [x19, #0x50]
00686B500  cbz      x0, #0x686b524
00686B504  adrp     x8, #0x8f24000
00686B508  ldr      x8, [x8, #0xc8]
00686B50C  ldr      x1, [x8]
00686B510  bl       #0x524c948 ; Rock.Collections.OrderedHashSet<int>$$Clear
00686B514  ldp      x20, x19, [sp, #0x50]
00686B518  ldp      x30, x21, [sp, #0x40]
00686B51C  add      sp, sp, #0x60
00686B520  ret      
00686B524  bl       #0x382bfb8 ; 
00686B528  b        #0x686b52c ; 
00686B52C  mov      x21, x0
00686B530  cmp      w1, #1
00686B534  b.ne     #0x686b568
00686B538  mov      x0, x21
00686B53C  bl       #0x89eda50 ; 
00686B540  ldr      x20, [x0]
00686B544  bl       #0x89eda60 ; 
00686B548  adrp     x8, #0x8f24000
00686B54C  ldr      x8, [x8, #0xb8]
00686B550  add      x0, sp, #0x20
00686B554  ldr      x1, [x8]
00686B558  bl       #0x60e2764 ; Rock.Collections.OrderedHashSet.Enumerator<int>$$System.IDisposable.Dispose
00686B55C  cbz      x20, #0x686b4fc
00686B560  mov      x0, x20
00686B564  bl       #0x382bfb0 ; 
00686B568  mov      x20, xzr
00686B56C  b        #0x686b574 ; 
00686B570  mov      x21, x0
00686B574  adrp     x8, #0x8f24000
00686B578  ldr      x8, [x8, #0xb8]
00686B57C  ldr      x1, [x8]
00686B580  add      x0, sp, #0x20
00686B584  bl       #0x60e2764 ; Rock.Collections.OrderedHashSet.Enumerator<int>$$System.IDisposable.Dispose
00686B588  cbnz     x20, #0x686b594
00686B58C  mov      x0, x21
00686B590  bl       #0x3b56bfc ; 
00686B594  mov      x0, x20
00686B598  bl       #0x382bfb0 ; 
00686B59C  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillFlags
; RVA 0x686AFF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686AFF8  str      x30, [sp, #-0x30]!
00686AFFC  stp      x22, x21, [sp, #0x10]
00686B000  stp      x20, x19, [sp, #0x20]
00686B004  adrp     x21, #0x959b000
00686B008  adrp     x22, #0x8f24000
00686B00C  ldrb     w8, [x21, #0xa45]
00686B010  ldr      x22, [x22, #0x78]
00686B014  mov      x19, x1
00686B018  mov      x20, x0
00686B01C  tbnz     w8, #0, #0x686b034
00686B020  adrp     x0, #0x8f24000
00686B024  ldr      x0, [x0, #0x78]
00686B028  bl       #0x382bd14 ; 
00686B02C  mov      w8, #1
00686B030  strb     w8, [x21, #0xa45]
00686B034  ldr      x2, [x22]
00686B038  ldrb     w8, [x2, #0x53]
00686B03C  tbnz     w8, #5, #0x686b094
00686B040  cbz      x19, #0x686b084
00686B044  ldr      x8, [x19, #0x18]
00686B048  cbz      x8, #0x686b084
00686B04C  cmp      w8, #1
00686B050  b.lt     #0x686b084
00686B054  mov      x21, xzr
00686B058  add      x22, x19, #0x20
00686B05C  cmp      x21, w8, uxtw
00686B060  b.hs     #0x686b0b0
00686B064  ldr      x0, [x20, #0x88]
00686B068  cbz      x0, #0x686b0b4
00686B06C  ldr      w1, [x22, x21, lsl #2]
00686B070  bl       #0x686b6fc ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillFlag
00686B074  ldr      w8, [x19, #0x18]
00686B078  add      x21, x21, #1
00686B07C  cmp      x21, w8, sxtw
00686B080  b.lt     #0x686b05c
00686B084  ldp      x20, x19, [sp, #0x20]
00686B088  ldp      x22, x21, [sp, #0x10]
00686B08C  ldr      x30, [sp], #0x30
00686B090  ret      
00686B094  ldr      x3, [x2, #0x60]
00686B098  mov      x0, x20
00686B09C  mov      x1, x19
00686B0A0  ldp      x20, x19, [sp, #0x20]
00686B0A4  ldp      x22, x21, [sp, #0x10]
00686B0A8  ldr      x30, [sp], #0x30
00686B0AC  br       x3
00686B0B0  bl       #0x382bfc0 ; 
00686B0B4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillRejectFlags
; RVA 0x686B0B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B0B8  str      x30, [sp, #-0x30]!
00686B0BC  stp      x22, x21, [sp, #0x10]
00686B0C0  stp      x20, x19, [sp, #0x20]
00686B0C4  adrp     x21, #0x959b000
00686B0C8  adrp     x22, #0x8f24000
00686B0CC  ldrb     w8, [x21, #0xa46]
00686B0D0  ldr      x22, [x22, #0x80]
00686B0D4  mov      w19, w1
00686B0D8  mov      x20, x0
00686B0DC  tbnz     w8, #0, #0x686b0f4
00686B0E0  adrp     x0, #0x8f24000
00686B0E4  ldr      x0, [x0, #0x80]
00686B0E8  bl       #0x382bd14 ; 
00686B0EC  mov      w8, #1
00686B0F0  strb     w8, [x21, #0xa46]
00686B0F4  ldr      x2, [x22]
00686B0F8  ldrb     w8, [x2, #0x53]
00686B0FC  tbnz     w8, #5, #0x686b11c
00686B100  ldr      x0, [x20, #0x88]
00686B104  cbz      x0, #0x686b138
00686B108  mov      w1, w19
00686B10C  ldp      x20, x19, [sp, #0x20]
00686B110  ldp      x22, x21, [sp, #0x10]
00686B114  ldr      x30, [sp], #0x30
00686B118  b        #0x686b7bc ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillRejectFlag
00686B11C  ldr      x3, [x2, #0x60]
00686B120  mov      x0, x20
00686B124  mov      w1, w19
00686B128  ldp      x20, x19, [sp, #0x20]
00686B12C  ldp      x22, x21, [sp, #0x10]
00686B130  ldr      x30, [sp], #0x30
00686B134  br       x3
00686B138  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddRejectSkills
; RVA 0x686B1C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B1C0  str      x30, [sp, #-0x30]!
00686B1C4  stp      x22, x21, [sp, #0x10]
00686B1C8  stp      x20, x19, [sp, #0x20]
00686B1CC  adrp     x21, #0x959b000
00686B1D0  adrp     x22, #0x8f24000
00686B1D4  ldrb     w8, [x21, #0xa47]
00686B1D8  ldr      x22, [x22, #0x90]
00686B1DC  mov      x19, x1
00686B1E0  mov      x20, x0
00686B1E4  tbnz     w8, #0, #0x686b1fc
00686B1E8  adrp     x0, #0x8f24000
00686B1EC  ldr      x0, [x0, #0x90]
00686B1F0  bl       #0x382bd14 ; 
00686B1F4  mov      w8, #1
00686B1F8  strb     w8, [x21, #0xa47]
00686B1FC  ldr      x2, [x22]
00686B200  ldrb     w8, [x2, #0x53]
00686B204  tbnz     w8, #5, #0x686b224
00686B208  ldr      x0, [x20, #0x88]
00686B20C  cbz      x0, #0x686b240
00686B210  mov      x1, x19
00686B214  ldp      x20, x19, [sp, #0x20]
00686B218  ldp      x22, x21, [sp, #0x10]
00686B21C  ldr      x30, [sp], #0x30
00686B220  b        #0x686b87c ; HotFix.BattleLogic.HeroSkillCreator$$AddRejectSkills
00686B224  ldr      x3, [x2, #0x60]
00686B228  mov      x0, x20
00686B22C  mov      x1, x19
00686B230  ldp      x20, x19, [sp, #0x20]
00686B234  ldp      x22, x21, [sp, #0x10]
00686B238  ldr      x30, [sp], #0x30
00686B23C  br       x3
00686B240  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AddNeedSkill
; RVA 0x686B13C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B13C  str      x30, [sp, #-0x30]!
00686B140  stp      x22, x21, [sp, #0x10]
00686B144  stp      x20, x19, [sp, #0x20]
00686B148  adrp     x21, #0x959b000
00686B14C  adrp     x22, #0x8f24000
00686B150  ldrb     w8, [x21, #0xa48]
00686B154  ldr      x22, [x22, #0x88]
00686B158  mov      w19, w1
00686B15C  mov      x20, x0
00686B160  tbnz     w8, #0, #0x686b178
00686B164  adrp     x0, #0x8f24000
00686B168  ldr      x0, [x0, #0x88]
00686B16C  bl       #0x382bd14 ; 
00686B170  mov      w8, #1
00686B174  strb     w8, [x21, #0xa48]
00686B178  ldr      x2, [x22]
00686B17C  ldrb     w8, [x2, #0x53]
00686B180  tbnz     w8, #5, #0x686b1a0
00686B184  ldr      x0, [x20, #0x88]
00686B188  cbz      x0, #0x686b1bc
00686B18C  mov      w1, w19
00686B190  ldp      x20, x19, [sp, #0x20]
00686B194  ldp      x22, x21, [sp, #0x10]
00686B198  ldr      x30, [sp], #0x30
00686B19C  b        #0x686b93c ; HotFix.BattleLogic.HeroSkillCreator$$AddNewSkill
00686B1A0  ldr      x3, [x2, #0x60]
00686B1A4  mov      x0, x20
00686B1A8  mov      w1, w19
00686B1AC  ldp      x20, x19, [sp, #0x20]
00686B1B0  ldp      x22, x21, [sp, #0x10]
00686B1B4  ldr      x30, [sp], #0x30
00686B1B8  br       x3
00686B1BC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RemoveRandomSkill
; RVA 0x6869E18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869E18  str      x30, [sp, #-0x30]!
006869E1C  stp      x22, x21, [sp, #0x10]
006869E20  stp      x20, x19, [sp, #0x20]
006869E24  adrp     x21, #0x959b000
006869E28  adrp     x22, #0x8f24000
006869E2C  ldrb     w8, [x21, #0xa49]
006869E30  ldr      x22, [x22]
006869E34  mov      w19, w1
006869E38  mov      x20, x0
006869E3C  tbnz     w8, #0, #0x6869e54
006869E40  adrp     x0, #0x8f24000
006869E44  ldr      x0, [x0]
006869E48  bl       #0x382bd14 ; 
006869E4C  mov      w8, #1
006869E50  strb     w8, [x21, #0xa49]
006869E54  ldr      x2, [x22]
006869E58  ldrb     w8, [x2, #0x53]
006869E5C  tbnz     w8, #5, #0x6869e7c
006869E60  ldr      x0, [x20, #0x88]
006869E64  cbz      x0, #0x6869e98
006869E68  mov      w1, w19
006869E6C  ldp      x20, x19, [sp, #0x20]
006869E70  ldp      x22, x21, [sp, #0x10]
006869E74  ldr      x30, [sp], #0x30
006869E78  b        #0x686b9fc ; HotFix.BattleLogic.HeroSkillCreator$$RemoveRandomSkill
006869E7C  ldr      x3, [x2, #0x60]
006869E80  mov      x0, x20
006869E84  mov      w1, w19
006869E88  ldp      x20, x19, [sp, #0x20]
006869E8C  ldp      x22, x21, [sp, #0x10]
006869E90  ldr      x30, [sp], #0x30
006869E94  br       x3
006869E98  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$Init
; RVA 0x686BAC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686BAC4  stp      x30, x21, [sp, #-0x20]!
00686BAC8  stp      x20, x19, [sp, #0x10]
00686BACC  adrp     x20, #0x959b000
00686BAD0  adrp     x21, #0x8f24000
00686BAD4  ldrb     w8, [x20, #0xa4a]
00686BAD8  ldr      x21, [x21, #0x110]
00686BADC  mov      x19, x0
00686BAE0  tbnz     w8, #0, #0x686bb10
00686BAE4  adrp     x0, #0x8f24000
00686BAE8  ldr      x0, [x0, #0x118]
00686BAEC  bl       #0x382bd14 ; 
00686BAF0  adrp     x0, #0x8f24000
00686BAF4  ldr      x0, [x0, #0x110]
00686BAF8  bl       #0x382bd14 ; 
00686BAFC  adrp     x0, #0x8f24000
00686BB00  ldr      x0, [x0, #0x120]
00686BB04  bl       #0x382bd14 ; 
00686BB08  mov      w8, #1
00686BB0C  strb     w8, [x20, #0xa4a]
00686BB10  ldr      x1, [x21]
00686BB14  ldrb     w8, [x1, #0x53]
00686BB18  tbnz     w8, #5, #0x686bb58
00686BB1C  adrp     x20, #0x9591000
00686BB20  ldrb     w8, [x20, #0xa4b]
00686BB24  cbnz     w8, #0x686bb3c
00686BB28  adrp     x0, #0x8ee5000
00686BB2C  ldr      x0, [x0, #0xb28]
00686BB30  bl       #0x382bd14 ; 
00686BB34  mov      w8, #1
00686BB38  strb     w8, [x20, #0xa4b]
00686BB3C  adrp     x21, #0x8ee5000
00686BB40  ldr      x21, [x21, #0xb28]
00686BB44  ldr      x1, [x21]
00686BB48  ldrb     w8, [x1, #0x53]
00686BB4C  tbnz     w8, #5, #0x686bb6c
00686BB50  ldr      x0, [x19, #0x20]
00686BB54  b        #0x686bb78 ; 
00686BB58  ldr      x2, [x1, #0x60]
00686BB5C  mov      x0, x19
00686BB60  ldp      x20, x19, [sp, #0x10]
00686BB64  ldp      x30, x21, [sp], #0x20
00686BB68  br       x2
00686BB6C  ldr      x8, [x1, #0x60]
00686BB70  mov      x0, x19
00686BB74  blr      x8
00686BB78  cbz      x0, #0x686bc7c
00686BB7C  ldrb     w8, [x20, #0xa4b]
00686BB80  cbnz     w8, #0x686bb98
00686BB84  adrp     x0, #0x8ee5000
00686BB88  ldr      x0, [x0, #0xb28]
00686BB8C  bl       #0x382bd14 ; 
00686BB90  mov      w8, #1
00686BB94  strb     w8, [x20, #0xa4b]
00686BB98  ldr      x1, [x21]
00686BB9C  ldrb     w8, [x1, #0x53]
00686BBA0  tbnz     w8, #5, #0x686bbac
00686BBA4  ldr      x0, [x19, #0x20]
00686BBA8  b        #0x686bbb8 ; 
00686BBAC  ldr      x8, [x1, #0x60]
00686BBB0  mov      x0, x19
00686BBB4  blr      x8
00686BBB8  cbz      x0, #0x686bc7c
00686BBBC  mov      x1, xzr
00686BBC0  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00686BBC4  tbz      w0, #0, #0x686bbe4
00686BBC8  adrp     x8, #0x8f24000
00686BBCC  ldr      x8, [x8, #0x118]
00686BBD0  ldr      x0, [x8]
00686BBD4  bl       #0x382bfa0 ; 
00686BBD8  mov      x20, x0
00686BBDC  bl       #0x68662ac ; HotFix.BattleLogic.DankeSkillCreator$$.ctor
00686BBE0  b        #0x686bbfc ; 
00686BBE4  adrp     x8, #0x8f24000
00686BBE8  ldr      x8, [x8, #0x120]
00686BBEC  ldr      x0, [x8]
00686BBF0  bl       #0x382bfa0 ; 
00686BBF4  mov      x20, x0
00686BBF8  bl       #0x6866460 ; HotFix.BattleLogic.NormalSkillCreator$$.ctor
00686BBFC  mov      x21, x19
00686BC00  str      x20, [x21, #0x88]!
00686BC04  mov      x0, x21
00686BC08  mov      x1, x20
00686BC0C  bl       #0x382bcb8 ; 
00686BC10  ldr      x20, [x21]
00686BC14  cbz      x20, #0x686bc7c
00686BC18  adrp     x21, #0x959b000
00686BC1C  ldrb     w8, [x21, #0xbaf]
00686BC20  cbnz     w8, #0x686bc38
00686BC24  adrp     x0, #0x8f24000
00686BC28  ldr      x0, [x0, #0x128]
00686BC2C  bl       #0x382bd14 ; 
00686BC30  mov      w8, #1
00686BC34  strb     w8, [x21, #0xbaf]
00686BC38  adrp     x8, #0x8f24000
00686BC3C  ldr      x8, [x8, #0x128]
00686BC40  ldr      x2, [x8]
00686BC44  ldrb     w8, [x2, #0x53]
00686BC48  tbnz     w8, #5, #0x686bc64
00686BC4C  str      x19, [x20, #0x10]!
00686BC50  mov      x0, x20
00686BC54  mov      x1, x19
00686BC58  ldp      x20, x19, [sp, #0x10]
00686BC5C  ldp      x30, x21, [sp], #0x20
00686BC60  b        #0x382bcb8 ; 
00686BC64  ldr      x3, [x2, #0x60]
00686BC68  mov      x0, x20
00686BC6C  mov      x1, x19
00686BC70  ldp      x20, x19, [sp, #0x10]
00686BC74  ldp      x30, x21, [sp], #0x20
00686BC78  br       x3
00686BC7C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$InitRandomSkill
; RVA 0x686BC80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686BC80  stp      x30, x23, [sp, #-0x30]!
00686BC84  stp      x22, x21, [sp, #0x10]
00686BC88  stp      x20, x19, [sp, #0x20]
00686BC8C  adrp     x22, #0x959b000
00686BC90  adrp     x23, #0x8f24000
00686BC94  ldrb     w8, [x22, #0xa4b]
00686BC98  ldr      x23, [x23, #0x130]
00686BC9C  mov      x20, x2
00686BCA0  mov      x21, x1
00686BCA4  mov      x19, x0
00686BCA8  tbnz     w8, #0, #0x686bcc0
00686BCAC  adrp     x0, #0x8f24000
00686BCB0  ldr      x0, [x0, #0x130]
00686BCB4  bl       #0x382bd14 ; 
00686BCB8  mov      w8, #1
00686BCBC  strb     w8, [x22, #0xa4b]
00686BCC0  ldr      x3, [x23]
00686BCC4  ldrb     w8, [x3, #0x53]
00686BCC8  tbnz     w8, #5, #0x686bcfc
00686BCCC  ldr      x0, [x19, #0x88]
00686BCD0  cbz      x0, #0x686bd1c
00686BCD4  mov      x1, x21
00686BCD8  mov      x2, x20
00686BCDC  bl       #0x686bd20 ; HotFix.BattleLogic.HeroSkillCreator$$InitRandomSkill
00686BCE0  mov      x0, x19
00686BCE4  bl       #0x686beac ; HotFix.BattleLogic.HeroComponentRandomSkill$$GroupSkillsByType
00686BCE8  mov      x0, x19
00686BCEC  ldp      x20, x19, [sp, #0x20]
00686BCF0  ldp      x22, x21, [sp, #0x10]
00686BCF4  ldp      x30, x23, [sp], #0x30
00686BCF8  b        #0x686c5b4 ; HotFix.BattleLogic.HeroComponentRandomSkill$$RecalculateAllWeight
00686BCFC  ldr      x4, [x3, #0x60]
00686BD00  mov      x0, x19
00686BD04  mov      x1, x21
00686BD08  mov      x2, x20
00686BD0C  ldp      x20, x19, [sp, #0x20]
00686BD10  ldp      x22, x21, [sp, #0x10]
00686BD14  ldp      x30, x23, [sp], #0x30
00686BD18  br       x4
00686BD1C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$DeInit
; RVA 0x686C6B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C6B4  stp      x30, x21, [sp, #-0x20]!
00686C6B8  stp      x20, x19, [sp, #0x10]
00686C6BC  adrp     x20, #0x959b000
00686C6C0  adrp     x21, #0x8f24000
00686C6C4  ldrb     w8, [x20, #0xa4c]
00686C6C8  ldr      x21, [x21, #0x1b8]
00686C6CC  mov      x19, x0
00686C6D0  tbnz     w8, #0, #0x686c718
00686C6D4  adrp     x0, #0x8eea000
00686C6D8  ldr      x0, [x0, #0xf0]
00686C6DC  bl       #0x382bd14 ; 
00686C6E0  adrp     x0, #0x8f24000
00686C6E4  ldr      x0, [x0, #0x1b8]
00686C6E8  bl       #0x382bd14 ; 
00686C6EC  adrp     x0, #0x8ec2000
00686C6F0  ldr      x0, [x0, #0x240]
00686C6F4  bl       #0x382bd14 ; 
00686C6F8  adrp     x0, #0x8f24000
00686C6FC  ldr      x0, [x0, #0x1c0]
00686C700  bl       #0x382bd14 ; 
00686C704  adrp     x0, #0x8f24000
00686C708  ldr      x0, [x0, #0xc8]
00686C70C  bl       #0x382bd14 ; 
00686C710  mov      w8, #1
00686C714  strb     w8, [x20, #0xa4c]
00686C718  ldr      x1, [x21]
00686C71C  ldrb     w8, [x1, #0x53]
00686C720  tbnz     w8, #5, #0x686c7a8
00686C724  mov      x20, x19
00686C728  ldr      x0, [x20, #0x88]!
00686C72C  cbz      x0, #0x686c7bc
00686C730  bl       #0x686c7c0 ; HotFix.BattleLogic.HeroSkillCreator$$DeInit
00686C734  mov      x0, x20
00686C738  mov      x1, xzr
00686C73C  str      xzr, [x19, #0x88]
00686C740  bl       #0x382bcb8 ; 
00686C744  ldr      x0, [x19, #0x48]
00686C748  cbz      x0, #0x686c7bc
00686C74C  adrp     x8, #0x8f24000
00686C750  ldr      x8, [x8, #0x1c0]
00686C754  ldr      x1, [x8]
00686C758  bl       #0x521dd84 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$Clear
00686C75C  ldr      x0, [x19, #0x50]
00686C760  cbz      x0, #0x686c7bc
00686C764  adrp     x8, #0x8f24000
00686C768  ldr      x8, [x8, #0xc8]
00686C76C  ldr      x1, [x8]
00686C770  bl       #0x524c948 ; Rock.Collections.OrderedHashSet<int>$$Clear
00686C774  ldr      x8, [x19, #0x58]
00686C778  cbz      x8, #0x686c7bc
00686C77C  ldr      w9, [x8, #0x1c]
00686C780  add      w9, w9, #1
00686C784  stp      wzr, w9, [x8, #0x18]
00686C788  ldr      x0, [x19, #0x40]
00686C78C  cbz      x0, #0x686c7bc
00686C790  adrp     x8, #0x8eea000
00686C794  ldr      x8, [x8, #0xf0]
00686C798  ldp      x20, x19, [sp, #0x10]
00686C79C  ldr      x1, [x8]
00686C7A0  ldp      x30, x21, [sp], #0x20
00686C7A4  b        #0x5e282e0 ; System.Collections.Generic.Dictionary<int, int>$$Clear
00686C7A8  ldr      x2, [x1, #0x60]
00686C7AC  mov      x0, x19
00686C7B0  ldp      x20, x19, [sp, #0x10]
00686C7B4  ldp      x30, x21, [sp], #0x20
00686C7B8  br       x2
00686C7BC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$OnUpdate
; RVA 0x686C834; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C834  str      x30, [sp, #-0x30]!
00686C838  stp      x22, x21, [sp, #0x10]
00686C83C  stp      x20, x19, [sp, #0x20]
00686C840  adrp     x21, #0x959b000
00686C844  adrp     x22, #0x8f24000
00686C848  ldrb     w8, [x21, #0xa4d]
00686C84C  ldr      x22, [x22, #0x1d0]
00686C850  mov      x19, x1
00686C854  mov      x20, x0
00686C858  tbnz     w8, #0, #0x686c870
00686C85C  adrp     x0, #0x8f24000
00686C860  ldr      x0, [x0, #0x1d0]
00686C864  bl       #0x382bd14 ; 
00686C868  mov      w8, #1
00686C86C  strb     w8, [x21, #0xa4d]
00686C870  ldr      x2, [x22]
00686C874  ldrb     w8, [x2, #0x53]
00686C878  tbnz     w8, #5, #0x686c88c
00686C87C  ldp      x20, x19, [sp, #0x20]
00686C880  ldp      x22, x21, [sp, #0x10]
00686C884  ldr      x30, [sp], #0x30
00686C888  ret      
00686C88C  ldr      x3, [x2, #0x60]
00686C890  mov      x0, x20
00686C894  mov      x1, x19
00686C898  ldp      x20, x19, [sp, #0x20]
00686C89C  ldp      x22, x21, [sp, #0x10]
00686C8A0  ldr      x30, [sp], #0x30
00686C8A4  br       x3

; HotFix.BattleLogic.HeroComponentRandomSkill$$OnLateUpdate
; RVA 0x686C8A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C8A8  str      x30, [sp, #-0x30]!
00686C8AC  stp      x22, x21, [sp, #0x10]
00686C8B0  stp      x20, x19, [sp, #0x20]
00686C8B4  adrp     x21, #0x959b000
00686C8B8  adrp     x22, #0x8f24000
00686C8BC  ldrb     w8, [x21, #0xa4e]
00686C8C0  ldr      x22, [x22, #0x1d8]
00686C8C4  mov      x19, x1
00686C8C8  mov      x20, x0
00686C8CC  tbnz     w8, #0, #0x686c8e4
00686C8D0  adrp     x0, #0x8f24000
00686C8D4  ldr      x0, [x0, #0x1d8]
00686C8D8  bl       #0x382bd14 ; 
00686C8DC  mov      w8, #1
00686C8E0  strb     w8, [x21, #0xa4e]
00686C8E4  ldr      x2, [x22]
00686C8E8  ldrb     w8, [x2, #0x53]
00686C8EC  tbnz     w8, #5, #0x686c900
00686C8F0  ldp      x20, x19, [sp, #0x20]
00686C8F4  ldp      x22, x21, [sp, #0x10]
00686C8F8  ldr      x30, [sp], #0x30
00686C8FC  ret      
00686C900  ldr      x3, [x2, #0x60]
00686C904  mov      x0, x20
00686C908  mov      x1, x19
00686C90C  ldp      x20, x19, [sp, #0x20]
00686C910  ldp      x22, x21, [sp, #0x10]
00686C914  ldr      x30, [sp], #0x30
00686C918  br       x3

; HotFix.BattleLogic.HeroComponentRandomSkill$$OnEvent
; RVA 0x686C91C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C91C  stp      x30, x23, [sp, #-0x30]!
00686C920  stp      x22, x21, [sp, #0x10]
00686C924  stp      x20, x19, [sp, #0x20]
00686C928  adrp     x22, #0x959b000
00686C92C  adrp     x23, #0x8f24000
00686C930  ldrb     w8, [x22, #0xa4f]
00686C934  ldr      x23, [x23, #0x1e0]
00686C938  mov      x19, x2
00686C93C  mov      w20, w1
00686C940  mov      x21, x0
00686C944  tbnz     w8, #0, #0x686c95c
00686C948  adrp     x0, #0x8f24000
00686C94C  ldr      x0, [x0, #0x1e0]
00686C950  bl       #0x382bd14 ; 
00686C954  mov      w8, #1
00686C958  strb     w8, [x22, #0xa4f]
00686C95C  ldr      x3, [x23]
00686C960  ldrb     w8, [x3, #0x53]
00686C964  tbnz     w8, #5, #0x686c978
00686C968  ldp      x20, x19, [sp, #0x20]
00686C96C  ldp      x22, x21, [sp, #0x10]
00686C970  ldp      x30, x23, [sp], #0x30
00686C974  ret      
00686C978  ldr      x4, [x3, #0x60]
00686C97C  mov      x0, x21
00686C980  mov      w1, w20
00686C984  mov      x2, x19
00686C988  ldp      x20, x19, [sp, #0x20]
00686C98C  ldp      x22, x21, [sp, #0x10]
00686C990  ldp      x30, x23, [sp], #0x30
00686C994  br       x4

; HotFix.BattleLogic.HeroComponentRandomSkill$$RandomSkill
; RVA 0x686C998; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C998  sub      sp, sp, #0x80
00686C99C  stp      x29, x30, [sp, #0x20]
00686C9A0  stp      x28, x27, [sp, #0x30]
00686C9A4  stp      x26, x25, [sp, #0x40]
00686C9A8  stp      x24, x23, [sp, #0x50]
00686C9AC  stp      x22, x21, [sp, #0x60]
00686C9B0  stp      x20, x19, [sp, #0x70]
00686C9B4  adrp     x20, #0x959b000
00686C9B8  adrp     x21, #0x8f24000
00686C9BC  ldrb     w8, [x20, #0xa50]
00686C9C0  ldr      x21, [x21, #0x1e8]
00686C9C4  mov      w24, w5
00686C9C8  mov      w29, w4
00686C9CC  mov      w28, w3
00686C9D0  mov      w25, w2
00686C9D4  mov      w26, w1
00686C9D8  mov      x19, x0
00686C9DC  tbnz     w8, #0, #0x686ca84
00686C9E0  adrp     x0, #0x8f09000
00686C9E4  ldr      x0, [x0, #0x150]
00686C9E8  bl       #0x382bd14 ; 
00686C9EC  adrp     x0, #0x8ee6000
00686C9F0  ldr      x0, [x0, #0xd8]
00686C9F4  bl       #0x382bd14 ; 
00686C9F8  adrp     x0, #0x8f23000
00686C9FC  ldr      x0, [x0, #0x140]
00686CA00  bl       #0x382bd14 ; 
00686CA04  adrp     x0, #0x8ee3000
00686CA08  ldr      x0, [x0, #0xf48]
00686CA0C  bl       #0x382bd14 ; 
00686CA10  adrp     x0, #0x8f24000
00686CA14  ldr      x0, [x0, #0x1e8]
00686CA18  bl       #0x382bd14 ; 
00686CA1C  adrp     x0, #0x8f08000
00686CA20  ldr      x0, [x0, #0xbb0]
00686CA24  bl       #0x382bd14 ; 
00686CA28  adrp     x0, #0x8ee1000
00686CA2C  ldr      x0, [x0, #0x6e8]
00686CA30  bl       #0x382bd14 ; 
00686CA34  adrp     x0, #0x8f08000
00686CA38  ldr      x0, [x0, #0xbb8]
00686CA3C  bl       #0x382bd14 ; 
00686CA40  adrp     x0, #0x8f08000
00686CA44  ldr      x0, [x0, #0xbc0]
00686CA48  bl       #0x382bd14 ; 
00686CA4C  adrp     x0, #0x8f0a000
00686CA50  ldr      x0, [x0, #0x618]
00686CA54  bl       #0x382bd14 ; 
00686CA58  adrp     x0, #0x8f08000
00686CA5C  ldr      x0, [x0, #0xf38]
00686CA60  bl       #0x382bd14 ; 
00686CA64  adrp     x0, #0x8f24000
00686CA68  ldr      x0, [x0, #0x1f0]
00686CA6C  bl       #0x382bd14 ; 
00686CA70  adrp     x0, #0x8f24000
00686CA74  ldr      x0, [x0, #0x1f8]
00686CA78  bl       #0x382bd14 ; 
00686CA7C  mov      w8, #1
00686CA80  strb     w8, [x20, #0xa50]
00686CA84  ldr      x6, [x21]
00686CA88  ldrb     w8, [x6, #0x53]
00686CA8C  tbnz     w8, #5, #0x686cab0
00686CA90  adrp     x27, #0x8f23000
00686CA94  ldr      x27, [x27, #0x140]
00686CA98  str      wzr, [sp, #0x1c]
00686CA9C  ldr      x1, [x27]
00686CAA0  ldrb     w8, [x1, #0x53]
00686CAA4  tbnz     w8, #5, #0x686caec
00686CAA8  ldr      x0, [x19, #0x30]
00686CAAC  b        #0x686caf8 ; 
00686CAB0  ldr      x7, [x6, #0x60]
00686CAB4  and      w1, w26, #1
00686CAB8  and      w5, w24, #1
00686CABC  mov      x0, x19
00686CAC0  mov      w2, w25
00686CAC4  mov      w3, w28
00686CAC8  mov      w4, w29
00686CACC  ldp      x20, x19, [sp, #0x70]
00686CAD0  ldp      x22, x21, [sp, #0x60]
00686CAD4  ldp      x24, x23, [sp, #0x50]
00686CAD8  ldp      x26, x25, [sp, #0x40]
00686CADC  ldp      x28, x27, [sp, #0x30]
00686CAE0  ldp      x29, x30, [sp, #0x20]
00686CAE4  add      sp, sp, #0x80
00686CAE8  br       x7
00686CAEC  ldr      x8, [x1, #0x60]
00686CAF0  mov      x0, x19
00686CAF4  blr      x8
00686CAF8  cbz      x0, #0x686de0c
00686CAFC  adrp     x8, #0x8ee6000
00686CB00  ldr      x8, [x8, #0xd8]
00686CB04  ldr      x1, [x8]
00686CB08  ldrb     w8, [x1, #0x53]
00686CB0C  tbnz     w8, #5, #0x686cb18
00686CB10  ldr      x23, [x0, #0x38]
00686CB14  b        #0x686cb24 ; 
00686CB18  ldr      x8, [x1, #0x60]
00686CB1C  blr      x8
00686CB20  mov      x23, x0
00686CB24  cbz      x23, #0x686de0c
00686CB28  adrp     x21, #0x9591000
00686CB2C  ldrb     w8, [x21, #0xa7f]
00686CB30  cbnz     w8, #0x686cb48
00686CB34  adrp     x0, #0x8ee6000
00686CB38  ldr      x0, [x0, #0x2d8]
00686CB3C  bl       #0x382bd14 ; 
00686CB40  mov      w8, #1
00686CB44  strb     w8, [x21, #0xa7f]
00686CB48  adrp     x8, #0x8ee6000
00686CB4C  ldr      x8, [x8, #0x2d8]
00686CB50  ldr      x1, [x8]
00686CB54  ldrb     w8, [x1, #0x53]
00686CB58  tbnz     w8, #5, #0x686cb64
00686CB5C  ldr      x0, [x23, #0x178]
00686CB60  b        #0x686cb70 ; 
00686CB64  ldr      x8, [x1, #0x60]
00686CB68  mov      x0, x23
00686CB6C  blr      x8
00686CB70  cbz      x0, #0x686de0c
00686CB74  adrp     x20, #0x8f0a000
00686CB78  ldr      x20, [x20, #0x618]
00686CB7C  mov      x2, xzr
00686CB80  ldr      x1, [x20]
00686CB84  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686CB88  lsr      x22, x0, #0x10
00686CB8C  tbz      w26, #0, #0x686cbac
00686CB90  cmp      w22, #0
00686CB94  b.le     #0x686cbc0
00686CB98  ldr      x1, [x27]
00686CB9C  ldrb     w8, [x1, #0x53]
00686CBA0  tbnz     w8, #5, #0x686cc0c
00686CBA4  ldr      x0, [x19, #0x30]
00686CBA8  b        #0x686cc18 ; 
00686CBAC  mov      x0, x19
00686CBB0  str      w28, [sp, #8]
00686CBB4  bl       #0x686de10 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckQualityUp
00686CBB8  mov      w28, w0
00686CBBC  b        #0x686ccb4 ; 
00686CBC0  adrp     x8, #0x8ee1000
00686CBC4  ldr      x8, [x8, #0x6e8]
00686CBC8  ldr      x0, [x8]
00686CBCC  ldr      w8, [x0, #0xe0]
00686CBD0  cbnz     w8, #0x686cbd8
00686CBD4  bl       #0x382be8c ; 
00686CBD8  adrp     x8, #0x8f24000
00686CBDC  adrp     x9, #0x8f08000
00686CBE0  adrp     x10, #0x8f24000
00686CBE4  ldr      x8, [x8, #0x1f0]
00686CBE8  ldr      x9, [x9, #0xf38]
00686CBEC  ldr      x10, [x10, #0x1f8]
00686CBF0  mov      w3, #0x224
00686CBF4  ldr      x0, [x8]
00686CBF8  ldr      x1, [x9]
00686CBFC  ldr      x2, [x10]
00686CC00  mov      x4, xzr
00686CC04  bl       #0x7997754 ; Logger$$LogError
00686CC08  b        #0x686ddec ; 
00686CC0C  ldr      x8, [x1, #0x60]
00686CC10  mov      x0, x19
00686CC14  blr      x8
00686CC18  cbz      x0, #0x686de0c
00686CC1C  adrp     x8, #0x8ee6000
00686CC20  ldr      x8, [x8, #0xd8]
00686CC24  ldr      x1, [x8]
00686CC28  ldrb     w8, [x1, #0x53]
00686CC2C  tbnz     w8, #5, #0x686cc38
00686CC30  ldr      x23, [x0, #0x38]
00686CC34  b        #0x686cc44 ; 
00686CC38  ldr      x8, [x1, #0x60]
00686CC3C  blr      x8
00686CC40  mov      x23, x0
00686CC44  cbz      x23, #0x686de0c
00686CC48  ldrb     w8, [x21, #0xa7f]
00686CC4C  cbnz     w8, #0x686cc64
00686CC50  adrp     x0, #0x8ee6000
00686CC54  ldr      x0, [x0, #0x2d8]
00686CC58  bl       #0x382bd14 ; 
00686CC5C  mov      w8, #1
00686CC60  strb     w8, [x21, #0xa7f]
00686CC64  adrp     x8, #0x8ee6000
00686CC68  ldr      x8, [x8, #0x2d8]
00686CC6C  ldr      x1, [x8]
00686CC70  ldrb     w8, [x1, #0x53]
00686CC74  tbnz     w8, #5, #0x686cc80
00686CC78  ldr      x0, [x23, #0x178]
00686CC7C  b        #0x686cc8c ; 
00686CC80  ldr      x8, [x1, #0x60]
00686CC84  mov      x0, x23
00686CC88  blr      x8
00686CC8C  str      w28, [sp, #8]
00686CC90  cbz      x0, #0x686de0c
00686CC94  ldr      x8, [x0]
00686CC98  ldr      x1, [x20]
00686CC9C  sub      w22, w22, #1
00686CCA0  ldp      x9, x3, [x8, #0x178]
00686CCA4  mov      w8, w22
00686CCA8  lsl      x2, x8, #0x10
00686CCAC  blr      x9
00686CCB0  mov      w28, wzr
00686CCB4  adrp     x8, #0x9591000
00686CCB8  mov      x21, x8
00686CCBC  ldrb     w8, [x8, #0xa4b]
00686CCC0  cbnz     w8, #0x686ccd8
00686CCC4  adrp     x0, #0x8ee5000
00686CCC8  ldr      x0, [x0, #0xb28]
00686CCCC  bl       #0x382bd14 ; 
00686CCD0  mov      w8, #1
00686CCD4  strb     w8, [x21, #0xa4b]
00686CCD8  adrp     x8, #0x8ee5000
00686CCDC  ldr      x8, [x8, #0xb28]
00686CCE0  ldr      x1, [x8]
00686CCE4  ldrb     w8, [x1, #0x53]
00686CCE8  tbnz     w8, #5, #0x686ccf4
00686CCEC  ldr      x23, [x19, #0x20]
00686CCF0  b        #0x686cd04 ; 
00686CCF4  ldr      x8, [x1, #0x60]
00686CCF8  mov      x0, x19
00686CCFC  blr      x8
00686CD00  mov      x23, x0
00686CD04  cbz      x23, #0x686de0c
00686CD08  adrp     x8, #0x9591000
00686CD0C  ldrb     w8, [x8, #0xa90]
00686CD10  cbnz     w8, #0x686cd2c
00686CD14  adrp     x0, #0x8ee6000
00686CD18  ldr      x0, [x0, #0x3e0]
00686CD1C  bl       #0x382bd14 ; 
00686CD20  mov      w8, #1
00686CD24  adrp     x9, #0x9591000
00686CD28  strb     w8, [x9, #0xa90]
00686CD2C  adrp     x8, #0x8ee6000
00686CD30  ldr      x8, [x8, #0x3e0]
00686CD34  ldr      x1, [x8]
00686CD38  ldrb     w8, [x1, #0x53]
00686CD3C  tbnz     w8, #5, #0x686cd48
00686CD40  ldr      x0, [x23, #0x230]
00686CD44  b        #0x686cd54 ; 
00686CD48  ldr      x8, [x1, #0x60]
00686CD4C  mov      x0, x23
00686CD50  blr      x8
00686CD54  cbz      x0, #0x686de0c
00686CD58  adrp     x8, #0x8f08000
00686CD5C  ldr      x8, [x8, #0xbb8]
00686CD60  ldr      x1, [x8]
00686CD64  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
00686CD68  ldrb     w8, [x21, #0xa4b]
00686CD6C  mov      x23, x0
00686CD70  cbnz     w8, #0x686cd88
00686CD74  adrp     x0, #0x8ee5000
00686CD78  ldr      x0, [x0, #0xb28]
00686CD7C  bl       #0x382bd14 ; 
00686CD80  mov      w8, #1
00686CD84  strb     w8, [x21, #0xa4b]
00686CD88  str      w24, [sp, #4]
00686CD8C  adrp     x8, #0x8ee5000
00686CD90  ldr      x8, [x8, #0xb28]
00686CD94  ldr      x1, [x8]
00686CD98  ldrb     w8, [x1, #0x53]
00686CD9C  tbnz     w8, #5, #0x686cda8
00686CDA0  ldr      x24, [x19, #0x20]
00686CDA4  b        #0x686cdb8 ; 
00686CDA8  ldr      x8, [x1, #0x60]
00686CDAC  mov      x0, x19
00686CDB0  blr      x8
00686CDB4  mov      x24, x0
00686CDB8  cbz      x24, #0x686de0c
00686CDBC  adrp     x20, #0x9598000
00686CDC0  ldrb     w8, [x20, #0xfc4]
00686CDC4  cbnz     w8, #0x686cddc
00686CDC8  adrp     x0, #0x8f05000
00686CDCC  ldr      x0, [x0, #0xfd8]
00686CDD0  bl       #0x382bd14 ; 
00686CDD4  mov      w8, #1
00686CDD8  strb     w8, [x20, #0xfc4]
00686CDDC  adrp     x8, #0x8f05000
00686CDE0  ldr      x8, [x8, #0xfd8]
00686CDE4  ldr      x1, [x8]
00686CDE8  ldrb     w8, [x1, #0x53]
00686CDEC  tbnz     w8, #5, #0x686cdf8
00686CDF0  ldr      x24, [x24, #0x220]
00686CDF4  b        #0x686ce08 ; 
00686CDF8  ldr      x8, [x1, #0x60]
00686CDFC  mov      x0, x24
00686CE00  blr      x8
00686CE04  mov      x24, x0
00686CE08  str      w29, [sp, #0xc]
00686CE0C  cbz      x24, #0x686de0c
00686CE10  adrp     x29, #0x959b000
00686CE14  ldrb     w8, [x29, #0xbb0]
00686CE18  str      x23, [sp, #0x10]
00686CE1C  cbnz     w8, #0x686ce34
00686CE20  adrp     x0, #0x8f08000
00686CE24  ldr      x0, [x0, #0x750]
00686CE28  bl       #0x382bd14 ; 
00686CE2C  mov      w8, #1
00686CE30  strb     w8, [x29, #0xbb0]
00686CE34  adrp     x23, #0x8f08000
00686CE38  ldr      x23, [x23, #0x750]
00686CE3C  ldr      x1, [x23]
00686CE40  ldrb     w8, [x1, #0x53]
00686CE44  tbnz     w8, #5, #0x686ce50
00686CE48  ldr      x24, [x24, #0x20]
00686CE4C  b        #0x686ce60 ; 
00686CE50  ldr      x8, [x1, #0x60]
00686CE54  mov      x0, x24
00686CE58  blr      x8
00686CE5C  mov      x24, x0
00686CE60  ldr      x1, [x27]
00686CE64  ldrb     w8, [x1, #0x53]
00686CE68  tbnz     w8, #5, #0x686ce74
00686CE6C  ldr      x0, [x19, #0x30]
00686CE70  b        #0x686ce80 ; 
00686CE74  ldr      x8, [x1, #0x60]
00686CE78  mov      x0, x19
00686CE7C  blr      x8
00686CE80  cbz      x0, #0x686de0c
00686CE84  adrp     x8, #0x8f09000
00686CE88  ldr      x8, [x8, #0x150]
00686CE8C  ldr      x1, [x8]
00686CE90  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00686CE94  cbz      x0, #0x686de0c
00686CE98  mov      x1, xzr
00686CE9C  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
00686CEA0  mov      w27, w0
00686CEA4  str      wzr, [sp, #0x1c]
00686CEA8  cbz      x24, #0x686cee4
00686CEAC  ldrb     w8, [x21, #0xa4b]
00686CEB0  cbnz     w8, #0x686cec8
00686CEB4  adrp     x0, #0x8ee5000
00686CEB8  ldr      x0, [x0, #0xb28]
00686CEBC  bl       #0x382bd14 ; 
00686CEC0  mov      w8, #1
00686CEC4  strb     w8, [x21, #0xa4b]
00686CEC8  adrp     x8, #0x8ee5000
00686CECC  ldr      x8, [x8, #0xb28]
00686CED0  ldr      x1, [x8]
00686CED4  ldrb     w8, [x1, #0x53]
00686CED8  tbnz     w8, #5, #0x686cf0c
00686CEDC  ldr      x28, [x19, #0x20]
00686CEE0  b        #0x686cf1c ; 
00686CEE4  ldr      x1, [sp, #0x10]
00686CEE8  and      w2, w28, #1
00686CEEC  and      w3, w26, #1
00686CEF0  add      x5, sp, #0x1c
00686CEF4  mov      x0, x19
00686CEF8  mov      w4, w27
00686CEFC  bl       #0x686e0a0 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetNormalSkill
00686CF00  mov      w28, w0
00686CF04  mov      x29, x21
00686CF08  b        #0x686d0d0 ; 
00686CF0C  ldr      x8, [x1, #0x60]
00686CF10  mov      x0, x19
00686CF14  blr      x8
00686CF18  mov      x28, x0
00686CF1C  cbz      x28, #0x686de0c
00686CF20  ldrb     w8, [x20, #0xfc4]
00686CF24  cbnz     w8, #0x686cf3c
00686CF28  adrp     x0, #0x8f05000
00686CF2C  ldr      x0, [x0, #0xfd8]
00686CF30  bl       #0x382bd14 ; 
00686CF34  mov      w8, #1
00686CF38  strb     w8, [x20, #0xfc4]
00686CF3C  adrp     x8, #0x8f05000
00686CF40  ldr      x8, [x8, #0xfd8]
00686CF44  ldr      x1, [x8]
00686CF48  ldrb     w8, [x1, #0x53]
00686CF4C  tbnz     w8, #5, #0x686cf58
00686CF50  ldr      x28, [x28, #0x220]
00686CF54  b        #0x686cf68 ; 
00686CF58  ldr      x8, [x1, #0x60]
00686CF5C  mov      x0, x28
00686CF60  blr      x8
00686CF64  mov      x28, x0
00686CF68  cbz      x28, #0x686de0c
00686CF6C  ldrb     w8, [x29, #0xbb0]
00686CF70  cbnz     w8, #0x686cf88
00686CF74  adrp     x0, #0x8f08000
00686CF78  ldr      x0, [x0, #0x750]
00686CF7C  bl       #0x382bd14 ; 
00686CF80  mov      w8, #1
00686CF84  strb     w8, [x29, #0xbb0]
00686CF88  ldr      x1, [x23]
00686CF8C  ldrb     w8, [x1, #0x53]
00686CF90  tbnz     w8, #5, #0x686cf9c
00686CF94  ldr      x1, [x28, #0x20]
00686CF98  b        #0x686cfac ; 
00686CF9C  ldr      x8, [x1, #0x60]
00686CFA0  mov      x0, x28
00686CFA4  blr      x8
00686CFA8  mov      x1, x0
00686CFAC  adrp     x23, #0x8f05000
00686CFB0  ldr      x0, [sp, #0x10]
00686CFB4  ldr      x23, [x23, #0xfd8]
00686CFB8  mov      x29, x21
00686CFBC  cbz      x0, #0x686de0c
00686CFC0  adrp     x8, #0x8f08000
00686CFC4  ldr      x8, [x8, #0xbb0]
00686CFC8  ldr      x2, [x8]
00686CFCC  bl       #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
00686CFD0  ldrb     w8, [x29, #0xa4b]
00686CFD4  cbnz     w8, #0x686cfec
00686CFD8  adrp     x0, #0x8ee5000
00686CFDC  ldr      x0, [x0, #0xb28]
00686CFE0  bl       #0x382bd14 ; 
00686CFE4  mov      w8, #1
00686CFE8  strb     w8, [x29, #0xa4b]
00686CFEC  adrp     x8, #0x8ee5000
00686CFF0  ldr      x8, [x8, #0xb28]
00686CFF4  ldr      x1, [x8]
00686CFF8  ldrb     w8, [x1, #0x53]
00686CFFC  tbnz     w8, #5, #0x686d008
00686D000  ldr      x28, [x19, #0x20]
00686D004  b        #0x686d018 ; 
00686D008  ldr      x8, [x1, #0x60]
00686D00C  mov      x0, x19
00686D010  blr      x8
00686D014  mov      x28, x0
00686D018  cbz      x28, #0x686de0c
00686D01C  ldrb     w8, [x20, #0xfc4]
00686D020  cbnz     w8, #0x686d038
00686D024  adrp     x0, #0x8f05000
00686D028  ldr      x0, [x0, #0xfd8]
00686D02C  bl       #0x382bd14 ; 
00686D030  mov      w8, #1
00686D034  strb     w8, [x20, #0xfc4]
00686D038  ldr      x1, [x23]
00686D03C  ldrb     w8, [x1, #0x53]
00686D040  tbnz     w8, #5, #0x686d04c
00686D044  ldr      x28, [x28, #0x220]
00686D048  b        #0x686d05c ; 
00686D04C  ldr      x8, [x1, #0x60]
00686D050  mov      x0, x28
00686D054  blr      x8
00686D058  mov      x28, x0
00686D05C  cbz      x28, #0x686de0c
00686D060  adrp     x23, #0x9599000
00686D064  ldrb     w8, [x23, #0xeb2]
00686D068  cbnz     w8, #0x686d080
00686D06C  adrp     x0, #0x8f08000
00686D070  ldr      x0, [x0, #0x758]
00686D074  bl       #0x382bd14 ; 
00686D078  mov      w8, #1
00686D07C  strb     w8, [x23, #0xeb2]
00686D080  adrp     x8, #0x8f08000
00686D084  ldr      x8, [x8, #0x758]
00686D088  ldr      x2, [x8]
00686D08C  ldrb     w8, [x2, #0x53]
00686D090  tbnz     w8, #5, #0x686d0a8
00686D094  str      xzr, [x28, #0x20]!
00686D098  mov      x0, x28
00686D09C  mov      x1, xzr
00686D0A0  bl       #0x382bcb8 ; 
00686D0A4  b        #0x686d0b8 ; 
00686D0A8  ldr      x8, [x2, #0x60]
00686D0AC  mov      x0, x28
00686D0B0  mov      x1, xzr
00686D0B4  blr      x8
00686D0B8  ldr      x0, [x19, #0x88]
00686D0BC  cbz      x0, #0x686de0c
00686D0C0  ldr      x8, [x0]
00686D0C4  ldp      x9, x1, [x8, #0x188]
00686D0C8  blr      x9
00686D0CC  mov      w28, wzr
00686D0D0  ldr      x23, [x19, #0x80]
00686D0D4  cbz      x23, #0x686de0c
00686D0D8  ldr      w8, [x23, #0x14]
00686D0DC  add      w8, w8, #1
00686D0E0  str      w8, [x23, #0x14]
00686D0E4  ldrb     w8, [x29, #0xa4b]
00686D0E8  cbnz     w8, #0x686d100
00686D0EC  adrp     x0, #0x8ee5000
00686D0F0  ldr      x0, [x0, #0xb28]
00686D0F4  bl       #0x382bd14 ; 
00686D0F8  mov      w8, #1
00686D0FC  strb     w8, [x29, #0xa4b]
00686D100  adrp     x8, #0x8ee5000
00686D104  ldr      x8, [x8, #0xb28]
00686D108  ldr      x1, [x8]
00686D10C  ldrb     w8, [x1, #0x53]
00686D110  tbnz     w8, #5, #0x686d11c
00686D114  ldr      x29, [x19, #0x20]
00686D118  b        #0x686d12c ; 
00686D11C  ldr      x8, [x1, #0x60]
00686D120  mov      x0, x19
00686D124  blr      x8
00686D128  mov      x29, x0
00686D12C  cbz      x29, #0x686de0c
00686D130  ldrb     w8, [x20, #0xfc4]
00686D134  cbnz     w8, #0x686d14c
00686D138  adrp     x0, #0x8f05000
00686D13C  ldr      x0, [x0, #0xfd8]
00686D140  bl       #0x382bd14 ; 
00686D144  mov      w8, #1
00686D148  strb     w8, [x20, #0xfc4]
00686D14C  adrp     x8, #0x8f05000
00686D150  ldr      x8, [x8, #0xfd8]
00686D154  ldr      x1, [x8]
00686D158  ldrb     w8, [x1, #0x53]
00686D15C  tbnz     w8, #5, #0x686d168
00686D160  ldr      x0, [x29, #0x220]
00686D164  b        #0x686d174 ; 
00686D168  ldr      x8, [x1, #0x60]
00686D16C  mov      x0, x29
00686D170  blr      x8
00686D174  cbz      x0, #0x686de0c
00686D178  ldr      x8, [x0]
00686D17C  ldr      x9, [x8, #0x2e8]
00686D180  ldr      x1, [x8, #0x2f0]
00686D184  blr      x9
00686D188  and      w8, w0, #1
00686D18C  strb     w8, [x23, #0x25]
00686D190  ldr      x29, [x19, #0x80]
00686D194  cbz      x29, #0x686de0c
00686D198  and      w8, w28, #1
00686D19C  strb     w8, [x29, #0x24]
00686D1A0  ldr      w8, [sp, #0x1c]
00686D1A4  str      w22, [x29, #0x18]
00686D1A8  ldr      x23, [sp, #0x10]
00686D1AC  add      w8, w8, #1
00686D1B0  stp      w27, w8, [x29, #0x1c]
00686D1B4  ldr      x27, [x19, #0x88]
00686D1B8  cbz      x27, #0x686de0c
00686D1BC  adrp     x22, #0x959b000
00686D1C0  ldrb     w8, [x22, #0xbb1]
00686D1C4  cbnz     w8, #0x686d1dc
00686D1C8  adrp     x0, #0x8f24000
00686D1CC  ldr      x0, [x0, #0x200]
00686D1D0  bl       #0x382bd14 ; 
00686D1D4  mov      w8, #1
00686D1D8  strb     w8, [x22, #0xbb1]
00686D1DC  adrp     x8, #0x8f24000
00686D1E0  ldr      x8, [x8, #0x200]
00686D1E4  ldr      x1, [x8]
00686D1E8  ldrb     w8, [x1, #0x53]
00686D1EC  tbnz     w8, #5, #0x686d1f8
00686D1F0  ldr      w0, [x27, #0x60]
00686D1F4  b        #0x686d204 ; 
00686D1F8  ldr      x8, [x1, #0x60]
00686D1FC  mov      x0, x27
00686D200  blr      x8
00686D204  adrp     x22, #0x959b000
00686D208  ldrb     w8, [x22, #0xb91]
00686D20C  add      w27, w0, #1
00686D210  cbnz     w8, #0x686d228
00686D214  adrp     x0, #0x8f23000
00686D218  ldr      x0, [x0, #0xef0]
00686D21C  bl       #0x382bd14 ; 
00686D220  mov      w8, #1
00686D224  strb     w8, [x22, #0xb91]
00686D228  adrp     x8, #0x8f23000
00686D22C  ldr      x8, [x8, #0xef0]
00686D230  ldr      x2, [x8]
00686D234  ldrb     w8, [x2, #0x53]
00686D238  tbnz     w8, #5, #0x686d244
00686D23C  str      w27, [x29, #0x68]
00686D240  b        #0x686d254 ; 
00686D244  ldr      x8, [x2, #0x60]
00686D248  mov      x0, x29
00686D24C  mov      w1, w27
00686D250  blr      x8
00686D254  adrp     x27, #0x8f23000
00686D258  ldr      x8, [x19, #0x80]
00686D25C  ldr      x27, [x27, #0x140]
00686D260  ldr      w28, [sp, #0xc]
00686D264  cbz      x8, #0x686de0c
00686D268  and      w9, w26, #1
00686D26C  strb     w9, [x8, #0x26]
00686D270  mov      x29, x21
00686D274  ldrb     w8, [x21, #0xa4b]
00686D278  adrp     x21, #0x8ee5000
00686D27C  ldr      x21, [x21, #0xb28]
00686D280  cbnz     w8, #0x686d298
00686D284  adrp     x0, #0x8ee5000
00686D288  ldr      x0, [x0, #0xb28]
00686D28C  bl       #0x382bd14 ; 
00686D290  mov      w8, #1
00686D294  strb     w8, [x29, #0xa4b]
00686D298  ldr      x1, [x21]
00686D29C  ldrb     w8, [x1, #0x53]
00686D2A0  tbnz     w8, #5, #0x686d2ac
00686D2A4  ldr      x0, [x19, #0x20]
00686D2A8  b        #0x686d2b8 ; 
00686D2AC  ldr      x8, [x1, #0x60]
00686D2B0  mov      x0, x19
00686D2B4  blr      x8
00686D2B8  cbz      x0, #0x686de0c
00686D2BC  mov      x1, xzr
00686D2C0  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00686D2C4  ldr      x26, [x19, #0x80]
00686D2C8  cbz      x26, #0x686de0c
00686D2CC  tbz      w0, #0, #0x686d2d8
00686D2D0  str      w25, [x26, #0x28]
00686D2D4  b        #0x686d324 ; 
00686D2D8  adrp     x22, #0x959b000
00686D2DC  ldrb     w8, [x22, #0xb93]
00686D2E0  cbnz     w8, #0x686d2f8
00686D2E4  adrp     x0, #0x8f23000
00686D2E8  ldr      x0, [x0, #0xea0]
00686D2EC  bl       #0x382bd14 ; 
00686D2F0  mov      w8, #1
00686D2F4  strb     w8, [x22, #0xb93]
00686D2F8  adrp     x8, #0x8f23000
00686D2FC  ldr      x8, [x8, #0xea0]
00686D300  ldr      x2, [x8]
00686D304  ldrb     w8, [x2, #0x53]
00686D308  tbnz     w8, #5, #0x686d314
00686D30C  str      w25, [x26, #0x44]
00686D310  b        #0x686d324 ; 
00686D314  ldr      x8, [x2, #0x60]
00686D318  mov      x0, x26
00686D31C  mov      w1, w25
00686D320  blr      x8
00686D324  adrp     x22, #0x9599000
00686D328  ldrb     w8, [x22, #0x4c7]
00686D32C  ldr      x25, [x19, #0x80]
00686D330  cbnz     w8, #0x686d348
00686D334  adrp     x0, #0x8f09000
00686D338  ldr      x0, [x0, #0xc8]
00686D33C  bl       #0x382bd14 ; 
00686D340  mov      w8, #1
00686D344  strb     w8, [x22, #0x4c7]
00686D348  adrp     x8, #0x8f09000
00686D34C  ldr      x8, [x8, #0xc8]
00686D350  ldr      x1, [x8]
00686D354  ldrb     w8, [x1, #0x53]
00686D358  tbnz     w8, #5, #0x686d364
00686D35C  ldr      x1, [x19, #0x58]
00686D360  b        #0x686d374 ; 
00686D364  ldr      x8, [x1, #0x60]
00686D368  mov      x0, x19
00686D36C  blr      x8
00686D370  mov      x1, x0
00686D374  cbz      x25, #0x686de0c
00686D378  str      x1, [x25, #0x30]!
00686D37C  mov      x0, x25
00686D380  bl       #0x382bcb8 ; 
00686D384  ldr      x0, [x19, #0x80]
00686D388  cbz      x0, #0x686de0c
00686D38C  mov      x1, x23
00686D390  bl       #0x6866748 ; HotFix.BattleLogic.RandomSkillResult$$InitByList
00686D394  adrp     x8, #0x8ee3000
00686D398  ldr      x25, [x19, #0x80]
00686D39C  ldr      x0, [x19, #0x50]
00686D3A0  ldr      x8, [x8, #0xf48]
00686D3A4  ldr      x1, [x8]
00686D3A8  bl       #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
00686D3AC  cbz      x25, #0x686de0c
00686D3B0  adrp     x22, #0x959b000
00686D3B4  adrp     x23, #0x8f05000
00686D3B8  ldrb     w8, [x22, #0xb95]
00686D3BC  ldr      x23, [x23, #0xfd8]
00686D3C0  mov      x26, x0
00686D3C4  cbnz     w8, #0x686d3dc
00686D3C8  adrp     x0, #0x8f23000
00686D3CC  ldr      x0, [x0, #0xee0]
00686D3D0  bl       #0x382bd14 ; 
00686D3D4  mov      w8, #1
00686D3D8  strb     w8, [x22, #0xb95]
00686D3DC  adrp     x8, #0x8f23000
00686D3E0  ldr      x8, [x8, #0xee0]
00686D3E4  ldr      x2, [x8]
00686D3E8  ldrb     w8, [x2, #0x53]
00686D3EC  tbnz     w8, #5, #0x686d404
00686D3F0  str      x26, [x25, #0x58]!
00686D3F4  mov      x0, x25
00686D3F8  mov      x1, x26
00686D3FC  bl       #0x382bcb8 ; 
00686D400  b        #0x686d414 ; 
00686D404  ldr      x8, [x2, #0x60]
00686D408  mov      x0, x25
00686D40C  mov      x1, x26
00686D410  blr      x8
00686D414  ldrb     w8, [x29, #0xa4b]
00686D418  ldr      x25, [x19, #0x80]
00686D41C  cbnz     w8, #0x686d434
00686D420  adrp     x0, #0x8ee5000
00686D424  ldr      x0, [x0, #0xb28]
00686D428  bl       #0x382bd14 ; 
00686D42C  mov      w8, #1
00686D430  strb     w8, [x29, #0xa4b]
00686D434  ldr      x1, [x21]
00686D438  ldrb     w8, [x1, #0x53]
00686D43C  tbnz     w8, #5, #0x686d448
00686D440  ldr      x26, [x19, #0x20]
00686D444  b        #0x686d458 ; 
00686D448  ldr      x8, [x1, #0x60]
00686D44C  mov      x0, x19
00686D450  blr      x8
00686D454  mov      x26, x0
00686D458  cbz      x26, #0x686de0c
00686D45C  ldrb     w8, [x20, #0xfc4]
00686D460  cbnz     w8, #0x686d478
00686D464  adrp     x0, #0x8f05000
00686D468  ldr      x0, [x0, #0xfd8]
00686D46C  bl       #0x382bd14 ; 
00686D470  mov      w8, #1
00686D474  strb     w8, [x20, #0xfc4]
00686D478  ldr      x1, [x23]
00686D47C  ldrb     w8, [x1, #0x53]
00686D480  tbnz     w8, #5, #0x686d48c
00686D484  ldr      x0, [x26, #0x220]
00686D488  b        #0x686d498 ; 
00686D48C  ldr      x8, [x1, #0x60]
00686D490  mov      x0, x26
00686D494  blr      x8
00686D498  cbz      x0, #0x686de0c
00686D49C  mov      x1, xzr
00686D4A0  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
00686D4A4  cbz      x25, #0x686de0c
00686D4A8  adrp     x22, #0x959b000
00686D4AC  ldrb     w8, [x22, #0xb97]
00686D4B0  mov      w26, w0
00686D4B4  cbnz     w8, #0x686d4cc
00686D4B8  adrp     x0, #0x8f23000
00686D4BC  ldr      x0, [x0, #0xe80]
00686D4C0  bl       #0x382bd14 ; 
00686D4C4  mov      w8, #1
00686D4C8  strb     w8, [x22, #0xb97]
00686D4CC  adrp     x8, #0x8f23000
00686D4D0  ldr      x8, [x8, #0xe80]
00686D4D4  ldr      x2, [x8]
00686D4D8  ldrb     w8, [x2, #0x53]
00686D4DC  tbnz     w8, #5, #0x686d4ec
00686D4E0  and      w8, w26, #1
00686D4E4  strb     w8, [x25, #0x3c]
00686D4E8  b        #0x686d4fc ; 
00686D4EC  ldr      x8, [x2, #0x60]
00686D4F0  and      w1, w26, #1
00686D4F4  mov      x0, x25
00686D4F8  blr      x8
00686D4FC  ldr      x25, [x19, #0x80]
00686D500  cbz      x25, #0x686de0c
00686D504  adrp     x22, #0x959b000
00686D508  ldrb     w8, [x22, #0xb99]
00686D50C  cbnz     w8, #0x686d524
00686D510  adrp     x0, #0x8f23000
00686D514  ldr      x0, [x0, #0xeb0]
00686D518  bl       #0x382bd14 ; 
00686D51C  mov      w8, #1
00686D520  strb     w8, [x22, #0xb99]
00686D524  adrp     x8, #0x8f23000
00686D528  ldr      x8, [x8, #0xeb0]
00686D52C  ldr      x2, [x8]
00686D530  ldrb     w8, [x2, #0x53]
00686D534  tbnz     w8, #5, #0x686d540
00686D538  strb     wzr, [x25, #0x48]
00686D53C  b        #0x686d550 ; 
00686D540  ldr      x8, [x2, #0x60]
00686D544  mov      x0, x25
00686D548  mov      w1, wzr
00686D54C  blr      x8
00686D550  ldrb     w8, [x29, #0xa4b]
00686D554  cbnz     w8, #0x686d56c
00686D558  adrp     x0, #0x8ee5000
00686D55C  ldr      x0, [x0, #0xb28]
00686D560  bl       #0x382bd14 ; 
00686D564  mov      w8, #1
00686D568  strb     w8, [x29, #0xa4b]
00686D56C  ldr      x1, [x21]
00686D570  ldrb     w8, [x1, #0x53]
00686D574  tbnz     w8, #5, #0x686d580
00686D578  ldr      x25, [x19, #0x20]
00686D57C  b        #0x686d590 ; 
00686D580  ldr      x8, [x1, #0x60]
00686D584  mov      x0, x19
00686D588  blr      x8
00686D58C  mov      x25, x0
00686D590  cbz      x25, #0x686de0c
00686D594  ldrb     w8, [x20, #0xfc4]
00686D598  cbnz     w8, #0x686d5b0
00686D59C  adrp     x0, #0x8f05000
00686D5A0  ldr      x0, [x0, #0xfd8]
00686D5A4  bl       #0x382bd14 ; 
00686D5A8  mov      w8, #1
00686D5AC  strb     w8, [x20, #0xfc4]
00686D5B0  ldr      x1, [x23]
00686D5B4  ldrb     w8, [x1, #0x53]
00686D5B8  tbnz     w8, #5, #0x686d5c4
00686D5BC  ldr      x0, [x25, #0x220]
00686D5C0  b        #0x686d5d0 ; 
00686D5C4  ldr      x8, [x1, #0x60]
00686D5C8  mov      x0, x25
00686D5CC  blr      x8
00686D5D0  cbz      x0, #0x686de0c
00686D5D4  ldr      x8, [x0]
00686D5D8  ldp      x9, x1, [x8, #0x1a8]
00686D5DC  blr      x9
00686D5E0  tbz      w0, #0, #0x686d6c0
00686D5E4  ldrb     w8, [x29, #0xa4b]
00686D5E8  cbnz     w8, #0x686d600
00686D5EC  adrp     x0, #0x8ee5000
00686D5F0  ldr      x0, [x0, #0xb28]
00686D5F4  bl       #0x382bd14 ; 
00686D5F8  mov      w8, #1
00686D5FC  strb     w8, [x29, #0xa4b]
00686D600  ldr      x1, [x21]
00686D604  ldrb     w8, [x1, #0x53]
00686D608  tbnz     w8, #5, #0x686d614
00686D60C  ldr      x25, [x19, #0x20]
00686D610  b        #0x686d624 ; 
00686D614  ldr      x8, [x1, #0x60]
00686D618  mov      x0, x19
00686D61C  blr      x8
00686D620  mov      x25, x0
00686D624  cbz      x25, #0x686de0c
00686D628  adrp     x22, #0x9599000
00686D62C  ldrb     w8, [x22, #0x29b]
00686D630  cbnz     w8, #0x686d648
00686D634  adrp     x0, #0x8f08000
00686D638  ldr      x0, [x0, #0x68]
00686D63C  bl       #0x382bd14 ; 
00686D640  mov      w8, #1
00686D644  strb     w8, [x22, #0x29b]
00686D648  adrp     x8, #0x8f08000
00686D64C  ldr      x8, [x8, #0x68]
00686D650  ldr      x1, [x8]
00686D654  ldrb     w8, [x1, #0x53]
00686D658  tbnz     w8, #5, #0x686d664
00686D65C  ldr      w0, [x25, #0x18c]
00686D660  b        #0x686d670 ; 
00686D664  ldr      x8, [x1, #0x60]
00686D668  mov      x0, x25
00686D66C  blr      x8
00686D670  adrp     x22, #0x9599000
00686D674  ldrb     w8, [x22, #0x4be]
00686D678  add      w26, w0, #1
00686D67C  cbnz     w8, #0x686d694
00686D680  adrp     x0, #0x8f08000
00686D684  ldr      x0, [x0, #0xe90]
00686D688  bl       #0x382bd14 ; 
00686D68C  mov      w8, #1
00686D690  strb     w8, [x22, #0x4be]
00686D694  adrp     x8, #0x8f08000
00686D698  ldr      x8, [x8, #0xe90]
00686D69C  ldr      x2, [x8]
00686D6A0  ldrb     w8, [x2, #0x53]
00686D6A4  tbnz     w8, #5, #0x686d6b0
00686D6A8  str      w26, [x25, #0x18c]
00686D6AC  b        #0x686d6c0 ; 
00686D6B0  ldr      x8, [x2, #0x60]
00686D6B4  mov      x0, x25
00686D6B8  mov      w1, w26
00686D6BC  blr      x8
00686D6C0  ldrb     w8, [x29, #0xa4b]
00686D6C4  cbnz     w8, #0x686d6dc
00686D6C8  adrp     x0, #0x8ee5000
00686D6CC  ldr      x0, [x0, #0xb28]
00686D6D0  bl       #0x382bd14 ; 
00686D6D4  mov      w8, #1
00686D6D8  strb     w8, [x29, #0xa4b]
00686D6DC  ldr      x1, [x21]
00686D6E0  ldrb     w8, [x1, #0x53]
00686D6E4  tbnz     w8, #5, #0x686d6f0
00686D6E8  ldr      x0, [x19, #0x20]
00686D6EC  b        #0x686d6fc ; 
00686D6F0  ldr      x8, [x1, #0x60]
00686D6F4  mov      x0, x19
00686D6F8  blr      x8
00686D6FC  cbz      x0, #0x686de0c
00686D700  mov      x1, xzr
00686D704  bl       #0x6a005a4 ; HotFix.BattleLogic.BattleWorldContext$$IsMultiPlayerBattle
00686D708  tbnz     w0, #0, #0x686d758
00686D70C  ldrb     w8, [x29, #0xa4b]
00686D710  cbnz     w8, #0x686d728
00686D714  adrp     x0, #0x8ee5000
00686D718  ldr      x0, [x0, #0xb28]
00686D71C  bl       #0x382bd14 ; 
00686D720  mov      w8, #1
00686D724  strb     w8, [x29, #0xa4b]
00686D728  ldr      x1, [x21]
00686D72C  ldrb     w8, [x1, #0x53]
00686D730  tbnz     w8, #5, #0x686d73c
00686D734  ldr      x0, [x19, #0x20]
00686D738  b        #0x686d748 ; 
00686D73C  ldr      x8, [x1, #0x60]
00686D740  mov      x0, x19
00686D744  blr      x8
00686D748  cbz      x0, #0x686de0c
00686D74C  mov      w1, #4
00686D750  mov      x2, xzr
00686D754  bl       #0x6a052e4 ; HotFix.BattleLogic.BattleWorldContext$$SetBattleFlag
00686D758  ldrb     w8, [x29, #0xa4b]
00686D75C  ldr      x25, [x19, #0x80]
00686D760  cbnz     w8, #0x686d778
00686D764  adrp     x0, #0x8ee5000
00686D768  ldr      x0, [x0, #0xb28]
00686D76C  bl       #0x382bd14 ; 
00686D770  mov      w8, #1
00686D774  strb     w8, [x29, #0xa4b]
00686D778  ldr      x1, [x21]
00686D77C  ldrb     w8, [x1, #0x53]
00686D780  tbnz     w8, #5, #0x686d78c
00686D784  ldr      x26, [x19, #0x20]
00686D788  b        #0x686d79c ; 
00686D78C  ldr      x8, [x1, #0x60]
00686D790  mov      x0, x19
00686D794  blr      x8
00686D798  mov      x26, x0
00686D79C  cbz      x26, #0x686de0c
00686D7A0  ldrb     w8, [x20, #0xfc4]
00686D7A4  cbnz     w8, #0x686d7bc
00686D7A8  adrp     x0, #0x8f05000
00686D7AC  ldr      x0, [x0, #0xfd8]
00686D7B0  bl       #0x382bd14 ; 
00686D7B4  mov      w8, #1
00686D7B8  strb     w8, [x20, #0xfc4]
00686D7BC  ldr      x1, [x23]
00686D7C0  ldrb     w8, [x1, #0x53]
00686D7C4  tbnz     w8, #5, #0x686d7d0
00686D7C8  ldr      x0, [x26, #0x220]
00686D7CC  b        #0x686d7dc ; 
00686D7D0  ldr      x8, [x1, #0x60]
00686D7D4  mov      x0, x26
00686D7D8  blr      x8
00686D7DC  cbz      x0, #0x686de0c
00686D7E0  ldr      x8, [x0]
00686D7E4  ldr      x9, [x8, #0x518]
00686D7E8  ldr      x1, [x8, #0x520]
00686D7EC  blr      x9
00686D7F0  cbz      x25, #0x686de0c
00686D7F4  adrp     x22, #0x959b000
00686D7F8  ldrb     w8, [x22, #0xb9f]
00686D7FC  mov      w26, w0
00686D800  cbnz     w8, #0x686d818
00686D804  adrp     x0, #0x8f23000
00686D808  ldr      x0, [x0, #0xe90]
00686D80C  bl       #0x382bd14 ; 
00686D810  mov      w8, #1
00686D814  strb     w8, [x22, #0xb9f]
00686D818  adrp     x8, #0x8f23000
00686D81C  ldr      x8, [x8, #0xe90]
00686D820  ldr      x2, [x8]
00686D824  ldrb     w8, [x2, #0x53]
00686D828  tbnz     w8, #5, #0x686d834
00686D82C  str      w26, [x25, #0x40]
00686D830  b        #0x686d844 ; 
00686D834  ldr      x8, [x2, #0x60]
00686D838  mov      x0, x25
00686D83C  mov      w1, w26
00686D840  blr      x8
00686D844  ldrb     w8, [x29, #0xa4b]
00686D848  ldr      x25, [x19, #0x80]
00686D84C  cbnz     w8, #0x686d864
00686D850  adrp     x0, #0x8ee5000
00686D854  ldr      x0, [x0, #0xb28]
00686D858  bl       #0x382bd14 ; 
00686D85C  mov      w8, #1
00686D860  strb     w8, [x29, #0xa4b]
00686D864  ldr      x1, [x21]
00686D868  ldrb     w8, [x1, #0x53]
00686D86C  tbnz     w8, #5, #0x686d878
00686D870  ldr      x26, [x19, #0x20]
00686D874  b        #0x686d888 ; 
00686D878  ldr      x8, [x1, #0x60]
00686D87C  mov      x0, x19
00686D880  blr      x8
00686D884  mov      x26, x0
00686D888  adrp     x21, #0x9591000
00686D88C  cbz      x26, #0x686de0c
00686D890  ldrb     w8, [x20, #0xfc4]
00686D894  cbnz     w8, #0x686d8ac
00686D898  adrp     x0, #0x8f05000
00686D89C  ldr      x0, [x0, #0xfd8]
00686D8A0  bl       #0x382bd14 ; 
00686D8A4  mov      w8, #1
00686D8A8  strb     w8, [x20, #0xfc4]
00686D8AC  ldr      x1, [x23]
00686D8B0  ldrb     w8, [x1, #0x53]
00686D8B4  tbnz     w8, #5, #0x686d8c0
00686D8B8  ldr      x0, [x26, #0x220]
00686D8BC  b        #0x686d8cc ; 
00686D8C0  ldr      x8, [x1, #0x60]
00686D8C4  mov      x0, x26
00686D8C8  blr      x8
00686D8CC  cbz      x0, #0x686de0c
00686D8D0  ldr      x8, [x0]
00686D8D4  ldr      x9, [x8, #0x528]
00686D8D8  ldr      x1, [x8, #0x530]
00686D8DC  blr      x9
00686D8E0  cbz      x25, #0x686de0c
00686D8E4  adrp     x20, #0x959b000
00686D8E8  ldrb     w8, [x20, #0xba1]
00686D8EC  mov      w26, w0
00686D8F0  cbnz     w8, #0x686d908
00686D8F4  adrp     x0, #0x8f23000
00686D8F8  ldr      x0, [x0, #0xe70]
00686D8FC  bl       #0x382bd14 ; 
00686D900  mov      w8, #1
00686D904  strb     w8, [x20, #0xba1]
00686D908  adrp     x8, #0x8f23000
00686D90C  ldr      x8, [x8, #0xe70]
00686D910  ldr      x2, [x8]
00686D914  ldrb     w8, [x2, #0x53]
00686D918  tbnz     w8, #5, #0x686d924
00686D91C  str      w26, [x25, #0x38]
00686D920  b        #0x686d934 ; 
00686D924  ldr      x8, [x2, #0x60]
00686D928  mov      x0, x25
00686D92C  mov      w1, w26
00686D930  blr      x8
00686D934  ldr      x1, [x27]
00686D938  ldr      x25, [x19, #0x80]
00686D93C  ldrb     w8, [x1, #0x53]
00686D940  tbnz     w8, #5, #0x686d94c
00686D944  ldr      x0, [x19, #0x30]
00686D948  b        #0x686d958 ; 
00686D94C  ldr      x8, [x1, #0x60]
00686D950  mov      x0, x19
00686D954  blr      x8
00686D958  cbz      x0, #0x686de0c
00686D95C  adrp     x8, #0x8ee6000
00686D960  ldr      x8, [x8, #0xd8]
00686D964  ldr      x1, [x8]
00686D968  ldrb     w8, [x1, #0x53]
00686D96C  tbnz     w8, #5, #0x686d978
00686D970  ldr      x26, [x0, #0x38]
00686D974  b        #0x686d984 ; 
00686D978  ldr      x8, [x1, #0x60]
00686D97C  blr      x8
00686D980  mov      x26, x0
00686D984  cbz      x26, #0x686de0c
00686D988  ldrb     w8, [x21, #0xa7f]
00686D98C  cbnz     w8, #0x686d9a4
00686D990  adrp     x0, #0x8ee6000
00686D994  ldr      x0, [x0, #0x2d8]
00686D998  bl       #0x382bd14 ; 
00686D99C  mov      w8, #1
00686D9A0  strb     w8, [x21, #0xa7f]
00686D9A4  adrp     x8, #0x8ee6000
00686D9A8  ldr      x8, [x8, #0x2d8]
00686D9AC  ldr      x1, [x8]
00686D9B0  ldrb     w8, [x1, #0x53]
00686D9B4  tbnz     w8, #5, #0x686d9c0
00686D9B8  ldr      x0, [x26, #0x178]
00686D9BC  b        #0x686d9cc ; 
00686D9C0  ldr      x8, [x1, #0x60]
00686D9C4  mov      x0, x26
00686D9C8  blr      x8
00686D9CC  cbz      x0, #0x686de0c
00686D9D0  mov      x1, xzr
00686D9D4  bl       #0x6b3cf00 ; HotFix.Common.AttributeData$$GetAttack
00686D9D8  cbz      x25, #0x686de0c
00686D9DC  adrp     x20, #0x959b000
00686D9E0  ldrb     w8, [x20, #0xb9b]
00686D9E4  lsr      x26, x0, #0x10
00686D9E8  cbnz     w8, #0x686da00
00686D9EC  adrp     x0, #0x8f23000
00686D9F0  ldr      x0, [x0, #0xec0]
00686D9F4  bl       #0x382bd14 ; 
00686D9F8  mov      w8, #1
00686D9FC  strb     w8, [x20, #0xb9b]
00686DA00  adrp     x8, #0x8f23000
00686DA04  ldr      x8, [x8, #0xec0]
00686DA08  ldr      x2, [x8]
00686DA0C  ldrb     w8, [x2, #0x53]
00686DA10  tbnz     w8, #5, #0x686da1c
00686DA14  str      w26, [x25, #0x4c]
00686DA18  b        #0x686da2c ; 
00686DA1C  ldr      x8, [x2, #0x60]
00686DA20  mov      x0, x25
00686DA24  mov      w1, w26
00686DA28  blr      x8
00686DA2C  ldr      x1, [x27]
00686DA30  ldr      x25, [x19, #0x80]
00686DA34  ldrb     w8, [x1, #0x53]
00686DA38  tbnz     w8, #5, #0x686da44
00686DA3C  ldr      x0, [x19, #0x30]
00686DA40  b        #0x686da50 ; 
00686DA44  ldr      x8, [x1, #0x60]
00686DA48  mov      x0, x19
00686DA4C  blr      x8
00686DA50  cbz      x0, #0x686de0c
00686DA54  ldr      x8, [x0]
00686DA58  ldr      x9, [x8, #0x498]
00686DA5C  ldr      x1, [x8, #0x4a0]
00686DA60  blr      x9
00686DA64  cbz      x25, #0x686de0c
00686DA68  adrp     x20, #0x959b000
00686DA6C  ldrb     w8, [x20, #0xb9d]
00686DA70  mov      w26, w0
00686DA74  cbnz     w8, #0x686da8c
00686DA78  adrp     x0, #0x8f23000
00686DA7C  ldr      x0, [x0, #0xed0]
00686DA80  bl       #0x382bd14 ; 
00686DA84  mov      w8, #1
00686DA88  strb     w8, [x20, #0xb9d]
00686DA8C  adrp     x8, #0x8f23000
00686DA90  ldr      x8, [x8, #0xed0]
00686DA94  ldr      x2, [x8]
00686DA98  ldrb     w8, [x2, #0x53]
00686DA9C  tbnz     w8, #5, #0x686daa8
00686DAA0  str      w26, [x25, #0x50]
00686DAA4  b        #0x686dab8 ; 
00686DAA8  ldr      x8, [x2, #0x60]
00686DAAC  mov      x0, x25
00686DAB0  mov      w1, w26
00686DAB4  blr      x8
00686DAB8  ldr      x25, [x19, #0x80]
00686DABC  cbz      x25, #0x686de0c
00686DAC0  adrp     x21, #0x959b000
00686DAC4  ldrb     w8, [x21, #0xba3]
00686DAC8  cmp      x24, #0
00686DACC  cset     w20, ne
00686DAD0  cbnz     w8, #0x686dae8
00686DAD4  adrp     x0, #0x8f23000
00686DAD8  ldr      x0, [x0, #0xf00]
00686DADC  bl       #0x382bd14 ; 
00686DAE0  mov      w8, #1
00686DAE4  strb     w8, [x21, #0xba3]
00686DAE8  adrp     x8, #0x8f23000
00686DAEC  ldr      x8, [x8, #0xf00]
00686DAF0  ldr      x2, [x8]
00686DAF4  ldrb     w8, [x2, #0x53]
00686DAF8  tbnz     w8, #5, #0x686db04
00686DAFC  strb     w20, [x25, #0x6c]
00686DB00  b        #0x686db18 ; 
00686DB04  ldr      x8, [x2, #0x60]
00686DB08  cmp      x24, #0
00686DB0C  cset     w1, ne
00686DB10  mov      x0, x25
00686DB14  blr      x8
00686DB18  adrp     x21, #0x8ee5000
00686DB1C  ldr      x21, [x21, #0xb28]
00686DB20  ldr      x24, [x19, #0x80]
00686DB24  cbz      x24, #0x686de0c
00686DB28  str      wzr, [x24, #0x10]
00686DB2C  adrp     x20, #0x959b000
00686DB30  ldrb     w8, [x20, #0xba5]
00686DB34  cbnz     w8, #0x686db4c
00686DB38  adrp     x0, #0x8f23000
00686DB3C  ldr      x0, [x0, #0xf10]
00686DB40  bl       #0x382bd14 ; 
00686DB44  mov      w8, #1
00686DB48  strb     w8, [x20, #0xba5]
00686DB4C  adrp     x8, #0x8f23000
00686DB50  ldr      x8, [x8, #0xf10]
00686DB54  ldr      x2, [x8]
00686DB58  ldrb     w8, [x2, #0x53]
00686DB5C  tbnz     w8, #5, #0x686db6c
00686DB60  ldr      w8, [sp, #8]
00686DB64  str      w8, [x24, #0x70]
00686DB68  b        #0x686db7c ; 
00686DB6C  ldr      x8, [x2, #0x60]
00686DB70  ldr      w1, [sp, #8]
00686DB74  mov      x0, x24
00686DB78  blr      x8
00686DB7C  ldr      x22, [x19, #0x80]
00686DB80  ldr      w23, [sp, #4]
00686DB84  cbz      x22, #0x686de0c
00686DB88  str      w28, [x22, #0x74]
00686DB8C  ldrb     w8, [x29, #0xa4b]
00686DB90  cbnz     w8, #0x686dba8
00686DB94  adrp     x0, #0x8ee5000
00686DB98  ldr      x0, [x0, #0xb28]
00686DB9C  bl       #0x382bd14 ; 
00686DBA0  mov      w8, #1
00686DBA4  strb     w8, [x29, #0xa4b]
00686DBA8  ldr      x1, [x21]
00686DBAC  ldrb     w8, [x1, #0x53]
00686DBB0  tbnz     w8, #5, #0x686dbbc
00686DBB4  ldr      x0, [x19, #0x20]
00686DBB8  b        #0x686dbc8 ; 
00686DBBC  ldr      x8, [x1, #0x60]
00686DBC0  mov      x0, x19
00686DBC4  blr      x8
00686DBC8  cbz      x0, #0x686de0c
00686DBCC  ldr      x1, [x27]
00686DBD0  ldr      x21, [x0, #0x1d0]
00686DBD4  ldrb     w8, [x1, #0x53]
00686DBD8  tbnz     w8, #5, #0x686dbe4
00686DBDC  ldr      x0, [x19, #0x30]
00686DBE0  b        #0x686dbf0 ; 
00686DBE4  ldr      x8, [x1, #0x60]
00686DBE8  mov      x0, x19
00686DBEC  blr      x8
00686DBF0  cbz      x0, #0x686de0c
00686DBF4  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
00686DBF8  cbz      x21, #0x686de0c
00686DBFC  mov      w1, w0
00686DC00  mov      x0, x21
00686DC04  mov      x2, xzr
00686DC08  bl       #0x6a4802c ; HotFix.BattleLogic.WorldInitInfo$$GetPlayerInfoByPlayerID
00686DC0C  cbz      x0, #0x686de0c
00686DC10  adrp     x20, #0x9599000
00686DC14  ldrb     w8, [x20, #0x299]
00686DC18  mov      x21, x0
00686DC1C  cbnz     w8, #0x686dc34
00686DC20  adrp     x0, #0x8f07000
00686DC24  ldr      x0, [x0, #0xfd8]
00686DC28  bl       #0x382bd14 ; 
00686DC2C  mov      w8, #1
00686DC30  strb     w8, [x20, #0x299]
00686DC34  adrp     x8, #0x8f07000
00686DC38  ldr      x8, [x8, #0xfd8]
00686DC3C  ldr      x1, [x8]
00686DC40  ldrb     w8, [x1, #0x53]
00686DC44  tbnz     w8, #5, #0x686dc50
00686DC48  ldr      x1, [x21, #0x20]
00686DC4C  b        #0x686dc60 ; 
00686DC50  ldr      x8, [x1, #0x60]
00686DC54  mov      x0, x21
00686DC58  blr      x8
00686DC5C  mov      x1, x0
00686DC60  str      x1, [x22, #0x78]!
00686DC64  mov      x0, x22
00686DC68  bl       #0x382bcb8 ; 
00686DC6C  adrp     x21, #0x8ee5000
00686DC70  ldr      x21, [x21, #0xb28]
00686DC74  tbz      w23, #0, #0x686dd44
00686DC78  ldrb     w8, [x29, #0xa4b]
00686DC7C  cbnz     w8, #0x686dc94
00686DC80  adrp     x0, #0x8ee5000
00686DC84  ldr      x0, [x0, #0xb28]
00686DC88  bl       #0x382bd14 ; 
00686DC8C  mov      w8, #1
00686DC90  strb     w8, [x29, #0xa4b]
00686DC94  ldr      x1, [x21]
00686DC98  ldrb     w8, [x1, #0x53]
00686DC9C  tbnz     w8, #5, #0x686dca8
00686DCA0  ldr      x0, [x19, #0x20]
00686DCA4  b        #0x686dcb4 ; 
00686DCA8  ldr      x8, [x1, #0x60]
00686DCAC  mov      x0, x19
00686DCB0  blr      x8
00686DCB4  cbz      x0, #0x686de0c
00686DCB8  mov      x1, xzr
00686DCBC  bl       #0x6a009e8 ; HotFix.BattleLogic.BattleWorldContext$$ResetGameSpeed
00686DCC0  ldrb     w8, [x29, #0xa4b]
00686DCC4  cbnz     w8, #0x686dcdc
00686DCC8  adrp     x0, #0x8ee5000
00686DCCC  ldr      x0, [x0, #0xb28]
00686DCD0  bl       #0x382bd14 ; 
00686DCD4  mov      w8, #1
00686DCD8  strb     w8, [x29, #0xa4b]
00686DCDC  ldr      x1, [x21]
00686DCE0  ldrb     w8, [x1, #0x53]
00686DCE4  tbnz     w8, #5, #0x686dcf0
00686DCE8  ldr      x20, [x19, #0x20]
00686DCEC  b        #0x686dd00 ; 
00686DCF0  ldr      x8, [x1, #0x60]
00686DCF4  mov      x0, x19
00686DCF8  blr      x8
00686DCFC  mov      x20, x0
00686DD00  ldr      x1, [x27]
00686DD04  ldrb     w8, [x1, #0x53]
00686DD08  tbnz     w8, #5, #0x686dd14
00686DD0C  ldr      x0, [x19, #0x30]
00686DD10  b        #0x686dd20 ; 
00686DD14  ldr      x8, [x1, #0x60]
00686DD18  mov      x0, x19
00686DD1C  blr      x8
00686DD20  cbz      x0, #0x686de0c
00686DD24  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
00686DD28  cbz      x20, #0x686de0c
00686DD2C  ldr      x3, [x19, #0x80]
00686DD30  mov      w1, w0
00686DD34  mov      w2, #1
00686DD38  mov      x0, x20
00686DD3C  mov      x4, xzr
00686DD40  bl       #0x6a0f95c ; HotFix.BattleLogic.BattleWorldContext$$DisPatchOpenViewEvent
00686DD44  ldrb     w8, [x29, #0xa4b]
00686DD48  cbnz     w8, #0x686dd60
00686DD4C  adrp     x0, #0x8ee5000
00686DD50  ldr      x0, [x0, #0xb28]
00686DD54  bl       #0x382bd14 ; 
00686DD58  mov      w8, #1
00686DD5C  strb     w8, [x29, #0xa4b]
00686DD60  ldr      x1, [x21]
00686DD64  ldr      x21, [sp, #0x10]
00686DD68  adrp     x20, #0x9591000
00686DD6C  ldrb     w8, [x1, #0x53]
00686DD70  tbnz     w8, #5, #0x686dd7c
00686DD74  ldr      x19, [x19, #0x20]
00686DD78  b        #0x686dd8c ; 
00686DD7C  ldr      x8, [x1, #0x60]
00686DD80  mov      x0, x19
00686DD84  blr      x8
00686DD88  mov      x19, x0
00686DD8C  cbz      x19, #0x686de0c
00686DD90  ldrb     w8, [x20, #0xa90]
00686DD94  cbnz     w8, #0x686ddac
00686DD98  adrp     x0, #0x8ee6000
00686DD9C  ldr      x0, [x0, #0x3e0]
00686DDA0  bl       #0x382bd14 ; 
00686DDA4  mov      w8, #1
00686DDA8  strb     w8, [x20, #0xa90]
00686DDAC  adrp     x8, #0x8ee6000
00686DDB0  ldr      x8, [x8, #0x3e0]
00686DDB4  ldr      x1, [x8]
00686DDB8  ldrb     w8, [x1, #0x53]
00686DDBC  tbnz     w8, #5, #0x686ddc8
00686DDC0  ldr      x0, [x19, #0x230]
00686DDC4  b        #0x686ddd4 ; 
00686DDC8  ldr      x8, [x1, #0x60]
00686DDCC  mov      x0, x19
00686DDD0  blr      x8
00686DDD4  cbz      x0, #0x686de0c
00686DDD8  adrp     x8, #0x8f08000
00686DDDC  ldr      x8, [x8, #0xbc0]
00686DDE0  mov      x1, x21
00686DDE4  ldr      x2, [x8]
00686DDE8  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
00686DDEC  ldp      x20, x19, [sp, #0x70]
00686DDF0  ldp      x22, x21, [sp, #0x60]
00686DDF4  ldp      x24, x23, [sp, #0x50]
00686DDF8  ldp      x26, x25, [sp, #0x40]
00686DDFC  ldp      x28, x27, [sp, #0x30]
00686DE00  ldp      x29, x30, [sp, #0x20]
00686DE04  add      sp, sp, #0x80
00686DE08  ret      
00686DE0C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckQualityUp
; RVA 0x686DE10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686DE10  sub      sp, sp, #0x40
00686DE14  stp      x30, x23, [sp, #0x10]
00686DE18  stp      x22, x21, [sp, #0x20]
00686DE1C  stp      x20, x19, [sp, #0x30]
00686DE20  adrp     x20, #0x959b000
00686DE24  adrp     x21, #0x8f24000
00686DE28  ldrb     w8, [x20, #0xa51]
00686DE2C  ldr      x21, [x21, #0x208]
00686DE30  mov      x19, x0
00686DE34  tbnz     w8, #0, #0x686de7c
00686DE38  adrp     x0, #0x8ee6000
00686DE3C  ldr      x0, [x0, #0xd8]
00686DE40  bl       #0x382bd14 ; 
00686DE44  adrp     x0, #0x8ee6000
00686DE48  ldr      x0, [x0, #0xe8]
00686DE4C  bl       #0x382bd14 ; 
00686DE50  adrp     x0, #0x8f23000
00686DE54  ldr      x0, [x0, #0x140]
00686DE58  bl       #0x382bd14 ; 
00686DE5C  adrp     x0, #0x8f24000
00686DE60  ldr      x0, [x0, #0x208]
00686DE64  bl       #0x382bd14 ; 
00686DE68  adrp     x0, #0x8f24000
00686DE6C  ldr      x0, [x0, #0x210]
00686DE70  bl       #0x382bd14 ; 
00686DE74  mov      w8, #1
00686DE78  strb     w8, [x20, #0xa51]
00686DE7C  ldr      x1, [x21]
00686DE80  ldrb     w8, [x1, #0x53]
00686DE84  tbnz     w8, #5, #0x686dea4
00686DE88  adrp     x21, #0x8f23000
00686DE8C  ldr      x21, [x21, #0x140]
00686DE90  ldr      x1, [x21]
00686DE94  ldrb     w8, [x1, #0x53]
00686DE98  tbnz     w8, #5, #0x686dec0
00686DE9C  ldr      x0, [x19, #0x30]
00686DEA0  b        #0x686decc ; 
00686DEA4  ldr      x2, [x1, #0x60]
00686DEA8  mov      x0, x19
00686DEAC  ldp      x20, x19, [sp, #0x30]
00686DEB0  ldp      x22, x21, [sp, #0x20]
00686DEB4  ldp      x30, x23, [sp, #0x10]
00686DEB8  add      sp, sp, #0x40
00686DEBC  br       x2
00686DEC0  ldr      x8, [x1, #0x60]
00686DEC4  mov      x0, x19
00686DEC8  blr      x8
00686DECC  cbz      x0, #0x686e09c
00686DED0  adrp     x8, #0x8ee6000
00686DED4  ldr      x8, [x8, #0xd8]
00686DED8  ldr      x1, [x8]
00686DEDC  ldrb     w8, [x1, #0x53]
00686DEE0  tbnz     w8, #5, #0x686deec
00686DEE4  ldr      x20, [x0, #0x38]
00686DEE8  b        #0x686def8 ; 
00686DEEC  ldr      x8, [x1, #0x60]
00686DEF0  blr      x8
00686DEF4  mov      x20, x0
00686DEF8  cbz      x20, #0x686e09c
00686DEFC  adrp     x22, #0x9591000
00686DF00  ldrb     w8, [x22, #0xa7f]
00686DF04  cbnz     w8, #0x686df1c
00686DF08  adrp     x0, #0x8ee6000
00686DF0C  ldr      x0, [x0, #0x2d8]
00686DF10  bl       #0x382bd14 ; 
00686DF14  mov      w8, #1
00686DF18  strb     w8, [x22, #0xa7f]
00686DF1C  adrp     x8, #0x8ee6000
00686DF20  ldr      x8, [x8, #0x2d8]
00686DF24  ldr      x1, [x8]
00686DF28  ldrb     w8, [x1, #0x53]
00686DF2C  tbnz     w8, #5, #0x686df38
00686DF30  ldr      x0, [x20, #0x178]
00686DF34  b        #0x686df44 ; 
00686DF38  ldr      x8, [x1, #0x60]
00686DF3C  mov      x0, x20
00686DF40  blr      x8
00686DF44  cbz      x0, #0x686e09c
00686DF48  adrp     x8, #0x8f24000
00686DF4C  ldr      x8, [x8, #0x210]
00686DF50  mov      x2, xzr
00686DF54  ldr      x1, [x8]
00686DF58  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686DF5C  cmp      x0, #1
00686DF60  b.lt     #0x686dff4
00686DF64  adrp     x22, #0x9591000
00686DF68  ldrb     w8, [x22, #0xa4b]
00686DF6C  mov      x20, x0
00686DF70  cbnz     w8, #0x686df88
00686DF74  adrp     x0, #0x8ee5000
00686DF78  ldr      x0, [x0, #0xb28]
00686DF7C  bl       #0x382bd14 ; 
00686DF80  mov      w8, #1
00686DF84  strb     w8, [x22, #0xa4b]
00686DF88  adrp     x23, #0x8ee5000
00686DF8C  ldr      x23, [x23, #0xb28]
00686DF90  ldr      x1, [x23]
00686DF94  ldrb     w8, [x1, #0x53]
00686DF98  tbnz     w8, #5, #0x686dfa4
00686DF9C  ldr      x0, [x19, #0x20]
00686DFA0  b        #0x686dfb0 ; 
00686DFA4  ldr      x8, [x1, #0x60]
00686DFA8  mov      x0, x19
00686DFAC  blr      x8
00686DFB0  cbz      x0, #0x686e09c
00686DFB4  mov      x1, x20
00686DFB8  mov      x2, xzr
00686DFBC  bl       #0x6a015a4 ; HotFix.BattleLogic.BattleWorldContext$$SkillRandomNextBool
00686DFC0  tbz      w0, #0, #0x686dff4
00686DFC4  ldrb     w8, [x22, #0xa4b]
00686DFC8  cbnz     w8, #0x686dfe0
00686DFCC  adrp     x0, #0x8ee5000
00686DFD0  ldr      x0, [x0, #0xb28]
00686DFD4  bl       #0x382bd14 ; 
00686DFD8  mov      w8, #1
00686DFDC  strb     w8, [x22, #0xa4b]
00686DFE0  ldr      x1, [x23]
00686DFE4  ldrb     w8, [x1, #0x53]
00686DFE8  tbnz     w8, #5, #0x686dffc
00686DFEC  ldr      x20, [x19, #0x20]
00686DFF0  b        #0x686e00c ; 
00686DFF4  mov      w0, wzr
00686DFF8  b        #0x686e088 ; 
00686DFFC  ldr      x8, [x1, #0x60]
00686E000  mov      x0, x19
00686E004  blr      x8
00686E008  mov      x20, x0
00686E00C  ldr      x1, [x21]
00686E010  ldrb     w8, [x1, #0x53]
00686E014  tbnz     w8, #5, #0x686e020
00686E018  ldr      x0, [x19, #0x30]
00686E01C  b        #0x686e02c ; 
00686E020  ldr      x8, [x1, #0x60]
00686E024  mov      x0, x19
00686E028  blr      x8
00686E02C  cbz      x0, #0x686e09c
00686E030  adrp     x8, #0x8ee6000
00686E034  ldr      x8, [x8, #0xe8]
00686E038  ldr      x1, [x8]
00686E03C  ldrb     w8, [x1, #0x53]
00686E040  tbnz     w8, #5, #0x686e04c
00686E044  ldr      x3, [x0, #0x28]
00686E048  b        #0x686e058 ; 
00686E04C  ldr      x8, [x1, #0x60]
00686E050  blr      x8
00686E054  mov      x3, x0
00686E058  cbz      x20, #0x686e09c
00686E05C  mov      w1, #0x11
00686E060  mov      w4, #0x10000
00686E064  mov      x0, x20
00686E068  mov      w2, wzr
00686E06C  mov      w5, wzr
00686E070  mov      w6, wzr
00686E074  mov      x7, xzr
00686E078  str      xzr, [sp, #8]
00686E07C  str      wzr, [sp]
00686E080  bl       #0x6a0ed24 ; HotFix.BattleLogic.BattleWorldContext$$ShowHoverEvent
00686E084  mov      w0, #1
00686E088  ldp      x20, x19, [sp, #0x30]
00686E08C  ldp      x22, x21, [sp, #0x20]
00686E090  ldp      x30, x23, [sp, #0x10]
00686E094  add      sp, sp, #0x40
00686E098  ret      
00686E09C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$FillNormalSkill
; RVA 0x686E568; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686E568  sub      sp, sp, #0x90
00686E56C  str      x30, [sp, #0x40]
00686E570  stp      x26, x25, [sp, #0x50]
00686E574  stp      x24, x23, [sp, #0x60]
00686E578  stp      x22, x21, [sp, #0x70]
00686E57C  stp      x20, x19, [sp, #0x80]
00686E580  adrp     x21, #0x959b000
00686E584  adrp     x22, #0x8f24000
00686E588  ldrb     w8, [x21, #0xa52]
00686E58C  ldr      x22, [x22, #0x230]
00686E590  mov      x20, x1
00686E594  mov      x19, x0
00686E598  tbnz     w8, #0, #0x686e5f8
00686E59C  adrp     x0, #0x8f09000
00686E5A0  ldr      x0, [x0, #0x150]
00686E5A4  bl       #0x382bd14 ; 
00686E5A8  adrp     x0, #0x8f23000
00686E5AC  ldr      x0, [x0, #0x140]
00686E5B0  bl       #0x382bd14 ; 
00686E5B4  adrp     x0, #0x8ee5000
00686E5B8  ldr      x0, [x0, #0x768]
00686E5BC  bl       #0x382bd14 ; 
00686E5C0  adrp     x0, #0x8ee5000
00686E5C4  ldr      x0, [x0, #0x770]
00686E5C8  bl       #0x382bd14 ; 
00686E5CC  adrp     x0, #0x8ee5000
00686E5D0  ldr      x0, [x0, #0x788]
00686E5D4  bl       #0x382bd14 ; 
00686E5D8  adrp     x0, #0x8f24000
00686E5DC  ldr      x0, [x0, #0x230]
00686E5E0  bl       #0x382bd14 ; 
00686E5E4  adrp     x0, #0x8ee5000
00686E5E8  ldr      x0, [x0, #0x7a0]
00686E5EC  bl       #0x382bd14 ; 
00686E5F0  mov      w8, #1
00686E5F4  strb     w8, [x21, #0xa52]
00686E5F8  ldr      x2, [x22]
00686E5FC  ldrb     w8, [x2, #0x53]
00686E600  tbnz     w8, #5, #0x686e628
00686E604  adrp     x23, #0x8f23000
00686E608  ldr      x23, [x23, #0x140]
00686E60C  stp      xzr, xzr, [sp, #0x20]
00686E610  str      xzr, [sp, #0x30]
00686E614  ldr      x1, [x23]
00686E618  ldrb     w8, [x1, #0x53]
00686E61C  tbnz     w8, #5, #0x686e650
00686E620  ldr      x0, [x19, #0x30]
00686E624  b        #0x686e65c ; 
00686E628  ldr      x3, [x2, #0x60]
00686E62C  mov      x0, x19
00686E630  mov      x1, x20
00686E634  ldp      x20, x19, [sp, #0x80]
00686E638  ldp      x22, x21, [sp, #0x70]
00686E63C  ldp      x24, x23, [sp, #0x60]
00686E640  ldp      x26, x25, [sp, #0x50]
00686E644  ldr      x30, [sp, #0x40]
00686E648  add      sp, sp, #0x90
00686E64C  br       x3
00686E650  ldr      x8, [x1, #0x60]
00686E654  mov      x0, x19
00686E658  blr      x8
00686E65C  cbz      x0, #0x686e7a0
00686E660  adrp     x8, #0x8f09000
00686E664  ldr      x8, [x8, #0x150]
00686E668  ldr      x1, [x8]
00686E66C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00686E670  cbz      x0, #0x686e7a0
00686E674  mov      x1, xzr
00686E678  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
00686E67C  mov      w4, w0
00686E680  add      x5, sp, #0x4c
00686E684  mov      x0, x19
00686E688  mov      x1, x20
00686E68C  mov      w2, wzr
00686E690  mov      w3, wzr
00686E694  str      wzr, [sp, #0x4c]
00686E698  bl       #0x686e0a0 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetNormalSkill
00686E69C  cbz      x20, #0x686e7a0
00686E6A0  adrp     x8, #0x8ee5000
00686E6A4  ldr      x8, [x8, #0x7a0]
00686E6A8  mov      x0, x20
00686E6AC  ldr      x1, [x8]
00686E6B0  add      x8, sp, #8
00686E6B4  bl       #0x4d65168 ; System.Collections.Generic.List<int>$$GetEnumerator
00686E6B8  ldur     q0, [sp, #8]
00686E6BC  ldr      x8, [sp, #0x18]
00686E6C0  adrp     x24, #0x8ee5000
00686E6C4  adrp     x20, #0x8ee5000
00686E6C8  ldr      x24, [x24, #0x770]
00686E6CC  ldr      x20, [x20, #0xb28]
00686E6D0  adrp     x25, #0x9591000
00686E6D4  str      q0, [sp, #0x20]
00686E6D8  str      x8, [sp, #0x30]
00686E6DC  mov      w26, #1
00686E6E0  ldr      x1, [x24]
00686E6E4  add      x0, sp, #0x20
00686E6E8  bl       #0x60e2380 ; System.Collections.Generic.List.Enumerator<int>$$MoveNext
00686E6EC  tbz      w0, #0, #0x686e76c
00686E6F0  ldrb     w8, [x25, #0xa4b]
00686E6F4  ldr      w21, [sp, #0x30]
00686E6F8  cbnz     w8, #0x686e708
00686E6FC  mov      x0, x20
00686E700  bl       #0x382bd14 ; 
00686E704  strb     w26, [x25, #0xa4b]
00686E708  ldr      x1, [x20]
00686E70C  ldrb     w8, [x1, #0x53]
00686E710  tbnz     w8, #5, #0x686e71c
00686E714  ldr      x22, [x19, #0x20]
00686E718  b        #0x686e72c ; 
00686E71C  ldr      x8, [x1, #0x60]
00686E720  mov      x0, x19
00686E724  blr      x8
00686E728  mov      x22, x0
00686E72C  ldr      x1, [x23]
00686E730  ldrb     w8, [x1, #0x53]
00686E734  tbnz     w8, #5, #0x686e740
00686E738  ldr      x1, [x19, #0x30]
00686E73C  b        #0x686e750 ; 
00686E740  ldr      x8, [x1, #0x60]
00686E744  mov      x0, x19
00686E748  blr      x8
00686E74C  mov      x1, x0
00686E750  cbz      x22, #0x686e79c
00686E754  mov      w3, #1
00686E758  mov      x0, x22
00686E75C  mov      w2, w21
00686E760  mov      x4, xzr
00686E764  bl       #0x6a0dd34 ; HotFix.BattleLogic.BattleWorldContext$$AddSkillToCharacter
00686E768  b        #0x686e6e0 ; 
00686E76C  adrp     x8, #0x8ee5000
00686E770  ldr      x8, [x8, #0x768]
00686E774  add      x0, sp, #0x20
00686E778  ldr      x1, [x8]
00686E77C  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
00686E780  ldp      x20, x19, [sp, #0x80]
00686E784  ldp      x22, x21, [sp, #0x70]
00686E788  ldp      x24, x23, [sp, #0x60]
00686E78C  ldp      x26, x25, [sp, #0x50]
00686E790  ldr      x30, [sp, #0x40]
00686E794  add      sp, sp, #0x90
00686E798  ret      
00686E79C  bl       #0x382bfb8 ; 
00686E7A0  bl       #0x382bfb8 ; 
00686E7A4  b        #0x686e7b4 ; 
00686E7A8  b        #0x686e7b4 ; 
00686E7AC  b        #0x686e7b4 ; 
00686E7B0  b        #0x686e7b4 ; 
00686E7B4  mov      x19, x0
00686E7B8  cmp      w1, #1
00686E7BC  b.ne     #0x686e7f0
00686E7C0  mov      x0, x19
00686E7C4  bl       #0x89eda50 ; 
00686E7C8  ldr      x20, [x0]
00686E7CC  bl       #0x89eda60 ; 
00686E7D0  adrp     x8, #0x8ee5000
00686E7D4  ldr      x8, [x8, #0x768]
00686E7D8  add      x0, sp, #0x20
00686E7DC  ldr      x1, [x8]
00686E7E0  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
00686E7E4  cbz      x20, #0x686e780
00686E7E8  mov      x0, x20
00686E7EC  bl       #0x382bfb0 ; 
00686E7F0  mov      x20, xzr
00686E7F4  b        #0x686e7fc ; 
00686E7F8  mov      x19, x0
00686E7FC  adrp     x8, #0x8ee5000
00686E800  ldr      x8, [x8, #0x768]
00686E804  ldr      x1, [x8]
00686E808  add      x0, sp, #0x20
00686E80C  bl       #0x60e237c ; System.Collections.Generic.List.Enumerator<int>$$Dispose
00686E810  cbnz     x20, #0x686e81c
00686E814  mov      x0, x19
00686E818  bl       #0x3b56bfc ; 
00686E81C  mov      x0, x20
00686E820  bl       #0x382bfb0 ; 
00686E824  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$PauseGame
; RVA 0x686E828; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686E828  str      x30, [sp, #-0x30]!
00686E82C  stp      x22, x21, [sp, #0x10]
00686E830  stp      x20, x19, [sp, #0x20]
00686E834  adrp     x20, #0x959b000
00686E838  adrp     x21, #0x8f24000
00686E83C  ldrb     w8, [x20, #0xa53]
00686E840  ldr      x21, [x21, #0x238]
00686E844  mov      x19, x0
00686E848  tbnz     w8, #0, #0x686e86c
00686E84C  adrp     x0, #0x8f23000
00686E850  ldr      x0, [x0, #0x140]
00686E854  bl       #0x382bd14 ; 
00686E858  adrp     x0, #0x8f24000
00686E85C  ldr      x0, [x0, #0x238]
00686E860  bl       #0x382bd14 ; 
00686E864  mov      w8, #1
00686E868  strb     w8, [x20, #0xa53]
00686E86C  ldr      x1, [x21]
00686E870  ldrb     w8, [x1, #0x53]
00686E874  tbnz     w8, #5, #0x686e894
00686E878  adrp     x21, #0x8f23000
00686E87C  ldr      x21, [x21, #0x140]
00686E880  ldr      x1, [x21]
00686E884  ldrb     w8, [x1, #0x53]
00686E888  tbnz     w8, #5, #0x686e8ac
00686E88C  ldr      x20, [x19, #0x30]
00686E890  b        #0x686e8bc ; 
00686E894  ldr      x2, [x1, #0x60]
00686E898  mov      x0, x19
00686E89C  ldp      x20, x19, [sp, #0x20]
00686E8A0  ldp      x22, x21, [sp, #0x10]
00686E8A4  ldr      x30, [sp], #0x30
00686E8A8  br       x2
00686E8AC  ldr      x8, [x1, #0x60]
00686E8B0  mov      x0, x19
00686E8B4  blr      x8
00686E8B8  mov      x20, x0
00686E8BC  cbz      x20, #0x686ea58
00686E8C0  adrp     x22, #0x9599000
00686E8C4  ldrb     w8, [x22, #0x28b]
00686E8C8  cbnz     w8, #0x686e8e0
00686E8CC  adrp     x0, #0x8f07000
00686E8D0  ldr      x0, [x0, #0xe78]
00686E8D4  bl       #0x382bd14 ; 
00686E8D8  mov      w8, #1
00686E8DC  strb     w8, [x22, #0x28b]
00686E8E0  adrp     x8, #0x8f07000
00686E8E4  ldr      x8, [x8, #0xe78]
00686E8E8  ldr      x1, [x8]
00686E8EC  ldrb     w8, [x1, #0x53]
00686E8F0  tbnz     w8, #5, #0x686e90c
00686E8F4  ldrb     w8, [x20, #0x648]
00686E8F8  cbz      w8, #0x686e91c
00686E8FC  ldp      x20, x19, [sp, #0x20]
00686E900  ldp      x22, x21, [sp, #0x10]
00686E904  ldr      x30, [sp], #0x30
00686E908  ret      
00686E90C  ldr      x8, [x1, #0x60]
00686E910  mov      x0, x20
00686E914  blr      x8
00686E918  tbnz     w0, #0, #0x686e8fc
00686E91C  ldr      x1, [x19, #0xa0]
00686E920  mov      x0, x19
00686E924  bl       #0x686ea5c ; HotFix.BattleLogic.HeroComponentRandomSkill$$FillSkillList
00686E928  adrp     x20, #0x9591000
00686E92C  ldrb     w8, [x20, #0xa4b]
00686E930  cbnz     w8, #0x686e948
00686E934  adrp     x0, #0x8ee5000
00686E938  ldr      x0, [x0, #0xb28]
00686E93C  bl       #0x382bd14 ; 
00686E940  mov      w8, #1
00686E944  strb     w8, [x20, #0xa4b]
00686E948  adrp     x22, #0x8ee5000
00686E94C  ldr      x22, [x22, #0xb28]
00686E950  ldr      x1, [x22]
00686E954  ldrb     w8, [x1, #0x53]
00686E958  tbnz     w8, #5, #0x686e964
00686E95C  ldr      x0, [x19, #0x20]
00686E960  b        #0x686e970 ; 
00686E964  ldr      x8, [x1, #0x60]
00686E968  mov      x0, x19
00686E96C  blr      x8
00686E970  cbz      x0, #0x686ea58
00686E974  mov      x1, xzr
00686E978  bl       #0x6a009e8 ; HotFix.BattleLogic.BattleWorldContext$$ResetGameSpeed
00686E97C  ldrb     w8, [x20, #0xa4b]
00686E980  cbnz     w8, #0x686e998
00686E984  adrp     x0, #0x8ee5000
00686E988  ldr      x0, [x0, #0xb28]
00686E98C  bl       #0x382bd14 ; 
00686E990  mov      w8, #1
00686E994  strb     w8, [x20, #0xa4b]
00686E998  ldr      x1, [x22]
00686E99C  ldrb     w8, [x1, #0x53]
00686E9A0  tbnz     w8, #5, #0x686e9ac
00686E9A4  ldr      x20, [x19, #0x20]
00686E9A8  b        #0x686e9bc ; 
00686E9AC  ldr      x8, [x1, #0x60]
00686E9B0  mov      x0, x19
00686E9B4  blr      x8
00686E9B8  mov      x20, x0
00686E9BC  ldr      x1, [x21]
00686E9C0  ldrb     w8, [x1, #0x53]
00686E9C4  tbnz     w8, #5, #0x686e9d0
00686E9C8  ldr      x0, [x19, #0x30]
00686E9CC  b        #0x686e9dc ; 
00686E9D0  ldr      x8, [x1, #0x60]
00686E9D4  mov      x0, x19
00686E9D8  blr      x8
00686E9DC  cbz      x0, #0x686ea58
00686E9E0  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
00686E9E4  adrp     x22, #0x9599000
00686E9E8  ldrb     w8, [x22, #0x4c7]
00686E9EC  mov      w21, w0
00686E9F0  cbnz     w8, #0x686ea08
00686E9F4  adrp     x0, #0x8f09000
00686E9F8  ldr      x0, [x0, #0xc8]
00686E9FC  bl       #0x382bd14 ; 
00686EA00  mov      w8, #1
00686EA04  strb     w8, [x22, #0x4c7]
00686EA08  adrp     x8, #0x8f09000
00686EA0C  ldr      x8, [x8, #0xc8]
00686EA10  ldr      x1, [x8]
00686EA14  ldrb     w8, [x1, #0x53]
00686EA18  tbnz     w8, #5, #0x686ea24
00686EA1C  ldr      x3, [x19, #0x58]
00686EA20  b        #0x686ea34 ; 
00686EA24  ldr      x8, [x1, #0x60]
00686EA28  mov      x0, x19
00686EA2C  blr      x8
00686EA30  mov      x3, x0
00686EA34  cbz      x20, #0x686ea58
00686EA38  mov      x0, x20
00686EA3C  mov      w1, w21
00686EA40  ldp      x20, x19, [sp, #0x20]
00686EA44  ldp      x22, x21, [sp, #0x10]
00686EA48  mov      w2, #2
00686EA4C  mov      x4, xzr
00686EA50  ldr      x30, [sp], #0x30
00686EA54  b        #0x6a0f95c ; HotFix.BattleLogic.BattleWorldContext$$DisPatchOpenViewEvent
00686EA58  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$ForcePauseGame
; RVA 0x686ECAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686ECAC  stp      x30, x21, [sp, #-0x20]!
00686ECB0  stp      x20, x19, [sp, #0x10]
00686ECB4  adrp     x20, #0x959b000
00686ECB8  adrp     x21, #0x8f24000
00686ECBC  ldrb     w8, [x20, #0xa54]
00686ECC0  ldr      x21, [x21, #0x278]
00686ECC4  mov      x19, x0
00686ECC8  tbnz     w8, #0, #0x686ece0
00686ECCC  adrp     x0, #0x8f24000
00686ECD0  ldr      x0, [x0, #0x278]
00686ECD4  bl       #0x382bd14 ; 
00686ECD8  mov      w8, #1
00686ECDC  strb     w8, [x20, #0xa54]
00686ECE0  ldr      x1, [x21]
00686ECE4  ldrb     w8, [x1, #0x53]
00686ECE8  tbnz     w8, #5, #0x686ed08
00686ECEC  ldr      x1, [x19, #0xa0]
00686ECF0  mov      x0, x19
00686ECF4  bl       #0x686ea5c ; HotFix.BattleLogic.HeroComponentRandomSkill$$FillSkillList
00686ECF8  ldr      x0, [x19, #0xa0]
00686ECFC  ldp      x20, x19, [sp, #0x10]
00686ED00  ldp      x30, x21, [sp], #0x20
00686ED04  ret      
00686ED08  ldr      x2, [x1, #0x60]
00686ED0C  mov      x0, x19
00686ED10  ldp      x20, x19, [sp, #0x10]
00686ED14  ldp      x30, x21, [sp], #0x20
00686ED18  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$FillSkillList
; RVA 0x686EA5C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686EA5C  sub      sp, sp, #0x80
00686EA60  stp      x30, x23, [sp, #0x50]
00686EA64  stp      x22, x21, [sp, #0x60]
00686EA68  stp      x20, x19, [sp, #0x70]
00686EA6C  adrp     x21, #0x959b000
00686EA70  adrp     x22, #0x8f24000
00686EA74  ldrb     w8, [x21, #0xa55]
00686EA78  ldr      x22, [x22, #0x240]
00686EA7C  mov      x19, x1
00686EA80  mov      x20, x0
00686EA84  tbnz     w8, #0, #0x686eafc
00686EA88  adrp     x0, #0x8f24000
00686EA8C  ldr      x0, [x0, #0x248]
00686EA90  bl       #0x382bd14 ; 
00686EA94  adrp     x0, #0x8f24000
00686EA98  ldr      x0, [x0, #0x250]
00686EA9C  bl       #0x382bd14 ; 
00686EAA0  adrp     x0, #0x8f24000
00686EAA4  ldr      x0, [x0, #0x258]
00686EAA8  bl       #0x382bd14 ; 
00686EAAC  adrp     x0, #0x8f24000
00686EAB0  ldr      x0, [x0, #0x240]
00686EAB4  bl       #0x382bd14 ; 
00686EAB8  adrp     x0, #0x8f24000
00686EABC  ldr      x0, [x0, #0x260]
00686EAC0  bl       #0x382bd14 ; 
00686EAC4  adrp     x0, #0x8f24000
00686EAC8  ldr      x0, [x0, #0x268]
00686EACC  bl       #0x382bd14 ; 
00686EAD0  adrp     x0, #0x8ec2000
00686EAD4  ldr      x0, [x0, #0x260]
00686EAD8  bl       #0x382bd14 ; 
00686EADC  adrp     x0, #0x8ec2000
00686EAE0  ldr      x0, [x0, #0x240]
00686EAE4  bl       #0x382bd14 ; 
00686EAE8  adrp     x0, #0x8f24000
00686EAEC  ldr      x0, [x0, #0x270]
00686EAF0  bl       #0x382bd14 ; 
00686EAF4  mov      w8, #1
00686EAF8  strb     w8, [x21, #0xa55]
00686EAFC  ldr      x2, [x22]
00686EB00  ldrb     w8, [x2, #0x53]
00686EB04  tbnz     w8, #5, #0x686ebe0
00686EB08  movi     v0.2d, #0000000000000000
00686EB0C  stp      q0, q0, [sp, #0x30]
00686EB10  cbz      x19, #0x686ec2c
00686EB14  ldr      w8, [x19, #0x1c]
00686EB18  add      w8, w8, #1
00686EB1C  stp      wzr, w8, [x19, #0x18]
00686EB20  ldr      x0, [x20, #0x48]
00686EB24  cbz      x0, #0x686ec2c
00686EB28  adrp     x8, #0x8f24000
00686EB2C  ldr      x8, [x8, #0x270]
00686EB30  ldr      x1, [x8]
00686EB34  mov      x8, sp
00686EB38  bl       #0x521e0d0 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$GetEnumerator
00686EB3C  ldp      q0, q1, [sp]
00686EB40  adrp     x21, #0x8f24000
00686EB44  ldr      x21, [x21, #0x250]
00686EB48  adrp     x22, #0x8ec2000
00686EB4C  stp      q0, q1, [sp, #0x30]
00686EB50  ldr      x22, [x22, #0x260]
00686EB54  ldr      x1, [x21]
00686EB58  add      x0, sp, #0x30
00686EB5C  bl       #0x614d804 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$MoveNext
00686EB60  tbz      w0, #0, #0x686ec00
00686EB64  ldr      x20, [sp, #0x40]
00686EB68  ldr      w8, [sp, #0x48]
00686EB6C  lsr      x23, x20, #0x20
00686EB70  cmp      w23, #1
00686EB74  str      x20, [sp, #0x20]
00686EB78  str      w8, [sp, #0x28]
00686EB7C  b.lt     #0x686eb54
00686EB80  ldr      w10, [x19, #0x1c]
00686EB84  ldr      x8, [x19, #0x10]
00686EB88  ldr      x9, [x22]
00686EB8C  add      w10, w10, #1
00686EB90  str      w10, [x19, #0x1c]
00686EB94  cbz      x8, #0x686ec28
00686EB98  ldrsw    x10, [x19, #0x18]
00686EB9C  ldr      w11, [x8, #0x18]
00686EBA0  cmp      w10, w11
00686EBA4  b.hs     #0x686ebbc
00686EBA8  add      w9, w10, #1
00686EBAC  add      x8, x8, x10, lsl #2
00686EBB0  str      w9, [x19, #0x18]
00686EBB4  str      w20, [x8, #0x20]
00686EBB8  b        #0x686ebd4 ; 
00686EBBC  ldr      x8, [x9, #0x20]
00686EBC0  ldr      x8, [x8, #0xc0]
00686EBC4  ldr      x2, [x8, #0x70]
00686EBC8  mov      x0, x19
00686EBCC  mov      w1, w20
00686EBD0  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
00686EBD4  subs     w23, w23, #1
00686EBD8  b.ne     #0x686eb80
00686EBDC  b        #0x686eb54 ; 
00686EBE0  ldr      x3, [x2, #0x60]
00686EBE4  mov      x0, x20
00686EBE8  mov      x1, x19
00686EBEC  ldp      x20, x19, [sp, #0x70]
00686EBF0  ldp      x22, x21, [sp, #0x60]
00686EBF4  ldp      x30, x23, [sp, #0x50]
00686EBF8  add      sp, sp, #0x80
00686EBFC  br       x3
00686EC00  adrp     x8, #0x8f24000
00686EC04  ldr      x8, [x8, #0x248]
00686EC08  add      x0, sp, #0x30
00686EC0C  ldr      x1, [x8]
00686EC10  bl       #0x614d958 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$Dispose
00686EC14  ldp      x20, x19, [sp, #0x70]
00686EC18  ldp      x22, x21, [sp, #0x60]
00686EC1C  ldp      x30, x23, [sp, #0x50]
00686EC20  add      sp, sp, #0x80
00686EC24  ret      
00686EC28  bl       #0x382bfb8 ; 
00686EC2C  bl       #0x382bfb8 ; 
00686EC30  b        #0x686ec38 ; 
00686EC34  b        #0x686ec38 ; 
00686EC38  mov      x19, x0
00686EC3C  cmp      w1, #1
00686EC40  b.ne     #0x686ec74
00686EC44  mov      x0, x19
00686EC48  bl       #0x89eda50 ; 
00686EC4C  ldr      x20, [x0]
00686EC50  bl       #0x89eda60 ; 
00686EC54  adrp     x8, #0x8f24000
00686EC58  ldr      x8, [x8, #0x248]
00686EC5C  add      x0, sp, #0x30
00686EC60  ldr      x1, [x8]
00686EC64  bl       #0x614d958 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$Dispose
00686EC68  cbz      x20, #0x686ec14
00686EC6C  mov      x0, x20
00686EC70  bl       #0x382bfb0 ; 
00686EC74  mov      x20, xzr
00686EC78  b        #0x686ec80 ; 
00686EC7C  mov      x19, x0
00686EC80  adrp     x8, #0x8f24000
00686EC84  ldr      x8, [x8, #0x248]
00686EC88  ldr      x1, [x8]
00686EC8C  add      x0, sp, #0x30
00686EC90  bl       #0x614d958 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$Dispose
00686EC94  cbnz     x20, #0x686eca0
00686EC98  mov      x0, x19
00686EC9C  bl       #0x3b56bfc ; 
00686ECA0  mov      x0, x20
00686ECA4  bl       #0x382bfb0 ; 
00686ECA8  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillRemainCount
; RVA 0x686ED1C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686ED1C  str      x30, [sp, #-0x30]!
00686ED20  stp      x22, x21, [sp, #0x10]
00686ED24  stp      x20, x19, [sp, #0x20]
00686ED28  adrp     x21, #0x959b000
00686ED2C  adrp     x22, #0x8f24000
00686ED30  ldrb     w8, [x21, #0xa56]
00686ED34  ldr      x22, [x22, #0x280]
00686ED38  mov      w19, w1
00686ED3C  mov      x20, x0
00686ED40  tbnz     w8, #0, #0x686ed70
00686ED44  adrp     x0, #0x8f24000
00686ED48  ldr      x0, [x0, #0x280]
00686ED4C  bl       #0x382bd14 ; 
00686ED50  adrp     x0, #0x8f23000
00686ED54  ldr      x0, [x0, #0xf98]
00686ED58  bl       #0x382bd14 ; 
00686ED5C  adrp     x0, #0x8f23000
00686ED60  ldr      x0, [x0, #0xfa0]
00686ED64  bl       #0x382bd14 ; 
00686ED68  mov      w8, #1
00686ED6C  strb     w8, [x21, #0xa56]
00686ED70  ldr      x2, [x22]
00686ED74  ldrb     w8, [x2, #0x53]
00686ED78  tbnz     w8, #5, #0x686edc8
00686ED7C  ldr      x0, [x20, #0x48]
00686ED80  cbz      x0, #0x686eeec
00686ED84  adrp     x8, #0x8f23000
00686ED88  ldr      x8, [x8, #0xf98]
00686ED8C  mov      w1, w19
00686ED90  ldr      x2, [x8]
00686ED94  bl       #0x521de14 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$ContainsKey
00686ED98  tbz      w0, #0, #0x686ede4
00686ED9C  ldr      x0, [x20, #0x48]
00686EDA0  cbz      x0, #0x686eeec
00686EDA4  adrp     x8, #0x8f23000
00686EDA8  ldr      x8, [x8, #0xfa0]
00686EDAC  mov      w1, w19
00686EDB0  ldr      x2, [x8]
00686EDB4  bl       #0x521db48 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$get_Item
00686EDB8  str      x0, [sp, #8]
00686EDBC  add      x0, sp, #8
00686EDC0  bl       #0x686667c ; HotFix.BattleLogic.HeroSkillCount$$RemainCount
00686EDC4  b        #0x686eedc ; 
00686EDC8  ldr      x3, [x2, #0x60]
00686EDCC  mov      x0, x20
00686EDD0  mov      w1, w19
00686EDD4  ldp      x20, x19, [sp, #0x20]
00686EDD8  ldp      x22, x21, [sp, #0x10]
00686EDDC  ldr      x30, [sp], #0x30
00686EDE0  br       x3
00686EDE4  adrp     x21, #0x9591000
00686EDE8  ldrb     w8, [x21, #0xa4b]
00686EDEC  cbnz     w8, #0x686ee04
00686EDF0  adrp     x0, #0x8ee5000
00686EDF4  ldr      x0, [x0, #0xb28]
00686EDF8  bl       #0x382bd14 ; 
00686EDFC  mov      w8, #1
00686EE00  strb     w8, [x21, #0xa4b]
00686EE04  adrp     x8, #0x8ee5000
00686EE08  ldr      x8, [x8, #0xb28]
00686EE0C  ldr      x1, [x8]
00686EE10  ldrb     w8, [x1, #0x53]
00686EE14  tbnz     w8, #5, #0x686ee20
00686EE18  ldr      x20, [x20, #0x20]
00686EE1C  b        #0x686ee30 ; 
00686EE20  ldr      x8, [x1, #0x60]
00686EE24  mov      x0, x20
00686EE28  blr      x8
00686EE2C  mov      x20, x0
00686EE30  cbz      x20, #0x686eeec
00686EE34  adrp     x21, #0x9598000
00686EE38  ldrb     w8, [x21, #0xfcc]
00686EE3C  cbnz     w8, #0x686ee54
00686EE40  adrp     x0, #0x8f06000
00686EE44  ldr      x0, [x0, #0x470]
00686EE48  bl       #0x382bd14 ; 
00686EE4C  mov      w8, #1
00686EE50  strb     w8, [x21, #0xfcc]
00686EE54  adrp     x8, #0x8f06000
00686EE58  ldr      x8, [x8, #0x470]
00686EE5C  ldr      x1, [x8]
00686EE60  ldrb     w8, [x1, #0x53]
00686EE64  tbnz     w8, #5, #0x686ee70
00686EE68  ldr      x0, [x20, #0x200]
00686EE6C  b        #0x686ee7c ; 
00686EE70  ldr      x8, [x1, #0x60]
00686EE74  mov      x0, x20
00686EE78  blr      x8
00686EE7C  cbz      x0, #0x686eeec
00686EE80  mov      w1, w19
00686EE84  mov      x2, xzr
00686EE88  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00686EE8C  cbz      x0, #0x686eeec
00686EE90  adrp     x20, #0x959b000
00686EE94  ldrb     w8, [x20, #0xbac]
00686EE98  mov      x19, x0
00686EE9C  cbnz     w8, #0x686eeb4
00686EEA0  adrp     x0, #0x8f24000
00686EEA4  ldr      x0, [x0, #0x58]
00686EEA8  bl       #0x382bd14 ; 
00686EEAC  mov      w8, #1
00686EEB0  strb     w8, [x20, #0xbac]
00686EEB4  adrp     x8, #0x8f24000
00686EEB8  ldr      x8, [x8, #0x58]
00686EEBC  ldr      x1, [x8]
00686EEC0  ldrb     w8, [x1, #0x53]
00686EEC4  tbnz     w8, #5, #0x686eed0
00686EEC8  ldr      w0, [x19, #0x64]
00686EECC  b        #0x686eedc ; 
00686EED0  ldr      x8, [x1, #0x60]
00686EED4  mov      x0, x19
00686EED8  blr      x8
00686EEDC  ldp      x20, x19, [sp, #0x20]
00686EEE0  ldp      x22, x21, [sp, #0x10]
00686EEE4  ldr      x30, [sp], #0x30
00686EEE8  ret      
00686EEEC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AppendSkillList
; RVA 0x686EEF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686EEF0  sub      sp, sp, #0x80
00686EEF4  stp      x30, x23, [sp, #0x50]
00686EEF8  stp      x22, x21, [sp, #0x60]
00686EEFC  stp      x20, x19, [sp, #0x70]
00686EF00  adrp     x21, #0x959b000
00686EF04  adrp     x22, #0x8f24000
00686EF08  ldrb     w8, [x21, #0xa57]
00686EF0C  ldr      x22, [x22, #0x288]
00686EF10  mov      x19, x1
00686EF14  mov      x20, x0
00686EF18  tbnz     w8, #0, #0x686ef84
00686EF1C  adrp     x0, #0x8f24000
00686EF20  ldr      x0, [x0, #0x248]
00686EF24  bl       #0x382bd14 ; 
00686EF28  adrp     x0, #0x8f24000
00686EF2C  ldr      x0, [x0, #0x250]
00686EF30  bl       #0x382bd14 ; 
00686EF34  adrp     x0, #0x8f24000
00686EF38  ldr      x0, [x0, #0x258]
00686EF3C  bl       #0x382bd14 ; 
00686EF40  adrp     x0, #0x8f24000
00686EF44  ldr      x0, [x0, #0x288]
00686EF48  bl       #0x382bd14 ; 
00686EF4C  adrp     x0, #0x8f24000
00686EF50  ldr      x0, [x0, #0x260]
00686EF54  bl       #0x382bd14 ; 
00686EF58  adrp     x0, #0x8f24000
00686EF5C  ldr      x0, [x0, #0x268]
00686EF60  bl       #0x382bd14 ; 
00686EF64  adrp     x0, #0x8ec2000
00686EF68  ldr      x0, [x0, #0x260]
00686EF6C  bl       #0x382bd14 ; 
00686EF70  adrp     x0, #0x8f24000
00686EF74  ldr      x0, [x0, #0x270]
00686EF78  bl       #0x382bd14 ; 
00686EF7C  mov      w8, #1
00686EF80  strb     w8, [x21, #0xa57]
00686EF84  ldr      x2, [x22]
00686EF88  ldrb     w8, [x2, #0x53]
00686EF8C  tbnz     w8, #5, #0x686f064
00686EF90  movi     v0.2d, #0000000000000000
00686EF94  stp      q0, q0, [sp, #0x30]
00686EF98  ldr      x0, [x20, #0x48]
00686EF9C  cbz      x0, #0x686f0b4
00686EFA0  adrp     x8, #0x8f24000
00686EFA4  ldr      x8, [x8, #0x270]
00686EFA8  ldr      x1, [x8]
00686EFAC  mov      x8, sp
00686EFB0  bl       #0x521e0d0 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$GetEnumerator
00686EFB4  ldp      q0, q1, [sp]
00686EFB8  adrp     x21, #0x8f24000
00686EFBC  ldr      x21, [x21, #0x250]
00686EFC0  adrp     x22, #0x8ec2000
00686EFC4  stp      q0, q1, [sp, #0x30]
00686EFC8  ldr      x22, [x22, #0x260]
00686EFCC  ldr      x1, [x21]
00686EFD0  add      x0, sp, #0x30
00686EFD4  bl       #0x614d804 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$MoveNext
00686EFD8  tbz      w0, #0, #0x686f084
00686EFDC  ldr      x20, [sp, #0x40]
00686EFE0  ldr      w9, [sp, #0x48]
00686EFE4  lsr      x8, x20, #0x20
00686EFE8  cmp      w8, #1
00686EFEC  str      x20, [sp, #0x20]
00686EFF0  str      w9, [sp, #0x28]
00686EFF4  b.lt     #0x686efcc
00686EFF8  cbz      x19, #0x686f0b0
00686EFFC  cmp      w8, #1
00686F000  csinc    w23, w8, wzr, gt
00686F004  ldr      w10, [x19, #0x1c]
00686F008  ldr      x8, [x19, #0x10]
00686F00C  ldr      x9, [x22]
00686F010  add      w10, w10, #1
00686F014  str      w10, [x19, #0x1c]
00686F018  cbz      x8, #0x686f0ac
00686F01C  ldrsw    x10, [x19, #0x18]
00686F020  ldr      w11, [x8, #0x18]
00686F024  cmp      w10, w11
00686F028  b.hs     #0x686f040
00686F02C  add      w9, w10, #1
00686F030  add      x8, x8, x10, lsl #2
00686F034  str      w9, [x19, #0x18]
00686F038  str      w20, [x8, #0x20]
00686F03C  b        #0x686f058 ; 
00686F040  ldr      x8, [x9, #0x20]
00686F044  ldr      x8, [x8, #0xc0]
00686F048  ldr      x2, [x8, #0x70]
00686F04C  mov      x0, x19
00686F050  mov      w1, w20
00686F054  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
00686F058  subs     w23, w23, #1
00686F05C  b.ne     #0x686f004
00686F060  b        #0x686efcc ; 
00686F064  ldr      x3, [x2, #0x60]
00686F068  mov      x0, x20
00686F06C  mov      x1, x19
00686F070  ldp      x20, x19, [sp, #0x70]
00686F074  ldp      x22, x21, [sp, #0x60]
00686F078  ldp      x30, x23, [sp, #0x50]
00686F07C  add      sp, sp, #0x80
00686F080  br       x3
00686F084  adrp     x8, #0x8f24000
00686F088  ldr      x8, [x8, #0x248]
00686F08C  add      x0, sp, #0x30
00686F090  ldr      x1, [x8]
00686F094  bl       #0x614d958 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$Dispose
00686F098  ldp      x20, x19, [sp, #0x70]
00686F09C  ldp      x22, x21, [sp, #0x60]
00686F0A0  ldp      x30, x23, [sp, #0x50]
00686F0A4  add      sp, sp, #0x80
00686F0A8  ret      
00686F0AC  bl       #0x382bfb8 ; 
00686F0B0  bl       #0x382bfb8 ; 
00686F0B4  bl       #0x382bfb8 ; 
00686F0B8  b        #0x686f0c0 ; 
00686F0BC  b        #0x686f0c0 ; 
00686F0C0  mov      x19, x0
00686F0C4  cmp      w1, #1
00686F0C8  b.ne     #0x686f0fc
00686F0CC  mov      x0, x19
00686F0D0  bl       #0x89eda50 ; 
00686F0D4  ldr      x20, [x0]
00686F0D8  bl       #0x89eda60 ; 
00686F0DC  adrp     x8, #0x8f24000
00686F0E0  ldr      x8, [x8, #0x248]
00686F0E4  add      x0, sp, #0x30
00686F0E8  ldr      x1, [x8]
00686F0EC  bl       #0x614d958 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$Dispose
00686F0F0  cbz      x20, #0x686f098
00686F0F4  mov      x0, x20
00686F0F8  bl       #0x382bfb0 ; 
00686F0FC  mov      x20, xzr
00686F100  b        #0x686f108 ; 
00686F104  mov      x19, x0
00686F108  adrp     x8, #0x8f24000
00686F10C  ldr      x8, [x8, #0x248]
00686F110  ldr      x1, [x8]
00686F114  add      x0, sp, #0x30
00686F118  bl       #0x614d958 ; Rock.Collections.OrderedDictionary.Enumerator<int, HeroSkillCount>$$Dispose
00686F11C  cbnz     x20, #0x686f128
00686F120  mov      x0, x19
00686F124  bl       #0x3b56bfc ; 
00686F128  mov      x0, x20
00686F12C  bl       #0x382bfb0 ; 
00686F130  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetNormalSkill
; RVA 0x686E0A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686E0A0  sub      sp, sp, #0x70
00686E0A4  str      x30, [sp, #0x10]
00686E0A8  stp      x28, x27, [sp, #0x20]
00686E0AC  stp      x26, x25, [sp, #0x30]
00686E0B0  stp      x24, x23, [sp, #0x40]
00686E0B4  stp      x22, x21, [sp, #0x50]
00686E0B8  stp      x20, x19, [sp, #0x60]
00686E0BC  adrp     x24, #0x959b000
00686E0C0  adrp     x26, #0x8f24000
00686E0C4  ldrb     w8, [x24, #0xa58]
00686E0C8  ldr      x26, [x26, #0x218]
00686E0CC  mov      x19, x5
00686E0D0  mov      w25, w4
00686E0D4  mov      w21, w3
00686E0D8  mov      w22, w2
00686E0DC  mov      x20, x1
00686E0E0  mov      x23, x0
00686E0E4  tbnz     w8, #0, #0x686e12c
00686E0E8  adrp     x0, #0x8ee8000
00686E0EC  ldr      x0, [x0, #0x898]
00686E0F0  bl       #0x382bd14 ; 
00686E0F4  adrp     x0, #0x8ee6000
00686E0F8  ldr      x0, [x0, #0xd8]
00686E0FC  bl       #0x382bd14 ; 
00686E100  adrp     x0, #0x8f23000
00686E104  ldr      x0, [x0, #0x140]
00686E108  bl       #0x382bd14 ; 
00686E10C  adrp     x0, #0x8f24000
00686E110  ldr      x0, [x0, #0x218]
00686E114  bl       #0x382bd14 ; 
00686E118  adrp     x0, #0x8f24000
00686E11C  ldr      x0, [x0, #0x220]
00686E120  bl       #0x382bd14 ; 
00686E124  mov      w8, #1
00686E128  strb     w8, [x24, #0xa58]
00686E12C  ldr      x6, [x26]
00686E130  ldrb     w8, [x6, #0x53]
00686E134  tbnz     w8, #5, #0x686e174
00686E138  adrp     x26, #0x9591000
00686E13C  ldrb     w8, [x26, #0xa4b]
00686E140  cbnz     w8, #0x686e158
00686E144  adrp     x0, #0x8ee5000
00686E148  ldr      x0, [x0, #0xb28]
00686E14C  bl       #0x382bd14 ; 
00686E150  mov      w8, #1
00686E154  strb     w8, [x26, #0xa4b]
00686E158  adrp     x27, #0x8ee5000
00686E15C  ldr      x27, [x27, #0xb28]
00686E160  ldr      x1, [x27]
00686E164  ldrb     w8, [x1, #0x53]
00686E168  tbnz     w8, #5, #0x686e1b0
00686E16C  ldr      x0, [x23, #0x20]
00686E170  b        #0x686e1bc ; 
00686E174  ldr      x7, [x6, #0x60]
00686E178  and      w2, w22, #1
00686E17C  and      w3, w21, #1
00686E180  mov      x0, x23
00686E184  mov      x1, x20
00686E188  mov      w4, w25
00686E18C  mov      x5, x19
00686E190  ldp      x20, x19, [sp, #0x60]
00686E194  ldp      x22, x21, [sp, #0x50]
00686E198  ldp      x24, x23, [sp, #0x40]
00686E19C  ldp      x26, x25, [sp, #0x30]
00686E1A0  ldp      x28, x27, [sp, #0x20]
00686E1A4  ldr      x30, [sp, #0x10]
00686E1A8  add      sp, sp, #0x70
00686E1AC  br       x7
00686E1B0  ldr      x8, [x1, #0x60]
00686E1B4  mov      x0, x23
00686E1B8  blr      x8
00686E1BC  cbz      x0, #0x686e560
00686E1C0  mov      x1, xzr
00686E1C4  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00686E1C8  tbz      w0, #0, #0x686e200
00686E1CC  ldrb     w8, [x26, #0xa4b]
00686E1D0  ldr      x24, [x23, #0xb0]
00686E1D4  cbnz     w8, #0x686e1ec
00686E1D8  adrp     x0, #0x8ee5000
00686E1DC  ldr      x0, [x0, #0xb28]
00686E1E0  bl       #0x382bd14 ; 
00686E1E4  mov      w8, #1
00686E1E8  strb     w8, [x26, #0xa4b]
00686E1EC  ldr      x1, [x27]
00686E1F0  ldrb     w8, [x1, #0x53]
00686E1F4  tbnz     w8, #5, #0x686e220
00686E1F8  ldr      x26, [x23, #0x20]
00686E1FC  b        #0x686e230 ; 
00686E200  adrp     x25, #0x8ee8000
00686E204  ldr      x25, [x25, #0x898]
00686E208  ldr      x24, [x23, #0xa8]
00686E20C  ldr      x0, [x25]
00686E210  ldr      w8, [x0, #0xe0]
00686E214  cbz      w8, #0x686e368
00686E218  mov      x1, x24
00686E21C  b        #0x686e374 ; 
00686E220  ldr      x8, [x1, #0x60]
00686E224  mov      x0, x23
00686E228  blr      x8
00686E22C  mov      x26, x0
00686E230  cbz      x26, #0x686e560
00686E234  adrp     x27, #0x9598000
00686E238  ldrb     w8, [x27, #0xfcc]
00686E23C  cbnz     w8, #0x686e254
00686E240  adrp     x0, #0x8f06000
00686E244  ldr      x0, [x0, #0x470]
00686E248  bl       #0x382bd14 ; 
00686E24C  mov      w8, #1
00686E250  strb     w8, [x27, #0xfcc]
00686E254  adrp     x8, #0x8f06000
00686E258  ldr      x8, [x8, #0x470]
00686E25C  ldr      x1, [x8]
00686E260  ldrb     w8, [x1, #0x53]
00686E264  tbnz     w8, #5, #0x686e270
00686E268  ldr      x0, [x26, #0x200]
00686E26C  b        #0x686e27c ; 
00686E270  ldr      x8, [x1, #0x60]
00686E274  mov      x0, x26
00686E278  blr      x8
00686E27C  cbz      x0, #0x686e560
00686E280  mov      w1, w25
00686E284  mov      x2, xzr
00686E288  bl       #0x64e564c ; LocalModels.LocalModelManager$$GetExp_exp
00686E28C  adrp     x28, #0x8ee8000
00686E290  ldr      x28, [x28, #0x898]
00686E294  mov      x25, x0
00686E298  ldr      x8, [x28]
00686E29C  ldr      w9, [x8, #0xe0]
00686E2A0  cbnz     w9, #0x686e2ac
00686E2A4  mov      x0, x8
00686E2A8  bl       #0x382be8c ; 
00686E2AC  mov      x0, xzr
00686E2B0  bl       #0x64cb688 ; LocalModels.Const$$GetDankeSkillWeight
00686E2B4  ldr      x26, [x23, #0xb0]
00686E2B8  mov      x27, x0
00686E2BC  mov      x0, xzr
00686E2C0  bl       #0x64cb688 ; LocalModels.Const$$GetDankeSkillWeight
00686E2C4  cbz      x0, #0x686e560
00686E2C8  ldr      w2, [x0, #0x18]
00686E2CC  mov      x0, x27
00686E2D0  mov      x1, x26
00686E2D4  mov      x3, xzr
00686E2D8  bl       #0x7c01418 ; System.Array$$Copy
00686E2DC  cbz      x25, #0x686e560
00686E2E0  adrp     x26, #0x959b000
00686E2E4  ldrb     w8, [x26, #0xbb2]
00686E2E8  cbnz     w8, #0x686e300
00686E2EC  adrp     x0, #0x8f24000
00686E2F0  ldr      x0, [x0, #0x228]
00686E2F4  bl       #0x382bd14 ; 
00686E2F8  mov      w8, #1
00686E2FC  strb     w8, [x26, #0xbb2]
00686E300  adrp     x8, #0x8f24000
00686E304  ldr      x8, [x8, #0x228]
00686E308  ldr      x1, [x8]
00686E30C  ldrb     w8, [x1, #0x53]
00686E310  tbnz     w8, #5, #0x686e31c
00686E314  ldr      x25, [x25, #0x28]
00686E318  b        #0x686e32c ; 
00686E31C  ldr      x8, [x1, #0x60]
00686E320  mov      x0, x25
00686E324  blr      x8
00686E328  mov      x25, x0
00686E32C  ldr      x0, [x23, #0x88]
00686E330  cbz      x0, #0x686e560
00686E334  ldr      x8, [x0]
00686E338  ldr      x9, [x8, #0x248]
00686E33C  ldr      x1, [x8, #0x250]
00686E340  blr      x9
00686E344  tbz      w0, #0, #0x686e38c
00686E348  ldr      x0, [x28]
00686E34C  ldr      w8, [x0, #0xe0]
00686E350  cbnz     w8, #0x686e35c
00686E354  bl       #0x382be8c ; 
00686E358  ldr      x0, [x28]
00686E35C  ldr      x8, [x0, #0xb8]
00686E360  ldr      x25, [x8, #0x3b8]
00686E364  b        #0x686e38c ; 
00686E368  bl       #0x382be8c ; 
00686E36C  ldr      x0, [x25]
00686E370  ldr      x1, [x23, #0xa8]
00686E374  ldr      x8, [x0, #0xb8]
00686E378  mov      x3, xzr
00686E37C  ldr      x0, [x8, #0x1c0]
00686E380  ldr      w2, [x8, #0x2f0]
00686E384  bl       #0x7c01418 ; System.Array$$Copy
00686E388  mov      x25, xzr
00686E38C  adrp     x8, #0x8f23000
00686E390  ldr      x8, [x8, #0x140]
00686E394  ldr      x1, [x8]
00686E398  ldrb     w8, [x1, #0x53]
00686E39C  tbnz     w8, #5, #0x686e3a8
00686E3A0  ldr      x0, [x23, #0x30]
00686E3A4  b        #0x686e3b4 ; 
00686E3A8  ldr      x8, [x1, #0x60]
00686E3AC  mov      x0, x23
00686E3B0  blr      x8
00686E3B4  cbz      x0, #0x686e560
00686E3B8  adrp     x8, #0x8ee6000
00686E3BC  ldr      x8, [x8, #0xd8]
00686E3C0  ldr      x1, [x8]
00686E3C4  ldrb     w8, [x1, #0x53]
00686E3C8  tbnz     w8, #5, #0x686e3d4
00686E3CC  ldr      x26, [x0, #0x38]
00686E3D0  b        #0x686e3e0 ; 
00686E3D4  ldr      x8, [x1, #0x60]
00686E3D8  blr      x8
00686E3DC  mov      x26, x0
00686E3E0  cbz      x26, #0x686e560
00686E3E4  adrp     x27, #0x9591000
00686E3E8  ldrb     w8, [x27, #0xa7f]
00686E3EC  cbnz     w8, #0x686e404
00686E3F0  adrp     x0, #0x8ee6000
00686E3F4  ldr      x0, [x0, #0x2d8]
00686E3F8  bl       #0x382bd14 ; 
00686E3FC  mov      w8, #1
00686E400  strb     w8, [x27, #0xa7f]
00686E404  adrp     x8, #0x8ee6000
00686E408  ldr      x8, [x8, #0x2d8]
00686E40C  ldr      x1, [x8]
00686E410  ldrb     w8, [x1, #0x53]
00686E414  tbnz     w8, #5, #0x686e420
00686E418  ldr      x0, [x26, #0x178]
00686E41C  b        #0x686e42c ; 
00686E420  ldr      x8, [x1, #0x60]
00686E424  mov      x0, x26
00686E428  blr      x8
00686E42C  cbz      x0, #0x686e560
00686E430  adrp     x8, #0x8f24000
00686E434  ldr      x8, [x8, #0x220]
00686E438  mov      x2, xzr
00686E43C  ldr      x1, [x8]
00686E440  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686E444  cmp      x0, #1
00686E448  b.lt     #0x686e4b8
00686E44C  ldr      x27, [x23, #0xa8]
00686E450  cbz      x27, #0x686e560
00686E454  ldr      w8, [x27, #0x18]
00686E458  cmp      w8, #1
00686E45C  b.ls     #0x686e564
00686E460  ldrsw    x8, [x27, #0x24]
00686E464  add      x26, x0, #0x10, lsl #12
00686E468  mov      x1, xzr
00686E46C  mul      x0, x26, x8
00686E470  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686E474  ldr      w8, [x27, #0x18]
00686E478  cmp      w8, #1
00686E47C  b.ls     #0x686e564
00686E480  str      w0, [x27, #0x24]
00686E484  ldr      x27, [x23, #0xa8]
00686E488  cbz      x27, #0x686e560
00686E48C  ldr      w8, [x27, #0x18]
00686E490  cmp      w8, #2
00686E494  b.ls     #0x686e564
00686E498  ldrsw    x8, [x27, #0x28]
00686E49C  mov      x1, xzr
00686E4A0  mul      x0, x26, x8
00686E4A4  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686E4A8  ldr      w8, [x27, #0x18]
00686E4AC  cmp      w8, #2
00686E4B0  b.ls     #0x686e564
00686E4B4  str      w0, [x27, #0x28]
00686E4B8  adrp     x27, #0x9599000
00686E4BC  ldrb     w8, [x27, #0x4c7]
00686E4C0  ldr      x26, [x23, #0x88]
00686E4C4  cbnz     w8, #0x686e4dc
00686E4C8  adrp     x0, #0x8f09000
00686E4CC  ldr      x0, [x0, #0xc8]
00686E4D0  bl       #0x382bd14 ; 
00686E4D4  mov      w8, #1
00686E4D8  strb     w8, [x27, #0x4c7]
00686E4DC  adrp     x8, #0x8f09000
00686E4E0  ldr      x8, [x8, #0xc8]
00686E4E4  ldr      x1, [x8]
00686E4E8  ldrb     w8, [x1, #0x53]
00686E4EC  tbnz     w8, #5, #0x686e4f8
00686E4F0  ldr      x5, [x23, #0x58]
00686E4F4  b        #0x686e508 ; 
00686E4F8  ldr      x8, [x1, #0x60]
00686E4FC  mov      x0, x23
00686E500  blr      x8
00686E504  mov      x5, x0
00686E508  cbz      x26, #0x686e560
00686E50C  ldr      x8, [x26]
00686E510  and      w2, w21, #1
00686E514  and      w4, w22, #1
00686E518  mov      x0, x26
00686E51C  ldr      x9, [x8, #0x238]
00686E520  ldr      x8, [x8, #0x240]
00686E524  mov      x1, x20
00686E528  mov      x3, x24
00686E52C  mov      x6, x19
00686E530  mov      x7, x25
00686E534  str      x8, [sp]
00686E538  blr      x9
00686E53C  ldp      x20, x19, [sp, #0x60]
00686E540  ldp      x22, x21, [sp, #0x50]
00686E544  ldp      x24, x23, [sp, #0x40]
00686E548  ldp      x26, x25, [sp, #0x30]
00686E54C  ldp      x28, x27, [sp, #0x20]
00686E550  ldr      x30, [sp, #0x10]
00686E554  and      w0, w0, #1
00686E558  add      sp, sp, #0x70
00686E55C  ret      
00686E560  bl       #0x382bfb8 ; 
00686E564  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetBoxRandomSkills
; RVA 0x686F134; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F134  stp      x30, x21, [sp, #-0x20]!
00686F138  stp      x20, x19, [sp, #0x10]
00686F13C  adrp     x20, #0x959b000
00686F140  adrp     x21, #0x8f24000
00686F144  ldrb     w8, [x20, #0xa59]
00686F148  ldr      x21, [x21, #0x290]
00686F14C  mov      x19, x0
00686F150  tbnz     w8, #0, #0x686f1a4
00686F154  adrp     x0, #0x8ee8000
00686F158  ldr      x0, [x0, #0x898]
00686F15C  bl       #0x382bd14 ; 
00686F160  adrp     x0, #0x8ee6000
00686F164  ldr      x0, [x0, #0xd8]
00686F168  bl       #0x382bd14 ; 
00686F16C  adrp     x0, #0x8f23000
00686F170  ldr      x0, [x0, #0x140]
00686F174  bl       #0x382bd14 ; 
00686F178  adrp     x0, #0x8ee3000
00686F17C  ldr      x0, [x0, #0xf48]
00686F180  bl       #0x382bd14 ; 
00686F184  adrp     x0, #0x8f24000
00686F188  ldr      x0, [x0, #0x290]
00686F18C  bl       #0x382bd14 ; 
00686F190  adrp     x0, #0x8f24000
00686F194  ldr      x0, [x0, #0x298]
00686F198  bl       #0x382bd14 ; 
00686F19C  mov      w8, #1
00686F1A0  strb     w8, [x20, #0xa59]
00686F1A4  ldr      x1, [x21]
00686F1A8  ldrb     w8, [x1, #0x53]
00686F1AC  tbnz     w8, #5, #0x686f200
00686F1B0  adrp     x21, #0x8ee8000
00686F1B4  ldr      x21, [x21, #0x898]
00686F1B8  adrp     x20, #0x8f23000
00686F1BC  ldr      x0, [x21]
00686F1C0  ldr      w8, [x0, #0xe0]
00686F1C4  ldr      x20, [x20, #0x140]
00686F1C8  cbnz     w8, #0x686f1d4
00686F1CC  bl       #0x382be8c ; 
00686F1D0  ldr      x0, [x21]
00686F1D4  ldr      x8, [x0, #0xb8]
00686F1D8  ldr      x1, [x19, #0xa8]
00686F1DC  mov      w2, #3
00686F1E0  mov      x3, xzr
00686F1E4  ldr      x0, [x8, #0x1f8]
00686F1E8  bl       #0x7c01418 ; System.Array$$Copy
00686F1EC  ldr      x1, [x20]
00686F1F0  ldrb     w8, [x1, #0x53]
00686F1F4  tbnz     w8, #5, #0x686f214
00686F1F8  ldr      x0, [x19, #0x30]
00686F1FC  b        #0x686f220 ; 
00686F200  ldr      x2, [x1, #0x60]
00686F204  mov      x0, x19
00686F208  ldp      x20, x19, [sp, #0x10]
00686F20C  ldp      x30, x21, [sp], #0x20
00686F210  br       x2
00686F214  ldr      x8, [x1, #0x60]
00686F218  mov      x0, x19
00686F21C  blr      x8
00686F220  cbz      x0, #0x686f38c
00686F224  adrp     x8, #0x8ee6000
00686F228  ldr      x8, [x8, #0xd8]
00686F22C  ldr      x1, [x8]
00686F230  ldrb     w8, [x1, #0x53]
00686F234  tbnz     w8, #5, #0x686f240
00686F238  ldr      x20, [x0, #0x38]
00686F23C  b        #0x686f24c ; 
00686F240  ldr      x8, [x1, #0x60]
00686F244  blr      x8
00686F248  mov      x20, x0
00686F24C  cbz      x20, #0x686f38c
00686F250  adrp     x21, #0x9591000
00686F254  ldrb     w8, [x21, #0xa7f]
00686F258  cbnz     w8, #0x686f270
00686F25C  adrp     x0, #0x8ee6000
00686F260  ldr      x0, [x0, #0x2d8]
00686F264  bl       #0x382bd14 ; 
00686F268  mov      w8, #1
00686F26C  strb     w8, [x21, #0xa7f]
00686F270  adrp     x8, #0x8ee6000
00686F274  ldr      x8, [x8, #0x2d8]
00686F278  ldr      x1, [x8]
00686F27C  ldrb     w8, [x1, #0x53]
00686F280  tbnz     w8, #5, #0x686f28c
00686F284  ldr      x0, [x20, #0x178]
00686F288  b        #0x686f298 ; 
00686F28C  ldr      x8, [x1, #0x60]
00686F290  mov      x0, x20
00686F294  blr      x8
00686F298  cbz      x0, #0x686f38c
00686F29C  adrp     x8, #0x8f24000
00686F2A0  ldr      x8, [x8, #0x298]
00686F2A4  mov      x2, xzr
00686F2A8  ldr      x1, [x8]
00686F2AC  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686F2B0  cmp      x0, #1
00686F2B4  b.lt     #0x686f324
00686F2B8  ldr      x21, [x19, #0xa8]
00686F2BC  cbz      x21, #0x686f38c
00686F2C0  ldr      w8, [x21, #0x18]
00686F2C4  cmp      w8, #1
00686F2C8  b.ls     #0x686f390
00686F2CC  ldrsw    x8, [x21, #0x24]
00686F2D0  add      x20, x0, #0x10, lsl #12
00686F2D4  mov      x1, xzr
00686F2D8  mul      x0, x20, x8
00686F2DC  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686F2E0  ldr      w8, [x21, #0x18]
00686F2E4  cmp      w8, #1
00686F2E8  b.ls     #0x686f390
00686F2EC  str      w0, [x21, #0x24]
00686F2F0  ldr      x21, [x19, #0xa8]
00686F2F4  cbz      x21, #0x686f38c
00686F2F8  ldr      w8, [x21, #0x18]
00686F2FC  cmp      w8, #2
00686F300  b.ls     #0x686f390
00686F304  ldrsw    x8, [x21, #0x28]
00686F308  mov      x1, xzr
00686F30C  mul      x0, x20, x8
00686F310  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686F314  ldr      w8, [x21, #0x18]
00686F318  cmp      w8, #2
00686F31C  b.ls     #0x686f390
00686F320  str      w0, [x21, #0x28]
00686F324  mov      x0, x19
00686F328  bl       #0x686de10 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckQualityUp
00686F32C  add      x20, x19, #0x60
00686F330  mov      w21, w0
00686F334  mov      x0, x20
00686F338  bl       #0x68666e4 ; HotFix.BattleLogic.BoxSkillResult$$Clear
00686F33C  ldr      x0, [x19, #0x88]
00686F340  cbz      x0, #0x686f38c
00686F344  ldr      x8, [x0]
00686F348  ldr      x2, [x19, #0xa8]
00686F34C  and      w3, w21, #1
00686F350  mov      x1, x20
00686F354  ldr      x9, [x8, #0x268]
00686F358  ldr      x4, [x8, #0x270]
00686F35C  blr      x9
00686F360  adrp     x8, #0x8ee3000
00686F364  ldr      x0, [x19, #0x50]
00686F368  ldr      x8, [x8, #0xf48]
00686F36C  ldr      x1, [x8]
00686F370  bl       #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
00686F374  str      x0, [x19, #0x70]!
00686F378  mov      x1, x0
00686F37C  mov      x0, x19
00686F380  ldp      x20, x19, [sp, #0x10]
00686F384  ldp      x30, x21, [sp], #0x20
00686F388  b        #0x382bcb8 ; 
00686F38C  bl       #0x382bfb8 ; 
00686F390  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetRandomAngleSkills
; RVA 0x686F394; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F394  stp      x30, x23, [sp, #-0x30]!
00686F398  stp      x22, x21, [sp, #0x10]
00686F39C  stp      x20, x19, [sp, #0x20]
00686F3A0  adrp     x22, #0x959b000
00686F3A4  adrp     x23, #0x8f24000
00686F3A8  ldrb     w8, [x22, #0xa5a]
00686F3AC  ldr      x23, [x23, #0x2a0]
00686F3B0  mov      w19, w2
00686F3B4  mov      x20, x1
00686F3B8  mov      x21, x0
00686F3BC  tbnz     w8, #0, #0x686f3d4
00686F3C0  adrp     x0, #0x8f24000
00686F3C4  ldr      x0, [x0, #0x2a0]
00686F3C8  bl       #0x382bd14 ; 
00686F3CC  mov      w8, #1
00686F3D0  strb     w8, [x22, #0xa5a]
00686F3D4  ldr      x3, [x23]
00686F3D8  ldrb     w8, [x3, #0x53]
00686F3DC  tbnz     w8, #5, #0x686f420
00686F3E0  adrp     x23, #0x9599000
00686F3E4  ldrb     w8, [x23, #0x4c7]
00686F3E8  ldr      x22, [x21, #0x88]
00686F3EC  cbnz     w8, #0x686f404
00686F3F0  adrp     x0, #0x8f09000
00686F3F4  ldr      x0, [x0, #0xc8]
00686F3F8  bl       #0x382bd14 ; 
00686F3FC  mov      w8, #1
00686F400  strb     w8, [x23, #0x4c7]
00686F404  adrp     x8, #0x8f09000
00686F408  ldr      x8, [x8, #0xc8]
00686F40C  ldr      x1, [x8]
00686F410  ldrb     w8, [x1, #0x53]
00686F414  tbnz     w8, #5, #0x686f440
00686F418  ldr      x2, [x21, #0x58]
00686F41C  b        #0x686f450 ; 
00686F420  ldr      x4, [x3, #0x60]
00686F424  mov      x0, x21
00686F428  mov      x1, x20
00686F42C  mov      w2, w19
00686F430  ldp      x20, x19, [sp, #0x20]
00686F434  ldp      x22, x21, [sp, #0x10]
00686F438  ldp      x30, x23, [sp], #0x30
00686F43C  br       x4
00686F440  ldr      x8, [x1, #0x60]
00686F444  mov      x0, x21
00686F448  blr      x8
00686F44C  mov      x2, x0
00686F450  cbz      x22, #0x686f47c
00686F454  ldr      x8, [x22]
00686F458  mov      x0, x22
00686F45C  mov      x1, x20
00686F460  mov      w3, w19
00686F464  ldr      x5, [x8, #0x278]
00686F468  ldr      x4, [x8, #0x280]
00686F46C  ldp      x20, x19, [sp, #0x20]
00686F470  ldp      x22, x21, [sp, #0x10]
00686F474  ldp      x30, x23, [sp], #0x30
00686F478  br       x5
00686F47C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RandomAngelSkill
; RVA 0x686F480; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F480  stp      x30, x21, [sp, #-0x20]!
00686F484  stp      x20, x19, [sp, #0x10]
00686F488  adrp     x20, #0x959b000
00686F48C  adrp     x21, #0x8f24000
00686F490  ldrb     w8, [x20, #0xa5b]
00686F494  ldr      x21, [x21, #0x2a8]
00686F498  mov      x19, x0
00686F49C  tbnz     w8, #0, #0x686f4b4
00686F4A0  adrp     x0, #0x8f24000
00686F4A4  ldr      x0, [x0, #0x2a8]
00686F4A8  bl       #0x382bd14 ; 
00686F4AC  mov      w8, #1
00686F4B0  strb     w8, [x20, #0xa5b]
00686F4B4  ldr      x1, [x21]
00686F4B8  ldrb     w8, [x1, #0x53]
00686F4BC  tbnz     w8, #5, #0x686f4d8
00686F4C0  ldr      x0, [x19, #0x88]
00686F4C4  cbz      x0, #0x686f4ec
00686F4C8  ldr      x8, [x0]
00686F4CC  ldr      x2, [x8, #0x288]
00686F4D0  ldr      x1, [x8, #0x290]
00686F4D4  b        #0x686f4e0 ; 
00686F4D8  ldr      x2, [x1, #0x60]
00686F4DC  mov      x0, x19
00686F4E0  ldp      x20, x19, [sp, #0x10]
00686F4E4  ldp      x30, x21, [sp], #0x20
00686F4E8  br       x2
00686F4EC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$RandomDevilSkill
; RVA 0x686F4F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F4F0  sub      sp, sp, #0x40
00686F4F4  stp      x30, x23, [sp, #0x10]
00686F4F8  stp      x22, x21, [sp, #0x20]
00686F4FC  stp      x20, x19, [sp, #0x30]
00686F500  adrp     x20, #0x959b000
00686F504  adrp     x21, #0x8f24000
00686F508  ldrb     w8, [x20, #0xa5c]
00686F50C  ldr      x21, [x21, #0x2b0]
00686F510  mov      x19, x0
00686F514  tbnz     w8, #0, #0x686f55c
00686F518  adrp     x0, #0x8ee8000
00686F51C  ldr      x0, [x0, #0x898]
00686F520  bl       #0x382bd14 ; 
00686F524  adrp     x0, #0x8ee6000
00686F528  ldr      x0, [x0, #0xd8]
00686F52C  bl       #0x382bd14 ; 
00686F530  adrp     x0, #0x8f23000
00686F534  ldr      x0, [x0, #0x140]
00686F538  bl       #0x382bd14 ; 
00686F53C  adrp     x0, #0x8f24000
00686F540  ldr      x0, [x0, #0x2b0]
00686F544  bl       #0x382bd14 ; 
00686F548  adrp     x0, #0x8f24000
00686F54C  ldr      x0, [x0, #0x2b8]
00686F550  bl       #0x382bd14 ; 
00686F554  mov      w8, #1
00686F558  strb     w8, [x20, #0xa5c]
00686F55C  ldr      x1, [x21]
00686F560  ldrb     w8, [x1, #0x53]
00686F564  tbnz     w8, #5, #0x686f5f8
00686F568  str      wzr, [sp, #0xc]
00686F56C  ldr      x20, [x19, #0x88]
00686F570  mov      x0, x19
00686F574  bl       #0x686de10 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckQualityUp
00686F578  cbz      x20, #0x686f748
00686F57C  ldr      x8, [x20]
00686F580  and      w2, w0, #1
00686F584  add      x1, sp, #0xc
00686F588  mov      x0, x20
00686F58C  ldp      x9, x3, [x8, #0x198]
00686F590  blr      x9
00686F594  adrp     x21, #0x8ee8000
00686F598  ldr      x21, [x21, #0x898]
00686F59C  mov      w20, w0
00686F5A0  ldr      x8, [x21]
00686F5A4  ldr      w9, [x8, #0xe0]
00686F5A8  cbnz     w9, #0x686f5b8
00686F5AC  mov      x0, x8
00686F5B0  bl       #0x382be8c ; 
00686F5B4  ldr      x8, [x21]
00686F5B8  ldr      x8, [x8, #0xb8]
00686F5BC  ldr      x8, [x8, #0x190]
00686F5C0  cbz      x8, #0x686f748
00686F5C4  ldrsw    x9, [sp, #0xc]
00686F5C8  ldr      w10, [x8, #0x18]
00686F5CC  cmp      w9, w10
00686F5D0  b.hs     #0x686f74c
00686F5D4  adrp     x10, #0x8f23000
00686F5D8  ldr      x10, [x10, #0x140]
00686F5DC  add      x8, x8, x9, lsl #2
00686F5E0  ldr      w21, [x8, #0x20]
00686F5E4  ldr      x1, [x10]
00686F5E8  ldrb     w9, [x1, #0x53]
00686F5EC  tbnz     w9, #5, #0x686f614
00686F5F0  ldr      x0, [x19, #0x30]
00686F5F4  b        #0x686f620 ; 
00686F5F8  ldr      x2, [x1, #0x60]
00686F5FC  mov      x0, x19
00686F600  ldp      x20, x19, [sp, #0x30]
00686F604  ldp      x22, x21, [sp, #0x20]
00686F608  ldp      x30, x23, [sp, #0x10]
00686F60C  add      sp, sp, #0x40
00686F610  br       x2
00686F614  ldr      x8, [x1, #0x60]
00686F618  mov      x0, x19
00686F61C  blr      x8
00686F620  cbz      x0, #0x686f748
00686F624  adrp     x8, #0x8ee6000
00686F628  ldr      x8, [x8, #0xd8]
00686F62C  ldr      x1, [x8]
00686F630  ldrb     w8, [x1, #0x53]
00686F634  tbnz     w8, #5, #0x686f640
00686F638  ldr      x22, [x0, #0x38]
00686F63C  b        #0x686f64c ; 
00686F640  ldr      x8, [x1, #0x60]
00686F644  blr      x8
00686F648  mov      x22, x0
00686F64C  cbz      x22, #0x686f748
00686F650  adrp     x23, #0x9591000
00686F654  ldrb     w8, [x23, #0xa7f]
00686F658  cbnz     w8, #0x686f670
00686F65C  adrp     x0, #0x8ee6000
00686F660  ldr      x0, [x0, #0x2d8]
00686F664  bl       #0x382bd14 ; 
00686F668  mov      w8, #1
00686F66C  strb     w8, [x23, #0xa7f]
00686F670  adrp     x8, #0x8ee6000
00686F674  ldr      x8, [x8, #0x2d8]
00686F678  ldr      x1, [x8]
00686F67C  ldrb     w8, [x1, #0x53]
00686F680  tbnz     w8, #5, #0x686f68c
00686F684  ldr      x0, [x22, #0x178]
00686F688  b        #0x686f698 ; 
00686F68C  ldr      x8, [x1, #0x60]
00686F690  mov      x0, x22
00686F694  blr      x8
00686F698  cbz      x0, #0x686f748
00686F69C  adrp     x8, #0x8f24000
00686F6A0  ldr      x8, [x8, #0x2b8]
00686F6A4  mov      x2, xzr
00686F6A8  ldr      x1, [x8]
00686F6AC  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686F6B0  cmp      x0, #1
00686F6B4  b.lt     #0x686f6d4
00686F6B8  mov      w9, #0x10000
00686F6BC  sxtw     x8, w21
00686F6C0  sub      x9, x9, x0
00686F6C4  mul      x0, x9, x8
00686F6C8  mov      x1, xzr
00686F6CC  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686F6D0  mov      w21, w0
00686F6D4  adrp     x22, #0x9591000
00686F6D8  ldrb     w8, [x22, #0xa4b]
00686F6DC  cbnz     w8, #0x686f6f4
00686F6E0  adrp     x0, #0x8ee5000
00686F6E4  ldr      x0, [x0, #0xb28]
00686F6E8  bl       #0x382bd14 ; 
00686F6EC  mov      w8, #1
00686F6F0  strb     w8, [x22, #0xa4b]
00686F6F4  adrp     x8, #0x8ee5000
00686F6F8  ldr      x8, [x8, #0xb28]
00686F6FC  ldr      x1, [x8]
00686F700  ldrb     w8, [x1, #0x53]
00686F704  tbnz     w8, #5, #0x686f710
00686F708  ldr      x0, [x19, #0x20]
00686F70C  b        #0x686f71c ; 
00686F710  ldr      x8, [x1, #0x60]
00686F714  mov      x0, x19
00686F718  blr      x8
00686F71C  cbz      x0, #0x686f748
00686F720  mov      w1, #1
00686F724  mov      w2, w21
00686F728  mov      x3, xzr
00686F72C  bl       #0x69facec ; HotFix.BattleLogic.BattleWorldContext$$SetCachedHp
00686F730  mov      w0, w20
00686F734  ldp      x20, x19, [sp, #0x30]
00686F738  ldp      x22, x21, [sp, #0x20]
00686F73C  ldp      x30, x23, [sp, #0x10]
00686F740  add      sp, sp, #0x40
00686F744  ret      
00686F748  bl       #0x382bfb8 ; 
00686F74C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetAllBattleSkill
; RVA 0x686F750; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F750  stp      x30, x21, [sp, #-0x20]!
00686F754  stp      x20, x19, [sp, #0x10]
00686F758  adrp     x20, #0x959b000
00686F75C  adrp     x21, #0x8f08000
00686F760  ldrb     w8, [x20, #0xa5d]
00686F764  ldr      x21, [x21, #0xbd8]
00686F768  mov      x19, x0
00686F76C  tbnz     w8, #0, #0x686f784
00686F770  adrp     x0, #0x8f08000
00686F774  ldr      x0, [x0, #0xbd8]
00686F778  bl       #0x382bd14 ; 
00686F77C  mov      w8, #1
00686F780  strb     w8, [x20, #0xa5d]
00686F784  ldr      x1, [x21]
00686F788  ldrb     w8, [x1, #0x53]
00686F78C  tbnz     w8, #5, #0x686f7a0
00686F790  ldr      x0, [x19, #0x50]
00686F794  ldp      x20, x19, [sp, #0x10]
00686F798  ldp      x30, x21, [sp], #0x20
00686F79C  ret      
00686F7A0  ldr      x2, [x1, #0x60]
00686F7A4  mov      x0, x19
00686F7A8  ldp      x20, x19, [sp, #0x10]
00686F7AC  ldp      x30, x21, [sp], #0x20
00686F7B0  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$ShowDefaultRandomSkills
; RVA 0x686F7B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F7B4  stp      x30, x21, [sp, #-0x20]!
00686F7B8  stp      x20, x19, [sp, #0x10]
00686F7BC  adrp     x20, #0x959b000
00686F7C0  adrp     x21, #0x8f24000
00686F7C4  ldrb     w8, [x20, #0xa5e]
00686F7C8  ldr      x21, [x21, #0x2c0]
00686F7CC  mov      x19, x0
00686F7D0  tbnz     w8, #0, #0x686f7e8
00686F7D4  adrp     x0, #0x8f24000
00686F7D8  ldr      x0, [x0, #0x2c0]
00686F7DC  bl       #0x382bd14 ; 
00686F7E0  mov      w8, #1
00686F7E4  strb     w8, [x20, #0xa5e]
00686F7E8  ldr      x1, [x21]
00686F7EC  ldrb     w8, [x1, #0x53]
00686F7F0  tbnz     w8, #5, #0x686f808
00686F7F4  ldr      x0, [x19, #0x88]
00686F7F8  cbz      x0, #0x686f81c
00686F7FC  ldp      x20, x19, [sp, #0x10]
00686F800  ldp      x30, x21, [sp], #0x20
00686F804  b        #0x686f820 ; HotFix.BattleLogic.HeroSkillCreator$$ShowDefaultRandomSkills
00686F808  ldr      x2, [x1, #0x60]
00686F80C  mov      x0, x19
00686F810  ldp      x20, x19, [sp, #0x10]
00686F814  ldp      x30, x21, [sp], #0x20
00686F818  br       x2
00686F81C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetPunchboardRandomCount
; RVA 0x686F88C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F88C  sub      sp, sp, #0x80
00686F890  stp      x29, x30, [sp, #0x20]
00686F894  stp      x28, x27, [sp, #0x30]
00686F898  stp      x26, x25, [sp, #0x40]
00686F89C  stp      x24, x23, [sp, #0x50]
00686F8A0  stp      x22, x21, [sp, #0x60]
00686F8A4  stp      x20, x19, [sp, #0x70]
00686F8A8  adrp     x20, #0x959b000
00686F8AC  adrp     x21, #0x8f24000
00686F8B0  ldrb     w8, [x20, #0xa5f]
00686F8B4  ldr      x21, [x21, #0x2d0]
00686F8B8  mov      x19, x0
00686F8BC  tbnz     w8, #0, #0x686f958
00686F8C0  adrp     x0, #0x8ee8000
00686F8C4  ldr      x0, [x0, #0x898]
00686F8C8  bl       #0x382bd14 ; 
00686F8CC  adrp     x0, #0x8ee6000
00686F8D0  ldr      x0, [x0, #0xd8]
00686F8D4  bl       #0x382bd14 ; 
00686F8D8  adrp     x0, #0x8f23000
00686F8DC  ldr      x0, [x0, #0x140]
00686F8E0  bl       #0x382bd14 ; 
00686F8E4  adrp     x0, #0x8ede000
00686F8E8  ldr      x0, [x0, #0xd0]
00686F8EC  bl       #0x382bd14 ; 
00686F8F0  adrp     x0, #0x8ee3000
00686F8F4  ldr      x0, [x0, #0xf18]
00686F8F8  bl       #0x382bd14 ; 
00686F8FC  adrp     x0, #0x8ede000
00686F900  ldr      x0, [x0, #0x108]
00686F904  bl       #0x382bd14 ; 
00686F908  adrp     x0, #0x8ede000
00686F90C  ldr      x0, [x0, #0x100]
00686F910  bl       #0x382bd14 ; 
00686F914  adrp     x0, #0x8f24000
00686F918  ldr      x0, [x0, #0x2d0]
00686F91C  bl       #0x382bd14 ; 
00686F920  adrp     x0, #0x8ec1000
00686F924  ldr      x0, [x0, #0x240]
00686F928  bl       #0x382bd14 ; 
00686F92C  adrp     x0, #0x8ec2000
00686F930  ldr      x0, [x0, #0x268]
00686F934  bl       #0x382bd14 ; 
00686F938  adrp     x0, #0x8ec2000
00686F93C  ldr      x0, [x0, #0x270]
00686F940  bl       #0x382bd14 ; 
00686F944  adrp     x0, #0x8f24000
00686F948  ldr      x0, [x0, #0x2d8]
00686F94C  bl       #0x382bd14 ; 
00686F950  mov      w8, #1
00686F954  strb     w8, [x20, #0xa5f]
00686F958  ldr      x1, [x21]
00686F95C  ldrb     w8, [x1, #0x53]
00686F960  tbnz     w8, #5, #0x686f980
00686F964  adrp     x8, #0x8f23000
00686F968  ldr      x8, [x8, #0x140]
00686F96C  ldr      x1, [x8]
00686F970  ldrb     w8, [x1, #0x53]
00686F974  tbnz     w8, #5, #0x686f9a8
00686F978  ldr      x0, [x19, #0x30]
00686F97C  b        #0x686f9b4 ; 
00686F980  ldr      x2, [x1, #0x60]
00686F984  mov      x0, x19
00686F988  ldp      x20, x19, [sp, #0x70]
00686F98C  ldp      x22, x21, [sp, #0x60]
00686F990  ldp      x24, x23, [sp, #0x50]
00686F994  ldp      x26, x25, [sp, #0x40]
00686F998  ldp      x28, x27, [sp, #0x30]
00686F99C  ldp      x29, x30, [sp, #0x20]
00686F9A0  add      sp, sp, #0x80
00686F9A4  br       x2
00686F9A8  ldr      x8, [x1, #0x60]
00686F9AC  mov      x0, x19
00686F9B0  blr      x8
00686F9B4  cbz      x0, #0x686ffa0
00686F9B8  adrp     x8, #0x8ee6000
00686F9BC  ldr      x8, [x8, #0xd8]
00686F9C0  ldr      x1, [x8]
00686F9C4  ldrb     w8, [x1, #0x53]
00686F9C8  tbnz     w8, #5, #0x686f9d4
00686F9CC  ldr      x20, [x0, #0x38]
00686F9D0  b        #0x686f9e0 ; 
00686F9D4  ldr      x8, [x1, #0x60]
00686F9D8  blr      x8
00686F9DC  mov      x20, x0
00686F9E0  cbz      x20, #0x686ffa0
00686F9E4  adrp     x21, #0x9591000
00686F9E8  ldrb     w8, [x21, #0xa7f]
00686F9EC  cbnz     w8, #0x686fa04
00686F9F0  adrp     x0, #0x8ee6000
00686F9F4  ldr      x0, [x0, #0x2d8]
00686F9F8  bl       #0x382bd14 ; 
00686F9FC  mov      w8, #1
00686FA00  strb     w8, [x21, #0xa7f]
00686FA04  adrp     x8, #0x8ee6000
00686FA08  ldr      x8, [x8, #0x2d8]
00686FA0C  ldr      x1, [x8]
00686FA10  ldrb     w8, [x1, #0x53]
00686FA14  tbnz     w8, #5, #0x686fa20
00686FA18  ldr      x0, [x20, #0x178]
00686FA1C  b        #0x686fa2c ; 
00686FA20  ldr      x8, [x1, #0x60]
00686FA24  mov      x0, x20
00686FA28  blr      x8
00686FA2C  cbz      x0, #0x686ffa0
00686FA30  adrp     x8, #0x8f24000
00686FA34  ldr      x8, [x8, #0x2d8]
00686FA38  mov      x2, xzr
00686FA3C  ldr      x1, [x8]
00686FA40  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686FA44  adrp     x28, #0x8ee8000
00686FA48  ldr      x28, [x28, #0x898]
00686FA4C  mov      x22, x0
00686FA50  ldr      x8, [x28]
00686FA54  ldr      w9, [x8, #0xe0]
00686FA58  cbnz     w9, #0x686fa64
00686FA5C  mov      x0, x8
00686FA60  bl       #0x382be8c ; 
00686FA64  mov      x0, xzr
00686FA68  bl       #0x64cb808 ; LocalModels.Const$$GetPunchboardRandomSkillCountWeight
00686FA6C  cbz      x0, #0x686ffa0
00686FA70  adrp     x8, #0x8ec1000
00686FA74  ldr      x26, [x0, #0x18]
00686FA78  ldr      x8, [x8, #0x240]
00686FA7C  mov      w1, w26
00686FA80  ldr      x0, [x8]
00686FA84  bl       #0x382bdfc ; 
00686FA88  cmp      x22, #1
00686FA8C  mov      x27, x0
00686FA90  b.lt     #0x686fb38
00686FA94  cmp      w26, #1
00686FA98  b.lt     #0x686fb60
00686FA9C  sub      w21, w26, #1
00686FAA0  add      x24, x27, #0x20
00686FAA4  mov      x20, xzr
00686FAA8  add      x22, x22, #0x10, lsl #12
00686FAAC  and      x23, x26, #0xffffffff
00686FAB0  add      x25, x24, w21, uxtw #2
00686FAB4  ldr      x0, [x28]
00686FAB8  ldr      w8, [x0, #0xe0]
00686FABC  cbnz     w8, #0x686fac4
00686FAC0  bl       #0x382be8c ; 
00686FAC4  mov      x0, xzr
00686FAC8  bl       #0x64cb808 ; LocalModels.Const$$GetPunchboardRandomSkillCountWeight
00686FACC  cbz      x0, #0x686ffa0
00686FAD0  ldr      w8, [x0, #0x18]
00686FAD4  cmp      x20, x8
00686FAD8  b.hs     #0x686ffa4
00686FADC  add      x8, x0, x20, lsl #2
00686FAE0  ldr      w8, [x8, #0x20]
00686FAE4  cmp      x21, x20
00686FAE8  b.ne     #0x686fb14
00686FAEC  sxtw     x8, w8
00686FAF0  mul      x0, x22, x8
00686FAF4  mov      x1, xzr
00686FAF8  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686FAFC  cbz      x27, #0x686ffa0
00686FB00  ldr      w8, [x27, #0x18]
00686FB04  cmp      x21, x8
00686FB08  b.hs     #0x686ffa4
00686FB0C  str      w0, [x25]
00686FB10  b        #0x686fb28 ; 
00686FB14  cbz      x27, #0x686ffa0
00686FB18  ldr      w9, [x27, #0x18]
00686FB1C  cmp      x20, x9
00686FB20  b.hs     #0x686ffa4
00686FB24  str      w8, [x24, x20, lsl #2]
00686FB28  add      x20, x20, #1
00686FB2C  cmp      x23, x20
00686FB30  b.ne     #0x686fab4
00686FB34  b        #0x686fb60 ; 
00686FB38  ldr      x0, [x28]
00686FB3C  ldr      w8, [x0, #0xe0]
00686FB40  cbnz     w8, #0x686fb48
00686FB44  bl       #0x382be8c ; 
00686FB48  mov      x0, xzr
00686FB4C  bl       #0x64cb808 ; LocalModels.Const$$GetPunchboardRandomSkillCountWeight
00686FB50  mov      x1, x27
00686FB54  mov      w2, w26
00686FB58  mov      x3, xzr
00686FB5C  bl       #0x7c01418 ; System.Array$$Copy
00686FB60  stp      x27, x26, [sp, #8]
00686FB64  adrp     x8, #0x8ede000
00686FB68  ldr      x8, [x8, #0x100]
00686FB6C  ldr      x0, [x8]
00686FB70  bl       #0x382bfa0 ; 
00686FB74  adrp     x8, #0x8ede000
00686FB78  ldr      x8, [x8, #0x108]
00686FB7C  mov      x23, x0
00686FB80  ldr      x1, [x8]
00686FB84  bl       #0x4936d3c ; System.Collections.Generic.HashSet<int>$$.ctor
00686FB88  ldr      x8, [x19, #0x58]
00686FB8C  cbz      x8, #0x686ffa0
00686FB90  str      wzr, [sp, #0x1c]
00686FB94  adrp     x25, #0x8f06000
00686FB98  adrp     x26, #0x8f09000
00686FB9C  adrp     x27, #0x8f09000
00686FBA0  ldr      x25, [x25, #0x470]
00686FBA4  ldr      x26, [x26, #0x8c0]
00686FBA8  ldr      x27, [x27, #0xd0]
00686FBAC  mov      w24, wzr
00686FBB0  adrp     x21, #0x9591000
00686FBB4  mov      w20, #1
00686FBB8  adrp     x22, #0x9598000
00686FBBC  adrp     x29, #0x9599000
00686FBC0  ldr      w8, [x8, #0x18]
00686FBC4  cmp      w24, w8
00686FBC8  b.ge     #0x686fd8c
00686FBCC  ldrb     w8, [x21, #0xa4b]
00686FBD0  cbnz     w8, #0x686fbe4
00686FBD4  adrp     x0, #0x8ee5000
00686FBD8  ldr      x0, [x0, #0xb28]
00686FBDC  bl       #0x382bd14 ; 
00686FBE0  strb     w20, [x21, #0xa4b]
00686FBE4  adrp     x8, #0x8ee5000
00686FBE8  ldr      x8, [x8, #0xb28]
00686FBEC  ldr      x1, [x8]
00686FBF0  ldrb     w8, [x1, #0x53]
00686FBF4  tbnz     w8, #5, #0x686fc00
00686FBF8  ldr      x28, [x19, #0x20]
00686FBFC  b        #0x686fc10 ; 
00686FC00  ldr      x8, [x1, #0x60]
00686FC04  mov      x0, x19
00686FC08  blr      x8
00686FC0C  mov      x28, x0
00686FC10  cbz      x28, #0x686ffa0
00686FC14  ldrb     w8, [x22, #0xfcc]
00686FC18  cbnz     w8, #0x686fc28
00686FC1C  mov      x0, x25
00686FC20  bl       #0x382bd14 ; 
00686FC24  strb     w20, [x22, #0xfcc]
00686FC28  ldr      x1, [x25]
00686FC2C  ldrb     w8, [x1, #0x53]
00686FC30  tbnz     w8, #5, #0x686fc3c
00686FC34  ldr      x28, [x28, #0x200]
00686FC38  b        #0x686fc4c ; 
00686FC3C  ldr      x8, [x1, #0x60]
00686FC40  mov      x0, x28
00686FC44  blr      x8
00686FC48  mov      x28, x0
00686FC4C  ldr      x0, [x19, #0x58]
00686FC50  cbz      x0, #0x686ffa0
00686FC54  adrp     x8, #0x8ec2000
00686FC58  ldr      x8, [x8, #0x270]
00686FC5C  mov      w1, w24
00686FC60  ldr      x2, [x8]
00686FC64  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00686FC68  cbz      x28, #0x686ffa0
00686FC6C  mov      w1, w0
00686FC70  mov      x0, x28
00686FC74  mov      x2, xzr
00686FC78  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00686FC7C  cbz      x0, #0x686ffa0
00686FC80  ldrb     w8, [x29, #0x4dc]
00686FC84  mov      x28, x0
00686FC88  cbnz     w8, #0x686fc98
00686FC8C  mov      x0, x26
00686FC90  bl       #0x382bd14 ; 
00686FC94  strb     w20, [x29, #0x4dc]
00686FC98  ldr      x1, [x26]
00686FC9C  ldrb     w8, [x1, #0x53]
00686FCA0  tbnz     w8, #5, #0x686fcac
00686FCA4  ldr      w0, [x28, #0x24]
00686FCA8  b        #0x686fcb8 ; 
00686FCAC  ldr      x8, [x1, #0x60]
00686FCB0  mov      x0, x28
00686FCB4  blr      x8
00686FCB8  cmp      w0, #1
00686FCBC  b.ne     #0x686fd7c
00686FCC0  adrp     x8, #0x9599000
00686FCC4  ldrb     w8, [x8, #0x4c8]
00686FCC8  cbnz     w8, #0x686fcdc
00686FCCC  mov      x0, x27
00686FCD0  bl       #0x382bd14 ; 
00686FCD4  adrp     x8, #0x9599000
00686FCD8  strb     w20, [x8, #0x4c8]
00686FCDC  ldr      x1, [x27]
00686FCE0  ldrb     w8, [x1, #0x53]
00686FCE4  tbnz     w8, #5, #0x686fcf0
00686FCE8  ldr      w1, [x28, #0x120]
00686FCEC  b        #0x686fd00 ; 
00686FCF0  ldr      x8, [x1, #0x60]
00686FCF4  mov      x0, x28
00686FCF8  blr      x8
00686FCFC  mov      w1, w0
00686FD00  cbz      x23, #0x686ffa0
00686FD04  adrp     x8, #0x8ee3000
00686FD08  ldr      x8, [x8, #0xf18]
00686FD0C  mov      x0, x23
00686FD10  ldr      x2, [x8]
00686FD14  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
00686FD18  tbnz     w0, #0, #0x686fd7c
00686FD1C  adrp     x8, #0x9599000
00686FD20  ldrb     w8, [x8, #0x4c8]
00686FD24  cbnz     w8, #0x686fd38
00686FD28  mov      x0, x27
00686FD2C  bl       #0x382bd14 ; 
00686FD30  adrp     x8, #0x9599000
00686FD34  strb     w20, [x8, #0x4c8]
00686FD38  ldr      x1, [x27]
00686FD3C  ldrb     w8, [x1, #0x53]
00686FD40  tbnz     w8, #5, #0x686fd4c
00686FD44  ldr      w1, [x28, #0x120]
00686FD48  b        #0x686fd5c ; 
00686FD4C  ldr      x8, [x1, #0x60]
00686FD50  mov      x0, x28
00686FD54  blr      x8
00686FD58  mov      w1, w0
00686FD5C  adrp     x8, #0x8ede000
00686FD60  ldr      x8, [x8, #0xd0]
00686FD64  mov      x0, x23
00686FD68  ldr      x2, [x8]
00686FD6C  bl       #0x4937f40 ; System.Collections.Generic.HashSet<int>$$Add
00686FD70  ldr      w8, [sp, #0x1c]
00686FD74  add      w8, w8, #1
00686FD78  str      w8, [sp, #0x1c]
00686FD7C  ldr      x8, [x19, #0x58]
00686FD80  add      w24, w24, #1
00686FD84  cbnz     x8, #0x686fbc0
00686FD88  b        #0x686ffa0 ; 
00686FD8C  adrp     x20, #0x8ee8000
00686FD90  ldr      x20, [x20, #0x898]
00686FD94  ldr      x22, [sp, #0x10]
00686FD98  ldr      x0, [x20]
00686FD9C  ldr      w8, [x0, #0xe0]
00686FDA0  cbnz     w8, #0x686fdac
00686FDA4  bl       #0x382be8c ; 
00686FDA8  ldr      x0, [x20]
00686FDAC  ldr      x24, [sp, #8]
00686FDB0  cmp      w22, #5
00686FDB4  b.lt     #0x686fdec
00686FDB8  ldr      x8, [x0, #0xb8]
00686FDBC  ldr      w9, [sp, #0x1c]
00686FDC0  ldr      w8, [x8, #0x4a4]
00686FDC4  cmp      w9, w8
00686FDC8  b.gt     #0x686fdec
00686FDCC  cbz      x24, #0x686ffa0
00686FDD0  ldr      w9, [x24, #0x18]
00686FDD4  sub      w8, w22, #1
00686FDD8  cmp      w8, w9
00686FDDC  b.hs     #0x686ffa4
00686FDE0  add      x8, x24, w8, uxtw #2
00686FDE4  str      wzr, [x8, #0x20]
00686FDE8  b        #0x686fdf8 ; 
00686FDEC  cmp      w22, #1
00686FDF0  b.lt     #0x686ff94
00686FDF4  cbz      x24, #0x686ffa0
00686FDF8  ldr      w10, [x24, #0x18]
00686FDFC  mov      x9, xzr
00686FE00  mov      w8, wzr
00686FE04  and      x11, x22, #0xffffffff
00686FE08  add      x12, x24, #0x20
00686FE0C  cmp      x9, x10
00686FE10  b.hs     #0x686ffa4
00686FE14  ldr      w13, [x12, x9, lsl #2]
00686FE18  add      x9, x9, #1
00686FE1C  cmp      x11, x9
00686FE20  add      w8, w13, w8
00686FE24  b.ne     #0x686fe0c
00686FE28  add      w23, w8, #1
00686FE2C  mov      w20, #1
00686FE30  ldrb     w8, [x21, #0xa4b]
00686FE34  cbnz     w8, #0x686fe4c
00686FE38  adrp     x0, #0x8ee5000
00686FE3C  ldr      x0, [x0, #0xb28]
00686FE40  bl       #0x382bd14 ; 
00686FE44  mov      w8, #1
00686FE48  strb     w8, [x21, #0xa4b]
00686FE4C  adrp     x8, #0x8ee5000
00686FE50  ldr      x8, [x8, #0xb28]
00686FE54  ldr      x1, [x8]
00686FE58  ldrb     w8, [x1, #0x53]
00686FE5C  tbnz     w8, #5, #0x686fe68
00686FE60  ldr      x19, [x19, #0x20]
00686FE64  b        #0x686fe78 ; 
00686FE68  ldr      x8, [x1, #0x60]
00686FE6C  mov      x0, x19
00686FE70  blr      x8
00686FE74  mov      x19, x0
00686FE78  cbz      x19, #0x686ffa0
00686FE7C  adrp     x21, #0x9599000
00686FE80  ldrb     w8, [x21, #0xac6]
00686FE84  cbnz     w8, #0x686fe9c
00686FE88  adrp     x0, #0x8f0d000
00686FE8C  ldr      x0, [x0, #0x28]
00686FE90  bl       #0x382bd14 ; 
00686FE94  mov      w8, #1
00686FE98  strb     w8, [x21, #0xac6]
00686FE9C  adrp     x8, #0x8f0d000
00686FEA0  ldr      x8, [x8, #0x28]
00686FEA4  ldr      x3, [x8]
00686FEA8  ldrb     w8, [x3, #0x53]
00686FEAC  tbnz     w8, #5, #0x686feec
00686FEB0  adrp     x21, #0x9599000
00686FEB4  ldrb     w8, [x21, #0xac7]
00686FEB8  cbnz     w8, #0x686fed0
00686FEBC  adrp     x0, #0x8f0d000
00686FEC0  ldr      x0, [x0, #0x30]
00686FEC4  bl       #0x382bd14 ; 
00686FEC8  mov      w8, #1
00686FECC  strb     w8, [x21, #0xac7]
00686FED0  adrp     x8, #0x8f0d000
00686FED4  ldr      x8, [x8, #0x30]
00686FED8  ldr      x1, [x8]
00686FEDC  ldrb     w8, [x1, #0x53]
00686FEE0  tbnz     w8, #5, #0x686ff08
00686FEE4  ldr      x0, [x19, #0x260]
00686FEE8  b        #0x686ff14 ; 
00686FEEC  ldr      x8, [x3, #0x60]
00686FEF0  mov      x0, x19
00686FEF4  mov      w1, wzr
00686FEF8  mov      w2, w23
00686FEFC  blr      x8
00686FF00  cbnz     w20, #0x686ff38
00686FF04  b        #0x686ff68 ; 
00686FF08  ldr      x8, [x1, #0x60]
00686FF0C  mov      x0, x19
00686FF10  blr      x8
00686FF14  cbz      x0, #0x686ffa0
00686FF18  mov      w1, wzr
00686FF1C  mov      w2, w23
00686FF20  mov      x3, xzr
00686FF24  bl       #0x416d068 ; XXRandom$$Next
00686FF28  ldr      w8, [x19, #0x32c]
00686FF2C  add      w8, w8, #1
00686FF30  str      w8, [x19, #0x32c]
00686FF34  cbz      w20, #0x686ff68
00686FF38  cbz      x24, #0x686ffa0
00686FF3C  ldr      w8, [x24, #0x18]
00686FF40  mov      w9, wzr
00686FF44  cmp      w9, w8
00686FF48  b.hs     #0x686ffa4
00686FF4C  add      x10, x24, w9, sxtw #2
00686FF50  ldr      w10, [x10, #0x20]
00686FF54  subs     w0, w0, w10
00686FF58  b.lt     #0x686ff70
00686FF5C  add      w9, w9, #1
00686FF60  cmp      w22, w9
00686FF64  b.ne     #0x686ff44
00686FF68  mov      w0, #1
00686FF6C  b        #0x686ff74 ; 
00686FF70  add      w0, w9, #1
00686FF74  ldp      x20, x19, [sp, #0x70]
00686FF78  ldp      x22, x21, [sp, #0x60]
00686FF7C  ldp      x24, x23, [sp, #0x50]
00686FF80  ldp      x26, x25, [sp, #0x40]
00686FF84  ldp      x28, x27, [sp, #0x30]
00686FF88  ldp      x29, x30, [sp, #0x20]
00686FF8C  add      sp, sp, #0x80
00686FF90  ret      
00686FF94  mov      w20, wzr
00686FF98  mov      w23, #1
00686FF9C  b        #0x686fe30 ; 
00686FFA0  bl       #0x382bfb8 ; 
00686FFA4  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$ResolveSkillIconId
; RVA 0x686FFA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686FFA8  stp      x29, x30, [sp, #-0x60]!
00686FFAC  stp      x28, x27, [sp, #0x10]
00686FFB0  stp      x26, x25, [sp, #0x20]
00686FFB4  stp      x24, x23, [sp, #0x30]
00686FFB8  stp      x22, x21, [sp, #0x40]
00686FFBC  stp      x20, x19, [sp, #0x50]
00686FFC0  adrp     x21, #0x959b000
00686FFC4  adrp     x22, #0x8f24000
00686FFC8  ldrb     w8, [x21, #0xa60]
00686FFCC  ldr      x22, [x22, #0x2e0]
00686FFD0  mov      w20, w1
00686FFD4  mov      x19, x0
00686FFD8  tbnz     w8, #0, #0x6870038
00686FFDC  adrp     x0, #0x8f24000
00686FFE0  ldr      x0, [x0, #0x2e8]
00686FFE4  bl       #0x382bd14 ; 
00686FFE8  adrp     x0, #0x8f24000
00686FFEC  ldr      x0, [x0, #0x2e0]
00686FFF0  bl       #0x382bd14 ; 
00686FFF4  adrp     x0, #0x8f24000
00686FFF8  ldr      x0, [x0, #0x2f0]
00686FFFC  bl       #0x382bd14 ; 
006870000  adrp     x0, #0x8f24000
006870004  ldr      x0, [x0, #0x2f8]
006870008  bl       #0x382bd14 ; 
00687000C  adrp     x0, #0x8f24000
006870010  ldr      x0, [x0, #0x300]
006870014  bl       #0x382bd14 ; 
006870018  adrp     x0, #0x8f24000
00687001C  ldr      x0, [x0, #0x308]
006870020  bl       #0x382bd14 ; 
006870024  adrp     x0, #0x8f24000
006870028  ldr      x0, [x0, #0x310]
00687002C  bl       #0x382bd14 ; 
006870030  mov      w8, #1
006870034  strb     w8, [x21, #0xa60]
006870038  ldr      x2, [x22]
00687003C  ldrb     w8, [x2, #0x53]
006870040  tbnz     w8, #5, #0x68700a0
006870044  adrp     x8, #0x8f24000
006870048  ldr      x8, [x8, #0x310]
00687004C  ldr      x0, [x8]
006870050  bl       #0x382bfa0 ; 
006870054  mov      x21, x0
006870058  bl       #0x687039c ; HotFix.BattleLogic.HeroComponentRandomSkill.<>c__DisplayClass68_0$$.ctor
00687005C  cbz      x21, #0x6870328
006870060  str      w20, [x21, #0x10]
006870064  adrp     x22, #0x9591000
006870068  ldrb     w8, [x22, #0xa4b]
00687006C  cbnz     w8, #0x6870084
006870070  adrp     x0, #0x8ee5000
006870074  ldr      x0, [x0, #0xb28]
006870078  bl       #0x382bd14 ; 
00687007C  mov      w8, #1
006870080  strb     w8, [x22, #0xa4b]
006870084  adrp     x8, #0x8ee5000
006870088  ldr      x8, [x8, #0xb28]
00687008C  ldr      x1, [x8]
006870090  ldrb     w8, [x1, #0x53]
006870094  tbnz     w8, #5, #0x68700c8
006870098  ldr      x22, [x19, #0x20]
00687009C  b        #0x68700d8 ; 
0068700A0  ldr      x3, [x2, #0x60]
0068700A4  mov      x0, x19
0068700A8  mov      w1, w20
0068700AC  ldp      x20, x19, [sp, #0x50]
0068700B0  ldp      x22, x21, [sp, #0x40]
0068700B4  ldp      x24, x23, [sp, #0x30]
0068700B8  ldp      x26, x25, [sp, #0x20]
0068700BC  ldp      x28, x27, [sp, #0x10]
0068700C0  ldp      x29, x30, [sp], #0x60
0068700C4  br       x3
0068700C8  ldr      x8, [x1, #0x60]
0068700CC  mov      x0, x19
0068700D0  blr      x8
0068700D4  mov      x22, x0
0068700D8  cbz      x22, #0x6870328
0068700DC  adrp     x23, #0x9598000
0068700E0  ldrb     w8, [x23, #0xfcc]
0068700E4  cbnz     w8, #0x68700fc
0068700E8  adrp     x0, #0x8f06000
0068700EC  ldr      x0, [x0, #0x470]
0068700F0  bl       #0x382bd14 ; 
0068700F4  mov      w8, #1
0068700F8  strb     w8, [x23, #0xfcc]
0068700FC  adrp     x8, #0x8f06000
006870100  ldr      x8, [x8, #0x470]
006870104  ldr      x1, [x8]
006870108  ldrb     w8, [x1, #0x53]
00687010C  tbnz     w8, #5, #0x6870118
006870110  ldr      x0, [x22, #0x200]
006870114  b        #0x6870124 ; 
006870118  ldr      x8, [x1, #0x60]
00687011C  mov      x0, x22
006870120  blr      x8
006870124  cbz      x0, #0x6870328
006870128  mov      x1, xzr
00687012C  bl       #0x64e1b68 ; LocalModels.LocalModelManager$$GetSkill_MainElements
006870130  adrp     x8, #0x8f24000
006870134  ldr      x8, [x8, #0x2e8]
006870138  ldr      x1, [x8]
00687013C  bl       #0x45dc24c ; System.Linq.Enumerable$$ToList<object>
006870140  adrp     x8, #0x8f24000
006870144  ldr      x8, [x8, #0x2f8]
006870148  mov      x22, x0
00687014C  ldr      x8, [x8]
006870150  mov      x0, x8
006870154  bl       #0x382bfa0 ; 
006870158  adrp     x8, #0x8f24000
00687015C  ldr      x8, [x8, #0x300]
006870160  mov      x1, x21
006870164  mov      x3, xzr
006870168  mov      x23, x0
00687016C  ldr      x2, [x8]
006870170  bl       #0x527cd68 ; System.Predicate<object>$$.ctor
006870174  cbz      x22, #0x6870328
006870178  adrp     x28, #0x8f24000
00687017C  ldr      x28, [x28, #0x2f0]
006870180  mov      x0, x22
006870184  mov      x1, x23
006870188  ldr      x2, [x28]
00687018C  bl       #0x4db04fc ; System.Collections.Generic.List<object>$$Find
006870190  mov      x1, x0
006870194  mov      x23, x21
006870198  str      x1, [x23, #0x18]!
00687019C  mov      x0, x23
0068701A0  bl       #0x382bcb8 ; 
0068701A4  ldr      x25, [x23]
0068701A8  cbz      x25, #0x6870358
0068701AC  adrp     x29, #0x9598000
0068701B0  ldrb     w8, [x29, #0xde3]
0068701B4  cbnz     w8, #0x68701cc
0068701B8  adrp     x0, #0x8f00000
0068701BC  ldr      x0, [x0, #0xd98]
0068701C0  bl       #0x382bd14 ; 
0068701C4  mov      w8, #1
0068701C8  strb     w8, [x29, #0xde3]
0068701CC  adrp     x24, #0x8f00000
0068701D0  ldr      x24, [x24, #0xd98]
0068701D4  ldr      x1, [x24]
0068701D8  ldrb     w8, [x1, #0x53]
0068701DC  tbnz     w8, #5, #0x68701e8
0068701E0  ldr      w20, [x25, #0x20]
0068701E4  b        #0x68701f8 ; 
0068701E8  ldr      x8, [x1, #0x60]
0068701EC  mov      x0, x25
0068701F0  blr      x8
0068701F4  mov      w20, w0
0068701F8  ldr      x26, [x23]
0068701FC  cbz      x26, #0x6870328
006870200  add      x25, x21, #0x20
006870204  mov      w27, #0x65
006870208  ldrb     w8, [x29, #0xde3]
00687020C  cbnz     w8, #0x6870220
006870210  mov      x0, x24
006870214  bl       #0x382bd14 ; 
006870218  mov      w8, #1
00687021C  strb     w8, [x29, #0xde3]
006870220  ldr      x1, [x24]
006870224  ldrb     w8, [x1, #0x53]
006870228  tbnz     w8, #5, #0x6870234
00687022C  ldr      w1, [x26, #0x20]
006870230  b        #0x6870244 ; 
006870234  ldr      x8, [x1, #0x60]
006870238  mov      x0, x26
00687023C  blr      x8
006870240  mov      w1, w0
006870244  mov      x0, x19
006870248  bl       #0x6869340 ; HotFix.BattleLogic.HeroComponentRandomSkill$$HasSkill
00687024C  tbnz     w0, #0, #0x6870358
006870250  subs     w27, w27, #1
006870254  b.eq     #0x6870358
006870258  ldr      x0, [x23]
00687025C  cbz      x0, #0x6870328
006870260  mov      x1, xzr
006870264  bl       #0x6b09f68 ; LocalModels.Bean.Skill_Main$$get_HasNextSkill
006870268  tbz      w0, #0, #0x6870358
00687026C  ldr      x26, [x25]
006870270  cbnz     x26, #0x68702b0
006870274  adrp     x8, #0x8f24000
006870278  ldr      x8, [x8, #0x2f8]
00687027C  ldr      x0, [x8]
006870280  bl       #0x382bfa0 ; 
006870284  adrp     x8, #0x8f24000
006870288  ldr      x8, [x8, #0x308]
00687028C  mov      x1, x21
006870290  mov      x3, xzr
006870294  mov      x26, x0
006870298  ldr      x2, [x8]
00687029C  bl       #0x527cd68 ; System.Predicate<object>$$.ctor
0068702A0  mov      x0, x25
0068702A4  mov      x1, x26
0068702A8  str      x26, [x21, #0x20]
0068702AC  bl       #0x382bcb8 ; 
0068702B0  ldr      x2, [x28]
0068702B4  mov      x0, x22
0068702B8  mov      x1, x26
0068702BC  bl       #0x4db04fc ; System.Collections.Generic.List<object>$$Find
0068702C0  cbz      x0, #0x6870358
0068702C4  ldrb     w8, [x29, #0xde3]
0068702C8  mov      x26, x0
0068702CC  cbnz     w8, #0x68702e0
0068702D0  mov      x0, x24
0068702D4  bl       #0x382bd14 ; 
0068702D8  mov      w8, #1
0068702DC  strb     w8, [x29, #0xde3]
0068702E0  ldr      x1, [x24]
0068702E4  ldrb     w8, [x1, #0x53]
0068702E8  tbnz     w8, #5, #0x68702f4
0068702EC  ldr      w1, [x26, #0x20]
0068702F0  b        #0x6870304 ; 
0068702F4  ldr      x8, [x1, #0x60]
0068702F8  mov      x0, x26
0068702FC  blr      x8
006870300  mov      w1, w0
006870304  mov      x0, x19
006870308  bl       #0x6869340 ; HotFix.BattleLogic.HeroComponentRandomSkill$$HasSkill
00687030C  tbnz     w0, #0, #0x687032c
006870310  mov      x0, x23
006870314  mov      x1, x26
006870318  str      x26, [x23]
00687031C  bl       #0x382bcb8 ; 
006870320  ldr      x26, [x23]
006870324  cbnz     x26, #0x6870208
006870328  bl       #0x382bfb8 ; 
00687032C  ldrb     w8, [x29, #0xde3]
006870330  cbnz     w8, #0x6870348
006870334  adrp     x0, #0x8f00000
006870338  ldr      x0, [x0, #0xd98]
00687033C  bl       #0x382bd14 ; 
006870340  mov      w8, #1
006870344  strb     w8, [x29, #0xde3]
006870348  ldr      x1, [x24]
00687034C  ldrb     w8, [x1, #0x53]
006870350  tbnz     w8, #5, #0x6870378
006870354  ldr      w20, [x26, #0x20]
006870358  mov      w0, w20
00687035C  ldp      x20, x19, [sp, #0x50]
006870360  ldp      x22, x21, [sp, #0x40]
006870364  ldp      x24, x23, [sp, #0x30]
006870368  ldp      x26, x25, [sp, #0x20]
00687036C  ldp      x28, x27, [sp, #0x10]
006870370  ldp      x29, x30, [sp], #0x60
006870374  ret      
006870378  ldr      x2, [x1, #0x60]
00687037C  mov      x0, x26
006870380  ldp      x20, x19, [sp, #0x50]
006870384  ldp      x22, x21, [sp, #0x40]
006870388  ldp      x24, x23, [sp, #0x30]
00687038C  ldp      x26, x25, [sp, #0x20]
006870390  ldp      x28, x27, [sp, #0x10]
006870394  ldp      x29, x30, [sp], #0x60
006870398  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckNeedOpenSpecialSkill
; RVA 0x6870404; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006870404  stp      x30, x21, [sp, #-0x20]!
006870408  stp      x20, x19, [sp, #0x10]
00687040C  adrp     x20, #0x959b000
006870410  adrp     x21, #0x8f24000
006870414  ldrb     w8, [x20, #0xa61]
006870418  ldr      x21, [x21, #0x320]
00687041C  mov      x19, x0
006870420  tbnz     w8, #0, #0x6870438
006870424  adrp     x0, #0x8f24000
006870428  ldr      x0, [x0, #0x320]
00687042C  bl       #0x382bd14 ; 
006870430  mov      w8, #1
006870434  strb     w8, [x20, #0xa61]
006870438  ldr      x1, [x21]
00687043C  ldrb     w8, [x1, #0x53]
006870440  tbnz     w8, #5, #0x687045c
006870444  ldr      x0, [x19, #0x88]
006870448  cbz      x0, #0x6870470
00687044C  ldr      x8, [x0]
006870450  ldr      x2, [x8, #0x2b8]
006870454  ldr      x1, [x8, #0x2c0]
006870458  b        #0x6870464 ; 
00687045C  ldr      x2, [x1, #0x60]
006870460  mov      x0, x19
006870464  ldp      x20, x19, [sp, #0x10]
006870468  ldp      x30, x21, [sp], #0x20
00687046C  br       x2
006870470  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$OpenSelectSpecialSkill
; RVA 0x6870474; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006870474  sub      sp, sp, #0x70
006870478  stp      x29, x30, [sp, #0x10]
00687047C  stp      x28, x27, [sp, #0x20]
006870480  stp      x26, x25, [sp, #0x30]
006870484  stp      x24, x23, [sp, #0x40]
006870488  stp      x22, x21, [sp, #0x50]
00687048C  stp      x20, x19, [sp, #0x60]
006870490  adrp     x20, #0x959b000
006870494  adrp     x22, #0x8f24000
006870498  ldrb     w8, [x20, #0xa62]
00687049C  ldr      x22, [x22, #0x328]
0068704A0  mov      w21, w1
0068704A4  mov      x19, x0
0068704A8  tbnz     w8, #0, #0x6870514
0068704AC  adrp     x0, #0x8f09000
0068704B0  ldr      x0, [x0, #0x150]
0068704B4  bl       #0x382bd14 ; 
0068704B8  adrp     x0, #0x8ee6000
0068704BC  ldr      x0, [x0, #0xd8]
0068704C0  bl       #0x382bd14 ; 
0068704C4  adrp     x0, #0x8f23000
0068704C8  ldr      x0, [x0, #0x140]
0068704CC  bl       #0x382bd14 ; 
0068704D0  adrp     x0, #0x8ee3000
0068704D4  ldr      x0, [x0, #0xf48]
0068704D8  bl       #0x382bd14 ; 
0068704DC  adrp     x0, #0x8f24000
0068704E0  ldr      x0, [x0, #0x328]
0068704E4  bl       #0x382bd14 ; 
0068704E8  adrp     x0, #0x8ec2000
0068704EC  ldr      x0, [x0, #0x268]
0068704F0  bl       #0x382bd14 ; 
0068704F4  adrp     x0, #0x8f08000
0068704F8  ldr      x0, [x0, #0xbb8]
0068704FC  bl       #0x382bd14 ; 
006870500  adrp     x0, #0x8f08000
006870504  ldr      x0, [x0, #0xbc0]
006870508  bl       #0x382bd14 ; 
00687050C  mov      w8, #1
006870510  strb     w8, [x20, #0xa62]
006870514  ldr      x2, [x22]
006870518  ldrb     w8, [x2, #0x53]
00687051C  tbnz     w8, #5, #0x6870564
006870520  ldrb     w8, [x19, #0x90]
006870524  cbnz     w8, #0x6870748
006870528  adrp     x26, #0x9591000
00687052C  ldrb     w8, [x26, #0xa4b]
006870530  cbnz     w8, #0x6870548
006870534  adrp     x0, #0x8ee5000
006870538  ldr      x0, [x0, #0xb28]
00687053C  bl       #0x382bd14 ; 
006870540  mov      w8, #1
006870544  strb     w8, [x26, #0xa4b]
006870548  adrp     x27, #0x8ee5000
00687054C  ldr      x27, [x27, #0xb28]
006870550  ldr      x1, [x27]
006870554  ldrb     w8, [x1, #0x53]
006870558  tbnz     w8, #5, #0x6870590
00687055C  ldr      x20, [x19, #0x20]
006870560  b        #0x68705a0 ; 
006870564  ldr      x3, [x2, #0x60]
006870568  and      w1, w21, #1
00687056C  mov      x0, x19
006870570  ldp      x20, x19, [sp, #0x60]
006870574  ldp      x22, x21, [sp, #0x50]
006870578  ldp      x24, x23, [sp, #0x40]
00687057C  ldp      x26, x25, [sp, #0x30]
006870580  ldp      x28, x27, [sp, #0x20]
006870584  ldp      x29, x30, [sp, #0x10]
006870588  add      sp, sp, #0x70
00687058C  br       x3
006870590  ldr      x8, [x1, #0x60]
006870594  mov      x0, x19
006870598  blr      x8
00687059C  mov      x20, x0
0068705A0  cbz      x20, #0x6871260
0068705A4  adrp     x24, #0x9591000
0068705A8  ldrb     w8, [x24, #0xa90]
0068705AC  cbnz     w8, #0x68705c4
0068705B0  adrp     x0, #0x8ee6000
0068705B4  ldr      x0, [x0, #0x3e0]
0068705B8  bl       #0x382bd14 ; 
0068705BC  mov      w8, #1
0068705C0  strb     w8, [x24, #0xa90]
0068705C4  adrp     x23, #0x8ee6000
0068705C8  ldr      x23, [x23, #0x3e0]
0068705CC  ldr      x1, [x23]
0068705D0  ldrb     w8, [x1, #0x53]
0068705D4  tbnz     w8, #5, #0x68705e0
0068705D8  ldr      x0, [x20, #0x230]
0068705DC  b        #0x68705ec ; 
0068705E0  ldr      x8, [x1, #0x60]
0068705E4  mov      x0, x20
0068705E8  blr      x8
0068705EC  cbz      x0, #0x6871260
0068705F0  adrp     x8, #0x8f08000
0068705F4  ldr      x8, [x8, #0xbb8]
0068705F8  ldr      x1, [x8]
0068705FC  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006870600  str      wzr, [sp, #0xc]
006870604  adrp     x28, #0x9599000
006870608  ldrb     w8, [x28, #0x4c7]
00687060C  ldr      x22, [x19, #0x88]
006870610  mov      x20, x0
006870614  cbnz     w8, #0x687062c
006870618  adrp     x0, #0x8f09000
00687061C  ldr      x0, [x0, #0xc8]
006870620  bl       #0x382bd14 ; 
006870624  mov      w8, #1
006870628  strb     w8, [x28, #0x4c7]
00687062C  adrp     x29, #0x8f09000
006870630  ldr      x29, [x29, #0xc8]
006870634  ldr      x1, [x29]
006870638  ldrb     w8, [x1, #0x53]
00687063C  tbnz     w8, #5, #0x6870648
006870640  ldr      x2, [x19, #0x58]
006870644  b        #0x6870658 ; 
006870648  ldr      x8, [x1, #0x60]
00687064C  mov      x0, x19
006870650  blr      x8
006870654  mov      x2, x0
006870658  cbz      x22, #0x6871260
00687065C  ldr      x8, [x22]
006870660  add      x3, sp, #0xc
006870664  mov      x0, x22
006870668  mov      x1, x20
00687066C  ldr      x9, [x8, #0x2a8]
006870670  ldr      x4, [x8, #0x2b0]
006870674  blr      x9
006870678  tbz      w0, #0, #0x68706b0
00687067C  cbz      x20, #0x6871260
006870680  ldr      w8, [x20, #0x18]
006870684  cmp      w8, #1
006870688  b.lt     #0x68706b0
00687068C  mov      w8, #1
006870690  strb     w8, [x19, #0x90]
006870694  adrp     x8, #0x8f23000
006870698  ldr      x8, [x8, #0x140]
00687069C  ldr      x1, [x8]
0068706A0  ldrb     w8, [x1, #0x53]
0068706A4  tbnz     w8, #5, #0x687076c
0068706A8  ldr      x0, [x19, #0x30]
0068706AC  b        #0x6870778 ; 
0068706B0  ldrb     w8, [x26, #0xa4b]
0068706B4  cbnz     w8, #0x68706cc
0068706B8  adrp     x0, #0x8ee5000
0068706BC  ldr      x0, [x0, #0xb28]
0068706C0  bl       #0x382bd14 ; 
0068706C4  mov      w8, #1
0068706C8  strb     w8, [x26, #0xa4b]
0068706CC  ldr      x1, [x27]
0068706D0  ldrb     w8, [x1, #0x53]
0068706D4  tbnz     w8, #5, #0x68706e0
0068706D8  ldr      x19, [x19, #0x20]
0068706DC  b        #0x68706f0 ; 
0068706E0  ldr      x8, [x1, #0x60]
0068706E4  mov      x0, x19
0068706E8  blr      x8
0068706EC  mov      x19, x0
0068706F0  cbz      x19, #0x6871260
0068706F4  ldrb     w8, [x24, #0xa90]
0068706F8  cbnz     w8, #0x6870710
0068706FC  adrp     x0, #0x8ee6000
006870700  ldr      x0, [x0, #0x3e0]
006870704  bl       #0x382bd14 ; 
006870708  mov      w8, #1
00687070C  strb     w8, [x24, #0xa90]
006870710  ldr      x1, [x23]
006870714  ldrb     w8, [x1, #0x53]
006870718  tbnz     w8, #5, #0x6870724
00687071C  ldr      x0, [x19, #0x230]
006870720  b        #0x6870730 ; 
006870724  ldr      x8, [x1, #0x60]
006870728  mov      x0, x19
00687072C  blr      x8
006870730  cbz      x0, #0x6871260
006870734  adrp     x8, #0x8f08000
006870738  ldr      x8, [x8, #0xbc0]
00687073C  mov      x1, x20
006870740  ldr      x2, [x8]
006870744  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
006870748  mov      w0, wzr
00687074C  ldp      x20, x19, [sp, #0x60]
006870750  ldp      x22, x21, [sp, #0x50]
006870754  ldp      x24, x23, [sp, #0x40]
006870758  ldp      x26, x25, [sp, #0x30]
00687075C  ldp      x28, x27, [sp, #0x20]
006870760  ldp      x29, x30, [sp, #0x10]
006870764  add      sp, sp, #0x70
006870768  ret      
00687076C  ldr      x8, [x1, #0x60]
006870770  mov      x0, x19
006870774  blr      x8
006870778  cbz      x0, #0x6871260
00687077C  adrp     x8, #0x8f09000
006870780  ldr      x8, [x8, #0x150]
006870784  ldr      x1, [x8]
006870788  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00687078C  cbz      x0, #0x6871260
006870790  mov      x1, xzr
006870794  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
006870798  ldr      x22, [x19, #0x80]
00687079C  cbz      x22, #0x6871260
0068707A0  ldr      w8, [x22, #0x14]
0068707A4  strb     wzr, [x22, #0x24]
0068707A8  stp      w0, wzr, [x22, #0x1c]
0068707AC  add      w8, w8, #1
0068707B0  stp      w8, wzr, [x22, #0x14]
0068707B4  ldr      x23, [x19, #0x88]
0068707B8  cbz      x23, #0x6871260
0068707BC  adrp     x25, #0x959b000
0068707C0  ldrb     w8, [x25, #0xbb1]
0068707C4  cbnz     w8, #0x68707dc
0068707C8  adrp     x0, #0x8f24000
0068707CC  ldr      x0, [x0, #0x200]
0068707D0  bl       #0x382bd14 ; 
0068707D4  mov      w8, #1
0068707D8  strb     w8, [x25, #0xbb1]
0068707DC  adrp     x8, #0x8f24000
0068707E0  ldr      x8, [x8, #0x200]
0068707E4  ldr      x1, [x8]
0068707E8  ldrb     w8, [x1, #0x53]
0068707EC  tbnz     w8, #5, #0x68707f8
0068707F0  ldr      w0, [x23, #0x60]
0068707F4  b        #0x6870804 ; 
0068707F8  ldr      x8, [x1, #0x60]
0068707FC  mov      x0, x23
006870800  blr      x8
006870804  adrp     x25, #0x959b000
006870808  ldrb     w8, [x25, #0xb91]
00687080C  add      w23, w0, #1
006870810  cbnz     w8, #0x6870828
006870814  adrp     x0, #0x8f23000
006870818  ldr      x0, [x0, #0xef0]
00687081C  bl       #0x382bd14 ; 
006870820  mov      w8, #1
006870824  strb     w8, [x25, #0xb91]
006870828  adrp     x8, #0x8f23000
00687082C  ldr      x8, [x8, #0xef0]
006870830  ldr      x2, [x8]
006870834  ldrb     w8, [x2, #0x53]
006870838  tbnz     w8, #5, #0x6870844
00687083C  str      w23, [x22, #0x68]
006870840  b        #0x6870854 ; 
006870844  ldr      x8, [x2, #0x60]
006870848  mov      x0, x22
00687084C  mov      w1, w23
006870850  blr      x8
006870854  ldr      x22, [x19, #0x80]
006870858  cbz      x22, #0x6871260
00687085C  strb     wzr, [x22, #0x26]
006870860  ldrb     w8, [x28, #0x4c7]
006870864  cbnz     w8, #0x687087c
006870868  adrp     x0, #0x8f09000
00687086C  ldr      x0, [x0, #0xc8]
006870870  bl       #0x382bd14 ; 
006870874  mov      w8, #1
006870878  strb     w8, [x28, #0x4c7]
00687087C  ldr      x1, [x29]
006870880  ldrb     w8, [x1, #0x53]
006870884  tbnz     w8, #5, #0x6870890
006870888  ldr      x1, [x19, #0x58]
00687088C  b        #0x68708a0 ; 
006870890  ldr      x8, [x1, #0x60]
006870894  mov      x0, x19
006870898  blr      x8
00687089C  mov      x1, x0
0068708A0  str      x1, [x22, #0x30]!
0068708A4  mov      x0, x22
0068708A8  bl       #0x382bcb8 ; 
0068708AC  ldr      x0, [x19, #0x80]
0068708B0  cbz      x0, #0x6871260
0068708B4  mov      x1, x20
0068708B8  bl       #0x6866748 ; HotFix.BattleLogic.RandomSkillResult$$InitByList
0068708BC  adrp     x8, #0x8ee3000
0068708C0  ldr      x22, [x19, #0x80]
0068708C4  ldr      x0, [x19, #0x50]
0068708C8  ldr      x8, [x8, #0xf48]
0068708CC  ldr      x1, [x8]
0068708D0  bl       #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
0068708D4  cbz      x22, #0x6871260
0068708D8  adrp     x25, #0x959b000
0068708DC  ldrb     w8, [x25, #0xb95]
0068708E0  mov      x23, x0
0068708E4  cbnz     w8, #0x68708fc
0068708E8  adrp     x0, #0x8f23000
0068708EC  ldr      x0, [x0, #0xee0]
0068708F0  bl       #0x382bd14 ; 
0068708F4  mov      w8, #1
0068708F8  strb     w8, [x25, #0xb95]
0068708FC  adrp     x8, #0x8f23000
006870900  ldr      x8, [x8, #0xee0]
006870904  ldr      x2, [x8]
006870908  ldrb     w8, [x2, #0x53]
00687090C  tbnz     w8, #5, #0x6870924
006870910  str      x23, [x22, #0x58]!
006870914  mov      x0, x22
006870918  mov      x1, x23
00687091C  bl       #0x382bcb8 ; 
006870920  b        #0x6870934 ; 
006870924  ldr      x8, [x2, #0x60]
006870928  mov      x0, x22
00687092C  mov      x1, x23
006870930  blr      x8
006870934  ldrb     w8, [x26, #0xa4b]
006870938  ldr      x22, [x19, #0x80]
00687093C  cbnz     w8, #0x6870954
006870940  adrp     x0, #0x8ee5000
006870944  ldr      x0, [x0, #0xb28]
006870948  bl       #0x382bd14 ; 
00687094C  mov      w8, #1
006870950  strb     w8, [x26, #0xa4b]
006870954  ldr      x1, [x27]
006870958  ldrb     w8, [x1, #0x53]
00687095C  tbnz     w8, #5, #0x6870968
006870960  ldr      x23, [x19, #0x20]
006870964  b        #0x6870978 ; 
006870968  ldr      x8, [x1, #0x60]
00687096C  mov      x0, x19
006870970  blr      x8
006870974  mov      x23, x0
006870978  cbz      x23, #0x6871260
00687097C  adrp     x29, #0x9598000
006870980  ldrb     w8, [x29, #0xfc4]
006870984  cbnz     w8, #0x687099c
006870988  adrp     x0, #0x8f05000
00687098C  ldr      x0, [x0, #0xfd8]
006870990  bl       #0x382bd14 ; 
006870994  mov      w8, #1
006870998  strb     w8, [x29, #0xfc4]
00687099C  adrp     x28, #0x8f05000
0068709A0  ldr      x28, [x28, #0xfd8]
0068709A4  ldr      x1, [x28]
0068709A8  ldrb     w8, [x1, #0x53]
0068709AC  tbnz     w8, #5, #0x68709b8
0068709B0  ldr      x0, [x23, #0x220]
0068709B4  b        #0x68709c4 ; 
0068709B8  ldr      x8, [x1, #0x60]
0068709BC  mov      x0, x23
0068709C0  blr      x8
0068709C4  cbz      x0, #0x6871260
0068709C8  mov      x1, xzr
0068709CC  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
0068709D0  cbz      x22, #0x6871260
0068709D4  adrp     x25, #0x959b000
0068709D8  ldrb     w8, [x25, #0xb97]
0068709DC  mov      w23, w0
0068709E0  cbnz     w8, #0x68709f8
0068709E4  adrp     x0, #0x8f23000
0068709E8  ldr      x0, [x0, #0xe80]
0068709EC  bl       #0x382bd14 ; 
0068709F0  mov      w8, #1
0068709F4  strb     w8, [x25, #0xb97]
0068709F8  adrp     x8, #0x8f23000
0068709FC  ldr      x8, [x8, #0xe80]
006870A00  ldr      x2, [x8]
006870A04  ldrb     w8, [x2, #0x53]
006870A08  tbnz     w8, #5, #0x6870a18
006870A0C  and      w8, w23, #1
006870A10  strb     w8, [x22, #0x3c]
006870A14  b        #0x6870a28 ; 
006870A18  ldr      x8, [x2, #0x60]
006870A1C  and      w1, w23, #1
006870A20  mov      x0, x22
006870A24  blr      x8
006870A28  ldr      x22, [x19, #0x80]
006870A2C  cbz      x22, #0x6871260
006870A30  adrp     x23, #0x959b000
006870A34  ldrb     w8, [x23, #0xb99]
006870A38  cbnz     w8, #0x6870a50
006870A3C  adrp     x0, #0x8f23000
006870A40  ldr      x0, [x0, #0xeb0]
006870A44  bl       #0x382bd14 ; 
006870A48  mov      w8, #1
006870A4C  strb     w8, [x23, #0xb99]
006870A50  adrp     x8, #0x8f23000
006870A54  ldr      x8, [x8, #0xeb0]
006870A58  ldr      x2, [x8]
006870A5C  ldrb     w8, [x2, #0x53]
006870A60  tbnz     w8, #5, #0x6870a6c
006870A64  strb     wzr, [x22, #0x48]
006870A68  b        #0x6870a7c ; 
006870A6C  ldr      x8, [x2, #0x60]
006870A70  mov      x0, x22
006870A74  mov      w1, wzr
006870A78  blr      x8
006870A7C  ldrb     w8, [x26, #0xa4b]
006870A80  cbnz     w8, #0x6870a98
006870A84  adrp     x0, #0x8ee5000
006870A88  ldr      x0, [x0, #0xb28]
006870A8C  bl       #0x382bd14 ; 
006870A90  mov      w8, #1
006870A94  strb     w8, [x26, #0xa4b]
006870A98  ldr      x1, [x27]
006870A9C  ldrb     w8, [x1, #0x53]
006870AA0  tbnz     w8, #5, #0x6870aac
006870AA4  ldr      x22, [x19, #0x20]
006870AA8  b        #0x6870abc ; 
006870AAC  ldr      x8, [x1, #0x60]
006870AB0  mov      x0, x19
006870AB4  blr      x8
006870AB8  mov      x22, x0
006870ABC  cbz      x22, #0x6871260
006870AC0  ldrb     w8, [x29, #0xfc4]
006870AC4  cbnz     w8, #0x6870adc
006870AC8  adrp     x0, #0x8f05000
006870ACC  ldr      x0, [x0, #0xfd8]
006870AD0  bl       #0x382bd14 ; 
006870AD4  mov      w8, #1
006870AD8  strb     w8, [x29, #0xfc4]
006870ADC  ldr      x1, [x28]
006870AE0  ldrb     w8, [x1, #0x53]
006870AE4  tbnz     w8, #5, #0x6870af0
006870AE8  ldr      x0, [x22, #0x220]
006870AEC  b        #0x6870afc ; 
006870AF0  ldr      x8, [x1, #0x60]
006870AF4  mov      x0, x22
006870AF8  blr      x8
006870AFC  cbz      x0, #0x6871260
006870B00  ldr      x8, [x0]
006870B04  ldp      x9, x1, [x8, #0x1a8]
006870B08  blr      x9
006870B0C  tbz      w0, #0, #0x6870bec
006870B10  ldrb     w8, [x26, #0xa4b]
006870B14  cbnz     w8, #0x6870b2c
006870B18  adrp     x0, #0x8ee5000
006870B1C  ldr      x0, [x0, #0xb28]
006870B20  bl       #0x382bd14 ; 
006870B24  mov      w8, #1
006870B28  strb     w8, [x26, #0xa4b]
006870B2C  ldr      x1, [x27]
006870B30  ldrb     w8, [x1, #0x53]
006870B34  tbnz     w8, #5, #0x6870b40
006870B38  ldr      x22, [x19, #0x20]
006870B3C  b        #0x6870b50 ; 
006870B40  ldr      x8, [x1, #0x60]
006870B44  mov      x0, x19
006870B48  blr      x8
006870B4C  mov      x22, x0
006870B50  cbz      x22, #0x6871260
006870B54  adrp     x23, #0x9599000
006870B58  ldrb     w8, [x23, #0x29b]
006870B5C  cbnz     w8, #0x6870b74
006870B60  adrp     x0, #0x8f08000
006870B64  ldr      x0, [x0, #0x68]
006870B68  bl       #0x382bd14 ; 
006870B6C  mov      w8, #1
006870B70  strb     w8, [x23, #0x29b]
006870B74  adrp     x8, #0x8f08000
006870B78  ldr      x8, [x8, #0x68]
006870B7C  ldr      x1, [x8]
006870B80  ldrb     w8, [x1, #0x53]
006870B84  tbnz     w8, #5, #0x6870b90
006870B88  ldr      w0, [x22, #0x18c]
006870B8C  b        #0x6870b9c ; 
006870B90  ldr      x8, [x1, #0x60]
006870B94  mov      x0, x22
006870B98  blr      x8
006870B9C  adrp     x25, #0x9599000
006870BA0  ldrb     w8, [x25, #0x4be]
006870BA4  add      w23, w0, #1
006870BA8  cbnz     w8, #0x6870bc0
006870BAC  adrp     x0, #0x8f08000
006870BB0  ldr      x0, [x0, #0xe90]
006870BB4  bl       #0x382bd14 ; 
006870BB8  mov      w8, #1
006870BBC  strb     w8, [x25, #0x4be]
006870BC0  adrp     x8, #0x8f08000
006870BC4  ldr      x8, [x8, #0xe90]
006870BC8  ldr      x2, [x8]
006870BCC  ldrb     w8, [x2, #0x53]
006870BD0  tbnz     w8, #5, #0x6870bdc
006870BD4  str      w23, [x22, #0x18c]
006870BD8  b        #0x6870bec ; 
006870BDC  ldr      x8, [x2, #0x60]
006870BE0  mov      x0, x22
006870BE4  mov      w1, w23
006870BE8  blr      x8
006870BEC  ldrb     w8, [x26, #0xa4b]
006870BF0  cbnz     w8, #0x6870c08
006870BF4  adrp     x0, #0x8ee5000
006870BF8  ldr      x0, [x0, #0xb28]
006870BFC  bl       #0x382bd14 ; 
006870C00  mov      w8, #1
006870C04  strb     w8, [x26, #0xa4b]
006870C08  ldr      x1, [x27]
006870C0C  ldrb     w8, [x1, #0x53]
006870C10  tbnz     w8, #5, #0x6870c1c
006870C14  ldr      x0, [x19, #0x20]
006870C18  b        #0x6870c28 ; 
006870C1C  ldr      x8, [x1, #0x60]
006870C20  mov      x0, x19
006870C24  blr      x8
006870C28  cbz      x0, #0x6871260
006870C2C  mov      x1, xzr
006870C30  bl       #0x6a005a4 ; HotFix.BattleLogic.BattleWorldContext$$IsMultiPlayerBattle
006870C34  tbnz     w0, #0, #0x6870c84
006870C38  ldrb     w8, [x26, #0xa4b]
006870C3C  cbnz     w8, #0x6870c54
006870C40  adrp     x0, #0x8ee5000
006870C44  ldr      x0, [x0, #0xb28]
006870C48  bl       #0x382bd14 ; 
006870C4C  mov      w8, #1
006870C50  strb     w8, [x26, #0xa4b]
006870C54  ldr      x1, [x27]
006870C58  ldrb     w8, [x1, #0x53]
006870C5C  tbnz     w8, #5, #0x6870c68
006870C60  ldr      x0, [x19, #0x20]
006870C64  b        #0x6870c74 ; 
006870C68  ldr      x8, [x1, #0x60]
006870C6C  mov      x0, x19
006870C70  blr      x8
006870C74  cbz      x0, #0x6871260
006870C78  mov      w1, #4
006870C7C  mov      x2, xzr
006870C80  bl       #0x6a052e4 ; HotFix.BattleLogic.BattleWorldContext$$SetBattleFlag
006870C84  ldrb     w8, [x26, #0xa4b]
006870C88  ldr      x22, [x19, #0x80]
006870C8C  cbnz     w8, #0x6870ca4
006870C90  adrp     x0, #0x8ee5000
006870C94  ldr      x0, [x0, #0xb28]
006870C98  bl       #0x382bd14 ; 
006870C9C  mov      w8, #1
006870CA0  strb     w8, [x26, #0xa4b]
006870CA4  ldr      x1, [x27]
006870CA8  ldrb     w8, [x1, #0x53]
006870CAC  tbnz     w8, #5, #0x6870cb8
006870CB0  ldr      x23, [x19, #0x20]
006870CB4  b        #0x6870cc8 ; 
006870CB8  ldr      x8, [x1, #0x60]
006870CBC  mov      x0, x19
006870CC0  blr      x8
006870CC4  mov      x23, x0
006870CC8  cbz      x23, #0x6871260
006870CCC  ldrb     w8, [x29, #0xfc4]
006870CD0  cbnz     w8, #0x6870ce8
006870CD4  adrp     x0, #0x8f05000
006870CD8  ldr      x0, [x0, #0xfd8]
006870CDC  bl       #0x382bd14 ; 
006870CE0  mov      w8, #1
006870CE4  strb     w8, [x29, #0xfc4]
006870CE8  ldr      x1, [x28]
006870CEC  ldrb     w8, [x1, #0x53]
006870CF0  tbnz     w8, #5, #0x6870cfc
006870CF4  ldr      x0, [x23, #0x220]
006870CF8  b        #0x6870d08 ; 
006870CFC  ldr      x8, [x1, #0x60]
006870D00  mov      x0, x23
006870D04  blr      x8
006870D08  cbz      x0, #0x6871260
006870D0C  ldr      x8, [x0]
006870D10  ldr      x9, [x8, #0x518]
006870D14  ldr      x1, [x8, #0x520]
006870D18  blr      x9
006870D1C  cbz      x22, #0x6871260
006870D20  adrp     x25, #0x959b000
006870D24  ldrb     w8, [x25, #0xb9f]
006870D28  mov      w23, w0
006870D2C  cbnz     w8, #0x6870d44
006870D30  adrp     x0, #0x8f23000
006870D34  ldr      x0, [x0, #0xe90]
006870D38  bl       #0x382bd14 ; 
006870D3C  mov      w8, #1
006870D40  strb     w8, [x25, #0xb9f]
006870D44  adrp     x8, #0x8f23000
006870D48  ldr      x8, [x8, #0xe90]
006870D4C  ldr      x2, [x8]
006870D50  ldrb     w8, [x2, #0x53]
006870D54  tbnz     w8, #5, #0x6870d60
006870D58  str      w23, [x22, #0x40]
006870D5C  b        #0x6870d70 ; 
006870D60  ldr      x8, [x2, #0x60]
006870D64  mov      x0, x22
006870D68  mov      w1, w23
006870D6C  blr      x8
006870D70  ldrb     w8, [x26, #0xa4b]
006870D74  ldr      x22, [x19, #0x80]
006870D78  cbnz     w8, #0x6870d90
006870D7C  adrp     x0, #0x8ee5000
006870D80  ldr      x0, [x0, #0xb28]
006870D84  bl       #0x382bd14 ; 
006870D88  mov      w8, #1
006870D8C  strb     w8, [x26, #0xa4b]
006870D90  ldr      x1, [x27]
006870D94  ldrb     w8, [x1, #0x53]
006870D98  tbnz     w8, #5, #0x6870da4
006870D9C  ldr      x23, [x19, #0x20]
006870DA0  b        #0x6870db4 ; 
006870DA4  ldr      x8, [x1, #0x60]
006870DA8  mov      x0, x19
006870DAC  blr      x8
006870DB0  mov      x23, x0
006870DB4  cbz      x23, #0x6871260
006870DB8  ldrb     w8, [x29, #0xfc4]
006870DBC  cbnz     w8, #0x6870dd4
006870DC0  adrp     x0, #0x8f05000
006870DC4  ldr      x0, [x0, #0xfd8]
006870DC8  bl       #0x382bd14 ; 
006870DCC  mov      w8, #1
006870DD0  strb     w8, [x29, #0xfc4]
006870DD4  ldr      x1, [x28]
006870DD8  ldrb     w8, [x1, #0x53]
006870DDC  tbnz     w8, #5, #0x6870de8
006870DE0  ldr      x0, [x23, #0x220]
006870DE4  b        #0x6870df4 ; 
006870DE8  ldr      x8, [x1, #0x60]
006870DEC  mov      x0, x23
006870DF0  blr      x8
006870DF4  adrp     x28, #0x8f23000
006870DF8  ldr      x28, [x28, #0x140]
006870DFC  cbz      x0, #0x6871260
006870E00  ldr      x8, [x0]
006870E04  ldr      x9, [x8, #0x528]
006870E08  ldr      x1, [x8, #0x530]
006870E0C  blr      x9
006870E10  cbz      x22, #0x6871260
006870E14  adrp     x25, #0x959b000
006870E18  ldrb     w8, [x25, #0xba1]
006870E1C  mov      w23, w0
006870E20  cbnz     w8, #0x6870e38
006870E24  adrp     x0, #0x8f23000
006870E28  ldr      x0, [x0, #0xe70]
006870E2C  bl       #0x382bd14 ; 
006870E30  mov      w8, #1
006870E34  strb     w8, [x25, #0xba1]
006870E38  adrp     x8, #0x8f23000
006870E3C  ldr      x8, [x8, #0xe70]
006870E40  ldr      x2, [x8]
006870E44  ldrb     w8, [x2, #0x53]
006870E48  tbnz     w8, #5, #0x6870e54
006870E4C  str      w23, [x22, #0x38]
006870E50  b        #0x6870e64 ; 
006870E54  ldr      x8, [x2, #0x60]
006870E58  mov      x0, x22
006870E5C  mov      w1, w23
006870E60  blr      x8
006870E64  ldr      x1, [x28]
006870E68  ldr      x22, [x19, #0x80]
006870E6C  ldrb     w8, [x1, #0x53]
006870E70  tbnz     w8, #5, #0x6870e7c
006870E74  ldr      x0, [x19, #0x30]
006870E78  b        #0x6870e88 ; 
006870E7C  ldr      x8, [x1, #0x60]
006870E80  mov      x0, x19
006870E84  blr      x8
006870E88  cbz      x0, #0x6871260
006870E8C  adrp     x8, #0x8ee6000
006870E90  ldr      x8, [x8, #0xd8]
006870E94  ldr      x1, [x8]
006870E98  ldrb     w8, [x1, #0x53]
006870E9C  tbnz     w8, #5, #0x6870ea8
006870EA0  ldr      x23, [x0, #0x38]
006870EA4  b        #0x6870eb4 ; 
006870EA8  ldr      x8, [x1, #0x60]
006870EAC  blr      x8
006870EB0  mov      x23, x0
006870EB4  cbz      x23, #0x6871260
006870EB8  adrp     x25, #0x9591000
006870EBC  ldrb     w8, [x25, #0xa7f]
006870EC0  cbnz     w8, #0x6870ed8
006870EC4  adrp     x0, #0x8ee6000
006870EC8  ldr      x0, [x0, #0x2d8]
006870ECC  bl       #0x382bd14 ; 
006870ED0  mov      w8, #1
006870ED4  strb     w8, [x25, #0xa7f]
006870ED8  adrp     x8, #0x8ee6000
006870EDC  ldr      x8, [x8, #0x2d8]
006870EE0  ldr      x1, [x8]
006870EE4  ldrb     w8, [x1, #0x53]
006870EE8  tbnz     w8, #5, #0x6870ef4
006870EEC  ldr      x0, [x23, #0x178]
006870EF0  b        #0x6870f00 ; 
006870EF4  ldr      x8, [x1, #0x60]
006870EF8  mov      x0, x23
006870EFC  blr      x8
006870F00  cbz      x0, #0x6871260
006870F04  mov      x1, xzr
006870F08  bl       #0x6b3cf00 ; HotFix.Common.AttributeData$$GetAttack
006870F0C  cbz      x22, #0x6871260
006870F10  adrp     x25, #0x959b000
006870F14  ldrb     w8, [x25, #0xb9b]
006870F18  lsr      x23, x0, #0x10
006870F1C  cbnz     w8, #0x6870f34
006870F20  adrp     x0, #0x8f23000
006870F24  ldr      x0, [x0, #0xec0]
006870F28  bl       #0x382bd14 ; 
006870F2C  mov      w8, #1
006870F30  strb     w8, [x25, #0xb9b]
006870F34  adrp     x8, #0x8f23000
006870F38  ldr      x8, [x8, #0xec0]
006870F3C  ldr      x2, [x8]
006870F40  ldrb     w8, [x2, #0x53]
006870F44  tbnz     w8, #5, #0x6870f50
006870F48  str      w23, [x22, #0x4c]
006870F4C  b        #0x6870f60 ; 
006870F50  ldr      x8, [x2, #0x60]
006870F54  mov      x0, x22
006870F58  mov      w1, w23
006870F5C  blr      x8
006870F60  ldr      x1, [x28]
006870F64  ldr      x22, [x19, #0x80]
006870F68  ldrb     w8, [x1, #0x53]
006870F6C  tbnz     w8, #5, #0x6870f78
006870F70  ldr      x0, [x19, #0x30]
006870F74  b        #0x6870f84 ; 
006870F78  ldr      x8, [x1, #0x60]
006870F7C  mov      x0, x19
006870F80  blr      x8
006870F84  cbz      x0, #0x6871260
006870F88  ldr      x8, [x0]
006870F8C  ldr      x9, [x8, #0x498]
006870F90  ldr      x1, [x8, #0x4a0]
006870F94  blr      x9
006870F98  cbz      x22, #0x6871260
006870F9C  adrp     x25, #0x959b000
006870FA0  ldrb     w8, [x25, #0xb9d]
006870FA4  mov      w23, w0
006870FA8  cbnz     w8, #0x6870fc0
006870FAC  adrp     x0, #0x8f23000
006870FB0  ldr      x0, [x0, #0xed0]
006870FB4  bl       #0x382bd14 ; 
006870FB8  mov      w8, #1
006870FBC  strb     w8, [x25, #0xb9d]
006870FC0  adrp     x8, #0x8f23000
006870FC4  ldr      x8, [x8, #0xed0]
006870FC8  ldr      x2, [x8]
006870FCC  ldrb     w8, [x2, #0x53]
006870FD0  tbnz     w8, #5, #0x6870fdc
006870FD4  str      w23, [x22, #0x50]
006870FD8  b        #0x6870fec ; 
006870FDC  ldr      x8, [x2, #0x60]
006870FE0  mov      x0, x22
006870FE4  mov      w1, w23
006870FE8  blr      x8
006870FEC  ldr      x22, [x19, #0x80]
006870FF0  cbz      x22, #0x6871260
006870FF4  adrp     x23, #0x959b000
006870FF8  ldrb     w8, [x23, #0xba3]
006870FFC  cbnz     w8, #0x6871014
006871000  adrp     x0, #0x8f23000
006871004  ldr      x0, [x0, #0xf00]
006871008  bl       #0x382bd14 ; 
00687100C  mov      w8, #1
006871010  strb     w8, [x23, #0xba3]
006871014  adrp     x8, #0x8f23000
006871018  ldr      x8, [x8, #0xf00]
00687101C  ldr      x2, [x8]
006871020  ldrb     w8, [x2, #0x53]
006871024  tbnz     w8, #5, #0x6871030
006871028  strb     wzr, [x22, #0x6c]
00687102C  b        #0x6871040 ; 
006871030  ldr      x8, [x2, #0x60]
006871034  mov      x0, x22
006871038  mov      w1, wzr
00687103C  blr      x8
006871040  ldr      x22, [x19, #0x80]
006871044  cbz      x22, #0x6871260
006871048  ldr      w8, [sp, #0xc]
00687104C  str      w8, [x22, #0x10]
006871050  ldrb     w8, [x26, #0xa4b]
006871054  cbnz     w8, #0x687106c
006871058  adrp     x0, #0x8ee5000
00687105C  ldr      x0, [x0, #0xb28]
006871060  bl       #0x382bd14 ; 
006871064  mov      w8, #1
006871068  strb     w8, [x26, #0xa4b]
00687106C  ldr      x1, [x27]
006871070  ldrb     w8, [x1, #0x53]
006871074  tbnz     w8, #5, #0x6871080
006871078  ldr      x0, [x19, #0x20]
00687107C  b        #0x687108c ; 
006871080  ldr      x8, [x1, #0x60]
006871084  mov      x0, x19
006871088  blr      x8
00687108C  cbz      x0, #0x6871260
006871090  ldr      x1, [x28]
006871094  ldr      x23, [x0, #0x1d0]
006871098  ldrb     w8, [x1, #0x53]
00687109C  tbnz     w8, #5, #0x68710a8
0068710A0  ldr      x0, [x19, #0x30]
0068710A4  b        #0x68710b4 ; 
0068710A8  ldr      x8, [x1, #0x60]
0068710AC  mov      x0, x19
0068710B0  blr      x8
0068710B4  cbz      x0, #0x6871260
0068710B8  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
0068710BC  cbz      x23, #0x6871260
0068710C0  mov      w1, w0
0068710C4  mov      x0, x23
0068710C8  mov      x2, xzr
0068710CC  bl       #0x6a4802c ; HotFix.BattleLogic.WorldInitInfo$$GetPlayerInfoByPlayerID
0068710D0  cbz      x0, #0x6871260
0068710D4  adrp     x25, #0x9599000
0068710D8  ldrb     w8, [x25, #0x299]
0068710DC  mov      x23, x0
0068710E0  cbnz     w8, #0x68710f8
0068710E4  adrp     x0, #0x8f07000
0068710E8  ldr      x0, [x0, #0xfd8]
0068710EC  bl       #0x382bd14 ; 
0068710F0  mov      w8, #1
0068710F4  strb     w8, [x25, #0x299]
0068710F8  adrp     x8, #0x8f07000
0068710FC  ldr      x8, [x8, #0xfd8]
006871100  ldr      x1, [x8]
006871104  ldrb     w8, [x1, #0x53]
006871108  tbnz     w8, #5, #0x6871114
00687110C  ldr      x1, [x23, #0x20]
006871110  b        #0x6871124 ; 
006871114  ldr      x8, [x1, #0x60]
006871118  mov      x0, x23
00687111C  blr      x8
006871120  mov      x1, x0
006871124  adrp     x23, #0x8ee6000
006871128  ldr      x23, [x23, #0x3e0]
00687112C  str      x1, [x22, #0x78]!
006871130  mov      x0, x22
006871134  bl       #0x382bcb8 ; 
006871138  tbz      w21, #0, #0x68711c0
00687113C  ldrb     w8, [x26, #0xa4b]
006871140  cbnz     w8, #0x6871158
006871144  adrp     x0, #0x8ee5000
006871148  ldr      x0, [x0, #0xb28]
00687114C  bl       #0x382bd14 ; 
006871150  mov      w8, #1
006871154  strb     w8, [x26, #0xa4b]
006871158  ldr      x1, [x27]
00687115C  ldrb     w8, [x1, #0x53]
006871160  tbnz     w8, #5, #0x687116c
006871164  ldr      x21, [x19, #0x20]
006871168  b        #0x687117c ; 
00687116C  ldr      x8, [x1, #0x60]
006871170  mov      x0, x19
006871174  blr      x8
006871178  mov      x21, x0
00687117C  ldr      x1, [x28]
006871180  ldrb     w8, [x1, #0x53]
006871184  tbnz     w8, #5, #0x6871190
006871188  ldr      x0, [x19, #0x30]
00687118C  b        #0x687119c ; 
006871190  ldr      x8, [x1, #0x60]
006871194  mov      x0, x19
006871198  blr      x8
00687119C  cbz      x0, #0x6871260
0068711A0  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
0068711A4  cbz      x21, #0x6871260
0068711A8  ldr      x3, [x19, #0x80]
0068711AC  mov      w1, w0
0068711B0  mov      w2, #4
0068711B4  mov      x0, x21
0068711B8  mov      x4, xzr
0068711BC  bl       #0x6a0f95c ; HotFix.BattleLogic.BattleWorldContext$$DisPatchOpenViewEvent
0068711C0  ldrb     w8, [x26, #0xa4b]
0068711C4  cbnz     w8, #0x68711dc
0068711C8  adrp     x0, #0x8ee5000
0068711CC  ldr      x0, [x0, #0xb28]
0068711D0  bl       #0x382bd14 ; 
0068711D4  mov      w8, #1
0068711D8  strb     w8, [x26, #0xa4b]
0068711DC  ldr      x1, [x27]
0068711E0  ldrb     w8, [x1, #0x53]
0068711E4  tbnz     w8, #5, #0x68711f0
0068711E8  ldr      x19, [x19, #0x20]
0068711EC  b        #0x6871200 ; 
0068711F0  ldr      x8, [x1, #0x60]
0068711F4  mov      x0, x19
0068711F8  blr      x8
0068711FC  mov      x19, x0
006871200  cbz      x19, #0x6871260
006871204  ldrb     w8, [x24, #0xa90]
006871208  cbnz     w8, #0x6871220
00687120C  adrp     x0, #0x8ee6000
006871210  ldr      x0, [x0, #0x3e0]
006871214  bl       #0x382bd14 ; 
006871218  mov      w8, #1
00687121C  strb     w8, [x24, #0xa90]
006871220  ldr      x1, [x23]
006871224  ldrb     w8, [x1, #0x53]
006871228  tbnz     w8, #5, #0x6871234
00687122C  ldr      x0, [x19, #0x230]
006871230  b        #0x6871240 ; 
006871234  ldr      x8, [x1, #0x60]
006871238  mov      x0, x19
00687123C  blr      x8
006871240  cbz      x0, #0x6871260
006871244  adrp     x8, #0x8f08000
006871248  ldr      x8, [x8, #0xbc0]
00687124C  mov      x1, x20
006871250  ldr      x2, [x8]
006871254  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
006871258  mov      w0, #1
00687125C  b        #0x687074c ; 
006871260  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GroupSkillsByType
; RVA 0x686BEAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686BEAC  sub      sp, sp, #0x80
00686BEB0  stp      x29, x30, [sp, #0x20]
00686BEB4  stp      x28, x27, [sp, #0x30]
00686BEB8  stp      x26, x25, [sp, #0x40]
00686BEBC  stp      x24, x23, [sp, #0x50]
00686BEC0  stp      x22, x21, [sp, #0x60]
00686BEC4  stp      x20, x19, [sp, #0x70]
00686BEC8  adrp     x20, #0x959b000
00686BECC  adrp     x21, #0x8f24000
00686BED0  ldrb     w8, [x20, #0xa63]
00686BED4  ldr      x21, [x21, #0x140]
00686BED8  mov      x19, x0
00686BEDC  tbnz     w8, #0, #0x686bfb4
00686BEE0  adrp     x0, #0x8f24000
00686BEE4  ldr      x0, [x0, #0x148]
00686BEE8  bl       #0x382bd14 ; 
00686BEEC  adrp     x0, #0x8f24000
00686BEF0  ldr      x0, [x0, #0x150]
00686BEF4  bl       #0x382bd14 ; 
00686BEF8  adrp     x0, #0x8f24000
00686BEFC  ldr      x0, [x0, #0x158]
00686BF00  bl       #0x382bd14 ; 
00686BF04  adrp     x0, #0x8f24000
00686BF08  ldr      x0, [x0, #0x140]
00686BF0C  bl       #0x382bd14 ; 
00686BF10  adrp     x0, #0x8ebf000
00686BF14  ldr      x0, [x0, #0x4e8]
00686BF18  bl       #0x382bd14 ; 
00686BF1C  adrp     x0, #0x8f24000
00686BF20  ldr      x0, [x0, #0x160]
00686BF24  bl       #0x382bd14 ; 
00686BF28  adrp     x0, #0x8f24000
00686BF2C  ldr      x0, [x0, #0x168]
00686BF30  bl       #0x382bd14 ; 
00686BF34  adrp     x0, #0x8ebf000
00686BF38  ldr      x0, [x0, #0x4f0]
00686BF3C  bl       #0x382bd14 ; 
00686BF40  adrp     x0, #0x8f24000
00686BF44  ldr      x0, [x0, #0x170]
00686BF48  bl       #0x382bd14 ; 
00686BF4C  adrp     x0, #0x8f24000
00686BF50  ldr      x0, [x0, #0x178]
00686BF54  bl       #0x382bd14 ; 
00686BF58  adrp     x0, #0x8f24000
00686BF5C  ldr      x0, [x0, #0x180]
00686BF60  bl       #0x382bd14 ; 
00686BF64  adrp     x0, #0x8f24000
00686BF68  ldr      x0, [x0, #0x188]
00686BF6C  bl       #0x382bd14 ; 
00686BF70  adrp     x0, #0x8f24000
00686BF74  ldr      x0, [x0, #0x190]
00686BF78  bl       #0x382bd14 ; 
00686BF7C  adrp     x0, #0x8f09000
00686BF80  ldr      x0, [x0, #0xa08]
00686BF84  bl       #0x382bd14 ; 
00686BF88  adrp     x0, #0x8f24000
00686BF8C  ldr      x0, [x0, #0x50]
00686BF90  bl       #0x382bd14 ; 
00686BF94  adrp     x0, #0x8f24000
00686BF98  ldr      x0, [x0, #0x198]
00686BF9C  bl       #0x382bd14 ; 
00686BFA0  adrp     x0, #0x8f24000
00686BFA4  ldr      x0, [x0, #0x1a0]
00686BFA8  bl       #0x382bd14 ; 
00686BFAC  mov      w8, #1
00686BFB0  strb     w8, [x20, #0xa63]
00686BFB4  ldr      x1, [x21]
00686BFB8  ldrb     w8, [x1, #0x53]
00686BFBC  tbnz     w8, #5, #0x686c004
00686BFC0  adrp     x20, #0x9591000
00686BFC4  ldrb     w8, [x20, #0xa4b]
00686BFC8  stp      xzr, xzr, [sp, #8]
00686BFCC  str      xzr, [sp, #0x18]
00686BFD0  cbnz     w8, #0x686bfe8
00686BFD4  adrp     x0, #0x8ee5000
00686BFD8  ldr      x0, [x0, #0xb28]
00686BFDC  bl       #0x382bd14 ; 
00686BFE0  mov      w8, #1
00686BFE4  strb     w8, [x20, #0xa4b]
00686BFE8  adrp     x8, #0x8ee5000
00686BFEC  ldr      x8, [x8, #0xb28]
00686BFF0  ldr      x1, [x8]
00686BFF4  ldrb     w8, [x1, #0x53]
00686BFF8  tbnz     w8, #5, #0x686c02c
00686BFFC  ldr      x20, [x19, #0x20]
00686C000  b        #0x686c03c ; 
00686C004  ldr      x2, [x1, #0x60]
00686C008  mov      x0, x19
00686C00C  ldp      x20, x19, [sp, #0x70]
00686C010  ldp      x22, x21, [sp, #0x60]
00686C014  ldp      x24, x23, [sp, #0x50]
00686C018  ldp      x26, x25, [sp, #0x40]
00686C01C  ldp      x28, x27, [sp, #0x30]
00686C020  ldp      x29, x30, [sp, #0x20]
00686C024  add      sp, sp, #0x80
00686C028  br       x2
00686C02C  ldr      x8, [x1, #0x60]
00686C030  mov      x0, x19
00686C034  blr      x8
00686C038  mov      x20, x0
00686C03C  cbz      x20, #0x686c450
00686C040  adrp     x21, #0x9598000
00686C044  ldrb     w8, [x21, #0xfcc]
00686C048  cbnz     w8, #0x686c060
00686C04C  adrp     x0, #0x8f06000
00686C050  ldr      x0, [x0, #0x470]
00686C054  bl       #0x382bd14 ; 
00686C058  mov      w8, #1
00686C05C  strb     w8, [x21, #0xfcc]
00686C060  adrp     x8, #0x8f06000
00686C064  ldr      x8, [x8, #0x470]
00686C068  ldr      x1, [x8]
00686C06C  ldrb     w8, [x1, #0x53]
00686C070  tbnz     w8, #5, #0x686c07c
00686C074  ldr      x0, [x20, #0x200]
00686C078  b        #0x686c088 ; 
00686C07C  ldr      x8, [x1, #0x60]
00686C080  mov      x0, x20
00686C084  blr      x8
00686C088  cbz      x0, #0x686c450
00686C08C  mov      x1, xzr
00686C090  bl       #0x64e1b68 ; LocalModels.LocalModelManager$$GetSkill_MainElements
00686C094  cbz      x0, #0x686c450
00686C098  adrp     x10, #0x8f24000
00686C09C  ldr      x8, [x0]
00686C0A0  ldr      x10, [x10, #0x160]
00686C0A4  mov      x20, x0
00686C0A8  ldrh     w9, [x8, #0x12e]
00686C0AC  ldr      x1, [x10]
00686C0B0  cbz      x9, #0x686c0d4
00686C0B4  ldr      x10, [x8, #0xb0]
00686C0B8  add      x10, x10, #8
00686C0BC  ldur     x11, [x10, #-8]
00686C0C0  cmp      x11, x1
00686C0C4  b.eq     #0x686c0e4
00686C0C8  subs     x9, x9, #1
00686C0CC  add      x10, x10, #0x10
00686C0D0  b.ne     #0x686c0bc
00686C0D4  mov      x0, x20
00686C0D8  mov      w2, wzr
00686C0DC  bl       #0x3a7e710 ; 
00686C0E0  b        #0x686c0f0 ; 
00686C0E4  ldrsw    x9, [x10]
00686C0E8  add      x8, x8, x9, lsl #4
00686C0EC  add      x0, x8, #0x138
00686C0F0  ldp      x8, x1, [x0]
00686C0F4  mov      x0, x20
00686C0F8  blr      x8
00686C0FC  mov      x20, x0
00686C100  cbz      x0, #0x686c454
00686C104  adrp     x27, #0x8ebf000
00686C108  adrp     x21, #0x8ef9000
00686C10C  adrp     x22, #0x8f00000
00686C110  ldr      x27, [x27, #0x4f0]
00686C114  ldr      x21, [x21, #0xf30]
00686C118  ldr      x22, [x22, #0xd98]
00686C11C  adrp     x29, #0x9598000
00686C120  adrp     x28, #0x9598000
00686C124  ldr      x8, [x20]
00686C128  ldr      x1, [x27]
00686C12C  ldrh     w9, [x8, #0x12e]
00686C130  cbz      x9, #0x686c154
00686C134  ldr      x10, [x8, #0xb0]
00686C138  add      x10, x10, #8
00686C13C  ldur     x11, [x10, #-8]
00686C140  cmp      x11, x1
00686C144  b.eq     #0x686c164
00686C148  subs     x9, x9, #1
00686C14C  add      x10, x10, #0x10
00686C150  b.ne     #0x686c13c
00686C154  mov      x0, x20
00686C158  mov      w2, wzr
00686C15C  bl       #0x3a7e710 ; 
00686C160  b        #0x686c170 ; 
00686C164  ldrsw    x9, [x10]
00686C168  add      x8, x8, x9, lsl #4
00686C16C  add      x0, x8, #0x138
00686C170  ldp      x8, x1, [x0]
00686C174  mov      x0, x20
00686C178  blr      x8
00686C17C  tbz      w0, #0, #0x686c304
00686C180  ldr      x8, [x20]
00686C184  adrp     x10, #0x8f24000
00686C188  ldrh     w9, [x8, #0x12e]
00686C18C  ldr      x10, [x10, #0x168]
00686C190  ldr      x1, [x10]
00686C194  cbz      x9, #0x686c1b8
00686C198  ldr      x10, [x8, #0xb0]
00686C19C  add      x10, x10, #8
00686C1A0  ldur     x11, [x10, #-8]
00686C1A4  cmp      x11, x1
00686C1A8  b.eq     #0x686c1c8
00686C1AC  subs     x9, x9, #1
00686C1B0  add      x10, x10, #0x10
00686C1B4  b.ne     #0x686c1a0
00686C1B8  mov      x0, x20
00686C1BC  mov      w2, wzr
00686C1C0  bl       #0x3a7e710 ; 
00686C1C4  b        #0x686c1d4 ; 
00686C1C8  ldrsw    x9, [x10]
00686C1CC  add      x8, x8, x9, lsl #4
00686C1D0  add      x0, x8, #0x138
00686C1D4  ldp      x8, x1, [x0]
00686C1D8  mov      x0, x20
00686C1DC  blr      x8
00686C1E0  mov      x23, x0
00686C1E4  cbz      x0, #0x686c440
00686C1E8  ldrb     w8, [x29, #0x35e]
00686C1EC  cbnz     w8, #0x686c200
00686C1F0  mov      x0, x21
00686C1F4  bl       #0x382bd14 ; 
00686C1F8  mov      w8, #1
00686C1FC  strb     w8, [x29, #0x35e]
00686C200  ldr      x1, [x21]
00686C204  ldrb     w8, [x1, #0x53]
00686C208  tbnz     w8, #5, #0x686c214
00686C20C  ldr      w24, [x23, #0x68]
00686C210  b        #0x686c224 ; 
00686C214  ldr      x8, [x1, #0x60]
00686C218  mov      x0, x23
00686C21C  blr      x8
00686C220  mov      w24, w0
00686C224  ldr      x0, [x19, #0xb8]
00686C228  cbz      x0, #0x686c444
00686C22C  adrp     x8, #0x8f24000
00686C230  ldr      x8, [x8, #0x178]
00686C234  ldr      x2, [x8]
00686C238  mov      w1, w24
00686C23C  bl       #0x5225d20 ; Rock.Collections.OrderedDictionary<int, object>$$ContainsKey
00686C240  tbnz     w0, #0, #0x686c28c
00686C244  adrp     x8, #0x8f24000
00686C248  ldr      x25, [x19, #0xb8]
00686C24C  ldr      x8, [x8, #0x1a0]
00686C250  ldr      x0, [x8]
00686C254  bl       #0x382bfa0 ; 
00686C258  adrp     x8, #0x8f24000
00686C25C  ldr      x8, [x8, #0x198]
00686C260  mov      x26, x0
00686C264  ldr      x1, [x8]
00686C268  bl       #0x524bf90 ; Rock.Collections.OrderedHashSet<int>$$.ctor
00686C26C  cbz      x25, #0x686c44c
00686C270  adrp     x8, #0x8f24000
00686C274  ldr      x8, [x8, #0x190]
00686C278  ldr      x3, [x8]
00686C27C  mov      x0, x25
00686C280  mov      w1, w24
00686C284  mov      x2, x26
00686C288  bl       #0x5225af4 ; Rock.Collections.OrderedDictionary<int, object>$$set_Item
00686C28C  ldr      x0, [x19, #0xb8]
00686C290  cbz      x0, #0x686c438
00686C294  adrp     x8, #0x8f24000
00686C298  ldr      x8, [x8, #0x180]
00686C29C  ldr      x2, [x8]
00686C2A0  mov      w1, w24
00686C2A4  bl       #0x5225a74 ; Rock.Collections.OrderedDictionary<int, object>$$get_Item
00686C2A8  ldrb     w8, [x28, #0xde3]
00686C2AC  mov      x24, x0
00686C2B0  cbnz     w8, #0x686c2c4
00686C2B4  mov      x0, x22
00686C2B8  bl       #0x382bd14 ; 
00686C2BC  mov      w8, #1
00686C2C0  strb     w8, [x28, #0xde3]
00686C2C4  ldr      x1, [x22]
00686C2C8  ldrb     w8, [x1, #0x53]
00686C2CC  tbnz     w8, #5, #0x686c2d8
00686C2D0  ldr      w1, [x23, #0x20]
00686C2D4  b        #0x686c2e8 ; 
00686C2D8  ldr      x8, [x1, #0x60]
00686C2DC  mov      x0, x23
00686C2E0  blr      x8
00686C2E4  mov      w1, w0
00686C2E8  cbz      x24, #0x686c43c
00686C2EC  adrp     x8, #0x8f24000
00686C2F0  ldr      x8, [x8, #0x50]
00686C2F4  ldr      x2, [x8]
00686C2F8  mov      x0, x24
00686C2FC  bl       #0x524e0bc ; Rock.Collections.OrderedHashSet<int>$$Add
00686C300  b        #0x686c124 ; 
00686C304  mov      x22, xzr
00686C308  mov      w21, #5
00686C30C  cbz      x20, #0x686c370
00686C310  adrp     x10, #0x8ebf000
00686C314  ldr      x8, [x20]
00686C318  ldr      x10, [x10, #0x4e8]
00686C31C  ldrh     w9, [x8, #0x12e]
00686C320  ldr      x1, [x10]
00686C324  cbz      x9, #0x686c348
00686C328  ldr      x10, [x8, #0xb0]
00686C32C  add      x10, x10, #8
00686C330  ldur     x11, [x10, #-8]
00686C334  cmp      x11, x1
00686C338  b.eq     #0x686c358
00686C33C  subs     x9, x9, #1
00686C340  add      x10, x10, #0x10
00686C344  b.ne     #0x686c330
00686C348  mov      x0, x20
00686C34C  mov      w2, wzr
00686C350  bl       #0x3a7e710 ; 
00686C354  b        #0x686c364 ; 
00686C358  ldrsw    x9, [x10]
00686C35C  add      x8, x8, x9, lsl #4
00686C360  add      x0, x8, #0x138
00686C364  ldp      x8, x1, [x0]
00686C368  mov      x0, x20
00686C36C  blr      x8
00686C370  cbnz     x22, #0x686c458
00686C374  cmp      w21, #5
00686C378  b.eq     #0x686c380
00686C37C  cbnz     w21, #0x686c418
00686C380  ldr      x0, [x19, #0xb8]
00686C384  cbz      x0, #0x686c450
00686C388  adrp     x8, #0x8f24000
00686C38C  ldr      x8, [x8, #0x188]
00686C390  ldr      x1, [x8]
00686C394  bl       #0x52257d4 ; Rock.Collections.OrderedDictionary<int, object>$$get_Keys
00686C398  cbz      x0, #0x686c450
00686C39C  adrp     x8, #0x8f24000
00686C3A0  ldr      x8, [x8, #0x170]
00686C3A4  ldr      x1, [x8]
00686C3A8  add      x8, sp, #8
00686C3AC  bl       #0x4a93f30 ; Rock.Collections.OrderedDictionary.KeyCollection<int, object>$$GetEnumerator
00686C3B0  adrp     x20, #0x8f24000
00686C3B4  adrp     x21, #0x8f09000
00686C3B8  ldr      x20, [x20, #0x150]
00686C3BC  ldr      x21, [x21, #0xa08]
00686C3C0  ldr      x1, [x20]
00686C3C4  add      x0, sp, #8
00686C3C8  bl       #0x6154758 ; Rock.Collections.OrderedDictionary.KeyCollection.Enumerator<int, object>$$MoveNext
00686C3CC  tbz      w0, #0, #0x686c3ec
00686C3D0  ldr      x0, [x19, #0xc0]
00686C3D4  cbz      x0, #0x686c448
00686C3D8  ldr      w1, [sp, #0x18]
00686C3DC  ldr      x3, [x21]
00686C3E0  mov      w2, wzr
00686C3E4  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
00686C3E8  b        #0x686c3c0 ; 
00686C3EC  adrp     x8, #0x8f24000
00686C3F0  ldr      x8, [x8, #0x148]
00686C3F4  add      x0, sp, #8
00686C3F8  ldr      x1, [x8]
00686C3FC  bl       #0x6154754 ; Rock.Collections.OrderedDictionary.KeyCollection.Enumerator<int, object>$$Dispose
00686C400  mov      x0, x19
00686C404  bl       #0x6871264 ; HotFix.BattleLogic.HeroComponentRandomSkill$$LogSkillGroupsByType
00686C408  mov      x0, x19
00686C40C  bl       #0x6871424 ; HotFix.BattleLogic.HeroComponentRandomSkill$$LogLearnedSkillCountsByType
00686C410  mov      x0, x19
00686C414  bl       #0x68715a8 ; HotFix.BattleLogic.HeroComponentRandomSkill$$LogAllWeightInfo
00686C418  ldp      x20, x19, [sp, #0x70]
00686C41C  ldp      x22, x21, [sp, #0x60]
00686C420  ldp      x24, x23, [sp, #0x50]
00686C424  ldp      x26, x25, [sp, #0x40]
00686C428  ldp      x28, x27, [sp, #0x30]
00686C42C  ldp      x29, x30, [sp, #0x20]
00686C430  add      sp, sp, #0x80
00686C434  ret      
00686C438  bl       #0x382bfb8 ; 
00686C43C  bl       #0x382bfb8 ; 
00686C440  bl       #0x382bfb8 ; 
00686C444  bl       #0x382bfb8 ; 
00686C448  bl       #0x382bfb8 ; 
00686C44C  bl       #0x382bfb8 ; 
00686C450  bl       #0x382bfb8 ; 
00686C454  bl       #0x382bfb8 ; 
00686C458  mov      x0, x22
00686C45C  bl       #0x382bfb0 ; 
00686C460  b        #0x686c504 ; 
00686C464  b        #0x686c504 ; 
00686C468  b        #0x686c470 ; 
00686C46C  b        #0x686c470 ; 
00686C470  mov      x21, x0
00686C474  cmp      w1, #1
00686C478  b.ne     #0x686c4ac
00686C47C  mov      x0, x21
00686C480  bl       #0x89eda50 ; 
00686C484  ldr      x20, [x0]
00686C488  bl       #0x89eda60 ; 
00686C48C  adrp     x8, #0x8f24000
00686C490  ldr      x8, [x8, #0x148]
00686C494  add      x0, sp, #8
00686C498  ldr      x1, [x8]
00686C49C  bl       #0x6154754 ; Rock.Collections.OrderedDictionary.KeyCollection.Enumerator<int, object>$$Dispose
00686C4A0  cbz      x20, #0x686c400
00686C4A4  mov      x0, x20
00686C4A8  bl       #0x382bfb0 ; 
00686C4AC  mov      x20, xzr
00686C4B0  b        #0x686c4b8 ; 
00686C4B4  mov      x21, x0
00686C4B8  adrp     x8, #0x8f24000
00686C4BC  ldr      x8, [x8, #0x148]
00686C4C0  ldr      x1, [x8]
00686C4C4  add      x0, sp, #8
00686C4C8  bl       #0x6154754 ; Rock.Collections.OrderedDictionary.KeyCollection.Enumerator<int, object>$$Dispose
00686C4CC  cbz      x20, #0x686c5a0
00686C4D0  mov      x0, x20
00686C4D4  bl       #0x382bfb0 ; 
00686C4D8  b        #0x686c504 ; 
00686C4DC  b        #0x686c504 ; 
00686C4E0  b        #0x686c504 ; 
00686C4E4  b        #0x686c504 ; 
00686C4E8  b        #0x686c504 ; 
00686C4EC  b        #0x686c504 ; 
00686C4F0  b        #0x686c504 ; 
00686C4F4  b        #0x686c504 ; 
00686C4F8  b        #0x686c504 ; 
00686C4FC  b        #0x686c504 ; 
00686C500  b        #0x686c504 ; 
00686C504  mov      x21, x0
00686C508  cmp      w1, #1
00686C50C  b.ne     #0x686c52c
00686C510  mov      x0, x21
00686C514  bl       #0x89eda50 ; 
00686C518  ldr      x22, [x0]
00686C51C  bl       #0x89eda60 ; 
00686C520  mov      w21, wzr
00686C524  cbnz     x20, #0x686c310
00686C528  b        #0x686c370 ; 
00686C52C  mov      x22, xzr
00686C530  b        #0x686c538 ; 
00686C534  mov      x21, x0
00686C538  cbz      x20, #0x686c59c
00686C53C  adrp     x10, #0x8ebf000
00686C540  ldr      x8, [x20]
00686C544  ldr      x10, [x10, #0x4e8]
00686C548  ldrh     w9, [x8, #0x12e]
00686C54C  ldr      x1, [x10]
00686C550  cbz      x9, #0x686c574
00686C554  ldr      x10, [x8, #0xb0]
00686C558  add      x10, x10, #8
00686C55C  ldur     x11, [x10, #-8]
00686C560  cmp      x11, x1
00686C564  b.eq     #0x686c584
00686C568  subs     x9, x9, #1
00686C56C  add      x10, x10, #0x10
00686C570  b.ne     #0x686c55c
00686C574  mov      x0, x20
00686C578  mov      w2, wzr
00686C57C  bl       #0x3a7e710 ; 
00686C580  b        #0x686c590 ; 
00686C584  ldrsw    x9, [x10]
00686C588  add      x8, x8, x9, lsl #4
00686C58C  add      x0, x8, #0x138
00686C590  ldp      x8, x1, [x0]
00686C594  mov      x0, x20
00686C598  blr      x8
00686C59C  cbnz     x22, #0x686c5a8
00686C5A0  mov      x0, x21
00686C5A4  bl       #0x3b56bfc ; 
00686C5A8  mov      x0, x22
00686C5AC  bl       #0x382bfb0 ; 
00686C5B0  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$UpdateLearnedSkillCount
; RVA 0x686AEF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686AEF4  str      x30, [sp, #-0x30]!
00686AEF8  stp      x22, x21, [sp, #0x10]
00686AEFC  stp      x20, x19, [sp, #0x20]
00686AF00  adrp     x21, #0x959b000
00686AF04  adrp     x22, #0x8f24000
00686AF08  ldrb     w8, [x21, #0xa64]
00686AF0C  ldr      x22, [x22, #0x70]
00686AF10  mov      w20, w1
00686AF14  mov      x19, x0
00686AF18  tbnz     w8, #0, #0x686af54
00686AF1C  adrp     x0, #0x8f24000
00686AF20  ldr      x0, [x0, #0x70]
00686AF24  bl       #0x382bd14 ; 
00686AF28  adrp     x0, #0x8f0a000
00686AF2C  ldr      x0, [x0, #0x9b8]
00686AF30  bl       #0x382bd14 ; 
00686AF34  adrp     x0, #0x8f09000
00686AF38  ldr      x0, [x0, #0xa20]
00686AF3C  bl       #0x382bd14 ; 
00686AF40  adrp     x0, #0x8f09000
00686AF44  ldr      x0, [x0, #0xa08]
00686AF48  bl       #0x382bd14 ; 
00686AF4C  mov      w8, #1
00686AF50  strb     w8, [x21, #0xa64]
00686AF54  ldr      x2, [x22]
00686AF58  ldrb     w8, [x2, #0x53]
00686AF5C  tbnz     w8, #5, #0x686afa8
00686AF60  ldr      x0, [x19, #0xc0]
00686AF64  cbz      x0, #0x686aff4
00686AF68  adrp     x8, #0x8f0a000
00686AF6C  ldr      x8, [x8, #0x9b8]
00686AF70  mov      w1, w20
00686AF74  ldr      x2, [x8]
00686AF78  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
00686AF7C  ldr      x21, [x19, #0xc0]
00686AF80  cbz      x21, #0x686aff4
00686AF84  tbz      w0, #0, #0x686afc4
00686AF88  adrp     x8, #0x8f09000
00686AF8C  ldr      x8, [x8, #0xa20]
00686AF90  mov      x0, x21
00686AF94  mov      w1, w20
00686AF98  ldr      x2, [x8]
00686AF9C  bl       #0x5221c50 ; Rock.Collections.OrderedDictionary<int, int>$$get_Item
00686AFA0  add      w2, w0, #1
00686AFA4  b        #0x686afc8 ; 
00686AFA8  ldr      x3, [x2, #0x60]
00686AFAC  mov      x0, x19
00686AFB0  mov      w1, w20
00686AFB4  ldp      x20, x19, [sp, #0x20]
00686AFB8  ldp      x22, x21, [sp, #0x10]
00686AFBC  ldr      x30, [sp], #0x30
00686AFC0  br       x3
00686AFC4  mov      w2, #1
00686AFC8  adrp     x8, #0x8f09000
00686AFCC  ldr      x8, [x8, #0xa08]
00686AFD0  mov      x0, x21
00686AFD4  mov      w1, w20
00686AFD8  ldr      x3, [x8]
00686AFDC  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
00686AFE0  mov      x0, x19
00686AFE4  ldp      x20, x19, [sp, #0x20]
00686AFE8  ldp      x22, x21, [sp, #0x10]
00686AFEC  ldr      x30, [sp], #0x30
00686AFF0  b        #0x6871424 ; HotFix.BattleLogic.HeroComponentRandomSkill$$LogLearnedSkillCountsByType
00686AFF4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$DecreaseLearnedSkillCount
; RVA 0x6869D14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869D14  str      x30, [sp, #-0x30]!
006869D18  stp      x22, x21, [sp, #0x10]
006869D1C  stp      x20, x19, [sp, #0x20]
006869D20  adrp     x21, #0x959b000
006869D24  adrp     x22, #0x8f23000
006869D28  ldrb     w8, [x21, #0xa65]
006869D2C  ldr      x22, [x22, #0xff8]
006869D30  mov      w20, w1
006869D34  mov      x19, x0
006869D38  tbnz     w8, #0, #0x6869d74
006869D3C  adrp     x0, #0x8f23000
006869D40  ldr      x0, [x0, #0xff8]
006869D44  bl       #0x382bd14 ; 
006869D48  adrp     x0, #0x8f0a000
006869D4C  ldr      x0, [x0, #0x9b8]
006869D50  bl       #0x382bd14 ; 
006869D54  adrp     x0, #0x8f09000
006869D58  ldr      x0, [x0, #0xa20]
006869D5C  bl       #0x382bd14 ; 
006869D60  adrp     x0, #0x8f09000
006869D64  ldr      x0, [x0, #0xa08]
006869D68  bl       #0x382bd14 ; 
006869D6C  mov      w8, #1
006869D70  strb     w8, [x21, #0xa65]
006869D74  ldr      x2, [x22]
006869D78  ldrb     w8, [x2, #0x53]
006869D7C  tbnz     w8, #5, #0x6869dc8
006869D80  ldr      x0, [x19, #0xc0]
006869D84  cbz      x0, #0x6869e14
006869D88  adrp     x8, #0x8f0a000
006869D8C  ldr      x8, [x8, #0x9b8]
006869D90  mov      w1, w20
006869D94  ldr      x2, [x8]
006869D98  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
006869D9C  ldr      x21, [x19, #0xc0]
006869DA0  cbz      x21, #0x6869e14
006869DA4  tbz      w0, #0, #0x6869de4
006869DA8  adrp     x8, #0x8f09000
006869DAC  ldr      x8, [x8, #0xa20]
006869DB0  mov      x0, x21
006869DB4  mov      w1, w20
006869DB8  ldr      x2, [x8]
006869DBC  bl       #0x5221c50 ; Rock.Collections.OrderedDictionary<int, int>$$get_Item
006869DC0  sub      w2, w0, #1
006869DC4  b        #0x6869de8 ; 
006869DC8  ldr      x3, [x2, #0x60]
006869DCC  mov      x0, x19
006869DD0  mov      w1, w20
006869DD4  ldp      x20, x19, [sp, #0x20]
006869DD8  ldp      x22, x21, [sp, #0x10]
006869DDC  ldr      x30, [sp], #0x30
006869DE0  br       x3
006869DE4  mov      w2, wzr
006869DE8  adrp     x8, #0x8f09000
006869DEC  ldr      x8, [x8, #0xa08]
006869DF0  mov      x0, x21
006869DF4  mov      w1, w20
006869DF8  ldr      x3, [x8]
006869DFC  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
006869E00  mov      x0, x19
006869E04  ldp      x20, x19, [sp, #0x20]
006869E08  ldp      x22, x21, [sp, #0x10]
006869E0C  ldr      x30, [sp], #0x30
006869E10  b        #0x6871424 ; HotFix.BattleLogic.HeroComponentRandomSkill$$LogLearnedSkillCountsByType
006869E14  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillCountByType
; RVA 0x6871660; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871660  str      x30, [sp, #-0x30]!
006871664  stp      x22, x21, [sp, #0x10]
006871668  stp      x20, x19, [sp, #0x20]
00687166C  adrp     x21, #0x959b000
006871670  adrp     x22, #0x8f24000
006871674  ldrb     w8, [x21, #0xa66]
006871678  ldr      x22, [x22, #0x378]
00687167C  mov      w19, w1
006871680  mov      x20, x0
006871684  tbnz     w8, #0, #0x68716b4
006871688  adrp     x0, #0x8f24000
00687168C  ldr      x0, [x0, #0x378]
006871690  bl       #0x382bd14 ; 
006871694  adrp     x0, #0x8f0a000
006871698  ldr      x0, [x0, #0x9b8]
00687169C  bl       #0x382bd14 ; 
0068716A0  adrp     x0, #0x8f09000
0068716A4  ldr      x0, [x0, #0xa20]
0068716A8  bl       #0x382bd14 ; 
0068716AC  mov      w8, #1
0068716B0  strb     w8, [x21, #0xa66]
0068716B4  ldr      x2, [x22]
0068716B8  ldrb     w8, [x2, #0x53]
0068716BC  tbnz     w8, #5, #0x6871708
0068716C0  ldr      x0, [x20, #0xc0]
0068716C4  cbz      x0, #0x6871738
0068716C8  adrp     x8, #0x8f0a000
0068716CC  ldr      x8, [x8, #0x9b8]
0068716D0  mov      w1, w19
0068716D4  ldr      x2, [x8]
0068716D8  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
0068716DC  tbz      w0, #0, #0x6871724
0068716E0  ldr      x0, [x20, #0xc0]
0068716E4  cbz      x0, #0x6871738
0068716E8  adrp     x8, #0x8f09000
0068716EC  ldr      x8, [x8, #0xa20]
0068716F0  mov      w1, w19
0068716F4  ldp      x20, x19, [sp, #0x20]
0068716F8  ldp      x22, x21, [sp, #0x10]
0068716FC  ldr      x2, [x8]
006871700  ldr      x30, [sp], #0x30
006871704  b        #0x5221c50 ; Rock.Collections.OrderedDictionary<int, int>$$get_Item
006871708  ldr      x3, [x2, #0x60]
00687170C  mov      x0, x20
006871710  mov      w1, w19
006871714  ldp      x20, x19, [sp, #0x20]
006871718  ldp      x22, x21, [sp, #0x10]
00687171C  ldr      x30, [sp], #0x30
006871720  br       x3
006871724  ldp      x20, x19, [sp, #0x20]
006871728  ldp      x22, x21, [sp, #0x10]
00687172C  mov      w0, wzr
006871730  ldr      x30, [sp], #0x30
006871734  ret      
006871738  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillIdsByType
; RVA 0x687173C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687173C  str      x30, [sp, #-0x30]!
006871740  stp      x22, x21, [sp, #0x10]
006871744  stp      x20, x19, [sp, #0x20]
006871748  adrp     x21, #0x959b000
00687174C  adrp     x22, #0x8f24000
006871750  ldrb     w8, [x21, #0xa67]
006871754  ldr      x22, [x22, #0x380]
006871758  mov      w19, w1
00687175C  mov      x20, x0
006871760  tbnz     w8, #0, #0x68717a8
006871764  adrp     x0, #0x8ee3000
006871768  ldr      x0, [x0, #0xf48]
00687176C  bl       #0x382bd14 ; 
006871770  adrp     x0, #0x8f24000
006871774  ldr      x0, [x0, #0x380]
006871778  bl       #0x382bd14 ; 
00687177C  adrp     x0, #0x8ec1000
006871780  ldr      x0, [x0, #0x240]
006871784  bl       #0x382bd14 ; 
006871788  adrp     x0, #0x8f24000
00687178C  ldr      x0, [x0, #0x178]
006871790  bl       #0x382bd14 ; 
006871794  adrp     x0, #0x8f24000
006871798  ldr      x0, [x0, #0x180]
00687179C  bl       #0x382bd14 ; 
0068717A0  mov      w8, #1
0068717A4  strb     w8, [x21, #0xa67]
0068717A8  ldr      x2, [x22]
0068717AC  ldrb     w8, [x2, #0x53]
0068717B0  tbnz     w8, #5, #0x687180c
0068717B4  ldr      x0, [x20, #0xb8]
0068717B8  cbz      x0, #0x6871848
0068717BC  adrp     x8, #0x8f24000
0068717C0  ldr      x8, [x8, #0x178]
0068717C4  mov      w1, w19
0068717C8  ldr      x2, [x8]
0068717CC  bl       #0x5225d20 ; Rock.Collections.OrderedDictionary<int, object>$$ContainsKey
0068717D0  tbz      w0, #0, #0x6871828
0068717D4  ldr      x0, [x20, #0xb8]
0068717D8  cbz      x0, #0x6871848
0068717DC  adrp     x8, #0x8f24000
0068717E0  ldr      x8, [x8, #0x180]
0068717E4  mov      w1, w19
0068717E8  ldr      x2, [x8]
0068717EC  bl       #0x5225a74 ; Rock.Collections.OrderedDictionary<int, object>$$get_Item
0068717F0  adrp     x8, #0x8ee3000
0068717F4  ldr      x8, [x8, #0xf48]
0068717F8  ldp      x20, x19, [sp, #0x20]
0068717FC  ldp      x22, x21, [sp, #0x10]
006871800  ldr      x1, [x8]
006871804  ldr      x30, [sp], #0x30
006871808  b        #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
00687180C  ldr      x3, [x2, #0x60]
006871810  mov      x0, x20
006871814  mov      w1, w19
006871818  ldp      x20, x19, [sp, #0x20]
00687181C  ldp      x22, x21, [sp, #0x10]
006871820  ldr      x30, [sp], #0x30
006871824  br       x3
006871828  adrp     x8, #0x8ec1000
00687182C  ldr      x8, [x8, #0x240]
006871830  ldp      x20, x19, [sp, #0x20]
006871834  ldp      x22, x21, [sp, #0x10]
006871838  mov      w1, wzr
00687183C  ldr      x0, [x8]
006871840  ldr      x30, [sp], #0x30
006871844  b        #0x382bdfc ; 
006871848  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$AdjustWeightsForSkillGroup
; RVA 0x686A17C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686A17C  stp      x30, x23, [sp, #-0x30]!
00686A180  stp      x22, x21, [sp, #0x10]
00686A184  stp      x20, x19, [sp, #0x20]
00686A188  adrp     x22, #0x959b000
00686A18C  adrp     x23, #0x8f24000
00686A190  ldrb     w8, [x22, #0xa68]
00686A194  ldr      x23, [x23, #0x38]
00686A198  mov      x19, x2
00686A19C  mov      w20, w1
00686A1A0  mov      x21, x0
00686A1A4  tbnz     w8, #0, #0x686a1bc
00686A1A8  adrp     x0, #0x8f24000
00686A1AC  ldr      x0, [x0, #0x38]
00686A1B0  bl       #0x382bd14 ; 
00686A1B4  mov      w8, #1
00686A1B8  strb     w8, [x22, #0xa68]
00686A1BC  ldr      x3, [x23]
00686A1C0  ldrb     w8, [x3, #0x53]
00686A1C4  tbnz     w8, #5, #0x686a1d8
00686A1C8  ldp      x20, x19, [sp, #0x20]
00686A1CC  ldp      x22, x21, [sp, #0x10]
00686A1D0  ldp      x30, x23, [sp], #0x30
00686A1D4  ret      
00686A1D8  ldr      x4, [x3, #0x60]
00686A1DC  mov      x0, x21
00686A1E0  mov      w1, w20
00686A1E4  mov      x2, x19
00686A1E8  ldp      x20, x19, [sp, #0x20]
00686A1EC  ldp      x22, x21, [sp, #0x10]
00686A1F0  ldp      x30, x23, [sp], #0x30
00686A1F4  br       x4

; HotFix.BattleLogic.HeroComponentRandomSkill$$RecalculateAllWeight
; RVA 0x686C5B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C5B4  stp      x30, x21, [sp, #-0x20]!
00686C5B8  stp      x20, x19, [sp, #0x10]
00686C5BC  adrp     x20, #0x959b000
00686C5C0  adrp     x21, #0x8f24000
00686C5C4  ldrb     w8, [x20, #0xa69]
00686C5C8  ldr      x21, [x21, #0x1a8]
00686C5CC  mov      x19, x0
00686C5D0  tbnz     w8, #0, #0x686c5e8
00686C5D4  adrp     x0, #0x8f24000
00686C5D8  ldr      x0, [x0, #0x1a8]
00686C5DC  bl       #0x382bd14 ; 
00686C5E0  mov      w8, #1
00686C5E4  strb     w8, [x20, #0xa69]
00686C5E8  ldr      x1, [x21]
00686C5EC  ldrb     w8, [x1, #0x53]
00686C5F0  tbnz     w8, #5, #0x686c638
00686C5F4  ldr      x19, [x19, #0x88]
00686C5F8  cbz      x19, #0x686c6b0
00686C5FC  adrp     x20, #0x959b000
00686C600  ldrb     w8, [x20, #0xbb3]
00686C604  cbnz     w8, #0x686c61c
00686C608  adrp     x0, #0x8f24000
00686C60C  ldr      x0, [x0, #0x1b0]
00686C610  bl       #0x382bd14 ; 
00686C614  mov      w8, #1
00686C618  strb     w8, [x20, #0xbb3]
00686C61C  adrp     x8, #0x8f24000
00686C620  ldr      x8, [x8, #0x1b0]
00686C624  ldr      x1, [x8]
00686C628  ldrb     w8, [x1, #0x53]
00686C62C  tbnz     w8, #5, #0x686c64c
00686C630  ldr      x19, [x19, #0x48]
00686C634  b        #0x686c65c ; 
00686C638  ldr      x2, [x1, #0x60]
00686C63C  mov      x0, x19
00686C640  ldp      x20, x19, [sp, #0x10]
00686C644  ldp      x30, x21, [sp], #0x20
00686C648  br       x2
00686C64C  ldr      x8, [x1, #0x60]
00686C650  mov      x0, x19
00686C654  blr      x8
00686C658  mov      x19, x0
00686C65C  cbz      x19, #0x686c6b0
00686C660  ldr      x8, [x19, #0x18]
00686C664  subs     w20, w8, #1
00686C668  b.lt     #0x686c6a4
00686C66C  cbz      w8, #0x686c6a0
00686C670  mov      w21, wzr
00686C674  add      x8, x19, w21, sxtw #3
00686C678  ldr      x0, [x8, #0x20]
00686C67C  cbz      x0, #0x686c6b0
00686C680  mov      x1, xzr
00686C684  bl       #0x6633750 ; HotFix.BattleLogic.WeightRandom$$RecalculateAllWeight
00686C688  cmp      w20, w21
00686C68C  b.eq     #0x686c6a4
00686C690  ldr      w8, [x19, #0x18]
00686C694  add      w21, w21, #1
00686C698  cmp      w21, w8
00686C69C  b.lo     #0x686c674
00686C6A0  bl       #0x382bfc0 ; 
00686C6A4  ldp      x20, x19, [sp, #0x10]
00686C6A8  ldp      x30, x21, [sp], #0x20
00686C6AC  ret      
00686C6B0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$GetDeltaWeightPercent
; RVA 0x6869E9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869E9C  str      x30, [sp, #-0x30]!
006869EA0  stp      x22, x21, [sp, #0x10]
006869EA4  stp      x20, x19, [sp, #0x20]
006869EA8  adrp     x21, #0x959b000
006869EAC  adrp     x22, #0x8f24000
006869EB0  ldrb     w8, [x21, #0xa6a]
006869EB4  ldr      x22, [x22, #8]
006869EB8  mov      w19, w1
006869EBC  mov      x20, x0
006869EC0  tbnz     w8, #0, #0x6869f14
006869EC4  adrp     x0, #0x8f24000
006869EC8  ldr      x0, [x0, #8]
006869ECC  bl       #0x382bd14 ; 
006869ED0  adrp     x0, #0x8ebf000
006869ED4  ldr      x0, [x0, #0xba0]
006869ED8  bl       #0x382bd14 ; 
006869EDC  adrp     x0, #0x8ee1000
006869EE0  ldr      x0, [x0, #0x6e8]
006869EE4  bl       #0x382bd14 ; 
006869EE8  adrp     x0, #0x8f24000
006869EEC  ldr      x0, [x0, #0x10]
006869EF0  bl       #0x382bd14 ; 
006869EF4  adrp     x0, #0x8f24000
006869EF8  ldr      x0, [x0, #0x18]
006869EFC  bl       #0x382bd14 ; 
006869F00  adrp     x0, #0x8f24000
006869F04  ldr      x0, [x0, #0x20]
006869F08  bl       #0x382bd14 ; 
006869F0C  mov      w8, #1
006869F10  strb     w8, [x21, #0xa6a]
006869F14  ldr      x2, [x22]
006869F18  ldrb     w8, [x2, #0x53]
006869F1C  tbnz     w8, #5, #0x6869f5c
006869F20  adrp     x21, #0x9591000
006869F24  ldrb     w8, [x21, #0xa4b]
006869F28  cbnz     w8, #0x6869f40
006869F2C  adrp     x0, #0x8ee5000
006869F30  ldr      x0, [x0, #0xb28]
006869F34  bl       #0x382bd14 ; 
006869F38  mov      w8, #1
006869F3C  strb     w8, [x21, #0xa4b]
006869F40  adrp     x8, #0x8ee5000
006869F44  ldr      x8, [x8, #0xb28]
006869F48  ldr      x1, [x8]
006869F4C  ldrb     w8, [x1, #0x53]
006869F50  tbnz     w8, #5, #0x6869f78
006869F54  ldr      x21, [x20, #0x20]
006869F58  b        #0x6869f88 ; 
006869F5C  ldr      x3, [x2, #0x60]
006869F60  mov      x0, x20
006869F64  mov      w1, w19
006869F68  ldp      x20, x19, [sp, #0x20]
006869F6C  ldp      x22, x21, [sp, #0x10]
006869F70  ldr      x30, [sp], #0x30
006869F74  br       x3
006869F78  ldr      x8, [x1, #0x60]
006869F7C  mov      x0, x20
006869F80  blr      x8
006869F84  mov      x21, x0
006869F88  cbz      x21, #0x686a178
006869F8C  adrp     x22, #0x9598000
006869F90  ldrb     w8, [x22, #0xfcc]
006869F94  cbnz     w8, #0x6869fac
006869F98  adrp     x0, #0x8f06000
006869F9C  ldr      x0, [x0, #0x470]
006869FA0  bl       #0x382bd14 ; 
006869FA4  mov      w8, #1
006869FA8  strb     w8, [x22, #0xfcc]
006869FAC  adrp     x8, #0x8f06000
006869FB0  ldr      x8, [x8, #0x470]
006869FB4  ldr      x1, [x8]
006869FB8  ldrb     w8, [x1, #0x53]
006869FBC  tbnz     w8, #5, #0x6869fc8
006869FC0  ldr      x0, [x21, #0x200]
006869FC4  b        #0x6869fd4 ; 
006869FC8  ldr      x8, [x1, #0x60]
006869FCC  mov      x0, x21
006869FD0  blr      x8
006869FD4  cbz      x0, #0x686a178
006869FD8  mov      w1, w19
006869FDC  mov      x2, xzr
006869FE0  bl       #0x64db89c ; LocalModels.LocalModelManager$$GetSkill_SkillTypeWeight
006869FE4  cbz      x0, #0x686a038
006869FE8  mov      x21, x0
006869FEC  mov      x0, x20
006869FF0  mov      w1, w19
006869FF4  bl       #0x6871660 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillCountByType
006869FF8  adrp     x20, #0x959b000
006869FFC  ldrb     w8, [x20, #0xbb4]
00686A000  mov      w19, w0
00686A004  cbnz     w8, #0x686a01c
00686A008  adrp     x0, #0x8f24000
00686A00C  ldr      x0, [x0, #0x28]
00686A010  bl       #0x382bd14 ; 
00686A014  mov      w8, #1
00686A018  strb     w8, [x20, #0xbb4]
00686A01C  adrp     x8, #0x8f24000
00686A020  ldr      x8, [x8, #0x28]
00686A024  ldr      x1, [x8]
00686A028  ldrb     w8, [x1, #0x53]
00686A02C  tbnz     w8, #5, #0x686a0bc
00686A030  ldr      w0, [x21, #0x24]
00686A034  b        #0x686a0c8 ; 
00686A038  adrp     x8, #0x8ebf000
00686A03C  ldr      x8, [x8, #0xba0]
00686A040  add      x1, sp, #0xc
00686A044  str      w19, [sp, #0xc]
00686A048  ldr      x0, [x8]
00686A04C  bl       #0x382be94 ; 
00686A050  adrp     x8, #0x8f24000
00686A054  ldr      x8, [x8, #0x18]
00686A058  mov      x1, x0
00686A05C  mov      x2, xzr
00686A060  ldr      x8, [x8]
00686A064  mov      x0, x8
00686A068  bl       #0x79d140c ; System.String$$Format
00686A06C  adrp     x8, #0x8ee1000
00686A070  ldr      x8, [x8, #0x6e8]
00686A074  mov      x19, x0
00686A078  ldr      x8, [x8]
00686A07C  ldr      w9, [x8, #0xe0]
00686A080  cbnz     w9, #0x686a08c
00686A084  mov      x0, x8
00686A088  bl       #0x382be8c ; 
00686A08C  adrp     x8, #0x8f24000
00686A090  adrp     x9, #0x8f24000
00686A094  ldr      x8, [x8, #0x10]
00686A098  ldr      x9, [x9, #0x20]
00686A09C  mov      w3, #0x85
00686A0A0  mov      x0, x19
00686A0A4  ldr      x1, [x8]
00686A0A8  ldr      x2, [x9]
00686A0AC  mov      x4, xzr
00686A0B0  bl       #0x7997754 ; Logger$$LogError
00686A0B4  mov      x0, xzr
00686A0B8  b        #0x686a168 ; 
00686A0BC  ldr      x8, [x1, #0x60]
00686A0C0  mov      x0, x21
00686A0C4  blr      x8
00686A0C8  mov      x9, #0xd70b
00686A0CC  movk     x9, #0x70a3, lsl #16
00686A0D0  movk     x9, #0xa3d, lsl #32
00686A0D4  lsl      x8, x0, #0x20
00686A0D8  movk     x9, #0xa3d7, lsl #48
00686A0DC  adrp     x22, #0x959b000
00686A0E0  smulh    x8, x8, x9
00686A0E4  ldrb     w9, [x22, #0xbb5]
00686A0E8  add      x8, x8, x0, lsl #32
00686A0EC  asr      x10, x8, #0x16
00686A0F0  add      x20, x10, x8, lsr #63
00686A0F4  sxtw     x19, w19
00686A0F8  cbnz     w9, #0x686a110
00686A0FC  adrp     x0, #0x8f24000
00686A100  ldr      x0, [x0, #0x30]
00686A104  bl       #0x382bd14 ; 
00686A108  mov      w8, #1
00686A10C  strb     w8, [x22, #0xbb5]
00686A110  adrp     x8, #0x8f24000
00686A114  ldr      x8, [x8, #0x30]
00686A118  mul      x19, x20, x19
00686A11C  ldr      x1, [x8]
00686A120  ldrb     w8, [x1, #0x53]
00686A124  tbnz     w8, #5, #0x686a130
00686A128  ldr      w0, [x21, #0x28]
00686A12C  b        #0x686a13c ; 
00686A130  ldr      x8, [x1, #0x60]
00686A134  mov      x0, x21
00686A138  blr      x8
00686A13C  mov      x9, #0xd70b
00686A140  movk     x9, #0x70a3, lsl #16
00686A144  movk     x9, #0xa3d, lsl #32
00686A148  lsl      x8, x0, #0x20
00686A14C  movk     x9, #0xa3d7, lsl #48
00686A150  smulh    x8, x8, x9
00686A154  add      x8, x8, x0, lsl #32
00686A158  asr      x9, x8, #0x16
00686A15C  add      x8, x9, x8, lsr #63
00686A160  cmp      x19, x8
00686A164  csel     x0, x19, x8, lt
00686A168  ldp      x20, x19, [sp, #0x20]
00686A16C  ldp      x22, x21, [sp, #0x10]
00686A170  ldr      x30, [sp], #0x30
00686A174  ret      
00686A178  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$LogSkillGroupsByType
; RVA 0x6871264; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871264  sub      sp, sp, #0x50
006871268  stp      x30, x21, [sp, #0x30]
00687126C  stp      x20, x19, [sp, #0x40]
006871270  adrp     x20, #0x959b000
006871274  adrp     x21, #0x8f24000
006871278  ldrb     w8, [x20, #0xa6b]
00687127C  ldr      x21, [x21, #0x330]
006871280  mov      x19, x0
006871284  tbnz     w8, #0, #0x68712fc
006871288  adrp     x0, #0x8f24000
00687128C  ldr      x0, [x0, #0x338]
006871290  bl       #0x382bd14 ; 
006871294  adrp     x0, #0x8f24000
006871298  ldr      x0, [x0, #0x340]
00687129C  bl       #0x382bd14 ; 
0068712A0  adrp     x0, #0x8f24000
0068712A4  ldr      x0, [x0, #0x348]
0068712A8  bl       #0x382bd14 ; 
0068712AC  adrp     x0, #0x8f24000
0068712B0  ldr      x0, [x0, #0x330]
0068712B4  bl       #0x382bd14 ; 
0068712B8  adrp     x0, #0x8f24000
0068712BC  ldr      x0, [x0, #0x350]
0068712C0  bl       #0x382bd14 ; 
0068712C4  adrp     x0, #0x8f24000
0068712C8  ldr      x0, [x0, #0x358]
0068712CC  bl       #0x382bd14 ; 
0068712D0  adrp     x0, #0x8f24000
0068712D4  ldr      x0, [x0, #0x360]
0068712D8  bl       #0x382bd14 ; 
0068712DC  adrp     x0, #0x8f09000
0068712E0  ldr      x0, [x0, #0xa98]
0068712E4  bl       #0x382bd14 ; 
0068712E8  adrp     x0, #0x8ec8000
0068712EC  ldr      x0, [x0, #0xf08]
0068712F0  bl       #0x382bd14 ; 
0068712F4  mov      w8, #1
0068712F8  strb     w8, [x20, #0xa6b]
0068712FC  ldr      x1, [x21]
006871300  ldrb     w8, [x1, #0x53]
006871304  tbnz     w8, #5, #0x687136c
006871308  movi     v0.2d, #0000000000000000
00687130C  str      xzr, [sp, #0x20]
006871310  stp      q0, q0, [sp]
006871314  ldr      x0, [x19, #0xb8]
006871318  cbz      x0, #0x68713a8
00687131C  adrp     x8, #0x8f24000
006871320  ldr      x8, [x8, #0x360]
006871324  ldr      x1, [x8]
006871328  mov      x8, sp
00687132C  bl       #0x5226020 ; Rock.Collections.OrderedDictionary<int, object>$$GetEnumerator
006871330  adrp     x19, #0x8f24000
006871334  adrp     x20, #0x8ec8000
006871338  adrp     x21, #0x8f09000
00687133C  ldr      x19, [x19, #0x340]
006871340  ldr      x20, [x20, #0xf08]
006871344  ldr      x21, [x21, #0xa98]
006871348  ldr      x1, [x19]
00687134C  mov      x0, sp
006871350  bl       #0x615364c ; Rock.Collections.OrderedDictionary.Enumerator<int, object>$$MoveNext
006871354  tbz      w0, #0, #0x6871384
006871358  ldr      x1, [sp, #0x18]
00687135C  ldr      x0, [x20]
006871360  ldr      x2, [x21]
006871364  bl       #0x4702f28 ; System.String$$Join<int>
006871368  b        #0x6871348 ; 
00687136C  ldr      x2, [x1, #0x60]
006871370  mov      x0, x19
006871374  ldp      x20, x19, [sp, #0x40]
006871378  ldp      x30, x21, [sp, #0x30]
00687137C  add      sp, sp, #0x50
006871380  br       x2
006871384  adrp     x8, #0x8f24000
006871388  ldr      x8, [x8, #0x338]
00687138C  mov      x0, sp
006871390  ldr      x1, [x8]
006871394  bl       #0x6153790 ; Rock.Collections.OrderedDictionary.Enumerator<int, object>$$Dispose
006871398  ldp      x20, x19, [sp, #0x40]
00687139C  ldp      x30, x21, [sp, #0x30]
0068713A0  add      sp, sp, #0x50
0068713A4  ret      
0068713A8  bl       #0x382bfb8 ; 
0068713AC  b        #0x68713b0 ; 
0068713B0  mov      x20, x0
0068713B4  cmp      w1, #1
0068713B8  b.ne     #0x68713ec
0068713BC  mov      x0, x20
0068713C0  bl       #0x89eda50 ; 
0068713C4  ldr      x19, [x0]
0068713C8  bl       #0x89eda60 ; 
0068713CC  adrp     x8, #0x8f24000
0068713D0  ldr      x8, [x8, #0x338]
0068713D4  mov      x0, sp
0068713D8  ldr      x1, [x8]
0068713DC  bl       #0x6153790 ; Rock.Collections.OrderedDictionary.Enumerator<int, object>$$Dispose
0068713E0  cbz      x19, #0x6871398
0068713E4  mov      x0, x19
0068713E8  bl       #0x382bfb0 ; 
0068713EC  mov      x19, xzr
0068713F0  b        #0x68713f8 ; 
0068713F4  mov      x20, x0
0068713F8  adrp     x8, #0x8f24000
0068713FC  ldr      x8, [x8, #0x338]
006871400  ldr      x1, [x8]
006871404  mov      x0, sp
006871408  bl       #0x6153790 ; Rock.Collections.OrderedDictionary.Enumerator<int, object>$$Dispose
00687140C  cbnz     x19, #0x6871418
006871410  mov      x0, x20
006871414  bl       #0x3b56bfc ; 
006871418  mov      x0, x19
00687141C  bl       #0x382bfb0 ; 
006871420  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$LogLearnedSkillCountsByType
; RVA 0x6871424; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871424  sub      sp, sp, #0x60
006871428  stp      x30, x21, [sp, #0x40]
00687142C  stp      x20, x19, [sp, #0x50]
006871430  adrp     x20, #0x959b000
006871434  adrp     x21, #0x8f24000
006871438  ldrb     w8, [x20, #0xa6c]
00687143C  ldr      x21, [x21, #0x368]
006871440  mov      x19, x0
006871444  tbnz     w8, #0, #0x68714a4
006871448  adrp     x0, #0x8ee6000
00687144C  ldr      x0, [x0, #0xed8]
006871450  bl       #0x382bd14 ; 
006871454  adrp     x0, #0x8ee6000
006871458  ldr      x0, [x0, #0xee0]
00687145C  bl       #0x382bd14 ; 
006871460  adrp     x0, #0x8ee6000
006871464  ldr      x0, [x0, #0xee8]
006871468  bl       #0x382bd14 ; 
00687146C  adrp     x0, #0x8f24000
006871470  ldr      x0, [x0, #0x368]
006871474  bl       #0x382bd14 ; 
006871478  adrp     x0, #0x8ee6000
00687147C  ldr      x0, [x0, #0xf00]
006871480  bl       #0x382bd14 ; 
006871484  adrp     x0, #0x8ee6000
006871488  ldr      x0, [x0, #0xf08]
00687148C  bl       #0x382bd14 ; 
006871490  adrp     x0, #0x8ee6000
006871494  ldr      x0, [x0, #0xf10]
006871498  bl       #0x382bd14 ; 
00687149C  mov      w8, #1
0068714A0  strb     w8, [x20, #0xa6c]
0068714A4  ldr      x1, [x21]
0068714A8  ldrb     w8, [x1, #0x53]
0068714AC  tbnz     w8, #5, #0x6871518
0068714B0  movi     v0.2d, #0000000000000000
0068714B4  stp      q0, q0, [sp, #0x20]
0068714B8  ldr      x0, [x19, #0xc0]
0068714BC  cbz      x0, #0x6871530
0068714C0  adrp     x8, #0x8ee6000
0068714C4  ldr      x8, [x8, #0xf10]
0068714C8  ldr      x1, [x8]
0068714CC  mov      x8, sp
0068714D0  bl       #0x52221a0 ; Rock.Collections.OrderedDictionary<int, int>$$GetEnumerator
0068714D4  ldp      q0, q1, [sp]
0068714D8  adrp     x19, #0x8ee6000
0068714DC  stp      q0, q1, [sp, #0x20]
0068714E0  ldr      x19, [x19, #0xee0]
0068714E4  ldr      x1, [x19]
0068714E8  add      x0, sp, #0x20
0068714EC  bl       #0x614f0cc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$MoveNext
0068714F0  tbnz     w0, #0, #0x68714e4
0068714F4  adrp     x8, #0x8ee6000
0068714F8  ldr      x8, [x8, #0xed8]
0068714FC  add      x0, sp, #0x20
006871500  ldr      x1, [x8]
006871504  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
006871508  ldp      x20, x19, [sp, #0x50]
00687150C  ldp      x30, x21, [sp, #0x40]
006871510  add      sp, sp, #0x60
006871514  ret      
006871518  ldr      x2, [x1, #0x60]
00687151C  mov      x0, x19
006871520  ldp      x20, x19, [sp, #0x50]
006871524  ldp      x30, x21, [sp, #0x40]
006871528  add      sp, sp, #0x60
00687152C  br       x2
006871530  bl       #0x382bfb8 ; 
006871534  cmp      w1, #1
006871538  mov      x20, x0
00687153C  b.ne     #0x6871570
006871540  mov      x0, x20
006871544  bl       #0x89eda50 ; 
006871548  ldr      x19, [x0]
00687154C  bl       #0x89eda60 ; 
006871550  adrp     x8, #0x8ee6000
006871554  ldr      x8, [x8, #0xed8]
006871558  add      x0, sp, #0x20
00687155C  ldr      x1, [x8]
006871560  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
006871564  cbz      x19, #0x6871508
006871568  mov      x0, x19
00687156C  bl       #0x382bfb0 ; 
006871570  mov      x19, xzr
006871574  b        #0x687157c ; 
006871578  mov      x20, x0
00687157C  adrp     x8, #0x8ee6000
006871580  ldr      x8, [x8, #0xed8]
006871584  ldr      x1, [x8]
006871588  add      x0, sp, #0x20
00687158C  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
006871590  cbnz     x19, #0x687159c
006871594  mov      x0, x20
006871598  bl       #0x3b56bfc ; 
00687159C  mov      x0, x19
0068715A0  bl       #0x382bfb0 ; 
0068715A4  bl       #0x3442448 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$LogAllWeightInfo
; RVA 0x68715A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068715A8  stp      x30, x21, [sp, #-0x20]!
0068715AC  stp      x20, x19, [sp, #0x10]
0068715B0  adrp     x20, #0x959b000
0068715B4  adrp     x21, #0x8f24000
0068715B8  ldrb     w8, [x20, #0xa6d]
0068715BC  ldr      x21, [x21, #0x370]
0068715C0  mov      x19, x0
0068715C4  tbnz     w8, #0, #0x68715dc
0068715C8  adrp     x0, #0x8f24000
0068715CC  ldr      x0, [x0, #0x370]
0068715D0  bl       #0x382bd14 ; 
0068715D4  mov      w8, #1
0068715D8  strb     w8, [x20, #0xa6d]
0068715DC  ldr      x1, [x21]
0068715E0  ldrb     w8, [x1, #0x53]
0068715E4  tbnz     w8, #5, #0x687162c
0068715E8  ldr      x19, [x19, #0x88]
0068715EC  cbz      x19, #0x687165c
0068715F0  adrp     x20, #0x959b000
0068715F4  ldrb     w8, [x20, #0xbb3]
0068715F8  cbnz     w8, #0x6871610
0068715FC  adrp     x0, #0x8f24000
006871600  ldr      x0, [x0, #0x1b0]
006871604  bl       #0x382bd14 ; 
006871608  mov      w8, #1
00687160C  strb     w8, [x20, #0xbb3]
006871610  adrp     x8, #0x8f24000
006871614  ldr      x8, [x8, #0x1b0]
006871618  ldr      x1, [x8]
00687161C  ldrb     w8, [x1, #0x53]
006871620  tbnz     w8, #5, #0x6871640
006871624  ldr      x0, [x19, #0x48]
006871628  b        #0x687164c ; 
00687162C  ldr      x2, [x1, #0x60]
006871630  mov      x0, x19
006871634  ldp      x20, x19, [sp, #0x10]
006871638  ldp      x30, x21, [sp], #0x20
00687163C  br       x2
006871640  ldr      x8, [x1, #0x60]
006871644  mov      x0, x19
006871648  blr      x8
00687164C  cbz      x0, #0x687165c
006871650  ldp      x20, x19, [sp, #0x10]
006871654  ldp      x30, x21, [sp], #0x20
006871658  ret      
00687165C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$.ctor
; RVA 0x687184C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687184C  stp      x29, x30, [sp, #-0x60]!
006871850  stp      x28, x27, [sp, #0x10]
006871854  stp      x26, x25, [sp, #0x20]
006871858  stp      x24, x23, [sp, #0x30]
00687185C  stp      x22, x21, [sp, #0x40]
006871860  stp      x20, x19, [sp, #0x50]
006871864  adrp     x20, #0x959b000
006871868  adrp     x21, #0x8f24000
00687186C  ldrb     w8, [x20, #0xa6e]
006871870  ldr      x21, [x21, #0x388]
006871874  mov      x19, x0
006871878  tbnz     w8, #0, #0x6871938
00687187C  adrp     x0, #0x8ee3000
006871880  ldr      x0, [x0, #0xfb0]
006871884  bl       #0x382bd14 ; 
006871888  adrp     x0, #0x8ee3000
00687188C  ldr      x0, [x0, #0xfa8]
006871890  bl       #0x382bd14 ; 
006871894  adrp     x0, #0x8f24000
006871898  ldr      x0, [x0, #0x388]
00687189C  bl       #0x382bd14 ; 
0068718A0  adrp     x0, #0x8ec1000
0068718A4  ldr      x0, [x0, #0x240]
0068718A8  bl       #0x382bd14 ; 
0068718AC  adrp     x0, #0x8ec2000
0068718B0  ldr      x0, [x0, #0x2b8]
0068718B4  bl       #0x382bd14 ; 
0068718B8  adrp     x0, #0x8ec2000
0068718BC  ldr      x0, [x0, #0x2d0]
0068718C0  bl       #0x382bd14 ; 
0068718C4  adrp     x0, #0x8f0a000
0068718C8  ldr      x0, [x0, #0xbd8]
0068718CC  bl       #0x382bd14 ; 
0068718D0  adrp     x0, #0x8f24000
0068718D4  ldr      x0, [x0, #0x390]
0068718D8  bl       #0x382bd14 ; 
0068718DC  adrp     x0, #0x8f24000
0068718E0  ldr      x0, [x0, #0x398]
0068718E4  bl       #0x382bd14 ; 
0068718E8  adrp     x0, #0x8f24000
0068718EC  ldr      x0, [x0, #0x3a0]
0068718F0  bl       #0x382bd14 ; 
0068718F4  adrp     x0, #0x8f09000
0068718F8  ldr      x0, [x0, #0xaf0]
0068718FC  bl       #0x382bd14 ; 
006871900  adrp     x0, #0x8f24000
006871904  ldr      x0, [x0, #0x3a8]
006871908  bl       #0x382bd14 ; 
00687190C  adrp     x0, #0x8f24000
006871910  ldr      x0, [x0, #0x198]
006871914  bl       #0x382bd14 ; 
006871918  adrp     x0, #0x8f24000
00687191C  ldr      x0, [x0, #0x1a0]
006871920  bl       #0x382bd14 ; 
006871924  adrp     x0, #0x8f24000
006871928  ldr      x0, [x0, #0x3b0]
00687192C  bl       #0x382bd14 ; 
006871930  mov      w8, #1
006871934  strb     w8, [x20, #0xa6e]
006871938  ldr      x1, [x21]
00687193C  ldrb     w8, [x1, #0x53]
006871940  tbnz     w8, #5, #0x6871b40
006871944  adrp     x8, #0x8ee3000
006871948  ldr      x8, [x8, #0xfa8]
00687194C  adrp     x20, #0x8ee3000
006871950  adrp     x21, #0x8f24000
006871954  adrp     x22, #0x8f24000
006871958  adrp     x23, #0x8f24000
00687195C  adrp     x24, #0x8f24000
006871960  adrp     x28, #0x8ec2000
006871964  adrp     x27, #0x8ec2000
006871968  adrp     x29, #0x8f24000
00687196C  adrp     x26, #0x8ec1000
006871970  adrp     x25, #0x8f24000
006871974  ldr      x20, [x20, #0xfb0]
006871978  ldr      x21, [x21, #0x3a8]
00687197C  ldr      x22, [x22, #0x390]
006871980  ldr      x23, [x23, #0x1a0]
006871984  ldr      x24, [x24, #0x198]
006871988  ldr      x28, [x28, #0x2d0]
00687198C  ldr      x27, [x27, #0x2b8]
006871990  ldr      x29, [x29, #0x3b0]
006871994  ldr      x26, [x26, #0x240]
006871998  ldr      x25, [x25, #0x3a0]
00687199C  ldr      x0, [x8]
0068719A0  bl       #0x382bfa0 ; 
0068719A4  ldr      x1, [x20]
0068719A8  mov      x20, x0
0068719AC  bl       #0x5e2737c ; System.Collections.Generic.Dictionary<int, int>$$.ctor
0068719B0  mov      x0, x19
0068719B4  str      x20, [x0, #0x40]!
0068719B8  mov      x1, x20
0068719BC  bl       #0x382bcb8 ; 
0068719C0  mov      x0, xzr
0068719C4  bl       #0x416d554 ; Rock.Collections.Custom.OrderedDictionaryIntComparer$$get_Default
0068719C8  ldr      x8, [x21]
0068719CC  mov      x20, x0
0068719D0  mov      x0, x8
0068719D4  bl       #0x382bfa0 ; 
0068719D8  ldr      x2, [x22]
0068719DC  mov      x1, x20
0068719E0  mov      x21, x0
0068719E4  bl       #0x521d090 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$.ctor
0068719E8  mov      x0, x19
0068719EC  str      x21, [x0, #0x48]!
0068719F0  mov      x1, x21
0068719F4  bl       #0x382bcb8 ; 
0068719F8  ldr      x0, [x23]
0068719FC  bl       #0x382bfa0 ; 
006871A00  ldr      x1, [x24]
006871A04  mov      x20, x0
006871A08  bl       #0x524bf90 ; Rock.Collections.OrderedHashSet<int>$$.ctor
006871A0C  mov      x0, x19
006871A10  str      x20, [x0, #0x50]!
006871A14  mov      x1, x20
006871A18  bl       #0x382bcb8 ; 
006871A1C  ldr      x0, [x28]
006871A20  bl       #0x382bfa0 ; 
006871A24  ldr      x1, [x27]
006871A28  mov      x20, x0
006871A2C  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
006871A30  mov      x0, x19
006871A34  str      x20, [x0, #0x58]!
006871A38  mov      x1, x20
006871A3C  bl       #0x382bcb8 ; 
006871A40  ldr      x0, [x29]
006871A44  bl       #0x382bfa0 ; 
006871A48  mov      x20, x0
006871A4C  bl       #0x6867dbc ; HotFix.BattleLogic.RandomSkillResult$$.ctor
006871A50  mov      x0, x19
006871A54  str      x20, [x0, #0x80]!
006871A58  mov      x1, x20
006871A5C  bl       #0x382bcb8 ; 
006871A60  ldr      x0, [x28]
006871A64  bl       #0x382bfa0 ; 
006871A68  ldr      x1, [x27]
006871A6C  mov      x20, x0
006871A70  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
006871A74  mov      x0, x19
006871A78  str      x20, [x0, #0xa0]!
006871A7C  mov      x1, x20
006871A80  bl       #0x382bcb8 ; 
006871A84  ldr      x0, [x26]
006871A88  mov      w1, #4
006871A8C  bl       #0x382bdfc ; 
006871A90  mov      x1, x0
006871A94  mov      x0, x19
006871A98  str      x1, [x0, #0xa8]!
006871A9C  bl       #0x382bcb8 ; 
006871AA0  ldr      x0, [x26]
006871AA4  mov      w1, #4
006871AA8  bl       #0x382bdfc ; 
006871AAC  mov      x1, x0
006871AB0  mov      x0, x19
006871AB4  str      x1, [x0, #0xb0]!
006871AB8  bl       #0x382bcb8 ; 
006871ABC  ldr      x0, [x25]
006871AC0  bl       #0x382bfa0 ; 
006871AC4  adrp     x8, #0x8f24000
006871AC8  ldr      x8, [x8, #0x398]
006871ACC  mov      x20, x0
006871AD0  ldr      x1, [x8]
006871AD4  bl       #0x5224fa0 ; Rock.Collections.OrderedDictionary<int, object>$$.ctor
006871AD8  mov      x0, x19
006871ADC  str      x20, [x0, #0xb8]!
006871AE0  mov      x1, x20
006871AE4  bl       #0x382bcb8 ; 
006871AE8  adrp     x8, #0x8f09000
006871AEC  ldr      x8, [x8, #0xaf0]
006871AF0  ldr      x0, [x8]
006871AF4  bl       #0x382bfa0 ; 
006871AF8  adrp     x8, #0x8f0a000
006871AFC  ldr      x8, [x8, #0xbd8]
006871B00  mov      x20, x0
006871B04  ldr      x1, [x8]
006871B08  bl       #0x5221198 ; Rock.Collections.OrderedDictionary<int, int>$$.ctor
006871B0C  mov      x0, x19
006871B10  str      x20, [x0, #0xc0]!
006871B14  mov      x1, x20
006871B18  bl       #0x382bcb8 ; 
006871B1C  mov      x0, x19
006871B20  ldp      x20, x19, [sp, #0x50]
006871B24  ldp      x22, x21, [sp, #0x40]
006871B28  ldp      x24, x23, [sp, #0x30]
006871B2C  ldp      x26, x25, [sp, #0x20]
006871B30  ldp      x28, x27, [sp, #0x10]
006871B34  mov      x1, xzr
006871B38  ldp      x29, x30, [sp], #0x60
006871B3C  b        #0x68493e8 ; HotFix.BattleLogic.HeroComponentBase$$.ctor
006871B40  ldr      x2, [x1, #0x60]
006871B44  mov      x0, x19
006871B48  ldp      x20, x19, [sp, #0x50]
006871B4C  ldp      x22, x21, [sp, #0x40]
006871B50  ldp      x24, x23, [sp, #0x30]
006871B54  ldp      x26, x25, [sp, #0x20]
006871B58  ldp      x28, x27, [sp, #0x10]
006871B5C  ldp      x29, x30, [sp], #0x60
006871B60  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill$$.cctor
; RVA 0x6871B64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871B64  stp      x30, x21, [sp, #-0x20]!
006871B68  stp      x20, x19, [sp, #0x10]
006871B6C  adrp     x21, #0x959b000
006871B70  adrp     x19, #0x8f24000
006871B74  adrp     x20, #0x8f24000
006871B78  ldrb     w8, [x21, #0xa6f]
006871B7C  ldr      x19, [x19, #0x3b8]
006871B80  ldr      x20, [x20, #0x3c0]
006871B84  tbnz     w8, #0, #0x6871ba8
006871B88  adrp     x0, #0x8f24000
006871B8C  ldr      x0, [x0, #0x3c0]
006871B90  bl       #0x382bd14 ; 
006871B94  adrp     x0, #0x8f24000
006871B98  ldr      x0, [x0, #0x3b8]
006871B9C  bl       #0x382bd14 ; 
006871BA0  mov      w8, #1
006871BA4  strb     w8, [x21, #0xa6f]
006871BA8  ldr      x8, [x20]
006871BAC  ldr      x9, [x19]
006871BB0  ldr      x8, [x8, #0xb8]
006871BB4  str      x9, [x8]
006871BB8  ldr      x8, [x20]
006871BBC  ldr      x1, [x19]
006871BC0  ldp      x20, x19, [sp, #0x10]
006871BC4  ldr      x0, [x8, #0xb8]
006871BC8  ldp      x30, x21, [sp], #0x20
006871BCC  b        #0x382bcb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$<RemoveSkillInSTG>g__SkillSuit|32_0
; RVA 0x686A1F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686A1F8  str      x30, [sp, #-0x30]!
00686A1FC  stp      x22, x21, [sp, #0x10]
00686A200  stp      x20, x19, [sp, #0x20]
00686A204  adrp     x21, #0x959b000
00686A208  adrp     x22, #0x8f24000
00686A20C  ldrb     w8, [x21, #0xa70]
00686A210  ldr      x22, [x22, #0x40]
00686A214  mov      w19, w1
00686A218  mov      x20, x0
00686A21C  tbnz     w8, #0, #0x686a240
00686A220  adrp     x0, #0x8f24000
00686A224  ldr      x0, [x0, #0x40]
00686A228  bl       #0x382bd14 ; 
00686A22C  adrp     x0, #0x8f23000
00686A230  ldr      x0, [x0, #0xfd0]
00686A234  bl       #0x382bd14 ; 
00686A238  mov      w8, #1
00686A23C  strb     w8, [x21, #0xa70]
00686A240  ldr      x2, [x22]
00686A244  ldrb     w8, [x2, #0x53]
00686A248  tbnz     w8, #5, #0x686a278
00686A24C  cbz      w19, #0x686a294
00686A250  ldr      x0, [x20, #0x50]
00686A254  cbz      x0, #0x686a2a8
00686A258  adrp     x8, #0x8f23000
00686A25C  ldr      x8, [x8, #0xfd0]
00686A260  mov      w1, w19
00686A264  ldp      x20, x19, [sp, #0x20]
00686A268  ldp      x22, x21, [sp, #0x10]
00686A26C  ldr      x2, [x8]
00686A270  ldr      x30, [sp], #0x30
00686A274  b        #0x524c9b0 ; Rock.Collections.OrderedHashSet<int>$$Contains
00686A278  ldr      x3, [x2, #0x60]
00686A27C  mov      x0, x20
00686A280  mov      w1, w19
00686A284  ldp      x20, x19, [sp, #0x20]
00686A288  ldp      x22, x21, [sp, #0x10]
00686A28C  ldr      x30, [sp], #0x30
00686A290  br       x3
00686A294  ldp      x20, x19, [sp, #0x20]
00686A298  ldp      x22, x21, [sp, #0x10]
00686A29C  mov      w0, #1
00686A2A0  ldr      x30, [sp], #0x30
00686A2A4  ret      
00686A2A8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill$$<AddSkill>g__SkillSuit|34_0
; RVA 0x686B244; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B244  str      x30, [sp, #-0x30]!
00686B248  stp      x22, x21, [sp, #0x10]
00686B24C  stp      x20, x19, [sp, #0x20]
00686B250  adrp     x21, #0x959b000
00686B254  adrp     x22, #0x8f24000
00686B258  ldrb     w8, [x21, #0xa71]
00686B25C  ldr      x22, [x22, #0x98]
00686B260  mov      w19, w1
00686B264  mov      x20, x0
00686B268  tbnz     w8, #0, #0x686b28c
00686B26C  adrp     x0, #0x8f24000
00686B270  ldr      x0, [x0, #0x98]
00686B274  bl       #0x382bd14 ; 
00686B278  adrp     x0, #0x8f23000
00686B27C  ldr      x0, [x0, #0xfd0]
00686B280  bl       #0x382bd14 ; 
00686B284  mov      w8, #1
00686B288  strb     w8, [x21, #0xa71]
00686B28C  ldr      x2, [x22]
00686B290  ldrb     w8, [x2, #0x53]
00686B294  tbnz     w8, #5, #0x686b2c4
00686B298  cbz      w19, #0x686b2e0
00686B29C  ldr      x0, [x20, #0x50]
00686B2A0  cbz      x0, #0x686b2f4
00686B2A4  adrp     x8, #0x8f23000
00686B2A8  ldr      x8, [x8, #0xfd0]
00686B2AC  mov      w1, w19
00686B2B0  ldp      x20, x19, [sp, #0x20]
00686B2B4  ldp      x22, x21, [sp, #0x10]
00686B2B8  ldr      x2, [x8]
00686B2BC  ldr      x30, [sp], #0x30
00686B2C0  b        #0x524c9b0 ; Rock.Collections.OrderedHashSet<int>$$Contains
00686B2C4  ldr      x3, [x2, #0x60]
00686B2C8  mov      x0, x20
00686B2CC  mov      w1, w19
00686B2D0  ldp      x20, x19, [sp, #0x20]
00686B2D4  ldp      x22, x21, [sp, #0x10]
00686B2D8  ldr      x30, [sp], #0x30
00686B2DC  br       x3
00686B2E0  ldp      x20, x19, [sp, #0x20]
00686B2E4  ldp      x22, x21, [sp, #0x10]
00686B2E8  mov      w0, #1
00686B2EC  ldr      x30, [sp], #0x30
00686B2F0  ret      
00686B2F4  bl       #0x382bfb8 ; 

