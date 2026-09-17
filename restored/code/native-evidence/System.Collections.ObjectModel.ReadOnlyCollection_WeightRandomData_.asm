; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$.ctor
; RVA 0x53D8290; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8290  str      x30, [sp, #-0x20]!
0053D8294  stp      x20, x19, [sp, #0x10]
0053D8298  mov      x19, x1
0053D829C  mov      x1, xzr
0053D82A0  mov      x20, x0
0053D82A4  bl       #0x7c335dc ; System.Object$$.ctor
0053D82A8  cbnz     x19, #0x53d82b8
0053D82AC  mov      w0, #7
0053D82B0  mov      x1, xzr
0053D82B4  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
0053D82B8  str      x19, [x20, #0x10]!
0053D82BC  mov      x0, x20
0053D82C0  mov      x1, x19
0053D82C4  ldp      x20, x19, [sp, #0x10]
0053D82C8  ldr      x30, [sp], #0x20
0053D82CC  b        #0x382bcb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$get_Count
; RVA 0x53D82D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D82D0  stp      x30, x19, [sp, #-0x10]!
0053D82D4  ldr      x19, [x0, #0x10]
0053D82D8  cbz      x19, #0x53d8354
0053D82DC  ldr      x8, [x1, #0x20]
0053D82E0  ldr      x8, [x8, #0xc0]
0053D82E4  ldr      x1, [x8, #0x10]
0053D82E8  ldrb     w8, [x1, #0x135]
0053D82EC  tbnz     w8, #0, #0x53d82fc
0053D82F0  mov      x0, x1
0053D82F4  bl       #0x3a7e60c ; 
0053D82F8  mov      x1, x0
0053D82FC  ldr      x8, [x19]
0053D8300  ldrh     w9, [x8, #0x12e]
0053D8304  cbz      x9, #0x53d8328
0053D8308  ldr      x10, [x8, #0xb0]
0053D830C  add      x10, x10, #8
0053D8310  ldur     x11, [x10, #-8]
0053D8314  cmp      x11, x1
0053D8318  b.eq     #0x53d8338
0053D831C  subs     x9, x9, #1
0053D8320  add      x10, x10, #0x10
0053D8324  b.ne     #0x53d8310
0053D8328  mov      x0, x19
0053D832C  mov      w2, wzr
0053D8330  bl       #0x3a7e710 ; 
0053D8334  b        #0x53d8344 ; 
0053D8338  ldrsw    x9, [x10]
0053D833C  add      x8, x8, x9, lsl #4
0053D8340  add      x0, x8, #0x138
0053D8344  ldp      x2, x1, [x0]
0053D8348  mov      x0, x19
0053D834C  ldp      x30, x19, [sp], #0x10
0053D8350  br       x2
0053D8354  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$get_Item
; RVA 0x53D8358; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8358  sub      sp, sp, #0x60
0053D835C  stp      x30, x21, [sp, #0x40]
0053D8360  stp      x20, x19, [sp, #0x50]
0053D8364  ldr      x21, [x0, #0x10]
0053D8368  cbz      x21, #0x53d841c
0053D836C  mov      x19, x8
0053D8370  ldr      x8, [x2, #0x20]
0053D8374  mov      w20, w1
0053D8378  ldr      x8, [x8, #0xc0]
0053D837C  ldr      x1, [x8]
0053D8380  ldrb     w8, [x1, #0x135]
0053D8384  tbnz     w8, #0, #0x53d8394
0053D8388  mov      x0, x1
0053D838C  bl       #0x3a7e60c ; 
0053D8390  mov      x1, x0
0053D8394  ldr      x8, [x21]
0053D8398  ldrh     w9, [x8, #0x12e]
0053D839C  cbz      x9, #0x53d83c0
0053D83A0  ldr      x10, [x8, #0xb0]
0053D83A4  add      x10, x10, #8
0053D83A8  ldur     x11, [x10, #-8]
0053D83AC  cmp      x11, x1
0053D83B0  b.eq     #0x53d83d0
0053D83B4  subs     x9, x9, #1
0053D83B8  add      x10, x10, #0x10
0053D83BC  b.ne     #0x53d83a8
0053D83C0  mov      x0, x21
0053D83C4  mov      w2, wzr
0053D83C8  bl       #0x3a7e710 ; 
0053D83CC  b        #0x53d83dc ; 
0053D83D0  ldrsw    x9, [x10]
0053D83D4  add      x8, x8, x9, lsl #4
0053D83D8  add      x0, x8, #0x138
0053D83DC  ldp      x9, x2, [x0]
0053D83E0  add      x8, sp, #8
0053D83E4  mov      x0, x21
0053D83E8  mov      w1, w20
0053D83EC  blr      x9
0053D83F0  ldr      x8, [sp, #0x38]
0053D83F4  ldur     q0, [sp, #0x28]
0053D83F8  ldur     q1, [sp, #0x18]
0053D83FC  ldur     q2, [sp, #8]
0053D8400  str      x8, [x19, #0x30]
0053D8404  ldp      x30, x21, [sp, #0x40]
0053D8408  stp      q1, q0, [x19, #0x10]
0053D840C  str      q2, [x19]
0053D8410  ldp      x20, x19, [sp, #0x50]
0053D8414  add      sp, sp, #0x60
0053D8418  ret      
0053D841C  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$Contains
; RVA 0x53D8420; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8420  sub      sp, sp, #0xd0
0053D8424  stp      x30, x19, [sp, #0xc0]
0053D8428  ldp      q2, q0, [x1, #0x10]
0053D842C  ldr      x8, [x1, #0x30]
0053D8430  ldr      q1, [x1]
0053D8434  ldr      x19, [x0, #0x10]
0053D8438  stp      q2, q0, [sp, #0x50]
0053D843C  str      x8, [sp, #0x70]
0053D8440  str      q1, [sp, #0x40]
0053D8444  cbz      x19, #0x53d8508
0053D8448  ldr      x8, [x2, #0x20]
0053D844C  ldr      x8, [x8, #0xc0]
0053D8450  ldr      x1, [x8, #0x10]
0053D8454  ldrb     w8, [x1, #0x135]
0053D8458  tbnz     w8, #0, #0x53d8468
0053D845C  mov      x0, x1
0053D8460  bl       #0x3a7e60c ; 
0053D8464  mov      x1, x0
0053D8468  ldp      q0, q1, [sp, #0x40]
0053D846C  ldr      q2, [sp, #0x60]
0053D8470  ldr      x8, [sp, #0x70]
0053D8474  stp      q0, q1, [sp]
0053D8478  str      q2, [sp, #0x20]
0053D847C  str      x8, [sp, #0x30]
0053D8480  ldr      x8, [x19]
0053D8484  ldrh     w9, [x8, #0x12e]
0053D8488  cbz      x9, #0x53d84ac
0053D848C  ldr      x10, [x8, #0xb0]
0053D8490  add      x10, x10, #8
0053D8494  ldur     x11, [x10, #-8]
0053D8498  cmp      x11, x1
0053D849C  b.eq     #0x53d84bc
0053D84A0  subs     x9, x9, #1
0053D84A4  add      x10, x10, #0x10
0053D84A8  b.ne     #0x53d8494
0053D84AC  mov      w2, #4
0053D84B0  mov      x0, x19
0053D84B4  bl       #0x3a7e710 ; 
0053D84B8  b        #0x53d84cc ; 
0053D84BC  ldr      w9, [x10]
0053D84C0  add      w9, w9, #4
0053D84C4  add      x8, x8, w9, sxtw #4
0053D84C8  add      x0, x8, #0x138
0053D84CC  ldp      q0, q1, [sp]
0053D84D0  ldr      q2, [sp, #0x20]
0053D84D4  ldr      x9, [sp, #0x30]
0053D84D8  ldr      x8, [x0]
0053D84DC  stp      q0, q1, [sp, #0x80]
0053D84E0  str      q2, [sp, #0xa0]
0053D84E4  str      x9, [sp, #0xb0]
0053D84E8  ldr      x2, [x0, #8]
0053D84EC  add      x1, sp, #0x80
0053D84F0  mov      x0, x19
0053D84F4  blr      x8
0053D84F8  ldp      x30, x19, [sp, #0xc0]
0053D84FC  and      w0, w0, #1
0053D8500  add      sp, sp, #0xd0
0053D8504  ret      
0053D8508  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$CopyTo
; RVA 0x53D850C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D850C  stp      x30, x21, [sp, #-0x20]!
0053D8510  stp      x20, x19, [sp, #0x10]
0053D8514  ldr      x21, [x0, #0x10]
0053D8518  cbz      x21, #0x53d85ac
0053D851C  ldr      x8, [x3, #0x20]
0053D8520  mov      x20, x1
0053D8524  mov      w19, w2
0053D8528  ldr      x8, [x8, #0xc0]
0053D852C  ldr      x1, [x8, #0x10]
0053D8530  ldrb     w8, [x1, #0x135]
0053D8534  tbnz     w8, #0, #0x53d8544
0053D8538  mov      x0, x1
0053D853C  bl       #0x3a7e60c ; 
0053D8540  mov      x1, x0
0053D8544  ldr      x8, [x21]
0053D8548  ldrh     w9, [x8, #0x12e]
0053D854C  cbz      x9, #0x53d8570
0053D8550  ldr      x10, [x8, #0xb0]
0053D8554  add      x10, x10, #8
0053D8558  ldur     x11, [x10, #-8]
0053D855C  cmp      x11, x1
0053D8560  b.eq     #0x53d8580
0053D8564  subs     x9, x9, #1
0053D8568  add      x10, x10, #0x10
0053D856C  b.ne     #0x53d8558
0053D8570  mov      w2, #5
0053D8574  mov      x0, x21
0053D8578  bl       #0x3a7e710 ; 
0053D857C  b        #0x53d8590 ; 
0053D8580  ldr      w9, [x10]
0053D8584  add      w9, w9, #5
0053D8588  add      x8, x8, w9, sxtw #4
0053D858C  add      x0, x8, #0x138
0053D8590  ldp      x4, x3, [x0]
0053D8594  mov      x1, x20
0053D8598  mov      w2, w19
0053D859C  ldp      x20, x19, [sp, #0x10]
0053D85A0  mov      x0, x21
0053D85A4  ldp      x30, x21, [sp], #0x20
0053D85A8  br       x4
0053D85AC  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$GetEnumerator
; RVA 0x53D85B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D85B0  stp      x30, x19, [sp, #-0x10]!
0053D85B4  ldr      x19, [x0, #0x10]
0053D85B8  cbz      x19, #0x53d8634
0053D85BC  ldr      x8, [x1, #0x20]
0053D85C0  ldr      x8, [x8, #0xc0]
0053D85C4  ldr      x1, [x8, #0x48]
0053D85C8  ldrb     w8, [x1, #0x135]
0053D85CC  tbnz     w8, #0, #0x53d85dc
0053D85D0  mov      x0, x1
0053D85D4  bl       #0x3a7e60c ; 
0053D85D8  mov      x1, x0
0053D85DC  ldr      x8, [x19]
0053D85E0  ldrh     w9, [x8, #0x12e]
0053D85E4  cbz      x9, #0x53d8608
0053D85E8  ldr      x10, [x8, #0xb0]
0053D85EC  add      x10, x10, #8
0053D85F0  ldur     x11, [x10, #-8]
0053D85F4  cmp      x11, x1
0053D85F8  b.eq     #0x53d8618
0053D85FC  subs     x9, x9, #1
0053D8600  add      x10, x10, #0x10
0053D8604  b.ne     #0x53d85f0
0053D8608  mov      x0, x19
0053D860C  mov      w2, wzr
0053D8610  bl       #0x3a7e710 ; 
0053D8614  b        #0x53d8624 ; 
0053D8618  ldrsw    x9, [x10]
0053D861C  add      x8, x8, x9, lsl #4
0053D8620  add      x0, x8, #0x138
0053D8624  ldp      x2, x1, [x0]
0053D8628  mov      x0, x19
0053D862C  ldp      x30, x19, [sp], #0x10
0053D8630  br       x2
0053D8634  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$IndexOf
; RVA 0x53D8638; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8638  sub      sp, sp, #0xd0
0053D863C  stp      x30, x19, [sp, #0xc0]
0053D8640  ldp      q2, q0, [x1, #0x10]
0053D8644  ldr      x8, [x1, #0x30]
0053D8648  ldr      q1, [x1]
0053D864C  ldr      x19, [x0, #0x10]
0053D8650  stp      q2, q0, [sp, #0x50]
0053D8654  str      x8, [sp, #0x70]
0053D8658  str      q1, [sp, #0x40]
0053D865C  cbz      x19, #0x53d871c
0053D8660  ldr      x8, [x2, #0x20]
0053D8664  ldr      x8, [x8, #0xc0]
0053D8668  ldr      x1, [x8]
0053D866C  ldrb     w8, [x1, #0x135]
0053D8670  tbnz     w8, #0, #0x53d8680
0053D8674  mov      x0, x1
0053D8678  bl       #0x3a7e60c ; 
0053D867C  mov      x1, x0
0053D8680  ldp      q0, q1, [sp, #0x40]
0053D8684  ldr      q2, [sp, #0x60]
0053D8688  ldr      x8, [sp, #0x70]
0053D868C  stp      q0, q1, [sp]
0053D8690  str      q2, [sp, #0x20]
0053D8694  str      x8, [sp, #0x30]
0053D8698  ldr      x8, [x19]
0053D869C  ldrh     w9, [x8, #0x12e]
0053D86A0  cbz      x9, #0x53d86c4
0053D86A4  ldr      x10, [x8, #0xb0]
0053D86A8  add      x10, x10, #8
0053D86AC  ldur     x11, [x10, #-8]
0053D86B0  cmp      x11, x1
0053D86B4  b.eq     #0x53d86d4
0053D86B8  subs     x9, x9, #1
0053D86BC  add      x10, x10, #0x10
0053D86C0  b.ne     #0x53d86ac
0053D86C4  mov      w2, #2
0053D86C8  mov      x0, x19
0053D86CC  bl       #0x3a7e710 ; 
0053D86D0  b        #0x53d86e4 ; 
0053D86D4  ldr      w9, [x10]
0053D86D8  add      w9, w9, #2
0053D86DC  add      x8, x8, w9, sxtw #4
0053D86E0  add      x0, x8, #0x138
0053D86E4  ldp      q0, q1, [sp]
0053D86E8  ldr      q2, [sp, #0x20]
0053D86EC  ldr      x9, [sp, #0x30]
0053D86F0  ldr      x8, [x0]
0053D86F4  stp      q0, q1, [sp, #0x80]
0053D86F8  str      q2, [sp, #0xa0]
0053D86FC  str      x9, [sp, #0xb0]
0053D8700  ldr      x2, [x0, #8]
0053D8704  add      x1, sp, #0x80
0053D8708  mov      x0, x19
0053D870C  blr      x8
0053D8710  ldp      x30, x19, [sp, #0xc0]
0053D8714  add      sp, sp, #0xd0
0053D8718  ret      
0053D871C  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$get_Items
; RVA 0x53D8720; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8720  ldr      x0, [x0, #0x10]
0053D8724  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.ICollection<T>.get_IsReadOnly
; RVA 0x53D8728; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8728  mov      w0, #1
0053D872C  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.IList<T>.get_Item
; RVA 0x53D8730; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8730  sub      sp, sp, #0x60
0053D8734  stp      x30, x21, [sp, #0x40]
0053D8738  stp      x20, x19, [sp, #0x50]
0053D873C  ldr      x21, [x0, #0x10]
0053D8740  cbz      x21, #0x53d87f4
0053D8744  mov      x19, x8
0053D8748  ldr      x8, [x2, #0x20]
0053D874C  mov      w20, w1
0053D8750  ldr      x8, [x8, #0xc0]
0053D8754  ldr      x1, [x8]
0053D8758  ldrb     w8, [x1, #0x135]
0053D875C  tbnz     w8, #0, #0x53d876c
0053D8760  mov      x0, x1
0053D8764  bl       #0x3a7e60c ; 
0053D8768  mov      x1, x0
0053D876C  ldr      x8, [x21]
0053D8770  ldrh     w9, [x8, #0x12e]
0053D8774  cbz      x9, #0x53d8798
0053D8778  ldr      x10, [x8, #0xb0]
0053D877C  add      x10, x10, #8
0053D8780  ldur     x11, [x10, #-8]
0053D8784  cmp      x11, x1
0053D8788  b.eq     #0x53d87a8
0053D878C  subs     x9, x9, #1
0053D8790  add      x10, x10, #0x10
0053D8794  b.ne     #0x53d8780
0053D8798  mov      x0, x21
0053D879C  mov      w2, wzr
0053D87A0  bl       #0x3a7e710 ; 
0053D87A4  b        #0x53d87b4 ; 
0053D87A8  ldrsw    x9, [x10]
0053D87AC  add      x8, x8, x9, lsl #4
0053D87B0  add      x0, x8, #0x138
0053D87B4  ldp      x9, x2, [x0]
0053D87B8  add      x8, sp, #8
0053D87BC  mov      x0, x21
0053D87C0  mov      w1, w20
0053D87C4  blr      x9
0053D87C8  ldr      x8, [sp, #0x38]
0053D87CC  ldur     q0, [sp, #0x28]
0053D87D0  ldur     q1, [sp, #0x18]
0053D87D4  ldur     q2, [sp, #8]
0053D87D8  str      x8, [x19, #0x30]
0053D87DC  ldp      x30, x21, [sp, #0x40]
0053D87E0  stp      q1, q0, [x19, #0x10]
0053D87E4  str      q2, [x19]
0053D87E8  ldp      x20, x19, [sp, #0x50]
0053D87EC  add      sp, sp, #0x60
0053D87F0  ret      
0053D87F4  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.IList<T>.set_Item
; RVA 0x53D87F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D87F8  mov      w0, #0x1c
0053D87FC  mov      x1, xzr
0053D8800  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.ICollection<T>.Add
; RVA 0x53D8804; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8804  mov      w0, #0x1c
0053D8808  mov      x1, xzr
0053D880C  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.ICollection<T>.Clear
; RVA 0x53D8810; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8810  mov      w0, #0x1c
0053D8814  mov      x1, xzr
0053D8818  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.IList<T>.Insert
; RVA 0x53D881C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D881C  mov      w0, #0x1c
0053D8820  mov      x1, xzr
0053D8824  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.ICollection<T>.Remove
; RVA 0x53D8828; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8828  str      x30, [sp, #-0x10]!
0053D882C  mov      w0, #0x1c
0053D8830  mov      x1, xzr
0053D8834  bl       #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException
0053D8838  mov      w0, wzr
0053D883C  ldr      x30, [sp], #0x10
0053D8840  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.Generic.IList<T>.RemoveAt
; RVA 0x53D8844; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8844  mov      w0, #0x1c
0053D8848  mov      x1, xzr
0053D884C  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IEnumerable.GetEnumerator
; RVA 0x53D8850; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8850  str      x30, [sp, #-0x20]!
0053D8854  stp      x20, x19, [sp, #0x10]
0053D8858  adrp     x20, #0x9593000
0053D885C  ldrb     w8, [x20, #0x60b]
0053D8860  mov      x19, x0
0053D8864  tbnz     w8, #0, #0x53d887c
0053D8868  adrp     x0, #0x8ec2000
0053D886C  ldr      x0, [x0, #0xc78]
0053D8870  bl       #0x382bd14 ; 
0053D8874  mov      w8, #1
0053D8878  strb     w8, [x20, #0x60b]
0053D887C  ldr      x19, [x19, #0x10]
0053D8880  cbz      x19, #0x53d88ec
0053D8884  adrp     x10, #0x8ec2000
0053D8888  ldr      x8, [x19]
0053D888C  ldr      x10, [x10, #0xc78]
0053D8890  ldrh     w9, [x8, #0x12e]
0053D8894  ldr      x1, [x10]
0053D8898  cbz      x9, #0x53d88bc
0053D889C  ldr      x10, [x8, #0xb0]
0053D88A0  add      x10, x10, #8
0053D88A4  ldur     x11, [x10, #-8]
0053D88A8  cmp      x11, x1
0053D88AC  b.eq     #0x53d88cc
0053D88B0  subs     x9, x9, #1
0053D88B4  add      x10, x10, #0x10
0053D88B8  b.ne     #0x53d88a4
0053D88BC  mov      x0, x19
0053D88C0  mov      w2, wzr
0053D88C4  bl       #0x3a7e710 ; 
0053D88C8  b        #0x53d88d8 ; 
0053D88CC  ldrsw    x9, [x10]
0053D88D0  add      x8, x8, x9, lsl #4
0053D88D4  add      x0, x8, #0x138
0053D88D8  ldp      x2, x1, [x0]
0053D88DC  mov      x0, x19
0053D88E0  ldp      x20, x19, [sp, #0x10]
0053D88E4  ldr      x30, [sp], #0x20
0053D88E8  br       x2
0053D88EC  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.ICollection.get_IsSynchronized
; RVA 0x53D88F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D88F0  mov      w0, wzr
0053D88F4  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.ICollection.get_SyncRoot
; RVA 0x53D88F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D88F8  stp      x30, x21, [sp, #-0x20]!
0053D88FC  stp      x20, x19, [sp, #0x10]
0053D8900  adrp     x19, #0x9593000
0053D8904  ldrb     w8, [x19, #0x60c]
0053D8908  mov      x20, x0
0053D890C  tbnz     w8, #0, #0x53d8930
0053D8910  adrp     x0, #0x8ec2000
0053D8914  ldr      x0, [x0, #0xc50]
0053D8918  bl       #0x382bd14 ; 
0053D891C  adrp     x0, #0x8ec2000
0053D8920  ldr      x0, [x0, #0xd60]
0053D8924  bl       #0x382bd14 ; 
0053D8928  mov      w8, #1
0053D892C  strb     w8, [x19, #0x60c]
0053D8930  mov      x19, x20
0053D8934  ldr      x8, [x19, #0x18]!
0053D8938  cbnz     x8, #0x53d89f4
0053D893C  adrp     x21, #0x8ec2000
0053D8940  ldr      x0, [x20, #0x10]
0053D8944  ldr      x21, [x21, #0xc50]
0053D8948  ldr      x1, [x21]
0053D894C  bl       #0x382be90 ; 
0053D8950  cbz      x0, #0x53d8998
0053D8954  ldr      x8, [x0]
0053D8958  ldr      x1, [x21]
0053D895C  mov      x20, x0
0053D8960  ldrh     w9, [x8, #0x12e]
0053D8964  cbz      x9, #0x53d8988
0053D8968  ldr      x10, [x8, #0xb0]
0053D896C  add      x10, x10, #8
0053D8970  ldur     x11, [x10, #-8]
0053D8974  cmp      x11, x1
0053D8978  b.eq     #0x53d89c8
0053D897C  subs     x9, x9, #1
0053D8980  add      x10, x10, #0x10
0053D8984  b.ne     #0x53d8970
0053D8988  mov      w2, #2
0053D898C  mov      x0, x20
0053D8990  bl       #0x3a7e710 ; 
0053D8994  b        #0x53d89d8 ; 
0053D8998  adrp     x8, #0x8ec2000
0053D899C  ldr      x8, [x8, #0xd60]
0053D89A0  ldr      x0, [x8]
0053D89A4  bl       #0x382bfa0 ; 
0053D89A8  mov      x1, xzr
0053D89AC  mov      x20, x0
0053D89B0  bl       #0x7c335dc ; System.Object$$.ctor
0053D89B4  mov      x0, x19
0053D89B8  mov      x1, x20
0053D89BC  mov      x2, xzr
0053D89C0  bl       #0x3ad5fac ; 
0053D89C4  b        #0x53d89f4 ; 
0053D89C8  ldr      w9, [x10]
0053D89CC  add      w9, w9, #2
0053D89D0  add      x8, x8, w9, sxtw #4
0053D89D4  add      x0, x8, #0x138
0053D89D8  ldp      x8, x1, [x0]
0053D89DC  mov      x0, x20
0053D89E0  blr      x8
0053D89E4  mov      x1, x0
0053D89E8  str      x0, [x19]
0053D89EC  mov      x0, x19
0053D89F0  bl       #0x382bcb8 ; 
0053D89F4  ldr      x0, [x19]
0053D89F8  ldp      x20, x19, [sp, #0x10]
0053D89FC  ldp      x30, x21, [sp], #0x20
0053D8A00  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.ICollection.CopyTo
; RVA 0x53D8A04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8A04  sub      sp, sp, #0xc0
0053D8A08  stp      x30, x25, [sp, #0x80]
0053D8A0C  stp      x24, x23, [sp, #0x90]
0053D8A10  stp      x22, x21, [sp, #0xa0]
0053D8A14  stp      x20, x19, [sp, #0xb0]
0053D8A18  adrp     x23, #0x9593000
0053D8A1C  ldrb     w8, [x23, #0x60d]
0053D8A20  mov      x20, x3
0053D8A24  mov      w19, w2
0053D8A28  mov      x22, x1
0053D8A2C  mov      x21, x0
0053D8A30  tbnz     w8, #0, #0x53d8a54
0053D8A34  adrp     x0, #0x8ec2000
0053D8A38  ldr      x0, [x0, #0xbc8]
0053D8A3C  bl       #0x382bd14 ; 
0053D8A40  adrp     x0, #0x8ebf000
0053D8A44  ldr      x0, [x0, #0x3a8]
0053D8A48  bl       #0x382bd14 ; 
0053D8A4C  mov      w8, #1
0053D8A50  strb     w8, [x23, #0x60d]
0053D8A54  cbz      x22, #0x53d8e34
0053D8A58  mov      x0, x22
0053D8A5C  mov      x1, xzr
0053D8A60  bl       #0x7c00480 ; System.Array$$get_Rank
0053D8A64  cmp      w0, #1
0053D8A68  b.eq     #0x53d8a78
0053D8A6C  mov      w0, #7
0053D8A70  mov      x1, xzr
0053D8A74  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
0053D8A78  mov      x0, x22
0053D8A7C  mov      w1, wzr
0053D8A80  mov      x2, xzr
0053D8A84  bl       #0x7c001cc ; System.Array$$GetLowerBound
0053D8A88  cbz      w0, #0x53d8a98
0053D8A8C  mov      w0, #6
0053D8A90  mov      x1, xzr
0053D8A94  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
0053D8A98  tbz      w19, #0x1f, #0x53d8aa4
0053D8A9C  mov      x0, xzr
0053D8AA0  bl       #0x7bfe7e4 ; System.ThrowHelper$$ThrowIndexArgumentOutOfRange_NeedNonNegNumException
0053D8AA4  mov      x0, x22
0053D8AA8  mov      x1, xzr
0053D8AAC  bl       #0x7bffd60 ; System.Array$$get_Length
0053D8AB0  ldr      x8, [x20, #0x20]
0053D8AB4  mov      w23, w0
0053D8AB8  mov      x0, x21
0053D8ABC  ldr      x8, [x8, #0xc0]
0053D8AC0  ldr      x1, [x8, #0x68]
0053D8AC4  bl       #0x53d82d0 ; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$get_Count
0053D8AC8  sub      w8, w23, w19
0053D8ACC  cmp      w8, w0
0053D8AD0  b.ge     #0x53d8ae0
0053D8AD4  mov      w0, #5
0053D8AD8  mov      x1, xzr
0053D8ADC  bl       #0x7bfdf64 ; System.ThrowHelper$$ThrowArgumentException
0053D8AE0  ldr      x8, [x20, #0x20]
0053D8AE4  ldr      x8, [x8, #0xc0]
0053D8AE8  ldr      x1, [x8, #0x38]
0053D8AEC  ldrb     w8, [x1, #0x135]
0053D8AF0  tbnz     w8, #0, #0x53d8b00
0053D8AF4  mov      x0, x1
0053D8AF8  bl       #0x3a7e60c ; 
0053D8AFC  mov      x1, x0
0053D8B00  mov      x0, x22
0053D8B04  bl       #0x382be90 ; 
0053D8B08  cbz      x0, #0x53d8b74
0053D8B0C  ldr      x21, [x21, #0x10]
0053D8B10  cbz      x21, #0x53d8e40
0053D8B14  ldr      x8, [x20, #0x20]
0053D8B18  mov      x23, x0
0053D8B1C  ldr      x8, [x8, #0xc0]
0053D8B20  ldr      x1, [x8, #0x10]
0053D8B24  ldrb     w8, [x1, #0x135]
0053D8B28  tbnz     w8, #0, #0x53d8b38
0053D8B2C  mov      x0, x1
0053D8B30  bl       #0x3a7e60c ; 
0053D8B34  mov      x1, x0
0053D8B38  ldr      x8, [x21]
0053D8B3C  ldrh     w9, [x8, #0x12e]
0053D8B40  cbz      x9, #0x53d8b64
0053D8B44  ldr      x10, [x8, #0xb0]
0053D8B48  add      x10, x10, #8
0053D8B4C  ldur     x11, [x10, #-8]
0053D8B50  cmp      x11, x1
0053D8B54  b.eq     #0x53d8c9c
0053D8B58  subs     x9, x9, #1
0053D8B5C  add      x10, x10, #0x10
0053D8B60  b.ne     #0x53d8b4c
0053D8B64  mov      w2, #5
0053D8B68  mov      x0, x21
0053D8B6C  bl       #0x3a7e710 ; 
0053D8B70  b        #0x53d8cac ; 
0053D8B74  mov      x0, x22
0053D8B78  mov      x1, xzr
0053D8B7C  bl       #0x7c33c40 ; System.Object$$GetType
0053D8B80  cbz      x0, #0x53d8e40
0053D8B84  ldr      x8, [x0]
0053D8B88  ldr      x9, [x8, #0x538]
0053D8B8C  ldr      x1, [x8, #0x540]
0053D8B90  blr      x9
0053D8B94  adrp     x8, #0x8ebf000
0053D8B98  ldr      x9, [x20, #0x20]
0053D8B9C  ldr      x8, [x8, #0x3a8]
0053D8BA0  mov      x23, x0
0053D8BA4  ldr      x9, [x9, #0xc0]
0053D8BA8  ldr      x8, [x8]
0053D8BAC  ldr      x24, [x9, #0x70]
0053D8BB0  ldr      w10, [x8, #0xe0]
0053D8BB4  cbnz     w10, #0x53d8bc0
0053D8BB8  mov      x0, x8
0053D8BBC  bl       #0x382be8c ; 
0053D8BC0  mov      x0, x24
0053D8BC4  mov      x1, xzr
0053D8BC8  bl       #0x7be5bc0 ; System.Type$$GetTypeFromHandle
0053D8BCC  cbz      x23, #0x53d8e40
0053D8BD0  ldr      x8, [x23]
0053D8BD4  mov      x24, x0
0053D8BD8  mov      x0, x23
0053D8BDC  mov      x1, x24
0053D8BE0  ldr      x9, [x8, #0x388]
0053D8BE4  ldr      x2, [x8, #0x390]
0053D8BE8  blr      x9
0053D8BEC  tbnz     w0, #0, #0x53d8c18
0053D8BF0  cbz      x24, #0x53d8e40
0053D8BF4  ldr      x8, [x24]
0053D8BF8  mov      x0, x24
0053D8BFC  mov      x1, x23
0053D8C00  ldr      x9, [x8, #0x388]
0053D8C04  ldr      x2, [x8, #0x390]
0053D8C08  blr      x9
0053D8C0C  tbnz     w0, #0, #0x53d8c18
0053D8C10  mov      x0, xzr
0053D8C14  bl       #0x7bfe81c ; System.ThrowHelper$$ThrowArgumentException_Argument_InvalidArrayType
0053D8C18  adrp     x8, #0x8ec2000
0053D8C1C  ldr      x8, [x8, #0xbc8]
0053D8C20  mov      x0, x22
0053D8C24  ldr      x1, [x8]
0053D8C28  bl       #0x382be90 ; 
0053D8C2C  mov      x22, x0
0053D8C30  cbnz     x0, #0x53d8c38
0053D8C34  bl       #0x7bfe81c ; System.ThrowHelper$$ThrowArgumentException_Argument_InvalidArrayType
0053D8C38  ldr      x23, [x21, #0x10]
0053D8C3C  cbz      x23, #0x53d8e40
0053D8C40  ldr      x8, [x20, #0x20]
0053D8C44  ldr      x8, [x8, #0xc0]
0053D8C48  ldr      x1, [x8, #0x10]
0053D8C4C  ldrb     w8, [x1, #0x135]
0053D8C50  tbnz     w8, #0, #0x53d8c60
0053D8C54  mov      x0, x1
0053D8C58  bl       #0x3a7e60c ; 
0053D8C5C  mov      x1, x0
0053D8C60  ldr      x8, [x23]
0053D8C64  ldrh     w9, [x8, #0x12e]
0053D8C68  cbz      x9, #0x53d8c8c
0053D8C6C  ldr      x10, [x8, #0xb0]
0053D8C70  add      x10, x10, #8
0053D8C74  ldur     x11, [x10, #-8]
0053D8C78  cmp      x11, x1
0053D8C7C  b.eq     #0x53d8cd4
0053D8C80  subs     x9, x9, #1
0053D8C84  add      x10, x10, #0x10
0053D8C88  b.ne     #0x53d8c74
0053D8C8C  mov      x0, x23
0053D8C90  mov      w2, wzr
0053D8C94  bl       #0x3a7e710 ; 
0053D8C98  b        #0x53d8ce0 ; 
0053D8C9C  ldr      w9, [x10]
0053D8CA0  add      w9, w9, #5
0053D8CA4  add      x8, x8, w9, sxtw #4
0053D8CA8  add      x0, x8, #0x138
0053D8CAC  ldp      x4, x3, [x0]
0053D8CB0  mov      x0, x21
0053D8CB4  mov      x1, x23
0053D8CB8  mov      w2, w19
0053D8CBC  ldp      x20, x19, [sp, #0xb0]
0053D8CC0  ldp      x22, x21, [sp, #0xa0]
0053D8CC4  ldp      x24, x23, [sp, #0x90]
0053D8CC8  ldp      x30, x25, [sp, #0x80]
0053D8CCC  add      sp, sp, #0xc0
0053D8CD0  br       x4
0053D8CD4  ldrsw    x9, [x10]
0053D8CD8  add      x8, x8, x9, lsl #4
0053D8CDC  add      x0, x8, #0x138
0053D8CE0  ldp      x8, x1, [x0]
0053D8CE4  mov      x0, x23
0053D8CE8  blr      x8
0053D8CEC  cmp      w0, #1
0053D8CF0  b.lt     #0x53d8e04
0053D8CF4  mov      w23, w0
0053D8CF8  mov      w24, wzr
0053D8CFC  ldr      x25, [x21, #0x10]
0053D8D00  cbz      x25, #0x53d8e1c
0053D8D04  ldr      x8, [x20, #0x20]
0053D8D08  ldr      x8, [x8, #0xc0]
0053D8D0C  ldr      x1, [x8]
0053D8D10  ldrb     w8, [x1, #0x135]
0053D8D14  tbnz     w8, #0, #0x53d8d24
0053D8D18  mov      x0, x1
0053D8D1C  bl       #0x3a7e60c ; 
0053D8D20  mov      x1, x0
0053D8D24  ldr      x8, [x25]
0053D8D28  ldrh     w9, [x8, #0x12e]
0053D8D2C  cbz      x9, #0x53d8d50
0053D8D30  ldr      x10, [x8, #0xb0]
0053D8D34  add      x10, x10, #8
0053D8D38  ldur     x11, [x10, #-8]
0053D8D3C  cmp      x11, x1
0053D8D40  b.eq     #0x53d8d60
0053D8D44  subs     x9, x9, #1
0053D8D48  add      x10, x10, #0x10
0053D8D4C  b.ne     #0x53d8d38
0053D8D50  mov      x0, x25
0053D8D54  mov      w2, wzr
0053D8D58  bl       #0x3a7e710 ; 
0053D8D5C  b        #0x53d8d6c ; 
0053D8D60  ldrsw    x9, [x10]
0053D8D64  add      x8, x8, x9, lsl #4
0053D8D68  add      x0, x8, #0x138
0053D8D6C  ldp      x9, x2, [x0]
0053D8D70  mov      x8, sp
0053D8D74  mov      x0, x25
0053D8D78  mov      w1, w24
0053D8D7C  blr      x9
0053D8D80  ldp      q0, q1, [sp]
0053D8D84  ldr      q2, [sp, #0x20]
0053D8D88  ldr      x8, [sp, #0x30]
0053D8D8C  stp      q0, q1, [sp, #0x40]
0053D8D90  str      q2, [sp, #0x60]
0053D8D94  str      x8, [sp, #0x70]
0053D8D98  stp      q0, q1, [sp]
0053D8D9C  str      q2, [sp, #0x20]
0053D8DA0  str      x8, [sp, #0x30]
0053D8DA4  ldr      x8, [x20, #0x20]
0053D8DA8  ldr      x8, [x8, #0xc0]
0053D8DAC  ldr      x0, [x8, #0x28]
0053D8DB0  mov      x1, sp
0053D8DB4  bl       #0x382be94 ; 
0053D8DB8  cbz      x22, #0x53d8e20
0053D8DBC  mov      x25, x0
0053D8DC0  cbz      x0, #0x53d8dd8
0053D8DC4  ldr      x8, [x22]
0053D8DC8  ldr      x1, [x8, #0x40]
0053D8DCC  mov      x0, x25
0053D8DD0  bl       #0x382be90 ; 
0053D8DD4  cbz      x0, #0x53d8e28
0053D8DD8  ldr      w8, [x22, #0x18]
0053D8DDC  cmp      w19, w8
0053D8DE0  b.hs     #0x53d8e24
0053D8DE4  add      x0, x22, w19, sxtw #3
0053D8DE8  str      x25, [x0, #0x20]!
0053D8DEC  mov      x1, x25
0053D8DF0  bl       #0x382bcb8 ; 
0053D8DF4  add      w24, w24, #1
0053D8DF8  cmp      w24, w23
0053D8DFC  add      w19, w19, #1
0053D8E00  b.ne     #0x53d8cfc
0053D8E04  ldp      x20, x19, [sp, #0xb0]
0053D8E08  ldp      x22, x21, [sp, #0xa0]
0053D8E0C  ldp      x24, x23, [sp, #0x90]
0053D8E10  ldp      x30, x25, [sp, #0x80]
0053D8E14  add      sp, sp, #0xc0
0053D8E18  ret      
0053D8E1C  bl       #0x382bfb8 ; 
0053D8E20  bl       #0x382bfb8 ; 
0053D8E24  bl       #0x382bfc0 ; 
0053D8E28  bl       #0x382bfdc ; 
0053D8E2C  mov      x1, xzr
0053D8E30  bl       #0x382be7c ; 
0053D8E34  mov      w0, #3
0053D8E38  mov      x1, xzr
0053D8E3C  bl       #0x7bfd7d8 ; System.ThrowHelper$$ThrowArgumentNullException
0053D8E40  bl       #0x382bfb8 ; 
0053D8E44  b        #0x53d8e50 ; 
0053D8E48  b        #0x53d8e50 ; 
0053D8E4C  b        #0x53d8e50 ; 
0053D8E50  mov      x19, x0
0053D8E54  cmp      w1, #1
0053D8E58  b.ne     #0x53d8ebc
0053D8E5C  mov      x0, x19
0053D8E60  bl       #0x89eda50 ; 
0053D8E64  mov      x19, x0
0053D8E68  adrp     x0, #0x8ee7000
0053D8E6C  ldr      x0, [x0, #0x758]
0053D8E70  bl       #0x382bd28 ; 
0053D8E74  ldr      x8, [x19]
0053D8E78  ldr      x1, [x8]
0053D8E7C  bl       #0x382c3e4 ; 
0053D8E80  tbz      w0, #0, #0x53d8e94
0053D8E84  bl       #0x89eda60 ; 
0053D8E88  mov      x0, xzr
0053D8E8C  bl       #0x7bfe81c ; System.ThrowHelper$$ThrowArgumentException_Argument_InvalidArrayType
0053D8E90  b        #0x53d8e04 ; 
0053D8E94  mov      w0, #8
0053D8E98  bl       #0x89eda70 ; 
0053D8E9C  ldr      x8, [x19]
0053D8EA0  str      x8, [x0]
0053D8EA4  adrp     x1, #0x89f3000
0053D8EA8  add      x1, x1, #0xf98
0053D8EAC  mov      x2, xzr
0053D8EB0  bl       #0x89eda80 ; 
0053D8EB4  mov      x19, x0
0053D8EB8  bl       #0x89eda60 ; 
0053D8EBC  mov      x0, x19
0053D8EC0  bl       #0x3b56bfc ; 
0053D8EC4  bl       #0x3442448 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.get_IsFixedSize
; RVA 0x53D8EC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8EC8  mov      w0, #1
0053D8ECC  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.get_IsReadOnly
; RVA 0x53D8ED0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8ED0  mov      w0, #1
0053D8ED4  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.get_Item
; RVA 0x53D8ED8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8ED8  sub      sp, sp, #0xa0
0053D8EDC  stp      x30, x21, [sp, #0x80]
0053D8EE0  stp      x20, x19, [sp, #0x90]
0053D8EE4  ldr      x21, [x0, #0x10]
0053D8EE8  cbz      x21, #0x53d8fb8
0053D8EEC  ldr      x8, [x2, #0x20]
0053D8EF0  mov      w20, w1
0053D8EF4  mov      x19, x2
0053D8EF8  ldr      x8, [x8, #0xc0]
0053D8EFC  ldr      x1, [x8]
0053D8F00  ldrb     w8, [x1, #0x135]
0053D8F04  tbnz     w8, #0, #0x53d8f14
0053D8F08  mov      x0, x1
0053D8F0C  bl       #0x3a7e60c ; 
0053D8F10  mov      x1, x0
0053D8F14  ldr      x8, [x21]
0053D8F18  ldrh     w9, [x8, #0x12e]
0053D8F1C  cbz      x9, #0x53d8f40
0053D8F20  ldr      x10, [x8, #0xb0]
0053D8F24  add      x10, x10, #8
0053D8F28  ldur     x11, [x10, #-8]
0053D8F2C  cmp      x11, x1
0053D8F30  b.eq     #0x53d8f50
0053D8F34  subs     x9, x9, #1
0053D8F38  add      x10, x10, #0x10
0053D8F3C  b.ne     #0x53d8f28
0053D8F40  mov      x0, x21
0053D8F44  mov      w2, wzr
0053D8F48  bl       #0x3a7e710 ; 
0053D8F4C  b        #0x53d8f5c ; 
0053D8F50  ldrsw    x9, [x10]
0053D8F54  add      x8, x8, x9, lsl #4
0053D8F58  add      x0, x8, #0x138
0053D8F5C  ldp      x9, x2, [x0]
0053D8F60  mov      x8, sp
0053D8F64  mov      x0, x21
0053D8F68  mov      w1, w20
0053D8F6C  blr      x9
0053D8F70  ldr      x8, [sp, #0x30]
0053D8F74  ldp      q1, q0, [sp, #0x10]
0053D8F78  ldr      q2, [sp]
0053D8F7C  mov      x1, sp
0053D8F80  str      x8, [sp, #0x70]
0053D8F84  stp      q1, q0, [sp, #0x50]
0053D8F88  str      q2, [sp, #0x40]
0053D8F8C  stp      q2, q1, [sp]
0053D8F90  str      q0, [sp, #0x20]
0053D8F94  str      x8, [sp, #0x30]
0053D8F98  ldr      x8, [x19, #0x20]
0053D8F9C  ldr      x8, [x8, #0xc0]
0053D8FA0  ldr      x0, [x8, #0x28]
0053D8FA4  bl       #0x382be94 ; 
0053D8FA8  ldp      x20, x19, [sp, #0x90]
0053D8FAC  ldp      x30, x21, [sp, #0x80]
0053D8FB0  add      sp, sp, #0xa0
0053D8FB4  ret      
0053D8FB8  bl       #0x382bfb8 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.set_Item
; RVA 0x53D8FBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8FBC  mov      w0, #0x1c
0053D8FC0  mov      x1, xzr
0053D8FC4  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.Add
; RVA 0x53D8FC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8FC8  str      x30, [sp, #-0x10]!
0053D8FCC  mov      w0, #0x1c
0053D8FD0  mov      x1, xzr
0053D8FD4  bl       #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException
0053D8FD8  mov      w0, #-1
0053D8FDC  ldr      x30, [sp], #0x10
0053D8FE0  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.Clear
; RVA 0x53D8FE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8FE4  mov      w0, #0x1c
0053D8FE8  mov      x1, xzr
0053D8FEC  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$IsCompatibleObject
; RVA 0x53D8FF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D8FF0  stp      x30, x19, [sp, #-0x10]!
0053D8FF4  ldr      x8, [x1, #0x20]
0053D8FF8  mov      x19, x0
0053D8FFC  ldrb     w9, [x8, #0x135]
0053D9000  tbnz     w9, #0, #0x53d9010
0053D9004  mov      x0, x8
0053D9008  bl       #0x3a7e60c ; 
0053D900C  mov      x8, x0
0053D9010  ldr      x8, [x8, #0xc0]
0053D9014  ldr      x1, [x8, #0x28]
0053D9018  ldrb     w8, [x1, #0x135]
0053D901C  tbnz     w8, #0, #0x53d902c
0053D9020  mov      x0, x1
0053D9024  bl       #0x3a7e60c ; 
0053D9028  mov      x1, x0
0053D902C  mov      x0, x19
0053D9030  bl       #0x382be90 ; 
0053D9034  cmp      x0, #0
0053D9038  cset     w0, ne
0053D903C  ldp      x30, x19, [sp], #0x10
0053D9040  ret      

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.Contains
; RVA 0x53D9044; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D9044  sub      sp, sp, #0xa0
0053D9048  stp      x30, x21, [sp, #0x80]
0053D904C  stp      x20, x19, [sp, #0x90]
0053D9050  ldr      x8, [x2, #0x20]
0053D9054  mov      x21, x1
0053D9058  mov      x19, x0
0053D905C  mov      x0, x21
0053D9060  ldr      x8, [x8, #0xc0]
0053D9064  mov      x20, x2
0053D9068  ldr      x1, [x8, #0x78]
0053D906C  bl       #0x53d8ff0 ; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$IsCompatibleObject
0053D9070  tbz      w0, #0, #0x53d9100
0053D9074  ldr      x8, [x20, #0x20]
0053D9078  ldr      x8, [x8, #0xc0]
0053D907C  ldr      x1, [x8, #0x28]
0053D9080  ldrb     w8, [x1, #0x135]
0053D9084  tbnz     w8, #0, #0x53d9094
0053D9088  mov      x0, x1
0053D908C  bl       #0x3a7e60c ; 
0053D9090  mov      x1, x0
0053D9094  cbz      x21, #0x53d9118
0053D9098  ldr      x8, [x21]
0053D909C  ldr      x9, [x1, #0x40]
0053D90A0  mov      x0, x21
0053D90A4  ldr      x8, [x8, #0x40]
0053D90A8  cmp      x8, x9
0053D90AC  b.ne     #0x53d911c
0053D90B0  bl       #0x382be98 ; 
0053D90B4  ldr      x8, [x0, #0x30]
0053D90B8  ldp      q1, q0, [x0, #0x10]
0053D90BC  ldr      q2, [x0]
0053D90C0  add      x1, sp, #0x40
0053D90C4  str      x8, [sp, #0x30]
0053D90C8  stp      q1, q0, [sp, #0x10]
0053D90CC  str      q2, [sp]
0053D90D0  ldr      x8, [x20, #0x20]
0053D90D4  ldp      q0, q1, [sp]
0053D90D8  ldr      q2, [sp, #0x20]
0053D90DC  ldr      x9, [sp, #0x30]
0053D90E0  ldr      x8, [x8, #0xc0]
0053D90E4  mov      x0, x19
0053D90E8  ldr      x2, [x8, #0x88]
0053D90EC  stp      q0, q1, [sp, #0x40]
0053D90F0  str      q2, [sp, #0x60]
0053D90F4  str      x9, [sp, #0x70]
0053D90F8  bl       #0x53d8420 ; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$Contains
0053D90FC  b        #0x53d9104 ; 
0053D9100  mov      w0, wzr
0053D9104  ldp      x20, x19, [sp, #0x90]
0053D9108  ldp      x30, x21, [sp, #0x80]
0053D910C  and      w0, w0, #1
0053D9110  add      sp, sp, #0xa0
0053D9114  ret      
0053D9118  bl       #0x382bfb8 ; 
0053D911C  bl       #0x382c354 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.IndexOf
; RVA 0x53D9120; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D9120  sub      sp, sp, #0xa0
0053D9124  stp      x30, x21, [sp, #0x80]
0053D9128  stp      x20, x19, [sp, #0x90]
0053D912C  ldr      x8, [x2, #0x20]
0053D9130  mov      x21, x1
0053D9134  mov      x19, x0
0053D9138  mov      x0, x21
0053D913C  ldr      x8, [x8, #0xc0]
0053D9140  mov      x20, x2
0053D9144  ldr      x1, [x8, #0x78]
0053D9148  bl       #0x53d8ff0 ; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$IsCompatibleObject
0053D914C  tbz      w0, #0, #0x53d91dc
0053D9150  ldr      x8, [x20, #0x20]
0053D9154  ldr      x8, [x8, #0xc0]
0053D9158  ldr      x1, [x8, #0x28]
0053D915C  ldrb     w8, [x1, #0x135]
0053D9160  tbnz     w8, #0, #0x53d9170
0053D9164  mov      x0, x1
0053D9168  bl       #0x3a7e60c ; 
0053D916C  mov      x1, x0
0053D9170  cbz      x21, #0x53d91f0
0053D9174  ldr      x8, [x21]
0053D9178  ldr      x9, [x1, #0x40]
0053D917C  mov      x0, x21
0053D9180  ldr      x8, [x8, #0x40]
0053D9184  cmp      x8, x9
0053D9188  b.ne     #0x53d91f4
0053D918C  bl       #0x382be98 ; 
0053D9190  ldr      x8, [x0, #0x30]
0053D9194  ldp      q1, q0, [x0, #0x10]
0053D9198  ldr      q2, [x0]
0053D919C  add      x1, sp, #0x40
0053D91A0  str      x8, [sp, #0x30]
0053D91A4  stp      q1, q0, [sp, #0x10]
0053D91A8  str      q2, [sp]
0053D91AC  ldr      x8, [x20, #0x20]
0053D91B0  ldp      q0, q1, [sp]
0053D91B4  ldr      q2, [sp, #0x20]
0053D91B8  ldr      x9, [sp, #0x30]
0053D91BC  ldr      x8, [x8, #0xc0]
0053D91C0  mov      x0, x19
0053D91C4  ldr      x2, [x8, #0x90]
0053D91C8  stp      q0, q1, [sp, #0x40]
0053D91CC  str      q2, [sp, #0x60]
0053D91D0  str      x9, [sp, #0x70]
0053D91D4  bl       #0x53d8638 ; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$IndexOf
0053D91D8  b        #0x53d91e0 ; 
0053D91DC  mov      w0, #-1
0053D91E0  ldp      x20, x19, [sp, #0x90]
0053D91E4  ldp      x30, x21, [sp, #0x80]
0053D91E8  add      sp, sp, #0xa0
0053D91EC  ret      
0053D91F0  bl       #0x382bfb8 ; 
0053D91F4  bl       #0x382c354 ; 

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.Insert
; RVA 0x53D91F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D91F8  mov      w0, #0x1c
0053D91FC  mov      x1, xzr
0053D9200  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.Remove
; RVA 0x53D9204; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D9204  mov      w0, #0x1c
0053D9208  mov      x1, xzr
0053D920C  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

; System.Collections.ObjectModel.ReadOnlyCollection<WeightRandomData>$$System.Collections.IList.RemoveAt
; RVA 0x53D9210; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0053D9210  mov      w0, #0x1c
0053D9214  mov      x1, xzr
0053D9218  b        #0x7bfe564 ; System.ThrowHelper$$ThrowNotSupportedException

