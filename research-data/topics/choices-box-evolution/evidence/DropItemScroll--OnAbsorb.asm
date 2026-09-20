; HotFix.BattleLogic.DropItemScroll$$OnAbsorb
; RVA 0x6668F9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006668F9C  stp      x30, x25, [sp, #-0x40]!
006668FA0  stp      x24, x23, [sp, #0x10]
006668FA4  stp      x22, x21, [sp, #0x20]
006668FA8  stp      x20, x19, [sp, #0x30]
006668FAC  adrp     x20, #0x9599000
006668FB0  adrp     x21, #0x8f0f000
006668FB4  ldrb     w8, [x20, #0xd91]
006668FB8  ldr      x21, [x21, #0x408] ; GLOBAL Method$HotFix.BattleLogic.DropItemScroll.OnAbsorb() @ 0x925fe50
006668FBC  mov      x19, x0
006668FC0  tbnz     w8, #0, #0x6668fe4
006668FC4  adrp     x0, #0x8f0f000
006668FC8  ldr      x0, [x0, #0x408] ; GLOBAL Method$HotFix.BattleLogic.DropItemScroll.OnAbsorb() @ 0x925fe50
006668FCC  bl       #0x382bd14 ; 
006668FD0  adrp     x0, #0x8f0f000
006668FD4  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006668FD8  bl       #0x382bd14 ; 
006668FDC  mov      w8, #1
006668FE0  strb     w8, [x20, #0xd91]
006668FE4  ldr      x1, [x21]
006668FE8  ldrb     w8, [x1, #0x53]
006668FEC  tbnz     w8, #5, #0x666902c
006668FF0  adrp     x22, #0x9591000
006668FF4  ldrb     w8, [x22, #0xa4b]
006668FF8  cbnz     w8, #0x6669010
006668FFC  adrp     x0, #0x8ee5000
006669000  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006669004  bl       #0x382bd14 ; 
006669008  mov      w8, #1
00666900C  strb     w8, [x22, #0xa4b]
006669010  adrp     x23, #0x8ee5000
006669014  ldr      x23, [x23, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006669018  ldr      x1, [x23]
00666901C  ldrb     w8, [x1, #0x53]
006669020  tbnz     w8, #5, #0x6669034
006669024  ldr      x20, [x19, #0x20]
006669028  b        #0x6669044 ; 
00666902C  ldr      x2, [x1, #0x60]
006669030  b        #0x6669270 ; 
006669034  ldr      x8, [x1, #0x60]
006669038  mov      x0, x19
00666903C  blr      x8
006669040  mov      x20, x0
006669044  cbz      x20, #0x6669288
006669048  adrp     x21, #0x9599000
00666904C  ldrb     w8, [x21, #0x287]
006669050  cbnz     w8, #0x6669068
006669054  adrp     x0, #0x8f07000
006669058  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00666905C  bl       #0x382bd14 ; 
006669060  mov      w8, #1
006669064  strb     w8, [x21, #0x287]
006669068  adrp     x8, #0x8f07000
00666906C  ldr      x8, [x8, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
006669070  ldr      x1, [x8]
006669074  ldrb     w8, [x1, #0x53]
006669078  tbnz     w8, #5, #0x6669084
00666907C  ldr      x0, [x20, #0x350]
006669080  b        #0x6669090 ; 
006669084  ldr      x8, [x1, #0x60]
006669088  mov      x0, x20
00666908C  blr      x8
006669090  cbz      x0, #0x6669288
006669094  mov      w2, #1
006669098  mov      w1, wzr
00666909C  mov      w20, #1
0066690A0  bl       #0x6666358 ; HotFix.BattleLogic.DropMgr$$ReduceItemCount
0066690A4  ldrb     w8, [x22, #0xa4b]
0066690A8  cbnz     w8, #0x66690bc
0066690AC  adrp     x0, #0x8ee5000
0066690B0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0066690B4  bl       #0x382bd14 ; 
0066690B8  strb     w20, [x22, #0xa4b]
0066690BC  ldr      x1, [x23]
0066690C0  ldrb     w8, [x1, #0x53]
0066690C4  tbnz     w8, #5, #0x66690d0
0066690C8  ldr      x20, [x19, #0x20]
0066690CC  b        #0x66690e0 ; 
0066690D0  ldr      x8, [x1, #0x60]
0066690D4  mov      x0, x19
0066690D8  blr      x8
0066690DC  mov      x20, x0
0066690E0  adrp     x24, #0x8f0f000
0066690E4  ldr      x24, [x24, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
0066690E8  ldr      x1, [x24]
0066690EC  ldrb     w8, [x1, #0x53]
0066690F0  tbnz     w8, #5, #0x66690fc
0066690F4  ldr      x0, [x19, #0x38]
0066690F8  b        #0x6669108 ; 
0066690FC  ldr      x8, [x1, #0x60]
006669100  mov      x0, x19
006669104  blr      x8
006669108  cbz      x0, #0x6669288
00666910C  ldr      x21, [x0, #0x78]
006669110  cbz      x21, #0x6669288
006669114  adrp     x25, #0x9599000
006669118  ldrb     w8, [x25, #0xebb]
00666911C  cbnz     w8, #0x6669134
006669120  adrp     x0, #0x8f0f000
006669124  ldr      x0, [x0, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006669128  bl       #0x382bd14 ; 
00666912C  mov      w8, #1
006669130  strb     w8, [x25, #0xebb]
006669134  adrp     x8, #0x8f0f000
006669138  ldr      x8, [x8, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
00666913C  ldr      x1, [x8]
006669140  ldrb     w8, [x1, #0x53]
006669144  tbnz     w8, #5, #0x6669150
006669148  ldr      w1, [x21, #0x60]
00666914C  b        #0x6669160 ; 
006669150  ldr      x8, [x1, #0x60]
006669154  mov      x0, x21
006669158  blr      x8
00666915C  mov      w1, w0
006669160  cbz      x20, #0x6669288
006669164  mov      x0, x20
006669168  mov      x2, xzr
00666916C  bl       #0x6a074b4 ; HotFix.BattleLogic.BattleWorldContext$$PlaySound
006669170  ldrb     w8, [x22, #0xa4b]
006669174  cbnz     w8, #0x666918c
006669178  adrp     x0, #0x8ee5000
00666917C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006669180  bl       #0x382bd14 ; 
006669184  mov      w8, #1
006669188  strb     w8, [x22, #0xa4b]
00666918C  ldr      x1, [x23]
006669190  ldrb     w8, [x1, #0x53]
006669194  tbnz     w8, #5, #0x66691a0
006669198  ldr      x20, [x19, #0x20]
00666919C  b        #0x66691b0 ; 
0066691A0  ldr      x8, [x1, #0x60]
0066691A4  mov      x0, x19
0066691A8  blr      x8
0066691AC  mov      x20, x0
0066691B0  cbz      x20, #0x6669288
0066691B4  adrp     x21, #0x9591000
0066691B8  ldrb     w8, [x21, #0xa62]
0066691BC  cbnz     w8, #0x66691d4
0066691C0  adrp     x0, #0x8ee6000
0066691C4  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0066691C8  bl       #0x382bd14 ; 
0066691CC  mov      w8, #1
0066691D0  strb     w8, [x21, #0xa62]
0066691D4  adrp     x8, #0x8ee6000
0066691D8  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0066691DC  ldr      x1, [x8]
0066691E0  ldrb     w8, [x1, #0x53]
0066691E4  tbnz     w8, #5, #0x66691f0
0066691E8  ldr      x20, [x20, #0x1f8]
0066691EC  b        #0x6669200 ; 
0066691F0  ldr      x8, [x1, #0x60]
0066691F4  mov      x0, x20
0066691F8  blr      x8
0066691FC  mov      x20, x0
006669200  ldr      x1, [x24]
006669204  ldrb     w8, [x1, #0x53]
006669208  tbnz     w8, #5, #0x6669214
00666920C  ldr      x0, [x19, #0x38]
006669210  b        #0x6669220 ; 
006669214  ldr      x8, [x1, #0x60]
006669218  mov      x0, x19
00666921C  blr      x8
006669220  cbz      x0, #0x6669288
006669224  cbz      x20, #0x6669288
006669228  ldr      w1, [x0, #0x80]
00666922C  mov      x0, x20
006669230  mov      x2, xzr
006669234  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
006669238  cbz      x0, #0x6669264
00666923C  mov      x1, xzr
006669240  mov      x20, x0
006669244  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
006669248  tbnz     w0, #0, #0x6669264
00666924C  ldr      x8, [x19]
006669250  mov      x0, x19
006669254  mov      x1, x20
006669258  ldr      x9, [x8, #0x368]
00666925C  ldr      x2, [x8, #0x370]
006669260  blr      x9
006669264  ldr      x8, [x19]
006669268  ldr      x2, [x8, #0x398]
00666926C  ldr      x1, [x8, #0x3a0]
006669270  mov      x0, x19
006669274  ldp      x20, x19, [sp, #0x30]
006669278  ldp      x22, x21, [sp, #0x20]
00666927C  ldp      x24, x23, [sp, #0x10]
006669280  ldp      x30, x25, [sp], #0x40
006669284  br       x2
006669288  bl       #0x382bfb8 ; 

