; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalEquipData>$$.ctor
; RVA 0x5B05A80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05A80  str      x30, [sp, #-0x30]!
005B05A84  stp      x22, x21, [sp, #0x10]
005B05A88  stp      x20, x19, [sp, #0x20]
005B05A8C  ldr      x8, [x4, #0x20]
005B05A90  mov      x21, x1
005B05A94  mov      x19, x3
005B05A98  mov      x20, x2
005B05A9C  ldr      x8, [x8, #0xc0]
005B05AA0  mov      x22, x0
005B05AA4  ldr      x1, [x8]
005B05AA8  bl       #0x4a7386c ; System.Linq.Enumerable.Iterator<CalEquipData>$$.ctor
005B05AAC  mov      x0, x22
005B05AB0  str      x21, [x0, #0x20]!
005B05AB4  mov      x1, x21
005B05AB8  bl       #0x382bcb8 ; 
005B05ABC  mov      x0, x22
005B05AC0  str      x20, [x0, #0x28]!
005B05AC4  mov      x1, x20
005B05AC8  bl       #0x382bcb8 ; 
005B05ACC  str      x19, [x22, #0x30]!
005B05AD0  mov      x0, x22
005B05AD4  mov      x1, x19
005B05AD8  ldp      x20, x19, [sp, #0x20]
005B05ADC  ldp      x22, x21, [sp, #0x10]
005B05AE0  ldr      x30, [sp], #0x30
005B05AE4  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalEquipData>$$Clone
; RVA 0x5B05AE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05AE8  str      x30, [sp, #-0x30]!
005B05AEC  stp      x22, x21, [sp, #0x10]
005B05AF0  stp      x20, x19, [sp, #0x20]
005B05AF4  ldr      x9, [x1, #0x20]
005B05AF8  mov      x8, x0
005B05AFC  ldp      x21, x20, [x8, #0x20]
005B05B00  ldr      x22, [x8, #0x30]
005B05B04  ldr      x9, [x9, #0xc0]
005B05B08  mov      x19, x1
005B05B0C  ldr      x0, [x9, #0x18]
005B05B10  ldrb     w9, [x0, #0x135]
005B05B14  tbnz     w9, #0, #0x5b05b1c
005B05B18  bl       #0x3a7e60c ; 
005B05B1C  bl       #0x382bfa0 ; 
005B05B20  ldr      x8, [x19, #0x20]
005B05B24  mov      x1, x21
005B05B28  mov      x2, x20
005B05B2C  mov      x3, x22
005B05B30  ldr      x8, [x8, #0xc0]
005B05B34  mov      x19, x0
005B05B38  ldr      x4, [x8, #0x30]
005B05B3C  bl       #0x5b05a80 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalEquipData>$$.ctor
005B05B40  mov      x0, x19
005B05B44  ldp      x20, x19, [sp, #0x20]
005B05B48  ldp      x22, x21, [sp, #0x10]
005B05B4C  ldr      x30, [sp], #0x30
005B05B50  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalEquipData>$$MoveNext
; RVA 0x5B05B54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05B54  sub      sp, sp, #0x110
005B05B58  stp      x29, x30, [sp, #0xe0]
005B05B5C  stp      x22, x21, [sp, #0xf0]
005B05B60  stp      x20, x19, [sp, #0x100]
005B05B64  ldr      w8, [x0, #0x14]
005B05B68  mov      x19, x0
005B05B6C  mov      x20, x1
005B05B70  cmp      w8, #2
005B05B74  b.eq     #0x5b05bd4
005B05B78  cmp      w8, #1
005B05B7C  b.ne     #0x5b05cac
005B05B80  ldr      x0, [x19, #0x20]
005B05B84  cbz      x0, #0x5b05cc4
005B05B88  ldr      x8, [x20, #0x20]
005B05B8C  ldr      x8, [x8, #0xc0]
005B05B90  ldr      x1, [x8, #0x40]
005B05B94  add      x8, sp, #0x40
005B05B98  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B05B9C  add      x0, sp, #0x90
005B05BA0  add      x1, sp, #0x40
005B05BA4  mov      w2, #0x48
005B05BA8  bl       #0x89edad0 ; 
005B05BAC  add      x21, x19, #0x38
005B05BB0  add      x1, sp, #0x90
005B05BB4  mov      w2, #0x48
005B05BB8  mov      x0, x21
005B05BBC  bl       #0x89edad0 ; 
005B05BC0  mov      x0, x21
005B05BC4  mov      x1, xzr
005B05BC8  bl       #0x382bcb8 ; 
005B05BCC  mov      w8, #2
005B05BD0  str      w8, [x19, #0x14]
005B05BD4  add      x21, x19, #0x38
005B05BD8  add      x22, x19, #0x48
005B05BDC  ldr      x8, [x20, #0x20]
005B05BE0  mov      x0, x21
005B05BE4  ldr      x8, [x8, #0xc0]
005B05BE8  ldr      x1, [x8, #0x80]
005B05BEC  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B05BF0  tbz      w0, #0, #0x5b05c9c
005B05BF4  ldr      x8, [x22, #0x30]
005B05BF8  ldp      q1, q0, [x22, #0x10]
005B05BFC  ldr      q2, [x22]
005B05C00  str      x8, [sp, #0x70]
005B05C04  stp      q1, q0, [sp, #0x50]
005B05C08  str      q2, [sp, #0x40]
005B05C0C  ldr      x8, [x19, #0x28]
005B05C10  cbz      x8, #0x5b05c44
005B05C14  ldp      q0, q1, [sp, #0x40]
005B05C18  ldr      q2, [sp, #0x60]
005B05C1C  ldr      x10, [sp, #0x70]
005B05C20  ldr      x9, [x8, #0x18]
005B05C24  ldr      x0, [x8, #0x40]
005B05C28  stp      q0, q1, [sp, #0x90]
005B05C2C  str      q2, [sp, #0xb0]
005B05C30  str      x10, [sp, #0xc0]
005B05C34  ldr      x2, [x8, #0x28]
005B05C38  add      x1, sp, #0x90
005B05C3C  blr      x9
005B05C40  tbz      w0, #0, #0x5b05bdc
005B05C44  ldr      x8, [x19, #0x30]
005B05C48  ldp      q0, q1, [sp, #0x40]
005B05C4C  ldr      q2, [sp, #0x60]
005B05C50  ldr      x9, [sp, #0x70]
005B05C54  stp      q0, q1, [sp]
005B05C58  str      q2, [sp, #0x20]
005B05C5C  str      x9, [sp, #0x30]
005B05C60  cbz      x8, #0x5b05cc4
005B05C64  ldp      q0, q1, [sp]
005B05C68  ldr      q2, [sp, #0x20]
005B05C6C  ldr      x10, [sp, #0x30]
005B05C70  ldr      x9, [x8, #0x18]
005B05C74  ldr      x0, [x8, #0x40]
005B05C78  stp      q0, q1, [sp, #0x90]
005B05C7C  str      q2, [sp, #0xb0]
005B05C80  str      x10, [sp, #0xc0]
005B05C84  ldr      x2, [x8, #0x28]
005B05C88  add      x1, sp, #0x90
005B05C8C  blr      x9
005B05C90  str      x0, [x19, #0x18]
005B05C94  mov      w0, #1
005B05C98  b        #0x5b05cb0 ; 
005B05C9C  ldr      x8, [x19]
005B05CA0  mov      x0, x19
005B05CA4  ldp      x9, x1, [x8, #0x1f8]
005B05CA8  blr      x9
005B05CAC  mov      w0, wzr
005B05CB0  ldp      x20, x19, [sp, #0x100]
005B05CB4  ldp      x22, x21, [sp, #0xf0]
005B05CB8  ldp      x29, x30, [sp, #0xe0]
005B05CBC  add      sp, sp, #0x110
005B05CC0  ret      
005B05CC4  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalEquipData>$$Where
; RVA 0x5B05CC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05CC8  stp      x30, x21, [sp, #-0x20]!
005B05CCC  stp      x20, x19, [sp, #0x10]
005B05CD0  ldr      x8, [x2, #0x20]
005B05CD4  mov      x20, x2
005B05CD8  mov      x19, x1
005B05CDC  mov      x21, x0
005B05CE0  ldr      x8, [x8, #0xc0]
005B05CE4  ldr      x8, [x8, #0x98]
005B05CE8  ldrb     w9, [x8, #0x135]
005B05CEC  tbnz     w9, #0, #0x5b05cfc
005B05CF0  mov      x0, x8
005B05CF4  bl       #0x3a7e60c ; 
005B05CF8  mov      x8, x0
005B05CFC  mov      x0, x8
005B05D00  bl       #0x382bfa0 ; 
005B05D04  ldr      x8, [x20, #0x20]
005B05D08  mov      x1, x21
005B05D0C  mov      x2, x19
005B05D10  mov      x20, x0
005B05D14  ldr      x8, [x8, #0xc0]
005B05D18  ldr      x3, [x8, #0xa0]
005B05D1C  bl       #0x59c74f4 ; System.Linq.Enumerable.WhereEnumerableIterator<CalEquipData>$$.ctor
005B05D20  mov      x0, x20
005B05D24  ldp      x20, x19, [sp, #0x10]
005B05D28  ldp      x30, x21, [sp], #0x20
005B05D2C  ret      

