; LocalModels.Bean.Pilot_PilotConfig$$readImpl
; RVA 0x6AD2510; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD2510  str      d8, [sp, #-0x30]!
006AD2514  stp      x30, x21, [sp, #0x10]
006AD2518  stp      x20, x19, [sp, #0x20]
006AD251C  adrp     x20, #0x959e000
006AD2520  adrp     x21, #0x8f3b000
006AD2524  ldrb     w8, [x20, #0xb45]
006AD2528  ldr      x21, [x21, #0xf70]
006AD252C  mov      x19, x0
006AD2530  tbnz     w8, #0, #0x6ad2548
006AD2534  adrp     x0, #0x8f3b000
006AD2538  ldr      x0, [x0, #0xf70]
006AD253C  bl       #0x382bd14 ; 
006AD2540  mov      w8, #1
006AD2544  strb     w8, [x20, #0xb45]
006AD2548  ldr      x1, [x21]
006AD254C  ldrb     w8, [x1, #0x53]
006AD2550  tbnz     w8, #5, #0x6ad25ac
006AD2554  mov      x0, x19
006AD2558  mov      x1, xzr
006AD255C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD2560  adrp     x21, #0x959f000
006AD2564  ldrb     w8, [x21, #0xf6]
006AD2568  mov      x20, x0
006AD256C  cbnz     w8, #0x6ad2584
006AD2570  adrp     x0, #0x8f3b000
006AD2574  ldr      x0, [x0, #0xef8]
006AD2578  bl       #0x382bd14 ; 
006AD257C  mov      w8, #1
006AD2580  strb     w8, [x21, #0xf6]
006AD2584  adrp     x8, #0x8f3b000
006AD2588  ldr      x8, [x8, #0xef8]
006AD258C  ldr      x2, [x8]
006AD2590  ldrb     w8, [x2, #0x53]
006AD2594  tbnz     w8, #5, #0x6ad25c4
006AD2598  mov      x0, x19
006AD259C  str      x20, [x0, #0x20]!
006AD25A0  mov      x1, x20
006AD25A4  bl       #0x382bcb8 ; 
006AD25A8  b        #0x6ad25d4 ; 
006AD25AC  ldr      x2, [x1, #0x60]
006AD25B0  mov      x0, x19
006AD25B4  ldp      x20, x19, [sp, #0x20]
006AD25B8  ldp      x30, x21, [sp, #0x10]
006AD25BC  ldr      d8, [sp], #0x30
006AD25C0  br       x2
006AD25C4  ldr      x8, [x2, #0x60]
006AD25C8  mov      x0, x19
006AD25CC  mov      x1, x20
006AD25D0  blr      x8
006AD25D4  mov      x0, x19
006AD25D8  mov      x1, xzr
006AD25DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD25E0  adrp     x21, #0x959f000
006AD25E4  ldrb     w8, [x21, #0xf7]
006AD25E8  mov      x20, x0
006AD25EC  cbnz     w8, #0x6ad2604
006AD25F0  adrp     x0, #0x8f3b000
006AD25F4  ldr      x0, [x0, #0xf08]
006AD25F8  bl       #0x382bd14 ; 
006AD25FC  mov      w8, #1
006AD2600  strb     w8, [x21, #0xf7]
006AD2604  adrp     x8, #0x8f3b000
006AD2608  ldr      x8, [x8, #0xf08]
006AD260C  ldr      x2, [x8]
006AD2610  ldrb     w8, [x2, #0x53]
006AD2614  tbnz     w8, #5, #0x6ad262c
006AD2618  mov      x0, x19
006AD261C  str      x20, [x0, #0x28]!
006AD2620  mov      x1, x20
006AD2624  bl       #0x382bcb8 ; 
006AD2628  b        #0x6ad263c ; 
006AD262C  ldr      x8, [x2, #0x60]
006AD2630  mov      x0, x19
006AD2634  mov      x1, x20
006AD2638  blr      x8
006AD263C  mov      x0, x19
006AD2640  mov      x1, xzr
006AD2644  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD2648  adrp     x21, #0x959f000
006AD264C  ldrb     w8, [x21, #0xf8]
006AD2650  mov      w20, w0
006AD2654  cbnz     w8, #0x6ad266c
006AD2658  adrp     x0, #0x8f3b000
006AD265C  ldr      x0, [x0, #0xf18]
006AD2660  bl       #0x382bd14 ; 
006AD2664  mov      w8, #1
006AD2668  strb     w8, [x21, #0xf8]
006AD266C  adrp     x8, #0x8f3b000
006AD2670  ldr      x8, [x8, #0xf18]
006AD2674  ldr      x2, [x8]
006AD2678  ldrb     w8, [x2, #0x53]
006AD267C  tbnz     w8, #5, #0x6ad2688
006AD2680  str      w20, [x19, #0x30]
006AD2684  b        #0x6ad2698 ; 
006AD2688  ldr      x8, [x2, #0x60]
006AD268C  mov      x0, x19
006AD2690  mov      w1, w20
006AD2694  blr      x8
006AD2698  mov      x0, x19
006AD269C  mov      x1, xzr
006AD26A0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AD26A4  adrp     x21, #0x959f000
006AD26A8  ldrb     w8, [x21, #0xf9]
006AD26AC  mov      x20, x0
006AD26B0  cbnz     w8, #0x6ad26c8
006AD26B4  adrp     x0, #0x8f3b000
006AD26B8  ldr      x0, [x0, #0xf28]
006AD26BC  bl       #0x382bd14 ; 
006AD26C0  mov      w8, #1
006AD26C4  strb     w8, [x21, #0xf9]
006AD26C8  adrp     x8, #0x8f3b000
006AD26CC  ldr      x8, [x8, #0xf28]
006AD26D0  ldr      x2, [x8]
006AD26D4  ldrb     w8, [x2, #0x53]
006AD26D8  tbnz     w8, #5, #0x6ad26f0
006AD26DC  mov      x0, x19
006AD26E0  str      x20, [x0, #0x38]!
006AD26E4  mov      x1, x20
006AD26E8  bl       #0x382bcb8 ; 
006AD26EC  b        #0x6ad2700 ; 
006AD26F0  ldr      x8, [x2, #0x60]
006AD26F4  mov      x0, x19
006AD26F8  mov      x1, x20
006AD26FC  blr      x8
006AD2700  mov      x0, x19
006AD2704  mov      x1, xzr
006AD2708  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD270C  adrp     x21, #0x959f000
006AD2710  ldrb     w8, [x21, #0xfa]
006AD2714  mov      x20, x0
006AD2718  cbnz     w8, #0x6ad2730
006AD271C  adrp     x0, #0x8f3b000
006AD2720  ldr      x0, [x0, #0xf38]
006AD2724  bl       #0x382bd14 ; 
006AD2728  mov      w8, #1
006AD272C  strb     w8, [x21, #0xfa]
006AD2730  adrp     x8, #0x8f3b000
006AD2734  ldr      x8, [x8, #0xf38]
006AD2738  ldr      x2, [x8]
006AD273C  ldrb     w8, [x2, #0x53]
006AD2740  tbnz     w8, #5, #0x6ad2758
006AD2744  mov      x0, x19
006AD2748  str      x20, [x0, #0x40]!
006AD274C  mov      x1, x20
006AD2750  bl       #0x382bcb8 ; 
006AD2754  b        #0x6ad2768 ; 
006AD2758  ldr      x8, [x2, #0x60]
006AD275C  mov      x0, x19
006AD2760  mov      x1, x20
006AD2764  blr      x8
006AD2768  mov      x0, x19
006AD276C  mov      x1, xzr
006AD2770  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006AD2774  adrp     x20, #0x959f000
006AD2778  ldrb     w8, [x20, #0xfb]
006AD277C  mov      v8.16b, v0.16b
006AD2780  cbnz     w8, #0x6ad2798
006AD2784  adrp     x0, #0x8f3b000
006AD2788  ldr      x0, [x0, #0xf48]
006AD278C  bl       #0x382bd14 ; 
006AD2790  mov      w8, #1
006AD2794  strb     w8, [x20, #0xfb]
006AD2798  adrp     x8, #0x8f3b000
006AD279C  ldr      x8, [x8, #0xf48]
006AD27A0  ldr      x1, [x8]
006AD27A4  ldrb     w8, [x1, #0x53]
006AD27A8  tbnz     w8, #5, #0x6ad27b4
006AD27AC  str      s8, [x19, #0x48]
006AD27B0  b        #0x6ad27c4 ; 
006AD27B4  ldr      x8, [x1, #0x60]
006AD27B8  mov      x0, x19
006AD27BC  mov      v0.16b, v8.16b
006AD27C0  blr      x8
006AD27C4  mov      x0, x19
006AD27C8  mov      x1, xzr
006AD27CC  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
006AD27D0  adrp     x21, #0x959f000
006AD27D4  ldrb     w8, [x21, #0xfc]
006AD27D8  mov      x20, x0
006AD27DC  cbnz     w8, #0x6ad27f4
006AD27E0  adrp     x0, #0x8f3b000
006AD27E4  ldr      x0, [x0, #0xf58]
006AD27E8  bl       #0x382bd14 ; 
006AD27EC  mov      w8, #1
006AD27F0  strb     w8, [x21, #0xfc]
006AD27F4  adrp     x8, #0x8f3b000
006AD27F8  ldr      x8, [x8, #0xf58]
006AD27FC  ldr      x2, [x8]
006AD2800  ldrb     w8, [x2, #0x53]
006AD2804  tbnz     w8, #5, #0x6ad281c
006AD2808  mov      x0, x19
006AD280C  str      x20, [x0, #0x50]!
006AD2810  mov      x1, x20
006AD2814  bl       #0x382bcb8 ; 
006AD2818  b        #0x6ad282c ; 
006AD281C  ldr      x8, [x2, #0x60]
006AD2820  mov      x0, x19
006AD2824  mov      x1, x20
006AD2828  blr      x8
006AD282C  mov      x0, x19
006AD2830  mov      x1, xzr
006AD2834  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AD2838  adrp     x21, #0x959f000
006AD283C  ldrb     w8, [x21, #0xfd]
006AD2840  mov      x20, x0
006AD2844  cbnz     w8, #0x6ad285c
006AD2848  adrp     x0, #0x8f3b000
006AD284C  ldr      x0, [x0, #0xf68]
006AD2850  bl       #0x382bd14 ; 
006AD2854  mov      w8, #1
006AD2858  strb     w8, [x21, #0xfd]
006AD285C  adrp     x8, #0x8f3b000
006AD2860  ldr      x8, [x8, #0xf68]
006AD2864  ldr      x2, [x8]
006AD2868  ldrb     w8, [x2, #0x53]
006AD286C  tbnz     w8, #5, #0x6ad2884
006AD2870  str      x20, [x19, #0x58]!
006AD2874  mov      x0, x19
006AD2878  mov      x1, x20
006AD287C  bl       #0x382bcb8 ; 
006AD2880  b        #0x6ad2894 ; 
006AD2884  ldr      x8, [x2, #0x60]
006AD2888  mov      x0, x19
006AD288C  mov      x1, x20
006AD2890  blr      x8
006AD2894  ldp      x20, x19, [sp, #0x20]
006AD2898  ldp      x30, x21, [sp, #0x10]
006AD289C  mov      w0, #1
006AD28A0  ldr      d8, [sp], #0x30
006AD28A4  ret      

