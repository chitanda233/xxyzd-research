; LocalModels.Bean.Relic_Relic$$readImpl
; RVA 0x6AD9764; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD9764  stp      x30, x21, [sp, #-0x20]!
006AD9768  stp      x20, x19, [sp, #0x10]
006AD976C  adrp     x20, #0x959e000
006AD9770  adrp     x21, #0x8f3c000
006AD9774  ldrb     w8, [x20, #0xc07]
006AD9778  ldr      x21, [x21, #0x508]
006AD977C  mov      x19, x0
006AD9780  tbnz     w8, #0, #0x6ad9798
006AD9784  adrp     x0, #0x8f3c000
006AD9788  ldr      x0, [x0, #0x508]
006AD978C  bl       #0x382bd14 ; 
006AD9790  mov      w8, #1
006AD9794  strb     w8, [x20, #0xc07]
006AD9798  ldr      x1, [x21]
006AD979C  ldrb     w8, [x1, #0x53]
006AD97A0  tbnz     w8, #5, #0x6ad97f0
006AD97A4  mov      x0, x19
006AD97A8  mov      x1, xzr
006AD97AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD97B0  adrp     x21, #0x959f000
006AD97B4  ldrb     w8, [x21, #0x13e]
006AD97B8  mov      w20, w0
006AD97BC  cbnz     w8, #0x6ad97d4
006AD97C0  adrp     x0, #0x8f3c000
006AD97C4  ldr      x0, [x0, #0x458]
006AD97C8  bl       #0x382bd14 ; 
006AD97CC  mov      w8, #1
006AD97D0  strb     w8, [x21, #0x13e]
006AD97D4  adrp     x8, #0x8f3c000
006AD97D8  ldr      x8, [x8, #0x458]
006AD97DC  ldr      x2, [x8]
006AD97E0  ldrb     w8, [x2, #0x53]
006AD97E4  tbnz     w8, #5, #0x6ad9804
006AD97E8  str      w20, [x19, #0x20]
006AD97EC  b        #0x6ad9814 ; 
006AD97F0  ldr      x2, [x1, #0x60]
006AD97F4  mov      x0, x19
006AD97F8  ldp      x20, x19, [sp, #0x10]
006AD97FC  ldp      x30, x21, [sp], #0x20
006AD9800  br       x2
006AD9804  ldr      x8, [x2, #0x60]
006AD9808  mov      x0, x19
006AD980C  mov      w1, w20
006AD9810  blr      x8
006AD9814  mov      x0, x19
006AD9818  mov      x1, xzr
006AD981C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD9820  adrp     x21, #0x959f000
006AD9824  ldrb     w8, [x21, #0x13f]
006AD9828  mov      w20, w0
006AD982C  cbnz     w8, #0x6ad9844
006AD9830  adrp     x0, #0x8f3c000
006AD9834  ldr      x0, [x0, #0x468]
006AD9838  bl       #0x382bd14 ; 
006AD983C  mov      w8, #1
006AD9840  strb     w8, [x21, #0x13f]
006AD9844  adrp     x8, #0x8f3c000
006AD9848  ldr      x8, [x8, #0x468]
006AD984C  ldr      x2, [x8]
006AD9850  ldrb     w8, [x2, #0x53]
006AD9854  tbnz     w8, #5, #0x6ad9860
006AD9858  str      w20, [x19, #0x24]
006AD985C  b        #0x6ad9870 ; 
006AD9860  ldr      x8, [x2, #0x60]
006AD9864  mov      x0, x19
006AD9868  mov      w1, w20
006AD986C  blr      x8
006AD9870  mov      x0, x19
006AD9874  mov      x1, xzr
006AD9878  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD987C  adrp     x21, #0x959f000
006AD9880  ldrb     w8, [x21, #0x140]
006AD9884  mov      w20, w0
006AD9888  cbnz     w8, #0x6ad98a0
006AD988C  adrp     x0, #0x8f3c000
006AD9890  ldr      x0, [x0, #0x478]
006AD9894  bl       #0x382bd14 ; 
006AD9898  mov      w8, #1
006AD989C  strb     w8, [x21, #0x140]
006AD98A0  adrp     x8, #0x8f3c000
006AD98A4  ldr      x8, [x8, #0x478]
006AD98A8  ldr      x2, [x8]
006AD98AC  ldrb     w8, [x2, #0x53]
006AD98B0  tbnz     w8, #5, #0x6ad98bc
006AD98B4  str      w20, [x19, #0x28]
006AD98B8  b        #0x6ad98cc ; 
006AD98BC  ldr      x8, [x2, #0x60]
006AD98C0  mov      x0, x19
006AD98C4  mov      w1, w20
006AD98C8  blr      x8
006AD98CC  mov      x0, x19
006AD98D0  mov      x1, xzr
006AD98D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD98D8  adrp     x21, #0x959f000
006AD98DC  ldrb     w8, [x21, #0x141]
006AD98E0  mov      w20, w0
006AD98E4  cbnz     w8, #0x6ad98fc
006AD98E8  adrp     x0, #0x8f3c000
006AD98EC  ldr      x0, [x0, #0x488]
006AD98F0  bl       #0x382bd14 ; 
006AD98F4  mov      w8, #1
006AD98F8  strb     w8, [x21, #0x141]
006AD98FC  adrp     x8, #0x8f3c000
006AD9900  ldr      x8, [x8, #0x488]
006AD9904  ldr      x2, [x8]
006AD9908  ldrb     w8, [x2, #0x53]
006AD990C  tbnz     w8, #5, #0x6ad9918
006AD9910  str      w20, [x19, #0x2c]
006AD9914  b        #0x6ad9928 ; 
006AD9918  ldr      x8, [x2, #0x60]
006AD991C  mov      x0, x19
006AD9920  mov      w1, w20
006AD9924  blr      x8
006AD9928  mov      x0, x19
006AD992C  mov      x1, xzr
006AD9930  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD9934  adrp     x21, #0x959f000
006AD9938  ldrb     w8, [x21, #0x142]
006AD993C  mov      w20, w0
006AD9940  cbnz     w8, #0x6ad9958
006AD9944  adrp     x0, #0x8f3c000
006AD9948  ldr      x0, [x0, #0x498]
006AD994C  bl       #0x382bd14 ; 
006AD9950  mov      w8, #1
006AD9954  strb     w8, [x21, #0x142]
006AD9958  adrp     x8, #0x8f3c000
006AD995C  ldr      x8, [x8, #0x498]
006AD9960  ldr      x2, [x8]
006AD9964  ldrb     w8, [x2, #0x53]
006AD9968  tbnz     w8, #5, #0x6ad9974
006AD996C  str      w20, [x19, #0x30]
006AD9970  b        #0x6ad9984 ; 
006AD9974  ldr      x8, [x2, #0x60]
006AD9978  mov      x0, x19
006AD997C  mov      w1, w20
006AD9980  blr      x8
006AD9984  mov      x0, x19
006AD9988  mov      x1, xzr
006AD998C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD9990  adrp     x21, #0x959f000
006AD9994  ldrb     w8, [x21, #0x143]
006AD9998  mov      w20, w0
006AD999C  cbnz     w8, #0x6ad99b4
006AD99A0  adrp     x0, #0x8f3c000
006AD99A4  ldr      x0, [x0, #0x4a8]
006AD99A8  bl       #0x382bd14 ; 
006AD99AC  mov      w8, #1
006AD99B0  strb     w8, [x21, #0x143]
006AD99B4  adrp     x8, #0x8f3c000
006AD99B8  ldr      x8, [x8, #0x4a8]
006AD99BC  ldr      x2, [x8]
006AD99C0  ldrb     w8, [x2, #0x53]
006AD99C4  tbnz     w8, #5, #0x6ad99d0
006AD99C8  str      w20, [x19, #0x34]
006AD99CC  b        #0x6ad99e0 ; 
006AD99D0  ldr      x8, [x2, #0x60]
006AD99D4  mov      x0, x19
006AD99D8  mov      w1, w20
006AD99DC  blr      x8
006AD99E0  mov      x0, x19
006AD99E4  mov      x1, xzr
006AD99E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD99EC  adrp     x21, #0x959f000
006AD99F0  ldrb     w8, [x21, #0x144]
006AD99F4  mov      x20, x0
006AD99F8  cbnz     w8, #0x6ad9a10
006AD99FC  adrp     x0, #0x8f3c000
006AD9A00  ldr      x0, [x0, #0x4b8]
006AD9A04  bl       #0x382bd14 ; 
006AD9A08  mov      w8, #1
006AD9A0C  strb     w8, [x21, #0x144]
006AD9A10  adrp     x8, #0x8f3c000
006AD9A14  ldr      x8, [x8, #0x4b8]
006AD9A18  ldr      x2, [x8]
006AD9A1C  ldrb     w8, [x2, #0x53]
006AD9A20  tbnz     w8, #5, #0x6ad9a38
006AD9A24  mov      x0, x19
006AD9A28  str      x20, [x0, #0x38]!
006AD9A2C  mov      x1, x20
006AD9A30  bl       #0x382bcb8 ; 
006AD9A34  b        #0x6ad9a48 ; 
006AD9A38  ldr      x8, [x2, #0x60]
006AD9A3C  mov      x0, x19
006AD9A40  mov      x1, x20
006AD9A44  blr      x8
006AD9A48  mov      x0, x19
006AD9A4C  mov      x1, xzr
006AD9A50  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD9A54  adrp     x21, #0x959f000
006AD9A58  ldrb     w8, [x21, #0x145]
006AD9A5C  mov      x20, x0
006AD9A60  cbnz     w8, #0x6ad9a78
006AD9A64  adrp     x0, #0x8f3c000
006AD9A68  ldr      x0, [x0, #0x4c8]
006AD9A6C  bl       #0x382bd14 ; 
006AD9A70  mov      w8, #1
006AD9A74  strb     w8, [x21, #0x145]
006AD9A78  adrp     x8, #0x8f3c000
006AD9A7C  ldr      x8, [x8, #0x4c8]
006AD9A80  ldr      x2, [x8]
006AD9A84  ldrb     w8, [x2, #0x53]
006AD9A88  tbnz     w8, #5, #0x6ad9aa0
006AD9A8C  mov      x0, x19
006AD9A90  str      x20, [x0, #0x40]!
006AD9A94  mov      x1, x20
006AD9A98  bl       #0x382bcb8 ; 
006AD9A9C  b        #0x6ad9ab0 ; 
006AD9AA0  ldr      x8, [x2, #0x60]
006AD9AA4  mov      x0, x19
006AD9AA8  mov      x1, x20
006AD9AAC  blr      x8
006AD9AB0  mov      x0, x19
006AD9AB4  mov      x1, xzr
006AD9AB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD9ABC  adrp     x21, #0x959f000
006AD9AC0  ldrb     w8, [x21, #0x146]
006AD9AC4  mov      w20, w0
006AD9AC8  cbnz     w8, #0x6ad9ae0
006AD9ACC  adrp     x0, #0x8f3c000
006AD9AD0  ldr      x0, [x0, #0x4d8]
006AD9AD4  bl       #0x382bd14 ; 
006AD9AD8  mov      w8, #1
006AD9ADC  strb     w8, [x21, #0x146]
006AD9AE0  adrp     x8, #0x8f3c000
006AD9AE4  ldr      x8, [x8, #0x4d8]
006AD9AE8  ldr      x2, [x8]
006AD9AEC  ldrb     w8, [x2, #0x53]
006AD9AF0  tbnz     w8, #5, #0x6ad9afc
006AD9AF4  str      w20, [x19, #0x48]
006AD9AF8  b        #0x6ad9b0c ; 
006AD9AFC  ldr      x8, [x2, #0x60]
006AD9B00  mov      x0, x19
006AD9B04  mov      w1, w20
006AD9B08  blr      x8
006AD9B0C  mov      x0, x19
006AD9B10  mov      x1, xzr
006AD9B14  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD9B18  adrp     x21, #0x959f000
006AD9B1C  ldrb     w8, [x21, #0x147]
006AD9B20  mov      x20, x0
006AD9B24  cbnz     w8, #0x6ad9b3c
006AD9B28  adrp     x0, #0x8f3c000
006AD9B2C  ldr      x0, [x0, #0x4e8]
006AD9B30  bl       #0x382bd14 ; 
006AD9B34  mov      w8, #1
006AD9B38  strb     w8, [x21, #0x147]
006AD9B3C  adrp     x8, #0x8f3c000
006AD9B40  ldr      x8, [x8, #0x4e8]
006AD9B44  ldr      x2, [x8]
006AD9B48  ldrb     w8, [x2, #0x53]
006AD9B4C  tbnz     w8, #5, #0x6ad9b64
006AD9B50  mov      x0, x19
006AD9B54  str      x20, [x0, #0x50]!
006AD9B58  mov      x1, x20
006AD9B5C  bl       #0x382bcb8 ; 
006AD9B60  b        #0x6ad9b74 ; 
006AD9B64  ldr      x8, [x2, #0x60]
006AD9B68  mov      x0, x19
006AD9B6C  mov      x1, x20
006AD9B70  blr      x8
006AD9B74  mov      x0, x19
006AD9B78  mov      x1, xzr
006AD9B7C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AD9B80  adrp     x21, #0x959f000
006AD9B84  ldrb     w8, [x21, #0x148]
006AD9B88  mov      x20, x0
006AD9B8C  cbnz     w8, #0x6ad9ba4
006AD9B90  adrp     x0, #0x8f3c000
006AD9B94  ldr      x0, [x0, #0x4f8]
006AD9B98  bl       #0x382bd14 ; 
006AD9B9C  mov      w8, #1
006AD9BA0  strb     w8, [x21, #0x148]
006AD9BA4  adrp     x8, #0x8f3c000
006AD9BA8  ldr      x8, [x8, #0x4f8]
006AD9BAC  ldr      x2, [x8]
006AD9BB0  ldrb     w8, [x2, #0x53]
006AD9BB4  tbnz     w8, #5, #0x6ad9bcc
006AD9BB8  mov      x0, x19
006AD9BBC  str      x20, [x0, #0x58]!
006AD9BC0  mov      x1, x20
006AD9BC4  bl       #0x382bcb8 ; 
006AD9BC8  b        #0x6ad9bdc ; 
006AD9BCC  ldr      x8, [x2, #0x60]
006AD9BD0  mov      x0, x19
006AD9BD4  mov      x1, x20
006AD9BD8  blr      x8
006AD9BDC  mov      x0, x19
006AD9BE0  mov      x1, xzr
006AD9BE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD9BE8  adrp     x21, #0x959f000
006AD9BEC  ldrb     w8, [x21, #0x149]
006AD9BF0  mov      w20, w0
006AD9BF4  cbnz     w8, #0x6ad9c0c
006AD9BF8  adrp     x0, #0x8f3c000
006AD9BFC  ldr      x0, [x0, #0x500]
006AD9C00  bl       #0x382bd14 ; 
006AD9C04  mov      w8, #1
006AD9C08  strb     w8, [x21, #0x149]
006AD9C0C  adrp     x8, #0x8f3c000
006AD9C10  ldr      x8, [x8, #0x500]
006AD9C14  ldr      x2, [x8]
006AD9C18  ldrb     w8, [x2, #0x53]
006AD9C1C  tbnz     w8, #5, #0x6ad9c28
006AD9C20  str      w20, [x19, #0x60]
006AD9C24  b        #0x6ad9c38 ; 
006AD9C28  ldr      x8, [x2, #0x60]
006AD9C2C  mov      x0, x19
006AD9C30  mov      w1, w20
006AD9C34  blr      x8
006AD9C38  ldp      x20, x19, [sp, #0x10]
006AD9C3C  mov      w0, #1
006AD9C40  ldp      x30, x21, [sp], #0x20
006AD9C44  ret      

