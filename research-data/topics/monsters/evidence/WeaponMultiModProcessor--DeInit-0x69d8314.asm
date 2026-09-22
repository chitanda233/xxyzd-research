; HotFix.BattleLogic.WeaponMultiModProcessor$$DeInit
; RVA 0x69D8314; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D8314  stp      x30, x21, [sp, #-0x20]!
0069D8318  stp      x20, x19, [sp, #0x10]
0069D831C  adrp     x20, #0x959d000
0069D8320  adrp     x21, #0x8f31000
0069D8324  ldrb     w8, [x20, #0x381]
0069D8328  ldr      x21, [x21, #0x3b0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.DeInit()
0069D832C  mov      x19, x0
0069D8330  tbnz     w8, #0, #0x69d8354
0069D8334  adrp     x0, #0x8f2e000
0069D8338  ldr      x0, [x0, #0xc80] ; GLOBAL Method$System.Collections.Generic.List<FP>.Clear()
0069D833C  bl       #0x382bd14 ; 
0069D8340  adrp     x0, #0x8f31000
0069D8344  ldr      x0, [x0, #0x3b0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.DeInit()
0069D8348  bl       #0x382bd14 ; 
0069D834C  mov      w8, #1
0069D8350  strb     w8, [x20, #0x381]
0069D8354  ldr      x1, [x21]
0069D8358  ldrb     w8, [x1, #0x53]
0069D835C  tbnz     w8, #5, #0x69d83a0
0069D8360  mov      x0, x19
0069D8364  ldr      x8, [x0, #0x48]!
0069D8368  cbz      x8, #0x69d8378
0069D836C  ldr      w9, [x8, #0x1c]
0069D8370  add      w9, w9, #1
0069D8374  stp      wzr, w9, [x8, #0x18]
0069D8378  mov      x1, xzr
0069D837C  str      xzr, [x19, #0x48]
0069D8380  bl       #0x382bcb8 ; 
0069D8384  str      xzr, [x19, #0x50]
0069D8388  str      wzr, [x19, #0x58]
0069D838C  stp      xzr, xzr, [x19, #0x60]
0069D8390  str      wzr, [x19, #0x70]
0069D8394  ldp      x20, x19, [sp, #0x10]
0069D8398  ldp      x30, x21, [sp], #0x20
0069D839C  ret      
0069D83A0  ldr      x2, [x1, #0x60]
0069D83A4  mov      x0, x19
0069D83A8  ldp      x20, x19, [sp, #0x10]
0069D83AC  ldp      x30, x21, [sp], #0x20
0069D83B0  br       x2

