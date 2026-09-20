; HotFix.BattleLogic.BasePunchboardState$$OnExit
; RVA 0x65A00A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065A00A0  sub      sp, sp, #0x40
0065A00A4  stp      x30, x23, [sp, #0x10]
0065A00A8  stp      x22, x21, [sp, #0x20]
0065A00AC  stp      x20, x19, [sp, #0x30]
0065A00B0  adrp     x21, #0x9599000
0065A00B4  adrp     x22, #0x8f09000
0065A00B8  ldrb     w8, [x21, #0x335]
0065A00BC  ldr      x22, [x22, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.OnExit() @ 0x923b6b8
0065A00C0  mov      x20, x1
0065A00C4  mov      x19, x0
0065A00C8  tbnz     w8, #0, #0x65a00f8
0065A00CC  adrp     x0, #0x8f09000
0065A00D0  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.OnExit() @ 0x923b6b8
0065A00D4  bl       #0x382bd14 ; 
0065A00D8  adrp     x0, #0x8ee8000
0065A00DC  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065A00E0  bl       #0x382bd14 ; 
0065A00E4  adrp     x0, #0x8ee6000
0065A00E8  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065A00EC  bl       #0x382bd14 ; 
0065A00F0  mov      w8, #1
0065A00F4  strb     w8, [x21, #0x335]
0065A00F8  ldr      x2, [x22]
0065A00FC  ldrb     w8, [x2, #0x53]
0065A0100  tbnz     w8, #5, #0x65a0154
0065A0104  ldr      x0, [x19, #0x28]
0065A0108  cbz      x0, #0x65a02b8
0065A010C  bl       #0x65a02bc ; HotFix.BattleLogic.PlayerPunchboard$$Clear
0065A0110  ldr      x20, [x19, #0x18]
0065A0114  cbz      x20, #0x65a02b8
0065A0118  adrp     x21, #0x9599000
0065A011C  ldrb     w8, [x21, #0x4b0]
0065A0120  cbnz     w8, #0x65a0138
0065A0124  adrp     x0, #0x8f08000
0065A0128  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
0065A012C  bl       #0x382bd14 ; 
0065A0130  mov      w8, #1
0065A0134  strb     w8, [x21, #0x4b0]
0065A0138  adrp     x8, #0x8f08000
0065A013C  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
0065A0140  ldr      x2, [x8]
0065A0144  ldrb     w8, [x2, #0x53]
0065A0148  tbnz     w8, #5, #0x65a0174
0065A014C  strb     wzr, [x20, #0x648]
0065A0150  b        #0x65a0184 ; 
0065A0154  ldr      x3, [x2, #0x60]
0065A0158  mov      x0, x19
0065A015C  mov      x1, x20
0065A0160  ldp      x20, x19, [sp, #0x30]
0065A0164  ldp      x22, x21, [sp, #0x20]
0065A0168  ldp      x30, x23, [sp, #0x10]
0065A016C  add      sp, sp, #0x40
0065A0170  br       x3
0065A0174  ldr      x8, [x2, #0x60]
0065A0178  mov      x0, x20
0065A017C  mov      w1, wzr
0065A0180  blr      x8
0065A0184  adrp     x20, #0x9599000
0065A0188  ldrb     w8, [x20, #0x4b1]
0065A018C  cbnz     w8, #0x65a01a4
0065A0190  adrp     x0, #0x8f08000
0065A0194  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065A0198  bl       #0x382bd14 ; 
0065A019C  mov      w8, #1
0065A01A0  strb     w8, [x20, #0x4b1]
0065A01A4  adrp     x8, #0x8f08000
0065A01A8  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065A01AC  ldr      x1, [x8]
0065A01B0  ldrb     w8, [x1, #0x53]
0065A01B4  tbnz     w8, #5, #0x65a01c0
0065A01B8  ldr      x20, [x19, #0x10]
0065A01BC  b        #0x65a01d0 ; 
0065A01C0  ldr      x8, [x1, #0x60]
0065A01C4  mov      x0, x19
0065A01C8  blr      x8
0065A01CC  mov      x20, x0
0065A01D0  ldr      x21, [x19, #0x18]
0065A01D4  cbz      x21, #0x65a02b8
0065A01D8  adrp     x8, #0x8ee6000
0065A01DC  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065A01E0  ldr      x1, [x8]
0065A01E4  ldrb     w8, [x1, #0x53]
0065A01E8  tbnz     w8, #5, #0x65a01f4
0065A01EC  ldr      x22, [x21, #0x38]
0065A01F0  b        #0x65a0204 ; 
0065A01F4  ldr      x8, [x1, #0x60]
0065A01F8  mov      x0, x21
0065A01FC  blr      x8
0065A0200  mov      x22, x0
0065A0204  cbz      x22, #0x65a02b8
0065A0208  adrp     x23, #0x9591000
0065A020C  ldrb     w8, [x23, #0xa7f]
0065A0210  cbnz     w8, #0x65a0228
0065A0214  adrp     x0, #0x8ee6000
0065A0218  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
0065A021C  bl       #0x382bd14 ; 
0065A0220  mov      w8, #1
0065A0224  strb     w8, [x23, #0xa7f]
0065A0228  adrp     x8, #0x8ee6000
0065A022C  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
0065A0230  ldr      x1, [x8]
0065A0234  ldrb     w8, [x1, #0x53]
0065A0238  tbnz     w8, #5, #0x65a0244
0065A023C  ldr      x22, [x22, #0x178]
0065A0240  b        #0x65a0254 ; 
0065A0244  ldr      x8, [x1, #0x60]
0065A0248  mov      x0, x22
0065A024C  blr      x8
0065A0250  mov      x22, x0
0065A0254  adrp     x23, #0x8ee8000
0065A0258  ldr      x23, [x23, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065A025C  ldr      x19, [x19, #0x18]
0065A0260  ldr      x0, [x23]
0065A0264  ldr      w8, [x0, #0xe0]
0065A0268  cbnz     w8, #0x65a0270
0065A026C  bl       #0x382be8c ; 
0065A0270  cbz      x20, #0x65a02b8
0065A0274  ldr      x8, [x23]
0065A0278  mov      w5, #0x10000
0065A027C  mov      x0, x20
0065A0280  mov      x1, x21
0065A0284  ldr      x8, [x8, #0xb8]
0065A0288  mov      x2, x22
0065A028C  mov      x3, x19
0065A0290  mov      w6, wzr
0065A0294  ldr      w4, [x8, #0x120]
0065A0298  mov      w7, wzr
0065A029C  str      xzr, [sp]
0065A02A0  bl       #0x6a0d17c ; HotFix.BattleLogic.BattleWorldContext$$AddBuffToEntity
0065A02A4  ldp      x20, x19, [sp, #0x30]
0065A02A8  ldp      x22, x21, [sp, #0x20]
0065A02AC  ldp      x30, x23, [sp, #0x10]
0065A02B0  add      sp, sp, #0x40
0065A02B4  ret      
0065A02B8  bl       #0x382bfb8 ; 

