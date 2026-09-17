; LocalModels.Bean.CrossArena_CrossArenaRobotHero$$readImpl
; RVA 0x6A5600C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5600C  stp      x30, x21, [sp, #-0x20]!
006A56010  stp      x20, x19, [sp, #0x10]
006A56014  adrp     x20, #0x959d000
006A56018  adrp     x21, #0x8f36000
006A5601C  ldrb     w8, [x20, #0xae5]
006A56020  ldr      x21, [x21, #0x218]
006A56024  mov      x19, x0
006A56028  tbnz     w8, #0, #0x6a56040
006A5602C  adrp     x0, #0x8f36000
006A56030  ldr      x0, [x0, #0x218]
006A56034  bl       #0x382bd14 ; 
006A56038  mov      w8, #1
006A5603C  strb     w8, [x20, #0xae5]
006A56040  ldr      x1, [x21]
006A56044  ldrb     w8, [x1, #0x53]
006A56048  tbnz     w8, #5, #0x6a56098
006A5604C  mov      x0, x19
006A56050  mov      x1, xzr
006A56054  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A56058  adrp     x21, #0x959e000
006A5605C  ldrb     w8, [x21, #0x328]
006A56060  mov      w20, w0
006A56064  cbnz     w8, #0x6a5607c
006A56068  adrp     x0, #0x8f36000
006A5606C  ldr      x0, [x0, #0x1c0]
006A56070  bl       #0x382bd14 ; 
006A56074  mov      w8, #1
006A56078  strb     w8, [x21, #0x328]
006A5607C  adrp     x8, #0x8f36000
006A56080  ldr      x8, [x8, #0x1c0]
006A56084  ldr      x2, [x8]
006A56088  ldrb     w8, [x2, #0x53]
006A5608C  tbnz     w8, #5, #0x6a560ac
006A56090  str      w20, [x19, #0x20]
006A56094  b        #0x6a560bc ; 
006A56098  ldr      x2, [x1, #0x60]
006A5609C  mov      x0, x19
006A560A0  ldp      x20, x19, [sp, #0x10]
006A560A4  ldp      x30, x21, [sp], #0x20
006A560A8  br       x2
006A560AC  ldr      x8, [x2, #0x60]
006A560B0  mov      x0, x19
006A560B4  mov      w1, w20
006A560B8  blr      x8
006A560BC  mov      x0, x19
006A560C0  mov      x1, xzr
006A560C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A560C8  adrp     x21, #0x959e000
006A560CC  ldrb     w8, [x21, #0x329]
006A560D0  mov      w20, w0
006A560D4  cbnz     w8, #0x6a560ec
006A560D8  adrp     x0, #0x8f36000
006A560DC  ldr      x0, [x0, #0x1d0]
006A560E0  bl       #0x382bd14 ; 
006A560E4  mov      w8, #1
006A560E8  strb     w8, [x21, #0x329]
006A560EC  adrp     x8, #0x8f36000
006A560F0  ldr      x8, [x8, #0x1d0]
006A560F4  ldr      x2, [x8]
006A560F8  ldrb     w8, [x2, #0x53]
006A560FC  tbnz     w8, #5, #0x6a56108
006A56100  str      w20, [x19, #0x24]
006A56104  b        #0x6a56118 ; 
006A56108  ldr      x8, [x2, #0x60]
006A5610C  mov      x0, x19
006A56110  mov      w1, w20
006A56114  blr      x8
006A56118  mov      x0, x19
006A5611C  mov      x1, xzr
006A56120  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A56124  adrp     x21, #0x959e000
006A56128  ldrb     w8, [x21, #0x32a]
006A5612C  mov      w20, w0
006A56130  cbnz     w8, #0x6a56148
006A56134  adrp     x0, #0x8f36000
006A56138  ldr      x0, [x0, #0x1e0]
006A5613C  bl       #0x382bd14 ; 
006A56140  mov      w8, #1
006A56144  strb     w8, [x21, #0x32a]
006A56148  adrp     x8, #0x8f36000
006A5614C  ldr      x8, [x8, #0x1e0]
006A56150  ldr      x2, [x8]
006A56154  ldrb     w8, [x2, #0x53]
006A56158  tbnz     w8, #5, #0x6a56164
006A5615C  str      w20, [x19, #0x28]
006A56160  b        #0x6a56174 ; 
006A56164  ldr      x8, [x2, #0x60]
006A56168  mov      x0, x19
006A5616C  mov      w1, w20
006A56170  blr      x8
006A56174  mov      x0, x19
006A56178  mov      x1, xzr
006A5617C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A56180  adrp     x21, #0x959e000
006A56184  ldrb     w8, [x21, #0x32b]
006A56188  mov      w20, w0
006A5618C  cbnz     w8, #0x6a561a4
006A56190  adrp     x0, #0x8f36000
006A56194  ldr      x0, [x0, #0x1f0]
006A56198  bl       #0x382bd14 ; 
006A5619C  mov      w8, #1
006A561A0  strb     w8, [x21, #0x32b]
006A561A4  adrp     x8, #0x8f36000
006A561A8  ldr      x8, [x8, #0x1f0]
006A561AC  ldr      x2, [x8]
006A561B0  ldrb     w8, [x2, #0x53]
006A561B4  tbnz     w8, #5, #0x6a561c0
006A561B8  str      w20, [x19, #0x2c]
006A561BC  b        #0x6a561d0 ; 
006A561C0  ldr      x8, [x2, #0x60]
006A561C4  mov      x0, x19
006A561C8  mov      w1, w20
006A561CC  blr      x8
006A561D0  mov      x0, x19
006A561D4  mov      x1, xzr
006A561D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A561DC  adrp     x21, #0x959e000
006A561E0  ldrb     w8, [x21, #0x32c]
006A561E4  mov      w20, w0
006A561E8  cbnz     w8, #0x6a56200
006A561EC  adrp     x0, #0x8f36000
006A561F0  ldr      x0, [x0, #0x200]
006A561F4  bl       #0x382bd14 ; 
006A561F8  mov      w8, #1
006A561FC  strb     w8, [x21, #0x32c]
006A56200  adrp     x8, #0x8f36000
006A56204  ldr      x8, [x8, #0x200]
006A56208  ldr      x2, [x8]
006A5620C  ldrb     w8, [x2, #0x53]
006A56210  tbnz     w8, #5, #0x6a5621c
006A56214  str      w20, [x19, #0x30]
006A56218  b        #0x6a5622c ; 
006A5621C  ldr      x8, [x2, #0x60]
006A56220  mov      x0, x19
006A56224  mov      w1, w20
006A56228  blr      x8
006A5622C  mov      x0, x19
006A56230  mov      x1, xzr
006A56234  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A56238  adrp     x21, #0x959e000
006A5623C  ldrb     w8, [x21, #0x32d]
006A56240  mov      w20, w0
006A56244  cbnz     w8, #0x6a5625c
006A56248  adrp     x0, #0x8f36000
006A5624C  ldr      x0, [x0, #0x210]
006A56250  bl       #0x382bd14 ; 
006A56254  mov      w8, #1
006A56258  strb     w8, [x21, #0x32d]
006A5625C  adrp     x8, #0x8f36000
006A56260  ldr      x8, [x8, #0x210]
006A56264  ldr      x2, [x8]
006A56268  ldrb     w8, [x2, #0x53]
006A5626C  tbnz     w8, #5, #0x6a56278
006A56270  str      w20, [x19, #0x34]
006A56274  b        #0x6a56288 ; 
006A56278  ldr      x8, [x2, #0x60]
006A5627C  mov      x0, x19
006A56280  mov      w1, w20
006A56284  blr      x8
006A56288  ldp      x20, x19, [sp, #0x10]
006A5628C  mov      w0, #1
006A56290  ldp      x30, x21, [sp], #0x20
006A56294  ret      

