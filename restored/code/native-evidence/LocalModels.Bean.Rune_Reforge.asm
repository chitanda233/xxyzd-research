; LocalModels.Bean.Rune_Reforge$$readImpl
; RVA 0x6AE4488; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE4488  stp      x30, x21, [sp, #-0x20]!
006AE448C  stp      x20, x19, [sp, #0x10]
006AE4490  adrp     x20, #0x959e000
006AE4494  adrp     x21, #0x8f3c000
006AE4498  ldrb     w8, [x20, #0xd1b]
006AE449C  ldr      x21, [x21, #0xca8]
006AE44A0  mov      x19, x0
006AE44A4  tbnz     w8, #0, #0x6ae44bc
006AE44A8  adrp     x0, #0x8f3c000
006AE44AC  ldr      x0, [x0, #0xca8]
006AE44B0  bl       #0x382bd14 ; 
006AE44B4  mov      w8, #1
006AE44B8  strb     w8, [x20, #0xd1b]
006AE44BC  ldr      x1, [x21]
006AE44C0  ldrb     w8, [x1, #0x53]
006AE44C4  tbnz     w8, #5, #0x6ae4514
006AE44C8  mov      x0, x19
006AE44CC  mov      x1, xzr
006AE44D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE44D4  adrp     x21, #0x959f000
006AE44D8  ldrb     w8, [x21, #0x1bf]
006AE44DC  mov      w20, w0
006AE44E0  cbnz     w8, #0x6ae44f8
006AE44E4  adrp     x0, #0x8f3c000
006AE44E8  ldr      x0, [x0, #0xc80]
006AE44EC  bl       #0x382bd14 ; 
006AE44F0  mov      w8, #1
006AE44F4  strb     w8, [x21, #0x1bf]
006AE44F8  adrp     x8, #0x8f3c000
006AE44FC  ldr      x8, [x8, #0xc80]
006AE4500  ldr      x2, [x8]
006AE4504  ldrb     w8, [x2, #0x53]
006AE4508  tbnz     w8, #5, #0x6ae4528
006AE450C  str      w20, [x19, #0x20]
006AE4510  b        #0x6ae4538 ; 
006AE4514  ldr      x2, [x1, #0x60]
006AE4518  mov      x0, x19
006AE451C  ldp      x20, x19, [sp, #0x10]
006AE4520  ldp      x30, x21, [sp], #0x20
006AE4524  br       x2
006AE4528  ldr      x8, [x2, #0x60]
006AE452C  mov      x0, x19
006AE4530  mov      w1, w20
006AE4534  blr      x8
006AE4538  mov      x0, x19
006AE453C  mov      x1, xzr
006AE4540  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE4544  adrp     x21, #0x959f000
006AE4548  ldrb     w8, [x21, #0x1c0]
006AE454C  mov      w20, w0
006AE4550  cbnz     w8, #0x6ae4568
006AE4554  adrp     x0, #0x8f3c000
006AE4558  ldr      x0, [x0, #0xc90]
006AE455C  bl       #0x382bd14 ; 
006AE4560  mov      w8, #1
006AE4564  strb     w8, [x21, #0x1c0]
006AE4568  adrp     x8, #0x8f3c000
006AE456C  ldr      x8, [x8, #0xc90]
006AE4570  ldr      x2, [x8]
006AE4574  ldrb     w8, [x2, #0x53]
006AE4578  tbnz     w8, #5, #0x6ae4584
006AE457C  str      w20, [x19, #0x24]
006AE4580  b        #0x6ae4594 ; 
006AE4584  ldr      x8, [x2, #0x60]
006AE4588  mov      x0, x19
006AE458C  mov      w1, w20
006AE4590  blr      x8
006AE4594  mov      x0, x19
006AE4598  mov      x1, xzr
006AE459C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AE45A0  adrp     x21, #0x959f000
006AE45A4  ldrb     w8, [x21, #0x1c1]
006AE45A8  mov      x20, x0
006AE45AC  cbnz     w8, #0x6ae45c4
006AE45B0  adrp     x0, #0x8f3c000
006AE45B4  ldr      x0, [x0, #0xca0]
006AE45B8  bl       #0x382bd14 ; 
006AE45BC  mov      w8, #1
006AE45C0  strb     w8, [x21, #0x1c1]
006AE45C4  adrp     x8, #0x8f3c000
006AE45C8  ldr      x8, [x8, #0xca0]
006AE45CC  ldr      x2, [x8]
006AE45D0  ldrb     w8, [x2, #0x53]
006AE45D4  tbnz     w8, #5, #0x6ae45ec
006AE45D8  str      x20, [x19, #0x28]!
006AE45DC  mov      x0, x19
006AE45E0  mov      x1, x20
006AE45E4  bl       #0x382bcb8 ; 
006AE45E8  b        #0x6ae45fc ; 
006AE45EC  ldr      x8, [x2, #0x60]
006AE45F0  mov      x0, x19
006AE45F4  mov      x1, x20
006AE45F8  blr      x8
006AE45FC  ldp      x20, x19, [sp, #0x10]
006AE4600  mov      w0, #1
006AE4604  ldp      x30, x21, [sp], #0x20
006AE4608  ret      

