; LocalModels.Bean.Guild_guildDonation$$readImpl
; RVA 0x6A90710; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A90710  stp      x30, x21, [sp, #-0x20]!
006A90714  stp      x20, x19, [sp, #0x10]
006A90718  adrp     x20, #0x959e000
006A9071C  adrp     x21, #0x8f38000
006A90720  ldrb     w8, [x20, #0xf3]
006A90724  ldr      x21, [x21, #0xde0]
006A90728  mov      x19, x0
006A9072C  tbnz     w8, #0, #0x6a90744
006A90730  adrp     x0, #0x8f38000
006A90734  ldr      x0, [x0, #0xde0]
006A90738  bl       #0x382bd14 ; 
006A9073C  mov      w8, #1
006A90740  strb     w8, [x20, #0xf3]
006A90744  ldr      x1, [x21]
006A90748  ldrb     w8, [x1, #0x53]
006A9074C  tbnz     w8, #5, #0x6a9079c
006A90750  mov      x0, x19
006A90754  mov      x1, xzr
006A90758  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9075C  adrp     x21, #0x959e000
006A90760  ldrb     w8, [x21, #0x5a9]
006A90764  mov      w20, w0
006A90768  cbnz     w8, #0x6a90780
006A9076C  adrp     x0, #0x8f38000
006A90770  ldr      x0, [x0, #0xd98]
006A90774  bl       #0x382bd14 ; 
006A90778  mov      w8, #1
006A9077C  strb     w8, [x21, #0x5a9]
006A90780  adrp     x8, #0x8f38000
006A90784  ldr      x8, [x8, #0xd98]
006A90788  ldr      x2, [x8]
006A9078C  ldrb     w8, [x2, #0x53]
006A90790  tbnz     w8, #5, #0x6a907b0
006A90794  str      w20, [x19, #0x20]
006A90798  b        #0x6a907c0 ; 
006A9079C  ldr      x2, [x1, #0x60]
006A907A0  mov      x0, x19
006A907A4  ldp      x20, x19, [sp, #0x10]
006A907A8  ldp      x30, x21, [sp], #0x20
006A907AC  br       x2
006A907B0  ldr      x8, [x2, #0x60]
006A907B4  mov      x0, x19
006A907B8  mov      w1, w20
006A907BC  blr      x8
006A907C0  mov      x0, x19
006A907C4  mov      x1, xzr
006A907C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A907CC  adrp     x21, #0x959e000
006A907D0  ldrb     w8, [x21, #0x5aa]
006A907D4  mov      w20, w0
006A907D8  cbnz     w8, #0x6a907f0
006A907DC  adrp     x0, #0x8f38000
006A907E0  ldr      x0, [x0, #0xda8]
006A907E4  bl       #0x382bd14 ; 
006A907E8  mov      w8, #1
006A907EC  strb     w8, [x21, #0x5aa]
006A907F0  adrp     x8, #0x8f38000
006A907F4  ldr      x8, [x8, #0xda8]
006A907F8  ldr      x2, [x8]
006A907FC  ldrb     w8, [x2, #0x53]
006A90800  tbnz     w8, #5, #0x6a9080c
006A90804  str      w20, [x19, #0x24]
006A90808  b        #0x6a9081c ; 
006A9080C  ldr      x8, [x2, #0x60]
006A90810  mov      x0, x19
006A90814  mov      w1, w20
006A90818  blr      x8
006A9081C  mov      x0, x19
006A90820  mov      x1, xzr
006A90824  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A90828  adrp     x21, #0x959e000
006A9082C  ldrb     w8, [x21, #0x5ab]
006A90830  mov      x20, x0
006A90834  cbnz     w8, #0x6a9084c
006A90838  adrp     x0, #0x8f38000
006A9083C  ldr      x0, [x0, #0xdb8]
006A90840  bl       #0x382bd14 ; 
006A90844  mov      w8, #1
006A90848  strb     w8, [x21, #0x5ab]
006A9084C  adrp     x8, #0x8f38000
006A90850  ldr      x8, [x8, #0xdb8]
006A90854  ldr      x2, [x8]
006A90858  ldrb     w8, [x2, #0x53]
006A9085C  tbnz     w8, #5, #0x6a90874
006A90860  mov      x0, x19
006A90864  str      x20, [x0, #0x28]!
006A90868  mov      x1, x20
006A9086C  bl       #0x382bcb8 ; 
006A90870  b        #0x6a90884 ; 
006A90874  ldr      x8, [x2, #0x60]
006A90878  mov      x0, x19
006A9087C  mov      x1, x20
006A90880  blr      x8
006A90884  mov      x0, x19
006A90888  mov      x1, xzr
006A9088C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A90890  adrp     x21, #0x959e000
006A90894  ldrb     w8, [x21, #0x5ac]
006A90898  mov      x20, x0
006A9089C  cbnz     w8, #0x6a908b4
006A908A0  adrp     x0, #0x8f38000
006A908A4  ldr      x0, [x0, #0xdc8]
006A908A8  bl       #0x382bd14 ; 
006A908AC  mov      w8, #1
006A908B0  strb     w8, [x21, #0x5ac]
006A908B4  adrp     x8, #0x8f38000
006A908B8  ldr      x8, [x8, #0xdc8]
006A908BC  ldr      x2, [x8]
006A908C0  ldrb     w8, [x2, #0x53]
006A908C4  tbnz     w8, #5, #0x6a908dc
006A908C8  mov      x0, x19
006A908CC  str      x20, [x0, #0x30]!
006A908D0  mov      x1, x20
006A908D4  bl       #0x382bcb8 ; 
006A908D8  b        #0x6a908ec ; 
006A908DC  ldr      x8, [x2, #0x60]
006A908E0  mov      x0, x19
006A908E4  mov      x1, x20
006A908E8  blr      x8
006A908EC  mov      x0, x19
006A908F0  mov      x1, xzr
006A908F4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A908F8  adrp     x21, #0x959e000
006A908FC  ldrb     w8, [x21, #0x5ad]
006A90900  mov      x20, x0
006A90904  cbnz     w8, #0x6a9091c
006A90908  adrp     x0, #0x8f38000
006A9090C  ldr      x0, [x0, #0xdd8]
006A90910  bl       #0x382bd14 ; 
006A90914  mov      w8, #1
006A90918  strb     w8, [x21, #0x5ad]
006A9091C  adrp     x8, #0x8f38000
006A90920  ldr      x8, [x8, #0xdd8]
006A90924  ldr      x2, [x8]
006A90928  ldrb     w8, [x2, #0x53]
006A9092C  tbnz     w8, #5, #0x6a90944
006A90930  str      x20, [x19, #0x38]!
006A90934  mov      x0, x19
006A90938  mov      x1, x20
006A9093C  bl       #0x382bcb8 ; 
006A90940  b        #0x6a90954 ; 
006A90944  ldr      x8, [x2, #0x60]
006A90948  mov      x0, x19
006A9094C  mov      x1, x20
006A90950  blr      x8
006A90954  ldp      x20, x19, [sp, #0x10]
006A90958  mov      w0, #1
006A9095C  ldp      x30, x21, [sp], #0x20
006A90960  ret      

