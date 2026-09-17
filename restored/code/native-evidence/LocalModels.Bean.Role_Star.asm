; LocalModels.Bean.Role_Star$$readImpl
; RVA 0x6AE27E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE27E4  stp      x30, x21, [sp, #-0x20]!
006AE27E8  stp      x20, x19, [sp, #0x10]
006AE27EC  adrp     x20, #0x959e000
006AE27F0  adrp     x21, #0x8f3c000
006AE27F4  ldrb     w8, [x20, #0xcef]
006AE27F8  ldr      x21, [x21, #0xb68]
006AE27FC  mov      x19, x0
006AE2800  tbnz     w8, #0, #0x6ae2818
006AE2804  adrp     x0, #0x8f3c000
006AE2808  ldr      x0, [x0, #0xb68]
006AE280C  bl       #0x382bd14 ; 
006AE2810  mov      w8, #1
006AE2814  strb     w8, [x20, #0xcef]
006AE2818  ldr      x1, [x21]
006AE281C  ldrb     w8, [x1, #0x53]
006AE2820  tbnz     w8, #5, #0x6ae2870
006AE2824  mov      x0, x19
006AE2828  mov      x1, xzr
006AE282C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE2830  adrp     x21, #0x959f000
006AE2834  ldrb     w8, [x21, #0x1a7]
006AE2838  mov      w20, w0
006AE283C  cbnz     w8, #0x6ae2854
006AE2840  adrp     x0, #0x8f3c000
006AE2844  ldr      x0, [x0, #0xae8]
006AE2848  bl       #0x382bd14 ; 
006AE284C  mov      w8, #1
006AE2850  strb     w8, [x21, #0x1a7]
006AE2854  adrp     x8, #0x8f3c000
006AE2858  ldr      x8, [x8, #0xae8]
006AE285C  ldr      x2, [x8]
006AE2860  ldrb     w8, [x2, #0x53]
006AE2864  tbnz     w8, #5, #0x6ae2884
006AE2868  str      w20, [x19, #0x20]
006AE286C  b        #0x6ae2894 ; 
006AE2870  ldr      x2, [x1, #0x60]
006AE2874  mov      x0, x19
006AE2878  ldp      x20, x19, [sp, #0x10]
006AE287C  ldp      x30, x21, [sp], #0x20
006AE2880  br       x2
006AE2884  ldr      x8, [x2, #0x60]
006AE2888  mov      x0, x19
006AE288C  mov      w1, w20
006AE2890  blr      x8
006AE2894  mov      x0, x19
006AE2898  mov      x1, xzr
006AE289C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE28A0  adrp     x21, #0x959f000
006AE28A4  ldrb     w8, [x21, #0x1a8]
006AE28A8  mov      w20, w0
006AE28AC  cbnz     w8, #0x6ae28c4
006AE28B0  adrp     x0, #0x8f3c000
006AE28B4  ldr      x0, [x0, #0xaf8]
006AE28B8  bl       #0x382bd14 ; 
006AE28BC  mov      w8, #1
006AE28C0  strb     w8, [x21, #0x1a8]
006AE28C4  adrp     x8, #0x8f3c000
006AE28C8  ldr      x8, [x8, #0xaf8]
006AE28CC  ldr      x2, [x8]
006AE28D0  ldrb     w8, [x2, #0x53]
006AE28D4  tbnz     w8, #5, #0x6ae28e0
006AE28D8  str      w20, [x19, #0x24]
006AE28DC  b        #0x6ae28f0 ; 
006AE28E0  ldr      x8, [x2, #0x60]
006AE28E4  mov      x0, x19
006AE28E8  mov      w1, w20
006AE28EC  blr      x8
006AE28F0  mov      x0, x19
006AE28F4  mov      x1, xzr
006AE28F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE28FC  adrp     x21, #0x959f000
006AE2900  ldrb     w8, [x21, #0x1a9]
006AE2904  mov      w20, w0
006AE2908  cbnz     w8, #0x6ae2920
006AE290C  adrp     x0, #0x8f3c000
006AE2910  ldr      x0, [x0, #0xb08]
006AE2914  bl       #0x382bd14 ; 
006AE2918  mov      w8, #1
006AE291C  strb     w8, [x21, #0x1a9]
006AE2920  adrp     x8, #0x8f3c000
006AE2924  ldr      x8, [x8, #0xb08]
006AE2928  ldr      x2, [x8]
006AE292C  ldrb     w8, [x2, #0x53]
006AE2930  tbnz     w8, #5, #0x6ae293c
006AE2934  str      w20, [x19, #0x28]
006AE2938  b        #0x6ae294c ; 
006AE293C  ldr      x8, [x2, #0x60]
006AE2940  mov      x0, x19
006AE2944  mov      w1, w20
006AE2948  blr      x8
006AE294C  mov      x0, x19
006AE2950  mov      x1, xzr
006AE2954  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE2958  adrp     x21, #0x959f000
006AE295C  ldrb     w8, [x21, #0x1aa]
006AE2960  mov      w20, w0
006AE2964  cbnz     w8, #0x6ae297c
006AE2968  adrp     x0, #0x8f3c000
006AE296C  ldr      x0, [x0, #0xb10]
006AE2970  bl       #0x382bd14 ; 
006AE2974  mov      w8, #1
006AE2978  strb     w8, [x21, #0x1aa]
006AE297C  adrp     x8, #0x8f3c000
006AE2980  ldr      x8, [x8, #0xb10]
006AE2984  ldr      x2, [x8]
006AE2988  ldrb     w8, [x2, #0x53]
006AE298C  tbnz     w8, #5, #0x6ae2998
006AE2990  str      w20, [x19, #0x2c]
006AE2994  b        #0x6ae29a8 ; 
006AE2998  ldr      x8, [x2, #0x60]
006AE299C  mov      x0, x19
006AE29A0  mov      w1, w20
006AE29A4  blr      x8
006AE29A8  mov      x0, x19
006AE29AC  mov      x1, xzr
006AE29B0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AE29B4  adrp     x21, #0x959f000
006AE29B8  ldrb     w8, [x21, #0x1ab]
006AE29BC  mov      x20, x0
006AE29C0  cbnz     w8, #0x6ae29d8
006AE29C4  adrp     x0, #0x8f3c000
006AE29C8  ldr      x0, [x0, #0xb20]
006AE29CC  bl       #0x382bd14 ; 
006AE29D0  mov      w8, #1
006AE29D4  strb     w8, [x21, #0x1ab]
006AE29D8  adrp     x8, #0x8f3c000
006AE29DC  ldr      x8, [x8, #0xb20]
006AE29E0  ldr      x2, [x8]
006AE29E4  ldrb     w8, [x2, #0x53]
006AE29E8  tbnz     w8, #5, #0x6ae2a00
006AE29EC  mov      x0, x19
006AE29F0  str      x20, [x0, #0x30]!
006AE29F4  mov      x1, x20
006AE29F8  bl       #0x382bcb8 ; 
006AE29FC  b        #0x6ae2a10 ; 
006AE2A00  ldr      x8, [x2, #0x60]
006AE2A04  mov      x0, x19
006AE2A08  mov      x1, x20
006AE2A0C  blr      x8
006AE2A10  mov      x0, x19
006AE2A14  mov      x1, xzr
006AE2A18  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE2A1C  adrp     x21, #0x959f000
006AE2A20  ldrb     w8, [x21, #0x1ac]
006AE2A24  mov      x20, x0
006AE2A28  cbnz     w8, #0x6ae2a40
006AE2A2C  adrp     x0, #0x8f3c000
006AE2A30  ldr      x0, [x0, #0xb28]
006AE2A34  bl       #0x382bd14 ; 
006AE2A38  mov      w8, #1
006AE2A3C  strb     w8, [x21, #0x1ac]
006AE2A40  adrp     x8, #0x8f3c000
006AE2A44  ldr      x8, [x8, #0xb28]
006AE2A48  ldr      x2, [x8]
006AE2A4C  ldrb     w8, [x2, #0x53]
006AE2A50  tbnz     w8, #5, #0x6ae2a68
006AE2A54  mov      x0, x19
006AE2A58  str      x20, [x0, #0x38]!
006AE2A5C  mov      x1, x20
006AE2A60  bl       #0x382bcb8 ; 
006AE2A64  b        #0x6ae2a78 ; 
006AE2A68  ldr      x8, [x2, #0x60]
006AE2A6C  mov      x0, x19
006AE2A70  mov      x1, x20
006AE2A74  blr      x8
006AE2A78  mov      x0, x19
006AE2A7C  mov      x1, xzr
006AE2A80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE2A84  adrp     x21, #0x959f000
006AE2A88  ldrb     w8, [x21, #0x1ad]
006AE2A8C  mov      w20, w0
006AE2A90  cbnz     w8, #0x6ae2aa8
006AE2A94  adrp     x0, #0x8f3c000
006AE2A98  ldr      x0, [x0, #0xb38]
006AE2A9C  bl       #0x382bd14 ; 
006AE2AA0  mov      w8, #1
006AE2AA4  strb     w8, [x21, #0x1ad]
006AE2AA8  adrp     x8, #0x8f3c000
006AE2AAC  ldr      x8, [x8, #0xb38]
006AE2AB0  ldr      x2, [x8]
006AE2AB4  ldrb     w8, [x2, #0x53]
006AE2AB8  tbnz     w8, #5, #0x6ae2ac4
006AE2ABC  str      w20, [x19, #0x40]
006AE2AC0  b        #0x6ae2ad4 ; 
006AE2AC4  ldr      x8, [x2, #0x60]
006AE2AC8  mov      x0, x19
006AE2ACC  mov      w1, w20
006AE2AD0  blr      x8
006AE2AD4  mov      x0, x19
006AE2AD8  mov      x1, xzr
006AE2ADC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE2AE0  adrp     x21, #0x959f000
006AE2AE4  ldrb     w8, [x21, #0x1ae]
006AE2AE8  mov      x20, x0
006AE2AEC  cbnz     w8, #0x6ae2b04
006AE2AF0  adrp     x0, #0x8f3c000
006AE2AF4  ldr      x0, [x0, #0xb40]
006AE2AF8  bl       #0x382bd14 ; 
006AE2AFC  mov      w8, #1
006AE2B00  strb     w8, [x21, #0x1ae]
006AE2B04  adrp     x8, #0x8f3c000
006AE2B08  ldr      x8, [x8, #0xb40]
006AE2B0C  ldr      x2, [x8]
006AE2B10  ldrb     w8, [x2, #0x53]
006AE2B14  tbnz     w8, #5, #0x6ae2b2c
006AE2B18  mov      x0, x19
006AE2B1C  str      x20, [x0, #0x48]!
006AE2B20  mov      x1, x20
006AE2B24  bl       #0x382bcb8 ; 
006AE2B28  b        #0x6ae2b3c ; 
006AE2B2C  ldr      x8, [x2, #0x60]
006AE2B30  mov      x0, x19
006AE2B34  mov      x1, x20
006AE2B38  blr      x8
006AE2B3C  mov      x0, x19
006AE2B40  mov      x1, xzr
006AE2B44  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AE2B48  adrp     x21, #0x959f000
006AE2B4C  ldrb     w8, [x21, #0x1af]
006AE2B50  mov      x20, x0
006AE2B54  cbnz     w8, #0x6ae2b6c
006AE2B58  adrp     x0, #0x8f3c000
006AE2B5C  ldr      x0, [x0, #0xb50]
006AE2B60  bl       #0x382bd14 ; 
006AE2B64  mov      w8, #1
006AE2B68  strb     w8, [x21, #0x1af]
006AE2B6C  adrp     x8, #0x8f3c000
006AE2B70  ldr      x8, [x8, #0xb50]
006AE2B74  ldr      x2, [x8]
006AE2B78  ldrb     w8, [x2, #0x53]
006AE2B7C  tbnz     w8, #5, #0x6ae2b94
006AE2B80  mov      x0, x19
006AE2B84  str      x20, [x0, #0x50]!
006AE2B88  mov      x1, x20
006AE2B8C  bl       #0x382bcb8 ; 
006AE2B90  b        #0x6ae2ba4 ; 
006AE2B94  ldr      x8, [x2, #0x60]
006AE2B98  mov      x0, x19
006AE2B9C  mov      x1, x20
006AE2BA0  blr      x8
006AE2BA4  mov      x0, x19
006AE2BA8  mov      x1, xzr
006AE2BAC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE2BB0  adrp     x21, #0x959f000
006AE2BB4  ldrb     w8, [x21, #0x1b0]
006AE2BB8  mov      x20, x0
006AE2BBC  cbnz     w8, #0x6ae2bd4
006AE2BC0  adrp     x0, #0x8f3c000
006AE2BC4  ldr      x0, [x0, #0xb58]
006AE2BC8  bl       #0x382bd14 ; 
006AE2BCC  mov      w8, #1
006AE2BD0  strb     w8, [x21, #0x1b0]
006AE2BD4  adrp     x8, #0x8f3c000
006AE2BD8  ldr      x8, [x8, #0xb58]
006AE2BDC  ldr      x2, [x8]
006AE2BE0  ldrb     w8, [x2, #0x53]
006AE2BE4  tbnz     w8, #5, #0x6ae2bfc
006AE2BE8  mov      x0, x19
006AE2BEC  str      x20, [x0, #0x58]!
006AE2BF0  mov      x1, x20
006AE2BF4  bl       #0x382bcb8 ; 
006AE2BF8  b        #0x6ae2c0c ; 
006AE2BFC  ldr      x8, [x2, #0x60]
006AE2C00  mov      x0, x19
006AE2C04  mov      x1, x20
006AE2C08  blr      x8
006AE2C0C  mov      x0, x19
006AE2C10  mov      x1, xzr
006AE2C14  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE2C18  adrp     x21, #0x959f000
006AE2C1C  ldrb     w8, [x21, #0x1b1]
006AE2C20  mov      x20, x0
006AE2C24  cbnz     w8, #0x6ae2c3c
006AE2C28  adrp     x0, #0x8f3c000
006AE2C2C  ldr      x0, [x0, #0xb60]
006AE2C30  bl       #0x382bd14 ; 
006AE2C34  mov      w8, #1
006AE2C38  strb     w8, [x21, #0x1b1]
006AE2C3C  adrp     x8, #0x8f3c000
006AE2C40  ldr      x8, [x8, #0xb60]
006AE2C44  ldr      x2, [x8]
006AE2C48  ldrb     w8, [x2, #0x53]
006AE2C4C  tbnz     w8, #5, #0x6ae2c64
006AE2C50  str      x20, [x19, #0x60]!
006AE2C54  mov      x0, x19
006AE2C58  mov      x1, x20
006AE2C5C  bl       #0x382bcb8 ; 
006AE2C60  b        #0x6ae2c74 ; 
006AE2C64  ldr      x8, [x2, #0x60]
006AE2C68  mov      x0, x19
006AE2C6C  mov      x1, x20
006AE2C70  blr      x8
006AE2C74  ldp      x20, x19, [sp, #0x10]
006AE2C78  mov      w0, #1
006AE2C7C  ldp      x30, x21, [sp], #0x20
006AE2C80  ret      

