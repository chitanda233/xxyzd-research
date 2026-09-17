; HotFix.BattleLogic.WeightRandom$$get_AllWeight
; RVA 0x6632760; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632760  stp      x30, x21, [sp, #-0x20]!
006632764  stp      x20, x19, [sp, #0x10]
006632768  adrp     x20, #0x9599000
00663276C  adrp     x21, #0x8f0c000
006632770  ldrb     w8, [x20, #0x9d7]
006632774  ldr      x21, [x21, #0xf10]
006632778  mov      x19, x0
00663277C  tbnz     w8, #0, #0x6632794
006632780  adrp     x0, #0x8f0c000
006632784  ldr      x0, [x0, #0xf10]
006632788  bl       #0x382bd14 ; 
00663278C  mov      w8, #1
006632790  strb     w8, [x20, #0x9d7]
006632794  ldr      x1, [x21]
006632798  ldrb     w8, [x1, #0x53]
00663279C  tbnz     w8, #5, #0x66327b0
0066327A0  ldr      w0, [x19, #0x2c]
0066327A4  ldp      x20, x19, [sp, #0x10]
0066327A8  ldp      x30, x21, [sp], #0x20
0066327AC  ret      
0066327B0  ldr      x2, [x1, #0x60]
0066327B4  mov      x0, x19
0066327B8  ldp      x20, x19, [sp, #0x10]
0066327BC  ldp      x30, x21, [sp], #0x20
0066327C0  br       x2

; HotFix.BattleLogic.WeightRandom$$UpdateWeightPercent
; RVA 0x66327C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066327C4  sub      sp, sp, #0x70
0066327C8  stp      x29, x30, [sp, #0x10]
0066327CC  stp      x28, x27, [sp, #0x20]
0066327D0  stp      x26, x25, [sp, #0x30]
0066327D4  stp      x24, x23, [sp, #0x40]
0066327D8  stp      x22, x21, [sp, #0x50]
0066327DC  stp      x20, x19, [sp, #0x60]
0066327E0  str      x2, [sp, #8]
0066327E4  adrp     x19, #0x9599000
0066327E8  adrp     x22, #0x8f0c000
0066327EC  ldrb     w8, [x19, #0x9d8]
0066327F0  ldr      x22, [x22, #0xf18]
0066327F4  mov      x20, x1
0066327F8  mov      x21, x0
0066327FC  tbnz     w8, #0, #0x6632844
006632800  adrp     x0, #0x8f0c000
006632804  ldr      x0, [x0, #0xf20]
006632808  bl       #0x382bd14 ; 
00663280C  adrp     x0, #0x8eeb000
006632810  ldr      x0, [x0, #0x928]
006632814  bl       #0x382bd14 ; 
006632818  adrp     x0, #0x8f0c000
00663281C  ldr      x0, [x0, #0xf28]
006632820  bl       #0x382bd14 ; 
006632824  adrp     x0, #0x8f0c000
006632828  ldr      x0, [x0, #0xf30]
00663282C  bl       #0x382bd14 ; 
006632830  adrp     x0, #0x8f0c000
006632834  ldr      x0, [x0, #0xf18]
006632838  bl       #0x382bd14 ; 
00663283C  mov      w8, #1
006632840  strb     w8, [x19, #0x9d8]
006632844  ldr      x3, [x22]
006632848  ldrb     w8, [x3, #0x53]
00663284C  tbnz     w8, #5, #0x6632978
006632850  ldr      w8, [x21, #0x30]
006632854  cmp      w8, #1
006632858  b.lt     #0x6632958
00663285C  adrp     x27, #0x8f0c000
006632860  adrp     x28, #0x8eeb000
006632864  adrp     x29, #0x8f0c000
006632868  adrp     x22, #0x8f0c000
00663286C  ldr      x27, [x27, #0xf30]
006632870  ldr      x28, [x28, #0x928]
006632874  ldr      x29, [x29, #0xf28]
006632878  ldr      x22, [x22, #0xf20]
00663287C  mov      x25, xzr
006632880  mov      x26, xzr
006632884  ldr      x0, [x27]
006632888  bl       #0x382bfa0 ; 
00663288C  mov      x23, x0
006632890  bl       #0x66329b0 ; HotFix.BattleLogic.WeightRandom.<>c__DisplayClass9_0$$.ctor
006632894  ldr      x19, [x21, #0x40]
006632898  cbz      x19, #0x66329a8
00663289C  ldr      w8, [x19, #0x18]
0066328A0  cmp      x26, x8
0066328A4  b.hs     #0x66329ac
0066328A8  cbz      x23, #0x66329a8
0066328AC  add      x8, x19, x25
0066328B0  ldr      w8, [x8, #0x20]
0066328B4  str      w8, [x23, #0x10]
0066328B8  ldr      x0, [x28]
0066328BC  bl       #0x382bfa0 ; 
0066328C0  ldr      x2, [x29]
0066328C4  mov      x1, x23
0066328C8  mov      x3, xzr
0066328CC  mov      x24, x0
0066328D0  bl       #0x527a6f4 ; System.Predicate<int>$$.ctor
0066328D4  ldr      x2, [x22]
0066328D8  mov      x0, x20
0066328DC  mov      x1, x24
0066328E0  bl       #0x47b1aa8 ; System.Array$$Exists<int>
0066328E4  tbz      w0, #0, #0x6632944
0066328E8  adrp     x8, #0x9599000
0066328EC  ldrb     w8, [x8, #0xac5]
0066328F0  cbnz     w8, #0x663290c
0066328F4  adrp     x0, #0x8f0c000
0066328F8  ldr      x0, [x0, #0xed0]
0066328FC  bl       #0x382bd14 ; 
006632900  adrp     x8, #0x9599000
006632904  mov      w9, #1
006632908  strb     w9, [x8, #0xac5]
00663290C  adrp     x8, #0x8f0c000
006632910  ldr      x8, [x8, #0xed0]
006632914  ldr      x2, [x8]
006632918  ldrb     w8, [x2, #0x53]
00663291C  tbnz     w8, #5, #0x6632930
006632920  ldr      x9, [sp, #8]
006632924  add      x8, x19, x25
006632928  str      x9, [x8, #0x38]
00663292C  b        #0x6632944 ; 
006632930  ldr      x8, [x2, #0x60]
006632934  ldr      x1, [sp, #8]
006632938  add      x9, x19, x25
00663293C  add      x0, x9, #0x20
006632940  blr      x8
006632944  ldrsw    x8, [x21, #0x30]
006632948  add      x26, x26, #1
00663294C  add      x25, x25, #0x38
006632950  cmp      x26, x8
006632954  b.lt     #0x6632884
006632958  ldp      x20, x19, [sp, #0x60]
00663295C  ldp      x22, x21, [sp, #0x50]
006632960  ldp      x24, x23, [sp, #0x40]
006632964  ldp      x26, x25, [sp, #0x30]
006632968  ldp      x28, x27, [sp, #0x20]
00663296C  ldp      x29, x30, [sp, #0x10]
006632970  add      sp, sp, #0x70
006632974  ret      
006632978  ldr      x4, [x3, #0x60]
00663297C  mov      x0, x21
006632980  mov      x1, x20
006632984  ldr      x2, [sp, #8]
006632988  ldp      x20, x19, [sp, #0x60]
00663298C  ldp      x22, x21, [sp, #0x50]
006632990  ldp      x24, x23, [sp, #0x40]
006632994  ldp      x26, x25, [sp, #0x30]
006632998  ldp      x28, x27, [sp, #0x20]
00663299C  ldp      x29, x30, [sp, #0x10]
0066329A0  add      sp, sp, #0x70
0066329A4  br       x4
0066329A8  bl       #0x382bfb8 ; 
0066329AC  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$GetInfo
; RVA 0x6632A18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632A18  str      x30, [sp, #-0x30]!
006632A1C  stp      x22, x21, [sp, #0x10]
006632A20  stp      x20, x19, [sp, #0x20]
006632A24  adrp     x20, #0x9599000
006632A28  adrp     x21, #0x8f0c000
006632A2C  ldrb     w8, [x20, #0x9d9]
006632A30  ldr      x21, [x21, #0xf40]
006632A34  mov      x19, x0
006632A38  tbnz     w8, #0, #0x6632aa4
006632A3C  adrp     x0, #0x8f0c000
006632A40  ldr      x0, [x0, #0xf48]
006632A44  bl       #0x382bd14 ; 
006632A48  adrp     x0, #0x8f0c000
006632A4C  ldr      x0, [x0, #0xf50]
006632A50  bl       #0x382bd14 ; 
006632A54  adrp     x0, #0x8f0c000
006632A58  ldr      x0, [x0, #0xf58]
006632A5C  bl       #0x382bd14 ; 
006632A60  adrp     x0, #0x8ec2000
006632A64  ldr      x0, [x0, #0x420]
006632A68  bl       #0x382bd14 ; 
006632A6C  adrp     x0, #0x8f0c000
006632A70  ldr      x0, [x0, #0xf60]
006632A74  bl       #0x382bd14 ; 
006632A78  adrp     x0, #0x8f0c000
006632A7C  ldr      x0, [x0, #0xf68]
006632A80  bl       #0x382bd14 ; 
006632A84  adrp     x0, #0x8f0c000
006632A88  ldr      x0, [x0, #0xf40]
006632A8C  bl       #0x382bd14 ; 
006632A90  adrp     x0, #0x8f0c000
006632A94  ldr      x0, [x0, #0xf70]
006632A98  bl       #0x382bd14 ; 
006632A9C  mov      w8, #1
006632AA0  strb     w8, [x20, #0x9d9]
006632AA4  ldr      x1, [x21]
006632AA8  ldrb     w8, [x1, #0x53]
006632AAC  tbnz     w8, #5, #0x6632b94
006632AB0  ldr      x0, [x19, #0x40]
006632AB4  cbz      x0, #0x6632bac
006632AB8  adrp     x8, #0x8f0c000
006632ABC  ldr      x8, [x8, #0xf50]
006632AC0  ldr      x1, [x8]
006632AC4  bl       #0x45dc344 ; System.Linq.Enumerable$$ToList<WeightRandomData>
006632AC8  adrp     x22, #0x8f0c000
006632ACC  ldr      x22, [x22, #0xf68]
006632AD0  mov      x19, x0
006632AD4  ldr      x8, [x22]
006632AD8  ldr      w9, [x8, #0xe0]
006632ADC  cbnz     w9, #0x6632aec
006632AE0  mov      x0, x8
006632AE4  bl       #0x382be8c ; 
006632AE8  ldr      x8, [x22]
006632AEC  ldr      x9, [x8, #0xb8]
006632AF0  ldr      x20, [x9, #8]
006632AF4  cbnz     x20, #0x6632b54
006632AF8  ldr      w9, [x8, #0xe0]
006632AFC  cbnz     w9, #0x6632b0c
006632B00  mov      x0, x8
006632B04  bl       #0x382be8c ; 
006632B08  ldr      x8, [x22]
006632B0C  adrp     x9, #0x8f0c000
006632B10  ldr      x8, [x8, #0xb8]
006632B14  ldr      x9, [x9, #0xf58]
006632B18  ldr      x21, [x8]
006632B1C  ldr      x0, [x9]
006632B20  bl       #0x382bfa0 ; 
006632B24  adrp     x8, #0x8f0c000
006632B28  ldr      x8, [x8, #0xf60]
006632B2C  mov      x1, x21
006632B30  mov      x3, xzr
006632B34  mov      x20, x0
006632B38  ldr      x2, [x8]
006632B3C  bl       #0x48db89c ; System.Func<WeightRandomData, object>$$.ctor
006632B40  ldr      x8, [x22]
006632B44  mov      x1, x20
006632B48  ldr      x0, [x8, #0xb8]
006632B4C  str      x20, [x0, #8]!
006632B50  bl       #0x382bcb8 ; 
006632B54  adrp     x8, #0x8f0c000
006632B58  ldr      x8, [x8, #0xf48]
006632B5C  mov      x0, x19
006632B60  mov      x1, x20
006632B64  ldr      x2, [x8]
006632B68  bl       #0x45d1794 ; System.Linq.Enumerable$$Select<WeightRandomData, object>
006632B6C  adrp     x8, #0x8f0c000
006632B70  ldr      x8, [x8, #0xf70]
006632B74  ldp      x20, x19, [sp, #0x20]
006632B78  ldp      x22, x21, [sp, #0x10]
006632B7C  mov      x1, x0
006632B80  ldr      x8, [x8]
006632B84  mov      x2, xzr
006632B88  mov      x0, x8
006632B8C  ldr      x30, [sp], #0x30
006632B90  b        #0x79e32b4 ; System.String$$Join
006632B94  ldr      x2, [x1, #0x60]
006632B98  mov      x0, x19
006632B9C  ldp      x20, x19, [sp, #0x20]
006632BA0  ldp      x22, x21, [sp, #0x10]
006632BA4  ldr      x30, [sp], #0x30
006632BA8  br       x2
006632BAC  adrp     x8, #0x8ec2000
006632BB0  ldr      x8, [x8, #0x420]
006632BB4  ldp      x20, x19, [sp, #0x20]
006632BB8  ldp      x22, x21, [sp, #0x10]
006632BBC  ldr      x8, [x8]
006632BC0  ldr      x8, [x8, #0xb8]
006632BC4  ldr      x0, [x8]
006632BC8  ldr      x30, [sp], #0x30
006632BCC  ret      

; HotFix.BattleLogic.WeightRandom$$GetCount
; RVA 0x6632BD0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632BD0  stp      x30, x25, [sp, #-0x40]!
006632BD4  stp      x24, x23, [sp, #0x10]
006632BD8  stp      x22, x21, [sp, #0x20]
006632BDC  stp      x20, x19, [sp, #0x30]
006632BE0  adrp     x21, #0x9599000
006632BE4  adrp     x22, #0x8f0c000
006632BE8  ldrb     w8, [x21, #0x9da]
006632BEC  ldr      x22, [x22, #0xf78]
006632BF0  mov      x19, x1
006632BF4  mov      x20, x0
006632BF8  tbnz     w8, #0, #0x6632c1c
006632BFC  adrp     x0, #0x8f08000
006632C00  ldr      x0, [x0, #0x630]
006632C04  bl       #0x382bd14 ; 
006632C08  adrp     x0, #0x8f0c000
006632C0C  ldr      x0, [x0, #0xf78]
006632C10  bl       #0x382bd14 ; 
006632C14  mov      w8, #1
006632C18  strb     w8, [x21, #0x9da]
006632C1C  ldr      x2, [x22]
006632C20  ldrb     w8, [x2, #0x53]
006632C24  tbnz     w8, #5, #0x6632ca0
006632C28  ldr      w8, [x20, #0x30]
006632C2C  cmp      w8, #1
006632C30  b.lt     #0x6632cc0
006632C34  adrp     x24, #0x8f08000
006632C38  ldr      x24, [x24, #0x630]
006632C3C  mov      x22, xzr
006632C40  mov      w21, wzr
006632C44  mov      w23, #0x20
006632C48  ldr      x25, [x20, #0x40]
006632C4C  cbz      x25, #0x6632cdc
006632C50  ldr      w8, [x25, #0x18]
006632C54  cmp      x22, x8
006632C58  b.hs     #0x6632ce0
006632C5C  add      x0, x25, x23
006632C60  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006632C64  cmp      w0, #1
006632C68  b.lt     #0x6632c88
006632C6C  cbz      x19, #0x6632c84
006632C70  ldr      w1, [x25, x23]
006632C74  ldr      x2, [x24]
006632C78  mov      x0, x19
006632C7C  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006632C80  tbnz     w0, #0, #0x6632c88
006632C84  add      w21, w21, #1
006632C88  ldrsw    x8, [x20, #0x30]
006632C8C  add      x22, x22, #1
006632C90  add      x23, x23, #0x38
006632C94  cmp      x22, x8
006632C98  b.lt     #0x6632c48
006632C9C  b        #0x6632cc4 ; 
006632CA0  ldr      x3, [x2, #0x60]
006632CA4  mov      x0, x20
006632CA8  mov      x1, x19
006632CAC  ldp      x20, x19, [sp, #0x30]
006632CB0  ldp      x22, x21, [sp, #0x20]
006632CB4  ldp      x24, x23, [sp, #0x10]
006632CB8  ldp      x30, x25, [sp], #0x40
006632CBC  br       x3
006632CC0  mov      w21, wzr
006632CC4  mov      w0, w21
006632CC8  ldp      x20, x19, [sp, #0x30]
006632CCC  ldp      x22, x21, [sp, #0x20]
006632CD0  ldp      x24, x23, [sp, #0x10]
006632CD4  ldp      x30, x25, [sp], #0x40
006632CD8  ret      
006632CDC  bl       #0x382bfb8 ; 
006632CE0  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$RemoveRandom
; RVA 0x6632CE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632CE4  sub      sp, sp, #0x80
006632CE8  str      x30, [sp, #0x40]
006632CEC  stp      x24, x23, [sp, #0x50]
006632CF0  stp      x22, x21, [sp, #0x60]
006632CF4  stp      x20, x19, [sp, #0x70]
006632CF8  adrp     x22, #0x9599000
006632CFC  adrp     x23, #0x8f0c000
006632D00  ldrb     w8, [x22, #0x9db]
006632D04  ldr      x23, [x23, #0xf80]
006632D08  mov      w21, w2
006632D0C  mov      w20, w1
006632D10  mov      x19, x0
006632D14  tbnz     w8, #0, #0x6632d2c
006632D18  adrp     x0, #0x8f0c000
006632D1C  ldr      x0, [x0, #0xf80]
006632D20  bl       #0x382bd14 ; 
006632D24  mov      w8, #1
006632D28  strb     w8, [x22, #0x9db]
006632D2C  ldr      x3, [x23]
006632D30  ldrb     w8, [x3, #0x53]
006632D34  tbnz     w8, #5, #0x6632d84
006632D38  ldr      w8, [x19, #0x30]
006632D3C  cmp      w8, #1
006632D40  b.lt     #0x6632d7c
006632D44  ldr      x9, [x19, #0x40]
006632D48  cbz      x9, #0x6632e84
006632D4C  ldr      w10, [x9, #0x18]
006632D50  mov      w23, wzr
006632D54  mov      w22, #0x20
006632D58  cmp      w23, w10
006632D5C  b.hs     #0x6632e80
006632D60  ldr      w11, [x9, x22]
006632D64  cmp      w11, w20
006632D68  b.eq     #0x6632dac
006632D6C  add      w23, w23, #1
006632D70  cmp      w23, w8
006632D74  add      x22, x22, #0x38
006632D78  b.lt     #0x6632d58
006632D7C  mov      w20, #-1
006632D80  b        #0x6632e64 ; 
006632D84  ldr      x4, [x3, #0x60]
006632D88  and      w2, w21, #1
006632D8C  mov      x0, x19
006632D90  mov      w1, w20
006632D94  ldp      x20, x19, [sp, #0x70]
006632D98  ldp      x22, x21, [sp, #0x60]
006632D9C  ldp      x24, x23, [sp, #0x50]
006632DA0  ldr      x30, [sp, #0x40]
006632DA4  add      sp, sp, #0x80
006632DA8  br       x4
006632DAC  add      x21, x9, x22
006632DB0  mov      x0, x21
006632DB4  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006632DB8  ldr      w24, [x19, #0x2c]
006632DBC  mov      w20, w0
006632DC0  mov      x0, x21
006632DC4  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006632DC8  ldr      w9, [x19, #0x30]
006632DCC  ldr      x8, [x19, #0x40]
006632DD0  sub      w11, w24, w0
006632DD4  sub      w10, w9, #1
006632DD8  stp      w11, w10, [x19, #0x2c]
006632DDC  cbz      x8, #0x6632e84
006632DE0  ldr      w9, [x8, #0x18]
006632DE4  cmp      w10, w9
006632DE8  b.hs     #0x6632e80
006632DEC  mov      w11, #0x38
006632DF0  smaddl   x10, w10, w11, x8
006632DF4  ldp      q2, q0, [x10, #0x30]
006632DF8  ldr      x11, [x10, #0x50]
006632DFC  ldr      q1, [x10, #0x20]
006632E00  cmp      w23, w9
006632E04  stp      q2, q0, [sp, #0x10]
006632E08  str      x11, [sp, #0x30]
006632E0C  str      q1, [sp]
006632E10  b.hs     #0x6632e80
006632E14  ldp      q2, q0, [sp, #0x10]
006632E18  ldr      x9, [sp, #0x30]
006632E1C  ldr      q1, [sp]
006632E20  add      x8, x8, x22
006632E24  add      x0, x8, #0x10
006632E28  mov      x1, xzr
006632E2C  str      x9, [x8, #0x30]
006632E30  stp      q2, q0, [x8, #0x10]
006632E34  str      q1, [x8]
006632E38  bl       #0x382bcb8 ; 
006632E3C  ldr      x8, [x19, #0x40]
006632E40  cbz      x8, #0x6632e84
006632E44  ldrsw    x9, [x19, #0x30]
006632E48  ldr      w10, [x8, #0x18]
006632E4C  cmp      w9, w10
006632E50  b.hs     #0x6632e80
006632E54  mov      w10, #0x38
006632E58  madd     x8, x9, x10, x8
006632E5C  add      x0, x8, #0x20
006632E60  bl       #0x6631e40 ; HotFix.BattleLogic.WeightRandomData$$Clear
006632E64  mov      w0, w20
006632E68  ldp      x20, x19, [sp, #0x70]
006632E6C  ldp      x22, x21, [sp, #0x60]
006632E70  ldp      x24, x23, [sp, #0x50]
006632E74  ldr      x30, [sp, #0x40]
006632E78  add      sp, sp, #0x80
006632E7C  ret      
006632E80  bl       #0x382bfc0 ; 
006632E84  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandom$$Add
; RVA 0x6632E88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632E88  sub      sp, sp, #0xf0
006632E8C  stp      x29, x30, [sp, #0x90]
006632E90  stp      x28, x27, [sp, #0xa0]
006632E94  stp      x26, x25, [sp, #0xb0]
006632E98  stp      x24, x23, [sp, #0xc0]
006632E9C  stp      x22, x21, [sp, #0xd0]
006632EA0  stp      x20, x19, [sp, #0xe0]
006632EA4  adrp     x26, #0x9599000
006632EA8  adrp     x27, #0x8f0c000
006632EAC  ldrb     w8, [x26, #0x9dc]
006632EB0  ldr      x27, [x27, #0xf88]
006632EB4  mov      x19, x6
006632EB8  mov      x22, x5
006632EBC  mov      x23, x4
006632EC0  mov      w21, w3
006632EC4  mov      w24, w2
006632EC8  mov      w25, w1
006632ECC  mov      x20, x0
006632ED0  tbnz     w8, #0, #0x6632f0c
006632ED4  adrp     x0, #0x8ec2000
006632ED8  ldr      x0, [x0, #0x268]
006632EDC  bl       #0x382bd14 ; 
006632EE0  adrp     x0, #0x8ec2000
006632EE4  ldr      x0, [x0, #0x270]
006632EE8  bl       #0x382bd14 ; 
006632EEC  adrp     x0, #0x8f0c000
006632EF0  ldr      x0, [x0, #0xf90]
006632EF4  bl       #0x382bd14 ; 
006632EF8  adrp     x0, #0x8f0c000
006632EFC  ldr      x0, [x0, #0xf88]
006632F00  bl       #0x382bd14 ; 
006632F04  mov      w8, #1
006632F08  strb     w8, [x26, #0x9dc]
006632F0C  ldr      x7, [x27]
006632F10  ldrb     w8, [x7, #0x53]
006632F14  tbnz     w8, #5, #0x6633028
006632F18  mov      x0, x20
006632F1C  mov      w1, w25
006632F20  bl       #0x66331e4 ; HotFix.BattleLogic.WeightRandom$$Exist
006632F24  cmp      w24, #1
006632F28  b.lt     #0x66331bc
006632F2C  tbnz     w0, #0, #0x66331bc
006632F30  mov      x26, x20
006632F34  ldr      x8, [x26, #0x40]!
006632F38  cbz      x8, #0x6633068
006632F3C  ldp      w9, w8, [x20, #0x30]
006632F40  cmp      w9, w8
006632F44  b.lt     #0x6633094
006632F48  adrp     x9, #0x8f0c000
006632F4C  ldr      x9, [x9, #0xf90]
006632F50  add      w1, w8, #0x32
006632F54  str      w1, [sp, #0xc]
006632F58  ldr      x0, [x9]
006632F5C  bl       #0x382bdfc ; 
006632F60  ldr      w8, [x20, #0x34]
006632F64  mov      x28, x0
006632F68  cmp      w8, #1
006632F6C  b.lt     #0x663300c
006632F70  mov      x29, xzr
006632F74  mov      w27, #0x20
006632F78  ldr      x8, [x26]
006632F7C  cbz      x8, #0x66331dc
006632F80  ldr      w9, [x8, #0x18]
006632F84  cmp      x29, x9
006632F88  b.hs     #0x66331e0
006632F8C  add      x8, x8, x27
006632F90  ldr      x9, [x8, #0x30]
006632F94  ldp      q1, q0, [x8, #0x10]
006632F98  ldr      q2, [x8]
006632F9C  str      x9, [sp, #0x80]
006632FA0  stp      q1, q0, [sp, #0x60]
006632FA4  str      q2, [sp, #0x50]
006632FA8  cbz      x28, #0x66331dc
006632FAC  ldp      q0, q1, [sp, #0x50]
006632FB0  ldr      q2, [sp, #0x70]
006632FB4  ldr      x8, [sp, #0x80]
006632FB8  stp      q0, q1, [sp, #0x10]
006632FBC  str      q2, [sp, #0x30]
006632FC0  str      x8, [sp, #0x40]
006632FC4  ldr      w8, [x28, #0x18]
006632FC8  cmp      x29, x8
006632FCC  b.hs     #0x66331e0
006632FD0  ldp      q2, q0, [sp, #0x20]
006632FD4  ldr      x8, [sp, #0x40]
006632FD8  ldr      q1, [sp, #0x10]
006632FDC  add      x9, x28, x27
006632FE0  add      x0, x9, #0x10
006632FE4  mov      x1, xzr
006632FE8  str      x8, [x9, #0x30]
006632FEC  stp      q2, q0, [x9, #0x10]
006632FF0  str      q1, [x9]
006632FF4  bl       #0x382bcb8 ; 
006632FF8  ldrsw    x8, [x20, #0x34]
006632FFC  add      x29, x29, #1
006633000  add      x27, x27, #0x38
006633004  cmp      x29, x8
006633008  b.lt     #0x6632f78
00663300C  mov      x0, x26
006633010  mov      x1, x28
006633014  str      x28, [x20, #0x40]
006633018  bl       #0x382bcb8 ; 
00663301C  ldr      w8, [sp, #0xc]
006633020  str      w8, [x20, #0x34]
006633024  b        #0x6633094 ; 
006633028  ldr      x8, [x7, #0x60]
00663302C  mov      x0, x20
006633030  mov      w1, w25
006633034  mov      w2, w24
006633038  mov      w3, w21
00663303C  mov      x4, x23
006633040  mov      x5, x22
006633044  mov      x6, x19
006633048  ldp      x20, x19, [sp, #0xe0]
00663304C  ldp      x22, x21, [sp, #0xd0]
006633050  ldp      x24, x23, [sp, #0xc0]
006633054  ldp      x26, x25, [sp, #0xb0]
006633058  ldp      x28, x27, [sp, #0xa0]
00663305C  ldp      x29, x30, [sp, #0x90]
006633060  add      sp, sp, #0xf0
006633064  br       x8
006633068  adrp     x8, #0x8f0c000
00663306C  ldr      x8, [x8, #0xf90]
006633070  mov      w1, #0x32
006633074  mov      w27, #0x32
006633078  ldr      x0, [x8]
00663307C  bl       #0x382bdfc ; 
006633080  mov      x1, x0
006633084  str      x0, [x20, #0x40]
006633088  mov      x0, x26
00663308C  bl       #0x382bcb8 ; 
006633090  str      w27, [x20, #0x34]
006633094  ldrsw    x27, [x20, #0x30]
006633098  ldr      x28, [x20, #0x40]
00663309C  add      w8, w27, #1
0066330A0  str      w8, [x20, #0x30]
0066330A4  cbz      x28, #0x66331dc
0066330A8  ldr      w8, [x28, #0x18]
0066330AC  cmp      w27, w8
0066330B0  b.hs     #0x66331e0
0066330B4  mov      w8, #0x38
0066330B8  madd     x8, x27, x8, x28
0066330BC  add      x26, x8, #0x20
0066330C0  mov      x0, x26
0066330C4  mov      w1, w25
0066330C8  mov      w2, w24
0066330CC  mov      w3, w21
0066330D0  mov      x4, x23
0066330D4  mov      x5, x22
0066330D8  bl       #0x6631ee4 ; HotFix.BattleLogic.WeightRandomData$$Init
0066330DC  cmp      w21, #1
0066330E0  b.lt     #0x66330f0
0066330E4  ldr      w8, [x20, #0x38]
0066330E8  orr      w8, w8, w21
0066330EC  str      w8, [x20, #0x38]
0066330F0  cbz      x19, #0x66331a8
0066330F4  ldr      w8, [x19, #0x18]
0066330F8  cmp      w8, #1
0066330FC  b.lt     #0x66331a8
006633100  adrp     x21, #0x9599000
006633104  ldrb     w8, [x21, #0xac4]
006633108  cbnz     w8, #0x6633120
00663310C  adrp     x0, #0x8f0c000
006633110  ldr      x0, [x0, #0xea8]
006633114  bl       #0x382bd14 ; 
006633118  mov      w8, #1
00663311C  strb     w8, [x21, #0xac4]
006633120  adrp     x8, #0x8f0c000
006633124  ldr      x8, [x8, #0xea8]
006633128  ldr      x1, [x8]
00663312C  ldrb     w8, [x1, #0x53]
006633130  tbnz     w8, #5, #0x6633144
006633134  mov      w8, #0x38
006633138  madd     x8, x27, x8, x28
00663313C  ldr      x0, [x8, #0x48]
006633140  b        #0x6633150 ; 
006633144  ldr      x8, [x1, #0x60]
006633148  mov      x0, x26
00663314C  blr      x8
006633150  cbz      x0, #0x66331a8
006633154  ldr      w8, [x0, #0x18]
006633158  cmp      w8, #1
00663315C  b.lt     #0x66331a8
006633160  ldr      w8, [x19, #0x18]
006633164  cmp      w8, #1
006633168  b.lt     #0x66331a8
00663316C  adrp     x22, #0x8ec2000
006633170  ldr      x22, [x22, #0x270]
006633174  mov      w21, wzr
006633178  ldr      x2, [x22]
00663317C  mov      x0, x19
006633180  mov      w1, w21
006633184  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006633188  mov      w1, w0
00663318C  mov      x0, x26
006633190  bl       #0x6632510 ; HotFix.BattleLogic.WeightRandomData$$AddNeedSkill
006633194  tbnz     w0, #0, #0x66331a8
006633198  ldr      w8, [x19, #0x18]
00663319C  add      w21, w21, #1
0066331A0  cmp      w21, w8
0066331A4  b.lt     #0x6633178
0066331A8  ldr      w19, [x20, #0x2c]
0066331AC  mov      x0, x26
0066331B0  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066331B4  add      w8, w0, w19
0066331B8  str      w8, [x20, #0x2c]
0066331BC  ldp      x20, x19, [sp, #0xe0]
0066331C0  ldp      x22, x21, [sp, #0xd0]
0066331C4  ldp      x24, x23, [sp, #0xc0]
0066331C8  ldp      x26, x25, [sp, #0xb0]
0066331CC  ldp      x28, x27, [sp, #0xa0]
0066331D0  ldp      x29, x30, [sp, #0x90]
0066331D4  add      sp, sp, #0xf0
0066331D8  ret      
0066331DC  bl       #0x382bfb8 ; 
0066331E0  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
; RVA 0x66332B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066332B0  str      x30, [sp, #-0x40]!
0066332B4  stp      x24, x23, [sp, #0x10]
0066332B8  stp      x22, x21, [sp, #0x20]
0066332BC  stp      x20, x19, [sp, #0x30]
0066332C0  adrp     x21, #0x9599000
0066332C4  adrp     x22, #0x8f0c000
0066332C8  ldrb     w8, [x21, #0x9dd]
0066332CC  ldr      x22, [x22, #0xfa0]
0066332D0  mov      w20, w1
0066332D4  mov      x19, x0
0066332D8  tbnz     w8, #0, #0x66332f0
0066332DC  adrp     x0, #0x8f0c000
0066332E0  ldr      x0, [x0, #0xfa0]
0066332E4  bl       #0x382bd14 ; 
0066332E8  mov      w8, #1
0066332EC  strb     w8, [x21, #0x9dd]
0066332F0  ldr      x2, [x22]
0066332F4  ldrb     w8, [x2, #0x53]
0066332F8  tbnz     w8, #5, #0x6633384
0066332FC  cbz      w20, #0x6633370
006633300  ldr      w8, [x19, #0x30]
006633304  cmp      w8, #1
006633308  b.lt     #0x6633370
00663330C  mov      w8, #1
006633310  mov      x23, xzr
006633314  lsl      w20, w8, w20
006633318  mov      w24, #0x20
00663331C  ldr      x8, [x19, #0x40]
006633320  cbz      x8, #0x66333a4
006633324  ldr      w9, [x8, #0x18]
006633328  cmp      x23, x9
00663332C  b.hs     #0x66333a8
006633330  add      x22, x8, x24
006633334  mov      x0, x22
006633338  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
00663333C  mov      w21, w0
006633340  mov      x0, x22
006633344  mov      w1, w20
006633348  bl       #0x663220c ; HotFix.BattleLogic.WeightRandomData$$AddRejectFlag
00663334C  tbz      w0, #0, #0x663335c
006633350  ldr      w8, [x19, #0x2c]
006633354  sub      w8, w8, w21
006633358  str      w8, [x19, #0x2c]
00663335C  ldrsw    x8, [x19, #0x30]
006633360  add      x23, x23, #1
006633364  add      x24, x24, #0x38
006633368  cmp      x23, x8
00663336C  b.lt     #0x663331c
006633370  ldp      x20, x19, [sp, #0x30]
006633374  ldp      x22, x21, [sp, #0x20]
006633378  ldp      x24, x23, [sp, #0x10]
00663337C  ldr      x30, [sp], #0x40
006633380  ret      
006633384  ldr      x3, [x2, #0x60]
006633388  mov      x0, x19
00663338C  mov      w1, w20
006633390  ldp      x20, x19, [sp, #0x30]
006633394  ldp      x22, x21, [sp, #0x20]
006633398  ldp      x24, x23, [sp, #0x10]
00663339C  ldr      x30, [sp], #0x40
0066333A0  br       x3
0066333A4  bl       #0x382bfb8 ; 
0066333A8  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
; RVA 0x66333AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066333AC  stp      x30, x25, [sp, #-0x40]!
0066333B0  stp      x24, x23, [sp, #0x10]
0066333B4  stp      x22, x21, [sp, #0x20]
0066333B8  stp      x20, x19, [sp, #0x30]
0066333BC  adrp     x21, #0x9599000
0066333C0  adrp     x22, #0x8f0c000
0066333C4  ldrb     w8, [x21, #0x9de]
0066333C8  ldr      x22, [x22, #0xfa8]
0066333CC  mov      x19, x1
0066333D0  mov      x20, x0
0066333D4  tbnz     w8, #0, #0x66333ec
0066333D8  adrp     x0, #0x8f0c000
0066333DC  ldr      x0, [x0, #0xfa8]
0066333E0  bl       #0x382bd14 ; 
0066333E4  mov      w8, #1
0066333E8  strb     w8, [x21, #0x9de]
0066333EC  ldr      x2, [x22]
0066333F0  ldrb     w8, [x2, #0x53]
0066333F4  tbnz     w8, #5, #0x66334b0
0066333F8  cbz      x19, #0x663349c
0066333FC  ldr      w8, [x20, #0x30]
006633400  cmp      w8, #1
006633404  b.lt     #0x663349c
006633408  mov      x23, xzr
00663340C  add      x24, x19, #0x20
006633410  mov      w25, #0x38
006633414  ldr      x8, [x20, #0x40]
006633418  cbz      x8, #0x66334d4
00663341C  ldr      w9, [x8, #0x18]
006633420  cmp      x23, x9
006633424  b.hs     #0x66334d0
006633428  madd     x8, x23, x25, x8
00663342C  add      x22, x8, #0x20
006633430  mov      x0, x22
006633434  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006633438  ldr      w8, [x19, #0x18]
00663343C  cmp      w8, #1
006633440  b.lt     #0x663348c
006633444  ldr      w9, [x22]
006633448  mov      w21, w0
00663344C  mov      x10, xzr
006633450  cmp      w10, w8
006633454  b.hs     #0x66334d0
006633458  ldr      w11, [x24, x10, lsl #2]
00663345C  cmp      w11, w9
006633460  b.eq     #0x6633474
006633464  add      x10, x10, #1
006633468  cmp      w10, w8
00663346C  b.lt     #0x6633450
006633470  b        #0x663348c ; 
006633474  mov      x0, x22
006633478  bl       #0x663236c ; HotFix.BattleLogic.WeightRandomData$$AddRejectSkill
00663347C  tbz      w0, #0, #0x663348c
006633480  ldr      w8, [x20, #0x2c]
006633484  sub      w8, w8, w21
006633488  str      w8, [x20, #0x2c]
00663348C  ldrsw    x8, [x20, #0x30]
006633490  add      x23, x23, #1
006633494  cmp      x23, x8
006633498  b.lt     #0x6633414
00663349C  ldp      x20, x19, [sp, #0x30]
0066334A0  ldp      x22, x21, [sp, #0x20]
0066334A4  ldp      x24, x23, [sp, #0x10]
0066334A8  ldp      x30, x25, [sp], #0x40
0066334AC  ret      
0066334B0  ldr      x3, [x2, #0x60]
0066334B4  mov      x0, x20
0066334B8  mov      x1, x19
0066334BC  ldp      x20, x19, [sp, #0x30]
0066334C0  ldp      x22, x21, [sp, #0x20]
0066334C4  ldp      x24, x23, [sp, #0x10]
0066334C8  ldp      x30, x25, [sp], #0x40
0066334CC  br       x3
0066334D0  bl       #0x382bfc0 ; 
0066334D4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandom$$OnAddFlag
; RVA 0x66334D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066334D8  str      x30, [sp, #-0x40]!
0066334DC  stp      x24, x23, [sp, #0x10]
0066334E0  stp      x22, x21, [sp, #0x20]
0066334E4  stp      x20, x19, [sp, #0x30]
0066334E8  adrp     x21, #0x9599000
0066334EC  adrp     x22, #0x8f0c000
0066334F0  ldrb     w8, [x21, #0x9df]
0066334F4  ldr      x22, [x22, #0xfb0]
0066334F8  mov      w20, w1
0066334FC  mov      x19, x0
006633500  tbnz     w8, #0, #0x6633518
006633504  adrp     x0, #0x8f0c000
006633508  ldr      x0, [x0, #0xfb0]
00663350C  bl       #0x382bd14 ; 
006633510  mov      w8, #1
006633514  strb     w8, [x21, #0x9df]
006633518  ldr      x2, [x22]
00663351C  ldrb     w8, [x2, #0x53]
006633520  tbnz     w8, #5, #0x66335c0
006633524  ldr      w8, [x19, #0x38]
006633528  cbz      w8, #0x66335ac
00663352C  mov      w9, #1
006633530  lsl      w20, w9, w20
006633534  and      w9, w8, w20
006633538  cmp      w9, #1
00663353C  b.lt     #0x66335ac
006633540  ldr      w9, [x19, #0x30]
006633544  bic      w8, w8, w20
006633548  str      w8, [x19, #0x38]
00663354C  cmp      w9, #1
006633550  b.lt     #0x66335ac
006633554  mov      x22, xzr
006633558  mov      w23, #0x20
00663355C  ldr      x8, [x19, #0x40]
006633560  cbz      x8, #0x66335e0
006633564  ldr      w9, [x8, #0x18]
006633568  cmp      x22, x9
00663356C  b.hs     #0x66335e4
006633570  add      x21, x8, x23
006633574  mov      x0, x21
006633578  mov      w1, w20
00663357C  bl       #0x66322dc ; HotFix.BattleLogic.WeightRandomData$$TryAddFlag
006633580  tbz      w0, #0, #0x6633598
006633584  ldr      w24, [x19, #0x2c]
006633588  mov      x0, x21
00663358C  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006633590  add      w8, w0, w24
006633594  str      w8, [x19, #0x2c]
006633598  ldrsw    x8, [x19, #0x30]
00663359C  add      x22, x22, #1
0066335A0  add      x23, x23, #0x38
0066335A4  cmp      x22, x8
0066335A8  b.lt     #0x663355c
0066335AC  ldp      x20, x19, [sp, #0x30]
0066335B0  ldp      x22, x21, [sp, #0x20]
0066335B4  ldp      x24, x23, [sp, #0x10]
0066335B8  ldr      x30, [sp], #0x40
0066335BC  ret      
0066335C0  ldr      x3, [x2, #0x60]
0066335C4  mov      x0, x19
0066335C8  mov      w1, w20
0066335CC  ldp      x20, x19, [sp, #0x30]
0066335D0  ldp      x22, x21, [sp, #0x20]
0066335D4  ldp      x24, x23, [sp, #0x10]
0066335D8  ldr      x30, [sp], #0x40
0066335DC  br       x3
0066335E0  bl       #0x382bfb8 ; 
0066335E4  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
; RVA 0x66335E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066335E8  str      x30, [sp, #-0x40]!
0066335EC  stp      x24, x23, [sp, #0x10]
0066335F0  stp      x22, x21, [sp, #0x20]
0066335F4  stp      x20, x19, [sp, #0x30]
0066335F8  adrp     x21, #0x9599000
0066335FC  adrp     x22, #0x8f0c000
006633600  ldrb     w8, [x21, #0x9e0]
006633604  ldr      x22, [x22, #0xfb8]
006633608  mov      w19, w1
00663360C  mov      x20, x0
006633610  tbnz     w8, #0, #0x6633628
006633614  adrp     x0, #0x8f0c000
006633618  ldr      x0, [x0, #0xfb8]
00663361C  bl       #0x382bd14 ; 
006633620  mov      w8, #1
006633624  strb     w8, [x21, #0x9e0]
006633628  ldr      x2, [x22]
00663362C  ldrb     w8, [x2, #0x53]
006633630  tbnz     w8, #5, #0x66336b4
006633634  cmp      w19, #1
006633638  b.lt     #0x66336a0
00663363C  ldr      w8, [x20, #0x30]
006633640  cmp      w8, #1
006633644  b.lt     #0x66336a0
006633648  mov      x22, xzr
00663364C  mov      w23, #0x20
006633650  ldr      x8, [x20, #0x40]
006633654  cbz      x8, #0x66336d4
006633658  ldr      w9, [x8, #0x18]
00663365C  cmp      x22, x9
006633660  b.hs     #0x66336d8
006633664  add      x21, x8, x23
006633668  mov      x0, x21
00663366C  mov      w1, w19
006633670  bl       #0x6632510 ; HotFix.BattleLogic.WeightRandomData$$AddNeedSkill
006633674  tbz      w0, #0, #0x663368c
006633678  ldr      w24, [x20, #0x2c]
00663367C  mov      x0, x21
006633680  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006633684  add      w8, w0, w24
006633688  str      w8, [x20, #0x2c]
00663368C  ldrsw    x8, [x20, #0x30]
006633690  add      x22, x22, #1
006633694  add      x23, x23, #0x38
006633698  cmp      x22, x8
00663369C  b.lt     #0x6633650
0066336A0  ldp      x20, x19, [sp, #0x30]
0066336A4  ldp      x22, x21, [sp, #0x20]
0066336A8  ldp      x24, x23, [sp, #0x10]
0066336AC  ldr      x30, [sp], #0x40
0066336B0  ret      
0066336B4  ldr      x3, [x2, #0x60]
0066336B8  mov      x0, x20
0066336BC  mov      w1, w19
0066336C0  ldp      x20, x19, [sp, #0x30]
0066336C4  ldp      x22, x21, [sp, #0x20]
0066336C8  ldp      x24, x23, [sp, #0x10]
0066336CC  ldr      x30, [sp], #0x40
0066336D0  br       x3
0066336D4  bl       #0x382bfb8 ; 
0066336D8  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$OnRemoveFlag
; RVA 0x66336DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066336DC  str      x30, [sp, #-0x30]!
0066336E0  stp      x22, x21, [sp, #0x10]
0066336E4  stp      x20, x19, [sp, #0x20]
0066336E8  adrp     x21, #0x9599000
0066336EC  adrp     x22, #0x8f0c000
0066336F0  ldrb     w8, [x21, #0x9e1]
0066336F4  ldr      x22, [x22, #0xfc0]
0066336F8  mov      w19, w1
0066336FC  mov      x20, x0
006633700  tbnz     w8, #0, #0x6633718
006633704  adrp     x0, #0x8f0c000
006633708  ldr      x0, [x0, #0xfc0]
00663370C  bl       #0x382bd14 ; 
006633710  mov      w8, #1
006633714  strb     w8, [x21, #0x9e1]
006633718  ldr      x2, [x22]
00663371C  ldrb     w8, [x2, #0x53]
006633720  tbnz     w8, #5, #0x6633734
006633724  ldp      x20, x19, [sp, #0x20]
006633728  ldp      x22, x21, [sp, #0x10]
00663372C  ldr      x30, [sp], #0x30
006633730  ret      
006633734  ldr      x3, [x2, #0x60]
006633738  mov      x0, x20
00663373C  mov      w1, w19
006633740  ldp      x20, x19, [sp, #0x20]
006633744  ldp      x22, x21, [sp, #0x10]
006633748  ldr      x30, [sp], #0x30
00663374C  br       x3

; HotFix.BattleLogic.WeightRandom$$RecalculateAllWeight
; RVA 0x6633750; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006633750  stp      x30, x23, [sp, #-0x30]!
006633754  stp      x22, x21, [sp, #0x10]
006633758  stp      x20, x19, [sp, #0x20]
00663375C  adrp     x20, #0x9599000
006633760  adrp     x21, #0x8f0c000
006633764  ldrb     w8, [x20, #0x9e2]
006633768  ldr      x21, [x21, #0xfc8]
00663376C  mov      x19, x0
006633770  tbnz     w8, #0, #0x6633788
006633774  adrp     x0, #0x8f0c000
006633778  ldr      x0, [x0, #0xfc8]
00663377C  bl       #0x382bd14 ; 
006633780  mov      w8, #1
006633784  strb     w8, [x20, #0x9e2]
006633788  ldr      x1, [x21]
00663378C  ldrb     w8, [x1, #0x53]
006633790  tbnz     w8, #5, #0x6633804
006633794  ldr      w8, [x19, #0x30]
006633798  str      wzr, [x19, #0x2c]
00663379C  cmp      w8, #1
0066337A0  b.lt     #0x66337f4
0066337A4  mov      x21, xzr
0066337A8  mov      w22, #0x20
0066337AC  ldr      x8, [x19, #0x40]
0066337B0  cbz      x8, #0x663381c
0066337B4  ldr      w9, [x8, #0x18]
0066337B8  cmp      x21, x9
0066337BC  b.hs     #0x6633820
0066337C0  add      x20, x8, x22
0066337C4  mov      x0, x20
0066337C8  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066337CC  ldr      w23, [x19, #0x2c]
0066337D0  mov      x0, x20
0066337D4  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066337D8  ldrsw    x8, [x19, #0x30]
0066337DC  add      x21, x21, #1
0066337E0  add      w9, w0, w23
0066337E4  add      x22, x22, #0x38
0066337E8  cmp      x21, x8
0066337EC  str      w9, [x19, #0x2c]
0066337F0  b.lt     #0x66337ac
0066337F4  ldp      x20, x19, [sp, #0x20]
0066337F8  ldp      x22, x21, [sp, #0x10]
0066337FC  ldp      x30, x23, [sp], #0x30
006633800  ret      
006633804  ldr      x2, [x1, #0x60]
006633808  mov      x0, x19
00663380C  ldp      x20, x19, [sp, #0x20]
006633810  ldp      x22, x21, [sp, #0x10]
006633814  ldp      x30, x23, [sp], #0x30
006633818  br       x2
00663381C  bl       #0x382bfb8 ; 
006633820  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$BoostWeightByPercent
; RVA 0x6633824; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006633824  stp      x30, x23, [sp, #-0x30]!
006633828  stp      x22, x21, [sp, #0x10]
00663382C  stp      x20, x19, [sp, #0x20]
006633830  adrp     x22, #0x9599000
006633834  adrp     x23, #0x8f0c000
006633838  ldrb     w8, [x22, #0x9e3]
00663383C  ldr      x23, [x23, #0xfd0]
006633840  mov      w20, w2
006633844  mov      w21, w1
006633848  mov      x19, x0
00663384C  tbnz     w8, #0, #0x6633864
006633850  adrp     x0, #0x8f0c000
006633854  ldr      x0, [x0, #0xfd0]
006633858  bl       #0x382bd14 ; 
00663385C  mov      w8, #1
006633860  strb     w8, [x22, #0x9e3]
006633864  ldr      x3, [x23]
006633868  ldrb     w8, [x3, #0x53]
00663386C  tbnz     w8, #5, #0x66338bc
006633870  ldr      w8, [x19, #0x30]
006633874  cmp      w8, #1
006633878  b.lt     #0x66338b4
00663387C  ldr      x11, [x19, #0x40]
006633880  cbz      x11, #0x6633904
006633884  ldr      w10, [x11, #0x18]
006633888  mov      w9, wzr
00663388C  add      x0, x11, #0x20
006633890  cmp      w9, w10
006633894  b.hs     #0x6633900
006633898  ldr      w11, [x0]
00663389C  cmp      w11, w21
0066338A0  b.eq     #0x66338dc
0066338A4  add      w9, w9, #1
0066338A8  cmp      w9, w8
0066338AC  add      x0, x0, #0x38
0066338B0  b.lt     #0x6633890
0066338B4  mov      w0, wzr
0066338B8  b        #0x66338f0 ; 
0066338BC  ldr      x4, [x3, #0x60]
0066338C0  mov      x0, x19
0066338C4  mov      w1, w21
0066338C8  mov      w2, w20
0066338CC  ldp      x20, x19, [sp, #0x20]
0066338D0  ldp      x22, x21, [sp, #0x10]
0066338D4  ldp      x30, x23, [sp], #0x30
0066338D8  br       x4
0066338DC  mov      w1, w20
0066338E0  bl       #0x66323e4 ; HotFix.BattleLogic.WeightRandomData$$BoostWeight
0066338E4  ldr      w8, [x19, #0x2c]
0066338E8  add      w8, w8, w0
0066338EC  str      w8, [x19, #0x2c]
0066338F0  ldp      x20, x19, [sp, #0x20]
0066338F4  ldp      x22, x21, [sp, #0x10]
0066338F8  ldp      x30, x23, [sp], #0x30
0066338FC  ret      
006633900  bl       #0x382bfc0 ; 
006633904  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandom$$RevertWeightBoost
; RVA 0x6633908; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006633908  stp      x30, x23, [sp, #-0x30]!
00663390C  stp      x22, x21, [sp, #0x10]
006633910  stp      x20, x19, [sp, #0x20]
006633914  adrp     x22, #0x9599000
006633918  adrp     x23, #0x8f0c000
00663391C  ldrb     w8, [x22, #0x9e4]
006633920  ldr      x23, [x23, #0xfd8]
006633924  mov      w19, w2
006633928  mov      w21, w1
00663392C  mov      x20, x0
006633930  tbnz     w8, #0, #0x6633948
006633934  adrp     x0, #0x8f0c000
006633938  ldr      x0, [x0, #0xfd8]
00663393C  bl       #0x382bd14 ; 
006633940  mov      w8, #1
006633944  strb     w8, [x22, #0x9e4]
006633948  ldr      x3, [x23]
00663394C  ldrb     w8, [x3, #0x53]
006633950  tbnz     w8, #5, #0x663399c
006633954  ldr      w8, [x20, #0x30]
006633958  cmp      w8, #1
00663395C  b.lt     #0x66339d0
006633960  ldr      x11, [x20, #0x40]
006633964  cbz      x11, #0x66339e4
006633968  ldr      w10, [x11, #0x18]
00663396C  mov      w9, wzr
006633970  add      x0, x11, #0x20
006633974  cmp      w9, w10
006633978  b.hs     #0x66339e0
00663397C  ldr      w11, [x0]
006633980  cmp      w11, w21
006633984  b.eq     #0x66339bc
006633988  add      w9, w9, #1
00663398C  cmp      w9, w8
006633990  add      x0, x0, #0x38
006633994  b.lt     #0x6633974
006633998  b        #0x66339d0 ; 
00663399C  ldr      x4, [x3, #0x60]
0066339A0  mov      x0, x20
0066339A4  mov      w1, w21
0066339A8  mov      w2, w19
0066339AC  ldp      x20, x19, [sp, #0x20]
0066339B0  ldp      x22, x21, [sp, #0x10]
0066339B4  ldp      x30, x23, [sp], #0x30
0066339B8  br       x4
0066339BC  mov      w1, w19
0066339C0  bl       #0x6632490 ; HotFix.BattleLogic.WeightRandomData$$RevertWeightBoost
0066339C4  ldr      w8, [x20, #0x2c]
0066339C8  sub      w8, w8, w19
0066339CC  str      w8, [x20, #0x2c]
0066339D0  ldp      x20, x19, [sp, #0x20]
0066339D4  ldp      x22, x21, [sp, #0x10]
0066339D8  ldp      x30, x23, [sp], #0x30
0066339DC  ret      
0066339E0  bl       #0x382bfc0 ; 
0066339E4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandom$$GetRandom
; RVA 0x66339E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066339E8  str      x30, [sp, #-0x40]!
0066339EC  stp      x24, x23, [sp, #0x10]
0066339F0  stp      x22, x21, [sp, #0x20]
0066339F4  stp      x20, x19, [sp, #0x30]
0066339F8  adrp     x20, #0x9599000
0066339FC  adrp     x21, #0x8f0c000
006633A00  ldrb     w8, [x20, #0x9e5]
006633A04  ldr      x21, [x21, #0xfe0]
006633A08  mov      x19, x0
006633A0C  tbnz     w8, #0, #0x6633a60
006633A10  adrp     x0, #0x8ebf000
006633A14  ldr      x0, [x0, #0xba0]
006633A18  bl       #0x382bd14 ; 
006633A1C  adrp     x0, #0x8ee1000
006633A20  ldr      x0, [x0, #0x6e8]
006633A24  bl       #0x382bd14 ; 
006633A28  adrp     x0, #0x8f0c000
006633A2C  ldr      x0, [x0, #0xfe0]
006633A30  bl       #0x382bd14 ; 
006633A34  adrp     x0, #0x8f0c000
006633A38  ldr      x0, [x0, #0xfe8]
006633A3C  bl       #0x382bd14 ; 
006633A40  adrp     x0, #0x8f0c000
006633A44  ldr      x0, [x0, #0xff0]
006633A48  bl       #0x382bd14 ; 
006633A4C  adrp     x0, #0x8f0c000
006633A50  ldr      x0, [x0, #0xff8]
006633A54  bl       #0x382bd14 ; 
006633A58  mov      w8, #1
006633A5C  strb     w8, [x20, #0x9e5]
006633A60  ldr      x1, [x21]
006633A64  ldrb     w8, [x1, #0x53]
006633A68  tbnz     w8, #5, #0x6633aa8
006633A6C  adrp     x20, #0x9591000
006633A70  ldrb     w8, [x20, #0xa4b]
006633A74  cbnz     w8, #0x6633a8c
006633A78  adrp     x0, #0x8ee5000
006633A7C  ldr      x0, [x0, #0xb28]
006633A80  bl       #0x382bd14 ; 
006633A84  mov      w8, #1
006633A88  strb     w8, [x20, #0xa4b]
006633A8C  adrp     x8, #0x8ee5000
006633A90  ldr      x8, [x8, #0xb28]
006633A94  ldr      x1, [x8]
006633A98  ldrb     w8, [x1, #0x53]
006633A9C  tbnz     w8, #5, #0x6633ac4
006633AA0  ldr      x0, [x19, #0x20]
006633AA4  b        #0x6633ad0 ; 
006633AA8  ldr      x2, [x1, #0x60]
006633AAC  mov      x0, x19
006633AB0  ldp      x20, x19, [sp, #0x30]
006633AB4  ldp      x22, x21, [sp, #0x20]
006633AB8  ldp      x24, x23, [sp, #0x10]
006633ABC  ldr      x30, [sp], #0x40
006633AC0  br       x2
006633AC4  ldr      x8, [x1, #0x60]
006633AC8  mov      x0, x19
006633ACC  blr      x8
006633AD0  cbz      x0, #0x6633c04
006633AD4  ldr      w2, [x19, #0x2c]
006633AD8  mov      w1, wzr
006633ADC  mov      x3, xzr
006633AE0  bl       #0x54b65d8 ; 
006633AE4  ldr      w8, [x19, #0x30]
006633AE8  mov      w20, w0
006633AEC  cmp      w8, #1
006633AF0  b.lt     #0x6633b3c
006633AF4  mov      x21, xzr
006633AF8  mov      w22, #0x20
006633AFC  ldr      x24, [x19, #0x40]
006633B00  cbz      x24, #0x6633c04
006633B04  ldr      w8, [x24, #0x18]
006633B08  cmp      x21, x8
006633B0C  b.hs     #0x6633c08
006633B10  add      x0, x24, x22
006633B14  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006633B18  subs     w23, w20, w0
006633B1C  b.lt     #0x6633b44
006633B20  ldrsw    x8, [x19, #0x30]
006633B24  add      x21, x21, #1
006633B28  add      x22, x22, #0x38
006633B2C  mov      w20, w23
006633B30  cmp      x21, x8
006633B34  b.lt     #0x6633afc
006633B38  b        #0x6633b54 ; 
006633B3C  mov      w23, w20
006633B40  b        #0x6633b54 ; 
006633B44  ldr      w0, [x24, x22]
006633B48  mov      w23, w20
006633B4C  cmn      w0, #1
006633B50  b.ne     #0x6633bf0
006633B54  adrp     x20, #0x8ebf000
006633B58  ldr      w8, [x19, #0x2c]
006633B5C  ldr      x20, [x20, #0xba0]
006633B60  add      x1, sp, #0xc
006633B64  str      w8, [sp, #0xc]
006633B68  ldr      x0, [x20]
006633B6C  bl       #0x382be94 ; 
006633B70  mov      x19, x0
006633B74  ldr      x0, [x20]
006633B78  add      x1, sp, #8
006633B7C  str      w23, [sp, #8]
006633B80  bl       #0x382be94 ; 
006633B84  adrp     x8, #0x8f0c000
006633B88  ldr      x8, [x8, #0xfe8]
006633B8C  mov      x2, x0
006633B90  mov      x1, x19
006633B94  mov      x3, xzr
006633B98  ldr      x8, [x8]
006633B9C  mov      x0, x8
006633BA0  bl       #0x79e2794 ; System.String$$Format
006633BA4  adrp     x8, #0x8ee1000
006633BA8  ldr      x8, [x8, #0x6e8]
006633BAC  mov      x19, x0
006633BB0  ldr      x8, [x8]
006633BB4  ldr      w9, [x8, #0xe0]
006633BB8  cbnz     w9, #0x6633bc4
006633BBC  mov      x0, x8
006633BC0  bl       #0x382be8c ; 
006633BC4  adrp     x8, #0x8f0c000
006633BC8  adrp     x9, #0x8f0c000
006633BCC  ldr      x8, [x8, #0xff0]
006633BD0  ldr      x9, [x9, #0xff8]
006633BD4  mov      w3, #0x1cf
006633BD8  mov      x0, x19
006633BDC  ldr      x1, [x8]
006633BE0  ldr      x2, [x9]
006633BE4  mov      x4, xzr
006633BE8  bl       #0x7997754 ; Logger$$LogError
006633BEC  mov      w0, #-1
006633BF0  ldp      x20, x19, [sp, #0x30]
006633BF4  ldp      x22, x21, [sp, #0x20]
006633BF8  ldp      x24, x23, [sp, #0x10]
006633BFC  ldr      x30, [sp], #0x40
006633C00  ret      
006633C04  bl       #0x382bfb8 ; 
006633C08  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$GetRandomCount
; RVA 0x6633C0C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006633C0C  stp      x29, x30, [sp, #-0x60]!
006633C10  stp      x28, x27, [sp, #0x10]
006633C14  stp      x26, x25, [sp, #0x20]
006633C18  stp      x24, x23, [sp, #0x30]
006633C1C  stp      x22, x21, [sp, #0x40]
006633C20  stp      x20, x19, [sp, #0x50]
006633C24  sub      sp, sp, #0x1d0
006633C28  adrp     x21, #0x9599000
006633C2C  adrp     x22, #0x8f0d000
006633C30  ldrb     w8, [x21, #0x9e6]
006633C34  ldr      x22, [x22]
006633C38  mov      x25, x4
006633C3C  mov      x26, x3
006633C40  mov      x19, x2
006633C44  mov      w27, w1
006633C48  mov      x20, x0
006633C4C  tbnz     w8, #0, #0x6633cdc
006633C50  adrp     x0, #0x8ebf000
006633C54  ldr      x0, [x0, #0xba0]
006633C58  bl       #0x382bd14 ; 
006633C5C  adrp     x0, #0x8ec2000
006633C60  ldr      x0, [x0, #0x260]
006633C64  bl       #0x382bd14 ; 
006633C68  adrp     x0, #0x8f08000
006633C6C  ldr      x0, [x0, #0x630]
006633C70  bl       #0x382bd14 ; 
006633C74  adrp     x0, #0x8ee1000
006633C78  ldr      x0, [x0, #0x6e8]
006633C7C  bl       #0x382bd14 ; 
006633C80  adrp     x0, #0x8ec2000
006633C84  ldr      x0, [x0, #0xbc8]
006633C88  bl       #0x382bd14 ; 
006633C8C  adrp     x0, #0x8f0d000
006633C90  ldr      x0, [x0]
006633C94  bl       #0x382bd14 ; 
006633C98  adrp     x0, #0x8f0d000
006633C9C  ldr      x0, [x0, #8]
006633CA0  bl       #0x382bd14 ; 
006633CA4  adrp     x0, #0x8f0c000
006633CA8  ldr      x0, [x0, #0xff8]
006633CAC  bl       #0x382bd14 ; 
006633CB0  adrp     x0, #0x8f0d000
006633CB4  ldr      x0, [x0, #0x10]
006633CB8  bl       #0x382bd14 ; 
006633CBC  adrp     x0, #0x8f0d000
006633CC0  ldr      x0, [x0, #0x18]
006633CC4  bl       #0x382bd14 ; 
006633CC8  adrp     x0, #0x8f0d000
006633CCC  ldr      x0, [x0, #0x20]
006633CD0  bl       #0x382bd14 ; 
006633CD4  mov      w8, #1
006633CD8  strb     w8, [x21, #0x9e6]
006633CDC  ldr      x5, [x22]
006633CE0  ldrb     w8, [x5, #0x53]
006633CE4  tbnz     w8, #5, #0x6633dac
006633CE8  movi     v0.2d, #0000000000000000
006633CEC  str      xzr, [sp, #0x1c0]
006633CF0  str      xzr, [sp, #0x180]
006633CF4  str      xzr, [sp, #0x140]
006633CF8  stp      q0, q0, [sp, #0x1a0]
006633CFC  str      q0, [sp, #0x190]
006633D00  stp      q0, q0, [sp, #0x160]
006633D04  str      q0, [sp, #0x150]
006633D08  stp      q0, q0, [sp, #0x120]
006633D0C  str      q0, [sp, #0x110]
006633D10  ldr      w24, [x20, #0x30]
006633D14  cmp      w24, #1
006633D18  b.lt     #0x6633de4
006633D1C  adrp     x23, #0x8f08000
006633D20  ldr      x23, [x23, #0x630]
006633D24  mov      x21, xzr
006633D28  mov      w28, wzr
006633D2C  mov      w22, #0x20
006633D30  ldr      x8, [x20, #0x40]
006633D34  cbz      x8, #0x66345a0
006633D38  ldr      w9, [x8, #0x18]
006633D3C  cmp      x21, x9
006633D40  b.hs     #0x66345a4
006633D44  cbz      x19, #0x66345a0
006633D48  ldr      w1, [x8, x22]
006633D4C  ldr      x2, [x23]
006633D50  mov      x0, x19
006633D54  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006633D58  tbnz     w0, #0, #0x6633d98
006633D5C  ldr      x8, [x20, #0x40]
006633D60  cbz      x8, #0x66345a0
006633D64  ldr      w9, [x8, #0x18]
006633D68  cmp      x21, x9
006633D6C  b.hs     #0x66345a4
006633D70  add      x8, x8, x22
006633D74  ldr      x9, [x8, #0x30]
006633D78  ldp      q1, q0, [x8, #0x10]
006633D7C  ldr      q2, [x8]
006633D80  add      x0, sp, #0x190
006633D84  str      x9, [sp, #0x1c0]
006633D88  stp      q1, q0, [sp, #0x1a0]
006633D8C  str      q2, [sp, #0x190]
006633D90  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006633D94  add      w28, w0, w28
006633D98  add      x21, x21, #1
006633D9C  cmp      x24, x21
006633DA0  add      x22, x22, #0x38
006633DA4  b.ne     #0x6633d30
006633DA8  b        #0x6633de8 ; 
006633DAC  ldr      x6, [x5, #0x60]
006633DB0  mov      x0, x20
006633DB4  mov      w1, w27
006633DB8  mov      x2, x19
006633DBC  mov      x3, x26
006633DC0  mov      x4, x25
006633DC4  add      sp, sp, #0x1d0
006633DC8  ldp      x20, x19, [sp, #0x50]
006633DCC  ldp      x22, x21, [sp, #0x40]
006633DD0  ldp      x24, x23, [sp, #0x30]
006633DD4  ldp      x26, x25, [sp, #0x20]
006633DD8  ldp      x28, x27, [sp, #0x10]
006633DDC  ldp      x29, x30, [sp], #0x60
006633DE0  br       x6
006633DE4  mov      w28, wzr
006633DE8  cmp      w27, #1
006633DEC  stp      x26, x25, [sp, #0x10]
006633DF0  b.lt     #0x6634580
006633DF4  adrp     x26, #0x8ebf000
006633DF8  ldr      x26, [x26, #0xba0]
006633DFC  mov      w22, w28
006633E00  mov      w21, wzr
006633E04  str      w27, [sp, #0x2c]
006633E08  adrp     x8, #0x9591000
006633E0C  ldrb     w8, [x8, #0xa4b]
006633E10  cbnz     w8, #0x6633e2c
006633E14  adrp     x0, #0x8ee5000
006633E18  ldr      x0, [x0, #0xb28]
006633E1C  bl       #0x382bd14 ; 
006633E20  adrp     x8, #0x9591000
006633E24  mov      w9, #1
006633E28  strb     w9, [x8, #0xa4b]
006633E2C  str      w21, [sp, #0x30]
006633E30  adrp     x8, #0x8ee5000
006633E34  ldr      x8, [x8, #0xb28]
006633E38  ldr      x1, [x8]
006633E3C  ldrb     w8, [x1, #0x53]
006633E40  tbnz     w8, #5, #0x6633e4c
006633E44  ldr      x28, [x20, #0x20]
006633E48  b        #0x6633e5c ; 
006633E4C  ldr      x8, [x1, #0x60]
006633E50  mov      x0, x20
006633E54  blr      x8
006633E58  mov      x28, x0
006633E5C  cbz      x28, #0x66345a0
006633E60  adrp     x8, #0x9599000
006633E64  ldrb     w8, [x8, #0xac6]
006633E68  cbnz     w8, #0x6633e84
006633E6C  adrp     x0, #0x8f0d000
006633E70  ldr      x0, [x0, #0x28]
006633E74  bl       #0x382bd14 ; 
006633E78  mov      w8, #1
006633E7C  adrp     x9, #0x9599000
006633E80  strb     w8, [x9, #0xac6]
006633E84  adrp     x8, #0x8f0d000
006633E88  ldr      x8, [x8, #0x28]
006633E8C  ldr      x3, [x8]
006633E90  ldrb     w8, [x3, #0x53]
006633E94  tbnz     w8, #5, #0x6633ed8
006633E98  adrp     x8, #0x9599000
006633E9C  ldrb     w8, [x8, #0xac7]
006633EA0  cbnz     w8, #0x6633ebc
006633EA4  adrp     x0, #0x8f0d000
006633EA8  ldr      x0, [x0, #0x30]
006633EAC  bl       #0x382bd14 ; 
006633EB0  mov      w8, #1
006633EB4  adrp     x9, #0x9599000
006633EB8  strb     w8, [x9, #0xac7]
006633EBC  adrp     x8, #0x8f0d000
006633EC0  ldr      x8, [x8, #0x30]
006633EC4  ldr      x1, [x8]
006633EC8  ldrb     w8, [x1, #0x53]
006633ECC  tbnz     w8, #5, #0x6633ef4
006633ED0  ldr      x0, [x28, #0x260]
006633ED4  b        #0x6633f00 ; 
006633ED8  ldr      x8, [x3, #0x60]
006633EDC  mov      w1, #1
006633EE0  mov      x0, x28
006633EE4  mov      w2, w22
006633EE8  blr      x8
006633EEC  mov      w29, w0
006633EF0  b        #0x6633f24 ; 
006633EF4  ldr      x8, [x1, #0x60]
006633EF8  mov      x0, x28
006633EFC  blr      x8
006633F00  cbz      x0, #0x66345a0
006633F04  mov      w1, #1
006633F08  mov      w2, w22
006633F0C  mov      x3, xzr
006633F10  bl       #0x416d068 ; XXRandom$$Next
006633F14  ldr      w8, [x28, #0x32c]
006633F18  mov      w29, w0
006633F1C  add      w8, w8, #1
006633F20  str      w8, [x28, #0x32c]
006633F24  adrp     x8, #0x8ec2000
006633F28  ldr      x8, [x8, #0xbc8]
006633F2C  mov      w1, #4
006633F30  ldr      x0, [x8]
006633F34  bl       #0x382bdfc ; 
006633F38  mov      x28, x0
006633F3C  ldr      x0, [x26]
006633F40  add      x1, sp, #0xc0
006633F44  str      w29, [sp, #0xc0]
006633F48  bl       #0x382be94 ; 
006633F4C  cbz      x28, #0x66345a0
006633F50  mov      x21, x0
006633F54  cbz      x0, #0x6633f6c
006633F58  ldr      x8, [x28]
006633F5C  mov      x0, x21
006633F60  ldr      x1, [x8, #0x40]
006633F64  bl       #0x382be90 ; 
006633F68  cbz      x0, #0x66345a8
006633F6C  ldr      w8, [x28, #0x18]
006633F70  cbz      w8, #0x66345a4
006633F74  mov      x0, x28
006633F78  str      x21, [x0, #0x20]!
006633F7C  mov      x1, x21
006633F80  bl       #0x382bcb8 ; 
006633F84  ldr      x0, [x26]
006633F88  add      x1, sp, #0x10c
006633F8C  str      w22, [sp, #0x10c]
006633F90  bl       #0x382be94 ; 
006633F94  mov      x21, x0
006633F98  cbz      x0, #0x6633fb0
006633F9C  ldr      x8, [x28]
006633FA0  mov      x0, x21
006633FA4  ldr      x1, [x8, #0x40]
006633FA8  bl       #0x382be90 ; 
006633FAC  cbz      x0, #0x66345a8
006633FB0  ldr      w8, [x28, #0x18]
006633FB4  cmp      w8, #1
006633FB8  b.ls     #0x66345a4
006633FBC  mov      x0, x28
006633FC0  str      x21, [x0, #0x28]!
006633FC4  mov      x1, x21
006633FC8  bl       #0x382bcb8 ; 
006633FCC  ldr      x0, [x26]
006633FD0  add      x1, sp, #0x108
006633FD4  str      w27, [sp, #0x108]
006633FD8  bl       #0x382be94 ; 
006633FDC  mov      x21, x0
006633FE0  cbz      x0, #0x6633ff8
006633FE4  ldr      x8, [x28]
006633FE8  mov      x0, x21
006633FEC  ldr      x1, [x8, #0x40]
006633FF0  bl       #0x382be90 ; 
006633FF4  cbz      x0, #0x66345a8
006633FF8  ldr      w8, [x28, #0x18]
006633FFC  cmp      w8, #2
006634000  b.ls     #0x66345a4
006634004  mov      x0, x28
006634008  str      x21, [x0, #0x30]!
00663400C  mov      x1, x21
006634010  bl       #0x382bcb8 ; 
006634014  ldr      x0, [x26]
006634018  add      x1, sp, #0x104
00663401C  str      w24, [sp, #0x104]
006634020  bl       #0x382be94 ; 
006634024  mov      x21, x0
006634028  cbz      x0, #0x6634040
00663402C  ldr      x8, [x28]
006634030  mov      x0, x21
006634034  ldr      x1, [x8, #0x40]
006634038  bl       #0x382be90 ; 
00663403C  cbz      x0, #0x66345a8
006634040  ldr      w8, [x28, #0x18]
006634044  str      w22, [sp, #0x34]
006634048  cmp      w8, #3
00663404C  b.ls     #0x66345a4
006634050  mov      x0, x28
006634054  str      x21, [x0, #0x38]!
006634058  mov      x1, x21
00663405C  bl       #0x382bcb8 ; 
006634060  adrp     x8, #0x8f0d000
006634064  ldr      x8, [x8, #8]
006634068  mov      x1, x28
00663406C  mov      x2, xzr
006634070  ldr      x0, [x8]
006634074  bl       #0x79e281c ; System.String$$Format
006634078  mov      x1, x0
00663407C  mov      x0, x20
006634080  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634084  subs     w8, w24, #1
006634088  str      x24, [sp, #0x38]
00663408C  str      x8, [sp, #0x20]
006634090  b.lt     #0x663416c
006634094  ldr      x8, [sp, #0x38]
006634098  mov      x25, xzr
00663409C  mov      w24, #0x20
0066340A0  mov      w23, w8
0066340A4  ldr      x27, [x20, #0x40]
0066340A8  cbz      x27, #0x66345a0
0066340AC  ldr      w8, [x27, #0x18]
0066340B0  cmp      x25, x8
0066340B4  b.hs     #0x66345a4
0066340B8  add      x21, x27, x24
0066340BC  mov      x0, x21
0066340C0  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066340C4  mov      w28, w0
0066340C8  ldr      x0, [x26]
0066340CC  add      x1, sp, #0xc0
0066340D0  str      w29, [sp, #0xc0]
0066340D4  bl       #0x382be94 ; 
0066340D8  mov      x22, x0
0066340DC  ldr      w8, [x21]
0066340E0  ldr      x0, [x26]
0066340E4  add      x1, sp, #0x10c
0066340E8  str      w8, [sp, #0x10c]
0066340EC  bl       #0x382be94 ; 
0066340F0  mov      x21, x0
0066340F4  ldr      x0, [x26]
0066340F8  add      x1, sp, #0x108
0066340FC  str      w28, [sp, #0x108]
006634100  bl       #0x382be94 ; 
006634104  adrp     x8, #0x8f0d000
006634108  ldr      x8, [x8, #0x18]
00663410C  mov      x3, x0
006634110  mov      x1, x22
006634114  mov      x2, x21
006634118  ldr      x8, [x8]
00663411C  mov      x4, xzr
006634120  mov      x0, x8
006634124  bl       #0x79e27d8 ; System.String$$Format
006634128  mov      x1, x0
00663412C  mov      x0, x20
006634130  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634134  cbz      x19, #0x66345a0
006634138  adrp     x8, #0x8f08000
00663413C  ldr      w1, [x27, x24]
006634140  ldr      x8, [x8, #0x630]
006634144  mov      x0, x19
006634148  ldr      x2, [x8]
00663414C  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006634150  subs     w29, w29, w28
006634154  b.gt     #0x663415c
006634158  tbz      w0, #0, #0x663420c
00663415C  add      x25, x25, #1
006634160  cmp      x23, x25
006634164  add      x24, x24, #0x38
006634168  b.ne     #0x66340a4
00663416C  adrp     x8, #0x8ee1000
006634170  ldr      x8, [x8, #0x6e8]
006634174  ldr      x0, [x8]
006634178  ldr      w8, [x0, #0xe0]
00663417C  cbnz     w8, #0x6634184
006634180  bl       #0x382be8c ; 
006634184  adrp     x8, #0x8f0d000
006634188  ldr      x8, [x8, #0x20]
00663418C  mov      w3, #0x202
006634190  mov      x4, xzr
006634194  ldr      x0, [x8]
006634198  adrp     x8, #0x8f0d000
00663419C  ldr      x8, [x8, #0x10]
0066341A0  ldr      x1, [x8]
0066341A4  adrp     x8, #0x8f0c000
0066341A8  ldr      x8, [x8, #0xff8]
0066341AC  ldr      x2, [x8]
0066341B0  bl       #0x7997754 ; Logger$$LogError
0066341B4  ldr      x8, [x20, #0x40]
0066341B8  ldr      w27, [sp, #0x2c]
0066341BC  ldr      w22, [sp, #0x34]
0066341C0  ldr      x24, [sp, #0x38]
0066341C4  cbz      x8, #0x66345a0
0066341C8  ldr      w9, [x8, #0x18]
0066341CC  cbz      w9, #0x66345a4
0066341D0  add      x28, x8, #0x20
0066341D4  mov      x0, x28
0066341D8  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066341DC  cbz      x19, #0x66345a0
0066341E0  adrp     x8, #0x8f08000
0066341E4  ldr      w1, [x28]
0066341E8  ldr      x8, [x8, #0x630]
0066341EC  mov      w21, w0
0066341F0  mov      x0, x19
0066341F4  ldr      x2, [x8]
0066341F8  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0066341FC  cmp      w21, #1
006634200  b.lt     #0x6634434
006634204  tbnz     w0, #0, #0x6634434
006634208  b        #0x6634448 ; 
00663420C  ldr      x8, [x20, #0x40]
006634210  cbz      x8, #0x66345a0
006634214  ldr      w10, [x8, #0x18]
006634218  cmp      w25, w10
00663421C  b.hs     #0x66345a4
006634220  add      x9, x8, x24
006634224  ldr      x11, [sp, #0x38]
006634228  ldr      w29, [x27, x24]
00663422C  ldp      q0, q1, [x9]
006634230  ldr      x12, [x9, #0x30]
006634234  ldr      q2, [x9, #0x20]
006634238  ldr      w22, [sp, #0x34]
00663423C  sxtw     x11, w11
006634240  sub      x24, x11, #1
006634244  cmp      w24, w10
006634248  str      x12, [sp, #0x180]
00663424C  stp      q1, q2, [sp, #0x160]
006634250  str      q0, [sp, #0x150]
006634254  b.hs     #0x66345a4
006634258  mov      w10, #0x38
00663425C  madd     x8, x24, x10, x8
006634260  ldr      x10, [x8, #0x50]
006634264  ldp      q1, q0, [x8, #0x30]
006634268  ldr      q2, [x8, #0x20]
00663426C  add      x0, x9, #0x10
006634270  mov      x1, xzr
006634274  str      x10, [x9, #0x30]
006634278  stp      q1, q0, [x9, #0x10]
00663427C  str      q2, [x9]
006634280  bl       #0x382bcb8 ; 
006634284  ldr      x8, [x20, #0x40]
006634288  ldp      q0, q1, [sp, #0x150]
00663428C  ldr      q2, [sp, #0x170]
006634290  ldr      x9, [sp, #0x180]
006634294  ldr      w27, [sp, #0x2c]
006634298  stp      q0, q1, [sp, #0xc0]
00663429C  str      q2, [sp, #0xe0]
0066342A0  str      x9, [sp, #0xf0]
0066342A4  cbz      x8, #0x66345a0
0066342A8  ldp      q0, q1, [sp, #0xc0]
0066342AC  ldr      q2, [sp, #0xe0]
0066342B0  ldr      x9, [sp, #0xf0]
0066342B4  stp      q0, q1, [sp, #0x80]
0066342B8  str      q2, [sp, #0xa0]
0066342BC  str      x9, [sp, #0xb0]
0066342C0  ldr      w9, [x8, #0x18]
0066342C4  cmp      w24, w9
0066342C8  b.hs     #0x66345a4
0066342CC  ldp      q2, q0, [sp, #0x90]
0066342D0  ldr      x9, [sp, #0xb0]
0066342D4  ldr      q1, [sp, #0x80]
0066342D8  mov      w10, #0x38
0066342DC  madd     x8, x24, x10, x8
0066342E0  add      x0, x8, #0x30
0066342E4  mov      x1, xzr
0066342E8  str      x9, [x8, #0x50]
0066342EC  stp      q2, q0, [x8, #0x30]
0066342F0  str      q1, [x8, #0x20]
0066342F4  bl       #0x382bcb8 ; 
0066342F8  adrp     x8, #0x9591000
0066342FC  ldrb     w8, [x8, #0xa4b]
006634300  cbnz     w8, #0x663431c
006634304  adrp     x0, #0x8ee5000
006634308  ldr      x0, [x0, #0xb28]
00663430C  bl       #0x382bd14 ; 
006634310  adrp     x8, #0x9591000
006634314  mov      w9, #1
006634318  strb     w9, [x8, #0xa4b]
00663431C  adrp     x8, #0x8ee5000
006634320  ldr      x8, [x8, #0xb28]
006634324  ldr      x1, [x8]
006634328  ldrb     w8, [x1, #0x53]
00663432C  tbnz     w8, #5, #0x6634338
006634330  ldr      x21, [x20, #0x20]
006634334  b        #0x6634348 ; 
006634338  ldr      x8, [x1, #0x60]
00663433C  mov      x0, x20
006634340  blr      x8
006634344  mov      x21, x0
006634348  cbz      x21, #0x66345a0
00663434C  adrp     x8, #0x9598000
006634350  ldrb     w8, [x8, #0xfcc]
006634354  cbnz     w8, #0x6634370
006634358  adrp     x0, #0x8f06000
00663435C  ldr      x0, [x0, #0x470]
006634360  bl       #0x382bd14 ; 
006634364  mov      w8, #1
006634368  adrp     x9, #0x9598000
00663436C  strb     w8, [x9, #0xfcc]
006634370  adrp     x8, #0x8f06000
006634374  ldr      x8, [x8, #0x470]
006634378  ldr      x1, [x8]
00663437C  ldrb     w8, [x1, #0x53]
006634380  tbnz     w8, #5, #0x663438c
006634384  ldr      x0, [x21, #0x200]
006634388  b        #0x6634398 ; 
00663438C  ldr      x8, [x1, #0x60]
006634390  mov      x0, x21
006634394  blr      x8
006634398  cbz      x0, #0x66345a0
00663439C  mov      w1, w29
0066343A0  mov      x2, xzr
0066343A4  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0066343A8  cbz      x0, #0x66345a0
0066343AC  mov      x1, xzr
0066343B0  bl       #0x6b0a2d4 ; LocalModels.Bean.Skill_Main$$GetIsUpgrade
0066343B4  cmp      w0, #2
0066343B8  b.ne     #0x66343d4
0066343BC  ldp      x3, x4, [sp, #0x10]
0066343C0  mov      x0, x20
0066343C4  mov      w1, w29
0066343C8  mov      x2, x19
0066343CC  bl       #0x66346a0 ; HotFix.BattleLogic.WeightRandom$$RandomOneSubSkillByParent
0066343D0  b        #0x6634434 ; 
0066343D4  adrp     x9, #0x8ec2000
0066343D8  ldr      w10, [x19, #0x1c]
0066343DC  ldr      x8, [x19, #0x10]
0066343E0  ldr      x9, [x9, #0x260]
0066343E4  add      w10, w10, #1
0066343E8  ldr      x9, [x9]
0066343EC  str      w10, [x19, #0x1c]
0066343F0  cbz      x8, #0x66345a0
0066343F4  ldrsw    x10, [x19, #0x18]
0066343F8  ldr      w11, [x8, #0x18]
0066343FC  sub      w22, w22, w28
006634400  cmp      w10, w11
006634404  b.hs     #0x663441c
006634408  add      w9, w10, #1
00663440C  add      x8, x8, x10, lsl #2
006634410  str      w9, [x19, #0x18]
006634414  str      w29, [x8, #0x20]
006634418  b        #0x6634434 ; 
00663441C  ldr      x8, [x9, #0x20]
006634420  mov      x0, x19
006634424  mov      w1, w29
006634428  ldr      x8, [x8, #0xc0]
00663442C  ldr      x2, [x8, #0x70]
006634430  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006634434  ldr      w21, [sp, #0x30]
006634438  add      w21, w21, #1
00663443C  cmp      w21, w27
006634440  b.ne     #0x6633e08
006634444  b        #0x6634580 ; 
006634448  ldr      x8, [x20, #0x40]
00663444C  cbz      x8, #0x66345a0
006634450  ldr      w9, [x8, #0x18]
006634454  ldr      x11, [sp, #0x20]
006634458  cbz      w9, #0x66345a4
00663445C  ldr      w21, [x28]
006634460  ldp      q2, q0, [x8, #0x30]
006634464  ldr      x10, [x8, #0x50]
006634468  ldr      q1, [x8, #0x20]
00663446C  cmp      w11, w9
006634470  stp      q2, q0, [sp, #0x120]
006634474  str      x10, [sp, #0x140]
006634478  str      q1, [sp, #0x110]
00663447C  b.hs     #0x66345a4
006634480  sxtw     x22, w11
006634484  mov      w9, #0x38
006634488  madd     x9, x22, x9, x8
00663448C  ldp      q2, q0, [x9, #0x30]
006634490  ldr      x10, [x9, #0x50]
006634494  ldr      q1, [x9, #0x20]
006634498  add      x9, x8, #0x20
00663449C  add      x0, x8, #0x30
0066344A0  mov      x1, xzr
0066344A4  str      x10, [x9, #0x30]
0066344A8  stp      q2, q0, [x9, #0x10]
0066344AC  str      q1, [x9]
0066344B0  bl       #0x382bcb8 ; 
0066344B4  ldr      x8, [x20, #0x40]
0066344B8  ldp      q0, q1, [sp, #0x110]
0066344BC  ldr      q2, [sp, #0x130]
0066344C0  ldr      x9, [sp, #0x140]
0066344C4  stp      q0, q1, [sp, #0xc0]
0066344C8  str      q2, [sp, #0xe0]
0066344CC  str      x9, [sp, #0xf0]
0066344D0  cbz      x8, #0x66345a0
0066344D4  ldp      q0, q1, [sp, #0xc0]
0066344D8  ldr      q2, [sp, #0xe0]
0066344DC  ldr      x9, [sp, #0xf0]
0066344E0  stp      q0, q1, [sp, #0x40]
0066344E4  str      q2, [sp, #0x60]
0066344E8  str      x9, [sp, #0x70]
0066344EC  ldr      w9, [x8, #0x18]
0066344F0  cmp      w22, w9
0066344F4  b.hs     #0x66345a4
0066344F8  ldp      q2, q0, [sp, #0x50]
0066344FC  ldr      x10, [sp, #0x70]
006634500  ldr      q1, [sp, #0x40]
006634504  mov      w9, #0x38
006634508  madd     x8, x22, x9, x8
00663450C  add      x0, x8, #0x30
006634510  mov      x1, xzr
006634514  str      x10, [x8, #0x50]
006634518  stp      q2, q0, [x8, #0x30]
00663451C  str      q1, [x8, #0x20]
006634520  bl       #0x382bcb8 ; 
006634524  adrp     x9, #0x8ec2000
006634528  ldr      w10, [x19, #0x1c]
00663452C  ldr      x8, [x19, #0x10]
006634530  ldr      x9, [x9, #0x260]
006634534  add      w10, w10, #1
006634538  ldr      x9, [x9]
00663453C  str      w10, [x19, #0x1c]
006634540  cbz      x8, #0x66345a0
006634544  ldrsw    x10, [x19, #0x18]
006634548  ldr      w11, [x8, #0x18]
00663454C  cmp      w10, w11
006634550  b.hs     #0x6634568
006634554  add      w9, w10, #1
006634558  add      x8, x8, x10, lsl #2
00663455C  str      w9, [x19, #0x18]
006634560  str      w21, [x8, #0x20]
006634564  b        #0x6634580 ; 
006634568  ldr      x8, [x9, #0x20]
00663456C  mov      x0, x19
006634570  mov      w1, w21
006634574  ldr      x8, [x8, #0xc0]
006634578  ldr      x2, [x8, #0x70]
00663457C  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006634580  add      sp, sp, #0x1d0
006634584  ldp      x20, x19, [sp, #0x50]
006634588  ldp      x22, x21, [sp, #0x40]
00663458C  ldp      x24, x23, [sp, #0x30]
006634590  ldp      x26, x25, [sp, #0x20]
006634594  ldp      x28, x27, [sp, #0x10]
006634598  ldp      x29, x30, [sp], #0x60
00663459C  ret      
0066345A0  bl       #0x382bfb8 ; 
0066345A4  bl       #0x382bfc0 ; 
0066345A8  bl       #0x382bfdc ; 
0066345AC  mov      x1, xzr
0066345B0  bl       #0x382be7c ; 

; HotFix.BattleLogic.WeightRandom$$GetAlreadyStudySkill
; RVA 0x6634F18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006634F18  sub      sp, sp, #0x70
006634F1C  stp      x29, x30, [sp, #0x10]
006634F20  stp      x28, x27, [sp, #0x20]
006634F24  stp      x26, x25, [sp, #0x30]
006634F28  stp      x24, x23, [sp, #0x40]
006634F2C  stp      x22, x21, [sp, #0x50]
006634F30  stp      x20, x19, [sp, #0x60]
006634F34  adrp     x19, #0x9599000
006634F38  adrp     x21, #0x8f0d000
006634F3C  ldrb     w8, [x19, #0x9e7]
006634F40  ldr      x21, [x21, #0x70]
006634F44  mov      x22, x1
006634F48  mov      x20, x0
006634F4C  tbnz     w8, #0, #0x6634f70
006634F50  adrp     x0, #0x8eea000
006634F54  ldr      x0, [x0, #0xf18]
006634F58  bl       #0x382bd14 ; 
006634F5C  adrp     x0, #0x8f0d000
006634F60  ldr      x0, [x0, #0x70]
006634F64  bl       #0x382bd14 ; 
006634F68  mov      w8, #1
006634F6C  strb     w8, [x19, #0x9e7]
006634F70  ldr      x2, [x21]
006634F74  ldrb     w8, [x2, #0x53]
006634F78  tbnz     w8, #5, #0x6635254
006634F7C  cbz      x22, #0x66352a8
006634F80  mov      x0, x22
006634F84  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006634F88  ldr      w8, [x20, #0x30]
006634F8C  cmp      w8, #1
006634F90  b.lt     #0x6635280
006634F94  str      x22, [sp]
006634F98  str      wzr, [sp, #0xc]
006634F9C  adrp     x21, #0x8ee5000
006634FA0  ldr      x21, [x21, #0xb28]
006634FA4  mov      x22, xzr
006634FA8  mov      x23, xzr
006634FAC  adrp     x27, #0x9591000
006634FB0  ldr      x24, [x20, #0x40]
006634FB4  cbz      x24, #0x66352a8
006634FB8  ldr      w8, [x24, #0x18]
006634FBC  cmp      x23, x8
006634FC0  b.hs     #0x66352ac
006634FC4  add      x26, x24, x22
006634FC8  ldr      w28, [x26, #0x20]!
006634FCC  ldrb     w8, [x27, #0xa4b]
006634FD0  cbnz     w8, #0x6634fe4
006634FD4  mov      x0, x21
006634FD8  bl       #0x382bd14 ; 
006634FDC  mov      w8, #1
006634FE0  strb     w8, [x27, #0xa4b]
006634FE4  ldr      x1, [x21]
006634FE8  ldrb     w8, [x1, #0x53]
006634FEC  tbnz     w8, #5, #0x6634ff8
006634FF0  ldr      x19, [x20, #0x20]
006634FF4  b        #0x6635008 ; 
006634FF8  ldr      x8, [x1, #0x60]
006634FFC  mov      x0, x20
006635000  blr      x8
006635004  mov      x19, x0
006635008  cbz      x19, #0x66352a8
00663500C  adrp     x8, #0x9598000
006635010  ldrb     w8, [x8, #0xfcc]
006635014  cbnz     w8, #0x6635030
006635018  adrp     x0, #0x8f06000
00663501C  ldr      x0, [x0, #0x470]
006635020  bl       #0x382bd14 ; 
006635024  mov      w8, #1
006635028  adrp     x9, #0x9598000
00663502C  strb     w8, [x9, #0xfcc]
006635030  adrp     x8, #0x8f06000
006635034  ldr      x8, [x8, #0x470]
006635038  ldr      x1, [x8]
00663503C  ldrb     w8, [x1, #0x53]
006635040  tbnz     w8, #5, #0x663504c
006635044  ldr      x0, [x19, #0x200]
006635048  b        #0x6635058 ; 
00663504C  ldr      x8, [x1, #0x60]
006635050  mov      x0, x19
006635054  blr      x8
006635058  cbz      x0, #0x66352a8
00663505C  mov      w1, w28
006635060  mov      x2, xzr
006635064  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006635068  cbz      x0, #0x66352a8
00663506C  adrp     x8, #0x9599000
006635070  ldrb     w8, [x8, #0xac8]
006635074  mov      x29, x0
006635078  cbnz     w8, #0x6635094
00663507C  adrp     x0, #0x8f0d000
006635080  ldr      x0, [x0, #0x78]
006635084  bl       #0x382bd14 ; 
006635088  mov      w8, #1
00663508C  adrp     x9, #0x9599000
006635090  strb     w8, [x9, #0xac8]
006635094  adrp     x8, #0x8f0d000
006635098  ldr      x8, [x8, #0x78]
00663509C  ldr      x1, [x8]
0066350A0  ldrb     w8, [x1, #0x53]
0066350A4  tbnz     w8, #5, #0x66350b0
0066350A8  ldr      w25, [x29, #0x58]
0066350AC  b        #0x66350c0 ; 
0066350B0  ldr      x8, [x1, #0x60]
0066350B4  mov      x0, x29
0066350B8  blr      x8
0066350BC  mov      w25, w0
0066350C0  cmp      w25, #2
0066350C4  b.lt     #0x663523c
0066350C8  mov      x0, x26
0066350CC  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066350D0  adrp     x8, #0x9599000
0066350D4  ldrb     w8, [x8, #0xac2]
0066350D8  mov      w26, w0
0066350DC  cbnz     w8, #0x66350f8
0066350E0  adrp     x0, #0x8f0c000
0066350E4  ldr      x0, [x0, #0xe98]
0066350E8  bl       #0x382bd14 ; 
0066350EC  mov      w8, #1
0066350F0  adrp     x9, #0x9599000
0066350F4  strb     w8, [x9, #0xac2]
0066350F8  adrp     x8, #0x8f0c000
0066350FC  ldr      x8, [x8, #0xe98]
006635100  mov      x21, x27
006635104  ldr      x1, [x8]
006635108  ldrb     w8, [x1, #0x53]
00663510C  tbnz     w8, #5, #0x663511c
006635110  add      x8, x24, x22
006635114  ldr      w27, [x8, #0x2c]
006635118  b        #0x6635130 ; 
00663511C  ldr      x8, [x1, #0x60]
006635120  add      x9, x24, x22
006635124  add      x0, x9, #0x20
006635128  blr      x8
00663512C  mov      w27, w0
006635130  adrp     x8, #0x9599000
006635134  ldrb     w8, [x8, #0xac3]
006635138  cbnz     w8, #0x6635154
00663513C  adrp     x0, #0x8f0c000
006635140  ldr      x0, [x0, #0xea0]
006635144  bl       #0x382bd14 ; 
006635148  mov      w8, #1
00663514C  adrp     x9, #0x9599000
006635150  strb     w8, [x9, #0xac3]
006635154  adrp     x8, #0x8f0c000
006635158  ldr      x8, [x8, #0xea0]
00663515C  ldr      x1, [x8]
006635160  ldrb     w8, [x1, #0x53]
006635164  tbnz     w8, #5, #0x6635174
006635168  add      x8, x24, x22
00663516C  ldr      x19, [x8, #0x30]
006635170  b        #0x6635188 ; 
006635174  ldr      x8, [x1, #0x60]
006635178  add      x9, x24, x22
00663517C  add      x0, x9, #0x20
006635180  blr      x8
006635184  mov      x19, x0
006635188  adrp     x8, #0x9599000
00663518C  ldrb     w8, [x8, #0xac4]
006635190  cbnz     w8, #0x66351ac
006635194  adrp     x0, #0x8f0c000
006635198  ldr      x0, [x0, #0xea8]
00663519C  bl       #0x382bd14 ; 
0066351A0  mov      w8, #1
0066351A4  adrp     x9, #0x9599000
0066351A8  strb     w8, [x9, #0xac4]
0066351AC  adrp     x8, #0x8f0c000
0066351B0  ldr      x8, [x8, #0xea8]
0066351B4  ldr      x1, [x8]
0066351B8  ldrb     w8, [x1, #0x53]
0066351BC  tbnz     w8, #5, #0x66351cc
0066351C0  add      x8, x24, x22
0066351C4  ldr      x0, [x8, #0x48]
0066351C8  b        #0x66351dc ; 
0066351CC  ldr      x8, [x1, #0x60]
0066351D0  add      x9, x24, x22
0066351D4  add      x0, x9, #0x20
0066351D8  blr      x8
0066351DC  cbz      x0, #0x66352a8
0066351E0  adrp     x8, #0x8eea000
0066351E4  ldr      x8, [x8, #0xf18]
0066351E8  ldr      x1, [x8]
0066351EC  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
0066351F0  mov      x5, x0
0066351F4  ldr      x0, [sp]
0066351F8  mov      w1, w28
0066351FC  mov      w2, w26
006635200  mov      w3, w27
006635204  mov      x4, x19
006635208  mov      x6, xzr
00663520C  bl       #0x6632e88 ; HotFix.BattleLogic.WeightRandom$$Add
006635210  mov      x0, x29
006635214  mov      x1, xzr
006635218  bl       #0x6b0a07c ; LocalModels.Bean.Skill_Main$$GetMaxStar
00663521C  ldr      w8, [sp, #0xc]
006635220  mov      x27, x21
006635224  adrp     x21, #0x8ee5000
006635228  sub      w8, w8, w25
00663522C  add      w8, w8, w0
006635230  add      w8, w8, #1
006635234  str      w8, [sp, #0xc]
006635238  ldr      x21, [x21, #0xb28]
00663523C  ldrsw    x8, [x20, #0x30]
006635240  add      x23, x23, #1
006635244  add      x22, x22, #0x38
006635248  cmp      x23, x8
00663524C  b.lt     #0x6634fb0
006635250  b        #0x6635284 ; 
006635254  ldr      x3, [x2, #0x60]
006635258  mov      x0, x20
00663525C  mov      x1, x22
006635260  ldp      x20, x19, [sp, #0x60]
006635264  ldp      x22, x21, [sp, #0x50]
006635268  ldp      x24, x23, [sp, #0x40]
00663526C  ldp      x26, x25, [sp, #0x30]
006635270  ldp      x28, x27, [sp, #0x20]
006635274  ldp      x29, x30, [sp, #0x10]
006635278  add      sp, sp, #0x70
00663527C  br       x3
006635280  str      wzr, [sp, #0xc]
006635284  ldr      w0, [sp, #0xc]
006635288  ldp      x20, x19, [sp, #0x60]
00663528C  ldp      x22, x21, [sp, #0x50]
006635290  ldp      x24, x23, [sp, #0x40]
006635294  ldp      x26, x25, [sp, #0x30]
006635298  ldp      x28, x27, [sp, #0x20]
00663529C  ldp      x29, x30, [sp, #0x10]
0066352A0  add      sp, sp, #0x70
0066352A4  ret      
0066352A8  bl       #0x382bfb8 ; 
0066352AC  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$GetReadyStudySkill
; RVA 0x6635318; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006635318  sub      sp, sp, #0x70
00663531C  stp      x29, x30, [sp, #0x10]
006635320  stp      x28, x27, [sp, #0x20]
006635324  stp      x26, x25, [sp, #0x30]
006635328  stp      x24, x23, [sp, #0x40]
00663532C  stp      x22, x21, [sp, #0x50]
006635330  stp      x20, x19, [sp, #0x60]
006635334  adrp     x19, #0x9599000
006635338  adrp     x21, #0x8f0d000
00663533C  ldrb     w8, [x19, #0x9e8]
006635340  ldr      x21, [x21, #0x88]
006635344  mov      x22, x1
006635348  mov      x20, x0
00663534C  tbnz     w8, #0, #0x6635370
006635350  adrp     x0, #0x8eea000
006635354  ldr      x0, [x0, #0xf18]
006635358  bl       #0x382bd14 ; 
00663535C  adrp     x0, #0x8f0d000
006635360  ldr      x0, [x0, #0x88]
006635364  bl       #0x382bd14 ; 
006635368  mov      w8, #1
00663536C  strb     w8, [x19, #0x9e8]
006635370  ldr      x2, [x21]
006635374  ldrb     w8, [x2, #0x53]
006635378  tbnz     w8, #5, #0x6635634
00663537C  cbz      x22, #0x6635688
006635380  mov      x0, x22
006635384  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006635388  ldr      w8, [x20, #0x30]
00663538C  cmp      w8, #1
006635390  b.lt     #0x6635660
006635394  str      x22, [sp, #8]
006635398  adrp     x24, #0x8ee5000
00663539C  ldr      x24, [x24, #0xb28]
0066353A0  mov      x27, xzr
0066353A4  mov      x19, xzr
0066353A8  mov      w21, wzr
0066353AC  adrp     x26, #0x9591000
0066353B0  adrp     x22, #0x9598000
0066353B4  ldr      x23, [x20, #0x40]
0066353B8  cbz      x23, #0x6635688
0066353BC  ldr      w8, [x23, #0x18]
0066353C0  cmp      x19, x8
0066353C4  b.hs     #0x663568c
0066353C8  add      x29, x23, x27
0066353CC  ldr      w28, [x29, #0x20]!
0066353D0  ldrb     w8, [x26, #0xa4b]
0066353D4  cbnz     w8, #0x66353e8
0066353D8  mov      x0, x24
0066353DC  bl       #0x382bd14 ; 
0066353E0  mov      w8, #1
0066353E4  strb     w8, [x26, #0xa4b]
0066353E8  ldr      x1, [x24]
0066353EC  ldrb     w8, [x1, #0x53]
0066353F0  tbnz     w8, #5, #0x66353fc
0066353F4  ldr      x25, [x20, #0x20]
0066353F8  b        #0x663540c ; 
0066353FC  ldr      x8, [x1, #0x60]
006635400  mov      x0, x20
006635404  blr      x8
006635408  mov      x25, x0
00663540C  cbz      x25, #0x6635688
006635410  ldrb     w8, [x22, #0xfcc]
006635414  cbnz     w8, #0x663542c
006635418  adrp     x0, #0x8f06000
00663541C  ldr      x0, [x0, #0x470]
006635420  bl       #0x382bd14 ; 
006635424  mov      w8, #1
006635428  strb     w8, [x22, #0xfcc]
00663542C  adrp     x8, #0x8f06000
006635430  ldr      x8, [x8, #0x470]
006635434  ldr      x1, [x8]
006635438  ldrb     w8, [x1, #0x53]
00663543C  tbnz     w8, #5, #0x6635448
006635440  ldr      x0, [x25, #0x200]
006635444  b        #0x6635454 ; 
006635448  ldr      x8, [x1, #0x60]
00663544C  mov      x0, x25
006635450  blr      x8
006635454  cbz      x0, #0x6635688
006635458  mov      w1, w28
00663545C  mov      x2, xzr
006635460  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006635464  cbz      x0, #0x6635688
006635468  adrp     x8, #0x9599000
00663546C  ldrb     w8, [x8, #0xac8]
006635470  mov      x25, x0
006635474  cbnz     w8, #0x6635490
006635478  adrp     x0, #0x8f0d000
00663547C  ldr      x0, [x0, #0x78]
006635480  bl       #0x382bd14 ; 
006635484  mov      w8, #1
006635488  adrp     x9, #0x9599000
00663548C  strb     w8, [x9, #0xac8]
006635490  adrp     x8, #0x8f0d000
006635494  ldr      x8, [x8, #0x78]
006635498  ldr      x1, [x8]
00663549C  ldrb     w8, [x1, #0x53]
0066354A0  tbnz     w8, #5, #0x66354ac
0066354A4  ldr      w0, [x25, #0x58]
0066354A8  b        #0x66354b8 ; 
0066354AC  ldr      x8, [x1, #0x60]
0066354B0  mov      x0, x25
0066354B4  blr      x8
0066354B8  cmp      w0, #1
0066354BC  b.ne     #0x663561c
0066354C0  mov      x0, x29
0066354C4  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
0066354C8  adrp     x8, #0x9599000
0066354CC  ldrb     w8, [x8, #0xac2]
0066354D0  mov      w29, w0
0066354D4  cbnz     w8, #0x66354f0
0066354D8  adrp     x0, #0x8f0c000
0066354DC  ldr      x0, [x0, #0xe98]
0066354E0  bl       #0x382bd14 ; 
0066354E4  mov      w8, #1
0066354E8  adrp     x9, #0x9599000
0066354EC  strb     w8, [x9, #0xac2]
0066354F0  adrp     x8, #0x8f0c000
0066354F4  ldr      x8, [x8, #0xe98]
0066354F8  ldr      x1, [x8]
0066354FC  ldrb     w8, [x1, #0x53]
006635500  tbnz     w8, #5, #0x6635510
006635504  add      x8, x23, x27
006635508  ldr      w25, [x8, #0x2c]
00663550C  b        #0x6635524 ; 
006635510  ldr      x8, [x1, #0x60]
006635514  add      x9, x23, x27
006635518  add      x0, x9, #0x20
00663551C  blr      x8
006635520  mov      w25, w0
006635524  adrp     x8, #0x9599000
006635528  ldrb     w8, [x8, #0xac3]
00663552C  mov      x22, x24
006635530  cbnz     w8, #0x663554c
006635534  adrp     x0, #0x8f0c000
006635538  ldr      x0, [x0, #0xea0]
00663553C  bl       #0x382bd14 ; 
006635540  mov      w8, #1
006635544  adrp     x9, #0x9599000
006635548  strb     w8, [x9, #0xac3]
00663554C  adrp     x8, #0x8f0c000
006635550  ldr      x8, [x8, #0xea0]
006635554  mov      x24, x26
006635558  ldr      x1, [x8]
00663555C  ldrb     w8, [x1, #0x53]
006635560  tbnz     w8, #5, #0x6635570
006635564  add      x8, x23, x27
006635568  ldr      x26, [x8, #0x30]
00663556C  b        #0x6635584 ; 
006635570  ldr      x8, [x1, #0x60]
006635574  add      x9, x23, x27
006635578  add      x0, x9, #0x20
00663557C  blr      x8
006635580  mov      x26, x0
006635584  adrp     x8, #0x9599000
006635588  ldrb     w8, [x8, #0xac4]
00663558C  cbnz     w8, #0x66355a8
006635590  adrp     x0, #0x8f0c000
006635594  ldr      x0, [x0, #0xea8]
006635598  bl       #0x382bd14 ; 
00663559C  mov      w8, #1
0066355A0  adrp     x9, #0x9599000
0066355A4  strb     w8, [x9, #0xac4]
0066355A8  adrp     x8, #0x8f0c000
0066355AC  ldr      x8, [x8, #0xea8]
0066355B0  ldr      x1, [x8]
0066355B4  ldrb     w8, [x1, #0x53]
0066355B8  tbnz     w8, #5, #0x66355c8
0066355BC  add      x8, x23, x27
0066355C0  ldr      x0, [x8, #0x48]
0066355C4  b        #0x66355d8 ; 
0066355C8  ldr      x8, [x1, #0x60]
0066355CC  add      x9, x23, x27
0066355D0  add      x0, x9, #0x20
0066355D4  blr      x8
0066355D8  cbz      x0, #0x6635688
0066355DC  adrp     x8, #0x8eea000
0066355E0  ldr      x8, [x8, #0xf18]
0066355E4  ldr      x1, [x8]
0066355E8  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
0066355EC  mov      x5, x0
0066355F0  ldr      x0, [sp, #8]
0066355F4  mov      w1, w28
0066355F8  mov      w2, w29
0066355FC  mov      w3, w25
006635600  mov      x4, x26
006635604  mov      x6, xzr
006635608  bl       #0x6632e88 ; HotFix.BattleLogic.WeightRandom$$Add
00663560C  add      w21, w21, #1
006635610  mov      x26, x24
006635614  mov      x24, x22
006635618  adrp     x22, #0x9598000
00663561C  ldrsw    x8, [x20, #0x30]
006635620  add      x19, x19, #1
006635624  add      x27, x27, #0x38
006635628  cmp      x19, x8
00663562C  b.lt     #0x66353b4
006635630  b        #0x6635664 ; 
006635634  ldr      x3, [x2, #0x60]
006635638  mov      x0, x20
00663563C  mov      x1, x22
006635640  ldp      x20, x19, [sp, #0x60]
006635644  ldp      x22, x21, [sp, #0x50]
006635648  ldp      x24, x23, [sp, #0x40]
00663564C  ldp      x26, x25, [sp, #0x30]
006635650  ldp      x28, x27, [sp, #0x20]
006635654  ldp      x29, x30, [sp, #0x10]
006635658  add      sp, sp, #0x70
00663565C  br       x3
006635660  mov      w21, wzr
006635664  mov      w0, w21
006635668  ldp      x20, x19, [sp, #0x60]
00663566C  ldp      x22, x21, [sp, #0x50]
006635670  ldp      x24, x23, [sp, #0x40]
006635674  ldp      x26, x25, [sp, #0x30]
006635678  ldp      x28, x27, [sp, #0x20]
00663567C  ldp      x29, x30, [sp, #0x10]
006635680  add      sp, sp, #0x70
006635684  ret      
006635688  bl       #0x382bfb8 ; 
00663568C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$GetOneStarSkill
; RVA 0x6635690; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006635690  sub      sp, sp, #0x70
006635694  stp      x29, x30, [sp, #0x10]
006635698  stp      x28, x27, [sp, #0x20]
00663569C  stp      x26, x25, [sp, #0x30]
0066356A0  stp      x24, x23, [sp, #0x40]
0066356A4  stp      x22, x21, [sp, #0x50]
0066356A8  stp      x20, x19, [sp, #0x60]
0066356AC  adrp     x19, #0x9599000
0066356B0  adrp     x21, #0x8f0d000
0066356B4  ldrb     w8, [x19, #0x9e9]
0066356B8  ldr      x21, [x21, #0x90]
0066356BC  mov      x22, x1
0066356C0  mov      x20, x0
0066356C4  tbnz     w8, #0, #0x66356e8
0066356C8  adrp     x0, #0x8eea000
0066356CC  ldr      x0, [x0, #0xf18]
0066356D0  bl       #0x382bd14 ; 
0066356D4  adrp     x0, #0x8f0d000
0066356D8  ldr      x0, [x0, #0x90]
0066356DC  bl       #0x382bd14 ; 
0066356E0  mov      w8, #1
0066356E4  strb     w8, [x19, #0x9e9]
0066356E8  ldr      x2, [x21]
0066356EC  ldrb     w8, [x2, #0x53]
0066356F0  tbnz     w8, #5, #0x66359c0
0066356F4  cbz      x22, #0x6635a14
0066356F8  mov      x0, x22
0066356FC  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006635700  ldr      w8, [x20, #0x30]
006635704  cmp      w8, #1
006635708  b.lt     #0x66359ec
00663570C  str      x22, [sp]
006635710  str      wzr, [sp, #0xc]
006635714  adrp     x23, #0x8ee5000
006635718  ldr      x23, [x23, #0xb28]
00663571C  mov      x19, xzr
006635720  mov      x22, xzr
006635724  adrp     x27, #0x9591000
006635728  adrp     x21, #0x9598000
00663572C  ldr      x24, [x20, #0x40]
006635730  cbz      x24, #0x6635a14
006635734  ldr      w8, [x24, #0x18]
006635738  cmp      x22, x8
00663573C  b.hs     #0x6635a18
006635740  add      x25, x24, x19
006635744  ldr      w28, [x25, #0x20]!
006635748  ldrb     w8, [x27, #0xa4b]
00663574C  cbnz     w8, #0x6635760
006635750  mov      x0, x23
006635754  bl       #0x382bd14 ; 
006635758  mov      w8, #1
00663575C  strb     w8, [x27, #0xa4b]
006635760  ldr      x1, [x23]
006635764  ldrb     w8, [x1, #0x53]
006635768  tbnz     w8, #5, #0x6635774
00663576C  ldr      x26, [x20, #0x20]
006635770  b        #0x6635784 ; 
006635774  ldr      x8, [x1, #0x60]
006635778  mov      x0, x20
00663577C  blr      x8
006635780  mov      x26, x0
006635784  cbz      x26, #0x6635a14
006635788  ldrb     w8, [x21, #0xfcc]
00663578C  cbnz     w8, #0x66357a4
006635790  adrp     x0, #0x8f06000
006635794  ldr      x0, [x0, #0x470]
006635798  bl       #0x382bd14 ; 
00663579C  mov      w8, #1
0066357A0  strb     w8, [x21, #0xfcc]
0066357A4  adrp     x8, #0x8f06000
0066357A8  ldr      x8, [x8, #0x470]
0066357AC  ldr      x1, [x8]
0066357B0  ldrb     w8, [x1, #0x53]
0066357B4  tbnz     w8, #5, #0x66357c0
0066357B8  ldr      x0, [x26, #0x200]
0066357BC  b        #0x66357cc ; 
0066357C0  ldr      x8, [x1, #0x60]
0066357C4  mov      x0, x26
0066357C8  blr      x8
0066357CC  cbz      x0, #0x6635a14
0066357D0  mov      w1, w28
0066357D4  mov      x2, xzr
0066357D8  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0066357DC  cbz      x0, #0x6635a14
0066357E0  adrp     x8, #0x9599000
0066357E4  ldrb     w8, [x8, #0xac8]
0066357E8  mov      x29, x0
0066357EC  cbnz     w8, #0x6635808
0066357F0  adrp     x0, #0x8f0d000
0066357F4  ldr      x0, [x0, #0x78]
0066357F8  bl       #0x382bd14 ; 
0066357FC  mov      w8, #1
006635800  adrp     x9, #0x9599000
006635804  strb     w8, [x9, #0xac8]
006635808  adrp     x8, #0x8f0d000
00663580C  ldr      x8, [x8, #0x78]
006635810  ldr      x1, [x8]
006635814  ldrb     w8, [x1, #0x53]
006635818  tbnz     w8, #5, #0x6635824
00663581C  ldr      w0, [x29, #0x58]
006635820  b        #0x6635830 ; 
006635824  ldr      x8, [x1, #0x60]
006635828  mov      x0, x29
00663582C  blr      x8
006635830  cmp      w0, #1
006635834  b.ne     #0x66359a8
006635838  mov      x0, x25
00663583C  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006635840  adrp     x8, #0x9599000
006635844  ldrb     w8, [x8, #0xac2]
006635848  mov      w25, w0
00663584C  cbnz     w8, #0x6635868
006635850  adrp     x0, #0x8f0c000
006635854  ldr      x0, [x0, #0xe98]
006635858  bl       #0x382bd14 ; 
00663585C  mov      w8, #1
006635860  adrp     x9, #0x9599000
006635864  strb     w8, [x9, #0xac2]
006635868  adrp     x8, #0x8f0c000
00663586C  ldr      x8, [x8, #0xe98]
006635870  ldr      x1, [x8]
006635874  ldrb     w8, [x1, #0x53]
006635878  tbnz     w8, #5, #0x6635888
00663587C  add      x8, x24, x19
006635880  ldr      w26, [x8, #0x2c]
006635884  b        #0x663589c ; 
006635888  ldr      x8, [x1, #0x60]
00663588C  add      x9, x24, x19
006635890  add      x0, x9, #0x20
006635894  blr      x8
006635898  mov      w26, w0
00663589C  adrp     x8, #0x9599000
0066358A0  ldrb     w8, [x8, #0xac3]
0066358A4  mov      x21, x23
0066358A8  cbnz     w8, #0x66358c4
0066358AC  adrp     x0, #0x8f0c000
0066358B0  ldr      x0, [x0, #0xea0]
0066358B4  bl       #0x382bd14 ; 
0066358B8  mov      w8, #1
0066358BC  adrp     x9, #0x9599000
0066358C0  strb     w8, [x9, #0xac3]
0066358C4  adrp     x8, #0x8f0c000
0066358C8  ldr      x8, [x8, #0xea0]
0066358CC  mov      x23, x27
0066358D0  ldr      x1, [x8]
0066358D4  ldrb     w8, [x1, #0x53]
0066358D8  tbnz     w8, #5, #0x66358e8
0066358DC  add      x8, x24, x19
0066358E0  ldr      x27, [x8, #0x30]
0066358E4  b        #0x66358fc ; 
0066358E8  ldr      x8, [x1, #0x60]
0066358EC  add      x9, x24, x19
0066358F0  add      x0, x9, #0x20
0066358F4  blr      x8
0066358F8  mov      x27, x0
0066358FC  adrp     x8, #0x9599000
006635900  ldrb     w8, [x8, #0xac4]
006635904  cbnz     w8, #0x6635920
006635908  adrp     x0, #0x8f0c000
00663590C  ldr      x0, [x0, #0xea8]
006635910  bl       #0x382bd14 ; 
006635914  mov      w8, #1
006635918  adrp     x9, #0x9599000
00663591C  strb     w8, [x9, #0xac4]
006635920  adrp     x8, #0x8f0c000
006635924  ldr      x8, [x8, #0xea8]
006635928  ldr      x1, [x8]
00663592C  ldrb     w8, [x1, #0x53]
006635930  tbnz     w8, #5, #0x6635940
006635934  add      x8, x24, x19
006635938  ldr      x0, [x8, #0x48]
00663593C  b        #0x6635950 ; 
006635940  ldr      x8, [x1, #0x60]
006635944  add      x9, x24, x19
006635948  add      x0, x9, #0x20
00663594C  blr      x8
006635950  cbz      x0, #0x6635a14
006635954  adrp     x8, #0x8eea000
006635958  ldr      x8, [x8, #0xf18]
00663595C  ldr      x1, [x8]
006635960  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
006635964  mov      x5, x0
006635968  ldr      x0, [sp]
00663596C  mov      w1, w28
006635970  mov      w2, w25
006635974  mov      w3, w26
006635978  mov      x4, x27
00663597C  mov      x6, xzr
006635980  bl       #0x6632e88 ; HotFix.BattleLogic.WeightRandom$$Add
006635984  mov      x0, x29
006635988  mov      x1, xzr
00663598C  bl       #0x6b0a07c ; LocalModels.Bean.Skill_Main$$GetMaxStar
006635990  ldr      w8, [sp, #0xc]
006635994  mov      x27, x23
006635998  mov      x23, x21
00663599C  adrp     x21, #0x9598000
0066359A0  add      w8, w8, w0
0066359A4  str      w8, [sp, #0xc]
0066359A8  ldrsw    x8, [x20, #0x30]
0066359AC  add      x22, x22, #1
0066359B0  add      x19, x19, #0x38
0066359B4  cmp      x22, x8
0066359B8  b.lt     #0x663572c
0066359BC  b        #0x66359f0 ; 
0066359C0  ldr      x3, [x2, #0x60]
0066359C4  mov      x0, x20
0066359C8  mov      x1, x22
0066359CC  ldp      x20, x19, [sp, #0x60]
0066359D0  ldp      x22, x21, [sp, #0x50]
0066359D4  ldp      x24, x23, [sp, #0x40]
0066359D8  ldp      x26, x25, [sp, #0x30]
0066359DC  ldp      x28, x27, [sp, #0x20]
0066359E0  ldp      x29, x30, [sp, #0x10]
0066359E4  add      sp, sp, #0x70
0066359E8  br       x3
0066359EC  str      wzr, [sp, #0xc]
0066359F0  ldr      w0, [sp, #0xc]
0066359F4  ldp      x20, x19, [sp, #0x60]
0066359F8  ldp      x22, x21, [sp, #0x50]
0066359FC  ldp      x24, x23, [sp, #0x40]
006635A00  ldp      x26, x25, [sp, #0x30]
006635A04  ldp      x28, x27, [sp, #0x20]
006635A08  ldp      x29, x30, [sp, #0x10]
006635A0C  add      sp, sp, #0x70
006635A10  ret      
006635A14  bl       #0x382bfb8 ; 
006635A18  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$CopyWeightRandom
; RVA 0x6635A1C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006635A1C  stp      x29, x30, [sp, #-0x60]!
006635A20  stp      x28, x27, [sp, #0x10]
006635A24  stp      x26, x25, [sp, #0x20]
006635A28  stp      x24, x23, [sp, #0x30]
006635A2C  stp      x22, x21, [sp, #0x40]
006635A30  stp      x20, x19, [sp, #0x50]
006635A34  adrp     x21, #0x9599000
006635A38  adrp     x22, #0x8f0d000
006635A3C  ldrb     w8, [x21, #0x9ea]
006635A40  ldr      x22, [x22, #0x98]
006635A44  mov      x19, x1
006635A48  mov      x20, x0
006635A4C  tbnz     w8, #0, #0x6635a70
006635A50  adrp     x0, #0x8eea000
006635A54  ldr      x0, [x0, #0xf18]
006635A58  bl       #0x382bd14 ; 
006635A5C  adrp     x0, #0x8f0d000
006635A60  ldr      x0, [x0, #0x98]
006635A64  bl       #0x382bd14 ; 
006635A68  mov      w8, #1
006635A6C  strb     w8, [x21, #0x9ea]
006635A70  ldr      x2, [x22]
006635A74  ldrb     w8, [x2, #0x53]
006635A78  tbnz     w8, #5, #0x6635c20
006635A7C  cbz      x19, #0x6635c48
006635A80  mov      x0, x19
006635A84  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006635A88  ldr      w8, [x20, #0x30]
006635A8C  cmp      w8, #1
006635A90  b.lt     #0x6635c04
006635A94  adrp     x22, #0x8f0c000
006635A98  adrp     x23, #0x8f0c000
006635A9C  ldr      x22, [x22, #0xea0]
006635AA0  ldr      x23, [x23, #0xea8]
006635AA4  mov      x28, xzr
006635AA8  mov      x29, xzr
006635AAC  ldr      x21, [x20, #0x40]
006635AB0  cbz      x21, #0x6635c48
006635AB4  ldr      w8, [x21, #0x18]
006635AB8  cmp      x29, x8
006635ABC  b.hs     #0x6635c4c
006635AC0  add      x0, x21, x28
006635AC4  ldr      w24, [x0, #0x20]!
006635AC8  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006635ACC  adrp     x8, #0x9599000
006635AD0  ldrb     w8, [x8, #0xac2]
006635AD4  mov      w25, w0
006635AD8  cbnz     w8, #0x6635af4
006635ADC  adrp     x0, #0x8f0c000
006635AE0  ldr      x0, [x0, #0xe98]
006635AE4  bl       #0x382bd14 ; 
006635AE8  adrp     x8, #0x9599000
006635AEC  mov      w9, #1
006635AF0  strb     w9, [x8, #0xac2]
006635AF4  adrp     x8, #0x8f0c000
006635AF8  ldr      x8, [x8, #0xe98]
006635AFC  ldr      x1, [x8]
006635B00  ldrb     w8, [x1, #0x53]
006635B04  tbnz     w8, #5, #0x6635b14
006635B08  add      x8, x21, x28
006635B0C  ldr      w26, [x8, #0x2c]
006635B10  b        #0x6635b28 ; 
006635B14  ldr      x8, [x1, #0x60]
006635B18  add      x9, x21, x28
006635B1C  add      x0, x9, #0x20
006635B20  blr      x8
006635B24  mov      w26, w0
006635B28  adrp     x8, #0x9599000
006635B2C  ldrb     w8, [x8, #0xac3]
006635B30  cbnz     w8, #0x6635b48
006635B34  mov      x0, x22
006635B38  bl       #0x382bd14 ; 
006635B3C  mov      w8, #1
006635B40  adrp     x9, #0x9599000
006635B44  strb     w8, [x9, #0xac3]
006635B48  ldr      x1, [x22]
006635B4C  ldrb     w8, [x1, #0x53]
006635B50  tbnz     w8, #5, #0x6635b60
006635B54  add      x8, x21, x28
006635B58  ldr      x27, [x8, #0x30]
006635B5C  b        #0x6635b74 ; 
006635B60  ldr      x8, [x1, #0x60]
006635B64  add      x9, x21, x28
006635B68  add      x0, x9, #0x20
006635B6C  blr      x8
006635B70  mov      x27, x0
006635B74  adrp     x8, #0x9599000
006635B78  ldrb     w8, [x8, #0xac4]
006635B7C  cbnz     w8, #0x6635b94
006635B80  mov      x0, x23
006635B84  bl       #0x382bd14 ; 
006635B88  mov      w8, #1
006635B8C  adrp     x9, #0x9599000
006635B90  strb     w8, [x9, #0xac4]
006635B94  ldr      x1, [x23]
006635B98  ldrb     w8, [x1, #0x53]
006635B9C  tbnz     w8, #5, #0x6635bac
006635BA0  add      x8, x21, x28
006635BA4  ldr      x0, [x8, #0x48]
006635BA8  b        #0x6635bbc ; 
006635BAC  ldr      x8, [x1, #0x60]
006635BB0  add      x9, x21, x28
006635BB4  add      x0, x9, #0x20
006635BB8  blr      x8
006635BBC  cbz      x0, #0x6635c48
006635BC0  adrp     x8, #0x8eea000
006635BC4  ldr      x8, [x8, #0xf18]
006635BC8  ldr      x1, [x8]
006635BCC  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
006635BD0  mov      x5, x0
006635BD4  mov      x0, x19
006635BD8  mov      w1, w24
006635BDC  mov      w2, w25
006635BE0  mov      w3, w26
006635BE4  mov      x4, x27
006635BE8  mov      x6, xzr
006635BEC  bl       #0x6632e88 ; HotFix.BattleLogic.WeightRandom$$Add
006635BF0  ldrsw    x8, [x20, #0x30]
006635BF4  add      x29, x29, #1
006635BF8  add      x28, x28, #0x38
006635BFC  cmp      x29, x8
006635C00  b.lt     #0x6635aac
006635C04  ldp      x20, x19, [sp, #0x50]
006635C08  ldp      x22, x21, [sp, #0x40]
006635C0C  ldp      x24, x23, [sp, #0x30]
006635C10  ldp      x26, x25, [sp, #0x20]
006635C14  ldp      x28, x27, [sp, #0x10]
006635C18  ldp      x29, x30, [sp], #0x60
006635C1C  ret      
006635C20  ldr      x3, [x2, #0x60]
006635C24  mov      x0, x20
006635C28  mov      x1, x19
006635C2C  ldp      x20, x19, [sp, #0x50]
006635C30  ldp      x22, x21, [sp, #0x40]
006635C34  ldp      x24, x23, [sp, #0x30]
006635C38  ldp      x26, x25, [sp, #0x20]
006635C3C  ldp      x28, x27, [sp, #0x10]
006635C40  ldp      x29, x30, [sp], #0x60
006635C44  br       x3
006635C48  bl       #0x382bfb8 ; 
006635C4C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$CopyWeightRandomFull
; RVA 0x6635C50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006635C50  str      x30, [sp, #-0x60]!
006635C54  stp      x28, x27, [sp, #0x10]
006635C58  stp      x26, x25, [sp, #0x20]
006635C5C  stp      x24, x23, [sp, #0x30]
006635C60  stp      x22, x21, [sp, #0x40]
006635C64  stp      x20, x19, [sp, #0x50]
006635C68  adrp     x21, #0x9599000
006635C6C  adrp     x22, #0x8f0d000
006635C70  ldrb     w8, [x21, #0x9eb]
006635C74  ldr      x22, [x22, #0xa0]
006635C78  mov      x19, x1
006635C7C  mov      x20, x0
006635C80  tbnz     w8, #0, #0x6635cb0
006635C84  adrp     x0, #0x8ebf000
006635C88  ldr      x0, [x0, #0x840]
006635C8C  bl       #0x382bd14 ; 
006635C90  adrp     x0, #0x8f0c000
006635C94  ldr      x0, [x0, #0xf90]
006635C98  bl       #0x382bd14 ; 
006635C9C  adrp     x0, #0x8f0d000
006635CA0  ldr      x0, [x0, #0xa0]
006635CA4  bl       #0x382bd14 ; 
006635CA8  mov      w8, #1
006635CAC  strb     w8, [x21, #0x9eb]
006635CB0  ldr      x2, [x22]
006635CB4  ldrb     w8, [x2, #0x53]
006635CB8  tbnz     w8, #5, #0x6635ce8
006635CBC  cbz      x19, #0x6635e6c
006635CC0  mov      x0, x19
006635CC4  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006635CC8  mov      x21, x19
006635CCC  ldr      x8, [x21, #0x40]!
006635CD0  cbz      x8, #0x6635d10
006635CD4  ldr      w9, [x19, #0x34]
006635CD8  ldr      w22, [x20, #0x30]
006635CDC  cmp      w9, w22
006635CE0  b.lt     #0x6635d14
006635CE4  b        #0x6635d78 ; 
006635CE8  ldr      x3, [x2, #0x60]
006635CEC  mov      x0, x20
006635CF0  mov      x1, x19
006635CF4  ldp      x20, x19, [sp, #0x50]
006635CF8  ldp      x22, x21, [sp, #0x40]
006635CFC  ldp      x24, x23, [sp, #0x30]
006635D00  ldp      x26, x25, [sp, #0x20]
006635D04  ldp      x28, x27, [sp, #0x10]
006635D08  ldr      x30, [sp], #0x60
006635D0C  br       x3
006635D10  ldr      w22, [x20, #0x30]
006635D14  adrp     x8, #0x8ebf000
006635D18  ldr      x8, [x8, #0x840]
006635D1C  ldr      x0, [x8]
006635D20  ldr      w8, [x0, #0xe0]
006635D24  cbnz     w8, #0x6635d2c
006635D28  bl       #0x382be8c ; 
006635D2C  mov      w1, #0x32
006635D30  mov      w0, w22
006635D34  mov      x2, xzr
006635D38  bl       #0x7bd6858 ; System.Math$$Max
006635D3C  adrp     x8, #0x8f0c000
006635D40  ldr      x8, [x8, #0xf90]
006635D44  mov      w1, w0
006635D48  ldr      x8, [x8]
006635D4C  mov      x0, x8
006635D50  bl       #0x382bdfc ; 
006635D54  mov      x1, x0
006635D58  str      x0, [x21]
006635D5C  mov      x0, x21
006635D60  bl       #0x382bcb8 ; 
006635D64  ldr      x8, [x21]
006635D68  cbz      x8, #0x6635e6c
006635D6C  ldr      x9, [x8, #0x18]
006635D70  str      w9, [x19, #0x34]
006635D74  ldr      w22, [x20, #0x30]
006635D78  stp      wzr, w22, [x19, #0x2c]
006635D7C  str      wzr, [x19, #0x38]
006635D80  ldr      w9, [x20, #0x30]
006635D84  cmp      w9, #1
006635D88  b.lt     #0x6635e70
006635D8C  adrp     x22, #0x8f0c000
006635D90  ldr      x22, [x22, #0xe98]
006635D94  mov      x23, xzr
006635D98  mov      w24, #0x2c
006635D9C  adrp     x25, #0x9599000
006635DA0  mov      w26, #1
006635DA4  ldr      x9, [x20, #0x40]
006635DA8  cbz      x9, #0x6635e6c
006635DAC  ldr      w10, [x8, #0x18]
006635DB0  cmp      x23, x10
006635DB4  b.hs     #0x6635e8c
006635DB8  ldr      w10, [x9, #0x18]
006635DBC  cmp      x23, x10
006635DC0  b.hs     #0x6635e8c
006635DC4  add      x8, x8, x24
006635DC8  add      x9, x9, x24
006635DCC  sub      x0, x8, #0xc
006635DD0  sub      x1, x9, #0xc
006635DD4  bl       #0x6632604 ; HotFix.BattleLogic.WeightRandomData$$CopyFrom
006635DD8  ldr      x27, [x21]
006635DDC  cbz      x27, #0x6635e6c
006635DE0  ldr      w8, [x27, #0x18]
006635DE4  cmp      x23, x8
006635DE8  b.hs     #0x6635e8c
006635DEC  ldr      w28, [x19, #0x2c]
006635DF0  add      x8, x27, x24
006635DF4  sub      x0, x8, #0xc
006635DF8  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006635DFC  add      w8, w0, w28
006635E00  str      w8, [x19, #0x2c]
006635E04  ldrb     w8, [x25, #0xac2]
006635E08  cbnz     w8, #0x6635e18
006635E0C  mov      x0, x22
006635E10  bl       #0x382bd14 ; 
006635E14  strb     w26, [x25, #0xac2]
006635E18  ldr      x1, [x22]
006635E1C  ldrb     w8, [x1, #0x53]
006635E20  tbnz     w8, #5, #0x6635e2c
006635E24  ldr      w0, [x27, x24]
006635E28  b        #0x6635e3c ; 
006635E2C  ldr      x8, [x1, #0x60]
006635E30  add      x9, x27, x24
006635E34  sub      x0, x9, #0xc
006635E38  blr      x8
006635E3C  cmp      w0, #1
006635E40  b.lt     #0x6635e50
006635E44  ldr      w8, [x19, #0x38]
006635E48  orr      w8, w8, w0
006635E4C  str      w8, [x19, #0x38]
006635E50  ldrsw    x8, [x20, #0x30]
006635E54  add      x23, x23, #1
006635E58  cmp      x23, x8
006635E5C  b.ge     #0x6635e70
006635E60  ldr      x8, [x21]
006635E64  add      x24, x24, #0x38
006635E68  cbnz     x8, #0x6635da4
006635E6C  bl       #0x382bfb8 ; 
006635E70  ldp      x20, x19, [sp, #0x50]
006635E74  ldp      x22, x21, [sp, #0x40]
006635E78  ldp      x24, x23, [sp, #0x30]
006635E7C  ldp      x26, x25, [sp, #0x20]
006635E80  ldp      x28, x27, [sp, #0x10]
006635E84  ldr      x30, [sp], #0x60
006635E88  ret      
006635E8C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$RestoreMissing
; RVA 0x6635E90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006635E90  stp      x29, x30, [sp, #-0x60]!
006635E94  stp      x28, x27, [sp, #0x10]
006635E98  stp      x26, x25, [sp, #0x20]
006635E9C  stp      x24, x23, [sp, #0x30]
006635EA0  stp      x22, x21, [sp, #0x40]
006635EA4  stp      x20, x19, [sp, #0x50]
006635EA8  adrp     x21, #0x9599000
006635EAC  adrp     x22, #0x8f0d000
006635EB0  ldrb     w8, [x21, #0x9ec]
006635EB4  ldr      x22, [x22, #0xa8]
006635EB8  mov      x19, x1
006635EBC  mov      x20, x0
006635EC0  tbnz     w8, #0, #0x6635ee4
006635EC4  adrp     x0, #0x8eea000
006635EC8  ldr      x0, [x0, #0xf18]
006635ECC  bl       #0x382bd14 ; 
006635ED0  adrp     x0, #0x8f0d000
006635ED4  ldr      x0, [x0, #0xa8]
006635ED8  bl       #0x382bd14 ; 
006635EDC  mov      w8, #1
006635EE0  strb     w8, [x21, #0x9ec]
006635EE4  ldr      x2, [x22]
006635EE8  ldrb     w8, [x2, #0x53]
006635EEC  tbnz     w8, #5, #0x66360a4
006635EF0  cbz      x19, #0x66360cc
006635EF4  ldr      w8, [x19, #0x30]
006635EF8  cmp      w8, #1
006635EFC  b.lt     #0x6636088
006635F00  adrp     x22, #0x8f0c000
006635F04  adrp     x23, #0x8f0c000
006635F08  ldr      x22, [x22, #0xea0]
006635F0C  ldr      x23, [x23, #0xea8]
006635F10  mov      x28, xzr
006635F14  mov      x29, xzr
006635F18  ldr      x21, [x19, #0x40]
006635F1C  cbz      x21, #0x66360cc
006635F20  ldr      w8, [x21, #0x18]
006635F24  cmp      x29, x8
006635F28  b.hs     #0x66360d0
006635F2C  add      x24, x21, x28
006635F30  mov      x25, x24
006635F34  ldr      w1, [x25, #0x20]!
006635F38  mov      x0, x20
006635F3C  bl       #0x66331e4 ; HotFix.BattleLogic.WeightRandom$$Exist
006635F40  tbnz     w0, #0, #0x6636074
006635F44  ldr      w24, [x24, #0x20]
006635F48  mov      x0, x25
006635F4C  bl       #0x6632120 ; HotFix.BattleLogic.WeightRandomData$$PracticalWeight
006635F50  adrp     x8, #0x9599000
006635F54  ldrb     w8, [x8, #0xac2]
006635F58  mov      w25, w0
006635F5C  cbnz     w8, #0x6635f78
006635F60  adrp     x0, #0x8f0c000
006635F64  ldr      x0, [x0, #0xe98]
006635F68  bl       #0x382bd14 ; 
006635F6C  adrp     x8, #0x9599000
006635F70  mov      w9, #1
006635F74  strb     w9, [x8, #0xac2]
006635F78  adrp     x8, #0x8f0c000
006635F7C  ldr      x8, [x8, #0xe98]
006635F80  ldr      x1, [x8]
006635F84  ldrb     w8, [x1, #0x53]
006635F88  tbnz     w8, #5, #0x6635f98
006635F8C  add      x8, x21, x28
006635F90  ldr      w26, [x8, #0x2c]
006635F94  b        #0x6635fac ; 
006635F98  ldr      x8, [x1, #0x60]
006635F9C  add      x9, x21, x28
006635FA0  add      x0, x9, #0x20
006635FA4  blr      x8
006635FA8  mov      w26, w0
006635FAC  adrp     x8, #0x9599000
006635FB0  ldrb     w8, [x8, #0xac3]
006635FB4  cbnz     w8, #0x6635fcc
006635FB8  mov      x0, x22
006635FBC  bl       #0x382bd14 ; 
006635FC0  mov      w8, #1
006635FC4  adrp     x9, #0x9599000
006635FC8  strb     w8, [x9, #0xac3]
006635FCC  ldr      x1, [x22]
006635FD0  ldrb     w8, [x1, #0x53]
006635FD4  tbnz     w8, #5, #0x6635fe4
006635FD8  add      x8, x21, x28
006635FDC  ldr      x27, [x8, #0x30]
006635FE0  b        #0x6635ff8 ; 
006635FE4  ldr      x8, [x1, #0x60]
006635FE8  add      x9, x21, x28
006635FEC  add      x0, x9, #0x20
006635FF0  blr      x8
006635FF4  mov      x27, x0
006635FF8  adrp     x8, #0x9599000
006635FFC  ldrb     w8, [x8, #0xac4]
006636000  cbnz     w8, #0x6636018
006636004  mov      x0, x23
006636008  bl       #0x382bd14 ; 
00663600C  mov      w8, #1
006636010  adrp     x9, #0x9599000
006636014  strb     w8, [x9, #0xac4]
006636018  ldr      x1, [x23]
00663601C  ldrb     w8, [x1, #0x53]
006636020  tbnz     w8, #5, #0x6636030
006636024  add      x8, x21, x28
006636028  ldr      x0, [x8, #0x48]
00663602C  b        #0x6636040 ; 
006636030  ldr      x8, [x1, #0x60]
006636034  add      x9, x21, x28
006636038  add      x0, x9, #0x20
00663603C  blr      x8
006636040  cbz      x0, #0x66360cc
006636044  adrp     x8, #0x8eea000
006636048  ldr      x8, [x8, #0xf18]
00663604C  ldr      x1, [x8]
006636050  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
006636054  mov      x5, x0
006636058  mov      x0, x20
00663605C  mov      w1, w24
006636060  mov      w2, w25
006636064  mov      w3, w26
006636068  mov      x4, x27
00663606C  mov      x6, xzr
006636070  bl       #0x6632e88 ; HotFix.BattleLogic.WeightRandom$$Add
006636074  ldrsw    x8, [x19, #0x30]
006636078  add      x29, x29, #1
00663607C  add      x28, x28, #0x38
006636080  cmp      x29, x8
006636084  b.lt     #0x6635f18
006636088  ldp      x20, x19, [sp, #0x50]
00663608C  ldp      x22, x21, [sp, #0x40]
006636090  ldp      x24, x23, [sp, #0x30]
006636094  ldp      x26, x25, [sp, #0x20]
006636098  ldp      x28, x27, [sp, #0x10]
00663609C  ldp      x29, x30, [sp], #0x60
0066360A0  ret      
0066360A4  ldr      x3, [x2, #0x60]
0066360A8  mov      x0, x20
0066360AC  mov      x1, x19
0066360B0  ldp      x20, x19, [sp, #0x50]
0066360B4  ldp      x22, x21, [sp, #0x40]
0066360B8  ldp      x24, x23, [sp, #0x30]
0066360BC  ldp      x26, x25, [sp, #0x20]
0066360C0  ldp      x28, x27, [sp, #0x10]
0066360C4  ldp      x29, x30, [sp], #0x60
0066360C8  br       x3
0066360CC  bl       #0x382bfb8 ; 
0066360D0  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$RandomOneSubSkillByParent
; RVA 0x66346A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066346A0  sub      sp, sp, #0x80
0066346A4  stp      x29, x30, [sp, #0x20]
0066346A8  stp      x28, x27, [sp, #0x30]
0066346AC  stp      x26, x25, [sp, #0x40]
0066346B0  stp      x24, x23, [sp, #0x50]
0066346B4  stp      x22, x21, [sp, #0x60]
0066346B8  stp      x20, x19, [sp, #0x70]
0066346BC  adrp     x19, #0x9599000
0066346C0  adrp     x23, #0x8f0d000
0066346C4  ldrb     w8, [x19, #0x9ed]
0066346C8  ldr      x23, [x23, #0x40]
0066346CC  mov      x26, x4
0066346D0  mov      x20, x3
0066346D4  mov      x24, x2
0066346D8  mov      w21, w1
0066346DC  mov      x22, x0
0066346E0  tbnz     w8, #0, #0x663474c
0066346E4  adrp     x0, #0x8f0d000
0066346E8  ldr      x0, [x0, #0x48]
0066346EC  bl       #0x382bd14 ; 
0066346F0  adrp     x0, #0x8ebf000
0066346F4  ldr      x0, [x0, #0xba0]
0066346F8  bl       #0x382bd14 ; 
0066346FC  adrp     x0, #0x8f08000
006634700  ldr      x0, [x0, #0x630]
006634704  bl       #0x382bd14 ; 
006634708  adrp     x0, #0x8ec2000
00663470C  ldr      x0, [x0, #0x268]
006634710  bl       #0x382bd14 ; 
006634714  adrp     x0, #0x8ebf000
006634718  ldr      x0, [x0, #0x840]
00663471C  bl       #0x382bd14 ; 
006634720  adrp     x0, #0x8f0d000
006634724  ldr      x0, [x0, #0x40]
006634728  bl       #0x382bd14 ; 
00663472C  adrp     x0, #0x8f0d000
006634730  ldr      x0, [x0, #0x50]
006634734  bl       #0x382bd14 ; 
006634738  adrp     x0, #0x8f0d000
00663473C  ldr      x0, [x0, #0x58]
006634740  bl       #0x382bd14 ; 
006634744  mov      w8, #1
006634748  strb     w8, [x19, #0x9ed]
00663474C  ldr      x5, [x23]
006634750  ldrb     w8, [x5, #0x53]
006634754  tbnz     w8, #5, #0x66347b4
006634758  adrp     x8, #0x8f0d000
00663475C  ldr      x8, [x8, #0x48]
006634760  ldr      x8, [x8]
006634764  ldr      x8, [x8, #0xb8]
006634768  ldr      x0, [x8]
00663476C  cbz      x0, #0x6634f10
006634770  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006634774  adrp     x8, #0x9591000
006634778  ldrb     w8, [x8, #0xa4b]
00663477C  cbnz     w8, #0x6634798
006634780  adrp     x0, #0x8ee5000
006634784  ldr      x0, [x0, #0xb28]
006634788  bl       #0x382bd14 ; 
00663478C  mov      w8, #1
006634790  adrp     x9, #0x9591000
006634794  strb     w8, [x9, #0xa4b]
006634798  adrp     x8, #0x8ee5000
00663479C  ldr      x8, [x8, #0xb28]
0066347A0  ldr      x1, [x8]
0066347A4  ldrb     w8, [x1, #0x53]
0066347A8  tbnz     w8, #5, #0x66347ec
0066347AC  ldr      x25, [x22, #0x20]
0066347B0  b        #0x66347fc ; 
0066347B4  ldr      x6, [x5, #0x60]
0066347B8  mov      x0, x22
0066347BC  mov      w1, w21
0066347C0  mov      x2, x24
0066347C4  mov      x3, x20
0066347C8  mov      x4, x26
0066347CC  ldp      x20, x19, [sp, #0x70]
0066347D0  ldp      x22, x21, [sp, #0x60]
0066347D4  ldp      x24, x23, [sp, #0x50]
0066347D8  ldp      x26, x25, [sp, #0x40]
0066347DC  ldp      x28, x27, [sp, #0x30]
0066347E0  ldp      x29, x30, [sp, #0x20]
0066347E4  add      sp, sp, #0x80
0066347E8  br       x6
0066347EC  ldr      x8, [x1, #0x60]
0066347F0  mov      x0, x22
0066347F4  blr      x8
0066347F8  mov      x25, x0
0066347FC  cbz      x25, #0x6634f10
006634800  adrp     x8, #0x9598000
006634804  ldrb     w8, [x8, #0xfcc]
006634808  cbnz     w8, #0x6634824
00663480C  adrp     x0, #0x8f06000
006634810  ldr      x0, [x0, #0x470]
006634814  bl       #0x382bd14 ; 
006634818  mov      w8, #1
00663481C  adrp     x9, #0x9598000
006634820  strb     w8, [x9, #0xfcc]
006634824  adrp     x8, #0x8f06000
006634828  ldr      x8, [x8, #0x470]
00663482C  ldr      x1, [x8]
006634830  ldrb     w8, [x1, #0x53]
006634834  tbnz     w8, #5, #0x6634840
006634838  ldr      x0, [x25, #0x200]
00663483C  b        #0x663484c ; 
006634840  ldr      x8, [x1, #0x60]
006634844  mov      x0, x25
006634848  blr      x8
00663484C  cbz      x0, #0x6634f10
006634850  mov      w1, w21
006634854  mov      x2, xzr
006634858  str      x24, [sp]
00663485C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006634860  cbz      x0, #0x6634f10
006634864  mov      x1, xzr
006634868  bl       #0x6b0a438 ; LocalModels.Bean.Skill_Main$$GetUpgradeSkillId
00663486C  cbz      x0, #0x6634f10
006634870  ldr      w8, [x0, #0x18]
006634874  mov      x25, x0
006634878  cmp      w8, #1
00663487C  b.lt     #0x6634e30
006634880  adrp     x27, #0x8f09000
006634884  ldr      x27, [x27, #0x300]
006634888  mov      x23, xzr
00663488C  mov      w19, #1
006634890  adrp     x24, #0x9599000
006634894  str      x26, [sp, #8]
006634898  adrp     x8, #0x9591000
00663489C  ldrb     w8, [x8, #0xa4b]
0066348A0  cbnz     w8, #0x66348b8
0066348A4  adrp     x0, #0x8ee5000
0066348A8  ldr      x0, [x0, #0xb28]
0066348AC  bl       #0x382bd14 ; 
0066348B0  adrp     x8, #0x9591000
0066348B4  strb     w19, [x8, #0xa4b]
0066348B8  adrp     x8, #0x8ee5000
0066348BC  ldr      x8, [x8, #0xb28]
0066348C0  ldr      x1, [x8]
0066348C4  ldrb     w8, [x1, #0x53]
0066348C8  tbnz     w8, #5, #0x66348d4
0066348CC  ldr      x21, [x22, #0x20]
0066348D0  b        #0x66348e4 ; 
0066348D4  ldr      x8, [x1, #0x60]
0066348D8  mov      x0, x22
0066348DC  blr      x8
0066348E0  mov      x21, x0
0066348E4  cbz      x21, #0x6634f10
0066348E8  adrp     x8, #0x9598000
0066348EC  ldrb     w8, [x8, #0xfcc]
0066348F0  cbnz     w8, #0x6634908
0066348F4  adrp     x0, #0x8f06000
0066348F8  ldr      x0, [x0, #0x470]
0066348FC  bl       #0x382bd14 ; 
006634900  adrp     x8, #0x9598000
006634904  strb     w19, [x8, #0xfcc]
006634908  adrp     x8, #0x8f06000
00663490C  ldr      x8, [x8, #0x470]
006634910  ldr      x1, [x8]
006634914  ldrb     w8, [x1, #0x53]
006634918  tbnz     w8, #5, #0x6634924
00663491C  ldr      x0, [x21, #0x200]
006634920  b        #0x6634930 ; 
006634924  ldr      x8, [x1, #0x60]
006634928  mov      x0, x21
00663492C  blr      x8
006634930  ldr      w8, [x25, #0x18]
006634934  cmp      x23, x8
006634938  b.hs     #0x6634f14
00663493C  cbz      x0, #0x6634f10
006634940  add      x8, x25, x23, lsl #2
006634944  ldr      w1, [x8, #0x20]
006634948  mov      x2, xzr
00663494C  bl       #0x64d8398 ; LocalModels.LocalModelManager$$GetSkillGroup_BranchSurvivorGroup
006634950  cbz      x0, #0x6634f10
006634954  adrp     x8, #0x9599000
006634958  ldrb     w8, [x8, #0xac9]
00663495C  mov      x29, x0
006634960  cbnz     w8, #0x6634978
006634964  adrp     x0, #0x8f0d000
006634968  ldr      x0, [x0, #0x60]
00663496C  bl       #0x382bd14 ; 
006634970  adrp     x8, #0x9599000
006634974  strb     w19, [x8, #0xac9]
006634978  adrp     x8, #0x8f0d000
00663497C  ldr      x8, [x8, #0x60]
006634980  ldr      x1, [x8]
006634984  ldrb     w8, [x1, #0x53]
006634988  tbnz     w8, #5, #0x6634994
00663498C  ldr      w28, [x29, #0x24]
006634990  b        #0x66349a4 ; 
006634994  ldr      x8, [x1, #0x60]
006634998  mov      x0, x29
00663499C  blr      x8
0066349A0  mov      w28, w0
0066349A4  adrp     x8, #0x9591000
0066349A8  ldrb     w8, [x8, #0xa4b]
0066349AC  cbnz     w8, #0x66349c4
0066349B0  adrp     x0, #0x8ee5000
0066349B4  ldr      x0, [x0, #0xb28]
0066349B8  bl       #0x382bd14 ; 
0066349BC  adrp     x8, #0x9591000
0066349C0  strb     w19, [x8, #0xa4b]
0066349C4  adrp     x8, #0x8ee5000
0066349C8  ldr      x8, [x8, #0xb28]
0066349CC  ldr      x1, [x8]
0066349D0  ldrb     w8, [x1, #0x53]
0066349D4  tbnz     w8, #5, #0x66349e0
0066349D8  ldr      x21, [x22, #0x20]
0066349DC  b        #0x66349f0 ; 
0066349E0  ldr      x8, [x1, #0x60]
0066349E4  mov      x0, x22
0066349E8  blr      x8
0066349EC  mov      x21, x0
0066349F0  cbz      x21, #0x6634f10
0066349F4  adrp     x8, #0x9598000
0066349F8  ldrb     w8, [x8, #0xfcc]
0066349FC  cbnz     w8, #0x6634a14
006634A00  adrp     x0, #0x8f06000
006634A04  ldr      x0, [x0, #0x470]
006634A08  bl       #0x382bd14 ; 
006634A0C  adrp     x8, #0x9598000
006634A10  strb     w19, [x8, #0xfcc]
006634A14  adrp     x8, #0x8f06000
006634A18  ldr      x8, [x8, #0x470]
006634A1C  ldr      x1, [x8]
006634A20  ldrb     w8, [x1, #0x53]
006634A24  tbnz     w8, #5, #0x6634a30
006634A28  ldr      x0, [x21, #0x200]
006634A2C  b        #0x6634a3c ; 
006634A30  ldr      x8, [x1, #0x60]
006634A34  mov      x0, x21
006634A38  blr      x8
006634A3C  mov      x1, x20
006634A40  mov      w2, w28
006634A44  mov      x3, xzr
006634A48  bl       #0x691f410 ; HotFix.BattleLogic.GameUtils$$CheckCanStudySkill
006634A4C  tbz      w0, #0, #0x6634a70
006634A50  cbz      x26, #0x6634f10
006634A54  adrp     x8, #0x8f08000
006634A58  ldr      x8, [x8, #0x630]
006634A5C  mov      x0, x26
006634A60  mov      w1, w28
006634A64  ldr      x2, [x8]
006634A68  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006634A6C  tbz      w0, #0, #0x6634ab4
006634A70  adrp     x8, #0x8ebf000
006634A74  ldr      x8, [x8, #0xba0]
006634A78  add      x1, sp, #0x14
006634A7C  str      w28, [sp, #0x14]
006634A80  ldr      x0, [x8]
006634A84  bl       #0x382be94 ; 
006634A88  adrp     x8, #0x8f0d000
006634A8C  ldr      x8, [x8, #0x50]
006634A90  mov      x1, x0
006634A94  mov      x2, xzr
006634A98  ldr      x8, [x8]
006634A9C  mov      x0, x8
006634AA0  bl       #0x79d140c ; System.String$$Format
006634AA4  mov      x1, x0
006634AA8  mov      x0, x22
006634AAC  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634AB0  b        #0x6634e20 ; 
006634AB4  adrp     x8, #0x9591000
006634AB8  ldrb     w8, [x8, #0xa4b]
006634ABC  cbnz     w8, #0x6634ad4
006634AC0  adrp     x0, #0x8ee5000
006634AC4  ldr      x0, [x0, #0xb28]
006634AC8  bl       #0x382bd14 ; 
006634ACC  adrp     x8, #0x9591000
006634AD0  strb     w19, [x8, #0xa4b]
006634AD4  adrp     x8, #0x8ee5000
006634AD8  ldr      x8, [x8, #0xb28]
006634ADC  ldr      x1, [x8]
006634AE0  ldrb     w8, [x1, #0x53]
006634AE4  tbnz     w8, #5, #0x6634af0
006634AE8  ldr      x21, [x22, #0x20]
006634AEC  b        #0x6634b00 ; 
006634AF0  ldr      x8, [x1, #0x60]
006634AF4  mov      x0, x22
006634AF8  blr      x8
006634AFC  mov      x21, x0
006634B00  cbz      x21, #0x6634f10
006634B04  adrp     x8, #0x9598000
006634B08  ldrb     w8, [x8, #0xfcc]
006634B0C  cbnz     w8, #0x6634b24
006634B10  adrp     x0, #0x8f06000
006634B14  ldr      x0, [x0, #0x470]
006634B18  bl       #0x382bd14 ; 
006634B1C  adrp     x8, #0x9598000
006634B20  strb     w19, [x8, #0xfcc]
006634B24  adrp     x8, #0x8f06000
006634B28  ldr      x8, [x8, #0x470]
006634B2C  ldr      x1, [x8]
006634B30  ldrb     w8, [x1, #0x53]
006634B34  tbnz     w8, #5, #0x6634b40
006634B38  ldr      x0, [x21, #0x200]
006634B3C  b        #0x6634b4c ; 
006634B40  ldr      x8, [x1, #0x60]
006634B44  mov      x0, x21
006634B48  blr      x8
006634B4C  cbz      x0, #0x6634f10
006634B50  mov      w1, w28
006634B54  mov      x2, xzr
006634B58  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006634B5C  cbz      x0, #0x6634f10
006634B60  ldrb     w8, [x24, #0x4c9]
006634B64  mov      x21, x0
006634B68  cbnz     w8, #0x6634b78
006634B6C  mov      x0, x27
006634B70  bl       #0x382bd14 ; 
006634B74  strb     w19, [x24, #0x4c9]
006634B78  ldr      x1, [x27]
006634B7C  ldrb     w8, [x1, #0x53]
006634B80  tbnz     w8, #5, #0x6634b90
006634B84  ldr      x0, [x21, #0x98]
006634B88  cbnz     x0, #0x6634ba0
006634B8C  b        #0x6634c58 ; 
006634B90  ldr      x8, [x1, #0x60]
006634B94  mov      x0, x21
006634B98  blr      x8
006634B9C  cbz      x0, #0x6634c58
006634BA0  mov      x26, xzr
006634BA4  ldrb     w8, [x24, #0x4c9]
006634BA8  cbnz     w8, #0x6634bb8
006634BAC  mov      x0, x27
006634BB0  bl       #0x382bd14 ; 
006634BB4  strb     w19, [x24, #0x4c9]
006634BB8  ldr      x1, [x27]
006634BBC  ldrb     w8, [x1, #0x53]
006634BC0  tbnz     w8, #5, #0x6634bcc
006634BC4  ldr      x0, [x21, #0x98]
006634BC8  b        #0x6634bd8 ; 
006634BCC  ldr      x8, [x1, #0x60]
006634BD0  mov      x0, x21
006634BD4  blr      x8
006634BD8  cbz      x0, #0x6634f10
006634BDC  ldrsw    x8, [x0, #0x18]
006634BE0  cmp      x26, x8
006634BE4  b.ge     #0x6634c58
006634BE8  ldrb     w8, [x24, #0x4c9]
006634BEC  cbnz     w8, #0x6634bfc
006634BF0  mov      x0, x27
006634BF4  bl       #0x382bd14 ; 
006634BF8  strb     w19, [x24, #0x4c9]
006634BFC  ldr      x1, [x27]
006634C00  ldrb     w8, [x1, #0x53]
006634C04  tbnz     w8, #5, #0x6634c10
006634C08  ldr      x0, [x21, #0x98]
006634C0C  b        #0x6634c1c ; 
006634C10  ldr      x8, [x1, #0x60]
006634C14  mov      x0, x21
006634C18  blr      x8
006634C1C  cbz      x0, #0x6634f10
006634C20  ldr      w8, [x0, #0x18]
006634C24  cmp      x26, x8
006634C28  b.hs     #0x6634f14
006634C2C  cbz      x20, #0x6634f10
006634C30  add      x8, x0, x26, lsl #2
006634C34  ldr      w1, [x8, #0x20]
006634C38  adrp     x8, #0x8f08000
006634C3C  ldr      x8, [x8, #0x630]
006634C40  mov      x0, x20
006634C44  ldr      x2, [x8]
006634C48  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006634C4C  tbz      w0, #0, #0x6634d70
006634C50  add      x26, x26, #1
006634C54  b        #0x6634ba4 ; 
006634C58  adrp     x8, #0x9591000
006634C5C  ldrb     w8, [x8, #0xa4b]
006634C60  cbnz     w8, #0x6634c78
006634C64  adrp     x0, #0x8ee5000
006634C68  ldr      x0, [x0, #0xb28]
006634C6C  bl       #0x382bd14 ; 
006634C70  adrp     x8, #0x9591000
006634C74  strb     w19, [x8, #0xa4b]
006634C78  adrp     x8, #0x8ee5000
006634C7C  ldr      x8, [x8, #0xb28]
006634C80  ldr      x1, [x8]
006634C84  ldrb     w8, [x1, #0x53]
006634C88  tbnz     w8, #5, #0x6634c94
006634C8C  ldr      x21, [x22, #0x20]
006634C90  b        #0x6634ca4 ; 
006634C94  ldr      x8, [x1, #0x60]
006634C98  mov      x0, x22
006634C9C  blr      x8
006634CA0  mov      x21, x0
006634CA4  cbz      x21, #0x6634f10
006634CA8  adrp     x8, #0x9598000
006634CAC  ldrb     w8, [x8, #0xfcc]
006634CB0  cbnz     w8, #0x6634cc8
006634CB4  adrp     x0, #0x8f06000
006634CB8  ldr      x0, [x0, #0x470]
006634CBC  bl       #0x382bd14 ; 
006634CC0  adrp     x8, #0x9598000
006634CC4  strb     w19, [x8, #0xfcc]
006634CC8  adrp     x8, #0x8f06000
006634CCC  ldr      x8, [x8, #0x470]
006634CD0  ldr      x1, [x8]
006634CD4  ldrb     w8, [x1, #0x53]
006634CD8  tbnz     w8, #5, #0x6634ce4
006634CDC  ldr      x21, [x21, #0x200]
006634CE0  b        #0x6634cf4 ; 
006634CE4  ldr      x8, [x1, #0x60]
006634CE8  mov      x0, x21
006634CEC  blr      x8
006634CF0  mov      x21, x0
006634CF4  adrp     x8, #0x8f0d000
006634CF8  ldr      x8, [x8, #0x48]
006634CFC  adrp     x9, #0x9599000
006634D00  ldrb     w9, [x9, #0xaca]
006634D04  ldr      x8, [x8]
006634D08  ldr      x8, [x8, #0xb8]
006634D0C  ldr      x26, [x8]
006634D10  cbnz     w9, #0x6634d28
006634D14  adrp     x0, #0x8f0d000
006634D18  ldr      x0, [x0, #0x68]
006634D1C  bl       #0x382bd14 ; 
006634D20  adrp     x8, #0x9599000
006634D24  strb     w19, [x8, #0xaca]
006634D28  adrp     x8, #0x8f0d000
006634D2C  ldr      x8, [x8, #0x68]
006634D30  ldr      x1, [x8]
006634D34  ldrb     w8, [x1, #0x53]
006634D38  tbnz     w8, #5, #0x6634d44
006634D3C  ldr      w3, [x29, #0x28]
006634D40  b        #0x6634d54 ; 
006634D44  ldr      x8, [x1, #0x60]
006634D48  mov      x0, x29
006634D4C  blr      x8
006634D50  mov      w3, w0
006634D54  mov      x0, x21
006634D58  mov      x1, x26
006634D5C  mov      w2, w28
006634D60  mov      x4, x20
006634D64  mov      x5, xzr
006634D68  bl       #0x691f57c ; HotFix.BattleLogic.GameUtils$$AddSkillToRandom
006634D6C  b        #0x6634e1c ; 
006634D70  adrp     x8, #0x8ebf000
006634D74  ldr      x8, [x8, #0xba0]
006634D78  add      x1, sp, #0x1c
006634D7C  str      w28, [sp, #0x1c]
006634D80  ldr      x0, [x8]
006634D84  bl       #0x382be94 ; 
006634D88  ldrb     w8, [x24, #0x4c9]
006634D8C  mov      x28, x0
006634D90  cbnz     w8, #0x6634da0
006634D94  mov      x0, x27
006634D98  bl       #0x382bd14 ; 
006634D9C  strb     w19, [x24, #0x4c9]
006634DA0  ldr      x1, [x27]
006634DA4  ldrb     w8, [x1, #0x53]
006634DA8  tbnz     w8, #5, #0x6634db4
006634DAC  ldr      x0, [x21, #0x98]
006634DB0  b        #0x6634dc0 ; 
006634DB4  ldr      x8, [x1, #0x60]
006634DB8  mov      x0, x21
006634DBC  blr      x8
006634DC0  cbz      x0, #0x6634f10
006634DC4  ldr      w8, [x0, #0x18]
006634DC8  cmp      w26, w8
006634DCC  b.hs     #0x6634f14
006634DD0  add      x8, x0, x26, lsl #2
006634DD4  adrp     x9, #0x8ebf000
006634DD8  ldr      w8, [x8, #0x20]
006634DDC  ldr      x9, [x9, #0xba0]
006634DE0  add      x1, sp, #0x18
006634DE4  str      w8, [sp, #0x18]
006634DE8  ldr      x0, [x9]
006634DEC  bl       #0x382be94 ; 
006634DF0  adrp     x8, #0x8f0d000
006634DF4  ldr      x8, [x8, #0x58]
006634DF8  mov      x2, x0
006634DFC  mov      x1, x28
006634E00  mov      x3, xzr
006634E04  ldr      x8, [x8]
006634E08  mov      x0, x8
006634E0C  bl       #0x79e2794 ; System.String$$Format
006634E10  mov      x1, x0
006634E14  mov      x0, x22
006634E18  bl       #0x66345b4 ; HotFix.BattleLogic.WeightRandom$$LogError
006634E1C  ldr      x26, [sp, #8]
006634E20  ldrsw    x8, [x25, #0x18]
006634E24  add      x23, x23, #1
006634E28  cmp      x23, x8
006634E2C  b.lt     #0x6634898
006634E30  adrp     x8, #0x8f0d000
006634E34  ldr      x8, [x8, #0x48]
006634E38  ldr      x8, [x8]
006634E3C  ldr      x8, [x8, #0xb8]
006634E40  ldr      x0, [x8]
006634E44  cbz      x0, #0x6634f10
006634E48  ldr      x19, [sp]
006634E4C  mov      x1, x19
006634E50  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006634E54  cmp      w0, #1
006634E58  b.lt     #0x6634ef0
006634E5C  adrp     x8, #0x8ebf000
006634E60  ldr      x8, [x8, #0x840]
006634E64  mov      w21, w0
006634E68  ldr      x0, [x8]
006634E6C  ldr      w8, [x0, #0xe0]
006634E70  cbnz     w8, #0x6634e78
006634E74  bl       #0x382be8c ; 
006634E78  mov      w1, #1
006634E7C  mov      w0, w21
006634E80  mov      x2, xzr
006634E84  bl       #0x7bd69a0 ; System.Math$$Min
006634E88  adrp     x8, #0x8f0d000
006634E8C  ldr      x8, [x8, #0x48]
006634E90  ldr      x8, [x8]
006634E94  ldr      x8, [x8, #0xb8]
006634E98  ldr      x8, [x8]
006634E9C  cbz      x8, #0x6634f10
006634EA0  mov      w21, w0
006634EA4  mov      x0, x8
006634EA8  mov      x1, x19
006634EAC  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006634EB0  mov      w1, w0
006634EB4  mov      w0, w21
006634EB8  mov      x2, xzr
006634EBC  bl       #0x7bd69a0 ; System.Math$$Min
006634EC0  cbz      x19, #0x6634f10
006634EC4  adrp     x8, #0x8f0d000
006634EC8  ldr      x8, [x8, #0x48]
006634ECC  mov      w1, w0
006634ED0  ldr      x8, [x8]
006634ED4  ldr      x8, [x8, #0xb8]
006634ED8  ldr      x0, [x8]
006634EDC  cbz      x0, #0x6634f10
006634EE0  mov      x2, x19
006634EE4  mov      x3, x20
006634EE8  mov      x4, x26
006634EEC  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
006634EF0  ldp      x20, x19, [sp, #0x70]
006634EF4  ldp      x22, x21, [sp, #0x60]
006634EF8  ldp      x24, x23, [sp, #0x50]
006634EFC  ldp      x26, x25, [sp, #0x40]
006634F00  ldp      x28, x27, [sp, #0x30]
006634F04  ldp      x29, x30, [sp, #0x20]
006634F08  add      sp, sp, #0x80
006634F0C  ret      
006634F10  bl       #0x382bfb8 ; 
006634F14  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$OnRelease
; RVA 0x66360D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066360D4  stp      x30, x21, [sp, #-0x20]!
0066360D8  stp      x20, x19, [sp, #0x10]
0066360DC  adrp     x20, #0x9599000
0066360E0  adrp     x21, #0x8f0d000
0066360E4  ldrb     w8, [x20, #0x9ee]
0066360E8  ldr      x21, [x21, #0xb0]
0066360EC  mov      x19, x0
0066360F0  tbnz     w8, #0, #0x6636108
0066360F4  adrp     x0, #0x8f0d000
0066360F8  ldr      x0, [x0, #0xb0]
0066360FC  bl       #0x382bd14 ; 
006636100  mov      w8, #1
006636104  strb     w8, [x20, #0x9ee]
006636108  ldr      x1, [x21]
00663610C  ldrb     w8, [x1, #0x53]
006636110  tbnz     w8, #5, #0x6636140
006636114  mov      x0, x19
006636118  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
00663611C  mov      x0, x19
006636120  str      xzr, [x0, #0x40]!
006636124  mov      x1, xzr
006636128  bl       #0x382bcb8 ; 
00663612C  mov      x0, x19
006636130  ldp      x20, x19, [sp, #0x10]
006636134  mov      x1, xzr
006636138  ldp      x30, x21, [sp], #0x20
00663613C  b        #0x6b4d53c ; HotFix.Common.PooledElement$$OnRelease
006636140  ldr      x2, [x1, #0x60]
006636144  mov      x0, x19
006636148  ldp      x20, x19, [sp, #0x10]
00663614C  ldp      x30, x21, [sp], #0x20
006636150  br       x2

; HotFix.BattleLogic.WeightRandom$$Clear
; RVA 0x66352B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066352B0  stp      x30, x21, [sp, #-0x20]!
0066352B4  stp      x20, x19, [sp, #0x10]
0066352B8  adrp     x20, #0x9599000
0066352BC  adrp     x21, #0x8f0d000
0066352C0  ldrb     w8, [x20, #0x9ef]
0066352C4  ldr      x21, [x21, #0x80]
0066352C8  mov      x19, x0
0066352CC  tbnz     w8, #0, #0x66352e4
0066352D0  adrp     x0, #0x8f0d000
0066352D4  ldr      x0, [x0, #0x80]
0066352D8  bl       #0x382bd14 ; 
0066352DC  mov      w8, #1
0066352E0  strb     w8, [x20, #0x9ef]
0066352E4  ldr      x1, [x21]
0066352E8  ldrb     w8, [x1, #0x53]
0066352EC  tbnz     w8, #5, #0x6635304
0066352F0  str      xzr, [x19, #0x30]
0066352F4  str      wzr, [x19, #0x2c]
0066352F8  ldp      x20, x19, [sp, #0x10]
0066352FC  ldp      x30, x21, [sp], #0x20
006635300  ret      
006635304  ldr      x2, [x1, #0x60]
006635308  mov      x0, x19
00663530C  ldp      x20, x19, [sp, #0x10]
006635310  ldp      x30, x21, [sp], #0x20
006635314  br       x2

; HotFix.BattleLogic.WeightRandom$$Exist
; RVA 0x66331E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066331E4  str      x30, [sp, #-0x30]!
0066331E8  stp      x22, x21, [sp, #0x10]
0066331EC  stp      x20, x19, [sp, #0x20]
0066331F0  adrp     x21, #0x9599000
0066331F4  adrp     x22, #0x8f0c000
0066331F8  ldrb     w8, [x21, #0x9f0]
0066331FC  ldr      x22, [x22, #0xf98]
006633200  mov      w19, w1
006633204  mov      x20, x0
006633208  tbnz     w8, #0, #0x6633220
00663320C  adrp     x0, #0x8f0c000
006633210  ldr      x0, [x0, #0xf98]
006633214  bl       #0x382bd14 ; 
006633218  mov      w8, #1
00663321C  strb     w8, [x21, #0x9f0]
006633220  ldr      x2, [x22]
006633224  ldrb     w8, [x2, #0x53]
006633228  tbnz     w8, #5, #0x6633278
00663322C  ldr      w8, [x20, #0x30]
006633230  cmp      w8, #1
006633234  b.lt     #0x6633294
006633238  ldr      x11, [x20, #0x40]
00663323C  cbz      x11, #0x66332ac
006633240  ldr      w10, [x11, #0x18]
006633244  mov      w9, wzr
006633248  add      x11, x11, #0x20
00663324C  cmp      w9, w10
006633250  b.hs     #0x66332a8
006633254  ldr      w12, [x11], #0x38
006633258  add      w9, w9, #1
00663325C  cmp      w12, w19
006633260  cset     w0, eq
006633264  cmp      w9, w8
006633268  b.ge     #0x6633298
00663326C  cmp      w12, w19
006633270  b.ne     #0x663324c
006633274  b        #0x6633298 ; 
006633278  ldr      x3, [x2, #0x60]
00663327C  mov      x0, x20
006633280  mov      w1, w19
006633284  ldp      x20, x19, [sp, #0x20]
006633288  ldp      x22, x21, [sp, #0x10]
00663328C  ldr      x30, [sp], #0x30
006633290  br       x3
006633294  mov      w0, wzr
006633298  ldp      x20, x19, [sp, #0x20]
00663329C  ldp      x22, x21, [sp, #0x10]
0066332A0  ldr      x30, [sp], #0x30
0066332A4  ret      
0066332A8  bl       #0x382bfc0 ; 
0066332AC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandom$$LogAllId
; RVA 0x6636154; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006636154  str      x30, [sp, #-0x30]!
006636158  stp      x22, x21, [sp, #0x10]
00663615C  stp      x20, x19, [sp, #0x20]
006636160  adrp     x20, #0x9599000
006636164  adrp     x21, #0x8f0d000
006636168  ldrb     w8, [x20, #0x9f1]
00663616C  ldr      x21, [x21, #0xb8]
006636170  mov      x19, x0
006636174  tbnz     w8, #0, #0x66361c8
006636178  adrp     x0, #0x8f0d000
00663617C  ldr      x0, [x0, #0xc0]
006636180  bl       #0x382bd14 ; 
006636184  adrp     x0, #0x8ee3000
006636188  ldr      x0, [x0, #0xf48]
00663618C  bl       #0x382bd14 ; 
006636190  adrp     x0, #0x8f0d000
006636194  ldr      x0, [x0, #0xc8]
006636198  bl       #0x382bd14 ; 
00663619C  adrp     x0, #0x8f0d000
0066361A0  ldr      x0, [x0, #0xd0]
0066361A4  bl       #0x382bd14 ; 
0066361A8  adrp     x0, #0x8f0c000
0066361AC  ldr      x0, [x0, #0xf68]
0066361B0  bl       #0x382bd14 ; 
0066361B4  adrp     x0, #0x8f0d000
0066361B8  ldr      x0, [x0, #0xb8]
0066361BC  bl       #0x382bd14 ; 
0066361C0  mov      w8, #1
0066361C4  strb     w8, [x20, #0x9f1]
0066361C8  ldr      x1, [x21]
0066361CC  ldrb     w8, [x1, #0x53]
0066361D0  tbnz     w8, #5, #0x6636290
0066361D4  ldr      x19, [x19, #0x40]
0066361D8  cbz      x19, #0x66362a8
0066361DC  adrp     x22, #0x8f0c000
0066361E0  ldr      x22, [x22, #0xf68]
0066361E4  ldr      x0, [x22]
0066361E8  ldr      w8, [x0, #0xe0]
0066361EC  cbnz     w8, #0x66361f8
0066361F0  bl       #0x382be8c ; 
0066361F4  ldr      x0, [x22]
0066361F8  ldr      x8, [x0, #0xb8]
0066361FC  ldr      x20, [x8, #0x10]
006636200  cbnz     x20, #0x663625c
006636204  ldr      w8, [x0, #0xe0]
006636208  cbnz     w8, #0x6636214
00663620C  bl       #0x382be8c ; 
006636210  ldr      x0, [x22]
006636214  adrp     x9, #0x8f0d000
006636218  ldr      x8, [x0, #0xb8]
00663621C  ldr      x9, [x9, #0xc8]
006636220  ldr      x21, [x8]
006636224  ldr      x0, [x9]
006636228  bl       #0x382bfa0 ; 
00663622C  adrp     x8, #0x8f0d000
006636230  ldr      x8, [x8, #0xd0]
006636234  mov      x1, x21
006636238  mov      x3, xzr
00663623C  mov      x20, x0
006636240  ldr      x2, [x8]
006636244  bl       #0x48db3d4 ; System.Func<WeightRandomData, int>$$.ctor
006636248  ldr      x8, [x22]
00663624C  mov      x1, x20
006636250  ldr      x0, [x8, #0xb8]
006636254  str      x20, [x0, #0x10]!
006636258  bl       #0x382bcb8 ; 
00663625C  adrp     x8, #0x8f0d000
006636260  ldr      x8, [x8, #0xc0]
006636264  mov      x0, x19
006636268  mov      x1, x20
00663626C  ldr      x2, [x8]
006636270  bl       #0x45d14a0 ; System.Linq.Enumerable$$Select<WeightRandomData, int>
006636274  adrp     x8, #0x8ee3000
006636278  ldr      x8, [x8, #0xf48]
00663627C  ldp      x20, x19, [sp, #0x20]
006636280  ldp      x22, x21, [sp, #0x10]
006636284  ldr      x1, [x8]
006636288  ldr      x30, [sp], #0x30
00663628C  b        #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
006636290  ldr      x2, [x1, #0x60]
006636294  mov      x0, x19
006636298  ldp      x20, x19, [sp, #0x20]
00663629C  ldp      x22, x21, [sp, #0x10]
0066362A0  ldr      x30, [sp], #0x30
0066362A4  br       x2
0066362A8  ldp      x20, x19, [sp, #0x20]
0066362AC  ldp      x22, x21, [sp, #0x10]
0066362B0  ldr      x30, [sp], #0x30
0066362B4  ret      

; HotFix.BattleLogic.WeightRandom$$LogError
; RVA 0x66345B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066345B4  str      x30, [sp, #-0x30]!
0066345B8  stp      x22, x21, [sp, #0x10]
0066345BC  stp      x20, x19, [sp, #0x20]
0066345C0  adrp     x21, #0x9599000
0066345C4  adrp     x22, #0x8f0d000
0066345C8  ldrb     w8, [x21, #0x9f2]
0066345CC  ldr      x22, [x22, #0x38]
0066345D0  mov      x19, x1
0066345D4  mov      x20, x0
0066345D8  tbnz     w8, #0, #0x6634614
0066345DC  adrp     x0, #0x8ee1000
0066345E0  ldr      x0, [x0, #0x6e8]
0066345E4  bl       #0x382bd14 ; 
0066345E8  adrp     x0, #0x8f0d000
0066345EC  ldr      x0, [x0, #0x38]
0066345F0  bl       #0x382bd14 ; 
0066345F4  adrp     x0, #0x8f0c000
0066345F8  ldr      x0, [x0, #0xff8]
0066345FC  bl       #0x382bd14 ; 
006634600  adrp     x0, #0x8ee4000
006634604  ldr      x0, [x0, #0x588]
006634608  bl       #0x382bd14 ; 
00663460C  mov      w8, #1
006634610  strb     w8, [x21, #0x9f2]
006634614  ldr      x2, [x22]
006634618  ldrb     w8, [x2, #0x53]
00663461C  tbnz     w8, #5, #0x6634674
006634620  ldrb     w8, [x20, #0x28]
006634624  cbz      w8, #0x6634690
006634628  adrp     x8, #0x8ee1000
00663462C  ldr      x8, [x8, #0x6e8]
006634630  ldr      x0, [x8]
006634634  ldr      w8, [x0, #0xe0]
006634638  cbnz     w8, #0x6634640
00663463C  bl       #0x382be8c ; 
006634640  adrp     x8, #0x8ee4000
006634644  adrp     x9, #0x8f0c000
006634648  ldr      x8, [x8, #0x588]
00663464C  ldr      x9, [x9, #0xff8]
006634650  mov      x0, x19
006634654  ldp      x20, x19, [sp, #0x20]
006634658  ldr      x1, [x8]
00663465C  ldr      x2, [x9]
006634660  ldp      x22, x21, [sp, #0x10]
006634664  mov      w3, #0x2e6
006634668  mov      x4, xzr
00663466C  ldr      x30, [sp], #0x30
006634670  b        #0x7997754 ; Logger$$LogError
006634674  ldr      x3, [x2, #0x60]
006634678  mov      x0, x20
00663467C  mov      x1, x19
006634680  ldp      x20, x19, [sp, #0x20]
006634684  ldp      x22, x21, [sp, #0x10]
006634688  ldr      x30, [sp], #0x30
00663468C  br       x3
006634690  ldp      x20, x19, [sp, #0x20]
006634694  ldp      x22, x21, [sp, #0x10]
006634698  ldr      x30, [sp], #0x30
00663469C  ret      

; HotFix.BattleLogic.WeightRandom$$InitAllSkillWeight
; RVA 0x66362B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066362B8  sub      sp, sp, #0x70
0066362BC  stp      x29, x30, [sp, #0x10]
0066362C0  stp      x28, x27, [sp, #0x20]
0066362C4  stp      x26, x25, [sp, #0x30]
0066362C8  stp      x24, x23, [sp, #0x40]
0066362CC  stp      x22, x21, [sp, #0x50]
0066362D0  stp      x20, x19, [sp, #0x60]
0066362D4  str      x2, [sp, #8]
0066362D8  adrp     x19, #0x9599000
0066362DC  adrp     x22, #0x8f0d000
0066362E0  ldrb     w8, [x19, #0x9f3]
0066362E4  ldr      x22, [x22, #0xd8]
0066362E8  mov      x20, x1
0066362EC  mov      x21, x0
0066362F0  tbnz     w8, #0, #0x6636314
0066362F4  adrp     x0, #0x8f08000
0066362F8  ldr      x0, [x0, #0x630]
0066362FC  bl       #0x382bd14 ; 
006636300  adrp     x0, #0x8f0d000
006636304  ldr      x0, [x0, #0xd8]
006636308  bl       #0x382bd14 ; 
00663630C  mov      w8, #1
006636310  strb     w8, [x19, #0x9f3]
006636314  ldr      x3, [x22]
006636318  ldrb     w8, [x3, #0x53]
00663631C  tbnz     w8, #5, #0x6636570
006636320  ldr      w8, [x21, #0x30]
006636324  cmp      w8, #1
006636328  b.lt     #0x66365a0
00663632C  adrp     x22, #0x8ee5000
006636330  adrp     x23, #0x8f06000
006636334  ldr      x22, [x22, #0xb28]
006636338  ldr      x23, [x23, #0x470]
00663633C  mov      x27, xzr
006636340  ldr      x29, [x21, #0x40]
006636344  cbz      x29, #0x66365c0
006636348  ldr      w8, [x29, #0x18]
00663634C  cmp      x27, x8
006636350  b.hs     #0x66365c4
006636354  mov      w8, #0x38
006636358  madd     x24, x27, x8, x29
00663635C  adrp     x8, #0x9591000
006636360  ldr      w25, [x24, #0x20]!
006636364  ldrb     w8, [x8, #0xa4b]
006636368  cbnz     w8, #0x6636380
00663636C  mov      x0, x22
006636370  bl       #0x382bd14 ; 
006636374  adrp     x8, #0x9591000
006636378  mov      w9, #1
00663637C  strb     w9, [x8, #0xa4b]
006636380  ldr      x1, [x22]
006636384  ldrb     w8, [x1, #0x53]
006636388  tbnz     w8, #5, #0x6636394
00663638C  ldr      x26, [x21, #0x20]
006636390  b        #0x66363a4 ; 
006636394  ldr      x8, [x1, #0x60]
006636398  mov      x0, x21
00663639C  blr      x8
0066363A0  mov      x26, x0
0066363A4  cbz      x26, #0x66365c0
0066363A8  adrp     x8, #0x9598000
0066363AC  ldrb     w8, [x8, #0xfcc]
0066363B0  cbnz     w8, #0x66363c8
0066363B4  mov      x0, x23
0066363B8  bl       #0x382bd14 ; 
0066363BC  mov      w8, #1
0066363C0  adrp     x9, #0x9598000
0066363C4  strb     w8, [x9, #0xfcc]
0066363C8  ldr      x1, [x23]
0066363CC  ldrb     w8, [x1, #0x53]
0066363D0  tbnz     w8, #5, #0x66363dc
0066363D4  ldr      x0, [x26, #0x200]
0066363D8  b        #0x66363e8 ; 
0066363DC  ldr      x8, [x1, #0x60]
0066363E0  mov      x0, x26
0066363E4  blr      x8
0066363E8  cbz      x0, #0x66365c0
0066363EC  mov      w1, w25
0066363F0  mov      x2, xzr
0066363F4  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0066363F8  mov      x25, x0
0066363FC  mov      x0, x24
006636400  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006636404  cmp      w0, #1
006636408  b.lt     #0x6636554
00663640C  cbz      x25, #0x66365c0
006636410  mov      x0, x25
006636414  mov      x1, xzr
006636418  bl       #0x6b0a2d4 ; LocalModels.Bean.Skill_Main$$GetIsUpgrade
00663641C  cmp      w0, #2
006636420  b.ne     #0x6636554
006636424  mov      x0, x25
006636428  mov      x1, xzr
00663642C  bl       #0x6b0a438 ; LocalModels.Bean.Skill_Main$$GetUpgradeSkillId
006636430  cbz      x0, #0x6636544
006636434  ldr      x8, [x0, #0x18]
006636438  mov      x24, x0
00663643C  cbz      x8, #0x6636544
006636440  cmp      w8, #1
006636444  b.lt     #0x6636554
006636448  mov      w9, #0x38
00663644C  madd     x9, x27, x9, x29
006636450  mov      x28, xzr
006636454  add      x29, x9, #0x50
006636458  add      x19, x24, #0x20
00663645C  cmp      x28, w8, uxtw
006636460  b.hs     #0x66365c4
006636464  adrp     x8, #0x9591000
006636468  ldrb     w8, [x8, #0xa4b]
00663646C  ldr      w25, [x19, x28, lsl #2]
006636470  cbnz     w8, #0x6636488
006636474  mov      x0, x22
006636478  bl       #0x382bd14 ; 
00663647C  adrp     x8, #0x9591000
006636480  mov      w9, #1
006636484  strb     w9, [x8, #0xa4b]
006636488  ldr      x1, [x22]
00663648C  ldrb     w8, [x1, #0x53]
006636490  tbnz     w8, #5, #0x663649c
006636494  ldr      x26, [x21, #0x20]
006636498  b        #0x66364ac ; 
00663649C  ldr      x8, [x1, #0x60]
0066364A0  mov      x0, x21
0066364A4  blr      x8
0066364A8  mov      x26, x0
0066364AC  cbz      x26, #0x66365c0
0066364B0  adrp     x8, #0x9598000
0066364B4  ldrb     w8, [x8, #0xfcc]
0066364B8  cbnz     w8, #0x66364d0
0066364BC  mov      x0, x23
0066364C0  bl       #0x382bd14 ; 
0066364C4  mov      w8, #1
0066364C8  adrp     x9, #0x9598000
0066364CC  strb     w8, [x9, #0xfcc]
0066364D0  ldr      x1, [x23]
0066364D4  ldrb     w8, [x1, #0x53]
0066364D8  tbnz     w8, #5, #0x66364e4
0066364DC  ldr      x0, [x26, #0x200]
0066364E0  b        #0x66364f0 ; 
0066364E4  ldr      x8, [x1, #0x60]
0066364E8  mov      x0, x26
0066364EC  blr      x8
0066364F0  ldr      x1, [sp, #8]
0066364F4  mov      w2, w25
0066364F8  mov      x3, xzr
0066364FC  bl       #0x691f410 ; HotFix.BattleLogic.GameUtils$$CheckCanStudySkill
006636500  cbz      x20, #0x66365c0
006636504  adrp     x8, #0x8f08000
006636508  ldr      x8, [x8, #0x630]
00663650C  mov      w26, w0
006636510  mov      x0, x20
006636514  mov      w1, w25
006636518  ldr      x2, [x8]
00663651C  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006636520  bic      w8, w26, w0
006636524  tbnz     w8, #0, #0x6636568
006636528  mov      w8, #1
00663652C  strb     w8, [x29]
006636530  ldr      w8, [x24, #0x18]
006636534  add      x28, x28, #1
006636538  cmp      x28, w8, sxtw
00663653C  b.lt     #0x663645c
006636540  b        #0x6636554 ; 
006636544  mov      w8, #0x38
006636548  madd     x8, x27, x8, x29
00663654C  mov      w9, #1
006636550  strb     w9, [x8, #0x50]
006636554  ldrsw    x8, [x21, #0x30]
006636558  add      x27, x27, #1
00663655C  cmp      x27, x8
006636560  b.lt     #0x6636340
006636564  b        #0x66365a0 ; 
006636568  strb     wzr, [x29]
00663656C  b        #0x6636554 ; 
006636570  ldr      x4, [x3, #0x60]
006636574  mov      x0, x21
006636578  mov      x1, x20
00663657C  ldr      x2, [sp, #8]
006636580  ldp      x20, x19, [sp, #0x60]
006636584  ldp      x22, x21, [sp, #0x50]
006636588  ldp      x24, x23, [sp, #0x40]
00663658C  ldp      x26, x25, [sp, #0x30]
006636590  ldp      x28, x27, [sp, #0x20]
006636594  ldp      x29, x30, [sp, #0x10]
006636598  add      sp, sp, #0x70
00663659C  br       x4
0066365A0  ldp      x20, x19, [sp, #0x60]
0066365A4  ldp      x22, x21, [sp, #0x50]
0066365A8  ldp      x24, x23, [sp, #0x40]
0066365AC  ldp      x26, x25, [sp, #0x30]
0066365B0  ldp      x28, x27, [sp, #0x20]
0066365B4  ldp      x29, x30, [sp, #0x10]
0066365B8  add      sp, sp, #0x70
0066365BC  ret      
0066365C0  bl       #0x382bfb8 ; 
0066365C4  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandom$$.ctor
; RVA 0x66365C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066365C8  stp      x30, x21, [sp, #-0x20]!
0066365CC  stp      x20, x19, [sp, #0x10]
0066365D0  adrp     x20, #0x9599000
0066365D4  adrp     x21, #0x8f0d000
0066365D8  ldrb     w8, [x20, #0x9f4]
0066365DC  ldr      x21, [x21, #0xe0]
0066365E0  mov      x19, x0
0066365E4  tbnz     w8, #0, #0x66365fc
0066365E8  adrp     x0, #0x8f0d000
0066365EC  ldr      x0, [x0, #0xe0]
0066365F0  bl       #0x382bd14 ; 
0066365F4  mov      w8, #1
0066365F8  strb     w8, [x20, #0x9f4]
0066365FC  ldr      x1, [x21]
006636600  ldrb     w8, [x1, #0x53]
006636604  tbnz     w8, #5, #0x663661c
006636608  mov      x0, x19
00663660C  ldp      x20, x19, [sp, #0x10]
006636610  mov      x1, xzr
006636614  ldp      x30, x21, [sp], #0x20
006636618  b        #0x6a34500 ; HotFix.BattleLogic.PooledWorldElement$$.ctor
00663661C  ldr      x2, [x1, #0x60]
006636620  mov      x0, x19
006636624  ldp      x20, x19, [sp, #0x10]
006636628  ldp      x30, x21, [sp], #0x20
00663662C  br       x2

