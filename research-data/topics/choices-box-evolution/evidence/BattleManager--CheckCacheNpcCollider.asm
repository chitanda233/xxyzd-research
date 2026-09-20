; HotFix.BattleLogic.BattleManager$$CheckCacheNpcCollider
; RVA 0x6591F50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006591F50  stp      x30, x27, [sp, #-0x50]!
006591F54  stp      x26, x25, [sp, #0x10]
006591F58  stp      x24, x23, [sp, #0x20]
006591F5C  stp      x22, x21, [sp, #0x30]
006591F60  stp      x20, x19, [sp, #0x40]
006591F64  adrp     x20, #0x9599000
006591F68  adrp     x21, #0x8f08000
006591F6C  ldrb     w8, [x20, #0x24a]
006591F70  ldr      x21, [x21, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.CheckCacheNpcCollider() @ 0x923cb18
006591F74  mov      x19, x0
006591F78  tbnz     w8, #0, #0x6591f9c
006591F7C  adrp     x0, #0x8f08000
006591F80  ldr      x0, [x0, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.CheckCacheNpcCollider() @ 0x923cb18
006591F84  bl       #0x382bd14 ; 
006591F88  adrp     x0, #0x8ee6000
006591F8C  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006591F90  bl       #0x382bd14 ; 
006591F94  mov      w8, #1
006591F98  strb     w8, [x20, #0x24a]
006591F9C  ldr      x1, [x21]
006591FA0  ldrb     w8, [x1, #0x53]
006591FA4  tbnz     w8, #5, #0x6591fe4
006591FA8  adrp     x25, #0x9599000
006591FAC  ldrb     w8, [x25, #0x286]
006591FB0  cbnz     w8, #0x6591fc8
006591FB4  adrp     x0, #0x8f07000
006591FB8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006591FBC  bl       #0x382bd14 ; 
006591FC0  mov      w8, #1
006591FC4  strb     w8, [x25, #0x286]
006591FC8  adrp     x26, #0x8f07000
006591FCC  ldr      x26, [x26, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006591FD0  ldr      x1, [x26]
006591FD4  ldrb     w8, [x1, #0x53]
006591FD8  tbnz     w8, #5, #0x6592004
006591FDC  ldr      x20, [x19, #0x80]
006591FE0  b        #0x6592014 ; 
006591FE4  ldr      x2, [x1, #0x60]
006591FE8  mov      x0, x19
006591FEC  ldp      x20, x19, [sp, #0x40]
006591FF0  ldp      x22, x21, [sp, #0x30]
006591FF4  ldp      x24, x23, [sp, #0x20]
006591FF8  ldp      x26, x25, [sp, #0x10]
006591FFC  ldp      x30, x27, [sp], #0x50
006592000  br       x2
006592004  ldr      x8, [x1, #0x60]
006592008  mov      x0, x19
00659200C  blr      x8
006592010  mov      x20, x0
006592014  cbz      x20, #0x6592278
006592018  adrp     x21, #0x9599000
00659201C  ldrb     w8, [x21, #0x29b]
006592020  cbnz     w8, #0x6592038
006592024  adrp     x0, #0x8f08000
006592028  ldr      x0, [x0, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
00659202C  bl       #0x382bd14 ; 
006592030  mov      w8, #1
006592034  strb     w8, [x21, #0x29b]
006592038  adrp     x8, #0x8f08000
00659203C  ldr      x8, [x8, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
006592040  ldr      x1, [x8]
006592044  ldrb     w8, [x1, #0x53]
006592048  tbnz     w8, #5, #0x6592054
00659204C  ldr      w0, [x20, #0x18c]
006592050  b        #0x6592060 ; 
006592054  ldr      x8, [x1, #0x60]
006592058  mov      x0, x20
00659205C  blr      x8
006592060  cmp      w0, #0
006592064  b.gt     #0x6592260
006592068  ldrb     w8, [x25, #0x286]
00659206C  cbnz     w8, #0x6592084
006592070  adrp     x0, #0x8f07000
006592074  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006592078  bl       #0x382bd14 ; 
00659207C  mov      w8, #1
006592080  strb     w8, [x25, #0x286]
006592084  ldr      x1, [x26]
006592088  ldrb     w8, [x1, #0x53]
00659208C  tbnz     w8, #5, #0x6592098
006592090  ldr      x0, [x19, #0x80]
006592094  b        #0x65920a4 ; 
006592098  ldr      x8, [x1, #0x60]
00659209C  mov      x0, x19
0065920A0  blr      x8
0065920A4  cbz      x0, #0x6592278
0065920A8  mov      w1, #4
0065920AC  mov      x2, xzr
0065920B0  bl       #0x69fcc24 ; HotFix.BattleLogic.BattleWorldContext$$CheckBattleFlag
0065920B4  tbnz     w0, #0, #0x6592260
0065920B8  ldr      w8, [x19, #0x6c]
0065920BC  cbz      w8, #0x6592260
0065920C0  ldr      w8, [x19, #0x28]
0065920C4  cmp      w8, #8
0065920C8  b.eq     #0x6592260
0065920CC  cmp      w8, #0xe
0065920D0  b.eq     #0x6592260
0065920D4  ldr      x22, [x19, #0x70]
0065920D8  cbz      x22, #0x6592278
0065920DC  ldr      w8, [x22, #0x18]
0065920E0  cbz      w8, #0x659227c
0065920E4  ldr      x20, [x22, #0x20]!
0065920E8  mov      x23, x22
0065920EC  ldr      x21, [x23, #8]!
0065920F0  cbz      x20, #0x6592278
0065920F4  mov      x0, x20
0065920F8  mov      x1, xzr
0065920FC  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
006592100  tbnz     w0, #0, #0x6592260
006592104  cbz      x21, #0x6592278
006592108  ldr      w8, [x21, #0x62c]
00659210C  cmp      w8, #1
006592110  b.lt     #0x6592260
006592114  adrp     x8, #0x8ee6000
006592118  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659211C  ldr      x1, [x8]
006592120  ldrb     w8, [x1, #0x53]
006592124  tbnz     w8, #5, #0x6592130
006592128  ldr      x24, [x20, #0x38]
00659212C  b        #0x6592140 ; 
006592130  ldr      x8, [x1, #0x60]
006592134  mov      x0, x20
006592138  blr      x8
00659213C  mov      x24, x0
006592140  cbz      x24, #0x6592278
006592144  adrp     x27, #0x9591000
006592148  ldrb     w8, [x27, #0xa8f]
00659214C  cbnz     w8, #0x6592164
006592150  adrp     x0, #0x8ee6000
006592154  ldr      x0, [x0, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
006592158  bl       #0x382bd14 ; 
00659215C  mov      w8, #1
006592160  strb     w8, [x27, #0xa8f]
006592164  adrp     x8, #0x8ee6000
006592168  ldr      x8, [x8, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
00659216C  ldr      x2, [x8]
006592170  ldrb     w8, [x2, #0x53]
006592174  tbnz     w8, #5, #0x6592184
006592178  ldrb     w8, [x24, #0x221]
00659217C  tbz      w8, #0, #0x6592198
006592180  b        #0x6592260 ; 
006592184  ldr      x8, [x2, #0x60]
006592188  mov      w1, #8
00659218C  mov      x0, x24
006592190  blr      x8
006592194  tbnz     w0, #0, #0x6592260
006592198  ldrb     w8, [x25, #0x286]
00659219C  cbnz     w8, #0x65921b4
0065921A0  adrp     x0, #0x8f07000
0065921A4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065921A8  bl       #0x382bd14 ; 
0065921AC  mov      w8, #1
0065921B0  strb     w8, [x25, #0x286]
0065921B4  ldr      x1, [x26]
0065921B8  ldrb     w8, [x1, #0x53]
0065921BC  tbnz     w8, #5, #0x65921c8
0065921C0  ldr      x0, [x19, #0x80]
0065921C4  b        #0x65921d4 ; 
0065921C8  ldr      x8, [x1, #0x60]
0065921CC  mov      x0, x19
0065921D0  blr      x8
0065921D4  cbz      x0, #0x6592278
0065921D8  ldr      x8, [x0, #0x128]
0065921DC  ldr      x9, [x21, #0x630]
0065921E0  sub      x8, x8, x9
0065921E4  cmp      x8, #0x10, lsl #12
0065921E8  b.le     #0x6592260
0065921EC  ldr      w8, [x19, #0x6c]
0065921F0  sub      w8, w8, #1
0065921F4  cmp      w8, #1
0065921F8  str      w8, [x19, #0x6c]
0065921FC  b.lt     #0x659223c
006592200  ldr      x9, [x19, #0x70]
006592204  cbz      x9, #0x6592278
006592208  ldr      w10, [x9, #0x18]
00659220C  cmp      w8, w10
006592210  b.hs     #0x659227c
006592214  mov      w8, w8
006592218  add      x8, x9, x8, lsl #4
00659221C  ldp      x1, x24, [x8, #0x20]
006592220  mov      x0, x22
006592224  str      x1, [x22]
006592228  bl       #0x382bcb8 ; 
00659222C  mov      x0, x23
006592230  mov      x1, x24
006592234  str      x24, [x23]
006592238  bl       #0x382bcb8 ; 
00659223C  mov      x0, x19
006592240  mov      x1, x20
006592244  mov      x2, x21
006592248  ldp      x20, x19, [sp, #0x40]
00659224C  ldp      x22, x21, [sp, #0x30]
006592250  ldp      x24, x23, [sp, #0x20]
006592254  ldp      x26, x25, [sp, #0x10]
006592258  ldp      x30, x27, [sp], #0x50
00659225C  b        #0x6591eb0 ; HotFix.BattleLogic.BattleManager$$RealColliderWithNpc
006592260  ldp      x20, x19, [sp, #0x40]
006592264  ldp      x22, x21, [sp, #0x30]
006592268  ldp      x24, x23, [sp, #0x20]
00659226C  ldp      x26, x25, [sp, #0x10]
006592270  ldp      x30, x27, [sp], #0x50
006592274  ret      
006592278  bl       #0x382bfb8 ; 
00659227C  bl       #0x382bfc0 ; 

