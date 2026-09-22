; HotFix.BattleLogic.AIMoveToCircleCenter$$InitAttackLoop
; RVA 0x6551CA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006551CA0  stp      x30, x21, [sp, #-0x20]!
006551CA4  stp      x20, x19, [sp, #0x10]
006551CA8  adrp     x20, #0x9598000
006551CAC  adrp     x21, #0x8f05000
006551CB0  ldrb     w8, [x20, #0xe82]
006551CB4  ldr      x21, [x21, #0xbb8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToCircleCenter.InitAttackLoop()
006551CB8  mov      x19, x0
006551CBC  tbnz     w8, #0, #0x6551ce0
006551CC0  adrp     x0, #0x8f05000
006551CC4  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToCircleCenter.InitAttackLoop()
006551CC8  bl       #0x382bd14 ; 
006551CCC  adrp     x0, #0x8f05000
006551CD0  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToCircleCenter>()
006551CD4  bl       #0x382bd14 ; 
006551CD8  mov      w8, #1
006551CDC  strb     w8, [x20, #0xe82]
006551CE0  ldr      x1, [x21]
006551CE4  ldrb     w8, [x1, #0x53]
006551CE8  tbnz     w8, #5, #0x6551d40
006551CEC  adrp     x8, #0x8f05000
006551CF0  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToCircleCenter>()
006551CF4  mov      x0, x19
006551CF8  ldr      x1, [x8]
006551CFC  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
006551D00  ldr      x8, [x19, #0x180]
006551D04  cbz      x8, #0x6551d54
006551D08  mov      x20, x0
006551D0C  cbz      x0, #0x6551d54
006551D10  ldp      x1, x2, [x19, #0x188]
006551D14  ldp      x4, x5, [x8, #0x18]
006551D18  ldr      x3, [x8, #0x10]
006551D1C  mov      x0, x20
006551D20  mov      x6, xzr
006551D24  bl       #0x661a84c ; HotFix.BattleLogic.MonsterMoveToCircleCenter$$SetData
006551D28  mov      x0, x19
006551D2C  mov      x1, x20
006551D30  ldp      x20, x19, [sp, #0x10]
006551D34  mov      x2, xzr
006551D38  ldp      x30, x21, [sp], #0x20
006551D3C  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006551D40  ldr      x2, [x1, #0x60]
006551D44  mov      x0, x19
006551D48  ldp      x20, x19, [sp, #0x10]
006551D4C  ldp      x30, x21, [sp], #0x20
006551D50  br       x2
006551D54  bl       #0x382bfb8 ; 

