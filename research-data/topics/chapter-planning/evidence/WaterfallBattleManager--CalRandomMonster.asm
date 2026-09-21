; HotFix.BattleLogic.WaterfallBattleManager$$CalRandomMonster
0065D0E3C  cbz      x22, #0x65d0eb8
0065D0E40  cbz      x23, #0x65d0eb8
0065D0E44  cbz      x0, #0x65d0eb8
0065D0E48  ldr      w8, [x23, #0x14]
0065D0E4C  ldr      w9, [x22, #0x14]
0065D0E50  ldr      w10, [x0, #0x14]
0065D0E54  ldr      w11, [x19, #0x148]
0065D0E58  add      w8, w9, w8
0065D0E5C  add      w8, w8, w10
0065D0E60  madd     w8, w8, w21, w11
0065D0E64  str      w8, [x19, #0x148]
0065D0E68  ldr      w8, [x22, #0x10]
0065D0E6C  ldr      w9, [x23, #0x10]
0065D0E70  ldr      w10, [x0, #0x10]
0065D0E74  ldr      w11, [x19, #0x14c]
0065D0E78  add      w8, w9, w8
0065D0E7C  add      w8, w8, w10
0065D0E80  madd     w8, w8, w21, w11
0065D0E84  str      w8, [x19, #0x14c]
0065D0E88  ldr      w8, [x22, #0x18]
0065D0E8C  ldr      w9, [x23, #0x18]
0065D0E90  ldr      w10, [x0, #0x18]
0065D0E94  ldr      w11, [x19, #0x150]
0065D0E98  add      w8, w9, w8
0065D0E9C  add      w8, w8, w10
0065D0EA0  madd     w8, w8, w21, w11
0065D0EA4  str      w8, [x19, #0x150]
0065D0EA8  ldp      x20, x19, [sp, #0x20]
0065D0EAC  ldp      x22, x21, [sp, #0x10]
0065D0EB0  ldp      x30, x23, [sp], #0x30
0065D0EB4  ret      
0065D0EB8  bl       #0x382bfb8 ; 
0065D0EBC  bl       #0x382bfc0 ; 
