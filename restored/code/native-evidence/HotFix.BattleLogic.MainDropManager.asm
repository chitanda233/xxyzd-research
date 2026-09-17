; HotFix.BattleLogic.MainDropManager$$get_WaveGold
; RVA 0x667179C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00667179C  stp      x30, x21, [sp, #-0x20]!
0066717A0  stp      x20, x19, [sp, #0x10]
0066717A4  adrp     x20, #0x9599000
0066717A8  adrp     x21, #0x8f0f000
0066717AC  ldrb     w8, [x20, #0xde2]
0066717B0  ldr      x21, [x21, #0x750]
0066717B4  mov      x19, x0
0066717B8  tbnz     w8, #0, #0x66717dc
0066717BC  adrp     x0, #0x8f08000
0066717C0  ldr      x0, [x0, #0xab0]
0066717C4  bl       #0x382bd14 ; 
0066717C8  adrp     x0, #0x8f0f000
0066717CC  ldr      x0, [x0, #0x750]
0066717D0  bl       #0x382bd14 ; 
0066717D4  mov      w8, #1
0066717D8  strb     w8, [x20, #0xde2]
0066717DC  ldr      x1, [x21]
0066717E0  ldrb     w8, [x1, #0x53]
0066717E4  tbnz     w8, #5, #0x6671838
0066717E8  ldr      x19, [x19, #0x50]
0066717EC  cbz      x19, #0x6671864
0066717F0  adrp     x10, #0x8f08000
0066717F4  ldr      x8, [x19]
0066717F8  ldr      x10, [x10, #0xab0]
0066717FC  ldrh     w9, [x8, #0x12e]
006671800  ldr      x1, [x10]
006671804  cbz      x9, #0x6671828
006671808  ldr      x10, [x8, #0xb0]
00667180C  add      x10, x10, #8
006671810  ldur     x11, [x10, #-8]
006671814  cmp      x11, x1
006671818  b.eq     #0x6671840
00667181C  subs     x9, x9, #1
006671820  add      x10, x10, #0x10
006671824  b.ne     #0x6671810
006671828  mov      w2, #2
00667182C  mov      x0, x19
006671830  bl       #0x3a7e710 ; 
006671834  b        #0x6671850 ; 
006671838  ldr      x2, [x1, #0x60]
00667183C  b        #0x6671854 ; 
006671840  ldr      w9, [x10]
006671844  add      w9, w9, #2
006671848  add      x8, x8, w9, sxtw #4
00667184C  add      x0, x8, #0x138
006671850  ldp      x2, x1, [x0]
006671854  mov      x0, x19
006671858  ldp      x20, x19, [sp, #0x10]
00667185C  ldp      x30, x21, [sp], #0x20
006671860  br       x2
006671864  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.MainDropManager$$get_WaveExp
; RVA 0x6671868; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671868  stp      x30, x21, [sp, #-0x20]!
00667186C  stp      x20, x19, [sp, #0x10]
006671870  adrp     x20, #0x9599000
006671874  adrp     x21, #0x8f0f000
006671878  ldrb     w8, [x20, #0xde3]
00667187C  ldr      x21, [x21, #0x758]
006671880  mov      x19, x0
006671884  tbnz     w8, #0, #0x66718a8
006671888  adrp     x0, #0x8f08000
00667188C  ldr      x0, [x0, #0xab0]
006671890  bl       #0x382bd14 ; 
006671894  adrp     x0, #0x8f0f000
006671898  ldr      x0, [x0, #0x758]
00667189C  bl       #0x382bd14 ; 
0066718A0  mov      w8, #1
0066718A4  strb     w8, [x20, #0xde3]
0066718A8  ldr      x1, [x21]
0066718AC  ldrb     w8, [x1, #0x53]
0066718B0  tbnz     w8, #5, #0x6671904
0066718B4  ldr      x19, [x19, #0x50]
0066718B8  cbz      x19, #0x6671930
0066718BC  adrp     x10, #0x8f08000
0066718C0  ldr      x8, [x19]
0066718C4  ldr      x10, [x10, #0xab0]
0066718C8  ldrh     w9, [x8, #0x12e]
0066718CC  ldr      x1, [x10]
0066718D0  cbz      x9, #0x66718f4
0066718D4  ldr      x10, [x8, #0xb0]
0066718D8  add      x10, x10, #8
0066718DC  ldur     x11, [x10, #-8]
0066718E0  cmp      x11, x1
0066718E4  b.eq     #0x667190c
0066718E8  subs     x9, x9, #1
0066718EC  add      x10, x10, #0x10
0066718F0  b.ne     #0x66718dc
0066718F4  mov      w2, #4
0066718F8  mov      x0, x19
0066718FC  bl       #0x3a7e710 ; 
006671900  b        #0x667191c ; 
006671904  ldr      x2, [x1, #0x60]
006671908  b        #0x6671920 ; 
00667190C  ldr      w9, [x10]
006671910  add      w9, w9, #4
006671914  add      x8, x8, w9, sxtw #4
006671918  add      x0, x8, #0x138
00667191C  ldp      x2, x1, [x0]
006671920  mov      x0, x19
006671924  ldp      x20, x19, [sp, #0x10]
006671928  ldp      x30, x21, [sp], #0x20
00667192C  br       x2
006671930  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.MainDropManager$$OnSetChapterData
; RVA 0x6671934; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671934  stp      x30, x23, [sp, #-0x30]!
006671938  stp      x22, x21, [sp, #0x10]
00667193C  stp      x20, x19, [sp, #0x20]
006671940  adrp     x21, #0x9599000
006671944  adrp     x22, #0x8f0f000
006671948  ldrb     w8, [x21, #0xde4]
00667194C  ldr      x22, [x22, #0x760]
006671950  mov      x20, x1
006671954  mov      x19, x0
006671958  tbnz     w8, #0, #0x6671988
00667195C  adrp     x0, #0x8f08000
006671960  ldr      x0, [x0, #0xab0]
006671964  bl       #0x382bd14 ; 
006671968  adrp     x0, #0x8ec1000
00667196C  ldr      x0, [x0, #0x240]
006671970  bl       #0x382bd14 ; 
006671974  adrp     x0, #0x8f0f000
006671978  ldr      x0, [x0, #0x760]
00667197C  bl       #0x382bd14 ; 
006671980  mov      w8, #1
006671984  strb     w8, [x21, #0xde4]
006671988  ldr      x2, [x22]
00667198C  ldrb     w8, [x2, #0x53]
006671990  tbnz     w8, #5, #0x66719d8
006671994  adrp     x23, #0x8f08000
006671998  ldr      x23, [x23, #0xab0]
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
006671AF0  ldr      x20, [x20, #0x240]
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

; HotFix.BattleLogic.MainDropManager$$OnDropItem
; RVA 0x6671B50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671B50  stp      x30, x25, [sp, #-0x40]!
006671B54  stp      x24, x23, [sp, #0x10]
006671B58  stp      x22, x21, [sp, #0x20]
006671B5C  stp      x20, x19, [sp, #0x30]
006671B60  adrp     x24, #0x9599000
006671B64  adrp     x25, #0x8f0f000
006671B68  ldrb     w8, [x24, #0xde5]
006671B6C  ldr      x25, [x25, #0x768]
006671B70  mov      x19, x4
006671B74  mov      x20, x3
006671B78  mov      x21, x2
006671B7C  mov      x22, x1
006671B80  mov      x23, x0
006671B84  tbnz     w8, #0, #0x6671b9c
006671B88  adrp     x0, #0x8f0f000
006671B8C  ldr      x0, [x0, #0x768]
006671B90  bl       #0x382bd14 ; 
006671B94  mov      w8, #1
006671B98  strb     w8, [x24, #0xde5]
006671B9C  ldr      x5, [x25]
006671BA0  ldrb     w8, [x5, #0x53]
006671BA4  tbnz     w8, #5, #0x6671bd8
006671BA8  mov      x0, x23
006671BAC  mov      x1, x22
006671BB0  mov      x2, x21
006671BB4  mov      x3, x20
006671BB8  mov      x4, x19
006671BBC  bl       #0x6671c2c ; HotFix.BattleLogic.MainDropManager$$CheckSpecialDrop
006671BC0  tbz      w0, #0, #0x6671c04
006671BC4  ldp      x20, x19, [sp, #0x30]
006671BC8  ldp      x22, x21, [sp, #0x20]
006671BCC  ldp      x24, x23, [sp, #0x10]
006671BD0  ldp      x30, x25, [sp], #0x40
006671BD4  ret      
006671BD8  ldr      x6, [x5, #0x60]
006671BDC  mov      x0, x23
006671BE0  mov      x1, x22
006671BE4  mov      x2, x21
006671BE8  mov      x3, x20
006671BEC  mov      x4, x19
006671BF0  ldp      x20, x19, [sp, #0x30]
006671BF4  ldp      x22, x21, [sp, #0x20]
006671BF8  ldp      x24, x23, [sp, #0x10]
006671BFC  ldp      x30, x25, [sp], #0x40
006671C00  br       x6
006671C04  mov      x0, x23
006671C08  mov      x1, x22
006671C0C  mov      x2, x21
006671C10  mov      x3, x20
006671C14  mov      x4, x19
006671C18  ldp      x20, x19, [sp, #0x30]
006671C1C  ldp      x22, x21, [sp, #0x20]
006671C20  ldp      x24, x23, [sp, #0x10]
006671C24  ldp      x30, x25, [sp], #0x40
006671C28  b        #0x6671cc8 ; HotFix.BattleLogic.MainDropManager$$AddDropItemFromGroup

; HotFix.BattleLogic.MainDropManager$$CheckSpecialDrop
; RVA 0x6671C2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671C2C  stp      x30, x25, [sp, #-0x40]!
006671C30  stp      x24, x23, [sp, #0x10]
006671C34  stp      x22, x21, [sp, #0x20]
006671C38  stp      x20, x19, [sp, #0x30]
006671C3C  adrp     x24, #0x9599000
006671C40  adrp     x25, #0x8f0f000
006671C44  ldrb     w8, [x24, #0xde6]
006671C48  ldr      x25, [x25, #0x770]
006671C4C  mov      x19, x4
006671C50  mov      x20, x3
006671C54  mov      x21, x2
006671C58  mov      x22, x1
006671C5C  mov      x23, x0
006671C60  tbnz     w8, #0, #0x6671c78
006671C64  adrp     x0, #0x8f0f000
006671C68  ldr      x0, [x0, #0x770]
006671C6C  bl       #0x382bd14 ; 
006671C70  mov      w8, #1
006671C74  strb     w8, [x24, #0xde6]
006671C78  ldr      x5, [x25]
006671C7C  ldrb     w8, [x5, #0x53]
006671C80  tbnz     w8, #5, #0x6671c9c
006671C84  ldp      x20, x19, [sp, #0x30]
006671C88  ldp      x22, x21, [sp, #0x20]
006671C8C  ldp      x24, x23, [sp, #0x10]
006671C90  mov      w0, wzr
006671C94  ldp      x30, x25, [sp], #0x40
006671C98  ret      
006671C9C  ldr      x6, [x5, #0x60]
006671CA0  mov      x0, x23
006671CA4  mov      x1, x22
006671CA8  mov      x2, x21
006671CAC  mov      x3, x20
006671CB0  mov      x4, x19
006671CB4  ldp      x20, x19, [sp, #0x30]
006671CB8  ldp      x22, x21, [sp, #0x20]
006671CBC  ldp      x24, x23, [sp, #0x10]
006671CC0  ldp      x30, x25, [sp], #0x40
006671CC4  br       x6

; HotFix.BattleLogic.MainDropManager$$AddDropItemFromGroup
; RVA 0x6671CC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671CC8  stp      x30, x25, [sp, #-0x40]!
006671CCC  stp      x24, x23, [sp, #0x10]
006671CD0  stp      x22, x21, [sp, #0x20]
006671CD4  stp      x20, x19, [sp, #0x30]
006671CD8  adrp     x24, #0x9599000
006671CDC  adrp     x25, #0x8f0f000
006671CE0  ldrb     w8, [x24, #0xde7]
006671CE4  ldr      x25, [x25, #0x778]
006671CE8  mov      x19, x4
006671CEC  mov      x20, x3
006671CF0  mov      x21, x2
006671CF4  mov      x22, x1
006671CF8  mov      x23, x0
006671CFC  tbnz     w8, #0, #0x6671d14
006671D00  adrp     x0, #0x8f0f000
006671D04  ldr      x0, [x0, #0x778]
006671D08  bl       #0x382bd14 ; 
006671D0C  mov      w8, #1
006671D10  strb     w8, [x24, #0xde7]
006671D14  ldr      x5, [x25]
006671D18  ldrb     w8, [x5, #0x53]
006671D1C  tbnz     w8, #5, #0x6671d34
006671D20  ldp      x20, x19, [sp, #0x30]
006671D24  ldp      x22, x21, [sp, #0x20]
006671D28  ldp      x24, x23, [sp, #0x10]
006671D2C  ldp      x30, x25, [sp], #0x40
006671D30  ret      
006671D34  ldr      x6, [x5, #0x60]
006671D38  mov      x0, x23
006671D3C  mov      x1, x22
006671D40  mov      x2, x21
006671D44  mov      x3, x20
006671D48  mov      x4, x19
006671D4C  ldp      x20, x19, [sp, #0x30]
006671D50  ldp      x22, x21, [sp, #0x20]
006671D54  ldp      x24, x23, [sp, #0x10]
006671D58  ldp      x30, x25, [sp], #0x40
006671D5C  br       x6

; HotFix.BattleLogic.MainDropManager$$.ctor
; RVA 0x6671D60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671D60  stp      x30, x21, [sp, #-0x20]!
006671D64  stp      x20, x19, [sp, #0x10]
006671D68  adrp     x20, #0x9599000
006671D6C  adrp     x21, #0x8f0f000
006671D70  ldrb     w8, [x20, #0xde8]
006671D74  ldr      x21, [x21, #0x780]
006671D78  mov      x19, x0
006671D7C  tbnz     w8, #0, #0x6671d94
006671D80  adrp     x0, #0x8f0f000
006671D84  ldr      x0, [x0, #0x780]
006671D88  bl       #0x382bd14 ; 
006671D8C  mov      w8, #1
006671D90  strb     w8, [x20, #0xde8]
006671D94  ldr      x1, [x21]
006671D98  ldrb     w8, [x1, #0x53]
006671D9C  tbnz     w8, #5, #0x6671db0
006671DA0  mov      x0, x19
006671DA4  ldp      x20, x19, [sp, #0x10]
006671DA8  ldp      x30, x21, [sp], #0x20
006671DAC  b        #0x6660484 ; HotFix.BattleLogic.DropMgr$$.ctor
006671DB0  ldr      x2, [x1, #0x60]
006671DB4  mov      x0, x19
006671DB8  ldp      x20, x19, [sp, #0x10]
006671DBC  ldp      x30, x21, [sp], #0x20
006671DC0  br       x2

