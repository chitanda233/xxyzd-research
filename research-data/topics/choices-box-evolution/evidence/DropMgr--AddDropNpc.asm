; HotFix.BattleLogic.DropMgr$$AddDropNpc
; RVA 0x666DEB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00666DEB0  sub      sp, sp, #0x100
00666DEB4  stp      x29, x30, [sp, #0xa0]
00666DEB8  stp      x28, x27, [sp, #0xb0]
00666DEBC  stp      x26, x25, [sp, #0xc0]
00666DEC0  stp      x24, x23, [sp, #0xd0]
00666DEC4  stp      x22, x21, [sp, #0xe0]
00666DEC8  stp      x20, x19, [sp, #0xf0]
00666DECC  mrs      x28, tpidr_el0
00666DED0  ldr      x8, [x28, #0x28]
00666DED4  adrp     x24, #0x9599000
00666DED8  adrp     x26, #0x8f0f000
00666DEDC  mov      w25, w5
00666DEE0  str      x8, [sp, #0x98]
00666DEE4  ldrb     w8, [x24, #0xdc1]
00666DEE8  ldr      x26, [x26, #0x630] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.AddDropNpc() @ 0x9260020
00666DEEC  mov      w22, w4
00666DEF0  mov      x23, x3
00666DEF4  mov      w20, w2
00666DEF8  mov      w19, w1
00666DEFC  mov      x21, x0
00666DF00  tbnz     w8, #0, #0x666df3c
00666DF04  adrp     x0, #0x8f0f000
00666DF08  ldr      x0, [x0, #0x630] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.AddDropNpc() @ 0x9260020
00666DF0C  bl       #0x382bd14 ; 
00666DF10  adrp     x0, #0x8f0f000
00666DF14  ldr      x0, [x0, #0x5b8] ; GLOBAL Method$System.Collections.Generic.List<DropItemData>.Add() @ 0x921ba90
00666DF18  bl       #0x382bd14 ; 
00666DF1C  adrp     x0, #0x8f0f000
00666DF20  ldr      x0, [x0, #0x570] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<DropItemData>() @ 0x92cfd18
00666DF24  bl       #0x382bd14 ; 
00666DF28  adrp     x0, #0x8f0f000
00666DF2C  ldr      x0, [x0, #0x578] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<DropItemData>() @ 0x92cfdb8
00666DF30  bl       #0x382bd14 ; 
00666DF34  mov      w8, #1
00666DF38  strb     w8, [x24, #0xdc1]
00666DF3C  ldr      x6, [x26]
00666DF40  ldrb     w8, [x6, #0x53]
00666DF44  tbnz     w8, #5, #0x666df8c
00666DF48  adrp     x29, #0x9599000
00666DF4C  ldrb     w8, [x29, #0xeca]
00666DF50  stp      xzr, xzr, [sp, #0x60]
00666DF54  str      xzr, [sp, #0x70]
00666DF58  cbnz     w8, #0x666df70
00666DF5C  adrp     x0, #0x8f0f000
00666DF60  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666DF64  bl       #0x382bd14 ; 
00666DF68  mov      w8, #1
00666DF6C  strb     w8, [x29, #0xeca]
00666DF70  adrp     x26, #0x8f0f000
00666DF74  ldr      x26, [x26, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666DF78  ldr      x1, [x26]
00666DF7C  ldrb     w8, [x1, #0x53]
00666DF80  tbnz     w8, #5, #0x666dfc0
00666DF84  ldr      x24, [x21, #0x10]
00666DF88  b        #0x666dfd0 ; 
00666DF8C  ldr      x8, [x23, #0x10]
00666DF90  ldr      q0, [x23]
00666DF94  ldr      x9, [x6, #0x60]
00666DF98  and      w5, w25, #1
00666DF9C  add      x3, sp, #0x80
00666DFA0  mov      x0, x21
00666DFA4  mov      w1, w19
00666DFA8  mov      w2, w20
00666DFAC  mov      w4, w22
00666DFB0  str      x8, [sp, #0x90]
00666DFB4  str      q0, [sp, #0x80]
00666DFB8  blr      x9
00666DFBC  b        #0x666e3a0 ; 
00666DFC0  ldr      x8, [x1, #0x60]
00666DFC4  mov      x0, x21
00666DFC8  blr      x8
00666DFCC  mov      x24, x0
00666DFD0  cbz      x24, #0x666e3d0
00666DFD4  adrp     x8, #0x9591000
00666DFD8  ldrb     w8, [x8, #0xa90]
00666DFDC  cbnz     w8, #0x666dff8
00666DFE0  adrp     x0, #0x8ee6000
00666DFE4  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00666DFE8  bl       #0x382bd14 ; 
00666DFEC  mov      w8, #1
00666DFF0  adrp     x9, #0x9591000
00666DFF4  strb     w8, [x9, #0xa90]
00666DFF8  adrp     x8, #0x8ee6000
00666DFFC  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00666E000  ldr      x1, [x8]
00666E004  ldrb     w8, [x1, #0x53]
00666E008  tbnz     w8, #5, #0x666e014
00666E00C  ldr      x0, [x24, #0x230]
00666E010  b        #0x666e020 ; 
00666E014  ldr      x8, [x1, #0x60]
00666E018  mov      x0, x24
00666E01C  blr      x8
00666E020  cbz      x0, #0x666e3d0
00666E024  adrp     x8, #0x8f0f000
00666E028  ldr      x8, [x8, #0x570] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<DropItemData>() @ 0x92cfd18
00666E02C  ldr      x1, [x8]
00666E030  bl       #0x4784cec ; HotFix.Common.XListPoolHelper$$Get<object>
00666E034  ldrb     w8, [x29, #0xeca]
00666E038  mov      x24, x0
00666E03C  cbnz     w8, #0x666e054
00666E040  adrp     x0, #0x8f0f000
00666E044  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666E048  bl       #0x382bd14 ; 
00666E04C  mov      w8, #1
00666E050  strb     w8, [x29, #0xeca]
00666E054  ldr      x1, [x26]
00666E058  ldrb     w8, [x1, #0x53]
00666E05C  tbnz     w8, #5, #0x666e068
00666E060  ldr      x26, [x21, #0x10]
00666E064  b        #0x666e078 ; 
00666E068  ldr      x8, [x1, #0x60]
00666E06C  mov      x0, x21
00666E070  blr      x8
00666E074  mov      x26, x0
00666E078  cbz      x26, #0x666e3d0
00666E07C  adrp     x27, #0x9598000
00666E080  ldrb     w8, [x27, #0xfcc]
00666E084  cbnz     w8, #0x666e09c
00666E088  adrp     x0, #0x8f06000
00666E08C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00666E090  bl       #0x382bd14 ; 
00666E094  mov      w8, #1
00666E098  strb     w8, [x27, #0xfcc]
00666E09C  str      x28, [sp, #8]
00666E0A0  adrp     x8, #0x8f06000
00666E0A4  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00666E0A8  ldr      x1, [x8]
00666E0AC  ldrb     w8, [x1, #0x53]
00666E0B0  tbnz     w8, #5, #0x666e0c0
00666E0B4  ldr      x0, [x26, #0x200]
00666E0B8  mov      x28, x29
00666E0BC  b        #0x666e0d0 ; 
00666E0C0  ldr      x8, [x1, #0x60]
00666E0C4  mov      x0, x26
00666E0C8  mov      x28, x29
00666E0CC  blr      x8
00666E0D0  cbz      x0, #0x666e3d0
00666E0D4  mov      w1, w19
00666E0D8  mov      x2, xzr
00666E0DC  bl       #0x64e3708 ; LocalModels.LocalModelManager$$GetItem_battle
00666E0E0  cmp      w22, #1
00666E0E4  mov      x26, x0
00666E0E8  b.lt     #0x666e1c4
00666E0EC  adrp     x29, #0x8f0f000
00666E0F0  ldr      x29, [x29, #0x5b8] ; GLOBAL Method$System.Collections.Generic.List<DropItemData>.Add() @ 0x921ba90
00666E0F4  mov      w27, wzr
00666E0F8  and      w25, w25, #1
00666E0FC  add      x8, sp, #0x48
00666E100  mov      x0, x21
00666E104  mov      w1, w27
00666E108  bl       #0x666bf24 ; HotFix.BattleLogic.DropMgr$$GetRandomDirByIndex
00666E10C  ldr      x8, [sp, #0x58]
00666E110  ldur     q0, [sp, #0x48]
00666E114  add      x2, sp, #0x30
00666E118  add      x3, sp, #0x10
00666E11C  str      x8, [sp, #0x70]
00666E120  str      q0, [sp, #0x60]
00666E124  ldr      x9, [x23, #0x10]
00666E128  ldr      q1, [x23]
00666E12C  mov      x0, x21
00666E130  mov      w1, w20
00666E134  mov      x4, x26
00666E138  mov      w5, w27
00666E13C  mov      w6, wzr
00666E140  str      q0, [sp, #0x10]
00666E144  str      x9, [sp, #0x40]
00666E148  str      q1, [sp, #0x30]
00666E14C  str      x8, [sp, #0x20]
00666E150  bl       #0x666c230 ; HotFix.BattleLogic.DropMgr$$CreteDropData
00666E154  cbz      x0, #0x666e3d0
00666E158  mov      x1, x0
00666E15C  strb     w25, [x0, #0xcc]
00666E160  cbz      x24, #0x666e3d0
00666E164  ldr      w10, [x24, #0x1c]
00666E168  ldr      x8, [x24, #0x10]
00666E16C  ldr      x9, [x29]
00666E170  add      w10, w10, #1
00666E174  str      w10, [x24, #0x1c]
00666E178  cbz      x8, #0x666e3d0
00666E17C  ldrsw    x10, [x24, #0x18]
00666E180  ldr      w11, [x8, #0x18]
00666E184  cmp      w10, w11
00666E188  b.hs     #0x666e1a4
00666E18C  add      w9, w10, #1
00666E190  add      x0, x8, x10, lsl #3
00666E194  str      w9, [x24, #0x18]
00666E198  str      x1, [x0, #0x20]!
00666E19C  bl       #0x382bcb8 ; 
00666E1A0  b        #0x666e1b8 ; 
00666E1A4  ldr      x8, [x9, #0x20]
00666E1A8  mov      x0, x24
00666E1AC  ldr      x8, [x8, #0xc0]
00666E1B0  ldr      x2, [x8, #0x70]
00666E1B4  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
00666E1B8  add      w27, w27, #1
00666E1BC  cmp      w22, w27
00666E1C0  b.ne     #0x666e0fc
00666E1C4  mov      x0, x21
00666E1C8  mov      x1, x24
00666E1CC  bl       #0x666a808 ; HotFix.BattleLogic.DropMgr$$DropItems
00666E1D0  ldrb     w8, [x28, #0xeca]
00666E1D4  mov      x25, x28
00666E1D8  cbnz     w8, #0x666e1f0
00666E1DC  adrp     x0, #0x8f0f000
00666E1E0  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666E1E4  bl       #0x382bd14 ; 
00666E1E8  mov      w8, #1
00666E1EC  strb     w8, [x25, #0xeca]
00666E1F0  adrp     x27, #0x8f0f000
00666E1F4  ldr      x27, [x27, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666E1F8  ldr      x28, [sp, #8]
00666E1FC  adrp     x23, #0x9591000
00666E200  ldr      x1, [x27]
00666E204  ldrb     w8, [x1, #0x53]
00666E208  tbnz     w8, #5, #0x666e214
00666E20C  ldr      x22, [x21, #0x10]
00666E210  b        #0x666e224 ; 
00666E214  ldr      x8, [x1, #0x60]
00666E218  mov      x0, x21
00666E21C  blr      x8
00666E220  mov      x22, x0
00666E224  cbz      x22, #0x666e3d0
00666E228  ldrb     w8, [x23, #0xa90]
00666E22C  cbnz     w8, #0x666e244
00666E230  adrp     x0, #0x8ee6000
00666E234  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00666E238  bl       #0x382bd14 ; 
00666E23C  mov      w8, #1
00666E240  strb     w8, [x23, #0xa90]
00666E244  adrp     x8, #0x8ee6000
00666E248  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00666E24C  ldr      x1, [x8]
00666E250  ldrb     w8, [x1, #0x53]
00666E254  tbnz     w8, #5, #0x666e260
00666E258  ldr      x0, [x22, #0x230]
00666E25C  b        #0x666e26c ; 
00666E260  ldr      x8, [x1, #0x60]
00666E264  mov      x0, x22
00666E268  blr      x8
00666E26C  cbz      x0, #0x666e3d0
00666E270  adrp     x8, #0x8f0f000
00666E274  ldr      x8, [x8, #0x578] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<DropItemData>() @ 0x92cfdb8
00666E278  mov      x1, x24
00666E27C  ldr      x2, [x8]
00666E280  bl       #0x47866c4 ; HotFix.Common.XListPoolHelper$$Push<object>
00666E284  cbz      x26, #0x666e3d0
00666E288  adrp     x22, #0x9599000
00666E28C  ldrb     w8, [x22, #0xebd]
00666E290  cbnz     w8, #0x666e2a8
00666E294  adrp     x0, #0x8f0f000
00666E298  ldr      x0, [x0, #0xb8] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_dropType() @ 0x9285d80
00666E29C  bl       #0x382bd14 ; 
00666E2A0  mov      w8, #1
00666E2A4  strb     w8, [x22, #0xebd]
00666E2A8  adrp     x8, #0x8f0f000
00666E2AC  ldr      x8, [x8, #0xb8] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_dropType() @ 0x9285d80
00666E2B0  ldr      x1, [x8]
00666E2B4  ldrb     w8, [x1, #0x53]
00666E2B8  tbnz     w8, #5, #0x666e2c4
00666E2BC  ldr      w0, [x26, #0x24]
00666E2C0  b        #0x666e2d0 ; 
00666E2C4  ldr      x8, [x1, #0x60]
00666E2C8  mov      x0, x26
00666E2CC  blr      x8
00666E2D0  ldrb     w8, [x25, #0xeca]
00666E2D4  sub      w23, w0, #3
00666E2D8  cmp      w23, #5
00666E2DC  cset     w22, lo
00666E2E0  cbnz     w8, #0x666e2f8
00666E2E4  adrp     x0, #0x8f0f000
00666E2E8  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666E2EC  bl       #0x382bd14 ; 
00666E2F0  mov      w8, #1
00666E2F4  strb     w8, [x25, #0xeca]
00666E2F8  ldr      x1, [x27]
00666E2FC  ldrb     w8, [x1, #0x53]
00666E300  tbnz     w8, #5, #0x666e30c
00666E304  ldr      x21, [x21, #0x10]
00666E308  b        #0x666e31c ; 
00666E30C  ldr      x8, [x1, #0x60]
00666E310  mov      x0, x21
00666E314  blr      x8
00666E318  mov      x21, x0
00666E31C  cbz      x21, #0x666e3d0
00666E320  adrp     x24, #0x9591000
00666E324  ldrb     w8, [x24, #0xa62]
00666E328  cbnz     w8, #0x666e340
00666E32C  adrp     x0, #0x8ee6000
00666E330  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
00666E334  bl       #0x382bd14 ; 
00666E338  mov      w8, #1
00666E33C  strb     w8, [x24, #0xa62]
00666E340  adrp     x8, #0x8ee6000
00666E344  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
00666E348  ldr      x1, [x8]
00666E34C  ldrb     w8, [x1, #0x53]
00666E350  tbnz     w8, #5, #0x666e35c
00666E354  ldr      x0, [x21, #0x1f8]
00666E358  b        #0x666e368 ; 
00666E35C  ldr      x8, [x1, #0x60]
00666E360  mov      x0, x21
00666E364  blr      x8
00666E368  cbz      x0, #0x666e3d0
00666E36C  mov      w8, #0x13
00666E370  lsr      w8, w8, w23
00666E374  mov      w1, w20
00666E378  mov      x2, xzr
00666E37C  and      w21, w8, w22
00666E380  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
00666E384  cbz      w21, #0x666e3a0
00666E388  cbz      x0, #0x666e3d0
00666E38C  ldr      x8, [x0]
00666E390  mov      w1, w19
00666E394  ldr      x9, [x8, #0x588]
00666E398  ldr      x2, [x8, #0x590]
00666E39C  blr      x9
00666E3A0  ldr      x8, [x28, #0x28]
00666E3A4  ldr      x9, [sp, #0x98]
00666E3A8  cmp      x8, x9
00666E3AC  b.ne     #0x666e3d4
00666E3B0  ldp      x20, x19, [sp, #0xf0]
00666E3B4  ldp      x22, x21, [sp, #0xe0]
00666E3B8  ldp      x24, x23, [sp, #0xd0]
00666E3BC  ldp      x26, x25, [sp, #0xc0]
00666E3C0  ldp      x28, x27, [sp, #0xb0]
00666E3C4  ldp      x29, x30, [sp, #0xa0]
00666E3C8  add      sp, sp, #0x100
00666E3CC  ret      
00666E3D0  bl       #0x382bfb8 ; 
00666E3D4  bl       #0x89edb60 ; 

