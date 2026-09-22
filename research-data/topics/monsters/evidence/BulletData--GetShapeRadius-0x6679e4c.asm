; HotFix.BattleLogic.BulletData$$GetShapeRadius
; RVA 0x6679E4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006679E4C  sub      sp, sp, #0xa0
006679E50  stp      x30, x25, [sp, #0x60]
006679E54  stp      x24, x23, [sp, #0x70]
006679E58  stp      x22, x21, [sp, #0x80]
006679E5C  stp      x20, x19, [sp, #0x90]
006679E60  mrs      x21, tpidr_el0
006679E64  ldr      x8, [x21, #0x28]
006679E68  adrp     x20, #0x9599000
006679E6C  adrp     x22, #0x8f0f000
006679E70  mov      x19, x0
006679E74  str      x8, [sp, #0x58]
006679E78  ldrb     w8, [x20, #0xea5]
006679E7C  ldr      x22, [x22, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.BulletData.GetShapeRadius()
006679E80  tbnz     w8, #0, #0x6679ea4
006679E84  adrp     x0, #0x8f0f000
006679E88  ldr      x0, [x0, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.BulletData.GetShapeRadius()
006679E8C  bl       #0x382bd14 ; 
006679E90  adrp     x0, #0x8f0f000
006679E94  ldr      x0, [x0, #0xc10] ; GLOBAL Method$System.ValueTuple<FP, FP>..ctor()
006679E98  bl       #0x382bd14 ; 
006679E9C  mov      w8, #1
006679EA0  strb     w8, [x20, #0xea5]
006679EA4  ldr      x1, [x22]
006679EA8  ldrb     w8, [x1, #0x53]
006679EAC  tbnz     w8, #5, #0x6679eec
006679EB0  adrp     x22, #0x9591000
006679EB4  ldrb     w8, [x22, #0xa81]
006679EB8  cbnz     w8, #0x6679ed0
006679EBC  adrp     x0, #0x8ee6000
006679EC0  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679EC4  bl       #0x382bd14 ; 
006679EC8  mov      w8, #1
006679ECC  strb     w8, [x22, #0xa81]
006679ED0  adrp     x24, #0x8ee6000
006679ED4  ldr      x24, [x24, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679ED8  ldr      x1, [x24]
006679EDC  ldrb     w8, [x1, #0x53]
006679EE0  tbnz     w8, #5, #0x6679f00
006679EE4  ldr      x20, [x19, #0x330]
006679EE8  b        #0x6679f10 ; 
006679EEC  ldr      x8, [x1, #0x60]
006679EF0  mov      x0, x19
006679EF4  blr      x8
006679EF8  stp      x0, x1, [sp]
006679EFC  b        #0x667a0f4 ; 
006679F00  ldr      x8, [x1, #0x60]
006679F04  mov      x0, x19
006679F08  blr      x8
006679F0C  mov      x20, x0
006679F10  cbz      x20, #0x667a208
006679F14  adrp     x23, #0x9594000
006679F18  ldrb     w8, [x23, #0x276]
006679F1C  cbnz     w8, #0x6679f34
006679F20  adrp     x0, #0x8ee9000
006679F24  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
006679F28  bl       #0x382bd14 ; 
006679F2C  mov      w8, #1
006679F30  strb     w8, [x23, #0x276]
006679F34  adrp     x25, #0x8ee9000
006679F38  ldr      x25, [x25, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
006679F3C  ldr      x1, [x25]
006679F40  ldrb     w8, [x1, #0x53]
006679F44  tbnz     w8, #5, #0x6679f50
006679F48  ldr      x0, [x20, #0xe8]
006679F4C  b        #0x6679f5c ; 
006679F50  ldr      x8, [x1, #0x60]
006679F54  mov      x0, x20
006679F58  blr      x8
006679F5C  cbz      x0, #0x667a208
006679F60  ldr      w8, [x0, #0x18]
006679F64  cmp      w8, #1
006679F68  b.ne     #0x6679fb8
006679F6C  adrp     x20, #0x9592000
006679F70  ldrb     w8, [x20, #0x46a]
006679F74  cbnz     w8, #0x6679f8c
006679F78  adrp     x0, #0x8ee8000
006679F7C  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
006679F80  bl       #0x382bd14 ; 
006679F84  mov      w8, #1
006679F88  strb     w8, [x20, #0x46a]
006679F8C  adrp     x8, #0x8ee8000
006679F90  ldr      x8, [x8, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
006679F94  ldr      x1, [x8]
006679F98  ldrb     w8, [x1, #0x53]
006679F9C  tbnz     w8, #5, #0x6679fe8
006679FA0  add      x8, x19, #0x1c8
006679FA4  ldp      q1, q0, [x8, #0x20]
006679FA8  ldp      q3, q2, [x8]
006679FAC  stp      q1, q0, [sp, #0x30]
006679FB0  stp      q3, q2, [sp, #0x10]
006679FB4  b        #0x6679ff8 ; 
006679FB8  ldrb     w8, [x22, #0xa81]
006679FBC  cbnz     w8, #0x6679fd4
006679FC0  adrp     x0, #0x8ee6000
006679FC4  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_TableData()
006679FC8  bl       #0x382bd14 ; 
006679FCC  mov      w8, #1
006679FD0  strb     w8, [x22, #0xa81]
006679FD4  ldr      x1, [x24]
006679FD8  ldrb     w8, [x1, #0x53]
006679FDC  tbnz     w8, #5, #0x667a018
006679FE0  ldr      x20, [x19, #0x330]
006679FE4  b        #0x667a028 ; 
006679FE8  ldr      x9, [x1, #0x60]
006679FEC  add      x8, sp, #0x10
006679FF0  mov      x0, x19
006679FF4  blr      x9
006679FF8  adrp     x8, #0x8f0f000
006679FFC  ldr      x1, [sp, #0x30]
00667A000  b        #0x89ed20c ; 
00667A004  stp      xzr, xzr, [sp]
00667A008  mov      x0, sp
00667A00C  mov      x2, x1
00667A010  ldr      x3, [x8] ; GLOBAL Method$HotFix.BattleLogic.BattleDropItemData.AddDropItem()
00667A014  b        #0x667a0f0 ; 
00667A018  ldr      x8, [x1, #0x60]
00667A01C  mov      x0, x19
00667A020  blr      x8
00667A024  mov      x20, x0
00667A028  cbz      x20, #0x667a208
00667A02C  ldrb     w8, [x23, #0x276]
00667A030  cbnz     w8, #0x667a048
00667A034  adrp     x0, #0x8ee9000
00667A038  ldr      x0, [x0, #0xf58] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_Shape()
00667A03C  bl       #0x382bd14 ; 
00667A040  mov      w8, #1
00667A044  strb     w8, [x23, #0x276]
00667A048  ldr      x1, [x25]
00667A04C  ldrb     w8, [x1, #0x53]
00667A050  tbnz     w8, #5, #0x667a05c
00667A054  ldr      x0, [x20, #0xe8]
00667A058  b        #0x667a068 ; 
00667A05C  ldr      x8, [x1, #0x60]
00667A060  mov      x0, x20
00667A064  blr      x8
00667A068  cbz      x0, #0x667a208
00667A06C  ldr      w8, [x0, #0x18]
00667A070  cmp      w8, #2
00667A074  b.ne     #0x667a0d4
00667A078  mov      x0, x19
00667A07C  bl       #0x66770b4 ; HotFix.BattleLogic.BulletData$$get_BulletType
00667A080  adrp     x20, #0x9592000
00667A084  cmp      w0, #3
00667A088  b.ne     #0x667a120
00667A08C  ldrb     w8, [x20, #0x46a]
00667A090  cbnz     w8, #0x667a0a8
00667A094  adrp     x0, #0x8ee8000
00667A098  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
00667A09C  bl       #0x382bd14 ; 
00667A0A0  mov      w8, #1
00667A0A4  strb     w8, [x20, #0x46a]
00667A0A8  adrp     x8, #0x8ee8000
00667A0AC  ldr      x8, [x8, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
00667A0B0  ldr      x1, [x8]
00667A0B4  ldrb     w8, [x1, #0x53]
00667A0B8  tbnz     w8, #5, #0x667a168
00667A0BC  add      x8, x19, #0x1c8
00667A0C0  ldp      q1, q0, [x8, #0x20]
00667A0C4  ldp      q3, q2, [x8]
00667A0C8  stp      q1, q0, [sp, #0x30]
00667A0CC  stp      q3, q2, [sp, #0x10]
00667A0D0  b        #0x667a178 ; 
00667A0D4  adrp     x8, #0x8f0f000
00667A0D8  ldr      x8, [x8, #0xc10] ; GLOBAL Method$System.ValueTuple<FP, FP>..ctor()
00667A0DC  mov      x0, sp
00667A0E0  mov      w1, #0xccb
00667A0E4  mov      w2, #0xccb
00667A0E8  ldr      x3, [x8]
00667A0EC  stp      xzr, xzr, [sp]
00667A0F0  bl       #0x57d88c0 ; System.ValueTuple<FP, FP>$$.ctor
00667A0F4  ldp      x0, x1, [sp]
00667A0F8  ldr      x8, [x21, #0x28]
00667A0FC  ldr      x9, [sp, #0x58]
00667A100  cmp      x8, x9
00667A104  b.ne     #0x667a20c
00667A108  ldp      x20, x19, [sp, #0x90]
00667A10C  ldp      x22, x21, [sp, #0x80]
00667A110  ldp      x24, x23, [sp, #0x70]
00667A114  ldp      x30, x25, [sp, #0x60]
00667A118  add      sp, sp, #0xa0
00667A11C  ret      
00667A120  ldrb     w8, [x20, #0x46a]
00667A124  cbnz     w8, #0x667a13c
00667A128  adrp     x0, #0x8ee8000
00667A12C  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
00667A130  bl       #0x382bd14 ; 
00667A134  mov      w8, #1
00667A138  strb     w8, [x20, #0x46a]
00667A13C  adrp     x8, #0x8ee8000
00667A140  ldr      x8, [x8, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Shape()
00667A144  ldr      x1, [x8]
00667A148  ldrb     w8, [x1, #0x53]
00667A14C  tbnz     w8, #5, #0x667a1b8
00667A150  add      x8, x19, #0x1c8
00667A154  ldp      q1, q0, [x8, #0x20]
00667A158  ldp      q3, q2, [x8]
00667A15C  stp      q1, q0, [sp, #0x30]
00667A160  stp      q3, q2, [sp, #0x10]
00667A164  b        #0x667a1c8 ; 
00667A168  ldr      x9, [x1, #0x60]
00667A16C  add      x8, sp, #0x10
00667A170  mov      x0, x19
00667A174  blr      x9
00667A178  adrp     x22, #0x9594000
00667A17C  ldrb     w8, [x22, #0x275]
00667A180  ldr      x20, [sp, #0x30]
00667A184  cbnz     w8, #0x667a19c
00667A188  adrp     x0, #0x8ee9000
00667A18C  ldr      x0, [x0, #0xf50] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ExShapeRadius()
00667A190  bl       #0x382bd14 ; 
00667A194  mov      w8, #1
00667A198  strb     w8, [x22, #0x275]
00667A19C  adrp     x8, #0x8ee9000
00667A1A0  ldr      x8, [x8, #0xf50] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_ExShapeRadius()
00667A1A4  ldr      x1, [x8]
00667A1A8  ldrb     w8, [x1, #0x53]
00667A1AC  tbnz     w8, #5, #0x667a1e0
00667A1B0  ldr      x2, [x19, #0x3f8]
00667A1B4  b        #0x667a1f0 ; 
00667A1B8  ldr      x9, [x1, #0x60]
00667A1BC  add      x8, sp, #0x10
00667A1C0  mov      x0, x19
00667A1C4  blr      x9
00667A1C8  adrp     x8, #0x8f0f000
00667A1CC  ldp      x1, x2, [sp, #0x38]
00667A1D0  ldr      x8, [x8, #0xc10] ; GLOBAL Method$System.ValueTuple<FP, FP>..ctor()
00667A1D4  stp      xzr, xzr, [sp]
00667A1D8  mov      x0, sp
00667A1DC  b        #0x667a010 ; 
00667A1E0  ldr      x8, [x1, #0x60]
00667A1E4  mov      x0, x19
00667A1E8  blr      x8
00667A1EC  mov      x2, x0
00667A1F0  adrp     x8, #0x8f0f000
00667A1F4  ldr      x8, [x8, #0xc10] ; GLOBAL Method$System.ValueTuple<FP, FP>..ctor()
00667A1F8  stp      xzr, xzr, [sp]
00667A1FC  mov      x0, sp
00667A200  mov      x1, x20
00667A204  b        #0x667a010 ; 
00667A208  bl       #0x382bfb8 ; 
00667A20C  bl       #0x89edb60 ; 

