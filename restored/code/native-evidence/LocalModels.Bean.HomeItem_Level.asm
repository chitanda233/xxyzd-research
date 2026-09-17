; LocalModels.Bean.HomeItem_Level$$readImpl
; RVA 0x6A99228; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A99228  str      d8, [sp, #-0x30]!
006A9922C  stp      x30, x21, [sp, #0x10]
006A99230  stp      x20, x19, [sp, #0x20]
006A99234  adrp     x20, #0x959e000
006A99238  adrp     x21, #0x8f39000
006A9923C  ldrb     w8, [x20, #0x1db]
006A99240  ldr      x21, [x21, #0x490]
006A99244  mov      x19, x0
006A99248  tbnz     w8, #0, #0x6a99260
006A9924C  adrp     x0, #0x8f39000
006A99250  ldr      x0, [x0, #0x490]
006A99254  bl       #0x382bd14 ; 
006A99258  mov      w8, #1
006A9925C  strb     w8, [x20, #0x1db]
006A99260  ldr      x1, [x21]
006A99264  ldrb     w8, [x1, #0x53]
006A99268  tbnz     w8, #5, #0x6a992b8
006A9926C  mov      x0, x19
006A99270  mov      x1, xzr
006A99274  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A99278  adrp     x21, #0x959e000
006A9927C  ldrb     w8, [x21, #0x607]
006A99280  mov      w20, w0
006A99284  cbnz     w8, #0x6a9929c
006A99288  adrp     x0, #0x8f39000
006A9928C  ldr      x0, [x0, #0x468]
006A99290  bl       #0x382bd14 ; 
006A99294  mov      w8, #1
006A99298  strb     w8, [x21, #0x607]
006A9929C  adrp     x8, #0x8f39000
006A992A0  ldr      x8, [x8, #0x468]
006A992A4  ldr      x2, [x8]
006A992A8  ldrb     w8, [x2, #0x53]
006A992AC  tbnz     w8, #5, #0x6a992d0
006A992B0  str      w20, [x19, #0x20]
006A992B4  b        #0x6a992e0 ; 
006A992B8  ldr      x2, [x1, #0x60]
006A992BC  mov      x0, x19
006A992C0  ldp      x20, x19, [sp, #0x20]
006A992C4  ldp      x30, x21, [sp, #0x10]
006A992C8  ldr      d8, [sp], #0x30
006A992CC  br       x2
006A992D0  ldr      x8, [x2, #0x60]
006A992D4  mov      x0, x19
006A992D8  mov      w1, w20
006A992DC  blr      x8
006A992E0  mov      x0, x19
006A992E4  mov      x1, xzr
006A992E8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A992EC  adrp     x21, #0x959e000
006A992F0  ldrb     w8, [x21, #0x608]
006A992F4  mov      x20, x0
006A992F8  cbnz     w8, #0x6a99310
006A992FC  adrp     x0, #0x8f39000
006A99300  ldr      x0, [x0, #0x478]
006A99304  bl       #0x382bd14 ; 
006A99308  mov      w8, #1
006A9930C  strb     w8, [x21, #0x608]
006A99310  adrp     x8, #0x8f39000
006A99314  ldr      x8, [x8, #0x478]
006A99318  ldr      x2, [x8]
006A9931C  ldrb     w8, [x2, #0x53]
006A99320  tbnz     w8, #5, #0x6a99338
006A99324  mov      x0, x19
006A99328  str      x20, [x0, #0x28]!
006A9932C  mov      x1, x20
006A99330  bl       #0x382bcb8 ; 
006A99334  b        #0x6a99348 ; 
006A99338  ldr      x8, [x2, #0x60]
006A9933C  mov      x0, x19
006A99340  mov      x1, x20
006A99344  blr      x8
006A99348  mov      x0, x19
006A9934C  mov      x1, xzr
006A99350  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006A99354  adrp     x20, #0x959e000
006A99358  ldrb     w8, [x20, #0x609]
006A9935C  mov      v8.16b, v0.16b
006A99360  cbnz     w8, #0x6a99378
006A99364  adrp     x0, #0x8f39000
006A99368  ldr      x0, [x0, #0x488]
006A9936C  bl       #0x382bd14 ; 
006A99370  mov      w8, #1
006A99374  strb     w8, [x20, #0x609]
006A99378  adrp     x8, #0x8f39000
006A9937C  ldr      x8, [x8, #0x488]
006A99380  ldr      x1, [x8]
006A99384  ldrb     w8, [x1, #0x53]
006A99388  tbnz     w8, #5, #0x6a99394
006A9938C  str      s8, [x19, #0x30]
006A99390  b        #0x6a993a4 ; 
006A99394  ldr      x8, [x1, #0x60]
006A99398  mov      x0, x19
006A9939C  mov      v0.16b, v8.16b
006A993A0  blr      x8
006A993A4  ldp      x20, x19, [sp, #0x20]
006A993A8  ldp      x30, x21, [sp, #0x10]
006A993AC  mov      w0, #1
006A993B0  ldr      d8, [sp], #0x30
006A993B4  ret      

