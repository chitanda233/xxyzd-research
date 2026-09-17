; LocalModels.Bean.Chapter_MissionReward$$readImpl
; RVA 0x68B42BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B42BC  stp      x30, x21, [sp, #-0x20]!
0068B42C0  stp      x20, x19, [sp, #0x10]
0068B42C4  adrp     x20, #0x959c000
0068B42C8  adrp     x21, #0x8f27000
0068B42CC  ldrb     w8, [x20, #0xcc]
0068B42D0  ldr      x21, [x21, #0x238]
0068B42D4  mov      x19, x0
0068B42D8  tbnz     w8, #0, #0x68b42f0
0068B42DC  adrp     x0, #0x8f27000
0068B42E0  ldr      x0, [x0, #0x238]
0068B42E4  bl       #0x382bd14 ; 
0068B42E8  mov      w8, #1
0068B42EC  strb     w8, [x20, #0xcc]
0068B42F0  ldr      x1, [x21]
0068B42F4  ldrb     w8, [x1, #0x53]
0068B42F8  tbnz     w8, #5, #0x68b4348
0068B42FC  mov      x0, x19
0068B4300  mov      x1, xzr
0068B4304  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B4308  adrp     x21, #0x959c000
0068B430C  ldrb     w8, [x21, #0x607]
0068B4310  mov      w20, w0
0068B4314  cbnz     w8, #0x68b432c
0068B4318  adrp     x0, #0x8f27000
0068B431C  ldr      x0, [x0, #0x1e0]
0068B4320  bl       #0x382bd14 ; 
0068B4324  mov      w8, #1
0068B4328  strb     w8, [x21, #0x607]
0068B432C  adrp     x8, #0x8f27000
0068B4330  ldr      x8, [x8, #0x1e0]
0068B4334  ldr      x2, [x8]
0068B4338  ldrb     w8, [x2, #0x53]
0068B433C  tbnz     w8, #5, #0x68b435c
0068B4340  str      w20, [x19, #0x20]
0068B4344  b        #0x68b436c ; 
0068B4348  ldr      x2, [x1, #0x60]
0068B434C  mov      x0, x19
0068B4350  ldp      x20, x19, [sp, #0x10]
0068B4354  ldp      x30, x21, [sp], #0x20
0068B4358  br       x2
0068B435C  ldr      x8, [x2, #0x60]
0068B4360  mov      x0, x19
0068B4364  mov      w1, w20
0068B4368  blr      x8
0068B436C  mov      x0, x19
0068B4370  mov      x1, xzr
0068B4374  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B4378  adrp     x21, #0x959c000
0068B437C  ldrb     w8, [x21, #0x608]
0068B4380  mov      w20, w0
0068B4384  cbnz     w8, #0x68b439c
0068B4388  adrp     x0, #0x8f27000
0068B438C  ldr      x0, [x0, #0x1f0]
0068B4390  bl       #0x382bd14 ; 
0068B4394  mov      w8, #1
0068B4398  strb     w8, [x21, #0x608]
0068B439C  adrp     x8, #0x8f27000
0068B43A0  ldr      x8, [x8, #0x1f0]
0068B43A4  ldr      x2, [x8]
0068B43A8  ldrb     w8, [x2, #0x53]
0068B43AC  tbnz     w8, #5, #0x68b43b8
0068B43B0  str      w20, [x19, #0x24]
0068B43B4  b        #0x68b43c8 ; 
0068B43B8  ldr      x8, [x2, #0x60]
0068B43BC  mov      x0, x19
0068B43C0  mov      w1, w20
0068B43C4  blr      x8
0068B43C8  mov      x0, x19
0068B43CC  mov      x1, xzr
0068B43D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B43D4  adrp     x21, #0x959c000
0068B43D8  ldrb     w8, [x21, #0x609]
0068B43DC  mov      w20, w0
0068B43E0  cbnz     w8, #0x68b43f8
0068B43E4  adrp     x0, #0x8f27000
0068B43E8  ldr      x0, [x0, #0x200]
0068B43EC  bl       #0x382bd14 ; 
0068B43F0  mov      w8, #1
0068B43F4  strb     w8, [x21, #0x609]
0068B43F8  adrp     x8, #0x8f27000
0068B43FC  ldr      x8, [x8, #0x200]
0068B4400  ldr      x2, [x8]
0068B4404  ldrb     w8, [x2, #0x53]
0068B4408  tbnz     w8, #5, #0x68b4414
0068B440C  str      w20, [x19, #0x28]
0068B4410  b        #0x68b4424 ; 
0068B4414  ldr      x8, [x2, #0x60]
0068B4418  mov      x0, x19
0068B441C  mov      w1, w20
0068B4420  blr      x8
0068B4424  mov      x0, x19
0068B4428  mov      x1, xzr
0068B442C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B4430  adrp     x21, #0x959c000
0068B4434  ldrb     w8, [x21, #0x60a]
0068B4438  mov      w20, w0
0068B443C  cbnz     w8, #0x68b4454
0068B4440  adrp     x0, #0x8f27000
0068B4444  ldr      x0, [x0, #0x210]
0068B4448  bl       #0x382bd14 ; 
0068B444C  mov      w8, #1
0068B4450  strb     w8, [x21, #0x60a]
0068B4454  adrp     x8, #0x8f27000
0068B4458  ldr      x8, [x8, #0x210]
0068B445C  ldr      x2, [x8]
0068B4460  ldrb     w8, [x2, #0x53]
0068B4464  tbnz     w8, #5, #0x68b4470
0068B4468  str      w20, [x19, #0x2c]
0068B446C  b        #0x68b4480 ; 
0068B4470  ldr      x8, [x2, #0x60]
0068B4474  mov      x0, x19
0068B4478  mov      w1, w20
0068B447C  blr      x8
0068B4480  mov      x0, x19
0068B4484  mov      x1, xzr
0068B4488  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B448C  adrp     x21, #0x959c000
0068B4490  ldrb     w8, [x21, #0x60b]
0068B4494  mov      w20, w0
0068B4498  cbnz     w8, #0x68b44b0
0068B449C  adrp     x0, #0x8f27000
0068B44A0  ldr      x0, [x0, #0x220]
0068B44A4  bl       #0x382bd14 ; 
0068B44A8  mov      w8, #1
0068B44AC  strb     w8, [x21, #0x60b]
0068B44B0  adrp     x8, #0x8f27000
0068B44B4  ldr      x8, [x8, #0x220]
0068B44B8  ldr      x2, [x8]
0068B44BC  ldrb     w8, [x2, #0x53]
0068B44C0  tbnz     w8, #5, #0x68b44cc
0068B44C4  str      w20, [x19, #0x30]
0068B44C8  b        #0x68b44dc ; 
0068B44CC  ldr      x8, [x2, #0x60]
0068B44D0  mov      x0, x19
0068B44D4  mov      w1, w20
0068B44D8  blr      x8
0068B44DC  mov      x0, x19
0068B44E0  mov      x1, xzr
0068B44E4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068B44E8  adrp     x21, #0x959c000
0068B44EC  ldrb     w8, [x21, #0x60c]
0068B44F0  mov      x20, x0
0068B44F4  cbnz     w8, #0x68b450c
0068B44F8  adrp     x0, #0x8f27000
0068B44FC  ldr      x0, [x0, #0x230]
0068B4500  bl       #0x382bd14 ; 
0068B4504  mov      w8, #1
0068B4508  strb     w8, [x21, #0x60c]
0068B450C  adrp     x8, #0x8f27000
0068B4510  ldr      x8, [x8, #0x230]
0068B4514  ldr      x2, [x8]
0068B4518  ldrb     w8, [x2, #0x53]
0068B451C  tbnz     w8, #5, #0x68b4534
0068B4520  str      x20, [x19, #0x38]!
0068B4524  mov      x0, x19
0068B4528  mov      x1, x20
0068B452C  bl       #0x382bcb8 ; 
0068B4530  b        #0x68b4544 ; 
0068B4534  ldr      x8, [x2, #0x60]
0068B4538  mov      x0, x19
0068B453C  mov      x1, x20
0068B4540  blr      x8
0068B4544  ldp      x20, x19, [sp, #0x10]
0068B4548  mov      w0, #1
0068B454C  ldp      x30, x21, [sp], #0x20
0068B4550  ret      

