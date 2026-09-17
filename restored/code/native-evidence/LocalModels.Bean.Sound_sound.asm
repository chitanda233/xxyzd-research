; LocalModels.Bean.Sound_sound$$readImpl
; RVA 0x6B0F08C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0F08C  str      d8, [sp, #-0x30]!
006B0F090  stp      x30, x21, [sp, #0x10]
006B0F094  stp      x20, x19, [sp, #0x20]
006B0F098  adrp     x20, #0x959f000
006B0F09C  adrp     x21, #0x8f3e000
006B0F0A0  ldrb     w8, [x20, #0x510]
006B0F0A4  ldr      x21, [x21, #0xb28]
006B0F0A8  mov      x19, x0
006B0F0AC  tbnz     w8, #0, #0x6b0f0c4
006B0F0B0  adrp     x0, #0x8f3e000
006B0F0B4  ldr      x0, [x0, #0xb28]
006B0F0B8  bl       #0x382bd14 ; 
006B0F0BC  mov      w8, #1
006B0F0C0  strb     w8, [x20, #0x510]
006B0F0C4  ldr      x1, [x21]
006B0F0C8  ldrb     w8, [x1, #0x53]
006B0F0CC  tbnz     w8, #5, #0x6b0f11c
006B0F0D0  mov      x0, x19
006B0F0D4  mov      x1, xzr
006B0F0D8  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006B0F0DC  adrp     x21, #0x959f000
006B0F0E0  ldrb     w8, [x21, #0x998]
006B0F0E4  mov      x20, x0
006B0F0E8  cbnz     w8, #0x6b0f100
006B0F0EC  adrp     x0, #0x8f3e000
006B0F0F0  ldr      x0, [x0, #0xb10]
006B0F0F4  bl       #0x382bd14 ; 
006B0F0F8  mov      w8, #1
006B0F0FC  strb     w8, [x21, #0x998]
006B0F100  adrp     x8, #0x8f3e000
006B0F104  ldr      x8, [x8, #0xb10]
006B0F108  ldr      x2, [x8]
006B0F10C  ldrb     w8, [x2, #0x53]
006B0F110  tbnz     w8, #5, #0x6b0f134
006B0F114  str      x20, [x19, #0x20]
006B0F118  b        #0x6b0f144 ; 
006B0F11C  ldr      x2, [x1, #0x60]
006B0F120  mov      x0, x19
006B0F124  ldp      x20, x19, [sp, #0x20]
006B0F128  ldp      x30, x21, [sp, #0x10]
006B0F12C  ldr      d8, [sp], #0x30
006B0F130  br       x2
006B0F134  ldr      x8, [x2, #0x60]
006B0F138  mov      x0, x19
006B0F13C  mov      x1, x20
006B0F140  blr      x8
006B0F144  mov      x0, x19
006B0F148  mov      x1, xzr
006B0F14C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0F150  adrp     x21, #0x959f000
006B0F154  ldrb     w8, [x21, #0x999]
006B0F158  mov      x20, x0
006B0F15C  cbnz     w8, #0x6b0f174
006B0F160  adrp     x0, #0x8f3e000
006B0F164  ldr      x0, [x0, #0xb18]
006B0F168  bl       #0x382bd14 ; 
006B0F16C  mov      w8, #1
006B0F170  strb     w8, [x21, #0x999]
006B0F174  adrp     x8, #0x8f3e000
006B0F178  ldr      x8, [x8, #0xb18]
006B0F17C  ldr      x2, [x8]
006B0F180  ldrb     w8, [x2, #0x53]
006B0F184  tbnz     w8, #5, #0x6b0f19c
006B0F188  mov      x0, x19
006B0F18C  str      x20, [x0, #0x28]!
006B0F190  mov      x1, x20
006B0F194  bl       #0x382bcb8 ; 
006B0F198  b        #0x6b0f1ac ; 
006B0F19C  ldr      x8, [x2, #0x60]
006B0F1A0  mov      x0, x19
006B0F1A4  mov      x1, x20
006B0F1A8  blr      x8
006B0F1AC  mov      x0, x19
006B0F1B0  mov      x1, xzr
006B0F1B4  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006B0F1B8  adrp     x20, #0x959f000
006B0F1BC  ldrb     w8, [x20, #0x99a]
006B0F1C0  mov      v8.16b, v0.16b
006B0F1C4  cbnz     w8, #0x6b0f1dc
006B0F1C8  adrp     x0, #0x8f3e000
006B0F1CC  ldr      x0, [x0, #0xb20]
006B0F1D0  bl       #0x382bd14 ; 
006B0F1D4  mov      w8, #1
006B0F1D8  strb     w8, [x20, #0x99a]
006B0F1DC  adrp     x8, #0x8f3e000
006B0F1E0  ldr      x8, [x8, #0xb20]
006B0F1E4  ldr      x1, [x8]
006B0F1E8  ldrb     w8, [x1, #0x53]
006B0F1EC  tbnz     w8, #5, #0x6b0f1f8
006B0F1F0  str      s8, [x19, #0x30]
006B0F1F4  b        #0x6b0f208 ; 
006B0F1F8  ldr      x8, [x1, #0x60]
006B0F1FC  mov      x0, x19
006B0F200  mov      v0.16b, v8.16b
006B0F204  blr      x8
006B0F208  ldp      x20, x19, [sp, #0x20]
006B0F20C  ldp      x30, x21, [sp, #0x10]
006B0F210  mov      w0, #1
006B0F214  ldr      d8, [sp], #0x30
006B0F218  ret      

