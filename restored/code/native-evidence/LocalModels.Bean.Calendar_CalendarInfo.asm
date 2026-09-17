; LocalModels.Bean.Calendar_CalendarInfo$$readImpl
; RVA 0x6891F24; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006891F24  stp      x30, x21, [sp, #-0x20]!
006891F28  stp      x20, x19, [sp, #0x10]
006891F2C  adrp     x20, #0x959b000
006891F30  adrp     x21, #0x8f25000
006891F34  ldrb     w8, [x20, #0xd51]
006891F38  ldr      x21, [x21, #0x860]
006891F3C  mov      x19, x0
006891F40  tbnz     w8, #0, #0x6891f58
006891F44  adrp     x0, #0x8f25000
006891F48  ldr      x0, [x0, #0x860]
006891F4C  bl       #0x382bd14 ; 
006891F50  mov      w8, #1
006891F54  strb     w8, [x20, #0xd51]
006891F58  ldr      x1, [x21]
006891F5C  ldrb     w8, [x1, #0x53]
006891F60  tbnz     w8, #5, #0x6891fb0
006891F64  mov      x0, x19
006891F68  mov      x1, xzr
006891F6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006891F70  adrp     x21, #0x959c000
006891F74  ldrb     w8, [x21, #0x46c]
006891F78  mov      w20, w0
006891F7C  cbnz     w8, #0x6891f94
006891F80  adrp     x0, #0x8f25000
006891F84  ldr      x0, [x0, #0x778]
006891F88  bl       #0x382bd14 ; 
006891F8C  mov      w8, #1
006891F90  strb     w8, [x21, #0x46c]
006891F94  adrp     x8, #0x8f25000
006891F98  ldr      x8, [x8, #0x778]
006891F9C  ldr      x2, [x8]
006891FA0  ldrb     w8, [x2, #0x53]
006891FA4  tbnz     w8, #5, #0x6891fc4
006891FA8  str      w20, [x19, #0x20]
006891FAC  b        #0x6891fd4 ; 
006891FB0  ldr      x2, [x1, #0x60]
006891FB4  mov      x0, x19
006891FB8  ldp      x20, x19, [sp, #0x10]
006891FBC  ldp      x30, x21, [sp], #0x20
006891FC0  br       x2
006891FC4  ldr      x8, [x2, #0x60]
006891FC8  mov      x0, x19
006891FCC  mov      w1, w20
006891FD0  blr      x8
006891FD4  mov      x0, x19
006891FD8  mov      x1, xzr
006891FDC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006891FE0  adrp     x21, #0x959c000
006891FE4  ldrb     w8, [x21, #0x46d]
006891FE8  mov      x20, x0
006891FEC  cbnz     w8, #0x6892004
006891FF0  adrp     x0, #0x8f25000
006891FF4  ldr      x0, [x0, #0x788]
006891FF8  bl       #0x382bd14 ; 
006891FFC  mov      w8, #1
006892000  strb     w8, [x21, #0x46d]
006892004  adrp     x8, #0x8f25000
006892008  ldr      x8, [x8, #0x788]
00689200C  ldr      x2, [x8]
006892010  ldrb     w8, [x2, #0x53]
006892014  tbnz     w8, #5, #0x689202c
006892018  mov      x0, x19
00689201C  str      x20, [x0, #0x28]!
006892020  mov      x1, x20
006892024  bl       #0x382bcb8 ; 
006892028  b        #0x689203c ; 
00689202C  ldr      x8, [x2, #0x60]
006892030  mov      x0, x19
006892034  mov      x1, x20
006892038  blr      x8
00689203C  mov      x0, x19
006892040  mov      x1, xzr
006892044  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006892048  adrp     x21, #0x959c000
00689204C  ldrb     w8, [x21, #0x46e]
006892050  mov      w20, w0
006892054  cbnz     w8, #0x689206c
006892058  adrp     x0, #0x8f25000
00689205C  ldr      x0, [x0, #0x798]
006892060  bl       #0x382bd14 ; 
006892064  mov      w8, #1
006892068  strb     w8, [x21, #0x46e]
00689206C  adrp     x8, #0x8f25000
006892070  ldr      x8, [x8, #0x798]
006892074  ldr      x2, [x8]
006892078  ldrb     w8, [x2, #0x53]
00689207C  tbnz     w8, #5, #0x6892088
006892080  str      w20, [x19, #0x30]
006892084  b        #0x6892098 ; 
006892088  ldr      x8, [x2, #0x60]
00689208C  mov      x0, x19
006892090  mov      w1, w20
006892094  blr      x8
006892098  mov      x0, x19
00689209C  mov      x1, xzr
0068920A0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068920A4  adrp     x21, #0x959c000
0068920A8  ldrb     w8, [x21, #0x46f]
0068920AC  mov      x20, x0
0068920B0  cbnz     w8, #0x68920c8
0068920B4  adrp     x0, #0x8f25000
0068920B8  ldr      x0, [x0, #0x7a8]
0068920BC  bl       #0x382bd14 ; 
0068920C0  mov      w8, #1
0068920C4  strb     w8, [x21, #0x46f]
0068920C8  adrp     x8, #0x8f25000
0068920CC  ldr      x8, [x8, #0x7a8]
0068920D0  ldr      x2, [x8]
0068920D4  ldrb     w8, [x2, #0x53]
0068920D8  tbnz     w8, #5, #0x68920f0
0068920DC  mov      x0, x19
0068920E0  str      x20, [x0, #0x38]!
0068920E4  mov      x1, x20
0068920E8  bl       #0x382bcb8 ; 
0068920EC  b        #0x6892100 ; 
0068920F0  ldr      x8, [x2, #0x60]
0068920F4  mov      x0, x19
0068920F8  mov      x1, x20
0068920FC  blr      x8
006892100  mov      x0, x19
006892104  mov      x1, xzr
006892108  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689210C  adrp     x21, #0x959c000
006892110  ldrb     w8, [x21, #0x470]
006892114  mov      w20, w0
006892118  cbnz     w8, #0x6892130
00689211C  adrp     x0, #0x8f25000
006892120  ldr      x0, [x0, #0x7b8]
006892124  bl       #0x382bd14 ; 
006892128  mov      w8, #1
00689212C  strb     w8, [x21, #0x470]
006892130  adrp     x8, #0x8f25000
006892134  ldr      x8, [x8, #0x7b8]
006892138  ldr      x2, [x8]
00689213C  ldrb     w8, [x2, #0x53]
006892140  tbnz     w8, #5, #0x689214c
006892144  str      w20, [x19, #0x40]
006892148  b        #0x689215c ; 
00689214C  ldr      x8, [x2, #0x60]
006892150  mov      x0, x19
006892154  mov      w1, w20
006892158  blr      x8
00689215C  mov      x0, x19
006892160  mov      x1, xzr
006892164  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006892168  adrp     x21, #0x959c000
00689216C  ldrb     w8, [x21, #0x471]
006892170  mov      w20, w0
006892174  cbnz     w8, #0x689218c
006892178  adrp     x0, #0x8f25000
00689217C  ldr      x0, [x0, #0x7c8]
006892180  bl       #0x382bd14 ; 
006892184  mov      w8, #1
006892188  strb     w8, [x21, #0x471]
00689218C  adrp     x8, #0x8f25000
006892190  ldr      x8, [x8, #0x7c8]
006892194  ldr      x2, [x8]
006892198  ldrb     w8, [x2, #0x53]
00689219C  tbnz     w8, #5, #0x68921a8
0068921A0  str      w20, [x19, #0x44]
0068921A4  b        #0x68921b8 ; 
0068921A8  ldr      x8, [x2, #0x60]
0068921AC  mov      x0, x19
0068921B0  mov      w1, w20
0068921B4  blr      x8
0068921B8  mov      x0, x19
0068921BC  mov      x1, xzr
0068921C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068921C4  adrp     x21, #0x959c000
0068921C8  ldrb     w8, [x21, #0x472]
0068921CC  mov      w20, w0
0068921D0  cbnz     w8, #0x68921e8
0068921D4  adrp     x0, #0x8f25000
0068921D8  ldr      x0, [x0, #0x7d8]
0068921DC  bl       #0x382bd14 ; 
0068921E0  mov      w8, #1
0068921E4  strb     w8, [x21, #0x472]
0068921E8  adrp     x8, #0x8f25000
0068921EC  ldr      x8, [x8, #0x7d8]
0068921F0  ldr      x2, [x8]
0068921F4  ldrb     w8, [x2, #0x53]
0068921F8  tbnz     w8, #5, #0x6892204
0068921FC  str      w20, [x19, #0x48]
006892200  b        #0x6892214 ; 
006892204  ldr      x8, [x2, #0x60]
006892208  mov      x0, x19
00689220C  mov      w1, w20
006892210  blr      x8
006892214  mov      x0, x19
006892218  mov      x1, xzr
00689221C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006892220  adrp     x21, #0x959c000
006892224  ldrb     w8, [x21, #0x473]
006892228  mov      w20, w0
00689222C  cbnz     w8, #0x6892244
006892230  adrp     x0, #0x8f25000
006892234  ldr      x0, [x0, #0x7e8]
006892238  bl       #0x382bd14 ; 
00689223C  mov      w8, #1
006892240  strb     w8, [x21, #0x473]
006892244  adrp     x8, #0x8f25000
006892248  ldr      x8, [x8, #0x7e8]
00689224C  ldr      x2, [x8]
006892250  ldrb     w8, [x2, #0x53]
006892254  tbnz     w8, #5, #0x6892260
006892258  str      w20, [x19, #0x4c]
00689225C  b        #0x6892270 ; 
006892260  ldr      x8, [x2, #0x60]
006892264  mov      x0, x19
006892268  mov      w1, w20
00689226C  blr      x8
006892270  mov      x0, x19
006892274  mov      x1, xzr
006892278  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689227C  adrp     x21, #0x959c000
006892280  ldrb     w8, [x21, #0x474]
006892284  mov      x20, x0
006892288  cbnz     w8, #0x68922a0
00689228C  adrp     x0, #0x8f25000
006892290  ldr      x0, [x0, #0x7f8]
006892294  bl       #0x382bd14 ; 
006892298  mov      w8, #1
00689229C  strb     w8, [x21, #0x474]
0068922A0  adrp     x8, #0x8f25000
0068922A4  ldr      x8, [x8, #0x7f8]
0068922A8  ldr      x2, [x8]
0068922AC  ldrb     w8, [x2, #0x53]
0068922B0  tbnz     w8, #5, #0x68922c8
0068922B4  mov      x0, x19
0068922B8  str      x20, [x0, #0x50]!
0068922BC  mov      x1, x20
0068922C0  bl       #0x382bcb8 ; 
0068922C4  b        #0x68922d8 ; 
0068922C8  ldr      x8, [x2, #0x60]
0068922CC  mov      x0, x19
0068922D0  mov      x1, x20
0068922D4  blr      x8
0068922D8  mov      x0, x19
0068922DC  mov      x1, xzr
0068922E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068922E4  adrp     x21, #0x959c000
0068922E8  ldrb     w8, [x21, #0x475]
0068922EC  mov      w20, w0
0068922F0  cbnz     w8, #0x6892308
0068922F4  adrp     x0, #0x8f25000
0068922F8  ldr      x0, [x0, #0x808]
0068922FC  bl       #0x382bd14 ; 
006892300  mov      w8, #1
006892304  strb     w8, [x21, #0x475]
006892308  adrp     x8, #0x8f25000
00689230C  ldr      x8, [x8, #0x808]
006892310  ldr      x2, [x8]
006892314  ldrb     w8, [x2, #0x53]
006892318  tbnz     w8, #5, #0x6892324
00689231C  str      w20, [x19, #0x58]
006892320  b        #0x6892334 ; 
006892324  ldr      x8, [x2, #0x60]
006892328  mov      x0, x19
00689232C  mov      w1, w20
006892330  blr      x8
006892334  mov      x0, x19
006892338  mov      x1, xzr
00689233C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006892340  adrp     x21, #0x959c000
006892344  ldrb     w8, [x21, #0x476]
006892348  mov      x20, x0
00689234C  cbnz     w8, #0x6892364
006892350  adrp     x0, #0x8f25000
006892354  ldr      x0, [x0, #0x818]
006892358  bl       #0x382bd14 ; 
00689235C  mov      w8, #1
006892360  strb     w8, [x21, #0x476]
006892364  adrp     x8, #0x8f25000
006892368  ldr      x8, [x8, #0x818]
00689236C  ldr      x2, [x8]
006892370  ldrb     w8, [x2, #0x53]
006892374  tbnz     w8, #5, #0x689238c
006892378  mov      x0, x19
00689237C  str      x20, [x0, #0x60]!
006892380  mov      x1, x20
006892384  bl       #0x382bcb8 ; 
006892388  b        #0x689239c ; 
00689238C  ldr      x8, [x2, #0x60]
006892390  mov      x0, x19
006892394  mov      x1, x20
006892398  blr      x8
00689239C  mov      x0, x19
0068923A0  mov      x1, xzr
0068923A4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068923A8  adrp     x21, #0x959c000
0068923AC  ldrb     w8, [x21, #0x477]
0068923B0  mov      x20, x0
0068923B4  cbnz     w8, #0x68923cc
0068923B8  adrp     x0, #0x8f25000
0068923BC  ldr      x0, [x0, #0x828]
0068923C0  bl       #0x382bd14 ; 
0068923C4  mov      w8, #1
0068923C8  strb     w8, [x21, #0x477]
0068923CC  adrp     x8, #0x8f25000
0068923D0  ldr      x8, [x8, #0x828]
0068923D4  ldr      x2, [x8]
0068923D8  ldrb     w8, [x2, #0x53]
0068923DC  tbnz     w8, #5, #0x68923f4
0068923E0  mov      x0, x19
0068923E4  str      x20, [x0, #0x68]!
0068923E8  mov      x1, x20
0068923EC  bl       #0x382bcb8 ; 
0068923F0  b        #0x6892404 ; 
0068923F4  ldr      x8, [x2, #0x60]
0068923F8  mov      x0, x19
0068923FC  mov      x1, x20
006892400  blr      x8
006892404  mov      x0, x19
006892408  mov      x1, xzr
00689240C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006892410  adrp     x21, #0x959c000
006892414  ldrb     w8, [x21, #0x478]
006892418  mov      x20, x0
00689241C  cbnz     w8, #0x6892434
006892420  adrp     x0, #0x8f25000
006892424  ldr      x0, [x0, #0x838]
006892428  bl       #0x382bd14 ; 
00689242C  mov      w8, #1
006892430  strb     w8, [x21, #0x478]
006892434  adrp     x8, #0x8f25000
006892438  ldr      x8, [x8, #0x838]
00689243C  ldr      x2, [x8]
006892440  ldrb     w8, [x2, #0x53]
006892444  tbnz     w8, #5, #0x689245c
006892448  mov      x0, x19
00689244C  str      x20, [x0, #0x70]!
006892450  mov      x1, x20
006892454  bl       #0x382bcb8 ; 
006892458  b        #0x689246c ; 
00689245C  ldr      x8, [x2, #0x60]
006892460  mov      x0, x19
006892464  mov      x1, x20
006892468  blr      x8
00689246C  mov      x0, x19
006892470  mov      x1, xzr
006892474  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006892478  adrp     x21, #0x959c000
00689247C  ldrb     w8, [x21, #0x479]
006892480  mov      x20, x0
006892484  cbnz     w8, #0x689249c
006892488  adrp     x0, #0x8f25000
00689248C  ldr      x0, [x0, #0x848]
006892490  bl       #0x382bd14 ; 
006892494  mov      w8, #1
006892498  strb     w8, [x21, #0x479]
00689249C  adrp     x8, #0x8f25000
0068924A0  ldr      x8, [x8, #0x848]
0068924A4  ldr      x2, [x8]
0068924A8  ldrb     w8, [x2, #0x53]
0068924AC  tbnz     w8, #5, #0x68924c4
0068924B0  mov      x0, x19
0068924B4  str      x20, [x0, #0x78]!
0068924B8  mov      x1, x20
0068924BC  bl       #0x382bcb8 ; 
0068924C0  b        #0x68924d4 ; 
0068924C4  ldr      x8, [x2, #0x60]
0068924C8  mov      x0, x19
0068924CC  mov      x1, x20
0068924D0  blr      x8
0068924D4  mov      x0, x19
0068924D8  mov      x1, xzr
0068924DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068924E0  adrp     x21, #0x959c000
0068924E4  ldrb     w8, [x21, #0x47a]
0068924E8  mov      w20, w0
0068924EC  cbnz     w8, #0x6892504
0068924F0  adrp     x0, #0x8f25000
0068924F4  ldr      x0, [x0, #0x858]
0068924F8  bl       #0x382bd14 ; 
0068924FC  mov      w8, #1
006892500  strb     w8, [x21, #0x47a]
006892504  adrp     x8, #0x8f25000
006892508  ldr      x8, [x8, #0x858]
00689250C  ldr      x2, [x8]
006892510  ldrb     w8, [x2, #0x53]
006892514  tbnz     w8, #5, #0x6892520
006892518  str      w20, [x19, #0x80]
00689251C  b        #0x6892530 ; 
006892520  ldr      x8, [x2, #0x60]
006892524  mov      x0, x19
006892528  mov      w1, w20
00689252C  blr      x8
006892530  ldp      x20, x19, [sp, #0x10]
006892534  mov      w0, #1
006892538  ldp      x30, x21, [sp], #0x20
00689253C  ret      

