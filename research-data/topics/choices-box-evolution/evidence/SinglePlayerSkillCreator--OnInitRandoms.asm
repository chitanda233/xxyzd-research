; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnInitRandoms
; RVA 0x6875AAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006875AAC  stp      x30, x21, [sp, #-0x20]!
006875AB0  stp      x20, x19, [sp, #0x10]
006875AB4  adrp     x20, #0x959b000
006875AB8  adrp     x21, #0x8f24000
006875ABC  ldrb     w8, [x20, #0xaaa]
006875AC0  ldr      x21, [x21, #0x510] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnInitRandoms() @ 0x92aa9b8
006875AC4  mov      x19, x0
006875AC8  tbnz     w8, #0, #0x6875af8
006875ACC  adrp     x0, #0x8ee8000
006875AD0  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006875AD4  bl       #0x382bd14 ; 
006875AD8  adrp     x0, #0x8f24000
006875ADC  ldr      x0, [x0, #0x510] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnInitRandoms() @ 0x92aa9b8
006875AE0  bl       #0x382bd14 ; 
006875AE4  adrp     x0, #0x8f23000
006875AE8  ldr      x0, [x0, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
006875AEC  bl       #0x382bd14 ; 
006875AF0  mov      w8, #1
006875AF4  strb     w8, [x20, #0xaaa]
006875AF8  ldr      x1, [x21]
006875AFC  ldrb     w8, [x1, #0x53]
006875B00  tbnz     w8, #5, #0x6875be8
006875B04  adrp     x21, #0x8ee8000
006875B08  adrp     x20, #0x8f23000
006875B0C  ldr      x21, [x21, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006875B10  ldr      x20, [x20, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
006875B14  mov      x0, x19
006875B18  bl       #0x6871dc0 ; HotFix.BattleLogic.HeroSkillCreator$$OnInitRandoms
006875B1C  ldr      x0, [x21]
006875B20  ldr      w8, [x0, #0xe0]
006875B24  cbnz     w8, #0x6875b30
006875B28  bl       #0x382be8c ; 
006875B2C  ldr      x0, [x21]
006875B30  ldr      x8, [x0, #0xb8]
006875B34  ldr      x0, [x20]
006875B38  ldr      w1, [x8, #0x2f0]
006875B3C  bl       #0x382bdfc ; 
006875B40  mov      x1, x0
006875B44  mov      x0, x19
006875B48  str      x1, [x0, #0x18]!
006875B4C  bl       #0x382bcb8 ; 
006875B50  ldr      x8, [x21]
006875B54  ldr      x0, [x20]
006875B58  ldr      x8, [x8, #0xb8]
006875B5C  ldr      w1, [x8, #0x2f0]
006875B60  bl       #0x382bdfc ; 
006875B64  mov      x1, x0
006875B68  mov      x0, x19
006875B6C  str      x1, [x0, #0x20]!
006875B70  bl       #0x382bcb8 ; 
006875B74  ldr      x8, [x21]
006875B78  ldr      x0, [x20]
006875B7C  ldr      x8, [x8, #0xb8]
006875B80  ldr      w1, [x8, #0x2f0]
006875B84  bl       #0x382bdfc ; 
006875B88  mov      x1, x0
006875B8C  mov      x0, x19
006875B90  str      x1, [x0, #0x30]!
006875B94  bl       #0x382bcb8 ; 
006875B98  ldr      x8, [x21]
006875B9C  ldr      x0, [x20]
006875BA0  ldr      x8, [x8, #0xb8]
006875BA4  ldr      w1, [x8, #0x2f0]
006875BA8  bl       #0x382bdfc ; 
006875BAC  mov      x1, x0
006875BB0  mov      x0, x19
006875BB4  str      x1, [x0, #0x38]!
006875BB8  bl       #0x382bcb8 ; 
006875BBC  ldr      x8, [x21]
006875BC0  ldr      x0, [x20]
006875BC4  ldr      x8, [x8, #0xb8]
006875BC8  ldr      w1, [x8, #0x2f0]
006875BCC  bl       #0x382bdfc ; 
006875BD0  str      x0, [x19, #0x28]!
006875BD4  mov      x1, x0
006875BD8  mov      x0, x19
006875BDC  ldp      x20, x19, [sp, #0x10]
006875BE0  ldp      x30, x21, [sp], #0x20
006875BE4  b        #0x382bcb8 ; 
006875BE8  ldr      x2, [x1, #0x60]
006875BEC  mov      x0, x19
006875BF0  ldp      x20, x19, [sp, #0x10]
006875BF4  ldp      x30, x21, [sp], #0x20
006875BF8  br       x2

