; HotFix.BattleLogic.MonsterMoveToPoint$$OnStart
; RVA 0x661BDBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661BDBC  sub      sp, sp, #0x90
00661BDC0  str      x30, [sp, #0x60]
00661BDC4  stp      x22, x21, [sp, #0x70]
00661BDC8  stp      x20, x19, [sp, #0x80]
00661BDCC  mrs      x20, tpidr_el0
00661BDD0  ldr      x8, [x20, #0x28]
00661BDD4  adrp     x21, #0x9599000
00661BDD8  adrp     x22, #0x8f0c000
00661BDDC  mov      x19, x0
00661BDE0  str      x8, [sp, #0x58]
00661BDE4  ldrb     w8, [x21, #0x8b5]
00661BDE8  ldr      x22, [x22, #0x590] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.OnStart()
00661BDEC  tbnz     w8, #0, #0x661be10
00661BDF0  adrp     x0, #0x8f0a000
00661BDF4  ldr      x0, [x0, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
00661BDF8  bl       #0x382bd14 ; 
00661BDFC  adrp     x0, #0x8f0c000
00661BE00  ldr      x0, [x0, #0x590] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint.OnStart()
00661BE04  bl       #0x382bd14 ; 
00661BE08  mov      w8, #1
00661BE0C  strb     w8, [x21, #0x8b5]
00661BE10  ldr      x1, [x22]
00661BE14  ldrb     w8, [x1, #0x53]
00661BE18  tbnz     w8, #5, #0x661bec8
00661BE1C  ldr      x8, [x19, #0xc0]
00661BE20  cbz      x8, #0x661be50
00661BE24  ldr      x9, [x8, #0x18]
00661BE28  ldr      x0, [x8, #0x40]
00661BE2C  ldr      x1, [x8, #0x28]
00661BE30  add      x8, sp, #0x28
00661BE34  blr      x9
00661BE38  ldr      x8, [sp, #0x38]
00661BE3C  ldur     q0, [sp, #0x28]
00661BE40  str      x8, [sp, #0x50]
00661BE44  str      q0, [sp, #0x40]
00661BE48  str      x8, [x19, #0x98]
00661BE4C  stur     q0, [x19, #0x88]
00661BE50  ldur     q0, [x19, #0x88]
00661BE54  ldr      x8, [x19, #0x98]
00661BE58  ldrb     w9, [x19, #0xb9]
00661BE5C  str      q0, [x19, #0xa0]
00661BE60  str      x8, [x19, #0xb0]
00661BE64  cbz      w9, #0x661bf50
00661BE68  ldr      q0, [x19, #0xa0]
00661BE6C  ldr      q1, [x19, #0x70]
00661BE70  ldr      x8, [x19, #0xb0]
00661BE74  ldr      x9, [x19, #0x80]
00661BE78  sub      v0.2d, v0.2d, v1.2d
00661BE7C  sub      x21, x8, x9
00661BE80  mov      x9, v0.d[1]
00661BE84  fmov     x8, d0
00661BE88  mul      x9, x9, x9
00661BE8C  mul      x8, x8, x8
00661BE90  asr      x9, x9, #0x10
00661BE94  add      x8, x9, x8, asr #16
00661BE98  mul      x9, x21, x21
00661BE9C  add      x8, x8, x9, asr #16
00661BEA0  cmp      x8, #1
00661BEA4  b.lt     #0x661bf50
00661BEA8  adrp     x8, #0x8f0a000
00661BEAC  ldr      x8, [x8, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
00661BEB0  str      q0, [sp]
00661BEB4  ldr      x1, [x8]
00661BEB8  ldrb     w8, [x1, #0x53]
00661BEBC  tbnz     w8, #5, #0x661bed8
00661BEC0  ldr      x19, [x19, #0x58]
00661BEC4  b        #0x661bee8 ; 
00661BEC8  ldr      x8, [x1, #0x60]
00661BECC  mov      x0, x19
00661BED0  blr      x8
00661BED4  b        #0x661bf50 ; 
00661BED8  ldr      x8, [x1, #0x60]
00661BEDC  mov      x0, x19
00661BEE0  blr      x8
00661BEE4  mov      x19, x0
00661BEE8  cbz      x19, #0x661bf74
00661BEEC  adrp     x22, #0x9598000
00661BEF0  ldrb     w8, [x22, #0xfb7]
00661BEF4  cbnz     w8, #0x661bf0c
00661BEF8  adrp     x0, #0x8f05000
00661BEFC  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00661BF00  bl       #0x382bd14 ; 
00661BF04  mov      w8, #1
00661BF08  strb     w8, [x22, #0xfb7]
00661BF0C  adrp     x8, #0x8f05000
00661BF10  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00661BF14  ldr      x1, [x8]
00661BF18  ldrb     w8, [x1, #0x53]
00661BF1C  tbnz     w8, #5, #0x661bf28
00661BF20  ldr      x0, [x19, #0x118]
00661BF24  b        #0x661bf34 ; 
00661BF28  ldr      x8, [x1, #0x60]
00661BF2C  mov      x0, x19
00661BF30  blr      x8
00661BF34  ldr      q0, [sp]
00661BF38  cbz      x0, #0x661bf74
00661BF3C  add      x1, sp, #0x10
00661BF40  mov      x2, xzr
00661BF44  str      q0, [sp, #0x10]
00661BF48  str      x21, [sp, #0x20]
00661BF4C  bl       #0x672c948 ; HotFix.BattleLogic.CharacterComponentTransform$$LookRotationDir
00661BF50  ldr      x8, [x20, #0x28]
00661BF54  ldr      x9, [sp, #0x58]
00661BF58  cmp      x8, x9
00661BF5C  b.ne     #0x661bf78
00661BF60  ldp      x20, x19, [sp, #0x80]
00661BF64  ldp      x22, x21, [sp, #0x70]
00661BF68  ldr      x30, [sp, #0x60]
00661BF6C  add      sp, sp, #0x90
00661BF70  ret      
00661BF74  bl       #0x382bfb8 ; 
00661BF78  bl       #0x89edb60 ; 

