; LocalModels.Bean.ServerList_serverList$$readImpl
; RVA 0x6AE81D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE81D0  stp      x30, x21, [sp, #-0x20]!
006AE81D4  stp      x20, x19, [sp, #0x10]
006AE81D8  adrp     x20, #0x959e000
006AE81DC  adrp     x21, #0x8f3c000
006AE81E0  ldrb     w8, [x20, #0xd86]
006AE81E4  ldr      x21, [x21, #0xfb8]
006AE81E8  mov      x19, x0
006AE81EC  tbnz     w8, #0, #0x6ae8204
006AE81F0  adrp     x0, #0x8f3c000
006AE81F4  ldr      x0, [x0, #0xfb8]
006AE81F8  bl       #0x382bd14 ; 
006AE81FC  mov      w8, #1
006AE8200  strb     w8, [x20, #0xd86]
006AE8204  ldr      x1, [x21]
006AE8208  ldrb     w8, [x1, #0x53]
006AE820C  tbnz     w8, #5, #0x6ae825c
006AE8210  mov      x0, x19
006AE8214  mov      x1, xzr
006AE8218  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE821C  adrp     x21, #0x959f000
006AE8220  ldrb     w8, [x21, #0x1e3]
006AE8224  mov      w20, w0
006AE8228  cbnz     w8, #0x6ae8240
006AE822C  adrp     x0, #0x8f3c000
006AE8230  ldr      x0, [x0, #0xef0]
006AE8234  bl       #0x382bd14 ; 
006AE8238  mov      w8, #1
006AE823C  strb     w8, [x21, #0x1e3]
006AE8240  adrp     x8, #0x8f3c000
006AE8244  ldr      x8, [x8, #0xef0]
006AE8248  ldr      x2, [x8]
006AE824C  ldrb     w8, [x2, #0x53]
006AE8250  tbnz     w8, #5, #0x6ae8270
006AE8254  str      w20, [x19, #0x20]
006AE8258  b        #0x6ae8280 ; 
006AE825C  ldr      x2, [x1, #0x60]
006AE8260  mov      x0, x19
006AE8264  ldp      x20, x19, [sp, #0x10]
006AE8268  ldp      x30, x21, [sp], #0x20
006AE826C  br       x2
006AE8270  ldr      x8, [x2, #0x60]
006AE8274  mov      x0, x19
006AE8278  mov      w1, w20
006AE827C  blr      x8
006AE8280  mov      x0, x19
006AE8284  mov      x1, xzr
006AE8288  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE828C  adrp     x21, #0x959f000
006AE8290  ldrb     w8, [x21, #0x1e4]
006AE8294  mov      x20, x0
006AE8298  cbnz     w8, #0x6ae82b0
006AE829C  adrp     x0, #0x8f3c000
006AE82A0  ldr      x0, [x0, #0xf00]
006AE82A4  bl       #0x382bd14 ; 
006AE82A8  mov      w8, #1
006AE82AC  strb     w8, [x21, #0x1e4]
006AE82B0  adrp     x8, #0x8f3c000
006AE82B4  ldr      x8, [x8, #0xf00]
006AE82B8  ldr      x2, [x8]
006AE82BC  ldrb     w8, [x2, #0x53]
006AE82C0  tbnz     w8, #5, #0x6ae82d8
006AE82C4  mov      x0, x19
006AE82C8  str      x20, [x0, #0x28]!
006AE82CC  mov      x1, x20
006AE82D0  bl       #0x382bcb8 ; 
006AE82D4  b        #0x6ae82e8 ; 
006AE82D8  ldr      x8, [x2, #0x60]
006AE82DC  mov      x0, x19
006AE82E0  mov      x1, x20
006AE82E4  blr      x8
006AE82E8  mov      x0, x19
006AE82EC  mov      x1, xzr
006AE82F0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AE82F4  adrp     x21, #0x959f000
006AE82F8  ldrb     w8, [x21, #0x1e5]
006AE82FC  mov      x20, x0
006AE8300  cbnz     w8, #0x6ae8318
006AE8304  adrp     x0, #0x8f3c000
006AE8308  ldr      x0, [x0, #0xf10]
006AE830C  bl       #0x382bd14 ; 
006AE8310  mov      w8, #1
006AE8314  strb     w8, [x21, #0x1e5]
006AE8318  adrp     x8, #0x8f3c000
006AE831C  ldr      x8, [x8, #0xf10]
006AE8320  ldr      x2, [x8]
006AE8324  ldrb     w8, [x2, #0x53]
006AE8328  tbnz     w8, #5, #0x6ae8340
006AE832C  mov      x0, x19
006AE8330  str      x20, [x0, #0x30]!
006AE8334  mov      x1, x20
006AE8338  bl       #0x382bcb8 ; 
006AE833C  b        #0x6ae8350 ; 
006AE8340  ldr      x8, [x2, #0x60]
006AE8344  mov      x0, x19
006AE8348  mov      x1, x20
006AE834C  blr      x8
006AE8350  mov      x0, x19
006AE8354  mov      x1, xzr
006AE8358  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE835C  adrp     x21, #0x959f000
006AE8360  ldrb     w8, [x21, #0x1e6]
006AE8364  mov      x20, x0
006AE8368  cbnz     w8, #0x6ae8380
006AE836C  adrp     x0, #0x8f3c000
006AE8370  ldr      x0, [x0, #0xf20]
006AE8374  bl       #0x382bd14 ; 
006AE8378  mov      w8, #1
006AE837C  strb     w8, [x21, #0x1e6]
006AE8380  adrp     x8, #0x8f3c000
006AE8384  ldr      x8, [x8, #0xf20]
006AE8388  ldr      x2, [x8]
006AE838C  ldrb     w8, [x2, #0x53]
006AE8390  tbnz     w8, #5, #0x6ae83a8
006AE8394  mov      x0, x19
006AE8398  str      x20, [x0, #0x38]!
006AE839C  mov      x1, x20
006AE83A0  bl       #0x382bcb8 ; 
006AE83A4  b        #0x6ae83b8 ; 
006AE83A8  ldr      x8, [x2, #0x60]
006AE83AC  mov      x0, x19
006AE83B0  mov      x1, x20
006AE83B4  blr      x8
006AE83B8  mov      x0, x19
006AE83BC  mov      x1, xzr
006AE83C0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE83C4  adrp     x21, #0x959f000
006AE83C8  ldrb     w8, [x21, #0x1e7]
006AE83CC  mov      x20, x0
006AE83D0  cbnz     w8, #0x6ae83e8
006AE83D4  adrp     x0, #0x8f3c000
006AE83D8  ldr      x0, [x0, #0xf30]
006AE83DC  bl       #0x382bd14 ; 
006AE83E0  mov      w8, #1
006AE83E4  strb     w8, [x21, #0x1e7]
006AE83E8  adrp     x8, #0x8f3c000
006AE83EC  ldr      x8, [x8, #0xf30]
006AE83F0  ldr      x2, [x8]
006AE83F4  ldrb     w8, [x2, #0x53]
006AE83F8  tbnz     w8, #5, #0x6ae8410
006AE83FC  mov      x0, x19
006AE8400  str      x20, [x0, #0x40]!
006AE8404  mov      x1, x20
006AE8408  bl       #0x382bcb8 ; 
006AE840C  b        #0x6ae8420 ; 
006AE8410  ldr      x8, [x2, #0x60]
006AE8414  mov      x0, x19
006AE8418  mov      x1, x20
006AE841C  blr      x8
006AE8420  mov      x0, x19
006AE8424  mov      x1, xzr
006AE8428  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE842C  adrp     x21, #0x959f000
006AE8430  ldrb     w8, [x21, #0x1e8]
006AE8434  mov      w20, w0
006AE8438  cbnz     w8, #0x6ae8450
006AE843C  adrp     x0, #0x8f3c000
006AE8440  ldr      x0, [x0, #0xf40]
006AE8444  bl       #0x382bd14 ; 
006AE8448  mov      w8, #1
006AE844C  strb     w8, [x21, #0x1e8]
006AE8450  adrp     x8, #0x8f3c000
006AE8454  ldr      x8, [x8, #0xf40]
006AE8458  ldr      x2, [x8]
006AE845C  ldrb     w8, [x2, #0x53]
006AE8460  tbnz     w8, #5, #0x6ae846c
006AE8464  str      w20, [x19, #0x48]
006AE8468  b        #0x6ae847c ; 
006AE846C  ldr      x8, [x2, #0x60]
006AE8470  mov      x0, x19
006AE8474  mov      w1, w20
006AE8478  blr      x8
006AE847C  mov      x0, x19
006AE8480  mov      x1, xzr
006AE8484  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE8488  adrp     x21, #0x959f000
006AE848C  ldrb     w8, [x21, #0x1e9]
006AE8490  mov      w20, w0
006AE8494  cbnz     w8, #0x6ae84ac
006AE8498  adrp     x0, #0x8f3c000
006AE849C  ldr      x0, [x0, #0xf50]
006AE84A0  bl       #0x382bd14 ; 
006AE84A4  mov      w8, #1
006AE84A8  strb     w8, [x21, #0x1e9]
006AE84AC  adrp     x8, #0x8f3c000
006AE84B0  ldr      x8, [x8, #0xf50]
006AE84B4  ldr      x2, [x8]
006AE84B8  ldrb     w8, [x2, #0x53]
006AE84BC  tbnz     w8, #5, #0x6ae84c8
006AE84C0  str      w20, [x19, #0x4c]
006AE84C4  b        #0x6ae84d8 ; 
006AE84C8  ldr      x8, [x2, #0x60]
006AE84CC  mov      x0, x19
006AE84D0  mov      w1, w20
006AE84D4  blr      x8
006AE84D8  mov      x0, x19
006AE84DC  mov      x1, xzr
006AE84E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE84E4  adrp     x21, #0x959f000
006AE84E8  ldrb     w8, [x21, #0x1ea]
006AE84EC  mov      w20, w0
006AE84F0  cbnz     w8, #0x6ae8508
006AE84F4  adrp     x0, #0x8f3c000
006AE84F8  ldr      x0, [x0, #0xf60]
006AE84FC  bl       #0x382bd14 ; 
006AE8500  mov      w8, #1
006AE8504  strb     w8, [x21, #0x1ea]
006AE8508  adrp     x8, #0x8f3c000
006AE850C  ldr      x8, [x8, #0xf60]
006AE8510  ldr      x2, [x8]
006AE8514  ldrb     w8, [x2, #0x53]
006AE8518  tbnz     w8, #5, #0x6ae8524
006AE851C  str      w20, [x19, #0x50]
006AE8520  b        #0x6ae8534 ; 
006AE8524  ldr      x8, [x2, #0x60]
006AE8528  mov      x0, x19
006AE852C  mov      w1, w20
006AE8530  blr      x8
006AE8534  mov      x0, x19
006AE8538  mov      x1, xzr
006AE853C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AE8540  adrp     x21, #0x959f000
006AE8544  ldrb     w8, [x21, #0x1eb]
006AE8548  mov      x20, x0
006AE854C  cbnz     w8, #0x6ae8564
006AE8550  adrp     x0, #0x8f3c000
006AE8554  ldr      x0, [x0, #0xf70]
006AE8558  bl       #0x382bd14 ; 
006AE855C  mov      w8, #1
006AE8560  strb     w8, [x21, #0x1eb]
006AE8564  adrp     x8, #0x8f3c000
006AE8568  ldr      x8, [x8, #0xf70]
006AE856C  ldr      x2, [x8]
006AE8570  ldrb     w8, [x2, #0x53]
006AE8574  tbnz     w8, #5, #0x6ae858c
006AE8578  mov      x0, x19
006AE857C  str      x20, [x0, #0x58]!
006AE8580  mov      x1, x20
006AE8584  bl       #0x382bcb8 ; 
006AE8588  b        #0x6ae859c ; 
006AE858C  ldr      x8, [x2, #0x60]
006AE8590  mov      x0, x19
006AE8594  mov      x1, x20
006AE8598  blr      x8
006AE859C  mov      x0, x19
006AE85A0  mov      x1, xzr
006AE85A4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AE85A8  adrp     x21, #0x959f000
006AE85AC  ldrb     w8, [x21, #0x1ec]
006AE85B0  mov      x20, x0
006AE85B4  cbnz     w8, #0x6ae85cc
006AE85B8  adrp     x0, #0x8f3c000
006AE85BC  ldr      x0, [x0, #0xf80]
006AE85C0  bl       #0x382bd14 ; 
006AE85C4  mov      w8, #1
006AE85C8  strb     w8, [x21, #0x1ec]
006AE85CC  adrp     x8, #0x8f3c000
006AE85D0  ldr      x8, [x8, #0xf80]
006AE85D4  ldr      x2, [x8]
006AE85D8  ldrb     w8, [x2, #0x53]
006AE85DC  tbnz     w8, #5, #0x6ae85f4
006AE85E0  mov      x0, x19
006AE85E4  str      x20, [x0, #0x60]!
006AE85E8  mov      x1, x20
006AE85EC  bl       #0x382bcb8 ; 
006AE85F0  b        #0x6ae8604 ; 
006AE85F4  ldr      x8, [x2, #0x60]
006AE85F8  mov      x0, x19
006AE85FC  mov      x1, x20
006AE8600  blr      x8
006AE8604  mov      x0, x19
006AE8608  mov      x1, xzr
006AE860C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE8610  adrp     x21, #0x959f000
006AE8614  ldrb     w8, [x21, #0x1ed]
006AE8618  mov      w20, w0
006AE861C  cbnz     w8, #0x6ae8634
006AE8620  adrp     x0, #0x8f3c000
006AE8624  ldr      x0, [x0, #0xf90]
006AE8628  bl       #0x382bd14 ; 
006AE862C  mov      w8, #1
006AE8630  strb     w8, [x21, #0x1ed]
006AE8634  adrp     x8, #0x8f3c000
006AE8638  ldr      x8, [x8, #0xf90]
006AE863C  ldr      x2, [x8]
006AE8640  ldrb     w8, [x2, #0x53]
006AE8644  tbnz     w8, #5, #0x6ae8650
006AE8648  str      w20, [x19, #0x68]
006AE864C  b        #0x6ae8660 ; 
006AE8650  ldr      x8, [x2, #0x60]
006AE8654  mov      x0, x19
006AE8658  mov      w1, w20
006AE865C  blr      x8
006AE8660  mov      x0, x19
006AE8664  mov      x1, xzr
006AE8668  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE866C  adrp     x21, #0x959f000
006AE8670  ldrb     w8, [x21, #0x1ee]
006AE8674  mov      w20, w0
006AE8678  cbnz     w8, #0x6ae8690
006AE867C  adrp     x0, #0x8f3c000
006AE8680  ldr      x0, [x0, #0xfa0]
006AE8684  bl       #0x382bd14 ; 
006AE8688  mov      w8, #1
006AE868C  strb     w8, [x21, #0x1ee]
006AE8690  adrp     x8, #0x8f3c000
006AE8694  ldr      x8, [x8, #0xfa0]
006AE8698  ldr      x2, [x8]
006AE869C  ldrb     w8, [x2, #0x53]
006AE86A0  tbnz     w8, #5, #0x6ae86ac
006AE86A4  str      w20, [x19, #0x6c]
006AE86A8  b        #0x6ae86bc ; 
006AE86AC  ldr      x8, [x2, #0x60]
006AE86B0  mov      x0, x19
006AE86B4  mov      w1, w20
006AE86B8  blr      x8
006AE86BC  mov      x0, x19
006AE86C0  mov      x1, xzr
006AE86C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE86C8  adrp     x21, #0x959f000
006AE86CC  ldrb     w8, [x21, #0x1ef]
006AE86D0  mov      w20, w0
006AE86D4  cbnz     w8, #0x6ae86ec
006AE86D8  adrp     x0, #0x8f3c000
006AE86DC  ldr      x0, [x0, #0xfb0]
006AE86E0  bl       #0x382bd14 ; 
006AE86E4  mov      w8, #1
006AE86E8  strb     w8, [x21, #0x1ef]
006AE86EC  adrp     x8, #0x8f3c000
006AE86F0  ldr      x8, [x8, #0xfb0]
006AE86F4  ldr      x2, [x8]
006AE86F8  ldrb     w8, [x2, #0x53]
006AE86FC  tbnz     w8, #5, #0x6ae8708
006AE8700  str      w20, [x19, #0x70]
006AE8704  b        #0x6ae8718 ; 
006AE8708  ldr      x8, [x2, #0x60]
006AE870C  mov      x0, x19
006AE8710  mov      w1, w20
006AE8714  blr      x8
006AE8718  ldp      x20, x19, [sp, #0x10]
006AE871C  mov      w0, #1
006AE8720  ldp      x30, x21, [sp], #0x20
006AE8724  ret      

