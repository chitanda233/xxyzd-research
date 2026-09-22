; HotFix.BattleLogic.MonsterMoveInTwoPoint$$OnUpdate
; RVA 0x661548C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661548C  sub      sp, sp, #0x100
006615490  str      x30, [sp, #0xb0]
006615494  stp      x26, x25, [sp, #0xc0]
006615498  stp      x24, x23, [sp, #0xd0]
00661549C  stp      x22, x21, [sp, #0xe0]
0066154A0  stp      x20, x19, [sp, #0xf0]
0066154A4  mrs      x23, tpidr_el0
0066154A8  ldr      x8, [x23, #0x28]
0066154AC  adrp     x21, #0x9599000
0066154B0  adrp     x22, #0x8f0c000
0066154B4  mov      x20, x1
0066154B8  str      x8, [sp, #0xa8]
0066154BC  ldrb     w8, [x21, #0x87b]
0066154C0  ldr      x22, [x22, #0x3b0] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.OnUpdate()
0066154C4  mov      x19, x0
0066154C8  tbnz     w8, #0, #0x66154f8
0066154CC  adrp     x0, #0x8f0a000
0066154D0  ldr      x0, [x0, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
0066154D4  bl       #0x382bd14 ; 
0066154D8  adrp     x0, #0x8ee6000
0066154DC  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0066154E0  bl       #0x382bd14 ; 
0066154E4  adrp     x0, #0x8f0c000
0066154E8  ldr      x0, [x0, #0x3b0] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.OnUpdate()
0066154EC  bl       #0x382bd14 ; 
0066154F0  mov      w8, #1
0066154F4  strb     w8, [x21, #0x87b]
0066154F8  ldr      x2, [x22]
0066154FC  ldrb     w8, [x2, #0x53]
006615500  tbnz     w8, #5, #0x6615528
006615504  adrp     x24, #0x8f0a000
006615508  ldr      x24, [x24, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
00661550C  stp      xzr, xzr, [sp, #0x90]
006615510  str      xzr, [sp, #0xa0]
006615514  ldr      x1, [x24]
006615518  ldrb     w8, [x1, #0x53]
00661551C  tbnz     w8, #5, #0x661554c
006615520  ldr      x0, [x19, #0x58]
006615524  b        #0x6615558 ; 
006615528  ldr      x8, [x2, #0x60]
00661552C  mov      x0, x19
006615530  mov      x1, x20
006615534  blr      x8
006615538  ldr      x8, [x23, #0x28]
00661553C  ldr      x9, [sp, #0xa8]
006615540  cmp      x8, x9
006615544  b.eq     #0x66157e8
006615548  b        #0x6615808 ; 
00661554C  ldr      x8, [x1, #0x60]
006615550  mov      x0, x19
006615554  blr      x8
006615558  cbz      x0, #0x6615804
00661555C  adrp     x25, #0x8ee6000
006615560  ldr      x25, [x25, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006615564  ldr      x1, [x25]
006615568  ldrb     w8, [x1, #0x53]
00661556C  tbnz     w8, #5, #0x6615578
006615570  ldr      x21, [x0, #0x38]
006615574  b        #0x6615584 ; 
006615578  ldr      x8, [x1, #0x60]
00661557C  blr      x8
006615580  mov      x21, x0
006615584  cbz      x21, #0x6615804
006615588  adrp     x22, #0x9591000
00661558C  ldrb     w8, [x22, #0xa7f]
006615590  cbnz     w8, #0x66155a8
006615594  adrp     x0, #0x8ee6000
006615598  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
00661559C  bl       #0x382bd14 ; 
0066155A0  mov      w8, #1
0066155A4  strb     w8, [x22, #0xa7f]
0066155A8  adrp     x8, #0x8ee6000
0066155AC  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
0066155B0  ldr      x1, [x8]
0066155B4  ldrb     w8, [x1, #0x53]
0066155B8  tbnz     w8, #5, #0x66155c4
0066155BC  ldr      x0, [x21, #0x178]
0066155C0  b        #0x66155d0 ; 
0066155C4  ldr      x8, [x1, #0x60]
0066155C8  mov      x0, x21
0066155CC  blr      x8
0066155D0  cbz      x0, #0x6615804
0066155D4  mov      x1, xzr
0066155D8  bl       #0x6b3d38c ; HotFix.Common.AttributeData$$GetMoveSpeed
0066155DC  ldr      x1, [x24]
0066155E0  mov      x21, x0
0066155E4  ldrb     w8, [x1, #0x53]
0066155E8  tbnz     w8, #5, #0x66155f4
0066155EC  ldr      x22, [x19, #0x58]
0066155F0  b        #0x6615604 ; 
0066155F4  ldr      x8, [x1, #0x60]
0066155F8  mov      x0, x19
0066155FC  blr      x8
006615600  mov      x22, x0
006615604  cbz      x22, #0x6615804
006615608  adrp     x26, #0x9598000
00661560C  ldrb     w8, [x26, #0xfb7]
006615610  cbnz     w8, #0x6615628
006615614  adrp     x0, #0x8f05000
006615618  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00661561C  bl       #0x382bd14 ; 
006615620  mov      w8, #1
006615624  strb     w8, [x26, #0xfb7]
006615628  adrp     x8, #0x8f05000
00661562C  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006615630  ldr      x1, [x8]
006615634  ldrb     w8, [x1, #0x53]
006615638  tbnz     w8, #5, #0x6615644
00661563C  ldr      x22, [x22, #0x118]
006615640  b        #0x6615654 ; 
006615644  ldr      x8, [x1, #0x60]
006615648  mov      x0, x22
00661564C  blr      x8
006615650  mov      x22, x0
006615654  ldr      x1, [x24]
006615658  ldrb     w8, [x1, #0x53]
00661565C  tbnz     w8, #5, #0x6615668
006615660  ldr      x0, [x19, #0x58]
006615664  b        #0x6615674 ; 
006615668  ldr      x8, [x1, #0x60]
00661566C  mov      x0, x19
006615670  blr      x8
006615674  cbz      x0, #0x6615804
006615678  ldr      x1, [x25]
00661567C  ldrb     w8, [x1, #0x53]
006615680  tbnz     w8, #5, #0x661568c
006615684  ldr      x0, [x0, #0x38]
006615688  b        #0x6615694 ; 
00661568C  ldr      x8, [x1, #0x60]
006615690  blr      x8
006615694  cbz      x0, #0x6615804
006615698  mul      x8, x21, x20
00661569C  asr      x20, x8, #0x10
0066156A0  add      x8, sp, #0x70
0066156A4  mov      x1, xzr
0066156A8  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
0066156AC  ldr      q0, [sp, #0x70]
0066156B0  ldr      x8, [sp, #0x80]
0066156B4  add      x0, sp, #0x40
0066156B8  add      x1, sp, #0x20
0066156BC  str      q0, [sp, #0x40]
0066156C0  str      x8, [sp, #0x50]
0066156C4  ldr      x8, [x19, #0xb0]
0066156C8  ldr      q0, [x19, #0xa0]
0066156CC  mov      x2, x20
0066156D0  mov      x3, xzr
0066156D4  str      x8, [sp, #0x30]
0066156D8  add      x8, sp, #0x58
0066156DC  str      q0, [sp, #0x20]
0066156E0  bl       #0x7d50aec ; Photon.Deterministic.FPVector3$$MoveTowards
0066156E4  ldur     q0, [sp, #0x58]
0066156E8  ldr      x8, [sp, #0x68]
0066156EC  str      q0, [sp, #0x70]
0066156F0  str      x8, [sp, #0x80]
0066156F4  cbz      x22, #0x6615804
0066156F8  ldr      q0, [sp, #0x70]
0066156FC  ldr      x8, [sp, #0x80]
006615700  mov      x1, sp
006615704  mov      x0, x22
006615708  mov      w2, wzr
00661570C  mov      x3, xzr
006615710  str      q0, [sp]
006615714  str      x8, [sp, #0x10]
006615718  bl       #0x672c418 ; HotFix.BattleLogic.CharacterComponentTransform$$MoveToPosition
00661571C  ldr      x1, [x24]
006615720  ldrb     w8, [x1, #0x53]
006615724  tbnz     w8, #5, #0x6615730
006615728  ldr      x0, [x19, #0x58]
00661572C  b        #0x661573c ; 
006615730  ldr      x8, [x1, #0x60]
006615734  mov      x0, x19
006615738  blr      x8
00661573C  cbz      x0, #0x6615804
006615740  ldr      x1, [x25]
006615744  ldrb     w8, [x1, #0x53]
006615748  tbnz     w8, #5, #0x6615754
00661574C  ldr      x0, [x0, #0x38]
006615750  b        #0x661575c ; 
006615754  ldr      x8, [x1, #0x60]
006615758  blr      x8
00661575C  cbz      x0, #0x6615804
006615760  add      x8, sp, #0x58
006615764  mov      x1, xzr
006615768  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
00661576C  ldr      x8, [sp, #0x58]
006615770  ldr      x9, [x19, #0xa0]
006615774  cmp      x8, x9
006615778  b.ne     #0x66157d4
00661577C  ldr      x9, [sp, #0x60]
006615780  ldr      x10, [x19, #0xa8]
006615784  cmp      x9, x10
006615788  b.ne     #0x66157d4
00661578C  ldr      x10, [sp, #0x68]
006615790  ldr      x11, [x19, #0xb0]
006615794  cmp      x10, x11
006615798  b.ne     #0x66157d4
00661579C  add      x11, x19, #0xa0
0066157A0  ldr      x12, [x19, #0x70]!
0066157A4  ldp      x14, x13, [x19, #8]
0066157A8  add      x15, x19, #0x18
0066157AC  cmp      x10, x13
0066157B0  ccmp     x9, x14, #0, eq
0066157B4  ccmp     x8, x12, #0, eq
0066157B8  csel     x8, x15, x19, eq
0066157BC  ldr      q0, [x8]
0066157C0  ldr      x8, [x8, #0x10]
0066157C4  str      q0, [sp, #0x90]
0066157C8  str      x8, [sp, #0xa0]
0066157CC  str      x8, [x11, #0x10]
0066157D0  str      q0, [x11]
0066157D4  ldr      x8, [x23, #0x28]
0066157D8  ldr      x9, [sp, #0xa8]
0066157DC  cmp      x8, x9
0066157E0  b.ne     #0x6615808
0066157E4  mov      w0, #3
0066157E8  ldp      x20, x19, [sp, #0xf0]
0066157EC  ldp      x22, x21, [sp, #0xe0]
0066157F0  ldp      x24, x23, [sp, #0xd0]
0066157F4  ldp      x26, x25, [sp, #0xc0]
0066157F8  ldr      x30, [sp, #0xb0]
0066157FC  add      sp, sp, #0x100
006615800  ret      
006615804  bl       #0x382bfb8 ; 
006615808  bl       #0x89edb60 ; 

