; HotFix.BattleLogic.AIPunchboard$$OnBorn
; RVA 0x6B8A05C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8A05C  sub      sp, sp, #0x70
006B8A060  str      x30, [sp, #0x40]
006B8A064  stp      x22, x21, [sp, #0x50]
006B8A068  stp      x20, x19, [sp, #0x60]
006B8A06C  adrp     x20, #0x959f000
006B8A070  adrp     x21, #0x8f43000
006B8A074  ldrb     w8, [x20, #0xf7a]
006B8A078  ldr      x21, [x21, #0x840] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnBorn() @ 0x92323f8
006B8A07C  mov      x19, x0
006B8A080  tbnz     w8, #0, #0x6b8a0c8
006B8A084  adrp     x0, #0x8f43000
006B8A088  ldr      x0, [x0, #0x840] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnBorn() @ 0x92323f8
006B8A08C  bl       #0x382bd14 ; 
006B8A090  adrp     x0, #0x8f43000
006B8A094  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.<OnBorn>b__11_0() @ 0x92323e0
006B8A098  bl       #0x382bd14 ; 
006B8A09C  adrp     x0, #0x8ec1000
006B8A0A0  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
006B8A0A4  bl       #0x382bd14 ; 
006B8A0A8  adrp     x0, #0x8ee8000
006B8A0AC  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006B8A0B0  bl       #0x382bd14 ; 
006B8A0B4  adrp     x0, #0x8f0b000
006B8A0B8  ldr      x0, [x0, #0x490] ; GLOBAL Born @ 0x92f3130
006B8A0BC  bl       #0x382bd14 ; 
006B8A0C0  mov      w8, #1
006B8A0C4  strb     w8, [x20, #0xf7a]
006B8A0C8  ldr      x1, [x21]
006B8A0CC  ldrb     w8, [x1, #0x53]
006B8A0D0  tbnz     w8, #5, #0x6b8a170
006B8A0D4  ldr      x0, [x19, #0x58]
006B8A0D8  cbz      x0, #0x6b8a220
006B8A0DC  adrp     x8, #0x8f0b000
006B8A0E0  ldr      x8, [x8, #0x490] ; GLOBAL Born @ 0x92f3130
006B8A0E4  mov      x2, xzr
006B8A0E8  ldr      x1, [x8]
006B8A0EC  bl       #0x67dcd04 ; HotFix.BattleLogic.EntityCharacter$$GetAnimLength
006B8A0F0  mov      x1, x0
006B8A0F4  mov      x0, x19
006B8A0F8  bl       #0x6b809a0 ; HotFix.BattleLogic.AIStateController$$AddTaskWait
006B8A0FC  adrp     x8, #0x8ec1000
006B8A100  ldr      x8, [x8, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
006B8A104  ldr      x0, [x8]
006B8A108  bl       #0x382bfa0 ; 
006B8A10C  adrp     x8, #0x8f43000
006B8A110  ldr      x8, [x8, #0x848] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.<OnBorn>b__11_0() @ 0x92323e0
006B8A114  mov      x1, x19
006B8A118  mov      x3, xzr
006B8A11C  mov      x20, x0
006B8A120  ldr      x2, [x8]
006B8A124  bl       #0x7ade578 ; System.Action$$.ctor
006B8A128  mov      x0, x19
006B8A12C  mov      x1, x20
006B8A130  bl       #0x6b7f70c ; HotFix.BattleLogic.AIStateController$$AddTaskDoEvent
006B8A134  adrp     x20, #0x9591000
006B8A138  ldrb     w8, [x20, #0xa4b]
006B8A13C  cbnz     w8, #0x6b8a154
006B8A140  adrp     x0, #0x8ee5000
006B8A144  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8A148  bl       #0x382bd14 ; 
006B8A14C  mov      w8, #1
006B8A150  strb     w8, [x20, #0xa4b]
006B8A154  adrp     x8, #0x8ee5000
006B8A158  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8A15C  ldr      x1, [x8]
006B8A160  ldrb     w8, [x1, #0x53]
006B8A164  tbnz     w8, #5, #0x6b8a18c
006B8A168  ldr      x0, [x19, #0x20]
006B8A16C  b        #0x6b8a198 ; 
006B8A170  ldr      x2, [x1, #0x60]
006B8A174  mov      x0, x19
006B8A178  ldp      x20, x19, [sp, #0x60]
006B8A17C  ldp      x22, x21, [sp, #0x50]
006B8A180  ldr      x30, [sp, #0x40]
006B8A184  add      sp, sp, #0x70
006B8A188  br       x2
006B8A18C  ldr      x8, [x1, #0x60]
006B8A190  mov      x0, x19
006B8A194  blr      x8
006B8A198  cbz      x0, #0x6b8a220
006B8A19C  add      x8, sp, #8
006B8A1A0  mov      x1, xzr
006B8A1A4  bl       #0x69ffac0 ; HotFix.BattleLogic.BattleWorldContext$$GetPunchboardGameplayRule
006B8A1A8  ldr      w8, [sp, #0xc]
006B8A1AC  cmp      w8, #1
006B8A1B0  b.ne     #0x6b8a20c
006B8A1B4  ldr      x8, [x19, #0x118]
006B8A1B8  cbz      x8, #0x6b8a220
006B8A1BC  ldr      w20, [x8, #0x10]
006B8A1C0  cbz      w20, #0x6b8a20c
006B8A1C4  cmp      w20, #0x3e8
006B8A1C8  b.eq     #0x6b8a20c
006B8A1CC  adrp     x22, #0x8ee8000
006B8A1D0  ldr      x22, [x22, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006B8A1D4  ldr      w21, [x8, #0x1c]
006B8A1D8  ldr      x0, [x22]
006B8A1DC  ldr      w9, [x0, #0xe0]
006B8A1E0  cbnz     w9, #0x6b8a1ec
006B8A1E4  bl       #0x382be8c ; 
006B8A1E8  ldr      x0, [x22]
006B8A1EC  ldr      x8, [x0, #0xb8]
006B8A1F0  cmp      w21, #1
006B8A1F4  cset     w2, eq
006B8A1F8  mov      x0, x19
006B8A1FC  ldr      x4, [x8, #0x338]
006B8A200  mov      w1, w20
006B8A204  mov      w3, wzr
006B8A208  bl       #0x6b8a224 ; HotFix.BattleLogic.AIStateController$$AddTaskPunchboardMoveOnPath
006B8A20C  ldp      x20, x19, [sp, #0x60]
006B8A210  ldp      x22, x21, [sp, #0x50]
006B8A214  ldr      x30, [sp, #0x40]
006B8A218  add      sp, sp, #0x70
006B8A21C  ret      
006B8A220  bl       #0x382bfb8 ; 

