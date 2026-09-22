; HotFix.BattleLogic.AIStateController$$InitBornData
; RVA 0x6B8E478; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8E478  sub      sp, sp, #0x40
006B8E47C  stp      x30, x23, [sp, #0x10]
006B8E480  stp      x22, x21, [sp, #0x20]
006B8E484  stp      x20, x19, [sp, #0x30]
006B8E488  adrp     x22, #0x959f000
006B8E48C  adrp     x23, #0x8f43000
006B8E490  ldrb     w8, [x22, #0xfb5]
006B8E494  ldr      x23, [x23, #0xaa8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.InitBornData()
006B8E498  mov      x21, x2
006B8E49C  mov      w19, w1
006B8E4A0  mov      x20, x0
006B8E4A4  tbnz     w8, #0, #0x6b8e4ec
006B8E4A8  adrp     x0, #0x8f43000
006B8E4AC  ldr      x0, [x0, #0xaa8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.InitBornData()
006B8E4B0  bl       #0x382bd14 ; 
006B8E4B4  adrp     x0, #0x8f43000
006B8E4B8  ldr      x0, [x0, #0xab0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, BornData>.Add()
006B8E4BC  bl       #0x382bd14 ; 
006B8E4C0  adrp     x0, #0x8f43000
006B8E4C4  ldr      x0, [x0, #0xab8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, BornData>.TryGetValue()
006B8E4C8  bl       #0x382bd14 ; 
006B8E4CC  adrp     x0, #0x8f43000
006B8E4D0  ldr      x0, [x0, #0xac0] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<BornData>()
006B8E4D4  bl       #0x382bd14 ; 
006B8E4D8  adrp     x0, #0x8ee2000
006B8E4DC  ldr      x0, [x0, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
006B8E4E0  bl       #0x382bd14 ; 
006B8E4E4  mov      w8, #1
006B8E4E8  strb     w8, [x22, #0xfb5]
006B8E4EC  ldr      x3, [x23]
006B8E4F0  ldrb     w8, [x3, #0x53]
006B8E4F4  tbnz     w8, #5, #0x6b8e548
006B8E4F8  mov      x0, x21
006B8E4FC  mov      x1, xzr
006B8E500  str      xzr, [sp, #8]
006B8E504  bl       #0x79e2368 ; System.String$$IsNullOrEmpty
006B8E508  tbnz     w0, #0, #0x6b8e654
006B8E50C  adrp     x22, #0x9591000
006B8E510  ldrb     w8, [x22, #0xa4b]
006B8E514  cbnz     w8, #0x6b8e52c
006B8E518  adrp     x0, #0x8ee5000
006B8E51C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B8E520  bl       #0x382bd14 ; 
006B8E524  mov      w8, #1
006B8E528  strb     w8, [x22, #0xa4b]
006B8E52C  adrp     x23, #0x8ee5000
006B8E530  ldr      x23, [x23, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B8E534  ldr      x1, [x23]
006B8E538  ldrb     w8, [x1, #0x53]
006B8E53C  tbnz     w8, #5, #0x6b8e56c
006B8E540  ldr      x0, [x20, #0x20]
006B8E544  b        #0x6b8e578 ; 
006B8E548  ldr      x4, [x3, #0x60]
006B8E54C  mov      x0, x20
006B8E550  mov      w1, w19
006B8E554  mov      x2, x21
006B8E558  ldp      x20, x19, [sp, #0x30]
006B8E55C  ldp      x22, x21, [sp, #0x20]
006B8E560  ldp      x30, x23, [sp, #0x10]
006B8E564  add      sp, sp, #0x40
006B8E568  br       x4
006B8E56C  ldr      x8, [x1, #0x60]
006B8E570  mov      x0, x20
006B8E574  blr      x8
006B8E578  cbz      x0, #0x6b8e668
006B8E57C  ldr      x0, [x0, #0x68]
006B8E580  cbz      x0, #0x6b8e668
006B8E584  adrp     x8, #0x8f43000
006B8E588  ldr      x8, [x8, #0xab8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, BornData>.TryGetValue()
006B8E58C  add      x2, sp, #8
006B8E590  mov      w1, w19
006B8E594  ldr      x3, [x8]
006B8E598  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
006B8E59C  tbz      w0, #0, #0x6b8e5b4
006B8E5A0  ldr      x1, [sp, #8]
006B8E5A4  str      x1, [x20, #0x38]!
006B8E5A8  mov      x0, x20
006B8E5AC  bl       #0x382bcb8 ; 
006B8E5B0  b        #0x6b8e654 ; 
006B8E5B4  adrp     x8, #0x8ee2000
006B8E5B8  ldr      x8, [x8, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
006B8E5BC  ldr      x0, [x8]
006B8E5C0  ldr      w8, [x0, #0xe0]
006B8E5C4  cbnz     w8, #0x6b8e5cc
006B8E5C8  bl       #0x382be8c ; 
006B8E5CC  adrp     x8, #0x8f43000
006B8E5D0  ldr      x8, [x8, #0xac0] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<BornData>()
006B8E5D4  mov      x0, x21
006B8E5D8  ldr      x1, [x8]
006B8E5DC  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
006B8E5E0  mov      x21, x20
006B8E5E4  str      x0, [x21, #0x38]!
006B8E5E8  mov      x1, x0
006B8E5EC  mov      x0, x21
006B8E5F0  bl       #0x382bcb8 ; 
006B8E5F4  ldrb     w8, [x22, #0xa4b]
006B8E5F8  cbnz     w8, #0x6b8e610
006B8E5FC  adrp     x0, #0x8ee5000
006B8E600  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B8E604  bl       #0x382bd14 ; 
006B8E608  mov      w8, #1
006B8E60C  strb     w8, [x22, #0xa4b]
006B8E610  ldr      x1, [x23]
006B8E614  ldrb     w8, [x1, #0x53]
006B8E618  tbnz     w8, #5, #0x6b8e624
006B8E61C  ldr      x0, [x20, #0x20]
006B8E620  b        #0x6b8e630 ; 
006B8E624  ldr      x8, [x1, #0x60]
006B8E628  mov      x0, x20
006B8E62C  blr      x8
006B8E630  cbz      x0, #0x6b8e668
006B8E634  ldr      x0, [x0, #0x68]
006B8E638  cbz      x0, #0x6b8e668
006B8E63C  adrp     x8, #0x8f43000
006B8E640  ldr      x2, [x21]
006B8E644  ldr      x8, [x8, #0xab0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, BornData>.Add()
006B8E648  mov      w1, w19
006B8E64C  ldr      x3, [x8]
006B8E650  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
006B8E654  ldp      x20, x19, [sp, #0x30]
006B8E658  ldp      x22, x21, [sp, #0x20]
006B8E65C  ldp      x30, x23, [sp, #0x10]
006B8E660  add      sp, sp, #0x40
006B8E664  ret      
006B8E668  bl       #0x382bfb8 ; 

