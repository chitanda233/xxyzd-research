; HotFix.BattleLogic.AIStateController$$SelectWeightedRandomIndex
; RVA 0x6B90668; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B90668  str      x30, [sp, #-0x30]!
006B9066C  stp      x22, x21, [sp, #0x10]
006B90670  stp      x20, x19, [sp, #0x20]
006B90674  adrp     x21, #0x959f000
006B90678  adrp     x22, #0x8f43000
006B9067C  ldrb     w8, [x21, #0xfd1]
006B90680  ldr      x22, [x22, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.SelectWeightedRandomIndex()
006B90684  mov      x19, x1
006B90688  mov      x20, x0
006B9068C  tbnz     w8, #0, #0x6b906a4
006B90690  adrp     x0, #0x8f43000
006B90694  ldr      x0, [x0, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.SelectWeightedRandomIndex()
006B90698  bl       #0x382bd14 ; 
006B9069C  mov      w8, #1
006B906A0  strb     w8, [x21, #0xfd1]
006B906A4  ldr      x2, [x22]
006B906A8  ldrb     w8, [x2, #0x53]
006B906AC  tbnz     w8, #5, #0x6b906ec
006B906B0  cbz      x19, #0x6b907d4
006B906B4  ldr      w8, [x19, #0x18]
006B906B8  lsl      x9, x8, #0x20
006B906BC  cmp      x9, #1
006B906C0  b.lt     #0x6b90708
006B906C4  mov      x21, xzr
006B906C8  sxtw     x9, w8
006B906CC  add      x10, x19, #0x20
006B906D0  cbz      x8, #0x6b907d0
006B906D4  ldr      x11, [x10], #8
006B906D8  sub      x9, x9, #1
006B906DC  sub      x8, x8, #1
006B906E0  add      x21, x11, x21
006B906E4  cbnz     x9, #0x6b906d0
006B906E8  b        #0x6b9070c ; 
006B906EC  ldr      x3, [x2, #0x60]
006B906F0  mov      x0, x20
006B906F4  mov      x1, x19
006B906F8  ldp      x20, x19, [sp, #0x20]
006B906FC  ldp      x22, x21, [sp, #0x10]
006B90700  ldr      x30, [sp], #0x30
006B90704  br       x3
006B90708  mov      x21, xzr
006B9070C  cmp      x21, #1
006B90710  b.lt     #0x6b90750
006B90714  adrp     x22, #0x9591000
006B90718  ldrb     w8, [x22, #0xa4b]
006B9071C  cbnz     w8, #0x6b90734
006B90720  adrp     x0, #0x8ee5000
006B90724  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B90728  bl       #0x382bd14 ; 
006B9072C  mov      w8, #1
006B90730  strb     w8, [x22, #0xa4b]
006B90734  adrp     x8, #0x8ee5000
006B90738  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006B9073C  ldr      x1, [x8]
006B90740  ldrb     w8, [x1, #0x53]
006B90744  tbnz     w8, #5, #0x6b90758
006B90748  ldr      x0, [x20, #0x20]
006B9074C  b        #0x6b90764 ; 
006B90750  mov      w8, wzr
006B90754  b        #0x6b907bc ; 
006B90758  ldr      x8, [x1, #0x60]
006B9075C  mov      x0, x20
006B90760  blr      x8
006B90764  cbz      x0, #0x6b907d4
006B90768  mov      x1, xzr
006B9076C  mov      x2, x21
006B90770  mov      x3, xzr
006B90774  bl       #0x563860c ; 
006B90778  ldr      w9, [x19, #0x18]
006B9077C  subs     w8, w9, #1
006B90780  b.lt     #0x6b907bc
006B90784  mov      x10, xzr
006B90788  mov      x11, xzr
006B9078C  add      x12, x19, #0x20
006B90790  cmp      w10, w9
006B90794  b.hs     #0x6b907d0
006B90798  ldr      x13, [x12, x10, lsl #3]
006B9079C  add      x11, x13, x11
006B907A0  cmp      x0, x11
006B907A4  b.lt     #0x6b907b8
006B907A8  add      x10, x10, #1
006B907AC  cmp      w10, w9
006B907B0  b.lt     #0x6b90790
006B907B4  b        #0x6b907bc ; 
006B907B8  mov      w8, w10
006B907BC  ldp      x20, x19, [sp, #0x20]
006B907C0  ldp      x22, x21, [sp, #0x10]
006B907C4  mov      w0, w8
006B907C8  ldr      x30, [sp], #0x30
006B907CC  ret      
006B907D0  bl       #0x382bfc0 ; 
006B907D4  bl       #0x382bfb8 ; 

