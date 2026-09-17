; LocalModels.Bean.Producer_GoldProducer$$readImpl
; RVA 0x6AD4218; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD4218  stp      x30, x21, [sp, #-0x20]!
006AD421C  stp      x20, x19, [sp, #0x10]
006AD4220  adrp     x20, #0x959e000
006AD4224  adrp     x21, #0x8f3c000
006AD4228  ldrb     w8, [x20, #0xb73]
006AD422C  ldr      x21, [x21, #0xc0]
006AD4230  mov      x19, x0
006AD4234  tbnz     w8, #0, #0x6ad424c
006AD4238  adrp     x0, #0x8f3c000
006AD423C  ldr      x0, [x0, #0xc0]
006AD4240  bl       #0x382bd14 ; 
006AD4244  mov      w8, #1
006AD4248  strb     w8, [x20, #0xb73]
006AD424C  ldr      x1, [x21]
006AD4250  ldrb     w8, [x1, #0x53]
006AD4254  tbnz     w8, #5, #0x6ad42a4
006AD4258  mov      x0, x19
006AD425C  mov      x1, xzr
006AD4260  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD4264  adrp     x21, #0x959f000
006AD4268  ldrb     w8, [x21, #0x10c]
006AD426C  mov      w20, w0
006AD4270  cbnz     w8, #0x6ad4288
006AD4274  adrp     x0, #0x8f3c000
006AD4278  ldr      x0, [x0, #0x98]
006AD427C  bl       #0x382bd14 ; 
006AD4280  mov      w8, #1
006AD4284  strb     w8, [x21, #0x10c]
006AD4288  adrp     x8, #0x8f3c000
006AD428C  ldr      x8, [x8, #0x98]
006AD4290  ldr      x2, [x8]
006AD4294  ldrb     w8, [x2, #0x53]
006AD4298  tbnz     w8, #5, #0x6ad42b8
006AD429C  str      w20, [x19, #0x20]
006AD42A0  b        #0x6ad42c8 ; 
006AD42A4  ldr      x2, [x1, #0x60]
006AD42A8  mov      x0, x19
006AD42AC  ldp      x20, x19, [sp, #0x10]
006AD42B0  ldp      x30, x21, [sp], #0x20
006AD42B4  br       x2
006AD42B8  ldr      x8, [x2, #0x60]
006AD42BC  mov      x0, x19
006AD42C0  mov      w1, w20
006AD42C4  blr      x8
006AD42C8  mov      x0, x19
006AD42CC  mov      x1, xzr
006AD42D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD42D4  adrp     x21, #0x959f000
006AD42D8  ldrb     w8, [x21, #0x10d]
006AD42DC  mov      w20, w0
006AD42E0  cbnz     w8, #0x6ad42f8
006AD42E4  adrp     x0, #0x8f3c000
006AD42E8  ldr      x0, [x0, #0xa8]
006AD42EC  bl       #0x382bd14 ; 
006AD42F0  mov      w8, #1
006AD42F4  strb     w8, [x21, #0x10d]
006AD42F8  adrp     x8, #0x8f3c000
006AD42FC  ldr      x8, [x8, #0xa8]
006AD4300  ldr      x2, [x8]
006AD4304  ldrb     w8, [x2, #0x53]
006AD4308  tbnz     w8, #5, #0x6ad4314
006AD430C  str      w20, [x19, #0x24]
006AD4310  b        #0x6ad4324 ; 
006AD4314  ldr      x8, [x2, #0x60]
006AD4318  mov      x0, x19
006AD431C  mov      w1, w20
006AD4320  blr      x8
006AD4324  mov      x0, x19
006AD4328  mov      x1, xzr
006AD432C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD4330  adrp     x21, #0x959f000
006AD4334  ldrb     w8, [x21, #0x10e]
006AD4338  mov      w20, w0
006AD433C  cbnz     w8, #0x6ad4354
006AD4340  adrp     x0, #0x8f3c000
006AD4344  ldr      x0, [x0, #0xb8]
006AD4348  bl       #0x382bd14 ; 
006AD434C  mov      w8, #1
006AD4350  strb     w8, [x21, #0x10e]
006AD4354  adrp     x8, #0x8f3c000
006AD4358  ldr      x8, [x8, #0xb8]
006AD435C  ldr      x2, [x8]
006AD4360  ldrb     w8, [x2, #0x53]
006AD4364  tbnz     w8, #5, #0x6ad4370
006AD4368  str      w20, [x19, #0x28]
006AD436C  b        #0x6ad4380 ; 
006AD4370  ldr      x8, [x2, #0x60]
006AD4374  mov      x0, x19
006AD4378  mov      w1, w20
006AD437C  blr      x8
006AD4380  ldp      x20, x19, [sp, #0x10]
006AD4384  mov      w0, #1
006AD4388  ldp      x30, x21, [sp], #0x20
006AD438C  ret      

