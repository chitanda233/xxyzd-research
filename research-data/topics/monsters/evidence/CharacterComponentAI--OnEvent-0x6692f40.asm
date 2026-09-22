; HotFix.BattleLogic.CharacterComponentAI$$OnEvent
; RVA 0x6692F40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692F40  stp      x30, x23, [sp, #-0x30]!
006692F44  stp      x22, x21, [sp, #0x10]
006692F48  stp      x20, x19, [sp, #0x20]
006692F4C  adrp     x22, #0x959a000
006692F50  adrp     x23, #0x8f10000
006692F54  ldrb     w8, [x22, #0x44]
006692F58  ldr      x23, [x23, #0x9f8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnEvent()
006692F5C  mov      x19, x2
006692F60  mov      w21, w1
006692F64  mov      x20, x0
006692F68  tbnz     w8, #0, #0x6692f80
006692F6C  adrp     x0, #0x8f10000
006692F70  ldr      x0, [x0, #0x9f8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnEvent()
006692F74  bl       #0x382bd14 ; 
006692F78  mov      w8, #1
006692F7C  strb     w8, [x22, #0x44]
006692F80  ldr      x3, [x23]
006692F84  ldrb     w8, [x3, #0x53]
006692F88  tbnz     w8, #5, #0x6692fbc
006692F8C  cmp      w21, #2
006692F90  b.le     #0x6692fdc
006692F94  cmp      w21, #3
006692F98  b.eq     #0x6692ffc
006692F9C  cmp      w21, #0xd
006692FA0  b.eq     #0x669300c
006692FA4  cmp      w21, #0x16
006692FA8  b.ne     #0x6693040
006692FAC  ldr      x0, [x20, #0x40]
006692FB0  cbz      x0, #0x6693050
006692FB4  mov      w1, #4
006692FB8  b        #0x6693028 ; 
006692FBC  ldr      x4, [x3, #0x60]
006692FC0  mov      x0, x20
006692FC4  mov      w1, w21
006692FC8  mov      x2, x19
006692FCC  ldp      x20, x19, [sp, #0x20]
006692FD0  ldp      x22, x21, [sp, #0x10]
006692FD4  ldp      x30, x23, [sp], #0x30
006692FD8  br       x4
006692FDC  cmp      w21, #1
006692FE0  b.eq     #0x669301c
006692FE4  cmp      w21, #2
006692FE8  b.ne     #0x6693040
006692FEC  ldr      x0, [x20, #0x40]
006692FF0  cbz      x0, #0x6693050
006692FF4  mov      w1, wzr
006692FF8  b        #0x6693028 ; 
006692FFC  ldr      x0, [x20, #0x40]
006693000  cbz      x0, #0x6693050
006693004  mov      w1, #3
006693008  b        #0x6693028 ; 
00669300C  ldr      x0, [x20, #0x40]
006693010  cbz      x0, #0x6693050
006693014  mov      w1, #5
006693018  b        #0x6693028 ; 
00669301C  ldr      x0, [x20, #0x40]
006693020  cbz      x0, #0x6693050
006693024  mov      w1, #2
006693028  mov      x2, x19
00669302C  ldp      x20, x19, [sp, #0x20]
006693030  ldp      x22, x21, [sp, #0x10]
006693034  mov      x3, xzr
006693038  ldp      x30, x23, [sp], #0x30
00669303C  b        #0x6b918f4 ; HotFix.BattleLogic.AIStateController$$OnEvent
006693040  ldp      x20, x19, [sp, #0x20]
006693044  ldp      x22, x21, [sp, #0x10]
006693048  ldp      x30, x23, [sp], #0x30
00669304C  ret      
006693050  bl       #0x382bfb8 ; 

