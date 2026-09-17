; LocalModels.Bean.CrossArena_CrossArenaTime$$readImpl
; RVA 0x6A57830; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A57830  stp      x30, x21, [sp, #-0x20]!
006A57834  stp      x20, x19, [sp, #0x10]
006A57838  adrp     x20, #0x959d000
006A5783C  adrp     x21, #0x8f36000
006A57840  ldrb     w8, [x20, #0xb0c]
006A57844  ldr      x21, [x21, #0x338]
006A57848  mov      x19, x0
006A5784C  tbnz     w8, #0, #0x6a57864
006A57850  adrp     x0, #0x8f36000
006A57854  ldr      x0, [x0, #0x338]
006A57858  bl       #0x382bd14 ; 
006A5785C  mov      w8, #1
006A57860  strb     w8, [x20, #0xb0c]
006A57864  ldr      x1, [x21]
006A57868  ldrb     w8, [x1, #0x53]
006A5786C  tbnz     w8, #5, #0x6a578bc
006A57870  mov      x0, x19
006A57874  mov      x1, xzr
006A57878  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5787C  adrp     x21, #0x959e000
006A57880  ldrb     w8, [x21, #0x33a]
006A57884  mov      w20, w0
006A57888  cbnz     w8, #0x6a578a0
006A5788C  adrp     x0, #0x8f36000
006A57890  ldr      x0, [x0, #0x310]
006A57894  bl       #0x382bd14 ; 
006A57898  mov      w8, #1
006A5789C  strb     w8, [x21, #0x33a]
006A578A0  adrp     x8, #0x8f36000
006A578A4  ldr      x8, [x8, #0x310]
006A578A8  ldr      x2, [x8]
006A578AC  ldrb     w8, [x2, #0x53]
006A578B0  tbnz     w8, #5, #0x6a578d0
006A578B4  str      w20, [x19, #0x20]
006A578B8  b        #0x6a578e0 ; 
006A578BC  ldr      x2, [x1, #0x60]
006A578C0  mov      x0, x19
006A578C4  ldp      x20, x19, [sp, #0x10]
006A578C8  ldp      x30, x21, [sp], #0x20
006A578CC  br       x2
006A578D0  ldr      x8, [x2, #0x60]
006A578D4  mov      x0, x19
006A578D8  mov      w1, w20
006A578DC  blr      x8
006A578E0  mov      x0, x19
006A578E4  mov      x1, xzr
006A578E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A578EC  adrp     x21, #0x959e000
006A578F0  ldrb     w8, [x21, #0x33b]
006A578F4  mov      x20, x0
006A578F8  cbnz     w8, #0x6a57910
006A578FC  adrp     x0, #0x8f36000
006A57900  ldr      x0, [x0, #0x320]
006A57904  bl       #0x382bd14 ; 
006A57908  mov      w8, #1
006A5790C  strb     w8, [x21, #0x33b]
006A57910  adrp     x8, #0x8f36000
006A57914  ldr      x8, [x8, #0x320]
006A57918  ldr      x2, [x8]
006A5791C  ldrb     w8, [x2, #0x53]
006A57920  tbnz     w8, #5, #0x6a57938
006A57924  mov      x0, x19
006A57928  str      x20, [x0, #0x28]!
006A5792C  mov      x1, x20
006A57930  bl       #0x382bcb8 ; 
006A57934  b        #0x6a57948 ; 
006A57938  ldr      x8, [x2, #0x60]
006A5793C  mov      x0, x19
006A57940  mov      x1, x20
006A57944  blr      x8
006A57948  mov      x0, x19
006A5794C  mov      x1, xzr
006A57950  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A57954  adrp     x21, #0x959e000
006A57958  ldrb     w8, [x21, #0x33c]
006A5795C  mov      x20, x0
006A57960  cbnz     w8, #0x6a57978
006A57964  adrp     x0, #0x8f36000
006A57968  ldr      x0, [x0, #0x330]
006A5796C  bl       #0x382bd14 ; 
006A57970  mov      w8, #1
006A57974  strb     w8, [x21, #0x33c]
006A57978  adrp     x8, #0x8f36000
006A5797C  ldr      x8, [x8, #0x330]
006A57980  ldr      x2, [x8]
006A57984  ldrb     w8, [x2, #0x53]
006A57988  tbnz     w8, #5, #0x6a579a0
006A5798C  str      x20, [x19, #0x30]!
006A57990  mov      x0, x19
006A57994  mov      x1, x20
006A57998  bl       #0x382bcb8 ; 
006A5799C  b        #0x6a579b0 ; 
006A579A0  ldr      x8, [x2, #0x60]
006A579A4  mov      x0, x19
006A579A8  mov      x1, x20
006A579AC  blr      x8
006A579B0  ldp      x20, x19, [sp, #0x10]
006A579B4  mov      w0, #1
006A579B8  ldp      x30, x21, [sp], #0x20
006A579BC  ret      

