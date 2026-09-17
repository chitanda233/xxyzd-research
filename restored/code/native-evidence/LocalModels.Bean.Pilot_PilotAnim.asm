; LocalModels.Bean.Pilot_PilotAnim$$readImpl
; RVA 0x6AD1B0C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD1B0C  stp      x30, x21, [sp, #-0x20]!
006AD1B10  stp      x20, x19, [sp, #0x10]
006AD1B14  adrp     x20, #0x959e000
006AD1B18  adrp     x21, #0x8f3b000
006AD1B1C  ldrb     w8, [x20, #0xb32]
006AD1B20  ldr      x21, [x21, #0xee0]
006AD1B24  mov      x19, x0
006AD1B28  tbnz     w8, #0, #0x6ad1b40
006AD1B2C  adrp     x0, #0x8f3b000
006AD1B30  ldr      x0, [x0, #0xee0]
006AD1B34  bl       #0x382bd14 ; 
006AD1B38  mov      w8, #1
006AD1B3C  strb     w8, [x20, #0xb32]
006AD1B40  ldr      x1, [x21]
006AD1B44  ldrb     w8, [x1, #0x53]
006AD1B48  tbnz     w8, #5, #0x6ad1b98
006AD1B4C  mov      x0, x19
006AD1B50  mov      x1, xzr
006AD1B54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD1B58  adrp     x21, #0x959f000
006AD1B5C  ldrb     w8, [x21, #0xf2]
006AD1B60  mov      w20, w0
006AD1B64  cbnz     w8, #0x6ad1b7c
006AD1B68  adrp     x0, #0x8f3b000
006AD1B6C  ldr      x0, [x0, #0xea8]
006AD1B70  bl       #0x382bd14 ; 
006AD1B74  mov      w8, #1
006AD1B78  strb     w8, [x21, #0xf2]
006AD1B7C  adrp     x8, #0x8f3b000
006AD1B80  ldr      x8, [x8, #0xea8]
006AD1B84  ldr      x2, [x8]
006AD1B88  ldrb     w8, [x2, #0x53]
006AD1B8C  tbnz     w8, #5, #0x6ad1bac
006AD1B90  str      w20, [x19, #0x20]
006AD1B94  b        #0x6ad1bbc ; 
006AD1B98  ldr      x2, [x1, #0x60]
006AD1B9C  mov      x0, x19
006AD1BA0  ldp      x20, x19, [sp, #0x10]
006AD1BA4  ldp      x30, x21, [sp], #0x20
006AD1BA8  br       x2
006AD1BAC  ldr      x8, [x2, #0x60]
006AD1BB0  mov      x0, x19
006AD1BB4  mov      w1, w20
006AD1BB8  blr      x8
006AD1BBC  mov      x0, x19
006AD1BC0  mov      x1, xzr
006AD1BC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD1BC8  adrp     x21, #0x959f000
006AD1BCC  ldrb     w8, [x21, #0xf3]
006AD1BD0  mov      w20, w0
006AD1BD4  cbnz     w8, #0x6ad1bec
006AD1BD8  adrp     x0, #0x8f3b000
006AD1BDC  ldr      x0, [x0, #0xeb8]
006AD1BE0  bl       #0x382bd14 ; 
006AD1BE4  mov      w8, #1
006AD1BE8  strb     w8, [x21, #0xf3]
006AD1BEC  adrp     x8, #0x8f3b000
006AD1BF0  ldr      x8, [x8, #0xeb8]
006AD1BF4  ldr      x2, [x8]
006AD1BF8  ldrb     w8, [x2, #0x53]
006AD1BFC  tbnz     w8, #5, #0x6ad1c08
006AD1C00  str      w20, [x19, #0x24]
006AD1C04  b        #0x6ad1c18 ; 
006AD1C08  ldr      x8, [x2, #0x60]
006AD1C0C  mov      x0, x19
006AD1C10  mov      w1, w20
006AD1C14  blr      x8
006AD1C18  mov      x0, x19
006AD1C1C  mov      x1, xzr
006AD1C20  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD1C24  adrp     x21, #0x959f000
006AD1C28  ldrb     w8, [x21, #0xf4]
006AD1C2C  mov      w20, w0
006AD1C30  cbnz     w8, #0x6ad1c48
006AD1C34  adrp     x0, #0x8f3b000
006AD1C38  ldr      x0, [x0, #0xec8]
006AD1C3C  bl       #0x382bd14 ; 
006AD1C40  mov      w8, #1
006AD1C44  strb     w8, [x21, #0xf4]
006AD1C48  adrp     x8, #0x8f3b000
006AD1C4C  ldr      x8, [x8, #0xec8]
006AD1C50  ldr      x2, [x8]
006AD1C54  ldrb     w8, [x2, #0x53]
006AD1C58  tbnz     w8, #5, #0x6ad1c64
006AD1C5C  str      w20, [x19, #0x28]
006AD1C60  b        #0x6ad1c74 ; 
006AD1C64  ldr      x8, [x2, #0x60]
006AD1C68  mov      x0, x19
006AD1C6C  mov      w1, w20
006AD1C70  blr      x8
006AD1C74  mov      x0, x19
006AD1C78  mov      x1, xzr
006AD1C7C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD1C80  adrp     x21, #0x959f000
006AD1C84  ldrb     w8, [x21, #0xf5]
006AD1C88  mov      x20, x0
006AD1C8C  cbnz     w8, #0x6ad1ca4
006AD1C90  adrp     x0, #0x8f3b000
006AD1C94  ldr      x0, [x0, #0xed8]
006AD1C98  bl       #0x382bd14 ; 
006AD1C9C  mov      w8, #1
006AD1CA0  strb     w8, [x21, #0xf5]
006AD1CA4  adrp     x8, #0x8f3b000
006AD1CA8  ldr      x8, [x8, #0xed8]
006AD1CAC  ldr      x2, [x8]
006AD1CB0  ldrb     w8, [x2, #0x53]
006AD1CB4  tbnz     w8, #5, #0x6ad1ccc
006AD1CB8  str      x20, [x19, #0x30]!
006AD1CBC  mov      x0, x19
006AD1CC0  mov      x1, x20
006AD1CC4  bl       #0x382bcb8 ; 
006AD1CC8  b        #0x6ad1cdc ; 
006AD1CCC  ldr      x8, [x2, #0x60]
006AD1CD0  mov      x0, x19
006AD1CD4  mov      x1, x20
006AD1CD8  blr      x8
006AD1CDC  ldp      x20, x19, [sp, #0x10]
006AD1CE0  mov      w0, #1
006AD1CE4  ldp      x30, x21, [sp], #0x20
006AD1CE8  ret      

