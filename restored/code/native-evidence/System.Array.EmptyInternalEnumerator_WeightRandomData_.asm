; System.Array.EmptyInternalEnumerator<WeightRandomData>$$Dispose
; RVA 0x609ED60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00609ED60  ret      

; System.Array.EmptyInternalEnumerator<WeightRandomData>$$MoveNext
; RVA 0x609ED64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00609ED64  mov      w0, wzr
00609ED68  ret      

; System.Array.EmptyInternalEnumerator<WeightRandomData>$$get_Current
; RVA 0x609ED6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00609ED6C  str      x30, [sp, #-0x20]!
00609ED70  stp      x20, x19, [sp, #0x10]
00609ED74  adrp     x0, #0x8ec3000
00609ED78  ldr      x0, [x0, #0x760]
00609ED7C  mov      x19, x1
00609ED80  bl       #0x382bd28 ; 
00609ED84  bl       #0x382bfa0 ; 
00609ED88  mov      x20, x0
00609ED8C  adrp     x0, #0x8ee8000
00609ED90  ldr      x0, [x0, #0x670]
00609ED94  bl       #0x382bd28 ; 
00609ED98  mov      x1, x0
00609ED9C  mov      x0, x20
00609EDA0  mov      x2, xzr
00609EDA4  bl       #0x7bd4cd8 ; System.InvalidOperationException$$.ctor
00609EDA8  mov      x0, x20
00609EDAC  mov      x1, x19
00609EDB0  bl       #0x382be7c ; 

; System.Array.EmptyInternalEnumerator<WeightRandomData>$$System.Collections.IEnumerator.get_Current
; RVA 0x609EDB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00609EDB4  str      x30, [sp, #-0x10]!
00609EDB8  ldr      x8, [x1, #0x20]
00609EDBC  ldr      x8, [x8, #0xc0]
00609EDC0  ldr      x1, [x8, #8]
00609EDC4  bl       #0x609ed6c ; System.Array.EmptyInternalEnumerator<WeightRandomData>$$get_Current

; System.Array.EmptyInternalEnumerator<WeightRandomData>$$System.Collections.IEnumerator.Reset
; RVA 0x609EDC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00609EDC8  ret      

; System.Array.EmptyInternalEnumerator<WeightRandomData>$$.ctor
; RVA 0x609EDCC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00609EDCC  mov      x1, xzr
00609EDD0  b        #0x7c335dc ; System.Object$$.ctor

; System.Array.EmptyInternalEnumerator<WeightRandomData>$$.cctor
; RVA 0x609EDD4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00609EDD4  str      x30, [sp, #-0x20]!
00609EDD8  stp      x20, x19, [sp, #0x10]
00609EDDC  mov      x19, x0
00609EDE0  ldr      x0, [x0, #0x20]
00609EDE4  ldrb     w8, [x0, #0x135]
00609EDE8  tbnz     w8, #0, #0x609edf0
00609EDEC  bl       #0x3a7e60c ; 
00609EDF0  ldr      x8, [x0, #0xc0]
00609EDF4  ldr      x0, [x8, #0x10]
00609EDF8  ldrb     w8, [x0, #0x135]
00609EDFC  tbnz     w8, #0, #0x609ee04
00609EE00  bl       #0x3a7e60c ; 
00609EE04  bl       #0x382bfa0 ; 
00609EE08  ldr      x8, [x19, #0x20]
00609EE0C  mov      x20, x0
00609EE10  ldrb     w9, [x8, #0x135]
00609EE14  tbnz     w9, #0, #0x609ee20
00609EE18  mov      x0, x8
00609EE1C  bl       #0x3a7e60c ; 
00609EE20  mov      x0, x20
00609EE24  mov      x1, xzr
00609EE28  bl       #0x7c335dc ; System.Object$$.ctor
00609EE2C  ldr      x0, [x19, #0x20]
00609EE30  ldrb     w8, [x0, #0x135]
00609EE34  tbnz     w8, #0, #0x609ee3c
00609EE38  bl       #0x3a7e60c ; 
00609EE3C  ldr      x8, [x0, #0xc0]
00609EE40  ldr      x0, [x8, #0x20]
00609EE44  ldrb     w8, [x0, #0x135]
00609EE48  tbnz     w8, #0, #0x609ee50
00609EE4C  bl       #0x3a7e60c ; 
00609EE50  ldr      x8, [x0, #0xb8]
00609EE54  str      x20, [x8]
00609EE58  ldr      x0, [x19, #0x20]
00609EE5C  ldrb     w8, [x0, #0x135]
00609EE60  tbnz     w8, #0, #0x609ee68
00609EE64  bl       #0x3a7e60c ; 
00609EE68  ldr      x8, [x0, #0xc0]
00609EE6C  ldr      x0, [x8, #0x20]
00609EE70  ldrb     w8, [x0, #0x135]
00609EE74  tbnz     w8, #0, #0x609ee7c
00609EE78  bl       #0x3a7e60c ; 
00609EE7C  ldr      x0, [x0, #0xb8]
00609EE80  mov      x1, x20
00609EE84  ldp      x20, x19, [sp, #0x10]
00609EE88  ldr      x30, [sp], #0x20
00609EE8C  b        #0x382bcb8 ; 

