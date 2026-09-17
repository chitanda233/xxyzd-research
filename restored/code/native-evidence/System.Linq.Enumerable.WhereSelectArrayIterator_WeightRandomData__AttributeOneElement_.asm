; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, AttributeOneElement>$$.ctor
; RVA 0x5A0BC04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BC04  str      x30, [sp, #-0x30]!
005A0BC08  stp      x22, x21, [sp, #0x10]
005A0BC0C  stp      x20, x19, [sp, #0x20]
005A0BC10  ldr      x8, [x4, #0x20]
005A0BC14  mov      x21, x1
005A0BC18  mov      x19, x3
005A0BC1C  mov      x20, x2
005A0BC20  ldr      x8, [x8, #0xc0]
005A0BC24  mov      x22, x0
005A0BC28  ldr      x1, [x8]
005A0BC2C  bl       #0x4a72e4c ; System.Linq.Enumerable.Iterator<AttributeOneElement>$$.ctor
005A0BC30  mov      x0, x22
005A0BC34  str      x21, [x0, #0x30]!
005A0BC38  mov      x1, x21
005A0BC3C  bl       #0x382bcb8 ; 
005A0BC40  mov      x0, x22
005A0BC44  str      x20, [x0, #0x38]!
005A0BC48  mov      x1, x20
005A0BC4C  bl       #0x382bcb8 ; 
005A0BC50  str      x19, [x22, #0x40]!
005A0BC54  mov      x0, x22
005A0BC58  mov      x1, x19
005A0BC5C  ldp      x20, x19, [sp, #0x20]
005A0BC60  ldp      x22, x21, [sp, #0x10]
005A0BC64  ldr      x30, [sp], #0x30
005A0BC68  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, AttributeOneElement>$$Clone
; RVA 0x5A0BC6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BC6C  str      x30, [sp, #-0x30]!
005A0BC70  stp      x22, x21, [sp, #0x10]
005A0BC74  stp      x20, x19, [sp, #0x20]
005A0BC78  ldr      x9, [x1, #0x20]
005A0BC7C  mov      x8, x0
005A0BC80  ldp      x21, x20, [x8, #0x30]
005A0BC84  ldr      x22, [x8, #0x40]
005A0BC88  ldr      x9, [x9, #0xc0]
005A0BC8C  mov      x19, x1
005A0BC90  ldr      x0, [x9, #0x18]
005A0BC94  ldrb     w9, [x0, #0x135]
005A0BC98  tbnz     w9, #0, #0x5a0bca0
005A0BC9C  bl       #0x3a7e60c ; 
005A0BCA0  bl       #0x382bfa0 ; 
005A0BCA4  ldr      x8, [x19, #0x20]
005A0BCA8  mov      x1, x21
005A0BCAC  mov      x2, x20
005A0BCB0  mov      x3, x22
005A0BCB4  ldr      x8, [x8, #0xc0]
005A0BCB8  mov      x19, x0
005A0BCBC  ldr      x4, [x8, #0x30]
005A0BCC0  bl       #0x5a0bc04 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, AttributeOneElement>$$.ctor
005A0BCC4  mov      x0, x19
005A0BCC8  ldp      x20, x19, [sp, #0x20]
005A0BCCC  ldp      x22, x21, [sp, #0x10]
005A0BCD0  ldr      x30, [sp], #0x30
005A0BCD4  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, AttributeOneElement>$$MoveNext
; RVA 0x5A0BCD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BCD8  sub      sp, sp, #0x110
005A0BCDC  str      x29, [sp, #0xe0]
005A0BCE0  stp      x30, x21, [sp, #0xf0]
005A0BCE4  stp      x20, x19, [sp, #0x100]
005A0BCE8  ldr      w8, [x0, #0x14]
005A0BCEC  cmp      w8, #1
005A0BCF0  b.ne     #0x5a0be08
005A0BCF4  mov      x19, x0
005A0BCF8  add      x20, sp, #0xa0
005A0BCFC  mov      w21, #0x38
005A0BD00  ldr      x9, [x19, #0x30]
005A0BD04  cbz      x9, #0x5a0be24
005A0BD08  ldrsw    x8, [x19, #0x48]
005A0BD0C  ldr      w10, [x9, #0x18]
005A0BD10  cmp      w8, w10
005A0BD14  b.ge     #0x5a0bdf8
005A0BD18  cmp      w8, w10
005A0BD1C  b.hs     #0x5a0be20
005A0BD20  madd     x9, x8, x21, x9
005A0BD24  ldr      x10, [x9, #0x50]
005A0BD28  ldp      q1, q0, [x9, #0x30]
005A0BD2C  ldr      q2, [x9, #0x20]
005A0BD30  add      w8, w8, #1
005A0BD34  str      x10, [sp, #0x90]
005A0BD38  stp      q1, q0, [sp, #0x70]
005A0BD3C  str      q2, [sp, #0x60]
005A0BD40  ldr      x9, [x19, #0x38]
005A0BD44  str      w8, [x19, #0x48]
005A0BD48  cbz      x9, #0x5a0bd7c
005A0BD4C  ldp      q0, q1, [sp, #0x60]
005A0BD50  ldr      q2, [sp, #0x80]
005A0BD54  ldr      x10, [sp, #0x90]
005A0BD58  ldr      x8, [x9, #0x18]
005A0BD5C  ldr      x0, [x9, #0x40]
005A0BD60  stp      q0, q1, [x20]
005A0BD64  str      q2, [x20, #0x20]
005A0BD68  str      x10, [sp, #0xd0]
005A0BD6C  ldr      x2, [x9, #0x28]
005A0BD70  add      x1, sp, #0xa0
005A0BD74  blr      x8
005A0BD78  tbz      w0, #0, #0x5a0bd00
005A0BD7C  ldr      x8, [x19, #0x40]
005A0BD80  ldp      q0, q1, [sp, #0x60]
005A0BD84  ldr      q2, [sp, #0x80]
005A0BD88  ldr      x9, [sp, #0x90]
005A0BD8C  stp      q0, q1, [sp, #0x20]
005A0BD90  str      q2, [sp, #0x40]
005A0BD94  str      x9, [sp, #0x50]
005A0BD98  cbz      x8, #0x5a0be24
005A0BD9C  ldp      q0, q1, [sp, #0x20]
005A0BDA0  ldr      q2, [sp, #0x40]
005A0BDA4  ldr      x10, [sp, #0x50]
005A0BDA8  ldr      x9, [x8, #0x18]
005A0BDAC  ldr      x0, [x8, #0x40]
005A0BDB0  stp      q0, q1, [x20]
005A0BDB4  str      q2, [x20, #0x20]
005A0BDB8  str      x10, [sp, #0xd0]
005A0BDBC  ldr      x2, [x8, #0x28]
005A0BDC0  add      x8, sp, #8
005A0BDC4  add      x1, sp, #0xa0
005A0BDC8  blr      x9
005A0BDCC  ldr      x8, [sp, #0x18]
005A0BDD0  ldur     q0, [sp, #8]
005A0BDD4  add      x0, x19, #0x18
005A0BDD8  mov      x1, xzr
005A0BDDC  str      x8, [sp, #0xb0]
005A0BDE0  str      q0, [x20]
005A0BDE4  str      x8, [x19, #0x28]
005A0BDE8  stur     q0, [x19, #0x18]
005A0BDEC  bl       #0x382bcb8 ; 
005A0BDF0  mov      w0, #1
005A0BDF4  b        #0x5a0be0c ; 
005A0BDF8  ldr      x8, [x19]
005A0BDFC  mov      x0, x19
005A0BE00  ldp      x9, x1, [x8, #0x1f8]
005A0BE04  blr      x9
005A0BE08  mov      w0, wzr
005A0BE0C  ldp      x20, x19, [sp, #0x100]
005A0BE10  ldp      x30, x21, [sp, #0xf0]
005A0BE14  ldr      x29, [sp, #0xe0]
005A0BE18  add      sp, sp, #0x110
005A0BE1C  ret      
005A0BE20  bl       #0x382bfc0 ; 
005A0BE24  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, AttributeOneElement>$$Where
; RVA 0x5A0BE28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BE28  stp      x30, x21, [sp, #-0x20]!
005A0BE2C  stp      x20, x19, [sp, #0x10]
005A0BE30  ldr      x8, [x2, #0x20]
005A0BE34  mov      x20, x2
005A0BE38  mov      x19, x1
005A0BE3C  mov      x21, x0
005A0BE40  ldr      x8, [x8, #0xc0]
005A0BE44  ldr      x8, [x8, #0x70]
005A0BE48  ldrb     w9, [x8, #0x135]
005A0BE4C  tbnz     w9, #0, #0x5a0be5c
005A0BE50  mov      x0, x8
005A0BE54  bl       #0x3a7e60c ; 
005A0BE58  mov      x8, x0
005A0BE5C  mov      x0, x8
005A0BE60  bl       #0x382bfa0 ; 
005A0BE64  ldr      x8, [x20, #0x20]
005A0BE68  mov      x1, x21
005A0BE6C  mov      x2, x19
005A0BE70  mov      x20, x0
005A0BE74  ldr      x8, [x8, #0xc0]
005A0BE78  ldr      x3, [x8, #0x78]
005A0BE7C  bl       #0x59c4fa0 ; System.Linq.Enumerable.WhereEnumerableIterator<AttributeOneElement>$$.ctor
005A0BE80  mov      x0, x20
005A0BE84  ldp      x20, x19, [sp, #0x10]
005A0BE88  ldp      x30, x21, [sp], #0x20
005A0BE8C  ret      

