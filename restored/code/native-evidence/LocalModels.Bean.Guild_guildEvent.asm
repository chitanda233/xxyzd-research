; LocalModels.Bean.Guild_guildEvent$$readImpl
; RVA 0x6A90FB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A90FB0  stp      x30, x21, [sp, #-0x20]!
006A90FB4  stp      x20, x19, [sp, #0x10]
006A90FB8  adrp     x20, #0x959e000
006A90FBC  adrp     x21, #0x8f38000
006A90FC0  ldrb     w8, [x20, #0x102]
006A90FC4  ldr      x21, [x21, #0xe50]
006A90FC8  mov      x19, x0
006A90FCC  tbnz     w8, #0, #0x6a90fe4
006A90FD0  adrp     x0, #0x8f38000
006A90FD4  ldr      x0, [x0, #0xe50]
006A90FD8  bl       #0x382bd14 ; 
006A90FDC  mov      w8, #1
006A90FE0  strb     w8, [x20, #0x102]
006A90FE4  ldr      x1, [x21]
006A90FE8  ldrb     w8, [x1, #0x53]
006A90FEC  tbnz     w8, #5, #0x6a9103c
006A90FF0  mov      x0, x19
006A90FF4  mov      x1, xzr
006A90FF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A90FFC  adrp     x21, #0x959e000
006A91000  ldrb     w8, [x21, #0x5ae]
006A91004  mov      w20, w0
006A91008  cbnz     w8, #0x6a91020
006A9100C  adrp     x0, #0x8f38000
006A91010  ldr      x0, [x0, #0xdf8]
006A91014  bl       #0x382bd14 ; 
006A91018  mov      w8, #1
006A9101C  strb     w8, [x21, #0x5ae]
006A91020  adrp     x8, #0x8f38000
006A91024  ldr      x8, [x8, #0xdf8]
006A91028  ldr      x2, [x8]
006A9102C  ldrb     w8, [x2, #0x53]
006A91030  tbnz     w8, #5, #0x6a91050
006A91034  str      w20, [x19, #0x20]
006A91038  b        #0x6a91060 ; 
006A9103C  ldr      x2, [x1, #0x60]
006A91040  mov      x0, x19
006A91044  ldp      x20, x19, [sp, #0x10]
006A91048  ldp      x30, x21, [sp], #0x20
006A9104C  br       x2
006A91050  ldr      x8, [x2, #0x60]
006A91054  mov      x0, x19
006A91058  mov      w1, w20
006A9105C  blr      x8
006A91060  mov      x0, x19
006A91064  mov      x1, xzr
006A91068  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9106C  adrp     x21, #0x959e000
006A91070  ldrb     w8, [x21, #0x5af]
006A91074  mov      w20, w0
006A91078  cbnz     w8, #0x6a91090
006A9107C  adrp     x0, #0x8f38000
006A91080  ldr      x0, [x0, #0xe08]
006A91084  bl       #0x382bd14 ; 
006A91088  mov      w8, #1
006A9108C  strb     w8, [x21, #0x5af]
006A91090  adrp     x8, #0x8f38000
006A91094  ldr      x8, [x8, #0xe08]
006A91098  ldr      x2, [x8]
006A9109C  ldrb     w8, [x2, #0x53]
006A910A0  tbnz     w8, #5, #0x6a910ac
006A910A4  str      w20, [x19, #0x24]
006A910A8  b        #0x6a910bc ; 
006A910AC  ldr      x8, [x2, #0x60]
006A910B0  mov      x0, x19
006A910B4  mov      w1, w20
006A910B8  blr      x8
006A910BC  mov      x0, x19
006A910C0  mov      x1, xzr
006A910C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A910C8  adrp     x21, #0x959e000
006A910CC  ldrb     w8, [x21, #0x5b0]
006A910D0  mov      w20, w0
006A910D4  cbnz     w8, #0x6a910ec
006A910D8  adrp     x0, #0x8f38000
006A910DC  ldr      x0, [x0, #0xe18]
006A910E0  bl       #0x382bd14 ; 
006A910E4  mov      w8, #1
006A910E8  strb     w8, [x21, #0x5b0]
006A910EC  adrp     x8, #0x8f38000
006A910F0  ldr      x8, [x8, #0xe18]
006A910F4  ldr      x2, [x8]
006A910F8  ldrb     w8, [x2, #0x53]
006A910FC  tbnz     w8, #5, #0x6a91108
006A91100  str      w20, [x19, #0x28]
006A91104  b        #0x6a91118 ; 
006A91108  ldr      x8, [x2, #0x60]
006A9110C  mov      x0, x19
006A91110  mov      w1, w20
006A91114  blr      x8
006A91118  mov      x0, x19
006A9111C  mov      x1, xzr
006A91120  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A91124  adrp     x21, #0x959e000
006A91128  ldrb     w8, [x21, #0x5b1]
006A9112C  mov      x20, x0
006A91130  cbnz     w8, #0x6a91148
006A91134  adrp     x0, #0x8f38000
006A91138  ldr      x0, [x0, #0xe28]
006A9113C  bl       #0x382bd14 ; 
006A91140  mov      w8, #1
006A91144  strb     w8, [x21, #0x5b1]
006A91148  adrp     x8, #0x8f38000
006A9114C  ldr      x8, [x8, #0xe28]
006A91150  ldr      x2, [x8]
006A91154  ldrb     w8, [x2, #0x53]
006A91158  tbnz     w8, #5, #0x6a91170
006A9115C  mov      x0, x19
006A91160  str      x20, [x0, #0x30]!
006A91164  mov      x1, x20
006A91168  bl       #0x382bcb8 ; 
006A9116C  b        #0x6a91180 ; 
006A91170  ldr      x8, [x2, #0x60]
006A91174  mov      x0, x19
006A91178  mov      x1, x20
006A9117C  blr      x8
006A91180  mov      x0, x19
006A91184  mov      x1, xzr
006A91188  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A9118C  adrp     x21, #0x959e000
006A91190  ldrb     w8, [x21, #0x5b2]
006A91194  mov      x20, x0
006A91198  cbnz     w8, #0x6a911b0
006A9119C  adrp     x0, #0x8f38000
006A911A0  ldr      x0, [x0, #0xe38]
006A911A4  bl       #0x382bd14 ; 
006A911A8  mov      w8, #1
006A911AC  strb     w8, [x21, #0x5b2]
006A911B0  adrp     x8, #0x8f38000
006A911B4  ldr      x8, [x8, #0xe38]
006A911B8  ldr      x2, [x8]
006A911BC  ldrb     w8, [x2, #0x53]
006A911C0  tbnz     w8, #5, #0x6a911d8
006A911C4  mov      x0, x19
006A911C8  str      x20, [x0, #0x38]!
006A911CC  mov      x1, x20
006A911D0  bl       #0x382bcb8 ; 
006A911D4  b        #0x6a911e8 ; 
006A911D8  ldr      x8, [x2, #0x60]
006A911DC  mov      x0, x19
006A911E0  mov      x1, x20
006A911E4  blr      x8
006A911E8  mov      x0, x19
006A911EC  mov      x1, xzr
006A911F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A911F4  adrp     x21, #0x959e000
006A911F8  ldrb     w8, [x21, #0x5b3]
006A911FC  mov      w20, w0
006A91200  cbnz     w8, #0x6a91218
006A91204  adrp     x0, #0x8f38000
006A91208  ldr      x0, [x0, #0xe48]
006A9120C  bl       #0x382bd14 ; 
006A91210  mov      w8, #1
006A91214  strb     w8, [x21, #0x5b3]
006A91218  adrp     x8, #0x8f38000
006A9121C  ldr      x8, [x8, #0xe48]
006A91220  ldr      x2, [x8]
006A91224  ldrb     w8, [x2, #0x53]
006A91228  tbnz     w8, #5, #0x6a91234
006A9122C  str      w20, [x19, #0x40]
006A91230  b        #0x6a91244 ; 
006A91234  ldr      x8, [x2, #0x60]
006A91238  mov      x0, x19
006A9123C  mov      w1, w20
006A91240  blr      x8
006A91244  ldp      x20, x19, [sp, #0x10]
006A91248  mov      w0, #1
006A9124C  ldp      x30, x21, [sp], #0x20
006A91250  ret      

