; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRoleData>$$.ctor
; RVA 0x5B05D30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05D30  str      x30, [sp, #-0x30]!
005B05D34  stp      x22, x21, [sp, #0x10]
005B05D38  stp      x20, x19, [sp, #0x20]
005B05D3C  ldr      x8, [x4, #0x20]
005B05D40  mov      x21, x1
005B05D44  mov      x19, x3
005B05D48  mov      x20, x2
005B05D4C  ldr      x8, [x8, #0xc0]
005B05D50  mov      x22, x0
005B05D54  ldr      x1, [x8]
005B05D58  bl       #0x4a73980 ; System.Linq.Enumerable.Iterator<CalRoleData>$$.ctor
005B05D5C  mov      x0, x22
005B05D60  str      x21, [x0, #0x48]!
005B05D64  mov      x1, x21
005B05D68  bl       #0x382bcb8 ; 
005B05D6C  mov      x0, x22
005B05D70  str      x20, [x0, #0x50]!
005B05D74  mov      x1, x20
005B05D78  bl       #0x382bcb8 ; 
005B05D7C  str      x19, [x22, #0x58]!
005B05D80  mov      x0, x22
005B05D84  mov      x1, x19
005B05D88  ldp      x20, x19, [sp, #0x20]
005B05D8C  ldp      x22, x21, [sp, #0x10]
005B05D90  ldr      x30, [sp], #0x30
005B05D94  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRoleData>$$Clone
; RVA 0x5B05D98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05D98  str      x30, [sp, #-0x30]!
005B05D9C  stp      x22, x21, [sp, #0x10]
005B05DA0  stp      x20, x19, [sp, #0x20]
005B05DA4  ldr      x9, [x1, #0x20]
005B05DA8  mov      x8, x0
005B05DAC  ldp      x21, x20, [x8, #0x48]
005B05DB0  ldr      x22, [x8, #0x58]
005B05DB4  ldr      x9, [x9, #0xc0]
005B05DB8  mov      x19, x1
005B05DBC  ldr      x0, [x9, #0x18]
005B05DC0  ldrb     w9, [x0, #0x135]
005B05DC4  tbnz     w9, #0, #0x5b05dcc
005B05DC8  bl       #0x3a7e60c ; 
005B05DCC  bl       #0x382bfa0 ; 
005B05DD0  ldr      x8, [x19, #0x20]
005B05DD4  mov      x1, x21
005B05DD8  mov      x2, x20
005B05DDC  mov      x3, x22
005B05DE0  ldr      x8, [x8, #0xc0]
005B05DE4  mov      x19, x0
005B05DE8  ldr      x4, [x8, #0x30]
005B05DEC  bl       #0x5b05d30 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRoleData>$$.ctor
005B05DF0  mov      x0, x19
005B05DF4  ldp      x20, x19, [sp, #0x20]
005B05DF8  ldp      x22, x21, [sp, #0x10]
005B05DFC  ldr      x30, [sp], #0x30
005B05E00  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRoleData>$$MoveNext
; RVA 0x5B05E04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05E04  sub      sp, sp, #0x140
005B05E08  stp      x29, x30, [sp, #0x110]
005B05E0C  stp      x22, x21, [sp, #0x120]
005B05E10  stp      x20, x19, [sp, #0x130]
005B05E14  ldr      w8, [x0, #0x14]
005B05E18  mov      x19, x0
005B05E1C  mov      x20, x1
005B05E20  cmp      w8, #2
005B05E24  b.eq     #0x5b05e84
005B05E28  cmp      w8, #1
005B05E2C  b.ne     #0x5b05f84
005B05E30  ldr      x0, [x19, #0x48]
005B05E34  cbz      x0, #0x5b05f9c
005B05E38  ldr      x8, [x20, #0x20]
005B05E3C  ldr      x8, [x8, #0xc0]
005B05E40  ldr      x1, [x8, #0x40]
005B05E44  add      x8, sp, #0x70
005B05E48  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B05E4C  add      x0, sp, #0xc0
005B05E50  add      x1, sp, #0x70
005B05E54  mov      w2, #0x48
005B05E58  bl       #0x89edad0 ; 
005B05E5C  add      x21, x19, #0x60
005B05E60  add      x1, sp, #0xc0
005B05E64  mov      w2, #0x48
005B05E68  mov      x0, x21
005B05E6C  bl       #0x89edad0 ; 
005B05E70  mov      x0, x21
005B05E74  mov      x1, xzr
005B05E78  bl       #0x382bcb8 ; 
005B05E7C  mov      w8, #2
005B05E80  str      w8, [x19, #0x14]
005B05E84  add      x21, x19, #0x60
005B05E88  add      x22, x19, #0x70
005B05E8C  ldr      x8, [x20, #0x20]
005B05E90  mov      x0, x21
005B05E94  ldr      x8, [x8, #0xc0]
005B05E98  ldr      x1, [x8, #0x80]
005B05E9C  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B05EA0  tbz      w0, #0, #0x5b05f74
005B05EA4  ldr      x8, [x22, #0x30]
005B05EA8  ldp      q1, q0, [x22, #0x10]
005B05EAC  ldr      q2, [x22]
005B05EB0  str      x8, [sp, #0xa0]
005B05EB4  stp      q1, q0, [sp, #0x80]
005B05EB8  str      q2, [sp, #0x70]
005B05EBC  ldr      x8, [x19, #0x50]
005B05EC0  cbz      x8, #0x5b05ef4
005B05EC4  ldp      q0, q1, [sp, #0x70]
005B05EC8  ldr      q2, [sp, #0x90]
005B05ECC  ldr      x10, [sp, #0xa0]
005B05ED0  ldr      x9, [x8, #0x18]
005B05ED4  ldr      x0, [x8, #0x40]
005B05ED8  stp      q0, q1, [sp, #0xc0]
005B05EDC  str      q2, [sp, #0xe0]
005B05EE0  str      x10, [sp, #0xf0]
005B05EE4  ldr      x2, [x8, #0x28]
005B05EE8  add      x1, sp, #0xc0
005B05EEC  blr      x9
005B05EF0  tbz      w0, #0, #0x5b05e8c
005B05EF4  ldr      x8, [x19, #0x58]
005B05EF8  ldp      q0, q1, [sp, #0x70]
005B05EFC  ldr      q2, [sp, #0x90]
005B05F00  ldr      x9, [sp, #0xa0]
005B05F04  stp      q0, q1, [sp, #0x30]
005B05F08  str      q2, [sp, #0x50]
005B05F0C  str      x9, [sp, #0x60]
005B05F10  cbz      x8, #0x5b05f9c
005B05F14  ldp      q0, q1, [sp, #0x30]
005B05F18  ldr      q2, [sp, #0x50]
005B05F1C  ldr      x10, [sp, #0x60]
005B05F20  ldr      x9, [x8, #0x18]
005B05F24  ldr      x0, [x8, #0x40]
005B05F28  stp      q0, q1, [sp, #0xc0]
005B05F2C  str      q2, [sp, #0xe0]
005B05F30  str      x10, [sp, #0xf0]
005B05F34  ldr      x2, [x8, #0x28]
005B05F38  mov      x8, sp
005B05F3C  add      x1, sp, #0xc0
005B05F40  blr      x9
005B05F44  ldp      q1, q0, [sp, #0x10]
005B05F48  ldr      q2, [sp]
005B05F4C  add      x0, x19, #0x28
005B05F50  mov      x1, xzr
005B05F54  stp      q1, q0, [sp, #0xd0]
005B05F58  str      q2, [sp, #0xc0]
005B05F5C  stur     q0, [x19, #0x38]
005B05F60  stur     q1, [x19, #0x28]
005B05F64  stur     q2, [x19, #0x18]
005B05F68  bl       #0x382bcb8 ; 
005B05F6C  mov      w0, #1
005B05F70  b        #0x5b05f88 ; 
005B05F74  ldr      x8, [x19]
005B05F78  mov      x0, x19
005B05F7C  ldp      x9, x1, [x8, #0x1f8]
005B05F80  blr      x9
005B05F84  mov      w0, wzr
005B05F88  ldp      x20, x19, [sp, #0x130]
005B05F8C  ldp      x22, x21, [sp, #0x120]
005B05F90  ldp      x29, x30, [sp, #0x110]
005B05F94  add      sp, sp, #0x140
005B05F98  ret      
005B05F9C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRoleData>$$Where
; RVA 0x5B05FA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05FA0  stp      x30, x21, [sp, #-0x20]!
005B05FA4  stp      x20, x19, [sp, #0x10]
005B05FA8  ldr      x8, [x2, #0x20]
005B05FAC  mov      x20, x2
005B05FB0  mov      x19, x1
005B05FB4  mov      x21, x0
005B05FB8  ldr      x8, [x8, #0xc0]
005B05FBC  ldr      x8, [x8, #0x98]
005B05FC0  ldrb     w9, [x8, #0x135]
005B05FC4  tbnz     w9, #0, #0x5b05fd4
005B05FC8  mov      x0, x8
005B05FCC  bl       #0x3a7e60c ; 
005B05FD0  mov      x8, x0
005B05FD4  mov      x0, x8
005B05FD8  bl       #0x382bfa0 ; 
005B05FDC  ldr      x8, [x20, #0x20]
005B05FE0  mov      x1, x21
005B05FE4  mov      x2, x19
005B05FE8  mov      x20, x0
005B05FEC  ldr      x8, [x8, #0xc0]
005B05FF0  ldr      x3, [x8, #0xa0]
005B05FF4  bl       #0x59c7908 ; System.Linq.Enumerable.WhereEnumerableIterator<CalRoleData>$$.ctor
005B05FF8  mov      x0, x20
005B05FFC  ldp      x20, x19, [sp, #0x10]
005B06000  ldp      x30, x21, [sp], #0x20
005B06004  ret      

