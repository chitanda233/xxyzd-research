; HotFix.BattleLogic.BattleWorldContext$$CreateBulletData
; RVA 0x69FDEFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069FDEFC  sub      sp, sp, #0x1f0
0069FDF00  stp      x29, x30, [sp, #0x190]
0069FDF04  stp      x28, x27, [sp, #0x1a0]
0069FDF08  stp      x26, x25, [sp, #0x1b0]
0069FDF0C  stp      x24, x23, [sp, #0x1c0]
0069FDF10  stp      x22, x21, [sp, #0x1d0]
0069FDF14  stp      x20, x19, [sp, #0x1e0]
0069FDF18  stp      x6, x7, [sp, #0x50]
0069FDF1C  stp      x3, x5, [sp, #0x38]
0069FDF20  mrs      x8, tpidr_el0
0069FDF24  str      x8, [sp, #0x48]
0069FDF28  ldr      x8, [x8, #0x28]
0069FDF2C  adrp     x20, #0x959d000
0069FDF30  adrp     x19, #0x8f32000
0069FDF34  ldr      x28, [sp, #0x200]
0069FDF38  str      x8, [sp, #0x188]
0069FDF3C  ldrb     w8, [x20, #0x51d]
0069FDF40  ldr      x19, [x19, #0x498] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateBulletData()
0069FDF44  mov      x27, x4
0069FDF48  mov      x29, x2
0069FDF4C  mov      x23, x1
0069FDF50  mov      x24, x0
0069FDF54  tbnz     w8, #0, #0x69fdfe4
0069FDF58  adrp     x0, #0x8f32000
0069FDF5C  ldr      x0, [x0, #0x498] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateBulletData()
0069FDF60  bl       #0x382bd14 ; 
0069FDF64  adrp     x0, #0x8f32000
0069FDF68  ldr      x0, [x0, #0x4a0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEntityData<BulletData>()
0069FDF6C  bl       #0x382bd14 ; 
0069FDF70  adrp     x0, #0x8f22000
0069FDF74  ldr      x0, [x0, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
0069FDF78  bl       #0x382bd14 ; 
0069FDF7C  adrp     x0, #0x8ee6000
0069FDF80  ldr      x0, [x0, #0x1a8] ; GLOBAL BulletSpeed
0069FDF84  bl       #0x382bd14 ; 
0069FDF88  adrp     x0, #0x8ee6000
0069FDF8C  ldr      x0, [x0, #0x1b8] ; GLOBAL Bullet_LifeTime
0069FDF90  bl       #0x382bd14 ; 
0069FDF94  adrp     x0, #0x8f17000
0069FDF98  ldr      x0, [x0, #0xb78] ; GLOBAL CritRate%
0069FDF9C  bl       #0x382bd14 ; 
0069FDFA0  adrp     x0, #0x8f32000
0069FDFA4  ldr      x0, [x0, #0x4a8] ; GLOBAL SuperCritValue%
0069FDFA8  bl       #0x382bd14 ; 
0069FDFAC  adrp     x0, #0x8f17000
0069FDFB0  ldr      x0, [x0, #0xb80] ; GLOBAL CritValue%
0069FDFB4  bl       #0x382bd14 ; 
0069FDFB8  adrp     x0, #0x8f0f000
0069FDFBC  ldr      x0, [x0, #0xd08] ; GLOBAL Attack%
0069FDFC0  bl       #0x382bd14 ; 
0069FDFC4  adrp     x0, #0x8f0b000
0069FDFC8  ldr      x0, [x0, #0xe50] ; GLOBAL RotateSpeed
0069FDFCC  bl       #0x382bd14 ; 
0069FDFD0  adrp     x0, #0x8f32000
0069FDFD4  ldr      x0, [x0, #0x4b0] ; GLOBAL SuperCritRate%
0069FDFD8  bl       #0x382bd14 ; 
0069FDFDC  mov      w8, #1
0069FDFE0  strb     w8, [x20, #0x51d]
0069FDFE4  ldr      x20, [x19]
0069FDFE8  ldr      x26, [sp, #0x208]
0069FDFEC  ldp      x21, x19, [sp, #0x1f0]
0069FDFF0  ldrb     w8, [x20, #0x53]
0069FDFF4  tbnz     w8, #5, #0x69fe060
0069FDFF8  str      x26, [sp, #0x30]
0069FDFFC  adrp     x20, #0x8f32000
0069FE000  ldr      x20, [x20, #0x4a0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEntityData<BulletData>()
0069FE004  mov      x0, x24
0069FE008  bl       #0x69fd584 ; HotFix.BattleLogic.BattleWorldContext$$CreateQBulletEntity
0069FE00C  ldr      x2, [x20]
0069FE010  mov      x1, x0
0069FE014  mov      x0, x24
0069FE018  bl       #0x4540144 ; HotFix.BattleLogic.BattleWorldContext$$CreateEntityData<object>
0069FE01C  cbz      x23, #0x69fe728
0069FE020  adrp     x20, #0x9595000
0069FE024  ldrb     w8, [x20, #0x73c]
0069FE028  mov      x22, x0
0069FE02C  cbnz     w8, #0x69fe044
0069FE030  adrp     x0, #0x8eea000
0069FE034  ldr      x0, [x0, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ID()
0069FE038  bl       #0x382bd14 ; 
0069FE03C  mov      w8, #1
0069FE040  strb     w8, [x20, #0x73c]
0069FE044  adrp     x8, #0x8eea000
0069FE048  ldr      x8, [x8, #0xf60] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_ID()
0069FE04C  ldr      x1, [x8]
0069FE050  ldrb     w8, [x1, #0x53]
0069FE054  tbnz     w8, #5, #0x69fe0a8
0069FE058  ldr      w20, [x23, #0x20]
0069FE05C  b        #0x69fe0b8 ; 
0069FE060  ldr      x22, [x20, #0x60]
0069FE064  add      x0, sp, #0x120
0069FE068  mov      w2, #0x68
0069FE06C  mov      x1, x28
0069FE070  add      x25, sp, #0x120
0069FE074  bl       #0x89edad0 ; 
0069FE078  ldp      x3, x5, [sp, #0x38]
0069FE07C  ldp      x6, x7, [sp, #0x50]
0069FE080  mov      x0, x24
0069FE084  mov      x1, x23
0069FE088  mov      x2, x29
0069FE08C  mov      x4, x27
0069FE090  stp      x26, x20, [sp, #0x18]
0069FE094  stp      x19, x25, [sp, #8]
0069FE098  str      x21, [sp]
0069FE09C  blr      x22
0069FE0A0  mov      x22, x0
0069FE0A4  b        #0x69fe6f0 ; 
0069FE0A8  ldr      x8, [x1, #0x60]
0069FE0AC  mov      x0, x23
0069FE0B0  blr      x8
0069FE0B4  mov      w20, w0
0069FE0B8  cbz      x22, #0x69fe728
0069FE0BC  adrp     x25, #0x959d000
0069FE0C0  ldrb     w8, [x25, #0x64a]
0069FE0C4  cbnz     w8, #0x69fe0dc
0069FE0C8  adrp     x0, #0x8f0f000
0069FE0CC  ldr      x0, [x0, #0x9b0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ID()
0069FE0D0  bl       #0x382bd14 ; 
0069FE0D4  mov      w8, #1
0069FE0D8  strb     w8, [x25, #0x64a]
0069FE0DC  adrp     x8, #0x8f0f000
0069FE0E0  ldr      x8, [x8, #0x9b0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_ID()
0069FE0E4  ldr      x2, [x8]
0069FE0E8  ldrb     w8, [x2, #0x53]
0069FE0EC  tbnz     w8, #5, #0x69fe0f8
0069FE0F0  str      w20, [x22, #0x11c]
0069FE0F4  b        #0x69fe108 ; 
0069FE0F8  ldr      x8, [x2, #0x60]
0069FE0FC  mov      x0, x22
0069FE100  mov      w1, w20
0069FE104  blr      x8
0069FE108  adrp     x20, #0x9599000
0069FE10C  ldrb     w8, [x20, #0xed3]
0069FE110  cbnz     w8, #0x69fe128
0069FE114  adrp     x0, #0x8f0f000
0069FE118  ldr      x0, [x0, #0x9c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_GroupId()
0069FE11C  bl       #0x382bd14 ; 
0069FE120  mov      w8, #1
0069FE124  strb     w8, [x20, #0xed3]
0069FE128  adrp     x8, #0x8f0f000
0069FE12C  ldr      x8, [x8, #0x9c0] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_GroupId()
0069FE130  ldr      x2, [x8]
0069FE134  ldrb     w8, [x2, #0x53]
0069FE138  tbnz     w8, #5, #0x69fe144
0069FE13C  str      x19, [x22, #0x120]
0069FE140  b        #0x69fe154 ; 
0069FE144  ldr      x8, [x2, #0x60]
0069FE148  mov      x0, x22
0069FE14C  mov      x1, x19
0069FE150  blr      x8
0069FE154  adrp     x19, #0x959a000
0069FE158  ldrb     w8, [x19, #0x109]
0069FE15C  cbnz     w8, #0x69fe174
0069FE160  adrp     x0, #0x8f0f000
0069FE164  ldr      x0, [x0, #0x940] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_TargetId()
0069FE168  bl       #0x382bd14 ; 
0069FE16C  mov      w8, #1
0069FE170  strb     w8, [x19, #0x109]
0069FE174  adrp     x8, #0x8f0f000
0069FE178  ldr      x8, [x8, #0x940] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_TargetId()
0069FE17C  ldr      x2, [x8]
0069FE180  ldrb     w8, [x2, #0x53]
0069FE184  tbnz     w8, #5, #0x69fe190
0069FE188  str      x29, [x22, #0xd0]
0069FE18C  b        #0x69fe1a0 ; 
0069FE190  ldr      x8, [x2, #0x60]
0069FE194  mov      x0, x22
0069FE198  mov      x1, x29
0069FE19C  blr      x8
0069FE1A0  adrp     x19, #0x9598000
0069FE1A4  ldrb     w8, [x19, #0xfcc]
0069FE1A8  cbnz     w8, #0x69fe1c0
0069FE1AC  adrp     x0, #0x8f06000
0069FE1B0  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0069FE1B4  bl       #0x382bd14 ; 
0069FE1B8  mov      w8, #1
0069FE1BC  strb     w8, [x19, #0xfcc]
0069FE1C0  adrp     x8, #0x8f06000
0069FE1C4  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0069FE1C8  ldr      x1, [x8]
0069FE1CC  ldrb     w8, [x1, #0x53]
0069FE1D0  tbnz     w8, #5, #0x69fe1dc
0069FE1D4  ldr      x19, [x24, #0x200]
0069FE1D8  b        #0x69fe1ec ; 
0069FE1DC  ldr      x8, [x1, #0x60]
0069FE1E0  mov      x0, x24
0069FE1E4  blr      x8
0069FE1E8  mov      x19, x0
0069FE1EC  cbz      x19, #0x69fe728
0069FE1F0  adrp     x20, #0x959d000
0069FE1F4  ldrb     w8, [x20, #0x64b]
0069FE1F8  cbnz     w8, #0x69fe210
0069FE1FC  adrp     x0, #0x8efb000
0069FE200  ldr      x0, [x0, #0xad0] ; GLOBAL Method$LocalModels.LocalModelManager.GetAttributeString_stringModelInstance()
0069FE204  bl       #0x382bd14 ; 
0069FE208  mov      w8, #1
0069FE20C  strb     w8, [x20, #0x64b]
0069FE210  adrp     x8, #0x8efb000
0069FE214  ldr      x8, [x8, #0xad0] ; GLOBAL Method$LocalModels.LocalModelManager.GetAttributeString_stringModelInstance()
0069FE218  ldr      x1, [x8]
0069FE21C  ldrb     w8, [x1, #0x53]
0069FE220  tbnz     w8, #5, #0x69fe22c
0069FE224  ldr      x0, [x19, #0x798]
0069FE228  b        #0x69fe238 ; 
0069FE22C  ldr      x8, [x1, #0x60]
0069FE230  mov      x0, x19
0069FE234  blr      x8
0069FE238  cbz      x0, #0x69fe728
0069FE23C  mov      x1, xzr
0069FE240  bl       #0x6521cec ; LocalModels.Model.AttributeString_stringModel$$GetAllElements
0069FE244  adrp     x20, #0x959d000
0069FE248  ldrb     w8, [x20, #0x64c]
0069FE24C  mov      x19, x0
0069FE250  cbnz     w8, #0x69fe268
0069FE254  adrp     x0, #0x8f0f000
0069FE258  ldr      x0, [x0, #0xac8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_TableData()
0069FE25C  bl       #0x382bd14 ; 
0069FE260  mov      w8, #1
0069FE264  strb     w8, [x20, #0x64c]
0069FE268  adrp     x8, #0x8f0f000
0069FE26C  ldr      x8, [x8, #0xac8] ; GLOBAL Method$HotFix.BattleLogic.BulletData.set_TableData()
0069FE270  ldr      x2, [x8]
0069FE274  ldrb     w8, [x2, #0x53]
0069FE278  tbnz     w8, #5, #0x69fe290
0069FE27C  add      x0, x22, #0x330
0069FE280  mov      x1, x23
0069FE284  str      x23, [x22, #0x330]
0069FE288  bl       #0x382bcb8 ; 
0069FE28C  b        #0x69fe2a0 ; 
0069FE290  ldr      x8, [x2, #0x60]
0069FE294  mov      x0, x22
0069FE298  mov      x1, x23
0069FE29C  blr      x8
0069FE2A0  adrp     x20, #0x9591000
0069FE2A4  ldrb     w8, [x20, #0xa72]
0069FE2A8  cbnz     w8, #0x69fe2c0
0069FE2AC  adrp     x0, #0x8ee6000
0069FE2B0  ldr      x0, [x0, #0x278] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Attribute()
0069FE2B4  bl       #0x382bd14 ; 
0069FE2B8  mov      w8, #1
0069FE2BC  strb     w8, [x20, #0xa72]
0069FE2C0  adrp     x8, #0x8ee6000
0069FE2C4  ldr      x8, [x8, #0x278] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Attribute()
0069FE2C8  ldr      x1, [x8]
0069FE2CC  ldrb     w8, [x1, #0x53]
0069FE2D0  tbnz     w8, #5, #0x69fe2dc
0069FE2D4  ldr      x29, [x22, #0x180]
0069FE2D8  b        #0x69fe2ec ; 
0069FE2DC  ldr      x8, [x1, #0x60]
0069FE2E0  mov      x0, x22
0069FE2E4  blr      x8
0069FE2E8  mov      x29, x0
0069FE2EC  adrp     x8, #0x8f22000
0069FE2F0  ldr      x8, [x8, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
0069FE2F4  ldr      x0, [x8]
0069FE2F8  ldr      w8, [x0, #0xe0]
0069FE2FC  cbnz     w8, #0x69fe304
0069FE300  bl       #0x382be8c ; 
0069FE304  mov      w2, #1
0069FE308  mov      x0, x29
0069FE30C  mov      x1, x19
0069FE310  mov      x3, xzr
0069FE314  mov      w20, #1
0069FE318  bl       #0x6b50c30 ; HotFix.Common.CommonUtils$$CreateBulletAttributeData
0069FE31C  adrp     x19, #0x959d000
0069FE320  ldrb     w8, [x19, #0x64d]
0069FE324  cbnz     w8, #0x69fe338
0069FE328  adrp     x0, #0x8f25000
0069FE32C  ldr      x0, [x0, #0x178] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_LifeTime()
0069FE330  bl       #0x382bd14 ; 
0069FE334  strb     w20, [x19, #0x64d]
0069FE338  adrp     x8, #0x8f25000
0069FE33C  ldr      x8, [x8, #0x178] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_LifeTime()
0069FE340  ldr      x1, [x8]
0069FE344  ldrb     w8, [x1, #0x53]
0069FE348  tbnz     w8, #5, #0x69fe354
0069FE34C  ldr      x0, [x23, #0x40]
0069FE350  b        #0x69fe360 ; 
0069FE354  ldr      x8, [x1, #0x60]
0069FE358  mov      x0, x23
0069FE35C  blr      x8
0069FE360  ldp      x9, x8, [x28, #0x30]
0069FE364  stp      xzr, xzr, [sp, #0x108]
0069FE368  adrp     x10, #0x8ee6000
0069FE36C  ldr      x10, [x10, #0x1b8] ; GLOBAL Bullet_LifeTime
0069FE370  add      x8, x8, x0
0069FE374  add      x9, x9, #0x10, lsl #12
0069FE378  mul      x8, x9, x8
0069FE37C  ldr      x1, [x10]
0069FE380  asr      x2, x8, #0x10
0069FE384  add      x0, sp, #0x108
0069FE388  mov      x3, xzr
0069FE38C  str      xzr, [sp, #0x118]
0069FE390  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
0069FE394  cbz      x29, #0x69fe728
0069FE398  add      x8, sp, #9
0069FE39C  ldur     q0, [x8, #0xff]
0069FE3A0  ldr      x8, [sp, #0x118]
0069FE3A4  add      x1, sp, #0xf0
0069FE3A8  mov      x0, x29
0069FE3AC  mov      w2, wzr
0069FE3B0  mov      x3, xzr
0069FE3B4  str      q0, [sp, #0xf0]
0069FE3B8  str      x8, [sp, #0x100]
0069FE3BC  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
0069FE3C0  adrp     x8, #0x8f0f000
0069FE3C4  ldr      x8, [x8, #0xd08] ; GLOBAL Attack%
0069FE3C8  add      x0, sp, #0xd8
0069FE3CC  mov      x2, x27
0069FE3D0  mov      x3, xzr
0069FE3D4  ldr      x1, [x8]
0069FE3D8  stp      xzr, xzr, [sp, #0xd8]
0069FE3DC  str      xzr, [sp, #0xe8]
0069FE3E0  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
0069FE3E4  ldur     q0, [sp, #0xd8]
0069FE3E8  ldr      x8, [sp, #0xe8]
0069FE3EC  add      x1, sp, #0xc0
0069FE3F0  mov      x0, x29
0069FE3F4  mov      w2, wzr
0069FE3F8  mov      x3, xzr
0069FE3FC  str      q0, [sp, #0xc0]
0069FE400  str      x8, [sp, #0xd0]
0069FE404  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
0069FE408  adrp     x19, #0x959d000
0069FE40C  ldrb     w8, [x19, #0x61]
0069FE410  cbnz     w8, #0x69fe428
0069FE414  adrp     x0, #0x8f25000
0069FE418  ldr      x0, [x0, #0x1c0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_MoveSpeed()
0069FE41C  bl       #0x382bd14 ; 
0069FE420  mov      w8, #1
0069FE424  strb     w8, [x19, #0x61]
0069FE428  adrp     x8, #0x8f25000
0069FE42C  ldr      x8, [x8, #0x1c0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_MoveSpeed()
0069FE430  ldr      x1, [x8]
0069FE434  ldrb     w8, [x1, #0x53]
0069FE438  tbnz     w8, #5, #0x69fe444
0069FE43C  ldr      x0, [x23, #0x68]
0069FE440  b        #0x69fe450 ; 
0069FE444  ldr      x8, [x1, #0x60]
0069FE448  mov      x0, x23
0069FE44C  blr      x8
0069FE450  adrp     x19, #0x8ee6000
0069FE454  ldp      x8, x9, [sp, #0x50]
0069FE458  ldr      x19, [x19, #0x1a8] ; GLOBAL BulletSpeed
0069FE45C  mov      x3, xzr
0069FE460  stp      xzr, xzr, [sp, #0xa8]
0069FE464  add      x8, x0, x8
0069FE468  ldr      x1, [x19]
0069FE46C  add      x9, x9, #0x10, lsl #12
0069FE470  mul      x8, x8, x9
0069FE474  asr      x2, x8, #0x10
0069FE478  add      x0, sp, #0xa8
0069FE47C  str      xzr, [sp, #0xb8]
0069FE480  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
0069FE484  ldur     q0, [sp, #0xa8]
0069FE488  ldr      x8, [sp, #0xb8]
0069FE48C  add      x1, sp, #0x90
0069FE490  mov      x0, x29
0069FE494  mov      w2, wzr
0069FE498  mov      x3, xzr
0069FE49C  str      q0, [sp, #0x90]
0069FE4A0  str      x8, [sp, #0xa0]
0069FE4A4  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
0069FE4A8  adrp     x20, #0x959d000
0069FE4AC  ldrb     w8, [x20, #0x64e]
0069FE4B0  cbnz     w8, #0x69fe4c8
0069FE4B4  adrp     x0, #0x8f25000
0069FE4B8  ldr      x0, [x0, #0x1d0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_RotateSpeed()
0069FE4BC  bl       #0x382bd14 ; 
0069FE4C0  mov      w8, #1
0069FE4C4  strb     w8, [x20, #0x64e]
0069FE4C8  adrp     x8, #0x8f25000
0069FE4CC  ldr      x8, [x8, #0x1d0] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_RotateSpeed()
0069FE4D0  ldr      x1, [x8]
0069FE4D4  ldrb     w8, [x1, #0x53]
0069FE4D8  tbnz     w8, #5, #0x69fe4e4
0069FE4DC  ldr      x0, [x23, #0x70]
0069FE4E0  b        #0x69fe4f0 ; 
0069FE4E4  ldr      x8, [x1, #0x60]
0069FE4E8  mov      x0, x23
0069FE4EC  blr      x8
0069FE4F0  adrp     x9, #0x8f0b000
0069FE4F4  ldr      x9, [x9, #0xe50] ; GLOBAL RotateSpeed
0069FE4F8  add      x8, x21, #0x10, lsl #12
0069FE4FC  mul      x8, x0, x8
0069FE500  asr      x2, x8, #0x10
0069FE504  ldr      x1, [x9]
0069FE508  add      x0, sp, #0x78
0069FE50C  mov      x3, xzr
0069FE510  stp      xzr, xzr, [sp, #0x78]
0069FE514  str      xzr, [sp, #0x88]
0069FE518  bl       #0x6b41044 ; HotFix.Common.AttributeOneElement$$.ctor
0069FE51C  ldur     q0, [sp, #0x78]
0069FE520  ldr      x8, [sp, #0x88]
0069FE524  add      x1, sp, #0x60
0069FE528  mov      x0, x29
0069FE52C  mov      w2, wzr
0069FE530  mov      x3, xzr
0069FE534  str      q0, [sp, #0x60]
0069FE538  str      x8, [sp, #0x70]
0069FE53C  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
0069FE540  ldr      w8, [x24, #0x1c8]
0069FE544  cmp      w8, #5
0069FE548  b.ne     #0x69fe574
0069FE54C  ldr      x1, [x19]
0069FE550  mov      x0, x29
0069FE554  mov      x2, xzr
0069FE558  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
0069FE55C  ldr      x8, [x29]
0069FE560  ldr      x1, [x19]
0069FE564  asr      x2, x0, #1
0069FE568  mov      x0, x29
0069FE56C  ldp      x9, x3, [x8, #0x178]
0069FE570  blr      x9
0069FE574  adrp     x19, #0x959d000
0069FE578  ldrb     w8, [x19, #0x64f]
0069FE57C  cbnz     w8, #0x69fe594
0069FE580  adrp     x0, #0x8f25000
0069FE584  ldr      x0, [x0, #0x330] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_HitCamp()
0069FE588  bl       #0x382bd14 ; 
0069FE58C  mov      w8, #1
0069FE590  strb     w8, [x19, #0x64f]
0069FE594  adrp     x8, #0x8f25000
0069FE598  ldr      x8, [x8, #0x330] ; GLOBAL Method$LocalModels.Bean.Bullet_Bullet.get_HitCamp()
0069FE59C  ldr      x1, [x8]
0069FE5A0  ldrb     w8, [x1, #0x53]
0069FE5A4  tbnz     w8, #5, #0x69fe5b0
0069FE5A8  ldr      x0, [x23, #0xf8]
0069FE5AC  b        #0x69fe5bc ; 
0069FE5B0  ldr      x8, [x1, #0x60]
0069FE5B4  mov      x0, x23
0069FE5B8  blr      x8
0069FE5BC  cbz      x0, #0x69fe728
0069FE5C0  ldr      x9, [x0, #0x18]
0069FE5C4  cmp      w9, #1
0069FE5C8  b.lt     #0x69fe5ec
0069FE5CC  mov      w8, wzr
0069FE5D0  and      x9, x9, #0xffffffff
0069FE5D4  add      x10, x0, #0x20
0069FE5D8  ldr      w11, [x10], #4
0069FE5DC  subs     x9, x9, #1
0069FE5E0  orr      w8, w11, w8
0069FE5E4  b.ne     #0x69fe5d8
0069FE5E8  b        #0x69fe5f0 ; 
0069FE5EC  mov      w8, wzr
0069FE5F0  str      w8, [x22, #0x32c]
0069FE5F4  adrp     x9, #0x8f17000
0069FE5F8  ldr      x8, [x29]
0069FE5FC  ldr      x9, [x9, #0xb80] ; GLOBAL CritValue%
0069FE600  mov      x0, x29
0069FE604  mov      x2, xzr
0069FE608  ldr      x1, [x9]
0069FE60C  ldp      x9, x3, [x8, #0x178]
0069FE610  blr      x9
0069FE614  adrp     x9, #0x8f32000
0069FE618  ldr      x8, [x29]
0069FE61C  ldr      x9, [x9, #0x4a8] ; GLOBAL SuperCritValue%
0069FE620  mov      x0, x29
0069FE624  mov      x2, xzr
0069FE628  ldr      x1, [x9]
0069FE62C  ldp      x9, x3, [x8, #0x178]
0069FE630  blr      x9
0069FE634  adrp     x9, #0x8f17000
0069FE638  ldr      x8, [x29]
0069FE63C  ldr      x9, [x9, #0xb78] ; GLOBAL CritRate%
0069FE640  mov      x0, x29
0069FE644  mov      x2, xzr
0069FE648  ldr      x1, [x9]
0069FE64C  ldp      x9, x3, [x8, #0x178]
0069FE650  blr      x9
0069FE654  adrp     x9, #0x8f32000
0069FE658  ldr      x8, [x29]
0069FE65C  ldr      x9, [x9, #0x4b0] ; GLOBAL SuperCritRate%
0069FE660  mov      x0, x29
0069FE664  mov      x2, xzr
0069FE668  ldr      x1, [x9]
0069FE66C  ldp      x9, x3, [x8, #0x178]
0069FE670  blr      x9
0069FE674  ldr      x1, [sp, #0x38]
0069FE678  mov      x0, x22
0069FE67C  mov      x2, xzr
0069FE680  bl       #0x6677434 ; HotFix.BattleLogic.BulletData$$Init
0069FE684  ldr      x9, [sp, #0x40]
0069FE688  ldr      x8, [x22, #0x288]
0069FE68C  adrp     x19, #0x959d000
0069FE690  add      x9, x9, #0x10, lsl #12
0069FE694  mul      x8, x8, x9
0069FE698  asr      x8, x8, #0x10
0069FE69C  str      x8, [x22, #0x288]
0069FE6A0  ldrb     w8, [x19, #0x650]
0069FE6A4  cbnz     w8, #0x69fe6bc
0069FE6A8  adrp     x0, #0x8f32000
0069FE6AC  ldr      x0, [x0, #0x4b8] ; GLOBAL Method$HotFix.EntityData.set_WeaponSkin()
0069FE6B0  bl       #0x382bd14 ; 
0069FE6B4  mov      w8, #1
0069FE6B8  strb     w8, [x19, #0x650]
0069FE6BC  adrp     x8, #0x8f32000
0069FE6C0  ldr      x8, [x8, #0x4b8] ; GLOBAL Method$HotFix.EntityData.set_WeaponSkin()
0069FE6C4  ldr      x1, [sp, #0x30]
0069FE6C8  ldr      x2, [x8]
0069FE6CC  ldrb     w8, [x2, #0x53]
0069FE6D0  tbnz     w8, #5, #0x69fe6e4
0069FE6D4  mov      x0, x22
0069FE6D8  str      x1, [x0, #0x28]!
0069FE6DC  bl       #0x382bcb8 ; 
0069FE6E0  b        #0x69fe6f0 ; 
0069FE6E4  ldr      x8, [x2, #0x60]
0069FE6E8  mov      x0, x22
0069FE6EC  blr      x8
0069FE6F0  ldr      x8, [sp, #0x48]
0069FE6F4  ldr      x8, [x8, #0x28]
0069FE6F8  ldr      x9, [sp, #0x188]
0069FE6FC  cmp      x8, x9
0069FE700  b.ne     #0x69fe72c
0069FE704  mov      x0, x22
0069FE708  ldp      x20, x19, [sp, #0x1e0]
0069FE70C  ldp      x22, x21, [sp, #0x1d0]
0069FE710  ldp      x24, x23, [sp, #0x1c0]
0069FE714  ldp      x26, x25, [sp, #0x1b0]
0069FE718  ldp      x28, x27, [sp, #0x1a0]
0069FE71C  ldp      x29, x30, [sp, #0x190]
0069FE720  add      sp, sp, #0x1f0
0069FE724  ret      
0069FE728  bl       #0x382bfb8 ; 
0069FE72C  bl       #0x89edb60 ; 

