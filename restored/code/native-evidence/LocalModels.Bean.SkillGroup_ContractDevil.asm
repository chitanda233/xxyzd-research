; LocalModels.Bean.SkillGroup_ContractDevil$$readImpl
; RVA 0x6AF6C14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF6C14  stp      x30, x21, [sp, #-0x20]!
006AF6C18  stp      x20, x19, [sp, #0x10]
006AF6C1C  adrp     x20, #0x959f000
006AF6C20  adrp     x21, #0x8f3d000
006AF6C24  ldrb     w8, [x20, #0x29b]
006AF6C28  ldr      x21, [x21, #0xae0]
006AF6C2C  mov      x19, x0
006AF6C30  tbnz     w8, #0, #0x6af6c48
006AF6C34  adrp     x0, #0x8f3d000
006AF6C38  ldr      x0, [x0, #0xae0]
006AF6C3C  bl       #0x382bd14 ; 
006AF6C40  mov      w8, #1
006AF6C44  strb     w8, [x20, #0x29b]
006AF6C48  ldr      x1, [x21]
006AF6C4C  ldrb     w8, [x1, #0x53]
006AF6C50  tbnz     w8, #5, #0x6af6ca0
006AF6C54  mov      x0, x19
006AF6C58  mov      x1, xzr
006AF6C5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF6C60  adrp     x21, #0x959f000
006AF6C64  ldrb     w8, [x21, #0x86a]
006AF6C68  mov      w20, w0
006AF6C6C  cbnz     w8, #0x6af6c84
006AF6C70  adrp     x0, #0x8f3d000
006AF6C74  ldr      x0, [x0, #0xab8]
006AF6C78  bl       #0x382bd14 ; 
006AF6C7C  mov      w8, #1
006AF6C80  strb     w8, [x21, #0x86a]
006AF6C84  adrp     x8, #0x8f3d000
006AF6C88  ldr      x8, [x8, #0xab8]
006AF6C8C  ldr      x2, [x8]
006AF6C90  ldrb     w8, [x2, #0x53]
006AF6C94  tbnz     w8, #5, #0x6af6cb4
006AF6C98  str      w20, [x19, #0x20]
006AF6C9C  b        #0x6af6cc4 ; 
006AF6CA0  ldr      x2, [x1, #0x60]
006AF6CA4  mov      x0, x19
006AF6CA8  ldp      x20, x19, [sp, #0x10]
006AF6CAC  ldp      x30, x21, [sp], #0x20
006AF6CB0  br       x2
006AF6CB4  ldr      x8, [x2, #0x60]
006AF6CB8  mov      x0, x19
006AF6CBC  mov      w1, w20
006AF6CC0  blr      x8
006AF6CC4  mov      x0, x19
006AF6CC8  mov      x1, xzr
006AF6CCC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF6CD0  adrp     x21, #0x959f000
006AF6CD4  ldrb     w8, [x21, #0x86b]
006AF6CD8  mov      w20, w0
006AF6CDC  cbnz     w8, #0x6af6cf4
006AF6CE0  adrp     x0, #0x8f3d000
006AF6CE4  ldr      x0, [x0, #0xac8]
006AF6CE8  bl       #0x382bd14 ; 
006AF6CEC  mov      w8, #1
006AF6CF0  strb     w8, [x21, #0x86b]
006AF6CF4  adrp     x8, #0x8f3d000
006AF6CF8  ldr      x8, [x8, #0xac8]
006AF6CFC  ldr      x2, [x8]
006AF6D00  ldrb     w8, [x2, #0x53]
006AF6D04  tbnz     w8, #5, #0x6af6d10
006AF6D08  str      w20, [x19, #0x24]
006AF6D0C  b        #0x6af6d20 ; 
006AF6D10  ldr      x8, [x2, #0x60]
006AF6D14  mov      x0, x19
006AF6D18  mov      w1, w20
006AF6D1C  blr      x8
006AF6D20  mov      x0, x19
006AF6D24  mov      x1, xzr
006AF6D28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF6D2C  adrp     x21, #0x959f000
006AF6D30  ldrb     w8, [x21, #0x86c]
006AF6D34  mov      w20, w0
006AF6D38  cbnz     w8, #0x6af6d50
006AF6D3C  adrp     x0, #0x8f3d000
006AF6D40  ldr      x0, [x0, #0xad8]
006AF6D44  bl       #0x382bd14 ; 
006AF6D48  mov      w8, #1
006AF6D4C  strb     w8, [x21, #0x86c]
006AF6D50  adrp     x8, #0x8f3d000
006AF6D54  ldr      x8, [x8, #0xad8]
006AF6D58  ldr      x2, [x8]
006AF6D5C  ldrb     w8, [x2, #0x53]
006AF6D60  tbnz     w8, #5, #0x6af6d6c
006AF6D64  str      w20, [x19, #0x28]
006AF6D68  b        #0x6af6d7c ; 
006AF6D6C  ldr      x8, [x2, #0x60]
006AF6D70  mov      x0, x19
006AF6D74  mov      w1, w20
006AF6D78  blr      x8
006AF6D7C  ldp      x20, x19, [sp, #0x10]
006AF6D80  mov      w0, #1
006AF6D84  ldp      x30, x21, [sp], #0x20
006AF6D88  ret      

