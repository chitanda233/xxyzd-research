; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalEquipData>$$.ctor
; RVA 0x5ABBA5C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBA5C  str      x30, [sp, #-0x30]!
005ABBA60  stp      x22, x21, [sp, #0x10]
005ABBA64  stp      x20, x19, [sp, #0x20]
005ABBA68  ldr      x8, [x4, #0x20]
005ABBA6C  mov      x21, x1
005ABBA70  mov      x19, x3
005ABBA74  mov      x20, x2
005ABBA78  ldr      x8, [x8, #0xc0]
005ABBA7C  mov      x22, x0
005ABBA80  ldr      x1, [x8]
005ABBA84  bl       #0x4a7386c ; System.Linq.Enumerable.Iterator<CalEquipData>$$.ctor
005ABBA88  mov      x0, x22
005ABBA8C  str      x21, [x0, #0x20]!
005ABBA90  mov      x1, x21
005ABBA94  bl       #0x382bcb8 ; 
005ABBA98  mov      x0, x22
005ABBA9C  str      x20, [x0, #0x28]!
005ABBAA0  mov      x1, x20
005ABBAA4  bl       #0x382bcb8 ; 
005ABBAA8  str      x19, [x22, #0x30]!
005ABBAAC  mov      x0, x22
005ABBAB0  mov      x1, x19
005ABBAB4  ldp      x20, x19, [sp, #0x20]
005ABBAB8  ldp      x22, x21, [sp, #0x10]
005ABBABC  ldr      x30, [sp], #0x30
005ABBAC0  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalEquipData>$$Clone
; RVA 0x5ABBAC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBAC4  str      x30, [sp, #-0x30]!
005ABBAC8  stp      x22, x21, [sp, #0x10]
005ABBACC  stp      x20, x19, [sp, #0x20]
005ABBAD0  ldr      x9, [x1, #0x20]
005ABBAD4  mov      x8, x0
005ABBAD8  ldp      x21, x20, [x8, #0x20]
005ABBADC  ldr      x22, [x8, #0x30]
005ABBAE0  ldr      x9, [x9, #0xc0]
005ABBAE4  mov      x19, x1
005ABBAE8  ldr      x0, [x9, #0x18]
005ABBAEC  ldrb     w9, [x0, #0x135]
005ABBAF0  tbnz     w9, #0, #0x5abbaf8
005ABBAF4  bl       #0x3a7e60c ; 
005ABBAF8  bl       #0x382bfa0 ; 
005ABBAFC  ldr      x8, [x19, #0x20]
005ABBB00  mov      x1, x21
005ABBB04  mov      x2, x20
005ABBB08  mov      x3, x22
005ABBB0C  ldr      x8, [x8, #0xc0]
005ABBB10  mov      x19, x0
005ABBB14  ldr      x4, [x8, #0x30]
005ABBB18  bl       #0x5abba5c ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalEquipData>$$.ctor
005ABBB1C  mov      x0, x19
005ABBB20  ldp      x20, x19, [sp, #0x20]
005ABBB24  ldp      x22, x21, [sp, #0x10]
005ABBB28  ldr      x30, [sp], #0x30
005ABBB2C  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalEquipData>$$Dispose
; RVA 0x5ABBB30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBB30  str      x30, [sp, #-0x30]!
005ABBB34  stp      x22, x21, [sp, #0x10]
005ABBB38  stp      x20, x19, [sp, #0x20]
005ABBB3C  adrp     x21, #0x9595000
005ABBB40  ldrb     w8, [x21, #0x44f]
005ABBB44  mov      x19, x1
005ABBB48  mov      x20, x0
005ABBB4C  tbnz     w8, #0, #0x5abbb64
005ABBB50  adrp     x0, #0x8ebf000
005ABBB54  ldr      x0, [x0, #0x4e8]
005ABBB58  bl       #0x382bd14 ; 
005ABBB5C  mov      w8, #1
005ABBB60  strb     w8, [x21, #0x44f]
005ABBB64  mov      x21, x20
005ABBB68  ldr      x22, [x21, #0x38]!
005ABBB6C  cbz      x22, #0x5abbbd0
005ABBB70  adrp     x10, #0x8ebf000
005ABBB74  ldr      x8, [x22]
005ABBB78  ldr      x10, [x10, #0x4e8]
005ABBB7C  ldrh     w9, [x8, #0x12e]
005ABBB80  ldr      x1, [x10]
005ABBB84  cbz      x9, #0x5abbba8
005ABBB88  ldr      x10, [x8, #0xb0]
005ABBB8C  add      x10, x10, #8
005ABBB90  ldur     x11, [x10, #-8]
005ABBB94  cmp      x11, x1
005ABBB98  b.eq     #0x5abbbb8
005ABBB9C  subs     x9, x9, #1
005ABBBA0  add      x10, x10, #0x10
005ABBBA4  b.ne     #0x5abbb90
005ABBBA8  mov      x0, x22
005ABBBAC  mov      w2, wzr
005ABBBB0  bl       #0x3a7e710 ; 
005ABBBB4  b        #0x5abbbc4 ; 
005ABBBB8  ldrsw    x9, [x10]
005ABBBBC  add      x8, x8, x9, lsl #4
005ABBBC0  add      x0, x8, #0x138
005ABBBC4  ldp      x8, x1, [x0]
005ABBBC8  mov      x0, x22
005ABBBCC  blr      x8
005ABBBD0  mov      x0, x21
005ABBBD4  mov      x1, xzr
005ABBBD8  str      xzr, [x20, #0x38]
005ABBBDC  bl       #0x382bcb8 ; 
005ABBBE0  ldr      x8, [x19, #0x20]
005ABBBE4  mov      x0, x20
005ABBBE8  ldp      x20, x19, [sp, #0x20]
005ABBBEC  ldp      x22, x21, [sp, #0x10]
005ABBBF0  ldr      x8, [x8, #0xc0]
005ABBBF4  ldr      x1, [x8, #0x48]
005ABBBF8  ldr      x30, [sp], #0x30
005ABBBFC  b        #0x4a738a8 ; System.Linq.Enumerable.Iterator<CalEquipData>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalEquipData>$$MoveNext
; RVA 0x5ABBC00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBC00  sub      sp, sp, #0xf0
005ABBC04  str      x30, [sp, #0xc0]
005ABBC08  stp      x22, x21, [sp, #0xd0]
005ABBC0C  stp      x20, x19, [sp, #0xe0]
005ABBC10  adrp     x21, #0x9595000
005ABBC14  ldrb     w8, [x21, #0x450]
005ABBC18  mov      x20, x1
005ABBC1C  mov      x19, x0
005ABBC20  tbnz     w8, #0, #0x5abbc38
005ABBC24  adrp     x0, #0x8ebf000
005ABBC28  ldr      x0, [x0, #0x4f0]
005ABBC2C  bl       #0x382bd14 ; 
005ABBC30  mov      w8, #1
005ABBC34  strb     w8, [x21, #0x450]
005ABBC38  ldr      w8, [x19, #0x14]
005ABBC3C  adrp     x22, #0x8ebf000
005ABBC40  ldr      x22, [x22, #0x4f0]
005ABBC44  cmp      w8, #2
005ABBC48  b.eq     #0x5abbcec
005ABBC4C  cmp      w8, #1
005ABBC50  b.ne     #0x5abbe8c
005ABBC54  ldr      x21, [x19, #0x20]
005ABBC58  cbz      x21, #0x5abbea4
005ABBC5C  ldr      x8, [x20, #0x20]
005ABBC60  ldr      x8, [x8, #0xc0]
005ABBC64  ldr      x1, [x8, #0x10]
005ABBC68  ldrb     w8, [x1, #0x135]
005ABBC6C  tbnz     w8, #0, #0x5abbc7c
005ABBC70  mov      x0, x1
005ABBC74  bl       #0x3a7e60c ; 
005ABBC78  mov      x1, x0
005ABBC7C  ldr      x8, [x21]
005ABBC80  ldrh     w9, [x8, #0x12e]
005ABBC84  cbz      x9, #0x5abbca8
005ABBC88  ldr      x10, [x8, #0xb0]
005ABBC8C  add      x10, x10, #8
005ABBC90  ldur     x11, [x10, #-8]
005ABBC94  cmp      x11, x1
005ABBC98  b.eq     #0x5abbcb8
005ABBC9C  subs     x9, x9, #1
005ABBCA0  add      x10, x10, #0x10
005ABBCA4  b.ne     #0x5abbc90
005ABBCA8  mov      x0, x21
005ABBCAC  mov      w2, wzr
005ABBCB0  bl       #0x3a7e710 ; 
005ABBCB4  b        #0x5abbcc4 ; 
005ABBCB8  ldrsw    x9, [x10]
005ABBCBC  add      x8, x8, x9, lsl #4
005ABBCC0  add      x0, x8, #0x138
005ABBCC4  ldp      x8, x1, [x0]
005ABBCC8  mov      x0, x21
005ABBCCC  blr      x8
005ABBCD0  mov      x21, x19
005ABBCD4  str      x0, [x21, #0x38]!
005ABBCD8  mov      x1, x0
005ABBCDC  mov      x0, x21
005ABBCE0  bl       #0x382bcb8 ; 
005ABBCE4  mov      w8, #2
005ABBCE8  stur     w8, [x21, #-0x24]
005ABBCEC  ldr      x21, [x19, #0x38]
005ABBCF0  cbz      x21, #0x5abbea4
005ABBCF4  ldr      x8, [x21]
005ABBCF8  ldr      x1, [x22]
005ABBCFC  ldrh     w9, [x8, #0x12e]
005ABBD00  cbz      x9, #0x5abbd24
005ABBD04  ldr      x10, [x8, #0xb0]
005ABBD08  add      x10, x10, #8
005ABBD0C  ldur     x11, [x10, #-8]
005ABBD10  cmp      x11, x1
005ABBD14  b.eq     #0x5abbd34
005ABBD18  subs     x9, x9, #1
005ABBD1C  add      x10, x10, #0x10
005ABBD20  b.ne     #0x5abbd0c
005ABBD24  mov      x0, x21
005ABBD28  mov      w2, wzr
005ABBD2C  bl       #0x3a7e710 ; 
005ABBD30  b        #0x5abbd40 ; 
005ABBD34  ldrsw    x9, [x10]
005ABBD38  add      x8, x8, x9, lsl #4
005ABBD3C  add      x0, x8, #0x138
005ABBD40  ldp      x8, x1, [x0]
005ABBD44  mov      x0, x21
005ABBD48  blr      x8
005ABBD4C  tbz      w0, #0, #0x5abbe78
005ABBD50  ldr      x21, [x19, #0x38]
005ABBD54  cbz      x21, #0x5abbea4
005ABBD58  ldr      x8, [x20, #0x20]
005ABBD5C  ldr      x8, [x8, #0xc0]
005ABBD60  ldr      x1, [x8, #0x40]
005ABBD64  ldrb     w8, [x1, #0x135]
005ABBD68  tbnz     w8, #0, #0x5abbd78
005ABBD6C  mov      x0, x1
005ABBD70  bl       #0x3a7e60c ; 
005ABBD74  mov      x1, x0
005ABBD78  ldr      x8, [x21]
005ABBD7C  ldrh     w9, [x8, #0x12e]
005ABBD80  cbz      x9, #0x5abbda4
005ABBD84  ldr      x10, [x8, #0xb0]
005ABBD88  add      x10, x10, #8
005ABBD8C  ldur     x11, [x10, #-8]
005ABBD90  cmp      x11, x1
005ABBD94  b.eq     #0x5abbdb4
005ABBD98  subs     x9, x9, #1
005ABBD9C  add      x10, x10, #0x10
005ABBDA0  b.ne     #0x5abbd8c
005ABBDA4  mov      x0, x21
005ABBDA8  mov      w2, wzr
005ABBDAC  bl       #0x3a7e710 ; 
005ABBDB0  b        #0x5abbdc0 ; 
005ABBDB4  ldrsw    x9, [x10]
005ABBDB8  add      x8, x8, x9, lsl #4
005ABBDBC  add      x0, x8, #0x138
005ABBDC0  ldp      x9, x1, [x0]
005ABBDC4  add      x8, sp, #0x80
005ABBDC8  mov      x0, x21
005ABBDCC  blr      x9
005ABBDD0  ldp      q0, q1, [sp, #0x80]
005ABBDD4  ldr      q2, [sp, #0xa0]
005ABBDD8  ldr      x8, [sp, #0xb0]
005ABBDDC  stp      q0, q1, [sp, #0x40]
005ABBDE0  str      q2, [sp, #0x60]
005ABBDE4  str      x8, [sp, #0x70]
005ABBDE8  ldr      x8, [x19, #0x28]
005ABBDEC  cbz      x8, #0x5abbe20
005ABBDF0  ldp      q0, q1, [sp, #0x40]
005ABBDF4  ldr      q2, [sp, #0x60]
005ABBDF8  ldr      x10, [sp, #0x70]
005ABBDFC  ldr      x9, [x8, #0x18]
005ABBE00  ldr      x0, [x8, #0x40]
005ABBE04  stp      q0, q1, [sp, #0x80]
005ABBE08  str      q2, [sp, #0xa0]
005ABBE0C  str      x10, [sp, #0xb0]
005ABBE10  ldr      x2, [x8, #0x28]
005ABBE14  add      x1, sp, #0x80
005ABBE18  blr      x9
005ABBE1C  tbz      w0, #0, #0x5abbcec
005ABBE20  ldr      x8, [x19, #0x30]
005ABBE24  ldp      q0, q1, [sp, #0x40]
005ABBE28  ldr      q2, [sp, #0x60]
005ABBE2C  ldr      x9, [sp, #0x70]
005ABBE30  stp      q0, q1, [sp]
005ABBE34  str      q2, [sp, #0x20]
005ABBE38  str      x9, [sp, #0x30]
005ABBE3C  cbz      x8, #0x5abbea4
005ABBE40  ldp      q0, q1, [sp]
005ABBE44  ldr      q2, [sp, #0x20]
005ABBE48  ldr      x10, [sp, #0x30]
005ABBE4C  ldr      x9, [x8, #0x18]
005ABBE50  ldr      x0, [x8, #0x40]
005ABBE54  stp      q0, q1, [sp, #0x80]
005ABBE58  str      q2, [sp, #0xa0]
005ABBE5C  str      x10, [sp, #0xb0]
005ABBE60  ldr      x2, [x8, #0x28]
005ABBE64  add      x1, sp, #0x80
005ABBE68  blr      x9
005ABBE6C  str      x0, [x19, #0x18]
005ABBE70  mov      w0, #1
005ABBE74  b        #0x5abbe90 ; 
005ABBE78  cbz      x19, #0x5abbea4
005ABBE7C  ldr      x8, [x19]
005ABBE80  mov      x0, x19
005ABBE84  ldp      x9, x1, [x8, #0x1f8]
005ABBE88  blr      x9
005ABBE8C  mov      w0, wzr
005ABBE90  ldp      x20, x19, [sp, #0xe0]
005ABBE94  ldp      x22, x21, [sp, #0xd0]
005ABBE98  ldr      x30, [sp, #0xc0]
005ABBE9C  add      sp, sp, #0xf0
005ABBEA0  ret      
005ABBEA4  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalEquipData>$$Where
; RVA 0x5ABBEA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBEA8  stp      x30, x21, [sp, #-0x20]!
005ABBEAC  stp      x20, x19, [sp, #0x10]
005ABBEB0  ldr      x8, [x2, #0x20]
005ABBEB4  mov      x20, x2
005ABBEB8  mov      x19, x1
005ABBEBC  mov      x21, x0
005ABBEC0  ldr      x8, [x8, #0xc0]
005ABBEC4  ldr      x8, [x8, #0x88]
005ABBEC8  ldrb     w9, [x8, #0x135]
005ABBECC  tbnz     w9, #0, #0x5abbedc
005ABBED0  mov      x0, x8
005ABBED4  bl       #0x3a7e60c ; 
005ABBED8  mov      x8, x0
005ABBEDC  mov      x0, x8
005ABBEE0  bl       #0x382bfa0 ; 
005ABBEE4  ldr      x8, [x20, #0x20]
005ABBEE8  mov      x1, x21
005ABBEEC  mov      x2, x19
005ABBEF0  mov      x20, x0
005ABBEF4  ldr      x8, [x8, #0xc0]
005ABBEF8  ldr      x3, [x8, #0x90]
005ABBEFC  bl       #0x59c74f4 ; System.Linq.Enumerable.WhereEnumerableIterator<CalEquipData>$$.ctor
005ABBF00  mov      x0, x20
005ABBF04  ldp      x20, x19, [sp, #0x10]
005ABBF08  ldp      x30, x21, [sp], #0x20
005ABBF0C  ret      

