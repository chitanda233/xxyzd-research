; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
; RVA 0x5A0C5A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C5A8  str      x30, [sp, #-0x30]!
005A0C5AC  stp      x22, x21, [sp, #0x10]
005A0C5B0  stp      x20, x19, [sp, #0x20]
005A0C5B4  ldr      x8, [x4, #0x20]
005A0C5B8  mov      x21, x1
005A0C5BC  mov      x19, x3
005A0C5C0  mov      x20, x2
005A0C5C4  ldr      x8, [x8, #0xc0]
005A0C5C8  mov      x22, x0
005A0C5CC  ldr      x1, [x8]
005A0C5D0  bl       #0x4a73758 ; System.Linq.Enumerable.Iterator<CalCollectionTreasureData>$$.ctor
005A0C5D4  mov      x0, x22
005A0C5D8  str      x21, [x0, #0x20]!
005A0C5DC  mov      x1, x21
005A0C5E0  bl       #0x382bcb8 ; 
005A0C5E4  mov      x0, x22
005A0C5E8  str      x20, [x0, #0x28]!
005A0C5EC  mov      x1, x20
005A0C5F0  bl       #0x382bcb8 ; 
005A0C5F4  str      x19, [x22, #0x30]!
005A0C5F8  mov      x0, x22
005A0C5FC  mov      x1, x19
005A0C600  ldp      x20, x19, [sp, #0x20]
005A0C604  ldp      x22, x21, [sp, #0x10]
005A0C608  ldr      x30, [sp], #0x30
005A0C60C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalCollectionTreasureData>$$Clone
; RVA 0x5A0C610; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C610  str      x30, [sp, #-0x30]!
005A0C614  stp      x22, x21, [sp, #0x10]
005A0C618  stp      x20, x19, [sp, #0x20]
005A0C61C  ldr      x9, [x1, #0x20]
005A0C620  mov      x8, x0
005A0C624  ldp      x21, x20, [x8, #0x20]
005A0C628  ldr      x22, [x8, #0x30]
005A0C62C  ldr      x9, [x9, #0xc0]
005A0C630  mov      x19, x1
005A0C634  ldr      x0, [x9, #0x18]
005A0C638  ldrb     w9, [x0, #0x135]
005A0C63C  tbnz     w9, #0, #0x5a0c644
005A0C640  bl       #0x3a7e60c ; 
005A0C644  bl       #0x382bfa0 ; 
005A0C648  ldr      x8, [x19, #0x20]
005A0C64C  mov      x1, x21
005A0C650  mov      x2, x20
005A0C654  mov      x3, x22
005A0C658  ldr      x8, [x8, #0xc0]
005A0C65C  mov      x19, x0
005A0C660  ldr      x4, [x8, #0x30]
005A0C664  bl       #0x5a0c5a8 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
005A0C668  mov      x0, x19
005A0C66C  ldp      x20, x19, [sp, #0x20]
005A0C670  ldp      x22, x21, [sp, #0x10]
005A0C674  ldr      x30, [sp], #0x30
005A0C678  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalCollectionTreasureData>$$MoveNext
; RVA 0x5A0C67C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C67C  sub      sp, sp, #0xe0
005A0C680  str      x30, [sp, #0xc0]
005A0C684  stp      x20, x19, [sp, #0xd0]
005A0C688  ldr      w8, [x0, #0x14]
005A0C68C  cmp      w8, #1
005A0C690  b.ne     #0x5a0c780
005A0C694  mov      x19, x0
005A0C698  mov      w20, #0x38
005A0C69C  ldr      x9, [x19, #0x20]
005A0C6A0  cbz      x9, #0x5a0c798
005A0C6A4  ldrsw    x8, [x19, #0x38]
005A0C6A8  ldr      w10, [x9, #0x18]
005A0C6AC  cmp      w8, w10
005A0C6B0  b.ge     #0x5a0c770
005A0C6B4  cmp      w8, w10
005A0C6B8  b.hs     #0x5a0c794
005A0C6BC  madd     x9, x8, x20, x9
005A0C6C0  ldr      x10, [x9, #0x50]
005A0C6C4  ldp      q1, q0, [x9, #0x30]
005A0C6C8  ldr      q2, [x9, #0x20]
005A0C6CC  add      w8, w8, #1
005A0C6D0  str      x10, [sp, #0x70]
005A0C6D4  stp      q1, q0, [sp, #0x50]
005A0C6D8  str      q2, [sp, #0x40]
005A0C6DC  ldr      x9, [x19, #0x28]
005A0C6E0  str      w8, [x19, #0x38]
005A0C6E4  cbz      x9, #0x5a0c718
005A0C6E8  ldp      q0, q1, [sp, #0x40]
005A0C6EC  ldr      q2, [sp, #0x60]
005A0C6F0  ldr      x10, [sp, #0x70]
005A0C6F4  ldr      x8, [x9, #0x18]
005A0C6F8  ldr      x0, [x9, #0x40]
005A0C6FC  stp      q0, q1, [sp, #0x80]
005A0C700  str      q2, [sp, #0xa0]
005A0C704  str      x10, [sp, #0xb0]
005A0C708  ldr      x2, [x9, #0x28]
005A0C70C  add      x1, sp, #0x80
005A0C710  blr      x8
005A0C714  tbz      w0, #0, #0x5a0c69c
005A0C718  ldr      x8, [x19, #0x30]
005A0C71C  ldp      q0, q1, [sp, #0x40]
005A0C720  ldr      q2, [sp, #0x60]
005A0C724  ldr      x9, [sp, #0x70]
005A0C728  stp      q0, q1, [sp]
005A0C72C  str      q2, [sp, #0x20]
005A0C730  str      x9, [sp, #0x30]
005A0C734  cbz      x8, #0x5a0c798
005A0C738  ldp      q0, q1, [sp]
005A0C73C  ldr      q2, [sp, #0x20]
005A0C740  ldr      x10, [sp, #0x30]
005A0C744  ldr      x9, [x8, #0x18]
005A0C748  ldr      x0, [x8, #0x40]
005A0C74C  stp      q0, q1, [sp, #0x80]
005A0C750  str      q2, [sp, #0xa0]
005A0C754  str      x10, [sp, #0xb0]
005A0C758  ldr      x2, [x8, #0x28]
005A0C75C  add      x1, sp, #0x80
005A0C760  blr      x9
005A0C764  str      x0, [x19, #0x18]
005A0C768  mov      w0, #1
005A0C76C  b        #0x5a0c784 ; 
005A0C770  ldr      x8, [x19]
005A0C774  mov      x0, x19
005A0C778  ldp      x9, x1, [x8, #0x1f8]
005A0C77C  blr      x9
005A0C780  mov      w0, wzr
005A0C784  ldp      x20, x19, [sp, #0xd0]
005A0C788  ldr      x30, [sp, #0xc0]
005A0C78C  add      sp, sp, #0xe0
005A0C790  ret      
005A0C794  bl       #0x382bfc0 ; 
005A0C798  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalCollectionTreasureData>$$Where
; RVA 0x5A0C79C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C79C  stp      x30, x21, [sp, #-0x20]!
005A0C7A0  stp      x20, x19, [sp, #0x10]
005A0C7A4  ldr      x8, [x2, #0x20]
005A0C7A8  mov      x20, x2
005A0C7AC  mov      x19, x1
005A0C7B0  mov      x21, x0
005A0C7B4  ldr      x8, [x8, #0xc0]
005A0C7B8  ldr      x8, [x8, #0x70]
005A0C7BC  ldrb     w9, [x8, #0x135]
005A0C7C0  tbnz     w9, #0, #0x5a0c7d0
005A0C7C4  mov      x0, x8
005A0C7C8  bl       #0x3a7e60c ; 
005A0C7CC  mov      x8, x0
005A0C7D0  mov      x0, x8
005A0C7D4  bl       #0x382bfa0 ; 
005A0C7D8  ldr      x8, [x20, #0x20]
005A0C7DC  mov      x1, x21
005A0C7E0  mov      x2, x19
005A0C7E4  mov      x20, x0
005A0C7E8  ldr      x8, [x8, #0xc0]
005A0C7EC  ldr      x3, [x8, #0x78]
005A0C7F0  bl       #0x59c70e0 ; System.Linq.Enumerable.WhereEnumerableIterator<CalCollectionTreasureData>$$.ctor
005A0C7F4  mov      x0, x20
005A0C7F8  ldp      x20, x19, [sp, #0x10]
005A0C7FC  ldp      x30, x21, [sp], #0x20
005A0C800  ret      

