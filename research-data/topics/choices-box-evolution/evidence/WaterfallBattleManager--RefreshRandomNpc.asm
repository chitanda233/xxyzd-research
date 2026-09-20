; HotFix.BattleLogic.WaterfallBattleManager$$RefreshRandomNpc
; RVA 0x65CD8EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CD8EC  str      x30, [sp, #-0x30]!
0065CD8F0  stp      x22, x21, [sp, #0x10]
0065CD8F4  stp      x20, x19, [sp, #0x20]
0065CD8F8  adrp     x20, #0x9599000
0065CD8FC  adrp     x21, #0x8f0a000
0065CD900  ldrb     w8, [x20, #0x5a0]
0065CD904  ldr      x21, [x21, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.RefreshRandomNpc() @ 0x92c81a8
0065CD908  mov      x19, x0
0065CD90C  tbnz     w8, #0, #0x65cd93c
0065CD910  adrp     x0, #0x8ee8000
0065CD914  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065CD918  bl       #0x382bd14 ; 
0065CD91C  adrp     x0, #0x8f09000
0065CD920  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065CD924  bl       #0x382bd14 ; 
0065CD928  adrp     x0, #0x8f0a000
0065CD92C  ldr      x0, [x0, #0x8a8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.RefreshRandomNpc() @ 0x92c81a8
0065CD930  bl       #0x382bd14 ; 
0065CD934  mov      w8, #1
0065CD938  strb     w8, [x20, #0x5a0]
0065CD93C  ldr      x1, [x21]
0065CD940  ldrb     w8, [x1, #0x53]
0065CD944  tbnz     w8, #5, #0x65cd998
0065CD948  ldr      x20, [x19, #0x188]
0065CD94C  cbz      x20, #0x65cdafc
0065CD950  adrp     x21, #0x8f09000
0065CD954  ldr      x8, [x20]
0065CD958  ldr      x21, [x21, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065CD95C  ldrh     w9, [x8, #0x12e]
0065CD960  ldr      x1, [x21]
0065CD964  cbz      x9, #0x65cd988
0065CD968  ldr      x10, [x8, #0xb0]
0065CD96C  add      x10, x10, #8
0065CD970  ldur     x11, [x10, #-8]
0065CD974  cmp      x11, x1
0065CD978  b.eq     #0x65cd9b0
0065CD97C  subs     x9, x9, #1
0065CD980  add      x10, x10, #0x10
0065CD984  b.ne     #0x65cd970
0065CD988  mov      w2, #0x24
0065CD98C  mov      x0, x20
0065CD990  bl       #0x3a7e710 ; 
0065CD994  b        #0x65cd9c0 ; 
0065CD998  ldr      x2, [x1, #0x60]
0065CD99C  mov      x0, x19
0065CD9A0  ldp      x20, x19, [sp, #0x20]
0065CD9A4  ldp      x22, x21, [sp, #0x10]
0065CD9A8  ldr      x30, [sp], #0x30
0065CD9AC  br       x2
0065CD9B0  ldr      w9, [x10]
0065CD9B4  add      w9, w9, #0x24
0065CD9B8  add      x8, x8, w9, sxtw #4
0065CD9BC  add      x0, x8, #0x138
0065CD9C0  ldp      x8, x1, [x0]
0065CD9C4  mov      x0, x20
0065CD9C8  blr      x8
0065CD9CC  cmp      w0, #1
0065CD9D0  b.lt     #0x65cdad8
0065CD9D4  ldr      x20, [x19, #0x188]
0065CD9D8  cbz      x20, #0x65cdafc
0065CD9DC  ldr      x8, [x20]
0065CD9E0  ldr      x1, [x21]
0065CD9E4  ldrh     w9, [x8, #0x12e]
0065CD9E8  cbz      x9, #0x65cda0c
0065CD9EC  ldr      x10, [x8, #0xb0]
0065CD9F0  add      x10, x10, #8
0065CD9F4  ldur     x11, [x10, #-8]
0065CD9F8  cmp      x11, x1
0065CD9FC  b.eq     #0x65cda1c
0065CDA00  subs     x9, x9, #1
0065CDA04  add      x10, x10, #0x10
0065CDA08  b.ne     #0x65cd9f4
0065CDA0C  mov      w2, #0x24
0065CDA10  mov      x0, x20
0065CDA14  bl       #0x3a7e710 ; 
0065CDA18  b        #0x65cda2c ; 
0065CDA1C  ldr      w9, [x10]
0065CDA20  add      w9, w9, #0x24
0065CDA24  add      x8, x8, w9, sxtw #4
0065CDA28  add      x0, x8, #0x138
0065CDA2C  ldp      x8, x1, [x0]
0065CDA30  mov      x0, x20
0065CDA34  blr      x8
0065CDA38  cmp      w0, #9
0065CDA3C  b.ne     #0x65cdad8
0065CDA40  adrp     x20, #0x9599000
0065CDA44  ldrb     w8, [x20, #0x286]
0065CDA48  cbnz     w8, #0x65cda60
0065CDA4C  adrp     x0, #0x8f07000
0065CDA50  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065CDA54  bl       #0x382bd14 ; 
0065CDA58  mov      w8, #1
0065CDA5C  strb     w8, [x20, #0x286]
0065CDA60  adrp     x8, #0x8f07000
0065CDA64  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065CDA68  ldr      x1, [x8]
0065CDA6C  ldrb     w8, [x1, #0x53]
0065CDA70  tbnz     w8, #5, #0x65cda7c
0065CDA74  ldr      x0, [x19, #0x80]
0065CDA78  b        #0x65cda88 ; 
0065CDA7C  ldr      x8, [x1, #0x60]
0065CDA80  mov      x0, x19
0065CDA84  blr      x8
0065CDA88  cbz      x0, #0x65cdafc
0065CDA8C  mov      w2, #0x64
0065CDA90  mov      w1, wzr
0065CDA94  mov      x3, xzr
0065CDA98  bl       #0x54b65d8 ; 
0065CDA9C  adrp     x22, #0x8ee8000
0065CDAA0  ldr      x22, [x22, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065CDAA4  ldr      w21, [x19, #0x128]
0065CDAA8  mov      w20, w0
0065CDAAC  ldr      x8, [x22]
0065CDAB0  ldr      w9, [x8, #0xe0]
0065CDAB4  cbnz     w9, #0x65cdac4
0065CDAB8  mov      x0, x8
0065CDABC  bl       #0x382be8c ; 
0065CDAC0  ldr      x8, [x22]
0065CDAC4  ldr      x8, [x8, #0xb8]
0065CDAC8  ldr      w8, [x8, #0x334]
0065CDACC  mul      w8, w8, w21
0065CDAD0  cmp      w20, w8
0065CDAD4  b.le     #0x65cdae8
0065CDAD8  ldp      x20, x19, [sp, #0x20]
0065CDADC  ldp      x22, x21, [sp, #0x10]
0065CDAE0  ldr      x30, [sp], #0x30
0065CDAE4  ret      
0065CDAE8  mov      x0, x19
0065CDAEC  ldp      x20, x19, [sp, #0x20]
0065CDAF0  ldp      x22, x21, [sp, #0x10]
0065CDAF4  ldr      x30, [sp], #0x30
0065CDAF8  b        #0x65cd7c4 ; HotFix.BattleLogic.WaterfallBattleManager$$CreatePunchboardNpc
0065CDAFC  bl       #0x382bfb8 ; 

