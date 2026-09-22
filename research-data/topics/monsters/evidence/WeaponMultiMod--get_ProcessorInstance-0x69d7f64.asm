; HotFix.BattleLogic.WeaponMultiMod$$get_ProcessorInstance
; RVA 0x69D7F64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7F64  stp      x30, x21, [sp, #-0x20]!
0069D7F68  stp      x20, x19, [sp, #0x10]
0069D7F6C  adrp     x20, #0x959d000
0069D7F70  adrp     x21, #0x8f31000
0069D7F74  ldrb     w8, [x20, #0x37d]
0069D7F78  ldr      x21, [x21, #0x370] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiMod.get_ProcessorInstance()
0069D7F7C  mov      x19, x0
0069D7F80  tbnz     w8, #0, #0x69d7fa4
0069D7F84  adrp     x0, #0x8f31000
0069D7F88  ldr      x0, [x0, #0x370] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiMod.get_ProcessorInstance()
0069D7F8C  bl       #0x382bd14 ; 
0069D7F90  adrp     x0, #0x8f31000
0069D7F94  ldr      x0, [x0, #0x378] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeaponMultiModProcessor>()
0069D7F98  bl       #0x382bd14 ; 
0069D7F9C  mov      w8, #1
0069D7FA0  strb     w8, [x20, #0x37d]
0069D7FA4  ldr      x1, [x21]
0069D7FA8  ldrb     w8, [x1, #0x53]
0069D7FAC  tbnz     w8, #5, #0x69d7fec
0069D7FB0  adrp     x20, #0x9591000
0069D7FB4  ldrb     w8, [x20, #0xa4b]
0069D7FB8  cbnz     w8, #0x69d7fd0
0069D7FBC  adrp     x0, #0x8ee5000
0069D7FC0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069D7FC4  bl       #0x382bd14 ; 
0069D7FC8  mov      w8, #1
0069D7FCC  strb     w8, [x20, #0xa4b]
0069D7FD0  adrp     x8, #0x8ee5000
0069D7FD4  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069D7FD8  ldr      x1, [x8]
0069D7FDC  ldrb     w8, [x1, #0x53]
0069D7FE0  tbnz     w8, #5, #0x69d8000
0069D7FE4  ldr      x19, [x19, #0x20]
0069D7FE8  b        #0x69d8010 ; 
0069D7FEC  ldr      x2, [x1, #0x60]
0069D7FF0  mov      x0, x19
0069D7FF4  ldp      x20, x19, [sp, #0x10]
0069D7FF8  ldp      x30, x21, [sp], #0x20
0069D7FFC  br       x2
0069D8000  ldr      x8, [x1, #0x60]
0069D8004  mov      x0, x19
0069D8008  blr      x8
0069D800C  mov      x19, x0
0069D8010  cbz      x19, #0x69d8078
0069D8014  adrp     x20, #0x9591000
0069D8018  ldrb     w8, [x20, #0xa4c]
0069D801C  cbnz     w8, #0x69d8034
0069D8020  adrp     x0, #0x8ee5000
0069D8024  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069D8028  bl       #0x382bd14 ; 
0069D802C  mov      w8, #1
0069D8030  strb     w8, [x20, #0xa4c]
0069D8034  adrp     x8, #0x8ee5000
0069D8038  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069D803C  ldr      x1, [x8]
0069D8040  ldrb     w8, [x1, #0x53]
0069D8044  tbnz     w8, #5, #0x69d8050
0069D8048  ldr      x0, [x19, #0x210]
0069D804C  b        #0x69d805c ; 
0069D8050  ldr      x8, [x1, #0x60]
0069D8054  mov      x0, x19
0069D8058  blr      x8
0069D805C  cbz      x0, #0x69d8078
0069D8060  adrp     x8, #0x8f31000
0069D8064  ldr      x8, [x8, #0x378] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeaponMultiModProcessor>()
0069D8068  ldp      x20, x19, [sp, #0x10]
0069D806C  ldr      x1, [x8]
0069D8070  ldp      x30, x21, [sp], #0x20
0069D8074  b        #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0069D8078  bl       #0x382bfb8 ; 

