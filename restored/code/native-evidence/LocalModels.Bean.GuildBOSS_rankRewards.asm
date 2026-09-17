; LocalModels.Bean.GuildBOSS_rankRewards$$readImpl
; RVA 0x6A891C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A891C0  stp      x30, x21, [sp, #-0x20]!
006A891C4  stp      x20, x19, [sp, #0x10]
006A891C8  adrp     x20, #0x959e000
006A891CC  adrp     x21, #0x8f38000
006A891D0  ldrb     w8, [x20, #0x2e]
006A891D4  ldr      x21, [x21, #0x8b0]
006A891D8  mov      x19, x0
006A891DC  tbnz     w8, #0, #0x6a891f4
006A891E0  adrp     x0, #0x8f38000
006A891E4  ldr      x0, [x0, #0x8b0]
006A891E8  bl       #0x382bd14 ; 
006A891EC  mov      w8, #1
006A891F0  strb     w8, [x20, #0x2e]
006A891F4  ldr      x1, [x21]
006A891F8  ldrb     w8, [x1, #0x53]
006A891FC  tbnz     w8, #5, #0x6a8924c
006A89200  mov      x0, x19
006A89204  mov      x1, xzr
006A89208  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8920C  adrp     x21, #0x959e000
006A89210  ldrb     w8, [x21, #0x55b]
006A89214  mov      w20, w0
006A89218  cbnz     w8, #0x6a89230
006A8921C  adrp     x0, #0x8f38000
006A89220  ldr      x0, [x0, #0x878]
006A89224  bl       #0x382bd14 ; 
006A89228  mov      w8, #1
006A8922C  strb     w8, [x21, #0x55b]
006A89230  adrp     x8, #0x8f38000
006A89234  ldr      x8, [x8, #0x878]
006A89238  ldr      x2, [x8]
006A8923C  ldrb     w8, [x2, #0x53]
006A89240  tbnz     w8, #5, #0x6a89260
006A89244  str      w20, [x19, #0x20]
006A89248  b        #0x6a89270 ; 
006A8924C  ldr      x2, [x1, #0x60]
006A89250  mov      x0, x19
006A89254  ldp      x20, x19, [sp, #0x10]
006A89258  ldp      x30, x21, [sp], #0x20
006A8925C  br       x2
006A89260  ldr      x8, [x2, #0x60]
006A89264  mov      x0, x19
006A89268  mov      w1, w20
006A8926C  blr      x8
006A89270  mov      x0, x19
006A89274  mov      x1, xzr
006A89278  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8927C  adrp     x21, #0x959e000
006A89280  ldrb     w8, [x21, #0x55c]
006A89284  mov      w20, w0
006A89288  cbnz     w8, #0x6a892a0
006A8928C  adrp     x0, #0x8f38000
006A89290  ldr      x0, [x0, #0x888]
006A89294  bl       #0x382bd14 ; 
006A89298  mov      w8, #1
006A8929C  strb     w8, [x21, #0x55c]
006A892A0  adrp     x8, #0x8f38000
006A892A4  ldr      x8, [x8, #0x888]
006A892A8  ldr      x2, [x8]
006A892AC  ldrb     w8, [x2, #0x53]
006A892B0  tbnz     w8, #5, #0x6a892bc
006A892B4  str      w20, [x19, #0x24]
006A892B8  b        #0x6a892cc ; 
006A892BC  ldr      x8, [x2, #0x60]
006A892C0  mov      x0, x19
006A892C4  mov      w1, w20
006A892C8  blr      x8
006A892CC  mov      x0, x19
006A892D0  mov      x1, xzr
006A892D4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A892D8  adrp     x21, #0x959e000
006A892DC  ldrb     w8, [x21, #0x55d]
006A892E0  mov      x20, x0
006A892E4  cbnz     w8, #0x6a892fc
006A892E8  adrp     x0, #0x8f38000
006A892EC  ldr      x0, [x0, #0x898]
006A892F0  bl       #0x382bd14 ; 
006A892F4  mov      w8, #1
006A892F8  strb     w8, [x21, #0x55d]
006A892FC  adrp     x8, #0x8f38000
006A89300  ldr      x8, [x8, #0x898]
006A89304  ldr      x2, [x8]
006A89308  ldrb     w8, [x2, #0x53]
006A8930C  tbnz     w8, #5, #0x6a89324
006A89310  mov      x0, x19
006A89314  str      x20, [x0, #0x28]!
006A89318  mov      x1, x20
006A8931C  bl       #0x382bcb8 ; 
006A89320  b        #0x6a89334 ; 
006A89324  ldr      x8, [x2, #0x60]
006A89328  mov      x0, x19
006A8932C  mov      x1, x20
006A89330  blr      x8
006A89334  mov      x0, x19
006A89338  mov      x1, xzr
006A8933C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A89340  adrp     x21, #0x959e000
006A89344  ldrb     w8, [x21, #0x55e]
006A89348  mov      x20, x0
006A8934C  cbnz     w8, #0x6a89364
006A89350  adrp     x0, #0x8f38000
006A89354  ldr      x0, [x0, #0x8a8]
006A89358  bl       #0x382bd14 ; 
006A8935C  mov      w8, #1
006A89360  strb     w8, [x21, #0x55e]
006A89364  adrp     x8, #0x8f38000
006A89368  ldr      x8, [x8, #0x8a8]
006A8936C  ldr      x2, [x8]
006A89370  ldrb     w8, [x2, #0x53]
006A89374  tbnz     w8, #5, #0x6a8938c
006A89378  str      x20, [x19, #0x30]!
006A8937C  mov      x0, x19
006A89380  mov      x1, x20
006A89384  bl       #0x382bcb8 ; 
006A89388  b        #0x6a8939c ; 
006A8938C  ldr      x8, [x2, #0x60]
006A89390  mov      x0, x19
006A89394  mov      x1, x20
006A89398  blr      x8
006A8939C  ldp      x20, x19, [sp, #0x10]
006A893A0  mov      w0, #1
006A893A4  ldp      x30, x21, [sp], #0x20
006A893A8  ret      

