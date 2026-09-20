; HotFix.ShowPunchboardMsgProcessor.<>c$$<OnExec>b__0_0
; RVA 0x6FBE330; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006FBE330  str      x30, [sp, #-0x30]!
006FBE334  stp      x22, x21, [sp, #0x10]
006FBE338  stp      x20, x19, [sp, #0x20]
006FBE33C  adrp     x21, #0x95a4000
006FBE340  adrp     x22, #0x8f6e000
006FBE344  ldrb     w8, [x21, #0x5cc]
006FBE348  ldr      x22, [x22, #0x4e8] ; GLOBAL Method$HotFix.ShowPunchboardMsgProcessor.<>c.<OnExec>b__0_0() @ 0x92df2f8
006FBE34C  mov      x19, x1
006FBE350  mov      x20, x0
006FBE354  tbnz     w8, #0, #0x6fbe36c
006FBE358  adrp     x0, #0x8f6e000
006FBE35C  ldr      x0, [x0, #0x4e8] ; GLOBAL Method$HotFix.ShowPunchboardMsgProcessor.<>c.<OnExec>b__0_0() @ 0x92df2f8
006FBE360  bl       #0x382bd14 ; 
006FBE364  mov      w8, #1
006FBE368  strb     w8, [x21, #0x5cc]
006FBE36C  ldr      x2, [x22]
006FBE370  ldrb     w8, [x2, #0x53]
006FBE374  tbnz     w8, #5, #0x6fbe38c
006FBE378  mov      w0, w19
006FBE37C  ldp      x20, x19, [sp, #0x20]
006FBE380  ldp      x22, x21, [sp, #0x10]
006FBE384  ldr      x30, [sp], #0x30
006FBE388  ret      
006FBE38C  ldr      x3, [x2, #0x60]
006FBE390  mov      x0, x20
006FBE394  mov      x1, x19
006FBE398  ldp      x20, x19, [sp, #0x20]
006FBE39C  ldp      x22, x21, [sp, #0x10]
006FBE3A0  ldr      x30, [sp], #0x30
006FBE3A4  br       x3

