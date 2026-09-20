; HotFix.PunchboardViewModule$$DispatchSelectCmd
; RVA 0x778A1B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00778A1B4  str      x30, [sp, #-0x50]!
00778A1B8  stp      x26, x25, [sp, #0x10]
00778A1BC  stp      x24, x23, [sp, #0x20]
00778A1C0  stp      x22, x21, [sp, #0x30]
00778A1C4  stp      x20, x19, [sp, #0x40]
00778A1C8  adrp     x20, #0x95ab000
00778A1CC  adrp     x21, #0x8fb7000
00778A1D0  ldrb     w8, [x20, #0x288]
00778A1D4  ldr      x21, [x21, #0x400] ; GLOBAL Method$HotFix.PunchboardViewModule.DispatchSelectCmd() @ 0x929baf0
00778A1D8  mov      x19, x0
00778A1DC  tbnz     w8, #0, #0x778a290
00778A1E0  adrp     x0, #0x8f73000
00778A1E4  ldr      x0, [x0, #0xd78] ; GLOBAL Method$HotFix.BattleWorldElementCreator.CreateCommand<PunchboardCommand>() @ 0x92402c0
00778A1E8  bl       #0x382bd14 ; 
00778A1EC  adrp     x0, #0x8fb7000
00778A1F0  ldr      x0, [x0, #0x408] ; GLOBAL System.Comparison<PunchboardSkillRandomData>_TypeInfo @ 0x91d0e20
00778A1F4  bl       #0x382bd14 ; 
00778A1F8  adrp     x0, #0x8f6e000
00778A1FC  ldr      x0, [x0, #0x4c8] ; GLOBAL Method$System.Linq.Enumerable.Select<PunchboardSkillRandomData, int>() @ 0x9265598
00778A200  bl       #0x382bd14 ; 
00778A204  adrp     x0, #0x8f06000
00778A208  ldr      x0, [x0, #0x4a8] ; GLOBAL Method$System.Linq.Enumerable.ToList<int>() @ 0x9265be8
00778A20C  bl       #0x382bd14 ; 
00778A210  adrp     x0, #0x8f6e000
00778A214  ldr      x0, [x0, #0x4d0] ; GLOBAL System.Func<PunchboardSkillRandomData, int>_TypeInfo @ 0x91d5e30
00778A218  bl       #0x382bd14 ; 
00778A21C  adrp     x0, #0x8ee1000
00778A220  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
00778A224  bl       #0x382bd14 ; 
00778A228  adrp     x0, #0x8fb7000
00778A22C  ldr      x0, [x0, #0x410] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Sort() @ 0x921f558
00778A230  bl       #0x382bd14 ; 
00778A234  adrp     x0, #0x8fb7000
00778A238  ldr      x0, [x0, #0x400] ; GLOBAL Method$HotFix.PunchboardViewModule.DispatchSelectCmd() @ 0x929baf0
00778A23C  bl       #0x382bd14 ; 
00778A240  adrp     x0, #0x8f6e000
00778A244  ldr      x0, [x0, #0x4d8] ; GLOBAL HotFix.PunchboardViewModule_TypeInfo @ 0x91ee730
00778A248  bl       #0x382bd14 ; 
00778A24C  adrp     x0, #0x8f6b000
00778A250  ldr      x0, [x0, #0xbf8] ; GLOBAL HotFix.Tracker_TypeInfo @ 0x91f2b68
00778A254  bl       #0x382bd14 ; 
00778A258  adrp     x0, #0x8fb7000
00778A25C  ldr      x0, [x0, #0x418] ; GLOBAL Method$HotFix.PunchboardViewModule.<>c.<DispatchSelectCmd>b__82_0() @ 0x92dcf70
00778A260  bl       #0x382bd14 ; 
00778A264  adrp     x0, #0x8fb7000
00778A268  ldr      x0, [x0, #0x420] ; GLOBAL Method$HotFix.PunchboardViewModule.<>c.<DispatchSelectCmd>b__82_1() @ 0x92dcf78
00778A26C  bl       #0x382bd14 ; 
00778A270  adrp     x0, #0x8fb7000
00778A274  ldr      x0, [x0, #0x300] ; GLOBAL HotFix.PunchboardViewModule.<>c_TypeInfo @ 0x91fba28
00778A278  bl       #0x382bd14 ; 
00778A27C  adrp     x0, #0x8fb7000
00778A280  ldr      x0, [x0, #0x428] ; GLOBAL 赌博机 @ 0x932ddc8
00778A284  bl       #0x382bd14 ; 
00778A288  mov      w8, #1
00778A28C  strb     w8, [x20, #0x288]
00778A290  ldr      x1, [x21]
00778A294  ldrb     w8, [x1, #0x53]
00778A298  tbnz     w8, #5, #0x778a318
00778A29C  mov      x0, xzr
00778A2A0  bl       #0x6f993bc ; HotFix.BattleGame$$get_ElementCreator
00778A2A4  cbz      x0, #0x778a6f8
00778A2A8  adrp     x8, #0x8f73000
00778A2AC  ldr      x8, [x8, #0xd78] ; GLOBAL Method$HotFix.BattleWorldElementCreator.CreateCommand<PunchboardCommand>() @ 0x92402c0
00778A2B0  mov      w1, #0x15
00778A2B4  ldr      x2, [x8]
00778A2B8  bl       #0x4540634 ; HotFix.BattleWorldElementCreator$$CreateCommand<object>
00778A2BC  adrp     x23, #0x95a4000
00778A2C0  ldrb     w8, [x23, #0x459]
00778A2C4  mov      x19, x0
00778A2C8  cbnz     w8, #0x778a2ec
00778A2CC  adrp     x0, #0x8f6c000
00778A2D0  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
00778A2D4  bl       #0x382bd14 ; 
00778A2D8  adrp     x0, #0x8f6c000
00778A2DC  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00778A2E0  bl       #0x382bd14 ; 
00778A2E4  mov      w8, #1
00778A2E8  strb     w8, [x23, #0x459]
00778A2EC  adrp     x26, #0x8f6c000
00778A2F0  ldr      x26, [x26, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
00778A2F4  ldr      x0, [x26]
00778A2F8  ldrb     w8, [x0, #0x53]
00778A2FC  tbnz     w8, #5, #0x778a338
00778A300  adrp     x8, #0x8f6c000
00778A304  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00778A308  ldr      x8, [x8]
00778A30C  ldr      x8, [x8, #0xb8]
00778A310  ldr      x0, [x8]
00778A314  b        #0x778a340 ; 
00778A318  ldr      x2, [x1, #0x60]
00778A31C  mov      x0, x19
00778A320  ldp      x20, x19, [sp, #0x40]
00778A324  ldp      x22, x21, [sp, #0x30]
00778A328  ldp      x24, x23, [sp, #0x20]
00778A32C  ldp      x26, x25, [sp, #0x10]
00778A330  ldr      x30, [sp], #0x50
00778A334  br       x2
00778A338  ldr      x8, [x0, #0x60]
00778A33C  blr      x8
00778A340  cbz      x0, #0x778a6f8
00778A344  cbz      x19, #0x778a6f8
00778A348  ldr      w8, [x0, #0x6c]
00778A34C  adrp     x24, #0x8f6e000
00778A350  strb     w8, [x19, #0x20]
00778A354  ldr      x24, [x24, #0x4d8] ; GLOBAL HotFix.PunchboardViewModule_TypeInfo @ 0x91ee730
00778A358  ldr      x0, [x24]
00778A35C  ldr      w8, [x0, #0xe0]
00778A360  cbnz     w8, #0x778a36c
00778A364  bl       #0x382be8c ; 
00778A368  ldr      x0, [x24]
00778A36C  ldr      x8, [x0, #0xb8]
00778A370  ldr      x8, [x8]
00778A374  cbz      x8, #0x778a6f8
00778A378  adrp     x25, #0x8fb7000
00778A37C  ldr      x25, [x25, #0x300] ; GLOBAL HotFix.PunchboardViewModule.<>c_TypeInfo @ 0x91fba28
00778A380  ldr      x20, [x8, #0x10]
00778A384  ldr      x0, [x25]
00778A388  ldr      w9, [x0, #0xe0]
00778A38C  cbnz     w9, #0x778a398
00778A390  bl       #0x382be8c ; 
00778A394  ldr      x0, [x25]
00778A398  ldr      x8, [x0, #0xb8]
00778A39C  ldr      x21, [x8, #0x18]
00778A3A0  cbnz     x21, #0x778a3fc
00778A3A4  ldr      w8, [x0, #0xe0]
00778A3A8  cbnz     w8, #0x778a3b4
00778A3AC  bl       #0x382be8c ; 
00778A3B0  ldr      x0, [x25]
00778A3B4  adrp     x9, #0x8fb7000
00778A3B8  ldr      x8, [x0, #0xb8]
00778A3BC  ldr      x9, [x9, #0x408] ; GLOBAL System.Comparison<PunchboardSkillRandomData>_TypeInfo @ 0x91d0e20
00778A3C0  ldr      x22, [x8]
00778A3C4  ldr      x0, [x9]
00778A3C8  bl       #0x382bfa0 ; 
00778A3CC  adrp     x8, #0x8fb7000
00778A3D0  ldr      x8, [x8, #0x418] ; GLOBAL Method$HotFix.PunchboardViewModule.<>c.<DispatchSelectCmd>b__82_0() @ 0x92dcf70
00778A3D4  mov      x1, x22
00778A3D8  mov      x3, xzr
00778A3DC  mov      x21, x0
00778A3E0  ldr      x2, [x8]
00778A3E4  bl       #0x5c896cc ; System.Comparison<PunchboardSkillRandomData>$$.ctor
00778A3E8  ldr      x8, [x25]
00778A3EC  mov      x1, x21
00778A3F0  ldr      x0, [x8, #0xb8]
00778A3F4  str      x21, [x0, #0x18]!
00778A3F8  bl       #0x382bcb8 ; 
00778A3FC  cbz      x20, #0x778a6f8
00778A400  adrp     x8, #0x8fb7000
00778A404  ldr      x8, [x8, #0x410] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Sort() @ 0x921f558
00778A408  mov      x0, x20
00778A40C  mov      x1, x21
00778A410  ldr      x2, [x8]
00778A414  bl       #0x4dd75bc ; System.Collections.Generic.List<PunchboardSkillRandomData>$$Sort
00778A418  ldr      x0, [x24]
00778A41C  ldr      w8, [x0, #0xe0]
00778A420  cbnz     w8, #0x778a42c
00778A424  bl       #0x382be8c ; 
00778A428  ldr      x0, [x24]
00778A42C  ldr      x8, [x0, #0xb8]
00778A430  ldr      x8, [x8]
00778A434  cbz      x8, #0x778a6f8
00778A438  ldr      x1, [x8, #0x10]
00778A43C  mov      x0, x19
00778A440  str      x1, [x0, #0x28]!
00778A444  bl       #0x382bcb8 ; 
00778A448  adrp     x20, #0x8ee1000
00778A44C  ldr      x20, [x20, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
00778A450  ldr      x0, [x20]
00778A454  ldr      w8, [x0, #0xe0]
00778A458  cbnz     w8, #0x778a460
00778A45C  bl       #0x382be8c ; 
00778A460  adrp     x21, #0x9591000
00778A464  ldrb     w8, [x21, #0x5ba]
00778A468  cbnz     w8, #0x778a480
00778A46C  adrp     x0, #0x8ee1000
00778A470  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
00778A474  bl       #0x382bd14 ; 
00778A478  mov      w8, #1
00778A47C  strb     w8, [x21, #0x5ba]
00778A480  ldr      x0, [x20]
00778A484  ldr      w8, [x0, #0xe0]
00778A488  cbnz     w8, #0x778a494
00778A48C  bl       #0x382be8c ; 
00778A490  ldr      x0, [x20]
00778A494  ldr      x8, [x0, #0xb8]
00778A498  mov      w1, #0x98
00778A49C  mov      x2, x19
00778A4A0  mov      x3, xzr
00778A4A4  ldr      x0, [x8, #0x10]
00778A4A8  bl       #0x7270dbc ; HotFix.FrameworkExpand$$DispatchNow
00778A4AC  ldrb     w8, [x23, #0x459]
00778A4B0  cbnz     w8, #0x778a4d4
00778A4B4  adrp     x0, #0x8f6c000
00778A4B8  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
00778A4BC  bl       #0x382bd14 ; 
00778A4C0  adrp     x0, #0x8f6c000
00778A4C4  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00778A4C8  bl       #0x382bd14 ; 
00778A4CC  mov      w8, #1
00778A4D0  strb     w8, [x23, #0x459]
00778A4D4  ldr      x0, [x26]
00778A4D8  ldrb     w8, [x0, #0x53]
00778A4DC  tbnz     w8, #5, #0x778a4f8
00778A4E0  adrp     x8, #0x8f6c000
00778A4E4  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00778A4E8  ldr      x8, [x8]
00778A4EC  ldr      x8, [x8, #0xb8]
00778A4F0  ldr      x0, [x8]
00778A4F4  b        #0x778a500 ; 
00778A4F8  ldr      x8, [x0, #0x60]
00778A4FC  blr      x8
00778A500  cbz      x0, #0x778a6f8
00778A504  mov      x1, xzr
00778A508  bl       #0x704d364 ; HotFix.WorldBattle$$get_IsOnlineBattle
00778A50C  tbnz     w0, #0, #0x778a570
00778A510  ldrb     w8, [x23, #0x459]
00778A514  cbnz     w8, #0x778a538
00778A518  adrp     x0, #0x8f6c000
00778A51C  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
00778A520  bl       #0x382bd14 ; 
00778A524  adrp     x0, #0x8f6c000
00778A528  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00778A52C  bl       #0x382bd14 ; 
00778A530  mov      w8, #1
00778A534  strb     w8, [x23, #0x459]
00778A538  ldr      x0, [x26]
00778A53C  ldrb     w8, [x0, #0x53]
00778A540  tbnz     w8, #5, #0x778a55c
00778A544  adrp     x8, #0x8f6c000
00778A548  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00778A54C  ldr      x8, [x8]
00778A550  ldr      x8, [x8, #0xb8]
00778A554  ldr      x0, [x8]
00778A558  b        #0x778a564 ; 
00778A55C  ldr      x8, [x0, #0x60]
00778A560  blr      x8
00778A564  cbz      x0, #0x778a6f8
00778A568  mov      x1, xzr
00778A56C  bl       #0x704d71c ; HotFix.WorldBattle$$ResetTime
00778A570  ldr      x0, [x24]
00778A574  ldr      w8, [x0, #0xe0]
00778A578  cbnz     w8, #0x778a584
00778A57C  bl       #0x382be8c ; 
00778A580  ldr      x0, [x24]
00778A584  ldr      x8, [x0, #0xb8]
00778A588  ldr      x19, [x8]
00778A58C  cbz      x19, #0x778a6f8
00778A590  ldr      x0, [x25]
00778A594  ldr      x21, [x19, #0x10]
00778A598  ldr      w8, [x0, #0xe0]
00778A59C  cbnz     w8, #0x778a5a8
00778A5A0  bl       #0x382be8c ; 
00778A5A4  ldr      x0, [x25]
00778A5A8  ldr      x8, [x0, #0xb8]
00778A5AC  ldr      x22, [x8, #0x20]
00778A5B0  adrp     x8, #0x8fb7000
00778A5B4  ldr      x8, [x8, #0x428] ; GLOBAL 赌博机 @ 0x932ddc8
00778A5B8  ldr      x20, [x8]
00778A5BC  cbnz     x22, #0x778a618
00778A5C0  ldr      w8, [x0, #0xe0]
00778A5C4  cbnz     w8, #0x778a5d0
00778A5C8  bl       #0x382be8c ; 
00778A5CC  ldr      x0, [x25]
00778A5D0  adrp     x9, #0x8f6e000
00778A5D4  ldr      x8, [x0, #0xb8]
00778A5D8  ldr      x9, [x9, #0x4d0] ; GLOBAL System.Func<PunchboardSkillRandomData, int>_TypeInfo @ 0x91d5e30
00778A5DC  ldr      x23, [x8]
00778A5E0  ldr      x0, [x9]
00778A5E4  bl       #0x382bfa0 ; 
00778A5E8  adrp     x8, #0x8fb7000
00778A5EC  ldr      x8, [x8, #0x420] ; GLOBAL Method$HotFix.PunchboardViewModule.<>c.<DispatchSelectCmd>b__82_1() @ 0x92dcf78
00778A5F0  mov      x1, x23
00778A5F4  mov      x3, xzr
00778A5F8  mov      x22, x0
00778A5FC  ldr      x2, [x8]
00778A600  bl       #0x48d612c ; System.Func<PunchboardSkillRandomData, int>$$.ctor
00778A604  ldr      x8, [x25]
00778A608  mov      x1, x22
00778A60C  ldr      x0, [x8, #0xb8]
00778A610  str      x22, [x0, #0x20]!
00778A614  bl       #0x382bcb8 ; 
00778A618  adrp     x8, #0x8f6e000
00778A61C  ldr      x8, [x8, #0x4c8] ; GLOBAL Method$System.Linq.Enumerable.Select<PunchboardSkillRandomData, int>() @ 0x9265598
00778A620  mov      x0, x21
00778A624  mov      x1, x22
00778A628  ldr      x2, [x8]
00778A62C  bl       #0x45d0bc4 ; System.Linq.Enumerable$$Select<PunchboardSkillRandomData, int>
00778A630  adrp     x8, #0x8f06000
00778A634  ldr      x8, [x8, #0x4a8] ; GLOBAL Method$System.Linq.Enumerable.ToList<int>() @ 0x9265be8
00778A638  ldr      x1, [x8]
00778A63C  bl       #0x45dc05c ; System.Linq.Enumerable$$ToList<int>
00778A640  ldr      x8, [x24]
00778A644  mov      x21, x0
00778A648  ldr      w9, [x8, #0xe0]
00778A64C  cbnz     w9, #0x778a65c
00778A650  mov      x0, x8
00778A654  bl       #0x382be8c ; 
00778A658  ldr      x8, [x24]
00778A65C  ldr      x8, [x8, #0xb8]
00778A660  ldr      x22, [x8]
00778A664  cbz      x22, #0x778a6f8
00778A668  adrp     x23, #0x95a4000
00778A66C  ldrb     w8, [x23, #0x6fb]
00778A670  cbnz     w8, #0x778a688
00778A674  adrp     x0, #0x8f6e000
00778A678  ldr      x0, [x0, #0x510] ; GLOBAL Method$HotFix.PunchboardViewData.get_OwnSkills() @ 0x929ba30
00778A67C  bl       #0x382bd14 ; 
00778A680  mov      w8, #1
00778A684  strb     w8, [x23, #0x6fb]
00778A688  adrp     x8, #0x8f6e000
00778A68C  ldr      x8, [x8, #0x510] ; GLOBAL Method$HotFix.PunchboardViewData.get_OwnSkills() @ 0x929ba30
00778A690  ldr      x1, [x8]
00778A694  ldrb     w8, [x1, #0x53]
00778A698  tbnz     w8, #5, #0x778a6a4
00778A69C  ldr      x22, [x22, #0x40]
00778A6A0  b        #0x778a6b4 ; 
00778A6A4  ldr      x8, [x1, #0x60]
00778A6A8  mov      x0, x22
00778A6AC  blr      x8
00778A6B0  mov      x22, x0
00778A6B4  adrp     x8, #0x8f6b000
00778A6B8  ldr      x8, [x8, #0xbf8] ; GLOBAL HotFix.Tracker_TypeInfo @ 0x91f2b68
00778A6BC  ldr      x0, [x8]
00778A6C0  ldr      w8, [x0, #0xe0]
00778A6C4  cbnz     w8, #0x778a6cc
00778A6C8  bl       #0x382be8c ; 
00778A6CC  mov      x0, x19
00778A6D0  mov      x1, x20
00778A6D4  mov      x2, x21
00778A6D8  mov      x3, x22
00778A6DC  ldp      x20, x19, [sp, #0x40]
00778A6E0  ldp      x22, x21, [sp, #0x30]
00778A6E4  ldp      x24, x23, [sp, #0x20]
00778A6E8  ldp      x26, x25, [sp, #0x10]
00778A6EC  mov      x4, xzr
00778A6F0  ldr      x30, [sp], #0x50
00778A6F4  b        #0x781adf0 ; HotFix.Tracker$$TrackSkillSelect
00778A6F8  bl       #0x382bfb8 ; 

