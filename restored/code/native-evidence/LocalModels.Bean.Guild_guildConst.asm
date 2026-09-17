; LocalModels.Bean.Guild_guildConst$$readImpl
; RVA 0x6A8F5AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8F5AC  stp      x30, x21, [sp, #-0x20]!
006A8F5B0  stp      x20, x19, [sp, #0x10]
006A8F5B4  adrp     x20, #0x959e000
006A8F5B8  adrp     x21, #0x8f38000
006A8F5BC  ldrb     w8, [x20, #0xd6]
006A8F5C0  ldr      x21, [x21, #0xd10]
006A8F5C4  mov      x19, x0
006A8F5C8  tbnz     w8, #0, #0x6a8f5e0
006A8F5CC  adrp     x0, #0x8f38000
006A8F5D0  ldr      x0, [x0, #0xd10]
006A8F5D4  bl       #0x382bd14 ; 
006A8F5D8  mov      w8, #1
006A8F5DC  strb     w8, [x20, #0xd6]
006A8F5E0  ldr      x1, [x21]
006A8F5E4  ldrb     w8, [x1, #0x53]
006A8F5E8  tbnz     w8, #5, #0x6a8f638
006A8F5EC  mov      x0, x19
006A8F5F0  mov      x1, xzr
006A8F5F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8F5F8  adrp     x21, #0x959e000
006A8F5FC  ldrb     w8, [x21, #0x59e]
006A8F600  mov      w20, w0
006A8F604  cbnz     w8, #0x6a8f61c
006A8F608  adrp     x0, #0x8f38000
006A8F60C  ldr      x0, [x0, #0xcc0]
006A8F610  bl       #0x382bd14 ; 
006A8F614  mov      w8, #1
006A8F618  strb     w8, [x21, #0x59e]
006A8F61C  adrp     x8, #0x8f38000
006A8F620  ldr      x8, [x8, #0xcc0]
006A8F624  ldr      x2, [x8]
006A8F628  ldrb     w8, [x2, #0x53]
006A8F62C  tbnz     w8, #5, #0x6a8f64c
006A8F630  str      w20, [x19, #0x20]
006A8F634  b        #0x6a8f65c ; 
006A8F638  ldr      x2, [x1, #0x60]
006A8F63C  mov      x0, x19
006A8F640  ldp      x20, x19, [sp, #0x10]
006A8F644  ldp      x30, x21, [sp], #0x20
006A8F648  br       x2
006A8F64C  ldr      x8, [x2, #0x60]
006A8F650  mov      x0, x19
006A8F654  mov      w1, w20
006A8F658  blr      x8
006A8F65C  mov      x0, x19
006A8F660  mov      x1, xzr
006A8F664  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8F668  adrp     x21, #0x959e000
006A8F66C  ldrb     w8, [x21, #0x59f]
006A8F670  mov      x20, x0
006A8F674  cbnz     w8, #0x6a8f68c
006A8F678  adrp     x0, #0x8f38000
006A8F67C  ldr      x0, [x0, #0xcd0]
006A8F680  bl       #0x382bd14 ; 
006A8F684  mov      w8, #1
006A8F688  strb     w8, [x21, #0x59f]
006A8F68C  adrp     x8, #0x8f38000
006A8F690  ldr      x8, [x8, #0xcd0]
006A8F694  ldr      x2, [x8]
006A8F698  ldrb     w8, [x2, #0x53]
006A8F69C  tbnz     w8, #5, #0x6a8f6b4
006A8F6A0  mov      x0, x19
006A8F6A4  str      x20, [x0, #0x28]!
006A8F6A8  mov      x1, x20
006A8F6AC  bl       #0x382bcb8 ; 
006A8F6B0  b        #0x6a8f6c4 ; 
006A8F6B4  ldr      x8, [x2, #0x60]
006A8F6B8  mov      x0, x19
006A8F6BC  mov      x1, x20
006A8F6C0  blr      x8
006A8F6C4  mov      x0, x19
006A8F6C8  mov      x1, xzr
006A8F6CC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8F6D0  adrp     x21, #0x959e000
006A8F6D4  ldrb     w8, [x21, #0x5a0]
006A8F6D8  mov      x20, x0
006A8F6DC  cbnz     w8, #0x6a8f6f4
006A8F6E0  adrp     x0, #0x8f38000
006A8F6E4  ldr      x0, [x0, #0xce0]
006A8F6E8  bl       #0x382bd14 ; 
006A8F6EC  mov      w8, #1
006A8F6F0  strb     w8, [x21, #0x5a0]
006A8F6F4  adrp     x8, #0x8f38000
006A8F6F8  ldr      x8, [x8, #0xce0]
006A8F6FC  ldr      x2, [x8]
006A8F700  ldrb     w8, [x2, #0x53]
006A8F704  tbnz     w8, #5, #0x6a8f71c
006A8F708  mov      x0, x19
006A8F70C  str      x20, [x0, #0x30]!
006A8F710  mov      x1, x20
006A8F714  bl       #0x382bcb8 ; 
006A8F718  b        #0x6a8f72c ; 
006A8F71C  ldr      x8, [x2, #0x60]
006A8F720  mov      x0, x19
006A8F724  mov      x1, x20
006A8F728  blr      x8
006A8F72C  mov      x0, x19
006A8F730  mov      x1, xzr
006A8F734  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8F738  adrp     x21, #0x959e000
006A8F73C  ldrb     w8, [x21, #0x5a1]
006A8F740  mov      w20, w0
006A8F744  cbnz     w8, #0x6a8f75c
006A8F748  adrp     x0, #0x8f38000
006A8F74C  ldr      x0, [x0, #0xce8]
006A8F750  bl       #0x382bd14 ; 
006A8F754  mov      w8, #1
006A8F758  strb     w8, [x21, #0x5a1]
006A8F75C  adrp     x8, #0x8f38000
006A8F760  ldr      x8, [x8, #0xce8]
006A8F764  ldr      x2, [x8]
006A8F768  ldrb     w8, [x2, #0x53]
006A8F76C  tbnz     w8, #5, #0x6a8f778
006A8F770  str      w20, [x19, #0x38]
006A8F774  b        #0x6a8f788 ; 
006A8F778  ldr      x8, [x2, #0x60]
006A8F77C  mov      x0, x19
006A8F780  mov      w1, w20
006A8F784  blr      x8
006A8F788  mov      x0, x19
006A8F78C  mov      x1, xzr
006A8F790  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A8F794  adrp     x21, #0x959e000
006A8F798  ldrb     w8, [x21, #0x5a2]
006A8F79C  mov      x20, x0
006A8F7A0  cbnz     w8, #0x6a8f7b8
006A8F7A4  adrp     x0, #0x8f38000
006A8F7A8  ldr      x0, [x0, #0xcf8]
006A8F7AC  bl       #0x382bd14 ; 
006A8F7B0  mov      w8, #1
006A8F7B4  strb     w8, [x21, #0x5a2]
006A8F7B8  adrp     x8, #0x8f38000
006A8F7BC  ldr      x8, [x8, #0xcf8]
006A8F7C0  ldr      x2, [x8]
006A8F7C4  ldrb     w8, [x2, #0x53]
006A8F7C8  tbnz     w8, #5, #0x6a8f7e0
006A8F7CC  mov      x0, x19
006A8F7D0  str      x20, [x0, #0x40]!
006A8F7D4  mov      x1, x20
006A8F7D8  bl       #0x382bcb8 ; 
006A8F7DC  b        #0x6a8f7f0 ; 
006A8F7E0  ldr      x8, [x2, #0x60]
006A8F7E4  mov      x0, x19
006A8F7E8  mov      x1, x20
006A8F7EC  blr      x8
006A8F7F0  mov      x0, x19
006A8F7F4  mov      x1, xzr
006A8F7F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8F7FC  adrp     x21, #0x959e000
006A8F800  ldrb     w8, [x21, #0x5a3]
006A8F804  mov      x20, x0
006A8F808  cbnz     w8, #0x6a8f820
006A8F80C  adrp     x0, #0x8f38000
006A8F810  ldr      x0, [x0, #0xd08]
006A8F814  bl       #0x382bd14 ; 
006A8F818  mov      w8, #1
006A8F81C  strb     w8, [x21, #0x5a3]
006A8F820  adrp     x8, #0x8f38000
006A8F824  ldr      x8, [x8, #0xd08]
006A8F828  ldr      x2, [x8]
006A8F82C  ldrb     w8, [x2, #0x53]
006A8F830  tbnz     w8, #5, #0x6a8f848
006A8F834  str      x20, [x19, #0x48]!
006A8F838  mov      x0, x19
006A8F83C  mov      x1, x20
006A8F840  bl       #0x382bcb8 ; 
006A8F844  b        #0x6a8f858 ; 
006A8F848  ldr      x8, [x2, #0x60]
006A8F84C  mov      x0, x19
006A8F850  mov      x1, x20
006A8F854  blr      x8
006A8F858  ldp      x20, x19, [sp, #0x10]
006A8F85C  mov      w0, #1
006A8F860  ldp      x30, x21, [sp], #0x20
006A8F864  ret      

