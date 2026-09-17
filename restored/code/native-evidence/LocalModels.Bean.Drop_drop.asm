; LocalModels.Bean.Drop_drop$$readImpl
; RVA 0x6A62048; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A62048  stp      x30, x21, [sp, #-0x20]!
006A6204C  stp      x20, x19, [sp, #0x10]
006A62050  adrp     x20, #0x959d000
006A62054  adrp     x21, #0x8f36000
006A62058  ldrb     w8, [x20, #0xc25]
006A6205C  ldr      x21, [x21, #0xb00]
006A62060  mov      x19, x0
006A62064  tbnz     w8, #0, #0x6a6207c
006A62068  adrp     x0, #0x8f36000
006A6206C  ldr      x0, [x0, #0xb00]
006A62070  bl       #0x382bd14 ; 
006A62074  mov      w8, #1
006A62078  strb     w8, [x20, #0xc25]
006A6207C  ldr      x1, [x21]
006A62080  ldrb     w8, [x1, #0x53]
006A62084  tbnz     w8, #5, #0x6a620d4
006A62088  mov      x0, x19
006A6208C  mov      x1, xzr
006A62090  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A62094  adrp     x21, #0x959e000
006A62098  ldrb     w8, [x21, #0x3a9]
006A6209C  mov      w20, w0
006A620A0  cbnz     w8, #0x6a620b8
006A620A4  adrp     x0, #0x8f36000
006A620A8  ldr      x0, [x0, #0xa68]
006A620AC  bl       #0x382bd14 ; 
006A620B0  mov      w8, #1
006A620B4  strb     w8, [x21, #0x3a9]
006A620B8  adrp     x8, #0x8f36000
006A620BC  ldr      x8, [x8, #0xa68]
006A620C0  ldr      x2, [x8]
006A620C4  ldrb     w8, [x2, #0x53]
006A620C8  tbnz     w8, #5, #0x6a620e8
006A620CC  str      w20, [x19, #0x20]
006A620D0  b        #0x6a620f8 ; 
006A620D4  ldr      x2, [x1, #0x60]
006A620D8  mov      x0, x19
006A620DC  ldp      x20, x19, [sp, #0x10]
006A620E0  ldp      x30, x21, [sp], #0x20
006A620E4  br       x2
006A620E8  ldr      x8, [x2, #0x60]
006A620EC  mov      x0, x19
006A620F0  mov      w1, w20
006A620F4  blr      x8
006A620F8  mov      x0, x19
006A620FC  mov      x1, xzr
006A62100  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A62104  adrp     x21, #0x959e000
006A62108  ldrb     w8, [x21, #0x3aa]
006A6210C  mov      w20, w0
006A62110  cbnz     w8, #0x6a62128
006A62114  adrp     x0, #0x8f36000
006A62118  ldr      x0, [x0, #0xa78]
006A6211C  bl       #0x382bd14 ; 
006A62120  mov      w8, #1
006A62124  strb     w8, [x21, #0x3aa]
006A62128  adrp     x8, #0x8f36000
006A6212C  ldr      x8, [x8, #0xa78]
006A62130  ldr      x2, [x8]
006A62134  ldrb     w8, [x2, #0x53]
006A62138  tbnz     w8, #5, #0x6a62144
006A6213C  str      w20, [x19, #0x24]
006A62140  b        #0x6a62154 ; 
006A62144  ldr      x8, [x2, #0x60]
006A62148  mov      x0, x19
006A6214C  mov      w1, w20
006A62150  blr      x8
006A62154  mov      x0, x19
006A62158  mov      x1, xzr
006A6215C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A62160  adrp     x21, #0x959e000
006A62164  ldrb     w8, [x21, #0x3ab]
006A62168  mov      x20, x0
006A6216C  cbnz     w8, #0x6a62184
006A62170  adrp     x0, #0x8f36000
006A62174  ldr      x0, [x0, #0xa88]
006A62178  bl       #0x382bd14 ; 
006A6217C  mov      w8, #1
006A62180  strb     w8, [x21, #0x3ab]
006A62184  adrp     x8, #0x8f36000
006A62188  ldr      x8, [x8, #0xa88]
006A6218C  ldr      x2, [x8]
006A62190  ldrb     w8, [x2, #0x53]
006A62194  tbnz     w8, #5, #0x6a621ac
006A62198  mov      x0, x19
006A6219C  str      x20, [x0, #0x28]!
006A621A0  mov      x1, x20
006A621A4  bl       #0x382bcb8 ; 
006A621A8  b        #0x6a621bc ; 
006A621AC  ldr      x8, [x2, #0x60]
006A621B0  mov      x0, x19
006A621B4  mov      x1, x20
006A621B8  blr      x8
006A621BC  mov      x0, x19
006A621C0  mov      x1, xzr
006A621C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A621C8  adrp     x21, #0x959e000
006A621CC  ldrb     w8, [x21, #0x3ac]
006A621D0  mov      w20, w0
006A621D4  cbnz     w8, #0x6a621ec
006A621D8  adrp     x0, #0x8f36000
006A621DC  ldr      x0, [x0, #0xa98]
006A621E0  bl       #0x382bd14 ; 
006A621E4  mov      w8, #1
006A621E8  strb     w8, [x21, #0x3ac]
006A621EC  adrp     x8, #0x8f36000
006A621F0  ldr      x8, [x8, #0xa98]
006A621F4  ldr      x2, [x8]
006A621F8  ldrb     w8, [x2, #0x53]
006A621FC  tbnz     w8, #5, #0x6a62208
006A62200  str      w20, [x19, #0x30]
006A62204  b        #0x6a62218 ; 
006A62208  ldr      x8, [x2, #0x60]
006A6220C  mov      x0, x19
006A62210  mov      w1, w20
006A62214  blr      x8
006A62218  mov      x0, x19
006A6221C  mov      x1, xzr
006A62220  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A62224  adrp     x21, #0x959e000
006A62228  ldrb     w8, [x21, #0x3ad]
006A6222C  mov      x20, x0
006A62230  cbnz     w8, #0x6a62248
006A62234  adrp     x0, #0x8f36000
006A62238  ldr      x0, [x0, #0xaa8]
006A6223C  bl       #0x382bd14 ; 
006A62240  mov      w8, #1
006A62244  strb     w8, [x21, #0x3ad]
006A62248  adrp     x8, #0x8f36000
006A6224C  ldr      x8, [x8, #0xaa8]
006A62250  ldr      x2, [x8]
006A62254  ldrb     w8, [x2, #0x53]
006A62258  tbnz     w8, #5, #0x6a62270
006A6225C  mov      x0, x19
006A62260  str      x20, [x0, #0x38]!
006A62264  mov      x1, x20
006A62268  bl       #0x382bcb8 ; 
006A6226C  b        #0x6a62280 ; 
006A62270  ldr      x8, [x2, #0x60]
006A62274  mov      x0, x19
006A62278  mov      x1, x20
006A6227C  blr      x8
006A62280  mov      x0, x19
006A62284  mov      x1, xzr
006A62288  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6228C  adrp     x21, #0x959e000
006A62290  ldrb     w8, [x21, #0x3ae]
006A62294  mov      x20, x0
006A62298  cbnz     w8, #0x6a622b0
006A6229C  adrp     x0, #0x8f36000
006A622A0  ldr      x0, [x0, #0xab8]
006A622A4  bl       #0x382bd14 ; 
006A622A8  mov      w8, #1
006A622AC  strb     w8, [x21, #0x3ae]
006A622B0  adrp     x8, #0x8f36000
006A622B4  ldr      x8, [x8, #0xab8]
006A622B8  ldr      x2, [x8]
006A622BC  ldrb     w8, [x2, #0x53]
006A622C0  tbnz     w8, #5, #0x6a622d8
006A622C4  mov      x0, x19
006A622C8  str      x20, [x0, #0x40]!
006A622CC  mov      x1, x20
006A622D0  bl       #0x382bcb8 ; 
006A622D4  b        #0x6a622e8 ; 
006A622D8  ldr      x8, [x2, #0x60]
006A622DC  mov      x0, x19
006A622E0  mov      x1, x20
006A622E4  blr      x8
006A622E8  mov      x0, x19
006A622EC  mov      x1, xzr
006A622F0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A622F4  adrp     x21, #0x959e000
006A622F8  ldrb     w8, [x21, #0x3af]
006A622FC  mov      x20, x0
006A62300  cbnz     w8, #0x6a62318
006A62304  adrp     x0, #0x8f36000
006A62308  ldr      x0, [x0, #0xac8]
006A6230C  bl       #0x382bd14 ; 
006A62310  mov      w8, #1
006A62314  strb     w8, [x21, #0x3af]
006A62318  adrp     x8, #0x8f36000
006A6231C  ldr      x8, [x8, #0xac8]
006A62320  ldr      x2, [x8]
006A62324  ldrb     w8, [x2, #0x53]
006A62328  tbnz     w8, #5, #0x6a62340
006A6232C  mov      x0, x19
006A62330  str      x20, [x0, #0x48]!
006A62334  mov      x1, x20
006A62338  bl       #0x382bcb8 ; 
006A6233C  b        #0x6a62350 ; 
006A62340  ldr      x8, [x2, #0x60]
006A62344  mov      x0, x19
006A62348  mov      x1, x20
006A6234C  blr      x8
006A62350  mov      x0, x19
006A62354  mov      x1, xzr
006A62358  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6235C  adrp     x21, #0x959e000
006A62360  ldrb     w8, [x21, #0x3b0]
006A62364  mov      x20, x0
006A62368  cbnz     w8, #0x6a62380
006A6236C  adrp     x0, #0x8f36000
006A62370  ldr      x0, [x0, #0xad8]
006A62374  bl       #0x382bd14 ; 
006A62378  mov      w8, #1
006A6237C  strb     w8, [x21, #0x3b0]
006A62380  adrp     x8, #0x8f36000
006A62384  ldr      x8, [x8, #0xad8]
006A62388  ldr      x2, [x8]
006A6238C  ldrb     w8, [x2, #0x53]
006A62390  tbnz     w8, #5, #0x6a623a8
006A62394  mov      x0, x19
006A62398  str      x20, [x0, #0x50]!
006A6239C  mov      x1, x20
006A623A0  bl       #0x382bcb8 ; 
006A623A4  b        #0x6a623b8 ; 
006A623A8  ldr      x8, [x2, #0x60]
006A623AC  mov      x0, x19
006A623B0  mov      x1, x20
006A623B4  blr      x8
006A623B8  mov      x0, x19
006A623BC  mov      x1, xzr
006A623C0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A623C4  adrp     x21, #0x959e000
006A623C8  ldrb     w8, [x21, #0x3b1]
006A623CC  mov      x20, x0
006A623D0  cbnz     w8, #0x6a623e8
006A623D4  adrp     x0, #0x8f36000
006A623D8  ldr      x0, [x0, #0xae8]
006A623DC  bl       #0x382bd14 ; 
006A623E0  mov      w8, #1
006A623E4  strb     w8, [x21, #0x3b1]
006A623E8  adrp     x8, #0x8f36000
006A623EC  ldr      x8, [x8, #0xae8]
006A623F0  ldr      x2, [x8]
006A623F4  ldrb     w8, [x2, #0x53]
006A623F8  tbnz     w8, #5, #0x6a62410
006A623FC  mov      x0, x19
006A62400  str      x20, [x0, #0x58]!
006A62404  mov      x1, x20
006A62408  bl       #0x382bcb8 ; 
006A6240C  b        #0x6a62420 ; 
006A62410  ldr      x8, [x2, #0x60]
006A62414  mov      x0, x19
006A62418  mov      x1, x20
006A6241C  blr      x8
006A62420  mov      x0, x19
006A62424  mov      x1, xzr
006A62428  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6242C  adrp     x21, #0x959e000
006A62430  ldrb     w8, [x21, #0x3b2]
006A62434  mov      x20, x0
006A62438  cbnz     w8, #0x6a62450
006A6243C  adrp     x0, #0x8f36000
006A62440  ldr      x0, [x0, #0xaf8]
006A62444  bl       #0x382bd14 ; 
006A62448  mov      w8, #1
006A6244C  strb     w8, [x21, #0x3b2]
006A62450  adrp     x8, #0x8f36000
006A62454  ldr      x8, [x8, #0xaf8]
006A62458  ldr      x2, [x8]
006A6245C  ldrb     w8, [x2, #0x53]
006A62460  tbnz     w8, #5, #0x6a62478
006A62464  str      x20, [x19, #0x60]!
006A62468  mov      x0, x19
006A6246C  mov      x1, x20
006A62470  bl       #0x382bcb8 ; 
006A62474  b        #0x6a62488 ; 
006A62478  ldr      x8, [x2, #0x60]
006A6247C  mov      x0, x19
006A62480  mov      x1, x20
006A62484  blr      x8
006A62488  ldp      x20, x19, [sp, #0x10]
006A6248C  mov      w0, #1
006A62490  ldp      x30, x21, [sp], #0x20
006A62494  ret      

