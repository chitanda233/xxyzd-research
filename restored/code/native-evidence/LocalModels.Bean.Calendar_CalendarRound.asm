; LocalModels.Bean.Calendar_CalendarRound$$readImpl
; RVA 0x6893490; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006893490  stp      x30, x21, [sp, #-0x20]!
006893494  stp      x20, x19, [sp, #0x10]
006893498  adrp     x20, #0x959b000
00689349C  adrp     x21, #0x8f25000
0068934A0  ldrb     w8, [x20, #0xd6f]
0068934A4  ldr      x21, [x21, #0x940]
0068934A8  mov      x19, x0
0068934AC  tbnz     w8, #0, #0x68934c4
0068934B0  adrp     x0, #0x8f25000
0068934B4  ldr      x0, [x0, #0x940]
0068934B8  bl       #0x382bd14 ; 
0068934BC  mov      w8, #1
0068934C0  strb     w8, [x20, #0xd6f]
0068934C4  ldr      x1, [x21]
0068934C8  ldrb     w8, [x1, #0x53]
0068934CC  tbnz     w8, #5, #0x689351c
0068934D0  mov      x0, x19
0068934D4  mov      x1, xzr
0068934D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068934DC  adrp     x21, #0x959c000
0068934E0  ldrb     w8, [x21, #0x481]
0068934E4  mov      w20, w0
0068934E8  cbnz     w8, #0x6893500
0068934EC  adrp     x0, #0x8f25000
0068934F0  ldr      x0, [x0, #0x8e8]
0068934F4  bl       #0x382bd14 ; 
0068934F8  mov      w8, #1
0068934FC  strb     w8, [x21, #0x481]
006893500  adrp     x8, #0x8f25000
006893504  ldr      x8, [x8, #0x8e8]
006893508  ldr      x2, [x8]
00689350C  ldrb     w8, [x2, #0x53]
006893510  tbnz     w8, #5, #0x6893530
006893514  str      w20, [x19, #0x20]
006893518  b        #0x6893540 ; 
00689351C  ldr      x2, [x1, #0x60]
006893520  mov      x0, x19
006893524  ldp      x20, x19, [sp, #0x10]
006893528  ldp      x30, x21, [sp], #0x20
00689352C  br       x2
006893530  ldr      x8, [x2, #0x60]
006893534  mov      x0, x19
006893538  mov      w1, w20
00689353C  blr      x8
006893540  mov      x0, x19
006893544  mov      x1, xzr
006893548  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689354C  adrp     x21, #0x959c000
006893550  ldrb     w8, [x21, #0x482]
006893554  mov      w20, w0
006893558  cbnz     w8, #0x6893570
00689355C  adrp     x0, #0x8f25000
006893560  ldr      x0, [x0, #0x8f8]
006893564  bl       #0x382bd14 ; 
006893568  mov      w8, #1
00689356C  strb     w8, [x21, #0x482]
006893570  adrp     x8, #0x8f25000
006893574  ldr      x8, [x8, #0x8f8]
006893578  ldr      x2, [x8]
00689357C  ldrb     w8, [x2, #0x53]
006893580  tbnz     w8, #5, #0x689358c
006893584  str      w20, [x19, #0x24]
006893588  b        #0x689359c ; 
00689358C  ldr      x8, [x2, #0x60]
006893590  mov      x0, x19
006893594  mov      w1, w20
006893598  blr      x8
00689359C  mov      x0, x19
0068935A0  mov      x1, xzr
0068935A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068935A8  adrp     x21, #0x959c000
0068935AC  ldrb     w8, [x21, #0x483]
0068935B0  mov      w20, w0
0068935B4  cbnz     w8, #0x68935cc
0068935B8  adrp     x0, #0x8f25000
0068935BC  ldr      x0, [x0, #0x908]
0068935C0  bl       #0x382bd14 ; 
0068935C4  mov      w8, #1
0068935C8  strb     w8, [x21, #0x483]
0068935CC  adrp     x8, #0x8f25000
0068935D0  ldr      x8, [x8, #0x908]
0068935D4  ldr      x2, [x8]
0068935D8  ldrb     w8, [x2, #0x53]
0068935DC  tbnz     w8, #5, #0x68935e8
0068935E0  str      w20, [x19, #0x28]
0068935E4  b        #0x68935f8 ; 
0068935E8  ldr      x8, [x2, #0x60]
0068935EC  mov      x0, x19
0068935F0  mov      w1, w20
0068935F4  blr      x8
0068935F8  mov      x0, x19
0068935FC  mov      x1, xzr
006893600  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006893604  adrp     x21, #0x959c000
006893608  ldrb     w8, [x21, #0x484]
00689360C  mov      w20, w0
006893610  cbnz     w8, #0x6893628
006893614  adrp     x0, #0x8f25000
006893618  ldr      x0, [x0, #0x918]
00689361C  bl       #0x382bd14 ; 
006893620  mov      w8, #1
006893624  strb     w8, [x21, #0x484]
006893628  adrp     x8, #0x8f25000
00689362C  ldr      x8, [x8, #0x918]
006893630  ldr      x2, [x8]
006893634  ldrb     w8, [x2, #0x53]
006893638  tbnz     w8, #5, #0x6893644
00689363C  str      w20, [x19, #0x2c]
006893640  b        #0x6893654 ; 
006893644  ldr      x8, [x2, #0x60]
006893648  mov      x0, x19
00689364C  mov      w1, w20
006893650  blr      x8
006893654  mov      x0, x19
006893658  mov      x1, xzr
00689365C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006893660  adrp     x21, #0x959c000
006893664  ldrb     w8, [x21, #0x485]
006893668  mov      x20, x0
00689366C  cbnz     w8, #0x6893684
006893670  adrp     x0, #0x8f25000
006893674  ldr      x0, [x0, #0x928]
006893678  bl       #0x382bd14 ; 
00689367C  mov      w8, #1
006893680  strb     w8, [x21, #0x485]
006893684  adrp     x8, #0x8f25000
006893688  ldr      x8, [x8, #0x928]
00689368C  ldr      x2, [x8]
006893690  ldrb     w8, [x2, #0x53]
006893694  tbnz     w8, #5, #0x68936ac
006893698  mov      x0, x19
00689369C  str      x20, [x0, #0x30]!
0068936A0  mov      x1, x20
0068936A4  bl       #0x382bcb8 ; 
0068936A8  b        #0x68936bc ; 
0068936AC  ldr      x8, [x2, #0x60]
0068936B0  mov      x0, x19
0068936B4  mov      x1, x20
0068936B8  blr      x8
0068936BC  mov      x0, x19
0068936C0  mov      x1, xzr
0068936C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068936C8  adrp     x21, #0x959c000
0068936CC  ldrb     w8, [x21, #0x486]
0068936D0  mov      x20, x0
0068936D4  cbnz     w8, #0x68936ec
0068936D8  adrp     x0, #0x8f25000
0068936DC  ldr      x0, [x0, #0x938]
0068936E0  bl       #0x382bd14 ; 
0068936E4  mov      w8, #1
0068936E8  strb     w8, [x21, #0x486]
0068936EC  adrp     x8, #0x8f25000
0068936F0  ldr      x8, [x8, #0x938]
0068936F4  ldr      x2, [x8]
0068936F8  ldrb     w8, [x2, #0x53]
0068936FC  tbnz     w8, #5, #0x6893714
006893700  str      x20, [x19, #0x38]!
006893704  mov      x0, x19
006893708  mov      x1, x20
00689370C  bl       #0x382bcb8 ; 
006893710  b        #0x6893724 ; 
006893714  ldr      x8, [x2, #0x60]
006893718  mov      x0, x19
00689371C  mov      x1, x20
006893720  blr      x8
006893724  ldp      x20, x19, [sp, #0x10]
006893728  mov      w0, #1
00689372C  ldp      x30, x21, [sp], #0x20
006893730  ret      

