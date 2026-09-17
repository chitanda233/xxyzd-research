; LocalModels.Bean.GuildRace_opentime$$readImpl
; RVA 0x6A8C8E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8C8E0  stp      x30, x21, [sp, #-0x20]!
006A8C8E4  stp      x20, x19, [sp, #0x10]
006A8C8E8  adrp     x20, #0x959e000
006A8C8EC  adrp     x21, #0x8f38000
006A8C8F0  ldrb     w8, [x20, #0x91]
006A8C8F4  ldr      x21, [x21, #0xb18]
006A8C8F8  mov      x19, x0
006A8C8FC  tbnz     w8, #0, #0x6a8c914
006A8C900  adrp     x0, #0x8f38000
006A8C904  ldr      x0, [x0, #0xb18]
006A8C908  bl       #0x382bd14 ; 
006A8C90C  mov      w8, #1
006A8C910  strb     w8, [x20, #0x91]
006A8C914  ldr      x1, [x21]
006A8C918  ldrb     w8, [x1, #0x53]
006A8C91C  tbnz     w8, #5, #0x6a8c96c
006A8C920  mov      x0, x19
006A8C924  mov      x1, xzr
006A8C928  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8C92C  adrp     x21, #0x959e000
006A8C930  ldrb     w8, [x21, #0x579]
006A8C934  mov      w20, w0
006A8C938  cbnz     w8, #0x6a8c950
006A8C93C  adrp     x0, #0x8f38000
006A8C940  ldr      x0, [x0, #0xa90]
006A8C944  bl       #0x382bd14 ; 
006A8C948  mov      w8, #1
006A8C94C  strb     w8, [x21, #0x579]
006A8C950  adrp     x8, #0x8f38000
006A8C954  ldr      x8, [x8, #0xa90]
006A8C958  ldr      x2, [x8]
006A8C95C  ldrb     w8, [x2, #0x53]
006A8C960  tbnz     w8, #5, #0x6a8c980
006A8C964  str      w20, [x19, #0x20]
006A8C968  b        #0x6a8c990 ; 
006A8C96C  ldr      x2, [x1, #0x60]
006A8C970  mov      x0, x19
006A8C974  ldp      x20, x19, [sp, #0x10]
006A8C978  ldp      x30, x21, [sp], #0x20
006A8C97C  br       x2
006A8C980  ldr      x8, [x2, #0x60]
006A8C984  mov      x0, x19
006A8C988  mov      w1, w20
006A8C98C  blr      x8
006A8C990  mov      x0, x19
006A8C994  mov      x1, xzr
006A8C998  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8C99C  adrp     x21, #0x959e000
006A8C9A0  ldrb     w8, [x21, #0x57a]
006A8C9A4  mov      x20, x0
006A8C9A8  cbnz     w8, #0x6a8c9c0
006A8C9AC  adrp     x0, #0x8f38000
006A8C9B0  ldr      x0, [x0, #0xaa0]
006A8C9B4  bl       #0x382bd14 ; 
006A8C9B8  mov      w8, #1
006A8C9BC  strb     w8, [x21, #0x57a]
006A8C9C0  adrp     x8, #0x8f38000
006A8C9C4  ldr      x8, [x8, #0xaa0]
006A8C9C8  ldr      x2, [x8]
006A8C9CC  ldrb     w8, [x2, #0x53]
006A8C9D0  tbnz     w8, #5, #0x6a8c9e8
006A8C9D4  mov      x0, x19
006A8C9D8  str      x20, [x0, #0x28]!
006A8C9DC  mov      x1, x20
006A8C9E0  bl       #0x382bcb8 ; 
006A8C9E4  b        #0x6a8c9f8 ; 
006A8C9E8  ldr      x8, [x2, #0x60]
006A8C9EC  mov      x0, x19
006A8C9F0  mov      x1, x20
006A8C9F4  blr      x8
006A8C9F8  mov      x0, x19
006A8C9FC  mov      x1, xzr
006A8CA00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CA04  adrp     x21, #0x959e000
006A8CA08  ldrb     w8, [x21, #0x57b]
006A8CA0C  mov      w20, w0
006A8CA10  cbnz     w8, #0x6a8ca28
006A8CA14  adrp     x0, #0x8f38000
006A8CA18  ldr      x0, [x0, #0xaa8]
006A8CA1C  bl       #0x382bd14 ; 
006A8CA20  mov      w8, #1
006A8CA24  strb     w8, [x21, #0x57b]
006A8CA28  adrp     x8, #0x8f38000
006A8CA2C  ldr      x8, [x8, #0xaa8]
006A8CA30  ldr      x2, [x8]
006A8CA34  ldrb     w8, [x2, #0x53]
006A8CA38  tbnz     w8, #5, #0x6a8ca44
006A8CA3C  str      w20, [x19, #0x30]
006A8CA40  b        #0x6a8ca54 ; 
006A8CA44  ldr      x8, [x2, #0x60]
006A8CA48  mov      x0, x19
006A8CA4C  mov      w1, w20
006A8CA50  blr      x8
006A8CA54  mov      x0, x19
006A8CA58  mov      x1, xzr
006A8CA5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CA60  adrp     x21, #0x959e000
006A8CA64  ldrb     w8, [x21, #0x57c]
006A8CA68  mov      w20, w0
006A8CA6C  cbnz     w8, #0x6a8ca84
006A8CA70  adrp     x0, #0x8f38000
006A8CA74  ldr      x0, [x0, #0xab0]
006A8CA78  bl       #0x382bd14 ; 
006A8CA7C  mov      w8, #1
006A8CA80  strb     w8, [x21, #0x57c]
006A8CA84  adrp     x8, #0x8f38000
006A8CA88  ldr      x8, [x8, #0xab0]
006A8CA8C  ldr      x2, [x8]
006A8CA90  ldrb     w8, [x2, #0x53]
006A8CA94  tbnz     w8, #5, #0x6a8caa0
006A8CA98  str      w20, [x19, #0x34]
006A8CA9C  b        #0x6a8cab0 ; 
006A8CAA0  ldr      x8, [x2, #0x60]
006A8CAA4  mov      x0, x19
006A8CAA8  mov      w1, w20
006A8CAAC  blr      x8
006A8CAB0  mov      x0, x19
006A8CAB4  mov      x1, xzr
006A8CAB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CABC  adrp     x21, #0x959e000
006A8CAC0  ldrb     w8, [x21, #0x57d]
006A8CAC4  mov      w20, w0
006A8CAC8  cbnz     w8, #0x6a8cae0
006A8CACC  adrp     x0, #0x8f38000
006A8CAD0  ldr      x0, [x0, #0xab8]
006A8CAD4  bl       #0x382bd14 ; 
006A8CAD8  mov      w8, #1
006A8CADC  strb     w8, [x21, #0x57d]
006A8CAE0  adrp     x8, #0x8f38000
006A8CAE4  ldr      x8, [x8, #0xab8]
006A8CAE8  ldr      x2, [x8]
006A8CAEC  ldrb     w8, [x2, #0x53]
006A8CAF0  tbnz     w8, #5, #0x6a8cafc
006A8CAF4  str      w20, [x19, #0x38]
006A8CAF8  b        #0x6a8cb0c ; 
006A8CAFC  ldr      x8, [x2, #0x60]
006A8CB00  mov      x0, x19
006A8CB04  mov      w1, w20
006A8CB08  blr      x8
006A8CB0C  mov      x0, x19
006A8CB10  mov      x1, xzr
006A8CB14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CB18  adrp     x21, #0x959e000
006A8CB1C  ldrb     w8, [x21, #0x57e]
006A8CB20  mov      w20, w0
006A8CB24  cbnz     w8, #0x6a8cb3c
006A8CB28  adrp     x0, #0x8f38000
006A8CB2C  ldr      x0, [x0, #0xac0]
006A8CB30  bl       #0x382bd14 ; 
006A8CB34  mov      w8, #1
006A8CB38  strb     w8, [x21, #0x57e]
006A8CB3C  adrp     x8, #0x8f38000
006A8CB40  ldr      x8, [x8, #0xac0]
006A8CB44  ldr      x2, [x8]
006A8CB48  ldrb     w8, [x2, #0x53]
006A8CB4C  tbnz     w8, #5, #0x6a8cb58
006A8CB50  str      w20, [x19, #0x3c]
006A8CB54  b        #0x6a8cb68 ; 
006A8CB58  ldr      x8, [x2, #0x60]
006A8CB5C  mov      x0, x19
006A8CB60  mov      w1, w20
006A8CB64  blr      x8
006A8CB68  mov      x0, x19
006A8CB6C  mov      x1, xzr
006A8CB70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CB74  adrp     x21, #0x959e000
006A8CB78  ldrb     w8, [x21, #0x57f]
006A8CB7C  mov      w20, w0
006A8CB80  cbnz     w8, #0x6a8cb98
006A8CB84  adrp     x0, #0x8f38000
006A8CB88  ldr      x0, [x0, #0xac8]
006A8CB8C  bl       #0x382bd14 ; 
006A8CB90  mov      w8, #1
006A8CB94  strb     w8, [x21, #0x57f]
006A8CB98  adrp     x8, #0x8f38000
006A8CB9C  ldr      x8, [x8, #0xac8]
006A8CBA0  ldr      x2, [x8]
006A8CBA4  ldrb     w8, [x2, #0x53]
006A8CBA8  tbnz     w8, #5, #0x6a8cbb4
006A8CBAC  str      w20, [x19, #0x40]
006A8CBB0  b        #0x6a8cbc4 ; 
006A8CBB4  ldr      x8, [x2, #0x60]
006A8CBB8  mov      x0, x19
006A8CBBC  mov      w1, w20
006A8CBC0  blr      x8
006A8CBC4  mov      x0, x19
006A8CBC8  mov      x1, xzr
006A8CBCC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CBD0  adrp     x21, #0x959e000
006A8CBD4  ldrb     w8, [x21, #0x580]
006A8CBD8  mov      w20, w0
006A8CBDC  cbnz     w8, #0x6a8cbf4
006A8CBE0  adrp     x0, #0x8f38000
006A8CBE4  ldr      x0, [x0, #0xad0]
006A8CBE8  bl       #0x382bd14 ; 
006A8CBEC  mov      w8, #1
006A8CBF0  strb     w8, [x21, #0x580]
006A8CBF4  adrp     x8, #0x8f38000
006A8CBF8  ldr      x8, [x8, #0xad0]
006A8CBFC  ldr      x2, [x8]
006A8CC00  ldrb     w8, [x2, #0x53]
006A8CC04  tbnz     w8, #5, #0x6a8cc10
006A8CC08  str      w20, [x19, #0x44]
006A8CC0C  b        #0x6a8cc20 ; 
006A8CC10  ldr      x8, [x2, #0x60]
006A8CC14  mov      x0, x19
006A8CC18  mov      w1, w20
006A8CC1C  blr      x8
006A8CC20  mov      x0, x19
006A8CC24  mov      x1, xzr
006A8CC28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CC2C  adrp     x21, #0x959e000
006A8CC30  ldrb     w8, [x21, #0x581]
006A8CC34  mov      w20, w0
006A8CC38  cbnz     w8, #0x6a8cc50
006A8CC3C  adrp     x0, #0x8f38000
006A8CC40  ldr      x0, [x0, #0xad8]
006A8CC44  bl       #0x382bd14 ; 
006A8CC48  mov      w8, #1
006A8CC4C  strb     w8, [x21, #0x581]
006A8CC50  adrp     x8, #0x8f38000
006A8CC54  ldr      x8, [x8, #0xad8]
006A8CC58  ldr      x2, [x8]
006A8CC5C  ldrb     w8, [x2, #0x53]
006A8CC60  tbnz     w8, #5, #0x6a8cc6c
006A8CC64  str      w20, [x19, #0x48]
006A8CC68  b        #0x6a8cc7c ; 
006A8CC6C  ldr      x8, [x2, #0x60]
006A8CC70  mov      x0, x19
006A8CC74  mov      w1, w20
006A8CC78  blr      x8
006A8CC7C  mov      x0, x19
006A8CC80  mov      x1, xzr
006A8CC84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CC88  adrp     x21, #0x959e000
006A8CC8C  ldrb     w8, [x21, #0x582]
006A8CC90  mov      w20, w0
006A8CC94  cbnz     w8, #0x6a8ccac
006A8CC98  adrp     x0, #0x8f38000
006A8CC9C  ldr      x0, [x0, #0xae0]
006A8CCA0  bl       #0x382bd14 ; 
006A8CCA4  mov      w8, #1
006A8CCA8  strb     w8, [x21, #0x582]
006A8CCAC  adrp     x8, #0x8f38000
006A8CCB0  ldr      x8, [x8, #0xae0]
006A8CCB4  ldr      x2, [x8]
006A8CCB8  ldrb     w8, [x2, #0x53]
006A8CCBC  tbnz     w8, #5, #0x6a8ccc8
006A8CCC0  str      w20, [x19, #0x4c]
006A8CCC4  b        #0x6a8ccd8 ; 
006A8CCC8  ldr      x8, [x2, #0x60]
006A8CCCC  mov      x0, x19
006A8CCD0  mov      w1, w20
006A8CCD4  blr      x8
006A8CCD8  mov      x0, x19
006A8CCDC  mov      x1, xzr
006A8CCE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CCE4  adrp     x21, #0x959e000
006A8CCE8  ldrb     w8, [x21, #0x583]
006A8CCEC  mov      w20, w0
006A8CCF0  cbnz     w8, #0x6a8cd08
006A8CCF4  adrp     x0, #0x8f38000
006A8CCF8  ldr      x0, [x0, #0xae8]
006A8CCFC  bl       #0x382bd14 ; 
006A8CD00  mov      w8, #1
006A8CD04  strb     w8, [x21, #0x583]
006A8CD08  adrp     x8, #0x8f38000
006A8CD0C  ldr      x8, [x8, #0xae8]
006A8CD10  ldr      x2, [x8]
006A8CD14  ldrb     w8, [x2, #0x53]
006A8CD18  tbnz     w8, #5, #0x6a8cd24
006A8CD1C  str      w20, [x19, #0x50]
006A8CD20  b        #0x6a8cd34 ; 
006A8CD24  ldr      x8, [x2, #0x60]
006A8CD28  mov      x0, x19
006A8CD2C  mov      w1, w20
006A8CD30  blr      x8
006A8CD34  mov      x0, x19
006A8CD38  mov      x1, xzr
006A8CD3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CD40  adrp     x21, #0x959e000
006A8CD44  ldrb     w8, [x21, #0x584]
006A8CD48  mov      w20, w0
006A8CD4C  cbnz     w8, #0x6a8cd64
006A8CD50  adrp     x0, #0x8f38000
006A8CD54  ldr      x0, [x0, #0xaf0]
006A8CD58  bl       #0x382bd14 ; 
006A8CD5C  mov      w8, #1
006A8CD60  strb     w8, [x21, #0x584]
006A8CD64  adrp     x8, #0x8f38000
006A8CD68  ldr      x8, [x8, #0xaf0]
006A8CD6C  ldr      x2, [x8]
006A8CD70  ldrb     w8, [x2, #0x53]
006A8CD74  tbnz     w8, #5, #0x6a8cd80
006A8CD78  str      w20, [x19, #0x54]
006A8CD7C  b        #0x6a8cd90 ; 
006A8CD80  ldr      x8, [x2, #0x60]
006A8CD84  mov      x0, x19
006A8CD88  mov      w1, w20
006A8CD8C  blr      x8
006A8CD90  mov      x0, x19
006A8CD94  mov      x1, xzr
006A8CD98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CD9C  adrp     x21, #0x959e000
006A8CDA0  ldrb     w8, [x21, #0x585]
006A8CDA4  mov      w20, w0
006A8CDA8  cbnz     w8, #0x6a8cdc0
006A8CDAC  adrp     x0, #0x8f38000
006A8CDB0  ldr      x0, [x0, #0xaf8]
006A8CDB4  bl       #0x382bd14 ; 
006A8CDB8  mov      w8, #1
006A8CDBC  strb     w8, [x21, #0x585]
006A8CDC0  adrp     x8, #0x8f38000
006A8CDC4  ldr      x8, [x8, #0xaf8]
006A8CDC8  ldr      x2, [x8]
006A8CDCC  ldrb     w8, [x2, #0x53]
006A8CDD0  tbnz     w8, #5, #0x6a8cddc
006A8CDD4  str      w20, [x19, #0x58]
006A8CDD8  b        #0x6a8cdec ; 
006A8CDDC  ldr      x8, [x2, #0x60]
006A8CDE0  mov      x0, x19
006A8CDE4  mov      w1, w20
006A8CDE8  blr      x8
006A8CDEC  mov      x0, x19
006A8CDF0  mov      x1, xzr
006A8CDF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CDF8  adrp     x21, #0x959e000
006A8CDFC  ldrb     w8, [x21, #0x586]
006A8CE00  mov      w20, w0
006A8CE04  cbnz     w8, #0x6a8ce1c
006A8CE08  adrp     x0, #0x8f38000
006A8CE0C  ldr      x0, [x0, #0xb00]
006A8CE10  bl       #0x382bd14 ; 
006A8CE14  mov      w8, #1
006A8CE18  strb     w8, [x21, #0x586]
006A8CE1C  adrp     x8, #0x8f38000
006A8CE20  ldr      x8, [x8, #0xb00]
006A8CE24  ldr      x2, [x8]
006A8CE28  ldrb     w8, [x2, #0x53]
006A8CE2C  tbnz     w8, #5, #0x6a8ce38
006A8CE30  str      w20, [x19, #0x5c]
006A8CE34  b        #0x6a8ce48 ; 
006A8CE38  ldr      x8, [x2, #0x60]
006A8CE3C  mov      x0, x19
006A8CE40  mov      w1, w20
006A8CE44  blr      x8
006A8CE48  mov      x0, x19
006A8CE4C  mov      x1, xzr
006A8CE50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CE54  adrp     x21, #0x959e000
006A8CE58  ldrb     w8, [x21, #0x587]
006A8CE5C  mov      w20, w0
006A8CE60  cbnz     w8, #0x6a8ce78
006A8CE64  adrp     x0, #0x8f38000
006A8CE68  ldr      x0, [x0, #0xb08]
006A8CE6C  bl       #0x382bd14 ; 
006A8CE70  mov      w8, #1
006A8CE74  strb     w8, [x21, #0x587]
006A8CE78  adrp     x8, #0x8f38000
006A8CE7C  ldr      x8, [x8, #0xb08]
006A8CE80  ldr      x2, [x8]
006A8CE84  ldrb     w8, [x2, #0x53]
006A8CE88  tbnz     w8, #5, #0x6a8ce94
006A8CE8C  str      w20, [x19, #0x60]
006A8CE90  b        #0x6a8cea4 ; 
006A8CE94  ldr      x8, [x2, #0x60]
006A8CE98  mov      x0, x19
006A8CE9C  mov      w1, w20
006A8CEA0  blr      x8
006A8CEA4  mov      x0, x19
006A8CEA8  mov      x1, xzr
006A8CEAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8CEB0  adrp     x21, #0x959e000
006A8CEB4  ldrb     w8, [x21, #0x588]
006A8CEB8  mov      w20, w0
006A8CEBC  cbnz     w8, #0x6a8ced4
006A8CEC0  adrp     x0, #0x8f38000
006A8CEC4  ldr      x0, [x0, #0xb10]
006A8CEC8  bl       #0x382bd14 ; 
006A8CECC  mov      w8, #1
006A8CED0  strb     w8, [x21, #0x588]
006A8CED4  adrp     x8, #0x8f38000
006A8CED8  ldr      x8, [x8, #0xb10]
006A8CEDC  ldr      x2, [x8]
006A8CEE0  ldrb     w8, [x2, #0x53]
006A8CEE4  tbnz     w8, #5, #0x6a8cef0
006A8CEE8  str      w20, [x19, #0x64]
006A8CEEC  b        #0x6a8cf00 ; 
006A8CEF0  ldr      x8, [x2, #0x60]
006A8CEF4  mov      x0, x19
006A8CEF8  mov      w1, w20
006A8CEFC  blr      x8
006A8CF00  ldp      x20, x19, [sp, #0x10]
006A8CF04  mov      w0, #1
006A8CF08  ldp      x30, x21, [sp], #0x20
006A8CF0C  ret      

