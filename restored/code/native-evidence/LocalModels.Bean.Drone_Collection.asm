; LocalModels.Bean.Drone_Collection$$readImpl
; RVA 0x6A5DC9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5DC9C  stp      x30, x21, [sp, #-0x20]!
006A5DCA0  stp      x20, x19, [sp, #0x10]
006A5DCA4  adrp     x20, #0x959d000
006A5DCA8  adrp     x21, #0x8f36000
006A5DCAC  ldrb     w8, [x20, #0xbb3]
006A5DCB0  ldr      x21, [x21, #0x818]
006A5DCB4  mov      x19, x0
006A5DCB8  tbnz     w8, #0, #0x6a5dcd0
006A5DCBC  adrp     x0, #0x8f36000
006A5DCC0  ldr      x0, [x0, #0x818]
006A5DCC4  bl       #0x382bd14 ; 
006A5DCC8  mov      w8, #1
006A5DCCC  strb     w8, [x20, #0xbb3]
006A5DCD0  ldr      x1, [x21]
006A5DCD4  ldrb     w8, [x1, #0x53]
006A5DCD8  tbnz     w8, #5, #0x6a5dd28
006A5DCDC  mov      x0, x19
006A5DCE0  mov      x1, xzr
006A5DCE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5DCE8  adrp     x21, #0x959e000
006A5DCEC  ldrb     w8, [x21, #0x37d]
006A5DCF0  mov      w20, w0
006A5DCF4  cbnz     w8, #0x6a5dd0c
006A5DCF8  adrp     x0, #0x8f36000
006A5DCFC  ldr      x0, [x0, #0x7c8]
006A5DD00  bl       #0x382bd14 ; 
006A5DD04  mov      w8, #1
006A5DD08  strb     w8, [x21, #0x37d]
006A5DD0C  adrp     x8, #0x8f36000
006A5DD10  ldr      x8, [x8, #0x7c8]
006A5DD14  ldr      x2, [x8]
006A5DD18  ldrb     w8, [x2, #0x53]
006A5DD1C  tbnz     w8, #5, #0x6a5dd3c
006A5DD20  str      w20, [x19, #0x20]
006A5DD24  b        #0x6a5dd4c ; 
006A5DD28  ldr      x2, [x1, #0x60]
006A5DD2C  mov      x0, x19
006A5DD30  ldp      x20, x19, [sp, #0x10]
006A5DD34  ldp      x30, x21, [sp], #0x20
006A5DD38  br       x2
006A5DD3C  ldr      x8, [x2, #0x60]
006A5DD40  mov      x0, x19
006A5DD44  mov      w1, w20
006A5DD48  blr      x8
006A5DD4C  mov      x0, x19
006A5DD50  mov      x1, xzr
006A5DD54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5DD58  adrp     x21, #0x959e000
006A5DD5C  ldrb     w8, [x21, #0x37e]
006A5DD60  mov      w20, w0
006A5DD64  cbnz     w8, #0x6a5dd7c
006A5DD68  adrp     x0, #0x8f36000
006A5DD6C  ldr      x0, [x0, #0x7d8]
006A5DD70  bl       #0x382bd14 ; 
006A5DD74  mov      w8, #1
006A5DD78  strb     w8, [x21, #0x37e]
006A5DD7C  adrp     x8, #0x8f36000
006A5DD80  ldr      x8, [x8, #0x7d8]
006A5DD84  ldr      x2, [x8]
006A5DD88  ldrb     w8, [x2, #0x53]
006A5DD8C  tbnz     w8, #5, #0x6a5dd98
006A5DD90  str      w20, [x19, #0x24]
006A5DD94  b        #0x6a5dda8 ; 
006A5DD98  ldr      x8, [x2, #0x60]
006A5DD9C  mov      x0, x19
006A5DDA0  mov      w1, w20
006A5DDA4  blr      x8
006A5DDA8  mov      x0, x19
006A5DDAC  mov      x1, xzr
006A5DDB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5DDB4  adrp     x21, #0x959e000
006A5DDB8  ldrb     w8, [x21, #0x37f]
006A5DDBC  mov      w20, w0
006A5DDC0  cbnz     w8, #0x6a5ddd8
006A5DDC4  adrp     x0, #0x8f36000
006A5DDC8  ldr      x0, [x0, #0x7e8]
006A5DDCC  bl       #0x382bd14 ; 
006A5DDD0  mov      w8, #1
006A5DDD4  strb     w8, [x21, #0x37f]
006A5DDD8  adrp     x8, #0x8f36000
006A5DDDC  ldr      x8, [x8, #0x7e8]
006A5DDE0  ldr      x2, [x8]
006A5DDE4  ldrb     w8, [x2, #0x53]
006A5DDE8  tbnz     w8, #5, #0x6a5ddf4
006A5DDEC  str      w20, [x19, #0x28]
006A5DDF0  b        #0x6a5de04 ; 
006A5DDF4  ldr      x8, [x2, #0x60]
006A5DDF8  mov      x0, x19
006A5DDFC  mov      w1, w20
006A5DE00  blr      x8
006A5DE04  mov      x0, x19
006A5DE08  mov      x1, xzr
006A5DE0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5DE10  adrp     x21, #0x959e000
006A5DE14  ldrb     w8, [x21, #0x380]
006A5DE18  mov      w20, w0
006A5DE1C  cbnz     w8, #0x6a5de34
006A5DE20  adrp     x0, #0x8f36000
006A5DE24  ldr      x0, [x0, #0x7f8]
006A5DE28  bl       #0x382bd14 ; 
006A5DE2C  mov      w8, #1
006A5DE30  strb     w8, [x21, #0x380]
006A5DE34  adrp     x8, #0x8f36000
006A5DE38  ldr      x8, [x8, #0x7f8]
006A5DE3C  ldr      x2, [x8]
006A5DE40  ldrb     w8, [x2, #0x53]
006A5DE44  tbnz     w8, #5, #0x6a5de50
006A5DE48  str      w20, [x19, #0x2c]
006A5DE4C  b        #0x6a5de60 ; 
006A5DE50  ldr      x8, [x2, #0x60]
006A5DE54  mov      x0, x19
006A5DE58  mov      w1, w20
006A5DE5C  blr      x8
006A5DE60  mov      x0, x19
006A5DE64  mov      x1, xzr
006A5DE68  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5DE6C  adrp     x21, #0x959e000
006A5DE70  ldrb     w8, [x21, #0x381]
006A5DE74  mov      x20, x0
006A5DE78  cbnz     w8, #0x6a5de90
006A5DE7C  adrp     x0, #0x8f36000
006A5DE80  ldr      x0, [x0, #0x800]
006A5DE84  bl       #0x382bd14 ; 
006A5DE88  mov      w8, #1
006A5DE8C  strb     w8, [x21, #0x381]
006A5DE90  adrp     x8, #0x8f36000
006A5DE94  ldr      x8, [x8, #0x800]
006A5DE98  ldr      x2, [x8]
006A5DE9C  ldrb     w8, [x2, #0x53]
006A5DEA0  tbnz     w8, #5, #0x6a5deb8
006A5DEA4  mov      x0, x19
006A5DEA8  str      x20, [x0, #0x30]!
006A5DEAC  mov      x1, x20
006A5DEB0  bl       #0x382bcb8 ; 
006A5DEB4  b        #0x6a5dec8 ; 
006A5DEB8  ldr      x8, [x2, #0x60]
006A5DEBC  mov      x0, x19
006A5DEC0  mov      x1, x20
006A5DEC4  blr      x8
006A5DEC8  mov      x0, x19
006A5DECC  mov      x1, xzr
006A5DED0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5DED4  adrp     x21, #0x959e000
006A5DED8  ldrb     w8, [x21, #0x382]
006A5DEDC  mov      x20, x0
006A5DEE0  cbnz     w8, #0x6a5def8
006A5DEE4  adrp     x0, #0x8f36000
006A5DEE8  ldr      x0, [x0, #0x810]
006A5DEEC  bl       #0x382bd14 ; 
006A5DEF0  mov      w8, #1
006A5DEF4  strb     w8, [x21, #0x382]
006A5DEF8  adrp     x8, #0x8f36000
006A5DEFC  ldr      x8, [x8, #0x810]
006A5DF00  ldr      x2, [x8]
006A5DF04  ldrb     w8, [x2, #0x53]
006A5DF08  tbnz     w8, #5, #0x6a5df20
006A5DF0C  str      x20, [x19, #0x38]!
006A5DF10  mov      x0, x19
006A5DF14  mov      x1, x20
006A5DF18  bl       #0x382bcb8 ; 
006A5DF1C  b        #0x6a5df30 ; 
006A5DF20  ldr      x8, [x2, #0x60]
006A5DF24  mov      x0, x19
006A5DF28  mov      x1, x20
006A5DF2C  blr      x8
006A5DF30  ldp      x20, x19, [sp, #0x10]
006A5DF34  mov      w0, #1
006A5DF38  ldp      x30, x21, [sp], #0x20
006A5DF3C  ret      

