; HotFix.BattleLogic.WeightRandomData$$CopyFrom
; RVA 0x6632604; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632604  str      x30, [sp, #-0x30]!
006632608  stp      x22, x21, [sp, #0x10]
00663260C  stp      x20, x19, [sp, #0x20]
006632610  adrp     x21, #0x9599000
006632614  adrp     x22, #0x8f0c000
006632618  ldrb     w8, [x21, #0x9d5]
00663261C  ldr      x22, [x22, #0xf08] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.CopyFrom() @ 0x92cbb90
006632620  mov      x20, x1
006632624  mov      x19, x0
006632628  tbnz     w8, #0, #0x6632670
00663262C  adrp     x0, #0x8f08000
006632630  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
006632634  bl       #0x382bd14 ; 
006632638  adrp     x0, #0x8ec2000
00663263C  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.List<int>.Clear() @ 0x921de58
006632640  bl       #0x382bd14 ; 
006632644  adrp     x0, #0x8edb000
006632648  ldr      x0, [x0, #0x2f8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de30
00663264C  bl       #0x382bd14 ; 
006632650  adrp     x0, #0x8ec2000
006632654  ldr      x0, [x0, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
006632658  bl       #0x382bd14 ; 
00663265C  adrp     x0, #0x8f0c000
006632660  ldr      x0, [x0, #0xf08] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.CopyFrom() @ 0x92cbb90
006632664  bl       #0x382bd14 ; 
006632668  mov      w8, #1
00663266C  strb     w8, [x21, #0x9d5]
006632670  ldr      x2, [x22]
006632674  ldrb     w8, [x2, #0x53]
006632678  tbnz     w8, #5, #0x66326cc
00663267C  ldr      q0, [x20]
006632680  mov      x0, x19
006632684  str      q0, [x19]
006632688  ldr      x1, [x20, #0x10]
00663268C  str      x1, [x0, #0x10]!
006632690  bl       #0x382bcb8 ; 
006632694  ldr      x9, [x20, #0x18]
006632698  ldr      x8, [x19, #0x28]!
00663269C  stur     x9, [x19, #-0x10]
0066326A0  ldrb     w9, [x20, #0x20]
0066326A4  sturb    w9, [x19, #-8]
0066326A8  ldrb     w9, [x20, #0x21]
0066326AC  sturb    w9, [x19, #-7]
0066326B0  ldrb     w9, [x20, #0x30]
0066326B4  strb     w9, [x19, #8]
0066326B8  cbz      x8, #0x66326e8
0066326BC  ldr      w9, [x8, #0x1c]
0066326C0  add      w9, w9, #1
0066326C4  stp      wzr, w9, [x8, #0x18]
0066326C8  b        #0x6632720 ; 
0066326CC  ldr      x3, [x2, #0x60]
0066326D0  mov      x0, x19
0066326D4  mov      x1, x20
0066326D8  ldp      x20, x19, [sp, #0x20]
0066326DC  ldp      x22, x21, [sp, #0x10]
0066326E0  ldr      x30, [sp], #0x30
0066326E4  br       x3
0066326E8  adrp     x8, #0x8ec2000
0066326EC  ldr      x8, [x8, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
0066326F0  ldr      x0, [x8]
0066326F4  bl       #0x382bfa0 ; 
0066326F8  adrp     x8, #0x8edb000
0066326FC  ldr      x8, [x8, #0x2f8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de30
006632700  mov      w1, #0xa
006632704  mov      x21, x0
006632708  ldr      x2, [x8]
00663270C  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
006632710  mov      x0, x19
006632714  mov      x1, x21
006632718  str      x21, [x19]
00663271C  bl       #0x382bcb8 ; 
006632720  ldr      x1, [x20, #0x28]
006632724  cbz      x1, #0x663274c
006632728  ldr      x0, [x19]
00663272C  cbz      x0, #0x663275c
006632730  adrp     x8, #0x8f08000
006632734  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
006632738  ldp      x20, x19, [sp, #0x20]
00663273C  ldp      x22, x21, [sp, #0x10]
006632740  ldr      x2, [x8]
006632744  ldr      x30, [sp], #0x30
006632748  b        #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
00663274C  ldp      x20, x19, [sp, #0x20]
006632750  ldp      x22, x21, [sp, #0x10]
006632754  ldr      x30, [sp], #0x30
006632758  ret      
00663275C  bl       #0x382bfb8 ; 

