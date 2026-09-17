; LocalModels.Bean.IAP_DailyGift$$readImpl
; RVA 0x6AA24B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA24B0  stp      x30, x21, [sp, #-0x20]!
006AA24B4  stp      x20, x19, [sp, #0x10]
006AA24B8  adrp     x20, #0x959e000
006AA24BC  adrp     x21, #0x8f39000
006AA24C0  ldrb     w8, [x20, #0x2d3]
006AA24C4  ldr      x21, [x21, #0xc10]
006AA24C8  mov      x19, x0
006AA24CC  tbnz     w8, #0, #0x6aa24e4
006AA24D0  adrp     x0, #0x8f39000
006AA24D4  ldr      x0, [x0, #0xc10]
006AA24D8  bl       #0x382bd14 ; 
006AA24DC  mov      w8, #1
006AA24E0  strb     w8, [x20, #0x2d3]
006AA24E4  ldr      x1, [x21]
006AA24E8  ldrb     w8, [x1, #0x53]
006AA24EC  tbnz     w8, #5, #0x6aa253c
006AA24F0  mov      x0, x19
006AA24F4  mov      x1, xzr
006AA24F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA24FC  adrp     x21, #0x959e000
006AA2500  ldrb     w8, [x21, #0x668]
006AA2504  mov      w20, w0
006AA2508  cbnz     w8, #0x6aa2520
006AA250C  adrp     x0, #0x8f39000
006AA2510  ldr      x0, [x0, #0xaf8]
006AA2514  bl       #0x382bd14 ; 
006AA2518  mov      w8, #1
006AA251C  strb     w8, [x21, #0x668]
006AA2520  adrp     x8, #0x8f39000
006AA2524  ldr      x8, [x8, #0xaf8]
006AA2528  ldr      x2, [x8]
006AA252C  ldrb     w8, [x2, #0x53]
006AA2530  tbnz     w8, #5, #0x6aa2550
006AA2534  str      w20, [x19, #0x20]
006AA2538  b        #0x6aa2560 ; 
006AA253C  ldr      x2, [x1, #0x60]
006AA2540  mov      x0, x19
006AA2544  ldp      x20, x19, [sp, #0x10]
006AA2548  ldp      x30, x21, [sp], #0x20
006AA254C  br       x2
006AA2550  ldr      x8, [x2, #0x60]
006AA2554  mov      x0, x19
006AA2558  mov      w1, w20
006AA255C  blr      x8
006AA2560  mov      x0, x19
006AA2564  mov      x1, xzr
006AA2568  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA256C  adrp     x21, #0x959e000
006AA2570  ldrb     w8, [x21, #0x669]
006AA2574  mov      x20, x0
006AA2578  cbnz     w8, #0x6aa2590
006AA257C  adrp     x0, #0x8f39000
006AA2580  ldr      x0, [x0, #0xb08]
006AA2584  bl       #0x382bd14 ; 
006AA2588  mov      w8, #1
006AA258C  strb     w8, [x21, #0x669]
006AA2590  adrp     x8, #0x8f39000
006AA2594  ldr      x8, [x8, #0xb08]
006AA2598  ldr      x2, [x8]
006AA259C  ldrb     w8, [x2, #0x53]
006AA25A0  tbnz     w8, #5, #0x6aa25b8
006AA25A4  mov      x0, x19
006AA25A8  str      x20, [x0, #0x28]!
006AA25AC  mov      x1, x20
006AA25B0  bl       #0x382bcb8 ; 
006AA25B4  b        #0x6aa25c8 ; 
006AA25B8  ldr      x8, [x2, #0x60]
006AA25BC  mov      x0, x19
006AA25C0  mov      x1, x20
006AA25C4  blr      x8
006AA25C8  mov      x0, x19
006AA25CC  mov      x1, xzr
006AA25D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA25D4  adrp     x21, #0x959e000
006AA25D8  ldrb     w8, [x21, #0x66a]
006AA25DC  mov      w20, w0
006AA25E0  cbnz     w8, #0x6aa25f8
006AA25E4  adrp     x0, #0x8f39000
006AA25E8  ldr      x0, [x0, #0xb18]
006AA25EC  bl       #0x382bd14 ; 
006AA25F0  mov      w8, #1
006AA25F4  strb     w8, [x21, #0x66a]
006AA25F8  adrp     x8, #0x8f39000
006AA25FC  ldr      x8, [x8, #0xb18]
006AA2600  ldr      x2, [x8]
006AA2604  ldrb     w8, [x2, #0x53]
006AA2608  tbnz     w8, #5, #0x6aa2614
006AA260C  str      w20, [x19, #0x30]
006AA2610  b        #0x6aa2624 ; 
006AA2614  ldr      x8, [x2, #0x60]
006AA2618  mov      x0, x19
006AA261C  mov      w1, w20
006AA2620  blr      x8
006AA2624  mov      x0, x19
006AA2628  mov      x1, xzr
006AA262C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA2630  adrp     x21, #0x959e000
006AA2634  ldrb     w8, [x21, #0x66b]
006AA2638  mov      w20, w0
006AA263C  cbnz     w8, #0x6aa2654
006AA2640  adrp     x0, #0x8f39000
006AA2644  ldr      x0, [x0, #0xb28]
006AA2648  bl       #0x382bd14 ; 
006AA264C  mov      w8, #1
006AA2650  strb     w8, [x21, #0x66b]
006AA2654  adrp     x8, #0x8f39000
006AA2658  ldr      x8, [x8, #0xb28]
006AA265C  ldr      x2, [x8]
006AA2660  ldrb     w8, [x2, #0x53]
006AA2664  tbnz     w8, #5, #0x6aa2670
006AA2668  str      w20, [x19, #0x34]
006AA266C  b        #0x6aa2680 ; 
006AA2670  ldr      x8, [x2, #0x60]
006AA2674  mov      x0, x19
006AA2678  mov      w1, w20
006AA267C  blr      x8
006AA2680  mov      x0, x19
006AA2684  mov      x1, xzr
006AA2688  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA268C  adrp     x21, #0x959e000
006AA2690  ldrb     w8, [x21, #0x66c]
006AA2694  mov      w20, w0
006AA2698  cbnz     w8, #0x6aa26b0
006AA269C  adrp     x0, #0x8f39000
006AA26A0  ldr      x0, [x0, #0xb38]
006AA26A4  bl       #0x382bd14 ; 
006AA26A8  mov      w8, #1
006AA26AC  strb     w8, [x21, #0x66c]
006AA26B0  adrp     x8, #0x8f39000
006AA26B4  ldr      x8, [x8, #0xb38]
006AA26B8  ldr      x2, [x8]
006AA26BC  ldrb     w8, [x2, #0x53]
006AA26C0  tbnz     w8, #5, #0x6aa26cc
006AA26C4  str      w20, [x19, #0x38]
006AA26C8  b        #0x6aa26dc ; 
006AA26CC  ldr      x8, [x2, #0x60]
006AA26D0  mov      x0, x19
006AA26D4  mov      w1, w20
006AA26D8  blr      x8
006AA26DC  mov      x0, x19
006AA26E0  mov      x1, xzr
006AA26E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA26E8  adrp     x21, #0x959e000
006AA26EC  ldrb     w8, [x21, #0x66d]
006AA26F0  mov      w20, w0
006AA26F4  cbnz     w8, #0x6aa270c
006AA26F8  adrp     x0, #0x8f39000
006AA26FC  ldr      x0, [x0, #0xb48]
006AA2700  bl       #0x382bd14 ; 
006AA2704  mov      w8, #1
006AA2708  strb     w8, [x21, #0x66d]
006AA270C  adrp     x8, #0x8f39000
006AA2710  ldr      x8, [x8, #0xb48]
006AA2714  ldr      x2, [x8]
006AA2718  ldrb     w8, [x2, #0x53]
006AA271C  tbnz     w8, #5, #0x6aa2728
006AA2720  str      w20, [x19, #0x3c]
006AA2724  b        #0x6aa2738 ; 
006AA2728  ldr      x8, [x2, #0x60]
006AA272C  mov      x0, x19
006AA2730  mov      w1, w20
006AA2734  blr      x8
006AA2738  mov      x0, x19
006AA273C  mov      x1, xzr
006AA2740  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA2744  adrp     x21, #0x959e000
006AA2748  ldrb     w8, [x21, #0x66e]
006AA274C  mov      w20, w0
006AA2750  cbnz     w8, #0x6aa2768
006AA2754  adrp     x0, #0x8f39000
006AA2758  ldr      x0, [x0, #0xb58]
006AA275C  bl       #0x382bd14 ; 
006AA2760  mov      w8, #1
006AA2764  strb     w8, [x21, #0x66e]
006AA2768  adrp     x8, #0x8f39000
006AA276C  ldr      x8, [x8, #0xb58]
006AA2770  ldr      x2, [x8]
006AA2774  ldrb     w8, [x2, #0x53]
006AA2778  tbnz     w8, #5, #0x6aa2784
006AA277C  str      w20, [x19, #0x40]
006AA2780  b        #0x6aa2794 ; 
006AA2784  ldr      x8, [x2, #0x60]
006AA2788  mov      x0, x19
006AA278C  mov      w1, w20
006AA2790  blr      x8
006AA2794  mov      x0, x19
006AA2798  mov      x1, xzr
006AA279C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA27A0  adrp     x21, #0x959e000
006AA27A4  ldrb     w8, [x21, #0x66f]
006AA27A8  mov      x20, x0
006AA27AC  cbnz     w8, #0x6aa27c4
006AA27B0  adrp     x0, #0x8f39000
006AA27B4  ldr      x0, [x0, #0xb68]
006AA27B8  bl       #0x382bd14 ; 
006AA27BC  mov      w8, #1
006AA27C0  strb     w8, [x21, #0x66f]
006AA27C4  adrp     x8, #0x8f39000
006AA27C8  ldr      x8, [x8, #0xb68]
006AA27CC  ldr      x2, [x8]
006AA27D0  ldrb     w8, [x2, #0x53]
006AA27D4  tbnz     w8, #5, #0x6aa27ec
006AA27D8  mov      x0, x19
006AA27DC  str      x20, [x0, #0x48]!
006AA27E0  mov      x1, x20
006AA27E4  bl       #0x382bcb8 ; 
006AA27E8  b        #0x6aa27fc ; 
006AA27EC  ldr      x8, [x2, #0x60]
006AA27F0  mov      x0, x19
006AA27F4  mov      x1, x20
006AA27F8  blr      x8
006AA27FC  mov      x0, x19
006AA2800  mov      x1, xzr
006AA2804  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2808  adrp     x21, #0x959e000
006AA280C  ldrb     w8, [x21, #0x670]
006AA2810  mov      x20, x0
006AA2814  cbnz     w8, #0x6aa282c
006AA2818  adrp     x0, #0x8f39000
006AA281C  ldr      x0, [x0, #0xb78]
006AA2820  bl       #0x382bd14 ; 
006AA2824  mov      w8, #1
006AA2828  strb     w8, [x21, #0x670]
006AA282C  adrp     x8, #0x8f39000
006AA2830  ldr      x8, [x8, #0xb78]
006AA2834  ldr      x2, [x8]
006AA2838  ldrb     w8, [x2, #0x53]
006AA283C  tbnz     w8, #5, #0x6aa2854
006AA2840  mov      x0, x19
006AA2844  str      x20, [x0, #0x50]!
006AA2848  mov      x1, x20
006AA284C  bl       #0x382bcb8 ; 
006AA2850  b        #0x6aa2864 ; 
006AA2854  ldr      x8, [x2, #0x60]
006AA2858  mov      x0, x19
006AA285C  mov      x1, x20
006AA2860  blr      x8
006AA2864  mov      x0, x19
006AA2868  mov      x1, xzr
006AA286C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2870  adrp     x21, #0x959e000
006AA2874  ldrb     w8, [x21, #0x671]
006AA2878  mov      x20, x0
006AA287C  cbnz     w8, #0x6aa2894
006AA2880  adrp     x0, #0x8f39000
006AA2884  ldr      x0, [x0, #0xb88]
006AA2888  bl       #0x382bd14 ; 
006AA288C  mov      w8, #1
006AA2890  strb     w8, [x21, #0x671]
006AA2894  adrp     x8, #0x8f39000
006AA2898  ldr      x8, [x8, #0xb88]
006AA289C  ldr      x2, [x8]
006AA28A0  ldrb     w8, [x2, #0x53]
006AA28A4  tbnz     w8, #5, #0x6aa28bc
006AA28A8  mov      x0, x19
006AA28AC  str      x20, [x0, #0x58]!
006AA28B0  mov      x1, x20
006AA28B4  bl       #0x382bcb8 ; 
006AA28B8  b        #0x6aa28cc ; 
006AA28BC  ldr      x8, [x2, #0x60]
006AA28C0  mov      x0, x19
006AA28C4  mov      x1, x20
006AA28C8  blr      x8
006AA28CC  mov      x0, x19
006AA28D0  mov      x1, xzr
006AA28D4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA28D8  adrp     x21, #0x959e000
006AA28DC  ldrb     w8, [x21, #0x672]
006AA28E0  mov      x20, x0
006AA28E4  cbnz     w8, #0x6aa28fc
006AA28E8  adrp     x0, #0x8f39000
006AA28EC  ldr      x0, [x0, #0xb98]
006AA28F0  bl       #0x382bd14 ; 
006AA28F4  mov      w8, #1
006AA28F8  strb     w8, [x21, #0x672]
006AA28FC  adrp     x8, #0x8f39000
006AA2900  ldr      x8, [x8, #0xb98]
006AA2904  ldr      x2, [x8]
006AA2908  ldrb     w8, [x2, #0x53]
006AA290C  tbnz     w8, #5, #0x6aa2924
006AA2910  mov      x0, x19
006AA2914  str      x20, [x0, #0x60]!
006AA2918  mov      x1, x20
006AA291C  bl       #0x382bcb8 ; 
006AA2920  b        #0x6aa2934 ; 
006AA2924  ldr      x8, [x2, #0x60]
006AA2928  mov      x0, x19
006AA292C  mov      x1, x20
006AA2930  blr      x8
006AA2934  mov      x0, x19
006AA2938  mov      x1, xzr
006AA293C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2940  adrp     x21, #0x959e000
006AA2944  ldrb     w8, [x21, #0x673]
006AA2948  mov      x20, x0
006AA294C  cbnz     w8, #0x6aa2964
006AA2950  adrp     x0, #0x8f39000
006AA2954  ldr      x0, [x0, #0xba8]
006AA2958  bl       #0x382bd14 ; 
006AA295C  mov      w8, #1
006AA2960  strb     w8, [x21, #0x673]
006AA2964  adrp     x8, #0x8f39000
006AA2968  ldr      x8, [x8, #0xba8]
006AA296C  ldr      x2, [x8]
006AA2970  ldrb     w8, [x2, #0x53]
006AA2974  tbnz     w8, #5, #0x6aa298c
006AA2978  mov      x0, x19
006AA297C  str      x20, [x0, #0x68]!
006AA2980  mov      x1, x20
006AA2984  bl       #0x382bcb8 ; 
006AA2988  b        #0x6aa299c ; 
006AA298C  ldr      x8, [x2, #0x60]
006AA2990  mov      x0, x19
006AA2994  mov      x1, x20
006AA2998  blr      x8
006AA299C  mov      x0, x19
006AA29A0  mov      x1, xzr
006AA29A4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA29A8  adrp     x21, #0x959e000
006AA29AC  ldrb     w8, [x21, #0x674]
006AA29B0  mov      x20, x0
006AA29B4  cbnz     w8, #0x6aa29cc
006AA29B8  adrp     x0, #0x8f39000
006AA29BC  ldr      x0, [x0, #0xbb8]
006AA29C0  bl       #0x382bd14 ; 
006AA29C4  mov      w8, #1
006AA29C8  strb     w8, [x21, #0x674]
006AA29CC  adrp     x8, #0x8f39000
006AA29D0  ldr      x8, [x8, #0xbb8]
006AA29D4  ldr      x2, [x8]
006AA29D8  ldrb     w8, [x2, #0x53]
006AA29DC  tbnz     w8, #5, #0x6aa29f4
006AA29E0  mov      x0, x19
006AA29E4  str      x20, [x0, #0x70]!
006AA29E8  mov      x1, x20
006AA29EC  bl       #0x382bcb8 ; 
006AA29F0  b        #0x6aa2a04 ; 
006AA29F4  ldr      x8, [x2, #0x60]
006AA29F8  mov      x0, x19
006AA29FC  mov      x1, x20
006AA2A00  blr      x8
006AA2A04  mov      x0, x19
006AA2A08  mov      x1, xzr
006AA2A0C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2A10  adrp     x21, #0x959e000
006AA2A14  ldrb     w8, [x21, #0x675]
006AA2A18  mov      x20, x0
006AA2A1C  cbnz     w8, #0x6aa2a34
006AA2A20  adrp     x0, #0x8f39000
006AA2A24  ldr      x0, [x0, #0xbc8]
006AA2A28  bl       #0x382bd14 ; 
006AA2A2C  mov      w8, #1
006AA2A30  strb     w8, [x21, #0x675]
006AA2A34  adrp     x8, #0x8f39000
006AA2A38  ldr      x8, [x8, #0xbc8]
006AA2A3C  ldr      x2, [x8]
006AA2A40  ldrb     w8, [x2, #0x53]
006AA2A44  tbnz     w8, #5, #0x6aa2a5c
006AA2A48  mov      x0, x19
006AA2A4C  str      x20, [x0, #0x78]!
006AA2A50  mov      x1, x20
006AA2A54  bl       #0x382bcb8 ; 
006AA2A58  b        #0x6aa2a6c ; 
006AA2A5C  ldr      x8, [x2, #0x60]
006AA2A60  mov      x0, x19
006AA2A64  mov      x1, x20
006AA2A68  blr      x8
006AA2A6C  mov      x0, x19
006AA2A70  mov      x1, xzr
006AA2A74  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2A78  adrp     x21, #0x959e000
006AA2A7C  ldrb     w8, [x21, #0x676]
006AA2A80  mov      x20, x0
006AA2A84  cbnz     w8, #0x6aa2a9c
006AA2A88  adrp     x0, #0x8f39000
006AA2A8C  ldr      x0, [x0, #0xbd8]
006AA2A90  bl       #0x382bd14 ; 
006AA2A94  mov      w8, #1
006AA2A98  strb     w8, [x21, #0x676]
006AA2A9C  adrp     x8, #0x8f39000
006AA2AA0  ldr      x8, [x8, #0xbd8]
006AA2AA4  ldr      x2, [x8]
006AA2AA8  ldrb     w8, [x2, #0x53]
006AA2AAC  tbnz     w8, #5, #0x6aa2ac4
006AA2AB0  mov      x0, x19
006AA2AB4  str      x20, [x0, #0x80]!
006AA2AB8  mov      x1, x20
006AA2ABC  bl       #0x382bcb8 ; 
006AA2AC0  b        #0x6aa2ad4 ; 
006AA2AC4  ldr      x8, [x2, #0x60]
006AA2AC8  mov      x0, x19
006AA2ACC  mov      x1, x20
006AA2AD0  blr      x8
006AA2AD4  mov      x0, x19
006AA2AD8  mov      x1, xzr
006AA2ADC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2AE0  adrp     x21, #0x959e000
006AA2AE4  ldrb     w8, [x21, #0x677]
006AA2AE8  mov      x20, x0
006AA2AEC  cbnz     w8, #0x6aa2b04
006AA2AF0  adrp     x0, #0x8f39000
006AA2AF4  ldr      x0, [x0, #0xbe8]
006AA2AF8  bl       #0x382bd14 ; 
006AA2AFC  mov      w8, #1
006AA2B00  strb     w8, [x21, #0x677]
006AA2B04  adrp     x8, #0x8f39000
006AA2B08  ldr      x8, [x8, #0xbe8]
006AA2B0C  ldr      x2, [x8]
006AA2B10  ldrb     w8, [x2, #0x53]
006AA2B14  tbnz     w8, #5, #0x6aa2b2c
006AA2B18  mov      x0, x19
006AA2B1C  str      x20, [x0, #0x88]!
006AA2B20  mov      x1, x20
006AA2B24  bl       #0x382bcb8 ; 
006AA2B28  b        #0x6aa2b3c ; 
006AA2B2C  ldr      x8, [x2, #0x60]
006AA2B30  mov      x0, x19
006AA2B34  mov      x1, x20
006AA2B38  blr      x8
006AA2B3C  mov      x0, x19
006AA2B40  mov      x1, xzr
006AA2B44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2B48  adrp     x21, #0x959e000
006AA2B4C  ldrb     w8, [x21, #0x678]
006AA2B50  mov      x20, x0
006AA2B54  cbnz     w8, #0x6aa2b6c
006AA2B58  adrp     x0, #0x8f39000
006AA2B5C  ldr      x0, [x0, #0xbf8]
006AA2B60  bl       #0x382bd14 ; 
006AA2B64  mov      w8, #1
006AA2B68  strb     w8, [x21, #0x678]
006AA2B6C  adrp     x8, #0x8f39000
006AA2B70  ldr      x8, [x8, #0xbf8]
006AA2B74  ldr      x2, [x8]
006AA2B78  ldrb     w8, [x2, #0x53]
006AA2B7C  tbnz     w8, #5, #0x6aa2b94
006AA2B80  mov      x0, x19
006AA2B84  str      x20, [x0, #0x90]!
006AA2B88  mov      x1, x20
006AA2B8C  bl       #0x382bcb8 ; 
006AA2B90  b        #0x6aa2ba4 ; 
006AA2B94  ldr      x8, [x2, #0x60]
006AA2B98  mov      x0, x19
006AA2B9C  mov      x1, x20
006AA2BA0  blr      x8
006AA2BA4  mov      x0, x19
006AA2BA8  mov      x1, xzr
006AA2BAC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA2BB0  adrp     x21, #0x959e000
006AA2BB4  ldrb     w8, [x21, #0x679]
006AA2BB8  mov      x20, x0
006AA2BBC  cbnz     w8, #0x6aa2bd4
006AA2BC0  adrp     x0, #0x8f39000
006AA2BC4  ldr      x0, [x0, #0xc08]
006AA2BC8  bl       #0x382bd14 ; 
006AA2BCC  mov      w8, #1
006AA2BD0  strb     w8, [x21, #0x679]
006AA2BD4  adrp     x8, #0x8f39000
006AA2BD8  ldr      x8, [x8, #0xc08]
006AA2BDC  ldr      x2, [x8]
006AA2BE0  ldrb     w8, [x2, #0x53]
006AA2BE4  tbnz     w8, #5, #0x6aa2bfc
006AA2BE8  str      x20, [x19, #0x98]!
006AA2BEC  mov      x0, x19
006AA2BF0  mov      x1, x20
006AA2BF4  bl       #0x382bcb8 ; 
006AA2BF8  b        #0x6aa2c0c ; 
006AA2BFC  ldr      x8, [x2, #0x60]
006AA2C00  mov      x0, x19
006AA2C04  mov      x1, x20
006AA2C08  blr      x8
006AA2C0C  ldp      x20, x19, [sp, #0x10]
006AA2C10  mov      w0, #1
006AA2C14  ldp      x30, x21, [sp], #0x20
006AA2C18  ret      

