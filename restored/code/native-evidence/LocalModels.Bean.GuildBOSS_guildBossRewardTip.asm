; LocalModels.Bean.GuildBOSS_guildBossRewardTip$$readImpl
; RVA 0x6A88C04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A88C04  stp      x30, x21, [sp, #-0x20]!
006A88C08  stp      x20, x19, [sp, #0x10]
006A88C0C  adrp     x20, #0x959e000
006A88C10  adrp     x21, #0x8f38000
006A88C14  ldrb     w8, [x20, #0x23]
006A88C18  ldr      x21, [x21, #0x860]
006A88C1C  mov      x19, x0
006A88C20  tbnz     w8, #0, #0x6a88c38
006A88C24  adrp     x0, #0x8f38000
006A88C28  ldr      x0, [x0, #0x860]
006A88C2C  bl       #0x382bd14 ; 
006A88C30  mov      w8, #1
006A88C34  strb     w8, [x20, #0x23]
006A88C38  ldr      x1, [x21]
006A88C3C  ldrb     w8, [x1, #0x53]
006A88C40  tbnz     w8, #5, #0x6a88c90
006A88C44  mov      x0, x19
006A88C48  mov      x1, xzr
006A88C4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A88C50  adrp     x21, #0x959e000
006A88C54  ldrb     w8, [x21, #0x559]
006A88C58  mov      w20, w0
006A88C5C  cbnz     w8, #0x6a88c74
006A88C60  adrp     x0, #0x8f38000
006A88C64  ldr      x0, [x0, #0x848]
006A88C68  bl       #0x382bd14 ; 
006A88C6C  mov      w8, #1
006A88C70  strb     w8, [x21, #0x559]
006A88C74  adrp     x8, #0x8f38000
006A88C78  ldr      x8, [x8, #0x848]
006A88C7C  ldr      x2, [x8]
006A88C80  ldrb     w8, [x2, #0x53]
006A88C84  tbnz     w8, #5, #0x6a88ca4
006A88C88  str      w20, [x19, #0x20]
006A88C8C  b        #0x6a88cb4 ; 
006A88C90  ldr      x2, [x1, #0x60]
006A88C94  mov      x0, x19
006A88C98  ldp      x20, x19, [sp, #0x10]
006A88C9C  ldp      x30, x21, [sp], #0x20
006A88CA0  br       x2
006A88CA4  ldr      x8, [x2, #0x60]
006A88CA8  mov      x0, x19
006A88CAC  mov      w1, w20
006A88CB0  blr      x8
006A88CB4  mov      x0, x19
006A88CB8  mov      x1, xzr
006A88CBC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A88CC0  adrp     x21, #0x959e000
006A88CC4  ldrb     w8, [x21, #0x55a]
006A88CC8  mov      x20, x0
006A88CCC  cbnz     w8, #0x6a88ce4
006A88CD0  adrp     x0, #0x8f38000
006A88CD4  ldr      x0, [x0, #0x858]
006A88CD8  bl       #0x382bd14 ; 
006A88CDC  mov      w8, #1
006A88CE0  strb     w8, [x21, #0x55a]
006A88CE4  adrp     x8, #0x8f38000
006A88CE8  ldr      x8, [x8, #0x858]
006A88CEC  ldr      x2, [x8]
006A88CF0  ldrb     w8, [x2, #0x53]
006A88CF4  tbnz     w8, #5, #0x6a88d0c
006A88CF8  str      x20, [x19, #0x28]!
006A88CFC  mov      x0, x19
006A88D00  mov      x1, x20
006A88D04  bl       #0x382bcb8 ; 
006A88D08  b        #0x6a88d1c ; 
006A88D0C  ldr      x8, [x2, #0x60]
006A88D10  mov      x0, x19
006A88D14  mov      x1, x20
006A88D18  blr      x8
006A88D1C  ldp      x20, x19, [sp, #0x10]
006A88D20  mov      w0, #1
006A88D24  ldp      x30, x21, [sp], #0x20
006A88D28  ret      

