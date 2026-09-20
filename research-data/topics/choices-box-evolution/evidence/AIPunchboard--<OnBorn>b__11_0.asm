; HotFix.BattleLogic.AIPunchboard$$<OnBorn>b__11_0
; RVA 0x6B8ADF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8ADF4  stp      x30, x21, [sp, #-0x20]!
006B8ADF8  stp      x20, x19, [sp, #0x10]
006B8ADFC  adrp     x20, #0x959f000
006B8AE00  adrp     x21, #0x8f43000
006B8AE04  ldrb     w8, [x20, #0xf80]
006B8AE08  ldr      x21, [x21, #0x848] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.<OnBorn>b__11_0() @ 0x92323e0
006B8AE0C  mov      x19, x0
006B8AE10  tbnz     w8, #0, #0x6b8ae28
006B8AE14  adrp     x0, #0x8f43000
006B8AE18  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.<OnBorn>b__11_0() @ 0x92323e0
006B8AE1C  bl       #0x382bd14 ; 
006B8AE20  mov      w8, #1
006B8AE24  strb     w8, [x20, #0xf80]
006B8AE28  ldr      x1, [x21]
006B8AE2C  ldrb     w8, [x1, #0x53]
006B8AE30  tbnz     w8, #5, #0x6b8ae84
006B8AE34  ldr      x8, [x19, #0x118]
006B8AE38  cbz      x8, #0x6b8aeec
006B8AE3C  ldr      w8, [x8, #0x18]
006B8AE40  cmp      w8, #1
006B8AE44  b.lt     #0x6b8ae98
006B8AE48  adrp     x20, #0x9591000
006B8AE4C  ldrb     w8, [x20, #0xa4b]
006B8AE50  cbnz     w8, #0x6b8ae68
006B8AE54  adrp     x0, #0x8ee5000
006B8AE58  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8AE5C  bl       #0x382bd14 ; 
006B8AE60  mov      w8, #1
006B8AE64  strb     w8, [x20, #0xa4b]
006B8AE68  adrp     x8, #0x8ee5000
006B8AE6C  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006B8AE70  ldr      x1, [x8]
006B8AE74  ldrb     w8, [x1, #0x53]
006B8AE78  tbnz     w8, #5, #0x6b8aea4
006B8AE7C  ldr      x0, [x19, #0x20]
006B8AE80  b        #0x6b8aeb0 ; 
006B8AE84  ldr      x2, [x1, #0x60]
006B8AE88  mov      x0, x19
006B8AE8C  ldp      x20, x19, [sp, #0x10]
006B8AE90  ldp      x30, x21, [sp], #0x20
006B8AE94  br       x2
006B8AE98  ldp      x20, x19, [sp, #0x10]
006B8AE9C  ldp      x30, x21, [sp], #0x20
006B8AEA0  ret      
006B8AEA4  ldr      x8, [x1, #0x60]
006B8AEA8  mov      x0, x19
006B8AEAC  blr      x8
006B8AEB0  cbz      x0, #0x6b8aeec
006B8AEB4  mov      x1, xzr
006B8AEB8  bl       #0x69fcf48 ; HotFix.BattleLogic.BattleWorldContext$$CreateGuid
006B8AEBC  ldr      x8, [x19, #0x118]
006B8AEC0  str      x0, [x19, #0x128]
006B8AEC4  cbz      x8, #0x6b8aeec
006B8AEC8  mov      x1, x0
006B8AECC  ldr      x0, [x19, #0x58]
006B8AED0  cbz      x0, #0x6b8aeec
006B8AED4  ldr      w2, [x8, #0x18]
006B8AED8  ldp      x20, x19, [sp, #0x10]
006B8AEDC  mov      w3, #1
006B8AEE0  mov      x4, xzr
006B8AEE4  ldp      x30, x21, [sp], #0x20
006B8AEE8  b        #0x67f57e8 ; HotFix.BattleLogic.EntityCharacter$$AddEffectToBody
006B8AEEC  bl       #0x382bfb8 ; 

