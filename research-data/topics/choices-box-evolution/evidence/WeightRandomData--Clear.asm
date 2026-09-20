; HotFix.BattleLogic.WeightRandomData$$Clear
; RVA 0x6631E40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631E40  stp      x30, x21, [sp, #-0x20]!
006631E44  stp      x20, x19, [sp, #0x10]
006631E48  adrp     x20, #0x9599000
006631E4C  adrp     x21, #0x8f0c000
006631E50  ldrb     w8, [x20, #0x9bf]
006631E54  ldr      x21, [x21, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.Clear() @ 0x92cbb88
006631E58  mov      x19, x0
006631E5C  tbnz     w8, #0, #0x6631e80
006631E60  adrp     x0, #0x8ec2000
006631E64  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.List<int>.Clear() @ 0x921de58
006631E68  bl       #0x382bd14 ; 
006631E6C  adrp     x0, #0x8f0c000
006631E70  ldr      x0, [x0, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.Clear() @ 0x92cbb88
006631E74  bl       #0x382bd14 ; 
006631E78  mov      w8, #1
006631E7C  strb     w8, [x20, #0x9bf]
006631E80  ldr      x1, [x21]
006631E84  ldrb     w8, [x1, #0x53]
006631E88  tbnz     w8, #5, #0x6631ecc
006631E8C  mov      x0, x19
006631E90  str      xzr, [x0, #0x10]!
006631E94  mov      x1, xzr
006631E98  stp      xzr, xzr, [x19]
006631E9C  bl       #0x382bcb8 ; 
006631EA0  ldr      x8, [x19, #0x28]
006631EA4  str      xzr, [x19, #0x18]
006631EA8  strh     wzr, [x19, #0x20]
006631EAC  strb     wzr, [x19, #0x30]
006631EB0  cbz      x8, #0x6631ee0
006631EB4  ldr      w9, [x8, #0x1c]
006631EB8  ldp      x20, x19, [sp, #0x10]
006631EBC  add      w9, w9, #1
006631EC0  stp      wzr, w9, [x8, #0x18]
006631EC4  ldp      x30, x21, [sp], #0x20
006631EC8  ret      
006631ECC  ldr      x2, [x1, #0x60]
006631ED0  mov      x0, x19
006631ED4  ldp      x20, x19, [sp, #0x10]
006631ED8  ldp      x30, x21, [sp], #0x20
006631EDC  br       x2
006631EE0  bl       #0x382bfb8 ; 

