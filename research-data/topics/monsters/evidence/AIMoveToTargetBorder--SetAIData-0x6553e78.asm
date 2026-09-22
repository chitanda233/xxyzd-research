; HotFix.BattleLogic.AIMoveToTargetBorder$$SetAIData
; RVA 0x6553E78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006553E78  str      x30, [sp, #-0x30]!
006553E7C  stp      x22, x21, [sp, #0x10]
006553E80  stp      x20, x19, [sp, #0x20]
006553E84  adrp     x21, #0x9598000
006553E88  adrp     x22, #0x8f05000
006553E8C  ldrb     w8, [x21, #0xe99]
006553E90  ldr      x22, [x22, #0xd38] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.SetAIData()
006553E94  mov      x19, x1
006553E98  mov      x20, x0
006553E9C  tbnz     w8, #0, #0x6553ec0
006553EA0  adrp     x0, #0x8f05000
006553EA4  ldr      x0, [x0, #0xd38] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.SetAIData()
006553EA8  bl       #0x382bd14 ; 
006553EAC  adrp     x0, #0x8f05000
006553EB0  ldr      x0, [x0, #0xd18] ; GLOBAL HotFix.BattleLogic.AIMoveToTargetBorder.Data_TypeInfo
006553EB4  bl       #0x382bd14 ; 
006553EB8  mov      w8, #1
006553EBC  strb     w8, [x21, #0xe99]
006553EC0  ldr      x2, [x22]
006553EC4  ldrb     w8, [x2, #0x53]
006553EC8  tbnz     w8, #5, #0x6553f30
006553ECC  cbz      x19, #0x6553f4c
006553ED0  adrp     x8, #0x8f05000
006553ED4  ldr      x8, [x8, #0xd18] ; GLOBAL HotFix.BattleLogic.AIMoveToTargetBorder.Data_TypeInfo
006553ED8  ldr      x9, [x19]
006553EDC  ldr      x1, [x8]
006553EE0  ldrb     w10, [x9, #0x130]
006553EE4  ldrb     w8, [x1, #0x130]
006553EE8  cmp      w10, w8
006553EEC  b.lo     #0x6553f70
006553EF0  ldr      x10, [x9, #0xc8]
006553EF4  sub      x9, x8, #1
006553EF8  ldr      x10, [x10, x9, lsl #3]
006553EFC  cmp      x10, x1
006553F00  b.ne     #0x6553f70
006553F04  str      x19, [x20, #0x118]
006553F08  ldr      x10, [x19]
006553F0C  ldrb     w11, [x10, #0x130]
006553F10  cmp      w11, w8
006553F14  b.lo     #0x6553f70
006553F18  ldr      x8, [x10, #0xc8]
006553F1C  ldr      x8, [x8, x9, lsl #3]
006553F20  cmp      x8, x1
006553F24  b.ne     #0x6553f70
006553F28  add      x0, x20, #0x118
006553F2C  b        #0x6553f54 ; 
006553F30  ldr      x3, [x2, #0x60]
006553F34  mov      x0, x20
006553F38  mov      x1, x19
006553F3C  ldp      x20, x19, [sp, #0x20]
006553F40  ldp      x22, x21, [sp, #0x10]
006553F44  ldr      x30, [sp], #0x30
006553F48  br       x3
006553F4C  add      x0, x20, #0x118
006553F50  str      xzr, [x20, #0x118]
006553F54  mov      x1, x19
006553F58  bl       #0x382bcb8 ; 
006553F5C  mov      x0, x20
006553F60  ldp      x20, x19, [sp, #0x20]
006553F64  ldp      x22, x21, [sp, #0x10]
006553F68  ldr      x30, [sp], #0x30
006553F6C  b        #0x6553d30 ; HotFix.BattleLogic.AIMoveToTargetBorder$$onGetDataParams
006553F70  mov      x0, x19
006553F74  bl       #0x382c354 ; 

