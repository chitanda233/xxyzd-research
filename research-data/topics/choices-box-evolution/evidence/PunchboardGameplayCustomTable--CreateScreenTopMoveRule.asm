; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateScreenTopMoveRule
; RVA 0x65BD044; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BD044  sub      sp, sp, #0x60
0065BD048  stp      x30, x21, [sp, #0x40]
0065BD04C  stp      x20, x19, [sp, #0x50]
0065BD050  adrp     x20, #0x9599000
0065BD054  adrp     x21, #0x8f0a000
0065BD058  mov      x19, x8
0065BD05C  ldrb     w8, [x20, #0x493]
0065BD060  ldr      x21, [x21, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateScreenTopMoveRule() @ 0x929b940
0065BD064  tbnz     w8, #0, #0x65bd088
0065BD068  adrp     x0, #0x8f0a000
0065BD06C  ldr      x0, [x0, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateScreenTopMoveRule() @ 0x929b940
0065BD070  bl       #0x382bd14 ; 
0065BD074  adrp     x0, #0x8f0a000
0065BD078  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD07C  bl       #0x382bd14 ; 
0065BD080  mov      w8, #1
0065BD084  strb     w8, [x20, #0x493]
0065BD088  ldr      x0, [x21]
0065BD08C  ldrb     w8, [x0, #0x53]
0065BD090  tbnz     w8, #5, #0x65bd104
0065BD094  adrp     x8, #0x8f0a000
0065BD098  ldr      x8, [x8, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD09C  ldr      x0, [x8]
0065BD0A0  ldr      w8, [x0, #0xe0]
0065BD0A4  cbnz     w8, #0x65bd0ac
0065BD0A8  bl       #0x382be8c ; 
0065BD0AC  mov      x4, #-0x10000
0065BD0B0  add      x8, sp, #8
0065BD0B4  mov      w0, #1
0065BD0B8  mov      w1, #1
0065BD0BC  mov      w2, #0x40000
0065BD0C0  mov      w3, #0x60000
0065BD0C4  movk     x4, #0xfffd, lsl #16
0065BD0C8  mov      w5, #0x30000
0065BD0CC  mov      w6, #0x30000
0065BD0D0  mov      w7, #0x50000
0065BD0D4  bl       #0x65bce54 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$BuildRule
0065BD0D8  ldr      x8, [sp, #0x38]
0065BD0DC  ldur     q0, [sp, #0x28]
0065BD0E0  ldur     q1, [sp, #0x18]
0065BD0E4  ldur     q2, [sp, #8]
0065BD0E8  str      x8, [x19, #0x30]
0065BD0EC  ldp      x30, x21, [sp, #0x40]
0065BD0F0  stp      q1, q0, [x19, #0x10]
0065BD0F4  str      q2, [x19]
0065BD0F8  ldp      x20, x19, [sp, #0x50]
0065BD0FC  add      sp, sp, #0x60
0065BD100  ret      
0065BD104  ldr      x1, [x0, #0x60]
0065BD108  mov      x8, x19
0065BD10C  ldp      x20, x19, [sp, #0x50]
0065BD110  ldp      x30, x21, [sp, #0x40]
0065BD114  add      sp, sp, #0x60
0065BD118  br       x1

