; LocalModelEx$$CheckSkillIndexIsOpen
; RVA 0x64C97A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C97A8  str      x30, [sp, #-0x30]!
0064C97AC  stp      x22, x21, [sp, #0x10]
0064C97B0  stp      x20, x19, [sp, #0x20]
0064C97B4  adrp     x21, #0x9597000
0064C97B8  adrp     x22, #0x8ef9000
0064C97BC  ldrb     w8, [x21, #0xfb8]
0064C97C0  ldr      x22, [x22, #0xf68] ; GLOBAL Method$LocalModelEx.CheckSkillIndexIsOpen() @ 0x928a800
0064C97C4  mov      w19, w1
0064C97C8  mov      w20, w0
0064C97CC  tbnz     w8, #0, #0x64c97f0
0064C97D0  adrp     x0, #0x8ee8000
0064C97D4  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064C97D8  bl       #0x382bd14 ; 
0064C97DC  adrp     x0, #0x8ef9000
0064C97E0  ldr      x0, [x0, #0xf68] ; GLOBAL Method$LocalModelEx.CheckSkillIndexIsOpen() @ 0x928a800
0064C97E4  bl       #0x382bd14 ; 
0064C97E8  mov      w8, #1
0064C97EC  strb     w8, [x21, #0xfb8]
0064C97F0  ldr      x2, [x22]
0064C97F4  ldrb     w8, [x2, #0x53]
0064C97F8  tbnz     w8, #5, #0x64c9848
0064C97FC  adrp     x8, #0x8ee8000
0064C9800  ldr      x8, [x8, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064C9804  ldr      x0, [x8]
0064C9808  ldr      w8, [x0, #0xe0]
0064C980C  cbnz     w8, #0x64c9814
0064C9810  bl       #0x382be8c ; 
0064C9814  bl       #0x64c986c ; LocalModels.Const$$GetSkillStudyUnlockLevel
0064C9818  cbz      x0, #0x64c9864
0064C981C  ldr      w8, [x0, #0x18]
0064C9820  cmp      w8, w20
0064C9824  b.ls     #0x64c9868
0064C9828  add      x8, x0, w20, sxtw #2
0064C982C  ldr      w8, [x8, #0x20]
0064C9830  ldp      x22, x21, [sp, #0x10]
0064C9834  cmp      w8, w19
0064C9838  ldp      x20, x19, [sp, #0x20]
0064C983C  cset     w0, le
0064C9840  ldr      x30, [sp], #0x30
0064C9844  ret      
0064C9848  ldr      x3, [x2, #0x60]
0064C984C  mov      w0, w20
0064C9850  mov      w1, w19
0064C9854  ldp      x20, x19, [sp, #0x20]
0064C9858  ldp      x22, x21, [sp, #0x10]
0064C985C  ldr      x30, [sp], #0x30
0064C9860  br       x3
0064C9864  bl       #0x382bfb8 ; 
0064C9868  bl       #0x382bfc0 ; 

