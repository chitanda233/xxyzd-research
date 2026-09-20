; HotFix.BattleLogic.BattleWorldContext$$get_UseNvWuShenInitSkill
; RVA 0x69FFE94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069FFE94  stp      x30, x21, [sp, #-0x20]!
0069FFE98  stp      x20, x19, [sp, #0x10]
0069FFE9C  adrp     x20, #0x959d000
0069FFEA0  adrp     x21, #0x8f32000
0069FFEA4  ldrb     w8, [x20, #0x52e]
0069FFEA8  ldr      x21, [x21, #0x568] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_UseNvWuShenInitSkill() @ 0x9240010
0069FFEAC  mov      x19, x0
0069FFEB0  tbnz     w8, #0, #0x69ffec8
0069FFEB4  adrp     x0, #0x8f32000
0069FFEB8  ldr      x0, [x0, #0x568] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_UseNvWuShenInitSkill() @ 0x9240010
0069FFEBC  bl       #0x382bd14 ; 
0069FFEC0  mov      w8, #1
0069FFEC4  strb     w8, [x20, #0x52e]
0069FFEC8  ldr      x1, [x21]
0069FFECC  ldrb     w8, [x1, #0x53]
0069FFED0  tbnz     w8, #5, #0x69fff10
0069FFED4  adrp     x20, #0x9599000
0069FFED8  ldrb     w8, [x20, #0x4d6]
0069FFEDC  cbnz     w8, #0x69ffef4
0069FFEE0  adrp     x0, #0x8f09000
0069FFEE4  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0069FFEE8  bl       #0x382bd14 ; 
0069FFEEC  mov      w8, #1
0069FFEF0  strb     w8, [x20, #0x4d6]
0069FFEF4  adrp     x8, #0x8f09000
0069FFEF8  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
0069FFEFC  ldr      x1, [x8]
0069FFF00  ldrb     w8, [x1, #0x53]
0069FFF04  tbnz     w8, #5, #0x69fff24
0069FFF08  ldr      w0, [x19, #0x290]
0069FFF0C  b        #0x69fff30 ; 
0069FFF10  ldr      x2, [x1, #0x60]
0069FFF14  mov      x0, x19
0069FFF18  ldp      x20, x19, [sp, #0x10]
0069FFF1C  ldp      x30, x21, [sp], #0x20
0069FFF20  br       x2
0069FFF24  ldr      x8, [x1, #0x60]
0069FFF28  mov      x0, x19
0069FFF2C  blr      x8
0069FFF30  cmp      w0, #1
0069FFF34  b.ne     #0x69fffd4
0069FFF38  adrp     x20, #0x9599000
0069FFF3C  ldrb     w8, [x20, #0x28d]
0069FFF40  cbnz     w8, #0x69fff58
0069FFF44  adrp     x0, #0x8f07000
0069FFF48  ldr      x0, [x0, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionIndex() @ 0x923fe98
0069FFF4C  bl       #0x382bd14 ; 
0069FFF50  mov      w8, #1
0069FFF54  strb     w8, [x20, #0x28d]
0069FFF58  adrp     x8, #0x8f07000
0069FFF5C  ldr      x8, [x8, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionIndex() @ 0x923fe98
0069FFF60  ldr      x1, [x8]
0069FFF64  ldrb     w8, [x1, #0x53]
0069FFF68  tbnz     w8, #5, #0x69fffa8
0069FFF6C  adrp     x20, #0x9599000
0069FFF70  ldrb     w8, [x20, #0x2ab]
0069FFF74  cbnz     w8, #0x69fff8c
0069FFF78  adrp     x0, #0x8f07000
0069FFF7C  ldr      x0, [x0, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_MissionIndex() @ 0x923c3a8
0069FFF80  bl       #0x382bd14 ; 
0069FFF84  mov      w8, #1
0069FFF88  strb     w8, [x20, #0x2ab]
0069FFF8C  adrp     x8, #0x8f07000
0069FFF90  ldr      x8, [x8, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_MissionIndex() @ 0x923c3a8
0069FFF94  ldr      x1, [x8]
0069FFF98  ldrb     w8, [x1, #0x53]
0069FFF9C  tbnz     w8, #5, #0x69fffb4
0069FFFA0  ldr      w0, [x19, #0x324]
0069FFFA4  b        #0x69fffc0 ; 
0069FFFA8  ldr      x8, [x1, #0x60]
0069FFFAC  mov      x0, x19
0069FFFB0  b        #0x69fffbc ; 
0069FFFB4  ldr      x8, [x1, #0x60]
0069FFFB8  add      x0, x19, #0x290
0069FFFBC  blr      x8
0069FFFC0  cmp      w0, #4
0069FFFC4  b.gt     #0x69fffd4
0069FFFC8  ldr      w8, [x19, #0x420]
0069FFFCC  cmp      w8, #1
0069FFFD0  b.le     #0x69fffe4
0069FFFD4  mov      w0, wzr
0069FFFD8  ldp      x20, x19, [sp, #0x10]
0069FFFDC  ldp      x30, x21, [sp], #0x20
0069FFFE0  ret      
0069FFFE4  ldr      w8, [x19, #0x424]
0069FFFE8  cmp      w8, #5
0069FFFEC  cset     w0, lt
0069FFFF0  b        #0x69fffd8 ; 

