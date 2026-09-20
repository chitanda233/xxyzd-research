; HotFix.BattleLogic.SinglePlayerSkillCreator$$GetInginiteSkill
; RVA 0x68606EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068606EC  stp      x30, x27, [sp, #-0x50]!
0068606F0  stp      x26, x25, [sp, #0x10]
0068606F4  stp      x24, x23, [sp, #0x20]
0068606F8  stp      x22, x21, [sp, #0x30]
0068606FC  stp      x20, x19, [sp, #0x40]
006860700  adrp     x23, #0x959b000
006860704  adrp     x24, #0x8f23000
006860708  ldrb     w8, [x23, #0xab4]
00686070C  ldr      x24, [x24, #0xc68] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.GetInginiteSkill() @ 0x92aa968
006860710  mov      w19, w3
006860714  mov      x20, x2
006860718  mov      x22, x1
00686071C  mov      x21, x0
006860720  tbnz     w8, #0, #0x6860780
006860724  adrp     x0, #0x8ec2000
006860728  ldr      x0, [x0, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
00686072C  bl       #0x382bd14 ; 
006860730  adrp     x0, #0x8ec2000
006860734  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.List<int>.Clear() @ 0x921de58
006860738  bl       #0x382bd14 ; 
00686073C  adrp     x0, #0x8ec2000
006860740  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006860744  bl       #0x382bd14 ; 
006860748  adrp     x0, #0x8ec2000
00686074C  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006860750  bl       #0x382bd14 ; 
006860754  adrp     x0, #0x8f23000
006860758  ldr      x0, [x0, #0xc68] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.GetInginiteSkill() @ 0x92aa968
00686075C  bl       #0x382bd14 ; 
006860760  adrp     x0, #0x8f08000
006860764  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006860768  bl       #0x382bd14 ; 
00686076C  adrp     x0, #0x8f08000
006860770  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006860774  bl       #0x382bd14 ; 
006860778  mov      w8, #1
00686077C  strb     w8, [x23, #0xab4]
006860780  ldr      x4, [x24]
006860784  ldrb     w8, [x4, #0x53]
006860788  tbnz     w8, #5, #0x68607d8
00686078C  mov      x0, x21
006860790  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860794  cbz      x0, #0x6860974
006860798  adrp     x24, #0x9591000
00686079C  ldrb     w8, [x24, #0xa90]
0068607A0  mov      x23, x0
0068607A4  cbnz     w8, #0x68607bc
0068607A8  adrp     x0, #0x8ee6000
0068607AC  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0068607B0  bl       #0x382bd14 ; 
0068607B4  mov      w8, #1
0068607B8  strb     w8, [x24, #0xa90]
0068607BC  adrp     x25, #0x8ee6000
0068607C0  ldr      x25, [x25, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0068607C4  ldr      x1, [x25]
0068607C8  ldrb     w8, [x1, #0x53]
0068607CC  tbnz     w8, #5, #0x6860804
0068607D0  ldr      x0, [x23, #0x230]
0068607D4  b        #0x6860810 ; 
0068607D8  ldr      x5, [x4, #0x60]
0068607DC  mov      x0, x21
0068607E0  mov      x1, x22
0068607E4  mov      x2, x20
0068607E8  mov      w3, w19
0068607EC  ldp      x20, x19, [sp, #0x40]
0068607F0  ldp      x22, x21, [sp, #0x30]
0068607F4  ldp      x24, x23, [sp, #0x20]
0068607F8  ldp      x26, x25, [sp, #0x10]
0068607FC  ldp      x30, x27, [sp], #0x50
006860800  br       x5
006860804  ldr      x8, [x1, #0x60]
006860808  mov      x0, x23
00686080C  blr      x8
006860810  cbz      x0, #0x6860974
006860814  adrp     x8, #0x8f08000
006860818  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00686081C  ldr      x1, [x8]
006860820  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006860824  mov      x23, x0
006860828  mov      x0, x21
00686082C  mov      x1, x23
006860830  mov      x2, x20
006860834  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
006860838  cmp      w19, #1
00686083C  b.lt     #0x68608fc
006860840  adrp     x26, #0x8ec2000
006860844  adrp     x27, #0x8ec2000
006860848  ldr      x26, [x26, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00686084C  ldr      x27, [x27, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006860850  ldr      x2, [x21, #0x68]
006860854  cbz      x2, #0x6860974
006860858  ldr      w8, [x2, #0x1c]
00686085C  add      w8, w8, #1
006860860  stp      wzr, w8, [x2, #0x18]
006860864  ldr      x0, [x21, #0x40]
006860868  cbz      x0, #0x6860974
00686086C  mov      w1, #1
006860870  mov      x3, x20
006860874  mov      x4, x23
006860878  mov      x5, xzr
00686087C  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
006860880  ldr      x0, [x21, #0x68]
006860884  cbz      x0, #0x6860974
006860888  ldr      w8, [x0, #0x18]
00686088C  cbz      w8, #0x68608fc
006860890  ldr      x2, [x26]
006860894  mov      w1, wzr
006860898  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00686089C  cbz      x22, #0x6860974
0068608A0  ldr      w10, [x22, #0x1c]
0068608A4  ldr      x8, [x22, #0x10]
0068608A8  ldr      x9, [x27]
0068608AC  add      w10, w10, #1
0068608B0  str      w10, [x22, #0x1c]
0068608B4  cbz      x8, #0x6860974
0068608B8  ldrsw    x10, [x22, #0x18]
0068608BC  ldr      w11, [x8, #0x18]
0068608C0  mov      w1, w0
0068608C4  cmp      w10, w11
0068608C8  b.hs     #0x68608e0
0068608CC  add      w9, w10, #1
0068608D0  add      x8, x8, x10, lsl #2
0068608D4  str      w9, [x22, #0x18]
0068608D8  str      w1, [x8, #0x20]
0068608DC  b        #0x68608f4 ; 
0068608E0  ldr      x8, [x9, #0x20]
0068608E4  mov      x0, x22
0068608E8  ldr      x8, [x8, #0xc0]
0068608EC  ldr      x2, [x8, #0x70]
0068608F0  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0068608F4  subs     w19, w19, #1
0068608F8  b.ne     #0x6860850
0068608FC  mov      x0, x21
006860900  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860904  cbz      x0, #0x6860974
006860908  ldrb     w8, [x24, #0xa90]
00686090C  mov      x19, x0
006860910  cbnz     w8, #0x6860928
006860914  adrp     x0, #0x8ee6000
006860918  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00686091C  bl       #0x382bd14 ; 
006860920  mov      w8, #1
006860924  strb     w8, [x24, #0xa90]
006860928  ldr      x1, [x25]
00686092C  ldrb     w8, [x1, #0x53]
006860930  tbnz     w8, #5, #0x686093c
006860934  ldr      x0, [x19, #0x230]
006860938  b        #0x6860948 ; 
00686093C  ldr      x8, [x1, #0x60]
006860940  mov      x0, x19
006860944  blr      x8
006860948  cbz      x0, #0x6860974
00686094C  adrp     x8, #0x8f08000
006860950  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006860954  mov      x1, x23
006860958  ldp      x20, x19, [sp, #0x40]
00686095C  ldp      x22, x21, [sp, #0x30]
006860960  ldr      x2, [x8]
006860964  ldp      x24, x23, [sp, #0x20]
006860968  ldp      x26, x25, [sp, #0x10]
00686096C  ldp      x30, x27, [sp], #0x50
006860970  b        #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
006860974  bl       #0x382bfb8 ; 

