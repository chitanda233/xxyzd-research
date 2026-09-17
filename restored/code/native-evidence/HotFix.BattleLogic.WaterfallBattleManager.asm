; HotFix.BattleLogic.WaterfallBattleManager$$get_CurShowWaveIndex
; RVA 0x65C7558; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C7558  stp      x30, x21, [sp, #-0x20]!
0065C755C  stp      x20, x19, [sp, #0x10]
0065C7560  adrp     x20, #0x9599000
0065C7564  adrp     x21, #0x8f0a000
0065C7568  ldrb     w8, [x20, #0x561]
0065C756C  ldr      x21, [x21, #0x668]
0065C7570  mov      x19, x0
0065C7574  tbnz     w8, #0, #0x65c758c
0065C7578  adrp     x0, #0x8f0a000
0065C757C  ldr      x0, [x0, #0x668]
0065C7580  bl       #0x382bd14 ; 
0065C7584  mov      w8, #1
0065C7588  strb     w8, [x20, #0x561]
0065C758C  ldr      x1, [x21]
0065C7590  ldrb     w8, [x1, #0x53]
0065C7594  tbnz     w8, #5, #0x65c75a8
0065C7598  ldr      w0, [x19, #0x12c]
0065C759C  ldp      x20, x19, [sp, #0x10]
0065C75A0  ldp      x30, x21, [sp], #0x20
0065C75A4  ret      
0065C75A8  ldr      x2, [x1, #0x60]
0065C75AC  mov      x0, x19
0065C75B0  ldp      x20, x19, [sp, #0x10]
0065C75B4  ldp      x30, x21, [sp], #0x20
0065C75B8  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$set_CurShowWaveIndex
; RVA 0x65C75BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C75BC  str      x30, [sp, #-0x30]!
0065C75C0  stp      x22, x21, [sp, #0x10]
0065C75C4  stp      x20, x19, [sp, #0x20]
0065C75C8  adrp     x21, #0x9599000
0065C75CC  adrp     x22, #0x8f0a000
0065C75D0  ldrb     w8, [x21, #0x562]
0065C75D4  ldr      x22, [x22, #0x670]
0065C75D8  mov      w20, w1
0065C75DC  mov      x19, x0
0065C75E0  tbnz     w8, #0, #0x65c75f8
0065C75E4  adrp     x0, #0x8f0a000
0065C75E8  ldr      x0, [x0, #0x670]
0065C75EC  bl       #0x382bd14 ; 
0065C75F0  mov      w8, #1
0065C75F4  strb     w8, [x21, #0x562]
0065C75F8  ldr      x2, [x22]
0065C75FC  ldrb     w8, [x2, #0x53]
0065C7600  tbnz     w8, #5, #0x65c762c
0065C7604  ldr      w8, [x19, #0x12c]
0065C7608  str      w20, [x19, #0x12c]
0065C760C  cmp      w8, w20
0065C7610  b.eq     #0x65c761c
0065C7614  mov      w8, #1
0065C7618  strb     w8, [x19, #0x180]
0065C761C  ldp      x20, x19, [sp, #0x20]
0065C7620  ldp      x22, x21, [sp, #0x10]
0065C7624  ldr      x30, [sp], #0x30
0065C7628  ret      
0065C762C  ldr      x3, [x2, #0x60]
0065C7630  mov      x0, x19
0065C7634  mov      w1, w20
0065C7638  ldp      x20, x19, [sp, #0x20]
0065C763C  ldp      x22, x21, [sp, #0x10]
0065C7640  ldr      x30, [sp], #0x30
0065C7644  br       x3

; HotFix.BattleLogic.WaterfallBattleManager$$get_BattleChapterType
; RVA 0x65C7648; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C7648  stp      x30, x21, [sp, #-0x20]!
0065C764C  stp      x20, x19, [sp, #0x10]
0065C7650  adrp     x20, #0x9599000
0065C7654  adrp     x21, #0x8f0a000
0065C7658  ldrb     w8, [x20, #0x563]
0065C765C  ldr      x21, [x21, #0x678]
0065C7660  mov      x19, x0
0065C7664  tbnz     w8, #0, #0x65c767c
0065C7668  adrp     x0, #0x8f0a000
0065C766C  ldr      x0, [x0, #0x678]
0065C7670  bl       #0x382bd14 ; 
0065C7674  mov      w8, #1
0065C7678  strb     w8, [x20, #0x563]
0065C767C  ldr      x1, [x21]
0065C7680  ldrb     w8, [x1, #0x53]
0065C7684  tbnz     w8, #5, #0x65c7698
0065C7688  ldp      x20, x19, [sp, #0x10]
0065C768C  mov      w0, #7
0065C7690  ldp      x30, x21, [sp], #0x20
0065C7694  ret      
0065C7698  ldr      x2, [x1, #0x60]
0065C769C  mov      x0, x19
0065C76A0  ldp      x20, x19, [sp, #0x10]
0065C76A4  ldp      x30, x21, [sp], #0x20
0065C76A8  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$get_IsInMissileBoostDuration
; RVA 0x65C76AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C76AC  stp      x30, x21, [sp, #-0x20]!
0065C76B0  stp      x20, x19, [sp, #0x10]
0065C76B4  adrp     x20, #0x9599000
0065C76B8  adrp     x21, #0x8f0a000
0065C76BC  ldrb     w8, [x20, #0x564]
0065C76C0  ldr      x21, [x21, #0x680]
0065C76C4  mov      x19, x0
0065C76C8  tbnz     w8, #0, #0x65c76e0
0065C76CC  adrp     x0, #0x8f0a000
0065C76D0  ldr      x0, [x0, #0x680]
0065C76D4  bl       #0x382bd14 ; 
0065C76D8  mov      w8, #1
0065C76DC  strb     w8, [x20, #0x564]
0065C76E0  ldr      x1, [x21]
0065C76E4  ldrb     w8, [x1, #0x53]
0065C76E8  tbnz     w8, #5, #0x65c76fc
0065C76EC  ldrb     w0, [x19, #0x1a4]
0065C76F0  ldp      x20, x19, [sp, #0x10]
0065C76F4  ldp      x30, x21, [sp], #0x20
0065C76F8  ret      
0065C76FC  ldr      x2, [x1, #0x60]
0065C7700  mov      x0, x19
0065C7704  ldp      x20, x19, [sp, #0x10]
0065C7708  ldp      x30, x21, [sp], #0x20
0065C770C  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$get_WaveElapsedTime
; RVA 0x65C7710; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C7710  stp      x30, x21, [sp, #-0x20]!
0065C7714  stp      x20, x19, [sp, #0x10]
0065C7718  adrp     x20, #0x9599000
0065C771C  adrp     x21, #0x8f0a000
0065C7720  ldrb     w8, [x20, #0x565]
0065C7724  ldr      x21, [x21, #0x688]
0065C7728  mov      x19, x0
0065C772C  tbnz     w8, #0, #0x65c7744
0065C7730  adrp     x0, #0x8f0a000
0065C7734  ldr      x0, [x0, #0x688]
0065C7738  bl       #0x382bd14 ; 
0065C773C  mov      w8, #1
0065C7740  strb     w8, [x20, #0x565]
0065C7744  ldr      x1, [x21]
0065C7748  ldrb     w8, [x1, #0x53]
0065C774C  tbnz     w8, #5, #0x65c7760
0065C7750  ldr      x0, [x19, #0x1c0]
0065C7754  ldp      x20, x19, [sp, #0x10]
0065C7758  ldp      x30, x21, [sp], #0x20
0065C775C  ret      
0065C7760  ldr      x2, [x1, #0x60]
0065C7764  mov      x0, x19
0065C7768  ldp      x20, x19, [sp, #0x10]
0065C776C  ldp      x30, x21, [sp], #0x20
0065C7770  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$get_NeedUpLevelCount
; RVA 0x65C7774; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C7774  stp      x30, x21, [sp, #-0x20]!
0065C7778  stp      x20, x19, [sp, #0x10]
0065C777C  adrp     x20, #0x9599000
0065C7780  adrp     x21, #0x8f09000
0065C7784  ldrb     w8, [x20, #0x566]
0065C7788  ldr      x21, [x21, #0xc70]
0065C778C  mov      x19, x0
0065C7790  tbnz     w8, #0, #0x65c77a8
0065C7794  adrp     x0, #0x8f09000
0065C7798  ldr      x0, [x0, #0xc70]
0065C779C  bl       #0x382bd14 ; 
0065C77A0  mov      w8, #1
0065C77A4  strb     w8, [x20, #0x566]
0065C77A8  ldr      x1, [x21]
0065C77AC  ldrb     w8, [x1, #0x53]
0065C77B0  tbnz     w8, #5, #0x65c77c4
0065C77B4  ldr      w0, [x19, #0x1cc]
0065C77B8  ldp      x20, x19, [sp, #0x10]
0065C77BC  ldp      x30, x21, [sp], #0x20
0065C77C0  ret      
0065C77C4  ldr      x2, [x1, #0x60]
0065C77C8  mov      x0, x19
0065C77CC  ldp      x20, x19, [sp, #0x10]
0065C77D0  ldp      x30, x21, [sp], #0x20
0065C77D4  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$RegisterWaveUpdateListener
; RVA 0x65C77D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C77D8  str      x30, [sp, #-0x30]!
0065C77DC  stp      x22, x21, [sp, #0x10]
0065C77E0  stp      x20, x19, [sp, #0x20]
0065C77E4  adrp     x21, #0x9599000
0065C77E8  adrp     x22, #0x8f0a000
0065C77EC  ldrb     w8, [x21, #0x567]
0065C77F0  ldr      x22, [x22, #0x690]
0065C77F4  mov      x19, x1
0065C77F8  mov      x20, x0
0065C77FC  tbnz     w8, #0, #0x65c782c
0065C7800  adrp     x0, #0x8f0a000
0065C7804  ldr      x0, [x0, #0x698]
0065C7808  bl       #0x382bd14 ; 
0065C780C  adrp     x0, #0x8f0a000
0065C7810  ldr      x0, [x0, #0x6a0]
0065C7814  bl       #0x382bd14 ; 
0065C7818  adrp     x0, #0x8f0a000
0065C781C  ldr      x0, [x0, #0x690]
0065C7820  bl       #0x382bd14 ; 
0065C7824  mov      w8, #1
0065C7828  strb     w8, [x21, #0x567]
0065C782C  ldr      x2, [x22]
0065C7830  ldrb     w8, [x2, #0x53]
0065C7834  tbnz     w8, #5, #0x65c7868
0065C7838  ldr      x0, [x20, #0x200]
0065C783C  cbz      x0, #0x65c7904
0065C7840  adrp     x8, #0x8f0a000
0065C7844  ldr      x8, [x8, #0x6a0]
0065C7848  mov      x1, x19
0065C784C  ldr      x2, [x8]
0065C7850  bl       #0x4db01c0 ; System.Collections.Generic.List<object>$$Contains
0065C7854  tbz      w0, #0, #0x65c7884
0065C7858  ldp      x20, x19, [sp, #0x20]
0065C785C  ldp      x22, x21, [sp, #0x10]
0065C7860  ldr      x30, [sp], #0x30
0065C7864  ret      
0065C7868  ldr      x3, [x2, #0x60]
0065C786C  mov      x0, x20
0065C7870  mov      x1, x19
0065C7874  ldp      x20, x19, [sp, #0x20]
0065C7878  ldp      x22, x21, [sp, #0x10]
0065C787C  ldr      x30, [sp], #0x30
0065C7880  br       x3
0065C7884  ldr      x0, [x20, #0x200]
0065C7888  cbz      x0, #0x65c7904
0065C788C  adrp     x9, #0x8f0a000
0065C7890  ldr      x9, [x9, #0x698]
0065C7894  ldr      w10, [x0, #0x1c]
0065C7898  ldr      x8, [x0, #0x10]
0065C789C  ldr      x9, [x9]
0065C78A0  add      w10, w10, #1
0065C78A4  str      w10, [x0, #0x1c]
0065C78A8  cbz      x8, #0x65c7904
0065C78AC  ldrsw    x10, [x0, #0x18]
0065C78B0  ldr      w11, [x8, #0x18]
0065C78B4  cmp      w10, w11
0065C78B8  b.hs     #0x65c78e4
0065C78BC  add      w9, w10, #1
0065C78C0  add      x8, x8, x10, lsl #3
0065C78C4  str      w9, [x0, #0x18]
0065C78C8  str      x19, [x8, #0x20]!
0065C78CC  mov      x1, x19
0065C78D0  ldp      x20, x19, [sp, #0x20]
0065C78D4  ldp      x22, x21, [sp, #0x10]
0065C78D8  mov      x0, x8
0065C78DC  ldr      x30, [sp], #0x30
0065C78E0  b        #0x382bcb8 ; 
0065C78E4  ldr      x8, [x9, #0x20]
0065C78E8  mov      x1, x19
0065C78EC  ldp      x20, x19, [sp, #0x20]
0065C78F0  ldp      x22, x21, [sp, #0x10]
0065C78F4  ldr      x8, [x8, #0xc0]
0065C78F8  ldr      x2, [x8, #0x70]
0065C78FC  ldr      x30, [sp], #0x30
0065C7900  b        #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0065C7904  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$UnregisterWaveUpdateListener
; RVA 0x65C7908; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C7908  str      x30, [sp, #-0x30]!
0065C790C  stp      x22, x21, [sp, #0x10]
0065C7910  stp      x20, x19, [sp, #0x20]
0065C7914  adrp     x21, #0x9599000
0065C7918  adrp     x22, #0x8f0a000
0065C791C  ldrb     w8, [x21, #0x568]
0065C7920  ldr      x22, [x22, #0x6a8]
0065C7924  mov      x19, x1
0065C7928  mov      x20, x0
0065C792C  tbnz     w8, #0, #0x65c7950
0065C7930  adrp     x0, #0x8f0a000
0065C7934  ldr      x0, [x0, #0x6b0]
0065C7938  bl       #0x382bd14 ; 
0065C793C  adrp     x0, #0x8f0a000
0065C7940  ldr      x0, [x0, #0x6a8]
0065C7944  bl       #0x382bd14 ; 
0065C7948  mov      w8, #1
0065C794C  strb     w8, [x21, #0x568]
0065C7950  ldr      x2, [x22]
0065C7954  ldrb     w8, [x2, #0x53]
0065C7958  tbnz     w8, #5, #0x65c7984
0065C795C  ldr      x0, [x20, #0x200]
0065C7960  cbz      x0, #0x65c79a0
0065C7964  adrp     x8, #0x8f0a000
0065C7968  ldr      x8, [x8, #0x6b0]
0065C796C  mov      x1, x19
0065C7970  ldp      x20, x19, [sp, #0x20]
0065C7974  ldp      x22, x21, [sp, #0x10]
0065C7978  ldr      x2, [x8]
0065C797C  ldr      x30, [sp], #0x30
0065C7980  b        #0x4db16c0 ; System.Collections.Generic.List<object>$$Remove
0065C7984  ldr      x3, [x2, #0x60]
0065C7988  mov      x0, x20
0065C798C  mov      x1, x19
0065C7990  ldp      x20, x19, [sp, #0x20]
0065C7994  ldp      x22, x21, [sp, #0x10]
0065C7998  ldr      x30, [sp], #0x30
0065C799C  br       x3
0065C79A0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$OnInit
; RVA 0x65C79A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C79A4  stp      x30, x27, [sp, #-0x50]!
0065C79A8  stp      x26, x25, [sp, #0x10]
0065C79AC  stp      x24, x23, [sp, #0x20]
0065C79B0  stp      x22, x21, [sp, #0x30]
0065C79B4  stp      x20, x19, [sp, #0x40]
0065C79B8  adrp     x20, #0x9599000
0065C79BC  adrp     x21, #0x8f0a000
0065C79C0  ldrb     w8, [x20, #0x569]
0065C79C4  ldr      x21, [x21, #0x6b8]
0065C79C8  mov      x19, x0
0065C79CC  tbnz     w8, #0, #0x65c7aa4
0065C79D0  adrp     x0, #0x8f0a000
0065C79D4  ldr      x0, [x0, #0x68]
0065C79D8  bl       #0x382bd14 ; 
0065C79DC  adrp     x0, #0x8f0a000
0065C79E0  ldr      x0, [x0, #0x6b8]
0065C79E4  bl       #0x382bd14 ; 
0065C79E8  adrp     x0, #0x8f05000
0065C79EC  ldr      x0, [x0, #0xfd0]
0065C79F0  bl       #0x382bd14 ; 
0065C79F4  adrp     x0, #0x8f0a000
0065C79F8  ldr      x0, [x0, #0x6c0]
0065C79FC  bl       #0x382bd14 ; 
0065C7A00  adrp     x0, #0x8f0a000
0065C7A04  ldr      x0, [x0, #0x6c8]
0065C7A08  bl       #0x382bd14 ; 
0065C7A0C  adrp     x0, #0x8f0a000
0065C7A10  ldr      x0, [x0, #0x6d0]
0065C7A14  bl       #0x382bd14 ; 
0065C7A18  adrp     x0, #0x8f0a000
0065C7A1C  ldr      x0, [x0, #0x6d8]
0065C7A20  bl       #0x382bd14 ; 
0065C7A24  adrp     x0, #0x8f0a000
0065C7A28  ldr      x0, [x0, #0x6e0]
0065C7A2C  bl       #0x382bd14 ; 
0065C7A30  adrp     x0, #0x8f0a000
0065C7A34  ldr      x0, [x0, #0x6e8]
0065C7A38  bl       #0x382bd14 ; 
0065C7A3C  adrp     x0, #0x8f0a000
0065C7A40  ldr      x0, [x0, #0x6f0]
0065C7A44  bl       #0x382bd14 ; 
0065C7A48  adrp     x0, #0x8f0a000
0065C7A4C  ldr      x0, [x0, #0x6f8]
0065C7A50  bl       #0x382bd14 ; 
0065C7A54  adrp     x0, #0x8f0a000
0065C7A58  ldr      x0, [x0, #0x700]
0065C7A5C  bl       #0x382bd14 ; 
0065C7A60  adrp     x0, #0x8f0a000
0065C7A64  ldr      x0, [x0, #0x708]
0065C7A68  bl       #0x382bd14 ; 
0065C7A6C  adrp     x0, #0x8f0a000
0065C7A70  ldr      x0, [x0, #0x710]
0065C7A74  bl       #0x382bd14 ; 
0065C7A78  adrp     x0, #0x8f0a000
0065C7A7C  ldr      x0, [x0, #0x718]
0065C7A80  bl       #0x382bd14 ; 
0065C7A84  adrp     x0, #0x8f0a000
0065C7A88  ldr      x0, [x0, #0x720]
0065C7A8C  bl       #0x382bd14 ; 
0065C7A90  adrp     x0, #0x8f0a000
0065C7A94  ldr      x0, [x0, #0x728]
0065C7A98  bl       #0x382bd14 ; 
0065C7A9C  mov      w8, #1
0065C7AA0  strb     w8, [x20, #0x569]
0065C7AA4  ldr      x1, [x21]
0065C7AA8  ldrb     w8, [x1, #0x53]
0065C7AAC  tbnz     w8, #5, #0x65c7b34
0065C7AB0  adrp     x8, #0x8f0a000
0065C7AB4  ldr      x8, [x8, #0x68]
0065C7AB8  adrp     x22, #0x8f05000
0065C7ABC  mov      w1, #0xf
0065C7AC0  ldr      x0, [x8]
0065C7AC4  ldr      x22, [x22, #0xfd0]
0065C7AC8  bl       #0x382bdfc ; 
0065C7ACC  mov      x20, x19
0065C7AD0  str      x0, [x20, #0x10]!
0065C7AD4  mov      x1, x0
0065C7AD8  mov      x0, x20
0065C7ADC  bl       #0x382bcb8 ; 
0065C7AE0  ldr      x0, [x22]
0065C7AE4  ldr      x21, [x20]
0065C7AE8  bl       #0x382bfa0 ; 
0065C7AEC  mov      x1, xzr
0065C7AF0  mov      x22, x0
0065C7AF4  bl       #0x65a8cd4 ; HotFix.BattleLogic.WaterfallInitState$$.ctor
0065C7AF8  adrp     x24, #0x9599000
0065C7AFC  ldrb     w8, [x24, #0x286]
0065C7B00  cbnz     w8, #0x65c7b18
0065C7B04  adrp     x0, #0x8f07000
0065C7B08  ldr      x0, [x0, #0xc98]
0065C7B0C  bl       #0x382bd14 ; 
0065C7B10  mov      w8, #1
0065C7B14  strb     w8, [x24, #0x286]
0065C7B18  adrp     x26, #0x8f07000
0065C7B1C  ldr      x26, [x26, #0xc98]
0065C7B20  ldr      x1, [x26]
0065C7B24  ldrb     w8, [x1, #0x53]
0065C7B28  tbnz     w8, #5, #0x65c7b54
0065C7B2C  ldr      x23, [x19, #0x80]
0065C7B30  b        #0x65c7b64 ; 
0065C7B34  ldr      x2, [x1, #0x60]
0065C7B38  mov      x0, x19
0065C7B3C  ldp      x20, x19, [sp, #0x40]
0065C7B40  ldp      x22, x21, [sp, #0x30]
0065C7B44  ldp      x24, x23, [sp, #0x20]
0065C7B48  ldp      x26, x25, [sp, #0x10]
0065C7B4C  ldp      x30, x27, [sp], #0x50
0065C7B50  br       x2
0065C7B54  ldr      x8, [x1, #0x60]
0065C7B58  mov      x0, x19
0065C7B5C  blr      x8
0065C7B60  mov      x23, x0
0065C7B64  cbz      x22, #0x65c887c
0065C7B68  adrp     x25, #0x9599000
0065C7B6C  ldrb     w8, [x25, #0x4f5]
0065C7B70  cbnz     w8, #0x65c7b88
0065C7B74  adrp     x0, #0x8f09000
0065C7B78  ldr      x0, [x0, #0x1e8]
0065C7B7C  bl       #0x382bd14 ; 
0065C7B80  mov      w8, #1
0065C7B84  strb     w8, [x25, #0x4f5]
0065C7B88  adrp     x27, #0x8f09000
0065C7B8C  ldr      x27, [x27, #0x1e8]
0065C7B90  ldr      x2, [x27]
0065C7B94  ldrb     w8, [x2, #0x53]
0065C7B98  tbnz     w8, #5, #0x65c7bb0
0065C7B9C  mov      x0, x22
0065C7BA0  str      x23, [x0, #0x10]!
0065C7BA4  mov      x1, x23
0065C7BA8  bl       #0x382bcb8 ; 
0065C7BAC  b        #0x65c7bc0 ; 
0065C7BB0  ldr      x8, [x2, #0x60]
0065C7BB4  mov      x0, x22
0065C7BB8  mov      x1, x23
0065C7BBC  blr      x8
0065C7BC0  cbz      x21, #0x65c887c
0065C7BC4  ldr      x8, [x21]
0065C7BC8  mov      x0, x22
0065C7BCC  ldr      x1, [x8, #0x40]
0065C7BD0  bl       #0x382be90 ; 
0065C7BD4  cbz      x0, #0x65c8880
0065C7BD8  ldr      w8, [x21, #0x18]
0065C7BDC  cbz      w8, #0x65c888c
0065C7BE0  str      x22, [x21, #0x20]!
0065C7BE4  mov      x0, x21
0065C7BE8  mov      x1, x22
0065C7BEC  bl       #0x382bcb8 ; 
0065C7BF0  adrp     x8, #0x8f0a000
0065C7BF4  ldr      x21, [x20]
0065C7BF8  ldr      x8, [x8, #0x708]
0065C7BFC  ldr      x0, [x8]
0065C7C00  bl       #0x382bfa0 ; 
0065C7C04  mov      x1, xzr
0065C7C08  mov      x22, x0
0065C7C0C  bl       #0x65b55d4 ; HotFix.BattleLogic.WaterfallStateNpcDrop$$.ctor
0065C7C10  ldrb     w8, [x24, #0x286]
0065C7C14  cbnz     w8, #0x65c7c2c
0065C7C18  adrp     x0, #0x8f07000
0065C7C1C  ldr      x0, [x0, #0xc98]
0065C7C20  bl       #0x382bd14 ; 
0065C7C24  mov      w8, #1
0065C7C28  strb     w8, [x24, #0x286]
0065C7C2C  ldr      x1, [x26]
0065C7C30  ldrb     w8, [x1, #0x53]
0065C7C34  tbnz     w8, #5, #0x65c7c40
0065C7C38  ldr      x23, [x19, #0x80]
0065C7C3C  b        #0x65c7c50 ; 
0065C7C40  ldr      x8, [x1, #0x60]
0065C7C44  mov      x0, x19
0065C7C48  blr      x8
0065C7C4C  mov      x23, x0
0065C7C50  cbz      x22, #0x65c887c
0065C7C54  ldrb     w8, [x25, #0x4f5]
0065C7C58  cbnz     w8, #0x65c7c70
0065C7C5C  adrp     x0, #0x8f09000
0065C7C60  ldr      x0, [x0, #0x1e8]
0065C7C64  bl       #0x382bd14 ; 
0065C7C68  mov      w8, #1
0065C7C6C  strb     w8, [x25, #0x4f5]
0065C7C70  ldr      x2, [x27]
0065C7C74  ldrb     w8, [x2, #0x53]
0065C7C78  tbnz     w8, #5, #0x65c7c90
0065C7C7C  mov      x0, x22
0065C7C80  str      x23, [x0, #0x10]!
0065C7C84  mov      x1, x23
0065C7C88  bl       #0x382bcb8 ; 
0065C7C8C  b        #0x65c7ca0 ; 
0065C7C90  ldr      x8, [x2, #0x60]
0065C7C94  mov      x0, x22
0065C7C98  mov      x1, x23
0065C7C9C  blr      x8
0065C7CA0  cbz      x21, #0x65c887c
0065C7CA4  ldr      x8, [x21]
0065C7CA8  mov      x0, x22
0065C7CAC  ldr      x1, [x8, #0x40]
0065C7CB0  bl       #0x382be90 ; 
0065C7CB4  cbz      x0, #0x65c8880
0065C7CB8  ldr      w8, [x21, #0x18]
0065C7CBC  cmp      w8, #2
0065C7CC0  b.ls     #0x65c888c
0065C7CC4  str      x22, [x21, #0x30]!
0065C7CC8  mov      x0, x21
0065C7CCC  mov      x1, x22
0065C7CD0  bl       #0x382bcb8 ; 
0065C7CD4  adrp     x8, #0x8f0a000
0065C7CD8  ldr      x21, [x20]
0065C7CDC  ldr      x8, [x8, #0x6d0]
0065C7CE0  ldr      x0, [x8]
0065C7CE4  bl       #0x382bfa0 ; 
0065C7CE8  mov      x1, xzr
0065C7CEC  mov      x22, x0
0065C7CF0  bl       #0x65b4f14 ; HotFix.BattleLogic.WaterfallStateBattle$$.ctor
0065C7CF4  ldrb     w8, [x24, #0x286]
0065C7CF8  cbnz     w8, #0x65c7d10
0065C7CFC  adrp     x0, #0x8f07000
0065C7D00  ldr      x0, [x0, #0xc98]
0065C7D04  bl       #0x382bd14 ; 
0065C7D08  mov      w8, #1
0065C7D0C  strb     w8, [x24, #0x286]
0065C7D10  ldr      x1, [x26]
0065C7D14  ldrb     w8, [x1, #0x53]
0065C7D18  tbnz     w8, #5, #0x65c7d24
0065C7D1C  ldr      x23, [x19, #0x80]
0065C7D20  b        #0x65c7d34 ; 
0065C7D24  ldr      x8, [x1, #0x60]
0065C7D28  mov      x0, x19
0065C7D2C  blr      x8
0065C7D30  mov      x23, x0
0065C7D34  cbz      x22, #0x65c887c
0065C7D38  ldrb     w8, [x25, #0x4f5]
0065C7D3C  cbnz     w8, #0x65c7d54
0065C7D40  adrp     x0, #0x8f09000
0065C7D44  ldr      x0, [x0, #0x1e8]
0065C7D48  bl       #0x382bd14 ; 
0065C7D4C  mov      w8, #1
0065C7D50  strb     w8, [x25, #0x4f5]
0065C7D54  ldr      x2, [x27]
0065C7D58  ldrb     w8, [x2, #0x53]
0065C7D5C  tbnz     w8, #5, #0x65c7d74
0065C7D60  mov      x0, x22
0065C7D64  str      x23, [x0, #0x10]!
0065C7D68  mov      x1, x23
0065C7D6C  bl       #0x382bcb8 ; 
0065C7D70  b        #0x65c7d84 ; 
0065C7D74  ldr      x8, [x2, #0x60]
0065C7D78  mov      x0, x22
0065C7D7C  mov      x1, x23
0065C7D80  blr      x8
0065C7D84  cbz      x21, #0x65c887c
0065C7D88  ldr      x8, [x21]
0065C7D8C  mov      x0, x22
0065C7D90  ldr      x1, [x8, #0x40]
0065C7D94  bl       #0x382be90 ; 
0065C7D98  cbz      x0, #0x65c8880
0065C7D9C  ldr      w8, [x21, #0x18]
0065C7DA0  cmp      w8, #1
0065C7DA4  b.ls     #0x65c888c
0065C7DA8  str      x22, [x21, #0x28]!
0065C7DAC  mov      x0, x21
0065C7DB0  mov      x1, x22
0065C7DB4  bl       #0x382bcb8 ; 
0065C7DB8  adrp     x8, #0x8f0a000
0065C7DBC  ldr      x21, [x20]
0065C7DC0  ldr      x8, [x8, #0x728]
0065C7DC4  ldr      x0, [x8]
0065C7DC8  bl       #0x382bfa0 ; 
0065C7DCC  mov      x1, xzr
0065C7DD0  mov      x22, x0
0065C7DD4  bl       #0x65a90f8 ; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$.ctor
0065C7DD8  ldrb     w8, [x24, #0x286]
0065C7DDC  cbnz     w8, #0x65c7df4
0065C7DE0  adrp     x0, #0x8f07000
0065C7DE4  ldr      x0, [x0, #0xc98]
0065C7DE8  bl       #0x382bd14 ; 
0065C7DEC  mov      w8, #1
0065C7DF0  strb     w8, [x24, #0x286]
0065C7DF4  ldr      x1, [x26]
0065C7DF8  ldrb     w8, [x1, #0x53]
0065C7DFC  tbnz     w8, #5, #0x65c7e08
0065C7E00  ldr      x23, [x19, #0x80]
0065C7E04  b        #0x65c7e18 ; 
0065C7E08  ldr      x8, [x1, #0x60]
0065C7E0C  mov      x0, x19
0065C7E10  blr      x8
0065C7E14  mov      x23, x0
0065C7E18  cbz      x22, #0x65c887c
0065C7E1C  ldrb     w8, [x25, #0x4f5]
0065C7E20  cbnz     w8, #0x65c7e38
0065C7E24  adrp     x0, #0x8f09000
0065C7E28  ldr      x0, [x0, #0x1e8]
0065C7E2C  bl       #0x382bd14 ; 
0065C7E30  mov      w8, #1
0065C7E34  strb     w8, [x25, #0x4f5]
0065C7E38  ldr      x2, [x27]
0065C7E3C  ldrb     w8, [x2, #0x53]
0065C7E40  tbnz     w8, #5, #0x65c7e58
0065C7E44  mov      x0, x22
0065C7E48  str      x23, [x0, #0x10]!
0065C7E4C  mov      x1, x23
0065C7E50  bl       #0x382bcb8 ; 
0065C7E54  b        #0x65c7e68 ; 
0065C7E58  ldr      x8, [x2, #0x60]
0065C7E5C  mov      x0, x22
0065C7E60  mov      x1, x23
0065C7E64  blr      x8
0065C7E68  cbz      x21, #0x65c887c
0065C7E6C  ldr      x8, [x21]
0065C7E70  mov      x0, x22
0065C7E74  ldr      x1, [x8, #0x40]
0065C7E78  bl       #0x382be90 ; 
0065C7E7C  cbz      x0, #0x65c8880
0065C7E80  ldr      w8, [x21, #0x18]
0065C7E84  cmp      w8, #0xc
0065C7E88  b.ls     #0x65c888c
0065C7E8C  str      x22, [x21, #0x80]!
0065C7E90  mov      x0, x21
0065C7E94  mov      x1, x22
0065C7E98  bl       #0x382bcb8 ; 
0065C7E9C  adrp     x8, #0x8f0a000
0065C7EA0  ldr      x21, [x20]
0065C7EA4  ldr      x8, [x8, #0x718]
0065C7EA8  ldr      x0, [x8]
0065C7EAC  bl       #0x382bfa0 ; 
0065C7EB0  mov      x1, xzr
0065C7EB4  mov      x22, x0
0065C7EB8  bl       #0x65a8fe0 ; HotFix.BattleLogic.WaterfallStateSelectSkill$$.ctor
0065C7EBC  ldrb     w8, [x24, #0x286]
0065C7EC0  cbnz     w8, #0x65c7ed8
0065C7EC4  adrp     x0, #0x8f07000
0065C7EC8  ldr      x0, [x0, #0xc98]
0065C7ECC  bl       #0x382bd14 ; 
0065C7ED0  mov      w8, #1
0065C7ED4  strb     w8, [x24, #0x286]
0065C7ED8  ldr      x1, [x26]
0065C7EDC  ldrb     w8, [x1, #0x53]
0065C7EE0  tbnz     w8, #5, #0x65c7eec
0065C7EE4  ldr      x23, [x19, #0x80]
0065C7EE8  b        #0x65c7efc ; 
0065C7EEC  ldr      x8, [x1, #0x60]
0065C7EF0  mov      x0, x19
0065C7EF4  blr      x8
0065C7EF8  mov      x23, x0
0065C7EFC  cbz      x22, #0x65c887c
0065C7F00  ldrb     w8, [x25, #0x4f5]
0065C7F04  cbnz     w8, #0x65c7f1c
0065C7F08  adrp     x0, #0x8f09000
0065C7F0C  ldr      x0, [x0, #0x1e8]
0065C7F10  bl       #0x382bd14 ; 
0065C7F14  mov      w8, #1
0065C7F18  strb     w8, [x25, #0x4f5]
0065C7F1C  ldr      x2, [x27]
0065C7F20  ldrb     w8, [x2, #0x53]
0065C7F24  tbnz     w8, #5, #0x65c7f3c
0065C7F28  mov      x0, x22
0065C7F2C  str      x23, [x0, #0x10]!
0065C7F30  mov      x1, x23
0065C7F34  bl       #0x382bcb8 ; 
0065C7F38  b        #0x65c7f4c ; 
0065C7F3C  ldr      x8, [x2, #0x60]
0065C7F40  mov      x0, x22
0065C7F44  mov      x1, x23
0065C7F48  blr      x8
0065C7F4C  cbz      x21, #0x65c887c
0065C7F50  ldr      x8, [x21]
0065C7F54  mov      x0, x22
0065C7F58  ldr      x1, [x8, #0x40]
0065C7F5C  bl       #0x382be90 ; 
0065C7F60  cbz      x0, #0x65c8880
0065C7F64  ldr      w8, [x21, #0x18]
0065C7F68  cmp      w8, #3
0065C7F6C  b.ls     #0x65c888c
0065C7F70  str      x22, [x21, #0x38]!
0065C7F74  mov      x0, x21
0065C7F78  mov      x1, x22
0065C7F7C  bl       #0x382bcb8 ; 
0065C7F80  adrp     x8, #0x8f0a000
0065C7F84  ldr      x21, [x20]
0065C7F88  ldr      x8, [x8, #0x6c8]
0065C7F8C  ldr      x0, [x8]
0065C7F90  bl       #0x382bfa0 ; 
0065C7F94  mov      x1, xzr
0065C7F98  mov      x22, x0
0065C7F9C  bl       #0x65b49d0 ; HotFix.BattleLogic.WaterfallStateAngel$$.ctor
0065C7FA0  ldrb     w8, [x24, #0x286]
0065C7FA4  cbnz     w8, #0x65c7fbc
0065C7FA8  adrp     x0, #0x8f07000
0065C7FAC  ldr      x0, [x0, #0xc98]
0065C7FB0  bl       #0x382bd14 ; 
0065C7FB4  mov      w8, #1
0065C7FB8  strb     w8, [x24, #0x286]
0065C7FBC  ldr      x1, [x26]
0065C7FC0  ldrb     w8, [x1, #0x53]
0065C7FC4  tbnz     w8, #5, #0x65c7fd0
0065C7FC8  ldr      x23, [x19, #0x80]
0065C7FCC  b        #0x65c7fe0 ; 
0065C7FD0  ldr      x8, [x1, #0x60]
0065C7FD4  mov      x0, x19
0065C7FD8  blr      x8
0065C7FDC  mov      x23, x0
0065C7FE0  cbz      x22, #0x65c887c
0065C7FE4  ldrb     w8, [x25, #0x4f5]
0065C7FE8  cbnz     w8, #0x65c8000
0065C7FEC  adrp     x0, #0x8f09000
0065C7FF0  ldr      x0, [x0, #0x1e8]
0065C7FF4  bl       #0x382bd14 ; 
0065C7FF8  mov      w8, #1
0065C7FFC  strb     w8, [x25, #0x4f5]
0065C8000  ldr      x2, [x27]
0065C8004  ldrb     w8, [x2, #0x53]
0065C8008  tbnz     w8, #5, #0x65c8020
0065C800C  mov      x0, x22
0065C8010  str      x23, [x0, #0x10]!
0065C8014  mov      x1, x23
0065C8018  bl       #0x382bcb8 ; 
0065C801C  b        #0x65c8030 ; 
0065C8020  ldr      x8, [x2, #0x60]
0065C8024  mov      x0, x22
0065C8028  mov      x1, x23
0065C802C  blr      x8
0065C8030  cbz      x21, #0x65c887c
0065C8034  ldr      x8, [x21]
0065C8038  mov      x0, x22
0065C803C  ldr      x1, [x8, #0x40]
0065C8040  bl       #0x382be90 ; 
0065C8044  cbz      x0, #0x65c8880
0065C8048  ldr      w8, [x21, #0x18]
0065C804C  cmp      w8, #4
0065C8050  b.ls     #0x65c888c
0065C8054  str      x22, [x21, #0x40]!
0065C8058  mov      x0, x21
0065C805C  mov      x1, x22
0065C8060  bl       #0x382bcb8 ; 
0065C8064  adrp     x8, #0x8f0a000
0065C8068  ldr      x21, [x20]
0065C806C  ldr      x8, [x8, #0x6e0]
0065C8070  ldr      x0, [x8]
0065C8074  bl       #0x382bfa0 ; 
0065C8078  mov      x1, xzr
0065C807C  mov      x22, x0
0065C8080  bl       #0x65b4f78 ; HotFix.BattleLogic.WaterfallStateContractDevil$$.ctor
0065C8084  ldrb     w8, [x24, #0x286]
0065C8088  cbnz     w8, #0x65c80a0
0065C808C  adrp     x0, #0x8f07000
0065C8090  ldr      x0, [x0, #0xc98]
0065C8094  bl       #0x382bd14 ; 
0065C8098  mov      w8, #1
0065C809C  strb     w8, [x24, #0x286]
0065C80A0  ldr      x1, [x26]
0065C80A4  ldrb     w8, [x1, #0x53]
0065C80A8  tbnz     w8, #5, #0x65c80b4
0065C80AC  ldr      x23, [x19, #0x80]
0065C80B0  b        #0x65c80c4 ; 
0065C80B4  ldr      x8, [x1, #0x60]
0065C80B8  mov      x0, x19
0065C80BC  blr      x8
0065C80C0  mov      x23, x0
0065C80C4  cbz      x22, #0x65c887c
0065C80C8  ldrb     w8, [x25, #0x4f5]
0065C80CC  cbnz     w8, #0x65c80e4
0065C80D0  adrp     x0, #0x8f09000
0065C80D4  ldr      x0, [x0, #0x1e8]
0065C80D8  bl       #0x382bd14 ; 
0065C80DC  mov      w8, #1
0065C80E0  strb     w8, [x25, #0x4f5]
0065C80E4  ldr      x2, [x27]
0065C80E8  ldrb     w8, [x2, #0x53]
0065C80EC  tbnz     w8, #5, #0x65c8104
0065C80F0  mov      x0, x22
0065C80F4  str      x23, [x0, #0x10]!
0065C80F8  mov      x1, x23
0065C80FC  bl       #0x382bcb8 ; 
0065C8100  b        #0x65c8114 ; 
0065C8104  ldr      x8, [x2, #0x60]
0065C8108  mov      x0, x22
0065C810C  mov      x1, x23
0065C8110  blr      x8
0065C8114  cbz      x21, #0x65c887c
0065C8118  ldr      x8, [x21]
0065C811C  mov      x0, x22
0065C8120  ldr      x1, [x8, #0x40]
0065C8124  bl       #0x382be90 ; 
0065C8128  cbz      x0, #0x65c8880
0065C812C  ldr      w8, [x21, #0x18]
0065C8130  cmp      w8, #5
0065C8134  b.ls     #0x65c888c
0065C8138  str      x22, [x21, #0x48]!
0065C813C  mov      x0, x21
0065C8140  mov      x1, x22
0065C8144  bl       #0x382bcb8 ; 
0065C8148  adrp     x8, #0x8f0a000
0065C814C  ldr      x21, [x20]
0065C8150  ldr      x8, [x8, #0x6d8]
0065C8154  ldr      x0, [x8]
0065C8158  bl       #0x382bfa0 ; 
0065C815C  mov      x1, xzr
0065C8160  mov      x22, x0
0065C8164  bl       #0x65a8a7c ; HotFix.BattleLogic.WaterfallStateBox$$.ctor
0065C8168  ldrb     w8, [x24, #0x286]
0065C816C  cbnz     w8, #0x65c8184
0065C8170  adrp     x0, #0x8f07000
0065C8174  ldr      x0, [x0, #0xc98]
0065C8178  bl       #0x382bd14 ; 
0065C817C  mov      w8, #1
0065C8180  strb     w8, [x24, #0x286]
0065C8184  ldr      x1, [x26]
0065C8188  ldrb     w8, [x1, #0x53]
0065C818C  tbnz     w8, #5, #0x65c8198
0065C8190  ldr      x23, [x19, #0x80]
0065C8194  b        #0x65c81a8 ; 
0065C8198  ldr      x8, [x1, #0x60]
0065C819C  mov      x0, x19
0065C81A0  blr      x8
0065C81A4  mov      x23, x0
0065C81A8  cbz      x22, #0x65c887c
0065C81AC  ldrb     w8, [x25, #0x4f5]
0065C81B0  cbnz     w8, #0x65c81c8
0065C81B4  adrp     x0, #0x8f09000
0065C81B8  ldr      x0, [x0, #0x1e8]
0065C81BC  bl       #0x382bd14 ; 
0065C81C0  mov      w8, #1
0065C81C4  strb     w8, [x25, #0x4f5]
0065C81C8  ldr      x2, [x27]
0065C81CC  ldrb     w8, [x2, #0x53]
0065C81D0  tbnz     w8, #5, #0x65c81e8
0065C81D4  mov      x0, x22
0065C81D8  str      x23, [x0, #0x10]!
0065C81DC  mov      x1, x23
0065C81E0  bl       #0x382bcb8 ; 
0065C81E4  b        #0x65c81f8 ; 
0065C81E8  ldr      x8, [x2, #0x60]
0065C81EC  mov      x0, x22
0065C81F0  mov      x1, x23
0065C81F4  blr      x8
0065C81F8  cbz      x21, #0x65c887c
0065C81FC  ldr      x8, [x21]
0065C8200  mov      x0, x22
0065C8204  ldr      x1, [x8, #0x40]
0065C8208  bl       #0x382be90 ; 
0065C820C  cbz      x0, #0x65c8880
0065C8210  ldr      w8, [x21, #0x18]
0065C8214  cmp      w8, #6
0065C8218  b.ls     #0x65c888c
0065C821C  str      x22, [x21, #0x50]!
0065C8220  mov      x0, x21
0065C8224  mov      x1, x22
0065C8228  bl       #0x382bcb8 ; 
0065C822C  adrp     x8, #0x8f0a000
0065C8230  ldr      x21, [x20]
0065C8234  ldr      x8, [x8, #0x6f0]
0065C8238  ldr      x0, [x8]
0065C823C  bl       #0x382bfa0 ; 
0065C8240  mov      x1, xzr
0065C8244  mov      x22, x0
0065C8248  bl       #0x65b514c ; HotFix.BattleLogic.WaterfallStateFortune$$.ctor
0065C824C  ldrb     w8, [x24, #0x286]
0065C8250  cbnz     w8, #0x65c8268
0065C8254  adrp     x0, #0x8f07000
0065C8258  ldr      x0, [x0, #0xc98]
0065C825C  bl       #0x382bd14 ; 
0065C8260  mov      w8, #1
0065C8264  strb     w8, [x24, #0x286]
0065C8268  ldr      x1, [x26]
0065C826C  ldrb     w8, [x1, #0x53]
0065C8270  tbnz     w8, #5, #0x65c827c
0065C8274  ldr      x23, [x19, #0x80]
0065C8278  b        #0x65c828c ; 
0065C827C  ldr      x8, [x1, #0x60]
0065C8280  mov      x0, x19
0065C8284  blr      x8
0065C8288  mov      x23, x0
0065C828C  cbz      x22, #0x65c887c
0065C8290  ldrb     w8, [x25, #0x4f5]
0065C8294  cbnz     w8, #0x65c82ac
0065C8298  adrp     x0, #0x8f09000
0065C829C  ldr      x0, [x0, #0x1e8]
0065C82A0  bl       #0x382bd14 ; 
0065C82A4  mov      w8, #1
0065C82A8  strb     w8, [x25, #0x4f5]
0065C82AC  ldr      x2, [x27]
0065C82B0  ldrb     w8, [x2, #0x53]
0065C82B4  tbnz     w8, #5, #0x65c82cc
0065C82B8  mov      x0, x22
0065C82BC  str      x23, [x0, #0x10]!
0065C82C0  mov      x1, x23
0065C82C4  bl       #0x382bcb8 ; 
0065C82C8  b        #0x65c82dc ; 
0065C82CC  ldr      x8, [x2, #0x60]
0065C82D0  mov      x0, x22
0065C82D4  mov      x1, x23
0065C82D8  blr      x8
0065C82DC  cbz      x21, #0x65c887c
0065C82E0  ldr      x8, [x21]
0065C82E4  mov      x0, x22
0065C82E8  ldr      x1, [x8, #0x40]
0065C82EC  bl       #0x382be90 ; 
0065C82F0  cbz      x0, #0x65c8880
0065C82F4  ldr      w8, [x21, #0x18]
0065C82F8  cmp      w8, #7
0065C82FC  b.ls     #0x65c888c
0065C8300  str      x22, [x21, #0x58]!
0065C8304  mov      x0, x21
0065C8308  mov      x1, x22
0065C830C  bl       #0x382bcb8 ; 
0065C8310  adrp     x8, #0x8f0a000
0065C8314  ldr      x21, [x20]
0065C8318  ldr      x8, [x8, #0x6f8]
0065C831C  ldr      x0, [x8]
0065C8320  bl       #0x382bfa0 ; 
0065C8324  mov      x1, xzr
0065C8328  mov      x22, x0
0065C832C  bl       #0x65b51b0 ; HotFix.BattleLogic.WaterfallStateGoldFortune$$.ctor
0065C8330  ldrb     w8, [x24, #0x286]
0065C8334  cbnz     w8, #0x65c834c
0065C8338  adrp     x0, #0x8f07000
0065C833C  ldr      x0, [x0, #0xc98]
0065C8340  bl       #0x382bd14 ; 
0065C8344  mov      w8, #1
0065C8348  strb     w8, [x24, #0x286]
0065C834C  ldr      x1, [x26]
0065C8350  ldrb     w8, [x1, #0x53]
0065C8354  tbnz     w8, #5, #0x65c8360
0065C8358  ldr      x23, [x19, #0x80]
0065C835C  b        #0x65c8370 ; 
0065C8360  ldr      x8, [x1, #0x60]
0065C8364  mov      x0, x19
0065C8368  blr      x8
0065C836C  mov      x23, x0
0065C8370  cbz      x22, #0x65c887c
0065C8374  ldrb     w8, [x25, #0x4f5]
0065C8378  cbnz     w8, #0x65c8390
0065C837C  adrp     x0, #0x8f09000
0065C8380  ldr      x0, [x0, #0x1e8]
0065C8384  bl       #0x382bd14 ; 
0065C8388  mov      w8, #1
0065C838C  strb     w8, [x25, #0x4f5]
0065C8390  ldr      x2, [x27]
0065C8394  ldrb     w8, [x2, #0x53]
0065C8398  tbnz     w8, #5, #0x65c83b0
0065C839C  mov      x0, x22
0065C83A0  str      x23, [x0, #0x10]!
0065C83A4  mov      x1, x23
0065C83A8  bl       #0x382bcb8 ; 
0065C83AC  b        #0x65c83c0 ; 
0065C83B0  ldr      x8, [x2, #0x60]
0065C83B4  mov      x0, x22
0065C83B8  mov      x1, x23
0065C83BC  blr      x8
0065C83C0  cbz      x21, #0x65c887c
0065C83C4  ldr      x8, [x21]
0065C83C8  mov      x0, x22
0065C83CC  ldr      x1, [x8, #0x40]
0065C83D0  bl       #0x382be90 ; 
0065C83D4  cbz      x0, #0x65c8880
0065C83D8  ldr      w8, [x21, #0x18]
0065C83DC  cmp      w8, #9
0065C83E0  b.ls     #0x65c888c
0065C83E4  str      x22, [x21, #0x68]!
0065C83E8  mov      x0, x21
0065C83EC  mov      x1, x22
0065C83F0  bl       #0x382bcb8 ; 
0065C83F4  adrp     x8, #0x8f0a000
0065C83F8  ldr      x21, [x20]
0065C83FC  ldr      x8, [x8, #0x700]
0065C8400  ldr      x0, [x8]
0065C8404  bl       #0x382bfa0 ; 
0065C8408  mov      x1, xzr
0065C840C  mov      x22, x0
0065C8410  bl       #0x65a8c0c ; HotFix.BattleLogic.WaterfallStateHeroDie$$.ctor
0065C8414  ldrb     w8, [x24, #0x286]
0065C8418  cbnz     w8, #0x65c8430
0065C841C  adrp     x0, #0x8f07000
0065C8420  ldr      x0, [x0, #0xc98]
0065C8424  bl       #0x382bd14 ; 
0065C8428  mov      w8, #1
0065C842C  strb     w8, [x24, #0x286]
0065C8430  ldr      x1, [x26]
0065C8434  ldrb     w8, [x1, #0x53]
0065C8438  tbnz     w8, #5, #0x65c8444
0065C843C  ldr      x23, [x19, #0x80]
0065C8440  b        #0x65c8454 ; 
0065C8444  ldr      x8, [x1, #0x60]
0065C8448  mov      x0, x19
0065C844C  blr      x8
0065C8450  mov      x23, x0
0065C8454  cbz      x22, #0x65c887c
0065C8458  ldrb     w8, [x25, #0x4f5]
0065C845C  cbnz     w8, #0x65c8474
0065C8460  adrp     x0, #0x8f09000
0065C8464  ldr      x0, [x0, #0x1e8]
0065C8468  bl       #0x382bd14 ; 
0065C846C  mov      w8, #1
0065C8470  strb     w8, [x25, #0x4f5]
0065C8474  ldr      x2, [x27]
0065C8478  ldrb     w8, [x2, #0x53]
0065C847C  tbnz     w8, #5, #0x65c8494
0065C8480  mov      x0, x22
0065C8484  str      x23, [x0, #0x10]!
0065C8488  mov      x1, x23
0065C848C  bl       #0x382bcb8 ; 
0065C8490  b        #0x65c84a4 ; 
0065C8494  ldr      x8, [x2, #0x60]
0065C8498  mov      x0, x22
0065C849C  mov      x1, x23
0065C84A0  blr      x8
0065C84A4  cbz      x21, #0x65c887c
0065C84A8  ldr      x8, [x21]
0065C84AC  mov      x0, x22
0065C84B0  ldr      x1, [x8, #0x40]
0065C84B4  bl       #0x382be90 ; 
0065C84B8  cbz      x0, #0x65c8880
0065C84BC  ldr      w8, [x21, #0x18]
0065C84C0  cmp      w8, #8
0065C84C4  b.ls     #0x65c888c
0065C84C8  str      x22, [x21, #0x60]!
0065C84CC  mov      x0, x21
0065C84D0  mov      x1, x22
0065C84D4  bl       #0x382bcb8 ; 
0065C84D8  adrp     x8, #0x8f0a000
0065C84DC  ldr      x21, [x20]
0065C84E0  ldr      x8, [x8, #0x720]
0065C84E4  ldr      x0, [x8]
0065C84E8  bl       #0x382bfa0 ; 
0065C84EC  mov      x1, xzr
0065C84F0  mov      x22, x0
0065C84F4  bl       #0x65b7318 ; HotFix.BattleLogic.WaterfallStateSimpleGold$$.ctor
0065C84F8  ldrb     w8, [x24, #0x286]
0065C84FC  cbnz     w8, #0x65c8514
0065C8500  adrp     x0, #0x8f07000
0065C8504  ldr      x0, [x0, #0xc98]
0065C8508  bl       #0x382bd14 ; 
0065C850C  mov      w8, #1
0065C8510  strb     w8, [x24, #0x286]
0065C8514  ldr      x1, [x26]
0065C8518  ldrb     w8, [x1, #0x53]
0065C851C  tbnz     w8, #5, #0x65c8528
0065C8520  ldr      x23, [x19, #0x80]
0065C8524  b        #0x65c8538 ; 
0065C8528  ldr      x8, [x1, #0x60]
0065C852C  mov      x0, x19
0065C8530  blr      x8
0065C8534  mov      x23, x0
0065C8538  cbz      x22, #0x65c887c
0065C853C  ldrb     w8, [x25, #0x4f5]
0065C8540  cbnz     w8, #0x65c8558
0065C8544  adrp     x0, #0x8f09000
0065C8548  ldr      x0, [x0, #0x1e8]
0065C854C  bl       #0x382bd14 ; 
0065C8550  mov      w8, #1
0065C8554  strb     w8, [x25, #0x4f5]
0065C8558  ldr      x2, [x27]
0065C855C  ldrb     w8, [x2, #0x53]
0065C8560  tbnz     w8, #5, #0x65c8578
0065C8564  mov      x0, x22
0065C8568  str      x23, [x0, #0x10]!
0065C856C  mov      x1, x23
0065C8570  bl       #0x382bcb8 ; 
0065C8574  b        #0x65c8588 ; 
0065C8578  ldr      x8, [x2, #0x60]
0065C857C  mov      x0, x22
0065C8580  mov      x1, x23
0065C8584  blr      x8
0065C8588  cbz      x21, #0x65c887c
0065C858C  ldr      x8, [x21]
0065C8590  mov      x0, x22
0065C8594  ldr      x1, [x8, #0x40]
0065C8598  bl       #0x382be90 ; 
0065C859C  cbz      x0, #0x65c8880
0065C85A0  ldr      w8, [x21, #0x18]
0065C85A4  cmp      w8, #0xa
0065C85A8  b.ls     #0x65c888c
0065C85AC  str      x22, [x21, #0x70]!
0065C85B0  mov      x0, x21
0065C85B4  mov      x1, x22
0065C85B8  bl       #0x382bcb8 ; 
0065C85BC  adrp     x8, #0x8f0a000
0065C85C0  ldr      x21, [x20]
0065C85C4  ldr      x8, [x8, #0x710]
0065C85C8  ldr      x0, [x8]
0065C85CC  bl       #0x382bfa0 ; 
0065C85D0  mov      x1, xzr
0065C85D4  mov      x22, x0
0065C85D8  bl       #0x65a8f18 ; HotFix.BattleLogic.WaterfallStatePunchboard$$.ctor
0065C85DC  ldrb     w8, [x24, #0x286]
0065C85E0  cbnz     w8, #0x65c85f8
0065C85E4  adrp     x0, #0x8f07000
0065C85E8  ldr      x0, [x0, #0xc98]
0065C85EC  bl       #0x382bd14 ; 
0065C85F0  mov      w8, #1
0065C85F4  strb     w8, [x24, #0x286]
0065C85F8  ldr      x1, [x26]
0065C85FC  ldrb     w8, [x1, #0x53]
0065C8600  tbnz     w8, #5, #0x65c860c
0065C8604  ldr      x23, [x19, #0x80]
0065C8608  b        #0x65c861c ; 
0065C860C  ldr      x8, [x1, #0x60]
0065C8610  mov      x0, x19
0065C8614  blr      x8
0065C8618  mov      x23, x0
0065C861C  cbz      x22, #0x65c887c
0065C8620  ldrb     w8, [x25, #0x4f5]
0065C8624  cbnz     w8, #0x65c863c
0065C8628  adrp     x0, #0x8f09000
0065C862C  ldr      x0, [x0, #0x1e8]
0065C8630  bl       #0x382bd14 ; 
0065C8634  mov      w8, #1
0065C8638  strb     w8, [x25, #0x4f5]
0065C863C  ldr      x2, [x27]
0065C8640  ldrb     w8, [x2, #0x53]
0065C8644  tbnz     w8, #5, #0x65c865c
0065C8648  mov      x0, x22
0065C864C  str      x23, [x0, #0x10]!
0065C8650  mov      x1, x23
0065C8654  bl       #0x382bcb8 ; 
0065C8658  b        #0x65c866c ; 
0065C865C  ldr      x8, [x2, #0x60]
0065C8660  mov      x0, x22
0065C8664  mov      x1, x23
0065C8668  blr      x8
0065C866C  cbz      x21, #0x65c887c
0065C8670  ldr      x8, [x21]
0065C8674  mov      x0, x22
0065C8678  ldr      x1, [x8, #0x40]
0065C867C  bl       #0x382be90 ; 
0065C8680  cbz      x0, #0x65c8880
0065C8684  ldr      w8, [x21, #0x18]
0065C8688  cmp      w8, #0xb
0065C868C  b.ls     #0x65c888c
0065C8690  str      x22, [x21, #0x78]!
0065C8694  mov      x0, x21
0065C8698  mov      x1, x22
0065C869C  bl       #0x382bcb8 ; 
0065C86A0  adrp     x8, #0x8f0a000
0065C86A4  ldr      x21, [x20]
0065C86A8  ldr      x8, [x8, #0x6c0]
0065C86AC  ldr      x0, [x8]
0065C86B0  bl       #0x382bfa0 ; 
0065C86B4  mov      x1, xzr
0065C86B8  mov      x22, x0
0065C86BC  bl       #0x65b496c ; HotFix.BattleLogic.WaterfallSpecialEndState$$.ctor
0065C86C0  ldrb     w8, [x24, #0x286]
0065C86C4  cbnz     w8, #0x65c86dc
0065C86C8  adrp     x0, #0x8f07000
0065C86CC  ldr      x0, [x0, #0xc98]
0065C86D0  bl       #0x382bd14 ; 
0065C86D4  mov      w8, #1
0065C86D8  strb     w8, [x24, #0x286]
0065C86DC  ldr      x1, [x26]
0065C86E0  ldrb     w8, [x1, #0x53]
0065C86E4  tbnz     w8, #5, #0x65c86f0
0065C86E8  ldr      x23, [x19, #0x80]
0065C86EC  b        #0x65c8700 ; 
0065C86F0  ldr      x8, [x1, #0x60]
0065C86F4  mov      x0, x19
0065C86F8  blr      x8
0065C86FC  mov      x23, x0
0065C8700  cbz      x22, #0x65c887c
0065C8704  ldrb     w8, [x25, #0x4f5]
0065C8708  cbnz     w8, #0x65c8720
0065C870C  adrp     x0, #0x8f09000
0065C8710  ldr      x0, [x0, #0x1e8]
0065C8714  bl       #0x382bd14 ; 
0065C8718  mov      w8, #1
0065C871C  strb     w8, [x25, #0x4f5]
0065C8720  ldr      x2, [x27]
0065C8724  ldrb     w8, [x2, #0x53]
0065C8728  tbnz     w8, #5, #0x65c8740
0065C872C  mov      x0, x22
0065C8730  str      x23, [x0, #0x10]!
0065C8734  mov      x1, x23
0065C8738  bl       #0x382bcb8 ; 
0065C873C  b        #0x65c8750 ; 
0065C8740  ldr      x8, [x2, #0x60]
0065C8744  mov      x0, x22
0065C8748  mov      x1, x23
0065C874C  blr      x8
0065C8750  cbz      x21, #0x65c887c
0065C8754  ldr      x8, [x21]
0065C8758  mov      x0, x22
0065C875C  ldr      x1, [x8, #0x40]
0065C8760  bl       #0x382be90 ; 
0065C8764  cbz      x0, #0x65c8880
0065C8768  ldr      w8, [x21, #0x18]
0065C876C  cmp      w8, #0xd
0065C8770  b.ls     #0x65c888c
0065C8774  str      x22, [x21, #0x88]!
0065C8778  mov      x0, x21
0065C877C  mov      x1, x22
0065C8780  bl       #0x382bcb8 ; 
0065C8784  adrp     x8, #0x8f0a000
0065C8788  ldr      x20, [x20]
0065C878C  ldr      x8, [x8, #0x6e8]
0065C8790  ldr      x0, [x8]
0065C8794  bl       #0x382bfa0 ; 
0065C8798  mov      x1, xzr
0065C879C  mov      x21, x0
0065C87A0  bl       #0x65a8b44 ; HotFix.BattleLogic.WaterfallStateEnd$$.ctor
0065C87A4  ldrb     w8, [x24, #0x286]
0065C87A8  cbnz     w8, #0x65c87c0
0065C87AC  adrp     x0, #0x8f07000
0065C87B0  ldr      x0, [x0, #0xc98]
0065C87B4  bl       #0x382bd14 ; 
0065C87B8  mov      w8, #1
0065C87BC  strb     w8, [x24, #0x286]
0065C87C0  ldr      x1, [x26]
0065C87C4  ldrb     w8, [x1, #0x53]
0065C87C8  tbnz     w8, #5, #0x65c87d4
0065C87CC  ldr      x19, [x19, #0x80]
0065C87D0  b        #0x65c87e4 ; 
0065C87D4  ldr      x8, [x1, #0x60]
0065C87D8  mov      x0, x19
0065C87DC  blr      x8
0065C87E0  mov      x19, x0
0065C87E4  cbz      x21, #0x65c887c
0065C87E8  ldrb     w8, [x25, #0x4f5]
0065C87EC  cbnz     w8, #0x65c8804
0065C87F0  adrp     x0, #0x8f09000
0065C87F4  ldr      x0, [x0, #0x1e8]
0065C87F8  bl       #0x382bd14 ; 
0065C87FC  mov      w8, #1
0065C8800  strb     w8, [x25, #0x4f5]
0065C8804  ldr      x2, [x27]
0065C8808  ldrb     w8, [x2, #0x53]
0065C880C  tbnz     w8, #5, #0x65c8824
0065C8810  mov      x0, x21
0065C8814  str      x19, [x0, #0x10]!
0065C8818  mov      x1, x19
0065C881C  bl       #0x382bcb8 ; 
0065C8820  b        #0x65c8834 ; 
0065C8824  ldr      x8, [x2, #0x60]
0065C8828  mov      x0, x21
0065C882C  mov      x1, x19
0065C8830  blr      x8
0065C8834  cbz      x20, #0x65c887c
0065C8838  ldr      x8, [x20]
0065C883C  mov      x0, x21
0065C8840  ldr      x1, [x8, #0x40]
0065C8844  bl       #0x382be90 ; 
0065C8848  cbz      x0, #0x65c8880
0065C884C  ldr      w8, [x20, #0x18]
0065C8850  cmp      w8, #0xe
0065C8854  b.ls     #0x65c888c
0065C8858  str      x21, [x20, #0x90]!
0065C885C  mov      x0, x20
0065C8860  mov      x1, x21
0065C8864  ldp      x20, x19, [sp, #0x40]
0065C8868  ldp      x22, x21, [sp, #0x30]
0065C886C  ldp      x24, x23, [sp, #0x20]
0065C8870  ldp      x26, x25, [sp, #0x10]
0065C8874  ldp      x30, x27, [sp], #0x50
0065C8878  b        #0x382bcb8 ; 
0065C887C  bl       #0x382bfb8 ; 
0065C8880  bl       #0x382bfdc ; 
0065C8884  mov      x1, xzr
0065C8888  bl       #0x382be7c ; 
0065C888C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$AddUpLevel
; RVA 0x65C8890; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8890  stp      x30, x21, [sp, #-0x20]!
0065C8894  stp      x20, x19, [sp, #0x10]
0065C8898  adrp     x20, #0x9599000
0065C889C  adrp     x21, #0x8f0a000
0065C88A0  ldrb     w8, [x20, #0x56a]
0065C88A4  ldr      x21, [x21, #0x730]
0065C88A8  mov      x19, x0
0065C88AC  tbnz     w8, #0, #0x65c88c4
0065C88B0  adrp     x0, #0x8f0a000
0065C88B4  ldr      x0, [x0, #0x730]
0065C88B8  bl       #0x382bd14 ; 
0065C88BC  mov      w8, #1
0065C88C0  strb     w8, [x20, #0x56a]
0065C88C4  ldr      x1, [x21]
0065C88C8  ldrb     w8, [x1, #0x53]
0065C88CC  tbnz     w8, #5, #0x65c88e8
0065C88D0  ldr      w8, [x19, #0x1cc]
0065C88D4  add      w8, w8, #1
0065C88D8  str      w8, [x19, #0x1cc]
0065C88DC  ldp      x20, x19, [sp, #0x10]
0065C88E0  ldp      x30, x21, [sp], #0x20
0065C88E4  ret      
0065C88E8  ldr      x2, [x1, #0x60]
0065C88EC  mov      x0, x19
0065C88F0  ldp      x20, x19, [sp, #0x10]
0065C88F4  ldp      x30, x21, [sp], #0x20
0065C88F8  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$DelUpLevel
; RVA 0x65C88FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C88FC  stp      x30, x21, [sp, #-0x20]!
0065C8900  stp      x20, x19, [sp, #0x10]
0065C8904  adrp     x20, #0x9599000
0065C8908  adrp     x21, #0x8f0a000
0065C890C  ldrb     w8, [x20, #0x56b]
0065C8910  ldr      x21, [x21, #0x738]
0065C8914  mov      x19, x0
0065C8918  tbnz     w8, #0, #0x65c8930
0065C891C  adrp     x0, #0x8f0a000
0065C8920  ldr      x0, [x0, #0x738]
0065C8924  bl       #0x382bd14 ; 
0065C8928  mov      w8, #1
0065C892C  strb     w8, [x20, #0x56b]
0065C8930  ldr      x1, [x21]
0065C8934  ldrb     w8, [x1, #0x53]
0065C8938  tbnz     w8, #5, #0x65c8964
0065C893C  ldr      w8, [x19, #0x1cc]
0065C8940  subs     w8, w8, #1
0065C8944  b.lt     #0x65c8958
0065C8948  ldr      w9, [x19, #0x1c8]
0065C894C  str      w8, [x19, #0x1cc]
0065C8950  add      w8, w9, #1
0065C8954  str      w8, [x19, #0x1c8]
0065C8958  ldp      x20, x19, [sp, #0x10]
0065C895C  ldp      x30, x21, [sp], #0x20
0065C8960  ret      
0065C8964  ldr      x2, [x1, #0x60]
0065C8968  mov      x0, x19
0065C896C  ldp      x20, x19, [sp, #0x10]
0065C8970  ldp      x30, x21, [sp], #0x20
0065C8974  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$ShouldApplyLevelOnSelectSkillEnter
; RVA 0x65C8978; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8978  stp      x30, x21, [sp, #-0x20]!
0065C897C  stp      x20, x19, [sp, #0x10]
0065C8980  adrp     x20, #0x9599000
0065C8984  adrp     x21, #0x8f0a000
0065C8988  ldrb     w8, [x20, #0x56c]
0065C898C  ldr      x21, [x21, #0x740]
0065C8990  mov      x19, x0
0065C8994  tbnz     w8, #0, #0x65c89ac
0065C8998  adrp     x0, #0x8f0a000
0065C899C  ldr      x0, [x0, #0x740]
0065C89A0  bl       #0x382bd14 ; 
0065C89A4  mov      w8, #1
0065C89A8  strb     w8, [x20, #0x56c]
0065C89AC  ldr      x1, [x21]
0065C89B0  ldrb     w8, [x1, #0x53]
0065C89B4  tbnz     w8, #5, #0x65c89d4
0065C89B8  ldr      w8, [x19, #0x1d0]
0065C89BC  cmp      w8, #1
0065C89C0  b.ne     #0x65c89e8
0065C89C4  mov      w8, #2
0065C89C8  mov      w0, #1
0065C89CC  str      w8, [x19, #0x1d0]
0065C89D0  b        #0x65c89f4 ; 
0065C89D4  ldr      x2, [x1, #0x60]
0065C89D8  mov      x0, x19
0065C89DC  ldp      x20, x19, [sp, #0x10]
0065C89E0  ldp      x30, x21, [sp], #0x20
0065C89E4  br       x2
0065C89E8  and      w8, w8, #0xfffffffe
0065C89EC  cmp      w8, #2
0065C89F0  cset     w0, ne
0065C89F4  ldp      x20, x19, [sp, #0x10]
0065C89F8  ldp      x30, x21, [sp], #0x20
0065C89FC  ret      

; HotFix.BattleLogic.WaterfallBattleManager$$MarkWaveEndSelectSkillFinished
; RVA 0x65C8A00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8A00  stp      x30, x21, [sp, #-0x20]!
0065C8A04  stp      x20, x19, [sp, #0x10]
0065C8A08  adrp     x20, #0x9599000
0065C8A0C  adrp     x21, #0x8f0a000
0065C8A10  ldrb     w8, [x20, #0x56d]
0065C8A14  ldr      x21, [x21, #0x748]
0065C8A18  mov      x19, x0
0065C8A1C  tbnz     w8, #0, #0x65c8a34
0065C8A20  adrp     x0, #0x8f0a000
0065C8A24  ldr      x0, [x0, #0x748]
0065C8A28  bl       #0x382bd14 ; 
0065C8A2C  mov      w8, #1
0065C8A30  strb     w8, [x20, #0x56d]
0065C8A34  ldr      x1, [x21]
0065C8A38  ldrb     w8, [x1, #0x53]
0065C8A3C  tbnz     w8, #5, #0x65c8a64
0065C8A40  ldr      w8, [x19, #0x1d0]
0065C8A44  cmp      w8, #2
0065C8A48  b.ne     #0x65c8a78
0065C8A4C  mov      w8, #3
0065C8A50  mov      x0, x19
0065C8A54  str      w8, [x19, #0x1d0]
0065C8A58  bl       #0x65c88fc ; HotFix.BattleLogic.WaterfallBattleManager$$DelUpLevel
0065C8A5C  mov      w0, #1
0065C8A60  b        #0x65c8a7c ; 
0065C8A64  ldr      x2, [x1, #0x60]
0065C8A68  mov      x0, x19
0065C8A6C  ldp      x20, x19, [sp, #0x10]
0065C8A70  ldp      x30, x21, [sp], #0x20
0065C8A74  br       x2
0065C8A78  mov      w0, wzr
0065C8A7C  ldp      x20, x19, [sp, #0x10]
0065C8A80  ldp      x30, x21, [sp], #0x20
0065C8A84  ret      

; HotFix.BattleLogic.WaterfallBattleManager$$OnWaveEndSelectSkillExit
; RVA 0x65C8A88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8A88  stp      x30, x23, [sp, #-0x30]!
0065C8A8C  stp      x22, x21, [sp, #0x10]
0065C8A90  stp      x20, x19, [sp, #0x20]
0065C8A94  adrp     x22, #0x9599000
0065C8A98  adrp     x23, #0x8f0a000
0065C8A9C  ldrb     w8, [x22, #0x56e]
0065C8AA0  ldr      x23, [x23, #0x750]
0065C8AA4  mov      w20, w2
0065C8AA8  mov      w21, w1
0065C8AAC  mov      x19, x0
0065C8AB0  tbnz     w8, #0, #0x65c8ac8
0065C8AB4  adrp     x0, #0x8f0a000
0065C8AB8  ldr      x0, [x0, #0x750]
0065C8ABC  bl       #0x382bd14 ; 
0065C8AC0  mov      w8, #1
0065C8AC4  strb     w8, [x22, #0x56e]
0065C8AC8  ldr      x3, [x23]
0065C8ACC  ldrb     w8, [x3, #0x53]
0065C8AD0  tbnz     w8, #5, #0x65c8b08
0065C8AD4  cmp      w20, #1
0065C8AD8  cset     w8, eq
0065C8ADC  and      w8, w8, w21
0065C8AE0  tbnz     w8, #0, #0x65c8af8
0065C8AE4  cmp      w20, #8
0065C8AE8  b.eq     #0x65c8af8
0065C8AEC  ldr      w8, [x19, #0x1d0]
0065C8AF0  cbz      w8, #0x65c8af8
0065C8AF4  str      wzr, [x19, #0x1d0]
0065C8AF8  ldp      x20, x19, [sp, #0x20]
0065C8AFC  ldp      x22, x21, [sp, #0x10]
0065C8B00  ldp      x30, x23, [sp], #0x30
0065C8B04  ret      
0065C8B08  ldr      x4, [x3, #0x60]
0065C8B0C  and      w1, w21, #1
0065C8B10  mov      x0, x19
0065C8B14  mov      w2, w20
0065C8B18  ldp      x20, x19, [sp, #0x20]
0065C8B1C  ldp      x22, x21, [sp, #0x10]
0065C8B20  ldp      x30, x23, [sp], #0x30
0065C8B24  br       x4

; HotFix.BattleLogic.WaterfallBattleManager$$TryContinueWaveEndUpLevelAfterSelection
; RVA 0x65C8B28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8B28  stp      x30, x21, [sp, #-0x20]!
0065C8B2C  stp      x20, x19, [sp, #0x10]
0065C8B30  adrp     x20, #0x9599000
0065C8B34  adrp     x21, #0x8f0a000
0065C8B38  ldrb     w8, [x20, #0x56f]
0065C8B3C  ldr      x21, [x21, #0x758]
0065C8B40  mov      x19, x0
0065C8B44  tbnz     w8, #0, #0x65c8b68
0065C8B48  adrp     x0, #0x8f07000
0065C8B4C  ldr      x0, [x0, #0xe68]
0065C8B50  bl       #0x382bd14 ; 
0065C8B54  adrp     x0, #0x8f0a000
0065C8B58  ldr      x0, [x0, #0x758]
0065C8B5C  bl       #0x382bd14 ; 
0065C8B60  mov      w8, #1
0065C8B64  strb     w8, [x20, #0x56f]
0065C8B68  ldr      x1, [x21]
0065C8B6C  ldrb     w8, [x1, #0x53]
0065C8B70  tbnz     w8, #5, #0x65c8bcc
0065C8B74  ldr      w8, [x19, #0x1d0]
0065C8B78  cmp      w8, #3
0065C8B7C  b.ne     #0x65c8be0
0065C8B80  ldr      x0, [x19, #0x88]
0065C8B84  str      wzr, [x19, #0x1d0]
0065C8B88  cbz      x0, #0x65c8c10
0065C8B8C  adrp     x8, #0x8f07000
0065C8B90  ldr      x8, [x8, #0xe68]
0065C8B94  ldr      x1, [x8]
0065C8B98  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065C8B9C  cbz      x0, #0x65c8c10
0065C8BA0  mov      x1, xzr
0065C8BA4  bl       #0x6870404 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckNeedOpenSpecialSkill
0065C8BA8  tbz      w0, #0, #0x65c8be8
0065C8BAC  mov      w1, #0xc
0065C8BB0  mov      w3, #1
0065C8BB4  mov      x0, x19
0065C8BB8  mov      x2, xzr
0065C8BBC  mov      x4, xzr
0065C8BC0  mov      w20, #1
0065C8BC4  bl       #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
0065C8BC8  b        #0x65c8c00 ; 
0065C8BCC  ldr      x2, [x1, #0x60]
0065C8BD0  mov      x0, x19
0065C8BD4  ldp      x20, x19, [sp, #0x10]
0065C8BD8  ldp      x30, x21, [sp], #0x20
0065C8BDC  br       x2
0065C8BE0  mov      w20, wzr
0065C8BE4  b        #0x65c8c00 ; 
0065C8BE8  ldr      x8, [x19]
0065C8BEC  mov      x0, x19
0065C8BF0  ldr      x9, [x8, #0x288]
0065C8BF4  ldr      x1, [x8, #0x290]
0065C8BF8  blr      x9
0065C8BFC  mov      w20, #1
0065C8C00  mov      w0, w20
0065C8C04  ldp      x20, x19, [sp, #0x10]
0065C8C08  ldp      x30, x21, [sp], #0x20
0065C8C0C  ret      
0065C8C10  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$TryResumeWaveEndUpLevelProgress
; RVA 0x65C8C14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8C14  stp      x30, x21, [sp, #-0x20]!
0065C8C18  stp      x20, x19, [sp, #0x10]
0065C8C1C  adrp     x20, #0x9599000
0065C8C20  adrp     x21, #0x8f0a000
0065C8C24  ldrb     w8, [x20, #0x570]
0065C8C28  ldr      x21, [x21, #0x760]
0065C8C2C  mov      x19, x0
0065C8C30  tbnz     w8, #0, #0x65c8c48
0065C8C34  adrp     x0, #0x8f0a000
0065C8C38  ldr      x0, [x0, #0x760]
0065C8C3C  bl       #0x382bd14 ; 
0065C8C40  mov      w8, #1
0065C8C44  strb     w8, [x20, #0x570]
0065C8C48  ldr      x1, [x21]
0065C8C4C  ldrb     w8, [x1, #0x53]
0065C8C50  tbnz     w8, #5, #0x65c8ca0
0065C8C54  mov      x0, x19
0065C8C58  mov      x1, xzr
0065C8C5C  bl       #0x6587334 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_IsStateWaveShowEnd
0065C8C60  tbz      w0, #0, #0x65c8cb4
0065C8C64  mov      x0, x19
0065C8C68  bl       #0x65c8cd0 ; HotFix.BattleLogic.WaterfallBattleManager$$IsCurrentUpLevelUI
0065C8C6C  tbz      w0, #0, #0x65c8cb4
0065C8C70  ldrb     w8, [x19, #0x1d4]
0065C8C74  cbnz     w8, #0x65c8cb4
0065C8C78  mov      x0, x19
0065C8C7C  bl       #0x65c8d70 ; HotFix.BattleLogic.WaterfallBattleManager$$CanRunUpLevelProgress
0065C8C80  tbz      w0, #0, #0x65c8cb4
0065C8C84  ldr      w8, [x19, #0x1d0]
0065C8C88  cmp      w8, #3
0065C8C8C  b.ne     #0x65c8cc0
0065C8C90  mov      x0, x19
0065C8C94  ldp      x20, x19, [sp, #0x10]
0065C8C98  ldp      x30, x21, [sp], #0x20
0065C8C9C  b        #0x65c8b28 ; HotFix.BattleLogic.WaterfallBattleManager$$TryContinueWaveEndUpLevelAfterSelection
0065C8CA0  ldr      x2, [x1, #0x60]
0065C8CA4  mov      x0, x19
0065C8CA8  ldp      x20, x19, [sp, #0x10]
0065C8CAC  ldp      x30, x21, [sp], #0x20
0065C8CB0  br       x2
0065C8CB4  ldp      x20, x19, [sp, #0x10]
0065C8CB8  ldp      x30, x21, [sp], #0x20
0065C8CBC  ret      
0065C8CC0  ldr      x8, [x19]
0065C8CC4  ldr      x2, [x8, #0x288]
0065C8CC8  ldr      x1, [x8, #0x290]
0065C8CCC  b        #0x65c8ca4 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$IsCurrentUpLevelUI
; RVA 0x65C8CD0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8CD0  stp      x30, x21, [sp, #-0x20]!
0065C8CD4  stp      x20, x19, [sp, #0x10]
0065C8CD8  adrp     x20, #0x9599000
0065C8CDC  adrp     x21, #0x8f0a000
0065C8CE0  ldrb     w8, [x20, #0x571]
0065C8CE4  ldr      x21, [x21, #0x768]
0065C8CE8  mov      x19, x0
0065C8CEC  tbnz     w8, #0, #0x65c8d04
0065C8CF0  adrp     x0, #0x8f0a000
0065C8CF4  ldr      x0, [x0, #0x768]
0065C8CF8  bl       #0x382bd14 ; 
0065C8CFC  mov      w8, #1
0065C8D00  strb     w8, [x20, #0x571]
0065C8D04  ldr      x1, [x21]
0065C8D08  ldrb     w8, [x1, #0x53]
0065C8D0C  tbnz     w8, #5, #0x65c8d48
0065C8D10  ldr      x8, [x19, #0x1e8]
0065C8D14  cbz      x8, #0x65c8d5c
0065C8D18  ldr      w9, [x19, #0x198]
0065C8D1C  tbnz     w9, #0x1f, #0x65c8d5c
0065C8D20  ldr      w10, [x8, #0x18]
0065C8D24  cmp      w9, w10
0065C8D28  b.ge     #0x65c8d5c
0065C8D2C  cmp      w9, w10
0065C8D30  b.hs     #0x65c8d6c
0065C8D34  add      x8, x8, x9, lsl #2
0065C8D38  ldr      w8, [x8, #0x20]
0065C8D3C  cmp      w8, #4
0065C8D40  cset     w0, eq
0065C8D44  b        #0x65c8d60 ; 
0065C8D48  ldr      x2, [x1, #0x60]
0065C8D4C  mov      x0, x19
0065C8D50  ldp      x20, x19, [sp, #0x10]
0065C8D54  ldp      x30, x21, [sp], #0x20
0065C8D58  br       x2
0065C8D5C  mov      w0, wzr
0065C8D60  ldp      x20, x19, [sp, #0x10]
0065C8D64  ldp      x30, x21, [sp], #0x20
0065C8D68  ret      
0065C8D6C  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CanRunUpLevelProgress
; RVA 0x65C8D70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8D70  stp      x30, x21, [sp, #-0x20]!
0065C8D74  stp      x20, x19, [sp, #0x10]
0065C8D78  adrp     x20, #0x9599000
0065C8D7C  adrp     x21, #0x8f0a000
0065C8D80  ldrb     w8, [x20, #0x572]
0065C8D84  ldr      x21, [x21, #0x770]
0065C8D88  mov      x19, x0
0065C8D8C  tbnz     w8, #0, #0x65c8da4
0065C8D90  adrp     x0, #0x8f0a000
0065C8D94  ldr      x0, [x0, #0x770]
0065C8D98  bl       #0x382bd14 ; 
0065C8D9C  mov      w8, #1
0065C8DA0  strb     w8, [x20, #0x572]
0065C8DA4  ldr      x1, [x21]
0065C8DA8  ldrb     w8, [x1, #0x53]
0065C8DAC  tbnz     w8, #5, #0x65c8e00
0065C8DB0  ldr      x0, [x19, #0x88]
0065C8DB4  cbz      x0, #0x65c8e88
0065C8DB8  mov      x1, xzr
0065C8DBC  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0065C8DC0  tbnz     w0, #0, #0x65c8e64
0065C8DC4  adrp     x20, #0x9599000
0065C8DC8  ldrb     w8, [x20, #0x28c]
0065C8DCC  cbnz     w8, #0x65c8de4
0065C8DD0  adrp     x0, #0x8f07000
0065C8DD4  ldr      x0, [x0, #0xdf0]
0065C8DD8  bl       #0x382bd14 ; 
0065C8DDC  mov      w8, #1
0065C8DE0  strb     w8, [x20, #0x28c]
0065C8DE4  adrp     x8, #0x8f07000
0065C8DE8  ldr      x8, [x8, #0xdf0]
0065C8DEC  ldr      x1, [x8]
0065C8DF0  ldrb     w8, [x1, #0x53]
0065C8DF4  tbnz     w8, #5, #0x65c8e14
0065C8DF8  ldr      w0, [x19, #0x28]
0065C8DFC  b        #0x65c8e20 ; 
0065C8E00  ldr      x2, [x1, #0x60]
0065C8E04  mov      x0, x19
0065C8E08  ldp      x20, x19, [sp, #0x10]
0065C8E0C  ldp      x30, x21, [sp], #0x20
0065C8E10  br       x2
0065C8E14  ldr      x8, [x1, #0x60]
0065C8E18  mov      x0, x19
0065C8E1C  blr      x8
0065C8E20  cmp      w0, #1
0065C8E24  b.ne     #0x65c8e64
0065C8E28  adrp     x20, #0x9599000
0065C8E2C  ldrb     w8, [x20, #0x286]
0065C8E30  cbnz     w8, #0x65c8e48
0065C8E34  adrp     x0, #0x8f07000
0065C8E38  ldr      x0, [x0, #0xc98]
0065C8E3C  bl       #0x382bd14 ; 
0065C8E40  mov      w8, #1
0065C8E44  strb     w8, [x20, #0x286]
0065C8E48  adrp     x8, #0x8f07000
0065C8E4C  ldr      x8, [x8, #0xc98]
0065C8E50  ldr      x1, [x8]
0065C8E54  ldrb     w8, [x1, #0x53]
0065C8E58  tbnz     w8, #5, #0x65c8e6c
0065C8E5C  ldr      x0, [x19, #0x80]
0065C8E60  b        #0x65c8e78 ; 
0065C8E64  mov      w0, wzr
0065C8E68  b        #0x65c8e88 ; 
0065C8E6C  ldr      x8, [x1, #0x60]
0065C8E70  mov      x0, x19
0065C8E74  blr      x8
0065C8E78  cbz      x0, #0x65c8e94
0065C8E7C  ldrb     w8, [x0, #0x1a0]
0065C8E80  cmp      w8, #0
0065C8E84  cset     w0, eq
0065C8E88  ldp      x20, x19, [sp, #0x10]
0065C8E8C  ldp      x30, x21, [sp], #0x20
0065C8E90  ret      
0065C8E94  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$QueueSelectSkill
; RVA 0x65C8E98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8E98  stp      x30, x21, [sp, #-0x20]!
0065C8E9C  stp      x20, x19, [sp, #0x10]
0065C8EA0  adrp     x20, #0x9599000
0065C8EA4  adrp     x21, #0x8f0a000
0065C8EA8  ldrb     w8, [x20, #0x573]
0065C8EAC  ldr      x21, [x21, #0x778]
0065C8EB0  mov      x19, x0
0065C8EB4  tbnz     w8, #0, #0x65c8ecc
0065C8EB8  adrp     x0, #0x8f0a000
0065C8EBC  ldr      x0, [x0, #0x778]
0065C8EC0  bl       #0x382bd14 ; 
0065C8EC4  mov      w8, #1
0065C8EC8  strb     w8, [x20, #0x573]
0065C8ECC  ldr      x1, [x21]
0065C8ED0  ldrb     w8, [x1, #0x53]
0065C8ED4  tbnz     w8, #5, #0x65c8f2c
0065C8ED8  mov      x0, x19
0065C8EDC  bl       #0x65c8d70 ; HotFix.BattleLogic.WaterfallBattleManager$$CanRunUpLevelProgress
0065C8EE0  tbz      w0, #0, #0x65c8f40
0065C8EE4  mov      x0, x19
0065C8EE8  mov      x1, xzr
0065C8EEC  bl       #0x6587334 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_IsStateWaveShowEnd
0065C8EF0  tbz      w0, #0, #0x65c8f0c
0065C8EF4  ldr      w8, [x19, #0x1d0]
0065C8EF8  cmp      w8, #3
0065C8EFC  b.eq     #0x65c8f40
0065C8F00  cbnz     w8, #0x65c8f0c
0065C8F04  mov      w8, #1
0065C8F08  str      w8, [x19, #0x1d0]
0065C8F0C  mov      x0, x19
0065C8F10  ldp      x20, x19, [sp, #0x10]
0065C8F14  mov      w1, #3
0065C8F18  mov      x2, xzr
0065C8F1C  mov      w3, wzr
0065C8F20  mov      x4, xzr
0065C8F24  ldp      x30, x21, [sp], #0x20
0065C8F28  b        #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
0065C8F2C  ldr      x2, [x1, #0x60]
0065C8F30  mov      x0, x19
0065C8F34  ldp      x20, x19, [sp, #0x10]
0065C8F38  ldp      x30, x21, [sp], #0x20
0065C8F3C  br       x2
0065C8F40  ldp      x20, x19, [sp, #0x10]
0065C8F44  ldp      x30, x21, [sp], #0x20
0065C8F48  ret      

; HotFix.BattleLogic.WaterfallBattleManager$$OnStart
; RVA 0x65C8F4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C8F4C  str      x30, [sp, #-0x40]!
0065C8F50  stp      x24, x23, [sp, #0x10]
0065C8F54  stp      x22, x21, [sp, #0x20]
0065C8F58  stp      x20, x19, [sp, #0x30]
0065C8F5C  adrp     x20, #0x9599000
0065C8F60  adrp     x21, #0x8f0a000
0065C8F64  ldrb     w8, [x20, #0x574]
0065C8F68  ldr      x21, [x21, #0x780]
0065C8F6C  mov      x19, x0
0065C8F70  tbnz     w8, #0, #0x65c8f94
0065C8F74  adrp     x0, #0x8f09000
0065C8F78  ldr      x0, [x0, #0xc08]
0065C8F7C  bl       #0x382bd14 ; 
0065C8F80  adrp     x0, #0x8f0a000
0065C8F84  ldr      x0, [x0, #0x780]
0065C8F88  bl       #0x382bd14 ; 
0065C8F8C  mov      w8, #1
0065C8F90  strb     w8, [x20, #0x574]
0065C8F94  ldr      x1, [x21]
0065C8F98  ldrb     w8, [x1, #0x53]
0065C8F9C  tbnz     w8, #5, #0x65c8fdc
0065C8FA0  adrp     x22, #0x9599000
0065C8FA4  ldrb     w8, [x22, #0x286]
0065C8FA8  cbnz     w8, #0x65c8fc0
0065C8FAC  adrp     x0, #0x8f07000
0065C8FB0  ldr      x0, [x0, #0xc98]
0065C8FB4  bl       #0x382bd14 ; 
0065C8FB8  mov      w8, #1
0065C8FBC  strb     w8, [x22, #0x286]
0065C8FC0  adrp     x23, #0x8f07000
0065C8FC4  ldr      x23, [x23, #0xc98]
0065C8FC8  ldr      x1, [x23]
0065C8FCC  ldrb     w8, [x1, #0x53]
0065C8FD0  tbnz     w8, #5, #0x65c8ff8
0065C8FD4  ldr      x0, [x19, #0x80]
0065C8FD8  b        #0x65c9004 ; 
0065C8FDC  ldr      x2, [x1, #0x60]
0065C8FE0  mov      x0, x19
0065C8FE4  ldp      x20, x19, [sp, #0x30]
0065C8FE8  ldp      x22, x21, [sp, #0x20]
0065C8FEC  ldp      x24, x23, [sp, #0x10]
0065C8FF0  ldr      x30, [sp], #0x40
0065C8FF4  br       x2
0065C8FF8  ldr      x8, [x1, #0x60]
0065C8FFC  mov      x0, x19
0065C9000  blr      x8
0065C9004  cbz      x0, #0x65c9210
0065C9008  ldr      x8, [x0, #0x1d0]
0065C900C  cbz      x8, #0x65c9210
0065C9010  ldr      x8, [x8, #0x28]
0065C9014  cbz      x8, #0x65c9210
0065C9018  ldr      w8, [x8, #0x10]
0065C901C  str      wzr, [x19, #0x128]
0065C9020  strb     wzr, [x19, #0x118]
0065C9024  str      w8, [x19, #0x12c]
0065C9028  ldrb     w8, [x22, #0x286]
0065C902C  cbnz     w8, #0x65c9044
0065C9030  adrp     x0, #0x8f07000
0065C9034  ldr      x0, [x0, #0xc98]
0065C9038  bl       #0x382bd14 ; 
0065C903C  mov      w8, #1
0065C9040  strb     w8, [x22, #0x286]
0065C9044  ldr      x1, [x23]
0065C9048  ldrb     w8, [x1, #0x53]
0065C904C  tbnz     w8, #5, #0x65c9058
0065C9050  ldr      x0, [x19, #0x80]
0065C9054  b        #0x65c9064 ; 
0065C9058  ldr      x8, [x1, #0x60]
0065C905C  mov      x0, x19
0065C9060  blr      x8
0065C9064  cbz      x0, #0x65c9210
0065C9068  mov      x1, xzr
0065C906C  bl       #0x6a01dc8 ; HotFix.BattleLogic.BattleWorldContext$$GetWaterfallMissions
0065C9070  cbz      x0, #0x65c9210
0065C9074  ldr      x8, [x0, #0x18]
0065C9078  cbz      x8, #0x65c91e8
0065C907C  cbz      w8, #0x65c9214
0065C9080  mov      x9, #-0x100000000
0065C9084  add      x8, x9, x8, lsl #32
0065C9088  add      x8, x0, x8, asr #30
0065C908C  ldrb     w9, [x22, #0x286]
0065C9090  ldr      w20, [x8, #0x20]
0065C9094  cbnz     w9, #0x65c90ac
0065C9098  adrp     x0, #0x8f07000
0065C909C  ldr      x0, [x0, #0xc98]
0065C90A0  bl       #0x382bd14 ; 
0065C90A4  mov      w8, #1
0065C90A8  strb     w8, [x22, #0x286]
0065C90AC  ldr      x1, [x23]
0065C90B0  ldrb     w8, [x1, #0x53]
0065C90B4  tbnz     w8, #5, #0x65c90c0
0065C90B8  ldr      x21, [x19, #0x80]
0065C90BC  b        #0x65c90d0 ; 
0065C90C0  ldr      x8, [x1, #0x60]
0065C90C4  mov      x0, x19
0065C90C8  blr      x8
0065C90CC  mov      x21, x0
0065C90D0  cbz      x21, #0x65c9210
0065C90D4  adrp     x24, #0x9598000
0065C90D8  ldrb     w8, [x24, #0xfcc]
0065C90DC  cbnz     w8, #0x65c90f4
0065C90E0  adrp     x0, #0x8f06000
0065C90E4  ldr      x0, [x0, #0x470]
0065C90E8  bl       #0x382bd14 ; 
0065C90EC  mov      w8, #1
0065C90F0  strb     w8, [x24, #0xfcc]
0065C90F4  adrp     x8, #0x8f06000
0065C90F8  ldr      x8, [x8, #0x470]
0065C90FC  ldr      x1, [x8]
0065C9100  ldrb     w8, [x1, #0x53]
0065C9104  tbnz     w8, #5, #0x65c9110
0065C9108  ldr      x21, [x21, #0x200]
0065C910C  b        #0x65c9120 ; 
0065C9110  ldr      x8, [x1, #0x60]
0065C9114  mov      x0, x21
0065C9118  blr      x8
0065C911C  mov      x21, x0
0065C9120  ldrb     w8, [x22, #0x286]
0065C9124  cbnz     w8, #0x65c913c
0065C9128  adrp     x0, #0x8f07000
0065C912C  ldr      x0, [x0, #0xc98]
0065C9130  bl       #0x382bd14 ; 
0065C9134  mov      w8, #1
0065C9138  strb     w8, [x22, #0x286]
0065C913C  ldr      x1, [x23]
0065C9140  ldrb     w8, [x1, #0x53]
0065C9144  tbnz     w8, #5, #0x65c9150
0065C9148  ldr      x0, [x19, #0x80]
0065C914C  b        #0x65c915c ; 
0065C9150  ldr      x8, [x1, #0x60]
0065C9154  mov      x0, x19
0065C9158  blr      x8
0065C915C  cbz      x0, #0x65c9210
0065C9160  ldr      w1, [x0, #0x1c8]
0065C9164  mov      x0, x21
0065C9168  mov      w2, w20
0065C916C  mov      x3, xzr
0065C9170  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065C9174  cbz      x0, #0x65c9210
0065C9178  adrp     x10, #0x8f09000
0065C917C  ldr      x8, [x0]
0065C9180  ldr      x10, [x10, #0xc08]
0065C9184  mov      x20, x0
0065C9188  ldrh     w9, [x8, #0x12e]
0065C918C  ldr      x1, [x10]
0065C9190  cbz      x9, #0x65c91b4
0065C9194  ldr      x10, [x8, #0xb0]
0065C9198  add      x10, x10, #8
0065C919C  ldur     x11, [x10, #-8]
0065C91A0  cmp      x11, x1
0065C91A4  b.eq     #0x65c91c4
0065C91A8  subs     x9, x9, #1
0065C91AC  add      x10, x10, #0x10
0065C91B0  b.ne     #0x65c919c
0065C91B4  mov      w2, #4
0065C91B8  mov      x0, x20
0065C91BC  bl       #0x3a7e710 ; 
0065C91C0  b        #0x65c91d4 ; 
0065C91C4  ldr      w9, [x10]
0065C91C8  add      w9, w9, #4
0065C91CC  add      x8, x8, w9, sxtw #4
0065C91D0  add      x0, x8, #0x138
0065C91D4  ldp      x8, x1, [x0]
0065C91D8  mov      x0, x20
0065C91DC  blr      x8
0065C91E0  lsr      x8, x0, #0x10
0065C91E4  str      w8, [x19, #0x114]
0065C91E8  strh     wzr, [x19, #0x1a4]
0065C91EC  strb     wzr, [x19, #0x1a6]
0065C91F0  str      wzr, [x19, #0x1a8]
0065C91F4  str      xzr, [x19, #0x1b0]
0065C91F8  str      xzr, [x19, #0x1c0]
0065C91FC  ldp      x20, x19, [sp, #0x30]
0065C9200  ldp      x22, x21, [sp, #0x20]
0065C9204  ldp      x24, x23, [sp, #0x10]
0065C9208  ldr      x30, [sp], #0x40
0065C920C  ret      
0065C9210  bl       #0x382bfb8 ; 
0065C9214  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$SaveBattleRecord
; RVA 0x65C9218; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C9218  stp      x30, x21, [sp, #-0x20]!
0065C921C  stp      x20, x19, [sp, #0x10]
0065C9220  adrp     x20, #0x9599000
0065C9224  adrp     x21, #0x8f0a000
0065C9228  ldrb     w8, [x20, #0x575]
0065C922C  ldr      x21, [x21, #0x788]
0065C9230  mov      x19, x0
0065C9234  tbnz     w8, #0, #0x65c9264
0065C9238  adrp     x0, #0x8f09000
0065C923C  ldr      x0, [x0, #0xc08]
0065C9240  bl       #0x382bd14 ; 
0065C9244  adrp     x0, #0x8f0a000
0065C9248  ldr      x0, [x0, #0x788]
0065C924C  bl       #0x382bd14 ; 
0065C9250  adrp     x0, #0x8f0a000
0065C9254  ldr      x0, [x0, #0x790]
0065C9258  bl       #0x382bd14 ; 
0065C925C  mov      w8, #1
0065C9260  strb     w8, [x20, #0x575]
0065C9264  ldr      x1, [x21]
0065C9268  ldrb     w8, [x1, #0x53]
0065C926C  tbnz     w8, #5, #0x65c92c0
0065C9270  ldr      x20, [x19, #0x188]
0065C9274  cbz      x20, #0x65c9334
0065C9278  adrp     x10, #0x8f09000
0065C927C  ldr      x8, [x20]
0065C9280  ldr      x10, [x10, #0xc08]
0065C9284  ldrh     w9, [x8, #0x12e]
0065C9288  ldr      x1, [x10]
0065C928C  cbz      x9, #0x65c92b0
0065C9290  ldr      x10, [x8, #0xb0]
0065C9294  add      x10, x10, #8
0065C9298  ldur     x11, [x10, #-8]
0065C929C  cmp      x11, x1
0065C92A0  b.eq     #0x65c92d4
0065C92A4  subs     x9, x9, #1
0065C92A8  add      x10, x10, #0x10
0065C92AC  b.ne     #0x65c9298
0065C92B0  mov      x0, x20
0065C92B4  mov      w2, wzr
0065C92B8  bl       #0x3a7e710 ; 
0065C92BC  b        #0x65c92e0 ; 
0065C92C0  ldr      x2, [x1, #0x60]
0065C92C4  mov      x0, x19
0065C92C8  ldp      x20, x19, [sp, #0x10]
0065C92CC  ldp      x30, x21, [sp], #0x20
0065C92D0  br       x2
0065C92D4  ldrsw    x9, [x10]
0065C92D8  add      x8, x8, x9, lsl #4
0065C92DC  add      x0, x8, #0x138
0065C92E0  ldp      x8, x1, [x0]
0065C92E4  mov      x0, x20
0065C92E8  blr      x8
0065C92EC  ldr      w8, [x19, #0x134]
0065C92F0  cmp      w0, w8
0065C92F4  b.ne     #0x65c9334
0065C92F8  adrp     x20, #0x9599000
0065C92FC  ldrb     w8, [x20, #0x286]
0065C9300  cbnz     w8, #0x65c9318
0065C9304  adrp     x0, #0x8f07000
0065C9308  ldr      x0, [x0, #0xc98]
0065C930C  bl       #0x382bd14 ; 
0065C9310  mov      w8, #1
0065C9314  strb     w8, [x20, #0x286]
0065C9318  adrp     x8, #0x8f07000
0065C931C  ldr      x8, [x8, #0xc98]
0065C9320  ldr      x1, [x8]
0065C9324  ldrb     w8, [x1, #0x53]
0065C9328  tbnz     w8, #5, #0x65c9340
0065C932C  ldr      x0, [x19, #0x80]
0065C9330  b        #0x65c934c ; 
0065C9334  ldp      x20, x19, [sp, #0x10]
0065C9338  ldp      x30, x21, [sp], #0x20
0065C933C  ret      
0065C9340  ldr      x8, [x1, #0x60]
0065C9344  mov      x0, x19
0065C9348  blr      x8
0065C934C  cbz      x0, #0x65c9384
0065C9350  adrp     x8, #0x8f0a000
0065C9354  ldr      x8, [x8, #0x790]
0065C9358  mov      x2, xzr
0065C935C  ldr      x1, [x8]
0065C9360  bl       #0x6a22a9c ; HotFix.BattleLogic.BattleWorldContext$$DisPathBattleRecordEvent
0065C9364  ldr      x8, [x19]
0065C9368  mov      x0, x19
0065C936C  ldp      x20, x19, [sp, #0x10]
0065C9370  mov      w1, wzr
0065C9374  ldr      x3, [x8, #0x638]
0065C9378  ldr      x2, [x8, #0x640]
0065C937C  ldp      x30, x21, [sp], #0x20
0065C9380  br       x3
0065C9384  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$OnBattleEnd
; RVA 0x65C9388; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C9388  str      x30, [sp, #-0x30]!
0065C938C  stp      x22, x21, [sp, #0x10]
0065C9390  stp      x20, x19, [sp, #0x20]
0065C9394  adrp     x21, #0x9599000
0065C9398  adrp     x22, #0x8f0a000
0065C939C  ldrb     w8, [x21, #0x576]
0065C93A0  ldr      x22, [x22, #0x798]
0065C93A4  mov      w19, w1
0065C93A8  mov      x20, x0
0065C93AC  tbnz     w8, #0, #0x65c93c4
0065C93B0  adrp     x0, #0x8f0a000
0065C93B4  ldr      x0, [x0, #0x798]
0065C93B8  bl       #0x382bd14 ; 
0065C93BC  mov      w8, #1
0065C93C0  strb     w8, [x21, #0x576]
0065C93C4  ldr      x2, [x22]
0065C93C8  ldrb     w8, [x2, #0x53]
0065C93CC  tbnz     w8, #5, #0x65c9404
0065C93D0  ldr      x8, [x20]
0065C93D4  mov      w9, #1
0065C93D8  strb     w9, [x20, #0x180]
0065C93DC  mov      x0, x20
0065C93E0  ldr      x9, [x8, #0x578]
0065C93E4  ldr      x1, [x8, #0x580]
0065C93E8  blr      x9
0065C93EC  mov      x0, x20
0065C93F0  mov      w1, w19
0065C93F4  ldp      x20, x19, [sp, #0x20]
0065C93F8  ldp      x22, x21, [sp, #0x10]
0065C93FC  ldr      x30, [sp], #0x30
0065C9400  b        #0x65c3fa0 ; HotFix.BattleLogic.SinglePlayerBattleManager$$OnBattleEnd
0065C9404  ldr      x3, [x2, #0x60]
0065C9408  mov      x0, x20
0065C940C  mov      w1, w19
0065C9410  ldp      x20, x19, [sp, #0x20]
0065C9414  ldp      x22, x21, [sp, #0x10]
0065C9418  ldr      x30, [sp], #0x30
0065C941C  br       x3

; HotFix.BattleLogic.WaterfallBattleManager$$UploadBattleData
; RVA 0x65C9420; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C9420  stp      x29, x30, [sp, #-0x60]!
0065C9424  stp      x28, x27, [sp, #0x10]
0065C9428  stp      x26, x25, [sp, #0x20]
0065C942C  stp      x24, x23, [sp, #0x30]
0065C9430  stp      x22, x21, [sp, #0x40]
0065C9434  stp      x20, x19, [sp, #0x50]
0065C9438  sub      sp, sp, #0x290
0065C943C  adrp     x20, #0x9599000
0065C9440  adrp     x21, #0x8f0a000
0065C9444  ldrb     w8, [x20, #0x577]
0065C9448  ldr      x21, [x21, #0x7a0]
0065C944C  mov      x19, x0
0065C9450  tbnz     w8, #0, #0x65c94c8
0065C9454  adrp     x0, #0x8f08000
0065C9458  ldr      x0, [x0, #0x590]
0065C945C  bl       #0x382bd14 ; 
0065C9460  adrp     x0, #0x8f0a000
0065C9464  ldr      x0, [x0, #0x7a8]
0065C9468  bl       #0x382bd14 ; 
0065C946C  adrp     x0, #0x8f07000
0065C9470  ldr      x0, [x0, #0xe68]
0065C9474  bl       #0x382bd14 ; 
0065C9478  adrp     x0, #0x8ee6000
0065C947C  ldr      x0, [x0, #0xd8]
0065C9480  bl       #0x382bd14 ; 
0065C9484  adrp     x0, #0x8ee6000
0065C9488  ldr      x0, [x0, #0x610]
0065C948C  bl       #0x382bd14 ; 
0065C9490  adrp     x0, #0x8f08000
0065C9494  ldr      x0, [x0, #0x5a0]
0065C9498  bl       #0x382bd14 ; 
0065C949C  adrp     x0, #0x8ef7000
0065C94A0  ldr      x0, [x0, #0xb78]
0065C94A4  bl       #0x382bd14 ; 
0065C94A8  adrp     x0, #0x8f0a000
0065C94AC  ldr      x0, [x0, #0x7a0]
0065C94B0  bl       #0x382bd14 ; 
0065C94B4  adrp     x0, #0x8f0a000
0065C94B8  ldr      x0, [x0, #0x618]
0065C94BC  bl       #0x382bd14 ; 
0065C94C0  mov      w8, #1
0065C94C4  strb     w8, [x20, #0x577]
0065C94C8  ldr      x1, [x21]
0065C94CC  ldrb     w8, [x1, #0x53]
0065C94D0  tbnz     w8, #5, #0x65c952c
0065C94D4  add      x0, sp, #0x1e0
0065C94D8  mov      w2, #0xb0
0065C94DC  mov      w1, wzr
0065C94E0  bl       #0x89edb70 ; 
0065C94E4  ldrb     w8, [x19, #0x180]
0065C94E8  cbz      w8, #0x65ca584
0065C94EC  strb     wzr, [x19, #0x180]
0065C94F0  adrp     x22, #0x9599000
0065C94F4  ldrb     w8, [x22, #0x286]
0065C94F8  cbnz     w8, #0x65c9510
0065C94FC  adrp     x0, #0x8f07000
0065C9500  ldr      x0, [x0, #0xc98]
0065C9504  bl       #0x382bd14 ; 
0065C9508  mov      w8, #1
0065C950C  strb     w8, [x22, #0x286]
0065C9510  adrp     x23, #0x8f07000
0065C9514  ldr      x23, [x23, #0xc98]
0065C9518  ldr      x1, [x23]
0065C951C  ldrb     w8, [x1, #0x53]
0065C9520  tbnz     w8, #5, #0x65c9554
0065C9524  ldr      x20, [x19, #0x80]
0065C9528  b        #0x65c9564 ; 
0065C952C  ldr      x2, [x1, #0x60]
0065C9530  mov      x0, x19
0065C9534  add      sp, sp, #0x290
0065C9538  ldp      x20, x19, [sp, #0x50]
0065C953C  ldp      x22, x21, [sp, #0x40]
0065C9540  ldp      x24, x23, [sp, #0x30]
0065C9544  ldp      x26, x25, [sp, #0x20]
0065C9548  ldp      x28, x27, [sp, #0x10]
0065C954C  ldp      x29, x30, [sp], #0x60
0065C9550  br       x2
0065C9554  ldr      x8, [x1, #0x60]
0065C9558  mov      x0, x19
0065C955C  blr      x8
0065C9560  mov      x20, x0
0065C9564  cbz      x20, #0x65ca5a4
0065C9568  adrp     x8, #0x9591000
0065C956C  ldrb     w8, [x8, #0xa62]
0065C9570  cbnz     w8, #0x65c958c
0065C9574  adrp     x0, #0x8ee6000
0065C9578  ldr      x0, [x0, #0x1f8]
0065C957C  bl       #0x382bd14 ; 
0065C9580  mov      w8, #1
0065C9584  adrp     x9, #0x9591000
0065C9588  strb     w8, [x9, #0xa62]
0065C958C  adrp     x8, #0x8ee6000
0065C9590  ldr      x8, [x8, #0x1f8]
0065C9594  ldr      x1, [x8]
0065C9598  ldrb     w8, [x1, #0x53]
0065C959C  tbnz     w8, #5, #0x65c95a8
0065C95A0  ldr      x0, [x20, #0x1f8]
0065C95A4  b        #0x65c95b4 ; 
0065C95A8  ldr      x8, [x1, #0x60]
0065C95AC  mov      x0, x20
0065C95B0  blr      x8
0065C95B4  cbz      x0, #0x65ca5a4
0065C95B8  mov      w1, #1
0065C95BC  mov      x2, xzr
0065C95C0  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
0065C95C4  cbz      x0, #0x65ca5a4
0065C95C8  adrp     x8, #0x8f07000
0065C95CC  ldr      x8, [x8, #0xe68]
0065C95D0  ldr      x1, [x8]
0065C95D4  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065C95D8  cbz      x0, #0x65ca5a4
0065C95DC  adrp     x8, #0x9599000
0065C95E0  ldrb     w8, [x8, #0x4c7]
0065C95E4  mov      x20, x0
0065C95E8  cbnz     w8, #0x65c9604
0065C95EC  adrp     x0, #0x8f09000
0065C95F0  ldr      x0, [x0, #0xc8]
0065C95F4  bl       #0x382bd14 ; 
0065C95F8  mov      w8, #1
0065C95FC  adrp     x9, #0x9599000
0065C9600  strb     w8, [x9, #0x4c7]
0065C9604  adrp     x8, #0x8f09000
0065C9608  ldr      x8, [x8, #0xc8]
0065C960C  ldr      x1, [x8]
0065C9610  ldrb     w8, [x1, #0x53]
0065C9614  tbnz     w8, #5, #0x65c9620
0065C9618  ldr      x26, [x20, #0x58]
0065C961C  b        #0x65c9630 ; 
0065C9620  ldr      x8, [x1, #0x60]
0065C9624  mov      x0, x20
0065C9628  blr      x8
0065C962C  mov      x26, x0
0065C9630  ldr      x0, [x19, #0x88]
0065C9634  cbz      x0, #0x65ca5a4
0065C9638  adrp     x8, #0x8ee6000
0065C963C  ldr      x8, [x8, #0xd8]
0065C9640  ldr      x1, [x8]
0065C9644  ldrb     w8, [x1, #0x53]
0065C9648  tbnz     w8, #5, #0x65c9654
0065C964C  ldr      x20, [x0, #0x38]
0065C9650  b        #0x65c9660 ; 
0065C9654  ldr      x8, [x1, #0x60]
0065C9658  blr      x8
0065C965C  mov      x20, x0
0065C9660  cbz      x20, #0x65ca5a4
0065C9664  adrp     x21, #0x9591000
0065C9668  ldrb     w8, [x21, #0xa7f]
0065C966C  cbnz     w8, #0x65c9684
0065C9670  adrp     x0, #0x8ee6000
0065C9674  ldr      x0, [x0, #0x2d8]
0065C9678  bl       #0x382bd14 ; 
0065C967C  mov      w8, #1
0065C9680  strb     w8, [x21, #0xa7f]
0065C9684  adrp     x8, #0x8ee6000
0065C9688  ldr      x8, [x8, #0x2d8]
0065C968C  ldr      x1, [x8]
0065C9690  ldrb     w8, [x1, #0x53]
0065C9694  tbnz     w8, #5, #0x65c96a0
0065C9698  ldr      x0, [x20, #0x178]
0065C969C  b        #0x65c96ac ; 
0065C96A0  ldr      x8, [x1, #0x60]
0065C96A4  mov      x0, x20
0065C96A8  blr      x8
0065C96AC  cbz      x0, #0x65ca5a4
0065C96B0  adrp     x8, #0x8f0a000
0065C96B4  ldr      x8, [x8, #0x618]
0065C96B8  mov      x2, xzr
0065C96BC  ldr      x1, [x8]
0065C96C0  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
0065C96C4  ldrb     w8, [x22, #0x286]
0065C96C8  mov      x27, x0
0065C96CC  cbnz     w8, #0x65c96e4
0065C96D0  adrp     x0, #0x8f07000
0065C96D4  ldr      x0, [x0, #0xc98]
0065C96D8  bl       #0x382bd14 ; 
0065C96DC  mov      w8, #1
0065C96E0  strb     w8, [x22, #0x286]
0065C96E4  ldr      x1, [x23]
0065C96E8  ldrb     w8, [x1, #0x53]
0065C96EC  tbnz     w8, #5, #0x65c96f8
0065C96F0  ldr      x0, [x19, #0x80]
0065C96F4  b        #0x65c9704 ; 
0065C96F8  ldr      x8, [x1, #0x60]
0065C96FC  mov      x0, x19
0065C9700  blr      x8
0065C9704  cbz      x0, #0x65ca5a4
0065C9708  mov      x1, xzr
0065C970C  bl       #0x6a246a0 ; HotFix.BattleLogic.BattleWorldContext$$CollectTriggerActionStateJsons
0065C9710  ldrb     w8, [x22, #0x286]
0065C9714  mov      x21, x0
0065C9718  cbnz     w8, #0x65c9730
0065C971C  adrp     x0, #0x8f07000
0065C9720  ldr      x0, [x0, #0xc98]
0065C9724  bl       #0x382bd14 ; 
0065C9728  mov      w8, #1
0065C972C  strb     w8, [x22, #0x286]
0065C9730  ldr      x1, [x23]
0065C9734  ldrb     w8, [x1, #0x53]
0065C9738  tbnz     w8, #5, #0x65c9744
0065C973C  ldr      x0, [x19, #0x80]
0065C9740  b        #0x65c9750 ; 
0065C9744  ldr      x8, [x1, #0x60]
0065C9748  mov      x0, x19
0065C974C  blr      x8
0065C9750  cbz      x0, #0x65ca5a4
0065C9754  ldr      x8, [x0, #0x1d0]
0065C9758  cbz      x8, #0x65ca5a4
0065C975C  ldr      x20, [x8, #0x28]
0065C9760  adrp     x8, #0x8f08000
0065C9764  ldr      w25, [x19, #0x12c]
0065C9768  ldr      x8, [x8, #0x590]
0065C976C  adrp     x9, #0x8ee6000
0065C9770  ldr      x9, [x9, #0x610]
0065C9774  adrp     x10, #0x8f08000
0065C9778  ldr      x8, [x8]
0065C977C  ldr      x10, [x10, #0x5a0]
0065C9780  ldr      x9, [x9]
0065C9784  ldrb     w11, [x22, #0x286]
0065C9788  ldr      x8, [x8, #0xb8]
0065C978C  ldr      x10, [x10]
0065C9790  ldr      x9, [x9, #0xb8]
0065C9794  ldr      w12, [x8, #8]
0065C9798  ldr      x10, [x10, #0xb8]
0065C979C  ldr      w24, [x9]
0065C97A0  str      w12, [sp, #0x11c]
0065C97A4  ldp      w12, w8, [x8]
0065C97A8  ldp      w28, w29, [x10]
0065C97AC  str      w8, [sp, #0x124]
0065C97B0  ldr      w8, [x10, #8]
0065C97B4  str      w12, [sp, #0x120]
0065C97B8  str      w8, [sp, #0x118]
0065C97BC  ldr      w8, [x10, #0xc]
0065C97C0  str      w8, [sp, #0x114]
0065C97C4  cbnz     w11, #0x65c97dc
0065C97C8  adrp     x0, #0x8f07000
0065C97CC  ldr      x0, [x0, #0xc98]
0065C97D0  bl       #0x382bd14 ; 
0065C97D4  mov      w8, #1
0065C97D8  strb     w8, [x22, #0x286]
0065C97DC  ldr      x1, [x23]
0065C97E0  ldrb     w8, [x1, #0x53]
0065C97E4  tbnz     w8, #5, #0x65c97f0
0065C97E8  ldr      x0, [x19, #0x80]
0065C97EC  b        #0x65c97fc ; 
0065C97F0  ldr      x8, [x1, #0x60]
0065C97F4  mov      x0, x19
0065C97F8  blr      x8
0065C97FC  cbz      x0, #0x65ca5a4
0065C9800  ldr      x0, [x0, #0x1d0]
0065C9804  cbz      x0, #0x65ca5a4
0065C9808  mov      x1, xzr
0065C980C  str      w24, [sp, #0x110]
0065C9810  str      x20, [sp, #0x128]
0065C9814  bl       #0x6a31e00 ; HotFix.BattleLogic.WorldInitInfo$$GetPlayerInfo
0065C9818  cbz      x0, #0x65ca5a4
0065C981C  adrp     x24, #0x9599000
0065C9820  ldrb     w8, [x24, #0x650]
0065C9824  mov      x20, x0
0065C9828  cbnz     w8, #0x65c9840
0065C982C  adrp     x0, #0x8f0a000
0065C9830  ldr      x0, [x0, #0x7b0]
0065C9834  bl       #0x382bd14 ; 
0065C9838  mov      w8, #1
0065C983C  strb     w8, [x24, #0x650]
0065C9840  adrp     x8, #0x8f0a000
0065C9844  ldr      x8, [x8, #0x7b0]
0065C9848  ldr      x1, [x8]
0065C984C  ldrb     w8, [x1, #0x53]
0065C9850  tbnz     w8, #5, #0x65c985c
0065C9854  ldr      w24, [x20, #0x14]
0065C9858  b        #0x65c986c ; 
0065C985C  ldr      x8, [x1, #0x60]
0065C9860  mov      x0, x20
0065C9864  blr      x8
0065C9868  mov      w24, w0
0065C986C  adrp     x20, #0x8f0a000
0065C9870  ldr      x20, [x20, #0x7a8]
0065C9874  ldr      x0, [x20]
0065C9878  ldr      w8, [x0, #0xe0]
0065C987C  cbnz     w8, #0x65c9884
0065C9880  bl       #0x382be8c ; 
0065C9884  adrp     x8, #0x9599000
0065C9888  ldrb     w8, [x8, #0x651]
0065C988C  cbnz     w8, #0x65c98b4
0065C9890  adrp     x0, #0x8f0a000
0065C9894  ldr      x0, [x0, #0x7b8]
0065C9898  bl       #0x382bd14 ; 
0065C989C  adrp     x0, #0x8f0a000
0065C98A0  ldr      x0, [x0, #0x7a8]
0065C98A4  bl       #0x382bd14 ; 
0065C98A8  mov      w8, #1
0065C98AC  adrp     x9, #0x9599000
0065C98B0  strb     w8, [x9, #0x651]
0065C98B4  adrp     x8, #0x8f0a000
0065C98B8  ldr      x8, [x8, #0x7b8]
0065C98BC  ldr      x0, [x8]
0065C98C0  ldrb     w8, [x0, #0x53]
0065C98C4  tbnz     w8, #5, #0x65c98ec
0065C98C8  ldr      x0, [x20]
0065C98CC  ldr      w8, [x0, #0xe0]
0065C98D0  cbnz     w8, #0x65c98dc
0065C98D4  bl       #0x382be8c ; 
0065C98D8  ldr      x0, [x20]
0065C98DC  ldr      x8, [x0, #0xb8]
0065C98E0  ldr      x8, [x8, #8]
0065C98E4  str      x8, [sp, #0x100]
0065C98E8  b        #0x65c98f8 ; 
0065C98EC  ldr      x8, [x0, #0x60]
0065C98F0  blr      x8
0065C98F4  str      x0, [sp, #0x100]
0065C98F8  ldrb     w8, [x22, #0x286]
0065C98FC  cbnz     w8, #0x65c9914
0065C9900  adrp     x0, #0x8f07000
0065C9904  ldr      x0, [x0, #0xc98]
0065C9908  bl       #0x382bd14 ; 
0065C990C  mov      w8, #1
0065C9910  strb     w8, [x22, #0x286]
0065C9914  ldr      x1, [x23]
0065C9918  ldrb     w8, [x1, #0x53]
0065C991C  tbnz     w8, #5, #0x65c9928
0065C9920  ldr      x20, [x19, #0x80]
0065C9924  b        #0x65c9938 ; 
0065C9928  ldr      x8, [x1, #0x60]
0065C992C  mov      x0, x19
0065C9930  blr      x8
0065C9934  mov      x20, x0
0065C9938  str      w29, [sp, #0x10c]
0065C993C  cbz      x20, #0x65ca5a4
0065C9940  adrp     x29, #0x9599000
0065C9944  ldrb     w8, [x29, #0x63b]
0065C9948  str      w24, [sp, #0xfc]
0065C994C  cbnz     w8, #0x65c9964
0065C9950  adrp     x0, #0x8f0a000
0065C9954  ldr      x0, [x0, #0x490]
0065C9958  bl       #0x382bd14 ; 
0065C995C  mov      w8, #1
0065C9960  strb     w8, [x29, #0x63b]
0065C9964  adrp     x24, #0x8f0a000
0065C9968  ldr      x24, [x24, #0x490]
0065C996C  ldr      x1, [x24]
0065C9970  ldrb     w8, [x1, #0x53]
0065C9974  tbnz     w8, #5, #0x65c998c
0065C9978  add      x1, x20, #0x290
0065C997C  add      x0, sp, #0x130
0065C9980  mov      w2, #0xb0
0065C9984  bl       #0x89edad0 ; 
0065C9988  b        #0x65c999c ; 
0065C998C  ldr      x9, [x1, #0x60]
0065C9990  add      x8, sp, #0x130
0065C9994  mov      x0, x20
0065C9998  blr      x9
0065C999C  add      x0, sp, #0x1e0
0065C99A0  add      x1, sp, #0x130
0065C99A4  mov      w2, #0xb0
0065C99A8  bl       #0x89edad0 ; 
0065C99AC  adrp     x20, #0x9599000
0065C99B0  ldrb     w8, [x20, #0x2a9]
0065C99B4  cbnz     w8, #0x65c99cc
0065C99B8  adrp     x0, #0x8f08000
0065C99BC  ldr      x0, [x0, #0x5b8]
0065C99C0  bl       #0x382bd14 ; 
0065C99C4  mov      w8, #1
0065C99C8  strb     w8, [x20, #0x2a9]
0065C99CC  adrp     x8, #0x8f08000
0065C99D0  ldr      x8, [x8, #0x5b8]
0065C99D4  ldr      x1, [x8]
0065C99D8  ldrb     w8, [x1, #0x53]
0065C99DC  tbnz     w8, #5, #0x65c99ec
0065C99E0  ldr      x8, [sp, #0x288]
0065C99E4  str      x8, [sp, #0xf0]
0065C99E8  b        #0x65c99fc ; 
0065C99EC  ldr      x8, [x1, #0x60]
0065C99F0  add      x0, sp, #0x1e0
0065C99F4  blr      x8
0065C99F8  str      x0, [sp, #0xf0]
0065C99FC  ldrb     w8, [x22, #0x286]
0065C9A00  cbnz     w8, #0x65c9a18
0065C9A04  adrp     x0, #0x8f07000
0065C9A08  ldr      x0, [x0, #0xc98]
0065C9A0C  bl       #0x382bd14 ; 
0065C9A10  mov      w8, #1
0065C9A14  strb     w8, [x22, #0x286]
0065C9A18  ldr      x1, [x23]
0065C9A1C  ldrb     w8, [x1, #0x53]
0065C9A20  tbnz     w8, #5, #0x65c9a2c
0065C9A24  ldr      x20, [x19, #0x80]
0065C9A28  b        #0x65c9a3c ; 
0065C9A2C  ldr      x8, [x1, #0x60]
0065C9A30  mov      x0, x19
0065C9A34  blr      x8
0065C9A38  mov      x20, x0
0065C9A3C  cbz      x20, #0x65ca5a4
0065C9A40  ldrb     w8, [x29, #0x63b]
0065C9A44  cbnz     w8, #0x65c9a5c
0065C9A48  adrp     x0, #0x8f0a000
0065C9A4C  ldr      x0, [x0, #0x490]
0065C9A50  bl       #0x382bd14 ; 
0065C9A54  mov      w8, #1
0065C9A58  strb     w8, [x29, #0x63b]
0065C9A5C  ldr      x1, [x24]
0065C9A60  ldrb     w8, [x1, #0x53]
0065C9A64  tbnz     w8, #5, #0x65c9a7c
0065C9A68  add      x1, x20, #0x290
0065C9A6C  add      x0, sp, #0x130
0065C9A70  mov      w2, #0xb0
0065C9A74  bl       #0x89edad0 ; 
0065C9A78  b        #0x65c9a8c ; 
0065C9A7C  ldr      x9, [x1, #0x60]
0065C9A80  add      x8, sp, #0x130
0065C9A84  mov      x0, x20
0065C9A88  blr      x9
0065C9A8C  add      x0, sp, #0x1e0
0065C9A90  add      x1, sp, #0x130
0065C9A94  mov      w2, #0xb0
0065C9A98  bl       #0x89edad0 ; 
0065C9A9C  adrp     x20, #0x9599000
0065C9AA0  ldrb     w8, [x20, #0x2a7]
0065C9AA4  cbnz     w8, #0x65c9abc
0065C9AA8  adrp     x0, #0x8f08000
0065C9AAC  ldr      x0, [x0, #0x5a8]
0065C9AB0  bl       #0x382bd14 ; 
0065C9AB4  mov      w8, #1
0065C9AB8  strb     w8, [x20, #0x2a7]
0065C9ABC  adrp     x8, #0x8f08000
0065C9AC0  ldr      x8, [x8, #0x5a8]
0065C9AC4  ldr      x1, [x8]
0065C9AC8  ldrb     w8, [x1, #0x53]
0065C9ACC  tbnz     w8, #5, #0x65c9adc
0065C9AD0  ldr      w8, [sp, #0x284]
0065C9AD4  str      w8, [sp, #0xec]
0065C9AD8  b        #0x65c9aec ; 
0065C9ADC  ldr      x8, [x1, #0x60]
0065C9AE0  add      x0, sp, #0x1e0
0065C9AE4  blr      x8
0065C9AE8  str      w0, [sp, #0xec]
0065C9AEC  ldrb     w8, [x22, #0x286]
0065C9AF0  cbnz     w8, #0x65c9b08
0065C9AF4  adrp     x0, #0x8f07000
0065C9AF8  ldr      x0, [x0, #0xc98]
0065C9AFC  bl       #0x382bd14 ; 
0065C9B00  mov      w8, #1
0065C9B04  strb     w8, [x22, #0x286]
0065C9B08  ldr      x1, [x23]
0065C9B0C  ldrb     w8, [x1, #0x53]
0065C9B10  tbnz     w8, #5, #0x65c9b1c
0065C9B14  ldr      x20, [x19, #0x80]
0065C9B18  b        #0x65c9b2c ; 
0065C9B1C  ldr      x8, [x1, #0x60]
0065C9B20  mov      x0, x19
0065C9B24  blr      x8
0065C9B28  mov      x20, x0
0065C9B2C  cbz      x20, #0x65ca5a4
0065C9B30  ldrb     w8, [x29, #0x63b]
0065C9B34  cbnz     w8, #0x65c9b4c
0065C9B38  adrp     x0, #0x8f0a000
0065C9B3C  ldr      x0, [x0, #0x490]
0065C9B40  bl       #0x382bd14 ; 
0065C9B44  mov      w8, #1
0065C9B48  strb     w8, [x29, #0x63b]
0065C9B4C  ldr      x1, [x24]
0065C9B50  ldrb     w8, [x1, #0x53]
0065C9B54  tbnz     w8, #5, #0x65c9b6c
0065C9B58  add      x1, x20, #0x290
0065C9B5C  add      x0, sp, #0x130
0065C9B60  mov      w2, #0xb0
0065C9B64  bl       #0x89edad0 ; 
0065C9B68  b        #0x65c9b7c ; 
0065C9B6C  ldr      x9, [x1, #0x60]
0065C9B70  add      x8, sp, #0x130
0065C9B74  mov      x0, x20
0065C9B78  blr      x9
0065C9B7C  add      x0, sp, #0x1e0
0065C9B80  add      x1, sp, #0x130
0065C9B84  mov      w2, #0xb0
0065C9B88  bl       #0x89edad0 ; 
0065C9B8C  adrp     x20, #0x9599000
0065C9B90  ldrb     w8, [x20, #0x2ad]
0065C9B94  cbnz     w8, #0x65c9bac
0065C9B98  adrp     x0, #0x8f08000
0065C9B9C  ldr      x0, [x0, #0x5d8]
0065C9BA0  bl       #0x382bd14 ; 
0065C9BA4  mov      w8, #1
0065C9BA8  strb     w8, [x20, #0x2ad]
0065C9BAC  adrp     x8, #0x8f08000
0065C9BB0  ldr      x8, [x8, #0x5d8]
0065C9BB4  ldr      x1, [x8]
0065C9BB8  ldrb     w8, [x1, #0x53]
0065C9BBC  tbnz     w8, #5, #0x65c9bcc
0065C9BC0  ldr      w8, [sp, #0x278]
0065C9BC4  str      w8, [sp, #0xe8]
0065C9BC8  b        #0x65c9bdc ; 
0065C9BCC  ldr      x8, [x1, #0x60]
0065C9BD0  add      x0, sp, #0x1e0
0065C9BD4  blr      x8
0065C9BD8  str      w0, [sp, #0xe8]
0065C9BDC  ldrb     w8, [x22, #0x286]
0065C9BE0  cbnz     w8, #0x65c9bf8
0065C9BE4  adrp     x0, #0x8f07000
0065C9BE8  ldr      x0, [x0, #0xc98]
0065C9BEC  bl       #0x382bd14 ; 
0065C9BF0  mov      w8, #1
0065C9BF4  strb     w8, [x22, #0x286]
0065C9BF8  ldr      x1, [x23]
0065C9BFC  ldrb     w8, [x1, #0x53]
0065C9C00  tbnz     w8, #5, #0x65c9c0c
0065C9C04  ldr      x20, [x19, #0x80]
0065C9C08  b        #0x65c9c1c ; 
0065C9C0C  ldr      x8, [x1, #0x60]
0065C9C10  mov      x0, x19
0065C9C14  blr      x8
0065C9C18  mov      x20, x0
0065C9C1C  cbz      x20, #0x65ca5a4
0065C9C20  ldrb     w8, [x29, #0x63b]
0065C9C24  cbnz     w8, #0x65c9c3c
0065C9C28  adrp     x0, #0x8f0a000
0065C9C2C  ldr      x0, [x0, #0x490]
0065C9C30  bl       #0x382bd14 ; 
0065C9C34  mov      w8, #1
0065C9C38  strb     w8, [x29, #0x63b]
0065C9C3C  ldr      x1, [x24]
0065C9C40  ldrb     w8, [x1, #0x53]
0065C9C44  tbnz     w8, #5, #0x65c9c5c
0065C9C48  add      x1, x20, #0x290
0065C9C4C  add      x0, sp, #0x130
0065C9C50  mov      w2, #0xb0
0065C9C54  bl       #0x89edad0 ; 
0065C9C58  b        #0x65c9c6c ; 
0065C9C5C  ldr      x9, [x1, #0x60]
0065C9C60  add      x8, sp, #0x130
0065C9C64  mov      x0, x20
0065C9C68  blr      x9
0065C9C6C  ldrb     w8, [x22, #0x286]
0065C9C70  ldr      w9, [sp, #0x160]
0065C9C74  str      w9, [sp, #0xe4]
0065C9C78  cbnz     w8, #0x65c9c90
0065C9C7C  adrp     x0, #0x8f07000
0065C9C80  ldr      x0, [x0, #0xc98]
0065C9C84  bl       #0x382bd14 ; 
0065C9C88  mov      w8, #1
0065C9C8C  strb     w8, [x22, #0x286]
0065C9C90  ldr      x1, [x23]
0065C9C94  ldrb     w8, [x1, #0x53]
0065C9C98  tbnz     w8, #5, #0x65c9ca4
0065C9C9C  ldr      x20, [x19, #0x80]
0065C9CA0  b        #0x65c9cb4 ; 
0065C9CA4  ldr      x8, [x1, #0x60]
0065C9CA8  mov      x0, x19
0065C9CAC  blr      x8
0065C9CB0  mov      x20, x0
0065C9CB4  cbz      x20, #0x65ca5a4
0065C9CB8  ldrb     w8, [x29, #0x63b]
0065C9CBC  cbnz     w8, #0x65c9cd4
0065C9CC0  adrp     x0, #0x8f0a000
0065C9CC4  ldr      x0, [x0, #0x490]
0065C9CC8  bl       #0x382bd14 ; 
0065C9CCC  mov      w8, #1
0065C9CD0  strb     w8, [x29, #0x63b]
0065C9CD4  ldr      x1, [x24]
0065C9CD8  ldrb     w8, [x1, #0x53]
0065C9CDC  tbnz     w8, #5, #0x65c9cf4
0065C9CE0  add      x1, x20, #0x290
0065C9CE4  add      x0, sp, #0x130
0065C9CE8  mov      w2, #0xb0
0065C9CEC  bl       #0x89edad0 ; 
0065C9CF0  b        #0x65c9d04 ; 
0065C9CF4  ldr      x9, [x1, #0x60]
0065C9CF8  add      x8, sp, #0x130
0065C9CFC  mov      x0, x20
0065C9D00  blr      x9
0065C9D04  ldrb     w8, [x22, #0x286]
0065C9D08  ldr      w9, [sp, #0x164]
0065C9D0C  str      w9, [sp, #0xe0]
0065C9D10  cbnz     w8, #0x65c9d28
0065C9D14  adrp     x0, #0x8f07000
0065C9D18  ldr      x0, [x0, #0xc98]
0065C9D1C  bl       #0x382bd14 ; 
0065C9D20  mov      w8, #1
0065C9D24  strb     w8, [x22, #0x286]
0065C9D28  ldr      x1, [x23]
0065C9D2C  ldrb     w8, [x1, #0x53]
0065C9D30  tbnz     w8, #5, #0x65c9d3c
0065C9D34  ldr      x20, [x19, #0x80]
0065C9D38  b        #0x65c9d4c ; 
0065C9D3C  ldr      x8, [x1, #0x60]
0065C9D40  mov      x0, x19
0065C9D44  blr      x8
0065C9D48  mov      x20, x0
0065C9D4C  cbz      x20, #0x65ca5a4
0065C9D50  ldrb     w8, [x29, #0x63b]
0065C9D54  cbnz     w8, #0x65c9d6c
0065C9D58  adrp     x0, #0x8f0a000
0065C9D5C  ldr      x0, [x0, #0x490]
0065C9D60  bl       #0x382bd14 ; 
0065C9D64  mov      w8, #1
0065C9D68  strb     w8, [x29, #0x63b]
0065C9D6C  ldr      x1, [x24]
0065C9D70  ldrb     w8, [x1, #0x53]
0065C9D74  tbnz     w8, #5, #0x65c9d8c
0065C9D78  add      x1, x20, #0x290
0065C9D7C  add      x0, sp, #0x130
0065C9D80  mov      w2, #0xb0
0065C9D84  bl       #0x89edad0 ; 
0065C9D88  b        #0x65c9d9c ; 
0065C9D8C  ldr      x9, [x1, #0x60]
0065C9D90  add      x8, sp, #0x130
0065C9D94  mov      x0, x20
0065C9D98  blr      x9
0065C9D9C  ldrb     w8, [x22, #0x286]
0065C9DA0  ldr      w9, [sp, #0x168]
0065C9DA4  str      w9, [sp, #0xdc]
0065C9DA8  cbnz     w8, #0x65c9dc0
0065C9DAC  adrp     x0, #0x8f07000
0065C9DB0  ldr      x0, [x0, #0xc98]
0065C9DB4  bl       #0x382bd14 ; 
0065C9DB8  mov      w8, #1
0065C9DBC  strb     w8, [x22, #0x286]
0065C9DC0  ldr      x1, [x23]
0065C9DC4  ldrb     w8, [x1, #0x53]
0065C9DC8  tbnz     w8, #5, #0x65c9dd4
0065C9DCC  ldr      x20, [x19, #0x80]
0065C9DD0  b        #0x65c9de4 ; 
0065C9DD4  ldr      x8, [x1, #0x60]
0065C9DD8  mov      x0, x19
0065C9DDC  blr      x8
0065C9DE0  mov      x20, x0
0065C9DE4  cbz      x20, #0x65ca5a4
0065C9DE8  ldrb     w8, [x29, #0x63b]
0065C9DEC  cbnz     w8, #0x65c9e04
0065C9DF0  adrp     x0, #0x8f0a000
0065C9DF4  ldr      x0, [x0, #0x490]
0065C9DF8  bl       #0x382bd14 ; 
0065C9DFC  mov      w8, #1
0065C9E00  strb     w8, [x29, #0x63b]
0065C9E04  ldr      x1, [x24]
0065C9E08  ldrb     w8, [x1, #0x53]
0065C9E0C  tbnz     w8, #5, #0x65c9e24
0065C9E10  add      x1, x20, #0x290
0065C9E14  add      x0, sp, #0x130
0065C9E18  mov      w2, #0xb0
0065C9E1C  bl       #0x89edad0 ; 
0065C9E20  b        #0x65c9e34 ; 
0065C9E24  ldr      x9, [x1, #0x60]
0065C9E28  add      x8, sp, #0x130
0065C9E2C  mov      x0, x20
0065C9E30  blr      x9
0065C9E34  ldrb     w8, [x22, #0x286]
0065C9E38  ldr      w9, [sp, #0x178]
0065C9E3C  str      w9, [sp, #0xd8]
0065C9E40  cbnz     w8, #0x65c9e58
0065C9E44  adrp     x0, #0x8f07000
0065C9E48  ldr      x0, [x0, #0xc98]
0065C9E4C  bl       #0x382bd14 ; 
0065C9E50  mov      w8, #1
0065C9E54  strb     w8, [x22, #0x286]
0065C9E58  ldr      x1, [x23]
0065C9E5C  ldrb     w8, [x1, #0x53]
0065C9E60  tbnz     w8, #5, #0x65c9e6c
0065C9E64  ldr      x20, [x19, #0x80]
0065C9E68  b        #0x65c9e7c ; 
0065C9E6C  ldr      x8, [x1, #0x60]
0065C9E70  mov      x0, x19
0065C9E74  blr      x8
0065C9E78  mov      x20, x0
0065C9E7C  cbz      x20, #0x65ca5a4
0065C9E80  ldrb     w8, [x29, #0x63b]
0065C9E84  cbnz     w8, #0x65c9e9c
0065C9E88  adrp     x0, #0x8f0a000
0065C9E8C  ldr      x0, [x0, #0x490]
0065C9E90  bl       #0x382bd14 ; 
0065C9E94  mov      w8, #1
0065C9E98  strb     w8, [x29, #0x63b]
0065C9E9C  ldr      x1, [x24]
0065C9EA0  ldrb     w8, [x1, #0x53]
0065C9EA4  tbnz     w8, #5, #0x65c9ebc
0065C9EA8  add      x1, x20, #0x290
0065C9EAC  add      x0, sp, #0x130
0065C9EB0  mov      w2, #0xb0
0065C9EB4  bl       #0x89edad0 ; 
0065C9EB8  b        #0x65c9ecc ; 
0065C9EBC  ldr      x9, [x1, #0x60]
0065C9EC0  add      x8, sp, #0x130
0065C9EC4  mov      x0, x20
0065C9EC8  blr      x9
0065C9ECC  ldrb     w8, [x22, #0x286]
0065C9ED0  ldr      w9, [sp, #0x174]
0065C9ED4  str      w9, [sp, #0xd4]
0065C9ED8  cbnz     w8, #0x65c9ef0
0065C9EDC  adrp     x0, #0x8f07000
0065C9EE0  ldr      x0, [x0, #0xc98]
0065C9EE4  bl       #0x382bd14 ; 
0065C9EE8  mov      w8, #1
0065C9EEC  strb     w8, [x22, #0x286]
0065C9EF0  ldr      x1, [x23]
0065C9EF4  ldrb     w8, [x1, #0x53]
0065C9EF8  tbnz     w8, #5, #0x65c9f04
0065C9EFC  ldr      x20, [x19, #0x80]
0065C9F00  b        #0x65c9f14 ; 
0065C9F04  ldr      x8, [x1, #0x60]
0065C9F08  mov      x0, x19
0065C9F0C  blr      x8
0065C9F10  mov      x20, x0
0065C9F14  cbz      x20, #0x65ca5a4
0065C9F18  ldrb     w8, [x29, #0x63b]
0065C9F1C  cbnz     w8, #0x65c9f34
0065C9F20  adrp     x0, #0x8f0a000
0065C9F24  ldr      x0, [x0, #0x490]
0065C9F28  bl       #0x382bd14 ; 
0065C9F2C  mov      w8, #1
0065C9F30  strb     w8, [x29, #0x63b]
0065C9F34  ldr      x1, [x24]
0065C9F38  str      w25, [sp, #0xd0]
0065C9F3C  str      x26, [sp, #0xc8]
0065C9F40  ldrb     w8, [x1, #0x53]
0065C9F44  tbnz     w8, #5, #0x65c9f5c
0065C9F48  add      x1, x20, #0x290
0065C9F4C  add      x0, sp, #0x130
0065C9F50  mov      w2, #0xb0
0065C9F54  bl       #0x89edad0 ; 
0065C9F58  b        #0x65c9f6c ; 
0065C9F5C  ldr      x9, [x1, #0x60]
0065C9F60  add      x8, sp, #0x130
0065C9F64  mov      x0, x20
0065C9F68  blr      x9
0065C9F6C  ldr      w26, [sp, #0x1cc]
0065C9F70  mov      w25, w28
0065C9F74  cbz      x21, #0x65c9f94
0065C9F78  adrp     x8, #0x8ef7000
0065C9F7C  ldr      x8, [x8, #0xb78]
0065C9F80  mov      x0, x21
0065C9F84  ldr      x1, [x8]
0065C9F88  bl       #0x4db1cf0 ; System.Collections.Generic.List<object>$$ToArray
0065C9F8C  mov      x28, x0
0065C9F90  b        #0x65c9f98 ; 
0065C9F94  mov      x28, xzr
0065C9F98  ldrb     w8, [x22, #0x286]
0065C9F9C  cbnz     w8, #0x65c9fb4
0065C9FA0  adrp     x0, #0x8f07000
0065C9FA4  ldr      x0, [x0, #0xc98]
0065C9FA8  bl       #0x382bd14 ; 
0065C9FAC  mov      w8, #1
0065C9FB0  strb     w8, [x22, #0x286]
0065C9FB4  ldr      x1, [x23]
0065C9FB8  ldrb     w8, [x1, #0x53]
0065C9FBC  tbnz     w8, #5, #0x65c9fc8
0065C9FC0  ldr      x20, [x19, #0x80]
0065C9FC4  b        #0x65c9fd8 ; 
0065C9FC8  ldr      x8, [x1, #0x60]
0065C9FCC  mov      x0, x19
0065C9FD0  blr      x8
0065C9FD4  mov      x20, x0
0065C9FD8  cbz      x20, #0x65ca5a4
0065C9FDC  ldrb     w8, [x29, #0x63b]
0065C9FE0  cbnz     w8, #0x65c9ff8
0065C9FE4  adrp     x0, #0x8f0a000
0065C9FE8  ldr      x0, [x0, #0x490]
0065C9FEC  bl       #0x382bd14 ; 
0065C9FF0  mov      w8, #1
0065C9FF4  strb     w8, [x29, #0x63b]
0065C9FF8  ldr      x1, [x24]
0065C9FFC  str      x21, [sp, #0xc0]
0065CA000  ldrb     w8, [x1, #0x53]
0065CA004  tbnz     w8, #5, #0x65ca01c
0065CA008  add      x1, x20, #0x290
0065CA00C  add      x0, sp, #0x130
0065CA010  mov      w2, #0xb0
0065CA014  bl       #0x89edad0 ; 
0065CA018  b        #0x65ca02c ; 
0065CA01C  ldr      x9, [x1, #0x60]
0065CA020  add      x8, sp, #0x130
0065CA024  mov      x0, x20
0065CA028  blr      x9
0065CA02C  ldrb     w8, [x22, #0x286]
0065CA030  ldr      w21, [sp, #0x16c]
0065CA034  cbnz     w8, #0x65ca04c
0065CA038  adrp     x0, #0x8f07000
0065CA03C  ldr      x0, [x0, #0xc98]
0065CA040  bl       #0x382bd14 ; 
0065CA044  mov      w8, #1
0065CA048  strb     w8, [x22, #0x286]
0065CA04C  ldr      x1, [x23]
0065CA050  ldrb     w8, [x1, #0x53]
0065CA054  tbnz     w8, #5, #0x65ca060
0065CA058  ldr      x20, [x19, #0x80]
0065CA05C  b        #0x65ca070 ; 
0065CA060  ldr      x8, [x1, #0x60]
0065CA064  mov      x0, x19
0065CA068  blr      x8
0065CA06C  mov      x20, x0
0065CA070  cbz      x20, #0x65ca5a4
0065CA074  ldrb     w8, [x29, #0x63b]
0065CA078  cbnz     w8, #0x65ca090
0065CA07C  adrp     x0, #0x8f0a000
0065CA080  ldr      x0, [x0, #0x490]
0065CA084  bl       #0x382bd14 ; 
0065CA088  mov      w8, #1
0065CA08C  strb     w8, [x29, #0x63b]
0065CA090  ldr      x1, [x24]
0065CA094  ldrb     w8, [x1, #0x53]
0065CA098  tbnz     w8, #5, #0x65ca0b0
0065CA09C  add      x1, x20, #0x290
0065CA0A0  add      x0, sp, #0x130
0065CA0A4  mov      w2, #0xb0
0065CA0A8  bl       #0x89edad0 ; 
0065CA0AC  b        #0x65ca0c0 ; 
0065CA0B0  ldr      x9, [x1, #0x60]
0065CA0B4  add      x8, sp, #0x130
0065CA0B8  mov      x0, x20
0065CA0BC  blr      x9
0065CA0C0  ldr      x24, [sp, #0x128]
0065CA0C4  ldrb     w8, [x22, #0x286]
0065CA0C8  ldr      w20, [sp, #0x170]
0065CA0CC  adrp     x29, #0x9599000
0065CA0D0  cbnz     w8, #0x65ca0e8
0065CA0D4  adrp     x0, #0x8f07000
0065CA0D8  ldr      x0, [x0, #0xc98]
0065CA0DC  bl       #0x382bd14 ; 
0065CA0E0  mov      w8, #1
0065CA0E4  strb     w8, [x22, #0x286]
0065CA0E8  ldr      x1, [x23]
0065CA0EC  ldrb     w8, [x1, #0x53]
0065CA0F0  tbnz     w8, #5, #0x65ca0fc
0065CA0F4  ldr      x0, [x19, #0x80]
0065CA0F8  b        #0x65ca108 ; 
0065CA0FC  ldr      x8, [x1, #0x60]
0065CA100  mov      x0, x19
0065CA104  blr      x8
0065CA108  cbz      x0, #0x65ca5a4
0065CA10C  cbz      x24, #0x65ca5a4
0065CA110  ldr      x8, [x0, #0x1b0]
0065CA114  ldr      x10, [sp, #0xf0]
0065CA118  ldr      w1, [sp, #0xd0]
0065CA11C  ldr      w2, [sp, #0x11c]
0065CA120  str      x8, [sp, #0x98]
0065CA124  ldr      w8, [sp, #0xd4]
0065CA128  ldr      w3, [sp, #0x120]
0065CA12C  ldr      w4, [sp, #0x124]
0065CA130  ldr      w5, [sp, #0x110]
0065CA134  str      w8, [sp, #0x68]
0065CA138  ldr      w8, [sp, #0xd8]
0065CA13C  ldr      w6, [sp, #0x10c]
0065CA140  lsr      x9, x27, #0x10
0065CA144  mov      x0, x24
0065CA148  str      w8, [sp, #0x60]
0065CA14C  ldr      w8, [sp, #0xdc]
0065CA150  mov      w7, w25
0065CA154  str      xzr, [sp, #0xa8]
0065CA158  str      wzr, [sp, #0xa0]
0065CA15C  str      w8, [sp, #0x58]
0065CA160  ldr      w8, [sp, #0xe0]
0065CA164  str      w20, [sp, #0x90]
0065CA168  str      w21, [sp, #0x88]
0065CA16C  str      x28, [sp, #0x80]
0065CA170  str      w8, [sp, #0x50]
0065CA174  ldr      w8, [sp, #0xe4]
0065CA178  str      w9, [sp, #0x78]
0065CA17C  str      w26, [sp, #0x70]
0065CA180  str      wzr, [sp, #0x10]
0065CA184  str      w8, [sp, #0x48]
0065CA188  ldr      w8, [sp, #0xe8]
0065CA18C  str      w8, [sp, #0x40]
0065CA190  ldr      w8, [sp, #0xec]
0065CA194  str      w8, [sp, #0x38]
0065CA198  ldr      x8, [sp, #0x100]
0065CA19C  stp      x8, x10, [sp, #0x28]
0065CA1A0  ldr      x8, [sp, #0xc8]
0065CA1A4  str      x8, [sp, #0x20]
0065CA1A8  ldr      w8, [sp, #0xfc]
0065CA1AC  str      w8, [sp, #0x18]
0065CA1B0  ldr      w8, [sp, #0x114]
0065CA1B4  str      w8, [sp, #8]
0065CA1B8  ldr      w8, [sp, #0x118]
0065CA1BC  str      w8, [sp]
0065CA1C0  bl       #0x6a4eb34 ; HotFix.BattleLogic.BattleSaveData$$SaveAllBattleData
0065CA1C4  ldrb     w8, [x22, #0x286]
0065CA1C8  cbnz     w8, #0x65ca1e0
0065CA1CC  adrp     x0, #0x8f07000
0065CA1D0  ldr      x0, [x0, #0xc98]
0065CA1D4  bl       #0x382bd14 ; 
0065CA1D8  mov      w8, #1
0065CA1DC  strb     w8, [x22, #0x286]
0065CA1E0  ldr      x1, [x23]
0065CA1E4  ldrb     w8, [x1, #0x53]
0065CA1E8  tbnz     w8, #5, #0x65ca1f4
0065CA1EC  ldr      x0, [x19, #0x80]
0065CA1F0  b        #0x65ca200 ; 
0065CA1F4  ldr      x8, [x1, #0x60]
0065CA1F8  mov      x0, x19
0065CA1FC  blr      x8
0065CA200  cbz      x0, #0x65ca5a4
0065CA204  mov      w1, #1
0065CA208  mov      x2, xzr
0065CA20C  mov      w20, #1
0065CA210  bl       #0x6a21b1c ; HotFix.BattleLogic.BattleWorldContext$$LogEntityAttr
0065CA214  ldrb     w8, [x22, #0x286]
0065CA218  cbnz     w8, #0x65ca22c
0065CA21C  adrp     x0, #0x8f07000
0065CA220  ldr      x0, [x0, #0xc98]
0065CA224  bl       #0x382bd14 ; 
0065CA228  strb     w20, [x22, #0x286]
0065CA22C  ldr      x1, [x23]
0065CA230  ldrb     w8, [x1, #0x53]
0065CA234  tbnz     w8, #5, #0x65ca240
0065CA238  ldr      x0, [x19, #0x80]
0065CA23C  b        #0x65ca24c ; 
0065CA240  ldr      x8, [x1, #0x60]
0065CA244  mov      x0, x19
0065CA248  blr      x8
0065CA24C  cbz      x0, #0x65ca5a4
0065CA250  ldr      x8, [x0, #0x3b0]
0065CA254  cbz      x8, #0x65ca584
0065CA258  ldrb     w8, [x22, #0x286]
0065CA25C  cbnz     w8, #0x65ca274
0065CA260  adrp     x0, #0x8f07000
0065CA264  ldr      x0, [x0, #0xc98]
0065CA268  bl       #0x382bd14 ; 
0065CA26C  mov      w8, #1
0065CA270  strb     w8, [x22, #0x286]
0065CA274  ldr      x1, [x23]
0065CA278  ldrb     w8, [x1, #0x53]
0065CA27C  tbnz     w8, #5, #0x65ca28c
0065CA280  ldr      x21, [x19, #0x80]
0065CA284  mov      w8, #1
0065CA288  b        #0x65ca2a0 ; 
0065CA28C  ldr      x8, [x1, #0x60]
0065CA290  mov      x0, x19
0065CA294  blr      x8
0065CA298  ldrb     w8, [x22, #0x286]
0065CA29C  mov      x21, x0
0065CA2A0  adrp     x9, #0x8f08000
0065CA2A4  ldr      x9, [x9, #0x590]
0065CA2A8  adrp     x10, #0x8ee6000
0065CA2AC  adrp     x11, #0x8f08000
0065CA2B0  ldr      x9, [x9]
0065CA2B4  ldr      x10, [x10, #0x610]
0065CA2B8  ldr      x10, [x10]
0065CA2BC  ldr      x11, [x11, #0x5a0]
0065CA2C0  ldr      x9, [x9, #0xb8]
0065CA2C4  ldr      w25, [x19, #0x12c]
0065CA2C8  ldr      x10, [x10, #0xb8]
0065CA2CC  ldr      x11, [x11]
0065CA2D0  ldp      w24, w12, [x9, #4]
0065CA2D4  ldr      w20, [x9]
0065CA2D8  ldr      w28, [x10]
0065CA2DC  ldr      x11, [x11, #0xb8]
0065CA2E0  str      w12, [sp, #0x128]
0065CA2E4  ldr      w9, [x11, #8]
0065CA2E8  ldp      w26, w27, [x11]
0065CA2EC  str      w9, [sp, #0x124]
0065CA2F0  ldr      w9, [x11, #0xc]
0065CA2F4  str      w9, [sp, #0x120]
0065CA2F8  cbnz     w8, #0x65ca310
0065CA2FC  adrp     x0, #0x8f07000
0065CA300  ldr      x0, [x0, #0xc98]
0065CA304  bl       #0x382bd14 ; 
0065CA308  mov      w8, #1
0065CA30C  strb     w8, [x22, #0x286]
0065CA310  ldr      x1, [x23]
0065CA314  ldrb     w8, [x1, #0x53]
0065CA318  tbnz     w8, #5, #0x65ca324
0065CA31C  ldr      x0, [x19, #0x80]
0065CA320  b        #0x65ca330 ; 
0065CA324  ldr      x8, [x1, #0x60]
0065CA328  mov      x0, x19
0065CA32C  blr      x8
0065CA330  cbz      x0, #0x65ca5a4
0065CA334  ldr      x0, [x0, #0x1d0]
0065CA338  str      w20, [sp, #0x11c]
0065CA33C  cbz      x0, #0x65ca5a4
0065CA340  mov      x1, xzr
0065CA344  bl       #0x6a31e00 ; HotFix.BattleLogic.WorldInitInfo$$GetPlayerInfo
0065CA348  cbz      x0, #0x65ca5a4
0065CA34C  ldrb     w8, [x29, #0x650]
0065CA350  mov      x20, x0
0065CA354  cbnz     w8, #0x65ca36c
0065CA358  adrp     x0, #0x8f0a000
0065CA35C  ldr      x0, [x0, #0x7b0]
0065CA360  bl       #0x382bd14 ; 
0065CA364  mov      w8, #1
0065CA368  strb     w8, [x29, #0x650]
0065CA36C  adrp     x8, #0x8f0a000
0065CA370  ldr      x8, [x8, #0x7b0]
0065CA374  ldr      x1, [x8]
0065CA378  ldrb     w8, [x1, #0x53]
0065CA37C  tbnz     w8, #5, #0x65ca388
0065CA380  ldr      w29, [x20, #0x14]
0065CA384  b        #0x65ca398 ; 
0065CA388  ldr      x8, [x1, #0x60]
0065CA38C  mov      x0, x20
0065CA390  blr      x8
0065CA394  mov      w29, w0
0065CA398  ldrb     w8, [x22, #0x286]
0065CA39C  adrp     x20, #0x9591000
0065CA3A0  cbnz     w8, #0x65ca3b8
0065CA3A4  adrp     x0, #0x8f07000
0065CA3A8  ldr      x0, [x0, #0xc98]
0065CA3AC  bl       #0x382bd14 ; 
0065CA3B0  mov      w8, #1
0065CA3B4  strb     w8, [x22, #0x286]
0065CA3B8  ldr      x1, [x23]
0065CA3BC  ldrb     w8, [x1, #0x53]
0065CA3C0  tbnz     w8, #5, #0x65ca3cc
0065CA3C4  ldr      x19, [x19, #0x80]
0065CA3C8  b        #0x65ca3dc ; 
0065CA3CC  ldr      x8, [x1, #0x60]
0065CA3D0  mov      x0, x19
0065CA3D4  blr      x8
0065CA3D8  mov      x19, x0
0065CA3DC  adrp     x22, #0x9599000
0065CA3E0  cbz      x19, #0x65ca5a4
0065CA3E4  ldrb     w8, [x20, #0xa62]
0065CA3E8  cbnz     w8, #0x65ca400
0065CA3EC  adrp     x0, #0x8ee6000
0065CA3F0  ldr      x0, [x0, #0x1f8]
0065CA3F4  bl       #0x382bd14 ; 
0065CA3F8  mov      w8, #1
0065CA3FC  strb     w8, [x20, #0xa62]
0065CA400  adrp     x8, #0x8ee6000
0065CA404  ldr      x8, [x8, #0x1f8]
0065CA408  ldr      x1, [x8]
0065CA40C  ldrb     w8, [x1, #0x53]
0065CA410  tbnz     w8, #5, #0x65ca41c
0065CA414  ldr      x0, [x19, #0x1f8]
0065CA418  b        #0x65ca428 ; 
0065CA41C  ldr      x8, [x1, #0x60]
0065CA420  mov      x0, x19
0065CA424  blr      x8
0065CA428  adrp     x20, #0x9599000
0065CA42C  cbz      x0, #0x65ca5a4
0065CA430  mov      w1, #1
0065CA434  mov      x2, xzr
0065CA438  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
0065CA43C  cbz      x0, #0x65ca5a4
0065CA440  adrp     x8, #0x8f07000
0065CA444  ldr      x8, [x8, #0xe68]
0065CA448  ldr      x1, [x8]
0065CA44C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065CA450  cbz      x0, #0x65ca5a4
0065CA454  ldrb     w8, [x20, #0x4c7]
0065CA458  mov      x19, x0
0065CA45C  cbnz     w8, #0x65ca474
0065CA460  adrp     x0, #0x8f09000
0065CA464  ldr      x0, [x0, #0xc8]
0065CA468  bl       #0x382bd14 ; 
0065CA46C  mov      w8, #1
0065CA470  strb     w8, [x20, #0x4c7]
0065CA474  adrp     x8, #0x8f09000
0065CA478  ldr      x8, [x8, #0xc8]
0065CA47C  ldr      x1, [x8]
0065CA480  ldrb     w8, [x1, #0x53]
0065CA484  tbnz     w8, #5, #0x65ca490
0065CA488  ldr      x19, [x19, #0x58]
0065CA48C  b        #0x65ca4a0 ; 
0065CA490  ldr      x8, [x1, #0x60]
0065CA494  mov      x0, x19
0065CA498  blr      x8
0065CA49C  mov      x19, x0
0065CA4A0  adrp     x20, #0x8f0a000
0065CA4A4  ldr      x20, [x20, #0x7a8]
0065CA4A8  ldr      x0, [x20]
0065CA4AC  ldr      w8, [x0, #0xe0]
0065CA4B0  cbnz     w8, #0x65ca4b8
0065CA4B4  bl       #0x382be8c ; 
0065CA4B8  ldrb     w8, [x22, #0x651]
0065CA4BC  cbnz     w8, #0x65ca4e0
0065CA4C0  adrp     x0, #0x8f0a000
0065CA4C4  ldr      x0, [x0, #0x7b8]
0065CA4C8  bl       #0x382bd14 ; 
0065CA4CC  adrp     x0, #0x8f0a000
0065CA4D0  ldr      x0, [x0, #0x7a8]
0065CA4D4  bl       #0x382bd14 ; 
0065CA4D8  mov      w8, #1
0065CA4DC  strb     w8, [x22, #0x651]
0065CA4E0  adrp     x8, #0x8f0a000
0065CA4E4  ldr      x8, [x8, #0x7b8]
0065CA4E8  ldr      x0, [x8]
0065CA4EC  ldrb     w8, [x0, #0x53]
0065CA4F0  tbnz     w8, #5, #0x65ca514
0065CA4F4  ldr      x0, [x20]
0065CA4F8  ldr      w8, [x0, #0xe0]
0065CA4FC  cbnz     w8, #0x65ca508
0065CA500  bl       #0x382be8c ; 
0065CA504  ldr      x0, [x20]
0065CA508  ldr      x8, [x0, #0xb8]
0065CA50C  ldr      x20, [x8, #8]
0065CA510  b        #0x65ca520 ; 
0065CA514  ldr      x8, [x0, #0x60]
0065CA518  blr      x8
0065CA51C  mov      x20, x0
0065CA520  ldr      x0, [sp, #0xc0]
0065CA524  cbz      x0, #0x65ca538
0065CA528  adrp     x8, #0x8ef7000
0065CA52C  ldr      x8, [x8, #0xb78]
0065CA530  ldr      x1, [x8]
0065CA534  bl       #0x4db1cf0 ; System.Collections.Generic.List<object>$$ToArray
0065CA538  cbz      x21, #0x65ca5a4
0065CA53C  ldr      w8, [sp, #0x120]
0065CA540  ldr      w2, [sp, #0x128]
0065CA544  ldr      w3, [sp, #0x11c]
0065CA548  stp      x0, xzr, [sp, #0x38]
0065CA54C  str      w8, [sp, #8]
0065CA550  ldr      w8, [sp, #0x124]
0065CA554  mov      x0, x21
0065CA558  mov      w1, w25
0065CA55C  mov      w4, w24
0065CA560  mov      w5, w28
0065CA564  mov      w6, w27
0065CA568  mov      w7, w26
0065CA56C  strb     wzr, [sp, #0x30]
0065CA570  stp      x19, x20, [sp, #0x20]
0065CA574  str      w29, [sp, #0x18]
0065CA578  str      wzr, [sp, #0x10]
0065CA57C  str      w8, [sp]
0065CA580  bl       #0x6a09d58 ; HotFix.BattleLogic.BattleWorldContext$$DispatchUploadBattleDataEvent
0065CA584  add      sp, sp, #0x290
0065CA588  ldp      x20, x19, [sp, #0x50]
0065CA58C  ldp      x22, x21, [sp, #0x40]
0065CA590  ldp      x24, x23, [sp, #0x30]
0065CA594  ldp      x26, x25, [sp, #0x20]
0065CA598  ldp      x28, x27, [sp, #0x10]
0065CA59C  ldp      x29, x30, [sp], #0x60
0065CA5A0  ret      
0065CA5A4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$TrackerWaveEvent
; RVA 0x65CA5A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CA5A8  str      x30, [sp, #-0x40]!
0065CA5AC  stp      x24, x23, [sp, #0x10]
0065CA5B0  stp      x22, x21, [sp, #0x20]
0065CA5B4  stp      x20, x19, [sp, #0x30]
0065CA5B8  adrp     x20, #0x9599000
0065CA5BC  adrp     x22, #0x8f0a000
0065CA5C0  ldrb     w8, [x20, #0x578]
0065CA5C4  ldr      x22, [x22, #0x7c0]
0065CA5C8  mov      w21, w1
0065CA5CC  mov      x19, x0
0065CA5D0  tbnz     w8, #0, #0x65ca600
0065CA5D4  adrp     x0, #0x8f0a000
0065CA5D8  ldr      x0, [x0, #0x7c8]
0065CA5DC  bl       #0x382bd14 ; 
0065CA5E0  adrp     x0, #0x8f0a000
0065CA5E4  ldr      x0, [x0, #0x7d0]
0065CA5E8  bl       #0x382bd14 ; 
0065CA5EC  adrp     x0, #0x8f0a000
0065CA5F0  ldr      x0, [x0, #0x7c0]
0065CA5F4  bl       #0x382bd14 ; 
0065CA5F8  mov      w8, #1
0065CA5FC  strb     w8, [x20, #0x578]
0065CA600  ldr      x2, [x22]
0065CA604  ldrb     w8, [x2, #0x53]
0065CA608  tbnz     w8, #5, #0x65ca648
0065CA60C  adrp     x22, #0x9599000
0065CA610  ldrb     w8, [x22, #0x286]
0065CA614  cbnz     w8, #0x65ca62c
0065CA618  adrp     x0, #0x8f07000
0065CA61C  ldr      x0, [x0, #0xc98]
0065CA620  bl       #0x382bd14 ; 
0065CA624  mov      w8, #1
0065CA628  strb     w8, [x22, #0x286]
0065CA62C  adrp     x23, #0x8f07000
0065CA630  ldr      x23, [x23, #0xc98]
0065CA634  ldr      x1, [x23]
0065CA638  ldrb     w8, [x1, #0x53]
0065CA63C  tbnz     w8, #5, #0x65ca668
0065CA640  ldr      x20, [x19, #0x80]
0065CA644  b        #0x65ca678 ; 
0065CA648  ldr      x3, [x2, #0x60]
0065CA64C  and      w1, w21, #1
0065CA650  mov      x0, x19
0065CA654  ldp      x20, x19, [sp, #0x30]
0065CA658  ldp      x22, x21, [sp, #0x20]
0065CA65C  ldp      x24, x23, [sp, #0x10]
0065CA660  ldr      x30, [sp], #0x40
0065CA664  br       x3
0065CA668  ldr      x8, [x1, #0x60]
0065CA66C  mov      x0, x19
0065CA670  blr      x8
0065CA674  mov      x20, x0
0065CA678  cbz      x20, #0x65ca824
0065CA67C  adrp     x24, #0x9591000
0065CA680  ldrb     w8, [x24, #0xa61]
0065CA684  cbnz     w8, #0x65ca69c
0065CA688  adrp     x0, #0x8ee6000
0065CA68C  ldr      x0, [x0, #0x308]
0065CA690  bl       #0x382bd14 ; 
0065CA694  mov      w8, #1
0065CA698  strb     w8, [x24, #0xa61]
0065CA69C  adrp     x8, #0x8ee6000
0065CA6A0  ldr      x8, [x8, #0x308]
0065CA6A4  ldr      x1, [x8]
0065CA6A8  ldrb     w8, [x1, #0x53]
0065CA6AC  tbnz     w8, #5, #0x65ca6b8
0065CA6B0  ldr      x0, [x20, #0x1e8]
0065CA6B4  b        #0x65ca6c4 ; 
0065CA6B8  ldr      x8, [x1, #0x60]
0065CA6BC  mov      x0, x20
0065CA6C0  blr      x8
0065CA6C4  cbz      x0, #0x65ca824
0065CA6C8  adrp     x8, #0x8f0a000
0065CA6CC  ldr      x8, [x8, #0x7d0]
0065CA6D0  ldr      x1, [x8]
0065CA6D4  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065CA6D8  adrp     x24, #0x9599000
0065CA6DC  ldrb     w8, [x24, #0x652]
0065CA6E0  mov      x20, x0
0065CA6E4  cbnz     w8, #0x65ca6fc
0065CA6E8  adrp     x0, #0x8f0a000
0065CA6EC  ldr      x0, [x0, #0x668]
0065CA6F0  bl       #0x382bd14 ; 
0065CA6F4  mov      w8, #1
0065CA6F8  strb     w8, [x24, #0x652]
0065CA6FC  adrp     x8, #0x8f0a000
0065CA700  ldr      x8, [x8, #0x668]
0065CA704  ldr      x1, [x8]
0065CA708  ldrb     w8, [x1, #0x53]
0065CA70C  tbnz     w8, #5, #0x65ca718
0065CA710  ldr      w0, [x19, #0x12c]
0065CA714  b        #0x65ca724 ; 
0065CA718  ldr      x8, [x1, #0x60]
0065CA71C  mov      x0, x19
0065CA720  blr      x8
0065CA724  cbz      x20, #0x65ca824
0065CA728  and      w8, w21, #1
0065CA72C  add      w8, w0, w8
0065CA730  str      w8, [x20, #0x20]
0065CA734  ldr      x0, [x19, #0x88]
0065CA738  cbz      x0, #0x65ca824
0065CA73C  ldr      x8, [x0]
0065CA740  ldr      x9, [x8, #0x498]
0065CA744  ldr      x1, [x8, #0x4a0]
0065CA748  blr      x9
0065CA74C  str      w0, [x20, #0x24]
0065CA750  ldrb     w8, [x22, #0x286]
0065CA754  cbnz     w8, #0x65ca76c
0065CA758  adrp     x0, #0x8f07000
0065CA75C  ldr      x0, [x0, #0xc98]
0065CA760  bl       #0x382bd14 ; 
0065CA764  mov      w8, #1
0065CA768  strb     w8, [x22, #0x286]
0065CA76C  ldr      x1, [x23]
0065CA770  ldrb     w8, [x1, #0x53]
0065CA774  tbnz     w8, #5, #0x65ca780
0065CA778  ldr      x0, [x19, #0x80]
0065CA77C  b        #0x65ca78c ; 
0065CA780  ldr      x8, [x1, #0x60]
0065CA784  mov      x0, x19
0065CA788  blr      x8
0065CA78C  cbz      x0, #0x65ca824
0065CA790  ldr      x19, [x0, #0x1e0]
0065CA794  cbz      x19, #0x65ca824
0065CA798  adrp     x9, #0x8f0a000
0065CA79C  ldr      x9, [x9, #0x7c8]
0065CA7A0  ldr      x8, [x19]
0065CA7A4  ldr      x21, [x9]
0065CA7A8  ldrh     w9, [x8, #0x12e]
0065CA7AC  ldr      x1, [x21, #0x20]
0065CA7B0  ldrh     w2, [x21, #0x50]
0065CA7B4  cbz      x9, #0x65ca7d8
0065CA7B8  ldr      x10, [x8, #0xb0]
0065CA7BC  add      x10, x10, #8
0065CA7C0  ldur     x11, [x10, #-8]
0065CA7C4  cmp      x11, x1
0065CA7C8  b.eq     #0x65ca7e4
0065CA7CC  subs     x9, x9, #1
0065CA7D0  add      x10, x10, #0x10
0065CA7D4  b.ne     #0x65ca7c0
0065CA7D8  mov      x0, x19
0065CA7DC  bl       #0x3a7e710 ; 
0065CA7E0  b        #0x65ca7f4 ; 
0065CA7E4  ldr      w9, [x10]
0065CA7E8  add      w9, w9, w2
0065CA7EC  add      x8, x8, w9, sxtw #4
0065CA7F0  add      x0, x8, #0x138
0065CA7F4  ldr      x0, [x0, #8]
0065CA7F8  mov      x1, x21
0065CA7FC  bl       #0x382be88 ; 
0065CA800  mov      x2, x0
0065CA804  ldr      x3, [x0, #8]
0065CA808  mov      x0, x19
0065CA80C  mov      x1, x20
0065CA810  ldp      x20, x19, [sp, #0x30]
0065CA814  ldp      x22, x21, [sp, #0x20]
0065CA818  ldp      x24, x23, [sp, #0x10]
0065CA81C  ldr      x30, [sp], #0x40
0065CA820  br       x3
0065CA824  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$AddExpAndGold
; RVA 0x65CA828; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CA828  str      x30, [sp, #-0x50]!
0065CA82C  stp      x26, x25, [sp, #0x10]
0065CA830  stp      x24, x23, [sp, #0x20]
0065CA834  stp      x22, x21, [sp, #0x30]
0065CA838  stp      x20, x19, [sp, #0x40]
0065CA83C  adrp     x20, #0x9599000
0065CA840  adrp     x21, #0x8f0a000
0065CA844  ldrb     w8, [x20, #0x579]
0065CA848  ldr      x21, [x21, #0x7d8]
0065CA84C  mov      x19, x0
0065CA850  tbnz     w8, #0, #0x65ca88c
0065CA854  adrp     x0, #0x8ee6000
0065CA858  ldr      x0, [x0, #0xd8]
0065CA85C  bl       #0x382bd14 ; 
0065CA860  adrp     x0, #0x8f09000
0065CA864  ldr      x0, [x0, #0xc08]
0065CA868  bl       #0x382bd14 ; 
0065CA86C  adrp     x0, #0x8f0a000
0065CA870  ldr      x0, [x0, #0x7d8]
0065CA874  bl       #0x382bd14 ; 
0065CA878  adrp     x0, #0x8f09000
0065CA87C  ldr      x0, [x0, #0xfe8]
0065CA880  bl       #0x382bd14 ; 
0065CA884  mov      w8, #1
0065CA888  strb     w8, [x20, #0x579]
0065CA88C  ldr      x1, [x21]
0065CA890  ldrb     w8, [x1, #0x53]
0065CA894  tbnz     w8, #5, #0x65ca8ec
0065CA898  ldr      x20, [x19, #0x188]
0065CA89C  cbz      x20, #0x65cad10
0065CA8A0  adrp     x21, #0x8f09000
0065CA8A4  ldr      x8, [x20]
0065CA8A8  ldr      w22, [x19, #0x134]
0065CA8AC  ldr      x21, [x21, #0xc08]
0065CA8B0  ldrh     w9, [x8, #0x12e]
0065CA8B4  ldr      x1, [x21]
0065CA8B8  cbz      x9, #0x65ca8dc
0065CA8BC  ldr      x10, [x8, #0xb0]
0065CA8C0  add      x10, x10, #8
0065CA8C4  ldur     x11, [x10, #-8]
0065CA8C8  cmp      x11, x1
0065CA8CC  b.eq     #0x65ca90c
0065CA8D0  subs     x9, x9, #1
0065CA8D4  add      x10, x10, #0x10
0065CA8D8  b.ne     #0x65ca8c4
0065CA8DC  mov      x0, x20
0065CA8E0  mov      w2, wzr
0065CA8E4  bl       #0x3a7e710 ; 
0065CA8E8  b        #0x65ca918 ; 
0065CA8EC  ldr      x2, [x1, #0x60]
0065CA8F0  mov      x0, x19
0065CA8F4  ldp      x20, x19, [sp, #0x40]
0065CA8F8  ldp      x22, x21, [sp, #0x30]
0065CA8FC  ldp      x24, x23, [sp, #0x20]
0065CA900  ldp      x26, x25, [sp, #0x10]
0065CA904  ldr      x30, [sp], #0x50
0065CA908  br       x2
0065CA90C  ldrsw    x9, [x10]
0065CA910  add      x8, x8, x9, lsl #4
0065CA914  add      x0, x8, #0x138
0065CA918  ldp      x8, x1, [x0]
0065CA91C  mov      x0, x20
0065CA920  blr      x8
0065CA924  cmp      w22, w0
0065CA928  b.eq     #0x65ca998
0065CA92C  ldr      x20, [x19, #0x188]
0065CA930  cbz      x20, #0x65cad10
0065CA934  ldr      x8, [x20]
0065CA938  ldr      x1, [x21]
0065CA93C  ldrh     w9, [x8, #0x12e]
0065CA940  cbz      x9, #0x65ca964
0065CA944  ldr      x10, [x8, #0xb0]
0065CA948  add      x10, x10, #8
0065CA94C  ldur     x11, [x10, #-8]
0065CA950  cmp      x11, x1
0065CA954  b.eq     #0x65ca974
0065CA958  subs     x9, x9, #1
0065CA95C  add      x10, x10, #0x10
0065CA960  b.ne     #0x65ca94c
0065CA964  mov      w2, #2
0065CA968  mov      x0, x20
0065CA96C  bl       #0x3a7e710 ; 
0065CA970  b        #0x65ca984 ; 
0065CA974  ldr      w9, [x10]
0065CA978  add      w9, w9, #2
0065CA97C  add      x8, x8, w9, sxtw #4
0065CA980  add      x0, x8, #0x138
0065CA984  ldp      x8, x1, [x0]
0065CA988  mov      x0, x20
0065CA98C  blr      x8
0065CA990  cmp      w0, #1
0065CA994  b.ne     #0x65ca9b0
0065CA998  ldp      x20, x19, [sp, #0x40]
0065CA99C  ldp      x22, x21, [sp, #0x30]
0065CA9A0  ldp      x24, x23, [sp, #0x20]
0065CA9A4  ldp      x26, x25, [sp, #0x10]
0065CA9A8  ldr      x30, [sp], #0x50
0065CA9AC  ret      
0065CA9B0  adrp     x23, #0x9599000
0065CA9B4  ldrb     w8, [x23, #0x286]
0065CA9B8  cbnz     w8, #0x65ca9d0
0065CA9BC  adrp     x0, #0x8f07000
0065CA9C0  ldr      x0, [x0, #0xc98]
0065CA9C4  bl       #0x382bd14 ; 
0065CA9C8  mov      w8, #1
0065CA9CC  strb     w8, [x23, #0x286]
0065CA9D0  adrp     x24, #0x8f07000
0065CA9D4  ldr      x24, [x24, #0xc98]
0065CA9D8  ldr      x1, [x24]
0065CA9DC  ldrb     w8, [x1, #0x53]
0065CA9E0  tbnz     w8, #5, #0x65ca9ec
0065CA9E4  ldr      x20, [x19, #0x80]
0065CA9E8  b        #0x65ca9fc ; 
0065CA9EC  ldr      x8, [x1, #0x60]
0065CA9F0  mov      x0, x19
0065CA9F4  blr      x8
0065CA9F8  mov      x20, x0
0065CA9FC  cbz      x20, #0x65cad10
0065CAA00  adrp     x22, #0x9599000
0065CAA04  ldrb     w8, [x22, #0x287]
0065CAA08  cbnz     w8, #0x65caa20
0065CAA0C  adrp     x0, #0x8f07000
0065CAA10  ldr      x0, [x0, #0xcf0]
0065CAA14  bl       #0x382bd14 ; 
0065CAA18  mov      w8, #1
0065CAA1C  strb     w8, [x22, #0x287]
0065CAA20  adrp     x25, #0x8f07000
0065CAA24  ldr      x25, [x25, #0xcf0]
0065CAA28  ldr      x1, [x25]
0065CAA2C  ldrb     w8, [x1, #0x53]
0065CAA30  tbnz     w8, #5, #0x65caa3c
0065CAA34  ldr      x0, [x20, #0x350]
0065CAA38  b        #0x65caa48 ; 
0065CAA3C  ldr      x8, [x1, #0x60]
0065CAA40  mov      x0, x20
0065CAA44  blr      x8
0065CAA48  cbz      x0, #0x65cad10
0065CAA4C  ldr      x8, [x0]
0065CAA50  ldp      x9, x1, [x8, #0x1b8]
0065CAA54  blr      x9
0065CAA58  ldr      x8, [x19, #0x88]
0065CAA5C  cbz      x8, #0x65cad10
0065CAA60  adrp     x9, #0x8ee6000
0065CAA64  ldr      x9, [x9, #0xd8]
0065CAA68  mov      w20, w0
0065CAA6C  ldr      x1, [x9]
0065CAA70  ldrb     w9, [x1, #0x53]
0065CAA74  tbnz     w9, #5, #0x65caa80
0065CAA78  ldr      x21, [x8, #0x38]
0065CAA7C  b        #0x65caa90 ; 
0065CAA80  ldr      x9, [x1, #0x60]
0065CAA84  mov      x0, x8
0065CAA88  blr      x9
0065CAA8C  mov      x21, x0
0065CAA90  cbz      x21, #0x65cad10
0065CAA94  adrp     x26, #0x9591000
0065CAA98  ldrb     w8, [x26, #0xa7f]
0065CAA9C  cbnz     w8, #0x65caab4
0065CAAA0  adrp     x0, #0x8ee6000
0065CAAA4  ldr      x0, [x0, #0x2d8]
0065CAAA8  bl       #0x382bd14 ; 
0065CAAAC  mov      w8, #1
0065CAAB0  strb     w8, [x26, #0xa7f]
0065CAAB4  adrp     x8, #0x8ee6000
0065CAAB8  ldr      x8, [x8, #0x2d8]
0065CAABC  ldr      x1, [x8]
0065CAAC0  ldrb     w8, [x1, #0x53]
0065CAAC4  tbnz     w8, #5, #0x65caad0
0065CAAC8  ldr      x0, [x21, #0x178]
0065CAACC  b        #0x65caadc ; 
0065CAAD0  ldr      x8, [x1, #0x60]
0065CAAD4  mov      x0, x21
0065CAAD8  blr      x8
0065CAADC  cbz      x0, #0x65cad10
0065CAAE0  adrp     x8, #0x8f09000
0065CAAE4  ldr      x8, [x8, #0xfe8]
0065CAAE8  mov      x2, xzr
0065CAAEC  ldr      x1, [x8]
0065CAAF0  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
0065CAAF4  add      x8, x0, #0x10, lsl #12
0065CAAF8  sxtw     x9, w20
0065CAAFC  mul      x0, x8, x9
0065CAB00  mov      x1, xzr
0065CAB04  bl       #0x7d46e84 ; Photon.Deterministic.FPMath$$CeilToInt
0065CAB08  ldrb     w8, [x23, #0x286]
0065CAB0C  mov      w20, w0
0065CAB10  cbnz     w8, #0x65cab28
0065CAB14  adrp     x0, #0x8f07000
0065CAB18  ldr      x0, [x0, #0xc98]
0065CAB1C  bl       #0x382bd14 ; 
0065CAB20  mov      w8, #1
0065CAB24  strb     w8, [x23, #0x286]
0065CAB28  ldr      x1, [x24]
0065CAB2C  ldrb     w8, [x1, #0x53]
0065CAB30  tbnz     w8, #5, #0x65cab3c
0065CAB34  ldr      x21, [x19, #0x80]
0065CAB38  b        #0x65cab4c ; 
0065CAB3C  ldr      x8, [x1, #0x60]
0065CAB40  mov      x0, x19
0065CAB44  blr      x8
0065CAB48  mov      x21, x0
0065CAB4C  cbz      x21, #0x65cad10
0065CAB50  adrp     x26, #0x9599000
0065CAB54  ldrb     w8, [x26, #0x4bb]
0065CAB58  cbnz     w8, #0x65cab70
0065CAB5C  adrp     x0, #0x8f08000
0065CAB60  ldr      x0, [x0, #0xe58]
0065CAB64  bl       #0x382bd14 ; 
0065CAB68  mov      w8, #1
0065CAB6C  strb     w8, [x26, #0x4bb]
0065CAB70  adrp     x8, #0x8f08000
0065CAB74  ldr      x8, [x8, #0xe58]
0065CAB78  ldr      x3, [x8]
0065CAB7C  ldrb     w8, [x3, #0x53]
0065CAB80  tbnz     w8, #5, #0x65caba8
0065CAB84  add      x0, x21, #0x290
0065CAB88  mov      w1, w20
0065CAB8C  mov      x2, xzr
0065CAB90  bl       #0x658f244 ; HotFix.BattleLogic.BattleData$$AddWaveGold
0065CAB94  mov      x0, x21
0065CAB98  mov      w1, wzr
0065CAB9C  mov      x2, xzr
0065CABA0  bl       #0x6a02274 ; HotFix.BattleLogic.BattleWorldContext$$DisPathGoldUpdateEvent
0065CABA4  b        #0x65cabbc ; 
0065CABA8  ldr      x8, [x3, #0x60]
0065CABAC  mov      x0, x21
0065CABB0  mov      w1, w20
0065CABB4  mov      w2, wzr
0065CABB8  blr      x8
0065CABBC  ldrb     w8, [x23, #0x286]
0065CABC0  cbnz     w8, #0x65cabd8
0065CABC4  adrp     x0, #0x8f07000
0065CABC8  ldr      x0, [x0, #0xc98]
0065CABCC  bl       #0x382bd14 ; 
0065CABD0  mov      w8, #1
0065CABD4  strb     w8, [x23, #0x286]
0065CABD8  ldr      x1, [x24]
0065CABDC  ldrb     w8, [x1, #0x53]
0065CABE0  tbnz     w8, #5, #0x65cabec
0065CABE4  ldr      x20, [x19, #0x80]
0065CABE8  b        #0x65cac18 ; 
0065CABEC  ldr      x8, [x1, #0x60]
0065CABF0  mov      x0, x19
0065CABF4  blr      x8
0065CABF8  ldrb     w8, [x23, #0x286]
0065CABFC  mov      x20, x0
0065CAC00  cbnz     w8, #0x65cac18
0065CAC04  adrp     x0, #0x8f07000
0065CAC08  ldr      x0, [x0, #0xc98]
0065CAC0C  bl       #0x382bd14 ; 
0065CAC10  mov      w8, #1
0065CAC14  strb     w8, [x23, #0x286]
0065CAC18  ldr      x1, [x24]
0065CAC1C  ldrb     w8, [x1, #0x53]
0065CAC20  tbnz     w8, #5, #0x65cac2c
0065CAC24  ldr      x19, [x19, #0x80]
0065CAC28  b        #0x65cac3c ; 
0065CAC2C  ldr      x8, [x1, #0x60]
0065CAC30  mov      x0, x19
0065CAC34  blr      x8
0065CAC38  mov      x19, x0
0065CAC3C  cbz      x19, #0x65cad10
0065CAC40  ldrb     w8, [x22, #0x287]
0065CAC44  cbnz     w8, #0x65cac5c
0065CAC48  adrp     x0, #0x8f07000
0065CAC4C  ldr      x0, [x0, #0xcf0]
0065CAC50  bl       #0x382bd14 ; 
0065CAC54  mov      w8, #1
0065CAC58  strb     w8, [x22, #0x287]
0065CAC5C  ldr      x1, [x25]
0065CAC60  ldrb     w8, [x1, #0x53]
0065CAC64  tbnz     w8, #5, #0x65cac70
0065CAC68  ldr      x0, [x19, #0x350]
0065CAC6C  b        #0x65cac7c ; 
0065CAC70  ldr      x8, [x1, #0x60]
0065CAC74  mov      x0, x19
0065CAC78  blr      x8
0065CAC7C  cbz      x0, #0x65cad10
0065CAC80  ldr      x8, [x0]
0065CAC84  ldp      x9, x1, [x8, #0x1c8]
0065CAC88  blr      x9
0065CAC8C  cbz      x20, #0x65cad10
0065CAC90  adrp     x21, #0x9599000
0065CAC94  ldrb     w8, [x21, #0x64a]
0065CAC98  mov      w19, w0
0065CAC9C  cbnz     w8, #0x65cacb4
0065CACA0  adrp     x0, #0x8f0a000
0065CACA4  ldr      x0, [x0, #0x5d8]
0065CACA8  bl       #0x382bd14 ; 
0065CACAC  mov      w8, #1
0065CACB0  strb     w8, [x21, #0x64a]
0065CACB4  adrp     x8, #0x8f0a000
0065CACB8  ldr      x8, [x8, #0x5d8]
0065CACBC  ldr      x2, [x8]
0065CACC0  ldrb     w8, [x2, #0x53]
0065CACC4  tbnz     w8, #5, #0x65cacec
0065CACC8  add      x0, x20, #0x290
0065CACCC  mov      w1, w19
0065CACD0  ldp      x20, x19, [sp, #0x40]
0065CACD4  ldp      x22, x21, [sp, #0x30]
0065CACD8  ldp      x24, x23, [sp, #0x20]
0065CACDC  ldp      x26, x25, [sp, #0x10]
0065CACE0  mov      x2, xzr
0065CACE4  ldr      x30, [sp], #0x50
0065CACE8  b        #0x658f450 ; HotFix.BattleLogic.BattleData$$AddUserExp
0065CACEC  ldr      x3, [x2, #0x60]
0065CACF0  mov      x0, x20
0065CACF4  mov      w1, w19
0065CACF8  ldp      x20, x19, [sp, #0x40]
0065CACFC  ldp      x22, x21, [sp, #0x30]
0065CAD00  ldp      x24, x23, [sp, #0x20]
0065CAD04  ldp      x26, x25, [sp, #0x10]
0065CAD08  ldr      x30, [sp], #0x50
0065CAD0C  br       x3
0065CAD10  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$RefreshBattleData
; RVA 0x65CAD14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CAD14  stp      x29, x30, [sp, #-0x60]!
0065CAD18  stp      x28, x27, [sp, #0x10]
0065CAD1C  stp      x26, x25, [sp, #0x20]
0065CAD20  stp      x24, x23, [sp, #0x30]
0065CAD24  stp      x22, x21, [sp, #0x40]
0065CAD28  stp      x20, x19, [sp, #0x50]
0065CAD2C  adrp     x20, #0x9599000
0065CAD30  adrp     x21, #0x8f0a000
0065CAD34  ldrb     w8, [x20, #0x57a]
0065CAD38  ldr      x21, [x21, #0x7e0]
0065CAD3C  mov      x19, x0
0065CAD40  tbnz     w8, #0, #0x65cad64
0065CAD44  adrp     x0, #0x8f09000
0065CAD48  ldr      x0, [x0, #0xc08]
0065CAD4C  bl       #0x382bd14 ; 
0065CAD50  adrp     x0, #0x8f0a000
0065CAD54  ldr      x0, [x0, #0x7e0]
0065CAD58  bl       #0x382bd14 ; 
0065CAD5C  mov      w8, #1
0065CAD60  strb     w8, [x20, #0x57a]
0065CAD64  ldr      x1, [x21]
0065CAD68  ldrb     w8, [x1, #0x53]
0065CAD6C  tbnz     w8, #5, #0x65cadb4
0065CAD70  ldr      w8, [x19, #0xe0]
0065CAD74  adrp     x23, #0x9599000
0065CAD78  str      w8, [x19, #0xe4]
0065CAD7C  ldrb     w8, [x23, #0x286]
0065CAD80  cbnz     w8, #0x65cad98
0065CAD84  adrp     x0, #0x8f07000
0065CAD88  ldr      x0, [x0, #0xc98]
0065CAD8C  bl       #0x382bd14 ; 
0065CAD90  mov      w8, #1
0065CAD94  strb     w8, [x23, #0x286]
0065CAD98  adrp     x24, #0x8f07000
0065CAD9C  ldr      x24, [x24, #0xc98]
0065CADA0  ldr      x1, [x24]
0065CADA4  ldrb     w8, [x1, #0x53]
0065CADA8  tbnz     w8, #5, #0x65cadd8
0065CADAC  ldr      x20, [x19, #0x80]
0065CADB0  b        #0x65cade8 ; 
0065CADB4  ldr      x2, [x1, #0x60]
0065CADB8  mov      x0, x19
0065CADBC  ldp      x20, x19, [sp, #0x50]
0065CADC0  ldp      x22, x21, [sp, #0x40]
0065CADC4  ldp      x24, x23, [sp, #0x30]
0065CADC8  ldp      x26, x25, [sp, #0x20]
0065CADCC  ldp      x28, x27, [sp, #0x10]
0065CADD0  ldp      x29, x30, [sp], #0x60
0065CADD4  br       x2
0065CADD8  ldr      x8, [x1, #0x60]
0065CADDC  mov      x0, x19
0065CADE0  blr      x8
0065CADE4  mov      x20, x0
0065CADE8  cbz      x20, #0x65cb630
0065CADEC  adrp     x28, #0x9598000
0065CADF0  ldrb     w8, [x28, #0xfcc]
0065CADF4  cbnz     w8, #0x65cae0c
0065CADF8  adrp     x0, #0x8f06000
0065CADFC  ldr      x0, [x0, #0x470]
0065CAE00  bl       #0x382bd14 ; 
0065CAE04  mov      w8, #1
0065CAE08  strb     w8, [x28, #0xfcc]
0065CAE0C  adrp     x29, #0x8f06000
0065CAE10  ldr      x29, [x29, #0x470]
0065CAE14  ldr      x1, [x29]
0065CAE18  ldrb     w8, [x1, #0x53]
0065CAE1C  tbnz     w8, #5, #0x65cae28
0065CAE20  ldr      x20, [x20, #0x200]
0065CAE24  b        #0x65cae38 ; 
0065CAE28  ldr      x8, [x1, #0x60]
0065CAE2C  mov      x0, x20
0065CAE30  blr      x8
0065CAE34  mov      x20, x0
0065CAE38  ldrb     w8, [x23, #0x286]
0065CAE3C  cbnz     w8, #0x65cae54
0065CAE40  adrp     x0, #0x8f07000
0065CAE44  ldr      x0, [x0, #0xc98]
0065CAE48  bl       #0x382bd14 ; 
0065CAE4C  mov      w8, #1
0065CAE50  strb     w8, [x23, #0x286]
0065CAE54  ldr      x1, [x24]
0065CAE58  ldrb     w8, [x1, #0x53]
0065CAE5C  tbnz     w8, #5, #0x65cae68
0065CAE60  ldr      x0, [x19, #0x80]
0065CAE64  b        #0x65cae74 ; 
0065CAE68  ldr      x8, [x1, #0x60]
0065CAE6C  mov      x0, x19
0065CAE70  blr      x8
0065CAE74  cbz      x0, #0x65cb630
0065CAE78  ldrb     w8, [x23, #0x286]
0065CAE7C  ldr      w21, [x0, #0x1c8]
0065CAE80  cbnz     w8, #0x65cae98
0065CAE84  adrp     x0, #0x8f07000
0065CAE88  ldr      x0, [x0, #0xc98]
0065CAE8C  bl       #0x382bd14 ; 
0065CAE90  mov      w8, #1
0065CAE94  strb     w8, [x23, #0x286]
0065CAE98  ldr      x1, [x24]
0065CAE9C  ldrb     w8, [x1, #0x53]
0065CAEA0  tbnz     w8, #5, #0x65caeac
0065CAEA4  ldr      x22, [x19, #0x80]
0065CAEA8  b        #0x65caebc ; 
0065CAEAC  ldr      x8, [x1, #0x60]
0065CAEB0  mov      x0, x19
0065CAEB4  blr      x8
0065CAEB8  mov      x22, x0
0065CAEBC  cbz      x22, #0x65cb630
0065CAEC0  adrp     x26, #0x9599000
0065CAEC4  ldrb     w8, [x26, #0x2c3]
0065CAEC8  cbnz     w8, #0x65caee0
0065CAECC  adrp     x0, #0x8f08000
0065CAED0  ldr      x0, [x0, #0x280]
0065CAED4  bl       #0x382bd14 ; 
0065CAED8  mov      w8, #1
0065CAEDC  strb     w8, [x26, #0x2c3]
0065CAEE0  adrp     x8, #0x8f08000
0065CAEE4  ldr      x8, [x8, #0x280]
0065CAEE8  ldr      x1, [x8]
0065CAEEC  ldrb     w8, [x1, #0x53]
0065CAEF0  tbnz     w8, #5, #0x65caf04
0065CAEF4  add      x0, x22, #0x290
0065CAEF8  mov      x1, xzr
0065CAEFC  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065CAF00  b        #0x65caf10 ; 
0065CAF04  ldr      x8, [x1, #0x60]
0065CAF08  mov      x0, x22
0065CAF0C  blr      x8
0065CAF10  mov      w2, w0
0065CAF14  mov      x0, x20
0065CAF18  mov      w1, w21
0065CAF1C  mov      x3, xzr
0065CAF20  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065CAF24  add      x20, x19, #0x188
0065CAF28  mov      x1, x0
0065CAF2C  str      x0, [x19, #0x188]
0065CAF30  mov      x0, x20
0065CAF34  bl       #0x382bcb8 ; 
0065CAF38  ldr      x21, [x19, #0x188]
0065CAF3C  cbz      x21, #0x65cb630
0065CAF40  adrp     x25, #0x8f09000
0065CAF44  ldr      x8, [x21]
0065CAF48  ldr      x25, [x25, #0xc08]
0065CAF4C  ldrh     w9, [x8, #0x12e]
0065CAF50  ldr      x1, [x25]
0065CAF54  cbz      x9, #0x65caf78
0065CAF58  ldr      x10, [x8, #0xb0]
0065CAF5C  add      x10, x10, #8
0065CAF60  ldur     x11, [x10, #-8]
0065CAF64  cmp      x11, x1
0065CAF68  b.eq     #0x65caf88
0065CAF6C  subs     x9, x9, #1
0065CAF70  add      x10, x10, #0x10
0065CAF74  b.ne     #0x65caf60
0065CAF78  mov      w2, #8
0065CAF7C  mov      x0, x21
0065CAF80  bl       #0x3a7e710 ; 
0065CAF84  b        #0x65caf98 ; 
0065CAF88  ldr      w9, [x10]
0065CAF8C  add      w9, w9, #8
0065CAF90  add      x8, x8, w9, sxtw #4
0065CAF94  add      x0, x8, #0x138
0065CAF98  ldp      x8, x1, [x0]
0065CAF9C  mov      x0, x21
0065CAFA0  blr      x8
0065CAFA4  str      w0, [x19, #0xe0]
0065CAFA8  mov      x0, x19
0065CAFAC  bl       #0x65cb634 ; HotFix.BattleLogic.WaterfallBattleManager$$InitNewWaveData
0065CAFB0  mov      x0, x19
0065CAFB4  bl       #0x65cc05c ; HotFix.BattleLogic.WaterfallBattleManager$$UpdateFightTime
0065CAFB8  ldrb     w8, [x23, #0x286]
0065CAFBC  cbnz     w8, #0x65cafd4
0065CAFC0  adrp     x0, #0x8f07000
0065CAFC4  ldr      x0, [x0, #0xc98]
0065CAFC8  bl       #0x382bd14 ; 
0065CAFCC  mov      w8, #1
0065CAFD0  strb     w8, [x23, #0x286]
0065CAFD4  ldr      x1, [x24]
0065CAFD8  ldrb     w8, [x1, #0x53]
0065CAFDC  tbnz     w8, #5, #0x65cafe8
0065CAFE0  ldr      x21, [x19, #0x80]
0065CAFE4  b        #0x65caff8 ; 
0065CAFE8  ldr      x8, [x1, #0x60]
0065CAFEC  mov      x0, x19
0065CAFF0  blr      x8
0065CAFF4  mov      x21, x0
0065CAFF8  cbz      x21, #0x65cb630
0065CAFFC  adrp     x22, #0x9599000
0065CB000  ldrb     w8, [x22, #0x653]
0065CB004  cbnz     w8, #0x65cb01c
0065CB008  adrp     x0, #0x8f0a000
0065CB00C  ldr      x0, [x0, #0x7e8]
0065CB010  bl       #0x382bd14 ; 
0065CB014  mov      w8, #1
0065CB018  strb     w8, [x22, #0x653]
0065CB01C  adrp     x8, #0x8f0a000
0065CB020  ldr      x8, [x8, #0x7e8]
0065CB024  ldr      x1, [x8]
0065CB028  ldrb     w8, [x1, #0x53]
0065CB02C  tbnz     w8, #5, #0x65cb040
0065CB030  add      x0, x21, #0x290
0065CB034  mov      x1, xzr
0065CB038  bl       #0x658f7a0 ; HotFix.BattleLogic.BattleData$$GetNextMissionId
0065CB03C  b        #0x65cb04c ; 
0065CB040  ldr      x8, [x1, #0x60]
0065CB044  mov      x0, x21
0065CB048  blr      x8
0065CB04C  mov      w21, w0
0065CB050  cmp      w0, #0
0065CB054  b.le     #0x65cb098
0065CB058  mov      x0, x19
0065CB05C  mov      x1, xzr
0065CB060  strb     wzr, [x19, #0x102]
0065CB064  bl       #0x65878a0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$ResetLastMissionRefreshStarted
0065CB068  ldrb     w8, [x23, #0x286]
0065CB06C  cbnz     w8, #0x65cb084
0065CB070  adrp     x0, #0x8f07000
0065CB074  ldr      x0, [x0, #0xc98]
0065CB078  bl       #0x382bd14 ; 
0065CB07C  mov      w8, #1
0065CB080  strb     w8, [x23, #0x286]
0065CB084  ldr      x1, [x24]
0065CB088  ldrb     w8, [x1, #0x53]
0065CB08C  tbnz     w8, #5, #0x65cb0dc
0065CB090  ldr      x22, [x19, #0x80]
0065CB094  b        #0x65cb0ec ; 
0065CB098  mov      w20, #1
0065CB09C  mov      x0, x19
0065CB0A0  mov      x1, xzr
0065CB0A4  strb     w20, [x19, #0x102]
0065CB0A8  bl       #0x65878a0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$ResetLastMissionRefreshStarted
0065CB0AC  str      wzr, [x19, #0xd0]
0065CB0B0  ldrb     w8, [x23, #0x286]
0065CB0B4  cbnz     w8, #0x65cb0c8
0065CB0B8  adrp     x0, #0x8f07000
0065CB0BC  ldr      x0, [x0, #0xc98]
0065CB0C0  bl       #0x382bd14 ; 
0065CB0C4  strb     w20, [x23, #0x286]
0065CB0C8  ldr      x1, [x24]
0065CB0CC  ldrb     w8, [x1, #0x53]
0065CB0D0  tbnz     w8, #5, #0x65cb368
0065CB0D4  ldr      x20, [x19, #0x80]
0065CB0D8  b        #0x65cb378 ; 
0065CB0DC  ldr      x8, [x1, #0x60]
0065CB0E0  mov      x0, x19
0065CB0E4  blr      x8
0065CB0E8  mov      x22, x0
0065CB0EC  cbz      x22, #0x65cb630
0065CB0F0  adrp     x27, #0x9599000
0065CB0F4  ldrb     w8, [x27, #0x2a6]
0065CB0F8  cbnz     w8, #0x65cb110
0065CB0FC  adrp     x0, #0x8f08000
0065CB100  ldr      x0, [x0, #0x318]
0065CB104  bl       #0x382bd14 ; 
0065CB108  mov      w8, #1
0065CB10C  strb     w8, [x27, #0x2a6]
0065CB110  adrp     x8, #0x8f08000
0065CB114  ldr      x8, [x8, #0x318]
0065CB118  ldr      x1, [x8]
0065CB11C  ldrb     w8, [x1, #0x53]
0065CB120  tbnz     w8, #5, #0x65cb134
0065CB124  add      x0, x22, #0x290
0065CB128  mov      x1, xzr
0065CB12C  bl       #0x658f8d8 ; HotFix.BattleLogic.BattleData$$GetNextMissionIndex
0065CB130  b        #0x65cb140 ; 
0065CB134  ldr      x8, [x1, #0x60]
0065CB138  mov      x0, x22
0065CB13C  blr      x8
0065CB140  adrp     x27, #0x8f08000
0065CB144  ldr      x27, [x27, #0x280]
0065CB148  ldrb     w8, [x23, #0x286]
0065CB14C  cbnz     w8, #0x65cb164
0065CB150  adrp     x0, #0x8f07000
0065CB154  ldr      x0, [x0, #0xc98]
0065CB158  bl       #0x382bd14 ; 
0065CB15C  mov      w8, #1
0065CB160  strb     w8, [x23, #0x286]
0065CB164  ldr      x1, [x24]
0065CB168  ldrb     w8, [x1, #0x53]
0065CB16C  tbnz     w8, #5, #0x65cb178
0065CB170  ldr      x22, [x19, #0x80]
0065CB174  b        #0x65cb188 ; 
0065CB178  ldr      x8, [x1, #0x60]
0065CB17C  mov      x0, x19
0065CB180  blr      x8
0065CB184  mov      x22, x0
0065CB188  cbz      x22, #0x65cb630
0065CB18C  ldrb     w8, [x28, #0xfcc]
0065CB190  cbnz     w8, #0x65cb1a8
0065CB194  adrp     x0, #0x8f06000
0065CB198  ldr      x0, [x0, #0x470]
0065CB19C  bl       #0x382bd14 ; 
0065CB1A0  mov      w8, #1
0065CB1A4  strb     w8, [x28, #0xfcc]
0065CB1A8  ldr      x1, [x29]
0065CB1AC  ldrb     w8, [x1, #0x53]
0065CB1B0  tbnz     w8, #5, #0x65cb1bc
0065CB1B4  ldr      x22, [x22, #0x200]
0065CB1B8  b        #0x65cb1cc ; 
0065CB1BC  ldr      x8, [x1, #0x60]
0065CB1C0  mov      x0, x22
0065CB1C4  blr      x8
0065CB1C8  mov      x22, x0
0065CB1CC  ldrb     w8, [x23, #0x286]
0065CB1D0  cbnz     w8, #0x65cb1e8
0065CB1D4  adrp     x0, #0x8f07000
0065CB1D8  ldr      x0, [x0, #0xc98]
0065CB1DC  bl       #0x382bd14 ; 
0065CB1E0  mov      w8, #1
0065CB1E4  strb     w8, [x23, #0x286]
0065CB1E8  ldr      x1, [x24]
0065CB1EC  ldrb     w8, [x1, #0x53]
0065CB1F0  tbnz     w8, #5, #0x65cb1fc
0065CB1F4  ldr      x0, [x19, #0x80]
0065CB1F8  b        #0x65cb208 ; 
0065CB1FC  ldr      x8, [x1, #0x60]
0065CB200  mov      x0, x19
0065CB204  blr      x8
0065CB208  cbz      x0, #0x65cb630
0065CB20C  ldr      w1, [x0, #0x1c8]
0065CB210  mov      x0, x22
0065CB214  mov      w2, w21
0065CB218  mov      x3, xzr
0065CB21C  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065CB220  cbz      x0, #0x65cb630
0065CB224  ldr      x8, [x0]
0065CB228  ldr      x1, [x25]
0065CB22C  mov      x21, x0
0065CB230  ldrh     w9, [x8, #0x12e]
0065CB234  cbz      x9, #0x65cb258
0065CB238  ldr      x10, [x8, #0xb0]
0065CB23C  add      x10, x10, #8
0065CB240  ldur     x11, [x10, #-8]
0065CB244  cmp      x11, x1
0065CB248  b.eq     #0x65cb268
0065CB24C  subs     x9, x9, #1
0065CB250  add      x10, x10, #0x10
0065CB254  b.ne     #0x65cb240
0065CB258  mov      w2, #0x28
0065CB25C  mov      x0, x21
0065CB260  bl       #0x3a7e710 ; 
0065CB264  b        #0x65cb278 ; 
0065CB268  ldr      w9, [x10]
0065CB26C  add      w9, w9, #0x28
0065CB270  add      x8, x8, w9, sxtw #4
0065CB274  add      x0, x8, #0x138
0065CB278  ldp      x8, x1, [x0]
0065CB27C  mov      x0, x21
0065CB280  blr      x8
0065CB284  str      w0, [x19, #0xd0]
0065CB288  ldrb     w8, [x23, #0x286]
0065CB28C  cbnz     w8, #0x65cb2a4
0065CB290  adrp     x0, #0x8f07000
0065CB294  ldr      x0, [x0, #0xc98]
0065CB298  bl       #0x382bd14 ; 
0065CB29C  mov      w8, #1
0065CB2A0  strb     w8, [x23, #0x286]
0065CB2A4  ldr      x1, [x24]
0065CB2A8  ldrb     w8, [x1, #0x53]
0065CB2AC  tbnz     w8, #5, #0x65cb2b8
0065CB2B0  ldr      x22, [x19, #0x80]
0065CB2B4  b        #0x65cb2c8 ; 
0065CB2B8  ldr      x8, [x1, #0x60]
0065CB2BC  mov      x0, x19
0065CB2C0  blr      x8
0065CB2C4  mov      x22, x0
0065CB2C8  cbz      x22, #0x65cb630
0065CB2CC  ldrb     w8, [x26, #0x2c3]
0065CB2D0  cbnz     w8, #0x65cb2e8
0065CB2D4  adrp     x0, #0x8f08000
0065CB2D8  ldr      x0, [x0, #0x280]
0065CB2DC  bl       #0x382bd14 ; 
0065CB2E0  mov      w8, #1
0065CB2E4  strb     w8, [x26, #0x2c3]
0065CB2E8  ldr      x1, [x27]
0065CB2EC  ldrb     w8, [x1, #0x53]
0065CB2F0  tbnz     w8, #5, #0x65cb304
0065CB2F4  add      x0, x22, #0x290
0065CB2F8  mov      x1, xzr
0065CB2FC  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065CB300  b        #0x65cb310 ; 
0065CB304  ldr      x8, [x1, #0x60]
0065CB308  mov      x0, x22
0065CB30C  blr      x8
0065CB310  ldr      w8, [x19, #0x138]
0065CB314  cmp      w0, w8
0065CB318  b.ne     #0x65cb494
0065CB31C  ldr      x22, [x19, #0x140]
0065CB320  cbz      x22, #0x65cb630
0065CB324  adrp     x23, #0x9599000
0065CB328  ldrb     w8, [x23, #0x655]
0065CB32C  cbnz     w8, #0x65cb344
0065CB330  adrp     x0, #0x8f0a000
0065CB334  ldr      x0, [x0, #0x7f0]
0065CB338  bl       #0x382bd14 ; 
0065CB33C  mov      w8, #1
0065CB340  strb     w8, [x23, #0x655]
0065CB344  adrp     x8, #0x8f0a000
0065CB348  ldr      x8, [x8, #0x7f0]
0065CB34C  ldr      x1, [x8]
0065CB350  ldrb     w8, [x1, #0x53]
0065CB354  tbnz     w8, #5, #0x65cb484
0065CB358  ldr      x0, [x22, #0x40]
0065CB35C  cbz      x0, #0x65cb494
0065CB360  mov      x8, #-0x10000
0065CB364  b        #0x65cb55c ; 
0065CB368  ldr      x8, [x1, #0x60]
0065CB36C  mov      x0, x19
0065CB370  blr      x8
0065CB374  mov      x20, x0
0065CB378  cbz      x20, #0x65cb630
0065CB37C  adrp     x21, #0x9599000
0065CB380  ldrb     w8, [x21, #0x2c7]
0065CB384  cbnz     w8, #0x65cb39c
0065CB388  adrp     x0, #0x8f08000
0065CB38C  ldr      x0, [x0, #0x940]
0065CB390  bl       #0x382bd14 ; 
0065CB394  mov      w8, #1
0065CB398  strb     w8, [x21, #0x2c7]
0065CB39C  adrp     x8, #0x8f08000
0065CB3A0  ldr      x8, [x8, #0x940]
0065CB3A4  ldr      x2, [x8]
0065CB3A8  ldrb     w8, [x2, #0x53]
0065CB3AC  tbnz     w8, #5, #0x65cb3bc
0065CB3B0  mov      w8, #-1
0065CB3B4  str      w8, [x20, #0x2a8]
0065CB3B8  b        #0x65cb3cc ; 
0065CB3BC  ldr      x8, [x2, #0x60]
0065CB3C0  mov      w1, #-1
0065CB3C4  mov      x0, x20
0065CB3C8  blr      x8
0065CB3CC  mov      x8, #-0x10000
0065CB3D0  str      x8, [x19, #0xb0]
0065CB3D4  adrp     x20, #0x9599000
0065CB3D8  ldrb     w8, [x20, #0x654]
0065CB3DC  cbnz     w8, #0x65cb3f4
0065CB3E0  adrp     x0, #0x8f08000
0065CB3E4  ldr      x0, [x0, #0x200]
0065CB3E8  bl       #0x382bd14 ; 
0065CB3EC  mov      w8, #1
0065CB3F0  strb     w8, [x20, #0x654]
0065CB3F4  adrp     x8, #0x8f08000
0065CB3F8  ldr      x8, [x8, #0x200]
0065CB3FC  ldr      x2, [x8]
0065CB400  ldrb     w8, [x2, #0x53]
0065CB404  tbnz     w8, #5, #0x65cb414
0065CB408  mov      w8, #1
0065CB40C  str      w8, [x19, #0xc0]
0065CB410  b        #0x65cb424 ; 
0065CB414  ldr      x8, [x2, #0x60]
0065CB418  mov      w1, #1
0065CB41C  mov      x0, x19
0065CB420  blr      x8
0065CB424  ldrb     w8, [x23, #0x286]
0065CB428  cbnz     w8, #0x65cb440
0065CB42C  adrp     x0, #0x8f07000
0065CB430  ldr      x0, [x0, #0xc98]
0065CB434  bl       #0x382bd14 ; 
0065CB438  mov      w8, #1
0065CB43C  strb     w8, [x23, #0x286]
0065CB440  ldr      x1, [x24]
0065CB444  ldrb     w8, [x1, #0x53]
0065CB448  tbnz     w8, #5, #0x65cb454
0065CB44C  ldr      x0, [x19, #0x80]
0065CB450  b        #0x65cb460 ; 
0065CB454  ldr      x8, [x1, #0x60]
0065CB458  mov      x0, x19
0065CB45C  blr      x8
0065CB460  cbz      x0, #0x65cb630
0065CB464  ldp      x20, x19, [sp, #0x50]
0065CB468  ldp      x22, x21, [sp, #0x40]
0065CB46C  ldp      x24, x23, [sp, #0x30]
0065CB470  ldp      x26, x25, [sp, #0x20]
0065CB474  ldp      x28, x27, [sp, #0x10]
0065CB478  mov      x1, xzr
0065CB47C  ldp      x29, x30, [sp], #0x60
0065CB480  b        #0x6a08b7c ; HotFix.BattleLogic.BattleWorldContext$$DispatchBattleDataEvent
0065CB484  ldr      x8, [x1, #0x60]
0065CB488  mov      x0, x22
0065CB48C  blr      x8
0065CB490  cbnz     x0, #0x65cb360
0065CB494  ldr      x8, [x21]
0065CB498  ldr      x1, [x25]
0065CB49C  ldrh     w9, [x8, #0x12e]
0065CB4A0  cbz      x9, #0x65cb4c4
0065CB4A4  ldr      x10, [x8, #0xb0]
0065CB4A8  add      x10, x10, #8
0065CB4AC  ldur     x11, [x10, #-8]
0065CB4B0  cmp      x11, x1
0065CB4B4  b.eq     #0x65cb4d4
0065CB4B8  subs     x9, x9, #1
0065CB4BC  add      x10, x10, #0x10
0065CB4C0  b.ne     #0x65cb4ac
0065CB4C4  mov      w2, #4
0065CB4C8  mov      x0, x21
0065CB4CC  bl       #0x3a7e710 ; 
0065CB4D0  b        #0x65cb4e4 ; 
0065CB4D4  ldr      w9, [x10]
0065CB4D8  add      w9, w9, #4
0065CB4DC  add      x8, x8, w9, sxtw #4
0065CB4E0  add      x0, x8, #0x138
0065CB4E4  ldp      x8, x1, [x0]
0065CB4E8  mov      x0, x21
0065CB4EC  blr      x8
0065CB4F0  ldr      x22, [x20]
0065CB4F4  cbz      x22, #0x65cb630
0065CB4F8  ldr      x8, [x22]
0065CB4FC  ldr      x1, [x25]
0065CB500  mov      x20, x0
0065CB504  ldrh     w9, [x8, #0x12e]
0065CB508  cbz      x9, #0x65cb52c
0065CB50C  ldr      x10, [x8, #0xb0]
0065CB510  add      x10, x10, #8
0065CB514  ldur     x11, [x10, #-8]
0065CB518  cmp      x11, x1
0065CB51C  b.eq     #0x65cb53c
0065CB520  subs     x9, x9, #1
0065CB524  add      x10, x10, #0x10
0065CB528  b.ne     #0x65cb514
0065CB52C  mov      w2, #4
0065CB530  mov      x0, x22
0065CB534  bl       #0x3a7e710 ; 
0065CB538  b        #0x65cb54c ; 
0065CB53C  ldr      w9, [x10]
0065CB540  add      w9, w9, #4
0065CB544  add      x8, x8, w9, sxtw #4
0065CB548  add      x0, x8, #0x138
0065CB54C  ldp      x8, x1, [x0]
0065CB550  mov      x0, x22
0065CB554  blr      x8
0065CB558  sub      x8, x20, x0
0065CB55C  str      x8, [x19, #0xb0]
0065CB560  ldr      x8, [x21]
0065CB564  ldr      x1, [x25]
0065CB568  ldrh     w9, [x8, #0x12e]
0065CB56C  cbz      x9, #0x65cb590
0065CB570  ldr      x10, [x8, #0xb0]
0065CB574  add      x10, x10, #8
0065CB578  ldur     x11, [x10, #-8]
0065CB57C  cmp      x11, x1
0065CB580  b.eq     #0x65cb5a0
0065CB584  subs     x9, x9, #1
0065CB588  add      x10, x10, #0x10
0065CB58C  b.ne     #0x65cb578
0065CB590  mov      w2, #8
0065CB594  mov      x0, x21
0065CB598  bl       #0x3a7e710 ; 
0065CB59C  b        #0x65cb5b0 ; 
0065CB5A0  ldr      w9, [x10]
0065CB5A4  add      w9, w9, #8
0065CB5A8  add      x8, x8, w9, sxtw #4
0065CB5AC  add      x0, x8, #0x138
0065CB5B0  ldp      x8, x1, [x0]
0065CB5B4  mov      x0, x21
0065CB5B8  blr      x8
0065CB5BC  adrp     x21, #0x9599000
0065CB5C0  ldrb     w8, [x21, #0x654]
0065CB5C4  mov      w20, w0
0065CB5C8  cbnz     w8, #0x65cb5e0
0065CB5CC  adrp     x0, #0x8f08000
0065CB5D0  ldr      x0, [x0, #0x200]
0065CB5D4  bl       #0x382bd14 ; 
0065CB5D8  mov      w8, #1
0065CB5DC  strb     w8, [x21, #0x654]
0065CB5E0  adrp     x8, #0x8f08000
0065CB5E4  ldr      x8, [x8, #0x200]
0065CB5E8  ldr      x2, [x8]
0065CB5EC  ldrb     w8, [x2, #0x53]
0065CB5F0  tbnz     w8, #5, #0x65cb5fc
0065CB5F4  str      w20, [x19, #0xc0]
0065CB5F8  b        #0x65cb60c ; 
0065CB5FC  ldr      x8, [x2, #0x60]
0065CB600  mov      x0, x19
0065CB604  mov      w1, w20
0065CB608  blr      x8
0065CB60C  mov      x0, x19
0065CB610  ldp      x20, x19, [sp, #0x50]
0065CB614  ldp      x22, x21, [sp, #0x40]
0065CB618  ldp      x24, x23, [sp, #0x30]
0065CB61C  ldp      x26, x25, [sp, #0x20]
0065CB620  ldp      x28, x27, [sp, #0x10]
0065CB624  mov      x1, xzr
0065CB628  ldp      x29, x30, [sp], #0x60
0065CB62C  b        #0x658853c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$InitNoticeTime
0065CB630  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$GetMissionType
; RVA 0x65CC3F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CC3F8  str      x30, [sp, #-0x40]!
0065CC3FC  stp      x24, x23, [sp, #0x10]
0065CC400  stp      x22, x21, [sp, #0x20]
0065CC404  stp      x20, x19, [sp, #0x30]
0065CC408  adrp     x21, #0x9599000
0065CC40C  adrp     x22, #0x8f0a000
0065CC410  ldrb     w8, [x21, #0x57b]
0065CC414  ldr      x22, [x22, #0x830]
0065CC418  mov      w19, w1
0065CC41C  mov      x20, x0
0065CC420  tbnz     w8, #0, #0x65cc444
0065CC424  adrp     x0, #0x8f09000
0065CC428  ldr      x0, [x0, #0xc08]
0065CC42C  bl       #0x382bd14 ; 
0065CC430  adrp     x0, #0x8f0a000
0065CC434  ldr      x0, [x0, #0x830]
0065CC438  bl       #0x382bd14 ; 
0065CC43C  mov      w8, #1
0065CC440  strb     w8, [x21, #0x57b]
0065CC444  ldr      x2, [x22]
0065CC448  ldrb     w8, [x2, #0x53]
0065CC44C  tbnz     w8, #5, #0x65cc48c
0065CC450  adrp     x22, #0x9599000
0065CC454  ldrb     w8, [x22, #0x286]
0065CC458  cbnz     w8, #0x65cc470
0065CC45C  adrp     x0, #0x8f07000
0065CC460  ldr      x0, [x0, #0xc98]
0065CC464  bl       #0x382bd14 ; 
0065CC468  mov      w8, #1
0065CC46C  strb     w8, [x22, #0x286]
0065CC470  adrp     x23, #0x8f07000
0065CC474  ldr      x23, [x23, #0xc98]
0065CC478  ldr      x1, [x23]
0065CC47C  ldrb     w8, [x1, #0x53]
0065CC480  tbnz     w8, #5, #0x65cc4ac
0065CC484  ldr      x21, [x20, #0x80]
0065CC488  b        #0x65cc4bc ; 
0065CC48C  ldr      x3, [x2, #0x60]
0065CC490  mov      x0, x20
0065CC494  mov      w1, w19
0065CC498  ldp      x20, x19, [sp, #0x30]
0065CC49C  ldp      x22, x21, [sp, #0x20]
0065CC4A0  ldp      x24, x23, [sp, #0x10]
0065CC4A4  ldr      x30, [sp], #0x40
0065CC4A8  br       x3
0065CC4AC  ldr      x8, [x1, #0x60]
0065CC4B0  mov      x0, x20
0065CC4B4  blr      x8
0065CC4B8  mov      x21, x0
0065CC4BC  cbz      x21, #0x65cc5dc
0065CC4C0  adrp     x24, #0x9598000
0065CC4C4  ldrb     w8, [x24, #0xfcc]
0065CC4C8  cbnz     w8, #0x65cc4e0
0065CC4CC  adrp     x0, #0x8f06000
0065CC4D0  ldr      x0, [x0, #0x470]
0065CC4D4  bl       #0x382bd14 ; 
0065CC4D8  mov      w8, #1
0065CC4DC  strb     w8, [x24, #0xfcc]
0065CC4E0  adrp     x8, #0x8f06000
0065CC4E4  ldr      x8, [x8, #0x470]
0065CC4E8  ldr      x1, [x8]
0065CC4EC  ldrb     w8, [x1, #0x53]
0065CC4F0  tbnz     w8, #5, #0x65cc4fc
0065CC4F4  ldr      x21, [x21, #0x200]
0065CC4F8  b        #0x65cc50c ; 
0065CC4FC  ldr      x8, [x1, #0x60]
0065CC500  mov      x0, x21
0065CC504  blr      x8
0065CC508  mov      x21, x0
0065CC50C  ldrb     w8, [x22, #0x286]
0065CC510  cbnz     w8, #0x65cc528
0065CC514  adrp     x0, #0x8f07000
0065CC518  ldr      x0, [x0, #0xc98]
0065CC51C  bl       #0x382bd14 ; 
0065CC520  mov      w8, #1
0065CC524  strb     w8, [x22, #0x286]
0065CC528  ldr      x1, [x23]
0065CC52C  ldrb     w8, [x1, #0x53]
0065CC530  tbnz     w8, #5, #0x65cc53c
0065CC534  ldr      x0, [x20, #0x80]
0065CC538  b        #0x65cc548 ; 
0065CC53C  ldr      x8, [x1, #0x60]
0065CC540  mov      x0, x20
0065CC544  blr      x8
0065CC548  cbz      x0, #0x65cc5dc
0065CC54C  ldr      w1, [x0, #0x1c8]
0065CC550  mov      x0, x21
0065CC554  mov      w2, w19
0065CC558  mov      x3, xzr
0065CC55C  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065CC560  cbz      x0, #0x65cc5dc
0065CC564  adrp     x10, #0x8f09000
0065CC568  ldr      x8, [x0]
0065CC56C  ldr      x10, [x10, #0xc08]
0065CC570  mov      x19, x0
0065CC574  ldrh     w9, [x8, #0x12e]
0065CC578  ldr      x1, [x10]
0065CC57C  cbz      x9, #0x65cc5a0
0065CC580  ldr      x10, [x8, #0xb0]
0065CC584  add      x10, x10, #8
0065CC588  ldur     x11, [x10, #-8]
0065CC58C  cmp      x11, x1
0065CC590  b.eq     #0x65cc5b0
0065CC594  subs     x9, x9, #1
0065CC598  add      x10, x10, #0x10
0065CC59C  b.ne     #0x65cc588
0065CC5A0  mov      w2, #8
0065CC5A4  mov      x0, x19
0065CC5A8  bl       #0x3a7e710 ; 
0065CC5AC  b        #0x65cc5c0 ; 
0065CC5B0  ldr      w9, [x10]
0065CC5B4  add      w9, w9, #8
0065CC5B8  add      x8, x8, w9, sxtw #4
0065CC5BC  add      x0, x8, #0x138
0065CC5C0  ldp      x2, x1, [x0]
0065CC5C4  mov      x0, x19
0065CC5C8  ldp      x20, x19, [sp, #0x30]
0065CC5CC  ldp      x22, x21, [sp, #0x20]
0065CC5D0  ldp      x24, x23, [sp, #0x10]
0065CC5D4  ldr      x30, [sp], #0x40
0065CC5D8  br       x2
0065CC5DC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$OnMissionIncrease
; RVA 0x65CC5E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CC5E0  stp      x30, x21, [sp, #-0x20]!
0065CC5E4  stp      x20, x19, [sp, #0x10]
0065CC5E8  adrp     x20, #0x9599000
0065CC5EC  adrp     x21, #0x8f0a000
0065CC5F0  ldrb     w8, [x20, #0x57c]
0065CC5F4  ldr      x21, [x21, #0x838]
0065CC5F8  mov      x19, x0
0065CC5FC  tbnz     w8, #0, #0x65cc614
0065CC600  adrp     x0, #0x8f0a000
0065CC604  ldr      x0, [x0, #0x838]
0065CC608  bl       #0x382bd14 ; 
0065CC60C  mov      w8, #1
0065CC610  strb     w8, [x20, #0x57c]
0065CC614  ldr      x1, [x21]
0065CC618  ldrb     w8, [x1, #0x53]
0065CC61C  tbnz     w8, #5, #0x65cc63c
0065CC620  mov      x0, x19
0065CC624  mov      x1, xzr
0065CC628  bl       #0x6590520 ; HotFix.BattleLogic.BattleManager$$OnMissionIncrease
0065CC62C  mov      x0, x19
0065CC630  ldp      x20, x19, [sp, #0x10]
0065CC634  ldp      x30, x21, [sp], #0x20
0065CC638  b        #0x65cc650 ; HotFix.BattleLogic.WaterfallBattleManager$$tryClearBeeMonsterCreators
0065CC63C  ldr      x2, [x1, #0x60]
0065CC640  mov      x0, x19
0065CC644  ldp      x20, x19, [sp, #0x10]
0065CC648  ldp      x30, x21, [sp], #0x20
0065CC64C  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$OnProgressFinish
; RVA 0x65CC838; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CC838  stp      x30, x25, [sp, #-0x40]!
0065CC83C  stp      x24, x23, [sp, #0x10]
0065CC840  stp      x22, x21, [sp, #0x20]
0065CC844  stp      x20, x19, [sp, #0x30]
0065CC848  adrp     x20, #0x9599000
0065CC84C  adrp     x21, #0x8f0a000
0065CC850  ldrb     w8, [x20, #0x57d]
0065CC854  ldr      x21, [x21, #0x878]
0065CC858  mov      x19, x0
0065CC85C  tbnz     w8, #0, #0x65cc88c
0065CC860  adrp     x0, #0x8f09000
0065CC864  ldr      x0, [x0, #0x540]
0065CC868  bl       #0x382bd14 ; 
0065CC86C  adrp     x0, #0x8f09000
0065CC870  ldr      x0, [x0, #0x548]
0065CC874  bl       #0x382bd14 ; 
0065CC878  adrp     x0, #0x8f0a000
0065CC87C  ldr      x0, [x0, #0x878]
0065CC880  bl       #0x382bd14 ; 
0065CC884  mov      w8, #1
0065CC888  strb     w8, [x20, #0x57d]
0065CC88C  ldr      x1, [x21]
0065CC890  ldrb     w8, [x1, #0x53]
0065CC894  tbnz     w8, #5, #0x65cc8d0
0065CC898  ldr      x8, [x19, #0x1e8]
0065CC89C  cbz      x8, #0x65cccf8
0065CC8A0  ldr      x9, [x8, #0x18]
0065CC8A4  cbz      x9, #0x65cccf8
0065CC8A8  ldrsw    x10, [x19, #0x198]
0065CC8AC  cmp      w10, w9
0065CC8B0  b.ne     #0x65cc8ec
0065CC8B4  mov      x0, x19
0065CC8B8  ldp      x20, x19, [sp, #0x30]
0065CC8BC  ldp      x22, x21, [sp, #0x20]
0065CC8C0  ldp      x24, x23, [sp, #0x10]
0065CC8C4  mov      x1, xzr
0065CC8C8  ldp      x30, x25, [sp], #0x40
0065CC8CC  b        #0x6587478 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$WaterfallProgressFinishGoNext
0065CC8D0  ldr      x2, [x1, #0x60]
0065CC8D4  mov      x0, x19
0065CC8D8  ldp      x20, x19, [sp, #0x30]
0065CC8DC  ldp      x22, x21, [sp, #0x20]
0065CC8E0  ldp      x24, x23, [sp, #0x10]
0065CC8E4  ldp      x30, x25, [sp], #0x40
0065CC8E8  br       x2
0065CC8EC  cmp      w10, w9
0065CC8F0  b.hs     #0x65cced8
0065CC8F4  add      x8, x8, x10, lsl #2
0065CC8F8  ldr      w23, [x8, #0x20]
0065CC8FC  sub      w8, w23, #2
0065CC900  cmp      w8, #4
0065CC904  b.hi     #0x65cccf8
0065CC908  adrp     x9, #0x1a71000
0065CC90C  add      x9, x9, #0xfd8
0065CC910  adr      x10, #0x65cc920
0065CC914  ldrb     w11, [x9, x8]
0065CC918  add      x10, x10, x11, lsl #2
0065CC91C  br       x10
0065CC920  adrp     x22, #0x9599000
0065CC924  ldrb     w8, [x22, #0x286]
0065CC928  cbnz     w8, #0x65cc940
0065CC92C  adrp     x0, #0x8f07000
0065CC930  ldr      x0, [x0, #0xc98]
0065CC934  bl       #0x382bd14 ; 
0065CC938  mov      w8, #1
0065CC93C  strb     w8, [x22, #0x286]
0065CC940  adrp     x24, #0x8f07000
0065CC944  ldr      x24, [x24, #0xc98]
0065CC948  ldr      x1, [x24]
0065CC94C  ldrb     w8, [x1, #0x53]
0065CC950  tbnz     w8, #5, #0x65cc95c
0065CC954  ldr      x21, [x19, #0x80]
0065CC958  b        #0x65cc96c ; 
0065CC95C  ldr      x8, [x1, #0x60]
0065CC960  mov      x0, x19
0065CC964  blr      x8
0065CC968  mov      x21, x0
0065CC96C  cbz      x21, #0x65cced4
0065CC970  adrp     x8, #0x8f09000
0065CC974  ldr      x8, [x8, #0x540]
0065CC978  ldr      x20, [x8]
0065CC97C  ldr      x8, [x20, #0x38]
0065CC980  cbnz     x8, #0x65cc98c
0065CC984  mov      x0, x20
0065CC988  bl       #0x3a7e668 ; 
0065CC98C  ldrb     w8, [x20, #0x53]
0065CC990  tbnz     w8, #5, #0x65cc9d0
0065CC994  adrp     x25, #0x9591000
0065CC998  ldrb     w8, [x25, #0xa61]
0065CC99C  cbnz     w8, #0x65cc9b4
0065CC9A0  adrp     x0, #0x8ee6000
0065CC9A4  ldr      x0, [x0, #0x308]
0065CC9A8  bl       #0x382bd14 ; 
0065CC9AC  mov      w8, #1
0065CC9B0  strb     w8, [x25, #0xa61]
0065CC9B4  adrp     x8, #0x8ee6000
0065CC9B8  ldr      x8, [x8, #0x308]
0065CC9BC  ldr      x1, [x8]
0065CC9C0  ldrb     w8, [x1, #0x53]
0065CC9C4  tbnz     w8, #5, #0x65cca70
0065CC9C8  ldr      x0, [x21, #0x1e8]
0065CC9CC  b        #0x65cca7c ; 
0065CC9D0  ldr      x8, [x20, #0x60]
0065CC9D4  mov      x0, x21
0065CC9D8  mov      x1, x20
0065CC9DC  blr      x8
0065CC9E0  b        #0x65cca8c ; 
0065CC9E4  mov      x0, x19
0065CC9E8  bl       #0x65c8d70 ; HotFix.BattleLogic.WaterfallBattleManager$$CanRunUpLevelProgress
0065CC9EC  tbz      w0, #0, #0x65cccf8
0065CC9F0  adrp     x21, #0x9599000
0065CC9F4  ldrb     w8, [x21, #0x286]
0065CC9F8  cbnz     w8, #0x65cca10
0065CC9FC  adrp     x0, #0x8f07000
0065CCA00  ldr      x0, [x0, #0xc98]
0065CCA04  bl       #0x382bd14 ; 
0065CCA08  mov      w8, #1
0065CCA0C  strb     w8, [x21, #0x286]
0065CCA10  adrp     x23, #0x8f07000
0065CCA14  ldr      x23, [x23, #0xc98]
0065CCA18  ldr      x1, [x23]
0065CCA1C  ldrb     w8, [x1, #0x53]
0065CCA20  tbnz     w8, #5, #0x65ccbac
0065CCA24  ldr      x20, [x19, #0x80]
0065CCA28  b        #0x65ccbbc ; 
0065CCA2C  mov      x0, x19
0065CCA30  bl       #0x65ccedc ; HotFix.BattleLogic.WaterfallBattleManager$$TriggerBossNoticeStart
0065CCA34  adrp     x22, #0x9599000
0065CCA38  ldrb     w8, [x22, #0x286]
0065CCA3C  cbnz     w8, #0x65cca54
0065CCA40  adrp     x0, #0x8f07000
0065CCA44  ldr      x0, [x0, #0xc98]
0065CCA48  bl       #0x382bd14 ; 
0065CCA4C  mov      w8, #1
0065CCA50  strb     w8, [x22, #0x286]
0065CCA54  adrp     x23, #0x8f07000
0065CCA58  ldr      x23, [x23, #0xc98]
0065CCA5C  ldr      x1, [x23]
0065CCA60  ldrb     w8, [x1, #0x53]
0065CCA64  tbnz     w8, #5, #0x65ccb24
0065CCA68  ldr      x21, [x19, #0x80]
0065CCA6C  b        #0x65ccb34 ; 
0065CCA70  ldr      x8, [x1, #0x60]
0065CCA74  mov      x0, x21
0065CCA78  blr      x8
0065CCA7C  cbz      x0, #0x65cced4
0065CCA80  ldr      x8, [x20, #0x38]
0065CCA84  ldr      x1, [x8]
0065CCA88  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065CCA8C  mov      x20, x0
0065CCA90  cbz      x0, #0x65cced4
0065CCA94  str      w23, [x20, #0x20]
0065CCA98  ldrb     w8, [x22, #0x286]
0065CCA9C  cbnz     w8, #0x65ccab4
0065CCAA0  adrp     x0, #0x8f07000
0065CCAA4  ldr      x0, [x0, #0xc98]
0065CCAA8  bl       #0x382bd14 ; 
0065CCAAC  mov      w8, #1
0065CCAB0  strb     w8, [x22, #0x286]
0065CCAB4  ldr      x1, [x24]
0065CCAB8  ldrb     w8, [x1, #0x53]
0065CCABC  tbnz     w8, #5, #0x65ccac8
0065CCAC0  ldr      x0, [x19, #0x80]
0065CCAC4  b        #0x65ccad4 ; 
0065CCAC8  ldr      x8, [x1, #0x60]
0065CCACC  mov      x0, x19
0065CCAD0  blr      x8
0065CCAD4  cbz      x0, #0x65cced4
0065CCAD8  ldr      x21, [x0, #0x1e0]
0065CCADC  cbz      x21, #0x65cced4
0065CCAE0  adrp     x9, #0x8f09000
0065CCAE4  ldr      x9, [x9, #0x548]
0065CCAE8  ldr      x8, [x21]
0065CCAEC  ldr      x22, [x9]
0065CCAF0  ldrh     w9, [x8, #0x12e]
0065CCAF4  ldr      x1, [x22, #0x20]
0065CCAF8  ldrh     w2, [x22, #0x50]
0065CCAFC  cbz      x9, #0x65cccb0
0065CCB00  ldr      x10, [x8, #0xb0]
0065CCB04  add      x10, x10, #8
0065CCB08  ldur     x11, [x10, #-8]
0065CCB0C  cmp      x11, x1
0065CCB10  b.eq     #0x65cccbc
0065CCB14  subs     x9, x9, #1
0065CCB18  add      x10, x10, #0x10
0065CCB1C  b.ne     #0x65ccb08
0065CCB20  b        #0x65cccb0 ; 
0065CCB24  ldr      x8, [x1, #0x60]
0065CCB28  mov      x0, x19
0065CCB2C  blr      x8
0065CCB30  mov      x21, x0
0065CCB34  cbz      x21, #0x65cced4
0065CCB38  adrp     x8, #0x8f09000
0065CCB3C  ldr      x8, [x8, #0x540]
0065CCB40  ldr      x20, [x8]
0065CCB44  ldr      x8, [x20, #0x38]
0065CCB48  cbnz     x8, #0x65ccb54
0065CCB4C  mov      x0, x20
0065CCB50  bl       #0x3a7e668 ; 
0065CCB54  ldrb     w8, [x20, #0x53]
0065CCB58  tbnz     w8, #5, #0x65ccb98
0065CCB5C  adrp     x24, #0x9591000
0065CCB60  ldrb     w8, [x24, #0xa61]
0065CCB64  cbnz     w8, #0x65ccb7c
0065CCB68  adrp     x0, #0x8ee6000
0065CCB6C  ldr      x0, [x0, #0x308]
0065CCB70  bl       #0x382bd14 ; 
0065CCB74  mov      w8, #1
0065CCB78  strb     w8, [x24, #0xa61]
0065CCB7C  adrp     x8, #0x8ee6000
0065CCB80  ldr      x8, [x8, #0x308]
0065CCB84  ldr      x1, [x8]
0065CCB88  ldrb     w8, [x1, #0x53]
0065CCB8C  tbnz     w8, #5, #0x65ccbfc
0065CCB90  ldr      x0, [x21, #0x1e8]
0065CCB94  b        #0x65ccc08 ; 
0065CCB98  ldr      x8, [x20, #0x60]
0065CCB9C  mov      x0, x21
0065CCBA0  mov      x1, x20
0065CCBA4  blr      x8
0065CCBA8  b        #0x65ccc18 ; 
0065CCBAC  ldr      x8, [x1, #0x60]
0065CCBB0  mov      x0, x19
0065CCBB4  blr      x8
0065CCBB8  mov      x20, x0
0065CCBBC  cbz      x20, #0x65cced4
0065CCBC0  adrp     x22, #0x9599000
0065CCBC4  ldrb     w8, [x22, #0x287]
0065CCBC8  cbnz     w8, #0x65ccbe0
0065CCBCC  adrp     x0, #0x8f07000
0065CCBD0  ldr      x0, [x0, #0xcf0]
0065CCBD4  bl       #0x382bd14 ; 
0065CCBD8  mov      w8, #1
0065CCBDC  strb     w8, [x22, #0x287]
0065CCBE0  adrp     x24, #0x8f07000
0065CCBE4  ldr      x24, [x24, #0xcf0]
0065CCBE8  ldr      x1, [x24]
0065CCBEC  ldrb     w8, [x1, #0x53]
0065CCBF0  tbnz     w8, #5, #0x65ccd0c
0065CCBF4  ldr      x0, [x20, #0x350]
0065CCBF8  b        #0x65ccd18 ; 
0065CCBFC  ldr      x8, [x1, #0x60]
0065CCC00  mov      x0, x21
0065CCC04  blr      x8
0065CCC08  cbz      x0, #0x65cced4
0065CCC0C  ldr      x8, [x20, #0x38]
0065CCC10  ldr      x1, [x8]
0065CCC14  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065CCC18  mov      x20, x0
0065CCC1C  cbz      x0, #0x65cced4
0065CCC20  mov      w8, #2
0065CCC24  str      w8, [x20, #0x20]
0065CCC28  ldrb     w8, [x22, #0x286]
0065CCC2C  cbnz     w8, #0x65ccc44
0065CCC30  adrp     x0, #0x8f07000
0065CCC34  ldr      x0, [x0, #0xc98]
0065CCC38  bl       #0x382bd14 ; 
0065CCC3C  mov      w8, #1
0065CCC40  strb     w8, [x22, #0x286]
0065CCC44  ldr      x1, [x23]
0065CCC48  ldrb     w8, [x1, #0x53]
0065CCC4C  tbnz     w8, #5, #0x65ccc58
0065CCC50  ldr      x0, [x19, #0x80]
0065CCC54  b        #0x65ccc64 ; 
0065CCC58  ldr      x8, [x1, #0x60]
0065CCC5C  mov      x0, x19
0065CCC60  blr      x8
0065CCC64  cbz      x0, #0x65cced4
0065CCC68  ldr      x21, [x0, #0x1e0]
0065CCC6C  cbz      x21, #0x65cced4
0065CCC70  adrp     x9, #0x8f09000
0065CCC74  ldr      x9, [x9, #0x548]
0065CCC78  ldr      x8, [x21]
0065CCC7C  ldr      x22, [x9]
0065CCC80  ldrh     w9, [x8, #0x12e]
0065CCC84  ldr      x1, [x22, #0x20]
0065CCC88  ldrh     w2, [x22, #0x50]
0065CCC8C  cbz      x9, #0x65cccb0
0065CCC90  ldr      x10, [x8, #0xb0]
0065CCC94  add      x10, x10, #8
0065CCC98  ldur     x11, [x10, #-8]
0065CCC9C  cmp      x11, x1
0065CCCA0  b.eq     #0x65cccbc
0065CCCA4  subs     x9, x9, #1
0065CCCA8  add      x10, x10, #0x10
0065CCCAC  b.ne     #0x65ccc98
0065CCCB0  mov      x0, x21
0065CCCB4  bl       #0x3a7e710 ; 
0065CCCB8  b        #0x65ccccc ; 
0065CCCBC  ldr      w9, [x10]
0065CCCC0  add      w9, w9, w2
0065CCCC4  add      x8, x8, w9, sxtw #4
0065CCCC8  add      x0, x8, #0x138
0065CCCCC  ldr      x0, [x0, #8]
0065CCCD0  mov      x1, x22
0065CCCD4  bl       #0x382be88 ; 
0065CCCD8  ldr      x8, [x0, #8]
0065CCCDC  mov      x2, x0
0065CCCE0  mov      x0, x21
0065CCCE4  mov      x1, x20
0065CCCE8  blr      x8
0065CCCEC  ldr      w8, [x19, #0x198]
0065CCCF0  add      w8, w8, #1
0065CCCF4  str      w8, [x19, #0x198]
0065CCCF8  ldp      x20, x19, [sp, #0x30]
0065CCCFC  ldp      x22, x21, [sp, #0x20]
0065CCD00  ldp      x24, x23, [sp, #0x10]
0065CCD04  ldp      x30, x25, [sp], #0x40
0065CCD08  ret      
0065CCD0C  ldr      x8, [x1, #0x60]
0065CCD10  mov      x0, x20
0065CCD14  blr      x8
0065CCD18  cbz      x0, #0x65cced4
0065CCD1C  mov      x1, xzr
0065CCD20  bl       #0x666fea8 ; HotFix.BattleLogic.DropMgr$$HasEquip
0065CCD24  tbnz     w0, #0, #0x65ccdcc
0065CCD28  ldrb     w8, [x21, #0x286]
0065CCD2C  cbnz     w8, #0x65ccd44
0065CCD30  adrp     x0, #0x8f07000
0065CCD34  ldr      x0, [x0, #0xc98]
0065CCD38  bl       #0x382bd14 ; 
0065CCD3C  mov      w8, #1
0065CCD40  strb     w8, [x21, #0x286]
0065CCD44  ldr      x1, [x23]
0065CCD48  ldrb     w8, [x1, #0x53]
0065CCD4C  tbnz     w8, #5, #0x65ccd58
0065CCD50  ldr      x20, [x19, #0x80]
0065CCD54  b        #0x65ccd68 ; 
0065CCD58  ldr      x8, [x1, #0x60]
0065CCD5C  mov      x0, x19
0065CCD60  blr      x8
0065CCD64  mov      x20, x0
0065CCD68  cbz      x20, #0x65cced4
0065CCD6C  ldrb     w8, [x22, #0x287]
0065CCD70  cbnz     w8, #0x65ccd88
0065CCD74  adrp     x0, #0x8f07000
0065CCD78  ldr      x0, [x0, #0xcf0]
0065CCD7C  bl       #0x382bd14 ; 
0065CCD80  mov      w8, #1
0065CCD84  strb     w8, [x22, #0x287]
0065CCD88  ldr      x1, [x24]
0065CCD8C  ldrb     w8, [x1, #0x53]
0065CCD90  tbnz     w8, #5, #0x65ccd9c
0065CCD94  ldr      x0, [x20, #0x350]
0065CCD98  b        #0x65ccda8 ; 
0065CCD9C  ldr      x8, [x1, #0x60]
0065CCDA0  mov      x0, x20
0065CCDA4  blr      x8
0065CCDA8  cbz      x0, #0x65cced4
0065CCDAC  mov      x1, xzr
0065CCDB0  bl       #0x666fd64 ; HotFix.BattleLogic.DropMgr$$HaveDropExp
0065CCDB4  tbnz     w0, #0, #0x65ccdcc
0065CCDB8  ldr      x0, [x19, #0x90]
0065CCDBC  cbz      x0, #0x65cced4
0065CCDC0  mov      x1, xzr
0065CCDC4  bl       #0x6851208 ; HotFix.BattleLogic.ExpAnimProcessor$$IsAdding
0065CCDC8  tbz      w0, #0, #0x65cce64
0065CCDCC  ldrb     w8, [x21, #0x286]
0065CCDD0  cbnz     w8, #0x65ccde8
0065CCDD4  adrp     x0, #0x8f07000
0065CCDD8  ldr      x0, [x0, #0xc98]
0065CCDDC  bl       #0x382bd14 ; 
0065CCDE0  mov      w8, #1
0065CCDE4  strb     w8, [x21, #0x286]
0065CCDE8  ldr      x1, [x23]
0065CCDEC  ldrb     w8, [x1, #0x53]
0065CCDF0  tbnz     w8, #5, #0x65ccdfc
0065CCDF4  ldr      x20, [x19, #0x80]
0065CCDF8  b        #0x65cce0c ; 
0065CCDFC  ldr      x8, [x1, #0x60]
0065CCE00  mov      x0, x19
0065CCE04  blr      x8
0065CCE08  mov      x20, x0
0065CCE0C  cbz      x20, #0x65cced4
0065CCE10  ldrb     w8, [x22, #0x287]
0065CCE14  cbnz     w8, #0x65cce2c
0065CCE18  adrp     x0, #0x8f07000
0065CCE1C  ldr      x0, [x0, #0xcf0]
0065CCE20  bl       #0x382bd14 ; 
0065CCE24  mov      w8, #1
0065CCE28  strb     w8, [x22, #0x287]
0065CCE2C  ldr      x1, [x24]
0065CCE30  ldrb     w8, [x1, #0x53]
0065CCE34  tbnz     w8, #5, #0x65cce40
0065CCE38  ldr      x0, [x20, #0x350]
0065CCE3C  b        #0x65cce4c ; 
0065CCE40  ldr      x8, [x1, #0x60]
0065CCE44  mov      x0, x20
0065CCE48  blr      x8
0065CCE4C  cbz      x0, #0x65cced4
0065CCE50  mov      x1, xzr
0065CCE54  bl       #0x666ff78 ; HotFix.BattleLogic.DropMgr$$AbsorbAll
0065CCE58  mov      w8, #1
0065CCE5C  strb     w8, [x19, #0x1d4]
0065CCE60  b        #0x65cccf8 ; 
0065CCE64  ldr      x0, [x19, #0x90]
0065CCE68  cbz      x0, #0x65cced4
0065CCE6C  mov      x1, xzr
0065CCE70  bl       #0x68510f8 ; HotFix.BattleLogic.ExpAnimProcessor$$IsIdle
0065CCE74  tbz      w0, #0, #0x65cce84
0065CCE78  ldr      w8, [x19, #0x1cc]
0065CCE7C  cbnz     w8, #0x65cce9c
0065CCE80  b        #0x65cceb8 ; 
0065CCE84  ldr      x0, [x19, #0x90]
0065CCE88  cbz      x0, #0x65cced4
0065CCE8C  mov      x1, xzr
0065CCE90  bl       #0x6850f28 ; HotFix.BattleLogic.ExpAnimProcessor$$CanLevelUp
0065CCE94  ldr      w8, [x19, #0x1cc]
0065CCE98  cbz      w8, #0x65cceb4
0065CCE9C  mov      x0, x19
0065CCEA0  ldp      x20, x19, [sp, #0x30]
0065CCEA4  ldp      x22, x21, [sp, #0x20]
0065CCEA8  ldp      x24, x23, [sp, #0x10]
0065CCEAC  ldp      x30, x25, [sp], #0x40
0065CCEB0  b        #0x65c8e98 ; HotFix.BattleLogic.WaterfallBattleManager$$QueueSelectSkill
0065CCEB4  tbnz     w0, #0, #0x65cccf8
0065CCEB8  ldr      w8, [x19, #0x198]
0065CCEBC  ldr      x9, [x19]
0065CCEC0  add      w8, w8, #1
0065CCEC4  str      w8, [x19, #0x198]
0065CCEC8  ldr      x2, [x9, #0x288]
0065CCECC  ldr      x1, [x9, #0x290]
0065CCED0  b        #0x65cc8d4 ; 
0065CCED4  bl       #0x382bfb8 ; 
0065CCED8  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$TriggerBossNoticeStart
; RVA 0x65CCEDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CCEDC  stp      x30, x21, [sp, #-0x20]!
0065CCEE0  stp      x20, x19, [sp, #0x10]
0065CCEE4  adrp     x20, #0x9599000
0065CCEE8  adrp     x21, #0x8f0a000
0065CCEEC  ldrb     w8, [x20, #0x57e]
0065CCEF0  ldr      x21, [x21, #0x880]
0065CCEF4  mov      x19, x0
0065CCEF8  tbnz     w8, #0, #0x65ccf1c
0065CCEFC  adrp     x0, #0x8f09000
0065CCF00  ldr      x0, [x0, #0xc08]
0065CCF04  bl       #0x382bd14 ; 
0065CCF08  adrp     x0, #0x8f0a000
0065CCF0C  ldr      x0, [x0, #0x880]
0065CCF10  bl       #0x382bd14 ; 
0065CCF14  mov      w8, #1
0065CCF18  strb     w8, [x20, #0x57e]
0065CCF1C  ldr      x1, [x21]
0065CCF20  ldrb     w8, [x1, #0x53]
0065CCF24  tbnz     w8, #5, #0x65ccf64
0065CCF28  adrp     x20, #0x9599000
0065CCF2C  ldrb     w8, [x20, #0x286]
0065CCF30  cbnz     w8, #0x65ccf48
0065CCF34  adrp     x0, #0x8f07000
0065CCF38  ldr      x0, [x0, #0xc98]
0065CCF3C  bl       #0x382bd14 ; 
0065CCF40  mov      w8, #1
0065CCF44  strb     w8, [x20, #0x286]
0065CCF48  adrp     x8, #0x8f07000
0065CCF4C  ldr      x8, [x8, #0xc98]
0065CCF50  ldr      x1, [x8]
0065CCF54  ldrb     w8, [x1, #0x53]
0065CCF58  tbnz     w8, #5, #0x65ccf78
0065CCF5C  ldr      x20, [x19, #0x80]
0065CCF60  b        #0x65ccf88 ; 
0065CCF64  ldr      x2, [x1, #0x60]
0065CCF68  mov      x0, x19
0065CCF6C  ldp      x20, x19, [sp, #0x10]
0065CCF70  ldp      x30, x21, [sp], #0x20
0065CCF74  br       x2
0065CCF78  ldr      x8, [x1, #0x60]
0065CCF7C  mov      x0, x19
0065CCF80  blr      x8
0065CCF84  mov      x20, x0
0065CCF88  cbz      x20, #0x65cd0ec
0065CCF8C  adrp     x21, #0x9599000
0065CCF90  ldrb     w8, [x21, #0x28d]
0065CCF94  cbnz     w8, #0x65ccfac
0065CCF98  adrp     x0, #0x8f07000
0065CCF9C  ldr      x0, [x0, #0xe98]
0065CCFA0  bl       #0x382bd14 ; 
0065CCFA4  mov      w8, #1
0065CCFA8  strb     w8, [x21, #0x28d]
0065CCFAC  adrp     x8, #0x8f07000
0065CCFB0  ldr      x8, [x8, #0xe98]
0065CCFB4  ldr      x1, [x8]
0065CCFB8  ldrb     w8, [x1, #0x53]
0065CCFBC  tbnz     w8, #5, #0x65ccffc
0065CCFC0  adrp     x21, #0x9599000
0065CCFC4  ldrb     w8, [x21, #0x2ab]
0065CCFC8  cbnz     w8, #0x65ccfe0
0065CCFCC  adrp     x0, #0x8f07000
0065CCFD0  ldr      x0, [x0, #0xea0]
0065CCFD4  bl       #0x382bd14 ; 
0065CCFD8  mov      w8, #1
0065CCFDC  strb     w8, [x21, #0x2ab]
0065CCFE0  adrp     x8, #0x8f07000
0065CCFE4  ldr      x8, [x8, #0xea0]
0065CCFE8  ldr      x1, [x8]
0065CCFEC  ldrb     w8, [x1, #0x53]
0065CCFF0  tbnz     w8, #5, #0x65cd008
0065CCFF4  ldr      w21, [x20, #0x324]
0065CCFF8  b        #0x65cd018 ; 
0065CCFFC  ldr      x8, [x1, #0x60]
0065CD000  mov      x0, x20
0065CD004  b        #0x65cd010 ; 
0065CD008  ldr      x8, [x1, #0x60]
0065CD00C  add      x0, x20, #0x290
0065CD010  blr      x8
0065CD014  mov      w21, w0
0065CD018  mov      x0, x19
0065CD01C  mov      x1, xzr
0065CD020  bl       #0x65873a4 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_IsWaitingForWaveStartUIProgress
0065CD024  tbz      w0, #0, #0x65cd058
0065CD028  ldr      w8, [x19, #0xe0]
0065CD02C  cmp      w8, #2
0065CD030  b.ne     #0x65cd058
0065CD034  ldr      x20, [x19, #0x188]
0065CD038  cbz      x20, #0x65cd058
0065CD03C  ldr      w8, [x19, #0x19c]
0065CD040  cmp      w8, w21
0065CD044  b.ne     #0x65cd064
0065CD048  ldr      w9, [x19, #0x1a0]
0065CD04C  ldr      w8, [x19, #0x198]
0065CD050  cmp      w9, w8
0065CD054  b.ne     #0x65cd068
0065CD058  ldp      x20, x19, [sp, #0x10]
0065CD05C  ldp      x30, x21, [sp], #0x20
0065CD060  ret      
0065CD064  ldr      w8, [x19, #0x198]
0065CD068  str      w21, [x19, #0x19c]
0065CD06C  str      w8, [x19, #0x1a0]
0065CD070  adrp     x10, #0x8f09000
0065CD074  ldr      x8, [x20]
0065CD078  ldr      x10, [x10, #0xc08]
0065CD07C  ldrh     w9, [x8, #0x12e]
0065CD080  ldr      x1, [x10]
0065CD084  cbz      x9, #0x65cd0a8
0065CD088  ldr      x10, [x8, #0xb0]
0065CD08C  add      x10, x10, #8
0065CD090  ldur     x11, [x10, #-8]
0065CD094  cmp      x11, x1
0065CD098  b.eq     #0x65cd0b8
0065CD09C  subs     x9, x9, #1
0065CD0A0  add      x10, x10, #0x10
0065CD0A4  b.ne     #0x65cd090
0065CD0A8  mov      w2, #2
0065CD0AC  mov      x0, x20
0065CD0B0  bl       #0x3a7e710 ; 
0065CD0B4  b        #0x65cd0c8 ; 
0065CD0B8  ldr      w9, [x10]
0065CD0BC  add      w9, w9, #2
0065CD0C0  add      x8, x8, w9, sxtw #4
0065CD0C4  add      x0, x8, #0x138
0065CD0C8  ldp      x8, x1, [x0]
0065CD0CC  mov      x0, x20
0065CD0D0  blr      x8
0065CD0D4  ldr      w2, [x19, #0x198]
0065CD0D8  mov      w1, w0
0065CD0DC  mov      x0, x19
0065CD0E0  ldp      x20, x19, [sp, #0x10]
0065CD0E4  ldp      x30, x21, [sp], #0x20
0065CD0E8  b        #0x65c4804 ; HotFix.BattleLogic.SinglePlayerBattleManager$$TriggerBossNoticeStartEvent
0065CD0EC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckIsWaveFirstSelectSkill
; RVA 0x65CD0F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CD0F0  stp      x30, x21, [sp, #-0x20]!
0065CD0F4  stp      x20, x19, [sp, #0x10]
0065CD0F8  adrp     x20, #0x9599000
0065CD0FC  adrp     x21, #0x8f0a000
0065CD100  ldrb     w8, [x20, #0x57f]
0065CD104  ldr      x21, [x21, #0x888]
0065CD108  mov      x19, x0
0065CD10C  tbnz     w8, #0, #0x65cd124
0065CD110  adrp     x0, #0x8f0a000
0065CD114  ldr      x0, [x0, #0x888]
0065CD118  bl       #0x382bd14 ; 
0065CD11C  mov      w8, #1
0065CD120  strb     w8, [x20, #0x57f]
0065CD124  ldr      x1, [x21]
0065CD128  ldrb     w8, [x1, #0x53]
0065CD12C  tbnz     w8, #5, #0x65cd144
0065CD130  ldrb     w0, [x19, #0x210]
0065CD134  strb     wzr, [x19, #0x210]
0065CD138  ldp      x20, x19, [sp, #0x10]
0065CD13C  ldp      x30, x21, [sp], #0x20
0065CD140  ret      
0065CD144  ldr      x2, [x1, #0x60]
0065CD148  mov      x0, x19
0065CD14C  ldp      x20, x19, [sp, #0x10]
0065CD150  ldp      x30, x21, [sp], #0x20
0065CD154  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$tryClearBeeMonsterCreators
; RVA 0x65CC650; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CC650  sub      sp, sp, #0x40
0065CC654  stp      x30, x21, [sp, #0x20]
0065CC658  stp      x20, x19, [sp, #0x30]
0065CC65C  adrp     x20, #0x9599000
0065CC660  adrp     x21, #0x8f0a000
0065CC664  ldrb     w8, [x20, #0x580]
0065CC668  ldr      x21, [x21, #0x840]
0065CC66C  mov      x19, x0
0065CC670  tbnz     w8, #0, #0x65cc6d0
0065CC674  adrp     x0, #0x8f0a000
0065CC678  ldr      x0, [x0, #0x848]
0065CC67C  bl       #0x382bd14 ; 
0065CC680  adrp     x0, #0x8f0a000
0065CC684  ldr      x0, [x0, #0x850]
0065CC688  bl       #0x382bd14 ; 
0065CC68C  adrp     x0, #0x8f0a000
0065CC690  ldr      x0, [x0, #0x858]
0065CC694  bl       #0x382bd14 ; 
0065CC698  adrp     x0, #0x8f0a000
0065CC69C  ldr      x0, [x0, #0x860]
0065CC6A0  bl       #0x382bd14 ; 
0065CC6A4  adrp     x0, #0x8f0a000
0065CC6A8  ldr      x0, [x0, #0x868]
0065CC6AC  bl       #0x382bd14 ; 
0065CC6B0  adrp     x0, #0x8f0a000
0065CC6B4  ldr      x0, [x0, #0x870]
0065CC6B8  bl       #0x382bd14 ; 
0065CC6BC  adrp     x0, #0x8f0a000
0065CC6C0  ldr      x0, [x0, #0x840]
0065CC6C4  bl       #0x382bd14 ; 
0065CC6C8  mov      w8, #1
0065CC6CC  strb     w8, [x20, #0x580]
0065CC6D0  ldr      x1, [x21]
0065CC6D4  ldrb     w8, [x1, #0x53]
0065CC6D8  tbnz     w8, #5, #0x65cc73c
0065CC6DC  stp      xzr, xzr, [sp, #8]
0065CC6E0  str      xzr, [sp, #0x18]
0065CC6E4  ldr      x0, [x19, #0x190]
0065CC6E8  add      x19, x19, #0x190
0065CC6EC  cbz      x0, #0x65cc794
0065CC6F0  ldr      w8, [x0, #0x18]
0065CC6F4  cmp      w8, #1
0065CC6F8  b.lt     #0x65cc768
0065CC6FC  adrp     x8, #0x8f0a000
0065CC700  ldr      x8, [x8, #0x868]
0065CC704  ldr      x1, [x8]
0065CC708  add      x8, sp, #8
0065CC70C  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
0065CC710  adrp     x20, #0x8f0a000
0065CC714  ldr      x20, [x20, #0x850]
0065CC718  ldr      x1, [x20]
0065CC71C  add      x0, sp, #8
0065CC720  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
0065CC724  tbz      w0, #0, #0x65cc754
0065CC728  ldr      x0, [sp, #0x18]
0065CC72C  cbz      x0, #0x65cc7b4
0065CC730  mov      x1, xzr
0065CC734  bl       #0x65bb12c ; HotFix.BattleLogic.BeeMonsterCreator$$OnMissionClear
0065CC738  b        #0x65cc718 ; 
0065CC73C  ldr      x2, [x1, #0x60]
0065CC740  mov      x0, x19
0065CC744  ldp      x20, x19, [sp, #0x30]
0065CC748  ldp      x30, x21, [sp, #0x20]
0065CC74C  add      sp, sp, #0x40
0065CC750  br       x2
0065CC754  adrp     x8, #0x8f0a000
0065CC758  ldr      x8, [x8, #0x848]
0065CC75C  add      x0, sp, #8
0065CC760  ldr      x1, [x8]
0065CC764  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065CC768  ldr      x8, [x19]
0065CC76C  cbz      x8, #0x65cc7b8
0065CC770  ldp      w2, w9, [x8, #0x18]
0065CC774  add      w9, w9, #1
0065CC778  cmp      w2, #1
0065CC77C  stp      wzr, w9, [x8, #0x18]
0065CC780  b.lt     #0x65cc794
0065CC784  ldr      x0, [x8, #0x10]
0065CC788  mov      w1, wzr
0065CC78C  mov      x3, xzr
0065CC790  bl       #0x7c001d0 ; System.Array$$Clear
0065CC794  mov      x0, x19
0065CC798  mov      x1, xzr
0065CC79C  str      xzr, [x19]
0065CC7A0  bl       #0x382bcb8 ; 
0065CC7A4  ldp      x20, x19, [sp, #0x30]
0065CC7A8  ldp      x30, x21, [sp, #0x20]
0065CC7AC  add      sp, sp, #0x40
0065CC7B0  ret      
0065CC7B4  bl       #0x382bfb8 ; 
0065CC7B8  bl       #0x382bfb8 ; 
0065CC7BC  b        #0x65cc7c4 ; 
0065CC7C0  b        #0x65cc7c4 ; 
0065CC7C4  mov      x20, x0
0065CC7C8  cmp      w1, #1
0065CC7CC  b.ne     #0x65cc800
0065CC7D0  mov      x0, x20
0065CC7D4  bl       #0x89eda50 ; 
0065CC7D8  ldr      x21, [x0]
0065CC7DC  bl       #0x89eda60 ; 
0065CC7E0  adrp     x8, #0x8f0a000
0065CC7E4  ldr      x8, [x8, #0x848]
0065CC7E8  add      x0, sp, #8
0065CC7EC  ldr      x1, [x8]
0065CC7F0  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065CC7F4  cbz      x21, #0x65cc768
0065CC7F8  mov      x0, x21
0065CC7FC  bl       #0x382bfb0 ; 
0065CC800  mov      x21, xzr
0065CC804  b        #0x65cc80c ; 
0065CC808  mov      x20, x0
0065CC80C  adrp     x8, #0x8f0a000
0065CC810  ldr      x8, [x8, #0x848]
0065CC814  ldr      x1, [x8]
0065CC818  add      x0, sp, #8
0065CC81C  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065CC820  cbnz     x21, #0x65cc82c
0065CC824  mov      x0, x20
0065CC828  bl       #0x3b56bfc ; 
0065CC82C  mov      x0, x21
0065CC830  bl       #0x382bfb0 ; 
0065CC834  bl       #0x3442448 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$RefreshMonsters
; RVA 0x65CD158; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CD158  str      x30, [sp, #-0x50]!
0065CD15C  stp      x26, x25, [sp, #0x10]
0065CD160  stp      x24, x23, [sp, #0x20]
0065CD164  stp      x22, x21, [sp, #0x30]
0065CD168  stp      x20, x19, [sp, #0x40]
0065CD16C  adrp     x20, #0x9599000
0065CD170  adrp     x21, #0x8f0a000
0065CD174  ldrb     w8, [x20, #0x581]
0065CD178  ldr      x21, [x21, #0x890]
0065CD17C  mov      x19, x0
0065CD180  tbnz     w8, #0, #0x65cd1a4
0065CD184  adrp     x0, #0x8f09000
0065CD188  ldr      x0, [x0, #0xc08]
0065CD18C  bl       #0x382bd14 ; 
0065CD190  adrp     x0, #0x8f0a000
0065CD194  ldr      x0, [x0, #0x890]
0065CD198  bl       #0x382bd14 ; 
0065CD19C  mov      w8, #1
0065CD1A0  strb     w8, [x20, #0x581]
0065CD1A4  ldr      x1, [x21]
0065CD1A8  ldrb     w8, [x1, #0x53]
0065CD1AC  tbnz     w8, #5, #0x65cd1d0
0065CD1B0  ldrb     w8, [x19, #0x78]
0065CD1B4  cbz      w8, #0x65cd1f0
0065CD1B8  ldp      x20, x19, [sp, #0x40]
0065CD1BC  ldp      x22, x21, [sp, #0x30]
0065CD1C0  ldp      x24, x23, [sp, #0x20]
0065CD1C4  ldp      x26, x25, [sp, #0x10]
0065CD1C8  ldr      x30, [sp], #0x50
0065CD1CC  ret      
0065CD1D0  ldr      x2, [x1, #0x60]
0065CD1D4  mov      x0, x19
0065CD1D8  ldp      x20, x19, [sp, #0x40]
0065CD1DC  ldp      x22, x21, [sp, #0x30]
0065CD1E0  ldp      x24, x23, [sp, #0x20]
0065CD1E4  ldp      x26, x25, [sp, #0x10]
0065CD1E8  ldr      x30, [sp], #0x50
0065CD1EC  br       x2
0065CD1F0  mov      x0, x19
0065CD1F4  mov      x1, xzr
0065CD1F8  bl       #0x6587904 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$MarkLastMissionRefreshStarted
0065CD1FC  ldr      x20, [x19, #0x188]
0065CD200  cbz      x20, #0x65cd7c0
0065CD204  adrp     x26, #0x8f09000
0065CD208  ldr      x8, [x20]
0065CD20C  ldr      x26, [x26, #0xc08]
0065CD210  ldrh     w9, [x8, #0x12e]
0065CD214  ldr      x1, [x26]
0065CD218  cbz      x9, #0x65cd23c
0065CD21C  ldr      x10, [x8, #0xb0]
0065CD220  add      x10, x10, #8
0065CD224  ldur     x11, [x10, #-8]
0065CD228  cmp      x11, x1
0065CD22C  b.eq     #0x65cd24c
0065CD230  subs     x9, x9, #1
0065CD234  add      x10, x10, #0x10
0065CD238  b.ne     #0x65cd224
0065CD23C  mov      w2, #8
0065CD240  mov      x0, x20
0065CD244  bl       #0x3a7e710 ; 
0065CD248  b        #0x65cd25c ; 
0065CD24C  ldr      w9, [x10]
0065CD250  add      w9, w9, #8
0065CD254  add      x8, x8, w9, sxtw #4
0065CD258  add      x0, x8, #0x138
0065CD25C  ldp      x8, x1, [x0]
0065CD260  mov      x0, x20
0065CD264  blr      x8
0065CD268  adrp     x24, #0x8f07000
0065CD26C  ldr      x24, [x24, #0xc98]
0065CD270  cmp      w0, #9
0065CD274  adrp     x25, #0x9599000
0065CD278  b.eq     #0x65cd36c
0065CD27C  ldr      x20, [x19, #0x140]
0065CD280  cbz      x20, #0x65cd7c0
0065CD284  adrp     x22, #0x9599000
0065CD288  ldrb     w8, [x22, #0x656]
0065CD28C  cbnz     w8, #0x65cd2a4
0065CD290  adrp     x0, #0x8f0a000
0065CD294  ldr      x0, [x0, #0x898]
0065CD298  bl       #0x382bd14 ; 
0065CD29C  mov      w8, #1
0065CD2A0  strb     w8, [x22, #0x656]
0065CD2A4  adrp     x23, #0x8f0a000
0065CD2A8  ldr      x23, [x23, #0x898]
0065CD2AC  ldr      x1, [x23]
0065CD2B0  ldrb     w8, [x1, #0x53]
0065CD2B4  tbnz     w8, #5, #0x65cd2c0
0065CD2B8  ldr      w0, [x20, #0x68]
0065CD2BC  b        #0x65cd2cc ; 
0065CD2C0  ldr      x8, [x1, #0x60]
0065CD2C4  mov      x0, x20
0065CD2C8  blr      x8
0065CD2CC  cmp      w0, #1
0065CD2D0  b.lt     #0x65cd36c
0065CD2D4  ldrb     w8, [x25, #0x286]
0065CD2D8  cbnz     w8, #0x65cd2f0
0065CD2DC  adrp     x0, #0x8f07000
0065CD2E0  ldr      x0, [x0, #0xc98]
0065CD2E4  bl       #0x382bd14 ; 
0065CD2E8  mov      w8, #1
0065CD2EC  strb     w8, [x25, #0x286]
0065CD2F0  ldr      x1, [x24]
0065CD2F4  ldrb     w8, [x1, #0x53]
0065CD2F8  tbnz     w8, #5, #0x65cd304
0065CD2FC  ldr      x20, [x19, #0x80]
0065CD300  b        #0x65cd314 ; 
0065CD304  ldr      x8, [x1, #0x60]
0065CD308  mov      x0, x19
0065CD30C  blr      x8
0065CD310  mov      x20, x0
0065CD314  ldr      x21, [x19, #0x140]
0065CD318  cbz      x21, #0x65cd7c0
0065CD31C  ldrb     w8, [x22, #0x656]
0065CD320  cbnz     w8, #0x65cd338
0065CD324  adrp     x0, #0x8f0a000
0065CD328  ldr      x0, [x0, #0x898]
0065CD32C  bl       #0x382bd14 ; 
0065CD330  mov      w8, #1
0065CD334  strb     w8, [x22, #0x656]
0065CD338  ldr      x1, [x23]
0065CD33C  ldrb     w8, [x1, #0x53]
0065CD340  tbnz     w8, #5, #0x65cd34c
0065CD344  ldr      w1, [x21, #0x68]
0065CD348  b        #0x65cd35c ; 
0065CD34C  ldr      x8, [x1, #0x60]
0065CD350  mov      x0, x21
0065CD354  blr      x8
0065CD358  mov      w1, w0
0065CD35C  cbz      x20, #0x65cd7c0
0065CD360  mov      x0, x20
0065CD364  mov      x2, xzr
0065CD368  bl       #0x6a076cc ; HotFix.BattleLogic.BattleWorldContext$$PlayMusic
0065CD36C  ldr      w8, [x19, #0xe0]
0065CD370  mov      x0, x19
0065CD374  cmp      w8, #9
0065CD378  b.ne     #0x65cd384
0065CD37C  bl       #0x65cd7c4 ; HotFix.BattleLogic.WaterfallBattleManager$$CreatePunchboardNpc
0065CD380  b        #0x65cd390 ; 
0065CD384  mov      x1, xzr
0065CD388  mov      x2, xzr
0065CD38C  bl       #0x6588698 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreateMissionNpc
0065CD390  ldr      w8, [x19, #0xe0]
0065CD394  cmp      w8, #0xa
0065CD398  b.ne     #0x65cd3ac
0065CD39C  mov      w1, #1
0065CD3A0  mov      x0, x19
0065CD3A4  mov      w2, wzr
0065CD3A8  bl       #0x65c0900 ; HotFix.BattleLogic.SinglePlayerBattleManager$$CreateHp
0065CD3AC  mov      x0, x19
0065CD3B0  bl       #0x65cd8ec ; HotFix.BattleLogic.WaterfallBattleManager$$RefreshRandomNpc
0065CD3B4  ldr      x20, [x19, #0x188]
0065CD3B8  cbz      x20, #0x65cd7c0
0065CD3BC  ldr      x8, [x20]
0065CD3C0  ldr      x1, [x26]
0065CD3C4  ldrh     w9, [x8, #0x12e]
0065CD3C8  cbz      x9, #0x65cd3ec
0065CD3CC  ldr      x10, [x8, #0xb0]
0065CD3D0  add      x10, x10, #8
0065CD3D4  ldur     x11, [x10, #-8]
0065CD3D8  cmp      x11, x1
0065CD3DC  b.eq     #0x65cd3fc
0065CD3E0  subs     x9, x9, #1
0065CD3E4  add      x10, x10, #0x10
0065CD3E8  b.ne     #0x65cd3d4
0065CD3EC  mov      w2, #0x1c
0065CD3F0  mov      x0, x20
0065CD3F4  bl       #0x3a7e710 ; 
0065CD3F8  b        #0x65cd40c ; 
0065CD3FC  ldr      w9, [x10]
0065CD400  add      w9, w9, #0x1c
0065CD404  add      x8, x8, w9, sxtw #4
0065CD408  add      x0, x8, #0x138
0065CD40C  ldp      x8, x1, [x0]
0065CD410  mov      x0, x20
0065CD414  blr      x8
0065CD418  ldr      x21, [x19, #0x188]
0065CD41C  cbz      x21, #0x65cd7c0
0065CD420  ldr      x8, [x21]
0065CD424  ldr      x1, [x26]
0065CD428  mov      x20, x0
0065CD42C  ldrh     w9, [x8, #0x12e]
0065CD430  cbz      x9, #0x65cd454
0065CD434  ldr      x10, [x8, #0xb0]
0065CD438  add      x10, x10, #8
0065CD43C  ldur     x11, [x10, #-8]
0065CD440  cmp      x11, x1
0065CD444  b.eq     #0x65cd464
0065CD448  subs     x9, x9, #1
0065CD44C  add      x10, x10, #0x10
0065CD450  b.ne     #0x65cd43c
0065CD454  mov      w2, #0x1e
0065CD458  mov      x0, x21
0065CD45C  bl       #0x3a7e710 ; 
0065CD460  b        #0x65cd474 ; 
0065CD464  ldr      w9, [x10]
0065CD468  add      w9, w9, #0x1e
0065CD46C  add      x8, x8, w9, sxtw #4
0065CD470  add      x0, x8, #0x138
0065CD474  ldp      x8, x1, [x0]
0065CD478  mov      x0, x21
0065CD47C  blr      x8
0065CD480  ldr      x22, [x19, #0x188]
0065CD484  cbz      x22, #0x65cd7c0
0065CD488  ldr      x8, [x22]
0065CD48C  ldr      x1, [x26]
0065CD490  mov      x21, x0
0065CD494  ldrh     w9, [x8, #0x12e]
0065CD498  cbz      x9, #0x65cd4bc
0065CD49C  ldr      x10, [x8, #0xb0]
0065CD4A0  add      x10, x10, #8
0065CD4A4  ldur     x11, [x10, #-8]
0065CD4A8  cmp      x11, x1
0065CD4AC  b.eq     #0x65cd4cc
0065CD4B0  subs     x9, x9, #1
0065CD4B4  add      x10, x10, #0x10
0065CD4B8  b.ne     #0x65cd4a4
0065CD4BC  mov      w2, #0x20
0065CD4C0  mov      x0, x22
0065CD4C4  bl       #0x3a7e710 ; 
0065CD4C8  b        #0x65cd4dc ; 
0065CD4CC  ldr      w9, [x10]
0065CD4D0  add      w9, w9, #0x20
0065CD4D4  add      x8, x8, w9, sxtw #4
0065CD4D8  add      x0, x8, #0x138
0065CD4DC  ldp      x8, x1, [x0]
0065CD4E0  mov      x0, x22
0065CD4E4  blr      x8
0065CD4E8  ldr      x23, [x19, #0x188]
0065CD4EC  cbz      x23, #0x65cd7c0
0065CD4F0  ldr      x8, [x23]
0065CD4F4  ldr      x1, [x26]
0065CD4F8  mov      x22, x0
0065CD4FC  ldrh     w9, [x8, #0x12e]
0065CD500  cbz      x9, #0x65cd524
0065CD504  ldr      x10, [x8, #0xb0]
0065CD508  add      x10, x10, #8
0065CD50C  ldur     x11, [x10, #-8]
0065CD510  cmp      x11, x1
0065CD514  b.eq     #0x65cd534
0065CD518  subs     x9, x9, #1
0065CD51C  add      x10, x10, #0x10
0065CD520  b.ne     #0x65cd50c
0065CD524  mov      w2, #0x22
0065CD528  mov      x0, x23
0065CD52C  bl       #0x3a7e710 ; 
0065CD530  b        #0x65cd544 ; 
0065CD534  ldr      w9, [x10]
0065CD538  add      w9, w9, #0x22
0065CD53C  add      x8, x8, w9, sxtw #4
0065CD540  add      x0, x8, #0x138
0065CD544  ldp      x8, x1, [x0]
0065CD548  mov      x0, x23
0065CD54C  blr      x8
0065CD550  mov      x4, x0
0065CD554  mov      x0, x19
0065CD558  mov      x1, x20
0065CD55C  mov      x2, x21
0065CD560  mov      x3, x22
0065CD564  mov      x5, xzr
0065CD568  bl       #0x65910f4 ; HotFix.BattleLogic.BattleManager$$AddExBattleAttr
0065CD56C  ldrb     w8, [x25, #0x286]
0065CD570  cbnz     w8, #0x65cd588
0065CD574  adrp     x0, #0x8f07000
0065CD578  ldr      x0, [x0, #0xc98]
0065CD57C  bl       #0x382bd14 ; 
0065CD580  mov      w8, #1
0065CD584  strb     w8, [x25, #0x286]
0065CD588  ldr      x1, [x24]
0065CD58C  ldrb     w8, [x1, #0x53]
0065CD590  tbnz     w8, #5, #0x65cd59c
0065CD594  ldr      x20, [x19, #0x80]
0065CD598  b        #0x65cd5ac ; 
0065CD59C  ldr      x8, [x1, #0x60]
0065CD5A0  mov      x0, x19
0065CD5A4  blr      x8
0065CD5A8  mov      x20, x0
0065CD5AC  cbz      x20, #0x65cd7c0
0065CD5B0  adrp     x21, #0x9591000
0065CD5B4  ldrb     w8, [x21, #0xa9c]
0065CD5B8  cbnz     w8, #0x65cd5d0
0065CD5BC  adrp     x0, #0x8ee6000
0065CD5C0  ldr      x0, [x0, #0xaf0]
0065CD5C4  bl       #0x382bd14 ; 
0065CD5C8  mov      w8, #1
0065CD5CC  strb     w8, [x21, #0xa9c]
0065CD5D0  adrp     x8, #0x8ee6000
0065CD5D4  ldr      x8, [x8, #0xaf0]
0065CD5D8  ldr      x1, [x8]
0065CD5DC  ldrb     w8, [x1, #0x53]
0065CD5E0  tbnz     w8, #5, #0x65cd5ec
0065CD5E4  ldr      x20, [x20, #0x240]
0065CD5E8  b        #0x65cd5fc ; 
0065CD5EC  ldr      x8, [x1, #0x60]
0065CD5F0  mov      x0, x20
0065CD5F4  blr      x8
0065CD5F8  mov      x20, x0
0065CD5FC  cbz      x20, #0x65cd7c0
0065CD600  adrp     x21, #0x9599000
0065CD604  ldrb     w8, [x21, #0x26f]
0065CD608  cbnz     w8, #0x65cd620
0065CD60C  adrp     x0, #0x8f06000
0065CD610  ldr      x0, [x0, #0xd58]
0065CD614  bl       #0x382bd14 ; 
0065CD618  mov      w8, #1
0065CD61C  strb     w8, [x21, #0x26f]
0065CD620  adrp     x8, #0x8f06000
0065CD624  ldr      x8, [x8, #0xd58]
0065CD628  ldr      x1, [x8]
0065CD62C  ldrb     w8, [x1, #0x53]
0065CD630  tbnz     w8, #5, #0x65cd63c
0065CD634  ldr      x20, [x20, #0x20]
0065CD638  b        #0x65cd64c ; 
0065CD63C  ldr      x8, [x1, #0x60]
0065CD640  mov      x0, x20
0065CD644  blr      x8
0065CD648  mov      x20, x0
0065CD64C  ldrb     w8, [x25, #0x286]
0065CD650  cbnz     w8, #0x65cd668
0065CD654  adrp     x0, #0x8f07000
0065CD658  ldr      x0, [x0, #0xc98]
0065CD65C  bl       #0x382bd14 ; 
0065CD660  mov      w8, #1
0065CD664  strb     w8, [x25, #0x286]
0065CD668  ldr      x1, [x24]
0065CD66C  ldrb     w8, [x1, #0x53]
0065CD670  tbnz     w8, #5, #0x65cd67c
0065CD674  ldr      x21, [x19, #0x80]
0065CD678  b        #0x65cd68c ; 
0065CD67C  ldr      x8, [x1, #0x60]
0065CD680  mov      x0, x19
0065CD684  blr      x8
0065CD688  mov      x21, x0
0065CD68C  cbz      x21, #0x65cd7c0
0065CD690  adrp     x22, #0x9599000
0065CD694  ldrb     w8, [x22, #0x28d]
0065CD698  cbnz     w8, #0x65cd6b0
0065CD69C  adrp     x0, #0x8f07000
0065CD6A0  ldr      x0, [x0, #0xe98]
0065CD6A4  bl       #0x382bd14 ; 
0065CD6A8  mov      w8, #1
0065CD6AC  strb     w8, [x22, #0x28d]
0065CD6B0  adrp     x8, #0x8f07000
0065CD6B4  ldr      x8, [x8, #0xe98]
0065CD6B8  ldr      x1, [x8]
0065CD6BC  ldrb     w8, [x1, #0x53]
0065CD6C0  tbnz     w8, #5, #0x65cd700
0065CD6C4  adrp     x22, #0x9599000
0065CD6C8  ldrb     w8, [x22, #0x2ab]
0065CD6CC  cbnz     w8, #0x65cd6e4
0065CD6D0  adrp     x0, #0x8f07000
0065CD6D4  ldr      x0, [x0, #0xea0]
0065CD6D8  bl       #0x382bd14 ; 
0065CD6DC  mov      w8, #1
0065CD6E0  strb     w8, [x22, #0x2ab]
0065CD6E4  adrp     x8, #0x8f07000
0065CD6E8  ldr      x8, [x8, #0xea0]
0065CD6EC  ldr      x1, [x8]
0065CD6F0  ldrb     w8, [x1, #0x53]
0065CD6F4  tbnz     w8, #5, #0x65cd70c
0065CD6F8  ldr      w1, [x21, #0x324]
0065CD6FC  b        #0x65cd71c ; 
0065CD700  ldr      x8, [x1, #0x60]
0065CD704  mov      x0, x21
0065CD708  b        #0x65cd714 ; 
0065CD70C  ldr      x8, [x1, #0x60]
0065CD710  add      x0, x21, #0x290
0065CD714  blr      x8
0065CD718  mov      w1, w0
0065CD71C  cbz      x20, #0x65cd7c0
0065CD720  mov      x0, x20
0065CD724  mov      x2, xzr
0065CD728  bl       #0x64c63c8 ; MissionData$$LoadPreCountMonsterData
0065CD72C  ldr      w8, [x19, #0xe0]
0065CD730  cmp      w8, #0xb
0065CD734  b.ne     #0x65cd754
0065CD738  mov      x0, x19
0065CD73C  ldp      x20, x19, [sp, #0x40]
0065CD740  ldp      x22, x21, [sp, #0x30]
0065CD744  ldp      x24, x23, [sp, #0x20]
0065CD748  ldp      x26, x25, [sp, #0x10]
0065CD74C  ldr      x30, [sp], #0x50
0065CD750  b        #0x65cdb00 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileNpc
0065CD754  ldrb     w8, [x25, #0x286]
0065CD758  cbnz     w8, #0x65cd770
0065CD75C  adrp     x0, #0x8f07000
0065CD760  ldr      x0, [x0, #0xc98]
0065CD764  bl       #0x382bd14 ; 
0065CD768  mov      w8, #1
0065CD76C  strb     w8, [x25, #0x286]
0065CD770  ldr      x1, [x24]
0065CD774  ldrb     w8, [x1, #0x53]
0065CD778  tbnz     w8, #5, #0x65cd784
0065CD77C  ldr      x0, [x19, #0x80]
0065CD780  b        #0x65cd790 ; 
0065CD784  ldr      x8, [x1, #0x60]
0065CD788  mov      x0, x19
0065CD78C  blr      x8
0065CD790  cbz      x0, #0x65cd7c0
0065CD794  ldrb     w8, [x0, #0x15]
0065CD798  cbz      w8, #0x65cd7a4
0065CD79C  mov      x0, x19
0065CD7A0  bl       #0x65ce0b0 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateBeeMonsterCreator
0065CD7A4  mov      x0, x19
0065CD7A8  ldp      x20, x19, [sp, #0x40]
0065CD7AC  ldp      x22, x21, [sp, #0x30]
0065CD7B0  ldp      x24, x23, [sp, #0x20]
0065CD7B4  ldp      x26, x25, [sp, #0x10]
0065CD7B8  ldr      x30, [sp], #0x50
0065CD7BC  b        #0x65ce3f4 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateIntervalMonster
0065CD7C0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$tryStartMissileBoostOnWaveStart
; RVA 0x65CE628; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CE628  stp      x30, x21, [sp, #-0x20]!
0065CE62C  stp      x20, x19, [sp, #0x10]
0065CE630  adrp     x20, #0x9599000
0065CE634  adrp     x21, #0x8f0a000
0065CE638  ldrb     w8, [x20, #0x582]
0065CE63C  ldr      x21, [x21, #0x8f8]
0065CE640  mov      x19, x0
0065CE644  tbnz     w8, #0, #0x65ce668
0065CE648  adrp     x0, #0x8f07000
0065CE64C  ldr      x0, [x0, #0xfd0]
0065CE650  bl       #0x382bd14 ; 
0065CE654  adrp     x0, #0x8f0a000
0065CE658  ldr      x0, [x0, #0x8f8]
0065CE65C  bl       #0x382bd14 ; 
0065CE660  mov      w8, #1
0065CE664  strb     w8, [x20, #0x582]
0065CE668  ldr      x1, [x21]
0065CE66C  ldrb     w8, [x1, #0x53]
0065CE670  tbnz     w8, #5, #0x65ce6cc
0065CE674  mov      x0, x19
0065CE678  mov      x1, xzr
0065CE67C  str      xzr, [x19, #0x1c0]
0065CE680  bl       #0x659025c ; HotFix.BattleLogic.BattleManager$$InvokeOnWaveStart
0065CE684  ldr      x8, [x19, #0x1b0]
0065CE688  cmp      x8, #1
0065CE68C  b.lt     #0x65ce6e0
0065CE690  ldrb     w8, [x19, #0x1a5]
0065CE694  cbz      w8, #0x65ce6bc
0065CE698  ldrb     w8, [x19, #0x1a6]
0065CE69C  cbnz     w8, #0x65ce6bc
0065CE6A0  ldr      x0, [x19, #0x88]
0065CE6A4  cbz      x0, #0x65ce6ec
0065CE6A8  adrp     x8, #0x8f07000
0065CE6AC  ldr      x8, [x8, #0xfd0]
0065CE6B0  mov      w1, #0x2a
0065CE6B4  ldr      x2, [x8]
0065CE6B8  bl       #0x60b34ec ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0065CE6BC  mov      x0, x19
0065CE6C0  ldp      x20, x19, [sp, #0x10]
0065CE6C4  ldp      x30, x21, [sp], #0x20
0065CE6C8  b        #0x65ce6f0 ; HotFix.BattleLogic.WaterfallBattleManager$$HeroMissileBoostStart
0065CE6CC  ldr      x2, [x1, #0x60]
0065CE6D0  mov      x0, x19
0065CE6D4  ldp      x20, x19, [sp, #0x10]
0065CE6D8  ldp      x30, x21, [sp], #0x20
0065CE6DC  br       x2
0065CE6E0  ldp      x20, x19, [sp, #0x10]
0065CE6E4  ldp      x30, x21, [sp], #0x20
0065CE6E8  ret      
0065CE6EC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$HeroMissileBoostStart
; RVA 0x65CE6F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CE6F0  sub      sp, sp, #0x50
0065CE6F4  stp      x30, x23, [sp, #0x20]
0065CE6F8  stp      x22, x21, [sp, #0x30]
0065CE6FC  stp      x20, x19, [sp, #0x40]
0065CE700  adrp     x20, #0x9599000
0065CE704  adrp     x21, #0x8f0a000
0065CE708  ldrb     w8, [x20, #0x583]
0065CE70C  ldr      x21, [x21, #0x900]
0065CE710  mov      x19, x0
0065CE714  tbnz     w8, #0, #0x65ce75c
0065CE718  adrp     x0, #0x8ee6000
0065CE71C  ldr      x0, [x0, #0xab0]
0065CE720  bl       #0x382bd14 ; 
0065CE724  adrp     x0, #0x8ee2000
0065CE728  ldr      x0, [x0, #0x970]
0065CE72C  bl       #0x382bd14 ; 
0065CE730  adrp     x0, #0x8ebf000
0065CE734  ldr      x0, [x0, #0xba0]
0065CE738  bl       #0x382bd14 ; 
0065CE73C  adrp     x0, #0x8ec2000
0065CE740  ldr      x0, [x0, #0xbc8]
0065CE744  bl       #0x382bd14 ; 
0065CE748  adrp     x0, #0x8f0a000
0065CE74C  ldr      x0, [x0, #0x900]
0065CE750  bl       #0x382bd14 ; 
0065CE754  mov      w8, #1
0065CE758  strb     w8, [x20, #0x583]
0065CE75C  ldr      x1, [x21]
0065CE760  ldrb     w8, [x1, #0x53]
0065CE764  tbnz     w8, #5, #0x65ce8b8
0065CE768  adrp     x8, #0x8ec2000
0065CE76C  ldr      x8, [x8, #0xbc8]
0065CE770  mov      w9, #0x101
0065CE774  strb     wzr, [x19, #0x1a6]
0065CE778  strh     w9, [x19, #0x1a4]
0065CE77C  ldr      x0, [x8]
0065CE780  adrp     x23, #0x8ebf000
0065CE784  ldr      x20, [x19, #0x88]
0065CE788  ldr      x23, [x23, #0xba0]
0065CE78C  mov      w1, #3
0065CE790  bl       #0x382bdfc ; 
0065CE794  mov      x21, x0
0065CE798  ldr      w8, [x19, #0x1a8]
0065CE79C  ldr      x0, [x23]
0065CE7A0  add      x1, sp, #0x1c
0065CE7A4  str      w8, [sp, #0x1c]
0065CE7A8  bl       #0x382be94 ; 
0065CE7AC  cbz      x21, #0x65ce8d8
0065CE7B0  mov      x22, x0
0065CE7B4  cbz      x0, #0x65ce7cc
0065CE7B8  ldr      x8, [x21]
0065CE7BC  mov      x0, x22
0065CE7C0  ldr      x1, [x8, #0x40]
0065CE7C4  bl       #0x382be90 ; 
0065CE7C8  cbz      x0, #0x65ce8dc
0065CE7CC  ldr      w8, [x21, #0x18]
0065CE7D0  cbz      w8, #0x65ce8d4
0065CE7D4  mov      x0, x21
0065CE7D8  str      x22, [x0, #0x20]!
0065CE7DC  mov      x1, x22
0065CE7E0  bl       #0x382bcb8 ; 
0065CE7E4  adrp     x9, #0x8ee2000
0065CE7E8  ldr      x8, [x19, #0x1b0]
0065CE7EC  ldr      x9, [x9, #0x970]
0065CE7F0  add      x1, sp, #0x10
0065CE7F4  str      x8, [sp, #0x10]
0065CE7F8  ldr      x0, [x9]
0065CE7FC  bl       #0x382be94 ; 
0065CE800  mov      x22, x0
0065CE804  cbz      x0, #0x65ce81c
0065CE808  ldr      x8, [x21]
0065CE80C  mov      x0, x22
0065CE810  ldr      x1, [x8, #0x40]
0065CE814  bl       #0x382be90 ; 
0065CE818  cbz      x0, #0x65ce8dc
0065CE81C  ldr      w8, [x21, #0x18]
0065CE820  cmp      w8, #1
0065CE824  b.ls     #0x65ce8d4
0065CE828  mov      x0, x21
0065CE82C  str      x22, [x0, #0x28]!
0065CE830  mov      x1, x22
0065CE834  bl       #0x382bcb8 ; 
0065CE838  ldr      w8, [x19, #0x1b8]
0065CE83C  ldr      x0, [x23]
0065CE840  add      x1, sp, #0xc
0065CE844  str      w8, [sp, #0xc]
0065CE848  bl       #0x382be94 ; 
0065CE84C  mov      x19, x0
0065CE850  cbz      x0, #0x65ce868
0065CE854  ldr      x8, [x21]
0065CE858  mov      x0, x19
0065CE85C  ldr      x1, [x8, #0x40]
0065CE860  bl       #0x382be90 ; 
0065CE864  cbz      x0, #0x65ce8dc
0065CE868  ldr      w8, [x21, #0x18]
0065CE86C  cmp      w8, #2
0065CE870  b.ls     #0x65ce8d4
0065CE874  mov      x0, x21
0065CE878  str      x19, [x0, #0x30]!
0065CE87C  mov      x1, x19
0065CE880  bl       #0x382bcb8 ; 
0065CE884  cbz      x20, #0x65ce8d8
0065CE888  adrp     x8, #0x8ee6000
0065CE88C  ldr      x8, [x8, #0xab0]
0065CE890  mov      w1, #0x29
0065CE894  mov      x0, x20
0065CE898  mov      x2, x21
0065CE89C  ldr      x3, [x8]
0065CE8A0  bl       #0x60b3770 ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0065CE8A4  ldp      x20, x19, [sp, #0x40]
0065CE8A8  ldp      x22, x21, [sp, #0x30]
0065CE8AC  ldp      x30, x23, [sp, #0x20]
0065CE8B0  add      sp, sp, #0x50
0065CE8B4  ret      
0065CE8B8  ldr      x2, [x1, #0x60]
0065CE8BC  mov      x0, x19
0065CE8C0  ldp      x20, x19, [sp, #0x40]
0065CE8C4  ldp      x22, x21, [sp, #0x30]
0065CE8C8  ldp      x30, x23, [sp, #0x20]
0065CE8CC  add      sp, sp, #0x50
0065CE8D0  br       x2
0065CE8D4  bl       #0x382bfc0 ; 
0065CE8D8  bl       #0x382bfb8 ; 
0065CE8DC  bl       #0x382bfdc ; 
0065CE8E0  mov      x1, xzr
0065CE8E4  bl       #0x382be7c ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CreateIntervalMonster
; RVA 0x65CE3F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CE3F4  str      x30, [sp, #-0x30]!
0065CE3F8  stp      x22, x21, [sp, #0x10]
0065CE3FC  stp      x20, x19, [sp, #0x20]
0065CE400  adrp     x20, #0x9599000
0065CE404  adrp     x21, #0x8f0a000
0065CE408  ldrb     w8, [x20, #0x584]
0065CE40C  ldr      x21, [x21, #0x8f0]
0065CE410  mov      x19, x0
0065CE414  tbnz     w8, #0, #0x65ce438
0065CE418  adrp     x0, #0x8f09000
0065CE41C  ldr      x0, [x0, #0xc08]
0065CE420  bl       #0x382bd14 ; 
0065CE424  adrp     x0, #0x8f0a000
0065CE428  ldr      x0, [x0, #0x8f0]
0065CE42C  bl       #0x382bd14 ; 
0065CE430  mov      w8, #1
0065CE434  strb     w8, [x20, #0x584]
0065CE438  ldr      x1, [x21]
0065CE43C  ldrb     w8, [x1, #0x53]
0065CE440  tbnz     w8, #5, #0x65ce494
0065CE444  ldr      x20, [x19, #0x188]
0065CE448  cbz      x20, #0x65ce620
0065CE44C  adrp     x21, #0x8f09000
0065CE450  ldr      x8, [x20]
0065CE454  ldr      x21, [x21, #0xc08]
0065CE458  ldrh     w9, [x8, #0x12e]
0065CE45C  ldr      x1, [x21]
0065CE460  cbz      x9, #0x65ce484
0065CE464  ldr      x10, [x8, #0xb0]
0065CE468  add      x10, x10, #8
0065CE46C  ldur     x11, [x10, #-8]
0065CE470  cmp      x11, x1
0065CE474  b.eq     #0x65ce4ac
0065CE478  subs     x9, x9, #1
0065CE47C  add      x10, x10, #0x10
0065CE480  b.ne     #0x65ce46c
0065CE484  mov      w2, #0xa
0065CE488  mov      x0, x20
0065CE48C  bl       #0x3a7e710 ; 
0065CE490  b        #0x65ce4bc ; 
0065CE494  ldr      x2, [x1, #0x60]
0065CE498  mov      x0, x19
0065CE49C  ldp      x20, x19, [sp, #0x20]
0065CE4A0  ldp      x22, x21, [sp, #0x10]
0065CE4A4  ldr      x30, [sp], #0x30
0065CE4A8  br       x2
0065CE4AC  ldr      w9, [x10]
0065CE4B0  add      w9, w9, #0xa
0065CE4B4  add      x8, x8, w9, sxtw #4
0065CE4B8  add      x0, x8, #0x138
0065CE4BC  ldp      x8, x1, [x0]
0065CE4C0  mov      x0, x20
0065CE4C4  blr      x8
0065CE4C8  cbz      x0, #0x65ce620
0065CE4CC  ldr      x8, [x0, #0x18]
0065CE4D0  cbz      x8, #0x65ce51c
0065CE4D4  ldr      x20, [x19, #0x188]
0065CE4D8  cbz      x20, #0x65ce620
0065CE4DC  ldr      x8, [x20]
0065CE4E0  ldr      x1, [x21]
0065CE4E4  ldrh     w9, [x8, #0x12e]
0065CE4E8  cbz      x9, #0x65ce50c
0065CE4EC  ldr      x10, [x8, #0xb0]
0065CE4F0  add      x10, x10, #8
0065CE4F4  ldur     x11, [x10, #-8]
0065CE4F8  cmp      x11, x1
0065CE4FC  b.eq     #0x65ce528
0065CE500  subs     x9, x9, #1
0065CE504  add      x10, x10, #0x10
0065CE508  b.ne     #0x65ce4f4
0065CE50C  mov      w2, #0xa
0065CE510  mov      x0, x20
0065CE514  bl       #0x3a7e710 ; 
0065CE518  b        #0x65ce538 ; 
0065CE51C  mov      x21, xzr
0065CE520  mov      w8, #1
0065CE524  b        #0x65ce5d8 ; 
0065CE528  ldr      w9, [x10]
0065CE52C  add      w9, w9, #0xa
0065CE530  add      x8, x8, w9, sxtw #4
0065CE534  add      x0, x8, #0x138
0065CE538  ldp      x8, x1, [x0]
0065CE53C  mov      x0, x20
0065CE540  blr      x8
0065CE544  cbz      x0, #0x65ce620
0065CE548  ldr      w8, [x0, #0x18]
0065CE54C  cbz      w8, #0x65ce624
0065CE550  ldr      x20, [x19, #0x188]
0065CE554  cbz      x20, #0x65ce620
0065CE558  ldr      x8, [x20]
0065CE55C  ldr      x22, [x0, #0x20]
0065CE560  ldr      x1, [x21]
0065CE564  ldrh     w9, [x8, #0x12e]
0065CE568  cbz      x9, #0x65ce58c
0065CE56C  ldr      x10, [x8, #0xb0]
0065CE570  add      x10, x10, #8
0065CE574  ldur     x11, [x10, #-8]
0065CE578  cmp      x11, x1
0065CE57C  b.eq     #0x65ce59c
0065CE580  subs     x9, x9, #1
0065CE584  add      x10, x10, #0x10
0065CE588  b.ne     #0x65ce574
0065CE58C  mov      w2, #0xa
0065CE590  mov      x0, x20
0065CE594  bl       #0x3a7e710 ; 
0065CE598  b        #0x65ce5ac ; 
0065CE59C  ldr      w9, [x10]
0065CE5A0  add      w9, w9, #0xa
0065CE5A4  add      x8, x8, w9, sxtw #4
0065CE5A8  add      x0, x8, #0x138
0065CE5AC  ldp      x8, x1, [x0]
0065CE5B0  mov      x0, x20
0065CE5B4  blr      x8
0065CE5B8  cbz      x0, #0x65ce620
0065CE5BC  ldr      w8, [x0, #0x18]
0065CE5C0  cmp      w8, #1
0065CE5C4  b.ls     #0x65ce624
0065CE5C8  lsr      x8, x22, #0x10
0065CE5CC  cmp      w8, #1
0065CE5D0  b.lt     #0x65ce610
0065CE5D4  ldr      x21, [x0, #0x28]
0065CE5D8  mov      x20, xzr
0065CE5DC  and      x22, x8, #0xffffffff
0065CE5E0  mov      x0, x19
0065CE5E4  mov      x1, x20
0065CE5E8  bl       #0x65ce8e8 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileMonster
0065CE5EC  mov      x0, x19
0065CE5F0  mov      x1, x20
0065CE5F4  bl       #0x65cf35c ; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileGroupMonster
0065CE5F8  mov      x0, x19
0065CE5FC  mov      x1, x20
0065CE600  bl       #0x65cff58 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateRandomMonster
0065CE604  subs     x22, x22, #1
0065CE608  add      x20, x20, x21
0065CE60C  b.ne     #0x65ce5e0
0065CE610  ldp      x20, x19, [sp, #0x20]
0065CE614  ldp      x22, x21, [sp, #0x10]
0065CE618  ldr      x30, [sp], #0x30
0065CE61C  ret      
0065CE620  bl       #0x382bfb8 ; 
0065CE624  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileMonster
; RVA 0x65CE8E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CE8E8  sub      sp, sp, #0xe0
0065CE8EC  stp      x29, x30, [sp, #0x80]
0065CE8F0  stp      x28, x27, [sp, #0x90]
0065CE8F4  stp      x26, x25, [sp, #0xa0]
0065CE8F8  stp      x24, x23, [sp, #0xb0]
0065CE8FC  stp      x22, x21, [sp, #0xc0]
0065CE900  stp      x20, x19, [sp, #0xd0]
0065CE904  str      x1, [sp, #0x40]
0065CE908  mrs      x24, tpidr_el0
0065CE90C  ldr      x8, [x24, #0x28]
0065CE910  adrp     x20, #0x9599000
0065CE914  adrp     x21, #0x8f0a000
0065CE918  mov      x19, x0
0065CE91C  str      x8, [sp, #0x78]
0065CE920  ldrb     w8, [x20, #0x585]
0065CE924  ldr      x21, [x21, #0x908]
0065CE928  tbnz     w8, #0, #0x65ce9ac
0065CE92C  adrp     x0, #0x8ee8000
0065CE930  ldr      x0, [x0, #0x898]
0065CE934  bl       #0x382bd14 ; 
0065CE938  adrp     x0, #0x8f0a000
0065CE93C  ldr      x0, [x0, #0x910]
0065CE940  bl       #0x382bd14 ; 
0065CE944  adrp     x0, #0x8f09000
0065CE948  ldr      x0, [x0, #0xc08]
0065CE94C  bl       #0x382bd14 ; 
0065CE950  adrp     x0, #0x8ee1000
0065CE954  ldr      x0, [x0, #0x6e8]
0065CE958  bl       #0x382bd14 ; 
0065CE95C  adrp     x0, #0x8f05000
0065CE960  ldr      x0, [x0, #0xa78]
0065CE964  bl       #0x382bd14 ; 
0065CE968  adrp     x0, #0x8f0a000
0065CE96C  ldr      x0, [x0, #0x908]
0065CE970  bl       #0x382bd14 ; 
0065CE974  adrp     x0, #0x8f0a000
0065CE978  ldr      x0, [x0, #0x918]
0065CE97C  bl       #0x382bd14 ; 
0065CE980  adrp     x0, #0x8f0a000
0065CE984  ldr      x0, [x0, #0x8b8]
0065CE988  bl       #0x382bd14 ; 
0065CE98C  adrp     x0, #0x8f0a000
0065CE990  ldr      x0, [x0, #0x8c8]
0065CE994  bl       #0x382bd14 ; 
0065CE998  adrp     x0, #0x8f0a000
0065CE99C  ldr      x0, [x0, #0x920]
0065CE9A0  bl       #0x382bd14 ; 
0065CE9A4  mov      w8, #1
0065CE9A8  strb     w8, [x20, #0x585]
0065CE9AC  ldr      x2, [x21]
0065CE9B0  ldrb     w8, [x2, #0x53]
0065CE9B4  tbnz     w8, #5, #0x65ce9fc
0065CE9B8  adrp     x8, #0x9599000
0065CE9BC  ldrb     w8, [x8, #0x286]
0065CE9C0  cbnz     w8, #0x65ce9dc
0065CE9C4  adrp     x0, #0x8f07000
0065CE9C8  ldr      x0, [x0, #0xc98]
0065CE9CC  bl       #0x382bd14 ; 
0065CE9D0  mov      w8, #1
0065CE9D4  adrp     x9, #0x9599000
0065CE9D8  strb     w8, [x9, #0x286]
0065CE9DC  adrp     x8, #0x8f07000
0065CE9E0  ldr      x8, [x8, #0xc98]
0065CE9E4  mov      x27, x19
0065CE9E8  ldr      x1, [x8]
0065CE9EC  ldrb     w8, [x1, #0x53]
0065CE9F0  tbnz     w8, #5, #0x65cea10
0065CE9F4  ldr      x22, [x19, #0x80]
0065CE9F8  b        #0x65cea20 ; 
0065CE9FC  ldr      x8, [x2, #0x60]
0065CEA00  ldr      x1, [sp, #0x40]
0065CEA04  mov      x0, x19
0065CEA08  blr      x8
0065CEA0C  b        #0x65cf320 ; 
0065CEA10  ldr      x8, [x1, #0x60]
0065CEA14  mov      x0, x19
0065CEA18  blr      x8
0065CEA1C  mov      x22, x0
0065CEA20  cbz      x22, #0x65cf350
0065CEA24  adrp     x20, #0x9591000
0065CEA28  ldrb     w8, [x20, #0xa9c]
0065CEA2C  cbnz     w8, #0x65cea44
0065CEA30  adrp     x0, #0x8ee6000
0065CEA34  ldr      x0, [x0, #0xaf0]
0065CEA38  bl       #0x382bd14 ; 
0065CEA3C  mov      w8, #1
0065CEA40  strb     w8, [x20, #0xa9c]
0065CEA44  adrp     x8, #0x8ee6000
0065CEA48  ldr      x8, [x8, #0xaf0]
0065CEA4C  ldr      x1, [x8]
0065CEA50  ldrb     w8, [x1, #0x53]
0065CEA54  tbnz     w8, #5, #0x65cea60
0065CEA58  ldr      x21, [x22, #0x240]
0065CEA5C  b        #0x65cea70 ; 
0065CEA60  ldr      x8, [x1, #0x60]
0065CEA64  mov      x0, x22
0065CEA68  blr      x8
0065CEA6C  mov      x21, x0
0065CEA70  cbz      x21, #0x65cf350
0065CEA74  adrp     x20, #0x9599000
0065CEA78  ldrb     w8, [x20, #0x26f]
0065CEA7C  mov      x19, x27
0065CEA80  cbnz     w8, #0x65cea98
0065CEA84  adrp     x0, #0x8f06000
0065CEA88  ldr      x0, [x0, #0xd58]
0065CEA8C  bl       #0x382bd14 ; 
0065CEA90  mov      w8, #1
0065CEA94  strb     w8, [x20, #0x26f]
0065CEA98  adrp     x23, #0x8f06000
0065CEA9C  ldr      x23, [x23, #0xd58]
0065CEAA0  ldr      x1, [x23]
0065CEAA4  ldrb     w8, [x1, #0x53]
0065CEAA8  tbnz     w8, #5, #0x65ceab4
0065CEAAC  ldr      x0, [x21, #0x20]
0065CEAB0  b        #0x65ceac0 ; 
0065CEAB4  ldr      x8, [x1, #0x60]
0065CEAB8  mov      x0, x21
0065CEABC  blr      x8
0065CEAC0  cbz      x0, #0x65cf350
0065CEAC4  ldr      x26, [x0, #0x158]
0065CEAC8  cbz      x26, #0x65cf320
0065CEACC  str      x24, [sp]
0065CEAD0  ldr      x24, [x19, #0x188]
0065CEAD4  cbz      x24, #0x65cf350
0065CEAD8  adrp     x10, #0x8f09000
0065CEADC  ldr      x8, [x24]
0065CEAE0  ldr      x22, [x19, #0x1f0]
0065CEAE4  ldr      x10, [x10, #0xc08]
0065CEAE8  ldrh     w9, [x8, #0x12e]
0065CEAEC  ldr      x1, [x10]
0065CEAF0  cbz      x9, #0x65ceb14
0065CEAF4  ldr      x10, [x8, #0xb0]
0065CEAF8  add      x10, x10, #8
0065CEAFC  ldur     x11, [x10, #-8]
0065CEB00  cmp      x11, x1
0065CEB04  b.eq     #0x65ceb24
0065CEB08  subs     x9, x9, #1
0065CEB0C  add      x10, x10, #0x10
0065CEB10  b.ne     #0x65ceafc
0065CEB14  mov      x0, x24
0065CEB18  mov      w2, wzr
0065CEB1C  bl       #0x3a7e710 ; 
0065CEB20  b        #0x65ceb30 ; 
0065CEB24  ldrsw    x9, [x10]
0065CEB28  add      x8, x8, x9, lsl #4
0065CEB2C  add      x0, x8, #0x138
0065CEB30  ldp      x8, x1, [x0]
0065CEB34  mov      x0, x24
0065CEB38  blr      x8
0065CEB3C  cbz      x22, #0x65cf350
0065CEB40  adrp     x8, #0x8f0a000
0065CEB44  ldr      x8, [x8, #0x910]
0065CEB48  mov      w1, w0
0065CEB4C  mov      x0, x22
0065CEB50  ldr      x2, [x8]
0065CEB54  bl       #0x5e5f99c ; System.Collections.Generic.Dictionary<int, object>$$get_Item
0065CEB58  ldr      x24, [x27, #0x188]
0065CEB5C  cbz      x24, #0x65cf350
0065CEB60  ldr      x8, [x24]
0065CEB64  adrp     x10, #0x8f09000
0065CEB68  mov      x22, x27
0065CEB6C  ldrh     w9, [x8, #0x12e]
0065CEB70  ldr      x10, [x10, #0xc08]
0065CEB74  str      x0, [sp, #0x18]
0065CEB78  ldr      x1, [x10]
0065CEB7C  cbz      x9, #0x65ceba0
0065CEB80  ldr      x10, [x8, #0xb0]
0065CEB84  add      x10, x10, #8
0065CEB88  ldur     x11, [x10, #-8]
0065CEB8C  cmp      x11, x1
0065CEB90  b.eq     #0x65cebb0
0065CEB94  subs     x9, x9, #1
0065CEB98  add      x10, x10, #0x10
0065CEB9C  b.ne     #0x65ceb88
0065CEBA0  mov      w2, #0xe
0065CEBA4  mov      x0, x24
0065CEBA8  bl       #0x3a7e710 ; 
0065CEBAC  b        #0x65cebc0 ; 
0065CEBB0  ldr      w9, [x10]
0065CEBB4  add      w9, w9, #0xe
0065CEBB8  add      x8, x8, w9, sxtw #4
0065CEBBC  add      x0, x8, #0x138
0065CEBC0  ldp      x8, x1, [x0]
0065CEBC4  mov      x0, x24
0065CEBC8  blr      x8
0065CEBCC  cmp      w0, #1
0065CEBD0  b.lt     #0x65ceda4
0065CEBD4  adrp     x8, #0x9599000
0065CEBD8  ldrb     w8, [x8, #0x286]
0065CEBDC  mov      w24, w0
0065CEBE0  cbnz     w8, #0x65cebfc
0065CEBE4  adrp     x0, #0x8f07000
0065CEBE8  ldr      x0, [x0, #0xc98]
0065CEBEC  bl       #0x382bd14 ; 
0065CEBF0  mov      w8, #1
0065CEBF4  adrp     x9, #0x9599000
0065CEBF8  strb     w8, [x9, #0x286]
0065CEBFC  adrp     x8, #0x8f07000
0065CEC00  ldr      x8, [x8, #0xc98]
0065CEC04  ldr      x1, [x8]
0065CEC08  ldrb     w8, [x1, #0x53]
0065CEC0C  tbnz     w8, #5, #0x65cec18
0065CEC10  ldr      x25, [x22, #0x80]
0065CEC14  b        #0x65cec28 ; 
0065CEC18  ldr      x8, [x1, #0x60]
0065CEC1C  mov      x0, x22
0065CEC20  blr      x8
0065CEC24  mov      x25, x0
0065CEC28  cbz      x25, #0x65cf350
0065CEC2C  adrp     x22, #0x9598000
0065CEC30  ldrb     w8, [x22, #0xfcc]
0065CEC34  cbnz     w8, #0x65cec4c
0065CEC38  adrp     x0, #0x8f06000
0065CEC3C  ldr      x0, [x0, #0x470]
0065CEC40  bl       #0x382bd14 ; 
0065CEC44  mov      w8, #1
0065CEC48  strb     w8, [x22, #0xfcc]
0065CEC4C  adrp     x8, #0x8f06000
0065CEC50  ldr      x8, [x8, #0x470]
0065CEC54  ldr      x1, [x8]
0065CEC58  ldrb     w8, [x1, #0x53]
0065CEC5C  tbnz     w8, #5, #0x65cec68
0065CEC60  ldr      x0, [x25, #0x200]
0065CEC64  b        #0x65cec74 ; 
0065CEC68  ldr      x8, [x1, #0x60]
0065CEC6C  mov      x0, x25
0065CEC70  blr      x8
0065CEC74  cbz      x0, #0x65cf350
0065CEC78  mov      w1, w24
0065CEC7C  mov      x2, xzr
0065CEC80  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065CEC84  cbz      x0, #0x65cecc8
0065CEC88  adrp     x22, #0x9599000
0065CEC8C  ldrb     w8, [x22, #0x657]
0065CEC90  mov      x24, x0
0065CEC94  cbnz     w8, #0x65cecac
0065CEC98  adrp     x0, #0x8f0a000
0065CEC9C  ldr      x0, [x0, #0x8d0]
0065CECA0  bl       #0x382bd14 ; 
0065CECA4  mov      w8, #1
0065CECA8  strb     w8, [x22, #0x657]
0065CECAC  adrp     x8, #0x8f0a000
0065CECB0  ldr      x8, [x8, #0x8d0]
0065CECB4  ldr      x1, [x8]
0065CECB8  ldrb     w8, [x1, #0x53]
0065CECBC  tbnz     w8, #5, #0x65ced1c
0065CECC0  ldr      x0, [x24, #0x28]
0065CECC4  b        #0x65ced28 ; 
0065CECC8  adrp     x8, #0x8ee1000
0065CECCC  ldr      x8, [x8, #0x6e8]
0065CECD0  ldr      x0, [x8]
0065CECD4  ldr      w8, [x0, #0xe0]
0065CECD8  cbnz     w8, #0x65cece0
0065CECDC  bl       #0x382be8c ; 
0065CECE0  adrp     x8, #0x8f0a000
0065CECE4  adrp     x9, #0x8f0a000
0065CECE8  adrp     x10, #0x8f0a000
0065CECEC  ldr      x8, [x8, #0x8c8]
0065CECF0  ldr      x9, [x9, #0x920]
0065CECF4  ldr      x10, [x10, #0x8b8]
0065CECF8  mov      w3, #0x2e2
0065CECFC  ldr      x0, [x8]
0065CED00  ldr      x1, [x9]
0065CED04  ldr      x2, [x10]
0065CED08  mov      x4, xzr
0065CED0C  bl       #0x7997754 ; Logger$$LogError
0065CED10  ldr      x8, [sp]
0065CED14  ldr      x8, [x8, #0x28]
0065CED18  b        #0x65cf324 ; 
0065CED1C  ldr      x8, [x1, #0x60]
0065CED20  mov      x0, x24
0065CED24  blr      x8
0065CED28  mov      x22, x27
0065CED2C  cbz      x0, #0x65cf350
0065CED30  ldr      x8, [x0, #0x18]
0065CED34  ldr      x9, [sp, #0x18]
0065CED38  cbz      x8, #0x65ceda4
0065CED3C  cbz      x9, #0x65cf350
0065CED40  ldrb     w8, [x20, #0x26f]
0065CED44  ldrsw    x22, [x9, #0x10]
0065CED48  cbnz     w8, #0x65ced60
0065CED4C  adrp     x0, #0x8f06000
0065CED50  ldr      x0, [x0, #0xd58]
0065CED54  bl       #0x382bd14 ; 
0065CED58  mov      w8, #1
0065CED5C  strb     w8, [x20, #0x26f]
0065CED60  ldr      x1, [x23]
0065CED64  ldrb     w8, [x1, #0x53]
0065CED68  tbnz     w8, #5, #0x65ced74
0065CED6C  ldr      x0, [x21, #0x20]
0065CED70  b        #0x65ced80 ; 
0065CED74  ldr      x8, [x1, #0x60]
0065CED78  mov      x0, x21
0065CED7C  blr      x8
0065CED80  cbz      x0, #0x65cf350
0065CED84  ldr      x8, [x0, #0x140]
0065CED88  cbz      x8, #0x65cf350
0065CED8C  ldr      w9, [x8, #0x18]
0065CED90  cmp      w22, w9
0065CED94  b.hs     #0x65cf354
0065CED98  add      x8, x8, x22, lsl #4
0065CED9C  ldr      x26, [x8, #0x28]
0065CEDA0  mov      x22, x27
0065CEDA4  cbz      x26, #0x65cf350
0065CEDA8  ldr      w9, [x26, #0x18]
0065CEDAC  ldr      w8, [x22, #0xa8]
0065CEDB0  add      w8, w8, w9
0065CEDB4  cmp      w8, #0x259
0065CEDB8  b.lt     #0x65cee10
0065CEDBC  adrp     x8, #0x8ee1000
0065CEDC0  ldr      x8, [x8, #0x6e8]
0065CEDC4  ldr      x0, [x8]
0065CEDC8  ldr      w8, [x0, #0xe0]
0065CEDCC  cbnz     w8, #0x65cedd4
0065CEDD0  bl       #0x382be8c ; 
0065CEDD4  adrp     x8, #0x8f0a000
0065CEDD8  adrp     x9, #0x8f0a000
0065CEDDC  adrp     x10, #0x8f0a000
0065CEDE0  ldr      x8, [x8, #0x918]
0065CEDE4  ldr      x9, [x9, #0x920]
0065CEDE8  ldr      x10, [x10, #0x8b8]
0065CEDEC  mov      w3, #0x2f1
0065CEDF0  ldr      x0, [x8]
0065CEDF4  ldr      x1, [x9]
0065CEDF8  ldr      x2, [x10]
0065CEDFC  mov      x4, xzr
0065CEE00  bl       #0x7997754 ; Logger$$LogError
0065CEE04  ldr      w8, [x22, #0xa8]
0065CEE08  mov      w9, #0x258
0065CEE0C  sub      w9, w9, w8
0065CEE10  cmp      w9, #1
0065CEE14  str      w9, [sp, #0xc]
0065CEE18  b.lt     #0x65cf30c
0065CEE1C  ldr      w9, [x26, #0x18]
0065CEE20  cbz      w9, #0x65cf354
0065CEE24  ldr      w23, [sp, #0xc]
0065CEE28  ldr      x19, [x26, #0x38]
0065CEE2C  subs     w8, w23, #2
0065CEE30  b.lt     #0x65cee70
0065CEE34  mov      w11, w23
0065CEE38  sub      w9, w9, #1
0065CEE3C  add      x10, x26, #0x70
0065CEE40  sub      x11, x11, #1
0065CEE44  mov      x24, x19
0065CEE48  cmp      w9, w8
0065CEE4C  b.ls     #0x65cf354
0065CEE50  ldr      x12, [x10], #0x38
0065CEE54  cmp      x12, x19
0065CEE58  csel     x19, x12, x19, lt
0065CEE5C  cmp      x12, x24
0065CEE60  csel     x24, x12, x24, gt
0065CEE64  subs     x11, x11, #1
0065CEE68  b.ne     #0x65cee48
0065CEE6C  b        #0x65cee74 ; 
0065CEE70  mov      x24, x19
0065CEE74  ldr      x8, [x21, #0x10]
0065CEE78  cbz      x8, #0x65cf350
0065CEE7C  adrp     x20, #0x8f05000
0065CEE80  ldr      x20, [x20, #0xa78]
0065CEE84  ldr      x8, [x8, #0x20]
0065CEE88  ldr      x0, [x20]
0065CEE8C  subs     x8, x19, x8
0065CEE90  cneg     x21, x8, mi
0065CEE94  ldr      w9, [x0, #0xe0]
0065CEE98  cbnz     w9, #0x65ceea4
0065CEE9C  bl       #0x382be8c ; 
0065CEEA0  ldr      x0, [x20]
0065CEEA4  cmp      w23, #1
0065CEEA8  b.lt     #0x65cf30c
0065CEEAC  ldr      w9, [sp, #0xc]
0065CEEB0  ldr      x8, [x0, #0xb8]
0065CEEB4  adrp     x27, #0x8ee8000
0065CEEB8  mov      x20, xzr
0065CEEBC  mov      w9, w9
0065CEEC0  str      x9, [sp, #0x20]
0065CEEC4  ldr      x27, [x27, #0x898]
0065CEEC8  ldr      x8, [x8, #0x10]
0065CEECC  stp      x26, x24, [sp, #0x28]
0065CEED0  str      x19, [sp, #0x38]
0065CEED4  add      x8, x8, x21
0065CEED8  str      x8, [sp, #0x10]
0065CEEDC  ldr      x23, [x22, #0xa0]
0065CEEE0  cbz      x23, #0x65cf350
0065CEEE4  ldr      w8, [x22, #0xa8]
0065CEEE8  ldr      w9, [x23, #0x18]
0065CEEEC  add      w21, w8, w20
0065CEEF0  cmp      w21, w9
0065CEEF4  b.hs     #0x65cf354
0065CEEF8  ldr      w8, [x26, #0x18]
0065CEEFC  cmp      x20, x8
0065CEF00  b.hs     #0x65cf354
0065CEF04  ldr      x29, [x22, #0x188]
0065CEF08  cbz      x29, #0x65cf350
0065CEF0C  mov      w8, #0x38
0065CEF10  madd     x9, x20, x8, x26
0065CEF14  ldr      w10, [x9, #0x20]
0065CEF18  ldr      x8, [x29]
0065CEF1C  mov      x19, x22
0065CEF20  ldp      x28, x24, [x9, #0x28]
0065CEF24  str      w10, [sp, #0x5c]
0065CEF28  adrp     x10, #0x8f09000
0065CEF2C  ldp      x25, x13, [x9, #0x38]
0065CEF30  ldp      x22, x12, [x9, #0x48]
0065CEF34  ldrh     w9, [x8, #0x12e]
0065CEF38  ldr      x10, [x10, #0xc08]
0065CEF3C  stp      x13, x12, [sp, #0x48]
0065CEF40  ldr      x1, [x10]
0065CEF44  cbz      x9, #0x65cef68
0065CEF48  ldr      x10, [x8, #0xb0]
0065CEF4C  add      x10, x10, #8
0065CEF50  ldur     x11, [x10, #-8]
0065CEF54  cmp      x11, x1
0065CEF58  b.eq     #0x65cef78
0065CEF5C  subs     x9, x9, #1
0065CEF60  add      x10, x10, #0x10
0065CEF64  b.ne     #0x65cef50
0065CEF68  mov      w2, #6
0065CEF6C  mov      x0, x29
0065CEF70  bl       #0x3a7e710 ; 
0065CEF74  b        #0x65cef88 ; 
0065CEF78  ldr      w9, [x10]
0065CEF7C  add      w9, w9, #6
0065CEF80  add      x8, x8, w9, sxtw #4
0065CEF84  add      x0, x8, #0x138
0065CEF88  ldp      x8, x1, [x0]
0065CEF8C  mov      x0, x29
0065CEF90  sxtw     x21, w21
0065CEF94  blr      x8
0065CEF98  ldr      x8, [sp, #0x40]
0065CEF9C  mov      x26, x21
0065CEFA0  add      x21, x23, x21, lsl #7
0065CEFA4  add      x8, x22, x8
0065CEFA8  add      x8, x8, x0
0065CEFAC  str      x8, [x21, #0x20]
0065CEFB0  ldr      x0, [x27]
0065CEFB4  ldr      w8, [x0, #0xe0]
0065CEFB8  cbnz     w8, #0x65cefc4
0065CEFBC  bl       #0x382be8c ; 
0065CEFC0  ldr      x0, [x27]
0065CEFC4  ldr      x8, [x0, #0xb8]
0065CEFC8  mov      x22, x19
0065CEFCC  ldr      x8, [x8, #0xb0]
0065CEFD0  str      x8, [x21, #0x28]
0065CEFD4  ldr      x29, [x19, #0x188]
0065CEFD8  cbz      x29, #0x65cf350
0065CEFDC  ldr      x8, [x29]
0065CEFE0  adrp     x10, #0x8f09000
0065CEFE4  mov      x19, x24
0065CEFE8  mov      x24, x28
0065CEFEC  ldrh     w9, [x8, #0x12e]
0065CEFF0  ldr      x10, [x10, #0xc08]
0065CEFF4  ldr      w28, [sp, #0x5c]
0065CEFF8  ldr      x1, [x10]
0065CEFFC  cbz      x9, #0x65cf020
0065CF000  ldr      x10, [x8, #0xb0]
0065CF004  add      x10, x10, #8
0065CF008  ldur     x11, [x10, #-8]
0065CF00C  cmp      x11, x1
0065CF010  b.eq     #0x65cf030
0065CF014  subs     x9, x9, #1
0065CF018  add      x10, x10, #0x10
0065CF01C  b.ne     #0x65cf008
0065CF020  mov      w2, #0x10
0065CF024  mov      x0, x29
0065CF028  bl       #0x3a7e710 ; 
0065CF02C  b        #0x65cf040 ; 
0065CF030  ldr      w9, [x10]
0065CF034  add      w9, w9, #0x10
0065CF038  add      x8, x8, w9, sxtw #4
0065CF03C  add      x0, x8, #0x138
0065CF040  ldp      x8, x1, [x0]
0065CF044  mov      x0, x29
0065CF048  blr      x8
0065CF04C  cbz      x0, #0x65cf350
0065CF050  ldr      x8, [x0, #0x18]
0065CF054  cbz      x8, #0x65cf0e8
0065CF058  ldr      x9, [sp, #0x18]
0065CF05C  cbz      x9, #0x65cf350
0065CF060  ldr      x28, [x22, #0x188]
0065CF064  cbz      x28, #0x65cf350
0065CF068  ldr      x8, [x28]
0065CF06C  adrp     x10, #0x8f09000
0065CF070  ldrsw    x21, [x9, #0x14]
0065CF074  ldrh     w9, [x8, #0x12e]
0065CF078  ldr      x10, [x10, #0xc08]
0065CF07C  ldr      x1, [x10]
0065CF080  cbz      x9, #0x65cf0a4
0065CF084  ldr      x10, [x8, #0xb0]
0065CF088  add      x10, x10, #8
0065CF08C  ldur     x11, [x10, #-8]
0065CF090  cmp      x11, x1
0065CF094  b.eq     #0x65cf0b4
0065CF098  subs     x9, x9, #1
0065CF09C  add      x10, x10, #0x10
0065CF0A0  b.ne     #0x65cf08c
0065CF0A4  mov      w2, #0x10
0065CF0A8  mov      x0, x28
0065CF0AC  bl       #0x3a7e710 ; 
0065CF0B0  b        #0x65cf0c4 ; 
0065CF0B4  ldr      w9, [x10]
0065CF0B8  add      w9, w9, #0x10
0065CF0BC  add      x8, x8, w9, sxtw #4
0065CF0C0  add      x0, x8, #0x138
0065CF0C4  ldp      x8, x1, [x0]
0065CF0C8  mov      x0, x28
0065CF0CC  blr      x8
0065CF0D0  cbz      x0, #0x65cf350
0065CF0D4  ldr      w8, [x0, #0x18]
0065CF0D8  cmp      w21, w8
0065CF0DC  b.hs     #0x65cf354
0065CF0E0  add      x8, x0, x21, lsl #2
0065CF0E4  ldr      w28, [x8, #0x20]
0065CF0E8  adrp     x8, #0x9599000
0065CF0EC  ldrb     w8, [x8, #0x286]
0065CF0F0  cbnz     w8, #0x65cf10c
0065CF0F4  adrp     x0, #0x8f07000
0065CF0F8  ldr      x0, [x0, #0xc98]
0065CF0FC  bl       #0x382bd14 ; 
0065CF100  adrp     x8, #0x9599000
0065CF104  mov      w9, #1
0065CF108  strb     w9, [x8, #0x286]
0065CF10C  adrp     x8, #0x8f07000
0065CF110  ldr      x8, [x8, #0xc98]
0065CF114  ldr      x1, [x8]
0065CF118  ldrb     w8, [x1, #0x53]
0065CF11C  tbnz     w8, #5, #0x65cf128
0065CF120  ldr      x29, [x22, #0x80]
0065CF124  b        #0x65cf138 ; 
0065CF128  ldr      x8, [x1, #0x60]
0065CF12C  mov      x0, x22
0065CF130  blr      x8
0065CF134  mov      x29, x0
0065CF138  cbz      x29, #0x65cf350
0065CF13C  adrp     x8, #0x9598000
0065CF140  ldrb     w8, [x8, #0xfcc]
0065CF144  cbnz     w8, #0x65cf160
0065CF148  adrp     x0, #0x8f06000
0065CF14C  ldr      x0, [x0, #0x470]
0065CF150  bl       #0x382bd14 ; 
0065CF154  mov      w8, #1
0065CF158  adrp     x9, #0x9598000
0065CF15C  strb     w8, [x9, #0xfcc]
0065CF160  adrp     x8, #0x8f06000
0065CF164  ldr      x8, [x8, #0x470]
0065CF168  ldr      x1, [x8]
0065CF16C  ldrb     w8, [x1, #0x53]
0065CF170  tbnz     w8, #5, #0x65cf17c
0065CF174  ldr      x0, [x29, #0x200]
0065CF178  b        #0x65cf188 ; 
0065CF17C  ldr      x8, [x1, #0x60]
0065CF180  mov      x0, x29
0065CF184  blr      x8
0065CF188  cbz      x0, #0x65cf350
0065CF18C  mov      w1, w28
0065CF190  mov      x2, xzr
0065CF194  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065CF198  mov      x29, x0
0065CF19C  cbz      x0, #0x65cf204
0065CF1A0  adrp     x8, #0x9599000
0065CF1A4  ldrb     w8, [x8, #0x29e]
0065CF1A8  cbnz     w8, #0x65cf1c4
0065CF1AC  adrp     x0, #0x8f08000
0065CF1B0  ldr      x0, [x0, #0x90]
0065CF1B4  bl       #0x382bd14 ; 
0065CF1B8  mov      w8, #1
0065CF1BC  adrp     x9, #0x9599000
0065CF1C0  strb     w8, [x9, #0x29e]
0065CF1C4  adrp     x8, #0x8f08000
0065CF1C8  ldr      x8, [x8, #0x90]
0065CF1CC  ldr      x1, [x8]
0065CF1D0  ldrb     w8, [x1, #0x53]
0065CF1D4  tbnz     w8, #5, #0x65cf1e0
0065CF1D8  ldr      w0, [x29, #0x120]
0065CF1DC  b        #0x65cf1ec ; 
0065CF1E0  ldr      x8, [x1, #0x60]
0065CF1E4  mov      x0, x29
0065CF1E8  blr      x8
0065CF1EC  cmp      w0, #1
0065CF1F0  b.ne     #0x65cf204
0065CF1F4  add      x8, x23, x26, lsl #7
0065CF1F8  stp      x24, x19, [x8, #0x30]
0065CF1FC  str      x25, [x8, #0x40]
0065CF200  b        #0x65cf23c ; 
0065CF204  ldr      x8, [sp, #0x10]
0065CF208  add      x0, sp, #0x60
0065CF20C  mov      x1, x24
0065CF210  mov      x2, x19
0065CF214  add      x3, x25, x8
0065CF218  mov      x4, xzr
0065CF21C  stp      xzr, xzr, [sp, #0x60]
0065CF220  str      xzr, [sp, #0x70]
0065CF224  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065CF228  ldr      x8, [sp, #0x70]
0065CF22C  ldr      q0, [sp, #0x60]
0065CF230  add      x9, x23, x26, lsl #7
0065CF234  str      x8, [x9, #0x40]
0065CF238  str      q0, [x9, #0x30]
0065CF23C  ldp      x8, x1, [sp, #0x48]
0065CF240  add      x21, x23, x26, lsl #7
0065CF244  str      x1, [x21, #0x70]!
0065CF248  mov      x0, x21
0065CF24C  str      wzr, [x21, #0x10]
0065CF250  stp      x24, x19, [x21, #-0x28]
0065CF254  stur     x25, [x21, #-0x18]
0065CF258  stur     w28, [x21, #-0x10]
0065CF25C  stur     x8, [x21, #-8]
0065CF260  bl       #0x382bcb8 ; 
0065CF264  ldp      x24, x19, [sp, #0x30]
0065CF268  str      xzr, [x21, #8]
0065CF26C  sub      x8, x25, x24
0065CF270  sub      x9, x25, x19
0065CF274  stp      x8, x9, [x21, #0x18]
0065CF278  ldr      x25, [x22, #0x188]
0065CF27C  cbz      x25, #0x65cf350
0065CF280  ldr      x8, [x25]
0065CF284  adrp     x10, #0x8f09000
0065CF288  ldrh     w9, [x8, #0x12e]
0065CF28C  ldr      x10, [x10, #0xc08]
0065CF290  ldr      x1, [x10]
0065CF294  cbz      x9, #0x65cf2b8
0065CF298  ldr      x10, [x8, #0xb0]
0065CF29C  add      x10, x10, #8
0065CF2A0  ldur     x11, [x10, #-8]
0065CF2A4  cmp      x11, x1
0065CF2A8  b.eq     #0x65cf2c8
0065CF2AC  subs     x9, x9, #1
0065CF2B0  add      x10, x10, #0x10
0065CF2B4  b.ne     #0x65cf2a0
0065CF2B8  mov      x0, x25
0065CF2BC  mov      w2, wzr
0065CF2C0  bl       #0x3a7e710 ; 
0065CF2C4  b        #0x65cf2d4 ; 
0065CF2C8  ldrsw    x9, [x10]
0065CF2CC  add      x8, x8, x9, lsl #4
0065CF2D0  add      x0, x8, #0x138
0065CF2D4  ldp      x8, x1, [x0]
0065CF2D8  mov      x0, x25
0065CF2DC  blr      x8
0065CF2E0  add      x21, x23, x26, lsl #7
0065CF2E4  str      w0, [x21, #0x98]
0065CF2E8  mov      x0, x22
0065CF2EC  mov      x1, x29
0065CF2F0  bl       #0x65d0b58 ; HotFix.BattleLogic.WaterfallBattleManager$$AddGoldMonster
0065CF2F4  ldp      x9, x26, [sp, #0x20]
0065CF2F8  add      x20, x20, #1
0065CF2FC  and      w8, w0, #1
0065CF300  strb     w8, [x21, #0x9c]
0065CF304  cmp      x20, x9
0065CF308  b.ne     #0x65ceedc
0065CF30C  ldr      w8, [x22, #0xa8]
0065CF310  ldr      w9, [sp, #0xc]
0065CF314  ldr      x24, [sp]
0065CF318  add      w8, w8, w9
0065CF31C  str      w8, [x22, #0xa8]
0065CF320  ldr      x8, [x24, #0x28]
0065CF324  ldr      x9, [sp, #0x78]
0065CF328  cmp      x8, x9
0065CF32C  b.ne     #0x65cf358
0065CF330  ldp      x20, x19, [sp, #0xd0]
0065CF334  ldp      x22, x21, [sp, #0xc0]
0065CF338  ldp      x24, x23, [sp, #0xb0]
0065CF33C  ldp      x26, x25, [sp, #0xa0]
0065CF340  ldp      x28, x27, [sp, #0x90]
0065CF344  ldp      x29, x30, [sp, #0x80]
0065CF348  add      sp, sp, #0xe0
0065CF34C  ret      
0065CF350  bl       #0x382bfb8 ; 
0065CF354  bl       #0x382bfc0 ; 
0065CF358  bl       #0x89edb60 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileNpc
; RVA 0x65CDB00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CDB00  sub      sp, sp, #0xa0
0065CDB04  str      x30, [sp, #0x40]
0065CDB08  stp      x28, x27, [sp, #0x50]
0065CDB0C  stp      x26, x25, [sp, #0x60]
0065CDB10  stp      x24, x23, [sp, #0x70]
0065CDB14  stp      x22, x21, [sp, #0x80]
0065CDB18  stp      x20, x19, [sp, #0x90]
0065CDB1C  mrs      x23, tpidr_el0
0065CDB20  ldr      x8, [x23, #0x28]
0065CDB24  adrp     x20, #0x9599000
0065CDB28  adrp     x21, #0x8f0a000
0065CDB2C  mov      x19, x0
0065CDB30  str      x8, [sp, #0x38]
0065CDB34  ldrb     w8, [x20, #0x586]
0065CDB38  ldr      x21, [x21, #0x8b0]
0065CDB3C  tbnz     w8, #0, #0x65cdb9c
0065CDB40  adrp     x0, #0x8f09000
0065CDB44  ldr      x0, [x0, #0xc08]
0065CDB48  bl       #0x382bd14 ; 
0065CDB4C  adrp     x0, #0x8ee1000
0065CDB50  ldr      x0, [x0, #0x6e8]
0065CDB54  bl       #0x382bd14 ; 
0065CDB58  adrp     x0, #0x8f05000
0065CDB5C  ldr      x0, [x0, #0xa78]
0065CDB60  bl       #0x382bd14 ; 
0065CDB64  adrp     x0, #0x8f0a000
0065CDB68  ldr      x0, [x0, #0x8b0]
0065CDB6C  bl       #0x382bd14 ; 
0065CDB70  adrp     x0, #0x8f0a000
0065CDB74  ldr      x0, [x0, #0x8b8]
0065CDB78  bl       #0x382bd14 ; 
0065CDB7C  adrp     x0, #0x8f0a000
0065CDB80  ldr      x0, [x0, #0x8c0]
0065CDB84  bl       #0x382bd14 ; 
0065CDB88  adrp     x0, #0x8f0a000
0065CDB8C  ldr      x0, [x0, #0x8c8]
0065CDB90  bl       #0x382bd14 ; 
0065CDB94  mov      w8, #1
0065CDB98  strb     w8, [x20, #0x586]
0065CDB9C  ldr      x1, [x21]
0065CDBA0  ldrb     w8, [x1, #0x53]
0065CDBA4  tbnz     w8, #5, #0x65cdbec
0065CDBA8  adrp     x22, #0x9599000
0065CDBAC  ldrb     w8, [x22, #0x286]
0065CDBB0  stp      xzr, xzr, [sp, #0x20]
0065CDBB4  str      xzr, [sp, #0x30]
0065CDBB8  cbnz     w8, #0x65cdbd0
0065CDBBC  adrp     x0, #0x8f07000
0065CDBC0  ldr      x0, [x0, #0xc98]
0065CDBC4  bl       #0x382bd14 ; 
0065CDBC8  mov      w8, #1
0065CDBCC  strb     w8, [x22, #0x286]
0065CDBD0  adrp     x28, #0x8f07000
0065CDBD4  ldr      x28, [x28, #0xc98]
0065CDBD8  ldr      x1, [x28]
0065CDBDC  ldrb     w8, [x1, #0x53]
0065CDBE0  tbnz     w8, #5, #0x65cdbfc
0065CDBE4  ldr      x20, [x19, #0x80]
0065CDBE8  b        #0x65cdc0c ; 
0065CDBEC  ldr      x8, [x1, #0x60]
0065CDBF0  mov      x0, x19
0065CDBF4  blr      x8
0065CDBF8  b        #0x65ce074 ; 
0065CDBFC  ldr      x8, [x1, #0x60]
0065CDC00  mov      x0, x19
0065CDC04  blr      x8
0065CDC08  mov      x20, x0
0065CDC0C  cbz      x20, #0x65ce0a8
0065CDC10  adrp     x21, #0x9591000
0065CDC14  ldrb     w8, [x21, #0xa9c]
0065CDC18  cbnz     w8, #0x65cdc30
0065CDC1C  adrp     x0, #0x8ee6000
0065CDC20  ldr      x0, [x0, #0xaf0]
0065CDC24  bl       #0x382bd14 ; 
0065CDC28  mov      w8, #1
0065CDC2C  strb     w8, [x21, #0xa9c]
0065CDC30  adrp     x8, #0x8ee6000
0065CDC34  ldr      x8, [x8, #0xaf0]
0065CDC38  ldr      x1, [x8]
0065CDC3C  ldrb     w8, [x1, #0x53]
0065CDC40  tbnz     w8, #5, #0x65cdc4c
0065CDC44  ldr      x20, [x20, #0x240]
0065CDC48  b        #0x65cdc5c ; 
0065CDC4C  ldr      x8, [x1, #0x60]
0065CDC50  mov      x0, x20
0065CDC54  blr      x8
0065CDC58  mov      x20, x0
0065CDC5C  cbz      x20, #0x65ce0a8
0065CDC60  adrp     x26, #0x9599000
0065CDC64  ldrb     w8, [x26, #0x26f]
0065CDC68  cbnz     w8, #0x65cdc80
0065CDC6C  adrp     x0, #0x8f06000
0065CDC70  ldr      x0, [x0, #0xd58]
0065CDC74  bl       #0x382bd14 ; 
0065CDC78  mov      w8, #1
0065CDC7C  strb     w8, [x26, #0x26f]
0065CDC80  adrp     x27, #0x8f06000
0065CDC84  ldr      x27, [x27, #0xd58]
0065CDC88  ldr      x1, [x27]
0065CDC8C  ldrb     w8, [x1, #0x53]
0065CDC90  tbnz     w8, #5, #0x65cdc9c
0065CDC94  ldr      x0, [x20, #0x20]
0065CDC98  b        #0x65cdca8 ; 
0065CDC9C  ldr      x8, [x1, #0x60]
0065CDCA0  mov      x0, x20
0065CDCA4  blr      x8
0065CDCA8  cbz      x0, #0x65ce0a8
0065CDCAC  ldr      x24, [x0, #0x158]
0065CDCB0  cbz      x24, #0x65ce074
0065CDCB4  ldr      x21, [x19, #0x188]
0065CDCB8  cbz      x21, #0x65ce0a8
0065CDCBC  adrp     x25, #0x8f09000
0065CDCC0  ldr      x8, [x21]
0065CDCC4  ldr      x25, [x25, #0xc08]
0065CDCC8  ldrh     w9, [x8, #0x12e]
0065CDCCC  ldr      x1, [x25]
0065CDCD0  cbz      x9, #0x65cdcf4
0065CDCD4  ldr      x10, [x8, #0xb0]
0065CDCD8  add      x10, x10, #8
0065CDCDC  ldur     x11, [x10, #-8]
0065CDCE0  cmp      x11, x1
0065CDCE4  b.eq     #0x65cdd04
0065CDCE8  subs     x9, x9, #1
0065CDCEC  add      x10, x10, #0x10
0065CDCF0  b.ne     #0x65cdcdc
0065CDCF4  mov      w2, #0xe
0065CDCF8  mov      x0, x21
0065CDCFC  bl       #0x3a7e710 ; 
0065CDD00  b        #0x65cdd14 ; 
0065CDD04  ldr      w9, [x10]
0065CDD08  add      w9, w9, #0xe
0065CDD0C  add      x8, x8, w9, sxtw #4
0065CDD10  add      x0, x8, #0x138
0065CDD14  ldp      x8, x1, [x0]
0065CDD18  mov      x0, x21
0065CDD1C  blr      x8
0065CDD20  cmp      w0, #1
0065CDD24  b.lt     #0x65cdf20
0065CDD28  ldrb     w8, [x22, #0x286]
0065CDD2C  mov      w21, w0
0065CDD30  cbnz     w8, #0x65cdd48
0065CDD34  adrp     x0, #0x8f07000
0065CDD38  ldr      x0, [x0, #0xc98]
0065CDD3C  bl       #0x382bd14 ; 
0065CDD40  mov      w8, #1
0065CDD44  strb     w8, [x22, #0x286]
0065CDD48  ldr      x1, [x28]
0065CDD4C  ldrb     w8, [x1, #0x53]
0065CDD50  tbnz     w8, #5, #0x65cdd5c
0065CDD54  ldr      x22, [x19, #0x80]
0065CDD58  b        #0x65cdd6c ; 
0065CDD5C  ldr      x8, [x1, #0x60]
0065CDD60  mov      x0, x19
0065CDD64  blr      x8
0065CDD68  mov      x22, x0
0065CDD6C  cbz      x22, #0x65ce0a8
0065CDD70  adrp     x28, #0x9598000
0065CDD74  ldrb     w8, [x28, #0xfcc]
0065CDD78  cbnz     w8, #0x65cdd90
0065CDD7C  adrp     x0, #0x8f06000
0065CDD80  ldr      x0, [x0, #0x470]
0065CDD84  bl       #0x382bd14 ; 
0065CDD88  mov      w8, #1
0065CDD8C  strb     w8, [x28, #0xfcc]
0065CDD90  adrp     x8, #0x8f06000
0065CDD94  ldr      x8, [x8, #0x470]
0065CDD98  ldr      x1, [x8]
0065CDD9C  ldrb     w8, [x1, #0x53]
0065CDDA0  tbnz     w8, #5, #0x65cddac
0065CDDA4  ldr      x0, [x22, #0x200]
0065CDDA8  b        #0x65cddb8 ; 
0065CDDAC  ldr      x8, [x1, #0x60]
0065CDDB0  mov      x0, x22
0065CDDB4  blr      x8
0065CDDB8  cbz      x0, #0x65ce0a8
0065CDDBC  mov      w1, w21
0065CDDC0  mov      x2, xzr
0065CDDC4  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065CDDC8  cbz      x0, #0x65cde0c
0065CDDCC  adrp     x22, #0x9599000
0065CDDD0  ldrb     w8, [x22, #0x657]
0065CDDD4  mov      x21, x0
0065CDDD8  cbnz     w8, #0x65cddf0
0065CDDDC  adrp     x0, #0x8f0a000
0065CDDE0  ldr      x0, [x0, #0x8d0]
0065CDDE4  bl       #0x382bd14 ; 
0065CDDE8  mov      w8, #1
0065CDDEC  strb     w8, [x22, #0x657]
0065CDDF0  adrp     x28, #0x8f0a000
0065CDDF4  ldr      x28, [x28, #0x8d0]
0065CDDF8  ldr      x1, [x28]
0065CDDFC  ldrb     w8, [x1, #0x53]
0065CDE00  tbnz     w8, #5, #0x65cde58
0065CDE04  ldr      x0, [x21, #0x28]
0065CDE08  b        #0x65cde64 ; 
0065CDE0C  adrp     x8, #0x8ee1000
0065CDE10  ldr      x8, [x8, #0x6e8]
0065CDE14  ldr      x0, [x8]
0065CDE18  ldr      w8, [x0, #0xe0]
0065CDE1C  cbnz     w8, #0x65cde24
0065CDE20  bl       #0x382be8c ; 
0065CDE24  adrp     x8, #0x8f0a000
0065CDE28  adrp     x9, #0x8f0a000
0065CDE2C  adrp     x10, #0x8f0a000
0065CDE30  ldr      x8, [x8, #0x8c8]
0065CDE34  ldr      x9, [x9, #0x8c0]
0065CDE38  ldr      x10, [x10, #0x8b8]
0065CDE3C  mov      w3, #0x34a
0065CDE40  ldr      x0, [x8]
0065CDE44  ldr      x1, [x9]
0065CDE48  ldr      x2, [x10]
0065CDE4C  mov      x4, xzr
0065CDE50  bl       #0x7997754 ; Logger$$LogError
0065CDE54  b        #0x65ce074 ; 
0065CDE58  ldr      x8, [x1, #0x60]
0065CDE5C  mov      x0, x21
0065CDE60  blr      x8
0065CDE64  cbz      x0, #0x65ce0a8
0065CDE68  ldr      w8, [x0, #0x18]
0065CDE6C  cmp      w8, #2
0065CDE70  b.lt     #0x65cdf20
0065CDE74  ldrb     w8, [x22, #0x657]
0065CDE78  cbnz     w8, #0x65cde90
0065CDE7C  adrp     x0, #0x8f0a000
0065CDE80  ldr      x0, [x0, #0x8d0]
0065CDE84  bl       #0x382bd14 ; 
0065CDE88  mov      w8, #1
0065CDE8C  strb     w8, [x22, #0x657]
0065CDE90  ldr      x1, [x28]
0065CDE94  ldrb     w8, [x1, #0x53]
0065CDE98  tbnz     w8, #5, #0x65cdea4
0065CDE9C  ldr      x1, [x21, #0x28]
0065CDEA0  b        #0x65cdeb4 ; 
0065CDEA4  ldr      x8, [x1, #0x60]
0065CDEA8  mov      x0, x21
0065CDEAC  blr      x8
0065CDEB0  mov      x1, x0
0065CDEB4  mov      x0, x20
0065CDEB8  mov      x2, xzr
0065CDEBC  bl       #0x6903320 ; HotFix.BattleLogic.MapManager$$WaterfallRandomMap
0065CDEC0  ldrb     w8, [x26, #0x26f]
0065CDEC4  mov      w21, w0
0065CDEC8  cbnz     w8, #0x65cdee0
0065CDECC  adrp     x0, #0x8f06000
0065CDED0  ldr      x0, [x0, #0xd58]
0065CDED4  bl       #0x382bd14 ; 
0065CDED8  mov      w8, #1
0065CDEDC  strb     w8, [x26, #0x26f]
0065CDEE0  ldr      x1, [x27]
0065CDEE4  ldrb     w8, [x1, #0x53]
0065CDEE8  tbnz     w8, #5, #0x65cdef4
0065CDEEC  ldr      x0, [x20, #0x20]
0065CDEF0  b        #0x65cdf00 ; 
0065CDEF4  ldr      x8, [x1, #0x60]
0065CDEF8  mov      x0, x20
0065CDEFC  blr      x8
0065CDF00  cbz      x0, #0x65ce0a8
0065CDF04  ldr      x8, [x0, #0x140]
0065CDF08  cbz      x8, #0x65ce0a8
0065CDF0C  ldr      w9, [x8, #0x18]
0065CDF10  cmp      w21, w9
0065CDF14  b.hs     #0x65ce0a4
0065CDF18  add      x8, x8, w21, sxtw #4
0065CDF1C  ldr      x24, [x8, #0x28]
0065CDF20  cbz      x24, #0x65ce0a8
0065CDF24  ldr      x22, [x24, #0x18]
0065CDF28  cmp      w22, #1
0065CDF2C  and      x21, x22, #0xffffffff
0065CDF30  b.lt     #0x65cdf98
0065CDF34  ldr      x8, [x24, #0x38]
0065CDF38  b.eq     #0x65cdf58
0065CDF3C  add      x9, x24, #0x70
0065CDF40  sub      x10, x21, #1
0065CDF44  ldr      x11, [x9], #0x38
0065CDF48  cmp      x11, x8
0065CDF4C  csel     x8, x11, x8, lt
0065CDF50  subs     x10, x10, #1
0065CDF54  b.ne     #0x65cdf44
0065CDF58  ldr      x9, [x20, #0x10]
0065CDF5C  cbz      x9, #0x65ce0a8
0065CDF60  adrp     x26, #0x8f05000
0065CDF64  ldr      x26, [x26, #0xa78]
0065CDF68  ldr      x9, [x9, #0x20]
0065CDF6C  ldr      x0, [x26]
0065CDF70  subs     x8, x8, x9
0065CDF74  cneg     x20, x8, mi
0065CDF78  ldr      w10, [x0, #0xe0]
0065CDF7C  cbnz     w10, #0x65cdf88
0065CDF80  bl       #0x382be8c ; 
0065CDF84  ldr      x0, [x26]
0065CDF88  ldr      x8, [x0, #0xb8]
0065CDF8C  ldr      x8, [x8, #0x10]
0065CDF90  add      x26, x8, x20
0065CDF94  b        #0x65cdf9c ; 
0065CDF98  mov      x26, xzr
0065CDF9C  ldr      x20, [x19, #0x188]
0065CDFA0  cbz      x20, #0x65ce0a8
0065CDFA4  ldr      x8, [x20]
0065CDFA8  ldr      x1, [x25]
0065CDFAC  ldrh     w9, [x8, #0x12e]
0065CDFB0  cbz      x9, #0x65cdfd4
0065CDFB4  ldr      x10, [x8, #0xb0]
0065CDFB8  add      x10, x10, #8
0065CDFBC  ldur     x11, [x10, #-8]
0065CDFC0  cmp      x11, x1
0065CDFC4  b.eq     #0x65cdfe4
0065CDFC8  subs     x9, x9, #1
0065CDFCC  add      x10, x10, #0x10
0065CDFD0  b.ne     #0x65cdfbc
0065CDFD4  mov      w2, #0x10
0065CDFD8  mov      x0, x20
0065CDFDC  bl       #0x3a7e710 ; 
0065CDFE0  b        #0x65cdff4 ; 
0065CDFE4  ldr      w9, [x10]
0065CDFE8  add      w9, w9, #0x10
0065CDFEC  add      x8, x8, w9, sxtw #4
0065CDFF0  add      x0, x8, #0x138
0065CDFF4  ldp      x8, x1, [x0]
0065CDFF8  mov      x0, x20
0065CDFFC  blr      x8
0065CE000  cbz      x0, #0x65ce0a8
0065CE004  ldr      w8, [x0, #0x18]
0065CE008  cbz      w8, #0x65ce0a4
0065CE00C  cmp      w22, #1
0065CE010  b.lt     #0x65ce074
0065CE014  ldr      w20, [x0, #0x20]
0065CE018  mov      x22, xzr
0065CE01C  add      x25, x24, #0x38
0065CE020  ldr      w8, [x24, #0x18]
0065CE024  cmp      x22, x8
0065CE028  b.hs     #0x65ce0a4
0065CE02C  ldp      x2, x8, [x25, #-8]
0065CE030  ldur     x1, [x25, #-0x10]
0065CE034  add      x0, sp, #0x20
0065CE038  mov      x4, xzr
0065CE03C  add      x3, x8, x26
0065CE040  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065CE044  ldr      q0, [sp, #0x20]
0065CE048  ldr      x8, [sp, #0x30]
0065CE04C  mov      x2, sp
0065CE050  mov      x0, x19
0065CE054  mov      w1, w20
0065CE058  str      q0, [sp]
0065CE05C  str      x8, [sp, #0x10]
0065CE060  bl       #0x65c0c04 ; HotFix.BattleLogic.SinglePlayerBattleManager$$CreateDropNpc
0065CE064  add      x22, x22, #1
0065CE068  cmp      x21, x22
0065CE06C  add      x25, x25, #0x38
0065CE070  b.ne     #0x65ce020
0065CE074  ldr      x8, [x23, #0x28]
0065CE078  ldr      x9, [sp, #0x38]
0065CE07C  cmp      x8, x9
0065CE080  b.ne     #0x65ce0ac
0065CE084  ldp      x20, x19, [sp, #0x90]
0065CE088  ldp      x22, x21, [sp, #0x80]
0065CE08C  ldp      x24, x23, [sp, #0x70]
0065CE090  ldp      x26, x25, [sp, #0x60]
0065CE094  ldp      x28, x27, [sp, #0x50]
0065CE098  ldr      x30, [sp, #0x40]
0065CE09C  add      sp, sp, #0xa0
0065CE0A0  ret      
0065CE0A4  bl       #0x382bfc0 ; 
0065CE0A8  bl       #0x382bfb8 ; 
0065CE0AC  bl       #0x89edb60 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$InitNewWaveData
; RVA 0x65CB634; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CB634  sub      sp, sp, #0x80
0065CB638  stp      x29, x30, [sp, #0x20]
0065CB63C  stp      x28, x27, [sp, #0x30]
0065CB640  stp      x26, x25, [sp, #0x40]
0065CB644  stp      x24, x23, [sp, #0x50]
0065CB648  stp      x22, x21, [sp, #0x60]
0065CB64C  stp      x20, x19, [sp, #0x70]
0065CB650  adrp     x20, #0x9599000
0065CB654  adrp     x21, #0x8f0a000
0065CB658  ldrb     w8, [x20, #0x587]
0065CB65C  ldr      x21, [x21, #0x7f8]
0065CB660  mov      x19, x0
0065CB664  tbnz     w8, #0, #0x65cb6ac
0065CB668  adrp     x0, #0x8f0a000
0065CB66C  ldr      x0, [x0, #0x800]
0065CB670  bl       #0x382bd14 ; 
0065CB674  adrp     x0, #0x8ee6000
0065CB678  ldr      x0, [x0, #0xd8]
0065CB67C  bl       #0x382bd14 ; 
0065CB680  adrp     x0, #0x8f09000
0065CB684  ldr      x0, [x0, #0xc08]
0065CB688  bl       #0x382bd14 ; 
0065CB68C  adrp     x0, #0x8f0a000
0065CB690  ldr      x0, [x0, #0x808]
0065CB694  bl       #0x382bd14 ; 
0065CB698  adrp     x0, #0x8f0a000
0065CB69C  ldr      x0, [x0, #0x7f8]
0065CB6A0  bl       #0x382bd14 ; 
0065CB6A4  mov      w8, #1
0065CB6A8  strb     w8, [x20, #0x587]
0065CB6AC  ldr      x1, [x21]
0065CB6B0  ldrb     w8, [x1, #0x53]
0065CB6B4  tbnz     w8, #5, #0x65cb70c
0065CB6B8  ldr      x20, [x19, #0x188]
0065CB6BC  cbz      x20, #0x65cc058
0065CB6C0  adrp     x29, #0x8f09000
0065CB6C4  ldr      x8, [x20]
0065CB6C8  ldr      w21, [x19, #0x130]
0065CB6CC  ldr      x29, [x29, #0xc08]
0065CB6D0  ldrh     w9, [x8, #0x12e]
0065CB6D4  ldr      x1, [x29]
0065CB6D8  cbz      x9, #0x65cb6fc
0065CB6DC  ldr      x10, [x8, #0xb0]
0065CB6E0  add      x10, x10, #8
0065CB6E4  ldur     x11, [x10, #-8]
0065CB6E8  cmp      x11, x1
0065CB6EC  b.eq     #0x65cb734
0065CB6F0  subs     x9, x9, #1
0065CB6F4  add      x10, x10, #0x10
0065CB6F8  b.ne     #0x65cb6e4
0065CB6FC  mov      w2, #2
0065CB700  mov      x0, x20
0065CB704  bl       #0x3a7e710 ; 
0065CB708  b        #0x65cb744 ; 
0065CB70C  ldr      x2, [x1, #0x60]
0065CB710  mov      x0, x19
0065CB714  ldp      x20, x19, [sp, #0x70]
0065CB718  ldp      x22, x21, [sp, #0x60]
0065CB71C  ldp      x24, x23, [sp, #0x50]
0065CB720  ldp      x26, x25, [sp, #0x40]
0065CB724  ldp      x28, x27, [sp, #0x30]
0065CB728  ldp      x29, x30, [sp, #0x20]
0065CB72C  add      sp, sp, #0x80
0065CB730  br       x2
0065CB734  ldr      w9, [x10]
0065CB738  add      w9, w9, #2
0065CB73C  add      x8, x8, w9, sxtw #4
0065CB740  add      x0, x8, #0x138
0065CB744  ldp      x8, x1, [x0]
0065CB748  mov      x0, x20
0065CB74C  blr      x8
0065CB750  cmp      w21, w0
0065CB754  b.ne     #0x65cb778
0065CB758  ldp      x20, x19, [sp, #0x70]
0065CB75C  ldp      x22, x21, [sp, #0x60]
0065CB760  ldp      x24, x23, [sp, #0x50]
0065CB764  ldp      x26, x25, [sp, #0x40]
0065CB768  ldp      x28, x27, [sp, #0x30]
0065CB76C  ldp      x29, x30, [sp, #0x20]
0065CB770  add      sp, sp, #0x80
0065CB774  ret      
0065CB778  ldr      x20, [x19, #0x188]
0065CB77C  str      xzr, [x19, #0x208]
0065CB780  cbz      x20, #0x65cc058
0065CB784  ldr      x8, [x20]
0065CB788  ldr      x1, [x29]
0065CB78C  ldrh     w9, [x8, #0x12e]
0065CB790  cbz      x9, #0x65cb7b4
0065CB794  ldr      x10, [x8, #0xb0]
0065CB798  add      x10, x10, #8
0065CB79C  ldur     x11, [x10, #-8]
0065CB7A0  cmp      x11, x1
0065CB7A4  b.eq     #0x65cb7c4
0065CB7A8  subs     x9, x9, #1
0065CB7AC  add      x10, x10, #0x10
0065CB7B0  b.ne     #0x65cb79c
0065CB7B4  mov      w2, #2
0065CB7B8  mov      x0, x20
0065CB7BC  bl       #0x3a7e710 ; 
0065CB7C0  b        #0x65cb7d4 ; 
0065CB7C4  ldr      w9, [x10]
0065CB7C8  add      w9, w9, #2
0065CB7CC  add      x8, x8, w9, sxtw #4
0065CB7D0  add      x0, x8, #0x138
0065CB7D4  ldp      x8, x1, [x0]
0065CB7D8  mov      x0, x20
0065CB7DC  blr      x8
0065CB7E0  mov      w20, #1
0065CB7E4  str      w0, [x19, #0x130]
0065CB7E8  str      wzr, [x19, #0x148]
0065CB7EC  str      wzr, [x19, #0x1c8]
0065CB7F0  str      wzr, [x19, #0x17c]
0065CB7F4  strb     w20, [x19, #0x210]
0065CB7F8  adrp     x26, #0x9599000
0065CB7FC  ldrb     w8, [x26, #0x286]
0065CB800  cbnz     w8, #0x65cb814
0065CB804  adrp     x0, #0x8f07000
0065CB808  ldr      x0, [x0, #0xc98]
0065CB80C  bl       #0x382bd14 ; 
0065CB810  strb     w20, [x26, #0x286]
0065CB814  adrp     x20, #0x8f07000
0065CB818  ldr      x20, [x20, #0xc98]
0065CB81C  ldr      x1, [x20]
0065CB820  ldrb     w8, [x1, #0x53]
0065CB824  tbnz     w8, #5, #0x65cb830
0065CB828  ldr      x0, [x19, #0x80]
0065CB82C  b        #0x65cb83c ; 
0065CB830  ldr      x8, [x1, #0x60]
0065CB834  mov      x0, x19
0065CB838  blr      x8
0065CB83C  cbz      x0, #0x65cc058
0065CB840  ldr      x0, [x0, #0x3b8]
0065CB844  mov      x1, xzr
0065CB848  bl       #0x6b26cc8 ; LocalModels.Bean.ChapterABTestExtension$$GetABWaveId
0065CB84C  ldr      x22, [x19, #0x188]
0065CB850  cbz      x22, #0x65cc058
0065CB854  ldr      x8, [x22]
0065CB858  ldr      x1, [x29]
0065CB85C  mov      w21, w0
0065CB860  ldrh     w9, [x8, #0x12e]
0065CB864  cbz      x9, #0x65cb888
0065CB868  ldr      x10, [x8, #0xb0]
0065CB86C  add      x10, x10, #8
0065CB870  ldur     x11, [x10, #-8]
0065CB874  cmp      x11, x1
0065CB878  b.eq     #0x65cb898
0065CB87C  subs     x9, x9, #1
0065CB880  add      x10, x10, #0x10
0065CB884  b.ne     #0x65cb870
0065CB888  mov      w2, #2
0065CB88C  mov      x0, x22
0065CB890  bl       #0x3a7e710 ; 
0065CB894  b        #0x65cb8a8 ; 
0065CB898  ldr      w9, [x10]
0065CB89C  add      w9, w9, #2
0065CB8A0  add      x8, x8, w9, sxtw #4
0065CB8A4  add      x0, x8, #0x138
0065CB8A8  ldp      x8, x1, [x0]
0065CB8AC  mov      x0, x22
0065CB8B0  blr      x8
0065CB8B4  ldrb     w8, [x26, #0x286]
0065CB8B8  mov      w23, w0
0065CB8BC  cbnz     w8, #0x65cb8d4
0065CB8C0  adrp     x0, #0x8f07000
0065CB8C4  ldr      x0, [x0, #0xc98]
0065CB8C8  bl       #0x382bd14 ; 
0065CB8CC  mov      w8, #1
0065CB8D0  strb     w8, [x26, #0x286]
0065CB8D4  ldr      x1, [x20]
0065CB8D8  ldrb     w8, [x1, #0x53]
0065CB8DC  tbnz     w8, #5, #0x65cb8e8
0065CB8E0  ldr      x24, [x19, #0x80]
0065CB8E4  b        #0x65cb8f8 ; 
0065CB8E8  ldr      x8, [x1, #0x60]
0065CB8EC  mov      x0, x19
0065CB8F0  blr      x8
0065CB8F4  mov      x24, x0
0065CB8F8  cbz      x24, #0x65cc058
0065CB8FC  adrp     x27, #0x9598000
0065CB900  ldrb     w8, [x27, #0xfcc]
0065CB904  cbnz     w8, #0x65cb91c
0065CB908  adrp     x0, #0x8f06000
0065CB90C  ldr      x0, [x0, #0x470]
0065CB910  bl       #0x382bd14 ; 
0065CB914  mov      w8, #1
0065CB918  strb     w8, [x27, #0xfcc]
0065CB91C  adrp     x22, #0x8f06000
0065CB920  ldr      x22, [x22, #0x470]
0065CB924  ldr      x1, [x22]
0065CB928  ldrb     w8, [x1, #0x53]
0065CB92C  tbnz     w8, #5, #0x65cb938
0065CB930  ldr      x0, [x24, #0x200]
0065CB934  b        #0x65cb944 ; 
0065CB938  ldr      x8, [x1, #0x60]
0065CB93C  mov      x0, x24
0065CB940  blr      x8
0065CB944  cbz      x0, #0x65cc058
0065CB948  add      w1, w23, w21
0065CB94C  mov      x2, xzr
0065CB950  bl       #0x64ce48c ; LocalModels.LocalModelManager$$GetChapterWave_Waves
0065CB954  add      x28, x19, #0x140
0065CB958  mov      x1, x0
0065CB95C  str      x0, [x19, #0x140]
0065CB960  mov      x0, x28
0065CB964  bl       #0x382bcb8 ; 
0065CB968  ldr      x0, [x19, #0x168]
0065CB96C  cbz      x0, #0x65cc058
0065CB970  adrp     x8, #0x8f0a000
0065CB974  ldr      x8, [x8, #0x808]
0065CB978  ldr      x1, [x8]
0065CB97C  bl       #0x5221e6c ; Rock.Collections.OrderedDictionary<int, int>$$Clear
0065CB980  ldr      x0, [x19, #0x1f0]
0065CB984  mov      w8, #-1
0065CB988  str      wzr, [x19, #0x150]
0065CB98C  str      wzr, [x19, #0x14c]
0065CB990  stp      xzr, xzr, [x19, #0x158]
0065CB994  str      w8, [x19, #0x13c]
0065CB998  str      w8, [x19, #0x134]
0065CB99C  cbz      x0, #0x65cc058
0065CB9A0  adrp     x8, #0x8f0a000
0065CB9A4  ldr      x8, [x8, #0x800]
0065CB9A8  ldr      x1, [x8]
0065CB9AC  bl       #0x5e5fbc4 ; System.Collections.Generic.Dictionary<int, object>$$Clear
0065CB9B0  ldr      x1, [x19, #0x140]
0065CB9B4  mov      x0, x19
0065CB9B8  mov      x2, xzr
0065CB9BC  bl       #0x6591480 ; HotFix.BattleLogic.BattleManager$$AddExBattleWaveAttr
0065CB9C0  ldrb     w8, [x26, #0x286]
0065CB9C4  cbnz     w8, #0x65cb9dc
0065CB9C8  adrp     x0, #0x8f07000
0065CB9CC  ldr      x0, [x0, #0xc98]
0065CB9D0  bl       #0x382bd14 ; 
0065CB9D4  mov      w8, #1
0065CB9D8  strb     w8, [x26, #0x286]
0065CB9DC  ldr      x1, [x20]
0065CB9E0  ldrb     w8, [x1, #0x53]
0065CB9E4  tbnz     w8, #5, #0x65cb9f0
0065CB9E8  ldr      x23, [x19, #0x80]
0065CB9EC  b        #0x65cba00 ; 
0065CB9F0  ldr      x8, [x1, #0x60]
0065CB9F4  mov      x0, x19
0065CB9F8  blr      x8
0065CB9FC  mov      x23, x0
0065CBA00  cbz      x23, #0x65cc058
0065CBA04  adrp     x21, #0x9599000
0065CBA08  ldrb     w8, [x21, #0x2c3]
0065CBA0C  cbnz     w8, #0x65cba24
0065CBA10  adrp     x0, #0x8f08000
0065CBA14  ldr      x0, [x0, #0x280]
0065CBA18  bl       #0x382bd14 ; 
0065CBA1C  mov      w8, #1
0065CBA20  strb     w8, [x21, #0x2c3]
0065CBA24  adrp     x8, #0x8f08000
0065CBA28  ldr      x8, [x8, #0x280]
0065CBA2C  ldr      x1, [x8]
0065CBA30  ldrb     w8, [x1, #0x53]
0065CBA34  tbnz     w8, #5, #0x65cba48
0065CBA38  add      x0, x23, #0x290
0065CBA3C  mov      x1, xzr
0065CBA40  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065CBA44  b        #0x65cba54 ; 
0065CBA48  ldr      x8, [x1, #0x60]
0065CBA4C  mov      x0, x23
0065CBA50  blr      x8
0065CBA54  ldrb     w8, [x26, #0x286]
0065CBA58  mov      w23, w0
0065CBA5C  cbnz     w8, #0x65cba74
0065CBA60  adrp     x0, #0x8f07000
0065CBA64  ldr      x0, [x0, #0xc98]
0065CBA68  bl       #0x382bd14 ; 
0065CBA6C  mov      w8, #1
0065CBA70  strb     w8, [x26, #0x286]
0065CBA74  ldr      x1, [x20]
0065CBA78  ldrb     w8, [x1, #0x53]
0065CBA7C  tbnz     w8, #5, #0x65cba88
0065CBA80  ldr      x24, [x19, #0x80]
0065CBA84  b        #0x65cba98 ; 
0065CBA88  ldr      x8, [x1, #0x60]
0065CBA8C  mov      x0, x19
0065CBA90  blr      x8
0065CBA94  mov      x24, x0
0065CBA98  cbz      x24, #0x65cc058
0065CBA9C  ldrb     w8, [x27, #0xfcc]
0065CBAA0  cbnz     w8, #0x65cbab8
0065CBAA4  adrp     x0, #0x8f06000
0065CBAA8  ldr      x0, [x0, #0x470]
0065CBAAC  bl       #0x382bd14 ; 
0065CBAB0  mov      w8, #1
0065CBAB4  strb     w8, [x27, #0xfcc]
0065CBAB8  ldr      x1, [x22]
0065CBABC  ldrb     w8, [x1, #0x53]
0065CBAC0  tbnz     w8, #5, #0x65cbacc
0065CBAC4  ldr      x24, [x24, #0x200]
0065CBAC8  b        #0x65cbadc ; 
0065CBACC  ldr      x8, [x1, #0x60]
0065CBAD0  mov      x0, x24
0065CBAD4  blr      x8
0065CBAD8  mov      x24, x0
0065CBADC  ldrb     w8, [x26, #0x286]
0065CBAE0  cbnz     w8, #0x65cbaf8
0065CBAE4  adrp     x0, #0x8f07000
0065CBAE8  ldr      x0, [x0, #0xc98]
0065CBAEC  bl       #0x382bd14 ; 
0065CBAF0  mov      w8, #1
0065CBAF4  strb     w8, [x26, #0x286]
0065CBAF8  ldr      x1, [x20]
0065CBAFC  ldrb     w8, [x1, #0x53]
0065CBB00  tbnz     w8, #5, #0x65cbb0c
0065CBB04  ldr      x0, [x19, #0x80]
0065CBB08  b        #0x65cbb18 ; 
0065CBB0C  ldr      x8, [x1, #0x60]
0065CBB10  mov      x0, x19
0065CBB14  blr      x8
0065CBB18  cbz      x0, #0x65cc058
0065CBB1C  ldr      w1, [x0, #0x1c8]
0065CBB20  mov      x0, x24
0065CBB24  mov      w2, w23
0065CBB28  mov      x3, xzr
0065CBB2C  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065CBB30  cbz      x0, #0x65cc058
0065CBB34  ldr      x8, [x0]
0065CBB38  ldr      w21, [x19, #0x130]
0065CBB3C  ldr      x1, [x29]
0065CBB40  mov      x24, x0
0065CBB44  ldrh     w9, [x8, #0x12e]
0065CBB48  cbz      x9, #0x65cbb6c
0065CBB4C  ldr      x10, [x8, #0xb0]
0065CBB50  add      x10, x10, #8
0065CBB54  ldur     x11, [x10, #-8]
0065CBB58  cmp      x11, x1
0065CBB5C  b.eq     #0x65cbb7c
0065CBB60  subs     x9, x9, #1
0065CBB64  add      x10, x10, #0x10
0065CBB68  b.ne     #0x65cbb54
0065CBB6C  mov      w2, #2
0065CBB70  mov      x0, x24
0065CBB74  bl       #0x3a7e710 ; 
0065CBB78  b        #0x65cbb8c ; 
0065CBB7C  ldr      w9, [x10]
0065CBB80  add      w9, w9, #2
0065CBB84  add      x8, x8, w9, sxtw #4
0065CBB88  add      x0, x8, #0x138
0065CBB8C  ldp      x8, x1, [x0]
0065CBB90  mov      x0, x24
0065CBB94  blr      x8
0065CBB98  mov      w25, w0
0065CBB9C  cmp      w0, #4
0065CBBA0  b.ne     #0x65cbd2c
0065CBBA4  ldrb     w8, [x26, #0x286]
0065CBBA8  cbnz     w8, #0x65cbbc0
0065CBBAC  adrp     x0, #0x8f07000
0065CBBB0  ldr      x0, [x0, #0xc98]
0065CBBB4  bl       #0x382bd14 ; 
0065CBBB8  mov      w8, #1
0065CBBBC  strb     w8, [x26, #0x286]
0065CBBC0  ldr      x1, [x20]
0065CBBC4  ldrb     w8, [x1, #0x53]
0065CBBC8  tbnz     w8, #5, #0x65cbbd4
0065CBBCC  ldr      x0, [x19, #0x80]
0065CBBD0  b        #0x65cbbe0 ; 
0065CBBD4  ldr      x8, [x1, #0x60]
0065CBBD8  mov      x0, x19
0065CBBDC  blr      x8
0065CBBE0  cbz      x0, #0x65cc058
0065CBBE4  ldr      w8, [x0, #0x1c8]
0065CBBE8  cmp      w8, #2
0065CBBEC  b.ne     #0x65cbd2c
0065CBBF0  ldrb     w8, [x26, #0x286]
0065CBBF4  cbnz     w8, #0x65cbc0c
0065CBBF8  adrp     x0, #0x8f07000
0065CBBFC  ldr      x0, [x0, #0xc98]
0065CBC00  bl       #0x382bd14 ; 
0065CBC04  mov      w8, #1
0065CBC08  strb     w8, [x26, #0x286]
0065CBC0C  ldr      x1, [x20]
0065CBC10  ldrb     w8, [x1, #0x53]
0065CBC14  tbnz     w8, #5, #0x65cbc20
0065CBC18  ldr      x0, [x19, #0x80]
0065CBC1C  b        #0x65cbc2c ; 
0065CBC20  ldr      x8, [x1, #0x60]
0065CBC24  mov      x0, x19
0065CBC28  blr      x8
0065CBC2C  cbz      x0, #0x65cc058
0065CBC30  mov      x1, xzr
0065CBC34  bl       #0x6a0fcc4 ; HotFix.BattleLogic.BattleWorldContext$$DispatchAccelerateMapMovement
0065CBC38  ldrb     w8, [x26, #0x286]
0065CBC3C  cbnz     w8, #0x65cbc54
0065CBC40  adrp     x0, #0x8f07000
0065CBC44  ldr      x0, [x0, #0xc98]
0065CBC48  bl       #0x382bd14 ; 
0065CBC4C  mov      w8, #1
0065CBC50  strb     w8, [x26, #0x286]
0065CBC54  ldr      x1, [x20]
0065CBC58  ldrb     w8, [x1, #0x53]
0065CBC5C  tbnz     w8, #5, #0x65cbc68
0065CBC60  ldr      x0, [x19, #0x80]
0065CBC64  b        #0x65cbc74 ; 
0065CBC68  ldr      x8, [x1, #0x60]
0065CBC6C  mov      x0, x19
0065CBC70  blr      x8
0065CBC74  ldr      x9, [x19, #0x88]
0065CBC78  cbz      x9, #0x65cc058
0065CBC7C  str      x28, [sp, #0x18]
0065CBC80  adrp     x8, #0x8ee6000
0065CBC84  ldr      x8, [x8, #0xd8]
0065CBC88  stp      x9, x0, [sp, #8]
0065CBC8C  ldr      x1, [x8]
0065CBC90  ldrb     w8, [x1, #0x53]
0065CBC94  tbnz     w8, #5, #0x65cbca0
0065CBC98  ldr      x28, [x9, #0x38]
0065CBC9C  b        #0x65cbcb0 ; 
0065CBCA0  ldr      x8, [x1, #0x60]
0065CBCA4  mov      x0, x9
0065CBCA8  blr      x8
0065CBCAC  mov      x28, x0
0065CBCB0  cbz      x28, #0x65cc058
0065CBCB4  adrp     x8, #0x9591000
0065CBCB8  ldrb     w8, [x8, #0xa7f]
0065CBCBC  cbnz     w8, #0x65cbcd8
0065CBCC0  adrp     x0, #0x8ee6000
0065CBCC4  ldr      x0, [x0, #0x2d8]
0065CBCC8  bl       #0x382bd14 ; 
0065CBCCC  mov      w8, #1
0065CBCD0  adrp     x9, #0x9591000
0065CBCD4  strb     w8, [x9, #0xa7f]
0065CBCD8  adrp     x8, #0x8ee6000
0065CBCDC  ldr      x8, [x8, #0x2d8]
0065CBCE0  ldr      x1, [x8]
0065CBCE4  ldrb     w8, [x1, #0x53]
0065CBCE8  tbnz     w8, #5, #0x65cbcf4
0065CBCEC  ldr      x2, [x28, #0x178]
0065CBCF0  b        #0x65cbd04 ; 
0065CBCF4  ldr      x8, [x1, #0x60]
0065CBCF8  mov      x0, x28
0065CBCFC  blr      x8
0065CBD00  mov      x2, x0
0065CBD04  ldp      x0, x28, [sp, #0x10]
0065CBD08  cbz      x0, #0x65cc058
0065CBD0C  ldr      x3, [x19, #0x88]
0065CBD10  ldr      x1, [sp, #8]
0065CBD14  mov      w4, #0xd
0065CBD18  mov      w5, #0x10000
0065CBD1C  mov      w6, wzr
0065CBD20  mov      w7, wzr
0065CBD24  str      xzr, [sp]
0065CBD28  bl       #0x6a0d17c ; HotFix.BattleLogic.BattleWorldContext$$AddBuffToEntity
0065CBD2C  cmp      w21, w25
0065CBD30  b.ne     #0x65cbf68
0065CBD34  mov      w25, #1
0065CBD38  ldr      w8, [x19, #0x134]
0065CBD3C  cmn      w8, #1
0065CBD40  b.ne     #0x65cbd48
0065CBD44  str      w23, [x19, #0x134]
0065CBD48  mov      x0, x19
0065CBD4C  mov      x1, x24
0065CBD50  str      w23, [x19, #0x138]
0065CBD54  bl       #0x65d0c70 ; HotFix.BattleLogic.WaterfallBattleManager$$CalSpecialMonsterCount
0065CBD58  cbz      x24, #0x65cc058
0065CBD5C  ldr      x8, [x24]
0065CBD60  ldr      x1, [x29]
0065CBD64  ldrh     w9, [x8, #0x12e]
0065CBD68  cbz      x9, #0x65cbd8c
0065CBD6C  ldr      x10, [x8, #0xb0]
0065CBD70  add      x10, x10, #8
0065CBD74  ldur     x11, [x10, #-8]
0065CBD78  cmp      x11, x1
0065CBD7C  b.eq     #0x65cbd9c
0065CBD80  subs     x9, x9, #1
0065CBD84  add      x10, x10, #0x10
0065CBD88  b.ne     #0x65cbd74
0065CBD8C  mov      w2, #8
0065CBD90  mov      x0, x24
0065CBD94  bl       #0x3a7e710 ; 
0065CBD98  b        #0x65cbdac ; 
0065CBD9C  ldr      w9, [x10]
0065CBDA0  add      w9, w9, #8
0065CBDA4  add      x8, x8, w9, sxtw #4
0065CBDA8  add      x0, x8, #0x138
0065CBDAC  ldp      x8, x1, [x0]
0065CBDB0  mov      x0, x24
0065CBDB4  blr      x8
0065CBDB8  cbz      w0, #0x65cbe20
0065CBDBC  ldr      x8, [x24]
0065CBDC0  ldr      x1, [x29]
0065CBDC4  ldrh     w9, [x8, #0x12e]
0065CBDC8  cbz      x9, #0x65cbdec
0065CBDCC  ldr      x10, [x8, #0xb0]
0065CBDD0  add      x10, x10, #8
0065CBDD4  ldur     x11, [x10, #-8]
0065CBDD8  cmp      x11, x1
0065CBDDC  b.eq     #0x65cbdfc
0065CBDE0  subs     x9, x9, #1
0065CBDE4  add      x10, x10, #0x10
0065CBDE8  b.ne     #0x65cbdd4
0065CBDEC  mov      w2, #8
0065CBDF0  mov      x0, x24
0065CBDF4  bl       #0x3a7e710 ; 
0065CBDF8  b        #0x65cbe0c ; 
0065CBDFC  ldr      w9, [x10]
0065CBE00  add      w9, w9, #8
0065CBE04  add      x8, x8, w9, sxtw #4
0065CBE08  add      x0, x8, #0x138
0065CBE0C  ldp      x8, x1, [x0]
0065CBE10  mov      x0, x24
0065CBE14  blr      x8
0065CBE18  cmp      w0, #2
0065CBE1C  b.ne     #0x65cbe30
0065CBE20  ldr      w8, [x19, #0x13c]
0065CBE24  cmn      w8, #1
0065CBE28  b.ne     #0x65cbe30
0065CBE2C  str      w23, [x19, #0x13c]
0065CBE30  ldrb     w8, [x26, #0x286]
0065CBE34  cbnz     w8, #0x65cbe44
0065CBE38  mov      x0, x20
0065CBE3C  bl       #0x382bd14 ; 
0065CBE40  strb     w25, [x26, #0x286]
0065CBE44  ldr      x1, [x20]
0065CBE48  ldrb     w8, [x1, #0x53]
0065CBE4C  tbnz     w8, #5, #0x65cbe58
0065CBE50  ldr      x24, [x19, #0x80]
0065CBE54  b        #0x65cbe68 ; 
0065CBE58  ldr      x8, [x1, #0x60]
0065CBE5C  mov      x0, x19
0065CBE60  blr      x8
0065CBE64  mov      x24, x0
0065CBE68  cbz      x24, #0x65cc058
0065CBE6C  ldrb     w8, [x27, #0xfcc]
0065CBE70  cbnz     w8, #0x65cbe80
0065CBE74  mov      x0, x22
0065CBE78  bl       #0x382bd14 ; 
0065CBE7C  strb     w25, [x27, #0xfcc]
0065CBE80  ldr      x1, [x22]
0065CBE84  ldrb     w8, [x1, #0x53]
0065CBE88  tbnz     w8, #5, #0x65cbe94
0065CBE8C  ldr      x24, [x24, #0x200]
0065CBE90  b        #0x65cbea4 ; 
0065CBE94  ldr      x8, [x1, #0x60]
0065CBE98  mov      x0, x24
0065CBE9C  blr      x8
0065CBEA0  mov      x24, x0
0065CBEA4  ldrb     w8, [x26, #0x286]
0065CBEA8  cbnz     w8, #0x65cbeb8
0065CBEAC  mov      x0, x20
0065CBEB0  bl       #0x382bd14 ; 
0065CBEB4  strb     w25, [x26, #0x286]
0065CBEB8  ldr      x1, [x20]
0065CBEBC  ldrb     w8, [x1, #0x53]
0065CBEC0  tbnz     w8, #5, #0x65cbecc
0065CBEC4  ldr      x0, [x19, #0x80]
0065CBEC8  b        #0x65cbed8 ; 
0065CBECC  ldr      x8, [x1, #0x60]
0065CBED0  mov      x0, x19
0065CBED4  blr      x8
0065CBED8  cbz      x0, #0x65cc058
0065CBEDC  ldr      w1, [x0, #0x1c8]
0065CBEE0  add      w23, w23, #1
0065CBEE4  mov      x0, x24
0065CBEE8  mov      w2, w23
0065CBEEC  mov      x3, xzr
0065CBEF0  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065CBEF4  mov      x24, x0
0065CBEF8  cbz      x0, #0x65cbf3c
0065CBEFC  ldr      x8, [x24]
0065CBF00  ldr      x1, [x29]
0065CBF04  ldrh     w9, [x8, #0x12e]
0065CBF08  cbz      x9, #0x65cbf2c
0065CBF0C  ldr      x10, [x8, #0xb0]
0065CBF10  add      x10, x10, #8
0065CBF14  ldur     x11, [x10, #-8]
0065CBF18  cmp      x11, x1
0065CBF1C  b.eq     #0x65cbf44
0065CBF20  subs     x9, x9, #1
0065CBF24  add      x10, x10, #0x10
0065CBF28  b.ne     #0x65cbf14
0065CBF2C  mov      w2, #2
0065CBF30  mov      x0, x24
0065CBF34  bl       #0x3a7e710 ; 
0065CBF38  b        #0x65cbf54 ; 
0065CBF3C  mov      w0, #-1
0065CBF40  b        #0x65cbf60 ; 
0065CBF44  ldr      w9, [x10]
0065CBF48  add      w9, w9, #2
0065CBF4C  add      x8, x8, w9, sxtw #4
0065CBF50  add      x0, x8, #0x138
0065CBF54  ldp      x8, x1, [x0]
0065CBF58  mov      x0, x24
0065CBF5C  blr      x8
0065CBF60  cmp      w21, w0
0065CBF64  b.eq     #0x65cbd38
0065CBF68  ldr      x20, [x28]
0065CBF6C  cbz      x20, #0x65cc058
0065CBF70  adrp     x21, #0x9599000
0065CBF74  ldrb     w8, [x21, #0x658]
0065CBF78  cbnz     w8, #0x65cbf90
0065CBF7C  adrp     x0, #0x8f0a000
0065CBF80  ldr      x0, [x0, #0x810]
0065CBF84  bl       #0x382bd14 ; 
0065CBF88  mov      w8, #1
0065CBF8C  strb     w8, [x21, #0x658]
0065CBF90  adrp     x22, #0x8f0a000
0065CBF94  ldr      x22, [x22, #0x810]
0065CBF98  ldr      x1, [x22]
0065CBF9C  ldrb     w8, [x1, #0x53]
0065CBFA0  tbnz     w8, #5, #0x65cbfac
0065CBFA4  ldr      w0, [x20, #0x28]
0065CBFA8  b        #0x65cbfb8 ; 
0065CBFAC  ldr      x8, [x1, #0x60]
0065CBFB0  mov      x0, x20
0065CBFB4  blr      x8
0065CBFB8  cmp      w0, #1
0065CBFBC  b.lt     #0x65cc034
0065CBFC0  ldr      x20, [x28]
0065CBFC4  cbz      x20, #0x65cc058
0065CBFC8  ldrb     w8, [x21, #0x658]
0065CBFCC  cbnz     w8, #0x65cbfe4
0065CBFD0  adrp     x0, #0x8f0a000
0065CBFD4  ldr      x0, [x0, #0x810]
0065CBFD8  bl       #0x382bd14 ; 
0065CBFDC  mov      w8, #1
0065CBFE0  strb     w8, [x21, #0x658]
0065CBFE4  ldr      x1, [x22]
0065CBFE8  ldrb     w8, [x1, #0x53]
0065CBFEC  tbnz     w8, #5, #0x65cbff8
0065CBFF0  ldr      w0, [x20, #0x28]
0065CBFF4  b        #0x65cc004 ; 
0065CBFF8  ldr      x8, [x1, #0x60]
0065CBFFC  mov      x0, x20
0065CC000  blr      x8
0065CC004  ldrsw    x8, [x19, #0x150]
0065CC008  add      x20, x19, #0x158
0065CC00C  cbz      w8, #0x65cc01c
0065CC010  sbfiz    x9, x0, #0x10, #0x20
0065CC014  sdiv     x1, x9, x8
0065CC018  b        #0x65cc020 ; 
0065CC01C  mov      x1, xzr
0065CC020  mov      w0, #0x10000
0065CC024  mov      x2, xzr
0065CC028  str      x1, [x20]
0065CC02C  bl       #0x7d46f68 ; Photon.Deterministic.FPMath$$Max
0065CC030  str      x0, [x20]
0065CC034  mov      x0, x19
0065CC038  ldp      x20, x19, [sp, #0x70]
0065CC03C  ldp      x22, x21, [sp, #0x60]
0065CC040  ldp      x24, x23, [sp, #0x50]
0065CC044  ldp      x26, x25, [sp, #0x40]
0065CC048  ldp      x28, x27, [sp, #0x30]
0065CC04C  ldp      x29, x30, [sp, #0x20]
0065CC050  add      sp, sp, #0x80
0065CC054  b        #0x65d0ec0 ; HotFix.BattleLogic.WaterfallBattleManager$$InitWaveGoldData
0065CC058  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$InitWaveGoldData
; RVA 0x65D0EC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D0EC0  sub      sp, sp, #0xb0
0065D0EC4  stp      x29, x30, [sp, #0x50]
0065D0EC8  stp      x28, x27, [sp, #0x60]
0065D0ECC  stp      x26, x25, [sp, #0x70]
0065D0ED0  stp      x24, x23, [sp, #0x80]
0065D0ED4  stp      x22, x21, [sp, #0x90]
0065D0ED8  stp      x20, x19, [sp, #0xa0]
0065D0EDC  adrp     x20, #0x9599000
0065D0EE0  adrp     x21, #0x8f0a000
0065D0EE4  ldrb     w8, [x20, #0x588]
0065D0EE8  ldr      x21, [x21, #0x9b0]
0065D0EEC  mov      x19, x0
0065D0EF0  tbnz     w8, #0, #0x65d0f68
0065D0EF4  adrp     x0, #0x8ee6000
0065D0EF8  ldr      x0, [x0, #0xed8]
0065D0EFC  bl       #0x382bd14 ; 
0065D0F00  adrp     x0, #0x8ee6000
0065D0F04  ldr      x0, [x0, #0xee0]
0065D0F08  bl       #0x382bd14 ; 
0065D0F0C  adrp     x0, #0x8ee6000
0065D0F10  ldr      x0, [x0, #0xee8]
0065D0F14  bl       #0x382bd14 ; 
0065D0F18  adrp     x0, #0x8ee6000
0065D0F1C  ldr      x0, [x0, #0xf00]
0065D0F20  bl       #0x382bd14 ; 
0065D0F24  adrp     x0, #0x8ee6000
0065D0F28  ldr      x0, [x0, #0xf08]
0065D0F2C  bl       #0x382bd14 ; 
0065D0F30  adrp     x0, #0x8f0a000
0065D0F34  ldr      x0, [x0, #0x9b8]
0065D0F38  bl       #0x382bd14 ; 
0065D0F3C  adrp     x0, #0x8ee6000
0065D0F40  ldr      x0, [x0, #0xf10]
0065D0F44  bl       #0x382bd14 ; 
0065D0F48  adrp     x0, #0x8f09000
0065D0F4C  ldr      x0, [x0, #0xa20]
0065D0F50  bl       #0x382bd14 ; 
0065D0F54  adrp     x0, #0x8f0a000
0065D0F58  ldr      x0, [x0, #0x9b0]
0065D0F5C  bl       #0x382bd14 ; 
0065D0F60  mov      w8, #1
0065D0F64  strb     w8, [x20, #0x588]
0065D0F68  ldr      x1, [x21]
0065D0F6C  ldrb     w8, [x1, #0x53]
0065D0F70  tbnz     w8, #5, #0x65d0fc0
0065D0F74  movi     v0.2d, #0000000000000000
0065D0F78  stp      q0, q0, [sp, #0x30]
0065D0F7C  ldr      x20, [x19, #0x140]
0065D0F80  cbz      x20, #0x65d1510
0065D0F84  adrp     x21, #0x9599000
0065D0F88  ldrb     w8, [x21, #0x659]
0065D0F8C  cbnz     w8, #0x65d0fa4
0065D0F90  adrp     x0, #0x8f0a000
0065D0F94  ldr      x0, [x0, #0x9c0]
0065D0F98  bl       #0x382bd14 ; 
0065D0F9C  mov      w8, #1
0065D0FA0  strb     w8, [x21, #0x659]
0065D0FA4  adrp     x8, #0x8f0a000
0065D0FA8  ldr      x8, [x8, #0x9c0]
0065D0FAC  ldr      x1, [x8]
0065D0FB0  ldrb     w8, [x1, #0x53]
0065D0FB4  tbnz     w8, #5, #0x65d0fe8
0065D0FB8  ldr      w9, [x20, #0x6c]
0065D0FBC  b        #0x65d0ff8 ; 
0065D0FC0  ldr      x2, [x1, #0x60]
0065D0FC4  mov      x0, x19
0065D0FC8  ldp      x20, x19, [sp, #0xa0]
0065D0FCC  ldp      x22, x21, [sp, #0x90]
0065D0FD0  ldp      x24, x23, [sp, #0x80]
0065D0FD4  ldp      x26, x25, [sp, #0x70]
0065D0FD8  ldp      x28, x27, [sp, #0x60]
0065D0FDC  ldp      x29, x30, [sp, #0x50]
0065D0FE0  add      sp, sp, #0xb0
0065D0FE4  br       x2
0065D0FE8  ldr      x8, [x1, #0x60]
0065D0FEC  mov      x0, x20
0065D0FF0  blr      x8
0065D0FF4  mov      w9, w0
0065D0FF8  ldr      x0, [x19, #0x168]
0065D0FFC  cbz      x0, #0x65d1510
0065D1000  adrp     x8, #0x8ee6000
0065D1004  ldr      x8, [x8, #0xf10]
0065D1008  ldr      x1, [x8]
0065D100C  sbfiz    x8, x9, #0x10, #0x20
0065D1010  stp      x9, x8, [sp]
0065D1014  add      x8, sp, #0x10
0065D1018  bl       #0x52221a0 ; Rock.Collections.OrderedDictionary<int, int>$$GetEnumerator
0065D101C  ldp      q0, q1, [sp, #0x10]
0065D1020  adrp     x23, #0x8ee6000
0065D1024  adrp     x22, #0x8f07000
0065D1028  adrp     x21, #0x8f06000
0065D102C  ldr      x23, [x23, #0xee0]
0065D1030  ldr      x22, [x22, #0xc98]
0065D1034  ldr      x21, [x21, #0x470]
0065D1038  mov      x28, xzr
0065D103C  adrp     x29, #0x9599000
0065D1040  mov      w24, #1
0065D1044  adrp     x20, #0x9598000
0065D1048  stp      q0, q1, [sp, #0x30]
0065D104C  ldr      x1, [x23]
0065D1050  add      x0, sp, #0x30
0065D1054  bl       #0x614f0cc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$MoveNext
0065D1058  tbz      w0, #0, #0x65d1190
0065D105C  ldrb     w8, [x29, #0x286]
0065D1060  ldr      x25, [sp, #0x40]
0065D1064  cbnz     w8, #0x65d1074
0065D1068  mov      x0, x22
0065D106C  bl       #0x382bd14 ; 
0065D1070  strb     w24, [x29, #0x286]
0065D1074  ldr      x1, [x22]
0065D1078  ldrb     w8, [x1, #0x53]
0065D107C  tbnz     w8, #5, #0x65d1088
0065D1080  ldr      x26, [x19, #0x80]
0065D1084  b        #0x65d1098 ; 
0065D1088  ldr      x8, [x1, #0x60]
0065D108C  mov      x0, x19
0065D1090  blr      x8
0065D1094  mov      x26, x0
0065D1098  cbz      x26, #0x65d1508
0065D109C  ldrb     w8, [x20, #0xfcc]
0065D10A0  cbnz     w8, #0x65d10b0
0065D10A4  mov      x0, x21
0065D10A8  bl       #0x382bd14 ; 
0065D10AC  strb     w24, [x20, #0xfcc]
0065D10B0  ldr      x1, [x21]
0065D10B4  ldrb     w8, [x1, #0x53]
0065D10B8  tbnz     w8, #5, #0x65d10c4
0065D10BC  ldr      x0, [x26, #0x200]
0065D10C0  b        #0x65d10d0 ; 
0065D10C4  ldr      x8, [x1, #0x60]
0065D10C8  mov      x0, x26
0065D10CC  blr      x8
0065D10D0  cbz      x0, #0x65d150c
0065D10D4  mov      w1, w25
0065D10D8  mov      x2, xzr
0065D10DC  bl       #0x64d34c0 ; LocalModels.LocalModelManager$$GetCharacter_MonsterDropType
0065D10E0  mov      x26, x0
0065D10E4  cbz      x0, #0x65d104c
0065D10E8  adrp     x8, #0x9599000
0065D10EC  ldrb     w8, [x8, #0x65a]
0065D10F0  cbnz     w8, #0x65d1108
0065D10F4  adrp     x0, #0x8f0a000
0065D10F8  ldr      x0, [x0, #0x9c8]
0065D10FC  bl       #0x382bd14 ; 
0065D1100  adrp     x8, #0x9599000
0065D1104  strb     w24, [x8, #0x65a]
0065D1108  adrp     x8, #0x8f0a000
0065D110C  ldr      x8, [x8, #0x9c8]
0065D1110  ldr      x1, [x8]
0065D1114  ldrb     w8, [x1, #0x53]
0065D1118  tbnz     w8, #5, #0x65d1124
0065D111C  ldr      x27, [x26, #0x28]
0065D1120  b        #0x65d1134 ; 
0065D1124  ldr      x8, [x1, #0x60]
0065D1128  mov      x0, x26
0065D112C  blr      x8
0065D1130  mov      x27, x0
0065D1134  adrp     x8, #0x9599000
0065D1138  ldrb     w8, [x8, #0x65b]
0065D113C  cbnz     w8, #0x65d1154
0065D1140  adrp     x0, #0x8f0a000
0065D1144  ldr      x0, [x0, #0x9d0]
0065D1148  bl       #0x382bd14 ; 
0065D114C  adrp     x8, #0x9599000
0065D1150  strb     w24, [x8, #0x65b]
0065D1154  adrp     x8, #0x8f0a000
0065D1158  ldr      x8, [x8, #0x9d0]
0065D115C  ldr      x1, [x8]
0065D1160  ldrb     w8, [x1, #0x53]
0065D1164  tbnz     w8, #5, #0x65d1170
0065D1168  ldr      x0, [x26, #0x30]
0065D116C  b        #0x65d117c ; 
0065D1170  ldr      x8, [x1, #0x60]
0065D1174  mov      x0, x26
0065D1178  blr      x8
0065D117C  asr      x8, x25, #0x20
0065D1180  mul      x8, x27, x8
0065D1184  mul      x8, x8, x0
0065D1188  add      x28, x28, x8, asr #16
0065D118C  b        #0x65d104c ; 
0065D1190  adrp     x8, #0x8ee6000
0065D1194  ldr      x8, [x8, #0xed8]
0065D1198  add      x0, sp, #0x30
0065D119C  ldr      x1, [x8]
0065D11A0  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
0065D11A4  cbz      x28, #0x65d11b8
0065D11A8  ldr      x8, [sp]
0065D11AC  lsl      x8, x8, #0x20
0065D11B0  sdiv     x8, x8, x28
0065D11B4  b        #0x65d11bc ; 
0065D11B8  mov      x8, xzr
0065D11BC  ldr      x28, [sp, #8]
0065D11C0  ldr      x0, [x19, #0x168]
0065D11C4  str      x8, [x19, #0x170]
0065D11C8  cbz      x0, #0x65d1510
0065D11CC  adrp     x8, #0x8ee6000
0065D11D0  ldr      x8, [x8, #0xf10]
0065D11D4  ldr      x1, [x8]
0065D11D8  add      x8, sp, #0x10
0065D11DC  bl       #0x52221a0 ; Rock.Collections.OrderedDictionary<int, int>$$GetEnumerator
0065D11E0  ldp      q0, q1, [sp, #0x10]
0065D11E4  mov      w27, #1
0065D11E8  stp      q0, q1, [sp, #0x30]
0065D11EC  ldr      x1, [x23]
0065D11F0  add      x0, sp, #0x30
0065D11F4  bl       #0x614f0cc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$MoveNext
0065D11F8  tbz      w0, #0, #0x65d134c
0065D11FC  ldr      x24, [sp, #0x40]
0065D1200  cmp      w24, #2
0065D1204  b.lt     #0x65d11ec
0065D1208  ldrb     w8, [x29, #0x286]
0065D120C  cbnz     w8, #0x65d121c
0065D1210  mov      x0, x22
0065D1214  bl       #0x382bd14 ; 
0065D1218  strb     w27, [x29, #0x286]
0065D121C  ldr      x1, [x22]
0065D1220  ldrb     w8, [x1, #0x53]
0065D1224  tbnz     w8, #5, #0x65d1230
0065D1228  ldr      x25, [x19, #0x80]
0065D122C  b        #0x65d1240 ; 
0065D1230  ldr      x8, [x1, #0x60]
0065D1234  mov      x0, x19
0065D1238  blr      x8
0065D123C  mov      x25, x0
0065D1240  cbz      x25, #0x65d1518
0065D1244  ldrb     w8, [x20, #0xfcc]
0065D1248  cbnz     w8, #0x65d1258
0065D124C  mov      x0, x21
0065D1250  bl       #0x382bd14 ; 
0065D1254  strb     w27, [x20, #0xfcc]
0065D1258  ldr      x1, [x21]
0065D125C  ldrb     w8, [x1, #0x53]
0065D1260  tbnz     w8, #5, #0x65d126c
0065D1264  ldr      x0, [x25, #0x200]
0065D1268  b        #0x65d1278 ; 
0065D126C  ldr      x8, [x1, #0x60]
0065D1270  mov      x0, x25
0065D1274  blr      x8
0065D1278  cbz      x0, #0x65d151c
0065D127C  mov      w1, w24
0065D1280  mov      x2, xzr
0065D1284  bl       #0x64d34c0 ; LocalModels.LocalModelManager$$GetCharacter_MonsterDropType
0065D1288  mov      x25, x0
0065D128C  cbz      x0, #0x65d1514
0065D1290  adrp     x8, #0x9599000
0065D1294  ldrb     w8, [x8, #0x65a]
0065D1298  cbnz     w8, #0x65d12b0
0065D129C  adrp     x0, #0x8f0a000
0065D12A0  ldr      x0, [x0, #0x9c8]
0065D12A4  bl       #0x382bd14 ; 
0065D12A8  adrp     x8, #0x9599000
0065D12AC  strb     w27, [x8, #0x65a]
0065D12B0  adrp     x8, #0x8f0a000
0065D12B4  ldr      x8, [x8, #0x9c8]
0065D12B8  ldr      x1, [x8]
0065D12BC  ldrb     w8, [x1, #0x53]
0065D12C0  tbnz     w8, #5, #0x65d12cc
0065D12C4  ldr      x26, [x25, #0x28]
0065D12C8  b        #0x65d12dc ; 
0065D12CC  ldr      x8, [x1, #0x60]
0065D12D0  mov      x0, x25
0065D12D4  blr      x8
0065D12D8  mov      x26, x0
0065D12DC  adrp     x8, #0x9599000
0065D12E0  ldrb     w8, [x8, #0x65b]
0065D12E4  cbnz     w8, #0x65d12fc
0065D12E8  adrp     x0, #0x8f0a000
0065D12EC  ldr      x0, [x0, #0x9d0]
0065D12F0  bl       #0x382bd14 ; 
0065D12F4  adrp     x8, #0x9599000
0065D12F8  strb     w27, [x8, #0x65b]
0065D12FC  adrp     x8, #0x8f0a000
0065D1300  ldr      x8, [x8, #0x9d0]
0065D1304  ldr      x1, [x8]
0065D1308  ldrb     w8, [x1, #0x53]
0065D130C  tbnz     w8, #5, #0x65d1318
0065D1310  ldr      x0, [x25, #0x30]
0065D1314  b        #0x65d1324 ; 
0065D1318  ldr      x8, [x1, #0x60]
0065D131C  mov      x0, x25
0065D1320  blr      x8
0065D1324  ldr      x8, [x19, #0x170]
0065D1328  mul      x9, x0, x26
0065D132C  asr      x9, x9, #0x10
0065D1330  mul      x8, x9, x8
0065D1334  asr      x0, x8, #0x10
0065D1338  mov      x1, xzr
0065D133C  bl       #0x7d46e14 ; Photon.Deterministic.FPMath$$Floor
0065D1340  asr      x8, x24, #0x20
0065D1344  msub     x28, x0, x8, x28
0065D1348  b        #0x65d11ec ; 
0065D134C  adrp     x8, #0x8ee6000
0065D1350  ldr      x8, [x8, #0xed8]
0065D1354  add      x0, sp, #0x30
0065D1358  ldr      x1, [x8]
0065D135C  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
0065D1360  ldrb     w8, [x29, #0x286]
0065D1364  cbnz     w8, #0x65d137c
0065D1368  adrp     x0, #0x8f07000
0065D136C  ldr      x0, [x0, #0xc98]
0065D1370  bl       #0x382bd14 ; 
0065D1374  mov      w8, #1
0065D1378  strb     w8, [x29, #0x286]
0065D137C  ldr      x1, [x22]
0065D1380  ldrb     w8, [x1, #0x53]
0065D1384  tbnz     w8, #5, #0x65d1390
0065D1388  ldr      x22, [x19, #0x80]
0065D138C  b        #0x65d13a0 ; 
0065D1390  ldr      x8, [x1, #0x60]
0065D1394  mov      x0, x19
0065D1398  blr      x8
0065D139C  mov      x22, x0
0065D13A0  cbz      x22, #0x65d1510
0065D13A4  ldrb     w8, [x20, #0xfcc]
0065D13A8  cbnz     w8, #0x65d13c0
0065D13AC  adrp     x0, #0x8f06000
0065D13B0  ldr      x0, [x0, #0x470]
0065D13B4  bl       #0x382bd14 ; 
0065D13B8  mov      w8, #1
0065D13BC  strb     w8, [x20, #0xfcc]
0065D13C0  ldr      x1, [x21]
0065D13C4  ldrb     w8, [x1, #0x53]
0065D13C8  tbnz     w8, #5, #0x65d13d4
0065D13CC  ldr      x0, [x22, #0x200]
0065D13D0  b        #0x65d13e0 ; 
0065D13D4  ldr      x8, [x1, #0x60]
0065D13D8  mov      x0, x22
0065D13DC  blr      x8
0065D13E0  adrp     x22, #0x9599000
0065D13E4  cbz      x0, #0x65d1510
0065D13E8  mov      w1, #1
0065D13EC  mov      x2, xzr
0065D13F0  bl       #0x64d34c0 ; LocalModels.LocalModelManager$$GetCharacter_MonsterDropType
0065D13F4  cbz      x0, #0x65d1510
0065D13F8  ldrb     w8, [x22, #0x65a]
0065D13FC  ldr      x20, [x19, #0x170]
0065D1400  mov      x21, x0
0065D1404  cbnz     w8, #0x65d141c
0065D1408  adrp     x0, #0x8f0a000
0065D140C  ldr      x0, [x0, #0x9c8]
0065D1410  bl       #0x382bd14 ; 
0065D1414  mov      w8, #1
0065D1418  strb     w8, [x22, #0x65a]
0065D141C  adrp     x8, #0x8f0a000
0065D1420  ldr      x8, [x8, #0x9c8]
0065D1424  ldr      x1, [x8]
0065D1428  ldrb     w8, [x1, #0x53]
0065D142C  tbnz     w8, #5, #0x65d1438
0065D1430  ldr      x0, [x21, #0x28]
0065D1434  b        #0x65d1444 ; 
0065D1438  ldr      x8, [x1, #0x60]
0065D143C  mov      x0, x21
0065D1440  blr      x8
0065D1444  mul      x8, x0, x20
0065D1448  asr      x0, x8, #0x10
0065D144C  mov      x1, xzr
0065D1450  bl       #0x7d46e14 ; Photon.Deterministic.FPMath$$Floor
0065D1454  cbz      x0, #0x65d1460
0065D1458  lsl      x8, x28, #0x10
0065D145C  sdiv     x0, x8, x0
0065D1460  mov      x1, xzr
0065D1464  bl       #0x7d46e14 ; Photon.Deterministic.FPMath$$Floor
0065D1468  mov      x1, x0
0065D146C  mov      x0, xzr
0065D1470  mov      x2, xzr
0065D1474  bl       #0x7d46f68 ; Photon.Deterministic.FPMath$$Max
0065D1478  ldr      x8, [x19, #0x168]
0065D147C  lsr      x9, x0, #0x10
0065D1480  str      w9, [x19, #0x178]
0065D1484  cbz      x8, #0x65d1510
0065D1488  adrp     x9, #0x8f0a000
0065D148C  ldr      x9, [x9, #0x9b8]
0065D1490  mov      w1, #1
0065D1494  mov      x0, x8
0065D1498  ldr      x2, [x9]
0065D149C  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
0065D14A0  tbz      w0, #0, #0x65d14c8
0065D14A4  ldr      x0, [x19, #0x168]
0065D14A8  cbz      x0, #0x65d1510
0065D14AC  adrp     x8, #0x8f09000
0065D14B0  ldr      x8, [x8, #0xa20]
0065D14B4  mov      w1, #1
0065D14B8  ldr      x2, [x8]
0065D14BC  bl       #0x5221c50 ; Rock.Collections.OrderedDictionary<int, int>$$get_Item
0065D14C0  mov      w1, w0
0065D14C4  b        #0x65d14cc ; 
0065D14C8  mov      w1, wzr
0065D14CC  ldr      w2, [x19, #0x178]
0065D14D0  mov      x0, x19
0065D14D4  bl       #0x65d163c ; HotFix.BattleLogic.WaterfallBattleManager$$ShuffleWithFisherYates
0065D14D8  mov      x1, x0
0065D14DC  add      x0, x19, #0x1f8
0065D14E0  str      x1, [x19, #0x1f8]
0065D14E4  bl       #0x382bcb8 ; 
0065D14E8  ldp      x20, x19, [sp, #0xa0]
0065D14EC  ldp      x22, x21, [sp, #0x90]
0065D14F0  ldp      x24, x23, [sp, #0x80]
0065D14F4  ldp      x26, x25, [sp, #0x70]
0065D14F8  ldp      x28, x27, [sp, #0x60]
0065D14FC  ldp      x29, x30, [sp, #0x50]
0065D1500  add      sp, sp, #0xb0
0065D1504  ret      
0065D1508  bl       #0x382bfb8 ; 
0065D150C  bl       #0x382bfb8 ; 
0065D1510  bl       #0x382bfb8 ; 
0065D1514  bl       #0x382bfb8 ; 
0065D1518  bl       #0x382bfb8 ; 
0065D151C  bl       #0x382bfb8 ; 
0065D1520  b        #0x65d1560 ; 
0065D1524  b        #0x65d1560 ; 
0065D1528  b        #0x65d15d0 ; 
0065D152C  b        #0x65d15d0 ; 
0065D1530  b        #0x65d15d0 ; 
0065D1534  b        #0x65d15d0 ; 
0065D1538  b        #0x65d15d0 ; 
0065D153C  b        #0x65d15d0 ; 
0065D1540  b        #0x65d15d0 ; 
0065D1544  b        #0x65d15d0 ; 
0065D1548  b        #0x65d15d0 ; 
0065D154C  b        #0x65d1560 ; 
0065D1550  b        #0x65d1560 ; 
0065D1554  b        #0x65d1560 ; 
0065D1558  b        #0x65d1560 ; 
0065D155C  b        #0x65d1560 ; 
0065D1560  mov      x25, x0
0065D1564  cmp      w1, #1
0065D1568  b.ne     #0x65d159c
0065D156C  mov      x0, x25
0065D1570  bl       #0x89eda50 ; 
0065D1574  ldr      x26, [x0]
0065D1578  bl       #0x89eda60 ; 
0065D157C  adrp     x8, #0x8ee6000
0065D1580  ldr      x8, [x8, #0xed8]
0065D1584  add      x0, sp, #0x30
0065D1588  ldr      x1, [x8]
0065D158C  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
0065D1590  cbz      x26, #0x65d11a4
0065D1594  mov      x0, x26
0065D1598  bl       #0x382bfb0 ; 
0065D159C  mov      x26, xzr
0065D15A0  b        #0x65d15a8 ; 
0065D15A4  mov      x25, x0
0065D15A8  adrp     x8, #0x8ee6000
0065D15AC  ldr      x8, [x8, #0xed8]
0065D15B0  ldr      x1, [x8]
0065D15B4  add      x0, sp, #0x30
0065D15B8  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
0065D15BC  cbnz     x26, #0x65d15c8
0065D15C0  mov      x0, x25
0065D15C4  bl       #0x3b56bfc ; 
0065D15C8  mov      x0, x26
0065D15CC  bl       #0x382bfb0 ; 
0065D15D0  mov      x25, x0
0065D15D4  cmp      w1, #1
0065D15D8  b.ne     #0x65d160c
0065D15DC  mov      x0, x25
0065D15E0  bl       #0x89eda50 ; 
0065D15E4  ldr      x23, [x0]
0065D15E8  bl       #0x89eda60 ; 
0065D15EC  adrp     x8, #0x8ee6000
0065D15F0  ldr      x8, [x8, #0xed8]
0065D15F4  add      x0, sp, #0x30
0065D15F8  ldr      x1, [x8]
0065D15FC  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
0065D1600  cbz      x23, #0x65d1360
0065D1604  mov      x0, x23
0065D1608  bl       #0x382bfb0 ; 
0065D160C  mov      x23, xzr
0065D1610  b        #0x65d1618 ; 
0065D1614  mov      x25, x0
0065D1618  adrp     x8, #0x8ee6000
0065D161C  ldr      x8, [x8, #0xed8]
0065D1620  ldr      x1, [x8]
0065D1624  add      x0, sp, #0x30
0065D1628  bl       #0x614f1fc ; Rock.Collections.OrderedDictionary.Enumerator<int, int>$$Dispose
0065D162C  cbz      x23, #0x65d15c0
0065D1630  mov      x0, x23
0065D1634  bl       #0x382bfb0 ; 
0065D1638  bl       #0x3442448 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CalSpecialMonsterCount
; RVA 0x65D0C70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D0C70  stp      x30, x23, [sp, #-0x30]!
0065D0C74  stp      x22, x21, [sp, #0x10]
0065D0C78  stp      x20, x19, [sp, #0x20]
0065D0C7C  adrp     x21, #0x9599000
0065D0C80  adrp     x22, #0x8f0a000
0065D0C84  ldrb     w8, [x21, #0x589]
0065D0C88  ldr      x22, [x22, #0x9a8]
0065D0C8C  mov      x20, x1
0065D0C90  mov      x19, x0
0065D0C94  tbnz     w8, #0, #0x65d0cd0
0065D0C98  adrp     x0, #0x8ee3000
0065D0C9C  ldr      x0, [x0, #0xfb0]
0065D0CA0  bl       #0x382bd14 ; 
0065D0CA4  adrp     x0, #0x8ee3000
0065D0CA8  ldr      x0, [x0, #0xfa8]
0065D0CAC  bl       #0x382bd14 ; 
0065D0CB0  adrp     x0, #0x8f09000
0065D0CB4  ldr      x0, [x0, #0xc08]
0065D0CB8  bl       #0x382bd14 ; 
0065D0CBC  adrp     x0, #0x8f0a000
0065D0CC0  ldr      x0, [x0, #0x9a8]
0065D0CC4  bl       #0x382bd14 ; 
0065D0CC8  mov      w8, #1
0065D0CCC  strb     w8, [x21, #0x589]
0065D0CD0  ldr      x2, [x22]
0065D0CD4  ldrb     w8, [x2, #0x53]
0065D0CD8  tbnz     w8, #5, #0x65d0d48
0065D0CDC  adrp     x8, #0x8ee3000
0065D0CE0  ldr      x8, [x8, #0xfa8]
0065D0CE4  adrp     x21, #0x8ee3000
0065D0CE8  ldr      x0, [x8]
0065D0CEC  ldr      x21, [x21, #0xfb0]
0065D0CF0  bl       #0x382bfa0 ; 
0065D0CF4  ldr      x1, [x21]
0065D0CF8  bl       #0x5e2737c ; System.Collections.Generic.Dictionary<int, int>$$.ctor
0065D0CFC  cbz      x20, #0x65d0eb8
0065D0D00  adrp     x21, #0x8f09000
0065D0D04  ldr      x8, [x20]
0065D0D08  ldr      x21, [x21, #0xc08]
0065D0D0C  ldrh     w9, [x8, #0x12e]
0065D0D10  ldr      x1, [x21]
0065D0D14  cbz      x9, #0x65d0d38
0065D0D18  ldr      x10, [x8, #0xb0]
0065D0D1C  add      x10, x10, #8
0065D0D20  ldur     x11, [x10, #-8]
0065D0D24  cmp      x11, x1
0065D0D28  b.eq     #0x65d0d64
0065D0D2C  subs     x9, x9, #1
0065D0D30  add      x10, x10, #0x10
0065D0D34  b.ne     #0x65d0d20
0065D0D38  mov      w2, #0xa
0065D0D3C  mov      x0, x20
0065D0D40  bl       #0x3a7e710 ; 
0065D0D44  b        #0x65d0d74 ; 
0065D0D48  ldr      x3, [x2, #0x60]
0065D0D4C  mov      x0, x19
0065D0D50  mov      x1, x20
0065D0D54  ldp      x20, x19, [sp, #0x20]
0065D0D58  ldp      x22, x21, [sp, #0x10]
0065D0D5C  ldp      x30, x23, [sp], #0x30
0065D0D60  br       x3
0065D0D64  ldr      w9, [x10]
0065D0D68  add      w9, w9, #0xa
0065D0D6C  add      x8, x8, w9, sxtw #4
0065D0D70  add      x0, x8, #0x138
0065D0D74  ldp      x8, x1, [x0]
0065D0D78  mov      x0, x20
0065D0D7C  blr      x8
0065D0D80  cbz      x0, #0x65d0eb8
0065D0D84  ldr      x8, [x0, #0x18]
0065D0D88  cbz      x8, #0x65d0dcc
0065D0D8C  ldr      x8, [x20]
0065D0D90  ldr      x1, [x21]
0065D0D94  ldrh     w9, [x8, #0x12e]
0065D0D98  cbz      x9, #0x65d0dbc
0065D0D9C  ldr      x10, [x8, #0xb0]
0065D0DA0  add      x10, x10, #8
0065D0DA4  ldur     x11, [x10, #-8]
0065D0DA8  cmp      x11, x1
0065D0DAC  b.eq     #0x65d0dd4
0065D0DB0  subs     x9, x9, #1
0065D0DB4  add      x10, x10, #0x10
0065D0DB8  b.ne     #0x65d0da4
0065D0DBC  mov      w2, #0xa
0065D0DC0  mov      x0, x20
0065D0DC4  bl       #0x3a7e710 ; 
0065D0DC8  b        #0x65d0de4 ; 
0065D0DCC  mov      w21, #1
0065D0DD0  b        #0x65d0e04 ; 
0065D0DD4  ldr      w9, [x10]
0065D0DD8  add      w9, w9, #0xa
0065D0DDC  add      x8, x8, w9, sxtw #4
0065D0DE0  add      x0, x8, #0x138
0065D0DE4  ldp      x8, x1, [x0]
0065D0DE8  mov      x0, x20
0065D0DEC  blr      x8
0065D0DF0  cbz      x0, #0x65d0eb8
0065D0DF4  ldr      w8, [x0, #0x18]
0065D0DF8  cbz      w8, #0x65d0ebc
0065D0DFC  ldr      x8, [x0, #0x20]
0065D0E00  lsr      x21, x8, #0x10
0065D0E04  mov      x0, x19
0065D0E08  mov      x1, x20
0065D0E0C  mov      w2, w21
0065D0E10  bl       #0x65d1854 ; HotFix.BattleLogic.WaterfallBattleManager$$CalTileSpecialMonsterCount
0065D0E14  mov      x22, x0
0065D0E18  mov      x0, x19
0065D0E1C  mov      x1, x20
0065D0E20  mov      w2, w21
0065D0E24  bl       #0x65d2244 ; HotFix.BattleLogic.WaterfallBattleManager$$CalPositionGroupSpecialMonsterCount
0065D0E28  mov      x23, x0
0065D0E2C  mov      x0, x19
0065D0E30  mov      x1, x20
0065D0E34  mov      w2, w21
0065D0E38  bl       #0x65d2d9c ; HotFix.BattleLogic.WaterfallBattleManager$$CalRandomMonster
0065D0E3C  cbz      x22, #0x65d0eb8
0065D0E40  cbz      x23, #0x65d0eb8
0065D0E44  cbz      x0, #0x65d0eb8
0065D0E48  ldr      w8, [x23, #0x14]
0065D0E4C  ldr      w9, [x22, #0x14]
0065D0E50  ldr      w10, [x0, #0x14]
0065D0E54  ldr      w11, [x19, #0x148]
0065D0E58  add      w8, w9, w8
0065D0E5C  add      w8, w8, w10
0065D0E60  madd     w8, w8, w21, w11
0065D0E64  str      w8, [x19, #0x148]
0065D0E68  ldr      w8, [x22, #0x10]
0065D0E6C  ldr      w9, [x23, #0x10]
0065D0E70  ldr      w10, [x0, #0x10]
0065D0E74  ldr      w11, [x19, #0x14c]
0065D0E78  add      w8, w9, w8
0065D0E7C  add      w8, w8, w10
0065D0E80  madd     w8, w8, w21, w11
0065D0E84  str      w8, [x19, #0x14c]
0065D0E88  ldr      w8, [x22, #0x18]
0065D0E8C  ldr      w9, [x23, #0x18]
0065D0E90  ldr      w10, [x0, #0x18]
0065D0E94  ldr      w11, [x19, #0x150]
0065D0E98  add      w8, w9, w8
0065D0E9C  add      w8, w8, w10
0065D0EA0  madd     w8, w8, w21, w11
0065D0EA4  str      w8, [x19, #0x150]
0065D0EA8  ldp      x20, x19, [sp, #0x20]
0065D0EAC  ldp      x22, x21, [sp, #0x10]
0065D0EB0  ldp      x30, x23, [sp], #0x30
0065D0EB4  ret      
0065D0EB8  bl       #0x382bfb8 ; 
0065D0EBC  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CalPositionGroupSpecialMonsterCount
; RVA 0x65D2244; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D2244  sub      sp, sp, #0x90
0065D2248  stp      x29, x30, [sp, #0x30]
0065D224C  stp      x28, x27, [sp, #0x40]
0065D2250  stp      x26, x25, [sp, #0x50]
0065D2254  stp      x24, x23, [sp, #0x60]
0065D2258  stp      x22, x21, [sp, #0x70]
0065D225C  stp      x20, x19, [sp, #0x80]
0065D2260  str      w2, [sp, #0x20]
0065D2264  adrp     x19, #0x9599000
0065D2268  adrp     x21, #0x8f0a000
0065D226C  ldrb     w8, [x19, #0x58a]
0065D2270  ldr      x21, [x21, #0xa28]
0065D2274  mov      x24, x1
0065D2278  mov      x20, x0
0065D227C  tbnz     w8, #0, #0x65d2360
0065D2280  adrp     x0, #0x8f0a000
0065D2284  ldr      x0, [x0, #0x9f8]
0065D2288  bl       #0x382bd14 ; 
0065D228C  adrp     x0, #0x8f0a000
0065D2290  ldr      x0, [x0, #0xa00]
0065D2294  bl       #0x382bd14 ; 
0065D2298  adrp     x0, #0x8f0a000
0065D229C  ldr      x0, [x0, #0xa08]
0065D22A0  bl       #0x382bd14 ; 
0065D22A4  adrp     x0, #0x8f09000
0065D22A8  ldr      x0, [x0, #0xc08]
0065D22AC  bl       #0x382bd14 ; 
0065D22B0  adrp     x0, #0x8f0a000
0065D22B4  ldr      x0, [x0, #0x930]
0065D22B8  bl       #0x382bd14 ; 
0065D22BC  adrp     x0, #0x8ee2000
0065D22C0  ldr      x0, [x0, #0xa58]
0065D22C4  bl       #0x382bd14 ; 
0065D22C8  adrp     x0, #0x8f0a000
0065D22CC  ldr      x0, [x0, #0xa30]
0065D22D0  bl       #0x382bd14 ; 
0065D22D4  adrp     x0, #0x8f0a000
0065D22D8  ldr      x0, [x0, #0xa38]
0065D22DC  bl       #0x382bd14 ; 
0065D22E0  adrp     x0, #0x8f0a000
0065D22E4  ldr      x0, [x0, #0x938]
0065D22E8  bl       #0x382bd14 ; 
0065D22EC  adrp     x0, #0x8f0a000
0065D22F0  ldr      x0, [x0, #0x940]
0065D22F4  bl       #0x382bd14 ; 
0065D22F8  adrp     x0, #0x8f0a000
0065D22FC  ldr      x0, [x0, #0xa40]
0065D2300  bl       #0x382bd14 ; 
0065D2304  adrp     x0, #0x8ee1000
0065D2308  ldr      x0, [x0, #0x6e8]
0065D230C  bl       #0x382bd14 ; 
0065D2310  adrp     x0, #0x8f0a000
0065D2314  ldr      x0, [x0, #0xa48]
0065D2318  bl       #0x382bd14 ; 
0065D231C  adrp     x0, #0x8f0a000
0065D2320  ldr      x0, [x0, #0xa28]
0065D2324  bl       #0x382bd14 ; 
0065D2328  adrp     x0, #0x8f0a000
0065D232C  ldr      x0, [x0, #0xa10]
0065D2330  bl       #0x382bd14 ; 
0065D2334  adrp     x0, #0x8f0a000
0065D2338  ldr      x0, [x0, #0x950]
0065D233C  bl       #0x382bd14 ; 
0065D2340  adrp     x0, #0x8f0a000
0065D2344  ldr      x0, [x0, #0x8b8]
0065D2348  bl       #0x382bd14 ; 
0065D234C  adrp     x0, #0x8f0a000
0065D2350  ldr      x0, [x0, #0xa50]
0065D2354  bl       #0x382bd14 ; 
0065D2358  mov      w8, #1
0065D235C  strb     w8, [x19, #0x58a]
0065D2360  ldr      x3, [x21]
0065D2364  ldrb     w8, [x3, #0x53]
0065D2368  tbnz     w8, #5, #0x65d23c8
0065D236C  adrp     x8, #0x8f0a000
0065D2370  ldr      x8, [x8, #0x9f8]
0065D2374  str      xzr, [sp, #0x28]
0065D2378  str      wzr, [sp, #0x24]
0065D237C  ldr      x0, [x8]
0065D2380  bl       #0x382bfa0 ; 
0065D2384  mov      x21, x0
0065D2388  bl       #0x65c7420 ; HotFix.BattleLogic.CalMonsterCountData$$.ctor
0065D238C  adrp     x19, #0x9599000
0065D2390  ldrb     w8, [x19, #0x286]
0065D2394  cbnz     w8, #0x65d23ac
0065D2398  adrp     x0, #0x8f07000
0065D239C  ldr      x0, [x0, #0xc98]
0065D23A0  bl       #0x382bd14 ; 
0065D23A4  mov      w8, #1
0065D23A8  strb     w8, [x19, #0x286]
0065D23AC  adrp     x8, #0x8f07000
0065D23B0  ldr      x8, [x8, #0xc98]
0065D23B4  ldr      x1, [x8]
0065D23B8  ldrb     w8, [x1, #0x53]
0065D23BC  tbnz     w8, #5, #0x65d23f8
0065D23C0  ldr      x22, [x20, #0x80]
0065D23C4  b        #0x65d2408 ; 
0065D23C8  ldr      x4, [x3, #0x60]
0065D23CC  mov      x0, x20
0065D23D0  mov      x1, x24
0065D23D4  ldr      w2, [sp, #0x20]
0065D23D8  ldp      x20, x19, [sp, #0x80]
0065D23DC  ldp      x22, x21, [sp, #0x70]
0065D23E0  ldp      x24, x23, [sp, #0x60]
0065D23E4  ldp      x26, x25, [sp, #0x50]
0065D23E8  ldp      x28, x27, [sp, #0x40]
0065D23EC  ldp      x29, x30, [sp, #0x30]
0065D23F0  add      sp, sp, #0x90
0065D23F4  br       x4
0065D23F8  ldr      x8, [x1, #0x60]
0065D23FC  mov      x0, x20
0065D2400  blr      x8
0065D2404  mov      x22, x0
0065D2408  cbz      x22, #0x65d2d94
0065D240C  adrp     x19, #0x9591000
0065D2410  ldrb     w8, [x19, #0xa9c]
0065D2414  cbnz     w8, #0x65d242c
0065D2418  adrp     x0, #0x8ee6000
0065D241C  ldr      x0, [x0, #0xaf0]
0065D2420  bl       #0x382bd14 ; 
0065D2424  mov      w8, #1
0065D2428  strb     w8, [x19, #0xa9c]
0065D242C  adrp     x8, #0x8ee6000
0065D2430  ldr      x8, [x8, #0xaf0]
0065D2434  ldr      x1, [x8]
0065D2438  ldrb     w8, [x1, #0x53]
0065D243C  tbnz     w8, #5, #0x65d244c
0065D2440  ldr      x8, [x22, #0x240]
0065D2444  str      x8, [sp, #0x10]
0065D2448  b        #0x65d245c ; 
0065D244C  ldr      x8, [x1, #0x60]
0065D2450  mov      x0, x22
0065D2454  blr      x8
0065D2458  str      x0, [sp, #0x10]
0065D245C  mov      x0, x20
0065D2460  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D2464  cbz      x24, #0x65d2d94
0065D2468  adrp     x19, #0x8f09000
0065D246C  ldr      x8, [x24]
0065D2470  ldr      x19, [x19, #0xc08]
0065D2474  mov      w23, w0
0065D2478  ldrh     w9, [x8, #0x12e]
0065D247C  ldr      x1, [x19]
0065D2480  cbz      x9, #0x65d24a4
0065D2484  ldr      x10, [x8, #0xb0]
0065D2488  add      x10, x10, #8
0065D248C  ldur     x11, [x10, #-8]
0065D2490  cmp      x11, x1
0065D2494  b.eq     #0x65d24b4
0065D2498  subs     x9, x9, #1
0065D249C  add      x10, x10, #0x10
0065D24A0  b.ne     #0x65d248c
0065D24A4  mov      x0, x24
0065D24A8  mov      w2, wzr
0065D24AC  bl       #0x3a7e710 ; 
0065D24B0  b        #0x65d24c0 ; 
0065D24B4  ldrsw    x9, [x10]
0065D24B8  add      x8, x8, x9, lsl #4
0065D24BC  add      x0, x8, #0x138
0065D24C0  ldp      x8, x1, [x0]
0065D24C4  mov      x0, x24
0065D24C8  blr      x8
0065D24CC  ldr      x8, [x20, #0x1f0]
0065D24D0  cbz      x8, #0x65d2d94
0065D24D4  adrp     x9, #0x8f0a000
0065D24D8  ldr      x9, [x9, #0xa08]
0065D24DC  mov      w22, w0
0065D24E0  add      x2, sp, #0x28
0065D24E4  mov      x0, x8
0065D24E8  ldr      x3, [x9]
0065D24EC  mov      w1, w22
0065D24F0  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
0065D24F4  tbnz     w0, #0, #0x65d2534
0065D24F8  adrp     x8, #0x8f0a000
0065D24FC  ldr      x8, [x8, #0xa10]
0065D2500  ldr      x0, [x8]
0065D2504  bl       #0x382bfa0 ; 
0065D2508  mov      x25, x0
0065D250C  bl       #0x65c74f0 ; HotFix.BattleLogic.WaveMissionRandomData$$.ctor
0065D2510  str      x25, [sp, #0x28]
0065D2514  ldr      x0, [x20, #0x1f0]
0065D2518  cbz      x0, #0x65d2d94
0065D251C  adrp     x8, #0x8f0a000
0065D2520  ldr      x8, [x8, #0xa00]
0065D2524  mov      w1, w22
0065D2528  mov      x2, x25
0065D252C  ldr      x3, [x8]
0065D2530  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
0065D2534  ldr      x8, [x24]
0065D2538  ldr      x1, [x19]
0065D253C  ldrh     w9, [x8, #0x12e]
0065D2540  cbz      x9, #0x65d2564
0065D2544  ldr      x10, [x8, #0xb0]
0065D2548  add      x10, x10, #8
0065D254C  ldur     x11, [x10, #-8]
0065D2550  cmp      x11, x1
0065D2554  b.eq     #0x65d2574
0065D2558  subs     x9, x9, #1
0065D255C  add      x10, x10, #0x10
0065D2560  b.ne     #0x65d254c
0065D2564  mov      w2, #0x14
0065D2568  mov      x0, x24
0065D256C  bl       #0x3a7e710 ; 
0065D2570  b        #0x65d2584 ; 
0065D2574  ldr      w9, [x10]
0065D2578  add      w9, w9, #0x14
0065D257C  add      x8, x8, w9, sxtw #4
0065D2580  add      x0, x8, #0x138
0065D2584  ldp      x8, x1, [x0]
0065D2588  mov      x0, x24
0065D258C  blr      x8
0065D2590  cbz      x0, #0x65d2d94
0065D2594  ldr      w24, [x0, #0x18]
0065D2598  mov      x22, x0
0065D259C  cmp      w24, #1
0065D25A0  b.lt     #0x65d2d70
0065D25A4  adrp     x8, #0x9599000
0065D25A8  ldrb     w8, [x8, #0x286]
0065D25AC  cbnz     w8, #0x65d25c8
0065D25B0  adrp     x0, #0x8f07000
0065D25B4  ldr      x0, [x0, #0xc98]
0065D25B8  bl       #0x382bd14 ; 
0065D25BC  mov      w8, #1
0065D25C0  adrp     x9, #0x9599000
0065D25C4  strb     w8, [x9, #0x286]
0065D25C8  adrp     x8, #0x8f07000
0065D25CC  ldr      x8, [x8, #0xc98]
0065D25D0  ldr      x1, [x8]
0065D25D4  ldrb     w8, [x1, #0x53]
0065D25D8  tbnz     w8, #5, #0x65d25e4
0065D25DC  ldr      x0, [x20, #0x80]
0065D25E0  b        #0x65d25f0 ; 
0065D25E4  ldr      x8, [x1, #0x60]
0065D25E8  mov      x0, x20
0065D25EC  blr      x8
0065D25F0  cbz      x0, #0x65d2d94
0065D25F4  mov      w1, wzr
0065D25F8  mov      w2, w24
0065D25FC  mov      x3, xzr
0065D2600  bl       #0x54b65d8 ; 
0065D2604  ldr      x8, [sp, #0x28]
0065D2608  cbz      x8, #0x65d2d94
0065D260C  str      w0, [x8, #0x18]
0065D2610  adrp     x8, #0x9599000
0065D2614  ldrb     w8, [x8, #0x286]
0065D2618  mov      w25, w0
0065D261C  cbnz     w8, #0x65d2638
0065D2620  adrp     x0, #0x8f07000
0065D2624  ldr      x0, [x0, #0xc98]
0065D2628  bl       #0x382bd14 ; 
0065D262C  mov      w8, #1
0065D2630  adrp     x9, #0x9599000
0065D2634  strb     w8, [x9, #0x286]
0065D2638  adrp     x8, #0x8f07000
0065D263C  ldr      x8, [x8, #0xc98]
0065D2640  ldr      x1, [x8]
0065D2644  ldrb     w8, [x1, #0x53]
0065D2648  tbnz     w8, #5, #0x65d2654
0065D264C  ldr      x26, [x20, #0x80]
0065D2650  b        #0x65d2664 ; 
0065D2654  ldr      x8, [x1, #0x60]
0065D2658  mov      x0, x20
0065D265C  blr      x8
0065D2660  mov      x26, x0
0065D2664  cbz      x26, #0x65d2d94
0065D2668  adrp     x8, #0x9598000
0065D266C  ldrb     w8, [x8, #0xfcc]
0065D2670  cbnz     w8, #0x65d268c
0065D2674  adrp     x0, #0x8f06000
0065D2678  ldr      x0, [x0, #0x470]
0065D267C  bl       #0x382bd14 ; 
0065D2680  mov      w8, #1
0065D2684  adrp     x9, #0x9598000
0065D2688  strb     w8, [x9, #0xfcc]
0065D268C  adrp     x8, #0x8f06000
0065D2690  ldr      x8, [x8, #0x470]
0065D2694  ldr      x1, [x8]
0065D2698  ldrb     w8, [x1, #0x53]
0065D269C  tbnz     w8, #5, #0x65d26a8
0065D26A0  ldr      x0, [x26, #0x200]
0065D26A4  b        #0x65d26b4 ; 
0065D26A8  ldr      x8, [x1, #0x60]
0065D26AC  mov      x0, x26
0065D26B0  blr      x8
0065D26B4  ldr      w8, [x22, #0x18]
0065D26B8  cmp      w25, w8
0065D26BC  b.hs     #0x65d2d98
0065D26C0  cbz      x0, #0x65d2d94
0065D26C4  add      x8, x22, w25, sxtw #2
0065D26C8  ldr      w1, [x8, #0x20]
0065D26CC  mov      x2, xzr
0065D26D0  bl       #0x64d8fd4 ; LocalModels.LocalModelManager$$GetMission_PositionGroupMonsterFlushConfig
0065D26D4  cbz      x0, #0x65d2d94
0065D26D8  adrp     x19, #0x9599000
0065D26DC  ldrb     w8, [x19, #0x65c]
0065D26E0  mov      x22, x0
0065D26E4  cbnz     w8, #0x65d26fc
0065D26E8  adrp     x0, #0x8f0a000
0065D26EC  ldr      x0, [x0, #0x968]
0065D26F0  bl       #0x382bd14 ; 
0065D26F4  mov      w8, #1
0065D26F8  strb     w8, [x19, #0x65c]
0065D26FC  adrp     x8, #0x8f0a000
0065D2700  ldr      x8, [x8, #0x968]
0065D2704  ldr      x1, [x8]
0065D2708  ldrb     w8, [x1, #0x53]
0065D270C  tbnz     w8, #5, #0x65d2718
0065D2710  ldr      x22, [x22, #0x28]
0065D2714  b        #0x65d2728 ; 
0065D2718  ldr      x8, [x1, #0x60]
0065D271C  mov      x0, x22
0065D2720  blr      x8
0065D2724  mov      x22, x0
0065D2728  adrp     x8, #0x8ee2000
0065D272C  ldr      x8, [x8, #0xa58]
0065D2730  ldr      x0, [x8]
0065D2734  ldr      w8, [x0, #0xe0]
0065D2738  cbnz     w8, #0x65d2740
0065D273C  bl       #0x382be8c ; 
0065D2740  adrp     x8, #0x8f0a000
0065D2744  ldr      x8, [x8, #0x930]
0065D2748  mov      x0, x22
0065D274C  ldr      x1, [x8]
0065D2750  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
0065D2754  ldr      x8, [sp, #0x28]
0065D2758  cbz      x8, #0x65d2d94
0065D275C  ldr      x19, [x8, #0x20]
0065D2760  mov      x22, x0
0065D2764  cbnz     x19, #0x65d27a0
0065D2768  adrp     x8, #0x8f0a000
0065D276C  ldr      x8, [x8, #0xa40]
0065D2770  ldr      x0, [x8]
0065D2774  bl       #0x382bfa0 ; 
0065D2778  adrp     x8, #0x8f0a000
0065D277C  ldr      x8, [x8, #0xa38]
0065D2780  mov      x19, x0
0065D2784  ldr      x1, [x8]
0065D2788  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0065D278C  ldr      x0, [sp, #0x28]
0065D2790  cbz      x0, #0x65d2d94
0065D2794  str      x19, [x0, #0x20]!
0065D2798  mov      x1, x19
0065D279C  bl       #0x382bcb8 ; 
0065D27A0  str      x19, [sp, #8]
0065D27A4  cbz      x22, #0x65d2d94
0065D27A8  ldr      w8, [x22, #0x18]
0065D27AC  cmp      w8, #1
0065D27B0  b.lt     #0x65d2d70
0065D27B4  adrp     x26, #0x8f0a000
0065D27B8  adrp     x29, #0x8ee6000
0065D27BC  adrp     x28, #0x8f0a000
0065D27C0  ldr      x26, [x26, #0x940]
0065D27C4  ldr      x29, [x29, #0x290]
0065D27C8  ldr      x28, [x28, #0xa20]
0065D27CC  mov      w25, wzr
0065D27D0  mov      w19, #1
0065D27D4  adrp     x24, #0x9591000
0065D27D8  adrp     x27, #0x9599000
0065D27DC  and      w8, w23, #1
0065D27E0  str      w8, [sp, #0x1c]
0065D27E4  str      x22, [sp]
0065D27E8  ldr      x2, [x26]
0065D27EC  mov      x0, x22
0065D27F0  mov      w1, w25
0065D27F4  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065D27F8  cbz      x0, #0x65d2d94
0065D27FC  ldr      w8, [x0, #0x10]
0065D2800  ldr      x2, [x26]
0065D2804  mov      x0, x22
0065D2808  mov      w1, w25
0065D280C  str      w8, [sp, #0x24]
0065D2810  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065D2814  adrp     x23, #0x9599000
0065D2818  cbz      x0, #0x65d2d94
0065D281C  ldrb     w8, [x23, #0x286]
0065D2820  ldr      x26, [x0, #0x18]
0065D2824  cbnz     w8, #0x65d2838
0065D2828  adrp     x0, #0x8f07000
0065D282C  ldr      x0, [x0, #0xc98]
0065D2830  bl       #0x382bd14 ; 
0065D2834  strb     w19, [x23, #0x286]
0065D2838  adrp     x8, #0x8f07000
0065D283C  ldr      x8, [x8, #0xc98]
0065D2840  ldr      x1, [x8]
0065D2844  ldrb     w8, [x1, #0x53]
0065D2848  tbnz     w8, #5, #0x65d2854
0065D284C  ldr      x0, [x20, #0x80]
0065D2850  b        #0x65d2860 ; 
0065D2854  ldr      x8, [x1, #0x60]
0065D2858  mov      x0, x20
0065D285C  blr      x8
0065D2860  cbz      x26, #0x65d2d94
0065D2864  str      w25, [sp, #0x18]
0065D2868  cbz      x0, #0x65d2d94
0065D286C  ldr      w2, [x26, #0x18]
0065D2870  mov      w1, wzr
0065D2874  mov      x3, xzr
0065D2878  bl       #0x54b65d8 ; 
0065D287C  adrp     x8, #0x8f0a000
0065D2880  ldr      x8, [x8, #0xa48]
0065D2884  mov      w25, w0
0065D2888  ldr      x8, [x8]
0065D288C  mov      x0, x8
0065D2890  bl       #0x382bfa0 ; 
0065D2894  mov      x22, x0
0065D2898  bl       #0x65c7488 ; HotFix.BattleLogic.MissionPositionGroupMonsterRandomData$$.ctor
0065D289C  ldr      x12, [sp, #8]
0065D28A0  cbz      x12, #0x65d2d94
0065D28A4  adrp     x9, #0x8f0a000
0065D28A8  ldr      w10, [x12, #0x1c]
0065D28AC  ldr      x8, [x12, #0x10]
0065D28B0  ldr      x9, [x9, #0xa30]
0065D28B4  add      w10, w10, #1
0065D28B8  ldr      x9, [x9]
0065D28BC  str      w10, [x12, #0x1c]
0065D28C0  cbz      x8, #0x65d2d94
0065D28C4  ldrsw    x10, [x12, #0x18]
0065D28C8  ldr      w11, [x8, #0x18]
0065D28CC  cmp      w10, w11
0065D28D0  b.hs     #0x65d28f0
0065D28D4  add      w9, w10, #1
0065D28D8  add      x0, x8, x10, lsl #3
0065D28DC  str      w9, [x12, #0x18]
0065D28E0  str      x22, [x0, #0x20]!
0065D28E4  mov      x1, x22
0065D28E8  bl       #0x382bcb8 ; 
0065D28EC  b        #0x65d2908 ; 
0065D28F0  ldr      x8, [x9, #0x20]
0065D28F4  mov      x0, x12
0065D28F8  mov      x1, x22
0065D28FC  ldr      x8, [x8, #0xc0]
0065D2900  ldr      x2, [x8, #0x70]
0065D2904  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0065D2908  cbz      x22, #0x65d2d94
0065D290C  str      w25, [x22, #0x14]
0065D2910  ldr      w8, [x26, #0x18]
0065D2914  cmp      w25, w8
0065D2918  b.hs     #0x65d2d98
0065D291C  add      x8, x26, w25, sxtw #2
0065D2920  ldrb     w9, [x23, #0x286]
0065D2924  ldr      w25, [x8, #0x20]
0065D2928  cbnz     w9, #0x65d293c
0065D292C  adrp     x0, #0x8f07000
0065D2930  ldr      x0, [x0, #0xc98]
0065D2934  bl       #0x382bd14 ; 
0065D2938  strb     w19, [x23, #0x286]
0065D293C  adrp     x8, #0x8f07000
0065D2940  ldr      x8, [x8, #0xc98]
0065D2944  ldr      x1, [x8]
0065D2948  ldrb     w8, [x1, #0x53]
0065D294C  tbnz     w8, #5, #0x65d2958
0065D2950  ldr      x26, [x20, #0x80]
0065D2954  b        #0x65d2968 ; 
0065D2958  ldr      x8, [x1, #0x60]
0065D295C  mov      x0, x20
0065D2960  blr      x8
0065D2964  mov      x26, x0
0065D2968  cbz      x26, #0x65d2d94
0065D296C  adrp     x8, #0x9598000
0065D2970  ldrb     w8, [x8, #0xfcc]
0065D2974  cbnz     w8, #0x65d298c
0065D2978  adrp     x0, #0x8f06000
0065D297C  ldr      x0, [x0, #0x470]
0065D2980  bl       #0x382bd14 ; 
0065D2984  adrp     x8, #0x9598000
0065D2988  strb     w19, [x8, #0xfcc]
0065D298C  adrp     x8, #0x8f06000
0065D2990  ldr      x8, [x8, #0x470]
0065D2994  ldr      x1, [x8]
0065D2998  ldrb     w8, [x1, #0x53]
0065D299C  tbnz     w8, #5, #0x65d29a8
0065D29A0  ldr      x0, [x26, #0x200]
0065D29A4  b        #0x65d29b4 ; 
0065D29A8  ldr      x8, [x1, #0x60]
0065D29AC  mov      x0, x26
0065D29B0  blr      x8
0065D29B4  cbz      x0, #0x65d2d94
0065D29B8  ldr      w1, [sp, #0x24]
0065D29BC  mov      x2, xzr
0065D29C0  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065D29C4  cbz      x0, #0x65d2d00
0065D29C8  adrp     x8, #0x9599000
0065D29CC  ldrb     w8, [x8, #0x657]
0065D29D0  mov      x26, x0
0065D29D4  cbnz     w8, #0x65d29ec
0065D29D8  adrp     x0, #0x8f0a000
0065D29DC  ldr      x0, [x0, #0x8d0]
0065D29E0  bl       #0x382bd14 ; 
0065D29E4  adrp     x8, #0x9599000
0065D29E8  strb     w19, [x8, #0x657]
0065D29EC  adrp     x8, #0x8f0a000
0065D29F0  ldr      x8, [x8, #0x8d0]
0065D29F4  ldr      x1, [x8]
0065D29F8  ldrb     w8, [x1, #0x53]
0065D29FC  tbnz     w8, #5, #0x65d2a08
0065D2A00  ldr      x0, [x26, #0x28]
0065D2A04  b        #0x65d2a14 ; 
0065D2A08  ldr      x8, [x1, #0x60]
0065D2A0C  mov      x0, x26
0065D2A10  blr      x8
0065D2A14  cbz      x0, #0x65d2d94
0065D2A18  ldr      w8, [x0, #0x18]
0065D2A1C  cmp      w8, #1
0065D2A20  b.lt     #0x65d2cdc
0065D2A24  adrp     x8, #0x9599000
0065D2A28  ldrb     w8, [x8, #0x657]
0065D2A2C  cbnz     w8, #0x65d2a44
0065D2A30  adrp     x0, #0x8f0a000
0065D2A34  ldr      x0, [x0, #0x8d0]
0065D2A38  bl       #0x382bd14 ; 
0065D2A3C  adrp     x8, #0x9599000
0065D2A40  strb     w19, [x8, #0x657]
0065D2A44  adrp     x8, #0x8f0a000
0065D2A48  ldr      x8, [x8, #0x8d0]
0065D2A4C  ldr      x1, [x8]
0065D2A50  ldrb     w8, [x1, #0x53]
0065D2A54  tbnz     w8, #5, #0x65d2a60
0065D2A58  ldr      x1, [x26, #0x28]
0065D2A5C  b        #0x65d2a70 ; 
0065D2A60  ldr      x8, [x1, #0x60]
0065D2A64  mov      x0, x26
0065D2A68  blr      x8
0065D2A6C  mov      x1, x0
0065D2A70  ldr      x0, [sp, #0x10]
0065D2A74  cbz      x0, #0x65d2d94
0065D2A78  mov      x2, xzr
0065D2A7C  bl       #0x6903320 ; HotFix.BattleLogic.MapManager$$WaterfallRandomMap
0065D2A80  str      w0, [x22, #0x10]
0065D2A84  adrp     x8, #0x9599000
0065D2A88  ldrb     w8, [x8, #0x26f]
0065D2A8C  mov      w26, w0
0065D2A90  cbnz     w8, #0x65d2aa8
0065D2A94  adrp     x0, #0x8f06000
0065D2A98  ldr      x0, [x0, #0xd58]
0065D2A9C  bl       #0x382bd14 ; 
0065D2AA0  adrp     x8, #0x9599000
0065D2AA4  strb     w19, [x8, #0x26f]
0065D2AA8  adrp     x8, #0x8f06000
0065D2AAC  ldr      x8, [x8, #0xd58]
0065D2AB0  ldr      x1, [x8]
0065D2AB4  ldrb     w8, [x1, #0x53]
0065D2AB8  tbnz     w8, #5, #0x65d2ac8
0065D2ABC  ldr      x8, [sp, #0x10]
0065D2AC0  ldr      x0, [x8, #0x20]
0065D2AC4  b        #0x65d2ad4 ; 
0065D2AC8  ldr      x8, [x1, #0x60]
0065D2ACC  ldr      x0, [sp, #0x10]
0065D2AD0  blr      x8
0065D2AD4  cbz      x0, #0x65d2d94
0065D2AD8  ldr      x8, [x0, #0x140]
0065D2ADC  cbz      x8, #0x65d2d94
0065D2AE0  ldr      w9, [x8, #0x18]
0065D2AE4  cmp      w26, w9
0065D2AE8  b.hs     #0x65d2d98
0065D2AEC  add      x8, x8, w26, sxtw #4
0065D2AF0  ldr      x8, [x8, #0x28]
0065D2AF4  cbz      x8, #0x65d2d94
0065D2AF8  ldr      w26, [x8, #0x18]
0065D2AFC  cmp      w26, #1
0065D2B00  b.lt     #0x65d2cdc
0065D2B04  ldrb     w8, [x23, #0x286]
0065D2B08  cbnz     w8, #0x65d2b1c
0065D2B0C  adrp     x0, #0x8f07000
0065D2B10  ldr      x0, [x0, #0xc98]
0065D2B14  bl       #0x382bd14 ; 
0065D2B18  strb     w19, [x23, #0x286]
0065D2B1C  adrp     x8, #0x8f07000
0065D2B20  ldr      x8, [x8, #0xc98]
0065D2B24  ldr      x1, [x8]
0065D2B28  ldrb     w8, [x1, #0x53]
0065D2B2C  tbnz     w8, #5, #0x65d2b38
0065D2B30  ldr      x22, [x20, #0x80]
0065D2B34  b        #0x65d2b48 ; 
0065D2B38  ldr      x8, [x1, #0x60]
0065D2B3C  mov      x0, x20
0065D2B40  blr      x8
0065D2B44  mov      x22, x0
0065D2B48  cbz      x22, #0x65d2d94
0065D2B4C  adrp     x8, #0x9598000
0065D2B50  ldrb     w8, [x8, #0xfcc]
0065D2B54  cbnz     w8, #0x65d2b6c
0065D2B58  adrp     x0, #0x8f06000
0065D2B5C  ldr      x0, [x0, #0x470]
0065D2B60  bl       #0x382bd14 ; 
0065D2B64  adrp     x8, #0x9598000
0065D2B68  strb     w19, [x8, #0xfcc]
0065D2B6C  adrp     x8, #0x8f06000
0065D2B70  ldr      x8, [x8, #0x470]
0065D2B74  ldr      x1, [x8]
0065D2B78  ldrb     w8, [x1, #0x53]
0065D2B7C  tbnz     w8, #5, #0x65d2b88
0065D2B80  ldr      x0, [x22, #0x200]
0065D2B84  b        #0x65d2b94 ; 
0065D2B88  ldr      x8, [x1, #0x60]
0065D2B8C  mov      x0, x22
0065D2B90  blr      x8
0065D2B94  cbz      x0, #0x65d2d94
0065D2B98  mov      w1, w25
0065D2B9C  mov      x2, xzr
0065D2BA0  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D2BA4  cbz      x0, #0x65d2d94
0065D2BA8  ldrb     w8, [x24, #0xa75]
0065D2BAC  mov      x22, x0
0065D2BB0  cbnz     w8, #0x65d2bc0
0065D2BB4  mov      x0, x29
0065D2BB8  bl       #0x382bd14 ; 
0065D2BBC  strb     w19, [x24, #0xa75]
0065D2BC0  ldr      x1, [x29]
0065D2BC4  ldrb     w8, [x1, #0x53]
0065D2BC8  tbnz     w8, #5, #0x65d2bd4
0065D2BCC  ldr      w0, [x22, #0x24]
0065D2BD0  b        #0x65d2be0 ; 
0065D2BD4  ldr      x8, [x1, #0x60]
0065D2BD8  mov      x0, x22
0065D2BDC  blr      x8
0065D2BE0  cmp      w0, #0xc9
0065D2BE4  b.eq     #0x65d2c24
0065D2BE8  ldrb     w8, [x24, #0xa75]
0065D2BEC  cbnz     w8, #0x65d2bfc
0065D2BF0  mov      x0, x29
0065D2BF4  bl       #0x382bd14 ; 
0065D2BF8  strb     w19, [x24, #0xa75]
0065D2BFC  ldr      x1, [x29]
0065D2C00  ldrb     w8, [x1, #0x53]
0065D2C04  tbnz     w8, #5, #0x65d2c10
0065D2C08  ldr      w0, [x22, #0x24]
0065D2C0C  b        #0x65d2c1c ; 
0065D2C10  ldr      x8, [x1, #0x60]
0065D2C14  mov      x0, x22
0065D2C18  blr      x8
0065D2C1C  cmp      w0, #3
0065D2C20  b.ne     #0x65d2c34
0065D2C24  cbz      x21, #0x65d2d94
0065D2C28  ldr      w8, [x21, #0x14]
0065D2C2C  add      w8, w8, #1
0065D2C30  str      w8, [x21, #0x14]
0065D2C34  ldrb     w8, [x27, #0x65d]
0065D2C38  cbnz     w8, #0x65d2c48
0065D2C3C  mov      x0, x28
0065D2C40  bl       #0x382bd14 ; 
0065D2C44  strb     w19, [x27, #0x65d]
0065D2C48  ldr      x1, [x28]
0065D2C4C  ldrb     w8, [x1, #0x53]
0065D2C50  tbnz     w8, #5, #0x65d2c5c
0065D2C54  ldr      w0, [x22, #0x24c]
0065D2C58  b        #0x65d2c68 ; 
0065D2C5C  ldr      x8, [x1, #0x60]
0065D2C60  mov      x0, x22
0065D2C64  blr      x8
0065D2C68  cmp      w0, #1
0065D2C6C  b.lt     #0x65d2cc4
0065D2C70  cbz      x21, #0x65d2d94
0065D2C74  ldr      w8, [x21, #0x10]
0065D2C78  ldr      w23, [x21, #0x18]
0065D2C7C  add      w8, w8, #1
0065D2C80  str      w8, [x21, #0x10]
0065D2C84  ldrb     w8, [x27, #0x65d]
0065D2C88  cbnz     w8, #0x65d2c98
0065D2C8C  mov      x0, x28
0065D2C90  bl       #0x382bd14 ; 
0065D2C94  strb     w19, [x27, #0x65d]
0065D2C98  ldr      x1, [x28]
0065D2C9C  ldrb     w8, [x1, #0x53]
0065D2CA0  tbnz     w8, #5, #0x65d2cac
0065D2CA4  ldr      w0, [x22, #0x24c]
0065D2CA8  b        #0x65d2cb8 ; 
0065D2CAC  ldr      x8, [x1, #0x60]
0065D2CB0  mov      x0, x22
0065D2CB4  blr      x8
0065D2CB8  add      w8, w0, w23
0065D2CBC  adrp     x23, #0x9599000
0065D2CC0  str      w8, [x21, #0x18]
0065D2CC4  ldp      w2, w3, [sp, #0x1c]
0065D2CC8  mov      x0, x20
0065D2CCC  mov      x1, x22
0065D2CD0  bl       #0x65d3844 ; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
0065D2CD4  subs     w26, w26, #1
0065D2CD8  b.ne     #0x65d2b04
0065D2CDC  ldr      x22, [sp]
0065D2CE0  ldr      w25, [sp, #0x18]
0065D2CE4  adrp     x26, #0x8f0a000
0065D2CE8  ldr      w8, [x22, #0x18]
0065D2CEC  ldr      x26, [x26, #0x940]
0065D2CF0  add      w25, w25, #1
0065D2CF4  cmp      w25, w8
0065D2CF8  b.lt     #0x65d27e8
0065D2CFC  b        #0x65d2d70 ; 
0065D2D00  add      x0, sp, #0x24
0065D2D04  mov      x1, xzr
0065D2D08  bl       #0x7bd22a0 ; System.Int32$$ToString
0065D2D0C  adrp     x8, #0x8f0a000
0065D2D10  ldr      x8, [x8, #0x950]
0065D2D14  mov      x1, x0
0065D2D18  mov      x2, xzr
0065D2D1C  ldr      x8, [x8]
0065D2D20  mov      x0, x8
0065D2D24  bl       #0x79d469c ; System.String$$Concat
0065D2D28  adrp     x8, #0x8ee1000
0065D2D2C  ldr      x8, [x8, #0x6e8]
0065D2D30  mov      x19, x0
0065D2D34  ldr      x8, [x8]
0065D2D38  ldr      w9, [x8, #0xe0]
0065D2D3C  cbnz     w9, #0x65d2d48
0065D2D40  mov      x0, x8
0065D2D44  bl       #0x382be8c ; 
0065D2D48  adrp     x8, #0x8f0a000
0065D2D4C  adrp     x9, #0x8f0a000
0065D2D50  ldr      x8, [x8, #0xa50]
0065D2D54  ldr      x9, [x9, #0x8b8]
0065D2D58  mov      w3, #0x42c
0065D2D5C  mov      x0, x19
0065D2D60  ldr      x1, [x8]
0065D2D64  ldr      x2, [x9]
0065D2D68  mov      x4, xzr
0065D2D6C  bl       #0x7997754 ; Logger$$LogError
0065D2D70  mov      x0, x21
0065D2D74  ldp      x20, x19, [sp, #0x80]
0065D2D78  ldp      x22, x21, [sp, #0x70]
0065D2D7C  ldp      x24, x23, [sp, #0x60]
0065D2D80  ldp      x26, x25, [sp, #0x50]
0065D2D84  ldp      x28, x27, [sp, #0x40]
0065D2D88  ldp      x29, x30, [sp, #0x30]
0065D2D8C  add      sp, sp, #0x90
0065D2D90  ret      
0065D2D94  bl       #0x382bfb8 ; 
0065D2D98  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
; RVA 0x65D3844; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D3844  str      x30, [sp, #-0x40]!
0065D3848  stp      x24, x23, [sp, #0x10]
0065D384C  stp      x22, x21, [sp, #0x20]
0065D3850  stp      x20, x19, [sp, #0x30]
0065D3854  adrp     x22, #0x9599000
0065D3858  adrp     x24, #0x8f0a000
0065D385C  ldrb     w8, [x22, #0x58b]
0065D3860  ldr      x24, [x24, #0xa78]
0065D3864  mov      w19, w3
0065D3868  mov      w23, w2
0065D386C  mov      x21, x1
0065D3870  mov      x20, x0
0065D3874  tbnz     w8, #0, #0x65d38b0
0065D3878  adrp     x0, #0x8f0a000
0065D387C  ldr      x0, [x0, #0x9b8]
0065D3880  bl       #0x382bd14 ; 
0065D3884  adrp     x0, #0x8f09000
0065D3888  ldr      x0, [x0, #0xa20]
0065D388C  bl       #0x382bd14 ; 
0065D3890  adrp     x0, #0x8f09000
0065D3894  ldr      x0, [x0, #0xa08]
0065D3898  bl       #0x382bd14 ; 
0065D389C  adrp     x0, #0x8f0a000
0065D38A0  ldr      x0, [x0, #0xa78]
0065D38A4  bl       #0x382bd14 ; 
0065D38A8  mov      w8, #1
0065D38AC  strb     w8, [x22, #0x58b]
0065D38B0  ldr      x4, [x24]
0065D38B4  ldrb     w8, [x4, #0x53]
0065D38B8  tbnz     w8, #5, #0x65d3900
0065D38BC  cbz      x21, #0x65d3a74
0065D38C0  adrp     x22, #0x9599000
0065D38C4  ldrb     w8, [x22, #0x4ec]
0065D38C8  cbnz     w8, #0x65d38e0
0065D38CC  adrp     x0, #0x8f09000
0065D38D0  ldr      x0, [x0, #0xfc8]
0065D38D4  bl       #0x382bd14 ; 
0065D38D8  mov      w8, #1
0065D38DC  strb     w8, [x22, #0x4ec]
0065D38E0  adrp     x8, #0x8f09000
0065D38E4  ldr      x8, [x8, #0xfc8]
0065D38E8  ldr      x1, [x8]
0065D38EC  ldrb     w8, [x1, #0x53]
0065D38F0  tbnz     w8, #5, #0x65d3928
0065D38F4  ldr      w22, [x21, #0x268]
0065D38F8  cbnz     w22, #0x65d393c
0065D38FC  b        #0x65d3a60 ; 
0065D3900  ldr      x5, [x4, #0x60]
0065D3904  and      w2, w23, #1
0065D3908  mov      x0, x20
0065D390C  mov      x1, x21
0065D3910  mov      w3, w19
0065D3914  ldp      x20, x19, [sp, #0x30]
0065D3918  ldp      x22, x21, [sp, #0x20]
0065D391C  ldp      x24, x23, [sp, #0x10]
0065D3920  ldr      x30, [sp], #0x40
0065D3924  br       x5
0065D3928  ldr      x8, [x1, #0x60]
0065D392C  mov      x0, x21
0065D3930  blr      x8
0065D3934  mov      w22, w0
0065D3938  cbz      w22, #0x65d3a60
0065D393C  tbz      w23, #0, #0x65d39d4
0065D3940  adrp     x23, #0x9591000
0065D3944  ldrb     w8, [x23, #0xa75]
0065D3948  cbnz     w8, #0x65d3960
0065D394C  adrp     x0, #0x8ee6000
0065D3950  ldr      x0, [x0, #0x290]
0065D3954  bl       #0x382bd14 ; 
0065D3958  mov      w8, #1
0065D395C  strb     w8, [x23, #0xa75]
0065D3960  adrp     x24, #0x8ee6000
0065D3964  ldr      x24, [x24, #0x290]
0065D3968  ldr      x1, [x24]
0065D396C  ldrb     w8, [x1, #0x53]
0065D3970  tbnz     w8, #5, #0x65d397c
0065D3974  ldr      w0, [x21, #0x24]
0065D3978  b        #0x65d3988 ; 
0065D397C  ldr      x8, [x1, #0x60]
0065D3980  mov      x0, x21
0065D3984  blr      x8
0065D3988  cmp      w0, #0xc9
0065D398C  b.eq     #0x65d39d4
0065D3990  ldrb     w8, [x23, #0xa75]
0065D3994  cbnz     w8, #0x65d39ac
0065D3998  adrp     x0, #0x8ee6000
0065D399C  ldr      x0, [x0, #0x290]
0065D39A0  bl       #0x382bd14 ; 
0065D39A4  mov      w8, #1
0065D39A8  strb     w8, [x23, #0xa75]
0065D39AC  ldr      x1, [x24]
0065D39B0  ldrb     w8, [x1, #0x53]
0065D39B4  tbnz     w8, #5, #0x65d39c0
0065D39B8  ldr      w0, [x21, #0x24]
0065D39BC  b        #0x65d39cc ; 
0065D39C0  ldr      x8, [x1, #0x60]
0065D39C4  mov      x0, x21
0065D39C8  blr      x8
0065D39CC  cmp      w0, #3
0065D39D0  b.ne     #0x65d3a60
0065D39D4  ldr      x0, [x20, #0x168]
0065D39D8  cbz      x0, #0x65d3a74
0065D39DC  adrp     x8, #0x8f0a000
0065D39E0  ldr      x8, [x8, #0x9b8]
0065D39E4  mov      w1, w22
0065D39E8  ldr      x2, [x8]
0065D39EC  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
0065D39F0  tbnz     w0, #0, #0x65d3a14
0065D39F4  ldr      x0, [x20, #0x168]
0065D39F8  cbz      x0, #0x65d3a74
0065D39FC  adrp     x8, #0x8f09000
0065D3A00  ldr      x8, [x8, #0xa08]
0065D3A04  mov      w1, w22
0065D3A08  mov      w2, wzr
0065D3A0C  ldr      x3, [x8]
0065D3A10  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
0065D3A14  ldr      x20, [x20, #0x168]
0065D3A18  cbz      x20, #0x65d3a74
0065D3A1C  adrp     x8, #0x8f09000
0065D3A20  ldr      x8, [x8, #0xa20]
0065D3A24  mov      x0, x20
0065D3A28  mov      w1, w22
0065D3A2C  ldr      x2, [x8]
0065D3A30  bl       #0x5221c50 ; Rock.Collections.OrderedDictionary<int, int>$$get_Item
0065D3A34  adrp     x8, #0x8f09000
0065D3A38  ldr      x8, [x8, #0xa08]
0065D3A3C  add      w2, w0, w19
0065D3A40  mov      x0, x20
0065D3A44  mov      w1, w22
0065D3A48  ldr      x3, [x8]
0065D3A4C  ldp      x20, x19, [sp, #0x30]
0065D3A50  ldp      x22, x21, [sp, #0x20]
0065D3A54  ldp      x24, x23, [sp, #0x10]
0065D3A58  ldr      x30, [sp], #0x40
0065D3A5C  b        #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
0065D3A60  ldp      x20, x19, [sp, #0x30]
0065D3A64  ldp      x22, x21, [sp, #0x20]
0065D3A68  ldp      x24, x23, [sp, #0x10]
0065D3A6C  ldr      x30, [sp], #0x40
0065D3A70  ret      
0065D3A74  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$AddGoldMonster
; RVA 0x65D0B58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D0B58  str      x30, [sp, #-0x30]!
0065D0B5C  stp      x22, x21, [sp, #0x10]
0065D0B60  stp      x20, x19, [sp, #0x20]
0065D0B64  adrp     x21, #0x9599000
0065D0B68  adrp     x22, #0x8f0a000
0065D0B6C  ldrb     w8, [x21, #0x58c]
0065D0B70  ldr      x22, [x22, #0x9a0]
0065D0B74  mov      x20, x1
0065D0B78  mov      x19, x0
0065D0B7C  tbnz     w8, #0, #0x65d0ba0
0065D0B80  adrp     x0, #0x8f08000
0065D0B84  ldr      x0, [x0, #0x630]
0065D0B88  bl       #0x382bd14 ; 
0065D0B8C  adrp     x0, #0x8f0a000
0065D0B90  ldr      x0, [x0, #0x9a0]
0065D0B94  bl       #0x382bd14 ; 
0065D0B98  mov      w8, #1
0065D0B9C  strb     w8, [x21, #0x58c]
0065D0BA0  ldr      x2, [x22]
0065D0BA4  ldrb     w8, [x2, #0x53]
0065D0BA8  tbnz     w8, #5, #0x65d0bec
0065D0BAC  cbz      x20, #0x65d0c6c
0065D0BB0  adrp     x21, #0x9599000
0065D0BB4  ldrb     w8, [x21, #0x4ec]
0065D0BB8  cbnz     w8, #0x65d0bd0
0065D0BBC  adrp     x0, #0x8f09000
0065D0BC0  ldr      x0, [x0, #0xfc8]
0065D0BC4  bl       #0x382bd14 ; 
0065D0BC8  mov      w8, #1
0065D0BCC  strb     w8, [x21, #0x4ec]
0065D0BD0  adrp     x8, #0x8f09000
0065D0BD4  ldr      x8, [x8, #0xfc8]
0065D0BD8  ldr      x1, [x8]
0065D0BDC  ldrb     w8, [x1, #0x53]
0065D0BE0  tbnz     w8, #5, #0x65d0c08
0065D0BE4  ldr      w0, [x20, #0x268]
0065D0BE8  b        #0x65d0c14 ; 
0065D0BEC  ldr      x3, [x2, #0x60]
0065D0BF0  mov      x0, x19
0065D0BF4  mov      x1, x20
0065D0BF8  ldp      x20, x19, [sp, #0x20]
0065D0BFC  ldp      x22, x21, [sp, #0x10]
0065D0C00  ldr      x30, [sp], #0x30
0065D0C04  br       x3
0065D0C08  ldr      x8, [x1, #0x60]
0065D0C0C  mov      x0, x20
0065D0C10  blr      x8
0065D0C14  cmp      w0, #1
0065D0C18  b.ne     #0x65d0c28
0065D0C1C  mov      x0, x19
0065D0C20  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D0C24  tbz      w0, #0, #0x65d0c3c
0065D0C28  ldp      x20, x19, [sp, #0x20]
0065D0C2C  ldp      x22, x21, [sp, #0x10]
0065D0C30  mov      w0, wzr
0065D0C34  ldr      x30, [sp], #0x30
0065D0C38  ret      
0065D0C3C  ldr      w8, [x19, #0x17c]
0065D0C40  ldr      x0, [x19, #0x1f8]
0065D0C44  add      w1, w8, #1
0065D0C48  str      w1, [x19, #0x17c]
0065D0C4C  cbz      x0, #0x65d0c6c
0065D0C50  adrp     x8, #0x8f08000
0065D0C54  ldr      x8, [x8, #0x630]
0065D0C58  ldp      x20, x19, [sp, #0x20]
0065D0C5C  ldp      x22, x21, [sp, #0x10]
0065D0C60  ldr      x2, [x8]
0065D0C64  ldr      x30, [sp], #0x30
0065D0C68  b        #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0065D0C6C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CalTileSpecialMonsterCount
; RVA 0x65D1854; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D1854  sub      sp, sp, #0x70
0065D1858  stp      x29, x30, [sp, #0x10]
0065D185C  stp      x28, x27, [sp, #0x20]
0065D1860  stp      x26, x25, [sp, #0x30]
0065D1864  stp      x24, x23, [sp, #0x40]
0065D1868  stp      x22, x21, [sp, #0x50]
0065D186C  stp      x20, x19, [sp, #0x60]
0065D1870  adrp     x19, #0x9599000
0065D1874  adrp     x22, #0x8f0a000
0065D1878  ldrb     w8, [x19, #0x58d]
0065D187C  ldr      x22, [x22, #0x9f0]
0065D1880  mov      w23, w2
0065D1884  mov      x20, x1
0065D1888  mov      x21, x0
0065D188C  tbnz     w8, #0, #0x65d1910
0065D1890  adrp     x0, #0x8f0a000
0065D1894  ldr      x0, [x0, #0x9f8]
0065D1898  bl       #0x382bd14 ; 
0065D189C  adrp     x0, #0x8f0a000
0065D18A0  ldr      x0, [x0, #0xa00]
0065D18A4  bl       #0x382bd14 ; 
0065D18A8  adrp     x0, #0x8f0a000
0065D18AC  ldr      x0, [x0, #0xa08]
0065D18B0  bl       #0x382bd14 ; 
0065D18B4  adrp     x0, #0x8f09000
0065D18B8  ldr      x0, [x0, #0xc08]
0065D18BC  bl       #0x382bd14 ; 
0065D18C0  adrp     x0, #0x8ee1000
0065D18C4  ldr      x0, [x0, #0x6e8]
0065D18C8  bl       #0x382bd14 ; 
0065D18CC  adrp     x0, #0x8f0a000
0065D18D0  ldr      x0, [x0, #0x9f0]
0065D18D4  bl       #0x382bd14 ; 
0065D18D8  adrp     x0, #0x8f0a000
0065D18DC  ldr      x0, [x0, #0xa10]
0065D18E0  bl       #0x382bd14 ; 
0065D18E4  adrp     x0, #0x8f0a000
0065D18E8  ldr      x0, [x0, #0xa18]
0065D18EC  bl       #0x382bd14 ; 
0065D18F0  adrp     x0, #0x8f0a000
0065D18F4  ldr      x0, [x0, #0x8b8]
0065D18F8  bl       #0x382bd14 ; 
0065D18FC  adrp     x0, #0x8f0a000
0065D1900  ldr      x0, [x0, #0x8c8]
0065D1904  bl       #0x382bd14 ; 
0065D1908  mov      w8, #1
0065D190C  strb     w8, [x19, #0x58d]
0065D1910  ldr      x3, [x22]
0065D1914  ldrb     w8, [x3, #0x53]
0065D1918  tbnz     w8, #5, #0x65d1978
0065D191C  adrp     x8, #0x8f0a000
0065D1920  ldr      x8, [x8, #0x9f8]
0065D1924  str      xzr, [sp, #8]
0065D1928  ldr      x0, [x8]
0065D192C  bl       #0x382bfa0 ; 
0065D1930  mov      x22, x0
0065D1934  bl       #0x65c7420 ; HotFix.BattleLogic.CalMonsterCountData$$.ctor
0065D1938  adrp     x8, #0x9599000
0065D193C  ldrb     w8, [x8, #0x286]
0065D1940  cbnz     w8, #0x65d195c
0065D1944  adrp     x0, #0x8f07000
0065D1948  ldr      x0, [x0, #0xc98]
0065D194C  bl       #0x382bd14 ; 
0065D1950  mov      w8, #1
0065D1954  adrp     x9, #0x9599000
0065D1958  strb     w8, [x9, #0x286]
0065D195C  adrp     x8, #0x8f07000
0065D1960  ldr      x8, [x8, #0xc98]
0065D1964  ldr      x1, [x8]
0065D1968  ldrb     w8, [x1, #0x53]
0065D196C  tbnz     w8, #5, #0x65d19a8
0065D1970  ldr      x24, [x21, #0x80]
0065D1974  b        #0x65d19b8 ; 
0065D1978  ldr      x4, [x3, #0x60]
0065D197C  mov      x0, x21
0065D1980  mov      x1, x20
0065D1984  mov      w2, w23
0065D1988  ldp      x20, x19, [sp, #0x60]
0065D198C  ldp      x22, x21, [sp, #0x50]
0065D1990  ldp      x24, x23, [sp, #0x40]
0065D1994  ldp      x26, x25, [sp, #0x30]
0065D1998  ldp      x28, x27, [sp, #0x20]
0065D199C  ldp      x29, x30, [sp, #0x10]
0065D19A0  add      sp, sp, #0x70
0065D19A4  br       x4
0065D19A8  ldr      x8, [x1, #0x60]
0065D19AC  mov      x0, x21
0065D19B0  blr      x8
0065D19B4  mov      x24, x0
0065D19B8  cbz      x24, #0x65d223c
0065D19BC  adrp     x19, #0x9591000
0065D19C0  ldrb     w8, [x19, #0xa9c]
0065D19C4  cbnz     w8, #0x65d19dc
0065D19C8  adrp     x0, #0x8ee6000
0065D19CC  ldr      x0, [x0, #0xaf0]
0065D19D0  bl       #0x382bd14 ; 
0065D19D4  mov      w8, #1
0065D19D8  strb     w8, [x19, #0xa9c]
0065D19DC  adrp     x8, #0x8ee6000
0065D19E0  ldr      x8, [x8, #0xaf0]
0065D19E4  ldr      x1, [x8]
0065D19E8  ldrb     w8, [x1, #0x53]
0065D19EC  tbnz     w8, #5, #0x65d19f8
0065D19F0  ldr      x26, [x24, #0x240]
0065D19F4  b        #0x65d1a08 ; 
0065D19F8  ldr      x8, [x1, #0x60]
0065D19FC  mov      x0, x24
0065D1A00  blr      x8
0065D1A04  mov      x26, x0
0065D1A08  cbz      x20, #0x65d223c
0065D1A0C  adrp     x10, #0x8f09000
0065D1A10  ldr      x8, [x20]
0065D1A14  ldr      x10, [x10, #0xc08]
0065D1A18  ldrh     w9, [x8, #0x12e]
0065D1A1C  ldr      x1, [x10]
0065D1A20  cbz      x9, #0x65d1a44
0065D1A24  ldr      x10, [x8, #0xb0]
0065D1A28  add      x10, x10, #8
0065D1A2C  ldur     x11, [x10, #-8]
0065D1A30  cmp      x11, x1
0065D1A34  b.eq     #0x65d1a54
0065D1A38  subs     x9, x9, #1
0065D1A3C  add      x10, x10, #0x10
0065D1A40  b.ne     #0x65d1a2c
0065D1A44  mov      w2, #0xe
0065D1A48  mov      x0, x20
0065D1A4C  bl       #0x3a7e710 ; 
0065D1A50  b        #0x65d1a64 ; 
0065D1A54  ldr      w9, [x10]
0065D1A58  add      w9, w9, #0xe
0065D1A5C  add      x8, x8, w9, sxtw #4
0065D1A60  add      x0, x8, #0x138
0065D1A64  ldp      x8, x1, [x0]
0065D1A68  mov      x0, x20
0065D1A6C  blr      x8
0065D1A70  ldr      x8, [x20]
0065D1A74  adrp     x10, #0x8f09000
0065D1A78  mov      w27, w0
0065D1A7C  ldrh     w9, [x8, #0x12e]
0065D1A80  ldr      x10, [x10, #0xc08]
0065D1A84  ldr      x1, [x10]
0065D1A88  cbz      x9, #0x65d1aac
0065D1A8C  ldr      x10, [x8, #0xb0]
0065D1A90  add      x10, x10, #8
0065D1A94  ldur     x11, [x10, #-8]
0065D1A98  cmp      x11, x1
0065D1A9C  b.eq     #0x65d1abc
0065D1AA0  subs     x9, x9, #1
0065D1AA4  add      x10, x10, #0x10
0065D1AA8  b.ne     #0x65d1a94
0065D1AAC  mov      x0, x20
0065D1AB0  mov      w2, wzr
0065D1AB4  bl       #0x3a7e710 ; 
0065D1AB8  b        #0x65d1ac8 ; 
0065D1ABC  ldrsw    x9, [x10]
0065D1AC0  add      x8, x8, x9, lsl #4
0065D1AC4  add      x0, x8, #0x138
0065D1AC8  ldp      x8, x1, [x0]
0065D1ACC  mov      x0, x20
0065D1AD0  blr      x8
0065D1AD4  mov      w24, w0
0065D1AD8  mov      x0, x21
0065D1ADC  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D1AE0  ldr      x8, [x21, #0x1f0]
0065D1AE4  cbz      x8, #0x65d223c
0065D1AE8  adrp     x9, #0x8f0a000
0065D1AEC  ldr      x9, [x9, #0xa08]
0065D1AF0  mov      w29, w0
0065D1AF4  add      x2, sp, #8
0065D1AF8  mov      x0, x8
0065D1AFC  ldr      x3, [x9]
0065D1B00  mov      w1, w24
0065D1B04  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
0065D1B08  tbnz     w0, #0, #0x65d1b48
0065D1B0C  adrp     x8, #0x8f0a000
0065D1B10  ldr      x8, [x8, #0xa10]
0065D1B14  ldr      x0, [x8]
0065D1B18  bl       #0x382bfa0 ; 
0065D1B1C  mov      x28, x0
0065D1B20  bl       #0x65c74f0 ; HotFix.BattleLogic.WaveMissionRandomData$$.ctor
0065D1B24  str      x28, [sp, #8]
0065D1B28  ldr      x0, [x21, #0x1f0]
0065D1B2C  cbz      x0, #0x65d223c
0065D1B30  adrp     x8, #0x8f0a000
0065D1B34  ldr      x8, [x8, #0xa00]
0065D1B38  mov      w1, w24
0065D1B3C  mov      x2, x28
0065D1B40  ldr      x3, [x8]
0065D1B44  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
0065D1B48  cmp      w27, #1
0065D1B4C  str      w23, [sp, #4]
0065D1B50  b.lt     #0x65d2218
0065D1B54  adrp     x8, #0x9599000
0065D1B58  ldrb     w8, [x8, #0x286]
0065D1B5C  cbnz     w8, #0x65d1b78
0065D1B60  adrp     x0, #0x8f07000
0065D1B64  ldr      x0, [x0, #0xc98]
0065D1B68  bl       #0x382bd14 ; 
0065D1B6C  mov      w8, #1
0065D1B70  adrp     x9, #0x9599000
0065D1B74  strb     w8, [x9, #0x286]
0065D1B78  adrp     x8, #0x8f07000
0065D1B7C  ldr      x8, [x8, #0xc98]
0065D1B80  ldr      x1, [x8]
0065D1B84  ldrb     w8, [x1, #0x53]
0065D1B88  tbnz     w8, #5, #0x65d1b94
0065D1B8C  ldr      x28, [x21, #0x80]
0065D1B90  b        #0x65d1ba4 ; 
0065D1B94  ldr      x8, [x1, #0x60]
0065D1B98  mov      x0, x21
0065D1B9C  blr      x8
0065D1BA0  mov      x28, x0
0065D1BA4  cbz      x28, #0x65d223c
0065D1BA8  adrp     x8, #0x9598000
0065D1BAC  ldrb     w8, [x8, #0xfcc]
0065D1BB0  cbnz     w8, #0x65d1bcc
0065D1BB4  adrp     x0, #0x8f06000
0065D1BB8  ldr      x0, [x0, #0x470]
0065D1BBC  bl       #0x382bd14 ; 
0065D1BC0  mov      w8, #1
0065D1BC4  adrp     x9, #0x9598000
0065D1BC8  strb     w8, [x9, #0xfcc]
0065D1BCC  adrp     x8, #0x8f06000
0065D1BD0  ldr      x8, [x8, #0x470]
0065D1BD4  ldr      x1, [x8]
0065D1BD8  ldrb     w8, [x1, #0x53]
0065D1BDC  tbnz     w8, #5, #0x65d1be8
0065D1BE0  ldr      x0, [x28, #0x200]
0065D1BE4  b        #0x65d1bf4 ; 
0065D1BE8  ldr      x8, [x1, #0x60]
0065D1BEC  mov      x0, x28
0065D1BF0  blr      x8
0065D1BF4  cbz      x0, #0x65d223c
0065D1BF8  mov      w1, w27
0065D1BFC  mov      x2, xzr
0065D1C00  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065D1C04  cbz      x0, #0x65d1c48
0065D1C08  adrp     x19, #0x9599000
0065D1C0C  ldrb     w8, [x19, #0x657]
0065D1C10  mov      x27, x0
0065D1C14  cbnz     w8, #0x65d1c2c
0065D1C18  adrp     x0, #0x8f0a000
0065D1C1C  ldr      x0, [x0, #0x8d0]
0065D1C20  bl       #0x382bd14 ; 
0065D1C24  mov      w8, #1
0065D1C28  strb     w8, [x19, #0x657]
0065D1C2C  adrp     x23, #0x8f0a000
0065D1C30  ldr      x23, [x23, #0x8d0]
0065D1C34  ldr      x1, [x23]
0065D1C38  ldrb     w8, [x1, #0x53]
0065D1C3C  tbnz     w8, #5, #0x65d1c94
0065D1C40  ldr      x0, [x27, #0x28]
0065D1C44  b        #0x65d1ca0 ; 
0065D1C48  adrp     x8, #0x8ee1000
0065D1C4C  ldr      x8, [x8, #0x6e8]
0065D1C50  ldr      x0, [x8]
0065D1C54  ldr      w8, [x0, #0xe0]
0065D1C58  cbnz     w8, #0x65d1c60
0065D1C5C  bl       #0x382be8c ; 
0065D1C60  adrp     x8, #0x8f0a000
0065D1C64  adrp     x9, #0x8f0a000
0065D1C68  adrp     x10, #0x8f0a000
0065D1C6C  ldr      x8, [x8, #0x8c8]
0065D1C70  ldr      x9, [x9, #0xa18]
0065D1C74  ldr      x10, [x10, #0x8b8]
0065D1C78  mov      w3, #0x486
0065D1C7C  ldr      x0, [x8]
0065D1C80  ldr      x1, [x9]
0065D1C84  ldr      x2, [x10]
0065D1C88  mov      x4, xzr
0065D1C8C  bl       #0x7997754 ; Logger$$LogError
0065D1C90  b        #0x65d2218 ; 
0065D1C94  ldr      x8, [x1, #0x60]
0065D1C98  mov      x0, x27
0065D1C9C  blr      x8
0065D1CA0  cbz      x0, #0x65d223c
0065D1CA4  ldr      x8, [x0, #0x18]
0065D1CA8  cbz      x8, #0x65d2218
0065D1CAC  ldrb     w8, [x19, #0x657]
0065D1CB0  cbnz     w8, #0x65d1cc8
0065D1CB4  adrp     x0, #0x8f0a000
0065D1CB8  ldr      x0, [x0, #0x8d0]
0065D1CBC  bl       #0x382bd14 ; 
0065D1CC0  mov      w8, #1
0065D1CC4  strb     w8, [x19, #0x657]
0065D1CC8  ldr      x1, [x23]
0065D1CCC  ldrb     w8, [x1, #0x53]
0065D1CD0  tbnz     w8, #5, #0x65d1cdc
0065D1CD4  ldr      x1, [x27, #0x28]
0065D1CD8  b        #0x65d1cec ; 
0065D1CDC  ldr      x8, [x1, #0x60]
0065D1CE0  mov      x0, x27
0065D1CE4  blr      x8
0065D1CE8  mov      x1, x0
0065D1CEC  cbz      x26, #0x65d223c
0065D1CF0  mov      x0, x26
0065D1CF4  mov      x2, xzr
0065D1CF8  bl       #0x6903320 ; HotFix.BattleLogic.MapManager$$WaterfallRandomMap
0065D1CFC  ldr      x8, [sp, #8]
0065D1D00  cbz      x8, #0x65d223c
0065D1D04  str      w0, [x8, #0x10]
0065D1D08  adrp     x19, #0x9599000
0065D1D0C  ldrb     w8, [x19, #0x26f]
0065D1D10  mov      w27, w0
0065D1D14  cbnz     w8, #0x65d1d2c
0065D1D18  adrp     x0, #0x8f06000
0065D1D1C  ldr      x0, [x0, #0xd58]
0065D1D20  bl       #0x382bd14 ; 
0065D1D24  mov      w8, #1
0065D1D28  strb     w8, [x19, #0x26f]
0065D1D2C  adrp     x8, #0x8f06000
0065D1D30  ldr      x8, [x8, #0xd58]
0065D1D34  ldr      x1, [x8]
0065D1D38  ldrb     w8, [x1, #0x53]
0065D1D3C  tbnz     w8, #5, #0x65d1d48
0065D1D40  ldr      x0, [x26, #0x20]
0065D1D44  b        #0x65d1d54 ; 
0065D1D48  ldr      x8, [x1, #0x60]
0065D1D4C  mov      x0, x26
0065D1D50  blr      x8
0065D1D54  cbz      x0, #0x65d223c
0065D1D58  ldr      x8, [x0, #0x140]
0065D1D5C  cbz      x8, #0x65d223c
0065D1D60  ldr      w9, [x8, #0x18]
0065D1D64  cmp      w27, w9
0065D1D68  b.hs     #0x65d2240
0065D1D6C  add      x8, x8, w27, sxtw #4
0065D1D70  ldr      x23, [x8, #0x28]
0065D1D74  cbz      x23, #0x65d2218
0065D1D78  ldr      x8, [x20]
0065D1D7C  adrp     x10, #0x8f09000
0065D1D80  ldr      x25, [x23, #0x18]
0065D1D84  ldrh     w9, [x8, #0x12e]
0065D1D88  ldr      x10, [x10, #0xc08]
0065D1D8C  ldr      x1, [x10]
0065D1D90  cbz      x9, #0x65d1db4
0065D1D94  ldr      x10, [x8, #0xb0]
0065D1D98  add      x10, x10, #8
0065D1D9C  ldur     x11, [x10, #-8]
0065D1DA0  cmp      x11, x1
0065D1DA4  b.eq     #0x65d1dc4
0065D1DA8  subs     x9, x9, #1
0065D1DAC  add      x10, x10, #0x10
0065D1DB0  b.ne     #0x65d1d9c
0065D1DB4  mov      w2, #0x10
0065D1DB8  mov      x0, x20
0065D1DBC  bl       #0x3a7e710 ; 
0065D1DC0  b        #0x65d1dd4 ; 
0065D1DC4  ldr      w9, [x10]
0065D1DC8  add      w9, w9, #0x10
0065D1DCC  add      x8, x8, w9, sxtw #4
0065D1DD0  add      x0, x8, #0x138
0065D1DD4  ldp      x8, x1, [x0]
0065D1DD8  mov      x0, x20
0065D1DDC  blr      x8
0065D1DE0  cbz      x0, #0x65d223c
0065D1DE4  ldr      x8, [x0, #0x18]
0065D1DE8  cbz      x8, #0x65d1e2c
0065D1DEC  adrp     x8, #0x9599000
0065D1DF0  ldrb     w8, [x8, #0x286]
0065D1DF4  cbnz     w8, #0x65d1e10
0065D1DF8  adrp     x0, #0x8f07000
0065D1DFC  ldr      x0, [x0, #0xc98]
0065D1E00  bl       #0x382bd14 ; 
0065D1E04  mov      w8, #1
0065D1E08  adrp     x9, #0x9599000
0065D1E0C  strb     w8, [x9, #0x286]
0065D1E10  adrp     x8, #0x8f07000
0065D1E14  ldr      x8, [x8, #0xc98]
0065D1E18  ldr      x1, [x8]
0065D1E1C  ldrb     w8, [x1, #0x53]
0065D1E20  tbnz     w8, #5, #0x65d1e34
0065D1E24  ldr      x26, [x21, #0x80]
0065D1E28  b        #0x65d1e44 ; 
0065D1E2C  mov      w24, wzr
0065D1E30  b        #0x65d1f50 ; 
0065D1E34  ldr      x8, [x1, #0x60]
0065D1E38  mov      x0, x21
0065D1E3C  blr      x8
0065D1E40  mov      x26, x0
0065D1E44  ldr      x8, [x20]
0065D1E48  adrp     x10, #0x8f09000
0065D1E4C  ldrh     w9, [x8, #0x12e]
0065D1E50  ldr      x10, [x10, #0xc08]
0065D1E54  ldr      x1, [x10]
0065D1E58  cbz      x9, #0x65d1e7c
0065D1E5C  ldr      x10, [x8, #0xb0]
0065D1E60  add      x10, x10, #8
0065D1E64  ldur     x11, [x10, #-8]
0065D1E68  cmp      x11, x1
0065D1E6C  b.eq     #0x65d1e8c
0065D1E70  subs     x9, x9, #1
0065D1E74  add      x10, x10, #0x10
0065D1E78  b.ne     #0x65d1e64
0065D1E7C  mov      w2, #0x10
0065D1E80  mov      x0, x20
0065D1E84  bl       #0x3a7e710 ; 
0065D1E88  b        #0x65d1e9c ; 
0065D1E8C  ldr      w9, [x10]
0065D1E90  add      w9, w9, #0x10
0065D1E94  add      x8, x8, w9, sxtw #4
0065D1E98  add      x0, x8, #0x138
0065D1E9C  ldp      x8, x1, [x0]
0065D1EA0  mov      x0, x20
0065D1EA4  blr      x8
0065D1EA8  cbz      x0, #0x65d223c
0065D1EAC  cbz      x26, #0x65d223c
0065D1EB0  ldr      w2, [x0, #0x18]
0065D1EB4  mov      x0, x26
0065D1EB8  mov      w1, wzr
0065D1EBC  mov      x3, xzr
0065D1EC0  bl       #0x54b65d8 ; 
0065D1EC4  ldr      x8, [sp, #8]
0065D1EC8  cbz      x8, #0x65d223c
0065D1ECC  str      w0, [x8, #0x14]
0065D1ED0  ldr      x8, [x20]
0065D1ED4  adrp     x10, #0x8f09000
0065D1ED8  mov      w26, w0
0065D1EDC  ldrh     w9, [x8, #0x12e]
0065D1EE0  ldr      x10, [x10, #0xc08]
0065D1EE4  ldr      x1, [x10]
0065D1EE8  cbz      x9, #0x65d1f0c
0065D1EEC  ldr      x10, [x8, #0xb0]
0065D1EF0  add      x10, x10, #8
0065D1EF4  ldur     x11, [x10, #-8]
0065D1EF8  cmp      x11, x1
0065D1EFC  b.eq     #0x65d1f1c
0065D1F00  subs     x9, x9, #1
0065D1F04  add      x10, x10, #0x10
0065D1F08  b.ne     #0x65d1ef4
0065D1F0C  mov      w2, #0x10
0065D1F10  mov      x0, x20
0065D1F14  bl       #0x3a7e710 ; 
0065D1F18  b        #0x65d1f2c ; 
0065D1F1C  ldr      w9, [x10]
0065D1F20  add      w9, w9, #0x10
0065D1F24  add      x8, x8, w9, sxtw #4
0065D1F28  add      x0, x8, #0x138
0065D1F2C  ldp      x8, x1, [x0]
0065D1F30  mov      x0, x20
0065D1F34  blr      x8
0065D1F38  cbz      x0, #0x65d223c
0065D1F3C  ldr      w8, [x0, #0x18]
0065D1F40  cmp      w26, w8
0065D1F44  b.hs     #0x65d2240
0065D1F48  add      x8, x0, w26, sxtw #2
0065D1F4C  ldr      w24, [x8, #0x20]
0065D1F50  cmp      w25, #1
0065D1F54  b.lt     #0x65d2218
0065D1F58  adrp     x27, #0x8f0a000
0065D1F5C  ldr      x27, [x27, #0xa20]
0065D1F60  mov      x19, xzr
0065D1F64  and      x26, x25, #0xffffffff
0065D1F68  mov      w25, #1
0065D1F6C  and      w8, w29, #1
0065D1F70  str      w8, [sp]
0065D1F74  ldr      w8, [x23, #0x18]
0065D1F78  cmp      x19, x8
0065D1F7C  b.hs     #0x65d2240
0065D1F80  ldr      x8, [x20]
0065D1F84  mov      w9, #0x38
0065D1F88  madd     x9, x19, x9, x23
0065D1F8C  adrp     x10, #0x8f09000
0065D1F90  ldr      w28, [x9, #0x20]
0065D1F94  ldrh     w9, [x8, #0x12e]
0065D1F98  ldr      x10, [x10, #0xc08]
0065D1F9C  ldr      x1, [x10]
0065D1FA0  cbz      x9, #0x65d1fc4
0065D1FA4  ldr      x10, [x8, #0xb0]
0065D1FA8  add      x10, x10, #8
0065D1FAC  ldur     x11, [x10, #-8]
0065D1FB0  cmp      x11, x1
0065D1FB4  b.eq     #0x65d1fd4
0065D1FB8  subs     x9, x9, #1
0065D1FBC  add      x10, x10, #0x10
0065D1FC0  b.ne     #0x65d1fac
0065D1FC4  mov      w2, #0x10
0065D1FC8  mov      x0, x20
0065D1FCC  bl       #0x3a7e710 ; 
0065D1FD0  b        #0x65d1fe4 ; 
0065D1FD4  ldr      w9, [x10]
0065D1FD8  add      w9, w9, #0x10
0065D1FDC  add      x8, x8, w9, sxtw #4
0065D1FE0  add      x0, x8, #0x138
0065D1FE4  ldp      x8, x1, [x0]
0065D1FE8  mov      x0, x20
0065D1FEC  blr      x8
0065D1FF0  cbz      x0, #0x65d223c
0065D1FF4  ldr      x8, [x0, #0x18]
0065D1FF8  adrp     x9, #0x9599000
0065D1FFC  ldrb     w9, [x9, #0x286]
0065D2000  cmp      x8, #0
0065D2004  csel     w28, w28, w24, eq
0065D2008  cbnz     w9, #0x65d2020
0065D200C  adrp     x0, #0x8f07000
0065D2010  ldr      x0, [x0, #0xc98]
0065D2014  bl       #0x382bd14 ; 
0065D2018  adrp     x8, #0x9599000
0065D201C  strb     w25, [x8, #0x286]
0065D2020  adrp     x8, #0x8f07000
0065D2024  ldr      x8, [x8, #0xc98]
0065D2028  ldr      x1, [x8]
0065D202C  ldrb     w8, [x1, #0x53]
0065D2030  tbnz     w8, #5, #0x65d203c
0065D2034  ldr      x29, [x21, #0x80]
0065D2038  b        #0x65d204c ; 
0065D203C  ldr      x8, [x1, #0x60]
0065D2040  mov      x0, x21
0065D2044  blr      x8
0065D2048  mov      x29, x0
0065D204C  cbz      x29, #0x65d223c
0065D2050  adrp     x8, #0x9598000
0065D2054  ldrb     w8, [x8, #0xfcc]
0065D2058  cbnz     w8, #0x65d2070
0065D205C  adrp     x0, #0x8f06000
0065D2060  ldr      x0, [x0, #0x470]
0065D2064  bl       #0x382bd14 ; 
0065D2068  adrp     x8, #0x9598000
0065D206C  strb     w25, [x8, #0xfcc]
0065D2070  adrp     x8, #0x8f06000
0065D2074  ldr      x8, [x8, #0x470]
0065D2078  ldr      x1, [x8]
0065D207C  ldrb     w8, [x1, #0x53]
0065D2080  tbnz     w8, #5, #0x65d208c
0065D2084  ldr      x0, [x29, #0x200]
0065D2088  b        #0x65d2098 ; 
0065D208C  ldr      x8, [x1, #0x60]
0065D2090  mov      x0, x29
0065D2094  blr      x8
0065D2098  cbz      x0, #0x65d223c
0065D209C  mov      w1, w28
0065D20A0  mov      x2, xzr
0065D20A4  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D20A8  cbz      x0, #0x65d220c
0065D20AC  adrp     x8, #0x9591000
0065D20B0  ldrb     w8, [x8, #0xa75]
0065D20B4  mov      x28, x0
0065D20B8  cbnz     w8, #0x65d20d0
0065D20BC  adrp     x0, #0x8ee6000
0065D20C0  ldr      x0, [x0, #0x290]
0065D20C4  bl       #0x382bd14 ; 
0065D20C8  adrp     x8, #0x9591000
0065D20CC  strb     w25, [x8, #0xa75]
0065D20D0  adrp     x8, #0x8ee6000
0065D20D4  ldr      x8, [x8, #0x290]
0065D20D8  ldr      x1, [x8]
0065D20DC  ldrb     w8, [x1, #0x53]
0065D20E0  tbnz     w8, #5, #0x65d20ec
0065D20E4  ldr      w0, [x28, #0x24]
0065D20E8  b        #0x65d20f8 ; 
0065D20EC  ldr      x8, [x1, #0x60]
0065D20F0  mov      x0, x28
0065D20F4  blr      x8
0065D20F8  cmp      w0, #0xc9
0065D20FC  b.eq     #0x65d2150
0065D2100  adrp     x8, #0x9591000
0065D2104  ldrb     w8, [x8, #0xa75]
0065D2108  cbnz     w8, #0x65d2120
0065D210C  adrp     x0, #0x8ee6000
0065D2110  ldr      x0, [x0, #0x290]
0065D2114  bl       #0x382bd14 ; 
0065D2118  adrp     x8, #0x9591000
0065D211C  strb     w25, [x8, #0xa75]
0065D2120  adrp     x8, #0x8ee6000
0065D2124  ldr      x8, [x8, #0x290]
0065D2128  ldr      x1, [x8]
0065D212C  ldrb     w8, [x1, #0x53]
0065D2130  tbnz     w8, #5, #0x65d213c
0065D2134  ldr      w0, [x28, #0x24]
0065D2138  b        #0x65d2148 ; 
0065D213C  ldr      x8, [x1, #0x60]
0065D2140  mov      x0, x28
0065D2144  blr      x8
0065D2148  cmp      w0, #3
0065D214C  b.ne     #0x65d2160
0065D2150  cbz      x22, #0x65d223c
0065D2154  ldr      w8, [x22, #0x14]
0065D2158  add      w8, w8, #1
0065D215C  str      w8, [x22, #0x14]
0065D2160  adrp     x8, #0x9599000
0065D2164  ldrb     w8, [x8, #0x65d]
0065D2168  cbnz     w8, #0x65d217c
0065D216C  mov      x0, x27
0065D2170  bl       #0x382bd14 ; 
0065D2174  adrp     x8, #0x9599000
0065D2178  strb     w25, [x8, #0x65d]
0065D217C  ldr      x1, [x27]
0065D2180  ldrb     w8, [x1, #0x53]
0065D2184  tbnz     w8, #5, #0x65d2190
0065D2188  ldr      w0, [x28, #0x24c]
0065D218C  b        #0x65d219c ; 
0065D2190  ldr      x8, [x1, #0x60]
0065D2194  mov      x0, x28
0065D2198  blr      x8
0065D219C  cmp      w0, #1
0065D21A0  b.lt     #0x65d21fc
0065D21A4  cbz      x22, #0x65d223c
0065D21A8  ldr      w8, [x22, #0x10]
0065D21AC  ldr      w29, [x22, #0x18]
0065D21B0  add      w8, w8, #1
0065D21B4  str      w8, [x22, #0x10]
0065D21B8  adrp     x8, #0x9599000
0065D21BC  ldrb     w8, [x8, #0x65d]
0065D21C0  cbnz     w8, #0x65d21d4
0065D21C4  mov      x0, x27
0065D21C8  bl       #0x382bd14 ; 
0065D21CC  adrp     x8, #0x9599000
0065D21D0  strb     w25, [x8, #0x65d]
0065D21D4  ldr      x1, [x27]
0065D21D8  ldrb     w8, [x1, #0x53]
0065D21DC  tbnz     w8, #5, #0x65d21e8
0065D21E0  ldr      w0, [x28, #0x24c]
0065D21E4  b        #0x65d21f4 ; 
0065D21E8  ldr      x8, [x1, #0x60]
0065D21EC  mov      x0, x28
0065D21F0  blr      x8
0065D21F4  add      w8, w0, w29
0065D21F8  str      w8, [x22, #0x18]
0065D21FC  ldp      w2, w3, [sp]
0065D2200  mov      x0, x21
0065D2204  mov      x1, x28
0065D2208  bl       #0x65d3844 ; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
0065D220C  add      x19, x19, #1
0065D2210  cmp      x19, x26
0065D2214  b.ne     #0x65d1f74
0065D2218  mov      x0, x22
0065D221C  ldp      x20, x19, [sp, #0x60]
0065D2220  ldp      x22, x21, [sp, #0x50]
0065D2224  ldp      x24, x23, [sp, #0x40]
0065D2228  ldp      x26, x25, [sp, #0x30]
0065D222C  ldp      x28, x27, [sp, #0x20]
0065D2230  ldp      x29, x30, [sp, #0x10]
0065D2234  add      sp, sp, #0x70
0065D2238  ret      
0065D223C  bl       #0x382bfb8 ; 
0065D2240  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CalRandomMonster
; RVA 0x65D2D9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D2D9C  sub      sp, sp, #0x80
0065D2DA0  stp      x29, x30, [sp, #0x20]
0065D2DA4  stp      x28, x27, [sp, #0x30]
0065D2DA8  stp      x26, x25, [sp, #0x40]
0065D2DAC  stp      x24, x23, [sp, #0x50]
0065D2DB0  stp      x22, x21, [sp, #0x60]
0065D2DB4  stp      x20, x19, [sp, #0x70]
0065D2DB8  str      w2, [sp, #0x14]
0065D2DBC  adrp     x19, #0x9599000
0065D2DC0  adrp     x21, #0x8f0a000
0065D2DC4  ldrb     w8, [x19, #0x58e]
0065D2DC8  ldr      x21, [x21, #0xa58]
0065D2DCC  mov      x23, x1
0065D2DD0  mov      x20, x0
0065D2DD4  tbnz     w8, #0, #0x65d2e7c
0065D2DD8  adrp     x0, #0x8f0a000
0065D2DDC  ldr      x0, [x0, #0x9f8]
0065D2DE0  bl       #0x382bd14 ; 
0065D2DE4  adrp     x0, #0x8f0a000
0065D2DE8  ldr      x0, [x0, #0xa00]
0065D2DEC  bl       #0x382bd14 ; 
0065D2DF0  adrp     x0, #0x8f0a000
0065D2DF4  ldr      x0, [x0, #0xa08]
0065D2DF8  bl       #0x382bd14 ; 
0065D2DFC  adrp     x0, #0x8f09000
0065D2E00  ldr      x0, [x0, #0xc08]
0065D2E04  bl       #0x382bd14 ; 
0065D2E08  adrp     x0, #0x8ec2000
0065D2E0C  ldr      x0, [x0, #0x260]
0065D2E10  bl       #0x382bd14 ; 
0065D2E14  adrp     x0, #0x8ec2000
0065D2E18  ldr      x0, [x0, #0x2b8]
0065D2E1C  bl       #0x382bd14 ; 
0065D2E20  adrp     x0, #0x8ec2000
0065D2E24  ldr      x0, [x0, #0x2d0]
0065D2E28  bl       #0x382bd14 ; 
0065D2E2C  adrp     x0, #0x8ee1000
0065D2E30  ldr      x0, [x0, #0x6e8]
0065D2E34  bl       #0x382bd14 ; 
0065D2E38  adrp     x0, #0x8f0a000
0065D2E3C  ldr      x0, [x0, #0xa58]
0065D2E40  bl       #0x382bd14 ; 
0065D2E44  adrp     x0, #0x8f0a000
0065D2E48  ldr      x0, [x0, #0xa10]
0065D2E4C  bl       #0x382bd14 ; 
0065D2E50  adrp     x0, #0x8f0a000
0065D2E54  ldr      x0, [x0, #0x8b8]
0065D2E58  bl       #0x382bd14 ; 
0065D2E5C  adrp     x0, #0x8f0a000
0065D2E60  ldr      x0, [x0, #0xa60]
0065D2E64  bl       #0x382bd14 ; 
0065D2E68  adrp     x0, #0x8f0a000
0065D2E6C  ldr      x0, [x0, #0x980]
0065D2E70  bl       #0x382bd14 ; 
0065D2E74  mov      w8, #1
0065D2E78  strb     w8, [x19, #0x58e]
0065D2E7C  ldr      x3, [x21]
0065D2E80  ldrb     w8, [x3, #0x53]
0065D2E84  tbnz     w8, #5, #0x65d2efc
0065D2E88  adrp     x8, #0x8f0a000
0065D2E8C  ldr      x8, [x8, #0x9f8]
0065D2E90  str      xzr, [sp, #0x18]
0065D2E94  ldr      x0, [x8]
0065D2E98  bl       #0x382bfa0 ; 
0065D2E9C  mov      x21, x0
0065D2EA0  bl       #0x65c7420 ; HotFix.BattleLogic.CalMonsterCountData$$.ctor
0065D2EA4  mov      x0, x20
0065D2EA8  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D2EAC  cbz      x23, #0x65d377c
0065D2EB0  adrp     x24, #0x8f09000
0065D2EB4  ldr      x8, [x23]
0065D2EB8  ldr      x24, [x24, #0xc08]
0065D2EBC  mov      w29, w0
0065D2EC0  ldrh     w9, [x8, #0x12e]
0065D2EC4  ldr      x1, [x24]
0065D2EC8  cbz      x9, #0x65d2eec
0065D2ECC  ldr      x10, [x8, #0xb0]
0065D2ED0  add      x10, x10, #8
0065D2ED4  ldur     x11, [x10, #-8]
0065D2ED8  cmp      x11, x1
0065D2EDC  b.eq     #0x65d2f2c
0065D2EE0  subs     x9, x9, #1
0065D2EE4  add      x10, x10, #0x10
0065D2EE8  b.ne     #0x65d2ed4
0065D2EEC  mov      w2, #0x18
0065D2EF0  mov      x0, x23
0065D2EF4  bl       #0x3a7e710 ; 
0065D2EF8  b        #0x65d2f3c ; 
0065D2EFC  ldr      x4, [x3, #0x60]
0065D2F00  mov      x0, x20
0065D2F04  mov      x1, x23
0065D2F08  ldr      w2, [sp, #0x14]
0065D2F0C  ldp      x20, x19, [sp, #0x70]
0065D2F10  ldp      x22, x21, [sp, #0x60]
0065D2F14  ldp      x24, x23, [sp, #0x50]
0065D2F18  ldp      x26, x25, [sp, #0x40]
0065D2F1C  ldp      x28, x27, [sp, #0x30]
0065D2F20  ldp      x29, x30, [sp, #0x20]
0065D2F24  add      sp, sp, #0x80
0065D2F28  br       x4
0065D2F2C  ldr      w9, [x10]
0065D2F30  add      w9, w9, #0x18
0065D2F34  add      x8, x8, w9, sxtw #4
0065D2F38  add      x0, x8, #0x138
0065D2F3C  ldp      x8, x1, [x0]
0065D2F40  mov      x0, x23
0065D2F44  blr      x8
0065D2F48  cmp      w0, #1
0065D2F4C  b.lt     #0x65d3758
0065D2F50  ldr      x8, [x23]
0065D2F54  ldr      x1, [x24]
0065D2F58  ldrh     w9, [x8, #0x12e]
0065D2F5C  cbz      x9, #0x65d2f80
0065D2F60  ldr      x10, [x8, #0xb0]
0065D2F64  add      x10, x10, #8
0065D2F68  ldur     x11, [x10, #-8]
0065D2F6C  cmp      x11, x1
0065D2F70  b.eq     #0x65d2f90
0065D2F74  subs     x9, x9, #1
0065D2F78  add      x10, x10, #0x10
0065D2F7C  b.ne     #0x65d2f68
0065D2F80  mov      w2, #0x16
0065D2F84  mov      x0, x23
0065D2F88  bl       #0x3a7e710 ; 
0065D2F8C  b        #0x65d2fa0 ; 
0065D2F90  ldr      w9, [x10]
0065D2F94  add      w9, w9, #0x16
0065D2F98  add      x8, x8, w9, sxtw #4
0065D2F9C  add      x0, x8, #0x138
0065D2FA0  ldp      x8, x1, [x0]
0065D2FA4  mov      x0, x23
0065D2FA8  blr      x8
0065D2FAC  cbz      x0, #0x65d3758
0065D2FB0  ldr      x8, [x23]
0065D2FB4  ldr      x1, [x24]
0065D2FB8  ldrh     w9, [x8, #0x12e]
0065D2FBC  cbz      x9, #0x65d2fe0
0065D2FC0  ldr      x10, [x8, #0xb0]
0065D2FC4  add      x10, x10, #8
0065D2FC8  ldur     x11, [x10, #-8]
0065D2FCC  cmp      x11, x1
0065D2FD0  b.eq     #0x65d2ff0
0065D2FD4  subs     x9, x9, #1
0065D2FD8  add      x10, x10, #0x10
0065D2FDC  b.ne     #0x65d2fc8
0065D2FE0  mov      w2, #0x16
0065D2FE4  mov      x0, x23
0065D2FE8  bl       #0x3a7e710 ; 
0065D2FEC  b        #0x65d3000 ; 
0065D2FF0  ldr      w9, [x10]
0065D2FF4  add      w9, w9, #0x16
0065D2FF8  add      x8, x8, w9, sxtw #4
0065D2FFC  add      x0, x8, #0x138
0065D3000  ldp      x8, x1, [x0]
0065D3004  mov      x0, x23
0065D3008  blr      x8
0065D300C  cbz      x0, #0x65d377c
0065D3010  ldr      x8, [x0, #0x18]
0065D3014  cbz      x8, #0x65d3758
0065D3018  ldr      x8, [x23]
0065D301C  ldr      x1, [x24]
0065D3020  ldrh     w9, [x8, #0x12e]
0065D3024  cbz      x9, #0x65d3048
0065D3028  ldr      x10, [x8, #0xb0]
0065D302C  add      x10, x10, #8
0065D3030  ldur     x11, [x10, #-8]
0065D3034  cmp      x11, x1
0065D3038  b.eq     #0x65d3058
0065D303C  subs     x9, x9, #1
0065D3040  add      x10, x10, #0x10
0065D3044  b.ne     #0x65d3030
0065D3048  mov      x0, x23
0065D304C  mov      w2, wzr
0065D3050  bl       #0x3a7e710 ; 
0065D3054  b        #0x65d3064 ; 
0065D3058  ldrsw    x9, [x10]
0065D305C  add      x8, x8, x9, lsl #4
0065D3060  add      x0, x8, #0x138
0065D3064  ldp      x8, x1, [x0]
0065D3068  mov      x0, x23
0065D306C  blr      x8
0065D3070  ldr      x8, [x20, #0x1f0]
0065D3074  cbz      x8, #0x65d377c
0065D3078  adrp     x9, #0x8f0a000
0065D307C  ldr      x9, [x9, #0xa08]
0065D3080  mov      w19, w0
0065D3084  add      x2, sp, #0x18
0065D3088  mov      x0, x8
0065D308C  ldr      x3, [x9]
0065D3090  mov      w1, w19
0065D3094  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
0065D3098  tbnz     w0, #0, #0x65d30d8
0065D309C  adrp     x8, #0x8f0a000
0065D30A0  ldr      x8, [x8, #0xa10]
0065D30A4  ldr      x0, [x8]
0065D30A8  bl       #0x382bfa0 ; 
0065D30AC  mov      x22, x0
0065D30B0  bl       #0x65c74f0 ; HotFix.BattleLogic.WaveMissionRandomData$$.ctor
0065D30B4  str      x22, [sp, #0x18]
0065D30B8  ldr      x0, [x20, #0x1f0]
0065D30BC  cbz      x0, #0x65d377c
0065D30C0  adrp     x8, #0x8f0a000
0065D30C4  ldr      x8, [x8, #0xa00]
0065D30C8  mov      w1, w19
0065D30CC  mov      x2, x22
0065D30D0  ldr      x3, [x8]
0065D30D4  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
0065D30D8  ldr      x19, [sp, #0x18]
0065D30DC  cbz      x19, #0x65d377c
0065D30E0  ldr      x8, [x19, #0x28]!
0065D30E4  cbnz     x8, #0x65d311c
0065D30E8  adrp     x8, #0x8ec2000
0065D30EC  ldr      x8, [x8, #0x2d0]
0065D30F0  ldr      x0, [x8]
0065D30F4  bl       #0x382bfa0 ; 
0065D30F8  adrp     x8, #0x8ec2000
0065D30FC  ldr      x8, [x8, #0x2b8]
0065D3100  mov      x22, x0
0065D3104  ldr      x1, [x8]
0065D3108  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
0065D310C  mov      x0, x19
0065D3110  mov      x1, x22
0065D3114  str      x22, [x19]
0065D3118  bl       #0x382bcb8 ; 
0065D311C  ldr      x8, [x23]
0065D3120  ldr      x1, [x24]
0065D3124  ldrh     w9, [x8, #0x12e]
0065D3128  cbz      x9, #0x65d314c
0065D312C  ldr      x10, [x8, #0xb0]
0065D3130  add      x10, x10, #8
0065D3134  ldur     x11, [x10, #-8]
0065D3138  cmp      x11, x1
0065D313C  b.eq     #0x65d315c
0065D3140  subs     x9, x9, #1
0065D3144  add      x10, x10, #0x10
0065D3148  b.ne     #0x65d3134
0065D314C  mov      w2, #0x18
0065D3150  mov      x0, x23
0065D3154  bl       #0x3a7e710 ; 
0065D3158  b        #0x65d316c ; 
0065D315C  ldr      w9, [x10]
0065D3160  add      w9, w9, #0x18
0065D3164  add      x8, x8, w9, sxtw #4
0065D3168  add      x0, x8, #0x138
0065D316C  ldp      x8, x1, [x0]
0065D3170  mov      x0, x23
0065D3174  blr      x8
0065D3178  ldr      x8, [x23]
0065D317C  ldr      x1, [x24]
0065D3180  str      w0, [sp, #0x10]
0065D3184  ldrh     w9, [x8, #0x12e]
0065D3188  cbz      x9, #0x65d31ac
0065D318C  ldr      x10, [x8, #0xb0]
0065D3190  add      x10, x10, #8
0065D3194  ldur     x11, [x10, #-8]
0065D3198  cmp      x11, x1
0065D319C  b.eq     #0x65d31bc
0065D31A0  subs     x9, x9, #1
0065D31A4  add      x10, x10, #0x10
0065D31A8  b.ne     #0x65d3194
0065D31AC  mov      w2, #0x16
0065D31B0  mov      x0, x23
0065D31B4  bl       #0x3a7e710 ; 
0065D31B8  b        #0x65d31cc ; 
0065D31BC  ldr      w9, [x10]
0065D31C0  add      w9, w9, #0x16
0065D31C4  add      x8, x8, w9, sxtw #4
0065D31C8  add      x0, x8, #0x138
0065D31CC  ldp      x8, x1, [x0]
0065D31D0  mov      x0, x23
0065D31D4  blr      x8
0065D31D8  str      wzr, [sp]
0065D31DC  adrp     x24, #0x8f07000
0065D31E0  adrp     x25, #0x8f06000
0065D31E4  ldr      x24, [x24, #0xc98]
0065D31E8  ldr      x25, [x25, #0x470]
0065D31EC  mov      x23, x0
0065D31F0  adrp     x27, #0x9599000
0065D31F4  mov      w28, #1
0065D31F8  and      w8, w29, #1
0065D31FC  str      w8, [sp, #4]
0065D3200  ldrb     w8, [x27, #0x286]
0065D3204  cbnz     w8, #0x65d3214
0065D3208  mov      x0, x24
0065D320C  bl       #0x382bd14 ; 
0065D3210  strb     w28, [x27, #0x286]
0065D3214  ldr      x1, [x24]
0065D3218  ldrb     w8, [x1, #0x53]
0065D321C  tbnz     w8, #5, #0x65d3228
0065D3220  ldr      x0, [x20, #0x80]
0065D3224  b        #0x65d3234 ; 
0065D3228  ldr      x8, [x1, #0x60]
0065D322C  mov      x0, x20
0065D3230  blr      x8
0065D3234  cbz      x23, #0x65d377c
0065D3238  cbz      x0, #0x65d377c
0065D323C  ldr      w2, [x23, #0x18]
0065D3240  mov      w1, wzr
0065D3244  mov      x3, xzr
0065D3248  bl       #0x54b65d8 ; 
0065D324C  ldr      x8, [sp, #0x18]
0065D3250  cbz      x8, #0x65d377c
0065D3254  mov      w19, w0
0065D3258  ldr      x0, [x8, #0x28]
0065D325C  cbz      x0, #0x65d377c
0065D3260  adrp     x9, #0x8ec2000
0065D3264  ldr      w10, [x0, #0x1c]
0065D3268  ldr      x8, [x0, #0x10]
0065D326C  ldr      x9, [x9, #0x260]
0065D3270  add      w10, w10, #1
0065D3274  ldr      x9, [x9]
0065D3278  str      w10, [x0, #0x1c]
0065D327C  cbz      x8, #0x65d377c
0065D3280  ldrsw    x10, [x0, #0x18]
0065D3284  ldr      w11, [x8, #0x18]
0065D3288  cmp      w10, w11
0065D328C  b.hs     #0x65d32a4
0065D3290  add      w9, w10, #1
0065D3294  add      x8, x8, x10, lsl #2
0065D3298  str      w9, [x0, #0x18]
0065D329C  str      w19, [x8, #0x20]
0065D32A0  b        #0x65d32b8 ; 
0065D32A4  ldr      x8, [x9, #0x20]
0065D32A8  mov      w1, w19
0065D32AC  ldr      x8, [x8, #0xc0]
0065D32B0  ldr      x2, [x8, #0x70]
0065D32B4  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0065D32B8  ldr      w8, [x23, #0x18]
0065D32BC  cmp      w19, w8
0065D32C0  b.hs     #0x65d3780
0065D32C4  add      x8, x23, w19, sxtw #2
0065D32C8  ldrb     w9, [x27, #0x286]
0065D32CC  ldr      w19, [x8, #0x20]
0065D32D0  cbnz     w9, #0x65d32e0
0065D32D4  mov      x0, x24
0065D32D8  bl       #0x382bd14 ; 
0065D32DC  strb     w28, [x27, #0x286]
0065D32E0  ldr      x1, [x24]
0065D32E4  ldrb     w8, [x1, #0x53]
0065D32E8  tbnz     w8, #5, #0x65d32f4
0065D32EC  ldr      x22, [x20, #0x80]
0065D32F0  b        #0x65d3304 ; 
0065D32F4  ldr      x8, [x1, #0x60]
0065D32F8  mov      x0, x20
0065D32FC  blr      x8
0065D3300  mov      x22, x0
0065D3304  cbz      x22, #0x65d377c
0065D3308  adrp     x8, #0x9598000
0065D330C  ldrb     w8, [x8, #0xfcc]
0065D3310  cbnz     w8, #0x65d3324
0065D3314  mov      x0, x25
0065D3318  bl       #0x382bd14 ; 
0065D331C  adrp     x8, #0x9598000
0065D3320  strb     w28, [x8, #0xfcc]
0065D3324  ldr      x1, [x25]
0065D3328  ldrb     w8, [x1, #0x53]
0065D332C  tbnz     w8, #5, #0x65d3338
0065D3330  ldr      x0, [x22, #0x200]
0065D3334  b        #0x65d3344 ; 
0065D3338  ldr      x8, [x1, #0x60]
0065D333C  mov      x0, x22
0065D3340  blr      x8
0065D3344  cbz      x0, #0x65d377c
0065D3348  mov      w1, w19
0065D334C  mov      x2, xzr
0065D3350  bl       #0x64e54f0 ; LocalModels.LocalModelManager$$GetMission_RandomMonsterFlushConfig
0065D3354  cbz      x0, #0x65d3200
0065D3358  adrp     x8, #0x9599000
0065D335C  ldrb     w8, [x8, #0x65e]
0065D3360  mov      x19, x0
0065D3364  cbnz     w8, #0x65d337c
0065D3368  adrp     x0, #0x8f0a000
0065D336C  ldr      x0, [x0, #0x988]
0065D3370  bl       #0x382bd14 ; 
0065D3374  adrp     x8, #0x9599000
0065D3378  strb     w28, [x8, #0x65e]
0065D337C  adrp     x8, #0x8f0a000
0065D3380  ldr      x8, [x8, #0x988]
0065D3384  ldr      x1, [x8]
0065D3388  ldrb     w8, [x1, #0x53]
0065D338C  tbnz     w8, #5, #0x65d3398
0065D3390  ldr      x0, [x19, #0x28]
0065D3394  b        #0x65d33a4 ; 
0065D3398  ldr      x8, [x1, #0x60]
0065D339C  mov      x0, x19
0065D33A0  blr      x8
0065D33A4  cbz      x0, #0x65d3710
0065D33A8  adrp     x8, #0x9599000
0065D33AC  ldrb     w8, [x8, #0x65e]
0065D33B0  cbnz     w8, #0x65d33c8
0065D33B4  adrp     x0, #0x8f0a000
0065D33B8  ldr      x0, [x0, #0x988]
0065D33BC  bl       #0x382bd14 ; 
0065D33C0  adrp     x8, #0x9599000
0065D33C4  strb     w28, [x8, #0x65e]
0065D33C8  adrp     x8, #0x8f0a000
0065D33CC  ldr      x8, [x8, #0x988]
0065D33D0  ldr      x1, [x8]
0065D33D4  ldrb     w8, [x1, #0x53]
0065D33D8  tbnz     w8, #5, #0x65d33e4
0065D33DC  ldr      x0, [x19, #0x28]
0065D33E0  b        #0x65d33f0 ; 
0065D33E4  ldr      x8, [x1, #0x60]
0065D33E8  mov      x0, x19
0065D33EC  blr      x8
0065D33F0  cbz      x0, #0x65d377c
0065D33F4  ldr      x8, [x0, #0x18]
0065D33F8  cbz      x8, #0x65d3710
0065D33FC  ldr      w8, [sp]
0065D3400  mov      x26, xzr
0065D3404  mov      w8, w8
0065D3408  str      x8, [sp, #8]
0065D340C  adrp     x8, #0x9599000
0065D3410  ldrb     w8, [x8, #0x65e]
0065D3414  cbnz     w8, #0x65d342c
0065D3418  adrp     x0, #0x8f0a000
0065D341C  ldr      x0, [x0, #0x988]
0065D3420  bl       #0x382bd14 ; 
0065D3424  adrp     x8, #0x9599000
0065D3428  strb     w28, [x8, #0x65e]
0065D342C  adrp     x8, #0x8f0a000
0065D3430  ldr      x8, [x8, #0x988]
0065D3434  ldr      x1, [x8]
0065D3438  ldrb     w8, [x1, #0x53]
0065D343C  tbnz     w8, #5, #0x65d3448
0065D3440  ldr      x0, [x19, #0x28]
0065D3444  b        #0x65d3454 ; 
0065D3448  ldr      x8, [x1, #0x60]
0065D344C  mov      x0, x19
0065D3450  blr      x8
0065D3454  cbz      x0, #0x65d377c
0065D3458  ldrsw    x8, [x0, #0x18]
0065D345C  cmp      x26, x8
0065D3460  b.ge     #0x65d36e8
0065D3464  adrp     x8, #0x9599000
0065D3468  ldrb     w8, [x8, #0x65e]
0065D346C  cbnz     w8, #0x65d3484
0065D3470  adrp     x0, #0x8f0a000
0065D3474  ldr      x0, [x0, #0x988]
0065D3478  bl       #0x382bd14 ; 
0065D347C  adrp     x8, #0x9599000
0065D3480  strb     w28, [x8, #0x65e]
0065D3484  adrp     x8, #0x8f0a000
0065D3488  ldr      x8, [x8, #0x988]
0065D348C  ldr      x1, [x8]
0065D3490  ldrb     w8, [x1, #0x53]
0065D3494  tbnz     w8, #5, #0x65d34a0
0065D3498  ldr      x0, [x19, #0x28]
0065D349C  b        #0x65d34ac ; 
0065D34A0  ldr      x8, [x1, #0x60]
0065D34A4  mov      x0, x19
0065D34A8  blr      x8
0065D34AC  cbz      x0, #0x65d377c
0065D34B0  ldr      w8, [x0, #0x18]
0065D34B4  cmp      x26, x8
0065D34B8  b.hs     #0x65d3780
0065D34BC  add      x8, x0, x26, lsl #2
0065D34C0  ldrb     w9, [x27, #0x286]
0065D34C4  ldr      w22, [x8, #0x20]
0065D34C8  cbnz     w9, #0x65d34d8
0065D34CC  mov      x0, x24
0065D34D0  bl       #0x382bd14 ; 
0065D34D4  strb     w28, [x27, #0x286]
0065D34D8  ldr      x1, [x24]
0065D34DC  ldrb     w8, [x1, #0x53]
0065D34E0  tbnz     w8, #5, #0x65d34ec
0065D34E4  ldr      x29, [x20, #0x80]
0065D34E8  b        #0x65d34fc ; 
0065D34EC  ldr      x8, [x1, #0x60]
0065D34F0  mov      x0, x20
0065D34F4  blr      x8
0065D34F8  mov      x29, x0
0065D34FC  cbz      x29, #0x65d377c
0065D3500  adrp     x8, #0x9598000
0065D3504  ldrb     w8, [x8, #0xfcc]
0065D3508  cbnz     w8, #0x65d351c
0065D350C  mov      x0, x25
0065D3510  bl       #0x382bd14 ; 
0065D3514  adrp     x8, #0x9598000
0065D3518  strb     w28, [x8, #0xfcc]
0065D351C  ldr      x1, [x25]
0065D3520  ldrb     w8, [x1, #0x53]
0065D3524  tbnz     w8, #5, #0x65d3530
0065D3528  ldr      x0, [x29, #0x200]
0065D352C  b        #0x65d353c ; 
0065D3530  ldr      x8, [x1, #0x60]
0065D3534  mov      x0, x29
0065D3538  blr      x8
0065D353C  cbz      x0, #0x65d377c
0065D3540  mov      w1, w22
0065D3544  mov      x2, xzr
0065D3548  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D354C  cbz      x0, #0x65d377c
0065D3550  adrp     x8, #0x9591000
0065D3554  ldrb     w8, [x8, #0xa75]
0065D3558  mov      x22, x0
0065D355C  cbnz     w8, #0x65d3574
0065D3560  adrp     x0, #0x8ee6000
0065D3564  ldr      x0, [x0, #0x290]
0065D3568  bl       #0x382bd14 ; 
0065D356C  adrp     x8, #0x9591000
0065D3570  strb     w28, [x8, #0xa75]
0065D3574  adrp     x8, #0x8ee6000
0065D3578  ldr      x8, [x8, #0x290]
0065D357C  ldr      x1, [x8]
0065D3580  ldrb     w8, [x1, #0x53]
0065D3584  tbnz     w8, #5, #0x65d3590
0065D3588  ldr      w0, [x22, #0x24]
0065D358C  b        #0x65d359c ; 
0065D3590  ldr      x8, [x1, #0x60]
0065D3594  mov      x0, x22
0065D3598  blr      x8
0065D359C  cmp      w0, #0xc9
0065D35A0  b.eq     #0x65d35f4
0065D35A4  adrp     x8, #0x9591000
0065D35A8  ldrb     w8, [x8, #0xa75]
0065D35AC  cbnz     w8, #0x65d35c4
0065D35B0  adrp     x0, #0x8ee6000
0065D35B4  ldr      x0, [x0, #0x290]
0065D35B8  bl       #0x382bd14 ; 
0065D35BC  adrp     x8, #0x9591000
0065D35C0  strb     w28, [x8, #0xa75]
0065D35C4  adrp     x8, #0x8ee6000
0065D35C8  ldr      x8, [x8, #0x290]
0065D35CC  ldr      x1, [x8]
0065D35D0  ldrb     w8, [x1, #0x53]
0065D35D4  tbnz     w8, #5, #0x65d35e0
0065D35D8  ldr      w0, [x22, #0x24]
0065D35DC  b        #0x65d35ec ; 
0065D35E0  ldr      x8, [x1, #0x60]
0065D35E4  mov      x0, x22
0065D35E8  blr      x8
0065D35EC  cmp      w0, #3
0065D35F0  b.ne     #0x65d3604
0065D35F4  cbz      x21, #0x65d377c
0065D35F8  ldr      w8, [x21, #0x14]
0065D35FC  add      w8, w8, #1
0065D3600  str      w8, [x21, #0x14]
0065D3604  adrp     x8, #0x9599000
0065D3608  ldrb     w8, [x8, #0x65d]
0065D360C  cbnz     w8, #0x65d3624
0065D3610  adrp     x0, #0x8f0a000
0065D3614  ldr      x0, [x0, #0xa20]
0065D3618  bl       #0x382bd14 ; 
0065D361C  adrp     x8, #0x9599000
0065D3620  strb     w28, [x8, #0x65d]
0065D3624  adrp     x8, #0x8f0a000
0065D3628  ldr      x8, [x8, #0xa20]
0065D362C  ldr      x1, [x8]
0065D3630  ldrb     w8, [x1, #0x53]
0065D3634  tbnz     w8, #5, #0x65d3640
0065D3638  ldr      w0, [x22, #0x24c]
0065D363C  b        #0x65d364c ; 
0065D3640  ldr      x8, [x1, #0x60]
0065D3644  mov      x0, x22
0065D3648  blr      x8
0065D364C  cmp      w0, #1
0065D3650  b.lt     #0x65d36b8
0065D3654  cbz      x21, #0x65d377c
0065D3658  ldr      w8, [x21, #0x10]
0065D365C  ldr      w29, [x21, #0x18]
0065D3660  add      w8, w8, #1
0065D3664  str      w8, [x21, #0x10]
0065D3668  adrp     x8, #0x9599000
0065D366C  ldrb     w8, [x8, #0x65d]
0065D3670  cbnz     w8, #0x65d3688
0065D3674  adrp     x0, #0x8f0a000
0065D3678  ldr      x0, [x0, #0xa20]
0065D367C  bl       #0x382bd14 ; 
0065D3680  adrp     x8, #0x9599000
0065D3684  strb     w28, [x8, #0x65d]
0065D3688  adrp     x8, #0x8f0a000
0065D368C  ldr      x8, [x8, #0xa20]
0065D3690  ldr      x1, [x8]
0065D3694  ldrb     w8, [x1, #0x53]
0065D3698  tbnz     w8, #5, #0x65d36a4
0065D369C  ldr      w0, [x22, #0x24c]
0065D36A0  b        #0x65d36b0 ; 
0065D36A4  ldr      x8, [x1, #0x60]
0065D36A8  mov      x0, x22
0065D36AC  blr      x8
0065D36B0  add      w8, w0, w29
0065D36B4  str      w8, [x21, #0x18]
0065D36B8  ldr      w2, [sp, #4]
0065D36BC  ldr      w3, [sp, #0x14]
0065D36C0  mov      x0, x20
0065D36C4  mov      x1, x22
0065D36C8  bl       #0x65d3844 ; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
0065D36CC  ldr      x8, [sp, #8]
0065D36D0  ldr      w9, [sp, #0x10]
0065D36D4  add      x26, x26, #1
0065D36D8  add      w8, w8, w26
0065D36DC  cmp      w9, w8
0065D36E0  b.gt     #0x65d340c
0065D36E4  b        #0x65d3758 ; 
0065D36E8  ldr      w9, [sp]
0065D36EC  ldr      w8, [sp, #0x10]
0065D36F0  add      w9, w9, w26
0065D36F4  cmp      w8, w9
0065D36F8  str      w9, [sp]
0065D36FC  b.le     #0x65d3758
0065D3700  ldr      w8, [sp]
0065D3704  cmp      w8, #0x1f5
0065D3708  b.lt     #0x65d3200
0065D370C  b        #0x65d3758 ; 
0065D3710  adrp     x8, #0x8ee1000
0065D3714  ldr      x8, [x8, #0x6e8]
0065D3718  ldr      x0, [x8]
0065D371C  ldr      w8, [x0, #0xe0]
0065D3720  cbnz     w8, #0x65d3728
0065D3724  bl       #0x382be8c ; 
0065D3728  adrp     x8, #0x8f0a000
0065D372C  adrp     x9, #0x8f0a000
0065D3730  adrp     x10, #0x8f0a000
0065D3734  ldr      x8, [x8, #0x980]
0065D3738  ldr      x9, [x9, #0xa60]
0065D373C  ldr      x10, [x10, #0x8b8]
0065D3740  mov      w3, #0x4e9
0065D3744  ldr      x0, [x8]
0065D3748  ldr      x1, [x9]
0065D374C  ldr      x2, [x10]
0065D3750  mov      x4, xzr
0065D3754  bl       #0x7997754 ; Logger$$LogError
0065D3758  mov      x0, x21
0065D375C  ldp      x20, x19, [sp, #0x70]
0065D3760  ldp      x22, x21, [sp, #0x60]
0065D3764  ldp      x24, x23, [sp, #0x50]
0065D3768  ldp      x26, x25, [sp, #0x40]
0065D376C  ldp      x28, x27, [sp, #0x30]
0065D3770  ldp      x29, x30, [sp, #0x20]
0065D3774  add      sp, sp, #0x80
0065D3778  ret      
0065D377C  bl       #0x382bfb8 ; 
0065D3780  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
; RVA 0x65D3784; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D3784  stp      x30, x21, [sp, #-0x20]!
0065D3788  stp      x20, x19, [sp, #0x10]
0065D378C  adrp     x20, #0x9599000
0065D3790  adrp     x21, #0x8f0a000
0065D3794  ldrb     w8, [x20, #0x58f]
0065D3798  ldr      x21, [x21, #0xa68]
0065D379C  mov      x19, x0
0065D37A0  tbnz     w8, #0, #0x65d37b8
0065D37A4  adrp     x0, #0x8f0a000
0065D37A8  ldr      x0, [x0, #0xa68]
0065D37AC  bl       #0x382bd14 ; 
0065D37B0  mov      w8, #1
0065D37B4  strb     w8, [x20, #0x58f]
0065D37B8  ldr      x1, [x21]
0065D37BC  ldrb     w8, [x1, #0x53]
0065D37C0  tbnz     w8, #5, #0x65d3808
0065D37C4  ldr      x19, [x19, #0x140]
0065D37C8  cbz      x19, #0x65d381c
0065D37CC  adrp     x20, #0x9599000
0065D37D0  ldrb     w8, [x20, #0x65f]
0065D37D4  cbnz     w8, #0x65d37ec
0065D37D8  adrp     x0, #0x8f0a000
0065D37DC  ldr      x0, [x0, #0xa70]
0065D37E0  bl       #0x382bd14 ; 
0065D37E4  mov      w8, #1
0065D37E8  strb     w8, [x20, #0x65f]
0065D37EC  adrp     x8, #0x8f0a000
0065D37F0  ldr      x8, [x8, #0xa70]
0065D37F4  ldr      x1, [x8]
0065D37F8  ldrb     w8, [x1, #0x53]
0065D37FC  tbnz     w8, #5, #0x65d3824
0065D3800  ldr      w0, [x19, #0x24]
0065D3804  b        #0x65d3830 ; 
0065D3808  ldr      x2, [x1, #0x60]
0065D380C  mov      x0, x19
0065D3810  ldp      x20, x19, [sp, #0x10]
0065D3814  ldp      x30, x21, [sp], #0x20
0065D3818  br       x2
0065D381C  mov      w0, wzr
0065D3820  b        #0x65d3838 ; 
0065D3824  ldr      x8, [x1, #0x60]
0065D3828  mov      x0, x19
0065D382C  blr      x8
0065D3830  cmp      w0, #1
0065D3834  cset     w0, eq
0065D3838  ldp      x20, x19, [sp, #0x10]
0065D383C  ldp      x30, x21, [sp], #0x20
0065D3840  ret      

; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileGroupMonster
; RVA 0x65CF35C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CF35C  sub      sp, sp, #0xf0
0065CF360  stp      x29, x30, [sp, #0x90]
0065CF364  stp      x28, x27, [sp, #0xa0]
0065CF368  stp      x26, x25, [sp, #0xb0]
0065CF36C  stp      x24, x23, [sp, #0xc0]
0065CF370  stp      x22, x21, [sp, #0xd0]
0065CF374  stp      x20, x19, [sp, #0xe0]
0065CF378  str      x1, [sp, #0x48]
0065CF37C  mrs      x22, tpidr_el0
0065CF380  ldr      x8, [x22, #0x28]
0065CF384  adrp     x19, #0x9599000
0065CF388  adrp     x20, #0x8f0a000
0065CF38C  mov      x21, x0
0065CF390  str      x8, [sp, #0x88]
0065CF394  ldrb     w8, [x19, #0x590]
0065CF398  ldr      x20, [x20, #0x928]
0065CF39C  tbnz     w8, #0, #0x65cf468
0065CF3A0  adrp     x0, #0x8ee8000
0065CF3A4  ldr      x0, [x0, #0x898]
0065CF3A8  bl       #0x382bd14 ; 
0065CF3AC  adrp     x0, #0x8f0a000
0065CF3B0  ldr      x0, [x0, #0x910]
0065CF3B4  bl       #0x382bd14 ; 
0065CF3B8  adrp     x0, #0x8f09000
0065CF3BC  ldr      x0, [x0, #0xc08]
0065CF3C0  bl       #0x382bd14 ; 
0065CF3C4  adrp     x0, #0x8ebf000
0065CF3C8  ldr      x0, [x0, #0xba0]
0065CF3CC  bl       #0x382bd14 ; 
0065CF3D0  adrp     x0, #0x8f0a000
0065CF3D4  ldr      x0, [x0, #0x930]
0065CF3D8  bl       #0x382bd14 ; 
0065CF3DC  adrp     x0, #0x8ee2000
0065CF3E0  ldr      x0, [x0, #0xa58]
0065CF3E4  bl       #0x382bd14 ; 
0065CF3E8  adrp     x0, #0x8f0a000
0065CF3EC  ldr      x0, [x0, #0x938]
0065CF3F0  bl       #0x382bd14 ; 
0065CF3F4  adrp     x0, #0x8f0a000
0065CF3F8  ldr      x0, [x0, #0x940]
0065CF3FC  bl       #0x382bd14 ; 
0065CF400  adrp     x0, #0x8f0a000
0065CF404  ldr      x0, [x0, #0x948]
0065CF408  bl       #0x382bd14 ; 
0065CF40C  adrp     x0, #0x8ee1000
0065CF410  ldr      x0, [x0, #0x6e8]
0065CF414  bl       #0x382bd14 ; 
0065CF418  adrp     x0, #0x8f05000
0065CF41C  ldr      x0, [x0, #0xa78]
0065CF420  bl       #0x382bd14 ; 
0065CF424  adrp     x0, #0x8f0a000
0065CF428  ldr      x0, [x0, #0x928]
0065CF42C  bl       #0x382bd14 ; 
0065CF430  adrp     x0, #0x8f0a000
0065CF434  ldr      x0, [x0, #0x950]
0065CF438  bl       #0x382bd14 ; 
0065CF43C  adrp     x0, #0x8f0a000
0065CF440  ldr      x0, [x0, #0x8b8]
0065CF444  bl       #0x382bd14 ; 
0065CF448  adrp     x0, #0x8f0a000
0065CF44C  ldr      x0, [x0, #0x958]
0065CF450  bl       #0x382bd14 ; 
0065CF454  adrp     x0, #0x8f0a000
0065CF458  ldr      x0, [x0, #0x960]
0065CF45C  bl       #0x382bd14 ; 
0065CF460  mov      w8, #1
0065CF464  strb     w8, [x19, #0x590]
0065CF468  ldr      x2, [x20]
0065CF46C  ldrb     w8, [x2, #0x53]
0065CF470  tbnz     w8, #5, #0x65cf4bc
0065CF474  adrp     x8, #0x9599000
0065CF478  ldrb     w8, [x8, #0x286]
0065CF47C  str      wzr, [sp, #0x6c]
0065CF480  cbnz     w8, #0x65cf49c
0065CF484  adrp     x0, #0x8f07000
0065CF488  ldr      x0, [x0, #0xc98]
0065CF48C  bl       #0x382bd14 ; 
0065CF490  mov      w8, #1
0065CF494  adrp     x9, #0x9599000
0065CF498  strb     w8, [x9, #0x286]
0065CF49C  str      x22, [sp, #8]
0065CF4A0  adrp     x8, #0x8f07000
0065CF4A4  ldr      x8, [x8, #0xc98]
0065CF4A8  ldr      x1, [x8]
0065CF4AC  ldrb     w8, [x1, #0x53]
0065CF4B0  tbnz     w8, #5, #0x65cf4d4
0065CF4B4  ldr      x22, [x21, #0x80]
0065CF4B8  b        #0x65cf4e4 ; 
0065CF4BC  ldr      x8, [x2, #0x60]
0065CF4C0  ldr      x1, [sp, #0x48]
0065CF4C4  mov      x0, x21
0065CF4C8  blr      x8
0065CF4CC  ldr      x8, [x22, #0x28]
0065CF4D0  b        #0x65cff20 ; 
0065CF4D4  ldr      x8, [x1, #0x60]
0065CF4D8  mov      x0, x21
0065CF4DC  blr      x8
0065CF4E0  mov      x22, x0
0065CF4E4  cbz      x22, #0x65cff4c
0065CF4E8  adrp     x19, #0x9591000
0065CF4EC  ldrb     w8, [x19, #0xa9c]
0065CF4F0  cbnz     w8, #0x65cf508
0065CF4F4  adrp     x0, #0x8ee6000
0065CF4F8  ldr      x0, [x0, #0xaf0]
0065CF4FC  bl       #0x382bd14 ; 
0065CF500  mov      w8, #1
0065CF504  strb     w8, [x19, #0xa9c]
0065CF508  adrp     x8, #0x8ee6000
0065CF50C  ldr      x8, [x8, #0xaf0]
0065CF510  ldr      x1, [x8]
0065CF514  ldrb     w8, [x1, #0x53]
0065CF518  tbnz     w8, #5, #0x65cf524
0065CF51C  ldr      x25, [x22, #0x240]
0065CF520  b        #0x65cf534 ; 
0065CF524  ldr      x8, [x1, #0x60]
0065CF528  mov      x0, x22
0065CF52C  blr      x8
0065CF530  mov      x25, x0
0065CF534  ldr      x22, [x21, #0x188]
0065CF538  cbz      x22, #0x65cff4c
0065CF53C  adrp     x10, #0x8f09000
0065CF540  ldr      x8, [x22]
0065CF544  ldr      x10, [x10, #0xc08]
0065CF548  ldrh     w9, [x8, #0x12e]
0065CF54C  ldr      x1, [x10]
0065CF550  cbz      x9, #0x65cf574
0065CF554  ldr      x10, [x8, #0xb0]
0065CF558  add      x10, x10, #8
0065CF55C  ldur     x11, [x10, #-8]
0065CF560  cmp      x11, x1
0065CF564  b.eq     #0x65cf584
0065CF568  subs     x9, x9, #1
0065CF56C  add      x10, x10, #0x10
0065CF570  b.ne     #0x65cf55c
0065CF574  mov      w2, #0x14
0065CF578  mov      x0, x22
0065CF57C  bl       #0x3a7e710 ; 
0065CF580  b        #0x65cf594 ; 
0065CF584  ldr      w9, [x10]
0065CF588  add      w9, w9, #0x14
0065CF58C  add      x8, x8, w9, sxtw #4
0065CF590  add      x0, x8, #0x138
0065CF594  ldp      x8, x1, [x0]
0065CF598  mov      x0, x22
0065CF59C  blr      x8
0065CF5A0  cbz      x0, #0x65cff4c
0065CF5A4  ldr      x24, [x21, #0x188]
0065CF5A8  cbz      x24, #0x65cff4c
0065CF5AC  ldr      x8, [x24]
0065CF5B0  adrp     x10, #0x8f09000
0065CF5B4  ldr      x23, [x21, #0x1f0]
0065CF5B8  mov      x22, x0
0065CF5BC  ldrh     w9, [x8, #0x12e]
0065CF5C0  ldr      x10, [x10, #0xc08]
0065CF5C4  ldr      x1, [x10]
0065CF5C8  cbz      x9, #0x65cf5ec
0065CF5CC  ldr      x10, [x8, #0xb0]
0065CF5D0  add      x10, x10, #8
0065CF5D4  ldur     x11, [x10, #-8]
0065CF5D8  cmp      x11, x1
0065CF5DC  b.eq     #0x65cf5fc
0065CF5E0  subs     x9, x9, #1
0065CF5E4  add      x10, x10, #0x10
0065CF5E8  b.ne     #0x65cf5d4
0065CF5EC  mov      x0, x24
0065CF5F0  mov      w2, wzr
0065CF5F4  bl       #0x3a7e710 ; 
0065CF5F8  b        #0x65cf608 ; 
0065CF5FC  ldrsw    x9, [x10]
0065CF600  add      x8, x8, x9, lsl #4
0065CF604  add      x0, x8, #0x138
0065CF608  ldp      x8, x1, [x0]
0065CF60C  mov      x0, x24
0065CF610  blr      x8
0065CF614  cbz      x23, #0x65cff4c
0065CF618  adrp     x8, #0x8f0a000
0065CF61C  ldr      x8, [x8, #0x910]
0065CF620  mov      w1, w0
0065CF624  mov      x0, x23
0065CF628  ldr      x2, [x8]
0065CF62C  bl       #0x5e5f99c ; System.Collections.Generic.Dictionary<int, object>$$get_Item
0065CF630  ldr      w8, [x22, #0x18]
0065CF634  cmp      w8, #1
0065CF638  b.lt     #0x65cff18
0065CF63C  mov      x24, x0
0065CF640  cbz      x0, #0x65cff4c
0065CF644  adrp     x8, #0x9599000
0065CF648  ldrb     w8, [x8, #0x286]
0065CF64C  ldrsw    x19, [x24, #0x18]
0065CF650  cbnz     w8, #0x65cf66c
0065CF654  adrp     x0, #0x8f07000
0065CF658  ldr      x0, [x0, #0xc98]
0065CF65C  bl       #0x382bd14 ; 
0065CF660  mov      w8, #1
0065CF664  adrp     x9, #0x9599000
0065CF668  strb     w8, [x9, #0x286]
0065CF66C  adrp     x8, #0x8f07000
0065CF670  ldr      x8, [x8, #0xc98]
0065CF674  ldr      x1, [x8]
0065CF678  ldrb     w8, [x1, #0x53]
0065CF67C  tbnz     w8, #5, #0x65cf688
0065CF680  ldr      x23, [x21, #0x80]
0065CF684  b        #0x65cf698 ; 
0065CF688  ldr      x8, [x1, #0x60]
0065CF68C  mov      x0, x21
0065CF690  blr      x8
0065CF694  mov      x23, x0
0065CF698  cbz      x23, #0x65cff4c
0065CF69C  adrp     x8, #0x9598000
0065CF6A0  ldrb     w8, [x8, #0xfcc]
0065CF6A4  cbnz     w8, #0x65cf6c0
0065CF6A8  adrp     x0, #0x8f06000
0065CF6AC  ldr      x0, [x0, #0x470]
0065CF6B0  bl       #0x382bd14 ; 
0065CF6B4  mov      w8, #1
0065CF6B8  adrp     x9, #0x9598000
0065CF6BC  strb     w8, [x9, #0xfcc]
0065CF6C0  adrp     x8, #0x8f06000
0065CF6C4  ldr      x8, [x8, #0x470]
0065CF6C8  ldr      x1, [x8]
0065CF6CC  ldrb     w8, [x1, #0x53]
0065CF6D0  tbnz     w8, #5, #0x65cf6dc
0065CF6D4  ldr      x0, [x23, #0x200]
0065CF6D8  b        #0x65cf6e8 ; 
0065CF6DC  ldr      x8, [x1, #0x60]
0065CF6E0  mov      x0, x23
0065CF6E4  blr      x8
0065CF6E8  ldr      w8, [x22, #0x18]
0065CF6EC  cmp      w19, w8
0065CF6F0  b.hs     #0x65cff50
0065CF6F4  cbz      x0, #0x65cff4c
0065CF6F8  add      x8, x22, x19, lsl #2
0065CF6FC  ldr      w1, [x8, #0x20]
0065CF700  mov      x2, xzr
0065CF704  bl       #0x64d8fd4 ; LocalModels.LocalModelManager$$GetMission_PositionGroupMonsterFlushConfig
0065CF708  cbz      x0, #0x65cff4c
0065CF70C  adrp     x19, #0x9599000
0065CF710  ldrb     w8, [x19, #0x65c]
0065CF714  mov      x22, x0
0065CF718  cbnz     w8, #0x65cf730
0065CF71C  adrp     x0, #0x8f0a000
0065CF720  ldr      x0, [x0, #0x968]
0065CF724  bl       #0x382bd14 ; 
0065CF728  mov      w8, #1
0065CF72C  strb     w8, [x19, #0x65c]
0065CF730  adrp     x8, #0x8f0a000
0065CF734  ldr      x8, [x8, #0x968]
0065CF738  ldr      x1, [x8]
0065CF73C  ldrb     w8, [x1, #0x53]
0065CF740  tbnz     w8, #5, #0x65cf74c
0065CF744  ldr      x22, [x22, #0x28]
0065CF748  b        #0x65cf75c ; 
0065CF74C  ldr      x8, [x1, #0x60]
0065CF750  mov      x0, x22
0065CF754  blr      x8
0065CF758  mov      x22, x0
0065CF75C  adrp     x8, #0x8ee2000
0065CF760  ldr      x8, [x8, #0xa58]
0065CF764  ldr      x0, [x8]
0065CF768  ldr      w8, [x0, #0xe0]
0065CF76C  cbnz     w8, #0x65cf774
0065CF770  bl       #0x382be8c ; 
0065CF774  adrp     x8, #0x8f0a000
0065CF778  ldr      x8, [x8, #0x930]
0065CF77C  mov      x0, x22
0065CF780  ldr      x1, [x8]
0065CF784  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
0065CF788  cbz      x0, #0x65cff4c
0065CF78C  ldr      w8, [x0, #0x18]
0065CF790  mov      x26, x0
0065CF794  cmp      w8, #1
0065CF798  b.lt     #0x65cff18
0065CF79C  adrp     x28, #0x8f0a000
0065CF7A0  adrp     x19, #0x8f0a000
0065CF7A4  ldr      x28, [x28, #0x948]
0065CF7A8  ldr      x19, [x19, #0x940]
0065CF7AC  mov      w27, wzr
0065CF7B0  mov      w20, #0x258
0065CF7B4  stp      x24, x25, [sp, #0x10]
0065CF7B8  str      x26, [sp, #0x40]
0065CF7BC  ldr      x0, [x24, #0x20]
0065CF7C0  cbz      x0, #0x65cff4c
0065CF7C4  ldr      x2, [x28]
0065CF7C8  mov      w1, w27
0065CF7CC  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CF7D0  ldr      x2, [x19]
0065CF7D4  mov      x22, x0
0065CF7D8  mov      x0, x26
0065CF7DC  mov      w1, w27
0065CF7E0  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CF7E4  cbz      x0, #0x65cff4c
0065CF7E8  ldr      w8, [x0, #0x10]
0065CF7EC  ldr      x2, [x19]
0065CF7F0  mov      x0, x26
0065CF7F4  mov      w1, w27
0065CF7F8  str      w8, [sp, #0x6c]
0065CF7FC  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CF800  cbz      x0, #0x65cff4c
0065CF804  cbz      x22, #0x65cff4c
0065CF808  ldr      x8, [x0, #0x18]
0065CF80C  cbz      x8, #0x65cff4c
0065CF810  ldrsw    x9, [x22, #0x14]
0065CF814  ldr      w10, [x8, #0x18]
0065CF818  cmp      w9, w10
0065CF81C  b.hs     #0x65cff50
0065CF820  add      x8, x8, x9, lsl #2
0065CF824  adrp     x9, #0x9599000
0065CF828  ldrb     w9, [x9, #0x286]
0065CF82C  ldr      w8, [x8, #0x20]
0065CF830  str      w8, [sp, #0x68]
0065CF834  cbnz     w9, #0x65cf850
0065CF838  adrp     x0, #0x8f07000
0065CF83C  ldr      x0, [x0, #0xc98]
0065CF840  bl       #0x382bd14 ; 
0065CF844  adrp     x8, #0x9599000
0065CF848  mov      w9, #1
0065CF84C  strb     w9, [x8, #0x286]
0065CF850  adrp     x8, #0x8f07000
0065CF854  ldr      x8, [x8, #0xc98]
0065CF858  ldr      x1, [x8]
0065CF85C  ldrb     w8, [x1, #0x53]
0065CF860  tbnz     w8, #5, #0x65cf86c
0065CF864  ldr      x23, [x21, #0x80]
0065CF868  b        #0x65cf87c ; 
0065CF86C  ldr      x8, [x1, #0x60]
0065CF870  mov      x0, x21
0065CF874  blr      x8
0065CF878  mov      x23, x0
0065CF87C  cbz      x23, #0x65cff4c
0065CF880  adrp     x8, #0x9598000
0065CF884  ldrb     w8, [x8, #0xfcc]
0065CF888  cbnz     w8, #0x65cf8a4
0065CF88C  adrp     x0, #0x8f06000
0065CF890  ldr      x0, [x0, #0x470]
0065CF894  bl       #0x382bd14 ; 
0065CF898  adrp     x8, #0x9598000
0065CF89C  mov      w9, #1
0065CF8A0  strb     w9, [x8, #0xfcc]
0065CF8A4  adrp     x8, #0x8f06000
0065CF8A8  ldr      x8, [x8, #0x470]
0065CF8AC  ldr      x1, [x8]
0065CF8B0  ldrb     w8, [x1, #0x53]
0065CF8B4  tbnz     w8, #5, #0x65cf8c0
0065CF8B8  ldr      x0, [x23, #0x200]
0065CF8BC  b        #0x65cf8cc ; 
0065CF8C0  ldr      x8, [x1, #0x60]
0065CF8C4  mov      x0, x23
0065CF8C8  blr      x8
0065CF8CC  cbz      x0, #0x65cff4c
0065CF8D0  ldr      w1, [sp, #0x6c]
0065CF8D4  mov      x2, xzr
0065CF8D8  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065CF8DC  cbz      x0, #0x65cfea8
0065CF8E0  adrp     x8, #0x9599000
0065CF8E4  ldrb     w8, [x8, #0x657]
0065CF8E8  mov      x23, x0
0065CF8EC  cbnz     w8, #0x65cf908
0065CF8F0  adrp     x0, #0x8f0a000
0065CF8F4  ldr      x0, [x0, #0x8d0]
0065CF8F8  bl       #0x382bd14 ; 
0065CF8FC  mov      w8, #1
0065CF900  adrp     x9, #0x9599000
0065CF904  strb     w8, [x9, #0x657]
0065CF908  adrp     x8, #0x8f0a000
0065CF90C  ldr      x8, [x8, #0x8d0]
0065CF910  ldr      x1, [x8]
0065CF914  ldrb     w8, [x1, #0x53]
0065CF918  tbnz     w8, #5, #0x65cf924
0065CF91C  ldr      x0, [x23, #0x28]
0065CF920  b        #0x65cf930 ; 
0065CF924  ldr      x8, [x1, #0x60]
0065CF928  mov      x0, x23
0065CF92C  blr      x8
0065CF930  cbz      x0, #0x65cff4c
0065CF934  ldr      w8, [x0, #0x18]
0065CF938  cmp      w8, #1
0065CF93C  b.lt     #0x65cfe94
0065CF940  cbz      x25, #0x65cff4c
0065CF944  adrp     x8, #0x9599000
0065CF948  ldrb     w8, [x8, #0x26f]
0065CF94C  ldrsw    x19, [x22, #0x10]
0065CF950  cbnz     w8, #0x65cf96c
0065CF954  adrp     x0, #0x8f06000
0065CF958  ldr      x0, [x0, #0xd58]
0065CF95C  bl       #0x382bd14 ; 
0065CF960  mov      w8, #1
0065CF964  adrp     x9, #0x9599000
0065CF968  strb     w8, [x9, #0x26f]
0065CF96C  adrp     x8, #0x8f06000
0065CF970  ldr      x8, [x8, #0xd58]
0065CF974  ldr      x1, [x8]
0065CF978  ldrb     w8, [x1, #0x53]
0065CF97C  tbnz     w8, #5, #0x65cf988
0065CF980  ldr      x0, [x25, #0x20]
0065CF984  b        #0x65cf994 ; 
0065CF988  ldr      x8, [x1, #0x60]
0065CF98C  mov      x0, x25
0065CF990  blr      x8
0065CF994  cbz      x0, #0x65cff4c
0065CF998  ldr      x8, [x0, #0x140]
0065CF99C  cbz      x8, #0x65cff4c
0065CF9A0  ldr      w9, [x8, #0x18]
0065CF9A4  cmp      w19, w9
0065CF9A8  b.hs     #0x65cff50
0065CF9AC  add      x8, x8, x19, lsl #4
0065CF9B0  ldr      x23, [x8, #0x28]
0065CF9B4  cbz      x23, #0x65cff4c
0065CF9B8  ldr      x8, [x23, #0x18]
0065CF9BC  cmp      w8, #1
0065CF9C0  mov      x29, x8
0065CF9C4  b.lt     #0x65cf9e0
0065CF9C8  ldr      x12, [x23, #0x38]
0065CF9CC  b.ne     #0x65cf9f0
0065CF9D0  adrp     x11, #0x8f05000
0065CF9D4  ldr      x11, [x11, #0xa78]
0065CF9D8  mov      x19, x12
0065CF9DC  b        #0x65cfa24 ; 
0065CF9E0  str      xzr, [sp, #0x50]
0065CF9E4  mov      x19, xzr
0065CF9E8  str      xzr, [sp, #0x28]
0065CF9EC  b        #0x65cfa68 ; 
0065CF9F0  adrp     x11, #0x8f05000
0065CF9F4  ldr      x11, [x11, #0xa78]
0065CF9F8  and      x9, x8, #0xffffffff
0065CF9FC  add      x8, x23, #0x70
0065CFA00  sub      x9, x9, #1
0065CFA04  mov      x19, x12
0065CFA08  ldr      x10, [x8], #0x38
0065CFA0C  cmp      x10, x12
0065CFA10  csel     x12, x10, x12, lt
0065CFA14  cmp      x10, x19
0065CFA18  csel     x19, x10, x19, gt
0065CFA1C  subs     x9, x9, #1
0065CFA20  b.ne     #0x65cfa08
0065CFA24  ldr      x8, [x25, #0x10]
0065CFA28  cbz      x8, #0x65cff4c
0065CFA2C  ldr      x0, [x11]
0065CFA30  ldr      x8, [x8, #0x20]
0065CFA34  str      x12, [sp, #0x50]
0065CFA38  ldr      w9, [x0, #0xe0]
0065CFA3C  subs     x8, x12, x8
0065CFA40  cneg     x20, x8, mi
0065CFA44  cbnz     w9, #0x65cfa54
0065CFA48  mov      x22, x11
0065CFA4C  bl       #0x382be8c ; 
0065CFA50  ldr      x0, [x22]
0065CFA54  ldr      x8, [x0, #0xb8]
0065CFA58  ldr      x8, [x8, #0x10]
0065CFA5C  add      x8, x8, x20
0065CFA60  mov      w20, #0x258
0065CFA64  str      x8, [sp, #0x28]
0065CFA68  ldr      w8, [x21, #0xa8]
0065CFA6C  add      w9, w8, w29
0065CFA70  cmp      w9, #0x259
0065CFA74  b.lt     #0x65cfafc
0065CFA78  adrp     x8, #0x8ebf000
0065CFA7C  ldr      x8, [x8, #0xba0]
0065CFA80  add      x1, sp, #0x70
0065CFA84  str      w20, [sp, #0x70]
0065CFA88  ldr      x0, [x8]
0065CFA8C  bl       #0x382be94 ; 
0065CFA90  adrp     x8, #0x8f0a000
0065CFA94  ldr      x8, [x8, #0x958]
0065CFA98  mov      x1, x0
0065CFA9C  mov      x2, xzr
0065CFAA0  ldr      x8, [x8]
0065CFAA4  mov      x0, x8
0065CFAA8  bl       #0x79d140c ; System.String$$Format
0065CFAAC  adrp     x8, #0x8ee1000
0065CFAB0  ldr      x8, [x8, #0x6e8]
0065CFAB4  mov      x22, x0
0065CFAB8  ldr      x8, [x8]
0065CFABC  ldr      w9, [x8, #0xe0]
0065CFAC0  cbnz     w9, #0x65cfacc
0065CFAC4  mov      x0, x8
0065CFAC8  bl       #0x382be8c ; 
0065CFACC  adrp     x8, #0x8f0a000
0065CFAD0  ldr      x8, [x8, #0x960]
0065CFAD4  mov      w3, #0x559
0065CFAD8  mov      x0, x22
0065CFADC  mov      x4, xzr
0065CFAE0  ldr      x1, [x8]
0065CFAE4  adrp     x8, #0x8f0a000
0065CFAE8  ldr      x8, [x8, #0x8b8]
0065CFAEC  ldr      x2, [x8]
0065CFAF0  bl       #0x7997754 ; Logger$$LogError
0065CFAF4  ldr      w8, [x21, #0xa8]
0065CFAF8  sub      w29, w20, w8
0065CFAFC  cmp      w29, #1
0065CFB00  b.lt     #0x65cfe84
0065CFB04  mov      x26, xzr
0065CFB08  mov      w8, w29
0065CFB0C  str      w27, [sp, #0x5c]
0065CFB10  str      x29, [sp, #0x20]
0065CFB14  stp      x8, x23, [sp, #0x30]
0065CFB18  ldr      x28, [x21, #0xa0]
0065CFB1C  cbz      x28, #0x65cff4c
0065CFB20  ldr      w8, [x21, #0xa8]
0065CFB24  ldr      w9, [x28, #0x18]
0065CFB28  add      w20, w8, w26
0065CFB2C  cmp      w20, w9
0065CFB30  b.hs     #0x65cff50
0065CFB34  ldr      w8, [x23, #0x18]
0065CFB38  cmp      x26, x8
0065CFB3C  b.hs     #0x65cff50
0065CFB40  ldr      x29, [x21, #0x188]
0065CFB44  cbz      x29, #0x65cff4c
0065CFB48  mov      w8, #0x38
0065CFB4C  madd     x9, x26, x8, x23
0065CFB50  ldp      x24, x10, [x9, #0x38]
0065CFB54  ldr      x8, [x29]
0065CFB58  mov      x27, x21
0065CFB5C  ldp      x22, x23, [x9, #0x28]
0065CFB60  str      x10, [sp, #0x60]
0065CFB64  adrp     x10, #0x8f09000
0065CFB68  ldp      x21, x25, [x9, #0x48]
0065CFB6C  ldrh     w9, [x8, #0x12e]
0065CFB70  ldr      x10, [x10, #0xc08]
0065CFB74  ldr      x1, [x10]
0065CFB78  cbz      x9, #0x65cfb9c
0065CFB7C  ldr      x10, [x8, #0xb0]
0065CFB80  add      x10, x10, #8
0065CFB84  ldur     x11, [x10, #-8]
0065CFB88  cmp      x11, x1
0065CFB8C  b.eq     #0x65cfbac
0065CFB90  subs     x9, x9, #1
0065CFB94  add      x10, x10, #0x10
0065CFB98  b.ne     #0x65cfb84
0065CFB9C  mov      w2, #6
0065CFBA0  mov      x0, x29
0065CFBA4  bl       #0x3a7e710 ; 
0065CFBA8  b        #0x65cfbbc ; 
0065CFBAC  ldr      w9, [x10]
0065CFBB0  add      w9, w9, #6
0065CFBB4  add      x8, x8, w9, sxtw #4
0065CFBB8  add      x0, x8, #0x138
0065CFBBC  ldp      x8, x1, [x0]
0065CFBC0  mov      x0, x29
0065CFBC4  blr      x8
0065CFBC8  adrp     x8, #0x8f0a000
0065CFBCC  ldr      x8, [x8, #0x940]
0065CFBD0  mov      x29, x0
0065CFBD4  ldr      x0, [sp, #0x40]
0065CFBD8  ldr      w1, [sp, #0x5c]
0065CFBDC  ldr      x2, [x8]
0065CFBE0  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CFBE4  cbz      x0, #0x65cff4c
0065CFBE8  ldr      x9, [sp, #0x48]
0065CFBEC  ldr      x8, [x0, #0x20]
0065CFBF0  sxtw     x20, w20
0065CFBF4  add      x9, x21, x9
0065CFBF8  add      x9, x9, x29
0065CFBFC  add      x8, x9, x8
0065CFC00  add      x21, x28, x20, lsl #7
0065CFC04  str      x8, [x21, #0x20]
0065CFC08  adrp     x29, #0x8ee8000
0065CFC0C  ldr      x29, [x29, #0x898]
0065CFC10  ldr      x0, [x29]
0065CFC14  ldr      w8, [x0, #0xe0]
0065CFC18  cbnz     w8, #0x65cfc24
0065CFC1C  bl       #0x382be8c ; 
0065CFC20  ldr      x0, [x29]
0065CFC24  ldr      x8, [x0, #0xb8]
0065CFC28  ldr      x8, [x8, #0xb0]
0065CFC2C  str      x8, [x21, #0x28]
0065CFC30  adrp     x8, #0x9599000
0065CFC34  ldrb     w8, [x8, #0x286]
0065CFC38  cbnz     w8, #0x65cfc54
0065CFC3C  adrp     x0, #0x8f07000
0065CFC40  ldr      x0, [x0, #0xc98]
0065CFC44  bl       #0x382bd14 ; 
0065CFC48  adrp     x8, #0x9599000
0065CFC4C  mov      w9, #1
0065CFC50  strb     w9, [x8, #0x286]
0065CFC54  adrp     x8, #0x8f07000
0065CFC58  ldr      x8, [x8, #0xc98]
0065CFC5C  ldr      x1, [x8]
0065CFC60  ldrb     w8, [x1, #0x53]
0065CFC64  tbnz     w8, #5, #0x65cfc70
0065CFC68  ldr      x29, [x27, #0x80]
0065CFC6C  b        #0x65cfc80 ; 
0065CFC70  ldr      x8, [x1, #0x60]
0065CFC74  mov      x0, x27
0065CFC78  blr      x8
0065CFC7C  mov      x29, x0
0065CFC80  cbz      x29, #0x65cff4c
0065CFC84  adrp     x8, #0x9598000
0065CFC88  ldrb     w8, [x8, #0xfcc]
0065CFC8C  cbnz     w8, #0x65cfca8
0065CFC90  adrp     x0, #0x8f06000
0065CFC94  ldr      x0, [x0, #0x470]
0065CFC98  bl       #0x382bd14 ; 
0065CFC9C  adrp     x8, #0x9598000
0065CFCA0  mov      w9, #1
0065CFCA4  strb     w9, [x8, #0xfcc]
0065CFCA8  adrp     x8, #0x8f06000
0065CFCAC  ldr      x8, [x8, #0x470]
0065CFCB0  ldr      x1, [x8]
0065CFCB4  ldrb     w8, [x1, #0x53]
0065CFCB8  tbnz     w8, #5, #0x65cfcc4
0065CFCBC  ldr      x0, [x29, #0x200]
0065CFCC0  b        #0x65cfcd0 ; 
0065CFCC4  ldr      x8, [x1, #0x60]
0065CFCC8  mov      x0, x29
0065CFCCC  blr      x8
0065CFCD0  cbz      x0, #0x65cff4c
0065CFCD4  ldr      w1, [sp, #0x68]
0065CFCD8  mov      x2, xzr
0065CFCDC  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065CFCE0  mov      x29, x0
0065CFCE4  cbz      x0, #0x65cfd4c
0065CFCE8  adrp     x8, #0x9599000
0065CFCEC  ldrb     w8, [x8, #0x29e]
0065CFCF0  cbnz     w8, #0x65cfd0c
0065CFCF4  adrp     x0, #0x8f08000
0065CFCF8  ldr      x0, [x0, #0x90]
0065CFCFC  bl       #0x382bd14 ; 
0065CFD00  mov      w8, #1
0065CFD04  adrp     x9, #0x9599000
0065CFD08  strb     w8, [x9, #0x29e]
0065CFD0C  adrp     x8, #0x8f08000
0065CFD10  ldr      x8, [x8, #0x90]
0065CFD14  ldr      x1, [x8]
0065CFD18  ldrb     w8, [x1, #0x53]
0065CFD1C  tbnz     w8, #5, #0x65cfd28
0065CFD20  ldr      w0, [x29, #0x120]
0065CFD24  b        #0x65cfd34 ; 
0065CFD28  ldr      x8, [x1, #0x60]
0065CFD2C  mov      x0, x29
0065CFD30  blr      x8
0065CFD34  cmp      w0, #1
0065CFD38  b.ne     #0x65cfd4c
0065CFD3C  add      x8, x28, x20, lsl #7
0065CFD40  stp      x22, x23, [x8, #0x30]
0065CFD44  str      x24, [x8, #0x40]
0065CFD48  b        #0x65cfd84 ; 
0065CFD4C  ldr      x8, [sp, #0x28]
0065CFD50  add      x0, sp, #0x70
0065CFD54  mov      x1, x22
0065CFD58  mov      x2, x23
0065CFD5C  add      x3, x24, x8
0065CFD60  mov      x4, xzr
0065CFD64  stp      xzr, xzr, [sp, #0x70]
0065CFD68  str      xzr, [sp, #0x80]
0065CFD6C  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065CFD70  ldr      x8, [sp, #0x80]
0065CFD74  ldr      q0, [sp, #0x70]
0065CFD78  add      x9, x28, x20, lsl #7
0065CFD7C  str      x8, [x9, #0x40]
0065CFD80  str      q0, [x9, #0x30]
0065CFD84  ldr      w8, [sp, #0x68]
0065CFD88  add      x21, x28, x20, lsl #7
0065CFD8C  str      x25, [x21, #0x70]!
0065CFD90  mov      x0, x21
0065CFD94  stur     w8, [x21, #-0x10]
0065CFD98  ldr      x8, [sp, #0x60]
0065CFD9C  mov      x1, x25
0065CFDA0  str      wzr, [x21, #0x10]
0065CFDA4  stp      x22, x23, [x21, #-0x28]
0065CFDA8  stur     x24, [x21, #-0x18]
0065CFDAC  stur     x8, [x21, #-8]
0065CFDB0  bl       #0x382bcb8 ; 
0065CFDB4  ldr      x9, [sp, #0x50]
0065CFDB8  sub      x8, x24, x19
0065CFDBC  str      xzr, [x21, #8]
0065CFDC0  sub      x9, x24, x9
0065CFDC4  stp      x8, x9, [x21, #0x18]
0065CFDC8  ldr      x22, [x27, #0x188]
0065CFDCC  cbz      x22, #0x65cff4c
0065CFDD0  ldr      x8, [x22]
0065CFDD4  adrp     x10, #0x8f09000
0065CFDD8  mov      x21, x27
0065CFDDC  ldrh     w9, [x8, #0x12e]
0065CFDE0  ldr      x10, [x10, #0xc08]
0065CFDE4  ldr      x23, [sp, #0x38]
0065CFDE8  ldr      x1, [x10]
0065CFDEC  cbz      x9, #0x65cfe10
0065CFDF0  ldr      x10, [x8, #0xb0]
0065CFDF4  add      x10, x10, #8
0065CFDF8  ldur     x11, [x10, #-8]
0065CFDFC  cmp      x11, x1
0065CFE00  b.eq     #0x65cfe20
0065CFE04  subs     x9, x9, #1
0065CFE08  add      x10, x10, #0x10
0065CFE0C  b.ne     #0x65cfdf8
0065CFE10  mov      x0, x22
0065CFE14  mov      w2, wzr
0065CFE18  bl       #0x3a7e710 ; 
0065CFE1C  b        #0x65cfe2c ; 
0065CFE20  ldrsw    x9, [x10]
0065CFE24  add      x8, x8, x9, lsl #4
0065CFE28  add      x0, x8, #0x138
0065CFE2C  ldp      x8, x1, [x0]
0065CFE30  mov      x0, x22
0065CFE34  blr      x8
0065CFE38  add      x20, x28, x20, lsl #7
0065CFE3C  str      w0, [x20, #0x98]
0065CFE40  mov      x0, x21
0065CFE44  mov      x1, x29
0065CFE48  bl       #0x65d0b58 ; HotFix.BattleLogic.WaterfallBattleManager$$AddGoldMonster
0065CFE4C  ldr      x9, [sp, #0x30]
0065CFE50  add      x26, x26, #1
0065CFE54  and      w8, w0, #1
0065CFE58  strb     w8, [x20, #0x9c]
0065CFE5C  cmp      x26, x9
0065CFE60  b.ne     #0x65cfb18
0065CFE64  adrp     x28, #0x8f0a000
0065CFE68  ldr      w8, [x21, #0xa8]
0065CFE6C  ldp      x24, x25, [sp, #0x10]
0065CFE70  ldr      x26, [sp, #0x40]
0065CFE74  ldr      w27, [sp, #0x5c]
0065CFE78  ldr      x28, [x28, #0x948]
0065CFE7C  ldr      x29, [sp, #0x20]
0065CFE80  mov      w20, #0x258
0065CFE84  add      w8, w8, w29
0065CFE88  str      w8, [x21, #0xa8]
0065CFE8C  adrp     x19, #0x8f0a000
0065CFE90  ldr      x19, [x19, #0x940]
0065CFE94  ldr      w8, [x26, #0x18]
0065CFE98  add      w27, w27, #1
0065CFE9C  cmp      w27, w8
0065CFEA0  b.lt     #0x65cf7bc
0065CFEA4  b        #0x65cff18 ; 
0065CFEA8  add      x0, sp, #0x6c
0065CFEAC  mov      x1, xzr
0065CFEB0  bl       #0x7bd22a0 ; System.Int32$$ToString
0065CFEB4  adrp     x8, #0x8f0a000
0065CFEB8  ldr      x8, [x8, #0x950]
0065CFEBC  mov      x1, x0
0065CFEC0  mov      x2, xzr
0065CFEC4  ldr      x8, [x8]
0065CFEC8  mov      x0, x8
0065CFECC  bl       #0x79d469c ; System.String$$Concat
0065CFED0  adrp     x8, #0x8ee1000
0065CFED4  ldr      x8, [x8, #0x6e8]
0065CFED8  mov      x19, x0
0065CFEDC  ldr      x8, [x8]
0065CFEE0  ldr      w9, [x8, #0xe0]
0065CFEE4  cbnz     w9, #0x65cfef0
0065CFEE8  mov      x0, x8
0065CFEEC  bl       #0x382be8c ; 
0065CFEF0  adrp     x8, #0x8f0a000
0065CFEF4  ldr      x8, [x8, #0x960]
0065CFEF8  mov      w3, #0x531
0065CFEFC  mov      x0, x19
0065CFF00  mov      x4, xzr
0065CFF04  ldr      x1, [x8]
0065CFF08  adrp     x8, #0x8f0a000
0065CFF0C  ldr      x8, [x8, #0x8b8]
0065CFF10  ldr      x2, [x8]
0065CFF14  bl       #0x7997754 ; Logger$$LogError
0065CFF18  ldr      x8, [sp, #8]
0065CFF1C  ldr      x8, [x8, #0x28]
0065CFF20  ldr      x9, [sp, #0x88]
0065CFF24  cmp      x8, x9
0065CFF28  b.ne     #0x65cff54
0065CFF2C  ldp      x20, x19, [sp, #0xe0]
0065CFF30  ldp      x22, x21, [sp, #0xd0]
0065CFF34  ldp      x24, x23, [sp, #0xc0]
0065CFF38  ldp      x26, x25, [sp, #0xb0]
0065CFF3C  ldp      x28, x27, [sp, #0xa0]
0065CFF40  ldp      x29, x30, [sp, #0x90]
0065CFF44  add      sp, sp, #0xf0
0065CFF48  ret      
0065CFF4C  bl       #0x382bfb8 ; 
0065CFF50  bl       #0x382bfc0 ; 
0065CFF54  bl       #0x89edb60 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CreateRandomMonster
; RVA 0x65CFF58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CFF58  sub      sp, sp, #0x100
0065CFF5C  stp      x29, x30, [sp, #0xa0]
0065CFF60  stp      x28, x27, [sp, #0xb0]
0065CFF64  stp      x26, x25, [sp, #0xc0]
0065CFF68  stp      x24, x23, [sp, #0xd0]
0065CFF6C  stp      x22, x21, [sp, #0xe0]
0065CFF70  stp      x20, x19, [sp, #0xf0]
0065CFF74  str      x1, [sp, #0x40]
0065CFF78  mrs      x22, tpidr_el0
0065CFF7C  ldr      x8, [x22, #0x28]
0065CFF80  adrp     x20, #0x9599000
0065CFF84  adrp     x19, #0x8f0a000
0065CFF88  mov      x21, x0
0065CFF8C  str      x8, [sp, #0x98]
0065CFF90  ldrb     w8, [x20, #0x591]
0065CFF94  ldr      x19, [x19, #0x970]
0065CFF98  tbnz     w8, #0, #0x65d001c
0065CFF9C  adrp     x0, #0x8ee8000
0065CFFA0  ldr      x0, [x0, #0x898]
0065CFFA4  bl       #0x382bd14 ; 
0065CFFA8  adrp     x0, #0x8f0a000
0065CFFAC  ldr      x0, [x0, #0x910]
0065CFFB0  bl       #0x382bd14 ; 
0065CFFB4  adrp     x0, #0x8f09000
0065CFFB8  ldr      x0, [x0, #0xc08]
0065CFFBC  bl       #0x382bd14 ; 
0065CFFC0  adrp     x0, #0x8ec2000
0065CFFC4  ldr      x0, [x0, #0x270]
0065CFFC8  bl       #0x382bd14 ; 
0065CFFCC  adrp     x0, #0x8ee1000
0065CFFD0  ldr      x0, [x0, #0x6e8]
0065CFFD4  bl       #0x382bd14 ; 
0065CFFD8  adrp     x0, #0x8f0a000
0065CFFDC  ldr      x0, [x0, #0x970]
0065CFFE0  bl       #0x382bd14 ; 
0065CFFE4  adrp     x0, #0x8f0a000
0065CFFE8  ldr      x0, [x0, #0x918]
0065CFFEC  bl       #0x382bd14 ; 
0065CFFF0  adrp     x0, #0x8f0a000
0065CFFF4  ldr      x0, [x0, #0x8b8]
0065CFFF8  bl       #0x382bd14 ; 
0065CFFFC  adrp     x0, #0x8f0a000
0065D0000  ldr      x0, [x0, #0x978]
0065D0004  bl       #0x382bd14 ; 
0065D0008  adrp     x0, #0x8f0a000
0065D000C  ldr      x0, [x0, #0x980]
0065D0010  bl       #0x382bd14 ; 
0065D0014  mov      w8, #1
0065D0018  strb     w8, [x20, #0x591]
0065D001C  ldr      x2, [x19]
0065D0020  ldrb     w8, [x2, #0x53]
0065D0024  tbnz     w8, #5, #0x65d0080
0065D0028  stp      xzr, xzr, [sp, #0x80]
0065D002C  str      xzr, [sp, #0x90]
0065D0030  ldr      x20, [x21, #0x188]
0065D0034  cbz      x20, #0x65d0b4c
0065D0038  adrp     x10, #0x8f09000
0065D003C  ldr      x8, [x20]
0065D0040  ldr      x10, [x10, #0xc08]
0065D0044  ldrh     w9, [x8, #0x12e]
0065D0048  ldr      x1, [x10]
0065D004C  cbz      x9, #0x65d0070
0065D0050  ldr      x10, [x8, #0xb0]
0065D0054  add      x10, x10, #8
0065D0058  ldur     x11, [x10, #-8]
0065D005C  cmp      x11, x1
0065D0060  b.eq     #0x65d0094
0065D0064  subs     x9, x9, #1
0065D0068  add      x10, x10, #0x10
0065D006C  b.ne     #0x65d0058
0065D0070  mov      w2, #0x18
0065D0074  mov      x0, x20
0065D0078  bl       #0x3a7e710 ; 
0065D007C  b        #0x65d00a4 ; 
0065D0080  ldr      x8, [x2, #0x60]
0065D0084  ldr      x1, [sp, #0x40]
0065D0088  mov      x0, x21
0065D008C  blr      x8
0065D0090  b        #0x65d0b1c ; 
0065D0094  ldr      w9, [x10]
0065D0098  add      w9, w9, #0x18
0065D009C  add      x8, x8, w9, sxtw #4
0065D00A0  add      x0, x8, #0x138
0065D00A4  ldp      x8, x1, [x0]
0065D00A8  mov      x0, x20
0065D00AC  blr      x8
0065D00B0  cmp      w0, #1
0065D00B4  b.lt     #0x65d0b1c
0065D00B8  ldr      x20, [x21, #0x188]
0065D00BC  cbz      x20, #0x65d0b4c
0065D00C0  ldr      x8, [x20]
0065D00C4  adrp     x10, #0x8f09000
0065D00C8  ldrh     w9, [x8, #0x12e]
0065D00CC  ldr      x10, [x10, #0xc08]
0065D00D0  ldr      x1, [x10]
0065D00D4  cbz      x9, #0x65d00f8
0065D00D8  ldr      x10, [x8, #0xb0]
0065D00DC  add      x10, x10, #8
0065D00E0  ldur     x11, [x10, #-8]
0065D00E4  cmp      x11, x1
0065D00E8  b.eq     #0x65d0108
0065D00EC  subs     x9, x9, #1
0065D00F0  add      x10, x10, #0x10
0065D00F4  b.ne     #0x65d00e0
0065D00F8  mov      w2, #0x16
0065D00FC  mov      x0, x20
0065D0100  bl       #0x3a7e710 ; 
0065D0104  b        #0x65d0118 ; 
0065D0108  ldr      w9, [x10]
0065D010C  add      w9, w9, #0x16
0065D0110  add      x8, x8, w9, sxtw #4
0065D0114  add      x0, x8, #0x138
0065D0118  ldp      x8, x1, [x0]
0065D011C  mov      x0, x20
0065D0120  blr      x8
0065D0124  cbz      x0, #0x65d0b1c
0065D0128  ldr      x20, [x21, #0x188]
0065D012C  cbz      x20, #0x65d0b4c
0065D0130  ldr      x8, [x20]
0065D0134  adrp     x10, #0x8f09000
0065D0138  ldrh     w9, [x8, #0x12e]
0065D013C  ldr      x10, [x10, #0xc08]
0065D0140  ldr      x1, [x10]
0065D0144  cbz      x9, #0x65d0168
0065D0148  ldr      x10, [x8, #0xb0]
0065D014C  add      x10, x10, #8
0065D0150  ldur     x11, [x10, #-8]
0065D0154  cmp      x11, x1
0065D0158  b.eq     #0x65d0178
0065D015C  subs     x9, x9, #1
0065D0160  add      x10, x10, #0x10
0065D0164  b.ne     #0x65d0150
0065D0168  mov      w2, #0x16
0065D016C  mov      x0, x20
0065D0170  bl       #0x3a7e710 ; 
0065D0174  b        #0x65d0188 ; 
0065D0178  ldr      w9, [x10]
0065D017C  add      w9, w9, #0x16
0065D0180  add      x8, x8, w9, sxtw #4
0065D0184  add      x0, x8, #0x138
0065D0188  ldp      x8, x1, [x0]
0065D018C  mov      x0, x20
0065D0190  blr      x8
0065D0194  cbz      x0, #0x65d0b4c
0065D0198  ldr      x8, [x0, #0x18]
0065D019C  cbz      x8, #0x65d0b1c
0065D01A0  adrp     x26, #0x9599000
0065D01A4  ldrb     w8, [x26, #0x286]
0065D01A8  cbnz     w8, #0x65d01c0
0065D01AC  adrp     x0, #0x8f07000
0065D01B0  ldr      x0, [x0, #0xc98]
0065D01B4  bl       #0x382bd14 ; 
0065D01B8  mov      w8, #1
0065D01BC  strb     w8, [x26, #0x286]
0065D01C0  adrp     x8, #0x8f07000
0065D01C4  ldr      x8, [x8, #0xc98]
0065D01C8  ldr      x1, [x8]
0065D01CC  ldrb     w8, [x1, #0x53]
0065D01D0  tbnz     w8, #5, #0x65d01dc
0065D01D4  ldr      x20, [x21, #0x80]
0065D01D8  b        #0x65d01ec ; 
0065D01DC  ldr      x8, [x1, #0x60]
0065D01E0  mov      x0, x21
0065D01E4  blr      x8
0065D01E8  mov      x20, x0
0065D01EC  cbz      x20, #0x65d0b4c
0065D01F0  adrp     x19, #0x9591000
0065D01F4  ldrb     w8, [x19, #0xa9c]
0065D01F8  cbnz     w8, #0x65d0210
0065D01FC  adrp     x0, #0x8ee6000
0065D0200  ldr      x0, [x0, #0xaf0]
0065D0204  bl       #0x382bd14 ; 
0065D0208  mov      w8, #1
0065D020C  strb     w8, [x19, #0xa9c]
0065D0210  adrp     x8, #0x8ee6000
0065D0214  ldr      x8, [x8, #0xaf0]
0065D0218  ldr      x1, [x8]
0065D021C  ldrb     w8, [x1, #0x53]
0065D0220  tbnz     w8, #5, #0x65d022c
0065D0224  ldr      x27, [x20, #0x240]
0065D0228  b        #0x65d023c ; 
0065D022C  ldr      x8, [x1, #0x60]
0065D0230  mov      x0, x20
0065D0234  blr      x8
0065D0238  mov      x27, x0
0065D023C  cbz      x27, #0x65d0b4c
0065D0240  ldr      x9, [x27, #0x10]
0065D0244  cbz      x9, #0x65d0b4c
0065D0248  ldr      x20, [x21, #0x188]
0065D024C  cbz      x20, #0x65d0b4c
0065D0250  ldr      x8, [x20]
0065D0254  adrp     x10, #0x8f09000
0065D0258  ldp      x24, x19, [x9, #0x10]
0065D025C  ldrh     w9, [x8, #0x12e]
0065D0260  ldr      x10, [x10, #0xc08]
0065D0264  ldr      x1, [x10]
0065D0268  cbz      x9, #0x65d028c
0065D026C  ldr      x10, [x8, #0xb0]
0065D0270  add      x10, x10, #8
0065D0274  ldur     x11, [x10, #-8]
0065D0278  cmp      x11, x1
0065D027C  b.eq     #0x65d029c
0065D0280  subs     x9, x9, #1
0065D0284  add      x10, x10, #0x10
0065D0288  b.ne     #0x65d0274
0065D028C  mov      w2, #0x1a
0065D0290  mov      x0, x20
0065D0294  bl       #0x3a7e710 ; 
0065D0298  b        #0x65d02ac ; 
0065D029C  ldr      w9, [x10]
0065D02A0  add      w9, w9, #0x1a
0065D02A4  add      x8, x8, w9, sxtw #4
0065D02A8  add      x0, x8, #0x138
0065D02AC  ldp      x8, x1, [x0]
0065D02B0  mov      x0, x20
0065D02B4  blr      x8
0065D02B8  ldr      x20, [x21, #0x188]
0065D02BC  str      w0, [sp, #0x24]
0065D02C0  cbz      x20, #0x65d0b4c
0065D02C4  ldr      x8, [x20]
0065D02C8  adrp     x10, #0x8f09000
0065D02CC  ldrh     w9, [x8, #0x12e]
0065D02D0  ldr      x10, [x10, #0xc08]
0065D02D4  ldr      x1, [x10]
0065D02D8  cbz      x9, #0x65d02fc
0065D02DC  ldr      x10, [x8, #0xb0]
0065D02E0  add      x10, x10, #8
0065D02E4  ldur     x11, [x10, #-8]
0065D02E8  cmp      x11, x1
0065D02EC  b.eq     #0x65d030c
0065D02F0  subs     x9, x9, #1
0065D02F4  add      x10, x10, #0x10
0065D02F8  b.ne     #0x65d02e4
0065D02FC  mov      w2, #0x18
0065D0300  mov      x0, x20
0065D0304  bl       #0x3a7e710 ; 
0065D0308  b        #0x65d031c ; 
0065D030C  ldr      w9, [x10]
0065D0310  add      w9, w9, #0x18
0065D0314  add      x8, x8, w9, sxtw #4
0065D0318  add      x0, x8, #0x138
0065D031C  ldp      x8, x1, [x0]
0065D0320  mov      x0, x20
0065D0324  blr      x8
0065D0328  ldr      w8, [x21, #0xa8]
0065D032C  mov      w28, w0
0065D0330  add      w8, w8, w0
0065D0334  cmp      w8, #0x259
0065D0338  b.lt     #0x65d0390
0065D033C  adrp     x8, #0x8ee1000
0065D0340  ldr      x8, [x8, #0x6e8]
0065D0344  ldr      x0, [x8]
0065D0348  ldr      w8, [x0, #0xe0]
0065D034C  cbnz     w8, #0x65d0354
0065D0350  bl       #0x382be8c ; 
0065D0354  adrp     x8, #0x8f0a000
0065D0358  adrp     x9, #0x8f0a000
0065D035C  adrp     x10, #0x8f0a000
0065D0360  ldr      x8, [x8, #0x918]
0065D0364  ldr      x9, [x9, #0x978]
0065D0368  ldr      x10, [x10, #0x8b8]
0065D036C  mov      w3, #0x597
0065D0370  ldr      x0, [x8]
0065D0374  ldr      x1, [x9]
0065D0378  ldr      x2, [x10]
0065D037C  mov      x4, xzr
0065D0380  bl       #0x7997754 ; Logger$$LogError
0065D0384  ldr      w8, [x21, #0xa8]
0065D0388  mov      w9, #0x258
0065D038C  sub      w28, w9, w8
0065D0390  cbz      w28, #0x65d0b1c
0065D0394  ldr      x20, [x21, #0x188]
0065D0398  cbz      x20, #0x65d0b4c
0065D039C  ldr      x8, [x20]
0065D03A0  adrp     x10, #0x8f09000
0065D03A4  ldrh     w9, [x8, #0x12e]
0065D03A8  ldr      x10, [x10, #0xc08]
0065D03AC  ldr      x1, [x10]
0065D03B0  cbz      x9, #0x65d03d4
0065D03B4  ldr      x10, [x8, #0xb0]
0065D03B8  add      x10, x10, #8
0065D03BC  ldur     x11, [x10, #-8]
0065D03C0  cmp      x11, x1
0065D03C4  b.eq     #0x65d03e4
0065D03C8  subs     x9, x9, #1
0065D03CC  add      x10, x10, #0x10
0065D03D0  b.ne     #0x65d03bc
0065D03D4  mov      w2, #0x16
0065D03D8  mov      x0, x20
0065D03DC  bl       #0x3a7e710 ; 
0065D03E0  b        #0x65d03f4 ; 
0065D03E4  ldr      w9, [x10]
0065D03E8  add      w9, w9, #0x16
0065D03EC  add      x8, x8, w9, sxtw #4
0065D03F0  add      x0, x8, #0x138
0065D03F4  ldp      x8, x1, [x0]
0065D03F8  mov      x0, x20
0065D03FC  blr      x8
0065D0400  ldr      x23, [x21, #0x188]
0065D0404  str      x0, [sp, #0x10]
0065D0408  cbz      x23, #0x65d0b4c
0065D040C  ldr      x8, [x23]
0065D0410  adrp     x10, #0x8f09000
0065D0414  ldr      x20, [x21, #0x1f0]
0065D0418  ldrh     w9, [x8, #0x12e]
0065D041C  ldr      x10, [x10, #0xc08]
0065D0420  ldr      x1, [x10]
0065D0424  cbz      x9, #0x65d0448
0065D0428  ldr      x10, [x8, #0xb0]
0065D042C  add      x10, x10, #8
0065D0430  ldur     x11, [x10, #-8]
0065D0434  cmp      x11, x1
0065D0438  b.eq     #0x65d0458
0065D043C  subs     x9, x9, #1
0065D0440  add      x10, x10, #0x10
0065D0444  b.ne     #0x65d0430
0065D0448  mov      x0, x23
0065D044C  mov      w2, wzr
0065D0450  bl       #0x3a7e710 ; 
0065D0454  b        #0x65d0464 ; 
0065D0458  ldrsw    x9, [x10]
0065D045C  add      x8, x8, x9, lsl #4
0065D0460  add      x0, x8, #0x138
0065D0464  ldp      x8, x1, [x0]
0065D0468  mov      x0, x23
0065D046C  blr      x8
0065D0470  cbz      x20, #0x65d0b4c
0065D0474  str      x27, [sp, #0x48]
0065D0478  str      x22, [sp, #8]
0065D047C  adrp     x8, #0x8f0a000
0065D0480  ldr      x8, [x8, #0x910]
0065D0484  mov      w1, w0
0065D0488  mov      x0, x20
0065D048C  ldr      x2, [x8]
0065D0490  bl       #0x5e5f99c ; System.Collections.Generic.Dictionary<int, object>$$get_Item
0065D0494  cbz      x0, #0x65d0b4c
0065D0498  sub      x8, x19, x24
0065D049C  adrp     x25, #0x8ec2000
0065D04A0  sub      x8, x8, #0x20, lsl #12
0065D04A4  ldr      x25, [x25, #0x270]
0065D04A8  str      x8, [sp, #0x18]
0065D04AC  adrp     x24, #0x8f07000
0065D04B0  ldr      x24, [x24, #0xc98]
0065D04B4  mov      x29, x0
0065D04B8  mov      w27, wzr
0065D04BC  mov      w22, wzr
0065D04C0  str      x0, [sp, #0x28]
0065D04C4  ldr      x19, [sp, #0x10]
0065D04C8  ldr      x0, [x29, #0x28]
0065D04CC  cbz      x0, #0x65d0b4c
0065D04D0  ldr      x2, [x25]
0065D04D4  mov      w1, w27
0065D04D8  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065D04DC  cbz      x19, #0x65d0b4c
0065D04E0  ldr      w8, [x19, #0x18]
0065D04E4  cmp      w0, w8
0065D04E8  b.hs     #0x65d0b50
0065D04EC  add      x8, x19, w0, sxtw #2
0065D04F0  ldrb     w9, [x26, #0x286]
0065D04F4  ldr      w20, [x8, #0x20]
0065D04F8  cbnz     w9, #0x65d050c
0065D04FC  mov      x0, x24
0065D0500  bl       #0x382bd14 ; 
0065D0504  mov      w8, #1
0065D0508  strb     w8, [x26, #0x286]
0065D050C  ldr      x1, [x24]
0065D0510  ldrb     w8, [x1, #0x53]
0065D0514  tbnz     w8, #5, #0x65d0520
0065D0518  ldr      x23, [x21, #0x80]
0065D051C  b        #0x65d0530 ; 
0065D0520  ldr      x8, [x1, #0x60]
0065D0524  mov      x0, x21
0065D0528  blr      x8
0065D052C  mov      x23, x0
0065D0530  cbz      x23, #0x65d0b4c
0065D0534  adrp     x8, #0x9598000
0065D0538  ldrb     w8, [x8, #0xfcc]
0065D053C  cbnz     w8, #0x65d0558
0065D0540  adrp     x0, #0x8f06000
0065D0544  ldr      x0, [x0, #0x470]
0065D0548  bl       #0x382bd14 ; 
0065D054C  mov      w8, #1
0065D0550  adrp     x9, #0x9598000
0065D0554  strb     w8, [x9, #0xfcc]
0065D0558  adrp     x8, #0x8f06000
0065D055C  ldr      x8, [x8, #0x470]
0065D0560  ldr      x1, [x8]
0065D0564  ldrb     w8, [x1, #0x53]
0065D0568  tbnz     w8, #5, #0x65d0574
0065D056C  ldr      x0, [x23, #0x200]
0065D0570  b        #0x65d0580 ; 
0065D0574  ldr      x8, [x1, #0x60]
0065D0578  mov      x0, x23
0065D057C  blr      x8
0065D0580  cbz      x0, #0x65d0b4c
0065D0584  mov      w1, w20
0065D0588  mov      x2, xzr
0065D058C  add      w27, w27, #1
0065D0590  bl       #0x64e54f0 ; LocalModels.LocalModelManager$$GetMission_RandomMonsterFlushConfig
0065D0594  cbz      x0, #0x65d04c8
0065D0598  adrp     x8, #0x9599000
0065D059C  ldrb     w8, [x8, #0x65e]
0065D05A0  mov      x23, x0
0065D05A4  cbnz     w8, #0x65d05c0
0065D05A8  adrp     x0, #0x8f0a000
0065D05AC  ldr      x0, [x0, #0x988]
0065D05B0  bl       #0x382bd14 ; 
0065D05B4  mov      w8, #1
0065D05B8  adrp     x9, #0x9599000
0065D05BC  strb     w8, [x9, #0x65e]
0065D05C0  adrp     x8, #0x8f0a000
0065D05C4  ldr      x8, [x8, #0x988]
0065D05C8  ldr      x1, [x8]
0065D05CC  ldrb     w8, [x1, #0x53]
0065D05D0  tbnz     w8, #5, #0x65d05dc
0065D05D4  ldr      x0, [x23, #0x28]
0065D05D8  b        #0x65d05e8 ; 
0065D05DC  ldr      x8, [x1, #0x60]
0065D05E0  mov      x0, x23
0065D05E4  blr      x8
0065D05E8  cbz      x0, #0x65d0ad0
0065D05EC  adrp     x8, #0x9599000
0065D05F0  ldrb     w8, [x8, #0x65e]
0065D05F4  cbnz     w8, #0x65d0610
0065D05F8  adrp     x0, #0x8f0a000
0065D05FC  ldr      x0, [x0, #0x988]
0065D0600  bl       #0x382bd14 ; 
0065D0604  mov      w8, #1
0065D0608  adrp     x9, #0x9599000
0065D060C  strb     w8, [x9, #0x65e]
0065D0610  adrp     x8, #0x8f0a000
0065D0614  ldr      x8, [x8, #0x988]
0065D0618  ldr      x1, [x8]
0065D061C  ldrb     w8, [x1, #0x53]
0065D0620  tbnz     w8, #5, #0x65d062c
0065D0624  ldr      x0, [x23, #0x28]
0065D0628  b        #0x65d0638 ; 
0065D062C  ldr      x8, [x1, #0x60]
0065D0630  mov      x0, x23
0065D0634  blr      x8
0065D0638  cbz      x0, #0x65d0b4c
0065D063C  ldr      x8, [x0, #0x18]
0065D0640  cbz      x8, #0x65d0ad0
0065D0644  ldr      w8, [x21, #0xa8]
0065D0648  ldr      x1, [sp, #0x18]
0065D064C  ldr      w2, [sp, #0x24]
0065D0650  ldr      x3, [sp, #0x48]
0065D0654  add      w4, w8, w22
0065D0658  add      x8, sp, #0x68
0065D065C  mov      x0, x21
0065D0660  mov      x19, x21
0065D0664  bl       #0x65d3a78 ; HotFix.BattleLogic.WaterfallBattleManager$$RandomPos
0065D0668  ldr      x9, [sp, #0x68]
0065D066C  ldr      x8, [sp, #0x78]
0065D0670  mov      x26, xzr
0065D0674  stp      x8, x9, [sp, #0x30]
0065D0678  adrp     x20, #0x9599000
0065D067C  adrp     x21, #0x8f0a000
0065D0680  ldrb     w8, [x20, #0x65e]
0065D0684  ldr      x21, [x21, #0x988]
0065D0688  cbnz     w8, #0x65d069c
0065D068C  mov      x0, x21
0065D0690  bl       #0x382bd14 ; 
0065D0694  mov      w8, #1
0065D0698  strb     w8, [x20, #0x65e]
0065D069C  ldr      x1, [x21]
0065D06A0  ldrb     w8, [x1, #0x53]
0065D06A4  tbnz     w8, #5, #0x65d06b0
0065D06A8  ldr      x0, [x23, #0x28]
0065D06AC  b        #0x65d06bc ; 
0065D06B0  ldr      x8, [x1, #0x60]
0065D06B4  mov      x0, x23
0065D06B8  blr      x8
0065D06BC  cbz      x0, #0x65d0b4c
0065D06C0  ldrsw    x8, [x0, #0x18]
0065D06C4  cmp      x26, x8
0065D06C8  b.ge     #0x65d0ab0
0065D06CC  ldrb     w8, [x20, #0x65e]
0065D06D0  cbnz     w8, #0x65d06e4
0065D06D4  mov      x0, x21
0065D06D8  bl       #0x382bd14 ; 
0065D06DC  mov      w8, #1
0065D06E0  strb     w8, [x20, #0x65e]
0065D06E4  ldr      x1, [x21]
0065D06E8  ldrb     w8, [x1, #0x53]
0065D06EC  tbnz     w8, #5, #0x65d06f8
0065D06F0  ldr      x0, [x23, #0x28]
0065D06F4  b        #0x65d0704 ; 
0065D06F8  ldr      x8, [x1, #0x60]
0065D06FC  mov      x0, x23
0065D0700  blr      x8
0065D0704  cbz      x0, #0x65d0b4c
0065D0708  ldr      w8, [x0, #0x18]
0065D070C  cmp      x26, x8
0065D0710  b.hs     #0x65d0b50
0065D0714  ldr      x29, [x19, #0xa0]
0065D0718  cbz      x29, #0x65d0b4c
0065D071C  ldr      w8, [x19, #0xa8]
0065D0720  ldr      w9, [x29, #0x18]
0065D0724  mov      w21, w28
0065D0728  mov      x10, x19
0065D072C  add      w28, w8, w22
0065D0730  cmp      w28, w9
0065D0734  b.hs     #0x65d0b50
0065D0738  ldr      x24, [x10, #0x188]
0065D073C  cbz      x24, #0x65d0b4c
0065D0740  ldr      x8, [x24]
0065D0744  add      x9, x0, x26, lsl #2
0065D0748  adrp     x10, #0x8f09000
0065D074C  ldr      w20, [x9, #0x20]
0065D0750  ldrh     w9, [x8, #0x12e]
0065D0754  ldr      x10, [x10, #0xc08]
0065D0758  ldr      x1, [x10]
0065D075C  cbz      x9, #0x65d0780
0065D0760  ldr      x10, [x8, #0xb0]
0065D0764  add      x10, x10, #8
0065D0768  ldur     x11, [x10, #-8]
0065D076C  cmp      x11, x1
0065D0770  b.eq     #0x65d0790
0065D0774  subs     x9, x9, #1
0065D0778  add      x10, x10, #0x10
0065D077C  b.ne     #0x65d0768
0065D0780  mov      w2, #6
0065D0784  mov      x0, x24
0065D0788  bl       #0x3a7e710 ; 
0065D078C  b        #0x65d07a0 ; 
0065D0790  ldr      w9, [x10]
0065D0794  add      w9, w9, #6
0065D0798  add      x8, x8, w9, sxtw #4
0065D079C  add      x0, x8, #0x138
0065D07A0  ldp      x8, x1, [x0]
0065D07A4  mov      x0, x24
0065D07A8  sxtw     x28, w28
0065D07AC  blr      x8
0065D07B0  ldr      x8, [sp, #0x40]
0065D07B4  add      x24, x29, x28, lsl #7
0065D07B8  adrp     x9, #0x8ee8000
0065D07BC  add      x8, x0, x8
0065D07C0  str      x8, [x24, #0x20]
0065D07C4  ldr      x9, [x9, #0x898]
0065D07C8  ldr      x0, [x9]
0065D07CC  ldr      w8, [x0, #0xe0]
0065D07D0  cbnz     w8, #0x65d07e0
0065D07D4  mov      x25, x9
0065D07D8  bl       #0x382be8c ; 
0065D07DC  ldr      x0, [x25]
0065D07E0  ldr      x8, [x0, #0xb8]
0065D07E4  ldr      x8, [x8, #0xb0]
0065D07E8  str      x8, [x24, #0x28]
0065D07EC  adrp     x8, #0x9599000
0065D07F0  ldrb     w8, [x8, #0x660]
0065D07F4  cbnz     w8, #0x65d0810
0065D07F8  adrp     x0, #0x8f0a000
0065D07FC  ldr      x0, [x0, #0x990]
0065D0800  bl       #0x382bd14 ; 
0065D0804  mov      w8, #1
0065D0808  adrp     x9, #0x9599000
0065D080C  strb     w8, [x9, #0x660]
0065D0810  adrp     x8, #0x8f0a000
0065D0814  ldr      x8, [x8, #0x990]
0065D0818  ldr      x1, [x8]
0065D081C  ldrb     w8, [x1, #0x53]
0065D0820  tbnz     w8, #5, #0x65d082c
0065D0824  ldr      x0, [x23, #0x38]
0065D0828  b        #0x65d0838 ; 
0065D082C  ldr      x8, [x1, #0x60]
0065D0830  mov      x0, x23
0065D0834  blr      x8
0065D0838  ldr      x8, [sp, #0x48]
0065D083C  ldr      x8, [x8, #0x10]
0065D0840  cbz      x8, #0x65d0b4c
0065D0844  ldr      x8, [x8, #0x18]
0065D0848  ldr      x10, [sp, #0x38]
0065D084C  adrp     x9, #0x9599000
0065D0850  ldrb     w9, [x9, #0x661]
0065D0854  sub      x8, x8, #0x10, lsl #12
0065D0858  madd     x10, x0, x26, x10
0065D085C  cmp      x10, x8
0065D0860  csel     x24, x8, x10, gt
0065D0864  cbnz     w9, #0x65d0880
0065D0868  adrp     x0, #0x8f0a000
0065D086C  ldr      x0, [x0, #0x998]
0065D0870  bl       #0x382bd14 ; 
0065D0874  mov      w8, #1
0065D0878  adrp     x9, #0x9599000
0065D087C  strb     w8, [x9, #0x661]
0065D0880  adrp     x8, #0x8f0a000
0065D0884  ldr      x8, [x8, #0x998]
0065D0888  ldr      x1, [x8]
0065D088C  ldrb     w8, [x1, #0x53]
0065D0890  tbnz     w8, #5, #0x65d089c
0065D0894  ldr      x0, [x23, #0x30]
0065D0898  b        #0x65d08a8 ; 
0065D089C  ldr      x8, [x1, #0x60]
0065D08A0  mov      x0, x23
0065D08A4  blr      x8
0065D08A8  ldr      x8, [sp, #0x30]
0065D08AC  mov      x1, x24
0065D08B0  mov      x2, xzr
0065D08B4  mov      x4, xzr
0065D08B8  madd     x3, x0, x26, x8
0065D08BC  add      x0, sp, #0x80
0065D08C0  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065D08C4  ldr      w8, [x19, #0xa8]
0065D08C8  ldr      q0, [sp, #0x80]
0065D08CC  ldr      x9, [sp, #0x90]
0065D08D0  mov      x0, x19
0065D08D4  add      w24, w8, w22
0065D08D8  add      x2, sp, #0x50
0065D08DC  mov      w1, w24
0065D08E0  str      q0, [sp, #0x50]
0065D08E4  str      x9, [sp, #0x60]
0065D08E8  bl       #0x65d3c88 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckPosValid
0065D08EC  tbnz     w0, #0, #0x65d091c
0065D08F0  ldr      x1, [sp, #0x18]
0065D08F4  ldr      w2, [sp, #0x24]
0065D08F8  ldr      x3, [sp, #0x48]
0065D08FC  add      x8, sp, #0x68
0065D0900  mov      x0, x19
0065D0904  mov      w4, w24
0065D0908  bl       #0x65d3a78 ; HotFix.BattleLogic.WaterfallBattleManager$$RandomPos
0065D090C  ldur     q0, [sp, #0x68]
0065D0910  ldr      x8, [sp, #0x78]
0065D0914  str      q0, [sp, #0x80]
0065D0918  str      x8, [sp, #0x90]
0065D091C  adrp     x8, #0x9599000
0065D0920  adrp     x24, #0x8f07000
0065D0924  ldrb     w8, [x8, #0x286]
0065D0928  ldr      x24, [x24, #0xc98]
0065D092C  cbnz     w8, #0x65d0944
0065D0930  mov      x0, x24
0065D0934  bl       #0x382bd14 ; 
0065D0938  adrp     x8, #0x9599000
0065D093C  mov      w9, #1
0065D0940  strb     w9, [x8, #0x286]
0065D0944  ldr      x1, [x24]
0065D0948  ldrb     w8, [x1, #0x53]
0065D094C  tbnz     w8, #5, #0x65d0958
0065D0950  ldr      x24, [x19, #0x80]
0065D0954  b        #0x65d0968 ; 
0065D0958  ldr      x8, [x1, #0x60]
0065D095C  mov      x0, x19
0065D0960  blr      x8
0065D0964  mov      x24, x0
0065D0968  cbz      x24, #0x65d0b4c
0065D096C  adrp     x8, #0x9598000
0065D0970  ldrb     w8, [x8, #0xfcc]
0065D0974  cbnz     w8, #0x65d0990
0065D0978  adrp     x0, #0x8f06000
0065D097C  ldr      x0, [x0, #0x470]
0065D0980  bl       #0x382bd14 ; 
0065D0984  mov      w8, #1
0065D0988  adrp     x9, #0x9598000
0065D098C  strb     w8, [x9, #0xfcc]
0065D0990  adrp     x8, #0x8f06000
0065D0994  ldr      x8, [x8, #0x470]
0065D0998  ldr      x1, [x8]
0065D099C  ldrb     w8, [x1, #0x53]
0065D09A0  tbnz     w8, #5, #0x65d09ac
0065D09A4  ldr      x0, [x24, #0x200]
0065D09A8  b        #0x65d09b8 ; 
0065D09AC  ldr      x8, [x1, #0x60]
0065D09B0  mov      x0, x24
0065D09B4  blr      x8
0065D09B8  cbz      x0, #0x65d0b4c
0065D09BC  mov      w1, w20
0065D09C0  mov      x2, xzr
0065D09C4  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D09C8  ldr      q0, [sp, #0x80]
0065D09CC  add      x8, x29, x28, lsl #7
0065D09D0  ldr      x9, [sp, #0x90]
0065D09D4  mov      w10, #1
0065D09D8  str      q0, [x8, #0x30]
0065D09DC  ldr      q0, [x8, #0x30]
0065D09E0  str      w20, [x8, #0x60]
0065D09E4  str      xzr, [x8, #0x68]
0065D09E8  str      x9, [x8, #0x40]
0065D09EC  str      xzr, [x8, #0x78]
0065D09F0  str      w10, [x8, #0x80]
0065D09F4  str      x9, [x8, #0x58]
0065D09F8  stur     q0, [x8, #0x48]
0065D09FC  stp      xzr, xzr, [x8, #0x88]
0065D0A00  ldr      x24, [x19, #0x188]
0065D0A04  cbz      x24, #0x65d0b4c
0065D0A08  ldr      x8, [x24]
0065D0A0C  adrp     x10, #0x8f09000
0065D0A10  mov      x20, x0
0065D0A14  ldrh     w9, [x8, #0x12e]
0065D0A18  ldr      x10, [x10, #0xc08]
0065D0A1C  ldr      x1, [x10]
0065D0A20  cbz      x9, #0x65d0a44
0065D0A24  ldr      x10, [x8, #0xb0]
0065D0A28  add      x10, x10, #8
0065D0A2C  ldur     x11, [x10, #-8]
0065D0A30  cmp      x11, x1
0065D0A34  b.eq     #0x65d0a54
0065D0A38  subs     x9, x9, #1
0065D0A3C  add      x10, x10, #0x10
0065D0A40  b.ne     #0x65d0a2c
0065D0A44  mov      x0, x24
0065D0A48  mov      w2, wzr
0065D0A4C  bl       #0x3a7e710 ; 
0065D0A50  b        #0x65d0a60 ; 
0065D0A54  ldrsw    x9, [x10]
0065D0A58  add      x8, x8, x9, lsl #4
0065D0A5C  add      x0, x8, #0x138
0065D0A60  ldp      x8, x1, [x0]
0065D0A64  mov      x0, x24
0065D0A68  blr      x8
0065D0A6C  add      x24, x29, x28, lsl #7
0065D0A70  str      w0, [x24, #0x98]
0065D0A74  mov      x0, x19
0065D0A78  mov      x1, x20
0065D0A7C  bl       #0x65d0b58 ; HotFix.BattleLogic.WaterfallBattleManager$$AddGoldMonster
0065D0A80  and      w8, w0, #1
0065D0A84  strb     w8, [x24, #0x9c]
0065D0A88  adrp     x24, #0x8f07000
0065D0A8C  adrp     x25, #0x8ec2000
0065D0A90  ldr      x24, [x24, #0xc98]
0065D0A94  ldr      x29, [sp, #0x28]
0065D0A98  ldr      x25, [x25, #0x270]
0065D0A9C  add      w22, w22, #1
0065D0AA0  mov      w28, w21
0065D0AA4  cmp      w21, w22
0065D0AA8  add      x26, x26, #1
0065D0AAC  b.gt     #0x65d0678
0065D0AB0  cmp      w28, w22
0065D0AB4  adrp     x26, #0x9599000
0065D0AB8  mov      x21, x19
0065D0ABC  b.gt     #0x65d04c4
0065D0AC0  ldr      w8, [x21, #0xa8]
0065D0AC4  add      w8, w8, w28
0065D0AC8  str      w8, [x21, #0xa8]
0065D0ACC  b        #0x65d0b18 ; 
0065D0AD0  adrp     x8, #0x8ee1000
0065D0AD4  ldr      x8, [x8, #0x6e8]
0065D0AD8  ldr      x0, [x8]
0065D0ADC  ldr      w8, [x0, #0xe0]
0065D0AE0  cbnz     w8, #0x65d0ae8
0065D0AE4  bl       #0x382be8c ; 
0065D0AE8  adrp     x8, #0x8f0a000
0065D0AEC  adrp     x9, #0x8f0a000
0065D0AF0  adrp     x10, #0x8f0a000
0065D0AF4  ldr      x8, [x8, #0x980]
0065D0AF8  ldr      x9, [x9, #0x978]
0065D0AFC  ldr      x10, [x10, #0x8b8]
0065D0B00  mov      w3, #0x5ac
0065D0B04  ldr      x0, [x8]
0065D0B08  ldr      x1, [x9]
0065D0B0C  ldr      x2, [x10]
0065D0B10  mov      x4, xzr
0065D0B14  bl       #0x7997754 ; Logger$$LogError
0065D0B18  ldr      x22, [sp, #8]
0065D0B1C  ldr      x8, [x22, #0x28]
0065D0B20  ldr      x9, [sp, #0x98]
0065D0B24  cmp      x8, x9
0065D0B28  b.ne     #0x65d0b54
0065D0B2C  ldp      x20, x19, [sp, #0xf0]
0065D0B30  ldp      x22, x21, [sp, #0xe0]
0065D0B34  ldp      x24, x23, [sp, #0xd0]
0065D0B38  ldp      x26, x25, [sp, #0xc0]
0065D0B3C  ldp      x28, x27, [sp, #0xb0]
0065D0B40  ldp      x29, x30, [sp, #0xa0]
0065D0B44  add      sp, sp, #0x100
0065D0B48  ret      
0065D0B4C  bl       #0x382bfb8 ; 
0065D0B50  bl       #0x382bfc0 ; 
0065D0B54  bl       #0x89edb60 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$RandomPos
; RVA 0x65D3A78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D3A78  sub      sp, sp, #0xb0
0065D3A7C  stp      x29, x30, [sp, #0x50]
0065D3A80  stp      x28, x27, [sp, #0x60]
0065D3A84  stp      x26, x25, [sp, #0x70]
0065D3A88  stp      x24, x23, [sp, #0x80]
0065D3A8C  stp      x22, x21, [sp, #0x90]
0065D3A90  stp      x20, x19, [sp, #0xa0]
0065D3A94  mrs      x27, tpidr_el0
0065D3A98  mov      x26, x8
0065D3A9C  ldr      x8, [x27, #0x28]
0065D3AA0  adrp     x22, #0x9599000
0065D3AA4  adrp     x25, #0x8f0a000
0065D3AA8  mov      w19, w4
0065D3AAC  str      x8, [sp, #0x48]
0065D3AB0  ldrb     w8, [x22, #0x592]
0065D3AB4  ldr      x25, [x25, #0xa80]
0065D3AB8  mov      x20, x3
0065D3ABC  mov      w21, w2
0065D3AC0  mov      x23, x1
0065D3AC4  mov      x24, x0
0065D3AC8  tbnz     w8, #0, #0x65d3ae0
0065D3ACC  adrp     x0, #0x8f0a000
0065D3AD0  ldr      x0, [x0, #0xa80]
0065D3AD4  bl       #0x382bd14 ; 
0065D3AD8  mov      w8, #1
0065D3ADC  strb     w8, [x22, #0x592]
0065D3AE0  ldr      x5, [x25]
0065D3AE4  ldrb     w8, [x5, #0x53]
0065D3AE8  tbnz     w8, #5, #0x65d3c30
0065D3AEC  str      x26, [sp, #8]
0065D3AF0  stp      xzr, xzr, [sp, #0x30]
0065D3AF4  str      xzr, [sp, #0x40]
0065D3AF8  adrp     x25, #0x8f07000
0065D3AFC  ldr      x25, [x25, #0xc98]
0065D3B00  mov      w8, #9
0065D3B04  adrp     x28, #0x9599000
0065D3B08  mov      w29, #1
0065D3B0C  ldrb     w9, [x28, #0x286]
0065D3B10  mov      w22, w8
0065D3B14  cbnz     w9, #0x65d3b24
0065D3B18  mov      x0, x25
0065D3B1C  bl       #0x382bd14 ; 
0065D3B20  strb     w29, [x28, #0x286]
0065D3B24  ldr      x1, [x25]
0065D3B28  ldrb     w8, [x1, #0x53]
0065D3B2C  tbnz     w8, #5, #0x65d3b38
0065D3B30  ldr      x0, [x24, #0x80]
0065D3B34  b        #0x65d3b44 ; 
0065D3B38  ldr      x8, [x1, #0x60]
0065D3B3C  mov      x0, x24
0065D3B40  blr      x8
0065D3B44  cbz      x0, #0x65d3c80
0065D3B48  mov      x1, xzr
0065D3B4C  mov      x2, x23
0065D3B50  mov      x3, xzr
0065D3B54  bl       #0x563860c ; 
0065D3B58  ldrb     w8, [x28, #0x286]
0065D3B5C  mov      x26, x0
0065D3B60  cbnz     w8, #0x65d3b70
0065D3B64  mov      x0, x25
0065D3B68  bl       #0x382bd14 ; 
0065D3B6C  strb     w29, [x28, #0x286]
0065D3B70  ldr      x1, [x25]
0065D3B74  ldrb     w8, [x1, #0x53]
0065D3B78  tbnz     w8, #5, #0x65d3b84
0065D3B7C  ldr      x0, [x24, #0x80]
0065D3B80  b        #0x65d3b90 ; 
0065D3B84  ldr      x8, [x1, #0x60]
0065D3B88  mov      x0, x24
0065D3B8C  blr      x8
0065D3B90  cbz      x0, #0x65d3c80
0065D3B94  mov      w1, wzr
0065D3B98  mov      w2, w21
0065D3B9C  mov      x3, xzr
0065D3BA0  bl       #0x54b65d8 ; 
0065D3BA4  cbz      x20, #0x65d3c80
0065D3BA8  ldr      x8, [x20, #0x10]
0065D3BAC  cbz      x8, #0x65d3c80
0065D3BB0  ldp      x9, x10, [x8, #0x10]
0065D3BB4  ldr      x8, [x8, #0x20]
0065D3BB8  sxtw     x11, w0
0065D3BBC  add      x0, sp, #0x30
0065D3BC0  add      x9, x26, x9
0065D3BC4  sub      x10, x10, #0x10, lsl #12
0065D3BC8  add      x9, x9, #0x10, lsl #12
0065D3BCC  cmp      x9, x10
0065D3BD0  csel     x1, x10, x9, gt
0065D3BD4  add      x3, x8, x11, lsl #16
0065D3BD8  mov      x2, xzr
0065D3BDC  mov      x4, xzr
0065D3BE0  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065D3BE4  cmp      w19, #1
0065D3BE8  b.lt     #0x65d3c18
0065D3BEC  ldr      q0, [sp, #0x30]
0065D3BF0  ldr      x8, [sp, #0x40]
0065D3BF4  add      x2, sp, #0x10
0065D3BF8  mov      x0, x24
0065D3BFC  mov      w1, w19
0065D3C00  str      q0, [sp, #0x10]
0065D3C04  str      x8, [sp, #0x20]
0065D3C08  bl       #0x65d3c88 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckPosValid
0065D3C0C  tbnz     w0, #0, #0x65d3c18
0065D3C10  sub      w8, w22, #1
0065D3C14  cbnz     w22, #0x65d3b0c
0065D3C18  ldr      x8, [sp, #0x40]
0065D3C1C  ldr      q0, [sp, #0x30]
0065D3C20  ldr      x9, [sp, #8]
0065D3C24  str      x8, [x9, #0x10]
0065D3C28  str      q0, [x9]
0065D3C2C  b        #0x65d3c50 ; 
0065D3C30  ldr      x9, [x5, #0x60]
0065D3C34  mov      x8, x26
0065D3C38  mov      x0, x24
0065D3C3C  mov      x1, x23
0065D3C40  mov      w2, w21
0065D3C44  mov      x3, x20
0065D3C48  mov      w4, w19
0065D3C4C  blr      x9
0065D3C50  ldr      x8, [x27, #0x28]
0065D3C54  ldr      x9, [sp, #0x48]
0065D3C58  cmp      x8, x9
0065D3C5C  b.ne     #0x65d3c84
0065D3C60  ldp      x20, x19, [sp, #0xa0]
0065D3C64  ldp      x22, x21, [sp, #0x90]
0065D3C68  ldp      x24, x23, [sp, #0x80]
0065D3C6C  ldp      x26, x25, [sp, #0x70]
0065D3C70  ldp      x28, x27, [sp, #0x60]
0065D3C74  ldp      x29, x30, [sp, #0x50]
0065D3C78  add      sp, sp, #0xb0
0065D3C7C  ret      
0065D3C80  bl       #0x382bfb8 ; 
0065D3C84  bl       #0x89edb60 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckPosValid
; RVA 0x65D3C88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D3C88  sub      sp, sp, #0xe0
0065D3C8C  stp      x30, x25, [sp, #0xa0]
0065D3C90  stp      x24, x23, [sp, #0xb0]
0065D3C94  stp      x22, x21, [sp, #0xc0]
0065D3C98  stp      x20, x19, [sp, #0xd0]
0065D3C9C  mrs      x22, tpidr_el0
0065D3CA0  ldr      x8, [x22, #0x28]
0065D3CA4  adrp     x23, #0x9599000
0065D3CA8  adrp     x24, #0x8f0a000
0065D3CAC  mov      x20, x2
0065D3CB0  str      x8, [sp, #0x98]
0065D3CB4  ldrb     w8, [x23, #0x593]
0065D3CB8  ldr      x24, [x24, #0xa88]
0065D3CBC  mov      w21, w1
0065D3CC0  mov      x19, x0
0065D3CC4  tbnz     w8, #0, #0x65d3cdc
0065D3CC8  adrp     x0, #0x8f0a000
0065D3CCC  ldr      x0, [x0, #0xa88]
0065D3CD0  bl       #0x382bd14 ; 
0065D3CD4  mov      w8, #1
0065D3CD8  strb     w8, [x23, #0x593]
0065D3CDC  ldr      x3, [x24]
0065D3CE0  ldrb     w8, [x3, #0x53]
0065D3CE4  tbnz     w8, #5, #0x65d3d84
0065D3CE8  cmp      w21, #1
0065D3CEC  b.lt     #0x65d3dac
0065D3CF0  mov      x23, xzr
0065D3CF4  mov      w21, w21
0065D3CF8  mov      w24, #1
0065D3CFC  mov      w25, #0x30
0065D3D00  ldr      x8, [x20, #0x10]
0065D3D04  ldr      q0, [x20]
0065D3D08  str      x8, [sp, #0x70]
0065D3D0C  str      q0, [sp, #0x60]
0065D3D10  ldr      x8, [x19, #0xa0]
0065D3D14  cbz      x8, #0x65d3de0
0065D3D18  ldr      w9, [x8, #0x18]
0065D3D1C  cmp      x23, x9
0065D3D20  b.hs     #0x65d3de4
0065D3D24  add      x8, x8, x25
0065D3D28  ldr      q0, [sp, #0x60]
0065D3D2C  ldr      x9, [sp, #0x70]
0065D3D30  ldr      x10, [x8, #0x10]
0065D3D34  ldr      q1, [x8]
0065D3D38  add      x0, sp, #0x20
0065D3D3C  mov      x1, sp
0065D3D40  mov      x2, xzr
0065D3D44  str      q0, [sp, #0x20]
0065D3D48  str      x9, [sp, #0x30]
0065D3D4C  str      x10, [sp, #0x50]
0065D3D50  str      q1, [sp, #0x40]
0065D3D54  str      q1, [sp]
0065D3D58  str      x10, [sp, #0x10]
0065D3D5C  bl       #0x7d5071c ; Photon.Deterministic.FPVector3$$Distance
0065D3D60  cmp      x0, #0x20, lsl #12
0065D3D64  b.lt     #0x65d3db0
0065D3D68  add      x23, x23, #1
0065D3D6C  cmp      x23, x21
0065D3D70  cset     w24, lo
0065D3D74  cmp      x21, x23
0065D3D78  add      x25, x25, #0x80
0065D3D7C  b.ne     #0x65d3d00
0065D3D80  b        #0x65d3db0 ; 
0065D3D84  ldr      x8, [x20, #0x10]
0065D3D88  ldr      q0, [x20]
0065D3D8C  ldr      x9, [x3, #0x60]
0065D3D90  add      x2, sp, #0x80
0065D3D94  mov      x0, x19
0065D3D98  mov      w1, w21
0065D3D9C  str      x8, [sp, #0x90]
0065D3DA0  str      q0, [sp, #0x80]
0065D3DA4  blr      x9
0065D3DA8  b        #0x65d3db4 ; 
0065D3DAC  mov      w24, wzr
0065D3DB0  eor      w0, w24, #1
0065D3DB4  ldr      x8, [x22, #0x28]
0065D3DB8  ldr      x9, [sp, #0x98]
0065D3DBC  cmp      x8, x9
0065D3DC0  b.ne     #0x65d3de8
0065D3DC4  ldp      x20, x19, [sp, #0xd0]
0065D3DC8  ldp      x22, x21, [sp, #0xc0]
0065D3DCC  ldp      x24, x23, [sp, #0xb0]
0065D3DD0  ldp      x30, x25, [sp, #0xa0]
0065D3DD4  and      w0, w0, #1
0065D3DD8  add      sp, sp, #0xe0
0065D3DDC  ret      
0065D3DE0  bl       #0x382bfb8 ; 
0065D3DE4  bl       #0x382bfc0 ; 
0065D3DE8  bl       #0x89edb60 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CreateBeeMonsterCreator
; RVA 0x65CE0B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CE0B0  str      x30, [sp, #-0x30]!
0065CE0B4  stp      x22, x21, [sp, #0x10]
0065CE0B8  stp      x20, x19, [sp, #0x20]
0065CE0BC  adrp     x20, #0x9599000
0065CE0C0  adrp     x21, #0x8f0a000
0065CE0C4  ldrb     w8, [x20, #0x594]
0065CE0C8  ldr      x21, [x21, #0x8d8]
0065CE0CC  mov      x19, x0
0065CE0D0  tbnz     w8, #0, #0x65ce118
0065CE0D4  adrp     x0, #0x8f09000
0065CE0D8  ldr      x0, [x0, #0xc08]
0065CE0DC  bl       #0x382bd14 ; 
0065CE0E0  adrp     x0, #0x8f0a000
0065CE0E4  ldr      x0, [x0, #0x860]
0065CE0E8  bl       #0x382bd14 ; 
0065CE0EC  adrp     x0, #0x8f0a000
0065CE0F0  ldr      x0, [x0, #0x8e0]
0065CE0F4  bl       #0x382bd14 ; 
0065CE0F8  adrp     x0, #0x8f0a000
0065CE0FC  ldr      x0, [x0, #0x8e8]
0065CE100  bl       #0x382bd14 ; 
0065CE104  adrp     x0, #0x8f0a000
0065CE108  ldr      x0, [x0, #0x8d8]
0065CE10C  bl       #0x382bd14 ; 
0065CE110  mov      w8, #1
0065CE114  strb     w8, [x20, #0x594]
0065CE118  ldr      x1, [x21]
0065CE11C  ldrb     w8, [x1, #0x53]
0065CE120  tbnz     w8, #5, #0x65ce1e0
0065CE124  ldr      x8, [x19, #0x190]
0065CE128  cbnz     x8, #0x65ce16c
0065CE12C  adrp     x8, #0x8f0a000
0065CE130  ldr      x8, [x8, #0x8e8]
0065CE134  add      x20, x19, #0x190
0065CE138  ldr      x0, [x8]
0065CE13C  bl       #0x382bfa0 ; 
0065CE140  adrp     x8, #0x8f0a000
0065CE144  ldr      x8, [x8, #0x8e0]
0065CE148  mov      x21, x0
0065CE14C  ldr      x1, [x8]
0065CE150  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0065CE154  mov      x0, x20
0065CE158  mov      x1, x21
0065CE15C  str      x21, [x20]
0065CE160  bl       #0x382bcb8 ; 
0065CE164  ldr      x8, [x20]
0065CE168  cbz      x8, #0x65ce3ec
0065CE16C  ldp      w2, w9, [x8, #0x18]
0065CE170  add      w9, w9, #1
0065CE174  cmp      w2, #1
0065CE178  stp      wzr, w9, [x8, #0x18]
0065CE17C  b.lt     #0x65ce190
0065CE180  ldr      x0, [x8, #0x10]
0065CE184  mov      w1, wzr
0065CE188  mov      x3, xzr
0065CE18C  bl       #0x7c001d0 ; System.Array$$Clear
0065CE190  ldr      x20, [x19, #0x188]
0065CE194  cbz      x20, #0x65ce3ec
0065CE198  adrp     x21, #0x8f09000
0065CE19C  ldr      x8, [x20]
0065CE1A0  ldr      x21, [x21, #0xc08]
0065CE1A4  ldrh     w9, [x8, #0x12e]
0065CE1A8  ldr      x1, [x21]
0065CE1AC  cbz      x9, #0x65ce1d0
0065CE1B0  ldr      x10, [x8, #0xb0]
0065CE1B4  add      x10, x10, #8
0065CE1B8  ldur     x11, [x10, #-8]
0065CE1BC  cmp      x11, x1
0065CE1C0  b.eq     #0x65ce1f8
0065CE1C4  subs     x9, x9, #1
0065CE1C8  add      x10, x10, #0x10
0065CE1CC  b.ne     #0x65ce1b8
0065CE1D0  mov      w2, #0x26
0065CE1D4  mov      x0, x20
0065CE1D8  bl       #0x3a7e710 ; 
0065CE1DC  b        #0x65ce208 ; 
0065CE1E0  ldr      x2, [x1, #0x60]
0065CE1E4  mov      x0, x19
0065CE1E8  ldp      x20, x19, [sp, #0x20]
0065CE1EC  ldp      x22, x21, [sp, #0x10]
0065CE1F0  ldr      x30, [sp], #0x30
0065CE1F4  br       x2
0065CE1F8  ldr      w9, [x10]
0065CE1FC  add      w9, w9, #0x26
0065CE200  add      x8, x8, w9, sxtw #4
0065CE204  add      x0, x8, #0x138
0065CE208  ldp      x8, x1, [x0]
0065CE20C  mov      x0, x20
0065CE210  blr      x8
0065CE214  cbz      x0, #0x65ce3dc
0065CE218  ldr      x20, [x19, #0x188]
0065CE21C  cbz      x20, #0x65ce3ec
0065CE220  ldr      x8, [x20]
0065CE224  ldr      x1, [x21]
0065CE228  ldrh     w9, [x8, #0x12e]
0065CE22C  cbz      x9, #0x65ce250
0065CE230  ldr      x10, [x8, #0xb0]
0065CE234  add      x10, x10, #8
0065CE238  ldur     x11, [x10, #-8]
0065CE23C  cmp      x11, x1
0065CE240  b.eq     #0x65ce260
0065CE244  subs     x9, x9, #1
0065CE248  add      x10, x10, #0x10
0065CE24C  b.ne     #0x65ce238
0065CE250  mov      w2, #0x26
0065CE254  mov      x0, x20
0065CE258  bl       #0x3a7e710 ; 
0065CE25C  b        #0x65ce270 ; 
0065CE260  ldr      w9, [x10]
0065CE264  add      w9, w9, #0x26
0065CE268  add      x8, x8, w9, sxtw #4
0065CE26C  add      x0, x8, #0x138
0065CE270  ldp      x8, x1, [x0]
0065CE274  mov      x0, x20
0065CE278  blr      x8
0065CE27C  cbz      x0, #0x65ce3ec
0065CE280  ldr      x8, [x0, #0x18]
0065CE284  cbz      x8, #0x65ce3dc
0065CE288  adrp     x20, #0x9599000
0065CE28C  ldrb     w8, [x20, #0x286]
0065CE290  cbnz     w8, #0x65ce2a8
0065CE294  adrp     x0, #0x8f07000
0065CE298  ldr      x0, [x0, #0xc98]
0065CE29C  bl       #0x382bd14 ; 
0065CE2A0  mov      w8, #1
0065CE2A4  strb     w8, [x20, #0x286]
0065CE2A8  adrp     x22, #0x8f07000
0065CE2AC  ldr      x22, [x22, #0xc98]
0065CE2B0  ldr      x1, [x22]
0065CE2B4  ldrb     w8, [x1, #0x53]
0065CE2B8  tbnz     w8, #5, #0x65ce2c4
0065CE2BC  ldr      x0, [x19, #0x80]
0065CE2C0  b        #0x65ce2d0 ; 
0065CE2C4  ldr      x8, [x1, #0x60]
0065CE2C8  mov      x0, x19
0065CE2CC  blr      x8
0065CE2D0  cbz      x0, #0x65ce3ec
0065CE2D4  ldrb     w8, [x0, #0x13]
0065CE2D8  cbz      w8, #0x65ce30c
0065CE2DC  ldrb     w8, [x20, #0x286]
0065CE2E0  cbnz     w8, #0x65ce2f8
0065CE2E4  adrp     x0, #0x8f07000
0065CE2E8  ldr      x0, [x0, #0xc98]
0065CE2EC  bl       #0x382bd14 ; 
0065CE2F0  mov      w8, #1
0065CE2F4  strb     w8, [x20, #0x286]
0065CE2F8  ldr      x1, [x22]
0065CE2FC  ldrb     w8, [x1, #0x53]
0065CE300  tbnz     w8, #5, #0x65ce354
0065CE304  ldr      x0, [x19, #0x80]
0065CE308  b        #0x65ce360 ; 
0065CE30C  ldr      x20, [x19, #0x188]
0065CE310  cbz      x20, #0x65ce3ec
0065CE314  ldr      x8, [x20]
0065CE318  ldr      x1, [x21]
0065CE31C  ldrh     w9, [x8, #0x12e]
0065CE320  cbz      x9, #0x65ce344
0065CE324  ldr      x10, [x8, #0xb0]
0065CE328  add      x10, x10, #8
0065CE32C  ldur     x11, [x10, #-8]
0065CE330  cmp      x11, x1
0065CE334  b.eq     #0x65ce37c
0065CE338  subs     x9, x9, #1
0065CE33C  add      x10, x10, #0x10
0065CE340  b.ne     #0x65ce32c
0065CE344  mov      w2, #0x26
0065CE348  mov      x0, x20
0065CE34C  bl       #0x3a7e710 ; 
0065CE350  b        #0x65ce38c ; 
0065CE354  ldr      x8, [x1, #0x60]
0065CE358  mov      x0, x19
0065CE35C  blr      x8
0065CE360  cbz      x0, #0x65ce3ec
0065CE364  ldr      w1, [x0, #0x1c]
0065CE368  mov      x0, x19
0065CE36C  ldp      x20, x19, [sp, #0x20]
0065CE370  ldp      x22, x21, [sp, #0x10]
0065CE374  ldr      x30, [sp], #0x30
0065CE378  b        #0x65d3dec ; HotFix.BattleLogic.WaterfallBattleManager$$onSetFlushId
0065CE37C  ldr      w9, [x10]
0065CE380  add      w9, w9, #0x26
0065CE384  add      x8, x8, w9, sxtw #4
0065CE388  add      x0, x8, #0x138
0065CE38C  ldp      x8, x1, [x0]
0065CE390  mov      x0, x20
0065CE394  blr      x8
0065CE398  cbz      x0, #0x65ce3ec
0065CE39C  ldr      x8, [x0, #0x18]
0065CE3A0  mov      x20, x0
0065CE3A4  cmp      w8, #1
0065CE3A8  b.lt     #0x65ce3dc
0065CE3AC  mov      x21, xzr
0065CE3B0  and      x8, x8, #0xffffffff
0065CE3B4  add      x22, x20, #0x20
0065CE3B8  cmp      x21, w8, uxtw
0065CE3BC  b.hs     #0x65ce3f0
0065CE3C0  ldr      w1, [x22, x21, lsl #2]
0065CE3C4  mov      x0, x19
0065CE3C8  bl       #0x65d3dec ; HotFix.BattleLogic.WaterfallBattleManager$$onSetFlushId
0065CE3CC  ldr      w8, [x20, #0x18]
0065CE3D0  add      x21, x21, #1
0065CE3D4  cmp      x21, w8, sxtw
0065CE3D8  b.lt     #0x65ce3b8
0065CE3DC  ldp      x20, x19, [sp, #0x20]
0065CE3E0  ldp      x22, x21, [sp, #0x10]
0065CE3E4  ldr      x30, [sp], #0x30
0065CE3E8  ret      
0065CE3EC  bl       #0x382bfb8 ; 
0065CE3F0  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$onSetFlushId
; RVA 0x65D3DEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D3DEC  str      x30, [sp, #-0x30]!
0065D3DF0  stp      x22, x21, [sp, #0x10]
0065D3DF4  stp      x20, x19, [sp, #0x20]
0065D3DF8  adrp     x21, #0x9599000
0065D3DFC  adrp     x22, #0x8f0a000
0065D3E00  ldrb     w8, [x21, #0x595]
0065D3E04  ldr      x22, [x22, #0xa90]
0065D3E08  mov      w20, w1
0065D3E0C  mov      x19, x0
0065D3E10  tbnz     w8, #0, #0x65d3e4c
0065D3E14  adrp     x0, #0x8f09000
0065D3E18  ldr      x0, [x0, #0xc08]
0065D3E1C  bl       #0x382bd14 ; 
0065D3E20  adrp     x0, #0x8f0a000
0065D3E24  ldr      x0, [x0, #0xa98]
0065D3E28  bl       #0x382bd14 ; 
0065D3E2C  adrp     x0, #0x8f0a000
0065D3E30  ldr      x0, [x0, #0xa90]
0065D3E34  bl       #0x382bd14 ; 
0065D3E38  adrp     x0, #0x8f0a000
0065D3E3C  ldr      x0, [x0, #0xaa0]
0065D3E40  bl       #0x382bd14 ; 
0065D3E44  mov      w8, #1
0065D3E48  strb     w8, [x21, #0x595]
0065D3E4C  ldr      x2, [x22]
0065D3E50  ldrb     w8, [x2, #0x53]
0065D3E54  tbnz     w8, #5, #0x65d3e9c
0065D3E58  cmp      w20, #1
0065D3E5C  b.lt     #0x65d3eb8
0065D3E60  adrp     x21, #0x9599000
0065D3E64  ldrb     w8, [x21, #0x286]
0065D3E68  cbnz     w8, #0x65d3e80
0065D3E6C  adrp     x0, #0x8f07000
0065D3E70  ldr      x0, [x0, #0xc98]
0065D3E74  bl       #0x382bd14 ; 
0065D3E78  mov      w8, #1
0065D3E7C  strb     w8, [x21, #0x286]
0065D3E80  adrp     x8, #0x8f07000
0065D3E84  ldr      x8, [x8, #0xc98]
0065D3E88  ldr      x1, [x8]
0065D3E8C  ldrb     w8, [x1, #0x53]
0065D3E90  tbnz     w8, #5, #0x65d3ec8
0065D3E94  ldr      x21, [x19, #0x80]
0065D3E98  b        #0x65d3ed8 ; 
0065D3E9C  ldr      x3, [x2, #0x60]
0065D3EA0  mov      x0, x19
0065D3EA4  mov      w1, w20
0065D3EA8  ldp      x20, x19, [sp, #0x20]
0065D3EAC  ldp      x22, x21, [sp, #0x10]
0065D3EB0  ldr      x30, [sp], #0x30
0065D3EB4  br       x3
0065D3EB8  ldp      x20, x19, [sp, #0x20]
0065D3EBC  ldp      x22, x21, [sp, #0x10]
0065D3EC0  ldr      x30, [sp], #0x30
0065D3EC4  ret      
0065D3EC8  ldr      x8, [x1, #0x60]
0065D3ECC  mov      x0, x19
0065D3ED0  blr      x8
0065D3ED4  mov      x21, x0
0065D3ED8  cbz      x21, #0x65d4048
0065D3EDC  adrp     x22, #0x9591000
0065D3EE0  ldrb     w8, [x22, #0xa4c]
0065D3EE4  cbnz     w8, #0x65d3efc
0065D3EE8  adrp     x0, #0x8ee5000
0065D3EEC  ldr      x0, [x0, #0xb30]
0065D3EF0  bl       #0x382bd14 ; 
0065D3EF4  mov      w8, #1
0065D3EF8  strb     w8, [x22, #0xa4c]
0065D3EFC  adrp     x8, #0x8ee5000
0065D3F00  ldr      x8, [x8, #0xb30]
0065D3F04  ldr      x1, [x8]
0065D3F08  ldrb     w8, [x1, #0x53]
0065D3F0C  tbnz     w8, #5, #0x65d3f18
0065D3F10  ldr      x0, [x21, #0x210]
0065D3F14  b        #0x65d3f24 ; 
0065D3F18  ldr      x8, [x1, #0x60]
0065D3F1C  mov      x0, x21
0065D3F20  blr      x8
0065D3F24  cbz      x0, #0x65d4048
0065D3F28  adrp     x8, #0x8f0a000
0065D3F2C  ldr      x8, [x8, #0xaa0]
0065D3F30  ldr      x1, [x8]
0065D3F34  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0065D3F38  cbz      x0, #0x65d4048
0065D3F3C  mov      w1, w20
0065D3F40  mov      x2, xzr
0065D3F44  mov      x21, x0
0065D3F48  bl       #0x65bb080 ; HotFix.BattleLogic.BeeMonsterCreator$$SetFlushId
0065D3F4C  ldr      x22, [x19, #0x188]
0065D3F50  cbz      x22, #0x65d4048
0065D3F54  adrp     x10, #0x8f09000
0065D3F58  ldr      x8, [x22]
0065D3F5C  ldr      x10, [x10, #0xc08]
0065D3F60  ldrh     w9, [x8, #0x12e]
0065D3F64  ldr      x1, [x10]
0065D3F68  cbz      x9, #0x65d3f8c
0065D3F6C  ldr      x10, [x8, #0xb0]
0065D3F70  add      x10, x10, #8
0065D3F74  ldur     x11, [x10, #-8]
0065D3F78  cmp      x11, x1
0065D3F7C  b.eq     #0x65d3f9c
0065D3F80  subs     x9, x9, #1
0065D3F84  add      x10, x10, #0x10
0065D3F88  b.ne     #0x65d3f74
0065D3F8C  mov      x0, x22
0065D3F90  mov      w2, wzr
0065D3F94  bl       #0x3a7e710 ; 
0065D3F98  b        #0x65d3fa8 ; 
0065D3F9C  ldrsw    x9, [x10]
0065D3FA0  add      x8, x8, x9, lsl #4
0065D3FA4  add      x0, x8, #0x138
0065D3FA8  ldp      x8, x1, [x0]
0065D3FAC  mov      x0, x22
0065D3FB0  blr      x8
0065D3FB4  mov      w2, w0
0065D3FB8  mov      x0, x21
0065D3FBC  mov      w1, w20
0065D3FC0  mov      x3, xzr
0065D3FC4  bl       #0x65b9e04 ; HotFix.BattleLogic.BeeMonsterCreator$$SetData
0065D3FC8  ldr      x0, [x19, #0x190]
0065D3FCC  cbz      x0, #0x65d4048
0065D3FD0  adrp     x9, #0x8f0a000
0065D3FD4  ldr      x9, [x9, #0xa98]
0065D3FD8  ldr      w10, [x0, #0x1c]
0065D3FDC  ldr      x8, [x0, #0x10]
0065D3FE0  ldr      x9, [x9]
0065D3FE4  add      w10, w10, #1
0065D3FE8  str      w10, [x0, #0x1c]
0065D3FEC  cbz      x8, #0x65d4048
0065D3FF0  ldrsw    x10, [x0, #0x18]
0065D3FF4  ldr      w11, [x8, #0x18]
0065D3FF8  cmp      w10, w11
0065D3FFC  b.hs     #0x65d4028
0065D4000  add      w9, w10, #1
0065D4004  add      x8, x8, x10, lsl #3
0065D4008  str      w9, [x0, #0x18]
0065D400C  str      x21, [x8, #0x20]!
0065D4010  mov      x1, x21
0065D4014  ldp      x20, x19, [sp, #0x20]
0065D4018  ldp      x22, x21, [sp, #0x10]
0065D401C  mov      x0, x8
0065D4020  ldr      x30, [sp], #0x30
0065D4024  b        #0x382bcb8 ; 
0065D4028  ldr      x8, [x9, #0x20]
0065D402C  mov      x1, x21
0065D4030  ldp      x20, x19, [sp, #0x20]
0065D4034  ldp      x22, x21, [sp, #0x10]
0065D4038  ldr      x8, [x8, #0xc0]
0065D403C  ldr      x2, [x8, #0x70]
0065D4040  ldr      x30, [sp], #0x30
0065D4044  b        #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0065D4048  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckContractDevil
; RVA 0x65D404C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D404C  stp      x30, x21, [sp, #-0x20]!
0065D4050  stp      x20, x19, [sp, #0x10]
0065D4054  adrp     x20, #0x9599000
0065D4058  adrp     x21, #0x8f0a000
0065D405C  ldrb     w8, [x20, #0x596]
0065D4060  ldr      x21, [x21, #0xaa8]
0065D4064  mov      x19, x0
0065D4068  tbnz     w8, #0, #0x65d4080
0065D406C  adrp     x0, #0x8f0a000
0065D4070  ldr      x0, [x0, #0xaa8]
0065D4074  bl       #0x382bd14 ; 
0065D4078  mov      w8, #1
0065D407C  strb     w8, [x20, #0x596]
0065D4080  ldr      x1, [x21]
0065D4084  ldrb     w8, [x1, #0x53]
0065D4088  tbnz     w8, #5, #0x65d40d4
0065D408C  ldr      w8, [x19, #0xe0]
0065D4090  cmp      w8, #2
0065D4094  b.ne     #0x65d41bc
0065D4098  adrp     x20, #0x9599000
0065D409C  ldrb     w8, [x20, #0x286]
0065D40A0  cbnz     w8, #0x65d40b8
0065D40A4  adrp     x0, #0x8f07000
0065D40A8  ldr      x0, [x0, #0xc98]
0065D40AC  bl       #0x382bd14 ; 
0065D40B0  mov      w8, #1
0065D40B4  strb     w8, [x20, #0x286]
0065D40B8  adrp     x21, #0x8f07000
0065D40BC  ldr      x21, [x21, #0xc98]
0065D40C0  ldr      x1, [x21]
0065D40C4  ldrb     w8, [x1, #0x53]
0065D40C8  tbnz     w8, #5, #0x65d40e8
0065D40CC  ldr      x0, [x19, #0x80]
0065D40D0  b        #0x65d40f4 ; 
0065D40D4  ldr      x2, [x1, #0x60]
0065D40D8  mov      x0, x19
0065D40DC  ldp      x20, x19, [sp, #0x10]
0065D40E0  ldp      x30, x21, [sp], #0x20
0065D40E4  br       x2
0065D40E8  ldr      x8, [x1, #0x60]
0065D40EC  mov      x0, x19
0065D40F0  blr      x8
0065D40F4  cbz      x0, #0x65d41cc
0065D40F8  ldr      w8, [x0, #0x1c8]
0065D40FC  cmp      w8, #2
0065D4100  b.eq     #0x65d41bc
0065D4104  ldrb     w8, [x20, #0x286]
0065D4108  cbnz     w8, #0x65d4120
0065D410C  adrp     x0, #0x8f07000
0065D4110  ldr      x0, [x0, #0xc98]
0065D4114  bl       #0x382bd14 ; 
0065D4118  mov      w8, #1
0065D411C  strb     w8, [x20, #0x286]
0065D4120  ldr      x1, [x21]
0065D4124  ldrb     w8, [x1, #0x53]
0065D4128  tbnz     w8, #5, #0x65d4134
0065D412C  ldr      x20, [x19, #0x80]
0065D4130  b        #0x65d4144 ; 
0065D4134  ldr      x8, [x1, #0x60]
0065D4138  mov      x0, x19
0065D413C  blr      x8
0065D4140  mov      x20, x0
0065D4144  cbz      x20, #0x65d41cc
0065D4148  adrp     x21, #0x9599000
0065D414C  ldrb     w8, [x21, #0x2a6]
0065D4150  cbnz     w8, #0x65d4168
0065D4154  adrp     x0, #0x8f08000
0065D4158  ldr      x0, [x0, #0x318]
0065D415C  bl       #0x382bd14 ; 
0065D4160  mov      w8, #1
0065D4164  strb     w8, [x21, #0x2a6]
0065D4168  adrp     x8, #0x8f08000
0065D416C  ldr      x8, [x8, #0x318]
0065D4170  ldr      x1, [x8]
0065D4174  ldrb     w8, [x1, #0x53]
0065D4178  tbnz     w8, #5, #0x65d4190
0065D417C  add      x0, x20, #0x290
0065D4180  mov      x1, xzr
0065D4184  bl       #0x658f8d8 ; HotFix.BattleLogic.BattleData$$GetNextMissionIndex
0065D4188  tbz      w0, #0x1f, #0x65d41a0
0065D418C  b        #0x65d41bc ; 
0065D4190  ldr      x8, [x1, #0x60]
0065D4194  mov      x0, x20
0065D4198  blr      x8
0065D419C  tbnz     w0, #0x1f, #0x65d41bc
0065D41A0  mov      w1, #8
0065D41A4  mov      w2, #1
0065D41A8  mov      x0, x19
0065D41AC  mov      x3, xzr
0065D41B0  mov      x4, xzr
0065D41B4  mov      x5, xzr
0065D41B8  bl       #0x6588780 ; HotFix.BattleLogic.BattleManager$$TriggerMissionEvent
0065D41BC  ldp      x20, x19, [sp, #0x10]
0065D41C0  mov      w0, wzr
0065D41C4  ldp      x30, x21, [sp], #0x20
0065D41C8  ret      
0065D41CC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$OnUpdateHook
; RVA 0x65D41D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D41D0  sub      sp, sp, #0xa0
0065D41D4  stp      x30, x25, [sp, #0x60]
0065D41D8  stp      x24, x23, [sp, #0x70]
0065D41DC  stp      x22, x21, [sp, #0x80]
0065D41E0  stp      x20, x19, [sp, #0x90]
0065D41E4  adrp     x21, #0x9599000
0065D41E8  adrp     x22, #0x8f0a000
0065D41EC  ldrb     w8, [x21, #0x597]
0065D41F0  ldr      x22, [x22, #0xab0]
0065D41F4  mov      x20, x1
0065D41F8  mov      x19, x0
0065D41FC  tbnz     w8, #0, #0x65d4298
0065D4200  adrp     x0, #0x8f07000
0065D4204  ldr      x0, [x0, #0xfd0]
0065D4208  bl       #0x382bd14 ; 
0065D420C  adrp     x0, #0x8f0a000
0065D4210  ldr      x0, [x0, #0xab8]
0065D4214  bl       #0x382bd14 ; 
0065D4218  adrp     x0, #0x8f0a000
0065D421C  ldr      x0, [x0, #0x848]
0065D4220  bl       #0x382bd14 ; 
0065D4224  adrp     x0, #0x8f0a000
0065D4228  ldr      x0, [x0, #0xac0]
0065D422C  bl       #0x382bd14 ; 
0065D4230  adrp     x0, #0x8f0a000
0065D4234  ldr      x0, [x0, #0x850]
0065D4238  bl       #0x382bd14 ; 
0065D423C  adrp     x0, #0x8f0a000
0065D4240  ldr      x0, [x0, #0x858]
0065D4244  bl       #0x382bd14 ; 
0065D4248  adrp     x0, #0x8f0a000
0065D424C  ldr      x0, [x0, #0xac8]
0065D4250  bl       #0x382bd14 ; 
0065D4254  adrp     x0, #0x8f0a000
0065D4258  ldr      x0, [x0, #0xad0]
0065D425C  bl       #0x382bd14 ; 
0065D4260  adrp     x0, #0x8f0a000
0065D4264  ldr      x0, [x0, #0xad8]
0065D4268  bl       #0x382bd14 ; 
0065D426C  adrp     x0, #0x8f0a000
0065D4270  ldr      x0, [x0, #0x868]
0065D4274  bl       #0x382bd14 ; 
0065D4278  adrp     x0, #0x8f0a000
0065D427C  ldr      x0, [x0, #0x870]
0065D4280  bl       #0x382bd14 ; 
0065D4284  adrp     x0, #0x8f0a000
0065D4288  ldr      x0, [x0, #0xab0]
0065D428C  bl       #0x382bd14 ; 
0065D4290  mov      w8, #1
0065D4294  strb     w8, [x21, #0x597]
0065D4298  ldr      x2, [x22]
0065D429C  ldrb     w8, [x2, #0x53]
0065D42A0  tbnz     w8, #5, #0x65d42f0
0065D42A4  adrp     x23, #0x9599000
0065D42A8  ldrb     w8, [x23, #0x286]
0065D42AC  stp      xzr, xzr, [sp, #0x40]
0065D42B0  str      xzr, [sp, #0x50]
0065D42B4  stp      xzr, xzr, [sp, #0x20]
0065D42B8  str      xzr, [sp, #0x30]
0065D42BC  cbnz     w8, #0x65d42d4
0065D42C0  adrp     x0, #0x8f07000
0065D42C4  ldr      x0, [x0, #0xc98]
0065D42C8  bl       #0x382bd14 ; 
0065D42CC  mov      w8, #1
0065D42D0  strb     w8, [x23, #0x286]
0065D42D4  adrp     x24, #0x8f07000
0065D42D8  ldr      x24, [x24, #0xc98]
0065D42DC  ldr      x1, [x24]
0065D42E0  ldrb     w8, [x1, #0x53]
0065D42E4  tbnz     w8, #5, #0x65d4314
0065D42E8  ldr      x21, [x19, #0x80]
0065D42EC  b        #0x65d4324 ; 
0065D42F0  ldr      x3, [x2, #0x60]
0065D42F4  mov      x0, x19
0065D42F8  mov      x1, x20
0065D42FC  ldp      x20, x19, [sp, #0x90]
0065D4300  ldp      x22, x21, [sp, #0x80]
0065D4304  ldp      x24, x23, [sp, #0x70]
0065D4308  ldp      x30, x25, [sp, #0x60]
0065D430C  add      sp, sp, #0xa0
0065D4310  br       x3
0065D4314  ldr      x8, [x1, #0x60]
0065D4318  mov      x0, x19
0065D431C  blr      x8
0065D4320  mov      x21, x0
0065D4324  cbz      x21, #0x65d46d0
0065D4328  adrp     x22, #0x9599000
0065D432C  ldrb     w8, [x22, #0x4c3]
0065D4330  cbnz     w8, #0x65d4348
0065D4334  adrp     x0, #0x8f08000
0065D4338  ldr      x0, [x0, #0xfe0]
0065D433C  bl       #0x382bd14 ; 
0065D4340  mov      w8, #1
0065D4344  strb     w8, [x22, #0x4c3]
0065D4348  adrp     x8, #0x8f08000
0065D434C  ldr      x8, [x8, #0xfe0]
0065D4350  ldr      x1, [x8]
0065D4354  ldrb     w8, [x1, #0x53]
0065D4358  tbnz     w8, #5, #0x65d4368
0065D435C  ldrb     w8, [x21, #0x120]
0065D4360  cbnz     w8, #0x65d46b0
0065D4364  b        #0x65d4378 ; 
0065D4368  ldr      x8, [x1, #0x60]
0065D436C  mov      x0, x21
0065D4370  blr      x8
0065D4374  tbnz     w0, #0, #0x65d46b0
0065D4378  mov      x0, x19
0065D437C  mov      x1, x20
0065D4380  mov      x2, xzr
0065D4384  bl       #0x6586084 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnUpdateHook
0065D4388  ldr      x0, [x19, #0x190]
0065D438C  cbz      x0, #0x65d4404
0065D4390  ldr      w8, [x0, #0x18]
0065D4394  cmp      w8, #1
0065D4398  b.lt     #0x65d4404
0065D439C  adrp     x8, #0x8f0a000
0065D43A0  ldr      x8, [x8, #0x868]
0065D43A4  ldr      x1, [x8]
0065D43A8  add      x8, sp, #8
0065D43AC  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
0065D43B0  ldur     q0, [sp, #8]
0065D43B4  ldr      x8, [sp, #0x18]
0065D43B8  adrp     x21, #0x8f0a000
0065D43BC  str      q0, [sp, #0x40]
0065D43C0  str      x8, [sp, #0x50]
0065D43C4  ldr      x21, [x21, #0x850]
0065D43C8  ldr      x1, [x21]
0065D43CC  add      x0, sp, #0x40
0065D43D0  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
0065D43D4  tbz      w0, #0, #0x65d43f0
0065D43D8  ldr      x0, [sp, #0x50]
0065D43DC  cbz      x0, #0x65d46cc
0065D43E0  mov      x1, x20
0065D43E4  mov      x2, xzr
0065D43E8  bl       #0x65ba3d0 ; HotFix.BattleLogic.BeeMonsterCreator$$Update
0065D43EC  b        #0x65d43c8 ; 
0065D43F0  adrp     x8, #0x8f0a000
0065D43F4  ldr      x8, [x8, #0x848]
0065D43F8  add      x0, sp, #0x40
0065D43FC  ldr      x1, [x8]
0065D4400  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065D4404  ldr      x8, [x19, #0x1c0]
0065D4408  ldrb     w9, [x19, #0x1a4]
0065D440C  add      x8, x8, x20
0065D4410  str      x8, [x19, #0x1c0]
0065D4414  cbz      w9, #0x65d444c
0065D4418  ldr      x9, [x19, #0x1b0]
0065D441C  cmp      x8, x9
0065D4420  b.lt     #0x65d444c
0065D4424  ldr      x0, [x19, #0x88]
0065D4428  mov      w8, #1
0065D442C  strh     wzr, [x19, #0x1a4]
0065D4430  strb     w8, [x19, #0x1a6]
0065D4434  cbz      x0, #0x65d46d0
0065D4438  adrp     x8, #0x8f07000
0065D443C  ldr      x8, [x8, #0xfd0]
0065D4440  mov      w1, #0x2a
0065D4444  ldr      x2, [x8]
0065D4448  bl       #0x60b34ec ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0065D444C  ldr      x0, [x19, #0x200]
0065D4450  cbz      x0, #0x65d46d0
0065D4454  adrp     x8, #0x8f0a000
0065D4458  ldr      x8, [x8, #0xad8]
0065D445C  ldr      x1, [x8]
0065D4460  add      x8, sp, #8
0065D4464  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
0065D4468  ldur     q0, [sp, #8]
0065D446C  ldr      x8, [sp, #0x18]
0065D4470  adrp     x22, #0x8f0a000
0065D4474  ldr      x22, [x22, #0xac0]
0065D4478  str      q0, [sp, #0x20]
0065D447C  str      x8, [sp, #0x30]
0065D4480  adrp     x25, #0x8f0a000
0065D4484  ldr      x25, [x25, #0xad0]
0065D4488  ldr      x1, [x22]
0065D448C  add      x0, sp, #0x20
0065D4490  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
0065D4494  tbz      w0, #0, #0x65d4500
0065D4498  ldr      x21, [sp, #0x30]
0065D449C  cbz      x21, #0x65d46c8
0065D44A0  ldr      x8, [x21]
0065D44A4  ldr      x1, [x25]
0065D44A8  ldrh     w9, [x8, #0x12e]
0065D44AC  cbz      x9, #0x65d44d0
0065D44B0  ldr      x10, [x8, #0xb0]
0065D44B4  add      x10, x10, #8
0065D44B8  ldur     x11, [x10, #-8]
0065D44BC  cmp      x11, x1
0065D44C0  b.eq     #0x65d44e0
0065D44C4  subs     x9, x9, #1
0065D44C8  add      x10, x10, #0x10
0065D44CC  b.ne     #0x65d44b8
0065D44D0  mov      x0, x21
0065D44D4  mov      w2, wzr
0065D44D8  bl       #0x3a7e710 ; 
0065D44DC  b        #0x65d44ec ; 
0065D44E0  ldrsw    x9, [x10]
0065D44E4  add      x8, x8, x9, lsl #4
0065D44E8  add      x0, x8, #0x138
0065D44EC  ldp      x8, x2, [x0]
0065D44F0  mov      x0, x21
0065D44F4  mov      x1, x20
0065D44F8  blr      x8
0065D44FC  b        #0x65d4488 ; 
0065D4500  adrp     x8, #0x8f0a000
0065D4504  ldr      x8, [x8, #0xab8]
0065D4508  add      x0, sp, #0x20
0065D450C  ldr      x1, [x8]
0065D4510  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065D4514  ldrb     w8, [x19, #0x1d4]
0065D4518  cbz      w8, #0x65d46b0
0065D451C  mov      x0, x19
0065D4520  bl       #0x65c8d70 ; HotFix.BattleLogic.WaterfallBattleManager$$CanRunUpLevelProgress
0065D4524  tbz      w0, #0, #0x65d46b0
0065D4528  ldrb     w8, [x23, #0x286]
0065D452C  cbnz     w8, #0x65d4544
0065D4530  adrp     x0, #0x8f07000
0065D4534  ldr      x0, [x0, #0xc98]
0065D4538  bl       #0x382bd14 ; 
0065D453C  mov      w8, #1
0065D4540  strb     w8, [x23, #0x286]
0065D4544  ldr      x1, [x24]
0065D4548  ldrb     w8, [x1, #0x53]
0065D454C  tbnz     w8, #5, #0x65d4558
0065D4550  ldr      x21, [x19, #0x80]
0065D4554  b        #0x65d4568 ; 
0065D4558  ldr      x8, [x1, #0x60]
0065D455C  mov      x0, x19
0065D4560  blr      x8
0065D4564  mov      x21, x0
0065D4568  cbz      x21, #0x65d46d0
0065D456C  adrp     x22, #0x9599000
0065D4570  ldrb     w8, [x22, #0x287]
0065D4574  cbnz     w8, #0x65d458c
0065D4578  adrp     x0, #0x8f07000
0065D457C  ldr      x0, [x0, #0xcf0]
0065D4580  bl       #0x382bd14 ; 
0065D4584  mov      w8, #1
0065D4588  strb     w8, [x22, #0x287]
0065D458C  adrp     x25, #0x8f07000
0065D4590  ldr      x25, [x25, #0xcf0]
0065D4594  ldr      x1, [x25]
0065D4598  ldrb     w8, [x1, #0x53]
0065D459C  tbnz     w8, #5, #0x65d45a8
0065D45A0  ldr      x0, [x21, #0x350]
0065D45A4  b        #0x65d45b4 ; 
0065D45A8  ldr      x8, [x1, #0x60]
0065D45AC  mov      x0, x21
0065D45B0  blr      x8
0065D45B4  cbz      x0, #0x65d46d0
0065D45B8  mov      x1, xzr
0065D45BC  bl       #0x666fea8 ; HotFix.BattleLogic.DropMgr$$HasEquip
0065D45C0  tbnz     w0, #0, #0x65d46b0
0065D45C4  ldrb     w8, [x23, #0x286]
0065D45C8  cbnz     w8, #0x65d45e0
0065D45CC  adrp     x0, #0x8f07000
0065D45D0  ldr      x0, [x0, #0xc98]
0065D45D4  bl       #0x382bd14 ; 
0065D45D8  mov      w8, #1
0065D45DC  strb     w8, [x23, #0x286]
0065D45E0  ldr      x1, [x24]
0065D45E4  ldrb     w8, [x1, #0x53]
0065D45E8  tbnz     w8, #5, #0x65d45f4
0065D45EC  ldr      x21, [x19, #0x80]
0065D45F0  b        #0x65d4604 ; 
0065D45F4  ldr      x8, [x1, #0x60]
0065D45F8  mov      x0, x19
0065D45FC  blr      x8
0065D4600  mov      x21, x0
0065D4604  cbz      x21, #0x65d46d0
0065D4608  ldrb     w8, [x22, #0x287]
0065D460C  cbnz     w8, #0x65d4624
0065D4610  adrp     x0, #0x8f07000
0065D4614  ldr      x0, [x0, #0xcf0]
0065D4618  bl       #0x382bd14 ; 
0065D461C  mov      w8, #1
0065D4620  strb     w8, [x22, #0x287]
0065D4624  ldr      x1, [x25]
0065D4628  ldrb     w8, [x1, #0x53]
0065D462C  tbnz     w8, #5, #0x65d4638
0065D4630  ldr      x0, [x21, #0x350]
0065D4634  b        #0x65d4644 ; 
0065D4638  ldr      x8, [x1, #0x60]
0065D463C  mov      x0, x21
0065D4640  blr      x8
0065D4644  cbz      x0, #0x65d46d0
0065D4648  mov      x1, xzr
0065D464C  bl       #0x666fd64 ; HotFix.BattleLogic.DropMgr$$HaveDropExp
0065D4650  tbnz     w0, #0, #0x65d46b0
0065D4654  ldr      x8, [x19]
0065D4658  mov      x0, x19
0065D465C  ldr      x9, [x8, #0x388]
0065D4660  ldr      x1, [x8, #0x390]
0065D4664  blr      x9
0065D4668  tbz      w0, #0, #0x65d46b0
0065D466C  ldr      x0, [x19, #0x90]
0065D4670  cbz      x0, #0x65d46d0
0065D4674  mov      x1, xzr
0065D4678  bl       #0x6851208 ; HotFix.BattleLogic.ExpAnimProcessor$$IsAdding
0065D467C  tbnz     w0, #0, #0x65d46b0
0065D4680  ldp      x9, x8, [x19, #0x1d8]
0065D4684  add      x8, x8, x20
0065D4688  cmp      x9, x8
0065D468C  str      x8, [x19, #0x1e0]
0065D4690  b.gt     #0x65d46b0
0065D4694  ldr      x8, [x19]
0065D4698  strb     wzr, [x19, #0x1d4]
0065D469C  mov      x0, x19
0065D46A0  ldr      x9, [x8, #0x288]
0065D46A4  ldr      x1, [x8, #0x290]
0065D46A8  blr      x9
0065D46AC  str      xzr, [x19, #0x1e0]
0065D46B0  ldp      x20, x19, [sp, #0x90]
0065D46B4  ldp      x22, x21, [sp, #0x80]
0065D46B8  ldp      x24, x23, [sp, #0x70]
0065D46BC  ldp      x30, x25, [sp, #0x60]
0065D46C0  add      sp, sp, #0xa0
0065D46C4  ret      
0065D46C8  bl       #0x382bfb8 ; 
0065D46CC  bl       #0x382bfb8 ; 
0065D46D0  bl       #0x382bfb8 ; 
0065D46D4  b        #0x65d46dc ; 
0065D46D8  b        #0x65d46dc ; 
0065D46DC  mov      x21, x0
0065D46E0  cmp      w1, #1
0065D46E4  b.ne     #0x65d4714
0065D46E8  mov      x0, x21
0065D46EC  bl       #0x89eda50 ; 
0065D46F0  ldr      x22, [x0]
0065D46F4  bl       #0x89eda60 ; 
0065D46F8  adrp     x8, #0x8f0a000
0065D46FC  ldr      x8, [x8, #0x848]
0065D4700  add      x0, sp, #0x40
0065D4704  ldr      x1, [x8]
0065D4708  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065D470C  cbz      x22, #0x65d4404
0065D4710  b        #0x65d477c ; 
0065D4714  mov      x22, xzr
0065D4718  b        #0x65d4720 ; 
0065D471C  mov      x21, x0
0065D4720  adrp     x8, #0x8f0a000
0065D4724  ldr      x8, [x8, #0x848]
0065D4728  ldr      x1, [x8]
0065D472C  add      x0, sp, #0x40
0065D4730  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065D4734  cbz      x22, #0x65d47a8
0065D4738  mov      x0, x22
0065D473C  bl       #0x382bfb0 ; 
0065D4740  b        #0x65d4748 ; 
0065D4744  b        #0x65d4748 ; 
0065D4748  mov      x21, x0
0065D474C  cmp      w1, #1
0065D4750  b.ne     #0x65d4784
0065D4754  mov      x0, x21
0065D4758  bl       #0x89eda50 ; 
0065D475C  ldr      x22, [x0]
0065D4760  bl       #0x89eda60 ; 
0065D4764  adrp     x8, #0x8f0a000
0065D4768  ldr      x8, [x8, #0xab8]
0065D476C  add      x0, sp, #0x20
0065D4770  ldr      x1, [x8]
0065D4774  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065D4778  cbz      x22, #0x65d4514
0065D477C  mov      x0, x22
0065D4780  bl       #0x382bfb0 ; 
0065D4784  mov      x22, xzr
0065D4788  b        #0x65d4790 ; 
0065D478C  mov      x21, x0
0065D4790  adrp     x8, #0x8f0a000
0065D4794  ldr      x8, [x8, #0xab8]
0065D4798  ldr      x1, [x8]
0065D479C  add      x0, sp, #0x20
0065D47A0  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065D47A4  cbnz     x22, #0x65d47b0
0065D47A8  mov      x0, x21
0065D47AC  bl       #0x3b56bfc ; 
0065D47B0  mov      x0, x22
0065D47B4  bl       #0x382bfb0 ; 
0065D47B8  bl       #0x3442448 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckIsPauseState
; RVA 0x65D47BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D47BC  stp      x30, x21, [sp, #-0x20]!
0065D47C0  stp      x20, x19, [sp, #0x10]
0065D47C4  adrp     x20, #0x9599000
0065D47C8  adrp     x21, #0x8f0a000
0065D47CC  ldrb     w8, [x20, #0x598]
0065D47D0  ldr      x21, [x21, #0xae0]
0065D47D4  mov      x19, x0
0065D47D8  tbnz     w8, #0, #0x65d47f0
0065D47DC  adrp     x0, #0x8f0a000
0065D47E0  ldr      x0, [x0, #0xae0]
0065D47E4  bl       #0x382bd14 ; 
0065D47E8  mov      w8, #1
0065D47EC  strb     w8, [x20, #0x598]
0065D47F0  ldr      x1, [x21]
0065D47F4  ldrb     w8, [x1, #0x53]
0065D47F8  tbnz     w8, #5, #0x65d4810
0065D47FC  mov      x0, x19
0065D4800  ldp      x20, x19, [sp, #0x10]
0065D4804  mov      w1, #1
0065D4808  ldp      x30, x21, [sp], #0x20
0065D480C  b        #0x65d4824 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckNeedPause
0065D4810  ldr      x2, [x1, #0x60]
0065D4814  mov      x0, x19
0065D4818  ldp      x20, x19, [sp, #0x10]
0065D481C  ldp      x30, x21, [sp], #0x20
0065D4820  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$CheckNeedPause
; RVA 0x65D4824; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D4824  str      x30, [sp, #-0x30]!
0065D4828  stp      x22, x21, [sp, #0x10]
0065D482C  stp      x20, x19, [sp, #0x20]
0065D4830  adrp     x21, #0x9599000
0065D4834  adrp     x22, #0x8f0a000
0065D4838  ldrb     w8, [x21, #0x599]
0065D483C  ldr      x22, [x22, #0xae8]
0065D4840  mov      w20, w1
0065D4844  mov      x19, x0
0065D4848  tbnz     w8, #0, #0x65d4860
0065D484C  adrp     x0, #0x8f0a000
0065D4850  ldr      x0, [x0, #0xae8]
0065D4854  bl       #0x382bd14 ; 
0065D4858  mov      w8, #1
0065D485C  strb     w8, [x21, #0x599]
0065D4860  ldr      x2, [x22]
0065D4864  ldrb     w8, [x2, #0x53]
0065D4868  tbnz     w8, #5, #0x65d48ac
0065D486C  tbz      w20, #0, #0x65d48c8
0065D4870  adrp     x20, #0x9599000
0065D4874  ldrb     w8, [x20, #0x286]
0065D4878  cbnz     w8, #0x65d4890
0065D487C  adrp     x0, #0x8f07000
0065D4880  ldr      x0, [x0, #0xc98]
0065D4884  bl       #0x382bd14 ; 
0065D4888  mov      w8, #1
0065D488C  strb     w8, [x20, #0x286]
0065D4890  adrp     x8, #0x8f07000
0065D4894  ldr      x8, [x8, #0xc98]
0065D4898  ldr      x1, [x8]
0065D489C  ldrb     w8, [x1, #0x53]
0065D48A0  tbnz     w8, #5, #0x65d48d0
0065D48A4  ldr      x0, [x19, #0x80]
0065D48A8  b        #0x65d48dc ; 
0065D48AC  ldr      x3, [x2, #0x60]
0065D48B0  and      w1, w20, #1
0065D48B4  mov      x0, x19
0065D48B8  ldp      x20, x19, [sp, #0x20]
0065D48BC  ldp      x22, x21, [sp, #0x10]
0065D48C0  ldr      x30, [sp], #0x30
0065D48C4  br       x3
0065D48C8  mov      w0, wzr
0065D48CC  b        #0x65d4914 ; 
0065D48D0  ldr      x8, [x1, #0x60]
0065D48D4  mov      x0, x19
0065D48D8  blr      x8
0065D48DC  cbz      x0, #0x65d4924
0065D48E0  mov      x1, xzr
0065D48E4  bl       #0x6a048d0 ; HotFix.BattleLogic.BattleWorldContext$$GetChapterChestType
0065D48E8  ldr      w8, [x19, #0xe0]
0065D48EC  cmp      w8, #3
0065D48F0  b.eq     #0x65d4910
0065D48F4  cmp      w8, #9
0065D48F8  b.ne     #0x65d4904
0065D48FC  cmp      w0, #1
0065D4900  b.eq     #0x65d4914
0065D4904  cmp      w8, #2
0065D4908  cset     w0, eq
0065D490C  b        #0x65d4914 ; 
0065D4910  mov      w0, #1
0065D4914  ldp      x20, x19, [sp, #0x20]
0065D4918  ldp      x22, x21, [sp, #0x10]
0065D491C  ldr      x30, [sp], #0x30
0065D4920  ret      
0065D4924  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$UpdateFightTime
; RVA 0x65CC05C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CC05C  stp      x30, x23, [sp, #-0x30]!
0065CC060  stp      x22, x21, [sp, #0x10]
0065CC064  stp      x20, x19, [sp, #0x20]
0065CC068  adrp     x20, #0x9599000
0065CC06C  adrp     x21, #0x8f0a000
0065CC070  ldrb     w8, [x20, #0x59a]
0065CC074  ldr      x21, [x21, #0x818]
0065CC078  mov      x19, x0
0065CC07C  tbnz     w8, #0, #0x65cc0b8
0065CC080  adrp     x0, #0x8f0a000
0065CC084  ldr      x0, [x0, #0x820]
0065CC088  bl       #0x382bd14 ; 
0065CC08C  adrp     x0, #0x8f09000
0065CC090  ldr      x0, [x0, #0xc08]
0065CC094  bl       #0x382bd14 ; 
0065CC098  adrp     x0, #0x8f0a000
0065CC09C  ldr      x0, [x0, #0x828]
0065CC0A0  bl       #0x382bd14 ; 
0065CC0A4  adrp     x0, #0x8f0a000
0065CC0A8  ldr      x0, [x0, #0x818]
0065CC0AC  bl       #0x382bd14 ; 
0065CC0B0  mov      w8, #1
0065CC0B4  strb     w8, [x20, #0x59a]
0065CC0B8  ldr      x1, [x21]
0065CC0BC  ldrb     w8, [x1, #0x53]
0065CC0C0  tbnz     w8, #5, #0x65cc118
0065CC0C4  ldr      x20, [x19, #0x188]
0065CC0C8  cbz      x20, #0x65cc3f4
0065CC0CC  adrp     x21, #0x8f09000
0065CC0D0  ldr      x8, [x20]
0065CC0D4  ldr      w22, [x19, #0x134]
0065CC0D8  ldr      x21, [x21, #0xc08]
0065CC0DC  ldrh     w9, [x8, #0x12e]
0065CC0E0  ldr      x1, [x21]
0065CC0E4  cbz      x9, #0x65cc108
0065CC0E8  ldr      x10, [x8, #0xb0]
0065CC0EC  add      x10, x10, #8
0065CC0F0  ldur     x11, [x10, #-8]
0065CC0F4  cmp      x11, x1
0065CC0F8  b.eq     #0x65cc130
0065CC0FC  subs     x9, x9, #1
0065CC100  add      x10, x10, #0x10
0065CC104  b.ne     #0x65cc0f0
0065CC108  mov      x0, x20
0065CC10C  mov      w2, wzr
0065CC110  bl       #0x3a7e710 ; 
0065CC114  b        #0x65cc13c ; 
0065CC118  ldr      x2, [x1, #0x60]
0065CC11C  mov      x0, x19
0065CC120  ldp      x20, x19, [sp, #0x20]
0065CC124  ldp      x22, x21, [sp, #0x10]
0065CC128  ldp      x30, x23, [sp], #0x30
0065CC12C  br       x2
0065CC130  ldrsw    x9, [x10]
0065CC134  add      x8, x8, x9, lsl #4
0065CC138  add      x0, x8, #0x138
0065CC13C  ldp      x8, x1, [x0]
0065CC140  mov      x0, x20
0065CC144  blr      x8
0065CC148  cmp      w22, w0
0065CC14C  b.ne     #0x65cc250
0065CC150  ldr      x20, [x19, #0x188]
0065CC154  cbz      x20, #0x65cc3f4
0065CC158  ldr      x8, [x20]
0065CC15C  ldr      x1, [x21]
0065CC160  ldrh     w9, [x8, #0x12e]
0065CC164  cbz      x9, #0x65cc188
0065CC168  ldr      x10, [x8, #0xb0]
0065CC16C  add      x10, x10, #8
0065CC170  ldur     x11, [x10, #-8]
0065CC174  cmp      x11, x1
0065CC178  b.eq     #0x65cc198
0065CC17C  subs     x9, x9, #1
0065CC180  add      x10, x10, #0x10
0065CC184  b.ne     #0x65cc170
0065CC188  mov      w2, #2
0065CC18C  mov      x0, x20
0065CC190  bl       #0x3a7e710 ; 
0065CC194  b        #0x65cc1a8 ; 
0065CC198  ldr      w9, [x10]
0065CC19C  add      w9, w9, #2
0065CC1A0  add      x8, x8, w9, sxtw #4
0065CC1A4  add      x0, x8, #0x138
0065CC1A8  ldp      x8, x1, [x0]
0065CC1AC  mov      x0, x20
0065CC1B0  blr      x8
0065CC1B4  mov      w1, w0
0065CC1B8  mov      x0, x19
0065CC1BC  bl       #0x65c75bc ; HotFix.BattleLogic.WaterfallBattleManager$$set_CurShowWaveIndex
0065CC1C0  mov      x0, x19
0065CC1C4  bl       #0x65ce628 ; HotFix.BattleLogic.WaterfallBattleManager$$tryStartMissileBoostOnWaveStart
0065CC1C8  adrp     x21, #0x9599000
0065CC1CC  ldrb     w8, [x21, #0x286]
0065CC1D0  cbnz     w8, #0x65cc1e8
0065CC1D4  adrp     x0, #0x8f07000
0065CC1D8  ldr      x0, [x0, #0xc98]
0065CC1DC  bl       #0x382bd14 ; 
0065CC1E0  mov      w8, #1
0065CC1E4  strb     w8, [x21, #0x286]
0065CC1E8  adrp     x22, #0x8f07000
0065CC1EC  ldr      x22, [x22, #0xc98]
0065CC1F0  ldr      x1, [x22]
0065CC1F4  ldrb     w8, [x1, #0x53]
0065CC1F8  tbnz     w8, #5, #0x65cc204
0065CC1FC  ldr      x0, [x19, #0x80]
0065CC200  b        #0x65cc210 ; 
0065CC204  ldr      x8, [x1, #0x60]
0065CC208  mov      x0, x19
0065CC20C  blr      x8
0065CC210  cbz      x0, #0x65cc3f4
0065CC214  ldr      w8, [x0, #0x1c8]
0065CC218  cmp      w8, #2
0065CC21C  b.ne     #0x65cc250
0065CC220  ldrb     w8, [x21, #0x286]
0065CC224  cbnz     w8, #0x65cc23c
0065CC228  adrp     x0, #0x8f07000
0065CC22C  ldr      x0, [x0, #0xc98]
0065CC230  bl       #0x382bd14 ; 
0065CC234  mov      w8, #1
0065CC238  strb     w8, [x21, #0x286]
0065CC23C  ldr      x1, [x22]
0065CC240  ldrb     w8, [x1, #0x53]
0065CC244  tbnz     w8, #5, #0x65cc260
0065CC248  ldr      x20, [x19, #0x80]
0065CC24C  b        #0x65cc270 ; 
0065CC250  ldp      x20, x19, [sp, #0x20]
0065CC254  ldp      x22, x21, [sp, #0x10]
0065CC258  ldp      x30, x23, [sp], #0x30
0065CC25C  ret      
0065CC260  ldr      x8, [x1, #0x60]
0065CC264  mov      x0, x19
0065CC268  blr      x8
0065CC26C  mov      x20, x0
0065CC270  cbz      x20, #0x65cc3f4
0065CC274  adrp     x23, #0x9591000
0065CC278  ldrb     w8, [x23, #0xa61]
0065CC27C  cbnz     w8, #0x65cc294
0065CC280  adrp     x0, #0x8ee6000
0065CC284  ldr      x0, [x0, #0x308]
0065CC288  bl       #0x382bd14 ; 
0065CC28C  mov      w8, #1
0065CC290  strb     w8, [x23, #0xa61]
0065CC294  adrp     x8, #0x8ee6000
0065CC298  ldr      x8, [x8, #0x308]
0065CC29C  ldr      x1, [x8]
0065CC2A0  ldrb     w8, [x1, #0x53]
0065CC2A4  tbnz     w8, #5, #0x65cc2b0
0065CC2A8  ldr      x0, [x20, #0x1e8]
0065CC2AC  b        #0x65cc2bc ; 
0065CC2B0  ldr      x8, [x1, #0x60]
0065CC2B4  mov      x0, x20
0065CC2B8  blr      x8
0065CC2BC  cbz      x0, #0x65cc3f4
0065CC2C0  adrp     x8, #0x8f0a000
0065CC2C4  ldr      x8, [x8, #0x828]
0065CC2C8  ldr      x1, [x8]
0065CC2CC  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065CC2D0  adrp     x23, #0x9599000
0065CC2D4  ldrb     w8, [x23, #0x652]
0065CC2D8  mov      x20, x0
0065CC2DC  cbnz     w8, #0x65cc2f4
0065CC2E0  adrp     x0, #0x8f0a000
0065CC2E4  ldr      x0, [x0, #0x668]
0065CC2E8  bl       #0x382bd14 ; 
0065CC2EC  mov      w8, #1
0065CC2F0  strb     w8, [x23, #0x652]
0065CC2F4  adrp     x8, #0x8f0a000
0065CC2F8  ldr      x8, [x8, #0x668]
0065CC2FC  ldr      x1, [x8]
0065CC300  ldrb     w8, [x1, #0x53]
0065CC304  tbnz     w8, #5, #0x65cc310
0065CC308  ldr      w0, [x19, #0x12c]
0065CC30C  b        #0x65cc31c ; 
0065CC310  ldr      x8, [x1, #0x60]
0065CC314  mov      x0, x19
0065CC318  blr      x8
0065CC31C  cbz      x20, #0x65cc3f4
0065CC320  str      w0, [x20, #0x20]
0065CC324  ldrb     w8, [x21, #0x286]
0065CC328  cbnz     w8, #0x65cc340
0065CC32C  adrp     x0, #0x8f07000
0065CC330  ldr      x0, [x0, #0xc98]
0065CC334  bl       #0x382bd14 ; 
0065CC338  mov      w8, #1
0065CC33C  strb     w8, [x21, #0x286]
0065CC340  ldr      x1, [x22]
0065CC344  ldrb     w8, [x1, #0x53]
0065CC348  tbnz     w8, #5, #0x65cc354
0065CC34C  ldr      x0, [x19, #0x80]
0065CC350  b        #0x65cc360 ; 
0065CC354  ldr      x8, [x1, #0x60]
0065CC358  mov      x0, x19
0065CC35C  blr      x8
0065CC360  cbz      x0, #0x65cc3f4
0065CC364  ldr      x19, [x0, #0x1e0]
0065CC368  cbz      x19, #0x65cc3f4
0065CC36C  adrp     x9, #0x8f0a000
0065CC370  ldr      x9, [x9, #0x820]
0065CC374  ldr      x8, [x19]
0065CC378  ldr      x21, [x9]
0065CC37C  ldrh     w9, [x8, #0x12e]
0065CC380  ldr      x1, [x21, #0x20]
0065CC384  ldrh     w2, [x21, #0x50]
0065CC388  cbz      x9, #0x65cc3ac
0065CC38C  ldr      x10, [x8, #0xb0]
0065CC390  add      x10, x10, #8
0065CC394  ldur     x11, [x10, #-8]
0065CC398  cmp      x11, x1
0065CC39C  b.eq     #0x65cc3b8
0065CC3A0  subs     x9, x9, #1
0065CC3A4  add      x10, x10, #0x10
0065CC3A8  b.ne     #0x65cc394
0065CC3AC  mov      x0, x19
0065CC3B0  bl       #0x3a7e710 ; 
0065CC3B4  b        #0x65cc3c8 ; 
0065CC3B8  ldr      w9, [x10]
0065CC3BC  add      w9, w9, w2
0065CC3C0  add      x8, x8, w9, sxtw #4
0065CC3C4  add      x0, x8, #0x138
0065CC3C8  ldr      x0, [x0, #8]
0065CC3CC  mov      x1, x21
0065CC3D0  bl       #0x382be88 ; 
0065CC3D4  mov      x2, x0
0065CC3D8  ldr      x3, [x0, #8]
0065CC3DC  mov      x0, x19
0065CC3E0  mov      x1, x20
0065CC3E4  ldp      x20, x19, [sp, #0x20]
0065CC3E8  ldp      x22, x21, [sp, #0x10]
0065CC3EC  ldp      x30, x23, [sp], #0x30
0065CC3F0  br       x3
0065CC3F4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$GetBattleShowWave
; RVA 0x65D4928; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D4928  stp      x30, x21, [sp, #-0x20]!
0065D492C  stp      x20, x19, [sp, #0x10]
0065D4930  adrp     x20, #0x9599000
0065D4934  adrp     x21, #0x8f0a000
0065D4938  ldrb     w8, [x20, #0x59b]
0065D493C  ldr      x21, [x21, #0xaf0]
0065D4940  mov      x19, x0
0065D4944  tbnz     w8, #0, #0x65d495c
0065D4948  adrp     x0, #0x8f0a000
0065D494C  ldr      x0, [x0, #0xaf0]
0065D4950  bl       #0x382bd14 ; 
0065D4954  mov      w8, #1
0065D4958  strb     w8, [x20, #0x59b]
0065D495C  ldr      x1, [x21]
0065D4960  ldrb     w8, [x1, #0x53]
0065D4964  tbnz     w8, #5, #0x65d49ac
0065D4968  adrp     x20, #0x9599000
0065D496C  ldrb     w8, [x20, #0x652]
0065D4970  cbnz     w8, #0x65d4988
0065D4974  adrp     x0, #0x8f0a000
0065D4978  ldr      x0, [x0, #0x668]
0065D497C  bl       #0x382bd14 ; 
0065D4980  mov      w8, #1
0065D4984  strb     w8, [x20, #0x652]
0065D4988  adrp     x8, #0x8f0a000
0065D498C  ldr      x8, [x8, #0x668]
0065D4990  ldr      x1, [x8]
0065D4994  ldrb     w8, [x1, #0x53]
0065D4998  tbnz     w8, #5, #0x65d49ac
0065D499C  ldr      w0, [x19, #0x12c]
0065D49A0  ldp      x20, x19, [sp, #0x10]
0065D49A4  ldp      x30, x21, [sp], #0x20
0065D49A8  ret      
0065D49AC  ldr      x2, [x1, #0x60]
0065D49B0  mov      x0, x19
0065D49B4  ldp      x20, x19, [sp, #0x10]
0065D49B8  ldp      x30, x21, [sp], #0x20
0065D49BC  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$IsDropClear
; RVA 0x65D49C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D49C0  stp      x30, x21, [sp, #-0x20]!
0065D49C4  stp      x20, x19, [sp, #0x10]
0065D49C8  adrp     x20, #0x9599000
0065D49CC  adrp     x21, #0x8f0a000
0065D49D0  ldrb     w8, [x20, #0x59c]
0065D49D4  ldr      x21, [x21, #0xaf8]
0065D49D8  mov      x19, x0
0065D49DC  tbnz     w8, #0, #0x65d49f4
0065D49E0  adrp     x0, #0x8f0a000
0065D49E4  ldr      x0, [x0, #0xaf8]
0065D49E8  bl       #0x382bd14 ; 
0065D49EC  mov      w8, #1
0065D49F0  strb     w8, [x20, #0x59c]
0065D49F4  ldr      x1, [x21]
0065D49F8  ldrb     w8, [x1, #0x53]
0065D49FC  tbnz     w8, #5, #0x65d4a3c
0065D4A00  adrp     x20, #0x9599000
0065D4A04  ldrb     w8, [x20, #0x286]
0065D4A08  cbnz     w8, #0x65d4a20
0065D4A0C  adrp     x0, #0x8f07000
0065D4A10  ldr      x0, [x0, #0xc98]
0065D4A14  bl       #0x382bd14 ; 
0065D4A18  mov      w8, #1
0065D4A1C  strb     w8, [x20, #0x286]
0065D4A20  adrp     x8, #0x8f07000
0065D4A24  ldr      x8, [x8, #0xc98]
0065D4A28  ldr      x1, [x8]
0065D4A2C  ldrb     w8, [x1, #0x53]
0065D4A30  tbnz     w8, #5, #0x65d4a50
0065D4A34  ldr      x20, [x19, #0x80]
0065D4A38  b        #0x65d4a60 ; 
0065D4A3C  ldr      x2, [x1, #0x60]
0065D4A40  mov      x0, x19
0065D4A44  ldp      x20, x19, [sp, #0x10]
0065D4A48  ldp      x30, x21, [sp], #0x20
0065D4A4C  br       x2
0065D4A50  ldr      x8, [x1, #0x60]
0065D4A54  mov      x0, x19
0065D4A58  blr      x8
0065D4A5C  mov      x20, x0
0065D4A60  cbz      x20, #0x65d4b30
0065D4A64  adrp     x21, #0x9598000
0065D4A68  ldrb     w8, [x21, #0xfc4]
0065D4A6C  cbnz     w8, #0x65d4a84
0065D4A70  adrp     x0, #0x8f05000
0065D4A74  ldr      x0, [x0, #0xfd8]
0065D4A78  bl       #0x382bd14 ; 
0065D4A7C  mov      w8, #1
0065D4A80  strb     w8, [x21, #0xfc4]
0065D4A84  adrp     x8, #0x8f05000
0065D4A88  ldr      x8, [x8, #0xfd8]
0065D4A8C  ldr      x1, [x8]
0065D4A90  ldrb     w8, [x1, #0x53]
0065D4A94  tbnz     w8, #5, #0x65d4aa0
0065D4A98  ldr      x20, [x20, #0x220]
0065D4A9C  b        #0x65d4ab0 ; 
0065D4AA0  ldr      x8, [x1, #0x60]
0065D4AA4  mov      x0, x20
0065D4AA8  blr      x8
0065D4AAC  mov      x20, x0
0065D4AB0  cbz      x20, #0x65d4b30
0065D4AB4  adrp     x21, #0x9599000
0065D4AB8  ldrb     w8, [x21, #0x28c]
0065D4ABC  cbnz     w8, #0x65d4ad4
0065D4AC0  adrp     x0, #0x8f07000
0065D4AC4  ldr      x0, [x0, #0xdf0]
0065D4AC8  bl       #0x382bd14 ; 
0065D4ACC  mov      w8, #1
0065D4AD0  strb     w8, [x21, #0x28c]
0065D4AD4  adrp     x8, #0x8f07000
0065D4AD8  ldr      x8, [x8, #0xdf0]
0065D4ADC  ldr      x1, [x8]
0065D4AE0  ldrb     w8, [x1, #0x53]
0065D4AE4  tbnz     w8, #5, #0x65d4af0
0065D4AE8  ldr      w0, [x20, #0x28]
0065D4AEC  b        #0x65d4afc ; 
0065D4AF0  ldr      x8, [x1, #0x60]
0065D4AF4  mov      x0, x20
0065D4AF8  blr      x8
0065D4AFC  cmp      w0, #1
0065D4B00  b.ne     #0x65d4b18
0065D4B04  ldr      x0, [x19, #0x90]
0065D4B08  cbz      x0, #0x65d4b30
0065D4B0C  mov      x1, xzr
0065D4B10  bl       #0x6851180 ; HotFix.BattleLogic.ExpAnimProcessor$$IsIdleOrWaitLevelUp
0065D4B14  tbz      w0, #0, #0x65d4b20
0065D4B18  mov      w0, #1
0065D4B1C  b        #0x65d4b24 ; 
0065D4B20  mov      w0, wzr
0065D4B24  ldp      x20, x19, [sp, #0x10]
0065D4B28  ldp      x30, x21, [sp], #0x20
0065D4B2C  ret      
0065D4B30  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CanTriggerSkill
; RVA 0x65D4B34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D4B34  stp      x30, x21, [sp, #-0x20]!
0065D4B38  stp      x20, x19, [sp, #0x10]
0065D4B3C  adrp     x20, #0x9599000
0065D4B40  adrp     x21, #0x8f0a000
0065D4B44  ldrb     w8, [x20, #0x59d]
0065D4B48  ldr      x21, [x21, #0xb00]
0065D4B4C  mov      x19, x0
0065D4B50  tbnz     w8, #0, #0x65d4b68
0065D4B54  adrp     x0, #0x8f0a000
0065D4B58  ldr      x0, [x0, #0xb00]
0065D4B5C  bl       #0x382bd14 ; 
0065D4B60  mov      w8, #1
0065D4B64  strb     w8, [x20, #0x59d]
0065D4B68  ldr      x1, [x21]
0065D4B6C  ldrb     w8, [x1, #0x53]
0065D4B70  tbnz     w8, #5, #0x65d4bc0
0065D4B74  mov      x0, x19
0065D4B78  mov      x1, xzr
0065D4B7C  bl       #0x6587254 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_InRefreshState
0065D4B80  tbnz     w0, #0, #0x65d4bf0
0065D4B84  adrp     x20, #0x9599000
0065D4B88  ldrb     w8, [x20, #0x286]
0065D4B8C  cbnz     w8, #0x65d4ba4
0065D4B90  adrp     x0, #0x8f07000
0065D4B94  ldr      x0, [x0, #0xc98]
0065D4B98  bl       #0x382bd14 ; 
0065D4B9C  mov      w8, #1
0065D4BA0  strb     w8, [x20, #0x286]
0065D4BA4  adrp     x8, #0x8f07000
0065D4BA8  ldr      x8, [x8, #0xc98]
0065D4BAC  ldr      x1, [x8]
0065D4BB0  ldrb     w8, [x1, #0x53]
0065D4BB4  tbnz     w8, #5, #0x65d4bd4
0065D4BB8  ldr      x0, [x19, #0x80]
0065D4BBC  b        #0x65d4be0 ; 
0065D4BC0  ldr      x2, [x1, #0x60]
0065D4BC4  mov      x0, x19
0065D4BC8  ldp      x20, x19, [sp, #0x10]
0065D4BCC  ldp      x30, x21, [sp], #0x20
0065D4BD0  br       x2
0065D4BD4  ldr      x8, [x1, #0x60]
0065D4BD8  mov      x0, x19
0065D4BDC  blr      x8
0065D4BE0  cbz      x0, #0x65d4c14
0065D4BE4  mov      x1, xzr
0065D4BE8  bl       #0x6a16b50 ; HotFix.BattleLogic.BattleWorldContext$$HasNpc
0065D4BEC  tbz      w0, #0, #0x65d4bf8
0065D4BF0  mov      w0, wzr
0065D4BF4  b        #0x65d4c08 ; 
0065D4BF8  ldr      w8, [x19, #0xe0]
0065D4BFC  sub      w8, w8, #3
0065D4C00  cmp      w8, #1
0065D4C04  cset     w0, hi
0065D4C08  ldp      x20, x19, [sp, #0x10]
0065D4C0C  ldp      x30, x21, [sp], #0x20
0065D4C10  ret      
0065D4C14  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckGoNextMission
; RVA 0x65D4C18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D4C18  str      x30, [sp, #-0x30]!
0065D4C1C  stp      x22, x21, [sp, #0x10]
0065D4C20  stp      x20, x19, [sp, #0x20]
0065D4C24  adrp     x20, #0x9599000
0065D4C28  adrp     x21, #0x8f0a000
0065D4C2C  ldrb     w8, [x20, #0x59e]
0065D4C30  ldr      x21, [x21, #0xb08]
0065D4C34  mov      x19, x0
0065D4C38  tbnz     w8, #0, #0x65d4c50
0065D4C3C  adrp     x0, #0x8f0a000
0065D4C40  ldr      x0, [x0, #0xb08]
0065D4C44  bl       #0x382bd14 ; 
0065D4C48  mov      w8, #1
0065D4C4C  strb     w8, [x20, #0x59e]
0065D4C50  ldr      x1, [x21]
0065D4C54  ldrb     w8, [x1, #0x53]
0065D4C58  tbnz     w8, #5, #0x65d4c98
0065D4C5C  adrp     x21, #0x9599000
0065D4C60  ldrb     w8, [x21, #0x286]
0065D4C64  cbnz     w8, #0x65d4c7c
0065D4C68  adrp     x0, #0x8f07000
0065D4C6C  ldr      x0, [x0, #0xc98]
0065D4C70  bl       #0x382bd14 ; 
0065D4C74  mov      w8, #1
0065D4C78  strb     w8, [x21, #0x286]
0065D4C7C  adrp     x22, #0x8f07000
0065D4C80  ldr      x22, [x22, #0xc98]
0065D4C84  ldr      x1, [x22]
0065D4C88  ldrb     w8, [x1, #0x53]
0065D4C8C  tbnz     w8, #5, #0x65d4cb0
0065D4C90  ldr      x0, [x19, #0x80]
0065D4C94  b        #0x65d4cbc ; 
0065D4C98  ldr      x2, [x1, #0x60]
0065D4C9C  mov      x0, x19
0065D4CA0  ldp      x20, x19, [sp, #0x20]
0065D4CA4  ldp      x22, x21, [sp, #0x10]
0065D4CA8  ldr      x30, [sp], #0x30
0065D4CAC  br       x2
0065D4CB0  ldr      x8, [x1, #0x60]
0065D4CB4  mov      x0, x19
0065D4CB8  blr      x8
0065D4CBC  cbz      x0, #0x65d4dbc
0065D4CC0  mov      x1, xzr
0065D4CC4  bl       #0x6a048d0 ; HotFix.BattleLogic.BattleWorldContext$$GetChapterChestType
0065D4CC8  ldr      w8, [x19, #0xe0]
0065D4CCC  mov      w20, w0
0065D4CD0  cmp      w8, #3
0065D4CD4  b.ne     #0x65d4d28
0065D4CD8  ldrb     w8, [x21, #0x286]
0065D4CDC  cbnz     w8, #0x65d4cf4
0065D4CE0  adrp     x0, #0x8f07000
0065D4CE4  ldr      x0, [x0, #0xc98]
0065D4CE8  bl       #0x382bd14 ; 
0065D4CEC  mov      w8, #1
0065D4CF0  strb     w8, [x21, #0x286]
0065D4CF4  ldr      x1, [x22]
0065D4CF8  ldrb     w8, [x1, #0x53]
0065D4CFC  tbnz     w8, #5, #0x65d4d08
0065D4D00  ldr      x0, [x19, #0x80]
0065D4D04  b        #0x65d4d14 ; 
0065D4D08  ldr      x8, [x1, #0x60]
0065D4D0C  mov      x0, x19
0065D4D10  blr      x8
0065D4D14  cbz      x0, #0x65d4dbc
0065D4D18  mov      x1, xzr
0065D4D1C  bl       #0x6a16b50 ; HotFix.BattleLogic.BattleWorldContext$$HasNpc
0065D4D20  tbnz     w0, #0, #0x65d4d94
0065D4D24  ldr      w8, [x19, #0xe0]
0065D4D28  cmp      w20, #1
0065D4D2C  b.ne     #0x65d4d84
0065D4D30  cmp      w8, #9
0065D4D34  b.ne     #0x65d4d84
0065D4D38  ldrb     w8, [x21, #0x286]
0065D4D3C  cbnz     w8, #0x65d4d54
0065D4D40  adrp     x0, #0x8f07000
0065D4D44  ldr      x0, [x0, #0xc98]
0065D4D48  bl       #0x382bd14 ; 
0065D4D4C  mov      w8, #1
0065D4D50  strb     w8, [x21, #0x286]
0065D4D54  ldr      x1, [x22]
0065D4D58  ldrb     w8, [x1, #0x53]
0065D4D5C  tbnz     w8, #5, #0x65d4d68
0065D4D60  ldr      x0, [x19, #0x80]
0065D4D64  b        #0x65d4d74 ; 
0065D4D68  ldr      x8, [x1, #0x60]
0065D4D6C  mov      x0, x19
0065D4D70  blr      x8
0065D4D74  cbz      x0, #0x65d4dbc
0065D4D78  mov      x1, xzr
0065D4D7C  bl       #0x6a16b50 ; HotFix.BattleLogic.BattleWorldContext$$HasNpc
0065D4D80  tbnz     w0, #0, #0x65d4d94
0065D4D84  mov      x0, x19
0065D4D88  mov      w1, wzr
0065D4D8C  bl       #0x65d4824 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckNeedPause
0065D4D90  tbz      w0, #0, #0x65d4da4
0065D4D94  ldp      x20, x19, [sp, #0x20]
0065D4D98  ldp      x22, x21, [sp, #0x10]
0065D4D9C  ldr      x30, [sp], #0x30
0065D4DA0  ret      
0065D4DA4  mov      x0, x19
0065D4DA8  ldp      x20, x19, [sp, #0x20]
0065D4DAC  ldp      x22, x21, [sp, #0x10]
0065D4DB0  mov      x1, xzr
0065D4DB4  ldr      x30, [sp], #0x30
0065D4DB8  b        #0x6589abc ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CheckGoNextMission
0065D4DBC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CreatePunchboardNpc
; RVA 0x65CD7C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CD7C4  stp      x30, x21, [sp, #-0x20]!
0065CD7C8  stp      x20, x19, [sp, #0x10]
0065CD7CC  adrp     x20, #0x9599000
0065CD7D0  adrp     x21, #0x8f0a000
0065CD7D4  ldrb     w8, [x20, #0x59f]
0065CD7D8  ldr      x21, [x21, #0x8a0]
0065CD7DC  mov      x19, x0
0065CD7E0  tbnz     w8, #0, #0x65cd804
0065CD7E4  adrp     x0, #0x8ee8000
0065CD7E8  ldr      x0, [x0, #0x898]
0065CD7EC  bl       #0x382bd14 ; 
0065CD7F0  adrp     x0, #0x8f0a000
0065CD7F4  ldr      x0, [x0, #0x8a0]
0065CD7F8  bl       #0x382bd14 ; 
0065CD7FC  mov      w8, #1
0065CD800  strb     w8, [x20, #0x59f]
0065CD804  ldr      x1, [x21]
0065CD808  ldrb     w8, [x1, #0x53]
0065CD80C  tbnz     w8, #5, #0x65cd858
0065CD810  ldr      w8, [x19, #0x128]
0065CD814  adrp     x20, #0x9599000
0065CD818  add      w8, w8, #1
0065CD81C  str      w8, [x19, #0x128]
0065CD820  ldrb     w8, [x20, #0x286]
0065CD824  cbnz     w8, #0x65cd83c
0065CD828  adrp     x0, #0x8f07000
0065CD82C  ldr      x0, [x0, #0xc98]
0065CD830  bl       #0x382bd14 ; 
0065CD834  mov      w8, #1
0065CD838  strb     w8, [x20, #0x286]
0065CD83C  adrp     x8, #0x8f07000
0065CD840  ldr      x8, [x8, #0xc98]
0065CD844  ldr      x1, [x8]
0065CD848  ldrb     w8, [x1, #0x53]
0065CD84C  tbnz     w8, #5, #0x65cd86c
0065CD850  ldr      x20, [x19, #0x80]
0065CD854  b        #0x65cd87c ; 
0065CD858  ldr      x2, [x1, #0x60]
0065CD85C  mov      x0, x19
0065CD860  ldp      x20, x19, [sp, #0x10]
0065CD864  ldp      x30, x21, [sp], #0x20
0065CD868  br       x2
0065CD86C  ldr      x8, [x1, #0x60]
0065CD870  mov      x0, x19
0065CD874  blr      x8
0065CD878  mov      x20, x0
0065CD87C  adrp     x21, #0x8ee8000
0065CD880  ldr      x21, [x21, #0x898]
0065CD884  ldr      x0, [x21]
0065CD888  ldr      w8, [x0, #0xe0]
0065CD88C  cbnz     w8, #0x65cd894
0065CD890  bl       #0x382be8c ; 
0065CD894  cbz      x20, #0x65cd8e8
0065CD898  ldr      x8, [x21]
0065CD89C  mov      x0, x20
0065CD8A0  mov      w1, wzr
0065CD8A4  mov      x3, xzr
0065CD8A8  ldr      x8, [x8, #0xb8]
0065CD8AC  ldr      w2, [x8, #0x330]
0065CD8B0  bl       #0x54b65d8 ; 
0065CD8B4  mov      x9, #0xf7cf
0065CD8B8  movk     x9, #0xe353, lsl #16
0065CD8BC  movk     x9, #0x9ba5, lsl #32
0065CD8C0  lsl      x8, x0, #0x20
0065CD8C4  movk     x9, #0x20c4, lsl #48
0065CD8C8  mov      x0, x19
0065CD8CC  ldp      x20, x19, [sp, #0x10]
0065CD8D0  smulh    x8, x8, x9
0065CD8D4  asr      x9, x8, #0x17
0065CD8D8  add      x1, x9, x8, lsr #63
0065CD8DC  mov      x2, xzr
0065CD8E0  ldp      x30, x21, [sp], #0x20
0065CD8E4  b        #0x6588be0 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreatePunchboard
0065CD8E8  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$RefreshRandomNpc
; RVA 0x65CD8EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CD8EC  str      x30, [sp, #-0x30]!
0065CD8F0  stp      x22, x21, [sp, #0x10]
0065CD8F4  stp      x20, x19, [sp, #0x20]
0065CD8F8  adrp     x20, #0x9599000
0065CD8FC  adrp     x21, #0x8f0a000
0065CD900  ldrb     w8, [x20, #0x5a0]
0065CD904  ldr      x21, [x21, #0x8a8]
0065CD908  mov      x19, x0
0065CD90C  tbnz     w8, #0, #0x65cd93c
0065CD910  adrp     x0, #0x8ee8000
0065CD914  ldr      x0, [x0, #0x898]
0065CD918  bl       #0x382bd14 ; 
0065CD91C  adrp     x0, #0x8f09000
0065CD920  ldr      x0, [x0, #0xc08]
0065CD924  bl       #0x382bd14 ; 
0065CD928  adrp     x0, #0x8f0a000
0065CD92C  ldr      x0, [x0, #0x8a8]
0065CD930  bl       #0x382bd14 ; 
0065CD934  mov      w8, #1
0065CD938  strb     w8, [x20, #0x5a0]
0065CD93C  ldr      x1, [x21]
0065CD940  ldrb     w8, [x1, #0x53]
0065CD944  tbnz     w8, #5, #0x65cd998
0065CD948  ldr      x20, [x19, #0x188]
0065CD94C  cbz      x20, #0x65cdafc
0065CD950  adrp     x21, #0x8f09000
0065CD954  ldr      x8, [x20]
0065CD958  ldr      x21, [x21, #0xc08]
0065CD95C  ldrh     w9, [x8, #0x12e]
0065CD960  ldr      x1, [x21]
0065CD964  cbz      x9, #0x65cd988
0065CD968  ldr      x10, [x8, #0xb0]
0065CD96C  add      x10, x10, #8
0065CD970  ldur     x11, [x10, #-8]
0065CD974  cmp      x11, x1
0065CD978  b.eq     #0x65cd9b0
0065CD97C  subs     x9, x9, #1
0065CD980  add      x10, x10, #0x10
0065CD984  b.ne     #0x65cd970
0065CD988  mov      w2, #0x24
0065CD98C  mov      x0, x20
0065CD990  bl       #0x3a7e710 ; 
0065CD994  b        #0x65cd9c0 ; 
0065CD998  ldr      x2, [x1, #0x60]
0065CD99C  mov      x0, x19
0065CD9A0  ldp      x20, x19, [sp, #0x20]
0065CD9A4  ldp      x22, x21, [sp, #0x10]
0065CD9A8  ldr      x30, [sp], #0x30
0065CD9AC  br       x2
0065CD9B0  ldr      w9, [x10]
0065CD9B4  add      w9, w9, #0x24
0065CD9B8  add      x8, x8, w9, sxtw #4
0065CD9BC  add      x0, x8, #0x138
0065CD9C0  ldp      x8, x1, [x0]
0065CD9C4  mov      x0, x20
0065CD9C8  blr      x8
0065CD9CC  cmp      w0, #1
0065CD9D0  b.lt     #0x65cdad8
0065CD9D4  ldr      x20, [x19, #0x188]
0065CD9D8  cbz      x20, #0x65cdafc
0065CD9DC  ldr      x8, [x20]
0065CD9E0  ldr      x1, [x21]
0065CD9E4  ldrh     w9, [x8, #0x12e]
0065CD9E8  cbz      x9, #0x65cda0c
0065CD9EC  ldr      x10, [x8, #0xb0]
0065CD9F0  add      x10, x10, #8
0065CD9F4  ldur     x11, [x10, #-8]
0065CD9F8  cmp      x11, x1
0065CD9FC  b.eq     #0x65cda1c
0065CDA00  subs     x9, x9, #1
0065CDA04  add      x10, x10, #0x10
0065CDA08  b.ne     #0x65cd9f4
0065CDA0C  mov      w2, #0x24
0065CDA10  mov      x0, x20
0065CDA14  bl       #0x3a7e710 ; 
0065CDA18  b        #0x65cda2c ; 
0065CDA1C  ldr      w9, [x10]
0065CDA20  add      w9, w9, #0x24
0065CDA24  add      x8, x8, w9, sxtw #4
0065CDA28  add      x0, x8, #0x138
0065CDA2C  ldp      x8, x1, [x0]
0065CDA30  mov      x0, x20
0065CDA34  blr      x8
0065CDA38  cmp      w0, #9
0065CDA3C  b.ne     #0x65cdad8
0065CDA40  adrp     x20, #0x9599000
0065CDA44  ldrb     w8, [x20, #0x286]
0065CDA48  cbnz     w8, #0x65cda60
0065CDA4C  adrp     x0, #0x8f07000
0065CDA50  ldr      x0, [x0, #0xc98]
0065CDA54  bl       #0x382bd14 ; 
0065CDA58  mov      w8, #1
0065CDA5C  strb     w8, [x20, #0x286]
0065CDA60  adrp     x8, #0x8f07000
0065CDA64  ldr      x8, [x8, #0xc98]
0065CDA68  ldr      x1, [x8]
0065CDA6C  ldrb     w8, [x1, #0x53]
0065CDA70  tbnz     w8, #5, #0x65cda7c
0065CDA74  ldr      x0, [x19, #0x80]
0065CDA78  b        #0x65cda88 ; 
0065CDA7C  ldr      x8, [x1, #0x60]
0065CDA80  mov      x0, x19
0065CDA84  blr      x8
0065CDA88  cbz      x0, #0x65cdafc
0065CDA8C  mov      w2, #0x64
0065CDA90  mov      w1, wzr
0065CDA94  mov      x3, xzr
0065CDA98  bl       #0x54b65d8 ; 
0065CDA9C  adrp     x22, #0x8ee8000
0065CDAA0  ldr      x22, [x22, #0x898]
0065CDAA4  ldr      w21, [x19, #0x128]
0065CDAA8  mov      w20, w0
0065CDAAC  ldr      x8, [x22]
0065CDAB0  ldr      w9, [x8, #0xe0]
0065CDAB4  cbnz     w9, #0x65cdac4
0065CDAB8  mov      x0, x8
0065CDABC  bl       #0x382be8c ; 
0065CDAC0  ldr      x8, [x22]
0065CDAC4  ldr      x8, [x8, #0xb8]
0065CDAC8  ldr      w8, [x8, #0x334]
0065CDACC  mul      w8, w8, w21
0065CDAD0  cmp      w20, w8
0065CDAD4  b.le     #0x65cdae8
0065CDAD8  ldp      x20, x19, [sp, #0x20]
0065CDADC  ldp      x22, x21, [sp, #0x10]
0065CDAE0  ldr      x30, [sp], #0x30
0065CDAE4  ret      
0065CDAE8  mov      x0, x19
0065CDAEC  ldp      x20, x19, [sp, #0x20]
0065CDAF0  ldp      x22, x21, [sp, #0x10]
0065CDAF4  ldr      x30, [sp], #0x30
0065CDAF8  b        #0x65cd7c4 ; HotFix.BattleLogic.WaterfallBattleManager$$CreatePunchboardNpc
0065CDAFC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$StartMissileBoost
; RVA 0x65D4DC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D4DC0  str      x30, [sp, #-0x40]!
0065D4DC4  stp      x24, x23, [sp, #0x10]
0065D4DC8  stp      x22, x21, [sp, #0x20]
0065D4DCC  stp      x20, x19, [sp, #0x30]
0065D4DD0  adrp     x23, #0x9599000
0065D4DD4  adrp     x24, #0x8f0a000
0065D4DD8  ldrb     w8, [x23, #0x5a1]
0065D4DDC  ldr      x24, [x24, #0xb10]
0065D4DE0  mov      w19, w3
0065D4DE4  mov      x21, x2
0065D4DE8  mov      w22, w1
0065D4DEC  mov      x20, x0
0065D4DF0  tbnz     w8, #0, #0x65d4e08
0065D4DF4  adrp     x0, #0x8f0a000
0065D4DF8  ldr      x0, [x0, #0xb10]
0065D4DFC  bl       #0x382bd14 ; 
0065D4E00  mov      w8, #1
0065D4E04  strb     w8, [x23, #0x5a1]
0065D4E08  ldr      x4, [x24]
0065D4E0C  ldrb     w8, [x4, #0x53]
0065D4E10  tbnz     w8, #5, #0x65d4e40
0065D4E14  ldr      x8, [x20, #0x1c0]
0065D4E18  str      w22, [x20, #0x1a8]
0065D4E1C  str      x21, [x20, #0x1b0]
0065D4E20  str      w19, [x20, #0x1b8]
0065D4E24  cmp      x8, x21
0065D4E28  b.le     #0x65d4e68
0065D4E2C  ldp      x20, x19, [sp, #0x30]
0065D4E30  ldp      x22, x21, [sp, #0x20]
0065D4E34  ldp      x24, x23, [sp, #0x10]
0065D4E38  ldr      x30, [sp], #0x40
0065D4E3C  ret      
0065D4E40  ldr      x5, [x4, #0x60]
0065D4E44  mov      x0, x20
0065D4E48  mov      w1, w22
0065D4E4C  mov      x2, x21
0065D4E50  mov      w3, w19
0065D4E54  ldp      x20, x19, [sp, #0x30]
0065D4E58  ldp      x22, x21, [sp, #0x20]
0065D4E5C  ldp      x24, x23, [sp, #0x10]
0065D4E60  ldr      x30, [sp], #0x40
0065D4E64  br       x5
0065D4E68  mov      x0, x20
0065D4E6C  ldp      x20, x19, [sp, #0x30]
0065D4E70  ldp      x22, x21, [sp, #0x20]
0065D4E74  ldp      x24, x23, [sp, #0x10]
0065D4E78  ldr      x30, [sp], #0x40
0065D4E7C  b        #0x65ce6f0 ; HotFix.BattleLogic.WaterfallBattleManager$$HeroMissileBoostStart

; HotFix.BattleLogic.WaterfallBattleManager$$EnemyDieSpecialLogic
; RVA 0x65D4E80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D4E80  str      x30, [sp, #-0x50]!
0065D4E84  stp      x26, x25, [sp, #0x10]
0065D4E88  stp      x24, x23, [sp, #0x20]
0065D4E8C  stp      x22, x21, [sp, #0x30]
0065D4E90  stp      x20, x19, [sp, #0x40]
0065D4E94  adrp     x21, #0x9599000
0065D4E98  adrp     x22, #0x8f0a000
0065D4E9C  ldrb     w8, [x21, #0x5a2]
0065D4EA0  ldr      x22, [x22, #0xb18]
0065D4EA4  mov      x20, x1
0065D4EA8  mov      x19, x0
0065D4EAC  tbnz     w8, #0, #0x65d4ed0
0065D4EB0  adrp     x0, #0x8ee6000
0065D4EB4  ldr      x0, [x0, #0xd8]
0065D4EB8  bl       #0x382bd14 ; 
0065D4EBC  adrp     x0, #0x8f0a000
0065D4EC0  ldr      x0, [x0, #0xb18]
0065D4EC4  bl       #0x382bd14 ; 
0065D4EC8  mov      w8, #1
0065D4ECC  strb     w8, [x21, #0x5a2]
0065D4ED0  ldr      x2, [x22]
0065D4ED4  ldrb     w8, [x2, #0x53]
0065D4ED8  tbnz     w8, #5, #0x65d4f08
0065D4EDC  mov      x0, x19
0065D4EE0  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D4EE4  tbz      w0, #0, #0x65d50a4
0065D4EE8  cbz      x20, #0x65d5140
0065D4EEC  adrp     x24, #0x8ee6000
0065D4EF0  ldr      x24, [x24, #0xd8]
0065D4EF4  ldr      x1, [x24]
0065D4EF8  ldrb     w8, [x1, #0x53]
0065D4EFC  tbnz     w8, #5, #0x65d4f2c
0065D4F00  ldr      x21, [x20, #0x38]
0065D4F04  b        #0x65d4f3c ; 
0065D4F08  ldr      x3, [x2, #0x60]
0065D4F0C  mov      x0, x19
0065D4F10  mov      x1, x20
0065D4F14  ldp      x20, x19, [sp, #0x40]
0065D4F18  ldp      x22, x21, [sp, #0x30]
0065D4F1C  ldp      x24, x23, [sp, #0x20]
0065D4F20  ldp      x26, x25, [sp, #0x10]
0065D4F24  ldr      x30, [sp], #0x50
0065D4F28  br       x3
0065D4F2C  ldr      x8, [x1, #0x60]
0065D4F30  mov      x0, x20
0065D4F34  blr      x8
0065D4F38  mov      x21, x0
0065D4F3C  cbz      x21, #0x65d5140
0065D4F40  adrp     x22, #0x9591000
0065D4F44  ldrb     w8, [x22, #0xa74]
0065D4F48  cbnz     w8, #0x65d4f60
0065D4F4C  adrp     x0, #0x8ee6000
0065D4F50  ldr      x0, [x0, #0x288]
0065D4F54  bl       #0x382bd14 ; 
0065D4F58  mov      w8, #1
0065D4F5C  strb     w8, [x22, #0xa74]
0065D4F60  adrp     x25, #0x8ee6000
0065D4F64  ldr      x25, [x25, #0x288]
0065D4F68  ldr      x1, [x25]
0065D4F6C  ldrb     w8, [x1, #0x53]
0065D4F70  tbnz     w8, #5, #0x65d4f7c
0065D4F74  ldr      x21, [x21, #0x170]
0065D4F78  b        #0x65d4f8c ; 
0065D4F7C  ldr      x8, [x1, #0x60]
0065D4F80  mov      x0, x21
0065D4F84  blr      x8
0065D4F88  mov      x21, x0
0065D4F8C  cbz      x21, #0x65d5140
0065D4F90  adrp     x23, #0x9591000
0065D4F94  ldrb     w8, [x23, #0xa75]
0065D4F98  cbnz     w8, #0x65d4fb0
0065D4F9C  adrp     x0, #0x8ee6000
0065D4FA0  ldr      x0, [x0, #0x290]
0065D4FA4  bl       #0x382bd14 ; 
0065D4FA8  mov      w8, #1
0065D4FAC  strb     w8, [x23, #0xa75]
0065D4FB0  adrp     x26, #0x8ee6000
0065D4FB4  ldr      x26, [x26, #0x290]
0065D4FB8  ldr      x1, [x26]
0065D4FBC  ldrb     w8, [x1, #0x53]
0065D4FC0  tbnz     w8, #5, #0x65d4fcc
0065D4FC4  ldr      w0, [x21, #0x24]
0065D4FC8  b        #0x65d4fd8 ; 
0065D4FCC  ldr      x8, [x1, #0x60]
0065D4FD0  mov      x0, x21
0065D4FD4  blr      x8
0065D4FD8  cmp      w0, #0xc9
0065D4FDC  b.eq     #0x65d5090
0065D4FE0  ldr      x1, [x24]
0065D4FE4  ldrb     w8, [x1, #0x53]
0065D4FE8  tbnz     w8, #5, #0x65d4ff4
0065D4FEC  ldr      x20, [x20, #0x38]
0065D4FF0  b        #0x65d5004 ; 
0065D4FF4  ldr      x8, [x1, #0x60]
0065D4FF8  mov      x0, x20
0065D4FFC  blr      x8
0065D5000  mov      x20, x0
0065D5004  cbz      x20, #0x65d5140
0065D5008  ldrb     w8, [x22, #0xa74]
0065D500C  cbnz     w8, #0x65d5024
0065D5010  adrp     x0, #0x8ee6000
0065D5014  ldr      x0, [x0, #0x288]
0065D5018  bl       #0x382bd14 ; 
0065D501C  mov      w8, #1
0065D5020  strb     w8, [x22, #0xa74]
0065D5024  ldr      x1, [x25]
0065D5028  ldrb     w8, [x1, #0x53]
0065D502C  tbnz     w8, #5, #0x65d5038
0065D5030  ldr      x20, [x20, #0x170]
0065D5034  b        #0x65d5048 ; 
0065D5038  ldr      x8, [x1, #0x60]
0065D503C  mov      x0, x20
0065D5040  blr      x8
0065D5044  mov      x20, x0
0065D5048  cbz      x20, #0x65d5140
0065D504C  ldrb     w8, [x23, #0xa75]
0065D5050  cbnz     w8, #0x65d5068
0065D5054  adrp     x0, #0x8ee6000
0065D5058  ldr      x0, [x0, #0x290]
0065D505C  bl       #0x382bd14 ; 
0065D5060  mov      w8, #1
0065D5064  strb     w8, [x23, #0xa75]
0065D5068  ldr      x1, [x26]
0065D506C  ldrb     w8, [x1, #0x53]
0065D5070  tbnz     w8, #5, #0x65d507c
0065D5074  ldr      w0, [x20, #0x24]
0065D5078  b        #0x65d5088 ; 
0065D507C  ldr      x8, [x1, #0x60]
0065D5080  mov      x0, x20
0065D5084  blr      x8
0065D5088  cmp      w0, #3
0065D508C  b.ne     #0x65d50a4
0065D5090  ldr      w8, [x19, #0x148]
0065D5094  sub      w8, w8, #1
0065D5098  cmp      w8, #0
0065D509C  str      w8, [x19, #0x148]
0065D50A0  b.le     #0x65d50bc
0065D50A4  ldp      x20, x19, [sp, #0x40]
0065D50A8  ldp      x22, x21, [sp, #0x30]
0065D50AC  ldp      x24, x23, [sp, #0x20]
0065D50B0  ldp      x26, x25, [sp, #0x10]
0065D50B4  ldr      x30, [sp], #0x50
0065D50B8  ret      
0065D50BC  mov      x0, x19
0065D50C0  mov      x1, xzr
0065D50C4  bl       #0x65875ac ; HotFix.BattleLogic.BaseSurvivalBattleManager$$EnemySpecialDie
0065D50C8  adrp     x20, #0x9599000
0065D50CC  ldrb     w8, [x20, #0x286]
0065D50D0  cbnz     w8, #0x65d50e8
0065D50D4  adrp     x0, #0x8f07000
0065D50D8  ldr      x0, [x0, #0xc98]
0065D50DC  bl       #0x382bd14 ; 
0065D50E0  mov      w8, #1
0065D50E4  strb     w8, [x20, #0x286]
0065D50E8  adrp     x8, #0x8f07000
0065D50EC  ldr      x8, [x8, #0xc98]
0065D50F0  ldr      x1, [x8]
0065D50F4  ldrb     w8, [x1, #0x53]
0065D50F8  tbnz     w8, #5, #0x65d5104
0065D50FC  ldr      x0, [x19, #0x80]
0065D5100  b        #0x65d5110 ; 
0065D5104  ldr      x8, [x1, #0x60]
0065D5108  mov      x0, x19
0065D510C  blr      x8
0065D5110  cbz      x0, #0x65d5140
0065D5114  ldr      w1, [x19, #0x138]
0065D5118  mov      x2, xzr
0065D511C  bl       #0x6a01c08 ; HotFix.BattleLogic.BattleWorldContext$$SetCurMissionId
0065D5120  mov      x0, x19
0065D5124  ldp      x20, x19, [sp, #0x40]
0065D5128  ldp      x22, x21, [sp, #0x30]
0065D512C  ldp      x24, x23, [sp, #0x20]
0065D5130  ldp      x26, x25, [sp, #0x10]
0065D5134  mov      x1, xzr
0065D5138  ldr      x30, [sp], #0x50
0065D513C  b        #0x658783c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$ClearMonsterCreateData
0065D5140  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$GetCharacterDropExp
; RVA 0x65D5144; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D5144  str      x30, [sp, #-0x60]!
0065D5148  stp      x28, x27, [sp, #0x10]
0065D514C  stp      x26, x25, [sp, #0x20]
0065D5150  stp      x24, x23, [sp, #0x30]
0065D5154  stp      x22, x21, [sp, #0x40]
0065D5158  stp      x20, x19, [sp, #0x50]
0065D515C  adrp     x23, #0x9599000
0065D5160  adrp     x24, #0x8f0a000
0065D5164  ldrb     w8, [x23, #0x5a3]
0065D5168  ldr      x24, [x24, #0xb20]
0065D516C  mov      x20, x3
0065D5170  mov      x21, x2
0065D5174  mov      x22, x1
0065D5178  mov      x19, x0
0065D517C  tbnz     w8, #0, #0x65d5194
0065D5180  adrp     x0, #0x8f0a000
0065D5184  ldr      x0, [x0, #0xb20]
0065D5188  bl       #0x382bd14 ; 
0065D518C  mov      w8, #1
0065D5190  strb     w8, [x23, #0x5a3]
0065D5194  ldr      x4, [x24]
0065D5198  ldrb     w8, [x4, #0x53]
0065D519C  tbnz     w8, #5, #0x65d5240
0065D51A0  ldr      x21, [x19, #0x140]
0065D51A4  cbz      x21, #0x65d5638
0065D51A8  adrp     x24, #0x9599000
0065D51AC  ldrb     w8, [x24, #0x658]
0065D51B0  cbnz     w8, #0x65d51c8
0065D51B4  adrp     x0, #0x8f0a000
0065D51B8  ldr      x0, [x0, #0x810]
0065D51BC  bl       #0x382bd14 ; 
0065D51C0  mov      w8, #1
0065D51C4  strb     w8, [x24, #0x658]
0065D51C8  adrp     x25, #0x8f0a000
0065D51CC  ldr      x25, [x25, #0x810]
0065D51D0  ldr      x1, [x25]
0065D51D4  ldrb     w8, [x1, #0x53]
0065D51D8  tbnz     w8, #5, #0x65d5270
0065D51DC  ldr      w0, [x21, #0x28]
0065D51E0  cbz      w0, #0x65d5280
0065D51E4  ldr      x8, [x19]
0065D51E8  mov      x0, x19
0065D51EC  mov      x1, x22
0065D51F0  ldr      x9, [x8, #0x318]
0065D51F4  ldr      x2, [x8, #0x320]
0065D51F8  blr      x9
0065D51FC  cbz      x22, #0x65d5638
0065D5200  adrp     x26, #0x9591000
0065D5204  ldrb     w8, [x26, #0xa74]
0065D5208  mov      w21, w0
0065D520C  cbnz     w8, #0x65d5224
0065D5210  adrp     x0, #0x8ee6000
0065D5214  ldr      x0, [x0, #0x288]
0065D5218  bl       #0x382bd14 ; 
0065D521C  mov      w8, #1
0065D5220  strb     w8, [x26, #0xa74]
0065D5224  adrp     x27, #0x8ee6000
0065D5228  ldr      x27, [x27, #0x288]
0065D522C  ldr      x1, [x27]
0065D5230  ldrb     w8, [x1, #0x53]
0065D5234  tbnz     w8, #5, #0x65d52c0
0065D5238  ldr      x23, [x22, #0x170]
0065D523C  b        #0x65d52d0 ; 
0065D5240  ldr      x5, [x4, #0x60]
0065D5244  mov      x0, x19
0065D5248  mov      x1, x22
0065D524C  mov      x2, x21
0065D5250  mov      x3, x20
0065D5254  ldp      x20, x19, [sp, #0x50]
0065D5258  ldp      x22, x21, [sp, #0x40]
0065D525C  ldp      x24, x23, [sp, #0x30]
0065D5260  ldp      x26, x25, [sp, #0x20]
0065D5264  ldp      x28, x27, [sp, #0x10]
0065D5268  ldr      x30, [sp], #0x60
0065D526C  br       x5
0065D5270  ldr      x8, [x1, #0x60]
0065D5274  mov      x0, x21
0065D5278  blr      x8
0065D527C  cbnz     w0, #0x65d51e4
0065D5280  cbz      x22, #0x65d5638
0065D5284  adrp     x19, #0x9591000
0065D5288  ldrb     w8, [x19, #0xa74]
0065D528C  cbnz     w8, #0x65d52a4
0065D5290  adrp     x0, #0x8ee6000
0065D5294  ldr      x0, [x0, #0x288]
0065D5298  bl       #0x382bd14 ; 
0065D529C  mov      w8, #1
0065D52A0  strb     w8, [x19, #0xa74]
0065D52A4  adrp     x8, #0x8ee6000
0065D52A8  ldr      x8, [x8, #0x288]
0065D52AC  ldr      x1, [x8]
0065D52B0  ldrb     w8, [x1, #0x53]
0065D52B4  tbnz     w8, #5, #0x65d5460
0065D52B8  ldr      x19, [x22, #0x170]
0065D52BC  b        #0x65d5470 ; 
0065D52C0  ldr      x8, [x1, #0x60]
0065D52C4  mov      x0, x22
0065D52C8  blr      x8
0065D52CC  mov      x23, x0
0065D52D0  cbz      x23, #0x65d5638
0065D52D4  adrp     x28, #0x9599000
0065D52D8  ldrb     w8, [x28, #0x65d]
0065D52DC  cbnz     w8, #0x65d52f4
0065D52E0  adrp     x0, #0x8f0a000
0065D52E4  ldr      x0, [x0, #0xa20]
0065D52E8  bl       #0x382bd14 ; 
0065D52EC  mov      w8, #1
0065D52F0  strb     w8, [x28, #0x65d]
0065D52F4  adrp     x8, #0x8f0a000
0065D52F8  ldr      x8, [x8, #0xa20]
0065D52FC  ldr      x1, [x8]
0065D5300  ldrb     w8, [x1, #0x53]
0065D5304  tbnz     w8, #5, #0x65d5310
0065D5308  ldr      w0, [x23, #0x24c]
0065D530C  b        #0x65d531c ; 
0065D5310  ldr      x8, [x1, #0x60]
0065D5314  mov      x0, x23
0065D5318  blr      x8
0065D531C  cmp      w0, #1
0065D5320  b.lt     #0x65d5338
0065D5324  ldr      w8, [x19, #0x14c]
0065D5328  sub      w8, w8, #1
0065D532C  cmp      w8, #0
0065D5330  str      w8, [x19, #0x14c]
0065D5334  b.le     #0x65d53f0
0065D5338  ldrb     w8, [x26, #0xa74]
0065D533C  cbnz     w8, #0x65d5354
0065D5340  adrp     x0, #0x8ee6000
0065D5344  ldr      x0, [x0, #0x288]
0065D5348  bl       #0x382bd14 ; 
0065D534C  mov      w8, #1
0065D5350  strb     w8, [x26, #0xa74]
0065D5354  ldr      x1, [x27]
0065D5358  ldrb     w8, [x1, #0x53]
0065D535C  tbnz     w8, #5, #0x65d5368
0065D5360  ldr      x22, [x22, #0x170]
0065D5364  b        #0x65d5378 ; 
0065D5368  ldr      x8, [x1, #0x60]
0065D536C  mov      x0, x22
0065D5370  blr      x8
0065D5374  mov      x22, x0
0065D5378  cbz      x22, #0x65d5638
0065D537C  adrp     x23, #0x9591000
0065D5380  ldrb     w8, [x23, #0xa75]
0065D5384  cbnz     w8, #0x65d539c
0065D5388  adrp     x0, #0x8ee6000
0065D538C  ldr      x0, [x0, #0x290]
0065D5390  bl       #0x382bd14 ; 
0065D5394  mov      w8, #1
0065D5398  strb     w8, [x23, #0xa75]
0065D539C  adrp     x8, #0x8ee6000
0065D53A0  ldr      x8, [x8, #0x290]
0065D53A4  ldr      x1, [x8]
0065D53A8  ldrb     w8, [x1, #0x53]
0065D53AC  tbnz     w8, #5, #0x65d53b8
0065D53B0  ldr      w22, [x22, #0x24]
0065D53B4  b        #0x65d53c8 ; 
0065D53B8  ldr      x8, [x1, #0x60]
0065D53BC  mov      x0, x22
0065D53C0  blr      x8
0065D53C4  mov      w22, w0
0065D53C8  mov      x0, x19
0065D53CC  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D53D0  tbz      w0, #0, #0x65d5428
0065D53D4  ldr      w23, [x19, #0x148]
0065D53D8  mov      x0, x19
0065D53DC  mov      w1, w22
0065D53E0  bl       #0x65d563c ; HotFix.BattleLogic.WaterfallBattleManager$$CheckIsSpecialMonster
0065D53E4  and      w8, w0, #1
0065D53E8  cmp      w23, w8
0065D53EC  b.ne     #0x65d5428
0065D53F0  ldr      x20, [x19, #0x140]
0065D53F4  cbz      x20, #0x65d5638
0065D53F8  ldrb     w8, [x24, #0x658]
0065D53FC  cbnz     w8, #0x65d5414
0065D5400  adrp     x0, #0x8f0a000
0065D5404  ldr      x0, [x0, #0x810]
0065D5408  bl       #0x382bd14 ; 
0065D540C  mov      w8, #1
0065D5410  strb     w8, [x24, #0x658]
0065D5414  ldr      x1, [x25]
0065D5418  ldrb     w8, [x1, #0x53]
0065D541C  tbnz     w8, #5, #0x65d5534
0065D5420  ldr      w0, [x20, #0x28]
0065D5424  b        #0x65d5540 ; 
0065D5428  ldr      x22, [x19, #0x140]
0065D542C  cbz      x22, #0x65d5638
0065D5430  ldrb     w8, [x24, #0x658]
0065D5434  cbnz     w8, #0x65d544c
0065D5438  adrp     x0, #0x8f0a000
0065D543C  ldr      x0, [x0, #0x810]
0065D5440  bl       #0x382bd14 ; 
0065D5444  mov      w8, #1
0065D5448  strb     w8, [x24, #0x658]
0065D544C  ldr      x1, [x25]
0065D5450  ldrb     w8, [x1, #0x53]
0065D5454  tbnz     w8, #5, #0x65d54cc
0065D5458  ldr      w0, [x22, #0x28]
0065D545C  b        #0x65d54d8 ; 
0065D5460  ldr      x8, [x1, #0x60]
0065D5464  mov      x0, x22
0065D5468  blr      x8
0065D546C  mov      x19, x0
0065D5470  cbz      x19, #0x65d5638
0065D5474  adrp     x21, #0x9599000
0065D5478  ldrb     w8, [x21, #0x2b6]
0065D547C  cbnz     w8, #0x65d5494
0065D5480  adrp     x0, #0x8f08000
0065D5484  ldr      x0, [x0, #0x7f0]
0065D5488  bl       #0x382bd14 ; 
0065D548C  mov      w8, #1
0065D5490  strb     w8, [x21, #0x2b6]
0065D5494  adrp     x8, #0x8f08000
0065D5498  ldr      x8, [x8, #0x7f0]
0065D549C  ldr      x1, [x8]
0065D54A0  ldrb     w8, [x1, #0x53]
0065D54A4  tbnz     w8, #5, #0x65d54b0
0065D54A8  ldr      w0, [x19, #0x248]
0065D54AC  b        #0x65d54bc ; 
0065D54B0  ldr      x8, [x1, #0x60]
0065D54B4  mov      x0, x19
0065D54B8  blr      x8
0065D54BC  add      x8, x20, #0x10, lsl #12
0065D54C0  sxtw     x9, w0
0065D54C4  mul      x20, x8, x9
0065D54C8  b        #0x65d5618 ; 
0065D54CC  ldr      x8, [x1, #0x60]
0065D54D0  mov      x0, x22
0065D54D4  blr      x8
0065D54D8  ldr      x8, [x19, #0x160]
0065D54DC  sxtw     x9, w0
0065D54E0  cmp      x8, x9, lsl #16
0065D54E4  b.ne     #0x65d54f0
0065D54E8  mov      x20, xzr
0065D54EC  b        #0x65d5618 ; 
0065D54F0  ldr      x22, [x19, #0x140]
0065D54F4  cbz      x22, #0x65d5638
0065D54F8  ldrb     w8, [x24, #0x658]
0065D54FC  ldr      x23, [x19, #0x158]
0065D5500  sxtw     x21, w21
0065D5504  cbnz     w8, #0x65d551c
0065D5508  adrp     x0, #0x8f0a000
0065D550C  ldr      x0, [x0, #0x810]
0065D5510  bl       #0x382bd14 ; 
0065D5514  mov      w8, #1
0065D5518  strb     w8, [x24, #0x658]
0065D551C  ldr      x1, [x25]
0065D5520  mul      x21, x23, x21
0065D5524  ldrb     w8, [x1, #0x53]
0065D5528  tbnz     w8, #5, #0x65d559c
0065D552C  ldr      w0, [x22, #0x28]
0065D5530  b        #0x65d55a8 ; 
0065D5534  ldr      x8, [x1, #0x60]
0065D5538  mov      x0, x20
0065D553C  blr      x8
0065D5540  ldr      x21, [x19, #0x140]
0065D5544  cbz      x21, #0x65d5638
0065D5548  ldrb     w8, [x24, #0x658]
0065D554C  ldr      x20, [x19, #0x160]
0065D5550  sbfiz    x22, x0, #0x10, #0x20
0065D5554  cbnz     w8, #0x65d556c
0065D5558  adrp     x0, #0x8f0a000
0065D555C  ldr      x0, [x0, #0x810]
0065D5560  bl       #0x382bd14 ; 
0065D5564  mov      w8, #1
0065D5568  strb     w8, [x24, #0x658]
0065D556C  ldr      x1, [x25]
0065D5570  sub      x20, x22, x20
0065D5574  ldrb     w8, [x1, #0x53]
0065D5578  tbnz     w8, #5, #0x65d5584
0065D557C  ldr      w0, [x21, #0x28]
0065D5580  b        #0x65d5590 ; 
0065D5584  ldr      x8, [x1, #0x60]
0065D5588  mov      x0, x21
0065D558C  blr      x8
0065D5590  sbfiz    x8, x0, #0x10, #0x20
0065D5594  str      x8, [x19, #0x160]
0065D5598  b        #0x65d5618 ; 
0065D559C  ldr      x8, [x1, #0x60]
0065D55A0  mov      x0, x22
0065D55A4  blr      x8
0065D55A8  ldr      x8, [x19, #0x160]
0065D55AC  sxtw     x9, w0
0065D55B0  add      x8, x8, x21
0065D55B4  cmp      x8, x9, lsl #16
0065D55B8  b.le     #0x65d560c
0065D55BC  ldr      x21, [x19, #0x140]
0065D55C0  cbz      x21, #0x65d5638
0065D55C4  ldrb     w8, [x24, #0x658]
0065D55C8  cbnz     w8, #0x65d55e0
0065D55CC  adrp     x0, #0x8f0a000
0065D55D0  ldr      x0, [x0, #0x810]
0065D55D4  bl       #0x382bd14 ; 
0065D55D8  mov      w8, #1
0065D55DC  strb     w8, [x24, #0x658]
0065D55E0  ldr      x1, [x25]
0065D55E4  ldrb     w8, [x1, #0x53]
0065D55E8  tbnz     w8, #5, #0x65d55f4
0065D55EC  ldr      w0, [x21, #0x28]
0065D55F0  b        #0x65d5600 ; 
0065D55F4  ldr      x8, [x1, #0x60]
0065D55F8  mov      x0, x21
0065D55FC  blr      x8
0065D5600  ldr      x9, [x19, #0x160]
0065D5604  sbfiz    x8, x0, #0x10, #0x20
0065D5608  sub      x21, x8, x9
0065D560C  str      x8, [x19, #0x160]
0065D5610  mul      x8, x21, x20
0065D5614  asr      x20, x8, #0x10
0065D5618  mov      x0, x20
0065D561C  ldp      x20, x19, [sp, #0x50]
0065D5620  ldp      x22, x21, [sp, #0x40]
0065D5624  ldp      x24, x23, [sp, #0x30]
0065D5628  ldp      x26, x25, [sp, #0x20]
0065D562C  ldp      x28, x27, [sp, #0x10]
0065D5630  ldr      x30, [sp], #0x60
0065D5634  ret      
0065D5638  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$GetCharacterDropCoinCount
; RVA 0x65D56C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D56C4  str      x30, [sp, #-0x30]!
0065D56C8  stp      x22, x21, [sp, #0x10]
0065D56CC  stp      x20, x19, [sp, #0x20]
0065D56D0  adrp     x21, #0x9599000
0065D56D4  adrp     x22, #0x8f0a000
0065D56D8  ldrb     w8, [x21, #0x5a4]
0065D56DC  ldr      x22, [x22, #0xb30]
0065D56E0  mov      x19, x1
0065D56E4  mov      x20, x0
0065D56E8  tbnz     w8, #0, #0x65d5700
0065D56EC  adrp     x0, #0x8f0a000
0065D56F0  ldr      x0, [x0, #0xb30]
0065D56F4  bl       #0x382bd14 ; 
0065D56F8  mov      w8, #1
0065D56FC  strb     w8, [x21, #0x5a4]
0065D5700  ldr      x2, [x22]
0065D5704  ldrb     w8, [x2, #0x53]
0065D5708  tbnz     w8, #5, #0x65d574c
0065D570C  cbz      x19, #0x65d57dc
0065D5710  adrp     x20, #0x9591000
0065D5714  ldrb     w8, [x20, #0xa74]
0065D5718  cbnz     w8, #0x65d5730
0065D571C  adrp     x0, #0x8ee6000
0065D5720  ldr      x0, [x0, #0x288]
0065D5724  bl       #0x382bd14 ; 
0065D5728  mov      w8, #1
0065D572C  strb     w8, [x20, #0xa74]
0065D5730  adrp     x8, #0x8ee6000
0065D5734  ldr      x8, [x8, #0x288]
0065D5738  ldr      x1, [x8]
0065D573C  ldrb     w8, [x1, #0x53]
0065D5740  tbnz     w8, #5, #0x65d5768
0065D5744  ldr      x19, [x19, #0x170]
0065D5748  b        #0x65d5778 ; 
0065D574C  ldr      x3, [x2, #0x60]
0065D5750  mov      x0, x20
0065D5754  mov      x1, x19
0065D5758  ldp      x20, x19, [sp, #0x20]
0065D575C  ldp      x22, x21, [sp, #0x10]
0065D5760  ldr      x30, [sp], #0x30
0065D5764  br       x3
0065D5768  ldr      x8, [x1, #0x60]
0065D576C  mov      x0, x19
0065D5770  blr      x8
0065D5774  mov      x19, x0
0065D5778  cbz      x19, #0x65d57dc
0065D577C  adrp     x20, #0x9599000
0065D5780  ldrb     w8, [x20, #0x2b5]
0065D5784  cbnz     w8, #0x65d579c
0065D5788  adrp     x0, #0x8f08000
0065D578C  ldr      x0, [x0, #0x7e0]
0065D5790  bl       #0x382bd14 ; 
0065D5794  mov      w8, #1
0065D5798  strb     w8, [x20, #0x2b5]
0065D579C  adrp     x8, #0x8f08000
0065D57A0  ldr      x8, [x8, #0x7e0]
0065D57A4  ldr      x1, [x8]
0065D57A8  ldrb     w8, [x1, #0x53]
0065D57AC  tbnz     w8, #5, #0x65d57c4
0065D57B0  ldr      w0, [x19, #0x244]
0065D57B4  ldp      x20, x19, [sp, #0x20]
0065D57B8  ldp      x22, x21, [sp, #0x10]
0065D57BC  ldr      x30, [sp], #0x30
0065D57C0  ret      
0065D57C4  ldr      x2, [x1, #0x60]
0065D57C8  mov      x0, x19
0065D57CC  ldp      x20, x19, [sp, #0x20]
0065D57D0  ldp      x22, x21, [sp, #0x10]
0065D57D4  ldr      x30, [sp], #0x30
0065D57D8  br       x2
0065D57DC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$GetCharacterDropExpCount
; RVA 0x65D57E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D57E0  str      x30, [sp, #-0x30]!
0065D57E4  stp      x22, x21, [sp, #0x10]
0065D57E8  stp      x20, x19, [sp, #0x20]
0065D57EC  adrp     x21, #0x9599000
0065D57F0  adrp     x22, #0x8f0a000
0065D57F4  ldrb     w8, [x21, #0x5a5]
0065D57F8  ldr      x22, [x22, #0xb38]
0065D57FC  mov      x19, x1
0065D5800  mov      x20, x0
0065D5804  tbnz     w8, #0, #0x65d581c
0065D5808  adrp     x0, #0x8f0a000
0065D580C  ldr      x0, [x0, #0xb38]
0065D5810  bl       #0x382bd14 ; 
0065D5814  mov      w8, #1
0065D5818  strb     w8, [x21, #0x5a5]
0065D581C  ldr      x2, [x22]
0065D5820  ldrb     w8, [x2, #0x53]
0065D5824  tbnz     w8, #5, #0x65d586c
0065D5828  ldr      x20, [x20, #0x140]
0065D582C  cbz      x20, #0x65d598c
0065D5830  adrp     x21, #0x9599000
0065D5834  ldrb     w8, [x21, #0x658]
0065D5838  cbnz     w8, #0x65d5850
0065D583C  adrp     x0, #0x8f0a000
0065D5840  ldr      x0, [x0, #0x810]
0065D5844  bl       #0x382bd14 ; 
0065D5848  mov      w8, #1
0065D584C  strb     w8, [x21, #0x658]
0065D5850  adrp     x8, #0x8f0a000
0065D5854  ldr      x8, [x8, #0x810]
0065D5858  ldr      x1, [x8]
0065D585C  ldrb     w8, [x1, #0x53]
0065D5860  tbnz     w8, #5, #0x65d5888
0065D5864  ldr      w20, [x20, #0x28]
0065D5868  b        #0x65d5898 ; 
0065D586C  ldr      x3, [x2, #0x60]
0065D5870  mov      x0, x20
0065D5874  mov      x1, x19
0065D5878  ldp      x20, x19, [sp, #0x20]
0065D587C  ldp      x22, x21, [sp, #0x10]
0065D5880  ldr      x30, [sp], #0x30
0065D5884  br       x3
0065D5888  ldr      x8, [x1, #0x60]
0065D588C  mov      x0, x20
0065D5890  blr      x8
0065D5894  mov      w20, w0
0065D5898  cbz      x19, #0x65d598c
0065D589C  adrp     x21, #0x9591000
0065D58A0  ldrb     w8, [x21, #0xa74]
0065D58A4  cbnz     w8, #0x65d58bc
0065D58A8  adrp     x0, #0x8ee6000
0065D58AC  ldr      x0, [x0, #0x288]
0065D58B0  bl       #0x382bd14 ; 
0065D58B4  mov      w8, #1
0065D58B8  strb     w8, [x21, #0xa74]
0065D58BC  adrp     x8, #0x8ee6000
0065D58C0  ldr      x8, [x8, #0x288]
0065D58C4  ldr      x1, [x8]
0065D58C8  ldrb     w8, [x1, #0x53]
0065D58CC  tbnz     w8, #5, #0x65d58d8
0065D58D0  ldr      x19, [x19, #0x170]
0065D58D4  b        #0x65d58e8 ; 
0065D58D8  ldr      x8, [x1, #0x60]
0065D58DC  mov      x0, x19
0065D58E0  blr      x8
0065D58E4  mov      x19, x0
0065D58E8  cbz      x19, #0x65d598c
0065D58EC  cbz      w20, #0x65d592c
0065D58F0  adrp     x20, #0x9599000
0065D58F4  ldrb     w8, [x20, #0x65d]
0065D58F8  cbnz     w8, #0x65d5910
0065D58FC  adrp     x0, #0x8f0a000
0065D5900  ldr      x0, [x0, #0xa20]
0065D5904  bl       #0x382bd14 ; 
0065D5908  mov      w8, #1
0065D590C  strb     w8, [x20, #0x65d]
0065D5910  adrp     x8, #0x8f0a000
0065D5914  ldr      x8, [x8, #0xa20]
0065D5918  ldr      x1, [x8]
0065D591C  ldrb     w8, [x1, #0x53]
0065D5920  tbnz     w8, #5, #0x65d5974
0065D5924  ldr      w0, [x19, #0x24c]
0065D5928  b        #0x65d5964 ; 
0065D592C  adrp     x20, #0x9599000
0065D5930  ldrb     w8, [x20, #0x2b6]
0065D5934  cbnz     w8, #0x65d594c
0065D5938  adrp     x0, #0x8f08000
0065D593C  ldr      x0, [x0, #0x7f0]
0065D5940  bl       #0x382bd14 ; 
0065D5944  mov      w8, #1
0065D5948  strb     w8, [x20, #0x2b6]
0065D594C  adrp     x8, #0x8f08000
0065D5950  ldr      x8, [x8, #0x7f0]
0065D5954  ldr      x1, [x8]
0065D5958  ldrb     w8, [x1, #0x53]
0065D595C  tbnz     w8, #5, #0x65d5974
0065D5960  ldr      w0, [x19, #0x248]
0065D5964  ldp      x20, x19, [sp, #0x20]
0065D5968  ldp      x22, x21, [sp, #0x10]
0065D596C  ldr      x30, [sp], #0x30
0065D5970  ret      
0065D5974  ldr      x2, [x1, #0x60]
0065D5978  mov      x0, x19
0065D597C  ldp      x20, x19, [sp, #0x20]
0065D5980  ldp      x22, x21, [sp, #0x10]
0065D5984  ldr      x30, [sp], #0x30
0065D5988  br       x2
0065D598C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckIsSpecialMonster
; RVA 0x65D563C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D563C  str      x30, [sp, #-0x30]!
0065D5640  stp      x22, x21, [sp, #0x10]
0065D5644  stp      x20, x19, [sp, #0x20]
0065D5648  adrp     x21, #0x9599000
0065D564C  adrp     x22, #0x8f0a000
0065D5650  ldrb     w8, [x21, #0x5a6]
0065D5654  ldr      x22, [x22, #0xb28]
0065D5658  mov      w19, w1
0065D565C  mov      x20, x0
0065D5660  tbnz     w8, #0, #0x65d5678
0065D5664  adrp     x0, #0x8f0a000
0065D5668  ldr      x0, [x0, #0xb28]
0065D566C  bl       #0x382bd14 ; 
0065D5670  mov      w8, #1
0065D5674  strb     w8, [x21, #0x5a6]
0065D5678  ldr      x2, [x22]
0065D567C  ldrb     w8, [x2, #0x53]
0065D5680  tbnz     w8, #5, #0x65d56a8
0065D5684  cmp      w19, #0xc9
0065D5688  cset     w8, eq
0065D568C  cmp      w19, #3
0065D5690  ldp      x20, x19, [sp, #0x20]
0065D5694  ldp      x22, x21, [sp, #0x10]
0065D5698  cset     w9, eq
0065D569C  orr      w0, w8, w9
0065D56A0  ldr      x30, [sp], #0x30
0065D56A4  ret      
0065D56A8  ldr      x3, [x2, #0x60]
0065D56AC  mov      x0, x20
0065D56B0  mov      w1, w19
0065D56B4  ldp      x20, x19, [sp, #0x20]
0065D56B8  ldp      x22, x21, [sp, #0x10]
0065D56BC  ldr      x30, [sp], #0x30
0065D56C0  br       x3

; HotFix.BattleLogic.WaterfallBattleManager$$IsWaveLastMission
; RVA 0x65D5990; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D5990  stp      x30, x21, [sp, #-0x20]!
0065D5994  stp      x20, x19, [sp, #0x10]
0065D5998  adrp     x20, #0x9599000
0065D599C  adrp     x21, #0x8f0a000
0065D59A0  ldrb     w8, [x20, #0x5a7]
0065D59A4  ldr      x21, [x21, #0xb40]
0065D59A8  mov      x19, x0
0065D59AC  tbnz     w8, #0, #0x65d59c4
0065D59B0  adrp     x0, #0x8f0a000
0065D59B4  ldr      x0, [x0, #0xb40]
0065D59B8  bl       #0x382bd14 ; 
0065D59BC  mov      w8, #1
0065D59C0  strb     w8, [x20, #0x5a7]
0065D59C4  ldr      x1, [x21]
0065D59C8  ldrb     w8, [x1, #0x53]
0065D59CC  tbnz     w8, #5, #0x65d5a0c
0065D59D0  adrp     x20, #0x9599000
0065D59D4  ldrb     w8, [x20, #0x286]
0065D59D8  cbnz     w8, #0x65d59f0
0065D59DC  adrp     x0, #0x8f07000
0065D59E0  ldr      x0, [x0, #0xc98]
0065D59E4  bl       #0x382bd14 ; 
0065D59E8  mov      w8, #1
0065D59EC  strb     w8, [x20, #0x286]
0065D59F0  adrp     x8, #0x8f07000
0065D59F4  ldr      x8, [x8, #0xc98]
0065D59F8  ldr      x1, [x8]
0065D59FC  ldrb     w8, [x1, #0x53]
0065D5A00  tbnz     w8, #5, #0x65d5a20
0065D5A04  ldr      x20, [x19, #0x80]
0065D5A08  b        #0x65d5a30 ; 
0065D5A0C  ldr      x2, [x1, #0x60]
0065D5A10  mov      x0, x19
0065D5A14  ldp      x20, x19, [sp, #0x10]
0065D5A18  ldp      x30, x21, [sp], #0x20
0065D5A1C  br       x2
0065D5A20  ldr      x8, [x1, #0x60]
0065D5A24  mov      x0, x19
0065D5A28  blr      x8
0065D5A2C  mov      x20, x0
0065D5A30  cbz      x20, #0x65d5a9c
0065D5A34  adrp     x21, #0x9599000
0065D5A38  ldrb     w8, [x21, #0x2c3]
0065D5A3C  cbnz     w8, #0x65d5a54
0065D5A40  adrp     x0, #0x8f08000
0065D5A44  ldr      x0, [x0, #0x280]
0065D5A48  bl       #0x382bd14 ; 
0065D5A4C  mov      w8, #1
0065D5A50  strb     w8, [x21, #0x2c3]
0065D5A54  adrp     x8, #0x8f08000
0065D5A58  ldr      x8, [x8, #0x280]
0065D5A5C  ldr      x1, [x8]
0065D5A60  ldrb     w8, [x1, #0x53]
0065D5A64  tbnz     w8, #5, #0x65d5a78
0065D5A68  add      x0, x20, #0x290
0065D5A6C  mov      x1, xzr
0065D5A70  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065D5A74  b        #0x65d5a84 ; 
0065D5A78  ldr      x8, [x1, #0x60]
0065D5A7C  mov      x0, x20
0065D5A80  blr      x8
0065D5A84  ldr      w8, [x19, #0x138]
0065D5A88  ldp      x20, x19, [sp, #0x10]
0065D5A8C  cmp      w0, w8
0065D5A90  cset     w0, eq
0065D5A94  ldp      x30, x21, [sp], #0x20
0065D5A98  ret      
0065D5A9C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$IsWaveShowStartUIMission
; RVA 0x65D5AA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D5AA0  stp      x30, x21, [sp, #-0x20]!
0065D5AA4  stp      x20, x19, [sp, #0x10]
0065D5AA8  adrp     x20, #0x9599000
0065D5AAC  adrp     x21, #0x8f0a000
0065D5AB0  ldrb     w8, [x20, #0x5a8]
0065D5AB4  ldr      x21, [x21, #0xb48]
0065D5AB8  mov      x19, x0
0065D5ABC  tbnz     w8, #0, #0x65d5ad4
0065D5AC0  adrp     x0, #0x8f0a000
0065D5AC4  ldr      x0, [x0, #0xb48]
0065D5AC8  bl       #0x382bd14 ; 
0065D5ACC  mov      w8, #1
0065D5AD0  strb     w8, [x20, #0x5a8]
0065D5AD4  ldr      x1, [x21]
0065D5AD8  ldrb     w8, [x1, #0x53]
0065D5ADC  tbnz     w8, #5, #0x65d5b1c
0065D5AE0  adrp     x20, #0x9599000
0065D5AE4  ldrb     w8, [x20, #0x286]
0065D5AE8  cbnz     w8, #0x65d5b00
0065D5AEC  adrp     x0, #0x8f07000
0065D5AF0  ldr      x0, [x0, #0xc98]
0065D5AF4  bl       #0x382bd14 ; 
0065D5AF8  mov      w8, #1
0065D5AFC  strb     w8, [x20, #0x286]
0065D5B00  adrp     x8, #0x8f07000
0065D5B04  ldr      x8, [x8, #0xc98]
0065D5B08  ldr      x1, [x8]
0065D5B0C  ldrb     w8, [x1, #0x53]
0065D5B10  tbnz     w8, #5, #0x65d5b30
0065D5B14  ldr      x20, [x19, #0x80]
0065D5B18  b        #0x65d5b40 ; 
0065D5B1C  ldr      x2, [x1, #0x60]
0065D5B20  mov      x0, x19
0065D5B24  ldp      x20, x19, [sp, #0x10]
0065D5B28  ldp      x30, x21, [sp], #0x20
0065D5B2C  br       x2
0065D5B30  ldr      x8, [x1, #0x60]
0065D5B34  mov      x0, x19
0065D5B38  blr      x8
0065D5B3C  mov      x20, x0
0065D5B40  cbz      x20, #0x65d5bac
0065D5B44  adrp     x21, #0x9599000
0065D5B48  ldrb     w8, [x21, #0x2c3]
0065D5B4C  cbnz     w8, #0x65d5b64
0065D5B50  adrp     x0, #0x8f08000
0065D5B54  ldr      x0, [x0, #0x280]
0065D5B58  bl       #0x382bd14 ; 
0065D5B5C  mov      w8, #1
0065D5B60  strb     w8, [x21, #0x2c3]
0065D5B64  adrp     x8, #0x8f08000
0065D5B68  ldr      x8, [x8, #0x280]
0065D5B6C  ldr      x1, [x8]
0065D5B70  ldrb     w8, [x1, #0x53]
0065D5B74  tbnz     w8, #5, #0x65d5b88
0065D5B78  add      x0, x20, #0x290
0065D5B7C  mov      x1, xzr
0065D5B80  bl       #0x658e674 ; HotFix.BattleLogic.BattleData$$get_CurMissionId
0065D5B84  b        #0x65d5b94 ; 
0065D5B88  ldr      x8, [x1, #0x60]
0065D5B8C  mov      x0, x20
0065D5B90  blr      x8
0065D5B94  ldr      w8, [x19, #0x13c]
0065D5B98  ldp      x20, x19, [sp, #0x10]
0065D5B9C  cmp      w0, w8
0065D5BA0  cset     w0, eq
0065D5BA4  ldp      x30, x21, [sp], #0x20
0065D5BA8  ret      
0065D5BAC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$InitSpecialUIArr
; RVA 0x65D5BB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D5BB0  str      x30, [sp, #-0x30]!
0065D5BB4  stp      x22, x21, [sp, #0x10]
0065D5BB8  stp      x20, x19, [sp, #0x20]
0065D5BBC  adrp     x19, #0x9599000
0065D5BC0  adrp     x22, #0x8f0a000
0065D5BC4  ldrb     w8, [x19, #0x5a9]
0065D5BC8  ldr      x22, [x22, #0xb50]
0065D5BCC  mov      w21, w1
0065D5BD0  mov      x20, x0
0065D5BD4  tbnz     w8, #0, #0x65d5bec
0065D5BD8  adrp     x0, #0x8f0a000
0065D5BDC  ldr      x0, [x0, #0xb50]
0065D5BE0  bl       #0x382bd14 ; 
0065D5BE4  mov      w8, #1
0065D5BE8  strb     w8, [x19, #0x5a9]
0065D5BEC  ldr      x2, [x22]
0065D5BF0  ldrb     w8, [x2, #0x53]
0065D5BF4  tbnz     w8, #5, #0x65d5c5c
0065D5BF8  add      x19, x20, #0x1e8
0065D5BFC  mov      x0, x19
0065D5C00  mov      x1, xzr
0065D5C04  str      wzr, [x20, #0x198]
0065D5C08  str      wzr, [x20, #0x1d0]
0065D5C0C  str      xzr, [x20, #0x1e8]
0065D5C10  bl       #0x382bcb8 ; 
0065D5C14  ldr      x20, [x20, #0x140]
0065D5C18  cbz      x20, #0x65d5cdc
0065D5C1C  tbz      w21, #0, #0x65d5c78
0065D5C20  adrp     x21, #0x9598000
0065D5C24  ldrb     w8, [x21, #0x35f]
0065D5C28  cbnz     w8, #0x65d5c40
0065D5C2C  adrp     x0, #0x8ef9000
0065D5C30  ldr      x0, [x0, #0xf48]
0065D5C34  bl       #0x382bd14 ; 
0065D5C38  mov      w8, #1
0065D5C3C  strb     w8, [x21, #0x35f]
0065D5C40  adrp     x8, #0x8ef9000
0065D5C44  ldr      x8, [x8, #0xf48]
0065D5C48  ldr      x1, [x8]
0065D5C4C  ldrb     w8, [x1, #0x53]
0065D5C50  tbnz     w8, #5, #0x65d5cb4
0065D5C54  ldr      x1, [x20, #0x30]
0065D5C58  b        #0x65d5cc4 ; 
0065D5C5C  ldr      x3, [x2, #0x60]
0065D5C60  and      w1, w21, #1
0065D5C64  mov      x0, x20
0065D5C68  ldp      x20, x19, [sp, #0x20]
0065D5C6C  ldp      x22, x21, [sp, #0x10]
0065D5C70  ldr      x30, [sp], #0x30
0065D5C74  br       x3
0065D5C78  adrp     x21, #0x9599000
0065D5C7C  ldrb     w8, [x21, #0x662]
0065D5C80  cbnz     w8, #0x65d5c98
0065D5C84  adrp     x0, #0x8f0a000
0065D5C88  ldr      x0, [x0, #0xb58]
0065D5C8C  bl       #0x382bd14 ; 
0065D5C90  mov      w8, #1
0065D5C94  strb     w8, [x21, #0x662]
0065D5C98  adrp     x8, #0x8f0a000
0065D5C9C  ldr      x8, [x8, #0xb58]
0065D5CA0  ldr      x1, [x8]
0065D5CA4  ldrb     w8, [x1, #0x53]
0065D5CA8  tbnz     w8, #5, #0x65d5cb4
0065D5CAC  ldr      x1, [x20, #0x38]
0065D5CB0  b        #0x65d5cc4 ; 
0065D5CB4  ldr      x8, [x1, #0x60]
0065D5CB8  mov      x0, x20
0065D5CBC  blr      x8
0065D5CC0  mov      x1, x0
0065D5CC4  str      x1, [x19]
0065D5CC8  mov      x0, x19
0065D5CCC  ldp      x20, x19, [sp, #0x20]
0065D5CD0  ldp      x22, x21, [sp, #0x10]
0065D5CD4  ldr      x30, [sp], #0x30
0065D5CD8  b        #0x382bcb8 ; 
0065D5CDC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckWaveShowStartUI
; RVA 0x65D5CE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D5CE0  stp      x30, x21, [sp, #-0x20]!
0065D5CE4  stp      x20, x19, [sp, #0x10]
0065D5CE8  adrp     x20, #0x9599000
0065D5CEC  adrp     x21, #0x8f0a000
0065D5CF0  ldrb     w8, [x20, #0x5aa]
0065D5CF4  ldr      x21, [x21, #0xb60]
0065D5CF8  mov      x19, x0
0065D5CFC  tbnz     w8, #0, #0x65d5d20
0065D5D00  adrp     x0, #0x8f09000
0065D5D04  ldr      x0, [x0, #0xc08]
0065D5D08  bl       #0x382bd14 ; 
0065D5D0C  adrp     x0, #0x8f0a000
0065D5D10  ldr      x0, [x0, #0xb60]
0065D5D14  bl       #0x382bd14 ; 
0065D5D18  mov      w8, #1
0065D5D1C  strb     w8, [x20, #0x5aa]
0065D5D20  ldr      x1, [x21]
0065D5D24  ldrb     w8, [x1, #0x53]
0065D5D28  tbnz     w8, #5, #0x65d5d80
0065D5D2C  ldr      x20, [x19, #0x188]
0065D5D30  cbz      x20, #0x65d5e34
0065D5D34  adrp     x10, #0x8f09000
0065D5D38  ldr      x8, [x20]
0065D5D3C  ldr      w21, [x19, #0x13c]
0065D5D40  ldr      x10, [x10, #0xc08]
0065D5D44  ldrh     w9, [x8, #0x12e]
0065D5D48  ldr      x1, [x10]
0065D5D4C  cbz      x9, #0x65d5d70
0065D5D50  ldr      x10, [x8, #0xb0]
0065D5D54  add      x10, x10, #8
0065D5D58  ldur     x11, [x10, #-8]
0065D5D5C  cmp      x11, x1
0065D5D60  b.eq     #0x65d5d94
0065D5D64  subs     x9, x9, #1
0065D5D68  add      x10, x10, #0x10
0065D5D6C  b.ne     #0x65d5d58
0065D5D70  mov      x0, x20
0065D5D74  mov      w2, wzr
0065D5D78  bl       #0x3a7e710 ; 
0065D5D7C  b        #0x65d5da0 ; 
0065D5D80  ldr      x2, [x1, #0x60]
0065D5D84  mov      x0, x19
0065D5D88  ldp      x20, x19, [sp, #0x10]
0065D5D8C  ldp      x30, x21, [sp], #0x20
0065D5D90  br       x2
0065D5D94  ldrsw    x9, [x10]
0065D5D98  add      x8, x8, x9, lsl #4
0065D5D9C  add      x0, x8, #0x138
0065D5DA0  ldp      x8, x1, [x0]
0065D5DA4  mov      x0, x20
0065D5DA8  blr      x8
0065D5DAC  cmp      w21, w0
0065D5DB0  b.ne     #0x65d5e04
0065D5DB4  mov      w1, #1
0065D5DB8  mov      x0, x19
0065D5DBC  bl       #0x65d5bb0 ; HotFix.BattleLogic.WaterfallBattleManager$$InitSpecialUIArr
0065D5DC0  ldr      x19, [x19, #0x140]
0065D5DC4  cbz      x19, #0x65d5e34
0065D5DC8  adrp     x20, #0x9598000
0065D5DCC  ldrb     w8, [x20, #0x35f]
0065D5DD0  cbnz     w8, #0x65d5de8
0065D5DD4  adrp     x0, #0x8ef9000
0065D5DD8  ldr      x0, [x0, #0xf48]
0065D5DDC  bl       #0x382bd14 ; 
0065D5DE0  mov      w8, #1
0065D5DE4  strb     w8, [x20, #0x35f]
0065D5DE8  adrp     x8, #0x8ef9000
0065D5DEC  ldr      x8, [x8, #0xf48]
0065D5DF0  ldr      x1, [x8]
0065D5DF4  ldrb     w8, [x1, #0x53]
0065D5DF8  tbnz     w8, #5, #0x65d5e0c
0065D5DFC  ldr      x0, [x19, #0x30]
0065D5E00  b        #0x65d5e18 ; 
0065D5E04  mov      w0, wzr
0065D5E08  b        #0x65d5e28 ; 
0065D5E0C  ldr      x8, [x1, #0x60]
0065D5E10  mov      x0, x19
0065D5E14  blr      x8
0065D5E18  cbz      x0, #0x65d5e34
0065D5E1C  ldr      w8, [x0, #0x18]
0065D5E20  cmp      w8, #0
0065D5E24  cset     w0, ne
0065D5E28  ldp      x20, x19, [sp, #0x10]
0065D5E2C  ldp      x30, x21, [sp], #0x20
0065D5E30  ret      
0065D5E34  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckWaveShowEndUI
; RVA 0x65D5E38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D5E38  stp      x30, x21, [sp, #-0x20]!
0065D5E3C  stp      x20, x19, [sp, #0x10]
0065D5E40  adrp     x20, #0x9599000
0065D5E44  adrp     x21, #0x8f0a000
0065D5E48  ldrb     w8, [x20, #0x5ab]
0065D5E4C  ldr      x21, [x21, #0xb68]
0065D5E50  mov      x19, x0
0065D5E54  tbnz     w8, #0, #0x65d5e78
0065D5E58  adrp     x0, #0x8f09000
0065D5E5C  ldr      x0, [x0, #0xc08]
0065D5E60  bl       #0x382bd14 ; 
0065D5E64  adrp     x0, #0x8f0a000
0065D5E68  ldr      x0, [x0, #0xb68]
0065D5E6C  bl       #0x382bd14 ; 
0065D5E70  mov      w8, #1
0065D5E74  strb     w8, [x20, #0x5ab]
0065D5E78  ldr      x1, [x21]
0065D5E7C  ldrb     w8, [x1, #0x53]
0065D5E80  tbnz     w8, #5, #0x65d5ed8
0065D5E84  ldr      x20, [x19, #0x188]
0065D5E88  cbz      x20, #0x65d5f8c
0065D5E8C  adrp     x10, #0x8f09000
0065D5E90  ldr      x8, [x20]
0065D5E94  ldr      w21, [x19, #0x138]
0065D5E98  ldr      x10, [x10, #0xc08]
0065D5E9C  ldrh     w9, [x8, #0x12e]
0065D5EA0  ldr      x1, [x10]
0065D5EA4  cbz      x9, #0x65d5ec8
0065D5EA8  ldr      x10, [x8, #0xb0]
0065D5EAC  add      x10, x10, #8
0065D5EB0  ldur     x11, [x10, #-8]
0065D5EB4  cmp      x11, x1
0065D5EB8  b.eq     #0x65d5eec
0065D5EBC  subs     x9, x9, #1
0065D5EC0  add      x10, x10, #0x10
0065D5EC4  b.ne     #0x65d5eb0
0065D5EC8  mov      x0, x20
0065D5ECC  mov      w2, wzr
0065D5ED0  bl       #0x3a7e710 ; 
0065D5ED4  b        #0x65d5ef8 ; 
0065D5ED8  ldr      x2, [x1, #0x60]
0065D5EDC  mov      x0, x19
0065D5EE0  ldp      x20, x19, [sp, #0x10]
0065D5EE4  ldp      x30, x21, [sp], #0x20
0065D5EE8  br       x2
0065D5EEC  ldrsw    x9, [x10]
0065D5EF0  add      x8, x8, x9, lsl #4
0065D5EF4  add      x0, x8, #0x138
0065D5EF8  ldp      x8, x1, [x0]
0065D5EFC  mov      x0, x20
0065D5F00  blr      x8
0065D5F04  cmp      w21, w0
0065D5F08  b.ne     #0x65d5f5c
0065D5F0C  mov      x0, x19
0065D5F10  mov      w1, wzr
0065D5F14  bl       #0x65d5bb0 ; HotFix.BattleLogic.WaterfallBattleManager$$InitSpecialUIArr
0065D5F18  ldr      x19, [x19, #0x140]
0065D5F1C  cbz      x19, #0x65d5f8c
0065D5F20  adrp     x20, #0x9599000
0065D5F24  ldrb     w8, [x20, #0x662]
0065D5F28  cbnz     w8, #0x65d5f40
0065D5F2C  adrp     x0, #0x8f0a000
0065D5F30  ldr      x0, [x0, #0xb58]
0065D5F34  bl       #0x382bd14 ; 
0065D5F38  mov      w8, #1
0065D5F3C  strb     w8, [x20, #0x662]
0065D5F40  adrp     x8, #0x8f0a000
0065D5F44  ldr      x8, [x8, #0xb58]
0065D5F48  ldr      x1, [x8]
0065D5F4C  ldrb     w8, [x1, #0x53]
0065D5F50  tbnz     w8, #5, #0x65d5f64
0065D5F54  ldr      x0, [x19, #0x38]
0065D5F58  b        #0x65d5f70 ; 
0065D5F5C  mov      w0, wzr
0065D5F60  b        #0x65d5f80 ; 
0065D5F64  ldr      x8, [x1, #0x60]
0065D5F68  mov      x0, x19
0065D5F6C  blr      x8
0065D5F70  cbz      x0, #0x65d5f8c
0065D5F74  ldr      w8, [x0, #0x18]
0065D5F78  cmp      w8, #0
0065D5F7C  cset     w0, ne
0065D5F80  ldp      x20, x19, [sp, #0x10]
0065D5F84  ldp      x30, x21, [sp], #0x20
0065D5F88  ret      
0065D5F8C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$WaveShowStartUIHandle
; RVA 0x65D5F90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D5F90  stp      x30, x21, [sp, #-0x20]!
0065D5F94  stp      x20, x19, [sp, #0x10]
0065D5F98  adrp     x20, #0x9599000
0065D5F9C  adrp     x21, #0x8f0a000
0065D5FA0  ldrb     w8, [x20, #0x5ac]
0065D5FA4  ldr      x21, [x21, #0xb70]
0065D5FA8  mov      x19, x0
0065D5FAC  tbnz     w8, #0, #0x65d5fd0
0065D5FB0  adrp     x0, #0x8f09000
0065D5FB4  ldr      x0, [x0, #0xc08]
0065D5FB8  bl       #0x382bd14 ; 
0065D5FBC  adrp     x0, #0x8f0a000
0065D5FC0  ldr      x0, [x0, #0xb70]
0065D5FC4  bl       #0x382bd14 ; 
0065D5FC8  mov      w8, #1
0065D5FCC  strb     w8, [x20, #0x5ac]
0065D5FD0  ldr      x1, [x21]
0065D5FD4  ldrb     w8, [x1, #0x53]
0065D5FD8  tbnz     w8, #5, #0x65d6018
0065D5FDC  adrp     x20, #0x9599000
0065D5FE0  ldrb     w8, [x20, #0x286]
0065D5FE4  cbnz     w8, #0x65d5ffc
0065D5FE8  adrp     x0, #0x8f07000
0065D5FEC  ldr      x0, [x0, #0xc98]
0065D5FF0  bl       #0x382bd14 ; 
0065D5FF4  mov      w8, #1
0065D5FF8  strb     w8, [x20, #0x286]
0065D5FFC  adrp     x8, #0x8f07000
0065D6000  ldr      x8, [x8, #0xc98]
0065D6004  ldr      x1, [x8]
0065D6008  ldrb     w8, [x1, #0x53]
0065D600C  tbnz     w8, #5, #0x65d6020
0065D6010  ldr      x20, [x19, #0x80]
0065D6014  b        #0x65d6030 ; 
0065D6018  ldr      x2, [x1, #0x60]
0065D601C  b        #0x65d6134 ; 
0065D6020  ldr      x8, [x1, #0x60]
0065D6024  mov      x0, x19
0065D6028  blr      x8
0065D602C  mov      x20, x0
0065D6030  cbz      x20, #0x65d6144
0065D6034  adrp     x21, #0x9599000
0065D6038  ldrb     w8, [x21, #0x2a6]
0065D603C  cbnz     w8, #0x65d6054
0065D6040  adrp     x0, #0x8f08000
0065D6044  ldr      x0, [x0, #0x318]
0065D6048  bl       #0x382bd14 ; 
0065D604C  mov      w8, #1
0065D6050  strb     w8, [x21, #0x2a6]
0065D6054  adrp     x8, #0x8f08000
0065D6058  ldr      x8, [x8, #0x318]
0065D605C  ldr      x1, [x8]
0065D6060  ldrb     w8, [x1, #0x53]
0065D6064  tbnz     w8, #5, #0x65d6078
0065D6068  add      x0, x20, #0x290
0065D606C  mov      x1, xzr
0065D6070  bl       #0x658f8d8 ; HotFix.BattleLogic.BattleData$$GetNextMissionIndex
0065D6074  b        #0x65d6084 ; 
0065D6078  ldr      x8, [x1, #0x60]
0065D607C  mov      x0, x20
0065D6080  blr      x8
0065D6084  mov      w20, w0
0065D6088  ldr      x0, [x19, #0x140]
0065D608C  mov      w1, #1
0065D6090  mov      x2, xzr
0065D6094  bl       #0x64c94c4 ; LocalModelEx$$GetMissionShowSpecialUIType
0065D6098  tbz      w0, #0, #0x65d60bc
0065D609C  mov      x0, x19
0065D60A0  mov      w1, w20
0065D60A4  mov      x2, xzr
0065D60A8  bl       #0x659335c ; HotFix.BattleLogic.BattleManager$$CheckNextBossWave
0065D60AC  ldr      w8, [x19, #0x198]
0065D60B0  add      w8, w8, #1
0065D60B4  str      w8, [x19, #0x198]
0065D60B8  b        #0x65d60d0 ; 
0065D60BC  ldr      x8, [x19]
0065D60C0  mov      x0, x19
0065D60C4  ldr      x9, [x8, #0x288]
0065D60C8  ldr      x1, [x8, #0x290]
0065D60CC  blr      x9
0065D60D0  ldr      x19, [x19, #0x188]
0065D60D4  cbz      x19, #0x65d6144
0065D60D8  adrp     x10, #0x8f09000
0065D60DC  ldr      x8, [x19]
0065D60E0  ldr      x10, [x10, #0xc08]
0065D60E4  ldrh     w9, [x8, #0x12e]
0065D60E8  ldr      x1, [x10]
0065D60EC  cbz      x9, #0x65d6110
0065D60F0  ldr      x10, [x8, #0xb0]
0065D60F4  add      x10, x10, #8
0065D60F8  ldur     x11, [x10, #-8]
0065D60FC  cmp      x11, x1
0065D6100  b.eq     #0x65d6120
0065D6104  subs     x9, x9, #1
0065D6108  add      x10, x10, #0x10
0065D610C  b.ne     #0x65d60f8
0065D6110  mov      w2, #2
0065D6114  mov      x0, x19
0065D6118  bl       #0x3a7e710 ; 
0065D611C  b        #0x65d6130 ; 
0065D6120  ldr      w9, [x10]
0065D6124  add      w9, w9, #2
0065D6128  add      x8, x8, w9, sxtw #4
0065D612C  add      x0, x8, #0x138
0065D6130  ldp      x2, x1, [x0]
0065D6134  mov      x0, x19
0065D6138  ldp      x20, x19, [sp, #0x10]
0065D613C  ldp      x30, x21, [sp], #0x20
0065D6140  br       x2
0065D6144  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$WaveEndHandle
; RVA 0x65D6148; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D6148  stp      x30, x21, [sp, #-0x20]!
0065D614C  stp      x20, x19, [sp, #0x10]
0065D6150  adrp     x20, #0x9599000
0065D6154  adrp     x21, #0x8f0a000
0065D6158  ldrb     w8, [x20, #0x5ad]
0065D615C  ldr      x21, [x21, #0xb78]
0065D6160  mov      x19, x0
0065D6164  tbnz     w8, #0, #0x65d617c
0065D6168  adrp     x0, #0x8f0a000
0065D616C  ldr      x0, [x0, #0xb78]
0065D6170  bl       #0x382bd14 ; 
0065D6174  mov      w8, #1
0065D6178  strb     w8, [x20, #0x5ad]
0065D617C  ldr      x1, [x21]
0065D6180  ldrb     w8, [x1, #0x53]
0065D6184  tbnz     w8, #5, #0x65d6198
0065D6188  ldr      x8, [x19]
0065D618C  ldr      x2, [x8, #0x288]
0065D6190  ldr      x1, [x8, #0x290]
0065D6194  b        #0x65d619c ; 
0065D6198  ldr      x2, [x1, #0x60]
0065D619C  mov      x0, x19
0065D61A0  ldp      x20, x19, [sp, #0x10]
0065D61A4  ldp      x30, x21, [sp], #0x20
0065D61A8  br       x2

; HotFix.BattleLogic.WaterfallBattleManager$$GetCurMissionMultHp
; RVA 0x65D61AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D61AC  str      x30, [sp, #-0x40]!
0065D61B0  stp      x24, x23, [sp, #0x10]
0065D61B4  stp      x22, x21, [sp, #0x20]
0065D61B8  stp      x20, x19, [sp, #0x30]
0065D61BC  adrp     x21, #0x9599000
0065D61C0  adrp     x22, #0x8f0a000
0065D61C4  ldrb     w8, [x21, #0x5ae]
0065D61C8  ldr      x22, [x22, #0xb80]
0065D61CC  mov      w19, w1
0065D61D0  mov      x20, x0
0065D61D4  tbnz     w8, #0, #0x65d61f8
0065D61D8  adrp     x0, #0x8f09000
0065D61DC  ldr      x0, [x0, #0xc08]
0065D61E0  bl       #0x382bd14 ; 
0065D61E4  adrp     x0, #0x8f0a000
0065D61E8  ldr      x0, [x0, #0xb80]
0065D61EC  bl       #0x382bd14 ; 
0065D61F0  mov      w8, #1
0065D61F4  strb     w8, [x21, #0x5ae]
0065D61F8  ldr      x2, [x22]
0065D61FC  ldrb     w8, [x2, #0x53]
0065D6200  tbnz     w8, #5, #0x65d6248
0065D6204  cmp      w19, #1
0065D6208  b.lt     #0x65d6268
0065D620C  adrp     x22, #0x9599000
0065D6210  ldrb     w8, [x22, #0x286]
0065D6214  cbnz     w8, #0x65d622c
0065D6218  adrp     x0, #0x8f07000
0065D621C  ldr      x0, [x0, #0xc98]
0065D6220  bl       #0x382bd14 ; 
0065D6224  mov      w8, #1
0065D6228  strb     w8, [x22, #0x286]
0065D622C  adrp     x23, #0x8f07000
0065D6230  ldr      x23, [x23, #0xc98]
0065D6234  ldr      x1, [x23]
0065D6238  ldrb     w8, [x1, #0x53]
0065D623C  tbnz     w8, #5, #0x65d6280
0065D6240  ldr      x21, [x20, #0x80]
0065D6244  b        #0x65d6290 ; 
0065D6248  ldr      x3, [x2, #0x60]
0065D624C  mov      x0, x20
0065D6250  mov      w1, w19
0065D6254  ldp      x20, x19, [sp, #0x30]
0065D6258  ldp      x22, x21, [sp, #0x20]
0065D625C  ldp      x24, x23, [sp, #0x10]
0065D6260  ldr      x30, [sp], #0x40
0065D6264  br       x3
0065D6268  ldp      x20, x19, [sp, #0x30]
0065D626C  ldp      x22, x21, [sp, #0x20]
0065D6270  ldp      x24, x23, [sp, #0x10]
0065D6274  mov      x0, xzr
0065D6278  ldr      x30, [sp], #0x40
0065D627C  ret      
0065D6280  ldr      x8, [x1, #0x60]
0065D6284  mov      x0, x20
0065D6288  blr      x8
0065D628C  mov      x21, x0
0065D6290  cbz      x21, #0x65d63b0
0065D6294  adrp     x24, #0x9598000
0065D6298  ldrb     w8, [x24, #0xfcc]
0065D629C  cbnz     w8, #0x65d62b4
0065D62A0  adrp     x0, #0x8f06000
0065D62A4  ldr      x0, [x0, #0x470]
0065D62A8  bl       #0x382bd14 ; 
0065D62AC  mov      w8, #1
0065D62B0  strb     w8, [x24, #0xfcc]
0065D62B4  adrp     x8, #0x8f06000
0065D62B8  ldr      x8, [x8, #0x470]
0065D62BC  ldr      x1, [x8]
0065D62C0  ldrb     w8, [x1, #0x53]
0065D62C4  tbnz     w8, #5, #0x65d62d0
0065D62C8  ldr      x21, [x21, #0x200]
0065D62CC  b        #0x65d62e0 ; 
0065D62D0  ldr      x8, [x1, #0x60]
0065D62D4  mov      x0, x21
0065D62D8  blr      x8
0065D62DC  mov      x21, x0
0065D62E0  ldrb     w8, [x22, #0x286]
0065D62E4  cbnz     w8, #0x65d62fc
0065D62E8  adrp     x0, #0x8f07000
0065D62EC  ldr      x0, [x0, #0xc98]
0065D62F0  bl       #0x382bd14 ; 
0065D62F4  mov      w8, #1
0065D62F8  strb     w8, [x22, #0x286]
0065D62FC  ldr      x1, [x23]
0065D6300  ldrb     w8, [x1, #0x53]
0065D6304  tbnz     w8, #5, #0x65d6310
0065D6308  ldr      x0, [x20, #0x80]
0065D630C  b        #0x65d631c ; 
0065D6310  ldr      x8, [x1, #0x60]
0065D6314  mov      x0, x20
0065D6318  blr      x8
0065D631C  cbz      x0, #0x65d63b0
0065D6320  ldr      w1, [x0, #0x1c8]
0065D6324  mov      x0, x21
0065D6328  mov      w2, w19
0065D632C  mov      x3, xzr
0065D6330  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
0065D6334  cbz      x0, #0x65d63b0
0065D6338  adrp     x10, #0x8f09000
0065D633C  ldr      x8, [x0]
0065D6340  ldr      x10, [x10, #0xc08]
0065D6344  mov      x19, x0
0065D6348  ldrh     w9, [x8, #0x12e]
0065D634C  ldr      x1, [x10]
0065D6350  cbz      x9, #0x65d6374
0065D6354  ldr      x10, [x8, #0xb0]
0065D6358  add      x10, x10, #8
0065D635C  ldur     x11, [x10, #-8]
0065D6360  cmp      x11, x1
0065D6364  b.eq     #0x65d6384
0065D6368  subs     x9, x9, #1
0065D636C  add      x10, x10, #0x10
0065D6370  b.ne     #0x65d635c
0065D6374  mov      w2, #0x12
0065D6378  mov      x0, x19
0065D637C  bl       #0x3a7e710 ; 
0065D6380  b        #0x65d6394 ; 
0065D6384  ldr      w9, [x10]
0065D6388  add      w9, w9, #0x12
0065D638C  add      x8, x8, w9, sxtw #4
0065D6390  add      x0, x8, #0x138
0065D6394  ldp      x2, x1, [x0]
0065D6398  mov      x0, x19
0065D639C  ldp      x20, x19, [sp, #0x30]
0065D63A0  ldp      x22, x21, [sp, #0x20]
0065D63A4  ldp      x24, x23, [sp, #0x10]
0065D63A8  ldr      x30, [sp], #0x40
0065D63AC  br       x2
0065D63B0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$CheckShowExpAnim
; RVA 0x65D63B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D63B4  stp      x30, x21, [sp, #-0x20]!
0065D63B8  stp      x20, x19, [sp, #0x10]
0065D63BC  adrp     x20, #0x9599000
0065D63C0  adrp     x21, #0x8f0a000
0065D63C4  ldrb     w8, [x20, #0x5af]
0065D63C8  ldr      x21, [x21, #0xb88]
0065D63CC  mov      x19, x0
0065D63D0  tbnz     w8, #0, #0x65d63f4
0065D63D4  adrp     x0, #0x8f08000
0065D63D8  ldr      x0, [x0, #0x40]
0065D63DC  bl       #0x382bd14 ; 
0065D63E0  adrp     x0, #0x8f0a000
0065D63E4  ldr      x0, [x0, #0xb88]
0065D63E8  bl       #0x382bd14 ; 
0065D63EC  mov      w8, #1
0065D63F0  strb     w8, [x20, #0x5af]
0065D63F4  ldr      x1, [x21]
0065D63F8  ldrb     w8, [x1, #0x53]
0065D63FC  tbnz     w8, #5, #0x65d643c
0065D6400  adrp     x20, #0x9599000
0065D6404  ldrb     w8, [x20, #0x286]
0065D6408  cbnz     w8, #0x65d6420
0065D640C  adrp     x0, #0x8f07000
0065D6410  ldr      x0, [x0, #0xc98]
0065D6414  bl       #0x382bd14 ; 
0065D6418  mov      w8, #1
0065D641C  strb     w8, [x20, #0x286]
0065D6420  adrp     x8, #0x8f07000
0065D6424  ldr      x8, [x8, #0xc98]
0065D6428  ldr      x1, [x8]
0065D642C  ldrb     w8, [x1, #0x53]
0065D6430  tbnz     w8, #5, #0x65d6450
0065D6434  ldr      x0, [x19, #0x80]
0065D6438  b        #0x65d645c ; 
0065D643C  ldr      x2, [x1, #0x60]
0065D6440  mov      x0, x19
0065D6444  ldp      x20, x19, [sp, #0x10]
0065D6448  ldp      x30, x21, [sp], #0x20
0065D644C  br       x2
0065D6450  ldr      x8, [x1, #0x60]
0065D6454  mov      x0, x19
0065D6458  blr      x8
0065D645C  cbz      x0, #0x65d64f4
0065D6460  ldr      x20, [x0, #0x3b8]
0065D6464  cbz      x20, #0x65d64f4
0065D6468  adrp     x10, #0x8f08000
0065D646C  ldr      x8, [x20]
0065D6470  ldr      x10, [x10, #0x40]
0065D6474  ldrh     w9, [x8, #0x12e]
0065D6478  ldr      x1, [x10]
0065D647C  cbz      x9, #0x65d64a0
0065D6480  ldr      x10, [x8, #0xb0]
0065D6484  add      x10, x10, #8
0065D6488  ldur     x11, [x10, #-8]
0065D648C  cmp      x11, x1
0065D6490  b.eq     #0x65d64b0
0065D6494  subs     x9, x9, #1
0065D6498  add      x10, x10, #0x10
0065D649C  b.ne     #0x65d6488
0065D64A0  mov      w2, #0xd
0065D64A4  mov      x0, x20
0065D64A8  bl       #0x3a7e710 ; 
0065D64AC  b        #0x65d64c0 ; 
0065D64B0  ldr      w9, [x10]
0065D64B4  add      w9, w9, #0xd
0065D64B8  add      x8, x8, w9, sxtw #4
0065D64BC  add      x0, x8, #0x138
0065D64C0  ldp      x8, x1, [x0]
0065D64C4  mov      x0, x20
0065D64C8  blr      x8
0065D64CC  cmp      w0, #1
0065D64D0  b.ne     #0x65d64e4
0065D64D4  ldr      w8, [x19, #0x1c8]
0065D64D8  cmp      w8, #0
0065D64DC  cset     w0, eq
0065D64E0  b        #0x65d64e8 ; 
0065D64E4  mov      w0, #1
0065D64E8  ldp      x20, x19, [sp, #0x10]
0065D64EC  ldp      x30, x21, [sp], #0x20
0065D64F0  ret      
0065D64F4  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$WaveModelLevelUp
; RVA 0x65D64F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D64F8  stp      x30, x21, [sp, #-0x20]!
0065D64FC  stp      x20, x19, [sp, #0x10]
0065D6500  adrp     x20, #0x9599000
0065D6504  adrp     x21, #0x8f0a000
0065D6508  ldrb     w8, [x20, #0x5b0]
0065D650C  ldr      x21, [x21, #0xb90]
0065D6510  mov      x19, x0
0065D6514  tbnz     w8, #0, #0x65d652c
0065D6518  adrp     x0, #0x8f0a000
0065D651C  ldr      x0, [x0, #0xb90]
0065D6520  bl       #0x382bd14 ; 
0065D6524  mov      w8, #1
0065D6528  strb     w8, [x20, #0x5b0]
0065D652C  ldr      x1, [x21]
0065D6530  ldrb     w8, [x1, #0x53]
0065D6534  tbnz     w8, #5, #0x65d6564
0065D6538  mov      x0, x19
0065D653C  mov      x1, xzr
0065D6540  bl       #0x6587334 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$get_IsStateWaveShowEnd
0065D6544  tbz      w0, #0, #0x65d6578
0065D6548  ldr      x8, [x19]
0065D654C  mov      x0, x19
0065D6550  ldr      x9, [x8, #0x288]
0065D6554  ldr      x1, [x8, #0x290]
0065D6558  blr      x9
0065D655C  mov      w0, #1
0065D6560  b        #0x65d657c ; 
0065D6564  ldr      x2, [x1, #0x60]
0065D6568  mov      x0, x19
0065D656C  ldp      x20, x19, [sp, #0x10]
0065D6570  ldp      x30, x21, [sp], #0x20
0065D6574  br       x2
0065D6578  mov      w0, wzr
0065D657C  ldp      x20, x19, [sp, #0x10]
0065D6580  ldp      x30, x21, [sp], #0x20
0065D6584  ret      

; HotFix.BattleLogic.WaterfallBattleManager$$GetCharacterDropGold
; RVA 0x65D6588; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D6588  stp      x29, x30, [sp, #-0x60]!
0065D658C  stp      x28, x27, [sp, #0x10]
0065D6590  stp      x26, x25, [sp, #0x20]
0065D6594  stp      x24, x23, [sp, #0x30]
0065D6598  stp      x22, x21, [sp, #0x40]
0065D659C  stp      x20, x19, [sp, #0x50]
0065D65A0  adrp     x20, #0x9599000
0065D65A4  adrp     x22, #0x8f0a000
0065D65A8  ldrb     w8, [x20, #0x5b1]
0065D65AC  ldr      x22, [x22, #0xb98]
0065D65B0  mov      x21, x1
0065D65B4  mov      x19, x0
0065D65B8  tbnz     w8, #0, #0x65d65dc
0065D65BC  adrp     x0, #0x8f09000
0065D65C0  ldr      x0, [x0, #0xfc0]
0065D65C4  bl       #0x382bd14 ; 
0065D65C8  adrp     x0, #0x8f0a000
0065D65CC  ldr      x0, [x0, #0xb98]
0065D65D0  bl       #0x382bd14 ; 
0065D65D4  mov      w8, #1
0065D65D8  strb     w8, [x20, #0x5b1]
0065D65DC  ldr      x2, [x22]
0065D65E0  ldrb     w8, [x2, #0x53]
0065D65E4  tbnz     w8, #5, #0x65d6634
0065D65E8  ldr      x8, [x19, #0x170]
0065D65EC  cbz      x8, #0x65d69f4
0065D65F0  cbz      x21, #0x65d6aec
0065D65F4  adrp     x20, #0x9591000
0065D65F8  ldrb     w8, [x20, #0xa74]
0065D65FC  cbnz     w8, #0x65d6614
0065D6600  adrp     x0, #0x8ee6000
0065D6604  ldr      x0, [x0, #0x288]
0065D6608  bl       #0x382bd14 ; 
0065D660C  mov      w8, #1
0065D6610  strb     w8, [x20, #0xa74]
0065D6614  adrp     x8, #0x8ee6000
0065D6618  ldr      x8, [x8, #0x288]
0065D661C  ldr      x1, [x8]
0065D6620  ldrb     w8, [x1, #0x53]
0065D6624  tbnz     w8, #5, #0x65d665c
0065D6628  ldr      x20, [x21, #0x170]
0065D662C  cbnz     x20, #0x65d6670
0065D6630  b        #0x65d69f8 ; 
0065D6634  ldr      x3, [x2, #0x60]
0065D6638  mov      x0, x19
0065D663C  mov      x1, x21
0065D6640  ldp      x20, x19, [sp, #0x50]
0065D6644  ldp      x22, x21, [sp, #0x40]
0065D6648  ldp      x24, x23, [sp, #0x30]
0065D664C  ldp      x26, x25, [sp, #0x20]
0065D6650  ldp      x28, x27, [sp, #0x10]
0065D6654  ldp      x29, x30, [sp], #0x60
0065D6658  br       x3
0065D665C  ldr      x8, [x1, #0x60]
0065D6660  mov      x0, x21
0065D6664  blr      x8
0065D6668  mov      x20, x0
0065D666C  cbz      x20, #0x65d69f8
0065D6670  mov      x0, x19
0065D6674  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D6678  tbz      w0, #0, #0x65d6710
0065D667C  adrp     x22, #0x9591000
0065D6680  ldrb     w8, [x22, #0xa75]
0065D6684  cbnz     w8, #0x65d669c
0065D6688  adrp     x0, #0x8ee6000
0065D668C  ldr      x0, [x0, #0x290]
0065D6690  bl       #0x382bd14 ; 
0065D6694  mov      w8, #1
0065D6698  strb     w8, [x22, #0xa75]
0065D669C  adrp     x23, #0x8ee6000
0065D66A0  ldr      x23, [x23, #0x290]
0065D66A4  ldr      x1, [x23]
0065D66A8  ldrb     w8, [x1, #0x53]
0065D66AC  tbnz     w8, #5, #0x65d66b8
0065D66B0  ldr      w0, [x20, #0x24]
0065D66B4  b        #0x65d66c4 ; 
0065D66B8  ldr      x8, [x1, #0x60]
0065D66BC  mov      x0, x20
0065D66C0  blr      x8
0065D66C4  cmp      w0, #0xc9
0065D66C8  b.eq     #0x65d6710
0065D66CC  ldrb     w8, [x22, #0xa75]
0065D66D0  cbnz     w8, #0x65d66e8
0065D66D4  adrp     x0, #0x8ee6000
0065D66D8  ldr      x0, [x0, #0x290]
0065D66DC  bl       #0x382bd14 ; 
0065D66E0  mov      w8, #1
0065D66E4  strb     w8, [x22, #0xa75]
0065D66E8  ldr      x1, [x23]
0065D66EC  ldrb     w8, [x1, #0x53]
0065D66F0  tbnz     w8, #5, #0x65d66fc
0065D66F4  ldr      w0, [x20, #0x24]
0065D66F8  b        #0x65d6708 ; 
0065D66FC  ldr      x8, [x1, #0x60]
0065D6700  mov      x0, x20
0065D6704  blr      x8
0065D6708  cmp      w0, #3
0065D670C  b.ne     #0x65d69f4
0065D6710  adrp     x22, #0x9599000
0065D6714  ldrb     w8, [x22, #0x4ec]
0065D6718  cbnz     w8, #0x65d6730
0065D671C  adrp     x0, #0x8f09000
0065D6720  ldr      x0, [x0, #0xfc8]
0065D6724  bl       #0x382bd14 ; 
0065D6728  mov      w8, #1
0065D672C  strb     w8, [x22, #0x4ec]
0065D6730  adrp     x8, #0x8f09000
0065D6734  ldr      x8, [x8, #0xfc8]
0065D6738  ldr      x1, [x8]
0065D673C  ldrb     w8, [x1, #0x53]
0065D6740  tbnz     w8, #5, #0x65d674c
0065D6744  ldr      w23, [x20, #0x268]
0065D6748  b        #0x65d675c ; 
0065D674C  ldr      x8, [x1, #0x60]
0065D6750  mov      x0, x20
0065D6754  blr      x8
0065D6758  mov      w23, w0
0065D675C  adrp     x20, #0x9599000
0065D6760  ldrb     w8, [x20, #0x286]
0065D6764  cbnz     w8, #0x65d677c
0065D6768  adrp     x0, #0x8f07000
0065D676C  ldr      x0, [x0, #0xc98]
0065D6770  bl       #0x382bd14 ; 
0065D6774  mov      w8, #1
0065D6778  strb     w8, [x20, #0x286]
0065D677C  adrp     x8, #0x8f07000
0065D6780  ldr      x8, [x8, #0xc98]
0065D6784  ldr      x1, [x8]
0065D6788  ldrb     w8, [x1, #0x53]
0065D678C  tbnz     w8, #5, #0x65d6798
0065D6790  ldr      x20, [x19, #0x80]
0065D6794  b        #0x65d67a8 ; 
0065D6798  ldr      x8, [x1, #0x60]
0065D679C  mov      x0, x19
0065D67A0  blr      x8
0065D67A4  mov      x20, x0
0065D67A8  cbz      x20, #0x65d6aec
0065D67AC  adrp     x22, #0x9598000
0065D67B0  ldrb     w8, [x22, #0xfcc]
0065D67B4  cbnz     w8, #0x65d67cc
0065D67B8  adrp     x0, #0x8f06000
0065D67BC  ldr      x0, [x0, #0x470]
0065D67C0  bl       #0x382bd14 ; 
0065D67C4  mov      w8, #1
0065D67C8  strb     w8, [x22, #0xfcc]
0065D67CC  adrp     x8, #0x8f06000
0065D67D0  ldr      x8, [x8, #0x470]
0065D67D4  ldr      x1, [x8]
0065D67D8  ldrb     w8, [x1, #0x53]
0065D67DC  tbnz     w8, #5, #0x65d67e8
0065D67E0  ldr      x0, [x20, #0x200]
0065D67E4  b        #0x65d67f4 ; 
0065D67E8  ldr      x8, [x1, #0x60]
0065D67EC  mov      x0, x20
0065D67F0  blr      x8
0065D67F4  cbz      x0, #0x65d6aec
0065D67F8  mov      w1, w23
0065D67FC  mov      x2, xzr
0065D6800  bl       #0x64d34c0 ; LocalModels.LocalModelManager$$GetCharacter_MonsterDropType
0065D6804  cbz      x0, #0x65d69f4
0065D6808  adrp     x8, #0x8f09000
0065D680C  ldr      x8, [x8, #0xfc0]
0065D6810  mov      x22, x0
0065D6814  ldr      x0, [x8]
0065D6818  bl       #0x382bfa0 ; 
0065D681C  mov      x1, xzr
0065D6820  mov      x20, x0
0065D6824  bl       #0x66604f8 ; HotFix.BattleLogic.BattleDropItemData$$.ctor
0065D6828  cmp      w23, #1
0065D682C  b.ne     #0x65d6838
0065D6830  ldrb     w8, [x21, #0x88]
0065D6834  cbz      w8, #0x65d69f8
0065D6838  adrp     x23, #0x9599000
0065D683C  ldrb     w8, [x23, #0x65a]
0065D6840  ldr      x21, [x19, #0x170]
0065D6844  cbnz     w8, #0x65d685c
0065D6848  adrp     x0, #0x8f0a000
0065D684C  ldr      x0, [x0, #0x9c8]
0065D6850  bl       #0x382bd14 ; 
0065D6854  mov      w8, #1
0065D6858  strb     w8, [x23, #0x65a]
0065D685C  adrp     x8, #0x8f0a000
0065D6860  ldr      x8, [x8, #0x9c8]
0065D6864  ldr      x1, [x8]
0065D6868  ldrb     w8, [x1, #0x53]
0065D686C  tbnz     w8, #5, #0x65d6878
0065D6870  ldr      x0, [x22, #0x28]
0065D6874  b        #0x65d6884 ; 
0065D6878  ldr      x8, [x1, #0x60]
0065D687C  mov      x0, x22
0065D6880  blr      x8
0065D6884  mul      x8, x0, x21
0065D6888  asr      x0, x8, #0x10
0065D688C  mov      x1, xzr
0065D6890  bl       #0x7d46e14 ; Photon.Deterministic.FPMath$$Floor
0065D6894  adrp     x23, #0x9599000
0065D6898  ldrb     w8, [x23, #0x4ed]
0065D689C  mov      x21, x0
0065D68A0  cbnz     w8, #0x65d68b8
0065D68A4  adrp     x0, #0x8f09000
0065D68A8  ldr      x0, [x0, #0xfd0]
0065D68AC  bl       #0x382bd14 ; 
0065D68B0  mov      w8, #1
0065D68B4  strb     w8, [x23, #0x4ed]
0065D68B8  adrp     x8, #0x8f09000
0065D68BC  ldr      x8, [x8, #0xfd0]
0065D68C0  ldr      x1, [x8]
0065D68C4  ldrb     w8, [x1, #0x53]
0065D68C8  tbnz     w8, #5, #0x65d68d4
0065D68CC  ldr      w0, [x22, #0x38]
0065D68D0  b        #0x65d68e0 ; 
0065D68D4  ldr      x8, [x1, #0x60]
0065D68D8  mov      x0, x22
0065D68DC  blr      x8
0065D68E0  sbfiz    x0, x0, #0x10, #0x20
0065D68E4  mov      x1, x21
0065D68E8  mov      x2, xzr
0065D68EC  bl       #0x7d46f8c ; Photon.Deterministic.FPMath$$Min
0065D68F0  cbz      x0, #0x65d69ec
0065D68F4  lsl      x8, x21, #0x10
0065D68F8  mov      x23, x0
0065D68FC  sdiv     x0, x8, x0
0065D6900  mov      x1, xzr
0065D6904  bl       #0x7d46e14 ; Photon.Deterministic.FPMath$$Floor
0065D6908  cmp      x23, #1
0065D690C  b.lt     #0x65d69a4
0065D6910  adrp     x25, #0x8f09000
0065D6914  ldr      x25, [x25, #0xfd8]
0065D6918  mov      x24, x0
0065D691C  mov      x9, xzr
0065D6920  mov      x8, xzr
0065D6924  sub      x28, x23, #0x10, lsl #12
0065D6928  adrp     x27, #0x9599000
0065D692C  mov      w26, #1
0065D6930  ldrb     w10, [x27, #0x4ee]
0065D6934  nop      
0065D6938  msub     x8, x8, x24, x21
0065D693C  cmp      x9, x28
0065D6940  csel     x29, x8, x24, eq
0065D6944  cbnz     w10, #0x65d6958
0065D6948  mov      x0, x25
0065D694C  bl       #0x382bd14 ; 
0065D6950  mov      w8, #1
0065D6954  strb     w8, [x27, #0x4ee]
0065D6958  ldr      x1, [x25]
0065D695C  ldrb     w8, [x1, #0x53]
0065D6960  tbnz     w8, #5, #0x65d696c
0065D6964  ldr      w1, [x22, #0x3c]
0065D6968  b        #0x65d697c ; 
0065D696C  ldr      x8, [x1, #0x60]
0065D6970  mov      x0, x22
0065D6974  blr      x8
0065D6978  mov      w1, w0
0065D697C  cbz      x20, #0x65d6aec
0065D6980  lsr      x2, x29, #0x10
0065D6984  mov      x0, x20
0065D6988  mov      x3, xzr
0065D698C  bl       #0x66605ac ; HotFix.BattleLogic.BattleDropItemData$$AddDropItem
0065D6990  sbfiz    x9, x26, #0x10, #0x20
0065D6994  sxtw     x8, w26
0065D6998  cmp      x9, x23
0065D699C  add      w26, w26, #1
0065D69A0  b.lt     #0x65d6930
0065D69A4  ldr      x8, [x19, #0x208]
0065D69A8  adrp     x22, #0x9599000
0065D69AC  add      x8, x8, x21
0065D69B0  str      x8, [x19, #0x208]
0065D69B4  ldrb     w8, [x22, #0x286]
0065D69B8  cbnz     w8, #0x65d69d0
0065D69BC  adrp     x0, #0x8f07000
0065D69C0  ldr      x0, [x0, #0xc98]
0065D69C4  bl       #0x382bd14 ; 
0065D69C8  mov      w8, #1
0065D69CC  strb     w8, [x22, #0x286]
0065D69D0  adrp     x8, #0x8f07000
0065D69D4  ldr      x8, [x8, #0xc98]
0065D69D8  ldr      x1, [x8]
0065D69DC  ldrb     w8, [x1, #0x53]
0065D69E0  tbnz     w8, #5, #0x65d6a18
0065D69E4  ldr      x19, [x19, #0x80]
0065D69E8  b        #0x65d6a28 ; 
0065D69EC  mov      x1, xzr
0065D69F0  bl       #0x7d46e14 ; Photon.Deterministic.FPMath$$Floor
0065D69F4  mov      x20, xzr
0065D69F8  mov      x0, x20
0065D69FC  ldp      x20, x19, [sp, #0x50]
0065D6A00  ldp      x22, x21, [sp, #0x40]
0065D6A04  ldp      x24, x23, [sp, #0x30]
0065D6A08  ldp      x26, x25, [sp, #0x20]
0065D6A0C  ldp      x28, x27, [sp, #0x10]
0065D6A10  ldp      x29, x30, [sp], #0x60
0065D6A14  ret      
0065D6A18  ldr      x8, [x1, #0x60]
0065D6A1C  mov      x0, x19
0065D6A20  blr      x8
0065D6A24  mov      x19, x0
0065D6A28  cbz      x19, #0x65d6aec
0065D6A2C  adrp     x22, #0x9599000
0065D6A30  ldrb     w8, [x22, #0x663]
0065D6A34  lsr      x21, x21, #0x10
0065D6A38  cbnz     w8, #0x65d6a50
0065D6A3C  adrp     x0, #0x8f0a000
0065D6A40  ldr      x0, [x0, #0xba0]
0065D6A44  bl       #0x382bd14 ; 
0065D6A48  mov      w8, #1
0065D6A4C  strb     w8, [x22, #0x663]
0065D6A50  adrp     x8, #0x8f0a000
0065D6A54  ldr      x8, [x8, #0xba0]
0065D6A58  ldr      x2, [x8]
0065D6A5C  ldrb     w8, [x2, #0x53]
0065D6A60  tbnz     w8, #5, #0x65d6aa0
0065D6A64  adrp     x22, #0x9598000
0065D6A68  ldrb     w8, [x22, #0xfc4]
0065D6A6C  cbnz     w8, #0x65d6a84
0065D6A70  adrp     x0, #0x8f05000
0065D6A74  ldr      x0, [x0, #0xfd8]
0065D6A78  bl       #0x382bd14 ; 
0065D6A7C  mov      w8, #1
0065D6A80  strb     w8, [x22, #0xfc4]
0065D6A84  adrp     x8, #0x8f05000
0065D6A88  ldr      x8, [x8, #0xfd8]
0065D6A8C  ldr      x1, [x8]
0065D6A90  ldrb     w8, [x1, #0x53]
0065D6A94  tbnz     w8, #5, #0x65d6ab4
0065D6A98  ldr      x0, [x19, #0x220]
0065D6A9C  b        #0x65d6ac0 ; 
0065D6AA0  ldr      x8, [x2, #0x60]
0065D6AA4  mov      x0, x19
0065D6AA8  mov      w1, w21
0065D6AAC  blr      x8
0065D6AB0  b        #0x65d69f8 ; 
0065D6AB4  ldr      x8, [x1, #0x60]
0065D6AB8  mov      x0, x19
0065D6ABC  blr      x8
0065D6AC0  cbz      x0, #0x65d6aec
0065D6AC4  ldr      x8, [x0]
0065D6AC8  ldr      x9, [x8, #0x598]
0065D6ACC  ldr      x1, [x8, #0x5a0]
0065D6AD0  blr      x9
0065D6AD4  mov      w1, w0
0065D6AD8  add      x0, x19, #0x290
0065D6ADC  mov      w2, w21
0065D6AE0  mov      x3, xzr
0065D6AE4  bl       #0x658e8ac ; HotFix.BattleLogic.BattleData$$AddWaveGoldValue
0065D6AE8  b        #0x65d69f8 ; 
0065D6AEC  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$ShuffleWithFisherYates
; RVA 0x65D163C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D163C  sub      sp, sp, #0x70
0065D1640  stp      x29, x30, [sp, #0x10]
0065D1644  stp      x28, x27, [sp, #0x20]
0065D1648  stp      x26, x25, [sp, #0x30]
0065D164C  stp      x24, x23, [sp, #0x40]
0065D1650  stp      x22, x21, [sp, #0x50]
0065D1654  stp      x20, x19, [sp, #0x60]
0065D1658  adrp     x19, #0x9599000
0065D165C  adrp     x22, #0x8f0a000
0065D1660  ldrb     w8, [x19, #0x5b2]
0065D1664  ldr      x22, [x22, #0x9d8]
0065D1668  mov      w23, w2
0065D166C  mov      w21, w1
0065D1670  mov      x20, x0
0065D1674  tbnz     w8, #0, #0x65d16c8
0065D1678  adrp     x0, #0x8f0a000
0065D167C  ldr      x0, [x0, #0x9e0]
0065D1680  bl       #0x382bd14 ; 
0065D1684  adrp     x0, #0x8f06000
0065D1688  ldr      x0, [x0, #0x4a8]
0065D168C  bl       #0x382bd14 ; 
0065D1690  adrp     x0, #0x8ec2000
0065D1694  ldr      x0, [x0, #0x268]
0065D1698  bl       #0x382bd14 ; 
0065D169C  adrp     x0, #0x8ec2000
0065D16A0  ldr      x0, [x0, #0x270]
0065D16A4  bl       #0x382bd14 ; 
0065D16A8  adrp     x0, #0x8f0a000
0065D16AC  ldr      x0, [x0, #0x9e8]
0065D16B0  bl       #0x382bd14 ; 
0065D16B4  adrp     x0, #0x8f0a000
0065D16B8  ldr      x0, [x0, #0x9d8]
0065D16BC  bl       #0x382bd14 ; 
0065D16C0  mov      w8, #1
0065D16C4  strb     w8, [x19, #0x5b2]
0065D16C8  ldr      x3, [x22]
0065D16CC  ldrb     w8, [x3, #0x53]
0065D16D0  tbnz     w8, #5, #0x65d1820
0065D16D4  mov      w0, #1
0065D16D8  mov      w1, w21
0065D16DC  mov      x2, xzr
0065D16E0  str      w23, [sp, #0xc]
0065D16E4  bl       #0x7fd1824 ; System.Linq.Enumerable$$Range
0065D16E8  adrp     x8, #0x8f06000
0065D16EC  ldr      x8, [x8, #0x4a8]
0065D16F0  ldr      x1, [x8]
0065D16F4  bl       #0x45dc05c ; System.Linq.Enumerable$$ToList<int>
0065D16F8  cbz      x0, #0x65d1850
0065D16FC  ldr      w22, [x0, #0x18]
0065D1700  mov      x21, x0
0065D1704  sub      w8, w22, #1
0065D1708  cmp      w8, #1
0065D170C  b.lt     #0x65d17dc
0065D1710  adrp     x23, #0x8f07000
0065D1714  adrp     x27, #0x8ec2000
0065D1718  adrp     x19, #0x8f0a000
0065D171C  ldr      x23, [x23, #0xc98]
0065D1720  ldr      x27, [x27, #0x270]
0065D1724  ldr      x19, [x19, #0x9e8]
0065D1728  adrp     x28, #0x9599000
0065D172C  mov      w29, #1
0065D1730  ldrb     w8, [x28, #0x286]
0065D1734  cbnz     w8, #0x65d1744
0065D1738  mov      x0, x23
0065D173C  bl       #0x382bd14 ; 
0065D1740  strb     w29, [x28, #0x286]
0065D1744  ldr      x1, [x23]
0065D1748  ldrb     w8, [x1, #0x53]
0065D174C  tbnz     w8, #5, #0x65d1758
0065D1750  ldr      x0, [x20, #0x80]
0065D1754  b        #0x65d1764 ; 
0065D1758  ldr      x8, [x1, #0x60]
0065D175C  mov      x0, x20
0065D1760  blr      x8
0065D1764  cbz      x0, #0x65d1850
0065D1768  mov      w1, wzr
0065D176C  mov      w2, w22
0065D1770  mov      x3, xzr
0065D1774  sub      w24, w22, #1
0065D1778  bl       #0x54b65d8 ; 
0065D177C  ldr      x2, [x27]
0065D1780  mov      w25, w0
0065D1784  mov      x0, x21
0065D1788  mov      w1, w24
0065D178C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065D1790  ldr      x2, [x27]
0065D1794  mov      w26, w0
0065D1798  mov      x0, x21
0065D179C  mov      w1, w25
0065D17A0  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065D17A4  ldr      x3, [x19]
0065D17A8  mov      w2, w0
0065D17AC  mov      x0, x21
0065D17B0  mov      w1, w24
0065D17B4  bl       #0x4d642b8 ; System.Collections.Generic.List<int>$$set_Item
0065D17B8  ldr      x3, [x19]
0065D17BC  mov      x0, x21
0065D17C0  mov      w1, w25
0065D17C4  mov      w2, w26
0065D17C8  bl       #0x4d642b8 ; System.Collections.Generic.List<int>$$set_Item
0065D17CC  sub      w8, w22, #2
0065D17D0  cmp      w8, #0
0065D17D4  mov      w22, w24
0065D17D8  b.gt     #0x65d1730
0065D17DC  adrp     x8, #0x8f0a000
0065D17E0  ldr      x8, [x8, #0x9e0]
0065D17E4  ldr      w1, [sp, #0xc]
0065D17E8  mov      x0, x21
0065D17EC  ldr      x2, [x8]
0065D17F0  bl       #0x45d7ab8 ; System.Linq.Enumerable$$Take<int>
0065D17F4  adrp     x8, #0x8f06000
0065D17F8  ldr      x8, [x8, #0x4a8]
0065D17FC  ldp      x20, x19, [sp, #0x60]
0065D1800  ldp      x22, x21, [sp, #0x50]
0065D1804  ldp      x24, x23, [sp, #0x40]
0065D1808  ldr      x1, [x8]
0065D180C  ldp      x26, x25, [sp, #0x30]
0065D1810  ldp      x28, x27, [sp, #0x20]
0065D1814  ldp      x29, x30, [sp, #0x10]
0065D1818  add      sp, sp, #0x70
0065D181C  b        #0x45dc05c ; System.Linq.Enumerable$$ToList<int>
0065D1820  ldr      x4, [x3, #0x60]
0065D1824  mov      x0, x20
0065D1828  mov      w1, w21
0065D182C  mov      w2, w23
0065D1830  ldp      x20, x19, [sp, #0x60]
0065D1834  ldp      x22, x21, [sp, #0x50]
0065D1838  ldp      x24, x23, [sp, #0x40]
0065D183C  ldp      x26, x25, [sp, #0x30]
0065D1840  ldp      x28, x27, [sp, #0x20]
0065D1844  ldp      x29, x30, [sp, #0x10]
0065D1848  add      sp, sp, #0x70
0065D184C  br       x4
0065D1850  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WaterfallBattleManager$$GetCurWave
; RVA 0x65D6AF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D6AF0  stp      x30, x21, [sp, #-0x20]!
0065D6AF4  stp      x20, x19, [sp, #0x10]
0065D6AF8  adrp     x20, #0x9599000
0065D6AFC  adrp     x21, #0x8f0a000
0065D6B00  ldrb     w8, [x20, #0x5b3]
0065D6B04  ldr      x21, [x21, #0xba8]
0065D6B08  mov      x19, x0
0065D6B0C  tbnz     w8, #0, #0x65d6b24
0065D6B10  adrp     x0, #0x8f0a000
0065D6B14  ldr      x0, [x0, #0xba8]
0065D6B18  bl       #0x382bd14 ; 
0065D6B1C  mov      w8, #1
0065D6B20  strb     w8, [x20, #0x5b3]
0065D6B24  ldr      x1, [x21]
0065D6B28  ldrb     w8, [x1, #0x53]
0065D6B2C  tbnz     w8, #5, #0x65d6b74
0065D6B30  ldr      x19, [x19, #0x140]
0065D6B34  cbz      x19, #0x65d6b88
0065D6B38  adrp     x20, #0x9598000
0065D6B3C  ldrb     w8, [x20, #0xcaa]
0065D6B40  cbnz     w8, #0x65d6b58
0065D6B44  adrp     x0, #0x8efd000
0065D6B48  ldr      x0, [x0, #0x270]
0065D6B4C  bl       #0x382bd14 ; 
0065D6B50  mov      w8, #1
0065D6B54  strb     w8, [x20, #0xcaa]
0065D6B58  adrp     x8, #0x8efd000
0065D6B5C  ldr      x8, [x8, #0x270]
0065D6B60  ldr      x1, [x8]
0065D6B64  ldrb     w8, [x1, #0x53]
0065D6B68  tbnz     w8, #5, #0x65d6b90
0065D6B6C  ldr      w0, [x19, #0x20]
0065D6B70  b        #0x65d6b9c ; 
0065D6B74  ldr      x2, [x1, #0x60]
0065D6B78  mov      x0, x19
0065D6B7C  ldp      x20, x19, [sp, #0x10]
0065D6B80  ldp      x30, x21, [sp], #0x20
0065D6B84  br       x2
0065D6B88  mov      w0, #1
0065D6B8C  b        #0x65d6bbc ; 
0065D6B90  ldr      x8, [x1, #0x60]
0065D6B94  mov      x0, x19
0065D6B98  blr      x8
0065D6B9C  mov      w8, #0x851f
0065D6BA0  movk     w8, #0x51eb, lsl #16
0065D6BA4  smull    x8, w0, w8
0065D6BA8  lsr      x9, x8, #0x3f
0065D6BAC  asr      x8, x8, #0x25
0065D6BB0  add      w8, w8, w9
0065D6BB4  mov      w9, #0x64
0065D6BB8  msub     w0, w8, w9, w0
0065D6BBC  ldp      x20, x19, [sp, #0x10]
0065D6BC0  ldp      x30, x21, [sp], #0x20
0065D6BC4  ret      

; HotFix.BattleLogic.WaterfallBattleManager$$.ctor
; RVA 0x65D6BC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D6BC8  str      x30, [sp, #-0x50]!
0065D6BCC  stp      x26, x25, [sp, #0x10]
0065D6BD0  stp      x24, x23, [sp, #0x20]
0065D6BD4  stp      x22, x21, [sp, #0x30]
0065D6BD8  stp      x20, x19, [sp, #0x40]
0065D6BDC  adrp     x20, #0x9599000
0065D6BE0  adrp     x21, #0x8f0a000
0065D6BE4  ldrb     w8, [x20, #0x5b4]
0065D6BE8  ldr      x21, [x21, #0xbb0]
0065D6BEC  mov      x19, x0
0065D6BF0  tbnz     w8, #0, #0x65d6c68
0065D6BF4  adrp     x0, #0x8f0a000
0065D6BF8  ldr      x0, [x0, #0xbb8]
0065D6BFC  bl       #0x382bd14 ; 
0065D6C00  adrp     x0, #0x8f0a000
0065D6C04  ldr      x0, [x0, #0xbc0]
0065D6C08  bl       #0x382bd14 ; 
0065D6C0C  adrp     x0, #0x8f0a000
0065D6C10  ldr      x0, [x0, #0x8e0]
0065D6C14  bl       #0x382bd14 ; 
0065D6C18  adrp     x0, #0x8f0a000
0065D6C1C  ldr      x0, [x0, #0xbc8]
0065D6C20  bl       #0x382bd14 ; 
0065D6C24  adrp     x0, #0x8f0a000
0065D6C28  ldr      x0, [x0, #0x8e8]
0065D6C2C  bl       #0x382bd14 ; 
0065D6C30  adrp     x0, #0x8f0a000
0065D6C34  ldr      x0, [x0, #0xbd0]
0065D6C38  bl       #0x382bd14 ; 
0065D6C3C  adrp     x0, #0x8f0a000
0065D6C40  ldr      x0, [x0, #0xbd8]
0065D6C44  bl       #0x382bd14 ; 
0065D6C48  adrp     x0, #0x8f09000
0065D6C4C  ldr      x0, [x0, #0xaf0]
0065D6C50  bl       #0x382bd14 ; 
0065D6C54  adrp     x0, #0x8f0a000
0065D6C58  ldr      x0, [x0, #0xbb0]
0065D6C5C  bl       #0x382bd14 ; 
0065D6C60  mov      w8, #1
0065D6C64  strb     w8, [x20, #0x5b4]
0065D6C68  ldr      x1, [x21]
0065D6C6C  ldrb     w8, [x1, #0x53]
0065D6C70  tbnz     w8, #5, #0x65d6d98
0065D6C74  adrp     x8, #0x8f09000
0065D6C78  ldr      x8, [x8, #0xaf0]
0065D6C7C  adrp     x20, #0x8f0a000
0065D6C80  adrp     x23, #0x8f0a000
0065D6C84  adrp     x24, #0x8f0a000
0065D6C88  adrp     x25, #0x8f0a000
0065D6C8C  mov      w9, #-1
0065D6C90  mov      x10, #-0x10000
0065D6C94  ldr      x20, [x20, #0xbd8]
0065D6C98  ldr      x23, [x23, #0x8e8]
0065D6C9C  ldr      x24, [x24, #0x8e0]
0065D6CA0  ldr      x25, [x25, #0xbc0]
0065D6CA4  str      w9, [x19, #0x114]
0065D6CA8  str      x10, [x19, #0x120]
0065D6CAC  ldr      x0, [x8]
0065D6CB0  adrp     x26, #0x8f0a000
0065D6CB4  adrp     x22, #0x8f0a000
0065D6CB8  adrp     x21, #0x8f0a000
0065D6CBC  ldr      x26, [x26, #0xbb8]
0065D6CC0  ldr      x22, [x22, #0xbd0]
0065D6CC4  ldr      x21, [x21, #0xbc8]
0065D6CC8  bl       #0x382bfa0 ; 
0065D6CCC  ldr      x1, [x20]
0065D6CD0  mov      x20, x0
0065D6CD4  bl       #0x5221198 ; Rock.Collections.OrderedDictionary<int, int>$$.ctor
0065D6CD8  add      x0, x19, #0x168
0065D6CDC  mov      x1, x20
0065D6CE0  str      x20, [x19, #0x168]
0065D6CE4  bl       #0x382bcb8 ; 
0065D6CE8  ldr      x0, [x23]
0065D6CEC  bl       #0x382bfa0 ; 
0065D6CF0  ldr      x1, [x24]
0065D6CF4  mov      x20, x0
0065D6CF8  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0065D6CFC  add      x0, x19, #0x190
0065D6D00  mov      x1, x20
0065D6D04  str      x20, [x19, #0x190]
0065D6D08  bl       #0x382bcb8 ; 
0065D6D0C  add      x8, x19, #0x19c
0065D6D10  movi     v0.2d, #0xffffffffffffffff
0065D6D14  str      d0, [x8]
0065D6D18  str      xzr, [x19, #0x1b0]
0065D6D1C  str      xzr, [x19, #0x1c0]
0065D6D20  stp      xzr, xzr, [x19, #0x1d8]
0065D6D24  ldr      x0, [x25]
0065D6D28  bl       #0x382bfa0 ; 
0065D6D2C  ldr      x1, [x26]
0065D6D30  mov      x20, x0
0065D6D34  bl       #0x5e5ec40 ; System.Collections.Generic.Dictionary<int, object>$$.ctor
0065D6D38  add      x0, x19, #0x1f0
0065D6D3C  mov      x1, x20
0065D6D40  str      x20, [x19, #0x1f0]
0065D6D44  bl       #0x382bcb8 ; 
0065D6D48  ldr      x0, [x22]
0065D6D4C  bl       #0x382bfa0 ; 
0065D6D50  ldr      x1, [x21]
0065D6D54  mov      x20, x0
0065D6D58  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0065D6D5C  add      x0, x19, #0x200
0065D6D60  mov      x1, x20
0065D6D64  str      x20, [x19, #0x200]
0065D6D68  bl       #0x382bcb8 ; 
0065D6D6C  mov      w8, #1
0065D6D70  str      xzr, [x19, #0x208]
0065D6D74  strb     w8, [x19, #0x210]
0065D6D78  mov      x0, x19
0065D6D7C  ldp      x20, x19, [sp, #0x40]
0065D6D80  ldp      x22, x21, [sp, #0x30]
0065D6D84  ldp      x24, x23, [sp, #0x20]
0065D6D88  ldp      x26, x25, [sp, #0x10]
0065D6D8C  mov      x1, xzr
0065D6D90  ldr      x30, [sp], #0x50
0065D6D94  b        #0x658a660 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$.ctor
0065D6D98  ldr      x2, [x1, #0x60]
0065D6D9C  mov      x0, x19
0065D6DA0  ldp      x20, x19, [sp, #0x40]
0065D6DA4  ldp      x22, x21, [sp, #0x30]
0065D6DA8  ldp      x24, x23, [sp, #0x20]
0065D6DAC  ldp      x26, x25, [sp, #0x10]
0065D6DB0  ldr      x30, [sp], #0x50
0065D6DB4  br       x2

