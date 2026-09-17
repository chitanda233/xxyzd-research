; System.Collections.Generic.EqualityComparer<WeightRandomData>$$get_Default
; RVA 0x62B1EE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0062B1EE4  str      x30, [sp, #-0x20]!
0062B1EE8  stp      x20, x19, [sp, #0x10]
0062B1EEC  mov      x19, x0
0062B1EF0  ldr      x0, [x0, #0x20]
0062B1EF4  ldrb     w8, [x0, #0x135]
0062B1EF8  tbnz     w8, #0, #0x62b1f00
0062B1EFC  bl       #0x3a7e60c ; 
0062B1F00  ldr      x8, [x0, #0xc0]
0062B1F04  ldr      x0, [x8, #0x10]
0062B1F08  ldrb     w8, [x0, #0x135]
0062B1F0C  tbnz     w8, #0, #0x62b1f14
0062B1F10  bl       #0x3a7e60c ; 
0062B1F14  ldr      x8, [x0, #0xb8]
0062B1F18  ldr      x20, [x8]
0062B1F1C  bl       #0x382bdb0 ; 
0062B1F20  cbnz     x20, #0x62b1fa4
0062B1F24  ldr      x0, [x19, #0x20]
0062B1F28  ldrb     w8, [x0, #0x135]
0062B1F2C  tbnz     w8, #0, #0x62b1f34
0062B1F30  bl       #0x3a7e60c ; 
0062B1F34  ldr      x8, [x0, #0xc0]
0062B1F38  ldr      x0, [x8, #0x18]
0062B1F3C  bl       #0x62b1fb4 ; System.Collections.Generic.EqualityComparer<WeightRandomData>$$CreateComparer
0062B1F40  mov      x20, x0
0062B1F44  bl       #0x382bdb0 ; 
0062B1F48  ldr      x0, [x19, #0x20]
0062B1F4C  ldrb     w8, [x0, #0x135]
0062B1F50  tbnz     w8, #0, #0x62b1f58
0062B1F54  bl       #0x3a7e60c ; 
0062B1F58  ldr      x8, [x0, #0xc0]
0062B1F5C  ldr      x0, [x8, #0x10]
0062B1F60  ldrb     w8, [x0, #0x135]
0062B1F64  tbnz     w8, #0, #0x62b1f6c
0062B1F68  bl       #0x3a7e60c ; 
0062B1F6C  ldr      x8, [x0, #0xb8]
0062B1F70  str      x20, [x8]
0062B1F74  ldr      x0, [x19, #0x20]
0062B1F78  ldrb     w8, [x0, #0x135]
0062B1F7C  tbnz     w8, #0, #0x62b1f84
0062B1F80  bl       #0x3a7e60c ; 
0062B1F84  ldr      x8, [x0, #0xc0]
0062B1F88  ldr      x0, [x8, #0x10]
0062B1F8C  ldrb     w8, [x0, #0x135]
0062B1F90  tbnz     w8, #0, #0x62b1f98
0062B1F94  bl       #0x3a7e60c ; 
0062B1F98  ldr      x0, [x0, #0xb8]
0062B1F9C  mov      x1, x20
0062B1FA0  bl       #0x382bcb8 ; 
0062B1FA4  mov      x0, x20
0062B1FA8  ldp      x20, x19, [sp, #0x10]
0062B1FAC  ldr      x30, [sp], #0x20
0062B1FB0  ret      

; System.Collections.Generic.EqualityComparer<WeightRandomData>$$CreateComparer
; RVA 0x62B1FB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0062B1FB4  stp      x30, x25, [sp, #-0x40]!
0062B1FB8  stp      x24, x23, [sp, #0x10]
0062B1FBC  stp      x22, x21, [sp, #0x20]
0062B1FC0  stp      x20, x19, [sp, #0x30]
0062B1FC4  adrp     x20, #0x9596000
0062B1FC8  ldrb     w8, [x20, #0xc0f]
0062B1FCC  mov      x19, x0
0062B1FD0  tbnz     w8, #0, #0x62b209c
0062B1FD4  adrp     x0, #0x8eeb000
0062B1FD8  ldr      x0, [x0, #0xe68]
0062B1FDC  bl       #0x382bd14 ; 
0062B1FE0  adrp     x0, #0x8ed4000
0062B1FE4  ldr      x0, [x0, #0x500]
0062B1FE8  bl       #0x382bd14 ; 
0062B1FEC  adrp     x0, #0x8eeb000
0062B1FF0  ldr      x0, [x0, #0xe70]
0062B1FF4  bl       #0x382bd14 ; 
0062B1FF8  adrp     x0, #0x8ebf000
0062B1FFC  ldr      x0, [x0, #0xf08]
0062B2000  bl       #0x382bd14 ; 
0062B2004  adrp     x0, #0x8eeb000
0062B2008  ldr      x0, [x0, #0xe78]
0062B200C  bl       #0x382bd14 ; 
0062B2010  adrp     x0, #0x8eeb000
0062B2014  ldr      x0, [x0, #0xe80]
0062B2018  bl       #0x382bd14 ; 
0062B201C  adrp     x0, #0x8eeb000
0062B2020  ldr      x0, [x0, #0xe88]
0062B2024  bl       #0x382bd14 ; 
0062B2028  adrp     x0, #0x8eeb000
0062B202C  ldr      x0, [x0, #0xe90]
0062B2030  bl       #0x382bd14 ; 
0062B2034  adrp     x0, #0x8eeb000
0062B2038  ldr      x0, [x0, #0xe98]
0062B203C  bl       #0x382bd14 ; 
0062B2040  adrp     x0, #0x8ee8000
0062B2044  ldr      x0, [x0, #0xe28]
0062B2048  bl       #0x382bd14 ; 
0062B204C  adrp     x0, #0x8ee5000
0062B2050  ldr      x0, [x0, #0xd70]
0062B2054  bl       #0x382bd14 ; 
0062B2058  adrp     x0, #0x8eeb000
0062B205C  ldr      x0, [x0, #0xea0]
0062B2060  bl       #0x382bd14 ; 
0062B2064  adrp     x0, #0x8eeb000
0062B2068  ldr      x0, [x0, #0xea8]
0062B206C  bl       #0x382bd14 ; 
0062B2070  adrp     x0, #0x8ec4000
0062B2074  ldr      x0, [x0, #0x308]
0062B2078  bl       #0x382bd14 ; 
0062B207C  adrp     x0, #0x8ebf000
0062B2080  ldr      x0, [x0, #0xd08]
0062B2084  bl       #0x382bd14 ; 
0062B2088  adrp     x0, #0x8ebf000
0062B208C  ldr      x0, [x0, #0x3a8]
0062B2090  bl       #0x382bd14 ; 
0062B2094  mov      w8, #1
0062B2098  strb     w8, [x20, #0xc0f]
0062B209C  ldr      x0, [x19, #0x20]
0062B20A0  adrp     x25, #0x8ebf000
0062B20A4  ldrb     w8, [x0, #0x135]
0062B20A8  ldr      x25, [x25, #0x3a8]
0062B20AC  tbnz     w8, #0, #0x62b20b4
0062B20B0  bl       #0x3a7e60c ; 
0062B20B4  ldr      x8, [x25]
0062B20B8  ldr      x9, [x0, #0xc0]
0062B20BC  ldr      w10, [x8, #0xe0]
0062B20C0  ldr      x20, [x9, #0x20]
0062B20C4  cbnz     w10, #0x62b20d0
0062B20C8  mov      x0, x8
0062B20CC  bl       #0x382be8c ; 
0062B20D0  adrp     x24, #0x8ee5000
0062B20D4  ldr      x24, [x24, #0xd70]
0062B20D8  mov      x0, x20
0062B20DC  mov      x1, xzr
0062B20E0  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B20E4  mov      x20, x0
0062B20E8  cbz      x0, #0x62b2118
0062B20EC  ldr      x8, [x20]
0062B20F0  ldr      x1, [x24]
0062B20F4  ldrb     w10, [x8, #0x130]
0062B20F8  ldrb     w9, [x1, #0x130]
0062B20FC  cmp      w10, w9
0062B2100  b.lo     #0x62b25d4
0062B2104  ldr      x8, [x8, #0xc8]
0062B2108  add      x8, x8, x9, lsl #3
0062B210C  ldur     x8, [x8, #-8]
0062B2110  cmp      x8, x1
0062B2114  b.ne     #0x62b25d4
0062B2118  adrp     x8, #0x8ed4000
0062B211C  ldr      x8, [x8, #0x500]
0062B2120  mov      x1, xzr
0062B2124  ldr      x0, [x8]
0062B2128  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B212C  mov      x1, x0
0062B2130  mov      x0, x20
0062B2134  mov      x2, xzr
0062B2138  bl       #0x7bf2990 ; System.Type$$op_Equality
0062B213C  tbz      w0, #0, #0x62b2160
0062B2140  adrp     x8, #0x8eeb000
0062B2144  ldr      x8, [x8, #0xe68]
0062B2148  ldr      x0, [x8]
0062B214C  bl       #0x382bfa0 ; 
0062B2150  mov      x1, xzr
0062B2154  mov      x20, x0
0062B2158  bl       #0x7bad2e4 ; System.Collections.Generic.ByteEqualityComparer$$.ctor
0062B215C  b        #0x62b21b8 ; 
0062B2160  adrp     x8, #0x8ec4000
0062B2164  ldr      x0, [x25]
0062B2168  ldr      x8, [x8, #0x308]
0062B216C  ldr      w9, [x0, #0xe0]
0062B2170  ldr      x21, [x8]
0062B2174  cbnz     w9, #0x62b217c
0062B2178  bl       #0x382be8c ; 
0062B217C  mov      x0, x21
0062B2180  mov      x1, xzr
0062B2184  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B2188  mov      x1, x0
0062B218C  mov      x0, x20
0062B2190  mov      x2, xzr
0062B2194  bl       #0x7bf2990 ; System.Type$$op_Equality
0062B2198  tbz      w0, #0, #0x62b21d0
0062B219C  adrp     x8, #0x8eeb000
0062B21A0  ldr      x8, [x8, #0xe88]
0062B21A4  ldr      x0, [x8]
0062B21A8  bl       #0x382bfa0 ; 
0062B21AC  mov      x1, xzr
0062B21B0  mov      x20, x0
0062B21B4  bl       #0x7bad3e4 ; System.Collections.Generic.InternalStringComparer$$.ctor
0062B21B8  ldr      x0, [x19, #0x20]
0062B21BC  ldrb     w8, [x0, #0x135]
0062B21C0  tbnz     w8, #0, #0x62b21c8
0062B21C4  bl       #0x3a7e60c ; 
0062B21C8  ldr      x8, [x0, #0xc0]
0062B21CC  b        #0x62b2294 ; 
0062B21D0  ldr      x0, [x19, #0x20]
0062B21D4  ldrb     w8, [x0, #0x135]
0062B21D8  tbnz     w8, #0, #0x62b21e0
0062B21DC  bl       #0x3a7e60c ; 
0062B21E0  ldr      x8, [x25]
0062B21E4  ldr      x9, [x0, #0xc0]
0062B21E8  ldr      w10, [x8, #0xe0]
0062B21EC  ldr      x21, [x9, #0x28]
0062B21F0  cbnz     w10, #0x62b21fc
0062B21F4  mov      x0, x8
0062B21F8  bl       #0x382be8c ; 
0062B21FC  mov      x0, x21
0062B2200  mov      x1, xzr
0062B2204  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B2208  cbz      x0, #0x62b25dc
0062B220C  ldr      x8, [x0]
0062B2210  mov      x1, x20
0062B2214  ldr      x9, [x8, #0x388]
0062B2218  ldr      x2, [x8, #0x390]
0062B221C  blr      x9
0062B2220  tbz      w0, #0, #0x62b22f0
0062B2224  adrp     x8, #0x8eeb000
0062B2228  ldr      x0, [x25]
0062B222C  ldr      x8, [x8, #0xe78]
0062B2230  ldr      w9, [x0, #0xe0]
0062B2234  ldr      x21, [x8]
0062B2238  cbnz     w9, #0x62b2240
0062B223C  bl       #0x382be8c ; 
0062B2240  mov      x0, x21
0062B2244  mov      x1, xzr
0062B2248  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B224C  ldr      x8, [x24]
0062B2250  mov      x21, x0
0062B2254  ldr      w9, [x8, #0xe0]
0062B2258  cbnz     w9, #0x62b2264
0062B225C  mov      x0, x8
0062B2260  bl       #0x382be8c ; 
0062B2264  mov      x0, x21
0062B2268  mov      x1, x20
0062B226C  mov      x2, xzr
0062B2270  bl       #0x7c21f30 ; System.RuntimeType$$CreateInstanceForAnotherGenericParameter
0062B2274  ldr      x8, [x19, #0x20]
0062B2278  mov      x20, x0
0062B227C  ldrb     w9, [x8, #0x135]
0062B2280  tbnz     w9, #0, #0x62b2290
0062B2284  mov      x0, x8
0062B2288  bl       #0x3a7e60c ; 
0062B228C  mov      x8, x0
0062B2290  ldr      x8, [x8, #0xc0]
0062B2294  ldr      x1, [x8]
0062B2298  ldrb     w8, [x1, #0x135]
0062B229C  tbnz     w8, #0, #0x62b22ac
0062B22A0  mov      x0, x1
0062B22A4  bl       #0x3a7e60c ; 
0062B22A8  mov      x1, x0
0062B22AC  cbz      x20, #0x62b22d8
0062B22B0  ldr      x8, [x20]
0062B22B4  ldrb     w9, [x1, #0x130]
0062B22B8  ldrb     w10, [x8, #0x130]
0062B22BC  cmp      w10, w9
0062B22C0  b.lo     #0x62b25d4
0062B22C4  ldr      x8, [x8, #0xc8]
0062B22C8  add      x8, x8, x9, lsl #3
0062B22CC  ldur     x8, [x8, #-8]
0062B22D0  cmp      x8, x1
0062B22D4  b.ne     #0x62b25d4
0062B22D8  mov      x0, x20
0062B22DC  ldp      x20, x19, [sp, #0x30]
0062B22E0  ldp      x22, x21, [sp, #0x20]
0062B22E4  ldp      x24, x23, [sp, #0x10]
0062B22E8  ldp      x30, x25, [sp], #0x40
0062B22EC  ret      
0062B22F0  cbz      x20, #0x62b25dc
0062B22F4  ldr      x8, [x20]
0062B22F8  mov      x0, x20
0062B22FC  ldr      x9, [x8, #0x4c8]
0062B2300  ldr      x1, [x8, #0x4d0]
0062B2304  blr      x9
0062B2308  tbz      w0, #0, #0x62b24b8
0062B230C  ldr      x8, [x20]
0062B2310  mov      x0, x20
0062B2314  ldr      x9, [x8, #0x558]
0062B2318  ldr      x1, [x8, #0x560]
0062B231C  blr      x9
0062B2320  adrp     x9, #0x8ee8000
0062B2324  ldr      x8, [x25]
0062B2328  ldr      x9, [x9, #0xe28]
0062B232C  mov      x21, x0
0062B2330  ldr      w10, [x8, #0xe0]
0062B2334  ldr      x22, [x9]
0062B2338  cbnz     w10, #0x62b2344
0062B233C  mov      x0, x8
0062B2340  bl       #0x382be8c ; 
0062B2344  mov      x0, x22
0062B2348  mov      x1, xzr
0062B234C  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B2350  mov      x1, x0
0062B2354  mov      x0, x21
0062B2358  mov      x2, xzr
0062B235C  bl       #0x7bf2990 ; System.Type$$op_Equality
0062B2360  tbz      w0, #0, #0x62b24b8
0062B2364  ldr      x8, [x20]
0062B2368  mov      x0, x20
0062B236C  ldr      x9, [x8, #0x578]
0062B2370  ldr      x1, [x8, #0x580]
0062B2374  blr      x9
0062B2378  cbz      x0, #0x62b25dc
0062B237C  ldr      w8, [x0, #0x18]
0062B2380  cbz      w8, #0x62b25e0
0062B2384  ldr      x21, [x0, #0x20]
0062B2388  cbz      x21, #0x62b23b8
0062B238C  ldr      x8, [x21]
0062B2390  ldr      x1, [x24]
0062B2394  ldrb     w10, [x8, #0x130]
0062B2398  ldrb     w9, [x1, #0x130]
0062B239C  cmp      w10, w9
0062B23A0  b.lo     #0x62b25e4
0062B23A4  ldr      x8, [x8, #0xc8]
0062B23A8  add      x8, x8, x9, lsl #3
0062B23AC  ldur     x8, [x8, #-8]
0062B23B0  cmp      x8, x1
0062B23B4  b.ne     #0x62b25e4
0062B23B8  adrp     x8, #0x8eeb000
0062B23BC  ldr      x0, [x25]
0062B23C0  ldr      x8, [x8, #0xe80]
0062B23C4  ldr      w9, [x0, #0xe0]
0062B23C8  ldr      x22, [x8]
0062B23CC  cbnz     w9, #0x62b23d4
0062B23D0  bl       #0x382be8c ; 
0062B23D4  mov      x0, x22
0062B23D8  mov      x1, xzr
0062B23DC  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B23E0  adrp     x8, #0x8ebf000
0062B23E4  ldr      x8, [x8, #0xd08]
0062B23E8  mov      x22, x0
0062B23EC  mov      w1, #1
0062B23F0  ldr      x8, [x8]
0062B23F4  mov      x0, x8
0062B23F8  bl       #0x382bdfc ; 
0062B23FC  cbz      x0, #0x62b25dc
0062B2400  mov      x23, x0
0062B2404  cbz      x21, #0x62b241c
0062B2408  ldr      x8, [x23]
0062B240C  mov      x0, x21
0062B2410  ldr      x1, [x8, #0x40]
0062B2414  bl       #0x382be90 ; 
0062B2418  cbz      x0, #0x62b25ec
0062B241C  ldr      w8, [x23, #0x18]
0062B2420  cbz      w8, #0x62b25e0
0062B2424  mov      x0, x23
0062B2428  str      x21, [x0, #0x20]!
0062B242C  mov      x1, x21
0062B2430  bl       #0x382bcb8 ; 
0062B2434  cbz      x22, #0x62b25dc
0062B2438  ldr      x8, [x22]
0062B243C  mov      x0, x22
0062B2440  mov      x1, x23
0062B2444  ldr      x9, [x8, #0xc08]
0062B2448  ldr      x2, [x8, #0xc10]
0062B244C  blr      x9
0062B2450  cbz      x0, #0x62b25dc
0062B2454  ldr      x8, [x0]
0062B2458  mov      x1, x21
0062B245C  ldr      x9, [x8, #0x388]
0062B2460  ldr      x2, [x8, #0x390]
0062B2464  blr      x9
0062B2468  tbz      w0, #0, #0x62b24b8
0062B246C  adrp     x8, #0x8eeb000
0062B2470  ldr      x0, [x25]
0062B2474  ldr      x8, [x8, #0xe98]
0062B2478  ldr      w9, [x0, #0xe0]
0062B247C  ldr      x20, [x8]
0062B2480  cbnz     w9, #0x62b2488
0062B2484  bl       #0x382be8c ; 
0062B2488  mov      x0, x20
0062B248C  mov      x1, xzr
0062B2490  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0062B2494  ldr      x8, [x24]
0062B2498  mov      x20, x0
0062B249C  ldr      w9, [x8, #0xe0]
0062B24A0  cbnz     w9, #0x62b24ac
0062B24A4  mov      x0, x8
0062B24A8  bl       #0x382be8c ; 
0062B24AC  mov      x0, x20
0062B24B0  mov      x1, x21
0062B24B4  b        #0x62b226c ; 
0062B24B8  ldr      x8, [x20]
0062B24BC  mov      x0, x20
0062B24C0  ldr      x9, [x8, #0x758]
0062B24C4  ldr      x1, [x8, #0x760]
0062B24C8  blr      x9
0062B24CC  tbz      w0, #0, #0x62b254c
0062B24D0  adrp     x8, #0x8ebf000
0062B24D4  ldr      x8, [x8, #0xf08]
0062B24D8  ldr      x0, [x8]
0062B24DC  ldr      w8, [x0, #0xe0]
0062B24E0  cbnz     w8, #0x62b24e8
0062B24E4  bl       #0x382be8c ; 
0062B24E8  mov      x0, x20
0062B24EC  mov      x1, xzr
0062B24F0  bl       #0x7c126a0 ; System.Enum$$GetUnderlyingType
0062B24F4  ldr      x8, [x25]
0062B24F8  mov      x21, x0
0062B24FC  ldr      w9, [x8, #0xe0]
0062B2500  cbnz     w9, #0x62b250c
0062B2504  mov      x0, x8
0062B2508  bl       #0x382be8c ; 
0062B250C  mov      x0, x21
0062B2510  mov      x1, xzr
0062B2514  bl       #0x7bf667c ; System.Type$$GetTypeCode
0062B2518  sub      w8, w0, #5
0062B251C  cmp      w8, #7
0062B2520  b.hi     #0x62b254c
0062B2524  adrp     x9, #0x1a71000
0062B2528  add      x9, x9, #0xd1e
0062B252C  adr      x10, #0x62b253c
0062B2530  ldrb     w11, [x9, x8]
0062B2534  add      x10, x10, x11, lsl #2
0062B2538  br       x10
0062B253C  adrp     x8, #0x8eeb000
0062B2540  ldr      x0, [x25]
0062B2544  ldr      x8, [x8, #0xe70]
0062B2548  b        #0x62b2230 ; 
0062B254C  ldr      x0, [x19, #0x20]
0062B2550  ldrb     w8, [x0, #0x135]
0062B2554  tbnz     w8, #0, #0x62b255c
0062B2558  bl       #0x3a7e60c ; 
0062B255C  ldr      x8, [x0, #0xc0]
0062B2560  ldr      x0, [x8, #0x30]
0062B2564  ldrb     w8, [x0, #0x135]
0062B2568  tbnz     w8, #0, #0x62b2570
0062B256C  bl       #0x3a7e60c ; 
0062B2570  bl       #0x382bfa0 ; 
0062B2574  ldr      x8, [x19, #0x20]
0062B2578  mov      x20, x0
0062B257C  ldrb     w9, [x8, #0x135]
0062B2580  tbnz     w9, #0, #0x62b2590
0062B2584  mov      x0, x8
0062B2588  bl       #0x3a7e60c ; 
0062B258C  mov      x8, x0
0062B2590  ldr      x8, [x8, #0xc0]
0062B2594  mov      x0, x20
0062B2598  ldr      x1, [x8, #0x38]
0062B259C  bl       #0x51d9310 ; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$.ctor
0062B25A0  b        #0x62b22d8 ; 
0062B25A4  adrp     x8, #0x8eeb000
0062B25A8  ldr      x0, [x25]
0062B25AC  ldr      x8, [x8, #0xe90]
0062B25B0  b        #0x62b2230 ; 
0062B25B4  adrp     x8, #0x8eeb000
0062B25B8  ldr      x0, [x25]
0062B25BC  ldr      x8, [x8, #0xea0]
0062B25C0  b        #0x62b2230 ; 
0062B25C4  adrp     x8, #0x8eeb000
0062B25C8  ldr      x0, [x25]
0062B25CC  ldr      x8, [x8, #0xea8]
0062B25D0  b        #0x62b2230 ; 
0062B25D4  mov      x0, x20
0062B25D8  bl       #0x382c354 ; 
0062B25DC  bl       #0x382bfb8 ; 
0062B25E0  bl       #0x382bfc0 ; 
0062B25E4  mov      x0, x21
0062B25E8  bl       #0x382c354 ; 
0062B25EC  bl       #0x382bfdc ; 
0062B25F0  mov      x1, xzr
0062B25F4  bl       #0x382be7c ; 

; System.Collections.Generic.EqualityComparer<WeightRandomData>$$IndexOf
; RVA 0x62B25F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0062B25F8  sub      sp, sp, #0x140
0062B25FC  stp      x29, x30, [sp, #0x100]
0062B2600  stp      x24, x23, [sp, #0x110]
0062B2604  stp      x22, x21, [sp, #0x120]
0062B2608  stp      x20, x19, [sp, #0x130]
0062B260C  add      w8, w4, w3
0062B2610  cmp      w8, w3
0062B2614  b.le     #0x62b26dc
0062B2618  mov      x21, x1
0062B261C  cbz      x1, #0x62b2700
0062B2620  mov      w9, #0x38
0062B2624  sxtw     x8, w8
0062B2628  smaddl   x9, w3, w9, x21
0062B262C  mov      w19, w3
0062B2630  mov      x20, x2
0062B2634  mov      x22, x0
0062B2638  add      x23, x9, #0x20
0062B263C  sub      x24, x8, w3, sxtw
0062B2640  ldr      w8, [x21, #0x18]
0062B2644  cmp      w19, w8
0062B2648  b.hs     #0x62b26fc
0062B264C  ldr      x8, [x23, #0x30]
0062B2650  ldp      q1, q0, [x23, #0x10]
0062B2654  ldr      q2, [x23]
0062B2658  add      x1, sp, #0xc0
0062B265C  str      x8, [sp, #0x70]
0062B2660  stp      q1, q0, [sp, #0x50]
0062B2664  str      q2, [sp, #0x40]
0062B2668  ldp      q2, q0, [x20, #0x10]
0062B266C  ldr      x8, [x20, #0x30]
0062B2670  ldr      q1, [x20]
0062B2674  ldr      x9, [sp, #0x70]
0062B2678  stp      q2, q0, [sp, #0x10]
0062B267C  str      x8, [sp, #0x30]
0062B2680  str      q1, [sp]
0062B2684  ldr      x8, [x22]
0062B2688  ldp      q1, q0, [sp, #0x50]
0062B268C  ldr      q2, [sp, #0x40]
0062B2690  add      x2, sp, #0x80
0062B2694  ldr      x10, [x8, #0x1b8]
0062B2698  stp      q1, q0, [sp, #0xd0]
0062B269C  ldp      q0, q3, [sp]
0062B26A0  ldr      q1, [sp, #0x20]
0062B26A4  str      x9, [sp, #0xf0]
0062B26A8  ldr      x9, [sp, #0x30]
0062B26AC  str      q2, [sp, #0xc0]
0062B26B0  stp      q0, q3, [sp, #0x80]
0062B26B4  str      q1, [sp, #0xa0]
0062B26B8  str      x9, [sp, #0xb0]
0062B26BC  ldr      x3, [x8, #0x1c0]
0062B26C0  mov      x0, x22
0062B26C4  blr      x10
0062B26C8  tbnz     w0, #0, #0x62b26e0
0062B26CC  add      w19, w19, #1
0062B26D0  subs     x24, x24, #1
0062B26D4  add      x23, x23, #0x38
0062B26D8  b.ne     #0x62b2640
0062B26DC  mov      w19, #-1
0062B26E0  mov      w0, w19
0062B26E4  ldp      x20, x19, [sp, #0x130]
0062B26E8  ldp      x22, x21, [sp, #0x120]
0062B26EC  ldp      x24, x23, [sp, #0x110]
0062B26F0  ldp      x29, x30, [sp, #0x100]
0062B26F4  add      sp, sp, #0x140
0062B26F8  ret      
0062B26FC  bl       #0x382bfc0 ; 
0062B2700  bl       #0x382bfb8 ; 

; System.Collections.Generic.EqualityComparer<WeightRandomData>$$LastIndexOf
; RVA 0x62B2704; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0062B2704  sub      sp, sp, #0x140
0062B2708  stp      x29, x30, [sp, #0x100]
0062B270C  stp      x24, x23, [sp, #0x110]
0062B2710  stp      x22, x21, [sp, #0x120]
0062B2714  stp      x20, x19, [sp, #0x130]
0062B2718  sub      w8, w3, w4
0062B271C  add      w23, w8, #1
0062B2720  cmp      w23, w3
0062B2724  b.gt     #0x62b27d8
0062B2728  mov      x21, x1
0062B272C  cbz      x1, #0x62b27fc
0062B2730  mov      w19, w3
0062B2734  mov      x20, x2
0062B2738  mov      x22, x0
0062B273C  mov      w24, #0x38
0062B2740  ldr      w8, [x21, #0x18]
0062B2744  cmp      w19, w8
0062B2748  b.hs     #0x62b27f8
0062B274C  smaddl   x8, w19, w24, x21
0062B2750  ldr      x9, [x8, #0x50]
0062B2754  ldp      q1, q0, [x8, #0x30]
0062B2758  ldr      q2, [x8, #0x20]
0062B275C  add      x1, sp, #0xc0
0062B2760  str      x9, [sp, #0x70]
0062B2764  stp      q1, q0, [sp, #0x50]
0062B2768  str      q2, [sp, #0x40]
0062B276C  ldp      q2, q0, [x20, #0x10]
0062B2770  ldr      x8, [x20, #0x30]
0062B2774  ldr      q1, [x20]
0062B2778  add      x2, sp, #0x80
0062B277C  stp      q2, q0, [sp, #0x10]
0062B2780  str      x8, [sp, #0x30]
0062B2784  str      q1, [sp]
0062B2788  ldr      x8, [x22]
0062B278C  ldp      q1, q0, [sp, #0x50]
0062B2790  ldr      q2, [sp, #0x40]
0062B2794  mov      x0, x22
0062B2798  ldr      x10, [x8, #0x1b8]
0062B279C  stp      q1, q0, [sp, #0xd0]
0062B27A0  ldp      q0, q3, [sp]
0062B27A4  ldr      q1, [sp, #0x20]
0062B27A8  str      x9, [sp, #0xf0]
0062B27AC  ldr      x9, [sp, #0x30]
0062B27B0  str      q2, [sp, #0xc0]
0062B27B4  stp      q0, q3, [sp, #0x80]
0062B27B8  str      q1, [sp, #0xa0]
0062B27BC  str      x9, [sp, #0xb0]
0062B27C0  ldr      x3, [x8, #0x1c0]
0062B27C4  blr      x10
0062B27C8  tbnz     w0, #0, #0x62b27dc
0062B27CC  sub      w19, w19, #1
0062B27D0  cmp      w19, w23
0062B27D4  b.ge     #0x62b2740
0062B27D8  mov      w19, #-1
0062B27DC  mov      w0, w19
0062B27E0  ldp      x20, x19, [sp, #0x130]
0062B27E4  ldp      x22, x21, [sp, #0x120]
0062B27E8  ldp      x24, x23, [sp, #0x110]
0062B27EC  ldp      x29, x30, [sp, #0x100]
0062B27F0  add      sp, sp, #0x140
0062B27F4  ret      
0062B27F8  bl       #0x382bfc0 ; 
0062B27FC  bl       #0x382bfb8 ; 

; System.Collections.Generic.EqualityComparer<WeightRandomData>$$System.Collections.IEqualityComparer.GetHashCode
; RVA 0x62B2800; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0062B2800  sub      sp, sp, #0xa0
0062B2804  stp      x30, x21, [sp, #0x80]
0062B2808  stp      x20, x19, [sp, #0x90]
0062B280C  cbz      x1, #0x62b28dc
0062B2810  ldr      x8, [x2, #0x20]
0062B2814  mov      x20, x1
0062B2818  mov      x21, x2
0062B281C  mov      x19, x0
0062B2820  ldr      x8, [x8, #0xc0]
0062B2824  ldr      x1, [x8, #0x48]
0062B2828  ldrb     w8, [x1, #0x135]
0062B282C  tbnz     w8, #0, #0x62b283c
0062B2830  mov      x0, x1
0062B2834  bl       #0x3a7e60c ; 
0062B2838  mov      x1, x0
0062B283C  mov      x0, x20
0062B2840  bl       #0x382be90 ; 
0062B2844  cbz      x0, #0x62b28d0
0062B2848  ldr      x8, [x21, #0x20]
0062B284C  ldr      x8, [x8, #0xc0]
0062B2850  ldr      x1, [x8, #0x48]
0062B2854  ldrb     w8, [x1, #0x135]
0062B2858  tbnz     w8, #0, #0x62b2868
0062B285C  mov      x0, x1
0062B2860  bl       #0x3a7e60c ; 
0062B2864  mov      x1, x0
0062B2868  ldr      x8, [x20]
0062B286C  ldr      x9, [x1, #0x40]
0062B2870  mov      x0, x20
0062B2874  ldr      x8, [x8, #0x40]
0062B2878  cmp      x8, x9
0062B287C  b.ne     #0x62b28f0
0062B2880  bl       #0x382be98 ; 
0062B2884  ldr      x8, [x0, #0x30]
0062B2888  ldp      q1, q0, [x0, #0x10]
0062B288C  ldr      q2, [x0]
0062B2890  add      x1, sp, #0x40
0062B2894  str      x8, [sp, #0x30]
0062B2898  stp      q1, q0, [sp, #0x10]
0062B289C  str      q2, [sp]
0062B28A0  ldr      x8, [x19]
0062B28A4  ldp      q0, q1, [sp]
0062B28A8  ldr      q2, [sp, #0x20]
0062B28AC  ldr      x9, [sp, #0x30]
0062B28B0  ldr      x10, [x8, #0x1c8]
0062B28B4  stp      q0, q1, [sp, #0x40]
0062B28B8  str      q2, [sp, #0x60]
0062B28BC  str      x9, [sp, #0x70]
0062B28C0  ldr      x2, [x8, #0x1d0]
0062B28C4  mov      x0, x19
0062B28C8  blr      x10
0062B28CC  b        #0x62b28e0 ; 
0062B28D0  mov      w0, #2
0062B28D4  mov      x1, xzr
0062B28D8  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
0062B28DC  mov      w0, wzr
0062B28E0  ldp      x20, x19, [sp, #0x90]
0062B28E4  ldp      x30, x21, [sp, #0x80]
0062B28E8  add      sp, sp, #0xa0
0062B28EC  ret      
0062B28F0  bl       #0x382c354 ; 

; System.Collections.Generic.EqualityComparer<WeightRandomData>$$System.Collections.IEqualityComparer.Equals
; RVA 0x62B28F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0062B28F4  sub      sp, sp, #0x130
0062B28F8  stp      x29, x30, [sp, #0x100]
0062B28FC  stp      x22, x21, [sp, #0x110]
0062B2900  stp      x20, x19, [sp, #0x120]
0062B2904  cmp      x1, x2
0062B2908  b.eq     #0x62b2a78
0062B290C  mov      x22, x1
0062B2910  mov      x19, x0
0062B2914  mov      w0, wzr
0062B2918  cbz      x1, #0x62b2a90
0062B291C  mov      x20, x2
0062B2920  cbz      x2, #0x62b2a90
0062B2924  ldr      x8, [x3, #0x20]
0062B2928  mov      x21, x3
0062B292C  ldr      x8, [x8, #0xc0]
0062B2930  ldr      x1, [x8, #0x48]
0062B2934  ldrb     w8, [x1, #0x135]
0062B2938  tbnz     w8, #0, #0x62b2948
0062B293C  mov      x0, x1
0062B2940  bl       #0x3a7e60c ; 
0062B2944  mov      x1, x0
0062B2948  mov      x0, x22
0062B294C  bl       #0x382be90 ; 
0062B2950  cbz      x0, #0x62b2a80
0062B2954  ldr      x8, [x21, #0x20]
0062B2958  ldr      x8, [x8, #0xc0]
0062B295C  ldr      x1, [x8, #0x48]
0062B2960  ldrb     w8, [x1, #0x135]
0062B2964  tbnz     w8, #0, #0x62b2974
0062B2968  mov      x0, x1
0062B296C  bl       #0x3a7e60c ; 
0062B2970  mov      x1, x0
0062B2974  mov      x0, x20
0062B2978  bl       #0x382be90 ; 
0062B297C  cbz      x0, #0x62b2a80
0062B2980  ldr      x8, [x21, #0x20]
0062B2984  ldr      x8, [x8, #0xc0]
0062B2988  ldr      x1, [x8, #0x48]
0062B298C  ldrb     w8, [x1, #0x135]
0062B2990  tbnz     w8, #0, #0x62b29a0
0062B2994  mov      x0, x1
0062B2998  bl       #0x3a7e60c ; 
0062B299C  mov      x1, x0
0062B29A0  ldr      x8, [x22]
0062B29A4  ldr      x9, [x1, #0x40]
0062B29A8  mov      x0, x22
0062B29AC  ldr      x8, [x8, #0x40]
0062B29B0  cmp      x8, x9
0062B29B4  b.ne     #0x62b2aa8
0062B29B8  bl       #0x382be98 ; 
0062B29BC  ldr      x8, [x0, #0x30]
0062B29C0  ldp      q1, q0, [x0, #0x10]
0062B29C4  ldr      q2, [x0]
0062B29C8  str      x8, [sp, #0x70]
0062B29CC  stp      q1, q0, [sp, #0x50]
0062B29D0  str      q2, [sp, #0x40]
0062B29D4  ldr      x8, [x21, #0x20]
0062B29D8  ldr      x8, [x8, #0xc0]
0062B29DC  ldr      x1, [x8, #0x48]
0062B29E0  ldrb     w8, [x1, #0x135]
0062B29E4  tbnz     w8, #0, #0x62b29f4
0062B29E8  mov      x0, x1
0062B29EC  bl       #0x3a7e60c ; 
0062B29F0  mov      x1, x0
0062B29F4  ldr      x8, [x20]
0062B29F8  ldr      x9, [x1, #0x40]
0062B29FC  mov      x0, x20
0062B2A00  ldr      x8, [x8, #0x40]
0062B2A04  cmp      x8, x9
0062B2A08  b.ne     #0x62b2aa8
0062B2A0C  bl       #0x382be98 ; 
0062B2A10  ldp      q1, q0, [x0, #0x10]
0062B2A14  ldr      x8, [x0, #0x30]
0062B2A18  ldr      q2, [x0]
0062B2A1C  ldr      x9, [sp, #0x70]
0062B2A20  stp      q1, q0, [sp, #0x10]
0062B2A24  str      x8, [sp, #0x30]
0062B2A28  str      q2, [sp]
0062B2A2C  ldr      x8, [x19]
0062B2A30  ldp      q1, q0, [sp, #0x50]
0062B2A34  ldr      q2, [sp, #0x40]
0062B2A38  add      x1, sp, #0xc0
0062B2A3C  ldr      x10, [x8, #0x1b8]
0062B2A40  stp      q1, q0, [sp, #0xd0]
0062B2A44  ldp      q0, q3, [sp]
0062B2A48  ldr      q1, [sp, #0x20]
0062B2A4C  str      x9, [sp, #0xf0]
0062B2A50  ldr      x9, [sp, #0x30]
0062B2A54  str      q2, [sp, #0xc0]
0062B2A58  stp      q0, q3, [sp, #0x80]
0062B2A5C  str      q1, [sp, #0xa0]
0062B2A60  str      x9, [sp, #0xb0]
0062B2A64  ldr      x3, [x8, #0x1c0]
0062B2A68  add      x2, sp, #0x80
0062B2A6C  mov      x0, x19
0062B2A70  blr      x10
0062B2A74  b        #0x62b2a90 ; 
0062B2A78  mov      w0, #1
0062B2A7C  b        #0x62b2a90 ; 
0062B2A80  mov      w0, #2
0062B2A84  mov      x1, xzr
0062B2A88  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
0062B2A8C  mov      w0, wzr
0062B2A90  ldp      x20, x19, [sp, #0x120]
0062B2A94  ldp      x22, x21, [sp, #0x110]
0062B2A98  ldp      x29, x30, [sp, #0x100]
0062B2A9C  and      w0, w0, #1
0062B2AA0  add      sp, sp, #0x130
0062B2AA4  ret      
0062B2AA8  bl       #0x382c354 ; 

; System.Collections.Generic.EqualityComparer<WeightRandomData>$$.ctor
; RVA 0x62B2AAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0062B2AAC  mov      x1, xzr
0062B2AB0  b        #0x7c335dc ; System.Object$$.ctor

