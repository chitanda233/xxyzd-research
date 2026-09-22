; HotFix.Common.CommonUtils$$CreateAttributeData
; RVA 0x6B5066C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B5066C  sub      sp, sp, #0x1b0
006B50670  str      x29, [sp, #0x170]
006B50674  stp      x30, x23, [sp, #0x180]
006B50678  stp      x22, x21, [sp, #0x190]
006B5067C  stp      x20, x19, [sp, #0x1a0]
006B50680  adrp     x22, #0x959f000
006B50684  adrp     x23, #0x8f41000
006B50688  ldrb     w8, [x22, #0xc09]
006B5068C  ldr      x23, [x23, #0x3c0] ; GLOBAL Method$HotFix.Common.CommonUtils.CreateAttributeData()
006B50690  mov      w21, w2
006B50694  mov      x19, x1
006B50698  mov      x20, x0
006B5069C  tbnz     w8, #0, #0x6b50714
006B506A0  adrp     x0, #0x8f41000
006B506A4  ldr      x0, [x0, #0x3c0] ; GLOBAL Method$HotFix.Common.CommonUtils.CreateAttributeData()
006B506A8  bl       #0x382bd14 ; 
006B506AC  adrp     x0, #0x8f22000
006B506B0  ldr      x0, [x0, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
006B506B4  bl       #0x382bd14 ; 
006B506B8  adrp     x0, #0x8f32000
006B506BC  ldr      x0, [x0, #0xf08] ; GLOBAL HPMax
006B506C0  bl       #0x382bd14 ; 
006B506C4  adrp     x0, #0x8f07000
006B506C8  ldr      x0, [x0, #0x1b0] ; GLOBAL Attack
006B506CC  bl       #0x382bd14 ; 
006B506D0  adrp     x0, #0x8f23000
006B506D4  ldr      x0, [x0, #0x88] ; GLOBAL BulletLifeRange
006B506D8  bl       #0x382bd14 ; 
006B506DC  adrp     x0, #0x8f32000
006B506E0  ldr      x0, [x0, #0x188] ; GLOBAL BodyAttack
006B506E4  bl       #0x382bd14 ; 
006B506E8  adrp     x0, #0x8f11000
006B506EC  ldr      x0, [x0, #0xd40] ; GLOBAL HittedInterval
006B506F0  bl       #0x382bd14 ; 
006B506F4  adrp     x0, #0x8f0c000
006B506F8  ldr      x0, [x0, #0xb08] ; GLOBAL MoveSpeed
006B506FC  bl       #0x382bd14 ; 
006B50700  adrp     x0, #0x8f0b000
006B50704  ldr      x0, [x0, #0xe50] ; GLOBAL RotateSpeed
006B50708  bl       #0x382bd14 ; 
006B5070C  mov      w8, #1
006B50710  strb     w8, [x22, #0xc09]
006B50714  ldr      x3, [x23]
006B50718  ldrb     w8, [x3, #0x53]
006B5071C  tbnz     w8, #5, #0x6b5078c
006B50720  adrp     x8, #0x8f22000
006B50724  ldr      x8, [x8, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
006B50728  ldr      x0, [x8]
006B5072C  ldr      w8, [x0, #0xe0]
006B50730  cbnz     w8, #0x6b50738
006B50734  bl       #0x382be8c ; 
006B50738  and      w2, w21, #1
006B5073C  mov      w1, #1
006B50740  mov      x0, x20
006B50744  bl       #0x6b5013c ; HotFix.Common.CommonUtils$$CreateAttributeData
006B50748  cbz      x19, #0x6b50c2c
006B5074C  adrp     x21, #0x959f000
006B50750  ldrb     w8, [x21, #0xcfa]
006B50754  mov      x20, x0
006B50758  cbnz     w8, #0x6b50770
006B5075C  adrp     x0, #0x8f27000
006B50760  ldr      x0, [x0, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_HP()
006B50764  bl       #0x382bd14 ; 
006B50768  mov      w8, #1
006B5076C  strb     w8, [x21, #0xcfa]
006B50770  adrp     x8, #0x8f27000
006B50774  ldr      x8, [x8, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_HP()
006B50778  ldr      x1, [x8]
006B5077C  ldrb     w8, [x1, #0x53]
006B50780  tbnz     w8, #5, #0x6b507b4
006B50784  ldr      x2, [x19, #0x68]
006B50788  b        #0x6b507c4 ; 
006B5078C  ldr      x4, [x3, #0x60]
006B50790  and      w2, w21, #1
006B50794  mov      x0, x20
006B50798  mov      x1, x19
006B5079C  ldp      x20, x19, [sp, #0x1a0]
006B507A0  ldp      x22, x21, [sp, #0x190]
006B507A4  ldp      x30, x23, [sp, #0x180]
006B507A8  ldr      x29, [sp, #0x170]
006B507AC  add      sp, sp, #0x1b0
006B507B0  br       x4
006B507B4  ldr      x8, [x1, #0x60]
006B507B8  mov      x0, x19
006B507BC  blr      x8
006B507C0  mov      x2, x0
006B507C4  adrp     x8, #0x8f32000
006B507C8  ldr      x8, [x8, #0xf08] ; GLOBAL HPMax
006B507CC  add      x0, sp, #0x158
006B507D0  stp      xzr, xzr, [sp, #0x158]
006B507D4  str      xzr, [sp, #0x168]
006B507D8  ldr      x1, [x8]
006B507DC  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
006B507E0  cbz      x20, #0x6b50c2c
006B507E4  add      x21, sp, #0x98
006B507E8  ldr      q0, [x21, #0xc0]
006B507EC  ldr      x8, [sp, #0x168]
006B507F0  add      x1, sp, #0x140
006B507F4  mov      x0, x20
006B507F8  mov      w2, wzr
006B507FC  mov      x3, xzr
006B50800  str      q0, [sp, #0x140]
006B50804  str      x8, [sp, #0x150]
006B50808  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B5080C  adrp     x22, #0x959f000
006B50810  ldrb     w8, [x22, #0xcfb]
006B50814  cbnz     w8, #0x6b5082c
006B50818  adrp     x0, #0x8f27000
006B5081C  ldr      x0, [x0, #0xac8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Attack()
006B50820  bl       #0x382bd14 ; 
006B50824  mov      w8, #1
006B50828  strb     w8, [x22, #0xcfb]
006B5082C  adrp     x8, #0x8f27000
006B50830  ldr      x8, [x8, #0xac8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Attack()
006B50834  ldr      x1, [x8]
006B50838  ldrb     w8, [x1, #0x53]
006B5083C  tbnz     w8, #5, #0x6b50848
006B50840  ldr      x2, [x19, #0x70]
006B50844  b        #0x6b50858 ; 
006B50848  ldr      x8, [x1, #0x60]
006B5084C  mov      x0, x19
006B50850  blr      x8
006B50854  mov      x2, x0
006B50858  adrp     x8, #0x8f07000
006B5085C  ldr      x8, [x8, #0x1b0] ; GLOBAL Attack
006B50860  add      x0, sp, #0x128
006B50864  stp      xzr, xzr, [sp, #0x128]
006B50868  str      xzr, [sp, #0x138]
006B5086C  ldr      x1, [x8]
006B50870  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
006B50874  ldr      q0, [x21, #0x90]
006B50878  ldr      x8, [sp, #0x138]
006B5087C  add      x1, sp, #0x110
006B50880  mov      x0, x20
006B50884  mov      w2, wzr
006B50888  mov      x3, xzr
006B5088C  str      q0, [sp, #0x110]
006B50890  str      x8, [sp, #0x120]
006B50894  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B50898  adrp     x22, #0x959f000
006B5089C  ldrb     w8, [x22, #0xcfc]
006B508A0  cbnz     w8, #0x6b508b8
006B508A4  adrp     x0, #0x8f27000
006B508A8  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_BodyAttack()
006B508AC  bl       #0x382bd14 ; 
006B508B0  mov      w8, #1
006B508B4  strb     w8, [x22, #0xcfc]
006B508B8  adrp     x8, #0x8f27000
006B508BC  ldr      x8, [x8, #0xcf0] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_BodyAttack()
006B508C0  ldr      x1, [x8]
006B508C4  ldrb     w8, [x1, #0x53]
006B508C8  tbnz     w8, #5, #0x6b508d4
006B508CC  ldr      x2, [x19, #0x198]
006B508D0  b        #0x6b508e4 ; 
006B508D4  ldr      x8, [x1, #0x60]
006B508D8  mov      x0, x19
006B508DC  blr      x8
006B508E0  mov      x2, x0
006B508E4  adrp     x8, #0x8f32000
006B508E8  ldr      x8, [x8, #0x188] ; GLOBAL BodyAttack
006B508EC  add      x0, sp, #0xf8
006B508F0  stp      xzr, xzr, [sp, #0xf8]
006B508F4  str      xzr, [sp, #0x108]
006B508F8  ldr      x1, [x8]
006B508FC  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
006B50900  ldr      q0, [x21, #0x60]
006B50904  ldr      x8, [sp, #0x108]
006B50908  add      x1, sp, #0xe0
006B5090C  mov      x0, x20
006B50910  mov      w2, wzr
006B50914  mov      x3, xzr
006B50918  str      q0, [sp, #0xe0]
006B5091C  str      x8, [sp, #0xf0]
006B50920  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B50924  adrp     x22, #0x9599000
006B50928  ldrb     w8, [x22, #0x910]
006B5092C  cbnz     w8, #0x6b50944
006B50930  adrp     x0, #0x8f0c000
006B50934  ldr      x0, [x0, #0x3f0] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_MoveSpeed()
006B50938  bl       #0x382bd14 ; 
006B5093C  mov      w8, #1
006B50940  strb     w8, [x22, #0x910]
006B50944  adrp     x8, #0x8f0c000
006B50948  ldr      x8, [x8, #0x3f0] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_MoveSpeed()
006B5094C  ldr      x1, [x8]
006B50950  ldrb     w8, [x1, #0x53]
006B50954  tbnz     w8, #5, #0x6b50960
006B50958  ldr      x2, [x19, #0x78]
006B5095C  b        #0x6b50970 ; 
006B50960  ldr      x8, [x1, #0x60]
006B50964  mov      x0, x19
006B50968  blr      x8
006B5096C  mov      x2, x0
006B50970  adrp     x8, #0x8f0c000
006B50974  ldr      x8, [x8, #0xb08] ; GLOBAL MoveSpeed
006B50978  add      x0, sp, #0xc8
006B5097C  stp      xzr, xzr, [sp, #0xc8]
006B50980  str      xzr, [sp, #0xd8]
006B50984  ldr      x1, [x8]
006B50988  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
006B5098C  ldr      q0, [x21, #0x30]
006B50990  ldr      x8, [sp, #0xd8]
006B50994  add      x1, sp, #0xb0
006B50998  mov      x0, x20
006B5099C  mov      w2, wzr
006B509A0  mov      x3, xzr
006B509A4  str      q0, [sp, #0xb0]
006B509A8  str      x8, [sp, #0xc0]
006B509AC  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B509B0  adrp     x22, #0x959f000
006B509B4  ldrb     w8, [x22, #0xcf7]
006B509B8  cbnz     w8, #0x6b509d0
006B509BC  adrp     x0, #0x8f27000
006B509C0  ldr      x0, [x0, #0xce0] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_rotateSpeed()
006B509C4  bl       #0x382bd14 ; 
006B509C8  mov      w8, #1
006B509CC  strb     w8, [x22, #0xcf7]
006B509D0  adrp     x8, #0x8f27000
006B509D4  ldr      x8, [x8, #0xce0] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_rotateSpeed()
006B509D8  ldr      x1, [x8]
006B509DC  ldrb     w8, [x1, #0x53]
006B509E0  tbnz     w8, #5, #0x6b509ec
006B509E4  ldr      x2, [x19, #0x190]
006B509E8  b        #0x6b509fc ; 
006B509EC  ldr      x8, [x1, #0x60]
006B509F0  mov      x0, x19
006B509F4  blr      x8
006B509F8  mov      x2, x0
006B509FC  adrp     x8, #0x8f0b000
006B50A00  ldr      x8, [x8, #0xe50] ; GLOBAL RotateSpeed
006B50A04  add      x0, sp, #0x98
006B50A08  stp      xzr, xzr, [sp, #0x98]
006B50A0C  str      xzr, [sp, #0xa8]
006B50A10  ldr      x1, [x8]
006B50A14  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
006B50A18  ldr      q0, [x21]
006B50A1C  ldr      x8, [sp, #0xa8]
006B50A20  add      x1, sp, #0x80
006B50A24  mov      x0, x20
006B50A28  mov      w2, wzr
006B50A2C  mov      x3, xzr
006B50A30  str      q0, [sp, #0x80]
006B50A34  str      x8, [sp, #0x90]
006B50A38  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B50A3C  adrp     x22, #0x959f000
006B50A40  ldrb     w8, [x22, #0xcfd]
006B50A44  cbnz     w8, #0x6b50a5c
006B50A48  adrp     x0, #0x8f27000
006B50A4C  ldr      x0, [x0, #0xd48] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_HittedInterval()
006B50A50  bl       #0x382bd14 ; 
006B50A54  mov      w8, #1
006B50A58  strb     w8, [x22, #0xcfd]
006B50A5C  adrp     x8, #0x8f27000
006B50A60  ldr      x8, [x8, #0xd48] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_HittedInterval()
006B50A64  ldr      x1, [x8]
006B50A68  ldrb     w8, [x1, #0x53]
006B50A6C  tbnz     w8, #5, #0x6b50a78
006B50A70  ldr      x2, [x19, #0x1b8]
006B50A74  b        #0x6b50a88 ; 
006B50A78  ldr      x8, [x1, #0x60]
006B50A7C  mov      x0, x19
006B50A80  blr      x8
006B50A84  mov      x2, x0
006B50A88  adrp     x8, #0x8f11000
006B50A8C  ldr      x8, [x8, #0xd40] ; GLOBAL HittedInterval
006B50A90  add      x0, sp, #0x68
006B50A94  stp      xzr, xzr, [sp, #0x68]
006B50A98  str      xzr, [sp, #0x78]
006B50A9C  ldr      x1, [x8]
006B50AA0  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
006B50AA4  ldur     q0, [sp, #0x68]
006B50AA8  ldr      x8, [sp, #0x78]
006B50AAC  add      x1, sp, #0x50
006B50AB0  mov      x0, x20
006B50AB4  mov      w2, wzr
006B50AB8  mov      x3, xzr
006B50ABC  str      q0, [sp, #0x50]
006B50AC0  str      x8, [sp, #0x60]
006B50AC4  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B50AC8  adrp     x22, #0x959f000
006B50ACC  ldrb     w8, [x22, #0xcf8]
006B50AD0  cbnz     w8, #0x6b50ae8
006B50AD4  adrp     x0, #0x8f27000
006B50AD8  ldr      x0, [x0, #0xb30] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_BulletLifeRange()
006B50ADC  bl       #0x382bd14 ; 
006B50AE0  mov      w8, #1
006B50AE4  strb     w8, [x22, #0xcf8]
006B50AE8  adrp     x8, #0x8f27000
006B50AEC  ldr      x8, [x8, #0xb30] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_BulletLifeRange()
006B50AF0  ldr      x1, [x8]
006B50AF4  ldrb     w8, [x1, #0x53]
006B50AF8  tbnz     w8, #5, #0x6b50b04
006B50AFC  ldr      x2, [x19, #0xb8]
006B50B00  b        #0x6b50b14 ; 
006B50B04  ldr      x8, [x1, #0x60]
006B50B08  mov      x0, x19
006B50B0C  blr      x8
006B50B10  mov      x2, x0
006B50B14  adrp     x8, #0x8f23000
006B50B18  ldr      x8, [x8, #0x88] ; GLOBAL BulletLifeRange
006B50B1C  add      x0, sp, #0x38
006B50B20  stp      xzr, xzr, [sp, #0x38]
006B50B24  str      xzr, [sp, #0x48]
006B50B28  ldr      x1, [x8]
006B50B2C  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
006B50B30  ldur     q0, [sp, #0x38]
006B50B34  ldr      x8, [sp, #0x48]
006B50B38  add      x1, sp, #0x20
006B50B3C  mov      x0, x20
006B50B40  mov      w2, wzr
006B50B44  mov      x3, xzr
006B50B48  str      q0, [sp, #0x20]
006B50B4C  str      x8, [sp, #0x30]
006B50B50  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B50B54  adrp     x22, #0x959f000
006B50B58  ldrb     w8, [x22, #0xcf9]
006B50B5C  cbnz     w8, #0x6b50b74
006B50B60  adrp     x0, #0x8f27000
006B50B64  ldr      x0, [x0, #0xae8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_attributes()
006B50B68  bl       #0x382bd14 ; 
006B50B6C  mov      w8, #1
006B50B70  strb     w8, [x22, #0xcf9]
006B50B74  adrp     x8, #0x8f27000
006B50B78  ldr      x8, [x8, #0xae8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_attributes()
006B50B7C  ldr      x1, [x8]
006B50B80  ldrb     w8, [x1, #0x53]
006B50B84  tbnz     w8, #5, #0x6b50b90
006B50B88  ldr      x19, [x19, #0x88]
006B50B8C  b        #0x6b50ba0 ; 
006B50B90  ldr      x8, [x1, #0x60]
006B50B94  mov      x0, x19
006B50B98  blr      x8
006B50B9C  mov      x19, x0
006B50BA0  cbz      x19, #0x6b50c2c
006B50BA4  ldr      x8, [x19, #0x18]
006B50BA8  cmp      w8, #1
006B50BAC  b.lt     #0x6b50c0c
006B50BB0  mov      x22, xzr
006B50BB4  and      x8, x8, #0xffffffff
006B50BB8  add      x23, x19, #0x20
006B50BBC  cmp      x22, w8, uxtw
006B50BC0  b.hs     #0x6b50c28
006B50BC4  ldr      x1, [x23, x22, lsl #3]
006B50BC8  add      x0, sp, #0x158
006B50BCC  stp      xzr, xzr, [sp, #0x158]
006B50BD0  str      xzr, [sp, #0x168]
006B50BD4  bl       #0x6b4076c ; HotFix.Common.AttributeOneElement$$.ctor
006B50BD8  ldr      q0, [x21, #0xc0]
006B50BDC  ldr      x8, [sp, #0x168]
006B50BE0  mov      x1, sp
006B50BE4  mov      x0, x20
006B50BE8  mov      w2, wzr
006B50BEC  mov      x3, xzr
006B50BF0  str      q0, [sp]
006B50BF4  str      x8, [sp, #0x10]
006B50BF8  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006B50BFC  ldr      w8, [x19, #0x18]
006B50C00  add      x22, x22, #1
006B50C04  cmp      x22, w8, sxtw
006B50C08  b.lt     #0x6b50bbc
006B50C0C  mov      x0, x20
006B50C10  ldp      x20, x19, [sp, #0x1a0]
006B50C14  ldp      x22, x21, [sp, #0x190]
006B50C18  ldp      x30, x23, [sp, #0x180]
006B50C1C  ldr      x29, [sp, #0x170]
006B50C20  add      sp, sp, #0x1b0
006B50C24  ret      
006B50C28  bl       #0x382bfc0 ; 
006B50C2C  bl       #0x382bfb8 ; 

