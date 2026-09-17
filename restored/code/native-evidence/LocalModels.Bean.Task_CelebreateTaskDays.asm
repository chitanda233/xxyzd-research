; LocalModels.Bean.Task_CelebreateTaskDays$$readImpl
; RVA 0x6B12164; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B12164  stp      x30, x21, [sp, #-0x20]!
006B12168  stp      x20, x19, [sp, #0x10]
006B1216C  adrp     x20, #0x959f000
006B12170  adrp     x21, #0x8f3e000
006B12174  ldrb     w8, [x20, #0x563]
006B12178  ldr      x21, [x21, #0xd98]
006B1217C  mov      x19, x0
006B12180  tbnz     w8, #0, #0x6b12198
006B12184  adrp     x0, #0x8f3e000
006B12188  ldr      x0, [x0, #0xd98]
006B1218C  bl       #0x382bd14 ; 
006B12190  mov      w8, #1
006B12194  strb     w8, [x20, #0x563]
006B12198  ldr      x1, [x21]
006B1219C  ldrb     w8, [x1, #0x53]
006B121A0  tbnz     w8, #5, #0x6b121f0
006B121A4  mov      x0, x19
006B121A8  mov      x1, xzr
006B121AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B121B0  adrp     x21, #0x959f000
006B121B4  ldrb     w8, [x21, #0x9b8]
006B121B8  mov      w20, w0
006B121BC  cbnz     w8, #0x6b121d4
006B121C0  adrp     x0, #0x8f3e000
006B121C4  ldr      x0, [x0, #0xd50]
006B121C8  bl       #0x382bd14 ; 
006B121CC  mov      w8, #1
006B121D0  strb     w8, [x21, #0x9b8]
006B121D4  adrp     x8, #0x8f3e000
006B121D8  ldr      x8, [x8, #0xd50]
006B121DC  ldr      x2, [x8]
006B121E0  ldrb     w8, [x2, #0x53]
006B121E4  tbnz     w8, #5, #0x6b12204
006B121E8  str      w20, [x19, #0x20]
006B121EC  b        #0x6b12214 ; 
006B121F0  ldr      x2, [x1, #0x60]
006B121F4  mov      x0, x19
006B121F8  ldp      x20, x19, [sp, #0x10]
006B121FC  ldp      x30, x21, [sp], #0x20
006B12200  br       x2
006B12204  ldr      x8, [x2, #0x60]
006B12208  mov      x0, x19
006B1220C  mov      w1, w20
006B12210  blr      x8
006B12214  mov      x0, x19
006B12218  mov      x1, xzr
006B1221C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B12220  adrp     x21, #0x959f000
006B12224  ldrb     w8, [x21, #0x9b9]
006B12228  mov      w20, w0
006B1222C  cbnz     w8, #0x6b12244
006B12230  adrp     x0, #0x8f3e000
006B12234  ldr      x0, [x0, #0xd60]
006B12238  bl       #0x382bd14 ; 
006B1223C  mov      w8, #1
006B12240  strb     w8, [x21, #0x9b9]
006B12244  adrp     x8, #0x8f3e000
006B12248  ldr      x8, [x8, #0xd60]
006B1224C  ldr      x2, [x8]
006B12250  ldrb     w8, [x2, #0x53]
006B12254  tbnz     w8, #5, #0x6b12260
006B12258  str      w20, [x19, #0x24]
006B1225C  b        #0x6b12270 ; 
006B12260  ldr      x8, [x2, #0x60]
006B12264  mov      x0, x19
006B12268  mov      w1, w20
006B1226C  blr      x8
006B12270  mov      x0, x19
006B12274  mov      x1, xzr
006B12278  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1227C  adrp     x21, #0x959f000
006B12280  ldrb     w8, [x21, #0x9ba]
006B12284  mov      w20, w0
006B12288  cbnz     w8, #0x6b122a0
006B1228C  adrp     x0, #0x8f3e000
006B12290  ldr      x0, [x0, #0xd70]
006B12294  bl       #0x382bd14 ; 
006B12298  mov      w8, #1
006B1229C  strb     w8, [x21, #0x9ba]
006B122A0  adrp     x8, #0x8f3e000
006B122A4  ldr      x8, [x8, #0xd70]
006B122A8  ldr      x2, [x8]
006B122AC  ldrb     w8, [x2, #0x53]
006B122B0  tbnz     w8, #5, #0x6b122bc
006B122B4  str      w20, [x19, #0x28]
006B122B8  b        #0x6b122cc ; 
006B122BC  ldr      x8, [x2, #0x60]
006B122C0  mov      x0, x19
006B122C4  mov      w1, w20
006B122C8  blr      x8
006B122CC  mov      x0, x19
006B122D0  mov      x1, xzr
006B122D4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B122D8  adrp     x21, #0x959f000
006B122DC  ldrb     w8, [x21, #0x9bb]
006B122E0  mov      x20, x0
006B122E4  cbnz     w8, #0x6b122fc
006B122E8  adrp     x0, #0x8f3e000
006B122EC  ldr      x0, [x0, #0xd80]
006B122F0  bl       #0x382bd14 ; 
006B122F4  mov      w8, #1
006B122F8  strb     w8, [x21, #0x9bb]
006B122FC  adrp     x8, #0x8f3e000
006B12300  ldr      x8, [x8, #0xd80]
006B12304  ldr      x2, [x8]
006B12308  ldrb     w8, [x2, #0x53]
006B1230C  tbnz     w8, #5, #0x6b12324
006B12310  mov      x0, x19
006B12314  str      x20, [x0, #0x30]!
006B12318  mov      x1, x20
006B1231C  bl       #0x382bcb8 ; 
006B12320  b        #0x6b12334 ; 
006B12324  ldr      x8, [x2, #0x60]
006B12328  mov      x0, x19
006B1232C  mov      x1, x20
006B12330  blr      x8
006B12334  mov      x0, x19
006B12338  mov      x1, xzr
006B1233C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B12340  adrp     x21, #0x959f000
006B12344  ldrb     w8, [x21, #0x9bc]
006B12348  mov      x20, x0
006B1234C  cbnz     w8, #0x6b12364
006B12350  adrp     x0, #0x8f3e000
006B12354  ldr      x0, [x0, #0xd90]
006B12358  bl       #0x382bd14 ; 
006B1235C  mov      w8, #1
006B12360  strb     w8, [x21, #0x9bc]
006B12364  adrp     x8, #0x8f3e000
006B12368  ldr      x8, [x8, #0xd90]
006B1236C  ldr      x2, [x8]
006B12370  ldrb     w8, [x2, #0x53]
006B12374  tbnz     w8, #5, #0x6b1238c
006B12378  str      x20, [x19, #0x38]!
006B1237C  mov      x0, x19
006B12380  mov      x1, x20
006B12384  bl       #0x382bcb8 ; 
006B12388  b        #0x6b1239c ; 
006B1238C  ldr      x8, [x2, #0x60]
006B12390  mov      x0, x19
006B12394  mov      x1, x20
006B12398  blr      x8
006B1239C  ldp      x20, x19, [sp, #0x10]
006B123A0  mov      w0, #1
006B123A4  ldp      x30, x21, [sp], #0x20
006B123A8  ret      

