; LocalModels.Bean.SkillGroup_BossTreause$$readImpl
; RVA 0x6AF6110; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF6110  stp      x30, x21, [sp, #-0x20]!
006AF6114  stp      x20, x19, [sp, #0x10]
006AF6118  adrp     x20, #0x959f000
006AF611C  adrp     x21, #0x8f3d000
006AF6120  ldrb     w8, [x20, #0x288]
006AF6124  ldr      x21, [x21, #0xa68]
006AF6128  mov      x19, x0
006AF612C  tbnz     w8, #0, #0x6af6144
006AF6130  adrp     x0, #0x8f3d000
006AF6134  ldr      x0, [x0, #0xa68]
006AF6138  bl       #0x382bd14 ; 
006AF613C  mov      w8, #1
006AF6140  strb     w8, [x20, #0x288]
006AF6144  ldr      x1, [x21]
006AF6148  ldrb     w8, [x1, #0x53]
006AF614C  tbnz     w8, #5, #0x6af619c
006AF6150  mov      x0, x19
006AF6154  mov      x1, xzr
006AF6158  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF615C  adrp     x21, #0x959f000
006AF6160  ldrb     w8, [x21, #0x863]
006AF6164  mov      w20, w0
006AF6168  cbnz     w8, #0x6af6180
006AF616C  adrp     x0, #0x8f3d000
006AF6170  ldr      x0, [x0, #0xa40]
006AF6174  bl       #0x382bd14 ; 
006AF6178  mov      w8, #1
006AF617C  strb     w8, [x21, #0x863]
006AF6180  adrp     x8, #0x8f3d000
006AF6184  ldr      x8, [x8, #0xa40]
006AF6188  ldr      x2, [x8]
006AF618C  ldrb     w8, [x2, #0x53]
006AF6190  tbnz     w8, #5, #0x6af61b0
006AF6194  str      w20, [x19, #0x20]
006AF6198  b        #0x6af61c0 ; 
006AF619C  ldr      x2, [x1, #0x60]
006AF61A0  mov      x0, x19
006AF61A4  ldp      x20, x19, [sp, #0x10]
006AF61A8  ldp      x30, x21, [sp], #0x20
006AF61AC  br       x2
006AF61B0  ldr      x8, [x2, #0x60]
006AF61B4  mov      x0, x19
006AF61B8  mov      w1, w20
006AF61BC  blr      x8
006AF61C0  mov      x0, x19
006AF61C4  mov      x1, xzr
006AF61C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF61CC  adrp     x21, #0x959f000
006AF61D0  ldrb     w8, [x21, #0x864]
006AF61D4  mov      w20, w0
006AF61D8  cbnz     w8, #0x6af61f0
006AF61DC  adrp     x0, #0x8f3d000
006AF61E0  ldr      x0, [x0, #0xa50]
006AF61E4  bl       #0x382bd14 ; 
006AF61E8  mov      w8, #1
006AF61EC  strb     w8, [x21, #0x864]
006AF61F0  adrp     x8, #0x8f3d000
006AF61F4  ldr      x8, [x8, #0xa50]
006AF61F8  ldr      x2, [x8]
006AF61FC  ldrb     w8, [x2, #0x53]
006AF6200  tbnz     w8, #5, #0x6af620c
006AF6204  str      w20, [x19, #0x24]
006AF6208  b        #0x6af621c ; 
006AF620C  ldr      x8, [x2, #0x60]
006AF6210  mov      x0, x19
006AF6214  mov      w1, w20
006AF6218  blr      x8
006AF621C  mov      x0, x19
006AF6220  mov      x1, xzr
006AF6224  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF6228  adrp     x21, #0x959f000
006AF622C  ldrb     w8, [x21, #0x865]
006AF6230  mov      w20, w0
006AF6234  cbnz     w8, #0x6af624c
006AF6238  adrp     x0, #0x8f3d000
006AF623C  ldr      x0, [x0, #0xa60]
006AF6240  bl       #0x382bd14 ; 
006AF6244  mov      w8, #1
006AF6248  strb     w8, [x21, #0x865]
006AF624C  adrp     x8, #0x8f3d000
006AF6250  ldr      x8, [x8, #0xa60]
006AF6254  ldr      x2, [x8]
006AF6258  ldrb     w8, [x2, #0x53]
006AF625C  tbnz     w8, #5, #0x6af6268
006AF6260  str      w20, [x19, #0x28]
006AF6264  b        #0x6af6278 ; 
006AF6268  ldr      x8, [x2, #0x60]
006AF626C  mov      x0, x19
006AF6270  mov      w1, w20
006AF6274  blr      x8
006AF6278  ldp      x20, x19, [sp, #0x10]
006AF627C  mov      w0, #1
006AF6280  ldp      x30, x21, [sp], #0x20
006AF6284  ret      

