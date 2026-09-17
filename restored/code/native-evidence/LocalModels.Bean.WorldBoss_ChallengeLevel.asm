; LocalModels.Bean.WorldBoss_ChallengeLevel$$readImpl
; RVA 0x6B23044; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B23044  stp      x30, x21, [sp, #-0x20]!
006B23048  stp      x20, x19, [sp, #0x10]
006B2304C  adrp     x20, #0x959f000
006B23050  adrp     x21, #0x8f3f000
006B23054  ldrb     w8, [x20, #0x722]
006B23058  ldr      x21, [x21, #0x988]
006B2305C  mov      x19, x0
006B23060  tbnz     w8, #0, #0x6b23078
006B23064  adrp     x0, #0x8f3f000
006B23068  ldr      x0, [x0, #0x988]
006B2306C  bl       #0x382bd14 ; 
006B23070  mov      w8, #1
006B23074  strb     w8, [x20, #0x722]
006B23078  ldr      x1, [x21]
006B2307C  ldrb     w8, [x1, #0x53]
006B23080  tbnz     w8, #5, #0x6b230d0
006B23084  mov      x0, x19
006B23088  mov      x1, xzr
006B2308C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B23090  adrp     x21, #0x959f000
006B23094  ldrb     w8, [x21, #0xa74]
006B23098  mov      w20, w0
006B2309C  cbnz     w8, #0x6b230b4
006B230A0  adrp     x0, #0x8f3f000
006B230A4  ldr      x0, [x0, #0x950]
006B230A8  bl       #0x382bd14 ; 
006B230AC  mov      w8, #1
006B230B0  strb     w8, [x21, #0xa74]
006B230B4  adrp     x8, #0x8f3f000
006B230B8  ldr      x8, [x8, #0x950]
006B230BC  ldr      x2, [x8]
006B230C0  ldrb     w8, [x2, #0x53]
006B230C4  tbnz     w8, #5, #0x6b230e4
006B230C8  str      w20, [x19, #0x20]
006B230CC  b        #0x6b230f4 ; 
006B230D0  ldr      x2, [x1, #0x60]
006B230D4  mov      x0, x19
006B230D8  ldp      x20, x19, [sp, #0x10]
006B230DC  ldp      x30, x21, [sp], #0x20
006B230E0  br       x2
006B230E4  ldr      x8, [x2, #0x60]
006B230E8  mov      x0, x19
006B230EC  mov      w1, w20
006B230F0  blr      x8
006B230F4  mov      x0, x19
006B230F8  mov      x1, xzr
006B230FC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B23100  adrp     x21, #0x959f000
006B23104  ldrb     w8, [x21, #0xa75]
006B23108  mov      x20, x0
006B2310C  cbnz     w8, #0x6b23124
006B23110  adrp     x0, #0x8f3f000
006B23114  ldr      x0, [x0, #0x960]
006B23118  bl       #0x382bd14 ; 
006B2311C  mov      w8, #1
006B23120  strb     w8, [x21, #0xa75]
006B23124  adrp     x8, #0x8f3f000
006B23128  ldr      x8, [x8, #0x960]
006B2312C  ldr      x2, [x8]
006B23130  ldrb     w8, [x2, #0x53]
006B23134  tbnz     w8, #5, #0x6b2314c
006B23138  mov      x0, x19
006B2313C  str      x20, [x0, #0x28]!
006B23140  mov      x1, x20
006B23144  bl       #0x382bcb8 ; 
006B23148  b        #0x6b2315c ; 
006B2314C  ldr      x8, [x2, #0x60]
006B23150  mov      x0, x19
006B23154  mov      x1, x20
006B23158  blr      x8
006B2315C  mov      x0, x19
006B23160  mov      x1, xzr
006B23164  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B23168  adrp     x21, #0x959f000
006B2316C  ldrb     w8, [x21, #0xa76]
006B23170  mov      x20, x0
006B23174  cbnz     w8, #0x6b2318c
006B23178  adrp     x0, #0x8f3f000
006B2317C  ldr      x0, [x0, #0x970]
006B23180  bl       #0x382bd14 ; 
006B23184  mov      w8, #1
006B23188  strb     w8, [x21, #0xa76]
006B2318C  adrp     x8, #0x8f3f000
006B23190  ldr      x8, [x8, #0x970]
006B23194  ldr      x2, [x8]
006B23198  ldrb     w8, [x2, #0x53]
006B2319C  tbnz     w8, #5, #0x6b231b4
006B231A0  mov      x0, x19
006B231A4  str      x20, [x0, #0x30]!
006B231A8  mov      x1, x20
006B231AC  bl       #0x382bcb8 ; 
006B231B0  b        #0x6b231c4 ; 
006B231B4  ldr      x8, [x2, #0x60]
006B231B8  mov      x0, x19
006B231BC  mov      x1, x20
006B231C0  blr      x8
006B231C4  mov      x0, x19
006B231C8  mov      x1, xzr
006B231CC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B231D0  adrp     x21, #0x959f000
006B231D4  ldrb     w8, [x21, #0xa77]
006B231D8  mov      x20, x0
006B231DC  cbnz     w8, #0x6b231f4
006B231E0  adrp     x0, #0x8f3f000
006B231E4  ldr      x0, [x0, #0x980]
006B231E8  bl       #0x382bd14 ; 
006B231EC  mov      w8, #1
006B231F0  strb     w8, [x21, #0xa77]
006B231F4  adrp     x8, #0x8f3f000
006B231F8  ldr      x8, [x8, #0x980]
006B231FC  ldr      x2, [x8]
006B23200  ldrb     w8, [x2, #0x53]
006B23204  tbnz     w8, #5, #0x6b2321c
006B23208  str      x20, [x19, #0x38]!
006B2320C  mov      x0, x19
006B23210  mov      x1, x20
006B23214  bl       #0x382bcb8 ; 
006B23218  b        #0x6b2322c ; 
006B2321C  ldr      x8, [x2, #0x60]
006B23220  mov      x0, x19
006B23224  mov      x1, x20
006B23228  blr      x8
006B2322C  ldp      x20, x19, [sp, #0x10]
006B23230  mov      w0, #1
006B23234  ldp      x30, x21, [sp], #0x20
006B23238  ret      

