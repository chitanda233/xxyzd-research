; System.Collections.Generic.List<WeightRandomData>$$.ctor
; RVA 0x4E9F210; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F210  str      x30, [sp, #-0x20]!
004E9F214  stp      x20, x19, [sp, #0x10]
004E9F218  mov      x20, x1
004E9F21C  mov      x1, xzr
004E9F220  mov      x19, x0
004E9F224  bl       #0x7c335dc ; System.Object$$.ctor
004E9F228  ldr      x8, [x20, #0x20]
004E9F22C  ldr      x8, [x8, #0xc0]
004E9F230  ldr      x0, [x8, #0x10]
004E9F234  ldrb     w8, [x0, #0x135]
004E9F238  tbnz     w8, #0, #0x4e9f240
004E9F23C  bl       #0x3a7e60c ; 
004E9F240  ldr      w8, [x0, #0xe0]
004E9F244  cbnz     w8, #0x4e9f24c
004E9F248  bl       #0x382be8c ; 
004E9F24C  ldr      x8, [x20, #0x20]
004E9F250  ldr      x8, [x8, #0xc0]
004E9F254  ldr      x0, [x8, #0x10]
004E9F258  ldrb     w8, [x0, #0x135]
004E9F25C  tbnz     w8, #0, #0x4e9f264
004E9F260  bl       #0x3a7e60c ; 
004E9F264  ldr      x8, [x0, #0xb8]
004E9F268  ldr      x1, [x8]
004E9F26C  str      x1, [x19, #0x10]!
004E9F270  mov      x0, x19
004E9F274  ldp      x20, x19, [sp, #0x10]
004E9F278  ldr      x30, [sp], #0x20
004E9F27C  b        #0x382bcb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$.ctor
; RVA 0x4E9F280; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F280  stp      x30, x21, [sp, #-0x20]!
004E9F284  stp      x20, x19, [sp, #0x10]
004E9F288  mov      w20, w1
004E9F28C  mov      x1, xzr
004E9F290  mov      x21, x2
004E9F294  mov      x19, x0
004E9F298  bl       #0x7c335dc ; System.Object$$.ctor
004E9F29C  tbnz     w20, #0x1f, #0x4e9f2f0
004E9F2A0  ldr      x8, [x21, #0x20]
004E9F2A4  ldr      x8, [x8, #0xc0]
004E9F2A8  cbnz     w20, #0x4e9f308
004E9F2AC  ldr      x0, [x8, #0x10]
004E9F2B0  ldrb     w8, [x0, #0x135]
004E9F2B4  tbnz     w8, #0, #0x4e9f2bc
004E9F2B8  bl       #0x3a7e60c ; 
004E9F2BC  ldr      w8, [x0, #0xe0]
004E9F2C0  cbnz     w8, #0x4e9f2c8
004E9F2C4  bl       #0x382be8c ; 
004E9F2C8  ldr      x8, [x21, #0x20]
004E9F2CC  ldr      x8, [x8, #0xc0]
004E9F2D0  ldr      x0, [x8, #0x10]
004E9F2D4  ldrb     w8, [x0, #0x135]
004E9F2D8  tbnz     w8, #0, #0x4e9f2e0
004E9F2DC  bl       #0x3a7e60c ; 
004E9F2E0  ldr      x8, [x0, #0xb8]
004E9F2E4  ldr      x1, [x8]
004E9F2E8  str      x1, [x19, #0x10]!
004E9F2EC  b        #0x4e9f328 ; 
004E9F2F0  mov      w0, #0xc
004E9F2F4  mov      w1, #4
004E9F2F8  mov      x2, xzr
004E9F2FC  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004E9F300  ldr      x8, [x21, #0x20]
004E9F304  ldr      x8, [x8, #0xc0]
004E9F308  ldr      x0, [x8, #0x18]
004E9F30C  ldrb     w8, [x0, #0x135]
004E9F310  tbnz     w8, #0, #0x4e9f318
004E9F314  bl       #0x3a7e60c ; 
004E9F318  mov      w1, w20
004E9F31C  bl       #0x382bdfc ; 
004E9F320  mov      x1, x0
004E9F324  str      x0, [x19, #0x10]!
004E9F328  mov      x0, x19
004E9F32C  ldp      x20, x19, [sp, #0x10]
004E9F330  ldp      x30, x21, [sp], #0x20
004E9F334  b        #0x382bcb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$.ctor
; RVA 0x4E9F338; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F338  stp      x30, x23, [sp, #-0x30]!
004E9F33C  stp      x22, x21, [sp, #0x10]
004E9F340  stp      x20, x19, [sp, #0x20]
004E9F344  mov      x22, x1
004E9F348  mov      x1, xzr
004E9F34C  mov      x20, x2
004E9F350  mov      x19, x0
004E9F354  bl       #0x7c335dc ; System.Object$$.ctor
004E9F358  cbnz     x22, #0x4e9f368
004E9F35C  mov      w0, #6
004E9F360  mov      x1, xzr
004E9F364  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004E9F368  ldr      x8, [x20, #0x20]
004E9F36C  ldr      x8, [x8, #0xc0]
004E9F370  ldr      x1, [x8, #0x28]
004E9F374  ldrb     w8, [x1, #0x135]
004E9F378  tbnz     w8, #0, #0x4e9f388
004E9F37C  mov      x0, x1
004E9F380  bl       #0x3a7e60c ; 
004E9F384  mov      x1, x0
004E9F388  mov      x0, x22
004E9F38C  bl       #0x382be90 ; 
004E9F390  cbz      x0, #0x4e9f3f4
004E9F394  ldr      x8, [x20, #0x20]
004E9F398  mov      x21, x0
004E9F39C  ldr      x8, [x8, #0xc0]
004E9F3A0  ldr      x1, [x8, #0x28]
004E9F3A4  ldrb     w8, [x1, #0x135]
004E9F3A8  tbnz     w8, #0, #0x4e9f3b8
004E9F3AC  mov      x0, x1
004E9F3B0  bl       #0x3a7e60c ; 
004E9F3B4  mov      x1, x0
004E9F3B8  ldr      x8, [x21]
004E9F3BC  ldrh     w9, [x8, #0x12e]
004E9F3C0  cbz      x9, #0x4e9f3e4
004E9F3C4  ldr      x10, [x8, #0xb0]
004E9F3C8  add      x10, x10, #8
004E9F3CC  ldur     x11, [x10, #-8]
004E9F3D0  cmp      x11, x1
004E9F3D4  b.eq     #0x4e9f46c
004E9F3D8  subs     x9, x9, #1
004E9F3DC  add      x10, x10, #0x10
004E9F3E0  b.ne     #0x4e9f3cc
004E9F3E4  mov      x0, x21
004E9F3E8  mov      w2, wzr
004E9F3EC  bl       #0x3a7e710 ; 
004E9F3F0  b        #0x4e9f478 ; 
004E9F3F4  str      wzr, [x19, #0x18]
004E9F3F8  ldr      x8, [x20, #0x20]
004E9F3FC  ldr      x8, [x8, #0xc0]
004E9F400  ldr      x0, [x8, #0x10]
004E9F404  ldrb     w8, [x0, #0x135]
004E9F408  tbnz     w8, #0, #0x4e9f410
004E9F40C  bl       #0x3a7e60c ; 
004E9F410  ldr      w8, [x0, #0xe0]
004E9F414  cbnz     w8, #0x4e9f41c
004E9F418  bl       #0x382be8c ; 
004E9F41C  ldr      x8, [x20, #0x20]
004E9F420  ldr      x8, [x8, #0xc0]
004E9F424  ldr      x0, [x8, #0x10]
004E9F428  ldrb     w8, [x0, #0x135]
004E9F42C  tbnz     w8, #0, #0x4e9f434
004E9F430  bl       #0x3a7e60c ; 
004E9F434  ldr      x8, [x0, #0xb8]
004E9F438  mov      x0, x19
004E9F43C  ldr      x1, [x8]
004E9F440  str      x1, [x0, #0x10]!
004E9F444  bl       #0x382bcb8 ; 
004E9F448  ldr      x8, [x20, #0x20]
004E9F44C  mov      x0, x19
004E9F450  mov      x1, x22
004E9F454  ldp      x20, x19, [sp, #0x20]
004E9F458  ldr      x8, [x8, #0xc0]
004E9F45C  ldp      x22, x21, [sp, #0x10]
004E9F460  ldr      x2, [x8, #0x40]
004E9F464  ldp      x30, x23, [sp], #0x30
004E9F468  b        #0x4ea23d4 ; System.Collections.Generic.List<WeightRandomData>$$AddEnumerable
004E9F46C  ldrsw    x9, [x10]
004E9F470  add      x8, x8, x9, lsl #4
004E9F474  add      x0, x8, #0x138
004E9F478  ldp      x8, x1, [x0]
004E9F47C  mov      x0, x21
004E9F480  blr      x8
004E9F484  ldr      x8, [x20, #0x20]
004E9F488  ldr      x8, [x8, #0xc0]
004E9F48C  cbz      w0, #0x4e9f520
004E9F490  mov      w22, w0
004E9F494  ldr      x0, [x8, #0x18]
004E9F498  ldrb     w8, [x0, #0x135]
004E9F49C  tbnz     w8, #0, #0x4e9f4a4
004E9F4A0  bl       #0x3a7e60c ; 
004E9F4A4  mov      w1, w22
004E9F4A8  bl       #0x382bdfc ; 
004E9F4AC  mov      x23, x19
004E9F4B0  str      x0, [x23, #0x10]!
004E9F4B4  mov      x1, x0
004E9F4B8  mov      x0, x23
004E9F4BC  bl       #0x382bcb8 ; 
004E9F4C0  ldr      x8, [x20, #0x20]
004E9F4C4  ldr      x20, [x23]
004E9F4C8  ldr      x8, [x8, #0xc0]
004E9F4CC  ldr      x1, [x8, #0x28]
004E9F4D0  ldrb     w8, [x1, #0x135]
004E9F4D4  tbnz     w8, #0, #0x4e9f4e4
004E9F4D8  mov      x0, x1
004E9F4DC  bl       #0x3a7e60c ; 
004E9F4E0  mov      x1, x0
004E9F4E4  ldr      x8, [x21]
004E9F4E8  ldrh     w9, [x8, #0x12e]
004E9F4EC  cbz      x9, #0x4e9f510
004E9F4F0  ldr      x10, [x8, #0xb0]
004E9F4F4  add      x10, x10, #8
004E9F4F8  ldur     x11, [x10, #-8]
004E9F4FC  cmp      x11, x1
004E9F500  b.eq     #0x4e9f574
004E9F504  subs     x9, x9, #1
004E9F508  add      x10, x10, #0x10
004E9F50C  b.ne     #0x4e9f4f8
004E9F510  mov      w2, #5
004E9F514  mov      x0, x21
004E9F518  bl       #0x3a7e710 ; 
004E9F51C  b        #0x4e9f584 ; 
004E9F520  ldr      x0, [x8, #0x10]
004E9F524  ldrb     w8, [x0, #0x135]
004E9F528  tbnz     w8, #0, #0x4e9f530
004E9F52C  bl       #0x3a7e60c ; 
004E9F530  ldr      w8, [x0, #0xe0]
004E9F534  cbnz     w8, #0x4e9f53c
004E9F538  bl       #0x382be8c ; 
004E9F53C  ldr      x8, [x20, #0x20]
004E9F540  ldr      x8, [x8, #0xc0]
004E9F544  ldr      x0, [x8, #0x10]
004E9F548  ldrb     w8, [x0, #0x135]
004E9F54C  tbnz     w8, #0, #0x4e9f554
004E9F550  bl       #0x3a7e60c ; 
004E9F554  ldr      x8, [x0, #0xb8]
004E9F558  ldp      x22, x21, [sp, #0x10]
004E9F55C  ldr      x1, [x8]
004E9F560  str      x1, [x19, #0x10]!
004E9F564  mov      x0, x19
004E9F568  ldp      x20, x19, [sp, #0x20]
004E9F56C  ldp      x30, x23, [sp], #0x30
004E9F570  b        #0x382bcb8 ; 
004E9F574  ldr      w9, [x10]
004E9F578  add      w9, w9, #5
004E9F57C  add      x8, x8, w9, sxtw #4
004E9F580  add      x0, x8, #0x138
004E9F584  ldp      x8, x3, [x0]
004E9F588  mov      x0, x21
004E9F58C  mov      x1, x20
004E9F590  mov      w2, wzr
004E9F594  blr      x8
004E9F598  str      w22, [x19, #0x18]
004E9F59C  ldp      x20, x19, [sp, #0x20]
004E9F5A0  ldp      x22, x21, [sp, #0x10]
004E9F5A4  ldp      x30, x23, [sp], #0x30
004E9F5A8  ret      

; System.Collections.Generic.List<WeightRandomData>$$get_Capacity
; RVA 0x4E9F5AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F5AC  str      x30, [sp, #-0x10]!
004E9F5B0  ldr      x8, [x0, #0x10]
004E9F5B4  cbz      x8, #0x4e9f5c4
004E9F5B8  ldr      w0, [x8, #0x18]
004E9F5BC  ldr      x30, [sp], #0x10
004E9F5C0  ret      
004E9F5C4  bl       #0x382bfb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$set_Capacity
; RVA 0x4E9F5C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F5C8  str      x30, [sp, #-0x30]!
004E9F5CC  stp      x22, x21, [sp, #0x10]
004E9F5D0  stp      x20, x19, [sp, #0x20]
004E9F5D4  ldr      w8, [x0, #0x18]
004E9F5D8  mov      x20, x0
004E9F5DC  mov      w22, w1
004E9F5E0  mov      x21, x2
004E9F5E4  cmp      w8, w1
004E9F5E8  b.le     #0x4e9f5fc
004E9F5EC  mov      w0, #0xf
004E9F5F0  mov      w1, #0x15
004E9F5F4  mov      x2, xzr
004E9F5F8  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004E9F5FC  mov      x19, x20
004E9F600  ldr      x8, [x19, #0x10]!
004E9F604  cbz      x8, #0x4e9f6d8
004E9F608  ldr      w8, [x8, #0x18]
004E9F60C  cmp      w8, w22
004E9F610  b.ne     #0x4e9f624
004E9F614  ldp      x20, x19, [sp, #0x20]
004E9F618  ldp      x22, x21, [sp, #0x10]
004E9F61C  ldr      x30, [sp], #0x30
004E9F620  ret      
004E9F624  ldr      x8, [x21, #0x20]
004E9F628  cmp      w22, #1
004E9F62C  ldr      x8, [x8, #0xc0]
004E9F630  b.lt     #0x4e9f684
004E9F634  ldr      x0, [x8, #0x18]
004E9F638  ldrb     w8, [x0, #0x135]
004E9F63C  tbnz     w8, #0, #0x4e9f644
004E9F640  bl       #0x3a7e60c ; 
004E9F644  mov      w1, w22
004E9F648  bl       #0x382bdfc ; 
004E9F64C  ldr      w4, [x20, #0x18]
004E9F650  mov      x20, x0
004E9F654  cmp      w4, #1
004E9F658  b.lt     #0x4e9f674
004E9F65C  ldr      x0, [x19]
004E9F660  mov      w1, wzr
004E9F664  mov      x2, x20
004E9F668  mov      w3, wzr
004E9F66C  mov      x5, xzr
004E9F670  bl       #0x7c00484 ; System.Array$$Copy
004E9F674  mov      x0, x19
004E9F678  mov      x1, x20
004E9F67C  str      x20, [x19]
004E9F680  b        #0x4e9f6c8 ; 
004E9F684  ldr      x0, [x8, #0x10]
004E9F688  ldrb     w8, [x0, #0x135]
004E9F68C  tbnz     w8, #0, #0x4e9f694
004E9F690  bl       #0x3a7e60c ; 
004E9F694  ldr      w8, [x0, #0xe0]
004E9F698  cbnz     w8, #0x4e9f6a0
004E9F69C  bl       #0x382be8c ; 
004E9F6A0  ldr      x8, [x21, #0x20]
004E9F6A4  ldr      x8, [x8, #0xc0]
004E9F6A8  ldr      x0, [x8, #0x10]
004E9F6AC  ldrb     w8, [x0, #0x135]
004E9F6B0  tbnz     w8, #0, #0x4e9f6b8
004E9F6B4  bl       #0x3a7e60c ; 
004E9F6B8  ldr      x8, [x0, #0xb8]
004E9F6BC  mov      x0, x19
004E9F6C0  ldr      x1, [x8]
004E9F6C4  str      x1, [x19]
004E9F6C8  ldp      x20, x19, [sp, #0x20]
004E9F6CC  ldp      x22, x21, [sp, #0x10]
004E9F6D0  ldr      x30, [sp], #0x30
004E9F6D4  b        #0x382bcb8 ; 
004E9F6D8  bl       #0x382bfb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$get_Count
; RVA 0x4E9F6DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F6DC  ldr      w0, [x0, #0x18]
004E9F6E0  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.get_IsFixedSize
; RVA 0x4E9F6E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F6E4  mov      w0, wzr
004E9F6E8  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.Generic.ICollection<T>.get_IsReadOnly
; RVA 0x4E9F6EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F6EC  mov      w0, wzr
004E9F6F0  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.get_IsReadOnly
; RVA 0x4E9F6F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F6F4  mov      w0, wzr
004E9F6F8  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.ICollection.get_IsSynchronized
; RVA 0x4E9F6FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F6FC  mov      w0, wzr
004E9F700  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.ICollection.get_SyncRoot
; RVA 0x4E9F704; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F704  str      x30, [sp, #-0x20]!
004E9F708  stp      x20, x19, [sp, #0x10]
004E9F70C  adrp     x20, #0x9592000
004E9F710  ldrb     w8, [x20, #0x832]
004E9F714  mov      x19, x0
004E9F718  tbnz     w8, #0, #0x4e9f730
004E9F71C  adrp     x0, #0x8ec2000
004E9F720  ldr      x0, [x0, #0xd60]
004E9F724  bl       #0x382bd14 ; 
004E9F728  mov      w8, #1
004E9F72C  strb     w8, [x20, #0x832]
004E9F730  ldr      x0, [x19, #0x20]!
004E9F734  cbnz     x0, #0x4e9f768
004E9F738  adrp     x8, #0x8ec2000
004E9F73C  ldr      x8, [x8, #0xd60]
004E9F740  ldr      x0, [x8]
004E9F744  bl       #0x382bfa0 ; 
004E9F748  mov      x1, xzr
004E9F74C  mov      x20, x0
004E9F750  bl       #0x7c335dc ; System.Object$$.ctor
004E9F754  mov      x0, x19
004E9F758  mov      x1, x20
004E9F75C  mov      x2, xzr
004E9F760  bl       #0x3ad5fac ; 
004E9F764  ldr      x0, [x19]
004E9F768  ldp      x20, x19, [sp, #0x10]
004E9F76C  ldr      x30, [sp], #0x20
004E9F770  ret      

; System.Collections.Generic.List<WeightRandomData>$$get_Item
; RVA 0x4E9F774; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F774  stp      x30, x21, [sp, #-0x20]!
004E9F778  stp      x20, x19, [sp, #0x10]
004E9F77C  ldr      w9, [x0, #0x18]
004E9F780  mov      x21, x0
004E9F784  mov      w20, w1
004E9F788  mov      x19, x8
004E9F78C  cmp      w9, w1
004E9F790  b.hi     #0x4e9f79c
004E9F794  mov      x0, xzr
004E9F798  bl       #0x7bfe7ac ; System.ThrowHelper$$ThrowArgumentOutOfRange_IndexException
004E9F79C  ldr      x8, [x21, #0x10]
004E9F7A0  cbz      x8, #0x4e9f7dc
004E9F7A4  ldr      w9, [x8, #0x18]
004E9F7A8  cmp      w9, w20
004E9F7AC  b.ls     #0x4e9f7e0
004E9F7B0  mov      w9, #0x38
004E9F7B4  smaddl   x8, w20, w9, x8
004E9F7B8  ldr      x9, [x8, #0x50]
004E9F7BC  ldp      q1, q0, [x8, #0x30]
004E9F7C0  ldr      q2, [x8, #0x20]
004E9F7C4  str      x9, [x19, #0x30]
004E9F7C8  stp      q1, q0, [x19, #0x10]
004E9F7CC  str      q2, [x19]
004E9F7D0  ldp      x20, x19, [sp, #0x10]
004E9F7D4  ldp      x30, x21, [sp], #0x20
004E9F7D8  ret      
004E9F7DC  bl       #0x382bfb8 ; 
004E9F7E0  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$set_Item
; RVA 0x4E9F7E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F7E4  sub      sp, sp, #0xa0
004E9F7E8  stp      x30, x21, [sp, #0x80]
004E9F7EC  stp      x20, x19, [sp, #0x90]
004E9F7F0  ldr      w8, [x0, #0x18]
004E9F7F4  mov      x19, x0
004E9F7F8  mov      w20, w1
004E9F7FC  mov      x21, x2
004E9F800  cmp      w8, w1
004E9F804  b.hi     #0x4e9f810
004E9F808  mov      x0, xzr
004E9F80C  bl       #0x7bfe7ac ; System.ThrowHelper$$ThrowArgumentOutOfRange_IndexException
004E9F810  ldp      q2, q0, [x21, #0x10]
004E9F814  ldr      x9, [x21, #0x30]
004E9F818  ldr      q1, [x21]
004E9F81C  ldr      x8, [x19, #0x10]
004E9F820  stp      q2, q0, [sp, #0x50]
004E9F824  str      x9, [sp, #0x70]
004E9F828  str      q1, [sp, #0x40]
004E9F82C  cbz      x8, #0x4e9f8a0
004E9F830  ldp      q0, q1, [sp, #0x40]
004E9F834  ldr      q2, [sp, #0x60]
004E9F838  ldr      x9, [sp, #0x70]
004E9F83C  stp      q0, q1, [sp]
004E9F840  str      q2, [sp, #0x20]
004E9F844  str      x9, [sp, #0x30]
004E9F848  ldr      w9, [x8, #0x18]
004E9F84C  cmp      w9, w20
004E9F850  b.ls     #0x4e9f8a4
004E9F854  ldp      q2, q0, [sp, #0x10]
004E9F858  ldr      x11, [sp, #0x30]
004E9F85C  ldr      q1, [sp]
004E9F860  sxtw     x9, w20
004E9F864  mov      w10, #0x38
004E9F868  madd     x8, x9, x10, x8
004E9F86C  add      x0, x8, #0x30
004E9F870  mov      x1, xzr
004E9F874  str      x11, [x8, #0x50]
004E9F878  stp      q2, q0, [x8, #0x30]
004E9F87C  str      q1, [x8, #0x20]
004E9F880  bl       #0x382bcb8 ; 
004E9F884  ldr      w8, [x19, #0x1c]
004E9F888  ldp      x30, x21, [sp, #0x80]
004E9F88C  add      w8, w8, #1
004E9F890  str      w8, [x19, #0x1c]
004E9F894  ldp      x20, x19, [sp, #0x90]
004E9F898  add      sp, sp, #0xa0
004E9F89C  ret      
004E9F8A0  bl       #0x382bfb8 ; 
004E9F8A4  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$IsCompatibleObject
; RVA 0x4E9F8A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F8A8  stp      x30, x19, [sp, #-0x10]!
004E9F8AC  ldr      x8, [x1, #0x20]
004E9F8B0  mov      x19, x0
004E9F8B4  ldrb     w9, [x8, #0x135]
004E9F8B8  tbnz     w9, #0, #0x4e9f8c8
004E9F8BC  mov      x0, x8
004E9F8C0  bl       #0x3a7e60c ; 
004E9F8C4  mov      x8, x0
004E9F8C8  ldr      x8, [x8, #0xc0]
004E9F8CC  ldr      x1, [x8, #0x48]
004E9F8D0  ldrb     w8, [x1, #0x135]
004E9F8D4  tbnz     w8, #0, #0x4e9f8e4
004E9F8D8  mov      x0, x1
004E9F8DC  bl       #0x3a7e60c ; 
004E9F8E0  mov      x1, x0
004E9F8E4  mov      x0, x19
004E9F8E8  bl       #0x382be90 ; 
004E9F8EC  cmp      x0, #0
004E9F8F0  cset     w0, ne
004E9F8F4  ldp      x30, x19, [sp], #0x10
004E9F8F8  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.get_Item
; RVA 0x4E9F8FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F8FC  sub      sp, sp, #0x80
004E9F900  stp      x30, x19, [sp, #0x70]
004E9F904  add      x8, sp, #0x38
004E9F908  mov      x19, x2
004E9F90C  bl       #0x4e9f774 ; System.Collections.Generic.List<WeightRandomData>$$get_Item
004E9F910  ldur     q0, [sp, #0x38]
004E9F914  ldur     q1, [sp, #0x48]
004E9F918  ldur     q2, [sp, #0x58]
004E9F91C  ldr      x8, [sp, #0x68]
004E9F920  mov      x1, sp
004E9F924  stp      q0, q1, [sp]
004E9F928  str      q2, [sp, #0x20]
004E9F92C  str      x8, [sp, #0x30]
004E9F930  ldr      x8, [x19, #0x20]
004E9F934  ldr      x8, [x8, #0xc0]
004E9F938  ldr      x0, [x8, #0x48]
004E9F93C  bl       #0x382be94 ; 
004E9F940  ldp      x30, x19, [sp, #0x70]
004E9F944  add      sp, sp, #0x80
004E9F948  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.set_Item
; RVA 0x4E9F94C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9F94C  sub      sp, sp, #0x70
004E9F950  str      x30, [sp, #0x40]
004E9F954  stp      x22, x21, [sp, #0x50]
004E9F958  stp      x20, x19, [sp, #0x60]
004E9F95C  ldr      x8, [x3, #0x20]
004E9F960  mov      x19, x2
004E9F964  mov      w21, w1
004E9F968  mov      x22, x0
004E9F96C  ldr      x8, [x8, #0xc0]
004E9F970  mov      w1, #0xf
004E9F974  mov      x0, x19
004E9F978  mov      x20, x3
004E9F97C  ldr      x2, [x8, #0x58]
004E9F980  bl       #0x471e6d0 ; System.ThrowHelper$$IfNullAndNullsAreIllegalThenThrow<WeightRandomData>
004E9F984  ldr      x8, [x20, #0x20]
004E9F988  ldr      x8, [x8, #0xc0]
004E9F98C  ldr      x1, [x8, #0x48]
004E9F990  ldrb     w8, [x1, #0x135]
004E9F994  tbnz     w8, #0, #0x4e9f9a4
004E9F998  mov      x0, x1
004E9F99C  bl       #0x3a7e60c ; 
004E9F9A0  mov      x1, x0
004E9F9A4  cbz      x19, #0x4e9fa00
004E9F9A8  ldr      x8, [x19]
004E9F9AC  ldr      x9, [x1, #0x40]
004E9F9B0  ldr      x8, [x8, #0x40]
004E9F9B4  cmp      x8, x9
004E9F9B8  b.ne     #0x4e9fa04
004E9F9BC  mov      x0, x19
004E9F9C0  bl       #0x382be98 ; 
004E9F9C4  ldr      x8, [x0, #0x30]
004E9F9C8  ldp      q1, q0, [x0, #0x10]
004E9F9CC  ldr      q2, [x0]
004E9F9D0  str      x8, [sp, #0x30]
004E9F9D4  stp      q1, q0, [sp, #0x10]
004E9F9D8  str      q2, [sp]
004E9F9DC  mov      x2, sp
004E9F9E0  mov      x0, x22
004E9F9E4  mov      w1, w21
004E9F9E8  bl       #0x4e9f7e4 ; System.Collections.Generic.List<WeightRandomData>$$set_Item
004E9F9EC  ldp      x20, x19, [sp, #0x60]
004E9F9F0  ldp      x22, x21, [sp, #0x50]
004E9F9F4  ldr      x30, [sp, #0x40]
004E9F9F8  add      sp, sp, #0x70
004E9F9FC  ret      
004E9FA00  bl       #0x382bfb8 ; 
004E9FA04  mov      x0, x19
004E9FA08  bl       #0x382c354 ; 
004E9FA0C  cmp      w1, #1
004E9FA10  mov      x21, x0
004E9FA14  b.ne     #0x4e9fabc
004E9FA18  mov      x0, x21
004E9FA1C  bl       #0x89eda50 ; 
004E9FA20  mov      x21, x0
004E9FA24  adrp     x0, #0x8ec6000
004E9FA28  ldr      x0, [x0, #0xf48]
004E9FA2C  bl       #0x382bd28 ; 
004E9FA30  ldr      x8, [x21]
004E9FA34  ldr      x1, [x8]
004E9FA38  bl       #0x382c3e4 ; 
004E9FA3C  tbz      w0, #0, #0x4e9fa94
004E9FA40  bl       #0x89eda60 ; 
004E9FA44  ldr      x8, [x20, #0x20]
004E9FA48  adrp     x0, #0x8ebf000
004E9FA4C  ldr      x8, [x8, #0xc0]
004E9FA50  ldr      x20, [x8, #0x68]
004E9FA54  ldr      x0, [x0, #0x3a8]
004E9FA58  bl       #0x382bd28 ; 
004E9FA5C  ldr      w8, [x0, #0xe0]
004E9FA60  cbnz     w8, #0x4e9fa68
004E9FA64  bl       #0x382be8c ; 
004E9FA68  mov      x0, x20
004E9FA6C  mov      x1, xzr
004E9FA70  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
004E9FA74  mov      x1, x0
004E9FA78  mov      x0, x19
004E9FA7C  ldp      x20, x19, [sp, #0x60]
004E9FA80  ldp      x22, x21, [sp, #0x50]
004E9FA84  ldr      x30, [sp, #0x40]
004E9FA88  mov      x2, xzr
004E9FA8C  add      sp, sp, #0x70
004E9FA90  b        #0x7bfde90 ; System.ThrowHelper$$ThrowWrongValueTypeArgumentException
004E9FA94  mov      w0, #8
004E9FA98  bl       #0x89eda70 ; 
004E9FA9C  ldr      x8, [x21]
004E9FAA0  str      x8, [x0]
004E9FAA4  adrp     x1, #0x89f3000
004E9FAA8  add      x1, x1, #0xf98
004E9FAAC  mov      x2, xzr
004E9FAB0  bl       #0x89eda80 ; 
004E9FAB4  mov      x21, x0
004E9FAB8  bl       #0x89eda60 ; 
004E9FABC  mov      x0, x21
004E9FAC0  bl       #0x3b56bfc ; 
004E9FAC4  bl       #0x3442448 ; 

; System.Collections.Generic.List<WeightRandomData>$$Add
; RVA 0x4E9FAC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FAC8  sub      sp, sp, #0x90
004E9FACC  str      x30, [sp, #0x80]
004E9FAD0  ldr      w9, [x0, #0x1c]
004E9FAD4  ldr      x8, [x0, #0x10]
004E9FAD8  add      w9, w9, #1
004E9FADC  str      w9, [x0, #0x1c]
004E9FAE0  cbz      x8, #0x4e9fb78
004E9FAE4  ldrsw    x9, [x0, #0x18]
004E9FAE8  ldr      w10, [x8, #0x18]
004E9FAEC  cmp      w9, w10
004E9FAF0  b.hs     #0x4e9fb34
004E9FAF4  add      w10, w9, #1
004E9FAF8  mov      w11, #0x38
004E9FAFC  str      w10, [x0, #0x18]
004E9FB00  nop      
004E9FB04  madd     x8, x9, x11, x8
004E9FB08  ldp      q2, q0, [x1, #0x10]
004E9FB0C  ldr      x9, [x1, #0x30]
004E9FB10  ldr      q1, [x1]
004E9FB14  ldr      x30, [sp, #0x80]
004E9FB18  add      x0, x8, #0x30
004E9FB1C  str      x9, [x8, #0x50]
004E9FB20  stp      q2, q0, [x8, #0x30]
004E9FB24  str      q1, [x8, #0x20]
004E9FB28  mov      x1, xzr
004E9FB2C  add      sp, sp, #0x90
004E9FB30  b        #0x382bcb8 ; 
004E9FB34  ldr      x8, [x1, #0x30]
004E9FB38  ldp      q1, q0, [x1, #0x10]
004E9FB3C  ldr      q2, [x1]
004E9FB40  add      x1, sp, #0x40
004E9FB44  str      x8, [sp, #0x30]
004E9FB48  stp      q1, q0, [sp, #0x10]
004E9FB4C  str      q2, [sp]
004E9FB50  ldr      x9, [x2, #0x20]
004E9FB54  ldr      x9, [x9, #0xc0]
004E9FB58  ldr      x2, [x9, #0x70]
004E9FB5C  stp      q2, q1, [sp, #0x40]
004E9FB60  str      q0, [sp, #0x60]
004E9FB64  str      x8, [sp, #0x70]
004E9FB68  bl       #0x4e9fb7c ; System.Collections.Generic.List<WeightRandomData>$$AddWithResize
004E9FB6C  ldr      x30, [sp, #0x80]
004E9FB70  add      sp, sp, #0x90
004E9FB74  ret      
004E9FB78  bl       #0x382bfb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$AddWithResize
; RVA 0x4E9FB7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FB7C  sub      sp, sp, #0xb0
004E9FB80  str      x30, [sp, #0x80]
004E9FB84  stp      x22, x21, [sp, #0x90]
004E9FB88  stp      x20, x19, [sp, #0xa0]
004E9FB8C  ldr      x8, [x2, #0x20]
004E9FB90  ldrsw    x22, [x0, #0x18]
004E9FB94  mov      x19, x1
004E9FB98  mov      x20, x0
004E9FB9C  ldr      x8, [x8, #0xc0]
004E9FBA0  add      w21, w22, #1
004E9FBA4  mov      w1, w21
004E9FBA8  ldr      x2, [x8, #0x78]
004E9FBAC  bl       #0x4ea0374 ; System.Collections.Generic.List<WeightRandomData>$$EnsureCapacity
004E9FBB0  str      w21, [x20, #0x18]
004E9FBB4  ldp      q2, q0, [x19, #0x10]
004E9FBB8  ldr      x9, [x19, #0x30]
004E9FBBC  ldr      q1, [x19]
004E9FBC0  ldr      x8, [x20, #0x10]
004E9FBC4  stp      q2, q0, [sp, #0x50]
004E9FBC8  str      x9, [sp, #0x70]
004E9FBCC  str      q1, [sp, #0x40]
004E9FBD0  cbz      x8, #0x4e9fc38
004E9FBD4  ldp      q0, q1, [sp, #0x40]
004E9FBD8  ldr      q2, [sp, #0x60]
004E9FBDC  ldr      x9, [sp, #0x70]
004E9FBE0  stp      q0, q1, [sp]
004E9FBE4  str      q2, [sp, #0x20]
004E9FBE8  str      x9, [sp, #0x30]
004E9FBEC  ldr      w9, [x8, #0x18]
004E9FBF0  cmp      w22, w9
004E9FBF4  b.hs     #0x4e9fc3c
004E9FBF8  mov      w9, #0x38
004E9FBFC  ldp      q0, q1, [sp]
004E9FC00  ldr      x10, [sp, #0x30]
004E9FC04  ldr      q2, [sp, #0x20]
004E9FC08  nop      
004E9FC0C  madd     x8, x22, x9, x8
004E9FC10  ldp      x20, x19, [sp, #0xa0]
004E9FC14  ldp      x22, x21, [sp, #0x90]
004E9FC18  ldr      x30, [sp, #0x80]
004E9FC1C  add      x0, x8, #0x30
004E9FC20  str      x10, [x8, #0x50]
004E9FC24  stp      q1, q2, [x8, #0x30]
004E9FC28  str      q0, [x8, #0x20]
004E9FC2C  mov      x1, xzr
004E9FC30  add      sp, sp, #0xb0
004E9FC34  b        #0x382bcb8 ; 
004E9FC38  bl       #0x382bfb8 ; 
004E9FC3C  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.Add
; RVA 0x4E9FC40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FC40  sub      sp, sp, #0xf0
004E9FC44  str      x30, [sp, #0xc0]
004E9FC48  stp      x22, x21, [sp, #0xd0]
004E9FC4C  stp      x20, x19, [sp, #0xe0]
004E9FC50  ldr      x8, [x2, #0x20]
004E9FC54  mov      x21, x2
004E9FC58  mov      x20, x1
004E9FC5C  mov      x19, x0
004E9FC60  ldr      x8, [x8, #0xc0]
004E9FC64  mov      w1, #0x14
004E9FC68  mov      x0, x20
004E9FC6C  ldr      x2, [x8, #0x58]
004E9FC70  bl       #0x471e6d0 ; System.ThrowHelper$$IfNullAndNullsAreIllegalThenThrow<WeightRandomData>
004E9FC74  ldr      x8, [x21, #0x20]
004E9FC78  ldr      x8, [x8, #0xc0]
004E9FC7C  ldr      x1, [x8, #0x48]
004E9FC80  ldrb     w8, [x1, #0x135]
004E9FC84  tbnz     w8, #0, #0x4e9fc94
004E9FC88  mov      x0, x1
004E9FC8C  bl       #0x3a7e60c ; 
004E9FC90  mov      x1, x0
004E9FC94  cbz      x20, #0x4e9fd8c
004E9FC98  ldr      x8, [x20]
004E9FC9C  ldr      x9, [x1, #0x40]
004E9FCA0  ldr      x8, [x8, #0x40]
004E9FCA4  cmp      x8, x9
004E9FCA8  b.ne     #0x4e9fd90
004E9FCAC  mov      x0, x20
004E9FCB0  bl       #0x382be98 ; 
004E9FCB4  ldr      x8, [x0, #0x30]
004E9FCB8  ldp      q1, q0, [x0, #0x10]
004E9FCBC  ldr      q2, [x0]
004E9FCC0  str      x8, [sp, #0x30]
004E9FCC4  stp      q1, q0, [sp, #0x10]
004E9FCC8  str      q2, [sp]
004E9FCCC  ldr      x9, [x21, #0x20]
004E9FCD0  ldr      x9, [x9, #0xc0]
004E9FCD4  ldr      x9, [x9, #0x80]
004E9FCD8  stp      q2, q1, [sp, #0x40]
004E9FCDC  str      q0, [sp, #0x60]
004E9FCE0  str      x8, [sp, #0x70]
004E9FCE4  ldr      w10, [x19, #0x1c]
004E9FCE8  ldr      x8, [x19, #0x10]
004E9FCEC  add      w10, w10, #1
004E9FCF0  str      w10, [x19, #0x1c]
004E9FCF4  cbz      x8, #0x4e9fd98
004E9FCF8  ldrsw    x10, [x19, #0x18]
004E9FCFC  ldr      w11, [x8, #0x18]
004E9FD00  cmp      w10, w11
004E9FD04  b.hs     #0x4e9fd40
004E9FD08  add      w9, w10, #1
004E9FD0C  str      w9, [x19, #0x18]
004E9FD10  ldp      q2, q0, [sp, #0x50]
004E9FD14  ldr      x9, [sp, #0x70]
004E9FD18  ldr      q1, [sp, #0x40]
004E9FD1C  mov      w11, #0x38
004E9FD20  madd     x8, x10, x11, x8
004E9FD24  add      x0, x8, #0x30
004E9FD28  str      x9, [x8, #0x50]
004E9FD2C  stp      q2, q0, [x8, #0x30]
004E9FD30  str      q1, [x8, #0x20]
004E9FD34  mov      x1, xzr
004E9FD38  bl       #0x382bcb8 ; 
004E9FD3C  b        #0x4e9fd70 ; 
004E9FD40  ldr      x8, [x9, #0x20]
004E9FD44  ldp      q0, q1, [sp, #0x40]
004E9FD48  ldr      q2, [sp, #0x60]
004E9FD4C  ldr      x9, [sp, #0x70]
004E9FD50  ldr      x8, [x8, #0xc0]
004E9FD54  ldr      x2, [x8, #0x70]
004E9FD58  stp      q0, q1, [sp, #0x80]
004E9FD5C  str      q2, [sp, #0xa0]
004E9FD60  str      x9, [sp, #0xb0]
004E9FD64  add      x1, sp, #0x80
004E9FD68  mov      x0, x19
004E9FD6C  bl       #0x4e9fb7c ; System.Collections.Generic.List<WeightRandomData>$$AddWithResize
004E9FD70  ldr      w8, [x19, #0x18]
004E9FD74  ldp      x20, x19, [sp, #0xe0]
004E9FD78  ldp      x22, x21, [sp, #0xd0]
004E9FD7C  ldr      x30, [sp, #0xc0]
004E9FD80  sub      w0, w8, #1
004E9FD84  add      sp, sp, #0xf0
004E9FD88  ret      
004E9FD8C  bl       #0x382bfb8 ; 
004E9FD90  mov      x0, x20
004E9FD94  bl       #0x382c354 ; 
004E9FD98  bl       #0x382bfb8 ; 
004E9FD9C  cmp      w1, #1
004E9FDA0  mov      x22, x0
004E9FDA4  b.ne     #0x4e9fe40
004E9FDA8  mov      x0, x22
004E9FDAC  bl       #0x89eda50 ; 
004E9FDB0  mov      x22, x0
004E9FDB4  adrp     x0, #0x8ec6000
004E9FDB8  ldr      x0, [x0, #0xf48]
004E9FDBC  bl       #0x382bd28 ; 
004E9FDC0  ldr      x8, [x22]
004E9FDC4  ldr      x1, [x8]
004E9FDC8  bl       #0x382c3e4 ; 
004E9FDCC  tbz      w0, #0, #0x4e9fe18
004E9FDD0  bl       #0x89eda60 ; 
004E9FDD4  ldr      x8, [x21, #0x20]
004E9FDD8  adrp     x0, #0x8ebf000
004E9FDDC  ldr      x8, [x8, #0xc0]
004E9FDE0  ldr      x21, [x8, #0x68]
004E9FDE4  ldr      x0, [x0, #0x3a8]
004E9FDE8  bl       #0x382bd28 ; 
004E9FDEC  ldr      w8, [x0, #0xe0]
004E9FDF0  cbnz     w8, #0x4e9fdf8
004E9FDF4  bl       #0x382be8c ; 
004E9FDF8  mov      x0, x21
004E9FDFC  mov      x1, xzr
004E9FE00  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
004E9FE04  mov      x1, x0
004E9FE08  mov      x0, x20
004E9FE0C  mov      x2, xzr
004E9FE10  bl       #0x7bfde90 ; System.ThrowHelper$$ThrowWrongValueTypeArgumentException
004E9FE14  b        #0x4e9fd70 ; 
004E9FE18  mov      w0, #8
004E9FE1C  bl       #0x89eda70 ; 
004E9FE20  ldr      x8, [x22]
004E9FE24  str      x8, [x0]
004E9FE28  adrp     x1, #0x89f3000
004E9FE2C  add      x1, x1, #0xf98
004E9FE30  mov      x2, xzr
004E9FE34  bl       #0x89eda80 ; 
004E9FE38  mov      x22, x0
004E9FE3C  bl       #0x89eda60 ; 
004E9FE40  mov      x0, x22
004E9FE44  bl       #0x3b56bfc ; 
004E9FE48  bl       #0x3442448 ; 

; System.Collections.Generic.List<WeightRandomData>$$AddRange
; RVA 0x4E9FE4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FE4C  ldr      x8, [x2, #0x20]
004E9FE50  mov      x2, x1
004E9FE54  ldr      x9, [x8, #0xc0]
004E9FE58  ldr      w8, [x0, #0x18]
004E9FE5C  ldr      x3, [x9, #0x90]
004E9FE60  mov      w1, w8
004E9FE64  b        #0x4ea12f8 ; System.Collections.Generic.List<WeightRandomData>$$InsertRange

; System.Collections.Generic.List<WeightRandomData>$$AsReadOnly
; RVA 0x4E9FE68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FE68  str      x30, [sp, #-0x20]!
004E9FE6C  stp      x20, x19, [sp, #0x10]
004E9FE70  ldr      x8, [x1, #0x20]
004E9FE74  mov      x19, x1
004E9FE78  mov      x20, x0
004E9FE7C  ldr      x8, [x8, #0xc0]
004E9FE80  ldr      x8, [x8, #0x98]
004E9FE84  ldrb     w9, [x8, #0x135]
004E9FE88  tbnz     w9, #0, #0x4e9fe98
004E9FE8C  mov      x0, x8
004E9FE90  bl       #0x3a7e60c ; 
004E9FE94  mov      x8, x0
004E9FE98  mov      x0, x8
004E9FE9C  bl       #0x382bfa0 ; 
004E9FEA0  ldr      x8, [x19, #0x20]
004E9FEA4  mov      x1, x20
004E9FEA8  mov      x19, x0
004E9FEAC  ldr      x8, [x8, #0xc0]
004E9FEB0  ldr      x2, [x8, #0xa0]
004E9FEB4  bl       #0x53d8290 ; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$.ctor
004E9FEB8  mov      x0, x19
004E9FEBC  ldp      x20, x19, [sp, #0x10]
004E9FEC0  ldr      x30, [sp], #0x20
004E9FEC4  ret      

; System.Collections.Generic.List<WeightRandomData>$$BinarySearch
; RVA 0x4E9FEC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FEC8  sub      sp, sp, #0xc0
004E9FECC  str      x30, [sp, #0x80]
004E9FED0  stp      x24, x23, [sp, #0x90]
004E9FED4  stp      x22, x21, [sp, #0xa0]
004E9FED8  stp      x20, x19, [sp, #0xb0]
004E9FEDC  mov      x22, x5
004E9FEE0  mov      x19, x4
004E9FEE4  mov      x23, x3
004E9FEE8  mov      w20, w2
004E9FEEC  mov      w21, w1
004E9FEF0  mov      x24, x0
004E9FEF4  tbnz     w1, #0x1f, #0x4e9ff78
004E9FEF8  tbnz     w20, #0x1f, #0x4e9ff84
004E9FEFC  ldr      w8, [x24, #0x18]
004E9FF00  sub      w8, w8, w21
004E9FF04  cmp      w8, w20
004E9FF08  b.ge     #0x4e9ff18
004E9FF0C  mov      w0, #0x17
004E9FF10  mov      x1, xzr
004E9FF14  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
004E9FF18  ldp      q2, q0, [x23, #0x10]
004E9FF1C  ldr      x8, [x23, #0x30]
004E9FF20  ldr      q1, [x23]
004E9FF24  ldr      x0, [x24, #0x10]
004E9FF28  stp      q2, q0, [sp, #0x10]
004E9FF2C  str      x8, [sp, #0x30]
004E9FF30  str      q1, [sp]
004E9FF34  ldr      x9, [x22, #0x20]
004E9FF38  add      x3, sp, #0x40
004E9FF3C  mov      w1, w21
004E9FF40  mov      w2, w20
004E9FF44  ldr      x9, [x9, #0xc0]
004E9FF48  mov      x4, x19
004E9FF4C  ldr      x5, [x9, #0xb8]
004E9FF50  stp      q1, q2, [sp, #0x40]
004E9FF54  str      q0, [sp, #0x60]
004E9FF58  str      x8, [sp, #0x70]
004E9FF5C  bl       #0x477da04 ; System.Array$$BinarySearch<WeightRandomData>
004E9FF60  ldp      x20, x19, [sp, #0xb0]
004E9FF64  ldp      x22, x21, [sp, #0xa0]
004E9FF68  ldp      x24, x23, [sp, #0x90]
004E9FF6C  ldr      x30, [sp, #0x80]
004E9FF70  add      sp, sp, #0xc0
004E9FF74  ret      
004E9FF78  mov      x0, xzr
004E9FF7C  bl       #0x7bfe7e4 ; System.ThrowHelper$$ThrowIndexArgumentOutOfRange_NeedNonNegNumException
004E9FF80  tbz      w20, #0x1f, #0x4e9fefc
004E9FF84  mov      w0, #0x10
004E9FF88  mov      w1, #4
004E9FF8C  mov      x2, xzr
004E9FF90  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004E9FF94  b        #0x4e9fefc ; 

; System.Collections.Generic.List<WeightRandomData>$$BinarySearch
; RVA 0x4E9FF98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FF98  sub      sp, sp, #0x90
004E9FF9C  str      x30, [sp, #0x80]
004E9FFA0  ldr      x8, [x2, #0x20]
004E9FFA4  ldp      q0, q1, [x1]
004E9FFA8  ldr      x9, [x1, #0x30]
004E9FFAC  ldr      q2, [x1, #0x20]
004E9FFB0  ldr      x8, [x8, #0xc0]
004E9FFB4  ldr      w2, [x0, #0x18]
004E9FFB8  str      x9, [sp, #0x30]
004E9FFBC  stp      q1, q2, [sp, #0x10]
004E9FFC0  str      q0, [sp]
004E9FFC4  ldr      x5, [x8, #0xc0]
004E9FFC8  add      x3, sp, #0x40
004E9FFCC  mov      w1, wzr
004E9FFD0  mov      x4, xzr
004E9FFD4  stp      q0, q1, [sp, #0x40]
004E9FFD8  str      q2, [sp, #0x60]
004E9FFDC  str      x9, [sp, #0x70]
004E9FFE0  bl       #0x4e9fec8 ; System.Collections.Generic.List<WeightRandomData>$$BinarySearch
004E9FFE4  ldr      x30, [sp, #0x80]
004E9FFE8  add      sp, sp, #0x90
004E9FFEC  ret      

; System.Collections.Generic.List<WeightRandomData>$$BinarySearch
; RVA 0x4E9FFF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004E9FFF0  sub      sp, sp, #0x90
004E9FFF4  str      x30, [sp, #0x80]
004E9FFF8  ldr      x8, [x3, #0x20]
004E9FFFC  ldp      q0, q1, [x1]
004EA0000  ldr      x9, [x1, #0x30]
004EA0004  ldr      q2, [x1, #0x20]
004EA0008  ldr      x8, [x8, #0xc0]
004EA000C  mov      x4, x2
004EA0010  ldr      w2, [x0, #0x18]
004EA0014  str      x9, [sp, #0x30]
004EA0018  stp      q1, q2, [sp, #0x10]
004EA001C  str      q0, [sp]
004EA0020  ldr      x5, [x8, #0xc0]
004EA0024  add      x3, sp, #0x40
004EA0028  mov      w1, wzr
004EA002C  stp      q0, q1, [sp, #0x40]
004EA0030  str      q2, [sp, #0x60]
004EA0034  str      x9, [sp, #0x70]
004EA0038  bl       #0x4e9fec8 ; System.Collections.Generic.List<WeightRandomData>$$BinarySearch
004EA003C  ldr      x30, [sp, #0x80]
004EA0040  add      sp, sp, #0x90
004EA0044  ret      

; System.Collections.Generic.List<WeightRandomData>$$Clear
; RVA 0x4EA0048; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0048  ldp      w2, w8, [x0, #0x18]
004EA004C  add      w8, w8, #1
004EA0050  cmp      w2, #1
004EA0054  stp      wzr, w8, [x0, #0x18]
004EA0058  b.lt     #0x4ea006c
004EA005C  ldr      x0, [x0, #0x10]
004EA0060  mov      w1, wzr
004EA0064  mov      x3, xzr
004EA0068  b        #0x7c001d0 ; System.Array$$Clear
004EA006C  ret      

; System.Collections.Generic.List<WeightRandomData>$$Contains
; RVA 0x4EA0070; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0070  sub      sp, sp, #0x90
004EA0074  str      x30, [sp, #0x80]
004EA0078  ldr      w3, [x0, #0x18]
004EA007C  cbz      w3, #0x4ea00d8
004EA0080  ldr      x8, [x1, #0x30]
004EA0084  ldp      q1, q0, [x1, #0x10]
004EA0088  ldr      q2, [x1]
004EA008C  add      x1, sp, #0x40
004EA0090  str      x8, [sp, #0x30]
004EA0094  stp      q1, q0, [sp, #0x10]
004EA0098  str      q2, [sp]
004EA009C  ldr      x9, [x2, #0x20]
004EA00A0  ldr      x0, [x0, #0x10]
004EA00A4  mov      w2, wzr
004EA00A8  ldr      x9, [x9, #0xc0]
004EA00AC  ldr      x9, [x9, #0xd0]
004EA00B0  ldr      x9, [x9, #0x20]
004EA00B4  ldr      x9, [x9, #0xc0]
004EA00B8  ldr      x4, [x9, #0x158]
004EA00BC  stp      q2, q1, [sp, #0x40]
004EA00C0  str      q0, [sp, #0x60]
004EA00C4  str      x8, [sp, #0x70]
004EA00C8  bl       #0x47c6f60 ; System.Array$$IndexOf<WeightRandomData>
004EA00CC  cmn      w0, #1
004EA00D0  cset     w0, ne
004EA00D4  b        #0x4ea00dc ; 
004EA00D8  mov      w0, wzr
004EA00DC  ldr      x30, [sp, #0x80]
004EA00E0  add      sp, sp, #0x90
004EA00E4  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.Contains
; RVA 0x4EA00E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA00E8  sub      sp, sp, #0xa0
004EA00EC  stp      x30, x21, [sp, #0x80]
004EA00F0  stp      x20, x19, [sp, #0x90]
004EA00F4  ldr      x8, [x2, #0x20]
004EA00F8  mov      x20, x2
004EA00FC  mov      x21, x1
004EA0100  mov      x19, x0
004EA0104  ldr      x8, [x8, #0xc0]
004EA0108  ldr      x8, [x8, #0x10]
004EA010C  ldrb     w9, [x8, #0x135]
004EA0110  tbnz     w9, #0, #0x4ea0120
004EA0114  mov      x0, x8
004EA0118  bl       #0x3a7e60c ; 
004EA011C  mov      x8, x0
004EA0120  ldr      w9, [x8, #0xe0]
004EA0124  cbnz     w9, #0x4ea0130
004EA0128  mov      x0, x8
004EA012C  bl       #0x382be8c ; 
004EA0130  ldr      x8, [x20, #0x20]
004EA0134  mov      x0, x21
004EA0138  ldr      x8, [x8, #0xc0]
004EA013C  ldr      x1, [x8, #0xd8]
004EA0140  bl       #0x4e9f8a8 ; System.Collections.Generic.List<WeightRandomData>$$IsCompatibleObject
004EA0144  tbz      w0, #0, #0x4ea01d4
004EA0148  ldr      x8, [x20, #0x20]
004EA014C  ldr      x8, [x8, #0xc0]
004EA0150  ldr      x1, [x8, #0x48]
004EA0154  ldrb     w8, [x1, #0x135]
004EA0158  tbnz     w8, #0, #0x4ea0168
004EA015C  mov      x0, x1
004EA0160  bl       #0x3a7e60c ; 
004EA0164  mov      x1, x0
004EA0168  cbz      x21, #0x4ea01ec
004EA016C  ldr      x8, [x21]
004EA0170  ldr      x9, [x1, #0x40]
004EA0174  mov      x0, x21
004EA0178  ldr      x8, [x8, #0x40]
004EA017C  cmp      x8, x9
004EA0180  b.ne     #0x4ea01f0
004EA0184  bl       #0x382be98 ; 
004EA0188  ldr      x8, [x0, #0x30]
004EA018C  ldp      q1, q0, [x0, #0x10]
004EA0190  ldr      q2, [x0]
004EA0194  add      x1, sp, #0x40
004EA0198  str      x8, [sp, #0x30]
004EA019C  stp      q1, q0, [sp, #0x10]
004EA01A0  str      q2, [sp]
004EA01A4  ldr      x8, [x20, #0x20]
004EA01A8  ldp      q0, q1, [sp]
004EA01AC  ldr      q2, [sp, #0x20]
004EA01B0  ldr      x9, [sp, #0x30]
004EA01B4  ldr      x8, [x8, #0xc0]
004EA01B8  mov      x0, x19
004EA01BC  ldr      x2, [x8, #0xe0]
004EA01C0  stp      q0, q1, [sp, #0x40]
004EA01C4  str      q2, [sp, #0x60]
004EA01C8  str      x9, [sp, #0x70]
004EA01CC  bl       #0x4ea0070 ; System.Collections.Generic.List<WeightRandomData>$$Contains
004EA01D0  b        #0x4ea01d8 ; 
004EA01D4  mov      w0, wzr
004EA01D8  ldp      x20, x19, [sp, #0x90]
004EA01DC  ldp      x30, x21, [sp, #0x80]
004EA01E0  and      w0, w0, #1
004EA01E4  add      sp, sp, #0xa0
004EA01E8  ret      
004EA01EC  bl       #0x382bfb8 ; 
004EA01F0  bl       #0x382c354 ; 

; System.Collections.Generic.List<WeightRandomData>$$CopyTo
; RVA 0x4EA01F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA01F4  ldr      x8, [x0, #0x10]
004EA01F8  ldr      w4, [x0, #0x18]
004EA01FC  mov      x2, x1
004EA0200  mov      w1, wzr
004EA0204  mov      x0, x8
004EA0208  mov      w3, wzr
004EA020C  mov      x5, xzr
004EA0210  b        #0x7c00484 ; System.Array$$Copy

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.ICollection.CopyTo
; RVA 0x4EA0214; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0214  stp      x30, x21, [sp, #-0x20]!
004EA0218  stp      x20, x19, [sp, #0x10]
004EA021C  mov      w19, w2
004EA0220  mov      x20, x1
004EA0224  mov      x21, x0
004EA0228  cbz      x1, #0x4ea024c
004EA022C  mov      x0, x20
004EA0230  mov      x1, xzr
004EA0234  bl       #0x7c00480 ; System.Array$$get_Rank
004EA0238  cmp      w0, #1
004EA023C  b.eq     #0x4ea024c
004EA0240  mov      w0, #7
004EA0244  mov      x1, xzr
004EA0248  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
004EA024C  ldr      x0, [x21, #0x10]
004EA0250  ldr      w4, [x21, #0x18]
004EA0254  mov      w1, wzr
004EA0258  mov      x2, x20
004EA025C  mov      w3, w19
004EA0260  mov      x5, xzr
004EA0264  bl       #0x7c00484 ; System.Array$$Copy
004EA0268  ldp      x20, x19, [sp, #0x10]
004EA026C  ldp      x30, x21, [sp], #0x20
004EA0270  ret      
004EA0274  cmp      w1, #1
004EA0278  mov      x19, x0
004EA027C  b.ne     #0x4ea02e4
004EA0280  mov      x0, x19
004EA0284  bl       #0x89eda50 ; 
004EA0288  mov      x19, x0
004EA028C  adrp     x0, #0x8ee7000
004EA0290  ldr      x0, [x0, #0x758]
004EA0294  bl       #0x382bd28 ; 
004EA0298  ldr      x8, [x19]
004EA029C  ldr      x1, [x8]
004EA02A0  bl       #0x382c3e4 ; 
004EA02A4  tbz      w0, #0, #0x4ea02bc
004EA02A8  bl       #0x89eda60 ; 
004EA02AC  ldp      x20, x19, [sp, #0x10]
004EA02B0  mov      x0, xzr
004EA02B4  ldp      x30, x21, [sp], #0x20
004EA02B8  b        #0x7bfe81c ; System.ThrowHelper$$ThrowArgumentException_Argument_InvalidArrayType
004EA02BC  mov      w0, #8
004EA02C0  bl       #0x89eda70 ; 
004EA02C4  ldr      x8, [x19]
004EA02C8  str      x8, [x0]
004EA02CC  adrp     x1, #0x89f3000
004EA02D0  add      x1, x1, #0xf98
004EA02D4  mov      x2, xzr
004EA02D8  bl       #0x89eda80 ; 
004EA02DC  mov      x19, x0
004EA02E0  bl       #0x89eda60 ; 
004EA02E4  mov      x0, x19
004EA02E8  bl       #0x3b56bfc ; 
004EA02EC  bl       #0x3442448 ; 

; System.Collections.Generic.List<WeightRandomData>$$CopyTo
; RVA 0x4EA02F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA02F0  stp      x30, x23, [sp, #-0x30]!
004EA02F4  stp      x22, x21, [sp, #0x10]
004EA02F8  stp      x20, x19, [sp, #0x20]
004EA02FC  ldr      w8, [x0, #0x18]
004EA0300  mov      w19, w4
004EA0304  mov      w20, w3
004EA0308  mov      x23, x0
004EA030C  sub      w8, w8, w1
004EA0310  mov      w21, w1
004EA0314  cmp      w8, w4
004EA0318  mov      x22, x2
004EA031C  b.ge     #0x4ea032c
004EA0320  mov      w0, #0x17
004EA0324  mov      x1, xzr
004EA0328  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
004EA032C  ldr      x0, [x23, #0x10]
004EA0330  mov      w1, w21
004EA0334  mov      x2, x22
004EA0338  mov      w3, w20
004EA033C  mov      w4, w19
004EA0340  ldp      x20, x19, [sp, #0x20]
004EA0344  ldp      x22, x21, [sp, #0x10]
004EA0348  mov      x5, xzr
004EA034C  ldp      x30, x23, [sp], #0x30
004EA0350  b        #0x7c00484 ; System.Array$$Copy

; System.Collections.Generic.List<WeightRandomData>$$CopyTo
; RVA 0x4EA0354; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0354  ldr      x8, [x0, #0x10]
004EA0358  ldr      w4, [x0, #0x18]
004EA035C  mov      w3, w2
004EA0360  mov      x2, x1
004EA0364  mov      x0, x8
004EA0368  mov      w1, wzr
004EA036C  mov      x5, xzr
004EA0370  b        #0x7c00484 ; System.Array$$Copy

; System.Collections.Generic.List<WeightRandomData>$$EnsureCapacity
; RVA 0x4EA0374; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0374  str      x30, [sp, #-0x10]!
004EA0378  ldr      x8, [x0, #0x10]
004EA037C  cbz      x8, #0x4ea03cc
004EA0380  ldr      x8, [x8, #0x18]
004EA0384  cmp      w8, w1
004EA0388  b.ge     #0x4ea03c4
004EA038C  ldr      x9, [x2, #0x20]
004EA0390  lsl      w10, w8, #1
004EA0394  mov      w11, #0x7fefffff
004EA0398  cmp      w10, w11
004EA039C  ldr      x9, [x9, #0xc0]
004EA03A0  csel     w10, w10, w11, lo
004EA03A4  cmp      x8, #0
004EA03A8  mov      w8, #4
004EA03AC  ldr      x2, [x9, #0xf0]
004EA03B0  csel     w8, w8, w10, eq
004EA03B4  cmp      w8, w1
004EA03B8  csel     w1, w1, w8, lt
004EA03BC  ldr      x30, [sp], #0x10
004EA03C0  b        #0x4e9f5c8 ; System.Collections.Generic.List<WeightRandomData>$$set_Capacity
004EA03C4  ldr      x30, [sp], #0x10
004EA03C8  ret      
004EA03CC  bl       #0x382bfb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$Exists
; RVA 0x4EA03D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA03D0  str      x30, [sp, #-0x10]!
004EA03D4  ldr      x8, [x2, #0x20]
004EA03D8  ldr      w2, [x0, #0x18]
004EA03DC  mov      x3, x1
004EA03E0  mov      w1, wzr
004EA03E4  ldr      x8, [x8, #0xc0]
004EA03E8  ldr      x8, [x8, #0x100]
004EA03EC  ldr      x8, [x8, #0x20]
004EA03F0  ldr      x8, [x8, #0xc0]
004EA03F4  ldr      x4, [x8, #0x118]
004EA03F8  bl       #0x4ea0758 ; System.Collections.Generic.List<WeightRandomData>$$FindIndex
004EA03FC  cmn      w0, #1
004EA0400  cset     w0, ne
004EA0404  ldr      x30, [sp], #0x10
004EA0408  ret      

; System.Collections.Generic.List<WeightRandomData>$$Find
; RVA 0x4EA040C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA040C  sub      sp, sp, #0xb0
004EA0410  stp      x30, x23, [sp, #0x80]
004EA0414  stp      x22, x21, [sp, #0x90]
004EA0418  stp      x20, x19, [sp, #0xa0]
004EA041C  mov      x21, x1
004EA0420  mov      x20, x0
004EA0424  mov      x19, x8
004EA0428  cbnz     x1, #0x4ea0434
004EA042C  mov      w0, #8
004EA0430  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA0434  ldr      w8, [x20, #0x18]
004EA0438  cmp      w8, #1
004EA043C  b.lt     #0x4ea04c0
004EA0440  mov      x23, xzr
004EA0444  mov      w22, #0x20
004EA0448  ldr      x8, [x20, #0x10]
004EA044C  cbz      x8, #0x4ea0518
004EA0450  ldr      w9, [x8, #0x18]
004EA0454  cmp      x23, x9
004EA0458  b.hs     #0x4ea051c
004EA045C  add      x8, x8, x22
004EA0460  ldr      x9, [x8, #0x30]
004EA0464  ldp      q1, q0, [x8, #0x10]
004EA0468  ldr      q2, [x8]
004EA046C  str      x9, [sp, #0x30]
004EA0470  stp      q1, q0, [sp, #0x10]
004EA0474  str      q2, [sp]
004EA0478  cbz      x21, #0x4ea0518
004EA047C  ldp      q0, q1, [sp]
004EA0480  ldr      q2, [sp, #0x20]
004EA0484  ldr      x9, [sp, #0x30]
004EA0488  ldr      x8, [x21, #0x18]
004EA048C  ldr      x0, [x21, #0x40]
004EA0490  stp      q0, q1, [sp, #0x40]
004EA0494  str      q2, [sp, #0x60]
004EA0498  str      x9, [sp, #0x70]
004EA049C  ldr      x2, [x21, #0x28]
004EA04A0  add      x1, sp, #0x40
004EA04A4  blr      x8
004EA04A8  tbnz     w0, #0, #0x4ea04d4
004EA04AC  ldrsw    x8, [x20, #0x18]
004EA04B0  add      x23, x23, #1
004EA04B4  add      x22, x22, #0x38
004EA04B8  cmp      x23, x8
004EA04BC  b.lt     #0x4ea0448
004EA04C0  movi     v0.2d, #0000000000000000
004EA04C4  str      xzr, [x19, #0x30]
004EA04C8  stp      q0, q0, [x19, #0x10]
004EA04CC  str      q0, [x19]
004EA04D0  b        #0x4ea0504 ; 
004EA04D4  ldr      x8, [x20, #0x10]
004EA04D8  cbz      x8, #0x4ea0518
004EA04DC  ldr      w9, [x8, #0x18]
004EA04E0  cmp      w23, w9
004EA04E4  b.hs     #0x4ea051c
004EA04E8  add      x8, x8, x22
004EA04EC  ldr      x9, [x8, #0x30]
004EA04F0  ldp      q1, q0, [x8, #0x10]
004EA04F4  ldr      q2, [x8]
004EA04F8  str      x9, [x19, #0x30]
004EA04FC  stp      q1, q0, [x19, #0x10]
004EA0500  str      q2, [x19]
004EA0504  ldp      x20, x19, [sp, #0xa0]
004EA0508  ldp      x22, x21, [sp, #0x90]
004EA050C  ldp      x30, x23, [sp, #0x80]
004EA0510  add      sp, sp, #0xb0
004EA0514  ret      
004EA0518  bl       #0x382bfb8 ; 
004EA051C  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$FindAll
; RVA 0x4EA0520; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0520  sub      sp, sp, #0x110
004EA0524  str      x29, [sp, #0xc0]
004EA0528  stp      x30, x25, [sp, #0xd0]
004EA052C  stp      x24, x23, [sp, #0xe0]
004EA0530  stp      x22, x21, [sp, #0xf0]
004EA0534  stp      x20, x19, [sp, #0x100]
004EA0538  mov      x19, x2
004EA053C  mov      x20, x1
004EA0540  mov      x21, x0
004EA0544  cbnz     x1, #0x4ea0550
004EA0548  mov      w0, #8
004EA054C  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA0550  ldr      x8, [x19, #0x20]
004EA0554  ldr      x8, [x8, #0xc0]
004EA0558  ldr      x0, [x8]
004EA055C  ldrb     w8, [x0, #0x135]
004EA0560  tbnz     w8, #0, #0x4ea0568
004EA0564  bl       #0x3a7e60c ; 
004EA0568  bl       #0x382bfa0 ; 
004EA056C  ldr      x8, [x19, #0x20]
004EA0570  mov      x22, x0
004EA0574  ldr      x8, [x8, #0xc0]
004EA0578  ldr      x1, [x8, #0x110]
004EA057C  bl       #0x4e9f210 ; System.Collections.Generic.List<WeightRandomData>$$.ctor
004EA0580  ldr      w8, [x21, #0x18]
004EA0584  cmp      w8, #1
004EA0588  b.lt     #0x4ea06f4
004EA058C  mov      x23, xzr
004EA0590  mov      w24, #0x20
004EA0594  mov      w25, #0x38
004EA0598  ldr      x8, [x21, #0x10]
004EA059C  cbz      x8, #0x4ea0714
004EA05A0  ldr      w9, [x8, #0x18]
004EA05A4  cmp      x23, x9
004EA05A8  b.hs     #0x4ea0718
004EA05AC  add      x8, x8, x24
004EA05B0  ldr      x9, [x8, #0x30]
004EA05B4  ldp      q1, q0, [x8, #0x10]
004EA05B8  ldr      q2, [x8]
004EA05BC  str      x9, [sp, #0x70]
004EA05C0  stp      q1, q0, [sp, #0x50]
004EA05C4  str      q2, [sp, #0x40]
004EA05C8  cbz      x20, #0x4ea0714
004EA05CC  ldp      q0, q1, [sp, #0x40]
004EA05D0  ldr      q2, [sp, #0x60]
004EA05D4  ldr      x9, [sp, #0x70]
004EA05D8  ldr      x8, [x20, #0x18]
004EA05DC  ldr      x0, [x20, #0x40]
004EA05E0  stp      q0, q1, [sp, #0x80]
004EA05E4  str      q2, [sp, #0xa0]
004EA05E8  str      x9, [sp, #0xb0]
004EA05EC  ldr      x2, [x20, #0x28]
004EA05F0  add      x1, sp, #0x80
004EA05F4  blr      x8
004EA05F8  tbz      w0, #0, #0x4ea06e0
004EA05FC  ldr      x8, [x21, #0x10]
004EA0600  cbz      x8, #0x4ea0714
004EA0604  ldr      w9, [x8, #0x18]
004EA0608  cmp      x23, x9
004EA060C  b.hs     #0x4ea0718
004EA0610  add      x8, x8, x24
004EA0614  ldr      x9, [x8, #0x30]
004EA0618  ldp      q1, q0, [x8, #0x10]
004EA061C  ldr      q2, [x8]
004EA0620  str      x9, [sp, #0x30]
004EA0624  stp      q1, q0, [sp, #0x10]
004EA0628  str      q2, [sp]
004EA062C  cbz      x22, #0x4ea0714
004EA0630  ldr      x8, [x19, #0x20]
004EA0634  ldp      q0, q1, [sp]
004EA0638  ldr      q2, [sp, #0x20]
004EA063C  ldr      x10, [sp, #0x30]
004EA0640  ldr      x8, [x8, #0xc0]
004EA0644  ldr      x9, [x8, #0x80]
004EA0648  stp      q0, q1, [sp, #0x40]
004EA064C  str      q2, [sp, #0x60]
004EA0650  str      x10, [sp, #0x70]
004EA0654  ldr      w10, [x22, #0x1c]
004EA0658  ldr      x8, [x22, #0x10]
004EA065C  add      w10, w10, #1
004EA0660  str      w10, [x22, #0x1c]
004EA0664  cbz      x8, #0x4ea0714
004EA0668  ldrsw    x10, [x22, #0x18]
004EA066C  ldr      w11, [x8, #0x18]
004EA0670  cmp      w10, w11
004EA0674  b.hs     #0x4ea06b0
004EA0678  add      w9, w10, #1
004EA067C  str      w9, [x22, #0x18]
004EA0680  ldp      q2, q0, [sp, #0x50]
004EA0684  ldr      x9, [sp, #0x70]
004EA0688  ldr      q1, [sp, #0x40]
004EA068C  nop      
004EA0690  madd     x8, x10, x25, x8
004EA0694  add      x0, x8, #0x30
004EA0698  mov      x1, xzr
004EA069C  str      x9, [x8, #0x50]
004EA06A0  stp      q2, q0, [x8, #0x30]
004EA06A4  str      q1, [x8, #0x20]
004EA06A8  bl       #0x382bcb8 ; 
004EA06AC  b        #0x4ea06e0 ; 
004EA06B0  ldr      x8, [x9, #0x20]
004EA06B4  ldp      q0, q1, [sp, #0x40]
004EA06B8  ldr      q2, [sp, #0x60]
004EA06BC  ldr      x9, [sp, #0x70]
004EA06C0  ldr      x8, [x8, #0xc0]
004EA06C4  add      x1, sp, #0x80
004EA06C8  mov      x0, x22
004EA06CC  ldr      x2, [x8, #0x70]
004EA06D0  stp      q0, q1, [sp, #0x80]
004EA06D4  str      q2, [sp, #0xa0]
004EA06D8  str      x9, [sp, #0xb0]
004EA06DC  bl       #0x4e9fb7c ; System.Collections.Generic.List<WeightRandomData>$$AddWithResize
004EA06E0  ldrsw    x8, [x21, #0x18]
004EA06E4  add      x23, x23, #1
004EA06E8  add      x24, x24, #0x38
004EA06EC  cmp      x23, x8
004EA06F0  b.lt     #0x4ea0598
004EA06F4  mov      x0, x22
004EA06F8  ldp      x20, x19, [sp, #0x100]
004EA06FC  ldp      x22, x21, [sp, #0xf0]
004EA0700  ldp      x24, x23, [sp, #0xe0]
004EA0704  ldp      x30, x25, [sp, #0xd0]
004EA0708  ldr      x29, [sp, #0xc0]
004EA070C  add      sp, sp, #0x110
004EA0710  ret      
004EA0714  bl       #0x382bfb8 ; 
004EA0718  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$FindIndex
; RVA 0x4EA071C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA071C  ldr      x8, [x2, #0x20]
004EA0720  ldr      w2, [x0, #0x18]
004EA0724  mov      x3, x1
004EA0728  mov      w1, wzr
004EA072C  ldr      x8, [x8, #0xc0]
004EA0730  ldr      x4, [x8, #0x118]
004EA0734  b        #0x4ea0758 ; System.Collections.Generic.List<WeightRandomData>$$FindIndex

; System.Collections.Generic.List<WeightRandomData>$$FindIndex
; RVA 0x4EA0738; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0738  ldr      x8, [x3, #0x20]
004EA073C  ldr      w9, [x0, #0x18]
004EA0740  mov      x3, x2
004EA0744  ldr      x8, [x8, #0xc0]
004EA0748  ldr      x4, [x8, #0x118]
004EA074C  sub      w8, w9, w1
004EA0750  mov      w2, w8
004EA0754  b        #0x4ea0758 ; System.Collections.Generic.List<WeightRandomData>$$FindIndex

; System.Collections.Generic.List<WeightRandomData>$$FindIndex
; RVA 0x4EA0758; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0758  sub      sp, sp, #0xb0
004EA075C  stp      x30, x23, [sp, #0x80]
004EA0760  stp      x22, x21, [sp, #0x90]
004EA0764  stp      x20, x19, [sp, #0xa0]
004EA0768  ldr      w8, [x0, #0x18]
004EA076C  mov      x20, x3
004EA0770  mov      x21, x0
004EA0774  mov      w19, w1
004EA0778  cmp      w8, w1
004EA077C  mov      w22, w2
004EA0780  b.hs     #0x4ea078c
004EA0784  mov      x0, xzr
004EA0788  bl       #0x7bfec9c ; System.ThrowHelper$$ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index
004EA078C  tbnz     w22, #0x1f, #0x4ea07a0
004EA0790  ldr      w8, [x21, #0x18]
004EA0794  sub      w8, w8, w22
004EA0798  cmp      w8, w19
004EA079C  b.ge     #0x4ea07a8
004EA07A0  mov      x0, xzr
004EA07A4  bl       #0x7bfecc8 ; System.ThrowHelper$$ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count
004EA07A8  cbnz     x20, #0x4ea07b8
004EA07AC  mov      w0, #8
004EA07B0  mov      x1, xzr
004EA07B4  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA07B8  add      w8, w22, w19
004EA07BC  cmp      w8, w19
004EA07C0  b.le     #0x4ea084c
004EA07C4  mov      w9, #0x38
004EA07C8  sxtw     x8, w8
004EA07CC  smull    x9, w19, w9
004EA07D0  add      x22, x9, #0x20
004EA07D4  sub      x23, x8, w19, sxtw
004EA07D8  ldr      x8, [x21, #0x10]
004EA07DC  cbz      x8, #0x4ea0868
004EA07E0  ldr      w9, [x8, #0x18]
004EA07E4  cmp      w19, w9
004EA07E8  b.hs     #0x4ea086c
004EA07EC  add      x8, x8, x22
004EA07F0  ldr      x9, [x8, #0x30]
004EA07F4  ldp      q1, q0, [x8, #0x10]
004EA07F8  ldr      q2, [x8]
004EA07FC  str      x9, [sp, #0x30]
004EA0800  stp      q1, q0, [sp, #0x10]
004EA0804  str      q2, [sp]
004EA0808  cbz      x20, #0x4ea0868
004EA080C  ldp      q0, q1, [sp]
004EA0810  ldr      q2, [sp, #0x20]
004EA0814  ldr      x9, [sp, #0x30]
004EA0818  ldr      x8, [x20, #0x18]
004EA081C  ldr      x0, [x20, #0x40]
004EA0820  stp      q0, q1, [sp, #0x40]
004EA0824  str      q2, [sp, #0x60]
004EA0828  str      x9, [sp, #0x70]
004EA082C  ldr      x2, [x20, #0x28]
004EA0830  add      x1, sp, #0x40
004EA0834  blr      x8
004EA0838  tbnz     w0, #0, #0x4ea0850
004EA083C  add      w19, w19, #1
004EA0840  subs     x23, x23, #1
004EA0844  add      x22, x22, #0x38
004EA0848  b.ne     #0x4ea07d8
004EA084C  mov      w19, #-1
004EA0850  mov      w0, w19
004EA0854  ldp      x20, x19, [sp, #0xa0]
004EA0858  ldp      x22, x21, [sp, #0x90]
004EA085C  ldp      x30, x23, [sp, #0x80]
004EA0860  add      sp, sp, #0xb0
004EA0864  ret      
004EA0868  bl       #0x382bfb8 ; 
004EA086C  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$FindLast
; RVA 0x4EA0870; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0870  sub      sp, sp, #0xb0
004EA0874  stp      x30, x23, [sp, #0x80]
004EA0878  stp      x22, x21, [sp, #0x90]
004EA087C  stp      x20, x19, [sp, #0xa0]
004EA0880  mov      x21, x1
004EA0884  mov      x20, x0
004EA0888  mov      x19, x8
004EA088C  cbnz     x1, #0x4ea0898
004EA0890  mov      w0, #8
004EA0894  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA0898  ldr      w22, [x20, #0x18]
004EA089C  mov      w23, #0x38
004EA08A0  subs     w22, w22, #1
004EA08A4  b.mi     #0x4ea0948
004EA08A8  ldr      x8, [x20, #0x10]
004EA08AC  cbz      x8, #0x4ea096c
004EA08B0  ldr      w9, [x8, #0x18]
004EA08B4  cmp      w22, w9
004EA08B8  b.hs     #0x4ea0970
004EA08BC  umaddl   x8, w22, w23, x8
004EA08C0  ldr      x9, [x8, #0x50]
004EA08C4  ldp      q1, q0, [x8, #0x30]
004EA08C8  ldr      q2, [x8, #0x20]
004EA08CC  str      x9, [sp, #0x30]
004EA08D0  stp      q1, q0, [sp, #0x10]
004EA08D4  str      q2, [sp]
004EA08D8  cbz      x21, #0x4ea096c
004EA08DC  ldp      q0, q1, [sp]
004EA08E0  ldr      q2, [sp, #0x20]
004EA08E4  ldr      x9, [sp, #0x30]
004EA08E8  ldr      x8, [x21, #0x18]
004EA08EC  ldr      x0, [x21, #0x40]
004EA08F0  stp      q0, q1, [sp, #0x40]
004EA08F4  str      q2, [sp, #0x60]
004EA08F8  str      x9, [sp, #0x70]
004EA08FC  ldr      x2, [x21, #0x28]
004EA0900  add      x1, sp, #0x40
004EA0904  blr      x8
004EA0908  tbz      w0, #0, #0x4ea08a0
004EA090C  ldr      x8, [x20, #0x10]
004EA0910  cbz      x8, #0x4ea096c
004EA0914  ldr      w9, [x8, #0x18]
004EA0918  cmp      w22, w9
004EA091C  b.hs     #0x4ea0970
004EA0920  mov      w9, w22
004EA0924  mov      w10, #0x38
004EA0928  madd     x8, x9, x10, x8
004EA092C  ldr      x9, [x8, #0x50]
004EA0930  ldp      q1, q0, [x8, #0x30]
004EA0934  ldr      q2, [x8, #0x20]
004EA0938  str      x9, [x19, #0x30]
004EA093C  stp      q1, q0, [x19, #0x10]
004EA0940  str      q2, [x19]
004EA0944  b        #0x4ea0958 ; 
004EA0948  movi     v0.2d, #0000000000000000
004EA094C  str      xzr, [x19, #0x30]
004EA0950  stp      q0, q0, [x19, #0x10]
004EA0954  str      q0, [x19]
004EA0958  ldp      x20, x19, [sp, #0xa0]
004EA095C  ldp      x22, x21, [sp, #0x90]
004EA0960  ldp      x30, x23, [sp, #0x80]
004EA0964  add      sp, sp, #0xb0
004EA0968  ret      
004EA096C  bl       #0x382bfb8 ; 
004EA0970  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$FindLastIndex
; RVA 0x4EA0974; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0974  ldr      x8, [x2, #0x20]
004EA0978  ldr      w2, [x0, #0x18]
004EA097C  mov      x3, x1
004EA0980  ldr      x8, [x8, #0xc0]
004EA0984  ldr      x4, [x8, #0x120]
004EA0988  sub      w8, w2, #1
004EA098C  mov      w1, w8
004EA0990  b        #0x4ea09b0 ; System.Collections.Generic.List<WeightRandomData>$$FindLastIndex

; System.Collections.Generic.List<WeightRandomData>$$FindLastIndex
; RVA 0x4EA0994; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0994  ldr      x9, [x3, #0x20]
004EA0998  mov      x8, x2
004EA099C  add      w2, w1, #1
004EA09A0  mov      x3, x8
004EA09A4  ldr      x9, [x9, #0xc0]
004EA09A8  ldr      x4, [x9, #0x120]
004EA09AC  b        #0x4ea09b0 ; System.Collections.Generic.List<WeightRandomData>$$FindLastIndex

; System.Collections.Generic.List<WeightRandomData>$$FindLastIndex
; RVA 0x4EA09B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA09B0  sub      sp, sp, #0xb0
004EA09B4  stp      x30, x23, [sp, #0x80]
004EA09B8  stp      x22, x21, [sp, #0x90]
004EA09BC  stp      x20, x19, [sp, #0xa0]
004EA09C0  mov      x19, x3
004EA09C4  mov      w21, w2
004EA09C8  mov      w22, w1
004EA09CC  mov      x20, x0
004EA09D0  cbnz     x3, #0x4ea09e0
004EA09D4  mov      w0, #8
004EA09D8  mov      x1, xzr
004EA09DC  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA09E0  ldr      w8, [x20, #0x18]
004EA09E4  cbz      w8, #0x4ea0ac0
004EA09E8  cmp      w8, w22
004EA09EC  b.hi     #0x4ea09f8
004EA09F0  mov      x0, xzr
004EA09F4  bl       #0x7bfec9c ; System.ThrowHelper$$ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index
004EA09F8  tbnz     w21, #0x1f, #0x4ea0a08
004EA09FC  sub      w8, w22, w21
004EA0A00  cmn      w8, #1
004EA0A04  b.pl     #0x4ea0a10
004EA0A08  mov      x0, xzr
004EA0A0C  bl       #0x7bfecc8 ; System.ThrowHelper$$ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count
004EA0A10  sub      w8, w22, w21
004EA0A14  cmp      w8, w22
004EA0A18  b.ge     #0x4ea0aa4
004EA0A1C  sxtw     x23, w8
004EA0A20  mov      w8, #0x38
004EA0A24  smull    x8, w22, w8
004EA0A28  sxtw     x21, w22
004EA0A2C  add      x22, x8, #0x20
004EA0A30  ldr      x8, [x20, #0x10]
004EA0A34  cbz      x8, #0x4ea0acc
004EA0A38  ldr      w9, [x8, #0x18]
004EA0A3C  cmp      w21, w9
004EA0A40  b.hs     #0x4ea0ad0
004EA0A44  add      x8, x8, x22
004EA0A48  ldr      x9, [x8, #0x30]
004EA0A4C  ldp      q1, q0, [x8, #0x10]
004EA0A50  ldr      q2, [x8]
004EA0A54  str      x9, [sp, #0x30]
004EA0A58  stp      q1, q0, [sp, #0x10]
004EA0A5C  str      q2, [sp]
004EA0A60  cbz      x19, #0x4ea0acc
004EA0A64  ldp      q0, q1, [sp]
004EA0A68  ldr      q2, [sp, #0x20]
004EA0A6C  ldr      x9, [sp, #0x30]
004EA0A70  ldr      x8, [x19, #0x18]
004EA0A74  ldr      x0, [x19, #0x40]
004EA0A78  stp      q0, q1, [sp, #0x40]
004EA0A7C  str      q2, [sp, #0x60]
004EA0A80  str      x9, [sp, #0x70]
004EA0A84  ldr      x2, [x19, #0x28]
004EA0A88  add      x1, sp, #0x40
004EA0A8C  blr      x8
004EA0A90  tbnz     w0, #0, #0x4ea0aa8
004EA0A94  sub      x21, x21, #1
004EA0A98  cmp      x21, x23
004EA0A9C  sub      x22, x22, #0x38
004EA0AA0  b.gt     #0x4ea0a30
004EA0AA4  mov      w21, #-1
004EA0AA8  mov      w0, w21
004EA0AAC  ldp      x20, x19, [sp, #0xa0]
004EA0AB0  ldp      x22, x21, [sp, #0x90]
004EA0AB4  ldp      x30, x23, [sp, #0x80]
004EA0AB8  add      sp, sp, #0xb0
004EA0ABC  ret      
004EA0AC0  cmn      w22, #1
004EA0AC4  b.ne     #0x4ea09f0
004EA0AC8  b        #0x4ea09f8 ; 
004EA0ACC  bl       #0x382bfb8 ; 
004EA0AD0  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$ForEach
; RVA 0x4EA0AD4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0AD4  sub      sp, sp, #0xb0
004EA0AD8  stp      x30, x23, [sp, #0x80]
004EA0ADC  stp      x22, x21, [sp, #0x90]
004EA0AE0  stp      x20, x19, [sp, #0xa0]
004EA0AE4  mov      x19, x1
004EA0AE8  mov      x20, x0
004EA0AEC  cbnz     x1, #0x4ea0af8
004EA0AF0  mov      w0, #0x21
004EA0AF4  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA0AF8  ldr      w8, [x20, #0x18]
004EA0AFC  cmp      w8, #1
004EA0B00  b.lt     #0x4ea0ba4
004EA0B04  ldr      w21, [x20, #0x1c]
004EA0B08  mov      x22, xzr
004EA0B0C  mov      w23, #0x20
004EA0B10  mov      w8, w21
004EA0B14  cmp      w21, w8
004EA0B18  b.ne     #0x4ea0b94
004EA0B1C  ldr      x8, [x20, #0x10]
004EA0B20  cbz      x8, #0x4ea0bb8
004EA0B24  ldr      w9, [x8, #0x18]
004EA0B28  cmp      x22, x9
004EA0B2C  b.hs     #0x4ea0bbc
004EA0B30  add      x8, x8, x23
004EA0B34  ldr      x9, [x8, #0x30]
004EA0B38  ldp      q1, q0, [x8, #0x10]
004EA0B3C  ldr      q2, [x8]
004EA0B40  str      x9, [sp, #0x30]
004EA0B44  stp      q1, q0, [sp, #0x10]
004EA0B48  str      q2, [sp]
004EA0B4C  cbz      x19, #0x4ea0bb8
004EA0B50  ldp      q0, q1, [sp]
004EA0B54  ldr      q2, [sp, #0x20]
004EA0B58  ldr      x9, [sp, #0x30]
004EA0B5C  ldr      x8, [x19, #0x18]
004EA0B60  ldr      x0, [x19, #0x40]
004EA0B64  stp      q0, q1, [sp, #0x40]
004EA0B68  str      q2, [sp, #0x60]
004EA0B6C  str      x9, [sp, #0x70]
004EA0B70  ldr      x2, [x19, #0x28]
004EA0B74  add      x1, sp, #0x40
004EA0B78  blr      x8
004EA0B7C  ldp      w9, w8, [x20, #0x18]
004EA0B80  add      x22, x22, #1
004EA0B84  sxtw     x9, w9
004EA0B88  cmp      x22, x9
004EA0B8C  add      x23, x23, #0x38
004EA0B90  b.lt     #0x4ea0b14
004EA0B94  cmp      w21, w8
004EA0B98  b.eq     #0x4ea0ba4
004EA0B9C  mov      x0, xzr
004EA0BA0  bl       #0x7bfe5b4 ; System.ThrowHelper$$ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion
004EA0BA4  ldp      x20, x19, [sp, #0xa0]
004EA0BA8  ldp      x22, x21, [sp, #0x90]
004EA0BAC  ldp      x30, x23, [sp, #0x80]
004EA0BB0  add      sp, sp, #0xb0
004EA0BB4  ret      
004EA0BB8  bl       #0x382bfb8 ; 
004EA0BBC  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
; RVA 0x4EA0BC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0BC0  movi     v0.2d, #0000000000000000
004EA0BC4  str      xzr, [x8, #0x40]
004EA0BC8  stp      q0, q0, [x8, #0x20]
004EA0BCC  stp      q0, q0, [x8]
004EA0BD0  ldr      x9, [x1, #0x20]
004EA0BD4  mov      x1, x0
004EA0BD8  mov      x0, x8
004EA0BDC  ldr      x9, [x9, #0xc0]
004EA0BE0  ldr      x2, [x9, #0x140]
004EA0BE4  b        #0x60f8494 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$.ctor

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.Generic.IEnumerable<T>.GetEnumerator
; RVA 0x4EA0BE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0BE8  sub      sp, sp, #0xb0
004EA0BEC  stp      x30, x19, [sp, #0xa0]
004EA0BF0  movi     v0.2d, #0000000000000000
004EA0BF4  str      xzr, [sp, #0x90]
004EA0BF8  stp      q0, q0, [sp, #0x70]
004EA0BFC  stp      q0, q0, [sp, #0x50]
004EA0C00  ldr      x8, [x1, #0x20]
004EA0C04  mov      x19, x1
004EA0C08  mov      x1, x0
004EA0C0C  add      x0, sp, #0x50
004EA0C10  ldr      x8, [x8, #0xc0]
004EA0C14  ldr      x2, [x8, #0x140]
004EA0C18  bl       #0x60f8494 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$.ctor
004EA0C1C  add      x0, sp, #8
004EA0C20  add      x1, sp, #0x50
004EA0C24  mov      w2, #0x48
004EA0C28  bl       #0x89edad0 ; 
004EA0C2C  ldr      x8, [x19, #0x20]
004EA0C30  add      x1, sp, #8
004EA0C34  ldr      x8, [x8, #0xc0]
004EA0C38  ldr      x0, [x8, #0x138]
004EA0C3C  bl       #0x382be94 ; 
004EA0C40  ldp      x30, x19, [sp, #0xa0]
004EA0C44  add      sp, sp, #0xb0
004EA0C48  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IEnumerable.GetEnumerator
; RVA 0x4EA0C4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0C4C  sub      sp, sp, #0xb0
004EA0C50  stp      x30, x19, [sp, #0xa0]
004EA0C54  movi     v0.2d, #0000000000000000
004EA0C58  str      xzr, [sp, #0x90]
004EA0C5C  stp      q0, q0, [sp, #0x70]
004EA0C60  stp      q0, q0, [sp, #0x50]
004EA0C64  ldr      x8, [x1, #0x20]
004EA0C68  mov      x19, x1
004EA0C6C  mov      x1, x0
004EA0C70  add      x0, sp, #0x50
004EA0C74  ldr      x8, [x8, #0xc0]
004EA0C78  ldr      x2, [x8, #0x140]
004EA0C7C  bl       #0x60f8494 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$.ctor
004EA0C80  add      x0, sp, #8
004EA0C84  add      x1, sp, #0x50
004EA0C88  mov      w2, #0x48
004EA0C8C  bl       #0x89edad0 ; 
004EA0C90  ldr      x8, [x19, #0x20]
004EA0C94  add      x1, sp, #8
004EA0C98  ldr      x8, [x8, #0xc0]
004EA0C9C  ldr      x0, [x8, #0x138]
004EA0CA0  bl       #0x382be94 ; 
004EA0CA4  ldp      x30, x19, [sp, #0xa0]
004EA0CA8  add      sp, sp, #0xb0
004EA0CAC  ret      

; System.Collections.Generic.List<WeightRandomData>$$GetRange
; RVA 0x4EA0CB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0CB0  str      x30, [sp, #-0x30]!
004EA0CB4  stp      x22, x21, [sp, #0x10]
004EA0CB8  stp      x20, x19, [sp, #0x20]
004EA0CBC  mov      x22, x3
004EA0CC0  mov      w19, w2
004EA0CC4  mov      w20, w1
004EA0CC8  mov      x21, x0
004EA0CCC  tbnz     w1, #0x1f, #0x4ea0d5c
004EA0CD0  tbnz     w19, #0x1f, #0x4ea0d68
004EA0CD4  ldr      w8, [x21, #0x18]
004EA0CD8  sub      w8, w8, w20
004EA0CDC  cmp      w8, w19
004EA0CE0  b.ge     #0x4ea0cf0
004EA0CE4  mov      w0, #0x17
004EA0CE8  mov      x1, xzr
004EA0CEC  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
004EA0CF0  ldr      x8, [x22, #0x20]
004EA0CF4  ldr      x8, [x8, #0xc0]
004EA0CF8  ldr      x0, [x8]
004EA0CFC  ldrb     w8, [x0, #0x135]
004EA0D00  tbnz     w8, #0, #0x4ea0d08
004EA0D04  bl       #0x3a7e60c ; 
004EA0D08  bl       #0x382bfa0 ; 
004EA0D0C  ldr      x8, [x22, #0x20]
004EA0D10  mov      w1, w19
004EA0D14  mov      x22, x0
004EA0D18  ldr      x8, [x8, #0xc0]
004EA0D1C  ldr      x2, [x8, #0x150]
004EA0D20  bl       #0x4e9f280 ; System.Collections.Generic.List<WeightRandomData>$$.ctor
004EA0D24  cbz      x22, #0x4ea0d7c
004EA0D28  ldr      x0, [x21, #0x10]
004EA0D2C  ldr      x2, [x22, #0x10]
004EA0D30  mov      w1, w20
004EA0D34  mov      w3, wzr
004EA0D38  mov      w4, w19
004EA0D3C  mov      x5, xzr
004EA0D40  bl       #0x7c00484 ; System.Array$$Copy
004EA0D44  str      w19, [x22, #0x18]
004EA0D48  mov      x0, x22
004EA0D4C  ldp      x20, x19, [sp, #0x20]
004EA0D50  ldp      x22, x21, [sp, #0x10]
004EA0D54  ldr      x30, [sp], #0x30
004EA0D58  ret      
004EA0D5C  mov      x0, xzr
004EA0D60  bl       #0x7bfe7e4 ; System.ThrowHelper$$ThrowIndexArgumentOutOfRange_NeedNonNegNumException
004EA0D64  tbz      w19, #0x1f, #0x4ea0cd4
004EA0D68  mov      w0, #0x10
004EA0D6C  mov      w1, #4
004EA0D70  mov      x2, xzr
004EA0D74  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA0D78  b        #0x4ea0cd4 ; 
004EA0D7C  bl       #0x382bfb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$IndexOf
; RVA 0x4EA0D80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0D80  sub      sp, sp, #0x90
004EA0D84  str      x30, [sp, #0x80]
004EA0D88  ldp      q2, q0, [x1, #0x10]
004EA0D8C  ldr      x9, [x1, #0x30]
004EA0D90  ldr      q1, [x1]
004EA0D94  ldr      x8, [x0, #0x10]
004EA0D98  stp      q2, q0, [sp, #0x10]
004EA0D9C  str      x9, [sp, #0x30]
004EA0DA0  str      q1, [sp]
004EA0DA4  ldr      x10, [x2, #0x20]
004EA0DA8  ldr      w3, [x0, #0x18]
004EA0DAC  add      x1, sp, #0x40
004EA0DB0  mov      x0, x8
004EA0DB4  ldr      x10, [x10, #0xc0]
004EA0DB8  mov      w2, wzr
004EA0DBC  ldr      x4, [x10, #0x158]
004EA0DC0  stp      q1, q2, [sp, #0x40]
004EA0DC4  str      q0, [sp, #0x60]
004EA0DC8  str      x9, [sp, #0x70]
004EA0DCC  bl       #0x47c6f60 ; System.Array$$IndexOf<WeightRandomData>
004EA0DD0  ldr      x30, [sp, #0x80]
004EA0DD4  add      sp, sp, #0x90
004EA0DD8  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.IndexOf
; RVA 0x4EA0DDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0DDC  sub      sp, sp, #0xa0
004EA0DE0  stp      x30, x21, [sp, #0x80]
004EA0DE4  stp      x20, x19, [sp, #0x90]
004EA0DE8  ldr      x8, [x2, #0x20]
004EA0DEC  mov      x19, x2
004EA0DF0  mov      x21, x1
004EA0DF4  mov      x20, x0
004EA0DF8  ldr      x8, [x8, #0xc0]
004EA0DFC  ldr      x8, [x8, #0x10]
004EA0E00  ldrb     w9, [x8, #0x135]
004EA0E04  tbnz     w9, #0, #0x4ea0e14
004EA0E08  mov      x0, x8
004EA0E0C  bl       #0x3a7e60c ; 
004EA0E10  mov      x8, x0
004EA0E14  ldr      w9, [x8, #0xe0]
004EA0E18  cbnz     w9, #0x4ea0e24
004EA0E1C  mov      x0, x8
004EA0E20  bl       #0x382be8c ; 
004EA0E24  ldr      x8, [x19, #0x20]
004EA0E28  mov      x0, x21
004EA0E2C  ldr      x8, [x8, #0xc0]
004EA0E30  ldr      x1, [x8, #0xd8]
004EA0E34  bl       #0x4e9f8a8 ; System.Collections.Generic.List<WeightRandomData>$$IsCompatibleObject
004EA0E38  tbz      w0, #0, #0x4ea0edc
004EA0E3C  ldr      x8, [x19, #0x20]
004EA0E40  ldr      x8, [x8, #0xc0]
004EA0E44  ldr      x1, [x8, #0x48]
004EA0E48  ldrb     w8, [x1, #0x135]
004EA0E4C  tbnz     w8, #0, #0x4ea0e5c
004EA0E50  mov      x0, x1
004EA0E54  bl       #0x3a7e60c ; 
004EA0E58  mov      x1, x0
004EA0E5C  cbz      x21, #0x4ea0ef0
004EA0E60  ldr      x8, [x21]
004EA0E64  ldr      x9, [x1, #0x40]
004EA0E68  mov      x0, x21
004EA0E6C  ldr      x8, [x8, #0x40]
004EA0E70  cmp      x8, x9
004EA0E74  b.ne     #0x4ea0ef4
004EA0E78  bl       #0x382be98 ; 
004EA0E7C  ldr      x8, [x0, #0x30]
004EA0E80  ldp      q2, q0, [x0, #0x10]
004EA0E84  ldr      q1, [x0]
004EA0E88  add      x1, sp, #0x40
004EA0E8C  str      x8, [sp, #0x30]
004EA0E90  stp      q2, q0, [sp, #0x10]
004EA0E94  str      q1, [sp]
004EA0E98  ldr      x8, [x19, #0x20]
004EA0E9C  ldr      x0, [x20, #0x10]
004EA0EA0  ldr      w3, [x20, #0x18]
004EA0EA4  ldp      q0, q1, [sp]
004EA0EA8  ldr      x8, [x8, #0xc0]
004EA0EAC  ldr      q2, [sp, #0x20]
004EA0EB0  ldr      x9, [sp, #0x30]
004EA0EB4  mov      w2, wzr
004EA0EB8  ldr      x8, [x8, #0xd0]
004EA0EBC  ldr      x8, [x8, #0x20]
004EA0EC0  ldr      x8, [x8, #0xc0]
004EA0EC4  ldr      x4, [x8, #0x158]
004EA0EC8  stp      q0, q1, [sp, #0x40]
004EA0ECC  str      q2, [sp, #0x60]
004EA0ED0  str      x9, [sp, #0x70]
004EA0ED4  bl       #0x47c6f60 ; System.Array$$IndexOf<WeightRandomData>
004EA0ED8  b        #0x4ea0ee0 ; 
004EA0EDC  mov      w0, #-1
004EA0EE0  ldp      x20, x19, [sp, #0x90]
004EA0EE4  ldp      x30, x21, [sp, #0x80]
004EA0EE8  add      sp, sp, #0xa0
004EA0EEC  ret      
004EA0EF0  bl       #0x382bfb8 ; 
004EA0EF4  bl       #0x382c354 ; 

; System.Collections.Generic.List<WeightRandomData>$$IndexOf
; RVA 0x4EA0EF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0EF8  sub      sp, sp, #0xb0
004EA0EFC  str      x30, [sp, #0x80]
004EA0F00  stp      x22, x21, [sp, #0x90]
004EA0F04  stp      x20, x19, [sp, #0xa0]
004EA0F08  ldr      w8, [x0, #0x18]
004EA0F0C  mov      x20, x3
004EA0F10  mov      x21, x0
004EA0F14  mov      w19, w2
004EA0F18  cmp      w8, w2
004EA0F1C  mov      x22, x1
004EA0F20  b.ge     #0x4ea0f30
004EA0F24  mov      x0, xzr
004EA0F28  bl       #0x7bfe7ac ; System.ThrowHelper$$ThrowArgumentOutOfRange_IndexException
004EA0F2C  ldr      w8, [x21, #0x18]
004EA0F30  ldp      q2, q0, [x22, #0x10]
004EA0F34  ldr      x9, [x22, #0x30]
004EA0F38  ldr      q1, [x22]
004EA0F3C  ldr      x0, [x21, #0x10]
004EA0F40  stp      q2, q0, [sp, #0x10]
004EA0F44  str      x9, [sp, #0x30]
004EA0F48  str      q1, [sp]
004EA0F4C  ldr      x10, [x20, #0x20]
004EA0F50  sub      w3, w8, w19
004EA0F54  add      x1, sp, #0x40
004EA0F58  mov      w2, w19
004EA0F5C  ldr      x10, [x10, #0xc0]
004EA0F60  ldr      x4, [x10, #0x158]
004EA0F64  stp      q1, q2, [sp, #0x40]
004EA0F68  str      q0, [sp, #0x60]
004EA0F6C  str      x9, [sp, #0x70]
004EA0F70  bl       #0x47c6f60 ; System.Array$$IndexOf<WeightRandomData>
004EA0F74  ldp      x20, x19, [sp, #0xa0]
004EA0F78  ldp      x22, x21, [sp, #0x90]
004EA0F7C  ldr      x30, [sp, #0x80]
004EA0F80  add      sp, sp, #0xb0
004EA0F84  ret      

; System.Collections.Generic.List<WeightRandomData>$$IndexOf
; RVA 0x4EA0F88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA0F88  sub      sp, sp, #0xb0
004EA0F8C  stp      x30, x23, [sp, #0x80]
004EA0F90  stp      x22, x21, [sp, #0x90]
004EA0F94  stp      x20, x19, [sp, #0xa0]
004EA0F98  ldr      w8, [x0, #0x18]
004EA0F9C  mov      x21, x4
004EA0FA0  mov      w19, w3
004EA0FA4  mov      x22, x0
004EA0FA8  mov      w20, w2
004EA0FAC  cmp      w8, w2
004EA0FB0  mov      x23, x1
004EA0FB4  b.ge     #0x4ea0fc0
004EA0FB8  mov      x0, xzr
004EA0FBC  bl       #0x7bfe7ac ; System.ThrowHelper$$ThrowArgumentOutOfRange_IndexException
004EA0FC0  tbnz     w19, #0x1f, #0x4ea0fd4
004EA0FC4  ldr      w8, [x22, #0x18]
004EA0FC8  sub      w8, w8, w19
004EA0FCC  cmp      w8, w20
004EA0FD0  b.ge     #0x4ea0fdc
004EA0FD4  mov      x0, xzr
004EA0FD8  bl       #0x7bfecc8 ; System.ThrowHelper$$ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count
004EA0FDC  ldp      q2, q0, [x23, #0x10]
004EA0FE0  ldr      x8, [x23, #0x30]
004EA0FE4  ldr      q1, [x23]
004EA0FE8  ldr      x0, [x22, #0x10]
004EA0FEC  stp      q2, q0, [sp, #0x10]
004EA0FF0  str      x8, [sp, #0x30]
004EA0FF4  str      q1, [sp]
004EA0FF8  ldr      x9, [x21, #0x20]
004EA0FFC  add      x1, sp, #0x40
004EA1000  mov      w2, w20
004EA1004  mov      w3, w19
004EA1008  ldr      x9, [x9, #0xc0]
004EA100C  ldr      x4, [x9, #0x158]
004EA1010  stp      q1, q2, [sp, #0x40]
004EA1014  str      q0, [sp, #0x60]
004EA1018  str      x8, [sp, #0x70]
004EA101C  bl       #0x47c6f60 ; System.Array$$IndexOf<WeightRandomData>
004EA1020  ldp      x20, x19, [sp, #0xa0]
004EA1024  ldp      x22, x21, [sp, #0x90]
004EA1028  ldp      x30, x23, [sp, #0x80]
004EA102C  add      sp, sp, #0xb0
004EA1030  ret      

; System.Collections.Generic.List<WeightRandomData>$$Insert
; RVA 0x4EA1034; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1034  sub      sp, sp, #0xb0
004EA1038  str      x30, [sp, #0x80]
004EA103C  stp      x22, x21, [sp, #0x90]
004EA1040  stp      x20, x19, [sp, #0xa0]
004EA1044  ldr      w8, [x0, #0x18]
004EA1048  mov      x22, x3
004EA104C  mov      x19, x0
004EA1050  mov      w20, w1
004EA1054  cmp      w8, w1
004EA1058  mov      x21, x2
004EA105C  b.hs     #0x4ea1074
004EA1060  mov      w0, #0xd
004EA1064  mov      w1, #0x1b
004EA1068  mov      x2, xzr
004EA106C  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA1070  ldr      w8, [x19, #0x18]
004EA1074  ldr      x9, [x19, #0x10]
004EA1078  cbz      x9, #0x4ea115c
004EA107C  ldr      w9, [x9, #0x18]
004EA1080  cmp      w8, w9
004EA1084  b.ne     #0x4ea10a4
004EA1088  ldr      x9, [x22, #0x20]
004EA108C  add      w1, w8, #1
004EA1090  mov      x0, x19
004EA1094  ldr      x9, [x9, #0xc0]
004EA1098  ldr      x2, [x9, #0x78]
004EA109C  bl       #0x4ea0374 ; System.Collections.Generic.List<WeightRandomData>$$EnsureCapacity
004EA10A0  ldr      w8, [x19, #0x18]
004EA10A4  subs     w4, w8, w20
004EA10A8  b.le     #0x4ea10c4
004EA10AC  ldr      x0, [x19, #0x10]
004EA10B0  add      w3, w20, #1
004EA10B4  mov      w1, w20
004EA10B8  mov      x5, xzr
004EA10BC  mov      x2, x0
004EA10C0  bl       #0x7c00484 ; System.Array$$Copy
004EA10C4  ldp      q2, q0, [x21, #0x10]
004EA10C8  ldr      x9, [x21, #0x30]
004EA10CC  ldr      q1, [x21]
004EA10D0  ldr      x8, [x19, #0x10]
004EA10D4  stp      q2, q0, [sp, #0x50]
004EA10D8  str      x9, [sp, #0x70]
004EA10DC  str      q1, [sp, #0x40]
004EA10E0  cbz      x8, #0x4ea115c
004EA10E4  ldp      q0, q1, [sp, #0x40]
004EA10E8  ldr      q2, [sp, #0x60]
004EA10EC  ldr      x9, [sp, #0x70]
004EA10F0  stp      q0, q1, [sp]
004EA10F4  str      q2, [sp, #0x20]
004EA10F8  str      x9, [sp, #0x30]
004EA10FC  ldr      w9, [x8, #0x18]
004EA1100  cmp      w9, w20
004EA1104  b.ls     #0x4ea1160
004EA1108  ldp      q2, q0, [sp, #0x10]
004EA110C  ldr      x11, [sp, #0x30]
004EA1110  ldr      q1, [sp]
004EA1114  sxtw     x9, w20
004EA1118  mov      w10, #0x38
004EA111C  madd     x8, x9, x10, x8
004EA1120  add      x0, x8, #0x30
004EA1124  mov      x1, xzr
004EA1128  str      x11, [x8, #0x50]
004EA112C  stp      q2, q0, [x8, #0x30]
004EA1130  str      q1, [x8, #0x20]
004EA1134  bl       #0x382bcb8 ; 
004EA1138  ldr      d0, [x19, #0x18]
004EA113C  movi     v1.2s, #1
004EA1140  ldp      x22, x21, [sp, #0x90]
004EA1144  ldr      x30, [sp, #0x80]
004EA1148  add      v0.2s, v0.2s, v1.2s
004EA114C  str      d0, [x19, #0x18]
004EA1150  ldp      x20, x19, [sp, #0xa0]
004EA1154  add      sp, sp, #0xb0
004EA1158  ret      
004EA115C  bl       #0x382bfb8 ; 
004EA1160  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.Insert
; RVA 0x4EA1164; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1164  sub      sp, sp, #0xb0
004EA1168  str      x30, [sp, #0x80]
004EA116C  stp      x22, x21, [sp, #0x90]
004EA1170  stp      x20, x19, [sp, #0xa0]
004EA1174  ldr      x8, [x3, #0x20]
004EA1178  mov      x19, x2
004EA117C  mov      w21, w1
004EA1180  mov      x22, x0
004EA1184  ldr      x8, [x8, #0xc0]
004EA1188  mov      w1, #0x14
004EA118C  mov      x0, x19
004EA1190  mov      x20, x3
004EA1194  ldr      x2, [x8, #0x58]
004EA1198  bl       #0x471e6d0 ; System.ThrowHelper$$IfNullAndNullsAreIllegalThenThrow<WeightRandomData>
004EA119C  ldr      x8, [x20, #0x20]
004EA11A0  ldr      x8, [x8, #0xc0]
004EA11A4  ldr      x1, [x8, #0x48]
004EA11A8  ldrb     w8, [x1, #0x135]
004EA11AC  tbnz     w8, #0, #0x4ea11bc
004EA11B0  mov      x0, x1
004EA11B4  bl       #0x3a7e60c ; 
004EA11B8  mov      x1, x0
004EA11BC  cbz      x19, #0x4ea1230
004EA11C0  ldr      x8, [x19]
004EA11C4  ldr      x9, [x1, #0x40]
004EA11C8  ldr      x8, [x8, #0x40]
004EA11CC  cmp      x8, x9
004EA11D0  b.ne     #0x4ea1234
004EA11D4  mov      x0, x19
004EA11D8  bl       #0x382be98 ; 
004EA11DC  ldr      x8, [x0, #0x30]
004EA11E0  ldp      q1, q0, [x0, #0x10]
004EA11E4  ldr      q2, [x0]
004EA11E8  str      x8, [sp, #0x30]
004EA11EC  stp      q1, q0, [sp, #0x10]
004EA11F0  str      q2, [sp]
004EA11F4  ldr      x9, [x20, #0x20]
004EA11F8  ldr      x9, [x9, #0xc0]
004EA11FC  ldr      x3, [x9, #0x160]
004EA1200  stp      q2, q1, [sp, #0x40]
004EA1204  str      q0, [sp, #0x60]
004EA1208  str      x8, [sp, #0x70]
004EA120C  add      x2, sp, #0x40
004EA1210  mov      x0, x22
004EA1214  mov      w1, w21
004EA1218  bl       #0x4ea1034 ; System.Collections.Generic.List<WeightRandomData>$$Insert
004EA121C  ldp      x20, x19, [sp, #0xa0]
004EA1220  ldp      x22, x21, [sp, #0x90]
004EA1224  ldr      x30, [sp, #0x80]
004EA1228  add      sp, sp, #0xb0
004EA122C  ret      
004EA1230  bl       #0x382bfb8 ; 
004EA1234  mov      x0, x19
004EA1238  bl       #0x382c354 ; 
004EA123C  cmp      w1, #1
004EA1240  mov      x21, x0
004EA1244  b.ne     #0x4ea12ec
004EA1248  mov      x0, x21
004EA124C  bl       #0x89eda50 ; 
004EA1250  mov      x21, x0
004EA1254  adrp     x0, #0x8ec6000
004EA1258  ldr      x0, [x0, #0xf48]
004EA125C  bl       #0x382bd28 ; 
004EA1260  ldr      x8, [x21]
004EA1264  ldr      x1, [x8]
004EA1268  bl       #0x382c3e4 ; 
004EA126C  tbz      w0, #0, #0x4ea12c4
004EA1270  bl       #0x89eda60 ; 
004EA1274  ldr      x8, [x20, #0x20]
004EA1278  adrp     x0, #0x8ebf000
004EA127C  ldr      x8, [x8, #0xc0]
004EA1280  ldr      x20, [x8, #0x68]
004EA1284  ldr      x0, [x0, #0x3a8]
004EA1288  bl       #0x382bd28 ; 
004EA128C  ldr      w8, [x0, #0xe0]
004EA1290  cbnz     w8, #0x4ea1298
004EA1294  bl       #0x382be8c ; 
004EA1298  mov      x0, x20
004EA129C  mov      x1, xzr
004EA12A0  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
004EA12A4  mov      x1, x0
004EA12A8  mov      x0, x19
004EA12AC  ldp      x20, x19, [sp, #0xa0]
004EA12B0  ldp      x22, x21, [sp, #0x90]
004EA12B4  ldr      x30, [sp, #0x80]
004EA12B8  mov      x2, xzr
004EA12BC  add      sp, sp, #0xb0
004EA12C0  b        #0x7bfde90 ; System.ThrowHelper$$ThrowWrongValueTypeArgumentException
004EA12C4  mov      w0, #8
004EA12C8  bl       #0x89eda70 ; 
004EA12CC  ldr      x8, [x21]
004EA12D0  str      x8, [x0]
004EA12D4  adrp     x1, #0x89f3000
004EA12D8  add      x1, x1, #0xf98
004EA12DC  mov      x2, xzr
004EA12E0  bl       #0x89eda80 ; 
004EA12E4  mov      x21, x0
004EA12E8  bl       #0x89eda60 ; 
004EA12EC  mov      x0, x21
004EA12F0  bl       #0x3b56bfc ; 
004EA12F4  bl       #0x3442448 ; 

; System.Collections.Generic.List<WeightRandomData>$$InsertRange
; RVA 0x4EA12F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA12F8  sub      sp, sp, #0xc0
004EA12FC  str      x30, [sp, #0x80]
004EA1300  stp      x24, x23, [sp, #0x90]
004EA1304  stp      x22, x21, [sp, #0xa0]
004EA1308  stp      x20, x19, [sp, #0xb0]
004EA130C  adrp     x23, #0x9592000
004EA1310  ldrb     w8, [x23, #0x833]
004EA1314  mov      x20, x3
004EA1318  mov      x22, x2
004EA131C  mov      w21, w1
004EA1320  mov      x19, x0
004EA1324  tbnz     w8, #0, #0x4ea1348
004EA1328  adrp     x0, #0x8ebf000
004EA132C  ldr      x0, [x0, #0x4e8]
004EA1330  bl       #0x382bd14 ; 
004EA1334  adrp     x0, #0x8ebf000
004EA1338  ldr      x0, [x0, #0x4f0]
004EA133C  bl       #0x382bd14 ; 
004EA1340  mov      w8, #1
004EA1344  strb     w8, [x23, #0x833]
004EA1348  cbnz     x22, #0x4ea1358
004EA134C  mov      w0, #6
004EA1350  mov      x1, xzr
004EA1354  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA1358  ldr      w8, [x19, #0x18]
004EA135C  cmp      w8, w21
004EA1360  b.hs     #0x4ea136c
004EA1364  mov      x0, xzr
004EA1368  bl       #0x7bfe7ac ; System.ThrowHelper$$ThrowArgumentOutOfRange_IndexException
004EA136C  ldr      x8, [x20, #0x20]
004EA1370  ldr      x8, [x8, #0xc0]
004EA1374  ldr      x1, [x8, #0x28]
004EA1378  ldrb     w8, [x1, #0x135]
004EA137C  tbnz     w8, #0, #0x4ea138c
004EA1380  mov      x0, x1
004EA1384  bl       #0x3a7e60c ; 
004EA1388  mov      x1, x0
004EA138C  mov      x0, x22
004EA1390  bl       #0x382be90 ; 
004EA1394  cbz      x0, #0x4ea13f8
004EA1398  ldr      x8, [x20, #0x20]
004EA139C  mov      x23, x0
004EA13A0  ldr      x8, [x8, #0xc0]
004EA13A4  ldr      x1, [x8, #0x28]
004EA13A8  ldrb     w8, [x1, #0x135]
004EA13AC  tbnz     w8, #0, #0x4ea13bc
004EA13B0  mov      x0, x1
004EA13B4  bl       #0x3a7e60c ; 
004EA13B8  mov      x1, x0
004EA13BC  ldr      x8, [x23]
004EA13C0  ldrh     w9, [x8, #0x12e]
004EA13C4  cbz      x9, #0x4ea13e8
004EA13C8  ldr      x10, [x8, #0xb0]
004EA13CC  add      x10, x10, #8
004EA13D0  ldur     x11, [x10, #-8]
004EA13D4  cmp      x11, x1
004EA13D8  b.eq     #0x4ea1464
004EA13DC  subs     x9, x9, #1
004EA13E0  add      x10, x10, #0x10
004EA13E4  b.ne     #0x4ea13d0
004EA13E8  mov      x0, x23
004EA13EC  mov      w2, wzr
004EA13F0  bl       #0x3a7e710 ; 
004EA13F4  b        #0x4ea1470 ; 
004EA13F8  ldr      w8, [x19, #0x18]
004EA13FC  cmp      w8, w21
004EA1400  b.le     #0x4ea1764
004EA1404  cbz      x22, #0x4ea17a0
004EA1408  ldr      x8, [x20, #0x20]
004EA140C  ldr      x8, [x8, #0xc0]
004EA1410  ldr      x1, [x8, #0x20]
004EA1414  ldrb     w8, [x1, #0x135]
004EA1418  tbnz     w8, #0, #0x4ea1428
004EA141C  mov      x0, x1
004EA1420  bl       #0x3a7e60c ; 
004EA1424  mov      x1, x0
004EA1428  ldr      x8, [x22]
004EA142C  ldrh     w9, [x8, #0x12e]
004EA1430  cbz      x9, #0x4ea1454
004EA1434  ldr      x10, [x8, #0xb0]
004EA1438  add      x10, x10, #8
004EA143C  ldur     x11, [x10, #-8]
004EA1440  cmp      x11, x1
004EA1444  b.eq     #0x4ea15a4
004EA1448  subs     x9, x9, #1
004EA144C  add      x10, x10, #0x10
004EA1450  b.ne     #0x4ea143c
004EA1454  mov      x0, x22
004EA1458  mov      w2, wzr
004EA145C  bl       #0x3a7e710 ; 
004EA1460  b        #0x4ea15b0 ; 
004EA1464  ldrsw    x9, [x10]
004EA1468  add      x8, x8, x9, lsl #4
004EA146C  add      x0, x8, #0x138
004EA1470  ldp      x8, x1, [x0]
004EA1474  mov      x0, x23
004EA1478  blr      x8
004EA147C  cmp      w0, #1
004EA1480  b.lt     #0x4ea177c
004EA1484  ldr      x8, [x20, #0x20]
004EA1488  ldr      w9, [x19, #0x18]
004EA148C  mov      w22, w0
004EA1490  ldr      x8, [x8, #0xc0]
004EA1494  add      w1, w9, w0
004EA1498  mov      x0, x19
004EA149C  ldr      x2, [x8, #0x78]
004EA14A0  bl       #0x4ea0374 ; System.Collections.Generic.List<WeightRandomData>$$EnsureCapacity
004EA14A4  ldr      w8, [x19, #0x18]
004EA14A8  subs     w4, w8, w21
004EA14AC  b.le     #0x4ea14c8
004EA14B0  ldr      x0, [x19, #0x10]
004EA14B4  add      w3, w22, w21
004EA14B8  mov      w1, w21
004EA14BC  mov      x5, xzr
004EA14C0  mov      x2, x0
004EA14C4  bl       #0x7c00484 ; System.Array$$Copy
004EA14C8  cmp      x19, x23
004EA14CC  b.eq     #0x4ea1530
004EA14D0  ldr      x8, [x20, #0x20]
004EA14D4  ldr      x20, [x19, #0x10]
004EA14D8  ldr      x8, [x8, #0xc0]
004EA14DC  ldr      x1, [x8, #0x28]
004EA14E0  ldrb     w8, [x1, #0x135]
004EA14E4  tbnz     w8, #0, #0x4ea14f4
004EA14E8  mov      x0, x1
004EA14EC  bl       #0x3a7e60c ; 
004EA14F0  mov      x1, x0
004EA14F4  ldr      x8, [x23]
004EA14F8  ldrh     w9, [x8, #0x12e]
004EA14FC  cbz      x9, #0x4ea1520
004EA1500  ldr      x10, [x8, #0xb0]
004EA1504  add      x10, x10, #8
004EA1508  ldur     x11, [x10, #-8]
004EA150C  cmp      x11, x1
004EA1510  b.eq     #0x4ea1570
004EA1514  subs     x9, x9, #1
004EA1518  add      x10, x10, #0x10
004EA151C  b.ne     #0x4ea1508
004EA1520  mov      w2, #5
004EA1524  mov      x0, x23
004EA1528  bl       #0x3a7e710 ; 
004EA152C  b        #0x4ea1580 ; 
004EA1530  ldr      x0, [x19, #0x10]
004EA1534  mov      w1, wzr
004EA1538  mov      w3, w21
004EA153C  mov      w4, w21
004EA1540  mov      x2, x0
004EA1544  mov      x5, xzr
004EA1548  bl       #0x7c00484 ; System.Array$$Copy
004EA154C  ldr      w8, [x19, #0x18]
004EA1550  ldr      x0, [x19, #0x10]
004EA1554  add      w1, w22, w21
004EA1558  lsl      w3, w21, #1
004EA155C  sub      w4, w8, w21
004EA1560  mov      x2, x0
004EA1564  mov      x5, xzr
004EA1568  bl       #0x7c00484 ; System.Array$$Copy
004EA156C  b        #0x4ea1594 ; 
004EA1570  ldr      w9, [x10]
004EA1574  add      w9, w9, #5
004EA1578  add      x8, x8, w9, sxtw #4
004EA157C  add      x0, x8, #0x138
004EA1580  ldp      x8, x3, [x0]
004EA1584  mov      x0, x23
004EA1588  mov      x1, x20
004EA158C  mov      w2, w21
004EA1590  blr      x8
004EA1594  ldr      w8, [x19, #0x18]
004EA1598  add      w8, w8, w22
004EA159C  str      w8, [x19, #0x18]
004EA15A0  b        #0x4ea177c ; 
004EA15A4  ldrsw    x9, [x10]
004EA15A8  add      x8, x8, x9, lsl #4
004EA15AC  add      x0, x8, #0x138
004EA15B0  ldp      x8, x1, [x0]
004EA15B4  mov      x0, x22
004EA15B8  blr      x8
004EA15BC  mov      x23, x0
004EA15C0  cbz      x0, #0x4ea17a4
004EA15C4  adrp     x24, #0x8ebf000
004EA15C8  ldr      x24, [x24, #0x4f0]
004EA15CC  ldr      x8, [x23]
004EA15D0  ldr      x1, [x24]
004EA15D4  ldrh     w9, [x8, #0x12e]
004EA15D8  cbz      x9, #0x4ea15fc
004EA15DC  ldr      x10, [x8, #0xb0]
004EA15E0  add      x10, x10, #8
004EA15E4  ldur     x11, [x10, #-8]
004EA15E8  cmp      x11, x1
004EA15EC  b.eq     #0x4ea160c
004EA15F0  subs     x9, x9, #1
004EA15F4  add      x10, x10, #0x10
004EA15F8  b.ne     #0x4ea15e4
004EA15FC  mov      x0, x23
004EA1600  mov      w2, wzr
004EA1604  bl       #0x3a7e710 ; 
004EA1608  b        #0x4ea1618 ; 
004EA160C  ldrsw    x9, [x10]
004EA1610  add      x8, x8, x9, lsl #4
004EA1614  add      x0, x8, #0x138
004EA1618  ldp      x8, x1, [x0]
004EA161C  mov      x0, x23
004EA1620  blr      x8
004EA1624  tbz      w0, #0, #0x4ea16e8
004EA1628  ldr      x8, [x20, #0x20]
004EA162C  ldr      x8, [x8, #0xc0]
004EA1630  ldr      x1, [x8, #0x148]
004EA1634  ldrb     w8, [x1, #0x135]
004EA1638  tbnz     w8, #0, #0x4ea1648
004EA163C  mov      x0, x1
004EA1640  bl       #0x3a7e60c ; 
004EA1644  mov      x1, x0
004EA1648  ldr      x8, [x23]
004EA164C  ldrh     w9, [x8, #0x12e]
004EA1650  cbz      x9, #0x4ea1674
004EA1654  ldr      x10, [x8, #0xb0]
004EA1658  add      x10, x10, #8
004EA165C  ldur     x11, [x10, #-8]
004EA1660  cmp      x11, x1
004EA1664  b.eq     #0x4ea1684
004EA1668  subs     x9, x9, #1
004EA166C  add      x10, x10, #0x10
004EA1670  b.ne     #0x4ea165c
004EA1674  mov      x0, x23
004EA1678  mov      w2, wzr
004EA167C  bl       #0x3a7e710 ; 
004EA1680  b        #0x4ea1690 ; 
004EA1684  ldrsw    x9, [x10]
004EA1688  add      x8, x8, x9, lsl #4
004EA168C  add      x0, x8, #0x138
004EA1690  ldp      x9, x1, [x0]
004EA1694  add      x8, sp, #0x40
004EA1698  mov      x0, x23
004EA169C  blr      x9
004EA16A0  ldp      q0, q1, [sp, #0x40]
004EA16A4  ldr      q2, [sp, #0x60]
004EA16A8  ldr      x8, [sp, #0x70]
004EA16AC  stp      q0, q1, [sp]
004EA16B0  str      q2, [sp, #0x20]
004EA16B4  str      x8, [sp, #0x30]
004EA16B8  ldr      x9, [x20, #0x20]
004EA16BC  ldr      x9, [x9, #0xc0]
004EA16C0  ldr      x3, [x9, #0x160]
004EA16C4  stp      q0, q1, [sp, #0x40]
004EA16C8  str      q2, [sp, #0x60]
004EA16CC  str      x8, [sp, #0x70]
004EA16D0  add      x2, sp, #0x40
004EA16D4  mov      x0, x19
004EA16D8  mov      w1, w21
004EA16DC  bl       #0x4ea1034 ; System.Collections.Generic.List<WeightRandomData>$$Insert
004EA16E0  add      w21, w21, #1
004EA16E4  b        #0x4ea15cc ; 
004EA16E8  mov      x21, xzr
004EA16EC  mov      w24, #5
004EA16F0  cbz      x23, #0x4ea1754
004EA16F4  adrp     x10, #0x8ebf000
004EA16F8  ldr      x8, [x23]
004EA16FC  ldr      x10, [x10, #0x4e8]
004EA1700  ldrh     w9, [x8, #0x12e]
004EA1704  ldr      x1, [x10]
004EA1708  cbz      x9, #0x4ea172c
004EA170C  ldr      x10, [x8, #0xb0]
004EA1710  add      x10, x10, #8
004EA1714  ldur     x11, [x10, #-8]
004EA1718  cmp      x11, x1
004EA171C  b.eq     #0x4ea173c
004EA1720  subs     x9, x9, #1
004EA1724  add      x10, x10, #0x10
004EA1728  b.ne     #0x4ea1714
004EA172C  mov      x0, x23
004EA1730  mov      w2, wzr
004EA1734  bl       #0x3a7e710 ; 
004EA1738  b        #0x4ea1748 ; 
004EA173C  ldrsw    x9, [x10]
004EA1740  add      x8, x8, x9, lsl #4
004EA1744  add      x0, x8, #0x138
004EA1748  ldp      x8, x1, [x0]
004EA174C  mov      x0, x23
004EA1750  blr      x8
004EA1754  cbnz     x21, #0x4ea17a8
004EA1758  cmp      w24, #5
004EA175C  b.eq     #0x4ea177c
004EA1760  cbnz     w24, #0x4ea1788
004EA1764  ldr      x8, [x20, #0x20]
004EA1768  mov      x0, x19
004EA176C  mov      x1, x22
004EA1770  ldr      x8, [x8, #0xc0]
004EA1774  ldr      x2, [x8, #0x40]
004EA1778  bl       #0x4ea23d4 ; System.Collections.Generic.List<WeightRandomData>$$AddEnumerable
004EA177C  ldr      w8, [x19, #0x1c]
004EA1780  add      w8, w8, #1
004EA1784  str      w8, [x19, #0x1c]
004EA1788  ldp      x20, x19, [sp, #0xb0]
004EA178C  ldp      x22, x21, [sp, #0xa0]
004EA1790  ldp      x24, x23, [sp, #0x90]
004EA1794  ldr      x30, [sp, #0x80]
004EA1798  add      sp, sp, #0xc0
004EA179C  ret      
004EA17A0  bl       #0x382bfb8 ; 
004EA17A4  bl       #0x382bfb8 ; 
004EA17A8  mov      x0, x21
004EA17AC  bl       #0x382bfb0 ; 
004EA17B0  b        #0x4ea17bc ; 
004EA17B4  b        #0x4ea17bc ; 
004EA17B8  b        #0x4ea17bc ; 
004EA17BC  mov      x24, x0
004EA17C0  cmp      w1, #1
004EA17C4  b.ne     #0x4ea17e4
004EA17C8  mov      x0, x24
004EA17CC  bl       #0x89eda50 ; 
004EA17D0  ldr      x21, [x0]
004EA17D4  bl       #0x89eda60 ; 
004EA17D8  mov      w24, wzr
004EA17DC  cbnz     x23, #0x4ea16f4
004EA17E0  b        #0x4ea1754 ; 
004EA17E4  mov      x21, xzr
004EA17E8  b        #0x4ea17f0 ; 
004EA17EC  mov      x24, x0
004EA17F0  cbz      x23, #0x4ea1854
004EA17F4  adrp     x10, #0x8ebf000
004EA17F8  ldr      x8, [x23]
004EA17FC  ldr      x10, [x10, #0x4e8]
004EA1800  ldrh     w9, [x8, #0x12e]
004EA1804  ldr      x1, [x10]
004EA1808  cbz      x9, #0x4ea182c
004EA180C  ldr      x10, [x8, #0xb0]
004EA1810  add      x10, x10, #8
004EA1814  ldur     x11, [x10, #-8]
004EA1818  cmp      x11, x1
004EA181C  b.eq     #0x4ea183c
004EA1820  subs     x9, x9, #1
004EA1824  add      x10, x10, #0x10
004EA1828  b.ne     #0x4ea1814
004EA182C  mov      x0, x23
004EA1830  mov      w2, wzr
004EA1834  bl       #0x3a7e710 ; 
004EA1838  b        #0x4ea1848 ; 
004EA183C  ldrsw    x9, [x10]
004EA1840  add      x8, x8, x9, lsl #4
004EA1844  add      x0, x8, #0x138
004EA1848  ldp      x8, x1, [x0]
004EA184C  mov      x0, x23
004EA1850  blr      x8
004EA1854  cbnz     x21, #0x4ea1860
004EA1858  mov      x0, x24
004EA185C  bl       #0x3b56bfc ; 
004EA1860  mov      x0, x21
004EA1864  bl       #0x382bfb0 ; 
004EA1868  bl       #0x3442448 ; 

; System.Collections.Generic.List<WeightRandomData>$$LastIndexOf
; RVA 0x4EA186C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA186C  sub      sp, sp, #0x90
004EA1870  str      x30, [sp, #0x80]
004EA1874  ldr      w3, [x0, #0x18]
004EA1878  cbz      w3, #0x4ea18bc
004EA187C  ldr      x8, [x1, #0x30]
004EA1880  ldp      q1, q0, [x1, #0x10]
004EA1884  ldr      q2, [x1]
004EA1888  add      x1, sp, #0x40
004EA188C  str      x8, [sp, #0x30]
004EA1890  stp      q1, q0, [sp, #0x10]
004EA1894  str      q2, [sp]
004EA1898  ldr      x9, [x2, #0x20]
004EA189C  sub      w2, w3, #1
004EA18A0  ldr      x9, [x9, #0xc0]
004EA18A4  ldr      x4, [x9, #0x178]
004EA18A8  stp      q2, q1, [sp, #0x40]
004EA18AC  str      q0, [sp, #0x60]
004EA18B0  str      x8, [sp, #0x70]
004EA18B4  bl       #0x4ea1958 ; System.Collections.Generic.List<WeightRandomData>$$LastIndexOf
004EA18B8  b        #0x4ea18c0 ; 
004EA18BC  mov      w0, #-1
004EA18C0  ldr      x30, [sp, #0x80]
004EA18C4  add      sp, sp, #0x90
004EA18C8  ret      

; System.Collections.Generic.List<WeightRandomData>$$LastIndexOf
; RVA 0x4EA18CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA18CC  sub      sp, sp, #0xb0
004EA18D0  str      x30, [sp, #0x80]
004EA18D4  stp      x22, x21, [sp, #0x90]
004EA18D8  stp      x20, x19, [sp, #0xa0]
004EA18DC  ldr      w8, [x0, #0x18]
004EA18E0  mov      x21, x3
004EA18E4  mov      x19, x0
004EA18E8  mov      w20, w2
004EA18EC  cmp      w8, w2
004EA18F0  mov      x22, x1
004EA18F4  b.gt     #0x4ea1900
004EA18F8  mov      x0, xzr
004EA18FC  bl       #0x7bfe7ac ; System.ThrowHelper$$ThrowArgumentOutOfRange_IndexException
004EA1900  ldr      x8, [x22, #0x30]
004EA1904  ldp      q1, q0, [x22, #0x10]
004EA1908  ldr      q2, [x22]
004EA190C  add      w3, w20, #1
004EA1910  str      x8, [sp, #0x30]
004EA1914  stp      q1, q0, [sp, #0x10]
004EA1918  str      q2, [sp]
004EA191C  ldr      x9, [x21, #0x20]
004EA1920  add      x1, sp, #0x40
004EA1924  mov      x0, x19
004EA1928  mov      w2, w20
004EA192C  ldr      x9, [x9, #0xc0]
004EA1930  ldr      x4, [x9, #0x178]
004EA1934  stp      q2, q1, [sp, #0x40]
004EA1938  str      q0, [sp, #0x60]
004EA193C  str      x8, [sp, #0x70]
004EA1940  bl       #0x4ea1958 ; System.Collections.Generic.List<WeightRandomData>$$LastIndexOf
004EA1944  ldp      x20, x19, [sp, #0xa0]
004EA1948  ldp      x22, x21, [sp, #0x90]
004EA194C  ldr      x30, [sp, #0x80]
004EA1950  add      sp, sp, #0xb0
004EA1954  ret      

; System.Collections.Generic.List<WeightRandomData>$$LastIndexOf
; RVA 0x4EA1958; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1958  sub      sp, sp, #0xb0
004EA195C  stp      x30, x23, [sp, #0x80]
004EA1960  stp      x22, x21, [sp, #0x90]
004EA1964  stp      x20, x19, [sp, #0xa0]
004EA1968  ldr      w8, [x0, #0x18]
004EA196C  mov      x21, x4
004EA1970  mov      w19, w3
004EA1974  mov      w20, w2
004EA1978  mov      x22, x0
004EA197C  mov      x23, x1
004EA1980  tbz      w2, #0x1f, #0x4ea1994
004EA1984  cbz      w8, #0x4ea1994
004EA1988  mov      x0, xzr
004EA198C  bl       #0x7bfe7e4 ; System.ThrowHelper$$ThrowIndexArgumentOutOfRange_NeedNonNegNumException
004EA1990  ldr      w8, [x22, #0x18]
004EA1994  tbz      w19, #0x1f, #0x4ea19b0
004EA1998  cbz      w8, #0x4ea19b0
004EA199C  mov      w0, #0x10
004EA19A0  mov      w1, #4
004EA19A4  mov      x2, xzr
004EA19A8  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA19AC  ldr      w8, [x22, #0x18]
004EA19B0  cbz      w8, #0x4ea1a30
004EA19B4  cmp      w8, w20
004EA19B8  b.gt     #0x4ea19cc
004EA19BC  mov      w0, #0xd
004EA19C0  mov      w1, #0x22
004EA19C4  mov      x2, xzr
004EA19C8  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA19CC  add      w8, w20, #1
004EA19D0  cmp      w8, w19
004EA19D4  b.ge     #0x4ea19e8
004EA19D8  mov      w0, #0x10
004EA19DC  mov      w1, #0x22
004EA19E0  mov      x2, xzr
004EA19E4  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA19E8  ldp      q2, q0, [x23, #0x10]
004EA19EC  ldr      x8, [x23, #0x30]
004EA19F0  ldr      q1, [x23]
004EA19F4  ldr      x0, [x22, #0x10]
004EA19F8  stp      q2, q0, [sp, #0x10]
004EA19FC  str      x8, [sp, #0x30]
004EA1A00  str      q1, [sp]
004EA1A04  ldr      x9, [x21, #0x20]
004EA1A08  add      x1, sp, #0x40
004EA1A0C  mov      w2, w20
004EA1A10  mov      w3, w19
004EA1A14  ldr      x9, [x9, #0xc0]
004EA1A18  ldr      x4, [x9, #0x180]
004EA1A1C  stp      q1, q2, [sp, #0x40]
004EA1A20  str      q0, [sp, #0x60]
004EA1A24  str      x8, [sp, #0x70]
004EA1A28  bl       #0x445d080 ; System.Array$$LastIndexOf<WeightRandomData>
004EA1A2C  b        #0x4ea1a34 ; 
004EA1A30  mov      w0, #-1
004EA1A34  ldp      x20, x19, [sp, #0xa0]
004EA1A38  ldp      x22, x21, [sp, #0x90]
004EA1A3C  ldp      x30, x23, [sp, #0x80]
004EA1A40  add      sp, sp, #0xb0
004EA1A44  ret      

; System.Collections.Generic.List<WeightRandomData>$$Remove
; RVA 0x4EA1A48; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1A48  sub      sp, sp, #0xa0
004EA1A4C  str      x30, [sp, #0x80]
004EA1A50  stp      x20, x19, [sp, #0x90]
004EA1A54  ldr      x8, [x1, #0x30]
004EA1A58  ldp      q1, q0, [x1, #0x10]
004EA1A5C  ldr      q2, [x1]
004EA1A60  mov      x19, x0
004EA1A64  str      x8, [sp, #0x30]
004EA1A68  stp      q1, q0, [sp, #0x10]
004EA1A6C  str      q2, [sp]
004EA1A70  ldr      x8, [x2, #0x20]
004EA1A74  ldr      x0, [x0, #0x10]
004EA1A78  ldr      w3, [x19, #0x18]
004EA1A7C  ldp      q0, q1, [sp]
004EA1A80  ldr      x8, [x8, #0xc0]
004EA1A84  ldr      q2, [sp, #0x20]
004EA1A88  ldr      x9, [sp, #0x30]
004EA1A8C  add      x1, sp, #0x40
004EA1A90  ldr      x8, [x8, #0xd0]
004EA1A94  mov      w2, wzr
004EA1A98  ldr      x8, [x8, #0x20]
004EA1A9C  ldr      x8, [x8, #0xc0]
004EA1AA0  ldr      x4, [x8, #0x158]
004EA1AA4  stp      q0, q1, [sp, #0x40]
004EA1AA8  str      q2, [sp, #0x60]
004EA1AAC  str      x9, [sp, #0x70]
004EA1AB0  bl       #0x47c6f60 ; System.Array$$IndexOf<WeightRandomData>
004EA1AB4  mov      w20, w0
004EA1AB8  tbnz     w0, #0x1f, #0x4ea1ac8
004EA1ABC  mov      x0, x19
004EA1AC0  mov      w1, w20
004EA1AC4  bl       #0x4ea1e14 ; System.Collections.Generic.List<WeightRandomData>$$RemoveAt
004EA1AC8  mvn      w8, w20
004EA1ACC  ldp      x20, x19, [sp, #0x90]
004EA1AD0  ldr      x30, [sp, #0x80]
004EA1AD4  lsr      w0, w8, #0x1f
004EA1AD8  add      sp, sp, #0xa0
004EA1ADC  ret      

; System.Collections.Generic.List<WeightRandomData>$$System.Collections.IList.Remove
; RVA 0x4EA1AE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1AE0  sub      sp, sp, #0xa0
004EA1AE4  stp      x30, x21, [sp, #0x80]
004EA1AE8  stp      x20, x19, [sp, #0x90]
004EA1AEC  ldr      x8, [x2, #0x20]
004EA1AF0  mov      x20, x2
004EA1AF4  mov      x21, x1
004EA1AF8  mov      x19, x0
004EA1AFC  ldr      x8, [x8, #0xc0]
004EA1B00  ldr      x8, [x8, #0x10]
004EA1B04  ldrb     w9, [x8, #0x135]
004EA1B08  tbnz     w9, #0, #0x4ea1b18
004EA1B0C  mov      x0, x8
004EA1B10  bl       #0x3a7e60c ; 
004EA1B14  mov      x8, x0
004EA1B18  ldr      w9, [x8, #0xe0]
004EA1B1C  cbnz     w9, #0x4ea1b28
004EA1B20  mov      x0, x8
004EA1B24  bl       #0x382be8c ; 
004EA1B28  ldr      x8, [x20, #0x20]
004EA1B2C  mov      x0, x21
004EA1B30  ldr      x8, [x8, #0xc0]
004EA1B34  ldr      x1, [x8, #0xd8]
004EA1B38  bl       #0x4e9f8a8 ; System.Collections.Generic.List<WeightRandomData>$$IsCompatibleObject
004EA1B3C  tbz      w0, #0, #0x4ea1bc8
004EA1B40  ldr      x8, [x20, #0x20]
004EA1B44  ldr      x8, [x8, #0xc0]
004EA1B48  ldr      x1, [x8, #0x48]
004EA1B4C  ldrb     w8, [x1, #0x135]
004EA1B50  tbnz     w8, #0, #0x4ea1b60
004EA1B54  mov      x0, x1
004EA1B58  bl       #0x3a7e60c ; 
004EA1B5C  mov      x1, x0
004EA1B60  cbz      x21, #0x4ea1bd8
004EA1B64  ldr      x8, [x21]
004EA1B68  ldr      x9, [x1, #0x40]
004EA1B6C  mov      x0, x21
004EA1B70  ldr      x8, [x8, #0x40]
004EA1B74  cmp      x8, x9
004EA1B78  b.ne     #0x4ea1bdc
004EA1B7C  bl       #0x382be98 ; 
004EA1B80  ldr      x8, [x0, #0x30]
004EA1B84  ldp      q1, q0, [x0, #0x10]
004EA1B88  ldr      q2, [x0]
004EA1B8C  add      x1, sp, #0x40
004EA1B90  str      x8, [sp, #0x30]
004EA1B94  stp      q1, q0, [sp, #0x10]
004EA1B98  str      q2, [sp]
004EA1B9C  ldr      x8, [x20, #0x20]
004EA1BA0  ldp      q0, q1, [sp]
004EA1BA4  ldr      q2, [sp, #0x20]
004EA1BA8  ldr      x9, [sp, #0x30]
004EA1BAC  ldr      x8, [x8, #0xc0]
004EA1BB0  mov      x0, x19
004EA1BB4  ldr      x2, [x8, #0x190]
004EA1BB8  stp      q0, q1, [sp, #0x40]
004EA1BBC  str      q2, [sp, #0x60]
004EA1BC0  str      x9, [sp, #0x70]
004EA1BC4  bl       #0x4ea1a48 ; System.Collections.Generic.List<WeightRandomData>$$Remove
004EA1BC8  ldp      x20, x19, [sp, #0x90]
004EA1BCC  ldp      x30, x21, [sp, #0x80]
004EA1BD0  add      sp, sp, #0xa0
004EA1BD4  ret      
004EA1BD8  bl       #0x382bfb8 ; 
004EA1BDC  bl       #0x382c354 ; 

; System.Collections.Generic.List<WeightRandomData>$$RemoveAll
; RVA 0x4EA1BE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1BE0  sub      sp, sp, #0x100
004EA1BE4  str      x30, [sp, #0xc0]
004EA1BE8  stp      x24, x23, [sp, #0xd0]
004EA1BEC  stp      x22, x21, [sp, #0xe0]
004EA1BF0  stp      x20, x19, [sp, #0xf0]
004EA1BF4  mov      x20, x1
004EA1BF8  mov      x19, x0
004EA1BFC  cbnz     x1, #0x4ea1c08
004EA1C00  mov      w0, #8
004EA1C04  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA1C08  ldr      w8, [x19, #0x18]
004EA1C0C  cmp      w8, #1
004EA1C10  b.lt     #0x4ea1c98
004EA1C14  mov      x22, xzr
004EA1C18  mov      w21, #0x20
004EA1C1C  ldr      x8, [x19, #0x10]
004EA1C20  cbz      x8, #0x4ea1e0c
004EA1C24  ldr      w9, [x8, #0x18]
004EA1C28  cmp      x22, x9
004EA1C2C  b.hs     #0x4ea1e10
004EA1C30  add      x8, x8, x21
004EA1C34  ldr      x9, [x8, #0x30]
004EA1C38  ldp      q1, q0, [x8, #0x10]
004EA1C3C  ldr      q2, [x8]
004EA1C40  str      x9, [sp, #0x70]
004EA1C44  stp      q1, q0, [sp, #0x50]
004EA1C48  str      q2, [sp, #0x40]
004EA1C4C  cbz      x20, #0x4ea1e0c
004EA1C50  ldp      q0, q1, [sp, #0x40]
004EA1C54  ldr      q2, [sp, #0x60]
004EA1C58  ldr      x9, [sp, #0x70]
004EA1C5C  ldr      x8, [x20, #0x18]
004EA1C60  ldr      x0, [x20, #0x40]
004EA1C64  stp      q0, q1, [sp, #0x80]
004EA1C68  str      q2, [sp, #0xa0]
004EA1C6C  str      x9, [sp, #0xb0]
004EA1C70  ldr      x2, [x20, #0x28]
004EA1C74  add      x1, sp, #0x80
004EA1C78  blr      x8
004EA1C7C  tbnz     w0, #0, #0x4ea1ca0
004EA1C80  ldrsw    x8, [x19, #0x18]
004EA1C84  add      x22, x22, #1
004EA1C88  add      x21, x21, #0x38
004EA1C8C  cmp      x22, x8
004EA1C90  b.lt     #0x4ea1c1c
004EA1C94  b        #0x4ea1ca4 ; 
004EA1C98  mov      w22, wzr
004EA1C9C  b        #0x4ea1ca4 ; 
004EA1CA0  ldr      w8, [x19, #0x18]
004EA1CA4  cmp      w22, w8
004EA1CA8  b.ge     #0x4ea1dc8
004EA1CAC  mov      w23, #0x38
004EA1CB0  mov      w21, w22
004EA1CB4  add      w22, w22, #1
004EA1CB8  cmp      w22, w8
004EA1CBC  b.ge     #0x4ea1dd0
004EA1CC0  smull    x8, w22, w23
004EA1CC4  add      x24, x8, #0x20
004EA1CC8  sxtw     x22, w22
004EA1CCC  ldr      x8, [x19, #0x10]
004EA1CD0  cbz      x8, #0x4ea1e0c
004EA1CD4  ldr      w9, [x8, #0x18]
004EA1CD8  cmp      w22, w9
004EA1CDC  b.hs     #0x4ea1e10
004EA1CE0  add      x8, x8, x24
004EA1CE4  ldr      x9, [x8, #0x30]
004EA1CE8  ldp      q1, q0, [x8, #0x10]
004EA1CEC  ldr      q2, [x8]
004EA1CF0  str      x9, [sp, #0x70]
004EA1CF4  stp      q1, q0, [sp, #0x50]
004EA1CF8  str      q2, [sp, #0x40]
004EA1CFC  cbz      x20, #0x4ea1e0c
004EA1D00  ldp      q0, q1, [sp, #0x40]
004EA1D04  ldr      q2, [sp, #0x60]
004EA1D08  ldr      x9, [sp, #0x70]
004EA1D0C  ldr      x8, [x20, #0x18]
004EA1D10  ldr      x0, [x20, #0x40]
004EA1D14  stp      q0, q1, [sp, #0x80]
004EA1D18  str      q2, [sp, #0xa0]
004EA1D1C  str      x9, [sp, #0xb0]
004EA1D20  ldr      x2, [x20, #0x28]
004EA1D24  add      x1, sp, #0x80
004EA1D28  blr      x8
004EA1D2C  tbz      w0, #0, #0x4ea1d48
004EA1D30  ldrsw    x8, [x19, #0x18]
004EA1D34  add      x22, x22, #1
004EA1D38  add      x24, x24, #0x38
004EA1D3C  cmp      x22, x8
004EA1D40  b.lt     #0x4ea1ccc
004EA1D44  b        #0x4ea1d4c ; 
004EA1D48  ldr      w8, [x19, #0x18]
004EA1D4C  cmp      w22, w8
004EA1D50  b.ge     #0x4ea1cb8
004EA1D54  ldr      x8, [x19, #0x10]
004EA1D58  cbz      x8, #0x4ea1e0c
004EA1D5C  ldr      w9, [x8, #0x18]
004EA1D60  cmp      w22, w9
004EA1D64  b.hs     #0x4ea1e10
004EA1D68  smaddl   x10, w22, w23, x8
004EA1D6C  ldp      q2, q0, [x10, #0x30]
004EA1D70  ldr      x11, [x10, #0x50]
004EA1D74  ldr      q1, [x10, #0x20]
004EA1D78  cmp      w21, w9
004EA1D7C  stp      q2, q0, [sp, #0x10]
004EA1D80  str      x11, [sp, #0x30]
004EA1D84  str      q1, [sp]
004EA1D88  b.hs     #0x4ea1e10
004EA1D8C  ldp      q2, q0, [sp, #0x10]
004EA1D90  ldr      x10, [sp, #0x30]
004EA1D94  ldr      q1, [sp]
004EA1D98  sxtw     x9, w21
004EA1D9C  madd     x8, x9, x23, x8
004EA1DA0  add      x0, x8, #0x30
004EA1DA4  mov      x1, xzr
004EA1DA8  add      w24, w21, #1
004EA1DAC  str      x10, [x8, #0x50]
004EA1DB0  stp      q2, q0, [x8, #0x30]
004EA1DB4  str      q1, [x8, #0x20]
004EA1DB8  bl       #0x382bcb8 ; 
004EA1DBC  ldr      w8, [x19, #0x18]
004EA1DC0  mov      w21, w24
004EA1DC4  b        #0x4ea1cb4 ; 
004EA1DC8  mov      w0, wzr
004EA1DCC  b        #0x4ea1df4 ; 
004EA1DD0  ldr      x0, [x19, #0x10]
004EA1DD4  sub      w2, w8, w21
004EA1DD8  mov      w1, w21
004EA1DDC  mov      x3, xzr
004EA1DE0  bl       #0x7c001d0 ; System.Array$$Clear
004EA1DE4  ldp      w9, w8, [x19, #0x18]
004EA1DE8  add      w8, w8, #1
004EA1DEC  sub      w0, w9, w21
004EA1DF0  stp      w21, w8, [x19, #0x18]
004EA1DF4  ldp      x20, x19, [sp, #0xf0]
004EA1DF8  ldp      x22, x21, [sp, #0xe0]
004EA1DFC  ldp      x24, x23, [sp, #0xd0]
004EA1E00  ldr      x30, [sp, #0xc0]
004EA1E04  add      sp, sp, #0x100
004EA1E08  ret      
004EA1E0C  bl       #0x382bfb8 ; 
004EA1E10  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$RemoveAt
; RVA 0x4EA1E14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1E14  sub      sp, sp, #0xa0
004EA1E18  str      x30, [sp, #0x80]
004EA1E1C  stp      x20, x19, [sp, #0x90]
004EA1E20  ldr      w8, [x0, #0x18]
004EA1E24  mov      x19, x0
004EA1E28  mov      w20, w1
004EA1E2C  cmp      w8, w1
004EA1E30  b.hi     #0x4ea1e40
004EA1E34  mov      x0, xzr
004EA1E38  bl       #0x7bfe7ac ; System.ThrowHelper$$ThrowArgumentOutOfRange_IndexException
004EA1E3C  ldr      w8, [x19, #0x18]
004EA1E40  sub      w8, w8, #1
004EA1E44  subs     w4, w8, w20
004EA1E48  str      w8, [x19, #0x18]
004EA1E4C  b.le     #0x4ea1e6c
004EA1E50  ldr      x0, [x19, #0x10]
004EA1E54  add      w1, w20, #1
004EA1E58  mov      w3, w20
004EA1E5C  mov      x5, xzr
004EA1E60  mov      x2, x0
004EA1E64  bl       #0x7c00484 ; System.Array$$Copy
004EA1E68  ldr      w8, [x19, #0x18]
004EA1E6C  ldr      x9, [x19, #0x10]
004EA1E70  movi     v0.2d, #0000000000000000
004EA1E74  str      xzr, [sp, #0x70]
004EA1E78  stp      q0, q0, [sp, #0x50]
004EA1E7C  str      q0, [sp, #0x40]
004EA1E80  cbz      x9, #0x4ea1ef4
004EA1E84  ldp      q0, q1, [sp, #0x40]
004EA1E88  ldr      q2, [sp, #0x60]
004EA1E8C  ldr      x10, [sp, #0x70]
004EA1E90  stp      q0, q1, [sp]
004EA1E94  str      q2, [sp, #0x20]
004EA1E98  str      x10, [sp, #0x30]
004EA1E9C  ldr      w10, [x9, #0x18]
004EA1EA0  cmp      w8, w10
004EA1EA4  b.hs     #0x4ea1ef8
004EA1EA8  ldp      q2, q0, [sp, #0x10]
004EA1EAC  ldr      x11, [sp, #0x30]
004EA1EB0  ldr      q1, [sp]
004EA1EB4  sxtw     x8, w8
004EA1EB8  mov      w10, #0x38
004EA1EBC  madd     x8, x8, x10, x9
004EA1EC0  add      x0, x8, #0x30
004EA1EC4  mov      x1, xzr
004EA1EC8  str      x11, [x8, #0x50]
004EA1ECC  stp      q2, q0, [x8, #0x30]
004EA1ED0  str      q1, [x8, #0x20]
004EA1ED4  bl       #0x382bcb8 ; 
004EA1ED8  ldr      w8, [x19, #0x1c]
004EA1EDC  ldr      x30, [sp, #0x80]
004EA1EE0  add      w8, w8, #1
004EA1EE4  str      w8, [x19, #0x1c]
004EA1EE8  ldp      x20, x19, [sp, #0x90]
004EA1EEC  add      sp, sp, #0xa0
004EA1EF0  ret      
004EA1EF4  bl       #0x382bfb8 ; 
004EA1EF8  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$RemoveRange
; RVA 0x4EA1EFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1EFC  stp      x30, x21, [sp, #-0x20]!
004EA1F00  stp      x20, x19, [sp, #0x10]
004EA1F04  mov      w19, w2
004EA1F08  mov      w21, w1
004EA1F0C  mov      x20, x0
004EA1F10  tbnz     w1, #0x1f, #0x4ea1f90
004EA1F14  tbnz     w19, #0x1f, #0x4ea1f9c
004EA1F18  ldr      w8, [x20, #0x18]
004EA1F1C  sub      w8, w8, w21
004EA1F20  cmp      w8, w19
004EA1F24  b.ge     #0x4ea1f34
004EA1F28  mov      w0, #0x17
004EA1F2C  mov      x1, xzr
004EA1F30  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
004EA1F34  cmp      w19, #1
004EA1F38  b.lt     #0x4ea1fb0
004EA1F3C  ldr      w8, [x20, #0x18]
004EA1F40  sub      w1, w8, w19
004EA1F44  subs     w4, w1, w21
004EA1F48  str      w1, [x20, #0x18]
004EA1F4C  b.le     #0x4ea1f6c
004EA1F50  ldr      x0, [x20, #0x10]
004EA1F54  add      w1, w19, w21
004EA1F58  mov      w3, w21
004EA1F5C  mov      x5, xzr
004EA1F60  mov      x2, x0
004EA1F64  bl       #0x7c00484 ; System.Array$$Copy
004EA1F68  ldr      w1, [x20, #0x18]
004EA1F6C  ldr      w8, [x20, #0x1c]
004EA1F70  ldr      x0, [x20, #0x10]
004EA1F74  mov      w2, w19
004EA1F78  mov      x3, xzr
004EA1F7C  add      w8, w8, #1
004EA1F80  str      w8, [x20, #0x1c]
004EA1F84  ldp      x20, x19, [sp, #0x10]
004EA1F88  ldp      x30, x21, [sp], #0x20
004EA1F8C  b        #0x7c001d0 ; System.Array$$Clear
004EA1F90  mov      x0, xzr
004EA1F94  bl       #0x7bfe7e4 ; System.ThrowHelper$$ThrowIndexArgumentOutOfRange_NeedNonNegNumException
004EA1F98  tbz      w19, #0x1f, #0x4ea1f18
004EA1F9C  mov      w0, #0x10
004EA1FA0  mov      w1, #4
004EA1FA4  mov      x2, xzr
004EA1FA8  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA1FAC  b        #0x4ea1f18 ; 
004EA1FB0  ldp      x20, x19, [sp, #0x10]
004EA1FB4  ldp      x30, x21, [sp], #0x20
004EA1FB8  ret      

; System.Collections.Generic.List<WeightRandomData>$$Reverse
; RVA 0x4EA1FBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1FBC  ldr      x8, [x1, #0x20]
004EA1FC0  ldr      w2, [x0, #0x18]
004EA1FC4  mov      w1, wzr
004EA1FC8  ldr      x8, [x8, #0xc0]
004EA1FCC  ldr      x3, [x8, #0x198]
004EA1FD0  b        #0x4ea1fd4 ; System.Collections.Generic.List<WeightRandomData>$$Reverse

; System.Collections.Generic.List<WeightRandomData>$$Reverse
; RVA 0x4EA1FD4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA1FD4  str      x30, [sp, #-0x30]!
004EA1FD8  stp      x22, x21, [sp, #0x10]
004EA1FDC  stp      x20, x19, [sp, #0x20]
004EA1FE0  mov      x22, x3
004EA1FE4  mov      w20, w2
004EA1FE8  mov      w21, w1
004EA1FEC  mov      x19, x0
004EA1FF0  tbnz     w1, #0x1f, #0x4ea2054
004EA1FF4  tbnz     w20, #0x1f, #0x4ea2060
004EA1FF8  ldr      w8, [x19, #0x18]
004EA1FFC  sub      w8, w8, w21
004EA2000  cmp      w8, w20
004EA2004  b.ge     #0x4ea2014
004EA2008  mov      w0, #0x17
004EA200C  mov      x1, xzr
004EA2010  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
004EA2014  cmp      w20, #2
004EA2018  b.lt     #0x4ea2038
004EA201C  ldr      x8, [x22, #0x20]
004EA2020  ldr      x0, [x19, #0x10]
004EA2024  mov      w1, w21
004EA2028  mov      w2, w20
004EA202C  ldr      x8, [x8, #0xc0]
004EA2030  ldr      x3, [x8, #0x1a0]
004EA2034  bl       #0x44c44f0 ; System.Array$$Reverse<WeightRandomData>
004EA2038  ldr      w8, [x19, #0x1c]
004EA203C  ldp      x22, x21, [sp, #0x10]
004EA2040  add      w8, w8, #1
004EA2044  str      w8, [x19, #0x1c]
004EA2048  ldp      x20, x19, [sp, #0x20]
004EA204C  ldr      x30, [sp], #0x30
004EA2050  ret      
004EA2054  mov      x0, xzr
004EA2058  bl       #0x7bfe7e4 ; System.ThrowHelper$$ThrowIndexArgumentOutOfRange_NeedNonNegNumException
004EA205C  tbz      w20, #0x1f, #0x4ea1ff8
004EA2060  mov      w0, #0x10
004EA2064  mov      w1, #4
004EA2068  mov      x2, xzr
004EA206C  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA2070  b        #0x4ea1ff8 ; 

; System.Collections.Generic.List<WeightRandomData>$$Sort
; RVA 0x4EA2074; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA2074  ldr      x8, [x1, #0x20]
004EA2078  ldr      w2, [x0, #0x18]
004EA207C  mov      w1, wzr
004EA2080  mov      x3, xzr
004EA2084  ldr      x8, [x8, #0xc0]
004EA2088  ldr      x4, [x8, #0x1a8]
004EA208C  b        #0x4ea20ac ; System.Collections.Generic.List<WeightRandomData>$$Sort

; System.Collections.Generic.List<WeightRandomData>$$Sort
; RVA 0x4EA2090; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA2090  ldr      x8, [x2, #0x20]
004EA2094  ldr      w2, [x0, #0x18]
004EA2098  mov      x3, x1
004EA209C  mov      w1, wzr
004EA20A0  ldr      x8, [x8, #0xc0]
004EA20A4  ldr      x4, [x8, #0x1a8]
004EA20A8  b        #0x4ea20ac ; System.Collections.Generic.List<WeightRandomData>$$Sort

; System.Collections.Generic.List<WeightRandomData>$$Sort
; RVA 0x4EA20AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA20AC  stp      x30, x23, [sp, #-0x30]!
004EA20B0  stp      x22, x21, [sp, #0x10]
004EA20B4  stp      x20, x19, [sp, #0x20]
004EA20B8  mov      x23, x4
004EA20BC  mov      x20, x3
004EA20C0  mov      w21, w2
004EA20C4  mov      w22, w1
004EA20C8  mov      x19, x0
004EA20CC  tbnz     w1, #0x1f, #0x4ea2134
004EA20D0  tbnz     w21, #0x1f, #0x4ea2140
004EA20D4  ldr      w8, [x19, #0x18]
004EA20D8  sub      w8, w8, w22
004EA20DC  cmp      w8, w21
004EA20E0  b.ge     #0x4ea20f0
004EA20E4  mov      w0, #0x17
004EA20E8  mov      x1, xzr
004EA20EC  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
004EA20F0  cmp      w21, #2
004EA20F4  b.lt     #0x4ea2118
004EA20F8  ldr      x8, [x23, #0x20]
004EA20FC  ldr      x0, [x19, #0x10]
004EA2100  mov      w1, w22
004EA2104  mov      w2, w21
004EA2108  ldr      x8, [x8, #0xc0]
004EA210C  mov      x3, x20
004EA2110  ldr      x4, [x8, #0x1b0]
004EA2114  bl       #0x44eb30c ; System.Array$$Sort<WeightRandomData>
004EA2118  ldr      w8, [x19, #0x1c]
004EA211C  ldp      x22, x21, [sp, #0x10]
004EA2120  add      w8, w8, #1
004EA2124  str      w8, [x19, #0x1c]
004EA2128  ldp      x20, x19, [sp, #0x20]
004EA212C  ldp      x30, x23, [sp], #0x30
004EA2130  ret      
004EA2134  mov      x0, xzr
004EA2138  bl       #0x7bfe7e4 ; System.ThrowHelper$$ThrowIndexArgumentOutOfRange_NeedNonNegNumException
004EA213C  tbz      w21, #0x1f, #0x4ea20d4
004EA2140  mov      w0, #0x10
004EA2144  mov      w1, #4
004EA2148  mov      x2, xzr
004EA214C  bl       #0x7bfe428 ; System.ThrowHelper$$ThrowArgumentOutOfRangeException
004EA2150  b        #0x4ea20d4 ; 

; System.Collections.Generic.List<WeightRandomData>$$Sort
; RVA 0x4EA2154; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA2154  stp      x30, x23, [sp, #-0x30]!
004EA2158  stp      x22, x21, [sp, #0x10]
004EA215C  stp      x20, x19, [sp, #0x20]
004EA2160  mov      x21, x2
004EA2164  mov      x20, x1
004EA2168  mov      x19, x0
004EA216C  cbnz     x1, #0x4ea2178
004EA2170  mov      w0, #0x22
004EA2174  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA2178  ldr      w22, [x19, #0x18]
004EA217C  cmp      w22, #2
004EA2180  b.lt     #0x4ea21cc
004EA2184  ldr      x8, [x21, #0x20]
004EA2188  ldr      x23, [x19, #0x10]
004EA218C  ldr      x8, [x8, #0xc0]
004EA2190  ldr      x0, [x8, #0x1c8]
004EA2194  ldrb     w8, [x0, #0x135]
004EA2198  tbnz     w8, #0, #0x4ea21a0
004EA219C  bl       #0x3a7e60c ; 
004EA21A0  ldr      w8, [x0, #0xe0]
004EA21A4  cbnz     w8, #0x4ea21ac
004EA21A8  bl       #0x382be8c ; 
004EA21AC  ldr      x8, [x21, #0x20]
004EA21B0  mov      x0, x23
004EA21B4  mov      w1, wzr
004EA21B8  mov      w2, w22
004EA21BC  ldr      x8, [x8, #0xc0]
004EA21C0  mov      x3, x20
004EA21C4  ldr      x4, [x8, #0x1c0]
004EA21C8  bl       #0x5048740 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Sort
004EA21CC  ldr      w8, [x19, #0x1c]
004EA21D0  ldp      x22, x21, [sp, #0x10]
004EA21D4  add      w8, w8, #1
004EA21D8  str      w8, [x19, #0x1c]
004EA21DC  ldp      x20, x19, [sp, #0x20]
004EA21E0  ldp      x30, x23, [sp], #0x30
004EA21E4  ret      

; System.Collections.Generic.List<WeightRandomData>$$ToArray
; RVA 0x4EA21E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA21E8  stp      x30, x21, [sp, #-0x20]!
004EA21EC  stp      x20, x19, [sp, #0x10]
004EA21F0  ldr      x8, [x1, #0x20]
004EA21F4  ldr      w21, [x0, #0x18]
004EA21F8  ldr      x8, [x8, #0xc0]
004EA21FC  cbz      w21, #0x4ea2244
004EA2200  mov      x20, x0
004EA2204  ldr      x0, [x8, #0x18]
004EA2208  ldrb     w8, [x0, #0x135]
004EA220C  tbnz     w8, #0, #0x4ea2214
004EA2210  bl       #0x3a7e60c ; 
004EA2214  mov      w1, w21
004EA2218  bl       #0x382bdfc ; 
004EA221C  ldr      x8, [x20, #0x10]
004EA2220  ldr      w4, [x20, #0x18]
004EA2224  mov      x19, x0
004EA2228  mov      w1, wzr
004EA222C  mov      x0, x8
004EA2230  mov      x2, x19
004EA2234  mov      w3, wzr
004EA2238  mov      x5, xzr
004EA223C  bl       #0x7c00484 ; System.Array$$Copy
004EA2240  b        #0x4ea2284 ; 
004EA2244  ldr      x0, [x8, #0x10]
004EA2248  mov      x19, x1
004EA224C  ldrb     w8, [x0, #0x135]
004EA2250  tbnz     w8, #0, #0x4ea2258
004EA2254  bl       #0x3a7e60c ; 
004EA2258  ldr      w8, [x0, #0xe0]
004EA225C  cbnz     w8, #0x4ea2264
004EA2260  bl       #0x382be8c ; 
004EA2264  ldr      x8, [x19, #0x20]
004EA2268  ldr      x8, [x8, #0xc0]
004EA226C  ldr      x0, [x8, #0x10]
004EA2270  ldrb     w8, [x0, #0x135]
004EA2274  tbnz     w8, #0, #0x4ea227c
004EA2278  bl       #0x3a7e60c ; 
004EA227C  ldr      x8, [x0, #0xb8]
004EA2280  ldr      x19, [x8]
004EA2284  mov      x0, x19
004EA2288  ldp      x20, x19, [sp, #0x10]
004EA228C  ldp      x30, x21, [sp], #0x20
004EA2290  ret      

; System.Collections.Generic.List<WeightRandomData>$$TrimExcess
; RVA 0x4EA2294; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA2294  str      x30, [sp, #-0x10]!
004EA2298  ldr      x8, [x0, #0x10]
004EA229C  cbz      x8, #0x4ea22f8
004EA22A0  ldr      w9, [x8, #0x18]
004EA22A4  adrp     x8, #0x197f000
004EA22A8  ldr      d0, [x8, #0x308]
004EA22AC  mov      x10, #0x7ff0000000000000
004EA22B0  ldr      w8, [x0, #0x18]
004EA22B4  scvtf    d2, w9
004EA22B8  fmov     d1, x10
004EA22BC  fmul     d0, d2, d0
004EA22C0  fcvtzs   w9, d0
004EA22C4  fcmp     d0, d1
004EA22C8  mov      w10, #-0xffffffff80000000
004EA22CC  csel     w9, w10, w9, eq
004EA22D0  cmp      w8, w9
004EA22D4  b.ge     #0x4ea22f0
004EA22D8  ldr      x9, [x1, #0x20]
004EA22DC  mov      w1, w8
004EA22E0  ldr      x9, [x9, #0xc0]
004EA22E4  ldr      x2, [x9, #0xf0]
004EA22E8  ldr      x30, [sp], #0x10
004EA22EC  b        #0x4e9f5c8 ; System.Collections.Generic.List<WeightRandomData>$$set_Capacity
004EA22F0  ldr      x30, [sp], #0x10
004EA22F4  ret      
004EA22F8  bl       #0x382bfb8 ; 

; System.Collections.Generic.List<WeightRandomData>$$TrueForAll
; RVA 0x4EA22FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA22FC  sub      sp, sp, #0xb0
004EA2300  str      x30, [sp, #0x80]
004EA2304  stp      x22, x21, [sp, #0x90]
004EA2308  stp      x20, x19, [sp, #0xa0]
004EA230C  mov      x19, x1
004EA2310  mov      x20, x0
004EA2314  cbnz     x1, #0x4ea2320
004EA2318  mov      w0, #8
004EA231C  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
004EA2320  ldr      w8, [x20, #0x18]
004EA2324  cmp      w8, #1
004EA2328  b.lt     #0x4ea23b0
004EA232C  mov      x21, xzr
004EA2330  mov      w22, #0x20
004EA2334  ldr      x8, [x20, #0x10]
004EA2338  cbz      x8, #0x4ea23cc
004EA233C  ldr      w9, [x8, #0x18]
004EA2340  cmp      x21, x9
004EA2344  b.hs     #0x4ea23d0
004EA2348  add      x8, x8, x22
004EA234C  ldr      x9, [x8, #0x30]
004EA2350  ldp      q1, q0, [x8, #0x10]
004EA2354  ldr      q2, [x8]
004EA2358  str      x9, [sp, #0x30]
004EA235C  stp      q1, q0, [sp, #0x10]
004EA2360  str      q2, [sp]
004EA2364  cbz      x19, #0x4ea23cc
004EA2368  ldp      q0, q1, [sp]
004EA236C  ldr      q2, [sp, #0x20]
004EA2370  ldr      x9, [sp, #0x30]
004EA2374  ldr      x8, [x19, #0x18]
004EA2378  ldr      x0, [x19, #0x40]
004EA237C  stp      q0, q1, [sp, #0x40]
004EA2380  str      q2, [sp, #0x60]
004EA2384  str      x9, [sp, #0x70]
004EA2388  ldr      x2, [x19, #0x28]
004EA238C  add      x1, sp, #0x40
004EA2390  blr      x8
004EA2394  tbz      w0, #0, #0x4ea23b4
004EA2398  ldrsw    x8, [x20, #0x18]
004EA239C  add      x21, x21, #1
004EA23A0  add      x22, x22, #0x38
004EA23A4  cmp      x21, x8
004EA23A8  b.lt     #0x4ea2334
004EA23AC  b        #0x4ea23b4 ; 
004EA23B0  mov      w0, #1
004EA23B4  ldp      x20, x19, [sp, #0xa0]
004EA23B8  ldp      x22, x21, [sp, #0x90]
004EA23BC  ldr      x30, [sp, #0x80]
004EA23C0  and      w0, w0, #1
004EA23C4  add      sp, sp, #0xb0
004EA23C8  ret      
004EA23CC  bl       #0x382bfb8 ; 
004EA23D0  bl       #0x382bfc0 ; 

; System.Collections.Generic.List<WeightRandomData>$$AddEnumerable
; RVA 0x4EA23D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA23D4  sub      sp, sp, #0x100
004EA23D8  str      x30, [sp, #0xc0]
004EA23DC  stp      x24, x23, [sp, #0xd0]
004EA23E0  stp      x22, x21, [sp, #0xe0]
004EA23E4  stp      x20, x19, [sp, #0xf0]
004EA23E8  adrp     x22, #0x9592000
004EA23EC  ldrb     w8, [x22, #0x834]
004EA23F0  mov      x20, x2
004EA23F4  mov      x19, x1
004EA23F8  mov      x21, x0
004EA23FC  tbnz     w8, #0, #0x4ea2420
004EA2400  adrp     x0, #0x8ebf000
004EA2404  ldr      x0, [x0, #0x4e8]
004EA2408  bl       #0x382bd14 ; 
004EA240C  adrp     x0, #0x8ebf000
004EA2410  ldr      x0, [x0, #0x4f0]
004EA2414  bl       #0x382bd14 ; 
004EA2418  mov      w8, #1
004EA241C  strb     w8, [x22, #0x834]
004EA2420  movi     v0.2d, #0000000000000000
004EA2424  str      xzr, [sp, #0xb0]
004EA2428  stp      q0, q0, [sp, #0x90]
004EA242C  str      q0, [sp, #0x80]
004EA2430  ldr      w8, [x21, #0x1c]
004EA2434  add      w8, w8, #1
004EA2438  str      w8, [x21, #0x1c]
004EA243C  cbz      x19, #0x4ea26f4
004EA2440  ldr      x8, [x20, #0x20]
004EA2444  ldr      x8, [x8, #0xc0]
004EA2448  ldr      x1, [x8, #0x20]
004EA244C  ldrb     w8, [x1, #0x135]
004EA2450  tbnz     w8, #0, #0x4ea2460
004EA2454  mov      x0, x1
004EA2458  bl       #0x3a7e60c ; 
004EA245C  mov      x1, x0
004EA2460  ldr      x8, [x19]
004EA2464  ldrh     w9, [x8, #0x12e]
004EA2468  cbz      x9, #0x4ea248c
004EA246C  ldr      x10, [x8, #0xb0]
004EA2470  add      x10, x10, #8
004EA2474  ldur     x11, [x10, #-8]
004EA2478  cmp      x11, x1
004EA247C  b.eq     #0x4ea249c
004EA2480  subs     x9, x9, #1
004EA2484  add      x10, x10, #0x10
004EA2488  b.ne     #0x4ea2474
004EA248C  mov      x0, x19
004EA2490  mov      w2, wzr
004EA2494  bl       #0x3a7e710 ; 
004EA2498  b        #0x4ea24a8 ; 
004EA249C  ldrsw    x9, [x10]
004EA24A0  add      x8, x8, x9, lsl #4
004EA24A4  add      x0, x8, #0x138
004EA24A8  ldp      x8, x1, [x0]
004EA24AC  adrp     x22, #0x8ebf000
004EA24B0  ldr      x22, [x22, #0x4e8]
004EA24B4  mov      x0, x19
004EA24B8  blr      x8
004EA24BC  mov      x19, x0
004EA24C0  cbz      x0, #0x4ea26f8
004EA24C4  adrp     x23, #0x8ebf000
004EA24C8  ldr      x23, [x23, #0x4f0]
004EA24CC  mov      w24, #0x38
004EA24D0  ldr      x8, [x19]
004EA24D4  ldr      x1, [x23]
004EA24D8  ldrh     w9, [x8, #0x12e]
004EA24DC  cbz      x9, #0x4ea2500
004EA24E0  ldr      x10, [x8, #0xb0]
004EA24E4  add      x10, x10, #8
004EA24E8  ldur     x11, [x10, #-8]
004EA24EC  cmp      x11, x1
004EA24F0  b.eq     #0x4ea2510
004EA24F4  subs     x9, x9, #1
004EA24F8  add      x10, x10, #0x10
004EA24FC  b.ne     #0x4ea24e8
004EA2500  mov      x0, x19
004EA2504  mov      w2, wzr
004EA2508  bl       #0x3a7e710 ; 
004EA250C  b        #0x4ea251c ; 
004EA2510  ldrsw    x9, [x10]
004EA2514  add      x8, x8, x9, lsl #4
004EA2518  add      x0, x8, #0x138
004EA251C  ldp      x8, x1, [x0]
004EA2520  mov      x0, x19
004EA2524  blr      x8
004EA2528  tbz      w0, #0, #0x4ea266c
004EA252C  ldr      x8, [x20, #0x20]
004EA2530  ldr      x8, [x8, #0xc0]
004EA2534  ldr      x1, [x8, #0x148]
004EA2538  ldrb     w8, [x1, #0x135]
004EA253C  tbnz     w8, #0, #0x4ea254c
004EA2540  mov      x0, x1
004EA2544  bl       #0x3a7e60c ; 
004EA2548  mov      x1, x0
004EA254C  ldr      x8, [x19]
004EA2550  ldrh     w9, [x8, #0x12e]
004EA2554  cbz      x9, #0x4ea2578
004EA2558  ldr      x10, [x8, #0xb0]
004EA255C  add      x10, x10, #8
004EA2560  ldur     x11, [x10, #-8]
004EA2564  cmp      x11, x1
004EA2568  b.eq     #0x4ea2588
004EA256C  subs     x9, x9, #1
004EA2570  add      x10, x10, #0x10
004EA2574  b.ne     #0x4ea2560
004EA2578  mov      x0, x19
004EA257C  mov      w2, wzr
004EA2580  bl       #0x3a7e710 ; 
004EA2584  b        #0x4ea2594 ; 
004EA2588  ldrsw    x9, [x10]
004EA258C  add      x8, x8, x9, lsl #4
004EA2590  add      x0, x8, #0x138
004EA2594  ldp      x9, x1, [x0]
004EA2598  add      x8, sp, #0x40
004EA259C  mov      x0, x19
004EA25A0  blr      x9
004EA25A4  ldp      q0, q1, [sp, #0x40]
004EA25A8  ldr      q2, [sp, #0x60]
004EA25AC  ldr      x8, [sp, #0x70]
004EA25B0  stp      q0, q1, [sp, #0x80]
004EA25B4  str      q2, [sp, #0xa0]
004EA25B8  str      x8, [sp, #0xb0]
004EA25BC  ldr      x8, [x21, #0x10]
004EA25C0  cbz      x8, #0x4ea26ec
004EA25C4  ldr      w9, [x21, #0x18]
004EA25C8  ldr      w10, [x8, #0x18]
004EA25CC  cmp      w9, w10
004EA25D0  b.ne     #0x4ea25f4
004EA25D4  ldr      x8, [x20, #0x20]
004EA25D8  add      w1, w9, #1
004EA25DC  ldr      x8, [x8, #0xc0]
004EA25E0  ldr      x2, [x8, #0x78]
004EA25E4  mov      x0, x21
004EA25E8  bl       #0x4ea0374 ; System.Collections.Generic.List<WeightRandomData>$$EnsureCapacity
004EA25EC  ldr      x8, [x21, #0x10]
004EA25F0  ldr      w9, [x21, #0x18]
004EA25F4  add      w10, w9, #1
004EA25F8  str      w10, [x21, #0x18]
004EA25FC  ldp      q0, q1, [sp, #0x80]
004EA2600  ldr      q2, [sp, #0xa0]
004EA2604  ldr      x10, [sp, #0xb0]
004EA2608  stp      q0, q1, [sp, #0x40]
004EA260C  str      q2, [sp, #0x60]
004EA2610  str      x10, [sp, #0x70]
004EA2614  cbz      x8, #0x4ea26f0
004EA2618  ldp      q0, q1, [sp, #0x40]
004EA261C  ldr      q2, [sp, #0x60]
004EA2620  ldr      x10, [sp, #0x70]
004EA2624  stp      q0, q1, [sp]
004EA2628  str      q2, [sp, #0x20]
004EA262C  str      x10, [sp, #0x30]
004EA2630  ldr      w10, [x8, #0x18]
004EA2634  cmp      w9, w10
004EA2638  b.hs     #0x4ea26e8
004EA263C  ldp      q2, q0, [sp, #0x10]
004EA2640  ldr      x10, [sp, #0x30]
004EA2644  ldr      q1, [sp]
004EA2648  sxtw     x9, w9
004EA264C  madd     x8, x9, x24, x8
004EA2650  add      x0, x8, #0x30
004EA2654  str      x10, [x8, #0x50]
004EA2658  stp      q2, q0, [x8, #0x30]
004EA265C  str      q1, [x8, #0x20]
004EA2660  mov      x1, xzr
004EA2664  bl       #0x382bcb8 ; 
004EA2668  b        #0x4ea24d0 ; 
004EA266C  mov      x20, xzr
004EA2670  cbz      x19, #0x4ea26cc
004EA2674  ldr      x8, [x19]
004EA2678  ldr      x1, [x22]
004EA267C  ldrh     w9, [x8, #0x12e]
004EA2680  cbz      x9, #0x4ea26a4
004EA2684  ldr      x10, [x8, #0xb0]
004EA2688  add      x10, x10, #8
004EA268C  ldur     x11, [x10, #-8]
004EA2690  cmp      x11, x1
004EA2694  b.eq     #0x4ea26b4
004EA2698  subs     x9, x9, #1
004EA269C  add      x10, x10, #0x10
004EA26A0  b.ne     #0x4ea268c
004EA26A4  mov      x0, x19
004EA26A8  mov      w2, wzr
004EA26AC  bl       #0x3a7e710 ; 
004EA26B0  b        #0x4ea26c0 ; 
004EA26B4  ldrsw    x9, [x10]
004EA26B8  add      x8, x8, x9, lsl #4
004EA26BC  add      x0, x8, #0x138
004EA26C0  ldp      x8, x1, [x0]
004EA26C4  mov      x0, x19
004EA26C8  blr      x8
004EA26CC  cbnz     x20, #0x4ea26fc
004EA26D0  ldp      x20, x19, [sp, #0xf0]
004EA26D4  ldp      x22, x21, [sp, #0xe0]
004EA26D8  ldp      x24, x23, [sp, #0xd0]
004EA26DC  ldr      x30, [sp, #0xc0]
004EA26E0  add      sp, sp, #0x100
004EA26E4  ret      
004EA26E8  bl       #0x382bfc0 ; 
004EA26EC  bl       #0x382bfb8 ; 
004EA26F0  bl       #0x382bfb8 ; 
004EA26F4  bl       #0x382bfb8 ; 
004EA26F8  bl       #0x382bfb8 ; 
004EA26FC  mov      x0, x20
004EA2700  bl       #0x382bfb0 ; 
004EA2704  b        #0x4ea271c ; 
004EA2708  b        #0x4ea271c ; 
004EA270C  b        #0x4ea271c ; 
004EA2710  b        #0x4ea271c ; 
004EA2714  b        #0x4ea271c ; 
004EA2718  b        #0x4ea271c ; 
004EA271C  mov      x21, x0
004EA2720  cmp      w1, #1
004EA2724  b.ne     #0x4ea273c
004EA2728  mov      x0, x21
004EA272C  bl       #0x89eda50 ; 
004EA2730  ldr      x20, [x0]
004EA2734  bl       #0x89eda60 ; 
004EA2738  b        #0x4ea2670 ; 
004EA273C  mov      x20, xzr
004EA2740  b        #0x4ea2748 ; 
004EA2744  mov      x21, x0
004EA2748  cbz      x19, #0x4ea27a4
004EA274C  ldr      x8, [x19]
004EA2750  ldr      x1, [x22]
004EA2754  ldrh     w9, [x8, #0x12e]
004EA2758  cbz      x9, #0x4ea277c
004EA275C  ldr      x10, [x8, #0xb0]
004EA2760  add      x10, x10, #8
004EA2764  ldur     x11, [x10, #-8]
004EA2768  cmp      x11, x1
004EA276C  b.eq     #0x4ea278c
004EA2770  subs     x9, x9, #1
004EA2774  add      x10, x10, #0x10
004EA2778  b.ne     #0x4ea2764
004EA277C  mov      x0, x19
004EA2780  mov      w2, wzr
004EA2784  bl       #0x3a7e710 ; 
004EA2788  b        #0x4ea2798 ; 
004EA278C  ldrsw    x9, [x10]
004EA2790  add      x8, x8, x9, lsl #4
004EA2794  add      x0, x8, #0x138
004EA2798  ldp      x8, x1, [x0]
004EA279C  mov      x0, x19
004EA27A0  blr      x8
004EA27A4  cbnz     x20, #0x4ea27b0
004EA27A8  mov      x0, x21
004EA27AC  bl       #0x3b56bfc ; 
004EA27B0  mov      x0, x20
004EA27B4  bl       #0x382bfb0 ; 
004EA27B8  bl       #0x3442448 ; 

; System.Collections.Generic.List<WeightRandomData>$$.cctor
; RVA 0x4EA27BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004EA27BC  str      x30, [sp, #-0x20]!
004EA27C0  stp      x20, x19, [sp, #0x10]
004EA27C4  mov      x19, x0
004EA27C8  ldr      x0, [x0, #0x20]
004EA27CC  ldrb     w8, [x0, #0x135]
004EA27D0  tbnz     w8, #0, #0x4ea27d8
004EA27D4  bl       #0x3a7e60c ; 
004EA27D8  ldr      x8, [x0, #0xc0]
004EA27DC  ldr      x0, [x8, #0x18]
004EA27E0  ldrb     w8, [x0, #0x135]
004EA27E4  tbnz     w8, #0, #0x4ea27ec
004EA27E8  bl       #0x3a7e60c ; 
004EA27EC  mov      w1, wzr
004EA27F0  bl       #0x382bdfc ; 
004EA27F4  ldr      x8, [x19, #0x20]
004EA27F8  mov      x20, x0
004EA27FC  ldrb     w9, [x8, #0x135]
004EA2800  tbnz     w9, #0, #0x4ea2810
004EA2804  mov      x0, x8
004EA2808  bl       #0x3a7e60c ; 
004EA280C  mov      x8, x0
004EA2810  ldr      x8, [x8, #0xc0]
004EA2814  ldr      x0, [x8, #0x10]
004EA2818  ldrb     w8, [x0, #0x135]
004EA281C  tbnz     w8, #0, #0x4ea2824
004EA2820  bl       #0x3a7e60c ; 
004EA2824  ldr      x8, [x0, #0xb8]
004EA2828  str      x20, [x8]
004EA282C  ldr      x0, [x19, #0x20]
004EA2830  ldrb     w8, [x0, #0x135]
004EA2834  tbnz     w8, #0, #0x4ea283c
004EA2838  bl       #0x3a7e60c ; 
004EA283C  ldr      x8, [x0, #0xc0]
004EA2840  ldr      x0, [x8, #0x10]
004EA2844  ldrb     w8, [x0, #0x135]
004EA2848  tbnz     w8, #0, #0x4ea2850
004EA284C  bl       #0x3a7e60c ; 
004EA2850  ldr      x0, [x0, #0xb8]
004EA2854  mov      x1, x20
004EA2858  ldp      x20, x19, [sp, #0x10]
004EA285C  ldr      x30, [sp], #0x20
004EA2860  b        #0x382bcb8 ; 

