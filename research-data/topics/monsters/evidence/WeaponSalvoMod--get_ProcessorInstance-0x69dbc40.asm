; HotFix.BattleLogic.WeaponSalvoMod$$get_ProcessorInstance
; RVA 0x69DBC40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069DBC40  stp      x30, x21, [sp, #-0x20]!
0069DBC44  stp      x20, x19, [sp, #0x10]
0069DBC48  adrp     x20, #0x959d000
0069DBC4C  adrp     x21, #0x8f31000
0069DBC50  ldrb     w8, [x20, #0x3af]
0069DBC54  ldr      x21, [x21, #0x600] ; GLOBAL Method$HotFix.BattleLogic.WeaponSalvoMod.get_ProcessorInstance()
0069DBC58  mov      x19, x0
0069DBC5C  tbnz     w8, #0, #0x69dbc80
0069DBC60  adrp     x0, #0x8f31000
0069DBC64  ldr      x0, [x0, #0x600] ; GLOBAL Method$HotFix.BattleLogic.WeaponSalvoMod.get_ProcessorInstance()
0069DBC68  bl       #0x382bd14 ; 
0069DBC6C  adrp     x0, #0x8f31000
0069DBC70  ldr      x0, [x0, #0x608] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<SalvoModProcessorProcessor>()
0069DBC74  bl       #0x382bd14 ; 
0069DBC78  mov      w8, #1
0069DBC7C  strb     w8, [x20, #0x3af]
0069DBC80  ldr      x1, [x21]
0069DBC84  ldrb     w8, [x1, #0x53]
0069DBC88  tbnz     w8, #5, #0x69dbcc8
0069DBC8C  adrp     x20, #0x9591000
0069DBC90  ldrb     w8, [x20, #0xa4b]
0069DBC94  cbnz     w8, #0x69dbcac
0069DBC98  adrp     x0, #0x8ee5000
0069DBC9C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069DBCA0  bl       #0x382bd14 ; 
0069DBCA4  mov      w8, #1
0069DBCA8  strb     w8, [x20, #0xa4b]
0069DBCAC  adrp     x8, #0x8ee5000
0069DBCB0  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069DBCB4  ldr      x1, [x8]
0069DBCB8  ldrb     w8, [x1, #0x53]
0069DBCBC  tbnz     w8, #5, #0x69dbcdc
0069DBCC0  ldr      x19, [x19, #0x20]
0069DBCC4  b        #0x69dbcec ; 
0069DBCC8  ldr      x2, [x1, #0x60]
0069DBCCC  mov      x0, x19
0069DBCD0  ldp      x20, x19, [sp, #0x10]
0069DBCD4  ldp      x30, x21, [sp], #0x20
0069DBCD8  br       x2
0069DBCDC  ldr      x8, [x1, #0x60]
0069DBCE0  mov      x0, x19
0069DBCE4  blr      x8
0069DBCE8  mov      x19, x0
0069DBCEC  cbz      x19, #0x69dbd54
0069DBCF0  adrp     x20, #0x9591000
0069DBCF4  ldrb     w8, [x20, #0xa4c]
0069DBCF8  cbnz     w8, #0x69dbd10
0069DBCFC  adrp     x0, #0x8ee5000
0069DBD00  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069DBD04  bl       #0x382bd14 ; 
0069DBD08  mov      w8, #1
0069DBD0C  strb     w8, [x20, #0xa4c]
0069DBD10  adrp     x8, #0x8ee5000
0069DBD14  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069DBD18  ldr      x1, [x8]
0069DBD1C  ldrb     w8, [x1, #0x53]
0069DBD20  tbnz     w8, #5, #0x69dbd2c
0069DBD24  ldr      x0, [x19, #0x210]
0069DBD28  b        #0x69dbd38 ; 
0069DBD2C  ldr      x8, [x1, #0x60]
0069DBD30  mov      x0, x19
0069DBD34  blr      x8
0069DBD38  cbz      x0, #0x69dbd54
0069DBD3C  adrp     x8, #0x8f31000
0069DBD40  ldr      x8, [x8, #0x608] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<SalvoModProcessorProcessor>()
0069DBD44  ldp      x20, x19, [sp, #0x10]
0069DBD48  ldr      x1, [x8]
0069DBD4C  ldp      x30, x21, [sp], #0x20
0069DBD50  b        #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0069DBD54  bl       #0x382bfb8 ; 

