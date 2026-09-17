; LocalModels.Bean.SkillGroup_BaseGroupRoom$$readImpl
; RVA 0x6AF5548; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF5548  stp      x30, x21, [sp, #-0x20]!
006AF554C  stp      x20, x19, [sp, #0x10]
006AF5550  adrp     x20, #0x959e000
006AF5554  adrp     x21, #0x8f3d000
006AF5558  ldrb     w8, [x20, #0xee2]
006AF555C  ldr      x21, [x21, #0x9d8]
006AF5560  mov      x19, x0
006AF5564  tbnz     w8, #0, #0x6af557c
006AF5568  adrp     x0, #0x8f3d000
006AF556C  ldr      x0, [x0, #0x9d8]
006AF5570  bl       #0x382bd14 ; 
006AF5574  mov      w8, #1
006AF5578  strb     w8, [x20, #0xee2]
006AF557C  ldr      x1, [x21]
006AF5580  ldrb     w8, [x1, #0x53]
006AF5584  tbnz     w8, #5, #0x6af55d4
006AF5588  mov      x0, x19
006AF558C  mov      x1, xzr
006AF5590  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF5594  adrp     x21, #0x959f000
006AF5598  ldrb     w8, [x21, #0x27a]
006AF559C  mov      w20, w0
006AF55A0  cbnz     w8, #0x6af55b8
006AF55A4  adrp     x0, #0x8f3d000
006AF55A8  ldr      x0, [x0, #0x9b0]
006AF55AC  bl       #0x382bd14 ; 
006AF55B0  mov      w8, #1
006AF55B4  strb     w8, [x21, #0x27a]
006AF55B8  adrp     x8, #0x8f3d000
006AF55BC  ldr      x8, [x8, #0x9b0]
006AF55C0  ldr      x2, [x8]
006AF55C4  ldrb     w8, [x2, #0x53]
006AF55C8  tbnz     w8, #5, #0x6af55e8
006AF55CC  str      w20, [x19, #0x20]
006AF55D0  b        #0x6af55f8 ; 
006AF55D4  ldr      x2, [x1, #0x60]
006AF55D8  mov      x0, x19
006AF55DC  ldp      x20, x19, [sp, #0x10]
006AF55E0  ldp      x30, x21, [sp], #0x20
006AF55E4  br       x2
006AF55E8  ldr      x8, [x2, #0x60]
006AF55EC  mov      x0, x19
006AF55F0  mov      w1, w20
006AF55F4  blr      x8
006AF55F8  mov      x0, x19
006AF55FC  mov      x1, xzr
006AF5600  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF5604  adrp     x21, #0x959f000
006AF5608  ldrb     w8, [x21, #0x27b]
006AF560C  mov      w20, w0
006AF5610  cbnz     w8, #0x6af5628
006AF5614  adrp     x0, #0x8f3d000
006AF5618  ldr      x0, [x0, #0x9c0]
006AF561C  bl       #0x382bd14 ; 
006AF5620  mov      w8, #1
006AF5624  strb     w8, [x21, #0x27b]
006AF5628  adrp     x8, #0x8f3d000
006AF562C  ldr      x8, [x8, #0x9c0]
006AF5630  ldr      x2, [x8]
006AF5634  ldrb     w8, [x2, #0x53]
006AF5638  tbnz     w8, #5, #0x6af5644
006AF563C  str      w20, [x19, #0x24]
006AF5640  b        #0x6af5654 ; 
006AF5644  ldr      x8, [x2, #0x60]
006AF5648  mov      x0, x19
006AF564C  mov      w1, w20
006AF5650  blr      x8
006AF5654  mov      x0, x19
006AF5658  mov      x1, xzr
006AF565C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF5660  adrp     x21, #0x959f000
006AF5664  ldrb     w8, [x21, #0x27c]
006AF5668  mov      w20, w0
006AF566C  cbnz     w8, #0x6af5684
006AF5670  adrp     x0, #0x8f3d000
006AF5674  ldr      x0, [x0, #0x9d0]
006AF5678  bl       #0x382bd14 ; 
006AF567C  mov      w8, #1
006AF5680  strb     w8, [x21, #0x27c]
006AF5684  adrp     x8, #0x8f3d000
006AF5688  ldr      x8, [x8, #0x9d0]
006AF568C  ldr      x2, [x8]
006AF5690  ldrb     w8, [x2, #0x53]
006AF5694  tbnz     w8, #5, #0x6af56a0
006AF5698  str      w20, [x19, #0x28]
006AF569C  b        #0x6af56b0 ; 
006AF56A0  ldr      x8, [x2, #0x60]
006AF56A4  mov      x0, x19
006AF56A8  mov      w1, w20
006AF56AC  blr      x8
006AF56B0  ldp      x20, x19, [sp, #0x10]
006AF56B4  mov      w0, #1
006AF56B8  ldp      x30, x21, [sp], #0x20
006AF56BC  ret      

