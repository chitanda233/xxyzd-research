; LocalModels.Bean.SkillGroup_BaseGroupX$$readImpl
; RVA 0x6AF5B2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF5B2C  stp      x30, x21, [sp, #-0x20]!
006AF5B30  stp      x20, x19, [sp, #0x10]
006AF5B34  adrp     x20, #0x959e000
006AF5B38  adrp     x21, #0x8f3d000
006AF5B3C  ldrb     w8, [x20, #0xeec]
006AF5B40  ldr      x21, [x21, #0xa20]
006AF5B44  mov      x19, x0
006AF5B48  tbnz     w8, #0, #0x6af5b60
006AF5B4C  adrp     x0, #0x8f3d000
006AF5B50  ldr      x0, [x0, #0xa20]
006AF5B54  bl       #0x382bd14 ; 
006AF5B58  mov      w8, #1
006AF5B5C  strb     w8, [x20, #0xeec]
006AF5B60  ldr      x1, [x21]
006AF5B64  ldrb     w8, [x1, #0x53]
006AF5B68  tbnz     w8, #5, #0x6af5bb8
006AF5B6C  mov      x0, x19
006AF5B70  mov      x1, xzr
006AF5B74  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF5B78  adrp     x21, #0x959f000
006AF5B7C  ldrb     w8, [x21, #0x27e]
006AF5B80  mov      w20, w0
006AF5B84  cbnz     w8, #0x6af5b9c
006AF5B88  adrp     x0, #0x8f3d000
006AF5B8C  ldr      x0, [x0, #0x9f8]
006AF5B90  bl       #0x382bd14 ; 
006AF5B94  mov      w8, #1
006AF5B98  strb     w8, [x21, #0x27e]
006AF5B9C  adrp     x8, #0x8f3d000
006AF5BA0  ldr      x8, [x8, #0x9f8]
006AF5BA4  ldr      x2, [x8]
006AF5BA8  ldrb     w8, [x2, #0x53]
006AF5BAC  tbnz     w8, #5, #0x6af5bcc
006AF5BB0  str      w20, [x19, #0x20]
006AF5BB4  b        #0x6af5bdc ; 
006AF5BB8  ldr      x2, [x1, #0x60]
006AF5BBC  mov      x0, x19
006AF5BC0  ldp      x20, x19, [sp, #0x10]
006AF5BC4  ldp      x30, x21, [sp], #0x20
006AF5BC8  br       x2
006AF5BCC  ldr      x8, [x2, #0x60]
006AF5BD0  mov      x0, x19
006AF5BD4  mov      w1, w20
006AF5BD8  blr      x8
006AF5BDC  mov      x0, x19
006AF5BE0  mov      x1, xzr
006AF5BE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF5BE8  adrp     x21, #0x959f000
006AF5BEC  ldrb     w8, [x21, #0x27f]
006AF5BF0  mov      w20, w0
006AF5BF4  cbnz     w8, #0x6af5c0c
006AF5BF8  adrp     x0, #0x8f3d000
006AF5BFC  ldr      x0, [x0, #0xa08]
006AF5C00  bl       #0x382bd14 ; 
006AF5C04  mov      w8, #1
006AF5C08  strb     w8, [x21, #0x27f]
006AF5C0C  adrp     x8, #0x8f3d000
006AF5C10  ldr      x8, [x8, #0xa08]
006AF5C14  ldr      x2, [x8]
006AF5C18  ldrb     w8, [x2, #0x53]
006AF5C1C  tbnz     w8, #5, #0x6af5c28
006AF5C20  str      w20, [x19, #0x24]
006AF5C24  b        #0x6af5c38 ; 
006AF5C28  ldr      x8, [x2, #0x60]
006AF5C2C  mov      x0, x19
006AF5C30  mov      w1, w20
006AF5C34  blr      x8
006AF5C38  mov      x0, x19
006AF5C3C  mov      x1, xzr
006AF5C40  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF5C44  adrp     x21, #0x959f000
006AF5C48  ldrb     w8, [x21, #0x280]
006AF5C4C  mov      w20, w0
006AF5C50  cbnz     w8, #0x6af5c68
006AF5C54  adrp     x0, #0x8f3d000
006AF5C58  ldr      x0, [x0, #0xa18]
006AF5C5C  bl       #0x382bd14 ; 
006AF5C60  mov      w8, #1
006AF5C64  strb     w8, [x21, #0x280]
006AF5C68  adrp     x8, #0x8f3d000
006AF5C6C  ldr      x8, [x8, #0xa18]
006AF5C70  ldr      x2, [x8]
006AF5C74  ldrb     w8, [x2, #0x53]
006AF5C78  tbnz     w8, #5, #0x6af5c84
006AF5C7C  str      w20, [x19, #0x28]
006AF5C80  b        #0x6af5c94 ; 
006AF5C84  ldr      x8, [x2, #0x60]
006AF5C88  mov      x0, x19
006AF5C8C  mov      w1, w20
006AF5C90  blr      x8
006AF5C94  ldp      x20, x19, [sp, #0x10]
006AF5C98  mov      w0, #1
006AF5C9C  ldp      x30, x21, [sp], #0x20
006AF5CA0  ret      

