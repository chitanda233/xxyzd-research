; LocalModels.Bean.Event_Event$$readImpl
; RVA 0x6A7A974; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7A974  stp      x30, x21, [sp, #-0x20]!
006A7A978  stp      x20, x19, [sp, #0x10]
006A7A97C  adrp     x20, #0x959d000
006A7A980  adrp     x21, #0x8f37000
006A7A984  ldrb     w8, [x20, #0xea8]
006A7A988  ldr      x21, [x21, #0xd98]
006A7A98C  mov      x19, x0
006A7A990  tbnz     w8, #0, #0x6a7a9a8
006A7A994  adrp     x0, #0x8f37000
006A7A998  ldr      x0, [x0, #0xd98]
006A7A99C  bl       #0x382bd14 ; 
006A7A9A0  mov      w8, #1
006A7A9A4  strb     w8, [x20, #0xea8]
006A7A9A8  ldr      x1, [x21]
006A7A9AC  ldrb     w8, [x1, #0x53]
006A7A9B0  tbnz     w8, #5, #0x6a7aa00
006A7A9B4  mov      x0, x19
006A7A9B8  mov      x1, xzr
006A7A9BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7A9C0  adrp     x21, #0x959e000
006A7A9C4  ldrb     w8, [x21, #0x4c1]
006A7A9C8  mov      w20, w0
006A7A9CC  cbnz     w8, #0x6a7a9e4
006A7A9D0  adrp     x0, #0x8f37000
006A7A9D4  ldr      x0, [x0, #0xd50]
006A7A9D8  bl       #0x382bd14 ; 
006A7A9DC  mov      w8, #1
006A7A9E0  strb     w8, [x21, #0x4c1]
006A7A9E4  adrp     x8, #0x8f37000
006A7A9E8  ldr      x8, [x8, #0xd50]
006A7A9EC  ldr      x2, [x8]
006A7A9F0  ldrb     w8, [x2, #0x53]
006A7A9F4  tbnz     w8, #5, #0x6a7aa14
006A7A9F8  str      w20, [x19, #0x20]
006A7A9FC  b        #0x6a7aa24 ; 
006A7AA00  ldr      x2, [x1, #0x60]
006A7AA04  mov      x0, x19
006A7AA08  ldp      x20, x19, [sp, #0x10]
006A7AA0C  ldp      x30, x21, [sp], #0x20
006A7AA10  br       x2
006A7AA14  ldr      x8, [x2, #0x60]
006A7AA18  mov      x0, x19
006A7AA1C  mov      w1, w20
006A7AA20  blr      x8
006A7AA24  mov      x0, x19
006A7AA28  mov      x1, xzr
006A7AA2C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7AA30  adrp     x21, #0x959e000
006A7AA34  ldrb     w8, [x21, #0x4c2]
006A7AA38  mov      x20, x0
006A7AA3C  cbnz     w8, #0x6a7aa54
006A7AA40  adrp     x0, #0x8f37000
006A7AA44  ldr      x0, [x0, #0xd60]
006A7AA48  bl       #0x382bd14 ; 
006A7AA4C  mov      w8, #1
006A7AA50  strb     w8, [x21, #0x4c2]
006A7AA54  adrp     x8, #0x8f37000
006A7AA58  ldr      x8, [x8, #0xd60]
006A7AA5C  ldr      x2, [x8]
006A7AA60  ldrb     w8, [x2, #0x53]
006A7AA64  tbnz     w8, #5, #0x6a7aa7c
006A7AA68  mov      x0, x19
006A7AA6C  str      x20, [x0, #0x28]!
006A7AA70  mov      x1, x20
006A7AA74  bl       #0x382bcb8 ; 
006A7AA78  b        #0x6a7aa8c ; 
006A7AA7C  ldr      x8, [x2, #0x60]
006A7AA80  mov      x0, x19
006A7AA84  mov      x1, x20
006A7AA88  blr      x8
006A7AA8C  mov      x0, x19
006A7AA90  mov      x1, xzr
006A7AA94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7AA98  adrp     x21, #0x959e000
006A7AA9C  ldrb     w8, [x21, #0x4c3]
006A7AAA0  mov      w20, w0
006A7AAA4  cbnz     w8, #0x6a7aabc
006A7AAA8  adrp     x0, #0x8f37000
006A7AAAC  ldr      x0, [x0, #0xd70]
006A7AAB0  bl       #0x382bd14 ; 
006A7AAB4  mov      w8, #1
006A7AAB8  strb     w8, [x21, #0x4c3]
006A7AABC  adrp     x8, #0x8f37000
006A7AAC0  ldr      x8, [x8, #0xd70]
006A7AAC4  ldr      x2, [x8]
006A7AAC8  ldrb     w8, [x2, #0x53]
006A7AACC  tbnz     w8, #5, #0x6a7aad8
006A7AAD0  str      w20, [x19, #0x30]
006A7AAD4  b        #0x6a7aae8 ; 
006A7AAD8  ldr      x8, [x2, #0x60]
006A7AADC  mov      x0, x19
006A7AAE0  mov      w1, w20
006A7AAE4  blr      x8
006A7AAE8  mov      x0, x19
006A7AAEC  mov      x1, xzr
006A7AAF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7AAF4  adrp     x21, #0x959e000
006A7AAF8  ldrb     w8, [x21, #0x4c4]
006A7AAFC  mov      w20, w0
006A7AB00  cbnz     w8, #0x6a7ab18
006A7AB04  adrp     x0, #0x8f37000
006A7AB08  ldr      x0, [x0, #0xd80]
006A7AB0C  bl       #0x382bd14 ; 
006A7AB10  mov      w8, #1
006A7AB14  strb     w8, [x21, #0x4c4]
006A7AB18  adrp     x8, #0x8f37000
006A7AB1C  ldr      x8, [x8, #0xd80]
006A7AB20  ldr      x2, [x8]
006A7AB24  ldrb     w8, [x2, #0x53]
006A7AB28  tbnz     w8, #5, #0x6a7ab34
006A7AB2C  str      w20, [x19, #0x34]
006A7AB30  b        #0x6a7ab44 ; 
006A7AB34  ldr      x8, [x2, #0x60]
006A7AB38  mov      x0, x19
006A7AB3C  mov      w1, w20
006A7AB40  blr      x8
006A7AB44  mov      x0, x19
006A7AB48  mov      x1, xzr
006A7AB4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7AB50  adrp     x21, #0x959e000
006A7AB54  ldrb     w8, [x21, #0x4c5]
006A7AB58  mov      w20, w0
006A7AB5C  cbnz     w8, #0x6a7ab74
006A7AB60  adrp     x0, #0x8f37000
006A7AB64  ldr      x0, [x0, #0xd90]
006A7AB68  bl       #0x382bd14 ; 
006A7AB6C  mov      w8, #1
006A7AB70  strb     w8, [x21, #0x4c5]
006A7AB74  adrp     x8, #0x8f37000
006A7AB78  ldr      x8, [x8, #0xd90]
006A7AB7C  ldr      x2, [x8]
006A7AB80  ldrb     w8, [x2, #0x53]
006A7AB84  tbnz     w8, #5, #0x6a7ab90
006A7AB88  str      w20, [x19, #0x38]
006A7AB8C  b        #0x6a7aba0 ; 
006A7AB90  ldr      x8, [x2, #0x60]
006A7AB94  mov      x0, x19
006A7AB98  mov      w1, w20
006A7AB9C  blr      x8
006A7ABA0  ldp      x20, x19, [sp, #0x10]
006A7ABA4  mov      w0, #1
006A7ABA8  ldp      x30, x21, [sp], #0x20
006A7ABAC  ret      

