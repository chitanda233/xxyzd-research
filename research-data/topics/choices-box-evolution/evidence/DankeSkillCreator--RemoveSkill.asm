; HotFix.BattleLogic.DankeSkillCreator$$RemoveSkill
; RVA 0x6860F1C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006860F1C  sub      sp, sp, #0xa0
006860F20  stp      x29, x30, [sp, #0x40]
006860F24  stp      x28, x27, [sp, #0x50]
006860F28  stp      x26, x25, [sp, #0x60]
006860F2C  stp      x24, x23, [sp, #0x70]
006860F30  stp      x22, x21, [sp, #0x80]
006860F34  stp      x20, x19, [sp, #0x90]
006860F38  adrp     x20, #0x959b000
006860F3C  adrp     x23, #0x8f23000
006860F40  ldrb     w8, [x20, #0x9f7]
006860F44  ldr      x23, [x23, #0xca0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.RemoveSkill() @ 0x9259de8
006860F48  mov      x21, x2
006860F4C  mov      x22, x1
006860F50  mov      x19, x0
006860F54  tbnz     w8, #0, #0x6860fcc
006860F58  adrp     x0, #0x8f23000
006860F5C  ldr      x0, [x0, #0xca0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.RemoveSkill() @ 0x9259de8
006860F60  bl       #0x382bd14 ; 
006860F64  adrp     x0, #0x8f09000
006860F68  ldr      x0, [x0, #0x238] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.GetEnumerator() @ 0x920b060
006860F6C  bl       #0x382bd14 ; 
006860F70  adrp     x0, #0x8f09000
006860F74  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006860F78  bl       #0x382bd14 ; 
006860F7C  adrp     x0, #0x8f09000
006860F80  ldr      x0, [x0, #0x258] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.MoveNext() @ 0x9214798
006860F84  bl       #0x382bd14 ; 
006860F88  adrp     x0, #0x8f09000
006860F8C  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.get_Current() @ 0x92147a0
006860F90  bl       #0x382bd14 ; 
006860F94  adrp     x0, #0x8ee6000
006860F98  ldr      x0, [x0, #0xf00] ; GLOBAL Method$System.Collections.Generic.KeyValuePair<int, int>.get_Key() @ 0x9217b08
006860F9C  bl       #0x382bd14 ; 
006860FA0  adrp     x0, #0x8ee6000
006860FA4  ldr      x0, [x0, #0xf08] ; GLOBAL Method$System.Collections.Generic.KeyValuePair<int, int>.get_Value() @ 0x9217b10
006860FA8  bl       #0x382bd14 ; 
006860FAC  adrp     x0, #0x8f23000
006860FB0  ldr      x0, [x0, #0xca8] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Get<int, int>() @ 0x92cfb30
006860FB4  bl       #0x382bd14 ; 
006860FB8  adrp     x0, #0x8f23000
006860FBC  ldr      x0, [x0, #0xcb0] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Push<int, int>() @ 0x92cfb40
006860FC0  bl       #0x382bd14 ; 
006860FC4  mov      w8, #1
006860FC8  strb     w8, [x20, #0x9f7]
006860FCC  ldr      x3, [x23]
006860FD0  ldrb     w8, [x3, #0x53]
006860FD4  tbnz     w8, #5, #0x686102c
006860FD8  movi     v0.2d, #0000000000000000
006860FDC  mov      x0, x19
006860FE0  stp      q0, q0, [sp, #0x20]
006860FE4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860FE8  cbz      x0, #0x68613a4
006860FEC  adrp     x23, #0x959a000
006860FF0  ldrb     w8, [x23, #0xc8e]
006860FF4  mov      x20, x0
006860FF8  cbnz     w8, #0x6861010
006860FFC  adrp     x0, #0x8f19000
006861000  ldr      x0, [x0, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
006861004  bl       #0x382bd14 ; 
006861008  mov      w8, #1
00686100C  strb     w8, [x23, #0xc8e]
006861010  adrp     x8, #0x8f19000
006861014  ldr      x8, [x8, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
006861018  ldr      x1, [x8]
00686101C  ldrb     w8, [x1, #0x53]
006861020  tbnz     w8, #5, #0x686105c
006861024  ldr      x0, [x20, #0x250]
006861028  b        #0x6861068 ; 
00686102C  ldr      x4, [x3, #0x60]
006861030  mov      x0, x19
006861034  mov      x1, x22
006861038  mov      x2, x21
00686103C  ldp      x20, x19, [sp, #0x90]
006861040  ldp      x22, x21, [sp, #0x80]
006861044  ldp      x24, x23, [sp, #0x70]
006861048  ldp      x26, x25, [sp, #0x60]
00686104C  ldp      x28, x27, [sp, #0x50]
006861050  ldp      x29, x30, [sp, #0x40]
006861054  add      sp, sp, #0xa0
006861058  br       x4
00686105C  ldr      x8, [x1, #0x60]
006861060  mov      x0, x20
006861064  blr      x8
006861068  cbz      x0, #0x68613a4
00686106C  adrp     x8, #0x8f23000
006861070  ldr      x8, [x8, #0xca8] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Get<int, int>() @ 0x92cfb30
006861074  ldr      x1, [x8]
006861078  bl       #0x47831d8 ; HotFix.Common.XDictionaryHelper$$Get<int, int>
00686107C  mov      x20, x0
006861080  mov      x0, x19
006861084  mov      x1, x22
006861088  mov      x2, x21
00686108C  mov      x3, x20
006861090  mov      x4, xzr
006861094  bl       #0x6862418 ; HotFix.BattleLogic.DankeSkillCreator$$GetAddSkillId
006861098  mov      w1, #1
00686109C  mov      x0, x22
0068610A0  mov      x2, xzr
0068610A4  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
0068610A8  ldr      x8, [x19, #0x48]
0068610AC  cbz      x8, #0x68613a4
0068610B0  ldr      w9, [x8, #0x18]
0068610B4  mov      w23, w0
0068610B8  cmp      w0, w9
0068610BC  b.ge     #0x6861130
0068610C0  b.hs     #0x68613a8
0068610C4  cbz      x22, #0x68613a4
0068610C8  add      x8, x8, w23, sxtw #3
0068610CC  adrp     x25, #0x9598000
0068610D0  ldrb     w9, [x25, #0xde3]
0068610D4  ldr      x24, [x8, #0x20]
0068610D8  cbnz     w9, #0x68610f0
0068610DC  adrp     x0, #0x8f00000
0068610E0  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
0068610E4  bl       #0x382bd14 ; 
0068610E8  mov      w8, #1
0068610EC  strb     w8, [x25, #0xde3]
0068610F0  adrp     x8, #0x8f00000
0068610F4  ldr      x8, [x8, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
0068610F8  ldr      x1, [x8]
0068610FC  ldrb     w8, [x1, #0x53]
006861100  tbnz     w8, #5, #0x686110c
006861104  ldr      w1, [x22, #0x20]
006861108  b        #0x686111c ; 
00686110C  ldr      x8, [x1, #0x60]
006861110  mov      x0, x22
006861114  blr      x8
006861118  mov      w1, w0
00686111C  cbz      x24, #0x68613a4
006861120  mov      x0, x24
006861124  mov      w2, wzr
006861128  mov      x3, xzr
00686112C  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006861130  ldr      x8, [x19, #0x18]
006861134  cbz      x8, #0x68613a4
006861138  ldr      w9, [x8, #0x18]
00686113C  cmp      w23, w9
006861140  b.ge     #0x68611b4
006861144  b.hs     #0x68613a8
006861148  cbz      x22, #0x68613a4
00686114C  add      x8, x8, w23, sxtw #3
006861150  adrp     x24, #0x9598000
006861154  ldrb     w9, [x24, #0xde3]
006861158  ldr      x23, [x8, #0x20]
00686115C  cbnz     w9, #0x6861174
006861160  adrp     x0, #0x8f00000
006861164  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
006861168  bl       #0x382bd14 ; 
00686116C  mov      w8, #1
006861170  strb     w8, [x24, #0xde3]
006861174  adrp     x8, #0x8f00000
006861178  ldr      x8, [x8, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
00686117C  ldr      x1, [x8]
006861180  ldrb     w8, [x1, #0x53]
006861184  tbnz     w8, #5, #0x6861190
006861188  ldr      w1, [x22, #0x20]
00686118C  b        #0x68611a0 ; 
006861190  ldr      x8, [x1, #0x60]
006861194  mov      x0, x22
006861198  blr      x8
00686119C  mov      w1, w0
0068611A0  cbz      x23, #0x68613a4
0068611A4  mov      x0, x23
0068611A8  mov      w2, wzr
0068611AC  mov      x3, xzr
0068611B0  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
0068611B4  cbz      x20, #0x68613a4
0068611B8  adrp     x8, #0x8f09000
0068611BC  ldr      x8, [x8, #0x238] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.GetEnumerator() @ 0x920b060
0068611C0  mov      x0, x20
0068611C4  ldr      x1, [x8]
0068611C8  mov      x8, sp
0068611CC  bl       #0x5e28538 ; System.Collections.Generic.Dictionary<int, int>$$GetEnumerator
0068611D0  ldp      q0, q1, [sp]
0068611D4  adrp     x28, #0x8f09000
0068611D8  adrp     x22, #0x8f06000
0068611DC  ldr      x28, [x28, #0x258] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.MoveNext() @ 0x9214798
0068611E0  ldr      x22, [x22, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068611E4  adrp     x29, #0x9598000
0068611E8  stp      q0, q1, [sp, #0x20]
0068611EC  mov      w27, #1
0068611F0  ldr      x1, [x28]
0068611F4  add      x0, sp, #0x20
0068611F8  bl       #0x614eb48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$MoveNext
0068611FC  tbz      w0, #0, #0x68612e8
006861200  ldp      w23, w24, [sp, #0x30]
006861204  mov      x0, x19
006861208  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00686120C  mov      x25, x0
006861210  cbz      x0, #0x6861398
006861214  ldrb     w8, [x29, #0xfcc]
006861218  cbnz     w8, #0x6861228
00686121C  mov      x0, x22
006861220  bl       #0x382bd14 ; 
006861224  strb     w27, [x29, #0xfcc]
006861228  ldr      x1, [x22]
00686122C  ldrb     w8, [x1, #0x53]
006861230  tbnz     w8, #5, #0x686123c
006861234  ldr      x0, [x25, #0x200]
006861238  b        #0x6861248 ; 
00686123C  ldr      x8, [x1, #0x60]
006861240  mov      x0, x25
006861244  blr      x8
006861248  cbz      x0, #0x686139c
00686124C  mov      w1, w23
006861250  mov      x2, xzr
006861254  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006861258  mov      w1, #1
00686125C  mov      x2, xzr
006861260  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
006861264  ldr      x8, [x19, #0x48]
006861268  cbz      x8, #0x686138c
00686126C  ldr      w9, [x8, #0x18]
006861270  mov      w25, w0
006861274  cmp      w0, w9
006861278  b.hs     #0x6861394
00686127C  ldr      x9, [x19]
006861280  sxtw     x26, w25
006861284  add      x8, x8, x26, lsl #3
006861288  ldr      x1, [x8, #0x20]
00686128C  ldr      x8, [x9, #0x228]
006861290  ldr      x5, [x9, #0x230]
006861294  mov      x0, x19
006861298  mov      w2, w23
00686129C  mov      w3, w24
0068612A0  mov      x4, x21
0068612A4  blr      x8
0068612A8  ldr      x8, [x19, #0x18]
0068612AC  cbz      x8, #0x6861390
0068612B0  ldr      w9, [x8, #0x18]
0068612B4  cmp      w25, w9
0068612B8  b.hs     #0x68613a0
0068612BC  ldr      x9, [x19]
0068612C0  add      x8, x8, x26, lsl #3
0068612C4  ldr      x1, [x8, #0x20]
0068612C8  ldr      x8, [x9, #0x228]
0068612CC  ldr      x5, [x9, #0x230]
0068612D0  mov      x0, x19
0068612D4  mov      w2, w23
0068612D8  mov      w3, w24
0068612DC  mov      x4, x21
0068612E0  blr      x8
0068612E4  b        #0x68611f0 ; 
0068612E8  adrp     x8, #0x8f09000
0068612EC  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
0068612F0  add      x0, sp, #0x20
0068612F4  ldr      x1, [x8]
0068612F8  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
0068612FC  adrp     x24, #0x8f19000
006861300  ldr      x24, [x24, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
006861304  adrp     x23, #0x959a000
006861308  mov      x0, x19
00686130C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006861310  cbz      x0, #0x68613a4
006861314  ldrb     w8, [x23, #0xc8e]
006861318  mov      x19, x0
00686131C  cbnz     w8, #0x6861334
006861320  adrp     x0, #0x8f19000
006861324  ldr      x0, [x0, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
006861328  bl       #0x382bd14 ; 
00686132C  mov      w8, #1
006861330  strb     w8, [x23, #0xc8e]
006861334  ldr      x1, [x24]
006861338  ldrb     w8, [x1, #0x53]
00686133C  tbnz     w8, #5, #0x6861348
006861340  ldr      x0, [x19, #0x250]
006861344  b        #0x6861354 ; 
006861348  ldr      x8, [x1, #0x60]
00686134C  mov      x0, x19
006861350  blr      x8
006861354  cbz      x0, #0x68613a4
006861358  adrp     x8, #0x8f23000
00686135C  ldr      x8, [x8, #0xcb0] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Push<int, int>() @ 0x92cfb40
006861360  mov      x1, x20
006861364  ldr      x2, [x8]
006861368  bl       #0x47839d4 ; HotFix.Common.XDictionaryHelper$$Push<int, int>
00686136C  ldp      x20, x19, [sp, #0x90]
006861370  ldp      x22, x21, [sp, #0x80]
006861374  ldp      x24, x23, [sp, #0x70]
006861378  ldp      x26, x25, [sp, #0x60]
00686137C  ldp      x28, x27, [sp, #0x50]
006861380  ldp      x29, x30, [sp, #0x40]
006861384  add      sp, sp, #0xa0
006861388  ret      
00686138C  bl       #0x382bfb8 ; 
006861390  bl       #0x382bfb8 ; 
006861394  bl       #0x382bfc0 ; 
006861398  bl       #0x382bfb8 ; 
00686139C  bl       #0x382bfb8 ; 
0068613A0  bl       #0x382bfc0 ; 
0068613A4  bl       #0x382bfb8 ; 
0068613A8  bl       #0x382bfc0 ; 
0068613AC  b        #0x68613dc ; 
0068613B0  b        #0x68613dc ; 
0068613B4  b        #0x68613dc ; 
0068613B8  b        #0x68613dc ; 
0068613BC  b        #0x68613dc ; 
0068613C0  b        #0x68613dc ; 
0068613C4  b        #0x68613dc ; 
0068613C8  b        #0x68613dc ; 
0068613CC  b        #0x68613dc ; 
0068613D0  b        #0x68613dc ; 
0068613D4  b        #0x68613dc ; 
0068613D8  b        #0x68613dc ; 
0068613DC  adrp     x24, #0x8f19000
0068613E0  ldr      x24, [x24, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
0068613E4  mov      x21, x0
0068613E8  adrp     x23, #0x959a000
0068613EC  cmp      w1, #1
0068613F0  b.ne     #0x6861424
0068613F4  mov      x0, x21
0068613F8  bl       #0x89eda50 ; 
0068613FC  ldr      x22, [x0]
006861400  bl       #0x89eda60 ; 
006861404  adrp     x8, #0x8f09000
006861408  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
00686140C  add      x0, sp, #0x20
006861410  ldr      x1, [x8]
006861414  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006861418  cbz      x22, #0x6861308
00686141C  mov      x0, x22
006861420  bl       #0x382bfb0 ; 
006861424  mov      x22, xzr
006861428  b        #0x6861430 ; 
00686142C  mov      x21, x0
006861430  adrp     x8, #0x8f09000
006861434  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006861438  ldr      x1, [x8]
00686143C  add      x0, sp, #0x20
006861440  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006861444  cbnz     x22, #0x6861450
006861448  mov      x0, x21
00686144C  bl       #0x3b56bfc ; 
006861450  mov      x0, x22
006861454  bl       #0x382bfb0 ; 
006861458  bl       #0x3442448 ; 

