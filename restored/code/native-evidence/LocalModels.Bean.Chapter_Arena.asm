; LocalModels.Bean.Chapter_Arena$$readImpl
; RVA 0x68A1F4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068A1F4C  stp      x30, x21, [sp, #-0x20]!
0068A1F50  stp      x20, x19, [sp, #0x10]
0068A1F54  adrp     x20, #0x959b000
0068A1F58  adrp     x21, #0x8f26000
0068A1F5C  ldrb     w8, [x20, #0xf01]
0068A1F60  ldr      x21, [x21, #0x4d0]
0068A1F64  mov      x19, x0
0068A1F68  tbnz     w8, #0, #0x68a1f80
0068A1F6C  adrp     x0, #0x8f26000
0068A1F70  ldr      x0, [x0, #0x4d0]
0068A1F74  bl       #0x382bd14 ; 
0068A1F78  mov      w8, #1
0068A1F7C  strb     w8, [x20, #0xf01]
0068A1F80  ldr      x1, [x21]
0068A1F84  ldrb     w8, [x1, #0x53]
0068A1F88  tbnz     w8, #5, #0x68a1fd8
0068A1F8C  mov      x0, x19
0068A1F90  mov      x1, xzr
0068A1F94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A1F98  adrp     x21, #0x959c000
0068A1F9C  ldrb     w8, [x21, #0x518]
0068A1FA0  mov      w20, w0
0068A1FA4  cbnz     w8, #0x68a1fbc
0068A1FA8  adrp     x0, #0x8f26000
0068A1FAC  ldr      x0, [x0, #0x318]
0068A1FB0  bl       #0x382bd14 ; 
0068A1FB4  mov      w8, #1
0068A1FB8  strb     w8, [x21, #0x518]
0068A1FBC  adrp     x8, #0x8f26000
0068A1FC0  ldr      x8, [x8, #0x318]
0068A1FC4  ldr      x2, [x8]
0068A1FC8  ldrb     w8, [x2, #0x53]
0068A1FCC  tbnz     w8, #5, #0x68a1fec
0068A1FD0  str      w20, [x19, #0x20]
0068A1FD4  b        #0x68a1ffc ; 
0068A1FD8  ldr      x2, [x1, #0x60]
0068A1FDC  mov      x0, x19
0068A1FE0  ldp      x20, x19, [sp, #0x10]
0068A1FE4  ldp      x30, x21, [sp], #0x20
0068A1FE8  br       x2
0068A1FEC  ldr      x8, [x2, #0x60]
0068A1FF0  mov      x0, x19
0068A1FF4  mov      w1, w20
0068A1FF8  blr      x8
0068A1FFC  mov      x0, x19
0068A2000  mov      x1, xzr
0068A2004  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A2008  adrp     x21, #0x959c000
0068A200C  ldrb     w8, [x21, #0x519]
0068A2010  mov      x20, x0
0068A2014  cbnz     w8, #0x68a202c
0068A2018  adrp     x0, #0x8f26000
0068A201C  ldr      x0, [x0, #0x328]
0068A2020  bl       #0x382bd14 ; 
0068A2024  mov      w8, #1
0068A2028  strb     w8, [x21, #0x519]
0068A202C  adrp     x8, #0x8f26000
0068A2030  ldr      x8, [x8, #0x328]
0068A2034  ldr      x2, [x8]
0068A2038  ldrb     w8, [x2, #0x53]
0068A203C  tbnz     w8, #5, #0x68a2054
0068A2040  mov      x0, x19
0068A2044  str      x20, [x0, #0x28]!
0068A2048  mov      x1, x20
0068A204C  bl       #0x382bcb8 ; 
0068A2050  b        #0x68a2064 ; 
0068A2054  ldr      x8, [x2, #0x60]
0068A2058  mov      x0, x19
0068A205C  mov      x1, x20
0068A2060  blr      x8
0068A2064  mov      x0, x19
0068A2068  mov      x1, xzr
0068A206C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A2070  adrp     x21, #0x959c000
0068A2074  ldrb     w8, [x21, #0x51a]
0068A2078  mov      w20, w0
0068A207C  cbnz     w8, #0x68a2094
0068A2080  adrp     x0, #0x8f26000
0068A2084  ldr      x0, [x0, #0x338]
0068A2088  bl       #0x382bd14 ; 
0068A208C  mov      w8, #1
0068A2090  strb     w8, [x21, #0x51a]
0068A2094  adrp     x8, #0x8f26000
0068A2098  ldr      x8, [x8, #0x338]
0068A209C  ldr      x2, [x8]
0068A20A0  ldrb     w8, [x2, #0x53]
0068A20A4  tbnz     w8, #5, #0x68a20b0
0068A20A8  str      w20, [x19, #0x30]
0068A20AC  b        #0x68a20c0 ; 
0068A20B0  ldr      x8, [x2, #0x60]
0068A20B4  mov      x0, x19
0068A20B8  mov      w1, w20
0068A20BC  blr      x8
0068A20C0  mov      x0, x19
0068A20C4  mov      x1, xzr
0068A20C8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A20CC  adrp     x21, #0x959c000
0068A20D0  ldrb     w8, [x21, #0x51b]
0068A20D4  mov      x20, x0
0068A20D8  cbnz     w8, #0x68a20f0
0068A20DC  adrp     x0, #0x8f26000
0068A20E0  ldr      x0, [x0, #0x348]
0068A20E4  bl       #0x382bd14 ; 
0068A20E8  mov      w8, #1
0068A20EC  strb     w8, [x21, #0x51b]
0068A20F0  adrp     x8, #0x8f26000
0068A20F4  ldr      x8, [x8, #0x348]
0068A20F8  ldr      x2, [x8]
0068A20FC  ldrb     w8, [x2, #0x53]
0068A2100  tbnz     w8, #5, #0x68a2118
0068A2104  mov      x0, x19
0068A2108  str      x20, [x0, #0x38]!
0068A210C  mov      x1, x20
0068A2110  bl       #0x382bcb8 ; 
0068A2114  b        #0x68a2128 ; 
0068A2118  ldr      x8, [x2, #0x60]
0068A211C  mov      x0, x19
0068A2120  mov      x1, x20
0068A2124  blr      x8
0068A2128  mov      x0, x19
0068A212C  mov      x1, xzr
0068A2130  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A2134  adrp     x21, #0x959c000
0068A2138  ldrb     w8, [x21, #0x51c]
0068A213C  mov      w20, w0
0068A2140  cbnz     w8, #0x68a2158
0068A2144  adrp     x0, #0x8f26000
0068A2148  ldr      x0, [x0, #0x358]
0068A214C  bl       #0x382bd14 ; 
0068A2150  mov      w8, #1
0068A2154  strb     w8, [x21, #0x51c]
0068A2158  adrp     x8, #0x8f26000
0068A215C  ldr      x8, [x8, #0x358]
0068A2160  ldr      x2, [x8]
0068A2164  ldrb     w8, [x2, #0x53]
0068A2168  tbnz     w8, #5, #0x68a2174
0068A216C  str      w20, [x19, #0x40]
0068A2170  b        #0x68a2184 ; 
0068A2174  ldr      x8, [x2, #0x60]
0068A2178  mov      x0, x19
0068A217C  mov      w1, w20
0068A2180  blr      x8
0068A2184  mov      x0, x19
0068A2188  mov      x1, xzr
0068A218C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A2190  adrp     x21, #0x959c000
0068A2194  ldrb     w8, [x21, #0x51d]
0068A2198  mov      x20, x0
0068A219C  cbnz     w8, #0x68a21b4
0068A21A0  adrp     x0, #0x8f26000
0068A21A4  ldr      x0, [x0, #0x368]
0068A21A8  bl       #0x382bd14 ; 
0068A21AC  mov      w8, #1
0068A21B0  strb     w8, [x21, #0x51d]
0068A21B4  adrp     x8, #0x8f26000
0068A21B8  ldr      x8, [x8, #0x368]
0068A21BC  ldr      x2, [x8]
0068A21C0  ldrb     w8, [x2, #0x53]
0068A21C4  tbnz     w8, #5, #0x68a21d0
0068A21C8  str      x20, [x19, #0x48]
0068A21CC  b        #0x68a21e0 ; 
0068A21D0  ldr      x8, [x2, #0x60]
0068A21D4  mov      x0, x19
0068A21D8  mov      x1, x20
0068A21DC  blr      x8
0068A21E0  mov      x0, x19
0068A21E4  mov      x1, xzr
0068A21E8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A21EC  adrp     x21, #0x959c000
0068A21F0  ldrb     w8, [x21, #0x51e]
0068A21F4  mov      x20, x0
0068A21F8  cbnz     w8, #0x68a2210
0068A21FC  adrp     x0, #0x8f26000
0068A2200  ldr      x0, [x0, #0x378]
0068A2204  bl       #0x382bd14 ; 
0068A2208  mov      w8, #1
0068A220C  strb     w8, [x21, #0x51e]
0068A2210  adrp     x8, #0x8f26000
0068A2214  ldr      x8, [x8, #0x378]
0068A2218  ldr      x2, [x8]
0068A221C  ldrb     w8, [x2, #0x53]
0068A2220  tbnz     w8, #5, #0x68a222c
0068A2224  str      x20, [x19, #0x50]
0068A2228  b        #0x68a223c ; 
0068A222C  ldr      x8, [x2, #0x60]
0068A2230  mov      x0, x19
0068A2234  mov      x1, x20
0068A2238  blr      x8
0068A223C  mov      x0, x19
0068A2240  mov      x1, xzr
0068A2244  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A2248  adrp     x21, #0x959c000
0068A224C  ldrb     w8, [x21, #0x51f]
0068A2250  mov      x20, x0
0068A2254  cbnz     w8, #0x68a226c
0068A2258  adrp     x0, #0x8f26000
0068A225C  ldr      x0, [x0, #0x388]
0068A2260  bl       #0x382bd14 ; 
0068A2264  mov      w8, #1
0068A2268  strb     w8, [x21, #0x51f]
0068A226C  adrp     x8, #0x8f26000
0068A2270  ldr      x8, [x8, #0x388]
0068A2274  ldr      x2, [x8]
0068A2278  ldrb     w8, [x2, #0x53]
0068A227C  tbnz     w8, #5, #0x68a2288
0068A2280  str      x20, [x19, #0x58]
0068A2284  b        #0x68a2298 ; 
0068A2288  ldr      x8, [x2, #0x60]
0068A228C  mov      x0, x19
0068A2290  mov      x1, x20
0068A2294  blr      x8
0068A2298  mov      x0, x19
0068A229C  mov      x1, xzr
0068A22A0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A22A4  adrp     x21, #0x959c000
0068A22A8  ldrb     w8, [x21, #0x520]
0068A22AC  mov      x20, x0
0068A22B0  cbnz     w8, #0x68a22c8
0068A22B4  adrp     x0, #0x8f26000
0068A22B8  ldr      x0, [x0, #0x398]
0068A22BC  bl       #0x382bd14 ; 
0068A22C0  mov      w8, #1
0068A22C4  strb     w8, [x21, #0x520]
0068A22C8  adrp     x8, #0x8f26000
0068A22CC  ldr      x8, [x8, #0x398]
0068A22D0  ldr      x2, [x8]
0068A22D4  ldrb     w8, [x2, #0x53]
0068A22D8  tbnz     w8, #5, #0x68a22e4
0068A22DC  str      x20, [x19, #0x60]
0068A22E0  b        #0x68a22f4 ; 
0068A22E4  ldr      x8, [x2, #0x60]
0068A22E8  mov      x0, x19
0068A22EC  mov      x1, x20
0068A22F0  blr      x8
0068A22F4  mov      x0, x19
0068A22F8  mov      x1, xzr
0068A22FC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A2300  adrp     x21, #0x959c000
0068A2304  ldrb     w8, [x21, #0x521]
0068A2308  mov      x20, x0
0068A230C  cbnz     w8, #0x68a2324
0068A2310  adrp     x0, #0x8f26000
0068A2314  ldr      x0, [x0, #0x3a8]
0068A2318  bl       #0x382bd14 ; 
0068A231C  mov      w8, #1
0068A2320  strb     w8, [x21, #0x521]
0068A2324  adrp     x8, #0x8f26000
0068A2328  ldr      x8, [x8, #0x3a8]
0068A232C  ldr      x2, [x8]
0068A2330  ldrb     w8, [x2, #0x53]
0068A2334  tbnz     w8, #5, #0x68a2340
0068A2338  str      x20, [x19, #0x68]
0068A233C  b        #0x68a2350 ; 
0068A2340  ldr      x8, [x2, #0x60]
0068A2344  mov      x0, x19
0068A2348  mov      x1, x20
0068A234C  blr      x8
0068A2350  mov      x0, x19
0068A2354  mov      x1, xzr
0068A2358  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A235C  adrp     x21, #0x959c000
0068A2360  ldrb     w8, [x21, #0x522]
0068A2364  mov      x20, x0
0068A2368  cbnz     w8, #0x68a2380
0068A236C  adrp     x0, #0x8f26000
0068A2370  ldr      x0, [x0, #0x3b8]
0068A2374  bl       #0x382bd14 ; 
0068A2378  mov      w8, #1
0068A237C  strb     w8, [x21, #0x522]
0068A2380  adrp     x8, #0x8f26000
0068A2384  ldr      x8, [x8, #0x3b8]
0068A2388  ldr      x2, [x8]
0068A238C  ldrb     w8, [x2, #0x53]
0068A2390  tbnz     w8, #5, #0x68a23a8
0068A2394  mov      x0, x19
0068A2398  str      x20, [x0, #0x70]!
0068A239C  mov      x1, x20
0068A23A0  bl       #0x382bcb8 ; 
0068A23A4  b        #0x68a23b8 ; 
0068A23A8  ldr      x8, [x2, #0x60]
0068A23AC  mov      x0, x19
0068A23B0  mov      x1, x20
0068A23B4  blr      x8
0068A23B8  mov      x0, x19
0068A23BC  mov      x1, xzr
0068A23C0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A23C4  adrp     x21, #0x959c000
0068A23C8  ldrb     w8, [x21, #0x523]
0068A23CC  mov      x20, x0
0068A23D0  cbnz     w8, #0x68a23e8
0068A23D4  adrp     x0, #0x8f26000
0068A23D8  ldr      x0, [x0, #0x3c8]
0068A23DC  bl       #0x382bd14 ; 
0068A23E0  mov      w8, #1
0068A23E4  strb     w8, [x21, #0x523]
0068A23E8  adrp     x8, #0x8f26000
0068A23EC  ldr      x8, [x8, #0x3c8]
0068A23F0  ldr      x2, [x8]
0068A23F4  ldrb     w8, [x2, #0x53]
0068A23F8  tbnz     w8, #5, #0x68a2410
0068A23FC  mov      x0, x19
0068A2400  str      x20, [x0, #0x78]!
0068A2404  mov      x1, x20
0068A2408  bl       #0x382bcb8 ; 
0068A240C  b        #0x68a2420 ; 
0068A2410  ldr      x8, [x2, #0x60]
0068A2414  mov      x0, x19
0068A2418  mov      x1, x20
0068A241C  blr      x8
0068A2420  mov      x0, x19
0068A2424  mov      x1, xzr
0068A2428  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A242C  adrp     x21, #0x959c000
0068A2430  ldrb     w8, [x21, #0x524]
0068A2434  mov      x20, x0
0068A2438  cbnz     w8, #0x68a2450
0068A243C  adrp     x0, #0x8f26000
0068A2440  ldr      x0, [x0, #0x3d8]
0068A2444  bl       #0x382bd14 ; 
0068A2448  mov      w8, #1
0068A244C  strb     w8, [x21, #0x524]
0068A2450  adrp     x8, #0x8f26000
0068A2454  ldr      x8, [x8, #0x3d8]
0068A2458  ldr      x2, [x8]
0068A245C  ldrb     w8, [x2, #0x53]
0068A2460  tbnz     w8, #5, #0x68a2478
0068A2464  mov      x0, x19
0068A2468  str      x20, [x0, #0x80]!
0068A246C  mov      x1, x20
0068A2470  bl       #0x382bcb8 ; 
0068A2474  b        #0x68a2488 ; 
0068A2478  ldr      x8, [x2, #0x60]
0068A247C  mov      x0, x19
0068A2480  mov      x1, x20
0068A2484  blr      x8
0068A2488  mov      x0, x19
0068A248C  mov      x1, xzr
0068A2490  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A2494  adrp     x21, #0x959c000
0068A2498  ldrb     w8, [x21, #0x525]
0068A249C  mov      w20, w0
0068A24A0  cbnz     w8, #0x68a24b8
0068A24A4  adrp     x0, #0x8f26000
0068A24A8  ldr      x0, [x0, #0x3e8]
0068A24AC  bl       #0x382bd14 ; 
0068A24B0  mov      w8, #1
0068A24B4  strb     w8, [x21, #0x525]
0068A24B8  adrp     x8, #0x8f26000
0068A24BC  ldr      x8, [x8, #0x3e8]
0068A24C0  ldr      x2, [x8]
0068A24C4  ldrb     w8, [x2, #0x53]
0068A24C8  tbnz     w8, #5, #0x68a24d4
0068A24CC  str      w20, [x19, #0x88]
0068A24D0  b        #0x68a24e4 ; 
0068A24D4  ldr      x8, [x2, #0x60]
0068A24D8  mov      x0, x19
0068A24DC  mov      w1, w20
0068A24E0  blr      x8
0068A24E4  mov      x0, x19
0068A24E8  mov      x1, xzr
0068A24EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A24F0  adrp     x21, #0x959c000
0068A24F4  ldrb     w8, [x21, #0x526]
0068A24F8  mov      w20, w0
0068A24FC  cbnz     w8, #0x68a2514
0068A2500  adrp     x0, #0x8f26000
0068A2504  ldr      x0, [x0, #0x3f8]
0068A2508  bl       #0x382bd14 ; 
0068A250C  mov      w8, #1
0068A2510  strb     w8, [x21, #0x526]
0068A2514  adrp     x8, #0x8f26000
0068A2518  ldr      x8, [x8, #0x3f8]
0068A251C  ldr      x2, [x8]
0068A2520  ldrb     w8, [x2, #0x53]
0068A2524  tbnz     w8, #5, #0x68a2530
0068A2528  str      w20, [x19, #0x8c]
0068A252C  b        #0x68a2540 ; 
0068A2530  ldr      x8, [x2, #0x60]
0068A2534  mov      x0, x19
0068A2538  mov      w1, w20
0068A253C  blr      x8
0068A2540  mov      x0, x19
0068A2544  mov      x1, xzr
0068A2548  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A254C  adrp     x21, #0x959c000
0068A2550  ldrb     w8, [x21, #0x527]
0068A2554  mov      x20, x0
0068A2558  cbnz     w8, #0x68a2570
0068A255C  adrp     x0, #0x8f26000
0068A2560  ldr      x0, [x0, #0x408]
0068A2564  bl       #0x382bd14 ; 
0068A2568  mov      w8, #1
0068A256C  strb     w8, [x21, #0x527]
0068A2570  adrp     x8, #0x8f26000
0068A2574  ldr      x8, [x8, #0x408]
0068A2578  ldr      x2, [x8]
0068A257C  ldrb     w8, [x2, #0x53]
0068A2580  tbnz     w8, #5, #0x68a2598
0068A2584  mov      x0, x19
0068A2588  str      x20, [x0, #0x90]!
0068A258C  mov      x1, x20
0068A2590  bl       #0x382bcb8 ; 
0068A2594  b        #0x68a25a8 ; 
0068A2598  ldr      x8, [x2, #0x60]
0068A259C  mov      x0, x19
0068A25A0  mov      x1, x20
0068A25A4  blr      x8
0068A25A8  mov      x0, x19
0068A25AC  mov      x1, xzr
0068A25B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A25B4  adrp     x21, #0x959c000
0068A25B8  ldrb     w8, [x21, #0x528]
0068A25BC  mov      w20, w0
0068A25C0  cbnz     w8, #0x68a25d8
0068A25C4  adrp     x0, #0x8f26000
0068A25C8  ldr      x0, [x0, #0x418]
0068A25CC  bl       #0x382bd14 ; 
0068A25D0  mov      w8, #1
0068A25D4  strb     w8, [x21, #0x528]
0068A25D8  adrp     x8, #0x8f26000
0068A25DC  ldr      x8, [x8, #0x418]
0068A25E0  ldr      x2, [x8]
0068A25E4  ldrb     w8, [x2, #0x53]
0068A25E8  tbnz     w8, #5, #0x68a25f4
0068A25EC  str      w20, [x19, #0x98]
0068A25F0  b        #0x68a2604 ; 
0068A25F4  ldr      x8, [x2, #0x60]
0068A25F8  mov      x0, x19
0068A25FC  mov      w1, w20
0068A2600  blr      x8
0068A2604  mov      x0, x19
0068A2608  mov      x1, xzr
0068A260C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A2610  adrp     x21, #0x959c000
0068A2614  ldrb     w8, [x21, #0x529]
0068A2618  mov      w20, w0
0068A261C  cbnz     w8, #0x68a2634
0068A2620  adrp     x0, #0x8f26000
0068A2624  ldr      x0, [x0, #0x428]
0068A2628  bl       #0x382bd14 ; 
0068A262C  mov      w8, #1
0068A2630  strb     w8, [x21, #0x529]
0068A2634  adrp     x8, #0x8f26000
0068A2638  ldr      x8, [x8, #0x428]
0068A263C  ldr      x2, [x8]
0068A2640  ldrb     w8, [x2, #0x53]
0068A2644  tbnz     w8, #5, #0x68a2650
0068A2648  str      w20, [x19, #0x9c]
0068A264C  b        #0x68a2660 ; 
0068A2650  ldr      x8, [x2, #0x60]
0068A2654  mov      x0, x19
0068A2658  mov      w1, w20
0068A265C  blr      x8
0068A2660  mov      x0, x19
0068A2664  mov      x1, xzr
0068A2668  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A266C  adrp     x21, #0x959c000
0068A2670  ldrb     w8, [x21, #0x52a]
0068A2674  mov      w20, w0
0068A2678  cbnz     w8, #0x68a2690
0068A267C  adrp     x0, #0x8f26000
0068A2680  ldr      x0, [x0, #0x438]
0068A2684  bl       #0x382bd14 ; 
0068A2688  mov      w8, #1
0068A268C  strb     w8, [x21, #0x52a]
0068A2690  adrp     x8, #0x8f26000
0068A2694  ldr      x8, [x8, #0x438]
0068A2698  ldr      x2, [x8]
0068A269C  ldrb     w8, [x2, #0x53]
0068A26A0  tbnz     w8, #5, #0x68a26ac
0068A26A4  str      w20, [x19, #0xa0]
0068A26A8  b        #0x68a26bc ; 
0068A26AC  ldr      x8, [x2, #0x60]
0068A26B0  mov      x0, x19
0068A26B4  mov      w1, w20
0068A26B8  blr      x8
0068A26BC  mov      x0, x19
0068A26C0  mov      x1, xzr
0068A26C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A26C8  adrp     x21, #0x959c000
0068A26CC  ldrb     w8, [x21, #0x52b]
0068A26D0  mov      w20, w0
0068A26D4  cbnz     w8, #0x68a26ec
0068A26D8  adrp     x0, #0x8f26000
0068A26DC  ldr      x0, [x0, #0x448]
0068A26E0  bl       #0x382bd14 ; 
0068A26E4  mov      w8, #1
0068A26E8  strb     w8, [x21, #0x52b]
0068A26EC  adrp     x8, #0x8f26000
0068A26F0  ldr      x8, [x8, #0x448]
0068A26F4  ldr      x2, [x8]
0068A26F8  ldrb     w8, [x2, #0x53]
0068A26FC  tbnz     w8, #5, #0x68a2708
0068A2700  str      w20, [x19, #0xa4]
0068A2704  b        #0x68a2718 ; 
0068A2708  ldr      x8, [x2, #0x60]
0068A270C  mov      x0, x19
0068A2710  mov      w1, w20
0068A2714  blr      x8
0068A2718  mov      x0, x19
0068A271C  mov      x1, xzr
0068A2720  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A2724  adrp     x21, #0x959c000
0068A2728  ldrb     w8, [x21, #0x52c]
0068A272C  mov      w20, w0
0068A2730  cbnz     w8, #0x68a2748
0068A2734  adrp     x0, #0x8f26000
0068A2738  ldr      x0, [x0, #0x458]
0068A273C  bl       #0x382bd14 ; 
0068A2740  mov      w8, #1
0068A2744  strb     w8, [x21, #0x52c]
0068A2748  adrp     x8, #0x8f26000
0068A274C  ldr      x8, [x8, #0x458]
0068A2750  ldr      x2, [x8]
0068A2754  ldrb     w8, [x2, #0x53]
0068A2758  tbnz     w8, #5, #0x68a2764
0068A275C  str      w20, [x19, #0xa8]
0068A2760  b        #0x68a2774 ; 
0068A2764  ldr      x8, [x2, #0x60]
0068A2768  mov      x0, x19
0068A276C  mov      w1, w20
0068A2770  blr      x8
0068A2774  mov      x0, x19
0068A2778  mov      x1, xzr
0068A277C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A2780  adrp     x21, #0x959c000
0068A2784  ldrb     w8, [x21, #0x52d]
0068A2788  mov      w20, w0
0068A278C  cbnz     w8, #0x68a27a4
0068A2790  adrp     x0, #0x8f26000
0068A2794  ldr      x0, [x0, #0x468]
0068A2798  bl       #0x382bd14 ; 
0068A279C  mov      w8, #1
0068A27A0  strb     w8, [x21, #0x52d]
0068A27A4  adrp     x8, #0x8f26000
0068A27A8  ldr      x8, [x8, #0x468]
0068A27AC  ldr      x2, [x8]
0068A27B0  ldrb     w8, [x2, #0x53]
0068A27B4  tbnz     w8, #5, #0x68a27c0
0068A27B8  str      w20, [x19, #0xac]
0068A27BC  b        #0x68a27d0 ; 
0068A27C0  ldr      x8, [x2, #0x60]
0068A27C4  mov      x0, x19
0068A27C8  mov      w1, w20
0068A27CC  blr      x8
0068A27D0  mov      x0, x19
0068A27D4  mov      x1, xzr
0068A27D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A27DC  adrp     x21, #0x959c000
0068A27E0  ldrb     w8, [x21, #0x52e]
0068A27E4  mov      w20, w0
0068A27E8  cbnz     w8, #0x68a2800
0068A27EC  adrp     x0, #0x8f26000
0068A27F0  ldr      x0, [x0, #0x478]
0068A27F4  bl       #0x382bd14 ; 
0068A27F8  mov      w8, #1
0068A27FC  strb     w8, [x21, #0x52e]
0068A2800  adrp     x8, #0x8f26000
0068A2804  ldr      x8, [x8, #0x478]
0068A2808  ldr      x2, [x8]
0068A280C  ldrb     w8, [x2, #0x53]
0068A2810  tbnz     w8, #5, #0x68a281c
0068A2814  str      w20, [x19, #0xb0]
0068A2818  b        #0x68a282c ; 
0068A281C  ldr      x8, [x2, #0x60]
0068A2820  mov      x0, x19
0068A2824  mov      w1, w20
0068A2828  blr      x8
0068A282C  mov      x0, x19
0068A2830  mov      x1, xzr
0068A2834  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A2838  adrp     x21, #0x959c000
0068A283C  ldrb     w8, [x21, #0x52f]
0068A2840  mov      w20, w0
0068A2844  cbnz     w8, #0x68a285c
0068A2848  adrp     x0, #0x8f26000
0068A284C  ldr      x0, [x0, #0x488]
0068A2850  bl       #0x382bd14 ; 
0068A2854  mov      w8, #1
0068A2858  strb     w8, [x21, #0x52f]
0068A285C  adrp     x8, #0x8f26000
0068A2860  ldr      x8, [x8, #0x488]
0068A2864  ldr      x2, [x8]
0068A2868  ldrb     w8, [x2, #0x53]
0068A286C  tbnz     w8, #5, #0x68a2878
0068A2870  str      w20, [x19, #0xb4]
0068A2874  b        #0x68a2888 ; 
0068A2878  ldr      x8, [x2, #0x60]
0068A287C  mov      x0, x19
0068A2880  mov      w1, w20
0068A2884  blr      x8
0068A2888  mov      x0, x19
0068A288C  mov      x1, xzr
0068A2890  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068A2894  adrp     x21, #0x959c000
0068A2898  ldrb     w8, [x21, #0x530]
0068A289C  mov      x20, x0
0068A28A0  cbnz     w8, #0x68a28b8
0068A28A4  adrp     x0, #0x8f26000
0068A28A8  ldr      x0, [x0, #0x498]
0068A28AC  bl       #0x382bd14 ; 
0068A28B0  mov      w8, #1
0068A28B4  strb     w8, [x21, #0x530]
0068A28B8  adrp     x8, #0x8f26000
0068A28BC  ldr      x8, [x8, #0x498]
0068A28C0  ldr      x2, [x8]
0068A28C4  ldrb     w8, [x2, #0x53]
0068A28C8  tbnz     w8, #5, #0x68a28e0
0068A28CC  mov      x0, x19
0068A28D0  str      x20, [x0, #0xb8]!
0068A28D4  mov      x1, x20
0068A28D8  bl       #0x382bcb8 ; 
0068A28DC  b        #0x68a28f0 ; 
0068A28E0  ldr      x8, [x2, #0x60]
0068A28E4  mov      x0, x19
0068A28E8  mov      x1, x20
0068A28EC  blr      x8
0068A28F0  mov      x0, x19
0068A28F4  mov      x1, xzr
0068A28F8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A28FC  adrp     x21, #0x959c000
0068A2900  ldrb     w8, [x21, #0x531]
0068A2904  mov      x20, x0
0068A2908  cbnz     w8, #0x68a2920
0068A290C  adrp     x0, #0x8f26000
0068A2910  ldr      x0, [x0, #0x4a8]
0068A2914  bl       #0x382bd14 ; 
0068A2918  mov      w8, #1
0068A291C  strb     w8, [x21, #0x531]
0068A2920  adrp     x8, #0x8f26000
0068A2924  ldr      x8, [x8, #0x4a8]
0068A2928  ldr      x2, [x8]
0068A292C  ldrb     w8, [x2, #0x53]
0068A2930  tbnz     w8, #5, #0x68a2948
0068A2934  mov      x0, x19
0068A2938  str      x20, [x0, #0xc0]!
0068A293C  mov      x1, x20
0068A2940  bl       #0x382bcb8 ; 
0068A2944  b        #0x68a2958 ; 
0068A2948  ldr      x8, [x2, #0x60]
0068A294C  mov      x0, x19
0068A2950  mov      x1, x20
0068A2954  blr      x8
0068A2958  mov      x0, x19
0068A295C  mov      x1, xzr
0068A2960  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
0068A2964  adrp     x21, #0x959c000
0068A2968  ldrb     w8, [x21, #0x532]
0068A296C  mov      x20, x0
0068A2970  cbnz     w8, #0x68a2988
0068A2974  adrp     x0, #0x8f26000
0068A2978  ldr      x0, [x0, #0x4b8]
0068A297C  bl       #0x382bd14 ; 
0068A2980  mov      w8, #1
0068A2984  strb     w8, [x21, #0x532]
0068A2988  adrp     x8, #0x8f26000
0068A298C  ldr      x8, [x8, #0x4b8]
0068A2990  ldr      x2, [x8]
0068A2994  ldrb     w8, [x2, #0x53]
0068A2998  tbnz     w8, #5, #0x68a29b0
0068A299C  mov      x0, x19
0068A29A0  str      x20, [x0, #0xc8]!
0068A29A4  mov      x1, x20
0068A29A8  bl       #0x382bcb8 ; 
0068A29AC  b        #0x68a29c0 ; 
0068A29B0  ldr      x8, [x2, #0x60]
0068A29B4  mov      x0, x19
0068A29B8  mov      x1, x20
0068A29BC  blr      x8
0068A29C0  mov      x0, x19
0068A29C4  mov      x1, xzr
0068A29C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A29CC  adrp     x21, #0x959c000
0068A29D0  ldrb     w8, [x21, #0x533]
0068A29D4  mov      w20, w0
0068A29D8  cbnz     w8, #0x68a29f0
0068A29DC  adrp     x0, #0x8f26000
0068A29E0  ldr      x0, [x0, #0x4c8]
0068A29E4  bl       #0x382bd14 ; 
0068A29E8  mov      w8, #1
0068A29EC  strb     w8, [x21, #0x533]
0068A29F0  adrp     x8, #0x8f26000
0068A29F4  ldr      x8, [x8, #0x4c8]
0068A29F8  ldr      x2, [x8]
0068A29FC  ldrb     w8, [x2, #0x53]
0068A2A00  tbnz     w8, #5, #0x68a2a0c
0068A2A04  str      w20, [x19, #0xd0]
0068A2A08  b        #0x68a2a1c ; 
0068A2A0C  ldr      x8, [x2, #0x60]
0068A2A10  mov      x0, x19
0068A2A14  mov      w1, w20
0068A2A18  blr      x8
0068A2A1C  ldp      x20, x19, [sp, #0x10]
0068A2A20  mov      w0, #1
0068A2A24  ldp      x30, x21, [sp], #0x20
0068A2A28  ret      

