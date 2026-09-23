; HotFix.BattleLogic.BattleLogicWorld$$InitBaseBattleData
; RVA 0x6A2EED4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A2EED4  stp      x30, x23, [sp, #-0x30]!
006A2EED8  stp      x22, x21, [sp, #0x10]
006A2EEDC  stp      x20, x19, [sp, #0x20]
006A2EEE0  adrp     x22, #0x959d000
006A2EEE4  adrp     x23, #0x8f33000
006A2EEE8  ldrb     w8, [x22, #0x70d]
006A2EEEC  ldr      x23, [x23, #0xc80]
006A2EEF0  mov      x19, x2
006A2EEF4  mov      w20, w1
006A2EEF8  mov      x21, x0
006A2EEFC  tbnz     w8, #0, #0x6a2ef20
006A2EF00  adrp     x0, #0x8f33000
006A2EF04  ldr      x0, [x0, #0xc80]
006A2EF08  bl       #0x382bd14 ;
006A2EF0C  adrp     x0, #0x8ee8000
006A2EF10  ldr      x0, [x0, #0x898]
006A2EF14  bl       #0x382bd14 ;
006A2EF18  mov      w8, #1
006A2EF1C  strb     w8, [x22, #0x70d]
006A2EF20  ldr      x3, [x23]
006A2EF24  ldrb     w8, [x3, #0x53]
006A2EF28  tbnz     w8, #5, #0x6a2ef88
006A2EF2C  ldr      x8, [x21, #0x10]
006A2EF30  cbz      x8, #0x6a2efa8
006A2EF34  str      w20, [x8, #0x1c8]
006A2EF38  cbz      x19, #0x6a2ef40
006A2EF3C  ldr      x19, [x19, #0x20]
006A2EF40  adrp     x8, #0x8ee8000
006A2EF44  ldr      x8, [x8, #0x898]
006A2EF48  ldr      x0, [x8]
006A2EF4C  ldr      w8, [x0, #0xe0]
006A2EF50  cbnz     w8, #0x6a2ef58
006A2EF54  bl       #0x382be8c ;
006A2EF58  mov      x0, x19
006A2EF5C  mov      x1, xzr
006A2EF60  bl       #0x64cb414 ; LocalModels.Const$$SetSkillABTest
006A2EF64  mov      x0, x19
006A2EF68  mov      x1, xzr
006A2EF6C  bl       #0x64cc15c ; LocalModels.Const$$SetInitRoleABTest
006A2EF70  mov      x0, x19
006A2EF74  ldp      x20, x19, [sp, #0x20]
006A2EF78  ldp      x22, x21, [sp, #0x10]
006A2EF7C  mov      x1, xzr
006A2EF80  ldp      x30, x23, [sp], #0x30
006A2EF84  b        #0x64cbb08 ; LocalModels.Const$$SetMissionABTest
006A2EF88  ldr      x4, [x3, #0x60]
006A2EF8C  mov      x0, x21
006A2EF90  mov      w1, w20
006A2EF94  mov      x2, x19
006A2EF98  ldp      x20, x19, [sp, #0x20]
006A2EF9C  ldp      x22, x21, [sp, #0x10]
006A2EFA0  ldp      x30, x23, [sp], #0x30
006A2EFA4  br       x4
006A2EFA8  bl       #0x382bfb8 ;
