; LocalModels.Bean.Rank_RankConstant$$readImpl
; RVA 0x6AD7504; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD7504  str      d8, [sp, #-0x30]!
006AD7508  stp      x30, x21, [sp, #0x10]
006AD750C  stp      x20, x19, [sp, #0x20]
006AD7510  adrp     x20, #0x959e000
006AD7514  adrp     x21, #0x8f3c000
006AD7518  ldrb     w8, [x20, #0xbcb]
006AD751C  ldr      x21, [x21, #0x350]
006AD7520  mov      x19, x0
006AD7524  tbnz     w8, #0, #0x6ad753c
006AD7528  adrp     x0, #0x8f3c000
006AD752C  ldr      x0, [x0, #0x350]
006AD7530  bl       #0x382bd14 ; 
006AD7534  mov      w8, #1
006AD7538  strb     w8, [x20, #0xbcb]
006AD753C  ldr      x1, [x21]
006AD7540  ldrb     w8, [x1, #0x53]
006AD7544  tbnz     w8, #5, #0x6ad75a0
006AD7548  mov      x0, x19
006AD754C  mov      x1, xzr
006AD7550  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD7554  adrp     x21, #0x959f000
006AD7558  ldrb     w8, [x21, #0x12a]
006AD755C  mov      x20, x0
006AD7560  cbnz     w8, #0x6ad7578
006AD7564  adrp     x0, #0x8f3c000
006AD7568  ldr      x0, [x0, #0x2d8]
006AD756C  bl       #0x382bd14 ; 
006AD7570  mov      w8, #1
006AD7574  strb     w8, [x21, #0x12a]
006AD7578  adrp     x8, #0x8f3c000
006AD757C  ldr      x8, [x8, #0x2d8]
006AD7580  ldr      x2, [x8]
006AD7584  ldrb     w8, [x2, #0x53]
006AD7588  tbnz     w8, #5, #0x6ad75b8
006AD758C  mov      x0, x19
006AD7590  str      x20, [x0, #0x20]!
006AD7594  mov      x1, x20
006AD7598  bl       #0x382bcb8 ; 
006AD759C  b        #0x6ad75c8 ; 
006AD75A0  ldr      x2, [x1, #0x60]
006AD75A4  mov      x0, x19
006AD75A8  ldp      x20, x19, [sp, #0x20]
006AD75AC  ldp      x30, x21, [sp, #0x10]
006AD75B0  ldr      d8, [sp], #0x30
006AD75B4  br       x2
006AD75B8  ldr      x8, [x2, #0x60]
006AD75BC  mov      x0, x19
006AD75C0  mov      x1, x20
006AD75C4  blr      x8
006AD75C8  mov      x0, x19
006AD75CC  mov      x1, xzr
006AD75D0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD75D4  adrp     x21, #0x959f000
006AD75D8  ldrb     w8, [x21, #0x12b]
006AD75DC  mov      x20, x0
006AD75E0  cbnz     w8, #0x6ad75f8
006AD75E4  adrp     x0, #0x8f3c000
006AD75E8  ldr      x0, [x0, #0x2e8]
006AD75EC  bl       #0x382bd14 ; 
006AD75F0  mov      w8, #1
006AD75F4  strb     w8, [x21, #0x12b]
006AD75F8  adrp     x8, #0x8f3c000
006AD75FC  ldr      x8, [x8, #0x2e8]
006AD7600  ldr      x2, [x8]
006AD7604  ldrb     w8, [x2, #0x53]
006AD7608  tbnz     w8, #5, #0x6ad7620
006AD760C  mov      x0, x19
006AD7610  str      x20, [x0, #0x28]!
006AD7614  mov      x1, x20
006AD7618  bl       #0x382bcb8 ; 
006AD761C  b        #0x6ad7630 ; 
006AD7620  ldr      x8, [x2, #0x60]
006AD7624  mov      x0, x19
006AD7628  mov      x1, x20
006AD762C  blr      x8
006AD7630  mov      x0, x19
006AD7634  mov      x1, xzr
006AD7638  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD763C  adrp     x21, #0x959f000
006AD7640  ldrb     w8, [x21, #0x12c]
006AD7644  mov      w20, w0
006AD7648  cbnz     w8, #0x6ad7660
006AD764C  adrp     x0, #0x8f3c000
006AD7650  ldr      x0, [x0, #0x2f8]
006AD7654  bl       #0x382bd14 ; 
006AD7658  mov      w8, #1
006AD765C  strb     w8, [x21, #0x12c]
006AD7660  adrp     x8, #0x8f3c000
006AD7664  ldr      x8, [x8, #0x2f8]
006AD7668  ldr      x2, [x8]
006AD766C  ldrb     w8, [x2, #0x53]
006AD7670  tbnz     w8, #5, #0x6ad767c
006AD7674  str      w20, [x19, #0x30]
006AD7678  b        #0x6ad768c ; 
006AD767C  ldr      x8, [x2, #0x60]
006AD7680  mov      x0, x19
006AD7684  mov      w1, w20
006AD7688  blr      x8
006AD768C  mov      x0, x19
006AD7690  mov      x1, xzr
006AD7694  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AD7698  adrp     x21, #0x959f000
006AD769C  ldrb     w8, [x21, #0x12d]
006AD76A0  mov      x20, x0
006AD76A4  cbnz     w8, #0x6ad76bc
006AD76A8  adrp     x0, #0x8f3c000
006AD76AC  ldr      x0, [x0, #0x308]
006AD76B0  bl       #0x382bd14 ; 
006AD76B4  mov      w8, #1
006AD76B8  strb     w8, [x21, #0x12d]
006AD76BC  adrp     x8, #0x8f3c000
006AD76C0  ldr      x8, [x8, #0x308]
006AD76C4  ldr      x2, [x8]
006AD76C8  ldrb     w8, [x2, #0x53]
006AD76CC  tbnz     w8, #5, #0x6ad76e4
006AD76D0  mov      x0, x19
006AD76D4  str      x20, [x0, #0x38]!
006AD76D8  mov      x1, x20
006AD76DC  bl       #0x382bcb8 ; 
006AD76E0  b        #0x6ad76f4 ; 
006AD76E4  ldr      x8, [x2, #0x60]
006AD76E8  mov      x0, x19
006AD76EC  mov      x1, x20
006AD76F0  blr      x8
006AD76F4  mov      x0, x19
006AD76F8  mov      x1, xzr
006AD76FC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD7700  adrp     x21, #0x959f000
006AD7704  ldrb     w8, [x21, #0x12e]
006AD7708  mov      x20, x0
006AD770C  cbnz     w8, #0x6ad7724
006AD7710  adrp     x0, #0x8f3c000
006AD7714  ldr      x0, [x0, #0x318]
006AD7718  bl       #0x382bd14 ; 
006AD771C  mov      w8, #1
006AD7720  strb     w8, [x21, #0x12e]
006AD7724  adrp     x8, #0x8f3c000
006AD7728  ldr      x8, [x8, #0x318]
006AD772C  ldr      x2, [x8]
006AD7730  ldrb     w8, [x2, #0x53]
006AD7734  tbnz     w8, #5, #0x6ad774c
006AD7738  mov      x0, x19
006AD773C  str      x20, [x0, #0x40]!
006AD7740  mov      x1, x20
006AD7744  bl       #0x382bcb8 ; 
006AD7748  b        #0x6ad775c ; 
006AD774C  ldr      x8, [x2, #0x60]
006AD7750  mov      x0, x19
006AD7754  mov      x1, x20
006AD7758  blr      x8
006AD775C  mov      x0, x19
006AD7760  mov      x1, xzr
006AD7764  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006AD7768  adrp     x20, #0x959f000
006AD776C  ldrb     w8, [x20, #0x12f]
006AD7770  mov      v8.16b, v0.16b
006AD7774  cbnz     w8, #0x6ad778c
006AD7778  adrp     x0, #0x8f3c000
006AD777C  ldr      x0, [x0, #0x328]
006AD7780  bl       #0x382bd14 ; 
006AD7784  mov      w8, #1
006AD7788  strb     w8, [x20, #0x12f]
006AD778C  adrp     x8, #0x8f3c000
006AD7790  ldr      x8, [x8, #0x328]
006AD7794  ldr      x1, [x8]
006AD7798  ldrb     w8, [x1, #0x53]
006AD779C  tbnz     w8, #5, #0x6ad77a8
006AD77A0  str      s8, [x19, #0x48]
006AD77A4  b        #0x6ad77b8 ; 
006AD77A8  ldr      x8, [x1, #0x60]
006AD77AC  mov      x0, x19
006AD77B0  mov      v0.16b, v8.16b
006AD77B4  blr      x8
006AD77B8  mov      x0, x19
006AD77BC  mov      x1, xzr
006AD77C0  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
006AD77C4  adrp     x21, #0x959f000
006AD77C8  ldrb     w8, [x21, #0x130]
006AD77CC  mov      x20, x0
006AD77D0  cbnz     w8, #0x6ad77e8
006AD77D4  adrp     x0, #0x8f3c000
006AD77D8  ldr      x0, [x0, #0x338]
006AD77DC  bl       #0x382bd14 ; 
006AD77E0  mov      w8, #1
006AD77E4  strb     w8, [x21, #0x130]
006AD77E8  adrp     x8, #0x8f3c000
006AD77EC  ldr      x8, [x8, #0x338]
006AD77F0  ldr      x2, [x8]
006AD77F4  ldrb     w8, [x2, #0x53]
006AD77F8  tbnz     w8, #5, #0x6ad7810
006AD77FC  mov      x0, x19
006AD7800  str      x20, [x0, #0x50]!
006AD7804  mov      x1, x20
006AD7808  bl       #0x382bcb8 ; 
006AD780C  b        #0x6ad7820 ; 
006AD7810  ldr      x8, [x2, #0x60]
006AD7814  mov      x0, x19
006AD7818  mov      x1, x20
006AD781C  blr      x8
006AD7820  mov      x0, x19
006AD7824  mov      x1, xzr
006AD7828  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AD782C  adrp     x21, #0x959f000
006AD7830  ldrb     w8, [x21, #0x131]
006AD7834  mov      x20, x0
006AD7838  cbnz     w8, #0x6ad7850
006AD783C  adrp     x0, #0x8f3c000
006AD7840  ldr      x0, [x0, #0x348]
006AD7844  bl       #0x382bd14 ; 
006AD7848  mov      w8, #1
006AD784C  strb     w8, [x21, #0x131]
006AD7850  adrp     x8, #0x8f3c000
006AD7854  ldr      x8, [x8, #0x348]
006AD7858  ldr      x2, [x8]
006AD785C  ldrb     w8, [x2, #0x53]
006AD7860  tbnz     w8, #5, #0x6ad7878
006AD7864  str      x20, [x19, #0x58]!
006AD7868  mov      x0, x19
006AD786C  mov      x1, x20
006AD7870  bl       #0x382bcb8 ; 
006AD7874  b        #0x6ad7888 ; 
006AD7878  ldr      x8, [x2, #0x60]
006AD787C  mov      x0, x19
006AD7880  mov      x1, x20
006AD7884  blr      x8
006AD7888  ldp      x20, x19, [sp, #0x20]
006AD788C  ldp      x30, x21, [sp, #0x10]
006AD7890  mov      w0, #1
006AD7894  ldr      d8, [sp], #0x30
006AD7898  ret      

