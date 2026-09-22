; HotFix.BattleLogic.WeaponMultiAngleModProcessor$$FillLoadData
; RVA 0x69D7C8C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7C8C  str      x30, [sp, #-0x30]!
0069D7C90  stp      x22, x21, [sp, #0x10]
0069D7C94  stp      x20, x19, [sp, #0x20]
0069D7C98  adrp     x21, #0x959d000
0069D7C9C  adrp     x22, #0x8f31000
0069D7CA0  ldrb     w8, [x21, #0x377]
0069D7CA4  ldr      x22, [x22, #0x330] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.FillLoadData()
0069D7CA8  mov      x19, x1
0069D7CAC  mov      x20, x0
0069D7CB0  tbnz     w8, #0, #0x69d7cd4
0069D7CB4  adrp     x0, #0x8f31000
0069D7CB8  ldr      x0, [x0, #0x338] ; GLOBAL Method$HotFix.BattleLogic.ModProcessorBase<MultiAngleModParams>.get_Params()
0069D7CBC  bl       #0x382bd14 ; 
0069D7CC0  adrp     x0, #0x8f31000
0069D7CC4  ldr      x0, [x0, #0x330] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.FillLoadData()
0069D7CC8  bl       #0x382bd14 ; 
0069D7CCC  mov      w8, #1
0069D7CD0  strb     w8, [x21, #0x377]
0069D7CD4  ldr      x2, [x22]
0069D7CD8  ldrb     w8, [x2, #0x53]
0069D7CDC  tbnz     w8, #5, #0x69d7cfc
0069D7CE0  adrp     x8, #0x8f31000
0069D7CE4  ldr      x8, [x8, #0x338] ; GLOBAL Method$HotFix.BattleLogic.ModProcessorBase<MultiAngleModParams>.get_Params()
0069D7CE8  ldr      x1, [x8]
0069D7CEC  ldrb     w8, [x1, #0x53]
0069D7CF0  tbnz     w8, #5, #0x69d7d18
0069D7CF4  ldr      x0, [x20, #0x30]
0069D7CF8  b        #0x69d7d24 ; 
0069D7CFC  ldr      x3, [x2, #0x60]
0069D7D00  mov      x0, x20
0069D7D04  mov      x1, x19
0069D7D08  ldp      x20, x19, [sp, #0x20]
0069D7D0C  ldp      x22, x21, [sp, #0x10]
0069D7D10  ldr      x30, [sp], #0x30
0069D7D14  br       x3
0069D7D18  ldr      x8, [x1, #0x60]
0069D7D1C  mov      x0, x20
0069D7D20  blr      x8
0069D7D24  cbz      x0, #0x69d7d44
0069D7D28  ldr      x1, [x0, #0x18]
0069D7D2C  add      x0, x19, #0x150
0069D7D30  ldp      x22, x21, [sp, #0x10]
0069D7D34  str      x1, [x19, #0x150]
0069D7D38  ldp      x20, x19, [sp, #0x20]
0069D7D3C  ldr      x30, [sp], #0x30
0069D7D40  b        #0x382bcb8 ; 
0069D7D44  bl       #0x382bfb8 ; 

