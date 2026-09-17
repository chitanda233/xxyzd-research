; LocalModels.BaseLocalBean$$.ctor
; RVA 0x64C9CBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C9CBC  stp      x30, x21, [sp, #-0x20]!
0064C9CC0  stp      x20, x19, [sp, #0x10]
0064C9CC4  adrp     x20, #0x9597000
0064C9CC8  adrp     x21, #0x8ef9000
0064C9CCC  ldrb     w8, [x20, #0xfbe]
0064C9CD0  ldr      x21, [x21, #0xfb0]
0064C9CD4  mov      x19, x0
0064C9CD8  tbnz     w8, #0, #0x64c9cf0
0064C9CDC  adrp     x0, #0x8ef9000
0064C9CE0  ldr      x0, [x0, #0xfb0]
0064C9CE4  bl       #0x382bd14 ; 
0064C9CE8  mov      w8, #1
0064C9CEC  strb     w8, [x20, #0xfbe]
0064C9CF0  ldr      x1, [x21]
0064C9CF4  ldrb     w8, [x1, #0x53]
0064C9CF8  tbnz     w8, #5, #0x64c9d18
0064C9CFC  mov      x0, x19
0064C9D00  mov      x1, xzr
0064C9D04  bl       #0x7c335dc ; System.Object$$.ctor
0064C9D08  str      wzr, [x19, #0x14]
0064C9D0C  ldp      x20, x19, [sp, #0x10]
0064C9D10  ldp      x30, x21, [sp], #0x20
0064C9D14  ret      
0064C9D18  ldr      x2, [x1, #0x60]
0064C9D1C  mov      x0, x19
0064C9D20  ldp      x20, x19, [sp, #0x10]
0064C9D24  ldp      x30, x21, [sp], #0x20
0064C9D28  br       x2

; LocalModels.BaseLocalBean$$readFromBytes
; RVA 0x64C9D2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C9D2C  stp      x30, x23, [sp, #-0x30]!
0064C9D30  stp      x22, x21, [sp, #0x10]
0064C9D34  stp      x20, x19, [sp, #0x20]
0064C9D38  adrp     x22, #0x9597000
0064C9D3C  adrp     x23, #0x8ef9000
0064C9D40  ldrb     w8, [x22, #0xfbf]
0064C9D44  ldr      x23, [x23, #0xfb8]
0064C9D48  mov      w20, w2
0064C9D4C  mov      x21, x1
0064C9D50  mov      x19, x0
0064C9D54  tbnz     w8, #0, #0x64c9d6c
0064C9D58  adrp     x0, #0x8ef9000
0064C9D5C  ldr      x0, [x0, #0xfb8]
0064C9D60  bl       #0x382bd14 ; 
0064C9D64  mov      w8, #1
0064C9D68  strb     w8, [x22, #0xfbf]
0064C9D6C  ldr      x3, [x23]
0064C9D70  ldrb     w8, [x3, #0x53]
0064C9D74  tbnz     w8, #5, #0x64c9dc8
0064C9D78  mov      x22, x19
0064C9D7C  str      x21, [x22, #0x18]!
0064C9D80  mov      x0, x22
0064C9D84  mov      x1, x21
0064C9D88  bl       #0x382bcb8 ; 
0064C9D8C  mov      x0, x19
0064C9D90  str      w20, [x19, #0x14]
0064C9D94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0064C9D98  ldr      x8, [x19]
0064C9D9C  str      w0, [x19, #0x10]
0064C9DA0  mov      x0, x19
0064C9DA4  ldp      x9, x1, [x8, #0x198]
0064C9DA8  blr      x9
0064C9DAC  tbz      w0, #0, #0x64c9de8
0064C9DB0  mov      x0, x22
0064C9DB4  mov      x1, xzr
0064C9DB8  str      xzr, [x19, #0x18]
0064C9DBC  bl       #0x382bcb8 ; 
0064C9DC0  ldr      w0, [x19, #0x14]
0064C9DC4  b        #0x64c9dec ; 
0064C9DC8  ldr      x4, [x3, #0x60]
0064C9DCC  mov      x0, x19
0064C9DD0  mov      x1, x21
0064C9DD4  mov      w2, w20
0064C9DD8  ldp      x20, x19, [sp, #0x20]
0064C9DDC  ldp      x22, x21, [sp, #0x10]
0064C9DE0  ldp      x30, x23, [sp], #0x30
0064C9DE4  br       x4
0064C9DE8  mov      w0, #-1
0064C9DEC  ldp      x20, x19, [sp, #0x20]
0064C9DF0  ldp      x22, x21, [sp, #0x10]
0064C9DF4  ldp      x30, x23, [sp], #0x30
0064C9DF8  ret      

; LocalModels.BaseLocalBean$$getLength
; RVA 0x64C9ED4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C9ED4  stp      x30, x21, [sp, #-0x20]!
0064C9ED8  stp      x20, x19, [sp, #0x10]
0064C9EDC  adrp     x20, #0x9597000
0064C9EE0  adrp     x21, #0x8ef9000
0064C9EE4  ldrb     w8, [x20, #0xfc0]
0064C9EE8  ldr      x21, [x21, #0xfc8]
0064C9EEC  mov      x19, x0
0064C9EF0  tbnz     w8, #0, #0x64c9f08
0064C9EF4  adrp     x0, #0x8ef9000
0064C9EF8  ldr      x0, [x0, #0xfc8]
0064C9EFC  bl       #0x382bd14 ; 
0064C9F00  mov      w8, #1
0064C9F04  strb     w8, [x20, #0xfc0]
0064C9F08  ldr      x1, [x21]
0064C9F0C  ldrb     w8, [x1, #0x53]
0064C9F10  tbnz     w8, #5, #0x64c9f24
0064C9F14  ldr      w0, [x19, #0x10]
0064C9F18  ldp      x20, x19, [sp, #0x10]
0064C9F1C  ldp      x30, x21, [sp], #0x20
0064C9F20  ret      
0064C9F24  ldr      x2, [x1, #0x60]
0064C9F28  mov      x0, x19
0064C9F2C  ldp      x20, x19, [sp, #0x10]
0064C9F30  ldp      x30, x21, [sp], #0x20
0064C9F34  br       x2

; LocalModels.BaseLocalBean$$readBytes
; RVA 0x64C9F38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C9F38  stp      x30, x23, [sp, #-0x30]!
0064C9F3C  stp      x22, x21, [sp, #0x10]
0064C9F40  stp      x20, x19, [sp, #0x20]
0064C9F44  adrp     x22, #0x9597000
0064C9F48  adrp     x23, #0x8ef9000
0064C9F4C  ldrb     w8, [x22, #0xfc1]
0064C9F50  ldr      x23, [x23, #0xfd0]
0064C9F54  mov      w21, w2
0064C9F58  mov      x19, x1
0064C9F5C  mov      x20, x0
0064C9F60  tbnz     w8, #0, #0x64c9f78
0064C9F64  adrp     x0, #0x8ef9000
0064C9F68  ldr      x0, [x0, #0xfd0]
0064C9F6C  bl       #0x382bd14 ; 
0064C9F70  mov      w8, #1
0064C9F74  strb     w8, [x22, #0xfc1]
0064C9F78  ldr      x3, [x23]
0064C9F7C  ldrb     w8, [x3, #0x53]
0064C9F80  tbnz     w8, #5, #0x64c9ff4
0064C9F84  cmp      w21, #1
0064C9F88  b.lt     #0x64c9fe4
0064C9F8C  ldr      w11, [x20, #0x14]
0064C9F90  mov      x8, xzr
0064C9F94  mov      w9, w21
0064C9F98  add      x10, x19, #0x20
0064C9F9C  ldr      x12, [x20, #0x18]
0064C9FA0  cbz      x12, #0x64ca014
0064C9FA4  ldr      w13, [x12, #0x18]
0064C9FA8  cmp      w11, w13
0064C9FAC  b.hs     #0x64ca018
0064C9FB0  cbz      x19, #0x64ca014
0064C9FB4  ldr      w13, [x19, #0x18]
0064C9FB8  cmp      x8, x13
0064C9FBC  b.hs     #0x64ca018
0064C9FC0  add      x11, x12, w11, sxtw
0064C9FC4  ldrb     w11, [x11, #0x20]
0064C9FC8  strb     w11, [x10, x8]
0064C9FCC  ldr      w11, [x20, #0x14]
0064C9FD0  add      x8, x8, #1
0064C9FD4  cmp      x9, x8
0064C9FD8  add      w11, w11, #1
0064C9FDC  str      w11, [x20, #0x14]
0064C9FE0  b.ne     #0x64c9f9c
0064C9FE4  ldp      x20, x19, [sp, #0x20]
0064C9FE8  ldp      x22, x21, [sp, #0x10]
0064C9FEC  ldp      x30, x23, [sp], #0x30
0064C9FF0  ret      
0064C9FF4  ldr      x4, [x3, #0x60]
0064C9FF8  mov      x0, x20
0064C9FFC  mov      x1, x19
0064CA000  mov      w2, w21
0064CA004  ldp      x20, x19, [sp, #0x20]
0064CA008  ldp      x22, x21, [sp, #0x10]
0064CA00C  ldp      x30, x23, [sp], #0x30
0064CA010  br       x4
0064CA014  bl       #0x382bfb8 ; 
0064CA018  bl       #0x382bfc0 ; 

; LocalModels.BaseLocalBean$$readShort
; RVA 0x64CA01C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA01C  stp      x30, x21, [sp, #-0x20]!
0064CA020  stp      x20, x19, [sp, #0x10]
0064CA024  adrp     x20, #0x9597000
0064CA028  adrp     x21, #0x8ef9000
0064CA02C  ldrb     w8, [x20, #0xfc2]
0064CA030  ldr      x21, [x21, #0xfd8]
0064CA034  mov      x19, x0
0064CA038  tbnz     w8, #0, #0x64ca068
0064CA03C  adrp     x0, #0x8ef9000
0064CA040  ldr      x0, [x0, #0xfd8]
0064CA044  bl       #0x382bd14 ; 
0064CA048  adrp     x0, #0x8ebf000
0064CA04C  ldr      x0, [x0, #0x410]
0064CA050  bl       #0x382bd14 ; 
0064CA054  adrp     x0, #0x8ec3000
0064CA058  ldr      x0, [x0, #0x5e0]
0064CA05C  bl       #0x382bd14 ; 
0064CA060  mov      w8, #1
0064CA064  strb     w8, [x20, #0xfc2]
0064CA068  ldr      x1, [x21]
0064CA06C  ldrb     w8, [x1, #0x53]
0064CA070  tbnz     w8, #5, #0x64ca0e0
0064CA074  adrp     x8, #0x8ebf000
0064CA078  ldr      x8, [x8, #0x410]
0064CA07C  adrp     x21, #0x8ec3000
0064CA080  mov      w1, #2
0064CA084  ldr      x0, [x8]
0064CA088  ldr      x21, [x21, #0x5e0]
0064CA08C  bl       #0x382bdfc ; 
0064CA090  mov      x20, x0
0064CA094  mov      w2, #2
0064CA098  mov      x0, x19
0064CA09C  mov      x1, x20
0064CA0A0  bl       #0x64c9f38 ; LocalModels.BaseLocalBean$$readBytes
0064CA0A4  mov      x0, x20
0064CA0A8  mov      w1, wzr
0064CA0AC  mov      x2, xzr
0064CA0B0  bl       #0x7ae1a20 ; System.BitConverter$$ToInt16
0064CA0B4  ldr      x8, [x21]
0064CA0B8  mov      w19, w0
0064CA0BC  ldr      w9, [x8, #0xe0]
0064CA0C0  cbnz     w9, #0x64ca0cc
0064CA0C4  mov      x0, x8
0064CA0C8  bl       #0x382be8c ; 
0064CA0CC  mov      w0, w19
0064CA0D0  ldp      x20, x19, [sp, #0x10]
0064CA0D4  mov      x1, xzr
0064CA0D8  ldp      x30, x21, [sp], #0x20
0064CA0DC  b        #0x8446dd0 ; System.Net.IPAddress$$NetworkToHostOrder
0064CA0E0  ldr      x2, [x1, #0x60]
0064CA0E4  mov      x0, x19
0064CA0E8  ldp      x20, x19, [sp, #0x10]
0064CA0EC  ldp      x30, x21, [sp], #0x20
0064CA0F0  br       x2

; LocalModels.BaseLocalBean$$readBool
; RVA 0x64CA0F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA0F4  stp      x30, x21, [sp, #-0x20]!
0064CA0F8  stp      x20, x19, [sp, #0x10]
0064CA0FC  adrp     x20, #0x9597000
0064CA100  adrp     x21, #0x8ef9000
0064CA104  ldrb     w8, [x20, #0xfc3]
0064CA108  ldr      x21, [x21, #0xfe0]
0064CA10C  mov      x19, x0
0064CA110  tbnz     w8, #0, #0x64ca128
0064CA114  adrp     x0, #0x8ef9000
0064CA118  ldr      x0, [x0, #0xfe0]
0064CA11C  bl       #0x382bd14 ; 
0064CA120  mov      w8, #1
0064CA124  strb     w8, [x20, #0xfc3]
0064CA128  ldr      x1, [x21]
0064CA12C  ldrb     w8, [x1, #0x53]
0064CA130  tbnz     w8, #5, #0x64ca154
0064CA134  mov      x0, x19
0064CA138  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CA13C  ldp      x20, x19, [sp, #0x10]
0064CA140  and      w8, w0, #0xffff
0064CA144  cmp      w8, #1
0064CA148  cset     w0, eq
0064CA14C  ldp      x30, x21, [sp], #0x20
0064CA150  ret      
0064CA154  ldr      x2, [x1, #0x60]
0064CA158  mov      x0, x19
0064CA15C  ldp      x20, x19, [sp, #0x10]
0064CA160  ldp      x30, x21, [sp], #0x20
0064CA164  br       x2

; LocalModels.BaseLocalBean$$readInt
; RVA 0x64C9DFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C9DFC  stp      x30, x21, [sp, #-0x20]!
0064C9E00  stp      x20, x19, [sp, #0x10]
0064C9E04  adrp     x20, #0x9597000
0064C9E08  adrp     x21, #0x8ef9000
0064C9E0C  ldrb     w8, [x20, #0xfc4]
0064C9E10  ldr      x21, [x21, #0xfc0]
0064C9E14  mov      x19, x0
0064C9E18  tbnz     w8, #0, #0x64c9e48
0064C9E1C  adrp     x0, #0x8ef9000
0064C9E20  ldr      x0, [x0, #0xfc0]
0064C9E24  bl       #0x382bd14 ; 
0064C9E28  adrp     x0, #0x8ebf000
0064C9E2C  ldr      x0, [x0, #0x410]
0064C9E30  bl       #0x382bd14 ; 
0064C9E34  adrp     x0, #0x8ec3000
0064C9E38  ldr      x0, [x0, #0x5e0]
0064C9E3C  bl       #0x382bd14 ; 
0064C9E40  mov      w8, #1
0064C9E44  strb     w8, [x20, #0xfc4]
0064C9E48  ldr      x1, [x21]
0064C9E4C  ldrb     w8, [x1, #0x53]
0064C9E50  tbnz     w8, #5, #0x64c9ec0
0064C9E54  adrp     x8, #0x8ebf000
0064C9E58  ldr      x8, [x8, #0x410]
0064C9E5C  adrp     x21, #0x8ec3000
0064C9E60  mov      w1, #4
0064C9E64  ldr      x0, [x8]
0064C9E68  ldr      x21, [x21, #0x5e0]
0064C9E6C  bl       #0x382bdfc ; 
0064C9E70  mov      x20, x0
0064C9E74  mov      w2, #4
0064C9E78  mov      x0, x19
0064C9E7C  mov      x1, x20
0064C9E80  bl       #0x64c9f38 ; LocalModels.BaseLocalBean$$readBytes
0064C9E84  mov      x0, x20
0064C9E88  mov      w1, wzr
0064C9E8C  mov      x2, xzr
0064C9E90  bl       #0x7ae1b94 ; System.BitConverter$$ToInt32
0064C9E94  ldr      x8, [x21]
0064C9E98  mov      w19, w0
0064C9E9C  ldr      w9, [x8, #0xe0]
0064C9EA0  cbnz     w9, #0x64c9eac
0064C9EA4  mov      x0, x8
0064C9EA8  bl       #0x382be8c ; 
0064C9EAC  mov      w0, w19
0064C9EB0  ldp      x20, x19, [sp, #0x10]
0064C9EB4  mov      x1, xzr
0064C9EB8  ldp      x30, x21, [sp], #0x20
0064C9EBC  b        #0x8446d7c ; System.Net.IPAddress$$NetworkToHostOrder
0064C9EC0  ldr      x2, [x1, #0x60]
0064C9EC4  mov      x0, x19
0064C9EC8  ldp      x20, x19, [sp, #0x10]
0064C9ECC  ldp      x30, x21, [sp], #0x20
0064C9ED0  br       x2

; LocalModels.BaseLocalBean$$readLong
; RVA 0x64CA168; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA168  stp      x30, x21, [sp, #-0x20]!
0064CA16C  stp      x20, x19, [sp, #0x10]
0064CA170  adrp     x20, #0x9597000
0064CA174  adrp     x21, #0x8ef9000
0064CA178  ldrb     w8, [x20, #0xfc5]
0064CA17C  ldr      x21, [x21, #0xfe8]
0064CA180  mov      x19, x0
0064CA184  tbnz     w8, #0, #0x64ca1b4
0064CA188  adrp     x0, #0x8ef9000
0064CA18C  ldr      x0, [x0, #0xfe8]
0064CA190  bl       #0x382bd14 ; 
0064CA194  adrp     x0, #0x8ebf000
0064CA198  ldr      x0, [x0, #0x410]
0064CA19C  bl       #0x382bd14 ; 
0064CA1A0  adrp     x0, #0x8ec3000
0064CA1A4  ldr      x0, [x0, #0x5e0]
0064CA1A8  bl       #0x382bd14 ; 
0064CA1AC  mov      w8, #1
0064CA1B0  strb     w8, [x20, #0xfc5]
0064CA1B4  ldr      x1, [x21]
0064CA1B8  ldrb     w8, [x1, #0x53]
0064CA1BC  tbnz     w8, #5, #0x64ca22c
0064CA1C0  adrp     x8, #0x8ebf000
0064CA1C4  ldr      x8, [x8, #0x410]
0064CA1C8  adrp     x21, #0x8ec3000
0064CA1CC  mov      w1, #8
0064CA1D0  ldr      x0, [x8]
0064CA1D4  ldr      x21, [x21, #0x5e0]
0064CA1D8  bl       #0x382bdfc ; 
0064CA1DC  mov      x20, x0
0064CA1E0  mov      w2, #8
0064CA1E4  mov      x0, x19
0064CA1E8  mov      x1, x20
0064CA1EC  bl       #0x64c9f38 ; LocalModels.BaseLocalBean$$readBytes
0064CA1F0  mov      x0, x20
0064CA1F4  mov      w1, wzr
0064CA1F8  mov      x2, xzr
0064CA1FC  bl       #0x7ae1c90 ; System.BitConverter$$ToInt64
0064CA200  ldr      x8, [x21]
0064CA204  mov      x19, x0
0064CA208  ldr      w9, [x8, #0xe0]
0064CA20C  cbnz     w9, #0x64ca218
0064CA210  mov      x0, x8
0064CA214  bl       #0x382be8c ; 
0064CA218  mov      x0, x19
0064CA21C  ldp      x20, x19, [sp, #0x10]
0064CA220  mov      x1, xzr
0064CA224  ldp      x30, x21, [sp], #0x20
0064CA228  b        #0x8446d28 ; System.Net.IPAddress$$NetworkToHostOrder
0064CA22C  ldr      x2, [x1, #0x60]
0064CA230  mov      x0, x19
0064CA234  ldp      x20, x19, [sp, #0x10]
0064CA238  ldp      x30, x21, [sp], #0x20
0064CA23C  br       x2

; LocalModels.BaseLocalBean$$readDate
; RVA 0x64CA240; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA240  sub      sp, sp, #0x30
0064CA244  stp      x30, x21, [sp, #0x10]
0064CA248  stp      x20, x19, [sp, #0x20]
0064CA24C  adrp     x20, #0x9597000
0064CA250  adrp     x21, #0x8ef9000
0064CA254  ldrb     w8, [x20, #0xfc6]
0064CA258  ldr      x21, [x21, #0xff0]
0064CA25C  mov      x19, x0
0064CA260  tbnz     w8, #0, #0x64ca284
0064CA264  adrp     x0, #0x8ef9000
0064CA268  ldr      x0, [x0, #0xff0]
0064CA26C  bl       #0x382bd14 ; 
0064CA270  adrp     x0, #0x8ef9000
0064CA274  ldr      x0, [x0, #0xff8]
0064CA278  bl       #0x382bd14 ; 
0064CA27C  mov      w8, #1
0064CA280  strb     w8, [x20, #0xfc6]
0064CA284  ldr      x1, [x21]
0064CA288  ldrb     w8, [x1, #0x53]
0064CA28C  tbnz     w8, #5, #0x64ca2e8
0064CA290  adrp     x20, #0x8ef9000
0064CA294  ldr      x20, [x20, #0xff8]
0064CA298  mov      x0, x19
0064CA29C  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
0064CA2A0  ldr      x8, [x20]
0064CA2A4  mov      x19, x0
0064CA2A8  ldr      w9, [x8, #0xe0]
0064CA2AC  cbnz     w9, #0x64ca2bc
0064CA2B0  mov      x0, x8
0064CA2B4  bl       #0x382be8c ; 
0064CA2B8  ldr      x8, [x20]
0064CA2BC  ldr      x8, [x8, #0xb8]
0064CA2C0  add      x0, sp, #8
0064CA2C4  mov      x2, xzr
0064CA2C8  ldrsw    x9, [x8, #8]
0064CA2CC  ldr      x8, [x8]
0064CA2D0  str      xzr, [sp, #8]
0064CA2D4  nop      
0064CA2D8  madd     x1, x19, x9, x8
0064CA2DC  bl       #0x7bae4c4 ; System.DateTime$$.ctor
0064CA2E0  ldr      x0, [sp, #8]
0064CA2E4  b        #0x64ca2f8 ; 
0064CA2E8  ldr      x8, [x1, #0x60]
0064CA2EC  mov      x0, x19
0064CA2F0  blr      x8
0064CA2F4  str      x0, [sp, #8]
0064CA2F8  ldp      x20, x19, [sp, #0x20]
0064CA2FC  ldp      x30, x21, [sp, #0x10]
0064CA300  add      sp, sp, #0x30
0064CA304  ret      

; LocalModels.BaseLocalBean$$readFloat
; RVA 0x64CA308; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA308  stp      x30, x21, [sp, #-0x20]!
0064CA30C  stp      x20, x19, [sp, #0x10]
0064CA310  adrp     x20, #0x9597000
0064CA314  adrp     x21, #0x8efa000
0064CA318  ldrb     w8, [x20, #0xfc7]
0064CA31C  ldr      x21, [x21]
0064CA320  mov      x19, x0
0064CA324  tbnz     w8, #0, #0x64ca354
0064CA328  adrp     x0, #0x8efa000
0064CA32C  ldr      x0, [x0]
0064CA330  bl       #0x382bd14 ; 
0064CA334  adrp     x0, #0x8ebf000
0064CA338  ldr      x0, [x0, #0x410]
0064CA33C  bl       #0x382bd14 ; 
0064CA340  adrp     x0, #0x8ec3000
0064CA344  ldr      x0, [x0, #0x5e0]
0064CA348  bl       #0x382bd14 ; 
0064CA34C  mov      w8, #1
0064CA350  strb     w8, [x20, #0xfc7]
0064CA354  ldr      x1, [x21]
0064CA358  ldrb     w8, [x1, #0x53]
0064CA35C  tbnz     w8, #5, #0x64ca3e0
0064CA360  adrp     x8, #0x8ebf000
0064CA364  ldr      x8, [x8, #0x410]
0064CA368  adrp     x21, #0x8ec3000
0064CA36C  mov      w1, #4
0064CA370  ldr      x0, [x8]
0064CA374  ldr      x21, [x21, #0x5e0]
0064CA378  bl       #0x382bdfc ; 
0064CA37C  mov      x20, x0
0064CA380  mov      w2, #4
0064CA384  mov      x0, x19
0064CA388  mov      x1, x20
0064CA38C  bl       #0x64c9f38 ; LocalModels.BaseLocalBean$$readBytes
0064CA390  mov      x0, x20
0064CA394  mov      w1, wzr
0064CA398  mov      x2, xzr
0064CA39C  bl       #0x7ae1b94 ; System.BitConverter$$ToInt32
0064CA3A0  ldr      x8, [x21]
0064CA3A4  mov      w19, w0
0064CA3A8  ldr      w9, [x8, #0xe0]
0064CA3AC  cbnz     w9, #0x64ca3b8
0064CA3B0  mov      x0, x8
0064CA3B4  bl       #0x382be8c ; 
0064CA3B8  mov      w0, w19
0064CA3BC  mov      x1, xzr
0064CA3C0  bl       #0x8446d7c ; System.Net.IPAddress$$NetworkToHostOrder
0064CA3C4  mov      x1, xzr
0064CA3C8  bl       #0x7ae13d0 ; System.BitConverter$$GetBytes
0064CA3CC  ldp      x20, x19, [sp, #0x10]
0064CA3D0  mov      w1, wzr
0064CA3D4  mov      x2, xzr
0064CA3D8  ldp      x30, x21, [sp], #0x20
0064CA3DC  b        #0x7ae1f00 ; System.BitConverter$$ToSingle
0064CA3E0  ldr      x2, [x1, #0x60]
0064CA3E4  mov      x0, x19
0064CA3E8  ldp      x20, x19, [sp, #0x10]
0064CA3EC  ldp      x30, x21, [sp], #0x20
0064CA3F0  br       x2

; LocalModels.BaseLocalBean$$readFp
; RVA 0x64CA3F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA3F4  stp      x30, x21, [sp, #-0x20]!
0064CA3F8  stp      x20, x19, [sp, #0x10]
0064CA3FC  adrp     x20, #0x9597000
0064CA400  adrp     x21, #0x8efa000
0064CA404  ldrb     w8, [x20, #0xfc8]
0064CA408  ldr      x21, [x21, #8]
0064CA40C  mov      x19, x0
0064CA410  tbnz     w8, #0, #0x64ca428
0064CA414  adrp     x0, #0x8efa000
0064CA418  ldr      x0, [x0, #8]
0064CA41C  bl       #0x382bd14 ; 
0064CA420  mov      w8, #1
0064CA424  strb     w8, [x20, #0xfc8]
0064CA428  ldr      x1, [x21]
0064CA42C  ldrb     w8, [x1, #0x53]
0064CA430  tbnz     w8, #5, #0x64ca468
0064CA434  mov      x0, x19
0064CA438  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0064CA43C  mov      x9, #0x594b
0064CA440  movk     x9, #0x3886, lsl #16
0064CA444  movk     x9, #0xc5d6, lsl #32
0064CA448  sbfiz    x8, x0, #0x10, #0x20
0064CA44C  movk     x9, #0x346d, lsl #48
0064CA450  ldp      x20, x19, [sp, #0x10]
0064CA454  smulh    x8, x8, x9
0064CA458  asr      x9, x8, #0xb
0064CA45C  add      x0, x9, x8, lsr #63
0064CA460  ldp      x30, x21, [sp], #0x20
0064CA464  ret      
0064CA468  ldr      x2, [x1, #0x60]
0064CA46C  mov      x0, x19
0064CA470  ldp      x20, x19, [sp, #0x10]
0064CA474  ldp      x30, x21, [sp], #0x20
0064CA478  br       x2

; LocalModels.BaseLocalBean$$readDouble
; RVA 0x64CA47C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA47C  stp      x30, x21, [sp, #-0x20]!
0064CA480  stp      x20, x19, [sp, #0x10]
0064CA484  adrp     x20, #0x9597000
0064CA488  adrp     x21, #0x8efa000
0064CA48C  ldrb     w8, [x20, #0xfc9]
0064CA490  ldr      x21, [x21, #0x10]
0064CA494  mov      x19, x0
0064CA498  tbnz     w8, #0, #0x64ca4c8
0064CA49C  adrp     x0, #0x8efa000
0064CA4A0  ldr      x0, [x0, #0x10]
0064CA4A4  bl       #0x382bd14 ; 
0064CA4A8  adrp     x0, #0x8ebf000
0064CA4AC  ldr      x0, [x0, #0x410]
0064CA4B0  bl       #0x382bd14 ; 
0064CA4B4  adrp     x0, #0x8ec3000
0064CA4B8  ldr      x0, [x0, #0x5e0]
0064CA4BC  bl       #0x382bd14 ; 
0064CA4C0  mov      w8, #1
0064CA4C4  strb     w8, [x20, #0xfc9]
0064CA4C8  ldr      x1, [x21]
0064CA4CC  ldrb     w8, [x1, #0x53]
0064CA4D0  tbnz     w8, #5, #0x64ca548
0064CA4D4  adrp     x8, #0x8ebf000
0064CA4D8  ldr      x8, [x8, #0x410]
0064CA4DC  adrp     x21, #0x8ec3000
0064CA4E0  mov      w1, #8
0064CA4E4  ldr      x0, [x8]
0064CA4E8  ldr      x21, [x21, #0x5e0]
0064CA4EC  bl       #0x382bdfc ; 
0064CA4F0  mov      x20, x0
0064CA4F4  mov      w2, #8
0064CA4F8  mov      x0, x19
0064CA4FC  mov      x1, x20
0064CA500  bl       #0x64c9f38 ; LocalModels.BaseLocalBean$$readBytes
0064CA504  mov      x0, x20
0064CA508  mov      w1, wzr
0064CA50C  mov      x2, xzr
0064CA510  bl       #0x7ae1c90 ; System.BitConverter$$ToInt64
0064CA514  ldr      x8, [x21]
0064CA518  mov      x19, x0
0064CA51C  ldr      w9, [x8, #0xe0]
0064CA520  cbnz     w9, #0x64ca52c
0064CA524  mov      x0, x8
0064CA528  bl       #0x382be8c ; 
0064CA52C  mov      x0, x19
0064CA530  mov      x1, xzr
0064CA534  bl       #0x8446d28 ; System.Net.IPAddress$$NetworkToHostOrder
0064CA538  ldp      x20, x19, [sp, #0x10]
0064CA53C  fmov     d0, x0
0064CA540  ldp      x30, x21, [sp], #0x20
0064CA544  ret      
0064CA548  ldr      x2, [x1, #0x60]
0064CA54C  mov      x0, x19
0064CA550  ldp      x20, x19, [sp, #0x10]
0064CA554  ldp      x30, x21, [sp], #0x20
0064CA558  br       x2

; LocalModels.BaseLocalBean$$readLocalString
; RVA 0x64CA55C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA55C  str      x30, [sp, #-0x30]!
0064CA560  stp      x22, x21, [sp, #0x10]
0064CA564  stp      x20, x19, [sp, #0x20]
0064CA568  adrp     x20, #0x9597000
0064CA56C  adrp     x21, #0x8efa000
0064CA570  ldrb     w8, [x20, #0xfca]
0064CA574  ldr      x21, [x21, #0x18]
0064CA578  mov      x19, x0
0064CA57C  tbnz     w8, #0, #0x64ca5ac
0064CA580  adrp     x0, #0x8efa000
0064CA584  ldr      x0, [x0, #0x18]
0064CA588  bl       #0x382bd14 ; 
0064CA58C  adrp     x0, #0x8ef9000
0064CA590  ldr      x0, [x0, #0xff8]
0064CA594  bl       #0x382bd14 ; 
0064CA598  adrp     x0, #0x8ebf000
0064CA59C  ldr      x0, [x0, #0x410]
0064CA5A0  bl       #0x382bd14 ; 
0064CA5A4  mov      w8, #1
0064CA5A8  strb     w8, [x20, #0xfca]
0064CA5AC  ldr      x1, [x21]
0064CA5B0  ldrb     w8, [x1, #0x53]
0064CA5B4  tbnz     w8, #5, #0x64ca640
0064CA5B8  adrp     x20, #0x8ebf000
0064CA5BC  adrp     x22, #0x8ef9000
0064CA5C0  ldr      x20, [x20, #0x410]
0064CA5C4  ldr      x22, [x22, #0xff8]
0064CA5C8  mov      x0, x19
0064CA5CC  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CA5D0  ldr      x8, [x20]
0064CA5D4  sxth     w9, w0
0064CA5D8  sub      w21, w9, #2
0064CA5DC  mov      w1, w21
0064CA5E0  mov      x0, x8
0064CA5E4  bl       #0x382bdfc ; 
0064CA5E8  mov      x20, x0
0064CA5EC  mov      x0, x19
0064CA5F0  mov      x1, x20
0064CA5F4  mov      w2, w21
0064CA5F8  bl       #0x64c9f38 ; LocalModels.BaseLocalBean$$readBytes
0064CA5FC  ldr      x0, [x22]
0064CA600  ldr      w8, [x0, #0xe0]
0064CA604  cbnz     w8, #0x64ca610
0064CA608  bl       #0x382be8c ; 
0064CA60C  ldr      x0, [x22]
0064CA610  ldr      x8, [x0, #0xb8]
0064CA614  ldr      x0, [x8, #0x10]
0064CA618  cbz      x0, #0x64ca658
0064CA61C  ldr      x8, [x0]
0064CA620  ldr      x9, [x8, #0x428]
0064CA624  ldr      x2, [x8, #0x430]
0064CA628  mov      x1, x20
0064CA62C  blr      x9
0064CA630  ldp      x20, x19, [sp, #0x20]
0064CA634  ldp      x22, x21, [sp, #0x10]
0064CA638  ldr      x30, [sp], #0x30
0064CA63C  ret      
0064CA640  ldr      x2, [x1, #0x60]
0064CA644  mov      x0, x19
0064CA648  ldp      x20, x19, [sp, #0x20]
0064CA64C  ldp      x22, x21, [sp, #0x10]
0064CA650  ldr      x30, [sp], #0x30
0064CA654  br       x2
0064CA658  bl       #0x382bfb8 ; 
0064CA65C  b        #0x64ca664 ; 
0064CA660  b        #0x64ca664 ; 
0064CA664  mov      x19, x0
0064CA668  cmp      w1, #1
0064CA66C  b.ne     #0x64ca72c
0064CA670  mov      x0, x19
0064CA674  bl       #0x89eda50 ; 
0064CA678  mov      x19, x0
0064CA67C  adrp     x0, #0x8ebf000
0064CA680  ldr      x0, [x0, #0xc70]
0064CA684  bl       #0x382bd28 ; 
0064CA688  ldr      x8, [x19]
0064CA68C  ldr      x1, [x8]
0064CA690  bl       #0x382c3e4 ; 
0064CA694  tbz      w0, #0, #0x64ca704
0064CA698  ldr      x19, [x19]
0064CA69C  bl       #0x89eda60 ; 
0064CA6A0  adrp     x0, #0x8ee1000
0064CA6A4  ldr      x0, [x0, #0x6e8]
0064CA6A8  bl       #0x382bd28 ; 
0064CA6AC  ldr      w8, [x0, #0xe0]
0064CA6B0  cbnz     w8, #0x64ca6b8
0064CA6B4  bl       #0x382be8c ; 
0064CA6B8  adrp     x0, #0x8efa000
0064CA6BC  ldr      x0, [x0, #0x20]
0064CA6C0  bl       #0x382bd28 ; 
0064CA6C4  mov      x20, x0
0064CA6C8  adrp     x0, #0x8efa000
0064CA6CC  ldr      x0, [x0, #0x28]
0064CA6D0  bl       #0x382bd28 ; 
0064CA6D4  mov      x2, x0
0064CA6D8  mov      w3, #0x95
0064CA6DC  mov      x0, x19
0064CA6E0  mov      x1, x20
0064CA6E4  mov      x4, xzr
0064CA6E8  bl       #0x799724c ; Logger$$LogException
0064CA6EC  adrp     x0, #0x8ebf000
0064CA6F0  ldr      x0, [x0, #0x8e0]
0064CA6F4  ldp      x20, x19, [sp, #0x20]
0064CA6F8  ldp      x22, x21, [sp, #0x10]
0064CA6FC  ldr      x30, [sp], #0x30
0064CA700  b        #0x382bd28 ; 
0064CA704  mov      w0, #8
0064CA708  bl       #0x89eda70 ; 
0064CA70C  ldr      x8, [x19]
0064CA710  str      x8, [x0]
0064CA714  adrp     x1, #0x89f3000
0064CA718  add      x1, x1, #0xf98
0064CA71C  mov      x2, xzr
0064CA720  bl       #0x89eda80 ; 
0064CA724  mov      x19, x0
0064CA728  bl       #0x89eda60 ; 
0064CA72C  mov      x0, x19
0064CA730  bl       #0x3b56bfc ; 
0064CA734  bl       #0x3442448 ; 

; LocalModels.BaseLocalBean$$readCommonString
; RVA 0x64CA738; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA738  stp      x30, x21, [sp, #-0x20]!
0064CA73C  stp      x20, x19, [sp, #0x10]
0064CA740  adrp     x20, #0x9597000
0064CA744  adrp     x21, #0x8efa000
0064CA748  ldrb     w8, [x20, #0xfcb]
0064CA74C  ldr      x21, [x21, #0x30]
0064CA750  mov      x19, x0
0064CA754  tbnz     w8, #0, #0x64ca76c
0064CA758  adrp     x0, #0x8efa000
0064CA75C  ldr      x0, [x0, #0x30]
0064CA760  bl       #0x382bd14 ; 
0064CA764  mov      w8, #1
0064CA768  strb     w8, [x20, #0xfcb]
0064CA76C  ldr      x1, [x21]
0064CA770  ldrb     w8, [x1, #0x53]
0064CA774  tbnz     w8, #5, #0x64ca794
0064CA778  mov      x0, x19
0064CA77C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0064CA780  mov      x1, x0
0064CA784  mov      x0, x19
0064CA788  ldp      x20, x19, [sp, #0x10]
0064CA78C  ldp      x30, x21, [sp], #0x20
0064CA790  b        #0x64ca7a8 ; LocalModels.BaseLocalBean$$toCommonString
0064CA794  ldr      x2, [x1, #0x60]
0064CA798  mov      x0, x19
0064CA79C  ldp      x20, x19, [sp, #0x10]
0064CA7A0  ldp      x30, x21, [sp], #0x20
0064CA7A4  br       x2

; LocalModels.BaseLocalBean$$readArrayint
; RVA 0x64CA820; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA820  stp      x30, x23, [sp, #-0x30]!
0064CA824  stp      x22, x21, [sp, #0x10]
0064CA828  stp      x20, x19, [sp, #0x20]
0064CA82C  adrp     x20, #0x9597000
0064CA830  adrp     x21, #0x8efa000
0064CA834  ldrb     w8, [x20, #0xfcc]
0064CA838  ldr      x21, [x21, #0x40]
0064CA83C  mov      x19, x0
0064CA840  tbnz     w8, #0, #0x64ca864
0064CA844  adrp     x0, #0x8efa000
0064CA848  ldr      x0, [x0, #0x40]
0064CA84C  bl       #0x382bd14 ; 
0064CA850  adrp     x0, #0x8ec1000
0064CA854  ldr      x0, [x0, #0x240]
0064CA858  bl       #0x382bd14 ; 
0064CA85C  mov      w8, #1
0064CA860  strb     w8, [x20, #0xfcc]
0064CA864  ldr      x1, [x21]
0064CA868  ldrb     w8, [x1, #0x53]
0064CA86C  tbnz     w8, #5, #0x64ca8e8
0064CA870  adrp     x20, #0x8ec1000
0064CA874  ldr      x20, [x20, #0x240]
0064CA878  mov      x0, x19
0064CA87C  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CA880  ldr      x8, [x20]
0064CA884  sxth     w21, w0
0064CA888  mov      w1, w21
0064CA88C  mov      x0, x8
0064CA890  bl       #0x382bdfc ; 
0064CA894  cmp      w21, #1
0064CA898  mov      x20, x0
0064CA89C  b.lt     #0x64ca8d4
0064CA8A0  mov      x22, xzr
0064CA8A4  mov      w21, w21
0064CA8A8  add      x23, x20, #0x20
0064CA8AC  mov      x0, x19
0064CA8B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0064CA8B4  cbz      x20, #0x64ca900
0064CA8B8  ldr      w8, [x20, #0x18]
0064CA8BC  cmp      x22, x8
0064CA8C0  b.hs     #0x64ca904
0064CA8C4  str      w0, [x23, x22, lsl #2]
0064CA8C8  add      x22, x22, #1
0064CA8CC  cmp      x21, x22
0064CA8D0  b.ne     #0x64ca8ac
0064CA8D4  mov      x0, x20
0064CA8D8  ldp      x20, x19, [sp, #0x20]
0064CA8DC  ldp      x22, x21, [sp, #0x10]
0064CA8E0  ldp      x30, x23, [sp], #0x30
0064CA8E4  ret      
0064CA8E8  ldr      x2, [x1, #0x60]
0064CA8EC  mov      x0, x19
0064CA8F0  ldp      x20, x19, [sp, #0x20]
0064CA8F4  ldp      x22, x21, [sp, #0x10]
0064CA8F8  ldp      x30, x23, [sp], #0x30
0064CA8FC  br       x2
0064CA900  bl       #0x382bfb8 ; 
0064CA904  bl       #0x382bfc0 ; 

; LocalModels.BaseLocalBean$$readArrayArrayint
; RVA 0x64CA908; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA908  str      x30, [sp, #-0x40]!
0064CA90C  stp      x24, x23, [sp, #0x10]
0064CA910  stp      x22, x21, [sp, #0x20]
0064CA914  stp      x20, x19, [sp, #0x30]
0064CA918  adrp     x20, #0x9597000
0064CA91C  adrp     x21, #0x8efa000
0064CA920  ldrb     w8, [x20, #0xfcd]
0064CA924  ldr      x21, [x21, #0x48]
0064CA928  mov      x19, x0
0064CA92C  tbnz     w8, #0, #0x64ca950
0064CA930  adrp     x0, #0x8efa000
0064CA934  ldr      x0, [x0, #0x48]
0064CA938  bl       #0x382bd14 ; 
0064CA93C  adrp     x0, #0x8ec7000
0064CA940  ldr      x0, [x0, #0xd8]
0064CA944  bl       #0x382bd14 ; 
0064CA948  mov      w8, #1
0064CA94C  strb     w8, [x20, #0xfcd]
0064CA950  ldr      x1, [x21]
0064CA954  ldrb     w8, [x1, #0x53]
0064CA958  tbnz     w8, #5, #0x64ca9ec
0064CA95C  adrp     x20, #0x8ec7000
0064CA960  ldr      x20, [x20, #0xd8]
0064CA964  mov      x0, x19
0064CA968  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CA96C  ldr      x8, [x20]
0064CA970  sxth     w21, w0
0064CA974  mov      w1, w21
0064CA978  mov      x0, x8
0064CA97C  bl       #0x382bdfc ; 
0064CA980  cmp      w21, #1
0064CA984  mov      x20, x0
0064CA988  b.lt     #0x64ca9d4
0064CA98C  mov      x22, xzr
0064CA990  mov      w23, w21
0064CA994  add      x21, x20, #0x20
0064CA998  mov      x0, x19
0064CA99C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0064CA9A0  cbz      x20, #0x64caa08
0064CA9A4  ldr      w8, [x20, #0x18]
0064CA9A8  cmp      x22, x8
0064CA9AC  b.hs     #0x64caa0c
0064CA9B0  mov      x24, x21
0064CA9B4  mov      x1, x0
0064CA9B8  str      x0, [x24], #8
0064CA9BC  mov      x0, x21
0064CA9C0  bl       #0x382bcb8 ; 
0064CA9C4  add      x22, x22, #1
0064CA9C8  cmp      x23, x22
0064CA9CC  mov      x21, x24
0064CA9D0  b.ne     #0x64ca998
0064CA9D4  mov      x0, x20
0064CA9D8  ldp      x20, x19, [sp, #0x30]
0064CA9DC  ldp      x22, x21, [sp, #0x20]
0064CA9E0  ldp      x24, x23, [sp, #0x10]
0064CA9E4  ldr      x30, [sp], #0x40
0064CA9E8  ret      
0064CA9EC  ldr      x2, [x1, #0x60]
0064CA9F0  mov      x0, x19
0064CA9F4  ldp      x20, x19, [sp, #0x30]
0064CA9F8  ldp      x22, x21, [sp, #0x20]
0064CA9FC  ldp      x24, x23, [sp, #0x10]
0064CAA00  ldr      x30, [sp], #0x40
0064CAA04  br       x2
0064CAA08  bl       #0x382bfb8 ; 
0064CAA0C  bl       #0x382bfc0 ; 

; LocalModels.BaseLocalBean$$readArraylong
; RVA 0x64CAA10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CAA10  stp      x30, x23, [sp, #-0x30]!
0064CAA14  stp      x22, x21, [sp, #0x10]
0064CAA18  stp      x20, x19, [sp, #0x20]
0064CAA1C  adrp     x20, #0x9597000
0064CAA20  adrp     x21, #0x8efa000
0064CAA24  ldrb     w8, [x20, #0xfce]
0064CAA28  ldr      x21, [x21, #0x50]
0064CAA2C  mov      x19, x0
0064CAA30  tbnz     w8, #0, #0x64caa54
0064CAA34  adrp     x0, #0x8efa000
0064CAA38  ldr      x0, [x0, #0x50]
0064CAA3C  bl       #0x382bd14 ; 
0064CAA40  adrp     x0, #0x8ec8000
0064CAA44  ldr      x0, [x0, #0xf20]
0064CAA48  bl       #0x382bd14 ; 
0064CAA4C  mov      w8, #1
0064CAA50  strb     w8, [x20, #0xfce]
0064CAA54  ldr      x1, [x21]
0064CAA58  ldrb     w8, [x1, #0x53]
0064CAA5C  tbnz     w8, #5, #0x64caad8
0064CAA60  adrp     x20, #0x8ec8000
0064CAA64  ldr      x20, [x20, #0xf20]
0064CAA68  mov      x0, x19
0064CAA6C  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CAA70  ldr      x8, [x20]
0064CAA74  sxth     w21, w0
0064CAA78  mov      w1, w21
0064CAA7C  mov      x0, x8
0064CAA80  bl       #0x382bdfc ; 
0064CAA84  cmp      w21, #1
0064CAA88  mov      x20, x0
0064CAA8C  b.lt     #0x64caac4
0064CAA90  mov      x22, xzr
0064CAA94  mov      w21, w21
0064CAA98  add      x23, x20, #0x20
0064CAA9C  mov      x0, x19
0064CAAA0  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
0064CAAA4  cbz      x20, #0x64caaf0
0064CAAA8  ldr      w8, [x20, #0x18]
0064CAAAC  cmp      x22, x8
0064CAAB0  b.hs     #0x64caaf4
0064CAAB4  str      x0, [x23, x22, lsl #3]
0064CAAB8  add      x22, x22, #1
0064CAABC  cmp      x21, x22
0064CAAC0  b.ne     #0x64caa9c
0064CAAC4  mov      x0, x20
0064CAAC8  ldp      x20, x19, [sp, #0x20]
0064CAACC  ldp      x22, x21, [sp, #0x10]
0064CAAD0  ldp      x30, x23, [sp], #0x30
0064CAAD4  ret      
0064CAAD8  ldr      x2, [x1, #0x60]
0064CAADC  mov      x0, x19
0064CAAE0  ldp      x20, x19, [sp, #0x20]
0064CAAE4  ldp      x22, x21, [sp, #0x10]
0064CAAE8  ldp      x30, x23, [sp], #0x30
0064CAAEC  br       x2
0064CAAF0  bl       #0x382bfb8 ; 
0064CAAF4  bl       #0x382bfc0 ; 

; LocalModels.BaseLocalBean$$readArrayfloat
; RVA 0x64CAAF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CAAF8  stp      x30, x23, [sp, #-0x30]!
0064CAAFC  stp      x22, x21, [sp, #0x10]
0064CAB00  stp      x20, x19, [sp, #0x20]
0064CAB04  adrp     x20, #0x9597000
0064CAB08  adrp     x21, #0x8efa000
0064CAB0C  ldrb     w8, [x20, #0xfcf]
0064CAB10  ldr      x21, [x21, #0x58]
0064CAB14  mov      x19, x0
0064CAB18  tbnz     w8, #0, #0x64cab3c
0064CAB1C  adrp     x0, #0x8efa000
0064CAB20  ldr      x0, [x0, #0x58]
0064CAB24  bl       #0x382bd14 ; 
0064CAB28  adrp     x0, #0x8ec0000
0064CAB2C  ldr      x0, [x0, #0xe08]
0064CAB30  bl       #0x382bd14 ; 
0064CAB34  mov      w8, #1
0064CAB38  strb     w8, [x20, #0xfcf]
0064CAB3C  ldr      x1, [x21]
0064CAB40  ldrb     w8, [x1, #0x53]
0064CAB44  tbnz     w8, #5, #0x64cabc0
0064CAB48  adrp     x20, #0x8ec0000
0064CAB4C  ldr      x20, [x20, #0xe08]
0064CAB50  mov      x0, x19
0064CAB54  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CAB58  ldr      x8, [x20]
0064CAB5C  sxth     w21, w0
0064CAB60  mov      w1, w21
0064CAB64  mov      x0, x8
0064CAB68  bl       #0x382bdfc ; 
0064CAB6C  cmp      w21, #1
0064CAB70  mov      x20, x0
0064CAB74  b.lt     #0x64cabac
0064CAB78  mov      x22, xzr
0064CAB7C  mov      w21, w21
0064CAB80  add      x23, x20, #0x20
0064CAB84  mov      x0, x19
0064CAB88  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0064CAB8C  cbz      x20, #0x64cabd8
0064CAB90  ldr      w8, [x20, #0x18]
0064CAB94  cmp      x22, x8
0064CAB98  b.hs     #0x64cabdc
0064CAB9C  str      s0, [x23, x22, lsl #2]
0064CABA0  add      x22, x22, #1
0064CABA4  cmp      x21, x22
0064CABA8  b.ne     #0x64cab84
0064CABAC  mov      x0, x20
0064CABB0  ldp      x20, x19, [sp, #0x20]
0064CABB4  ldp      x22, x21, [sp, #0x10]
0064CABB8  ldp      x30, x23, [sp], #0x30
0064CABBC  ret      
0064CABC0  ldr      x2, [x1, #0x60]
0064CABC4  mov      x0, x19
0064CABC8  ldp      x20, x19, [sp, #0x20]
0064CABCC  ldp      x22, x21, [sp, #0x10]
0064CABD0  ldp      x30, x23, [sp], #0x30
0064CABD4  br       x2
0064CABD8  bl       #0x382bfb8 ; 
0064CABDC  bl       #0x382bfc0 ; 

; LocalModels.BaseLocalBean$$readArrayfp
; RVA 0x64CABE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CABE0  stp      x30, x23, [sp, #-0x30]!
0064CABE4  stp      x22, x21, [sp, #0x10]
0064CABE8  stp      x20, x19, [sp, #0x20]
0064CABEC  adrp     x20, #0x9597000
0064CABF0  adrp     x21, #0x8efa000
0064CABF4  ldrb     w8, [x20, #0xfd0]
0064CABF8  ldr      x21, [x21, #0x60]
0064CABFC  mov      x19, x0
0064CAC00  tbnz     w8, #0, #0x64cac24
0064CAC04  adrp     x0, #0x8efa000
0064CAC08  ldr      x0, [x0, #0x60]
0064CAC0C  bl       #0x382bd14 ; 
0064CAC10  adrp     x0, #0x8ee2000
0064CAC14  ldr      x0, [x0, #0xe10]
0064CAC18  bl       #0x382bd14 ; 
0064CAC1C  mov      w8, #1
0064CAC20  strb     w8, [x20, #0xfd0]
0064CAC24  ldr      x1, [x21]
0064CAC28  ldrb     w8, [x1, #0x53]
0064CAC2C  tbnz     w8, #5, #0x64caca8
0064CAC30  adrp     x20, #0x8ee2000
0064CAC34  ldr      x20, [x20, #0xe10]
0064CAC38  mov      x0, x19
0064CAC3C  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CAC40  ldr      x8, [x20]
0064CAC44  sxth     w21, w0
0064CAC48  mov      w1, w21
0064CAC4C  mov      x0, x8
0064CAC50  bl       #0x382bdfc ; 
0064CAC54  cmp      w21, #1
0064CAC58  mov      x20, x0
0064CAC5C  b.lt     #0x64cac94
0064CAC60  mov      x22, xzr
0064CAC64  mov      w21, w21
0064CAC68  add      x23, x20, #0x20
0064CAC6C  mov      x0, x19
0064CAC70  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0064CAC74  cbz      x20, #0x64cacc0
0064CAC78  ldr      w8, [x20, #0x18]
0064CAC7C  cmp      x22, x8
0064CAC80  b.hs     #0x64cacc4
0064CAC84  str      x0, [x23, x22, lsl #3]
0064CAC88  add      x22, x22, #1
0064CAC8C  cmp      x21, x22
0064CAC90  b.ne     #0x64cac6c
0064CAC94  mov      x0, x20
0064CAC98  ldp      x20, x19, [sp, #0x20]
0064CAC9C  ldp      x22, x21, [sp, #0x10]
0064CACA0  ldp      x30, x23, [sp], #0x30
0064CACA4  ret      
0064CACA8  ldr      x2, [x1, #0x60]
0064CACAC  mov      x0, x19
0064CACB0  ldp      x20, x19, [sp, #0x20]
0064CACB4  ldp      x22, x21, [sp, #0x10]
0064CACB8  ldp      x30, x23, [sp], #0x30
0064CACBC  br       x2
0064CACC0  bl       #0x382bfb8 ; 
0064CACC4  bl       #0x382bfc0 ; 

; LocalModels.BaseLocalBean$$readArraystring
; RVA 0x64CACC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CACC8  str      x30, [sp, #-0x40]!
0064CACCC  stp      x24, x23, [sp, #0x10]
0064CACD0  stp      x22, x21, [sp, #0x20]
0064CACD4  stp      x20, x19, [sp, #0x30]
0064CACD8  adrp     x20, #0x9597000
0064CACDC  adrp     x21, #0x8efa000
0064CACE0  ldrb     w8, [x20, #0xfd1]
0064CACE4  ldr      x21, [x21, #0x68]
0064CACE8  mov      x19, x0
0064CACEC  tbnz     w8, #0, #0x64cad10
0064CACF0  adrp     x0, #0x8efa000
0064CACF4  ldr      x0, [x0, #0x68]
0064CACF8  bl       #0x382bd14 ; 
0064CACFC  adrp     x0, #0x8ebf000
0064CAD00  ldr      x0, [x0, #0xe80]
0064CAD04  bl       #0x382bd14 ; 
0064CAD08  mov      w8, #1
0064CAD0C  strb     w8, [x20, #0xfd1]
0064CAD10  ldr      x1, [x21]
0064CAD14  ldrb     w8, [x1, #0x53]
0064CAD18  tbnz     w8, #5, #0x64cadac
0064CAD1C  adrp     x20, #0x8ebf000
0064CAD20  ldr      x20, [x20, #0xe80]
0064CAD24  mov      x0, x19
0064CAD28  bl       #0x64ca01c ; LocalModels.BaseLocalBean$$readShort
0064CAD2C  ldr      x8, [x20]
0064CAD30  sxth     w21, w0
0064CAD34  mov      w1, w21
0064CAD38  mov      x0, x8
0064CAD3C  bl       #0x382bdfc ; 
0064CAD40  cmp      w21, #1
0064CAD44  mov      x20, x0
0064CAD48  b.lt     #0x64cad94
0064CAD4C  mov      x22, xzr
0064CAD50  mov      w23, w21
0064CAD54  add      x21, x20, #0x20
0064CAD58  mov      x0, x19
0064CAD5C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0064CAD60  cbz      x20, #0x64cadc8
0064CAD64  ldr      w8, [x20, #0x18]
0064CAD68  cmp      x22, x8
0064CAD6C  b.hs     #0x64cadcc
0064CAD70  mov      x24, x21
0064CAD74  mov      x1, x0
0064CAD78  str      x0, [x24], #8
0064CAD7C  mov      x0, x21
0064CAD80  bl       #0x382bcb8 ; 
0064CAD84  add      x22, x22, #1
0064CAD88  cmp      x23, x22
0064CAD8C  mov      x21, x24
0064CAD90  b.ne     #0x64cad58
0064CAD94  mov      x0, x20
0064CAD98  ldp      x20, x19, [sp, #0x30]
0064CAD9C  ldp      x22, x21, [sp, #0x20]
0064CADA0  ldp      x24, x23, [sp, #0x10]
0064CADA4  ldr      x30, [sp], #0x40
0064CADA8  ret      
0064CADAC  ldr      x2, [x1, #0x60]
0064CADB0  mov      x0, x19
0064CADB4  ldp      x20, x19, [sp, #0x30]
0064CADB8  ldp      x22, x21, [sp, #0x20]
0064CADBC  ldp      x24, x23, [sp, #0x10]
0064CADC0  ldr      x30, [sp], #0x40
0064CADC4  br       x2
0064CADC8  bl       #0x382bfb8 ; 
0064CADCC  bl       #0x382bfc0 ; 

; LocalModels.BaseLocalBean$$toCommonString
; RVA 0x64CA7A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CA7A8  str      x30, [sp, #-0x30]!
0064CA7AC  stp      x22, x21, [sp, #0x10]
0064CA7B0  stp      x20, x19, [sp, #0x20]
0064CA7B4  adrp     x21, #0x9597000
0064CA7B8  adrp     x22, #0x8efa000
0064CA7BC  ldrb     w8, [x21, #0xfd2]
0064CA7C0  ldr      x22, [x22, #0x38]
0064CA7C4  mov      x19, x1
0064CA7C8  mov      x20, x0
0064CA7CC  tbnz     w8, #0, #0x64ca7e4
0064CA7D0  adrp     x0, #0x8efa000
0064CA7D4  ldr      x0, [x0, #0x38]
0064CA7D8  bl       #0x382bd14 ; 
0064CA7DC  mov      w8, #1
0064CA7E0  strb     w8, [x21, #0xfd2]
0064CA7E4  ldr      x2, [x22]
0064CA7E8  ldrb     w8, [x2, #0x53]
0064CA7EC  tbnz     w8, #5, #0x64ca804
0064CA7F0  mov      x0, x19
0064CA7F4  ldp      x20, x19, [sp, #0x20]
0064CA7F8  ldp      x22, x21, [sp, #0x10]
0064CA7FC  ldr      x30, [sp], #0x30
0064CA800  ret      
0064CA804  ldr      x3, [x2, #0x60]
0064CA808  mov      x0, x20
0064CA80C  mov      x1, x19
0064CA810  ldp      x20, x19, [sp, #0x20]
0064CA814  ldp      x22, x21, [sp, #0x10]
0064CA818  ldr      x30, [sp], #0x30
0064CA81C  br       x3

; LocalModels.BaseLocalBean$$.cctor
; RVA 0x64CADD0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CADD0  sub      sp, sp, #0x30
0064CADD4  str      x30, [sp, #0x10]
0064CADD8  stp      x20, x19, [sp, #0x20]
0064CADDC  adrp     x19, #0x9597000
0064CADE0  adrp     x20, #0x8ebf000
0064CADE4  ldrb     w8, [x19, #0xfd3]
0064CADE8  ldr      x20, [x20, #0x890]
0064CADEC  tbnz     w8, #0, #0x64cae10
0064CADF0  adrp     x0, #0x8ef9000
0064CADF4  ldr      x0, [x0, #0xff8]
0064CADF8  bl       #0x382bd14 ; 
0064CADFC  adrp     x0, #0x8ebf000
0064CAE00  ldr      x0, [x0, #0x890]
0064CAE04  bl       #0x382bd14 ; 
0064CAE08  mov      w8, #1
0064CAE0C  strb     w8, [x19, #0xfd3]
0064CAE10  adrp     x19, #0x8ef9000
0064CAE14  ldr      x19, [x19, #0xff8]
0064CAE18  add      x0, sp, #8
0064CAE1C  mov      w1, #0x7b2
0064CAE20  mov      w2, #1
0064CAE24  mov      w3, #1
0064CAE28  mov      w4, wzr
0064CAE2C  mov      w5, wzr
0064CAE30  mov      w6, wzr
0064CAE34  mov      w7, wzr
0064CAE38  str      xzr, [sp, #0x18]
0064CAE3C  stp      xzr, xzr, [sp]
0064CAE40  bl       #0x7baedbc ; System.DateTime$$.ctor
0064CAE44  ldr      x8, [sp, #8]
0064CAE48  ldr      x0, [x20]
0064CAE4C  str      x8, [sp, #0x18]
0064CAE50  ldr      w8, [x0, #0xe0]
0064CAE54  cbnz     w8, #0x64cae5c
0064CAE58  bl       #0x382be8c ; 
0064CAE5C  add      x0, sp, #0x18
0064CAE60  mov      x1, xzr
0064CAE64  bl       #0x7baed64 ; System.DateTime$$get_Ticks
0064CAE68  ldr      x8, [x19]
0064CAE6C  mov      w9, #0x2710
0064CAE70  ldr      x8, [x8, #0xb8]
0064CAE74  str      x0, [x8]
0064CAE78  mov      x0, xzr
0064CAE7C  str      w9, [x8, #8]
0064CAE80  bl       #0x7a1d0c8 ; System.Text.Encoding$$get_UTF8
0064CAE84  ldr      x8, [x19]
0064CAE88  mov      x1, x0
0064CAE8C  ldr      x8, [x8, #0xb8]
0064CAE90  str      x0, [x8, #0x10]!
0064CAE94  mov      x0, x8
0064CAE98  bl       #0x382bcb8 ; 
0064CAE9C  ldp      x20, x19, [sp, #0x20]
0064CAEA0  ldr      x30, [sp, #0x10]
0064CAEA4  add      sp, sp, #0x30
0064CAEA8  ret      

