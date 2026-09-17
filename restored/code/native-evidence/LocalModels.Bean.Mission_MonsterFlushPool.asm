; LocalModels.Bean.Mission_MonsterFlushPool$$readImpl
; RVA 0x6AC206C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC206C  stp      x30, x21, [sp, #-0x20]!
006AC2070  stp      x20, x19, [sp, #0x10]
006AC2074  adrp     x20, #0x959e000
006AC2078  adrp     x21, #0x8f3b000
006AC207C  ldrb     w8, [x20, #0x990]
006AC2080  ldr      x21, [x21, #0x360]
006AC2084  mov      x19, x0
006AC2088  tbnz     w8, #0, #0x6ac20a0
006AC208C  adrp     x0, #0x8f3b000
006AC2090  ldr      x0, [x0, #0x360]
006AC2094  bl       #0x382bd14 ; 
006AC2098  mov      w8, #1
006AC209C  strb     w8, [x20, #0x990]
006AC20A0  ldr      x1, [x21]
006AC20A4  ldrb     w8, [x1, #0x53]
006AC20A8  tbnz     w8, #5, #0x6ac20f8
006AC20AC  mov      x0, x19
006AC20B0  mov      x1, xzr
006AC20B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC20B8  adrp     x21, #0x959f000
006AC20BC  ldrb     w8, [x21, #0x44]
006AC20C0  mov      w20, w0
006AC20C4  cbnz     w8, #0x6ac20dc
006AC20C8  adrp     x0, #0x8f3b000
006AC20CC  ldr      x0, [x0, #0x348]
006AC20D0  bl       #0x382bd14 ; 
006AC20D4  mov      w8, #1
006AC20D8  strb     w8, [x21, #0x44]
006AC20DC  adrp     x8, #0x8f3b000
006AC20E0  ldr      x8, [x8, #0x348]
006AC20E4  ldr      x2, [x8]
006AC20E8  ldrb     w8, [x2, #0x53]
006AC20EC  tbnz     w8, #5, #0x6ac210c
006AC20F0  str      w20, [x19, #0x20]
006AC20F4  b        #0x6ac211c ; 
006AC20F8  ldr      x2, [x1, #0x60]
006AC20FC  mov      x0, x19
006AC2100  ldp      x20, x19, [sp, #0x10]
006AC2104  ldp      x30, x21, [sp], #0x20
006AC2108  br       x2
006AC210C  ldr      x8, [x2, #0x60]
006AC2110  mov      x0, x19
006AC2114  mov      w1, w20
006AC2118  blr      x8
006AC211C  mov      x0, x19
006AC2120  mov      x1, xzr
006AC2124  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC2128  adrp     x21, #0x959f000
006AC212C  ldrb     w8, [x21, #0x45]
006AC2130  mov      x20, x0
006AC2134  cbnz     w8, #0x6ac214c
006AC2138  adrp     x0, #0x8f3b000
006AC213C  ldr      x0, [x0, #0x358]
006AC2140  bl       #0x382bd14 ; 
006AC2144  mov      w8, #1
006AC2148  strb     w8, [x21, #0x45]
006AC214C  adrp     x8, #0x8f3b000
006AC2150  ldr      x8, [x8, #0x358]
006AC2154  ldr      x2, [x8]
006AC2158  ldrb     w8, [x2, #0x53]
006AC215C  tbnz     w8, #5, #0x6ac2174
006AC2160  str      x20, [x19, #0x28]!
006AC2164  mov      x0, x19
006AC2168  mov      x1, x20
006AC216C  bl       #0x382bcb8 ; 
006AC2170  b        #0x6ac2184 ; 
006AC2174  ldr      x8, [x2, #0x60]
006AC2178  mov      x0, x19
006AC217C  mov      x1, x20
006AC2180  blr      x8
006AC2184  ldp      x20, x19, [sp, #0x10]
006AC2188  mov      w0, #1
006AC218C  ldp      x30, x21, [sp], #0x20
006AC2190  ret      

