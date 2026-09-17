; LocalModels.Bean.EventDiving_DiveDynamic$$readImpl
; RVA 0x6A6DDB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6DDB8  stp      x30, x21, [sp, #-0x20]!
006A6DDBC  stp      x20, x19, [sp, #0x10]
006A6DDC0  adrp     x20, #0x959d000
006A6DDC4  adrp     x21, #0x8f37000
006A6DDC8  ldrb     w8, [x20, #0xd55]
006A6DDCC  ldr      x21, [x21, #0x3a8]
006A6DDD0  mov      x19, x0
006A6DDD4  tbnz     w8, #0, #0x6a6ddec
006A6DDD8  adrp     x0, #0x8f37000
006A6DDDC  ldr      x0, [x0, #0x3a8]
006A6DDE0  bl       #0x382bd14 ; 
006A6DDE4  mov      w8, #1
006A6DDE8  strb     w8, [x20, #0xd55]
006A6DDEC  ldr      x1, [x21]
006A6DDF0  ldrb     w8, [x1, #0x53]
006A6DDF4  tbnz     w8, #5, #0x6a6de44
006A6DDF8  mov      x0, x19
006A6DDFC  mov      x1, xzr
006A6DE00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6DE04  adrp     x21, #0x959e000
006A6DE08  ldrb     w8, [x21, #0x436]
006A6DE0C  mov      w20, w0
006A6DE10  cbnz     w8, #0x6a6de28
006A6DE14  adrp     x0, #0x8f37000
006A6DE18  ldr      x0, [x0, #0x350]
006A6DE1C  bl       #0x382bd14 ; 
006A6DE20  mov      w8, #1
006A6DE24  strb     w8, [x21, #0x436]
006A6DE28  adrp     x8, #0x8f37000
006A6DE2C  ldr      x8, [x8, #0x350]
006A6DE30  ldr      x2, [x8]
006A6DE34  ldrb     w8, [x2, #0x53]
006A6DE38  tbnz     w8, #5, #0x6a6de58
006A6DE3C  str      w20, [x19, #0x20]
006A6DE40  b        #0x6a6de68 ; 
006A6DE44  ldr      x2, [x1, #0x60]
006A6DE48  mov      x0, x19
006A6DE4C  ldp      x20, x19, [sp, #0x10]
006A6DE50  ldp      x30, x21, [sp], #0x20
006A6DE54  br       x2
006A6DE58  ldr      x8, [x2, #0x60]
006A6DE5C  mov      x0, x19
006A6DE60  mov      w1, w20
006A6DE64  blr      x8
006A6DE68  mov      x0, x19
006A6DE6C  mov      x1, xzr
006A6DE70  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6DE74  adrp     x21, #0x959e000
006A6DE78  ldrb     w8, [x21, #0x437]
006A6DE7C  mov      x20, x0
006A6DE80  cbnz     w8, #0x6a6de98
006A6DE84  adrp     x0, #0x8f37000
006A6DE88  ldr      x0, [x0, #0x360]
006A6DE8C  bl       #0x382bd14 ; 
006A6DE90  mov      w8, #1
006A6DE94  strb     w8, [x21, #0x437]
006A6DE98  adrp     x8, #0x8f37000
006A6DE9C  ldr      x8, [x8, #0x360]
006A6DEA0  ldr      x2, [x8]
006A6DEA4  ldrb     w8, [x2, #0x53]
006A6DEA8  tbnz     w8, #5, #0x6a6dec0
006A6DEAC  mov      x0, x19
006A6DEB0  str      x20, [x0, #0x28]!
006A6DEB4  mov      x1, x20
006A6DEB8  bl       #0x382bcb8 ; 
006A6DEBC  b        #0x6a6ded0 ; 
006A6DEC0  ldr      x8, [x2, #0x60]
006A6DEC4  mov      x0, x19
006A6DEC8  mov      x1, x20
006A6DECC  blr      x8
006A6DED0  mov      x0, x19
006A6DED4  mov      x1, xzr
006A6DED8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6DEDC  adrp     x21, #0x959e000
006A6DEE0  ldrb     w8, [x21, #0x438]
006A6DEE4  mov      w20, w0
006A6DEE8  cbnz     w8, #0x6a6df00
006A6DEEC  adrp     x0, #0x8f37000
006A6DEF0  ldr      x0, [x0, #0x370]
006A6DEF4  bl       #0x382bd14 ; 
006A6DEF8  mov      w8, #1
006A6DEFC  strb     w8, [x21, #0x438]
006A6DF00  adrp     x8, #0x8f37000
006A6DF04  ldr      x8, [x8, #0x370]
006A6DF08  ldr      x2, [x8]
006A6DF0C  ldrb     w8, [x2, #0x53]
006A6DF10  tbnz     w8, #5, #0x6a6df1c
006A6DF14  str      w20, [x19, #0x30]
006A6DF18  b        #0x6a6df2c ; 
006A6DF1C  ldr      x8, [x2, #0x60]
006A6DF20  mov      x0, x19
006A6DF24  mov      w1, w20
006A6DF28  blr      x8
006A6DF2C  mov      x0, x19
006A6DF30  mov      x1, xzr
006A6DF34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6DF38  adrp     x21, #0x959e000
006A6DF3C  ldrb     w8, [x21, #0x439]
006A6DF40  mov      w20, w0
006A6DF44  cbnz     w8, #0x6a6df5c
006A6DF48  adrp     x0, #0x8f37000
006A6DF4C  ldr      x0, [x0, #0x380]
006A6DF50  bl       #0x382bd14 ; 
006A6DF54  mov      w8, #1
006A6DF58  strb     w8, [x21, #0x439]
006A6DF5C  adrp     x8, #0x8f37000
006A6DF60  ldr      x8, [x8, #0x380]
006A6DF64  ldr      x2, [x8]
006A6DF68  ldrb     w8, [x2, #0x53]
006A6DF6C  tbnz     w8, #5, #0x6a6df78
006A6DF70  str      w20, [x19, #0x34]
006A6DF74  b        #0x6a6df88 ; 
006A6DF78  ldr      x8, [x2, #0x60]
006A6DF7C  mov      x0, x19
006A6DF80  mov      w1, w20
006A6DF84  blr      x8
006A6DF88  mov      x0, x19
006A6DF8C  mov      x1, xzr
006A6DF90  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6DF94  adrp     x21, #0x959e000
006A6DF98  ldrb     w8, [x21, #0x43a]
006A6DF9C  mov      w20, w0
006A6DFA0  cbnz     w8, #0x6a6dfb8
006A6DFA4  adrp     x0, #0x8f37000
006A6DFA8  ldr      x0, [x0, #0x390]
006A6DFAC  bl       #0x382bd14 ; 
006A6DFB0  mov      w8, #1
006A6DFB4  strb     w8, [x21, #0x43a]
006A6DFB8  adrp     x8, #0x8f37000
006A6DFBC  ldr      x8, [x8, #0x390]
006A6DFC0  ldr      x2, [x8]
006A6DFC4  ldrb     w8, [x2, #0x53]
006A6DFC8  tbnz     w8, #5, #0x6a6dfd4
006A6DFCC  str      w20, [x19, #0x38]
006A6DFD0  b        #0x6a6dfe4 ; 
006A6DFD4  ldr      x8, [x2, #0x60]
006A6DFD8  mov      x0, x19
006A6DFDC  mov      w1, w20
006A6DFE0  blr      x8
006A6DFE4  mov      x0, x19
006A6DFE8  mov      x1, xzr
006A6DFEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6DFF0  adrp     x21, #0x959e000
006A6DFF4  ldrb     w8, [x21, #0x43b]
006A6DFF8  mov      w20, w0
006A6DFFC  cbnz     w8, #0x6a6e014
006A6E000  adrp     x0, #0x8f37000
006A6E004  ldr      x0, [x0, #0x3a0]
006A6E008  bl       #0x382bd14 ; 
006A6E00C  mov      w8, #1
006A6E010  strb     w8, [x21, #0x43b]
006A6E014  adrp     x8, #0x8f37000
006A6E018  ldr      x8, [x8, #0x3a0]
006A6E01C  ldr      x2, [x8]
006A6E020  ldrb     w8, [x2, #0x53]
006A6E024  tbnz     w8, #5, #0x6a6e030
006A6E028  str      w20, [x19, #0x3c]
006A6E02C  b        #0x6a6e040 ; 
006A6E030  ldr      x8, [x2, #0x60]
006A6E034  mov      x0, x19
006A6E038  mov      w1, w20
006A6E03C  blr      x8
006A6E040  ldp      x20, x19, [sp, #0x10]
006A6E044  mov      w0, #1
006A6E048  ldp      x30, x21, [sp], #0x20
006A6E04C  ret      

