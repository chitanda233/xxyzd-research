; HotFix.BattleLogic.NormalSkillCreator$$get_UseInitBox
; RVA 0x6872CFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872CFC  stp      x30, x21, [sp, #-0x20]!
006872D00  stp      x20, x19, [sp, #0x10]
006872D04  adrp     x20, #0x959b000
006872D08  adrp     x21, #0x8f24000
006872D0C  ldrb     w8, [x20, #0xa93]
006872D10  ldr      x21, [x21, #0x420]
006872D14  mov      x19, x0
006872D18  tbnz     w8, #0, #0x6872d30
006872D1C  adrp     x0, #0x8f24000
006872D20  ldr      x0, [x0, #0x420]
006872D24  bl       #0x382bd14 ; 
006872D28  mov      w8, #1
006872D2C  strb     w8, [x20, #0xa93]
006872D30  ldr      x1, [x21]
006872D34  ldrb     w8, [x1, #0x53]
006872D38  tbnz     w8, #5, #0x6872d58
006872D3C  mov      x0, x19
006872D40  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006872D44  cbz      x0, #0x6872d6c
006872D48  ldp      x20, x19, [sp, #0x10]
006872D4C  mov      x1, xzr
006872D50  ldp      x30, x21, [sp], #0x20
006872D54  b        #0x69ffe94 ; HotFix.BattleLogic.BattleWorldContext$$get_UseNvWuShenInitSkill
006872D58  ldr      x2, [x1, #0x60]
006872D5C  mov      x0, x19
006872D60  ldp      x20, x19, [sp, #0x10]
006872D64  ldp      x30, x21, [sp], #0x20
006872D68  br       x2
006872D6C  bl       #0x382bfb8 ; 

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
006872D98  ldr      x24, [x24, #0x428]
006872D9C  mov      w22, w3
006872DA0  mov      x21, x2
006872DA4  mov      x20, x1
006872DA8  mov      x19, x0
006872DAC  tbnz     w8, #0, #0x6872df4
006872DB0  adrp     x0, #0x8f07000
006872DB4  ldr      x0, [x0, #0xe68]
006872DB8  bl       #0x382bd14 ; 
006872DBC  adrp     x0, #0x8ec2000
006872DC0  ldr      x0, [x0, #0x270]
006872DC4  bl       #0x382bd14 ; 
006872DC8  adrp     x0, #0x8f24000
006872DCC  ldr      x0, [x0, #0x428]
006872DD0  bl       #0x382bd14 ; 
006872DD4  adrp     x0, #0x8f08000
006872DD8  ldr      x0, [x0, #0xbb8]
006872DDC  bl       #0x382bd14 ; 
006872DE0  adrp     x0, #0x8f08000
006872DE4  ldr      x0, [x0, #0xbc0]
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
006872E20  ldr      x0, [x0, #0x3e0]
006872E24  bl       #0x382bd14 ; 
006872E28  mov      w8, #1
006872E2C  strb     w8, [x27, #0xa90]
006872E30  adrp     x28, #0x8ee6000
006872E34  ldr      x28, [x28, #0x3e0]
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
006872E94  ldr      x8, [x8, #0xbb8]
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
006872EEC  ldr      x0, [x0, #0x28]
006872EF0  bl       #0x382bd14 ; 
006872EF4  mov      w8, #1
006872EF8  strb     w8, [x29, #0xac6]
006872EFC  adrp     x8, #0x8f0d000
006872F00  ldr      x8, [x8, #0x28]
006872F04  ldr      x3, [x8]
006872F08  ldrb     w8, [x3, #0x53]
006872F0C  tbnz     w8, #5, #0x6872f4c
006872F10  adrp     x29, #0x9599000
006872F14  ldrb     w8, [x29, #0xac7]
006872F18  cbnz     w8, #0x6872f30
006872F1C  adrp     x0, #0x8f0d000
006872F20  ldr      x0, [x0, #0x30]
006872F24  bl       #0x382bd14 ; 
006872F28  mov      w8, #1
006872F2C  strb     w8, [x29, #0xac7]
006872F30  adrp     x8, #0x8f0d000
006872F34  ldr      x8, [x8, #0x30]
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
006872FA0  ldr      x8, [x8, #0xe68]
006872FA4  ldr      x1, [x8]
006872FA8  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006872FAC  cbz      x0, #0x68730ec
006872FB0  adrp     x29, #0x9599000
006872FB4  ldrb     w8, [x29, #0x4c7]
006872FB8  mov      x26, x0
006872FBC  cbnz     w8, #0x6872fd4
006872FC0  adrp     x0, #0x8f09000
006872FC4  ldr      x0, [x0, #0xc8]
006872FC8  bl       #0x382bd14 ; 
006872FCC  mov      w8, #1
006872FD0  strb     w8, [x29, #0x4c7]
006872FD4  adrp     x8, #0x8f09000
006872FD8  ldr      x8, [x8, #0xc8]
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
00687303C  ldr      x21, [x21, #0x270]
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
006873084  ldr      x0, [x0, #0x3e0]
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
0068730BC  ldr      x8, [x8, #0xbc0]
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

; HotFix.BattleLogic.NormalSkillCreator$$AngelRandomSkillQuality
; RVA 0x68730F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068730F0  stp      x30, x23, [sp, #-0x30]!
0068730F4  stp      x22, x21, [sp, #0x10]
0068730F8  stp      x20, x19, [sp, #0x20]
0068730FC  adrp     x20, #0x959b000
006873100  adrp     x21, #0x8f24000
006873104  ldrb     w8, [x20, #0xa95]
006873108  ldr      x21, [x21, #0x430]
00687310C  mov      x19, x0
006873110  tbnz     w8, #0, #0x6873134
006873114  adrp     x0, #0x8ee8000
006873118  ldr      x0, [x0, #0x898]
00687311C  bl       #0x382bd14 ; 
006873120  adrp     x0, #0x8f24000
006873124  ldr      x0, [x0, #0x430]
006873128  bl       #0x382bd14 ; 
00687312C  mov      w8, #1
006873130  strb     w8, [x20, #0xa95]
006873134  ldr      x1, [x21]
006873138  ldrb     w8, [x1, #0x53]
00687313C  tbnz     w8, #5, #0x68731b0
006873140  adrp     x21, #0x8ee8000
006873144  ldr      x21, [x21, #0x898]
006873148  mov      x20, xzr
00687314C  mov      w22, wzr
006873150  ldr      x0, [x21]
006873154  ldr      w8, [x0, #0xe0]
006873158  cbnz     w8, #0x6873164
00687315C  bl       #0x382be8c ; 
006873160  ldr      x0, [x21]
006873164  ldr      x8, [x0, #0xb8]
006873168  ldrsw    x8, [x8, #0x2f0]
00687316C  cmp      x20, x8
006873170  b.ge     #0x68731c8
006873174  ldr      w8, [x0, #0xe0]
006873178  cbnz     w8, #0x6873184
00687317C  bl       #0x382be8c ; 
006873180  ldr      x0, [x21]
006873184  ldr      x8, [x0, #0xb8]
006873188  ldr      x8, [x8, #0x2f8]
00687318C  cbz      x8, #0x6873350
006873190  ldr      w9, [x8, #0x18]
006873194  cmp      x20, x9
006873198  b.hs     #0x6873354
00687319C  add      x8, x8, x20, lsl #2
0068731A0  ldr      w8, [x8, #0x20]
0068731A4  add      x20, x20, #1
0068731A8  add      w22, w8, w22
0068731AC  b        #0x6873154 ; 
0068731B0  ldr      x2, [x1, #0x60]
0068731B4  mov      x0, x19
0068731B8  ldp      x20, x19, [sp, #0x20]
0068731BC  ldp      x22, x21, [sp, #0x10]
0068731C0  ldp      x30, x23, [sp], #0x30
0068731C4  br       x2
0068731C8  mov      x0, x19
0068731CC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068731D0  cbz      x0, #0x6873350
0068731D4  adrp     x23, #0x9599000
0068731D8  ldrb     w8, [x23, #0xac6]
0068731DC  mov      x20, x0
0068731E0  add      w19, w22, #1
0068731E4  cbnz     w8, #0x68731fc
0068731E8  adrp     x0, #0x8f0d000
0068731EC  ldr      x0, [x0, #0x28]
0068731F0  bl       #0x382bd14 ; 
0068731F4  mov      w8, #1
0068731F8  strb     w8, [x23, #0xac6]
0068731FC  adrp     x8, #0x8f0d000
006873200  ldr      x8, [x8, #0x28]
006873204  ldr      x3, [x8]
006873208  ldrb     w8, [x3, #0x53]
00687320C  tbnz     w8, #5, #0x687324c
006873210  adrp     x22, #0x9599000
006873214  ldrb     w8, [x22, #0xac7]
006873218  cbnz     w8, #0x6873230
00687321C  adrp     x0, #0x8f0d000
006873220  ldr      x0, [x0, #0x30]
006873224  bl       #0x382bd14 ; 
006873228  mov      w8, #1
00687322C  strb     w8, [x22, #0xac7]
006873230  adrp     x8, #0x8f0d000
006873234  ldr      x8, [x8, #0x30]
006873238  ldr      x1, [x8]
00687323C  ldrb     w8, [x1, #0x53]
006873240  tbnz     w8, #5, #0x6873268
006873244  ldr      x0, [x20, #0x260]
006873248  b        #0x6873274 ; 
00687324C  ldr      x8, [x3, #0x60]
006873250  mov      x0, x20
006873254  mov      w1, wzr
006873258  mov      w2, w19
00687325C  blr      x8
006873260  mov      w19, w0
006873264  b        #0x6873298 ; 
006873268  ldr      x8, [x1, #0x60]
00687326C  mov      x0, x20
006873270  blr      x8
006873274  cbz      x0, #0x6873350
006873278  mov      w1, wzr
00687327C  mov      w2, w19
006873280  mov      x3, xzr
006873284  bl       #0x416d068 ; XXRandom$$Next
006873288  ldr      w8, [x20, #0x32c]
00687328C  mov      w19, w0
006873290  add      w8, w8, #1
006873294  str      w8, [x20, #0x32c]
006873298  ldr      x0, [x21]
00687329C  mov      w20, wzr
0068732A0  ldr      w8, [x0, #0xe0]
0068732A4  cbnz     w8, #0x68732b0
0068732A8  bl       #0x382be8c ; 
0068732AC  ldr      x0, [x21]
0068732B0  ldr      x8, [x0, #0xb8]
0068732B4  ldr      w9, [x8, #0x2f0]
0068732B8  cmp      w20, w9
0068732BC  b.ge     #0x6873338
0068732C0  ldr      w9, [x0, #0xe0]
0068732C4  cbnz     w9, #0x68732d4
0068732C8  bl       #0x382be8c ; 
0068732CC  ldr      x0, [x21]
0068732D0  ldr      x8, [x0, #0xb8]
0068732D4  ldr      x8, [x8, #0x2f8]
0068732D8  cbz      x8, #0x6873350
0068732DC  ldr      w9, [x8, #0x18]
0068732E0  cmp      w20, w9
0068732E4  b.hs     #0x6873354
0068732E8  sxtw     x22, w20
0068732EC  add      x8, x8, x22, lsl #2
0068732F0  ldr      w8, [x8, #0x20]
0068732F4  cmp      w19, w8
0068732F8  b.lt     #0x687333c
0068732FC  ldr      w8, [x0, #0xe0]
006873300  cbnz     w8, #0x687330c
006873304  bl       #0x382be8c ; 
006873308  ldr      x0, [x21]
00687330C  ldr      x8, [x0, #0xb8]
006873310  ldr      x8, [x8, #0x2f8]
006873314  cbz      x8, #0x6873350
006873318  ldr      w9, [x8, #0x18]
00687331C  cmp      w20, w9
006873320  b.hs     #0x6873354
006873324  add      x8, x8, x22, lsl #2
006873328  ldr      w8, [x8, #0x20]
00687332C  add      w20, w20, #1
006873330  sub      w19, w19, w8
006873334  b        #0x68732a0 ; 
006873338  mov      w20, wzr
00687333C  mov      w0, w20
006873340  ldp      x20, x19, [sp, #0x20]
006873344  ldp      x22, x21, [sp, #0x10]
006873348  ldp      x30, x23, [sp], #0x30
00687334C  ret      
006873350  bl       #0x382bfb8 ; 
006873354  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.NormalSkillCreator$$GetRandomAngleSkills
; RVA 0x6873358; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006873358  stp      x30, x27, [sp, #-0x50]!
00687335C  stp      x26, x25, [sp, #0x10]
006873360  stp      x24, x23, [sp, #0x20]
006873364  stp      x22, x21, [sp, #0x30]
006873368  stp      x20, x19, [sp, #0x40]
00687336C  adrp     x23, #0x959b000
006873370  adrp     x24, #0x8f24000
006873374  ldrb     w8, [x23, #0xa96]
006873378  ldr      x24, [x24, #0x438]
00687337C  mov      w21, w3
006873380  mov      x20, x2
006873384  mov      x22, x1
006873388  mov      x19, x0
00687338C  tbnz     w8, #0, #0x68733ec
006873390  adrp     x0, #0x8ee1000
006873394  ldr      x0, [x0, #0x6e8]
006873398  bl       #0x382bd14 ; 
00687339C  adrp     x0, #0x8f24000
0068733A0  ldr      x0, [x0, #0x438]
0068733A4  bl       #0x382bd14 ; 
0068733A8  adrp     x0, #0x8f08000
0068733AC  ldr      x0, [x0, #0xbb8]
0068733B0  bl       #0x382bd14 ; 
0068733B4  adrp     x0, #0x8f08000
0068733B8  ldr      x0, [x0, #0xbc0]
0068733BC  bl       #0x382bd14 ; 
0068733C0  adrp     x0, #0x8f24000
0068733C4  ldr      x0, [x0, #0x440]
0068733C8  bl       #0x382bd14 ; 
0068733CC  adrp     x0, #0x8f24000
0068733D0  ldr      x0, [x0, #0x448]
0068733D4  bl       #0x382bd14 ; 
0068733D8  adrp     x0, #0x8f24000
0068733DC  ldr      x0, [x0, #0x450]
0068733E0  bl       #0x382bd14 ; 
0068733E4  mov      w8, #1
0068733E8  strb     w8, [x23, #0xa96]
0068733EC  ldr      x4, [x24]
0068733F0  ldrb     w8, [x4, #0x53]
0068733F4  tbnz     w8, #5, #0x6873498
0068733F8  mov      x0, x19
0068733FC  bl       #0x68730f0 ; HotFix.BattleLogic.NormalSkillCreator$$AngelRandomSkillQuality
006873400  ldr      x8, [x19, #0x78]
006873404  cbz      x8, #0x68735f4
006873408  ldr      w9, [x8, #0x18]
00687340C  mov      w23, w0
006873410  cmp      w0, w9
006873414  b.hs     #0x68735f8
006873418  sxtw     x26, w23
00687341C  add      x8, x8, x26, lsl #3
006873420  ldr      x0, [x8, #0x20]
006873424  cbz      x0, #0x68735f4
006873428  mov      x1, x22
00687342C  mov      x2, xzr
006873430  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006873434  cmp      w0, w21
006873438  b.ge     #0x68734c4
00687343C  adrp     x8, #0x8ee1000
006873440  ldr      x8, [x8, #0x6e8]
006873444  ldr      x0, [x8]
006873448  ldr      w8, [x0, #0xe0]
00687344C  cbnz     w8, #0x6873454
006873450  bl       #0x382be8c ; 
006873454  adrp     x8, #0x8f24000
006873458  adrp     x9, #0x8f24000
00687345C  adrp     x10, #0x8f24000
006873460  ldr      x8, [x8, #0x450]
006873464  ldr      x9, [x9, #0x448]
006873468  ldr      x10, [x10, #0x440]
00687346C  ldp      x20, x19, [sp, #0x40]
006873470  ldr      x0, [x8]
006873474  ldr      x1, [x9]
006873478  ldr      x2, [x10]
00687347C  ldp      x22, x21, [sp, #0x30]
006873480  ldp      x24, x23, [sp, #0x20]
006873484  ldp      x26, x25, [sp, #0x10]
006873488  mov      w3, #0x3c
00687348C  mov      x4, xzr
006873490  ldp      x30, x27, [sp], #0x50
006873494  b        #0x7997754 ; Logger$$LogError
006873498  ldr      x5, [x4, #0x60]
00687349C  mov      x0, x19
0068734A0  mov      x1, x22
0068734A4  mov      x2, x20
0068734A8  mov      w3, w21
0068734AC  ldp      x20, x19, [sp, #0x40]
0068734B0  ldp      x22, x21, [sp, #0x30]
0068734B4  ldp      x24, x23, [sp, #0x20]
0068734B8  ldp      x26, x25, [sp, #0x10]
0068734BC  ldp      x30, x27, [sp], #0x50
0068734C0  br       x5
0068734C4  mov      x0, x19
0068734C8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068734CC  cbz      x0, #0x68735f4
0068734D0  adrp     x25, #0x9591000
0068734D4  ldrb     w8, [x25, #0xa90]
0068734D8  mov      x24, x0
0068734DC  cbnz     w8, #0x68734f4
0068734E0  adrp     x0, #0x8ee6000
0068734E4  ldr      x0, [x0, #0x3e0]
0068734E8  bl       #0x382bd14 ; 
0068734EC  mov      w8, #1
0068734F0  strb     w8, [x25, #0xa90]
0068734F4  adrp     x27, #0x8ee6000
0068734F8  ldr      x27, [x27, #0x3e0]
0068734FC  ldr      x1, [x27]
006873500  ldrb     w8, [x1, #0x53]
006873504  tbnz     w8, #5, #0x6873510
006873508  ldr      x0, [x24, #0x230]
00687350C  b        #0x687351c ; 
006873510  ldr      x8, [x1, #0x60]
006873514  mov      x0, x24
006873518  blr      x8
00687351C  cbz      x0, #0x68735f4
006873520  adrp     x8, #0x8f08000
006873524  ldr      x8, [x8, #0xbb8]
006873528  ldr      x1, [x8]
00687352C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006873530  mov      x24, x0
006873534  mov      x0, x19
006873538  mov      x1, x24
00687353C  mov      x2, x20
006873540  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
006873544  ldr      x8, [x19, #0x78]
006873548  cbz      x8, #0x68735f4
00687354C  ldr      w9, [x8, #0x18]
006873550  cmp      w23, w9
006873554  b.hs     #0x68735f8
006873558  add      x8, x8, x26, lsl #3
00687355C  ldr      x0, [x8, #0x20]
006873560  cbz      x0, #0x68735f4
006873564  mov      w1, w21
006873568  mov      x2, x22
00687356C  mov      x3, x20
006873570  mov      x4, x24
006873574  mov      x5, xzr
006873578  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
00687357C  mov      x0, x19
006873580  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873584  cbz      x0, #0x68735f4
006873588  ldrb     w8, [x25, #0xa90]
00687358C  mov      x19, x0
006873590  cbnz     w8, #0x68735a8
006873594  adrp     x0, #0x8ee6000
006873598  ldr      x0, [x0, #0x3e0]
00687359C  bl       #0x382bd14 ; 
0068735A0  mov      w8, #1
0068735A4  strb     w8, [x25, #0xa90]
0068735A8  ldr      x1, [x27]
0068735AC  ldrb     w8, [x1, #0x53]
0068735B0  tbnz     w8, #5, #0x68735bc
0068735B4  ldr      x0, [x19, #0x230]
0068735B8  b        #0x68735c8 ; 
0068735BC  ldr      x8, [x1, #0x60]
0068735C0  mov      x0, x19
0068735C4  blr      x8
0068735C8  cbz      x0, #0x68735f4
0068735CC  adrp     x8, #0x8f08000
0068735D0  ldr      x8, [x8, #0xbc0]
0068735D4  mov      x1, x24
0068735D8  ldp      x20, x19, [sp, #0x40]
0068735DC  ldp      x22, x21, [sp, #0x30]
0068735E0  ldr      x2, [x8]
0068735E4  ldp      x24, x23, [sp, #0x20]
0068735E8  ldp      x26, x25, [sp, #0x10]
0068735EC  ldp      x30, x27, [sp], #0x50
0068735F0  b        #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
0068735F4  bl       #0x382bfb8 ; 
0068735F8  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.NormalSkillCreator$$RandomAngelSkill
; RVA 0x68735FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068735FC  stp      x30, x21, [sp, #-0x20]!
006873600  stp      x20, x19, [sp, #0x10]
006873604  adrp     x20, #0x959b000
006873608  adrp     x21, #0x8f24000
00687360C  ldrb     w8, [x20, #0xa97]
006873610  ldr      x21, [x21, #0x458]
006873614  mov      x19, x0
006873618  tbnz     w8, #0, #0x6873630
00687361C  adrp     x0, #0x8f24000
006873620  ldr      x0, [x0, #0x458]
006873624  bl       #0x382bd14 ; 
006873628  mov      w8, #1
00687362C  strb     w8, [x20, #0xa97]
006873630  ldr      x1, [x21]
006873634  ldrb     w8, [x1, #0x53]
006873638  tbnz     w8, #5, #0x6873674
00687363C  mov      x0, x19
006873640  bl       #0x68730f0 ; HotFix.BattleLogic.NormalSkillCreator$$AngelRandomSkillQuality
006873644  ldr      x8, [x19, #0x78]
006873648  cbz      x8, #0x6873688
00687364C  ldr      w9, [x8, #0x18]
006873650  cmp      w0, w9
006873654  b.hs     #0x687368c
006873658  add      x8, x8, w0, sxtw #3
00687365C  ldr      x0, [x8, #0x20]
006873660  cbz      x0, #0x6873688
006873664  ldp      x20, x19, [sp, #0x10]
006873668  mov      x1, xzr
00687366C  ldp      x30, x21, [sp], #0x20
006873670  b        #0x66339e8 ; HotFix.BattleLogic.WeightRandom$$GetRandom
006873674  ldr      x2, [x1, #0x60]
006873678  mov      x0, x19
00687367C  ldp      x20, x19, [sp, #0x10]
006873680  ldp      x30, x21, [sp], #0x20
006873684  br       x2
006873688  bl       #0x382bfb8 ; 
00687368C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.NormalSkillCreator$$AddSkillChangeRandomPool
; RVA 0x6860EA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006860EA0  stp      x30, x23, [sp, #-0x30]!
006860EA4  stp      x22, x21, [sp, #0x10]
006860EA8  stp      x20, x19, [sp, #0x20]
006860EAC  adrp     x22, #0x959b000
006860EB0  adrp     x23, #0x8f23000
006860EB4  ldrb     w8, [x22, #0xa98]
006860EB8  ldr      x23, [x23, #0xc98]
006860EBC  mov      x19, x2
006860EC0  mov      w20, w1
006860EC4  mov      x21, x0
006860EC8  tbnz     w8, #0, #0x6860ee0
006860ECC  adrp     x0, #0x8f23000
006860ED0  ldr      x0, [x0, #0xc98]
006860ED4  bl       #0x382bd14 ; 
006860ED8  mov      w8, #1
006860EDC  strb     w8, [x22, #0xa98]
006860EE0  ldr      x3, [x23]
006860EE4  ldrb     w8, [x3, #0x53]
006860EE8  tbnz     w8, #5, #0x6860efc
006860EEC  ldp      x20, x19, [sp, #0x20]
006860EF0  ldp      x22, x21, [sp, #0x10]
006860EF4  ldp      x30, x23, [sp], #0x30
006860EF8  ret      
006860EFC  ldr      x4, [x3, #0x60]
006860F00  mov      x0, x21
006860F04  mov      w1, w20
006860F08  mov      x2, x19
006860F0C  ldp      x20, x19, [sp, #0x20]
006860F10  ldp      x22, x21, [sp, #0x10]
006860F14  ldp      x30, x23, [sp], #0x30
006860F18  br       x4

; HotFix.BattleLogic.NormalSkillCreator$$OpenSelectSpecialSkill
; RVA 0x6873690; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006873690  str      x30, [sp, #-0x40]!
006873694  stp      x24, x23, [sp, #0x10]
006873698  stp      x22, x21, [sp, #0x20]
00687369C  stp      x20, x19, [sp, #0x30]
0068736A0  adrp     x23, #0x959b000
0068736A4  adrp     x24, #0x8f24000
0068736A8  ldrb     w8, [x23, #0xa99]
0068736AC  ldr      x24, [x24, #0x460]
0068736B0  mov      x19, x3
0068736B4  mov      x20, x2
0068736B8  mov      x21, x1
0068736BC  mov      x22, x0
0068736C0  tbnz     w8, #0, #0x68736d8
0068736C4  adrp     x0, #0x8f24000
0068736C8  ldr      x0, [x0, #0x460]
0068736CC  bl       #0x382bd14 ; 
0068736D0  mov      w8, #1
0068736D4  strb     w8, [x23, #0xa99]
0068736D8  ldr      x4, [x24]
0068736DC  ldrb     w8, [x4, #0x53]
0068736E0  tbnz     w8, #5, #0x6873700
0068736E4  str      wzr, [x19]
0068736E8  ldp      x20, x19, [sp, #0x30]
0068736EC  ldp      x22, x21, [sp, #0x20]
0068736F0  ldp      x24, x23, [sp, #0x10]
0068736F4  mov      w0, wzr
0068736F8  ldr      x30, [sp], #0x40
0068736FC  ret      
006873700  ldr      x5, [x4, #0x60]
006873704  mov      x0, x22
006873708  mov      x1, x21
00687370C  mov      x2, x20
006873710  mov      x3, x19
006873714  ldp      x20, x19, [sp, #0x30]
006873718  ldp      x22, x21, [sp, #0x20]
00687371C  ldp      x24, x23, [sp, #0x10]
006873720  ldr      x30, [sp], #0x40
006873724  br       x5

; HotFix.BattleLogic.NormalSkillCreator$$CheckNeedOpenSpecialSkill
; RVA 0x6873728; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006873728  stp      x30, x21, [sp, #-0x20]!
00687372C  stp      x20, x19, [sp, #0x10]
006873730  adrp     x20, #0x959b000
006873734  adrp     x21, #0x8f24000
006873738  ldrb     w8, [x20, #0xa9a]
00687373C  ldr      x21, [x21, #0x468]
006873740  mov      x19, x0
006873744  tbnz     w8, #0, #0x687375c
006873748  adrp     x0, #0x8f24000
00687374C  ldr      x0, [x0, #0x468]
006873750  bl       #0x382bd14 ; 
006873754  mov      w8, #1
006873758  strb     w8, [x20, #0xa9a]
00687375C  ldr      x1, [x21]
006873760  ldrb     w8, [x1, #0x53]
006873764  tbnz     w8, #5, #0x6873778
006873768  ldp      x20, x19, [sp, #0x10]
00687376C  mov      w0, wzr
006873770  ldp      x30, x21, [sp], #0x20
006873774  ret      
006873778  ldr      x2, [x1, #0x60]
00687377C  mov      x0, x19
006873780  ldp      x20, x19, [sp, #0x10]
006873784  ldp      x30, x21, [sp], #0x20
006873788  br       x2

; HotFix.BattleLogic.NormalSkillCreator$$GetRandomPunchboardSkills
; RVA 0x687378C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687378C  sub      sp, sp, #0xa0
006873790  stp      x29, x30, [sp, #0x40]
006873794  stp      x28, x27, [sp, #0x50]
006873798  stp      x26, x25, [sp, #0x60]
00687379C  stp      x24, x23, [sp, #0x70]
0068737A0  stp      x22, x21, [sp, #0x80]
0068737A4  stp      x20, x19, [sp, #0x90]
0068737A8  ldr      x9, [sp, #0xa0]
0068737AC  stp      w6, w7, [sp, #0x30]
0068737B0  str      x5, [sp, #0x38]
0068737B4  str      w4, [sp, #0x18]
0068737B8  adrp     x19, #0x959b000
0068737BC  stp      x1, x9, [sp, #0x20]
0068737C0  adrp     x22, #0x8f24000
0068737C4  ldrb     w8, [x19, #0xa9b]
0068737C8  ldr      x22, [x22, #0x470]
0068737CC  mov      x21, x3
0068737D0  mov      x26, x2
0068737D4  mov      x20, x0
0068737D8  tbnz     w8, #0, #0x6873844
0068737DC  adrp     x0, #0x8f07000
0068737E0  ldr      x0, [x0, #0xe68]
0068737E4  bl       #0x382bd14 ; 
0068737E8  adrp     x0, #0x8ec2000
0068737EC  ldr      x0, [x0, #0x260]
0068737F0  bl       #0x382bd14 ; 
0068737F4  adrp     x0, #0x8ec2000
0068737F8  ldr      x0, [x0, #0x240]
0068737FC  bl       #0x382bd14 ; 
006873800  adrp     x0, #0x8ed2000
006873804  ldr      x0, [x0, #0xdd8]
006873808  bl       #0x382bd14 ; 
00687380C  adrp     x0, #0x8ec2000
006873810  ldr      x0, [x0, #0x268]
006873814  bl       #0x382bd14 ; 
006873818  adrp     x0, #0x8ec2000
00687381C  ldr      x0, [x0, #0x270]
006873820  bl       #0x382bd14 ; 
006873824  adrp     x0, #0x8f24000
006873828  ldr      x0, [x0, #0x470]
00687382C  bl       #0x382bd14 ; 
006873830  adrp     x0, #0x8f08000
006873834  ldr      x0, [x0, #0xbb8]
006873838  bl       #0x382bd14 ; 
00687383C  mov      w8, #1
006873840  strb     w8, [x19, #0xa9b]
006873844  ldr      x8, [x22]
006873848  ldrb     w9, [x8, #0x53]
00687384C  tbnz     w9, #5, #0x68738e8
006873850  ldr      x9, [sp, #0x20]
006873854  cbz      x9, #0x6873e3c
006873858  ldr      w8, [x9, #0x1c]
00687385C  add      w8, w8, #1
006873860  stp      wzr, w8, [x9, #0x18]
006873864  cbz      x26, #0x6873e3c
006873868  ldr      w8, [x26, #0x1c]
00687386C  add      w8, w8, #1
006873870  stp      wzr, w8, [x26, #0x18]
006873874  cbz      x21, #0x6873e3c
006873878  ldr      w8, [x21, #0x1c]
00687387C  ldr      x22, [sp, #0x20]
006873880  add      w8, w8, #1
006873884  stp      wzr, w8, [x21, #0x18]
006873888  ldr      x3, [x20, #0x28]
00687388C  ldr      w21, [sp, #0x18]
006873890  cbz      x3, #0x6873e3c
006873894  mov      w19, #4
006873898  ldr      w8, [x3, #0x18]
00687389C  sub      x9, x19, #4
0068738A0  cmp      w9, w8
0068738A4  b.ge     #0x687393c
0068738A8  ldr      x10, [x20, #0x48]
0068738AC  cbz      x10, #0x6873e3c
0068738B0  ldr      w11, [x10, #0x18]
0068738B4  cmp      w9, w11
0068738B8  b.hs     #0x6873e40
0068738BC  cmp      w9, w8
0068738C0  b.hs     #0x6873e40
0068738C4  ldr      x0, [x10, x19, lsl #3]
0068738C8  cbz      x0, #0x6873e3c
0068738CC  ldr      x1, [x3, x19, lsl #3]
0068738D0  mov      x2, xzr
0068738D4  bl       #0x6635a1c ; HotFix.BattleLogic.WeightRandom$$CopyWeightRandom
0068738D8  ldr      x3, [x20, #0x28]
0068738DC  add      x19, x19, #1
0068738E0  cbnz     x3, #0x6873898
0068738E4  b        #0x6873e3c ; 
0068738E8  ldr      x9, [x8, #0x60]
0068738EC  str      x8, [sp, #0xa8]
0068738F0  ldr      w8, [sp, #0x30]
0068738F4  mov      x0, x20
0068738F8  mov      x2, x26
0068738FC  mov      x3, x21
006873900  and      w6, w8, #1
006873904  ldr      w8, [sp, #0x34]
006873908  ldr      w4, [sp, #0x18]
00687390C  ldr      x5, [sp, #0x38]
006873910  ldp      x20, x19, [sp, #0x90]
006873914  and      w7, w8, #1
006873918  ldp      x1, x8, [sp, #0x20]
00687391C  ldp      x22, x21, [sp, #0x80]
006873920  ldp      x24, x23, [sp, #0x70]
006873924  ldp      x26, x25, [sp, #0x60]
006873928  ldp      x28, x27, [sp, #0x50]
00687392C  ldp      x29, x30, [sp, #0x40]
006873930  str      x8, [sp, #0xa0]
006873934  add      sp, sp, #0xa0
006873938  br       x9
00687393C  cmp      w21, #1
006873940  b.lt     #0x6873b30
006873944  adrp     x29, #0x8f23000
006873948  adrp     x28, #0x8f24000
00687394C  ldr      x29, [x29, #0x90]
006873950  ldr      x28, [x28, #0x68]
006873954  mov      w19, wzr
006873958  mov      w23, wzr
00687395C  add      x26, x20, #0x60
006873960  mov      w24, #1
006873964  adrp     x25, #0x959b000
006873968  adrp     x27, #0x959b000
00687396C  str      x26, [sp, #0x10]
006873970  ldp      w9, w8, [sp, #0x30]
006873974  ldr      x2, [sp, #0x28]
006873978  ldr      x6, [sp, #0x38]
00687397C  mov      w4, #1
006873980  and      w8, w8, #1
006873984  and      w7, w9, #1
006873988  mov      x0, x20
00687398C  mov      x1, x22
006873990  mov      x5, x26
006873994  strb     w8, [sp]
006873998  bl       #0x685b9c4 ; HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills
00687399C  ldr      w8, [x22, #0x18]
0068739A0  cmp      w8, w19
0068739A4  b.le     #0x6873b1c
0068739A8  mov      x0, x20
0068739AC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068739B0  cbz      x0, #0x6873e3c
0068739B4  adrp     x8, #0x9598000
0068739B8  ldrb     w8, [x8, #0xfcc]
0068739BC  mov      x21, x0
0068739C0  cbnz     w8, #0x68739d8
0068739C4  adrp     x0, #0x8f06000
0068739C8  ldr      x0, [x0, #0x470]
0068739CC  bl       #0x382bd14 ; 
0068739D0  adrp     x8, #0x9598000
0068739D4  strb     w24, [x8, #0xfcc]
0068739D8  adrp     x8, #0x8f06000
0068739DC  ldr      x8, [x8, #0x470]
0068739E0  ldr      x1, [x8]
0068739E4  ldrb     w8, [x1, #0x53]
0068739E8  tbnz     w8, #5, #0x68739f4
0068739EC  ldr      x21, [x21, #0x200]
0068739F0  b        #0x6873a04 ; 
0068739F4  ldr      x8, [x1, #0x60]
0068739F8  mov      x0, x21
0068739FC  blr      x8
006873A00  mov      x21, x0
006873A04  adrp     x8, #0x8ec2000
006873A08  ldr      x8, [x8, #0x270]
006873A0C  mov      x0, x22
006873A10  mov      w1, w19
006873A14  ldr      x2, [x8]
006873A18  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873A1C  cbz      x21, #0x6873e3c
006873A20  mov      w1, w0
006873A24  mov      x0, x21
006873A28  mov      x2, xzr
006873A2C  str      w19, [sp, #0x1c]
006873A30  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006873A34  cbz      x0, #0x6873e3c
006873A38  mov      x21, x0
006873A3C  mov      w26, wzr
006873A40  ldrb     w8, [x25, #0x9b4]
006873A44  cbnz     w8, #0x6873a54
006873A48  mov      x0, x29
006873A4C  bl       #0x382bd14 ; 
006873A50  strb     w24, [x25, #0x9b4]
006873A54  ldr      x1, [x29]
006873A58  ldrb     w8, [x1, #0x53]
006873A5C  tbnz     w8, #5, #0x6873a68
006873A60  ldr      x0, [x21, #0x170]
006873A64  b        #0x6873a74 ; 
006873A68  ldr      x8, [x1, #0x60]
006873A6C  mov      x0, x21
006873A70  blr      x8
006873A74  cbz      x0, #0x6873e3c
006873A78  ldr      w8, [x0, #0x18]
006873A7C  cmp      w26, w8
006873A80  b.ge     #0x6873b0c
006873A84  ldr      x8, [x20, #0x28]
006873A88  cbz      x8, #0x6873e3c
006873A8C  mov      x19, xzr
006873A90  ldr      w9, [x8, #0x18]
006873A94  cmp      w19, w9
006873A98  b.ge     #0x6873b04
006873A9C  cmp      w19, w9
006873AA0  b.hs     #0x6873e40
006873AA4  add      x8, x8, x19, lsl #3
006873AA8  ldrb     w9, [x27, #0xbad]
006873AAC  ldr      x22, [x8, #0x20]
006873AB0  cbnz     w9, #0x6873ac0
006873AB4  mov      x0, x28
006873AB8  bl       #0x382bd14 ; 
006873ABC  strb     w24, [x27, #0xbad]
006873AC0  ldr      x1, [x28]
006873AC4  ldrb     w8, [x1, #0x53]
006873AC8  tbnz     w8, #5, #0x6873ad4
006873ACC  ldr      w1, [x21, #0x17c]
006873AD0  b        #0x6873ae4 ; 
006873AD4  ldr      x8, [x1, #0x60]
006873AD8  mov      x0, x21
006873ADC  blr      x8
006873AE0  mov      w1, w0
006873AE4  cbz      x22, #0x6873e3c
006873AE8  mov      x0, x22
006873AEC  mov      x2, xzr
006873AF0  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006873AF4  ldr      x8, [x20, #0x28]
006873AF8  add      x19, x19, #1
006873AFC  cbnz     x8, #0x6873a90
006873B00  b        #0x6873e3c ; 
006873B04  add      w26, w26, #1
006873B08  b        #0x6873a40 ; 
006873B0C  ldp      w21, w19, [sp, #0x18]
006873B10  ldr      x22, [sp, #0x20]
006873B14  ldr      x26, [sp, #0x10]
006873B18  add      w19, w19, #1
006873B1C  add      w23, w23, #1
006873B20  cmp      w23, w21
006873B24  b.eq     #0x6873b30
006873B28  ldr      x3, [x20, #0x28]
006873B2C  b        #0x6873970 ; 
006873B30  ldr      w8, [x22, #0x18]
006873B34  cmp      w8, w21
006873B38  b.ge     #0x6873e18
006873B3C  mov      x0, x20
006873B40  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873B44  cbz      x0, #0x6873e3c
006873B48  adrp     x19, #0x9591000
006873B4C  ldrb     w8, [x19, #0xa90]
006873B50  mov      x21, x0
006873B54  cbnz     w8, #0x6873b6c
006873B58  adrp     x0, #0x8ee6000
006873B5C  ldr      x0, [x0, #0x3e0]
006873B60  bl       #0x382bd14 ; 
006873B64  mov      w8, #1
006873B68  strb     w8, [x19, #0xa90]
006873B6C  adrp     x8, #0x8ee6000
006873B70  ldr      x8, [x8, #0x3e0]
006873B74  ldr      x1, [x8]
006873B78  ldrb     w8, [x1, #0x53]
006873B7C  tbnz     w8, #5, #0x6873b88
006873B80  ldr      x0, [x21, #0x230]
006873B84  b        #0x6873b94 ; 
006873B88  ldr      x8, [x1, #0x60]
006873B8C  mov      x0, x21
006873B90  blr      x8
006873B94  ldr      x26, [sp, #0x20]
006873B98  cbz      x0, #0x6873e3c
006873B9C  adrp     x8, #0x8f08000
006873BA0  ldr      x8, [x8, #0xbb8]
006873BA4  ldr      x1, [x8]
006873BA8  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006873BAC  ldr      x8, [x20, #0x58]
006873BB0  cbz      x8, #0x6873e3c
006873BB4  adrp     x9, #0x8f07000
006873BB8  ldr      x9, [x9, #0xe68]
006873BBC  mov      x22, x0
006873BC0  mov      x0, x8
006873BC4  ldr      x1, [x9]
006873BC8  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006873BCC  ldr      w8, [x26, #0x18]
006873BD0  cmp      w8, #1
006873BD4  b.lt     #0x6873c9c
006873BD8  adrp     x24, #0x8ec2000
006873BDC  adrp     x25, #0x8ec2000
006873BE0  ldr      x24, [x24, #0x270]
006873BE4  ldr      x25, [x25, #0x260]
006873BE8  mov      x21, x0
006873BEC  mov      w23, wzr
006873BF0  ldr      x2, [x24]
006873BF4  mov      x0, x26
006873BF8  mov      w1, w23
006873BFC  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873C00  cbz      x21, #0x6873e3c
006873C04  mov      w1, w0
006873C08  mov      x0, x21
006873C0C  bl       #0x686ed1c ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillRemainCount
006873C10  sub      w19, w0, #1
006873C14  cmp      w19, #1
006873C18  b.lt     #0x6873c8c
006873C1C  ldr      x2, [x24]
006873C20  mov      x0, x26
006873C24  mov      w1, w23
006873C28  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873C2C  cbz      x22, #0x6873e3c
006873C30  ldr      w10, [x22, #0x1c]
006873C34  ldr      x8, [x22, #0x10]
006873C38  ldr      x9, [x25]
006873C3C  add      w10, w10, #1
006873C40  str      w10, [x22, #0x1c]
006873C44  cbz      x8, #0x6873e3c
006873C48  ldrsw    x10, [x22, #0x18]
006873C4C  ldr      w11, [x8, #0x18]
006873C50  mov      w1, w0
006873C54  cmp      w10, w11
006873C58  b.hs     #0x6873c70
006873C5C  add      w9, w10, #1
006873C60  add      x8, x8, x10, lsl #2
006873C64  str      w9, [x22, #0x18]
006873C68  str      w1, [x8, #0x20]
006873C6C  b        #0x6873c84 ; 
006873C70  ldr      x8, [x9, #0x20]
006873C74  mov      x0, x22
006873C78  ldr      x8, [x8, #0xc0]
006873C7C  ldr      x2, [x8, #0x70]
006873C80  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006873C84  subs     w19, w19, #1
006873C88  b.ne     #0x6873c1c
006873C8C  ldr      w8, [x26, #0x18]
006873C90  add      w23, w23, #1
006873C94  cmp      w23, w8
006873C98  b.lt     #0x6873bf0
006873C9C  ldr      w9, [sp, #0x18]
006873CA0  sub      w26, w9, w8
006873CA4  cmp      w26, #1
006873CA8  b.lt     #0x6873e18
006873CAC  cbz      x22, #0x6873e3c
006873CB0  adrp     x21, #0x8f0d000
006873CB4  adrp     x28, #0x8ec2000
006873CB8  adrp     x29, #0x8ec2000
006873CBC  adrp     x23, #0x8ed2000
006873CC0  ldr      x21, [x21, #0x28]
006873CC4  ldr      x28, [x28, #0x270]
006873CC8  ldr      x29, [x29, #0x260]
006873CCC  ldr      x23, [x23, #0xdd8]
006873CD0  adrp     x27, #0x9599000
006873CD4  mov      w19, #1
006873CD8  ldr      w24, [x22, #0x18]
006873CDC  cmp      w24, #1
006873CE0  b.lt     #0x6873e10
006873CE4  mov      x0, x20
006873CE8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873CEC  cbz      x0, #0x6873e3c
006873CF0  ldrb     w8, [x27, #0xac6]
006873CF4  mov      x25, x0
006873CF8  cbnz     w8, #0x6873d08
006873CFC  mov      x0, x21
006873D00  bl       #0x382bd14 ; 
006873D04  strb     w19, [x27, #0xac6]
006873D08  ldr      x3, [x21]
006873D0C  ldrb     w8, [x3, #0x53]
006873D10  tbnz     w8, #5, #0x6873d50
006873D14  adrp     x8, #0x9599000
006873D18  ldrb     w8, [x8, #0xac7]
006873D1C  cbnz     w8, #0x6873d34
006873D20  adrp     x0, #0x8f0d000
006873D24  ldr      x0, [x0, #0x30]
006873D28  bl       #0x382bd14 ; 
006873D2C  adrp     x8, #0x9599000
006873D30  strb     w19, [x8, #0xac7]
006873D34  adrp     x8, #0x8f0d000
006873D38  ldr      x8, [x8, #0x30]
006873D3C  ldr      x1, [x8]
006873D40  ldrb     w8, [x1, #0x53]
006873D44  tbnz     w8, #5, #0x6873d6c
006873D48  ldr      x0, [x25, #0x260]
006873D4C  b        #0x6873d78 ; 
006873D50  ldr      x8, [x3, #0x60]
006873D54  mov      x0, x25
006873D58  mov      w1, wzr
006873D5C  mov      w2, w24
006873D60  blr      x8
006873D64  mov      w24, w0
006873D68  b        #0x6873d9c ; 
006873D6C  ldr      x8, [x1, #0x60]
006873D70  mov      x0, x25
006873D74  blr      x8
006873D78  cbz      x0, #0x6873e3c
006873D7C  mov      w1, wzr
006873D80  mov      w2, w24
006873D84  mov      x3, xzr
006873D88  bl       #0x416d068 ; XXRandom$$Next
006873D8C  ldr      w8, [x25, #0x32c]
006873D90  mov      w24, w0
006873D94  add      w8, w8, #1
006873D98  str      w8, [x25, #0x32c]
006873D9C  ldr      x2, [x28]
006873DA0  mov      x0, x22
006873DA4  mov      w1, w24
006873DA8  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873DAC  mov      w1, w0
006873DB0  ldr      x0, [sp, #0x20]
006873DB4  ldr      x9, [x29]
006873DB8  ldr      w10, [x0, #0x1c]
006873DBC  ldr      x8, [x0, #0x10]
006873DC0  add      w10, w10, #1
006873DC4  str      w10, [x0, #0x1c]
006873DC8  cbz      x8, #0x6873e3c
006873DCC  ldrsw    x10, [x0, #0x18]
006873DD0  ldr      w11, [x8, #0x18]
006873DD4  cmp      w10, w11
006873DD8  b.hs     #0x6873df0
006873DDC  add      w9, w10, #1
006873DE0  add      x8, x8, x10, lsl #2
006873DE4  str      w9, [x0, #0x18]
006873DE8  str      w1, [x8, #0x20]
006873DEC  b        #0x6873e00 ; 
006873DF0  ldr      x8, [x9, #0x20]
006873DF4  ldr      x8, [x8, #0xc0]
006873DF8  ldr      x2, [x8, #0x70]
006873DFC  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006873E00  ldr      x2, [x23]
006873E04  mov      x0, x22
006873E08  mov      w1, w24
006873E0C  bl       #0x4d6603c ; System.Collections.Generic.List<int>$$RemoveAt
006873E10  subs     w26, w26, #1
006873E14  b.ne     #0x6873cd8
006873E18  ldp      x20, x19, [sp, #0x90]
006873E1C  ldp      x22, x21, [sp, #0x80]
006873E20  ldp      x24, x23, [sp, #0x70]
006873E24  ldp      x26, x25, [sp, #0x60]
006873E28  ldp      x28, x27, [sp, #0x50]
006873E2C  ldp      x29, x30, [sp, #0x40]
006873E30  mov      x0, xzr
006873E34  add      sp, sp, #0xa0
006873E38  ret      
006873E3C  bl       #0x382bfb8 ; 
006873E40  bl       #0x382bfc0 ; 

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
006873E68  ldr      x23, [x23, #0x478]
006873E6C  mov      w21, w2
006873E70  mov      x20, x1
006873E74  mov      x19, x0
006873E78  tbnz     w8, #0, #0x6873ecc
006873E7C  adrp     x0, #0x8ee8000
006873E80  ldr      x0, [x0, #0x898]
006873E84  bl       #0x382bd14 ; 
006873E88  adrp     x0, #0x8f07000
006873E8C  ldr      x0, [x0, #0xe68]
006873E90  bl       #0x382bd14 ; 
006873E94  adrp     x0, #0x8ec2000
006873E98  ldr      x0, [x0, #0x270]
006873E9C  bl       #0x382bd14 ; 
006873EA0  adrp     x0, #0x8f24000
006873EA4  ldr      x0, [x0, #0x478]
006873EA8  bl       #0x382bd14 ; 
006873EAC  adrp     x0, #0x8f08000
006873EB0  ldr      x0, [x0, #0xbb8]
006873EB4  bl       #0x382bd14 ; 
006873EB8  adrp     x0, #0x8f08000
006873EBC  ldr      x0, [x0, #0xbc0]
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
006873EF8  ldr      x0, [x0, #0x3e0]
006873EFC  bl       #0x382bd14 ; 
006873F00  mov      w8, #1
006873F04  strb     w8, [x25, #0xa90]
006873F08  adrp     x26, #0x8ee6000
006873F0C  ldr      x26, [x26, #0x3e0]
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
006873F64  ldr      x8, [x8, #0xbb8]
006873F68  ldr      x1, [x8]
006873F6C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006873F70  ldr      x8, [x19, #0x58]
006873F74  cbz      x8, #0x68740d4
006873F78  adrp     x9, #0x8f07000
006873F7C  ldr      x9, [x9, #0xe68]
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
006873FA8  ldr      x0, [x0, #0xc8]
006873FAC  bl       #0x382bd14 ; 
006873FB0  mov      w8, #1
006873FB4  strb     w8, [x24, #0x4c7]
006873FB8  adrp     x8, #0x8f09000
006873FBC  ldr      x8, [x8, #0xc8]
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
006873FE8  ldr      x27, [x27, #0x898]
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
006874038  ldr      x8, [x8, #0x270]
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
00687406C  ldr      x0, [x0, #0x3e0]
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
0068740A4  ldr      x8, [x8, #0xbc0]
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

; HotFix.BattleLogic.NormalSkillCreator$$OnCreateRandoms
; RVA 0x685CECC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685CECC  stp      x30, x21, [sp, #-0x20]!
00685CED0  stp      x20, x19, [sp, #0x10]
00685CED4  adrp     x20, #0x959b000
00685CED8  adrp     x21, #0x8f23000
00685CEDC  ldrb     w8, [x20, #0xa9d]
00685CEE0  ldr      x21, [x21, #0xb28]
00685CEE4  mov      x19, x0
00685CEE8  tbnz     w8, #0, #0x685cf0c
00685CEEC  adrp     x0, #0x8f23000
00685CEF0  ldr      x0, [x0, #0xb28]
00685CEF4  bl       #0x382bd14 ; 
00685CEF8  adrp     x0, #0x8f23000
00685CEFC  ldr      x0, [x0, #0xb08]
00685CF00  bl       #0x382bd14 ; 
00685CF04  mov      w8, #1
00685CF08  strb     w8, [x20, #0xa9d]
00685CF0C  ldr      x1, [x21]
00685CF10  ldrb     w8, [x1, #0x53]
00685CF14  tbnz     w8, #5, #0x685cf88
00685CF18  mov      x0, x19
00685CF1C  bl       #0x68740d8 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCreateRandoms
00685CF20  mov      x0, x19
00685CF24  bl       #0x68741fc ; HotFix.BattleLogic.NormalSkillCreator$$CreateAngelRandoms
00685CF28  ldr      x1, [x19, #0x88]
00685CF2C  mov      x0, x19
00685CF30  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
00685CF34  ldr      x8, [x19]
00685CF38  mov      x0, x19
00685CF3C  ldr      x9, [x8, #0x2e8]
00685CF40  ldr      x1, [x8, #0x2f0]
00685CF44  blr      x9
00685CF48  tbz      w0, #0, #0x685cf9c
00685CF4C  adrp     x8, #0x8f23000
00685CF50  ldr      x8, [x8, #0xb08]
00685CF54  mov      w1, #3
00685CF58  ldr      x0, [x8]
00685CF5C  bl       #0x382bdfc ; 
00685CF60  mov      x20, x19
00685CF64  str      x0, [x20, #0x80]!
00685CF68  mov      x1, x0
00685CF6C  mov      x0, x20
00685CF70  bl       #0x382bcb8 ; 
00685CF74  ldr      x1, [x20]
00685CF78  mov      x0, x19
00685CF7C  ldp      x20, x19, [sp, #0x10]
00685CF80  ldp      x30, x21, [sp], #0x20
00685CF84  b        #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
00685CF88  ldr      x2, [x1, #0x60]
00685CF8C  mov      x0, x19
00685CF90  ldp      x20, x19, [sp, #0x10]
00685CF94  ldp      x30, x21, [sp], #0x20
00685CF98  br       x2
00685CF9C  ldp      x20, x19, [sp, #0x10]
00685CFA0  ldp      x30, x21, [sp], #0x20
00685CFA4  ret      

; HotFix.BattleLogic.NormalSkillCreator$$OnRemoveRandomSkill
; RVA 0x68743A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068743A4  stp      x30, x23, [sp, #-0x30]!
0068743A8  stp      x22, x21, [sp, #0x10]
0068743AC  stp      x20, x19, [sp, #0x20]
0068743B0  adrp     x21, #0x959b000
0068743B4  adrp     x22, #0x8f24000
0068743B8  ldrb     w8, [x21, #0xa9e]
0068743BC  ldr      x22, [x22, #0x490]
0068743C0  mov      w19, w1
0068743C4  mov      x20, x0
0068743C8  tbnz     w8, #0, #0x68743e0
0068743CC  adrp     x0, #0x8f24000
0068743D0  ldr      x0, [x0, #0x490]
0068743D4  bl       #0x382bd14 ; 
0068743D8  mov      w8, #1
0068743DC  strb     w8, [x21, #0xa9e]
0068743E0  ldr      x2, [x22]
0068743E4  ldrb     w8, [x2, #0x53]
0068743E8  tbnz     w8, #5, #0x68744a0
0068743EC  mov      x0, x20
0068743F0  mov      w1, w19
0068743F4  bl       #0x68744c4 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnRemoveRandomSkill
0068743F8  ldr      x21, [x20, #0x80]
0068743FC  cbz      x21, #0x6874444
006874400  ldr      w8, [x21, #0x18]
006874404  cmp      w8, #1
006874408  b.lt     #0x6874444
00687440C  mov      x22, xzr
006874410  add      x23, x21, #0x20
006874414  cmp      w22, w8
006874418  b.hs     #0x68744bc
00687441C  ldr      x0, [x23, x22, lsl #3]
006874420  cbz      x0, #0x68744c0
006874424  mov      w1, w19
006874428  mov      w2, wzr
00687442C  mov      x3, xzr
006874430  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006874434  ldr      w8, [x21, #0x18]
006874438  add      x22, x22, #1
00687443C  cmp      w22, w8
006874440  b.lt     #0x6874414
006874444  ldr      x20, [x20, #0x88]
006874448  cbz      x20, #0x68744c0
00687444C  ldr      w8, [x20, #0x18]
006874450  cmp      w8, #1
006874454  b.lt     #0x6874490
006874458  mov      w21, wzr
00687445C  cmp      w21, w8
006874460  b.hs     #0x68744bc
006874464  add      x8, x20, w21, sxtw #3
006874468  ldr      x0, [x8, #0x20]
00687446C  cbz      x0, #0x68744c0
006874470  mov      w1, w19
006874474  mov      w2, wzr
006874478  mov      x3, xzr
00687447C  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006874480  ldr      w8, [x20, #0x18]
006874484  add      w21, w21, #1
006874488  cmp      w21, w8
00687448C  b.lt     #0x687445c
006874490  ldp      x20, x19, [sp, #0x20]
006874494  ldp      x22, x21, [sp, #0x10]
006874498  ldp      x30, x23, [sp], #0x30
00687449C  ret      
0068744A0  ldr      x3, [x2, #0x60]
0068744A4  mov      x0, x20
0068744A8  mov      w1, w19
0068744AC  ldp      x20, x19, [sp, #0x20]
0068744B0  ldp      x22, x21, [sp, #0x10]
0068744B4  ldp      x30, x23, [sp], #0x30
0068744B8  br       x3
0068744BC  bl       #0x382bfc0 ; 
0068744C0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.NormalSkillCreator$$OnDeInit
; RVA 0x6874638; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874638  stp      x30, x21, [sp, #-0x20]!
00687463C  stp      x20, x19, [sp, #0x10]
006874640  adrp     x20, #0x959b000
006874644  adrp     x21, #0x8f24000
006874648  ldrb     w8, [x20, #0xa9f]
00687464C  ldr      x21, [x21, #0x4a0]
006874650  mov      x19, x0
006874654  tbnz     w8, #0, #0x687466c
006874658  adrp     x0, #0x8f24000
00687465C  ldr      x0, [x0, #0x4a0]
006874660  bl       #0x382bd14 ; 
006874664  mov      w8, #1
006874668  strb     w8, [x20, #0xa9f]
00687466C  ldr      x1, [x21]
006874670  ldrb     w8, [x1, #0x53]
006874674  tbnz     w8, #5, #0x68746b8
006874678  mov      x0, x19
00687467C  bl       #0x68746cc ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnDeInit
006874680  mov      x20, x19
006874684  ldr      x1, [x20, #0x80]!
006874688  cbz      x1, #0x68746a4
00687468C  mov      x0, x19
006874690  bl       #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
006874694  mov      x0, x20
006874698  mov      x1, xzr
00687469C  str      xzr, [x19, #0x80]
0068746A0  bl       #0x382bcb8 ; 
0068746A4  ldr      x1, [x19, #0x88]
0068746A8  mov      x0, x19
0068746AC  ldp      x20, x19, [sp, #0x10]
0068746B0  ldp      x30, x21, [sp], #0x20
0068746B4  b        #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
0068746B8  ldr      x2, [x1, #0x60]
0068746BC  mov      x0, x19
0068746C0  ldp      x20, x19, [sp, #0x10]
0068746C4  ldp      x30, x21, [sp], #0x20
0068746C8  br       x2

; HotFix.BattleLogic.NormalSkillCreator$$OnAddSkillFlag
; RVA 0x6874740; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874740  str      x30, [sp, #-0x30]!
006874744  stp      x22, x21, [sp, #0x10]
006874748  stp      x20, x19, [sp, #0x20]
00687474C  adrp     x21, #0x959b000
006874750  adrp     x22, #0x8f24000
006874754  ldrb     w8, [x21, #0xaa0]
006874758  ldr      x22, [x22, #0x4b0]
00687475C  mov      w19, w1
006874760  mov      x20, x0
006874764  tbnz     w8, #0, #0x687477c
006874768  adrp     x0, #0x8f24000
00687476C  ldr      x0, [x0, #0x4b0]
006874770  bl       #0x382bd14 ; 
006874774  mov      w8, #1
006874778  strb     w8, [x21, #0xaa0]
00687477C  ldr      x2, [x22]
006874780  ldrb     w8, [x2, #0x53]
006874784  tbnz     w8, #5, #0x6874854
006874788  mov      x0, x20
00687478C  mov      w1, w19
006874790  bl       #0x6874878 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddSkillFlag
006874794  ldr      x8, [x20, #0x80]
006874798  cbz      x8, #0x68747fc
00687479C  ldr      x8, [x20]
0068747A0  mov      x0, x20
0068747A4  ldr      x9, [x8, #0x2e8]
0068747A8  ldr      x1, [x8, #0x2f0]
0068747AC  blr      x9
0068747B0  tbz      w0, #0, #0x68747fc
0068747B4  ldr      x21, [x20, #0x80]
0068747B8  cbz      x21, #0x6874870
0068747BC  ldr      w8, [x21, #0x18]
0068747C0  cmp      w8, #1
0068747C4  b.lt     #0x68747fc
0068747C8  mov      w22, wzr
0068747CC  cmp      w22, w8
0068747D0  b.hs     #0x6874874
0068747D4  add      x8, x21, w22, sxtw #3
0068747D8  ldr      x0, [x8, #0x20]
0068747DC  cbz      x0, #0x6874870
0068747E0  mov      w1, w19
0068747E4  mov      x2, xzr
0068747E8  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
0068747EC  ldr      w8, [x21, #0x18]
0068747F0  add      w22, w22, #1
0068747F4  cmp      w22, w8
0068747F8  b.lt     #0x68747cc
0068747FC  ldr      x20, [x20, #0x88]
006874800  cbz      x20, #0x6874870
006874804  ldr      w8, [x20, #0x18]
006874808  cmp      w8, #1
00687480C  b.lt     #0x6874844
006874810  mov      w21, wzr
006874814  cmp      w21, w8
006874818  b.hs     #0x6874874
00687481C  add      x8, x20, w21, sxtw #3
006874820  ldr      x0, [x8, #0x20]
006874824  cbz      x0, #0x6874870
006874828  mov      w1, w19
00687482C  mov      x2, xzr
006874830  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
006874834  ldr      w8, [x20, #0x18]
006874838  add      w21, w21, #1
00687483C  cmp      w21, w8
006874840  b.lt     #0x6874814
006874844  ldp      x20, x19, [sp, #0x20]
006874848  ldp      x22, x21, [sp, #0x10]
00687484C  ldr      x30, [sp], #0x30
006874850  ret      
006874854  ldr      x3, [x2, #0x60]
006874858  mov      x0, x20
00687485C  mov      w1, w19
006874860  ldp      x20, x19, [sp, #0x20]
006874864  ldp      x22, x21, [sp, #0x10]
006874868  ldr      x30, [sp], #0x30
00687486C  br       x3
006874870  bl       #0x382bfb8 ; 
006874874  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.NormalSkillCreator$$OnAddRejectFlag
; RVA 0x6874984; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874984  str      x30, [sp, #-0x30]!
006874988  stp      x22, x21, [sp, #0x10]
00687498C  stp      x20, x19, [sp, #0x20]
006874990  adrp     x21, #0x959b000
006874994  adrp     x22, #0x8f24000
006874998  ldrb     w8, [x21, #0xaa1]
00687499C  ldr      x22, [x22, #0x4c0]
0068749A0  mov      w19, w1
0068749A4  mov      x20, x0
0068749A8  tbnz     w8, #0, #0x68749c0
0068749AC  adrp     x0, #0x8f24000
0068749B0  ldr      x0, [x0, #0x4c0]
0068749B4  bl       #0x382bd14 ; 
0068749B8  mov      w8, #1
0068749BC  strb     w8, [x21, #0xaa1]
0068749C0  ldr      x2, [x22]
0068749C4  ldrb     w8, [x2, #0x53]
0068749C8  tbnz     w8, #5, #0x6874a98
0068749CC  mov      x0, x20
0068749D0  mov      w1, w19
0068749D4  bl       #0x6874abc ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectFlag
0068749D8  ldr      x8, [x20, #0x80]
0068749DC  cbz      x8, #0x6874a40
0068749E0  ldr      x8, [x20]
0068749E4  mov      x0, x20
0068749E8  ldr      x9, [x8, #0x2e8]
0068749EC  ldr      x1, [x8, #0x2f0]
0068749F0  blr      x9
0068749F4  tbz      w0, #0, #0x6874a40
0068749F8  ldr      x21, [x20, #0x80]
0068749FC  cbz      x21, #0x6874ab4
006874A00  ldr      w8, [x21, #0x18]
006874A04  cmp      w8, #1
006874A08  b.lt     #0x6874a40
006874A0C  mov      w22, wzr
006874A10  cmp      w22, w8
006874A14  b.hs     #0x6874ab8
006874A18  add      x8, x21, w22, sxtw #3
006874A1C  ldr      x0, [x8, #0x20]
006874A20  cbz      x0, #0x6874ab4
006874A24  mov      w1, w19
006874A28  mov      x2, xzr
006874A2C  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874A30  ldr      w8, [x21, #0x18]
006874A34  add      w22, w22, #1
006874A38  cmp      w22, w8
006874A3C  b.lt     #0x6874a10
006874A40  ldr      x20, [x20, #0x88]
006874A44  cbz      x20, #0x6874ab4
006874A48  ldr      w8, [x20, #0x18]
006874A4C  cmp      w8, #1
006874A50  b.lt     #0x6874a88
006874A54  mov      w21, wzr
006874A58  cmp      w21, w8
006874A5C  b.hs     #0x6874ab8
006874A60  add      x8, x20, w21, sxtw #3
006874A64  ldr      x0, [x8, #0x20]
006874A68  cbz      x0, #0x6874ab4
006874A6C  mov      w1, w19
006874A70  mov      x2, xzr
006874A74  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006874A78  ldr      w8, [x20, #0x18]
006874A7C  add      w21, w21, #1
006874A80  cmp      w21, w8
006874A84  b.lt     #0x6874a58
006874A88  ldp      x20, x19, [sp, #0x20]
006874A8C  ldp      x22, x21, [sp, #0x10]
006874A90  ldr      x30, [sp], #0x30
006874A94  ret      
006874A98  ldr      x3, [x2, #0x60]
006874A9C  mov      x0, x20
006874AA0  mov      w1, w19
006874AA4  ldp      x20, x19, [sp, #0x20]
006874AA8  ldp      x22, x21, [sp, #0x10]
006874AAC  ldr      x30, [sp], #0x30
006874AB0  br       x3
006874AB4  bl       #0x382bfb8 ; 
006874AB8  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.NormalSkillCreator$$OnCheckNeedSkills
; RVA 0x6865D44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006865D44  str      x30, [sp, #-0x30]!
006865D48  stp      x22, x21, [sp, #0x10]
006865D4C  stp      x20, x19, [sp, #0x20]
006865D50  adrp     x21, #0x959b000
006865D54  adrp     x22, #0x8f23000
006865D58  ldrb     w8, [x21, #0xaa2]
006865D5C  ldr      x22, [x22, #0xdf0]
006865D60  mov      w19, w1
006865D64  mov      x20, x0
006865D68  tbnz     w8, #0, #0x6865d80
006865D6C  adrp     x0, #0x8f23000
006865D70  ldr      x0, [x0, #0xdf0]
006865D74  bl       #0x382bd14 ; 
006865D78  mov      w8, #1
006865D7C  strb     w8, [x21, #0xaa2]
006865D80  ldr      x2, [x22]
006865D84  ldrb     w8, [x2, #0x53]
006865D88  tbnz     w8, #5, #0x6865e58
006865D8C  mov      x0, x20
006865D90  mov      w1, w19
006865D94  bl       #0x6874bc8 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCheckNeedSkills
006865D98  ldr      x8, [x20, #0x80]
006865D9C  cbz      x8, #0x6865e00
006865DA0  ldr      x8, [x20]
006865DA4  mov      x0, x20
006865DA8  ldr      x9, [x8, #0x2e8]
006865DAC  ldr      x1, [x8, #0x2f0]
006865DB0  blr      x9
006865DB4  tbz      w0, #0, #0x6865e00
006865DB8  ldr      x21, [x20, #0x80]
006865DBC  cbz      x21, #0x6865e74
006865DC0  ldr      w8, [x21, #0x18]
006865DC4  cmp      w8, #1
006865DC8  b.lt     #0x6865e00
006865DCC  mov      w22, wzr
006865DD0  cmp      w22, w8
006865DD4  b.hs     #0x6865e78
006865DD8  add      x8, x21, w22, sxtw #3
006865DDC  ldr      x0, [x8, #0x20]
006865DE0  cbz      x0, #0x6865e74
006865DE4  mov      w1, w19
006865DE8  mov      x2, xzr
006865DEC  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006865DF0  ldr      w8, [x21, #0x18]
006865DF4  add      w22, w22, #1
006865DF8  cmp      w22, w8
006865DFC  b.lt     #0x6865dd0
006865E00  ldr      x20, [x20, #0x88]
006865E04  cbz      x20, #0x6865e74
006865E08  ldr      w8, [x20, #0x18]
006865E0C  cmp      w8, #1
006865E10  b.lt     #0x6865e48
006865E14  mov      w21, wzr
006865E18  cmp      w21, w8
006865E1C  b.hs     #0x6865e78
006865E20  add      x8, x20, w21, sxtw #3
006865E24  ldr      x0, [x8, #0x20]
006865E28  cbz      x0, #0x6865e74
006865E2C  mov      w1, w19
006865E30  mov      x2, xzr
006865E34  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006865E38  ldr      w8, [x20, #0x18]
006865E3C  add      w21, w21, #1
006865E40  cmp      w21, w8
006865E44  b.lt     #0x6865e18
006865E48  ldp      x20, x19, [sp, #0x20]
006865E4C  ldp      x22, x21, [sp, #0x10]
006865E50  ldr      x30, [sp], #0x30
006865E54  ret      
006865E58  ldr      x3, [x2, #0x60]
006865E5C  mov      x0, x20
006865E60  mov      w1, w19
006865E64  ldp      x20, x19, [sp, #0x20]
006865E68  ldp      x22, x21, [sp, #0x10]
006865E6C  ldr      x30, [sp], #0x30
006865E70  br       x3
006865E74  bl       #0x382bfb8 ; 
006865E78  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.NormalSkillCreator$$OnAddRejectSkills
; RVA 0x6874CF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874CF4  str      x30, [sp, #-0x30]!
006874CF8  stp      x22, x21, [sp, #0x10]
006874CFC  stp      x20, x19, [sp, #0x20]
006874D00  adrp     x21, #0x959b000
006874D04  adrp     x22, #0x8f24000
006874D08  ldrb     w8, [x21, #0xaa3]
006874D0C  ldr      x22, [x22, #0x4d8]
006874D10  mov      x19, x1
006874D14  mov      x20, x0
006874D18  tbnz     w8, #0, #0x6874d30
006874D1C  adrp     x0, #0x8f24000
006874D20  ldr      x0, [x0, #0x4d8]
006874D24  bl       #0x382bd14 ; 
006874D28  mov      w8, #1
006874D2C  strb     w8, [x21, #0xaa3]
006874D30  ldr      x2, [x22]
006874D34  ldrb     w8, [x2, #0x53]
006874D38  tbnz     w8, #5, #0x6874e08
006874D3C  mov      x0, x20
006874D40  mov      x1, x19
006874D44  bl       #0x6874e2c ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectSkills
006874D48  ldr      x8, [x20, #0x80]
006874D4C  cbz      x8, #0x6874db0
006874D50  ldr      x8, [x20]
006874D54  mov      x0, x20
006874D58  ldr      x9, [x8, #0x2e8]
006874D5C  ldr      x1, [x8, #0x2f0]
006874D60  blr      x9
006874D64  tbz      w0, #0, #0x6874db0
006874D68  ldr      x21, [x20, #0x80]
006874D6C  cbz      x21, #0x6874e24
006874D70  ldr      w8, [x21, #0x18]
006874D74  cmp      w8, #1
006874D78  b.lt     #0x6874db0
006874D7C  mov      w22, wzr
006874D80  cmp      w22, w8
006874D84  b.hs     #0x6874e28
006874D88  add      x8, x21, w22, sxtw #3
006874D8C  ldr      x0, [x8, #0x20]
006874D90  cbz      x0, #0x6874e24
006874D94  mov      x1, x19
006874D98  mov      x2, xzr
006874D9C  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874DA0  ldr      w8, [x21, #0x18]
006874DA4  add      w22, w22, #1
006874DA8  cmp      w22, w8
006874DAC  b.lt     #0x6874d80
006874DB0  ldr      x20, [x20, #0x88]
006874DB4  cbz      x20, #0x6874e24
006874DB8  ldr      w8, [x20, #0x18]
006874DBC  cmp      w8, #1
006874DC0  b.lt     #0x6874df8
006874DC4  mov      w21, wzr
006874DC8  cmp      w21, w8
006874DCC  b.hs     #0x6874e28
006874DD0  add      x8, x20, w21, sxtw #3
006874DD4  ldr      x0, [x8, #0x20]
006874DD8  cbz      x0, #0x6874e24
006874DDC  mov      x1, x19
006874DE0  mov      x2, xzr
006874DE4  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874DE8  ldr      w8, [x20, #0x18]
006874DEC  add      w21, w21, #1
006874DF0  cmp      w21, w8
006874DF4  b.lt     #0x6874dc8
006874DF8  ldp      x20, x19, [sp, #0x20]
006874DFC  ldp      x22, x21, [sp, #0x10]
006874E00  ldr      x30, [sp], #0x30
006874E04  ret      
006874E08  ldr      x3, [x2, #0x60]
006874E0C  mov      x0, x20
006874E10  mov      x1, x19
006874E14  ldp      x20, x19, [sp, #0x20]
006874E18  ldp      x22, x21, [sp, #0x10]
006874E1C  ldr      x30, [sp], #0x30
006874E20  br       x3
006874E24  bl       #0x382bfb8 ; 
006874E28  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.NormalSkillCreator$$CreateAngelRandoms
; RVA 0x68741FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068741FC  str      x30, [sp, #-0x60]!
006874200  stp      x28, x27, [sp, #0x10]
006874204  stp      x26, x25, [sp, #0x20]
006874208  stp      x24, x23, [sp, #0x30]
00687420C  stp      x22, x21, [sp, #0x40]
006874210  stp      x20, x19, [sp, #0x50]
006874214  adrp     x20, #0x959b000
006874218  adrp     x21, #0x8f24000
00687421C  ldrb     w8, [x20, #0xaa4]
006874220  ldr      x21, [x21, #0x488]
006874224  mov      x19, x0
006874228  tbnz     w8, #0, #0x6874258
00687422C  adrp     x0, #0x8ee8000
006874230  ldr      x0, [x0, #0x898]
006874234  bl       #0x382bd14 ; 
006874238  adrp     x0, #0x8f24000
00687423C  ldr      x0, [x0, #0x488]
006874240  bl       #0x382bd14 ; 
006874244  adrp     x0, #0x8f23000
006874248  ldr      x0, [x0, #0xb20]
00687424C  bl       #0x382bd14 ; 
006874250  mov      w8, #1
006874254  strb     w8, [x20, #0xaa4]
006874258  ldr      x1, [x21]
00687425C  ldrb     w8, [x1, #0x53]
006874260  tbnz     w8, #5, #0x6874350
006874264  adrp     x23, #0x8ee8000
006874268  adrp     x24, #0x8f23000
00687426C  adrp     x20, #0x8ee5000
006874270  ldr      x23, [x23, #0x898]
006874274  ldr      x24, [x24, #0xb20]
006874278  ldr      x20, [x20, #0xb30]
00687427C  mov      x22, xzr
006874280  mov      w25, #0x20
006874284  adrp     x26, #0x9591000
006874288  mov      w27, #1
00687428C  ldr      x0, [x23]
006874290  ldr      w8, [x0, #0xe0]
006874294  cbnz     w8, #0x68742a0
006874298  bl       #0x382be8c ; 
00687429C  ldr      x0, [x23]
0068742A0  ldr      x8, [x0, #0xb8]
0068742A4  ldrsw    x8, [x8, #0x2f0]
0068742A8  cmp      x22, x8
0068742AC  b.ge     #0x6874374
0068742B0  ldr      x28, [x19, #0x78]
0068742B4  mov      x0, x19
0068742B8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068742BC  cbz      x0, #0x6874390
0068742C0  ldrb     w8, [x26, #0xa4c]
0068742C4  mov      x21, x0
0068742C8  cbnz     w8, #0x68742d8
0068742CC  mov      x0, x20
0068742D0  bl       #0x382bd14 ; 
0068742D4  strb     w27, [x26, #0xa4c]
0068742D8  ldr      x1, [x20]
0068742DC  ldrb     w8, [x1, #0x53]
0068742E0  tbnz     w8, #5, #0x68742ec
0068742E4  ldr      x0, [x21, #0x210]
0068742E8  b        #0x68742f8 ; 
0068742EC  ldr      x8, [x1, #0x60]
0068742F0  mov      x0, x21
0068742F4  blr      x8
0068742F8  cbz      x0, #0x6874390
0068742FC  ldr      x1, [x24]
006874300  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
006874304  cbz      x28, #0x6874390
006874308  mov      x21, x0
00687430C  cbz      x0, #0x6874324
006874310  ldr      x8, [x28]
006874314  mov      x0, x21
006874318  ldr      x1, [x8, #0x40]
00687431C  bl       #0x382be90 ; 
006874320  cbz      x0, #0x6874398
006874324  ldr      w8, [x28, #0x18]
006874328  cmp      x22, x8
00687432C  b.hs     #0x6874394
006874330  add      x8, x28, x22, lsl #3
006874334  add      x0, x28, x25
006874338  mov      x1, x21
00687433C  str      x21, [x8, #0x20]
006874340  bl       #0x382bcb8 ; 
006874344  add      x22, x22, #1
006874348  add      x25, x25, #8
00687434C  b        #0x687428c ; 
006874350  ldr      x2, [x1, #0x60]
006874354  mov      x0, x19
006874358  ldp      x20, x19, [sp, #0x50]
00687435C  ldp      x22, x21, [sp, #0x40]
006874360  ldp      x24, x23, [sp, #0x30]
006874364  ldp      x26, x25, [sp, #0x20]
006874368  ldp      x28, x27, [sp, #0x10]
00687436C  ldr      x30, [sp], #0x60
006874370  br       x2
006874374  ldp      x20, x19, [sp, #0x50]
006874378  ldp      x22, x21, [sp, #0x40]
00687437C  ldp      x24, x23, [sp, #0x30]
006874380  ldp      x26, x25, [sp, #0x20]
006874384  ldp      x28, x27, [sp, #0x10]
006874388  ldr      x30, [sp], #0x60
00687438C  ret      
006874390  bl       #0x382bfb8 ; 
006874394  bl       #0x382bfc0 ; 
006874398  bl       #0x382bfdc ; 
00687439C  mov      x1, xzr
0068743A0  bl       #0x382be7c ; 

; HotFix.BattleLogic.NormalSkillCreator$$OnInitRandomSkill
; RVA 0x6874F38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874F38  stp      x29, x30, [sp, #-0x60]!
006874F3C  stp      x28, x27, [sp, #0x10]
006874F40  stp      x26, x25, [sp, #0x20]
006874F44  stp      x24, x23, [sp, #0x30]
006874F48  stp      x22, x21, [sp, #0x40]
006874F4C  stp      x20, x19, [sp, #0x50]
006874F50  adrp     x22, #0x959b000
006874F54  adrp     x23, #0x8f24000
006874F58  ldrb     w8, [x22, #0xaa5]
006874F5C  ldr      x23, [x23, #0x4e8]
006874F60  mov      x20, x2
006874F64  mov      w19, w1
006874F68  mov      x21, x0
006874F6C  tbnz     w8, #0, #0x6874fb4
006874F70  adrp     x0, #0x8ebf000
006874F74  ldr      x0, [x0, #0x4e8]
006874F78  bl       #0x382bd14 ; 
006874F7C  adrp     x0, #0x8f24000
006874F80  ldr      x0, [x0, #0x4f0]
006874F84  bl       #0x382bd14 ; 
006874F88  adrp     x0, #0x8f24000
006874F8C  ldr      x0, [x0, #0x4f8]
006874F90  bl       #0x382bd14 ; 
006874F94  adrp     x0, #0x8ebf000
006874F98  ldr      x0, [x0, #0x4f0]
006874F9C  bl       #0x382bd14 ; 
006874FA0  adrp     x0, #0x8f24000
006874FA4  ldr      x0, [x0, #0x4e8]
006874FA8  bl       #0x382bd14 ; 
006874FAC  mov      w8, #1
006874FB0  strb     w8, [x22, #0xaa5]
006874FB4  ldr      x3, [x23]
006874FB8  ldrb     w8, [x3, #0x53]
006874FBC  tbnz     w8, #5, #0x6875010
006874FC0  mov      x0, x21
006874FC4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006874FC8  cbz      x0, #0x6875360
006874FCC  adrp     x8, #0x9598000
006874FD0  ldrb     w8, [x8, #0xfcc]
006874FD4  mov      x19, x0
006874FD8  cbnz     w8, #0x6874ff4
006874FDC  adrp     x0, #0x8f06000
006874FE0  ldr      x0, [x0, #0x470]
006874FE4  bl       #0x382bd14 ; 
006874FE8  mov      w8, #1
006874FEC  adrp     x9, #0x9598000
006874FF0  strb     w8, [x9, #0xfcc]
006874FF4  adrp     x8, #0x8f06000
006874FF8  ldr      x8, [x8, #0x470]
006874FFC  ldr      x1, [x8]
006875000  ldrb     w8, [x1, #0x53]
006875004  tbnz     w8, #5, #0x687503c
006875008  ldr      x0, [x19, #0x200]
00687500C  b        #0x6875048 ; 
006875010  ldr      x4, [x3, #0x60]
006875014  mov      x0, x21
006875018  mov      w1, w19
00687501C  mov      x2, x20
006875020  ldp      x20, x19, [sp, #0x50]
006875024  ldp      x22, x21, [sp, #0x40]
006875028  ldp      x24, x23, [sp, #0x30]
00687502C  ldp      x26, x25, [sp, #0x20]
006875030  ldp      x28, x27, [sp, #0x10]
006875034  ldp      x29, x30, [sp], #0x60
006875038  br       x4
00687503C  ldr      x8, [x1, #0x60]
006875040  mov      x0, x19
006875044  blr      x8
006875048  cbz      x0, #0x6875360
00687504C  mov      x1, xzr
006875050  bl       #0x64d6c0c ; LocalModels.LocalModelManager$$GetSkillGroup_AngelElements
006875054  cbz      x0, #0x6875360
006875058  adrp     x10, #0x8f24000
00687505C  ldr      x8, [x0]
006875060  ldr      x10, [x10, #0x4f0]
006875064  mov      x19, x0
006875068  ldrh     w9, [x8, #0x12e]
00687506C  ldr      x1, [x10]
006875070  cbz      x9, #0x6875094
006875074  ldr      x10, [x8, #0xb0]
006875078  add      x10, x10, #8
00687507C  ldur     x11, [x10, #-8]
006875080  cmp      x11, x1
006875084  b.eq     #0x68750a4
006875088  subs     x9, x9, #1
00687508C  add      x10, x10, #0x10
006875090  b.ne     #0x687507c
006875094  mov      x0, x19
006875098  mov      w2, wzr
00687509C  bl       #0x3a7e710 ; 
0068750A0  b        #0x68750b0 ; 
0068750A4  ldrsw    x9, [x10]
0068750A8  add      x8, x8, x9, lsl #4
0068750AC  add      x0, x8, #0x138
0068750B0  ldp      x8, x1, [x0]
0068750B4  mov      x0, x19
0068750B8  blr      x8
0068750BC  mov      x19, x0
0068750C0  cbz      x0, #0x6875364
0068750C4  adrp     x23, #0x8f24000
0068750C8  adrp     x24, #0x8f23000
0068750CC  ldr      x23, [x23, #0x500]
0068750D0  ldr      x24, [x24, #0xa10]
0068750D4  mov      w29, #1
0068750D8  adrp     x28, #0x959b000
0068750DC  adrp     x27, #0x959b000
0068750E0  ldr      x8, [x19]
0068750E4  adrp     x10, #0x8ebf000
0068750E8  ldrh     w9, [x8, #0x12e]
0068750EC  ldr      x10, [x10, #0x4f0]
0068750F0  ldr      x1, [x10]
0068750F4  cbz      x9, #0x6875118
0068750F8  ldr      x10, [x8, #0xb0]
0068750FC  add      x10, x10, #8
006875100  ldur     x11, [x10, #-8]
006875104  cmp      x11, x1
006875108  b.eq     #0x6875128
00687510C  subs     x9, x9, #1
006875110  add      x10, x10, #0x10
006875114  b.ne     #0x6875100
006875118  mov      x0, x19
00687511C  mov      w2, wzr
006875120  bl       #0x3a7e710 ; 
006875124  b        #0x6875134 ; 
006875128  ldrsw    x9, [x10]
00687512C  add      x8, x8, x9, lsl #4
006875130  add      x0, x8, #0x138
006875134  ldp      x8, x1, [x0]
006875138  mov      x0, x19
00687513C  blr      x8
006875140  tbz      w0, #0, #0x68752c0
006875144  ldr      x8, [x19]
006875148  adrp     x10, #0x8f24000
00687514C  ldrh     w9, [x8, #0x12e]
006875150  ldr      x10, [x10, #0x4f8]
006875154  ldr      x1, [x10]
006875158  cbz      x9, #0x687517c
00687515C  ldr      x10, [x8, #0xb0]
006875160  add      x10, x10, #8
006875164  ldur     x11, [x10, #-8]
006875168  cmp      x11, x1
00687516C  b.eq     #0x687518c
006875170  subs     x9, x9, #1
006875174  add      x10, x10, #0x10
006875178  b.ne     #0x6875164
00687517C  mov      x0, x19
006875180  mov      w2, wzr
006875184  bl       #0x3a7e710 ; 
006875188  b        #0x6875198 ; 
00687518C  ldrsw    x9, [x10]
006875190  add      x8, x8, x9, lsl #4
006875194  add      x0, x8, #0x138
006875198  ldp      x8, x1, [x0]
00687519C  mov      x0, x19
0068751A0  blr      x8
0068751A4  mov      x25, x0
0068751A8  mov      x0, x21
0068751AC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068751B0  mov      x26, x0
0068751B4  cbz      x0, #0x6875354
0068751B8  adrp     x8, #0x9598000
0068751BC  ldrb     w8, [x8, #0xfcc]
0068751C0  cbnz     w8, #0x68751d8
0068751C4  adrp     x0, #0x8f06000
0068751C8  ldr      x0, [x0, #0x470]
0068751CC  bl       #0x382bd14 ; 
0068751D0  adrp     x8, #0x9598000
0068751D4  strb     w29, [x8, #0xfcc]
0068751D8  adrp     x8, #0x8f06000
0068751DC  ldr      x8, [x8, #0x470]
0068751E0  ldr      x1, [x8]
0068751E4  ldrb     w8, [x1, #0x53]
0068751E8  tbnz     w8, #5, #0x68751f4
0068751EC  ldr      x26, [x26, #0x200]
0068751F0  b        #0x6875204 ; 
0068751F4  ldr      x8, [x1, #0x60]
0068751F8  mov      x0, x26
0068751FC  blr      x8
006875200  mov      x26, x0
006875204  cbz      x25, #0x6875358
006875208  ldrb     w8, [x28, #0xbb7]
00687520C  cbnz     w8, #0x687521c
006875210  mov      x0, x23
006875214  bl       #0x382bd14 ; 
006875218  strb     w29, [x28, #0xbb7]
00687521C  ldr      x1, [x23]
006875220  ldrb     w8, [x1, #0x53]
006875224  tbnz     w8, #5, #0x6875230
006875228  ldr      w1, [x25, #0x24]
00687522C  b        #0x6875240 ; 
006875230  ldr      x8, [x1, #0x60]
006875234  mov      x0, x25
006875238  blr      x8
00687523C  mov      w1, w0
006875240  cbz      x26, #0x687534c
006875244  mov      x0, x26
006875248  mov      x2, xzr
00687524C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006875250  mov      x26, x0
006875254  cbz      x0, #0x6875350
006875258  ldrb     w8, [x27, #0xb7f]
00687525C  ldr      x22, [x21, #0x78]
006875260  cbnz     w8, #0x6875270
006875264  mov      x0, x24
006875268  bl       #0x382bd14 ; 
00687526C  strb     w29, [x27, #0xb7f]
006875270  ldr      x1, [x24]
006875274  ldrb     w8, [x1, #0x53]
006875278  tbnz     w8, #5, #0x6875284
00687527C  ldr      w0, [x26, #0x30]
006875280  b        #0x6875290 ; 
006875284  ldr      x8, [x1, #0x60]
006875288  mov      x0, x26
00687528C  blr      x8
006875290  cbz      x22, #0x6875348
006875294  ldr      w9, [x22, #0x18]
006875298  sub      w8, w0, #1
00687529C  cmp      w8, w9
0068752A0  b.hs     #0x687535c
0068752A4  add      x8, x22, w8, sxtw #3
0068752A8  ldr      x1, [x8, #0x20]
0068752AC  mov      x0, x21
0068752B0  mov      x2, x25
0068752B4  mov      x3, x20
0068752B8  bl       #0x6872808 ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToRandom
0068752BC  b        #0x68750e0 ; 
0068752C0  mov      x21, xzr
0068752C4  cbz      x19, #0x6875328
0068752C8  adrp     x10, #0x8ebf000
0068752CC  ldr      x8, [x19]
0068752D0  ldr      x10, [x10, #0x4e8]
0068752D4  ldrh     w9, [x8, #0x12e]
0068752D8  ldr      x1, [x10]
0068752DC  cbz      x9, #0x6875300
0068752E0  ldr      x10, [x8, #0xb0]
0068752E4  add      x10, x10, #8
0068752E8  ldur     x11, [x10, #-8]
0068752EC  cmp      x11, x1
0068752F0  b.eq     #0x6875310
0068752F4  subs     x9, x9, #1
0068752F8  add      x10, x10, #0x10
0068752FC  b.ne     #0x68752e8
006875300  mov      x0, x19
006875304  mov      w2, wzr
006875308  bl       #0x3a7e710 ; 
00687530C  b        #0x687531c ; 
006875310  ldrsw    x9, [x10]
006875314  add      x8, x8, x9, lsl #4
006875318  add      x0, x8, #0x138
00687531C  ldp      x8, x1, [x0]
006875320  mov      x0, x19
006875324  blr      x8
006875328  cbnz     x21, #0x6875368
00687532C  ldp      x20, x19, [sp, #0x50]
006875330  ldp      x22, x21, [sp, #0x40]
006875334  ldp      x24, x23, [sp, #0x30]
006875338  ldp      x26, x25, [sp, #0x20]
00687533C  ldp      x28, x27, [sp, #0x10]
006875340  ldp      x29, x30, [sp], #0x60
006875344  ret      
006875348  bl       #0x382bfb8 ; 
00687534C  bl       #0x382bfb8 ; 
006875350  bl       #0x382bfb8 ; 
006875354  bl       #0x382bfb8 ; 
006875358  bl       #0x382bfb8 ; 
00687535C  bl       #0x382bfc0 ; 
006875360  bl       #0x382bfb8 ; 
006875364  bl       #0x382bfb8 ; 
006875368  mov      x0, x21
00687536C  bl       #0x382bfb0 ; 
006875370  b        #0x68753a8 ; 
006875374  b        #0x68753a8 ; 
006875378  b        #0x68753a8 ; 
00687537C  b        #0x68753a8 ; 
006875380  b        #0x68753a8 ; 
006875384  b        #0x68753a8 ; 
006875388  b        #0x68753a8 ; 
00687538C  b        #0x68753a8 ; 
006875390  b        #0x68753a8 ; 
006875394  b        #0x68753a8 ; 
006875398  b        #0x68753a8 ; 
00687539C  b        #0x68753a8 ; 
0068753A0  b        #0x68753a8 ; 
0068753A4  b        #0x68753a8 ; 
0068753A8  mov      x20, x0
0068753AC  cmp      w1, #1
0068753B0  b.ne     #0x68753c8
0068753B4  mov      x0, x20
0068753B8  bl       #0x89eda50 ; 
0068753BC  ldr      x21, [x0]
0068753C0  bl       #0x89eda60 ; 
0068753C4  b        #0x68752c4 ; 
0068753C8  mov      x21, xzr
0068753CC  b        #0x68753d4 ; 
0068753D0  mov      x20, x0
0068753D4  cbz      x19, #0x6875438
0068753D8  adrp     x10, #0x8ebf000
0068753DC  ldr      x8, [x19]
0068753E0  ldr      x10, [x10, #0x4e8]
0068753E4  ldrh     w9, [x8, #0x12e]
0068753E8  ldr      x1, [x10]
0068753EC  cbz      x9, #0x6875410
0068753F0  ldr      x10, [x8, #0xb0]
0068753F4  add      x10, x10, #8
0068753F8  ldur     x11, [x10, #-8]
0068753FC  cmp      x11, x1
006875400  b.eq     #0x6875420
006875404  subs     x9, x9, #1
006875408  add      x10, x10, #0x10
00687540C  b.ne     #0x68753f8
006875410  mov      x0, x19
006875414  mov      w2, wzr
006875418  bl       #0x3a7e710 ; 
00687541C  b        #0x687542c ; 
006875420  ldrsw    x9, [x10]
006875424  add      x8, x8, x9, lsl #4
006875428  add      x0, x8, #0x138
00687542C  ldp      x8, x1, [x0]
006875430  mov      x0, x19
006875434  blr      x8
006875438  cbnz     x21, #0x6875444
00687543C  mov      x0, x20
006875440  bl       #0x3b56bfc ; 
006875444  mov      x0, x21
006875448  bl       #0x382bfb0 ; 
00687544C  bl       #0x3442448 ; 

; HotFix.BattleLogic.NormalSkillCreator$$.ctor
; RVA 0x6866460; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006866460  stp      x30, x21, [sp, #-0x20]!
006866464  stp      x20, x19, [sp, #0x10]
006866468  adrp     x20, #0x959b000
00686646C  adrp     x21, #0x8f23000
006866470  ldrb     w8, [x20, #0xaa6]
006866474  ldr      x21, [x21, #0xe28]
006866478  mov      x19, x0
00686647C  tbnz     w8, #0, #0x68664ac
006866480  adrp     x0, #0x8ee8000
006866484  ldr      x0, [x0, #0x898]
006866488  bl       #0x382bd14 ; 
00686648C  adrp     x0, #0x8f23000
006866490  ldr      x0, [x0, #0xe28]
006866494  bl       #0x382bd14 ; 
006866498  adrp     x0, #0x8f23000
00686649C  ldr      x0, [x0, #0xb08]
0068664A0  bl       #0x382bd14 ; 
0068664A4  mov      w8, #1
0068664A8  strb     w8, [x20, #0xaa6]
0068664AC  ldr      x1, [x21]
0068664B0  ldrb     w8, [x1, #0x53]
0068664B4  tbnz     w8, #5, #0x6866528
0068664B8  adrp     x21, #0x8ee8000
0068664BC  ldr      x21, [x21, #0x898]
0068664C0  adrp     x20, #0x8f23000
0068664C4  ldr      x0, [x21]
0068664C8  ldr      w8, [x0, #0xe0]
0068664CC  ldr      x20, [x20, #0xb08]
0068664D0  cbnz     w8, #0x68664dc
0068664D4  bl       #0x382be8c ; 
0068664D8  ldr      x0, [x21]
0068664DC  ldr      x8, [x0, #0xb8]
0068664E0  ldr      x0, [x20]
0068664E4  ldr      w1, [x8, #0x2f0]
0068664E8  bl       #0x382bdfc ; 
0068664EC  mov      x1, x0
0068664F0  mov      x0, x19
0068664F4  str      x1, [x0, #0x78]!
0068664F8  bl       #0x382bcb8 ; 
0068664FC  ldr      x0, [x20]
006866500  mov      w1, #3
006866504  bl       #0x382bdfc ; 
006866508  mov      x1, x0
00686650C  mov      x0, x19
006866510  str      x1, [x0, #0x88]!
006866514  bl       #0x382bcb8 ; 
006866518  mov      x0, x19
00686651C  ldp      x20, x19, [sp, #0x10]
006866520  ldp      x30, x21, [sp], #0x20
006866524  b        #0x685cb68 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$.ctor
006866528  ldr      x2, [x1, #0x60]
00686652C  mov      x0, x19
006866530  ldp      x20, x19, [sp, #0x10]
006866534  ldp      x30, x21, [sp], #0x20
006866538  br       x2

