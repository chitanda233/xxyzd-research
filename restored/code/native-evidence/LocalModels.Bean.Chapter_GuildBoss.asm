; LocalModels.Bean.Chapter_GuildBoss$$readImpl
; RVA 0x68A9284; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068A9284  str      d8, [sp, #-0x30]!
0068A9288  stp      x30, x21, [sp, #0x10]
0068A928C  stp      x20, x19, [sp, #0x20]
0068A9290  adrp     x20, #0x959b000
0068A9294  adrp     x21, #0x8f26000
0068A9298  ldrb     w8, [x20, #0xfc3]
0068A929C  ldr      x21, [x21, #0xa40]
0068A92A0  mov      x19, x0
0068A92A4  tbnz     w8, #0, #0x68a92bc
0068A92A8  adrp     x0, #0x8f26000
0068A92AC  ldr      x0, [x0, #0xa40]
0068A92B0  bl       #0x382bd14 ; 
0068A92B4  mov      w8, #1
0068A92B8  strb     w8, [x20, #0xfc3]
0068A92BC  ldr      x1, [x21]
0068A92C0  ldrb     w8, [x1, #0x53]
0068A92C4  tbnz     w8, #5, #0x68a9314
0068A92C8  mov      x0, x19
0068A92CC  mov      x1, xzr
0068A92D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A92D4  adrp     x21, #0x959c000
0068A92D8  ldrb     w8, [x21, #0x56a]
0068A92DC  mov      w20, w0
0068A92E0  cbnz     w8, #0x68a92f8
0068A92E4  adrp     x0, #0x8f26000
0068A92E8  ldr      x0, [x0, #0x810]
0068A92EC  bl       #0x382bd14 ; 
0068A92F0  mov      w8, #1
0068A92F4  strb     w8, [x21, #0x56a]
0068A92F8  adrp     x8, #0x8f26000
0068A92FC  ldr      x8, [x8, #0x810]
0068A9300  ldr      x2, [x8]
0068A9304  ldrb     w8, [x2, #0x53]
0068A9308  tbnz     w8, #5, #0x68a932c
0068A930C  str      w20, [x19, #0x20]
0068A9310  b        #0x68a933c ; 
0068A9314  ldr      x2, [x1, #0x60]
0068A9318  mov      x0, x19
0068A931C  ldp      x20, x19, [sp, #0x20]
0068A9320  ldp      x30, x21, [sp, #0x10]
0068A9324  ldr      d8, [sp], #0x30
0068A9328  br       x2
0068A932C  ldr      x8, [x2, #0x60]
0068A9330  mov      x0, x19
0068A9334  mov      w1, w20
0068A9338  blr      x8
0068A933C  mov      x0, x19
0068A9340  mov      x1, xzr
0068A9344  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A9348  adrp     x21, #0x959c000
0068A934C  ldrb     w8, [x21, #0x56b]
0068A9350  mov      x20, x0
0068A9354  cbnz     w8, #0x68a936c
0068A9358  adrp     x0, #0x8f26000
0068A935C  ldr      x0, [x0, #0x820]
0068A9360  bl       #0x382bd14 ; 
0068A9364  mov      w8, #1
0068A9368  strb     w8, [x21, #0x56b]
0068A936C  adrp     x8, #0x8f26000
0068A9370  ldr      x8, [x8, #0x820]
0068A9374  ldr      x2, [x8]
0068A9378  ldrb     w8, [x2, #0x53]
0068A937C  tbnz     w8, #5, #0x68a9394
0068A9380  mov      x0, x19
0068A9384  str      x20, [x0, #0x28]!
0068A9388  mov      x1, x20
0068A938C  bl       #0x382bcb8 ; 
0068A9390  b        #0x68a93a4 ; 
0068A9394  ldr      x8, [x2, #0x60]
0068A9398  mov      x0, x19
0068A939C  mov      x1, x20
0068A93A0  blr      x8
0068A93A4  mov      x0, x19
0068A93A8  mov      x1, xzr
0068A93AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A93B0  adrp     x21, #0x959c000
0068A93B4  ldrb     w8, [x21, #0x56c]
0068A93B8  mov      w20, w0
0068A93BC  cbnz     w8, #0x68a93d4
0068A93C0  adrp     x0, #0x8f26000
0068A93C4  ldr      x0, [x0, #0x830]
0068A93C8  bl       #0x382bd14 ; 
0068A93CC  mov      w8, #1
0068A93D0  strb     w8, [x21, #0x56c]
0068A93D4  adrp     x8, #0x8f26000
0068A93D8  ldr      x8, [x8, #0x830]
0068A93DC  ldr      x2, [x8]
0068A93E0  ldrb     w8, [x2, #0x53]
0068A93E4  tbnz     w8, #5, #0x68a93f0
0068A93E8  str      w20, [x19, #0x30]
0068A93EC  b        #0x68a9400 ; 
0068A93F0  ldr      x8, [x2, #0x60]
0068A93F4  mov      x0, x19
0068A93F8  mov      w1, w20
0068A93FC  blr      x8
0068A9400  mov      x0, x19
0068A9404  mov      x1, xzr
0068A9408  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A940C  adrp     x21, #0x959c000
0068A9410  ldrb     w8, [x21, #0x56d]
0068A9414  mov      w20, w0
0068A9418  cbnz     w8, #0x68a9430
0068A941C  adrp     x0, #0x8f26000
0068A9420  ldr      x0, [x0, #0x840]
0068A9424  bl       #0x382bd14 ; 
0068A9428  mov      w8, #1
0068A942C  strb     w8, [x21, #0x56d]
0068A9430  adrp     x8, #0x8f26000
0068A9434  ldr      x8, [x8, #0x840]
0068A9438  ldr      x2, [x8]
0068A943C  ldrb     w8, [x2, #0x53]
0068A9440  tbnz     w8, #5, #0x68a944c
0068A9444  str      w20, [x19, #0x34]
0068A9448  b        #0x68a945c ; 
0068A944C  ldr      x8, [x2, #0x60]
0068A9450  mov      x0, x19
0068A9454  mov      w1, w20
0068A9458  blr      x8
0068A945C  mov      x0, x19
0068A9460  mov      x1, xzr
0068A9464  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A9468  adrp     x21, #0x959c000
0068A946C  ldrb     w8, [x21, #0x56e]
0068A9470  mov      x20, x0
0068A9474  cbnz     w8, #0x68a948c
0068A9478  adrp     x0, #0x8f26000
0068A947C  ldr      x0, [x0, #0x850]
0068A9480  bl       #0x382bd14 ; 
0068A9484  mov      w8, #1
0068A9488  strb     w8, [x21, #0x56e]
0068A948C  adrp     x8, #0x8f26000
0068A9490  ldr      x8, [x8, #0x850]
0068A9494  ldr      x2, [x8]
0068A9498  ldrb     w8, [x2, #0x53]
0068A949C  tbnz     w8, #5, #0x68a94b4
0068A94A0  mov      x0, x19
0068A94A4  str      x20, [x0, #0x38]!
0068A94A8  mov      x1, x20
0068A94AC  bl       #0x382bcb8 ; 
0068A94B0  b        #0x68a94c4 ; 
0068A94B4  ldr      x8, [x2, #0x60]
0068A94B8  mov      x0, x19
0068A94BC  mov      x1, x20
0068A94C0  blr      x8
0068A94C4  mov      x0, x19
0068A94C8  mov      x1, xzr
0068A94CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A94D0  adrp     x21, #0x959c000
0068A94D4  ldrb     w8, [x21, #0x56f]
0068A94D8  mov      w20, w0
0068A94DC  cbnz     w8, #0x68a94f4
0068A94E0  adrp     x0, #0x8f26000
0068A94E4  ldr      x0, [x0, #0x860]
0068A94E8  bl       #0x382bd14 ; 
0068A94EC  mov      w8, #1
0068A94F0  strb     w8, [x21, #0x56f]
0068A94F4  adrp     x8, #0x8f26000
0068A94F8  ldr      x8, [x8, #0x860]
0068A94FC  ldr      x2, [x8]
0068A9500  ldrb     w8, [x2, #0x53]
0068A9504  tbnz     w8, #5, #0x68a9510
0068A9508  str      w20, [x19, #0x40]
0068A950C  b        #0x68a9520 ; 
0068A9510  ldr      x8, [x2, #0x60]
0068A9514  mov      x0, x19
0068A9518  mov      w1, w20
0068A951C  blr      x8
0068A9520  mov      x0, x19
0068A9524  mov      x1, xzr
0068A9528  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A952C  adrp     x21, #0x959c000
0068A9530  ldrb     w8, [x21, #0x570]
0068A9534  mov      w20, w0
0068A9538  cbnz     w8, #0x68a9550
0068A953C  adrp     x0, #0x8f26000
0068A9540  ldr      x0, [x0, #0x870]
0068A9544  bl       #0x382bd14 ; 
0068A9548  mov      w8, #1
0068A954C  strb     w8, [x21, #0x570]
0068A9550  adrp     x8, #0x8f26000
0068A9554  ldr      x8, [x8, #0x870]
0068A9558  ldr      x2, [x8]
0068A955C  ldrb     w8, [x2, #0x53]
0068A9560  tbnz     w8, #5, #0x68a956c
0068A9564  str      w20, [x19, #0x44]
0068A9568  b        #0x68a957c ; 
0068A956C  ldr      x8, [x2, #0x60]
0068A9570  mov      x0, x19
0068A9574  mov      w1, w20
0068A9578  blr      x8
0068A957C  mov      x0, x19
0068A9580  mov      x1, xzr
0068A9584  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A9588  adrp     x21, #0x959c000
0068A958C  ldrb     w8, [x21, #0x571]
0068A9590  mov      w20, w0
0068A9594  cbnz     w8, #0x68a95ac
0068A9598  adrp     x0, #0x8f26000
0068A959C  ldr      x0, [x0, #0x880]
0068A95A0  bl       #0x382bd14 ; 
0068A95A4  mov      w8, #1
0068A95A8  strb     w8, [x21, #0x571]
0068A95AC  adrp     x8, #0x8f26000
0068A95B0  ldr      x8, [x8, #0x880]
0068A95B4  ldr      x2, [x8]
0068A95B8  ldrb     w8, [x2, #0x53]
0068A95BC  tbnz     w8, #5, #0x68a95c8
0068A95C0  str      w20, [x19, #0x48]
0068A95C4  b        #0x68a95d8 ; 
0068A95C8  ldr      x8, [x2, #0x60]
0068A95CC  mov      x0, x19
0068A95D0  mov      w1, w20
0068A95D4  blr      x8
0068A95D8  mov      x0, x19
0068A95DC  mov      x1, xzr
0068A95E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A95E4  adrp     x21, #0x959c000
0068A95E8  ldrb     w8, [x21, #0x572]
0068A95EC  mov      w20, w0
0068A95F0  cbnz     w8, #0x68a9608
0068A95F4  adrp     x0, #0x8f26000
0068A95F8  ldr      x0, [x0, #0x890]
0068A95FC  bl       #0x382bd14 ; 
0068A9600  mov      w8, #1
0068A9604  strb     w8, [x21, #0x572]
0068A9608  adrp     x8, #0x8f26000
0068A960C  ldr      x8, [x8, #0x890]
0068A9610  ldr      x2, [x8]
0068A9614  ldrb     w8, [x2, #0x53]
0068A9618  tbnz     w8, #5, #0x68a9624
0068A961C  str      w20, [x19, #0x4c]
0068A9620  b        #0x68a9634 ; 
0068A9624  ldr      x8, [x2, #0x60]
0068A9628  mov      x0, x19
0068A962C  mov      w1, w20
0068A9630  blr      x8
0068A9634  mov      x0, x19
0068A9638  mov      x1, xzr
0068A963C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A9640  adrp     x21, #0x959c000
0068A9644  ldrb     w8, [x21, #0x573]
0068A9648  mov      x20, x0
0068A964C  cbnz     w8, #0x68a9664
0068A9650  adrp     x0, #0x8f26000
0068A9654  ldr      x0, [x0, #0x8a0]
0068A9658  bl       #0x382bd14 ; 
0068A965C  mov      w8, #1
0068A9660  strb     w8, [x21, #0x573]
0068A9664  adrp     x8, #0x8f26000
0068A9668  ldr      x8, [x8, #0x8a0]
0068A966C  ldr      x2, [x8]
0068A9670  ldrb     w8, [x2, #0x53]
0068A9674  tbnz     w8, #5, #0x68a9680
0068A9678  str      x20, [x19, #0x50]
0068A967C  b        #0x68a9690 ; 
0068A9680  ldr      x8, [x2, #0x60]
0068A9684  mov      x0, x19
0068A9688  mov      x1, x20
0068A968C  blr      x8
0068A9690  mov      x0, x19
0068A9694  mov      x1, xzr
0068A9698  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A969C  adrp     x21, #0x959c000
0068A96A0  ldrb     w8, [x21, #0x574]
0068A96A4  mov      x20, x0
0068A96A8  cbnz     w8, #0x68a96c0
0068A96AC  adrp     x0, #0x8f26000
0068A96B0  ldr      x0, [x0, #0x8b0]
0068A96B4  bl       #0x382bd14 ; 
0068A96B8  mov      w8, #1
0068A96BC  strb     w8, [x21, #0x574]
0068A96C0  adrp     x8, #0x8f26000
0068A96C4  ldr      x8, [x8, #0x8b0]
0068A96C8  ldr      x2, [x8]
0068A96CC  ldrb     w8, [x2, #0x53]
0068A96D0  tbnz     w8, #5, #0x68a96dc
0068A96D4  str      x20, [x19, #0x58]
0068A96D8  b        #0x68a96ec ; 
0068A96DC  ldr      x8, [x2, #0x60]
0068A96E0  mov      x0, x19
0068A96E4  mov      x1, x20
0068A96E8  blr      x8
0068A96EC  mov      x0, x19
0068A96F0  mov      x1, xzr
0068A96F4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A96F8  adrp     x21, #0x959c000
0068A96FC  ldrb     w8, [x21, #0x575]
0068A9700  mov      x20, x0
0068A9704  cbnz     w8, #0x68a971c
0068A9708  adrp     x0, #0x8f26000
0068A970C  ldr      x0, [x0, #0x8c0]
0068A9710  bl       #0x382bd14 ; 
0068A9714  mov      w8, #1
0068A9718  strb     w8, [x21, #0x575]
0068A971C  adrp     x8, #0x8f26000
0068A9720  ldr      x8, [x8, #0x8c0]
0068A9724  ldr      x2, [x8]
0068A9728  ldrb     w8, [x2, #0x53]
0068A972C  tbnz     w8, #5, #0x68a9738
0068A9730  str      x20, [x19, #0x60]
0068A9734  b        #0x68a9748 ; 
0068A9738  ldr      x8, [x2, #0x60]
0068A973C  mov      x0, x19
0068A9740  mov      x1, x20
0068A9744  blr      x8
0068A9748  mov      x0, x19
0068A974C  mov      x1, xzr
0068A9750  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A9754  adrp     x21, #0x959c000
0068A9758  ldrb     w8, [x21, #0x576]
0068A975C  mov      x20, x0
0068A9760  cbnz     w8, #0x68a9778
0068A9764  adrp     x0, #0x8f26000
0068A9768  ldr      x0, [x0, #0x8d0]
0068A976C  bl       #0x382bd14 ; 
0068A9770  mov      w8, #1
0068A9774  strb     w8, [x21, #0x576]
0068A9778  adrp     x8, #0x8f26000
0068A977C  ldr      x8, [x8, #0x8d0]
0068A9780  ldr      x2, [x8]
0068A9784  ldrb     w8, [x2, #0x53]
0068A9788  tbnz     w8, #5, #0x68a9794
0068A978C  str      x20, [x19, #0x68]
0068A9790  b        #0x68a97a4 ; 
0068A9794  ldr      x8, [x2, #0x60]
0068A9798  mov      x0, x19
0068A979C  mov      x1, x20
0068A97A0  blr      x8
0068A97A4  mov      x0, x19
0068A97A8  mov      x1, xzr
0068A97AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A97B0  adrp     x21, #0x959c000
0068A97B4  ldrb     w8, [x21, #0x577]
0068A97B8  mov      w20, w0
0068A97BC  cbnz     w8, #0x68a97d4
0068A97C0  adrp     x0, #0x8f26000
0068A97C4  ldr      x0, [x0, #0x8e0]
0068A97C8  bl       #0x382bd14 ; 
0068A97CC  mov      w8, #1
0068A97D0  strb     w8, [x21, #0x577]
0068A97D4  adrp     x8, #0x8f26000
0068A97D8  ldr      x8, [x8, #0x8e0]
0068A97DC  ldr      x2, [x8]
0068A97E0  ldrb     w8, [x2, #0x53]
0068A97E4  tbnz     w8, #5, #0x68a97f0
0068A97E8  str      w20, [x19, #0x70]
0068A97EC  b        #0x68a9800 ; 
0068A97F0  ldr      x8, [x2, #0x60]
0068A97F4  mov      x0, x19
0068A97F8  mov      w1, w20
0068A97FC  blr      x8
0068A9800  mov      x0, x19
0068A9804  mov      x1, xzr
0068A9808  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A980C  adrp     x21, #0x959c000
0068A9810  ldrb     w8, [x21, #0x578]
0068A9814  mov      x20, x0
0068A9818  cbnz     w8, #0x68a9830
0068A981C  adrp     x0, #0x8f26000
0068A9820  ldr      x0, [x0, #0x8f0]
0068A9824  bl       #0x382bd14 ; 
0068A9828  mov      w8, #1
0068A982C  strb     w8, [x21, #0x578]
0068A9830  adrp     x8, #0x8f26000
0068A9834  ldr      x8, [x8, #0x8f0]
0068A9838  ldr      x2, [x8]
0068A983C  ldrb     w8, [x2, #0x53]
0068A9840  tbnz     w8, #5, #0x68a9858
0068A9844  mov      x0, x19
0068A9848  str      x20, [x0, #0x78]!
0068A984C  mov      x1, x20
0068A9850  bl       #0x382bcb8 ; 
0068A9854  b        #0x68a9868 ; 
0068A9858  ldr      x8, [x2, #0x60]
0068A985C  mov      x0, x19
0068A9860  mov      x1, x20
0068A9864  blr      x8
0068A9868  mov      x0, x19
0068A986C  mov      x1, xzr
0068A9870  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A9874  adrp     x21, #0x959c000
0068A9878  ldrb     w8, [x21, #0x579]
0068A987C  mov      w20, w0
0068A9880  cbnz     w8, #0x68a9898
0068A9884  adrp     x0, #0x8f26000
0068A9888  ldr      x0, [x0, #0x900]
0068A988C  bl       #0x382bd14 ; 
0068A9890  mov      w8, #1
0068A9894  strb     w8, [x21, #0x579]
0068A9898  adrp     x8, #0x8f26000
0068A989C  ldr      x8, [x8, #0x900]
0068A98A0  ldr      x2, [x8]
0068A98A4  ldrb     w8, [x2, #0x53]
0068A98A8  tbnz     w8, #5, #0x68a98b4
0068A98AC  str      w20, [x19, #0x80]
0068A98B0  b        #0x68a98c4 ; 
0068A98B4  ldr      x8, [x2, #0x60]
0068A98B8  mov      x0, x19
0068A98BC  mov      w1, w20
0068A98C0  blr      x8
0068A98C4  mov      x0, x19
0068A98C8  mov      x1, xzr
0068A98CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A98D0  adrp     x21, #0x959c000
0068A98D4  ldrb     w8, [x21, #0x57a]
0068A98D8  mov      w20, w0
0068A98DC  cbnz     w8, #0x68a98f4
0068A98E0  adrp     x0, #0x8f26000
0068A98E4  ldr      x0, [x0, #0x910]
0068A98E8  bl       #0x382bd14 ; 
0068A98EC  mov      w8, #1
0068A98F0  strb     w8, [x21, #0x57a]
0068A98F4  adrp     x8, #0x8f26000
0068A98F8  ldr      x8, [x8, #0x910]
0068A98FC  ldr      x2, [x8]
0068A9900  ldrb     w8, [x2, #0x53]
0068A9904  tbnz     w8, #5, #0x68a9910
0068A9908  str      w20, [x19, #0x84]
0068A990C  b        #0x68a9920 ; 
0068A9910  ldr      x8, [x2, #0x60]
0068A9914  mov      x0, x19
0068A9918  mov      w1, w20
0068A991C  blr      x8
0068A9920  mov      x0, x19
0068A9924  mov      x1, xzr
0068A9928  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A992C  adrp     x21, #0x959c000
0068A9930  ldrb     w8, [x21, #0x57b]
0068A9934  mov      w20, w0
0068A9938  cbnz     w8, #0x68a9950
0068A993C  adrp     x0, #0x8f26000
0068A9940  ldr      x0, [x0, #0x920]
0068A9944  bl       #0x382bd14 ; 
0068A9948  mov      w8, #1
0068A994C  strb     w8, [x21, #0x57b]
0068A9950  adrp     x8, #0x8f26000
0068A9954  ldr      x8, [x8, #0x920]
0068A9958  ldr      x2, [x8]
0068A995C  ldrb     w8, [x2, #0x53]
0068A9960  tbnz     w8, #5, #0x68a996c
0068A9964  str      w20, [x19, #0x88]
0068A9968  b        #0x68a997c ; 
0068A996C  ldr      x8, [x2, #0x60]
0068A9970  mov      x0, x19
0068A9974  mov      w1, w20
0068A9978  blr      x8
0068A997C  mov      x0, x19
0068A9980  mov      x1, xzr
0068A9984  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A9988  adrp     x21, #0x959c000
0068A998C  ldrb     w8, [x21, #0x57c]
0068A9990  mov      w20, w0
0068A9994  cbnz     w8, #0x68a99ac
0068A9998  adrp     x0, #0x8f26000
0068A999C  ldr      x0, [x0, #0x928]
0068A99A0  bl       #0x382bd14 ; 
0068A99A4  mov      w8, #1
0068A99A8  strb     w8, [x21, #0x57c]
0068A99AC  adrp     x8, #0x8f26000
0068A99B0  ldr      x8, [x8, #0x928]
0068A99B4  ldr      x2, [x8]
0068A99B8  ldrb     w8, [x2, #0x53]
0068A99BC  tbnz     w8, #5, #0x68a99c8
0068A99C0  str      w20, [x19, #0x8c]
0068A99C4  b        #0x68a99d8 ; 
0068A99C8  ldr      x8, [x2, #0x60]
0068A99CC  mov      x0, x19
0068A99D0  mov      w1, w20
0068A99D4  blr      x8
0068A99D8  mov      x0, x19
0068A99DC  mov      x1, xzr
0068A99E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A99E4  adrp     x21, #0x959c000
0068A99E8  ldrb     w8, [x21, #0x57d]
0068A99EC  mov      w20, w0
0068A99F0  cbnz     w8, #0x68a9a08
0068A99F4  adrp     x0, #0x8f26000
0068A99F8  ldr      x0, [x0, #0x938]
0068A99FC  bl       #0x382bd14 ; 
0068A9A00  mov      w8, #1
0068A9A04  strb     w8, [x21, #0x57d]
0068A9A08  adrp     x8, #0x8f26000
0068A9A0C  ldr      x8, [x8, #0x938]
0068A9A10  ldr      x2, [x8]
0068A9A14  ldrb     w8, [x2, #0x53]
0068A9A18  tbnz     w8, #5, #0x68a9a24
0068A9A1C  str      w20, [x19, #0x90]
0068A9A20  b        #0x68a9a34 ; 
0068A9A24  ldr      x8, [x2, #0x60]
0068A9A28  mov      x0, x19
0068A9A2C  mov      w1, w20
0068A9A30  blr      x8
0068A9A34  mov      x0, x19
0068A9A38  mov      x1, xzr
0068A9A3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A9A40  adrp     x21, #0x959c000
0068A9A44  ldrb     w8, [x21, #0x57e]
0068A9A48  mov      w20, w0
0068A9A4C  cbnz     w8, #0x68a9a64
0068A9A50  adrp     x0, #0x8f26000
0068A9A54  ldr      x0, [x0, #0x948]
0068A9A58  bl       #0x382bd14 ; 
0068A9A5C  mov      w8, #1
0068A9A60  strb     w8, [x21, #0x57e]
0068A9A64  adrp     x8, #0x8f26000
0068A9A68  ldr      x8, [x8, #0x948]
0068A9A6C  ldr      x2, [x8]
0068A9A70  ldrb     w8, [x2, #0x53]
0068A9A74  tbnz     w8, #5, #0x68a9a80
0068A9A78  str      w20, [x19, #0x94]
0068A9A7C  b        #0x68a9a90 ; 
0068A9A80  ldr      x8, [x2, #0x60]
0068A9A84  mov      x0, x19
0068A9A88  mov      w1, w20
0068A9A8C  blr      x8
0068A9A90  mov      x0, x19
0068A9A94  mov      x1, xzr
0068A9A98  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068A9A9C  adrp     x21, #0x959c000
0068A9AA0  ldrb     w8, [x21, #0x57f]
0068A9AA4  mov      x20, x0
0068A9AA8  cbnz     w8, #0x68a9ac0
0068A9AAC  adrp     x0, #0x8f26000
0068A9AB0  ldr      x0, [x0, #0x958]
0068A9AB4  bl       #0x382bd14 ; 
0068A9AB8  mov      w8, #1
0068A9ABC  strb     w8, [x21, #0x57f]
0068A9AC0  adrp     x8, #0x8f26000
0068A9AC4  ldr      x8, [x8, #0x958]
0068A9AC8  ldr      x2, [x8]
0068A9ACC  ldrb     w8, [x2, #0x53]
0068A9AD0  tbnz     w8, #5, #0x68a9ae8
0068A9AD4  mov      x0, x19
0068A9AD8  str      x20, [x0, #0x98]!
0068A9ADC  mov      x1, x20
0068A9AE0  bl       #0x382bcb8 ; 
0068A9AE4  b        #0x68a9af8 ; 
0068A9AE8  ldr      x8, [x2, #0x60]
0068A9AEC  mov      x0, x19
0068A9AF0  mov      x1, x20
0068A9AF4  blr      x8
0068A9AF8  mov      x0, x19
0068A9AFC  mov      x1, xzr
0068A9B00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A9B04  adrp     x21, #0x959c000
0068A9B08  ldrb     w8, [x21, #0x580]
0068A9B0C  mov      w20, w0
0068A9B10  cbnz     w8, #0x68a9b28
0068A9B14  adrp     x0, #0x8f26000
0068A9B18  ldr      x0, [x0, #0x968]
0068A9B1C  bl       #0x382bd14 ; 
0068A9B20  mov      w8, #1
0068A9B24  strb     w8, [x21, #0x580]
0068A9B28  adrp     x8, #0x8f26000
0068A9B2C  ldr      x8, [x8, #0x968]
0068A9B30  ldr      x2, [x8]
0068A9B34  ldrb     w8, [x2, #0x53]
0068A9B38  tbnz     w8, #5, #0x68a9b44
0068A9B3C  str      w20, [x19, #0xa0]
0068A9B40  b        #0x68a9b54 ; 
0068A9B44  ldr      x8, [x2, #0x60]
0068A9B48  mov      x0, x19
0068A9B4C  mov      w1, w20
0068A9B50  blr      x8
0068A9B54  mov      x0, x19
0068A9B58  mov      x1, xzr
0068A9B5C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068A9B60  adrp     x21, #0x959c000
0068A9B64  ldrb     w8, [x21, #0x581]
0068A9B68  mov      x20, x0
0068A9B6C  cbnz     w8, #0x68a9b84
0068A9B70  adrp     x0, #0x8f26000
0068A9B74  ldr      x0, [x0, #0x978]
0068A9B78  bl       #0x382bd14 ; 
0068A9B7C  mov      w8, #1
0068A9B80  strb     w8, [x21, #0x581]
0068A9B84  adrp     x8, #0x8f26000
0068A9B88  ldr      x8, [x8, #0x978]
0068A9B8C  ldr      x2, [x8]
0068A9B90  ldrb     w8, [x2, #0x53]
0068A9B94  tbnz     w8, #5, #0x68a9bac
0068A9B98  mov      x0, x19
0068A9B9C  str      x20, [x0, #0xa8]!
0068A9BA0  mov      x1, x20
0068A9BA4  bl       #0x382bcb8 ; 
0068A9BA8  b        #0x68a9bbc ; 
0068A9BAC  ldr      x8, [x2, #0x60]
0068A9BB0  mov      x0, x19
0068A9BB4  mov      x1, x20
0068A9BB8  blr      x8
0068A9BBC  mov      x0, x19
0068A9BC0  mov      x1, xzr
0068A9BC4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A9BC8  adrp     x21, #0x959c000
0068A9BCC  ldrb     w8, [x21, #0x582]
0068A9BD0  mov      x20, x0
0068A9BD4  cbnz     w8, #0x68a9bec
0068A9BD8  adrp     x0, #0x8f26000
0068A9BDC  ldr      x0, [x0, #0x980]
0068A9BE0  bl       #0x382bd14 ; 
0068A9BE4  mov      w8, #1
0068A9BE8  strb     w8, [x21, #0x582]
0068A9BEC  adrp     x8, #0x8f26000
0068A9BF0  ldr      x8, [x8, #0x980]
0068A9BF4  ldr      x2, [x8]
0068A9BF8  ldrb     w8, [x2, #0x53]
0068A9BFC  tbnz     w8, #5, #0x68a9c14
0068A9C00  mov      x0, x19
0068A9C04  str      x20, [x0, #0xb0]!
0068A9C08  mov      x1, x20
0068A9C0C  bl       #0x382bcb8 ; 
0068A9C10  b        #0x68a9c24 ; 
0068A9C14  ldr      x8, [x2, #0x60]
0068A9C18  mov      x0, x19
0068A9C1C  mov      x1, x20
0068A9C20  blr      x8
0068A9C24  mov      x0, x19
0068A9C28  mov      x1, xzr
0068A9C2C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A9C30  adrp     x21, #0x959c000
0068A9C34  ldrb     w8, [x21, #0x583]
0068A9C38  mov      x20, x0
0068A9C3C  cbnz     w8, #0x68a9c54
0068A9C40  adrp     x0, #0x8f26000
0068A9C44  ldr      x0, [x0, #0x988]
0068A9C48  bl       #0x382bd14 ; 
0068A9C4C  mov      w8, #1
0068A9C50  strb     w8, [x21, #0x583]
0068A9C54  adrp     x8, #0x8f26000
0068A9C58  ldr      x8, [x8, #0x988]
0068A9C5C  ldr      x2, [x8]
0068A9C60  ldrb     w8, [x2, #0x53]
0068A9C64  tbnz     w8, #5, #0x68a9c7c
0068A9C68  mov      x0, x19
0068A9C6C  str      x20, [x0, #0xb8]!
0068A9C70  mov      x1, x20
0068A9C74  bl       #0x382bcb8 ; 
0068A9C78  b        #0x68a9c8c ; 
0068A9C7C  ldr      x8, [x2, #0x60]
0068A9C80  mov      x0, x19
0068A9C84  mov      x1, x20
0068A9C88  blr      x8
0068A9C8C  mov      x0, x19
0068A9C90  mov      x1, xzr
0068A9C94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A9C98  adrp     x21, #0x959c000
0068A9C9C  ldrb     w8, [x21, #0x584]
0068A9CA0  mov      w20, w0
0068A9CA4  cbnz     w8, #0x68a9cbc
0068A9CA8  adrp     x0, #0x8f26000
0068A9CAC  ldr      x0, [x0, #0x998]
0068A9CB0  bl       #0x382bd14 ; 
0068A9CB4  mov      w8, #1
0068A9CB8  strb     w8, [x21, #0x584]
0068A9CBC  adrp     x8, #0x8f26000
0068A9CC0  ldr      x8, [x8, #0x998]
0068A9CC4  ldr      x2, [x8]
0068A9CC8  ldrb     w8, [x2, #0x53]
0068A9CCC  tbnz     w8, #5, #0x68a9cd8
0068A9CD0  str      w20, [x19, #0xc0]
0068A9CD4  b        #0x68a9ce8 ; 
0068A9CD8  ldr      x8, [x2, #0x60]
0068A9CDC  mov      x0, x19
0068A9CE0  mov      w1, w20
0068A9CE4  blr      x8
0068A9CE8  mov      x0, x19
0068A9CEC  mov      x1, xzr
0068A9CF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A9CF4  adrp     x21, #0x959c000
0068A9CF8  ldrb     w8, [x21, #0x585]
0068A9CFC  mov      w20, w0
0068A9D00  cbnz     w8, #0x68a9d18
0068A9D04  adrp     x0, #0x8f26000
0068A9D08  ldr      x0, [x0, #0x9a8]
0068A9D0C  bl       #0x382bd14 ; 
0068A9D10  mov      w8, #1
0068A9D14  strb     w8, [x21, #0x585]
0068A9D18  adrp     x8, #0x8f26000
0068A9D1C  ldr      x8, [x8, #0x9a8]
0068A9D20  ldr      x2, [x8]
0068A9D24  ldrb     w8, [x2, #0x53]
0068A9D28  tbnz     w8, #5, #0x68a9d34
0068A9D2C  str      w20, [x19, #0xc4]
0068A9D30  b        #0x68a9d44 ; 
0068A9D34  ldr      x8, [x2, #0x60]
0068A9D38  mov      x0, x19
0068A9D3C  mov      w1, w20
0068A9D40  blr      x8
0068A9D44  mov      x0, x19
0068A9D48  mov      x1, xzr
0068A9D4C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068A9D50  adrp     x21, #0x959c000
0068A9D54  ldrb     w8, [x21, #0x586]
0068A9D58  mov      x20, x0
0068A9D5C  cbnz     w8, #0x68a9d74
0068A9D60  adrp     x0, #0x8f26000
0068A9D64  ldr      x0, [x0, #0x9b8]
0068A9D68  bl       #0x382bd14 ; 
0068A9D6C  mov      w8, #1
0068A9D70  strb     w8, [x21, #0x586]
0068A9D74  adrp     x8, #0x8f26000
0068A9D78  ldr      x8, [x8, #0x9b8]
0068A9D7C  ldr      x2, [x8]
0068A9D80  ldrb     w8, [x2, #0x53]
0068A9D84  tbnz     w8, #5, #0x68a9d9c
0068A9D88  mov      x0, x19
0068A9D8C  str      x20, [x0, #0xc8]!
0068A9D90  mov      x1, x20
0068A9D94  bl       #0x382bcb8 ; 
0068A9D98  b        #0x68a9dac ; 
0068A9D9C  ldr      x8, [x2, #0x60]
0068A9DA0  mov      x0, x19
0068A9DA4  mov      x1, x20
0068A9DA8  blr      x8
0068A9DAC  mov      x0, x19
0068A9DB0  mov      x1, xzr
0068A9DB4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A9DB8  adrp     x21, #0x959c000
0068A9DBC  ldrb     w8, [x21, #0x587]
0068A9DC0  mov      x20, x0
0068A9DC4  cbnz     w8, #0x68a9ddc
0068A9DC8  adrp     x0, #0x8f26000
0068A9DCC  ldr      x0, [x0, #0x9c8]
0068A9DD0  bl       #0x382bd14 ; 
0068A9DD4  mov      w8, #1
0068A9DD8  strb     w8, [x21, #0x587]
0068A9DDC  adrp     x8, #0x8f26000
0068A9DE0  ldr      x8, [x8, #0x9c8]
0068A9DE4  ldr      x2, [x8]
0068A9DE8  ldrb     w8, [x2, #0x53]
0068A9DEC  tbnz     w8, #5, #0x68a9e04
0068A9DF0  mov      x0, x19
0068A9DF4  str      x20, [x0, #0xd0]!
0068A9DF8  mov      x1, x20
0068A9DFC  bl       #0x382bcb8 ; 
0068A9E00  b        #0x68a9e14 ; 
0068A9E04  ldr      x8, [x2, #0x60]
0068A9E08  mov      x0, x19
0068A9E0C  mov      x1, x20
0068A9E10  blr      x8
0068A9E14  mov      x0, x19
0068A9E18  mov      x1, xzr
0068A9E1C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A9E20  adrp     x21, #0x959c000
0068A9E24  ldrb     w8, [x21, #0x588]
0068A9E28  mov      x20, x0
0068A9E2C  cbnz     w8, #0x68a9e44
0068A9E30  adrp     x0, #0x8f26000
0068A9E34  ldr      x0, [x0, #0x9d8]
0068A9E38  bl       #0x382bd14 ; 
0068A9E3C  mov      w8, #1
0068A9E40  strb     w8, [x21, #0x588]
0068A9E44  adrp     x8, #0x8f26000
0068A9E48  ldr      x8, [x8, #0x9d8]
0068A9E4C  ldr      x2, [x8]
0068A9E50  ldrb     w8, [x2, #0x53]
0068A9E54  tbnz     w8, #5, #0x68a9e6c
0068A9E58  mov      x0, x19
0068A9E5C  str      x20, [x0, #0xd8]!
0068A9E60  mov      x1, x20
0068A9E64  bl       #0x382bcb8 ; 
0068A9E68  b        #0x68a9e7c ; 
0068A9E6C  ldr      x8, [x2, #0x60]
0068A9E70  mov      x0, x19
0068A9E74  mov      x1, x20
0068A9E78  blr      x8
0068A9E7C  mov      x0, x19
0068A9E80  mov      x1, xzr
0068A9E84  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A9E88  adrp     x21, #0x959c000
0068A9E8C  ldrb     w8, [x21, #0x589]
0068A9E90  mov      x20, x0
0068A9E94  cbnz     w8, #0x68a9eac
0068A9E98  adrp     x0, #0x8f26000
0068A9E9C  ldr      x0, [x0, #0x9e8]
0068A9EA0  bl       #0x382bd14 ; 
0068A9EA4  mov      w8, #1
0068A9EA8  strb     w8, [x21, #0x589]
0068A9EAC  adrp     x8, #0x8f26000
0068A9EB0  ldr      x8, [x8, #0x9e8]
0068A9EB4  ldr      x2, [x8]
0068A9EB8  ldrb     w8, [x2, #0x53]
0068A9EBC  tbnz     w8, #5, #0x68a9ed4
0068A9EC0  mov      x0, x19
0068A9EC4  str      x20, [x0, #0xe0]!
0068A9EC8  mov      x1, x20
0068A9ECC  bl       #0x382bcb8 ; 
0068A9ED0  b        #0x68a9ee4 ; 
0068A9ED4  ldr      x8, [x2, #0x60]
0068A9ED8  mov      x0, x19
0068A9EDC  mov      x1, x20
0068A9EE0  blr      x8
0068A9EE4  mov      x0, x19
0068A9EE8  mov      x1, xzr
0068A9EEC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A9EF0  adrp     x21, #0x959c000
0068A9EF4  ldrb     w8, [x21, #0x58a]
0068A9EF8  mov      x20, x0
0068A9EFC  cbnz     w8, #0x68a9f14
0068A9F00  adrp     x0, #0x8f26000
0068A9F04  ldr      x0, [x0, #0x9f8]
0068A9F08  bl       #0x382bd14 ; 
0068A9F0C  mov      w8, #1
0068A9F10  strb     w8, [x21, #0x58a]
0068A9F14  adrp     x8, #0x8f26000
0068A9F18  ldr      x8, [x8, #0x9f8]
0068A9F1C  ldr      x2, [x8]
0068A9F20  ldrb     w8, [x2, #0x53]
0068A9F24  tbnz     w8, #5, #0x68a9f3c
0068A9F28  mov      x0, x19
0068A9F2C  str      x20, [x0, #0xe8]!
0068A9F30  mov      x1, x20
0068A9F34  bl       #0x382bcb8 ; 
0068A9F38  b        #0x68a9f4c ; 
0068A9F3C  ldr      x8, [x2, #0x60]
0068A9F40  mov      x0, x19
0068A9F44  mov      x1, x20
0068A9F48  blr      x8
0068A9F4C  mov      x0, x19
0068A9F50  mov      x1, xzr
0068A9F54  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068A9F58  adrp     x20, #0x959c000
0068A9F5C  ldrb     w8, [x20, #0x58b]
0068A9F60  mov      v8.16b, v0.16b
0068A9F64  cbnz     w8, #0x68a9f7c
0068A9F68  adrp     x0, #0x8f26000
0068A9F6C  ldr      x0, [x0, #0xa08]
0068A9F70  bl       #0x382bd14 ; 
0068A9F74  mov      w8, #1
0068A9F78  strb     w8, [x20, #0x58b]
0068A9F7C  adrp     x8, #0x8f26000
0068A9F80  ldr      x8, [x8, #0xa08]
0068A9F84  ldr      x1, [x8]
0068A9F88  ldrb     w8, [x1, #0x53]
0068A9F8C  tbnz     w8, #5, #0x68a9f98
0068A9F90  str      s8, [x19, #0xf0]
0068A9F94  b        #0x68a9fa8 ; 
0068A9F98  ldr      x8, [x1, #0x60]
0068A9F9C  mov      x0, x19
0068A9FA0  mov      v0.16b, v8.16b
0068A9FA4  blr      x8
0068A9FA8  mov      x0, x19
0068A9FAC  mov      x1, xzr
0068A9FB0  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068A9FB4  adrp     x20, #0x959c000
0068A9FB8  ldrb     w8, [x20, #0x58c]
0068A9FBC  mov      v8.16b, v0.16b
0068A9FC0  cbnz     w8, #0x68a9fd8
0068A9FC4  adrp     x0, #0x8f26000
0068A9FC8  ldr      x0, [x0, #0xa18]
0068A9FCC  bl       #0x382bd14 ; 
0068A9FD0  mov      w8, #1
0068A9FD4  strb     w8, [x20, #0x58c]
0068A9FD8  adrp     x8, #0x8f26000
0068A9FDC  ldr      x8, [x8, #0xa18]
0068A9FE0  ldr      x1, [x8]
0068A9FE4  ldrb     w8, [x1, #0x53]
0068A9FE8  tbnz     w8, #5, #0x68a9ff4
0068A9FEC  str      s8, [x19, #0xf4]
0068A9FF0  b        #0x68aa004 ; 
0068A9FF4  ldr      x8, [x1, #0x60]
0068A9FF8  mov      x0, x19
0068A9FFC  mov      v0.16b, v8.16b
0068AA000  blr      x8
0068AA004  mov      x0, x19
0068AA008  mov      x1, xzr
0068AA00C  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068AA010  adrp     x20, #0x959c000
0068AA014  ldrb     w8, [x20, #0x58d]
0068AA018  mov      v8.16b, v0.16b
0068AA01C  cbnz     w8, #0x68aa034
0068AA020  adrp     x0, #0x8f26000
0068AA024  ldr      x0, [x0, #0xa28]
0068AA028  bl       #0x382bd14 ; 
0068AA02C  mov      w8, #1
0068AA030  strb     w8, [x20, #0x58d]
0068AA034  adrp     x8, #0x8f26000
0068AA038  ldr      x8, [x8, #0xa28]
0068AA03C  ldr      x1, [x8]
0068AA040  ldrb     w8, [x1, #0x53]
0068AA044  tbnz     w8, #5, #0x68aa050
0068AA048  str      s8, [x19, #0xf8]
0068AA04C  b        #0x68aa060 ; 
0068AA050  ldr      x8, [x1, #0x60]
0068AA054  mov      x0, x19
0068AA058  mov      v0.16b, v8.16b
0068AA05C  blr      x8
0068AA060  mov      x0, x19
0068AA064  mov      x1, xzr
0068AA068  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AA06C  adrp     x21, #0x959c000
0068AA070  ldrb     w8, [x21, #0x58e]
0068AA074  mov      w20, w0
0068AA078  cbnz     w8, #0x68aa090
0068AA07C  adrp     x0, #0x8f26000
0068AA080  ldr      x0, [x0, #0xa38]
0068AA084  bl       #0x382bd14 ; 
0068AA088  mov      w8, #1
0068AA08C  strb     w8, [x21, #0x58e]
0068AA090  adrp     x8, #0x8f26000
0068AA094  ldr      x8, [x8, #0xa38]
0068AA098  ldr      x2, [x8]
0068AA09C  ldrb     w8, [x2, #0x53]
0068AA0A0  tbnz     w8, #5, #0x68aa0ac
0068AA0A4  str      w20, [x19, #0xfc]
0068AA0A8  b        #0x68aa0bc ; 
0068AA0AC  ldr      x8, [x2, #0x60]
0068AA0B0  mov      x0, x19
0068AA0B4  mov      w1, w20
0068AA0B8  blr      x8
0068AA0BC  ldp      x20, x19, [sp, #0x20]
0068AA0C0  ldp      x30, x21, [sp, #0x10]
0068AA0C4  mov      w0, #1
0068AA0C8  ldr      d8, [sp], #0x30
0068AA0CC  ret      

