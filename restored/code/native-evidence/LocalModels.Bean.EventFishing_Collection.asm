; LocalModels.Bean.EventFishing_Collection$$readImpl
; RVA 0x6A70870; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A70870  stp      x30, x21, [sp, #-0x20]!
006A70874  stp      x20, x19, [sp, #0x10]
006A70878  adrp     x20, #0x959d000
006A7087C  adrp     x21, #0x8f37000
006A70880  ldrb     w8, [x20, #0xd9c]
006A70884  ldr      x21, [x21, #0x5a8]
006A70888  mov      x19, x0
006A7088C  tbnz     w8, #0, #0x6a708a4
006A70890  adrp     x0, #0x8f37000
006A70894  ldr      x0, [x0, #0x5a8]
006A70898  bl       #0x382bd14 ; 
006A7089C  mov      w8, #1
006A708A0  strb     w8, [x20, #0xd9c]
006A708A4  ldr      x1, [x21]
006A708A8  ldrb     w8, [x1, #0x53]
006A708AC  tbnz     w8, #5, #0x6a708fc
006A708B0  mov      x0, x19
006A708B4  mov      x1, xzr
006A708B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A708BC  adrp     x21, #0x959e000
006A708C0  ldrb     w8, [x21, #0x452]
006A708C4  mov      w20, w0
006A708C8  cbnz     w8, #0x6a708e0
006A708CC  adrp     x0, #0x8f37000
006A708D0  ldr      x0, [x0, #0x580]
006A708D4  bl       #0x382bd14 ; 
006A708D8  mov      w8, #1
006A708DC  strb     w8, [x21, #0x452]
006A708E0  adrp     x8, #0x8f37000
006A708E4  ldr      x8, [x8, #0x580]
006A708E8  ldr      x2, [x8]
006A708EC  ldrb     w8, [x2, #0x53]
006A708F0  tbnz     w8, #5, #0x6a70910
006A708F4  str      w20, [x19, #0x20]
006A708F8  b        #0x6a70920 ; 
006A708FC  ldr      x2, [x1, #0x60]
006A70900  mov      x0, x19
006A70904  ldp      x20, x19, [sp, #0x10]
006A70908  ldp      x30, x21, [sp], #0x20
006A7090C  br       x2
006A70910  ldr      x8, [x2, #0x60]
006A70914  mov      x0, x19
006A70918  mov      w1, w20
006A7091C  blr      x8
006A70920  mov      x0, x19
006A70924  mov      x1, xzr
006A70928  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A7092C  adrp     x21, #0x959e000
006A70930  ldrb     w8, [x21, #0x453]
006A70934  mov      x20, x0
006A70938  cbnz     w8, #0x6a70950
006A7093C  adrp     x0, #0x8f37000
006A70940  ldr      x0, [x0, #0x590]
006A70944  bl       #0x382bd14 ; 
006A70948  mov      w8, #1
006A7094C  strb     w8, [x21, #0x453]
006A70950  adrp     x8, #0x8f37000
006A70954  ldr      x8, [x8, #0x590]
006A70958  ldr      x2, [x8]
006A7095C  ldrb     w8, [x2, #0x53]
006A70960  tbnz     w8, #5, #0x6a70978
006A70964  mov      x0, x19
006A70968  str      x20, [x0, #0x28]!
006A7096C  mov      x1, x20
006A70970  bl       #0x382bcb8 ; 
006A70974  b        #0x6a70988 ; 
006A70978  ldr      x8, [x2, #0x60]
006A7097C  mov      x0, x19
006A70980  mov      x1, x20
006A70984  blr      x8
006A70988  mov      x0, x19
006A7098C  mov      x1, xzr
006A70990  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A70994  adrp     x21, #0x959e000
006A70998  ldrb     w8, [x21, #0x454]
006A7099C  mov      x20, x0
006A709A0  cbnz     w8, #0x6a709b8
006A709A4  adrp     x0, #0x8f37000
006A709A8  ldr      x0, [x0, #0x5a0]
006A709AC  bl       #0x382bd14 ; 
006A709B0  mov      w8, #1
006A709B4  strb     w8, [x21, #0x454]
006A709B8  adrp     x8, #0x8f37000
006A709BC  ldr      x8, [x8, #0x5a0]
006A709C0  ldr      x2, [x8]
006A709C4  ldrb     w8, [x2, #0x53]
006A709C8  tbnz     w8, #5, #0x6a709e0
006A709CC  str      x20, [x19, #0x30]!
006A709D0  mov      x0, x19
006A709D4  mov      x1, x20
006A709D8  bl       #0x382bcb8 ; 
006A709DC  b        #0x6a709f0 ; 
006A709E0  ldr      x8, [x2, #0x60]
006A709E4  mov      x0, x19
006A709E8  mov      x1, x20
006A709EC  blr      x8
006A709F0  ldp      x20, x19, [sp, #0x10]
006A709F4  mov      w0, #1
006A709F8  ldp      x30, x21, [sp], #0x20
006A709FC  ret      

