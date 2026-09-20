; LocalModelEx$$GetSkillDeepType
; RVA 0x64C91A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C91A0  stp      x30, x23, [sp, #-0x30]!
0064C91A4  stp      x22, x21, [sp, #0x10]
0064C91A8  stp      x20, x19, [sp, #0x20]
0064C91AC  adrp     x21, #0x9597000
0064C91B0  adrp     x22, #0x8ef9000
0064C91B4  ldrb     w8, [x21, #0xfb2]
0064C91B8  ldr      x22, [x22, #0xf28] ; GLOBAL Method$LocalModelEx.GetSkillDeepType() @ 0x928a818
0064C91BC  mov      w20, w1
0064C91C0  mov      x19, x0
0064C91C4  tbnz     w8, #0, #0x64c91e8
0064C91C8  adrp     x0, #0x8ee8000
0064C91CC  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064C91D0  bl       #0x382bd14 ; 
0064C91D4  adrp     x0, #0x8ef9000
0064C91D8  ldr      x0, [x0, #0xf28] ; GLOBAL Method$LocalModelEx.GetSkillDeepType() @ 0x928a818
0064C91DC  bl       #0x382bd14 ; 
0064C91E0  mov      w8, #1
0064C91E4  strb     w8, [x21, #0xfb2]
0064C91E8  ldr      x2, [x22]
0064C91EC  ldrb     w8, [x2, #0x53]
0064C91F0  tbnz     w8, #5, #0x64c9260
0064C91F4  adrp     x21, #0x8ee8000
0064C91F8  ldr      x21, [x21, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064C91FC  ldr      x0, [x21]
0064C9200  ldr      w8, [x0, #0xe0]
0064C9204  cbnz     w8, #0x64c9210
0064C9208  bl       #0x382be8c ; 
0064C920C  ldr      x0, [x21]
0064C9210  ldr      x8, [x0, #0xb8]
0064C9214  ldr      w8, [x8, #0x438]
0064C9218  cmp      w8, #1
0064C921C  cset     w21, ne
0064C9220  cbz      x19, #0x64c943c
0064C9224  adrp     x22, #0x9598000
0064C9228  ldrb     w8, [x22, #0x35e]
0064C922C  cbnz     w8, #0x64c9244
0064C9230  adrp     x0, #0x8ef9000
0064C9234  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0064C9238  bl       #0x382bd14 ; 
0064C923C  mov      w8, #1
0064C9240  strb     w8, [x22, #0x35e]
0064C9244  adrp     x23, #0x8ef9000
0064C9248  ldr      x23, [x23, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0064C924C  ldr      x1, [x23]
0064C9250  ldrb     w8, [x1, #0x53]
0064C9254  tbnz     w8, #5, #0x64c927c
0064C9258  ldr      w0, [x19, #0x68]
0064C925C  b        #0x64c9288 ; 
0064C9260  ldr      x3, [x2, #0x60]
0064C9264  and      w1, w20, #1
0064C9268  mov      x0, x19
0064C926C  ldp      x20, x19, [sp, #0x20]
0064C9270  ldp      x22, x21, [sp, #0x10]
0064C9274  ldp      x30, x23, [sp], #0x30
0064C9278  br       x3
0064C927C  ldr      x8, [x1, #0x60]
0064C9280  mov      x0, x19
0064C9284  blr      x8
0064C9288  cmp      w0, #0x63
0064C928C  and      w21, w21, w20
0064C9290  b.ne     #0x64c92a0
0064C9294  mov      w20, wzr
0064C9298  tbnz     w21, #0, #0x64c93c4
0064C929C  b        #0x64c9414 ; 
0064C92A0  ldrb     w8, [x22, #0x35e]
0064C92A4  cbnz     w8, #0x64c92bc
0064C92A8  adrp     x0, #0x8ef9000
0064C92AC  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0064C92B0  bl       #0x382bd14 ; 
0064C92B4  mov      w8, #1
0064C92B8  strb     w8, [x22, #0x35e]
0064C92BC  ldr      x1, [x23]
0064C92C0  ldrb     w8, [x1, #0x53]
0064C92C4  tbnz     w8, #5, #0x64c92d0
0064C92C8  ldr      w0, [x19, #0x68]
0064C92CC  b        #0x64c92dc ; 
0064C92D0  ldr      x8, [x1, #0x60]
0064C92D4  mov      x0, x19
0064C92D8  blr      x8
0064C92DC  cmp      w0, #2
0064C92E0  b.ne     #0x64c92f0
0064C92E4  mov      w20, #1
0064C92E8  tbnz     w21, #0, #0x64c93c4
0064C92EC  b        #0x64c9414 ; 
0064C92F0  ldrb     w8, [x22, #0x35e]
0064C92F4  cbnz     w8, #0x64c930c
0064C92F8  adrp     x0, #0x8ef9000
0064C92FC  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0064C9300  bl       #0x382bd14 ; 
0064C9304  mov      w8, #1
0064C9308  strb     w8, [x22, #0x35e]
0064C930C  ldr      x1, [x23]
0064C9310  ldrb     w8, [x1, #0x53]
0064C9314  tbnz     w8, #5, #0x64c9320
0064C9318  ldr      w0, [x19, #0x68]
0064C931C  b        #0x64c932c ; 
0064C9320  ldr      x8, [x1, #0x60]
0064C9324  mov      x0, x19
0064C9328  blr      x8
0064C932C  cmp      w0, #1
0064C9330  b.eq     #0x64c93bc
0064C9334  ldrb     w8, [x22, #0x35e]
0064C9338  cbnz     w8, #0x64c9350
0064C933C  adrp     x0, #0x8ef9000
0064C9340  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0064C9344  bl       #0x382bd14 ; 
0064C9348  mov      w8, #1
0064C934C  strb     w8, [x22, #0x35e]
0064C9350  ldr      x1, [x23]
0064C9354  ldrb     w8, [x1, #0x53]
0064C9358  tbnz     w8, #5, #0x64c9364
0064C935C  ldr      w0, [x19, #0x68]
0064C9360  b        #0x64c9370 ; 
0064C9364  ldr      x8, [x1, #0x60]
0064C9368  mov      x0, x19
0064C936C  blr      x8
0064C9370  cmp      w0, #3
0064C9374  b.eq     #0x64c93bc
0064C9378  ldrb     w8, [x22, #0x35e]
0064C937C  cbnz     w8, #0x64c9394
0064C9380  adrp     x0, #0x8ef9000
0064C9384  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0064C9388  bl       #0x382bd14 ; 
0064C938C  mov      w8, #1
0064C9390  strb     w8, [x22, #0x35e]
0064C9394  ldr      x1, [x23]
0064C9398  ldrb     w8, [x1, #0x53]
0064C939C  tbnz     w8, #5, #0x64c93a8
0064C93A0  ldr      w0, [x19, #0x68]
0064C93A4  b        #0x64c93b4 ; 
0064C93A8  ldr      x8, [x1, #0x60]
0064C93AC  mov      x0, x19
0064C93B0  blr      x8
0064C93B4  cmp      w0, #4
0064C93B8  b.ne     #0x64c93cc
0064C93BC  mov      w20, #2
0064C93C0  tbz      w21, #0, #0x64c9414
0064C93C4  mov      w0, w20
0064C93C8  b        #0x64c942c ; 
0064C93CC  ldrb     w8, [x22, #0x35e]
0064C93D0  cbnz     w8, #0x64c93e8
0064C93D4  adrp     x0, #0x8ef9000
0064C93D8  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0064C93DC  bl       #0x382bd14 ; 
0064C93E0  mov      w8, #1
0064C93E4  strb     w8, [x22, #0x35e]
0064C93E8  ldr      x1, [x23]
0064C93EC  ldrb     w8, [x1, #0x53]
0064C93F0  tbnz     w8, #5, #0x64c93fc
0064C93F4  ldr      w0, [x19, #0x68]
0064C93F8  b        #0x64c9408 ; 
0064C93FC  ldr      x8, [x1, #0x60]
0064C9400  mov      x0, x19
0064C9404  blr      x8
0064C9408  cmp      w0, #5
0064C940C  cset     w20, eq
0064C9410  tbnz     w21, #0, #0x64c93c4
0064C9414  mov      x0, x19
0064C9418  mov      x1, xzr
0064C941C  bl       #0x6b0a2d4 ; LocalModels.Bean.Skill_Main$$GetIsUpgrade
0064C9420  cmp      w0, #1
0064C9424  mov      w8, #3
0064C9428  csel     w0, w8, w20, eq
0064C942C  ldp      x20, x19, [sp, #0x20]
0064C9430  ldp      x22, x21, [sp, #0x10]
0064C9434  ldp      x30, x23, [sp], #0x30
0064C9438  ret      
0064C943C  bl       #0x382bfb8 ; 

