; LocalModels.Bean.GamePreload_PreloadEffect$$readImpl
; RVA 0x6A811B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A811B0  stp      x30, x21, [sp, #-0x20]!
006A811B4  stp      x20, x19, [sp, #0x10]
006A811B8  adrp     x20, #0x959d000
006A811BC  adrp     x21, #0x8f38000
006A811C0  ldrb     w8, [x20, #0xf54]
006A811C4  ldr      x21, [x21, #0x290]
006A811C8  mov      x19, x0
006A811CC  tbnz     w8, #0, #0x6a811e4
006A811D0  adrp     x0, #0x8f38000
006A811D4  ldr      x0, [x0, #0x290]
006A811D8  bl       #0x382bd14 ; 
006A811DC  mov      w8, #1
006A811E0  strb     w8, [x20, #0xf54]
006A811E4  ldr      x1, [x21]
006A811E8  ldrb     w8, [x1, #0x53]
006A811EC  tbnz     w8, #5, #0x6a8123c
006A811F0  mov      x0, x19
006A811F4  mov      x1, xzr
006A811F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A811FC  adrp     x21, #0x959e000
006A81200  ldrb     w8, [x21, #0x50b]
006A81204  mov      w20, w0
006A81208  cbnz     w8, #0x6a81220
006A8120C  adrp     x0, #0x8f38000
006A81210  ldr      x0, [x0, #0x278]
006A81214  bl       #0x382bd14 ; 
006A81218  mov      w8, #1
006A8121C  strb     w8, [x21, #0x50b]
006A81220  adrp     x8, #0x8f38000
006A81224  ldr      x8, [x8, #0x278]
006A81228  ldr      x2, [x8]
006A8122C  ldrb     w8, [x2, #0x53]
006A81230  tbnz     w8, #5, #0x6a81250
006A81234  str      w20, [x19, #0x20]
006A81238  b        #0x6a81260 ; 
006A8123C  ldr      x2, [x1, #0x60]
006A81240  mov      x0, x19
006A81244  ldp      x20, x19, [sp, #0x10]
006A81248  ldp      x30, x21, [sp], #0x20
006A8124C  br       x2
006A81250  ldr      x8, [x2, #0x60]
006A81254  mov      x0, x19
006A81258  mov      w1, w20
006A8125C  blr      x8
006A81260  mov      x0, x19
006A81264  mov      x1, xzr
006A81268  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8126C  adrp     x21, #0x959e000
006A81270  ldrb     w8, [x21, #0x50c]
006A81274  mov      w20, w0
006A81278  cbnz     w8, #0x6a81290
006A8127C  adrp     x0, #0x8f38000
006A81280  ldr      x0, [x0, #0x288]
006A81284  bl       #0x382bd14 ; 
006A81288  mov      w8, #1
006A8128C  strb     w8, [x21, #0x50c]
006A81290  adrp     x8, #0x8f38000
006A81294  ldr      x8, [x8, #0x288]
006A81298  ldr      x2, [x8]
006A8129C  ldrb     w8, [x2, #0x53]
006A812A0  tbnz     w8, #5, #0x6a812ac
006A812A4  str      w20, [x19, #0x24]
006A812A8  b        #0x6a812bc ; 
006A812AC  ldr      x8, [x2, #0x60]
006A812B0  mov      x0, x19
006A812B4  mov      w1, w20
006A812B8  blr      x8
006A812BC  ldp      x20, x19, [sp, #0x10]
006A812C0  mov      w0, #1
006A812C4  ldp      x30, x21, [sp], #0x20
006A812C8  ret      

