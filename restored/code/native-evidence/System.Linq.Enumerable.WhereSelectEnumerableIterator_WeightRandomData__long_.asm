; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, long>$$.ctor
; RVA 0x5ABD6BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD6BC  str      x30, [sp, #-0x30]!
005ABD6C0  stp      x22, x21, [sp, #0x10]
005ABD6C4  stp      x20, x19, [sp, #0x20]
005ABD6C8  ldr      x8, [x4, #0x20]
005ABD6CC  mov      x21, x1
005ABD6D0  mov      x19, x3
005ABD6D4  mov      x20, x2
005ABD6D8  ldr      x8, [x8, #0xc0]
005ABD6DC  mov      x22, x0
005ABD6E0  ldr      x1, [x8]
005ABD6E4  bl       #0x4a745f4 ; System.Linq.Enumerable.Iterator<long>$$.ctor
005ABD6E8  mov      x0, x22
005ABD6EC  str      x21, [x0, #0x20]!
005ABD6F0  mov      x1, x21
005ABD6F4  bl       #0x382bcb8 ; 
005ABD6F8  mov      x0, x22
005ABD6FC  str      x20, [x0, #0x28]!
005ABD700  mov      x1, x20
005ABD704  bl       #0x382bcb8 ; 
005ABD708  str      x19, [x22, #0x30]!
005ABD70C  mov      x0, x22
005ABD710  mov      x1, x19
005ABD714  ldp      x20, x19, [sp, #0x20]
005ABD718  ldp      x22, x21, [sp, #0x10]
005ABD71C  ldr      x30, [sp], #0x30
005ABD720  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, long>$$Clone
; RVA 0x5ABD724; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD724  str      x30, [sp, #-0x30]!
005ABD728  stp      x22, x21, [sp, #0x10]
005ABD72C  stp      x20, x19, [sp, #0x20]
005ABD730  ldr      x9, [x1, #0x20]
005ABD734  mov      x8, x0
005ABD738  ldp      x21, x20, [x8, #0x20]
005ABD73C  ldr      x22, [x8, #0x30]
005ABD740  ldr      x9, [x9, #0xc0]
005ABD744  mov      x19, x1
005ABD748  ldr      x0, [x9, #0x18]
005ABD74C  ldrb     w9, [x0, #0x135]
005ABD750  tbnz     w9, #0, #0x5abd758
005ABD754  bl       #0x3a7e60c ; 
005ABD758  bl       #0x382bfa0 ; 
005ABD75C  ldr      x8, [x19, #0x20]
005ABD760  mov      x1, x21
005ABD764  mov      x2, x20
005ABD768  mov      x3, x22
005ABD76C  ldr      x8, [x8, #0xc0]
005ABD770  mov      x19, x0
005ABD774  ldr      x4, [x8, #0x30]
005ABD778  bl       #0x5abd6bc ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, long>$$.ctor
005ABD77C  mov      x0, x19
005ABD780  ldp      x20, x19, [sp, #0x20]
005ABD784  ldp      x22, x21, [sp, #0x10]
005ABD788  ldr      x30, [sp], #0x30
005ABD78C  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, long>$$Dispose
; RVA 0x5ABD790; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD790  str      x30, [sp, #-0x30]!
005ABD794  stp      x22, x21, [sp, #0x10]
005ABD798  stp      x20, x19, [sp, #0x20]
005ABD79C  adrp     x21, #0x9595000
005ABD7A0  ldrb     w8, [x21, #0x45b]
005ABD7A4  mov      x19, x1
005ABD7A8  mov      x20, x0
005ABD7AC  tbnz     w8, #0, #0x5abd7c4
005ABD7B0  adrp     x0, #0x8ebf000
005ABD7B4  ldr      x0, [x0, #0x4e8]
005ABD7B8  bl       #0x382bd14 ; 
005ABD7BC  mov      w8, #1
005ABD7C0  strb     w8, [x21, #0x45b]
005ABD7C4  mov      x21, x20
005ABD7C8  ldr      x22, [x21, #0x38]!
005ABD7CC  cbz      x22, #0x5abd830
005ABD7D0  adrp     x10, #0x8ebf000
005ABD7D4  ldr      x8, [x22]
005ABD7D8  ldr      x10, [x10, #0x4e8]
005ABD7DC  ldrh     w9, [x8, #0x12e]
005ABD7E0  ldr      x1, [x10]
005ABD7E4  cbz      x9, #0x5abd808
005ABD7E8  ldr      x10, [x8, #0xb0]
005ABD7EC  add      x10, x10, #8
005ABD7F0  ldur     x11, [x10, #-8]
005ABD7F4  cmp      x11, x1
005ABD7F8  b.eq     #0x5abd818
005ABD7FC  subs     x9, x9, #1
005ABD800  add      x10, x10, #0x10
005ABD804  b.ne     #0x5abd7f0
005ABD808  mov      x0, x22
005ABD80C  mov      w2, wzr
005ABD810  bl       #0x3a7e710 ; 
005ABD814  b        #0x5abd824 ; 
005ABD818  ldrsw    x9, [x10]
005ABD81C  add      x8, x8, x9, lsl #4
005ABD820  add      x0, x8, #0x138
005ABD824  ldp      x8, x1, [x0]
005ABD828  mov      x0, x22
005ABD82C  blr      x8
005ABD830  mov      x0, x21
005ABD834  mov      x1, xzr
005ABD838  str      xzr, [x20, #0x38]
005ABD83C  bl       #0x382bcb8 ; 
005ABD840  ldr      x8, [x19, #0x20]
005ABD844  mov      x0, x20
005ABD848  ldp      x20, x19, [sp, #0x20]
005ABD84C  ldp      x22, x21, [sp, #0x10]
005ABD850  ldr      x8, [x8, #0xc0]
005ABD854  ldr      x1, [x8, #0x48]
005ABD858  ldr      x30, [sp], #0x30
005ABD85C  b        #0x4a74630 ; System.Linq.Enumerable.Iterator<long>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, long>$$MoveNext
; RVA 0x5ABD860; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD860  sub      sp, sp, #0xf0
005ABD864  str      x30, [sp, #0xc0]
005ABD868  stp      x22, x21, [sp, #0xd0]
005ABD86C  stp      x20, x19, [sp, #0xe0]
005ABD870  adrp     x21, #0x9595000
005ABD874  ldrb     w8, [x21, #0x45c]
005ABD878  mov      x20, x1
005ABD87C  mov      x19, x0
005ABD880  tbnz     w8, #0, #0x5abd898
005ABD884  adrp     x0, #0x8ebf000
005ABD888  ldr      x0, [x0, #0x4f0]
005ABD88C  bl       #0x382bd14 ; 
005ABD890  mov      w8, #1
005ABD894  strb     w8, [x21, #0x45c]
005ABD898  ldr      w8, [x19, #0x14]
005ABD89C  adrp     x22, #0x8ebf000
005ABD8A0  ldr      x22, [x22, #0x4f0]
005ABD8A4  cmp      w8, #2
005ABD8A8  b.eq     #0x5abd94c
005ABD8AC  cmp      w8, #1
005ABD8B0  b.ne     #0x5abdaec
005ABD8B4  ldr      x21, [x19, #0x20]
005ABD8B8  cbz      x21, #0x5abdb04
005ABD8BC  ldr      x8, [x20, #0x20]
005ABD8C0  ldr      x8, [x8, #0xc0]
005ABD8C4  ldr      x1, [x8, #0x10]
005ABD8C8  ldrb     w8, [x1, #0x135]
005ABD8CC  tbnz     w8, #0, #0x5abd8dc
005ABD8D0  mov      x0, x1
005ABD8D4  bl       #0x3a7e60c ; 
005ABD8D8  mov      x1, x0
005ABD8DC  ldr      x8, [x21]
005ABD8E0  ldrh     w9, [x8, #0x12e]
005ABD8E4  cbz      x9, #0x5abd908
005ABD8E8  ldr      x10, [x8, #0xb0]
005ABD8EC  add      x10, x10, #8
005ABD8F0  ldur     x11, [x10, #-8]
005ABD8F4  cmp      x11, x1
005ABD8F8  b.eq     #0x5abd918
005ABD8FC  subs     x9, x9, #1
005ABD900  add      x10, x10, #0x10
005ABD904  b.ne     #0x5abd8f0
005ABD908  mov      x0, x21
005ABD90C  mov      w2, wzr
005ABD910  bl       #0x3a7e710 ; 
005ABD914  b        #0x5abd924 ; 
005ABD918  ldrsw    x9, [x10]
005ABD91C  add      x8, x8, x9, lsl #4
005ABD920  add      x0, x8, #0x138
005ABD924  ldp      x8, x1, [x0]
005ABD928  mov      x0, x21
005ABD92C  blr      x8
005ABD930  mov      x21, x19
005ABD934  str      x0, [x21, #0x38]!
005ABD938  mov      x1, x0
005ABD93C  mov      x0, x21
005ABD940  bl       #0x382bcb8 ; 
005ABD944  mov      w8, #2
005ABD948  stur     w8, [x21, #-0x24]
005ABD94C  ldr      x21, [x19, #0x38]
005ABD950  cbz      x21, #0x5abdb04
005ABD954  ldr      x8, [x21]
005ABD958  ldr      x1, [x22]
005ABD95C  ldrh     w9, [x8, #0x12e]
005ABD960  cbz      x9, #0x5abd984
005ABD964  ldr      x10, [x8, #0xb0]
005ABD968  add      x10, x10, #8
005ABD96C  ldur     x11, [x10, #-8]
005ABD970  cmp      x11, x1
005ABD974  b.eq     #0x5abd994
005ABD978  subs     x9, x9, #1
005ABD97C  add      x10, x10, #0x10
005ABD980  b.ne     #0x5abd96c
005ABD984  mov      x0, x21
005ABD988  mov      w2, wzr
005ABD98C  bl       #0x3a7e710 ; 
005ABD990  b        #0x5abd9a0 ; 
005ABD994  ldrsw    x9, [x10]
005ABD998  add      x8, x8, x9, lsl #4
005ABD99C  add      x0, x8, #0x138
005ABD9A0  ldp      x8, x1, [x0]
005ABD9A4  mov      x0, x21
005ABD9A8  blr      x8
005ABD9AC  tbz      w0, #0, #0x5abdad8
005ABD9B0  ldr      x21, [x19, #0x38]
005ABD9B4  cbz      x21, #0x5abdb04
005ABD9B8  ldr      x8, [x20, #0x20]
005ABD9BC  ldr      x8, [x8, #0xc0]
005ABD9C0  ldr      x1, [x8, #0x40]
005ABD9C4  ldrb     w8, [x1, #0x135]
005ABD9C8  tbnz     w8, #0, #0x5abd9d8
005ABD9CC  mov      x0, x1
005ABD9D0  bl       #0x3a7e60c ; 
005ABD9D4  mov      x1, x0
005ABD9D8  ldr      x8, [x21]
005ABD9DC  ldrh     w9, [x8, #0x12e]
005ABD9E0  cbz      x9, #0x5abda04
005ABD9E4  ldr      x10, [x8, #0xb0]
005ABD9E8  add      x10, x10, #8
005ABD9EC  ldur     x11, [x10, #-8]
005ABD9F0  cmp      x11, x1
005ABD9F4  b.eq     #0x5abda14
005ABD9F8  subs     x9, x9, #1
005ABD9FC  add      x10, x10, #0x10
005ABDA00  b.ne     #0x5abd9ec
005ABDA04  mov      x0, x21
005ABDA08  mov      w2, wzr
005ABDA0C  bl       #0x3a7e710 ; 
005ABDA10  b        #0x5abda20 ; 
005ABDA14  ldrsw    x9, [x10]
005ABDA18  add      x8, x8, x9, lsl #4
005ABDA1C  add      x0, x8, #0x138
005ABDA20  ldp      x9, x1, [x0]
005ABDA24  add      x8, sp, #0x80
005ABDA28  mov      x0, x21
005ABDA2C  blr      x9
005ABDA30  ldp      q0, q1, [sp, #0x80]
005ABDA34  ldr      q2, [sp, #0xa0]
005ABDA38  ldr      x8, [sp, #0xb0]
005ABDA3C  stp      q0, q1, [sp, #0x40]
005ABDA40  str      q2, [sp, #0x60]
005ABDA44  str      x8, [sp, #0x70]
005ABDA48  ldr      x8, [x19, #0x28]
005ABDA4C  cbz      x8, #0x5abda80
005ABDA50  ldp      q0, q1, [sp, #0x40]
005ABDA54  ldr      q2, [sp, #0x60]
005ABDA58  ldr      x10, [sp, #0x70]
005ABDA5C  ldr      x9, [x8, #0x18]
005ABDA60  ldr      x0, [x8, #0x40]
005ABDA64  stp      q0, q1, [sp, #0x80]
005ABDA68  str      q2, [sp, #0xa0]
005ABDA6C  str      x10, [sp, #0xb0]
005ABDA70  ldr      x2, [x8, #0x28]
005ABDA74  add      x1, sp, #0x80
005ABDA78  blr      x9
005ABDA7C  tbz      w0, #0, #0x5abd94c
005ABDA80  ldr      x8, [x19, #0x30]
005ABDA84  ldp      q0, q1, [sp, #0x40]
005ABDA88  ldr      q2, [sp, #0x60]
005ABDA8C  ldr      x9, [sp, #0x70]
005ABDA90  stp      q0, q1, [sp]
005ABDA94  str      q2, [sp, #0x20]
005ABDA98  str      x9, [sp, #0x30]
005ABDA9C  cbz      x8, #0x5abdb04
005ABDAA0  ldp      q0, q1, [sp]
005ABDAA4  ldr      q2, [sp, #0x20]
005ABDAA8  ldr      x10, [sp, #0x30]
005ABDAAC  ldr      x9, [x8, #0x18]
005ABDAB0  ldr      x0, [x8, #0x40]
005ABDAB4  stp      q0, q1, [sp, #0x80]
005ABDAB8  str      q2, [sp, #0xa0]
005ABDABC  str      x10, [sp, #0xb0]
005ABDAC0  ldr      x2, [x8, #0x28]
005ABDAC4  add      x1, sp, #0x80
005ABDAC8  blr      x9
005ABDACC  str      x0, [x19, #0x18]
005ABDAD0  mov      w0, #1
005ABDAD4  b        #0x5abdaf0 ; 
005ABDAD8  cbz      x19, #0x5abdb04
005ABDADC  ldr      x8, [x19]
005ABDAE0  mov      x0, x19
005ABDAE4  ldp      x9, x1, [x8, #0x1f8]
005ABDAE8  blr      x9
005ABDAEC  mov      w0, wzr
005ABDAF0  ldp      x20, x19, [sp, #0xe0]
005ABDAF4  ldp      x22, x21, [sp, #0xd0]
005ABDAF8  ldr      x30, [sp, #0xc0]
005ABDAFC  add      sp, sp, #0xf0
005ABDB00  ret      
005ABDB04  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, long>$$Where
; RVA 0x5ABDB08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABDB08  stp      x30, x21, [sp, #-0x20]!
005ABDB0C  stp      x20, x19, [sp, #0x10]
005ABDB10  ldr      x8, [x2, #0x20]
005ABDB14  mov      x20, x2
005ABDB18  mov      x19, x1
005ABDB1C  mov      x21, x0
005ABDB20  ldr      x8, [x8, #0xc0]
005ABDB24  ldr      x8, [x8, #0x88]
005ABDB28  ldrb     w9, [x8, #0x135]
005ABDB2C  tbnz     w9, #0, #0x5abdb3c
005ABDB30  mov      x0, x8
005ABDB34  bl       #0x3a7e60c ; 
005ABDB38  mov      x8, x0
005ABDB3C  mov      x0, x8
005ABDB40  bl       #0x382bfa0 ; 
005ABDB44  ldr      x8, [x20, #0x20]
005ABDB48  mov      x1, x21
005ABDB4C  mov      x2, x19
005ABDB50  mov      x20, x0
005ABDB54  ldr      x8, [x8, #0xc0]
005ABDB58  ldr      x3, [x8, #0x90]
005ABDB5C  bl       #0x59ca6a8 ; System.Linq.Enumerable.WhereEnumerableIterator<long>$$.ctor
005ABDB60  mov      x0, x20
005ABDB64  ldp      x20, x19, [sp, #0x10]
005ABDB68  ldp      x30, x21, [sp], #0x20
005ABDB6C  ret      

