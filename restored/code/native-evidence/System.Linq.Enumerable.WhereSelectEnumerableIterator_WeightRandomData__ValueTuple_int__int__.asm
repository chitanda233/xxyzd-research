; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
; RVA 0x5AB9DF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005AB9DF0  str      x30, [sp, #-0x30]!
005AB9DF4  stp      x22, x21, [sp, #0x10]
005AB9DF8  stp      x20, x19, [sp, #0x20]
005AB9DFC  ldr      x8, [x4, #0x20]
005AB9E00  mov      x21, x1
005AB9E04  mov      x19, x3
005AB9E08  mov      x20, x2
005AB9E0C  ldr      x8, [x8, #0xc0]
005AB9E10  mov      x22, x0
005AB9E14  ldr      x1, [x8]
005AB9E18  bl       #0x4a72aec ; System.Linq.Enumerable.Iterator<ValueTuple<int, int>>$$.ctor
005AB9E1C  mov      x0, x22
005AB9E20  str      x21, [x0, #0x20]!
005AB9E24  mov      x1, x21
005AB9E28  bl       #0x382bcb8 ; 
005AB9E2C  mov      x0, x22
005AB9E30  str      x20, [x0, #0x28]!
005AB9E34  mov      x1, x20
005AB9E38  bl       #0x382bcb8 ; 
005AB9E3C  str      x19, [x22, #0x30]!
005AB9E40  mov      x0, x22
005AB9E44  mov      x1, x19
005AB9E48  ldp      x20, x19, [sp, #0x20]
005AB9E4C  ldp      x22, x21, [sp, #0x10]
005AB9E50  ldr      x30, [sp], #0x30
005AB9E54  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, ValueTuple<int, int>>$$Clone
; RVA 0x5AB9E58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005AB9E58  str      x30, [sp, #-0x30]!
005AB9E5C  stp      x22, x21, [sp, #0x10]
005AB9E60  stp      x20, x19, [sp, #0x20]
005AB9E64  ldr      x9, [x1, #0x20]
005AB9E68  mov      x8, x0
005AB9E6C  ldp      x21, x20, [x8, #0x20]
005AB9E70  ldr      x22, [x8, #0x30]
005AB9E74  ldr      x9, [x9, #0xc0]
005AB9E78  mov      x19, x1
005AB9E7C  ldr      x0, [x9, #0x18]
005AB9E80  ldrb     w9, [x0, #0x135]
005AB9E84  tbnz     w9, #0, #0x5ab9e8c
005AB9E88  bl       #0x3a7e60c ; 
005AB9E8C  bl       #0x382bfa0 ; 
005AB9E90  ldr      x8, [x19, #0x20]
005AB9E94  mov      x1, x21
005AB9E98  mov      x2, x20
005AB9E9C  mov      x3, x22
005AB9EA0  ldr      x8, [x8, #0xc0]
005AB9EA4  mov      x19, x0
005AB9EA8  ldr      x4, [x8, #0x30]
005AB9EAC  bl       #0x5ab9df0 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
005AB9EB0  mov      x0, x19
005AB9EB4  ldp      x20, x19, [sp, #0x20]
005AB9EB8  ldp      x22, x21, [sp, #0x10]
005AB9EBC  ldr      x30, [sp], #0x30
005AB9EC0  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, ValueTuple<int, int>>$$Dispose
; RVA 0x5AB9EC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005AB9EC4  str      x30, [sp, #-0x30]!
005AB9EC8  stp      x22, x21, [sp, #0x10]
005AB9ECC  stp      x20, x19, [sp, #0x20]
005AB9ED0  adrp     x21, #0x9595000
005AB9ED4  ldrb     w8, [x21, #0x443]
005AB9ED8  mov      x19, x1
005AB9EDC  mov      x20, x0
005AB9EE0  tbnz     w8, #0, #0x5ab9ef8
005AB9EE4  adrp     x0, #0x8ebf000
005AB9EE8  ldr      x0, [x0, #0x4e8]
005AB9EEC  bl       #0x382bd14 ; 
005AB9EF0  mov      w8, #1
005AB9EF4  strb     w8, [x21, #0x443]
005AB9EF8  mov      x21, x20
005AB9EFC  ldr      x22, [x21, #0x38]!
005AB9F00  cbz      x22, #0x5ab9f64
005AB9F04  adrp     x10, #0x8ebf000
005AB9F08  ldr      x8, [x22]
005AB9F0C  ldr      x10, [x10, #0x4e8]
005AB9F10  ldrh     w9, [x8, #0x12e]
005AB9F14  ldr      x1, [x10]
005AB9F18  cbz      x9, #0x5ab9f3c
005AB9F1C  ldr      x10, [x8, #0xb0]
005AB9F20  add      x10, x10, #8
005AB9F24  ldur     x11, [x10, #-8]
005AB9F28  cmp      x11, x1
005AB9F2C  b.eq     #0x5ab9f4c
005AB9F30  subs     x9, x9, #1
005AB9F34  add      x10, x10, #0x10
005AB9F38  b.ne     #0x5ab9f24
005AB9F3C  mov      x0, x22
005AB9F40  mov      w2, wzr
005AB9F44  bl       #0x3a7e710 ; 
005AB9F48  b        #0x5ab9f58 ; 
005AB9F4C  ldrsw    x9, [x10]
005AB9F50  add      x8, x8, x9, lsl #4
005AB9F54  add      x0, x8, #0x138
005AB9F58  ldp      x8, x1, [x0]
005AB9F5C  mov      x0, x22
005AB9F60  blr      x8
005AB9F64  mov      x0, x21
005AB9F68  mov      x1, xzr
005AB9F6C  str      xzr, [x20, #0x38]
005AB9F70  bl       #0x382bcb8 ; 
005AB9F74  ldr      x8, [x19, #0x20]
005AB9F78  mov      x0, x20
005AB9F7C  ldp      x20, x19, [sp, #0x20]
005AB9F80  ldp      x22, x21, [sp, #0x10]
005AB9F84  ldr      x8, [x8, #0xc0]
005AB9F88  ldr      x1, [x8, #0x48]
005AB9F8C  ldr      x30, [sp], #0x30
005AB9F90  b        #0x4a72b28 ; System.Linq.Enumerable.Iterator<ValueTuple<int, int>>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, ValueTuple<int, int>>$$MoveNext
; RVA 0x5AB9F94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005AB9F94  sub      sp, sp, #0xf0
005AB9F98  str      x30, [sp, #0xc0]
005AB9F9C  stp      x22, x21, [sp, #0xd0]
005AB9FA0  stp      x20, x19, [sp, #0xe0]
005AB9FA4  adrp     x21, #0x9595000
005AB9FA8  ldrb     w8, [x21, #0x444]
005AB9FAC  mov      x20, x1
005AB9FB0  mov      x19, x0
005AB9FB4  tbnz     w8, #0, #0x5ab9fcc
005AB9FB8  adrp     x0, #0x8ebf000
005AB9FBC  ldr      x0, [x0, #0x4f0]
005AB9FC0  bl       #0x382bd14 ; 
005AB9FC4  mov      w8, #1
005AB9FC8  strb     w8, [x21, #0x444]
005AB9FCC  ldr      w8, [x19, #0x14]
005AB9FD0  adrp     x22, #0x8ebf000
005AB9FD4  ldr      x22, [x22, #0x4f0]
005AB9FD8  cmp      w8, #2
005AB9FDC  b.eq     #0x5aba080
005AB9FE0  cmp      w8, #1
005AB9FE4  b.ne     #0x5aba220
005AB9FE8  ldr      x21, [x19, #0x20]
005AB9FEC  cbz      x21, #0x5aba238
005AB9FF0  ldr      x8, [x20, #0x20]
005AB9FF4  ldr      x8, [x8, #0xc0]
005AB9FF8  ldr      x1, [x8, #0x10]
005AB9FFC  ldrb     w8, [x1, #0x135]
005ABA000  tbnz     w8, #0, #0x5aba010
005ABA004  mov      x0, x1
005ABA008  bl       #0x3a7e60c ; 
005ABA00C  mov      x1, x0
005ABA010  ldr      x8, [x21]
005ABA014  ldrh     w9, [x8, #0x12e]
005ABA018  cbz      x9, #0x5aba03c
005ABA01C  ldr      x10, [x8, #0xb0]
005ABA020  add      x10, x10, #8
005ABA024  ldur     x11, [x10, #-8]
005ABA028  cmp      x11, x1
005ABA02C  b.eq     #0x5aba04c
005ABA030  subs     x9, x9, #1
005ABA034  add      x10, x10, #0x10
005ABA038  b.ne     #0x5aba024
005ABA03C  mov      x0, x21
005ABA040  mov      w2, wzr
005ABA044  bl       #0x3a7e710 ; 
005ABA048  b        #0x5aba058 ; 
005ABA04C  ldrsw    x9, [x10]
005ABA050  add      x8, x8, x9, lsl #4
005ABA054  add      x0, x8, #0x138
005ABA058  ldp      x8, x1, [x0]
005ABA05C  mov      x0, x21
005ABA060  blr      x8
005ABA064  mov      x21, x19
005ABA068  str      x0, [x21, #0x38]!
005ABA06C  mov      x1, x0
005ABA070  mov      x0, x21
005ABA074  bl       #0x382bcb8 ; 
005ABA078  mov      w8, #2
005ABA07C  stur     w8, [x21, #-0x24]
005ABA080  ldr      x21, [x19, #0x38]
005ABA084  cbz      x21, #0x5aba238
005ABA088  ldr      x8, [x21]
005ABA08C  ldr      x1, [x22]
005ABA090  ldrh     w9, [x8, #0x12e]
005ABA094  cbz      x9, #0x5aba0b8
005ABA098  ldr      x10, [x8, #0xb0]
005ABA09C  add      x10, x10, #8
005ABA0A0  ldur     x11, [x10, #-8]
005ABA0A4  cmp      x11, x1
005ABA0A8  b.eq     #0x5aba0c8
005ABA0AC  subs     x9, x9, #1
005ABA0B0  add      x10, x10, #0x10
005ABA0B4  b.ne     #0x5aba0a0
005ABA0B8  mov      x0, x21
005ABA0BC  mov      w2, wzr
005ABA0C0  bl       #0x3a7e710 ; 
005ABA0C4  b        #0x5aba0d4 ; 
005ABA0C8  ldrsw    x9, [x10]
005ABA0CC  add      x8, x8, x9, lsl #4
005ABA0D0  add      x0, x8, #0x138
005ABA0D4  ldp      x8, x1, [x0]
005ABA0D8  mov      x0, x21
005ABA0DC  blr      x8
005ABA0E0  tbz      w0, #0, #0x5aba20c
005ABA0E4  ldr      x21, [x19, #0x38]
005ABA0E8  cbz      x21, #0x5aba238
005ABA0EC  ldr      x8, [x20, #0x20]
005ABA0F0  ldr      x8, [x8, #0xc0]
005ABA0F4  ldr      x1, [x8, #0x40]
005ABA0F8  ldrb     w8, [x1, #0x135]
005ABA0FC  tbnz     w8, #0, #0x5aba10c
005ABA100  mov      x0, x1
005ABA104  bl       #0x3a7e60c ; 
005ABA108  mov      x1, x0
005ABA10C  ldr      x8, [x21]
005ABA110  ldrh     w9, [x8, #0x12e]
005ABA114  cbz      x9, #0x5aba138
005ABA118  ldr      x10, [x8, #0xb0]
005ABA11C  add      x10, x10, #8
005ABA120  ldur     x11, [x10, #-8]
005ABA124  cmp      x11, x1
005ABA128  b.eq     #0x5aba148
005ABA12C  subs     x9, x9, #1
005ABA130  add      x10, x10, #0x10
005ABA134  b.ne     #0x5aba120
005ABA138  mov      x0, x21
005ABA13C  mov      w2, wzr
005ABA140  bl       #0x3a7e710 ; 
005ABA144  b        #0x5aba154 ; 
005ABA148  ldrsw    x9, [x10]
005ABA14C  add      x8, x8, x9, lsl #4
005ABA150  add      x0, x8, #0x138
005ABA154  ldp      x9, x1, [x0]
005ABA158  add      x8, sp, #0x80
005ABA15C  mov      x0, x21
005ABA160  blr      x9
005ABA164  ldp      q0, q1, [sp, #0x80]
005ABA168  ldr      q2, [sp, #0xa0]
005ABA16C  ldr      x8, [sp, #0xb0]
005ABA170  stp      q0, q1, [sp, #0x40]
005ABA174  str      q2, [sp, #0x60]
005ABA178  str      x8, [sp, #0x70]
005ABA17C  ldr      x8, [x19, #0x28]
005ABA180  cbz      x8, #0x5aba1b4
005ABA184  ldp      q0, q1, [sp, #0x40]
005ABA188  ldr      q2, [sp, #0x60]
005ABA18C  ldr      x10, [sp, #0x70]
005ABA190  ldr      x9, [x8, #0x18]
005ABA194  ldr      x0, [x8, #0x40]
005ABA198  stp      q0, q1, [sp, #0x80]
005ABA19C  str      q2, [sp, #0xa0]
005ABA1A0  str      x10, [sp, #0xb0]
005ABA1A4  ldr      x2, [x8, #0x28]
005ABA1A8  add      x1, sp, #0x80
005ABA1AC  blr      x9
005ABA1B0  tbz      w0, #0, #0x5aba080
005ABA1B4  ldr      x8, [x19, #0x30]
005ABA1B8  ldp      q0, q1, [sp, #0x40]
005ABA1BC  ldr      q2, [sp, #0x60]
005ABA1C0  ldr      x9, [sp, #0x70]
005ABA1C4  stp      q0, q1, [sp]
005ABA1C8  str      q2, [sp, #0x20]
005ABA1CC  str      x9, [sp, #0x30]
005ABA1D0  cbz      x8, #0x5aba238
005ABA1D4  ldp      q0, q1, [sp]
005ABA1D8  ldr      q2, [sp, #0x20]
005ABA1DC  ldr      x10, [sp, #0x30]
005ABA1E0  ldr      x9, [x8, #0x18]
005ABA1E4  ldr      x0, [x8, #0x40]
005ABA1E8  stp      q0, q1, [sp, #0x80]
005ABA1EC  str      q2, [sp, #0xa0]
005ABA1F0  str      x10, [sp, #0xb0]
005ABA1F4  ldr      x2, [x8, #0x28]
005ABA1F8  add      x1, sp, #0x80
005ABA1FC  blr      x9
005ABA200  str      x0, [x19, #0x18]
005ABA204  mov      w0, #1
005ABA208  b        #0x5aba224 ; 
005ABA20C  cbz      x19, #0x5aba238
005ABA210  ldr      x8, [x19]
005ABA214  mov      x0, x19
005ABA218  ldp      x9, x1, [x8, #0x1f8]
005ABA21C  blr      x9
005ABA220  mov      w0, wzr
005ABA224  ldp      x20, x19, [sp, #0xe0]
005ABA228  ldp      x22, x21, [sp, #0xd0]
005ABA22C  ldr      x30, [sp, #0xc0]
005ABA230  add      sp, sp, #0xf0
005ABA234  ret      
005ABA238  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, ValueTuple<int, int>>$$Where
; RVA 0x5ABA23C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA23C  stp      x30, x21, [sp, #-0x20]!
005ABA240  stp      x20, x19, [sp, #0x10]
005ABA244  ldr      x8, [x2, #0x20]
005ABA248  mov      x20, x2
005ABA24C  mov      x19, x1
005ABA250  mov      x21, x0
005ABA254  ldr      x8, [x8, #0xc0]
005ABA258  ldr      x8, [x8, #0x88]
005ABA25C  ldrb     w9, [x8, #0x135]
005ABA260  tbnz     w9, #0, #0x5aba270
005ABA264  mov      x0, x8
005ABA268  bl       #0x3a7e60c ; 
005ABA26C  mov      x8, x0
005ABA270  mov      x0, x8
005ABA274  bl       #0x382bfa0 ; 
005ABA278  ldr      x8, [x20, #0x20]
005ABA27C  mov      x1, x21
005ABA280  mov      x2, x19
005ABA284  mov      x20, x0
005ABA288  ldr      x8, [x8, #0xc0]
005ABA28C  ldr      x3, [x8, #0x90]
005ABA290  bl       #0x59c431c ; System.Linq.Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>$$.ctor
005ABA294  mov      x0, x20
005ABA298  ldp      x20, x19, [sp, #0x10]
005ABA29C  ldp      x30, x21, [sp], #0x20
005ABA2A0  ret      

