; LocalModels.Const$$IsSkillABTestB
; RVA 0x64CB600; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CB600  str      x30, [sp, #-0x20]!
0064CB604  stp      x20, x19, [sp, #0x10]
0064CB608  adrp     x19, #0x9597000
0064CB60C  adrp     x20, #0x8efa000
0064CB610  ldrb     w8, [x19, #0xfde]
0064CB614  ldr      x20, [x20, #0x120]
0064CB618  tbnz     w8, #0, #0x64cb63c
0064CB61C  adrp     x0, #0x8efa000
0064CB620  ldr      x0, [x0, #0x120]
0064CB624  bl       #0x382bd14 ;
0064CB628  adrp     x0, #0x8ee8000
0064CB62C  ldr      x0, [x0, #0x898]
0064CB630  bl       #0x382bd14 ;
0064CB634  mov      w8, #1
0064CB638  strb     w8, [x19, #0xfde]
0064CB63C  ldr      x0, [x20]
0064CB640  ldrb     w8, [x0, #0x53]
0064CB644  tbnz     w8, #5, #0x64cb678
0064CB648  adrp     x19, #0x8ee8000
0064CB64C  ldr      x19, [x19, #0x898]
0064CB650  ldr      x0, [x19]
0064CB654  ldr      w8, [x0, #0xe0]
0064CB658  cbnz     w8, #0x64cb664
0064CB65C  bl       #0x382be8c ;
0064CB660  ldr      x0, [x19]
0064CB664  ldr      x8, [x0, #0xb8]
0064CB668  ldp      x20, x19, [sp, #0x10]
0064CB66C  ldrb     w0, [x8, #0x530]
0064CB670  ldr      x30, [sp], #0x20
0064CB674  ret
0064CB678  ldr      x1, [x0, #0x60]
0064CB67C  ldp      x20, x19, [sp, #0x10]
0064CB680  ldr      x30, [sp], #0x20
0064CB684  br       x1
