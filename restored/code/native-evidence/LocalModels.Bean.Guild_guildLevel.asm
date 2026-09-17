; LocalModels.Bean.Guild_guildLevel$$readImpl
; RVA 0x6A93714; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A93714  stp      x30, x21, [sp, #-0x20]!
006A93718  stp      x20, x19, [sp, #0x10]
006A9371C  adrp     x20, #0x959e000
006A93720  adrp     x21, #0x8f39000
006A93724  ldrb     w8, [x20, #0x148]
006A93728  ldr      x21, [x21, #0x60]
006A9372C  mov      x19, x0
006A93730  tbnz     w8, #0, #0x6a93748
006A93734  adrp     x0, #0x8f39000
006A93738  ldr      x0, [x0, #0x60]
006A9373C  bl       #0x382bd14 ; 
006A93740  mov      w8, #1
006A93744  strb     w8, [x20, #0x148]
006A93748  ldr      x1, [x21]
006A9374C  ldrb     w8, [x1, #0x53]
006A93750  tbnz     w8, #5, #0x6a937a0
006A93754  mov      x0, x19
006A93758  mov      x1, xzr
006A9375C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A93760  adrp     x21, #0x959e000
006A93764  ldrb     w8, [x21, #0x5c4]
006A93768  mov      w20, w0
006A9376C  cbnz     w8, #0x6a93784
006A93770  adrp     x0, #0x8f38000
006A93774  ldr      x0, [x0, #0xf98]
006A93778  bl       #0x382bd14 ; 
006A9377C  mov      w8, #1
006A93780  strb     w8, [x21, #0x5c4]
006A93784  adrp     x8, #0x8f38000
006A93788  ldr      x8, [x8, #0xf98]
006A9378C  ldr      x2, [x8]
006A93790  ldrb     w8, [x2, #0x53]
006A93794  tbnz     w8, #5, #0x6a937b4
006A93798  str      w20, [x19, #0x20]
006A9379C  b        #0x6a937c4 ; 
006A937A0  ldr      x2, [x1, #0x60]
006A937A4  mov      x0, x19
006A937A8  ldp      x20, x19, [sp, #0x10]
006A937AC  ldp      x30, x21, [sp], #0x20
006A937B0  br       x2
006A937B4  ldr      x8, [x2, #0x60]
006A937B8  mov      x0, x19
006A937BC  mov      w1, w20
006A937C0  blr      x8
006A937C4  mov      x0, x19
006A937C8  mov      x1, xzr
006A937CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A937D0  adrp     x21, #0x959e000
006A937D4  ldrb     w8, [x21, #0x5c5]
006A937D8  mov      w20, w0
006A937DC  cbnz     w8, #0x6a937f4
006A937E0  adrp     x0, #0x8f38000
006A937E4  ldr      x0, [x0, #0xfa8]
006A937E8  bl       #0x382bd14 ; 
006A937EC  mov      w8, #1
006A937F0  strb     w8, [x21, #0x5c5]
006A937F4  adrp     x8, #0x8f38000
006A937F8  ldr      x8, [x8, #0xfa8]
006A937FC  ldr      x2, [x8]
006A93800  ldrb     w8, [x2, #0x53]
006A93804  tbnz     w8, #5, #0x6a93810
006A93808  str      w20, [x19, #0x24]
006A9380C  b        #0x6a93820 ; 
006A93810  ldr      x8, [x2, #0x60]
006A93814  mov      x0, x19
006A93818  mov      w1, w20
006A9381C  blr      x8
006A93820  mov      x0, x19
006A93824  mov      x1, xzr
006A93828  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9382C  adrp     x21, #0x959e000
006A93830  ldrb     w8, [x21, #0x5c6]
006A93834  mov      w20, w0
006A93838  cbnz     w8, #0x6a93850
006A9383C  adrp     x0, #0x8f38000
006A93840  ldr      x0, [x0, #0xfb8]
006A93844  bl       #0x382bd14 ; 
006A93848  mov      w8, #1
006A9384C  strb     w8, [x21, #0x5c6]
006A93850  adrp     x8, #0x8f38000
006A93854  ldr      x8, [x8, #0xfb8]
006A93858  ldr      x2, [x8]
006A9385C  ldrb     w8, [x2, #0x53]
006A93860  tbnz     w8, #5, #0x6a9386c
006A93864  str      w20, [x19, #0x28]
006A93868  b        #0x6a9387c ; 
006A9386C  ldr      x8, [x2, #0x60]
006A93870  mov      x0, x19
006A93874  mov      w1, w20
006A93878  blr      x8
006A9387C  mov      x0, x19
006A93880  mov      x1, xzr
006A93884  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A93888  adrp     x21, #0x959e000
006A9388C  ldrb     w8, [x21, #0x5c7]
006A93890  mov      x20, x0
006A93894  cbnz     w8, #0x6a938ac
006A93898  adrp     x0, #0x8f38000
006A9389C  ldr      x0, [x0, #0xfc8]
006A938A0  bl       #0x382bd14 ; 
006A938A4  mov      w8, #1
006A938A8  strb     w8, [x21, #0x5c7]
006A938AC  adrp     x8, #0x8f38000
006A938B0  ldr      x8, [x8, #0xfc8]
006A938B4  ldr      x2, [x8]
006A938B8  ldrb     w8, [x2, #0x53]
006A938BC  tbnz     w8, #5, #0x6a938d4
006A938C0  mov      x0, x19
006A938C4  str      x20, [x0, #0x30]!
006A938C8  mov      x1, x20
006A938CC  bl       #0x382bcb8 ; 
006A938D0  b        #0x6a938e4 ; 
006A938D4  ldr      x8, [x2, #0x60]
006A938D8  mov      x0, x19
006A938DC  mov      x1, x20
006A938E0  blr      x8
006A938E4  mov      x0, x19
006A938E8  mov      x1, xzr
006A938EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A938F0  adrp     x21, #0x959e000
006A938F4  ldrb     w8, [x21, #0x5c8]
006A938F8  mov      w20, w0
006A938FC  cbnz     w8, #0x6a93914
006A93900  adrp     x0, #0x8f38000
006A93904  ldr      x0, [x0, #0xfd8]
006A93908  bl       #0x382bd14 ; 
006A9390C  mov      w8, #1
006A93910  strb     w8, [x21, #0x5c8]
006A93914  adrp     x8, #0x8f38000
006A93918  ldr      x8, [x8, #0xfd8]
006A9391C  ldr      x2, [x8]
006A93920  ldrb     w8, [x2, #0x53]
006A93924  tbnz     w8, #5, #0x6a93930
006A93928  str      w20, [x19, #0x38]
006A9392C  b        #0x6a93940 ; 
006A93930  ldr      x8, [x2, #0x60]
006A93934  mov      x0, x19
006A93938  mov      w1, w20
006A9393C  blr      x8
006A93940  mov      x0, x19
006A93944  mov      x1, xzr
006A93948  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9394C  adrp     x21, #0x959e000
006A93950  ldrb     w8, [x21, #0x5c9]
006A93954  mov      w20, w0
006A93958  cbnz     w8, #0x6a93970
006A9395C  adrp     x0, #0x8f38000
006A93960  ldr      x0, [x0, #0xfe8]
006A93964  bl       #0x382bd14 ; 
006A93968  mov      w8, #1
006A9396C  strb     w8, [x21, #0x5c9]
006A93970  adrp     x8, #0x8f38000
006A93974  ldr      x8, [x8, #0xfe8]
006A93978  ldr      x2, [x8]
006A9397C  ldrb     w8, [x2, #0x53]
006A93980  tbnz     w8, #5, #0x6a9398c
006A93984  str      w20, [x19, #0x3c]
006A93988  b        #0x6a9399c ; 
006A9398C  ldr      x8, [x2, #0x60]
006A93990  mov      x0, x19
006A93994  mov      w1, w20
006A93998  blr      x8
006A9399C  mov      x0, x19
006A939A0  mov      x1, xzr
006A939A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A939A8  adrp     x21, #0x959e000
006A939AC  ldrb     w8, [x21, #0x5ca]
006A939B0  mov      w20, w0
006A939B4  cbnz     w8, #0x6a939cc
006A939B8  adrp     x0, #0x8f38000
006A939BC  ldr      x0, [x0, #0xff8]
006A939C0  bl       #0x382bd14 ; 
006A939C4  mov      w8, #1
006A939C8  strb     w8, [x21, #0x5ca]
006A939CC  adrp     x8, #0x8f38000
006A939D0  ldr      x8, [x8, #0xff8]
006A939D4  ldr      x2, [x8]
006A939D8  ldrb     w8, [x2, #0x53]
006A939DC  tbnz     w8, #5, #0x6a939e8
006A939E0  str      w20, [x19, #0x40]
006A939E4  b        #0x6a939f8 ; 
006A939E8  ldr      x8, [x2, #0x60]
006A939EC  mov      x0, x19
006A939F0  mov      w1, w20
006A939F4  blr      x8
006A939F8  mov      x0, x19
006A939FC  mov      x1, xzr
006A93A00  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A93A04  adrp     x21, #0x959e000
006A93A08  ldrb     w8, [x21, #0x5cb]
006A93A0C  mov      x20, x0
006A93A10  cbnz     w8, #0x6a93a28
006A93A14  adrp     x0, #0x8f39000
006A93A18  ldr      x0, [x0, #8]
006A93A1C  bl       #0x382bd14 ; 
006A93A20  mov      w8, #1
006A93A24  strb     w8, [x21, #0x5cb]
006A93A28  adrp     x8, #0x8f39000
006A93A2C  ldr      x8, [x8, #8]
006A93A30  ldr      x2, [x8]
006A93A34  ldrb     w8, [x2, #0x53]
006A93A38  tbnz     w8, #5, #0x6a93a50
006A93A3C  mov      x0, x19
006A93A40  str      x20, [x0, #0x48]!
006A93A44  mov      x1, x20
006A93A48  bl       #0x382bcb8 ; 
006A93A4C  b        #0x6a93a60 ; 
006A93A50  ldr      x8, [x2, #0x60]
006A93A54  mov      x0, x19
006A93A58  mov      x1, x20
006A93A5C  blr      x8
006A93A60  mov      x0, x19
006A93A64  mov      x1, xzr
006A93A68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A93A6C  adrp     x21, #0x959e000
006A93A70  ldrb     w8, [x21, #0x5cc]
006A93A74  mov      w20, w0
006A93A78  cbnz     w8, #0x6a93a90
006A93A7C  adrp     x0, #0x8f39000
006A93A80  ldr      x0, [x0, #0x18]
006A93A84  bl       #0x382bd14 ; 
006A93A88  mov      w8, #1
006A93A8C  strb     w8, [x21, #0x5cc]
006A93A90  adrp     x8, #0x8f39000
006A93A94  ldr      x8, [x8, #0x18]
006A93A98  ldr      x2, [x8]
006A93A9C  ldrb     w8, [x2, #0x53]
006A93AA0  tbnz     w8, #5, #0x6a93aac
006A93AA4  str      w20, [x19, #0x50]
006A93AA8  b        #0x6a93abc ; 
006A93AAC  ldr      x8, [x2, #0x60]
006A93AB0  mov      x0, x19
006A93AB4  mov      w1, w20
006A93AB8  blr      x8
006A93ABC  mov      x0, x19
006A93AC0  mov      x1, xzr
006A93AC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A93AC8  adrp     x21, #0x959e000
006A93ACC  ldrb     w8, [x21, #0x5cd]
006A93AD0  mov      w20, w0
006A93AD4  cbnz     w8, #0x6a93aec
006A93AD8  adrp     x0, #0x8f39000
006A93ADC  ldr      x0, [x0, #0x28]
006A93AE0  bl       #0x382bd14 ; 
006A93AE4  mov      w8, #1
006A93AE8  strb     w8, [x21, #0x5cd]
006A93AEC  adrp     x8, #0x8f39000
006A93AF0  ldr      x8, [x8, #0x28]
006A93AF4  ldr      x2, [x8]
006A93AF8  ldrb     w8, [x2, #0x53]
006A93AFC  tbnz     w8, #5, #0x6a93b08
006A93B00  str      w20, [x19, #0x54]
006A93B04  b        #0x6a93b18 ; 
006A93B08  ldr      x8, [x2, #0x60]
006A93B0C  mov      x0, x19
006A93B10  mov      w1, w20
006A93B14  blr      x8
006A93B18  mov      x0, x19
006A93B1C  mov      x1, xzr
006A93B20  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A93B24  adrp     x21, #0x959e000
006A93B28  ldrb     w8, [x21, #0x5ce]
006A93B2C  mov      x20, x0
006A93B30  cbnz     w8, #0x6a93b48
006A93B34  adrp     x0, #0x8f39000
006A93B38  ldr      x0, [x0, #0x38]
006A93B3C  bl       #0x382bd14 ; 
006A93B40  mov      w8, #1
006A93B44  strb     w8, [x21, #0x5ce]
006A93B48  adrp     x8, #0x8f39000
006A93B4C  ldr      x8, [x8, #0x38]
006A93B50  ldr      x2, [x8]
006A93B54  ldrb     w8, [x2, #0x53]
006A93B58  tbnz     w8, #5, #0x6a93b70
006A93B5C  mov      x0, x19
006A93B60  str      x20, [x0, #0x58]!
006A93B64  mov      x1, x20
006A93B68  bl       #0x382bcb8 ; 
006A93B6C  b        #0x6a93b80 ; 
006A93B70  ldr      x8, [x2, #0x60]
006A93B74  mov      x0, x19
006A93B78  mov      x1, x20
006A93B7C  blr      x8
006A93B80  mov      x0, x19
006A93B84  mov      x1, xzr
006A93B88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A93B8C  adrp     x21, #0x959e000
006A93B90  ldrb     w8, [x21, #0x5cf]
006A93B94  mov      w20, w0
006A93B98  cbnz     w8, #0x6a93bb0
006A93B9C  adrp     x0, #0x8f39000
006A93BA0  ldr      x0, [x0, #0x48]
006A93BA4  bl       #0x382bd14 ; 
006A93BA8  mov      w8, #1
006A93BAC  strb     w8, [x21, #0x5cf]
006A93BB0  adrp     x8, #0x8f39000
006A93BB4  ldr      x8, [x8, #0x48]
006A93BB8  ldr      x2, [x8]
006A93BBC  ldrb     w8, [x2, #0x53]
006A93BC0  tbnz     w8, #5, #0x6a93bcc
006A93BC4  str      w20, [x19, #0x60]
006A93BC8  b        #0x6a93bdc ; 
006A93BCC  ldr      x8, [x2, #0x60]
006A93BD0  mov      x0, x19
006A93BD4  mov      w1, w20
006A93BD8  blr      x8
006A93BDC  mov      x0, x19
006A93BE0  mov      x1, xzr
006A93BE4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A93BE8  adrp     x21, #0x959e000
006A93BEC  ldrb     w8, [x21, #0x5d0]
006A93BF0  mov      x20, x0
006A93BF4  cbnz     w8, #0x6a93c0c
006A93BF8  adrp     x0, #0x8f39000
006A93BFC  ldr      x0, [x0, #0x58]
006A93C00  bl       #0x382bd14 ; 
006A93C04  mov      w8, #1
006A93C08  strb     w8, [x21, #0x5d0]
006A93C0C  adrp     x8, #0x8f39000
006A93C10  ldr      x8, [x8, #0x58]
006A93C14  ldr      x2, [x8]
006A93C18  ldrb     w8, [x2, #0x53]
006A93C1C  tbnz     w8, #5, #0x6a93c34
006A93C20  str      x20, [x19, #0x68]!
006A93C24  mov      x0, x19
006A93C28  mov      x1, x20
006A93C2C  bl       #0x382bcb8 ; 
006A93C30  b        #0x6a93c44 ; 
006A93C34  ldr      x8, [x2, #0x60]
006A93C38  mov      x0, x19
006A93C3C  mov      x1, x20
006A93C40  blr      x8
006A93C44  ldp      x20, x19, [sp, #0x10]
006A93C48  mov      w0, #1
006A93C4C  ldp      x30, x21, [sp], #0x20
006A93C50  ret      

