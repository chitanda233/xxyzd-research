; LocalModels.Bean.GuildBOSS_guildBossInfo$$readImpl
; RVA 0x6A86E50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A86E50  stp      x30, x21, [sp, #-0x20]!
006A86E54  stp      x20, x19, [sp, #0x10]
006A86E58  adrp     x20, #0x959d000
006A86E5C  adrp     x21, #0x8f38000
006A86E60  ldrb     w8, [x20, #0xff4]
006A86E64  ldr      x21, [x21, #0x718]
006A86E68  mov      x19, x0
006A86E6C  tbnz     w8, #0, #0x6a86e84
006A86E70  adrp     x0, #0x8f38000
006A86E74  ldr      x0, [x0, #0x718]
006A86E78  bl       #0x382bd14 ; 
006A86E7C  mov      w8, #1
006A86E80  strb     w8, [x20, #0xff4]
006A86E84  ldr      x1, [x21]
006A86E88  ldrb     w8, [x1, #0x53]
006A86E8C  tbnz     w8, #5, #0x6a86edc
006A86E90  mov      x0, x19
006A86E94  mov      x1, xzr
006A86E98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A86E9C  adrp     x21, #0x959e000
006A86EA0  ldrb     w8, [x21, #0x543]
006A86EA4  mov      w20, w0
006A86EA8  cbnz     w8, #0x6a86ec0
006A86EAC  adrp     x0, #0x8f38000
006A86EB0  ldr      x0, [x0, #0x6a0]
006A86EB4  bl       #0x382bd14 ; 
006A86EB8  mov      w8, #1
006A86EBC  strb     w8, [x21, #0x543]
006A86EC0  adrp     x8, #0x8f38000
006A86EC4  ldr      x8, [x8, #0x6a0]
006A86EC8  ldr      x2, [x8]
006A86ECC  ldrb     w8, [x2, #0x53]
006A86ED0  tbnz     w8, #5, #0x6a86ef0
006A86ED4  str      w20, [x19, #0x20]
006A86ED8  b        #0x6a86f00 ; 
006A86EDC  ldr      x2, [x1, #0x60]
006A86EE0  mov      x0, x19
006A86EE4  ldp      x20, x19, [sp, #0x10]
006A86EE8  ldp      x30, x21, [sp], #0x20
006A86EEC  br       x2
006A86EF0  ldr      x8, [x2, #0x60]
006A86EF4  mov      x0, x19
006A86EF8  mov      w1, w20
006A86EFC  blr      x8
006A86F00  mov      x0, x19
006A86F04  mov      x1, xzr
006A86F08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A86F0C  adrp     x21, #0x959e000
006A86F10  ldrb     w8, [x21, #0x544]
006A86F14  mov      w20, w0
006A86F18  cbnz     w8, #0x6a86f30
006A86F1C  adrp     x0, #0x8f38000
006A86F20  ldr      x0, [x0, #0x6b0]
006A86F24  bl       #0x382bd14 ; 
006A86F28  mov      w8, #1
006A86F2C  strb     w8, [x21, #0x544]
006A86F30  adrp     x8, #0x8f38000
006A86F34  ldr      x8, [x8, #0x6b0]
006A86F38  ldr      x2, [x8]
006A86F3C  ldrb     w8, [x2, #0x53]
006A86F40  tbnz     w8, #5, #0x6a86f4c
006A86F44  str      w20, [x19, #0x24]
006A86F48  b        #0x6a86f5c ; 
006A86F4C  ldr      x8, [x2, #0x60]
006A86F50  mov      x0, x19
006A86F54  mov      w1, w20
006A86F58  blr      x8
006A86F5C  mov      x0, x19
006A86F60  mov      x1, xzr
006A86F64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A86F68  adrp     x21, #0x959e000
006A86F6C  ldrb     w8, [x21, #0x545]
006A86F70  mov      w20, w0
006A86F74  cbnz     w8, #0x6a86f8c
006A86F78  adrp     x0, #0x8f38000
006A86F7C  ldr      x0, [x0, #0x6c0]
006A86F80  bl       #0x382bd14 ; 
006A86F84  mov      w8, #1
006A86F88  strb     w8, [x21, #0x545]
006A86F8C  adrp     x8, #0x8f38000
006A86F90  ldr      x8, [x8, #0x6c0]
006A86F94  ldr      x2, [x8]
006A86F98  ldrb     w8, [x2, #0x53]
006A86F9C  tbnz     w8, #5, #0x6a86fa8
006A86FA0  str      w20, [x19, #0x28]
006A86FA4  b        #0x6a86fb8 ; 
006A86FA8  ldr      x8, [x2, #0x60]
006A86FAC  mov      x0, x19
006A86FB0  mov      w1, w20
006A86FB4  blr      x8
006A86FB8  mov      x0, x19
006A86FBC  mov      x1, xzr
006A86FC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A86FC4  adrp     x21, #0x959e000
006A86FC8  ldrb     w8, [x21, #0x546]
006A86FCC  mov      w20, w0
006A86FD0  cbnz     w8, #0x6a86fe8
006A86FD4  adrp     x0, #0x8f38000
006A86FD8  ldr      x0, [x0, #0x6d0]
006A86FDC  bl       #0x382bd14 ; 
006A86FE0  mov      w8, #1
006A86FE4  strb     w8, [x21, #0x546]
006A86FE8  adrp     x8, #0x8f38000
006A86FEC  ldr      x8, [x8, #0x6d0]
006A86FF0  ldr      x2, [x8]
006A86FF4  ldrb     w8, [x2, #0x53]
006A86FF8  tbnz     w8, #5, #0x6a87004
006A86FFC  str      w20, [x19, #0x2c]
006A87000  b        #0x6a87014 ; 
006A87004  ldr      x8, [x2, #0x60]
006A87008  mov      x0, x19
006A8700C  mov      w1, w20
006A87010  blr      x8
006A87014  mov      x0, x19
006A87018  mov      x1, xzr
006A8701C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A87020  adrp     x21, #0x959e000
006A87024  ldrb     w8, [x21, #0x547]
006A87028  mov      w20, w0
006A8702C  cbnz     w8, #0x6a87044
006A87030  adrp     x0, #0x8f38000
006A87034  ldr      x0, [x0, #0x6e0]
006A87038  bl       #0x382bd14 ; 
006A8703C  mov      w8, #1
006A87040  strb     w8, [x21, #0x547]
006A87044  adrp     x8, #0x8f38000
006A87048  ldr      x8, [x8, #0x6e0]
006A8704C  ldr      x2, [x8]
006A87050  ldrb     w8, [x2, #0x53]
006A87054  tbnz     w8, #5, #0x6a87060
006A87058  str      w20, [x19, #0x30]
006A8705C  b        #0x6a87070 ; 
006A87060  ldr      x8, [x2, #0x60]
006A87064  mov      x0, x19
006A87068  mov      w1, w20
006A8706C  blr      x8
006A87070  mov      x0, x19
006A87074  mov      x1, xzr
006A87078  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A8707C  adrp     x21, #0x959e000
006A87080  ldrb     w8, [x21, #0x548]
006A87084  mov      x20, x0
006A87088  cbnz     w8, #0x6a870a0
006A8708C  adrp     x0, #0x8f38000
006A87090  ldr      x0, [x0, #0x6f0]
006A87094  bl       #0x382bd14 ; 
006A87098  mov      w8, #1
006A8709C  strb     w8, [x21, #0x548]
006A870A0  adrp     x8, #0x8f38000
006A870A4  ldr      x8, [x8, #0x6f0]
006A870A8  ldr      x2, [x8]
006A870AC  ldrb     w8, [x2, #0x53]
006A870B0  tbnz     w8, #5, #0x6a870c8
006A870B4  mov      x0, x19
006A870B8  str      x20, [x0, #0x38]!
006A870BC  mov      x1, x20
006A870C0  bl       #0x382bcb8 ; 
006A870C4  b        #0x6a870d8 ; 
006A870C8  ldr      x8, [x2, #0x60]
006A870CC  mov      x0, x19
006A870D0  mov      x1, x20
006A870D4  blr      x8
006A870D8  mov      x0, x19
006A870DC  mov      x1, xzr
006A870E0  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A870E4  adrp     x21, #0x959e000
006A870E8  ldrb     w8, [x21, #0x549]
006A870EC  mov      x20, x0
006A870F0  cbnz     w8, #0x6a87108
006A870F4  adrp     x0, #0x8f38000
006A870F8  ldr      x0, [x0, #0x700]
006A870FC  bl       #0x382bd14 ; 
006A87100  mov      w8, #1
006A87104  strb     w8, [x21, #0x549]
006A87108  adrp     x8, #0x8f38000
006A8710C  ldr      x8, [x8, #0x700]
006A87110  ldr      x2, [x8]
006A87114  ldrb     w8, [x2, #0x53]
006A87118  tbnz     w8, #5, #0x6a87124
006A8711C  str      x20, [x19, #0x40]
006A87120  b        #0x6a87134 ; 
006A87124  ldr      x8, [x2, #0x60]
006A87128  mov      x0, x19
006A8712C  mov      x1, x20
006A87130  blr      x8
006A87134  mov      x0, x19
006A87138  mov      x1, xzr
006A8713C  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A87140  adrp     x21, #0x959e000
006A87144  ldrb     w8, [x21, #0x54a]
006A87148  mov      x20, x0
006A8714C  cbnz     w8, #0x6a87164
006A87150  adrp     x0, #0x8f38000
006A87154  ldr      x0, [x0, #0x710]
006A87158  bl       #0x382bd14 ; 
006A8715C  mov      w8, #1
006A87160  strb     w8, [x21, #0x54a]
006A87164  adrp     x8, #0x8f38000
006A87168  ldr      x8, [x8, #0x710]
006A8716C  ldr      x2, [x8]
006A87170  ldrb     w8, [x2, #0x53]
006A87174  tbnz     w8, #5, #0x6a87180
006A87178  str      x20, [x19, #0x48]
006A8717C  b        #0x6a87190 ; 
006A87180  ldr      x8, [x2, #0x60]
006A87184  mov      x0, x19
006A87188  mov      x1, x20
006A8718C  blr      x8
006A87190  ldp      x20, x19, [sp, #0x10]
006A87194  mov      w0, #1
006A87198  ldp      x30, x21, [sp], #0x20
006A8719C  ret      

