; HotFix.Common.CommonUtils$$CreateAttributeData
; RVA 0x6B5013C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B5013C  stp      x30, x23, [sp, #-0x30]!
006B50140  stp      x22, x21, [sp, #0x10]
006B50144  stp      x20, x19, [sp, #0x20]
006B50148  adrp     x22, #0x959f000
006B5014C  adrp     x23, #0x8f41000
006B50150  ldrb     w8, [x22, #0xc06]
006B50154  ldr      x23, [x23, #0x3a8] ; GLOBAL Method$HotFix.Common.CommonUtils.CreateAttributeData()
006B50158  mov      w19, w2
006B5015C  mov      w20, w1
006B50160  mov      x21, x0
006B50164  tbnz     w8, #0, #0x6b501a0
006B50168  adrp     x0, #0x8f22000
006B5016C  ldr      x0, [x0, #0x130] ; GLOBAL HotFix.Common.CharacterAttributeData_TypeInfo
006B50170  bl       #0x382bd14 ; 
006B50174  adrp     x0, #0x8f41000
006B50178  ldr      x0, [x0, #0x3a8] ; GLOBAL Method$HotFix.Common.CommonUtils.CreateAttributeData()
006B5017C  bl       #0x382bd14 ; 
006B50180  adrp     x0, #0x8f22000
006B50184  ldr      x0, [x0, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
006B50188  bl       #0x382bd14 ; 
006B5018C  adrp     x0, #0x8f41000
006B50190  ldr      x0, [x0, #0x388] ; GLOBAL Method$System.Collections.Generic.List<AttributeString_string>.Clear()
006B50194  bl       #0x382bd14 ; 
006B50198  mov      w8, #1
006B5019C  strb     w8, [x22, #0xc06]
006B501A0  ldr      x3, [x23]
006B501A4  ldrb     w8, [x3, #0x53]
006B501A8  tbnz     w8, #5, #0x6b50244
006B501AC  adrp     x22, #0x8f22000
006B501B0  ldr      x22, [x22, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
006B501B4  ldr      x0, [x22]
006B501B8  ldr      w8, [x0, #0xe0]
006B501BC  cbnz     w8, #0x6b501c4
006B501C0  bl       #0x382be8c ; 
006B501C4  mov      x0, x21
006B501C8  mov      w1, w20
006B501CC  bl       #0x6b4facc ; HotFix.Common.CommonUtils$$FilterOnce
006B501D0  ldr      x8, [x22]
006B501D4  adrp     x9, #0x8f22000
006B501D8  ldr      x8, [x8, #0xb8]
006B501DC  ldr      x9, [x9, #0x130] ; GLOBAL HotFix.Common.CharacterAttributeData_TypeInfo
006B501E0  ldr      x21, [x8]
006B501E4  ldr      x0, [x9]
006B501E8  bl       #0x382bfa0 ; 
006B501EC  and      w2, w19, #1
006B501F0  mov      x1, x21
006B501F4  mov      x20, x0
006B501F8  bl       #0x6b4917c ; HotFix.Common.CharacterAttributeData$$.ctor
006B501FC  ldr      x8, [x22]
006B50200  ldr      x8, [x8, #0xb8]
006B50204  ldr      x8, [x8]
006B50208  cbz      x8, #0x6b50264
006B5020C  ldp      w2, w9, [x8, #0x18]
006B50210  add      w9, w9, #1
006B50214  cmp      w2, #1
006B50218  stp      wzr, w9, [x8, #0x18]
006B5021C  b.lt     #0x6b50230
006B50220  ldr      x0, [x8, #0x10]
006B50224  mov      w1, wzr
006B50228  mov      x3, xzr
006B5022C  bl       #0x7c001d0 ; System.Array$$Clear
006B50230  mov      x0, x20
006B50234  ldp      x20, x19, [sp, #0x20]
006B50238  ldp      x22, x21, [sp, #0x10]
006B5023C  ldp      x30, x23, [sp], #0x30
006B50240  ret      
006B50244  ldr      x4, [x3, #0x60]
006B50248  and      w2, w19, #1
006B5024C  mov      x0, x21
006B50250  mov      w1, w20
006B50254  ldp      x20, x19, [sp, #0x20]
006B50258  ldp      x22, x21, [sp, #0x10]
006B5025C  ldp      x30, x23, [sp], #0x30
006B50260  br       x4
006B50264  bl       #0x382bfb8 ; 

