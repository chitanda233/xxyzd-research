; HotFix.BattleLogic.WeaponMultiAngleMod$$get_ProcessorInstance
; RVA 0x69D7AF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7AF8  stp      x30, x21, [sp, #-0x20]!
0069D7AFC  stp      x20, x19, [sp, #0x10]
0069D7B00  adrp     x20, #0x959d000
0069D7B04  adrp     x21, #0x8f31000
0069D7B08  ldrb     w8, [x20, #0x375]
0069D7B0C  ldr      x21, [x21, #0x310] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleMod.get_ProcessorInstance()
0069D7B10  mov      x19, x0
0069D7B14  tbnz     w8, #0, #0x69d7b38
0069D7B18  adrp     x0, #0x8f31000
0069D7B1C  ldr      x0, [x0, #0x310] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleMod.get_ProcessorInstance()
0069D7B20  bl       #0x382bd14 ; 
0069D7B24  adrp     x0, #0x8f31000
0069D7B28  ldr      x0, [x0, #0x318] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeaponMultiAngleModProcessor>()
0069D7B2C  bl       #0x382bd14 ; 
0069D7B30  mov      w8, #1
0069D7B34  strb     w8, [x20, #0x375]
0069D7B38  ldr      x1, [x21]
0069D7B3C  ldrb     w8, [x1, #0x53]
0069D7B40  tbnz     w8, #5, #0x69d7b80
0069D7B44  adrp     x20, #0x9591000
0069D7B48  ldrb     w8, [x20, #0xa4b]
0069D7B4C  cbnz     w8, #0x69d7b64
0069D7B50  adrp     x0, #0x8ee5000
0069D7B54  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069D7B58  bl       #0x382bd14 ; 
0069D7B5C  mov      w8, #1
0069D7B60  strb     w8, [x20, #0xa4b]
0069D7B64  adrp     x8, #0x8ee5000
0069D7B68  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069D7B6C  ldr      x1, [x8]
0069D7B70  ldrb     w8, [x1, #0x53]
0069D7B74  tbnz     w8, #5, #0x69d7b94
0069D7B78  ldr      x19, [x19, #0x20]
0069D7B7C  b        #0x69d7ba4 ; 
0069D7B80  ldr      x2, [x1, #0x60]
0069D7B84  mov      x0, x19
0069D7B88  ldp      x20, x19, [sp, #0x10]
0069D7B8C  ldp      x30, x21, [sp], #0x20
0069D7B90  br       x2
0069D7B94  ldr      x8, [x1, #0x60]
0069D7B98  mov      x0, x19
0069D7B9C  blr      x8
0069D7BA0  mov      x19, x0
0069D7BA4  cbz      x19, #0x69d7c0c
0069D7BA8  adrp     x20, #0x9591000
0069D7BAC  ldrb     w8, [x20, #0xa4c]
0069D7BB0  cbnz     w8, #0x69d7bc8
0069D7BB4  adrp     x0, #0x8ee5000
0069D7BB8  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069D7BBC  bl       #0x382bd14 ; 
0069D7BC0  mov      w8, #1
0069D7BC4  strb     w8, [x20, #0xa4c]
0069D7BC8  adrp     x8, #0x8ee5000
0069D7BCC  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069D7BD0  ldr      x1, [x8]
0069D7BD4  ldrb     w8, [x1, #0x53]
0069D7BD8  tbnz     w8, #5, #0x69d7be4
0069D7BDC  ldr      x0, [x19, #0x210]
0069D7BE0  b        #0x69d7bf0 ; 
0069D7BE4  ldr      x8, [x1, #0x60]
0069D7BE8  mov      x0, x19
0069D7BEC  blr      x8
0069D7BF0  cbz      x0, #0x69d7c0c
0069D7BF4  adrp     x8, #0x8f31000
0069D7BF8  ldr      x8, [x8, #0x318] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeaponMultiAngleModProcessor>()
0069D7BFC  ldp      x20, x19, [sp, #0x10]
0069D7C00  ldr      x1, [x8]
0069D7C04  ldp      x30, x21, [sp], #0x20
0069D7C08  b        #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0069D7C0C  bl       #0x382bfb8 ; 

