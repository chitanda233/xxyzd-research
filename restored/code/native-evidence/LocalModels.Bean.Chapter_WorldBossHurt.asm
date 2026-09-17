; LocalModels.Bean.Chapter_WorldBossHurt$$readImpl
; RVA 0x68BD680; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068BD680  stp      x30, x21, [sp, #-0x20]!
0068BD684  stp      x20, x19, [sp, #0x10]
0068BD688  adrp     x20, #0x959c000
0068BD68C  adrp     x21, #0x8f27000
0068BD690  ldrb     w8, [x20, #0x1b9]
0068BD694  ldr      x21, [x21, #0x938]
0068BD698  mov      x19, x0
0068BD69C  tbnz     w8, #0, #0x68bd6b4
0068BD6A0  adrp     x0, #0x8f27000
0068BD6A4  ldr      x0, [x0, #0x938]
0068BD6A8  bl       #0x382bd14 ; 
0068BD6AC  mov      w8, #1
0068BD6B0  strb     w8, [x20, #0x1b9]
0068BD6B4  ldr      x1, [x21]
0068BD6B8  ldrb     w8, [x1, #0x53]
0068BD6BC  tbnz     w8, #5, #0x68bd70c
0068BD6C0  mov      x0, x19
0068BD6C4  mov      x1, xzr
0068BD6C8  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
0068BD6CC  adrp     x21, #0x959c000
0068BD6D0  ldrb     w8, [x21, #0x67e]
0068BD6D4  mov      x20, x0
0068BD6D8  cbnz     w8, #0x68bd6f0
0068BD6DC  adrp     x0, #0x8f27000
0068BD6E0  ldr      x0, [x0, #0x920]
0068BD6E4  bl       #0x382bd14 ; 
0068BD6E8  mov      w8, #1
0068BD6EC  strb     w8, [x21, #0x67e]
0068BD6F0  adrp     x8, #0x8f27000
0068BD6F4  ldr      x8, [x8, #0x920]
0068BD6F8  ldr      x2, [x8]
0068BD6FC  ldrb     w8, [x2, #0x53]
0068BD700  tbnz     w8, #5, #0x68bd720
0068BD704  str      x20, [x19, #0x20]
0068BD708  b        #0x68bd730 ; 
0068BD70C  ldr      x2, [x1, #0x60]
0068BD710  mov      x0, x19
0068BD714  ldp      x20, x19, [sp, #0x10]
0068BD718  ldp      x30, x21, [sp], #0x20
0068BD71C  br       x2
0068BD720  ldr      x8, [x2, #0x60]
0068BD724  mov      x0, x19
0068BD728  mov      x1, x20
0068BD72C  blr      x8
0068BD730  mov      x0, x19
0068BD734  mov      x1, xzr
0068BD738  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BD73C  adrp     x21, #0x959c000
0068BD740  ldrb     w8, [x21, #0x67f]
0068BD744  mov      w20, w0
0068BD748  cbnz     w8, #0x68bd760
0068BD74C  adrp     x0, #0x8f27000
0068BD750  ldr      x0, [x0, #0x930]
0068BD754  bl       #0x382bd14 ; 
0068BD758  mov      w8, #1
0068BD75C  strb     w8, [x21, #0x67f]
0068BD760  adrp     x8, #0x8f27000
0068BD764  ldr      x8, [x8, #0x930]
0068BD768  ldr      x2, [x8]
0068BD76C  ldrb     w8, [x2, #0x53]
0068BD770  tbnz     w8, #5, #0x68bd77c
0068BD774  str      w20, [x19, #0x28]
0068BD778  b        #0x68bd78c ; 
0068BD77C  ldr      x8, [x2, #0x60]
0068BD780  mov      x0, x19
0068BD784  mov      w1, w20
0068BD788  blr      x8
0068BD78C  ldp      x20, x19, [sp, #0x10]
0068BD790  mov      w0, #1
0068BD794  ldp      x30, x21, [sp], #0x20
0068BD798  ret      

