; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$.ctor
; RVA 0x5B06568; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06568  str      x30, [sp, #-0x30]!
005B0656C  stp      x22, x21, [sp, #0x10]
005B06570  stp      x20, x19, [sp, #0x20]
005B06574  ldr      x8, [x4, #0x20]
005B06578  mov      x21, x1
005B0657C  mov      x19, x3
005B06580  mov      x20, x2
005B06584  ldr      x8, [x8, #0xc0]
005B06588  mov      x22, x0
005B0658C  ldr      x1, [x8]
005B06590  bl       #0x4a743d4 ; System.Linq.Enumerable.Iterator<int>$$.ctor
005B06594  mov      x0, x22
005B06598  str      x21, [x0, #0x20]!
005B0659C  mov      x1, x21
005B065A0  bl       #0x382bcb8 ; 
005B065A4  mov      x0, x22
005B065A8  str      x20, [x0, #0x28]!
005B065AC  mov      x1, x20
005B065B0  bl       #0x382bcb8 ; 
005B065B4  str      x19, [x22, #0x30]!
005B065B8  mov      x0, x22
005B065BC  mov      x1, x19
005B065C0  ldp      x20, x19, [sp, #0x20]
005B065C4  ldp      x22, x21, [sp, #0x10]
005B065C8  ldr      x30, [sp], #0x30
005B065CC  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$Clone
; RVA 0x5B065D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B065D0  str      x30, [sp, #-0x30]!
005B065D4  stp      x22, x21, [sp, #0x10]
005B065D8  stp      x20, x19, [sp, #0x20]
005B065DC  ldr      x9, [x1, #0x20]
005B065E0  mov      x8, x0
005B065E4  ldp      x21, x20, [x8, #0x20]
005B065E8  ldr      x22, [x8, #0x30]
005B065EC  ldr      x9, [x9, #0xc0]
005B065F0  mov      x19, x1
005B065F4  ldr      x0, [x9, #0x18]
005B065F8  ldrb     w9, [x0, #0x135]
005B065FC  tbnz     w9, #0, #0x5b06604
005B06600  bl       #0x3a7e60c ; 
005B06604  bl       #0x382bfa0 ; 
005B06608  ldr      x8, [x19, #0x20]
005B0660C  mov      x1, x21
005B06610  mov      x2, x20
005B06614  mov      x3, x22
005B06618  ldr      x8, [x8, #0xc0]
005B0661C  mov      x19, x0
005B06620  ldr      x4, [x8, #0x30]
005B06624  bl       #0x5b06568 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$.ctor
005B06628  mov      x0, x19
005B0662C  ldp      x20, x19, [sp, #0x20]
005B06630  ldp      x22, x21, [sp, #0x10]
005B06634  ldr      x30, [sp], #0x30
005B06638  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$MoveNext
; RVA 0x5B0663C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B0663C  sub      sp, sp, #0x110
005B06640  stp      x29, x30, [sp, #0xe0]
005B06644  stp      x22, x21, [sp, #0xf0]
005B06648  stp      x20, x19, [sp, #0x100]
005B0664C  ldr      w8, [x0, #0x14]
005B06650  mov      x19, x0
005B06654  mov      x20, x1
005B06658  cmp      w8, #2
005B0665C  b.eq     #0x5b066bc
005B06660  cmp      w8, #1
005B06664  b.ne     #0x5b06794
005B06668  ldr      x0, [x19, #0x20]
005B0666C  cbz      x0, #0x5b067ac
005B06670  ldr      x8, [x20, #0x20]
005B06674  ldr      x8, [x8, #0xc0]
005B06678  ldr      x1, [x8, #0x40]
005B0667C  add      x8, sp, #0x40
005B06680  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B06684  add      x0, sp, #0x90
005B06688  add      x1, sp, #0x40
005B0668C  mov      w2, #0x48
005B06690  bl       #0x89edad0 ; 
005B06694  add      x21, x19, #0x38
005B06698  add      x1, sp, #0x90
005B0669C  mov      w2, #0x48
005B066A0  mov      x0, x21
005B066A4  bl       #0x89edad0 ; 
005B066A8  mov      x0, x21
005B066AC  mov      x1, xzr
005B066B0  bl       #0x382bcb8 ; 
005B066B4  mov      w8, #2
005B066B8  str      w8, [x19, #0x14]
005B066BC  add      x21, x19, #0x38
005B066C0  add      x22, x19, #0x48
005B066C4  ldr      x8, [x20, #0x20]
005B066C8  mov      x0, x21
005B066CC  ldr      x8, [x8, #0xc0]
005B066D0  ldr      x1, [x8, #0x80]
005B066D4  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B066D8  tbz      w0, #0, #0x5b06784
005B066DC  ldr      x8, [x22, #0x30]
005B066E0  ldp      q1, q0, [x22, #0x10]
005B066E4  ldr      q2, [x22]
005B066E8  str      x8, [sp, #0x70]
005B066EC  stp      q1, q0, [sp, #0x50]
005B066F0  str      q2, [sp, #0x40]
005B066F4  ldr      x8, [x19, #0x28]
005B066F8  cbz      x8, #0x5b0672c
005B066FC  ldp      q0, q1, [sp, #0x40]
005B06700  ldr      q2, [sp, #0x60]
005B06704  ldr      x10, [sp, #0x70]
005B06708  ldr      x9, [x8, #0x18]
005B0670C  ldr      x0, [x8, #0x40]
005B06710  stp      q0, q1, [sp, #0x90]
005B06714  str      q2, [sp, #0xb0]
005B06718  str      x10, [sp, #0xc0]
005B0671C  ldr      x2, [x8, #0x28]
005B06720  add      x1, sp, #0x90
005B06724  blr      x9
005B06728  tbz      w0, #0, #0x5b066c4
005B0672C  ldr      x8, [x19, #0x30]
005B06730  ldp      q0, q1, [sp, #0x40]
005B06734  ldr      q2, [sp, #0x60]
005B06738  ldr      x9, [sp, #0x70]
005B0673C  stp      q0, q1, [sp]
005B06740  str      q2, [sp, #0x20]
005B06744  str      x9, [sp, #0x30]
005B06748  cbz      x8, #0x5b067ac
005B0674C  ldp      q0, q1, [sp]
005B06750  ldr      q2, [sp, #0x20]
005B06754  ldr      x10, [sp, #0x30]
005B06758  ldr      x9, [x8, #0x18]
005B0675C  ldr      x0, [x8, #0x40]
005B06760  stp      q0, q1, [sp, #0x90]
005B06764  str      q2, [sp, #0xb0]
005B06768  str      x10, [sp, #0xc0]
005B0676C  ldr      x2, [x8, #0x28]
005B06770  add      x1, sp, #0x90
005B06774  blr      x9
005B06778  str      w0, [x19, #0x18]
005B0677C  mov      w0, #1
005B06780  b        #0x5b06798 ; 
005B06784  ldr      x8, [x19]
005B06788  mov      x0, x19
005B0678C  ldp      x9, x1, [x8, #0x1f8]
005B06790  blr      x9
005B06794  mov      w0, wzr
005B06798  ldp      x20, x19, [sp, #0x100]
005B0679C  ldp      x22, x21, [sp, #0xf0]
005B067A0  ldp      x29, x30, [sp, #0xe0]
005B067A4  add      sp, sp, #0x110
005B067A8  ret      
005B067AC  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$Select<int>
; RVA 0x44B2E3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B2E3C  stp      x30, x23, [sp, #-0x30]!
0044B2E40  stp      x22, x21, [sp, #0x10]
0044B2E44  stp      x20, x19, [sp, #0x20]
0044B2E48  ldr      x8, [x2, #0x38]
0044B2E4C  mov      x19, x2
0044B2E50  mov      x22, x1
0044B2E54  mov      x23, x0
0044B2E58  cbnz     x8, #0x44b2e68
0044B2E5C  mov      x0, x19
0044B2E60  bl       #0x3a7e668 ; 
0044B2E64  ldr      x8, [x19, #0x38]
0044B2E68  ldr      x0, [x23, #0x30]
0044B2E6C  ldr      x2, [x8, #8]
0044B2E70  ldp      x20, x21, [x23, #0x20]
0044B2E74  mov      x1, x22
0044B2E78  bl       #0x45a06fc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, int>
0044B2E7C  ldr      x8, [x19, #0x38]
0044B2E80  mov      x22, x0
0044B2E84  ldr      x8, [x8, #0x18]
0044B2E88  ldrb     w9, [x8, #0x135]
0044B2E8C  tbnz     w9, #0, #0x44b2e9c
0044B2E90  mov      x0, x8
0044B2E94  bl       #0x3a7e60c ; 
0044B2E98  mov      x8, x0
0044B2E9C  mov      x0, x8
0044B2EA0  bl       #0x382bfa0 ; 
0044B2EA4  ldr      x8, [x19, #0x38]
0044B2EA8  mov      x1, x20
0044B2EAC  mov      x2, x21
0044B2EB0  mov      x3, x22
0044B2EB4  ldr      x4, [x8, #0x20]
0044B2EB8  mov      x19, x0
0044B2EBC  bl       #0x5b06568 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$.ctor
0044B2EC0  mov      x0, x19
0044B2EC4  ldp      x20, x19, [sp, #0x20]
0044B2EC8  ldp      x22, x21, [sp, #0x10]
0044B2ECC  ldp      x30, x23, [sp], #0x30
0044B2ED0  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$Select<Int32Enum>
; RVA 0x44B2ED4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B2ED4  stp      x30, x23, [sp, #-0x30]!
0044B2ED8  stp      x22, x21, [sp, #0x10]
0044B2EDC  stp      x20, x19, [sp, #0x20]
0044B2EE0  ldr      x8, [x2, #0x38]
0044B2EE4  mov      x19, x2
0044B2EE8  mov      x22, x1
0044B2EEC  mov      x23, x0
0044B2EF0  cbnz     x8, #0x44b2f00
0044B2EF4  mov      x0, x19
0044B2EF8  bl       #0x3a7e668 ; 
0044B2EFC  ldr      x8, [x19, #0x38]
0044B2F00  ldr      x0, [x23, #0x30]
0044B2F04  ldr      x2, [x8, #8]
0044B2F08  ldp      x20, x21, [x23, #0x20]
0044B2F0C  mov      x1, x22
0044B2F10  bl       #0x45a07b8 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, Int32Enum>
0044B2F14  ldr      x8, [x19, #0x38]
0044B2F18  mov      x22, x0
0044B2F1C  ldr      x8, [x8, #0x18]
0044B2F20  ldrb     w9, [x8, #0x135]
0044B2F24  tbnz     w9, #0, #0x44b2f34
0044B2F28  mov      x0, x8
0044B2F2C  bl       #0x3a7e60c ; 
0044B2F30  mov      x8, x0
0044B2F34  mov      x0, x8
0044B2F38  bl       #0x382bfa0 ; 
0044B2F3C  ldr      x8, [x19, #0x38]
0044B2F40  mov      x1, x20
0044B2F44  mov      x2, x21
0044B2F48  mov      x3, x22
0044B2F4C  ldr      x4, [x8, #0x20]
0044B2F50  mov      x19, x0
0044B2F54  bl       #0x5b06818 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Int32Enum>$$.ctor
0044B2F58  mov      x0, x19
0044B2F5C  ldp      x20, x19, [sp, #0x20]
0044B2F60  ldp      x22, x21, [sp, #0x10]
0044B2F64  ldp      x30, x23, [sp], #0x30
0044B2F68  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$Select<object>
; RVA 0x44B2F6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044B2F6C  stp      x30, x23, [sp, #-0x30]!
0044B2F70  stp      x22, x21, [sp, #0x10]
0044B2F74  stp      x20, x19, [sp, #0x20]
0044B2F78  ldr      x8, [x2, #0x38]
0044B2F7C  mov      x19, x2
0044B2F80  mov      x22, x1
0044B2F84  mov      x23, x0
0044B2F88  cbnz     x8, #0x44b2f98
0044B2F8C  mov      x0, x19
0044B2F90  bl       #0x3a7e668 ; 
0044B2F94  ldr      x8, [x19, #0x38]
0044B2F98  ldr      x0, [x23, #0x30]
0044B2F9C  ldr      x2, [x8, #8]
0044B2FA0  ldp      x20, x21, [x23, #0x20]
0044B2FA4  mov      x1, x22
0044B2FA8  bl       #0x45a0874 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, object>
0044B2FAC  ldr      x8, [x19, #0x38]
0044B2FB0  mov      x22, x0
0044B2FB4  ldr      x8, [x8, #0x18]
0044B2FB8  ldrb     w9, [x8, #0x135]
0044B2FBC  tbnz     w9, #0, #0x44b2fcc
0044B2FC0  mov      x0, x8
0044B2FC4  bl       #0x3a7e60c ; 
0044B2FC8  mov      x8, x0
0044B2FCC  mov      x0, x8
0044B2FD0  bl       #0x382bfa0 ; 
0044B2FD4  ldr      x8, [x19, #0x38]
0044B2FD8  mov      x1, x20
0044B2FDC  mov      x2, x21
0044B2FE0  mov      x3, x22
0044B2FE4  ldr      x4, [x8, #0x20]
0044B2FE8  mov      x19, x0
0044B2FEC  bl       #0x5b06d78 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, object>$$.ctor
0044B2FF0  mov      x0, x19
0044B2FF4  ldp      x20, x19, [sp, #0x20]
0044B2FF8  ldp      x22, x21, [sp, #0x10]
0044B2FFC  ldp      x30, x23, [sp], #0x30
0044B3000  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, int>$$Where
; RVA 0x5B067B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B067B0  stp      x30, x21, [sp, #-0x20]!
005B067B4  stp      x20, x19, [sp, #0x10]
005B067B8  ldr      x8, [x2, #0x20]
005B067BC  mov      x20, x2
005B067C0  mov      x19, x1
005B067C4  mov      x21, x0
005B067C8  ldr      x8, [x8, #0xc0]
005B067CC  ldr      x8, [x8, #0x98]
005B067D0  ldrb     w9, [x8, #0x135]
005B067D4  tbnz     w9, #0, #0x5b067e4
005B067D8  mov      x0, x8
005B067DC  bl       #0x3a7e60c ; 
005B067E0  mov      x8, x0
005B067E4  mov      x0, x8
005B067E8  bl       #0x382bfa0 ; 
005B067EC  ldr      x8, [x20, #0x20]
005B067F0  mov      x1, x21
005B067F4  mov      x2, x19
005B067F8  mov      x20, x0
005B067FC  ldr      x8, [x8, #0xc0]
005B06800  ldr      x3, [x8, #0xa0]
005B06804  bl       #0x59c9e80 ; System.Linq.Enumerable.WhereEnumerableIterator<int>$$.ctor
005B06808  mov      x0, x20
005B0680C  ldp      x20, x19, [sp, #0x10]
005B06810  ldp      x30, x21, [sp], #0x20
005B06814  ret      

