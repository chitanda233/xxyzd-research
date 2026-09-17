; LocalModels.Bean.SkillGroup_BranchSurvivorGroup$$readImpl
; RVA 0x6AF66F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF66F4  stp      x30, x21, [sp, #-0x20]!
006AF66F8  stp      x20, x19, [sp, #0x10]
006AF66FC  adrp     x20, #0x959f000
006AF6700  adrp     x21, #0x8f3d000
006AF6704  ldrb     w8, [x20, #0x292]
006AF6708  ldr      x21, [x21, #0xaa0]
006AF670C  mov      x19, x0
006AF6710  tbnz     w8, #0, #0x6af6728
006AF6714  adrp     x0, #0x8f3d000
006AF6718  ldr      x0, [x0, #0xaa0]
006AF671C  bl       #0x382bd14 ; 
006AF6720  mov      w8, #1
006AF6724  strb     w8, [x20, #0x292]
006AF6728  ldr      x1, [x21]
006AF672C  ldrb     w8, [x1, #0x53]
006AF6730  tbnz     w8, #5, #0x6af6780
006AF6734  mov      x0, x19
006AF6738  mov      x1, xzr
006AF673C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF6740  adrp     x21, #0x959f000
006AF6744  ldrb     w8, [x21, #0x867]
006AF6748  mov      w20, w0
006AF674C  cbnz     w8, #0x6af6764
006AF6750  adrp     x0, #0x8f3d000
006AF6754  ldr      x0, [x0, #0xa88]
006AF6758  bl       #0x382bd14 ; 
006AF675C  mov      w8, #1
006AF6760  strb     w8, [x21, #0x867]
006AF6764  adrp     x8, #0x8f3d000
006AF6768  ldr      x8, [x8, #0xa88]
006AF676C  ldr      x2, [x8]
006AF6770  ldrb     w8, [x2, #0x53]
006AF6774  tbnz     w8, #5, #0x6af6794
006AF6778  str      w20, [x19, #0x20]
006AF677C  b        #0x6af67a4 ; 
006AF6780  ldr      x2, [x1, #0x60]
006AF6784  mov      x0, x19
006AF6788  ldp      x20, x19, [sp, #0x10]
006AF678C  ldp      x30, x21, [sp], #0x20
006AF6790  br       x2
006AF6794  ldr      x8, [x2, #0x60]
006AF6798  mov      x0, x19
006AF679C  mov      w1, w20
006AF67A0  blr      x8
006AF67A4  mov      x0, x19
006AF67A8  mov      x1, xzr
006AF67AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF67B0  adrp     x21, #0x959f000
006AF67B4  ldrb     w8, [x21, #0x868]
006AF67B8  mov      w20, w0
006AF67BC  cbnz     w8, #0x6af67d4
006AF67C0  adrp     x0, #0x8f3d000
006AF67C4  ldr      x0, [x0, #0xa90]
006AF67C8  bl       #0x382bd14 ; 
006AF67CC  mov      w8, #1
006AF67D0  strb     w8, [x21, #0x868]
006AF67D4  adrp     x8, #0x8f3d000
006AF67D8  ldr      x8, [x8, #0xa90]
006AF67DC  ldr      x2, [x8]
006AF67E0  ldrb     w8, [x2, #0x53]
006AF67E4  tbnz     w8, #5, #0x6af67f0
006AF67E8  str      w20, [x19, #0x24]
006AF67EC  b        #0x6af6800 ; 
006AF67F0  ldr      x8, [x2, #0x60]
006AF67F4  mov      x0, x19
006AF67F8  mov      w1, w20
006AF67FC  blr      x8
006AF6800  mov      x0, x19
006AF6804  mov      x1, xzr
006AF6808  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF680C  adrp     x21, #0x959f000
006AF6810  ldrb     w8, [x21, #0x869]
006AF6814  mov      w20, w0
006AF6818  cbnz     w8, #0x6af6830
006AF681C  adrp     x0, #0x8f3d000
006AF6820  ldr      x0, [x0, #0xa98]
006AF6824  bl       #0x382bd14 ; 
006AF6828  mov      w8, #1
006AF682C  strb     w8, [x21, #0x869]
006AF6830  adrp     x8, #0x8f3d000
006AF6834  ldr      x8, [x8, #0xa98]
006AF6838  ldr      x2, [x8]
006AF683C  ldrb     w8, [x2, #0x53]
006AF6840  tbnz     w8, #5, #0x6af684c
006AF6844  str      w20, [x19, #0x28]
006AF6848  b        #0x6af685c ; 
006AF684C  ldr      x8, [x2, #0x60]
006AF6850  mov      x0, x19
006AF6854  mov      w1, w20
006AF6858  blr      x8
006AF685C  ldp      x20, x19, [sp, #0x10]
006AF6860  mov      w0, #1
006AF6864  ldp      x30, x21, [sp], #0x20
006AF6868  ret      

