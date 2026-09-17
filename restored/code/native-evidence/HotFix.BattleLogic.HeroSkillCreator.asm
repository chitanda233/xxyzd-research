; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
; RVA 0x685B324; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685B324  stp      x30, x21, [sp, #-0x20]!
00685B328  stp      x20, x19, [sp, #0x10]
00685B32C  adrp     x20, #0x959b000
00685B330  adrp     x21, #0x8f23000
00685B334  ldrb     w8, [x20, #0xa75]
00685B338  ldr      x21, [x21, #0x9f8]
00685B33C  mov      x19, x0
00685B340  tbnz     w8, #0, #0x685b358
00685B344  adrp     x0, #0x8f23000
00685B348  ldr      x0, [x0, #0x9f8]
00685B34C  bl       #0x382bd14 ; 
00685B350  mov      w8, #1
00685B354  strb     w8, [x20, #0xa75]
00685B358  ldr      x1, [x21]
00685B35C  ldrb     w8, [x1, #0x53]
00685B360  tbnz     w8, #5, #0x685b3b0
00685B364  ldr      x19, [x19, #0x10]
00685B368  cbz      x19, #0x685b3c4
00685B36C  adrp     x20, #0x9591000
00685B370  ldrb     w8, [x20, #0xa4b]
00685B374  cbnz     w8, #0x685b38c
00685B378  adrp     x0, #0x8ee5000
00685B37C  ldr      x0, [x0, #0xb28]
00685B380  bl       #0x382bd14 ; 
00685B384  mov      w8, #1
00685B388  strb     w8, [x20, #0xa4b]
00685B38C  adrp     x8, #0x8ee5000
00685B390  ldr      x8, [x8, #0xb28]
00685B394  ldr      x1, [x8]
00685B398  ldrb     w8, [x1, #0x53]
00685B39C  tbnz     w8, #5, #0x685b3b0
00685B3A0  ldr      x0, [x19, #0x20]
00685B3A4  ldp      x20, x19, [sp, #0x10]
00685B3A8  ldp      x30, x21, [sp], #0x20
00685B3AC  ret      
00685B3B0  ldr      x2, [x1, #0x60]
00685B3B4  mov      x0, x19
00685B3B8  ldp      x20, x19, [sp, #0x10]
00685B3BC  ldp      x30, x21, [sp], #0x20
00685B3C0  br       x2
00685B3C4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$OnInitRandoms
; RVA 0x6871DC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871DC0  stp      x30, x23, [sp, #-0x30]!
006871DC4  stp      x22, x21, [sp, #0x10]
006871DC8  stp      x20, x19, [sp, #0x20]
006871DCC  adrp     x20, #0x959b000
006871DD0  adrp     x21, #0x8f24000
006871DD4  ldrb     w8, [x20, #0xa76]
006871DD8  ldr      x21, [x21, #0x3c8]
006871DDC  mov      x19, x0
006871DE0  tbnz     w8, #0, #0x6871e28
006871DE4  adrp     x0, #0x8ee8000
006871DE8  ldr      x0, [x0, #0x898]
006871DEC  bl       #0x382bd14 ; 
006871DF0  adrp     x0, #0x8f24000
006871DF4  ldr      x0, [x0, #0x3c8]
006871DF8  bl       #0x382bd14 ; 
006871DFC  adrp     x0, #0x8f0d000
006871E00  ldr      x0, [x0, #0x48]
006871E04  bl       #0x382bd14 ; 
006871E08  adrp     x0, #0x8f23000
006871E0C  ldr      x0, [x0, #0xb08]
006871E10  bl       #0x382bd14 ; 
006871E14  adrp     x0, #0x8f23000
006871E18  ldr      x0, [x0, #0xb10]
006871E1C  bl       #0x382bd14 ; 
006871E20  mov      w8, #1
006871E24  strb     w8, [x20, #0xa76]
006871E28  ldr      x1, [x21]
006871E2C  ldrb     w8, [x1, #0x53]
006871E30  tbnz     w8, #5, #0x6871ee8
006871E34  adrp     x22, #0x8ee8000
006871E38  ldr      x22, [x22, #0x898]
006871E3C  adrp     x23, #0x8f23000
006871E40  adrp     x21, #0x8f23000
006871E44  adrp     x20, #0x8f0d000
006871E48  ldr      x0, [x22]
006871E4C  ldr      w8, [x0, #0xe0]
006871E50  ldr      x23, [x23, #0xb08]
006871E54  ldr      x21, [x21, #0xb10]
006871E58  ldr      x20, [x20, #0x48]
006871E5C  cbnz     w8, #0x6871e68
006871E60  bl       #0x382be8c ; 
006871E64  ldr      x0, [x22]
006871E68  ldr      x8, [x0, #0xb8]
006871E6C  ldr      x0, [x23]
006871E70  ldr      w1, [x8, #0x2f0]
006871E74  bl       #0x382bdfc ; 
006871E78  mov      x1, x0
006871E7C  mov      x0, x19
006871E80  str      x1, [x0, #0x48]!
006871E84  bl       #0x382bcb8 ; 
006871E88  ldr      x8, [x22]
006871E8C  ldr      x0, [x23]
006871E90  ldr      x8, [x8, #0xb8]
006871E94  ldr      w1, [x8, #0x2f0]
006871E98  bl       #0x382bdfc ; 
006871E9C  str      x0, [x19, #0x50]!
006871EA0  mov      x1, x0
006871EA4  mov      x0, x19
006871EA8  bl       #0x382bcb8 ; 
006871EAC  ldr      x0, [x21]
006871EB0  bl       #0x382bfa0 ; 
006871EB4  mov      x1, xzr
006871EB8  mov      x19, x0
006871EBC  bl       #0x66365c8 ; HotFix.BattleLogic.WeightRandom$$.ctor
006871EC0  ldr      x8, [x20]
006871EC4  mov      x1, x19
006871EC8  ldp      x22, x21, [sp, #0x10]
006871ECC  ldr      x8, [x8, #0xb8]
006871ED0  str      x19, [x8]
006871ED4  ldr      x8, [x20]
006871ED8  ldp      x20, x19, [sp, #0x20]
006871EDC  ldr      x0, [x8, #0xb8]
006871EE0  ldp      x30, x23, [sp], #0x30
006871EE4  b        #0x382bcb8 ; 
006871EE8  ldr      x2, [x1, #0x60]
006871EEC  mov      x0, x19
006871EF0  ldp      x20, x19, [sp, #0x20]
006871EF4  ldp      x22, x21, [sp, #0x10]
006871EF8  ldp      x30, x23, [sp], #0x30
006871EFC  br       x2

; HotFix.BattleLogic.HeroSkillCreator$$DoSomethingOnGuide
; RVA 0x685DE88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685DE88  stp      x30, x21, [sp, #-0x20]!
00685DE8C  stp      x20, x19, [sp, #0x10]
00685DE90  adrp     x20, #0x959b000
00685DE94  adrp     x21, #0x8f23000
00685DE98  ldrb     w8, [x20, #0xa77]
00685DE9C  ldr      x21, [x21, #0xb88]
00685DEA0  mov      x19, x0
00685DEA4  tbnz     w8, #0, #0x685debc
00685DEA8  adrp     x0, #0x8f23000
00685DEAC  ldr      x0, [x0, #0xb88]
00685DEB0  bl       #0x382bd14 ; 
00685DEB4  mov      w8, #1
00685DEB8  strb     w8, [x20, #0xa77]
00685DEBC  ldr      x1, [x21]
00685DEC0  ldrb     w8, [x1, #0x53]
00685DEC4  tbnz     w8, #5, #0x685ded4
00685DEC8  ldp      x20, x19, [sp, #0x10]
00685DECC  ldp      x30, x21, [sp], #0x20
00685DED0  ret      
00685DED4  ldr      x2, [x1, #0x60]
00685DED8  mov      x0, x19
00685DEDC  ldp      x20, x19, [sp, #0x10]
00685DEE0  ldp      x30, x21, [sp], #0x20
00685DEE4  br       x2

; HotFix.BattleLogic.HeroSkillCreator$$GetDefaultRandoms
; RVA 0x6871F00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871F00  stp      x30, x21, [sp, #-0x20]!
006871F04  stp      x20, x19, [sp, #0x10]
006871F08  adrp     x20, #0x959b000
006871F0C  adrp     x21, #0x8f24000
006871F10  ldrb     w8, [x20, #0xa78]
006871F14  ldr      x21, [x21, #0x1b0]
006871F18  mov      x19, x0
006871F1C  tbnz     w8, #0, #0x6871f34
006871F20  adrp     x0, #0x8f24000
006871F24  ldr      x0, [x0, #0x1b0]
006871F28  bl       #0x382bd14 ; 
006871F2C  mov      w8, #1
006871F30  strb     w8, [x20, #0xa78]
006871F34  ldr      x1, [x21]
006871F38  ldrb     w8, [x1, #0x53]
006871F3C  tbnz     w8, #5, #0x6871f50
006871F40  ldr      x0, [x19, #0x48]
006871F44  ldp      x20, x19, [sp, #0x10]
006871F48  ldp      x30, x21, [sp], #0x20
006871F4C  ret      
006871F50  ldr      x2, [x1, #0x60]
006871F54  mov      x0, x19
006871F58  ldp      x20, x19, [sp, #0x10]
006871F5C  ldp      x30, x21, [sp], #0x20
006871F60  br       x2

; HotFix.BattleLogic.HeroSkillCreator$$ShowDefaultRandomSkills
; RVA 0x686F820; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F820  stp      x30, x21, [sp, #-0x20]!
00686F824  stp      x20, x19, [sp, #0x10]
00686F828  adrp     x20, #0x959b000
00686F82C  adrp     x21, #0x8f24000
00686F830  ldrb     w8, [x20, #0xa79]
00686F834  ldr      x21, [x21, #0x2c8]
00686F838  mov      x19, x0
00686F83C  tbnz     w8, #0, #0x686f854
00686F840  adrp     x0, #0x8f24000
00686F844  ldr      x0, [x0, #0x2c8]
00686F848  bl       #0x382bd14 ; 
00686F84C  mov      w8, #1
00686F850  strb     w8, [x20, #0xa79]
00686F854  ldr      x1, [x21]
00686F858  ldrb     w8, [x1, #0x53]
00686F85C  tbnz     w8, #5, #0x686f874
00686F860  ldr      x8, [x19, #0x48]
00686F864  cbz      x8, #0x686f888
00686F868  ldp      x20, x19, [sp, #0x10]
00686F86C  ldp      x30, x21, [sp], #0x20
00686F870  ret      
00686F874  ldr      x2, [x1, #0x60]
00686F878  mov      x0, x19
00686F87C  ldp      x20, x19, [sp, #0x10]
00686F880  ldp      x30, x21, [sp], #0x20
00686F884  br       x2
00686F888  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$SetHeroSkillComponent
; RVA 0x6871F64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871F64  str      x30, [sp, #-0x30]!
006871F68  stp      x22, x21, [sp, #0x10]
006871F6C  stp      x20, x19, [sp, #0x20]
006871F70  adrp     x21, #0x959b000
006871F74  adrp     x22, #0x8f24000
006871F78  ldrb     w8, [x21, #0xa7a]
006871F7C  ldr      x22, [x22, #0x128]
006871F80  mov      x19, x1
006871F84  mov      x20, x0
006871F88  tbnz     w8, #0, #0x6871fa0
006871F8C  adrp     x0, #0x8f24000
006871F90  ldr      x0, [x0, #0x128]
006871F94  bl       #0x382bd14 ; 
006871F98  mov      w8, #1
006871F9C  strb     w8, [x21, #0xa7a]
006871FA0  ldr      x2, [x22]
006871FA4  ldrb     w8, [x2, #0x53]
006871FA8  tbnz     w8, #5, #0x6871fc8
006871FAC  str      x19, [x20, #0x10]!
006871FB0  mov      x0, x20
006871FB4  mov      x1, x19
006871FB8  ldp      x20, x19, [sp, #0x20]
006871FBC  ldp      x22, x21, [sp, #0x10]
006871FC0  ldr      x30, [sp], #0x30
006871FC4  b        #0x382bcb8 ; 
006871FC8  ldr      x3, [x2, #0x60]
006871FCC  mov      x0, x20
006871FD0  mov      x1, x19
006871FD4  ldp      x20, x19, [sp, #0x20]
006871FD8  ldp      x22, x21, [sp, #0x10]
006871FDC  ldr      x30, [sp], #0x30
006871FE0  br       x3

; HotFix.BattleLogic.HeroSkillCreator$$InitRandomSkill
; RVA 0x686BD20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686BD20  stp      x30, x23, [sp, #-0x30]!
00686BD24  stp      x22, x21, [sp, #0x10]
00686BD28  stp      x20, x19, [sp, #0x20]
00686BD2C  adrp     x22, #0x959b000
00686BD30  adrp     x23, #0x8f24000
00686BD34  ldrb     w8, [x22, #0xa7b]
00686BD38  ldr      x23, [x23, #0x138]
00686BD3C  mov      x21, x2
00686BD40  mov      x19, x1
00686BD44  mov      x20, x0
00686BD48  tbnz     w8, #0, #0x686bd78
00686BD4C  adrp     x0, #0x8f24000
00686BD50  ldr      x0, [x0, #0x138]
00686BD54  bl       #0x382bd14 ; 
00686BD58  adrp     x0, #0x8f0d000
00686BD5C  ldr      x0, [x0, #0x48]
00686BD60  bl       #0x382bd14 ; 
00686BD64  adrp     x0, #0x8f23000
00686BD68  ldr      x0, [x0, #0xb20]
00686BD6C  bl       #0x382bd14 ; 
00686BD70  mov      w8, #1
00686BD74  strb     w8, [x22, #0xa7b]
00686BD78  ldr      x3, [x23]
00686BD7C  ldrb     w8, [x3, #0x53]
00686BD80  tbnz     w8, #5, #0x686be08
00686BD84  mov      x0, x20
00686BD88  str      x21, [x0, #0x58]!
00686BD8C  mov      x1, x21
00686BD90  bl       #0x382bcb8 ; 
00686BD94  ldr      x8, [x20]
00686BD98  mov      x0, x20
00686BD9C  ldp      x9, x1, [x8, #0x178]
00686BDA0  blr      x9
00686BDA4  ldr      x1, [x20, #0x48]
00686BDA8  mov      x0, x20
00686BDAC  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
00686BDB0  ldr      x1, [x20, #0x50]
00686BDB4  mov      x0, x20
00686BDB8  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
00686BDBC  mov      x0, x20
00686BDC0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00686BDC4  cbz      x0, #0x686bea8
00686BDC8  adrp     x22, #0x9591000
00686BDCC  ldrb     w8, [x22, #0xa4c]
00686BDD0  mov      x21, x0
00686BDD4  cbnz     w8, #0x686bdec
00686BDD8  adrp     x0, #0x8ee5000
00686BDDC  ldr      x0, [x0, #0xb30]
00686BDE0  bl       #0x382bd14 ; 
00686BDE4  mov      w8, #1
00686BDE8  strb     w8, [x22, #0xa4c]
00686BDEC  adrp     x8, #0x8ee5000
00686BDF0  ldr      x8, [x8, #0xb30]
00686BDF4  ldr      x1, [x8]
00686BDF8  ldrb     w8, [x1, #0x53]
00686BDFC  tbnz     w8, #5, #0x686be28
00686BE00  ldr      x0, [x21, #0x210]
00686BE04  b        #0x686be34 ; 
00686BE08  ldr      x4, [x3, #0x60]
00686BE0C  mov      x0, x20
00686BE10  mov      x1, x19
00686BE14  mov      x2, x21
00686BE18  ldp      x20, x19, [sp, #0x20]
00686BE1C  ldp      x22, x21, [sp, #0x10]
00686BE20  ldp      x30, x23, [sp], #0x30
00686BE24  br       x4
00686BE28  ldr      x8, [x1, #0x60]
00686BE2C  mov      x0, x21
00686BE30  blr      x8
00686BE34  cbz      x0, #0x686bea8
00686BE38  adrp     x8, #0x8f23000
00686BE3C  ldr      x8, [x8, #0xb20]
00686BE40  ldr      x1, [x8]
00686BE44  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
00686BE48  adrp     x8, #0x8f0d000
00686BE4C  ldr      x8, [x8, #0x48]
00686BE50  mov      x1, x0
00686BE54  ldr      x9, [x8]
00686BE58  ldr      x9, [x9, #0xb8]
00686BE5C  str      x0, [x9]
00686BE60  ldr      x8, [x8]
00686BE64  ldr      x0, [x8, #0xb8]
00686BE68  bl       #0x382bcb8 ; 
00686BE6C  mov      x0, x20
00686BE70  bl       #0x687216c ; HotFix.BattleLogic.HeroSkillCreator$$BuildGroupToBaseSkillMap
00686BE74  ldr      x8, [x20]
00686BE78  mov      x0, x20
00686BE7C  ldp      x9, x1, [x8, #0x1f8]
00686BE80  blr      x9
00686BE84  ldr      x8, [x20]
00686BE88  mov      x0, x20
00686BE8C  mov      x1, x19
00686BE90  ldp      x20, x19, [sp, #0x20]
00686BE94  ldr      x3, [x8, #0x208]
00686BE98  ldr      x2, [x8, #0x210]
00686BE9C  ldp      x22, x21, [sp, #0x10]
00686BEA0  ldp      x30, x23, [sp], #0x30
00686BEA4  br       x3
00686BEA8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$DeInit
; RVA 0x686C7C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686C7C0  stp      x30, x21, [sp, #-0x20]!
00686C7C4  stp      x20, x19, [sp, #0x10]
00686C7C8  adrp     x20, #0x959b000
00686C7CC  adrp     x21, #0x8f24000
00686C7D0  ldrb     w8, [x20, #0xa7c]
00686C7D4  ldr      x21, [x21, #0x1c8]
00686C7D8  mov      x19, x0
00686C7DC  tbnz     w8, #0, #0x686c7f4
00686C7E0  adrp     x0, #0x8f24000
00686C7E4  ldr      x0, [x0, #0x1c8]
00686C7E8  bl       #0x382bd14 ; 
00686C7EC  mov      w8, #1
00686C7F0  strb     w8, [x20, #0xa7c]
00686C7F4  ldr      x1, [x21]
00686C7F8  ldrb     w8, [x1, #0x53]
00686C7FC  tbnz     w8, #5, #0x686c820
00686C800  ldr      x1, [x19, #0x48]
00686C804  mov      x0, x19
00686C808  bl       #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
00686C80C  mov      x0, xzr
00686C810  bl       #0x692d40c ; HotFix.BattleLogic.SkillTableHelper$$InvalidateCache
00686C814  ldr      x8, [x19]
00686C818  ldp      x2, x1, [x8, #0x1e8]
00686C81C  b        #0x686c824 ; 
00686C820  ldr      x2, [x1, #0x60]
00686C824  mov      x0, x19
00686C828  ldp      x20, x19, [sp, #0x10]
00686C82C  ldp      x30, x21, [sp], #0x20
00686C830  br       x2

; HotFix.BattleLogic.HeroSkillCreator$$RedistributeWeight
; RVA 0x6872310; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872310  stp      x30, x21, [sp, #-0x20]!
006872314  stp      x20, x19, [sp, #0x10]
006872318  adrp     x20, #0x959b000
00687231C  adrp     x21, #0x8f24000
006872320  ldrb     w8, [x20, #0xa7d]
006872324  ldr      x21, [x21, #0x3e8]
006872328  mov      x19, x0
00687232C  tbnz     w8, #0, #0x6872344
006872330  adrp     x0, #0x8f24000
006872334  ldr      x0, [x0, #0x3e8]
006872338  bl       #0x382bd14 ; 
00687233C  mov      w8, #1
006872340  strb     w8, [x20, #0xa7d]
006872344  ldr      x1, [x21]
006872348  ldrb     w8, [x1, #0x53]
00687234C  tbnz     w8, #5, #0x687235c
006872350  ldp      x20, x19, [sp, #0x10]
006872354  ldp      x30, x21, [sp], #0x20
006872358  ret      
00687235C  ldr      x2, [x1, #0x60]
006872360  mov      x0, x19
006872364  ldp      x20, x19, [sp, #0x10]
006872368  ldp      x30, x21, [sp], #0x20
00687236C  br       x2

; HotFix.BattleLogic.HeroSkillCreator$$AddSkillFlag
; RVA 0x686B6FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B6FC  str      x30, [sp, #-0x30]!
00686B700  stp      x22, x21, [sp, #0x10]
00686B704  stp      x20, x19, [sp, #0x20]
00686B708  adrp     x21, #0x959b000
00686B70C  adrp     x22, #0x8f24000
00686B710  ldrb     w8, [x21, #0xa7e]
00686B714  ldr      x22, [x22, #0xe8]
00686B718  mov      w19, w1
00686B71C  mov      x20, x0
00686B720  tbnz     w8, #0, #0x686b738
00686B724  adrp     x0, #0x8f24000
00686B728  ldr      x0, [x0, #0xe8]
00686B72C  bl       #0x382bd14 ; 
00686B730  mov      w8, #1
00686B734  strb     w8, [x21, #0xa7e]
00686B738  ldr      x2, [x22]
00686B73C  ldrb     w8, [x2, #0x53]
00686B740  tbnz     w8, #5, #0x686b798
00686B744  ldr      x21, [x20, #0x48]
00686B748  cbz      x21, #0x686b7b8
00686B74C  ldr      w8, [x21, #0x18]
00686B750  cmp      w8, #1
00686B754  b.lt     #0x686b78c
00686B758  mov      w22, wzr
00686B75C  cmp      w22, w8
00686B760  b.hs     #0x686b7b4
00686B764  add      x8, x21, w22, sxtw #3
00686B768  ldr      x0, [x8, #0x20]
00686B76C  cbz      x0, #0x686b7b8
00686B770  mov      w1, w19
00686B774  mov      x2, xzr
00686B778  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
00686B77C  ldr      w8, [x21, #0x18]
00686B780  add      w22, w22, #1
00686B784  cmp      w22, w8
00686B788  b.lt     #0x686b75c
00686B78C  ldr      x8, [x20]
00686B790  ldp      x3, x2, [x8, #0x1a8]
00686B794  b        #0x686b79c ; 
00686B798  ldr      x3, [x2, #0x60]
00686B79C  mov      x0, x20
00686B7A0  mov      w1, w19
00686B7A4  ldp      x20, x19, [sp, #0x20]
00686B7A8  ldp      x22, x21, [sp, #0x10]
00686B7AC  ldr      x30, [sp], #0x30
00686B7B0  br       x3
00686B7B4  bl       #0x382bfc0 ; 
00686B7B8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddSkillRejectFlag
; RVA 0x686B7BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B7BC  str      x30, [sp, #-0x30]!
00686B7C0  stp      x22, x21, [sp, #0x10]
00686B7C4  stp      x20, x19, [sp, #0x20]
00686B7C8  adrp     x21, #0x959b000
00686B7CC  adrp     x22, #0x8f24000
00686B7D0  ldrb     w8, [x21, #0xa7f]
00686B7D4  ldr      x22, [x22, #0xf0]
00686B7D8  mov      w19, w1
00686B7DC  mov      x20, x0
00686B7E0  tbnz     w8, #0, #0x686b7f8
00686B7E4  adrp     x0, #0x8f24000
00686B7E8  ldr      x0, [x0, #0xf0]
00686B7EC  bl       #0x382bd14 ; 
00686B7F0  mov      w8, #1
00686B7F4  strb     w8, [x21, #0xa7f]
00686B7F8  ldr      x2, [x22]
00686B7FC  ldrb     w8, [x2, #0x53]
00686B800  tbnz     w8, #5, #0x686b858
00686B804  ldr      x21, [x20, #0x48]
00686B808  cbz      x21, #0x686b878
00686B80C  ldr      w8, [x21, #0x18]
00686B810  cmp      w8, #1
00686B814  b.lt     #0x686b84c
00686B818  mov      w22, wzr
00686B81C  cmp      w22, w8
00686B820  b.hs     #0x686b874
00686B824  add      x8, x21, w22, sxtw #3
00686B828  ldr      x0, [x8, #0x20]
00686B82C  cbz      x0, #0x686b878
00686B830  mov      w1, w19
00686B834  mov      x2, xzr
00686B838  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
00686B83C  ldr      w8, [x21, #0x18]
00686B840  add      w22, w22, #1
00686B844  cmp      w22, w8
00686B848  b.lt     #0x686b81c
00686B84C  ldr      x8, [x20]
00686B850  ldp      x3, x2, [x8, #0x1b8]
00686B854  b        #0x686b85c ; 
00686B858  ldr      x3, [x2, #0x60]
00686B85C  mov      x0, x20
00686B860  mov      w1, w19
00686B864  ldp      x20, x19, [sp, #0x20]
00686B868  ldp      x22, x21, [sp, #0x10]
00686B86C  ldr      x30, [sp], #0x30
00686B870  br       x3
00686B874  bl       #0x382bfc0 ; 
00686B878  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddRejectSkills
; RVA 0x686B87C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B87C  str      x30, [sp, #-0x30]!
00686B880  stp      x22, x21, [sp, #0x10]
00686B884  stp      x20, x19, [sp, #0x20]
00686B888  adrp     x21, #0x959b000
00686B88C  adrp     x22, #0x8f24000
00686B890  ldrb     w8, [x21, #0xa80]
00686B894  ldr      x22, [x22, #0xf8]
00686B898  mov      x19, x1
00686B89C  mov      x20, x0
00686B8A0  tbnz     w8, #0, #0x686b8b8
00686B8A4  adrp     x0, #0x8f24000
00686B8A8  ldr      x0, [x0, #0xf8]
00686B8AC  bl       #0x382bd14 ; 
00686B8B0  mov      w8, #1
00686B8B4  strb     w8, [x21, #0xa80]
00686B8B8  ldr      x2, [x22]
00686B8BC  ldrb     w8, [x2, #0x53]
00686B8C0  tbnz     w8, #5, #0x686b918
00686B8C4  ldr      x21, [x20, #0x48]
00686B8C8  cbz      x21, #0x686b938
00686B8CC  ldr      w8, [x21, #0x18]
00686B8D0  cmp      w8, #1
00686B8D4  b.lt     #0x686b90c
00686B8D8  mov      w22, wzr
00686B8DC  cmp      w22, w8
00686B8E0  b.hs     #0x686b934
00686B8E4  add      x8, x21, w22, sxtw #3
00686B8E8  ldr      x0, [x8, #0x20]
00686B8EC  cbz      x0, #0x686b938
00686B8F0  mov      x1, x19
00686B8F4  mov      x2, xzr
00686B8F8  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
00686B8FC  ldr      w8, [x21, #0x18]
00686B900  add      w22, w22, #1
00686B904  cmp      w22, w8
00686B908  b.lt     #0x686b8dc
00686B90C  ldr      x8, [x20]
00686B910  ldp      x3, x2, [x8, #0x1d8]
00686B914  b        #0x686b91c ; 
00686B918  ldr      x3, [x2, #0x60]
00686B91C  mov      x0, x20
00686B920  mov      x1, x19
00686B924  ldp      x20, x19, [sp, #0x20]
00686B928  ldp      x22, x21, [sp, #0x10]
00686B92C  ldr      x30, [sp], #0x30
00686B930  br       x3
00686B934  bl       #0x382bfc0 ; 
00686B938  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddNewSkill
; RVA 0x686B93C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B93C  str      x30, [sp, #-0x30]!
00686B940  stp      x22, x21, [sp, #0x10]
00686B944  stp      x20, x19, [sp, #0x20]
00686B948  adrp     x21, #0x959b000
00686B94C  adrp     x22, #0x8f24000
00686B950  ldrb     w8, [x21, #0xa81]
00686B954  ldr      x22, [x22, #0x100]
00686B958  mov      w19, w1
00686B95C  mov      x20, x0
00686B960  tbnz     w8, #0, #0x686b978
00686B964  adrp     x0, #0x8f24000
00686B968  ldr      x0, [x0, #0x100]
00686B96C  bl       #0x382bd14 ; 
00686B970  mov      w8, #1
00686B974  strb     w8, [x21, #0xa81]
00686B978  ldr      x2, [x22]
00686B97C  ldrb     w8, [x2, #0x53]
00686B980  tbnz     w8, #5, #0x686b9d8
00686B984  ldr      x21, [x20, #0x48]
00686B988  cbz      x21, #0x686b9f8
00686B98C  ldr      w8, [x21, #0x18]
00686B990  cmp      w8, #1
00686B994  b.lt     #0x686b9cc
00686B998  mov      w22, wzr
00686B99C  cmp      w22, w8
00686B9A0  b.hs     #0x686b9f4
00686B9A4  add      x8, x21, w22, sxtw #3
00686B9A8  ldr      x0, [x8, #0x20]
00686B9AC  cbz      x0, #0x686b9f8
00686B9B0  mov      w1, w19
00686B9B4  mov      x2, xzr
00686B9B8  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
00686B9BC  ldr      w8, [x21, #0x18]
00686B9C0  add      w22, w22, #1
00686B9C4  cmp      w22, w8
00686B9C8  b.lt     #0x686b99c
00686B9CC  ldr      x8, [x20]
00686B9D0  ldp      x3, x2, [x8, #0x1c8]
00686B9D4  b        #0x686b9dc ; 
00686B9D8  ldr      x3, [x2, #0x60]
00686B9DC  mov      x0, x20
00686B9E0  mov      w1, w19
00686B9E4  ldp      x20, x19, [sp, #0x20]
00686B9E8  ldp      x22, x21, [sp, #0x10]
00686B9EC  ldr      x30, [sp], #0x30
00686B9F0  br       x3
00686B9F4  bl       #0x382bfc0 ; 
00686B9F8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
; RVA 0x6863690; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006863690  str      x30, [sp, #-0x30]!
006863694  stp      x22, x21, [sp, #0x10]
006863698  stp      x20, x19, [sp, #0x20]
00686369C  adrp     x21, #0x959b000
0068636A0  adrp     x22, #0x8f23000
0068636A4  ldrb     w8, [x21, #0xa82]
0068636A8  ldr      x22, [x22, #0xd50]
0068636AC  mov      x19, x1
0068636B0  mov      x20, x0
0068636B4  tbnz     w8, #0, #0x68636e4
0068636B8  adrp     x0, #0x8efd000
0068636BC  ldr      x0, [x0, #0x3b0]
0068636C0  bl       #0x382bd14 ; 
0068636C4  adrp     x0, #0x8f23000
0068636C8  ldr      x0, [x0, #0xd50]
0068636CC  bl       #0x382bd14 ; 
0068636D0  adrp     x0, #0x8f23000
0068636D4  ldr      x0, [x0, #0xa08]
0068636D8  bl       #0x382bd14 ; 
0068636DC  mov      w8, #1
0068636E0  strb     w8, [x21, #0xa82]
0068636E4  ldr      x2, [x22]
0068636E8  ldrb     w8, [x2, #0x53]
0068636EC  tbnz     w8, #5, #0x6863784
0068636F0  mov      x0, x20
0068636F4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068636F8  cbz      x0, #0x686384c
0068636FC  ldr      x0, [x0, #0x3b8]
006863700  cbz      x0, #0x6863738
006863704  adrp     x8, #0x8efd000
006863708  ldr      x8, [x8, #0x3b0]
00686370C  ldr      x9, [x0]
006863710  ldr      x8, [x8]
006863714  ldrb     w11, [x9, #0x130]
006863718  ldrb     w10, [x8, #0x130]
00686371C  cmp      w11, w10
006863720  b.lo     #0x6863738
006863724  ldr      x9, [x9, #0xc8]
006863728  add      x9, x9, x10, lsl #3
00686372C  ldur     x9, [x9, #-8]
006863730  cmp      x9, x8
006863734  b.eq     #0x68637c8
006863738  cbz      x19, #0x686384c
00686373C  adrp     x10, #0x8f23000
006863740  ldr      x8, [x19]
006863744  ldr      x10, [x10, #0xa08]
006863748  ldrh     w9, [x8, #0x12e]
00686374C  ldr      x1, [x10]
006863750  cbz      x9, #0x6863774
006863754  ldr      x10, [x8, #0xb0]
006863758  add      x10, x10, #8
00686375C  ldur     x11, [x10, #-8]
006863760  cmp      x11, x1
006863764  b.eq     #0x68637a0
006863768  subs     x9, x9, #1
00686376C  add      x10, x10, #0x10
006863770  b.ne     #0x686375c
006863774  mov      w2, #2
006863778  mov      x0, x19
00686377C  bl       #0x3a7e710 ; 
006863780  b        #0x68637b0 ; 
006863784  ldr      x3, [x2, #0x60]
006863788  mov      x0, x20
00686378C  mov      x1, x19
006863790  ldp      x20, x19, [sp, #0x20]
006863794  ldp      x22, x21, [sp, #0x10]
006863798  ldr      x30, [sp], #0x30
00686379C  br       x3
0068637A0  ldr      w9, [x10]
0068637A4  add      w9, w9, #2
0068637A8  add      x8, x8, w9, sxtw #4
0068637AC  add      x0, x8, #0x138
0068637B0  ldp      x2, x1, [x0]
0068637B4  mov      x0, x19
0068637B8  ldp      x20, x19, [sp, #0x20]
0068637BC  ldp      x22, x21, [sp, #0x10]
0068637C0  ldr      x30, [sp], #0x30
0068637C4  br       x2
0068637C8  mov      x1, xzr
0068637CC  bl       #0x68afc9c ; LocalModels.Bean.Chapter_MainChapter$$GetSkillGroupWeight
0068637D0  cbz      x19, #0x686384c
0068637D4  adrp     x10, #0x8f23000
0068637D8  ldr      x8, [x19]
0068637DC  ldr      x10, [x10, #0xa08]
0068637E0  mov      w20, w0
0068637E4  ldrh     w9, [x8, #0x12e]
0068637E8  ldr      x1, [x10]
0068637EC  cbz      x9, #0x6863810
0068637F0  ldr      x10, [x8, #0xb0]
0068637F4  add      x10, x10, #8
0068637F8  ldur     x11, [x10, #-8]
0068637FC  cmp      x11, x1
006863800  b.eq     #0x6863820
006863804  subs     x9, x9, #1
006863808  add      x10, x10, #0x10
00686380C  b.ne     #0x68637f8
006863810  mov      w2, #4
006863814  mov      x0, x19
006863818  bl       #0x3a7e710 ; 
00686381C  b        #0x6863830 ; 
006863820  ldr      w9, [x10]
006863824  add      w9, w9, #4
006863828  add      x8, x8, w9, sxtw #4
00686382C  add      x0, x8, #0x138
006863830  ldp      x3, x2, [x0]
006863834  mov      x0, x19
006863838  mov      w1, w20
00686383C  ldp      x20, x19, [sp, #0x20]
006863840  ldp      x22, x21, [sp, #0x10]
006863844  ldr      x30, [sp], #0x30
006863848  br       x3
00686384C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$RemoveRandomSkill
; RVA 0x686B9FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686B9FC  str      x30, [sp, #-0x30]!
00686BA00  stp      x22, x21, [sp, #0x10]
00686BA04  stp      x20, x19, [sp, #0x20]
00686BA08  adrp     x21, #0x959b000
00686BA0C  adrp     x22, #0x8f24000
00686BA10  ldrb     w8, [x21, #0xa83]
00686BA14  ldr      x22, [x22, #0x108]
00686BA18  mov      w19, w1
00686BA1C  mov      x20, x0
00686BA20  tbnz     w8, #0, #0x686ba38
00686BA24  adrp     x0, #0x8f24000
00686BA28  ldr      x0, [x0, #0x108]
00686BA2C  bl       #0x382bd14 ; 
00686BA30  mov      w8, #1
00686BA34  strb     w8, [x21, #0xa83]
00686BA38  ldr      x2, [x22]
00686BA3C  ldrb     w8, [x2, #0x53]
00686BA40  tbnz     w8, #5, #0x686baa0
00686BA44  ldr      x21, [x20, #0x48]
00686BA48  cbz      x21, #0x686bac0
00686BA4C  ldr      w8, [x21, #0x18]
00686BA50  cmp      w8, #1
00686BA54  b.lt     #0x686ba90
00686BA58  mov      w22, wzr
00686BA5C  cmp      w22, w8
00686BA60  b.hs     #0x686babc
00686BA64  add      x8, x21, w22, sxtw #3
00686BA68  ldr      x0, [x8, #0x20]
00686BA6C  cbz      x0, #0x686bac0
00686BA70  mov      w1, w19
00686BA74  mov      w2, wzr
00686BA78  mov      x3, xzr
00686BA7C  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
00686BA80  ldr      w8, [x21, #0x18]
00686BA84  add      w22, w22, #1
00686BA88  cmp      w22, w8
00686BA8C  b.lt     #0x686ba5c
00686BA90  ldr      x8, [x20]
00686BA94  ldr      x3, [x8, #0x218]
00686BA98  ldr      x2, [x8, #0x220]
00686BA9C  b        #0x686baa4 ; 
00686BAA0  ldr      x3, [x2, #0x60]
00686BAA4  mov      x0, x20
00686BAA8  mov      w1, w19
00686BAAC  ldp      x20, x19, [sp, #0x20]
00686BAB0  ldp      x22, x21, [sp, #0x10]
00686BAB4  ldr      x30, [sp], #0x30
00686BAB8  br       x3
00686BABC  bl       #0x382bfc0 ; 
00686BAC0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
; RVA 0x6871FE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871FE4  str      x30, [sp, #-0x60]!
006871FE8  stp      x28, x27, [sp, #0x10]
006871FEC  stp      x26, x25, [sp, #0x20]
006871FF0  stp      x24, x23, [sp, #0x30]
006871FF4  stp      x22, x21, [sp, #0x40]
006871FF8  stp      x20, x19, [sp, #0x50]
006871FFC  adrp     x21, #0x959b000
006872000  adrp     x22, #0x8f24000
006872004  ldrb     w8, [x21, #0xa84]
006872008  ldr      x22, [x22, #0x3d0]
00687200C  mov      x19, x1
006872010  mov      x20, x0
006872014  tbnz     w8, #0, #0x6872038
006872018  adrp     x0, #0x8f24000
00687201C  ldr      x0, [x0, #0x3d0]
006872020  bl       #0x382bd14 ; 
006872024  adrp     x0, #0x8f23000
006872028  ldr      x0, [x0, #0xb20]
00687202C  bl       #0x382bd14 ; 
006872030  mov      w8, #1
006872034  strb     w8, [x21, #0xa84]
006872038  ldr      x2, [x22]
00687203C  ldrb     w8, [x2, #0x53]
006872040  tbnz     w8, #5, #0x6872130
006872044  cbz      x19, #0x6872158
006872048  ldr      w8, [x19, #0x18]
00687204C  cmp      w8, #1
006872050  b.lt     #0x6872114
006872054  adrp     x21, #0x8ee5000
006872058  adrp     x28, #0x8f23000
00687205C  ldr      x21, [x21, #0xb30]
006872060  ldr      x28, [x28, #0xb20]
006872064  mov      x23, xzr
006872068  mov      x24, xzr
00687206C  add      x25, x19, #0x20
006872070  adrp     x26, #0x9591000
006872074  mov      w27, #1
006872078  mov      x0, x20
00687207C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006872080  cbz      x0, #0x6872158
006872084  ldrb     w8, [x26, #0xa4c]
006872088  mov      x22, x0
00687208C  cbnz     w8, #0x687209c
006872090  mov      x0, x21
006872094  bl       #0x382bd14 ; 
006872098  strb     w27, [x26, #0xa4c]
00687209C  ldr      x1, [x21]
0068720A0  ldrb     w8, [x1, #0x53]
0068720A4  tbnz     w8, #5, #0x68720b0
0068720A8  ldr      x0, [x22, #0x210]
0068720AC  b        #0x68720bc ; 
0068720B0  ldr      x8, [x1, #0x60]
0068720B4  mov      x0, x22
0068720B8  blr      x8
0068720BC  cbz      x0, #0x6872158
0068720C0  ldr      x1, [x28]
0068720C4  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0068720C8  mov      x22, x0
0068720CC  cbz      x0, #0x68720e4
0068720D0  ldr      x8, [x19]
0068720D4  mov      x0, x22
0068720D8  ldr      x1, [x8, #0x40]
0068720DC  bl       #0x382be90 ; 
0068720E0  cbz      x0, #0x6872160
0068720E4  ldr      w8, [x19, #0x18]
0068720E8  cmp      x24, x8
0068720EC  b.hs     #0x687215c
0068720F0  add      x0, x25, x23
0068720F4  mov      x1, x22
0068720F8  str      x22, [x25, x24, lsl #3]
0068720FC  bl       #0x382bcb8 ; 
006872100  ldrsw    x8, [x19, #0x18]
006872104  add      x24, x24, #1
006872108  add      x23, x23, #8
00687210C  cmp      x24, x8
006872110  b.lt     #0x6872078
006872114  ldp      x20, x19, [sp, #0x50]
006872118  ldp      x22, x21, [sp, #0x40]
00687211C  ldp      x24, x23, [sp, #0x30]
006872120  ldp      x26, x25, [sp, #0x20]
006872124  ldp      x28, x27, [sp, #0x10]
006872128  ldr      x30, [sp], #0x60
00687212C  ret      
006872130  ldr      x3, [x2, #0x60]
006872134  mov      x0, x20
006872138  mov      x1, x19
00687213C  ldp      x20, x19, [sp, #0x50]
006872140  ldp      x22, x21, [sp, #0x40]
006872144  ldp      x24, x23, [sp, #0x30]
006872148  ldp      x26, x25, [sp, #0x20]
00687214C  ldp      x28, x27, [sp, #0x10]
006872150  ldr      x30, [sp], #0x60
006872154  br       x3
006872158  bl       #0x382bfb8 ; 
00687215C  bl       #0x382bfc0 ; 
006872160  bl       #0x382bfdc ; 
006872164  mov      x1, xzr
006872168  bl       #0x382be7c ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToNormalRandom
; RVA 0x6872370; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872370  str      x30, [sp, #-0x40]!
006872374  stp      x24, x23, [sp, #0x10]
006872378  stp      x22, x21, [sp, #0x20]
00687237C  stp      x20, x19, [sp, #0x30]
006872380  adrp     x22, #0x959b000
006872384  adrp     x24, #0x8f24000
006872388  ldrb     w8, [x22, #0xa85]
00687238C  ldr      x24, [x24, #0x3f0]
006872390  mov      x23, x3
006872394  mov      x20, x2
006872398  mov      x21, x1
00687239C  mov      x19, x0
0068723A0  tbnz     w8, #0, #0x68723d0
0068723A4  adrp     x0, #0x8ee8000
0068723A8  ldr      x0, [x0, #0x898]
0068723AC  bl       #0x382bd14 ; 
0068723B0  adrp     x0, #0x8f24000
0068723B4  ldr      x0, [x0, #0x3f0]
0068723B8  bl       #0x382bd14 ; 
0068723BC  adrp     x0, #0x8f23000
0068723C0  ldr      x0, [x0, #0xa08]
0068723C4  bl       #0x382bd14 ; 
0068723C8  mov      w8, #1
0068723CC  strb     w8, [x22, #0xa85]
0068723D0  ldr      x4, [x24]
0068723D4  ldrb     w8, [x4, #0x53]
0068723D8  tbnz     w8, #5, #0x6872438
0068723DC  mov      x0, x19
0068723E0  mov      x1, x20
0068723E4  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
0068723E8  cbz      w0, #0x687248c
0068723EC  cbz      x20, #0x6872604
0068723F0  adrp     x10, #0x8f23000
0068723F4  ldr      x8, [x20]
0068723F8  ldr      x10, [x10, #0xa08]
0068723FC  ldrh     w9, [x8, #0x12e]
006872400  ldr      x1, [x10]
006872404  cbz      x9, #0x6872428
006872408  ldr      x10, [x8, #0xb0]
00687240C  add      x10, x10, #8
006872410  ldur     x11, [x10, #-8]
006872414  cmp      x11, x1
006872418  b.eq     #0x6872460
00687241C  subs     x9, x9, #1
006872420  add      x10, x10, #0x10
006872424  b.ne     #0x6872410
006872428  mov      x0, x20
00687242C  mov      w2, wzr
006872430  bl       #0x3a7e710 ; 
006872434  b        #0x687246c ; 
006872438  ldr      x5, [x4, #0x60]
00687243C  mov      x0, x19
006872440  mov      x1, x21
006872444  mov      x2, x20
006872448  mov      x3, x23
00687244C  ldp      x20, x19, [sp, #0x30]
006872450  ldp      x22, x21, [sp, #0x20]
006872454  ldp      x24, x23, [sp, #0x10]
006872458  ldr      x30, [sp], #0x40
00687245C  br       x5
006872460  ldrsw    x9, [x10]
006872464  add      x8, x8, x9, lsl #4
006872468  add      x0, x8, #0x138
00687246C  ldp      x8, x1, [x0]
006872470  mov      x0, x20
006872474  blr      x8
006872478  mov      w22, w0
00687247C  mov      x0, x23
006872480  mov      w1, w22
006872484  bl       #0x685b6b8 ; HotFix.BattleLogic.HeroSkillCreator$$IsContain
006872488  tbz      w0, #0, #0x68724a0
00687248C  ldp      x20, x19, [sp, #0x30]
006872490  ldp      x22, x21, [sp, #0x20]
006872494  ldp      x24, x23, [sp, #0x10]
006872498  ldr      x30, [sp], #0x40
00687249C  ret      
0068724A0  mov      x0, x19
0068724A4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068724A8  cbz      x0, #0x6872604
0068724AC  adrp     x24, #0x9598000
0068724B0  ldrb     w8, [x24, #0xfcc]
0068724B4  mov      x23, x0
0068724B8  cbnz     w8, #0x68724d0
0068724BC  adrp     x0, #0x8f06000
0068724C0  ldr      x0, [x0, #0x470]
0068724C4  bl       #0x382bd14 ; 
0068724C8  mov      w8, #1
0068724CC  strb     w8, [x24, #0xfcc]
0068724D0  adrp     x8, #0x8f06000
0068724D4  ldr      x8, [x8, #0x470]
0068724D8  ldr      x1, [x8]
0068724DC  ldrb     w8, [x1, #0x53]
0068724E0  tbnz     w8, #5, #0x68724ec
0068724E4  ldr      x0, [x23, #0x200]
0068724E8  b        #0x68724f8 ; 
0068724EC  ldr      x8, [x1, #0x60]
0068724F0  mov      x0, x23
0068724F4  blr      x8
0068724F8  cbz      x0, #0x6872604
0068724FC  mov      w1, w22
006872500  mov      x2, xzr
006872504  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006872508  cbz      x0, #0x6872604
00687250C  adrp     x24, #0x959b000
006872510  ldrb     w8, [x24, #0xb7f]
006872514  mov      x23, x0
006872518  cbnz     w8, #0x6872530
00687251C  adrp     x0, #0x8f23000
006872520  ldr      x0, [x0, #0xa10]
006872524  bl       #0x382bd14 ; 
006872528  mov      w8, #1
00687252C  strb     w8, [x24, #0xb7f]
006872530  adrp     x8, #0x8f23000
006872534  ldr      x8, [x8, #0xa10]
006872538  ldr      x1, [x8]
00687253C  ldrb     w8, [x1, #0x53]
006872540  tbnz     w8, #5, #0x687254c
006872544  ldr      w8, [x23, #0x30]
006872548  b        #0x687255c ; 
00687254C  ldr      x8, [x1, #0x60]
006872550  mov      x0, x23
006872554  blr      x8
006872558  mov      w8, w0
00687255C  adrp     x23, #0x8ee8000
006872560  ldr      x23, [x23, #0x898]
006872564  sub      w24, w8, #1
006872568  ldr      x0, [x23]
00687256C  ldr      w9, [x0, #0xe0]
006872570  cbnz     w9, #0x687257c
006872574  bl       #0x382be8c ; 
006872578  ldr      x0, [x23]
00687257C  ldr      x8, [x0, #0xb8]
006872580  ldr      w8, [x8, #0x2f0]
006872584  cmp      w24, w8
006872588  b.le     #0x68725a8
00687258C  ldr      w9, [x0, #0xe0]
006872590  mov      w24, w8
006872594  cbnz     w9, #0x68725a8
006872598  bl       #0x382be8c ; 
00687259C  ldr      x8, [x23]
0068725A0  ldr      x8, [x8, #0xb8]
0068725A4  ldr      w24, [x8, #0x2f0]
0068725A8  cbz      x21, #0x6872604
0068725AC  ldr      w9, [x21, #0x18]
0068725B0  bic      w8, w24, w24, asr #31
0068725B4  cmp      w8, w9
0068725B8  b.hs     #0x6872608
0068725BC  add      x8, x21, w8, uxtw #3
0068725C0  ldr      x21, [x8, #0x20]
0068725C4  mov      x0, x19
0068725C8  mov      x1, x20
0068725CC  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
0068725D0  ldr      x8, [x19]
0068725D4  mov      w3, w0
0068725D8  mov      x0, x19
0068725DC  mov      x1, x21
0068725E0  ldr      x6, [x8, #0x228]
0068725E4  ldr      x5, [x8, #0x230]
0068725E8  mov      w2, w22
0068725EC  ldp      x20, x19, [sp, #0x30]
0068725F0  ldp      x22, x21, [sp, #0x20]
0068725F4  ldp      x24, x23, [sp, #0x10]
0068725F8  mov      x4, xzr
0068725FC  ldr      x30, [sp], #0x40
006872600  br       x6
006872604  bl       #0x382bfb8 ; 
006872608  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddDankeSkillGroupToRandom
; RVA 0x687260C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687260C  str      x30, [sp, #-0x40]!
006872610  stp      x24, x23, [sp, #0x10]
006872614  stp      x22, x21, [sp, #0x20]
006872618  stp      x20, x19, [sp, #0x30]
00687261C  adrp     x23, #0x959b000
006872620  adrp     x24, #0x8f24000
006872624  ldrb     w8, [x23, #0xa86]
006872628  ldr      x24, [x24, #0x3f8]
00687262C  mov      x22, x3
006872630  mov      x20, x2
006872634  mov      x21, x1
006872638  mov      x19, x0
00687263C  tbnz     w8, #0, #0x6872660
006872640  adrp     x0, #0x8f24000
006872644  ldr      x0, [x0, #0x3f8]
006872648  bl       #0x382bd14 ; 
00687264C  adrp     x0, #0x8f23000
006872650  ldr      x0, [x0, #0xa08]
006872654  bl       #0x382bd14 ; 
006872658  mov      w8, #1
00687265C  strb     w8, [x23, #0xa86]
006872660  ldr      x4, [x24]
006872664  ldrb     w8, [x4, #0x53]
006872668  tbnz     w8, #5, #0x68726c8
00687266C  mov      x0, x19
006872670  mov      x1, x20
006872674  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
006872678  cbz      w0, #0x6872720
00687267C  cbz      x20, #0x6872800
006872680  adrp     x10, #0x8f23000
006872684  ldr      x8, [x20]
006872688  ldr      x10, [x10, #0xa08]
00687268C  ldrh     w9, [x8, #0x12e]
006872690  ldr      x1, [x10]
006872694  cbz      x9, #0x68726b8
006872698  ldr      x10, [x8, #0xb0]
00687269C  add      x10, x10, #8
0068726A0  ldur     x11, [x10, #-8]
0068726A4  cmp      x11, x1
0068726A8  b.eq     #0x68726f0
0068726AC  subs     x9, x9, #1
0068726B0  add      x10, x10, #0x10
0068726B4  b.ne     #0x68726a0
0068726B8  mov      x0, x20
0068726BC  mov      w2, wzr
0068726C0  bl       #0x3a7e710 ; 
0068726C4  b        #0x68726fc ; 
0068726C8  ldr      x5, [x4, #0x60]
0068726CC  mov      x0, x19
0068726D0  mov      x1, x21
0068726D4  mov      x2, x20
0068726D8  mov      x3, x22
0068726DC  ldp      x20, x19, [sp, #0x30]
0068726E0  ldp      x22, x21, [sp, #0x20]
0068726E4  ldp      x24, x23, [sp, #0x10]
0068726E8  ldr      x30, [sp], #0x40
0068726EC  br       x5
0068726F0  ldrsw    x9, [x10]
0068726F4  add      x8, x8, x9, lsl #4
0068726F8  add      x0, x8, #0x138
0068726FC  ldp      x8, x1, [x0]
006872700  mov      x0, x20
006872704  blr      x8
006872708  mov      w23, w0
00687270C  cbz      x22, #0x6872734
006872710  mov      x0, x22
006872714  mov      w1, w23
006872718  bl       #0x685b6b8 ; HotFix.BattleLogic.HeroSkillCreator$$IsContain
00687271C  tbz      w0, #0, #0x6872734
006872720  ldp      x20, x19, [sp, #0x30]
006872724  ldp      x22, x21, [sp, #0x20]
006872728  ldp      x24, x23, [sp, #0x10]
00687272C  ldr      x30, [sp], #0x40
006872730  ret      
006872734  mov      x0, x19
006872738  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00687273C  cbz      x0, #0x6872800
006872740  adrp     x24, #0x9598000
006872744  ldrb     w8, [x24, #0xfcc]
006872748  mov      x22, x0
00687274C  cbnz     w8, #0x6872764
006872750  adrp     x0, #0x8f06000
006872754  ldr      x0, [x0, #0x470]
006872758  bl       #0x382bd14 ; 
00687275C  mov      w8, #1
006872760  strb     w8, [x24, #0xfcc]
006872764  adrp     x8, #0x8f06000
006872768  ldr      x8, [x8, #0x470]
00687276C  ldr      x1, [x8]
006872770  ldrb     w8, [x1, #0x53]
006872774  tbnz     w8, #5, #0x6872780
006872778  ldr      x0, [x22, #0x200]
00687277C  b        #0x687278c ; 
006872780  ldr      x8, [x1, #0x60]
006872784  mov      x0, x22
006872788  blr      x8
00687278C  cbz      x0, #0x6872800
006872790  mov      w1, w23
006872794  mov      x2, xzr
006872798  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00687279C  mov      w1, wzr
0068727A0  mov      x2, xzr
0068727A4  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
0068727A8  cbz      x21, #0x6872800
0068727AC  ldr      w8, [x21, #0x18]
0068727B0  cmp      w0, w8
0068727B4  b.hs     #0x6872804
0068727B8  add      x8, x21, w0, sxtw #3
0068727BC  ldr      x21, [x8, #0x20]
0068727C0  mov      x0, x19
0068727C4  mov      x1, x20
0068727C8  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
0068727CC  ldr      x8, [x19]
0068727D0  mov      w3, w0
0068727D4  mov      x0, x19
0068727D8  mov      x1, x21
0068727DC  ldr      x6, [x8, #0x228]
0068727E0  ldr      x5, [x8, #0x230]
0068727E4  mov      w2, w23
0068727E8  ldp      x20, x19, [sp, #0x30]
0068727EC  ldp      x22, x21, [sp, #0x20]
0068727F0  ldp      x24, x23, [sp, #0x10]
0068727F4  mov      x4, xzr
0068727F8  ldr      x30, [sp], #0x40
0068727FC  br       x6
006872800  bl       #0x382bfb8 ; 
006872804  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToRandom
; RVA 0x6872808; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872808  str      x30, [sp, #-0x40]!
00687280C  stp      x24, x23, [sp, #0x10]
006872810  stp      x22, x21, [sp, #0x20]
006872814  stp      x20, x19, [sp, #0x30]
006872818  adrp     x23, #0x959b000
00687281C  adrp     x24, #0x8f24000
006872820  ldrb     w8, [x23, #0xa87]
006872824  ldr      x24, [x24, #0x400]
006872828  mov      x22, x3
00687282C  mov      x21, x2
006872830  mov      x19, x1
006872834  mov      x20, x0
006872838  tbnz     w8, #0, #0x687285c
00687283C  adrp     x0, #0x8f24000
006872840  ldr      x0, [x0, #0x400]
006872844  bl       #0x382bd14 ; 
006872848  adrp     x0, #0x8f23000
00687284C  ldr      x0, [x0, #0xa08]
006872850  bl       #0x382bd14 ; 
006872854  mov      w8, #1
006872858  strb     w8, [x23, #0xa87]
00687285C  ldr      x4, [x24]
006872860  ldrb     w8, [x4, #0x53]
006872864  tbnz     w8, #5, #0x68728c4
006872868  mov      x0, x20
00687286C  mov      x1, x21
006872870  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
006872874  cbz      w0, #0x6872918
006872878  cbz      x21, #0x687296c
00687287C  adrp     x10, #0x8f23000
006872880  ldr      x8, [x21]
006872884  ldr      x10, [x10, #0xa08]
006872888  ldrh     w9, [x8, #0x12e]
00687288C  ldr      x1, [x10]
006872890  cbz      x9, #0x68728b4
006872894  ldr      x10, [x8, #0xb0]
006872898  add      x10, x10, #8
00687289C  ldur     x11, [x10, #-8]
0068728A0  cmp      x11, x1
0068728A4  b.eq     #0x68728ec
0068728A8  subs     x9, x9, #1
0068728AC  add      x10, x10, #0x10
0068728B0  b.ne     #0x687289c
0068728B4  mov      x0, x21
0068728B8  mov      w2, wzr
0068728BC  bl       #0x3a7e710 ; 
0068728C0  b        #0x68728f8 ; 
0068728C4  ldr      x5, [x4, #0x60]
0068728C8  mov      x0, x20
0068728CC  mov      x1, x19
0068728D0  mov      x2, x21
0068728D4  mov      x3, x22
0068728D8  ldp      x20, x19, [sp, #0x30]
0068728DC  ldp      x22, x21, [sp, #0x20]
0068728E0  ldp      x24, x23, [sp, #0x10]
0068728E4  ldr      x30, [sp], #0x40
0068728E8  br       x5
0068728EC  ldrsw    x9, [x10]
0068728F0  add      x8, x8, x9, lsl #4
0068728F4  add      x0, x8, #0x138
0068728F8  ldp      x8, x1, [x0]
0068728FC  mov      x0, x21
006872900  blr      x8
006872904  mov      w23, w0
006872908  mov      x0, x22
00687290C  mov      w1, w23
006872910  bl       #0x685b6b8 ; HotFix.BattleLogic.HeroSkillCreator$$IsContain
006872914  tbz      w0, #0, #0x687292c
006872918  ldp      x20, x19, [sp, #0x30]
00687291C  ldp      x22, x21, [sp, #0x20]
006872920  ldp      x24, x23, [sp, #0x10]
006872924  ldr      x30, [sp], #0x40
006872928  ret      
00687292C  mov      x0, x20
006872930  mov      x1, x21
006872934  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
006872938  ldr      x8, [x20]
00687293C  mov      w3, w0
006872940  mov      x0, x20
006872944  mov      x1, x19
006872948  ldr      x6, [x8, #0x228]
00687294C  ldr      x5, [x8, #0x230]
006872950  mov      w2, w23
006872954  ldp      x20, x19, [sp, #0x30]
006872958  ldp      x22, x21, [sp, #0x20]
00687295C  ldp      x24, x23, [sp, #0x10]
006872960  mov      x4, xzr
006872964  ldr      x30, [sp], #0x40
006872968  br       x6
00687296C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToBoxRandoms
; RVA 0x6872970; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872970  str      x30, [sp, #-0x40]!
006872974  stp      x24, x23, [sp, #0x10]
006872978  stp      x22, x21, [sp, #0x20]
00687297C  stp      x20, x19, [sp, #0x30]
006872980  adrp     x22, #0x959b000
006872984  adrp     x24, #0x8f24000
006872988  ldrb     w8, [x22, #0xa88]
00687298C  ldr      x24, [x24, #0x408]
006872990  mov      x23, x3
006872994  mov      x21, x2
006872998  mov      x20, x1
00687299C  mov      x19, x0
0068729A0  tbnz     w8, #0, #0x68729c4
0068729A4  adrp     x0, #0x8f24000
0068729A8  ldr      x0, [x0, #0x408]
0068729AC  bl       #0x382bd14 ; 
0068729B0  adrp     x0, #0x8f23000
0068729B4  ldr      x0, [x0, #0xa08]
0068729B8  bl       #0x382bd14 ; 
0068729BC  mov      w8, #1
0068729C0  strb     w8, [x22, #0xa88]
0068729C4  ldr      x4, [x24]
0068729C8  ldrb     w8, [x4, #0x53]
0068729CC  tbnz     w8, #5, #0x6872a2c
0068729D0  mov      x0, x19
0068729D4  mov      x1, x20
0068729D8  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
0068729DC  cbz      w0, #0x6872a80
0068729E0  cbz      x20, #0x6872bb8
0068729E4  adrp     x10, #0x8f23000
0068729E8  ldr      x8, [x20]
0068729EC  ldr      x10, [x10, #0xa08]
0068729F0  ldrh     w9, [x8, #0x12e]
0068729F4  ldr      x1, [x10]
0068729F8  cbz      x9, #0x6872a1c
0068729FC  ldr      x10, [x8, #0xb0]
006872A00  add      x10, x10, #8
006872A04  ldur     x11, [x10, #-8]
006872A08  cmp      x11, x1
006872A0C  b.eq     #0x6872a54
006872A10  subs     x9, x9, #1
006872A14  add      x10, x10, #0x10
006872A18  b.ne     #0x6872a04
006872A1C  mov      x0, x20
006872A20  mov      w2, wzr
006872A24  bl       #0x3a7e710 ; 
006872A28  b        #0x6872a60 ; 
006872A2C  ldr      x5, [x4, #0x60]
006872A30  mov      x0, x19
006872A34  mov      x1, x20
006872A38  mov      x2, x21
006872A3C  mov      x3, x23
006872A40  ldp      x20, x19, [sp, #0x30]
006872A44  ldp      x22, x21, [sp, #0x20]
006872A48  ldp      x24, x23, [sp, #0x10]
006872A4C  ldr      x30, [sp], #0x40
006872A50  br       x5
006872A54  ldrsw    x9, [x10]
006872A58  add      x8, x8, x9, lsl #4
006872A5C  add      x0, x8, #0x138
006872A60  ldp      x8, x1, [x0]
006872A64  mov      x0, x20
006872A68  blr      x8
006872A6C  mov      w22, w0
006872A70  mov      x0, x23
006872A74  mov      w1, w22
006872A78  bl       #0x685b6b8 ; HotFix.BattleLogic.HeroSkillCreator$$IsContain
006872A7C  tbz      w0, #0, #0x6872a94
006872A80  ldp      x20, x19, [sp, #0x30]
006872A84  ldp      x22, x21, [sp, #0x20]
006872A88  ldp      x24, x23, [sp, #0x10]
006872A8C  ldr      x30, [sp], #0x40
006872A90  ret      
006872A94  mov      x0, x19
006872A98  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006872A9C  cbz      x0, #0x6872bb8
006872AA0  adrp     x24, #0x9598000
006872AA4  ldrb     w8, [x24, #0xfcc]
006872AA8  mov      x23, x0
006872AAC  cbnz     w8, #0x6872ac4
006872AB0  adrp     x0, #0x8f06000
006872AB4  ldr      x0, [x0, #0x470]
006872AB8  bl       #0x382bd14 ; 
006872ABC  mov      w8, #1
006872AC0  strb     w8, [x24, #0xfcc]
006872AC4  adrp     x8, #0x8f06000
006872AC8  ldr      x8, [x8, #0x470]
006872ACC  ldr      x1, [x8]
006872AD0  ldrb     w8, [x1, #0x53]
006872AD4  tbnz     w8, #5, #0x6872ae0
006872AD8  ldr      x0, [x23, #0x200]
006872ADC  b        #0x6872aec ; 
006872AE0  ldr      x8, [x1, #0x60]
006872AE4  mov      x0, x23
006872AE8  blr      x8
006872AEC  cbz      x0, #0x6872bb8
006872AF0  mov      w1, w22
006872AF4  mov      x2, xzr
006872AF8  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006872AFC  cbz      x0, #0x6872bb8
006872B00  adrp     x24, #0x959b000
006872B04  ldrb     w8, [x24, #0xb7f]
006872B08  mov      x23, x0
006872B0C  cbnz     w8, #0x6872b24
006872B10  adrp     x0, #0x8f23000
006872B14  ldr      x0, [x0, #0xa10]
006872B18  bl       #0x382bd14 ; 
006872B1C  mov      w8, #1
006872B20  strb     w8, [x24, #0xb7f]
006872B24  adrp     x8, #0x8f23000
006872B28  ldr      x8, [x8, #0xa10]
006872B2C  ldr      x1, [x8]
006872B30  ldrb     w8, [x1, #0x53]
006872B34  tbnz     w8, #5, #0x6872b40
006872B38  ldr      w0, [x23, #0x30]
006872B3C  b        #0x6872b4c ; 
006872B40  ldr      x8, [x1, #0x60]
006872B44  mov      x0, x23
006872B48  blr      x8
006872B4C  sub      w8, w0, #2
006872B50  bic      w8, w8, w8, asr #31
006872B54  cmp      w8, #2
006872B58  mov      w9, #2
006872B5C  csel     w8, w8, w9, lt
006872B60  cbz      x21, #0x6872bb8
006872B64  ldr      w9, [x21, #0x18]
006872B68  cmp      w8, w9
006872B6C  b.hs     #0x6872bbc
006872B70  add      x8, x21, w8, uxtw #3
006872B74  ldr      x21, [x8, #0x20]
006872B78  mov      x0, x19
006872B7C  mov      x1, x20
006872B80  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
006872B84  ldr      x8, [x19]
006872B88  mov      w3, w0
006872B8C  mov      x0, x19
006872B90  mov      x1, x21
006872B94  ldr      x6, [x8, #0x228]
006872B98  ldr      x5, [x8, #0x230]
006872B9C  mov      w2, w22
006872BA0  ldp      x20, x19, [sp, #0x30]
006872BA4  ldp      x22, x21, [sp, #0x20]
006872BA8  ldp      x24, x23, [sp, #0x10]
006872BAC  mov      x4, xzr
006872BB0  ldr      x30, [sp], #0x40
006872BB4  br       x6
006872BB8  bl       #0x382bfb8 ; 
006872BBC  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroSkillCreator$$AddSkillToRandom
; RVA 0x686606C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686606C  stp      x30, x27, [sp, #-0x50]!
006866070  stp      x26, x25, [sp, #0x10]
006866074  stp      x24, x23, [sp, #0x20]
006866078  stp      x22, x21, [sp, #0x30]
00686607C  stp      x20, x19, [sp, #0x40]
006866080  adrp     x24, #0x959b000
006866084  adrp     x25, #0x8f23000
006866088  ldrb     w8, [x24, #0xa89]
00686608C  ldr      x25, [x25, #0xe00]
006866090  mov      x19, x4
006866094  mov      w20, w3
006866098  mov      w21, w2
00686609C  mov      x22, x1
0068660A0  mov      x23, x0
0068660A4  tbnz     w8, #0, #0x68660bc
0068660A8  adrp     x0, #0x8f23000
0068660AC  ldr      x0, [x0, #0xe00]
0068660B0  bl       #0x382bd14 ; 
0068660B4  mov      w8, #1
0068660B8  strb     w8, [x24, #0xa89]
0068660BC  ldr      x5, [x25]
0068660C0  ldrb     w8, [x5, #0x53]
0068660C4  tbnz     w8, #5, #0x6866114
0068660C8  mov      x0, x23
0068660CC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068660D0  cbz      x0, #0x68662a8
0068660D4  adrp     x24, #0x9598000
0068660D8  ldrb     w8, [x24, #0xfcc]
0068660DC  mov      x23, x0
0068660E0  cbnz     w8, #0x68660f8
0068660E4  adrp     x0, #0x8f06000
0068660E8  ldr      x0, [x0, #0x470]
0068660EC  bl       #0x382bd14 ; 
0068660F0  mov      w8, #1
0068660F4  strb     w8, [x24, #0xfcc]
0068660F8  adrp     x8, #0x8f06000
0068660FC  ldr      x8, [x8, #0x470]
006866100  ldr      x1, [x8]
006866104  ldrb     w8, [x1, #0x53]
006866108  tbnz     w8, #5, #0x6866144
00686610C  ldr      x0, [x23, #0x200]
006866110  b        #0x6866150 ; 
006866114  ldr      x6, [x5, #0x60]
006866118  mov      x0, x23
00686611C  mov      x1, x22
006866120  mov      w2, w21
006866124  mov      w3, w20
006866128  mov      x4, x19
00686612C  ldp      x20, x19, [sp, #0x40]
006866130  ldp      x22, x21, [sp, #0x30]
006866134  ldp      x24, x23, [sp, #0x20]
006866138  ldp      x26, x25, [sp, #0x10]
00686613C  ldp      x30, x27, [sp], #0x50
006866140  br       x6
006866144  ldr      x8, [x1, #0x60]
006866148  mov      x0, x23
00686614C  blr      x8
006866150  cbz      x0, #0x68662a8
006866154  mov      w1, w21
006866158  mov      x2, xzr
00686615C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006866160  cbz      x0, #0x68661a4
006866164  adrp     x24, #0x959b000
006866168  ldrb     w8, [x24, #0xbb6]
00686616C  mov      x23, x0
006866170  cbnz     w8, #0x6866188
006866174  adrp     x0, #0x8f23000
006866178  ldr      x0, [x0, #0xe08]
00686617C  bl       #0x382bd14 ; 
006866180  mov      w8, #1
006866184  strb     w8, [x24, #0xbb6]
006866188  adrp     x8, #0x8f23000
00686618C  ldr      x8, [x8, #0xe08]
006866190  ldr      x1, [x8]
006866194  ldrb     w8, [x1, #0x53]
006866198  tbnz     w8, #5, #0x68661bc
00686619C  ldr      w25, [x23, #0x178]
0068661A0  b        #0x68661cc ; 
0068661A4  ldp      x20, x19, [sp, #0x40]
0068661A8  ldp      x22, x21, [sp, #0x30]
0068661AC  ldp      x24, x23, [sp, #0x20]
0068661B0  ldp      x26, x25, [sp, #0x10]
0068661B4  ldp      x30, x27, [sp], #0x50
0068661B8  ret      
0068661BC  ldr      x8, [x1, #0x60]
0068661C0  mov      x0, x23
0068661C4  blr      x8
0068661C8  mov      w25, w0
0068661CC  adrp     x24, #0x959b000
0068661D0  ldrb     w8, [x24, #0x9b4]
0068661D4  cbnz     w8, #0x68661ec
0068661D8  adrp     x0, #0x8f23000
0068661DC  ldr      x0, [x0, #0x90]
0068661E0  bl       #0x382bd14 ; 
0068661E4  mov      w8, #1
0068661E8  strb     w8, [x24, #0x9b4]
0068661EC  adrp     x8, #0x8f23000
0068661F0  ldr      x8, [x8, #0x90]
0068661F4  ldr      x1, [x8]
0068661F8  ldrb     w8, [x1, #0x53]
0068661FC  tbnz     w8, #5, #0x6866208
006866200  ldr      x24, [x23, #0x170]
006866204  b        #0x6866218 ; 
006866208  ldr      x8, [x1, #0x60]
00686620C  mov      x0, x23
006866210  blr      x8
006866214  mov      x24, x0
006866218  adrp     x26, #0x9599000
00686621C  ldrb     w8, [x26, #0x4c9]
006866220  mov      w27, #1
006866224  lsl      w9, w27, w25
006866228  cmp      w25, #0
00686622C  csel     w25, wzr, w9, eq
006866230  cbnz     w8, #0x6866244
006866234  adrp     x0, #0x8f09000
006866238  ldr      x0, [x0, #0x300]
00686623C  bl       #0x382bd14 ; 
006866240  strb     w27, [x26, #0x4c9]
006866244  adrp     x8, #0x8f09000
006866248  ldr      x8, [x8, #0x300]
00686624C  ldr      x1, [x8]
006866250  ldrb     w8, [x1, #0x53]
006866254  tbnz     w8, #5, #0x6866260
006866258  ldr      x5, [x23, #0x98]
00686625C  b        #0x6866270 ; 
006866260  ldr      x8, [x1, #0x60]
006866264  mov      x0, x23
006866268  blr      x8
00686626C  mov      x5, x0
006866270  cbz      x22, #0x68662a8
006866274  mov      x0, x22
006866278  mov      w1, w21
00686627C  mov      w2, w20
006866280  mov      w3, w25
006866284  mov      x4, x24
006866288  mov      x6, x19
00686628C  ldp      x20, x19, [sp, #0x40]
006866290  ldp      x22, x21, [sp, #0x30]
006866294  ldp      x24, x23, [sp, #0x20]
006866298  ldp      x26, x25, [sp, #0x10]
00686629C  mov      x7, xzr
0068662A0  ldp      x30, x27, [sp], #0x50
0068662A4  b        #0x6632e88 ; HotFix.BattleLogic.WeightRandom$$Add
0068662A8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$IsContain
; RVA 0x685B6B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685B6B8  str      x30, [sp, #-0x30]!
00685B6BC  stp      x22, x21, [sp, #0x10]
00685B6C0  stp      x20, x19, [sp, #0x20]
00685B6C4  adrp     x21, #0x959b000
00685B6C8  adrp     x22, #0x8f23000
00685B6CC  ldrb     w8, [x21, #0xa8a]
00685B6D0  ldr      x22, [x22, #0xa18]
00685B6D4  mov      w19, w1
00685B6D8  mov      x20, x0
00685B6DC  tbnz     w8, #0, #0x685b6f4
00685B6E0  adrp     x0, #0x8f23000
00685B6E4  ldr      x0, [x0, #0xa18]
00685B6E8  bl       #0x382bd14 ; 
00685B6EC  mov      w8, #1
00685B6F0  strb     w8, [x21, #0xa8a]
00685B6F4  ldr      x2, [x22]
00685B6F8  ldrb     w8, [x2, #0x53]
00685B6FC  tbnz     w8, #5, #0x685b738
00685B700  cbz      x20, #0x685b754
00685B704  ldr      w8, [x20, #0x18]
00685B708  subs     w8, w8, #1
00685B70C  b.lt     #0x685b754
00685B710  mov      w9, wzr
00685B714  add      x10, x20, w9, sxtw #2
00685B718  ldr      w10, [x10, #0x20]
00685B71C  cmp      w10, w19
00685B720  cset     w0, eq
00685B724  b.eq     #0x685b758
00685B728  cmp      w8, w9
00685B72C  add      w9, w9, #1
00685B730  b.ne     #0x685b714
00685B734  b        #0x685b758 ; 
00685B738  ldr      x3, [x2, #0x60]
00685B73C  mov      x0, x20
00685B740  mov      w1, w19
00685B744  ldp      x20, x19, [sp, #0x20]
00685B748  ldp      x22, x21, [sp, #0x10]
00685B74C  ldr      x30, [sp], #0x30
00685B750  br       x3
00685B754  mov      w0, wzr
00685B758  ldp      x20, x19, [sp, #0x20]
00685B75C  ldp      x22, x21, [sp, #0x10]
00685B760  ldr      x30, [sp], #0x30
00685B764  ret      

; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
; RVA 0x6872230; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872230  str      x30, [sp, #-0x30]!
006872234  stp      x22, x21, [sp, #0x10]
006872238  stp      x20, x19, [sp, #0x20]
00687223C  adrp     x21, #0x959b000
006872240  adrp     x22, #0x8f24000
006872244  ldrb     w8, [x21, #0xa8b]
006872248  ldr      x22, [x22, #0x3e0]
00687224C  mov      x19, x1
006872250  mov      x20, x0
006872254  tbnz     w8, #0, #0x687226c
006872258  adrp     x0, #0x8f24000
00687225C  ldr      x0, [x0, #0x3e0]
006872260  bl       #0x382bd14 ; 
006872264  mov      w8, #1
006872268  strb     w8, [x21, #0xa8b]
00687226C  ldr      x2, [x22]
006872270  ldrb     w8, [x2, #0x53]
006872274  tbnz     w8, #5, #0x68722ec
006872278  cbz      x19, #0x68722dc
00687227C  ldr      w8, [x19, #0x18]
006872280  cmp      w8, #1
006872284  b.lt     #0x68722dc
006872288  mov      w21, wzr
00687228C  add      x20, x19, #0x20
006872290  cmp      w21, w8
006872294  b.hs     #0x6872308
006872298  ldr      x0, [x20]
00687229C  cbz      x0, #0x687230c
0068722A0  mov      x1, xzr
0068722A4  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0068722A8  ldr      w8, [x19, #0x18]
0068722AC  cmp      w21, w8
0068722B0  b.hs     #0x6872308
0068722B4  mov      x22, x20
0068722B8  mov      x0, x20
0068722BC  mov      x1, xzr
0068722C0  str      xzr, [x22], #8
0068722C4  bl       #0x382bcb8 ; 
0068722C8  ldr      w8, [x19, #0x18]
0068722CC  add      w21, w21, #1
0068722D0  mov      x20, x22
0068722D4  cmp      w21, w8
0068722D8  b.lt     #0x6872290
0068722DC  ldp      x20, x19, [sp, #0x20]
0068722E0  ldp      x22, x21, [sp, #0x10]
0068722E4  ldr      x30, [sp], #0x30
0068722E8  ret      
0068722EC  ldr      x3, [x2, #0x60]
0068722F0  mov      x0, x20
0068722F4  mov      x1, x19
0068722F8  ldp      x20, x19, [sp, #0x20]
0068722FC  ldp      x22, x21, [sp, #0x10]
006872300  ldr      x30, [sp], #0x30
006872304  br       x3
006872308  bl       #0x382bfc0 ; 
00687230C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$get_RandomIndex
; RVA 0x6872BC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872BC0  stp      x30, x21, [sp, #-0x20]!
006872BC4  stp      x20, x19, [sp, #0x10]
006872BC8  adrp     x20, #0x959b000
006872BCC  adrp     x21, #0x8f24000
006872BD0  ldrb     w8, [x20, #0xa8c]
006872BD4  ldr      x21, [x21, #0x200]
006872BD8  mov      x19, x0
006872BDC  tbnz     w8, #0, #0x6872bf4
006872BE0  adrp     x0, #0x8f24000
006872BE4  ldr      x0, [x0, #0x200]
006872BE8  bl       #0x382bd14 ; 
006872BEC  mov      w8, #1
006872BF0  strb     w8, [x20, #0xa8c]
006872BF4  ldr      x1, [x21]
006872BF8  ldrb     w8, [x1, #0x53]
006872BFC  tbnz     w8, #5, #0x6872c10
006872C00  ldr      w0, [x19, #0x60]
006872C04  ldp      x20, x19, [sp, #0x10]
006872C08  ldp      x30, x21, [sp], #0x20
006872C0C  ret      
006872C10  ldr      x2, [x1, #0x60]
006872C14  mov      x0, x19
006872C18  ldp      x20, x19, [sp, #0x10]
006872C1C  ldp      x30, x21, [sp], #0x20
006872C20  br       x2

; HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills
; RVA 0x685B9C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685B9C4  sub      sp, sp, #0x80
00685B9C8  stp      x29, x30, [sp, #0x20]
00685B9CC  stp      x28, x27, [sp, #0x30]
00685B9D0  stp      x26, x25, [sp, #0x40]
00685B9D4  stp      x24, x23, [sp, #0x50]
00685B9D8  stp      x22, x21, [sp, #0x60]
00685B9DC  stp      x20, x19, [sp, #0x70]
00685B9E0  str      x2, [sp, #8]
00685B9E4  str      x1, [sp, #0x18]
00685B9E8  adrp     x19, #0x959b000
00685B9EC  adrp     x23, #0x8f23000
00685B9F0  ldrb     w8, [x19, #0xa8d]
00685B9F4  ldrb     w20, [sp, #0x80]
00685B9F8  ldr      x23, [x23, #0xa30]
00685B9FC  mov      w26, w7
00685BA00  mov      x27, x6
00685BA04  mov      x25, x5
00685BA08  mov      w22, w4
00685BA0C  mov      x21, x3
00685BA10  mov      x28, x0
00685BA14  tbnz     w8, #0, #0x685ba8c
00685BA18  adrp     x0, #0x8f23000
00685BA1C  ldr      x0, [x0, #0xa30]
00685BA20  bl       #0x382bd14 ; 
00685BA24  adrp     x0, #0x8ec2000
00685BA28  ldr      x0, [x0, #0x268]
00685BA2C  bl       #0x382bd14 ; 
00685BA30  adrp     x0, #0x8ee1000
00685BA34  ldr      x0, [x0, #0x6e8]
00685BA38  bl       #0x382bd14 ; 
00685BA3C  adrp     x0, #0x8ebf000
00685BA40  ldr      x0, [x0, #0x840]
00685BA44  bl       #0x382bd14 ; 
00685BA48  adrp     x0, #0x8f08000
00685BA4C  ldr      x0, [x0, #0xbb8]
00685BA50  bl       #0x382bd14 ; 
00685BA54  adrp     x0, #0x8f08000
00685BA58  ldr      x0, [x0, #0xbc0]
00685BA5C  bl       #0x382bd14 ; 
00685BA60  adrp     x0, #0x8f23000
00685BA64  ldr      x0, [x0, #0xa38]
00685BA68  bl       #0x382bd14 ; 
00685BA6C  adrp     x0, #0x8f23000
00685BA70  ldr      x0, [x0, #0xa40]
00685BA74  bl       #0x382bd14 ; 
00685BA78  adrp     x0, #0x8f23000
00685BA7C  ldr      x0, [x0, #0xa48]
00685BA80  bl       #0x382bd14 ; 
00685BA84  mov      w8, #1
00685BA88  strb     w8, [x19, #0xa8d]
00685BA8C  ldr      x8, [x23]
00685BA90  ldrb     w9, [x8, #0x53]
00685BA94  tbnz     w9, #5, #0x685bae4
00685BA98  mov      x0, x28
00685BA9C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BAA0  cbz      x0, #0x685bf1c
00685BAA4  adrp     x19, #0x9591000
00685BAA8  ldrb     w8, [x19, #0xa90]
00685BAAC  mov      x24, x0
00685BAB0  cbnz     w8, #0x685bac8
00685BAB4  adrp     x0, #0x8ee6000
00685BAB8  ldr      x0, [x0, #0x3e0]
00685BABC  bl       #0x382bd14 ; 
00685BAC0  mov      w8, #1
00685BAC4  strb     w8, [x19, #0xa90]
00685BAC8  adrp     x8, #0x8ee6000
00685BACC  ldr      x8, [x8, #0x3e0]
00685BAD0  ldr      x1, [x8]
00685BAD4  ldrb     w8, [x1, #0x53]
00685BAD8  tbnz     w8, #5, #0x685bb34
00685BADC  ldr      x0, [x24, #0x230]
00685BAE0  b        #0x685bb40 ; 
00685BAE4  ldr      x9, [x8, #0x60]
00685BAE8  str      x8, [sp, #0x88]
00685BAEC  and      w8, w20, #1
00685BAF0  and      w7, w26, #1
00685BAF4  mov      x0, x28
00685BAF8  ldr      x1, [sp, #0x18]
00685BAFC  ldr      x2, [sp, #8]
00685BB00  mov      x3, x21
00685BB04  mov      w4, w22
00685BB08  mov      x5, x25
00685BB0C  mov      x6, x27
00685BB10  ldp      x20, x19, [sp, #0x70]
00685BB14  ldp      x22, x21, [sp, #0x60]
00685BB18  ldp      x24, x23, [sp, #0x50]
00685BB1C  ldp      x26, x25, [sp, #0x40]
00685BB20  ldp      x28, x27, [sp, #0x30]
00685BB24  ldp      x29, x30, [sp, #0x20]
00685BB28  strb     w8, [sp, #0x80]
00685BB2C  add      sp, sp, #0x80
00685BB30  br       x9
00685BB34  ldr      x8, [x1, #0x60]
00685BB38  mov      x0, x24
00685BB3C  blr      x8
00685BB40  cbz      x0, #0x685bf1c
00685BB44  adrp     x8, #0x8f08000
00685BB48  ldr      x8, [x8, #0xbb8]
00685BB4C  ldr      x1, [x8]
00685BB50  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
00685BB54  ldr      x2, [sp, #8]
00685BB58  mov      x1, x0
00685BB5C  mov      x0, x28
00685BB60  str      x1, [sp]
00685BB64  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
00685BB68  cbz      x27, #0x685bf1c
00685BB6C  ldr      x29, [x27, #0x18]
00685BB70  tbz      w20, #0, #0x685bb80
00685BB74  ldr      w8, [x25]
00685BB78  str      w8, [sp, #0x14]
00685BB7C  b        #0x685bcd4 ; 
00685BB80  mov      x20, x28
00685BB84  mov      w23, w26
00685BB88  cmp      w29, #1
00685BB8C  b.lt     #0x685bbb0
00685BB90  mov      w28, wzr
00685BB94  and      x8, x29, #0xffffffff
00685BB98  add      x9, x27, #0x20
00685BB9C  ldr      w10, [x9], #4
00685BBA0  subs     x8, x8, #1
00685BBA4  add      w28, w10, w28
00685BBA8  b.ne     #0x685bb9c
00685BBAC  b        #0x685bbb4 ; 
00685BBB0  mov      w28, wzr
00685BBB4  mov      x0, x20
00685BBB8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BBBC  cbz      x0, #0x685bf1c
00685BBC0  adrp     x19, #0x9599000
00685BBC4  ldrb     w8, [x19, #0xac6]
00685BBC8  mov      x26, x0
00685BBCC  cbnz     w8, #0x685bbe4
00685BBD0  adrp     x0, #0x8f0d000
00685BBD4  ldr      x0, [x0, #0x28]
00685BBD8  bl       #0x382bd14 ; 
00685BBDC  mov      w8, #1
00685BBE0  strb     w8, [x19, #0xac6]
00685BBE4  adrp     x8, #0x8f0d000
00685BBE8  ldr      x8, [x8, #0x28]
00685BBEC  ldr      x3, [x8]
00685BBF0  ldrb     w8, [x3, #0x53]
00685BBF4  tbnz     w8, #5, #0x685bc34
00685BBF8  adrp     x19, #0x9599000
00685BBFC  ldrb     w8, [x19, #0xac7]
00685BC00  cbnz     w8, #0x685bc18
00685BC04  adrp     x0, #0x8f0d000
00685BC08  ldr      x0, [x0, #0x30]
00685BC0C  bl       #0x382bd14 ; 
00685BC10  mov      w8, #1
00685BC14  strb     w8, [x19, #0xac7]
00685BC18  adrp     x8, #0x8f0d000
00685BC1C  ldr      x8, [x8, #0x30]
00685BC20  ldr      x1, [x8]
00685BC24  ldrb     w8, [x1, #0x53]
00685BC28  tbnz     w8, #5, #0x685bc4c
00685BC2C  ldr      x0, [x26, #0x260]
00685BC30  b        #0x685bc58 ; 
00685BC34  ldr      x8, [x3, #0x60]
00685BC38  mov      x0, x26
00685BC3C  mov      w1, wzr
00685BC40  mov      w2, w28
00685BC44  blr      x8
00685BC48  b        #0x685bc78 ; 
00685BC4C  ldr      x8, [x1, #0x60]
00685BC50  mov      x0, x26
00685BC54  blr      x8
00685BC58  cbz      x0, #0x685bf1c
00685BC5C  mov      w1, wzr
00685BC60  mov      w2, w28
00685BC64  mov      x3, xzr
00685BC68  bl       #0x416d068 ; XXRandom$$Next
00685BC6C  ldr      w8, [x26, #0x32c]
00685BC70  add      w8, w8, #1
00685BC74  str      w8, [x26, #0x32c]
00685BC78  subs     w8, w29, #1
00685BC7C  mov      x28, x20
00685BC80  b.lt     #0x685bcb8
00685BC84  ldr      w11, [x27, #0x18]
00685BC88  mov      w10, wzr
00685BC8C  mov      w9, wzr
00685BC90  cmp      w11, w9
00685BC94  b.eq     #0x685bf20
00685BC98  add      x12, x27, w9, sxtw #2
00685BC9C  ldr      w12, [x12, #0x20]
00685BCA0  add      w10, w12, w10
00685BCA4  cmp      w0, w10
00685BCA8  b.lt     #0x685bcbc
00685BCAC  add      w9, w9, #1
00685BCB0  cmp      w29, w9
00685BCB4  b.ne     #0x685bc90
00685BCB8  mov      w9, wzr
00685BCBC  cmp      w9, w8
00685BCC0  cset     w8, lt
00685BCC4  and      w8, w8, w23
00685BCC8  add      w8, w9, w8
00685BCCC  str      w8, [sp, #0x14]
00685BCD0  str      w8, [x25]
00685BCD4  mov      x0, x28
00685BCD8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BCDC  cbz      x0, #0x685bf1c
00685BCE0  ldrb     w8, [x0, #0x25]
00685BCE4  cbz      w8, #0x685bd04
00685BCE8  mov      x0, x28
00685BCEC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BCF0  cbz      x0, #0x685bf1c
00685BCF4  ldr      w8, [x0, #0x28]
00685BCF8  sub      w8, w8, #1
00685BCFC  str      w8, [sp, #0x14]
00685BD00  str      w8, [x25]
00685BD04  subs     w24, w29, #1
00685BD08  b.mi     #0x685be34
00685BD0C  cmp      w22, #1
00685BD10  b.lt     #0x685be34
00685BD14  cbz      x21, #0x685bf1c
00685BD18  mov      w20, wzr
00685BD1C  mov      w25, w22
00685BD20  ldr      w9, [sp, #0x14]
00685BD24  ldr      w8, [x21, #0x18]
00685BD28  add      w9, w9, w20
00685BD2C  sdiv     w10, w9, w29
00685BD30  msub     w19, w10, w29, w9
00685BD34  cmp      w19, w8
00685BD38  b.hs     #0x685bf20
00685BD3C  add      x8, x21, w19, sxtw #3
00685BD40  ldr      x26, [x8, #0x20]
00685BD44  cbz      x26, #0x685bf1c
00685BD48  ldr      x1, [sp, #0x18]
00685BD4C  mov      x0, x26
00685BD50  mov      x2, xzr
00685BD54  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685BD58  cmp      w0, #1
00685BD5C  b.lt     #0x685be14
00685BD60  mov      w27, w0
00685BD64  mov      x0, x28
00685BD68  mov      x23, x21
00685BD6C  mov      w21, w22
00685BD70  mov      x22, x28
00685BD74  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BD78  cbz      x0, #0x685bf1c
00685BD7C  mov      x1, xzr
00685BD80  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00685BD84  adrp     x8, #0x8ebf000
00685BD88  ldr      x8, [x8, #0x840]
00685BD8C  mov      w28, w0
00685BD90  ldr      x8, [x8]
00685BD94  ldr      w9, [x8, #0xe0]
00685BD98  cbnz     w9, #0x685bda4
00685BD9C  mov      x0, x8
00685BDA0  bl       #0x382be8c ; 
00685BDA4  mov      w0, w27
00685BDA8  mov      w1, w25
00685BDAC  mov      x2, xzr
00685BDB0  bl       #0x7bd69a0 ; System.Math$$Min
00685BDB4  mov      w27, w0
00685BDB8  tbz      w28, #0, #0x685bde8
00685BDBC  ldr      x28, [sp, #0x18]
00685BDC0  mov      x0, x26
00685BDC4  mov      x2, xzr
00685BDC8  mov      x1, x28
00685BDCC  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685BDD0  mov      w1, w0
00685BDD4  mov      w0, w27
00685BDD8  mov      x2, xzr
00685BDDC  bl       #0x7bd69a0 ; System.Math$$Min
00685BDE0  mov      w27, w0
00685BDE4  b        #0x685bdec ; 
00685BDE8  ldr      x28, [sp, #0x18]
00685BDEC  ldp      x4, x3, [sp]
00685BDF0  mov      x0, x26
00685BDF4  mov      w1, w27
00685BDF8  mov      x2, x28
00685BDFC  mov      x5, xzr
00685BE00  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
00685BE04  sub      w25, w25, w27
00685BE08  mov      x28, x22
00685BE0C  mov      w22, w21
00685BE10  mov      x21, x23
00685BE14  cmp      w22, #1
00685BE18  b.ne     #0x685be20
00685BE1C  str      w19, [x28, #0x60]
00685BE20  add      w20, w20, #1
00685BE24  cmp      w20, w24
00685BE28  b.gt     #0x685be34
00685BE2C  cmp      w25, #0
00685BE30  b.gt     #0x685bd20
00685BE34  ldr      x8, [sp, #0x18]
00685BE38  cbz      x8, #0x685bf1c
00685BE3C  ldr      w8, [x8, #0x18]
00685BE40  adrp     x20, #0x9591000
00685BE44  cmp      w8, w22
00685BE48  b.ge     #0x685be94
00685BE4C  adrp     x8, #0x8ee1000
00685BE50  ldr      x8, [x8, #0x6e8]
00685BE54  ldr      x0, [x8]
00685BE58  ldr      w8, [x0, #0xe0]
00685BE5C  cbnz     w8, #0x685be64
00685BE60  bl       #0x382be8c ; 
00685BE64  adrp     x8, #0x8f23000
00685BE68  adrp     x9, #0x8f23000
00685BE6C  adrp     x10, #0x8f23000
00685BE70  ldr      x8, [x8, #0xa48]
00685BE74  ldr      x9, [x9, #0xa40]
00685BE78  ldr      x10, [x10, #0xa38]
00685BE7C  mov      w3, #0x185
00685BE80  ldr      x0, [x8]
00685BE84  ldr      x1, [x9]
00685BE88  ldr      x2, [x10]
00685BE8C  mov      x4, xzr
00685BE90  bl       #0x7997754 ; Logger$$LogError
00685BE94  mov      x0, x28
00685BE98  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685BE9C  cbz      x0, #0x685bf1c
00685BEA0  ldrb     w8, [x20, #0xa90]
00685BEA4  mov      x19, x0
00685BEA8  cbnz     w8, #0x685bec0
00685BEAC  adrp     x0, #0x8ee6000
00685BEB0  ldr      x0, [x0, #0x3e0]
00685BEB4  bl       #0x382bd14 ; 
00685BEB8  mov      w8, #1
00685BEBC  strb     w8, [x20, #0xa90]
00685BEC0  adrp     x8, #0x8ee6000
00685BEC4  ldr      x8, [x8, #0x3e0]
00685BEC8  ldr      x1, [x8]
00685BECC  ldrb     w8, [x1, #0x53]
00685BED0  tbnz     w8, #5, #0x685bedc
00685BED4  ldr      x0, [x19, #0x230]
00685BED8  b        #0x685bee8 ; 
00685BEDC  ldr      x8, [x1, #0x60]
00685BEE0  mov      x0, x19
00685BEE4  blr      x8
00685BEE8  cbz      x0, #0x685bf1c
00685BEEC  adrp     x8, #0x8f08000
00685BEF0  ldr      x8, [x8, #0xbc0]
00685BEF4  ldr      x1, [sp]
00685BEF8  ldp      x20, x19, [sp, #0x70]
00685BEFC  ldp      x22, x21, [sp, #0x60]
00685BF00  ldr      x2, [x8]
00685BF04  ldp      x24, x23, [sp, #0x50]
00685BF08  ldp      x26, x25, [sp, #0x40]
00685BF0C  ldp      x28, x27, [sp, #0x30]
00685BF10  ldp      x29, x30, [sp, #0x20]
00685BF14  add      sp, sp, #0x80
00685BF18  b        #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
00685BF1C  bl       #0x382bfb8 ; 
00685BF20  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
; RVA 0x68633D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068633D4  stp      x29, x30, [sp, #-0x60]!
0068633D8  stp      x28, x27, [sp, #0x10]
0068633DC  stp      x26, x25, [sp, #0x20]
0068633E0  stp      x24, x23, [sp, #0x30]
0068633E4  stp      x22, x21, [sp, #0x40]
0068633E8  stp      x20, x19, [sp, #0x50]
0068633EC  adrp     x22, #0x959b000
0068633F0  adrp     x23, #0x8f23000
0068633F4  ldrb     w8, [x22, #0xa8e]
0068633F8  ldr      x23, [x23, #0xd40]
0068633FC  mov      x19, x2
006863400  mov      x20, x1
006863404  mov      x21, x0
006863408  tbnz     w8, #0, #0x6863444
00686340C  adrp     x0, #0x8f23000
006863410  ldr      x0, [x0, #0xd40]
006863414  bl       #0x382bd14 ; 
006863418  adrp     x0, #0x8ec2000
00686341C  ldr      x0, [x0, #0x260]
006863420  bl       #0x382bd14 ; 
006863424  adrp     x0, #0x8ec2000
006863428  ldr      x0, [x0, #0x268]
00686342C  bl       #0x382bd14 ; 
006863430  adrp     x0, #0x8ec2000
006863434  ldr      x0, [x0, #0x270]
006863438  bl       #0x382bd14 ; 
00686343C  mov      w8, #1
006863440  strb     w8, [x22, #0xa8e]
006863444  ldr      x3, [x23]
006863448  ldrb     w8, [x3, #0x53]
00686344C  tbnz     w8, #5, #0x686365c
006863450  cbz      x19, #0x6863688
006863454  ldr      w8, [x19, #0x18]
006863458  cmp      w8, #1
00686345C  b.lt     #0x6863640
006863460  adrp     x23, #0x8f06000
006863464  adrp     x24, #0x8f23000
006863468  adrp     x28, #0x8ec2000
00686346C  ldr      x23, [x23, #0x470]
006863470  ldr      x24, [x24, #0xd48]
006863474  ldr      x28, [x28, #0x260]
006863478  mov      w22, wzr
00686347C  mov      w29, #1
006863480  adrp     x27, #0x959b000
006863484  adrp     x8, #0x8ec2000
006863488  ldr      x8, [x8, #0x270]
00686348C  mov      x0, x19
006863490  mov      w1, w22
006863494  ldr      x2, [x8]
006863498  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00686349C  mov      w25, w0
0068634A0  mov      x0, x21
0068634A4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068634A8  cbz      x0, #0x6863688
0068634AC  adrp     x8, #0x9598000
0068634B0  ldrb     w8, [x8, #0xfcc]
0068634B4  mov      x26, x0
0068634B8  cbnz     w8, #0x68634cc
0068634BC  mov      x0, x23
0068634C0  bl       #0x382bd14 ; 
0068634C4  adrp     x8, #0x9598000
0068634C8  strb     w29, [x8, #0xfcc]
0068634CC  ldr      x1, [x23]
0068634D0  ldrb     w8, [x1, #0x53]
0068634D4  tbnz     w8, #5, #0x68634e0
0068634D8  ldr      x0, [x26, #0x200]
0068634DC  b        #0x68634ec ; 
0068634E0  ldr      x8, [x1, #0x60]
0068634E4  mov      x0, x26
0068634E8  blr      x8
0068634EC  cbz      x0, #0x6863688
0068634F0  mov      w1, w25
0068634F4  mov      x2, xzr
0068634F8  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0068634FC  cbz      x0, #0x6863630
006863500  ldrb     w8, [x27, #0xbae]
006863504  mov      x25, x0
006863508  cbnz     w8, #0x6863518
00686350C  mov      x0, x24
006863510  bl       #0x382bd14 ; 
006863514  strb     w29, [x27, #0xbae]
006863518  ldr      x1, [x24]
00686351C  ldrb     w8, [x1, #0x53]
006863520  tbnz     w8, #5, #0x6863530
006863524  ldr      x0, [x25, #0x90]
006863528  cbnz     x0, #0x6863540
00686352C  b        #0x6863630 ; 
006863530  ldr      x8, [x1, #0x60]
006863534  mov      x0, x25
006863538  blr      x8
00686353C  cbz      x0, #0x6863630
006863540  mov      x26, xzr
006863544  ldrb     w8, [x27, #0xbae]
006863548  cbnz     w8, #0x6863558
00686354C  mov      x0, x24
006863550  bl       #0x382bd14 ; 
006863554  strb     w29, [x27, #0xbae]
006863558  ldr      x1, [x24]
00686355C  ldrb     w8, [x1, #0x53]
006863560  tbnz     w8, #5, #0x686356c
006863564  ldr      x0, [x25, #0x90]
006863568  b        #0x6863578 ; 
00686356C  ldr      x8, [x1, #0x60]
006863570  mov      x0, x25
006863574  blr      x8
006863578  cbz      x0, #0x6863688
00686357C  ldrsw    x8, [x0, #0x18]
006863580  cmp      x26, x8
006863584  b.ge     #0x6863630
006863588  ldrb     w8, [x27, #0xbae]
00686358C  cbnz     w8, #0x686359c
006863590  mov      x0, x24
006863594  bl       #0x382bd14 ; 
006863598  strb     w29, [x27, #0xbae]
00686359C  ldr      x1, [x24]
0068635A0  ldrb     w8, [x1, #0x53]
0068635A4  tbnz     w8, #5, #0x68635b0
0068635A8  ldr      x0, [x25, #0x90]
0068635AC  b        #0x68635bc ; 
0068635B0  ldr      x8, [x1, #0x60]
0068635B4  mov      x0, x25
0068635B8  blr      x8
0068635BC  cbz      x0, #0x6863688
0068635C0  ldr      w8, [x0, #0x18]
0068635C4  cmp      x26, x8
0068635C8  b.hs     #0x686368c
0068635CC  cbz      x20, #0x6863688
0068635D0  add      x8, x0, x26, lsl #2
0068635D4  ldr      w10, [x20, #0x1c]
0068635D8  ldr      w1, [x8, #0x20]
0068635DC  ldr      x8, [x20, #0x10]
0068635E0  ldr      x9, [x28]
0068635E4  add      w10, w10, #1
0068635E8  str      w10, [x20, #0x1c]
0068635EC  cbz      x8, #0x6863688
0068635F0  ldrsw    x10, [x20, #0x18]
0068635F4  ldr      w11, [x8, #0x18]
0068635F8  cmp      w10, w11
0068635FC  b.hs     #0x6863614
006863600  add      w9, w10, #1
006863604  add      x8, x8, x10, lsl #2
006863608  str      w9, [x20, #0x18]
00686360C  str      w1, [x8, #0x20]
006863610  b        #0x6863628 ; 
006863614  ldr      x8, [x9, #0x20]
006863618  mov      x0, x20
00686361C  ldr      x8, [x8, #0xc0]
006863620  ldr      x2, [x8, #0x70]
006863624  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006863628  add      x26, x26, #1
00686362C  b        #0x6863544 ; 
006863630  ldr      w8, [x19, #0x18]
006863634  add      w22, w22, #1
006863638  cmp      w22, w8
00686363C  b.lt     #0x6863484
006863640  ldp      x20, x19, [sp, #0x50]
006863644  ldp      x22, x21, [sp, #0x40]
006863648  ldp      x24, x23, [sp, #0x30]
00686364C  ldp      x26, x25, [sp, #0x20]
006863650  ldp      x28, x27, [sp, #0x10]
006863654  ldp      x29, x30, [sp], #0x60
006863658  ret      
00686365C  ldr      x4, [x3, #0x60]
006863660  mov      x0, x21
006863664  mov      x1, x20
006863668  mov      x2, x19
00686366C  ldp      x20, x19, [sp, #0x50]
006863670  ldp      x22, x21, [sp, #0x40]
006863674  ldp      x24, x23, [sp, #0x30]
006863678  ldp      x26, x25, [sp, #0x20]
00686367C  ldp      x28, x27, [sp, #0x10]
006863680  ldp      x29, x30, [sp], #0x60
006863684  br       x4
006863688  bl       #0x382bfb8 ; 
00686368C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.HeroSkillCreator$$IsFirst
; RVA 0x6872C24; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872C24  stp      x30, x21, [sp, #-0x20]!
006872C28  stp      x20, x19, [sp, #0x10]
006872C2C  adrp     x20, #0x959b000
006872C30  adrp     x21, #0x8f24000
006872C34  ldrb     w8, [x20, #0xa8f]
006872C38  ldr      x21, [x21, #0x410]
006872C3C  mov      x19, x0
006872C40  tbnz     w8, #0, #0x6872c58
006872C44  adrp     x0, #0x8f24000
006872C48  ldr      x0, [x0, #0x410]
006872C4C  bl       #0x382bd14 ; 
006872C50  mov      w8, #1
006872C54  strb     w8, [x20, #0xa8f]
006872C58  ldr      x1, [x21]
006872C5C  ldrb     w8, [x1, #0x53]
006872C60  tbnz     w8, #5, #0x6872c74
006872C64  ldp      x20, x19, [sp, #0x10]
006872C68  mov      w0, wzr
006872C6C  ldp      x30, x21, [sp], #0x20
006872C70  ret      
006872C74  ldr      x2, [x1, #0x60]
006872C78  mov      x0, x19
006872C7C  ldp      x20, x19, [sp, #0x10]
006872C80  ldp      x30, x21, [sp], #0x20
006872C84  br       x2

; HotFix.BattleLogic.HeroSkillCreator$$CheckIsSpecialSkill
; RVA 0x6872C88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872C88  str      x30, [sp, #-0x30]!
006872C8C  stp      x22, x21, [sp, #0x10]
006872C90  stp      x20, x19, [sp, #0x20]
006872C94  adrp     x21, #0x959b000
006872C98  adrp     x22, #0x8f24000
006872C9C  ldrb     w8, [x21, #0xa90]
006872CA0  ldr      x22, [x22, #0x418]
006872CA4  mov      w19, w1
006872CA8  mov      x20, x0
006872CAC  tbnz     w8, #0, #0x6872cc4
006872CB0  adrp     x0, #0x8f24000
006872CB4  ldr      x0, [x0, #0x418]
006872CB8  bl       #0x382bd14 ; 
006872CBC  mov      w8, #1
006872CC0  strb     w8, [x21, #0xa90]
006872CC4  ldr      x2, [x22]
006872CC8  ldrb     w8, [x2, #0x53]
006872CCC  tbnz     w8, #5, #0x6872ce0
006872CD0  ldp      x20, x19, [sp, #0x20]
006872CD4  ldp      x22, x21, [sp, #0x10]
006872CD8  ldr      x30, [sp], #0x30
006872CDC  ret      
006872CE0  ldr      x3, [x2, #0x60]
006872CE4  mov      x0, x20
006872CE8  mov      w1, w19
006872CEC  ldp      x20, x19, [sp, #0x20]
006872CF0  ldp      x22, x21, [sp, #0x10]
006872CF4  ldr      x30, [sp], #0x30
006872CF8  br       x3

; HotFix.BattleLogic.HeroSkillCreator$$BuildGroupToBaseSkillMap
; RVA 0x687216C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687216C  stp      x30, x21, [sp, #-0x20]!
006872170  stp      x20, x19, [sp, #0x10]
006872174  adrp     x20, #0x959b000
006872178  adrp     x21, #0x8f24000
00687217C  ldrb     w8, [x20, #0xa91]
006872180  ldr      x21, [x21, #0x3d8]
006872184  mov      x19, x0
006872188  tbnz     w8, #0, #0x68721a0
00687218C  adrp     x0, #0x8f24000
006872190  ldr      x0, [x0, #0x3d8]
006872194  bl       #0x382bd14 ; 
006872198  mov      w8, #1
00687219C  strb     w8, [x20, #0xa91]
0068721A0  ldr      x1, [x21]
0068721A4  ldrb     w8, [x1, #0x53]
0068721A8  tbnz     w8, #5, #0x68721f8
0068721AC  mov      x0, x19
0068721B0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068721B4  cbz      x0, #0x687222c
0068721B8  adrp     x20, #0x9598000
0068721BC  ldrb     w8, [x20, #0xfcc]
0068721C0  mov      x19, x0
0068721C4  cbnz     w8, #0x68721dc
0068721C8  adrp     x0, #0x8f06000
0068721CC  ldr      x0, [x0, #0x470]
0068721D0  bl       #0x382bd14 ; 
0068721D4  mov      w8, #1
0068721D8  strb     w8, [x20, #0xfcc]
0068721DC  adrp     x8, #0x8f06000
0068721E0  ldr      x8, [x8, #0x470]
0068721E4  ldr      x1, [x8]
0068721E8  ldrb     w8, [x1, #0x53]
0068721EC  tbnz     w8, #5, #0x687220c
0068721F0  ldr      x0, [x19, #0x200]
0068721F4  b        #0x6872218 ; 
0068721F8  ldr      x2, [x1, #0x60]
0068721FC  mov      x0, x19
006872200  ldp      x20, x19, [sp, #0x10]
006872204  ldp      x30, x21, [sp], #0x20
006872208  br       x2
00687220C  ldr      x8, [x1, #0x60]
006872210  mov      x0, x19
006872214  blr      x8
006872218  ldp      x20, x19, [sp, #0x10]
00687221C  mov      w1, wzr
006872220  mov      x2, xzr
006872224  ldp      x30, x21, [sp], #0x20
006872228  b        #0x692b8c0 ; HotFix.BattleLogic.SkillTableHelper$$GetBaseSkillByGroup
00687222C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroSkillCreator$$.ctor
; RVA 0x685C358; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685C358  stp      x30, x21, [sp, #-0x20]!
00685C35C  stp      x20, x19, [sp, #0x10]
00685C360  adrp     x20, #0x959b000
00685C364  adrp     x21, #0x8f23000
00685C368  ldrb     w8, [x20, #0xa92]
00685C36C  ldr      x21, [x21, #0xa90]
00685C370  mov      x19, x0
00685C374  tbnz     w8, #0, #0x685c38c
00685C378  adrp     x0, #0x8f23000
00685C37C  ldr      x0, [x0, #0xa90]
00685C380  bl       #0x382bd14 ; 
00685C384  mov      w8, #1
00685C388  strb     w8, [x20, #0xa92]
00685C38C  ldr      x1, [x21]
00685C390  ldrb     w8, [x1, #0x53]
00685C394  tbnz     w8, #5, #0x685c3ac
00685C398  mov      x0, x19
00685C39C  ldp      x20, x19, [sp, #0x10]
00685C3A0  mov      x1, xzr
00685C3A4  ldp      x30, x21, [sp], #0x20
00685C3A8  b        #0x7c335dc ; System.Object$$.ctor
00685C3AC  ldr      x2, [x1, #0x60]
00685C3B0  mov      x0, x19
00685C3B4  ldp      x20, x19, [sp, #0x10]
00685C3B8  ldp      x30, x21, [sp], #0x20
00685C3BC  br       x2

