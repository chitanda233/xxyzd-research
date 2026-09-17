; LocalModels.Bean.Rune_RuneSlot$$readImpl
; RVA 0x6AE66D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE66D0  stp      x30, x21, [sp, #-0x20]!
006AE66D4  stp      x20, x19, [sp, #0x10]
006AE66D8  adrp     x20, #0x959e000
006AE66DC  adrp     x21, #0x8f3c000
006AE66E0  ldrb     w8, [x20, #0xd52]
006AE66E4  ldr      x21, [x21, #0xe38]
006AE66E8  mov      x19, x0
006AE66EC  tbnz     w8, #0, #0x6ae6704
006AE66F0  adrp     x0, #0x8f3c000
006AE66F4  ldr      x0, [x0, #0xe38]
006AE66F8  bl       #0x382bd14 ; 
006AE66FC  mov      w8, #1
006AE6700  strb     w8, [x20, #0xd52]
006AE6704  ldr      x1, [x21]
006AE6708  ldrb     w8, [x1, #0x53]
006AE670C  tbnz     w8, #5, #0x6ae675c
006AE6710  mov      x0, x19
006AE6714  mov      x1, xzr
006AE6718  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE671C  adrp     x21, #0x959f000
006AE6720  ldrb     w8, [x21, #0x1d9]
006AE6724  mov      w20, w0
006AE6728  cbnz     w8, #0x6ae6740
006AE672C  adrp     x0, #0x8f3c000
006AE6730  ldr      x0, [x0, #0xe10]
006AE6734  bl       #0x382bd14 ; 
006AE6738  mov      w8, #1
006AE673C  strb     w8, [x21, #0x1d9]
006AE6740  adrp     x8, #0x8f3c000
006AE6744  ldr      x8, [x8, #0xe10]
006AE6748  ldr      x2, [x8]
006AE674C  ldrb     w8, [x2, #0x53]
006AE6750  tbnz     w8, #5, #0x6ae6770
006AE6754  str      w20, [x19, #0x20]
006AE6758  b        #0x6ae6780 ; 
006AE675C  ldr      x2, [x1, #0x60]
006AE6760  mov      x0, x19
006AE6764  ldp      x20, x19, [sp, #0x10]
006AE6768  ldp      x30, x21, [sp], #0x20
006AE676C  br       x2
006AE6770  ldr      x8, [x2, #0x60]
006AE6774  mov      x0, x19
006AE6778  mov      w1, w20
006AE677C  blr      x8
006AE6780  mov      x0, x19
006AE6784  mov      x1, xzr
006AE6788  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE678C  adrp     x21, #0x959f000
006AE6790  ldrb     w8, [x21, #0x1da]
006AE6794  mov      w20, w0
006AE6798  cbnz     w8, #0x6ae67b0
006AE679C  adrp     x0, #0x8f3c000
006AE67A0  ldr      x0, [x0, #0xe20]
006AE67A4  bl       #0x382bd14 ; 
006AE67A8  mov      w8, #1
006AE67AC  strb     w8, [x21, #0x1da]
006AE67B0  adrp     x8, #0x8f3c000
006AE67B4  ldr      x8, [x8, #0xe20]
006AE67B8  ldr      x2, [x8]
006AE67BC  ldrb     w8, [x2, #0x53]
006AE67C0  tbnz     w8, #5, #0x6ae67cc
006AE67C4  str      w20, [x19, #0x24]
006AE67C8  b        #0x6ae67dc ; 
006AE67CC  ldr      x8, [x2, #0x60]
006AE67D0  mov      x0, x19
006AE67D4  mov      w1, w20
006AE67D8  blr      x8
006AE67DC  mov      x0, x19
006AE67E0  mov      x1, xzr
006AE67E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE67E8  adrp     x21, #0x959f000
006AE67EC  ldrb     w8, [x21, #0x1db]
006AE67F0  mov      w20, w0
006AE67F4  cbnz     w8, #0x6ae680c
006AE67F8  adrp     x0, #0x8f3c000
006AE67FC  ldr      x0, [x0, #0xe30]
006AE6800  bl       #0x382bd14 ; 
006AE6804  mov      w8, #1
006AE6808  strb     w8, [x21, #0x1db]
006AE680C  adrp     x8, #0x8f3c000
006AE6810  ldr      x8, [x8, #0xe30]
006AE6814  ldr      x2, [x8]
006AE6818  ldrb     w8, [x2, #0x53]
006AE681C  tbnz     w8, #5, #0x6ae6828
006AE6820  str      w20, [x19, #0x28]
006AE6824  b        #0x6ae6838 ; 
006AE6828  ldr      x8, [x2, #0x60]
006AE682C  mov      x0, x19
006AE6830  mov      w1, w20
006AE6834  blr      x8
006AE6838  ldp      x20, x19, [sp, #0x10]
006AE683C  mov      w0, #1
006AE6840  ldp      x30, x21, [sp], #0x20
006AE6844  ret      

