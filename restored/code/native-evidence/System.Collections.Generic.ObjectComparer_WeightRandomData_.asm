; System.Collections.Generic.ObjectComparer<WeightRandomData>$$Compare
; RVA 0x515C0E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00515C0E4  sub      sp, sp, #0xb0
00515C0E8  stp      x30, x23, [sp, #0x80]
00515C0EC  stp      x22, x21, [sp, #0x90]
00515C0F0  stp      x20, x19, [sp, #0xa0]
00515C0F4  adrp     x23, #0x9592000
00515C0F8  adrp     x22, #0x8ee8000
00515C0FC  ldrb     w8, [x23, #0xf2c]
00515C100  ldr      x22, [x22, #0xca0]
00515C104  mov      x19, x3
00515C108  mov      x20, x2
00515C10C  mov      x21, x1
00515C110  tbnz     w8, #0, #0x515c128
00515C114  adrp     x0, #0x8ee8000
00515C118  ldr      x0, [x0, #0xca0]
00515C11C  bl       #0x382bd14 ; 
00515C120  mov      w8, #1
00515C124  strb     w8, [x23, #0xf2c]
00515C128  ldr      x0, [x22]
00515C12C  ldr      w8, [x0, #0xe0]
00515C130  cbnz     w8, #0x515c13c
00515C134  bl       #0x382be8c ; 
00515C138  ldr      x0, [x22]
00515C13C  ldr      x8, [x0, #0xb8]
00515C140  ldp      q2, q0, [x21, #0x10]
00515C144  ldr      x9, [x21, #0x30]
00515C148  ldr      q1, [x21]
00515C14C  ldr      x21, [x8]
00515C150  stp      q2, q0, [sp, #0x50]
00515C154  str      x9, [sp, #0x70]
00515C158  str      q1, [sp, #0x40]
00515C15C  ldr      x8, [x19, #0x20]
00515C160  add      x1, sp, #0x40
00515C164  ldr      x8, [x8, #0xc0]
00515C168  ldr      x0, [x8]
00515C16C  bl       #0x382be94 ; 
00515C170  ldr      x8, [x20, #0x30]
00515C174  ldp      q1, q0, [x20, #0x10]
00515C178  ldr      q2, [x20]
00515C17C  mov      x1, sp
00515C180  str      x8, [sp, #0x30]
00515C184  stp      q1, q0, [sp, #0x10]
00515C188  str      q2, [sp]
00515C18C  ldr      x8, [x19, #0x20]
00515C190  mov      x19, x0
00515C194  ldr      x8, [x8, #0xc0]
00515C198  ldr      x8, [x8]
00515C19C  mov      x0, x8
00515C1A0  bl       #0x382be94 ; 
00515C1A4  cbz      x21, #0x515c1d0
00515C1A8  mov      x2, x0
00515C1AC  mov      x0, x21
00515C1B0  mov      x1, x19
00515C1B4  mov      x3, xzr
00515C1B8  bl       #0x7b92090 ; System.Collections.Comparer$$Compare
00515C1BC  ldp      x20, x19, [sp, #0xa0]
00515C1C0  ldp      x22, x21, [sp, #0x90]
00515C1C4  ldp      x30, x23, [sp, #0x80]
00515C1C8  add      sp, sp, #0xb0
00515C1CC  ret      
00515C1D0  bl       #0x382bfb8 ; 

; System.Collections.Generic.ObjectComparer<WeightRandomData>$$Equals
; RVA 0x515C1D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00515C1D4  stp      x30, x19, [sp, #-0x10]!
00515C1D8  ldr      x8, [x2, #0x20]
00515C1DC  mov      x19, x1
00515C1E0  ldr      x8, [x8, #0xc0]
00515C1E4  ldr      x0, [x8, #8]
00515C1E8  ldrb     w8, [x0, #0x135]
00515C1EC  tbnz     w8, #0, #0x515c1f4
00515C1F0  bl       #0x3a7e60c ; 
00515C1F4  cbz      x19, #0x515c20c
00515C1F8  ldr      x8, [x19]
00515C1FC  ldrb     w9, [x0, #0x130]
00515C200  ldrb     w10, [x8, #0x130]
00515C204  cmp      w10, w9
00515C208  b.hs     #0x515c214
00515C20C  mov      w0, wzr
00515C210  b        #0x515c228 ; 
00515C214  ldr      x8, [x8, #0xc8]
00515C218  add      x8, x8, x9, lsl #3
00515C21C  ldur     x8, [x8, #-8]
00515C220  cmp      x8, x0
00515C224  cset     w0, eq
00515C228  ldp      x30, x19, [sp], #0x10
00515C22C  ret      

; System.Collections.Generic.ObjectComparer<WeightRandomData>$$GetHashCode
; RVA 0x515C230; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00515C230  str      x30, [sp, #-0x10]!
00515C234  cbz      x0, #0x515c268
00515C238  mov      x1, xzr
00515C23C  bl       #0x7c33c40 ; System.Object$$GetType
00515C240  cbz      x0, #0x515c268
00515C244  ldr      x8, [x0]
00515C248  ldr      x9, [x8, #0x208]
00515C24C  ldr      x1, [x8, #0x210]
00515C250  blr      x9
00515C254  cbz      x0, #0x515c268
00515C258  ldr      x8, [x0]
00515C25C  ldp      x2, x1, [x8, #0x158]
00515C260  ldr      x30, [sp], #0x10
00515C264  br       x2
00515C268  bl       #0x382bfb8 ; 

; System.Collections.Generic.ObjectComparer<WeightRandomData>$$.ctor
; RVA 0x515C26C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00515C26C  ldr      x8, [x1, #0x20]
00515C270  ldr      x8, [x8, #0xc0]
00515C274  ldr      x1, [x8, #0x10]
00515C278  b        #0x5c4fa54 ; System.Collections.Generic.Comparer<WeightRandomData>$$.ctor

