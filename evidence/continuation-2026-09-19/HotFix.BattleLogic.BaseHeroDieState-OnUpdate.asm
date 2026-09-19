; HotFix.BattleLogic.BaseHeroDieState$$OnUpdate
; RVA 0x659C644; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659C644  stp      x30, x25, [sp, #-0x40]!
00659C648  stp      x24, x23, [sp, #0x10]
00659C64C  stp      x22, x21, [sp, #0x20]
00659C650  stp      x20, x19, [sp, #0x30]
00659C654  adrp     x21, #0x9599000
00659C658  adrp     x22, #0x8f08000
00659C65C  ldrb     w8, [x21, #0x313]
00659C660  ldr      x22, [x22, #0xec8] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.OnUpdate() @ 0x923b248
00659C664  mov      x20, x1
00659C668  mov      x19, x0
00659C66C  tbnz     w8, #0, #0x659c69c
00659C670  adrp     x0, #0x8f08000
00659C674  ldr      x0, [x0, #0xec8] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.OnUpdate() @ 0x923b248
00659C678  bl       #0x382bd14 ; 
00659C67C  adrp     x0, #0x8f08000
00659C680  ldr      x0, [x0, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<ReviveEvent>() @ 0x923f400
00659C684  bl       #0x382bd14 ; 
00659C688  adrp     x0, #0x8f08000
00659C68C  ldr      x0, [x0, #0xed8] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<ReviveEvent>() @ 0x92848a8
00659C690  bl       #0x382bd14 ; 
00659C694  mov      w8, #1
00659C698  strb     w8, [x21, #0x313]
00659C69C  ldr      x2, [x22]
00659C6A0  ldrb     w8, [x2, #0x53]
00659C6A4  tbnz     w8, #5, #0x659c710
00659C6A8  ldr      w8, [x19, #0x24]
00659C6AC  cmp      w8, #2
00659C6B0  b.eq     #0x659c730
00659C6B4  cmp      w8, #1
00659C6B8  b.ne     #0x659c744
00659C6BC  ldr      x8, [x19, #0x28]
00659C6C0  sub      x8, x8, x20
00659C6C4  cmp      x8, #0
00659C6C8  str      x8, [x19, #0x28]
00659C6CC  b.gt     #0x659c744
00659C6D0  ldr      w1, [x19, #0x20]
00659C6D4  sub      w8, w1, #1
00659C6D8  cmp      w8, #2
00659C6DC  b.lo     #0x659c6f0
00659C6E0  cmp      w1, #3
00659C6E4  b.eq     #0x659c7dc
00659C6E8  cmp      w1, #4
00659C6EC  b.ne     #0x659c820
00659C6F0  mov      w8, #2
00659C6F4  str      w8, [x19, #0x24]
00659C6F8  mov      x0, x19
00659C6FC  ldp      x20, x19, [sp, #0x30]
00659C700  ldp      x22, x21, [sp, #0x20]
00659C704  ldp      x24, x23, [sp, #0x10]
00659C708  ldp      x30, x25, [sp], #0x40
00659C70C  b        #0x659c4e8 ; HotFix.BattleLogic.BaseHeroDieState$$PlayerRelive
00659C710  ldr      x3, [x2, #0x60]
00659C714  mov      x0, x19
00659C718  mov      x1, x20
00659C71C  ldp      x20, x19, [sp, #0x30]
00659C720  ldp      x22, x21, [sp, #0x20]
00659C724  ldp      x24, x23, [sp, #0x10]
00659C728  ldp      x30, x25, [sp], #0x40
00659C72C  br       x3
00659C730  ldr      x8, [x19, #0x28]
00659C734  sub      x8, x8, x20
00659C738  cmp      x8, #0
00659C73C  str      x8, [x19, #0x28]
00659C740  b.le     #0x659c758
00659C744  ldp      x20, x19, [sp, #0x30]
00659C748  ldp      x22, x21, [sp, #0x20]
00659C74C  ldp      x24, x23, [sp, #0x10]
00659C750  ldp      x30, x25, [sp], #0x40
00659C754  ret      
00659C758  str      wzr, [x19, #0x24]
00659C75C  str      xzr, [x19, #0x28]
00659C760  adrp     x20, #0x9599000
00659C764  ldrb     w8, [x20, #0x4b1]
00659C768  cbnz     w8, #0x659c780
00659C76C  adrp     x0, #0x8f08000
00659C770  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C774  bl       #0x382bd14 ; 
00659C778  mov      w8, #1
00659C77C  strb     w8, [x20, #0x4b1]
00659C780  adrp     x8, #0x8f08000
00659C784  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C788  ldr      x1, [x8]
00659C78C  ldrb     w8, [x1, #0x53]
00659C790  tbnz     w8, #5, #0x659c79c
00659C794  ldr      x0, [x19, #0x10]
00659C798  b        #0x659c7a8 ; 
00659C79C  ldr      x8, [x1, #0x60]
00659C7A0  mov      x0, x19
00659C7A4  blr      x8
00659C7A8  cbz      x0, #0x659cc34
00659C7AC  mov      w1, #0x1eb1
00659C7B0  movk     w1, #4, lsl #16
00659C7B4  mov      x2, xzr
00659C7B8  bl       #0x6a074b4 ; HotFix.BattleLogic.BattleWorldContext$$PlaySound
00659C7BC  ldr      x8, [x19]
00659C7C0  mov      x0, x19
00659C7C4  ldp      x20, x19, [sp, #0x30]
00659C7C8  ldp      x22, x21, [sp, #0x20]
00659C7CC  ldp      x2, x1, [x8, #0x1c8]
00659C7D0  ldp      x24, x23, [sp, #0x10]
00659C7D4  ldp      x30, x25, [sp], #0x40
00659C7D8  br       x2
00659C7DC  mov      w8, #3
00659C7E0  str      w8, [x19, #0x24]
00659C7E4  adrp     x22, #0x9599000
00659C7E8  ldrb     w8, [x22, #0x4b1]
00659C7EC  cbnz     w8, #0x659c804
00659C7F0  adrp     x0, #0x8f08000
00659C7F4  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C7F8  bl       #0x382bd14 ; 
00659C7FC  mov      w8, #1
00659C800  strb     w8, [x22, #0x4b1]
00659C804  adrp     x23, #0x8f08000
00659C808  ldr      x23, [x23, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C80C  ldr      x1, [x23]
00659C810  ldrb     w8, [x1, #0x53]
00659C814  tbnz     w8, #5, #0x659c864
00659C818  ldr      x21, [x19, #0x10]
00659C81C  b        #0x659c874 ; 
00659C820  str      wzr, [x19, #0x24]
00659C824  str      xzr, [x19, #0x28]
00659C828  adrp     x20, #0x9599000
00659C82C  ldrb     w8, [x20, #0x4b1]
00659C830  cbnz     w8, #0x659c848
00659C834  adrp     x0, #0x8f08000
00659C838  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C83C  bl       #0x382bd14 ; 
00659C840  mov      w8, #1
00659C844  strb     w8, [x20, #0x4b1]
00659C848  adrp     x8, #0x8f08000
00659C84C  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C850  ldr      x1, [x8]
00659C854  ldrb     w8, [x1, #0x53]
00659C858  tbnz     w8, #5, #0x659c8d8
00659C85C  ldr      x19, [x19, #0x10]
00659C860  b        #0x659c8e8 ; 
00659C864  ldr      x8, [x1, #0x60]
00659C868  mov      x0, x19
00659C86C  blr      x8
00659C870  mov      x21, x0
00659C874  cbz      x21, #0x659cc34
00659C878  adrp     x8, #0x8f08000
00659C87C  ldr      x8, [x8, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<ReviveEvent>() @ 0x923f400
00659C880  ldr      x20, [x8]
00659C884  ldr      x8, [x20, #0x38]
00659C888  cbnz     x8, #0x659c894
00659C88C  mov      x0, x20
00659C890  bl       #0x3a7e668 ; 
00659C894  ldrb     w8, [x20, #0x53]
00659C898  tbnz     w8, #5, #0x659c928
00659C89C  adrp     x24, #0x9591000
00659C8A0  ldrb     w8, [x24, #0xa61]
00659C8A4  cbnz     w8, #0x659c8bc
00659C8A8  adrp     x0, #0x8ee6000
00659C8AC  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
00659C8B0  bl       #0x382bd14 ; 
00659C8B4  mov      w8, #1
00659C8B8  strb     w8, [x24, #0xa61]
00659C8BC  adrp     x8, #0x8ee6000
00659C8C0  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
00659C8C4  ldr      x1, [x8]
00659C8C8  ldrb     w8, [x1, #0x53]
00659C8CC  tbnz     w8, #5, #0x659c970
00659C8D0  ldr      x0, [x21, #0x1e8]
00659C8D4  b        #0x659c97c ; 
00659C8D8  ldr      x8, [x1, #0x60]
00659C8DC  mov      x0, x19
00659C8E0  blr      x8
00659C8E4  mov      x19, x0
00659C8E8  cbz      x19, #0x659cc34
00659C8EC  adrp     x20, #0x9598000
00659C8F0  ldrb     w8, [x20, #0xfc4]
00659C8F4  cbnz     w8, #0x659c90c
00659C8F8  adrp     x0, #0x8f05000
00659C8FC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659C900  bl       #0x382bd14 ; 
00659C904  mov      w8, #1
00659C908  strb     w8, [x20, #0xfc4]
00659C90C  adrp     x8, #0x8f05000
00659C910  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659C914  ldr      x1, [x8]
00659C918  ldrb     w8, [x1, #0x53]
00659C91C  tbnz     w8, #5, #0x659c93c
00659C920  ldr      x0, [x19, #0x220]
00659C924  b        #0x659c948 ; 
00659C928  ldr      x8, [x20, #0x60]
00659C92C  mov      x0, x21
00659C930  mov      x1, x20
00659C934  blr      x8
00659C938  b        #0x659c98c ; 
00659C93C  ldr      x8, [x1, #0x60]
00659C940  mov      x0, x19
00659C944  blr      x8
00659C948  cbz      x0, #0x659cc34
00659C94C  ldr      x8, [x0]
00659C950  ldp      x20, x19, [sp, #0x30]
00659C954  ldp      x22, x21, [sp, #0x20]
00659C958  ldp      x24, x23, [sp, #0x10]
00659C95C  ldr      x3, [x8, #0x258]
00659C960  ldr      x2, [x8, #0x260]
00659C964  mov      w1, wzr
00659C968  ldp      x30, x25, [sp], #0x40
00659C96C  br       x3
00659C970  ldr      x8, [x1, #0x60]
00659C974  mov      x0, x21
00659C978  blr      x8
00659C97C  cbz      x0, #0x659cc34
00659C980  ldr      x8, [x20, #0x38]
00659C984  ldr      x1, [x8]
00659C988  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
00659C98C  mov      x20, x0
00659C990  ldr      x0, [x19, #0x18]
00659C994  cbz      x0, #0x659cc34
00659C998  mov      x1, xzr
00659C99C  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
00659C9A0  cbz      x20, #0x659cc34
00659C9A4  str      w0, [x20, #0x20]
00659C9A8  ldrb     w8, [x22, #0x4b1]
00659C9AC  cbnz     w8, #0x659c9c4
00659C9B0  adrp     x0, #0x8f08000
00659C9B4  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C9B8  bl       #0x382bd14 ; 
00659C9BC  mov      w8, #1
00659C9C0  strb     w8, [x22, #0x4b1]
00659C9C4  ldr      x1, [x23]
00659C9C8  ldrb     w8, [x1, #0x53]
00659C9CC  tbnz     w8, #5, #0x659c9d8
00659C9D0  ldr      x21, [x19, #0x10]
00659C9D4  b        #0x659c9e8 ; 
00659C9D8  ldr      x8, [x1, #0x60]
00659C9DC  mov      x0, x19
00659C9E0  blr      x8
00659C9E4  mov      x21, x0
00659C9E8  cbz      x21, #0x659cc34
00659C9EC  adrp     x24, #0x9598000
00659C9F0  ldrb     w8, [x24, #0xfc4]
00659C9F4  cbnz     w8, #0x659ca0c
00659C9F8  adrp     x0, #0x8f05000
00659C9FC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659CA00  bl       #0x382bd14 ; 
00659CA04  mov      w8, #1
00659CA08  strb     w8, [x24, #0xfc4]
00659CA0C  adrp     x25, #0x8f05000
00659CA10  ldr      x25, [x25, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659CA14  ldr      x1, [x25]
00659CA18  ldrb     w8, [x1, #0x53]
00659CA1C  tbnz     w8, #5, #0x659ca28
00659CA20  ldr      x0, [x21, #0x220]
00659CA24  b        #0x659ca34 ; 
00659CA28  ldr      x8, [x1, #0x60]
00659CA2C  mov      x0, x21
00659CA30  blr      x8
00659CA34  cbz      x0, #0x659cc34
00659CA38  mov      x1, xzr
00659CA3C  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
00659CA40  and      w8, w0, #1
00659CA44  strb     w8, [x20, #0x28]
00659CA48  ldrb     w8, [x22, #0x4b1]
00659CA4C  cbnz     w8, #0x659ca64
00659CA50  adrp     x0, #0x8f08000
00659CA54  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659CA58  bl       #0x382bd14 ; 
00659CA5C  mov      w8, #1
00659CA60  strb     w8, [x22, #0x4b1]
00659CA64  ldr      x1, [x23]
00659CA68  ldrb     w8, [x1, #0x53]
00659CA6C  tbnz     w8, #5, #0x659ca78
00659CA70  ldr      x21, [x19, #0x10]
00659CA74  b        #0x659ca88 ; 
00659CA78  ldr      x8, [x1, #0x60]
00659CA7C  mov      x0, x19
00659CA80  blr      x8
00659CA84  mov      x21, x0
00659CA88  cbz      x21, #0x659cc34
00659CA8C  ldrb     w8, [x24, #0xfc4]
00659CA90  cbnz     w8, #0x659caa8
00659CA94  adrp     x0, #0x8f05000
00659CA98  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659CA9C  bl       #0x382bd14 ; 
00659CAA0  mov      w8, #1
00659CAA4  strb     w8, [x24, #0xfc4]
00659CAA8  ldr      x1, [x25]
00659CAAC  ldrb     w8, [x1, #0x53]
00659CAB0  tbnz     w8, #5, #0x659cabc
00659CAB4  ldr      x0, [x21, #0x220]
00659CAB8  b        #0x659cac8 ; 
00659CABC  ldr      x8, [x1, #0x60]
00659CAC0  mov      x0, x21
00659CAC4  blr      x8
00659CAC8  cbz      x0, #0x659cc34
00659CACC  ldr      x8, [x0]
00659CAD0  ldr      x9, [x8, #0x518]
00659CAD4  ldr      x1, [x8, #0x520]
00659CAD8  blr      x9
00659CADC  str      w0, [x20, #0x24]
00659CAE0  ldrb     w8, [x22, #0x4b1]
00659CAE4  cbnz     w8, #0x659cafc
00659CAE8  adrp     x0, #0x8f08000
00659CAEC  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659CAF0  bl       #0x382bd14 ; 
00659CAF4  mov      w8, #1
00659CAF8  strb     w8, [x22, #0x4b1]
00659CAFC  ldr      x1, [x23]
00659CB00  ldrb     w8, [x1, #0x53]
00659CB04  tbnz     w8, #5, #0x659cb10
00659CB08  ldr      x21, [x19, #0x10]
00659CB0C  b        #0x659cb20 ; 
00659CB10  ldr      x8, [x1, #0x60]
00659CB14  mov      x0, x19
00659CB18  blr      x8
00659CB1C  mov      x21, x0
00659CB20  cbz      x21, #0x659cc34
00659CB24  adrp     x24, #0x9599000
00659CB28  ldrb     w8, [x24, #0x4bf]
00659CB2C  cbnz     w8, #0x659cb44
00659CB30  adrp     x0, #0x8f08000
00659CB34  ldr      x0, [x0, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_AdReliveCount() @ 0x923fe38
00659CB38  bl       #0x382bd14 ; 
00659CB3C  mov      w8, #1
00659CB40  strb     w8, [x24, #0x4bf]
00659CB44  adrp     x8, #0x8f08000
00659CB48  ldr      x8, [x8, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_AdReliveCount() @ 0x923fe38
00659CB4C  ldr      x1, [x8]
00659CB50  ldrb     w8, [x1, #0x53]
00659CB54  tbnz     w8, #5, #0x659cb60
00659CB58  ldr      w0, [x21, #0x2cc]
00659CB5C  b        #0x659cb6c ; 
00659CB60  ldr      x8, [x1, #0x60]
00659CB64  mov      x0, x21
00659CB68  blr      x8
00659CB6C  cmp      w0, #0
00659CB70  cset     w8, ne
00659CB74  strb     w8, [x20, #0x29]
00659CB78  ldrb     w8, [x22, #0x4b1]
00659CB7C  cbnz     w8, #0x659cb94
00659CB80  adrp     x0, #0x8f08000
00659CB84  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659CB88  bl       #0x382bd14 ; 
00659CB8C  mov      w8, #1
00659CB90  strb     w8, [x22, #0x4b1]
00659CB94  ldr      x1, [x23]
00659CB98  ldrb     w8, [x1, #0x53]
00659CB9C  tbnz     w8, #5, #0x659cba8
00659CBA0  ldr      x0, [x19, #0x10]
00659CBA4  b        #0x659cbb4 ; 
00659CBA8  ldr      x8, [x1, #0x60]
00659CBAC  mov      x0, x19
00659CBB0  blr      x8
00659CBB4  cbz      x0, #0x659cc34
00659CBB8  ldr      x19, [x0, #0x1e0]
00659CBBC  cbz      x19, #0x659cc34
00659CBC0  adrp     x9, #0x8f08000
00659CBC4  ldr      x9, [x9, #0xed8] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<ReviveEvent>() @ 0x92848a8
00659CBC8  ldr      x8, [x19]
00659CBCC  ldr      x21, [x9]
00659CBD0  ldrh     w9, [x8, #0x12e]
00659CBD4  ldr      x1, [x21, #0x20]
00659CBD8  ldrh     w2, [x21, #0x50]
00659CBDC  cbz      x9, #0x659cc00
00659CBE0  ldr      x10, [x8, #0xb0]
00659CBE4  add      x10, x10, #8
00659CBE8  ldur     x11, [x10, #-8]
00659CBEC  cmp      x11, x1
00659CBF0  b.eq     #0x659cc0c
00659CBF4  subs     x9, x9, #1
00659CBF8  add      x10, x10, #0x10
00659CBFC  b.ne     #0x659cbe8
00659CC00  mov      x0, x19
00659CC04  bl       #0x3a7e710 ; 
00659CC08  b        #0x659cc1c ; 
00659CC0C  ldr      w9, [x10]
00659CC10  add      w9, w9, w2
00659CC14  add      x8, x8, w9, sxtw #4
00659CC18  add      x0, x8, #0x138
00659CC1C  ldr      x0, [x0, #8]
00659CC20  mov      x1, x21
00659CC24  bl       #0x382be88 ; 
00659CC28  ldr      x3, [x0, #8]
00659CC2C  mov      x2, x0
00659CC30  b        #0x659c714 ; 
00659CC34  bl       #0x382bfb8 ; 

