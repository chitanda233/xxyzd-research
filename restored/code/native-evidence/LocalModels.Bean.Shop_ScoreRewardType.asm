; LocalModels.Bean.Shop_ScoreRewardType$$readImpl
; RVA 0x6AEE778; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEE778  stp      x30, x21, [sp, #-0x20]!
006AEE77C  stp      x20, x19, [sp, #0x10]
006AEE780  adrp     x20, #0x959e000
006AEE784  adrp     x21, #0x8f3d000
006AEE788  ldrb     w8, [x20, #0xe2c]
006AEE78C  ldr      x21, [x21, #0x488]
006AEE790  mov      x19, x0
006AEE794  tbnz     w8, #0, #0x6aee7ac
006AEE798  adrp     x0, #0x8f3d000
006AEE79C  ldr      x0, [x0, #0x488]
006AEE7A0  bl       #0x382bd14 ; 
006AEE7A4  mov      w8, #1
006AEE7A8  strb     w8, [x20, #0xe2c]
006AEE7AC  ldr      x1, [x21]
006AEE7B0  ldrb     w8, [x1, #0x53]
006AEE7B4  tbnz     w8, #5, #0x6aee804
006AEE7B8  mov      x0, x19
006AEE7BC  mov      x1, xzr
006AEE7C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEE7C4  adrp     x21, #0x959f000
006AEE7C8  ldrb     w8, [x21, #0x22e]
006AEE7CC  mov      w20, w0
006AEE7D0  cbnz     w8, #0x6aee7e8
006AEE7D4  adrp     x0, #0x8f3d000
006AEE7D8  ldr      x0, [x0, #0x460]
006AEE7DC  bl       #0x382bd14 ; 
006AEE7E0  mov      w8, #1
006AEE7E4  strb     w8, [x21, #0x22e]
006AEE7E8  adrp     x8, #0x8f3d000
006AEE7EC  ldr      x8, [x8, #0x460]
006AEE7F0  ldr      x2, [x8]
006AEE7F4  ldrb     w8, [x2, #0x53]
006AEE7F8  tbnz     w8, #5, #0x6aee818
006AEE7FC  str      w20, [x19, #0x20]
006AEE800  b        #0x6aee828 ; 
006AEE804  ldr      x2, [x1, #0x60]
006AEE808  mov      x0, x19
006AEE80C  ldp      x20, x19, [sp, #0x10]
006AEE810  ldp      x30, x21, [sp], #0x20
006AEE814  br       x2
006AEE818  ldr      x8, [x2, #0x60]
006AEE81C  mov      x0, x19
006AEE820  mov      w1, w20
006AEE824  blr      x8
006AEE828  mov      x0, x19
006AEE82C  mov      x1, xzr
006AEE830  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEE834  adrp     x21, #0x959f000
006AEE838  ldrb     w8, [x21, #0x22f]
006AEE83C  mov      w20, w0
006AEE840  cbnz     w8, #0x6aee858
006AEE844  adrp     x0, #0x8f3d000
006AEE848  ldr      x0, [x0, #0x470]
006AEE84C  bl       #0x382bd14 ; 
006AEE850  mov      w8, #1
006AEE854  strb     w8, [x21, #0x22f]
006AEE858  adrp     x8, #0x8f3d000
006AEE85C  ldr      x8, [x8, #0x470]
006AEE860  ldr      x2, [x8]
006AEE864  ldrb     w8, [x2, #0x53]
006AEE868  tbnz     w8, #5, #0x6aee874
006AEE86C  str      w20, [x19, #0x24]
006AEE870  b        #0x6aee884 ; 
006AEE874  ldr      x8, [x2, #0x60]
006AEE878  mov      x0, x19
006AEE87C  mov      w1, w20
006AEE880  blr      x8
006AEE884  mov      x0, x19
006AEE888  mov      x1, xzr
006AEE88C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEE890  adrp     x21, #0x959f000
006AEE894  ldrb     w8, [x21, #0x230]
006AEE898  mov      w20, w0
006AEE89C  cbnz     w8, #0x6aee8b4
006AEE8A0  adrp     x0, #0x8f3d000
006AEE8A4  ldr      x0, [x0, #0x480]
006AEE8A8  bl       #0x382bd14 ; 
006AEE8AC  mov      w8, #1
006AEE8B0  strb     w8, [x21, #0x230]
006AEE8B4  adrp     x8, #0x8f3d000
006AEE8B8  ldr      x8, [x8, #0x480]
006AEE8BC  ldr      x2, [x8]
006AEE8C0  ldrb     w8, [x2, #0x53]
006AEE8C4  tbnz     w8, #5, #0x6aee8d0
006AEE8C8  str      w20, [x19, #0x28]
006AEE8CC  b        #0x6aee8e0 ; 
006AEE8D0  ldr      x8, [x2, #0x60]
006AEE8D4  mov      x0, x19
006AEE8D8  mov      w1, w20
006AEE8DC  blr      x8
006AEE8E0  ldp      x20, x19, [sp, #0x10]
006AEE8E4  mov      w0, #1
006AEE8E8  ldp      x30, x21, [sp], #0x20
006AEE8EC  ret      

