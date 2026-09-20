; HotFix.BattleLogic.DropMgr$$DropItems
; RVA 0x666B0DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00666B0DC  str      x30, [sp, #-0x50]!
00666B0E0  stp      x26, x25, [sp, #0x10]
00666B0E4  stp      x24, x23, [sp, #0x20]
00666B0E8  stp      x22, x21, [sp, #0x30]
00666B0EC  stp      x20, x19, [sp, #0x40]
00666B0F0  adrp     x22, #0x9599000
00666B0F4  adrp     x23, #0x8f0f000
00666B0F8  ldrb     w8, [x22, #0xdb4]
00666B0FC  ldr      x23, [x23, #0x568] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.DropItems() @ 0x9260070
00666B100  mov      x20, x2
00666B104  mov      x21, x1
00666B108  mov      x19, x0
00666B10C  tbnz     w8, #0, #0x666b13c
00666B110  adrp     x0, #0x8f0f000
00666B114  ldr      x0, [x0, #0x568] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.DropItems() @ 0x9260070
00666B118  bl       #0x382bd14 ; 
00666B11C  adrp     x0, #0x8f0f000
00666B120  ldr      x0, [x0, #0x570] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<DropItemData>() @ 0x92cfd18
00666B124  bl       #0x382bd14 ; 
00666B128  adrp     x0, #0x8f0f000
00666B12C  ldr      x0, [x0, #0x578] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<DropItemData>() @ 0x92cfdb8
00666B130  bl       #0x382bd14 ; 
00666B134  mov      w8, #1
00666B138  strb     w8, [x22, #0xdb4]
00666B13C  ldr      x3, [x23]
00666B140  ldrb     w8, [x3, #0x53]
00666B144  tbnz     w8, #5, #0x666b184
00666B148  adrp     x23, #0x9599000
00666B14C  ldrb     w8, [x23, #0xeca]
00666B150  cbnz     w8, #0x666b168
00666B154  adrp     x0, #0x8f0f000
00666B158  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666B15C  bl       #0x382bd14 ; 
00666B160  mov      w8, #1
00666B164  strb     w8, [x23, #0xeca]
00666B168  adrp     x25, #0x8f0f000
00666B16C  ldr      x25, [x25, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666B170  ldr      x1, [x25]
00666B174  ldrb     w8, [x1, #0x53]
00666B178  tbnz     w8, #5, #0x666b1ac
00666B17C  ldr      x22, [x19, #0x10]
00666B180  b        #0x666b1bc ; 
00666B184  ldr      x4, [x3, #0x60]
00666B188  mov      x0, x19
00666B18C  mov      x1, x21
00666B190  mov      x2, x20
00666B194  ldp      x20, x19, [sp, #0x40]
00666B198  ldp      x22, x21, [sp, #0x30]
00666B19C  ldp      x24, x23, [sp, #0x20]
00666B1A0  ldp      x26, x25, [sp, #0x10]
00666B1A4  ldr      x30, [sp], #0x50
00666B1A8  br       x4
00666B1AC  ldr      x8, [x1, #0x60]
00666B1B0  mov      x0, x19
00666B1B4  blr      x8
00666B1B8  mov      x22, x0
00666B1BC  cbz      x22, #0x666b3fc
00666B1C0  adrp     x24, #0x9591000
00666B1C4  ldrb     w8, [x24, #0xa90]
00666B1C8  cbnz     w8, #0x666b1e0
00666B1CC  adrp     x0, #0x8ee6000
00666B1D0  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00666B1D4  bl       #0x382bd14 ; 
00666B1D8  mov      w8, #1
00666B1DC  strb     w8, [x24, #0xa90]
00666B1E0  adrp     x26, #0x8ee6000
00666B1E4  ldr      x26, [x26, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00666B1E8  ldr      x1, [x26]
00666B1EC  ldrb     w8, [x1, #0x53]
00666B1F0  tbnz     w8, #5, #0x666b1fc
00666B1F4  ldr      x0, [x22, #0x230]
00666B1F8  b        #0x666b208 ; 
00666B1FC  ldr      x8, [x1, #0x60]
00666B200  mov      x0, x22
00666B204  blr      x8
00666B208  cbz      x0, #0x666b3fc
00666B20C  adrp     x8, #0x8f0f000
00666B210  ldr      x8, [x8, #0x570] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<DropItemData>() @ 0x92cfd18
00666B214  ldr      x1, [x8]
00666B218  bl       #0x4784cec ; HotFix.Common.XListPoolHelper$$Get<object>
00666B21C  ldrb     w8, [x23, #0xeca]
00666B220  mov      x22, x0
00666B224  str      wzr, [sp, #0xc]
00666B228  cbnz     w8, #0x666b240
00666B22C  adrp     x0, #0x8f0f000
00666B230  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666B234  bl       #0x382bd14 ; 
00666B238  mov      w8, #1
00666B23C  strb     w8, [x23, #0xeca]
00666B240  ldr      x1, [x25]
00666B244  ldrb     w8, [x1, #0x53]
00666B248  tbnz     w8, #5, #0x666b254
00666B24C  ldr      x0, [x19, #0x10]
00666B250  b        #0x666b260 ; 
00666B254  ldr      x8, [x1, #0x60]
00666B258  mov      x0, x19
00666B25C  blr      x8
00666B260  cbz      x0, #0x666b3fc
00666B264  mov      w1, #1
00666B268  mov      x2, xzr
00666B26C  bl       #0x69fcc24 ; HotFix.BattleLogic.BattleWorldContext$$CheckBattleFlag
00666B270  tbnz     w0, #0, #0x666b28c
00666B274  add      x3, sp, #0xc
00666B278  mov      x0, x19
00666B27C  mov      x1, x21
00666B280  mov      x2, x20
00666B284  mov      x4, x22
00666B288  bl       #0x666b400 ; HotFix.BattleLogic.DropMgr$$AddDropHp
00666B28C  ldrb     w8, [x23, #0xeca]
00666B290  cbnz     w8, #0x666b2a8
00666B294  adrp     x0, #0x8f0f000
00666B298  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666B29C  bl       #0x382bd14 ; 
00666B2A0  mov      w8, #1
00666B2A4  strb     w8, [x23, #0xeca]
00666B2A8  ldr      x1, [x25]
00666B2AC  ldrb     w8, [x1, #0x53]
00666B2B0  tbnz     w8, #5, #0x666b2bc
00666B2B4  ldr      x0, [x19, #0x10]
00666B2B8  b        #0x666b2c8 ; 
00666B2BC  ldr      x8, [x1, #0x60]
00666B2C0  mov      x0, x19
00666B2C4  blr      x8
00666B2C8  cbz      x0, #0x666b3fc
00666B2CC  mov      w1, #2
00666B2D0  mov      x2, xzr
00666B2D4  bl       #0x69fcc24 ; HotFix.BattleLogic.BattleWorldContext$$CheckBattleFlag
00666B2D8  tbnz     w0, #0, #0x666b300
00666B2DC  ldr      x8, [x19]
00666B2E0  add      x3, sp, #0xc
00666B2E4  mov      x0, x19
00666B2E8  mov      x1, x21
00666B2EC  ldr      x9, [x8, #0x208]
00666B2F0  ldr      x5, [x8, #0x210]
00666B2F4  mov      x2, x20
00666B2F8  mov      x4, x22
00666B2FC  blr      x9
00666B300  ldr      x8, [x19]
00666B304  add      x3, sp, #0xc
00666B308  mov      x0, x19
00666B30C  mov      x1, x21
00666B310  ldp      x9, x5, [x8, #0x1f8]
00666B314  mov      x2, x20
00666B318  mov      x4, x22
00666B31C  blr      x9
00666B320  ldr      x8, [x19]
00666B324  add      x3, sp, #0xc
00666B328  mov      x0, x19
00666B32C  mov      x1, x21
00666B330  ldp      x9, x5, [x8, #0x1e8]
00666B334  mov      x2, x20
00666B338  mov      x4, x22
00666B33C  blr      x9
00666B340  mov      x0, x19
00666B344  mov      x1, x22
00666B348  bl       #0x666a808 ; HotFix.BattleLogic.DropMgr$$DropItems
00666B34C  ldrb     w8, [x23, #0xeca]
00666B350  cbnz     w8, #0x666b368
00666B354  adrp     x0, #0x8f0f000
00666B358  ldr      x0, [x0, #0x210] ; GLOBAL Method$HotFix.BattleLogic.DropMgr.get_WorldContext() @ 0x9260150
00666B35C  bl       #0x382bd14 ; 
00666B360  mov      w8, #1
00666B364  strb     w8, [x23, #0xeca]
00666B368  ldr      x1, [x25]
00666B36C  ldrb     w8, [x1, #0x53]
00666B370  tbnz     w8, #5, #0x666b37c
00666B374  ldr      x19, [x19, #0x10]
00666B378  b        #0x666b38c ; 
00666B37C  ldr      x8, [x1, #0x60]
00666B380  mov      x0, x19
00666B384  blr      x8
00666B388  mov      x19, x0
00666B38C  cbz      x19, #0x666b3fc
00666B390  ldrb     w8, [x24, #0xa90]
00666B394  cbnz     w8, #0x666b3ac
00666B398  adrp     x0, #0x8ee6000
00666B39C  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00666B3A0  bl       #0x382bd14 ; 
00666B3A4  mov      w8, #1
00666B3A8  strb     w8, [x24, #0xa90]
00666B3AC  ldr      x1, [x26]
00666B3B0  ldrb     w8, [x1, #0x53]
00666B3B4  tbnz     w8, #5, #0x666b3c0
00666B3B8  ldr      x0, [x19, #0x230]
00666B3BC  b        #0x666b3cc ; 
00666B3C0  ldr      x8, [x1, #0x60]
00666B3C4  mov      x0, x19
00666B3C8  blr      x8
00666B3CC  cbz      x0, #0x666b3fc
00666B3D0  adrp     x8, #0x8f0f000
00666B3D4  ldr      x8, [x8, #0x578] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<DropItemData>() @ 0x92cfdb8
00666B3D8  mov      x1, x22
00666B3DC  ldr      x2, [x8]
00666B3E0  bl       #0x47866c4 ; HotFix.Common.XListPoolHelper$$Push<object>
00666B3E4  ldp      x20, x19, [sp, #0x40]
00666B3E8  ldp      x22, x21, [sp, #0x30]
00666B3EC  ldp      x24, x23, [sp, #0x20]
00666B3F0  ldp      x26, x25, [sp, #0x10]
00666B3F4  ldr      x30, [sp], #0x50
00666B3F8  ret      
00666B3FC  bl       #0x382bfb8 ; 

