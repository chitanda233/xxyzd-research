; LocalModels.Bean.Tracker_Tracker$$readImpl
; RVA 0x6B18B24; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B18B24  stp      x30, x21, [sp, #-0x20]!
006B18B28  stp      x20, x19, [sp, #0x10]
006B18B2C  adrp     x20, #0x959f000
006B18B30  adrp     x21, #0x8f3f000
006B18B34  ldrb     w8, [x20, #0x618]
006B18B38  ldr      x21, [x21, #0x290]
006B18B3C  mov      x19, x0
006B18B40  tbnz     w8, #0, #0x6b18b58
006B18B44  adrp     x0, #0x8f3f000
006B18B48  ldr      x0, [x0, #0x290]
006B18B4C  bl       #0x382bd14 ; 
006B18B50  mov      w8, #1
006B18B54  strb     w8, [x20, #0x618]
006B18B58  ldr      x1, [x21]
006B18B5C  ldrb     w8, [x1, #0x53]
006B18B60  tbnz     w8, #5, #0x6b18bb0
006B18B64  mov      x0, x19
006B18B68  mov      x1, xzr
006B18B6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B18B70  adrp     x21, #0x959f000
006B18B74  ldrb     w8, [x21, #0x9fa]
006B18B78  mov      w20, w0
006B18B7C  cbnz     w8, #0x6b18b94
006B18B80  adrp     x0, #0x8f3f000
006B18B84  ldr      x0, [x0, #0x240]
006B18B88  bl       #0x382bd14 ; 
006B18B8C  mov      w8, #1
006B18B90  strb     w8, [x21, #0x9fa]
006B18B94  adrp     x8, #0x8f3f000
006B18B98  ldr      x8, [x8, #0x240]
006B18B9C  ldr      x2, [x8]
006B18BA0  ldrb     w8, [x2, #0x53]
006B18BA4  tbnz     w8, #5, #0x6b18bc4
006B18BA8  str      w20, [x19, #0x20]
006B18BAC  b        #0x6b18bd4 ; 
006B18BB0  ldr      x2, [x1, #0x60]
006B18BB4  mov      x0, x19
006B18BB8  ldp      x20, x19, [sp, #0x10]
006B18BBC  ldp      x30, x21, [sp], #0x20
006B18BC0  br       x2
006B18BC4  ldr      x8, [x2, #0x60]
006B18BC8  mov      x0, x19
006B18BCC  mov      w1, w20
006B18BD0  blr      x8
006B18BD4  mov      x0, x19
006B18BD8  mov      x1, xzr
006B18BDC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B18BE0  adrp     x21, #0x959f000
006B18BE4  ldrb     w8, [x21, #0x9fb]
006B18BE8  mov      w20, w0
006B18BEC  cbnz     w8, #0x6b18c04
006B18BF0  adrp     x0, #0x8f3f000
006B18BF4  ldr      x0, [x0, #0x248]
006B18BF8  bl       #0x382bd14 ; 
006B18BFC  mov      w8, #1
006B18C00  strb     w8, [x21, #0x9fb]
006B18C04  adrp     x8, #0x8f3f000
006B18C08  ldr      x8, [x8, #0x248]
006B18C0C  ldr      x2, [x8]
006B18C10  ldrb     w8, [x2, #0x53]
006B18C14  tbnz     w8, #5, #0x6b18c20
006B18C18  str      w20, [x19, #0x24]
006B18C1C  b        #0x6b18c30 ; 
006B18C20  ldr      x8, [x2, #0x60]
006B18C24  mov      x0, x19
006B18C28  mov      w1, w20
006B18C2C  blr      x8
006B18C30  mov      x0, x19
006B18C34  mov      x1, xzr
006B18C38  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B18C3C  adrp     x21, #0x959f000
006B18C40  ldrb     w8, [x21, #0x9fc]
006B18C44  mov      x20, x0
006B18C48  cbnz     w8, #0x6b18c60
006B18C4C  adrp     x0, #0x8f3f000
006B18C50  ldr      x0, [x0, #0x250]
006B18C54  bl       #0x382bd14 ; 
006B18C58  mov      w8, #1
006B18C5C  strb     w8, [x21, #0x9fc]
006B18C60  adrp     x8, #0x8f3f000
006B18C64  ldr      x8, [x8, #0x250]
006B18C68  ldr      x2, [x8]
006B18C6C  ldrb     w8, [x2, #0x53]
006B18C70  tbnz     w8, #5, #0x6b18c7c
006B18C74  str      x20, [x19, #0x28]
006B18C78  b        #0x6b18c8c ; 
006B18C7C  ldr      x8, [x2, #0x60]
006B18C80  mov      x0, x19
006B18C84  mov      x1, x20
006B18C88  blr      x8
006B18C8C  mov      x0, x19
006B18C90  mov      x1, xzr
006B18C94  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B18C98  adrp     x21, #0x959f000
006B18C9C  ldrb     w8, [x21, #0x9fd]
006B18CA0  mov      x20, x0
006B18CA4  cbnz     w8, #0x6b18cbc
006B18CA8  adrp     x0, #0x8f3f000
006B18CAC  ldr      x0, [x0, #0x258]
006B18CB0  bl       #0x382bd14 ; 
006B18CB4  mov      w8, #1
006B18CB8  strb     w8, [x21, #0x9fd]
006B18CBC  adrp     x8, #0x8f3f000
006B18CC0  ldr      x8, [x8, #0x258]
006B18CC4  ldr      x2, [x8]
006B18CC8  ldrb     w8, [x2, #0x53]
006B18CCC  tbnz     w8, #5, #0x6b18cd8
006B18CD0  str      x20, [x19, #0x30]
006B18CD4  b        #0x6b18ce8 ; 
006B18CD8  ldr      x8, [x2, #0x60]
006B18CDC  mov      x0, x19
006B18CE0  mov      x1, x20
006B18CE4  blr      x8
006B18CE8  mov      x0, x19
006B18CEC  mov      x1, xzr
006B18CF0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B18CF4  adrp     x21, #0x959f000
006B18CF8  ldrb     w8, [x21, #0x9fe]
006B18CFC  mov      x20, x0
006B18D00  cbnz     w8, #0x6b18d18
006B18D04  adrp     x0, #0x8f3f000
006B18D08  ldr      x0, [x0, #0x260]
006B18D0C  bl       #0x382bd14 ; 
006B18D10  mov      w8, #1
006B18D14  strb     w8, [x21, #0x9fe]
006B18D18  adrp     x8, #0x8f3f000
006B18D1C  ldr      x8, [x8, #0x260]
006B18D20  ldr      x2, [x8]
006B18D24  ldrb     w8, [x2, #0x53]
006B18D28  tbnz     w8, #5, #0x6b18d34
006B18D2C  str      x20, [x19, #0x38]
006B18D30  b        #0x6b18d44 ; 
006B18D34  ldr      x8, [x2, #0x60]
006B18D38  mov      x0, x19
006B18D3C  mov      x1, x20
006B18D40  blr      x8
006B18D44  mov      x0, x19
006B18D48  mov      x1, xzr
006B18D4C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B18D50  adrp     x21, #0x959f000
006B18D54  ldrb     w8, [x21, #0x9ff]
006B18D58  mov      x20, x0
006B18D5C  cbnz     w8, #0x6b18d74
006B18D60  adrp     x0, #0x8f3f000
006B18D64  ldr      x0, [x0, #0x268]
006B18D68  bl       #0x382bd14 ; 
006B18D6C  mov      w8, #1
006B18D70  strb     w8, [x21, #0x9ff]
006B18D74  adrp     x8, #0x8f3f000
006B18D78  ldr      x8, [x8, #0x268]
006B18D7C  ldr      x2, [x8]
006B18D80  ldrb     w8, [x2, #0x53]
006B18D84  tbnz     w8, #5, #0x6b18d90
006B18D88  str      x20, [x19, #0x40]
006B18D8C  b        #0x6b18da0 ; 
006B18D90  ldr      x8, [x2, #0x60]
006B18D94  mov      x0, x19
006B18D98  mov      x1, x20
006B18D9C  blr      x8
006B18DA0  mov      x0, x19
006B18DA4  mov      x1, xzr
006B18DA8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B18DAC  adrp     x21, #0x959f000
006B18DB0  ldrb     w8, [x21, #0xa00]
006B18DB4  mov      x20, x0
006B18DB8  cbnz     w8, #0x6b18dd0
006B18DBC  adrp     x0, #0x8f3f000
006B18DC0  ldr      x0, [x0, #0x270]
006B18DC4  bl       #0x382bd14 ; 
006B18DC8  mov      w8, #1
006B18DCC  strb     w8, [x21, #0xa00]
006B18DD0  adrp     x8, #0x8f3f000
006B18DD4  ldr      x8, [x8, #0x270]
006B18DD8  ldr      x2, [x8]
006B18DDC  ldrb     w8, [x2, #0x53]
006B18DE0  tbnz     w8, #5, #0x6b18dec
006B18DE4  str      x20, [x19, #0x48]
006B18DE8  b        #0x6b18dfc ; 
006B18DEC  ldr      x8, [x2, #0x60]
006B18DF0  mov      x0, x19
006B18DF4  mov      x1, x20
006B18DF8  blr      x8
006B18DFC  mov      x0, x19
006B18E00  mov      x1, xzr
006B18E04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B18E08  adrp     x21, #0x959f000
006B18E0C  ldrb     w8, [x21, #0xa01]
006B18E10  mov      w20, w0
006B18E14  cbnz     w8, #0x6b18e2c
006B18E18  adrp     x0, #0x8f3f000
006B18E1C  ldr      x0, [x0, #0x278]
006B18E20  bl       #0x382bd14 ; 
006B18E24  mov      w8, #1
006B18E28  strb     w8, [x21, #0xa01]
006B18E2C  adrp     x8, #0x8f3f000
006B18E30  ldr      x8, [x8, #0x278]
006B18E34  ldr      x2, [x8]
006B18E38  ldrb     w8, [x2, #0x53]
006B18E3C  tbnz     w8, #5, #0x6b18e48
006B18E40  str      w20, [x19, #0x50]
006B18E44  b        #0x6b18e58 ; 
006B18E48  ldr      x8, [x2, #0x60]
006B18E4C  mov      x0, x19
006B18E50  mov      w1, w20
006B18E54  blr      x8
006B18E58  mov      x0, x19
006B18E5C  mov      x1, xzr
006B18E60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B18E64  adrp     x21, #0x959f000
006B18E68  ldrb     w8, [x21, #0xa02]
006B18E6C  mov      w20, w0
006B18E70  cbnz     w8, #0x6b18e88
006B18E74  adrp     x0, #0x8f3f000
006B18E78  ldr      x0, [x0, #0x280]
006B18E7C  bl       #0x382bd14 ; 
006B18E80  mov      w8, #1
006B18E84  strb     w8, [x21, #0xa02]
006B18E88  adrp     x8, #0x8f3f000
006B18E8C  ldr      x8, [x8, #0x280]
006B18E90  ldr      x2, [x8]
006B18E94  ldrb     w8, [x2, #0x53]
006B18E98  tbnz     w8, #5, #0x6b18ea4
006B18E9C  str      w20, [x19, #0x54]
006B18EA0  b        #0x6b18eb4 ; 
006B18EA4  ldr      x8, [x2, #0x60]
006B18EA8  mov      x0, x19
006B18EAC  mov      w1, w20
006B18EB0  blr      x8
006B18EB4  mov      x0, x19
006B18EB8  mov      x1, xzr
006B18EBC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B18EC0  adrp     x21, #0x959f000
006B18EC4  ldrb     w8, [x21, #0xa03]
006B18EC8  mov      x20, x0
006B18ECC  cbnz     w8, #0x6b18ee4
006B18ED0  adrp     x0, #0x8f3f000
006B18ED4  ldr      x0, [x0, #0x288]
006B18ED8  bl       #0x382bd14 ; 
006B18EDC  mov      w8, #1
006B18EE0  strb     w8, [x21, #0xa03]
006B18EE4  adrp     x8, #0x8f3f000
006B18EE8  ldr      x8, [x8, #0x288]
006B18EEC  ldr      x2, [x8]
006B18EF0  ldrb     w8, [x2, #0x53]
006B18EF4  tbnz     w8, #5, #0x6b18f0c
006B18EF8  str      x20, [x19, #0x58]!
006B18EFC  mov      x0, x19
006B18F00  mov      x1, x20
006B18F04  bl       #0x382bcb8 ; 
006B18F08  b        #0x6b18f1c ; 
006B18F0C  ldr      x8, [x2, #0x60]
006B18F10  mov      x0, x19
006B18F14  mov      x1, x20
006B18F18  blr      x8
006B18F1C  ldp      x20, x19, [sp, #0x10]
006B18F20  mov      w0, #1
006B18F24  ldp      x30, x21, [sp], #0x20
006B18F28  ret      

