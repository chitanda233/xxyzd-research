; HotFix.BattleLogic.DropItemEquip$$Collect
; RVA 0x666656C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00666656C  str      x30, [sp, #-0x30]!
006666570  stp      x22, x21, [sp, #0x10]
006666574  stp      x20, x19, [sp, #0x20]
006666578  adrp     x20, #0x9599000
00666657C  adrp     x21, #0x8f0f000
006666580  ldrb     w8, [x20, #0xd70]
006666584  ldr      x21, [x21, #0x2a8] ; GLOBAL Method$HotFix.BattleLogic.DropItemEquip.Collect() @ 0x925fd08
006666588  mov      x19, x0
00666658C  tbnz     w8, #0, #0x66665b0
006666590  adrp     x0, #0x8f0f000
006666594  ldr      x0, [x0, #0x2a8] ; GLOBAL Method$HotFix.BattleLogic.DropItemEquip.Collect() @ 0x925fd08
006666598  bl       #0x382bd14 ; 
00666659C  adrp     x0, #0x8f0f000
0066665A0  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
0066665A4  bl       #0x382bd14 ; 
0066665A8  mov      w8, #1
0066665AC  strb     w8, [x20, #0xd70]
0066665B0  ldr      x1, [x21]
0066665B4  ldrb     w8, [x1, #0x53]
0066665B8  tbnz     w8, #5, #0x66665d4
0066665BC  ldrb     w8, [x19, #0xf0]
0066665C0  cbz      w8, #0x66665ec
0066665C4  ldp      x20, x19, [sp, #0x20]
0066665C8  ldp      x22, x21, [sp, #0x10]
0066665CC  ldr      x30, [sp], #0x30
0066665D0  ret      
0066665D4  ldr      x2, [x1, #0x60]
0066665D8  mov      x0, x19
0066665DC  ldp      x20, x19, [sp, #0x20]
0066665E0  ldp      x22, x21, [sp, #0x10]
0066665E4  ldr      x30, [sp], #0x30
0066665E8  br       x2
0066665EC  mov      w8, #1
0066665F0  strb     w8, [x19, #0xf0]
0066665F4  adrp     x22, #0x8f0f000
0066665F8  ldr      x22, [x22, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
0066665FC  ldr      x1, [x22]
006666600  ldrb     w8, [x1, #0x53]
006666604  tbnz     w8, #5, #0x6666610
006666608  ldr      x0, [x19, #0x38]
00666660C  b        #0x666661c ; 
006666610  ldr      x8, [x1, #0x60]
006666614  mov      x0, x19
006666618  blr      x8
00666661C  cbz      x0, #0x666671c
006666620  ldr      w8, [x0, #0xc8]
006666624  adrp     x21, #0x9591000
006666628  ldrb     w9, [x21, #0xa4b]
00666662C  cmp      w8, #0
006666630  csinc    w20, w8, wzr, ne
006666634  cbnz     w9, #0x666664c
006666638  adrp     x0, #0x8ee5000
00666663C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006666640  bl       #0x382bd14 ; 
006666644  mov      w8, #1
006666648  strb     w8, [x21, #0xa4b]
00666664C  adrp     x8, #0x8ee5000
006666650  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006666654  ldr      x1, [x8]
006666658  ldrb     w8, [x1, #0x53]
00666665C  tbnz     w8, #5, #0x6666668
006666660  ldr      x21, [x19, #0x20]
006666664  b        #0x6666678 ; 
006666668  ldr      x8, [x1, #0x60]
00666666C  mov      x0, x19
006666670  blr      x8
006666674  mov      x21, x0
006666678  ldr      x1, [x22]
00666667C  ldrb     w8, [x1, #0x53]
006666680  tbnz     w8, #5, #0x666668c
006666684  ldr      x0, [x19, #0x38]
006666688  b        #0x6666698 ; 
00666668C  ldr      x8, [x1, #0x60]
006666690  mov      x0, x19
006666694  blr      x8
006666698  cbz      x0, #0x666671c
00666669C  cbz      x21, #0x666671c
0066666A0  ldr      x8, [x0, #0xc0]
0066666A4  adrp     x22, #0x9599000
0066666A8  ldrb     w9, [x22, #0xec6]
0066666AC  lsr      x19, x8, #0x10
0066666B0  cbnz     w9, #0x66666c8
0066666B4  adrp     x0, #0x8f0f000
0066666B8  ldr      x0, [x0, #0x2b0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddDropInfo() @ 0x923f570
0066666BC  bl       #0x382bd14 ; 
0066666C0  mov      w8, #1
0066666C4  strb     w8, [x22, #0xec6]
0066666C8  adrp     x8, #0x8f0f000
0066666CC  ldr      x8, [x8, #0x2b0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddDropInfo() @ 0x923f570
0066666D0  ldr      x3, [x8]
0066666D4  ldrb     w8, [x3, #0x53]
0066666D8  tbnz     w8, #5, #0x66666fc
0066666DC  add      x0, x21, #0x290
0066666E0  mov      w1, w19
0066666E4  mov      w2, w20
0066666E8  ldp      x20, x19, [sp, #0x20]
0066666EC  ldp      x22, x21, [sp, #0x10]
0066666F0  mov      x3, xzr
0066666F4  ldr      x30, [sp], #0x30
0066666F8  b        #0x658eb6c ; HotFix.BattleLogic.BattleData$$AddDropInfo
0066666FC  ldr      x4, [x3, #0x60]
006666700  mov      x0, x21
006666704  mov      w1, w19
006666708  mov      w2, w20
00666670C  ldp      x20, x19, [sp, #0x20]
006666710  ldp      x22, x21, [sp, #0x10]
006666714  ldr      x30, [sp], #0x30
006666718  br       x4
00666671C  bl       #0x382bfb8 ; 

