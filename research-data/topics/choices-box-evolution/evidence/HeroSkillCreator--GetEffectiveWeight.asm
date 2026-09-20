; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
; RVA 0x6863690; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006863690  str      x30, [sp, #-0x30]!
006863694  stp      x22, x21, [sp, #0x10]
006863698  stp      x20, x19, [sp, #0x20]
00686369C  adrp     x21, #0x959b000
0068636A0  adrp     x22, #0x8f23000
0068636A4  ldrb     w8, [x21, #0xa82]
0068636A8  ldr      x22, [x22, #0xd50] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.GetEffectiveWeight() @ 0x927fe48
0068636AC  mov      x19, x1
0068636B0  mov      x20, x0
0068636B4  tbnz     w8, #0, #0x68636e4
0068636B8  adrp     x0, #0x8efd000
0068636BC  ldr      x0, [x0, #0x3b0] ; GLOBAL LocalModels.Bean.Chapter_MainChapter_TypeInfo @ 0x91e2ae8
0068636C0  bl       #0x382bd14 ; 
0068636C4  adrp     x0, #0x8f23000
0068636C8  ldr      x0, [x0, #0xd50] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.GetEffectiveWeight() @ 0x927fe48
0068636CC  bl       #0x382bd14 ; 
0068636D0  adrp     x0, #0x8f23000
0068636D4  ldr      x0, [x0, #0xa08] ; GLOBAL LocalModels.Bean.ISkillGroup_TypeInfo @ 0x91ea558
0068636D8  bl       #0x382bd14 ; 
0068636DC  mov      w8, #1
0068636E0  strb     w8, [x21, #0xa82]
0068636E4  ldr      x2, [x22]
0068636E8  ldrb     w8, [x2, #0x53]
0068636EC  tbnz     w8, #5, #0x6863784
0068636F0  mov      x0, x20
0068636F4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068636F8  cbz      x0, #0x686384c
0068636FC  ldr      x0, [x0, #0x3b8]
006863700  cbz      x0, #0x6863738
006863704  adrp     x8, #0x8efd000
006863708  ldr      x8, [x8, #0x3b0] ; GLOBAL LocalModels.Bean.Chapter_MainChapter_TypeInfo @ 0x91e2ae8
00686370C  ldr      x9, [x0]
006863710  ldr      x8, [x8]
006863714  ldrb     w11, [x9, #0x130]
006863718  ldrb     w10, [x8, #0x130]
00686371C  cmp      w11, w10
006863720  b.lo     #0x6863738
006863724  ldr      x9, [x9, #0xc8]
006863728  add      x9, x9, x10, lsl #3
00686372C  ldur     x9, [x9, #-8]
006863730  cmp      x9, x8
006863734  b.eq     #0x68637c8
006863738  cbz      x19, #0x686384c
00686373C  adrp     x10, #0x8f23000
006863740  ldr      x8, [x19]
006863744  ldr      x10, [x10, #0xa08] ; GLOBAL LocalModels.Bean.ISkillGroup_TypeInfo @ 0x91ea558
006863748  ldrh     w9, [x8, #0x12e]
00686374C  ldr      x1, [x10]
006863750  cbz      x9, #0x6863774
006863754  ldr      x10, [x8, #0xb0]
006863758  add      x10, x10, #8
00686375C  ldur     x11, [x10, #-8]
006863760  cmp      x11, x1
006863764  b.eq     #0x68637a0
006863768  subs     x9, x9, #1
00686376C  add      x10, x10, #0x10
006863770  b.ne     #0x686375c
006863774  mov      w2, #2
006863778  mov      x0, x19
00686377C  bl       #0x3a7e710 ; 
006863780  b        #0x68637b0 ; 
006863784  ldr      x3, [x2, #0x60]
006863788  mov      x0, x20
00686378C  mov      x1, x19
006863790  ldp      x20, x19, [sp, #0x20]
006863794  ldp      x22, x21, [sp, #0x10]
006863798  ldr      x30, [sp], #0x30
00686379C  br       x3
0068637A0  ldr      w9, [x10]
0068637A4  add      w9, w9, #2
0068637A8  add      x8, x8, w9, sxtw #4
0068637AC  add      x0, x8, #0x138
0068637B0  ldp      x2, x1, [x0]
0068637B4  mov      x0, x19
0068637B8  ldp      x20, x19, [sp, #0x20]
0068637BC  ldp      x22, x21, [sp, #0x10]
0068637C0  ldr      x30, [sp], #0x30
0068637C4  br       x2
0068637C8  mov      x1, xzr
0068637CC  bl       #0x68afc9c ; LocalModels.Bean.Chapter_MainChapter$$GetSkillGroupWeight
0068637D0  cbz      x19, #0x686384c
0068637D4  adrp     x10, #0x8f23000
0068637D8  ldr      x8, [x19]
0068637DC  ldr      x10, [x10, #0xa08] ; GLOBAL LocalModels.Bean.ISkillGroup_TypeInfo @ 0x91ea558
0068637E0  mov      w20, w0
0068637E4  ldrh     w9, [x8, #0x12e]
0068637E8  ldr      x1, [x10]
0068637EC  cbz      x9, #0x6863810
0068637F0  ldr      x10, [x8, #0xb0]
0068637F4  add      x10, x10, #8
0068637F8  ldur     x11, [x10, #-8]
0068637FC  cmp      x11, x1
006863800  b.eq     #0x6863820
006863804  subs     x9, x9, #1
006863808  add      x10, x10, #0x10
00686380C  b.ne     #0x68637f8
006863810  mov      w2, #4
006863814  mov      x0, x19
006863818  bl       #0x3a7e710 ; 
00686381C  b        #0x6863830 ; 
006863820  ldr      w9, [x10]
006863824  add      w9, w9, #4
006863828  add      x8, x8, w9, sxtw #4
00686382C  add      x0, x8, #0x138
006863830  ldp      x3, x2, [x0]
006863834  mov      x0, x19
006863838  mov      w1, w20
00686383C  ldp      x20, x19, [sp, #0x20]
006863840  ldp      x22, x21, [sp, #0x10]
006863844  ldr      x30, [sp], #0x30
006863848  br       x3
00686384C  bl       #0x382bfb8 ; 

