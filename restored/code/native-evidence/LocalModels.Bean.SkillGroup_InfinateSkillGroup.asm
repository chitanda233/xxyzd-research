; LocalModels.Bean.SkillGroup_InfinateSkillGroup$$readImpl
; RVA 0x6AF77DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF77DC  stp      x30, x21, [sp, #-0x20]!
006AF77E0  stp      x20, x19, [sp, #0x10]
006AF77E4  adrp     x20, #0x959f000
006AF77E8  adrp     x21, #0x8f3d000
006AF77EC  ldrb     w8, [x20, #0x2af]
006AF77F0  ldr      x21, [x21, #0xb60]
006AF77F4  mov      x19, x0
006AF77F8  tbnz     w8, #0, #0x6af7810
006AF77FC  adrp     x0, #0x8f3d000
006AF7800  ldr      x0, [x0, #0xb60]
006AF7804  bl       #0x382bd14 ; 
006AF7808  mov      w8, #1
006AF780C  strb     w8, [x20, #0x2af]
006AF7810  ldr      x1, [x21]
006AF7814  ldrb     w8, [x1, #0x53]
006AF7818  tbnz     w8, #5, #0x6af7868
006AF781C  mov      x0, x19
006AF7820  mov      x1, xzr
006AF7824  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF7828  adrp     x21, #0x959f000
006AF782C  ldrb     w8, [x21, #0x872]
006AF7830  mov      w20, w0
006AF7834  cbnz     w8, #0x6af784c
006AF7838  adrp     x0, #0x8f3d000
006AF783C  ldr      x0, [x0, #0xb48]
006AF7840  bl       #0x382bd14 ; 
006AF7844  mov      w8, #1
006AF7848  strb     w8, [x21, #0x872]
006AF784C  adrp     x8, #0x8f3d000
006AF7850  ldr      x8, [x8, #0xb48]
006AF7854  ldr      x2, [x8]
006AF7858  ldrb     w8, [x2, #0x53]
006AF785C  tbnz     w8, #5, #0x6af787c
006AF7860  str      w20, [x19, #0x20]
006AF7864  b        #0x6af788c ; 
006AF7868  ldr      x2, [x1, #0x60]
006AF786C  mov      x0, x19
006AF7870  ldp      x20, x19, [sp, #0x10]
006AF7874  ldp      x30, x21, [sp], #0x20
006AF7878  br       x2
006AF787C  ldr      x8, [x2, #0x60]
006AF7880  mov      x0, x19
006AF7884  mov      w1, w20
006AF7888  blr      x8
006AF788C  mov      x0, x19
006AF7890  mov      x1, xzr
006AF7894  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF7898  adrp     x21, #0x959f000
006AF789C  ldrb     w8, [x21, #0x873]
006AF78A0  mov      w20, w0
006AF78A4  cbnz     w8, #0x6af78bc
006AF78A8  adrp     x0, #0x8f3d000
006AF78AC  ldr      x0, [x0, #0xb50]
006AF78B0  bl       #0x382bd14 ; 
006AF78B4  mov      w8, #1
006AF78B8  strb     w8, [x21, #0x873]
006AF78BC  adrp     x8, #0x8f3d000
006AF78C0  ldr      x8, [x8, #0xb50]
006AF78C4  ldr      x2, [x8]
006AF78C8  ldrb     w8, [x2, #0x53]
006AF78CC  tbnz     w8, #5, #0x6af78d8
006AF78D0  str      w20, [x19, #0x24]
006AF78D4  b        #0x6af78e8 ; 
006AF78D8  ldr      x8, [x2, #0x60]
006AF78DC  mov      x0, x19
006AF78E0  mov      w1, w20
006AF78E4  blr      x8
006AF78E8  mov      x0, x19
006AF78EC  mov      x1, xzr
006AF78F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF78F4  adrp     x21, #0x959f000
006AF78F8  ldrb     w8, [x21, #0x874]
006AF78FC  mov      w20, w0
006AF7900  cbnz     w8, #0x6af7918
006AF7904  adrp     x0, #0x8f3d000
006AF7908  ldr      x0, [x0, #0xb58]
006AF790C  bl       #0x382bd14 ; 
006AF7910  mov      w8, #1
006AF7914  strb     w8, [x21, #0x874]
006AF7918  adrp     x8, #0x8f3d000
006AF791C  ldr      x8, [x8, #0xb58]
006AF7920  ldr      x2, [x8]
006AF7924  ldrb     w8, [x2, #0x53]
006AF7928  tbnz     w8, #5, #0x6af7934
006AF792C  str      w20, [x19, #0x28]
006AF7930  b        #0x6af7944 ; 
006AF7934  ldr      x8, [x2, #0x60]
006AF7938  mov      x0, x19
006AF793C  mov      w1, w20
006AF7940  blr      x8
006AF7944  ldp      x20, x19, [sp, #0x10]
006AF7948  mov      w0, #1
006AF794C  ldp      x30, x21, [sp], #0x20
006AF7950  ret      

