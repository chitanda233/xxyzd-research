; HotFix.BattleLogic.AILittleBee$$InitAttackLoop
; RVA 0x6548C08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006548C08  stp      x30, x21, [sp, #-0x20]!
006548C0C  stp      x20, x19, [sp, #0x10]
006548C10  adrp     x20, #0x9598000
006548C14  adrp     x21, #0x8f05000
006548C18  ldrb     w8, [x20, #0xe13]
006548C1C  ldr      x21, [x21, #0x640] ; GLOBAL Method$HotFix.BattleLogic.AILittleBee.InitAttackLoop()
006548C20  mov      x19, x0
006548C24  tbnz     w8, #0, #0x6548c3c
006548C28  adrp     x0, #0x8f05000
006548C2C  ldr      x0, [x0, #0x640] ; GLOBAL Method$HotFix.BattleLogic.AILittleBee.InitAttackLoop()
006548C30  bl       #0x382bd14 ; 
006548C34  mov      w8, #1
006548C38  strb     w8, [x20, #0xe13]
006548C3C  ldr      x1, [x21]
006548C40  ldrb     w8, [x1, #0x53]
006548C44  tbnz     w8, #5, #0x6548c78
006548C48  ldr      x8, [x19, #0x118]
006548C4C  cbz      x8, #0x6548c8c
006548C50  ldr      w9, [x8, #0x18]
006548C54  ldr      w1, [x8, #0x10]
006548C58  mov      x0, x19
006548C5C  ldp      x20, x19, [sp, #0x10]
006548C60  cmp      w9, #1
006548C64  cset     w2, eq
006548C68  mov      w3, wzr
006548C6C  mov      x4, xzr
006548C70  ldp      x30, x21, [sp], #0x20
006548C74  b        #0x6b96f70 ; HotFix.BattleLogic.AIStateController$$AddTaskLittleBeeMoveOnPath
006548C78  ldr      x2, [x1, #0x60]
006548C7C  mov      x0, x19
006548C80  ldp      x20, x19, [sp, #0x10]
006548C84  ldp      x30, x21, [sp], #0x20
006548C88  br       x2
006548C8C  bl       #0x382bfb8 ; 

