; LocalModels.Bean.Chapter_MainChapterHard$$readImpl
; RVA 0x68B22B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B22B8  stp      x30, x21, [sp, #-0x20]!
0068B22BC  stp      x20, x19, [sp, #0x10]
0068B22C0  adrp     x20, #0x959c000
0068B22C4  adrp     x21, #0x8f27000
0068B22C8  ldrb     w8, [x20, #0xad]
0068B22CC  ldr      x21, [x21, #0x150]
0068B22D0  mov      x19, x0
0068B22D4  tbnz     w8, #0, #0x68b22ec
0068B22D8  adrp     x0, #0x8f27000
0068B22DC  ldr      x0, [x0, #0x150]
0068B22E0  bl       #0x382bd14 ; 
0068B22E4  mov      w8, #1
0068B22E8  strb     w8, [x20, #0xad]
0068B22EC  ldr      x1, [x21]
0068B22F0  ldrb     w8, [x1, #0x53]
0068B22F4  tbnz     w8, #5, #0x68b2344
0068B22F8  mov      x0, x19
0068B22FC  mov      x1, xzr
0068B2300  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2304  adrp     x21, #0x959c000
0068B2308  ldrb     w8, [x21, #0x5d7]
0068B230C  mov      w20, w0
0068B2310  cbnz     w8, #0x68b2328
0068B2314  adrp     x0, #0x8f26000
0068B2318  ldr      x0, [x0, #0xeb8]
0068B231C  bl       #0x382bd14 ; 
0068B2320  mov      w8, #1
0068B2324  strb     w8, [x21, #0x5d7]
0068B2328  adrp     x8, #0x8f26000
0068B232C  ldr      x8, [x8, #0xeb8]
0068B2330  ldr      x2, [x8]
0068B2334  ldrb     w8, [x2, #0x53]
0068B2338  tbnz     w8, #5, #0x68b2358
0068B233C  str      w20, [x19, #0x20]
0068B2340  b        #0x68b2368 ; 
0068B2344  ldr      x2, [x1, #0x60]
0068B2348  mov      x0, x19
0068B234C  ldp      x20, x19, [sp, #0x10]
0068B2350  ldp      x30, x21, [sp], #0x20
0068B2354  br       x2
0068B2358  ldr      x8, [x2, #0x60]
0068B235C  mov      x0, x19
0068B2360  mov      w1, w20
0068B2364  blr      x8
0068B2368  mov      x0, x19
0068B236C  mov      x1, xzr
0068B2370  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068B2374  adrp     x21, #0x959c000
0068B2378  ldrb     w8, [x21, #0x5d8]
0068B237C  mov      x20, x0
0068B2380  cbnz     w8, #0x68b2398
0068B2384  adrp     x0, #0x8f26000
0068B2388  ldr      x0, [x0, #0xec8]
0068B238C  bl       #0x382bd14 ; 
0068B2390  mov      w8, #1
0068B2394  strb     w8, [x21, #0x5d8]
0068B2398  adrp     x8, #0x8f26000
0068B239C  ldr      x8, [x8, #0xec8]
0068B23A0  ldr      x2, [x8]
0068B23A4  ldrb     w8, [x2, #0x53]
0068B23A8  tbnz     w8, #5, #0x68b23c0
0068B23AC  mov      x0, x19
0068B23B0  str      x20, [x0, #0x28]!
0068B23B4  mov      x1, x20
0068B23B8  bl       #0x382bcb8 ; 
0068B23BC  b        #0x68b23d0 ; 
0068B23C0  ldr      x8, [x2, #0x60]
0068B23C4  mov      x0, x19
0068B23C8  mov      x1, x20
0068B23CC  blr      x8
0068B23D0  mov      x0, x19
0068B23D4  mov      x1, xzr
0068B23D8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068B23DC  adrp     x21, #0x959c000
0068B23E0  ldrb     w8, [x21, #0x5d9]
0068B23E4  mov      x20, x0
0068B23E8  cbnz     w8, #0x68b2400
0068B23EC  adrp     x0, #0x8f26000
0068B23F0  ldr      x0, [x0, #0xed8]
0068B23F4  bl       #0x382bd14 ; 
0068B23F8  mov      w8, #1
0068B23FC  strb     w8, [x21, #0x5d9]
0068B2400  adrp     x8, #0x8f26000
0068B2404  ldr      x8, [x8, #0xed8]
0068B2408  ldr      x2, [x8]
0068B240C  ldrb     w8, [x2, #0x53]
0068B2410  tbnz     w8, #5, #0x68b2428
0068B2414  mov      x0, x19
0068B2418  str      x20, [x0, #0x30]!
0068B241C  mov      x1, x20
0068B2420  bl       #0x382bcb8 ; 
0068B2424  b        #0x68b2438 ; 
0068B2428  ldr      x8, [x2, #0x60]
0068B242C  mov      x0, x19
0068B2430  mov      x1, x20
0068B2434  blr      x8
0068B2438  mov      x0, x19
0068B243C  mov      x1, xzr
0068B2440  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2444  adrp     x21, #0x959c000
0068B2448  ldrb     w8, [x21, #0x5da]
0068B244C  mov      w20, w0
0068B2450  cbnz     w8, #0x68b2468
0068B2454  adrp     x0, #0x8f26000
0068B2458  ldr      x0, [x0, #0xee8]
0068B245C  bl       #0x382bd14 ; 
0068B2460  mov      w8, #1
0068B2464  strb     w8, [x21, #0x5da]
0068B2468  adrp     x8, #0x8f26000
0068B246C  ldr      x8, [x8, #0xee8]
0068B2470  ldr      x2, [x8]
0068B2474  ldrb     w8, [x2, #0x53]
0068B2478  tbnz     w8, #5, #0x68b2484
0068B247C  str      w20, [x19, #0x38]
0068B2480  b        #0x68b2494 ; 
0068B2484  ldr      x8, [x2, #0x60]
0068B2488  mov      x0, x19
0068B248C  mov      w1, w20
0068B2490  blr      x8
0068B2494  mov      x0, x19
0068B2498  mov      x1, xzr
0068B249C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B24A0  adrp     x21, #0x959c000
0068B24A4  ldrb     w8, [x21, #0x5db]
0068B24A8  mov      x20, x0
0068B24AC  cbnz     w8, #0x68b24c4
0068B24B0  adrp     x0, #0x8f26000
0068B24B4  ldr      x0, [x0, #0xef8]
0068B24B8  bl       #0x382bd14 ; 
0068B24BC  mov      w8, #1
0068B24C0  strb     w8, [x21, #0x5db]
0068B24C4  adrp     x8, #0x8f26000
0068B24C8  ldr      x8, [x8, #0xef8]
0068B24CC  ldr      x2, [x8]
0068B24D0  ldrb     w8, [x2, #0x53]
0068B24D4  tbnz     w8, #5, #0x68b24ec
0068B24D8  mov      x0, x19
0068B24DC  str      x20, [x0, #0x40]!
0068B24E0  mov      x1, x20
0068B24E4  bl       #0x382bcb8 ; 
0068B24E8  b        #0x68b24fc ; 
0068B24EC  ldr      x8, [x2, #0x60]
0068B24F0  mov      x0, x19
0068B24F4  mov      x1, x20
0068B24F8  blr      x8
0068B24FC  mov      x0, x19
0068B2500  mov      x1, xzr
0068B2504  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2508  adrp     x21, #0x959c000
0068B250C  ldrb     w8, [x21, #0x5dc]
0068B2510  mov      w20, w0
0068B2514  cbnz     w8, #0x68b252c
0068B2518  adrp     x0, #0x8f26000
0068B251C  ldr      x0, [x0, #0xf08]
0068B2520  bl       #0x382bd14 ; 
0068B2524  mov      w8, #1
0068B2528  strb     w8, [x21, #0x5dc]
0068B252C  adrp     x8, #0x8f26000
0068B2530  ldr      x8, [x8, #0xf08]
0068B2534  ldr      x2, [x8]
0068B2538  ldrb     w8, [x2, #0x53]
0068B253C  tbnz     w8, #5, #0x68b2548
0068B2540  str      w20, [x19, #0x48]
0068B2544  b        #0x68b2558 ; 
0068B2548  ldr      x8, [x2, #0x60]
0068B254C  mov      x0, x19
0068B2550  mov      w1, w20
0068B2554  blr      x8
0068B2558  mov      x0, x19
0068B255C  mov      x1, xzr
0068B2560  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2564  adrp     x21, #0x959c000
0068B2568  ldrb     w8, [x21, #0x5dd]
0068B256C  mov      w20, w0
0068B2570  cbnz     w8, #0x68b2588
0068B2574  adrp     x0, #0x8f26000
0068B2578  ldr      x0, [x0, #0xf18]
0068B257C  bl       #0x382bd14 ; 
0068B2580  mov      w8, #1
0068B2584  strb     w8, [x21, #0x5dd]
0068B2588  adrp     x8, #0x8f26000
0068B258C  ldr      x8, [x8, #0xf18]
0068B2590  ldr      x2, [x8]
0068B2594  ldrb     w8, [x2, #0x53]
0068B2598  tbnz     w8, #5, #0x68b25a4
0068B259C  str      w20, [x19, #0x4c]
0068B25A0  b        #0x68b25b4 ; 
0068B25A4  ldr      x8, [x2, #0x60]
0068B25A8  mov      x0, x19
0068B25AC  mov      w1, w20
0068B25B0  blr      x8
0068B25B4  mov      x0, x19
0068B25B8  mov      x1, xzr
0068B25BC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B25C0  adrp     x21, #0x959c000
0068B25C4  ldrb     w8, [x21, #0x5de]
0068B25C8  mov      x20, x0
0068B25CC  cbnz     w8, #0x68b25e4
0068B25D0  adrp     x0, #0x8f26000
0068B25D4  ldr      x0, [x0, #0xf28]
0068B25D8  bl       #0x382bd14 ; 
0068B25DC  mov      w8, #1
0068B25E0  strb     w8, [x21, #0x5de]
0068B25E4  adrp     x8, #0x8f26000
0068B25E8  ldr      x8, [x8, #0xf28]
0068B25EC  ldr      x2, [x8]
0068B25F0  ldrb     w8, [x2, #0x53]
0068B25F4  tbnz     w8, #5, #0x68b2600
0068B25F8  str      x20, [x19, #0x50]
0068B25FC  b        #0x68b2610 ; 
0068B2600  ldr      x8, [x2, #0x60]
0068B2604  mov      x0, x19
0068B2608  mov      x1, x20
0068B260C  blr      x8
0068B2610  mov      x0, x19
0068B2614  mov      x1, xzr
0068B2618  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B261C  adrp     x21, #0x959c000
0068B2620  ldrb     w8, [x21, #0x5df]
0068B2624  mov      x20, x0
0068B2628  cbnz     w8, #0x68b2640
0068B262C  adrp     x0, #0x8f26000
0068B2630  ldr      x0, [x0, #0xf38]
0068B2634  bl       #0x382bd14 ; 
0068B2638  mov      w8, #1
0068B263C  strb     w8, [x21, #0x5df]
0068B2640  adrp     x8, #0x8f26000
0068B2644  ldr      x8, [x8, #0xf38]
0068B2648  ldr      x2, [x8]
0068B264C  ldrb     w8, [x2, #0x53]
0068B2650  tbnz     w8, #5, #0x68b265c
0068B2654  str      x20, [x19, #0x58]
0068B2658  b        #0x68b266c ; 
0068B265C  ldr      x8, [x2, #0x60]
0068B2660  mov      x0, x19
0068B2664  mov      x1, x20
0068B2668  blr      x8
0068B266C  mov      x0, x19
0068B2670  mov      x1, xzr
0068B2674  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B2678  adrp     x21, #0x959c000
0068B267C  ldrb     w8, [x21, #0x5e0]
0068B2680  mov      x20, x0
0068B2684  cbnz     w8, #0x68b269c
0068B2688  adrp     x0, #0x8f26000
0068B268C  ldr      x0, [x0, #0xf48]
0068B2690  bl       #0x382bd14 ; 
0068B2694  mov      w8, #1
0068B2698  strb     w8, [x21, #0x5e0]
0068B269C  adrp     x8, #0x8f26000
0068B26A0  ldr      x8, [x8, #0xf48]
0068B26A4  ldr      x2, [x8]
0068B26A8  ldrb     w8, [x2, #0x53]
0068B26AC  tbnz     w8, #5, #0x68b26b8
0068B26B0  str      x20, [x19, #0x60]
0068B26B4  b        #0x68b26c8 ; 
0068B26B8  ldr      x8, [x2, #0x60]
0068B26BC  mov      x0, x19
0068B26C0  mov      x1, x20
0068B26C4  blr      x8
0068B26C8  mov      x0, x19
0068B26CC  mov      x1, xzr
0068B26D0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B26D4  adrp     x21, #0x959c000
0068B26D8  ldrb     w8, [x21, #0x5e1]
0068B26DC  mov      x20, x0
0068B26E0  cbnz     w8, #0x68b26f8
0068B26E4  adrp     x0, #0x8f26000
0068B26E8  ldr      x0, [x0, #0xf58]
0068B26EC  bl       #0x382bd14 ; 
0068B26F0  mov      w8, #1
0068B26F4  strb     w8, [x21, #0x5e1]
0068B26F8  adrp     x8, #0x8f26000
0068B26FC  ldr      x8, [x8, #0xf58]
0068B2700  ldr      x2, [x8]
0068B2704  ldrb     w8, [x2, #0x53]
0068B2708  tbnz     w8, #5, #0x68b2714
0068B270C  str      x20, [x19, #0x68]
0068B2710  b        #0x68b2724 ; 
0068B2714  ldr      x8, [x2, #0x60]
0068B2718  mov      x0, x19
0068B271C  mov      x1, x20
0068B2720  blr      x8
0068B2724  mov      x0, x19
0068B2728  mov      x1, xzr
0068B272C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2730  adrp     x21, #0x959c000
0068B2734  ldrb     w8, [x21, #0x5e2]
0068B2738  mov      w20, w0
0068B273C  cbnz     w8, #0x68b2754
0068B2740  adrp     x0, #0x8f26000
0068B2744  ldr      x0, [x0, #0xf68]
0068B2748  bl       #0x382bd14 ; 
0068B274C  mov      w8, #1
0068B2750  strb     w8, [x21, #0x5e2]
0068B2754  adrp     x8, #0x8f26000
0068B2758  ldr      x8, [x8, #0xf68]
0068B275C  ldr      x2, [x8]
0068B2760  ldrb     w8, [x2, #0x53]
0068B2764  tbnz     w8, #5, #0x68b2770
0068B2768  str      w20, [x19, #0x70]
0068B276C  b        #0x68b2780 ; 
0068B2770  ldr      x8, [x2, #0x60]
0068B2774  mov      x0, x19
0068B2778  mov      w1, w20
0068B277C  blr      x8
0068B2780  mov      x0, x19
0068B2784  mov      x1, xzr
0068B2788  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B278C  adrp     x21, #0x959c000
0068B2790  ldrb     w8, [x21, #0x5e3]
0068B2794  mov      w20, w0
0068B2798  cbnz     w8, #0x68b27b0
0068B279C  adrp     x0, #0x8f26000
0068B27A0  ldr      x0, [x0, #0xf78]
0068B27A4  bl       #0x382bd14 ; 
0068B27A8  mov      w8, #1
0068B27AC  strb     w8, [x21, #0x5e3]
0068B27B0  adrp     x8, #0x8f26000
0068B27B4  ldr      x8, [x8, #0xf78]
0068B27B8  ldr      x2, [x8]
0068B27BC  ldrb     w8, [x2, #0x53]
0068B27C0  tbnz     w8, #5, #0x68b27cc
0068B27C4  str      w20, [x19, #0x74]
0068B27C8  b        #0x68b27dc ; 
0068B27CC  ldr      x8, [x2, #0x60]
0068B27D0  mov      x0, x19
0068B27D4  mov      w1, w20
0068B27D8  blr      x8
0068B27DC  mov      x0, x19
0068B27E0  mov      x1, xzr
0068B27E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B27E8  adrp     x21, #0x959c000
0068B27EC  ldrb     w8, [x21, #0x5e4]
0068B27F0  mov      w20, w0
0068B27F4  cbnz     w8, #0x68b280c
0068B27F8  adrp     x0, #0x8f26000
0068B27FC  ldr      x0, [x0, #0xf88]
0068B2800  bl       #0x382bd14 ; 
0068B2804  mov      w8, #1
0068B2808  strb     w8, [x21, #0x5e4]
0068B280C  adrp     x8, #0x8f26000
0068B2810  ldr      x8, [x8, #0xf88]
0068B2814  ldr      x2, [x8]
0068B2818  ldrb     w8, [x2, #0x53]
0068B281C  tbnz     w8, #5, #0x68b2828
0068B2820  str      w20, [x19, #0x78]
0068B2824  b        #0x68b2838 ; 
0068B2828  ldr      x8, [x2, #0x60]
0068B282C  mov      x0, x19
0068B2830  mov      w1, w20
0068B2834  blr      x8
0068B2838  mov      x0, x19
0068B283C  mov      x1, xzr
0068B2840  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068B2844  adrp     x21, #0x959c000
0068B2848  ldrb     w8, [x21, #0x5e5]
0068B284C  mov      x20, x0
0068B2850  cbnz     w8, #0x68b2868
0068B2854  adrp     x0, #0x8f26000
0068B2858  ldr      x0, [x0, #0xf98]
0068B285C  bl       #0x382bd14 ; 
0068B2860  mov      w8, #1
0068B2864  strb     w8, [x21, #0x5e5]
0068B2868  adrp     x8, #0x8f26000
0068B286C  ldr      x8, [x8, #0xf98]
0068B2870  ldr      x2, [x8]
0068B2874  ldrb     w8, [x2, #0x53]
0068B2878  tbnz     w8, #5, #0x68b2890
0068B287C  mov      x0, x19
0068B2880  str      x20, [x0, #0x80]!
0068B2884  mov      x1, x20
0068B2888  bl       #0x382bcb8 ; 
0068B288C  b        #0x68b28a0 ; 
0068B2890  ldr      x8, [x2, #0x60]
0068B2894  mov      x0, x19
0068B2898  mov      x1, x20
0068B289C  blr      x8
0068B28A0  mov      x0, x19
0068B28A4  mov      x1, xzr
0068B28A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B28AC  adrp     x21, #0x959c000
0068B28B0  ldrb     w8, [x21, #0x5e6]
0068B28B4  mov      w20, w0
0068B28B8  cbnz     w8, #0x68b28d0
0068B28BC  adrp     x0, #0x8f26000
0068B28C0  ldr      x0, [x0, #0xfa8]
0068B28C4  bl       #0x382bd14 ; 
0068B28C8  mov      w8, #1
0068B28CC  strb     w8, [x21, #0x5e6]
0068B28D0  adrp     x8, #0x8f26000
0068B28D4  ldr      x8, [x8, #0xfa8]
0068B28D8  ldr      x2, [x8]
0068B28DC  ldrb     w8, [x2, #0x53]
0068B28E0  tbnz     w8, #5, #0x68b28ec
0068B28E4  str      w20, [x19, #0x88]
0068B28E8  b        #0x68b28fc ; 
0068B28EC  ldr      x8, [x2, #0x60]
0068B28F0  mov      x0, x19
0068B28F4  mov      w1, w20
0068B28F8  blr      x8
0068B28FC  mov      x0, x19
0068B2900  mov      x1, xzr
0068B2904  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2908  adrp     x21, #0x959c000
0068B290C  ldrb     w8, [x21, #0x5e7]
0068B2910  mov      w20, w0
0068B2914  cbnz     w8, #0x68b292c
0068B2918  adrp     x0, #0x8f26000
0068B291C  ldr      x0, [x0, #0xfb8]
0068B2920  bl       #0x382bd14 ; 
0068B2924  mov      w8, #1
0068B2928  strb     w8, [x21, #0x5e7]
0068B292C  adrp     x8, #0x8f26000
0068B2930  ldr      x8, [x8, #0xfb8]
0068B2934  ldr      x2, [x8]
0068B2938  ldrb     w8, [x2, #0x53]
0068B293C  tbnz     w8, #5, #0x68b2948
0068B2940  str      w20, [x19, #0x8c]
0068B2944  b        #0x68b2958 ; 
0068B2948  ldr      x8, [x2, #0x60]
0068B294C  mov      x0, x19
0068B2950  mov      w1, w20
0068B2954  blr      x8
0068B2958  mov      x0, x19
0068B295C  mov      x1, xzr
0068B2960  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2964  adrp     x21, #0x959c000
0068B2968  ldrb     w8, [x21, #0x5e8]
0068B296C  mov      x20, x0
0068B2970  cbnz     w8, #0x68b2988
0068B2974  adrp     x0, #0x8f26000
0068B2978  ldr      x0, [x0, #0xfc8]
0068B297C  bl       #0x382bd14 ; 
0068B2980  mov      w8, #1
0068B2984  strb     w8, [x21, #0x5e8]
0068B2988  adrp     x8, #0x8f26000
0068B298C  ldr      x8, [x8, #0xfc8]
0068B2990  ldr      x2, [x8]
0068B2994  ldrb     w8, [x2, #0x53]
0068B2998  tbnz     w8, #5, #0x68b29b0
0068B299C  mov      x0, x19
0068B29A0  str      x20, [x0, #0x90]!
0068B29A4  mov      x1, x20
0068B29A8  bl       #0x382bcb8 ; 
0068B29AC  b        #0x68b29c0 ; 
0068B29B0  ldr      x8, [x2, #0x60]
0068B29B4  mov      x0, x19
0068B29B8  mov      x1, x20
0068B29BC  blr      x8
0068B29C0  mov      x0, x19
0068B29C4  mov      x1, xzr
0068B29C8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B29CC  adrp     x21, #0x959c000
0068B29D0  ldrb     w8, [x21, #0x5e9]
0068B29D4  mov      x20, x0
0068B29D8  cbnz     w8, #0x68b29f0
0068B29DC  adrp     x0, #0x8f26000
0068B29E0  ldr      x0, [x0, #0xfd8]
0068B29E4  bl       #0x382bd14 ; 
0068B29E8  mov      w8, #1
0068B29EC  strb     w8, [x21, #0x5e9]
0068B29F0  adrp     x8, #0x8f26000
0068B29F4  ldr      x8, [x8, #0xfd8]
0068B29F8  ldr      x2, [x8]
0068B29FC  ldrb     w8, [x2, #0x53]
0068B2A00  tbnz     w8, #5, #0x68b2a18
0068B2A04  mov      x0, x19
0068B2A08  str      x20, [x0, #0x98]!
0068B2A0C  mov      x1, x20
0068B2A10  bl       #0x382bcb8 ; 
0068B2A14  b        #0x68b2a28 ; 
0068B2A18  ldr      x8, [x2, #0x60]
0068B2A1C  mov      x0, x19
0068B2A20  mov      x1, x20
0068B2A24  blr      x8
0068B2A28  mov      x0, x19
0068B2A2C  mov      x1, xzr
0068B2A30  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2A34  adrp     x21, #0x959c000
0068B2A38  ldrb     w8, [x21, #0x5ea]
0068B2A3C  mov      x20, x0
0068B2A40  cbnz     w8, #0x68b2a58
0068B2A44  adrp     x0, #0x8f26000
0068B2A48  ldr      x0, [x0, #0xfe8]
0068B2A4C  bl       #0x382bd14 ; 
0068B2A50  mov      w8, #1
0068B2A54  strb     w8, [x21, #0x5ea]
0068B2A58  adrp     x8, #0x8f26000
0068B2A5C  ldr      x8, [x8, #0xfe8]
0068B2A60  ldr      x2, [x8]
0068B2A64  ldrb     w8, [x2, #0x53]
0068B2A68  tbnz     w8, #5, #0x68b2a80
0068B2A6C  mov      x0, x19
0068B2A70  str      x20, [x0, #0xa0]!
0068B2A74  mov      x1, x20
0068B2A78  bl       #0x382bcb8 ; 
0068B2A7C  b        #0x68b2a90 ; 
0068B2A80  ldr      x8, [x2, #0x60]
0068B2A84  mov      x0, x19
0068B2A88  mov      x1, x20
0068B2A8C  blr      x8
0068B2A90  mov      x0, x19
0068B2A94  mov      x1, xzr
0068B2A98  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2A9C  adrp     x21, #0x959c000
0068B2AA0  ldrb     w8, [x21, #0x5eb]
0068B2AA4  mov      x20, x0
0068B2AA8  cbnz     w8, #0x68b2ac0
0068B2AAC  adrp     x0, #0x8f26000
0068B2AB0  ldr      x0, [x0, #0xff8]
0068B2AB4  bl       #0x382bd14 ; 
0068B2AB8  mov      w8, #1
0068B2ABC  strb     w8, [x21, #0x5eb]
0068B2AC0  adrp     x8, #0x8f26000
0068B2AC4  ldr      x8, [x8, #0xff8]
0068B2AC8  ldr      x2, [x8]
0068B2ACC  ldrb     w8, [x2, #0x53]
0068B2AD0  tbnz     w8, #5, #0x68b2ae8
0068B2AD4  mov      x0, x19
0068B2AD8  str      x20, [x0, #0xa8]!
0068B2ADC  mov      x1, x20
0068B2AE0  bl       #0x382bcb8 ; 
0068B2AE4  b        #0x68b2af8 ; 
0068B2AE8  ldr      x8, [x2, #0x60]
0068B2AEC  mov      x0, x19
0068B2AF0  mov      x1, x20
0068B2AF4  blr      x8
0068B2AF8  mov      x0, x19
0068B2AFC  mov      x1, xzr
0068B2B00  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2B04  adrp     x21, #0x959c000
0068B2B08  ldrb     w8, [x21, #0x5ec]
0068B2B0C  mov      x20, x0
0068B2B10  cbnz     w8, #0x68b2b28
0068B2B14  adrp     x0, #0x8f27000
0068B2B18  ldr      x0, [x0, #8]
0068B2B1C  bl       #0x382bd14 ; 
0068B2B20  mov      w8, #1
0068B2B24  strb     w8, [x21, #0x5ec]
0068B2B28  adrp     x8, #0x8f27000
0068B2B2C  ldr      x8, [x8, #8]
0068B2B30  ldr      x2, [x8]
0068B2B34  ldrb     w8, [x2, #0x53]
0068B2B38  tbnz     w8, #5, #0x68b2b50
0068B2B3C  mov      x0, x19
0068B2B40  str      x20, [x0, #0xb0]!
0068B2B44  mov      x1, x20
0068B2B48  bl       #0x382bcb8 ; 
0068B2B4C  b        #0x68b2b60 ; 
0068B2B50  ldr      x8, [x2, #0x60]
0068B2B54  mov      x0, x19
0068B2B58  mov      x1, x20
0068B2B5C  blr      x8
0068B2B60  mov      x0, x19
0068B2B64  mov      x1, xzr
0068B2B68  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2B6C  adrp     x21, #0x959c000
0068B2B70  ldrb     w8, [x21, #0x5ed]
0068B2B74  mov      x20, x0
0068B2B78  cbnz     w8, #0x68b2b90
0068B2B7C  adrp     x0, #0x8f27000
0068B2B80  ldr      x0, [x0, #0x18]
0068B2B84  bl       #0x382bd14 ; 
0068B2B88  mov      w8, #1
0068B2B8C  strb     w8, [x21, #0x5ed]
0068B2B90  adrp     x8, #0x8f27000
0068B2B94  ldr      x8, [x8, #0x18]
0068B2B98  ldr      x2, [x8]
0068B2B9C  ldrb     w8, [x2, #0x53]
0068B2BA0  tbnz     w8, #5, #0x68b2bb8
0068B2BA4  mov      x0, x19
0068B2BA8  str      x20, [x0, #0xb8]!
0068B2BAC  mov      x1, x20
0068B2BB0  bl       #0x382bcb8 ; 
0068B2BB4  b        #0x68b2bc8 ; 
0068B2BB8  ldr      x8, [x2, #0x60]
0068B2BBC  mov      x0, x19
0068B2BC0  mov      x1, x20
0068B2BC4  blr      x8
0068B2BC8  mov      x0, x19
0068B2BCC  mov      x1, xzr
0068B2BD0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2BD4  adrp     x21, #0x959c000
0068B2BD8  ldrb     w8, [x21, #0x5ee]
0068B2BDC  mov      x20, x0
0068B2BE0  cbnz     w8, #0x68b2bf8
0068B2BE4  adrp     x0, #0x8f27000
0068B2BE8  ldr      x0, [x0, #0x28]
0068B2BEC  bl       #0x382bd14 ; 
0068B2BF0  mov      w8, #1
0068B2BF4  strb     w8, [x21, #0x5ee]
0068B2BF8  adrp     x8, #0x8f27000
0068B2BFC  ldr      x8, [x8, #0x28]
0068B2C00  ldr      x2, [x8]
0068B2C04  ldrb     w8, [x2, #0x53]
0068B2C08  tbnz     w8, #5, #0x68b2c20
0068B2C0C  mov      x0, x19
0068B2C10  str      x20, [x0, #0xc0]!
0068B2C14  mov      x1, x20
0068B2C18  bl       #0x382bcb8 ; 
0068B2C1C  b        #0x68b2c30 ; 
0068B2C20  ldr      x8, [x2, #0x60]
0068B2C24  mov      x0, x19
0068B2C28  mov      x1, x20
0068B2C2C  blr      x8
0068B2C30  mov      x0, x19
0068B2C34  mov      x1, xzr
0068B2C38  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2C3C  adrp     x21, #0x959c000
0068B2C40  ldrb     w8, [x21, #0x5ef]
0068B2C44  mov      x20, x0
0068B2C48  cbnz     w8, #0x68b2c60
0068B2C4C  adrp     x0, #0x8f27000
0068B2C50  ldr      x0, [x0, #0x38]
0068B2C54  bl       #0x382bd14 ; 
0068B2C58  mov      w8, #1
0068B2C5C  strb     w8, [x21, #0x5ef]
0068B2C60  adrp     x8, #0x8f27000
0068B2C64  ldr      x8, [x8, #0x38]
0068B2C68  ldr      x2, [x8]
0068B2C6C  ldrb     w8, [x2, #0x53]
0068B2C70  tbnz     w8, #5, #0x68b2c88
0068B2C74  mov      x0, x19
0068B2C78  str      x20, [x0, #0xc8]!
0068B2C7C  mov      x1, x20
0068B2C80  bl       #0x382bcb8 ; 
0068B2C84  b        #0x68b2c98 ; 
0068B2C88  ldr      x8, [x2, #0x60]
0068B2C8C  mov      x0, x19
0068B2C90  mov      x1, x20
0068B2C94  blr      x8
0068B2C98  mov      x0, x19
0068B2C9C  mov      x1, xzr
0068B2CA0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2CA4  adrp     x21, #0x959c000
0068B2CA8  ldrb     w8, [x21, #0x5f0]
0068B2CAC  mov      x20, x0
0068B2CB0  cbnz     w8, #0x68b2cc8
0068B2CB4  adrp     x0, #0x8f27000
0068B2CB8  ldr      x0, [x0, #0x48]
0068B2CBC  bl       #0x382bd14 ; 
0068B2CC0  mov      w8, #1
0068B2CC4  strb     w8, [x21, #0x5f0]
0068B2CC8  adrp     x8, #0x8f27000
0068B2CCC  ldr      x8, [x8, #0x48]
0068B2CD0  ldr      x2, [x8]
0068B2CD4  ldrb     w8, [x2, #0x53]
0068B2CD8  tbnz     w8, #5, #0x68b2cf0
0068B2CDC  mov      x0, x19
0068B2CE0  str      x20, [x0, #0xd0]!
0068B2CE4  mov      x1, x20
0068B2CE8  bl       #0x382bcb8 ; 
0068B2CEC  b        #0x68b2d00 ; 
0068B2CF0  ldr      x8, [x2, #0x60]
0068B2CF4  mov      x0, x19
0068B2CF8  mov      x1, x20
0068B2CFC  blr      x8
0068B2D00  mov      x0, x19
0068B2D04  mov      x1, xzr
0068B2D08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2D0C  adrp     x21, #0x959c000
0068B2D10  ldrb     w8, [x21, #0x5f1]
0068B2D14  mov      w20, w0
0068B2D18  cbnz     w8, #0x68b2d30
0068B2D1C  adrp     x0, #0x8f27000
0068B2D20  ldr      x0, [x0, #0x58]
0068B2D24  bl       #0x382bd14 ; 
0068B2D28  mov      w8, #1
0068B2D2C  strb     w8, [x21, #0x5f1]
0068B2D30  adrp     x8, #0x8f27000
0068B2D34  ldr      x8, [x8, #0x58]
0068B2D38  ldr      x2, [x8]
0068B2D3C  ldrb     w8, [x2, #0x53]
0068B2D40  tbnz     w8, #5, #0x68b2d4c
0068B2D44  str      w20, [x19, #0xd8]
0068B2D48  b        #0x68b2d5c ; 
0068B2D4C  ldr      x8, [x2, #0x60]
0068B2D50  mov      x0, x19
0068B2D54  mov      w1, w20
0068B2D58  blr      x8
0068B2D5C  mov      x0, x19
0068B2D60  mov      x1, xzr
0068B2D64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2D68  adrp     x21, #0x959c000
0068B2D6C  ldrb     w8, [x21, #0x5f2]
0068B2D70  mov      w20, w0
0068B2D74  cbnz     w8, #0x68b2d8c
0068B2D78  adrp     x0, #0x8f27000
0068B2D7C  ldr      x0, [x0, #0x68]
0068B2D80  bl       #0x382bd14 ; 
0068B2D84  mov      w8, #1
0068B2D88  strb     w8, [x21, #0x5f2]
0068B2D8C  adrp     x8, #0x8f27000
0068B2D90  ldr      x8, [x8, #0x68]
0068B2D94  ldr      x2, [x8]
0068B2D98  ldrb     w8, [x2, #0x53]
0068B2D9C  tbnz     w8, #5, #0x68b2da8
0068B2DA0  str      w20, [x19, #0xdc]
0068B2DA4  b        #0x68b2db8 ; 
0068B2DA8  ldr      x8, [x2, #0x60]
0068B2DAC  mov      x0, x19
0068B2DB0  mov      w1, w20
0068B2DB4  blr      x8
0068B2DB8  mov      x0, x19
0068B2DBC  mov      x1, xzr
0068B2DC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2DC4  adrp     x21, #0x959c000
0068B2DC8  ldrb     w8, [x21, #0x5f3]
0068B2DCC  mov      w20, w0
0068B2DD0  cbnz     w8, #0x68b2de8
0068B2DD4  adrp     x0, #0x8f27000
0068B2DD8  ldr      x0, [x0, #0x78]
0068B2DDC  bl       #0x382bd14 ; 
0068B2DE0  mov      w8, #1
0068B2DE4  strb     w8, [x21, #0x5f3]
0068B2DE8  adrp     x8, #0x8f27000
0068B2DEC  ldr      x8, [x8, #0x78]
0068B2DF0  ldr      x2, [x8]
0068B2DF4  ldrb     w8, [x2, #0x53]
0068B2DF8  tbnz     w8, #5, #0x68b2e04
0068B2DFC  str      w20, [x19, #0xe0]
0068B2E00  b        #0x68b2e14 ; 
0068B2E04  ldr      x8, [x2, #0x60]
0068B2E08  mov      x0, x19
0068B2E0C  mov      w1, w20
0068B2E10  blr      x8
0068B2E14  mov      x0, x19
0068B2E18  mov      x1, xzr
0068B2E1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2E20  adrp     x21, #0x959c000
0068B2E24  ldrb     w8, [x21, #0x5f4]
0068B2E28  mov      w20, w0
0068B2E2C  cbnz     w8, #0x68b2e44
0068B2E30  adrp     x0, #0x8f27000
0068B2E34  ldr      x0, [x0, #0x88]
0068B2E38  bl       #0x382bd14 ; 
0068B2E3C  mov      w8, #1
0068B2E40  strb     w8, [x21, #0x5f4]
0068B2E44  adrp     x8, #0x8f27000
0068B2E48  ldr      x8, [x8, #0x88]
0068B2E4C  ldr      x2, [x8]
0068B2E50  ldrb     w8, [x2, #0x53]
0068B2E54  tbnz     w8, #5, #0x68b2e60
0068B2E58  str      w20, [x19, #0xe4]
0068B2E5C  b        #0x68b2e70 ; 
0068B2E60  ldr      x8, [x2, #0x60]
0068B2E64  mov      x0, x19
0068B2E68  mov      w1, w20
0068B2E6C  blr      x8
0068B2E70  mov      x0, x19
0068B2E74  mov      x1, xzr
0068B2E78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2E7C  adrp     x21, #0x959c000
0068B2E80  ldrb     w8, [x21, #0x5f5]
0068B2E84  mov      w20, w0
0068B2E88  cbnz     w8, #0x68b2ea0
0068B2E8C  adrp     x0, #0x8f27000
0068B2E90  ldr      x0, [x0, #0x98]
0068B2E94  bl       #0x382bd14 ; 
0068B2E98  mov      w8, #1
0068B2E9C  strb     w8, [x21, #0x5f5]
0068B2EA0  adrp     x8, #0x8f27000
0068B2EA4  ldr      x8, [x8, #0x98]
0068B2EA8  ldr      x2, [x8]
0068B2EAC  ldrb     w8, [x2, #0x53]
0068B2EB0  tbnz     w8, #5, #0x68b2ebc
0068B2EB4  str      w20, [x19, #0xe8]
0068B2EB8  b        #0x68b2ecc ; 
0068B2EBC  ldr      x8, [x2, #0x60]
0068B2EC0  mov      x0, x19
0068B2EC4  mov      w1, w20
0068B2EC8  blr      x8
0068B2ECC  mov      x0, x19
0068B2ED0  mov      x1, xzr
0068B2ED4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B2ED8  adrp     x21, #0x959c000
0068B2EDC  ldrb     w8, [x21, #0x5f6]
0068B2EE0  mov      w20, w0
0068B2EE4  cbnz     w8, #0x68b2efc
0068B2EE8  adrp     x0, #0x8f27000
0068B2EEC  ldr      x0, [x0, #0xa8]
0068B2EF0  bl       #0x382bd14 ; 
0068B2EF4  mov      w8, #1
0068B2EF8  strb     w8, [x21, #0x5f6]
0068B2EFC  adrp     x8, #0x8f27000
0068B2F00  ldr      x8, [x8, #0xa8]
0068B2F04  ldr      x2, [x8]
0068B2F08  ldrb     w8, [x2, #0x53]
0068B2F0C  tbnz     w8, #5, #0x68b2f18
0068B2F10  str      w20, [x19, #0xec]
0068B2F14  b        #0x68b2f28 ; 
0068B2F18  ldr      x8, [x2, #0x60]
0068B2F1C  mov      x0, x19
0068B2F20  mov      w1, w20
0068B2F24  blr      x8
0068B2F28  mov      x0, x19
0068B2F2C  mov      x1, xzr
0068B2F30  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068B2F34  adrp     x21, #0x959c000
0068B2F38  ldrb     w8, [x21, #0x5f7]
0068B2F3C  mov      x20, x0
0068B2F40  cbnz     w8, #0x68b2f58
0068B2F44  adrp     x0, #0x8f27000
0068B2F48  ldr      x0, [x0, #0xb8]
0068B2F4C  bl       #0x382bd14 ; 
0068B2F50  mov      w8, #1
0068B2F54  strb     w8, [x21, #0x5f7]
0068B2F58  adrp     x8, #0x8f27000
0068B2F5C  ldr      x8, [x8, #0xb8]
0068B2F60  ldr      x2, [x8]
0068B2F64  ldrb     w8, [x2, #0x53]
0068B2F68  tbnz     w8, #5, #0x68b2f80
0068B2F6C  mov      x0, x19
0068B2F70  str      x20, [x0, #0xf0]!
0068B2F74  mov      x1, x20
0068B2F78  bl       #0x382bcb8 ; 
0068B2F7C  b        #0x68b2f90 ; 
0068B2F80  ldr      x8, [x2, #0x60]
0068B2F84  mov      x0, x19
0068B2F88  mov      x1, x20
0068B2F8C  blr      x8
0068B2F90  mov      x0, x19
0068B2F94  mov      x1, xzr
0068B2F98  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B2F9C  adrp     x21, #0x959c000
0068B2FA0  ldrb     w8, [x21, #0x5f8]
0068B2FA4  mov      x20, x0
0068B2FA8  cbnz     w8, #0x68b2fc0
0068B2FAC  adrp     x0, #0x8f27000
0068B2FB0  ldr      x0, [x0, #0xc8]
0068B2FB4  bl       #0x382bd14 ; 
0068B2FB8  mov      w8, #1
0068B2FBC  strb     w8, [x21, #0x5f8]
0068B2FC0  adrp     x8, #0x8f27000
0068B2FC4  ldr      x8, [x8, #0xc8]
0068B2FC8  ldr      x2, [x8]
0068B2FCC  ldrb     w8, [x2, #0x53]
0068B2FD0  tbnz     w8, #5, #0x68b2fe8
0068B2FD4  mov      x0, x19
0068B2FD8  str      x20, [x0, #0xf8]!
0068B2FDC  mov      x1, x20
0068B2FE0  bl       #0x382bcb8 ; 
0068B2FE4  b        #0x68b2ff8 ; 
0068B2FE8  ldr      x8, [x2, #0x60]
0068B2FEC  mov      x0, x19
0068B2FF0  mov      x1, x20
0068B2FF4  blr      x8
0068B2FF8  mov      x0, x19
0068B2FFC  mov      x1, xzr
0068B3000  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B3004  adrp     x21, #0x959c000
0068B3008  ldrb     w8, [x21, #0x5f9]
0068B300C  mov      w20, w0
0068B3010  cbnz     w8, #0x68b3028
0068B3014  adrp     x0, #0x8f27000
0068B3018  ldr      x0, [x0, #0xd8]
0068B301C  bl       #0x382bd14 ; 
0068B3020  mov      w8, #1
0068B3024  strb     w8, [x21, #0x5f9]
0068B3028  adrp     x8, #0x8f27000
0068B302C  ldr      x8, [x8, #0xd8]
0068B3030  ldr      x2, [x8]
0068B3034  ldrb     w8, [x2, #0x53]
0068B3038  tbnz     w8, #5, #0x68b3044
0068B303C  str      w20, [x19, #0x100]
0068B3040  b        #0x68b3054 ; 
0068B3044  ldr      x8, [x2, #0x60]
0068B3048  mov      x0, x19
0068B304C  mov      w1, w20
0068B3050  blr      x8
0068B3054  mov      x0, x19
0068B3058  mov      x1, xzr
0068B305C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B3060  adrp     x21, #0x959c000
0068B3064  ldrb     w8, [x21, #0x5fa]
0068B3068  mov      x20, x0
0068B306C  cbnz     w8, #0x68b3084
0068B3070  adrp     x0, #0x8f27000
0068B3074  ldr      x0, [x0, #0xe8]
0068B3078  bl       #0x382bd14 ; 
0068B307C  mov      w8, #1
0068B3080  strb     w8, [x21, #0x5fa]
0068B3084  adrp     x8, #0x8f27000
0068B3088  ldr      x8, [x8, #0xe8]
0068B308C  ldr      x2, [x8]
0068B3090  ldrb     w8, [x2, #0x53]
0068B3094  tbnz     w8, #5, #0x68b30ac
0068B3098  add      x0, x19, #0x108
0068B309C  mov      x1, x20
0068B30A0  str      x20, [x19, #0x108]
0068B30A4  bl       #0x382bcb8 ; 
0068B30A8  b        #0x68b30bc ; 
0068B30AC  ldr      x8, [x2, #0x60]
0068B30B0  mov      x0, x19
0068B30B4  mov      x1, x20
0068B30B8  blr      x8
0068B30BC  mov      x0, x19
0068B30C0  mov      x1, xzr
0068B30C4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B30C8  adrp     x21, #0x959c000
0068B30CC  ldrb     w8, [x21, #0x5fb]
0068B30D0  mov      x20, x0
0068B30D4  cbnz     w8, #0x68b30ec
0068B30D8  adrp     x0, #0x8f27000
0068B30DC  ldr      x0, [x0, #0xf8]
0068B30E0  bl       #0x382bd14 ; 
0068B30E4  mov      w8, #1
0068B30E8  strb     w8, [x21, #0x5fb]
0068B30EC  adrp     x8, #0x8f27000
0068B30F0  ldr      x8, [x8, #0xf8]
0068B30F4  ldr      x2, [x8]
0068B30F8  ldrb     w8, [x2, #0x53]
0068B30FC  tbnz     w8, #5, #0x68b3114
0068B3100  add      x0, x19, #0x110
0068B3104  mov      x1, x20
0068B3108  str      x20, [x19, #0x110]
0068B310C  bl       #0x382bcb8 ; 
0068B3110  b        #0x68b3124 ; 
0068B3114  ldr      x8, [x2, #0x60]
0068B3118  mov      x0, x19
0068B311C  mov      x1, x20
0068B3120  blr      x8
0068B3124  mov      x0, x19
0068B3128  mov      x1, xzr
0068B312C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B3130  adrp     x21, #0x959c000
0068B3134  ldrb     w8, [x21, #0x5fc]
0068B3138  mov      x20, x0
0068B313C  cbnz     w8, #0x68b3154
0068B3140  adrp     x0, #0x8f27000
0068B3144  ldr      x0, [x0, #0x108]
0068B3148  bl       #0x382bd14 ; 
0068B314C  mov      w8, #1
0068B3150  strb     w8, [x21, #0x5fc]
0068B3154  adrp     x8, #0x8f27000
0068B3158  ldr      x8, [x8, #0x108]
0068B315C  ldr      x2, [x8]
0068B3160  ldrb     w8, [x2, #0x53]
0068B3164  tbnz     w8, #5, #0x68b317c
0068B3168  add      x0, x19, #0x118
0068B316C  mov      x1, x20
0068B3170  str      x20, [x19, #0x118]
0068B3174  bl       #0x382bcb8 ; 
0068B3178  b        #0x68b318c ; 
0068B317C  ldr      x8, [x2, #0x60]
0068B3180  mov      x0, x19
0068B3184  mov      x1, x20
0068B3188  blr      x8
0068B318C  mov      x0, x19
0068B3190  mov      x1, xzr
0068B3194  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B3198  adrp     x21, #0x959c000
0068B319C  ldrb     w8, [x21, #0x5fd]
0068B31A0  mov      x20, x0
0068B31A4  cbnz     w8, #0x68b31bc
0068B31A8  adrp     x0, #0x8f27000
0068B31AC  ldr      x0, [x0, #0x118]
0068B31B0  bl       #0x382bd14 ; 
0068B31B4  mov      w8, #1
0068B31B8  strb     w8, [x21, #0x5fd]
0068B31BC  adrp     x8, #0x8f27000
0068B31C0  ldr      x8, [x8, #0x118]
0068B31C4  ldr      x2, [x8]
0068B31C8  ldrb     w8, [x2, #0x53]
0068B31CC  tbnz     w8, #5, #0x68b31e4
0068B31D0  add      x0, x19, #0x120
0068B31D4  mov      x1, x20
0068B31D8  str      x20, [x19, #0x120]
0068B31DC  bl       #0x382bcb8 ; 
0068B31E0  b        #0x68b31f4 ; 
0068B31E4  ldr      x8, [x2, #0x60]
0068B31E8  mov      x0, x19
0068B31EC  mov      x1, x20
0068B31F0  blr      x8
0068B31F4  mov      x0, x19
0068B31F8  mov      x1, xzr
0068B31FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B3200  adrp     x21, #0x959c000
0068B3204  ldrb     w8, [x21, #0x5fe]
0068B3208  mov      w20, w0
0068B320C  cbnz     w8, #0x68b3224
0068B3210  adrp     x0, #0x8f27000
0068B3214  ldr      x0, [x0, #0x128]
0068B3218  bl       #0x382bd14 ; 
0068B321C  mov      w8, #1
0068B3220  strb     w8, [x21, #0x5fe]
0068B3224  adrp     x8, #0x8f27000
0068B3228  ldr      x8, [x8, #0x128]
0068B322C  ldr      x2, [x8]
0068B3230  ldrb     w8, [x2, #0x53]
0068B3234  tbnz     w8, #5, #0x68b3240
0068B3238  str      w20, [x19, #0x128]
0068B323C  b        #0x68b3250 ; 
0068B3240  ldr      x8, [x2, #0x60]
0068B3244  mov      x0, x19
0068B3248  mov      w1, w20
0068B324C  blr      x8
0068B3250  mov      x0, x19
0068B3254  mov      x1, xzr
0068B3258  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B325C  adrp     x21, #0x959c000
0068B3260  ldrb     w8, [x21, #0x5ff]
0068B3264  mov      x20, x0
0068B3268  cbnz     w8, #0x68b3280
0068B326C  adrp     x0, #0x8f27000
0068B3270  ldr      x0, [x0, #0x138]
0068B3274  bl       #0x382bd14 ; 
0068B3278  mov      w8, #1
0068B327C  strb     w8, [x21, #0x5ff]
0068B3280  adrp     x8, #0x8f27000
0068B3284  ldr      x8, [x8, #0x138]
0068B3288  ldr      x2, [x8]
0068B328C  ldrb     w8, [x2, #0x53]
0068B3290  tbnz     w8, #5, #0x68b32a8
0068B3294  add      x0, x19, #0x130
0068B3298  mov      x1, x20
0068B329C  str      x20, [x19, #0x130]
0068B32A0  bl       #0x382bcb8 ; 
0068B32A4  b        #0x68b32b8 ; 
0068B32A8  ldr      x8, [x2, #0x60]
0068B32AC  mov      x0, x19
0068B32B0  mov      x1, x20
0068B32B4  blr      x8
0068B32B8  mov      x0, x19
0068B32BC  mov      x1, xzr
0068B32C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B32C4  adrp     x21, #0x959c000
0068B32C8  ldrb     w8, [x21, #0x600]
0068B32CC  mov      w20, w0
0068B32D0  cbnz     w8, #0x68b32e8
0068B32D4  adrp     x0, #0x8f27000
0068B32D8  ldr      x0, [x0, #0x148]
0068B32DC  bl       #0x382bd14 ; 
0068B32E0  mov      w8, #1
0068B32E4  strb     w8, [x21, #0x600]
0068B32E8  adrp     x8, #0x8f27000
0068B32EC  ldr      x8, [x8, #0x148]
0068B32F0  ldr      x2, [x8]
0068B32F4  ldrb     w8, [x2, #0x53]
0068B32F8  tbnz     w8, #5, #0x68b3304
0068B32FC  str      w20, [x19, #0x138]
0068B3300  b        #0x68b3314 ; 
0068B3304  ldr      x8, [x2, #0x60]
0068B3308  mov      x0, x19
0068B330C  mov      w1, w20
0068B3310  blr      x8
0068B3314  ldp      x20, x19, [sp, #0x10]
0068B3318  mov      w0, #1
0068B331C  ldp      x30, x21, [sp], #0x20
0068B3320  ret      

