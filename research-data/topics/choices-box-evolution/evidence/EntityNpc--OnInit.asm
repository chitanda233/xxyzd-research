; HotFix.BattleLogic.EntityNpc$$OnInit
; RVA 0x68D2AE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D2AE8  stp      x30, x21, [sp, #-0x20]!
0068D2AEC  stp      x20, x19, [sp, #0x10]
0068D2AF0  adrp     x20, #0x959c000
0068D2AF4  adrp     x21, #0x8f28000
0068D2AF8  ldrb     w8, [x20, #0x76d]
0068D2AFC  ldr      x21, [x21, #0x838] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnInit() @ 0x9263db0
0068D2B00  mov      x19, x0
0068D2B04  tbnz     w8, #0, #0x68d2b34
0068D2B08  adrp     x0, #0x8f22000
0068D2B0C  ldr      x0, [x0, #0xac0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentAI>() @ 0x920fe90
0068D2B10  bl       #0x382bd14 ; 
0068D2B14  adrp     x0, #0x8f28000
0068D2B18  ldr      x0, [x0, #0x7d8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentMovement>() @ 0x920fef8
0068D2B1C  bl       #0x382bd14 ; 
0068D2B20  adrp     x0, #0x8f28000
0068D2B24  ldr      x0, [x0, #0x838] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnInit() @ 0x9263db0
0068D2B28  bl       #0x382bd14 ; 
0068D2B2C  mov      w8, #1
0068D2B30  strb     w8, [x20, #0x76d]
0068D2B34  ldr      x1, [x21]
0068D2B38  ldrb     w8, [x1, #0x53]
0068D2B3C  tbnz     w8, #5, #0x68d2b80
0068D2B40  mov      w20, #1
0068D2B44  str      w20, [x19, #0x62c]
0068D2B48  adrp     x21, #0x9591000
0068D2B4C  ldrb     w8, [x21, #0xa4b]
0068D2B50  cbnz     w8, #0x68d2b64
0068D2B54  adrp     x0, #0x8ee5000
0068D2B58  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D2B5C  bl       #0x382bd14 ; 
0068D2B60  strb     w20, [x21, #0xa4b]
0068D2B64  adrp     x8, #0x8ee5000
0068D2B68  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D2B6C  ldr      x1, [x8]
0068D2B70  ldrb     w8, [x1, #0x53]
0068D2B74  tbnz     w8, #5, #0x68d2b94
0068D2B78  ldr      x0, [x19, #0x20]
0068D2B7C  b        #0x68d2ba0 ; 
0068D2B80  ldr      x2, [x1, #0x60]
0068D2B84  mov      x0, x19
0068D2B88  ldp      x20, x19, [sp, #0x10]
0068D2B8C  ldp      x30, x21, [sp], #0x20
0068D2B90  br       x2
0068D2B94  ldr      x8, [x1, #0x60]
0068D2B98  mov      x0, x19
0068D2B9C  blr      x8
0068D2BA0  cbz      x0, #0x68d2bec
0068D2BA4  ldr      x8, [x0, #0x128]
0068D2BA8  mov      x0, x19
0068D2BAC  str      x8, [x19, #0x630]
0068D2BB0  adrp     x8, #0x8f28000
0068D2BB4  ldr      x8, [x8, #0x7d8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentMovement>() @ 0x920fef8
0068D2BB8  ldr      x1, [x8]
0068D2BBC  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0068D2BC0  adrp     x8, #0x8f22000
0068D2BC4  ldr      x8, [x8, #0xac0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.AddComponent<CharacterComponentAI>() @ 0x920fe90
0068D2BC8  mov      x0, x19
0068D2BCC  ldr      x1, [x8]
0068D2BD0  bl       #0x42233f4 ; HotFix.BattleLogic.EntityBase<object>$$AddComponent<object>
0068D2BD4  mov      x1, x0
0068D2BD8  add      x0, x19, #0x648
0068D2BDC  str      x1, [x19, #0x648]
0068D2BE0  ldp      x20, x19, [sp, #0x10]
0068D2BE4  ldp      x30, x21, [sp], #0x20
0068D2BE8  b        #0x382bcb8 ; 
0068D2BEC  bl       #0x382bfb8 ; 

