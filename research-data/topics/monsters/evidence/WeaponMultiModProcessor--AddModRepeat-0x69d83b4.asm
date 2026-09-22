; HotFix.BattleLogic.WeaponMultiModProcessor$$AddModRepeat
; RVA 0x69D83B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D83B4  str      x30, [sp, #-0x30]!
0069D83B8  stp      x22, x21, [sp, #0x10]
0069D83BC  stp      x20, x19, [sp, #0x20]
0069D83C0  adrp     x21, #0x959d000
0069D83C4  adrp     x22, #0x8f31000
0069D83C8  ldrb     w8, [x21, #0x382]
0069D83CC  ldr      x22, [x22, #0x3b8] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.AddModRepeat()
0069D83D0  mov      x20, x1
0069D83D4  mov      x19, x0
0069D83D8  tbnz     w8, #0, #0x69d83f0
0069D83DC  adrp     x0, #0x8f31000
0069D83E0  ldr      x0, [x0, #0x3b8] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.AddModRepeat()
0069D83E4  bl       #0x382bd14 ; 
0069D83E8  mov      w8, #1
0069D83EC  strb     w8, [x21, #0x382]
0069D83F0  ldr      x2, [x22]
0069D83F4  ldrb     w8, [x2, #0x53]
0069D83F8  tbnz     w8, #5, #0x69d845c
0069D83FC  cbz      x20, #0x69d8478
0069D8400  ldr      x8, [x19, #0x50]
0069D8404  ldr      x9, [x20, #0x18]
0069D8408  ldr      w10, [x19, #0x58]
0069D840C  ldp      x22, x21, [sp, #0x10]
0069D8410  add      x8, x9, x8
0069D8414  str      x8, [x19, #0x50]
0069D8418  ldr      w8, [x20, #0x20]
0069D841C  add      w8, w8, w10
0069D8420  str      w8, [x19, #0x58]
0069D8424  ldr      x8, [x20, #0x30]
0069D8428  ldp      x9, x10, [x19, #0x60]
0069D842C  add      x8, x8, x9
0069D8430  str      x8, [x19, #0x60]
0069D8434  ldr      x8, [x20, #0x38]
0069D8438  add      x8, x8, x10
0069D843C  str      x8, [x19, #0x68]
0069D8440  ldr      w8, [x19, #0x70]
0069D8444  ldr      w9, [x20, #0x40]
0069D8448  add      w8, w9, w8
0069D844C  str      w8, [x19, #0x70]
0069D8450  ldp      x20, x19, [sp, #0x20]
0069D8454  ldr      x30, [sp], #0x30
0069D8458  ret      
0069D845C  ldr      x3, [x2, #0x60]
0069D8460  mov      x0, x19
0069D8464  mov      x1, x20
0069D8468  ldp      x20, x19, [sp, #0x20]
0069D846C  ldp      x22, x21, [sp, #0x10]
0069D8470  ldr      x30, [sp], #0x30
0069D8474  br       x3
0069D8478  bl       #0x382bfb8 ; 

