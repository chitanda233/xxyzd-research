; HotFix.BattleLogic.HeroComponentRandomSkill$$AddSkillSurvior
; RVA 0x686A2AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686A2AC  sub      sp, sp, #0x40
00686A2B0  str      x30, [sp, #0x10]
00686A2B4  stp      x22, x21, [sp, #0x20]
00686A2B8  stp      x20, x19, [sp, #0x30]
00686A2BC  adrp     x21, #0x959b000
00686A2C0  adrp     x22, #0x8f24000
00686A2C4  ldrb     w8, [x21, #0xa40]
00686A2C8  ldr      x22, [x22, #0x48] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.AddSkillSurvior() @ 0x927f968
00686A2CC  mov      x20, x1
00686A2D0  mov      x19, x0
00686A2D4  tbnz     w8, #0, #0x686a31c
00686A2D8  adrp     x0, #0x8f24000
00686A2DC  ldr      x0, [x0, #0x48] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.AddSkillSurvior() @ 0x927f968
00686A2E0  bl       #0x382bd14 ; 
00686A2E4  adrp     x0, #0x8f23000
00686A2E8  ldr      x0, [x0, #0xf98] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.ContainsKey() @ 0x92288c8
00686A2EC  bl       #0x382bd14 ; 
00686A2F0  adrp     x0, #0x8f23000
00686A2F4  ldr      x0, [x0, #0xfa0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.get_Item() @ 0x92288e0
00686A2F8  bl       #0x382bd14 ; 
00686A2FC  adrp     x0, #0x8f23000
00686A300  ldr      x0, [x0, #0xfa8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.set_Item() @ 0x92288e8
00686A304  bl       #0x382bd14 ; 
00686A308  adrp     x0, #0x8f24000
00686A30C  ldr      x0, [x0, #0x50] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.Add() @ 0x9228ca0
00686A310  bl       #0x382bd14 ; 
00686A314  mov      w8, #1
00686A318  strb     w8, [x21, #0xa40]
00686A31C  ldr      x2, [x22]
00686A320  ldrb     w8, [x2, #0x53]
00686A324  tbnz     w8, #5, #0x686a370
00686A328  str      xzr, [sp, #0x18]
00686A32C  str      xzr, [sp, #8]
00686A330  cbz      x20, #0x686a538
00686A334  adrp     x21, #0x9598000
00686A338  ldrb     w8, [x21, #0xde3]
00686A33C  cbnz     w8, #0x686a354
00686A340  adrp     x0, #0x8f00000
00686A344  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
00686A348  bl       #0x382bd14 ; 
00686A34C  mov      w8, #1
00686A350  strb     w8, [x21, #0xde3]
00686A354  adrp     x8, #0x8f00000
00686A358  ldr      x8, [x8, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
00686A35C  ldr      x1, [x8]
00686A360  ldrb     w8, [x1, #0x53]
00686A364  tbnz     w8, #5, #0x686a390
00686A368  ldr      w21, [x20, #0x20]
00686A36C  b        #0x686a3a0 ; 
00686A370  ldr      x3, [x2, #0x60]
00686A374  mov      x0, x19
00686A378  mov      x1, x20
00686A37C  ldp      x20, x19, [sp, #0x30]
00686A380  ldp      x22, x21, [sp, #0x20]
00686A384  ldr      x30, [sp, #0x10]
00686A388  add      sp, sp, #0x40
00686A38C  br       x3
00686A390  ldr      x8, [x1, #0x60]
00686A394  mov      x0, x20
00686A398  blr      x8
00686A39C  mov      w21, w0
00686A3A0  adrp     x22, #0x9598000
00686A3A4  ldrb     w8, [x22, #0x35e]
00686A3A8  cbnz     w8, #0x686a3c0
00686A3AC  adrp     x0, #0x8ef9000
00686A3B0  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
00686A3B4  bl       #0x382bd14 ; 
00686A3B8  mov      w8, #1
00686A3BC  strb     w8, [x22, #0x35e]
00686A3C0  adrp     x8, #0x8ef9000
00686A3C4  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
00686A3C8  ldr      x1, [x8]
00686A3CC  ldrb     w8, [x1, #0x53]
00686A3D0  tbz      w8, #5, #0x686a3e0
00686A3D4  ldr      x8, [x1, #0x60]
00686A3D8  mov      x0, x20
00686A3DC  blr      x8
00686A3E0  ldr      x0, [x19, #0x48]
00686A3E4  cbz      x0, #0x686a538
00686A3E8  adrp     x8, #0x8f23000
00686A3EC  ldr      x8, [x8, #0xf98] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.ContainsKey() @ 0x92288c8
00686A3F0  mov      w1, w21
00686A3F4  ldr      x2, [x8]
00686A3F8  bl       #0x521de14 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$ContainsKey
00686A3FC  tbz      w0, #0, #0x686a450
00686A400  ldr      x0, [x19, #0x48]
00686A404  cbz      x0, #0x686a538
00686A408  adrp     x8, #0x8f23000
00686A40C  ldr      x8, [x8, #0xfa0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.get_Item() @ 0x92288e0
00686A410  mov      w1, w21
00686A414  ldr      x2, [x8]
00686A418  bl       #0x521db48 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$get_Item
00686A41C  add      w8, w0, #1
00686A420  str      x0, [sp, #0x18]
00686A424  str      w8, [sp, #0x18]
00686A428  ldr      x0, [x19, #0x48]
00686A42C  cbz      x0, #0x686a538
00686A430  adrp     x8, #0x8f23000
00686A434  ldr      x2, [sp, #0x18]
00686A438  ldr      x8, [x8, #0xfa8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.set_Item() @ 0x92288e8
00686A43C  mov      w1, w21
00686A440  ldr      x3, [x8]
00686A444  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A448  add      x0, sp, #0x18
00686A44C  b        #0x686a504 ; 
00686A450  adrp     x22, #0x959b000
00686A454  ldrb     w8, [x22, #0xbac]
00686A458  cbnz     w8, #0x686a470
00686A45C  adrp     x0, #0x8f24000
00686A460  ldr      x0, [x0, #0x58] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_MaxCount() @ 0x92ac480
00686A464  bl       #0x382bd14 ; 
00686A468  mov      w8, #1
00686A46C  strb     w8, [x22, #0xbac]
00686A470  adrp     x8, #0x8f24000
00686A474  ldr      x8, [x8, #0x58] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_MaxCount() @ 0x92ac480
00686A478  ldr      x1, [x8]
00686A47C  ldrb     w8, [x1, #0x53]
00686A480  tbnz     w8, #5, #0x686a48c
00686A484  ldr      w0, [x20, #0x64]
00686A488  b        #0x686a498 ; 
00686A48C  ldr      x8, [x1, #0x60]
00686A490  mov      x0, x20
00686A494  blr      x8
00686A498  mov      w2, #1
00686A49C  bfi      x2, x0, #0x20, #0x20
00686A4A0  str      x2, [sp, #8]
00686A4A4  ldr      x0, [x19, #0x48]
00686A4A8  cbz      x0, #0x686a538
00686A4AC  adrp     x8, #0x8f23000
00686A4B0  ldr      x8, [x8, #0xfa8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, HeroSkillCount>.set_Item() @ 0x92288e8
00686A4B4  mov      w1, w21
00686A4B8  ldr      x3, [x8]
00686A4BC  bl       #0x521dbc8 ; Rock.Collections.OrderedDictionary<int, HeroSkillCount>$$set_Item
00686A4C0  adrp     x22, #0x959b000
00686A4C4  ldrb     w8, [x22, #0x9b4]
00686A4C8  cbnz     w8, #0x686a4e0
00686A4CC  adrp     x0, #0x8f23000
00686A4D0  ldr      x0, [x0, #0x90] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillFlag() @ 0x92ac538
00686A4D4  bl       #0x382bd14 ; 
00686A4D8  mov      w8, #1
00686A4DC  strb     w8, [x22, #0x9b4]
00686A4E0  adrp     x8, #0x8f23000
00686A4E4  ldr      x8, [x8, #0x90] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillFlag() @ 0x92ac538
00686A4E8  ldr      x1, [x8]
00686A4EC  ldrb     w8, [x1, #0x53]
00686A4F0  tbz      w8, #5, #0x686a500
00686A4F4  ldr      x8, [x1, #0x60]
00686A4F8  mov      x0, x20
00686A4FC  blr      x8
00686A500  add      x0, sp, #8
00686A504  bl       #0x6866604 ; HotFix.BattleLogic.HeroSkillCount$$IsMax
00686A508  ldr      x0, [x19, #0x50]
00686A50C  cbz      x0, #0x686a538
00686A510  adrp     x8, #0x8f24000
00686A514  ldr      x8, [x8, #0x50] ; GLOBAL Method$Rock.Collections.OrderedHashSet<int>.Add() @ 0x9228ca0
00686A518  mov      w1, w21
00686A51C  ldr      x2, [x8]
00686A520  bl       #0x524e0bc ; Rock.Collections.OrderedHashSet<int>$$Add
00686A524  ldp      x20, x19, [sp, #0x30]
00686A528  ldp      x22, x21, [sp, #0x20]
00686A52C  ldr      x30, [sp, #0x10]
00686A530  add      sp, sp, #0x40
00686A534  ret      
00686A538  bl       #0x382bfb8 ; 

