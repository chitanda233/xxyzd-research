; LocalModels.Const$$SetSkillABTest
; RVA 0x64CB56C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CB56C  stp      x30, x21, [sp, #-0x20]!
0064CB570  stp      x20, x19, [sp, #0x10]
0064CB574  adrp     x20, #0x9597000
0064CB578  adrp     x21, #0x8efa000
0064CB57C  ldrb     w8, [x20, #0xfdd]
0064CB580  ldr      x21, [x21, #0x118]
0064CB584  mov      w19, w0
0064CB588  tbnz     w8, #0, #0x64cb5ac
0064CB58C  adrp     x0, #0x8efa000
0064CB590  ldr      x0, [x0, #0x118]
0064CB594  bl       #0x382bd14 ;
0064CB598  adrp     x0, #0x8ee8000
0064CB59C  ldr      x0, [x0, #0x898]
0064CB5A0  bl       #0x382bd14 ;
0064CB5A4  mov      w8, #1
0064CB5A8  strb     w8, [x20, #0xfdd]
0064CB5AC  ldr      x1, [x21]
0064CB5B0  ldrb     w8, [x1, #0x53]
0064CB5B4  tbnz     w8, #5, #0x64cb5ec
0064CB5B8  adrp     x20, #0x8ee8000
0064CB5BC  ldr      x20, [x20, #0x898]
0064CB5C0  and      w19, w19, #1
0064CB5C4  ldr      x0, [x20]
0064CB5C8  ldr      w8, [x0, #0xe0]
0064CB5CC  cbnz     w8, #0x64cb5d8
0064CB5D0  bl       #0x382be8c ;
0064CB5D4  ldr      x0, [x20]
0064CB5D8  ldr      x8, [x0, #0xb8]
0064CB5DC  strb     w19, [x8, #0x530]
0064CB5E0  ldp      x20, x19, [sp, #0x10]
0064CB5E4  ldp      x30, x21, [sp], #0x20
0064CB5E8  ret
0064CB5EC  ldr      x2, [x1, #0x60]
0064CB5F0  and      w0, w19, #1
0064CB5F4  ldp      x20, x19, [sp, #0x10]
0064CB5F8  ldp      x30, x21, [sp], #0x20
0064CB5FC  br       x2
