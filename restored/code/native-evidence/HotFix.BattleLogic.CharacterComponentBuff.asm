; HotFix.BattleLogic.CharacterComponentBuff$$Init
; RVA 0x669367C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00669367C  stp      x30, x21, [sp, #-0x20]!
006693680  stp      x20, x19, [sp, #0x10]
006693684  adrp     x20, #0x959a000
006693688  adrp     x21, #0x8f10000
00669368C  ldrb     w8, [x20, #0x52]
006693690  ldr      x21, [x21, #0xa70]
006693694  mov      x19, x0
006693698  tbnz     w8, #0, #0x66936b0
00669369C  adrp     x0, #0x8f10000
0066936A0  ldr      x0, [x0, #0xa70]
0066936A4  bl       #0x382bd14 ; 
0066936A8  mov      w8, #1
0066936AC  strb     w8, [x20, #0x52]
0066936B0  ldr      x1, [x21]
0066936B4  ldrb     w8, [x1, #0x53]
0066936B8  tbnz     w8, #5, #0x66936d0
0066936BC  str      xzr, [x19, #0x40]
0066936C0  strb     wzr, [x19, #0x48]
0066936C4  ldp      x20, x19, [sp, #0x10]
0066936C8  ldp      x30, x21, [sp], #0x20
0066936CC  ret      
0066936D0  ldr      x2, [x1, #0x60]
0066936D4  mov      x0, x19
0066936D8  ldp      x20, x19, [sp, #0x10]
0066936DC  ldp      x30, x21, [sp], #0x20
0066936E0  br       x2

; HotFix.BattleLogic.CharacterComponentBuff$$DeInit
; RVA 0x66936E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066936E4  stp      x30, x21, [sp, #-0x20]!
0066936E8  stp      x20, x19, [sp, #0x10]
0066936EC  adrp     x20, #0x959a000
0066936F0  adrp     x21, #0x8f10000
0066936F4  ldrb     w8, [x20, #0x53]
0066936F8  ldr      x21, [x21, #0xa78]
0066936FC  mov      x19, x0
006693700  tbnz     w8, #0, #0x6693718
006693704  adrp     x0, #0x8f10000
006693708  ldr      x0, [x0, #0xa78]
00669370C  bl       #0x382bd14 ; 
006693710  mov      w8, #1
006693714  strb     w8, [x20, #0x53]
006693718  ldr      x1, [x21]
00669371C  ldrb     w8, [x1, #0x53]
006693720  tbnz     w8, #5, #0x6693734
006693724  mov      x0, x19
006693728  ldp      x20, x19, [sp, #0x10]
00669372C  ldp      x30, x21, [sp], #0x20
006693730  b        #0x6693748 ; HotFix.BattleLogic.CharacterComponentBuff$$ClearAllBuff
006693734  ldr      x2, [x1, #0x60]
006693738  mov      x0, x19
00669373C  ldp      x20, x19, [sp, #0x10]
006693740  ldp      x30, x21, [sp], #0x20
006693744  br       x2

; HotFix.BattleLogic.CharacterComponentBuff$$ClearAllBuff
; RVA 0x6693748; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006693748  stp      x30, x27, [sp, #-0x50]!
00669374C  stp      x26, x25, [sp, #0x10]
006693750  stp      x24, x23, [sp, #0x20]
006693754  stp      x22, x21, [sp, #0x30]
006693758  stp      x20, x19, [sp, #0x40]
00669375C  adrp     x20, #0x959a000
006693760  adrp     x21, #0x8f10000
006693764  ldrb     w8, [x20, #0x54]
006693768  ldr      x21, [x21, #0xa80]
00669376C  mov      x19, x0
006693770  tbnz     w8, #0, #0x66937e8
006693774  adrp     x0, #0x8f10000
006693778  ldr      x0, [x0, #0xa80]
00669377C  bl       #0x382bd14 ; 
006693780  adrp     x0, #0x8f10000
006693784  ldr      x0, [x0, #0xa88]
006693788  bl       #0x382bd14 ; 
00669378C  adrp     x0, #0x8f10000
006693790  ldr      x0, [x0, #0xa90]
006693794  bl       #0x382bd14 ; 
006693798  adrp     x0, #0x8f10000
00669379C  ldr      x0, [x0, #0xa98]
0066937A0  bl       #0x382bd14 ; 
0066937A4  adrp     x0, #0x8f10000
0066937A8  ldr      x0, [x0, #0xaa0]
0066937AC  bl       #0x382bd14 ; 
0066937B0  adrp     x0, #0x8f10000
0066937B4  ldr      x0, [x0, #0xaa8]
0066937B8  bl       #0x382bd14 ; 
0066937BC  adrp     x0, #0x8f10000
0066937C0  ldr      x0, [x0, #0xab0]
0066937C4  bl       #0x382bd14 ; 
0066937C8  adrp     x0, #0x8f10000
0066937CC  ldr      x0, [x0, #0xab8]
0066937D0  bl       #0x382bd14 ; 
0066937D4  adrp     x0, #0x8f10000
0066937D8  ldr      x0, [x0, #0xac0]
0066937DC  bl       #0x382bd14 ; 
0066937E0  mov      w8, #1
0066937E4  strb     w8, [x20, #0x54]
0066937E8  ldr      x1, [x21]
0066937EC  ldrb     w8, [x1, #0x53]
0066937F0  tbnz     w8, #5, #0x6693830
0066937F4  adrp     x22, #0x9591000
0066937F8  ldrb     w8, [x22, #0xa4b]
0066937FC  cbnz     w8, #0x6693814
006693800  adrp     x0, #0x8ee5000
006693804  ldr      x0, [x0, #0xb28]
006693808  bl       #0x382bd14 ; 
00669380C  mov      w8, #1
006693810  strb     w8, [x22, #0xa4b]
006693814  adrp     x24, #0x8ee5000
006693818  ldr      x24, [x24, #0xb28]
00669381C  ldr      x1, [x24]
006693820  ldrb     w8, [x1, #0x53]
006693824  tbnz     w8, #5, #0x6693850
006693828  ldr      x20, [x19, #0x20]
00669382C  b        #0x6693860 ; 
006693830  ldr      x2, [x1, #0x60]
006693834  mov      x0, x19
006693838  ldp      x20, x19, [sp, #0x40]
00669383C  ldp      x22, x21, [sp, #0x30]
006693840  ldp      x24, x23, [sp, #0x20]
006693844  ldp      x26, x25, [sp, #0x10]
006693848  ldp      x30, x27, [sp], #0x50
00669384C  br       x2
006693850  ldr      x8, [x1, #0x60]
006693854  mov      x0, x19
006693858  blr      x8
00669385C  mov      x20, x0
006693860  cbz      x20, #0x6693a3c
006693864  adrp     x23, #0x9591000
006693868  ldrb     w8, [x23, #0xa90]
00669386C  cbnz     w8, #0x6693884
006693870  adrp     x0, #0x8ee6000
006693874  ldr      x0, [x0, #0x3e0]
006693878  bl       #0x382bd14 ; 
00669387C  mov      w8, #1
006693880  strb     w8, [x23, #0xa90]
006693884  adrp     x25, #0x8ee6000
006693888  ldr      x25, [x25, #0x3e0]
00669388C  ldr      x1, [x25]
006693890  ldrb     w8, [x1, #0x53]
006693894  tbnz     w8, #5, #0x66938a0
006693898  ldr      x0, [x20, #0x230]
00669389C  b        #0x66938ac ; 
0066938A0  ldr      x8, [x1, #0x60]
0066938A4  mov      x0, x20
0066938A8  blr      x8
0066938AC  cbz      x0, #0x6693a3c
0066938B0  adrp     x8, #0x8f10000
0066938B4  ldr      x8, [x8, #0xab8]
0066938B8  ldr      x1, [x8]
0066938BC  bl       #0x4784cec ; HotFix.Common.XListPoolHelper$$Get<object>
0066938C0  ldr      x8, [x19, #0x50]
0066938C4  cbz      x8, #0x6693a3c
0066938C8  adrp     x9, #0x8f10000
0066938CC  ldr      x9, [x9, #0xab0]
0066938D0  mov      x20, x0
0066938D4  mov      x0, x8
0066938D8  ldr      x1, [x9]
0066938DC  bl       #0x5225924 ; Rock.Collections.OrderedDictionary<int, object>$$get_Values
0066938E0  cbz      x20, #0x6693a3c
0066938E4  adrp     x8, #0x8f10000
0066938E8  ldr      x8, [x8, #0xa90]
0066938EC  mov      x1, x0
0066938F0  mov      x0, x20
0066938F4  ldr      x2, [x8]
0066938F8  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
0066938FC  ldr      w26, [x20, #0x18]
006693900  cmp      w26, #1
006693904  b.lt     #0x6693940
006693908  adrp     x27, #0x8f10000
00669390C  ldr      x27, [x27, #0xaa0]
006693910  mov      w21, wzr
006693914  ldr      x2, [x27]
006693918  mov      x0, x20
00669391C  mov      w1, w21
006693920  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006693924  cbz      x0, #0x6693934
006693928  mov      w1, wzr
00669392C  mov      x2, xzr
006693930  bl       #0x6638a60 ; HotFix.BattleLogic.BuffBase$$DeInit
006693934  add      w21, w21, #1
006693938  cmp      w26, w21
00669393C  b.ne     #0x6693914
006693940  ldrb     w8, [x22, #0xa4b]
006693944  cbnz     w8, #0x669395c
006693948  adrp     x0, #0x8ee5000
00669394C  ldr      x0, [x0, #0xb28]
006693950  bl       #0x382bd14 ; 
006693954  mov      w8, #1
006693958  strb     w8, [x22, #0xa4b]
00669395C  ldr      x1, [x24]
006693960  ldrb     w8, [x1, #0x53]
006693964  tbnz     w8, #5, #0x6693970
006693968  ldr      x21, [x19, #0x20]
00669396C  b        #0x6693980 ; 
006693970  ldr      x8, [x1, #0x60]
006693974  mov      x0, x19
006693978  blr      x8
00669397C  mov      x21, x0
006693980  cbz      x21, #0x6693a3c
006693984  ldrb     w8, [x23, #0xa90]
006693988  cbnz     w8, #0x66939a0
00669398C  adrp     x0, #0x8ee6000
006693990  ldr      x0, [x0, #0x3e0]
006693994  bl       #0x382bd14 ; 
006693998  mov      w8, #1
00669399C  strb     w8, [x23, #0xa90]
0066939A0  ldr      x1, [x25]
0066939A4  ldrb     w8, [x1, #0x53]
0066939A8  tbnz     w8, #5, #0x66939b4
0066939AC  ldr      x0, [x21, #0x230]
0066939B0  b        #0x66939c0 ; 
0066939B4  ldr      x8, [x1, #0x60]
0066939B8  mov      x0, x21
0066939BC  blr      x8
0066939C0  cbz      x0, #0x6693a3c
0066939C4  adrp     x8, #0x8f10000
0066939C8  ldr      x8, [x8, #0xac0]
0066939CC  mov      x1, x20
0066939D0  ldr      x2, [x8]
0066939D4  bl       #0x47866c4 ; HotFix.Common.XListPoolHelper$$Push<object>
0066939D8  ldr      x0, [x19, #0x50]
0066939DC  cbz      x0, #0x6693a3c
0066939E0  adrp     x8, #0x8f10000
0066939E4  ldr      x8, [x8, #0xaa8]
0066939E8  ldr      x1, [x8]
0066939EC  bl       #0x5225c90 ; Rock.Collections.OrderedDictionary<int, object>$$Clear
0066939F0  ldr      x0, [x19, #0x60]
0066939F4  cbz      x0, #0x6693a3c
0066939F8  adrp     x8, #0x8f10000
0066939FC  ldr      x8, [x8, #0xa88]
006693A00  ldr      x1, [x8]
006693A04  bl       #0x5e99ae8 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$Clear
006693A08  ldr      x0, [x19, #0x68]
006693A0C  str      xzr, [x19, #0x40]
006693A10  strb     wzr, [x19, #0x48]
006693A14  cbz      x0, #0x6693a3c
006693A18  ldr      w2, [x0, #0x18]
006693A1C  ldp      x20, x19, [sp, #0x40]
006693A20  ldp      x22, x21, [sp, #0x30]
006693A24  ldp      x24, x23, [sp, #0x20]
006693A28  ldp      x26, x25, [sp, #0x10]
006693A2C  mov      w1, wzr
006693A30  mov      x3, xzr
006693A34  ldp      x30, x27, [sp], #0x50
006693A38  b        #0x7c001d0 ; System.Array$$Clear
006693A3C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$OnUpdate
; RVA 0x6693A40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006693A40  sub      sp, sp, #0x1a0
006693A44  stp      x29, x30, [sp, #0x140]
006693A48  stp      x28, x27, [sp, #0x150]
006693A4C  stp      x26, x25, [sp, #0x160]
006693A50  stp      x24, x23, [sp, #0x170]
006693A54  stp      x22, x21, [sp, #0x180]
006693A58  stp      x20, x19, [sp, #0x190]
006693A5C  mrs      x25, tpidr_el0
006693A60  ldr      x8, [x25, #0x28]
006693A64  adrp     x20, #0x959a000
006693A68  adrp     x22, #0x8f10000
006693A6C  mov      x21, x1
006693A70  str      x8, [sp, #0x138]
006693A74  ldrb     w8, [x20, #0x55]
006693A78  ldr      x22, [x22, #0xac8]
006693A7C  mov      x19, x0
006693A80  tbnz     w8, #0, #0x6693b04
006693A84  adrp     x0, #0x8f10000
006693A88  ldr      x0, [x0, #0xac8]
006693A8C  bl       #0x382bd14 ; 
006693A90  adrp     x0, #0x8ee6000
006693A94  ldr      x0, [x0, #0xd8]
006693A98  bl       #0x382bd14 ; 
006693A9C  adrp     x0, #0x8ee6000
006693AA0  ldr      x0, [x0, #0x608]
006693AA4  bl       #0x382bd14 ; 
006693AA8  adrp     x0, #0x8f10000
006693AAC  ldr      x0, [x0, #0xa90]
006693AB0  bl       #0x382bd14 ; 
006693AB4  adrp     x0, #0x8f10000
006693AB8  ldr      x0, [x0, #0xa98]
006693ABC  bl       #0x382bd14 ; 
006693AC0  adrp     x0, #0x8f10000
006693AC4  ldr      x0, [x0, #0xaa0]
006693AC8  bl       #0x382bd14 ; 
006693ACC  adrp     x0, #0x8f06000
006693AD0  ldr      x0, [x0, #0x340]
006693AD4  bl       #0x382bd14 ; 
006693AD8  adrp     x0, #0x8f10000
006693ADC  ldr      x0, [x0, #0xab0]
006693AE0  bl       #0x382bd14 ; 
006693AE4  adrp     x0, #0x8f10000
006693AE8  ldr      x0, [x0, #0xab8]
006693AEC  bl       #0x382bd14 ; 
006693AF0  adrp     x0, #0x8f10000
006693AF4  ldr      x0, [x0, #0xac0]
006693AF8  bl       #0x382bd14 ; 
006693AFC  mov      w8, #1
006693B00  strb     w8, [x20, #0x55]
006693B04  ldr      x2, [x22]
006693B08  ldrb     w8, [x2, #0x53]
006693B0C  tbnz     w8, #5, #0x6693b54
006693B10  adrp     x20, #0x9591000
006693B14  ldrb     w8, [x20, #0xa4b]
006693B18  stp      xzr, xzr, [sp, #0x100]
006693B1C  str      xzr, [sp, #0x110]
006693B20  cbnz     w8, #0x6693b38
006693B24  adrp     x0, #0x8ee5000
006693B28  ldr      x0, [x0, #0xb28]
006693B2C  bl       #0x382bd14 ; 
006693B30  mov      w8, #1
006693B34  strb     w8, [x20, #0xa4b]
006693B38  adrp     x8, #0x8ee5000
006693B3C  ldr      x8, [x8, #0xb28]
006693B40  ldr      x1, [x8]
006693B44  ldrb     w8, [x1, #0x53]
006693B48  tbnz     w8, #5, #0x6693b68
006693B4C  ldr      x20, [x19, #0x20]
006693B50  b        #0x6693b78 ; 
006693B54  ldr      x8, [x2, #0x60]
006693B58  mov      x0, x19
006693B5C  mov      x1, x21
006693B60  blr      x8
006693B64  b        #0x6693ee0 ; 
006693B68  ldr      x8, [x1, #0x60]
006693B6C  mov      x0, x19
006693B70  blr      x8
006693B74  mov      x20, x0
006693B78  cbz      x20, #0x6694098
006693B7C  adrp     x22, #0x9591000
006693B80  ldrb     w8, [x22, #0xa90]
006693B84  cbnz     w8, #0x6693b9c
006693B88  adrp     x0, #0x8ee6000
006693B8C  ldr      x0, [x0, #0x3e0]
006693B90  bl       #0x382bd14 ; 
006693B94  mov      w8, #1
006693B98  strb     w8, [x22, #0xa90]
006693B9C  adrp     x8, #0x8ee6000
006693BA0  ldr      x8, [x8, #0x3e0]
006693BA4  ldr      x1, [x8]
006693BA8  ldrb     w8, [x1, #0x53]
006693BAC  tbnz     w8, #5, #0x6693bb8
006693BB0  ldr      x0, [x20, #0x230]
006693BB4  b        #0x6693bc4 ; 
006693BB8  ldr      x8, [x1, #0x60]
006693BBC  mov      x0, x20
006693BC0  blr      x8
006693BC4  cbz      x0, #0x6694098
006693BC8  adrp     x8, #0x8f10000
006693BCC  ldr      x8, [x8, #0xab8]
006693BD0  ldr      x1, [x8]
006693BD4  bl       #0x4784cec ; HotFix.Common.XListPoolHelper$$Get<object>
006693BD8  ldr      x8, [x19, #0x50]
006693BDC  cbz      x8, #0x6694098
006693BE0  adrp     x9, #0x8f10000
006693BE4  ldr      x9, [x9, #0xab0]
006693BE8  mov      x20, x0
006693BEC  mov      x0, x8
006693BF0  ldr      x1, [x9]
006693BF4  bl       #0x5225924 ; Rock.Collections.OrderedDictionary<int, object>$$get_Values
006693BF8  cbz      x20, #0x6694098
006693BFC  adrp     x8, #0x8f10000
006693C00  ldr      x8, [x8, #0xa90]
006693C04  mov      x1, x0
006693C08  mov      x0, x20
006693C0C  ldr      x2, [x8]
006693C10  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
006693C14  ldr      w29, [x20, #0x18]
006693C18  cmp      w29, #1
006693C1C  b.lt     #0x6693e30
006693C20  adrp     x28, #0x8f10000
006693C24  adrp     x22, #0x8f0d000
006693C28  ldr      x28, [x28, #0xaa0]
006693C2C  ldr      x22, [x22, #0x108]
006693C30  mov      w23, wzr
006693C34  adrp     x27, #0x9599000
006693C38  mov      w26, #1
006693C3C  ldr      x2, [x28]
006693C40  mov      x0, x20
006693C44  mov      w1, w23
006693C48  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006693C4C  cbz      x0, #0x6693ca0
006693C50  ldr      x8, [x0]
006693C54  mov      x1, x21
006693C58  mov      x24, x0
006693C5C  ldr      x9, [x8, #0x328]
006693C60  ldr      x2, [x8, #0x330]
006693C64  blr      x9
006693C68  ldrb     w8, [x27, #0xad3]
006693C6C  cbnz     w8, #0x6693c7c
006693C70  mov      x0, x22
006693C74  bl       #0x382bd14 ; 
006693C78  strb     w26, [x27, #0xad3]
006693C7C  ldr      x1, [x22]
006693C80  ldrb     w8, [x1, #0x53]
006693C84  tbnz     w8, #5, #0x6693cb0
006693C88  ldrb     w8, [x24, #0x6c]
006693C8C  cbz      w8, #0x6693ca0
006693C90  mov      x0, x19
006693C94  mov      x1, x24
006693C98  mov      w2, wzr
006693C9C  bl       #0x66940a0 ; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffInternal
006693CA0  add      w23, w23, #1
006693CA4  cmp      w29, w23
006693CA8  b.ne     #0x6693c3c
006693CAC  b        #0x6693cc4 ; 
006693CB0  ldr      x8, [x1, #0x60]
006693CB4  mov      x0, x24
006693CB8  blr      x8
006693CBC  tbnz     w0, #0, #0x6693c90
006693CC0  b        #0x6693ca0 ; 
006693CC4  cmp      w29, #2
006693CC8  b.lt     #0x6693e30
006693CCC  ldrb     w8, [x19, #0x48]
006693CD0  cbz      w8, #0x6693e30
006693CD4  adrp     x21, #0x9591000
006693CD8  ldrb     w8, [x21, #0xa4b]
006693CDC  cbnz     w8, #0x6693cf4
006693CE0  adrp     x0, #0x8ee5000
006693CE4  ldr      x0, [x0, #0xb28]
006693CE8  bl       #0x382bd14 ; 
006693CEC  mov      w8, #1
006693CF0  strb     w8, [x21, #0xa4b]
006693CF4  adrp     x8, #0x8ee5000
006693CF8  ldr      x8, [x8, #0xb28]
006693CFC  ldr      x1, [x8]
006693D00  ldrb     w8, [x1, #0x53]
006693D04  tbnz     w8, #5, #0x6693d10
006693D08  ldr      x0, [x19, #0x20]
006693D0C  b        #0x6693d1c ; 
006693D10  ldr      x8, [x1, #0x60]
006693D14  mov      x0, x19
006693D18  blr      x8
006693D1C  cbz      x0, #0x6694098
006693D20  ldr      x8, [x0, #0x198]
006693D24  ldr      x9, [x19, #0x40]
006693D28  sub      x8, x8, x9
006693D2C  cmp      x8, #0x10, lsl #12
006693D30  b.le     #0x6693e30
006693D34  mov      w1, #2
006693D38  mov      x0, x19
006693D3C  bl       #0x6694280 ; HotFix.BattleLogic.CharacterComponentBuff$$CheckBuffFLag
006693D40  mov      w21, w0
006693D44  mov      w1, #3
006693D48  mov      x0, x19
006693D4C  bl       #0x6694280 ; HotFix.BattleLogic.CharacterComponentBuff$$CheckBuffFLag
006693D50  tbz      w21, #0, #0x6693e30
006693D54  tbz      w0, #0, #0x6693e30
006693D58  cmp      w29, #1
006693D5C  b.lt     #0x6693e30
006693D60  adrp     x23, #0x8f0d000
006693D64  ldr      x23, [x23, #0x118]
006693D68  mov      w21, wzr
006693D6C  adrp     x26, #0x9599000
006693D70  ldr      x2, [x28]
006693D74  mov      x0, x20
006693D78  mov      w1, w21
006693D7C  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006693D80  cbz      x0, #0x6693e24
006693D84  ldrb     w8, [x27, #0xad3]
006693D88  mov      x24, x0
006693D8C  cbnz     w8, #0x6693da0
006693D90  mov      x0, x22
006693D94  bl       #0x382bd14 ; 
006693D98  mov      w8, #1
006693D9C  strb     w8, [x27, #0xad3]
006693DA0  ldr      x1, [x22]
006693DA4  ldrb     w8, [x1, #0x53]
006693DA8  tbnz     w8, #5, #0x6693db8
006693DAC  ldrb     w8, [x24, #0x6c]
006693DB0  cbnz     w8, #0x6693e24
006693DB4  b        #0x6693dc8 ; 
006693DB8  ldr      x8, [x1, #0x60]
006693DBC  mov      x0, x24
006693DC0  blr      x8
006693DC4  tbnz     w0, #0, #0x6693e24
006693DC8  ldrb     w8, [x26, #0xaf2]
006693DCC  cbnz     w8, #0x6693de0
006693DD0  mov      x0, x23
006693DD4  bl       #0x382bd14 ; 
006693DD8  mov      w8, #1
006693DDC  strb     w8, [x26, #0xaf2]
006693DE0  ldr      x1, [x23]
006693DE4  ldrb     w8, [x1, #0x53]
006693DE8  tbnz     w8, #5, #0x6693df8
006693DEC  ldrb     w8, [x24, #0x64]
006693DF0  cbnz     w8, #0x6693e24
006693DF4  b        #0x6693e08 ; 
006693DF8  ldr      x8, [x1, #0x60]
006693DFC  mov      x0, x24
006693E00  blr      x8
006693E04  tbnz     w0, #0, #0x6693e24
006693E08  ldr      x0, [x24, #0x48]
006693E0C  cbz      x0, #0x6694098
006693E10  mov      x1, xzr
006693E14  bl       #0x663f0ac ; HotFix.BattleLogic.BuffData$$get_BuffFlag
006693E18  and      w8, w0, #0xfffffffe
006693E1C  cmp      w8, #2
006693E20  b.eq     #0x6693f10
006693E24  add      w21, w21, #1
006693E28  cmp      w29, w21
006693E2C  b.ne     #0x6693d70
006693E30  adrp     x21, #0x9591000
006693E34  ldrb     w8, [x21, #0xa4b]
006693E38  cbnz     w8, #0x6693e50
006693E3C  adrp     x0, #0x8ee5000
006693E40  ldr      x0, [x0, #0xb28]
006693E44  bl       #0x382bd14 ; 
006693E48  mov      w8, #1
006693E4C  strb     w8, [x21, #0xa4b]
006693E50  adrp     x8, #0x8ee5000
006693E54  ldr      x8, [x8, #0xb28]
006693E58  adrp     x22, #0x8ee6000
006693E5C  adrp     x21, #0x9591000
006693E60  ldr      x1, [x8]
006693E64  ldrb     w8, [x1, #0x53]
006693E68  ldr      x22, [x22, #0x3e0]
006693E6C  tbnz     w8, #5, #0x6693e78
006693E70  ldr      x19, [x19, #0x20]
006693E74  b        #0x6693e88 ; 
006693E78  ldr      x8, [x1, #0x60]
006693E7C  mov      x0, x19
006693E80  blr      x8
006693E84  mov      x19, x0
006693E88  cbz      x19, #0x6694098
006693E8C  ldrb     w8, [x21, #0xa90]
006693E90  cbnz     w8, #0x6693ea8
006693E94  adrp     x0, #0x8ee6000
006693E98  ldr      x0, [x0, #0x3e0]
006693E9C  bl       #0x382bd14 ; 
006693EA0  mov      w8, #1
006693EA4  strb     w8, [x21, #0xa90]
006693EA8  ldr      x1, [x22]
006693EAC  ldrb     w8, [x1, #0x53]
006693EB0  tbnz     w8, #5, #0x6693ebc
006693EB4  ldr      x0, [x19, #0x230]
006693EB8  b        #0x6693ec8 ; 
006693EBC  ldr      x8, [x1, #0x60]
006693EC0  mov      x0, x19
006693EC4  blr      x8
006693EC8  cbz      x0, #0x6694098
006693ECC  adrp     x8, #0x8f10000
006693ED0  ldr      x8, [x8, #0xac0]
006693ED4  mov      x1, x20
006693ED8  ldr      x2, [x8]
006693EDC  bl       #0x47866c4 ; HotFix.Common.XListPoolHelper$$Push<object>
006693EE0  ldr      x8, [x25, #0x28]
006693EE4  ldr      x9, [sp, #0x138]
006693EE8  cmp      x8, x9
006693EEC  b.ne     #0x669409c
006693EF0  ldp      x20, x19, [sp, #0x190]
006693EF4  ldp      x22, x21, [sp, #0x180]
006693EF8  ldp      x24, x23, [sp, #0x170]
006693EFC  ldp      x26, x25, [sp, #0x160]
006693F00  ldp      x28, x27, [sp, #0x150]
006693F04  ldp      x29, x30, [sp, #0x140]
006693F08  add      sp, sp, #0x1a0
006693F0C  ret      
006693F10  mov      x0, x24
006693F14  mov      x1, xzr
006693F18  bl       #0x663690c ; HotFix.BattleLogic.BuffBase$$get_Caster
006693F1C  cbz      x0, #0x6693e30
006693F20  adrp     x22, #0x9591000
006693F24  ldrb     w8, [x22, #0xa4b]
006693F28  mov      x21, x0
006693F2C  cbnz     w8, #0x6693f44
006693F30  adrp     x0, #0x8ee5000
006693F34  ldr      x0, [x0, #0xb28]
006693F38  bl       #0x382bd14 ; 
006693F3C  mov      w8, #1
006693F40  strb     w8, [x22, #0xa4b]
006693F44  adrp     x8, #0x8ee5000
006693F48  ldr      x8, [x8, #0xb28]
006693F4C  ldr      x1, [x8]
006693F50  ldrb     w8, [x1, #0x53]
006693F54  tbnz     w8, #5, #0x6693f60
006693F58  ldr      x0, [x19, #0x20]
006693F5C  b        #0x6693f6c ; 
006693F60  ldr      x8, [x1, #0x60]
006693F64  mov      x0, x19
006693F68  blr      x8
006693F6C  cbz      x0, #0x6694098
006693F70  ldr      x8, [x0, #0x198]
006693F74  str      x8, [x19, #0x40]
006693F78  adrp     x8, #0x8ee6000
006693F7C  ldr      x8, [x8, #0x608]
006693F80  ldr      x1, [x8]
006693F84  ldrb     w8, [x1, #0x53]
006693F88  tbnz     w8, #5, #0x6693f94
006693F8C  ldr      x0, [x19, #0x30]
006693F90  b        #0x6693fa0 ; 
006693F94  ldr      x8, [x1, #0x60]
006693F98  mov      x0, x19
006693F9C  blr      x8
006693FA0  cbz      x0, #0x6694098
006693FA4  adrp     x8, #0x8ee6000
006693FA8  ldr      x8, [x8, #0xd8]
006693FAC  ldr      x1, [x8]
006693FB0  ldrb     w8, [x1, #0x53]
006693FB4  tbnz     w8, #5, #0x6693fc0
006693FB8  ldr      x0, [x0, #0x38]
006693FBC  b        #0x6693fc8 ; 
006693FC0  ldr      x8, [x1, #0x60]
006693FC4  blr      x8
006693FC8  cbz      x0, #0x6694098
006693FCC  add      x8, sp, #0xc0
006693FD0  mov      x1, xzr
006693FD4  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006693FD8  ldr      x8, [sp, #0xd0]
006693FDC  ldr      q0, [sp, #0xc0]
006693FE0  mov      x0, xzr
006693FE4  str      x8, [sp, #0x110]
006693FE8  str      x8, [sp, #0xf0]
006693FEC  add      x8, sp, #0xa0
006693FF0  str      q0, [sp, #0x100]
006693FF4  str      q0, [sp, #0xe0]
006693FF8  bl       #0x7d4b8bc ; Photon.Deterministic.FPQuaternion$$get_Identity
006693FFC  adrp     x8, #0x8f06000
006694000  ldp      q0, q1, [sp, #0xa0]
006694004  ldr      x8, [x8, #0x340]
006694008  ldr      q2, [sp, #0x100]
00669400C  ldr      x9, [sp, #0x110]
006694010  movi     v3.2d, #0000000000000000
006694014  ldr      x2, [x8]
006694018  add      x0, sp, #0xa0
00669401C  add      x1, sp, #0x120
006694020  stp      q3, q3, [sp, #0xa0]
006694024  stp      q0, q1, [sp, #0xc0]
006694028  str      q2, [sp, #0x120]
00669402C  str      x9, [sp, #0x130]
006694030  bl       #0x5133758 ; System.Nullable<FPVector3>$$.ctor
006694034  ldp      q2, q0, [sp, #0xd0]
006694038  ldr      x8, [sp, #0xf0]
00669403C  ldp      q4, q1, [sp, #0xb0]
006694040  ldr      q3, [sp, #0xa0]
006694044  stp      q2, q0, [sp, #0x70]
006694048  str      x8, [sp, #0x90]
00669404C  movi     v0.2d, #0000000000000000
006694050  mov      w8, #1
006694054  add      x2, sp, #0x80
006694058  add      x3, sp, #0x60
00669405C  add      x4, sp, #0x40
006694060  mov      w1, #0x1770
006694064  mov      w6, #0x88
006694068  mov      x0, x21
00669406C  mov      x5, xzr
006694070  mov      w7, wzr
006694074  stp      q4, q1, [sp, #0x50]
006694078  str      q3, [sp, #0x40]
00669407C  stur     q0, [sp, #0x28]
006694080  strb     wzr, [sp, #0x20]
006694084  str      xzr, [sp, #0x10]
006694088  strb     w8, [sp, #0x18]
00669408C  str      q0, [sp]
006694090  bl       #0x67fd4e0 ; HotFix.BattleLogic.EntityCharacter$$CreateWeaponAndFire
006694094  b        #0x6693e30 ; 
006694098  bl       #0x382bfb8 ; 
00669409C  bl       #0x89edb60 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$OnLateUpdate
; RVA 0x6694320; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006694320  str      x30, [sp, #-0x30]!
006694324  stp      x22, x21, [sp, #0x10]
006694328  stp      x20, x19, [sp, #0x20]
00669432C  adrp     x21, #0x959a000
006694330  adrp     x22, #0x8f10000
006694334  ldrb     w8, [x21, #0x56]
006694338  ldr      x22, [x22, #0xb08]
00669433C  mov      x19, x1
006694340  mov      x20, x0
006694344  tbnz     w8, #0, #0x669435c
006694348  adrp     x0, #0x8f10000
00669434C  ldr      x0, [x0, #0xb08]
006694350  bl       #0x382bd14 ; 
006694354  mov      w8, #1
006694358  strb     w8, [x21, #0x56]
00669435C  ldr      x2, [x22]
006694360  ldrb     w8, [x2, #0x53]
006694364  tbnz     w8, #5, #0x6694378
006694368  ldp      x20, x19, [sp, #0x20]
00669436C  ldp      x22, x21, [sp, #0x10]
006694370  ldr      x30, [sp], #0x30
006694374  ret      
006694378  ldr      x3, [x2, #0x60]
00669437C  mov      x0, x20
006694380  mov      x1, x19
006694384  ldp      x20, x19, [sp, #0x20]
006694388  ldp      x22, x21, [sp, #0x10]
00669438C  ldr      x30, [sp], #0x30
006694390  br       x3

; HotFix.BattleLogic.CharacterComponentBuff$$OnEvent
; RVA 0x6694394; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006694394  stp      x30, x23, [sp, #-0x30]!
006694398  stp      x22, x21, [sp, #0x10]
00669439C  stp      x20, x19, [sp, #0x20]
0066943A0  adrp     x22, #0x959a000
0066943A4  adrp     x23, #0x8f10000
0066943A8  ldrb     w8, [x22, #0x57]
0066943AC  ldr      x23, [x23, #0xb10]
0066943B0  mov      x19, x2
0066943B4  mov      w20, w1
0066943B8  mov      x21, x0
0066943BC  tbnz     w8, #0, #0x66943d4
0066943C0  adrp     x0, #0x8f10000
0066943C4  ldr      x0, [x0, #0xb10]
0066943C8  bl       #0x382bd14 ; 
0066943CC  mov      w8, #1
0066943D0  strb     w8, [x22, #0x57]
0066943D4  ldr      x3, [x23]
0066943D8  ldrb     w8, [x3, #0x53]
0066943DC  tbnz     w8, #5, #0x66943f0
0066943E0  ldp      x20, x19, [sp, #0x20]
0066943E4  ldp      x22, x21, [sp, #0x10]
0066943E8  ldp      x30, x23, [sp], #0x30
0066943EC  ret      
0066943F0  ldr      x4, [x3, #0x60]
0066943F4  mov      x0, x21
0066943F8  mov      w1, w20
0066943FC  mov      x2, x19
006694400  ldp      x20, x19, [sp, #0x20]
006694404  ldp      x22, x21, [sp, #0x10]
006694408  ldp      x30, x23, [sp], #0x30
00669440C  br       x4

; HotFix.BattleLogic.CharacterComponentBuff$$CheckShield
; RVA 0x6694410; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006694410  sub      sp, sp, #0x70
006694414  stp      x30, x23, [sp, #0x40]
006694418  stp      x22, x21, [sp, #0x50]
00669441C  stp      x20, x19, [sp, #0x60]
006694420  adrp     x22, #0x959a000
006694424  adrp     x23, #0x8f10000
006694428  ldrb     w8, [x22, #0x58]
00669442C  ldr      x23, [x23, #0xb18]
006694430  mov      w19, w2
006694434  mov      w20, w1
006694438  mov      x21, x0
00669443C  tbnz     w8, #0, #0x6694490
006694440  adrp     x0, #0x8f10000
006694444  ldr      x0, [x0, #0xb20]
006694448  bl       #0x382bd14 ; 
00669444C  adrp     x0, #0x8f10000
006694450  ldr      x0, [x0, #0xb18]
006694454  bl       #0x382bd14 ; 
006694458  adrp     x0, #0x8f10000
00669445C  ldr      x0, [x0, #0xb28]
006694460  bl       #0x382bd14 ; 
006694464  adrp     x0, #0x8f10000
006694468  ldr      x0, [x0, #0xb30]
00669446C  bl       #0x382bd14 ; 
006694470  adrp     x0, #0x8f10000
006694474  ldr      x0, [x0, #0xb38]
006694478  bl       #0x382bd14 ; 
00669447C  adrp     x0, #0x8f10000
006694480  ldr      x0, [x0, #0xb40]
006694484  bl       #0x382bd14 ; 
006694488  mov      w8, #1
00669448C  strb     w8, [x22, #0x58]
006694490  ldr      x3, [x23]
006694494  ldrb     w8, [x3, #0x53]
006694498  tbnz     w8, #5, #0x6694544
00669449C  stp      xzr, xzr, [sp, #0x20]
0066944A0  str      xzr, [sp, #0x30]
0066944A4  ldr      x0, [x21, #0x58]
0066944A8  cbz      x0, #0x66945a4
0066944AC  adrp     x8, #0x8f10000
0066944B0  ldr      x8, [x8, #0xb40]
0066944B4  ldr      x1, [x8]
0066944B8  add      x8, sp, #8
0066944BC  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
0066944C0  ldur     q0, [sp, #8]
0066944C4  ldr      x8, [sp, #0x18]
0066944C8  adrp     x22, #0x8f10000
0066944CC  ldr      x22, [x22, #0xb30]
0066944D0  str      q0, [sp, #0x20]
0066944D4  str      x8, [sp, #0x30]
0066944D8  adrp     x23, #0x8f10000
0066944DC  ldr      x23, [x23, #0xb20]
0066944E0  ldr      x1, [x22]
0066944E4  add      x0, sp, #0x20
0066944E8  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
0066944EC  mov      w21, w0
0066944F0  tbz      w0, #0, #0x6694568
0066944F4  ldr      x0, [sp, #0x30]
0066944F8  cbz      x0, #0x66944e0
0066944FC  ldr      x8, [x0]
006694500  ldr      x1, [x23]
006694504  ldrb     w10, [x8, #0x130]
006694508  ldrb     w9, [x1, #0x130]
00669450C  cmp      w10, w9
006694510  b.lo     #0x66945a0
006694514  ldr      x8, [x8, #0xc8]
006694518  add      x8, x8, x9, lsl #3
00669451C  ldur     x8, [x8, #-8]
006694520  cmp      x8, x1
006694524  b.ne     #0x66945a0
006694528  and      w1, w20, #1
00669452C  mov      w2, w19
006694530  mov      x3, xzr
006694534  bl       #0x66464ec ; HotFix.BattleLogic.Buff_Shield$$CheckShield
006694538  tbz      w0, #0, #0x66944e0
00669453C  mov      w19, #4
006694540  b        #0x669456c ; 
006694544  ldr      x4, [x3, #0x60]
006694548  and      w1, w20, #1
00669454C  mov      x0, x21
006694550  mov      w2, w19
006694554  ldp      x20, x19, [sp, #0x60]
006694558  ldp      x22, x21, [sp, #0x50]
00669455C  ldp      x30, x23, [sp, #0x40]
006694560  add      sp, sp, #0x70
006694564  br       x4
006694568  mov      w19, #5
00669456C  adrp     x8, #0x8f10000
006694570  ldr      x8, [x8, #0xb28]
006694574  add      x0, sp, #0x20
006694578  ldr      x1, [x8]
00669457C  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
006694580  cmp      w19, #4
006694584  cset     w8, eq
006694588  and      w0, w21, w8
00669458C  ldp      x20, x19, [sp, #0x60]
006694590  ldp      x22, x21, [sp, #0x50]
006694594  ldp      x30, x23, [sp, #0x40]
006694598  add      sp, sp, #0x70
00669459C  ret      
0066945A0  bl       #0x382c354 ; 
0066945A4  bl       #0x382bfb8 ; 
0066945A8  b        #0x66945b0 ; 
0066945AC  b        #0x66945b0 ; 
0066945B0  mov      x19, x0
0066945B4  cmp      w1, #1
0066945B8  b.ne     #0x66945f0
0066945BC  mov      x0, x19
0066945C0  bl       #0x89eda50 ; 
0066945C4  ldr      x20, [x0]
0066945C8  bl       #0x89eda60 ; 
0066945CC  adrp     x8, #0x8f10000
0066945D0  ldr      x8, [x8, #0xb28]
0066945D4  add      x0, sp, #0x20
0066945D8  ldr      x1, [x8]
0066945DC  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0066945E0  cbnz     x20, #0x66945f8
0066945E4  mov      w21, wzr
0066945E8  mov      w19, wzr
0066945EC  b        #0x6694580 ; 
0066945F0  mov      x20, xzr
0066945F4  b        #0x6694604 ; 
0066945F8  mov      x0, x20
0066945FC  bl       #0x382bfb0 ; 
006694600  mov      x19, x0
006694604  adrp     x8, #0x8f10000
006694608  ldr      x8, [x8, #0xb28]
00669460C  ldr      x1, [x8]
006694610  add      x0, sp, #0x20
006694614  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
006694618  cbnz     x20, #0x6694624
00669461C  mov      x0, x19
006694620  bl       #0x3b56bfc ; 
006694624  mov      x0, x20
006694628  bl       #0x382bfb0 ; 
00669462C  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffInternal
; RVA 0x66940A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066940A0  sub      sp, sp, #0x40
0066940A4  stp      x30, x23, [sp, #0x10]
0066940A8  stp      x22, x21, [sp, #0x20]
0066940AC  stp      x20, x19, [sp, #0x30]
0066940B0  adrp     x22, #0x959a000
0066940B4  adrp     x23, #0x8f10000
0066940B8  ldrb     w8, [x22, #0x59]
0066940BC  ldr      x23, [x23, #0xad0]
0066940C0  mov      w20, w2
0066940C4  mov      x19, x1
0066940C8  mov      x21, x0
0066940CC  tbnz     w8, #0, #0x6694120
0066940D0  adrp     x0, #0x8f10000
0066940D4  ldr      x0, [x0, #0xad0]
0066940D8  bl       #0x382bd14 ; 
0066940DC  adrp     x0, #0x8f10000
0066940E0  ldr      x0, [x0, #0xad8]
0066940E4  bl       #0x382bd14 ; 
0066940E8  adrp     x0, #0x8f10000
0066940EC  ldr      x0, [x0, #0xae0]
0066940F0  bl       #0x382bd14 ; 
0066940F4  adrp     x0, #0x8f10000
0066940F8  ldr      x0, [x0, #0xae8]
0066940FC  bl       #0x382bd14 ; 
006694100  adrp     x0, #0x8f10000
006694104  ldr      x0, [x0, #0xaf0]
006694108  bl       #0x382bd14 ; 
00669410C  adrp     x0, #0x8f10000
006694110  ldr      x0, [x0, #0xaf8]
006694114  bl       #0x382bd14 ; 
006694118  mov      w8, #1
00669411C  strb     w8, [x22, #0x59]
006694120  ldr      x3, [x23]
006694124  ldrb     w8, [x3, #0x53]
006694128  tbnz     w8, #5, #0x6694258
00669412C  str      xzr, [sp, #8]
006694130  cbz      x19, #0x6694244
006694134  ldr      x0, [x19, #0x48]
006694138  cbz      x0, #0x669427c
00669413C  mov      x1, xzr
006694140  bl       #0x66384a4 ; HotFix.BattleLogic.BuffData$$get_Id
006694144  ldr      x8, [x19, #0x48]
006694148  cbz      x8, #0x669427c
00669414C  mov      w22, w0
006694150  mov      x0, x8
006694154  mov      x1, xzr
006694158  bl       #0x663f0ac ; HotFix.BattleLogic.BuffData$$get_BuffFlag
00669415C  mov      w1, w0
006694160  mov      x0, x21
006694164  bl       #0x6694630 ; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffFlag
006694168  ldr      x0, [x21, #0x50]
00669416C  cbz      x0, #0x669427c
006694170  adrp     x8, #0x8f10000
006694174  ldr      x8, [x8, #0xaf0]
006694178  mov      w1, w22
00669417C  ldr      x2, [x8]
006694180  bl       #0x5225d20 ; Rock.Collections.OrderedDictionary<int, object>$$ContainsKey
006694184  tbz      w0, #0, #0x66941a4
006694188  ldr      x0, [x21, #0x50]
00669418C  cbz      x0, #0x669427c
006694190  adrp     x8, #0x8f10000
006694194  ldr      x8, [x8, #0xaf8]
006694198  mov      w1, w22
00669419C  ldr      x2, [x8]
0066941A0  bl       #0x52275b0 ; Rock.Collections.OrderedDictionary<int, object>$$Remove
0066941A4  ldr      x0, [x19, #0x48]
0066941A8  cbz      x0, #0x669427c
0066941AC  ldr      x22, [x21, #0x60]
0066941B0  mov      x1, xzr
0066941B4  bl       #0x663f284 ; HotFix.BattleLogic.BuffData$$get_BuffType
0066941B8  cbz      x22, #0x669427c
0066941BC  adrp     x8, #0x8f10000
0066941C0  ldr      x8, [x8, #0xad8]
0066941C4  mov      w1, w0
0066941C8  add      x2, sp, #8
0066941CC  mov      x0, x22
0066941D0  ldr      x3, [x8]
0066941D4  bl       #0x5e9b3f0 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$TryGetValue
0066941D8  tbz      w0, #0, #0x6694218
0066941DC  ldr      x0, [sp, #8]
0066941E0  cbz      x0, #0x669427c
0066941E4  adrp     x8, #0x8f10000
0066941E8  ldr      x8, [x8, #0xae0]
0066941EC  mov      x1, x19
0066941F0  ldr      x2, [x8]
0066941F4  bl       #0x4db01c0 ; System.Collections.Generic.List<object>$$Contains
0066941F8  tbz      w0, #0, #0x6694218
0066941FC  ldr      x0, [sp, #8]
006694200  cbz      x0, #0x669427c
006694204  adrp     x8, #0x8f10000
006694208  ldr      x8, [x8, #0xae8]
00669420C  mov      x1, x19
006694210  ldr      x2, [x8]
006694214  bl       #0x4db16c0 ; System.Collections.Generic.List<object>$$Remove
006694218  ldr      x0, [x21, #0x58]
00669421C  cbz      x0, #0x669427c
006694220  adrp     x8, #0x8f10000
006694224  ldr      x8, [x8, #0xae8]
006694228  mov      x1, x19
00669422C  ldr      x2, [x8]
006694230  bl       #0x4db16c0 ; System.Collections.Generic.List<object>$$Remove
006694234  and      w1, w20, #1
006694238  mov      x0, x19
00669423C  mov      x2, xzr
006694240  bl       #0x6638a60 ; HotFix.BattleLogic.BuffBase$$DeInit
006694244  ldp      x20, x19, [sp, #0x30]
006694248  ldp      x22, x21, [sp, #0x20]
00669424C  ldp      x30, x23, [sp, #0x10]
006694250  add      sp, sp, #0x40
006694254  ret      
006694258  ldr      x4, [x3, #0x60]
00669425C  and      w2, w20, #1
006694260  mov      x0, x21
006694264  mov      x1, x19
006694268  ldp      x20, x19, [sp, #0x30]
00669426C  ldp      x22, x21, [sp, #0x20]
006694270  ldp      x30, x23, [sp, #0x10]
006694274  add      sp, sp, #0x40
006694278  br       x4
00669427C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$CheckBuffFLag
; RVA 0x6694280; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006694280  str      x30, [sp, #-0x30]!
006694284  stp      x22, x21, [sp, #0x10]
006694288  stp      x20, x19, [sp, #0x20]
00669428C  adrp     x21, #0x959a000
006694290  adrp     x22, #0x8f10000
006694294  ldrb     w8, [x21, #0x5a]
006694298  ldr      x22, [x22, #0xb00]
00669429C  mov      w19, w1
0066942A0  mov      x20, x0
0066942A4  tbnz     w8, #0, #0x66942bc
0066942A8  adrp     x0, #0x8f10000
0066942AC  ldr      x0, [x0, #0xb00]
0066942B0  bl       #0x382bd14 ; 
0066942B4  mov      w8, #1
0066942B8  strb     w8, [x21, #0x5a]
0066942BC  ldr      x2, [x22]
0066942C0  ldrb     w8, [x2, #0x53]
0066942C4  tbnz     w8, #5, #0x66942fc
0066942C8  ldr      x8, [x20, #0x68]
0066942CC  cbz      x8, #0x6694318
0066942D0  ldr      w9, [x8, #0x18]
0066942D4  cmp      w9, w19
0066942D8  b.ls     #0x669431c
0066942DC  add      x8, x8, w19, sxtw
0066942E0  ldrb     w8, [x8, #0x20]
0066942E4  ldp      x20, x19, [sp, #0x20]
0066942E8  ldp      x22, x21, [sp, #0x10]
0066942EC  cmp      w8, #0
0066942F0  cset     w0, ne
0066942F4  ldr      x30, [sp], #0x30
0066942F8  ret      
0066942FC  ldr      x3, [x2, #0x60]
006694300  mov      x0, x20
006694304  mov      w1, w19
006694308  ldp      x20, x19, [sp, #0x20]
00669430C  ldp      x22, x21, [sp, #0x10]
006694310  ldr      x30, [sp], #0x30
006694314  br       x3
006694318  bl       #0x382bfb8 ; 
00669431C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$GetAllBuffFlags
; RVA 0x66946D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066946D0  str      x30, [sp, #-0x30]!
0066946D4  stp      x22, x21, [sp, #0x10]
0066946D8  stp      x20, x19, [sp, #0x20]
0066946DC  adrp     x20, #0x959a000
0066946E0  adrp     x21, #0x8f10000
0066946E4  ldrb     w8, [x20, #0x5b]
0066946E8  ldr      x21, [x21, #0xb50]
0066946EC  mov      x19, x0
0066946F0  tbnz     w8, #0, #0x669472c
0066946F4  adrp     x0, #0x8f10000
0066946F8  ldr      x0, [x0, #0xb50]
0066946FC  bl       #0x382bd14 ; 
006694700  adrp     x0, #0x8ec2000
006694704  ldr      x0, [x0, #0x260]
006694708  bl       #0x382bd14 ; 
00669470C  adrp     x0, #0x8ec2000
006694710  ldr      x0, [x0, #0x2b8]
006694714  bl       #0x382bd14 ; 
006694718  adrp     x0, #0x8ec2000
00669471C  ldr      x0, [x0, #0x2d0]
006694720  bl       #0x382bd14 ; 
006694724  mov      w8, #1
006694728  strb     w8, [x20, #0x5b]
00669472C  ldr      x1, [x21]
006694730  ldrb     w8, [x1, #0x53]
006694734  tbnz     w8, #5, #0x66947f8
006694738  adrp     x8, #0x8ec2000
00669473C  ldr      x8, [x8, #0x2d0]
006694740  ldr      x0, [x8]
006694744  bl       #0x382bfa0 ; 
006694748  adrp     x8, #0x8ec2000
00669474C  ldr      x8, [x8, #0x2b8]
006694750  mov      x20, x0
006694754  ldr      x1, [x8]
006694758  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
00669475C  ldr      x8, [x19, #0x68]
006694760  cbz      x8, #0x66947f4
006694764  adrp     x22, #0x8ec2000
006694768  ldr      x22, [x22, #0x260]
00669476C  mov      x21, xzr
006694770  ldr      w9, [x8, #0x18]
006694774  cmp      x21, w9, sxtw
006694778  b.ge     #0x6694810
00669477C  cmp      x21, x9
006694780  b.hs     #0x6694824
006694784  add      x9, x8, x21
006694788  ldrb     w9, [x9, #0x20]
00669478C  cbz      w9, #0x66947ec
006694790  cbz      x20, #0x66947f4
006694794  ldr      w11, [x20, #0x1c]
006694798  ldr      x9, [x20, #0x10]
00669479C  ldr      x10, [x22]
0066947A0  add      w11, w11, #1
0066947A4  str      w11, [x20, #0x1c]
0066947A8  cbz      x9, #0x66947f4
0066947AC  ldrsw    x11, [x20, #0x18]
0066947B0  ldr      w12, [x9, #0x18]
0066947B4  cmp      w11, w12
0066947B8  b.hs     #0x66947d0
0066947BC  add      w10, w11, #1
0066947C0  add      x9, x9, x11, lsl #2
0066947C4  str      w10, [x20, #0x18]
0066947C8  str      w21, [x9, #0x20]
0066947CC  b        #0x66947ec ; 
0066947D0  ldr      x8, [x10, #0x20]
0066947D4  mov      x0, x20
0066947D8  mov      w1, w21
0066947DC  ldr      x8, [x8, #0xc0]
0066947E0  ldr      x2, [x8, #0x70]
0066947E4  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0066947E8  ldr      x8, [x19, #0x68]
0066947EC  add      x21, x21, #1
0066947F0  cbnz     x8, #0x6694770
0066947F4  bl       #0x382bfb8 ; 
0066947F8  ldr      x2, [x1, #0x60]
0066947FC  mov      x0, x19
006694800  ldp      x20, x19, [sp, #0x20]
006694804  ldp      x22, x21, [sp, #0x10]
006694808  ldr      x30, [sp], #0x30
00669480C  br       x2
006694810  mov      x0, x20
006694814  ldp      x20, x19, [sp, #0x20]
006694818  ldp      x22, x21, [sp, #0x10]
00669481C  ldr      x30, [sp], #0x30
006694820  ret      
006694824  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$AddBuffFlag
; RVA 0x6694828; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006694828  str      x30, [sp, #-0x30]!
00669482C  stp      x22, x21, [sp, #0x10]
006694830  stp      x20, x19, [sp, #0x20]
006694834  adrp     x21, #0x959a000
006694838  adrp     x22, #0x8f10000
00669483C  ldrb     w8, [x21, #0x5c]
006694840  ldr      x22, [x22, #0xb58]
006694844  mov      w19, w1
006694848  mov      x20, x0
00669484C  tbnz     w8, #0, #0x6694864
006694850  adrp     x0, #0x8f10000
006694854  ldr      x0, [x0, #0xb58]
006694858  bl       #0x382bd14 ; 
00669485C  mov      w8, #1
006694860  strb     w8, [x21, #0x5c]
006694864  ldr      x2, [x22]
006694868  ldrb     w8, [x2, #0x53]
00669486C  tbnz     w8, #5, #0x66948a4
006694870  ldr      x8, [x20, #0x68]
006694874  cbz      x8, #0x66948c0
006694878  ldr      w9, [x8, #0x18]
00669487C  cmp      w9, w19
006694880  b.ls     #0x66948c4
006694884  add      x8, x8, w19, sxtw
006694888  ldrb     w9, [x8, #0x20]
00669488C  ldp      x20, x19, [sp, #0x20]
006694890  ldp      x22, x21, [sp, #0x10]
006694894  add      w9, w9, #1
006694898  strb     w9, [x8, #0x20]
00669489C  ldr      x30, [sp], #0x30
0066948A0  ret      
0066948A4  ldr      x3, [x2, #0x60]
0066948A8  mov      x0, x20
0066948AC  mov      w1, w19
0066948B0  ldp      x20, x19, [sp, #0x20]
0066948B4  ldp      x22, x21, [sp, #0x10]
0066948B8  ldr      x30, [sp], #0x30
0066948BC  br       x3
0066948C0  bl       #0x382bfb8 ; 
0066948C4  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffFlag
; RVA 0x6694630; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006694630  str      x30, [sp, #-0x30]!
006694634  stp      x22, x21, [sp, #0x10]
006694638  stp      x20, x19, [sp, #0x20]
00669463C  adrp     x21, #0x959a000
006694640  adrp     x22, #0x8f10000
006694644  ldrb     w8, [x21, #0x5d]
006694648  ldr      x22, [x22, #0xb48]
00669464C  mov      w19, w1
006694650  mov      x20, x0
006694654  tbnz     w8, #0, #0x669466c
006694658  adrp     x0, #0x8f10000
00669465C  ldr      x0, [x0, #0xb48]
006694660  bl       #0x382bd14 ; 
006694664  mov      w8, #1
006694668  strb     w8, [x21, #0x5d]
00669466C  ldr      x2, [x22]
006694670  ldrb     w8, [x2, #0x53]
006694674  tbnz     w8, #5, #0x66946ac
006694678  ldr      x8, [x20, #0x68]
00669467C  cbz      x8, #0x66946c8
006694680  ldr      w9, [x8, #0x18]
006694684  cmp      w9, w19
006694688  b.ls     #0x66946cc
00669468C  add      x8, x8, w19, sxtw
006694690  ldrb     w9, [x8, #0x20]
006694694  ldp      x20, x19, [sp, #0x20]
006694698  ldp      x22, x21, [sp, #0x10]
00669469C  sub      w9, w9, #1
0066946A0  strb     w9, [x8, #0x20]
0066946A4  ldr      x30, [sp], #0x30
0066946A8  ret      
0066946AC  ldr      x3, [x2, #0x60]
0066946B0  mov      x0, x20
0066946B4  mov      w1, w19
0066946B8  ldp      x20, x19, [sp, #0x20]
0066946BC  ldp      x22, x21, [sp, #0x10]
0066946C0  ldr      x30, [sp], #0x30
0066946C4  br       x3
0066946C8  bl       #0x382bfb8 ; 
0066946CC  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$AddBuff
; RVA 0x66948C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066948C8  sub      sp, sp, #0x90
0066948CC  stp      x29, x30, [sp, #0x30]
0066948D0  stp      x28, x27, [sp, #0x40]
0066948D4  stp      x26, x25, [sp, #0x50]
0066948D8  stp      x24, x23, [sp, #0x60]
0066948DC  stp      x22, x21, [sp, #0x70]
0066948E0  stp      x20, x19, [sp, #0x80]
0066948E4  adrp     x22, #0x959a000
0066948E8  adrp     x27, #0x8f10000
0066948EC  ldrb     w8, [x22, #0x5e]
0066948F0  ldr      x27, [x27, #0xb60]
0066948F4  mov      w23, w7
0066948F8  mov      w26, w6
0066948FC  mov      w29, w5
006694900  mov      w19, w4
006694904  mov      x24, x3
006694908  mov      x25, x2
00669490C  mov      x20, x1
006694910  mov      x21, x0
006694914  tbnz     w8, #0, #0x6694a34
006694918  adrp     x0, #0x8f10000
00669491C  ldr      x0, [x0, #0xb68]
006694920  bl       #0x382bd14 ; 
006694924  adrp     x0, #0x8f10000
006694928  ldr      x0, [x0, #0xb70]
00669492C  bl       #0x382bd14 ; 
006694930  adrp     x0, #0x8f10000
006694934  ldr      x0, [x0, #0xb60]
006694938  bl       #0x382bd14 ; 
00669493C  adrp     x0, #0x8f10000
006694940  ldr      x0, [x0, #0xb78]
006694944  bl       #0x382bd14 ; 
006694948  adrp     x0, #0x8f10000
00669494C  ldr      x0, [x0, #0xb80]
006694950  bl       #0x382bd14 ; 
006694954  adrp     x0, #0x8f10000
006694958  ldr      x0, [x0, #0xb88]
00669495C  bl       #0x382bd14 ; 
006694960  adrp     x0, #0x8f10000
006694964  ldr      x0, [x0, #0xad8]
006694968  bl       #0x382bd14 ; 
00669496C  adrp     x0, #0x8f10000
006694970  ldr      x0, [x0, #0xb90]
006694974  bl       #0x382bd14 ; 
006694978  adrp     x0, #0x8f10000
00669497C  ldr      x0, [x0, #0xb98]
006694980  bl       #0x382bd14 ; 
006694984  adrp     x0, #0x8ee6000
006694988  ldr      x0, [x0, #0xd8]
00669498C  bl       #0x382bd14 ; 
006694990  adrp     x0, #0x8ee6000
006694994  ldr      x0, [x0, #0x608]
006694998  bl       #0x382bd14 ; 
00669499C  adrp     x0, #0x8ee6000
0066949A0  ldr      x0, [x0, #0x108]
0066949A4  bl       #0x382bd14 ; 
0066949A8  adrp     x0, #0x8ebf000
0066949AC  ldr      x0, [x0, #0xba0]
0066949B0  bl       #0x382bd14 ; 
0066949B4  adrp     x0, #0x8f10000
0066949B8  ldr      x0, [x0, #0xba0]
0066949BC  bl       #0x382bd14 ; 
0066949C0  adrp     x0, #0x8f10000
0066949C4  ldr      x0, [x0, #0xba8]
0066949C8  bl       #0x382bd14 ; 
0066949CC  adrp     x0, #0x8f10000
0066949D0  ldr      x0, [x0, #0xbb0]
0066949D4  bl       #0x382bd14 ; 
0066949D8  adrp     x0, #0x8ee1000
0066949DC  ldr      x0, [x0, #0x6e8]
0066949E0  bl       #0x382bd14 ; 
0066949E4  adrp     x0, #0x8f10000
0066949E8  ldr      x0, [x0, #0xbb8]
0066949EC  bl       #0x382bd14 ; 
0066949F0  adrp     x0, #0x8f10000
0066949F4  ldr      x0, [x0, #0xbc0]
0066949F8  bl       #0x382bd14 ; 
0066949FC  adrp     x0, #0x8f10000
006694A00  ldr      x0, [x0, #0xbc8]
006694A04  bl       #0x382bd14 ; 
006694A08  adrp     x0, #0x8f10000
006694A0C  ldr      x0, [x0, #0xbd0]
006694A10  bl       #0x382bd14 ; 
006694A14  adrp     x0, #0x8f10000
006694A18  ldr      x0, [x0, #0xbd8]
006694A1C  bl       #0x382bd14 ; 
006694A20  adrp     x0, #0x8f10000
006694A24  ldr      x0, [x0, #0xbe0]
006694A28  bl       #0x382bd14 ; 
006694A2C  mov      w8, #1
006694A30  strb     w8, [x22, #0x5e]
006694A34  ldr      x8, [x27]
006694A38  ldrb     w9, [x8, #0x53]
006694A3C  tbnz     w9, #5, #0x6694a84
006694A40  adrp     x22, #0x9591000
006694A44  ldrb     w8, [x22, #0xa4b]
006694A48  stp      xzr, xzr, [sp, #0x20]
006694A4C  stp      xzr, xzr, [sp, #0x10]
006694A50  cbnz     w8, #0x6694a68
006694A54  adrp     x0, #0x8ee5000
006694A58  ldr      x0, [x0, #0xb28]
006694A5C  bl       #0x382bd14 ; 
006694A60  mov      w8, #1
006694A64  strb     w8, [x22, #0xa4b]
006694A68  adrp     x28, #0x8ee5000
006694A6C  ldr      x28, [x28, #0xb28]
006694A70  ldr      x1, [x28]
006694A74  ldrb     w8, [x1, #0x53]
006694A78  tbnz     w8, #5, #0x6694acc
006694A7C  ldr      x0, [x21, #0x20]
006694A80  b        #0x6694ad8 ; 
006694A84  ldr      x9, [x8, #0x60]
006694A88  and      w5, w29, #1
006694A8C  and      w6, w26, #1
006694A90  mov      x0, x21
006694A94  mov      x1, x20
006694A98  mov      x2, x25
006694A9C  mov      x3, x24
006694AA0  mov      w4, w19
006694AA4  mov      w7, w23
006694AA8  ldp      x20, x19, [sp, #0x80]
006694AAC  ldp      x22, x21, [sp, #0x70]
006694AB0  ldp      x24, x23, [sp, #0x60]
006694AB4  ldp      x26, x25, [sp, #0x50]
006694AB8  ldp      x28, x27, [sp, #0x40]
006694ABC  ldp      x29, x30, [sp, #0x30]
006694AC0  str      x8, [sp, #0x90]
006694AC4  add      sp, sp, #0x90
006694AC8  br       x9
006694ACC  ldr      x8, [x1, #0x60]
006694AD0  mov      x0, x21
006694AD4  blr      x8
006694AD8  cbz      x0, #0x66958dc
006694ADC  ldr      x0, [x0, #0x78]
006694AE0  cbz      x0, #0x66958dc
006694AE4  adrp     x8, #0x8f10000
006694AE8  ldr      x8, [x8, #0xb88]
006694AEC  add      x2, sp, #0x28
006694AF0  mov      w1, w19
006694AF4  ldr      x3, [x8]
006694AF8  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
006694AFC  tbnz     w0, #0, #0x6694d44
006694B00  ldrb     w8, [x22, #0xa4b]
006694B04  cbnz     w8, #0x6694b1c
006694B08  adrp     x0, #0x8ee5000
006694B0C  ldr      x0, [x0, #0xb28]
006694B10  bl       #0x382bd14 ; 
006694B14  mov      w8, #1
006694B18  strb     w8, [x22, #0xa4b]
006694B1C  ldr      x1, [x28]
006694B20  ldrb     w8, [x1, #0x53]
006694B24  tbnz     w8, #5, #0x6694b30
006694B28  ldr      x27, [x21, #0x20]
006694B2C  b        #0x6694b40 ; 
006694B30  ldr      x8, [x1, #0x60]
006694B34  mov      x0, x21
006694B38  blr      x8
006694B3C  mov      x27, x0
006694B40  adrp     x8, #0x8f10000
006694B44  ldr      x8, [x8, #0xb70]
006694B48  ldr      x0, [x8]
006694B4C  bl       #0x382bfa0 ; 
006694B50  mov      x1, x27
006694B54  mov      x2, xzr
006694B58  mov      x28, x0
006694B5C  bl       #0x663fb5c ; HotFix.BattleLogic.BuffData$$.ctor
006694B60  ldrb     w8, [x22, #0xa4b]
006694B64  str      x28, [sp, #0x28]
006694B68  cbnz     w8, #0x6694b80
006694B6C  adrp     x0, #0x8ee5000
006694B70  ldr      x0, [x0, #0xb28]
006694B74  bl       #0x382bd14 ; 
006694B78  mov      w8, #1
006694B7C  strb     w8, [x22, #0xa4b]
006694B80  adrp     x8, #0x8ee5000
006694B84  ldr      x8, [x8, #0xb28]
006694B88  ldr      x1, [x8]
006694B8C  ldrb     w8, [x1, #0x53]
006694B90  tbnz     w8, #5, #0x6694b9c
006694B94  ldr      x27, [x21, #0x20]
006694B98  b        #0x6694bac ; 
006694B9C  ldr      x8, [x1, #0x60]
006694BA0  mov      x0, x21
006694BA4  blr      x8
006694BA8  mov      x27, x0
006694BAC  cbz      x27, #0x66958dc
006694BB0  adrp     x28, #0x9598000
006694BB4  ldrb     w8, [x28, #0xfcc]
006694BB8  cbnz     w8, #0x6694bd0
006694BBC  adrp     x0, #0x8f06000
006694BC0  ldr      x0, [x0, #0x470]
006694BC4  bl       #0x382bd14 ; 
006694BC8  mov      w8, #1
006694BCC  strb     w8, [x28, #0xfcc]
006694BD0  adrp     x8, #0x8f06000
006694BD4  ldr      x8, [x8, #0x470]
006694BD8  ldr      x1, [x8]
006694BDC  ldrb     w8, [x1, #0x53]
006694BE0  tbnz     w8, #5, #0x6694bec
006694BE4  ldr      x27, [x27, #0x200]
006694BE8  b        #0x6694bfc ; 
006694BEC  ldr      x8, [x1, #0x60]
006694BF0  mov      x0, x27
006694BF4  blr      x8
006694BF8  mov      x27, x0
006694BFC  cbz      x27, #0x66958dc
006694C00  adrp     x28, #0x959a000
006694C04  ldrb     w8, [x28, #0x102]
006694C08  cbnz     w8, #0x6694c20
006694C0C  adrp     x0, #0x8efa000
006694C10  ldr      x0, [x0, #0x948]
006694C14  bl       #0x382bd14 ; 
006694C18  mov      w8, #1
006694C1C  strb     w8, [x28, #0x102]
006694C20  adrp     x8, #0x8efa000
006694C24  ldr      x8, [x8, #0x948]
006694C28  ldr      x1, [x8]
006694C2C  ldrb     w8, [x1, #0x53]
006694C30  tbnz     w8, #5, #0x6694c3c
006694C34  ldr      x0, [x27, #0x1a8]
006694C38  b        #0x6694c48 ; 
006694C3C  ldr      x8, [x1, #0x60]
006694C40  mov      x0, x27
006694C44  blr      x8
006694C48  adrp     x28, #0x8ee5000
006694C4C  ldr      x28, [x28, #0xb28]
006694C50  cbz      x0, #0x66958dc
006694C54  mov      w1, w19
006694C58  mov      x2, xzr
006694C5C  bl       #0x6524404 ; LocalModels.Model.Buff_buffModel$$GetElementById
006694C60  cbz      x0, #0x6694ca8
006694C64  mov      x1, x0
006694C68  ldr      x0, [sp, #0x28]
006694C6C  cbz      x0, #0x66958dc
006694C70  mov      x2, xzr
006694C74  bl       #0x6640158 ; HotFix.BattleLogic.BuffData$$SetTableData
006694C78  ldrb     w8, [x22, #0xa4b]
006694C7C  cbnz     w8, #0x6694c94
006694C80  adrp     x0, #0x8ee5000
006694C84  ldr      x0, [x0, #0xb28]
006694C88  bl       #0x382bd14 ; 
006694C8C  mov      w8, #1
006694C90  strb     w8, [x22, #0xa4b]
006694C94  ldr      x1, [x28]
006694C98  ldrb     w8, [x1, #0x53]
006694C9C  tbnz     w8, #5, #0x6694d14
006694CA0  ldr      x0, [x21, #0x20]
006694CA4  b        #0x6694d20 ; 
006694CA8  adrp     x8, #0x8ebf000
006694CAC  ldr      x8, [x8, #0xba0]
006694CB0  add      x1, sp, #0xc
006694CB4  str      w19, [sp, #0xc]
006694CB8  ldr      x0, [x8]
006694CBC  bl       #0x382be94 ; 
006694CC0  adrp     x8, #0x8f10000
006694CC4  ldr      x8, [x8, #0xbc8]
006694CC8  mov      x1, x0
006694CCC  mov      x2, xzr
006694CD0  ldr      x8, [x8]
006694CD4  mov      x0, x8
006694CD8  bl       #0x79d140c ; System.String$$Format
006694CDC  adrp     x8, #0x8ee1000
006694CE0  ldr      x8, [x8, #0x6e8]
006694CE4  mov      x19, x0
006694CE8  ldr      x8, [x8]
006694CEC  ldr      w9, [x8, #0xe0]
006694CF0  cbnz     w9, #0x6694cfc
006694CF4  mov      x0, x8
006694CF8  bl       #0x382be8c ; 
006694CFC  adrp     x8, #0x8f10000
006694D00  adrp     x9, #0x8f10000
006694D04  ldr      x8, [x8, #0xbe0]
006694D08  ldr      x9, [x9, #0xbd8]
006694D0C  mov      w3, #0xbd
006694D10  b        #0x6695194 ; 
006694D14  ldr      x8, [x1, #0x60]
006694D18  mov      x0, x21
006694D1C  blr      x8
006694D20  cbz      x0, #0x66958dc
006694D24  ldr      x0, [x0, #0x78]
006694D28  cbz      x0, #0x66958dc
006694D2C  adrp     x8, #0x8f10000
006694D30  ldr      x2, [sp, #0x28]
006694D34  ldr      x8, [x8, #0xb80]
006694D38  mov      w1, w19
006694D3C  ldr      x3, [x8]
006694D40  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
006694D44  ldr      x0, [sp, #0x28]
006694D48  cbz      x0, #0x66958dc
006694D4C  mov      x1, xzr
006694D50  bl       #0x663f284 ; HotFix.BattleLogic.BuffData$$get_BuffType
006694D54  adrp     x8, #0x8ee6000
006694D58  ldr      x8, [x8, #0x608]
006694D5C  mov      w27, w0
006694D60  ldr      x1, [x8]
006694D64  ldrb     w8, [x1, #0x53]
006694D68  tbnz     w8, #5, #0x6694d74
006694D6C  ldr      x0, [x21, #0x30]
006694D70  b        #0x6694d80 ; 
006694D74  ldr      x8, [x1, #0x60]
006694D78  mov      x0, x21
006694D7C  blr      x8
006694D80  cbz      x0, #0x66958dc
006694D84  mov      x1, xzr
006694D88  bl       #0x67f7da8 ; HotFix.BattleLogic.EntityCharacter$$get_IsInvincible
006694D8C  tbz      w0, #0, #0x6694d98
006694D90  cbnz     w27, #0x66951a8
006694D94  b        #0x6694e8c ; 
006694D98  cmp      w27, #1
006694D9C  b.ne     #0x6694e8c
006694DA0  tbnz     w26, #0, #0x6694e8c
006694DA4  adrp     x8, #0x8ee6000
006694DA8  ldr      x8, [x8, #0x608]
006694DAC  ldr      x1, [x8]
006694DB0  ldrb     w8, [x1, #0x53]
006694DB4  tbnz     w8, #5, #0x6694dc0
006694DB8  ldr      x0, [x21, #0x30]
006694DBC  b        #0x6694dcc ; 
006694DC0  ldr      x8, [x1, #0x60]
006694DC4  mov      x0, x21
006694DC8  blr      x8
006694DCC  cbz      x0, #0x66958dc
006694DD0  adrp     x8, #0x8ee6000
006694DD4  ldr      x8, [x8, #0xd8]
006694DD8  ldr      x1, [x8]
006694DDC  ldrb     w8, [x1, #0x53]
006694DE0  tbnz     w8, #5, #0x6694dec
006694DE4  ldr      x26, [x0, #0x38]
006694DE8  b        #0x6694df8 ; 
006694DEC  ldr      x8, [x1, #0x60]
006694DF0  blr      x8
006694DF4  mov      x26, x0
006694DF8  cbz      x26, #0x66958dc
006694DFC  adrp     x27, #0x9591000
006694E00  ldrb     w8, [x27, #0xa8f]
006694E04  cbnz     w8, #0x6694e1c
006694E08  adrp     x0, #0x8ee6000
006694E0C  ldr      x0, [x0, #0x3d8]
006694E10  bl       #0x382bd14 ; 
006694E14  mov      w8, #1
006694E18  strb     w8, [x27, #0xa8f]
006694E1C  adrp     x8, #0x8ee6000
006694E20  ldr      x8, [x8, #0x3d8]
006694E24  ldr      x2, [x8]
006694E28  ldrb     w8, [x2, #0x53]
006694E2C  tbnz     w8, #5, #0x6694e3c
006694E30  ldrb     w8, [x26, #0x220]
006694E34  tbz      w8, #4, #0x6694e50
006694E38  b        #0x66951a8 ; 
006694E3C  ldr      x8, [x2, #0x60]
006694E40  mov      w1, #4
006694E44  mov      x0, x26
006694E48  blr      x8
006694E4C  tbnz     w0, #0, #0x66951a8
006694E50  adrp     x8, #0x8ee6000
006694E54  ldr      x8, [x8, #0x608]
006694E58  ldr      x1, [x8]
006694E5C  ldrb     w8, [x1, #0x53]
006694E60  tbnz     w8, #5, #0x6694e6c
006694E64  ldr      x0, [x21, #0x30]
006694E68  b        #0x6694e78 ; 
006694E6C  ldr      x8, [x1, #0x60]
006694E70  mov      x0, x21
006694E74  blr      x8
006694E78  cbz      x0, #0x66958dc
006694E7C  mov      x1, xzr
006694E80  bl       #0x67f7674 ; HotFix.BattleLogic.EntityCharacter$$CanAndFrozen
006694E84  mov      x27, xzr
006694E88  tbz      w0, #0, #0x66958b8
006694E8C  ldr      x0, [sp, #0x28]
006694E90  cbz      x0, #0x66958dc
006694E94  ldr      x26, [x21, #0x50]
006694E98  mov      x1, xzr
006694E9C  bl       #0x66384a4 ; HotFix.BattleLogic.BuffData$$get_Id
006694EA0  cbz      x26, #0x66958dc
006694EA4  adrp     x8, #0x8f10000
006694EA8  ldr      x8, [x8, #0xbc0]
006694EAC  mov      w1, w0
006694EB0  add      x2, sp, #0x20
006694EB4  mov      x0, x26
006694EB8  ldr      x3, [x8]
006694EBC  bl       #0x5227918 ; Rock.Collections.OrderedDictionary<int, object>$$TryGetValue
006694EC0  str      w0, [sp, #8]
006694EC4  tbz      w0, #0, #0x6694f40
006694EC8  ldr      x0, [sp, #0x28]
006694ECC  cbz      x0, #0x66958dc
006694ED0  mov      x1, xzr
006694ED4  bl       #0x663ae1c ; HotFix.BattleLogic.BuffData$$get_StackingType
006694ED8  cmp      w0, #6
006694EDC  b.ne     #0x6694fec
006694EE0  ldr      x0, [sp, #0x28]
006694EE4  cbz      x0, #0x66958dc
006694EE8  mov      x1, xzr
006694EEC  bl       #0x663f0ac ; HotFix.BattleLogic.BuffData$$get_BuffFlag
006694EF0  cmp      w0, #3
006694EF4  b.ne     #0x6694f30
006694EF8  ldr      x0, [sp, #0x20]
006694EFC  cbz      x0, #0x66958dc
006694F00  mov      x1, xzr
006694F04  bl       #0x6636cbc ; HotFix.BattleLogic.BuffBase$$get_DuringTime
006694F08  ldr      x8, [sp, #0x20]
006694F0C  cbz      x8, #0x66958dc
006694F10  mov      x27, x0
006694F14  mov      x0, x8
006694F18  mov      x1, xzr
006694F1C  bl       #0x6636c50 ; HotFix.BattleLogic.BuffBase$$get_ClearTime
006694F20  sub      x8, x27, x0
006694F24  cmp      x8, #0x10, lsl #12
006694F28  mov      x27, xzr
006694F2C  b.lt     #0x66958b8
006694F30  ldr      x1, [sp, #0x20]
006694F34  mov      w2, #1
006694F38  mov      x0, x21
006694F3C  bl       #0x66940a0 ; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffInternal
006694F40  ldrb     w8, [x22, #0xa4b]
006694F44  cbnz     w8, #0x6694f5c
006694F48  adrp     x0, #0x8ee5000
006694F4C  ldr      x0, [x0, #0xb28]
006694F50  bl       #0x382bd14 ; 
006694F54  mov      w8, #1
006694F58  strb     w8, [x22, #0xa4b]
006694F5C  ldr      x1, [x28]
006694F60  ldrb     w8, [x1, #0x53]
006694F64  tbnz     w8, #5, #0x6694f70
006694F68  ldr      x0, [x21, #0x20]
006694F6C  b        #0x6694f7c ; 
006694F70  ldr      x8, [x1, #0x60]
006694F74  mov      x0, x21
006694F78  blr      x8
006694F7C  cbz      x0, #0x66958dc
006694F80  ldr      x8, [sp, #0x28]
006694F84  cbz      x8, #0x66958dc
006694F88  ldr      x27, [x0, #0x80]
006694F8C  mov      x0, x8
006694F90  mov      x1, xzr
006694F94  bl       #0x663f198 ; HotFix.BattleLogic.BuffData$$get_ClassId
006694F98  cbz      x27, #0x66958dc
006694F9C  adrp     x8, #0x8f10000
006694FA0  ldr      x8, [x8, #0xb90]
006694FA4  mov      w1, w0
006694FA8  add      x2, sp, #0x18
006694FAC  mov      x0, x27
006694FB0  ldr      x3, [x8]
006694FB4  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
006694FB8  tbnz     w0, #0, #0x6695298
006694FBC  ldrb     w8, [x22, #0xa4b]
006694FC0  cbnz     w8, #0x6694fd8
006694FC4  adrp     x0, #0x8ee5000
006694FC8  ldr      x0, [x0, #0xb28]
006694FCC  bl       #0x382bd14 ; 
006694FD0  mov      w8, #1
006694FD4  strb     w8, [x22, #0xa4b]
006694FD8  ldr      x1, [x28]
006694FDC  ldrb     w8, [x1, #0x53]
006694FE0  tbnz     w8, #5, #0x6695000
006694FE4  ldr      x27, [x21, #0x20]
006694FE8  b        #0x6695010 ; 
006694FEC  ldr      x0, [sp, #0x20]
006694FF0  cbz      x0, #0x66958dc
006694FF4  mov      x1, xzr
006694FF8  bl       #0x663a980 ; HotFix.BattleLogic.BuffBase$$TryAddLayer
006694FFC  b        #0x66951a8 ; 
006695000  ldr      x8, [x1, #0x60]
006695004  mov      x0, x21
006695008  blr      x8
00669500C  mov      x27, x0
006695010  cbz      x27, #0x66958dc
006695014  adrp     x26, #0x9598000
006695018  ldrb     w8, [x26, #0xfcc]
00669501C  cbnz     w8, #0x6695034
006695020  adrp     x0, #0x8f06000
006695024  ldr      x0, [x0, #0x470]
006695028  bl       #0x382bd14 ; 
00669502C  mov      w8, #1
006695030  strb     w8, [x26, #0xfcc]
006695034  adrp     x8, #0x8f06000
006695038  ldr      x8, [x8, #0x470]
00669503C  ldr      x1, [x8]
006695040  ldrb     w8, [x1, #0x53]
006695044  tbnz     w8, #5, #0x6695050
006695048  ldr      x27, [x27, #0x200]
00669504C  b        #0x6695060 ; 
006695050  ldr      x8, [x1, #0x60]
006695054  mov      x0, x27
006695058  blr      x8
00669505C  mov      x27, x0
006695060  cbz      x27, #0x66958dc
006695064  adrp     x26, #0x959a000
006695068  ldrb     w8, [x26, #0x103]
00669506C  cbnz     w8, #0x6695084
006695070  adrp     x0, #0x8efa000
006695074  ldr      x0, [x0, #0x560]
006695078  bl       #0x382bd14 ; 
00669507C  mov      w8, #1
006695080  strb     w8, [x26, #0x103]
006695084  adrp     x8, #0x8efa000
006695088  ldr      x8, [x8, #0x560]
00669508C  ldr      x1, [x8]
006695090  ldrb     w8, [x1, #0x53]
006695094  tbnz     w8, #5, #0x66950a0
006695098  ldr      x27, [x27, #0x58]
00669509C  b        #0x66950b0 ; 
0066950A0  ldr      x8, [x1, #0x60]
0066950A4  mov      x0, x27
0066950A8  blr      x8
0066950AC  mov      x27, x0
0066950B0  ldr      x0, [sp, #0x28]
0066950B4  cbz      x0, #0x66958dc
0066950B8  mov      x1, xzr
0066950BC  bl       #0x663f198 ; HotFix.BattleLogic.BuffData$$get_ClassId
0066950C0  cbz      x27, #0x66958dc
0066950C4  mov      w1, w0
0066950C8  mov      x0, x27
0066950CC  mov      x2, xzr
0066950D0  bl       #0x6524b3c ; LocalModels.Model.Buff_nameModel$$GetElementById
0066950D4  cbz      x0, #0x6695118
0066950D8  adrp     x26, #0x959a000
0066950DC  ldrb     w8, [x26, #0x104]
0066950E0  mov      x27, x0
0066950E4  cbnz     w8, #0x66950fc
0066950E8  adrp     x0, #0x8f10000
0066950EC  ldr      x0, [x0, #0xbe8]
0066950F0  bl       #0x382bd14 ; 
0066950F4  mov      w8, #1
0066950F8  strb     w8, [x26, #0x104]
0066950FC  adrp     x8, #0x8f10000
006695100  ldr      x8, [x8, #0xbe8]
006695104  ldr      x1, [x8]
006695108  ldrb     w8, [x1, #0x53]
00669510C  tbnz     w8, #5, #0x66951b0
006695110  ldr      x0, [x27, #0x30]
006695114  b        #0x66951bc ; 
006695118  ldr      x0, [sp, #0x28]
00669511C  cbz      x0, #0x66958dc
006695120  mov      x1, xzr
006695124  bl       #0x663f198 ; HotFix.BattleLogic.BuffData$$get_ClassId
006695128  adrp     x8, #0x8ebf000
00669512C  ldr      x8, [x8, #0xba0]
006695130  str      w0, [sp, #0xc]
006695134  add      x1, sp, #0xc
006695138  ldr      x8, [x8]
00669513C  mov      x0, x8
006695140  bl       #0x382be94 ; 
006695144  adrp     x8, #0x8f10000
006695148  ldr      x8, [x8, #0xbd0]
00669514C  mov      x1, x0
006695150  mov      x2, xzr
006695154  ldr      x8, [x8]
006695158  mov      x0, x8
00669515C  bl       #0x79d140c ; System.String$$Format
006695160  adrp     x8, #0x8ee1000
006695164  ldr      x8, [x8, #0x6e8]
006695168  mov      x19, x0
00669516C  ldr      x8, [x8]
006695170  ldr      w9, [x8, #0xe0]
006695174  cbnz     w9, #0x6695180
006695178  mov      x0, x8
00669517C  bl       #0x382be8c ; 
006695180  adrp     x8, #0x8f10000
006695184  adrp     x9, #0x8f10000
006695188  ldr      x8, [x8, #0xbe0]
00669518C  ldr      x9, [x9, #0xbd8]
006695190  mov      w3, #0xf3
006695194  ldr      x1, [x8]
006695198  ldr      x2, [x9]
00669519C  mov      x0, x19
0066951A0  mov      x4, xzr
0066951A4  bl       #0x7997754 ; Logger$$LogError
0066951A8  mov      x27, xzr
0066951AC  b        #0x66958b8 ; 
0066951B0  ldr      x8, [x1, #0x60]
0066951B4  mov      x0, x27
0066951B8  blr      x8
0066951BC  ldrb     w8, [x22, #0xa4b]
0066951C0  str      x0, [sp, #0x18]
0066951C4  cbnz     w8, #0x66951dc
0066951C8  adrp     x0, #0x8ee5000
0066951CC  ldr      x0, [x0, #0xb28]
0066951D0  bl       #0x382bd14 ; 
0066951D4  mov      w8, #1
0066951D8  strb     w8, [x22, #0xa4b]
0066951DC  ldr      x1, [x28]
0066951E0  ldrb     w8, [x1, #0x53]
0066951E4  tbnz     w8, #5, #0x66951f0
0066951E8  ldr      x0, [x21, #0x20]
0066951EC  b        #0x66951fc ; 
0066951F0  ldr      x8, [x1, #0x60]
0066951F4  mov      x0, x21
0066951F8  blr      x8
0066951FC  str      x20, [sp]
006695200  cbz      x0, #0x66958dc
006695204  ldr      x8, [sp, #0x28]
006695208  cbz      x8, #0x66958dc
00669520C  ldr      x28, [x0, #0x80]
006695210  mov      x0, x8
006695214  mov      x1, xzr
006695218  mov      w20, w29
00669521C  bl       #0x663f198 ; HotFix.BattleLogic.BuffData$$get_ClassId
006695220  ldrb     w8, [x26, #0x104]
006695224  mov      w29, w0
006695228  cbnz     w8, #0x6695240
00669522C  adrp     x0, #0x8f10000
006695230  ldr      x0, [x0, #0xbe8]
006695234  bl       #0x382bd14 ; 
006695238  mov      w8, #1
00669523C  strb     w8, [x26, #0x104]
006695240  adrp     x8, #0x8f10000
006695244  ldr      x8, [x8, #0xbe8]
006695248  ldr      x1, [x8]
00669524C  ldrb     w8, [x1, #0x53]
006695250  tbnz     w8, #5, #0x669525c
006695254  ldr      x2, [x27, #0x30]
006695258  b        #0x669526c ; 
00669525C  ldr      x8, [x1, #0x60]
006695260  mov      x0, x27
006695264  blr      x8
006695268  mov      x2, x0
00669526C  cbz      x28, #0x66958dc
006695270  adrp     x8, #0x8f10000
006695274  ldr      x8, [x8, #0xb78]
006695278  mov      x0, x28
00669527C  mov      w1, w29
006695280  ldr      x3, [x8]
006695284  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
006695288  adrp     x28, #0x8ee5000
00669528C  mov      w29, w20
006695290  ldr      x28, [x28, #0xb28]
006695294  ldr      x20, [sp]
006695298  ldrb     w8, [x22, #0xa4b]
00669529C  cbnz     w8, #0x66952b4
0066952A0  adrp     x0, #0x8ee5000
0066952A4  ldr      x0, [x0, #0xb28]
0066952A8  bl       #0x382bd14 ; 
0066952AC  mov      w8, #1
0066952B0  strb     w8, [x22, #0xa4b]
0066952B4  ldr      x1, [x28]
0066952B8  ldrb     w8, [x1, #0x53]
0066952BC  tbnz     w8, #5, #0x66952c8
0066952C0  ldr      x0, [x21, #0x20]
0066952C4  b        #0x66952d4 ; 
0066952C8  ldr      x8, [x1, #0x60]
0066952CC  mov      x0, x21
0066952D0  blr      x8
0066952D4  cbz      x0, #0x66958dc
0066952D8  ldr      x1, [sp, #0x18]
0066952DC  mov      x2, xzr
0066952E0  bl       #0x69fb22c ; HotFix.BattleLogic.BattleWorldContext$$GetHotFixType
0066952E4  ldrb     w8, [x22, #0xa4b]
0066952E8  mov      x27, x0
0066952EC  cbnz     w8, #0x6695304
0066952F0  adrp     x0, #0x8ee5000
0066952F4  ldr      x0, [x0, #0xb28]
0066952F8  bl       #0x382bd14 ; 
0066952FC  mov      w8, #1
006695300  strb     w8, [x22, #0xa4b]
006695304  ldr      x1, [x28]
006695308  ldrb     w8, [x1, #0x53]
00669530C  tbnz     w8, #5, #0x6695318
006695310  ldr      x28, [x21, #0x20]
006695314  b        #0x6695328 ; 
006695318  ldr      x8, [x1, #0x60]
00669531C  mov      x0, x21
006695320  blr      x8
006695324  mov      x28, x0
006695328  cbz      x28, #0x66958dc
00669532C  adrp     x26, #0x9591000
006695330  ldrb     w8, [x26, #0xa4c]
006695334  cbnz     w8, #0x669534c
006695338  adrp     x0, #0x8ee5000
00669533C  ldr      x0, [x0, #0xb30]
006695340  bl       #0x382bd14 ; 
006695344  mov      w8, #1
006695348  strb     w8, [x26, #0xa4c]
00669534C  adrp     x8, #0x8ee5000
006695350  ldr      x8, [x8, #0xb30]
006695354  ldr      x1, [x8]
006695358  ldrb     w8, [x1, #0x53]
00669535C  tbnz     w8, #5, #0x6695368
006695360  ldr      x0, [x28, #0x210]
006695364  b        #0x6695374 ; 
006695368  ldr      x8, [x1, #0x60]
00669536C  mov      x0, x28
006695370  blr      x8
006695374  adrp     x26, #0x8ee5000
006695378  ldr      x26, [x26, #0xb28]
00669537C  cbz      x0, #0x66958dc
006695380  mov      x1, x27
006695384  mov      x2, xzr
006695388  bl       #0x6a425e8 ; HotFix.BattleLogic.WorldElementCreator$$CreateByType
00669538C  mov      x27, x0
006695390  cbz      x0, #0x66953c8
006695394  adrp     x9, #0x8f10000
006695398  ldr      x9, [x9, #0xb68]
00669539C  ldr      x8, [x27]
0066953A0  ldr      x1, [x9]
0066953A4  ldrb     w10, [x8, #0x130]
0066953A8  ldrb     w9, [x1, #0x130]
0066953AC  cmp      w10, w9
0066953B0  b.lo     #0x66958e0
0066953B4  ldr      x8, [x8, #0xc8]
0066953B8  add      x8, x8, x9, lsl #3
0066953BC  ldur     x8, [x8, #-8]
0066953C0  cmp      x8, x1
0066953C4  b.ne     #0x66958e0
0066953C8  ldrb     w8, [x22, #0xa4b]
0066953CC  cbnz     w8, #0x66953e4
0066953D0  adrp     x0, #0x8ee5000
0066953D4  ldr      x0, [x0, #0xb28]
0066953D8  bl       #0x382bd14 ; 
0066953DC  mov      w8, #1
0066953E0  strb     w8, [x22, #0xa4b]
0066953E4  ldr      x1, [x26]
0066953E8  ldrb     w8, [x1, #0x53]
0066953EC  tbnz     w8, #5, #0x66953f8
0066953F0  ldr      x28, [x21, #0x20]
0066953F4  b        #0x6695408 ; 
0066953F8  ldr      x8, [x1, #0x60]
0066953FC  mov      x0, x21
006695400  blr      x8
006695404  mov      x28, x0
006695408  cbz      x27, #0x66958dc
00669540C  adrp     x26, #0x9591000
006695410  ldrb     w8, [x26, #0xb47]
006695414  cbnz     w8, #0x669542c
006695418  adrp     x0, #0x8ee7000
00669541C  ldr      x0, [x0, #0xe60]
006695420  bl       #0x382bd14 ; 
006695424  mov      w8, #1
006695428  strb     w8, [x26, #0xb47]
00669542C  adrp     x8, #0x8ee7000
006695430  ldr      x8, [x8, #0xe60]
006695434  ldr      x2, [x8]
006695438  ldrb     w8, [x2, #0x53]
00669543C  tbnz     w8, #5, #0x6695454
006695440  mov      x0, x27
006695444  str      x28, [x0, #0x20]!
006695448  mov      x1, x28
00669544C  bl       #0x382bcb8 ; 
006695450  b        #0x6695464 ; 
006695454  ldr      x8, [x2, #0x60]
006695458  mov      x0, x27
00669545C  mov      x1, x28
006695460  blr      x8
006695464  adrp     x8, #0x8ee6000
006695468  ldr      x8, [x8, #0x608]
00669546C  ldr      x1, [x8]
006695470  ldrb     w8, [x1, #0x53]
006695474  tbnz     w8, #5, #0x6695480
006695478  ldr      x28, [x21, #0x30]
00669547C  b        #0x6695490 ; 
006695480  ldr      x8, [x1, #0x60]
006695484  mov      x0, x21
006695488  blr      x8
00669548C  mov      x28, x0
006695490  adrp     x26, #0x959a000
006695494  ldrb     w8, [x26, #0x105]
006695498  cbnz     w8, #0x66954b0
00669549C  adrp     x0, #0x8f0d000
0066954A0  ldr      x0, [x0, #0x120]
0066954A4  bl       #0x382bd14 ; 
0066954A8  mov      w8, #1
0066954AC  strb     w8, [x26, #0x105]
0066954B0  adrp     x8, #0x8f0d000
0066954B4  ldr      x8, [x8, #0x120]
0066954B8  ldr      x2, [x8]
0066954BC  ldrb     w8, [x2, #0x53]
0066954C0  tbnz     w8, #5, #0x66954d8
0066954C4  mov      x0, x27
0066954C8  str      x28, [x0, #0x50]!
0066954CC  mov      x1, x28
0066954D0  bl       #0x382bcb8 ; 
0066954D4  b        #0x66954e8 ; 
0066954D8  ldr      x8, [x2, #0x60]
0066954DC  mov      x0, x27
0066954E0  mov      x1, x28
0066954E4  blr      x8
0066954E8  adrp     x26, #0x8ee5000
0066954EC  ldrb     w8, [x22, #0xa4b]
0066954F0  ldr      x26, [x26, #0xb28]
0066954F4  cbnz     w8, #0x669550c
0066954F8  adrp     x0, #0x8ee5000
0066954FC  ldr      x0, [x0, #0xb28]
006695500  bl       #0x382bd14 ; 
006695504  mov      w8, #1
006695508  strb     w8, [x22, #0xa4b]
00669550C  ldr      x1, [x26]
006695510  ldrb     w8, [x1, #0x53]
006695514  tbnz     w8, #5, #0x6695520
006695518  ldr      x28, [x21, #0x20]
00669551C  b        #0x6695530 ; 
006695520  ldr      x8, [x1, #0x60]
006695524  mov      x0, x21
006695528  blr      x8
00669552C  mov      x28, x0
006695530  cbz      x28, #0x66958dc
006695534  adrp     x22, #0x9591000
006695538  ldrb     w8, [x22, #0xa62]
00669553C  cbnz     w8, #0x6695554
006695540  adrp     x0, #0x8ee6000
006695544  ldr      x0, [x0, #0x1f8]
006695548  bl       #0x382bd14 ; 
00669554C  mov      w8, #1
006695550  strb     w8, [x22, #0xa62]
006695554  adrp     x8, #0x8ee6000
006695558  ldr      x8, [x8, #0x1f8]
00669555C  ldr      x1, [x8]
006695560  ldrb     w8, [x1, #0x53]
006695564  tbnz     w8, #5, #0x6695570
006695568  ldr      x0, [x28, #0x1f8]
00669556C  b        #0x669557c ; 
006695570  ldr      x8, [x1, #0x60]
006695574  mov      x0, x28
006695578  blr      x8
00669557C  cbz      x0, #0x66958dc
006695580  adrp     x8, #0x8ee6000
006695584  ldr      x8, [x8, #0x108]
006695588  mov      x1, x20
00669558C  ldr      x2, [x8]
006695590  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
006695594  cbz      x0, #0x66955a8
006695598  mov      x1, xzr
00669559C  mov      x28, x0
0066955A0  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0066955A4  tbz      w0, #0, #0x66955c4
0066955A8  mov      x0, x27
0066955AC  mov      x1, x25
0066955B0  mov      x2, x24
0066955B4  mov      x3, x20
0066955B8  mov      x4, xzr
0066955BC  bl       #0x6636d28 ; HotFix.BattleLogic.BuffBase$$SetAttacker
0066955C0  b        #0x66955ec ; 
0066955C4  mov      w3, #1
0066955C8  mov      x0, x28
0066955CC  mov      x1, x20
0066955D0  mov      x2, x20
0066955D4  mov      x4, xzr
0066955D8  bl       #0x68dcd98 ; HotFix.BattleLogic.AttackerSnapshot$$CreateFromEntity
0066955DC  mov      x1, x0
0066955E0  mov      x0, x27
0066955E4  mov      x2, xzr
0066955E8  bl       #0x6636dd0 ; HotFix.BattleLogic.BuffBase$$SetAttackerSnapshot
0066955EC  adrp     x22, #0x959a000
0066955F0  ldrb     w8, [x22, #0x106]
0066955F4  cbnz     w8, #0x669560c
0066955F8  adrp     x0, #0x8f0d000
0066955FC  ldr      x0, [x0, #0x168]
006695600  bl       #0x382bd14 ; 
006695604  mov      w8, #1
006695608  strb     w8, [x22, #0x106]
00669560C  adrp     x8, #0x8f0d000
006695610  ldr      x8, [x8, #0x168]
006695614  ldr      x2, [x8]
006695618  ldrb     w8, [x2, #0x53]
00669561C  tbnz     w8, #5, #0x6695628
006695620  str      w23, [x27, #0x60]
006695624  b        #0x6695638 ; 
006695628  ldr      x8, [x2, #0x60]
00669562C  mov      x0, x27
006695630  mov      w1, w23
006695634  blr      x8
006695638  adrp     x22, #0x959a000
00669563C  ldrb     w8, [x22, #0x107]
006695640  ldr      x23, [sp, #0x28]
006695644  cbnz     w8, #0x669565c
006695648  adrp     x0, #0x8f0d000
00669564C  ldr      x0, [x0, #0x170]
006695650  bl       #0x382bd14 ; 
006695654  mov      w8, #1
006695658  strb     w8, [x22, #0x107]
00669565C  adrp     x8, #0x8f0d000
006695660  ldr      x8, [x8, #0x170]
006695664  ldr      x2, [x8]
006695668  ldrb     w8, [x2, #0x53]
00669566C  tbnz     w8, #5, #0x6695684
006695670  mov      x0, x27
006695674  str      x23, [x0, #0x48]!
006695678  mov      x1, x23
00669567C  bl       #0x382bcb8 ; 
006695680  b        #0x6695694 ; 
006695684  ldr      x8, [x2, #0x60]
006695688  mov      x0, x27
00669568C  mov      x1, x23
006695690  blr      x8
006695694  ldr      x0, [x27, #0x48]
006695698  cbz      x0, #0x66958dc
00669569C  ldr      x23, [x21, #0x50]
0066956A0  mov      x1, xzr
0066956A4  bl       #0x66384a4 ; HotFix.BattleLogic.BuffData$$get_Id
0066956A8  cbz      x23, #0x66958dc
0066956AC  adrp     x8, #0x8f10000
0066956B0  ldr      x8, [x8, #0xbb8]
0066956B4  mov      w1, w0
0066956B8  mov      x0, x23
0066956BC  mov      x2, x27
0066956C0  ldr      x3, [x8]
0066956C4  bl       #0x5225b08 ; Rock.Collections.OrderedDictionary<int, object>$$Add
0066956C8  ldr      x0, [sp, #0x28]
0066956CC  cbz      x0, #0x66958dc
0066956D0  mov      x1, xzr
0066956D4  bl       #0x663f0ac ; HotFix.BattleLogic.BuffData$$get_BuffFlag
0066956D8  mov      w1, w0
0066956DC  mov      x0, x21
0066956E0  bl       #0x6694828 ; HotFix.BattleLogic.CharacterComponentBuff$$AddBuffFlag
0066956E4  mov      x0, x27
0066956E8  mov      x1, xzr
0066956EC  bl       #0x6637164 ; HotFix.BattleLogic.BuffBase$$Init
0066956F0  ldr      w8, [sp, #8]
0066956F4  mov      x0, x27
0066956F8  mov      x2, xzr
0066956FC  and      w1, w8, #1
006695700  bl       #0x6637cd0 ; HotFix.BattleLogic.BuffBase$$CheckShow
006695704  ldr      x0, [sp, #0x28]
006695708  cbz      x0, #0x66958dc
00669570C  mov      x1, xzr
006695710  bl       #0x663f198 ; HotFix.BattleLogic.BuffData$$get_ClassId
006695714  cmp      w0, #8
006695718  b.ne     #0x6695728
00669571C  mov      x0, x21
006695720  mov      x1, x27
006695724  bl       #0x66958e8 ; HotFix.BattleLogic.CharacterComponentBuff$$AddShield
006695728  ldr      x0, [sp, #0x28]
00669572C  cbz      x0, #0x66958dc
006695730  ldr      x23, [x21, #0x60]
006695734  mov      x1, xzr
006695738  bl       #0x663f284 ; HotFix.BattleLogic.BuffData$$get_BuffType
00669573C  cbz      x23, #0x66958dc
006695740  adrp     x8, #0x8f10000
006695744  ldr      x8, [x8, #0xad8]
006695748  mov      w1, w0
00669574C  add      x2, sp, #0x10
006695750  mov      x0, x23
006695754  ldr      x3, [x8]
006695758  bl       #0x5e9b3f0 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$TryGetValue
00669575C  tbz      w0, #0, #0x66957b8
006695760  ldr      x0, [sp, #0x10]
006695764  cbz      x0, #0x66958dc
006695768  adrp     x9, #0x8f10000
00669576C  ldr      x9, [x9, #0xba0]
006695770  ldr      w10, [x0, #0x1c]
006695774  ldr      x8, [x0, #0x10]
006695778  ldr      x9, [x9]
00669577C  add      w10, w10, #1
006695780  str      w10, [x0, #0x1c]
006695784  cbz      x8, #0x66958dc
006695788  ldrsw    x10, [x0, #0x18]
00669578C  ldr      w11, [x8, #0x18]
006695790  cmp      w10, w11
006695794  b.hs     #0x669582c
006695798  add      w9, w10, #1
00669579C  add      x8, x8, x10, lsl #3
0066957A0  str      w9, [x0, #0x18]
0066957A4  str      x27, [x8, #0x20]!
0066957A8  mov      x0, x8
0066957AC  mov      x1, x27
0066957B0  bl       #0x382bcb8 ; 
0066957B4  b        #0x6695860 ; 
0066957B8  adrp     x8, #0x8f10000
0066957BC  ldr      x8, [x8, #0xbb0]
0066957C0  ldr      x0, [x8]
0066957C4  bl       #0x382bfa0 ; 
0066957C8  adrp     x8, #0x8f10000
0066957CC  ldr      x8, [x8, #0xba8]
0066957D0  mov      x23, x0
0066957D4  ldr      x1, [x8]
0066957D8  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0066957DC  cbz      x23, #0x66958dc
0066957E0  adrp     x9, #0x8f10000
0066957E4  ldr      x9, [x9, #0xba0]
0066957E8  ldr      w10, [x23, #0x1c]
0066957EC  ldr      x8, [x23, #0x10]
0066957F0  ldr      x9, [x9]
0066957F4  add      w10, w10, #1
0066957F8  str      w10, [x23, #0x1c]
0066957FC  cbz      x8, #0x66958dc
006695800  ldrsw    x10, [x23, #0x18]
006695804  ldr      w11, [x8, #0x18]
006695808  cmp      w10, w11
00669580C  b.hs     #0x6695844
006695810  add      w9, w10, #1
006695814  add      x0, x8, x10, lsl #3
006695818  str      w9, [x23, #0x18]
00669581C  str      x27, [x0, #0x20]!
006695820  mov      x1, x27
006695824  bl       #0x382bcb8 ; 
006695828  b        #0x669585c ; 
00669582C  ldr      x8, [x9, #0x20]
006695830  mov      x1, x27
006695834  ldr      x8, [x8, #0xc0]
006695838  ldr      x2, [x8, #0x70]
00669583C  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
006695840  b        #0x6695860 ; 
006695844  ldr      x8, [x9, #0x20]
006695848  mov      x0, x23
00669584C  mov      x1, x27
006695850  ldr      x8, [x8, #0xc0]
006695854  ldr      x2, [x8, #0x70]
006695858  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
00669585C  str      x23, [sp, #0x10]
006695860  ldr      x0, [sp, #0x28]
006695864  cbz      x0, #0x66958dc
006695868  ldr      x23, [x21, #0x60]
00669586C  mov      x1, xzr
006695870  bl       #0x663f284 ; HotFix.BattleLogic.BuffData$$get_BuffType
006695874  cbz      x23, #0x66958dc
006695878  adrp     x8, #0x8f10000
00669587C  ldr      x2, [sp, #0x10]
006695880  ldr      x8, [x8, #0xb98]
006695884  mov      w1, w0
006695888  mov      x0, x23
00669588C  ldr      x3, [x8]
006695890  bl       #0x5e9994c ; System.Collections.Generic.Dictionary<Int32Enum, object>$$set_Item
006695894  ldrb     w8, [x21, #0x48]
006695898  bic      w8, w29, w8
00669589C  tbz      w8, #0, #0x66958a8
0066958A0  mov      w8, #1
0066958A4  strb     w8, [x21, #0x48]
0066958A8  mov      x0, x21
0066958AC  mov      x1, x20
0066958B0  mov      w2, w19
0066958B4  bl       #0x6695b54 ; HotFix.BattleLogic.CharacterComponentBuff$$CheckTriggerAddBuff
0066958B8  mov      x0, x27
0066958BC  ldp      x20, x19, [sp, #0x80]
0066958C0  ldp      x22, x21, [sp, #0x70]
0066958C4  ldp      x24, x23, [sp, #0x60]
0066958C8  ldp      x26, x25, [sp, #0x50]
0066958CC  ldp      x28, x27, [sp, #0x40]
0066958D0  ldp      x29, x30, [sp, #0x30]
0066958D4  add      sp, sp, #0x90
0066958D8  ret      
0066958DC  bl       #0x382bfb8 ; 
0066958E0  mov      x0, x27
0066958E4  bl       #0x382c354 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$CheckTriggerAddBuff
; RVA 0x6695B54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006695B54  str      x30, [sp, #-0x40]!
006695B58  stp      x24, x23, [sp, #0x10]
006695B5C  stp      x22, x21, [sp, #0x20]
006695B60  stp      x20, x19, [sp, #0x30]
006695B64  adrp     x21, #0x959a000
006695B68  adrp     x23, #0x8f10000
006695B6C  ldrb     w8, [x21, #0x5f]
006695B70  ldr      x23, [x23, #0xc00]
006695B74  mov      w19, w2
006695B78  mov      x22, x1
006695B7C  mov      x20, x0
006695B80  tbnz     w8, #0, #0x6695bbc
006695B84  adrp     x0, #0x8f10000
006695B88  ldr      x0, [x0, #0xc00]
006695B8C  bl       #0x382bd14 ; 
006695B90  adrp     x0, #0x8ee6000
006695B94  ldr      x0, [x0, #0xe8]
006695B98  bl       #0x382bd14 ; 
006695B9C  adrp     x0, #0x8ee6000
006695BA0  ldr      x0, [x0, #0x608]
006695BA4  bl       #0x382bd14 ; 
006695BA8  adrp     x0, #0x8f10000
006695BAC  ldr      x0, [x0, #0xc08]
006695BB0  bl       #0x382bd14 ; 
006695BB4  mov      w8, #1
006695BB8  strb     w8, [x21, #0x5f]
006695BBC  ldr      x3, [x23]
006695BC0  ldrb     w8, [x3, #0x53]
006695BC4  tbnz     w8, #5, #0x6695c04
006695BC8  adrp     x21, #0x9591000
006695BCC  ldrb     w8, [x21, #0xa4b]
006695BD0  cbnz     w8, #0x6695be8
006695BD4  adrp     x0, #0x8ee5000
006695BD8  ldr      x0, [x0, #0xb28]
006695BDC  bl       #0x382bd14 ; 
006695BE0  mov      w8, #1
006695BE4  strb     w8, [x21, #0xa4b]
006695BE8  adrp     x8, #0x8ee5000
006695BEC  ldr      x8, [x8, #0xb28]
006695BF0  ldr      x1, [x8]
006695BF4  ldrb     w8, [x1, #0x53]
006695BF8  tbnz     w8, #5, #0x6695c28
006695BFC  ldr      x21, [x20, #0x20]
006695C00  b        #0x6695c38 ; 
006695C04  ldr      x4, [x3, #0x60]
006695C08  mov      x0, x20
006695C0C  mov      x1, x22
006695C10  mov      w2, w19
006695C14  ldp      x20, x19, [sp, #0x30]
006695C18  ldp      x22, x21, [sp, #0x20]
006695C1C  ldp      x24, x23, [sp, #0x10]
006695C20  ldr      x30, [sp], #0x40
006695C24  br       x4
006695C28  ldr      x8, [x1, #0x60]
006695C2C  mov      x0, x20
006695C30  blr      x8
006695C34  mov      x21, x0
006695C38  cbz      x21, #0x6695e80
006695C3C  adrp     x23, #0x9591000
006695C40  ldrb     w8, [x23, #0xa4c]
006695C44  cbnz     w8, #0x6695c5c
006695C48  adrp     x0, #0x8ee5000
006695C4C  ldr      x0, [x0, #0xb30]
006695C50  bl       #0x382bd14 ; 
006695C54  mov      w8, #1
006695C58  strb     w8, [x23, #0xa4c]
006695C5C  adrp     x8, #0x8ee5000
006695C60  ldr      x8, [x8, #0xb30]
006695C64  ldr      x1, [x8]
006695C68  ldrb     w8, [x1, #0x53]
006695C6C  tbnz     w8, #5, #0x6695c78
006695C70  ldr      x0, [x21, #0x210]
006695C74  b        #0x6695c84 ; 
006695C78  ldr      x8, [x1, #0x60]
006695C7C  mov      x0, x21
006695C80  blr      x8
006695C84  cbz      x0, #0x6695e80
006695C88  adrp     x8, #0x8f10000
006695C8C  ldr      x8, [x8, #0xc08]
006695C90  ldr      x1, [x8]
006695C94  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
006695C98  cbz      x0, #0x6695e80
006695C9C  str      w19, [x0, #0x50]
006695CA0  str      x22, [x0, #0x38]
006695CA4  adrp     x23, #0x8ee6000
006695CA8  ldr      x23, [x23, #0x608]
006695CAC  mov      x21, x0
006695CB0  ldr      x1, [x23]
006695CB4  ldrb     w8, [x1, #0x53]
006695CB8  tbnz     w8, #5, #0x6695cc4
006695CBC  ldr      x0, [x20, #0x30]
006695CC0  b        #0x6695cd0 ; 
006695CC4  ldr      x8, [x1, #0x60]
006695CC8  mov      x0, x20
006695CCC  blr      x8
006695CD0  cbz      x0, #0x6695e80
006695CD4  adrp     x8, #0x8ee6000
006695CD8  ldr      x8, [x8, #0xe8]
006695CDC  ldr      x1, [x8]
006695CE0  ldrb     w8, [x1, #0x53]
006695CE4  tbnz     w8, #5, #0x6695cf0
006695CE8  ldr      x0, [x0, #0x28]
006695CEC  b        #0x6695cf8 ; 
006695CF0  ldr      x8, [x1, #0x60]
006695CF4  blr      x8
006695CF8  str      x0, [x21, #0x48]
006695CFC  ldr      x1, [x23]
006695D00  ldrb     w8, [x1, #0x53]
006695D04  tbnz     w8, #5, #0x6695d14
006695D08  ldr      x22, [x20, #0x30]
006695D0C  cbnz     x22, #0x6695d28
006695D10  b        #0x6695ddc ; 
006695D14  ldr      x8, [x1, #0x60]
006695D18  mov      x0, x20
006695D1C  blr      x8
006695D20  mov      x22, x0
006695D24  cbz      x22, #0x6695ddc
006695D28  adrp     x24, #0x9591000
006695D2C  ldrb     w8, [x24, #0xa86]
006695D30  cbnz     w8, #0x6695d54
006695D34  adrp     x0, #0x8ee6000
006695D38  ldr      x0, [x0, #0x318]
006695D3C  bl       #0x382bd14 ; 
006695D40  adrp     x0, #0x8ee3000
006695D44  ldr      x0, [x0, #0xf18]
006695D48  bl       #0x382bd14 ; 
006695D4C  mov      w8, #1
006695D50  strb     w8, [x24, #0xa86]
006695D54  adrp     x8, #0x8ee6000
006695D58  ldr      x8, [x8, #0x318]
006695D5C  ldr      x2, [x8]
006695D60  ldrb     w8, [x2, #0x53]
006695D64  tbnz     w8, #5, #0x6695d8c
006695D68  ldr      x0, [x22, #0x190]
006695D6C  cbz      x0, #0x6695ddc
006695D70  adrp     x8, #0x8ee3000
006695D74  ldr      x8, [x8, #0xf18]
006695D78  mov      w1, #0x36
006695D7C  ldr      x2, [x8]
006695D80  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
006695D84  tbnz     w0, #0, #0x6695da0
006695D88  b        #0x6695ddc ; 
006695D8C  ldr      x8, [x2, #0x60]
006695D90  mov      w1, #0x36
006695D94  mov      x0, x22
006695D98  blr      x8
006695D9C  tbz      w0, #0, #0x6695ddc
006695DA0  ldr      x1, [x23]
006695DA4  ldrb     w8, [x1, #0x53]
006695DA8  tbnz     w8, #5, #0x6695db8
006695DAC  ldr      x0, [x20, #0x30]
006695DB0  cbnz     x0, #0x6695dc8
006695DB4  b        #0x6695ddc ; 
006695DB8  ldr      x8, [x1, #0x60]
006695DBC  mov      x0, x20
006695DC0  blr      x8
006695DC4  cbz      x0, #0x6695ddc
006695DC8  ldr      x0, [x0, #0x150]
006695DCC  cbz      x0, #0x6695ddc
006695DD0  mov      x1, x21
006695DD4  mov      x2, xzr
006695DD8  bl       #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
006695DDC  ldr      x1, [x23]
006695DE0  ldrb     w8, [x1, #0x53]
006695DE4  tbnz     w8, #5, #0x6695df4
006695DE8  ldr      x0, [x20, #0x30]
006695DEC  cbnz     x0, #0x6695e04
006695DF0  b        #0x6695e18 ; 
006695DF4  ldr      x8, [x1, #0x60]
006695DF8  mov      x0, x20
006695DFC  blr      x8
006695E00  cbz      x0, #0x6695e18
006695E04  ldr      x0, [x0, #0x158]
006695E08  cbz      x0, #0x6695e18
006695E0C  mov      x1, x21
006695E10  mov      x2, xzr
006695E14  bl       #0x66c5c74 ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroAddBuff
006695E18  ldr      x1, [x23]
006695E1C  ldrb     w8, [x1, #0x53]
006695E20  tbnz     w8, #5, #0x6695e30
006695E24  ldr      x0, [x20, #0x30]
006695E28  cbnz     x0, #0x6695e40
006695E2C  b        #0x6695e6c ; 
006695E30  ldr      x8, [x1, #0x60]
006695E34  mov      x0, x20
006695E38  blr      x8
006695E3C  cbz      x0, #0x6695e6c
006695E40  ldr      x8, [x0, #0xc0]
006695E44  cbz      x8, #0x6695e6c
006695E48  ldr      x3, [x8, #0x18]
006695E4C  ldr      x0, [x8, #0x40]
006695E50  ldr      x2, [x8, #0x28]
006695E54  mov      w1, w19
006695E58  ldp      x20, x19, [sp, #0x30]
006695E5C  ldp      x22, x21, [sp, #0x20]
006695E60  ldp      x24, x23, [sp, #0x10]
006695E64  ldr      x30, [sp], #0x40
006695E68  br       x3
006695E6C  ldp      x20, x19, [sp, #0x30]
006695E70  ldp      x22, x21, [sp, #0x20]
006695E74  ldp      x24, x23, [sp, #0x10]
006695E78  ldr      x30, [sp], #0x40
006695E7C  ret      
006695E80  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$AddShield
; RVA 0x66958E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066958E8  stp      x30, x25, [sp, #-0x40]!
0066958EC  stp      x24, x23, [sp, #0x10]
0066958F0  stp      x22, x21, [sp, #0x20]
0066958F4  stp      x20, x19, [sp, #0x30]
0066958F8  adrp     x21, #0x959a000
0066958FC  adrp     x22, #0x8f10000
006695900  ldrb     w8, [x21, #0x60]
006695904  ldr      x22, [x22, #0xbf0]
006695908  mov      x19, x1
00669590C  mov      x20, x0
006695910  tbnz     w8, #0, #0x6695964
006695914  adrp     x0, #0x8f10000
006695918  ldr      x0, [x0, #0xb20]
00669591C  bl       #0x382bd14 ; 
006695920  adrp     x0, #0x8f10000
006695924  ldr      x0, [x0, #0xbf0]
006695928  bl       #0x382bd14 ; 
00669592C  adrp     x0, #0x8f10000
006695930  ldr      x0, [x0, #0xba0]
006695934  bl       #0x382bd14 ; 
006695938  adrp     x0, #0x8f10000
00669593C  ldr      x0, [x0, #0xbf8]
006695940  bl       #0x382bd14 ; 
006695944  adrp     x0, #0x8f10000
006695948  ldr      x0, [x0, #0xa98]
00669594C  bl       #0x382bd14 ; 
006695950  adrp     x0, #0x8f10000
006695954  ldr      x0, [x0, #0xaa0]
006695958  bl       #0x382bd14 ; 
00669595C  mov      w8, #1
006695960  strb     w8, [x21, #0x60]
006695964  ldr      x2, [x22]
006695968  ldrb     w8, [x2, #0x53]
00669596C  tbnz     w8, #5, #0x6695a78
006695970  ldr      x0, [x20, #0x58]
006695974  cbz      x0, #0x6695b48
006695978  ldr      w23, [x0, #0x18]
00669597C  cbz      w23, #0x6695a98
006695980  cbz      x19, #0x6695b48
006695984  adrp     x24, #0x8f10000
006695988  ldr      x24, [x24, #0xb20]
00669598C  ldr      x8, [x19]
006695990  ldr      x1, [x24]
006695994  ldrb     w10, [x8, #0x130]
006695998  ldrb     w9, [x1, #0x130]
00669599C  cmp      w10, w9
0066959A0  b.lo     #0x6695b4c
0066959A4  ldr      x8, [x8, #0xc8]
0066959A8  add      x8, x8, x9, lsl #3
0066959AC  ldur     x8, [x8, #-8]
0066959B0  cmp      x8, x1
0066959B4  b.ne     #0x6695b4c
0066959B8  mov      x0, x19
0066959BC  mov      x1, xzr
0066959C0  bl       #0x6646218 ; HotFix.BattleLogic.Buff_Shield$$get_Priority
0066959C4  cmp      w23, #1
0066959C8  b.lt     #0x6695a3c
0066959CC  adrp     x25, #0x8f10000
0066959D0  ldr      x25, [x25, #0xaa0]
0066959D4  mov      w22, w0
0066959D8  mov      w21, wzr
0066959DC  ldr      x0, [x20, #0x58]
0066959E0  cbz      x0, #0x6695b48
0066959E4  ldr      x2, [x25]
0066959E8  mov      w1, w21
0066959EC  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0066959F0  cbz      x0, #0x6695b48
0066959F4  ldr      x8, [x0]
0066959F8  ldr      x1, [x24]
0066959FC  ldrb     w10, [x8, #0x130]
006695A00  ldrb     w9, [x1, #0x130]
006695A04  cmp      w10, w9
006695A08  b.lo     #0x6695b50
006695A0C  ldr      x8, [x8, #0xc8]
006695A10  add      x8, x8, x9, lsl #3
006695A14  ldur     x8, [x8, #-8]
006695A18  cmp      x8, x1
006695A1C  b.ne     #0x6695b50
006695A20  mov      x1, xzr
006695A24  bl       #0x6646218 ; HotFix.BattleLogic.Buff_Shield$$get_Priority
006695A28  cmp      w0, w22
006695A2C  b.gt     #0x6695a40
006695A30  add      w21, w21, #1
006695A34  cmp      w23, w21
006695A38  b.ne     #0x66959dc
006695A3C  mov      w21, #-1
006695A40  ldr      x0, [x20, #0x58]
006695A44  cbz      x0, #0x6695b48
006695A48  cmp      w21, #1
006695A4C  b.lt     #0x6695ac8
006695A50  adrp     x8, #0x8f10000
006695A54  ldr      x8, [x8, #0xbf8]
006695A58  mov      w1, w21
006695A5C  mov      x2, x19
006695A60  ldp      x20, x19, [sp, #0x30]
006695A64  ldr      x3, [x8]
006695A68  ldp      x22, x21, [sp, #0x20]
006695A6C  ldp      x24, x23, [sp, #0x10]
006695A70  ldp      x30, x25, [sp], #0x40
006695A74  b        #0x4db0dfc ; System.Collections.Generic.List<object>$$Insert
006695A78  ldr      x3, [x2, #0x60]
006695A7C  mov      x0, x20
006695A80  mov      x1, x19
006695A84  ldp      x20, x19, [sp, #0x30]
006695A88  ldp      x22, x21, [sp, #0x20]
006695A8C  ldp      x24, x23, [sp, #0x10]
006695A90  ldp      x30, x25, [sp], #0x40
006695A94  br       x3
006695A98  adrp     x9, #0x8f10000
006695A9C  ldr      x9, [x9, #0xba0]
006695AA0  ldr      w10, [x0, #0x1c]
006695AA4  ldr      x8, [x0, #0x10]
006695AA8  ldr      x9, [x9]
006695AAC  add      w10, w10, #1
006695AB0  str      w10, [x0, #0x1c]
006695AB4  cbz      x8, #0x6695b48
006695AB8  ldr      w10, [x8, #0x18]
006695ABC  cbz      w10, #0x6695b24
006695AC0  mov      w9, #1
006695AC4  b        #0x6695b00 ; 
006695AC8  adrp     x9, #0x8f10000
006695ACC  ldr      x9, [x9, #0xba0]
006695AD0  ldr      w10, [x0, #0x1c]
006695AD4  ldr      x8, [x0, #0x10]
006695AD8  ldr      x9, [x9]
006695ADC  add      w10, w10, #1
006695AE0  str      w10, [x0, #0x1c]
006695AE4  cbz      x8, #0x6695b48
006695AE8  ldrsw    x10, [x0, #0x18]
006695AEC  ldr      w11, [x8, #0x18]
006695AF0  cmp      w10, w11
006695AF4  b.hs     #0x6695b24
006695AF8  add      w9, w10, #1
006695AFC  add      x8, x8, x10, lsl #3
006695B00  str      w9, [x0, #0x18]
006695B04  str      x19, [x8, #0x20]!
006695B08  mov      x1, x19
006695B0C  ldp      x20, x19, [sp, #0x30]
006695B10  ldp      x22, x21, [sp, #0x20]
006695B14  ldp      x24, x23, [sp, #0x10]
006695B18  mov      x0, x8
006695B1C  ldp      x30, x25, [sp], #0x40
006695B20  b        #0x382bcb8 ; 
006695B24  ldr      x8, [x9, #0x20]
006695B28  mov      x1, x19
006695B2C  ldp      x20, x19, [sp, #0x30]
006695B30  ldp      x22, x21, [sp, #0x20]
006695B34  ldr      x8, [x8, #0xc0]
006695B38  ldp      x24, x23, [sp, #0x10]
006695B3C  ldr      x2, [x8, #0x70]
006695B40  ldp      x30, x25, [sp], #0x40
006695B44  b        #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
006695B48  bl       #0x382bfb8 ; 
006695B4C  mov      x0, x19
006695B50  bl       #0x382c354 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$ClearBuffsByType
; RVA 0x6695E84; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006695E84  str      x30, [sp, #-0x30]!
006695E88  stp      x22, x21, [sp, #0x10]
006695E8C  stp      x20, x19, [sp, #0x20]
006695E90  adrp     x21, #0x959a000
006695E94  adrp     x22, #0x8f10000
006695E98  ldrb     w8, [x21, #0x61]
006695E9C  ldr      x22, [x22, #0xc10]
006695EA0  mov      w20, w1
006695EA4  mov      x19, x0
006695EA8  tbnz     w8, #0, #0x6695ef0
006695EAC  adrp     x0, #0x8f10000
006695EB0  ldr      x0, [x0, #0xc10]
006695EB4  bl       #0x382bd14 ; 
006695EB8  adrp     x0, #0x8f10000
006695EBC  ldr      x0, [x0, #0xad8]
006695EC0  bl       #0x382bd14 ; 
006695EC4  adrp     x0, #0x8f10000
006695EC8  ldr      x0, [x0, #0xa90]
006695ECC  bl       #0x382bd14 ; 
006695ED0  adrp     x0, #0x8f10000
006695ED4  ldr      x0, [x0, #0xba8]
006695ED8  bl       #0x382bd14 ; 
006695EDC  adrp     x0, #0x8f10000
006695EE0  ldr      x0, [x0, #0xbb0]
006695EE4  bl       #0x382bd14 ; 
006695EE8  mov      w8, #1
006695EEC  strb     w8, [x21, #0x61]
006695EF0  ldr      x2, [x22]
006695EF4  ldrb     w8, [x2, #0x53]
006695EF8  tbnz     w8, #5, #0x6695f80
006695EFC  str      xzr, [sp, #8]
006695F00  ldr      x0, [x19, #0x60]
006695F04  cbz      x0, #0x6695f9c
006695F08  adrp     x8, #0x8f10000
006695F0C  ldr      x8, [x8, #0xad8]
006695F10  add      x2, sp, #8
006695F14  mov      w1, w20
006695F18  ldr      x3, [x8]
006695F1C  bl       #0x5e9b3f0 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$TryGetValue
006695F20  tbz      w0, #0, #0x6695f70
006695F24  adrp     x8, #0x8f10000
006695F28  ldr      x8, [x8, #0xbb0]
006695F2C  ldr      x0, [x8]
006695F30  bl       #0x382bfa0 ; 
006695F34  adrp     x8, #0x8f10000
006695F38  ldr      x8, [x8, #0xba8]
006695F3C  mov      x20, x0
006695F40  ldr      x1, [x8]
006695F44  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
006695F48  cbz      x20, #0x6695f9c
006695F4C  adrp     x8, #0x8f10000
006695F50  ldr      x1, [sp, #8]
006695F54  ldr      x8, [x8, #0xa90]
006695F58  mov      x0, x20
006695F5C  ldr      x2, [x8]
006695F60  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
006695F64  mov      x0, x19
006695F68  mov      x1, x20
006695F6C  bl       #0x6695fa0 ; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffs
006695F70  ldp      x20, x19, [sp, #0x20]
006695F74  ldp      x22, x21, [sp, #0x10]
006695F78  ldr      x30, [sp], #0x30
006695F7C  ret      
006695F80  ldr      x3, [x2, #0x60]
006695F84  mov      x0, x19
006695F88  mov      w1, w20
006695F8C  ldp      x20, x19, [sp, #0x20]
006695F90  ldp      x22, x21, [sp, #0x10]
006695F94  ldr      x30, [sp], #0x30
006695F98  br       x3
006695F9C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$AddInvBuffTime
; RVA 0x669607C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00669607C  sub      sp, sp, #0x70
006696080  stp      x30, x23, [sp, #0x40]
006696084  stp      x22, x21, [sp, #0x50]
006696088  stp      x20, x19, [sp, #0x60]
00669608C  adrp     x22, #0x959a000
006696090  adrp     x23, #0x8f10000
006696094  ldrb     w8, [x22, #0x62]
006696098  ldr      x23, [x23, #0xc20]
00669609C  mov      x19, x2
0066960A0  mov      x20, x1
0066960A4  mov      x21, x0
0066960A8  tbnz     w8, #0, #0x6696108
0066960AC  adrp     x0, #0x8f10000
0066960B0  ldr      x0, [x0, #0xc28]
0066960B4  bl       #0x382bd14 ; 
0066960B8  adrp     x0, #0x8f10000
0066960BC  ldr      x0, [x0, #0xc20]
0066960C0  bl       #0x382bd14 ; 
0066960C4  adrp     x0, #0x8f10000
0066960C8  ldr      x0, [x0, #0xad8]
0066960CC  bl       #0x382bd14 ; 
0066960D0  adrp     x0, #0x8f10000
0066960D4  ldr      x0, [x0, #0xb28]
0066960D8  bl       #0x382bd14 ; 
0066960DC  adrp     x0, #0x8f10000
0066960E0  ldr      x0, [x0, #0xb30]
0066960E4  bl       #0x382bd14 ; 
0066960E8  adrp     x0, #0x8f10000
0066960EC  ldr      x0, [x0, #0xb38]
0066960F0  bl       #0x382bd14 ; 
0066960F4  adrp     x0, #0x8f10000
0066960F8  ldr      x0, [x0, #0xb40]
0066960FC  bl       #0x382bd14 ; 
006696100  mov      w8, #1
006696104  strb     w8, [x22, #0x62]
006696108  ldr      x3, [x23]
00669610C  ldrb     w8, [x3, #0x53]
006696110  tbnz     w8, #5, #0x66961f0
006696114  stp      xzr, xzr, [sp, #0x30]
006696118  stp      xzr, xzr, [sp, #0x20]
00669611C  ldr      x0, [x21, #0x60]
006696120  cbz      x0, #0x669624c
006696124  adrp     x8, #0x8f10000
006696128  ldr      x8, [x8, #0xad8]
00669612C  add      x2, sp, #0x38
006696130  mov      w1, wzr
006696134  ldr      x3, [x8]
006696138  bl       #0x5e9b3f0 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$TryGetValue
00669613C  tbz      w0, #0, #0x6696228
006696140  ldr      x0, [sp, #0x38]
006696144  cbz      x0, #0x669624c
006696148  adrp     x8, #0x8f10000
00669614C  ldr      x8, [x8, #0xb40]
006696150  ldr      x1, [x8]
006696154  add      x8, sp, #8
006696158  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
00669615C  ldur     q0, [sp, #8]
006696160  ldr      x8, [sp, #0x18]
006696164  adrp     x22, #0x8f10000
006696168  ldr      x22, [x22, #0xb30]
00669616C  str      q0, [sp, #0x20]
006696170  str      x8, [sp, #0x30]
006696174  adrp     x23, #0x8f10000
006696178  ldr      x23, [x23, #0xc28]
00669617C  ldr      x1, [x22]
006696180  add      x0, sp, #0x20
006696184  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
006696188  tbz      w0, #0, #0x6696214
00669618C  ldr      x21, [sp, #0x30]
006696190  cbz      x21, #0x6696244
006696194  ldr      x0, [x21, #0x48]
006696198  cbz      x0, #0x6696248
00669619C  mov      x1, xzr
0066961A0  bl       #0x663f198 ; HotFix.BattleLogic.BuffData$$get_ClassId
0066961A4  cmp      w0, #6
0066961A8  b.ne     #0x669617c
0066961AC  ldr      x8, [x21]
0066961B0  ldr      x1, [x23]
0066961B4  ldrb     w10, [x8, #0x130]
0066961B8  ldrb     w9, [x1, #0x130]
0066961BC  cmp      w10, w9
0066961C0  b.lo     #0x669623c
0066961C4  ldr      x8, [x8, #0xc8]
0066961C8  add      x8, x8, x9, lsl #3
0066961CC  ldur     x8, [x8, #-8]
0066961D0  cmp      x8, x1
0066961D4  b.ne     #0x669623c
0066961D8  mov      x0, x21
0066961DC  mov      x1, x20
0066961E0  mov      x2, x19
0066961E4  mov      x3, xzr
0066961E8  bl       #0x6645c30 ; HotFix.BattleLogic.Buff_Invincible$$AddTime
0066961EC  b        #0x669617c ; 
0066961F0  ldr      x4, [x3, #0x60]
0066961F4  mov      x0, x21
0066961F8  mov      x1, x20
0066961FC  mov      x2, x19
006696200  ldp      x20, x19, [sp, #0x60]
006696204  ldp      x22, x21, [sp, #0x50]
006696208  ldp      x30, x23, [sp, #0x40]
00669620C  add      sp, sp, #0x70
006696210  br       x4
006696214  adrp     x8, #0x8f10000
006696218  ldr      x8, [x8, #0xb28]
00669621C  add      x0, sp, #0x20
006696220  ldr      x1, [x8]
006696224  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
006696228  ldp      x20, x19, [sp, #0x60]
00669622C  ldp      x22, x21, [sp, #0x50]
006696230  ldp      x30, x23, [sp, #0x40]
006696234  add      sp, sp, #0x70
006696238  ret      
00669623C  mov      x0, x21
006696240  bl       #0x382c354 ; 
006696244  bl       #0x382bfb8 ; 
006696248  bl       #0x382bfb8 ; 
00669624C  bl       #0x382bfb8 ; 
006696250  b        #0x6696264 ; 
006696254  b        #0x6696264 ; 
006696258  b        #0x6696264 ; 
00669625C  b        #0x6696264 ; 
006696260  b        #0x6696264 ; 
006696264  mov      x19, x0
006696268  cmp      w1, #1
00669626C  b.ne     #0x66962a0
006696270  mov      x0, x19
006696274  bl       #0x89eda50 ; 
006696278  ldr      x20, [x0]
00669627C  bl       #0x89eda60 ; 
006696280  adrp     x8, #0x8f10000
006696284  ldr      x8, [x8, #0xb28]
006696288  add      x0, sp, #0x20
00669628C  ldr      x1, [x8]
006696290  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
006696294  cbz      x20, #0x6696228
006696298  mov      x0, x20
00669629C  bl       #0x382bfb0 ; 
0066962A0  mov      x20, xzr
0066962A4  b        #0x66962ac ; 
0066962A8  mov      x19, x0
0066962AC  adrp     x8, #0x8f10000
0066962B0  ldr      x8, [x8, #0xb28]
0066962B4  ldr      x1, [x8]
0066962B8  add      x0, sp, #0x20
0066962BC  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0066962C0  cbnz     x20, #0x66962cc
0066962C4  mov      x0, x19
0066962C8  bl       #0x3b56bfc ; 
0066962CC  mov      x0, x20
0066962D0  bl       #0x382bfb0 ; 
0066962D4  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$OnWaveEnd
; RVA 0x66962D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066962D8  str      x30, [sp, #-0x40]!
0066962DC  stp      x24, x23, [sp, #0x10]
0066962E0  stp      x22, x21, [sp, #0x20]
0066962E4  stp      x20, x19, [sp, #0x30]
0066962E8  adrp     x20, #0x959a000
0066962EC  adrp     x21, #0x8f10000
0066962F0  ldrb     w8, [x20, #0x63]
0066962F4  ldr      x21, [x21, #0xc30]
0066962F8  mov      x19, x0
0066962FC  tbnz     w8, #0, #0x6696338
006696300  adrp     x0, #0x8f10000
006696304  ldr      x0, [x0, #0xb20]
006696308  bl       #0x382bd14 ; 
00669630C  adrp     x0, #0x8f10000
006696310  ldr      x0, [x0, #0xc30]
006696314  bl       #0x382bd14 ; 
006696318  adrp     x0, #0x8f10000
00669631C  ldr      x0, [x0, #0xa98]
006696320  bl       #0x382bd14 ; 
006696324  adrp     x0, #0x8f10000
006696328  ldr      x0, [x0, #0xaa0]
00669632C  bl       #0x382bd14 ; 
006696330  mov      w8, #1
006696334  strb     w8, [x20, #0x63]
006696338  ldr      x1, [x21]
00669633C  ldrb     w8, [x1, #0x53]
006696340  tbnz     w8, #5, #0x66963e0
006696344  ldr      x0, [x19, #0x58]
006696348  cbz      x0, #0x66963dc
00669634C  ldr      w22, [x0, #0x18]
006696350  cmp      w22, #1
006696354  b.lt     #0x66963fc
006696358  adrp     x23, #0x8f10000
00669635C  adrp     x24, #0x8f10000
006696360  ldr      x23, [x23, #0xaa0]
006696364  ldr      x24, [x24, #0xb20]
006696368  mov      w20, wzr
00669636C  ldr      x2, [x23]
006696370  mov      w1, w20
006696374  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006696378  cbz      x0, #0x66963c8
00669637C  ldr      x8, [x0]
006696380  ldr      x1, [x24]
006696384  mov      x21, x0
006696388  ldrb     w10, [x8, #0x130]
00669638C  ldrb     w9, [x1, #0x130]
006696390  cmp      w10, w9
006696394  b.lo     #0x6696410
006696398  ldr      x8, [x8, #0xc8]
00669639C  add      x8, x8, x9, lsl #3
0066963A0  ldur     x8, [x8, #-8]
0066963A4  cmp      x8, x1
0066963A8  b.ne     #0x6696410
0066963AC  mov      x0, x21
0066963B0  mov      x1, xzr
0066963B4  bl       #0x6646288 ; HotFix.BattleLogic.Buff_Shield$$get_ClearOnWaveEnd
0066963B8  tbz      w0, #0, #0x66963c8
0066963BC  mov      x0, x21
0066963C0  mov      x1, xzr
0066963C4  bl       #0x663a830 ; HotFix.BattleLogic.BuffBase$$ForceEnd
0066963C8  add      w20, w20, #1
0066963CC  cmp      w22, w20
0066963D0  b.eq     #0x66963fc
0066963D4  ldr      x0, [x19, #0x58]
0066963D8  cbnz     x0, #0x669636c
0066963DC  bl       #0x382bfb8 ; 
0066963E0  ldr      x2, [x1, #0x60]
0066963E4  mov      x0, x19
0066963E8  ldp      x20, x19, [sp, #0x30]
0066963EC  ldp      x22, x21, [sp, #0x20]
0066963F0  ldp      x24, x23, [sp, #0x10]
0066963F4  ldr      x30, [sp], #0x40
0066963F8  br       x2
0066963FC  ldp      x20, x19, [sp, #0x30]
006696400  ldp      x22, x21, [sp, #0x20]
006696404  ldp      x24, x23, [sp, #0x10]
006696408  ldr      x30, [sp], #0x40
00669640C  ret      
006696410  mov      x0, x21
006696414  bl       #0x382c354 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$EndBuffById
; RVA 0x6696418; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006696418  str      x30, [sp, #-0x30]!
00669641C  stp      x22, x21, [sp, #0x10]
006696420  stp      x20, x19, [sp, #0x20]
006696424  adrp     x21, #0x959a000
006696428  adrp     x22, #0x8f10000
00669642C  ldrb     w8, [x21, #0x64]
006696430  ldr      x22, [x22, #0xc38]
006696434  mov      w19, w1
006696438  mov      x20, x0
00669643C  tbnz     w8, #0, #0x6696460
006696440  adrp     x0, #0x8f10000
006696444  ldr      x0, [x0, #0xc38]
006696448  bl       #0x382bd14 ; 
00669644C  adrp     x0, #0x8f10000
006696450  ldr      x0, [x0, #0xbc0]
006696454  bl       #0x382bd14 ; 
006696458  mov      w8, #1
00669645C  strb     w8, [x21, #0x64]
006696460  ldr      x2, [x22]
006696464  ldrb     w8, [x2, #0x53]
006696468  tbnz     w8, #5, #0x66964b4
00669646C  str      xzr, [sp, #8]
006696470  ldr      x0, [x20, #0x50]
006696474  cbz      x0, #0x66964d0
006696478  adrp     x8, #0x8f10000
00669647C  ldr      x8, [x8, #0xbc0]
006696480  add      x2, sp, #8
006696484  mov      w1, w19
006696488  ldr      x3, [x8]
00669648C  bl       #0x5227918 ; Rock.Collections.OrderedDictionary<int, object>$$TryGetValue
006696490  tbz      w0, #0, #0x66964a4
006696494  ldr      x0, [sp, #8]
006696498  cbz      x0, #0x66964d0
00669649C  mov      x1, xzr
0066964A0  bl       #0x663a830 ; HotFix.BattleLogic.BuffBase$$ForceEnd
0066964A4  ldp      x20, x19, [sp, #0x20]
0066964A8  ldp      x22, x21, [sp, #0x10]
0066964AC  ldr      x30, [sp], #0x30
0066964B0  ret      
0066964B4  ldr      x3, [x2, #0x60]
0066964B8  mov      x0, x20
0066964BC  mov      w1, w19
0066964C0  ldp      x20, x19, [sp, #0x20]
0066964C4  ldp      x22, x21, [sp, #0x10]
0066964C8  ldr      x30, [sp], #0x30
0066964CC  br       x3
0066964D0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffs
; RVA 0x6695FA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006695FA0  str      x30, [sp, #-0x30]!
006695FA4  stp      x22, x21, [sp, #0x10]
006695FA8  stp      x20, x19, [sp, #0x20]
006695FAC  adrp     x21, #0x959a000
006695FB0  adrp     x22, #0x8f10000
006695FB4  ldrb     w8, [x21, #0x65]
006695FB8  ldr      x22, [x22, #0xc18]
006695FBC  mov      x19, x1
006695FC0  mov      x20, x0
006695FC4  tbnz     w8, #0, #0x6695ff4
006695FC8  adrp     x0, #0x8f10000
006695FCC  ldr      x0, [x0, #0xc18]
006695FD0  bl       #0x382bd14 ; 
006695FD4  adrp     x0, #0x8f10000
006695FD8  ldr      x0, [x0, #0xa98]
006695FDC  bl       #0x382bd14 ; 
006695FE0  adrp     x0, #0x8f10000
006695FE4  ldr      x0, [x0, #0xaa0]
006695FE8  bl       #0x382bd14 ; 
006695FEC  mov      w8, #1
006695FF0  strb     w8, [x21, #0x65]
006695FF4  ldr      x2, [x22]
006695FF8  ldrb     w8, [x2, #0x53]
006695FFC  tbnz     w8, #5, #0x6696060
006696000  cbz      x19, #0x6696050
006696004  ldr      w8, [x19, #0x18]
006696008  cmp      w8, #1
00669600C  b.lt     #0x6696050
006696010  adrp     x22, #0x8f10000
006696014  ldr      x22, [x22, #0xaa0]
006696018  mov      w21, wzr
00669601C  ldr      x2, [x22]
006696020  mov      x0, x19
006696024  mov      w1, w21
006696028  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
00669602C  cbz      x0, #0x6696040
006696030  mov      x1, x0
006696034  mov      x0, x20
006696038  mov      w2, wzr
00669603C  bl       #0x66940a0 ; HotFix.BattleLogic.CharacterComponentBuff$$RemoveBuffInternal
006696040  ldr      w8, [x19, #0x18]
006696044  add      w21, w21, #1
006696048  cmp      w21, w8
00669604C  b.lt     #0x669601c
006696050  ldp      x20, x19, [sp, #0x20]
006696054  ldp      x22, x21, [sp, #0x10]
006696058  ldr      x30, [sp], #0x30
00669605C  ret      
006696060  ldr      x3, [x2, #0x60]
006696064  mov      x0, x20
006696068  mov      x1, x19
00669606C  ldp      x20, x19, [sp, #0x20]
006696070  ldp      x22, x21, [sp, #0x10]
006696074  ldr      x30, [sp], #0x30
006696078  br       x3

; HotFix.BattleLogic.CharacterComponentBuff$$HasBuffOfHurtType
; RVA 0x66964D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066964D4  sub      sp, sp, #0x90
0066964D8  str      x30, [sp, #0x40]
0066964DC  stp      x26, x25, [sp, #0x50]
0066964E0  stp      x24, x23, [sp, #0x60]
0066964E4  stp      x22, x21, [sp, #0x70]
0066964E8  stp      x20, x19, [sp, #0x80]
0066964EC  adrp     x21, #0x959a000
0066964F0  adrp     x22, #0x8f10000
0066964F4  ldrb     w8, [x21, #0x66]
0066964F8  ldr      x22, [x22, #0xc40]
0066964FC  mov      w19, w1
006696500  mov      x20, x0
006696504  tbnz     w8, #0, #0x6696558
006696508  adrp     x0, #0x8f10000
00669650C  ldr      x0, [x0, #0xc40]
006696510  bl       #0x382bd14 ; 
006696514  adrp     x0, #0x8f10000
006696518  ldr      x0, [x0, #0xc48]
00669651C  bl       #0x382bd14 ; 
006696520  adrp     x0, #0x8f10000
006696524  ldr      x0, [x0, #0xc50]
006696528  bl       #0x382bd14 ; 
00669652C  adrp     x0, #0x8f10000
006696530  ldr      x0, [x0, #0xc58]
006696534  bl       #0x382bd14 ; 
006696538  adrp     x0, #0x8f10000
00669653C  ldr      x0, [x0, #0xab0]
006696540  bl       #0x382bd14 ; 
006696544  adrp     x0, #0x8f10000
006696548  ldr      x0, [x0, #0xc60]
00669654C  bl       #0x382bd14 ; 
006696550  mov      w8, #1
006696554  strb     w8, [x21, #0x66]
006696558  ldr      x2, [x22]
00669655C  ldrb     w8, [x2, #0x53]
006696560  tbnz     w8, #5, #0x6696678
006696564  stp      xzr, xzr, [sp, #0x20]
006696568  str      xzr, [sp, #0x30]
00669656C  ldr      x0, [x20, #0x50]
006696570  cbz      x0, #0x66966e8
006696574  adrp     x8, #0x8f10000
006696578  ldr      x8, [x8, #0xab0]
00669657C  ldr      x1, [x8]
006696580  bl       #0x5225924 ; Rock.Collections.OrderedDictionary<int, object>$$get_Values
006696584  cbz      x0, #0x66966e8
006696588  adrp     x8, #0x8f10000
00669658C  ldr      x8, [x8, #0xc60]
006696590  ldr      x1, [x8]
006696594  add      x8, sp, #8
006696598  bl       #0x56eb890 ; Rock.Collections.OrderedDictionary.ValueCollection<int, object>$$GetEnumerator
00669659C  adrp     x23, #0x8f10000
0066965A0  adrp     x21, #0x8f0d000
0066965A4  ldur     q0, [sp, #8]
0066965A8  ldr      x8, [sp, #0x18]
0066965AC  ldr      x23, [x23, #0xc50]
0066965B0  ldr      x21, [x21, #0x188]
0066965B4  adrp     x24, #0x9599000
0066965B8  mov      w25, #1
0066965BC  str      q0, [sp, #0x20]
0066965C0  str      x8, [sp, #0x30]
0066965C4  ldr      x1, [x23]
0066965C8  add      x0, sp, #0x20
0066965CC  bl       #0x615497c ; Rock.Collections.OrderedDictionary.ValueCollection.Enumerator<int, object>$$MoveNext
0066965D0  mov      w20, w0
0066965D4  tbz      w0, #0, #0x66966a0
0066965D8  ldr      x26, [sp, #0x30]
0066965DC  cbz      x26, #0x66965c4
0066965E0  ldr      x22, [x26, #0x48]
0066965E4  cbz      x22, #0x66965c4
0066965E8  ldrb     w8, [x24, #0xacd]
0066965EC  cbnz     w8, #0x66965fc
0066965F0  mov      x0, x21
0066965F4  bl       #0x382bd14 ; 
0066965F8  strb     w25, [x24, #0xacd]
0066965FC  ldr      x1, [x21]
006696600  ldrb     w8, [x1, #0x53]
006696604  tbnz     w8, #5, #0x6696610
006696608  ldr      x0, [x22, #0x18]
00669660C  b        #0x669661c ; 
006696610  ldr      x8, [x1, #0x60]
006696614  mov      x0, x22
006696618  blr      x8
00669661C  cbz      x0, #0x66965c4
006696620  ldr      x22, [x26, #0x48]
006696624  cbz      x22, #0x66966e0
006696628  ldrb     w8, [x24, #0xacd]
00669662C  cbnz     w8, #0x669663c
006696630  mov      x0, x21
006696634  bl       #0x382bd14 ; 
006696638  strb     w25, [x24, #0xacd]
00669663C  ldr      x1, [x21]
006696640  ldrb     w8, [x1, #0x53]
006696644  tbnz     w8, #5, #0x6696650
006696648  ldr      x0, [x22, #0x18]
00669664C  b        #0x669665c ; 
006696650  ldr      x8, [x1, #0x60]
006696654  mov      x0, x22
006696658  blr      x8
00669665C  cbz      x0, #0x66966e4
006696660  mov      w1, w19
006696664  mov      x2, xzr
006696668  bl       #0x68875b8 ; LocalModels.Bean.Buff_buff$$IsHurtType
00669666C  tbz      w0, #0, #0x66965c4
006696670  mov      w19, #7
006696674  b        #0x66966a4 ; 
006696678  ldr      x3, [x2, #0x60]
00669667C  mov      x0, x20
006696680  mov      w1, w19
006696684  ldp      x20, x19, [sp, #0x80]
006696688  ldp      x22, x21, [sp, #0x70]
00669668C  ldp      x24, x23, [sp, #0x60]
006696690  ldp      x26, x25, [sp, #0x50]
006696694  ldr      x30, [sp, #0x40]
006696698  add      sp, sp, #0x90
00669669C  br       x3
0066966A0  mov      w19, #8
0066966A4  adrp     x8, #0x8f10000
0066966A8  ldr      x8, [x8, #0xc48]
0066966AC  add      x0, sp, #0x20
0066966B0  ldr      x1, [x8]
0066966B4  bl       #0x6154978 ; Rock.Collections.OrderedDictionary.ValueCollection.Enumerator<int, object>$$Dispose
0066966B8  cmp      w19, #7
0066966BC  cset     w8, eq
0066966C0  and      w0, w20, w8
0066966C4  ldp      x20, x19, [sp, #0x80]
0066966C8  ldp      x22, x21, [sp, #0x70]
0066966CC  ldp      x24, x23, [sp, #0x60]
0066966D0  ldp      x26, x25, [sp, #0x50]
0066966D4  ldr      x30, [sp, #0x40]
0066966D8  add      sp, sp, #0x90
0066966DC  ret      
0066966E0  bl       #0x382bfb8 ; 
0066966E4  bl       #0x382bfb8 ; 
0066966E8  bl       #0x382bfb8 ; 
0066966EC  b        #0x6696700 ; 
0066966F0  b        #0x6696700 ; 
0066966F4  b        #0x6696700 ; 
0066966F8  b        #0x6696700 ; 
0066966FC  b        #0x6696700 ; 
006696700  mov      x19, x0
006696704  cmp      w1, #1
006696708  b.ne     #0x669673c
00669670C  mov      x0, x19
006696710  bl       #0x89eda50 ; 
006696714  ldr      x20, [x0]
006696718  bl       #0x89eda60 ; 
00669671C  adrp     x8, #0x8f10000
006696720  ldr      x8, [x8, #0xc48]
006696724  add      x0, sp, #0x20
006696728  ldr      x1, [x8]
00669672C  bl       #0x6154978 ; Rock.Collections.OrderedDictionary.ValueCollection.Enumerator<int, object>$$Dispose
006696730  cbnz     x20, #0x6696744
006696734  mov      w19, wzr
006696738  b        #0x66966b8 ; 
00669673C  mov      x20, xzr
006696740  b        #0x6696750 ; 
006696744  mov      x0, x20
006696748  bl       #0x382bfb0 ; 
00669674C  mov      x19, x0
006696750  adrp     x8, #0x8f10000
006696754  ldr      x8, [x8, #0xc48]
006696758  ldr      x1, [x8]
00669675C  add      x0, sp, #0x20
006696760  bl       #0x6154978 ; Rock.Collections.OrderedDictionary.ValueCollection.Enumerator<int, object>$$Dispose
006696764  cbnz     x20, #0x6696770
006696768  mov      x0, x19
00669676C  bl       #0x3b56bfc ; 
006696770  mov      x0, x20
006696774  bl       #0x382bfb0 ; 
006696778  bl       #0x3442448 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$HasNegativeBuff
; RVA 0x669677C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00669677C  sub      sp, sp, #0x30
006696780  stp      x30, x21, [sp, #0x10]
006696784  stp      x20, x19, [sp, #0x20]
006696788  adrp     x20, #0x959a000
00669678C  adrp     x21, #0x8f10000
006696790  ldrb     w8, [x20, #0x67]
006696794  ldr      x21, [x21, #0xc68]
006696798  mov      x19, x0
00669679C  tbnz     w8, #0, #0x66967cc
0066967A0  adrp     x0, #0x8f10000
0066967A4  ldr      x0, [x0, #0xc68]
0066967A8  bl       #0x382bd14 ; 
0066967AC  adrp     x0, #0x8f10000
0066967B0  ldr      x0, [x0, #0xad8]
0066967B4  bl       #0x382bd14 ; 
0066967B8  adrp     x0, #0x8f10000
0066967BC  ldr      x0, [x0, #0xa98]
0066967C0  bl       #0x382bd14 ; 
0066967C4  mov      w8, #1
0066967C8  strb     w8, [x20, #0x67]
0066967CC  ldr      x1, [x21]
0066967D0  ldrb     w8, [x1, #0x53]
0066967D4  tbnz     w8, #5, #0x669684c
0066967D8  stp      xzr, xzr, [sp]
0066967DC  ldr      x0, [x19, #0x60]
0066967E0  cbz      x0, #0x6696878
0066967E4  adrp     x20, #0x8f10000
0066967E8  ldr      x20, [x20, #0xad8]
0066967EC  add      x2, sp, #8
0066967F0  mov      w1, #2
0066967F4  ldr      x3, [x20]
0066967F8  bl       #0x5e9b3f0 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$TryGetValue
0066967FC  tbz      w0, #0, #0x6696814
006696800  ldr      x8, [sp, #8]
006696804  cbz      x8, #0x6696878
006696808  ldr      w8, [x8, #0x18]
00669680C  cmp      w8, #0
006696810  b.gt     #0x6696844
006696814  ldr      x0, [x19, #0x60]
006696818  cbz      x0, #0x6696878
00669681C  ldr      x3, [x20]
006696820  mov      x2, sp
006696824  mov      w1, #1
006696828  bl       #0x5e9b3f0 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$TryGetValue
00669682C  tbz      w0, #0, #0x6696864
006696830  ldr      x8, [sp]
006696834  cbz      x8, #0x6696878
006696838  ldr      w8, [x8, #0x18]
00669683C  cmp      w8, #0
006696840  b.le     #0x6696864
006696844  mov      w0, #1
006696848  b        #0x6696868 ; 
00669684C  ldr      x2, [x1, #0x60]
006696850  mov      x0, x19
006696854  ldp      x20, x19, [sp, #0x20]
006696858  ldp      x30, x21, [sp, #0x10]
00669685C  add      sp, sp, #0x30
006696860  br       x2
006696864  mov      w0, wzr
006696868  ldp      x20, x19, [sp, #0x20]
00669686C  ldp      x30, x21, [sp, #0x10]
006696870  add      sp, sp, #0x30
006696874  ret      
006696878  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$GetAllBuffs
; RVA 0x669687C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00669687C  stp      x30, x21, [sp, #-0x20]!
006696880  stp      x20, x19, [sp, #0x10]
006696884  adrp     x20, #0x959a000
006696888  adrp     x21, #0x8f10000
00669688C  ldrb     w8, [x20, #0x68]
006696890  ldr      x21, [x21, #0xc70]
006696894  mov      x19, x0
006696898  tbnz     w8, #0, #0x66968bc
00669689C  adrp     x0, #0x8f10000
0066968A0  ldr      x0, [x0, #0xc70]
0066968A4  bl       #0x382bd14 ; 
0066968A8  adrp     x0, #0x8f10000
0066968AC  ldr      x0, [x0, #0xab0]
0066968B0  bl       #0x382bd14 ; 
0066968B4  mov      w8, #1
0066968B8  strb     w8, [x20, #0x68]
0066968BC  ldr      x1, [x21]
0066968C0  ldrb     w8, [x1, #0x53]
0066968C4  tbnz     w8, #5, #0x66968e8
0066968C8  ldr      x0, [x19, #0x50]
0066968CC  cbz      x0, #0x66968fc
0066968D0  adrp     x8, #0x8f10000
0066968D4  ldr      x8, [x8, #0xab0]
0066968D8  ldp      x20, x19, [sp, #0x10]
0066968DC  ldr      x1, [x8]
0066968E0  ldp      x30, x21, [sp], #0x20
0066968E4  b        #0x5225924 ; Rock.Collections.OrderedDictionary<int, object>$$get_Values
0066968E8  ldr      x2, [x1, #0x60]
0066968EC  mov      x0, x19
0066968F0  ldp      x20, x19, [sp, #0x10]
0066968F4  ldp      x30, x21, [sp], #0x20
0066968F8  br       x2
0066968FC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.CharacterComponentBuff$$.ctor
; RVA 0x6696900; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006696900  str      x30, [sp, #-0x50]!
006696904  stp      x26, x25, [sp, #0x10]
006696908  stp      x24, x23, [sp, #0x20]
00669690C  stp      x22, x21, [sp, #0x30]
006696910  stp      x20, x19, [sp, #0x40]
006696914  adrp     x20, #0x959a000
006696918  adrp     x21, #0x8f10000
00669691C  ldrb     w8, [x20, #0x69]
006696920  ldr      x21, [x21, #0xc78]
006696924  mov      x19, x0
006696928  tbnz     w8, #0, #0x6696994
00669692C  adrp     x0, #0x8ebf000
006696930  ldr      x0, [x0, #0x410]
006696934  bl       #0x382bd14 ; 
006696938  adrp     x0, #0x8f10000
00669693C  ldr      x0, [x0, #0xc78]
006696940  bl       #0x382bd14 ; 
006696944  adrp     x0, #0x8f10000
006696948  ldr      x0, [x0, #0xc80]
00669694C  bl       #0x382bd14 ; 
006696950  adrp     x0, #0x8f10000
006696954  ldr      x0, [x0, #0xc88]
006696958  bl       #0x382bd14 ; 
00669695C  adrp     x0, #0x8f10000
006696960  ldr      x0, [x0, #0xba8]
006696964  bl       #0x382bd14 ; 
006696968  adrp     x0, #0x8f10000
00669696C  ldr      x0, [x0, #0xbb0]
006696970  bl       #0x382bd14 ; 
006696974  adrp     x0, #0x8f10000
006696978  ldr      x0, [x0, #0xc90]
00669697C  bl       #0x382bd14 ; 
006696980  adrp     x0, #0x8f10000
006696984  ldr      x0, [x0, #0xc98]
006696988  bl       #0x382bd14 ; 
00669698C  mov      w8, #1
006696990  strb     w8, [x20, #0x69]
006696994  ldr      x1, [x21]
006696998  ldrb     w8, [x1, #0x53]
00669699C  tbnz     w8, #5, #0x6696a90
0066969A0  adrp     x20, #0x8f10000
0066969A4  adrp     x21, #0x8f10000
0066969A8  adrp     x23, #0x8f10000
0066969AC  adrp     x24, #0x8f10000
0066969B0  adrp     x25, #0x8f10000
0066969B4  adrp     x26, #0x8f10000
0066969B8  adrp     x22, #0x8ebf000
0066969BC  ldr      x20, [x20, #0xc98]
0066969C0  ldr      x21, [x21, #0xc90]
0066969C4  ldr      x23, [x23, #0xbb0]
0066969C8  ldr      x24, [x24, #0xba8]
0066969CC  ldr      x25, [x25, #0xc88]
0066969D0  ldr      x26, [x26, #0xc80]
0066969D4  ldr      x22, [x22, #0x410]
0066969D8  mov      x0, xzr
0066969DC  bl       #0x416d554 ; Rock.Collections.Custom.OrderedDictionaryIntComparer$$get_Default
0066969E0  ldr      x8, [x20]
0066969E4  mov      x20, x0
0066969E8  mov      x0, x8
0066969EC  bl       #0x382bfa0 ; 
0066969F0  ldr      x2, [x21]
0066969F4  mov      x1, x20
0066969F8  mov      x21, x0
0066969FC  bl       #0x5224fcc ; Rock.Collections.OrderedDictionary<int, object>$$.ctor
006696A00  mov      x0, x19
006696A04  str      x21, [x0, #0x50]!
006696A08  mov      x1, x21
006696A0C  bl       #0x382bcb8 ; 
006696A10  ldr      x0, [x23]
006696A14  bl       #0x382bfa0 ; 
006696A18  ldr      x1, [x24]
006696A1C  mov      x20, x0
006696A20  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
006696A24  mov      x0, x19
006696A28  str      x20, [x0, #0x58]!
006696A2C  mov      x1, x20
006696A30  bl       #0x382bcb8 ; 
006696A34  ldr      x0, [x25]
006696A38  bl       #0x382bfa0 ; 
006696A3C  ldr      x1, [x26]
006696A40  mov      x20, x0
006696A44  bl       #0x5e98b64 ; System.Collections.Generic.Dictionary<Int32Enum, object>$$.ctor
006696A48  mov      x0, x19
006696A4C  str      x20, [x0, #0x60]!
006696A50  mov      x1, x20
006696A54  bl       #0x382bcb8 ; 
006696A58  ldr      x0, [x22]
006696A5C  mov      w1, #8
006696A60  bl       #0x382bdfc ; 
006696A64  mov      x1, x0
006696A68  mov      x0, x19
006696A6C  str      x1, [x0, #0x68]!
006696A70  bl       #0x382bcb8 ; 
006696A74  mov      x0, x19
006696A78  ldp      x20, x19, [sp, #0x40]
006696A7C  ldp      x22, x21, [sp, #0x30]
006696A80  ldp      x24, x23, [sp, #0x20]
006696A84  ldp      x26, x25, [sp, #0x10]
006696A88  ldr      x30, [sp], #0x50
006696A8C  b        #0x6693378 ; HotFix.BattleLogic.CharacterComponentBase$$.ctor
006696A90  ldr      x2, [x1, #0x60]
006696A94  mov      x0, x19
006696A98  ldp      x20, x19, [sp, #0x40]
006696A9C  ldp      x22, x21, [sp, #0x30]
006696AA0  ldp      x24, x23, [sp, #0x20]
006696AA4  ldp      x26, x25, [sp, #0x10]
006696AA8  ldr      x30, [sp], #0x50
006696AAC  br       x2

