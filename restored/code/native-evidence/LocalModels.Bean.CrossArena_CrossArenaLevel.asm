; LocalModels.Bean.CrossArena_CrossArenaLevel$$readImpl
; RVA 0x6A54130; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A54130  stp      x30, x21, [sp, #-0x20]!
006A54134  stp      x20, x19, [sp, #0x10]
006A54138  adrp     x20, #0x959d000
006A5413C  adrp     x21, #0x8f36000
006A54140  ldrb     w8, [x20, #0xab4]
006A54144  ldr      x21, [x21, #0xa8]
006A54148  mov      x19, x0
006A5414C  tbnz     w8, #0, #0x6a54164
006A54150  adrp     x0, #0x8f36000
006A54154  ldr      x0, [x0, #0xa8]
006A54158  bl       #0x382bd14 ; 
006A5415C  mov      w8, #1
006A54160  strb     w8, [x20, #0xab4]
006A54164  ldr      x1, [x21]
006A54168  ldrb     w8, [x1, #0x53]
006A5416C  tbnz     w8, #5, #0x6a541bc
006A54170  mov      x0, x19
006A54174  mov      x1, xzr
006A54178  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5417C  adrp     x21, #0x959e000
006A54180  ldrb     w8, [x21, #0x310]
006A54184  mov      w20, w0
006A54188  cbnz     w8, #0x6a541a0
006A5418C  adrp     x0, #0x8f36000
006A54190  ldr      x0, [x0, #0x10]
006A54194  bl       #0x382bd14 ; 
006A54198  mov      w8, #1
006A5419C  strb     w8, [x21, #0x310]
006A541A0  adrp     x8, #0x8f36000
006A541A4  ldr      x8, [x8, #0x10]
006A541A8  ldr      x2, [x8]
006A541AC  ldrb     w8, [x2, #0x53]
006A541B0  tbnz     w8, #5, #0x6a541d0
006A541B4  str      w20, [x19, #0x20]
006A541B8  b        #0x6a541e0 ; 
006A541BC  ldr      x2, [x1, #0x60]
006A541C0  mov      x0, x19
006A541C4  ldp      x20, x19, [sp, #0x10]
006A541C8  ldp      x30, x21, [sp], #0x20
006A541CC  br       x2
006A541D0  ldr      x8, [x2, #0x60]
006A541D4  mov      x0, x19
006A541D8  mov      w1, w20
006A541DC  blr      x8
006A541E0  mov      x0, x19
006A541E4  mov      x1, xzr
006A541E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A541EC  adrp     x21, #0x959e000
006A541F0  ldrb     w8, [x21, #0x311]
006A541F4  mov      w20, w0
006A541F8  cbnz     w8, #0x6a54210
006A541FC  adrp     x0, #0x8f36000
006A54200  ldr      x0, [x0, #0x20]
006A54204  bl       #0x382bd14 ; 
006A54208  mov      w8, #1
006A5420C  strb     w8, [x21, #0x311]
006A54210  adrp     x8, #0x8f36000
006A54214  ldr      x8, [x8, #0x20]
006A54218  ldr      x2, [x8]
006A5421C  ldrb     w8, [x2, #0x53]
006A54220  tbnz     w8, #5, #0x6a5422c
006A54224  str      w20, [x19, #0x24]
006A54228  b        #0x6a5423c ; 
006A5422C  ldr      x8, [x2, #0x60]
006A54230  mov      x0, x19
006A54234  mov      w1, w20
006A54238  blr      x8
006A5423C  mov      x0, x19
006A54240  mov      x1, xzr
006A54244  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A54248  adrp     x21, #0x959e000
006A5424C  ldrb     w8, [x21, #0x312]
006A54250  mov      x20, x0
006A54254  cbnz     w8, #0x6a5426c
006A54258  adrp     x0, #0x8f36000
006A5425C  ldr      x0, [x0, #0x30]
006A54260  bl       #0x382bd14 ; 
006A54264  mov      w8, #1
006A54268  strb     w8, [x21, #0x312]
006A5426C  adrp     x8, #0x8f36000
006A54270  ldr      x8, [x8, #0x30]
006A54274  ldr      x2, [x8]
006A54278  ldrb     w8, [x2, #0x53]
006A5427C  tbnz     w8, #5, #0x6a54294
006A54280  mov      x0, x19
006A54284  str      x20, [x0, #0x28]!
006A54288  mov      x1, x20
006A5428C  bl       #0x382bcb8 ; 
006A54290  b        #0x6a542a4 ; 
006A54294  ldr      x8, [x2, #0x60]
006A54298  mov      x0, x19
006A5429C  mov      x1, x20
006A542A0  blr      x8
006A542A4  mov      x0, x19
006A542A8  mov      x1, xzr
006A542AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A542B0  adrp     x21, #0x959e000
006A542B4  ldrb     w8, [x21, #0x313]
006A542B8  mov      w20, w0
006A542BC  cbnz     w8, #0x6a542d4
006A542C0  adrp     x0, #0x8f36000
006A542C4  ldr      x0, [x0, #0x40]
006A542C8  bl       #0x382bd14 ; 
006A542CC  mov      w8, #1
006A542D0  strb     w8, [x21, #0x313]
006A542D4  adrp     x8, #0x8f36000
006A542D8  ldr      x8, [x8, #0x40]
006A542DC  ldr      x2, [x8]
006A542E0  ldrb     w8, [x2, #0x53]
006A542E4  tbnz     w8, #5, #0x6a542f0
006A542E8  str      w20, [x19, #0x30]
006A542EC  b        #0x6a54300 ; 
006A542F0  ldr      x8, [x2, #0x60]
006A542F4  mov      x0, x19
006A542F8  mov      w1, w20
006A542FC  blr      x8
006A54300  mov      x0, x19
006A54304  mov      x1, xzr
006A54308  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5430C  adrp     x21, #0x959e000
006A54310  ldrb     w8, [x21, #0x314]
006A54314  mov      w20, w0
006A54318  cbnz     w8, #0x6a54330
006A5431C  adrp     x0, #0x8f36000
006A54320  ldr      x0, [x0, #0x50]
006A54324  bl       #0x382bd14 ; 
006A54328  mov      w8, #1
006A5432C  strb     w8, [x21, #0x314]
006A54330  adrp     x8, #0x8f36000
006A54334  ldr      x8, [x8, #0x50]
006A54338  ldr      x2, [x8]
006A5433C  ldrb     w8, [x2, #0x53]
006A54340  tbnz     w8, #5, #0x6a5434c
006A54344  str      w20, [x19, #0x34]
006A54348  b        #0x6a5435c ; 
006A5434C  ldr      x8, [x2, #0x60]
006A54350  mov      x0, x19
006A54354  mov      w1, w20
006A54358  blr      x8
006A5435C  mov      x0, x19
006A54360  mov      x1, xzr
006A54364  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A54368  adrp     x21, #0x959e000
006A5436C  ldrb     w8, [x21, #0x315]
006A54370  mov      w20, w0
006A54374  cbnz     w8, #0x6a5438c
006A54378  adrp     x0, #0x8f36000
006A5437C  ldr      x0, [x0, #0x60]
006A54380  bl       #0x382bd14 ; 
006A54384  mov      w8, #1
006A54388  strb     w8, [x21, #0x315]
006A5438C  adrp     x8, #0x8f36000
006A54390  ldr      x8, [x8, #0x60]
006A54394  ldr      x2, [x8]
006A54398  ldrb     w8, [x2, #0x53]
006A5439C  tbnz     w8, #5, #0x6a543a8
006A543A0  str      w20, [x19, #0x38]
006A543A4  b        #0x6a543b8 ; 
006A543A8  ldr      x8, [x2, #0x60]
006A543AC  mov      x0, x19
006A543B0  mov      w1, w20
006A543B4  blr      x8
006A543B8  mov      x0, x19
006A543BC  mov      x1, xzr
006A543C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A543C4  adrp     x21, #0x959e000
006A543C8  ldrb     w8, [x21, #0x316]
006A543CC  mov      w20, w0
006A543D0  cbnz     w8, #0x6a543e8
006A543D4  adrp     x0, #0x8f36000
006A543D8  ldr      x0, [x0, #0x70]
006A543DC  bl       #0x382bd14 ; 
006A543E0  mov      w8, #1
006A543E4  strb     w8, [x21, #0x316]
006A543E8  adrp     x8, #0x8f36000
006A543EC  ldr      x8, [x8, #0x70]
006A543F0  ldr      x2, [x8]
006A543F4  ldrb     w8, [x2, #0x53]
006A543F8  tbnz     w8, #5, #0x6a54404
006A543FC  str      w20, [x19, #0x3c]
006A54400  b        #0x6a54414 ; 
006A54404  ldr      x8, [x2, #0x60]
006A54408  mov      x0, x19
006A5440C  mov      w1, w20
006A54410  blr      x8
006A54414  mov      x0, x19
006A54418  mov      x1, xzr
006A5441C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A54420  adrp     x21, #0x959e000
006A54424  ldrb     w8, [x21, #0x317]
006A54428  mov      w20, w0
006A5442C  cbnz     w8, #0x6a54444
006A54430  adrp     x0, #0x8f36000
006A54434  ldr      x0, [x0, #0x80]
006A54438  bl       #0x382bd14 ; 
006A5443C  mov      w8, #1
006A54440  strb     w8, [x21, #0x317]
006A54444  adrp     x8, #0x8f36000
006A54448  ldr      x8, [x8, #0x80]
006A5444C  ldr      x2, [x8]
006A54450  ldrb     w8, [x2, #0x53]
006A54454  tbnz     w8, #5, #0x6a54460
006A54458  str      w20, [x19, #0x40]
006A5445C  b        #0x6a54470 ; 
006A54460  ldr      x8, [x2, #0x60]
006A54464  mov      x0, x19
006A54468  mov      w1, w20
006A5446C  blr      x8
006A54470  mov      x0, x19
006A54474  mov      x1, xzr
006A54478  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5447C  adrp     x21, #0x959e000
006A54480  ldrb     w8, [x21, #0x318]
006A54484  mov      x20, x0
006A54488  cbnz     w8, #0x6a544a0
006A5448C  adrp     x0, #0x8f36000
006A54490  ldr      x0, [x0, #0x90]
006A54494  bl       #0x382bd14 ; 
006A54498  mov      w8, #1
006A5449C  strb     w8, [x21, #0x318]
006A544A0  adrp     x8, #0x8f36000
006A544A4  ldr      x8, [x8, #0x90]
006A544A8  ldr      x2, [x8]
006A544AC  ldrb     w8, [x2, #0x53]
006A544B0  tbnz     w8, #5, #0x6a544c8
006A544B4  mov      x0, x19
006A544B8  str      x20, [x0, #0x48]!
006A544BC  mov      x1, x20
006A544C0  bl       #0x382bcb8 ; 
006A544C4  b        #0x6a544d8 ; 
006A544C8  ldr      x8, [x2, #0x60]
006A544CC  mov      x0, x19
006A544D0  mov      x1, x20
006A544D4  blr      x8
006A544D8  mov      x0, x19
006A544DC  mov      x1, xzr
006A544E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A544E4  adrp     x21, #0x959e000
006A544E8  ldrb     w8, [x21, #0x319]
006A544EC  mov      w20, w0
006A544F0  cbnz     w8, #0x6a54508
006A544F4  adrp     x0, #0x8f36000
006A544F8  ldr      x0, [x0, #0xa0]
006A544FC  bl       #0x382bd14 ; 
006A54500  mov      w8, #1
006A54504  strb     w8, [x21, #0x319]
006A54508  adrp     x8, #0x8f36000
006A5450C  ldr      x8, [x8, #0xa0]
006A54510  ldr      x2, [x8]
006A54514  ldrb     w8, [x2, #0x53]
006A54518  tbnz     w8, #5, #0x6a54524
006A5451C  str      w20, [x19, #0x50]
006A54520  b        #0x6a54534 ; 
006A54524  ldr      x8, [x2, #0x60]
006A54528  mov      x0, x19
006A5452C  mov      w1, w20
006A54530  blr      x8
006A54534  ldp      x20, x19, [sp, #0x10]
006A54538  mov      w0, #1
006A5453C  ldp      x30, x21, [sp], #0x20
006A54540  ret      

