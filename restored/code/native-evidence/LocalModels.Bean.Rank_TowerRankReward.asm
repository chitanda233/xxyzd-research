; LocalModels.Bean.Rank_TowerRankReward$$readImpl
; RVA 0x6AD7C4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD7C4C  stp      x30, x21, [sp, #-0x20]!
006AD7C50  stp      x20, x19, [sp, #0x10]
006AD7C54  adrp     x20, #0x959e000
006AD7C58  adrp     x21, #0x8f3c000
006AD7C5C  ldrb     w8, [x20, #0xbd4]
006AD7C60  ldr      x21, [x21, #0x390]
006AD7C64  mov      x19, x0
006AD7C68  tbnz     w8, #0, #0x6ad7c80
006AD7C6C  adrp     x0, #0x8f3c000
006AD7C70  ldr      x0, [x0, #0x390]
006AD7C74  bl       #0x382bd14 ; 
006AD7C78  mov      w8, #1
006AD7C7C  strb     w8, [x20, #0xbd4]
006AD7C80  ldr      x1, [x21]
006AD7C84  ldrb     w8, [x1, #0x53]
006AD7C88  tbnz     w8, #5, #0x6ad7cd8
006AD7C8C  mov      x0, x19
006AD7C90  mov      x1, xzr
006AD7C94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD7C98  adrp     x21, #0x959f000
006AD7C9C  ldrb     w8, [x21, #0x132]
006AD7CA0  mov      w20, w0
006AD7CA4  cbnz     w8, #0x6ad7cbc
006AD7CA8  adrp     x0, #0x8f3c000
006AD7CAC  ldr      x0, [x0, #0x368]
006AD7CB0  bl       #0x382bd14 ; 
006AD7CB4  mov      w8, #1
006AD7CB8  strb     w8, [x21, #0x132]
006AD7CBC  adrp     x8, #0x8f3c000
006AD7CC0  ldr      x8, [x8, #0x368]
006AD7CC4  ldr      x2, [x8]
006AD7CC8  ldrb     w8, [x2, #0x53]
006AD7CCC  tbnz     w8, #5, #0x6ad7cec
006AD7CD0  str      w20, [x19, #0x20]
006AD7CD4  b        #0x6ad7cfc ; 
006AD7CD8  ldr      x2, [x1, #0x60]
006AD7CDC  mov      x0, x19
006AD7CE0  ldp      x20, x19, [sp, #0x10]
006AD7CE4  ldp      x30, x21, [sp], #0x20
006AD7CE8  br       x2
006AD7CEC  ldr      x8, [x2, #0x60]
006AD7CF0  mov      x0, x19
006AD7CF4  mov      w1, w20
006AD7CF8  blr      x8
006AD7CFC  mov      x0, x19
006AD7D00  mov      x1, xzr
006AD7D04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD7D08  adrp     x21, #0x959f000
006AD7D0C  ldrb     w8, [x21, #0x133]
006AD7D10  mov      w20, w0
006AD7D14  cbnz     w8, #0x6ad7d2c
006AD7D18  adrp     x0, #0x8f3c000
006AD7D1C  ldr      x0, [x0, #0x378]
006AD7D20  bl       #0x382bd14 ; 
006AD7D24  mov      w8, #1
006AD7D28  strb     w8, [x21, #0x133]
006AD7D2C  adrp     x8, #0x8f3c000
006AD7D30  ldr      x8, [x8, #0x378]
006AD7D34  ldr      x2, [x8]
006AD7D38  ldrb     w8, [x2, #0x53]
006AD7D3C  tbnz     w8, #5, #0x6ad7d48
006AD7D40  str      w20, [x19, #0x24]
006AD7D44  b        #0x6ad7d58 ; 
006AD7D48  ldr      x8, [x2, #0x60]
006AD7D4C  mov      x0, x19
006AD7D50  mov      w1, w20
006AD7D54  blr      x8
006AD7D58  mov      x0, x19
006AD7D5C  mov      x1, xzr
006AD7D60  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AD7D64  adrp     x21, #0x959f000
006AD7D68  ldrb     w8, [x21, #0x134]
006AD7D6C  mov      x20, x0
006AD7D70  cbnz     w8, #0x6ad7d88
006AD7D74  adrp     x0, #0x8f3c000
006AD7D78  ldr      x0, [x0, #0x388]
006AD7D7C  bl       #0x382bd14 ; 
006AD7D80  mov      w8, #1
006AD7D84  strb     w8, [x21, #0x134]
006AD7D88  adrp     x8, #0x8f3c000
006AD7D8C  ldr      x8, [x8, #0x388]
006AD7D90  ldr      x2, [x8]
006AD7D94  ldrb     w8, [x2, #0x53]
006AD7D98  tbnz     w8, #5, #0x6ad7db0
006AD7D9C  str      x20, [x19, #0x28]!
006AD7DA0  mov      x0, x19
006AD7DA4  mov      x1, x20
006AD7DA8  bl       #0x382bcb8 ; 
006AD7DAC  b        #0x6ad7dc0 ; 
006AD7DB0  ldr      x8, [x2, #0x60]
006AD7DB4  mov      x0, x19
006AD7DB8  mov      x1, x20
006AD7DBC  blr      x8
006AD7DC0  ldp      x20, x19, [sp, #0x10]
006AD7DC4  mov      w0, #1
006AD7DC8  ldp      x30, x21, [sp], #0x20
006AD7DCC  ret      

