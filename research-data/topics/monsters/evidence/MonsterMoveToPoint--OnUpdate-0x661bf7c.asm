; HotFix.BattleLogic.MonsterMoveToPoint$$OnUpdate
; RVA 0x661BF7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661BF7C  sub      sp, sp, #0x120
00661BF80  str      x29, [sp, #0xd0]
00661BF84  stp      x30, x25, [sp, #0xe0]
00661BF88  stp      x24, x23, [sp, #0xf0]
00661BF8C  stp      x22, x21, [sp, #0x100]
00661BF90  stp      x20, x19, [sp, #0x110]
00661BF94  mrs      x22, tpidr_el0
00661BF98  ldr      x8, [x22, #0x28]
00661BF9C  adrp     x21, #0x9599000
00661BFA0  adrp     x23, #0x8f0c000
00661BFA4  mov      x20, x1
00661BFA8  str      x8, [sp, #0xc8]
00661BFAC  ldrb     w8, [x21, #0x8b6]
00661BFB0  ldr      x23, [x23, #0x598] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.OnUpdate()
00661BFB4  mov      x19, x0
00661BFB8  tbnz     w8, #0, #0x661bfe8
00661BFBC  adrp     x0, #0x8f0a000
00661BFC0  ldr      x0, [x0, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
00661BFC4  bl       #0x382bd14 ; 
00661BFC8  adrp     x0, #0x8ee6000
00661BFCC  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00661BFD0  bl       #0x382bd14 ; 
00661BFD4  adrp     x0, #0x8f0c000
00661BFD8  ldr      x0, [x0, #0x598] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.OnUpdate()
00661BFDC  bl       #0x382bd14 ; 
00661BFE0  mov      w8, #1
00661BFE4  strb     w8, [x21, #0x8b6]
00661BFE8  ldr      x2, [x23]
00661BFEC  ldrb     w8, [x2, #0x53]
00661BFF0  tbnz     w8, #5, #0x661c018
00661BFF4  adrp     x23, #0x8f0a000
00661BFF8  ldr      x23, [x23, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
00661BFFC  stp      xzr, xzr, [sp, #0xb0]
00661C000  str      xzr, [sp, #0xc0]
00661C004  ldr      x1, [x23]
00661C008  ldrb     w8, [x1, #0x53]
00661C00C  tbnz     w8, #5, #0x661c02c
00661C010  ldr      x0, [x19, #0x58]
00661C014  b        #0x661c038 ; 
00661C018  ldr      x8, [x2, #0x60]
00661C01C  mov      x0, x19
00661C020  mov      x1, x20
00661C024  blr      x8
00661C028  b        #0x661c374 ; 
00661C02C  ldr      x8, [x1, #0x60]
00661C030  mov      x0, x19
00661C034  blr      x8
00661C038  cbz      x0, #0x661c3a0
00661C03C  adrp     x24, #0x8ee6000
00661C040  ldr      x24, [x24, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00661C044  ldr      x1, [x24]
00661C048  ldrb     w8, [x1, #0x53]
00661C04C  tbnz     w8, #5, #0x661c058
00661C050  ldr      x21, [x0, #0x38]
00661C054  b        #0x661c064 ; 
00661C058  ldr      x8, [x1, #0x60]
00661C05C  blr      x8
00661C060  mov      x21, x0
00661C064  cbz      x21, #0x661c3a0
00661C068  adrp     x25, #0x9591000
00661C06C  ldrb     w8, [x25, #0xa7f]
00661C070  cbnz     w8, #0x661c088
00661C074  adrp     x0, #0x8ee6000
00661C078  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
00661C07C  bl       #0x382bd14 ; 
00661C080  mov      w8, #1
00661C084  strb     w8, [x25, #0xa7f]
00661C088  adrp     x8, #0x8ee6000
00661C08C  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
00661C090  ldr      x1, [x8]
00661C094  ldrb     w8, [x1, #0x53]
00661C098  tbnz     w8, #5, #0x661c0a4
00661C09C  ldr      x0, [x21, #0x178]
00661C0A0  b        #0x661c0b0 ; 
00661C0A4  ldr      x8, [x1, #0x60]
00661C0A8  mov      x0, x21
00661C0AC  blr      x8
00661C0B0  cbz      x0, #0x661c3a0
00661C0B4  mov      x1, xzr
00661C0B8  bl       #0x6b3d38c ; HotFix.Common.AttributeData$$GetMoveSpeed
00661C0BC  ldr      x1, [x23]
00661C0C0  mov      x21, x0
00661C0C4  ldrb     w8, [x1, #0x53]
00661C0C8  tbnz     w8, #5, #0x661c0d4
00661C0CC  ldr      x0, [x19, #0x58]
00661C0D0  b        #0x661c0e0 ; 
00661C0D4  ldr      x8, [x1, #0x60]
00661C0D8  mov      x0, x19
00661C0DC  blr      x8
00661C0E0  cbz      x0, #0x661c3a0
00661C0E4  ldr      x1, [x24]
00661C0E8  ldrb     w8, [x1, #0x53]
00661C0EC  tbnz     w8, #5, #0x661c0f8
00661C0F0  ldr      x0, [x0, #0x38]
00661C0F4  b        #0x661c100 ; 
00661C0F8  ldr      x8, [x1, #0x60]
00661C0FC  blr      x8
00661C100  cbz      x0, #0x661c3a0
00661C104  add      x8, sp, #0x90
00661C108  mov      x1, xzr
00661C10C  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00661C110  mov      x25, x19
00661C114  ldp      x10, x9, [sp, #0x90]
00661C118  ldr      x8, [sp, #0xa0]
00661C11C  ldr      x11, [x25, #0xa0]!
00661C120  cmp      x10, x11
00661C124  b.ne     #0x661c15c
00661C128  ldr      x10, [x25, #8]
00661C12C  cmp      x9, x10
00661C130  b.ne     #0x661c15c
00661C134  ldr      x9, [x25, #0x10]
00661C138  cmp      x8, x9
00661C13C  b.ne     #0x661c15c
00661C140  ldrb     w8, [x19, #0xb8]
00661C144  cbz      w8, #0x661c370
00661C148  ldr      x1, [x23]
00661C14C  ldrb     w8, [x1, #0x53]
00661C150  tbnz     w8, #5, #0x661c2a8
00661C154  ldr      x20, [x19, #0x58]
00661C158  b        #0x661c2b8 ; 
00661C15C  ldr      x1, [x23]
00661C160  ldrb     w8, [x1, #0x53]
00661C164  tbnz     w8, #5, #0x661c170
00661C168  ldr      x0, [x19, #0x58]
00661C16C  b        #0x661c17c ; 
00661C170  ldr      x8, [x1, #0x60]
00661C174  mov      x0, x19
00661C178  blr      x8
00661C17C  cbz      x0, #0x661c3a0
00661C180  ldr      x1, [x24]
00661C184  ldrb     w8, [x1, #0x53]
00661C188  tbnz     w8, #5, #0x661c194
00661C18C  ldr      x0, [x0, #0x38]
00661C190  b        #0x661c19c ; 
00661C194  ldr      x8, [x1, #0x60]
00661C198  blr      x8
00661C19C  cbz      x0, #0x661c3a0
00661C1A0  mul      x8, x21, x20
00661C1A4  asr      x20, x8, #0x10
00661C1A8  add      x8, sp, #0x90
00661C1AC  mov      x1, xzr
00661C1B0  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00661C1B4  ldr      q0, [sp, #0x90]
00661C1B8  ldr      x8, [sp, #0xa0]
00661C1BC  add      x0, sp, #0x40
00661C1C0  add      x1, sp, #0x20
00661C1C4  str      q0, [sp, #0x40]
00661C1C8  str      x8, [sp, #0x50]
00661C1CC  ldr      x8, [x25, #0x10]
00661C1D0  ldr      q0, [x25]
00661C1D4  mov      x2, x20
00661C1D8  mov      x3, xzr
00661C1DC  str      x8, [sp, #0x30]
00661C1E0  add      x8, sp, #0x90
00661C1E4  str      q0, [sp, #0x20]
00661C1E8  bl       #0x7d50aec ; Photon.Deterministic.FPVector3$$MoveTowards
00661C1EC  ldr      q0, [sp, #0x90]
00661C1F0  ldr      x8, [sp, #0xa0]
00661C1F4  ldr      x1, [x23]
00661C1F8  str      q0, [sp, #0xb0]
00661C1FC  str      x8, [sp, #0xc0]
00661C200  ldrb     w8, [x1, #0x53]
00661C204  tbnz     w8, #5, #0x661c210
00661C208  ldr      x19, [x19, #0x58]
00661C20C  b        #0x661c220 ; 
00661C210  ldr      x8, [x1, #0x60]
00661C214  mov      x0, x19
00661C218  blr      x8
00661C21C  mov      x19, x0
00661C220  cbz      x19, #0x661c3a0
00661C224  adrp     x20, #0x9598000
00661C228  ldrb     w8, [x20, #0xfb7]
00661C22C  cbnz     w8, #0x661c244
00661C230  adrp     x0, #0x8f05000
00661C234  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00661C238  bl       #0x382bd14 ; 
00661C23C  mov      w8, #1
00661C240  strb     w8, [x20, #0xfb7]
00661C244  adrp     x8, #0x8f05000
00661C248  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00661C24C  ldr      x1, [x8]
00661C250  ldrb     w8, [x1, #0x53]
00661C254  tbnz     w8, #5, #0x661c260
00661C258  ldr      x0, [x19, #0x118]
00661C25C  b        #0x661c26c ; 
00661C260  ldr      x8, [x1, #0x60]
00661C264  mov      x0, x19
00661C268  blr      x8
00661C26C  ldr      q0, [sp, #0xb0]
00661C270  ldr      x8, [sp, #0xc0]
00661C274  str      q0, [sp, #0x90]
00661C278  str      x8, [sp, #0xa0]
00661C27C  cbz      x0, #0x661c3a0
00661C280  ldr      q0, [sp, #0x90]
00661C284  ldr      x8, [sp, #0xa0]
00661C288  mov      x1, sp
00661C28C  mov      w2, wzr
00661C290  mov      x3, xzr
00661C294  str      q0, [sp]
00661C298  str      x8, [sp, #0x10]
00661C29C  bl       #0x672c418 ; HotFix.BattleLogic.CharacterComponentTransform$$MoveToPosition
00661C2A0  mov      w0, #3
00661C2A4  b        #0x661c374 ; 
00661C2A8  ldr      x8, [x1, #0x60]
00661C2AC  mov      x0, x19
00661C2B0  blr      x8
00661C2B4  mov      x20, x0
00661C2B8  cbz      x20, #0x661c3a0
00661C2BC  adrp     x21, #0x9598000
00661C2C0  ldrb     w8, [x21, #0xfb7]
00661C2C4  cbnz     w8, #0x661c2dc
00661C2C8  adrp     x0, #0x8f05000
00661C2CC  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00661C2D0  bl       #0x382bd14 ; 
00661C2D4  mov      w8, #1
00661C2D8  strb     w8, [x21, #0xfb7]
00661C2DC  adrp     x8, #0x8f05000
00661C2E0  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00661C2E4  ldr      x1, [x8]
00661C2E8  ldrb     w8, [x1, #0x53]
00661C2EC  tbnz     w8, #5, #0x661c2f8
00661C2F0  ldr      x20, [x20, #0x118]
00661C2F4  b        #0x661c308 ; 
00661C2F8  ldr      x8, [x1, #0x60]
00661C2FC  mov      x0, x20
00661C300  blr      x8
00661C304  mov      x20, x0
00661C308  ldr      x1, [x23]
00661C30C  ldrb     w8, [x1, #0x53]
00661C310  tbnz     w8, #5, #0x661c31c
00661C314  ldr      x0, [x19, #0x58]
00661C318  b        #0x661c328 ; 
00661C31C  ldr      x8, [x1, #0x60]
00661C320  mov      x0, x19
00661C324  blr      x8
00661C328  cbz      x0, #0x661c3a0
00661C32C  add      x8, sp, #0x78
00661C330  mov      x1, xzr
00661C334  bl       #0x67d6328 ; HotFix.BattleLogic.EntityCharacter$$GetLoopMoveRestartPos
00661C338  ldur     q0, [sp, #0x78]
00661C33C  ldr      x8, [sp, #0x88]
00661C340  str      q0, [sp, #0x90]
00661C344  str      x8, [sp, #0xa0]
00661C348  cbz      x20, #0x661c3a0
00661C34C  ldr      q0, [sp, #0x90]
00661C350  ldr      x8, [sp, #0xa0]
00661C354  add      x1, sp, #0x60
00661C358  mov      w2, #1
00661C35C  mov      x0, x20
00661C360  mov      x3, xzr
00661C364  str      q0, [sp, #0x60]
00661C368  str      x8, [sp, #0x70]
00661C36C  bl       #0x672c418 ; HotFix.BattleLogic.CharacterComponentTransform$$MoveToPosition
00661C370  mov      w0, #2
00661C374  ldr      x8, [x22, #0x28]
00661C378  ldr      x9, [sp, #0xc8]
00661C37C  cmp      x8, x9
00661C380  b.ne     #0x661c3a4
00661C384  ldp      x20, x19, [sp, #0x110]
00661C388  ldp      x22, x21, [sp, #0x100]
00661C38C  ldp      x24, x23, [sp, #0xf0]
00661C390  ldp      x30, x25, [sp, #0xe0]
00661C394  ldr      x29, [sp, #0xd0]
00661C398  add      sp, sp, #0x120
00661C39C  ret      
00661C3A0  bl       #0x382bfb8 ; 
00661C3A4  bl       #0x89edb60 ; 

