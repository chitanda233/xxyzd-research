; HotFix.BattleLogic.BaseHeroDieState$$OnEnter
; RVA 0x659BD28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659BD28  str      x30, [sp, #-0x60]!
00659BD2C  stp      x28, x27, [sp, #0x10]
00659BD30  stp      x26, x25, [sp, #0x20]
00659BD34  stp      x24, x23, [sp, #0x30]
00659BD38  stp      x22, x21, [sp, #0x40]
00659BD3C  stp      x20, x19, [sp, #0x50]
00659BD40  adrp     x21, #0x9599000
00659BD44  adrp     x22, #0x8f08000
00659BD48  ldrb     w8, [x21, #0x30f]
00659BD4C  ldr      x22, [x22, #0xe78] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.OnEnter() @ 0x923b230
00659BD50  mov      x20, x1
00659BD54  mov      x19, x0
00659BD58  tbnz     w8, #0, #0x659bd94
00659BD5C  adrp     x0, #0x8f08000
00659BD60  ldr      x0, [x0, #0xe78] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.OnEnter() @ 0x923b230
00659BD64  bl       #0x382bd14 ; 
00659BD68  adrp     x0, #0x8ee6000
00659BD6C  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659BD70  bl       #0x382bd14 ; 
00659BD74  adrp     x0, #0x8f08000
00659BD78  ldr      x0, [x0, #0xe80] ; GLOBAL BaseHeroDieState @ 0x92f2948
00659BD7C  bl       #0x382bd14 ; 
00659BD80  adrp     x0, #0x8f07000
00659BD84  ldr      x0, [x0, #0xec0] ; GLOBAL Death @ 0x92f97c0
00659BD88  bl       #0x382bd14 ; 
00659BD8C  mov      w8, #1
00659BD90  strb     w8, [x21, #0x30f]
00659BD94  ldr      x2, [x22]
00659BD98  ldrb     w8, [x2, #0x53]
00659BD9C  tbnz     w8, #5, #0x659bdf0
00659BDA0  ldr      x0, [x19, #0x18]
00659BDA4  mov      w8, #1
00659BDA8  str      w8, [x19, #0x24]
00659BDAC  cbz      x0, #0x659c1b0
00659BDB0  adrp     x8, #0x8f07000
00659BDB4  ldr      x8, [x8, #0xec0] ; GLOBAL Death @ 0x92f97c0
00659BDB8  mov      x2, xzr
00659BDBC  ldr      x1, [x8]
00659BDC0  bl       #0x67dcd04 ; HotFix.BattleLogic.EntityCharacter$$GetAnimLength
00659BDC4  ldr      x0, [x19, #0x18]
00659BDC8  mov      w8, #0xcccc
00659BDCC  str      x8, [x19, #0x28]
00659BDD0  cbz      x0, #0x659c1b0
00659BDD4  adrp     x26, #0x8ee6000
00659BDD8  ldr      x26, [x26, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659BDDC  ldr      x1, [x26]
00659BDE0  ldrb     w8, [x1, #0x53]
00659BDE4  tbnz     w8, #5, #0x659be18
00659BDE8  ldr      x20, [x0, #0x38]
00659BDEC  b        #0x659be24 ; 
00659BDF0  ldr      x3, [x2, #0x60]
00659BDF4  mov      x0, x19
00659BDF8  mov      x1, x20
00659BDFC  ldp      x20, x19, [sp, #0x50]
00659BE00  ldp      x22, x21, [sp, #0x40]
00659BE04  ldp      x24, x23, [sp, #0x30]
00659BE08  ldp      x26, x25, [sp, #0x20]
00659BE0C  ldp      x28, x27, [sp, #0x10]
00659BE10  ldr      x30, [sp], #0x60
00659BE14  br       x3
00659BE18  ldr      x8, [x1, #0x60]
00659BE1C  blr      x8
00659BE20  mov      x20, x0
00659BE24  cbz      x20, #0x659c1b0
00659BE28  adrp     x25, #0x9591000
00659BE2C  ldrb     w8, [x25, #0xa7f]
00659BE30  cbnz     w8, #0x659be48
00659BE34  adrp     x0, #0x8ee6000
00659BE38  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00659BE3C  bl       #0x382bd14 ; 
00659BE40  mov      w8, #1
00659BE44  strb     w8, [x25, #0xa7f]
00659BE48  adrp     x27, #0x8ee6000
00659BE4C  ldr      x27, [x27, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00659BE50  ldr      x1, [x27]
00659BE54  ldrb     w8, [x1, #0x53]
00659BE58  tbnz     w8, #5, #0x659be64
00659BE5C  ldr      x20, [x20, #0x178]
00659BE60  b        #0x659be74 ; 
00659BE64  ldr      x8, [x1, #0x60]
00659BE68  mov      x0, x20
00659BE6C  blr      x8
00659BE70  mov      x20, x0
00659BE74  adrp     x23, #0x9599000
00659BE78  ldrb     w8, [x23, #0x4b1]
00659BE7C  cbnz     w8, #0x659be94
00659BE80  adrp     x0, #0x8f08000
00659BE84  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659BE88  bl       #0x382bd14 ; 
00659BE8C  mov      w8, #1
00659BE90  strb     w8, [x23, #0x4b1]
00659BE94  adrp     x24, #0x8f08000
00659BE98  ldr      x24, [x24, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659BE9C  ldr      x1, [x24]
00659BEA0  ldrb     w8, [x1, #0x53]
00659BEA4  tbnz     w8, #5, #0x659beb0
00659BEA8  ldr      x0, [x19, #0x10]
00659BEAC  b        #0x659bebc ; 
00659BEB0  ldr      x8, [x1, #0x60]
00659BEB4  mov      x0, x19
00659BEB8  blr      x8
00659BEBC  cbz      x0, #0x659c1b0
00659BEC0  mov      w2, #0x10000
00659BEC4  mov      x1, xzr
00659BEC8  mov      x3, xzr
00659BECC  bl       #0x563860c ; 
00659BED0  ldrb     w8, [x23, #0x4b1]
00659BED4  mov      x21, x0
00659BED8  cbnz     w8, #0x659bef0
00659BEDC  adrp     x0, #0x8f08000
00659BEE0  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659BEE4  bl       #0x382bd14 ; 
00659BEE8  mov      w8, #1
00659BEEC  strb     w8, [x23, #0x4b1]
00659BEF0  ldr      x1, [x24]
00659BEF4  ldrb     w8, [x1, #0x53]
00659BEF8  tbnz     w8, #5, #0x659bf04
00659BEFC  ldr      x22, [x19, #0x10]
00659BF00  b        #0x659bf14 ; 
00659BF04  ldr      x8, [x1, #0x60]
00659BF08  mov      x0, x19
00659BF0C  blr      x8
00659BF10  mov      x22, x0
00659BF14  cbz      x22, #0x659c1b0
00659BF18  adrp     x28, #0x9599000
00659BF1C  ldrb     w8, [x28, #0x4bd]
00659BF20  cbnz     w8, #0x659bf38
00659BF24  adrp     x0, #0x8f08000
00659BF28  ldr      x0, [x0, #0xe88] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveCount() @ 0x923ff78
00659BF2C  bl       #0x382bd14 ; 
00659BF30  mov      w8, #1
00659BF34  strb     w8, [x28, #0x4bd]
00659BF38  adrp     x8, #0x8f08000
00659BF3C  ldr      x8, [x8, #0xe88] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveCount() @ 0x923ff78
00659BF40  ldr      x1, [x8]
00659BF44  ldrb     w8, [x1, #0x53]
00659BF48  tbnz     w8, #5, #0x659bf54
00659BF4C  ldr      w2, [x22, #0x2c8]
00659BF50  b        #0x659bf64 ; 
00659BF54  ldr      x8, [x1, #0x60]
00659BF58  mov      x0, x22
00659BF5C  blr      x8
00659BF60  mov      w2, w0
00659BF64  cbz      x20, #0x659c1b0
00659BF68  mov      x0, x20
00659BF6C  mov      x1, x21
00659BF70  mov      x3, xzr
00659BF74  bl       #0x6b3dd14 ; HotFix.Common.AttributeData$$GetRebornType
00659BF78  str      w0, [x19, #0x20]
00659BF7C  cbz      w0, #0x659c0a4
00659BF80  ldr      x0, [x19, #0x18]
00659BF84  cbz      x0, #0x659c1b0
00659BF88  ldr      x1, [x26]
00659BF8C  ldrb     w8, [x1, #0x53]
00659BF90  tbnz     w8, #5, #0x659bf9c
00659BF94  ldr      x20, [x0, #0x38]
00659BF98  b        #0x659bfa8 ; 
00659BF9C  ldr      x8, [x1, #0x60]
00659BFA0  blr      x8
00659BFA4  mov      x20, x0
00659BFA8  cbz      x20, #0x659c1b0
00659BFAC  ldrb     w8, [x25, #0xa7f]
00659BFB0  cbnz     w8, #0x659bfc8
00659BFB4  adrp     x0, #0x8ee6000
00659BFB8  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00659BFBC  bl       #0x382bd14 ; 
00659BFC0  mov      w8, #1
00659BFC4  strb     w8, [x25, #0xa7f]
00659BFC8  ldr      x1, [x27]
00659BFCC  ldrb     w8, [x1, #0x53]
00659BFD0  tbnz     w8, #5, #0x659bfdc
00659BFD4  ldr      x0, [x20, #0x178]
00659BFD8  b        #0x659bfe8 ; 
00659BFDC  ldr      x8, [x1, #0x60]
00659BFE0  mov      x0, x20
00659BFE4  blr      x8
00659BFE8  cbz      x0, #0x659c1b0
00659BFEC  ldr      w1, [x19, #0x20]
00659BFF0  mov      x2, xzr
00659BFF4  bl       #0x6b3de98 ; HotFix.Common.AttributeData$$ReduceReborn
00659BFF8  ldr      x20, [x19, #0x18]
00659BFFC  cbz      x20, #0x659c1b0
00659C000  adrp     x21, #0x9599000
00659C004  ldrb     w8, [x21, #0x4b0]
00659C008  cbnz     w8, #0x659c020
00659C00C  adrp     x0, #0x8f08000
00659C010  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
00659C014  bl       #0x382bd14 ; 
00659C018  mov      w8, #1
00659C01C  strb     w8, [x21, #0x4b0]
00659C020  adrp     x8, #0x8f08000
00659C024  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
00659C028  ldr      x2, [x8]
00659C02C  ldrb     w8, [x2, #0x53]
00659C030  tbnz     w8, #5, #0x659c040
00659C034  mov      w8, #1
00659C038  strb     w8, [x20, #0x648]
00659C03C  b        #0x659c050 ; 
00659C040  ldr      x8, [x2, #0x60]
00659C044  mov      w1, #1
00659C048  mov      x0, x20
00659C04C  blr      x8
00659C050  ldrb     w8, [x23, #0x4b1]
00659C054  cbnz     w8, #0x659c06c
00659C058  adrp     x0, #0x8f08000
00659C05C  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C060  bl       #0x382bd14 ; 
00659C064  mov      w8, #1
00659C068  strb     w8, [x23, #0x4b1]
00659C06C  ldr      x1, [x24]
00659C070  ldrb     w8, [x1, #0x53]
00659C074  tbnz     w8, #5, #0x659c080
00659C078  ldr      x0, [x19, #0x10]
00659C07C  b        #0x659c08c ; 
00659C080  ldr      x8, [x1, #0x60]
00659C084  mov      x0, x19
00659C088  blr      x8
00659C08C  cbz      x0, #0x659c1b0
00659C090  adrp     x8, #0x8f08000
00659C094  ldr      x8, [x8, #0xe80] ; GLOBAL BaseHeroDieState @ 0x92f2948
00659C098  mov      x2, xzr
00659C09C  ldr      x1, [x8]
00659C0A0  bl       #0x6a22a9c ; HotFix.BattleLogic.BattleWorldContext$$DisPathBattleRecordEvent
00659C0A4  ldrb     w8, [x23, #0x4b1]
00659C0A8  cbnz     w8, #0x659c0c0
00659C0AC  adrp     x0, #0x8f08000
00659C0B0  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C0B4  bl       #0x382bd14 ; 
00659C0B8  mov      w8, #1
00659C0BC  strb     w8, [x23, #0x4b1]
00659C0C0  ldr      x1, [x24]
00659C0C4  ldrb     w8, [x1, #0x53]
00659C0C8  tbnz     w8, #5, #0x659c0d4
00659C0CC  ldr      x19, [x19, #0x10]
00659C0D0  b        #0x659c0e4 ; 
00659C0D4  ldr      x8, [x1, #0x60]
00659C0D8  mov      x0, x19
00659C0DC  blr      x8
00659C0E0  mov      x19, x0
00659C0E4  cbz      x19, #0x659c1b0
00659C0E8  adrp     x20, #0x9599000
00659C0EC  ldrb     w8, [x20, #0x29b]
00659C0F0  cbnz     w8, #0x659c108
00659C0F4  adrp     x0, #0x8f08000
00659C0F8  ldr      x0, [x0, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
00659C0FC  bl       #0x382bd14 ; 
00659C100  mov      w8, #1
00659C104  strb     w8, [x20, #0x29b]
00659C108  adrp     x8, #0x8f08000
00659C10C  ldr      x8, [x8, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
00659C110  ldr      x1, [x8]
00659C114  ldrb     w8, [x1, #0x53]
00659C118  tbnz     w8, #5, #0x659c124
00659C11C  ldr      w0, [x19, #0x18c]
00659C120  b        #0x659c130 ; 
00659C124  ldr      x8, [x1, #0x60]
00659C128  mov      x0, x19
00659C12C  blr      x8
00659C130  adrp     x21, #0x9599000
00659C134  ldrb     w8, [x21, #0x4be]
00659C138  add      w20, w0, #1
00659C13C  cbnz     w8, #0x659c154
00659C140  adrp     x0, #0x8f08000
00659C144  ldr      x0, [x0, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseEntity() @ 0x9240110
00659C148  bl       #0x382bd14 ; 
00659C14C  mov      w8, #1
00659C150  strb     w8, [x21, #0x4be]
00659C154  adrp     x8, #0x8f08000
00659C158  ldr      x8, [x8, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseEntity() @ 0x9240110
00659C15C  ldr      x2, [x8]
00659C160  ldrb     w8, [x2, #0x53]
00659C164  tbnz     w8, #5, #0x659c188
00659C168  str      w20, [x19, #0x18c]
00659C16C  ldp      x20, x19, [sp, #0x50]
00659C170  ldp      x22, x21, [sp, #0x40]
00659C174  ldp      x24, x23, [sp, #0x30]
00659C178  ldp      x26, x25, [sp, #0x20]
00659C17C  ldp      x28, x27, [sp, #0x10]
00659C180  ldr      x30, [sp], #0x60
00659C184  ret      
00659C188  ldr      x3, [x2, #0x60]
00659C18C  mov      x0, x19
00659C190  mov      w1, w20
00659C194  ldp      x20, x19, [sp, #0x50]
00659C198  ldp      x22, x21, [sp, #0x40]
00659C19C  ldp      x24, x23, [sp, #0x30]
00659C1A0  ldp      x26, x25, [sp, #0x20]
00659C1A4  ldp      x28, x27, [sp, #0x10]
00659C1A8  ldr      x30, [sp], #0x60
00659C1AC  br       x3
00659C1B0  bl       #0x382bfb8 ; 

