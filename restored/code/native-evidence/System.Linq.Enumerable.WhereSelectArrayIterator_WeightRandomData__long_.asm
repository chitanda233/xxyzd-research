; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, long>$$.ctor
; RVA 0x5A0D654; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D654  str      x30, [sp, #-0x30]!
005A0D658  stp      x22, x21, [sp, #0x10]
005A0D65C  stp      x20, x19, [sp, #0x20]
005A0D660  ldr      x8, [x4, #0x20]
005A0D664  mov      x21, x1
005A0D668  mov      x19, x3
005A0D66C  mov      x20, x2
005A0D670  ldr      x8, [x8, #0xc0]
005A0D674  mov      x22, x0
005A0D678  ldr      x1, [x8]
005A0D67C  bl       #0x4a745f4 ; System.Linq.Enumerable.Iterator<long>$$.ctor
005A0D680  mov      x0, x22
005A0D684  str      x21, [x0, #0x20]!
005A0D688  mov      x1, x21
005A0D68C  bl       #0x382bcb8 ; 
005A0D690  mov      x0, x22
005A0D694  str      x20, [x0, #0x28]!
005A0D698  mov      x1, x20
005A0D69C  bl       #0x382bcb8 ; 
005A0D6A0  str      x19, [x22, #0x30]!
005A0D6A4  mov      x0, x22
005A0D6A8  mov      x1, x19
005A0D6AC  ldp      x20, x19, [sp, #0x20]
005A0D6B0  ldp      x22, x21, [sp, #0x10]
005A0D6B4  ldr      x30, [sp], #0x30
005A0D6B8  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, long>$$Clone
; RVA 0x5A0D6BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D6BC  str      x30, [sp, #-0x30]!
005A0D6C0  stp      x22, x21, [sp, #0x10]
005A0D6C4  stp      x20, x19, [sp, #0x20]
005A0D6C8  ldr      x9, [x1, #0x20]
005A0D6CC  mov      x8, x0
005A0D6D0  ldp      x21, x20, [x8, #0x20]
005A0D6D4  ldr      x22, [x8, #0x30]
005A0D6D8  ldr      x9, [x9, #0xc0]
005A0D6DC  mov      x19, x1
005A0D6E0  ldr      x0, [x9, #0x18]
005A0D6E4  ldrb     w9, [x0, #0x135]
005A0D6E8  tbnz     w9, #0, #0x5a0d6f0
005A0D6EC  bl       #0x3a7e60c ; 
005A0D6F0  bl       #0x382bfa0 ; 
005A0D6F4  ldr      x8, [x19, #0x20]
005A0D6F8  mov      x1, x21
005A0D6FC  mov      x2, x20
005A0D700  mov      x3, x22
005A0D704  ldr      x8, [x8, #0xc0]
005A0D708  mov      x19, x0
005A0D70C  ldr      x4, [x8, #0x30]
005A0D710  bl       #0x5a0d654 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, long>$$.ctor
005A0D714  mov      x0, x19
005A0D718  ldp      x20, x19, [sp, #0x20]
005A0D71C  ldp      x22, x21, [sp, #0x10]
005A0D720  ldr      x30, [sp], #0x30
005A0D724  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, long>$$MoveNext
; RVA 0x5A0D728; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D728  sub      sp, sp, #0xe0
005A0D72C  str      x30, [sp, #0xc0]
005A0D730  stp      x20, x19, [sp, #0xd0]
005A0D734  ldr      w8, [x0, #0x14]
005A0D738  cmp      w8, #1
005A0D73C  b.ne     #0x5a0d82c
005A0D740  mov      x19, x0
005A0D744  mov      w20, #0x38
005A0D748  ldr      x9, [x19, #0x20]
005A0D74C  cbz      x9, #0x5a0d844
005A0D750  ldrsw    x8, [x19, #0x38]
005A0D754  ldr      w10, [x9, #0x18]
005A0D758  cmp      w8, w10
005A0D75C  b.ge     #0x5a0d81c
005A0D760  cmp      w8, w10
005A0D764  b.hs     #0x5a0d840
005A0D768  madd     x9, x8, x20, x9
005A0D76C  ldr      x10, [x9, #0x50]
005A0D770  ldp      q1, q0, [x9, #0x30]
005A0D774  ldr      q2, [x9, #0x20]
005A0D778  add      w8, w8, #1
005A0D77C  str      x10, [sp, #0x70]
005A0D780  stp      q1, q0, [sp, #0x50]
005A0D784  str      q2, [sp, #0x40]
005A0D788  ldr      x9, [x19, #0x28]
005A0D78C  str      w8, [x19, #0x38]
005A0D790  cbz      x9, #0x5a0d7c4
005A0D794  ldp      q0, q1, [sp, #0x40]
005A0D798  ldr      q2, [sp, #0x60]
005A0D79C  ldr      x10, [sp, #0x70]
005A0D7A0  ldr      x8, [x9, #0x18]
005A0D7A4  ldr      x0, [x9, #0x40]
005A0D7A8  stp      q0, q1, [sp, #0x80]
005A0D7AC  str      q2, [sp, #0xa0]
005A0D7B0  str      x10, [sp, #0xb0]
005A0D7B4  ldr      x2, [x9, #0x28]
005A0D7B8  add      x1, sp, #0x80
005A0D7BC  blr      x8
005A0D7C0  tbz      w0, #0, #0x5a0d748
005A0D7C4  ldr      x8, [x19, #0x30]
005A0D7C8  ldp      q0, q1, [sp, #0x40]
005A0D7CC  ldr      q2, [sp, #0x60]
005A0D7D0  ldr      x9, [sp, #0x70]
005A0D7D4  stp      q0, q1, [sp]
005A0D7D8  str      q2, [sp, #0x20]
005A0D7DC  str      x9, [sp, #0x30]
005A0D7E0  cbz      x8, #0x5a0d844
005A0D7E4  ldp      q0, q1, [sp]
005A0D7E8  ldr      q2, [sp, #0x20]
005A0D7EC  ldr      x10, [sp, #0x30]
005A0D7F0  ldr      x9, [x8, #0x18]
005A0D7F4  ldr      x0, [x8, #0x40]
005A0D7F8  stp      q0, q1, [sp, #0x80]
005A0D7FC  str      q2, [sp, #0xa0]
005A0D800  str      x10, [sp, #0xb0]
005A0D804  ldr      x2, [x8, #0x28]
005A0D808  add      x1, sp, #0x80
005A0D80C  blr      x9
005A0D810  str      x0, [x19, #0x18]
005A0D814  mov      w0, #1
005A0D818  b        #0x5a0d830 ; 
005A0D81C  ldr      x8, [x19]
005A0D820  mov      x0, x19
005A0D824  ldp      x9, x1, [x8, #0x1f8]
005A0D828  blr      x9
005A0D82C  mov      w0, wzr
005A0D830  ldp      x20, x19, [sp, #0xd0]
005A0D834  ldr      x30, [sp, #0xc0]
005A0D838  add      sp, sp, #0xe0
005A0D83C  ret      
005A0D840  bl       #0x382bfc0 ; 
005A0D844  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, long>$$Where
; RVA 0x5A0D848; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D848  stp      x30, x21, [sp, #-0x20]!
005A0D84C  stp      x20, x19, [sp, #0x10]
005A0D850  ldr      x8, [x2, #0x20]
005A0D854  mov      x20, x2
005A0D858  mov      x19, x1
005A0D85C  mov      x21, x0
005A0D860  ldr      x8, [x8, #0xc0]
005A0D864  ldr      x8, [x8, #0x70]
005A0D868  ldrb     w9, [x8, #0x135]
005A0D86C  tbnz     w9, #0, #0x5a0d87c
005A0D870  mov      x0, x8
005A0D874  bl       #0x3a7e60c ; 
005A0D878  mov      x8, x0
005A0D87C  mov      x0, x8
005A0D880  bl       #0x382bfa0 ; 
005A0D884  ldr      x8, [x20, #0x20]
005A0D888  mov      x1, x21
005A0D88C  mov      x2, x19
005A0D890  mov      x20, x0
005A0D894  ldr      x8, [x8, #0xc0]
005A0D898  ldr      x3, [x8, #0x78]
005A0D89C  bl       #0x59ca6a8 ; System.Linq.Enumerable.WhereEnumerableIterator<long>$$.ctor
005A0D8A0  mov      x0, x20
005A0D8A4  ldp      x20, x19, [sp, #0x10]
005A0D8A8  ldp      x30, x21, [sp], #0x20
005A0D8AC  ret      

