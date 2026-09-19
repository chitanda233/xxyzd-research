; HotFix.BattleLogic.BaseEndState$$OnUpdate
; RVA 0x659A1CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659A1CC  str      x30, [sp, #-0x40]!
00659A1D0  stp      x24, x23, [sp, #0x10]
00659A1D4  stp      x22, x21, [sp, #0x20]
00659A1D8  stp      x20, x19, [sp, #0x30]
00659A1DC  adrp     x21, #0x9599000
00659A1E0  adrp     x22, #0x8f08000
00659A1E4  ldrb     w8, [x21, #0x300]
00659A1E8  ldr      x22, [x22, #0xd90] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.OnUpdate() @ 0x923b108
00659A1EC  mov      x20, x1
00659A1F0  mov      x19, x0
00659A1F4  tbnz     w8, #0, #0x659a218
00659A1F8  adrp     x0, #0x8f08000
00659A1FC  ldr      x0, [x0, #0xd90] ; GLOBAL Method$HotFix.BattleLogic.BaseEndState.OnUpdate() @ 0x923b108
00659A200  bl       #0x382bd14 ; 
00659A204  adrp     x0, #0x8f08000
00659A208  ldr      x0, [x0, #0x9d8] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.OnUpdate() @ 0x922db18
00659A20C  bl       #0x382bd14 ; 
00659A210  mov      w8, #1
00659A214  strb     w8, [x21, #0x300]
00659A218  ldr      x2, [x22]
00659A21C  ldrb     w8, [x2, #0x53]
00659A220  tbnz     w8, #5, #0x659a2a0
00659A224  ldr      x0, [x19, #0x20]
00659A228  cbz      x0, #0x659a6dc
00659A22C  adrp     x8, #0x8f08000
00659A230  ldr      x8, [x8, #0x9d8] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.OnUpdate() @ 0x922db18
00659A234  mov      x1, x20
00659A238  ldr      x2, [x8]
00659A23C  bl       #0x556fda4 ; HotFix.Common.TaskQueue<FP>$$OnUpdate
00659A240  ldr      w8, [x19, #0x28]
00659A244  cmp      w8, #3
00659A248  b.hi     #0x659a6c8
00659A24C  adrp     x9, #0x1a71000
00659A250  add      x9, x9, #0xfa9
00659A254  adr      x10, #0x659a264
00659A258  ldrb     w11, [x9, x8]
00659A25C  add      x10, x10, x11, lsl #2
00659A260  br       x10
00659A264  adrp     x21, #0x9599000
00659A268  ldrb     w8, [x21, #0x4b1]
00659A26C  cbnz     w8, #0x659a284
00659A270  adrp     x0, #0x8f08000
00659A274  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A278  bl       #0x382bd14 ; 
00659A27C  mov      w8, #1
00659A280  strb     w8, [x21, #0x4b1]
00659A284  adrp     x23, #0x8f08000
00659A288  ldr      x23, [x23, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A28C  ldr      x1, [x23]
00659A290  ldrb     w8, [x1, #0x53]
00659A294  tbnz     w8, #5, #0x659a390
00659A298  ldr      x20, [x19, #0x10]
00659A29C  b        #0x659a3a0 ; 
00659A2A0  ldr      x3, [x2, #0x60]
00659A2A4  mov      x0, x19
00659A2A8  mov      x1, x20
00659A2AC  ldp      x20, x19, [sp, #0x30]
00659A2B0  ldp      x22, x21, [sp, #0x20]
00659A2B4  ldp      x24, x23, [sp, #0x10]
00659A2B8  ldr      x30, [sp], #0x40
00659A2BC  br       x3
00659A2C0  adrp     x21, #0x9599000
00659A2C4  ldrb     w8, [x21, #0x4b1]
00659A2C8  cbnz     w8, #0x659a2e0
00659A2CC  adrp     x0, #0x8f08000
00659A2D0  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A2D4  bl       #0x382bd14 ; 
00659A2D8  mov      w8, #1
00659A2DC  strb     w8, [x21, #0x4b1]
00659A2E0  adrp     x23, #0x8f08000
00659A2E4  ldr      x23, [x23, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A2E8  ldr      x1, [x23]
00659A2EC  ldrb     w8, [x1, #0x53]
00659A2F0  tbnz     w8, #5, #0x659a3e0
00659A2F4  ldr      x20, [x19, #0x10]
00659A2F8  b        #0x659a3f0 ; 
00659A2FC  ldr      x20, [x19, #0x30]
00659A300  cbz      x20, #0x659a6c8
00659A304  adrp     x21, #0x9599000
00659A308  ldrb     w8, [x21, #0x4b3]
00659A30C  cbnz     w8, #0x659a324
00659A310  adrp     x0, #0x8f08000
00659A314  ldr      x0, [x0, #0xd98] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentBattleEnd.get_Stage() @ 0x927f748
00659A318  bl       #0x382bd14 ; 
00659A31C  mov      w8, #1
00659A320  strb     w8, [x21, #0x4b3]
00659A324  adrp     x8, #0x8f08000
00659A328  ldr      x8, [x8, #0xd98] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentBattleEnd.get_Stage() @ 0x927f748
00659A32C  ldr      x1, [x8]
00659A330  ldrb     w8, [x1, #0x53]
00659A334  tbnz     w8, #5, #0x659a544
00659A338  ldr      w0, [x20, #0xd8]
00659A33C  b        #0x659a550 ; 
00659A340  ldr      x0, [x19, #0x18]
00659A344  cbz      x0, #0x659a6dc
00659A348  mov      w1, wzr
00659A34C  mov      x2, xzr
00659A350  bl       #0x687d3f4 ; HotFix.BattleLogic.EntityHeroNormal$$set_DisableMoveInput
00659A354  adrp     x20, #0x9599000
00659A358  ldrb     w8, [x20, #0x4b1]
00659A35C  cbnz     w8, #0x659a374
00659A360  adrp     x0, #0x8f08000
00659A364  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A368  bl       #0x382bd14 ; 
00659A36C  mov      w8, #1
00659A370  strb     w8, [x20, #0x4b1]
00659A374  adrp     x8, #0x8f08000
00659A378  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A37C  ldr      x1, [x8]
00659A380  ldrb     w8, [x1, #0x53]
00659A384  tbnz     w8, #5, #0x659a430
00659A388  ldr      x20, [x19, #0x10]
00659A38C  b        #0x659a440 ; 
00659A390  ldr      x8, [x1, #0x60]
00659A394  mov      x0, x19
00659A398  blr      x8
00659A39C  mov      x20, x0
00659A3A0  cbz      x20, #0x659a6dc
00659A3A4  adrp     x22, #0x9599000
00659A3A8  ldrb     w8, [x22, #0x287]
00659A3AC  cbnz     w8, #0x659a3c4
00659A3B0  adrp     x0, #0x8f07000
00659A3B4  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00659A3B8  bl       #0x382bd14 ; 
00659A3BC  mov      w8, #1
00659A3C0  strb     w8, [x22, #0x287]
00659A3C4  adrp     x24, #0x8f07000
00659A3C8  ldr      x24, [x24, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00659A3CC  ldr      x1, [x24]
00659A3D0  ldrb     w8, [x1, #0x53]
00659A3D4  tbnz     w8, #5, #0x659a480
00659A3D8  ldr      x0, [x20, #0x350]
00659A3DC  b        #0x659a48c ; 
00659A3E0  ldr      x8, [x1, #0x60]
00659A3E4  mov      x0, x19
00659A3E8  blr      x8
00659A3EC  mov      x20, x0
00659A3F0  cbz      x20, #0x659a6dc
00659A3F4  adrp     x22, #0x9599000
00659A3F8  ldrb     w8, [x22, #0x287]
00659A3FC  cbnz     w8, #0x659a414
00659A400  adrp     x0, #0x8f07000
00659A404  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00659A408  bl       #0x382bd14 ; 
00659A40C  mov      w8, #1
00659A410  strb     w8, [x22, #0x287]
00659A414  adrp     x24, #0x8f07000
00659A418  ldr      x24, [x24, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00659A41C  ldr      x1, [x24]
00659A420  ldrb     w8, [x1, #0x53]
00659A424  tbnz     w8, #5, #0x659a4cc
00659A428  ldr      x0, [x20, #0x350]
00659A42C  b        #0x659a4d8 ; 
00659A430  ldr      x8, [x1, #0x60]
00659A434  mov      x0, x19
00659A438  blr      x8
00659A43C  mov      x20, x0
00659A440  cbz      x20, #0x659a6dc
00659A444  adrp     x21, #0x9598000
00659A448  ldrb     w8, [x21, #0xfc4]
00659A44C  cbnz     w8, #0x659a464
00659A450  adrp     x0, #0x8f05000
00659A454  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659A458  bl       #0x382bd14 ; 
00659A45C  mov      w8, #1
00659A460  strb     w8, [x21, #0xfc4]
00659A464  adrp     x8, #0x8f05000
00659A468  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659A46C  ldr      x1, [x8]
00659A470  ldrb     w8, [x1, #0x53]
00659A474  tbnz     w8, #5, #0x659a518
00659A478  ldr      x0, [x20, #0x220]
00659A47C  b        #0x659a524 ; 
00659A480  ldr      x8, [x1, #0x60]
00659A484  mov      x0, x20
00659A488  blr      x8
00659A48C  cbz      x0, #0x659a6dc
00659A490  mov      x1, xzr
00659A494  bl       #0x666fea8 ; HotFix.BattleLogic.DropMgr$$HasEquip
00659A498  tbnz     w0, #0, #0x659a604
00659A49C  ldrb     w8, [x21, #0x4b1]
00659A4A0  cbnz     w8, #0x659a4b8
00659A4A4  adrp     x0, #0x8f08000
00659A4A8  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A4AC  bl       #0x382bd14 ; 
00659A4B0  mov      w8, #1
00659A4B4  strb     w8, [x21, #0x4b1]
00659A4B8  ldr      x1, [x23]
00659A4BC  ldrb     w8, [x1, #0x53]
00659A4C0  tbnz     w8, #5, #0x659a560
00659A4C4  ldr      x20, [x19, #0x10]
00659A4C8  b        #0x659a570 ; 
00659A4CC  ldr      x8, [x1, #0x60]
00659A4D0  mov      x0, x20
00659A4D4  blr      x8
00659A4D8  cbz      x0, #0x659a6dc
00659A4DC  mov      x1, xzr
00659A4E0  bl       #0x666fdd0 ; HotFix.BattleLogic.DropMgr$$EquipIsClear
00659A4E4  tbz      w0, #0, #0x659a6c8
00659A4E8  ldrb     w8, [x21, #0x4b1]
00659A4EC  cbnz     w8, #0x659a504
00659A4F0  adrp     x0, #0x8f08000
00659A4F4  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A4F8  bl       #0x382bd14 ; 
00659A4FC  mov      w8, #1
00659A500  strb     w8, [x21, #0x4b1]
00659A504  ldr      x1, [x23]
00659A508  ldrb     w8, [x1, #0x53]
00659A50C  tbnz     w8, #5, #0x659a5a4
00659A510  ldr      x20, [x19, #0x10]
00659A514  b        #0x659a5b4 ; 
00659A518  ldr      x8, [x1, #0x60]
00659A51C  mov      x0, x20
00659A520  blr      x8
00659A524  cbz      x0, #0x659a6dc
00659A528  ldr      x8, [x0]
00659A52C  mov      w1, #1
00659A530  ldr      x9, [x8, #0x258]
00659A534  ldr      x2, [x8, #0x260]
00659A538  blr      x9
00659A53C  mov      w8, #4
00659A540  b        #0x659a6c4 ; 
00659A544  ldr      x8, [x1, #0x60]
00659A548  mov      x0, x20
00659A54C  blr      x8
00659A550  cmp      w0, #5
00659A554  b.ne     #0x659a6c8
00659A558  mov      w8, #3
00659A55C  b        #0x659a6c4 ; 
00659A560  ldr      x8, [x1, #0x60]
00659A564  mov      x0, x19
00659A568  blr      x8
00659A56C  mov      x20, x0
00659A570  cbz      x20, #0x659a6dc
00659A574  ldrb     w8, [x22, #0x287]
00659A578  cbnz     w8, #0x659a590
00659A57C  adrp     x0, #0x8f07000
00659A580  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00659A584  bl       #0x382bd14 ; 
00659A588  mov      w8, #1
00659A58C  strb     w8, [x22, #0x287]
00659A590  ldr      x1, [x24]
00659A594  ldrb     w8, [x1, #0x53]
00659A598  tbnz     w8, #5, #0x659a5e8
00659A59C  ldr      x0, [x20, #0x350]
00659A5A0  b        #0x659a5f4 ; 
00659A5A4  ldr      x8, [x1, #0x60]
00659A5A8  mov      x0, x19
00659A5AC  blr      x8
00659A5B0  mov      x20, x0
00659A5B4  cbz      x20, #0x659a6dc
00659A5B8  ldrb     w8, [x22, #0x287]
00659A5BC  cbnz     w8, #0x659a5d4
00659A5C0  adrp     x0, #0x8f07000
00659A5C4  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00659A5C8  bl       #0x382bd14 ; 
00659A5CC  mov      w8, #1
00659A5D0  strb     w8, [x22, #0x287]
00659A5D4  ldr      x1, [x24]
00659A5D8  ldrb     w8, [x1, #0x53]
00659A5DC  tbnz     w8, #5, #0x659a6a4
00659A5E0  ldr      x0, [x20, #0x350]
00659A5E4  b        #0x659a6b0 ; 
00659A5E8  ldr      x8, [x1, #0x60]
00659A5EC  mov      x0, x20
00659A5F0  blr      x8
00659A5F4  cbz      x0, #0x659a6dc
00659A5F8  mov      x1, xzr
00659A5FC  bl       #0x666fd64 ; HotFix.BattleLogic.DropMgr$$HaveDropExp
00659A600  tbz      w0, #0, #0x659a6c0
00659A604  mov      w20, #1
00659A608  str      w20, [x19, #0x28]
00659A60C  ldrb     w8, [x21, #0x4b1]
00659A610  cbnz     w8, #0x659a624
00659A614  adrp     x0, #0x8f08000
00659A618  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659A61C  bl       #0x382bd14 ; 
00659A620  strb     w20, [x21, #0x4b1]
00659A624  ldr      x1, [x23]
00659A628  ldrb     w8, [x1, #0x53]
00659A62C  tbnz     w8, #5, #0x659a638
00659A630  ldr      x19, [x19, #0x10]
00659A634  b        #0x659a648 ; 
00659A638  ldr      x8, [x1, #0x60]
00659A63C  mov      x0, x19
00659A640  blr      x8
00659A644  mov      x19, x0
00659A648  cbz      x19, #0x659a6dc
00659A64C  ldrb     w8, [x22, #0x287]
00659A650  cbnz     w8, #0x659a668
00659A654  adrp     x0, #0x8f07000
00659A658  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
00659A65C  bl       #0x382bd14 ; 
00659A660  mov      w8, #1
00659A664  strb     w8, [x22, #0x287]
00659A668  ldr      x1, [x24]
00659A66C  ldrb     w8, [x1, #0x53]
00659A670  tbnz     w8, #5, #0x659a67c
00659A674  ldr      x0, [x19, #0x350]
00659A678  b        #0x659a688 ; 
00659A67C  ldr      x8, [x1, #0x60]
00659A680  mov      x0, x19
00659A684  blr      x8
00659A688  cbz      x0, #0x659a6dc
00659A68C  ldp      x20, x19, [sp, #0x30]
00659A690  ldp      x22, x21, [sp, #0x20]
00659A694  ldp      x24, x23, [sp, #0x10]
00659A698  mov      x1, xzr
00659A69C  ldr      x30, [sp], #0x40
00659A6A0  b        #0x666ff78 ; HotFix.BattleLogic.DropMgr$$AbsorbAll
00659A6A4  ldr      x8, [x1, #0x60]
00659A6A8  mov      x0, x20
00659A6AC  blr      x8
00659A6B0  cbz      x0, #0x659a6dc
00659A6B4  mov      x1, xzr
00659A6B8  bl       #0x666fe3c ; HotFix.BattleLogic.DropMgr$$ExpIsClear
00659A6BC  tbz      w0, #0, #0x659a6c8
00659A6C0  mov      w8, #2
00659A6C4  str      w8, [x19, #0x28]
00659A6C8  ldp      x20, x19, [sp, #0x30]
00659A6CC  ldp      x22, x21, [sp, #0x20]
00659A6D0  ldp      x24, x23, [sp, #0x10]
00659A6D4  ldr      x30, [sp], #0x40
00659A6D8  ret      
00659A6DC  bl       #0x382bfb8 ; 

