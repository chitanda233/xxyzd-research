; LocalModels.Bean.SkillGroup_InitWorldBoss$$readImpl
; RVA 0x6AFAA54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFAA54  stp      x30, x21, [sp, #-0x20]!
006AFAA58  stp      x20, x19, [sp, #0x10]
006AFAA5C  adrp     x20, #0x959f000
006AFAA60  adrp     x21, #0x8f3d000
006AFAA64  ldrb     w8, [x20, #0x300]
006AFAA68  ldr      x21, [x21, #0xdb8]
006AFAA6C  mov      x19, x0
006AFAA70  tbnz     w8, #0, #0x6afaa88
006AFAA74  adrp     x0, #0x8f3d000
006AFAA78  ldr      x0, [x0, #0xdb8]
006AFAA7C  bl       #0x382bd14 ; 
006AFAA80  mov      w8, #1
006AFAA84  strb     w8, [x20, #0x300]
006AFAA88  ldr      x1, [x21]
006AFAA8C  ldrb     w8, [x1, #0x53]
006AFAA90  tbnz     w8, #5, #0x6afaae0
006AFAA94  mov      x0, x19
006AFAA98  mov      x1, xzr
006AFAA9C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFAAA0  adrp     x21, #0x959f000
006AFAAA4  ldrb     w8, [x21, #0x89e]
006AFAAA8  mov      w20, w0
006AFAAAC  cbnz     w8, #0x6afaac4
006AFAAB0  adrp     x0, #0x8f3d000
006AFAAB4  ldr      x0, [x0, #0xd90]
006AFAAB8  bl       #0x382bd14 ; 
006AFAABC  mov      w8, #1
006AFAAC0  strb     w8, [x21, #0x89e]
006AFAAC4  adrp     x8, #0x8f3d000
006AFAAC8  ldr      x8, [x8, #0xd90]
006AFAACC  ldr      x2, [x8]
006AFAAD0  ldrb     w8, [x2, #0x53]
006AFAAD4  tbnz     w8, #5, #0x6afaaf4
006AFAAD8  str      w20, [x19, #0x20]
006AFAADC  b        #0x6afab04 ; 
006AFAAE0  ldr      x2, [x1, #0x60]
006AFAAE4  mov      x0, x19
006AFAAE8  ldp      x20, x19, [sp, #0x10]
006AFAAEC  ldp      x30, x21, [sp], #0x20
006AFAAF0  br       x2
006AFAAF4  ldr      x8, [x2, #0x60]
006AFAAF8  mov      x0, x19
006AFAAFC  mov      w1, w20
006AFAB00  blr      x8
006AFAB04  mov      x0, x19
006AFAB08  mov      x1, xzr
006AFAB0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFAB10  adrp     x21, #0x959f000
006AFAB14  ldrb     w8, [x21, #0x89f]
006AFAB18  mov      w20, w0
006AFAB1C  cbnz     w8, #0x6afab34
006AFAB20  adrp     x0, #0x8f3d000
006AFAB24  ldr      x0, [x0, #0xda0]
006AFAB28  bl       #0x382bd14 ; 
006AFAB2C  mov      w8, #1
006AFAB30  strb     w8, [x21, #0x89f]
006AFAB34  adrp     x8, #0x8f3d000
006AFAB38  ldr      x8, [x8, #0xda0]
006AFAB3C  ldr      x2, [x8]
006AFAB40  ldrb     w8, [x2, #0x53]
006AFAB44  tbnz     w8, #5, #0x6afab50
006AFAB48  str      w20, [x19, #0x24]
006AFAB4C  b        #0x6afab60 ; 
006AFAB50  ldr      x8, [x2, #0x60]
006AFAB54  mov      x0, x19
006AFAB58  mov      w1, w20
006AFAB5C  blr      x8
006AFAB60  mov      x0, x19
006AFAB64  mov      x1, xzr
006AFAB68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFAB6C  adrp     x21, #0x959f000
006AFAB70  ldrb     w8, [x21, #0x8a0]
006AFAB74  mov      w20, w0
006AFAB78  cbnz     w8, #0x6afab90
006AFAB7C  adrp     x0, #0x8f3d000
006AFAB80  ldr      x0, [x0, #0xdb0]
006AFAB84  bl       #0x382bd14 ; 
006AFAB88  mov      w8, #1
006AFAB8C  strb     w8, [x21, #0x8a0]
006AFAB90  adrp     x8, #0x8f3d000
006AFAB94  ldr      x8, [x8, #0xdb0]
006AFAB98  ldr      x2, [x8]
006AFAB9C  ldrb     w8, [x2, #0x53]
006AFABA0  tbnz     w8, #5, #0x6afabac
006AFABA4  str      w20, [x19, #0x28]
006AFABA8  b        #0x6afabbc ; 
006AFABAC  ldr      x8, [x2, #0x60]
006AFABB0  mov      x0, x19
006AFABB4  mov      w1, w20
006AFABB8  blr      x8
006AFABBC  ldp      x20, x19, [sp, #0x10]
006AFABC0  mov      w0, #1
006AFABC4  ldp      x30, x21, [sp], #0x20
006AFABC8  ret      

