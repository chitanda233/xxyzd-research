; LocalModels.Bean.Attribute_AttrText$$readImpl
; RVA 0x6703EF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006703EF0  stp      x30, x21, [sp, #-0x20]!
006703EF4  stp      x20, x19, [sp, #0x10]
006703EF8  adrp     x20, #0x959a000
006703EFC  adrp     x21, #0x8f17000
006703F00  ldrb     w8, [x20, #0x8e9]
006703F04  ldr      x21, [x21, #0x940]
006703F08  mov      x19, x0
006703F0C  tbnz     w8, #0, #0x6703f24
006703F10  adrp     x0, #0x8f17000
006703F14  ldr      x0, [x0, #0x940]
006703F18  bl       #0x382bd14 ; 
006703F1C  mov      w8, #1
006703F20  strb     w8, [x20, #0x8e9]
006703F24  ldr      x1, [x21]
006703F28  ldrb     w8, [x1, #0x53]
006703F2C  tbnz     w8, #5, #0x6703f88
006703F30  mov      x0, x19
006703F34  mov      x1, xzr
006703F38  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006703F3C  adrp     x21, #0x959a000
006703F40  ldrb     w8, [x21, #0x976]
006703F44  mov      x20, x0
006703F48  cbnz     w8, #0x6703f60
006703F4C  adrp     x0, #0x8f17000
006703F50  ldr      x0, [x0, #0x8e8]
006703F54  bl       #0x382bd14 ; 
006703F58  mov      w8, #1
006703F5C  strb     w8, [x21, #0x976]
006703F60  adrp     x8, #0x8f17000
006703F64  ldr      x8, [x8, #0x8e8]
006703F68  ldr      x2, [x8]
006703F6C  ldrb     w8, [x2, #0x53]
006703F70  tbnz     w8, #5, #0x6703f9c
006703F74  mov      x0, x19
006703F78  str      x20, [x0, #0x20]!
006703F7C  mov      x1, x20
006703F80  bl       #0x382bcb8 ; 
006703F84  b        #0x6703fac ; 
006703F88  ldr      x2, [x1, #0x60]
006703F8C  mov      x0, x19
006703F90  ldp      x20, x19, [sp, #0x10]
006703F94  ldp      x30, x21, [sp], #0x20
006703F98  br       x2
006703F9C  ldr      x8, [x2, #0x60]
006703FA0  mov      x0, x19
006703FA4  mov      x1, x20
006703FA8  blr      x8
006703FAC  mov      x0, x19
006703FB0  mov      x1, xzr
006703FB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006703FB8  adrp     x21, #0x959a000
006703FBC  ldrb     w8, [x21, #0x977]
006703FC0  mov      w20, w0
006703FC4  cbnz     w8, #0x6703fdc
006703FC8  adrp     x0, #0x8f17000
006703FCC  ldr      x0, [x0, #0x8f8]
006703FD0  bl       #0x382bd14 ; 
006703FD4  mov      w8, #1
006703FD8  strb     w8, [x21, #0x977]
006703FDC  adrp     x8, #0x8f17000
006703FE0  ldr      x8, [x8, #0x8f8]
006703FE4  ldr      x2, [x8]
006703FE8  ldrb     w8, [x2, #0x53]
006703FEC  tbnz     w8, #5, #0x6703ff8
006703FF0  str      w20, [x19, #0x28]
006703FF4  b        #0x6704008 ; 
006703FF8  ldr      x8, [x2, #0x60]
006703FFC  mov      x0, x19
006704000  mov      w1, w20
006704004  blr      x8
006704008  mov      x0, x19
00670400C  mov      x1, xzr
006704010  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006704014  adrp     x21, #0x959a000
006704018  ldrb     w8, [x21, #0x978]
00670401C  mov      w20, w0
006704020  cbnz     w8, #0x6704038
006704024  adrp     x0, #0x8f17000
006704028  ldr      x0, [x0, #0x908]
00670402C  bl       #0x382bd14 ; 
006704030  mov      w8, #1
006704034  strb     w8, [x21, #0x978]
006704038  adrp     x8, #0x8f17000
00670403C  ldr      x8, [x8, #0x908]
006704040  ldr      x2, [x8]
006704044  ldrb     w8, [x2, #0x53]
006704048  tbnz     w8, #5, #0x6704054
00670404C  str      w20, [x19, #0x2c]
006704050  b        #0x6704064 ; 
006704054  ldr      x8, [x2, #0x60]
006704058  mov      x0, x19
00670405C  mov      w1, w20
006704060  blr      x8
006704064  mov      x0, x19
006704068  mov      x1, xzr
00670406C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006704070  adrp     x21, #0x959a000
006704074  ldrb     w8, [x21, #0x979]
006704078  mov      w20, w0
00670407C  cbnz     w8, #0x6704094
006704080  adrp     x0, #0x8f17000
006704084  ldr      x0, [x0, #0x918]
006704088  bl       #0x382bd14 ; 
00670408C  mov      w8, #1
006704090  strb     w8, [x21, #0x979]
006704094  adrp     x8, #0x8f17000
006704098  ldr      x8, [x8, #0x918]
00670409C  ldr      x2, [x8]
0067040A0  ldrb     w8, [x2, #0x53]
0067040A4  tbnz     w8, #5, #0x67040b0
0067040A8  str      w20, [x19, #0x30]
0067040AC  b        #0x67040c0 ; 
0067040B0  ldr      x8, [x2, #0x60]
0067040B4  mov      x0, x19
0067040B8  mov      w1, w20
0067040BC  blr      x8
0067040C0  mov      x0, x19
0067040C4  mov      x1, xzr
0067040C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067040CC  adrp     x21, #0x959a000
0067040D0  ldrb     w8, [x21, #0x97a]
0067040D4  mov      w20, w0
0067040D8  cbnz     w8, #0x67040f0
0067040DC  adrp     x0, #0x8f17000
0067040E0  ldr      x0, [x0, #0x928]
0067040E4  bl       #0x382bd14 ; 
0067040E8  mov      w8, #1
0067040EC  strb     w8, [x21, #0x97a]
0067040F0  adrp     x8, #0x8f17000
0067040F4  ldr      x8, [x8, #0x928]
0067040F8  ldr      x2, [x8]
0067040FC  ldrb     w8, [x2, #0x53]
006704100  tbnz     w8, #5, #0x670410c
006704104  str      w20, [x19, #0x34]
006704108  b        #0x670411c ; 
00670410C  ldr      x8, [x2, #0x60]
006704110  mov      x0, x19
006704114  mov      w1, w20
006704118  blr      x8
00670411C  mov      x0, x19
006704120  mov      x1, xzr
006704124  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006704128  adrp     x21, #0x959a000
00670412C  ldrb     w8, [x21, #0x97b]
006704130  mov      x20, x0
006704134  cbnz     w8, #0x670414c
006704138  adrp     x0, #0x8f17000
00670413C  ldr      x0, [x0, #0x938]
006704140  bl       #0x382bd14 ; 
006704144  mov      w8, #1
006704148  strb     w8, [x21, #0x97b]
00670414C  adrp     x8, #0x8f17000
006704150  ldr      x8, [x8, #0x938]
006704154  ldr      x2, [x8]
006704158  ldrb     w8, [x2, #0x53]
00670415C  tbnz     w8, #5, #0x6704174
006704160  str      x20, [x19, #0x38]!
006704164  mov      x0, x19
006704168  mov      x1, x20
00670416C  bl       #0x382bcb8 ; 
006704170  b        #0x6704184 ; 
006704174  ldr      x8, [x2, #0x60]
006704178  mov      x0, x19
00670417C  mov      x1, x20
006704180  blr      x8
006704184  ldp      x20, x19, [sp, #0x10]
006704188  mov      w0, #1
00670418C  ldp      x30, x21, [sp], #0x20
006704190  ret      

