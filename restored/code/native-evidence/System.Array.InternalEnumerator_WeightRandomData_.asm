; System.Array.InternalEnumerator<WeightRandomData>$$.ctor
; RVA 0x4A38244; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A38244  stp      x30, x19, [sp, #-0x10]!
004A38248  mov      x19, x0
004A3824C  str      x1, [x0]
004A38250  bl       #0x382bcb8 ; 
004A38254  mov      w8, #-2
004A38258  str      w8, [x19, #8]
004A3825C  ldp      x30, x19, [sp], #0x10
004A38260  ret      

; System.Array.InternalEnumerator<WeightRandomData>$$Dispose
; RVA 0x4A38264; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A38264  ret      

; System.Array.InternalEnumerator<WeightRandomData>$$MoveNext
; RVA 0x4A38268; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A38268  stp      x30, x19, [sp, #-0x10]!
004A3826C  mov      x19, x0
004A38270  ldr      w0, [x0, #8]
004A38274  cmn      w0, #2
004A38278  b.ne     #0x4a38290
004A3827C  ldr      x0, [x19]
004A38280  cbz      x0, #0x4a382b4
004A38284  mov      x1, xzr
004A38288  bl       #0x7bffd60 ; System.Array$$get_Length
004A3828C  str      w0, [x19, #8]
004A38290  cmn      w0, #1
004A38294  b.eq     #0x4a382a8
004A38298  subs     w8, w0, #1
004A3829C  cset     w0, hs
004A382A0  str      w8, [x19, #8]
004A382A4  b        #0x4a382ac ; 
004A382A8  mov      w0, wzr
004A382AC  ldp      x30, x19, [sp], #0x10
004A382B0  ret      
004A382B4  bl       #0x382bfb8 ; 

; System.Array.InternalEnumerator<WeightRandomData>$$get_Current
; RVA 0x4A382B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A382B8  sub      sp, sp, #0x70
004A382BC  str      x30, [sp, #0x40]
004A382C0  stp      x22, x21, [sp, #0x50]
004A382C4  stp      x20, x19, [sp, #0x60]
004A382C8  ldr      w9, [x0, #8]
004A382CC  mov      x19, x1
004A382D0  cmn      w9, #1
004A382D4  b.eq     #0x4a38364
004A382D8  cmn      w9, #2
004A382DC  b.eq     #0x4a38384
004A382E0  ldr      x21, [x0]
004A382E4  mov      x22, x0
004A382E8  cbz      x21, #0x4a383c0
004A382EC  mov      x0, x21
004A382F0  mov      x1, xzr
004A382F4  mov      x20, x8
004A382F8  bl       #0x7bffd60 ; System.Array$$get_Length
004A382FC  ldr      x8, [x19, #0x20]
004A38300  ldr      w22, [x22, #8]
004A38304  mov      w19, w0
004A38308  ldrb     w9, [x8, #0x135]
004A3830C  tbnz     w9, #0, #0x4a3831c
004A38310  mov      x0, x8
004A38314  bl       #0x3a7e60c ; 
004A38318  mov      x8, x0
004A3831C  ldr      x8, [x8, #0xc0]
004A38320  mov      x0, x21
004A38324  ldr      x2, [x8, #8]
004A38328  mvn      w8, w22
004A3832C  add      w1, w19, w8
004A38330  add      x8, sp, #8
004A38334  bl       #0x43dbdf0 ; System.Array$$InternalArray__get_Item<WeightRandomData>
004A38338  ldp      x8, x30, [sp, #0x38]
004A3833C  ldur     q0, [sp, #0x28]
004A38340  ldur     q1, [sp, #0x18]
004A38344  ldur     q2, [sp, #8]
004A38348  str      x8, [x20, #0x30]
004A3834C  ldp      x22, x21, [sp, #0x50]
004A38350  stp      q1, q0, [x20, #0x10]
004A38354  str      q2, [x20]
004A38358  ldp      x20, x19, [sp, #0x60]
004A3835C  add      sp, sp, #0x70
004A38360  ret      
004A38364  adrp     x0, #0x8ec3000
004A38368  ldr      x0, [x0, #0x760]
004A3836C  bl       #0x382bd28 ; 
004A38370  bl       #0x382bfa0 ; 
004A38374  mov      x20, x0
004A38378  adrp     x0, #0x8ee8000
004A3837C  ldr      x0, [x0, #0x668]
004A38380  b        #0x4a383a0 ; 
004A38384  adrp     x0, #0x8ec3000
004A38388  ldr      x0, [x0, #0x760]
004A3838C  bl       #0x382bd28 ; 
004A38390  bl       #0x382bfa0 ; 
004A38394  mov      x20, x0
004A38398  adrp     x0, #0x8ee8000
004A3839C  ldr      x0, [x0, #0x670]
004A383A0  bl       #0x382bd28 ; 
004A383A4  mov      x1, x0
004A383A8  mov      x0, x20
004A383AC  mov      x2, xzr
004A383B0  bl       #0x7bd4cd8 ; System.InvalidOperationException$$.ctor
004A383B4  mov      x0, x20
004A383B8  mov      x1, x19
004A383BC  bl       #0x382be7c ; 
004A383C0  bl       #0x382bfb8 ; 

; System.Array.InternalEnumerator<WeightRandomData>$$System.Collections.IEnumerator.Reset
; RVA 0x4A383C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A383C4  mov      w8, #-2
004A383C8  str      w8, [x0, #8]
004A383CC  ret      

; System.Array.InternalEnumerator<WeightRandomData>$$System.Collections.IEnumerator.get_Current
; RVA 0x4A383D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A383D0  sub      sp, sp, #0x90
004A383D4  str      x30, [sp, #0x70]
004A383D8  stp      x20, x19, [sp, #0x80]
004A383DC  ldr      x8, [x1, #0x20]
004A383E0  mov      x19, x1
004A383E4  mov      x20, x0
004A383E8  ldrb     w9, [x8, #0x135]
004A383EC  tbnz     w9, #0, #0x4a383fc
004A383F0  mov      x0, x8
004A383F4  bl       #0x3a7e60c ; 
004A383F8  mov      x8, x0
004A383FC  ldr      x8, [x8, #0xc0]
004A38400  mov      x0, x20
004A38404  ldr      x1, [x8, #0x18]
004A38408  add      x8, sp, #0x38
004A3840C  bl       #0x4a382b8 ; System.Array.InternalEnumerator<WeightRandomData>$$get_Current
004A38410  ldr      x8, [sp, #0x68]
004A38414  ldur     q0, [sp, #0x58]
004A38418  ldur     q1, [sp, #0x48]
004A3841C  ldur     q2, [sp, #0x38]
004A38420  str      x8, [sp, #0x30]
004A38424  stp      q1, q0, [sp, #0x10]
004A38428  str      q2, [sp]
004A3842C  ldr      x0, [x19, #0x20]
004A38430  ldrb     w8, [x0, #0x135]
004A38434  tbnz     w8, #0, #0x4a3843c
004A38438  bl       #0x3a7e60c ; 
004A3843C  ldr      x8, [x0, #0xc0]
004A38440  mov      x1, sp
004A38444  ldr      x0, [x8, #0x10]
004A38448  bl       #0x382be94 ; 
004A3844C  ldp      x20, x19, [sp, #0x80]
004A38450  ldr      x30, [sp, #0x70]
004A38454  add      sp, sp, #0x90
004A38458  ret      

