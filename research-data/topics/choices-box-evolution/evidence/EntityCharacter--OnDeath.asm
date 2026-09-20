; HotFix.BattleLogic.EntityCharacter$$OnDeath
; RVA 0x67DEC14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067DEC14  sub      sp, sp, #0x90
0067DEC18  str      x30, [sp, #0x40]
0067DEC1C  stp      x26, x25, [sp, #0x50]
0067DEC20  stp      x24, x23, [sp, #0x60]
0067DEC24  stp      x22, x21, [sp, #0x70]
0067DEC28  stp      x20, x19, [sp, #0x80]
0067DEC2C  mrs      x25, tpidr_el0
0067DEC30  ldr      x8, [x25, #0x28]
0067DEC34  adrp     x21, #0x959b000
0067DEC38  adrp     x22, #0x8f1e000
0067DEC3C  mov      x20, x1
0067DEC40  str      x8, [sp, #0x38]
0067DEC44  ldrb     w8, [x21, #0x1ff]
0067DEC48  ldr      x22, [x22, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnDeath() @ 0x92629a0
0067DEC4C  mov      x19, x0
0067DEC50  tbnz     w8, #0, #0x67dec98
0067DEC54  adrp     x0, #0x8ee6000
0067DEC58  ldr      x0, [x0, #0xab0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent() @ 0x9210168
0067DEC5C  bl       #0x382bd14 ; 
0067DEC60  adrp     x0, #0x8ee6000
0067DEC64  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0067DEC68  bl       #0x382bd14 ; 
0067DEC6C  adrp     x0, #0x8f1e000
0067DEC70  ldr      x0, [x0, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnDeath() @ 0x92629a0
0067DEC74  bl       #0x382bd14 ; 
0067DEC78  adrp     x0, #0x8ee6000
0067DEC7C  ldr      x0, [x0, #0x108] ; GLOBAL Method$HotFix.BattleLogic.EntityManager.GetEntity<EntityCharacter>() @ 0x9263bc0
0067DEC80  bl       #0x382bd14 ; 
0067DEC84  adrp     x0, #0x8ec2000
0067DEC88  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
0067DEC8C  bl       #0x382bd14 ; 
0067DEC90  mov      w8, #1
0067DEC94  strb     w8, [x21, #0x1ff]
0067DEC98  ldr      x2, [x22]
0067DEC9C  ldrb     w8, [x2, #0x53]
0067DECA0  tbnz     w8, #5, #0x67dece4
0067DECA4  cbz      x20, #0x67df148
0067DECA8  adrp     x21, #0x959a000
0067DECAC  ldrb     w8, [x21, #0x10f]
0067DECB0  cbnz     w8, #0x67decc8
0067DECB4  adrp     x0, #0x8f11000
0067DECB8  ldr      x0, [x0, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_Hero() @ 0x92b1888
0067DECBC  bl       #0x382bd14 ; 
0067DECC0  mov      w8, #1
0067DECC4  strb     w8, [x21, #0x10f]
0067DECC8  adrp     x8, #0x8f11000
0067DECCC  ldr      x8, [x8, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_Hero() @ 0x92b1888
0067DECD0  ldr      x1, [x8]
0067DECD4  ldrb     w8, [x1, #0x53]
0067DECD8  tbnz     w8, #5, #0x67decf8
0067DECDC  ldr      x21, [x20, #0x30]
0067DECE0  b        #0x67ded08 ; 
0067DECE4  ldr      x8, [x2, #0x60]
0067DECE8  mov      x0, x19
0067DECEC  mov      x1, x20
0067DECF0  blr      x8
0067DECF4  b        #0x67df11c ; 
0067DECF8  ldr      x8, [x1, #0x60]
0067DECFC  mov      x0, x20
0067DED00  blr      x8
0067DED04  mov      x21, x0
0067DED08  adrp     x22, #0x959b000
0067DED0C  ldrb     w8, [x22, #0x397]
0067DED10  cbnz     w8, #0x67ded28
0067DED14  adrp     x0, #0x8f1e000
0067DED18  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_Attacker() @ 0x92b1860
0067DED1C  bl       #0x382bd14 ; 
0067DED20  mov      w8, #1
0067DED24  strb     w8, [x22, #0x397]
0067DED28  adrp     x8, #0x8f1e000
0067DED2C  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_Attacker() @ 0x92b1860
0067DED30  ldr      x1, [x8]
0067DED34  ldrb     w8, [x1, #0x53]
0067DED38  tbnz     w8, #5, #0x67ded44
0067DED3C  ldr      x22, [x20, #0x38]
0067DED40  b        #0x67ded54 ; 
0067DED44  ldr      x8, [x1, #0x60]
0067DED48  mov      x0, x20
0067DED4C  blr      x8
0067DED50  mov      x22, x0
0067DED54  mov      x0, xzr
0067DED58  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
0067DED5C  mov      x1, x0
0067DED60  mov      x0, x22
0067DED64  mov      x2, xzr
0067DED68  bl       #0x7db81fc ; Quantum.EntityRef$$op_Inequality
0067DED6C  mov      x23, xzr
0067DED70  tbz      w0, #0, #0x67dee28
0067DED74  adrp     x23, #0x9591000
0067DED78  ldrb     w8, [x23, #0xa4b]
0067DED7C  cbnz     w8, #0x67ded94
0067DED80  adrp     x0, #0x8ee5000
0067DED84  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067DED88  bl       #0x382bd14 ; 
0067DED8C  mov      w8, #1
0067DED90  strb     w8, [x23, #0xa4b]
0067DED94  adrp     x8, #0x8ee5000
0067DED98  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067DED9C  ldr      x1, [x8]
0067DEDA0  ldrb     w8, [x1, #0x53]
0067DEDA4  tbnz     w8, #5, #0x67dedb0
0067DEDA8  ldr      x23, [x19, #0x20]
0067DEDAC  b        #0x67dedc0 ; 
0067DEDB0  ldr      x8, [x1, #0x60]
0067DEDB4  mov      x0, x19
0067DEDB8  blr      x8
0067DEDBC  mov      x23, x0
0067DEDC0  cbz      x23, #0x67df148
0067DEDC4  adrp     x24, #0x9591000
0067DEDC8  ldrb     w8, [x24, #0xa62]
0067DEDCC  cbnz     w8, #0x67dede4
0067DEDD0  adrp     x0, #0x8ee6000
0067DEDD4  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0067DEDD8  bl       #0x382bd14 ; 
0067DEDDC  mov      w8, #1
0067DEDE0  strb     w8, [x24, #0xa62]
0067DEDE4  adrp     x8, #0x8ee6000
0067DEDE8  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0067DEDEC  ldr      x1, [x8]
0067DEDF0  ldrb     w8, [x1, #0x53]
0067DEDF4  tbnz     w8, #5, #0x67dee00
0067DEDF8  ldr      x0, [x23, #0x1f8]
0067DEDFC  b        #0x67dee0c ; 
0067DEE00  ldr      x8, [x1, #0x60]
0067DEE04  mov      x0, x23
0067DEE08  blr      x8
0067DEE0C  cbz      x0, #0x67df148
0067DEE10  adrp     x8, #0x8ee6000
0067DEE14  ldr      x8, [x8, #0x108] ; GLOBAL Method$HotFix.BattleLogic.EntityManager.GetEntity<EntityCharacter>() @ 0x9263bc0
0067DEE18  mov      x1, x22
0067DEE1C  ldr      x2, [x8]
0067DEE20  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0067DEE24  mov      x23, x0
0067DEE28  mov      x0, xzr
0067DEE2C  bl       #0x7db81d8 ; Quantum.EntityRef$$get_None
0067DEE30  mov      x1, x0
0067DEE34  mov      x0, x21
0067DEE38  mov      x2, xzr
0067DEE3C  bl       #0x7db81fc ; Quantum.EntityRef$$op_Inequality
0067DEE40  mov      x24, xzr
0067DEE44  tbz      w0, #0, #0x67deefc
0067DEE48  adrp     x24, #0x9591000
0067DEE4C  ldrb     w8, [x24, #0xa4b]
0067DEE50  cbnz     w8, #0x67dee68
0067DEE54  adrp     x0, #0x8ee5000
0067DEE58  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067DEE5C  bl       #0x382bd14 ; 
0067DEE60  mov      w8, #1
0067DEE64  strb     w8, [x24, #0xa4b]
0067DEE68  adrp     x8, #0x8ee5000
0067DEE6C  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067DEE70  ldr      x1, [x8]
0067DEE74  ldrb     w8, [x1, #0x53]
0067DEE78  tbnz     w8, #5, #0x67dee84
0067DEE7C  ldr      x24, [x19, #0x20]
0067DEE80  b        #0x67dee94 ; 
0067DEE84  ldr      x8, [x1, #0x60]
0067DEE88  mov      x0, x19
0067DEE8C  blr      x8
0067DEE90  mov      x24, x0
0067DEE94  cbz      x24, #0x67df148
0067DEE98  adrp     x26, #0x9591000
0067DEE9C  ldrb     w8, [x26, #0xa62]
0067DEEA0  cbnz     w8, #0x67deeb8
0067DEEA4  adrp     x0, #0x8ee6000
0067DEEA8  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0067DEEAC  bl       #0x382bd14 ; 
0067DEEB0  mov      w8, #1
0067DEEB4  strb     w8, [x26, #0xa62]
0067DEEB8  adrp     x8, #0x8ee6000
0067DEEBC  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0067DEEC0  ldr      x1, [x8]
0067DEEC4  ldrb     w8, [x1, #0x53]
0067DEEC8  tbnz     w8, #5, #0x67deed4
0067DEECC  ldr      x0, [x24, #0x1f8]
0067DEED0  b        #0x67deee0 ; 
0067DEED4  ldr      x8, [x1, #0x60]
0067DEED8  mov      x0, x24
0067DEEDC  blr      x8
0067DEEE0  cbz      x0, #0x67df148
0067DEEE4  adrp     x8, #0x8ee6000
0067DEEE8  ldr      x8, [x8, #0x108] ; GLOBAL Method$HotFix.BattleLogic.EntityManager.GetEntity<EntityCharacter>() @ 0x9263bc0
0067DEEEC  mov      x1, x21
0067DEEF0  ldr      x2, [x8]
0067DEEF4  bl       #0x457e75c ; HotFix.BattleLogic.EntityManager$$GetEntity<object>
0067DEEF8  mov      x24, x0
0067DEEFC  cbz      x23, #0x67def18
0067DEF00  mov      x0, x19
0067DEF04  mov      x1, x23
0067DEF08  mov      x2, x22
0067DEF0C  mov      w3, wzr
0067DEF10  mov      x4, x20
0067DEF14  bl       #0x67df160 ; HotFix.BattleLogic.EntityCharacter$$ProcessDeathAttacker
0067DEF18  cbz      x24, #0x67defc4
0067DEF1C  adrp     x8, #0x8ee6000
0067DEF20  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0067DEF24  ldr      x1, [x8]
0067DEF28  ldrb     w8, [x1, #0x53]
0067DEF2C  tbnz     w8, #5, #0x67def38
0067DEF30  ldr      x0, [x24, #0x38]
0067DEF34  b        #0x67def44 ; 
0067DEF38  ldr      x8, [x1, #0x60]
0067DEF3C  mov      x0, x24
0067DEF40  blr      x8
0067DEF44  cbz      x0, #0x67df148
0067DEF48  mov      x1, xzr
0067DEF4C  bl       #0x45616a8 ; 
0067DEF50  cmp      x24, x23
0067DEF54  b.eq     #0x67defc4
0067DEF58  tbz      w0, #0, #0x67defc4
0067DEF5C  adrp     x22, #0x959b000
0067DEF60  ldrb     w8, [x22, #0x399]
0067DEF64  cbnz     w8, #0x67def7c
0067DEF68  adrp     x0, #0x8f1e000
0067DEF6C  ldr      x0, [x0, #0xb88] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_IsMainWeapon() @ 0x92b1898
0067DEF70  bl       #0x382bd14 ; 
0067DEF74  mov      w8, #1
0067DEF78  strb     w8, [x22, #0x399]
0067DEF7C  adrp     x8, #0x8f1e000
0067DEF80  ldr      x8, [x8, #0xb88] ; GLOBAL Method$HotFix.BattleLogic.TakeDamageData.get_IsMainWeapon() @ 0x92b1898
0067DEF84  ldr      x1, [x8]
0067DEF88  ldrb     w8, [x1, #0x53]
0067DEF8C  tbnz     w8, #5, #0x67defa0
0067DEF90  ldrb     w8, [x20, #0x28]
0067DEF94  cmp      w8, #0
0067DEF98  cset     w0, ne
0067DEF9C  b        #0x67defac ; 
0067DEFA0  ldr      x8, [x1, #0x60]
0067DEFA4  mov      x0, x20
0067DEFA8  blr      x8
0067DEFAC  and      w3, w0, #1
0067DEFB0  mov      x0, x19
0067DEFB4  mov      x1, x24
0067DEFB8  mov      x2, x21
0067DEFBC  mov      x4, x20
0067DEFC0  bl       #0x67df160 ; HotFix.BattleLogic.EntityCharacter$$ProcessDeathAttacker
0067DEFC4  adrp     x22, #0x8ee6000
0067DEFC8  ldr      x22, [x22, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0067DEFCC  ldr      x1, [x22]
0067DEFD0  ldrb     w8, [x1, #0x53]
0067DEFD4  tbnz     w8, #5, #0x67defe0
0067DEFD8  ldr      x0, [x19, #0x38]
0067DEFDC  b        #0x67defec ; 
0067DEFE0  ldr      x8, [x1, #0x60]
0067DEFE4  mov      x0, x19
0067DEFE8  blr      x8
0067DEFEC  cbz      x0, #0x67df148
0067DEFF0  add      x8, sp, #0x20
0067DEFF4  mov      x1, xzr
0067DEFF8  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0067DEFFC  ldr      q0, [sp, #0x20]
0067DF000  ldr      x8, [sp, #0x30]
0067DF004  mov      x2, sp
0067DF008  mov      x0, x19
0067DF00C  mov      x1, x21
0067DF010  str      q0, [sp]
0067DF014  str      x8, [sp, #0x10]
0067DF018  bl       #0x67df470 ; HotFix.BattleLogic.EntityCharacter$$CheckTriggerDead
0067DF01C  adrp     x8, #0x8ec2000
0067DF020  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
0067DF024  mov      w1, #1
0067DF028  ldr      x0, [x8]
0067DF02C  bl       #0x382bdfc ; 
0067DF030  cbz      x0, #0x67df148
0067DF034  ldr      x8, [x0]
0067DF038  mov      x21, x0
0067DF03C  mov      x0, x20
0067DF040  ldr      x1, [x8, #0x40]
0067DF044  bl       #0x382be90 ; 
0067DF048  cbz      x0, #0x67df14c
0067DF04C  ldr      w8, [x21, #0x18]
0067DF050  cbz      w8, #0x67df158
0067DF054  mov      x0, x21
0067DF058  str      x20, [x0, #0x20]!
0067DF05C  mov      x1, x20
0067DF060  bl       #0x382bcb8 ; 
0067DF064  adrp     x8, #0x8ee6000
0067DF068  ldr      x8, [x8, #0xab0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent() @ 0x9210168
0067DF06C  mov      x0, x19
0067DF070  mov      w1, wzr
0067DF074  mov      x2, x21
0067DF078  ldr      x3, [x8]
0067DF07C  bl       #0x60b3770 ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0067DF080  ldr      x8, [x19, #0xa0]
0067DF084  cbz      x8, #0x67df098
0067DF088  ldr      x9, [x8, #0x18]
0067DF08C  ldr      x0, [x8, #0x40]
0067DF090  ldr      x1, [x8, #0x28]
0067DF094  blr      x9
0067DF098  ldr      x1, [x22]
0067DF09C  ldrb     w8, [x1, #0x53]
0067DF0A0  tbnz     w8, #5, #0x67df0ac
0067DF0A4  ldr      x0, [x19, #0x38]
0067DF0A8  b        #0x67df0b8 ; 
0067DF0AC  ldr      x8, [x1, #0x60]
0067DF0B0  mov      x0, x19
0067DF0B4  blr      x8
0067DF0B8  cbz      x0, #0x67df148
0067DF0BC  mov      x1, xzr
0067DF0C0  bl       #0x45616a8 ; 
0067DF0C4  tbz      w0, #0, #0x67df11c
0067DF0C8  adrp     x20, #0x9591000
0067DF0CC  ldrb     w8, [x20, #0xa4b]
0067DF0D0  cbnz     w8, #0x67df0e8
0067DF0D4  adrp     x0, #0x8ee5000
0067DF0D8  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067DF0DC  bl       #0x382bd14 ; 
0067DF0E0  mov      w8, #1
0067DF0E4  strb     w8, [x20, #0xa4b]
0067DF0E8  adrp     x8, #0x8ee5000
0067DF0EC  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0067DF0F0  ldr      x1, [x8]
0067DF0F4  ldrb     w8, [x1, #0x53]
0067DF0F8  tbnz     w8, #5, #0x67df104
0067DF0FC  ldr      x0, [x19, #0x20]
0067DF100  b        #0x67df110 ; 
0067DF104  ldr      x8, [x1, #0x60]
0067DF108  mov      x0, x19
0067DF10C  blr      x8
0067DF110  cbz      x0, #0x67df148
0067DF114  mov      x1, xzr
0067DF118  bl       #0x6a009e8 ; HotFix.BattleLogic.BattleWorldContext$$ResetGameSpeed
0067DF11C  ldr      x8, [x25, #0x28]
0067DF120  ldr      x9, [sp, #0x38]
0067DF124  cmp      x8, x9
0067DF128  b.ne     #0x67df15c
0067DF12C  ldp      x20, x19, [sp, #0x80]
0067DF130  ldp      x22, x21, [sp, #0x70]
0067DF134  ldp      x24, x23, [sp, #0x60]
0067DF138  ldp      x26, x25, [sp, #0x50]
0067DF13C  ldr      x30, [sp, #0x40]
0067DF140  add      sp, sp, #0x90
0067DF144  ret      
0067DF148  bl       #0x382bfb8 ; 
0067DF14C  bl       #0x382bfdc ; 
0067DF150  mov      x1, xzr
0067DF154  bl       #0x382be7c ; 
0067DF158  bl       #0x382bfc0 ; 
0067DF15C  bl       #0x89edb60 ; 

