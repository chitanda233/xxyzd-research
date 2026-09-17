; LocalModels.Bean.Collection_Rune$$readImpl
; RVA 0x68CB588; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CB588  stp      x30, x21, [sp, #-0x20]!
0068CB58C  stp      x20, x19, [sp, #0x10]
0068CB590  adrp     x20, #0x959c000
0068CB594  adrp     x21, #0x8f28000
0068CB598  ldrb     w8, [x20, #0x328]
0068CB59C  ldr      x21, [x21, #0x2d8]
0068CB5A0  mov      x19, x0
0068CB5A4  tbnz     w8, #0, #0x68cb5bc
0068CB5A8  adrp     x0, #0x8f28000
0068CB5AC  ldr      x0, [x0, #0x2d8]
0068CB5B0  bl       #0x382bd14 ; 
0068CB5B4  mov      w8, #1
0068CB5B8  strb     w8, [x20, #0x328]
0068CB5BC  ldr      x1, [x21]
0068CB5C0  ldrb     w8, [x1, #0x53]
0068CB5C4  tbnz     w8, #5, #0x68cb614
0068CB5C8  mov      x0, x19
0068CB5CC  mov      x1, xzr
0068CB5D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CB5D4  adrp     x21, #0x959c000
0068CB5D8  ldrb     w8, [x21, #0x71d]
0068CB5DC  mov      w20, w0
0068CB5E0  cbnz     w8, #0x68cb5f8
0068CB5E4  adrp     x0, #0x8f28000
0068CB5E8  ldr      x0, [x0, #0x2a0]
0068CB5EC  bl       #0x382bd14 ; 
0068CB5F0  mov      w8, #1
0068CB5F4  strb     w8, [x21, #0x71d]
0068CB5F8  adrp     x8, #0x8f28000
0068CB5FC  ldr      x8, [x8, #0x2a0]
0068CB600  ldr      x2, [x8]
0068CB604  ldrb     w8, [x2, #0x53]
0068CB608  tbnz     w8, #5, #0x68cb628
0068CB60C  str      w20, [x19, #0x20]
0068CB610  b        #0x68cb638 ; 
0068CB614  ldr      x2, [x1, #0x60]
0068CB618  mov      x0, x19
0068CB61C  ldp      x20, x19, [sp, #0x10]
0068CB620  ldp      x30, x21, [sp], #0x20
0068CB624  br       x2
0068CB628  ldr      x8, [x2, #0x60]
0068CB62C  mov      x0, x19
0068CB630  mov      w1, w20
0068CB634  blr      x8
0068CB638  mov      x0, x19
0068CB63C  mov      x1, xzr
0068CB640  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CB644  adrp     x21, #0x959c000
0068CB648  ldrb     w8, [x21, #0x71e]
0068CB64C  mov      w20, w0
0068CB650  cbnz     w8, #0x68cb668
0068CB654  adrp     x0, #0x8f28000
0068CB658  ldr      x0, [x0, #0x2b0]
0068CB65C  bl       #0x382bd14 ; 
0068CB660  mov      w8, #1
0068CB664  strb     w8, [x21, #0x71e]
0068CB668  adrp     x8, #0x8f28000
0068CB66C  ldr      x8, [x8, #0x2b0]
0068CB670  ldr      x2, [x8]
0068CB674  ldrb     w8, [x2, #0x53]
0068CB678  tbnz     w8, #5, #0x68cb684
0068CB67C  str      w20, [x19, #0x24]
0068CB680  b        #0x68cb694 ; 
0068CB684  ldr      x8, [x2, #0x60]
0068CB688  mov      x0, x19
0068CB68C  mov      w1, w20
0068CB690  blr      x8
0068CB694  mov      x0, x19
0068CB698  mov      x1, xzr
0068CB69C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CB6A0  adrp     x21, #0x959c000
0068CB6A4  ldrb     w8, [x21, #0x71f]
0068CB6A8  mov      x20, x0
0068CB6AC  cbnz     w8, #0x68cb6c4
0068CB6B0  adrp     x0, #0x8f28000
0068CB6B4  ldr      x0, [x0, #0x2c0]
0068CB6B8  bl       #0x382bd14 ; 
0068CB6BC  mov      w8, #1
0068CB6C0  strb     w8, [x21, #0x71f]
0068CB6C4  adrp     x8, #0x8f28000
0068CB6C8  ldr      x8, [x8, #0x2c0]
0068CB6CC  ldr      x2, [x8]
0068CB6D0  ldrb     w8, [x2, #0x53]
0068CB6D4  tbnz     w8, #5, #0x68cb6ec
0068CB6D8  mov      x0, x19
0068CB6DC  str      x20, [x0, #0x28]!
0068CB6E0  mov      x1, x20
0068CB6E4  bl       #0x382bcb8 ; 
0068CB6E8  b        #0x68cb6fc ; 
0068CB6EC  ldr      x8, [x2, #0x60]
0068CB6F0  mov      x0, x19
0068CB6F4  mov      x1, x20
0068CB6F8  blr      x8
0068CB6FC  mov      x0, x19
0068CB700  mov      x1, xzr
0068CB704  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068CB708  adrp     x21, #0x959c000
0068CB70C  ldrb     w8, [x21, #0x720]
0068CB710  mov      x20, x0
0068CB714  cbnz     w8, #0x68cb72c
0068CB718  adrp     x0, #0x8f28000
0068CB71C  ldr      x0, [x0, #0x2d0]
0068CB720  bl       #0x382bd14 ; 
0068CB724  mov      w8, #1
0068CB728  strb     w8, [x21, #0x720]
0068CB72C  adrp     x8, #0x8f28000
0068CB730  ldr      x8, [x8, #0x2d0]
0068CB734  ldr      x2, [x8]
0068CB738  ldrb     w8, [x2, #0x53]
0068CB73C  tbnz     w8, #5, #0x68cb754
0068CB740  str      x20, [x19, #0x30]!
0068CB744  mov      x0, x19
0068CB748  mov      x1, x20
0068CB74C  bl       #0x382bcb8 ; 
0068CB750  b        #0x68cb764 ; 
0068CB754  ldr      x8, [x2, #0x60]
0068CB758  mov      x0, x19
0068CB75C  mov      x1, x20
0068CB760  blr      x8
0068CB764  ldp      x20, x19, [sp, #0x10]
0068CB768  mov      w0, #1
0068CB76C  ldp      x30, x21, [sp], #0x20
0068CB770  ret      

