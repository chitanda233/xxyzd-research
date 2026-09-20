; HotFix.BattleLogic.DropItemExp$$OnAbsorb
; RVA 0x6666C90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006666C90  sub      sp, sp, #0x70
006666C94  stp      x29, x30, [sp, #0x10]
006666C98  stp      x28, x27, [sp, #0x20]
006666C9C  stp      x26, x25, [sp, #0x30]
006666CA0  stp      x24, x23, [sp, #0x40]
006666CA4  stp      x22, x21, [sp, #0x50]
006666CA8  stp      x20, x19, [sp, #0x60]
006666CAC  adrp     x20, #0x9599000
006666CB0  adrp     x21, #0x8f0f000
006666CB4  ldrb     w8, [x20, #0xd76]
006666CB8  ldr      x21, [x21, #0x2f8] ; GLOBAL Method$HotFix.BattleLogic.DropItemExp.OnAbsorb() @ 0x925fd58
006666CBC  mov      x19, x0
006666CC0  tbnz     w8, #0, #0x6666d20
006666CC4  adrp     x0, #0x8f0f000
006666CC8  ldr      x0, [x0, #0x2f8] ; GLOBAL Method$HotFix.BattleLogic.DropItemExp.OnAbsorb() @ 0x925fd58
006666CCC  bl       #0x382bd14 ; 
006666CD0  adrp     x0, #0x8f09000
006666CD4  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
006666CD8  bl       #0x382bd14 ; 
006666CDC  adrp     x0, #0x8ee6000
006666CE0  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006666CE4  bl       #0x382bd14 ; 
006666CE8  adrp     x0, #0x8f0f000
006666CEC  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006666CF0  bl       #0x382bd14 ; 
006666CF4  adrp     x0, #0x8ee8000
006666CF8  ldr      x0, [x0, #0x838] ; GLOBAL Method$System.Nullable<FP>..ctor() @ 0x9227b20
006666CFC  bl       #0x382bd14 ; 
006666D00  adrp     x0, #0x8f0f000
006666D04  ldr      x0, [x0, #0x300] ; GLOBAL AddExp% @ 0x92f00b8
006666D08  bl       #0x382bd14 ; 
006666D0C  adrp     x0, #0x8f09000
006666D10  ldr      x0, [x0, #0xfe8] ; GLOBAL BattleGold% @ 0x92f2aa8
006666D14  bl       #0x382bd14 ; 
006666D18  mov      w8, #1
006666D1C  strb     w8, [x20, #0xd76]
006666D20  ldr      x1, [x21]
006666D24  ldrb     w8, [x1, #0x53]
006666D28  tbnz     w8, #5, #0x6666d70
006666D2C  adrp     x25, #0x9591000
006666D30  ldrb     w8, [x25, #0xa4b]
006666D34  cbnz     w8, #0x6666d4c
006666D38  adrp     x0, #0x8ee5000
006666D3C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006666D40  bl       #0x382bd14 ; 
006666D44  mov      w8, #1
006666D48  strb     w8, [x25, #0xa4b]
006666D4C  adrp     x26, #0x8ee5000
006666D50  ldr      x26, [x26, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006666D54  adrp     x28, #0x8f0f000
006666D58  ldr      x1, [x26]
006666D5C  ldrb     w8, [x1, #0x53]
006666D60  ldr      x28, [x28, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006666D64  tbnz     w8, #5, #0x6666d98
006666D68  ldr      x20, [x19, #0x20]
006666D6C  b        #0x6666da8 ; 
006666D70  ldr      x2, [x1, #0x60]
006666D74  mov      x0, x19
006666D78  ldp      x20, x19, [sp, #0x60]
006666D7C  ldp      x22, x21, [sp, #0x50]
006666D80  ldp      x24, x23, [sp, #0x40]
006666D84  ldp      x26, x25, [sp, #0x30]
006666D88  ldp      x28, x27, [sp, #0x20]
006666D8C  ldp      x29, x30, [sp, #0x10]
006666D90  add      sp, sp, #0x70
006666D94  br       x2
006666D98  ldr      x8, [x1, #0x60]
006666D9C  mov      x0, x19
006666DA0  blr      x8
006666DA4  mov      x20, x0
006666DA8  ldr      x1, [x28]
006666DAC  ldrb     w8, [x1, #0x53]
006666DB0  tbnz     w8, #5, #0x6666dbc
006666DB4  ldr      x0, [x19, #0x38]
006666DB8  b        #0x6666dc8 ; 
006666DBC  ldr      x8, [x1, #0x60]
006666DC0  mov      x0, x19
006666DC4  blr      x8
006666DC8  cbz      x0, #0x6667270
006666DCC  ldr      x21, [x0, #0x78]
006666DD0  cbz      x21, #0x6667270
006666DD4  adrp     x22, #0x9599000
006666DD8  ldrb     w8, [x22, #0xebb]
006666DDC  cbnz     w8, #0x6666df4
006666DE0  adrp     x0, #0x8f0f000
006666DE4  ldr      x0, [x0, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006666DE8  bl       #0x382bd14 ; 
006666DEC  mov      w8, #1
006666DF0  strb     w8, [x22, #0xebb]
006666DF4  adrp     x8, #0x8f0f000
006666DF8  ldr      x8, [x8, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006666DFC  ldr      x1, [x8]
006666E00  ldrb     w8, [x1, #0x53]
006666E04  tbnz     w8, #5, #0x6666e10
006666E08  ldr      w1, [x21, #0x60]
006666E0C  b        #0x6666e20 ; 
006666E10  ldr      x8, [x1, #0x60]
006666E14  mov      x0, x21
006666E18  blr      x8
006666E1C  mov      w1, w0
006666E20  cbz      x20, #0x6667270
006666E24  mov      x0, x20
006666E28  mov      x2, xzr
006666E2C  bl       #0x6a074b4 ; HotFix.BattleLogic.BattleWorldContext$$PlaySound
006666E30  ldrb     w8, [x25, #0xa4b]
006666E34  cbnz     w8, #0x6666e4c
006666E38  adrp     x0, #0x8ee5000
006666E3C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006666E40  bl       #0x382bd14 ; 
006666E44  mov      w8, #1
006666E48  strb     w8, [x25, #0xa4b]
006666E4C  ldr      x1, [x26]
006666E50  ldrb     w8, [x1, #0x53]
006666E54  tbnz     w8, #5, #0x6666e60
006666E58  ldr      x20, [x19, #0x20]
006666E5C  b        #0x6666e70 ; 
006666E60  ldr      x8, [x1, #0x60]
006666E64  mov      x0, x19
006666E68  blr      x8
006666E6C  mov      x20, x0
006666E70  cbz      x20, #0x6667270
006666E74  adrp     x21, #0x9591000
006666E78  ldrb     w8, [x21, #0xa62]
006666E7C  cbnz     w8, #0x6666e94
006666E80  adrp     x0, #0x8ee6000
006666E84  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
006666E88  bl       #0x382bd14 ; 
006666E8C  mov      w8, #1
006666E90  strb     w8, [x21, #0xa62]
006666E94  adrp     x8, #0x8ee6000
006666E98  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
006666E9C  ldr      x1, [x8]
006666EA0  ldrb     w8, [x1, #0x53]
006666EA4  tbnz     w8, #5, #0x6666eb0
006666EA8  ldr      x20, [x20, #0x1f8]
006666EAC  b        #0x6666ec0 ; 
006666EB0  ldr      x8, [x1, #0x60]
006666EB4  mov      x0, x20
006666EB8  blr      x8
006666EBC  mov      x20, x0
006666EC0  ldr      x1, [x28]
006666EC4  ldrb     w8, [x1, #0x53]
006666EC8  tbnz     w8, #5, #0x6666ed4
006666ECC  ldr      x0, [x19, #0x38]
006666ED0  b        #0x6666ee0 ; 
006666ED4  ldr      x8, [x1, #0x60]
006666ED8  mov      x0, x19
006666EDC  blr      x8
006666EE0  cbz      x0, #0x6667270
006666EE4  cbz      x20, #0x6667270
006666EE8  ldr      w1, [x0, #0x80]
006666EEC  mov      x0, x20
006666EF0  mov      x2, xzr
006666EF4  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
006666EF8  cbz      x0, #0x6667270
006666EFC  adrp     x8, #0x8ee6000
006666F00  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006666F04  mov      x20, x0
006666F08  ldr      x1, [x8]
006666F0C  ldrb     w8, [x1, #0x53]
006666F10  tbnz     w8, #5, #0x6666f1c
006666F14  ldr      x21, [x20, #0x38]
006666F18  b        #0x6666f2c ; 
006666F1C  ldr      x8, [x1, #0x60]
006666F20  mov      x0, x20
006666F24  blr      x8
006666F28  mov      x21, x0
006666F2C  cbz      x21, #0x6667270
006666F30  adrp     x27, #0x9591000
006666F34  ldrb     w8, [x27, #0xa7f]
006666F38  cbnz     w8, #0x6666f50
006666F3C  adrp     x0, #0x8ee6000
006666F40  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006666F44  bl       #0x382bd14 ; 
006666F48  mov      w8, #1
006666F4C  strb     w8, [x27, #0xa7f]
006666F50  adrp     x29, #0x8ee6000
006666F54  ldr      x29, [x29, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006666F58  ldr      x1, [x29]
006666F5C  ldrb     w8, [x1, #0x53]
006666F60  tbnz     w8, #5, #0x6666f6c
006666F64  ldr      x0, [x21, #0x178]
006666F68  b        #0x6666f78 ; 
006666F6C  ldr      x8, [x1, #0x60]
006666F70  mov      x0, x21
006666F74  blr      x8
006666F78  cbz      x0, #0x6667270
006666F7C  adrp     x8, #0x8f09000
006666F80  ldr      x8, [x8, #0xfe8] ; GLOBAL BattleGold% @ 0x92f2aa8
006666F84  mov      x2, xzr
006666F88  ldr      x1, [x8]
006666F8C  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
006666F90  ldrb     w8, [x25, #0xa4b]
006666F94  mov      x21, x0
006666F98  cbnz     w8, #0x6666fb0
006666F9C  adrp     x0, #0x8ee5000
006666FA0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006666FA4  bl       #0x382bd14 ; 
006666FA8  mov      w8, #1
006666FAC  strb     w8, [x25, #0xa4b]
006666FB0  ldr      x1, [x26]
006666FB4  ldrb     w8, [x1, #0x53]
006666FB8  tbnz     w8, #5, #0x6666fc4
006666FBC  ldr      x22, [x19, #0x20]
006666FC0  b        #0x6666fd4 ; 
006666FC4  ldr      x8, [x1, #0x60]
006666FC8  mov      x0, x19
006666FCC  blr      x8
006666FD0  mov      x22, x0
006666FD4  ldr      x1, [x28]
006666FD8  ldrb     w8, [x1, #0x53]
006666FDC  tbnz     w8, #5, #0x6666fe8
006666FE0  ldr      x0, [x19, #0x38]
006666FE4  b        #0x6666ff4 ; 
006666FE8  ldr      x8, [x1, #0x60]
006666FEC  mov      x0, x19
006666FF0  blr      x8
006666FF4  cbz      x0, #0x6667270
006666FF8  ldr      x23, [x0, #0x78]
006666FFC  cbz      x23, #0x6667270
006667000  adrp     x24, #0x9598000
006667004  ldrb     w8, [x24, #0xd61]
006667008  cbnz     w8, #0x6667020
00666700C  adrp     x0, #0x8eff000
006667010  ldr      x0, [x0, #0x538] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_id() @ 0x9285d88
006667014  bl       #0x382bd14 ; 
006667018  mov      w8, #1
00666701C  strb     w8, [x24, #0xd61]
006667020  adrp     x8, #0x8eff000
006667024  ldr      x8, [x8, #0x538] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_id() @ 0x9285d88
006667028  ldr      x1, [x8]
00666702C  ldrb     w8, [x1, #0x53]
006667030  tbnz     w8, #5, #0x666703c
006667034  ldr      w23, [x23, #0x20]
006667038  b        #0x666704c ; 
00666703C  ldr      x8, [x1, #0x60]
006667040  mov      x0, x23
006667044  blr      x8
006667048  mov      w23, w0
00666704C  adrp     x8, #0x8ee8000
006667050  ldr      x8, [x8, #0x838] ; GLOBAL Method$System.Nullable<FP>..ctor() @ 0x9227b20
006667054  mov      x0, sp
006667058  mov      x1, x21
00666705C  stp      xzr, xzr, [sp]
006667060  ldr      x2, [x8]
006667064  bl       #0x51328c0 ; System.Nullable<FP>$$.ctor
006667068  cbz      x22, #0x6667270
00666706C  ldp      x3, x4, [sp]
006667070  mov      x0, x22
006667074  mov      w1, w23
006667078  mov      w2, wzr
00666707C  mov      x5, xzr
006667080  bl       #0x667a728 ; 
006667084  ldrb     w8, [x25, #0xa4b]
006667088  cbnz     w8, #0x66670a0
00666708C  adrp     x0, #0x8ee5000
006667090  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006667094  bl       #0x382bd14 ; 
006667098  mov      w8, #1
00666709C  strb     w8, [x25, #0xa4b]
0066670A0  ldr      x1, [x26]
0066670A4  ldrb     w8, [x1, #0x53]
0066670A8  tbnz     w8, #5, #0x66670b4
0066670AC  ldr      x21, [x19, #0x20]
0066670B0  b        #0x66670c4 ; 
0066670B4  ldr      x8, [x1, #0x60]
0066670B8  mov      x0, x19
0066670BC  blr      x8
0066670C0  mov      x21, x0
0066670C4  cbz      x21, #0x6667270
0066670C8  adrp     x22, #0x9598000
0066670CC  ldrb     w8, [x22, #0xfc4]
0066670D0  cbnz     w8, #0x66670e8
0066670D4  adrp     x0, #0x8f05000
0066670D8  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0066670DC  bl       #0x382bd14 ; 
0066670E0  mov      w8, #1
0066670E4  strb     w8, [x22, #0xfc4]
0066670E8  adrp     x8, #0x8f05000
0066670EC  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0066670F0  ldr      x1, [x8]
0066670F4  ldrb     w8, [x1, #0x53]
0066670F8  tbnz     w8, #5, #0x6667104
0066670FC  ldr      x0, [x21, #0x220]
006667100  b        #0x6667110 ; 
006667104  ldr      x8, [x1, #0x60]
006667108  mov      x0, x21
00666710C  blr      x8
006667110  cbz      x0, #0x6667270
006667114  ldr      x8, [x0]
006667118  ldp      x9, x1, [x8, #0x198]
00666711C  blr      x9
006667120  cmp      w0, #7
006667124  b.ne     #0x666720c
006667128  adrp     x8, #0x8ee6000
00666712C  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006667130  ldr      x1, [x8]
006667134  ldrb     w8, [x1, #0x53]
006667138  tbnz     w8, #5, #0x6667144
00666713C  ldr      x21, [x20, #0x38]
006667140  b        #0x6667154 ; 
006667144  ldr      x8, [x1, #0x60]
006667148  mov      x0, x20
00666714C  blr      x8
006667150  mov      x21, x0
006667154  cbz      x21, #0x6667270
006667158  ldrb     w8, [x27, #0xa7f]
00666715C  cbnz     w8, #0x6667174
006667160  adrp     x0, #0x8ee6000
006667164  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006667168  bl       #0x382bd14 ; 
00666716C  mov      w8, #1
006667170  strb     w8, [x27, #0xa7f]
006667174  ldr      x1, [x29]
006667178  ldrb     w8, [x1, #0x53]
00666717C  tbnz     w8, #5, #0x6667188
006667180  ldr      x0, [x21, #0x178]
006667184  b        #0x6667194 ; 
006667188  ldr      x8, [x1, #0x60]
00666718C  mov      x0, x21
006667190  blr      x8
006667194  cbz      x0, #0x6667270
006667198  adrp     x8, #0x8f0f000
00666719C  ldr      x8, [x8, #0x300] ; GLOBAL AddExp% @ 0x92f00b8
0066671A0  mov      x2, xzr
0066671A4  ldr      x1, [x8]
0066671A8  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
0066671AC  adrp     x8, #0x8f09000
0066671B0  ldr      x8, [x8, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
0066671B4  mov      x21, x0
0066671B8  mov      x0, x20
0066671BC  ldr      x1, [x8]
0066671C0  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0066671C4  ldr      x1, [x28]
0066671C8  mov      x22, x0
0066671CC  ldrb     w8, [x1, #0x53]
0066671D0  tbnz     w8, #5, #0x66671dc
0066671D4  ldr      x0, [x19, #0x38]
0066671D8  b        #0x66671e8 ; 
0066671DC  ldr      x8, [x1, #0x60]
0066671E0  mov      x0, x19
0066671E4  blr      x8
0066671E8  cbz      x0, #0x6667270
0066671EC  cbz      x22, #0x6667270
0066671F0  ldr      x8, [x0, #0xc0]
0066671F4  add      x9, x21, #0x10, lsl #12
0066671F8  mov      x0, x22
0066671FC  mov      x2, xzr
006667200  mul      x8, x8, x9
006667204  asr      x1, x8, #0x10
006667208  bl       #0x6858484 ; HotFix.BattleLogic.HeroComponentExp$$AddExp
00666720C  mov      x0, x20
006667210  mov      x1, xzr
006667214  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
006667218  tbnz     w0, #0, #0x6667250
00666721C  ldr      x8, [x19]
006667220  mov      x0, x19
006667224  mov      x1, x20
006667228  ldr      x9, [x8, #0x368]
00666722C  ldr      x2, [x8, #0x370]
006667230  blr      x9
006667234  ldr      x8, [x19]
006667238  mov      w2, #2
00666723C  mov      x0, x19
006667240  mov      x1, x20
006667244  ldr      x9, [x8, #0x378]
006667248  ldr      x3, [x8, #0x380]
00666724C  blr      x9
006667250  ldp      x20, x19, [sp, #0x60]
006667254  ldp      x22, x21, [sp, #0x50]
006667258  ldp      x24, x23, [sp, #0x40]
00666725C  ldp      x26, x25, [sp, #0x30]
006667260  ldp      x28, x27, [sp, #0x20]
006667264  ldp      x29, x30, [sp, #0x10]
006667268  add      sp, sp, #0x70
00666726C  ret      
006667270  bl       #0x382bfb8 ; 

