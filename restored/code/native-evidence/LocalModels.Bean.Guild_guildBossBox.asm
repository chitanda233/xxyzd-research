; LocalModels.Bean.Guild_guildBossBox$$readImpl
; RVA 0x6A8DC4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8DC4C  stp      x30, x21, [sp, #-0x20]!
006A8DC50  stp      x20, x19, [sp, #0x10]
006A8DC54  adrp     x20, #0x959e000
006A8DC58  adrp     x21, #0x8f38000
006A8DC5C  ldrb     w8, [x20, #0xad]
006A8DC60  ldr      x21, [x21, #0xbe8]
006A8DC64  mov      x19, x0
006A8DC68  tbnz     w8, #0, #0x6a8dc80
006A8DC6C  adrp     x0, #0x8f38000
006A8DC70  ldr      x0, [x0, #0xbe8]
006A8DC74  bl       #0x382bd14 ; 
006A8DC78  mov      w8, #1
006A8DC7C  strb     w8, [x20, #0xad]
006A8DC80  ldr      x1, [x21]
006A8DC84  ldrb     w8, [x1, #0x53]
006A8DC88  tbnz     w8, #5, #0x6a8dcd8
006A8DC8C  mov      x0, x19
006A8DC90  mov      x1, xzr
006A8DC94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8DC98  adrp     x21, #0x959e000
006A8DC9C  ldrb     w8, [x21, #0x58c]
006A8DCA0  mov      w20, w0
006A8DCA4  cbnz     w8, #0x6a8dcbc
006A8DCA8  adrp     x0, #0x8f38000
006A8DCAC  ldr      x0, [x0, #0xb70]
006A8DCB0  bl       #0x382bd14 ; 
006A8DCB4  mov      w8, #1
006A8DCB8  strb     w8, [x21, #0x58c]
006A8DCBC  adrp     x8, #0x8f38000
006A8DCC0  ldr      x8, [x8, #0xb70]
006A8DCC4  ldr      x2, [x8]
006A8DCC8  ldrb     w8, [x2, #0x53]
006A8DCCC  tbnz     w8, #5, #0x6a8dcec
006A8DCD0  str      w20, [x19, #0x20]
006A8DCD4  b        #0x6a8dcfc ; 
006A8DCD8  ldr      x2, [x1, #0x60]
006A8DCDC  mov      x0, x19
006A8DCE0  ldp      x20, x19, [sp, #0x10]
006A8DCE4  ldp      x30, x21, [sp], #0x20
006A8DCE8  br       x2
006A8DCEC  ldr      x8, [x2, #0x60]
006A8DCF0  mov      x0, x19
006A8DCF4  mov      w1, w20
006A8DCF8  blr      x8
006A8DCFC  mov      x0, x19
006A8DD00  mov      x1, xzr
006A8DD04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8DD08  adrp     x21, #0x959e000
006A8DD0C  ldrb     w8, [x21, #0x58d]
006A8DD10  mov      w20, w0
006A8DD14  cbnz     w8, #0x6a8dd2c
006A8DD18  adrp     x0, #0x8f38000
006A8DD1C  ldr      x0, [x0, #0xb80]
006A8DD20  bl       #0x382bd14 ; 
006A8DD24  mov      w8, #1
006A8DD28  strb     w8, [x21, #0x58d]
006A8DD2C  adrp     x8, #0x8f38000
006A8DD30  ldr      x8, [x8, #0xb80]
006A8DD34  ldr      x2, [x8]
006A8DD38  ldrb     w8, [x2, #0x53]
006A8DD3C  tbnz     w8, #5, #0x6a8dd48
006A8DD40  str      w20, [x19, #0x24]
006A8DD44  b        #0x6a8dd58 ; 
006A8DD48  ldr      x8, [x2, #0x60]
006A8DD4C  mov      x0, x19
006A8DD50  mov      w1, w20
006A8DD54  blr      x8
006A8DD58  mov      x0, x19
006A8DD5C  mov      x1, xzr
006A8DD60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8DD64  adrp     x21, #0x959e000
006A8DD68  ldrb     w8, [x21, #0x58e]
006A8DD6C  mov      w20, w0
006A8DD70  cbnz     w8, #0x6a8dd88
006A8DD74  adrp     x0, #0x8f38000
006A8DD78  ldr      x0, [x0, #0xb90]
006A8DD7C  bl       #0x382bd14 ; 
006A8DD80  mov      w8, #1
006A8DD84  strb     w8, [x21, #0x58e]
006A8DD88  adrp     x8, #0x8f38000
006A8DD8C  ldr      x8, [x8, #0xb90]
006A8DD90  ldr      x2, [x8]
006A8DD94  ldrb     w8, [x2, #0x53]
006A8DD98  tbnz     w8, #5, #0x6a8dda4
006A8DD9C  str      w20, [x19, #0x28]
006A8DDA0  b        #0x6a8ddb4 ; 
006A8DDA4  ldr      x8, [x2, #0x60]
006A8DDA8  mov      x0, x19
006A8DDAC  mov      w1, w20
006A8DDB0  blr      x8
006A8DDB4  mov      x0, x19
006A8DDB8  mov      x1, xzr
006A8DDBC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A8DDC0  adrp     x21, #0x959e000
006A8DDC4  ldrb     w8, [x21, #0x58f]
006A8DDC8  mov      x20, x0
006A8DDCC  cbnz     w8, #0x6a8dde4
006A8DDD0  adrp     x0, #0x8f38000
006A8DDD4  ldr      x0, [x0, #0xba0]
006A8DDD8  bl       #0x382bd14 ; 
006A8DDDC  mov      w8, #1
006A8DDE0  strb     w8, [x21, #0x58f]
006A8DDE4  adrp     x8, #0x8f38000
006A8DDE8  ldr      x8, [x8, #0xba0]
006A8DDEC  ldr      x2, [x8]
006A8DDF0  ldrb     w8, [x2, #0x53]
006A8DDF4  tbnz     w8, #5, #0x6a8de0c
006A8DDF8  mov      x0, x19
006A8DDFC  str      x20, [x0, #0x30]!
006A8DE00  mov      x1, x20
006A8DE04  bl       #0x382bcb8 ; 
006A8DE08  b        #0x6a8de1c ; 
006A8DE0C  ldr      x8, [x2, #0x60]
006A8DE10  mov      x0, x19
006A8DE14  mov      x1, x20
006A8DE18  blr      x8
006A8DE1C  mov      x0, x19
006A8DE20  mov      x1, xzr
006A8DE24  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A8DE28  adrp     x21, #0x959e000
006A8DE2C  ldrb     w8, [x21, #0x590]
006A8DE30  mov      x20, x0
006A8DE34  cbnz     w8, #0x6a8de4c
006A8DE38  adrp     x0, #0x8f38000
006A8DE3C  ldr      x0, [x0, #0xbb0]
006A8DE40  bl       #0x382bd14 ; 
006A8DE44  mov      w8, #1
006A8DE48  strb     w8, [x21, #0x590]
006A8DE4C  adrp     x8, #0x8f38000
006A8DE50  ldr      x8, [x8, #0xbb0]
006A8DE54  ldr      x2, [x8]
006A8DE58  ldrb     w8, [x2, #0x53]
006A8DE5C  tbnz     w8, #5, #0x6a8de74
006A8DE60  mov      x0, x19
006A8DE64  str      x20, [x0, #0x38]!
006A8DE68  mov      x1, x20
006A8DE6C  bl       #0x382bcb8 ; 
006A8DE70  b        #0x6a8de84 ; 
006A8DE74  ldr      x8, [x2, #0x60]
006A8DE78  mov      x0, x19
006A8DE7C  mov      x1, x20
006A8DE80  blr      x8
006A8DE84  mov      x0, x19
006A8DE88  mov      x1, xzr
006A8DE8C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8DE90  adrp     x21, #0x959e000
006A8DE94  ldrb     w8, [x21, #0x591]
006A8DE98  mov      x20, x0
006A8DE9C  cbnz     w8, #0x6a8deb4
006A8DEA0  adrp     x0, #0x8f38000
006A8DEA4  ldr      x0, [x0, #0xbc0]
006A8DEA8  bl       #0x382bd14 ; 
006A8DEAC  mov      w8, #1
006A8DEB0  strb     w8, [x21, #0x591]
006A8DEB4  adrp     x8, #0x8f38000
006A8DEB8  ldr      x8, [x8, #0xbc0]
006A8DEBC  ldr      x2, [x8]
006A8DEC0  ldrb     w8, [x2, #0x53]
006A8DEC4  tbnz     w8, #5, #0x6a8dedc
006A8DEC8  mov      x0, x19
006A8DECC  str      x20, [x0, #0x40]!
006A8DED0  mov      x1, x20
006A8DED4  bl       #0x382bcb8 ; 
006A8DED8  b        #0x6a8deec ; 
006A8DEDC  ldr      x8, [x2, #0x60]
006A8DEE0  mov      x0, x19
006A8DEE4  mov      x1, x20
006A8DEE8  blr      x8
006A8DEEC  mov      x0, x19
006A8DEF0  mov      x1, xzr
006A8DEF4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8DEF8  adrp     x21, #0x959e000
006A8DEFC  ldrb     w8, [x21, #0x592]
006A8DF00  mov      x20, x0
006A8DF04  cbnz     w8, #0x6a8df1c
006A8DF08  adrp     x0, #0x8f38000
006A8DF0C  ldr      x0, [x0, #0xbd0]
006A8DF10  bl       #0x382bd14 ; 
006A8DF14  mov      w8, #1
006A8DF18  strb     w8, [x21, #0x592]
006A8DF1C  adrp     x8, #0x8f38000
006A8DF20  ldr      x8, [x8, #0xbd0]
006A8DF24  ldr      x2, [x8]
006A8DF28  ldrb     w8, [x2, #0x53]
006A8DF2C  tbnz     w8, #5, #0x6a8df44
006A8DF30  mov      x0, x19
006A8DF34  str      x20, [x0, #0x48]!
006A8DF38  mov      x1, x20
006A8DF3C  bl       #0x382bcb8 ; 
006A8DF40  b        #0x6a8df54 ; 
006A8DF44  ldr      x8, [x2, #0x60]
006A8DF48  mov      x0, x19
006A8DF4C  mov      x1, x20
006A8DF50  blr      x8
006A8DF54  mov      x0, x19
006A8DF58  mov      x1, xzr
006A8DF5C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8DF60  adrp     x21, #0x959e000
006A8DF64  ldrb     w8, [x21, #0x593]
006A8DF68  mov      x20, x0
006A8DF6C  cbnz     w8, #0x6a8df84
006A8DF70  adrp     x0, #0x8f38000
006A8DF74  ldr      x0, [x0, #0xbe0]
006A8DF78  bl       #0x382bd14 ; 
006A8DF7C  mov      w8, #1
006A8DF80  strb     w8, [x21, #0x593]
006A8DF84  adrp     x8, #0x8f38000
006A8DF88  ldr      x8, [x8, #0xbe0]
006A8DF8C  ldr      x2, [x8]
006A8DF90  ldrb     w8, [x2, #0x53]
006A8DF94  tbnz     w8, #5, #0x6a8dfac
006A8DF98  str      x20, [x19, #0x50]!
006A8DF9C  mov      x0, x19
006A8DFA0  mov      x1, x20
006A8DFA4  bl       #0x382bcb8 ; 
006A8DFA8  b        #0x6a8dfbc ; 
006A8DFAC  ldr      x8, [x2, #0x60]
006A8DFB0  mov      x0, x19
006A8DFB4  mov      x1, x20
006A8DFB8  blr      x8
006A8DFBC  ldp      x20, x19, [sp, #0x10]
006A8DFC0  mov      w0, #1
006A8DFC4  ldp      x30, x21, [sp], #0x20
006A8DFC8  ret      

