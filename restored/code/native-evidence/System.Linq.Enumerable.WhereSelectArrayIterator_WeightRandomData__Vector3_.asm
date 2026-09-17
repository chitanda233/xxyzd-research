; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Vector3>$$.ctor
; RVA 0x5A0DB18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0DB18  str      x30, [sp, #-0x30]!
005A0DB1C  stp      x22, x21, [sp, #0x10]
005A0DB20  stp      x20, x19, [sp, #0x20]
005A0DB24  ldr      x8, [x4, #0x20]
005A0DB28  mov      x21, x1
005A0DB2C  mov      x19, x3
005A0DB30  mov      x20, x2
005A0DB34  ldr      x8, [x8, #0xc0]
005A0DB38  mov      x22, x0
005A0DB3C  ldr      x1, [x8]
005A0DB40  bl       #0x4a7519c ; System.Linq.Enumerable.Iterator<Vector3>$$.ctor
005A0DB44  mov      x0, x22
005A0DB48  str      x21, [x0, #0x28]!
005A0DB4C  mov      x1, x21
005A0DB50  bl       #0x382bcb8 ; 
005A0DB54  mov      x0, x22
005A0DB58  str      x20, [x0, #0x30]!
005A0DB5C  mov      x1, x20
005A0DB60  bl       #0x382bcb8 ; 
005A0DB64  str      x19, [x22, #0x38]!
005A0DB68  mov      x0, x22
005A0DB6C  mov      x1, x19
005A0DB70  ldp      x20, x19, [sp, #0x20]
005A0DB74  ldp      x22, x21, [sp, #0x10]
005A0DB78  ldr      x30, [sp], #0x30
005A0DB7C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Vector3>$$Clone
; RVA 0x5A0DB80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0DB80  str      x30, [sp, #-0x30]!
005A0DB84  stp      x22, x21, [sp, #0x10]
005A0DB88  stp      x20, x19, [sp, #0x20]
005A0DB8C  ldr      x9, [x1, #0x20]
005A0DB90  mov      x8, x0
005A0DB94  ldp      x21, x20, [x8, #0x28]
005A0DB98  ldr      x22, [x8, #0x38]
005A0DB9C  ldr      x9, [x9, #0xc0]
005A0DBA0  mov      x19, x1
005A0DBA4  ldr      x0, [x9, #0x18]
005A0DBA8  ldrb     w9, [x0, #0x135]
005A0DBAC  tbnz     w9, #0, #0x5a0dbb4
005A0DBB0  bl       #0x3a7e60c ; 
005A0DBB4  bl       #0x382bfa0 ; 
005A0DBB8  ldr      x8, [x19, #0x20]
005A0DBBC  mov      x1, x21
005A0DBC0  mov      x2, x20
005A0DBC4  mov      x3, x22
005A0DBC8  ldr      x8, [x8, #0xc0]
005A0DBCC  mov      x19, x0
005A0DBD0  ldr      x4, [x8, #0x30]
005A0DBD4  bl       #0x5a0db18 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Vector3>$$.ctor
005A0DBD8  mov      x0, x19
005A0DBDC  ldp      x20, x19, [sp, #0x20]
005A0DBE0  ldp      x22, x21, [sp, #0x10]
005A0DBE4  ldr      x30, [sp], #0x30
005A0DBE8  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Vector3>$$MoveNext
; RVA 0x5A0DBEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0DBEC  sub      sp, sp, #0xe0
005A0DBF0  str      x30, [sp, #0xc0]
005A0DBF4  stp      x20, x19, [sp, #0xd0]
005A0DBF8  ldr      w8, [x0, #0x14]
005A0DBFC  cmp      w8, #1
005A0DC00  b.ne     #0x5a0dcf4
005A0DC04  mov      x19, x0
005A0DC08  mov      w20, #0x38
005A0DC0C  ldr      x9, [x19, #0x28]
005A0DC10  cbz      x9, #0x5a0dd0c
005A0DC14  ldrsw    x8, [x19, #0x40]
005A0DC18  ldr      w10, [x9, #0x18]
005A0DC1C  cmp      w8, w10
005A0DC20  b.ge     #0x5a0dce4
005A0DC24  cmp      w8, w10
005A0DC28  b.hs     #0x5a0dd08
005A0DC2C  madd     x9, x8, x20, x9
005A0DC30  ldr      x10, [x9, #0x50]
005A0DC34  ldp      q1, q0, [x9, #0x30]
005A0DC38  ldr      q2, [x9, #0x20]
005A0DC3C  add      w8, w8, #1
005A0DC40  str      x10, [sp, #0x70]
005A0DC44  stp      q1, q0, [sp, #0x50]
005A0DC48  str      q2, [sp, #0x40]
005A0DC4C  ldr      x9, [x19, #0x30]
005A0DC50  str      w8, [x19, #0x40]
005A0DC54  cbz      x9, #0x5a0dc88
005A0DC58  ldp      q0, q1, [sp, #0x40]
005A0DC5C  ldr      q2, [sp, #0x60]
005A0DC60  ldr      x10, [sp, #0x70]
005A0DC64  ldr      x8, [x9, #0x18]
005A0DC68  ldr      x0, [x9, #0x40]
005A0DC6C  stp      q0, q1, [sp, #0x80]
005A0DC70  str      q2, [sp, #0xa0]
005A0DC74  str      x10, [sp, #0xb0]
005A0DC78  ldr      x2, [x9, #0x28]
005A0DC7C  add      x1, sp, #0x80
005A0DC80  blr      x8
005A0DC84  tbz      w0, #0, #0x5a0dc0c
005A0DC88  ldr      x8, [x19, #0x38]
005A0DC8C  ldp      q0, q1, [sp, #0x40]
005A0DC90  ldr      q2, [sp, #0x60]
005A0DC94  ldr      x9, [sp, #0x70]
005A0DC98  stp      q0, q1, [sp]
005A0DC9C  str      q2, [sp, #0x20]
005A0DCA0  str      x9, [sp, #0x30]
005A0DCA4  cbz      x8, #0x5a0dd0c
005A0DCA8  ldp      q0, q1, [sp]
005A0DCAC  ldr      q2, [sp, #0x20]
005A0DCB0  ldr      x10, [sp, #0x30]
005A0DCB4  ldr      x9, [x8, #0x18]
005A0DCB8  ldr      x0, [x8, #0x40]
005A0DCBC  stp      q0, q1, [sp, #0x80]
005A0DCC0  str      q2, [sp, #0xa0]
005A0DCC4  str      x10, [sp, #0xb0]
005A0DCC8  ldr      x2, [x8, #0x28]
005A0DCCC  add      x1, sp, #0x80
005A0DCD0  blr      x9
005A0DCD4  stp      s0, s1, [x19, #0x18]
005A0DCD8  str      s2, [x19, #0x20]
005A0DCDC  mov      w0, #1
005A0DCE0  b        #0x5a0dcf8 ; 
005A0DCE4  ldr      x8, [x19]
005A0DCE8  mov      x0, x19
005A0DCEC  ldp      x9, x1, [x8, #0x1f8]
005A0DCF0  blr      x9
005A0DCF4  mov      w0, wzr
005A0DCF8  ldp      x20, x19, [sp, #0xd0]
005A0DCFC  ldr      x30, [sp, #0xc0]
005A0DD00  add      sp, sp, #0xe0
005A0DD04  ret      
005A0DD08  bl       #0x382bfc0 ; 
005A0DD0C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Vector3>$$Where
; RVA 0x5A0DD10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0DD10  stp      x30, x21, [sp, #-0x20]!
005A0DD14  stp      x20, x19, [sp, #0x10]
005A0DD18  ldr      x8, [x2, #0x20]
005A0DD1C  mov      x20, x2
005A0DD20  mov      x19, x1
005A0DD24  mov      x21, x0
005A0DD28  ldr      x8, [x8, #0xc0]
005A0DD2C  ldr      x8, [x8, #0x70]
005A0DD30  ldrb     w9, [x8, #0x135]
005A0DD34  tbnz     w9, #0, #0x5a0dd44
005A0DD38  mov      x0, x8
005A0DD3C  bl       #0x3a7e60c ; 
005A0DD40  mov      x8, x0
005A0DD44  mov      x0, x8
005A0DD48  bl       #0x382bfa0 ; 
005A0DD4C  ldr      x8, [x20, #0x20]
005A0DD50  mov      x1, x21
005A0DD54  mov      x2, x19
005A0DD58  mov      x20, x0
005A0DD5C  ldr      x8, [x8, #0xc0]
005A0DD60  ldr      x3, [x8, #0x78]
005A0DD64  bl       #0x59cbf7c ; System.Linq.Enumerable.WhereEnumerableIterator<Vector3>$$.ctor
005A0DD68  mov      x0, x20
005A0DD6C  ldp      x20, x19, [sp, #0x10]
005A0DD70  ldp      x30, x21, [sp], #0x20
005A0DD74  ret      

