; LocalModels.Bean.EventBigA_EventBigADraw$$readImpl
; RVA 0x6A688C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A688C0  stp      x30, x21, [sp, #-0x20]!
006A688C4  stp      x20, x19, [sp, #0x10]
006A688C8  adrp     x20, #0x959d000
006A688CC  adrp     x21, #0x8f36000
006A688D0  ldrb     w8, [x20, #0xcc9]
006A688D4  ldr      x21, [x21, #0xf98]
006A688D8  mov      x19, x0
006A688DC  tbnz     w8, #0, #0x6a688f4
006A688E0  adrp     x0, #0x8f36000
006A688E4  ldr      x0, [x0, #0xf98]
006A688E8  bl       #0x382bd14 ; 
006A688EC  mov      w8, #1
006A688F0  strb     w8, [x20, #0xcc9]
006A688F4  ldr      x1, [x21]
006A688F8  ldrb     w8, [x1, #0x53]
006A688FC  tbnz     w8, #5, #0x6a6894c
006A68900  mov      x0, x19
006A68904  mov      x1, xzr
006A68908  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6890C  adrp     x21, #0x959e000
006A68910  ldrb     w8, [x21, #0x3fc]
006A68914  mov      w20, w0
006A68918  cbnz     w8, #0x6a68930
006A6891C  adrp     x0, #0x8f36000
006A68920  ldr      x0, [x0, #0xf10]
006A68924  bl       #0x382bd14 ; 
006A68928  mov      w8, #1
006A6892C  strb     w8, [x21, #0x3fc]
006A68930  adrp     x8, #0x8f36000
006A68934  ldr      x8, [x8, #0xf10]
006A68938  ldr      x2, [x8]
006A6893C  ldrb     w8, [x2, #0x53]
006A68940  tbnz     w8, #5, #0x6a68960
006A68944  str      w20, [x19, #0x20]
006A68948  b        #0x6a68970 ; 
006A6894C  ldr      x2, [x1, #0x60]
006A68950  mov      x0, x19
006A68954  ldp      x20, x19, [sp, #0x10]
006A68958  ldp      x30, x21, [sp], #0x20
006A6895C  br       x2
006A68960  ldr      x8, [x2, #0x60]
006A68964  mov      x0, x19
006A68968  mov      w1, w20
006A6896C  blr      x8
006A68970  mov      x0, x19
006A68974  mov      x1, xzr
006A68978  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6897C  adrp     x21, #0x959e000
006A68980  ldrb     w8, [x21, #0x3fd]
006A68984  mov      w20, w0
006A68988  cbnz     w8, #0x6a689a0
006A6898C  adrp     x0, #0x8f36000
006A68990  ldr      x0, [x0, #0xf20]
006A68994  bl       #0x382bd14 ; 
006A68998  mov      w8, #1
006A6899C  strb     w8, [x21, #0x3fd]
006A689A0  adrp     x8, #0x8f36000
006A689A4  ldr      x8, [x8, #0xf20]
006A689A8  ldr      x2, [x8]
006A689AC  ldrb     w8, [x2, #0x53]
006A689B0  tbnz     w8, #5, #0x6a689bc
006A689B4  str      w20, [x19, #0x24]
006A689B8  b        #0x6a689cc ; 
006A689BC  ldr      x8, [x2, #0x60]
006A689C0  mov      x0, x19
006A689C4  mov      w1, w20
006A689C8  blr      x8
006A689CC  mov      x0, x19
006A689D0  mov      x1, xzr
006A689D4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A689D8  adrp     x21, #0x959e000
006A689DC  ldrb     w8, [x21, #0x3fe]
006A689E0  mov      x20, x0
006A689E4  cbnz     w8, #0x6a689fc
006A689E8  adrp     x0, #0x8f36000
006A689EC  ldr      x0, [x0, #0xf30]
006A689F0  bl       #0x382bd14 ; 
006A689F4  mov      w8, #1
006A689F8  strb     w8, [x21, #0x3fe]
006A689FC  adrp     x8, #0x8f36000
006A68A00  ldr      x8, [x8, #0xf30]
006A68A04  ldr      x2, [x8]
006A68A08  ldrb     w8, [x2, #0x53]
006A68A0C  tbnz     w8, #5, #0x6a68a24
006A68A10  mov      x0, x19
006A68A14  str      x20, [x0, #0x28]!
006A68A18  mov      x1, x20
006A68A1C  bl       #0x382bcb8 ; 
006A68A20  b        #0x6a68a34 ; 
006A68A24  ldr      x8, [x2, #0x60]
006A68A28  mov      x0, x19
006A68A2C  mov      x1, x20
006A68A30  blr      x8
006A68A34  mov      x0, x19
006A68A38  mov      x1, xzr
006A68A3C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A68A40  adrp     x21, #0x959e000
006A68A44  ldrb     w8, [x21, #0x3ff]
006A68A48  mov      x20, x0
006A68A4C  cbnz     w8, #0x6a68a64
006A68A50  adrp     x0, #0x8f36000
006A68A54  ldr      x0, [x0, #0xf40]
006A68A58  bl       #0x382bd14 ; 
006A68A5C  mov      w8, #1
006A68A60  strb     w8, [x21, #0x3ff]
006A68A64  adrp     x8, #0x8f36000
006A68A68  ldr      x8, [x8, #0xf40]
006A68A6C  ldr      x2, [x8]
006A68A70  ldrb     w8, [x2, #0x53]
006A68A74  tbnz     w8, #5, #0x6a68a8c
006A68A78  mov      x0, x19
006A68A7C  str      x20, [x0, #0x30]!
006A68A80  mov      x1, x20
006A68A84  bl       #0x382bcb8 ; 
006A68A88  b        #0x6a68a9c ; 
006A68A8C  ldr      x8, [x2, #0x60]
006A68A90  mov      x0, x19
006A68A94  mov      x1, x20
006A68A98  blr      x8
006A68A9C  mov      x0, x19
006A68AA0  mov      x1, xzr
006A68AA4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A68AA8  adrp     x21, #0x959e000
006A68AAC  ldrb     w8, [x21, #0x400]
006A68AB0  mov      w20, w0
006A68AB4  cbnz     w8, #0x6a68acc
006A68AB8  adrp     x0, #0x8f36000
006A68ABC  ldr      x0, [x0, #0xf50]
006A68AC0  bl       #0x382bd14 ; 
006A68AC4  mov      w8, #1
006A68AC8  strb     w8, [x21, #0x400]
006A68ACC  adrp     x8, #0x8f36000
006A68AD0  ldr      x8, [x8, #0xf50]
006A68AD4  ldr      x2, [x8]
006A68AD8  ldrb     w8, [x2, #0x53]
006A68ADC  tbnz     w8, #5, #0x6a68ae8
006A68AE0  str      w20, [x19, #0x38]
006A68AE4  b        #0x6a68af8 ; 
006A68AE8  ldr      x8, [x2, #0x60]
006A68AEC  mov      x0, x19
006A68AF0  mov      w1, w20
006A68AF4  blr      x8
006A68AF8  mov      x0, x19
006A68AFC  mov      x1, xzr
006A68B00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A68B04  adrp     x21, #0x959e000
006A68B08  ldrb     w8, [x21, #0x401]
006A68B0C  mov      w20, w0
006A68B10  cbnz     w8, #0x6a68b28
006A68B14  adrp     x0, #0x8f36000
006A68B18  ldr      x0, [x0, #0xf60]
006A68B1C  bl       #0x382bd14 ; 
006A68B20  mov      w8, #1
006A68B24  strb     w8, [x21, #0x401]
006A68B28  adrp     x8, #0x8f36000
006A68B2C  ldr      x8, [x8, #0xf60]
006A68B30  ldr      x2, [x8]
006A68B34  ldrb     w8, [x2, #0x53]
006A68B38  tbnz     w8, #5, #0x6a68b44
006A68B3C  str      w20, [x19, #0x3c]
006A68B40  b        #0x6a68b54 ; 
006A68B44  ldr      x8, [x2, #0x60]
006A68B48  mov      x0, x19
006A68B4C  mov      w1, w20
006A68B50  blr      x8
006A68B54  mov      x0, x19
006A68B58  mov      x1, xzr
006A68B5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A68B60  adrp     x21, #0x959e000
006A68B64  ldrb     w8, [x21, #0x402]
006A68B68  mov      w20, w0
006A68B6C  cbnz     w8, #0x6a68b84
006A68B70  adrp     x0, #0x8f36000
006A68B74  ldr      x0, [x0, #0xf70]
006A68B78  bl       #0x382bd14 ; 
006A68B7C  mov      w8, #1
006A68B80  strb     w8, [x21, #0x402]
006A68B84  adrp     x8, #0x8f36000
006A68B88  ldr      x8, [x8, #0xf70]
006A68B8C  ldr      x2, [x8]
006A68B90  ldrb     w8, [x2, #0x53]
006A68B94  tbnz     w8, #5, #0x6a68ba0
006A68B98  str      w20, [x19, #0x40]
006A68B9C  b        #0x6a68bb0 ; 
006A68BA0  ldr      x8, [x2, #0x60]
006A68BA4  mov      x0, x19
006A68BA8  mov      w1, w20
006A68BAC  blr      x8
006A68BB0  mov      x0, x19
006A68BB4  mov      x1, xzr
006A68BB8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A68BBC  adrp     x21, #0x959e000
006A68BC0  ldrb     w8, [x21, #0x403]
006A68BC4  mov      x20, x0
006A68BC8  cbnz     w8, #0x6a68be0
006A68BCC  adrp     x0, #0x8f36000
006A68BD0  ldr      x0, [x0, #0xf80]
006A68BD4  bl       #0x382bd14 ; 
006A68BD8  mov      w8, #1
006A68BDC  strb     w8, [x21, #0x403]
006A68BE0  adrp     x8, #0x8f36000
006A68BE4  ldr      x8, [x8, #0xf80]
006A68BE8  ldr      x2, [x8]
006A68BEC  ldrb     w8, [x2, #0x53]
006A68BF0  tbnz     w8, #5, #0x6a68c08
006A68BF4  mov      x0, x19
006A68BF8  str      x20, [x0, #0x48]!
006A68BFC  mov      x1, x20
006A68C00  bl       #0x382bcb8 ; 
006A68C04  b        #0x6a68c18 ; 
006A68C08  ldr      x8, [x2, #0x60]
006A68C0C  mov      x0, x19
006A68C10  mov      x1, x20
006A68C14  blr      x8
006A68C18  mov      x0, x19
006A68C1C  mov      x1, xzr
006A68C20  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A68C24  adrp     x21, #0x959e000
006A68C28  ldrb     w8, [x21, #0x404]
006A68C2C  mov      x20, x0
006A68C30  cbnz     w8, #0x6a68c48
006A68C34  adrp     x0, #0x8f36000
006A68C38  ldr      x0, [x0, #0xf90]
006A68C3C  bl       #0x382bd14 ; 
006A68C40  mov      w8, #1
006A68C44  strb     w8, [x21, #0x404]
006A68C48  adrp     x8, #0x8f36000
006A68C4C  ldr      x8, [x8, #0xf90]
006A68C50  ldr      x2, [x8]
006A68C54  ldrb     w8, [x2, #0x53]
006A68C58  tbnz     w8, #5, #0x6a68c70
006A68C5C  str      x20, [x19, #0x50]!
006A68C60  mov      x0, x19
006A68C64  mov      x1, x20
006A68C68  bl       #0x382bcb8 ; 
006A68C6C  b        #0x6a68c80 ; 
006A68C70  ldr      x8, [x2, #0x60]
006A68C74  mov      x0, x19
006A68C78  mov      x1, x20
006A68C7C  blr      x8
006A68C80  ldp      x20, x19, [sp, #0x10]
006A68C84  mov      w0, #1
006A68C88  ldp      x30, x21, [sp], #0x20
006A68C8C  ret      

