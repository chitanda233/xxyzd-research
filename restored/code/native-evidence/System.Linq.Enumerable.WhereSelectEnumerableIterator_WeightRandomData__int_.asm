; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$.ctor
; RVA 0x5ABCD54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABCD54  str      x30, [sp, #-0x30]!
005ABCD58  stp      x22, x21, [sp, #0x10]
005ABCD5C  stp      x20, x19, [sp, #0x20]
005ABCD60  ldr      x8, [x4, #0x20]
005ABCD64  mov      x21, x1
005ABCD68  mov      x19, x3
005ABCD6C  mov      x20, x2
005ABCD70  ldr      x8, [x8, #0xc0]
005ABCD74  mov      x22, x0
005ABCD78  ldr      x1, [x8]
005ABCD7C  bl       #0x4a743d4 ; System.Linq.Enumerable.Iterator<int>$$.ctor
005ABCD80  mov      x0, x22
005ABCD84  str      x21, [x0, #0x20]!
005ABCD88  mov      x1, x21
005ABCD8C  bl       #0x382bcb8 ; 
005ABCD90  mov      x0, x22
005ABCD94  str      x20, [x0, #0x28]!
005ABCD98  mov      x1, x20
005ABCD9C  bl       #0x382bcb8 ; 
005ABCDA0  str      x19, [x22, #0x30]!
005ABCDA4  mov      x0, x22
005ABCDA8  mov      x1, x19
005ABCDAC  ldp      x20, x19, [sp, #0x20]
005ABCDB0  ldp      x22, x21, [sp, #0x10]
005ABCDB4  ldr      x30, [sp], #0x30
005ABCDB8  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$Clone
; RVA 0x5ABCDBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABCDBC  str      x30, [sp, #-0x30]!
005ABCDC0  stp      x22, x21, [sp, #0x10]
005ABCDC4  stp      x20, x19, [sp, #0x20]
005ABCDC8  ldr      x9, [x1, #0x20]
005ABCDCC  mov      x8, x0
005ABCDD0  ldp      x21, x20, [x8, #0x20]
005ABCDD4  ldr      x22, [x8, #0x30]
005ABCDD8  ldr      x9, [x9, #0xc0]
005ABCDDC  mov      x19, x1
005ABCDE0  ldr      x0, [x9, #0x18]
005ABCDE4  ldrb     w9, [x0, #0x135]
005ABCDE8  tbnz     w9, #0, #0x5abcdf0
005ABCDEC  bl       #0x3a7e60c ; 
005ABCDF0  bl       #0x382bfa0 ; 
005ABCDF4  ldr      x8, [x19, #0x20]
005ABCDF8  mov      x1, x21
005ABCDFC  mov      x2, x20
005ABCE00  mov      x3, x22
005ABCE04  ldr      x8, [x8, #0xc0]
005ABCE08  mov      x19, x0
005ABCE0C  ldr      x4, [x8, #0x30]
005ABCE10  bl       #0x5abcd54 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$.ctor
005ABCE14  mov      x0, x19
005ABCE18  ldp      x20, x19, [sp, #0x20]
005ABCE1C  ldp      x22, x21, [sp, #0x10]
005ABCE20  ldr      x30, [sp], #0x30
005ABCE24  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$Dispose
; RVA 0x5ABCE28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABCE28  str      x30, [sp, #-0x30]!
005ABCE2C  stp      x22, x21, [sp, #0x10]
005ABCE30  stp      x20, x19, [sp, #0x20]
005ABCE34  adrp     x21, #0x9595000
005ABCE38  ldrb     w8, [x21, #0x457]
005ABCE3C  mov      x19, x1
005ABCE40  mov      x20, x0
005ABCE44  tbnz     w8, #0, #0x5abce5c
005ABCE48  adrp     x0, #0x8ebf000
005ABCE4C  ldr      x0, [x0, #0x4e8]
005ABCE50  bl       #0x382bd14 ; 
005ABCE54  mov      w8, #1
005ABCE58  strb     w8, [x21, #0x457]
005ABCE5C  mov      x21, x20
005ABCE60  ldr      x22, [x21, #0x38]!
005ABCE64  cbz      x22, #0x5abcec8
005ABCE68  adrp     x10, #0x8ebf000
005ABCE6C  ldr      x8, [x22]
005ABCE70  ldr      x10, [x10, #0x4e8]
005ABCE74  ldrh     w9, [x8, #0x12e]
005ABCE78  ldr      x1, [x10]
005ABCE7C  cbz      x9, #0x5abcea0
005ABCE80  ldr      x10, [x8, #0xb0]
005ABCE84  add      x10, x10, #8
005ABCE88  ldur     x11, [x10, #-8]
005ABCE8C  cmp      x11, x1
005ABCE90  b.eq     #0x5abceb0
005ABCE94  subs     x9, x9, #1
005ABCE98  add      x10, x10, #0x10
005ABCE9C  b.ne     #0x5abce88
005ABCEA0  mov      x0, x22
005ABCEA4  mov      w2, wzr
005ABCEA8  bl       #0x3a7e710 ; 
005ABCEAC  b        #0x5abcebc ; 
005ABCEB0  ldrsw    x9, [x10]
005ABCEB4  add      x8, x8, x9, lsl #4
005ABCEB8  add      x0, x8, #0x138
005ABCEBC  ldp      x8, x1, [x0]
005ABCEC0  mov      x0, x22
005ABCEC4  blr      x8
005ABCEC8  mov      x0, x21
005ABCECC  mov      x1, xzr
005ABCED0  str      xzr, [x20, #0x38]
005ABCED4  bl       #0x382bcb8 ; 
005ABCED8  ldr      x8, [x19, #0x20]
005ABCEDC  mov      x0, x20
005ABCEE0  ldp      x20, x19, [sp, #0x20]
005ABCEE4  ldp      x22, x21, [sp, #0x10]
005ABCEE8  ldr      x8, [x8, #0xc0]
005ABCEEC  ldr      x1, [x8, #0x48]
005ABCEF0  ldr      x30, [sp], #0x30
005ABCEF4  b        #0x4a74410 ; System.Linq.Enumerable.Iterator<int>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$MoveNext
; RVA 0x5ABCEF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABCEF8  sub      sp, sp, #0xf0
005ABCEFC  str      x30, [sp, #0xc0]
005ABCF00  stp      x22, x21, [sp, #0xd0]
005ABCF04  stp      x20, x19, [sp, #0xe0]
005ABCF08  adrp     x21, #0x9595000
005ABCF0C  ldrb     w8, [x21, #0x458]
005ABCF10  mov      x20, x1
005ABCF14  mov      x19, x0
005ABCF18  tbnz     w8, #0, #0x5abcf30
005ABCF1C  adrp     x0, #0x8ebf000
005ABCF20  ldr      x0, [x0, #0x4f0]
005ABCF24  bl       #0x382bd14 ; 
005ABCF28  mov      w8, #1
005ABCF2C  strb     w8, [x21, #0x458]
005ABCF30  ldr      w8, [x19, #0x14]
005ABCF34  adrp     x22, #0x8ebf000
005ABCF38  ldr      x22, [x22, #0x4f0]
005ABCF3C  cmp      w8, #2
005ABCF40  b.eq     #0x5abcfe4
005ABCF44  cmp      w8, #1
005ABCF48  b.ne     #0x5abd184
005ABCF4C  ldr      x21, [x19, #0x20]
005ABCF50  cbz      x21, #0x5abd19c
005ABCF54  ldr      x8, [x20, #0x20]
005ABCF58  ldr      x8, [x8, #0xc0]
005ABCF5C  ldr      x1, [x8, #0x10]
005ABCF60  ldrb     w8, [x1, #0x135]
005ABCF64  tbnz     w8, #0, #0x5abcf74
005ABCF68  mov      x0, x1
005ABCF6C  bl       #0x3a7e60c ; 
005ABCF70  mov      x1, x0
005ABCF74  ldr      x8, [x21]
005ABCF78  ldrh     w9, [x8, #0x12e]
005ABCF7C  cbz      x9, #0x5abcfa0
005ABCF80  ldr      x10, [x8, #0xb0]
005ABCF84  add      x10, x10, #8
005ABCF88  ldur     x11, [x10, #-8]
005ABCF8C  cmp      x11, x1
005ABCF90  b.eq     #0x5abcfb0
005ABCF94  subs     x9, x9, #1
005ABCF98  add      x10, x10, #0x10
005ABCF9C  b.ne     #0x5abcf88
005ABCFA0  mov      x0, x21
005ABCFA4  mov      w2, wzr
005ABCFA8  bl       #0x3a7e710 ; 
005ABCFAC  b        #0x5abcfbc ; 
005ABCFB0  ldrsw    x9, [x10]
005ABCFB4  add      x8, x8, x9, lsl #4
005ABCFB8  add      x0, x8, #0x138
005ABCFBC  ldp      x8, x1, [x0]
005ABCFC0  mov      x0, x21
005ABCFC4  blr      x8
005ABCFC8  mov      x21, x19
005ABCFCC  str      x0, [x21, #0x38]!
005ABCFD0  mov      x1, x0
005ABCFD4  mov      x0, x21
005ABCFD8  bl       #0x382bcb8 ; 
005ABCFDC  mov      w8, #2
005ABCFE0  stur     w8, [x21, #-0x24]
005ABCFE4  ldr      x21, [x19, #0x38]
005ABCFE8  cbz      x21, #0x5abd19c
005ABCFEC  ldr      x8, [x21]
005ABCFF0  ldr      x1, [x22]
005ABCFF4  ldrh     w9, [x8, #0x12e]
005ABCFF8  cbz      x9, #0x5abd01c
005ABCFFC  ldr      x10, [x8, #0xb0]
005ABD000  add      x10, x10, #8
005ABD004  ldur     x11, [x10, #-8]
005ABD008  cmp      x11, x1
005ABD00C  b.eq     #0x5abd02c
005ABD010  subs     x9, x9, #1
005ABD014  add      x10, x10, #0x10
005ABD018  b.ne     #0x5abd004
005ABD01C  mov      x0, x21
005ABD020  mov      w2, wzr
005ABD024  bl       #0x3a7e710 ; 
005ABD028  b        #0x5abd038 ; 
005ABD02C  ldrsw    x9, [x10]
005ABD030  add      x8, x8, x9, lsl #4
005ABD034  add      x0, x8, #0x138
005ABD038  ldp      x8, x1, [x0]
005ABD03C  mov      x0, x21
005ABD040  blr      x8
005ABD044  tbz      w0, #0, #0x5abd170
005ABD048  ldr      x21, [x19, #0x38]
005ABD04C  cbz      x21, #0x5abd19c
005ABD050  ldr      x8, [x20, #0x20]
005ABD054  ldr      x8, [x8, #0xc0]
005ABD058  ldr      x1, [x8, #0x40]
005ABD05C  ldrb     w8, [x1, #0x135]
005ABD060  tbnz     w8, #0, #0x5abd070
005ABD064  mov      x0, x1
005ABD068  bl       #0x3a7e60c ; 
005ABD06C  mov      x1, x0
005ABD070  ldr      x8, [x21]
005ABD074  ldrh     w9, [x8, #0x12e]
005ABD078  cbz      x9, #0x5abd09c
005ABD07C  ldr      x10, [x8, #0xb0]
005ABD080  add      x10, x10, #8
005ABD084  ldur     x11, [x10, #-8]
005ABD088  cmp      x11, x1
005ABD08C  b.eq     #0x5abd0ac
005ABD090  subs     x9, x9, #1
005ABD094  add      x10, x10, #0x10
005ABD098  b.ne     #0x5abd084
005ABD09C  mov      x0, x21
005ABD0A0  mov      w2, wzr
005ABD0A4  bl       #0x3a7e710 ; 
005ABD0A8  b        #0x5abd0b8 ; 
005ABD0AC  ldrsw    x9, [x10]
005ABD0B0  add      x8, x8, x9, lsl #4
005ABD0B4  add      x0, x8, #0x138
005ABD0B8  ldp      x9, x1, [x0]
005ABD0BC  add      x8, sp, #0x80
005ABD0C0  mov      x0, x21
005ABD0C4  blr      x9
005ABD0C8  ldp      q0, q1, [sp, #0x80]
005ABD0CC  ldr      q2, [sp, #0xa0]
005ABD0D0  ldr      x8, [sp, #0xb0]
005ABD0D4  stp      q0, q1, [sp, #0x40]
005ABD0D8  str      q2, [sp, #0x60]
005ABD0DC  str      x8, [sp, #0x70]
005ABD0E0  ldr      x8, [x19, #0x28]
005ABD0E4  cbz      x8, #0x5abd118
005ABD0E8  ldp      q0, q1, [sp, #0x40]
005ABD0EC  ldr      q2, [sp, #0x60]
005ABD0F0  ldr      x10, [sp, #0x70]
005ABD0F4  ldr      x9, [x8, #0x18]
005ABD0F8  ldr      x0, [x8, #0x40]
005ABD0FC  stp      q0, q1, [sp, #0x80]
005ABD100  str      q2, [sp, #0xa0]
005ABD104  str      x10, [sp, #0xb0]
005ABD108  ldr      x2, [x8, #0x28]
005ABD10C  add      x1, sp, #0x80
005ABD110  blr      x9
005ABD114  tbz      w0, #0, #0x5abcfe4
005ABD118  ldr      x8, [x19, #0x30]
005ABD11C  ldp      q0, q1, [sp, #0x40]
005ABD120  ldr      q2, [sp, #0x60]
005ABD124  ldr      x9, [sp, #0x70]
005ABD128  stp      q0, q1, [sp]
005ABD12C  str      q2, [sp, #0x20]
005ABD130  str      x9, [sp, #0x30]
005ABD134  cbz      x8, #0x5abd19c
005ABD138  ldp      q0, q1, [sp]
005ABD13C  ldr      q2, [sp, #0x20]
005ABD140  ldr      x10, [sp, #0x30]
005ABD144  ldr      x9, [x8, #0x18]
005ABD148  ldr      x0, [x8, #0x40]
005ABD14C  stp      q0, q1, [sp, #0x80]
005ABD150  str      q2, [sp, #0xa0]
005ABD154  str      x10, [sp, #0xb0]
005ABD158  ldr      x2, [x8, #0x28]
005ABD15C  add      x1, sp, #0x80
005ABD160  blr      x9
005ABD164  str      w0, [x19, #0x18]
005ABD168  mov      w0, #1
005ABD16C  b        #0x5abd188 ; 
005ABD170  cbz      x19, #0x5abd19c
005ABD174  ldr      x8, [x19]
005ABD178  mov      x0, x19
005ABD17C  ldp      x9, x1, [x8, #0x1f8]
005ABD180  blr      x9
005ABD184  mov      w0, wzr
005ABD188  ldp      x20, x19, [sp, #0xe0]
005ABD18C  ldp      x22, x21, [sp, #0xd0]
005ABD190  ldr      x30, [sp, #0xc0]
005ABD194  add      sp, sp, #0xf0
005ABD198  ret      
005ABD19C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$Select<int>
; RVA 0x44A26D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A26D8  stp      x30, x23, [sp, #-0x30]!
0044A26DC  stp      x22, x21, [sp, #0x10]
0044A26E0  stp      x20, x19, [sp, #0x20]
0044A26E4  ldr      x8, [x2, #0x38]
0044A26E8  mov      x19, x2
0044A26EC  mov      x22, x1
0044A26F0  mov      x23, x0
0044A26F4  cbnz     x8, #0x44a2704
0044A26F8  mov      x0, x19
0044A26FC  bl       #0x3a7e668 ; 
0044A2700  ldr      x8, [x19, #0x38]
0044A2704  ldr      x0, [x23, #0x30]
0044A2708  ldr      x2, [x8, #8]
0044A270C  ldp      x20, x21, [x23, #0x20]
0044A2710  mov      x1, x22
0044A2714  bl       #0x45a06fc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, int>
0044A2718  ldr      x8, [x19, #0x38]
0044A271C  mov      x22, x0
0044A2720  ldr      x8, [x8, #0x18]
0044A2724  ldrb     w9, [x8, #0x135]
0044A2728  tbnz     w9, #0, #0x44a2738
0044A272C  mov      x0, x8
0044A2730  bl       #0x3a7e60c ; 
0044A2734  mov      x8, x0
0044A2738  mov      x0, x8
0044A273C  bl       #0x382bfa0 ; 
0044A2740  ldr      x8, [x19, #0x38]
0044A2744  mov      x1, x20
0044A2748  mov      x2, x21
0044A274C  mov      x3, x22
0044A2750  ldr      x4, [x8, #0x20]
0044A2754  mov      x19, x0
0044A2758  bl       #0x5abcd54 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$.ctor
0044A275C  mov      x0, x19
0044A2760  ldp      x20, x19, [sp, #0x20]
0044A2764  ldp      x22, x21, [sp, #0x10]
0044A2768  ldp      x30, x23, [sp], #0x30
0044A276C  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$Select<Int32Enum>
; RVA 0x44A2770; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2770  stp      x30, x23, [sp, #-0x30]!
0044A2774  stp      x22, x21, [sp, #0x10]
0044A2778  stp      x20, x19, [sp, #0x20]
0044A277C  ldr      x8, [x2, #0x38]
0044A2780  mov      x19, x2
0044A2784  mov      x22, x1
0044A2788  mov      x23, x0
0044A278C  cbnz     x8, #0x44a279c
0044A2790  mov      x0, x19
0044A2794  bl       #0x3a7e668 ; 
0044A2798  ldr      x8, [x19, #0x38]
0044A279C  ldr      x0, [x23, #0x30]
0044A27A0  ldr      x2, [x8, #8]
0044A27A4  ldp      x20, x21, [x23, #0x20]
0044A27A8  mov      x1, x22
0044A27AC  bl       #0x45a07b8 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, Int32Enum>
0044A27B0  ldr      x8, [x19, #0x38]
0044A27B4  mov      x22, x0
0044A27B8  ldr      x8, [x8, #0x18]
0044A27BC  ldrb     w9, [x8, #0x135]
0044A27C0  tbnz     w9, #0, #0x44a27d0
0044A27C4  mov      x0, x8
0044A27C8  bl       #0x3a7e60c ; 
0044A27CC  mov      x8, x0
0044A27D0  mov      x0, x8
0044A27D4  bl       #0x382bfa0 ; 
0044A27D8  ldr      x8, [x19, #0x38]
0044A27DC  mov      x1, x20
0044A27E0  mov      x2, x21
0044A27E4  mov      x3, x22
0044A27E8  ldr      x4, [x8, #0x20]
0044A27EC  mov      x19, x0
0044A27F0  bl       #0x5abd208 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$.ctor
0044A27F4  mov      x0, x19
0044A27F8  ldp      x20, x19, [sp, #0x20]
0044A27FC  ldp      x22, x21, [sp, #0x10]
0044A2800  ldp      x30, x23, [sp], #0x30
0044A2804  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$Select<object>
; RVA 0x44A2808; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2808  stp      x30, x23, [sp, #-0x30]!
0044A280C  stp      x22, x21, [sp, #0x10]
0044A2810  stp      x20, x19, [sp, #0x20]
0044A2814  ldr      x8, [x2, #0x38]
0044A2818  mov      x19, x2
0044A281C  mov      x22, x1
0044A2820  mov      x23, x0
0044A2824  cbnz     x8, #0x44a2834
0044A2828  mov      x0, x19
0044A282C  bl       #0x3a7e668 ; 
0044A2830  ldr      x8, [x19, #0x38]
0044A2834  ldr      x0, [x23, #0x30]
0044A2838  ldr      x2, [x8, #8]
0044A283C  ldp      x20, x21, [x23, #0x20]
0044A2840  mov      x1, x22
0044A2844  bl       #0x45a0874 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, object>
0044A2848  ldr      x8, [x19, #0x38]
0044A284C  mov      x22, x0
0044A2850  ldr      x8, [x8, #0x18]
0044A2854  ldrb     w9, [x8, #0x135]
0044A2858  tbnz     w9, #0, #0x44a2868
0044A285C  mov      x0, x8
0044A2860  bl       #0x3a7e60c ; 
0044A2864  mov      x8, x0
0044A2868  mov      x0, x8
0044A286C  bl       #0x382bfa0 ; 
0044A2870  ldr      x8, [x19, #0x38]
0044A2874  mov      x1, x20
0044A2878  mov      x2, x21
0044A287C  mov      x3, x22
0044A2880  ldr      x4, [x8, #0x20]
0044A2884  mov      x19, x0
0044A2888  bl       #0x5abdb70 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$.ctor
0044A288C  mov      x0, x19
0044A2890  ldp      x20, x19, [sp, #0x20]
0044A2894  ldp      x22, x21, [sp, #0x10]
0044A2898  ldp      x30, x23, [sp], #0x30
0044A289C  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$Where
; RVA 0x5ABD1A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD1A0  stp      x30, x21, [sp, #-0x20]!
005ABD1A4  stp      x20, x19, [sp, #0x10]
005ABD1A8  ldr      x8, [x2, #0x20]
005ABD1AC  mov      x20, x2
005ABD1B0  mov      x19, x1
005ABD1B4  mov      x21, x0
005ABD1B8  ldr      x8, [x8, #0xc0]
005ABD1BC  ldr      x8, [x8, #0x88]
005ABD1C0  ldrb     w9, [x8, #0x135]
005ABD1C4  tbnz     w9, #0, #0x5abd1d4
005ABD1C8  mov      x0, x8
005ABD1CC  bl       #0x3a7e60c ; 
005ABD1D0  mov      x8, x0
005ABD1D4  mov      x0, x8
005ABD1D8  bl       #0x382bfa0 ; 
005ABD1DC  ldr      x8, [x20, #0x20]
005ABD1E0  mov      x1, x21
005ABD1E4  mov      x2, x19
005ABD1E8  mov      x20, x0
005ABD1EC  ldr      x8, [x8, #0xc0]
005ABD1F0  ldr      x3, [x8, #0x90]
005ABD1F4  bl       #0x59c9e80 ; System.Linq.Enumerable.WhereEnumerableIterator<int>$$.ctor
005ABD1F8  mov      x0, x20
005ABD1FC  ldp      x20, x19, [sp, #0x10]
005ABD200  ldp      x30, x21, [sp], #0x20
005ABD204  ret      

