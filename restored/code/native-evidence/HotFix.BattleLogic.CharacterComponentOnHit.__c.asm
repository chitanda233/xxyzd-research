; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$.cctor
; RVA 0x6705774; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705774  str      x30, [sp, #-0x20]!
006705778  stp      x20, x19, [sp, #0x10]
00670577C  adrp     x19, #0x959a000
006705780  adrp     x20, #0x8f11000
006705784  ldrb     w8, [x19, #0x98b]
006705788  ldr      x20, [x20, #0xba8]
00670578C  tbnz     w8, #0, #0x67057a4
006705790  adrp     x0, #0x8f11000
006705794  ldr      x0, [x0, #0xba8]
006705798  bl       #0x382bd14 ; 
00670579C  mov      w8, #1
0067057A0  strb     w8, [x19, #0x98b]
0067057A4  ldr      x0, [x20]
0067057A8  bl       #0x382bfa0 ; 
0067057AC  mov      x19, x0
0067057B0  bl       #0x67057d8 ; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$.ctor
0067057B4  ldr      x8, [x20]
0067057B8  mov      x1, x19
0067057BC  ldr      x8, [x8, #0xb8]
0067057C0  str      x19, [x8]
0067057C4  ldr      x8, [x20]
0067057C8  ldp      x20, x19, [sp, #0x10]
0067057CC  ldr      x0, [x8, #0xb8]
0067057D0  ldr      x30, [sp], #0x20
0067057D4  b        #0x382bcb8 ; 

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$.ctor
; RVA 0x67057D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067057D8  stp      x30, x21, [sp, #-0x20]!
0067057DC  stp      x20, x19, [sp, #0x10]
0067057E0  adrp     x20, #0x959a000
0067057E4  adrp     x21, #0x8f17000
0067057E8  ldrb     w8, [x20, #0x98c]
0067057EC  ldr      x21, [x21, #0xa60]
0067057F0  mov      x19, x0
0067057F4  tbnz     w8, #0, #0x670580c
0067057F8  adrp     x0, #0x8f17000
0067057FC  ldr      x0, [x0, #0xa60]
006705800  bl       #0x382bd14 ; 
006705804  mov      w8, #1
006705808  strb     w8, [x20, #0x98c]
00670580C  ldr      x1, [x21]
006705810  ldrb     w8, [x1, #0x53]
006705814  tbnz     w8, #5, #0x670582c
006705818  mov      x0, x19
00670581C  ldp      x20, x19, [sp, #0x10]
006705820  mov      x1, xzr
006705824  ldp      x30, x21, [sp], #0x20
006705828  b        #0x7c335dc ; System.Object$$.ctor
00670582C  ldr      x2, [x1, #0x60]
006705830  mov      x0, x19
006705834  ldp      x20, x19, [sp, #0x10]
006705838  ldp      x30, x21, [sp], #0x20
00670583C  br       x2

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroHurt>b__102_0
; RVA 0x6705840; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705840  stp      x30, x23, [sp, #-0x30]!
006705844  stp      x22, x21, [sp, #0x10]
006705848  stp      x20, x19, [sp, #0x20]
00670584C  adrp     x22, #0x959a000
006705850  adrp     x23, #0x8f11000
006705854  ldrb     w8, [x22, #0x98d]
006705858  ldr      x23, [x23, #0xe60]
00670585C  mov      x19, x2
006705860  mov      x20, x1
006705864  mov      x21, x0
006705868  tbnz     w8, #0, #0x6705880
00670586C  adrp     x0, #0x8f11000
006705870  ldr      x0, [x0, #0xe60]
006705874  bl       #0x382bd14 ; 
006705878  mov      w8, #1
00670587C  strb     w8, [x22, #0x98d]
006705880  ldr      x3, [x23]
006705884  ldrb     w8, [x3, #0x53]
006705888  tbnz     w8, #5, #0x67058ac
00670588C  cbz      x20, #0x67058cc
006705890  ldr      x8, [x20]
006705894  mov      x0, x20
006705898  mov      x1, x19
00670589C  mov      x2, xzr
0067058A0  ldr      x4, [x8, #0x4b8]
0067058A4  ldr      x3, [x8, #0x4c0]
0067058A8  b        #0x67058bc ; 
0067058AC  ldr      x4, [x3, #0x60]
0067058B0  mov      x0, x21
0067058B4  mov      x1, x20
0067058B8  mov      x2, x19
0067058BC  ldp      x20, x19, [sp, #0x20]
0067058C0  ldp      x22, x21, [sp, #0x10]
0067058C4  ldp      x30, x23, [sp], #0x30
0067058C8  br       x4
0067058CC  ldp      x20, x19, [sp, #0x20]
0067058D0  ldp      x22, x21, [sp, #0x10]
0067058D4  ldp      x30, x23, [sp], #0x30
0067058D8  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroHurtAfterHPChange>b__103_0
; RVA 0x67058DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067058DC  stp      x30, x23, [sp, #-0x30]!
0067058E0  stp      x22, x21, [sp, #0x10]
0067058E4  stp      x20, x19, [sp, #0x20]
0067058E8  adrp     x22, #0x959a000
0067058EC  adrp     x23, #0x8f11000
0067058F0  ldrb     w8, [x22, #0x98e]
0067058F4  ldr      x23, [x23, #0xea0]
0067058F8  mov      x19, x2
0067058FC  mov      x20, x1
006705900  mov      x21, x0
006705904  tbnz     w8, #0, #0x670591c
006705908  adrp     x0, #0x8f11000
00670590C  ldr      x0, [x0, #0xea0]
006705910  bl       #0x382bd14 ; 
006705914  mov      w8, #1
006705918  strb     w8, [x22, #0x98e]
00670591C  ldr      x3, [x23]
006705920  ldrb     w8, [x3, #0x53]
006705924  tbnz     w8, #5, #0x6705948
006705928  cbz      x20, #0x6705968
00670592C  ldr      x8, [x20]
006705930  mov      x0, x20
006705934  mov      x1, x19
006705938  mov      x2, xzr
00670593C  ldr      x4, [x8, #0x4c8]
006705940  ldr      x3, [x8, #0x4d0]
006705944  b        #0x6705958 ; 
006705948  ldr      x4, [x3, #0x60]
00670594C  mov      x0, x21
006705950  mov      x1, x20
006705954  mov      x2, x19
006705958  ldp      x20, x19, [sp, #0x20]
00670595C  ldp      x22, x21, [sp, #0x10]
006705960  ldp      x30, x23, [sp], #0x30
006705964  br       x4
006705968  ldp      x20, x19, [sp, #0x20]
00670596C  ldp      x22, x21, [sp, #0x10]
006705970  ldp      x30, x23, [sp], #0x30
006705974  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroInvHurt>b__104_0
; RVA 0x6705978; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705978  stp      x30, x23, [sp, #-0x30]!
00670597C  stp      x22, x21, [sp, #0x10]
006705980  stp      x20, x19, [sp, #0x20]
006705984  adrp     x22, #0x959a000
006705988  adrp     x23, #0x8f11000
00670598C  ldrb     w8, [x22, #0x98f]
006705990  ldr      x23, [x23, #0xd60]
006705994  mov      x19, x2
006705998  mov      x20, x1
00670599C  mov      x21, x0
0067059A0  tbnz     w8, #0, #0x67059b8
0067059A4  adrp     x0, #0x8f11000
0067059A8  ldr      x0, [x0, #0xd60]
0067059AC  bl       #0x382bd14 ; 
0067059B0  mov      w8, #1
0067059B4  strb     w8, [x22, #0x98f]
0067059B8  ldr      x3, [x23]
0067059BC  ldrb     w8, [x3, #0x53]
0067059C0  tbnz     w8, #5, #0x67059e4
0067059C4  cbz      x20, #0x6705a04
0067059C8  ldr      x8, [x20]
0067059CC  mov      x0, x20
0067059D0  mov      x1, x19
0067059D4  mov      x2, xzr
0067059D8  ldr      x4, [x8, #0x4d8]
0067059DC  ldr      x3, [x8, #0x4e0]
0067059E0  b        #0x67059f4 ; 
0067059E4  ldr      x4, [x3, #0x60]
0067059E8  mov      x0, x21
0067059EC  mov      x1, x20
0067059F0  mov      x2, x19
0067059F4  ldp      x20, x19, [sp, #0x20]
0067059F8  ldp      x22, x21, [sp, #0x10]
0067059FC  ldp      x30, x23, [sp], #0x30
006705A00  br       x4
006705A04  ldp      x20, x19, [sp, #0x20]
006705A08  ldp      x22, x21, [sp, #0x10]
006705A0C  ldp      x30, x23, [sp], #0x30
006705A10  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroDying>b__105_0
; RVA 0x6705A14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705A14  stp      x30, x23, [sp, #-0x30]!
006705A18  stp      x22, x21, [sp, #0x10]
006705A1C  stp      x20, x19, [sp, #0x20]
006705A20  adrp     x22, #0x959a000
006705A24  adrp     x23, #0x8f11000
006705A28  ldrb     w8, [x22, #0x990]
006705A2C  ldr      x23, [x23, #0xe80]
006705A30  mov      x19, x2
006705A34  mov      x20, x1
006705A38  mov      x21, x0
006705A3C  tbnz     w8, #0, #0x6705a54
006705A40  adrp     x0, #0x8f11000
006705A44  ldr      x0, [x0, #0xe80]
006705A48  bl       #0x382bd14 ; 
006705A4C  mov      w8, #1
006705A50  strb     w8, [x22, #0x990]
006705A54  ldr      x3, [x23]
006705A58  ldrb     w8, [x3, #0x53]
006705A5C  tbnz     w8, #5, #0x6705a80
006705A60  cbz      x20, #0x6705aa0
006705A64  ldr      x8, [x20]
006705A68  mov      x0, x20
006705A6C  mov      x1, x19
006705A70  mov      x2, xzr
006705A74  ldr      x4, [x8, #0x4f8]
006705A78  ldr      x3, [x8, #0x500]
006705A7C  b        #0x6705a90 ; 
006705A80  ldr      x4, [x3, #0x60]
006705A84  mov      x0, x21
006705A88  mov      x1, x20
006705A8C  mov      x2, x19
006705A90  ldp      x20, x19, [sp, #0x20]
006705A94  ldp      x22, x21, [sp, #0x10]
006705A98  ldp      x30, x23, [sp], #0x30
006705A9C  br       x4
006705AA0  ldp      x20, x19, [sp, #0x20]
006705AA4  ldp      x22, x21, [sp, #0x10]
006705AA8  ldp      x30, x23, [sp], #0x30
006705AAC  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroHpChange>b__106_0
; RVA 0x6705AB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705AB0  stp      x30, x23, [sp, #-0x30]!
006705AB4  stp      x22, x21, [sp, #0x10]
006705AB8  stp      x20, x19, [sp, #0x20]
006705ABC  adrp     x22, #0x959a000
006705AC0  adrp     x23, #0x8f11000
006705AC4  ldrb     w8, [x22, #0x991]
006705AC8  ldr      x23, [x23, #0xed8]
006705ACC  mov      x19, x2
006705AD0  mov      x20, x1
006705AD4  mov      x21, x0
006705AD8  tbnz     w8, #0, #0x6705af0
006705ADC  adrp     x0, #0x8f11000
006705AE0  ldr      x0, [x0, #0xed8]
006705AE4  bl       #0x382bd14 ; 
006705AE8  mov      w8, #1
006705AEC  strb     w8, [x22, #0x991]
006705AF0  ldr      x3, [x23]
006705AF4  ldrb     w8, [x3, #0x53]
006705AF8  tbnz     w8, #5, #0x6705b1c
006705AFC  cbz      x20, #0x6705b3c
006705B00  ldr      x8, [x20]
006705B04  mov      x0, x20
006705B08  mov      x1, x19
006705B0C  mov      x2, xzr
006705B10  ldr      x4, [x8, #0x508]
006705B14  ldr      x3, [x8, #0x510]
006705B18  b        #0x6705b2c ; 
006705B1C  ldr      x4, [x3, #0x60]
006705B20  mov      x0, x21
006705B24  mov      x1, x20
006705B28  mov      x2, x19
006705B2C  ldp      x20, x19, [sp, #0x20]
006705B30  ldp      x22, x21, [sp, #0x10]
006705B34  ldp      x30, x23, [sp], #0x30
006705B38  br       x4
006705B3C  ldp      x20, x19, [sp, #0x20]
006705B40  ldp      x22, x21, [sp, #0x10]
006705B44  ldp      x30, x23, [sp], #0x30
006705B48  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroMaxHpChange>b__107_0
; RVA 0x6705B4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705B4C  stp      x30, x23, [sp, #-0x30]!
006705B50  stp      x22, x21, [sp, #0x10]
006705B54  stp      x20, x19, [sp, #0x20]
006705B58  adrp     x22, #0x959a000
006705B5C  adrp     x23, #0x8f11000
006705B60  ldrb     w8, [x22, #0x992]
006705B64  ldr      x23, [x23, #0xef8]
006705B68  mov      x19, x2
006705B6C  mov      x20, x1
006705B70  mov      x21, x0
006705B74  tbnz     w8, #0, #0x6705b8c
006705B78  adrp     x0, #0x8f11000
006705B7C  ldr      x0, [x0, #0xef8]
006705B80  bl       #0x382bd14 ; 
006705B84  mov      w8, #1
006705B88  strb     w8, [x22, #0x992]
006705B8C  ldr      x3, [x23]
006705B90  ldrb     w8, [x3, #0x53]
006705B94  tbnz     w8, #5, #0x6705bb8
006705B98  cbz      x20, #0x6705bd8
006705B9C  ldr      x8, [x20]
006705BA0  mov      x0, x20
006705BA4  mov      x1, x19
006705BA8  mov      x2, xzr
006705BAC  ldr      x4, [x8, #0x518]
006705BB0  ldr      x3, [x8, #0x520]
006705BB4  b        #0x6705bc8 ; 
006705BB8  ldr      x4, [x3, #0x60]
006705BBC  mov      x0, x21
006705BC0  mov      x1, x20
006705BC4  mov      x2, x19
006705BC8  ldp      x20, x19, [sp, #0x20]
006705BCC  ldp      x22, x21, [sp, #0x10]
006705BD0  ldp      x30, x23, [sp], #0x30
006705BD4  br       x4
006705BD8  ldp      x20, x19, [sp, #0x20]
006705BDC  ldp      x22, x21, [sp, #0x10]
006705BE0  ldp      x30, x23, [sp], #0x30
006705BE4  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroHitted>b__108_0
; RVA 0x6705BE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705BE8  stp      x30, x23, [sp, #-0x30]!
006705BEC  stp      x22, x21, [sp, #0x10]
006705BF0  stp      x20, x19, [sp, #0x20]
006705BF4  adrp     x22, #0x959a000
006705BF8  adrp     x23, #0x8f11000
006705BFC  ldrb     w8, [x22, #0x993]
006705C00  ldr      x23, [x23, #0xda0]
006705C04  mov      x19, x2
006705C08  mov      x20, x1
006705C0C  mov      x21, x0
006705C10  tbnz     w8, #0, #0x6705c28
006705C14  adrp     x0, #0x8f11000
006705C18  ldr      x0, [x0, #0xda0]
006705C1C  bl       #0x382bd14 ; 
006705C20  mov      w8, #1
006705C24  strb     w8, [x22, #0x993]
006705C28  ldr      x3, [x23]
006705C2C  ldrb     w8, [x3, #0x53]
006705C30  tbnz     w8, #5, #0x6705c54
006705C34  cbz      x20, #0x6705c74
006705C38  ldr      x8, [x20]
006705C3C  mov      x0, x20
006705C40  mov      x1, x19
006705C44  mov      x2, xzr
006705C48  ldr      x4, [x8, #0x528]
006705C4C  ldr      x3, [x8, #0x530]
006705C50  b        #0x6705c64 ; 
006705C54  ldr      x4, [x3, #0x60]
006705C58  mov      x0, x21
006705C5C  mov      x1, x20
006705C60  mov      x2, x19
006705C64  ldp      x20, x19, [sp, #0x20]
006705C68  ldp      x22, x21, [sp, #0x10]
006705C6C  ldp      x30, x23, [sp], #0x30
006705C70  br       x4
006705C74  ldp      x20, x19, [sp, #0x20]
006705C78  ldp      x22, x21, [sp, #0x10]
006705C7C  ldp      x30, x23, [sp], #0x30
006705C80  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroDiscreteDistance>b__109_0
; RVA 0x6705C84; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705C84  stp      x30, x23, [sp, #-0x30]!
006705C88  stp      x22, x21, [sp, #0x10]
006705C8C  stp      x20, x19, [sp, #0x20]
006705C90  adrp     x22, #0x959a000
006705C94  adrp     x23, #0x8f11000
006705C98  ldrb     w8, [x22, #0x994]
006705C9C  ldr      x23, [x23, #0xf18]
006705CA0  mov      x19, x2
006705CA4  mov      x20, x1
006705CA8  mov      x21, x0
006705CAC  tbnz     w8, #0, #0x6705cc4
006705CB0  adrp     x0, #0x8f11000
006705CB4  ldr      x0, [x0, #0xf18]
006705CB8  bl       #0x382bd14 ; 
006705CBC  mov      w8, #1
006705CC0  strb     w8, [x22, #0x994]
006705CC4  ldr      x3, [x23]
006705CC8  ldrb     w8, [x3, #0x53]
006705CCC  tbnz     w8, #5, #0x6705cf0
006705CD0  cbz      x20, #0x6705d10
006705CD4  ldr      x8, [x20]
006705CD8  mov      x0, x20
006705CDC  mov      x1, x19
006705CE0  mov      x2, xzr
006705CE4  ldr      x4, [x8, #0x538]
006705CE8  ldr      x3, [x8, #0x540]
006705CEC  b        #0x6705d00 ; 
006705CF0  ldr      x4, [x3, #0x60]
006705CF4  mov      x0, x21
006705CF8  mov      x1, x20
006705CFC  mov      x2, x19
006705D00  ldp      x20, x19, [sp, #0x20]
006705D04  ldp      x22, x21, [sp, #0x10]
006705D08  ldp      x30, x23, [sp], #0x30
006705D0C  br       x4
006705D10  ldp      x20, x19, [sp, #0x20]
006705D14  ldp      x22, x21, [sp, #0x10]
006705D18  ldp      x30, x23, [sp], #0x30
006705D1C  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroDropItem>b__110_0
; RVA 0x6705D20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705D20  stp      x30, x23, [sp, #-0x30]!
006705D24  stp      x22, x21, [sp, #0x10]
006705D28  stp      x20, x19, [sp, #0x20]
006705D2C  adrp     x22, #0x959a000
006705D30  adrp     x23, #0x8f11000
006705D34  ldrb     w8, [x22, #0x995]
006705D38  ldr      x23, [x23, #0xf38]
006705D3C  mov      x19, x2
006705D40  mov      x20, x1
006705D44  mov      x21, x0
006705D48  tbnz     w8, #0, #0x6705d60
006705D4C  adrp     x0, #0x8f11000
006705D50  ldr      x0, [x0, #0xf38]
006705D54  bl       #0x382bd14 ; 
006705D58  mov      w8, #1
006705D5C  strb     w8, [x22, #0x995]
006705D60  ldr      x3, [x23]
006705D64  ldrb     w8, [x3, #0x53]
006705D68  tbnz     w8, #5, #0x6705d8c
006705D6C  cbz      x20, #0x6705dac
006705D70  ldr      x8, [x20]
006705D74  mov      x0, x20
006705D78  mov      x1, x19
006705D7C  mov      x2, xzr
006705D80  ldr      x4, [x8, #0x548]
006705D84  ldr      x3, [x8, #0x550]
006705D88  b        #0x6705d9c ; 
006705D8C  ldr      x4, [x3, #0x60]
006705D90  mov      x0, x21
006705D94  mov      x1, x20
006705D98  mov      x2, x19
006705D9C  ldp      x20, x19, [sp, #0x20]
006705DA0  ldp      x22, x21, [sp, #0x10]
006705DA4  ldp      x30, x23, [sp], #0x30
006705DA8  br       x4
006705DAC  ldp      x20, x19, [sp, #0x20]
006705DB0  ldp      x22, x21, [sp, #0x10]
006705DB4  ldp      x30, x23, [sp], #0x30
006705DB8  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroMiss>b__111_0
; RVA 0x6705DBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705DBC  stp      x30, x23, [sp, #-0x30]!
006705DC0  stp      x22, x21, [sp, #0x10]
006705DC4  stp      x20, x19, [sp, #0x20]
006705DC8  adrp     x22, #0x959a000
006705DCC  adrp     x23, #0x8f11000
006705DD0  ldrb     w8, [x22, #0x996]
006705DD4  ldr      x23, [x23, #0xba0]
006705DD8  mov      x19, x2
006705DDC  mov      x20, x1
006705DE0  mov      x21, x0
006705DE4  tbnz     w8, #0, #0x6705dfc
006705DE8  adrp     x0, #0x8f11000
006705DEC  ldr      x0, [x0, #0xba0]
006705DF0  bl       #0x382bd14 ; 
006705DF4  mov      w8, #1
006705DF8  strb     w8, [x22, #0x996]
006705DFC  ldr      x3, [x23]
006705E00  ldrb     w8, [x3, #0x53]
006705E04  tbnz     w8, #5, #0x6705e28
006705E08  cbz      x20, #0x6705e48
006705E0C  ldr      x8, [x20]
006705E10  mov      x0, x20
006705E14  mov      x1, x19
006705E18  mov      x2, xzr
006705E1C  ldr      x4, [x8, #0x4e8]
006705E20  ldr      x3, [x8, #0x4f0]
006705E24  b        #0x6705e38 ; 
006705E28  ldr      x4, [x3, #0x60]
006705E2C  mov      x0, x21
006705E30  mov      x1, x20
006705E34  mov      x2, x19
006705E38  ldp      x20, x19, [sp, #0x20]
006705E3C  ldp      x22, x21, [sp, #0x10]
006705E40  ldp      x30, x23, [sp], #0x30
006705E44  br       x4
006705E48  ldp      x20, x19, [sp, #0x20]
006705E4C  ldp      x22, x21, [sp, #0x10]
006705E50  ldp      x30, x23, [sp], #0x30
006705E54  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroAddBuff>b__112_0
; RVA 0x6705E58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705E58  stp      x30, x23, [sp, #-0x30]!
006705E5C  stp      x22, x21, [sp, #0x10]
006705E60  stp      x20, x19, [sp, #0x20]
006705E64  adrp     x22, #0x959a000
006705E68  adrp     x23, #0x8f11000
006705E6C  ldrb     w8, [x22, #0x997]
006705E70  ldr      x23, [x23, #0xf58]
006705E74  mov      x19, x2
006705E78  mov      x20, x1
006705E7C  mov      x21, x0
006705E80  tbnz     w8, #0, #0x6705e98
006705E84  adrp     x0, #0x8f11000
006705E88  ldr      x0, [x0, #0xf58]
006705E8C  bl       #0x382bd14 ; 
006705E90  mov      w8, #1
006705E94  strb     w8, [x22, #0x997]
006705E98  ldr      x3, [x23]
006705E9C  ldrb     w8, [x3, #0x53]
006705EA0  tbnz     w8, #5, #0x6705ec4
006705EA4  cbz      x20, #0x6705ee4
006705EA8  ldr      x8, [x20]
006705EAC  mov      x0, x20
006705EB0  mov      x1, x19
006705EB4  mov      x2, xzr
006705EB8  ldr      x4, [x8, #0x558]
006705EBC  ldr      x3, [x8, #0x560]
006705EC0  b        #0x6705ed4 ; 
006705EC4  ldr      x4, [x3, #0x60]
006705EC8  mov      x0, x21
006705ECC  mov      x1, x20
006705ED0  mov      x2, x19
006705ED4  ldp      x20, x19, [sp, #0x20]
006705ED8  ldp      x22, x21, [sp, #0x10]
006705EDC  ldp      x30, x23, [sp], #0x30
006705EE0  br       x4
006705EE4  ldp      x20, x19, [sp, #0x20]
006705EE8  ldp      x22, x21, [sp, #0x10]
006705EEC  ldp      x30, x23, [sp], #0x30
006705EF0  ret      

; HotFix.BattleLogic.CharacterComponentOnHit.<>c$$<NotifyFollowersOnHeroSkillSelected>b__113_0
; RVA 0x6705EF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705EF4  stp      x30, x23, [sp, #-0x30]!
006705EF8  stp      x22, x21, [sp, #0x10]
006705EFC  stp      x20, x19, [sp, #0x20]
006705F00  adrp     x22, #0x959a000
006705F04  adrp     x23, #0x8f11000
006705F08  ldrb     w8, [x22, #0x998]
006705F0C  ldr      x23, [x23, #0xf78]
006705F10  mov      x20, x2
006705F14  mov      x19, x1
006705F18  mov      x21, x0
006705F1C  tbnz     w8, #0, #0x6705f34
006705F20  adrp     x0, #0x8f11000
006705F24  ldr      x0, [x0, #0xf78]
006705F28  bl       #0x382bd14 ; 
006705F2C  mov      w8, #1
006705F30  strb     w8, [x22, #0x998]
006705F34  ldr      x3, [x23]
006705F38  ldrb     w8, [x3, #0x53]
006705F3C  tbnz     w8, #5, #0x6705f64
006705F40  cbz      x19, #0x6705f84
006705F44  ldr      x8, [x19]
006705F48  mov      x0, x19
006705F4C  ldp      x20, x19, [sp, #0x20]
006705F50  ldp      x22, x21, [sp, #0x10]
006705F54  ldr      x2, [x8, #0x568]
006705F58  ldr      x1, [x8, #0x570]
006705F5C  ldp      x30, x23, [sp], #0x30
006705F60  br       x2
006705F64  ldr      x4, [x3, #0x60]
006705F68  mov      x0, x21
006705F6C  mov      x1, x19
006705F70  mov      x2, x20
006705F74  ldp      x20, x19, [sp, #0x20]
006705F78  ldp      x22, x21, [sp, #0x10]
006705F7C  ldp      x30, x23, [sp], #0x30
006705F80  br       x4
006705F84  ldp      x20, x19, [sp, #0x20]
006705F88  ldp      x22, x21, [sp, #0x10]
006705F8C  ldp      x30, x23, [sp], #0x30
006705F90  ret      

