; HotFix.BattleLogic.SinglePlayerBattleManager$$CreateBattleEndEvent
; RVA 0x65C1DB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C1DB0  sub      sp, sp, #0x1d0
0065C1DB4  stp      x29, x30, [sp, #0x170]
0065C1DB8  stp      x28, x27, [sp, #0x180]
0065C1DBC  stp      x26, x25, [sp, #0x190]
0065C1DC0  stp      x24, x23, [sp, #0x1a0]
0065C1DC4  stp      x22, x21, [sp, #0x1b0]
0065C1DC8  stp      x20, x19, [sp, #0x1c0]
0065C1DCC  adrp     x20, #0x9599000
0065C1DD0  adrp     x22, #0x8f0a000
0065C1DD4  ldrb     w8, [x20, #0x53f]
0065C1DD8  ldr      x22, [x22, #0x428] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.CreateBattleEndEvent() @ 0x92aa820
0065C1DDC  mov      w21, w1
0065C1DE0  mov      x19, x0
0065C1DE4  tbnz     w8, #0, #0x65c1e5c
0065C1DE8  adrp     x0, #0x8f07000
0065C1DEC  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065C1DF0  bl       #0x382bd14 ; 
0065C1DF4  adrp     x0, #0x8ee6000
0065C1DF8  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065C1DFC  bl       #0x382bd14 ; 
0065C1E00  adrp     x0, #0x8ee3000
0065C1E04  ldr      x0, [x0, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
0065C1E08  bl       #0x382bd14 ; 
0065C1E0C  adrp     x0, #0x8f0a000
0065C1E10  ldr      x0, [x0, #0x430] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.get_Count() @ 0x9228cc8
0065C1E14  bl       #0x382bd14 ; 
0065C1E18  adrp     x0, #0x8f0a000
0065C1E1C  ldr      x0, [x0, #0x438] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<BossBattleEnd>() @ 0x929f7c0
0065C1E20  bl       #0x382bd14 ; 
0065C1E24  adrp     x0, #0x8f0a000
0065C1E28  ldr      x0, [x0, #0x440] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<GoldBattleEnd>() @ 0x929f878
0065C1E2C  bl       #0x382bd14 ; 
0065C1E30  adrp     x0, #0x8f0a000
0065C1E34  ldr      x0, [x0, #0x448] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<MainBattleEndEvent>() @ 0x929f890
0065C1E38  bl       #0x382bd14 ; 
0065C1E3C  adrp     x0, #0x8f0a000
0065C1E40  ldr      x0, [x0, #0x450] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<TowerBattleEnd>() @ 0x929f8d8
0065C1E44  bl       #0x382bd14 ; 
0065C1E48  adrp     x0, #0x8f0a000
0065C1E4C  ldr      x0, [x0, #0x428] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.CreateBattleEndEvent() @ 0x92aa820
0065C1E50  bl       #0x382bd14 ; 
0065C1E54  mov      w8, #1
0065C1E58  strb     w8, [x20, #0x53f]
0065C1E5C  ldr      x2, [x22]
0065C1E60  ldrb     w8, [x2, #0x53]
0065C1E64  tbnz     w8, #5, #0x65c1eb4
0065C1E68  add      x0, sp, #0xc0
0065C1E6C  mov      w2, #0xb0
0065C1E70  mov      w1, wzr
0065C1E74  bl       #0x89edb70 ; 
0065C1E78  adrp     x23, #0x9599000
0065C1E7C  ldrb     w8, [x23, #0x286]
0065C1E80  cbnz     w8, #0x65c1e98
0065C1E84  adrp     x0, #0x8f07000
0065C1E88  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C1E8C  bl       #0x382bd14 ; 
0065C1E90  mov      w8, #1
0065C1E94  strb     w8, [x23, #0x286]
0065C1E98  adrp     x24, #0x8f07000
0065C1E9C  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C1EA0  ldr      x1, [x24]
0065C1EA4  ldrb     w8, [x1, #0x53]
0065C1EA8  tbnz     w8, #5, #0x65c1ee0
0065C1EAC  ldr      x0, [x19, #0x80]
0065C1EB0  b        #0x65c1eec ; 
0065C1EB4  ldr      x3, [x2, #0x60]
0065C1EB8  mov      x0, x19
0065C1EBC  mov      w1, w21
0065C1EC0  ldp      x20, x19, [sp, #0x1c0]
0065C1EC4  ldp      x22, x21, [sp, #0x1b0]
0065C1EC8  ldp      x24, x23, [sp, #0x1a0]
0065C1ECC  ldp      x26, x25, [sp, #0x190]
0065C1ED0  ldp      x28, x27, [sp, #0x180]
0065C1ED4  ldp      x29, x30, [sp, #0x170]
0065C1ED8  add      sp, sp, #0x1d0
0065C1EDC  br       x3
0065C1EE0  ldr      x8, [x1, #0x60]
0065C1EE4  mov      x0, x19
0065C1EE8  blr      x8
0065C1EEC  cbz      x0, #0x65c3de0
0065C1EF0  ldr      w8, [x0, #0x1c8]
0065C1EF4  adrp     x25, #0x8f08000
0065C1EF8  ldr      x25, [x25, #0xbd8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetAllBattleSkill() @ 0x927f9b8
0065C1EFC  adrp     x26, #0x9599000
0065C1F00  sub      w8, w8, #1
0065C1F04  cmp      w8, #6
0065C1F08  b.hi     #0x65c1f84
0065C1F0C  adrp     x9, #0x1a71000
0065C1F10  add      x9, x9, #0xfd1
0065C1F14  adr      x10, #0x65c1f24
0065C1F18  ldrb     w11, [x9, x8]
0065C1F1C  add      x10, x10, x11, lsl #2
0065C1F20  br       x10
0065C1F24  ldrb     w8, [x23, #0x286]
0065C1F28  cbnz     w8, #0x65c1f40
0065C1F2C  adrp     x0, #0x8f07000
0065C1F30  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C1F34  bl       #0x382bd14 ; 
0065C1F38  mov      w8, #1
0065C1F3C  strb     w8, [x23, #0x286]
0065C1F40  ldr      x1, [x24]
0065C1F44  ldrb     w8, [x1, #0x53]
0065C1F48  tbnz     w8, #5, #0x65c2028
0065C1F4C  ldr      x20, [x19, #0x80]
0065C1F50  b        #0x65c2038 ; 
0065C1F54  ldrb     w8, [x23, #0x286]
0065C1F58  cbnz     w8, #0x65c1f70
0065C1F5C  adrp     x0, #0x8f07000
0065C1F60  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C1F64  bl       #0x382bd14 ; 
0065C1F68  mov      w8, #1
0065C1F6C  strb     w8, [x23, #0x286]
0065C1F70  ldr      x1, [x24]
0065C1F74  ldrb     w8, [x1, #0x53]
0065C1F78  tbnz     w8, #5, #0x65c2078
0065C1F7C  ldr      x20, [x19, #0x80]
0065C1F80  b        #0x65c2088 ; 
0065C1F84  mov      x27, x19
0065C1F88  ldr      x8, [x27, #0x88]!
0065C1F8C  cbnz     x8, #0x65c3de0
0065C1F90  mov      x20, xzr
0065C1F94  b        #0x65c2c60 ; 
0065C1F98  ldrb     w8, [x23, #0x286]
0065C1F9C  cbnz     w8, #0x65c1fb4
0065C1FA0  adrp     x0, #0x8f07000
0065C1FA4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C1FA8  bl       #0x382bd14 ; 
0065C1FAC  mov      w8, #1
0065C1FB0  strb     w8, [x23, #0x286]
0065C1FB4  ldr      x1, [x24]
0065C1FB8  ldrb     w8, [x1, #0x53]
0065C1FBC  tbnz     w8, #5, #0x65c20c8
0065C1FC0  ldr      x20, [x19, #0x80]
0065C1FC4  b        #0x65c20d8 ; 
0065C1FC8  ldrb     w8, [x23, #0x286]
0065C1FCC  cbnz     w8, #0x65c1fe4
0065C1FD0  adrp     x0, #0x8f07000
0065C1FD4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C1FD8  bl       #0x382bd14 ; 
0065C1FDC  mov      w8, #1
0065C1FE0  strb     w8, [x23, #0x286]
0065C1FE4  ldr      x1, [x24]
0065C1FE8  ldrb     w8, [x1, #0x53]
0065C1FEC  tbnz     w8, #5, #0x65c2118
0065C1FF0  ldr      x20, [x19, #0x80]
0065C1FF4  b        #0x65c2128 ; 
0065C1FF8  ldrb     w8, [x23, #0x286]
0065C1FFC  cbnz     w8, #0x65c2014
0065C2000  adrp     x0, #0x8f07000
0065C2004  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2008  bl       #0x382bd14 ; 
0065C200C  mov      w8, #1
0065C2010  strb     w8, [x23, #0x286]
0065C2014  ldr      x1, [x24]
0065C2018  ldrb     w8, [x1, #0x53]
0065C201C  tbnz     w8, #5, #0x65c2168
0065C2020  ldr      x20, [x19, #0x80]
0065C2024  b        #0x65c2178 ; 
0065C2028  ldr      x8, [x1, #0x60]
0065C202C  mov      x0, x19
0065C2030  blr      x8
0065C2034  mov      x20, x0
0065C2038  cbz      x20, #0x65c3de0
0065C203C  adrp     x22, #0x9591000
0065C2040  ldrb     w8, [x22, #0xa61]
0065C2044  cbnz     w8, #0x65c205c
0065C2048  adrp     x0, #0x8ee6000
0065C204C  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C2050  bl       #0x382bd14 ; 
0065C2054  mov      w8, #1
0065C2058  strb     w8, [x22, #0xa61]
0065C205C  adrp     x8, #0x8ee6000
0065C2060  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C2064  ldr      x1, [x8]
0065C2068  ldrb     w8, [x1, #0x53]
0065C206C  tbnz     w8, #5, #0x65c21b8
0065C2070  ldr      x0, [x20, #0x1e8]
0065C2074  b        #0x65c21c4 ; 
0065C2078  ldr      x8, [x1, #0x60]
0065C207C  mov      x0, x19
0065C2080  blr      x8
0065C2084  mov      x20, x0
0065C2088  cbz      x20, #0x65c3de0
0065C208C  adrp     x22, #0x9591000
0065C2090  ldrb     w8, [x22, #0xa61]
0065C2094  cbnz     w8, #0x65c20ac
0065C2098  adrp     x0, #0x8ee6000
0065C209C  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C20A0  bl       #0x382bd14 ; 
0065C20A4  mov      w8, #1
0065C20A8  strb     w8, [x22, #0xa61]
0065C20AC  adrp     x8, #0x8ee6000
0065C20B0  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C20B4  ldr      x1, [x8]
0065C20B8  ldrb     w8, [x1, #0x53]
0065C20BC  tbnz     w8, #5, #0x65c220c
0065C20C0  ldr      x0, [x20, #0x1e8]
0065C20C4  b        #0x65c2218 ; 
0065C20C8  ldr      x8, [x1, #0x60]
0065C20CC  mov      x0, x19
0065C20D0  blr      x8
0065C20D4  mov      x20, x0
0065C20D8  cbz      x20, #0x65c3de0
0065C20DC  adrp     x22, #0x9591000
0065C20E0  ldrb     w8, [x22, #0xa61]
0065C20E4  cbnz     w8, #0x65c20fc
0065C20E8  adrp     x0, #0x8ee6000
0065C20EC  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C20F0  bl       #0x382bd14 ; 
0065C20F4  mov      w8, #1
0065C20F8  strb     w8, [x22, #0xa61]
0065C20FC  adrp     x8, #0x8ee6000
0065C2100  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C2104  ldr      x1, [x8]
0065C2108  ldrb     w8, [x1, #0x53]
0065C210C  tbnz     w8, #5, #0x65c2260
0065C2110  ldr      x0, [x20, #0x1e8]
0065C2114  b        #0x65c226c ; 
0065C2118  ldr      x8, [x1, #0x60]
0065C211C  mov      x0, x19
0065C2120  blr      x8
0065C2124  mov      x20, x0
0065C2128  cbz      x20, #0x65c3de0
0065C212C  adrp     x22, #0x9591000
0065C2130  ldrb     w8, [x22, #0xa61]
0065C2134  cbnz     w8, #0x65c214c
0065C2138  adrp     x0, #0x8ee6000
0065C213C  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C2140  bl       #0x382bd14 ; 
0065C2144  mov      w8, #1
0065C2148  strb     w8, [x22, #0xa61]
0065C214C  adrp     x8, #0x8ee6000
0065C2150  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C2154  ldr      x1, [x8]
0065C2158  ldrb     w8, [x1, #0x53]
0065C215C  tbnz     w8, #5, #0x65c22b4
0065C2160  ldr      x0, [x20, #0x1e8]
0065C2164  b        #0x65c22c0 ; 
0065C2168  ldr      x8, [x1, #0x60]
0065C216C  mov      x0, x19
0065C2170  blr      x8
0065C2174  mov      x20, x0
0065C2178  cbz      x20, #0x65c3de0
0065C217C  adrp     x22, #0x9591000
0065C2180  ldrb     w8, [x22, #0xa61]
0065C2184  cbnz     w8, #0x65c219c
0065C2188  adrp     x0, #0x8ee6000
0065C218C  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C2190  bl       #0x382bd14 ; 
0065C2194  mov      w8, #1
0065C2198  strb     w8, [x22, #0xa61]
0065C219C  adrp     x8, #0x8ee6000
0065C21A0  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
0065C21A4  ldr      x1, [x8]
0065C21A8  ldrb     w8, [x1, #0x53]
0065C21AC  tbnz     w8, #5, #0x65c2308
0065C21B0  ldr      x0, [x20, #0x1e8]
0065C21B4  b        #0x65c2314 ; 
0065C21B8  ldr      x8, [x1, #0x60]
0065C21BC  mov      x0, x20
0065C21C0  blr      x8
0065C21C4  cbz      x0, #0x65c3de0
0065C21C8  adrp     x8, #0x8f0a000
0065C21CC  ldr      x8, [x8, #0x448] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<MainBattleEndEvent>() @ 0x929f890
0065C21D0  ldr      x1, [x8]
0065C21D4  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065C21D8  ldrb     w8, [x23, #0x286]
0065C21DC  mov      x20, x0
0065C21E0  cbnz     w8, #0x65c21f8
0065C21E4  adrp     x0, #0x8f07000
0065C21E8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C21EC  bl       #0x382bd14 ; 
0065C21F0  mov      w8, #1
0065C21F4  strb     w8, [x23, #0x286]
0065C21F8  ldr      x1, [x24]
0065C21FC  ldrb     w8, [x1, #0x53]
0065C2200  tbnz     w8, #5, #0x65c235c
0065C2204  ldr      x22, [x19, #0x80]
0065C2208  b        #0x65c236c ; 
0065C220C  ldr      x8, [x1, #0x60]
0065C2210  mov      x0, x20
0065C2214  blr      x8
0065C2218  cbz      x0, #0x65c3de0
0065C221C  adrp     x8, #0x8f0a000
0065C2220  ldr      x8, [x8, #0x440] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<GoldBattleEnd>() @ 0x929f878
0065C2224  ldr      x1, [x8]
0065C2228  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065C222C  ldrb     w8, [x23, #0x286]
0065C2230  mov      x20, x0
0065C2234  cbnz     w8, #0x65c224c
0065C2238  adrp     x0, #0x8f07000
0065C223C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2240  bl       #0x382bd14 ; 
0065C2244  mov      w8, #1
0065C2248  strb     w8, [x23, #0x286]
0065C224C  ldr      x1, [x24]
0065C2250  ldrb     w8, [x1, #0x53]
0065C2254  tbnz     w8, #5, #0x65c23ac
0065C2258  ldr      x22, [x19, #0x80]
0065C225C  b        #0x65c23bc ; 
0065C2260  ldr      x8, [x1, #0x60]
0065C2264  mov      x0, x20
0065C2268  blr      x8
0065C226C  cbz      x0, #0x65c3de0
0065C2270  adrp     x8, #0x8f0a000
0065C2274  ldr      x8, [x8, #0x450] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<TowerBattleEnd>() @ 0x929f8d8
0065C2278  ldr      x1, [x8]
0065C227C  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065C2280  ldrb     w8, [x23, #0x286]
0065C2284  mov      x20, x0
0065C2288  cbnz     w8, #0x65c22a0
0065C228C  adrp     x0, #0x8f07000
0065C2290  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2294  bl       #0x382bd14 ; 
0065C2298  mov      w8, #1
0065C229C  strb     w8, [x23, #0x286]
0065C22A0  ldr      x1, [x24]
0065C22A4  ldrb     w8, [x1, #0x53]
0065C22A8  tbnz     w8, #5, #0x65c23fc
0065C22AC  ldr      x22, [x19, #0x80]
0065C22B0  b        #0x65c240c ; 
0065C22B4  ldr      x8, [x1, #0x60]
0065C22B8  mov      x0, x20
0065C22BC  blr      x8
0065C22C0  cbz      x0, #0x65c3de0
0065C22C4  adrp     x8, #0x8f0a000
0065C22C8  ldr      x8, [x8, #0x438] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<BossBattleEnd>() @ 0x929f7c0
0065C22CC  ldr      x1, [x8]
0065C22D0  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065C22D4  ldrb     w8, [x23, #0x286]
0065C22D8  mov      x20, x0
0065C22DC  cbnz     w8, #0x65c22f4
0065C22E0  adrp     x0, #0x8f07000
0065C22E4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C22E8  bl       #0x382bd14 ; 
0065C22EC  mov      w8, #1
0065C22F0  strb     w8, [x23, #0x286]
0065C22F4  ldr      x1, [x24]
0065C22F8  ldrb     w8, [x1, #0x53]
0065C22FC  tbnz     w8, #5, #0x65c244c
0065C2300  ldr      x22, [x19, #0x80]
0065C2304  b        #0x65c245c ; 
0065C2308  ldr      x8, [x1, #0x60]
0065C230C  mov      x0, x20
0065C2310  blr      x8
0065C2314  cbz      x0, #0x65c3de0
0065C2318  adrp     x8, #0x8f0a000
0065C231C  ldr      x8, [x8, #0x438] ; GLOBAL Method$HotFix.BattleLogic.RenderEventPool.CreateRenderEvent<BossBattleEnd>() @ 0x929f7c0
0065C2320  ldr      x1, [x8]
0065C2324  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065C2328  ldrb     w8, [x23, #0x286]
0065C232C  mov      x20, x0
0065C2330  cbnz     w8, #0x65c2348
0065C2334  adrp     x0, #0x8f07000
0065C2338  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C233C  bl       #0x382bd14 ; 
0065C2340  mov      w8, #1
0065C2344  strb     w8, [x23, #0x286]
0065C2348  ldr      x1, [x24]
0065C234C  ldrb     w8, [x1, #0x53]
0065C2350  tbnz     w8, #5, #0x65c249c
0065C2354  ldr      x22, [x19, #0x80]
0065C2358  b        #0x65c24ac ; 
0065C235C  ldr      x8, [x1, #0x60]
0065C2360  mov      x0, x19
0065C2364  blr      x8
0065C2368  mov      x22, x0
0065C236C  cbz      x22, #0x65c3de0
0065C2370  adrp     x27, #0x9599000
0065C2374  ldrb     w8, [x27, #0x4d6]
0065C2378  cbnz     w8, #0x65c2390
0065C237C  adrp     x0, #0x8f09000
0065C2380  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C2384  bl       #0x382bd14 ; 
0065C2388  mov      w8, #1
0065C238C  strb     w8, [x27, #0x4d6]
0065C2390  adrp     x8, #0x8f09000
0065C2394  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C2398  ldr      x1, [x8]
0065C239C  ldrb     w8, [x1, #0x53]
0065C23A0  tbnz     w8, #5, #0x65c24ec
0065C23A4  ldr      w1, [x22, #0x290]
0065C23A8  b        #0x65c24fc ; 
0065C23AC  ldr      x8, [x1, #0x60]
0065C23B0  mov      x0, x19
0065C23B4  blr      x8
0065C23B8  mov      x22, x0
0065C23BC  cbz      x22, #0x65c3de0
0065C23C0  adrp     x27, #0x9599000
0065C23C4  ldrb     w8, [x27, #0x4d6]
0065C23C8  cbnz     w8, #0x65c23e0
0065C23CC  adrp     x0, #0x8f09000
0065C23D0  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C23D4  bl       #0x382bd14 ; 
0065C23D8  mov      w8, #1
0065C23DC  strb     w8, [x27, #0x4d6]
0065C23E0  adrp     x8, #0x8f09000
0065C23E4  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C23E8  ldr      x1, [x8]
0065C23EC  ldrb     w8, [x1, #0x53]
0065C23F0  tbnz     w8, #5, #0x65c2540
0065C23F4  ldr      w1, [x22, #0x290]
0065C23F8  b        #0x65c2550 ; 
0065C23FC  ldr      x8, [x1, #0x60]
0065C2400  mov      x0, x19
0065C2404  blr      x8
0065C2408  mov      x22, x0
0065C240C  cbz      x22, #0x65c3de0
0065C2410  adrp     x27, #0x9599000
0065C2414  ldrb     w8, [x27, #0x4d6]
0065C2418  cbnz     w8, #0x65c2430
0065C241C  adrp     x0, #0x8f09000
0065C2420  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C2424  bl       #0x382bd14 ; 
0065C2428  mov      w8, #1
0065C242C  strb     w8, [x27, #0x4d6]
0065C2430  adrp     x8, #0x8f09000
0065C2434  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C2438  ldr      x1, [x8]
0065C243C  ldrb     w8, [x1, #0x53]
0065C2440  tbnz     w8, #5, #0x65c2594
0065C2444  ldr      w1, [x22, #0x290]
0065C2448  b        #0x65c25a4 ; 
0065C244C  ldr      x8, [x1, #0x60]
0065C2450  mov      x0, x19
0065C2454  blr      x8
0065C2458  mov      x22, x0
0065C245C  cbz      x22, #0x65c3de0
0065C2460  adrp     x27, #0x9599000
0065C2464  ldrb     w8, [x27, #0x4d6]
0065C2468  cbnz     w8, #0x65c2480
0065C246C  adrp     x0, #0x8f09000
0065C2470  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C2474  bl       #0x382bd14 ; 
0065C2478  mov      w8, #1
0065C247C  strb     w8, [x27, #0x4d6]
0065C2480  adrp     x8, #0x8f09000
0065C2484  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C2488  ldr      x1, [x8]
0065C248C  ldrb     w8, [x1, #0x53]
0065C2490  tbnz     w8, #5, #0x65c25e8
0065C2494  ldr      w1, [x22, #0x290]
0065C2498  b        #0x65c25f8 ; 
0065C249C  ldr      x8, [x1, #0x60]
0065C24A0  mov      x0, x19
0065C24A4  blr      x8
0065C24A8  mov      x22, x0
0065C24AC  cbz      x22, #0x65c3de0
0065C24B0  adrp     x27, #0x9599000
0065C24B4  ldrb     w8, [x27, #0x4d6]
0065C24B8  cbnz     w8, #0x65c24d0
0065C24BC  adrp     x0, #0x8f09000
0065C24C0  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C24C4  bl       #0x382bd14 ; 
0065C24C8  mov      w8, #1
0065C24CC  strb     w8, [x27, #0x4d6]
0065C24D0  adrp     x8, #0x8f09000
0065C24D4  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0065C24D8  ldr      x1, [x8]
0065C24DC  ldrb     w8, [x1, #0x53]
0065C24E0  tbnz     w8, #5, #0x65c263c
0065C24E4  ldr      w1, [x22, #0x290]
0065C24E8  b        #0x65c264c ; 
0065C24EC  ldr      x8, [x1, #0x60]
0065C24F0  mov      x0, x22
0065C24F4  blr      x8
0065C24F8  mov      w1, w0
0065C24FC  cbz      x20, #0x65c3de0
0065C2500  mov      x0, x20
0065C2504  mov      w2, w21
0065C2508  mov      x3, xzr
0065C250C  bl       #0x6a3df6c ; HotFix.BattleLogic.BattleEndEvent$$Init
0065C2510  ldrb     w8, [x23, #0x286]
0065C2514  cbnz     w8, #0x65c252c
0065C2518  adrp     x0, #0x8f07000
0065C251C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2520  bl       #0x382bd14 ; 
0065C2524  mov      w8, #1
0065C2528  strb     w8, [x23, #0x286]
0065C252C  ldr      x1, [x24]
0065C2530  ldrb     w8, [x1, #0x53]
0065C2534  tbnz     w8, #5, #0x65c2690
0065C2538  ldr      x0, [x19, #0x80]
0065C253C  b        #0x65c269c ; 
0065C2540  ldr      x8, [x1, #0x60]
0065C2544  mov      x0, x22
0065C2548  blr      x8
0065C254C  mov      w1, w0
0065C2550  cbz      x20, #0x65c3de0
0065C2554  mov      x0, x20
0065C2558  mov      w2, w21
0065C255C  mov      x3, xzr
0065C2560  bl       #0x6a3df6c ; HotFix.BattleLogic.BattleEndEvent$$Init
0065C2564  ldrb     w8, [x23, #0x286]
0065C2568  cbnz     w8, #0x65c2580
0065C256C  adrp     x0, #0x8f07000
0065C2570  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2574  bl       #0x382bd14 ; 
0065C2578  mov      w8, #1
0065C257C  strb     w8, [x23, #0x286]
0065C2580  ldr      x1, [x24]
0065C2584  ldrb     w8, [x1, #0x53]
0065C2588  tbnz     w8, #5, #0x65c26dc
0065C258C  ldr      x0, [x19, #0x80]
0065C2590  b        #0x65c26e8 ; 
0065C2594  ldr      x8, [x1, #0x60]
0065C2598  mov      x0, x22
0065C259C  blr      x8
0065C25A0  mov      w1, w0
0065C25A4  cbz      x20, #0x65c3de0
0065C25A8  mov      x0, x20
0065C25AC  mov      w2, w21
0065C25B0  mov      x3, xzr
0065C25B4  bl       #0x6a3df6c ; HotFix.BattleLogic.BattleEndEvent$$Init
0065C25B8  ldrb     w8, [x23, #0x286]
0065C25BC  cbnz     w8, #0x65c25d4
0065C25C0  adrp     x0, #0x8f07000
0065C25C4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C25C8  bl       #0x382bd14 ; 
0065C25CC  mov      w8, #1
0065C25D0  strb     w8, [x23, #0x286]
0065C25D4  ldr      x1, [x24]
0065C25D8  ldrb     w8, [x1, #0x53]
0065C25DC  tbnz     w8, #5, #0x65c2728
0065C25E0  ldr      x0, [x19, #0x80]
0065C25E4  b        #0x65c2734 ; 
0065C25E8  ldr      x8, [x1, #0x60]
0065C25EC  mov      x0, x22
0065C25F0  blr      x8
0065C25F4  mov      w1, w0
0065C25F8  cbz      x20, #0x65c3de0
0065C25FC  mov      x0, x20
0065C2600  mov      w2, w21
0065C2604  mov      x3, xzr
0065C2608  bl       #0x6a3df6c ; HotFix.BattleLogic.BattleEndEvent$$Init
0065C260C  ldrb     w8, [x23, #0x286]
0065C2610  cbnz     w8, #0x65c2628
0065C2614  adrp     x0, #0x8f07000
0065C2618  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C261C  bl       #0x382bd14 ; 
0065C2620  mov      w8, #1
0065C2624  strb     w8, [x23, #0x286]
0065C2628  ldr      x1, [x24]
0065C262C  ldrb     w8, [x1, #0x53]
0065C2630  tbnz     w8, #5, #0x65c2748
0065C2634  ldr      x0, [x19, #0x80]
0065C2638  b        #0x65c2754 ; 
0065C263C  ldr      x8, [x1, #0x60]
0065C2640  mov      x0, x22
0065C2644  blr      x8
0065C2648  mov      w1, w0
0065C264C  cbz      x20, #0x65c3de0
0065C2650  mov      x0, x20
0065C2654  mov      w2, w21
0065C2658  mov      x3, xzr
0065C265C  bl       #0x6a3df6c ; HotFix.BattleLogic.BattleEndEvent$$Init
0065C2660  ldrb     w8, [x23, #0x286]
0065C2664  cbnz     w8, #0x65c267c
0065C2668  adrp     x0, #0x8f07000
0065C266C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2670  bl       #0x382bd14 ; 
0065C2674  mov      w8, #1
0065C2678  strb     w8, [x23, #0x286]
0065C267C  ldr      x1, [x24]
0065C2680  ldrb     w8, [x1, #0x53]
0065C2684  tbnz     w8, #5, #0x65c2768
0065C2688  ldr      x0, [x19, #0x80]
0065C268C  b        #0x65c2774 ; 
0065C2690  ldr      x8, [x1, #0x60]
0065C2694  mov      x0, x19
0065C2698  blr      x8
0065C269C  cbz      x0, #0x65c3de0
0065C26A0  mov      x1, x20
0065C26A4  mov      x2, xzr
0065C26A8  bl       #0x6a0ba70 ; HotFix.BattleLogic.BattleWorldContext$$FillNormalBattleEndEvent
0065C26AC  ldrb     w8, [x23, #0x286]
0065C26B0  cbnz     w8, #0x65c26c8
0065C26B4  adrp     x0, #0x8f07000
0065C26B8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C26BC  bl       #0x382bd14 ; 
0065C26C0  mov      w8, #1
0065C26C4  strb     w8, [x23, #0x286]
0065C26C8  ldr      x1, [x24]
0065C26CC  ldrb     w8, [x1, #0x53]
0065C26D0  tbnz     w8, #5, #0x65c2788
0065C26D4  ldr      x0, [x19, #0x80]
0065C26D8  b        #0x65c2794 ; 
0065C26DC  ldr      x8, [x1, #0x60]
0065C26E0  mov      x0, x19
0065C26E4  blr      x8
0065C26E8  cbz      x0, #0x65c3de0
0065C26EC  mov      x1, x20
0065C26F0  mov      x2, xzr
0065C26F4  bl       #0x6a0ba70 ; HotFix.BattleLogic.BattleWorldContext$$FillNormalBattleEndEvent
0065C26F8  ldrb     w8, [x23, #0x286]
0065C26FC  cbnz     w8, #0x65c2714
0065C2700  adrp     x0, #0x8f07000
0065C2704  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2708  bl       #0x382bd14 ; 
0065C270C  mov      w8, #1
0065C2710  strb     w8, [x23, #0x286]
0065C2714  ldr      x1, [x24]
0065C2718  ldrb     w8, [x1, #0x53]
0065C271C  tbnz     w8, #5, #0x65c27e0
0065C2720  ldr      x0, [x19, #0x80]
0065C2724  b        #0x65c27ec ; 
0065C2728  ldr      x8, [x1, #0x60]
0065C272C  mov      x0, x19
0065C2730  blr      x8
0065C2734  cbz      x0, #0x65c3de0
0065C2738  mov      x1, x20
0065C273C  mov      x2, xzr
0065C2740  bl       #0x6a0ba70 ; HotFix.BattleLogic.BattleWorldContext$$FillNormalBattleEndEvent
0065C2744  b        #0x65c2948 ; 
0065C2748  ldr      x8, [x1, #0x60]
0065C274C  mov      x0, x19
0065C2750  blr      x8
0065C2754  cbz      x0, #0x65c3de0
0065C2758  mov      x1, x20
0065C275C  mov      x2, xzr
0065C2760  bl       #0x6a0bfcc ; HotFix.BattleLogic.BattleWorldContext$$FillWorldBossBattleEnd
0065C2764  b        #0x65c2948 ; 
0065C2768  ldr      x8, [x1, #0x60]
0065C276C  mov      x0, x19
0065C2770  blr      x8
0065C2774  cbz      x0, #0x65c3de0
0065C2778  mov      x1, x20
0065C277C  mov      x2, xzr
0065C2780  bl       #0x6a0c1d0 ; HotFix.BattleLogic.BattleWorldContext$$FillBossBattleEnd
0065C2784  b        #0x65c2948 ; 
0065C2788  ldr      x8, [x1, #0x60]
0065C278C  mov      x0, x19
0065C2790  blr      x8
0065C2794  cbz      x0, #0x65c3de0
0065C2798  mov      x1, x20
0065C279C  mov      x2, xzr
0065C27A0  bl       #0x6a0be4c ; HotFix.BattleLogic.BattleWorldContext$$FillMainBattleEnd
0065C27A4  adrp     x22, #0x9599000
0065C27A8  ldrb     w8, [x22, #0x634]
0065C27AC  cbnz     w8, #0x65c27c4
0065C27B0  adrp     x0, #0x8f0a000
0065C27B4  ldr      x0, [x0, #0x458] ; GLOBAL Method$HotFix.BattleLogic.MainBattleEndEvent.set_StarMask() @ 0x928da80
0065C27B8  bl       #0x382bd14 ; 
0065C27BC  mov      w8, #1
0065C27C0  strb     w8, [x22, #0x634]
0065C27C4  adrp     x27, #0x8f0a000
0065C27C8  ldr      x27, [x27, #0x458] ; GLOBAL Method$HotFix.BattleLogic.MainBattleEndEvent.set_StarMask() @ 0x928da80
0065C27CC  ldr      x2, [x27]
0065C27D0  ldrb     w8, [x2, #0x53]
0065C27D4  tbnz     w8, #5, #0x65c2800
0065C27D8  str      wzr, [x20, #0x108]
0065C27DC  b        #0x65c2810 ; 
0065C27E0  ldr      x8, [x1, #0x60]
0065C27E4  mov      x0, x19
0065C27E8  blr      x8
0065C27EC  cbz      x0, #0x65c3de0
0065C27F0  mov      x1, x20
0065C27F4  mov      x2, xzr
0065C27F8  bl       #0x6a0b950 ; HotFix.BattleLogic.BattleWorldContext$$FillGoldBattleEnd
0065C27FC  b        #0x65c2948 ; 
0065C2800  ldr      x8, [x2, #0x60]
0065C2804  mov      x0, x20
0065C2808  mov      w1, wzr
0065C280C  blr      x8
0065C2810  ldrb     w8, [x23, #0x286]
0065C2814  cbnz     w8, #0x65c282c
0065C2818  adrp     x0, #0x8f07000
0065C281C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2820  bl       #0x382bd14 ; 
0065C2824  mov      w8, #1
0065C2828  strb     w8, [x23, #0x286]
0065C282C  ldr      x1, [x24]
0065C2830  ldrb     w8, [x1, #0x53]
0065C2834  tbnz     w8, #5, #0x65c2840
0065C2838  ldr      x0, [x19, #0x80]
0065C283C  b        #0x65c284c ; 
0065C2840  ldr      x8, [x1, #0x60]
0065C2844  mov      x0, x19
0065C2848  blr      x8
0065C284C  cbz      x0, #0x65c3de0
0065C2850  mov      w1, #0x13
0065C2854  mov      x2, xzr
0065C2858  bl       #0x69fcc24 ; HotFix.BattleLogic.BattleWorldContext$$CheckBattleFlag
0065C285C  cmp      w21, #1
0065C2860  b.ne     #0x65c2948
0065C2864  tbz      w0, #0, #0x65c2948
0065C2868  ldrb     w8, [x23, #0x286]
0065C286C  cbnz     w8, #0x65c2884
0065C2870  adrp     x0, #0x8f07000
0065C2874  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2878  bl       #0x382bd14 ; 
0065C287C  mov      w8, #1
0065C2880  strb     w8, [x23, #0x286]
0065C2884  ldr      x1, [x24]
0065C2888  ldrb     w8, [x1, #0x53]
0065C288C  tbnz     w8, #5, #0x65c2898
0065C2890  ldr      x21, [x19, #0x80]
0065C2894  b        #0x65c28a8 ; 
0065C2898  ldr      x8, [x1, #0x60]
0065C289C  mov      x0, x19
0065C28A0  blr      x8
0065C28A4  mov      x21, x0
0065C28A8  cbz      x21, #0x65c3de0
0065C28AC  adrp     x28, #0x9599000
0065C28B0  ldrb     w8, [x28, #0x2b9]
0065C28B4  cbnz     w8, #0x65c28cc
0065C28B8  adrp     x0, #0x8f08000
0065C28BC  ldr      x0, [x0, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_StarMgr() @ 0x923ffc0
0065C28C0  bl       #0x382bd14 ; 
0065C28C4  mov      w8, #1
0065C28C8  strb     w8, [x28, #0x2b9]
0065C28CC  adrp     x8, #0x8f08000
0065C28D0  ldr      x8, [x8, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_StarMgr() @ 0x923ffc0
0065C28D4  ldr      x1, [x8]
0065C28D8  ldrb     w8, [x1, #0x53]
0065C28DC  tbnz     w8, #5, #0x65c28e8
0065C28E0  ldr      x0, [x21, #0x228]
0065C28E4  b        #0x65c28f4 ; 
0065C28E8  ldr      x8, [x1, #0x60]
0065C28EC  mov      x0, x21
0065C28F0  blr      x8
0065C28F4  cbz      x0, #0x65c3de0
0065C28F8  mov      w1, #1
0065C28FC  mov      x2, xzr
0065C2900  mov      w28, #1
0065C2904  bl       #0x6595408 ; HotFix.BattleLogic.BattleStarManager$$CollectStar
0065C2908  ldrb     w8, [x22, #0x634]
0065C290C  mov      w21, w0
0065C2910  cbnz     w8, #0x65c2924
0065C2914  adrp     x0, #0x8f0a000
0065C2918  ldr      x0, [x0, #0x458] ; GLOBAL Method$HotFix.BattleLogic.MainBattleEndEvent.set_StarMask() @ 0x928da80
0065C291C  bl       #0x382bd14 ; 
0065C2920  strb     w28, [x22, #0x634]
0065C2924  ldr      x2, [x27]
0065C2928  ldrb     w8, [x2, #0x53]
0065C292C  tbnz     w8, #5, #0x65c2938
0065C2930  str      w21, [x20, #0x108]
0065C2934  b        #0x65c2948 ; 
0065C2938  ldr      x8, [x2, #0x60]
0065C293C  mov      x0, x20
0065C2940  mov      w1, w21
0065C2944  blr      x8
0065C2948  mov      x27, x19
0065C294C  ldr      x8, [x27, #0x88]!
0065C2950  cbz      x8, #0x65c2c60
0065C2954  ldr      x1, [x8, #0x2e0]
0065C2958  mov      x0, x20
0065C295C  str      x1, [x0, #0xa0]!
0065C2960  bl       #0x382bcb8 ; 
0065C2964  ldr      x0, [x27]
0065C2968  cbz      x0, #0x65c3de0
0065C296C  adrp     x8, #0x8ee6000
0065C2970  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065C2974  ldr      x1, [x8]
0065C2978  ldrb     w8, [x1, #0x53]
0065C297C  tbnz     w8, #5, #0x65c2988
0065C2980  ldr      x21, [x0, #0x38]
0065C2984  b        #0x65c2994 ; 
0065C2988  ldr      x8, [x1, #0x60]
0065C298C  blr      x8
0065C2990  mov      x21, x0
0065C2994  cbz      x21, #0x65c3de0
0065C2998  adrp     x22, #0x9591000
0065C299C  ldrb     w8, [x22, #0xa7f]
0065C29A0  cbnz     w8, #0x65c29b8
0065C29A4  adrp     x0, #0x8ee6000
0065C29A8  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
0065C29AC  bl       #0x382bd14 ; 
0065C29B0  mov      w8, #1
0065C29B4  strb     w8, [x22, #0xa7f]
0065C29B8  adrp     x8, #0x8ee6000
0065C29BC  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
0065C29C0  ldr      x1, [x8]
0065C29C4  ldrb     w8, [x1, #0x53]
0065C29C8  tbnz     w8, #5, #0x65c29d4
0065C29CC  ldr      x21, [x21, #0x178]
0065C29D0  b        #0x65c29e4 ; 
0065C29D4  ldr      x8, [x1, #0x60]
0065C29D8  mov      x0, x21
0065C29DC  blr      x8
0065C29E0  mov      x21, x0
0065C29E4  cbz      x21, #0x65c3de0
0065C29E8  mov      x0, x21
0065C29EC  mov      x1, xzr
0065C29F0  bl       #0x6b3cf00 ; HotFix.Common.AttributeData$$GetAttack
0065C29F4  adrp     x28, #0x9599000
0065C29F8  ldrb     w8, [x28, #0x635]
0065C29FC  lsr      x22, x0, #0x10
0065C2A00  cbnz     w8, #0x65c2a18
0065C2A04  adrp     x0, #0x8f0a000
0065C2A08  ldr      x0, [x0, #0x460] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_PlayerAttack() @ 0x92aa7d8
0065C2A0C  bl       #0x382bd14 ; 
0065C2A10  mov      w8, #1
0065C2A14  strb     w8, [x28, #0x635]
0065C2A18  adrp     x8, #0x8f0a000
0065C2A1C  ldr      x8, [x8, #0x460] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_PlayerAttack() @ 0x92aa7d8
0065C2A20  ldr      x2, [x8]
0065C2A24  ldrb     w8, [x2, #0x53]
0065C2A28  tbnz     w8, #5, #0x65c2a34
0065C2A2C  str      w22, [x20, #0xbc]
0065C2A30  b        #0x65c2a44 ; 
0065C2A34  ldr      x8, [x2, #0x60]
0065C2A38  mov      x0, x20
0065C2A3C  mov      w1, w22
0065C2A40  blr      x8
0065C2A44  mov      x0, x21
0065C2A48  mov      x1, xzr
0065C2A4C  bl       #0x6b3c490 ; HotFix.Common.AttributeData$$GetHpMax
0065C2A50  adrp     x22, #0x9599000
0065C2A54  ldrb     w8, [x22, #0x636]
0065C2A58  mov      w21, w0
0065C2A5C  cbnz     w8, #0x65c2a74
0065C2A60  adrp     x0, #0x8f0a000
0065C2A64  ldr      x0, [x0, #0x468] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_PlayerMaxHp() @ 0x92aa7e8
0065C2A68  bl       #0x382bd14 ; 
0065C2A6C  mov      w8, #1
0065C2A70  strb     w8, [x22, #0x636]
0065C2A74  adrp     x8, #0x8f0a000
0065C2A78  ldr      x8, [x8, #0x468] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_PlayerMaxHp() @ 0x92aa7e8
0065C2A7C  ldr      x2, [x8]
0065C2A80  ldrb     w8, [x2, #0x53]
0065C2A84  tbnz     w8, #5, #0x65c2a90
0065C2A88  str      w21, [x20, #0xc4]
0065C2A8C  b        #0x65c2aa0 ; 
0065C2A90  ldr      x8, [x2, #0x60]
0065C2A94  mov      x0, x20
0065C2A98  mov      w1, w21
0065C2A9C  blr      x8
0065C2AA0  ldr      x0, [x27]
0065C2AA4  cbz      x0, #0x65c3de0
0065C2AA8  ldr      x8, [x0]
0065C2AAC  ldr      x9, [x8, #0x498]
0065C2AB0  ldr      x1, [x8, #0x4a0]
0065C2AB4  blr      x9
0065C2AB8  adrp     x22, #0x9599000
0065C2ABC  ldrb     w8, [x22, #0x637]
0065C2AC0  mov      w21, w0
0065C2AC4  cbnz     w8, #0x65c2adc
0065C2AC8  adrp     x0, #0x8f0a000
0065C2ACC  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_PlayerCurHp() @ 0x92aa7e0
0065C2AD0  bl       #0x382bd14 ; 
0065C2AD4  mov      w8, #1
0065C2AD8  strb     w8, [x22, #0x637]
0065C2ADC  adrp     x8, #0x8f0a000
0065C2AE0  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_PlayerCurHp() @ 0x92aa7e0
0065C2AE4  ldr      x2, [x8]
0065C2AE8  ldrb     w8, [x2, #0x53]
0065C2AEC  tbnz     w8, #5, #0x65c2af8
0065C2AF0  str      w21, [x20, #0xc0]
0065C2AF4  b        #0x65c2b08 ; 
0065C2AF8  ldr      x8, [x2, #0x60]
0065C2AFC  mov      x0, x20
0065C2B00  mov      w1, w21
0065C2B04  blr      x8
0065C2B08  ldr      x0, [x27]
0065C2B0C  cbz      x0, #0x65c3de0
0065C2B10  adrp     x8, #0x8f07000
0065C2B14  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065C2B18  ldr      x1, [x8]
0065C2B1C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065C2B20  cbz      x0, #0x65c3de0
0065C2B24  ldrb     w8, [x26, #0x4b2]
0065C2B28  mov      x21, x0
0065C2B2C  cbnz     w8, #0x65c2b44
0065C2B30  adrp     x0, #0x8f08000
0065C2B34  ldr      x0, [x0, #0xbd8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetAllBattleSkill() @ 0x927f9b8
0065C2B38  bl       #0x382bd14 ; 
0065C2B3C  mov      w8, #1
0065C2B40  strb     w8, [x26, #0x4b2]
0065C2B44  ldr      x1, [x25]
0065C2B48  ldrb     w8, [x1, #0x53]
0065C2B4C  tbnz     w8, #5, #0x65c2b58
0065C2B50  ldr      x21, [x21, #0x50]
0065C2B54  b        #0x65c2b68 ; 
0065C2B58  ldr      x8, [x1, #0x60]
0065C2B5C  mov      x0, x21
0065C2B60  blr      x8
0065C2B64  mov      x21, x0
0065C2B68  adrp     x22, #0x9599000
0065C2B6C  ldrb     w8, [x22, #0x638]
0065C2B70  cbnz     w8, #0x65c2b88
0065C2B74  adrp     x0, #0x8f0a000
0065C2B78  ldr      x0, [x0, #0x478] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_AllBattleSkills() @ 0x92aa7a0
0065C2B7C  bl       #0x382bd14 ; 
0065C2B80  mov      w8, #1
0065C2B84  strb     w8, [x22, #0x638]
0065C2B88  adrp     x8, #0x8f0a000
0065C2B8C  ldr      x8, [x8, #0x478] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_AllBattleSkills() @ 0x92aa7a0
0065C2B90  ldr      x2, [x8]
0065C2B94  ldrb     w8, [x2, #0x53]
0065C2B98  tbnz     w8, #5, #0x65c2bb0
0065C2B9C  mov      x0, x20
0065C2BA0  str      x21, [x0, #0xe0]!
0065C2BA4  mov      x1, x21
0065C2BA8  bl       #0x382bcb8 ; 
0065C2BAC  b        #0x65c2bc0 ; 
0065C2BB0  ldr      x8, [x2, #0x60]
0065C2BB4  mov      x0, x20
0065C2BB8  mov      x1, x21
0065C2BBC  blr      x8
0065C2BC0  ldr      x21, [x19, #0x90]
0065C2BC4  cbz      x21, #0x65c3de0
0065C2BC8  adrp     x22, #0x9599000
0065C2BCC  ldrb     w8, [x22, #0x288]
0065C2BD0  cbnz     w8, #0x65c2be8
0065C2BD4  adrp     x0, #0x8f07000
0065C2BD8  ldr      x0, [x0, #0xd00] ; GLOBAL Method$HotFix.BattleLogic.ExpAnimProcessor.get_Level() @ 0x926a268
0065C2BDC  bl       #0x382bd14 ; 
0065C2BE0  mov      w8, #1
0065C2BE4  strb     w8, [x22, #0x288]
0065C2BE8  adrp     x8, #0x8f07000
0065C2BEC  ldr      x8, [x8, #0xd00] ; GLOBAL Method$HotFix.BattleLogic.ExpAnimProcessor.get_Level() @ 0x926a268
0065C2BF0  ldr      x1, [x8]
0065C2BF4  ldrb     w8, [x1, #0x53]
0065C2BF8  tbnz     w8, #5, #0x65c2c04
0065C2BFC  ldr      w21, [x21, #0x28]
0065C2C00  b        #0x65c2c14 ; 
0065C2C04  ldr      x8, [x1, #0x60]
0065C2C08  mov      x0, x21
0065C2C0C  blr      x8
0065C2C10  mov      w21, w0
0065C2C14  adrp     x22, #0x9599000
0065C2C18  ldrb     w8, [x22, #0x639]
0065C2C1C  cbnz     w8, #0x65c2c34
0065C2C20  adrp     x0, #0x8f0a000
0065C2C24  ldr      x0, [x0, #0x480] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_Level() @ 0x92aa7c0
0065C2C28  bl       #0x382bd14 ; 
0065C2C2C  mov      w8, #1
0065C2C30  strb     w8, [x22, #0x639]
0065C2C34  adrp     x8, #0x8f0a000
0065C2C38  ldr      x8, [x8, #0x480] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_Level() @ 0x92aa7c0
0065C2C3C  ldr      x2, [x8]
0065C2C40  ldrb     w8, [x2, #0x53]
0065C2C44  tbnz     w8, #5, #0x65c2c50
0065C2C48  str      w21, [x20, #0xc8]
0065C2C4C  b        #0x65c2c60 ; 
0065C2C50  ldr      x8, [x2, #0x60]
0065C2C54  mov      x0, x20
0065C2C58  mov      w1, w21
0065C2C5C  blr      x8
0065C2C60  ldrb     w8, [x23, #0x286]
0065C2C64  cbnz     w8, #0x65c2c7c
0065C2C68  adrp     x0, #0x8f07000
0065C2C6C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2C70  bl       #0x382bd14 ; 
0065C2C74  mov      w8, #1
0065C2C78  strb     w8, [x23, #0x286]
0065C2C7C  ldr      x1, [x24]
0065C2C80  ldrb     w8, [x1, #0x53]
0065C2C84  tbnz     w8, #5, #0x65c2c90
0065C2C88  ldr      x0, [x19, #0x80]
0065C2C8C  b        #0x65c2c9c ; 
0065C2C90  ldr      x8, [x1, #0x60]
0065C2C94  mov      x0, x19
0065C2C98  blr      x8
0065C2C9C  cbz      x0, #0x65c3de0
0065C2CA0  cbz      x20, #0x65c3de0
0065C2CA4  ldr      x8, [x0, #0x1b0]
0065C2CA8  adrp     x22, #0x9599000
0065C2CAC  ldrb     w9, [x22, #0x63a]
0065C2CB0  mov      w10, #0x640000
0065C2CB4  mul      x8, x8, x10
0065C2CB8  lsr      x21, x8, #0x20
0065C2CBC  cbnz     w9, #0x65c2cd4
0065C2CC0  adrp     x0, #0x8f0a000
0065C2CC4  ldr      x0, [x0, #0x488] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_MissionTime() @ 0x92aa7c8
0065C2CC8  bl       #0x382bd14 ; 
0065C2CCC  mov      w8, #1
0065C2CD0  strb     w8, [x22, #0x63a]
0065C2CD4  adrp     x8, #0x8f0a000
0065C2CD8  ldr      x8, [x8, #0x488] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_MissionTime() @ 0x92aa7c8
0065C2CDC  ldr      x2, [x8]
0065C2CE0  ldrb     w8, [x2, #0x53]
0065C2CE4  tbnz     w8, #5, #0x65c2cf0
0065C2CE8  str      w21, [x20, #0xcc]
0065C2CEC  b        #0x65c2d00 ; 
0065C2CF0  ldr      x8, [x2, #0x60]
0065C2CF4  mov      x0, x20
0065C2CF8  mov      w1, w21
0065C2CFC  blr      x8
0065C2D00  ldrb     w8, [x23, #0x286]
0065C2D04  cbnz     w8, #0x65c2d1c
0065C2D08  adrp     x0, #0x8f07000
0065C2D0C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2D10  bl       #0x382bd14 ; 
0065C2D14  mov      w8, #1
0065C2D18  strb     w8, [x23, #0x286]
0065C2D1C  ldr      x1, [x24]
0065C2D20  ldrb     w8, [x1, #0x53]
0065C2D24  tbnz     w8, #5, #0x65c2d30
0065C2D28  ldr      x21, [x19, #0x80]
0065C2D2C  b        #0x65c2d40 ; 
0065C2D30  ldr      x8, [x1, #0x60]
0065C2D34  mov      x0, x19
0065C2D38  blr      x8
0065C2D3C  mov      x21, x0
0065C2D40  cbz      x21, #0x65c3de0
0065C2D44  adrp     x22, #0x9599000
0065C2D48  ldrb     w8, [x22, #0x63b]
0065C2D4C  cbnz     w8, #0x65c2d64
0065C2D50  adrp     x0, #0x8f0a000
0065C2D54  ldr      x0, [x0, #0x490] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleData() @ 0x923fe48
0065C2D58  bl       #0x382bd14 ; 
0065C2D5C  mov      w8, #1
0065C2D60  strb     w8, [x22, #0x63b]
0065C2D64  adrp     x28, #0x8f0a000
0065C2D68  ldr      x28, [x28, #0x490] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleData() @ 0x923fe48
0065C2D6C  ldr      x1, [x28]
0065C2D70  ldrb     w8, [x1, #0x53]
0065C2D74  tbnz     w8, #5, #0x65c2d8c
0065C2D78  add      x1, x21, #0x290
0065C2D7C  add      x0, sp, #0x10
0065C2D80  mov      w2, #0xb0
0065C2D84  bl       #0x89edad0 ; 
0065C2D88  b        #0x65c2d9c ; 
0065C2D8C  ldr      x9, [x1, #0x60]
0065C2D90  add      x8, sp, #0x10
0065C2D94  mov      x0, x21
0065C2D98  blr      x9
0065C2D9C  add      x0, sp, #0xc0
0065C2DA0  add      x1, sp, #0x10
0065C2DA4  mov      w2, #0xb0
0065C2DA8  bl       #0x89edad0 ; 
0065C2DAC  add      x0, sp, #0xc0
0065C2DB0  mov      x1, xzr
0065C2DB4  bl       #0x658e134 ; HotFix.BattleLogic.BattleData$$get_Gold
0065C2DB8  adrp     x29, #0x9599000
0065C2DBC  ldrb     w8, [x29, #0x63c]
0065C2DC0  mov      w21, w0
0065C2DC4  cbnz     w8, #0x65c2ddc
0065C2DC8  adrp     x0, #0x8f0a000
0065C2DCC  ldr      x0, [x0, #0x498] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_Gold() @ 0x92aa7b8
0065C2DD0  bl       #0x382bd14 ; 
0065C2DD4  mov      w8, #1
0065C2DD8  strb     w8, [x29, #0x63c]
0065C2DDC  adrp     x8, #0x8f0a000
0065C2DE0  ldr      x8, [x8, #0x498] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_Gold() @ 0x92aa7b8
0065C2DE4  ldr      x2, [x8]
0065C2DE8  ldrb     w8, [x2, #0x53]
0065C2DEC  tbnz     w8, #5, #0x65c2df8
0065C2DF0  str      w21, [x20, #0xd0]
0065C2DF4  b        #0x65c2e08 ; 
0065C2DF8  ldr      x8, [x2, #0x60]
0065C2DFC  mov      x0, x20
0065C2E00  mov      w1, w21
0065C2E04  blr      x8
0065C2E08  ldrb     w8, [x23, #0x286]
0065C2E0C  cbnz     w8, #0x65c2e24
0065C2E10  adrp     x0, #0x8f07000
0065C2E14  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2E18  bl       #0x382bd14 ; 
0065C2E1C  mov      w8, #1
0065C2E20  strb     w8, [x23, #0x286]
0065C2E24  ldr      x1, [x24]
0065C2E28  ldrb     w8, [x1, #0x53]
0065C2E2C  tbnz     w8, #5, #0x65c2e38
0065C2E30  ldr      x21, [x19, #0x80]
0065C2E34  b        #0x65c2e48 ; 
0065C2E38  ldr      x8, [x1, #0x60]
0065C2E3C  mov      x0, x19
0065C2E40  blr      x8
0065C2E44  mov      x21, x0
0065C2E48  cbz      x21, #0x65c3de0
0065C2E4C  ldrb     w8, [x22, #0x63b]
0065C2E50  cbnz     w8, #0x65c2e68
0065C2E54  adrp     x0, #0x8f0a000
0065C2E58  ldr      x0, [x0, #0x490] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleData() @ 0x923fe48
0065C2E5C  bl       #0x382bd14 ; 
0065C2E60  mov      w8, #1
0065C2E64  strb     w8, [x22, #0x63b]
0065C2E68  ldr      x1, [x28]
0065C2E6C  ldrb     w8, [x1, #0x53]
0065C2E70  tbnz     w8, #5, #0x65c2e88
0065C2E74  add      x1, x21, #0x290
0065C2E78  add      x0, sp, #0x10
0065C2E7C  mov      w2, #0xb0
0065C2E80  bl       #0x89edad0 ; 
0065C2E84  b        #0x65c2e98 ; 
0065C2E88  ldr      x9, [x1, #0x60]
0065C2E8C  add      x8, sp, #0x10
0065C2E90  mov      x0, x21
0065C2E94  blr      x9
0065C2E98  add      x0, sp, #0xc0
0065C2E9C  add      x1, sp, #0x10
0065C2EA0  mov      w2, #0xb0
0065C2EA4  bl       #0x89edad0 ; 
0065C2EA8  adrp     x21, #0x9599000
0065C2EAC  ldrb     w8, [x21, #0x2a7]
0065C2EB0  cbnz     w8, #0x65c2ec8
0065C2EB4  adrp     x0, #0x8f08000
0065C2EB8  ldr      x0, [x0, #0x5a8] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_DropGold() @ 0x923c388
0065C2EBC  bl       #0x382bd14 ; 
0065C2EC0  mov      w8, #1
0065C2EC4  strb     w8, [x21, #0x2a7]
0065C2EC8  adrp     x8, #0x8f08000
0065C2ECC  ldr      x8, [x8, #0x5a8] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_DropGold() @ 0x923c388
0065C2ED0  ldr      x1, [x8]
0065C2ED4  ldrb     w8, [x1, #0x53]
0065C2ED8  tbnz     w8, #5, #0x65c2ee4
0065C2EDC  ldr      w0, [sp, #0x164]
0065C2EE0  b        #0x65c2ef0 ; 
0065C2EE4  ldr      x8, [x1, #0x60]
0065C2EE8  add      x0, sp, #0xc0
0065C2EEC  blr      x8
0065C2EF0  str      w0, [x20, #0x48]
0065C2EF4  ldrb     w8, [x23, #0x286]
0065C2EF8  cbnz     w8, #0x65c2f10
0065C2EFC  adrp     x0, #0x8f07000
0065C2F00  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2F04  bl       #0x382bd14 ; 
0065C2F08  mov      w8, #1
0065C2F0C  strb     w8, [x23, #0x286]
0065C2F10  ldr      x1, [x24]
0065C2F14  ldrb     w8, [x1, #0x53]
0065C2F18  tbnz     w8, #5, #0x65c2f24
0065C2F1C  ldr      x0, [x19, #0x80]
0065C2F20  b        #0x65c2f30 ; 
0065C2F24  ldr      x8, [x1, #0x60]
0065C2F28  mov      x0, x19
0065C2F2C  blr      x8
0065C2F30  cbz      x0, #0x65c3de0
0065C2F34  adrp     x22, #0x9599000
0065C2F38  ldrb     w8, [x22, #0x28f]
0065C2F3C  ldr      w21, [x0, #0x280]
0065C2F40  cbnz     w8, #0x65c2f58
0065C2F44  adrp     x0, #0x8f07000
0065C2F48  ldr      x0, [x0, #0xf78] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_FightFlag() @ 0x923c5b0
0065C2F4C  bl       #0x382bd14 ; 
0065C2F50  mov      w8, #1
0065C2F54  strb     w8, [x22, #0x28f]
0065C2F58  adrp     x8, #0x8f07000
0065C2F5C  ldr      x8, [x8, #0xf78] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_FightFlag() @ 0x923c5b0
0065C2F60  ldr      x2, [x8]
0065C2F64  ldrb     w8, [x2, #0x53]
0065C2F68  tbnz     w8, #5, #0x65c2f74
0065C2F6C  str      w21, [x20, #0x2c]
0065C2F70  b        #0x65c2f84 ; 
0065C2F74  ldr      x8, [x2, #0x60]
0065C2F78  mov      x0, x20
0065C2F7C  mov      w1, w21
0065C2F80  blr      x8
0065C2F84  ldrb     w8, [x23, #0x286]
0065C2F88  cbnz     w8, #0x65c2fa0
0065C2F8C  adrp     x0, #0x8f07000
0065C2F90  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C2F94  bl       #0x382bd14 ; 
0065C2F98  mov      w8, #1
0065C2F9C  strb     w8, [x23, #0x286]
0065C2FA0  ldr      x1, [x24]
0065C2FA4  ldrb     w8, [x1, #0x53]
0065C2FA8  tbnz     w8, #5, #0x65c2fb4
0065C2FAC  ldr      x0, [x19, #0x80]
0065C2FB0  b        #0x65c2fc0 ; 
0065C2FB4  ldr      x8, [x1, #0x60]
0065C2FB8  mov      x0, x19
0065C2FBC  blr      x8
0065C2FC0  cbz      x0, #0x65c3de0
0065C2FC4  adrp     x22, #0x9599000
0065C2FC8  ldrb     w8, [x22, #0x290]
0065C2FCC  ldr      w21, [x0, #0x284]
0065C2FD0  cbnz     w8, #0x65c2fe8
0065C2FD4  adrp     x0, #0x8f07000
0065C2FD8  ldr      x0, [x0, #0xf80] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_GameFlag() @ 0x923c5b8
0065C2FDC  bl       #0x382bd14 ; 
0065C2FE0  mov      w8, #1
0065C2FE4  strb     w8, [x22, #0x290]
0065C2FE8  adrp     x8, #0x8f07000
0065C2FEC  ldr      x8, [x8, #0xf80] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_GameFlag() @ 0x923c5b8
0065C2FF0  ldr      x2, [x8]
0065C2FF4  ldrb     w8, [x2, #0x53]
0065C2FF8  tbnz     w8, #5, #0x65c3004
0065C2FFC  str      w21, [x20, #0x30]
0065C3000  b        #0x65c3014 ; 
0065C3004  ldr      x8, [x2, #0x60]
0065C3008  mov      x0, x20
0065C300C  mov      w1, w21
0065C3010  blr      x8
0065C3014  ldr      x8, [x19]
0065C3018  mov      x0, x19
0065C301C  ldr      x9, [x8, #0x518]
0065C3020  ldr      x1, [x8, #0x520]
0065C3024  blr      x9
0065C3028  adrp     x22, #0x9599000
0065C302C  ldrb     w8, [x22, #0x63d]
0065C3030  mov      w21, w0
0065C3034  cbnz     w8, #0x65c304c
0065C3038  adrp     x0, #0x8f0a000
0065C303C  ldr      x0, [x0, #0x4a0] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_Wave() @ 0x92aa7f8
0065C3040  bl       #0x382bd14 ; 
0065C3044  mov      w8, #1
0065C3048  strb     w8, [x22, #0x63d]
0065C304C  adrp     x8, #0x8f0a000
0065C3050  ldr      x8, [x8, #0x4a0] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleEndEvent.set_Wave() @ 0x92aa7f8
0065C3054  ldr      x2, [x8]
0065C3058  ldrb     w8, [x2, #0x53]
0065C305C  tbnz     w8, #5, #0x65c3068
0065C3060  str      w21, [x20, #0xb4]
0065C3064  b        #0x65c3078 ; 
0065C3068  ldr      x8, [x2, #0x60]
0065C306C  mov      x0, x20
0065C3070  mov      w1, w21
0065C3074  blr      x8
0065C3078  ldr      x8, [x19]
0065C307C  mov      x0, x19
0065C3080  ldr      x9, [x8, #0x528]
0065C3084  ldr      x1, [x8, #0x530]
0065C3088  blr      x9
0065C308C  mov      w1, w0
0065C3090  mov      x0, x20
0065C3094  mov      x2, xzr
0065C3098  bl       #0x6a3f85c ; HotFix.BattleLogic.SinglePlayerBattleEndEvent$$set_ShowWaveIndex
0065C309C  ldrb     w8, [x23, #0x286]
0065C30A0  cbnz     w8, #0x65c30b8
0065C30A4  adrp     x0, #0x8f07000
0065C30A8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C30AC  bl       #0x382bd14 ; 
0065C30B0  mov      w8, #1
0065C30B4  strb     w8, [x23, #0x286]
0065C30B8  ldr      x1, [x24]
0065C30BC  ldrb     w8, [x1, #0x53]
0065C30C0  tbnz     w8, #5, #0x65c30cc
0065C30C4  ldr      x0, [x19, #0x80]
0065C30C8  b        #0x65c30d8 ; 
0065C30CC  ldr      x8, [x1, #0x60]
0065C30D0  mov      x0, x19
0065C30D4  blr      x8
0065C30D8  cbz      x0, #0x65c3de0
0065C30DC  ldrb     w8, [x0, #0x1c5]
0065C30E0  str      w8, [x20, #0xa8]
0065C30E4  ldrb     w8, [x23, #0x286]
0065C30E8  cbnz     w8, #0x65c3100
0065C30EC  adrp     x0, #0x8f07000
0065C30F0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C30F4  bl       #0x382bd14 ; 
0065C30F8  mov      w8, #1
0065C30FC  strb     w8, [x23, #0x286]
0065C3100  ldr      x1, [x24]
0065C3104  ldrb     w8, [x1, #0x53]
0065C3108  tbnz     w8, #5, #0x65c3114
0065C310C  ldr      x0, [x19, #0x80]
0065C3110  b        #0x65c3120 ; 
0065C3114  ldr      x8, [x1, #0x60]
0065C3118  mov      x0, x19
0065C311C  blr      x8
0065C3120  cbz      x0, #0x65c3de0
0065C3124  mov      x1, xzr
0065C3128  bl       #0x6a0fecc ; HotFix.BattleLogic.BattleWorldContext$$get_ReliveType
0065C312C  str      w0, [x20, #0xac]
0065C3130  ldrb     w8, [x23, #0x286]
0065C3134  cbnz     w8, #0x65c314c
0065C3138  adrp     x0, #0x8f07000
0065C313C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3140  bl       #0x382bd14 ; 
0065C3144  mov      w8, #1
0065C3148  strb     w8, [x23, #0x286]
0065C314C  ldr      x1, [x24]
0065C3150  ldrb     w8, [x1, #0x53]
0065C3154  tbnz     w8, #5, #0x65c3160
0065C3158  ldr      x0, [x19, #0x80]
0065C315C  b        #0x65c316c ; 
0065C3160  ldr      x8, [x1, #0x60]
0065C3164  mov      x0, x19
0065C3168  blr      x8
0065C316C  cbz      x0, #0x65c3de0
0065C3170  ldr      x8, [x0, #0x1d0]
0065C3174  cbz      x8, #0x65c3de0
0065C3178  ldr      x0, [x8, #0x28]
0065C317C  cbz      x0, #0x65c3de0
0065C3180  mov      x1, xzr
0065C3184  bl       #0x6a4da74 ; HotFix.BattleLogic.BattleSaveData$$DeepCopy
0065C3188  mov      x1, x0
0065C318C  mov      x0, x20
0065C3190  str      x1, [x0, #0x38]!
0065C3194  bl       #0x382bcb8 ; 
0065C3198  ldrb     w8, [x23, #0x286]
0065C319C  cbnz     w8, #0x65c31b4
0065C31A0  adrp     x0, #0x8f07000
0065C31A4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C31A8  bl       #0x382bd14 ; 
0065C31AC  mov      w8, #1
0065C31B0  strb     w8, [x23, #0x286]
0065C31B4  ldr      x1, [x24]
0065C31B8  ldrb     w8, [x1, #0x53]
0065C31BC  tbnz     w8, #5, #0x65c31c8
0065C31C0  ldr      x0, [x19, #0x80]
0065C31C4  b        #0x65c31d4 ; 
0065C31C8  ldr      x8, [x1, #0x60]
0065C31CC  mov      x0, x19
0065C31D0  blr      x8
0065C31D4  cbz      x0, #0x65c3de0
0065C31D8  ldr      x8, [x0, #0x1d0]
0065C31DC  cbz      x8, #0x65c3de0
0065C31E0  ldr      w8, [x8, #0x40]
0065C31E4  str      w8, [x20, #0x20]
0065C31E8  ldr      x0, [x27]
0065C31EC  cbz      x0, #0x65c3278
0065C31F0  adrp     x8, #0x8f07000
0065C31F4  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065C31F8  ldr      x1, [x8]
0065C31FC  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065C3200  cbz      x0, #0x65c3de0
0065C3204  ldrb     w8, [x26, #0x4b2]
0065C3208  mov      x21, x0
0065C320C  cbnz     w8, #0x65c3224
0065C3210  adrp     x0, #0x8f08000
0065C3214  ldr      x0, [x0, #0xbd8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetAllBattleSkill() @ 0x927f9b8
0065C3218  bl       #0x382bd14 ; 
0065C321C  mov      w8, #1
0065C3220  strb     w8, [x26, #0x4b2]
0065C3224  ldr      x1, [x25]
0065C3228  ldrb     w8, [x1, #0x53]
0065C322C  tbnz     w8, #5, #0x65c3238
0065C3230  ldr      x0, [x21, #0x50]
0065C3234  b        #0x65c3244 ; 
0065C3238  ldr      x8, [x1, #0x60]
0065C323C  mov      x0, x21
0065C3240  blr      x8
0065C3244  cbz      x0, #0x65c3de0
0065C3248  ldr      w8, [x0, #0x20]
0065C324C  cmp      w8, #1
0065C3250  b.lt     #0x65c3278
0065C3254  adrp     x8, #0x8ee3000
0065C3258  ldr      x8, [x8, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
0065C325C  ldr      x1, [x8]
0065C3260  bl       #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
0065C3264  adrp     x22, #0x9599000
0065C3268  ldrb     w8, [x22, #0x63e]
0065C326C  mov      x21, x0
0065C3270  cbnz     w8, #0x65c32ec
0065C3274  b        #0x65c32d8 ; 
0065C3278  ldrb     w8, [x23, #0x286]
0065C327C  cbnz     w8, #0x65c3294
0065C3280  adrp     x0, #0x8f07000
0065C3284  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3288  bl       #0x382bd14 ; 
0065C328C  mov      w8, #1
0065C3290  strb     w8, [x23, #0x286]
0065C3294  ldr      x1, [x24]
0065C3298  ldrb     w8, [x1, #0x53]
0065C329C  tbnz     w8, #5, #0x65c32a8
0065C32A0  ldr      x0, [x19, #0x80]
0065C32A4  b        #0x65c32b4 ; 
0065C32A8  ldr      x8, [x1, #0x60]
0065C32AC  mov      x0, x19
0065C32B0  blr      x8
0065C32B4  cbz      x0, #0x65c3de0
0065C32B8  ldr      x8, [x0, #0x1d0]
0065C32BC  cbz      x8, #0x65c3de0
0065C32C0  ldr      x8, [x8, #0x28]
0065C32C4  cbz      x8, #0x65c3de0
0065C32C8  adrp     x22, #0x9599000
0065C32CC  ldrb     w9, [x22, #0x63e]
0065C32D0  ldr      x21, [x8, #0x60]
0065C32D4  cbnz     w9, #0x65c32ec
0065C32D8  adrp     x0, #0x8f0a000
0065C32DC  ldr      x0, [x0, #0x4a8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_AllSkills() @ 0x923c598
0065C32E0  bl       #0x382bd14 ; 
0065C32E4  mov      w8, #1
0065C32E8  strb     w8, [x22, #0x63e]
0065C32EC  adrp     x8, #0x8f0a000
0065C32F0  ldr      x8, [x8, #0x4a8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_AllSkills() @ 0x923c598
0065C32F4  ldr      x2, [x8]
0065C32F8  ldrb     w8, [x2, #0x53]
0065C32FC  tbnz     w8, #5, #0x65c3314
0065C3300  mov      x0, x20
0065C3304  str      x21, [x0, #0x50]!
0065C3308  mov      x1, x21
0065C330C  bl       #0x382bcb8 ; 
0065C3310  b        #0x65c3324 ; 
0065C3314  ldr      x8, [x2, #0x60]
0065C3318  mov      x0, x20
0065C331C  mov      x1, x21
0065C3320  blr      x8
0065C3324  adrp     x21, #0x9599000
0065C3328  ldrb     w8, [x21, #0x63f]
0065C332C  cbnz     w8, #0x65c3344
0065C3330  adrp     x0, #0x8f0a000
0065C3334  ldr      x0, [x0, #0x4b0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_IsChapterSurvivor() @ 0x923c5c8
0065C3338  bl       #0x382bd14 ; 
0065C333C  mov      w8, #1
0065C3340  strb     w8, [x21, #0x63f]
0065C3344  adrp     x8, #0x8f0a000
0065C3348  ldr      x8, [x8, #0x4b0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_IsChapterSurvivor() @ 0x923c5c8
0065C334C  ldr      x2, [x8]
0065C3350  ldrb     w8, [x2, #0x53]
0065C3354  tbnz     w8, #5, #0x65c3360
0065C3358  strb     wzr, [x20, #0x58]
0065C335C  b        #0x65c3370 ; 
0065C3360  ldr      x8, [x2, #0x60]
0065C3364  mov      x0, x20
0065C3368  mov      w1, wzr
0065C336C  blr      x8
0065C3370  ldrb     w8, [x23, #0x286]
0065C3374  cbnz     w8, #0x65c338c
0065C3378  adrp     x0, #0x8f07000
0065C337C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3380  bl       #0x382bd14 ; 
0065C3384  mov      w8, #1
0065C3388  strb     w8, [x23, #0x286]
0065C338C  ldr      x1, [x24]
0065C3390  ldrb     w8, [x1, #0x53]
0065C3394  tbnz     w8, #5, #0x65c33a0
0065C3398  ldr      x21, [x19, #0x80]
0065C339C  b        #0x65c33b0 ; 
0065C33A0  ldr      x8, [x1, #0x60]
0065C33A4  mov      x0, x19
0065C33A8  blr      x8
0065C33AC  mov      x21, x0
0065C33B0  cbz      x21, #0x65c3de0
0065C33B4  adrp     x22, #0x9598000
0065C33B8  ldrb     w8, [x22, #0xfc4]
0065C33BC  cbnz     w8, #0x65c33d4
0065C33C0  adrp     x0, #0x8f05000
0065C33C4  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065C33C8  bl       #0x382bd14 ; 
0065C33CC  mov      w8, #1
0065C33D0  strb     w8, [x22, #0xfc4]
0065C33D4  adrp     x8, #0x8f05000
0065C33D8  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065C33DC  ldr      x1, [x8]
0065C33E0  ldrb     w8, [x1, #0x53]
0065C33E4  tbnz     w8, #5, #0x65c33f0
0065C33E8  ldr      x0, [x21, #0x220]
0065C33EC  b        #0x65c33fc ; 
0065C33F0  ldr      x8, [x1, #0x60]
0065C33F4  mov      x0, x21
0065C33F8  blr      x8
0065C33FC  cbz      x0, #0x65c3de0
0065C3400  mov      x1, xzr
0065C3404  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
0065C3408  adrp     x22, #0x9599000
0065C340C  ldrb     w8, [x22, #0x291]
0065C3410  and      w21, w0, #1
0065C3414  cbnz     w8, #0x65c342c
0065C3418  adrp     x0, #0x8f07000
0065C341C  ldr      x0, [x0, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_IsChapterBoss() @ 0x923c5c0
0065C3420  bl       #0x382bd14 ; 
0065C3424  mov      w8, #1
0065C3428  strb     w8, [x22, #0x291]
0065C342C  adrp     x8, #0x8f07000
0065C3430  ldr      x8, [x8, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_IsChapterBoss() @ 0x923c5c0
0065C3434  ldr      x2, [x8]
0065C3438  ldrb     w8, [x2, #0x53]
0065C343C  tbnz     w8, #5, #0x65c3448
0065C3440  strb     w21, [x20, #0x59]
0065C3444  b        #0x65c3458 ; 
0065C3448  ldr      x8, [x2, #0x60]
0065C344C  mov      x0, x20
0065C3450  mov      w1, w21
0065C3454  blr      x8
0065C3458  ldrb     w8, [x23, #0x286]
0065C345C  cbnz     w8, #0x65c3474
0065C3460  adrp     x0, #0x8f07000
0065C3464  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3468  bl       #0x382bd14 ; 
0065C346C  mov      w8, #1
0065C3470  strb     w8, [x23, #0x286]
0065C3474  ldr      x1, [x24]
0065C3478  ldrb     w8, [x1, #0x53]
0065C347C  tbnz     w8, #5, #0x65c3488
0065C3480  ldr      x21, [x19, #0x80]
0065C3484  b        #0x65c3498 ; 
0065C3488  ldr      x8, [x1, #0x60]
0065C348C  mov      x0, x19
0065C3490  blr      x8
0065C3494  mov      x21, x0
0065C3498  cbz      x21, #0x65c3de0
0065C349C  adrp     x22, #0x9594000
0065C34A0  ldrb     w8, [x22, #0x273]
0065C34A4  cbnz     w8, #0x65c34bc
0065C34A8  adrp     x0, #0x8ee9000
0065C34AC  ldr      x0, [x0, #0xf20] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleFrame() @ 0x923fe58
0065C34B0  bl       #0x382bd14 ; 
0065C34B4  mov      w8, #1
0065C34B8  strb     w8, [x22, #0x273]
0065C34BC  adrp     x25, #0x8ee9000
0065C34C0  ldr      x25, [x25, #0xf20] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleFrame() @ 0x923fe58
0065C34C4  ldr      x1, [x25]
0065C34C8  ldrb     w8, [x1, #0x53]
0065C34CC  tbnz     w8, #5, #0x65c34d8
0065C34D0  ldr      w21, [x21, #0x1f0]
0065C34D4  b        #0x65c34e8 ; 
0065C34D8  ldr      x8, [x1, #0x60]
0065C34DC  mov      x0, x21
0065C34E0  blr      x8
0065C34E4  mov      w21, w0
0065C34E8  adrp     x26, #0x9599000
0065C34EC  ldrb     w8, [x26, #0x295]
0065C34F0  cbnz     w8, #0x65c3508
0065C34F4  adrp     x0, #0x8f07000
0065C34F8  ldr      x0, [x0, #0xfa8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordTimes() @ 0x923c5f8
0065C34FC  bl       #0x382bd14 ; 
0065C3500  mov      w8, #1
0065C3504  strb     w8, [x26, #0x295]
0065C3508  adrp     x8, #0x8f07000
0065C350C  ldr      x8, [x8, #0xfa8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordTimes() @ 0x923c5f8
0065C3510  ldr      x2, [x8]
0065C3514  ldrb     w8, [x2, #0x53]
0065C3518  tbnz     w8, #5, #0x65c3524
0065C351C  str      w21, [x20, #0x5c]
0065C3520  b        #0x65c3534 ; 
0065C3524  ldr      x8, [x2, #0x60]
0065C3528  mov      x0, x20
0065C352C  mov      w1, w21
0065C3530  blr      x8
0065C3534  ldrb     w8, [x23, #0x286]
0065C3538  cbnz     w8, #0x65c3550
0065C353C  adrp     x0, #0x8f07000
0065C3540  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3544  bl       #0x382bd14 ; 
0065C3548  mov      w8, #1
0065C354C  strb     w8, [x23, #0x286]
0065C3550  ldr      x1, [x24]
0065C3554  ldrb     w8, [x1, #0x53]
0065C3558  tbnz     w8, #5, #0x65c3564
0065C355C  ldr      x0, [x19, #0x80]
0065C3560  b        #0x65c3570 ; 
0065C3564  ldr      x8, [x1, #0x60]
0065C3568  mov      x0, x19
0065C356C  blr      x8
0065C3570  cbz      x0, #0x65c3de0
0065C3574  adrp     x26, #0x9599000
0065C3578  ldrb     w8, [x26, #0x640]
0065C357C  ldr      x21, [x0, #0x430]
0065C3580  cbnz     w8, #0x65c3598
0065C3584  adrp     x0, #0x8f0a000
0065C3588  ldr      x0, [x0, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordAllDamage() @ 0x923c5d0
0065C358C  bl       #0x382bd14 ; 
0065C3590  mov      w8, #1
0065C3594  strb     w8, [x26, #0x640]
0065C3598  adrp     x8, #0x8f0a000
0065C359C  ldr      x8, [x8, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordAllDamage() @ 0x923c5d0
0065C35A0  ldr      x2, [x8]
0065C35A4  ldrb     w8, [x2, #0x53]
0065C35A8  tbnz     w8, #5, #0x65c35b4
0065C35AC  str      x21, [x20, #0x68]
0065C35B0  b        #0x65c35c4 ; 
0065C35B4  ldr      x8, [x2, #0x60]
0065C35B8  mov      x0, x20
0065C35BC  mov      x1, x21
0065C35C0  blr      x8
0065C35C4  ldrb     w8, [x23, #0x286]
0065C35C8  cbnz     w8, #0x65c35e0
0065C35CC  adrp     x0, #0x8f07000
0065C35D0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C35D4  bl       #0x382bd14 ; 
0065C35D8  mov      w8, #1
0065C35DC  strb     w8, [x23, #0x286]
0065C35E0  ldr      x1, [x24]
0065C35E4  ldrb     w8, [x1, #0x53]
0065C35E8  tbnz     w8, #5, #0x65c35f4
0065C35EC  ldr      x0, [x19, #0x80]
0065C35F0  b        #0x65c3600 ; 
0065C35F4  ldr      x8, [x1, #0x60]
0065C35F8  mov      x0, x19
0065C35FC  blr      x8
0065C3600  cbz      x0, #0x65c3de0
0065C3604  mov      x1, xzr
0065C3608  bl       #0x6a22d68 ; HotFix.BattleLogic.BattleWorldContext$$get_AllBeHitCount
0065C360C  adrp     x26, #0x9599000
0065C3610  ldrb     w8, [x26, #0x641]
0065C3614  mov      w21, w0
0065C3618  cbnz     w8, #0x65c3630
0065C361C  adrp     x0, #0x8f0a000
0065C3620  ldr      x0, [x0, #0x4c0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordBeHitCount() @ 0x923c5d8
0065C3624  bl       #0x382bd14 ; 
0065C3628  mov      w8, #1
0065C362C  strb     w8, [x26, #0x641]
0065C3630  adrp     x8, #0x8f0a000
0065C3634  ldr      x8, [x8, #0x4c0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordBeHitCount() @ 0x923c5d8
0065C3638  ldr      x2, [x8]
0065C363C  ldrb     w8, [x2, #0x53]
0065C3640  tbnz     w8, #5, #0x65c364c
0065C3644  str      w21, [x20, #0x64]
0065C3648  b        #0x65c365c ; 
0065C364C  ldr      x8, [x2, #0x60]
0065C3650  mov      x0, x20
0065C3654  mov      w1, w21
0065C3658  blr      x8
0065C365C  ldrb     w8, [x23, #0x286]
0065C3660  cbnz     w8, #0x65c3678
0065C3664  adrp     x0, #0x8f07000
0065C3668  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C366C  bl       #0x382bd14 ; 
0065C3670  mov      w8, #1
0065C3674  strb     w8, [x23, #0x286]
0065C3678  ldr      x1, [x24]
0065C367C  ldrb     w8, [x1, #0x53]
0065C3680  tbnz     w8, #5, #0x65c368c
0065C3684  ldr      x0, [x19, #0x80]
0065C3688  b        #0x65c3698 ; 
0065C368C  ldr      x8, [x1, #0x60]
0065C3690  mov      x0, x19
0065C3694  blr      x8
0065C3698  cbz      x0, #0x65c3de0
0065C369C  adrp     x26, #0x9599000
0065C36A0  ldrb     w8, [x26, #0x642]
0065C36A4  ldr      w21, [x0, #0x438]
0065C36A8  cbnz     w8, #0x65c36c0
0065C36AC  adrp     x0, #0x8f0a000
0065C36B0  ldr      x0, [x0, #0x4c8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordMaxDamage() @ 0x923c5e8
0065C36B4  bl       #0x382bd14 ; 
0065C36B8  mov      w8, #1
0065C36BC  strb     w8, [x26, #0x642]
0065C36C0  adrp     x8, #0x8f0a000
0065C36C4  ldr      x8, [x8, #0x4c8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordMaxDamage() @ 0x923c5e8
0065C36C8  ldr      x2, [x8]
0065C36CC  ldrb     w8, [x2, #0x53]
0065C36D0  tbnz     w8, #5, #0x65c36dc
0065C36D4  str      w21, [x20, #0x70]
0065C36D8  b        #0x65c36ec ; 
0065C36DC  ldr      x8, [x2, #0x60]
0065C36E0  mov      x0, x20
0065C36E4  mov      w1, w21
0065C36E8  blr      x8
0065C36EC  ldrb     w8, [x23, #0x286]
0065C36F0  cbnz     w8, #0x65c3708
0065C36F4  adrp     x0, #0x8f07000
0065C36F8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C36FC  bl       #0x382bd14 ; 
0065C3700  mov      w8, #1
0065C3704  strb     w8, [x23, #0x286]
0065C3708  ldr      x1, [x24]
0065C370C  ldrb     w8, [x1, #0x53]
0065C3710  tbnz     w8, #5, #0x65c371c
0065C3714  ldr      x21, [x19, #0x80]
0065C3718  b        #0x65c372c ; 
0065C371C  ldr      x8, [x1, #0x60]
0065C3720  mov      x0, x19
0065C3724  blr      x8
0065C3728  mov      x21, x0
0065C372C  cbz      x21, #0x65c3de0
0065C3730  adrp     x26, #0x9599000
0065C3734  ldrb     w8, [x26, #0x2a3]
0065C3738  cbnz     w8, #0x65c3750
0065C373C  adrp     x0, #0x8f08000
0065C3740  ldr      x0, [x0, #0x2c8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_KillCount() @ 0x923ff08
0065C3744  bl       #0x382bd14 ; 
0065C3748  mov      w8, #1
0065C374C  strb     w8, [x26, #0x2a3]
0065C3750  adrp     x8, #0x8f08000
0065C3754  ldr      x8, [x8, #0x2c8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_KillCount() @ 0x923ff08
0065C3758  ldr      x1, [x8]
0065C375C  ldrb     w8, [x1, #0x53]
0065C3760  tbnz     w8, #5, #0x65c37a0
0065C3764  adrp     x26, #0x9599000
0065C3768  ldrb     w8, [x26, #0x2ac]
0065C376C  cbnz     w8, #0x65c3784
0065C3770  adrp     x0, #0x8f08000
0065C3774  ldr      x0, [x0, #0x2d0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_KillCount() @ 0x923c398
0065C3778  bl       #0x382bd14 ; 
0065C377C  mov      w8, #1
0065C3780  strb     w8, [x26, #0x2ac]
0065C3784  adrp     x8, #0x8f08000
0065C3788  ldr      x8, [x8, #0x2d0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_KillCount() @ 0x923c398
0065C378C  ldr      x1, [x8]
0065C3790  ldrb     w8, [x1, #0x53]
0065C3794  tbnz     w8, #5, #0x65c37ac
0065C3798  ldr      w21, [x21, #0x320]
0065C379C  b        #0x65c37bc ; 
0065C37A0  ldr      x8, [x1, #0x60]
0065C37A4  mov      x0, x21
0065C37A8  b        #0x65c37b4 ; 
0065C37AC  ldr      x8, [x1, #0x60]
0065C37B0  add      x0, x21, #0x290
0065C37B4  blr      x8
0065C37B8  mov      w21, w0
0065C37BC  adrp     x26, #0x9599000
0065C37C0  ldrb     w8, [x26, #0x643]
0065C37C4  cbnz     w8, #0x65c37dc
0065C37C8  adrp     x0, #0x8f0a000
0065C37CC  ldr      x0, [x0, #0x4d0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordKillCount() @ 0x923c5e0
0065C37D0  bl       #0x382bd14 ; 
0065C37D4  mov      w8, #1
0065C37D8  strb     w8, [x26, #0x643]
0065C37DC  adrp     x8, #0x8f0a000
0065C37E0  ldr      x8, [x8, #0x4d0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordKillCount() @ 0x923c5e0
0065C37E4  ldr      x2, [x8]
0065C37E8  ldrb     w8, [x2, #0x53]
0065C37EC  tbnz     w8, #5, #0x65c37f8
0065C37F0  str      w21, [x20, #0x60]
0065C37F4  b        #0x65c3808 ; 
0065C37F8  ldr      x8, [x2, #0x60]
0065C37FC  mov      x0, x20
0065C3800  mov      w1, w21
0065C3804  blr      x8
0065C3808  ldrb     w8, [x23, #0x286]
0065C380C  cbnz     w8, #0x65c3824
0065C3810  adrp     x0, #0x8f07000
0065C3814  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3818  bl       #0x382bd14 ; 
0065C381C  mov      w8, #1
0065C3820  strb     w8, [x23, #0x286]
0065C3824  ldr      x1, [x24]
0065C3828  ldrb     w8, [x1, #0x53]
0065C382C  tbnz     w8, #5, #0x65c3838
0065C3830  ldr      x21, [x19, #0x80]
0065C3834  b        #0x65c3848 ; 
0065C3838  ldr      x8, [x1, #0x60]
0065C383C  mov      x0, x19
0065C3840  blr      x8
0065C3844  mov      x21, x0
0065C3848  cbz      x21, #0x65c3de0
0065C384C  adrp     x26, #0x9599000
0065C3850  ldrb     w8, [x26, #0x4af]
0065C3854  cbnz     w8, #0x65c386c
0065C3858  adrp     x0, #0x8f08000
0065C385C  ldr      x0, [x0, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
0065C3860  bl       #0x382bd14 ; 
0065C3864  mov      w8, #1
0065C3868  strb     w8, [x26, #0x4af]
0065C386C  adrp     x8, #0x8f08000
0065C3870  ldr      x8, [x8, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
0065C3874  ldr      x1, [x8]
0065C3878  ldrb     w8, [x1, #0x53]
0065C387C  tbnz     w8, #5, #0x65c3888
0065C3880  ldr      w21, [x21, #0x2d0]
0065C3884  b        #0x65c3898 ; 
0065C3888  ldr      x8, [x1, #0x60]
0065C388C  mov      x0, x21
0065C3890  blr      x8
0065C3894  mov      w21, w0
0065C3898  adrp     x26, #0x9599000
0065C389C  ldrb     w8, [x26, #0x644]
0065C38A0  cbnz     w8, #0x65c38b8
0065C38A4  adrp     x0, #0x8f0a000
0065C38A8  ldr      x0, [x0, #0x4d8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordReliveCount() @ 0x923c5f0
0065C38AC  bl       #0x382bd14 ; 
0065C38B0  mov      w8, #1
0065C38B4  strb     w8, [x26, #0x644]
0065C38B8  adrp     x8, #0x8f0a000
0065C38BC  ldr      x8, [x8, #0x4d8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordReliveCount() @ 0x923c5f0
0065C38C0  ldr      x2, [x8]
0065C38C4  ldrb     w8, [x2, #0x53]
0065C38C8  tbnz     w8, #5, #0x65c38d4
0065C38CC  str      w21, [x20, #0x74]
0065C38D0  b        #0x65c38e4 ; 
0065C38D4  ldr      x8, [x2, #0x60]
0065C38D8  mov      x0, x20
0065C38DC  mov      w1, w21
0065C38E0  blr      x8
0065C38E4  ldrb     w8, [x23, #0x286]
0065C38E8  cbnz     w8, #0x65c3900
0065C38EC  adrp     x0, #0x8f07000
0065C38F0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C38F4  bl       #0x382bd14 ; 
0065C38F8  mov      w8, #1
0065C38FC  strb     w8, [x23, #0x286]
0065C3900  ldr      x1, [x24]
0065C3904  ldrb     w8, [x1, #0x53]
0065C3908  tbnz     w8, #5, #0x65c3914
0065C390C  ldr      x0, [x19, #0x80]
0065C3910  b        #0x65c3920 ; 
0065C3914  ldr      x8, [x1, #0x60]
0065C3918  mov      x0, x19
0065C391C  blr      x8
0065C3920  cbz      x0, #0x65c3de0
0065C3924  adrp     x26, #0x9599000
0065C3928  ldrb     w8, [x26, #0x645]
0065C392C  ldr      x21, [x0, #0x450]
0065C3930  cbnz     w8, #0x65c3948
0065C3934  adrp     x0, #0x8f0a000
0065C3938  ldr      x0, [x0, #0x4e0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_DeathInfo() @ 0x923c5a8
0065C393C  bl       #0x382bd14 ; 
0065C3940  mov      w8, #1
0065C3944  strb     w8, [x26, #0x645]
0065C3948  adrp     x8, #0x8f0a000
0065C394C  ldr      x8, [x8, #0x4e0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_DeathInfo() @ 0x923c5a8
0065C3950  ldr      x2, [x8]
0065C3954  ldrb     w8, [x2, #0x53]
0065C3958  tbnz     w8, #5, #0x65c3970
0065C395C  mov      x0, x20
0065C3960  str      x21, [x0, #0x78]!
0065C3964  mov      x1, x21
0065C3968  bl       #0x382bcb8 ; 
0065C396C  b        #0x65c3980 ; 
0065C3970  ldr      x8, [x2, #0x60]
0065C3974  mov      x0, x20
0065C3978  mov      x1, x21
0065C397C  blr      x8
0065C3980  ldrb     w8, [x23, #0x286]
0065C3984  cbnz     w8, #0x65c399c
0065C3988  adrp     x0, #0x8f07000
0065C398C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3990  bl       #0x382bd14 ; 
0065C3994  mov      w8, #1
0065C3998  strb     w8, [x23, #0x286]
0065C399C  ldr      x1, [x24]
0065C39A0  ldrb     w8, [x1, #0x53]
0065C39A4  tbnz     w8, #5, #0x65c39b0
0065C39A8  ldr      x0, [x19, #0x80]
0065C39AC  b        #0x65c39bc ; 
0065C39B0  ldr      x8, [x1, #0x60]
0065C39B4  mov      x0, x19
0065C39B8  blr      x8
0065C39BC  cbz      x0, #0x65c3de0
0065C39C0  adrp     x26, #0x9599000
0065C39C4  ldrb     w8, [x26, #0x292]
0065C39C8  ldr      w21, [x0, #0x440]
0065C39CC  cbnz     w8, #0x65c39e4
0065C39D0  adrp     x0, #0x8f07000
0065C39D4  ldr      x0, [x0, #0xf90] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveKillCount() @ 0x923c610
0065C39D8  bl       #0x382bd14 ; 
0065C39DC  mov      w8, #1
0065C39E0  strb     w8, [x26, #0x292]
0065C39E4  adrp     x8, #0x8f07000
0065C39E8  ldr      x8, [x8, #0xf90] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveKillCount() @ 0x923c610
0065C39EC  ldr      x2, [x8]
0065C39F0  ldrb     w8, [x2, #0x53]
0065C39F4  tbnz     w8, #5, #0x65c3a00
0065C39F8  str      w21, [x20, #0x90]
0065C39FC  b        #0x65c3a10 ; 
0065C3A00  ldr      x8, [x2, #0x60]
0065C3A04  mov      x0, x20
0065C3A08  mov      w1, w21
0065C3A0C  blr      x8
0065C3A10  ldrb     w8, [x23, #0x286]
0065C3A14  cbnz     w8, #0x65c3a2c
0065C3A18  adrp     x0, #0x8f07000
0065C3A1C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3A20  bl       #0x382bd14 ; 
0065C3A24  mov      w8, #1
0065C3A28  strb     w8, [x23, #0x286]
0065C3A2C  ldr      x1, [x24]
0065C3A30  ldrb     w8, [x1, #0x53]
0065C3A34  tbnz     w8, #5, #0x65c3a40
0065C3A38  ldr      x0, [x19, #0x80]
0065C3A3C  b        #0x65c3a4c ; 
0065C3A40  ldr      x8, [x1, #0x60]
0065C3A44  mov      x0, x19
0065C3A48  blr      x8
0065C3A4C  cbz      x0, #0x65c3de0
0065C3A50  adrp     x26, #0x9599000
0065C3A54  ldrb     w8, [x26, #0x293]
0065C3A58  ldr      w21, [x0, #0x43c]
0065C3A5C  cbnz     w8, #0x65c3a74
0065C3A60  adrp     x0, #0x8f07000
0065C3A64  ldr      x0, [x0, #0xf98] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveMaxDamage() @ 0x923c618
0065C3A68  bl       #0x382bd14 ; 
0065C3A6C  mov      w8, #1
0065C3A70  strb     w8, [x26, #0x293]
0065C3A74  adrp     x8, #0x8f07000
0065C3A78  ldr      x8, [x8, #0xf98] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveMaxDamage() @ 0x923c618
0065C3A7C  ldr      x2, [x8]
0065C3A80  ldrb     w8, [x2, #0x53]
0065C3A84  tbnz     w8, #5, #0x65c3a90
0065C3A88  str      w21, [x20, #0x8c]
0065C3A8C  b        #0x65c3aa0 ; 
0065C3A90  ldr      x8, [x2, #0x60]
0065C3A94  mov      x0, x20
0065C3A98  mov      w1, w21
0065C3A9C  blr      x8
0065C3AA0  ldrb     w8, [x23, #0x286]
0065C3AA4  cbnz     w8, #0x65c3abc
0065C3AA8  adrp     x0, #0x8f07000
0065C3AAC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3AB0  bl       #0x382bd14 ; 
0065C3AB4  mov      w8, #1
0065C3AB8  strb     w8, [x23, #0x286]
0065C3ABC  ldr      x1, [x24]
0065C3AC0  ldrb     w8, [x1, #0x53]
0065C3AC4  tbnz     w8, #5, #0x65c3ad0
0065C3AC8  ldr      x0, [x19, #0x80]
0065C3ACC  b        #0x65c3adc ; 
0065C3AD0  ldr      x8, [x1, #0x60]
0065C3AD4  mov      x0, x19
0065C3AD8  blr      x8
0065C3ADC  cbz      x0, #0x65c3de0
0065C3AE0  adrp     x26, #0x9599000
0065C3AE4  ldrb     w8, [x26, #0x646]
0065C3AE8  ldr      x21, [x0, #0x458]
0065C3AEC  cbnz     w8, #0x65c3b04
0065C3AF0  adrp     x0, #0x8f0a000
0065C3AF4  ldr      x0, [x0, #0x4e8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_WaveDeathInfo() @ 0x923c628
0065C3AF8  bl       #0x382bd14 ; 
0065C3AFC  mov      w8, #1
0065C3B00  strb     w8, [x26, #0x646]
0065C3B04  adrp     x8, #0x8f0a000
0065C3B08  ldr      x8, [x8, #0x4e8] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_WaveDeathInfo() @ 0x923c628
0065C3B0C  ldr      x2, [x8]
0065C3B10  ldrb     w8, [x2, #0x53]
0065C3B14  tbnz     w8, #5, #0x65c3b2c
0065C3B18  mov      x0, x20
0065C3B1C  str      x21, [x0, #0x98]!
0065C3B20  mov      x1, x21
0065C3B24  bl       #0x382bcb8 ; 
0065C3B28  b        #0x65c3b3c ; 
0065C3B2C  ldr      x8, [x2, #0x60]
0065C3B30  mov      x0, x20
0065C3B34  mov      x1, x21
0065C3B38  blr      x8
0065C3B3C  ldrb     w8, [x23, #0x286]
0065C3B40  cbnz     w8, #0x65c3b58
0065C3B44  adrp     x0, #0x8f07000
0065C3B48  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3B4C  bl       #0x382bd14 ; 
0065C3B50  mov      w8, #1
0065C3B54  strb     w8, [x23, #0x286]
0065C3B58  ldr      x1, [x24]
0065C3B5C  ldrb     w8, [x1, #0x53]
0065C3B60  tbnz     w8, #5, #0x65c3b6c
0065C3B64  ldr      x0, [x19, #0x80]
0065C3B68  b        #0x65c3b78 ; 
0065C3B6C  ldr      x8, [x1, #0x60]
0065C3B70  mov      x0, x19
0065C3B74  blr      x8
0065C3B78  cbz      x0, #0x65c3de0
0065C3B7C  adrp     x26, #0x9599000
0065C3B80  ldrb     w8, [x26, #0x647]
0065C3B84  ldr      w21, [x0, #0x444]
0065C3B88  cbnz     w8, #0x65c3ba0
0065C3B8C  adrp     x0, #0x8f0a000
0065C3B90  ldr      x0, [x0, #0x4f0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveReliveCount() @ 0x923c620
0065C3B94  bl       #0x382bd14 ; 
0065C3B98  mov      w8, #1
0065C3B9C  strb     w8, [x26, #0x647]
0065C3BA0  adrp     x8, #0x8f0a000
0065C3BA4  ldr      x8, [x8, #0x4f0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveReliveCount() @ 0x923c620
0065C3BA8  ldr      x2, [x8]
0065C3BAC  ldrb     w8, [x2, #0x53]
0065C3BB0  tbnz     w8, #5, #0x65c3bbc
0065C3BB4  str      w21, [x20, #0x84]
0065C3BB8  b        #0x65c3bcc ; 
0065C3BBC  ldr      x8, [x2, #0x60]
0065C3BC0  mov      x0, x20
0065C3BC4  mov      w1, w21
0065C3BC8  blr      x8
0065C3BCC  ldrb     w8, [x23, #0x286]
0065C3BD0  cbnz     w8, #0x65c3be8
0065C3BD4  adrp     x0, #0x8f07000
0065C3BD8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3BDC  bl       #0x382bd14 ; 
0065C3BE0  mov      w8, #1
0065C3BE4  strb     w8, [x23, #0x286]
0065C3BE8  ldr      x1, [x24]
0065C3BEC  ldrb     w8, [x1, #0x53]
0065C3BF0  tbnz     w8, #5, #0x65c3bfc
0065C3BF4  ldr      x21, [x19, #0x80]
0065C3BF8  b        #0x65c3c0c ; 
0065C3BFC  ldr      x8, [x1, #0x60]
0065C3C00  mov      x0, x19
0065C3C04  blr      x8
0065C3C08  mov      x21, x0
0065C3C0C  cbz      x21, #0x65c3de0
0065C3C10  adrp     x26, #0x9599000
0065C3C14  ldrb     w8, [x26, #0x648]
0065C3C18  cbnz     w8, #0x65c3c30
0065C3C1C  adrp     x0, #0x8f0a000
0065C3C20  ldr      x0, [x0, #0x4f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BeHitCount() @ 0x923fe68
0065C3C24  bl       #0x382bd14 ; 
0065C3C28  mov      w8, #1
0065C3C2C  strb     w8, [x26, #0x648]
0065C3C30  adrp     x8, #0x8f0a000
0065C3C34  ldr      x8, [x8, #0x4f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BeHitCount() @ 0x923fe68
0065C3C38  ldr      x1, [x8]
0065C3C3C  ldrb     w8, [x1, #0x53]
0065C3C40  tbnz     w8, #5, #0x65c3c4c
0065C3C44  ldr      w21, [x21, #0x2d8]
0065C3C48  b        #0x65c3c5c ; 
0065C3C4C  ldr      x8, [x1, #0x60]
0065C3C50  mov      x0, x21
0065C3C54  blr      x8
0065C3C58  mov      w21, w0
0065C3C5C  adrp     x26, #0x9599000
0065C3C60  ldrb     w8, [x26, #0x649]
0065C3C64  cbnz     w8, #0x65c3c7c
0065C3C68  adrp     x0, #0x8f0a000
0065C3C6C  ldr      x0, [x0, #0x500] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveBeHitCount() @ 0x923c600
0065C3C70  bl       #0x382bd14 ; 
0065C3C74  mov      w8, #1
0065C3C78  strb     w8, [x26, #0x649]
0065C3C7C  adrp     x8, #0x8f0a000
0065C3C80  ldr      x8, [x8, #0x500] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveBeHitCount() @ 0x923c600
0065C3C84  ldr      x2, [x8]
0065C3C88  ldrb     w8, [x2, #0x53]
0065C3C8C  tbnz     w8, #5, #0x65c3c98
0065C3C90  str      w21, [x20, #0x80]
0065C3C94  b        #0x65c3ca8 ; 
0065C3C98  ldr      x8, [x2, #0x60]
0065C3C9C  mov      x0, x20
0065C3CA0  mov      w1, w21
0065C3CA4  blr      x8
0065C3CA8  ldrb     w8, [x23, #0x286]
0065C3CAC  cbnz     w8, #0x65c3cc4
0065C3CB0  adrp     x0, #0x8f07000
0065C3CB4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3CB8  bl       #0x382bd14 ; 
0065C3CBC  mov      w8, #1
0065C3CC0  strb     w8, [x23, #0x286]
0065C3CC4  ldr      x1, [x24]
0065C3CC8  ldrb     w8, [x1, #0x53]
0065C3CCC  tbnz     w8, #5, #0x65c3cd8
0065C3CD0  ldr      x21, [x19, #0x80]
0065C3CD4  b        #0x65c3ce8 ; 
0065C3CD8  ldr      x8, [x1, #0x60]
0065C3CDC  mov      x0, x19
0065C3CE0  blr      x8
0065C3CE4  mov      x21, x0
0065C3CE8  cbz      x21, #0x65c3de0
0065C3CEC  ldrb     w8, [x22, #0x273]
0065C3CF0  cbnz     w8, #0x65c3d08
0065C3CF4  adrp     x0, #0x8ee9000
0065C3CF8  ldr      x0, [x0, #0xf20] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleFrame() @ 0x923fe58
0065C3CFC  bl       #0x382bd14 ; 
0065C3D00  mov      w8, #1
0065C3D04  strb     w8, [x22, #0x273]
0065C3D08  ldr      x1, [x25]
0065C3D0C  ldrb     w8, [x1, #0x53]
0065C3D10  tbnz     w8, #5, #0x65c3d1c
0065C3D14  ldr      w21, [x21, #0x1f0]
0065C3D18  b        #0x65c3d2c ; 
0065C3D1C  ldr      x8, [x1, #0x60]
0065C3D20  mov      x0, x21
0065C3D24  blr      x8
0065C3D28  mov      w21, w0
0065C3D2C  ldrb     w8, [x23, #0x286]
0065C3D30  cbnz     w8, #0x65c3d48
0065C3D34  adrp     x0, #0x8f07000
0065C3D38  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C3D3C  bl       #0x382bd14 ; 
0065C3D40  mov      w8, #1
0065C3D44  strb     w8, [x23, #0x286]
0065C3D48  ldr      x1, [x24]
0065C3D4C  ldrb     w8, [x1, #0x53]
0065C3D50  tbnz     w8, #5, #0x65c3d5c
0065C3D54  ldr      x0, [x19, #0x80]
0065C3D58  b        #0x65c3d68 ; 
0065C3D5C  ldr      x8, [x1, #0x60]
0065C3D60  mov      x0, x19
0065C3D64  blr      x8
0065C3D68  cbz      x0, #0x65c3de0
0065C3D6C  adrp     x22, #0x9599000
0065C3D70  ldrb     w8, [x22, #0x294]
0065C3D74  ldr      w19, [x0, #0x448]
0065C3D78  cbnz     w8, #0x65c3d90
0065C3D7C  adrp     x0, #0x8f07000
0065C3D80  ldr      x0, [x0, #0xfa0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveFrames() @ 0x923c608
0065C3D84  bl       #0x382bd14 ; 
0065C3D88  mov      w8, #1
0065C3D8C  strb     w8, [x22, #0x294]
0065C3D90  adrp     x8, #0x8f07000
0065C3D94  ldr      x8, [x8, #0xfa0] ; GLOBAL Method$HotFix.BattleLogic.BattleEndEvent.set_RecordWaveFrames() @ 0x923c608
0065C3D98  sub      w1, w21, w19
0065C3D9C  ldr      x2, [x8]
0065C3DA0  ldrb     w8, [x2, #0x53]
0065C3DA4  tbnz     w8, #5, #0x65c3db0
0065C3DA8  str      w1, [x20, #0x88]
0065C3DAC  b        #0x65c3dbc ; 
0065C3DB0  ldr      x8, [x2, #0x60]
0065C3DB4  mov      x0, x20
0065C3DB8  blr      x8
0065C3DBC  mov      x0, x20
0065C3DC0  ldp      x20, x19, [sp, #0x1c0]
0065C3DC4  ldp      x22, x21, [sp, #0x1b0]
0065C3DC8  ldp      x24, x23, [sp, #0x1a0]
0065C3DCC  ldp      x26, x25, [sp, #0x190]
0065C3DD0  ldp      x28, x27, [sp, #0x180]
0065C3DD4  ldp      x29, x30, [sp, #0x170]
0065C3DD8  add      sp, sp, #0x1d0
0065C3DDC  ret      
0065C3DE0  bl       #0x382bfb8 ; 
