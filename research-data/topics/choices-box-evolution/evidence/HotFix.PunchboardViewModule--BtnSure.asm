; HotFix.PunchboardViewModule$$BtnSure
; RVA 0x7789D98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007789D98  stp      x30, x21, [sp, #-0x20]!
007789D9C  stp      x20, x19, [sp, #0x10]
007789DA0  adrp     x20, #0x95ab000
007789DA4  adrp     x21, #0x8fb7000
007789DA8  ldrb     w8, [x20, #0x27c]
007789DAC  ldr      x21, [x21, #0x2c0] ; GLOBAL Method$HotFix.PunchboardViewModule.BtnSure() @ 0x929bad8
007789DB0  mov      x19, x0
007789DB4  tbnz     w8, #0, #0x7789df0
007789DB8  adrp     x0, #0x8ee6000
007789DBC  ldr      x0, [x0, #0x88] ; GLOBAL HotFix.DxxTools_TypeInfo @ 0x91e5560
007789DC0  bl       #0x382bd14 ; 
007789DC4  adrp     x0, #0x8f09000
007789DC8  ldr      x0, [x0, #0xa0] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Count() @ 0x921f560
007789DCC  bl       #0x382bd14 ; 
007789DD0  adrp     x0, #0x8fb7000
007789DD4  ldr      x0, [x0, #0x2c0] ; GLOBAL Method$HotFix.PunchboardViewModule.BtnSure() @ 0x929bad8
007789DD8  bl       #0x382bd14 ; 
007789DDC  adrp     x0, #0x8f6e000
007789DE0  ldr      x0, [x0, #0x4d8] ; GLOBAL HotFix.PunchboardViewModule_TypeInfo @ 0x91ee730
007789DE4  bl       #0x382bd14 ; 
007789DE8  mov      w8, #1
007789DEC  strb     w8, [x20, #0x27c]
007789DF0  ldr      x1, [x21]
007789DF4  ldrb     w8, [x1, #0x53]
007789DF8  tbnz     w8, #5, #0x7789e58
007789DFC  ldr      x0, [x19, #0x40]
007789E00  cbz      x0, #0x7789eec
007789E04  mov      x1, xzr
007789E08  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007789E0C  adrp     x8, #0x8ee6000
007789E10  ldr      x8, [x8, #0x88] ; GLOBAL HotFix.DxxTools_TypeInfo @ 0x91e5560
007789E14  mov      x20, x0
007789E18  ldr      x8, [x8]
007789E1C  ldr      w9, [x8, #0xe0]
007789E20  cbnz     w9, #0x7789e2c
007789E24  mov      x0, x8
007789E28  bl       #0x382be8c ; 
007789E2C  mov      x0, x20
007789E30  mov      w1, wzr
007789E34  mov      x2, xzr
007789E38  bl       #0x779e90c ; HotFix.DxxTools$$SetActiveSafe
007789E3C  ldr      w8, [x19, #0xa4]
007789E40  cbz      w8, #0x7789e6c
007789E44  cmp      w8, #7
007789E48  b.le     #0x7789eb0
007789E4C  ldp      x20, x19, [sp, #0x10]
007789E50  ldp      x30, x21, [sp], #0x20
007789E54  ret      
007789E58  ldr      x2, [x1, #0x60]
007789E5C  mov      x0, x19
007789E60  ldp      x20, x19, [sp, #0x10]
007789E64  ldp      x30, x21, [sp], #0x20
007789E68  br       x2
007789E6C  adrp     x20, #0x8f6e000
007789E70  ldr      x20, [x20, #0x4d8] ; GLOBAL HotFix.PunchboardViewModule_TypeInfo @ 0x91ee730
007789E74  ldr      x0, [x20]
007789E78  ldr      w8, [x0, #0xe0]
007789E7C  cbnz     w8, #0x7789e88
007789E80  bl       #0x382be8c ; 
007789E84  ldr      x0, [x20]
007789E88  ldr      x8, [x0, #0xb8]
007789E8C  ldr      x8, [x8]
007789E90  cbz      x8, #0x7789eec
007789E94  ldr      x8, [x8, #0x10]
007789E98  cbz      x8, #0x7789eec
007789E9C  ldr      w8, [x8, #0x18]
007789EA0  cmp      w8, #5
007789EA4  b.ne     #0x7789ed4
007789EA8  mov      w1, #1
007789EAC  b        #0x7789ec4 ; 
007789EB0  mov      w8, #1
007789EB4  mov      x0, x19
007789EB8  strb     w8, [x19, #0xc4]
007789EBC  bl       #0x7786ac8 ; HotFix.PunchboardViewModule$$StopRunSound
007789EC0  mov      w1, #9
007789EC4  mov      x0, x19
007789EC8  ldp      x20, x19, [sp, #0x10]
007789ECC  ldp      x30, x21, [sp], #0x20
007789ED0  b        #0x77890c4 ; HotFix.PunchboardViewModule$$EnterState
007789ED4  mov      x0, x19
007789ED8  bl       #0x778964c ; HotFix.PunchboardViewModule$$InitMulAndSingleMoveCount
007789EDC  mov      x0, x19
007789EE0  ldp      x20, x19, [sp, #0x10]
007789EE4  ldp      x30, x21, [sp], #0x20
007789EE8  b        #0x77897d0 ; HotFix.PunchboardViewModule$$StartRandomTween
007789EEC  bl       #0x382bfb8 ; 

