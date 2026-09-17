; LocalModels.Bean.Guide_Guide$$readImpl
; RVA 0x6A82774; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A82774  stp      x30, x21, [sp, #-0x20]!
006A82778  stp      x20, x19, [sp, #0x10]
006A8277C  adrp     x20, #0x959d000
006A82780  adrp     x21, #0x8f38000
006A82784  ldrb     w8, [x20, #0xf7f]
006A82788  ldr      x21, [x21, #0x3d0]
006A8278C  mov      x19, x0
006A82790  tbnz     w8, #0, #0x6a827a8
006A82794  adrp     x0, #0x8f38000
006A82798  ldr      x0, [x0, #0x3d0]
006A8279C  bl       #0x382bd14 ; 
006A827A0  mov      w8, #1
006A827A4  strb     w8, [x20, #0xf7f]
006A827A8  ldr      x1, [x21]
006A827AC  ldrb     w8, [x1, #0x53]
006A827B0  tbnz     w8, #5, #0x6a82800
006A827B4  mov      x0, x19
006A827B8  mov      x1, xzr
006A827BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A827C0  adrp     x21, #0x959e000
006A827C4  ldrb     w8, [x21, #0x512]
006A827C8  mov      w20, w0
006A827CC  cbnz     w8, #0x6a827e4
006A827D0  adrp     x0, #0x8f38000
006A827D4  ldr      x0, [x0, #0x318]
006A827D8  bl       #0x382bd14 ; 
006A827DC  mov      w8, #1
006A827E0  strb     w8, [x21, #0x512]
006A827E4  adrp     x8, #0x8f38000
006A827E8  ldr      x8, [x8, #0x318]
006A827EC  ldr      x2, [x8]
006A827F0  ldrb     w8, [x2, #0x53]
006A827F4  tbnz     w8, #5, #0x6a82814
006A827F8  str      w20, [x19, #0x20]
006A827FC  b        #0x6a82824 ; 
006A82800  ldr      x2, [x1, #0x60]
006A82804  mov      x0, x19
006A82808  ldp      x20, x19, [sp, #0x10]
006A8280C  ldp      x30, x21, [sp], #0x20
006A82810  br       x2
006A82814  ldr      x8, [x2, #0x60]
006A82818  mov      x0, x19
006A8281C  mov      w1, w20
006A82820  blr      x8
006A82824  mov      x0, x19
006A82828  mov      x1, xzr
006A8282C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A82830  adrp     x21, #0x959e000
006A82834  ldrb     w8, [x21, #0x513]
006A82838  mov      w20, w0
006A8283C  cbnz     w8, #0x6a82854
006A82840  adrp     x0, #0x8f38000
006A82844  ldr      x0, [x0, #0x328]
006A82848  bl       #0x382bd14 ; 
006A8284C  mov      w8, #1
006A82850  strb     w8, [x21, #0x513]
006A82854  adrp     x8, #0x8f38000
006A82858  ldr      x8, [x8, #0x328]
006A8285C  ldr      x2, [x8]
006A82860  ldrb     w8, [x2, #0x53]
006A82864  tbnz     w8, #5, #0x6a82870
006A82868  str      w20, [x19, #0x24]
006A8286C  b        #0x6a82880 ; 
006A82870  ldr      x8, [x2, #0x60]
006A82874  mov      x0, x19
006A82878  mov      w1, w20
006A8287C  blr      x8
006A82880  mov      x0, x19
006A82884  mov      x1, xzr
006A82888  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8288C  adrp     x21, #0x959e000
006A82890  ldrb     w8, [x21, #0x514]
006A82894  mov      w20, w0
006A82898  cbnz     w8, #0x6a828b0
006A8289C  adrp     x0, #0x8f38000
006A828A0  ldr      x0, [x0, #0x338]
006A828A4  bl       #0x382bd14 ; 
006A828A8  mov      w8, #1
006A828AC  strb     w8, [x21, #0x514]
006A828B0  adrp     x8, #0x8f38000
006A828B4  ldr      x8, [x8, #0x338]
006A828B8  ldr      x2, [x8]
006A828BC  ldrb     w8, [x2, #0x53]
006A828C0  tbnz     w8, #5, #0x6a828cc
006A828C4  str      w20, [x19, #0x28]
006A828C8  b        #0x6a828dc ; 
006A828CC  ldr      x8, [x2, #0x60]
006A828D0  mov      x0, x19
006A828D4  mov      w1, w20
006A828D8  blr      x8
006A828DC  mov      x0, x19
006A828E0  mov      x1, xzr
006A828E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A828E8  adrp     x21, #0x959e000
006A828EC  ldrb     w8, [x21, #0x515]
006A828F0  mov      w20, w0
006A828F4  cbnz     w8, #0x6a8290c
006A828F8  adrp     x0, #0x8f38000
006A828FC  ldr      x0, [x0, #0x348]
006A82900  bl       #0x382bd14 ; 
006A82904  mov      w8, #1
006A82908  strb     w8, [x21, #0x515]
006A8290C  adrp     x8, #0x8f38000
006A82910  ldr      x8, [x8, #0x348]
006A82914  ldr      x2, [x8]
006A82918  ldrb     w8, [x2, #0x53]
006A8291C  tbnz     w8, #5, #0x6a82928
006A82920  str      w20, [x19, #0x2c]
006A82924  b        #0x6a82938 ; 
006A82928  ldr      x8, [x2, #0x60]
006A8292C  mov      x0, x19
006A82930  mov      w1, w20
006A82934  blr      x8
006A82938  mov      x0, x19
006A8293C  mov      x1, xzr
006A82940  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A82944  adrp     x21, #0x959e000
006A82948  ldrb     w8, [x21, #0x516]
006A8294C  mov      w20, w0
006A82950  cbnz     w8, #0x6a82968
006A82954  adrp     x0, #0x8f38000
006A82958  ldr      x0, [x0, #0x358]
006A8295C  bl       #0x382bd14 ; 
006A82960  mov      w8, #1
006A82964  strb     w8, [x21, #0x516]
006A82968  adrp     x8, #0x8f38000
006A8296C  ldr      x8, [x8, #0x358]
006A82970  ldr      x2, [x8]
006A82974  ldrb     w8, [x2, #0x53]
006A82978  tbnz     w8, #5, #0x6a82984
006A8297C  str      w20, [x19, #0x30]
006A82980  b        #0x6a82994 ; 
006A82984  ldr      x8, [x2, #0x60]
006A82988  mov      x0, x19
006A8298C  mov      w1, w20
006A82990  blr      x8
006A82994  mov      x0, x19
006A82998  mov      x1, xzr
006A8299C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A829A0  adrp     x21, #0x959e000
006A829A4  ldrb     w8, [x21, #0x517]
006A829A8  mov      x20, x0
006A829AC  cbnz     w8, #0x6a829c4
006A829B0  adrp     x0, #0x8f38000
006A829B4  ldr      x0, [x0, #0x368]
006A829B8  bl       #0x382bd14 ; 
006A829BC  mov      w8, #1
006A829C0  strb     w8, [x21, #0x517]
006A829C4  adrp     x8, #0x8f38000
006A829C8  ldr      x8, [x8, #0x368]
006A829CC  ldr      x2, [x8]
006A829D0  ldrb     w8, [x2, #0x53]
006A829D4  tbnz     w8, #5, #0x6a829ec
006A829D8  mov      x0, x19
006A829DC  str      x20, [x0, #0x38]!
006A829E0  mov      x1, x20
006A829E4  bl       #0x382bcb8 ; 
006A829E8  b        #0x6a829fc ; 
006A829EC  ldr      x8, [x2, #0x60]
006A829F0  mov      x0, x19
006A829F4  mov      x1, x20
006A829F8  blr      x8
006A829FC  mov      x0, x19
006A82A00  mov      x1, xzr
006A82A04  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A82A08  adrp     x21, #0x959e000
006A82A0C  ldrb     w8, [x21, #0x518]
006A82A10  mov      x20, x0
006A82A14  cbnz     w8, #0x6a82a2c
006A82A18  adrp     x0, #0x8f38000
006A82A1C  ldr      x0, [x0, #0x378]
006A82A20  bl       #0x382bd14 ; 
006A82A24  mov      w8, #1
006A82A28  strb     w8, [x21, #0x518]
006A82A2C  adrp     x8, #0x8f38000
006A82A30  ldr      x8, [x8, #0x378]
006A82A34  ldr      x2, [x8]
006A82A38  ldrb     w8, [x2, #0x53]
006A82A3C  tbnz     w8, #5, #0x6a82a54
006A82A40  mov      x0, x19
006A82A44  str      x20, [x0, #0x40]!
006A82A48  mov      x1, x20
006A82A4C  bl       #0x382bcb8 ; 
006A82A50  b        #0x6a82a64 ; 
006A82A54  ldr      x8, [x2, #0x60]
006A82A58  mov      x0, x19
006A82A5C  mov      x1, x20
006A82A60  blr      x8
006A82A64  mov      x0, x19
006A82A68  mov      x1, xzr
006A82A6C  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
006A82A70  adrp     x21, #0x959e000
006A82A74  ldrb     w8, [x21, #0x519]
006A82A78  mov      x20, x0
006A82A7C  cbnz     w8, #0x6a82a94
006A82A80  adrp     x0, #0x8f38000
006A82A84  ldr      x0, [x0, #0x388]
006A82A88  bl       #0x382bd14 ; 
006A82A8C  mov      w8, #1
006A82A90  strb     w8, [x21, #0x519]
006A82A94  adrp     x8, #0x8f38000
006A82A98  ldr      x8, [x8, #0x388]
006A82A9C  ldr      x2, [x8]
006A82AA0  ldrb     w8, [x2, #0x53]
006A82AA4  tbnz     w8, #5, #0x6a82abc
006A82AA8  mov      x0, x19
006A82AAC  str      x20, [x0, #0x48]!
006A82AB0  mov      x1, x20
006A82AB4  bl       #0x382bcb8 ; 
006A82AB8  b        #0x6a82acc ; 
006A82ABC  ldr      x8, [x2, #0x60]
006A82AC0  mov      x0, x19
006A82AC4  mov      x1, x20
006A82AC8  blr      x8
006A82ACC  mov      x0, x19
006A82AD0  mov      x1, xzr
006A82AD4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A82AD8  adrp     x21, #0x959e000
006A82ADC  ldrb     w8, [x21, #0x51a]
006A82AE0  mov      x20, x0
006A82AE4  cbnz     w8, #0x6a82afc
006A82AE8  adrp     x0, #0x8f38000
006A82AEC  ldr      x0, [x0, #0x398]
006A82AF0  bl       #0x382bd14 ; 
006A82AF4  mov      w8, #1
006A82AF8  strb     w8, [x21, #0x51a]
006A82AFC  adrp     x8, #0x8f38000
006A82B00  ldr      x8, [x8, #0x398]
006A82B04  ldr      x2, [x8]
006A82B08  ldrb     w8, [x2, #0x53]
006A82B0C  tbnz     w8, #5, #0x6a82b24
006A82B10  mov      x0, x19
006A82B14  str      x20, [x0, #0x50]!
006A82B18  mov      x1, x20
006A82B1C  bl       #0x382bcb8 ; 
006A82B20  b        #0x6a82b34 ; 
006A82B24  ldr      x8, [x2, #0x60]
006A82B28  mov      x0, x19
006A82B2C  mov      x1, x20
006A82B30  blr      x8
006A82B34  mov      x0, x19
006A82B38  mov      x1, xzr
006A82B3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A82B40  adrp     x21, #0x959e000
006A82B44  ldrb     w8, [x21, #0x51b]
006A82B48  mov      w20, w0
006A82B4C  cbnz     w8, #0x6a82b64
006A82B50  adrp     x0, #0x8f38000
006A82B54  ldr      x0, [x0, #0x3a8]
006A82B58  bl       #0x382bd14 ; 
006A82B5C  mov      w8, #1
006A82B60  strb     w8, [x21, #0x51b]
006A82B64  adrp     x8, #0x8f38000
006A82B68  ldr      x8, [x8, #0x3a8]
006A82B6C  ldr      x2, [x8]
006A82B70  ldrb     w8, [x2, #0x53]
006A82B74  tbnz     w8, #5, #0x6a82b80
006A82B78  str      w20, [x19, #0x58]
006A82B7C  b        #0x6a82b90 ; 
006A82B80  ldr      x8, [x2, #0x60]
006A82B84  mov      x0, x19
006A82B88  mov      w1, w20
006A82B8C  blr      x8
006A82B90  mov      x0, x19
006A82B94  mov      x1, xzr
006A82B98  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A82B9C  adrp     x21, #0x959e000
006A82BA0  ldrb     w8, [x21, #0x51c]
006A82BA4  mov      x20, x0
006A82BA8  cbnz     w8, #0x6a82bc0
006A82BAC  adrp     x0, #0x8f38000
006A82BB0  ldr      x0, [x0, #0x3b8]
006A82BB4  bl       #0x382bd14 ; 
006A82BB8  mov      w8, #1
006A82BBC  strb     w8, [x21, #0x51c]
006A82BC0  adrp     x8, #0x8f38000
006A82BC4  ldr      x8, [x8, #0x3b8]
006A82BC8  ldr      x2, [x8]
006A82BCC  ldrb     w8, [x2, #0x53]
006A82BD0  tbnz     w8, #5, #0x6a82be8
006A82BD4  mov      x0, x19
006A82BD8  str      x20, [x0, #0x60]!
006A82BDC  mov      x1, x20
006A82BE0  bl       #0x382bcb8 ; 
006A82BE4  b        #0x6a82bf8 ; 
006A82BE8  ldr      x8, [x2, #0x60]
006A82BEC  mov      x0, x19
006A82BF0  mov      x1, x20
006A82BF4  blr      x8
006A82BF8  mov      x0, x19
006A82BFC  mov      x1, xzr
006A82C00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A82C04  adrp     x21, #0x959e000
006A82C08  ldrb     w8, [x21, #0x51d]
006A82C0C  mov      w20, w0
006A82C10  cbnz     w8, #0x6a82c28
006A82C14  adrp     x0, #0x8f38000
006A82C18  ldr      x0, [x0, #0x3c8]
006A82C1C  bl       #0x382bd14 ; 
006A82C20  mov      w8, #1
006A82C24  strb     w8, [x21, #0x51d]
006A82C28  adrp     x8, #0x8f38000
006A82C2C  ldr      x8, [x8, #0x3c8]
006A82C30  ldr      x2, [x8]
006A82C34  ldrb     w8, [x2, #0x53]
006A82C38  tbnz     w8, #5, #0x6a82c44
006A82C3C  str      w20, [x19, #0x68]
006A82C40  b        #0x6a82c54 ; 
006A82C44  ldr      x8, [x2, #0x60]
006A82C48  mov      x0, x19
006A82C4C  mov      w1, w20
006A82C50  blr      x8
006A82C54  ldp      x20, x19, [sp, #0x10]
006A82C58  mov      w0, #1
006A82C5C  ldp      x30, x21, [sp], #0x20
006A82C60  ret      

