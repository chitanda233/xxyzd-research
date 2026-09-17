; LocalModels.Bean.Rank_guildBossRankReward$$readImpl
; RVA 0x6AD6B50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD6B50  stp      x30, x21, [sp, #-0x20]!
006AD6B54  stp      x20, x19, [sp, #0x10]
006AD6B58  adrp     x20, #0x959e000
006AD6B5C  adrp     x21, #0x8f3c000
006AD6B60  ldrb     w8, [x20, #0xbb8]
006AD6B64  ldr      x21, [x21, #0x2c0]
006AD6B68  mov      x19, x0
006AD6B6C  tbnz     w8, #0, #0x6ad6b84
006AD6B70  adrp     x0, #0x8f3c000
006AD6B74  ldr      x0, [x0, #0x2c0]
006AD6B78  bl       #0x382bd14 ; 
006AD6B7C  mov      w8, #1
006AD6B80  strb     w8, [x20, #0xbb8]
006AD6B84  ldr      x1, [x21]
006AD6B88  ldrb     w8, [x1, #0x53]
006AD6B8C  tbnz     w8, #5, #0x6ad6bdc
006AD6B90  mov      x0, x19
006AD6B94  mov      x1, xzr
006AD6B98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD6B9C  adrp     x21, #0x959f000
006AD6BA0  ldrb     w8, [x21, #0x127]
006AD6BA4  mov      w20, w0
006AD6BA8  cbnz     w8, #0x6ad6bc0
006AD6BAC  adrp     x0, #0x8f3c000
006AD6BB0  ldr      x0, [x0, #0x298]
006AD6BB4  bl       #0x382bd14 ; 
006AD6BB8  mov      w8, #1
006AD6BBC  strb     w8, [x21, #0x127]
006AD6BC0  adrp     x8, #0x8f3c000
006AD6BC4  ldr      x8, [x8, #0x298]
006AD6BC8  ldr      x2, [x8]
006AD6BCC  ldrb     w8, [x2, #0x53]
006AD6BD0  tbnz     w8, #5, #0x6ad6bf0
006AD6BD4  str      w20, [x19, #0x20]
006AD6BD8  b        #0x6ad6c00 ; 
006AD6BDC  ldr      x2, [x1, #0x60]
006AD6BE0  mov      x0, x19
006AD6BE4  ldp      x20, x19, [sp, #0x10]
006AD6BE8  ldp      x30, x21, [sp], #0x20
006AD6BEC  br       x2
006AD6BF0  ldr      x8, [x2, #0x60]
006AD6BF4  mov      x0, x19
006AD6BF8  mov      w1, w20
006AD6BFC  blr      x8
006AD6C00  mov      x0, x19
006AD6C04  mov      x1, xzr
006AD6C08  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AD6C0C  adrp     x21, #0x959f000
006AD6C10  ldrb     w8, [x21, #0x128]
006AD6C14  mov      x20, x0
006AD6C18  cbnz     w8, #0x6ad6c30
006AD6C1C  adrp     x0, #0x8f3c000
006AD6C20  ldr      x0, [x0, #0x2a8]
006AD6C24  bl       #0x382bd14 ; 
006AD6C28  mov      w8, #1
006AD6C2C  strb     w8, [x21, #0x128]
006AD6C30  adrp     x8, #0x8f3c000
006AD6C34  ldr      x8, [x8, #0x2a8]
006AD6C38  ldr      x2, [x8]
006AD6C3C  ldrb     w8, [x2, #0x53]
006AD6C40  tbnz     w8, #5, #0x6ad6c58
006AD6C44  mov      x0, x19
006AD6C48  str      x20, [x0, #0x28]!
006AD6C4C  mov      x1, x20
006AD6C50  bl       #0x382bcb8 ; 
006AD6C54  b        #0x6ad6c68 ; 
006AD6C58  ldr      x8, [x2, #0x60]
006AD6C5C  mov      x0, x19
006AD6C60  mov      x1, x20
006AD6C64  blr      x8
006AD6C68  mov      x0, x19
006AD6C6C  mov      x1, xzr
006AD6C70  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AD6C74  adrp     x21, #0x959f000
006AD6C78  ldrb     w8, [x21, #0x129]
006AD6C7C  mov      x20, x0
006AD6C80  cbnz     w8, #0x6ad6c98
006AD6C84  adrp     x0, #0x8f3c000
006AD6C88  ldr      x0, [x0, #0x2b8]
006AD6C8C  bl       #0x382bd14 ; 
006AD6C90  mov      w8, #1
006AD6C94  strb     w8, [x21, #0x129]
006AD6C98  adrp     x8, #0x8f3c000
006AD6C9C  ldr      x8, [x8, #0x2b8]
006AD6CA0  ldr      x2, [x8]
006AD6CA4  ldrb     w8, [x2, #0x53]
006AD6CA8  tbnz     w8, #5, #0x6ad6cc0
006AD6CAC  str      x20, [x19, #0x30]!
006AD6CB0  mov      x0, x19
006AD6CB4  mov      x1, x20
006AD6CB8  bl       #0x382bcb8 ; 
006AD6CBC  b        #0x6ad6cd0 ; 
006AD6CC0  ldr      x8, [x2, #0x60]
006AD6CC4  mov      x0, x19
006AD6CC8  mov      x1, x20
006AD6CCC  blr      x8
006AD6CD0  ldp      x20, x19, [sp, #0x10]
006AD6CD4  mov      w0, #1
006AD6CD8  ldp      x30, x21, [sp], #0x20
006AD6CDC  ret      

