; HotFix.BattleLogic.MonsterMoveToPoint$$SetFaceToTargetDuringMove
; RVA 0x661BD40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661BD40  str      x30, [sp, #-0x30]!
00661BD44  stp      x22, x21, [sp, #0x10]
00661BD48  stp      x20, x19, [sp, #0x20]
00661BD4C  adrp     x21, #0x9599000
00661BD50  adrp     x22, #0x8f0c000
00661BD54  ldrb     w8, [x21, #0x8b4]
00661BD58  ldr      x22, [x22, #0x588] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.SetFaceToTargetDuringMove()
00661BD5C  mov      w20, w1
00661BD60  mov      x19, x0
00661BD64  tbnz     w8, #0, #0x661bd7c
00661BD68  adrp     x0, #0x8f0c000
00661BD6C  ldr      x0, [x0, #0x588] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.SetFaceToTargetDuringMove()
00661BD70  bl       #0x382bd14 ; 
00661BD74  mov      w8, #1
00661BD78  strb     w8, [x21, #0x8b4]
00661BD7C  ldr      x2, [x22]
00661BD80  ldrb     w8, [x2, #0x53]
00661BD84  tbnz     w8, #5, #0x661bda0
00661BD88  and      w8, w20, #1
00661BD8C  strb     w8, [x19, #0xb9]
00661BD90  ldp      x20, x19, [sp, #0x20]
00661BD94  ldp      x22, x21, [sp, #0x10]
00661BD98  ldr      x30, [sp], #0x30
00661BD9C  ret      
00661BDA0  ldr      x3, [x2, #0x60]
00661BDA4  and      w1, w20, #1
00661BDA8  mov      x0, x19
00661BDAC  ldp      x20, x19, [sp, #0x20]
00661BDB0  ldp      x22, x21, [sp, #0x10]
00661BDB4  ldr      x30, [sp], #0x30
00661BDB8  br       x3

