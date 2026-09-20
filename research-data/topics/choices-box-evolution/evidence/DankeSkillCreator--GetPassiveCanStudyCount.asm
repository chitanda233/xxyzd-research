; HotFix.BattleLogic.DankeSkillCreator$$GetPassiveCanStudyCount
; RVA 0x685DB38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685DB38  stp      x30, x23, [sp, #-0x30]!
00685DB3C  stp      x22, x21, [sp, #0x10]
00685DB40  stp      x20, x19, [sp, #0x20]
00685DB44  adrp     x19, #0x959b000
00685DB48  adrp     x21, #0x8f23000
00685DB4C  ldrb     w8, [x19, #0x9ee]
00685DB50  ldr      x21, [x21, #0xb70] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetPassiveCanStudyCount() @ 0x9259d58
00685DB54  mov      x20, x0
00685DB58  tbnz     w8, #0, #0x685dbac
00685DB5C  adrp     x0, #0x8f0c000
00685DB60  ldr      x0, [x0, #0x1c0] ; GLOBAL Method$System.Array.IndexOf<int>() @ 0x92370c8
00685DB64  bl       #0x382bd14 ; 
00685DB68  adrp     x0, #0x8ee8000
00685DB6C  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685DB70  bl       #0x382bd14 ; 
00685DB74  adrp     x0, #0x8f23000
00685DB78  ldr      x0, [x0, #0xb70] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetPassiveCanStudyCount() @ 0x9259d58
00685DB7C  bl       #0x382bd14 ; 
00685DB80  adrp     x0, #0x8f09000
00685DB84  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00685DB88  bl       #0x382bd14 ; 
00685DB8C  adrp     x0, #0x8f08000
00685DB90  ldr      x0, [x0, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
00685DB94  bl       #0x382bd14 ; 
00685DB98  adrp     x0, #0x8ebf000
00685DB9C  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685DBA0  bl       #0x382bd14 ; 
00685DBA4  mov      w8, #1
00685DBA8  strb     w8, [x19, #0x9ee]
00685DBAC  ldr      x1, [x21]
00685DBB0  ldrb     w8, [x1, #0x53]
00685DBB4  tbnz     w8, #5, #0x685dc30
00685DBB8  ldr      x0, [x20, #0x58]
00685DBBC  cbz      x0, #0x685ddc8
00685DBC0  adrp     x8, #0x8f09000
00685DBC4  ldr      x8, [x8, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
00685DBC8  ldr      x1, [x8]
00685DBCC  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00685DBD0  cbz      x0, #0x685ddc8
00685DBD4  mov      x1, xzr
00685DBD8  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
00685DBDC  adrp     x23, #0x8ee8000
00685DBE0  ldr      x23, [x23, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685DBE4  mov      w21, wzr
00685DBE8  mov      w19, wzr
00685DBEC  add      w22, w0, #1
00685DBF0  ldr      x0, [x23]
00685DBF4  ldr      w8, [x0, #0xe0]
00685DBF8  cbnz     w8, #0x685dc00
00685DBFC  bl       #0x382be8c ; 
00685DC00  mov      x0, xzr
00685DC04  bl       #0x64cb988 ; LocalModels.Const$$GetDankeSkillMaxCount
00685DC08  cmp      w21, w0
00685DC0C  b.ge     #0x685dc48
00685DC10  mov      w0, w21
00685DC14  mov      w1, w22
00685DC18  mov      x2, xzr
00685DC1C  bl       #0x64c992c ; LocalModelEx$$CheckPassiveSkillIndexIsOpen
00685DC20  and      w8, w0, #1
00685DC24  add      w19, w19, w8
00685DC28  add      w21, w21, #1
00685DC2C  b        #0x685dbf0 ; 
00685DC30  ldr      x2, [x1, #0x60]
00685DC34  mov      x0, x20
00685DC38  ldp      x20, x19, [sp, #0x20]
00685DC3C  ldp      x22, x21, [sp, #0x10]
00685DC40  ldp      x30, x23, [sp], #0x30
00685DC44  br       x2
00685DC48  mov      x0, x20
00685DC4C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685DC50  cbz      x0, #0x685ddc8
00685DC54  ldr      w8, [x0, #0x1c8]
00685DC58  cmp      w8, #2
00685DC5C  b.ne     #0x685dc7c
00685DC60  ldr      x0, [x23]
00685DC64  ldr      w8, [x0, #0xe0]
00685DC68  cbnz     w8, #0x685dc70
00685DC6C  bl       #0x382be8c ; 
00685DC70  mov      x0, xzr
00685DC74  bl       #0x64cb988 ; LocalModels.Const$$GetDankeSkillMaxCount
00685DC78  mov      w19, w0
00685DC7C  mov      x0, x20
00685DC80  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685DC84  cbz      x0, #0x685ddc8
00685DC88  ldr      x21, [x0, #0x3b8]
00685DC8C  cbz      x21, #0x685ddc8
00685DC90  adrp     x22, #0x8f08000
00685DC94  ldr      x8, [x21]
00685DC98  ldr      x22, [x22, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
00685DC9C  ldrh     w9, [x8, #0x12e]
00685DCA0  ldr      x1, [x22]
00685DCA4  cbz      x9, #0x685dcc8
00685DCA8  ldr      x10, [x8, #0xb0]
00685DCAC  add      x10, x10, #8
00685DCB0  ldur     x11, [x10, #-8]
00685DCB4  cmp      x11, x1
00685DCB8  b.eq     #0x685dcd8
00685DCBC  subs     x9, x9, #1
00685DCC0  add      x10, x10, #0x10
00685DCC4  b.ne     #0x685dcb0
00685DCC8  mov      w2, #0x1e
00685DCCC  mov      x0, x21
00685DCD0  bl       #0x3a7e710 ; 
00685DCD4  b        #0x685dce8 ; 
00685DCD8  ldr      w9, [x10]
00685DCDC  add      w9, w9, #0x1e
00685DCE0  add      x8, x8, w9, sxtw #4
00685DCE4  add      x0, x8, #0x138
00685DCE8  ldp      x8, x1, [x0]
00685DCEC  mov      x0, x21
00685DCF0  blr      x8
00685DCF4  cbz      x0, #0x685ddb4
00685DCF8  mov      x0, x20
00685DCFC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685DD00  cbz      x0, #0x685ddc8
00685DD04  ldr      x20, [x0, #0x3b8]
00685DD08  cbz      x20, #0x685ddc8
00685DD0C  ldr      x8, [x20]
00685DD10  ldr      x1, [x22]
00685DD14  ldrh     w9, [x8, #0x12e]
00685DD18  cbz      x9, #0x685dd3c
00685DD1C  ldr      x10, [x8, #0xb0]
00685DD20  add      x10, x10, #8
00685DD24  ldur     x11, [x10, #-8]
00685DD28  cmp      x11, x1
00685DD2C  b.eq     #0x685dd4c
00685DD30  subs     x9, x9, #1
00685DD34  add      x10, x10, #0x10
00685DD38  b.ne     #0x685dd24
00685DD3C  mov      w2, #0x1e
00685DD40  mov      x0, x20
00685DD44  bl       #0x3a7e710 ; 
00685DD48  b        #0x685dd5c ; 
00685DD4C  ldr      w9, [x10]
00685DD50  add      w9, w9, #0x1e
00685DD54  add      x8, x8, w9, sxtw #4
00685DD58  add      x0, x8, #0x138
00685DD5C  ldp      x8, x1, [x0]
00685DD60  mov      x0, x20
00685DD64  blr      x8
00685DD68  adrp     x8, #0x8f0c000
00685DD6C  ldr      x8, [x8, #0x1c0] ; GLOBAL Method$System.Array.IndexOf<int>() @ 0x92370c8
00685DD70  mov      w1, #2
00685DD74  ldr      x2, [x8]
00685DD78  bl       #0x47b3cd0 ; System.Array$$IndexOf<int>
00685DD7C  tbnz     w0, #0x1f, #0x685ddb4
00685DD80  adrp     x8, #0x8ebf000
00685DD84  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685DD88  ldr      x0, [x8]
00685DD8C  ldr      w8, [x0, #0xe0]
00685DD90  cbnz     w8, #0x685dd98
00685DD94  bl       #0x382be8c ; 
00685DD98  mov      w0, w19
00685DD9C  ldp      x20, x19, [sp, #0x20]
00685DDA0  ldp      x22, x21, [sp, #0x10]
00685DDA4  mov      w1, #5
00685DDA8  mov      x2, xzr
00685DDAC  ldp      x30, x23, [sp], #0x30
00685DDB0  b        #0x7bd69a0 ; System.Math$$Min
00685DDB4  mov      w0, w19
00685DDB8  ldp      x20, x19, [sp, #0x20]
00685DDBC  ldp      x22, x21, [sp, #0x10]
00685DDC0  ldp      x30, x23, [sp], #0x30
00685DDC4  ret      
00685DDC8  bl       #0x382bfb8 ; 

