; HotFix.BattleLogic.AIFixedBezierPath$$InitAttackLoop
; RVA 0x6BA00A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006BA00A0  sub      sp, sp, #0x80
006BA00A4  str      x30, [sp, #0x50]
006BA00A8  stp      x22, x21, [sp, #0x60]
006BA00AC  stp      x20, x19, [sp, #0x70]
006BA00B0  mrs      x21, tpidr_el0
006BA00B4  ldr      x8, [x21, #0x28]
006BA00B8  adrp     x20, #0x95a0000
006BA00BC  adrp     x22, #0x8f44000
006BA00C0  mov      x19, x0
006BA00C4  str      x8, [sp, #0x48]
006BA00C8  ldrb     w8, [x20, #0xb0]
006BA00CC  ldr      x22, [x22, #0x368] ; GLOBAL Method$HotFix.BattleLogic.AIFixedBezierPath.InitAttackLoop()
006BA00D0  tbnz     w8, #0, #0x6ba00e8
006BA00D4  adrp     x0, #0x8f44000
006BA00D8  ldr      x0, [x0, #0x368] ; GLOBAL Method$HotFix.BattleLogic.AIFixedBezierPath.InitAttackLoop()
006BA00DC  bl       #0x382bd14 ; 
006BA00E0  mov      w8, #1
006BA00E4  strb     w8, [x20, #0xb0]
006BA00E8  ldr      x1, [x22]
006BA00EC  ldrb     w8, [x1, #0x53]
006BA00F0  tbnz     w8, #5, #0x6ba0158
006BA00F4  ldrb     w8, [x19, #0x120]
006BA00F8  cbz      w8, #0x6ba01c4
006BA00FC  ldr      x8, [x19, #0x118]
006BA0100  cbz      x8, #0x6ba021c
006BA0104  ldrb     w8, [x8, #0x1c]
006BA0108  cbz      w8, #0x6ba01c4
006BA010C  ldrb     w8, [x19, #0x121]
006BA0110  cbnz     w8, #0x6ba01c4
006BA0114  ldr      x20, [x19, #0x58]
006BA0118  cbz      x20, #0x6ba021c
006BA011C  adrp     x22, #0x9598000
006BA0120  ldrb     w8, [x22, #0xfb7]
006BA0124  cbnz     w8, #0x6ba013c
006BA0128  adrp     x0, #0x8f05000
006BA012C  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006BA0130  bl       #0x382bd14 ; 
006BA0134  mov      w8, #1
006BA0138  strb     w8, [x22, #0xfb7]
006BA013C  adrp     x8, #0x8f05000
006BA0140  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
006BA0144  ldr      x1, [x8]
006BA0148  ldrb     w8, [x1, #0x53]
006BA014C  tbnz     w8, #5, #0x6ba0168
006BA0150  ldr      x20, [x20, #0x118]
006BA0154  b        #0x6ba0178 ; 
006BA0158  ldr      x8, [x1, #0x60]
006BA015C  mov      x0, x19
006BA0160  blr      x8
006BA0164  b        #0x6ba01f8 ; 
006BA0168  ldr      x8, [x1, #0x60]
006BA016C  mov      x0, x20
006BA0170  blr      x8
006BA0174  mov      x20, x0
006BA0178  ldr      x0, [x19, #0x58]
006BA017C  cbz      x0, #0x6ba021c
006BA0180  add      x8, sp, #0x18
006BA0184  mov      x1, xzr
006BA0188  bl       #0x67d6328 ; HotFix.BattleLogic.EntityCharacter$$GetLoopMoveRestartPos
006BA018C  ldur     q0, [sp, #0x18]
006BA0190  ldr      x8, [sp, #0x28]
006BA0194  str      q0, [sp, #0x30]
006BA0198  str      x8, [sp, #0x40]
006BA019C  cbz      x20, #0x6ba021c
006BA01A0  ldr      q0, [sp, #0x30]
006BA01A4  ldr      x8, [sp, #0x40]
006BA01A8  mov      x1, sp
006BA01AC  mov      w2, #1
006BA01B0  mov      x0, x20
006BA01B4  mov      x3, xzr
006BA01B8  str      q0, [sp]
006BA01BC  str      x8, [sp, #0x10]
006BA01C0  bl       #0x672c418 ; HotFix.BattleLogic.CharacterComponentTransform$$MoveToPosition
006BA01C4  ldr      x8, [x19, #0x118]
006BA01C8  strb     wzr, [x19, #0x121]
006BA01CC  cbz      x8, #0x6ba021c
006BA01D0  ldr      w9, [x8, #0x18]
006BA01D4  ldr      w1, [x8, #0x10]
006BA01D8  ldrb     w4, [x8, #0x1c]
006BA01DC  mov      x0, x19
006BA01E0  cmp      w9, #1
006BA01E4  cset     w2, eq
006BA01E8  mov      w3, wzr
006BA01EC  bl       #0x6b96e58 ; HotFix.BattleLogic.AIStateController$$AddTaskMoveOnFixedPath
006BA01F0  mov      w8, #1
006BA01F4  strb     w8, [x19, #0x120]
006BA01F8  ldr      x8, [x21, #0x28]
006BA01FC  ldr      x9, [sp, #0x48]
006BA0200  cmp      x8, x9
006BA0204  b.ne     #0x6ba0220
006BA0208  ldp      x20, x19, [sp, #0x70]
006BA020C  ldp      x22, x21, [sp, #0x60]
006BA0210  ldr      x30, [sp, #0x50]
006BA0214  add      sp, sp, #0x80
006BA0218  ret      
006BA021C  bl       #0x382bfb8 ; 
006BA0220  bl       #0x89edb60 ; 

