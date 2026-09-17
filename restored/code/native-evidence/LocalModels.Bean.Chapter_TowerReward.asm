; LocalModels.Bean.Chapter_TowerReward$$readImpl
; RVA 0x68BA448; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068BA448  stp      x30, x21, [sp, #-0x20]!
0068BA44C  stp      x20, x19, [sp, #0x10]
0068BA450  adrp     x20, #0x959c000
0068BA454  adrp     x21, #0x8f27000
0068BA458  ldrb     w8, [x20, #0x168]
0068BA45C  ldr      x21, [x21, #0x6e0]
0068BA460  mov      x19, x0
0068BA464  tbnz     w8, #0, #0x68ba47c
0068BA468  adrp     x0, #0x8f27000
0068BA46C  ldr      x0, [x0, #0x6e0]
0068BA470  bl       #0x382bd14 ; 
0068BA474  mov      w8, #1
0068BA478  strb     w8, [x20, #0x168]
0068BA47C  ldr      x1, [x21]
0068BA480  ldrb     w8, [x1, #0x53]
0068BA484  tbnz     w8, #5, #0x68ba4d4
0068BA488  mov      x0, x19
0068BA48C  mov      x1, xzr
0068BA490  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BA494  adrp     x21, #0x959c000
0068BA498  ldrb     w8, [x21, #0x657]
0068BA49C  mov      w20, w0
0068BA4A0  cbnz     w8, #0x68ba4b8
0068BA4A4  adrp     x0, #0x8f27000
0068BA4A8  ldr      x0, [x0, #0x6a8]
0068BA4AC  bl       #0x382bd14 ; 
0068BA4B0  mov      w8, #1
0068BA4B4  strb     w8, [x21, #0x657]
0068BA4B8  adrp     x8, #0x8f27000
0068BA4BC  ldr      x8, [x8, #0x6a8]
0068BA4C0  ldr      x2, [x8]
0068BA4C4  ldrb     w8, [x2, #0x53]
0068BA4C8  tbnz     w8, #5, #0x68ba4e8
0068BA4CC  str      w20, [x19, #0x20]
0068BA4D0  b        #0x68ba4f8 ; 
0068BA4D4  ldr      x2, [x1, #0x60]
0068BA4D8  mov      x0, x19
0068BA4DC  ldp      x20, x19, [sp, #0x10]
0068BA4E0  ldp      x30, x21, [sp], #0x20
0068BA4E4  br       x2
0068BA4E8  ldr      x8, [x2, #0x60]
0068BA4EC  mov      x0, x19
0068BA4F0  mov      w1, w20
0068BA4F4  blr      x8
0068BA4F8  mov      x0, x19
0068BA4FC  mov      x1, xzr
0068BA500  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BA504  adrp     x21, #0x959c000
0068BA508  ldrb     w8, [x21, #0x658]
0068BA50C  mov      w20, w0
0068BA510  cbnz     w8, #0x68ba528
0068BA514  adrp     x0, #0x8f27000
0068BA518  ldr      x0, [x0, #0x6b8]
0068BA51C  bl       #0x382bd14 ; 
0068BA520  mov      w8, #1
0068BA524  strb     w8, [x21, #0x658]
0068BA528  adrp     x8, #0x8f27000
0068BA52C  ldr      x8, [x8, #0x6b8]
0068BA530  ldr      x2, [x8]
0068BA534  ldrb     w8, [x2, #0x53]
0068BA538  tbnz     w8, #5, #0x68ba544
0068BA53C  str      w20, [x19, #0x24]
0068BA540  b        #0x68ba554 ; 
0068BA544  ldr      x8, [x2, #0x60]
0068BA548  mov      x0, x19
0068BA54C  mov      w1, w20
0068BA550  blr      x8
0068BA554  mov      x0, x19
0068BA558  mov      x1, xzr
0068BA55C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068BA560  adrp     x21, #0x959c000
0068BA564  ldrb     w8, [x21, #0x659]
0068BA568  mov      x20, x0
0068BA56C  cbnz     w8, #0x68ba584
0068BA570  adrp     x0, #0x8f27000
0068BA574  ldr      x0, [x0, #0x6c8]
0068BA578  bl       #0x382bd14 ; 
0068BA57C  mov      w8, #1
0068BA580  strb     w8, [x21, #0x659]
0068BA584  adrp     x8, #0x8f27000
0068BA588  ldr      x8, [x8, #0x6c8]
0068BA58C  ldr      x2, [x8]
0068BA590  ldrb     w8, [x2, #0x53]
0068BA594  tbnz     w8, #5, #0x68ba5ac
0068BA598  mov      x0, x19
0068BA59C  str      x20, [x0, #0x28]!
0068BA5A0  mov      x1, x20
0068BA5A4  bl       #0x382bcb8 ; 
0068BA5A8  b        #0x68ba5bc ; 
0068BA5AC  ldr      x8, [x2, #0x60]
0068BA5B0  mov      x0, x19
0068BA5B4  mov      x1, x20
0068BA5B8  blr      x8
0068BA5BC  mov      x0, x19
0068BA5C0  mov      x1, xzr
0068BA5C4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068BA5C8  adrp     x21, #0x959c000
0068BA5CC  ldrb     w8, [x21, #0x65a]
0068BA5D0  mov      x20, x0
0068BA5D4  cbnz     w8, #0x68ba5ec
0068BA5D8  adrp     x0, #0x8f27000
0068BA5DC  ldr      x0, [x0, #0x6d8]
0068BA5E0  bl       #0x382bd14 ; 
0068BA5E4  mov      w8, #1
0068BA5E8  strb     w8, [x21, #0x65a]
0068BA5EC  adrp     x8, #0x8f27000
0068BA5F0  ldr      x8, [x8, #0x6d8]
0068BA5F4  ldr      x2, [x8]
0068BA5F8  ldrb     w8, [x2, #0x53]
0068BA5FC  tbnz     w8, #5, #0x68ba614
0068BA600  str      x20, [x19, #0x30]!
0068BA604  mov      x0, x19
0068BA608  mov      x1, x20
0068BA60C  bl       #0x382bcb8 ; 
0068BA610  b        #0x68ba624 ; 
0068BA614  ldr      x8, [x2, #0x60]
0068BA618  mov      x0, x19
0068BA61C  mov      x1, x20
0068BA620  blr      x8
0068BA624  ldp      x20, x19, [sp, #0x10]
0068BA628  mov      w0, #1
0068BA62C  ldp      x30, x21, [sp], #0x20
0068BA630  ret      

