; HotFix.BattleLogic.BeeMonsterRefresher$$SetData
; RVA 0x65BAB4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BAB4C  sub      sp, sp, #0x70
0065BAB50  stp      x30, x27, [sp, #0x20]
0065BAB54  stp      x26, x25, [sp, #0x30]
0065BAB58  stp      x24, x23, [sp, #0x40]
0065BAB5C  stp      x22, x21, [sp, #0x50]
0065BAB60  stp      x20, x19, [sp, #0x60]
0065BAB64  mrs      x25, tpidr_el0
0065BAB68  ldr      x8, [x25, #0x28]
0065BAB6C  adrp     x26, #0x9599000
0065BAB70  adrp     x27, #0x8f09000
0065BAB74  mov      w19, w5
0065BAB78  str      x8, [sp, #0x18]
0065BAB7C  ldrb     w8, [x26, #0x47c]
0065BAB80  ldr      x27, [x27, #0xf78]
0065BAB84  mov      w20, w4
0065BAB88  mov      x24, x3
0065BAB8C  mov      x22, x2
0065BAB90  mov      w23, w1
0065BAB94  mov      x21, x0
0065BAB98  tbnz     w8, #0, #0x65babb0
0065BAB9C  adrp     x0, #0x8f09000
0065BABA0  ldr      x0, [x0, #0xf78]
0065BABA4  bl       #0x382bd14 ; 
0065BABA8  mov      w8, #1
0065BABAC  strb     w8, [x26, #0x47c]
0065BABB0  ldr      x6, [x27]
0065BABB4  ldrb     w8, [x6, #0x53]
0065BABB8  tbnz     w8, #5, #0x65babe4
0065BABBC  str      w23, [x21, #0x28]
0065BABC0  str      x22, [x21, #0x30]
0065BABC4  ldr      x8, [x24, #0x10]
0065BABC8  ldr      q0, [x24]
0065BABCC  str      w20, [x21, #0x50]
0065BABD0  str      wzr, [x21, #0x68]
0065BABD4  str      x8, [x21, #0x48]
0065BABD8  stur     q0, [x21, #0x38]
0065BABDC  str      w19, [x21, #0x58]
0065BABE0  b        #0x65bac14 ; 
0065BABE4  ldr      x8, [x24, #0x10]
0065BABE8  ldr      q0, [x24]
0065BABEC  ldr      x9, [x6, #0x60]
0065BABF0  mov      x3, sp
0065BABF4  mov      x0, x21
0065BABF8  mov      w1, w23
0065BABFC  mov      x2, x22
0065BAC00  mov      w4, w20
0065BAC04  mov      w5, w19
0065BAC08  str      x8, [sp, #0x10]
0065BAC0C  str      q0, [sp]
0065BAC10  blr      x9
0065BAC14  ldr      x8, [x25, #0x28]
0065BAC18  ldr      x9, [sp, #0x18]
0065BAC1C  cmp      x8, x9
0065BAC20  b.ne     #0x65bac40
0065BAC24  ldp      x20, x19, [sp, #0x60]
0065BAC28  ldp      x22, x21, [sp, #0x50]
0065BAC2C  ldp      x24, x23, [sp, #0x40]
0065BAC30  ldp      x26, x25, [sp, #0x30]
0065BAC34  ldp      x30, x27, [sp, #0x20]
0065BAC38  add      sp, sp, #0x70
0065BAC3C  ret      
0065BAC40  bl       #0x89edb60 ; 

; HotFix.BattleLogic.BeeMonsterRefresher$$Update
; RVA 0x65BAC44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BAC44  sub      sp, sp, #0xa0
0065BAC48  stp      x30, x25, [sp, #0x60]
0065BAC4C  stp      x24, x23, [sp, #0x70]
0065BAC50  stp      x22, x21, [sp, #0x80]
0065BAC54  stp      x20, x19, [sp, #0x90]
0065BAC58  mrs      x24, tpidr_el0
0065BAC5C  ldr      x8, [x24, #0x28]
0065BAC60  adrp     x21, #0x9599000
0065BAC64  adrp     x22, #0x8f09000
0065BAC68  mov      x20, x1
0065BAC6C  str      x8, [sp, #0x58]
0065BAC70  ldrb     w8, [x21, #0x47d]
0065BAC74  ldr      x22, [x22, #0xf80]
0065BAC78  mov      x19, x0
0065BAC7C  tbnz     w8, #0, #0x65baca0
0065BAC80  adrp     x0, #0x8f09000
0065BAC84  ldr      x0, [x0, #0xf80]
0065BAC88  bl       #0x382bd14 ; 
0065BAC8C  adrp     x0, #0x8ec1000
0065BAC90  ldr      x0, [x0, #0x240]
0065BAC94  bl       #0x382bd14 ; 
0065BAC98  mov      w8, #1
0065BAC9C  strb     w8, [x21, #0x47d]
0065BACA0  ldr      x2, [x22]
0065BACA4  ldrb     w8, [x2, #0x53]
0065BACA8  tbnz     w8, #5, #0x65bacf8
0065BACAC  ldr      w8, [x19, #0x68]
0065BACB0  ldr      w9, [x19, #0x50]
0065BACB4  cmp      w8, w9
0065BACB8  b.ge     #0x65bad20
0065BACBC  adrp     x23, #0x9591000
0065BACC0  ldrb     w8, [x23, #0xa4b]
0065BACC4  cbnz     w8, #0x65bacdc
0065BACC8  adrp     x0, #0x8ee5000
0065BACCC  ldr      x0, [x0, #0xb28]
0065BACD0  bl       #0x382bd14 ; 
0065BACD4  mov      w8, #1
0065BACD8  strb     w8, [x23, #0xa4b]
0065BACDC  adrp     x25, #0x8ee5000
0065BACE0  ldr      x25, [x25, #0xb28]
0065BACE4  ldr      x1, [x25]
0065BACE8  ldrb     w8, [x1, #0x53]
0065BACEC  tbnz     w8, #5, #0x65bad28
0065BACF0  ldr      x0, [x19, #0x20]
0065BACF4  b        #0x65bad34 ; 
0065BACF8  ldr      x8, [x2, #0x60]
0065BACFC  mov      x0, x19
0065BAD00  mov      x1, x20
0065BAD04  blr      x8
0065BAD08  ldr      x8, [x24, #0x28]
0065BAD0C  ldr      x9, [sp, #0x58]
0065BAD10  cmp      x8, x9
0065BAD14  b.ne     #0x65baf50
0065BAD18  and      w0, w0, #1
0065BAD1C  b        #0x65baf30 ; 
0065BAD20  mov      w0, #1
0065BAD24  b        #0x65baf20 ; 
0065BAD28  ldr      x8, [x1, #0x60]
0065BAD2C  mov      x0, x19
0065BAD30  blr      x8
0065BAD34  cbz      x0, #0x65baf48
0065BAD38  ldr      x8, [x0, #0x128]
0065BAD3C  ldr      x9, [x19, #0x70]
0065BAD40  ldr      x10, [x19, #0x30]
0065BAD44  sub      x8, x8, x9
0065BAD48  cmp      x8, x10
0065BAD4C  b.lt     #0x65baf1c
0065BAD50  ldrb     w8, [x23, #0xa4b]
0065BAD54  cbnz     w8, #0x65bad6c
0065BAD58  adrp     x0, #0x8ee5000
0065BAD5C  ldr      x0, [x0, #0xb28]
0065BAD60  bl       #0x382bd14 ; 
0065BAD64  mov      w8, #1
0065BAD68  strb     w8, [x23, #0xa4b]
0065BAD6C  ldr      x1, [x25]
0065BAD70  ldrb     w8, [x1, #0x53]
0065BAD74  tbnz     w8, #5, #0x65bad80
0065BAD78  ldr      x0, [x19, #0x20]
0065BAD7C  b        #0x65bad8c ; 
0065BAD80  ldr      x8, [x1, #0x60]
0065BAD84  mov      x0, x19
0065BAD88  blr      x8
0065BAD8C  cbz      x0, #0x65baf48
0065BAD90  ldr      x8, [x0, #0x128]
0065BAD94  ldr      w9, [x19, #0x68]
0065BAD98  mov      w1, #4
0065BAD9C  str      x8, [x19, #0x70]
0065BADA0  add      w8, w9, #1
0065BADA4  str      w8, [x19, #0x68]
0065BADA8  adrp     x8, #0x8ec1000
0065BADAC  ldr      x8, [x8, #0x240]
0065BADB0  ldr      x0, [x8]
0065BADB4  bl       #0x382bdfc ; 
0065BADB8  cbz      x0, #0x65baf48
0065BADBC  ldr      w8, [x0, #0x18]
0065BADC0  mov      x20, x0
0065BADC4  cmp      w8, #3
0065BADC8  b.ls     #0x65baf4c
0065BADCC  ldr      w8, [x19, #0x54]
0065BADD0  str      w8, [x20, #0x2c]
0065BADD4  ldrb     w8, [x23, #0xa4b]
0065BADD8  cbnz     w8, #0x65badf0
0065BADDC  adrp     x0, #0x8ee5000
0065BADE0  ldr      x0, [x0, #0xb28]
0065BADE4  bl       #0x382bd14 ; 
0065BADE8  mov      w8, #1
0065BADEC  strb     w8, [x23, #0xa4b]
0065BADF0  ldr      x1, [x25]
0065BADF4  ldrb     w8, [x1, #0x53]
0065BADF8  tbnz     w8, #5, #0x65bae08
0065BADFC  ldr      x21, [x19, #0x20]
0065BAE00  mov      w8, wzr
0065BAE04  b        #0x65bae24 ; 
0065BAE08  ldr      x8, [x1, #0x60]
0065BAE0C  mov      x0, x19
0065BAE10  blr      x8
0065BAE14  ldrb     w8, [x23, #0xa4b]
0065BAE18  mov      x21, x0
0065BAE1C  cmp      w8, #0
0065BAE20  cset     w8, eq
0065BAE24  ldr      x9, [x19, #0x48]
0065BAE28  ldur     q0, [x19, #0x38]
0065BAE2C  ldr      w22, [x19, #0x28]
0065BAE30  str      x9, [sp, #0x50]
0065BAE34  str      q0, [sp, #0x40]
0065BAE38  cbz      w8, #0x65bae50
0065BAE3C  adrp     x0, #0x8ee5000
0065BAE40  ldr      x0, [x0, #0xb28]
0065BAE44  bl       #0x382bd14 ; 
0065BAE48  mov      w8, #1
0065BAE4C  strb     w8, [x23, #0xa4b]
0065BAE50  ldr      x1, [x25]
0065BAE54  ldrb     w8, [x1, #0x53]
0065BAE58  tbnz     w8, #5, #0x65bae64
0065BAE5C  ldr      x23, [x19, #0x20]
0065BAE60  b        #0x65bae74 ; 
0065BAE64  ldr      x8, [x1, #0x60]
0065BAE68  mov      x0, x19
0065BAE6C  blr      x8
0065BAE70  mov      x23, x0
0065BAE74  cbz      x23, #0x65baf48
0065BAE78  adrp     x25, #0x9598000
0065BAE7C  ldrb     w8, [x25, #0xfc4]
0065BAE80  cbnz     w8, #0x65bae98
0065BAE84  adrp     x0, #0x8f05000
0065BAE88  ldr      x0, [x0, #0xfd8]
0065BAE8C  bl       #0x382bd14 ; 
0065BAE90  mov      w8, #1
0065BAE94  strb     w8, [x25, #0xfc4]
0065BAE98  adrp     x8, #0x8f05000
0065BAE9C  ldr      x8, [x8, #0xfd8]
0065BAEA0  ldr      x1, [x8]
0065BAEA4  ldrb     w8, [x1, #0x53]
0065BAEA8  tbnz     w8, #5, #0x65baeb4
0065BAEAC  ldr      x0, [x23, #0x220]
0065BAEB0  b        #0x65baec0 ; 
0065BAEB4  ldr      x8, [x1, #0x60]
0065BAEB8  mov      x0, x23
0065BAEBC  blr      x8
0065BAEC0  cbz      x0, #0x65baf48
0065BAEC4  ldr      x8, [x0]
0065BAEC8  ldr      w1, [x19, #0x58]
0065BAECC  ldr      x9, [x8, #0x588]
0065BAED0  ldr      x2, [x8, #0x590]
0065BAED4  blr      x9
0065BAED8  cbz      x21, #0x65baf48
0065BAEDC  ldr      q0, [sp, #0x40]
0065BAEE0  ldr      x8, [sp, #0x50]
0065BAEE4  ldr      w9, [x19, #0x58]
0065BAEE8  mov      x6, x0
0065BAEEC  add      x2, sp, #0x20
0065BAEF0  mov      w5, #1
0065BAEF4  mov      x0, x21
0065BAEF8  mov      w1, w22
0065BAEFC  mov      x3, x20
0065BAF00  mov      x4, xzr
0065BAF04  mov      w7, wzr
0065BAF08  str      q0, [sp, #0x20]
0065BAF0C  str      x8, [sp, #0x30]
0065BAF10  stp      xzr, xzr, [sp, #8]
0065BAF14  str      w9, [sp]
0065BAF18  bl       #0x6a15ea4 ; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
0065BAF1C  mov      w0, wzr
0065BAF20  ldr      x8, [x24, #0x28]
0065BAF24  ldr      x9, [sp, #0x58]
0065BAF28  cmp      x8, x9
0065BAF2C  b.ne     #0x65baf50
0065BAF30  ldp      x20, x19, [sp, #0x90]
0065BAF34  ldp      x22, x21, [sp, #0x80]
0065BAF38  ldp      x24, x23, [sp, #0x70]
0065BAF3C  ldp      x30, x25, [sp, #0x60]
0065BAF40  add      sp, sp, #0xa0
0065BAF44  ret      
0065BAF48  bl       #0x382bfb8 ; 
0065BAF4C  bl       #0x382bfc0 ; 
0065BAF50  bl       #0x89edb60 ; 

; HotFix.BattleLogic.BeeMonsterRefresher$$.ctor
; RVA 0x65BB380; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BB380  stp      x30, x21, [sp, #-0x20]!
0065BB384  stp      x20, x19, [sp, #0x10]
0065BB388  adrp     x20, #0x9599000
0065BB38C  adrp     x21, #0x8f09000
0065BB390  ldrb     w8, [x20, #0x47e]
0065BB394  ldr      x21, [x21, #0xfa8]
0065BB398  mov      x19, x0
0065BB39C  tbnz     w8, #0, #0x65bb3b4
0065BB3A0  adrp     x0, #0x8f09000
0065BB3A4  ldr      x0, [x0, #0xfa8]
0065BB3A8  bl       #0x382bd14 ; 
0065BB3AC  mov      w8, #1
0065BB3B0  strb     w8, [x20, #0x47e]
0065BB3B4  ldr      x1, [x21]
0065BB3B8  ldrb     w8, [x1, #0x53]
0065BB3BC  tbnz     w8, #5, #0x65bb3d4
0065BB3C0  mov      x0, x19
0065BB3C4  ldp      x20, x19, [sp, #0x10]
0065BB3C8  mov      x1, xzr
0065BB3CC  ldp      x30, x21, [sp], #0x20
0065BB3D0  b        #0x6a34500 ; HotFix.BattleLogic.PooledWorldElement$$.ctor
0065BB3D4  ldr      x2, [x1, #0x60]
0065BB3D8  mov      x0, x19
0065BB3DC  ldp      x20, x19, [sp, #0x10]
0065BB3E0  ldp      x30, x21, [sp], #0x20
0065BB3E4  br       x2

