; HotFix.BattleLogic.EntityCharacter$$InitSkillStorage
; RVA 0x67D8F58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067D8F58  stp      x29, x30, [sp, #-0x60]!
0067D8F5C  stp      x28, x27, [sp, #0x10]
0067D8F60  stp      x26, x25, [sp, #0x20]
0067D8F64  stp      x24, x23, [sp, #0x30]
0067D8F68  stp      x22, x21, [sp, #0x40]
0067D8F6C  stp      x20, x19, [sp, #0x50]
0067D8F70  adrp     x20, #0x959b000
0067D8F74  adrp     x21, #0x8f1e000
0067D8F78  ldrb     w8, [x20, #0x287]
0067D8F7C  ldr      x21, [x21, #0x780] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitSkillStorage()
0067D8F80  mov      x19, x0
0067D8F84  tbnz     w8, #0, #0x67d90a4
0067D8F88  adrp     x0, #0x8f1e000
0067D8F8C  ldr      x0, [x0, #0x788] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityCharacterTypeKey, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>..ctor()
0067D8F90  bl       #0x382bd14 ; 
0067D8F94  adrp     x0, #0x8f1e000
0067D8F98  ldr      x0, [x0, #0x790] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>..ctor()
0067D8F9C  bl       #0x382bd14 ; 
0067D8FA0  adrp     x0, #0x8f1a000
0067D8FA4  ldr      x0, [x0, #0xdb8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, FP>..ctor()
0067D8FA8  bl       #0x382bd14 ; 
0067D8FAC  adrp     x0, #0x8f1e000
0067D8FB0  ldr      x0, [x0, #0x798] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponThroughFlagEnemyRateData>..ctor()
0067D8FB4  bl       #0x382bd14 ; 
0067D8FB8  adrp     x0, #0x8f1e000
0067D8FBC  ldr      x0, [x0, #0x7a0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, ValueTuple<FP, FP>>..ctor()
0067D8FC0  bl       #0x382bd14 ; 
0067D8FC4  adrp     x0, #0x8f1e000
0067D8FC8  ldr      x0, [x0, #0x7a8] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityCharacterTypeKey, EntityCharacter.SameEnemyMilestoneExplosionConfig>..ctor()
0067D8FCC  bl       #0x382bd14 ; 
0067D8FD0  adrp     x0, #0x8ee3000
0067D8FD4  ldr      x0, [x0, #0xfb0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>..ctor()
0067D8FD8  bl       #0x382bd14 ; 
0067D8FDC  adrp     x0, #0x8f1e000
0067D8FE0  ldr      x0, [x0, #0x7b0] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityRef, Dictionary<int, EntityCharacter.HurtByEnemyCountData>>..ctor()
0067D8FE4  bl       #0x382bd14 ; 
0067D8FE8  adrp     x0, #0x8f1e000
0067D8FEC  ldr      x0, [x0, #0x7b8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponBuffFlagData>..ctor()
0067D8FF0  bl       #0x382bd14 ; 
0067D8FF4  adrp     x0, #0x8f1e000
0067D8FF8  ldr      x0, [x0, #0x7c0] ; GLOBAL System.Collections.Generic.Dictionary<EntityCharacterTypeKey, EntityCharacter.SameEnemyMilestoneExplosionConfig>_TypeInfo
0067D8FFC  bl       #0x382bd14 ; 
0067D9000  adrp     x0, #0x8f1e000
0067D9004  ldr      x0, [x0, #0x7c8] ; GLOBAL System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponThroughFlagEnemyRateData>_TypeInfo
0067D9008  bl       #0x382bd14 ; 
0067D900C  adrp     x0, #0x8f1e000
0067D9010  ldr      x0, [x0, #0x7d0] ; GLOBAL System.Collections.Generic.Dictionary<EntityCharacterTypeKey, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>_TypeInfo
0067D9014  bl       #0x382bd14 ; 
0067D9018  adrp     x0, #0x8f1a000
0067D901C  ldr      x0, [x0, #0xdd0] ; GLOBAL System.Collections.Generic.Dictionary<int, FP>_TypeInfo
0067D9020  bl       #0x382bd14 ; 
0067D9024  adrp     x0, #0x8f1e000
0067D9028  ldr      x0, [x0, #0x7d8] ; GLOBAL System.Collections.Generic.Dictionary<EntityRef, Dictionary<int, EntityCharacter.HurtByEnemyCountData>>_TypeInfo
0067D902C  bl       #0x382bd14 ; 
0067D9030  adrp     x0, #0x8f1e000
0067D9034  ldr      x0, [x0, #0x7e0] ; GLOBAL System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponBuffFlagData>_TypeInfo
0067D9038  bl       #0x382bd14 ; 
0067D903C  adrp     x0, #0x8f1e000
0067D9040  ldr      x0, [x0, #0x7e8] ; GLOBAL System.Collections.Generic.Dictionary<int, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>_TypeInfo
0067D9044  bl       #0x382bd14 ; 
0067D9048  adrp     x0, #0x8ee3000
0067D904C  ldr      x0, [x0, #0xfa8] ; GLOBAL System.Collections.Generic.Dictionary<int, int>_TypeInfo
0067D9050  bl       #0x382bd14 ; 
0067D9054  adrp     x0, #0x8f1e000
0067D9058  ldr      x0, [x0, #0x7f0] ; GLOBAL System.Collections.Generic.Dictionary<int, ValueTuple<FP, FP>>_TypeInfo
0067D905C  bl       #0x382bd14 ; 
0067D9060  adrp     x0, #0x8f1e000
0067D9064  ldr      x0, [x0, #0x780] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitSkillStorage()
0067D9068  bl       #0x382bd14 ; 
0067D906C  adrp     x0, #0x8ede000
0067D9070  ldr      x0, [x0, #0x108] ; GLOBAL Method$System.Collections.Generic.HashSet<int>..ctor()
0067D9074  bl       #0x382bd14 ; 
0067D9078  adrp     x0, #0x8ede000
0067D907C  ldr      x0, [x0, #0x100] ; GLOBAL System.Collections.Generic.HashSet<int>_TypeInfo
0067D9080  bl       #0x382bd14 ; 
0067D9084  adrp     x0, #0x8f1e000
0067D9088  ldr      x0, [x0, #0x7f8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, List<ValueTuple<bool, IMod>>>..ctor()
0067D908C  bl       #0x382bd14 ; 
0067D9090  adrp     x0, #0x8f1e000
0067D9094  ldr      x0, [x0, #0x800] ; GLOBAL Rock.Collections.OrderedDictionary<int, List<ValueTuple<bool, IMod>>>_TypeInfo
0067D9098  bl       #0x382bd14 ; 
0067D909C  mov      w8, #1
0067D90A0  strb     w8, [x20, #0x287]
0067D90A4  ldr      x1, [x21]
0067D90A8  ldrb     w8, [x1, #0x53]
0067D90AC  tbnz     w8, #5, #0x67d93b0
0067D90B0  adrp     x23, #0x8f1a000
0067D90B4  ldr      x23, [x23, #0xdd0] ; GLOBAL System.Collections.Generic.Dictionary<int, FP>_TypeInfo
0067D90B8  adrp     x29, #0x8f1a000
0067D90BC  adrp     x28, #0x8f1e000
0067D90C0  adrp     x21, #0x8f1e000
0067D90C4  adrp     x27, #0x8f1e000
0067D90C8  adrp     x26, #0x8f1e000
0067D90CC  adrp     x25, #0x8f1e000
0067D90D0  adrp     x24, #0x8f1e000
0067D90D4  adrp     x22, #0x8f1e000
0067D90D8  ldr      x29, [x29, #0xdb8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, FP>..ctor()
0067D90DC  ldr      x28, [x28, #0x800] ; GLOBAL Rock.Collections.OrderedDictionary<int, List<ValueTuple<bool, IMod>>>_TypeInfo
0067D90E0  ldr      x21, [x21, #0x7f8] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, List<ValueTuple<bool, IMod>>>..ctor()
0067D90E4  ldr      x27, [x27, #0x7f0] ; GLOBAL System.Collections.Generic.Dictionary<int, ValueTuple<FP, FP>>_TypeInfo
0067D90E8  ldr      x26, [x26, #0x7a0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, ValueTuple<FP, FP>>..ctor()
0067D90EC  ldr      x25, [x25, #0x7e0] ; GLOBAL System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponBuffFlagData>_TypeInfo
0067D90F0  ldr      x24, [x24, #0x7b8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponBuffFlagData>..ctor()
0067D90F4  ldr      x22, [x22, #0x7d0] ; GLOBAL System.Collections.Generic.Dictionary<EntityCharacterTypeKey, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>_TypeInfo
0067D90F8  ldr      x0, [x23]
0067D90FC  bl       #0x382bfa0 ; 
0067D9100  ldr      x1, [x29]
0067D9104  mov      x20, x0
0067D9108  bl       #0x5e1c480 ; System.Collections.Generic.Dictionary<int, FP>$$.ctor
0067D910C  add      x0, x19, #0x200
0067D9110  mov      x1, x20
0067D9114  str      x20, [x19, #0x200]
0067D9118  bl       #0x382bcb8 ; 
0067D911C  ldr      x0, [x23]
0067D9120  bl       #0x382bfa0 ; 
0067D9124  ldr      x1, [x29]
0067D9128  mov      x20, x0
0067D912C  bl       #0x5e1c480 ; System.Collections.Generic.Dictionary<int, FP>$$.ctor
0067D9130  add      x0, x19, #0x208
0067D9134  mov      x1, x20
0067D9138  str      x20, [x19, #0x208]
0067D913C  bl       #0x382bcb8 ; 
0067D9140  ldr      x0, [x23]
0067D9144  bl       #0x382bfa0 ; 
0067D9148  ldr      x1, [x29]
0067D914C  mov      x20, x0
0067D9150  bl       #0x5e1c480 ; System.Collections.Generic.Dictionary<int, FP>$$.ctor
0067D9154  add      x0, x19, #0x210
0067D9158  mov      x1, x20
0067D915C  str      x20, [x19, #0x210]
0067D9160  bl       #0x382bcb8 ; 
0067D9164  mov      x0, xzr
0067D9168  bl       #0x416d554 ; Rock.Collections.Custom.OrderedDictionaryIntComparer$$get_Default
0067D916C  ldr      x8, [x28]
0067D9170  mov      x20, x0
0067D9174  mov      x0, x8
0067D9178  bl       #0x382bfa0 ; 
0067D917C  ldr      x2, [x21]
0067D9180  mov      x1, x20
0067D9184  mov      x21, x0
0067D9188  bl       #0x5224fcc ; Rock.Collections.OrderedDictionary<int, object>$$.ctor
0067D918C  add      x0, x19, #0x228
0067D9190  mov      x1, x21
0067D9194  str      x21, [x19, #0x228]
0067D9198  bl       #0x382bcb8 ; 
0067D919C  ldr      x0, [x27]
0067D91A0  bl       #0x382bfa0 ; 
0067D91A4  ldr      x1, [x26]
0067D91A8  mov      x20, x0
0067D91AC  bl       #0x5df7c30 ; System.Collections.Generic.Dictionary<int, ValueTuple<FP, FP>>$$.ctor
0067D91B0  add      x0, x19, #0x240
0067D91B4  mov      x1, x20
0067D91B8  str      x20, [x19, #0x240]
0067D91BC  bl       #0x382bcb8 ; 
0067D91C0  ldr      x0, [x25]
0067D91C4  bl       #0x382bfa0 ; 
0067D91C8  ldr      x1, [x24]
0067D91CC  mov      x20, x0
0067D91D0  bl       #0x5e5ec40 ; System.Collections.Generic.Dictionary<int, object>$$.ctor
0067D91D4  add      x0, x19, #0x248
0067D91D8  mov      x1, x20
0067D91DC  str      x20, [x19, #0x248]
0067D91E0  bl       #0x382bcb8 ; 
0067D91E4  ldr      x0, [x22]
0067D91E8  bl       #0x382bfa0 ; 
0067D91EC  adrp     x8, #0x8f1e000
0067D91F0  ldr      x8, [x8, #0x788] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityCharacterTypeKey, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>..ctor()
0067D91F4  mov      x20, x0
0067D91F8  ldr      x1, [x8]
0067D91FC  bl       #0x5dc1a50 ; System.Collections.Generic.Dictionary<EntityCharacterTypeKey, object>$$.ctor
0067D9200  add      x0, x19, #0x250
0067D9204  mov      x1, x20
0067D9208  str      x20, [x19, #0x250]
0067D920C  bl       #0x382bcb8 ; 
0067D9210  adrp     x8, #0x8f1e000
0067D9214  ldr      x8, [x8, #0x7e8] ; GLOBAL System.Collections.Generic.Dictionary<int, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>_TypeInfo
0067D9218  ldr      x0, [x8]
0067D921C  bl       #0x382bfa0 ; 
0067D9220  adrp     x8, #0x8f1e000
0067D9224  ldr      x8, [x8, #0x790] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, Dictionary<string, EntityCharacter.SameEnemyHurtAddConfig>>..ctor()
0067D9228  mov      x20, x0
0067D922C  ldr      x1, [x8]
0067D9230  bl       #0x5e5ec40 ; System.Collections.Generic.Dictionary<int, object>$$.ctor
0067D9234  add      x0, x19, #0x258
0067D9238  mov      x1, x20
0067D923C  str      x20, [x19, #0x258]
0067D9240  bl       #0x382bcb8 ; 
0067D9244  adrp     x8, #0x8f1e000
0067D9248  ldr      x8, [x8, #0x7c0] ; GLOBAL System.Collections.Generic.Dictionary<EntityCharacterTypeKey, EntityCharacter.SameEnemyMilestoneExplosionConfig>_TypeInfo
0067D924C  ldr      x0, [x8]
0067D9250  bl       #0x382bfa0 ; 
0067D9254  adrp     x8, #0x8f1e000
0067D9258  ldr      x8, [x8, #0x7a8] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityCharacterTypeKey, EntityCharacter.SameEnemyMilestoneExplosionConfig>..ctor()
0067D925C  mov      x20, x0
0067D9260  ldr      x1, [x8]
0067D9264  bl       #0x5dc1a50 ; System.Collections.Generic.Dictionary<EntityCharacterTypeKey, object>$$.ctor
0067D9268  add      x0, x19, #0x260
0067D926C  mov      x1, x20
0067D9270  str      x20, [x19, #0x260]
0067D9274  bl       #0x382bcb8 ; 
0067D9278  ldr      x0, [x23]
0067D927C  bl       #0x382bfa0 ; 
0067D9280  ldr      x1, [x29]
0067D9284  mov      x20, x0
0067D9288  bl       #0x5e1c480 ; System.Collections.Generic.Dictionary<int, FP>$$.ctor
0067D928C  add      x0, x19, #0x270
0067D9290  mov      x1, x20
0067D9294  str      x20, [x19, #0x270]
0067D9298  bl       #0x382bcb8 ; 
0067D929C  ldr      x0, [x23]
0067D92A0  bl       #0x382bfa0 ; 
0067D92A4  ldr      x1, [x29]
0067D92A8  mov      x20, x0
0067D92AC  bl       #0x5e1c480 ; System.Collections.Generic.Dictionary<int, FP>$$.ctor
0067D92B0  add      x0, x19, #0x288
0067D92B4  mov      x1, x20
0067D92B8  str      x20, [x19, #0x288]
0067D92BC  bl       #0x382bcb8 ; 
0067D92C0  adrp     x8, #0x8ee3000
0067D92C4  ldr      x8, [x8, #0xfa8] ; GLOBAL System.Collections.Generic.Dictionary<int, int>_TypeInfo
0067D92C8  ldr      x0, [x8]
0067D92CC  bl       #0x382bfa0 ; 
0067D92D0  adrp     x8, #0x8ee3000
0067D92D4  ldr      x8, [x8, #0xfb0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>..ctor()
0067D92D8  mov      x20, x0
0067D92DC  ldr      x1, [x8]
0067D92E0  bl       #0x5e2737c ; System.Collections.Generic.Dictionary<int, int>$$.ctor
0067D92E4  add      x0, x19, #0x290
0067D92E8  mov      x1, x20
0067D92EC  str      x20, [x19, #0x290]
0067D92F0  bl       #0x382bcb8 ; 
0067D92F4  adrp     x8, #0x8f1e000
0067D92F8  ldr      x8, [x8, #0x7c8] ; GLOBAL System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponThroughFlagEnemyRateData>_TypeInfo
0067D92FC  ldr      x0, [x8]
0067D9300  bl       #0x382bfa0 ; 
0067D9304  adrp     x8, #0x8f1e000
0067D9308  ldr      x8, [x8, #0x798] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, EntityCharacter.WeaponThroughFlagEnemyRateData>..ctor()
0067D930C  mov      x20, x0
0067D9310  ldr      x1, [x8]
0067D9314  bl       #0x5e5ec40 ; System.Collections.Generic.Dictionary<int, object>$$.ctor
0067D9318  add      x0, x19, #0x298
0067D931C  mov      x1, x20
0067D9320  str      x20, [x19, #0x298]
0067D9324  bl       #0x382bcb8 ; 
0067D9328  adrp     x8, #0x8f1e000
0067D932C  ldr      x8, [x8, #0x7d8] ; GLOBAL System.Collections.Generic.Dictionary<EntityRef, Dictionary<int, EntityCharacter.HurtByEnemyCountData>>_TypeInfo
0067D9330  ldr      x0, [x8]
0067D9334  bl       #0x382bfa0 ; 
0067D9338  adrp     x8, #0x8f1e000
0067D933C  ldr      x8, [x8, #0x7b0] ; GLOBAL Method$System.Collections.Generic.Dictionary<EntityRef, Dictionary<int, EntityCharacter.HurtByEnemyCountData>>..ctor()
0067D9340  mov      x20, x0
0067D9344  ldr      x1, [x8]
0067D9348  bl       #0x5dd7274 ; System.Collections.Generic.Dictionary<EntityRef, object>$$.ctor
0067D934C  add      x0, x19, #0x2a0
0067D9350  mov      x1, x20
0067D9354  str      x20, [x19, #0x2a0]
0067D9358  bl       #0x382bcb8 ; 
0067D935C  adrp     x8, #0x8ede000
0067D9360  ldr      x8, [x8, #0x100] ; GLOBAL System.Collections.Generic.HashSet<int>_TypeInfo
0067D9364  ldr      x0, [x8]
0067D9368  bl       #0x382bfa0 ; 
0067D936C  adrp     x8, #0x8ede000
0067D9370  ldr      x8, [x8, #0x108] ; GLOBAL Method$System.Collections.Generic.HashSet<int>..ctor()
0067D9374  mov      x20, x0
0067D9378  ldr      x1, [x8]
0067D937C  bl       #0x4936d3c ; System.Collections.Generic.HashSet<int>$$.ctor
0067D9380  add      x0, x19, #0x2a8
0067D9384  mov      x1, x20
0067D9388  str      x20, [x19, #0x2a8]
0067D938C  bl       #0x382bcb8 ; 
0067D9390  mov      x0, x19
0067D9394  ldp      x20, x19, [sp, #0x50]
0067D9398  ldp      x22, x21, [sp, #0x40]
0067D939C  ldp      x24, x23, [sp, #0x30]
0067D93A0  ldp      x26, x25, [sp, #0x20]
0067D93A4  ldp      x28, x27, [sp, #0x10]
0067D93A8  ldp      x29, x30, [sp], #0x60
0067D93AC  b        #0x67ed140 ; HotFix.BattleLogic.EntityCharacter$$InitKillBulletCounts
0067D93B0  ldr      x2, [x1, #0x60]
0067D93B4  mov      x0, x19
0067D93B8  ldp      x20, x19, [sp, #0x50]
0067D93BC  ldp      x22, x21, [sp, #0x40]
0067D93C0  ldp      x24, x23, [sp, #0x30]
0067D93C4  ldp      x26, x25, [sp, #0x20]
0067D93C8  ldp      x28, x27, [sp, #0x10]
0067D93CC  ldp      x29, x30, [sp], #0x60
0067D93D0  br       x2

