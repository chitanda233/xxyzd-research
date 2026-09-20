; HotFix.BattleLogic.DankeSkillCreator$$OnInitRandoms
; RVA 0x685CC70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685CC70  stp      x30, x21, [sp, #-0x20]!
00685CC74  stp      x20, x19, [sp, #0x10]
00685CC78  adrp     x20, #0x959b000
00685CC7C  adrp     x21, #0x8f23000
00685CC80  ldrb     w8, [x20, #0x9e7]
00685CC84  ldr      x21, [x21, #0xb00] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OnInitRandoms() @ 0x9259dd0
00685CC88  mov      x19, x0
00685CC8C  tbnz     w8, #0, #0x685ccbc
00685CC90  adrp     x0, #0x8f23000
00685CC94  ldr      x0, [x0, #0xb00] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OnInitRandoms() @ 0x9259dd0
00685CC98  bl       #0x382bd14 ; 
00685CC9C  adrp     x0, #0x8f23000
00685CCA0  ldr      x0, [x0, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
00685CCA4  bl       #0x382bd14 ; 
00685CCA8  adrp     x0, #0x8f23000
00685CCAC  ldr      x0, [x0, #0xb10] ; GLOBAL HotFix.BattleLogic.WeightRandom_TypeInfo @ 0x91f4c70
00685CCB0  bl       #0x382bd14 ; 
00685CCB4  mov      w8, #1
00685CCB8  strb     w8, [x20, #0x9e7]
00685CCBC  ldr      x1, [x21]
00685CCC0  ldrb     w8, [x1, #0x53]
00685CCC4  tbnz     w8, #5, #0x685cdc8
00685CCC8  adrp     x21, #0x8f23000
00685CCCC  ldr      x21, [x21, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
00685CCD0  adrp     x20, #0x8f23000
00685CCD4  mov      w1, #4
00685CCD8  ldr      x0, [x21]
00685CCDC  ldr      x20, [x20, #0xb10] ; GLOBAL HotFix.BattleLogic.WeightRandom_TypeInfo @ 0x91f4c70
00685CCE0  bl       #0x382bdfc ; 
00685CCE4  mov      x1, x0
00685CCE8  mov      x0, x19
00685CCEC  str      x1, [x0, #0x48]!
00685CCF0  bl       #0x382bcb8 ; 
00685CCF4  ldr      x0, [x21]
00685CCF8  mov      w1, #4
00685CCFC  bl       #0x382bdfc ; 
00685CD00  mov      x1, x0
00685CD04  mov      x0, x19
00685CD08  str      x1, [x0, #0x18]!
00685CD0C  bl       #0x382bcb8 ; 
00685CD10  ldr      x0, [x21]
00685CD14  mov      w1, #4
00685CD18  bl       #0x382bdfc ; 
00685CD1C  mov      x1, x0
00685CD20  mov      x0, x19
00685CD24  str      x1, [x0, #0x20]!
00685CD28  bl       #0x382bcb8 ; 
00685CD2C  ldr      x0, [x21]
00685CD30  mov      w1, #4
00685CD34  bl       #0x382bdfc ; 
00685CD38  mov      x1, x0
00685CD3C  mov      x0, x19
00685CD40  str      x1, [x0, #0x30]!
00685CD44  bl       #0x382bcb8 ; 
00685CD48  ldr      x0, [x21]
00685CD4C  mov      w1, #4
00685CD50  bl       #0x382bdfc ; 
00685CD54  mov      x1, x0
00685CD58  mov      x0, x19
00685CD5C  str      x1, [x0, #0x38]!
00685CD60  bl       #0x382bcb8 ; 
00685CD64  ldr      x0, [x21]
00685CD68  mov      w1, #4
00685CD6C  bl       #0x382bdfc ; 
00685CD70  mov      x1, x0
00685CD74  mov      x0, x19
00685CD78  str      x1, [x0, #0x28]!
00685CD7C  bl       #0x382bcb8 ; 
00685CD80  ldr      x0, [x21]
00685CD84  mov      w1, #4
00685CD88  bl       #0x382bdfc ; 
00685CD8C  mov      x1, x0
00685CD90  mov      x0, x19
00685CD94  str      x1, [x0, #0x50]!
00685CD98  bl       #0x382bcb8 ; 
00685CD9C  ldr      x0, [x20]
00685CDA0  bl       #0x382bfa0 ; 
00685CDA4  mov      x1, xzr
00685CDA8  mov      x20, x0
00685CDAC  bl       #0x66365c8 ; HotFix.BattleLogic.WeightRandom$$.ctor
00685CDB0  str      x20, [x19, #0x98]!
00685CDB4  mov      x0, x19
00685CDB8  mov      x1, x20
00685CDBC  ldp      x20, x19, [sp, #0x10]
00685CDC0  ldp      x30, x21, [sp], #0x20
00685CDC4  b        #0x382bcb8 ; 
00685CDC8  ldr      x2, [x1, #0x60]
00685CDCC  mov      x0, x19
00685CDD0  ldp      x20, x19, [sp, #0x10]
00685CDD4  ldp      x30, x21, [sp], #0x20
00685CDD8  br       x2

