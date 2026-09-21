; HotFix.BattleLogic.HeroComponentRandomSkill$$Init
; RVA 0x686BAC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686BAC4  stp      x30, x21, [sp, #-0x20]!
00686BAC8  stp      x20, x19, [sp, #0x10]
00686BACC  adrp     x20, #0x959b000
00686BAD0  adrp     x21, #0x8f24000
00686BAD4  ldrb     w8, [x20, #0xa4a]
00686BAD8  ldr      x21, [x21, #0x110] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.Init() @ 0x927fa18
00686BADC  mov      x19, x0
00686BAE0  tbnz     w8, #0, #0x686bb10
00686BAE4  adrp     x0, #0x8f24000
00686BAE8  ldr      x0, [x0, #0x118] ; GLOBAL HotFix.BattleLogic.DankeSkillCreator_TypeInfo @ 0x91e4290
00686BAEC  bl       #0x382bd14 ; 
00686BAF0  adrp     x0, #0x8f24000
00686BAF4  ldr      x0, [x0, #0x110] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.Init() @ 0x927fa18
00686BAF8  bl       #0x382bd14 ; 
00686BAFC  adrp     x0, #0x8f24000
00686BB00  ldr      x0, [x0, #0x120] ; GLOBAL HotFix.BattleLogic.NormalSkillCreator_TypeInfo @ 0x91ecff8
00686BB04  bl       #0x382bd14 ; 
00686BB08  mov      w8, #1
00686BB0C  strb     w8, [x20, #0xa4a]
00686BB10  ldr      x1, [x21]
00686BB14  ldrb     w8, [x1, #0x53]
00686BB18  tbnz     w8, #5, #0x686bb58
00686BB1C  adrp     x20, #0x9591000
00686BB20  ldrb     w8, [x20, #0xa4b]
00686BB24  cbnz     w8, #0x686bb3c
00686BB28  adrp     x0, #0x8ee5000
00686BB2C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686BB30  bl       #0x382bd14 ; 
00686BB34  mov      w8, #1
00686BB38  strb     w8, [x20, #0xa4b]
00686BB3C  adrp     x21, #0x8ee5000
00686BB40  ldr      x21, [x21, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686BB44  ldr      x1, [x21]
00686BB48  ldrb     w8, [x1, #0x53]
00686BB4C  tbnz     w8, #5, #0x686bb6c
00686BB50  ldr      x0, [x19, #0x20]
00686BB54  b        #0x686bb78 ; 
00686BB58  ldr      x2, [x1, #0x60]
00686BB5C  mov      x0, x19
00686BB60  ldp      x20, x19, [sp, #0x10]
00686BB64  ldp      x30, x21, [sp], #0x20
00686BB68  br       x2
00686BB6C  ldr      x8, [x1, #0x60]
00686BB70  mov      x0, x19
00686BB74  blr      x8
00686BB78  cbz      x0, #0x686bc7c
00686BB7C  ldrb     w8, [x20, #0xa4b]
00686BB80  cbnz     w8, #0x686bb98
00686BB84  adrp     x0, #0x8ee5000
00686BB88  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686BB8C  bl       #0x382bd14 ; 
00686BB90  mov      w8, #1
00686BB94  strb     w8, [x20, #0xa4b]
00686BB98  ldr      x1, [x21]
00686BB9C  ldrb     w8, [x1, #0x53]
00686BBA0  tbnz     w8, #5, #0x686bbac
00686BBA4  ldr      x0, [x19, #0x20]
00686BBA8  b        #0x686bbb8 ; 
00686BBAC  ldr      x8, [x1, #0x60]
00686BBB0  mov      x0, x19
00686BBB4  blr      x8
00686BBB8  cbz      x0, #0x686bc7c
00686BBBC  mov      x1, xzr
00686BBC0  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00686BBC4  tbz      w0, #0, #0x686bbe4
00686BBC8  adrp     x8, #0x8f24000
00686BBCC  ldr      x8, [x8, #0x118] ; GLOBAL HotFix.BattleLogic.DankeSkillCreator_TypeInfo @ 0x91e4290
00686BBD0  ldr      x0, [x8]
00686BBD4  bl       #0x382bfa0 ; 
00686BBD8  mov      x20, x0
00686BBDC  bl       #0x68662ac ; HotFix.BattleLogic.DankeSkillCreator$$.ctor
00686BBE0  b        #0x686bbfc ; 
00686BBE4  adrp     x8, #0x8f24000
00686BBE8  ldr      x8, [x8, #0x120] ; GLOBAL HotFix.BattleLogic.NormalSkillCreator_TypeInfo @ 0x91ecff8
00686BBEC  ldr      x0, [x8]
00686BBF0  bl       #0x382bfa0 ; 
00686BBF4  mov      x20, x0
00686BBF8  bl       #0x6866460 ; HotFix.BattleLogic.NormalSkillCreator$$.ctor
00686BBFC  mov      x21, x19
00686BC00  str      x20, [x21, #0x88]!
00686BC04  mov      x0, x21
00686BC08  mov      x1, x20
00686BC0C  bl       #0x382bcb8 ; 
00686BC10  ldr      x20, [x21]
00686BC14  cbz      x20, #0x686bc7c
00686BC18  adrp     x21, #0x959b000
00686BC1C  ldrb     w8, [x21, #0xbaf]
00686BC20  cbnz     w8, #0x686bc38
00686BC24  adrp     x0, #0x8f24000
00686BC28  ldr      x0, [x0, #0x128] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.SetHeroSkillComponent() @ 0x927fe90
00686BC2C  bl       #0x382bd14 ; 
00686BC30  mov      w8, #1
00686BC34  strb     w8, [x21, #0xbaf]
00686BC38  adrp     x8, #0x8f24000
00686BC3C  ldr      x8, [x8, #0x128] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.SetHeroSkillComponent() @ 0x927fe90
00686BC40  ldr      x2, [x8]
00686BC44  ldrb     w8, [x2, #0x53]
00686BC48  tbnz     w8, #5, #0x686bc64
00686BC4C  str      x19, [x20, #0x10]!
00686BC50  mov      x0, x20
00686BC54  mov      x1, x19
00686BC58  ldp      x20, x19, [sp, #0x10]
00686BC5C  ldp      x30, x21, [sp], #0x20
00686BC60  b        #0x382bcb8 ; 
00686BC64  ldr      x3, [x2, #0x60]
00686BC68  mov      x0, x20
00686BC6C  mov      x1, x19
00686BC70  ldp      x20, x19, [sp, #0x10]
00686BC74  ldp      x30, x21, [sp], #0x20
00686BC78  br       x3
00686BC7C  bl       #0x382bfb8 ; 

