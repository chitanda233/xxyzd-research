; System.Func<WeightRandomData, CalRuneData>$$.ctor
; RVA 0x48DB0A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB0A0  str      x30, [sp, #-0x30]!
0048DB0A4  stp      x22, x21, [sp, #0x10]
0048DB0A8  stp      x20, x19, [sp, #0x20]
0048DB0AC  ldr      x8, [x2, #8]
0048DB0B0  mov      x19, x0
0048DB0B4  str      x2, [x0, #0x28]
0048DB0B8  mov      x21, x2
0048DB0BC  str      x8, [x0, #0x10]
0048DB0C0  str      x1, [x0, #0x20]!
0048DB0C4  mov      x20, x1
0048DB0C8  bl       #0x382bcb8 ; 
0048DB0CC  ldrb     w22, [x21, #0x52]
0048DB0D0  mov      x0, x21
0048DB0D4  str      x19, [x19, #0x40]
0048DB0D8  bl       #0x382be14 ; 
0048DB0DC  tbz      w0, #0, #0x48db0f8
0048DB0E0  cmp      w22, #1
0048DB0E4  b.ne     #0x48db0fc
0048DB0E8  adrp     x8, #0x3474000
0048DB0EC  add      x8, x8, #0xf70
0048DB0F0  str      x8, [x19, #0x18]
0048DB0F4  b        #0x48db10c ; 
0048DB0F8  cbz      x20, #0x48db128
0048DB0FC  ldr      x8, [x19, #0x10]
0048DB100  ldr      x9, [x19, #0x20]
0048DB104  str      x8, [x19, #0x18]
0048DB108  str      x9, [x19, #0x40]
0048DB10C  adrp     x8, #0x3474000
0048DB110  add      x8, x8, #0xefc
0048DB114  str      x8, [x19, #0x38]
0048DB118  ldp      x20, x19, [sp, #0x20]
0048DB11C  ldp      x22, x21, [sp, #0x10]
0048DB120  ldr      x30, [sp], #0x30
0048DB124  ret      
0048DB128  adrp     x1, #0x1a2d000
0048DB12C  add      x1, x1, #0x4e9
0048DB130  mov      x0, xzr
0048DB134  bl       #0x382bfd4 ; 
0048DB138  mov      x1, xzr
0048DB13C  bl       #0x382be7c ; 

; System.Func<WeightRandomData, CalRuneData>$$Invoke
; RVA 0x48DB140; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB140  sub      sp, sp, #0x50
0048DB144  str      x30, [sp, #0x40]
0048DB148  ldp      q2, q0, [x1, #0x10]
0048DB14C  ldr      x10, [x1, #0x30]
0048DB150  ldr      q1, [x1]
0048DB154  ldr      x9, [x0, #0x18]
0048DB158  ldr      x8, [x0, #0x40]
0048DB15C  str      x10, [sp, #0x30]
0048DB160  stp      q2, q0, [sp, #0x10]
0048DB164  str      q1, [sp]
0048DB168  ldr      x2, [x0, #0x28]
0048DB16C  mov      x1, sp
0048DB170  mov      x0, x8
0048DB174  blr      x9
0048DB178  ldr      x30, [sp, #0x40]
0048DB17C  and      x0, x0, #0xffffffff
0048DB180  add      sp, sp, #0x50
0048DB184  ret      

; System.Func<WeightRandomData, CalRuneData>$$BeginInvoke
; RVA 0x48DB188; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB188  sub      sp, sp, #0x50
0048DB18C  str      x30, [sp, #0x10]
0048DB190  stp      x24, x23, [sp, #0x20]
0048DB194  stp      x22, x21, [sp, #0x30]
0048DB198  stp      x20, x19, [sp, #0x40]
0048DB19C  adrp     x24, #0x9591000
0048DB1A0  adrp     x23, #0x8ee8000
0048DB1A4  ldrb     w8, [x24, #0xfa4]
0048DB1A8  ldr      x23, [x23, #0x3d8]
0048DB1AC  mov      x19, x3
0048DB1B0  mov      x20, x2
0048DB1B4  mov      x22, x1
0048DB1B8  mov      x21, x0
0048DB1BC  tbnz     w8, #0, #0x48db1d4
0048DB1C0  adrp     x0, #0x8ee8000
0048DB1C4  ldr      x0, [x0, #0x3d8]
0048DB1C8  bl       #0x382bd14 ; 
0048DB1CC  mov      w8, #1
0048DB1D0  strb     w8, [x24, #0xfa4]
0048DB1D4  ldr      x0, [x23]
0048DB1D8  mov      x1, x22
0048DB1DC  str      xzr, [sp, #8]
0048DB1E0  bl       #0x382be94 ; 
0048DB1E4  str      x0, [sp]
0048DB1E8  mov      x1, sp
0048DB1EC  mov      x0, x21
0048DB1F0  mov      x2, x20
0048DB1F4  mov      x3, x19
0048DB1F8  bl       #0x382bcc8 ; 
0048DB1FC  ldp      x20, x19, [sp, #0x40]
0048DB200  ldp      x22, x21, [sp, #0x30]
0048DB204  ldp      x24, x23, [sp, #0x20]
0048DB208  ldr      x30, [sp, #0x10]
0048DB20C  add      sp, sp, #0x50
0048DB210  ret      

; System.Func<WeightRandomData, CalRuneData>$$EndInvoke
; RVA 0x48DB214; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB214  str      x30, [sp, #-0x10]!
0048DB218  mov      x0, x1
0048DB21C  mov      x1, xzr
0048DB220  bl       #0x382bccc ; 
0048DB224  cbz      x0, #0x48db238
0048DB228  bl       #0x382be98 ; 
0048DB22C  ldr      w0, [x0]
0048DB230  ldr      x30, [sp], #0x10
0048DB234  ret      
0048DB238  bl       #0x382bfb8 ; 

