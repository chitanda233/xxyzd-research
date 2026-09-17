; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrRelicData>$$.ctor
; RVA 0x5B05520; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05520  str      x30, [sp, #-0x30]!
005B05524  stp      x22, x21, [sp, #0x10]
005B05528  stp      x20, x19, [sp, #0x20]
005B0552C  ldr      x8, [x4, #0x20]
005B05530  mov      x21, x1
005B05534  mov      x19, x3
005B05538  mov      x20, x2
005B0553C  ldr      x8, [x8, #0xc0]
005B05540  mov      x22, x0
005B05544  ldr      x1, [x8]
005B05548  bl       #0x4a73644 ; System.Linq.Enumerable.Iterator<CalAttrRelicData>$$.ctor
005B0554C  mov      x0, x22
005B05550  str      x21, [x0, #0x20]!
005B05554  mov      x1, x21
005B05558  bl       #0x382bcb8 ; 
005B0555C  mov      x0, x22
005B05560  str      x20, [x0, #0x28]!
005B05564  mov      x1, x20
005B05568  bl       #0x382bcb8 ; 
005B0556C  str      x19, [x22, #0x30]!
005B05570  mov      x0, x22
005B05574  mov      x1, x19
005B05578  ldp      x20, x19, [sp, #0x20]
005B0557C  ldp      x22, x21, [sp, #0x10]
005B05580  ldr      x30, [sp], #0x30
005B05584  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrRelicData>$$Clone
; RVA 0x5B05588; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05588  str      x30, [sp, #-0x30]!
005B0558C  stp      x22, x21, [sp, #0x10]
005B05590  stp      x20, x19, [sp, #0x20]
005B05594  ldr      x9, [x1, #0x20]
005B05598  mov      x8, x0
005B0559C  ldp      x21, x20, [x8, #0x20]
005B055A0  ldr      x22, [x8, #0x30]
005B055A4  ldr      x9, [x9, #0xc0]
005B055A8  mov      x19, x1
005B055AC  ldr      x0, [x9, #0x18]
005B055B0  ldrb     w9, [x0, #0x135]
005B055B4  tbnz     w9, #0, #0x5b055bc
005B055B8  bl       #0x3a7e60c ; 
005B055BC  bl       #0x382bfa0 ; 
005B055C0  ldr      x8, [x19, #0x20]
005B055C4  mov      x1, x21
005B055C8  mov      x2, x20
005B055CC  mov      x3, x22
005B055D0  ldr      x8, [x8, #0xc0]
005B055D4  mov      x19, x0
005B055D8  ldr      x4, [x8, #0x30]
005B055DC  bl       #0x5b05520 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrRelicData>$$.ctor
005B055E0  mov      x0, x19
005B055E4  ldp      x20, x19, [sp, #0x20]
005B055E8  ldp      x22, x21, [sp, #0x10]
005B055EC  ldr      x30, [sp], #0x30
005B055F0  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrRelicData>$$MoveNext
; RVA 0x5B055F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B055F4  sub      sp, sp, #0x110
005B055F8  stp      x29, x30, [sp, #0xe0]
005B055FC  stp      x22, x21, [sp, #0xf0]
005B05600  stp      x20, x19, [sp, #0x100]
005B05604  ldr      w8, [x0, #0x14]
005B05608  mov      x19, x0
005B0560C  mov      x20, x1
005B05610  cmp      w8, #2
005B05614  b.eq     #0x5b05674
005B05618  cmp      w8, #1
005B0561C  b.ne     #0x5b0574c
005B05620  ldr      x0, [x19, #0x20]
005B05624  cbz      x0, #0x5b05764
005B05628  ldr      x8, [x20, #0x20]
005B0562C  ldr      x8, [x8, #0xc0]
005B05630  ldr      x1, [x8, #0x40]
005B05634  add      x8, sp, #0x40
005B05638  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B0563C  add      x0, sp, #0x90
005B05640  add      x1, sp, #0x40
005B05644  mov      w2, #0x48
005B05648  bl       #0x89edad0 ; 
005B0564C  add      x21, x19, #0x38
005B05650  add      x1, sp, #0x90
005B05654  mov      w2, #0x48
005B05658  mov      x0, x21
005B0565C  bl       #0x89edad0 ; 
005B05660  mov      x0, x21
005B05664  mov      x1, xzr
005B05668  bl       #0x382bcb8 ; 
005B0566C  mov      w8, #2
005B05670  str      w8, [x19, #0x14]
005B05674  add      x21, x19, #0x38
005B05678  add      x22, x19, #0x48
005B0567C  ldr      x8, [x20, #0x20]
005B05680  mov      x0, x21
005B05684  ldr      x8, [x8, #0xc0]
005B05688  ldr      x1, [x8, #0x80]
005B0568C  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B05690  tbz      w0, #0, #0x5b0573c
005B05694  ldr      x8, [x22, #0x30]
005B05698  ldp      q1, q0, [x22, #0x10]
005B0569C  ldr      q2, [x22]
005B056A0  str      x8, [sp, #0x70]
005B056A4  stp      q1, q0, [sp, #0x50]
005B056A8  str      q2, [sp, #0x40]
005B056AC  ldr      x8, [x19, #0x28]
005B056B0  cbz      x8, #0x5b056e4
005B056B4  ldp      q0, q1, [sp, #0x40]
005B056B8  ldr      q2, [sp, #0x60]
005B056BC  ldr      x10, [sp, #0x70]
005B056C0  ldr      x9, [x8, #0x18]
005B056C4  ldr      x0, [x8, #0x40]
005B056C8  stp      q0, q1, [sp, #0x90]
005B056CC  str      q2, [sp, #0xb0]
005B056D0  str      x10, [sp, #0xc0]
005B056D4  ldr      x2, [x8, #0x28]
005B056D8  add      x1, sp, #0x90
005B056DC  blr      x9
005B056E0  tbz      w0, #0, #0x5b0567c
005B056E4  ldr      x8, [x19, #0x30]
005B056E8  ldp      q0, q1, [sp, #0x40]
005B056EC  ldr      q2, [sp, #0x60]
005B056F0  ldr      x9, [sp, #0x70]
005B056F4  stp      q0, q1, [sp]
005B056F8  str      q2, [sp, #0x20]
005B056FC  str      x9, [sp, #0x30]
005B05700  cbz      x8, #0x5b05764
005B05704  ldp      q0, q1, [sp]
005B05708  ldr      q2, [sp, #0x20]
005B0570C  ldr      x10, [sp, #0x30]
005B05710  ldr      x9, [x8, #0x18]
005B05714  ldr      x0, [x8, #0x40]
005B05718  stp      q0, q1, [sp, #0x90]
005B0571C  str      q2, [sp, #0xb0]
005B05720  str      x10, [sp, #0xc0]
005B05724  ldr      x2, [x8, #0x28]
005B05728  add      x1, sp, #0x90
005B0572C  blr      x9
005B05730  str      x0, [x19, #0x18]
005B05734  mov      w0, #1
005B05738  b        #0x5b05750 ; 
005B0573C  ldr      x8, [x19]
005B05740  mov      x0, x19
005B05744  ldp      x9, x1, [x8, #0x1f8]
005B05748  blr      x9
005B0574C  mov      w0, wzr
005B05750  ldp      x20, x19, [sp, #0x100]
005B05754  ldp      x22, x21, [sp, #0xf0]
005B05758  ldp      x29, x30, [sp, #0xe0]
005B0575C  add      sp, sp, #0x110
005B05760  ret      
005B05764  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrRelicData>$$Where
; RVA 0x5B05768; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05768  stp      x30, x21, [sp, #-0x20]!
005B0576C  stp      x20, x19, [sp, #0x10]
005B05770  ldr      x8, [x2, #0x20]
005B05774  mov      x20, x2
005B05778  mov      x19, x1
005B0577C  mov      x21, x0
005B05780  ldr      x8, [x8, #0xc0]
005B05784  ldr      x8, [x8, #0x98]
005B05788  ldrb     w9, [x8, #0x135]
005B0578C  tbnz     w9, #0, #0x5b0579c
005B05790  mov      x0, x8
005B05794  bl       #0x3a7e60c ; 
005B05798  mov      x8, x0
005B0579C  mov      x0, x8
005B057A0  bl       #0x382bfa0 ; 
005B057A4  ldr      x8, [x20, #0x20]
005B057A8  mov      x1, x21
005B057AC  mov      x2, x19
005B057B0  mov      x20, x0
005B057B4  ldr      x8, [x8, #0xc0]
005B057B8  ldr      x3, [x8, #0xa0]
005B057BC  bl       #0x59c6ccc ; System.Linq.Enumerable.WhereEnumerableIterator<CalAttrRelicData>$$.ctor
005B057C0  mov      x0, x20
005B057C4  ldp      x20, x19, [sp, #0x10]
005B057C8  ldp      x30, x21, [sp], #0x20
005B057CC  ret      

