; LocalModels.Bean.MissionMulti_MultiWaterfallMission$$readImpl
; RVA 0x6AB91A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AB91A0  stp      x30, x21, [sp, #-0x20]!
006AB91A4  stp      x20, x19, [sp, #0x10]
006AB91A8  adrp     x20, #0x959e000
006AB91AC  adrp     x21, #0x8f3a000
006AB91B0  ldrb     w8, [x20, #0x8b4]
006AB91B4  ldr      x21, [x21, #0xce0]
006AB91B8  mov      x19, x0
006AB91BC  tbnz     w8, #0, #0x6ab91d4
006AB91C0  adrp     x0, #0x8f3a000
006AB91C4  ldr      x0, [x0, #0xce0]
006AB91C8  bl       #0x382bd14 ; 
006AB91CC  mov      w8, #1
006AB91D0  strb     w8, [x20, #0x8b4]
006AB91D4  ldr      x1, [x21]
006AB91D8  ldrb     w8, [x1, #0x53]
006AB91DC  tbnz     w8, #5, #0x6ab922c
006AB91E0  mov      x0, x19
006AB91E4  mov      x1, xzr
006AB91E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB91EC  adrp     x21, #0x959e000
006AB91F0  ldrb     w8, [x21, #0xfca]
006AB91F4  mov      w20, w0
006AB91F8  cbnz     w8, #0x6ab9210
006AB91FC  adrp     x0, #0x8f3a000
006AB9200  ldr      x0, [x0, #0xc08]
006AB9204  bl       #0x382bd14 ; 
006AB9208  mov      w8, #1
006AB920C  strb     w8, [x21, #0xfca]
006AB9210  adrp     x8, #0x8f3a000
006AB9214  ldr      x8, [x8, #0xc08]
006AB9218  ldr      x2, [x8]
006AB921C  ldrb     w8, [x2, #0x53]
006AB9220  tbnz     w8, #5, #0x6ab9240
006AB9224  str      w20, [x19, #0x20]
006AB9228  b        #0x6ab9250 ; 
006AB922C  ldr      x2, [x1, #0x60]
006AB9230  mov      x0, x19
006AB9234  ldp      x20, x19, [sp, #0x10]
006AB9238  ldp      x30, x21, [sp], #0x20
006AB923C  br       x2
006AB9240  ldr      x8, [x2, #0x60]
006AB9244  mov      x0, x19
006AB9248  mov      w1, w20
006AB924C  blr      x8
006AB9250  mov      x0, x19
006AB9254  mov      x1, xzr
006AB9258  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB925C  adrp     x21, #0x959e000
006AB9260  ldrb     w8, [x21, #0xfcb]
006AB9264  mov      w20, w0
006AB9268  cbnz     w8, #0x6ab9280
006AB926C  adrp     x0, #0x8f3a000
006AB9270  ldr      x0, [x0, #0xc10]
006AB9274  bl       #0x382bd14 ; 
006AB9278  mov      w8, #1
006AB927C  strb     w8, [x21, #0xfcb]
006AB9280  adrp     x8, #0x8f3a000
006AB9284  ldr      x8, [x8, #0xc10]
006AB9288  ldr      x2, [x8]
006AB928C  ldrb     w8, [x2, #0x53]
006AB9290  tbnz     w8, #5, #0x6ab929c
006AB9294  str      w20, [x19, #0x24]
006AB9298  b        #0x6ab92ac ; 
006AB929C  ldr      x8, [x2, #0x60]
006AB92A0  mov      x0, x19
006AB92A4  mov      w1, w20
006AB92A8  blr      x8
006AB92AC  mov      x0, x19
006AB92B0  mov      x1, xzr
006AB92B4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB92B8  adrp     x21, #0x959e000
006AB92BC  ldrb     w8, [x21, #0xfcc]
006AB92C0  mov      x20, x0
006AB92C4  cbnz     w8, #0x6ab92dc
006AB92C8  adrp     x0, #0x8f3a000
006AB92CC  ldr      x0, [x0, #0xc18]
006AB92D0  bl       #0x382bd14 ; 
006AB92D4  mov      w8, #1
006AB92D8  strb     w8, [x21, #0xfcc]
006AB92DC  adrp     x8, #0x8f3a000
006AB92E0  ldr      x8, [x8, #0xc18]
006AB92E4  ldr      x2, [x8]
006AB92E8  ldrb     w8, [x2, #0x53]
006AB92EC  tbnz     w8, #5, #0x6ab92f8
006AB92F0  str      x20, [x19, #0x28]
006AB92F4  b        #0x6ab9308 ; 
006AB92F8  ldr      x8, [x2, #0x60]
006AB92FC  mov      x0, x19
006AB9300  mov      x1, x20
006AB9304  blr      x8
006AB9308  mov      x0, x19
006AB930C  mov      x1, xzr
006AB9310  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB9314  adrp     x21, #0x959e000
006AB9318  ldrb     w8, [x21, #0xfcd]
006AB931C  mov      x20, x0
006AB9320  cbnz     w8, #0x6ab9338
006AB9324  adrp     x0, #0x8f3a000
006AB9328  ldr      x0, [x0, #0xc20]
006AB932C  bl       #0x382bd14 ; 
006AB9330  mov      w8, #1
006AB9334  strb     w8, [x21, #0xfcd]
006AB9338  adrp     x8, #0x8f3a000
006AB933C  ldr      x8, [x8, #0xc20]
006AB9340  ldr      x2, [x8]
006AB9344  ldrb     w8, [x2, #0x53]
006AB9348  tbnz     w8, #5, #0x6ab9354
006AB934C  str      x20, [x19, #0x30]
006AB9350  b        #0x6ab9364 ; 
006AB9354  ldr      x8, [x2, #0x60]
006AB9358  mov      x0, x19
006AB935C  mov      x1, x20
006AB9360  blr      x8
006AB9364  mov      x0, x19
006AB9368  mov      x1, xzr
006AB936C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB9370  adrp     x21, #0x959e000
006AB9374  ldrb     w8, [x21, #0xfce]
006AB9378  mov      w20, w0
006AB937C  cbnz     w8, #0x6ab9394
006AB9380  adrp     x0, #0x8f3a000
006AB9384  ldr      x0, [x0, #0xc28]
006AB9388  bl       #0x382bd14 ; 
006AB938C  mov      w8, #1
006AB9390  strb     w8, [x21, #0xfce]
006AB9394  adrp     x8, #0x8f3a000
006AB9398  ldr      x8, [x8, #0xc28]
006AB939C  ldr      x2, [x8]
006AB93A0  ldrb     w8, [x2, #0x53]
006AB93A4  tbnz     w8, #5, #0x6ab93b0
006AB93A8  str      w20, [x19, #0x38]
006AB93AC  b        #0x6ab93c0 ; 
006AB93B0  ldr      x8, [x2, #0x60]
006AB93B4  mov      x0, x19
006AB93B8  mov      w1, w20
006AB93BC  blr      x8
006AB93C0  mov      x0, x19
006AB93C4  mov      x1, xzr
006AB93C8  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006AB93CC  adrp     x21, #0x959e000
006AB93D0  ldrb     w8, [x21, #0xfcf]
006AB93D4  mov      x20, x0
006AB93D8  cbnz     w8, #0x6ab93f0
006AB93DC  adrp     x0, #0x8f3a000
006AB93E0  ldr      x0, [x0, #0xc30]
006AB93E4  bl       #0x382bd14 ; 
006AB93E8  mov      w8, #1
006AB93EC  strb     w8, [x21, #0xfcf]
006AB93F0  adrp     x8, #0x8f3a000
006AB93F4  ldr      x8, [x8, #0xc30]
006AB93F8  ldr      x2, [x8]
006AB93FC  ldrb     w8, [x2, #0x53]
006AB9400  tbnz     w8, #5, #0x6ab9418
006AB9404  mov      x0, x19
006AB9408  str      x20, [x0, #0x40]!
006AB940C  mov      x1, x20
006AB9410  bl       #0x382bcb8 ; 
006AB9414  b        #0x6ab9428 ; 
006AB9418  ldr      x8, [x2, #0x60]
006AB941C  mov      x0, x19
006AB9420  mov      x1, x20
006AB9424  blr      x8
006AB9428  mov      x0, x19
006AB942C  mov      x1, xzr
006AB9430  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB9434  adrp     x21, #0x959e000
006AB9438  ldrb     w8, [x21, #0xfd0]
006AB943C  mov      x20, x0
006AB9440  cbnz     w8, #0x6ab9458
006AB9444  adrp     x0, #0x8f3a000
006AB9448  ldr      x0, [x0, #0xc40]
006AB944C  bl       #0x382bd14 ; 
006AB9450  mov      w8, #1
006AB9454  strb     w8, [x21, #0xfd0]
006AB9458  adrp     x8, #0x8f3a000
006AB945C  ldr      x8, [x8, #0xc40]
006AB9460  ldr      x2, [x8]
006AB9464  ldrb     w8, [x2, #0x53]
006AB9468  tbnz     w8, #5, #0x6ab9480
006AB946C  mov      x0, x19
006AB9470  str      x20, [x0, #0x48]!
006AB9474  mov      x1, x20
006AB9478  bl       #0x382bcb8 ; 
006AB947C  b        #0x6ab9490 ; 
006AB9480  ldr      x8, [x2, #0x60]
006AB9484  mov      x0, x19
006AB9488  mov      x1, x20
006AB948C  blr      x8
006AB9490  mov      x0, x19
006AB9494  mov      x1, xzr
006AB9498  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB949C  adrp     x21, #0x959e000
006AB94A0  ldrb     w8, [x21, #0xfd1]
006AB94A4  mov      w20, w0
006AB94A8  cbnz     w8, #0x6ab94c0
006AB94AC  adrp     x0, #0x8f3a000
006AB94B0  ldr      x0, [x0, #0xc48]
006AB94B4  bl       #0x382bd14 ; 
006AB94B8  mov      w8, #1
006AB94BC  strb     w8, [x21, #0xfd1]
006AB94C0  adrp     x8, #0x8f3a000
006AB94C4  ldr      x8, [x8, #0xc48]
006AB94C8  ldr      x2, [x8]
006AB94CC  ldrb     w8, [x2, #0x53]
006AB94D0  tbnz     w8, #5, #0x6ab94dc
006AB94D4  str      w20, [x19, #0x50]
006AB94D8  b        #0x6ab94ec ; 
006AB94DC  ldr      x8, [x2, #0x60]
006AB94E0  mov      x0, x19
006AB94E4  mov      w1, w20
006AB94E8  blr      x8
006AB94EC  mov      x0, x19
006AB94F0  mov      x1, xzr
006AB94F4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB94F8  adrp     x21, #0x959e000
006AB94FC  ldrb     w8, [x21, #0xfd2]
006AB9500  mov      x20, x0
006AB9504  cbnz     w8, #0x6ab951c
006AB9508  adrp     x0, #0x8f3a000
006AB950C  ldr      x0, [x0, #0xc50]
006AB9510  bl       #0x382bd14 ; 
006AB9514  mov      w8, #1
006AB9518  strb     w8, [x21, #0xfd2]
006AB951C  adrp     x8, #0x8f3a000
006AB9520  ldr      x8, [x8, #0xc50]
006AB9524  ldr      x2, [x8]
006AB9528  ldrb     w8, [x2, #0x53]
006AB952C  tbnz     w8, #5, #0x6ab9544
006AB9530  mov      x0, x19
006AB9534  str      x20, [x0, #0x58]!
006AB9538  mov      x1, x20
006AB953C  bl       #0x382bcb8 ; 
006AB9540  b        #0x6ab9554 ; 
006AB9544  ldr      x8, [x2, #0x60]
006AB9548  mov      x0, x19
006AB954C  mov      x1, x20
006AB9550  blr      x8
006AB9554  mov      x0, x19
006AB9558  mov      x1, xzr
006AB955C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB9560  adrp     x21, #0x959e000
006AB9564  ldrb     w8, [x21, #0xfd3]
006AB9568  mov      x20, x0
006AB956C  cbnz     w8, #0x6ab9584
006AB9570  adrp     x0, #0x8f3a000
006AB9574  ldr      x0, [x0, #0xc58]
006AB9578  bl       #0x382bd14 ; 
006AB957C  mov      w8, #1
006AB9580  strb     w8, [x21, #0xfd3]
006AB9584  adrp     x8, #0x8f3a000
006AB9588  ldr      x8, [x8, #0xc58]
006AB958C  ldr      x2, [x8]
006AB9590  ldrb     w8, [x2, #0x53]
006AB9594  tbnz     w8, #5, #0x6ab95ac
006AB9598  mov      x0, x19
006AB959C  str      x20, [x0, #0x60]!
006AB95A0  mov      x1, x20
006AB95A4  bl       #0x382bcb8 ; 
006AB95A8  b        #0x6ab95bc ; 
006AB95AC  ldr      x8, [x2, #0x60]
006AB95B0  mov      x0, x19
006AB95B4  mov      x1, x20
006AB95B8  blr      x8
006AB95BC  mov      x0, x19
006AB95C0  mov      x1, xzr
006AB95C4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB95C8  adrp     x21, #0x959e000
006AB95CC  ldrb     w8, [x21, #0xfd4]
006AB95D0  mov      x20, x0
006AB95D4  cbnz     w8, #0x6ab95ec
006AB95D8  adrp     x0, #0x8f3a000
006AB95DC  ldr      x0, [x0, #0xc60]
006AB95E0  bl       #0x382bd14 ; 
006AB95E4  mov      w8, #1
006AB95E8  strb     w8, [x21, #0xfd4]
006AB95EC  adrp     x8, #0x8f3a000
006AB95F0  ldr      x8, [x8, #0xc60]
006AB95F4  ldr      x2, [x8]
006AB95F8  ldrb     w8, [x2, #0x53]
006AB95FC  tbnz     w8, #5, #0x6ab9614
006AB9600  mov      x0, x19
006AB9604  str      x20, [x0, #0x68]!
006AB9608  mov      x1, x20
006AB960C  bl       #0x382bcb8 ; 
006AB9610  b        #0x6ab9624 ; 
006AB9614  ldr      x8, [x2, #0x60]
006AB9618  mov      x0, x19
006AB961C  mov      x1, x20
006AB9620  blr      x8
006AB9624  mov      x0, x19
006AB9628  mov      x1, xzr
006AB962C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB9630  adrp     x21, #0x959e000
006AB9634  ldrb     w8, [x21, #0xfd5]
006AB9638  mov      x20, x0
006AB963C  cbnz     w8, #0x6ab9654
006AB9640  adrp     x0, #0x8f3a000
006AB9644  ldr      x0, [x0, #0xc68]
006AB9648  bl       #0x382bd14 ; 
006AB964C  mov      w8, #1
006AB9650  strb     w8, [x21, #0xfd5]
006AB9654  adrp     x8, #0x8f3a000
006AB9658  ldr      x8, [x8, #0xc68]
006AB965C  ldr      x2, [x8]
006AB9660  ldrb     w8, [x2, #0x53]
006AB9664  tbnz     w8, #5, #0x6ab967c
006AB9668  mov      x0, x19
006AB966C  str      x20, [x0, #0x70]!
006AB9670  mov      x1, x20
006AB9674  bl       #0x382bcb8 ; 
006AB9678  b        #0x6ab968c ; 
006AB967C  ldr      x8, [x2, #0x60]
006AB9680  mov      x0, x19
006AB9684  mov      x1, x20
006AB9688  blr      x8
006AB968C  mov      x0, x19
006AB9690  mov      x1, xzr
006AB9694  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB9698  adrp     x21, #0x959e000
006AB969C  ldrb     w8, [x21, #0xfd6]
006AB96A0  mov      w20, w0
006AB96A4  cbnz     w8, #0x6ab96bc
006AB96A8  adrp     x0, #0x8f3a000
006AB96AC  ldr      x0, [x0, #0xc70]
006AB96B0  bl       #0x382bd14 ; 
006AB96B4  mov      w8, #1
006AB96B8  strb     w8, [x21, #0xfd6]
006AB96BC  adrp     x8, #0x8f3a000
006AB96C0  ldr      x8, [x8, #0xc70]
006AB96C4  ldr      x2, [x8]
006AB96C8  ldrb     w8, [x2, #0x53]
006AB96CC  tbnz     w8, #5, #0x6ab96d8
006AB96D0  str      w20, [x19, #0x78]
006AB96D4  b        #0x6ab96e8 ; 
006AB96D8  ldr      x8, [x2, #0x60]
006AB96DC  mov      x0, x19
006AB96E0  mov      w1, w20
006AB96E4  blr      x8
006AB96E8  mov      x0, x19
006AB96EC  mov      x1, xzr
006AB96F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB96F4  adrp     x21, #0x959e000
006AB96F8  ldrb     w8, [x21, #0xfd7]
006AB96FC  mov      w20, w0
006AB9700  cbnz     w8, #0x6ab9718
006AB9704  adrp     x0, #0x8f3a000
006AB9708  ldr      x0, [x0, #0xc78]
006AB970C  bl       #0x382bd14 ; 
006AB9710  mov      w8, #1
006AB9714  strb     w8, [x21, #0xfd7]
006AB9718  adrp     x8, #0x8f3a000
006AB971C  ldr      x8, [x8, #0xc78]
006AB9720  ldr      x2, [x8]
006AB9724  ldrb     w8, [x2, #0x53]
006AB9728  tbnz     w8, #5, #0x6ab9734
006AB972C  str      w20, [x19, #0x7c]
006AB9730  b        #0x6ab9744 ; 
006AB9734  ldr      x8, [x2, #0x60]
006AB9738  mov      x0, x19
006AB973C  mov      w1, w20
006AB9740  blr      x8
006AB9744  mov      x0, x19
006AB9748  mov      x1, xzr
006AB974C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB9750  adrp     x21, #0x959e000
006AB9754  ldrb     w8, [x21, #0xfd8]
006AB9758  mov      x20, x0
006AB975C  cbnz     w8, #0x6ab9774
006AB9760  adrp     x0, #0x8f3a000
006AB9764  ldr      x0, [x0, #0xc80]
006AB9768  bl       #0x382bd14 ; 
006AB976C  mov      w8, #1
006AB9770  strb     w8, [x21, #0xfd8]
006AB9774  adrp     x8, #0x8f3a000
006AB9778  ldr      x8, [x8, #0xc80]
006AB977C  ldr      x2, [x8]
006AB9780  ldrb     w8, [x2, #0x53]
006AB9784  tbnz     w8, #5, #0x6ab9790
006AB9788  str      x20, [x19, #0x80]
006AB978C  b        #0x6ab97a0 ; 
006AB9790  ldr      x8, [x2, #0x60]
006AB9794  mov      x0, x19
006AB9798  mov      x1, x20
006AB979C  blr      x8
006AB97A0  mov      x0, x19
006AB97A4  mov      x1, xzr
006AB97A8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB97AC  adrp     x21, #0x959e000
006AB97B0  ldrb     w8, [x21, #0xfd9]
006AB97B4  mov      x20, x0
006AB97B8  cbnz     w8, #0x6ab97d0
006AB97BC  adrp     x0, #0x8f3a000
006AB97C0  ldr      x0, [x0, #0xc88]
006AB97C4  bl       #0x382bd14 ; 
006AB97C8  mov      w8, #1
006AB97CC  strb     w8, [x21, #0xfd9]
006AB97D0  adrp     x8, #0x8f3a000
006AB97D4  ldr      x8, [x8, #0xc88]
006AB97D8  ldr      x2, [x8]
006AB97DC  ldrb     w8, [x2, #0x53]
006AB97E0  tbnz     w8, #5, #0x6ab97ec
006AB97E4  str      x20, [x19, #0x88]
006AB97E8  b        #0x6ab97fc ; 
006AB97EC  ldr      x8, [x2, #0x60]
006AB97F0  mov      x0, x19
006AB97F4  mov      x1, x20
006AB97F8  blr      x8
006AB97FC  mov      x0, x19
006AB9800  mov      x1, xzr
006AB9804  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB9808  adrp     x21, #0x959e000
006AB980C  ldrb     w8, [x21, #0xfda]
006AB9810  mov      x20, x0
006AB9814  cbnz     w8, #0x6ab982c
006AB9818  adrp     x0, #0x8f3a000
006AB981C  ldr      x0, [x0, #0xc90]
006AB9820  bl       #0x382bd14 ; 
006AB9824  mov      w8, #1
006AB9828  strb     w8, [x21, #0xfda]
006AB982C  adrp     x8, #0x8f3a000
006AB9830  ldr      x8, [x8, #0xc90]
006AB9834  ldr      x2, [x8]
006AB9838  ldrb     w8, [x2, #0x53]
006AB983C  tbnz     w8, #5, #0x6ab9848
006AB9840  str      x20, [x19, #0x90]
006AB9844  b        #0x6ab9858 ; 
006AB9848  ldr      x8, [x2, #0x60]
006AB984C  mov      x0, x19
006AB9850  mov      x1, x20
006AB9854  blr      x8
006AB9858  mov      x0, x19
006AB985C  mov      x1, xzr
006AB9860  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB9864  adrp     x21, #0x959e000
006AB9868  ldrb     w8, [x21, #0xfdb]
006AB986C  mov      x20, x0
006AB9870  cbnz     w8, #0x6ab9888
006AB9874  adrp     x0, #0x8f3a000
006AB9878  ldr      x0, [x0, #0xc98]
006AB987C  bl       #0x382bd14 ; 
006AB9880  mov      w8, #1
006AB9884  strb     w8, [x21, #0xfdb]
006AB9888  adrp     x8, #0x8f3a000
006AB988C  ldr      x8, [x8, #0xc98]
006AB9890  ldr      x2, [x8]
006AB9894  ldrb     w8, [x2, #0x53]
006AB9898  tbnz     w8, #5, #0x6ab98a4
006AB989C  str      x20, [x19, #0x98]
006AB98A0  b        #0x6ab98b4 ; 
006AB98A4  ldr      x8, [x2, #0x60]
006AB98A8  mov      x0, x19
006AB98AC  mov      x1, x20
006AB98B0  blr      x8
006AB98B4  mov      x0, x19
006AB98B8  mov      x1, xzr
006AB98BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB98C0  adrp     x21, #0x959e000
006AB98C4  ldrb     w8, [x21, #0xfdc]
006AB98C8  mov      w20, w0
006AB98CC  cbnz     w8, #0x6ab98e4
006AB98D0  adrp     x0, #0x8f3a000
006AB98D4  ldr      x0, [x0, #0xca8]
006AB98D8  bl       #0x382bd14 ; 
006AB98DC  mov      w8, #1
006AB98E0  strb     w8, [x21, #0xfdc]
006AB98E4  adrp     x8, #0x8f3a000
006AB98E8  ldr      x8, [x8, #0xca8]
006AB98EC  ldr      x2, [x8]
006AB98F0  ldrb     w8, [x2, #0x53]
006AB98F4  tbnz     w8, #5, #0x6ab9900
006AB98F8  str      w20, [x19, #0xa0]
006AB98FC  b        #0x6ab9910 ; 
006AB9900  ldr      x8, [x2, #0x60]
006AB9904  mov      x0, x19
006AB9908  mov      w1, w20
006AB990C  blr      x8
006AB9910  mov      x0, x19
006AB9914  mov      x1, xzr
006AB9918  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB991C  adrp     x21, #0x959e000
006AB9920  ldrb     w8, [x21, #0xfdd]
006AB9924  mov      x20, x0
006AB9928  cbnz     w8, #0x6ab9940
006AB992C  adrp     x0, #0x8f3a000
006AB9930  ldr      x0, [x0, #0xcb0]
006AB9934  bl       #0x382bd14 ; 
006AB9938  mov      w8, #1
006AB993C  strb     w8, [x21, #0xfdd]
006AB9940  adrp     x8, #0x8f3a000
006AB9944  ldr      x8, [x8, #0xcb0]
006AB9948  ldr      x2, [x8]
006AB994C  ldrb     w8, [x2, #0x53]
006AB9950  tbnz     w8, #5, #0x6ab9968
006AB9954  mov      x0, x19
006AB9958  str      x20, [x0, #0xa8]!
006AB995C  mov      x1, x20
006AB9960  bl       #0x382bcb8 ; 
006AB9964  b        #0x6ab9978 ; 
006AB9968  ldr      x8, [x2, #0x60]
006AB996C  mov      x0, x19
006AB9970  mov      x1, x20
006AB9974  blr      x8
006AB9978  mov      x0, x19
006AB997C  mov      x1, xzr
006AB9980  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB9984  adrp     x21, #0x959e000
006AB9988  ldrb     w8, [x21, #0xfde]
006AB998C  mov      w20, w0
006AB9990  cbnz     w8, #0x6ab99a8
006AB9994  adrp     x0, #0x8f3a000
006AB9998  ldr      x0, [x0, #0xcb8]
006AB999C  bl       #0x382bd14 ; 
006AB99A0  mov      w8, #1
006AB99A4  strb     w8, [x21, #0xfde]
006AB99A8  adrp     x8, #0x8f3a000
006AB99AC  ldr      x8, [x8, #0xcb8]
006AB99B0  ldr      x2, [x8]
006AB99B4  ldrb     w8, [x2, #0x53]
006AB99B8  tbnz     w8, #5, #0x6ab99c4
006AB99BC  str      w20, [x19, #0xb0]
006AB99C0  b        #0x6ab99d4 ; 
006AB99C4  ldr      x8, [x2, #0x60]
006AB99C8  mov      x0, x19
006AB99CC  mov      w1, w20
006AB99D0  blr      x8
006AB99D4  mov      x0, x19
006AB99D8  mov      x1, xzr
006AB99DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB99E0  adrp     x21, #0x959e000
006AB99E4  ldrb     w8, [x21, #0xfdf]
006AB99E8  mov      x20, x0
006AB99EC  cbnz     w8, #0x6ab9a04
006AB99F0  adrp     x0, #0x8f3a000
006AB99F4  ldr      x0, [x0, #0xcc8]
006AB99F8  bl       #0x382bd14 ; 
006AB99FC  mov      w8, #1
006AB9A00  strb     w8, [x21, #0xfdf]
006AB9A04  adrp     x8, #0x8f3a000
006AB9A08  ldr      x8, [x8, #0xcc8]
006AB9A0C  ldr      x2, [x8]
006AB9A10  ldrb     w8, [x2, #0x53]
006AB9A14  tbnz     w8, #5, #0x6ab9a2c
006AB9A18  mov      x0, x19
006AB9A1C  str      x20, [x0, #0xb8]!
006AB9A20  mov      x1, x20
006AB9A24  bl       #0x382bcb8 ; 
006AB9A28  b        #0x6ab9a3c ; 
006AB9A2C  ldr      x8, [x2, #0x60]
006AB9A30  mov      x0, x19
006AB9A34  mov      x1, x20
006AB9A38  blr      x8
006AB9A3C  mov      x0, x19
006AB9A40  mov      x1, xzr
006AB9A44  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AB9A48  adrp     x21, #0x959e000
006AB9A4C  ldrb     w8, [x21, #0xfe0]
006AB9A50  mov      x20, x0
006AB9A54  cbnz     w8, #0x6ab9a6c
006AB9A58  adrp     x0, #0x8f3a000
006AB9A5C  ldr      x0, [x0, #0xcd8]
006AB9A60  bl       #0x382bd14 ; 
006AB9A64  mov      w8, #1
006AB9A68  strb     w8, [x21, #0xfe0]
006AB9A6C  adrp     x8, #0x8f3a000
006AB9A70  ldr      x8, [x8, #0xcd8]
006AB9A74  ldr      x2, [x8]
006AB9A78  ldrb     w8, [x2, #0x53]
006AB9A7C  tbnz     w8, #5, #0x6ab9a94
006AB9A80  str      x20, [x19, #0xc0]!
006AB9A84  mov      x0, x19
006AB9A88  mov      x1, x20
006AB9A8C  bl       #0x382bcb8 ; 
006AB9A90  b        #0x6ab9aa4 ; 
006AB9A94  ldr      x8, [x2, #0x60]
006AB9A98  mov      x0, x19
006AB9A9C  mov      x1, x20
006AB9AA0  blr      x8
006AB9AA4  ldp      x20, x19, [sp, #0x10]
006AB9AA8  mov      w0, #1
006AB9AAC  ldp      x30, x21, [sp], #0x20
006AB9AB0  ret      

