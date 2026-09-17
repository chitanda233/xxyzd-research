; HotFix.BattleLogic.HeroComponentRandomSkill.<>c__DisplayClass68_0$$.ctor
; RVA 0x687039C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687039C  stp      x30, x21, [sp, #-0x20]!
0068703A0  stp      x20, x19, [sp, #0x10]
0068703A4  adrp     x20, #0x959b000
0068703A8  adrp     x21, #0x8f24000
0068703AC  ldrb     w8, [x20, #0xa72]
0068703B0  ldr      x21, [x21, #0x318]
0068703B4  mov      x19, x0
0068703B8  tbnz     w8, #0, #0x68703d0
0068703BC  adrp     x0, #0x8f24000
0068703C0  ldr      x0, [x0, #0x318]
0068703C4  bl       #0x382bd14 ; 
0068703C8  mov      w8, #1
0068703CC  strb     w8, [x20, #0xa72]
0068703D0  ldr      x1, [x21]
0068703D4  ldrb     w8, [x1, #0x53]
0068703D8  tbnz     w8, #5, #0x68703f0
0068703DC  mov      x0, x19
0068703E0  ldp      x20, x19, [sp, #0x10]
0068703E4  mov      x1, xzr
0068703E8  ldp      x30, x21, [sp], #0x20
0068703EC  b        #0x7c335dc ; System.Object$$.ctor
0068703F0  ldr      x2, [x1, #0x60]
0068703F4  mov      x0, x19
0068703F8  ldp      x20, x19, [sp, #0x10]
0068703FC  ldp      x30, x21, [sp], #0x20
006870400  br       x2

; HotFix.BattleLogic.HeroComponentRandomSkill.<>c__DisplayClass68_0$$<ResolveSkillIconId>b__0
; RVA 0x6871BD0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871BD0  str      x30, [sp, #-0x30]!
006871BD4  stp      x22, x21, [sp, #0x10]
006871BD8  stp      x20, x19, [sp, #0x20]
006871BDC  adrp     x21, #0x959b000
006871BE0  adrp     x22, #0x8f24000
006871BE4  ldrb     w8, [x21, #0xa73]
006871BE8  ldr      x22, [x22, #0x300]
006871BEC  mov      x20, x1
006871BF0  mov      x19, x0
006871BF4  tbnz     w8, #0, #0x6871c0c
006871BF8  adrp     x0, #0x8f24000
006871BFC  ldr      x0, [x0, #0x300]
006871C00  bl       #0x382bd14 ; 
006871C04  mov      w8, #1
006871C08  strb     w8, [x21, #0xa73]
006871C0C  ldr      x2, [x22]
006871C10  ldrb     w8, [x2, #0x53]
006871C14  tbnz     w8, #5, #0x6871c58
006871C18  cbz      x20, #0x6871c9c
006871C1C  adrp     x21, #0x9598000
006871C20  ldrb     w8, [x21, #0xde3]
006871C24  cbnz     w8, #0x6871c3c
006871C28  adrp     x0, #0x8f00000
006871C2C  ldr      x0, [x0, #0xd98]
006871C30  bl       #0x382bd14 ; 
006871C34  mov      w8, #1
006871C38  strb     w8, [x21, #0xde3]
006871C3C  adrp     x8, #0x8f00000
006871C40  ldr      x8, [x8, #0xd98]
006871C44  ldr      x1, [x8]
006871C48  ldrb     w8, [x1, #0x53]
006871C4C  tbnz     w8, #5, #0x6871c74
006871C50  ldr      w0, [x20, #0x20]
006871C54  b        #0x6871c80 ; 
006871C58  ldr      x3, [x2, #0x60]
006871C5C  mov      x0, x19
006871C60  mov      x1, x20
006871C64  ldp      x20, x19, [sp, #0x20]
006871C68  ldp      x22, x21, [sp, #0x10]
006871C6C  ldr      x30, [sp], #0x30
006871C70  br       x3
006871C74  ldr      x8, [x1, #0x60]
006871C78  mov      x0, x20
006871C7C  blr      x8
006871C80  ldr      w8, [x19, #0x10]
006871C84  ldp      x20, x19, [sp, #0x20]
006871C88  ldp      x22, x21, [sp, #0x10]
006871C8C  cmp      w0, w8
006871C90  cset     w0, eq
006871C94  ldr      x30, [sp], #0x30
006871C98  ret      
006871C9C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.HeroComponentRandomSkill.<>c__DisplayClass68_0$$<ResolveSkillIconId>b__1
; RVA 0x6871CA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006871CA0  str      x30, [sp, #-0x30]!
006871CA4  stp      x22, x21, [sp, #0x10]
006871CA8  stp      x20, x19, [sp, #0x20]
006871CAC  adrp     x21, #0x959b000
006871CB0  adrp     x22, #0x8f24000
006871CB4  ldrb     w8, [x21, #0xa74]
006871CB8  ldr      x22, [x22, #0x308]
006871CBC  mov      x20, x1
006871CC0  mov      x19, x0
006871CC4  tbnz     w8, #0, #0x6871cdc
006871CC8  adrp     x0, #0x8f24000
006871CCC  ldr      x0, [x0, #0x308]
006871CD0  bl       #0x382bd14 ; 
006871CD4  mov      w8, #1
006871CD8  strb     w8, [x21, #0xa74]
006871CDC  ldr      x2, [x22]
006871CE0  ldrb     w8, [x2, #0x53]
006871CE4  tbnz     w8, #5, #0x6871d28
006871CE8  cbz      x20, #0x6871dbc
006871CEC  adrp     x21, #0x9598000
006871CF0  ldrb     w8, [x21, #0xde3]
006871CF4  cbnz     w8, #0x6871d0c
006871CF8  adrp     x0, #0x8f00000
006871CFC  ldr      x0, [x0, #0xd98]
006871D00  bl       #0x382bd14 ; 
006871D04  mov      w8, #1
006871D08  strb     w8, [x21, #0xde3]
006871D0C  adrp     x8, #0x8f00000
006871D10  ldr      x8, [x8, #0xd98]
006871D14  ldr      x1, [x8]
006871D18  ldrb     w8, [x1, #0x53]
006871D1C  tbnz     w8, #5, #0x6871d44
006871D20  ldr      w20, [x20, #0x20]
006871D24  b        #0x6871d54 ; 
006871D28  ldr      x3, [x2, #0x60]
006871D2C  mov      x0, x19
006871D30  mov      x1, x20
006871D34  ldp      x20, x19, [sp, #0x20]
006871D38  ldp      x22, x21, [sp, #0x10]
006871D3C  ldr      x30, [sp], #0x30
006871D40  br       x3
006871D44  ldr      x8, [x1, #0x60]
006871D48  mov      x0, x20
006871D4C  blr      x8
006871D50  mov      w20, w0
006871D54  ldr      x19, [x19, #0x18]
006871D58  cbz      x19, #0x6871dbc
006871D5C  adrp     x21, #0x959b000
006871D60  ldrb     w8, [x21, #0xb8e]
006871D64  cbnz     w8, #0x6871d7c
006871D68  adrp     x0, #0x8f23000
006871D6C  ldr      x0, [x0, #0xd10]
006871D70  bl       #0x382bd14 ; 
006871D74  mov      w8, #1
006871D78  strb     w8, [x21, #0xb8e]
006871D7C  adrp     x8, #0x8f23000
006871D80  ldr      x8, [x8, #0xd10]
006871D84  ldr      x1, [x8]
006871D88  ldrb     w8, [x1, #0x53]
006871D8C  tbnz     w8, #5, #0x6871d98
006871D90  ldr      w0, [x19, #0xa4]
006871D94  b        #0x6871da4 ; 
006871D98  ldr      x8, [x1, #0x60]
006871D9C  mov      x0, x19
006871DA0  blr      x8
006871DA4  cmp      w20, w0
006871DA8  ldp      x20, x19, [sp, #0x20]
006871DAC  ldp      x22, x21, [sp, #0x10]
006871DB0  cset     w0, eq
006871DB4  ldr      x30, [sp], #0x30
006871DB8  ret      
006871DBC  bl       #0x382bfb8 ; 

