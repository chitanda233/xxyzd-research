; HotFix.BattleLogic.DropItemEquip$$OnAbsorb
; RVA 0x6666068; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006666068  stp      x30, x25, [sp, #-0x40]!
00666606C  stp      x24, x23, [sp, #0x10]
006666070  stp      x22, x21, [sp, #0x20]
006666074  stp      x20, x19, [sp, #0x30]
006666078  adrp     x20, #0x9599000
00666607C  adrp     x21, #0x8f0f000
006666080  ldrb     w8, [x20, #0xd6d]
006666084  ldr      x21, [x21, #0x288] ; GLOBAL Method$HotFix.BattleLogic.DropItemEquip.OnAbsorb() @ 0x925fd18
006666088  mov      x19, x0
00666608C  tbnz     w8, #0, #0x66660b0
006666090  adrp     x0, #0x8f0f000
006666094  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.DropItemEquip.OnAbsorb() @ 0x925fd18
006666098  bl       #0x382bd14 ; 
00666609C  adrp     x0, #0x8f0f000
0066660A0  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
0066660A4  bl       #0x382bd14 ; 
0066660A8  mov      w8, #1
0066660AC  strb     w8, [x20, #0xd6d]
0066660B0  ldr      x1, [x21]
0066660B4  ldrb     w8, [x1, #0x53]
0066660B8  tbnz     w8, #5, #0x66660f8
0066660BC  adrp     x22, #0x9591000
0066660C0  ldrb     w8, [x22, #0xa4b]
0066660C4  cbnz     w8, #0x66660dc
0066660C8  adrp     x0, #0x8ee5000
0066660CC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0066660D0  bl       #0x382bd14 ; 
0066660D4  mov      w8, #1
0066660D8  strb     w8, [x22, #0xa4b]
0066660DC  adrp     x23, #0x8ee5000
0066660E0  ldr      x23, [x23, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0066660E4  ldr      x1, [x23]
0066660E8  ldrb     w8, [x1, #0x53]
0066660EC  tbnz     w8, #5, #0x6666100
0066660F0  ldr      x20, [x19, #0x20]
0066660F4  b        #0x6666110 ; 
0066660F8  ldr      x2, [x1, #0x60]
0066660FC  b        #0x666633c ; 
006666100  ldr      x8, [x1, #0x60]
006666104  mov      x0, x19
006666108  blr      x8
00666610C  mov      x20, x0
006666110  cbz      x20, #0x6666354
006666114  adrp     x21, #0x9599000
006666118  ldrb     w8, [x21, #0x287]
00666611C  cbnz     w8, #0x6666134
006666120  adrp     x0, #0x8f07000
006666124  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
006666128  bl       #0x382bd14 ; 
00666612C  mov      w8, #1
006666130  strb     w8, [x21, #0x287]
006666134  adrp     x8, #0x8f07000
006666138  ldr      x8, [x8, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00666613C  ldr      x1, [x8]
006666140  ldrb     w8, [x1, #0x53]
006666144  tbnz     w8, #5, #0x6666150
006666148  ldr      x0, [x20, #0x350]
00666614C  b        #0x666615c ; 
006666150  ldr      x8, [x1, #0x60]
006666154  mov      x0, x20
006666158  blr      x8
00666615C  cbz      x0, #0x6666354
006666160  mov      w2, #1
006666164  mov      w1, wzr
006666168  mov      w20, #1
00666616C  bl       #0x6666358 ; HotFix.BattleLogic.DropMgr$$ReduceItemCount
006666170  ldrb     w8, [x22, #0xa4b]
006666174  cbnz     w8, #0x6666188
006666178  adrp     x0, #0x8ee5000
00666617C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006666180  bl       #0x382bd14 ; 
006666184  strb     w20, [x22, #0xa4b]
006666188  ldr      x1, [x23]
00666618C  ldrb     w8, [x1, #0x53]
006666190  tbnz     w8, #5, #0x666619c
006666194  ldr      x20, [x19, #0x20]
006666198  b        #0x66661ac ; 
00666619C  ldr      x8, [x1, #0x60]
0066661A0  mov      x0, x19
0066661A4  blr      x8
0066661A8  mov      x20, x0
0066661AC  adrp     x24, #0x8f0f000
0066661B0  ldr      x24, [x24, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
0066661B4  ldr      x1, [x24]
0066661B8  ldrb     w8, [x1, #0x53]
0066661BC  tbnz     w8, #5, #0x66661c8
0066661C0  ldr      x0, [x19, #0x38]
0066661C4  b        #0x66661d4 ; 
0066661C8  ldr      x8, [x1, #0x60]
0066661CC  mov      x0, x19
0066661D0  blr      x8
0066661D4  cbz      x0, #0x6666354
0066661D8  ldr      x21, [x0, #0x78]
0066661DC  cbz      x21, #0x6666354
0066661E0  adrp     x25, #0x9599000
0066661E4  ldrb     w8, [x25, #0xebb]
0066661E8  cbnz     w8, #0x6666200
0066661EC  adrp     x0, #0x8f0f000
0066661F0  ldr      x0, [x0, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
0066661F4  bl       #0x382bd14 ; 
0066661F8  mov      w8, #1
0066661FC  strb     w8, [x25, #0xebb]
006666200  adrp     x8, #0x8f0f000
006666204  ldr      x8, [x8, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006666208  ldr      x1, [x8]
00666620C  ldrb     w8, [x1, #0x53]
006666210  tbnz     w8, #5, #0x666621c
006666214  ldr      w1, [x21, #0x60]
006666218  b        #0x666622c ; 
00666621C  ldr      x8, [x1, #0x60]
006666220  mov      x0, x21
006666224  blr      x8
006666228  mov      w1, w0
00666622C  cbz      x20, #0x6666354
006666230  mov      x0, x20
006666234  mov      x2, xzr
006666238  bl       #0x6a074b4 ; HotFix.BattleLogic.BattleWorldContext$$PlaySound
00666623C  ldrb     w8, [x22, #0xa4b]
006666240  cbnz     w8, #0x6666258
006666244  adrp     x0, #0x8ee5000
006666248  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00666624C  bl       #0x382bd14 ; 
006666250  mov      w8, #1
006666254  strb     w8, [x22, #0xa4b]
006666258  ldr      x1, [x23]
00666625C  ldrb     w8, [x1, #0x53]
006666260  tbnz     w8, #5, #0x666626c
006666264  ldr      x20, [x19, #0x20]
006666268  b        #0x666627c ; 
00666626C  ldr      x8, [x1, #0x60]
006666270  mov      x0, x19
006666274  blr      x8
006666278  mov      x20, x0
00666627C  cbz      x20, #0x6666354
006666280  adrp     x21, #0x9591000
006666284  ldrb     w8, [x21, #0xa62]
006666288  cbnz     w8, #0x66662a0
00666628C  adrp     x0, #0x8ee6000
006666290  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
006666294  bl       #0x382bd14 ; 
006666298  mov      w8, #1
00666629C  strb     w8, [x21, #0xa62]
0066662A0  adrp     x8, #0x8ee6000
0066662A4  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0066662A8  ldr      x1, [x8]
0066662AC  ldrb     w8, [x1, #0x53]
0066662B0  tbnz     w8, #5, #0x66662bc
0066662B4  ldr      x20, [x20, #0x1f8]
0066662B8  b        #0x66662cc ; 
0066662BC  ldr      x8, [x1, #0x60]
0066662C0  mov      x0, x20
0066662C4  blr      x8
0066662C8  mov      x20, x0
0066662CC  ldr      x1, [x24]
0066662D0  ldrb     w8, [x1, #0x53]
0066662D4  tbnz     w8, #5, #0x66662e0
0066662D8  ldr      x0, [x19, #0x38]
0066662DC  b        #0x66662ec ; 
0066662E0  ldr      x8, [x1, #0x60]
0066662E4  mov      x0, x19
0066662E8  blr      x8
0066662EC  cbz      x0, #0x6666354
0066662F0  cbz      x20, #0x6666354
0066662F4  ldr      w1, [x0, #0x80]
0066662F8  mov      x0, x20
0066662FC  mov      x2, xzr
006666300  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
006666304  cbz      x0, #0x6666330
006666308  mov      x1, xzr
00666630C  mov      x20, x0
006666310  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
006666314  tbnz     w0, #0, #0x6666330
006666318  ldr      x8, [x19]
00666631C  mov      x0, x19
006666320  mov      x1, x20
006666324  ldr      x9, [x8, #0x368]
006666328  ldr      x2, [x8, #0x370]
00666632C  blr      x9
006666330  ldr      x8, [x19]
006666334  ldr      x2, [x8, #0x398]
006666338  ldr      x1, [x8, #0x3a0]
00666633C  mov      x0, x19
006666340  ldp      x20, x19, [sp, #0x30]
006666344  ldp      x22, x21, [sp, #0x20]
006666348  ldp      x24, x23, [sp, #0x10]
00666634C  ldp      x30, x25, [sp], #0x40
006666350  br       x2
006666354  bl       #0x382bfb8 ; 

