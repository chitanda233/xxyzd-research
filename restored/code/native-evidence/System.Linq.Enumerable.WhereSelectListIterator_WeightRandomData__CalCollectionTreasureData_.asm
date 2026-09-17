; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
; RVA 0x5B057D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B057D0  str      x30, [sp, #-0x30]!
005B057D4  stp      x22, x21, [sp, #0x10]
005B057D8  stp      x20, x19, [sp, #0x20]
005B057DC  ldr      x8, [x4, #0x20]
005B057E0  mov      x21, x1
005B057E4  mov      x19, x3
005B057E8  mov      x20, x2
005B057EC  ldr      x8, [x8, #0xc0]
005B057F0  mov      x22, x0
005B057F4  ldr      x1, [x8]
005B057F8  bl       #0x4a73758 ; System.Linq.Enumerable.Iterator<CalCollectionTreasureData>$$.ctor
005B057FC  mov      x0, x22
005B05800  str      x21, [x0, #0x20]!
005B05804  mov      x1, x21
005B05808  bl       #0x382bcb8 ; 
005B0580C  mov      x0, x22
005B05810  str      x20, [x0, #0x28]!
005B05814  mov      x1, x20
005B05818  bl       #0x382bcb8 ; 
005B0581C  str      x19, [x22, #0x30]!
005B05820  mov      x0, x22
005B05824  mov      x1, x19
005B05828  ldp      x20, x19, [sp, #0x20]
005B0582C  ldp      x22, x21, [sp, #0x10]
005B05830  ldr      x30, [sp], #0x30
005B05834  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalCollectionTreasureData>$$Clone
; RVA 0x5B05838; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05838  str      x30, [sp, #-0x30]!
005B0583C  stp      x22, x21, [sp, #0x10]
005B05840  stp      x20, x19, [sp, #0x20]
005B05844  ldr      x9, [x1, #0x20]
005B05848  mov      x8, x0
005B0584C  ldp      x21, x20, [x8, #0x20]
005B05850  ldr      x22, [x8, #0x30]
005B05854  ldr      x9, [x9, #0xc0]
005B05858  mov      x19, x1
005B0585C  ldr      x0, [x9, #0x18]
005B05860  ldrb     w9, [x0, #0x135]
005B05864  tbnz     w9, #0, #0x5b0586c
005B05868  bl       #0x3a7e60c ; 
005B0586C  bl       #0x382bfa0 ; 
005B05870  ldr      x8, [x19, #0x20]
005B05874  mov      x1, x21
005B05878  mov      x2, x20
005B0587C  mov      x3, x22
005B05880  ldr      x8, [x8, #0xc0]
005B05884  mov      x19, x0
005B05888  ldr      x4, [x8, #0x30]
005B0588C  bl       #0x5b057d0 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
005B05890  mov      x0, x19
005B05894  ldp      x20, x19, [sp, #0x20]
005B05898  ldp      x22, x21, [sp, #0x10]
005B0589C  ldr      x30, [sp], #0x30
005B058A0  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalCollectionTreasureData>$$MoveNext
; RVA 0x5B058A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B058A4  sub      sp, sp, #0x110
005B058A8  stp      x29, x30, [sp, #0xe0]
005B058AC  stp      x22, x21, [sp, #0xf0]
005B058B0  stp      x20, x19, [sp, #0x100]
005B058B4  ldr      w8, [x0, #0x14]
005B058B8  mov      x19, x0
005B058BC  mov      x20, x1
005B058C0  cmp      w8, #2
005B058C4  b.eq     #0x5b05924
005B058C8  cmp      w8, #1
005B058CC  b.ne     #0x5b059fc
005B058D0  ldr      x0, [x19, #0x20]
005B058D4  cbz      x0, #0x5b05a14
005B058D8  ldr      x8, [x20, #0x20]
005B058DC  ldr      x8, [x8, #0xc0]
005B058E0  ldr      x1, [x8, #0x40]
005B058E4  add      x8, sp, #0x40
005B058E8  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B058EC  add      x0, sp, #0x90
005B058F0  add      x1, sp, #0x40
005B058F4  mov      w2, #0x48
005B058F8  bl       #0x89edad0 ; 
005B058FC  add      x21, x19, #0x38
005B05900  add      x1, sp, #0x90
005B05904  mov      w2, #0x48
005B05908  mov      x0, x21
005B0590C  bl       #0x89edad0 ; 
005B05910  mov      x0, x21
005B05914  mov      x1, xzr
005B05918  bl       #0x382bcb8 ; 
005B0591C  mov      w8, #2
005B05920  str      w8, [x19, #0x14]
005B05924  add      x21, x19, #0x38
005B05928  add      x22, x19, #0x48
005B0592C  ldr      x8, [x20, #0x20]
005B05930  mov      x0, x21
005B05934  ldr      x8, [x8, #0xc0]
005B05938  ldr      x1, [x8, #0x80]
005B0593C  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B05940  tbz      w0, #0, #0x5b059ec
005B05944  ldr      x8, [x22, #0x30]
005B05948  ldp      q1, q0, [x22, #0x10]
005B0594C  ldr      q2, [x22]
005B05950  str      x8, [sp, #0x70]
005B05954  stp      q1, q0, [sp, #0x50]
005B05958  str      q2, [sp, #0x40]
005B0595C  ldr      x8, [x19, #0x28]
005B05960  cbz      x8, #0x5b05994
005B05964  ldp      q0, q1, [sp, #0x40]
005B05968  ldr      q2, [sp, #0x60]
005B0596C  ldr      x10, [sp, #0x70]
005B05970  ldr      x9, [x8, #0x18]
005B05974  ldr      x0, [x8, #0x40]
005B05978  stp      q0, q1, [sp, #0x90]
005B0597C  str      q2, [sp, #0xb0]
005B05980  str      x10, [sp, #0xc0]
005B05984  ldr      x2, [x8, #0x28]
005B05988  add      x1, sp, #0x90
005B0598C  blr      x9
005B05990  tbz      w0, #0, #0x5b0592c
005B05994  ldr      x8, [x19, #0x30]
005B05998  ldp      q0, q1, [sp, #0x40]
005B0599C  ldr      q2, [sp, #0x60]
005B059A0  ldr      x9, [sp, #0x70]
005B059A4  stp      q0, q1, [sp]
005B059A8  str      q2, [sp, #0x20]
005B059AC  str      x9, [sp, #0x30]
005B059B0  cbz      x8, #0x5b05a14
005B059B4  ldp      q0, q1, [sp]
005B059B8  ldr      q2, [sp, #0x20]
005B059BC  ldr      x10, [sp, #0x30]
005B059C0  ldr      x9, [x8, #0x18]
005B059C4  ldr      x0, [x8, #0x40]
005B059C8  stp      q0, q1, [sp, #0x90]
005B059CC  str      q2, [sp, #0xb0]
005B059D0  str      x10, [sp, #0xc0]
005B059D4  ldr      x2, [x8, #0x28]
005B059D8  add      x1, sp, #0x90
005B059DC  blr      x9
005B059E0  str      x0, [x19, #0x18]
005B059E4  mov      w0, #1
005B059E8  b        #0x5b05a00 ; 
005B059EC  ldr      x8, [x19]
005B059F0  mov      x0, x19
005B059F4  ldp      x9, x1, [x8, #0x1f8]
005B059F8  blr      x9
005B059FC  mov      w0, wzr
005B05A00  ldp      x20, x19, [sp, #0x100]
005B05A04  ldp      x22, x21, [sp, #0xf0]
005B05A08  ldp      x29, x30, [sp, #0xe0]
005B05A0C  add      sp, sp, #0x110
005B05A10  ret      
005B05A14  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalCollectionTreasureData>$$Where
; RVA 0x5B05A18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05A18  stp      x30, x21, [sp, #-0x20]!
005B05A1C  stp      x20, x19, [sp, #0x10]
005B05A20  ldr      x8, [x2, #0x20]
005B05A24  mov      x20, x2
005B05A28  mov      x19, x1
005B05A2C  mov      x21, x0
005B05A30  ldr      x8, [x8, #0xc0]
005B05A34  ldr      x8, [x8, #0x98]
005B05A38  ldrb     w9, [x8, #0x135]
005B05A3C  tbnz     w9, #0, #0x5b05a4c
005B05A40  mov      x0, x8
005B05A44  bl       #0x3a7e60c ; 
005B05A48  mov      x8, x0
005B05A4C  mov      x0, x8
005B05A50  bl       #0x382bfa0 ; 
005B05A54  ldr      x8, [x20, #0x20]
005B05A58  mov      x1, x21
005B05A5C  mov      x2, x19
005B05A60  mov      x20, x0
005B05A64  ldr      x8, [x8, #0xc0]
005B05A68  ldr      x3, [x8, #0xa0]
005B05A6C  bl       #0x59c70e0 ; System.Linq.Enumerable.WhereEnumerableIterator<CalCollectionTreasureData>$$.ctor
005B05A70  mov      x0, x20
005B05A74  ldp      x20, x19, [sp, #0x10]
005B05A78  ldp      x30, x21, [sp], #0x20
005B05A7C  ret      

