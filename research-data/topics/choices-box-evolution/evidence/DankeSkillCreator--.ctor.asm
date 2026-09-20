; HotFix.BattleLogic.DankeSkillCreator$$.ctor
; RVA 0x68662AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068662AC  stp      x30, x25, [sp, #-0x40]!
0068662B0  stp      x24, x23, [sp, #0x10]
0068662B4  stp      x22, x21, [sp, #0x20]
0068662B8  stp      x20, x19, [sp, #0x30]
0068662BC  adrp     x20, #0x959b000
0068662C0  adrp     x21, #0x8f23000
0068662C4  ldrb     w8, [x20, #0xa09]
0068662C8  ldr      x21, [x21, #0xe10] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator..ctor() @ 0x9259ce8
0068662CC  mov      x19, x0
0068662D0  tbnz     w8, #0, #0x6866324
0068662D4  adrp     x0, #0x8f23000
0068662D8  ldr      x0, [x0, #0xe10] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator..ctor() @ 0x9259ce8
0068662DC  bl       #0x382bd14 ; 
0068662E0  adrp     x0, #0x8ec1000
0068662E4  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
0068662E8  bl       #0x382bd14 ; 
0068662EC  adrp     x0, #0x8ec2000
0068662F0  ldr      x0, [x0, #0x2b8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de20
0068662F4  bl       #0x382bd14 ; 
0068662F8  adrp     x0, #0x8ec2000
0068662FC  ldr      x0, [x0, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
006866300  bl       #0x382bd14 ; 
006866304  adrp     x0, #0x8f23000
006866308  ldr      x0, [x0, #0xe18] ; GLOBAL Field$<PrivateImplementationDetails>.8FFB9854C9B7DA4E349B54EC7D5BCC01F68E52871488EBA5D417FD01CAABC488 @ 0x92e50d0
00686630C  bl       #0x382bd14 ; 
006866310  adrp     x0, #0x8f23000
006866314  ldr      x0, [x0, #0xe20] ; GLOBAL Field$<PrivateImplementationDetails>.CDBAD42B461EAAF67DC39C10FBADBA96C5BA2D08FAE0794E5EF3DFFADAB969EE @ 0x92e5100
006866318  bl       #0x382bd14 ; 
00686631C  mov      w8, #1
006866320  strb     w8, [x20, #0xa09]
006866324  ldr      x1, [x21]
006866328  ldrb     w8, [x1, #0x53]
00686632C  tbnz     w8, #5, #0x6866444
006866330  adrp     x24, #0x8ec1000
006866334  ldr      x24, [x24, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
006866338  adrp     x25, #0x8f23000
00686633C  ldr      x25, [x25, #0xe20] ; GLOBAL Field$<PrivateImplementationDetails>.CDBAD42B461EAAF67DC39C10FBADBA96C5BA2D08FAE0794E5EF3DFFADAB969EE @ 0x92e5100
006866340  adrp     x23, #0x8f23000
006866344  ldr      x0, [x24]
006866348  adrp     x22, #0x8ec2000
00686634C  adrp     x21, #0x8ec2000
006866350  ldr      x23, [x23, #0xe18] ; GLOBAL Field$<PrivateImplementationDetails>.8FFB9854C9B7DA4E349B54EC7D5BCC01F68E52871488EBA5D417FD01CAABC488 @ 0x92e50d0
006866354  ldr      x22, [x22, #0x2d0] ; GLOBAL System.Collections.Generic.List<int>_TypeInfo @ 0x91da058
006866358  ldr      x21, [x21, #0x2b8] ; GLOBAL Method$System.Collections.Generic.List<int>..ctor() @ 0x921de20
00686635C  mov      w1, #6
006866360  bl       #0x382bdfc ; 
006866364  ldr      x1, [x25]
006866368  mov      x2, xzr
00686636C  mov      x20, x0
006866370  bl       #0x7ac27c0 ; System.Runtime.CompilerServices.RuntimeHelpers$$InitializeArray
006866374  mov      x0, x19
006866378  str      x20, [x0, #0xa0]!
00686637C  mov      x1, x20
006866380  bl       #0x382bcb8 ; 
006866384  ldr      x0, [x24]
006866388  mov      w1, #6
00686638C  bl       #0x382bdfc ; 
006866390  ldr      x1, [x23]
006866394  mov      x2, xzr
006866398  mov      x20, x0
00686639C  bl       #0x7ac27c0 ; System.Runtime.CompilerServices.RuntimeHelpers$$InitializeArray
0068663A0  mov      x0, x19
0068663A4  str      x20, [x0, #0xa8]!
0068663A8  mov      x1, x20
0068663AC  bl       #0x382bcb8 ; 
0068663B0  ldr      x0, [x24]
0068663B4  mov      w1, #6
0068663B8  bl       #0x382bdfc ; 
0068663BC  ldr      x1, [x25]
0068663C0  mov      x2, xzr
0068663C4  mov      x20, x0
0068663C8  bl       #0x7ac27c0 ; System.Runtime.CompilerServices.RuntimeHelpers$$InitializeArray
0068663CC  mov      x0, x19
0068663D0  str      x20, [x0, #0xb0]!
0068663D4  mov      x1, x20
0068663D8  bl       #0x382bcb8 ; 
0068663DC  ldr      x0, [x24]
0068663E0  mov      w1, #6
0068663E4  bl       #0x382bdfc ; 
0068663E8  ldr      x1, [x23]
0068663EC  mov      x2, xzr
0068663F0  mov      x20, x0
0068663F4  bl       #0x7ac27c0 ; System.Runtime.CompilerServices.RuntimeHelpers$$InitializeArray
0068663F8  mov      x0, x19
0068663FC  str      x20, [x0, #0xb8]!
006866400  mov      x1, x20
006866404  bl       #0x382bcb8 ; 
006866408  ldr      x0, [x22]
00686640C  bl       #0x382bfa0 ; 
006866410  ldr      x1, [x21]
006866414  mov      x20, x0
006866418  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
00686641C  mov      x0, x19
006866420  str      x20, [x0, #0xc0]!
006866424  mov      x1, x20
006866428  bl       #0x382bcb8 ; 
00686642C  mov      x0, x19
006866430  ldp      x20, x19, [sp, #0x30]
006866434  ldp      x22, x21, [sp, #0x20]
006866438  ldp      x24, x23, [sp, #0x10]
00686643C  ldp      x30, x25, [sp], #0x40
006866440  b        #0x6866460 ; HotFix.BattleLogic.NormalSkillCreator$$.ctor
006866444  ldr      x2, [x1, #0x60]
006866448  mov      x0, x19
00686644C  ldp      x20, x19, [sp, #0x30]
006866450  ldp      x22, x21, [sp, #0x20]
006866454  ldp      x24, x23, [sp, #0x10]
006866458  ldp      x30, x25, [sp], #0x40
00686645C  br       x2

