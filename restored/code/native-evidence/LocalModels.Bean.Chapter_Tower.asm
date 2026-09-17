; LocalModels.Bean.Chapter_Tower$$readImpl
; RVA 0x68B9110; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B9110  stp      x30, x21, [sp, #-0x20]!
0068B9114  stp      x20, x19, [sp, #0x10]
0068B9118  adrp     x20, #0x959c000
0068B911C  adrp     x21, #0x8f27000
0068B9120  ldrb     w8, [x20, #0x15c]
0068B9124  ldr      x21, [x21, #0x688]
0068B9128  mov      x19, x0
0068B912C  tbnz     w8, #0, #0x68b9144
0068B9130  adrp     x0, #0x8f27000
0068B9134  ldr      x0, [x0, #0x688]
0068B9138  bl       #0x382bd14 ; 
0068B913C  mov      w8, #1
0068B9140  strb     w8, [x20, #0x15c]
0068B9144  ldr      x1, [x21]
0068B9148  ldrb     w8, [x1, #0x53]
0068B914C  tbnz     w8, #5, #0x68b919c
0068B9150  mov      x0, x19
0068B9154  mov      x1, xzr
0068B9158  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B915C  adrp     x21, #0x959c000
0068B9160  ldrb     w8, [x21, #0x632]
0068B9164  mov      w20, w0
0068B9168  cbnz     w8, #0x68b9180
0068B916C  adrp     x0, #0x8f27000
0068B9170  ldr      x0, [x0, #0x448]
0068B9174  bl       #0x382bd14 ; 
0068B9178  mov      w8, #1
0068B917C  strb     w8, [x21, #0x632]
0068B9180  adrp     x8, #0x8f27000
0068B9184  ldr      x8, [x8, #0x448]
0068B9188  ldr      x2, [x8]
0068B918C  ldrb     w8, [x2, #0x53]
0068B9190  tbnz     w8, #5, #0x68b91b0
0068B9194  str      w20, [x19, #0x20]
0068B9198  b        #0x68b91c0 ; 
0068B919C  ldr      x2, [x1, #0x60]
0068B91A0  mov      x0, x19
0068B91A4  ldp      x20, x19, [sp, #0x10]
0068B91A8  ldp      x30, x21, [sp], #0x20
0068B91AC  br       x2
0068B91B0  ldr      x8, [x2, #0x60]
0068B91B4  mov      x0, x19
0068B91B8  mov      w1, w20
0068B91BC  blr      x8
0068B91C0  mov      x0, x19
0068B91C4  mov      x1, xzr
0068B91C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068B91CC  adrp     x21, #0x959c000
0068B91D0  ldrb     w8, [x21, #0x633]
0068B91D4  mov      x20, x0
0068B91D8  cbnz     w8, #0x68b91f0
0068B91DC  adrp     x0, #0x8f27000
0068B91E0  ldr      x0, [x0, #0x458]
0068B91E4  bl       #0x382bd14 ; 
0068B91E8  mov      w8, #1
0068B91EC  strb     w8, [x21, #0x633]
0068B91F0  adrp     x8, #0x8f27000
0068B91F4  ldr      x8, [x8, #0x458]
0068B91F8  ldr      x2, [x8]
0068B91FC  ldrb     w8, [x2, #0x53]
0068B9200  tbnz     w8, #5, #0x68b9218
0068B9204  mov      x0, x19
0068B9208  str      x20, [x0, #0x28]!
0068B920C  mov      x1, x20
0068B9210  bl       #0x382bcb8 ; 
0068B9214  b        #0x68b9228 ; 
0068B9218  ldr      x8, [x2, #0x60]
0068B921C  mov      x0, x19
0068B9220  mov      x1, x20
0068B9224  blr      x8
0068B9228  mov      x0, x19
0068B922C  mov      x1, xzr
0068B9230  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9234  adrp     x21, #0x959c000
0068B9238  ldrb     w8, [x21, #0x634]
0068B923C  mov      w20, w0
0068B9240  cbnz     w8, #0x68b9258
0068B9244  adrp     x0, #0x8f27000
0068B9248  ldr      x0, [x0, #0x468]
0068B924C  bl       #0x382bd14 ; 
0068B9250  mov      w8, #1
0068B9254  strb     w8, [x21, #0x634]
0068B9258  adrp     x8, #0x8f27000
0068B925C  ldr      x8, [x8, #0x468]
0068B9260  ldr      x2, [x8]
0068B9264  ldrb     w8, [x2, #0x53]
0068B9268  tbnz     w8, #5, #0x68b9274
0068B926C  str      w20, [x19, #0x30]
0068B9270  b        #0x68b9284 ; 
0068B9274  ldr      x8, [x2, #0x60]
0068B9278  mov      x0, x19
0068B927C  mov      w1, w20
0068B9280  blr      x8
0068B9284  mov      x0, x19
0068B9288  mov      x1, xzr
0068B928C  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
0068B9290  adrp     x21, #0x959c000
0068B9294  ldrb     w8, [x21, #0x635]
0068B9298  mov      x20, x0
0068B929C  cbnz     w8, #0x68b92b4
0068B92A0  adrp     x0, #0x8f27000
0068B92A4  ldr      x0, [x0, #0x470]
0068B92A8  bl       #0x382bd14 ; 
0068B92AC  mov      w8, #1
0068B92B0  strb     w8, [x21, #0x635]
0068B92B4  adrp     x8, #0x8f27000
0068B92B8  ldr      x8, [x8, #0x470]
0068B92BC  ldr      x2, [x8]
0068B92C0  ldrb     w8, [x2, #0x53]
0068B92C4  tbnz     w8, #5, #0x68b92dc
0068B92C8  mov      x0, x19
0068B92CC  str      x20, [x0, #0x38]!
0068B92D0  mov      x1, x20
0068B92D4  bl       #0x382bcb8 ; 
0068B92D8  b        #0x68b92ec ; 
0068B92DC  ldr      x8, [x2, #0x60]
0068B92E0  mov      x0, x19
0068B92E4  mov      x1, x20
0068B92E8  blr      x8
0068B92EC  mov      x0, x19
0068B92F0  mov      x1, xzr
0068B92F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B92F8  adrp     x21, #0x959c000
0068B92FC  ldrb     w8, [x21, #0x636]
0068B9300  mov      w20, w0
0068B9304  cbnz     w8, #0x68b931c
0068B9308  adrp     x0, #0x8f27000
0068B930C  ldr      x0, [x0, #0x480]
0068B9310  bl       #0x382bd14 ; 
0068B9314  mov      w8, #1
0068B9318  strb     w8, [x21, #0x636]
0068B931C  adrp     x8, #0x8f27000
0068B9320  ldr      x8, [x8, #0x480]
0068B9324  ldr      x2, [x8]
0068B9328  ldrb     w8, [x2, #0x53]
0068B932C  tbnz     w8, #5, #0x68b9338
0068B9330  str      w20, [x19, #0x40]
0068B9334  b        #0x68b9348 ; 
0068B9338  ldr      x8, [x2, #0x60]
0068B933C  mov      x0, x19
0068B9340  mov      w1, w20
0068B9344  blr      x8
0068B9348  mov      x0, x19
0068B934C  mov      x1, xzr
0068B9350  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9354  adrp     x21, #0x959c000
0068B9358  ldrb     w8, [x21, #0x637]
0068B935C  mov      w20, w0
0068B9360  cbnz     w8, #0x68b9378
0068B9364  adrp     x0, #0x8f27000
0068B9368  ldr      x0, [x0, #0x490]
0068B936C  bl       #0x382bd14 ; 
0068B9370  mov      w8, #1
0068B9374  strb     w8, [x21, #0x637]
0068B9378  adrp     x8, #0x8f27000
0068B937C  ldr      x8, [x8, #0x490]
0068B9380  ldr      x2, [x8]
0068B9384  ldrb     w8, [x2, #0x53]
0068B9388  tbnz     w8, #5, #0x68b9394
0068B938C  str      w20, [x19, #0x44]
0068B9390  b        #0x68b93a4 ; 
0068B9394  ldr      x8, [x2, #0x60]
0068B9398  mov      x0, x19
0068B939C  mov      w1, w20
0068B93A0  blr      x8
0068B93A4  mov      x0, x19
0068B93A8  mov      x1, xzr
0068B93AC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B93B0  adrp     x21, #0x959c000
0068B93B4  ldrb     w8, [x21, #0x638]
0068B93B8  mov      x20, x0
0068B93BC  cbnz     w8, #0x68b93d4
0068B93C0  adrp     x0, #0x8f27000
0068B93C4  ldr      x0, [x0, #0x4a0]
0068B93C8  bl       #0x382bd14 ; 
0068B93CC  mov      w8, #1
0068B93D0  strb     w8, [x21, #0x638]
0068B93D4  adrp     x8, #0x8f27000
0068B93D8  ldr      x8, [x8, #0x4a0]
0068B93DC  ldr      x2, [x8]
0068B93E0  ldrb     w8, [x2, #0x53]
0068B93E4  tbnz     w8, #5, #0x68b93f0
0068B93E8  str      x20, [x19, #0x48]
0068B93EC  b        #0x68b9400 ; 
0068B93F0  ldr      x8, [x2, #0x60]
0068B93F4  mov      x0, x19
0068B93F8  mov      x1, x20
0068B93FC  blr      x8
0068B9400  mov      x0, x19
0068B9404  mov      x1, xzr
0068B9408  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B940C  adrp     x21, #0x959c000
0068B9410  ldrb     w8, [x21, #0x639]
0068B9414  mov      x20, x0
0068B9418  cbnz     w8, #0x68b9430
0068B941C  adrp     x0, #0x8f27000
0068B9420  ldr      x0, [x0, #0x4b0]
0068B9424  bl       #0x382bd14 ; 
0068B9428  mov      w8, #1
0068B942C  strb     w8, [x21, #0x639]
0068B9430  adrp     x8, #0x8f27000
0068B9434  ldr      x8, [x8, #0x4b0]
0068B9438  ldr      x2, [x8]
0068B943C  ldrb     w8, [x2, #0x53]
0068B9440  tbnz     w8, #5, #0x68b944c
0068B9444  str      x20, [x19, #0x50]
0068B9448  b        #0x68b945c ; 
0068B944C  ldr      x8, [x2, #0x60]
0068B9450  mov      x0, x19
0068B9454  mov      x1, x20
0068B9458  blr      x8
0068B945C  mov      x0, x19
0068B9460  mov      x1, xzr
0068B9464  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B9468  adrp     x21, #0x959c000
0068B946C  ldrb     w8, [x21, #0x63a]
0068B9470  mov      x20, x0
0068B9474  cbnz     w8, #0x68b948c
0068B9478  adrp     x0, #0x8f27000
0068B947C  ldr      x0, [x0, #0x4c0]
0068B9480  bl       #0x382bd14 ; 
0068B9484  mov      w8, #1
0068B9488  strb     w8, [x21, #0x63a]
0068B948C  adrp     x8, #0x8f27000
0068B9490  ldr      x8, [x8, #0x4c0]
0068B9494  ldr      x2, [x8]
0068B9498  ldrb     w8, [x2, #0x53]
0068B949C  tbnz     w8, #5, #0x68b94a8
0068B94A0  str      x20, [x19, #0x58]
0068B94A4  b        #0x68b94b8 ; 
0068B94A8  ldr      x8, [x2, #0x60]
0068B94AC  mov      x0, x19
0068B94B0  mov      x1, x20
0068B94B4  blr      x8
0068B94B8  mov      x0, x19
0068B94BC  mov      x1, xzr
0068B94C0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B94C4  adrp     x21, #0x959c000
0068B94C8  ldrb     w8, [x21, #0x63b]
0068B94CC  mov      x20, x0
0068B94D0  cbnz     w8, #0x68b94e8
0068B94D4  adrp     x0, #0x8f27000
0068B94D8  ldr      x0, [x0, #0x4d0]
0068B94DC  bl       #0x382bd14 ; 
0068B94E0  mov      w8, #1
0068B94E4  strb     w8, [x21, #0x63b]
0068B94E8  adrp     x8, #0x8f27000
0068B94EC  ldr      x8, [x8, #0x4d0]
0068B94F0  ldr      x2, [x8]
0068B94F4  ldrb     w8, [x2, #0x53]
0068B94F8  tbnz     w8, #5, #0x68b9504
0068B94FC  str      x20, [x19, #0x60]
0068B9500  b        #0x68b9514 ; 
0068B9504  ldr      x8, [x2, #0x60]
0068B9508  mov      x0, x19
0068B950C  mov      x1, x20
0068B9510  blr      x8
0068B9514  mov      x0, x19
0068B9518  mov      x1, xzr
0068B951C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9520  adrp     x21, #0x959c000
0068B9524  ldrb     w8, [x21, #0x63c]
0068B9528  mov      w20, w0
0068B952C  cbnz     w8, #0x68b9544
0068B9530  adrp     x0, #0x8f27000
0068B9534  ldr      x0, [x0, #0x4e0]
0068B9538  bl       #0x382bd14 ; 
0068B953C  mov      w8, #1
0068B9540  strb     w8, [x21, #0x63c]
0068B9544  adrp     x8, #0x8f27000
0068B9548  ldr      x8, [x8, #0x4e0]
0068B954C  ldr      x2, [x8]
0068B9550  ldrb     w8, [x2, #0x53]
0068B9554  tbnz     w8, #5, #0x68b9560
0068B9558  str      w20, [x19, #0x68]
0068B955C  b        #0x68b9570 ; 
0068B9560  ldr      x8, [x2, #0x60]
0068B9564  mov      x0, x19
0068B9568  mov      w1, w20
0068B956C  blr      x8
0068B9570  mov      x0, x19
0068B9574  mov      x1, xzr
0068B9578  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B957C  adrp     x21, #0x959c000
0068B9580  ldrb     w8, [x21, #0x63d]
0068B9584  mov      w20, w0
0068B9588  cbnz     w8, #0x68b95a0
0068B958C  adrp     x0, #0x8f27000
0068B9590  ldr      x0, [x0, #0x4f0]
0068B9594  bl       #0x382bd14 ; 
0068B9598  mov      w8, #1
0068B959C  strb     w8, [x21, #0x63d]
0068B95A0  adrp     x8, #0x8f27000
0068B95A4  ldr      x8, [x8, #0x4f0]
0068B95A8  ldr      x2, [x8]
0068B95AC  ldrb     w8, [x2, #0x53]
0068B95B0  tbnz     w8, #5, #0x68b95bc
0068B95B4  str      w20, [x19, #0x6c]
0068B95B8  b        #0x68b95cc ; 
0068B95BC  ldr      x8, [x2, #0x60]
0068B95C0  mov      x0, x19
0068B95C4  mov      w1, w20
0068B95C8  blr      x8
0068B95CC  mov      x0, x19
0068B95D0  mov      x1, xzr
0068B95D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B95D8  adrp     x21, #0x959c000
0068B95DC  ldrb     w8, [x21, #0x63e]
0068B95E0  mov      w20, w0
0068B95E4  cbnz     w8, #0x68b95fc
0068B95E8  adrp     x0, #0x8f27000
0068B95EC  ldr      x0, [x0, #0x500]
0068B95F0  bl       #0x382bd14 ; 
0068B95F4  mov      w8, #1
0068B95F8  strb     w8, [x21, #0x63e]
0068B95FC  adrp     x8, #0x8f27000
0068B9600  ldr      x8, [x8, #0x500]
0068B9604  ldr      x2, [x8]
0068B9608  ldrb     w8, [x2, #0x53]
0068B960C  tbnz     w8, #5, #0x68b9618
0068B9610  str      w20, [x19, #0x70]
0068B9614  b        #0x68b9628 ; 
0068B9618  ldr      x8, [x2, #0x60]
0068B961C  mov      x0, x19
0068B9620  mov      w1, w20
0068B9624  blr      x8
0068B9628  mov      x0, x19
0068B962C  mov      x1, xzr
0068B9630  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B9634  adrp     x21, #0x959c000
0068B9638  ldrb     w8, [x21, #0x63f]
0068B963C  mov      x20, x0
0068B9640  cbnz     w8, #0x68b9658
0068B9644  adrp     x0, #0x8f27000
0068B9648  ldr      x0, [x0, #0x510]
0068B964C  bl       #0x382bd14 ; 
0068B9650  mov      w8, #1
0068B9654  strb     w8, [x21, #0x63f]
0068B9658  adrp     x8, #0x8f27000
0068B965C  ldr      x8, [x8, #0x510]
0068B9660  ldr      x2, [x8]
0068B9664  ldrb     w8, [x2, #0x53]
0068B9668  tbnz     w8, #5, #0x68b9674
0068B966C  str      x20, [x19, #0x78]
0068B9670  b        #0x68b9684 ; 
0068B9674  ldr      x8, [x2, #0x60]
0068B9678  mov      x0, x19
0068B967C  mov      x1, x20
0068B9680  blr      x8
0068B9684  mov      x0, x19
0068B9688  mov      x1, xzr
0068B968C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B9690  adrp     x21, #0x959c000
0068B9694  ldrb     w8, [x21, #0x640]
0068B9698  mov      x20, x0
0068B969C  cbnz     w8, #0x68b96b4
0068B96A0  adrp     x0, #0x8f27000
0068B96A4  ldr      x0, [x0, #0x520]
0068B96A8  bl       #0x382bd14 ; 
0068B96AC  mov      w8, #1
0068B96B0  strb     w8, [x21, #0x640]
0068B96B4  adrp     x8, #0x8f27000
0068B96B8  ldr      x8, [x8, #0x520]
0068B96BC  ldr      x2, [x8]
0068B96C0  ldrb     w8, [x2, #0x53]
0068B96C4  tbnz     w8, #5, #0x68b96d0
0068B96C8  str      x20, [x19, #0x80]
0068B96CC  b        #0x68b96e0 ; 
0068B96D0  ldr      x8, [x2, #0x60]
0068B96D4  mov      x0, x19
0068B96D8  mov      x1, x20
0068B96DC  blr      x8
0068B96E0  mov      x0, x19
0068B96E4  mov      x1, xzr
0068B96E8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B96EC  adrp     x21, #0x959c000
0068B96F0  ldrb     w8, [x21, #0x641]
0068B96F4  mov      x20, x0
0068B96F8  cbnz     w8, #0x68b9710
0068B96FC  adrp     x0, #0x8f27000
0068B9700  ldr      x0, [x0, #0x530]
0068B9704  bl       #0x382bd14 ; 
0068B9708  mov      w8, #1
0068B970C  strb     w8, [x21, #0x641]
0068B9710  adrp     x8, #0x8f27000
0068B9714  ldr      x8, [x8, #0x530]
0068B9718  ldr      x2, [x8]
0068B971C  ldrb     w8, [x2, #0x53]
0068B9720  tbnz     w8, #5, #0x68b972c
0068B9724  str      x20, [x19, #0x88]
0068B9728  b        #0x68b973c ; 
0068B972C  ldr      x8, [x2, #0x60]
0068B9730  mov      x0, x19
0068B9734  mov      x1, x20
0068B9738  blr      x8
0068B973C  mov      x0, x19
0068B9740  mov      x1, xzr
0068B9744  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068B9748  adrp     x21, #0x959c000
0068B974C  ldrb     w8, [x21, #0x642]
0068B9750  mov      x20, x0
0068B9754  cbnz     w8, #0x68b976c
0068B9758  adrp     x0, #0x8f27000
0068B975C  ldr      x0, [x0, #0x540]
0068B9760  bl       #0x382bd14 ; 
0068B9764  mov      w8, #1
0068B9768  strb     w8, [x21, #0x642]
0068B976C  adrp     x8, #0x8f27000
0068B9770  ldr      x8, [x8, #0x540]
0068B9774  ldr      x2, [x8]
0068B9778  ldrb     w8, [x2, #0x53]
0068B977C  tbnz     w8, #5, #0x68b9788
0068B9780  str      x20, [x19, #0x90]
0068B9784  b        #0x68b9798 ; 
0068B9788  ldr      x8, [x2, #0x60]
0068B978C  mov      x0, x19
0068B9790  mov      x1, x20
0068B9794  blr      x8
0068B9798  mov      x0, x19
0068B979C  mov      x1, xzr
0068B97A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B97A4  adrp     x21, #0x959c000
0068B97A8  ldrb     w8, [x21, #0x643]
0068B97AC  mov      w20, w0
0068B97B0  cbnz     w8, #0x68b97c8
0068B97B4  adrp     x0, #0x8f27000
0068B97B8  ldr      x0, [x0, #0x550]
0068B97BC  bl       #0x382bd14 ; 
0068B97C0  mov      w8, #1
0068B97C4  strb     w8, [x21, #0x643]
0068B97C8  adrp     x8, #0x8f27000
0068B97CC  ldr      x8, [x8, #0x550]
0068B97D0  ldr      x2, [x8]
0068B97D4  ldrb     w8, [x2, #0x53]
0068B97D8  tbnz     w8, #5, #0x68b97e4
0068B97DC  str      w20, [x19, #0x98]
0068B97E0  b        #0x68b97f4 ; 
0068B97E4  ldr      x8, [x2, #0x60]
0068B97E8  mov      x0, x19
0068B97EC  mov      w1, w20
0068B97F0  blr      x8
0068B97F4  mov      x0, x19
0068B97F8  mov      x1, xzr
0068B97FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9800  adrp     x21, #0x959c000
0068B9804  ldrb     w8, [x21, #0x644]
0068B9808  mov      w20, w0
0068B980C  cbnz     w8, #0x68b9824
0068B9810  adrp     x0, #0x8f27000
0068B9814  ldr      x0, [x0, #0x560]
0068B9818  bl       #0x382bd14 ; 
0068B981C  mov      w8, #1
0068B9820  strb     w8, [x21, #0x644]
0068B9824  adrp     x8, #0x8f27000
0068B9828  ldr      x8, [x8, #0x560]
0068B982C  ldr      x2, [x8]
0068B9830  ldrb     w8, [x2, #0x53]
0068B9834  tbnz     w8, #5, #0x68b9840
0068B9838  str      w20, [x19, #0x9c]
0068B983C  b        #0x68b9850 ; 
0068B9840  ldr      x8, [x2, #0x60]
0068B9844  mov      x0, x19
0068B9848  mov      w1, w20
0068B984C  blr      x8
0068B9850  mov      x0, x19
0068B9854  mov      x1, xzr
0068B9858  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068B985C  adrp     x21, #0x959c000
0068B9860  ldrb     w8, [x21, #0x645]
0068B9864  mov      x20, x0
0068B9868  cbnz     w8, #0x68b9880
0068B986C  adrp     x0, #0x8f27000
0068B9870  ldr      x0, [x0, #0x570]
0068B9874  bl       #0x382bd14 ; 
0068B9878  mov      w8, #1
0068B987C  strb     w8, [x21, #0x645]
0068B9880  adrp     x8, #0x8f27000
0068B9884  ldr      x8, [x8, #0x570]
0068B9888  ldr      x2, [x8]
0068B988C  ldrb     w8, [x2, #0x53]
0068B9890  tbnz     w8, #5, #0x68b98a8
0068B9894  mov      x0, x19
0068B9898  str      x20, [x0, #0xa0]!
0068B989C  mov      x1, x20
0068B98A0  bl       #0x382bcb8 ; 
0068B98A4  b        #0x68b98b8 ; 
0068B98A8  ldr      x8, [x2, #0x60]
0068B98AC  mov      x0, x19
0068B98B0  mov      x1, x20
0068B98B4  blr      x8
0068B98B8  mov      x0, x19
0068B98BC  mov      x1, xzr
0068B98C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B98C4  adrp     x21, #0x959c000
0068B98C8  ldrb     w8, [x21, #0x646]
0068B98CC  mov      w20, w0
0068B98D0  cbnz     w8, #0x68b98e8
0068B98D4  adrp     x0, #0x8f27000
0068B98D8  ldr      x0, [x0, #0x580]
0068B98DC  bl       #0x382bd14 ; 
0068B98E0  mov      w8, #1
0068B98E4  strb     w8, [x21, #0x646]
0068B98E8  adrp     x8, #0x8f27000
0068B98EC  ldr      x8, [x8, #0x580]
0068B98F0  ldr      x2, [x8]
0068B98F4  ldrb     w8, [x2, #0x53]
0068B98F8  tbnz     w8, #5, #0x68b9904
0068B98FC  str      w20, [x19, #0xa8]
0068B9900  b        #0x68b9914 ; 
0068B9904  ldr      x8, [x2, #0x60]
0068B9908  mov      x0, x19
0068B990C  mov      w1, w20
0068B9910  blr      x8
0068B9914  mov      x0, x19
0068B9918  mov      x1, xzr
0068B991C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9920  adrp     x21, #0x959c000
0068B9924  ldrb     w8, [x21, #0x647]
0068B9928  mov      w20, w0
0068B992C  cbnz     w8, #0x68b9944
0068B9930  adrp     x0, #0x8f27000
0068B9934  ldr      x0, [x0, #0x590]
0068B9938  bl       #0x382bd14 ; 
0068B993C  mov      w8, #1
0068B9940  strb     w8, [x21, #0x647]
0068B9944  adrp     x8, #0x8f27000
0068B9948  ldr      x8, [x8, #0x590]
0068B994C  ldr      x2, [x8]
0068B9950  ldrb     w8, [x2, #0x53]
0068B9954  tbnz     w8, #5, #0x68b9960
0068B9958  str      w20, [x19, #0xac]
0068B995C  b        #0x68b9970 ; 
0068B9960  ldr      x8, [x2, #0x60]
0068B9964  mov      x0, x19
0068B9968  mov      w1, w20
0068B996C  blr      x8
0068B9970  mov      x0, x19
0068B9974  mov      x1, xzr
0068B9978  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B997C  adrp     x21, #0x959c000
0068B9980  ldrb     w8, [x21, #0x648]
0068B9984  mov      w20, w0
0068B9988  cbnz     w8, #0x68b99a0
0068B998C  adrp     x0, #0x8f27000
0068B9990  ldr      x0, [x0, #0x5a0]
0068B9994  bl       #0x382bd14 ; 
0068B9998  mov      w8, #1
0068B999C  strb     w8, [x21, #0x648]
0068B99A0  adrp     x8, #0x8f27000
0068B99A4  ldr      x8, [x8, #0x5a0]
0068B99A8  ldr      x2, [x8]
0068B99AC  ldrb     w8, [x2, #0x53]
0068B99B0  tbnz     w8, #5, #0x68b99bc
0068B99B4  str      w20, [x19, #0xb0]
0068B99B8  b        #0x68b99cc ; 
0068B99BC  ldr      x8, [x2, #0x60]
0068B99C0  mov      x0, x19
0068B99C4  mov      w1, w20
0068B99C8  blr      x8
0068B99CC  mov      x0, x19
0068B99D0  mov      x1, xzr
0068B99D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B99D8  adrp     x21, #0x959c000
0068B99DC  ldrb     w8, [x21, #0x649]
0068B99E0  mov      w20, w0
0068B99E4  cbnz     w8, #0x68b99fc
0068B99E8  adrp     x0, #0x8f27000
0068B99EC  ldr      x0, [x0, #0x5b0]
0068B99F0  bl       #0x382bd14 ; 
0068B99F4  mov      w8, #1
0068B99F8  strb     w8, [x21, #0x649]
0068B99FC  adrp     x8, #0x8f27000
0068B9A00  ldr      x8, [x8, #0x5b0]
0068B9A04  ldr      x2, [x8]
0068B9A08  ldrb     w8, [x2, #0x53]
0068B9A0C  tbnz     w8, #5, #0x68b9a18
0068B9A10  str      w20, [x19, #0xb4]
0068B9A14  b        #0x68b9a28 ; 
0068B9A18  ldr      x8, [x2, #0x60]
0068B9A1C  mov      x0, x19
0068B9A20  mov      w1, w20
0068B9A24  blr      x8
0068B9A28  mov      x0, x19
0068B9A2C  mov      x1, xzr
0068B9A30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9A34  adrp     x21, #0x959c000
0068B9A38  ldrb     w8, [x21, #0x64a]
0068B9A3C  mov      w20, w0
0068B9A40  cbnz     w8, #0x68b9a58
0068B9A44  adrp     x0, #0x8f27000
0068B9A48  ldr      x0, [x0, #0x5c0]
0068B9A4C  bl       #0x382bd14 ; 
0068B9A50  mov      w8, #1
0068B9A54  strb     w8, [x21, #0x64a]
0068B9A58  adrp     x8, #0x8f27000
0068B9A5C  ldr      x8, [x8, #0x5c0]
0068B9A60  ldr      x2, [x8]
0068B9A64  ldrb     w8, [x2, #0x53]
0068B9A68  tbnz     w8, #5, #0x68b9a74
0068B9A6C  str      w20, [x19, #0xb8]
0068B9A70  b        #0x68b9a84 ; 
0068B9A74  ldr      x8, [x2, #0x60]
0068B9A78  mov      x0, x19
0068B9A7C  mov      w1, w20
0068B9A80  blr      x8
0068B9A84  mov      x0, x19
0068B9A88  mov      x1, xzr
0068B9A8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9A90  adrp     x21, #0x959c000
0068B9A94  ldrb     w8, [x21, #0x64b]
0068B9A98  mov      w20, w0
0068B9A9C  cbnz     w8, #0x68b9ab4
0068B9AA0  adrp     x0, #0x8f27000
0068B9AA4  ldr      x0, [x0, #0x5d0]
0068B9AA8  bl       #0x382bd14 ; 
0068B9AAC  mov      w8, #1
0068B9AB0  strb     w8, [x21, #0x64b]
0068B9AB4  adrp     x8, #0x8f27000
0068B9AB8  ldr      x8, [x8, #0x5d0]
0068B9ABC  ldr      x2, [x8]
0068B9AC0  ldrb     w8, [x2, #0x53]
0068B9AC4  tbnz     w8, #5, #0x68b9ad0
0068B9AC8  str      w20, [x19, #0xbc]
0068B9ACC  b        #0x68b9ae0 ; 
0068B9AD0  ldr      x8, [x2, #0x60]
0068B9AD4  mov      x0, x19
0068B9AD8  mov      w1, w20
0068B9ADC  blr      x8
0068B9AE0  mov      x0, x19
0068B9AE4  mov      x1, xzr
0068B9AE8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068B9AEC  adrp     x21, #0x959c000
0068B9AF0  ldrb     w8, [x21, #0x64c]
0068B9AF4  mov      x20, x0
0068B9AF8  cbnz     w8, #0x68b9b10
0068B9AFC  adrp     x0, #0x8f27000
0068B9B00  ldr      x0, [x0, #0x5e0]
0068B9B04  bl       #0x382bd14 ; 
0068B9B08  mov      w8, #1
0068B9B0C  strb     w8, [x21, #0x64c]
0068B9B10  adrp     x8, #0x8f27000
0068B9B14  ldr      x8, [x8, #0x5e0]
0068B9B18  ldr      x2, [x8]
0068B9B1C  ldrb     w8, [x2, #0x53]
0068B9B20  tbnz     w8, #5, #0x68b9b38
0068B9B24  mov      x0, x19
0068B9B28  str      x20, [x0, #0xc0]!
0068B9B2C  mov      x1, x20
0068B9B30  bl       #0x382bcb8 ; 
0068B9B34  b        #0x68b9b48 ; 
0068B9B38  ldr      x8, [x2, #0x60]
0068B9B3C  mov      x0, x19
0068B9B40  mov      x1, x20
0068B9B44  blr      x8
0068B9B48  mov      x0, x19
0068B9B4C  mov      x1, xzr
0068B9B50  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B9B54  adrp     x21, #0x959c000
0068B9B58  ldrb     w8, [x21, #0x64d]
0068B9B5C  mov      x20, x0
0068B9B60  cbnz     w8, #0x68b9b78
0068B9B64  adrp     x0, #0x8f27000
0068B9B68  ldr      x0, [x0, #0x5f0]
0068B9B6C  bl       #0x382bd14 ; 
0068B9B70  mov      w8, #1
0068B9B74  strb     w8, [x21, #0x64d]
0068B9B78  adrp     x8, #0x8f27000
0068B9B7C  ldr      x8, [x8, #0x5f0]
0068B9B80  ldr      x2, [x8]
0068B9B84  ldrb     w8, [x2, #0x53]
0068B9B88  tbnz     w8, #5, #0x68b9ba0
0068B9B8C  mov      x0, x19
0068B9B90  str      x20, [x0, #0xc8]!
0068B9B94  mov      x1, x20
0068B9B98  bl       #0x382bcb8 ; 
0068B9B9C  b        #0x68b9bb0 ; 
0068B9BA0  ldr      x8, [x2, #0x60]
0068B9BA4  mov      x0, x19
0068B9BA8  mov      x1, x20
0068B9BAC  blr      x8
0068B9BB0  mov      x0, x19
0068B9BB4  mov      x1, xzr
0068B9BB8  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
0068B9BBC  adrp     x21, #0x959c000
0068B9BC0  ldrb     w8, [x21, #0x64e]
0068B9BC4  mov      x20, x0
0068B9BC8  cbnz     w8, #0x68b9be0
0068B9BCC  adrp     x0, #0x8f27000
0068B9BD0  ldr      x0, [x0, #0x600]
0068B9BD4  bl       #0x382bd14 ; 
0068B9BD8  mov      w8, #1
0068B9BDC  strb     w8, [x21, #0x64e]
0068B9BE0  adrp     x8, #0x8f27000
0068B9BE4  ldr      x8, [x8, #0x600]
0068B9BE8  ldr      x2, [x8]
0068B9BEC  ldrb     w8, [x2, #0x53]
0068B9BF0  tbnz     w8, #5, #0x68b9c08
0068B9BF4  mov      x0, x19
0068B9BF8  str      x20, [x0, #0xd0]!
0068B9BFC  mov      x1, x20
0068B9C00  bl       #0x382bcb8 ; 
0068B9C04  b        #0x68b9c18 ; 
0068B9C08  ldr      x8, [x2, #0x60]
0068B9C0C  mov      x0, x19
0068B9C10  mov      x1, x20
0068B9C14  blr      x8
0068B9C18  mov      x0, x19
0068B9C1C  mov      x1, xzr
0068B9C20  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
0068B9C24  adrp     x21, #0x959c000
0068B9C28  ldrb     w8, [x21, #0x64f]
0068B9C2C  mov      x20, x0
0068B9C30  cbnz     w8, #0x68b9c48
0068B9C34  adrp     x0, #0x8f27000
0068B9C38  ldr      x0, [x0, #0x610]
0068B9C3C  bl       #0x382bd14 ; 
0068B9C40  mov      w8, #1
0068B9C44  strb     w8, [x21, #0x64f]
0068B9C48  adrp     x8, #0x8f27000
0068B9C4C  ldr      x8, [x8, #0x610]
0068B9C50  ldr      x2, [x8]
0068B9C54  ldrb     w8, [x2, #0x53]
0068B9C58  tbnz     w8, #5, #0x68b9c70
0068B9C5C  mov      x0, x19
0068B9C60  str      x20, [x0, #0xd8]!
0068B9C64  mov      x1, x20
0068B9C68  bl       #0x382bcb8 ; 
0068B9C6C  b        #0x68b9c80 ; 
0068B9C70  ldr      x8, [x2, #0x60]
0068B9C74  mov      x0, x19
0068B9C78  mov      x1, x20
0068B9C7C  blr      x8
0068B9C80  mov      x0, x19
0068B9C84  mov      x1, xzr
0068B9C88  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B9C8C  adrp     x21, #0x959c000
0068B9C90  ldrb     w8, [x21, #0x650]
0068B9C94  mov      x20, x0
0068B9C98  cbnz     w8, #0x68b9cb0
0068B9C9C  adrp     x0, #0x8f27000
0068B9CA0  ldr      x0, [x0, #0x620]
0068B9CA4  bl       #0x382bd14 ; 
0068B9CA8  mov      w8, #1
0068B9CAC  strb     w8, [x21, #0x650]
0068B9CB0  adrp     x8, #0x8f27000
0068B9CB4  ldr      x8, [x8, #0x620]
0068B9CB8  ldr      x2, [x8]
0068B9CBC  ldrb     w8, [x2, #0x53]
0068B9CC0  tbnz     w8, #5, #0x68b9cd8
0068B9CC4  mov      x0, x19
0068B9CC8  str      x20, [x0, #0xe0]!
0068B9CCC  mov      x1, x20
0068B9CD0  bl       #0x382bcb8 ; 
0068B9CD4  b        #0x68b9ce8 ; 
0068B9CD8  ldr      x8, [x2, #0x60]
0068B9CDC  mov      x0, x19
0068B9CE0  mov      x1, x20
0068B9CE4  blr      x8
0068B9CE8  mov      x0, x19
0068B9CEC  mov      x1, xzr
0068B9CF0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B9CF4  adrp     x21, #0x959c000
0068B9CF8  ldrb     w8, [x21, #0x651]
0068B9CFC  mov      x20, x0
0068B9D00  cbnz     w8, #0x68b9d18
0068B9D04  adrp     x0, #0x8f27000
0068B9D08  ldr      x0, [x0, #0x630]
0068B9D0C  bl       #0x382bd14 ; 
0068B9D10  mov      w8, #1
0068B9D14  strb     w8, [x21, #0x651]
0068B9D18  adrp     x8, #0x8f27000
0068B9D1C  ldr      x8, [x8, #0x630]
0068B9D20  ldr      x2, [x8]
0068B9D24  ldrb     w8, [x2, #0x53]
0068B9D28  tbnz     w8, #5, #0x68b9d40
0068B9D2C  mov      x0, x19
0068B9D30  str      x20, [x0, #0xe8]!
0068B9D34  mov      x1, x20
0068B9D38  bl       #0x382bcb8 ; 
0068B9D3C  b        #0x68b9d50 ; 
0068B9D40  ldr      x8, [x2, #0x60]
0068B9D44  mov      x0, x19
0068B9D48  mov      x1, x20
0068B9D4C  blr      x8
0068B9D50  mov      x0, x19
0068B9D54  mov      x1, xzr
0068B9D58  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B9D5C  adrp     x21, #0x959c000
0068B9D60  ldrb     w8, [x21, #0x652]
0068B9D64  mov      x20, x0
0068B9D68  cbnz     w8, #0x68b9d80
0068B9D6C  adrp     x0, #0x8f27000
0068B9D70  ldr      x0, [x0, #0x640]
0068B9D74  bl       #0x382bd14 ; 
0068B9D78  mov      w8, #1
0068B9D7C  strb     w8, [x21, #0x652]
0068B9D80  adrp     x8, #0x8f27000
0068B9D84  ldr      x8, [x8, #0x640]
0068B9D88  ldr      x2, [x8]
0068B9D8C  ldrb     w8, [x2, #0x53]
0068B9D90  tbnz     w8, #5, #0x68b9da8
0068B9D94  mov      x0, x19
0068B9D98  str      x20, [x0, #0xf0]!
0068B9D9C  mov      x1, x20
0068B9DA0  bl       #0x382bcb8 ; 
0068B9DA4  b        #0x68b9db8 ; 
0068B9DA8  ldr      x8, [x2, #0x60]
0068B9DAC  mov      x0, x19
0068B9DB0  mov      x1, x20
0068B9DB4  blr      x8
0068B9DB8  mov      x0, x19
0068B9DBC  mov      x1, xzr
0068B9DC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9DC4  adrp     x21, #0x959c000
0068B9DC8  ldrb     w8, [x21, #0x653]
0068B9DCC  mov      w20, w0
0068B9DD0  cbnz     w8, #0x68b9de8
0068B9DD4  adrp     x0, #0x8f27000
0068B9DD8  ldr      x0, [x0, #0x650]
0068B9DDC  bl       #0x382bd14 ; 
0068B9DE0  mov      w8, #1
0068B9DE4  strb     w8, [x21, #0x653]
0068B9DE8  adrp     x8, #0x8f27000
0068B9DEC  ldr      x8, [x8, #0x650]
0068B9DF0  ldr      x2, [x8]
0068B9DF4  ldrb     w8, [x2, #0x53]
0068B9DF8  tbnz     w8, #5, #0x68b9e04
0068B9DFC  str      w20, [x19, #0xf8]
0068B9E00  b        #0x68b9e14 ; 
0068B9E04  ldr      x8, [x2, #0x60]
0068B9E08  mov      x0, x19
0068B9E0C  mov      w1, w20
0068B9E10  blr      x8
0068B9E14  mov      x0, x19
0068B9E18  mov      x1, xzr
0068B9E1C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B9E20  adrp     x21, #0x959c000
0068B9E24  ldrb     w8, [x21, #0x654]
0068B9E28  mov      x20, x0
0068B9E2C  cbnz     w8, #0x68b9e44
0068B9E30  adrp     x0, #0x8f27000
0068B9E34  ldr      x0, [x0, #0x660]
0068B9E38  bl       #0x382bd14 ; 
0068B9E3C  mov      w8, #1
0068B9E40  strb     w8, [x21, #0x654]
0068B9E44  adrp     x8, #0x8f27000
0068B9E48  ldr      x8, [x8, #0x660]
0068B9E4C  ldr      x2, [x8]
0068B9E50  ldrb     w8, [x2, #0x53]
0068B9E54  tbnz     w8, #5, #0x68b9e6c
0068B9E58  add      x0, x19, #0x100
0068B9E5C  mov      x1, x20
0068B9E60  str      x20, [x19, #0x100]
0068B9E64  bl       #0x382bcb8 ; 
0068B9E68  b        #0x68b9e7c ; 
0068B9E6C  ldr      x8, [x2, #0x60]
0068B9E70  mov      x0, x19
0068B9E74  mov      x1, x20
0068B9E78  blr      x8
0068B9E7C  mov      x0, x19
0068B9E80  mov      x1, xzr
0068B9E84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B9E88  adrp     x21, #0x959c000
0068B9E8C  ldrb     w8, [x21, #0x655]
0068B9E90  mov      w20, w0
0068B9E94  cbnz     w8, #0x68b9eac
0068B9E98  adrp     x0, #0x8f27000
0068B9E9C  ldr      x0, [x0, #0x670]
0068B9EA0  bl       #0x382bd14 ; 
0068B9EA4  mov      w8, #1
0068B9EA8  strb     w8, [x21, #0x655]
0068B9EAC  adrp     x8, #0x8f27000
0068B9EB0  ldr      x8, [x8, #0x670]
0068B9EB4  ldr      x2, [x8]
0068B9EB8  ldrb     w8, [x2, #0x53]
0068B9EBC  tbnz     w8, #5, #0x68b9ec8
0068B9EC0  str      w20, [x19, #0x108]
0068B9EC4  b        #0x68b9ed8 ; 
0068B9EC8  ldr      x8, [x2, #0x60]
0068B9ECC  mov      x0, x19
0068B9ED0  mov      w1, w20
0068B9ED4  blr      x8
0068B9ED8  mov      x0, x19
0068B9EDC  mov      x1, xzr
0068B9EE0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068B9EE4  adrp     x21, #0x959c000
0068B9EE8  ldrb     w8, [x21, #0x656]
0068B9EEC  mov      x20, x0
0068B9EF0  cbnz     w8, #0x68b9f08
0068B9EF4  adrp     x0, #0x8f27000
0068B9EF8  ldr      x0, [x0, #0x680]
0068B9EFC  bl       #0x382bd14 ; 
0068B9F00  mov      w8, #1
0068B9F04  strb     w8, [x21, #0x656]
0068B9F08  adrp     x8, #0x8f27000
0068B9F0C  ldr      x8, [x8, #0x680]
0068B9F10  ldr      x2, [x8]
0068B9F14  ldrb     w8, [x2, #0x53]
0068B9F18  tbnz     w8, #5, #0x68b9f30
0068B9F1C  add      x0, x19, #0x110
0068B9F20  mov      x1, x20
0068B9F24  str      x20, [x19, #0x110]
0068B9F28  bl       #0x382bcb8 ; 
0068B9F2C  b        #0x68b9f40 ; 
0068B9F30  ldr      x8, [x2, #0x60]
0068B9F34  mov      x0, x19
0068B9F38  mov      x1, x20
0068B9F3C  blr      x8
0068B9F40  ldp      x20, x19, [sp, #0x10]
0068B9F44  mov      w0, #1
0068B9F48  ldp      x30, x21, [sp], #0x20
0068B9F4C  ret      

