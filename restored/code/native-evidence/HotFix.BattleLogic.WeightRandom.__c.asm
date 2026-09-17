; HotFix.BattleLogic.WeightRandom.<>c$$.cctor
; RVA 0x6636630; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006636630  str      x30, [sp, #-0x20]!
006636634  stp      x20, x19, [sp, #0x10]
006636638  adrp     x19, #0x9599000
00663663C  adrp     x20, #0x8f0c000
006636640  ldrb     w8, [x19, #0x9f5]
006636644  ldr      x20, [x20, #0xf68]
006636648  tbnz     w8, #0, #0x6636660
00663664C  adrp     x0, #0x8f0c000
006636650  ldr      x0, [x0, #0xf68]
006636654  bl       #0x382bd14 ; 
006636658  mov      w8, #1
00663665C  strb     w8, [x19, #0x9f5]
006636660  ldr      x0, [x20]
006636664  bl       #0x382bfa0 ; 
006636668  mov      x19, x0
00663666C  bl       #0x6636694 ; HotFix.BattleLogic.WeightRandom.<>c$$.ctor
006636670  ldr      x8, [x20]
006636674  mov      x1, x19
006636678  ldr      x8, [x8, #0xb8]
00663667C  str      x19, [x8]
006636680  ldr      x8, [x20]
006636684  ldp      x20, x19, [sp, #0x10]
006636688  ldr      x0, [x8, #0xb8]
00663668C  ldr      x30, [sp], #0x20
006636690  b        #0x382bcb8 ; 

; HotFix.BattleLogic.WeightRandom.<>c$$.ctor
; RVA 0x6636694; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006636694  stp      x30, x21, [sp, #-0x20]!
006636698  stp      x20, x19, [sp, #0x10]
00663669C  adrp     x20, #0x9599000
0066366A0  adrp     x21, #0x8f0d000
0066366A4  ldrb     w8, [x20, #0x9f6]
0066366A8  ldr      x21, [x21, #0xe8]
0066366AC  mov      x19, x0
0066366B0  tbnz     w8, #0, #0x66366c8
0066366B4  adrp     x0, #0x8f0d000
0066366B8  ldr      x0, [x0, #0xe8]
0066366BC  bl       #0x382bd14 ; 
0066366C0  mov      w8, #1
0066366C4  strb     w8, [x20, #0x9f6]
0066366C8  ldr      x1, [x21]
0066366CC  ldrb     w8, [x1, #0x53]
0066366D0  tbnz     w8, #5, #0x66366e8
0066366D4  mov      x0, x19
0066366D8  ldp      x20, x19, [sp, #0x10]
0066366DC  mov      x1, xzr
0066366E0  ldp      x30, x21, [sp], #0x20
0066366E4  b        #0x7c335dc ; System.Object$$.ctor
0066366E8  ldr      x2, [x1, #0x60]
0066366EC  mov      x0, x19
0066366F0  ldp      x20, x19, [sp, #0x10]
0066366F4  ldp      x30, x21, [sp], #0x20
0066366F8  br       x2

; HotFix.BattleLogic.WeightRandom.<>c$$<GetInfo>b__10_0
; RVA 0x66366FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066366FC  sub      sp, sp, #0x70
006636700  str      x30, [sp, #0x40]
006636704  stp      x22, x21, [sp, #0x50]
006636708  stp      x20, x19, [sp, #0x60]
00663670C  adrp     x21, #0x9599000
006636710  adrp     x22, #0x8f0c000
006636714  ldrb     w8, [x21, #0x9f7]
006636718  ldr      x22, [x22, #0xf60]
00663671C  mov      x19, x1
006636720  mov      x20, x0
006636724  tbnz     w8, #0, #0x6636754
006636728  adrp     x0, #0x8ebf000
00663672C  ldr      x0, [x0, #0xba0]
006636730  bl       #0x382bd14 ; 
006636734  adrp     x0, #0x8f0c000
006636738  ldr      x0, [x0, #0xf60]
00663673C  bl       #0x382bd14 ; 
006636740  adrp     x0, #0x8f0d000
006636744  ldr      x0, [x0, #0xf0]
006636748  bl       #0x382bd14 ; 
00663674C  mov      w8, #1
006636750  strb     w8, [x21, #0x9f7]
006636754  ldr      x2, [x22]
006636758  ldrb     w8, [x2, #0x53]
00663675C  tbnz     w8, #5, #0x66367c0
006636760  adrp     x21, #0x8ebf000
006636764  ldr      x21, [x21, #0xba0]
006636768  ldr      w8, [x19]
00663676C  adrp     x22, #0x8f0d000
006636770  add      x1, sp, #0x4c
006636774  ldr      x0, [x21]
006636778  ldr      x22, [x22, #0xf0]
00663677C  str      w8, [sp, #0x4c]
006636780  bl       #0x382be94 ; 
006636784  mov      x20, x0
006636788  mov      x0, x19
00663678C  bl       #0x663206c ; HotFix.BattleLogic.WeightRandomData$$Weight
006636790  ldr      x8, [x21]
006636794  str      w0, [sp, #0x48]
006636798  add      x1, sp, #0x48
00663679C  mov      x0, x8
0066367A0  bl       #0x382be94 ; 
0066367A4  ldr      x8, [x22]
0066367A8  mov      x2, x0
0066367AC  mov      x1, x20
0066367B0  mov      x3, xzr
0066367B4  mov      x0, x8
0066367B8  bl       #0x79e2794 ; System.String$$Format
0066367BC  b        #0x66367e8 ; 
0066367C0  ldp      q2, q0, [x19, #0x10]
0066367C4  ldr      x8, [x19, #0x30]
0066367C8  ldr      q1, [x19]
0066367CC  ldr      x9, [x2, #0x60]
0066367D0  mov      x1, sp
0066367D4  mov      x0, x20
0066367D8  str      x8, [sp, #0x30]
0066367DC  stp      q2, q0, [sp, #0x10]
0066367E0  str      q1, [sp]
0066367E4  blr      x9
0066367E8  ldp      x20, x19, [sp, #0x60]
0066367EC  ldp      x22, x21, [sp, #0x50]
0066367F0  ldr      x30, [sp, #0x40]
0066367F4  add      sp, sp, #0x70
0066367F8  ret      

; HotFix.BattleLogic.WeightRandom.<>c$$<LogAllId>b__34_0
; RVA 0x66367FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066367FC  sub      sp, sp, #0x70
006636800  str      x30, [sp, #0x40]
006636804  stp      x22, x21, [sp, #0x50]
006636808  stp      x20, x19, [sp, #0x60]
00663680C  adrp     x21, #0x9599000
006636810  adrp     x22, #0x8f0d000
006636814  ldrb     w8, [x21, #0x9f8]
006636818  ldr      x22, [x22, #0xd0]
00663681C  mov      x20, x1
006636820  mov      x19, x0
006636824  tbnz     w8, #0, #0x663683c
006636828  adrp     x0, #0x8f0d000
00663682C  ldr      x0, [x0, #0xd0]
006636830  bl       #0x382bd14 ; 
006636834  mov      w8, #1
006636838  strb     w8, [x21, #0x9f8]
00663683C  ldr      x2, [x22]
006636840  ldrb     w8, [x2, #0x53]
006636844  tbnz     w8, #5, #0x6636850
006636848  ldr      w0, [x20]
00663684C  b        #0x6636878 ; 
006636850  ldp      q2, q0, [x20, #0x10]
006636854  ldr      x8, [x20, #0x30]
006636858  ldr      q1, [x20]
00663685C  ldr      x9, [x2, #0x60]
006636860  mov      x1, sp
006636864  mov      x0, x19
006636868  str      x8, [sp, #0x30]
00663686C  stp      q2, q0, [sp, #0x10]
006636870  str      q1, [sp]
006636874  blr      x9
006636878  ldp      x20, x19, [sp, #0x60]
00663687C  ldp      x22, x21, [sp, #0x50]
006636880  ldr      x30, [sp, #0x40]
006636884  add      sp, sp, #0x70
006636888  ret      

