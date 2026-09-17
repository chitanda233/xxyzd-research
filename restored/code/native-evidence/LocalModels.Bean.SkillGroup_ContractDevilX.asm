; LocalModels.Bean.SkillGroup_ContractDevilX$$readImpl
; RVA 0x6AF71F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF71F8  stp      x30, x21, [sp, #-0x20]!
006AF71FC  stp      x20, x19, [sp, #0x10]
006AF7200  adrp     x20, #0x959f000
006AF7204  adrp     x21, #0x8f3d000
006AF7208  ldrb     w8, [x20, #0x2a5]
006AF720C  ldr      x21, [x21, #0xb28]
006AF7210  mov      x19, x0
006AF7214  tbnz     w8, #0, #0x6af722c
006AF7218  adrp     x0, #0x8f3d000
006AF721C  ldr      x0, [x0, #0xb28]
006AF7220  bl       #0x382bd14 ; 
006AF7224  mov      w8, #1
006AF7228  strb     w8, [x20, #0x2a5]
006AF722C  ldr      x1, [x21]
006AF7230  ldrb     w8, [x1, #0x53]
006AF7234  tbnz     w8, #5, #0x6af7284
006AF7238  mov      x0, x19
006AF723C  mov      x1, xzr
006AF7240  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF7244  adrp     x21, #0x959f000
006AF7248  ldrb     w8, [x21, #0x86e]
006AF724C  mov      w20, w0
006AF7250  cbnz     w8, #0x6af7268
006AF7254  adrp     x0, #0x8f3d000
006AF7258  ldr      x0, [x0, #0xb00]
006AF725C  bl       #0x382bd14 ; 
006AF7260  mov      w8, #1
006AF7264  strb     w8, [x21, #0x86e]
006AF7268  adrp     x8, #0x8f3d000
006AF726C  ldr      x8, [x8, #0xb00]
006AF7270  ldr      x2, [x8]
006AF7274  ldrb     w8, [x2, #0x53]
006AF7278  tbnz     w8, #5, #0x6af7298
006AF727C  str      w20, [x19, #0x20]
006AF7280  b        #0x6af72a8 ; 
006AF7284  ldr      x2, [x1, #0x60]
006AF7288  mov      x0, x19
006AF728C  ldp      x20, x19, [sp, #0x10]
006AF7290  ldp      x30, x21, [sp], #0x20
006AF7294  br       x2
006AF7298  ldr      x8, [x2, #0x60]
006AF729C  mov      x0, x19
006AF72A0  mov      w1, w20
006AF72A4  blr      x8
006AF72A8  mov      x0, x19
006AF72AC  mov      x1, xzr
006AF72B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF72B4  adrp     x21, #0x959f000
006AF72B8  ldrb     w8, [x21, #0x86f]
006AF72BC  mov      w20, w0
006AF72C0  cbnz     w8, #0x6af72d8
006AF72C4  adrp     x0, #0x8f3d000
006AF72C8  ldr      x0, [x0, #0xb10]
006AF72CC  bl       #0x382bd14 ; 
006AF72D0  mov      w8, #1
006AF72D4  strb     w8, [x21, #0x86f]
006AF72D8  adrp     x8, #0x8f3d000
006AF72DC  ldr      x8, [x8, #0xb10]
006AF72E0  ldr      x2, [x8]
006AF72E4  ldrb     w8, [x2, #0x53]
006AF72E8  tbnz     w8, #5, #0x6af72f4
006AF72EC  str      w20, [x19, #0x24]
006AF72F0  b        #0x6af7304 ; 
006AF72F4  ldr      x8, [x2, #0x60]
006AF72F8  mov      x0, x19
006AF72FC  mov      w1, w20
006AF7300  blr      x8
006AF7304  mov      x0, x19
006AF7308  mov      x1, xzr
006AF730C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF7310  adrp     x21, #0x959f000
006AF7314  ldrb     w8, [x21, #0x870]
006AF7318  mov      w20, w0
006AF731C  cbnz     w8, #0x6af7334
006AF7320  adrp     x0, #0x8f3d000
006AF7324  ldr      x0, [x0, #0xb20]
006AF7328  bl       #0x382bd14 ; 
006AF732C  mov      w8, #1
006AF7330  strb     w8, [x21, #0x870]
006AF7334  adrp     x8, #0x8f3d000
006AF7338  ldr      x8, [x8, #0xb20]
006AF733C  ldr      x2, [x8]
006AF7340  ldrb     w8, [x2, #0x53]
006AF7344  tbnz     w8, #5, #0x6af7350
006AF7348  str      w20, [x19, #0x28]
006AF734C  b        #0x6af7360 ; 
006AF7350  ldr      x8, [x2, #0x60]
006AF7354  mov      x0, x19
006AF7358  mov      w1, w20
006AF735C  blr      x8
006AF7360  ldp      x20, x19, [sp, #0x10]
006AF7364  mov      w0, #1
006AF7368  ldp      x30, x21, [sp], #0x20
006AF736C  ret      

