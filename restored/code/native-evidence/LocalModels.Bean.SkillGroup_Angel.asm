; LocalModels.Bean.SkillGroup_Angel$$readImpl
; RVA 0x6AF439C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF439C  stp      x30, x21, [sp, #-0x20]!
006AF43A0  stp      x20, x19, [sp, #0x10]
006AF43A4  adrp     x20, #0x959e000
006AF43A8  adrp     x21, #0x8f3d000
006AF43AC  ldrb     w8, [x20, #0xec4]
006AF43B0  ldr      x21, [x21, #0x900]
006AF43B4  mov      x19, x0
006AF43B8  tbnz     w8, #0, #0x6af43d0
006AF43BC  adrp     x0, #0x8f3d000
006AF43C0  ldr      x0, [x0, #0x900]
006AF43C4  bl       #0x382bd14 ; 
006AF43C8  mov      w8, #1
006AF43CC  strb     w8, [x20, #0xec4]
006AF43D0  ldr      x1, [x21]
006AF43D4  ldrb     w8, [x1, #0x53]
006AF43D8  tbnz     w8, #5, #0x6af4428
006AF43DC  mov      x0, x19
006AF43E0  mov      x1, xzr
006AF43E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF43E8  adrp     x21, #0x959f000
006AF43EC  ldrb     w8, [x21, #0x26e]
006AF43F0  mov      w20, w0
006AF43F4  cbnz     w8, #0x6af440c
006AF43F8  adrp     x0, #0x8f3d000
006AF43FC  ldr      x0, [x0, #0x8e0]
006AF4400  bl       #0x382bd14 ; 
006AF4404  mov      w8, #1
006AF4408  strb     w8, [x21, #0x26e]
006AF440C  adrp     x8, #0x8f3d000
006AF4410  ldr      x8, [x8, #0x8e0]
006AF4414  ldr      x2, [x8]
006AF4418  ldrb     w8, [x2, #0x53]
006AF441C  tbnz     w8, #5, #0x6af443c
006AF4420  str      w20, [x19, #0x20]
006AF4424  b        #0x6af444c ; 
006AF4428  ldr      x2, [x1, #0x60]
006AF442C  mov      x0, x19
006AF4430  ldp      x20, x19, [sp, #0x10]
006AF4434  ldp      x30, x21, [sp], #0x20
006AF4438  br       x2
006AF443C  ldr      x8, [x2, #0x60]
006AF4440  mov      x0, x19
006AF4444  mov      w1, w20
006AF4448  blr      x8
006AF444C  mov      x0, x19
006AF4450  mov      x1, xzr
006AF4454  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF4458  adrp     x21, #0x959f000
006AF445C  ldrb     w8, [x21, #0x26f]
006AF4460  mov      w20, w0
006AF4464  cbnz     w8, #0x6af447c
006AF4468  adrp     x0, #0x8f3d000
006AF446C  ldr      x0, [x0, #0x8e8]
006AF4470  bl       #0x382bd14 ; 
006AF4474  mov      w8, #1
006AF4478  strb     w8, [x21, #0x26f]
006AF447C  adrp     x8, #0x8f3d000
006AF4480  ldr      x8, [x8, #0x8e8]
006AF4484  ldr      x2, [x8]
006AF4488  ldrb     w8, [x2, #0x53]
006AF448C  tbnz     w8, #5, #0x6af4498
006AF4490  str      w20, [x19, #0x24]
006AF4494  b        #0x6af44a8 ; 
006AF4498  ldr      x8, [x2, #0x60]
006AF449C  mov      x0, x19
006AF44A0  mov      w1, w20
006AF44A4  blr      x8
006AF44A8  mov      x0, x19
006AF44AC  mov      x1, xzr
006AF44B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF44B4  adrp     x21, #0x959f000
006AF44B8  ldrb     w8, [x21, #0x270]
006AF44BC  mov      w20, w0
006AF44C0  cbnz     w8, #0x6af44d8
006AF44C4  adrp     x0, #0x8f3d000
006AF44C8  ldr      x0, [x0, #0x8f8]
006AF44CC  bl       #0x382bd14 ; 
006AF44D0  mov      w8, #1
006AF44D4  strb     w8, [x21, #0x270]
006AF44D8  adrp     x8, #0x8f3d000
006AF44DC  ldr      x8, [x8, #0x8f8]
006AF44E0  ldr      x2, [x8]
006AF44E4  ldrb     w8, [x2, #0x53]
006AF44E8  tbnz     w8, #5, #0x6af44f4
006AF44EC  str      w20, [x19, #0x28]
006AF44F0  b        #0x6af4504 ; 
006AF44F4  ldr      x8, [x2, #0x60]
006AF44F8  mov      x0, x19
006AF44FC  mov      w1, w20
006AF4500  blr      x8
006AF4504  ldp      x20, x19, [sp, #0x10]
006AF4508  mov      w0, #1
006AF450C  ldp      x30, x21, [sp], #0x20
006AF4510  ret      

