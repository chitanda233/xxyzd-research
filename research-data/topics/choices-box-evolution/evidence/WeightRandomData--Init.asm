; HotFix.BattleLogic.WeightRandomData$$Init
; RVA 0x6631EE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631EE4  str      x30, [sp, #-0x50]!
006631EE8  stp      x26, x25, [sp, #0x10]
006631EEC  stp      x24, x23, [sp, #0x20]
006631EF0  stp      x22, x21, [sp, #0x30]
006631EF4  stp      x20, x19, [sp, #0x40]
006631EF8  adrp     x25, #0x9599000
006631EFC  adrp     x26, #0x8f0c000
006631F00  ldrb     w8, [x25, #0x9c1]
006631F04  ldr      x26, [x26, #0xeb8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.Init() @ 0x92cbbb0
006631F08  mov      x19, x5
006631F0C  mov      x21, x4
006631F10  mov      w22, w3
006631F14  mov      w23, w2
006631F18  mov      w24, w1
006631F1C  mov      x20, x0
006631F20  tbnz     w8, #0, #0x6631f68
006631F24  adrp     x0, #0x8f08000
006631F28  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
006631F2C  bl       #0x382bd14 ; 
006631F30  adrp     x0, #0x8ec2000
006631F34  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.List<int>.Clear() @ 0x921de58
006631F38  bl       #0x382bd14 ; 
006631F3C  adrp     x0, #0x8edb000
006631F40  ldr      x0, [x0, #0x2f8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de30
006631F44  bl       #0x382bd14 ; 
006631F48  adrp     x0, #0x8ec2000
006631F4C  ldr      x0, [x0, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
006631F50  bl       #0x382bd14 ; 
006631F54  adrp     x0, #0x8f0c000
006631F58  ldr      x0, [x0, #0xeb8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.Init() @ 0x92cbbb0
006631F5C  bl       #0x382bd14 ; 
006631F60  mov      w8, #1
006631F64  strb     w8, [x25, #0x9c1]
006631F68  ldr      x6, [x26]
006631F6C  ldrb     w8, [x6, #0x53]
006631F70  tbnz     w8, #5, #0x6631fe0
006631F74  mov      x0, x20
006631F78  stp      w24, w23, [x20]
006631F7C  stp      w23, w22, [x20, #8]
006631F80  str      x21, [x0, #0x10]!
006631F84  mov      x1, x21
006631F88  bl       #0x382bcb8 ; 
006631F8C  ldr      x8, [x20, #0x28]!
006631F90  stur     xzr, [x20, #-0x10]
006631F94  sturh    wzr, [x20, #-8]
006631F98  strb     wzr, [x20, #8]
006631F9C  cbz      x8, #0x6632014
006631FA0  ldr      w9, [x8, #0x1c]
006631FA4  add      w9, w9, #1
006631FA8  stp      wzr, w9, [x8, #0x18]
006631FAC  cbz      x19, #0x6632050
006631FB0  ldr      x0, [x20]
006631FB4  cbz      x0, #0x6632068
006631FB8  adrp     x8, #0x8f08000
006631FBC  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
006631FC0  mov      x1, x19
006631FC4  ldp      x20, x19, [sp, #0x40]
006631FC8  ldp      x22, x21, [sp, #0x30]
006631FCC  ldr      x2, [x8]
006631FD0  ldp      x24, x23, [sp, #0x20]
006631FD4  ldp      x26, x25, [sp, #0x10]
006631FD8  ldr      x30, [sp], #0x50
006631FDC  b        #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
006631FE0  ldr      x7, [x6, #0x60]
006631FE4  mov      x0, x20
006631FE8  mov      w1, w24
006631FEC  mov      w2, w23
006631FF0  mov      w3, w22
006631FF4  mov      x4, x21
006631FF8  mov      x5, x19
006631FFC  ldp      x20, x19, [sp, #0x40]
006632000  ldp      x22, x21, [sp, #0x30]
006632004  ldp      x24, x23, [sp, #0x20]
006632008  ldp      x26, x25, [sp, #0x10]
00663200C  ldr      x30, [sp], #0x50
006632010  br       x7
006632014  adrp     x8, #0x8ec2000
006632018  ldr      x8, [x8, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
00663201C  ldr      x0, [x8]
006632020  bl       #0x382bfa0 ; 
006632024  adrp     x8, #0x8edb000
006632028  ldr      x8, [x8, #0x2f8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de30
00663202C  mov      w1, #0xa
006632030  mov      x21, x0
006632034  ldr      x2, [x8]
006632038  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
00663203C  mov      x0, x20
006632040  mov      x1, x21
006632044  str      x21, [x20]
006632048  bl       #0x382bcb8 ; 
00663204C  cbnz     x19, #0x6631fb0
006632050  ldp      x20, x19, [sp, #0x40]
006632054  ldp      x22, x21, [sp, #0x30]
006632058  ldp      x24, x23, [sp, #0x20]
00663205C  ldp      x26, x25, [sp, #0x10]
006632060  ldr      x30, [sp], #0x50
006632064  ret      
006632068  bl       #0x382bfb8 ; 

