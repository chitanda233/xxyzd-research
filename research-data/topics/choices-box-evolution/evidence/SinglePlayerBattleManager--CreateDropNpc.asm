; HotFix.BattleLogic.SinglePlayerBattleManager$$CreateDropNpc
; RVA 0x65C0C04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C0C04  sub      sp, sp, #0xa0
0065C0C08  str      x30, [sp, #0x60]
0065C0C0C  stp      x24, x23, [sp, #0x70]
0065C0C10  stp      x22, x21, [sp, #0x80]
0065C0C14  stp      x20, x19, [sp, #0x90]
0065C0C18  mrs      x23, tpidr_el0
0065C0C1C  ldr      x8, [x23, #0x28]
0065C0C20  adrp     x22, #0x9599000
0065C0C24  adrp     x24, #0x8f0a000
0065C0C28  mov      x20, x2
0065C0C2C  str      x8, [sp, #0x58]
0065C0C30  ldrb     w8, [x22, #0x535]
0065C0C34  ldr      x24, [x24, #0x3c8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.CreateDropNpc() @ 0x92aa828
0065C0C38  mov      w19, w1
0065C0C3C  mov      x21, x0
0065C0C40  tbnz     w8, #0, #0x65c0c58
0065C0C44  adrp     x0, #0x8f0a000
0065C0C48  ldr      x0, [x0, #0x3c8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.CreateDropNpc() @ 0x92aa828
0065C0C4C  bl       #0x382bd14 ; 
0065C0C50  mov      w8, #1
0065C0C54  strb     w8, [x22, #0x535]
0065C0C58  ldr      x3, [x24]
0065C0C5C  ldrb     w8, [x3, #0x53]
0065C0C60  tbnz     w8, #5, #0x65c0ca0
0065C0C64  adrp     x22, #0x9599000
0065C0C68  ldrb     w8, [x22, #0x286]
0065C0C6C  cbnz     w8, #0x65c0c84
0065C0C70  adrp     x0, #0x8f07000
0065C0C74  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C0C78  bl       #0x382bd14 ; 
0065C0C7C  mov      w8, #1
0065C0C80  strb     w8, [x22, #0x286]
0065C0C84  adrp     x8, #0x8f07000
0065C0C88  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065C0C8C  ldr      x1, [x8]
0065C0C90  ldrb     w8, [x1, #0x53]
0065C0C94  tbnz     w8, #5, #0x65c0cc8
0065C0C98  ldr      x22, [x21, #0x80]
0065C0C9C  b        #0x65c0cd8 ; 
0065C0CA0  ldr      x8, [x20, #0x10]
0065C0CA4  ldr      q0, [x20]
0065C0CA8  ldr      x9, [x3, #0x60]
0065C0CAC  add      x2, sp, #0x40
0065C0CB0  mov      x0, x21
0065C0CB4  mov      w1, w19
0065C0CB8  str      x8, [sp, #0x50]
0065C0CBC  str      q0, [sp, #0x40]
0065C0CC0  blr      x9
0065C0CC4  b        #0x65c0d7c ; 
0065C0CC8  ldr      x8, [x1, #0x60]
0065C0CCC  mov      x0, x21
0065C0CD0  blr      x8
0065C0CD4  mov      x22, x0
0065C0CD8  cbz      x22, #0x65c0da4
0065C0CDC  adrp     x24, #0x9599000
0065C0CE0  ldrb     w8, [x24, #0x287]
0065C0CE4  cbnz     w8, #0x65c0cfc
0065C0CE8  adrp     x0, #0x8f07000
0065C0CEC  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
0065C0CF0  bl       #0x382bd14 ; 
0065C0CF4  mov      w8, #1
0065C0CF8  strb     w8, [x24, #0x287]
0065C0CFC  adrp     x8, #0x8f07000
0065C0D00  ldr      x8, [x8, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
0065C0D04  ldr      x1, [x8]
0065C0D08  ldrb     w8, [x1, #0x53]
0065C0D0C  tbnz     w8, #5, #0x65c0d18
0065C0D10  ldr      x22, [x22, #0x350]
0065C0D14  b        #0x65c0d28 ; 
0065C0D18  ldr      x8, [x1, #0x60]
0065C0D1C  mov      x0, x22
0065C0D20  blr      x8
0065C0D24  mov      x22, x0
0065C0D28  ldr      x0, [x21, #0x88]
0065C0D2C  cbz      x0, #0x65c0da4
0065C0D30  mov      x1, xzr
0065C0D34  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
0065C0D38  ldr      x8, [x20, #0x10]
0065C0D3C  ldr      q0, [x20]
0065C0D40  str      x8, [sp, #0x30]
0065C0D44  str      q0, [sp, #0x20]
0065C0D48  cbz      x22, #0x65c0da4
0065C0D4C  ldr      q0, [sp, #0x20]
0065C0D50  ldr      x8, [sp, #0x30]
0065C0D54  mov      w2, w0
0065C0D58  mov      x3, sp
0065C0D5C  mov      w4, #1
0065C0D60  mov      x0, x22
0065C0D64  mov      w1, w19
0065C0D68  mov      w5, wzr
0065C0D6C  mov      x6, xzr
0065C0D70  str      q0, [sp]
0065C0D74  str      x8, [sp, #0x10]
0065C0D78  bl       #0x666deb0 ; HotFix.BattleLogic.DropMgr$$AddDropNpc
0065C0D7C  ldr      x8, [x23, #0x28]
0065C0D80  ldr      x9, [sp, #0x58]
0065C0D84  cmp      x8, x9
0065C0D88  b.ne     #0x65c0da8
0065C0D8C  ldp      x20, x19, [sp, #0x90]
0065C0D90  ldp      x22, x21, [sp, #0x80]
0065C0D94  ldp      x24, x23, [sp, #0x70]
0065C0D98  ldr      x30, [sp, #0x60]
0065C0D9C  add      sp, sp, #0xa0
0065C0DA0  ret      
0065C0DA4  bl       #0x382bfb8 ; 
0065C0DA8  bl       #0x89edb60 ; 

