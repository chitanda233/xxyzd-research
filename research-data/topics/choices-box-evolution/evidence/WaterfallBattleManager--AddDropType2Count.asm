; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
; RVA 0x65D3844; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D3844  str      x30, [sp, #-0x40]!
0065D3848  stp      x24, x23, [sp, #0x10]
0065D384C  stp      x22, x21, [sp, #0x20]
0065D3850  stp      x20, x19, [sp, #0x30]
0065D3854  adrp     x22, #0x9599000
0065D3858  adrp     x24, #0x8f0a000
0065D385C  ldrb     w8, [x22, #0x58b]
0065D3860  ldr      x24, [x24, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.AddDropType2Count() @ 0x92c7fd8
0065D3864  mov      w19, w3
0065D3868  mov      w23, w2
0065D386C  mov      x21, x1
0065D3870  mov      x20, x0
0065D3874  tbnz     w8, #0, #0x65d38b0
0065D3878  adrp     x0, #0x8f0a000
0065D387C  ldr      x0, [x0, #0x9b8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, int>.ContainsKey() @ 0x9228920
0065D3880  bl       #0x382bd14 ; 
0065D3884  adrp     x0, #0x8f09000
0065D3888  ldr      x0, [x0, #0xa20] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, int>.get_Item() @ 0x9228948
0065D388C  bl       #0x382bd14 ; 
0065D3890  adrp     x0, #0x8f09000
0065D3894  ldr      x0, [x0, #0xa08] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, int>.set_Item() @ 0x9228950
0065D3898  bl       #0x382bd14 ; 
0065D389C  adrp     x0, #0x8f0a000
0065D38A0  ldr      x0, [x0, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.AddDropType2Count() @ 0x92c7fd8
0065D38A4  bl       #0x382bd14 ; 
0065D38A8  mov      w8, #1
0065D38AC  strb     w8, [x22, #0x58b]
0065D38B0  ldr      x4, [x24]
0065D38B4  ldrb     w8, [x4, #0x53]
0065D38B8  tbnz     w8, #5, #0x65d3900
0065D38BC  cbz      x21, #0x65d3a74
0065D38C0  adrp     x22, #0x9599000
0065D38C4  ldrb     w8, [x22, #0x4ec]
0065D38C8  cbnz     w8, #0x65d38e0
0065D38CC  adrp     x0, #0x8f09000
0065D38D0  ldr      x0, [x0, #0xfc8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_MonsterDropType() @ 0x924f770
0065D38D4  bl       #0x382bd14 ; 
0065D38D8  mov      w8, #1
0065D38DC  strb     w8, [x22, #0x4ec]
0065D38E0  adrp     x8, #0x8f09000
0065D38E4  ldr      x8, [x8, #0xfc8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_MonsterDropType() @ 0x924f770
0065D38E8  ldr      x1, [x8]
0065D38EC  ldrb     w8, [x1, #0x53]
0065D38F0  tbnz     w8, #5, #0x65d3928
0065D38F4  ldr      w22, [x21, #0x268]
0065D38F8  cbnz     w22, #0x65d393c
0065D38FC  b        #0x65d3a60 ; 
0065D3900  ldr      x5, [x4, #0x60]
0065D3904  and      w2, w23, #1
0065D3908  mov      x0, x20
0065D390C  mov      x1, x21
0065D3910  mov      w3, w19
0065D3914  ldp      x20, x19, [sp, #0x30]
0065D3918  ldp      x22, x21, [sp, #0x20]
0065D391C  ldp      x24, x23, [sp, #0x10]
0065D3920  ldr      x30, [sp], #0x40
0065D3924  br       x5
0065D3928  ldr      x8, [x1, #0x60]
0065D392C  mov      x0, x21
0065D3930  blr      x8
0065D3934  mov      w22, w0
0065D3938  cbz      w22, #0x65d3a60
0065D393C  tbz      w23, #0, #0x65d39d4
0065D3940  adrp     x23, #0x9591000
0065D3944  ldrb     w8, [x23, #0xa75]
0065D3948  cbnz     w8, #0x65d3960
0065D394C  adrp     x0, #0x8ee6000
0065D3950  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
0065D3954  bl       #0x382bd14 ; 
0065D3958  mov      w8, #1
0065D395C  strb     w8, [x23, #0xa75]
0065D3960  adrp     x24, #0x8ee6000
0065D3964  ldr      x24, [x24, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
0065D3968  ldr      x1, [x24]
0065D396C  ldrb     w8, [x1, #0x53]
0065D3970  tbnz     w8, #5, #0x65d397c
0065D3974  ldr      w0, [x21, #0x24]
0065D3978  b        #0x65d3988 ; 
0065D397C  ldr      x8, [x1, #0x60]
0065D3980  mov      x0, x21
0065D3984  blr      x8
0065D3988  cmp      w0, #0xc9
0065D398C  b.eq     #0x65d39d4
0065D3990  ldrb     w8, [x23, #0xa75]
0065D3994  cbnz     w8, #0x65d39ac
0065D3998  adrp     x0, #0x8ee6000
0065D399C  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
0065D39A0  bl       #0x382bd14 ; 
0065D39A4  mov      w8, #1
0065D39A8  strb     w8, [x23, #0xa75]
0065D39AC  ldr      x1, [x24]
0065D39B0  ldrb     w8, [x1, #0x53]
0065D39B4  tbnz     w8, #5, #0x65d39c0
0065D39B8  ldr      w0, [x21, #0x24]
0065D39BC  b        #0x65d39cc ; 
0065D39C0  ldr      x8, [x1, #0x60]
0065D39C4  mov      x0, x21
0065D39C8  blr      x8
0065D39CC  cmp      w0, #3
0065D39D0  b.ne     #0x65d3a60
0065D39D4  ldr      x0, [x20, #0x168]
0065D39D8  cbz      x0, #0x65d3a74
0065D39DC  adrp     x8, #0x8f0a000
0065D39E0  ldr      x8, [x8, #0x9b8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, int>.ContainsKey() @ 0x9228920
0065D39E4  mov      w1, w22
0065D39E8  ldr      x2, [x8]
0065D39EC  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
0065D39F0  tbnz     w0, #0, #0x65d3a14
0065D39F4  ldr      x0, [x20, #0x168]
0065D39F8  cbz      x0, #0x65d3a74
0065D39FC  adrp     x8, #0x8f09000
0065D3A00  ldr      x8, [x8, #0xa08] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, int>.set_Item() @ 0x9228950
0065D3A04  mov      w1, w22
0065D3A08  mov      w2, wzr
0065D3A0C  ldr      x3, [x8]
0065D3A10  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
0065D3A14  ldr      x20, [x20, #0x168]
0065D3A18  cbz      x20, #0x65d3a74
0065D3A1C  adrp     x8, #0x8f09000
0065D3A20  ldr      x8, [x8, #0xa20] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, int>.get_Item() @ 0x9228948
0065D3A24  mov      x0, x20
0065D3A28  mov      w1, w22
0065D3A2C  ldr      x2, [x8]
0065D3A30  bl       #0x5221c50 ; Rock.Collections.OrderedDictionary<int, int>$$get_Item
0065D3A34  adrp     x8, #0x8f09000
0065D3A38  ldr      x8, [x8, #0xa08] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, int>.set_Item() @ 0x9228950
0065D3A3C  add      w2, w0, w19
0065D3A40  mov      x0, x20
0065D3A44  mov      w1, w22
0065D3A48  ldr      x3, [x8]
0065D3A4C  ldp      x20, x19, [sp, #0x30]
0065D3A50  ldp      x22, x21, [sp, #0x20]
0065D3A54  ldp      x24, x23, [sp, #0x10]
0065D3A58  ldr      x30, [sp], #0x40
0065D3A5C  b        #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
0065D3A60  ldp      x20, x19, [sp, #0x30]
0065D3A64  ldp      x22, x21, [sp, #0x20]
0065D3A68  ldp      x24, x23, [sp, #0x10]
0065D3A6C  ldr      x30, [sp], #0x40
0065D3A70  ret      
0065D3A74  bl       #0x382bfb8 ; 

