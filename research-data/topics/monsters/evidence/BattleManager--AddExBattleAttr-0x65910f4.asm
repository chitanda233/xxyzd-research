; HotFix.BattleLogic.BattleManager$$AddExBattleAttr
; RVA 0x65910F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065910F4  stp      x29, x30, [sp, #-0x60]!
0065910F8  stp      x28, x27, [sp, #0x10]
0065910FC  stp      x26, x25, [sp, #0x20]
006591100  stp      x24, x23, [sp, #0x30]
006591104  stp      x22, x21, [sp, #0x40]
006591108  stp      x20, x19, [sp, #0x50]
00659110C  adrp     x24, #0x9599000
006591110  adrp     x25, #0x8f08000
006591114  ldrb     w8, [x24, #0x244]
006591118  ldr      x25, [x25, #0x820] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.AddExBattleAttr()
00659111C  mov      x19, x4
006591120  mov      x21, x3
006591124  mov      x22, x2
006591128  mov      x23, x1
00659112C  mov      x20, x0
006591130  tbnz     w8, #0, #0x6591178
006591134  adrp     x0, #0x8f08000
006591138  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.AddExBattleAttr()
00659113C  bl       #0x382bd14 ; 
006591140  adrp     x0, #0x8f08000
006591144  ldr      x0, [x0, #0x828] ; GLOBAL AddExpMission
006591148  bl       #0x382bd14 ; 
00659114C  adrp     x0, #0x8f08000
006591150  ldr      x0, [x0, #0x830] ; GLOBAL HPPickUpAddMission
006591154  bl       #0x382bd14 ; 
006591158  adrp     x0, #0x8f08000
00659115C  ldr      x0, [x0, #0x838] ; GLOBAL AttackMission
006591160  bl       #0x382bd14 ; 
006591164  adrp     x0, #0x8f08000
006591168  ldr      x0, [x0, #0x840] ; GLOBAL HPMaxMission
00659116C  bl       #0x382bd14 ; 
006591170  mov      w8, #1
006591174  strb     w8, [x24, #0x244]
006591178  ldr      x5, [x25]
00659117C  ldrb     w8, [x5, #0x53]
006591180  tbnz     w8, #5, #0x65911c0
006591184  adrp     x26, #0x9599000
006591188  ldrb     w8, [x26, #0x286]
00659118C  cbnz     w8, #0x65911a4
006591190  adrp     x0, #0x8f07000
006591194  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591198  bl       #0x382bd14 ; 
00659119C  mov      w8, #1
0065911A0  strb     w8, [x26, #0x286]
0065911A4  adrp     x28, #0x8f07000
0065911A8  ldr      x28, [x28, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065911AC  ldr      x1, [x28]
0065911B0  ldrb     w8, [x1, #0x53]
0065911B4  tbnz     w8, #5, #0x65911f4
0065911B8  ldr      x24, [x20, #0x80]
0065911BC  b        #0x6591204 ; 
0065911C0  ldr      x6, [x5, #0x60]
0065911C4  mov      x0, x20
0065911C8  mov      x1, x23
0065911CC  mov      x2, x22
0065911D0  mov      x3, x21
0065911D4  mov      x4, x19
0065911D8  ldp      x20, x19, [sp, #0x50]
0065911DC  ldp      x22, x21, [sp, #0x40]
0065911E0  ldp      x24, x23, [sp, #0x30]
0065911E4  ldp      x26, x25, [sp, #0x20]
0065911E8  ldp      x28, x27, [sp, #0x10]
0065911EC  ldp      x29, x30, [sp], #0x60
0065911F0  br       x6
0065911F4  ldr      x8, [x1, #0x60]
0065911F8  mov      x0, x20
0065911FC  blr      x8
006591200  mov      x24, x0
006591204  cbz      x24, #0x659147c
006591208  adrp     x8, #0x8f08000
00659120C  ldr      x8, [x8, #0x840] ; GLOBAL HPMaxMission
006591210  adrp     x27, #0x9599000
006591214  ldrb     w9, [x27, #0x2bc]
006591218  ldr      x25, [x8]
00659121C  cbnz     w9, #0x6591234
006591220  adrp     x0, #0x8f08000
006591224  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleAttr()
006591228  bl       #0x382bd14 ; 
00659122C  mov      w8, #1
006591230  strb     w8, [x27, #0x2bc]
006591234  adrp     x29, #0x8f08000
006591238  ldr      x29, [x29, #0x848] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleAttr()
00659123C  ldr      x3, [x29]
006591240  ldrb     w8, [x3, #0x53]
006591244  tbnz     w8, #5, #0x659125c
006591248  add      x0, x24, #0x290
00659124C  mov      x1, x25
006591250  mov      x2, x23
006591254  bl       #0x658eef4 ; HotFix.BattleLogic.BattleData$$AddExBattleAttr
006591258  b        #0x6591270 ; 
00659125C  ldr      x8, [x3, #0x60]
006591260  mov      x0, x24
006591264  mov      x1, x25
006591268  mov      x2, x23
00659126C  blr      x8
006591270  ldrb     w8, [x26, #0x286]
006591274  cbnz     w8, #0x659128c
006591278  adrp     x0, #0x8f07000
00659127C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591280  bl       #0x382bd14 ; 
006591284  mov      w8, #1
006591288  strb     w8, [x26, #0x286]
00659128C  ldr      x1, [x28]
006591290  ldrb     w8, [x1, #0x53]
006591294  tbnz     w8, #5, #0x65912a0
006591298  ldr      x23, [x20, #0x80]
00659129C  b        #0x65912b0 ; 
0065912A0  ldr      x8, [x1, #0x60]
0065912A4  mov      x0, x20
0065912A8  blr      x8
0065912AC  mov      x23, x0
0065912B0  cbz      x23, #0x659147c
0065912B4  adrp     x8, #0x8f08000
0065912B8  ldr      x8, [x8, #0x838] ; GLOBAL AttackMission
0065912BC  ldrb     w9, [x27, #0x2bc]
0065912C0  ldr      x24, [x8]
0065912C4  cbnz     w9, #0x65912dc
0065912C8  adrp     x0, #0x8f08000
0065912CC  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleAttr()
0065912D0  bl       #0x382bd14 ; 
0065912D4  mov      w8, #1
0065912D8  strb     w8, [x27, #0x2bc]
0065912DC  ldr      x3, [x29]
0065912E0  ldrb     w8, [x3, #0x53]
0065912E4  tbnz     w8, #5, #0x65912fc
0065912E8  add      x0, x23, #0x290
0065912EC  mov      x1, x24
0065912F0  mov      x2, x22
0065912F4  bl       #0x658eef4 ; HotFix.BattleLogic.BattleData$$AddExBattleAttr
0065912F8  b        #0x6591310 ; 
0065912FC  ldr      x8, [x3, #0x60]
006591300  mov      x0, x23
006591304  mov      x1, x24
006591308  mov      x2, x22
00659130C  blr      x8
006591310  ldrb     w8, [x26, #0x286]
006591314  cbnz     w8, #0x659132c
006591318  adrp     x0, #0x8f07000
00659131C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591320  bl       #0x382bd14 ; 
006591324  mov      w8, #1
006591328  strb     w8, [x26, #0x286]
00659132C  ldr      x1, [x28]
006591330  ldrb     w8, [x1, #0x53]
006591334  tbnz     w8, #5, #0x6591340
006591338  ldr      x22, [x20, #0x80]
00659133C  b        #0x6591350 ; 
006591340  ldr      x8, [x1, #0x60]
006591344  mov      x0, x20
006591348  blr      x8
00659134C  mov      x22, x0
006591350  cbz      x22, #0x659147c
006591354  adrp     x8, #0x8f08000
006591358  ldr      x8, [x8, #0x828] ; GLOBAL AddExpMission
00659135C  ldrb     w9, [x27, #0x2bc]
006591360  ldr      x23, [x8]
006591364  cbnz     w9, #0x659137c
006591368  adrp     x0, #0x8f08000
00659136C  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleAttr()
006591370  bl       #0x382bd14 ; 
006591374  mov      w8, #1
006591378  strb     w8, [x27, #0x2bc]
00659137C  ldr      x3, [x29]
006591380  ldrb     w8, [x3, #0x53]
006591384  tbnz     w8, #5, #0x659139c
006591388  add      x0, x22, #0x290
00659138C  mov      x1, x23
006591390  mov      x2, x21
006591394  bl       #0x658eef4 ; HotFix.BattleLogic.BattleData$$AddExBattleAttr
006591398  b        #0x65913b0 ; 
00659139C  ldr      x8, [x3, #0x60]
0065913A0  mov      x0, x22
0065913A4  mov      x1, x23
0065913A8  mov      x2, x21
0065913AC  blr      x8
0065913B0  ldrb     w8, [x26, #0x286]
0065913B4  cbnz     w8, #0x65913cc
0065913B8  adrp     x0, #0x8f07000
0065913BC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065913C0  bl       #0x382bd14 ; 
0065913C4  mov      w8, #1
0065913C8  strb     w8, [x26, #0x286]
0065913CC  ldr      x1, [x28]
0065913D0  ldrb     w8, [x1, #0x53]
0065913D4  tbnz     w8, #5, #0x65913e0
0065913D8  ldr      x20, [x20, #0x80]
0065913DC  b        #0x65913f0 ; 
0065913E0  ldr      x8, [x1, #0x60]
0065913E4  mov      x0, x20
0065913E8  blr      x8
0065913EC  mov      x20, x0
0065913F0  cbz      x20, #0x659147c
0065913F4  adrp     x8, #0x8f08000
0065913F8  ldr      x8, [x8, #0x830] ; GLOBAL HPPickUpAddMission
0065913FC  ldrb     w9, [x27, #0x2bc]
006591400  ldr      x21, [x8]
006591404  cbnz     w9, #0x659141c
006591408  adrp     x0, #0x8f08000
00659140C  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleAttr()
006591410  bl       #0x382bd14 ; 
006591414  mov      w8, #1
006591418  strb     w8, [x27, #0x2bc]
00659141C  ldr      x3, [x29]
006591420  ldrb     w8, [x3, #0x53]
006591424  tbnz     w8, #5, #0x6591450
006591428  add      x0, x20, #0x290
00659142C  mov      x1, x21
006591430  mov      x2, x19
006591434  ldp      x20, x19, [sp, #0x50]
006591438  ldp      x22, x21, [sp, #0x40]
00659143C  ldp      x24, x23, [sp, #0x30]
006591440  ldp      x26, x25, [sp, #0x20]
006591444  ldp      x28, x27, [sp, #0x10]
006591448  ldp      x29, x30, [sp], #0x60
00659144C  b        #0x658eef4 ; HotFix.BattleLogic.BattleData$$AddExBattleAttr
006591450  ldr      x4, [x3, #0x60]
006591454  mov      x0, x20
006591458  mov      x1, x21
00659145C  mov      x2, x19
006591460  ldp      x20, x19, [sp, #0x50]
006591464  ldp      x22, x21, [sp, #0x40]
006591468  ldp      x24, x23, [sp, #0x30]
00659146C  ldp      x26, x25, [sp, #0x20]
006591470  ldp      x28, x27, [sp, #0x10]
006591474  ldp      x29, x30, [sp], #0x60
006591478  br       x4
00659147C  bl       #0x382bfb8 ; 

