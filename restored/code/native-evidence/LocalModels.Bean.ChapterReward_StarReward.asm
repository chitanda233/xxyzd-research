; LocalModels.Bean.ChapterReward_StarReward$$readImpl
; RVA 0x689D8E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689D8E8  stp      x30, x21, [sp, #-0x20]!
00689D8EC  stp      x20, x19, [sp, #0x10]
00689D8F0  adrp     x20, #0x959b000
00689D8F4  adrp     x21, #0x8f26000
00689D8F8  ldrb     w8, [x20, #0xe80]
00689D8FC  ldr      x21, [x21, #0x148]
00689D900  mov      x19, x0
00689D904  tbnz     w8, #0, #0x689d91c
00689D908  adrp     x0, #0x8f26000
00689D90C  ldr      x0, [x0, #0x148]
00689D910  bl       #0x382bd14 ; 
00689D914  mov      w8, #1
00689D918  strb     w8, [x20, #0xe80]
00689D91C  ldr      x1, [x21]
00689D920  ldrb     w8, [x1, #0x53]
00689D924  tbnz     w8, #5, #0x689d974
00689D928  mov      x0, x19
00689D92C  mov      x1, xzr
00689D930  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689D934  adrp     x21, #0x959c000
00689D938  ldrb     w8, [x21, #0x4f3]
00689D93C  mov      w20, w0
00689D940  cbnz     w8, #0x689d958
00689D944  adrp     x0, #0x8f26000
00689D948  ldr      x0, [x0, #0xd0]
00689D94C  bl       #0x382bd14 ; 
00689D950  mov      w8, #1
00689D954  strb     w8, [x21, #0x4f3]
00689D958  adrp     x8, #0x8f26000
00689D95C  ldr      x8, [x8, #0xd0]
00689D960  ldr      x2, [x8]
00689D964  ldrb     w8, [x2, #0x53]
00689D968  tbnz     w8, #5, #0x689d988
00689D96C  str      w20, [x19, #0x20]
00689D970  b        #0x689d998 ; 
00689D974  ldr      x2, [x1, #0x60]
00689D978  mov      x0, x19
00689D97C  ldp      x20, x19, [sp, #0x10]
00689D980  ldp      x30, x21, [sp], #0x20
00689D984  br       x2
00689D988  ldr      x8, [x2, #0x60]
00689D98C  mov      x0, x19
00689D990  mov      w1, w20
00689D994  blr      x8
00689D998  mov      x0, x19
00689D99C  mov      x1, xzr
00689D9A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689D9A4  adrp     x21, #0x959c000
00689D9A8  ldrb     w8, [x21, #0x4f4]
00689D9AC  mov      w20, w0
00689D9B0  cbnz     w8, #0x689d9c8
00689D9B4  adrp     x0, #0x8f26000
00689D9B8  ldr      x0, [x0, #0xe0]
00689D9BC  bl       #0x382bd14 ; 
00689D9C0  mov      w8, #1
00689D9C4  strb     w8, [x21, #0x4f4]
00689D9C8  adrp     x8, #0x8f26000
00689D9CC  ldr      x8, [x8, #0xe0]
00689D9D0  ldr      x2, [x8]
00689D9D4  ldrb     w8, [x2, #0x53]
00689D9D8  tbnz     w8, #5, #0x689d9e4
00689D9DC  str      w20, [x19, #0x24]
00689D9E0  b        #0x689d9f4 ; 
00689D9E4  ldr      x8, [x2, #0x60]
00689D9E8  mov      x0, x19
00689D9EC  mov      w1, w20
00689D9F0  blr      x8
00689D9F4  mov      x0, x19
00689D9F8  mov      x1, xzr
00689D9FC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
00689DA00  adrp     x21, #0x959c000
00689DA04  ldrb     w8, [x21, #0x4f5]
00689DA08  mov      x20, x0
00689DA0C  cbnz     w8, #0x689da24
00689DA10  adrp     x0, #0x8f26000
00689DA14  ldr      x0, [x0, #0xf0]
00689DA18  bl       #0x382bd14 ; 
00689DA1C  mov      w8, #1
00689DA20  strb     w8, [x21, #0x4f5]
00689DA24  adrp     x8, #0x8f26000
00689DA28  ldr      x8, [x8, #0xf0]
00689DA2C  ldr      x2, [x8]
00689DA30  ldrb     w8, [x2, #0x53]
00689DA34  tbnz     w8, #5, #0x689da4c
00689DA38  mov      x0, x19
00689DA3C  str      x20, [x0, #0x28]!
00689DA40  mov      x1, x20
00689DA44  bl       #0x382bcb8 ; 
00689DA48  b        #0x689da5c ; 
00689DA4C  ldr      x8, [x2, #0x60]
00689DA50  mov      x0, x19
00689DA54  mov      x1, x20
00689DA58  blr      x8
00689DA5C  mov      x0, x19
00689DA60  mov      x1, xzr
00689DA64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689DA68  adrp     x21, #0x959c000
00689DA6C  ldrb     w8, [x21, #0x4f6]
00689DA70  mov      w20, w0
00689DA74  cbnz     w8, #0x689da8c
00689DA78  adrp     x0, #0x8f26000
00689DA7C  ldr      x0, [x0, #0x100]
00689DA80  bl       #0x382bd14 ; 
00689DA84  mov      w8, #1
00689DA88  strb     w8, [x21, #0x4f6]
00689DA8C  adrp     x8, #0x8f26000
00689DA90  ldr      x8, [x8, #0x100]
00689DA94  ldr      x2, [x8]
00689DA98  ldrb     w8, [x2, #0x53]
00689DA9C  tbnz     w8, #5, #0x689daa8
00689DAA0  str      w20, [x19, #0x30]
00689DAA4  b        #0x689dab8 ; 
00689DAA8  ldr      x8, [x2, #0x60]
00689DAAC  mov      x0, x19
00689DAB0  mov      w1, w20
00689DAB4  blr      x8
00689DAB8  mov      x0, x19
00689DABC  mov      x1, xzr
00689DAC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689DAC4  adrp     x21, #0x959c000
00689DAC8  ldrb     w8, [x21, #0x4f7]
00689DACC  mov      w20, w0
00689DAD0  cbnz     w8, #0x689dae8
00689DAD4  adrp     x0, #0x8f26000
00689DAD8  ldr      x0, [x0, #0x110]
00689DADC  bl       #0x382bd14 ; 
00689DAE0  mov      w8, #1
00689DAE4  strb     w8, [x21, #0x4f7]
00689DAE8  adrp     x8, #0x8f26000
00689DAEC  ldr      x8, [x8, #0x110]
00689DAF0  ldr      x2, [x8]
00689DAF4  ldrb     w8, [x2, #0x53]
00689DAF8  tbnz     w8, #5, #0x689db04
00689DAFC  str      w20, [x19, #0x34]
00689DB00  b        #0x689db14 ; 
00689DB04  ldr      x8, [x2, #0x60]
00689DB08  mov      x0, x19
00689DB0C  mov      w1, w20
00689DB10  blr      x8
00689DB14  mov      x0, x19
00689DB18  mov      x1, xzr
00689DB1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689DB20  adrp     x21, #0x959c000
00689DB24  ldrb     w8, [x21, #0x4f8]
00689DB28  mov      w20, w0
00689DB2C  cbnz     w8, #0x689db44
00689DB30  adrp     x0, #0x8f26000
00689DB34  ldr      x0, [x0, #0x120]
00689DB38  bl       #0x382bd14 ; 
00689DB3C  mov      w8, #1
00689DB40  strb     w8, [x21, #0x4f8]
00689DB44  adrp     x8, #0x8f26000
00689DB48  ldr      x8, [x8, #0x120]
00689DB4C  ldr      x2, [x8]
00689DB50  ldrb     w8, [x2, #0x53]
00689DB54  tbnz     w8, #5, #0x689db60
00689DB58  str      w20, [x19, #0x38]
00689DB5C  b        #0x689db70 ; 
00689DB60  ldr      x8, [x2, #0x60]
00689DB64  mov      x0, x19
00689DB68  mov      w1, w20
00689DB6C  blr      x8
00689DB70  mov      x0, x19
00689DB74  mov      x1, xzr
00689DB78  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
00689DB7C  adrp     x21, #0x959c000
00689DB80  ldrb     w8, [x21, #0x4f9]
00689DB84  mov      x20, x0
00689DB88  cbnz     w8, #0x689dba0
00689DB8C  adrp     x0, #0x8f26000
00689DB90  ldr      x0, [x0, #0x130]
00689DB94  bl       #0x382bd14 ; 
00689DB98  mov      w8, #1
00689DB9C  strb     w8, [x21, #0x4f9]
00689DBA0  adrp     x8, #0x8f26000
00689DBA4  ldr      x8, [x8, #0x130]
00689DBA8  ldr      x2, [x8]
00689DBAC  ldrb     w8, [x2, #0x53]
00689DBB0  tbnz     w8, #5, #0x689dbc8
00689DBB4  mov      x0, x19
00689DBB8  str      x20, [x0, #0x40]!
00689DBBC  mov      x1, x20
00689DBC0  bl       #0x382bcb8 ; 
00689DBC4  b        #0x689dbd8 ; 
00689DBC8  ldr      x8, [x2, #0x60]
00689DBCC  mov      x0, x19
00689DBD0  mov      x1, x20
00689DBD4  blr      x8
00689DBD8  mov      x0, x19
00689DBDC  mov      x1, xzr
00689DBE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689DBE4  adrp     x21, #0x959c000
00689DBE8  ldrb     w8, [x21, #0x4fa]
00689DBEC  mov      w20, w0
00689DBF0  cbnz     w8, #0x689dc08
00689DBF4  adrp     x0, #0x8f26000
00689DBF8  ldr      x0, [x0, #0x140]
00689DBFC  bl       #0x382bd14 ; 
00689DC00  mov      w8, #1
00689DC04  strb     w8, [x21, #0x4fa]
00689DC08  adrp     x8, #0x8f26000
00689DC0C  ldr      x8, [x8, #0x140]
00689DC10  ldr      x2, [x8]
00689DC14  ldrb     w8, [x2, #0x53]
00689DC18  tbnz     w8, #5, #0x689dc24
00689DC1C  str      w20, [x19, #0x48]
00689DC20  b        #0x689dc34 ; 
00689DC24  ldr      x8, [x2, #0x60]
00689DC28  mov      x0, x19
00689DC2C  mov      w1, w20
00689DC30  blr      x8
00689DC34  ldp      x20, x19, [sp, #0x10]
00689DC38  mov      w0, #1
00689DC3C  ldp      x30, x21, [sp], #0x20
00689DC40  ret      

