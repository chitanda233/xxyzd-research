; HotFix.BattleLogic.AIMoveForward$$SetAIData
; RVA 0x654A9FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654A9FC  str      x30, [sp, #-0x30]!
00654AA00  stp      x22, x21, [sp, #0x10]
00654AA04  stp      x20, x19, [sp, #0x20]
00654AA08  adrp     x21, #0x9598000
00654AA0C  adrp     x22, #0x8f05000
00654AA10  ldrb     w8, [x21, #0xe2e]
00654AA14  ldr      x22, [x22, #0x7a8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveForward.SetAIData()
00654AA18  mov      x19, x1
00654AA1C  mov      x20, x0
00654AA20  tbnz     w8, #0, #0x654aa44
00654AA24  adrp     x0, #0x8f05000
00654AA28  ldr      x0, [x0, #0x7a8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveForward.SetAIData()
00654AA2C  bl       #0x382bd14 ; 
00654AA30  adrp     x0, #0x8f05000
00654AA34  ldr      x0, [x0, #0x790] ; GLOBAL HotFix.BattleLogic.AIMoveForward.Data_TypeInfo
00654AA38  bl       #0x382bd14 ; 
00654AA3C  mov      w8, #1
00654AA40  strb     w8, [x21, #0xe2e]
00654AA44  ldr      x2, [x22]
00654AA48  ldrb     w8, [x2, #0x53]
00654AA4C  tbnz     w8, #5, #0x654aab4
00654AA50  cbz      x19, #0x654aad0
00654AA54  adrp     x8, #0x8f05000
00654AA58  ldr      x8, [x8, #0x790] ; GLOBAL HotFix.BattleLogic.AIMoveForward.Data_TypeInfo
00654AA5C  ldr      x9, [x19]
00654AA60  ldr      x1, [x8]
00654AA64  ldrb     w10, [x9, #0x130]
00654AA68  ldrb     w8, [x1, #0x130]
00654AA6C  cmp      w10, w8
00654AA70  b.lo     #0x654aaec
00654AA74  ldr      x10, [x9, #0xc8]
00654AA78  sub      x9, x8, #1
00654AA7C  ldr      x10, [x10, x9, lsl #3]
00654AA80  cmp      x10, x1
00654AA84  b.ne     #0x654aaec
00654AA88  str      x19, [x20, #0x118]
00654AA8C  ldr      x10, [x19]
00654AA90  ldrb     w11, [x10, #0x130]
00654AA94  cmp      w11, w8
00654AA98  b.lo     #0x654aaec
00654AA9C  ldr      x8, [x10, #0xc8]
00654AAA0  ldr      x8, [x8, x9, lsl #3]
00654AAA4  cmp      x8, x1
00654AAA8  b.ne     #0x654aaec
00654AAAC  add      x0, x20, #0x118
00654AAB0  b        #0x654aad8 ; 
00654AAB4  ldr      x3, [x2, #0x60]
00654AAB8  mov      x0, x20
00654AABC  mov      x1, x19
00654AAC0  ldp      x20, x19, [sp, #0x20]
00654AAC4  ldp      x22, x21, [sp, #0x10]
00654AAC8  ldr      x30, [sp], #0x30
00654AACC  br       x3
00654AAD0  add      x0, x20, #0x118
00654AAD4  str      xzr, [x20, #0x118]
00654AAD8  mov      x1, x19
00654AADC  ldp      x20, x19, [sp, #0x20]
00654AAE0  ldp      x22, x21, [sp, #0x10]
00654AAE4  ldr      x30, [sp], #0x30
00654AAE8  b        #0x382bcb8 ; 
00654AAEC  mov      x0, x19
00654AAF0  bl       #0x382c354 ; 

