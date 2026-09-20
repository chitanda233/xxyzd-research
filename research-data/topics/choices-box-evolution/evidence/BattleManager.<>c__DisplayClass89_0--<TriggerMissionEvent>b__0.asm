; HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0$$<TriggerMissionEvent>b__0
; RVA 0x6594EA4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006594EA4  stp      x30, x21, [sp, #-0x20]!
006594EA8  stp      x20, x19, [sp, #0x10]
006594EAC  adrp     x20, #0x9599000
006594EB0  adrp     x21, #0x8f08000
006594EB4  ldrb     w8, [x20, #0x2cb]
006594EB8  ldr      x21, [x21, #0x270] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0.<TriggerMissionEvent>b__0() @ 0x92d2d48
006594EBC  mov      x19, x0
006594EC0  tbnz     w8, #0, #0x6594ed8
006594EC4  adrp     x0, #0x8f08000
006594EC8  ldr      x0, [x0, #0x270] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.<>c__DisplayClass89_0.<TriggerMissionEvent>b__0() @ 0x92d2d48
006594ECC  bl       #0x382bd14 ; 
006594ED0  mov      w8, #1
006594ED4  strb     w8, [x20, #0x2cb]
006594ED8  ldr      x1, [x21]
006594EDC  ldrb     w8, [x1, #0x53]
006594EE0  tbnz     w8, #5, #0x6594f28
006594EE4  ldr      w8, [x19, #0x10]
006594EE8  sub      w8, w8, #1
006594EEC  cmp      w8, #7
006594EF0  b.hi     #0x6595010
006594EF4  adrp     x9, #0x1a71000
006594EF8  add      x9, x9, #0xfa1
006594EFC  adr      x10, #0x6594f0c
006594F00  ldrb     w11, [x9, x8]
006594F04  add      x10, x10, x11, lsl #2
006594F08  br       x10
006594F0C  ldr      x0, [x19, #0x18]
006594F10  cbz      x0, #0x659501c
006594F14  ldr      x4, [x19, #0x28]
006594F18  ldrb     w3, [x19, #0x20]
006594F1C  mov      w1, #1
006594F20  mov      w2, #1
006594F24  b        #0x6594fe0 ; 
006594F28  ldr      x2, [x1, #0x60]
006594F2C  mov      x0, x19
006594F30  ldp      x20, x19, [sp, #0x10]
006594F34  ldp      x30, x21, [sp], #0x20
006594F38  br       x2
006594F3C  ldr      x0, [x19, #0x18]
006594F40  cbz      x0, #0x659501c
006594F44  ldr      x4, [x19, #0x28]
006594F48  ldrb     w3, [x19, #0x20]
006594F4C  mov      w1, #1
006594F50  mov      w2, #2
006594F54  b        #0x6594fe0 ; 
006594F58  ldr      x0, [x19, #0x18]
006594F5C  cbz      x0, #0x659501c
006594F60  ldr      x4, [x19, #0x28]
006594F64  ldrb     w3, [x19, #0x20]
006594F68  mov      w1, #3
006594F6C  mov      w2, #3
006594F70  b        #0x6594fe0 ; 
006594F74  ldr      x0, [x19, #0x18]
006594F78  cbz      x0, #0x659501c
006594F7C  ldr      x4, [x19, #0x28]
006594F80  ldrb     w3, [x19, #0x20]
006594F84  mov      w1, #4
006594F88  mov      w2, #4
006594F8C  b        #0x6594fe0 ; 
006594F90  ldr      x0, [x19, #0x18]
006594F94  cbz      x0, #0x659501c
006594F98  ldr      x4, [x19, #0x28]
006594F9C  ldrb     w3, [x19, #0x20]
006594FA0  mov      w1, #5
006594FA4  mov      w2, #5
006594FA8  b        #0x6594fe0 ; 
006594FAC  ldr      x0, [x19, #0x18]
006594FB0  cbz      x0, #0x659501c
006594FB4  ldr      x4, [x19, #0x28]
006594FB8  ldrb     w3, [x19, #0x20]
006594FBC  mov      w1, #6
006594FC0  mov      w2, #6
006594FC4  b        #0x6594fe0 ; 
006594FC8  ldr      x0, [x19, #0x18]
006594FCC  cbz      x0, #0x659501c
006594FD0  ldr      x4, [x19, #0x28]
006594FD4  ldrb     w3, [x19, #0x20]
006594FD8  mov      w1, #7
006594FDC  mov      w2, #7
006594FE0  ldp      x20, x19, [sp, #0x10]
006594FE4  mov      x5, xzr
006594FE8  ldp      x30, x21, [sp], #0x20
006594FEC  b        #0x6592ed0 ; HotFix.BattleLogic.BattleManager$$CreateNpc
006594FF0  ldr      x0, [x19, #0x18]
006594FF4  cbz      x0, #0x659501c
006594FF8  ldr      x1, [x19, #0x28]
006594FFC  mov      x2, xzr
006595000  bl       #0x6592348 ; HotFix.BattleLogic.BattleManager$$CreatePunchboardNpc
006595004  cbz      x0, #0x659501c
006595008  ldr      w8, [x19, #0x30]
00659500C  str      w8, [x0, #0x644]
006595010  ldp      x20, x19, [sp, #0x10]
006595014  ldp      x30, x21, [sp], #0x20
006595018  ret      
00659501C  bl       #0x382bfb8 ; 

