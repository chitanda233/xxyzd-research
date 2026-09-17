; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, AttributeOneElement>$$.ctor
; RVA 0x5B04CDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04CDC  str      x30, [sp, #-0x30]!
005B04CE0  stp      x22, x21, [sp, #0x10]
005B04CE4  stp      x20, x19, [sp, #0x20]
005B04CE8  ldr      x8, [x4, #0x20]
005B04CEC  mov      x21, x1
005B04CF0  mov      x19, x3
005B04CF4  mov      x20, x2
005B04CF8  ldr      x8, [x8, #0xc0]
005B04CFC  mov      x22, x0
005B04D00  ldr      x1, [x8]
005B04D04  bl       #0x4a72e4c ; System.Linq.Enumerable.Iterator<AttributeOneElement>$$.ctor
005B04D08  mov      x0, x22
005B04D0C  str      x21, [x0, #0x30]!
005B04D10  mov      x1, x21
005B04D14  bl       #0x382bcb8 ; 
005B04D18  mov      x0, x22
005B04D1C  str      x20, [x0, #0x38]!
005B04D20  mov      x1, x20
005B04D24  bl       #0x382bcb8 ; 
005B04D28  str      x19, [x22, #0x40]!
005B04D2C  mov      x0, x22
005B04D30  mov      x1, x19
005B04D34  ldp      x20, x19, [sp, #0x20]
005B04D38  ldp      x22, x21, [sp, #0x10]
005B04D3C  ldr      x30, [sp], #0x30
005B04D40  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, AttributeOneElement>$$Clone
; RVA 0x5B04D44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04D44  str      x30, [sp, #-0x30]!
005B04D48  stp      x22, x21, [sp, #0x10]
005B04D4C  stp      x20, x19, [sp, #0x20]
005B04D50  ldr      x9, [x1, #0x20]
005B04D54  mov      x8, x0
005B04D58  ldp      x21, x20, [x8, #0x30]
005B04D5C  ldr      x22, [x8, #0x40]
005B04D60  ldr      x9, [x9, #0xc0]
005B04D64  mov      x19, x1
005B04D68  ldr      x0, [x9, #0x18]
005B04D6C  ldrb     w9, [x0, #0x135]
005B04D70  tbnz     w9, #0, #0x5b04d78
005B04D74  bl       #0x3a7e60c ; 
005B04D78  bl       #0x382bfa0 ; 
005B04D7C  ldr      x8, [x19, #0x20]
005B04D80  mov      x1, x21
005B04D84  mov      x2, x20
005B04D88  mov      x3, x22
005B04D8C  ldr      x8, [x8, #0xc0]
005B04D90  mov      x19, x0
005B04D94  ldr      x4, [x8, #0x30]
005B04D98  bl       #0x5b04cdc ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, AttributeOneElement>$$.ctor
005B04D9C  mov      x0, x19
005B04DA0  ldp      x20, x19, [sp, #0x20]
005B04DA4  ldp      x22, x21, [sp, #0x10]
005B04DA8  ldr      x30, [sp], #0x30
005B04DAC  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, AttributeOneElement>$$MoveNext
; RVA 0x5B04DB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04DB0  sub      sp, sp, #0x140
005B04DB4  str      x29, [sp, #0x100]
005B04DB8  stp      x30, x23, [sp, #0x110]
005B04DBC  stp      x22, x21, [sp, #0x120]
005B04DC0  stp      x20, x19, [sp, #0x130]
005B04DC4  ldr      w8, [x0, #0x14]
005B04DC8  mov      x19, x0
005B04DCC  mov      x20, x1
005B04DD0  cmp      w8, #2
005B04DD4  b.eq     #0x5b04e34
005B04DD8  cmp      w8, #1
005B04DDC  b.ne     #0x5b04f34
005B04DE0  ldr      x0, [x19, #0x30]
005B04DE4  cbz      x0, #0x5b04f50
005B04DE8  ldr      x8, [x20, #0x20]
005B04DEC  ldr      x8, [x8, #0xc0]
005B04DF0  ldr      x1, [x8, #0x40]
005B04DF4  add      x8, sp, #0x60
005B04DF8  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B04DFC  add      x0, sp, #0xb0
005B04E00  add      x1, sp, #0x60
005B04E04  mov      w2, #0x48
005B04E08  bl       #0x89edad0 ; 
005B04E0C  add      x21, x19, #0x48
005B04E10  add      x1, sp, #0xb0
005B04E14  mov      w2, #0x48
005B04E18  mov      x0, x21
005B04E1C  bl       #0x89edad0 ; 
005B04E20  mov      x0, x21
005B04E24  mov      x1, xzr
005B04E28  bl       #0x382bcb8 ; 
005B04E2C  mov      w8, #2
005B04E30  str      w8, [x19, #0x14]
005B04E34  add      x22, sp, #0xb0
005B04E38  add      x21, x19, #0x48
005B04E3C  add      x23, x19, #0x58
005B04E40  ldr      x8, [x20, #0x20]
005B04E44  mov      x0, x21
005B04E48  ldr      x8, [x8, #0xc0]
005B04E4C  ldr      x1, [x8, #0x80]
005B04E50  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B04E54  tbz      w0, #0, #0x5b04f24
005B04E58  ldr      x8, [x23, #0x30]
005B04E5C  ldp      q1, q0, [x23, #0x10]
005B04E60  ldr      q2, [x23]
005B04E64  str      x8, [sp, #0x90]
005B04E68  stp      q1, q0, [sp, #0x70]
005B04E6C  str      q2, [sp, #0x60]
005B04E70  ldr      x8, [x19, #0x38]
005B04E74  cbz      x8, #0x5b04ea8
005B04E78  ldp      q0, q1, [sp, #0x60]
005B04E7C  ldr      q2, [sp, #0x80]
005B04E80  ldr      x10, [sp, #0x90]
005B04E84  ldr      x9, [x8, #0x18]
005B04E88  ldr      x0, [x8, #0x40]
005B04E8C  stp      q0, q1, [x22]
005B04E90  str      q2, [x22, #0x20]
005B04E94  str      x10, [sp, #0xe0]
005B04E98  ldr      x2, [x8, #0x28]
005B04E9C  add      x1, sp, #0xb0
005B04EA0  blr      x9
005B04EA4  tbz      w0, #0, #0x5b04e40
005B04EA8  ldr      x8, [x19, #0x40]
005B04EAC  ldp      q0, q1, [sp, #0x60]
005B04EB0  ldr      q2, [sp, #0x80]
005B04EB4  ldr      x9, [sp, #0x90]
005B04EB8  stp      q0, q1, [sp, #0x20]
005B04EBC  str      q2, [sp, #0x40]
005B04EC0  str      x9, [sp, #0x50]
005B04EC4  cbz      x8, #0x5b04f50
005B04EC8  ldp      q0, q1, [sp, #0x20]
005B04ECC  ldr      q2, [sp, #0x40]
005B04ED0  ldr      x10, [sp, #0x50]
005B04ED4  ldr      x9, [x8, #0x18]
005B04ED8  ldr      x0, [x8, #0x40]
005B04EDC  stp      q0, q1, [x22]
005B04EE0  str      q2, [x22, #0x20]
005B04EE4  str      x10, [sp, #0xe0]
005B04EE8  ldr      x2, [x8, #0x28]
005B04EEC  add      x8, sp, #8
005B04EF0  add      x1, sp, #0xb0
005B04EF4  blr      x9
005B04EF8  ldr      x8, [sp, #0x18]
005B04EFC  ldur     q0, [sp, #8]
005B04F00  add      x0, x19, #0x18
005B04F04  mov      x1, xzr
005B04F08  str      x8, [sp, #0xc0]
005B04F0C  str      q0, [x22]
005B04F10  str      x8, [x19, #0x28]
005B04F14  stur     q0, [x19, #0x18]
005B04F18  bl       #0x382bcb8 ; 
005B04F1C  mov      w0, #1
005B04F20  b        #0x5b04f38 ; 
005B04F24  ldr      x8, [x19]
005B04F28  mov      x0, x19
005B04F2C  ldp      x9, x1, [x8, #0x1f8]
005B04F30  blr      x9
005B04F34  mov      w0, wzr
005B04F38  ldp      x20, x19, [sp, #0x130]
005B04F3C  ldp      x22, x21, [sp, #0x120]
005B04F40  ldp      x30, x23, [sp, #0x110]
005B04F44  ldr      x29, [sp, #0x100]
005B04F48  add      sp, sp, #0x140
005B04F4C  ret      
005B04F50  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, AttributeOneElement>$$Where
; RVA 0x5B04F54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04F54  stp      x30, x21, [sp, #-0x20]!
005B04F58  stp      x20, x19, [sp, #0x10]
005B04F5C  ldr      x8, [x2, #0x20]
005B04F60  mov      x20, x2
005B04F64  mov      x19, x1
005B04F68  mov      x21, x0
005B04F6C  ldr      x8, [x8, #0xc0]
005B04F70  ldr      x8, [x8, #0x98]
005B04F74  ldrb     w9, [x8, #0x135]
005B04F78  tbnz     w9, #0, #0x5b04f88
005B04F7C  mov      x0, x8
005B04F80  bl       #0x3a7e60c ; 
005B04F84  mov      x8, x0
005B04F88  mov      x0, x8
005B04F8C  bl       #0x382bfa0 ; 
005B04F90  ldr      x8, [x20, #0x20]
005B04F94  mov      x1, x21
005B04F98  mov      x2, x19
005B04F9C  mov      x20, x0
005B04FA0  ldr      x8, [x8, #0xc0]
005B04FA4  ldr      x3, [x8, #0xa0]
005B04FA8  bl       #0x59c4fa0 ; System.Linq.Enumerable.WhereEnumerableIterator<AttributeOneElement>$$.ctor
005B04FAC  mov      x0, x20
005B04FB0  ldp      x20, x19, [sp, #0x10]
005B04FB4  ldp      x30, x21, [sp], #0x20
005B04FB8  ret      

