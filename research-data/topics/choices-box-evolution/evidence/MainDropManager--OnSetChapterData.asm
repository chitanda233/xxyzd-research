; HotFix.BattleLogic.MainDropManager$$OnSetChapterData
; RVA 0x6671934; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671934  stp      x30, x23, [sp, #-0x30]!
006671938  stp      x22, x21, [sp, #0x10]
00667193C  stp      x20, x19, [sp, #0x20]
006671940  adrp     x21, #0x9599000
006671944  adrp     x22, #0x8f0f000
006671948  ldrb     w8, [x21, #0xde4]
00667194C  ldr      x22, [x22, #0x760] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.OnSetChapterData() @ 0x928dc18
006671950  mov      x20, x1
006671954  mov      x19, x0
006671958  tbnz     w8, #0, #0x6671988
00667195C  adrp     x0, #0x8f08000
006671960  ldr      x0, [x0, #0xab0] ; GLOBAL LocalModels.Bean.IMainChapter_TypeInfo @ 0x91e9d80
006671964  bl       #0x382bd14 ; 
006671968  adrp     x0, #0x8ec1000
00667196C  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
006671970  bl       #0x382bd14 ; 
006671974  adrp     x0, #0x8f0f000
006671978  ldr      x0, [x0, #0x760] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.OnSetChapterData() @ 0x928dc18
00667197C  bl       #0x382bd14 ; 
006671980  mov      w8, #1
006671984  strb     w8, [x21, #0xde4]
006671988  ldr      x2, [x22]
00667198C  ldrb     w8, [x2, #0x53]
006671990  tbnz     w8, #5, #0x66719d8
006671994  adrp     x23, #0x8f08000
006671998  ldr      x23, [x23, #0xab0] ; GLOBAL LocalModels.Bean.IMainChapter_TypeInfo @ 0x91e9d80
00667199C  cbz      x20, #0x66719f4
0066719A0  ldr      x21, [x23]
0066719A4  mov      x0, x20
0066719A8  mov      x1, x21
0066719AC  bl       #0x382be90 ; 
0066719B0  cbz      x0, #0x6671b38
0066719B4  mov      x21, x19
0066719B8  str      x0, [x21, #0x50]!
0066719BC  ldr      x22, [x23]
0066719C0  mov      x0, x20
0066719C4  mov      x1, x22
0066719C8  bl       #0x382be90 ; 
0066719CC  cbz      x0, #0x6671b44
0066719D0  mov      x1, x0
0066719D4  b        #0x6671a00 ; 
0066719D8  ldr      x3, [x2, #0x60]
0066719DC  mov      x0, x19
0066719E0  mov      x1, x20
0066719E4  ldp      x20, x19, [sp, #0x20]
0066719E8  ldp      x22, x21, [sp, #0x10]
0066719EC  ldp      x30, x23, [sp], #0x30
0066719F0  br       x3
0066719F4  mov      x21, x19
0066719F8  mov      x1, xzr
0066719FC  str      xzr, [x21, #0x50]!
006671A00  mov      x0, x21
006671A04  bl       #0x382bcb8 ; 
006671A08  ldr      x20, [x21]
006671A0C  cbz      x20, #0x6671b34
006671A10  ldr      x8, [x20]
006671A14  ldr      x1, [x23]
006671A18  ldrh     w9, [x8, #0x12e]
006671A1C  cbz      x9, #0x6671a40
006671A20  ldr      x10, [x8, #0xb0]
006671A24  add      x10, x10, #8
006671A28  ldur     x11, [x10, #-8]
006671A2C  cmp      x11, x1
006671A30  b.eq     #0x6671a50
006671A34  subs     x9, x9, #1
006671A38  add      x10, x10, #0x10
006671A3C  b.ne     #0x6671a28
006671A40  mov      w2, #6
006671A44  mov      x0, x20
006671A48  bl       #0x3a7e710 ; 
006671A4C  b        #0x6671a60 ; 
006671A50  ldr      w9, [x10]
006671A54  add      w9, w9, #6
006671A58  add      x8, x8, w9, sxtw #4
006671A5C  add      x0, x8, #0x138
006671A60  ldp      x8, x1, [x0]
006671A64  mov      x0, x20
006671A68  blr      x8
006671A6C  cbz      x0, #0x6671b34
006671A70  ldr      x8, [x0, #0x18]
006671A74  ldr      x20, [x19, #0x50]
006671A78  str      w8, [x19, #0x68]
006671A7C  cbz      x20, #0x6671b34
006671A80  ldr      x8, [x20]
006671A84  ldr      x1, [x23]
006671A88  ldrh     w9, [x8, #0x12e]
006671A8C  cbz      x9, #0x6671ab0
006671A90  ldr      x10, [x8, #0xb0]
006671A94  add      x10, x10, #8
006671A98  ldur     x11, [x10, #-8]
006671A9C  cmp      x11, x1
006671AA0  b.eq     #0x6671ac0
006671AA4  subs     x9, x9, #1
006671AA8  add      x10, x10, #0x10
006671AAC  b.ne     #0x6671a98
006671AB0  mov      w2, #0xc
006671AB4  mov      x0, x20
006671AB8  bl       #0x3a7e710 ; 
006671ABC  b        #0x6671ad0 ; 
006671AC0  ldr      w9, [x10]
006671AC4  add      w9, w9, #0xc
006671AC8  add      x8, x8, w9, sxtw #4
006671ACC  add      x0, x8, #0x138
006671AD0  ldp      x8, x1, [x0]
006671AD4  mov      x0, x20
006671AD8  blr      x8
006671ADC  cbz      x0, #0x6671b34
006671AE0  ldr      x8, [x0, #0x18]
006671AE4  adrp     x20, #0x8ec1000
006671AE8  ldr      w1, [x19, #0x68]
006671AEC  str      w8, [x19, #0x6c]
006671AF0  ldr      x20, [x20, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
006671AF4  ldr      x0, [x20]
006671AF8  bl       #0x382bdfc ; 
006671AFC  mov      x1, x0
006671B00  mov      x0, x19
006671B04  str      x1, [x0, #0x58]!
006671B08  bl       #0x382bcb8 ; 
006671B0C  ldr      w1, [x19, #0x6c]
006671B10  ldr      x0, [x20]
006671B14  bl       #0x382bdfc ; 
006671B18  str      x0, [x19, #0x60]!
006671B1C  mov      x1, x0
006671B20  mov      x0, x19
006671B24  ldp      x20, x19, [sp, #0x20]
006671B28  ldp      x22, x21, [sp, #0x10]
006671B2C  ldp      x30, x23, [sp], #0x30
006671B30  b        #0x382bcb8 ; 
006671B34  bl       #0x382bfb8 ; 
006671B38  mov      x0, x20
006671B3C  mov      x1, x21
006671B40  bl       #0x382c354 ; 
006671B44  mov      x0, x20
006671B48  mov      x1, x22
006671B4C  bl       #0x382c354 ; 

