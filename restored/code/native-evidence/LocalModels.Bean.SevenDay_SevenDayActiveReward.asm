; LocalModels.Bean.SevenDay_SevenDayActiveReward$$readImpl
; RVA 0x6AE8BB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE8BB4  stp      x30, x21, [sp, #-0x20]!
006AE8BB8  stp      x20, x19, [sp, #0x10]
006AE8BBC  adrp     x20, #0x959e000
006AE8BC0  adrp     x21, #0x8f3d000
006AE8BC4  ldrb     w8, [x20, #0xd91]
006AE8BC8  ldr      x21, [x21, #8]
006AE8BCC  mov      x19, x0
006AE8BD0  tbnz     w8, #0, #0x6ae8be8
006AE8BD4  adrp     x0, #0x8f3d000
006AE8BD8  ldr      x0, [x0, #8]
006AE8BDC  bl       #0x382bd14 ; 
006AE8BE0  mov      w8, #1
006AE8BE4  strb     w8, [x20, #0xd91]
006AE8BE8  ldr      x1, [x21]
006AE8BEC  ldrb     w8, [x1, #0x53]
006AE8BF0  tbnz     w8, #5, #0x6ae8c40
006AE8BF4  mov      x0, x19
006AE8BF8  mov      x1, xzr
006AE8BFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE8C00  adrp     x21, #0x959f000
006AE8C04  ldrb     w8, [x21, #0x1f0]
006AE8C08  mov      w20, w0
006AE8C0C  cbnz     w8, #0x6ae8c24
006AE8C10  adrp     x0, #0x8f3c000
006AE8C14  ldr      x0, [x0, #0xfd0]
006AE8C18  bl       #0x382bd14 ; 
006AE8C1C  mov      w8, #1
006AE8C20  strb     w8, [x21, #0x1f0]
006AE8C24  adrp     x8, #0x8f3c000
006AE8C28  ldr      x8, [x8, #0xfd0]
006AE8C2C  ldr      x2, [x8]
006AE8C30  ldrb     w8, [x2, #0x53]
006AE8C34  tbnz     w8, #5, #0x6ae8c54
006AE8C38  str      w20, [x19, #0x20]
006AE8C3C  b        #0x6ae8c64 ; 
006AE8C40  ldr      x2, [x1, #0x60]
006AE8C44  mov      x0, x19
006AE8C48  ldp      x20, x19, [sp, #0x10]
006AE8C4C  ldp      x30, x21, [sp], #0x20
006AE8C50  br       x2
006AE8C54  ldr      x8, [x2, #0x60]
006AE8C58  mov      x0, x19
006AE8C5C  mov      w1, w20
006AE8C60  blr      x8
006AE8C64  mov      x0, x19
006AE8C68  mov      x1, xzr
006AE8C6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE8C70  adrp     x21, #0x959f000
006AE8C74  ldrb     w8, [x21, #0x1f1]
006AE8C78  mov      w20, w0
006AE8C7C  cbnz     w8, #0x6ae8c94
006AE8C80  adrp     x0, #0x8f3c000
006AE8C84  ldr      x0, [x0, #0xfe0]
006AE8C88  bl       #0x382bd14 ; 
006AE8C8C  mov      w8, #1
006AE8C90  strb     w8, [x21, #0x1f1]
006AE8C94  adrp     x8, #0x8f3c000
006AE8C98  ldr      x8, [x8, #0xfe0]
006AE8C9C  ldr      x2, [x8]
006AE8CA0  ldrb     w8, [x2, #0x53]
006AE8CA4  tbnz     w8, #5, #0x6ae8cb0
006AE8CA8  str      w20, [x19, #0x24]
006AE8CAC  b        #0x6ae8cc0 ; 
006AE8CB0  ldr      x8, [x2, #0x60]
006AE8CB4  mov      x0, x19
006AE8CB8  mov      w1, w20
006AE8CBC  blr      x8
006AE8CC0  mov      x0, x19
006AE8CC4  mov      x1, xzr
006AE8CC8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE8CCC  adrp     x21, #0x959f000
006AE8CD0  ldrb     w8, [x21, #0x1f2]
006AE8CD4  mov      x20, x0
006AE8CD8  cbnz     w8, #0x6ae8cf0
006AE8CDC  adrp     x0, #0x8f3c000
006AE8CE0  ldr      x0, [x0, #0xff0]
006AE8CE4  bl       #0x382bd14 ; 
006AE8CE8  mov      w8, #1
006AE8CEC  strb     w8, [x21, #0x1f2]
006AE8CF0  adrp     x8, #0x8f3c000
006AE8CF4  ldr      x8, [x8, #0xff0]
006AE8CF8  ldr      x2, [x8]
006AE8CFC  ldrb     w8, [x2, #0x53]
006AE8D00  tbnz     w8, #5, #0x6ae8d18
006AE8D04  mov      x0, x19
006AE8D08  str      x20, [x0, #0x28]!
006AE8D0C  mov      x1, x20
006AE8D10  bl       #0x382bcb8 ; 
006AE8D14  b        #0x6ae8d28 ; 
006AE8D18  ldr      x8, [x2, #0x60]
006AE8D1C  mov      x0, x19
006AE8D20  mov      x1, x20
006AE8D24  blr      x8
006AE8D28  mov      x0, x19
006AE8D2C  mov      x1, xzr
006AE8D30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE8D34  adrp     x21, #0x959f000
006AE8D38  ldrb     w8, [x21, #0x1f3]
006AE8D3C  mov      w20, w0
006AE8D40  cbnz     w8, #0x6ae8d58
006AE8D44  adrp     x0, #0x8f3d000
006AE8D48  ldr      x0, [x0]
006AE8D4C  bl       #0x382bd14 ; 
006AE8D50  mov      w8, #1
006AE8D54  strb     w8, [x21, #0x1f3]
006AE8D58  adrp     x8, #0x8f3d000
006AE8D5C  ldr      x8, [x8]
006AE8D60  ldr      x2, [x8]
006AE8D64  ldrb     w8, [x2, #0x53]
006AE8D68  tbnz     w8, #5, #0x6ae8d74
006AE8D6C  str      w20, [x19, #0x30]
006AE8D70  b        #0x6ae8d84 ; 
006AE8D74  ldr      x8, [x2, #0x60]
006AE8D78  mov      x0, x19
006AE8D7C  mov      w1, w20
006AE8D80  blr      x8
006AE8D84  ldp      x20, x19, [sp, #0x10]
006AE8D88  mov      w0, #1
006AE8D8C  ldp      x30, x21, [sp], #0x20
006AE8D90  ret      

