; HotFix.BattleLogic.NormalSkillCreator$$AngelRandomSkillQuality
; RVA 0x68730F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068730F0  stp      x30, x23, [sp, #-0x30]!
0068730F4  stp      x22, x21, [sp, #0x10]
0068730F8  stp      x20, x19, [sp, #0x20]
0068730FC  adrp     x20, #0x959b000
006873100  adrp     x21, #0x8f24000
006873104  ldrb     w8, [x20, #0xa95]
006873108  ldr      x21, [x21, #0x430] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.AngelRandomSkillQuality() @ 0x9295e68
00687310C  mov      x19, x0
006873110  tbnz     w8, #0, #0x6873134
006873114  adrp     x0, #0x8ee8000
006873118  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00687311C  bl       #0x382bd14 ; 
006873120  adrp     x0, #0x8f24000
006873124  ldr      x0, [x0, #0x430] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.AngelRandomSkillQuality() @ 0x9295e68
006873128  bl       #0x382bd14 ; 
00687312C  mov      w8, #1
006873130  strb     w8, [x20, #0xa95]
006873134  ldr      x1, [x21]
006873138  ldrb     w8, [x1, #0x53]
00687313C  tbnz     w8, #5, #0x68731b0
006873140  adrp     x21, #0x8ee8000
006873144  ldr      x21, [x21, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
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
0068731EC  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
0068731F0  bl       #0x382bd14 ; 
0068731F4  mov      w8, #1
0068731F8  strb     w8, [x23, #0xac6]
0068731FC  adrp     x8, #0x8f0d000
006873200  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006873204  ldr      x3, [x8]
006873208  ldrb     w8, [x3, #0x53]
00687320C  tbnz     w8, #5, #0x687324c
006873210  adrp     x22, #0x9599000
006873214  ldrb     w8, [x22, #0xac7]
006873218  cbnz     w8, #0x6873230
00687321C  adrp     x0, #0x8f0d000
006873220  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006873224  bl       #0x382bd14 ; 
006873228  mov      w8, #1
00687322C  strb     w8, [x22, #0xac7]
006873230  adrp     x8, #0x8f0d000
006873234  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
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

