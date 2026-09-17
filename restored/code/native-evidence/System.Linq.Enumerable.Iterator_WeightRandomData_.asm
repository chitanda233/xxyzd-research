; System.Linq.Enumerable.Iterator<WeightRandomData>$$.ctor
; RVA 0x4A752C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A752C8  stp      x30, x19, [sp, #-0x10]!
004A752CC  mov      x1, xzr
004A752D0  mov      x19, x0
004A752D4  bl       #0x7c335dc ; System.Object$$.ctor
004A752D8  mov      x0, xzr
004A752DC  bl       #0x7c57364 ; System.Threading.Thread$$get_CurrentThread
004A752E0  cbz      x0, #0x4a752f8
004A752E4  mov      x1, xzr
004A752E8  bl       #0x7c573c0 ; System.Threading.Thread$$get_ManagedThreadId
004A752EC  str      w0, [x19, #0x10]
004A752F0  ldp      x30, x19, [sp], #0x10
004A752F4  ret      
004A752F8  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.Iterator<WeightRandomData>$$get_Current
; RVA 0x4A752FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A752FC  ldr      x9, [x0, #0x48]
004A75300  ldur     q0, [x0, #0x38]
004A75304  ldur     q1, [x0, #0x28]
004A75308  ldur     q2, [x0, #0x18]
004A7530C  str      x9, [x8, #0x30]
004A75310  stp      q1, q0, [x8, #0x10]
004A75314  str      q2, [x8]
004A75318  ret      

; System.Linq.Enumerable.Iterator<WeightRandomData>$$Dispose
; RVA 0x4A7531C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A7531C  movi     v0.2d, #0000000000000000
004A75320  mov      w8, #-1
004A75324  str      xzr, [x0, #0x48]
004A75328  stur     q0, [x0, #0x38]
004A7532C  stur     q0, [x0, #0x28]
004A75330  stur     q0, [x0, #0x18]
004A75334  str      w8, [x0, #0x14]
004A75338  ret      

; System.Linq.Enumerable.Iterator<WeightRandomData>$$GetEnumerator
; RVA 0x4A7533C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A7533C  str      x30, [sp, #-0x20]!
004A75340  stp      x20, x19, [sp, #0x10]
004A75344  ldr      w20, [x0, #0x10]
004A75348  mov      x19, x0
004A7534C  mov      x0, xzr
004A75350  bl       #0x7c57364 ; System.Threading.Thread$$get_CurrentThread
004A75354  cbz      x0, #0x4a753a0
004A75358  mov      x1, xzr
004A7535C  bl       #0x7c573c0 ; System.Threading.Thread$$get_ManagedThreadId
004A75360  cmp      w20, w0
004A75364  b.ne     #0x4a75370
004A75368  ldr      w8, [x19, #0x14]
004A7536C  cbz      w8, #0x4a75388
004A75370  ldr      x8, [x19]
004A75374  mov      x0, x19
004A75378  ldp      x9, x1, [x8, #0x1e8]
004A7537C  blr      x9
004A75380  cbz      x0, #0x4a753a0
004A75384  mov      x19, x0
004A75388  mov      w8, #1
004A7538C  str      w8, [x19, #0x14]
004A75390  mov      x0, x19
004A75394  ldp      x20, x19, [sp, #0x10]
004A75398  ldr      x30, [sp], #0x20
004A7539C  ret      
004A753A0  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.Iterator<WeightRandomData>$$System.Collections.IEnumerator.get_Current
; RVA 0x4A753A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A753A4  sub      sp, sp, #0x50
004A753A8  str      x30, [sp, #0x40]
004A753AC  ldr      x8, [x1, #0x20]
004A753B0  ldur     q0, [x0, #0x18]
004A753B4  ldr      x9, [x0, #0x48]
004A753B8  ldur     q1, [x0, #0x38]
004A753BC  ldur     q2, [x0, #0x28]
004A753C0  ldr      x8, [x8, #0xc0]
004A753C4  str      x9, [sp, #0x30]
004A753C8  str      q0, [sp]
004A753CC  stp      q2, q1, [sp, #0x10]
004A753D0  ldr      x0, [x8, #8]
004A753D4  mov      x1, sp
004A753D8  bl       #0x382be94 ; 
004A753DC  ldr      x30, [sp, #0x40]
004A753E0  add      sp, sp, #0x50
004A753E4  ret      

; System.Linq.Enumerable.Iterator<WeightRandomData>$$System.Collections.IEnumerable.GetEnumerator
; RVA 0x4A753E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A753E8  b        #0x4a7533c ; System.Linq.Enumerable.Iterator<WeightRandomData>$$GetEnumerator

; System.Linq.Enumerable.Iterator<WeightRandomData>$$System.Collections.IEnumerator.Reset
; RVA 0x4A753EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A753EC  str      x30, [sp, #-0x20]!
004A753F0  stp      x20, x19, [sp, #0x10]
004A753F4  adrp     x0, #0x8ec2000
004A753F8  ldr      x0, [x0, #0xd78]
004A753FC  mov      x19, x1
004A75400  bl       #0x382bd28 ; 
004A75404  bl       #0x382bfa0 ; 
004A75408  mov      x1, xzr
004A7540C  mov      x20, x0
004A75410  bl       #0x7bd9630 ; System.NotImplementedException$$.ctor
004A75414  mov      x0, x20
004A75418  mov      x1, x19
004A7541C  bl       #0x382be7c ; 

