; HotFix.BattleLogic.WaterfallBattleManager$$CreateRandomMonster
0065CE604  subs     x22, x22, #1
0065CE608  add      x20, x20, x21
0065CE60C  b.ne     #0x65ce5e0
0065CE610  ldp      x20, x19, [sp, #0x20]
0065CE614  ldp      x22, x21, [sp, #0x10]
0065CE618  ldr      x30, [sp], #0x30
0065CE61C  ret      
0065CE620  bl       #0x382bfb8 ; 
0065CE624  bl       #0x382bfc0 ; 
