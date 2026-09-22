; HotFix.BattleLogic.AI200007$$AddAttack
; RVA 0x6B55B6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B55B6C  stp      x30, x23, [sp, #-0x30]!
006B55B70  stp      x22, x21, [sp, #0x10]
006B55B74  stp      x20, x19, [sp, #0x20]
006B55B78  adrp     x20, #0x959f000
006B55B7C  adrp     x21, #0x8f41000
006B55B80  ldrb     w8, [x20, #0xc5c]
006B55B84  ldr      x21, [x21, #0x790] ; GLOBAL Method$HotFix.BattleLogic.AI200007.AddAttack()
006B55B88  mov      x19, x0
006B55B8C  tbnz     w8, #0, #0x6b55bd4
006B55B90  adrp     x0, #0x8f41000
006B55B94  ldr      x0, [x0, #0x790] ; GLOBAL Method$HotFix.BattleLogic.AI200007.AddAttack()
006B55B98  bl       #0x382bd14 ; 
006B55B9C  adrp     x0, #0x8f41000
006B55BA0  ldr      x0, [x0, #0x798] ; GLOBAL Method$HotFix.BattleLogic.AI200007.<AddAttack>b__7_0()
006B55BA4  bl       #0x382bd14 ; 
006B55BA8  adrp     x0, #0x8f41000
006B55BAC  ldr      x0, [x0, #0x7a0] ; GLOBAL Method$HotFix.BattleLogic.AI200007.<AddAttack>b__7_1()
006B55BB0  bl       #0x382bd14 ; 
006B55BB4  adrp     x0, #0x8f05000
006B55BB8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<DoEventAction<FP>>()
006B55BBC  bl       #0x382bd14 ; 
006B55BC0  adrp     x0, #0x8ec1000
006B55BC4  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo
006B55BC8  bl       #0x382bd14 ; 
006B55BCC  mov      w8, #1
006B55BD0  strb     w8, [x20, #0xc5c]
006B55BD4  ldr      x1, [x21]
006B55BD8  ldrb     w8, [x1, #0x53]
006B55BDC  tbnz     w8, #5, #0x6b55d24
006B55BE0  mov      x0, x19
006B55BE4  mov      x1, xzr
006B55BE8  bl       #0x6b7f1c8 ; HotFix.BattleLogic.AIStateController$$IsAttackRandomSuccess
006B55BEC  tbz      w0, #0, #0x6b55ce8
006B55BF0  adrp     x22, #0x8f05000
006B55BF4  ldr      x22, [x22, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<DoEventAction<FP>>()
006B55BF8  mov      x0, x19
006B55BFC  ldr      x1, [x22]
006B55C00  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
006B55C04  adrp     x23, #0x8ec1000
006B55C08  ldr      x23, [x23, #0x6e8] ; GLOBAL System.Action_TypeInfo
006B55C0C  mov      x20, x0
006B55C10  ldr      x8, [x23]
006B55C14  mov      x0, x8
006B55C18  bl       #0x382bfa0 ; 
006B55C1C  adrp     x8, #0x8f41000
006B55C20  ldr      x8, [x8, #0x798] ; GLOBAL Method$HotFix.BattleLogic.AI200007.<AddAttack>b__7_0()
006B55C24  mov      x1, x19
006B55C28  mov      x3, xzr
006B55C2C  mov      x21, x0
006B55C30  ldr      x2, [x8]
006B55C34  bl       #0x7ade578 ; System.Action$$.ctor
006B55C38  cbz      x20, #0x6b55d7c
006B55C3C  mov      x0, x20
006B55C40  str      x21, [x0, #0x50]!
006B55C44  mov      x1, x21
006B55C48  bl       #0x382bcb8 ; 
006B55C4C  mov      x0, x19
006B55C50  mov      x1, x20
006B55C54  mov      x2, xzr
006B55C58  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006B55C5C  ldr      x8, [x19, #0x118]
006B55C60  cbz      x8, #0x6b55d7c
006B55C64  ldr      x1, [x8, #0x20]
006B55C68  mov      x0, x19
006B55C6C  mov      x2, xzr
006B55C70  bl       #0x6b82abc ; HotFix.BattleLogic.AIStateController$$AddTaskWaitWarning
006B55C74  mov      w1, #1
006B55C78  mov      x0, x19
006B55C7C  mov      x2, xzr
006B55C80  mov      x3, xzr
006B55C84  mov      x4, xzr
006B55C88  bl       #0x6b7f374 ; HotFix.BattleLogic.AIStateController$$AddTaskAttack
006B55C8C  ldr      x1, [x22]
006B55C90  mov      x0, x19
006B55C94  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
006B55C98  ldr      x8, [x23]
006B55C9C  mov      x20, x0
006B55CA0  mov      x0, x8
006B55CA4  bl       #0x382bfa0 ; 
006B55CA8  adrp     x8, #0x8f41000
006B55CAC  ldr      x8, [x8, #0x7a0] ; GLOBAL Method$HotFix.BattleLogic.AI200007.<AddAttack>b__7_1()
006B55CB0  mov      x1, x19
006B55CB4  mov      x3, xzr
006B55CB8  mov      x21, x0
006B55CBC  ldr      x2, [x8]
006B55CC0  bl       #0x7ade578 ; System.Action$$.ctor
006B55CC4  cbz      x20, #0x6b55d7c
006B55CC8  mov      x0, x20
006B55CCC  str      x21, [x0, #0x50]!
006B55CD0  mov      x1, x21
006B55CD4  bl       #0x382bcb8 ; 
006B55CD8  mov      x0, x19
006B55CDC  mov      x1, x20
006B55CE0  mov      x2, xzr
006B55CE4  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006B55CE8  adrp     x20, #0x9591000
006B55CEC  ldrb     w8, [x20, #0xa4b]
006B55CF0  cbnz     w8, #0x6b55d08
006B55CF4  adrp     x0, #0x8ee5000
006B55CF8  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B55CFC  bl       #0x382bd14 ; 
006B55D00  mov      w8, #1
006B55D04  strb     w8, [x20, #0xa4b]
006B55D08  adrp     x8, #0x8ee5000
006B55D0C  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B55D10  ldr      x1, [x8]
006B55D14  ldrb     w8, [x1, #0x53]
006B55D18  tbnz     w8, #5, #0x6b55d3c
006B55D1C  ldr      x0, [x19, #0x20]
006B55D20  b        #0x6b55d48 ; 
006B55D24  ldr      x2, [x1, #0x60]
006B55D28  mov      x0, x19
006B55D2C  ldp      x20, x19, [sp, #0x20]
006B55D30  ldp      x22, x21, [sp, #0x10]
006B55D34  ldp      x30, x23, [sp], #0x30
006B55D38  br       x2
006B55D3C  ldr      x8, [x1, #0x60]
006B55D40  mov      x0, x19
006B55D44  blr      x8
006B55D48  ldr      x8, [x19, #0x118]
006B55D4C  cbz      x8, #0x6b55d7c
006B55D50  cbz      x0, #0x6b55d7c
006B55D54  ldp      x2, x1, [x8, #0x10]
006B55D58  mov      x3, xzr
006B55D5C  bl       #0x563860c ; 
006B55D60  mov      x1, x0
006B55D64  mov      x0, x19
006B55D68  ldp      x20, x19, [sp, #0x20]
006B55D6C  ldp      x22, x21, [sp, #0x10]
006B55D70  mov      x2, xzr
006B55D74  ldp      x30, x23, [sp], #0x30
006B55D78  b        #0x6b809a0 ; HotFix.BattleLogic.AIStateController$$AddTaskWait
006B55D7C  bl       #0x382bfb8 ; 

