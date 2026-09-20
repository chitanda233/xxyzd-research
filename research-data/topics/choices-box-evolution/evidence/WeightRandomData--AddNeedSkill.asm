; HotFix.BattleLogic.WeightRandomData$$AddNeedSkill
; RVA 0x6632510; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632510  str      x30, [sp, #-0x30]!
006632514  stp      x22, x21, [sp, #0x10]
006632518  stp      x20, x19, [sp, #0x20]
00663251C  adrp     x21, #0x9599000
006632520  adrp     x22, #0x8f0c000
006632524  ldrb     w8, [x21, #0x9d3]
006632528  ldr      x22, [x22, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.AddNeedSkill() @ 0x92cbb68
00663252C  mov      w20, w1
006632530  mov      x19, x0
006632534  tbnz     w8, #0, #0x6632570
006632538  adrp     x0, #0x8f08000
00663253C  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006632540  bl       #0x382bd14 ; 
006632544  adrp     x0, #0x8edb000
006632548  ldr      x0, [x0, #0x180] ; GLOBAL Method$System.Collections.Generic.List<int>.Remove() @ 0x921de90
00663254C  bl       #0x382bd14 ; 
006632550  adrp     x0, #0x8ec2000
006632554  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006632558  bl       #0x382bd14 ; 
00663255C  adrp     x0, #0x8f0c000
006632560  ldr      x0, [x0, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.AddNeedSkill() @ 0x92cbb68
006632564  bl       #0x382bd14 ; 
006632568  mov      w8, #1
00663256C  strb     w8, [x21, #0x9d3]
006632570  ldr      x2, [x22]
006632574  ldrb     w8, [x2, #0x53]
006632578  tbnz     w8, #5, #0x66325dc
00663257C  ldr      x0, [x19, #0x28]
006632580  cbz      x0, #0x6632600
006632584  adrp     x8, #0x8f08000
006632588  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00663258C  mov      w1, w20
006632590  ldr      x2, [x8]
006632594  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006632598  tbz      w0, #0, #0x66325c8
00663259C  ldr      x0, [x19, #0x28]
0066325A0  cbz      x0, #0x6632600
0066325A4  adrp     x8, #0x8edb000
0066325A8  ldr      x8, [x8, #0x180] ; GLOBAL Method$System.Collections.Generic.List<int>.Remove() @ 0x921de90
0066325AC  mov      w1, w20
0066325B0  ldr      x2, [x8]
0066325B4  bl       #0x4d65db8 ; System.Collections.Generic.List<int>$$Remove
0066325B8  ldr      x8, [x19, #0x28]
0066325BC  cbz      x8, #0x6632600
0066325C0  ldr      w8, [x8, #0x18]
0066325C4  cbz      w8, #0x66325f8
0066325C8  mov      w0, wzr
0066325CC  ldp      x20, x19, [sp, #0x20]
0066325D0  ldp      x22, x21, [sp, #0x10]
0066325D4  ldr      x30, [sp], #0x30
0066325D8  ret      
0066325DC  ldr      x3, [x2, #0x60]
0066325E0  mov      x0, x19
0066325E4  mov      w1, w20
0066325E8  ldp      x20, x19, [sp, #0x20]
0066325EC  ldp      x22, x21, [sp, #0x10]
0066325F0  ldr      x30, [sp], #0x30
0066325F4  br       x3
0066325F8  mov      w0, #1
0066325FC  b        #0x66325cc ; 
006632600  bl       #0x382bfb8 ; 

