; System.Collections.Generic.List.Enumerator<WeightRandomData>$$.ctor
; RVA 0x60F8494; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060F8494  str      x30, [sp, #-0x20]!
0060F8498  stp      x20, x19, [sp, #0x10]
0060F849C  mov      x20, x1
0060F84A0  mov      x19, x0
0060F84A4  str      x1, [x0]
0060F84A8  bl       #0x382bcb8 ; 
0060F84AC  str      wzr, [x19, #8]
0060F84B0  cbz      x20, #0x60f84d8
0060F84B4  ldr      w8, [x20, #0x1c]
0060F84B8  movi     v0.2d, #0000000000000000
0060F84BC  stp      q0, q0, [x19, #0x10]
0060F84C0  str      q0, [x19, #0x30]
0060F84C4  str      w8, [x19, #0xc]
0060F84C8  str      xzr, [x19, #0x40]
0060F84CC  ldp      x20, x19, [sp, #0x10]
0060F84D0  ldr      x30, [sp], #0x20
0060F84D4  ret      
0060F84D8  bl       #0x382bfb8 ; 

; System.Collections.Generic.List.Enumerator<WeightRandomData>$$Dispose
; RVA 0x60F84DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060F84DC  ret      

; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
; RVA 0x60F84E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060F84E0  stp      x30, x19, [sp, #-0x10]!
0060F84E4  ldr      x9, [x0]
0060F84E8  cbz      x9, #0x60f8588
0060F84EC  ldr      w8, [x0, #0xc]
0060F84F0  ldr      w10, [x9, #0x1c]
0060F84F4  mov      x19, x0
0060F84F8  cmp      w8, w10
0060F84FC  b.ne     #0x60f8564
0060F8500  ldrsw    x8, [x19, #8]
0060F8504  ldr      w10, [x9, #0x18]
0060F8508  cmp      w8, w10
0060F850C  b.hs     #0x60f8564
0060F8510  ldr      x9, [x9, #0x10]
0060F8514  cbz      x9, #0x60f8588
0060F8518  ldr      w10, [x9, #0x18]
0060F851C  cmp      w8, w10
0060F8520  b.hs     #0x60f858c
0060F8524  mov      w10, #0x38
0060F8528  madd     x8, x8, x10, x9
0060F852C  ldr      x9, [x8, #0x50]
0060F8530  ldp      q1, q0, [x8, #0x30]
0060F8534  ldr      q2, [x8, #0x20]
0060F8538  add      x0, x19, #0x20
0060F853C  mov      x1, xzr
0060F8540  str      x9, [x19, #0x40]
0060F8544  stp      q1, q0, [x19, #0x20]
0060F8548  str      q2, [x19, #0x10]
0060F854C  bl       #0x382bcb8 ; 
0060F8550  ldr      w8, [x19, #8]
0060F8554  mov      w0, #1
0060F8558  add      w8, w8, #1
0060F855C  str      w8, [x19, #8]
0060F8560  b        #0x60f8580 ; 
0060F8564  ldr      x0, [x1, #0x20]
0060F8568  ldrb     w8, [x0, #0x135]
0060F856C  tbnz     w8, #0, #0x60f8574
0060F8570  bl       #0x3a7e60c ; 
0060F8574  mov      x0, x19
0060F8578  bl       #0x60f8590 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNextRare
0060F857C  mov      w0, wzr
0060F8580  ldp      x30, x19, [sp], #0x10
0060F8584  ret      
0060F8588  bl       #0x382bfb8 ; 
0060F858C  bl       #0x382bfc0 ; 

; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNextRare
; RVA 0x60F8590; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060F8590  stp      x30, x19, [sp, #-0x10]!
0060F8594  ldr      x8, [x0]
0060F8598  cbz      x8, #0x60f85e8
0060F859C  ldr      w9, [x0, #0xc]
0060F85A0  ldr      w10, [x8, #0x1c]
0060F85A4  mov      x19, x0
0060F85A8  cmp      w9, w10
0060F85AC  b.eq     #0x60f85c0
0060F85B0  mov      x0, xzr
0060F85B4  bl       #0x7bfe5b4 ; System.ThrowHelper$$ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion
0060F85B8  ldr      x8, [x19]
0060F85BC  cbz      x8, #0x60f85e8
0060F85C0  ldr      w8, [x8, #0x18]
0060F85C4  movi     v0.2d, #0000000000000000
0060F85C8  stp      q0, q0, [x19, #0x10]
0060F85CC  str      q0, [x19, #0x30]
0060F85D0  add      w8, w8, #1
0060F85D4  str      w8, [x19, #8]
0060F85D8  str      xzr, [x19, #0x40]
0060F85DC  mov      w0, wzr
0060F85E0  ldp      x30, x19, [sp], #0x10
0060F85E4  ret      
0060F85E8  bl       #0x382bfb8 ; 

; System.Collections.Generic.List.Enumerator<WeightRandomData>$$get_Current
; RVA 0x60F85EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060F85EC  ldr      x9, [x0, #0x40]
0060F85F0  ldp      q1, q0, [x0, #0x20]
0060F85F4  ldr      q2, [x0, #0x10]
0060F85F8  str      x9, [x8, #0x30]
0060F85FC  stp      q1, q0, [x8, #0x10]
0060F8600  str      q2, [x8]
0060F8604  ret      

; System.Collections.Generic.List.Enumerator<WeightRandomData>$$System.Collections.IEnumerator.get_Current
; RVA 0x60F8608; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060F8608  sub      sp, sp, #0x60
0060F860C  str      x30, [sp, #0x40]
0060F8610  stp      x20, x19, [sp, #0x50]
0060F8614  ldr      w8, [x0, #8]
0060F8618  mov      x19, x0
0060F861C  mov      x20, x1
0060F8620  cbz      w8, #0x60f863c
0060F8624  ldr      x9, [x19]
0060F8628  cbz      x9, #0x60f86a4
0060F862C  ldr      w9, [x9, #0x18]
0060F8630  add      w9, w9, #1
0060F8634  cmp      w8, w9
0060F8638  b.ne     #0x60f8644
0060F863C  mov      x0, xzr
0060F8640  bl       #0x7bfe600 ; System.ThrowHelper$$ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen
0060F8644  ldr      x0, [x20, #0x20]
0060F8648  add      x8, x0, #0x135
0060F864C  ldrh     w8, [x8]
0060F8650  tbnz     w8, #0, #0x60f8664
0060F8654  bl       #0x3a7e60c ; 
0060F8658  ldr      x0, [x20, #0x20]
0060F865C  add      x8, x0, #0x135
0060F8660  ldrh     w8, [x8]
0060F8664  ldr      x9, [x19, #0x40]
0060F8668  ldp      q1, q0, [x19, #0x20]
0060F866C  ldr      q2, [x19, #0x10]
0060F8670  str      x9, [sp, #0x30]
0060F8674  stp      q1, q0, [sp, #0x10]
0060F8678  str      q2, [sp]
0060F867C  tbnz     w8, #0, #0x60f8684
0060F8680  bl       #0x3a7e60c ; 
0060F8684  ldr      x8, [x0, #0xc0]
0060F8688  mov      x1, sp
0060F868C  ldr      x0, [x8, #0x10]
0060F8690  bl       #0x382be94 ; 
0060F8694  ldp      x20, x19, [sp, #0x50]
0060F8698  ldr      x30, [sp, #0x40]
0060F869C  add      sp, sp, #0x60
0060F86A0  ret      
0060F86A4  bl       #0x382bfb8 ; 

; System.Collections.Generic.List.Enumerator<WeightRandomData>$$System.Collections.IEnumerator.Reset
; RVA 0x60F86A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060F86A8  stp      x30, x19, [sp, #-0x10]!
0060F86AC  ldr      x8, [x0]
0060F86B0  cbz      x8, #0x60f86ec
0060F86B4  ldr      w9, [x0, #0xc]
0060F86B8  ldr      w8, [x8, #0x1c]
0060F86BC  mov      x19, x0
0060F86C0  cmp      w9, w8
0060F86C4  b.eq     #0x60f86d0
0060F86C8  mov      x0, xzr
0060F86CC  bl       #0x7bfe5b4 ; System.ThrowHelper$$ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion
0060F86D0  movi     v0.2d, #0000000000000000
0060F86D4  str      wzr, [x19, #8]
0060F86D8  stp      q0, q0, [x19, #0x10]
0060F86DC  str      q0, [x19, #0x30]
0060F86E0  str      xzr, [x19, #0x40]
0060F86E4  ldp      x30, x19, [sp], #0x10
0060F86E8  ret      
0060F86EC  bl       #0x382bfb8 ; 

