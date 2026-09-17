; LocalModels.Bean.Rank_ChapterRankReward$$readImpl
; RVA 0x6AD60E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD60E0  stp      x30, x21, [sp, #-0x20]!
006AD60E4  stp      x20, x19, [sp, #0x10]
006AD60E8  adrp     x20, #0x959e000
006AD60EC  adrp     x21, #0x8f3c000
006AD60F0  ldrb     w8, [x20, #0xba6]
006AD60F4  ldr      x21, [x21, #0x240]
006AD60F8  mov      x19, x0
006AD60FC  tbnz     w8, #0, #0x6ad6114
006AD6100  adrp     x0, #0x8f3c000
006AD6104  ldr      x0, [x0, #0x240]
006AD6108  bl       #0x382bd14 ; 
006AD610C  mov      w8, #1
006AD6110  strb     w8, [x20, #0xba6]
006AD6114  ldr      x1, [x21]
006AD6118  ldrb     w8, [x1, #0x53]
006AD611C  tbnz     w8, #5, #0x6ad616c
006AD6120  mov      x0, x19
006AD6124  mov      x1, xzr
006AD6128  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD612C  adrp     x21, #0x959f000
006AD6130  ldrb     w8, [x21, #0x121]
006AD6134  mov      w20, w0
006AD6138  cbnz     w8, #0x6ad6150
006AD613C  adrp     x0, #0x8f3c000
006AD6140  ldr      x0, [x0, #0x218]
006AD6144  bl       #0x382bd14 ; 
006AD6148  mov      w8, #1
006AD614C  strb     w8, [x21, #0x121]
006AD6150  adrp     x8, #0x8f3c000
006AD6154  ldr      x8, [x8, #0x218]
006AD6158  ldr      x2, [x8]
006AD615C  ldrb     w8, [x2, #0x53]
006AD6160  tbnz     w8, #5, #0x6ad6180
006AD6164  str      w20, [x19, #0x20]
006AD6168  b        #0x6ad6190 ; 
006AD616C  ldr      x2, [x1, #0x60]
006AD6170  mov      x0, x19
006AD6174  ldp      x20, x19, [sp, #0x10]
006AD6178  ldp      x30, x21, [sp], #0x20
006AD617C  br       x2
006AD6180  ldr      x8, [x2, #0x60]
006AD6184  mov      x0, x19
006AD6188  mov      w1, w20
006AD618C  blr      x8
006AD6190  mov      x0, x19
006AD6194  mov      x1, xzr
006AD6198  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD619C  adrp     x21, #0x959f000
006AD61A0  ldrb     w8, [x21, #0x122]
006AD61A4  mov      w20, w0
006AD61A8  cbnz     w8, #0x6ad61c0
006AD61AC  adrp     x0, #0x8f3c000
006AD61B0  ldr      x0, [x0, #0x228]
006AD61B4  bl       #0x382bd14 ; 
006AD61B8  mov      w8, #1
006AD61BC  strb     w8, [x21, #0x122]
006AD61C0  adrp     x8, #0x8f3c000
006AD61C4  ldr      x8, [x8, #0x228]
006AD61C8  ldr      x2, [x8]
006AD61CC  ldrb     w8, [x2, #0x53]
006AD61D0  tbnz     w8, #5, #0x6ad61dc
006AD61D4  str      w20, [x19, #0x24]
006AD61D8  b        #0x6ad61ec ; 
006AD61DC  ldr      x8, [x2, #0x60]
006AD61E0  mov      x0, x19
006AD61E4  mov      w1, w20
006AD61E8  blr      x8
006AD61EC  mov      x0, x19
006AD61F0  mov      x1, xzr
006AD61F4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AD61F8  adrp     x21, #0x959f000
006AD61FC  ldrb     w8, [x21, #0x123]
006AD6200  mov      x20, x0
006AD6204  cbnz     w8, #0x6ad621c
006AD6208  adrp     x0, #0x8f3c000
006AD620C  ldr      x0, [x0, #0x238]
006AD6210  bl       #0x382bd14 ; 
006AD6214  mov      w8, #1
006AD6218  strb     w8, [x21, #0x123]
006AD621C  adrp     x8, #0x8f3c000
006AD6220  ldr      x8, [x8, #0x238]
006AD6224  ldr      x2, [x8]
006AD6228  ldrb     w8, [x2, #0x53]
006AD622C  tbnz     w8, #5, #0x6ad6244
006AD6230  str      x20, [x19, #0x28]!
006AD6234  mov      x0, x19
006AD6238  mov      x1, x20
006AD623C  bl       #0x382bcb8 ; 
006AD6240  b        #0x6ad6254 ; 
006AD6244  ldr      x8, [x2, #0x60]
006AD6248  mov      x0, x19
006AD624C  mov      x1, x20
006AD6250  blr      x8
006AD6254  ldp      x20, x19, [sp, #0x10]
006AD6258  mov      w0, #1
006AD625C  ldp      x30, x21, [sp], #0x20
006AD6260  ret      

