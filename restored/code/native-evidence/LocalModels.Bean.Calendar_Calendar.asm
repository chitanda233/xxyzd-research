; LocalModels.Bean.Calendar_Calendar$$readImpl
; RVA 0x688DC6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00688DC6C  stp      x30, x21, [sp, #-0x20]!
00688DC70  stp      x20, x19, [sp, #0x10]
00688DC74  adrp     x20, #0x959b000
00688DC78  adrp     x21, #0x8f25000
00688DC7C  ldrb     w8, [x20, #0xce5]
00688DC80  ldr      x21, [x21, #0x530]
00688DC84  mov      x19, x0
00688DC88  tbnz     w8, #0, #0x688dca0
00688DC8C  adrp     x0, #0x8f25000
00688DC90  ldr      x0, [x0, #0x530]
00688DC94  bl       #0x382bd14 ; 
00688DC98  mov      w8, #1
00688DC9C  strb     w8, [x20, #0xce5]
00688DCA0  ldr      x1, [x21]
00688DCA4  ldrb     w8, [x1, #0x53]
00688DCA8  tbnz     w8, #5, #0x688dcf8
00688DCAC  mov      x0, x19
00688DCB0  mov      x1, xzr
00688DCB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688DCB8  adrp     x21, #0x959c000
00688DCBC  ldrb     w8, [x21, #0x43d]
00688DCC0  mov      w20, w0
00688DCC4  cbnz     w8, #0x688dcdc
00688DCC8  adrp     x0, #0x8f25000
00688DCCC  ldr      x0, [x0, #0x428]
00688DCD0  bl       #0x382bd14 ; 
00688DCD4  mov      w8, #1
00688DCD8  strb     w8, [x21, #0x43d]
00688DCDC  adrp     x8, #0x8f25000
00688DCE0  ldr      x8, [x8, #0x428]
00688DCE4  ldr      x2, [x8]
00688DCE8  ldrb     w8, [x2, #0x53]
00688DCEC  tbnz     w8, #5, #0x688dd0c
00688DCF0  str      w20, [x19, #0x20]
00688DCF4  b        #0x688dd1c ; 
00688DCF8  ldr      x2, [x1, #0x60]
00688DCFC  mov      x0, x19
00688DD00  ldp      x20, x19, [sp, #0x10]
00688DD04  ldp      x30, x21, [sp], #0x20
00688DD08  br       x2
00688DD0C  ldr      x8, [x2, #0x60]
00688DD10  mov      x0, x19
00688DD14  mov      w1, w20
00688DD18  blr      x8
00688DD1C  mov      x0, x19
00688DD20  mov      x1, xzr
00688DD24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688DD28  adrp     x21, #0x959c000
00688DD2C  ldrb     w8, [x21, #0x43e]
00688DD30  mov      w20, w0
00688DD34  cbnz     w8, #0x688dd4c
00688DD38  adrp     x0, #0x8f25000
00688DD3C  ldr      x0, [x0, #0x438]
00688DD40  bl       #0x382bd14 ; 
00688DD44  mov      w8, #1
00688DD48  strb     w8, [x21, #0x43e]
00688DD4C  adrp     x8, #0x8f25000
00688DD50  ldr      x8, [x8, #0x438]
00688DD54  ldr      x2, [x8]
00688DD58  ldrb     w8, [x2, #0x53]
00688DD5C  tbnz     w8, #5, #0x688dd68
00688DD60  str      w20, [x19, #0x24]
00688DD64  b        #0x688dd78 ; 
00688DD68  ldr      x8, [x2, #0x60]
00688DD6C  mov      x0, x19
00688DD70  mov      w1, w20
00688DD74  blr      x8
00688DD78  mov      x0, x19
00688DD7C  mov      x1, xzr
00688DD80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688DD84  adrp     x21, #0x959c000
00688DD88  ldrb     w8, [x21, #0x43f]
00688DD8C  mov      w20, w0
00688DD90  cbnz     w8, #0x688dda8
00688DD94  adrp     x0, #0x8f25000
00688DD98  ldr      x0, [x0, #0x448]
00688DD9C  bl       #0x382bd14 ; 
00688DDA0  mov      w8, #1
00688DDA4  strb     w8, [x21, #0x43f]
00688DDA8  adrp     x8, #0x8f25000
00688DDAC  ldr      x8, [x8, #0x448]
00688DDB0  ldr      x2, [x8]
00688DDB4  ldrb     w8, [x2, #0x53]
00688DDB8  tbnz     w8, #5, #0x688ddc4
00688DDBC  str      w20, [x19, #0x28]
00688DDC0  b        #0x688ddd4 ; 
00688DDC4  ldr      x8, [x2, #0x60]
00688DDC8  mov      x0, x19
00688DDCC  mov      w1, w20
00688DDD0  blr      x8
00688DDD4  mov      x0, x19
00688DDD8  mov      x1, xzr
00688DDDC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688DDE0  adrp     x21, #0x959c000
00688DDE4  ldrb     w8, [x21, #0x440]
00688DDE8  mov      x20, x0
00688DDEC  cbnz     w8, #0x688de04
00688DDF0  adrp     x0, #0x8f25000
00688DDF4  ldr      x0, [x0, #0x458]
00688DDF8  bl       #0x382bd14 ; 
00688DDFC  mov      w8, #1
00688DE00  strb     w8, [x21, #0x440]
00688DE04  adrp     x8, #0x8f25000
00688DE08  ldr      x8, [x8, #0x458]
00688DE0C  ldr      x2, [x8]
00688DE10  ldrb     w8, [x2, #0x53]
00688DE14  tbnz     w8, #5, #0x688de2c
00688DE18  mov      x0, x19
00688DE1C  str      x20, [x0, #0x30]!
00688DE20  mov      x1, x20
00688DE24  bl       #0x382bcb8 ; 
00688DE28  b        #0x688de3c ; 
00688DE2C  ldr      x8, [x2, #0x60]
00688DE30  mov      x0, x19
00688DE34  mov      x1, x20
00688DE38  blr      x8
00688DE3C  mov      x0, x19
00688DE40  mov      x1, xzr
00688DE44  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688DE48  adrp     x21, #0x959c000
00688DE4C  ldrb     w8, [x21, #0x441]
00688DE50  mov      x20, x0
00688DE54  cbnz     w8, #0x688de6c
00688DE58  adrp     x0, #0x8f25000
00688DE5C  ldr      x0, [x0, #0x468]
00688DE60  bl       #0x382bd14 ; 
00688DE64  mov      w8, #1
00688DE68  strb     w8, [x21, #0x441]
00688DE6C  adrp     x8, #0x8f25000
00688DE70  ldr      x8, [x8, #0x468]
00688DE74  ldr      x2, [x8]
00688DE78  ldrb     w8, [x2, #0x53]
00688DE7C  tbnz     w8, #5, #0x688de94
00688DE80  mov      x0, x19
00688DE84  str      x20, [x0, #0x38]!
00688DE88  mov      x1, x20
00688DE8C  bl       #0x382bcb8 ; 
00688DE90  b        #0x688dea4 ; 
00688DE94  ldr      x8, [x2, #0x60]
00688DE98  mov      x0, x19
00688DE9C  mov      x1, x20
00688DEA0  blr      x8
00688DEA4  mov      x0, x19
00688DEA8  mov      x1, xzr
00688DEAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688DEB0  adrp     x21, #0x959c000
00688DEB4  ldrb     w8, [x21, #0x442]
00688DEB8  mov      w20, w0
00688DEBC  cbnz     w8, #0x688ded4
00688DEC0  adrp     x0, #0x8f25000
00688DEC4  ldr      x0, [x0, #0x478]
00688DEC8  bl       #0x382bd14 ; 
00688DECC  mov      w8, #1
00688DED0  strb     w8, [x21, #0x442]
00688DED4  adrp     x8, #0x8f25000
00688DED8  ldr      x8, [x8, #0x478]
00688DEDC  ldr      x2, [x8]
00688DEE0  ldrb     w8, [x2, #0x53]
00688DEE4  tbnz     w8, #5, #0x688def0
00688DEE8  str      w20, [x19, #0x40]
00688DEEC  b        #0x688df00 ; 
00688DEF0  ldr      x8, [x2, #0x60]
00688DEF4  mov      x0, x19
00688DEF8  mov      w1, w20
00688DEFC  blr      x8
00688DF00  mov      x0, x19
00688DF04  mov      x1, xzr
00688DF08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688DF0C  adrp     x21, #0x959c000
00688DF10  ldrb     w8, [x21, #0x443]
00688DF14  mov      w20, w0
00688DF18  cbnz     w8, #0x688df30
00688DF1C  adrp     x0, #0x8f25000
00688DF20  ldr      x0, [x0, #0x488]
00688DF24  bl       #0x382bd14 ; 
00688DF28  mov      w8, #1
00688DF2C  strb     w8, [x21, #0x443]
00688DF30  adrp     x8, #0x8f25000
00688DF34  ldr      x8, [x8, #0x488]
00688DF38  ldr      x2, [x8]
00688DF3C  ldrb     w8, [x2, #0x53]
00688DF40  tbnz     w8, #5, #0x688df4c
00688DF44  str      w20, [x19, #0x44]
00688DF48  b        #0x688df5c ; 
00688DF4C  ldr      x8, [x2, #0x60]
00688DF50  mov      x0, x19
00688DF54  mov      w1, w20
00688DF58  blr      x8
00688DF5C  mov      x0, x19
00688DF60  mov      x1, xzr
00688DF64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688DF68  adrp     x21, #0x959c000
00688DF6C  ldrb     w8, [x21, #0x444]
00688DF70  mov      w20, w0
00688DF74  cbnz     w8, #0x688df8c
00688DF78  adrp     x0, #0x8f25000
00688DF7C  ldr      x0, [x0, #0x498]
00688DF80  bl       #0x382bd14 ; 
00688DF84  mov      w8, #1
00688DF88  strb     w8, [x21, #0x444]
00688DF8C  adrp     x8, #0x8f25000
00688DF90  ldr      x8, [x8, #0x498]
00688DF94  ldr      x2, [x8]
00688DF98  ldrb     w8, [x2, #0x53]
00688DF9C  tbnz     w8, #5, #0x688dfa8
00688DFA0  str      w20, [x19, #0x48]
00688DFA4  b        #0x688dfb8 ; 
00688DFA8  ldr      x8, [x2, #0x60]
00688DFAC  mov      x0, x19
00688DFB0  mov      w1, w20
00688DFB4  blr      x8
00688DFB8  mov      x0, x19
00688DFBC  mov      x1, xzr
00688DFC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688DFC4  adrp     x21, #0x959c000
00688DFC8  ldrb     w8, [x21, #0x445]
00688DFCC  mov      w20, w0
00688DFD0  cbnz     w8, #0x688dfe8
00688DFD4  adrp     x0, #0x8f25000
00688DFD8  ldr      x0, [x0, #0x4a8]
00688DFDC  bl       #0x382bd14 ; 
00688DFE0  mov      w8, #1
00688DFE4  strb     w8, [x21, #0x445]
00688DFE8  adrp     x8, #0x8f25000
00688DFEC  ldr      x8, [x8, #0x4a8]
00688DFF0  ldr      x2, [x8]
00688DFF4  ldrb     w8, [x2, #0x53]
00688DFF8  tbnz     w8, #5, #0x688e004
00688DFFC  str      w20, [x19, #0x4c]
00688E000  b        #0x688e014 ; 
00688E004  ldr      x8, [x2, #0x60]
00688E008  mov      x0, x19
00688E00C  mov      w1, w20
00688E010  blr      x8
00688E014  mov      x0, x19
00688E018  mov      x1, xzr
00688E01C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688E020  adrp     x21, #0x959c000
00688E024  ldrb     w8, [x21, #0x446]
00688E028  mov      x20, x0
00688E02C  cbnz     w8, #0x688e044
00688E030  adrp     x0, #0x8f25000
00688E034  ldr      x0, [x0, #0x4b8]
00688E038  bl       #0x382bd14 ; 
00688E03C  mov      w8, #1
00688E040  strb     w8, [x21, #0x446]
00688E044  adrp     x8, #0x8f25000
00688E048  ldr      x8, [x8, #0x4b8]
00688E04C  ldr      x2, [x8]
00688E050  ldrb     w8, [x2, #0x53]
00688E054  tbnz     w8, #5, #0x688e06c
00688E058  mov      x0, x19
00688E05C  str      x20, [x0, #0x50]!
00688E060  mov      x1, x20
00688E064  bl       #0x382bcb8 ; 
00688E068  b        #0x688e07c ; 
00688E06C  ldr      x8, [x2, #0x60]
00688E070  mov      x0, x19
00688E074  mov      x1, x20
00688E078  blr      x8
00688E07C  mov      x0, x19
00688E080  mov      x1, xzr
00688E084  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688E088  adrp     x21, #0x959c000
00688E08C  ldrb     w8, [x21, #0x447]
00688E090  mov      x20, x0
00688E094  cbnz     w8, #0x688e0ac
00688E098  adrp     x0, #0x8f25000
00688E09C  ldr      x0, [x0, #0x4c8]
00688E0A0  bl       #0x382bd14 ; 
00688E0A4  mov      w8, #1
00688E0A8  strb     w8, [x21, #0x447]
00688E0AC  adrp     x8, #0x8f25000
00688E0B0  ldr      x8, [x8, #0x4c8]
00688E0B4  ldr      x2, [x8]
00688E0B8  ldrb     w8, [x2, #0x53]
00688E0BC  tbnz     w8, #5, #0x688e0d4
00688E0C0  mov      x0, x19
00688E0C4  str      x20, [x0, #0x58]!
00688E0C8  mov      x1, x20
00688E0CC  bl       #0x382bcb8 ; 
00688E0D0  b        #0x688e0e4 ; 
00688E0D4  ldr      x8, [x2, #0x60]
00688E0D8  mov      x0, x19
00688E0DC  mov      x1, x20
00688E0E0  blr      x8
00688E0E4  mov      x0, x19
00688E0E8  mov      x1, xzr
00688E0EC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688E0F0  adrp     x21, #0x959c000
00688E0F4  ldrb     w8, [x21, #0x448]
00688E0F8  mov      x20, x0
00688E0FC  cbnz     w8, #0x688e114
00688E100  adrp     x0, #0x8f25000
00688E104  ldr      x0, [x0, #0x4d8]
00688E108  bl       #0x382bd14 ; 
00688E10C  mov      w8, #1
00688E110  strb     w8, [x21, #0x448]
00688E114  adrp     x8, #0x8f25000
00688E118  ldr      x8, [x8, #0x4d8]
00688E11C  ldr      x2, [x8]
00688E120  ldrb     w8, [x2, #0x53]
00688E124  tbnz     w8, #5, #0x688e13c
00688E128  mov      x0, x19
00688E12C  str      x20, [x0, #0x60]!
00688E130  mov      x1, x20
00688E134  bl       #0x382bcb8 ; 
00688E138  b        #0x688e14c ; 
00688E13C  ldr      x8, [x2, #0x60]
00688E140  mov      x0, x19
00688E144  mov      x1, x20
00688E148  blr      x8
00688E14C  mov      x0, x19
00688E150  mov      x1, xzr
00688E154  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688E158  adrp     x21, #0x959c000
00688E15C  ldrb     w8, [x21, #0x449]
00688E160  mov      x20, x0
00688E164  cbnz     w8, #0x688e17c
00688E168  adrp     x0, #0x8f25000
00688E16C  ldr      x0, [x0, #0x4e8]
00688E170  bl       #0x382bd14 ; 
00688E174  mov      w8, #1
00688E178  strb     w8, [x21, #0x449]
00688E17C  adrp     x8, #0x8f25000
00688E180  ldr      x8, [x8, #0x4e8]
00688E184  ldr      x2, [x8]
00688E188  ldrb     w8, [x2, #0x53]
00688E18C  tbnz     w8, #5, #0x688e1a4
00688E190  mov      x0, x19
00688E194  str      x20, [x0, #0x68]!
00688E198  mov      x1, x20
00688E19C  bl       #0x382bcb8 ; 
00688E1A0  b        #0x688e1b4 ; 
00688E1A4  ldr      x8, [x2, #0x60]
00688E1A8  mov      x0, x19
00688E1AC  mov      x1, x20
00688E1B0  blr      x8
00688E1B4  mov      x0, x19
00688E1B8  mov      x1, xzr
00688E1BC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688E1C0  adrp     x21, #0x959c000
00688E1C4  ldrb     w8, [x21, #0x44a]
00688E1C8  mov      x20, x0
00688E1CC  cbnz     w8, #0x688e1e4
00688E1D0  adrp     x0, #0x8f25000
00688E1D4  ldr      x0, [x0, #0x4f8]
00688E1D8  bl       #0x382bd14 ; 
00688E1DC  mov      w8, #1
00688E1E0  strb     w8, [x21, #0x44a]
00688E1E4  adrp     x8, #0x8f25000
00688E1E8  ldr      x8, [x8, #0x4f8]
00688E1EC  ldr      x2, [x8]
00688E1F0  ldrb     w8, [x2, #0x53]
00688E1F4  tbnz     w8, #5, #0x688e20c
00688E1F8  mov      x0, x19
00688E1FC  str      x20, [x0, #0x70]!
00688E200  mov      x1, x20
00688E204  bl       #0x382bcb8 ; 
00688E208  b        #0x688e21c ; 
00688E20C  ldr      x8, [x2, #0x60]
00688E210  mov      x0, x19
00688E214  mov      x1, x20
00688E218  blr      x8
00688E21C  mov      x0, x19
00688E220  mov      x1, xzr
00688E224  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688E228  adrp     x21, #0x959c000
00688E22C  ldrb     w8, [x21, #0x44b]
00688E230  mov      x20, x0
00688E234  cbnz     w8, #0x688e24c
00688E238  adrp     x0, #0x8f25000
00688E23C  ldr      x0, [x0, #0x508]
00688E240  bl       #0x382bd14 ; 
00688E244  mov      w8, #1
00688E248  strb     w8, [x21, #0x44b]
00688E24C  adrp     x8, #0x8f25000
00688E250  ldr      x8, [x8, #0x508]
00688E254  ldr      x2, [x8]
00688E258  ldrb     w8, [x2, #0x53]
00688E25C  tbnz     w8, #5, #0x688e274
00688E260  mov      x0, x19
00688E264  str      x20, [x0, #0x78]!
00688E268  mov      x1, x20
00688E26C  bl       #0x382bcb8 ; 
00688E270  b        #0x688e284 ; 
00688E274  ldr      x8, [x2, #0x60]
00688E278  mov      x0, x19
00688E27C  mov      x1, x20
00688E280  blr      x8
00688E284  mov      x0, x19
00688E288  mov      x1, xzr
00688E28C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688E290  adrp     x21, #0x959c000
00688E294  ldrb     w8, [x21, #0x44c]
00688E298  mov      x20, x0
00688E29C  cbnz     w8, #0x688e2b4
00688E2A0  adrp     x0, #0x8f25000
00688E2A4  ldr      x0, [x0, #0x518]
00688E2A8  bl       #0x382bd14 ; 
00688E2AC  mov      w8, #1
00688E2B0  strb     w8, [x21, #0x44c]
00688E2B4  adrp     x8, #0x8f25000
00688E2B8  ldr      x8, [x8, #0x518]
00688E2BC  ldr      x2, [x8]
00688E2C0  ldrb     w8, [x2, #0x53]
00688E2C4  tbnz     w8, #5, #0x688e2dc
00688E2C8  mov      x0, x19
00688E2CC  str      x20, [x0, #0x80]!
00688E2D0  mov      x1, x20
00688E2D4  bl       #0x382bcb8 ; 
00688E2D8  b        #0x688e2ec ; 
00688E2DC  ldr      x8, [x2, #0x60]
00688E2E0  mov      x0, x19
00688E2E4  mov      x1, x20
00688E2E8  blr      x8
00688E2EC  mov      x0, x19
00688E2F0  mov      x1, xzr
00688E2F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688E2F8  adrp     x21, #0x959c000
00688E2FC  ldrb     w8, [x21, #0x44d]
00688E300  mov      w20, w0
00688E304  cbnz     w8, #0x688e31c
00688E308  adrp     x0, #0x8f25000
00688E30C  ldr      x0, [x0, #0x528]
00688E310  bl       #0x382bd14 ; 
00688E314  mov      w8, #1
00688E318  strb     w8, [x21, #0x44d]
00688E31C  adrp     x8, #0x8f25000
00688E320  ldr      x8, [x8, #0x528]
00688E324  ldr      x2, [x8]
00688E328  ldrb     w8, [x2, #0x53]
00688E32C  tbnz     w8, #5, #0x688e338
00688E330  str      w20, [x19, #0x88]
00688E334  b        #0x688e348 ; 
00688E338  ldr      x8, [x2, #0x60]
00688E33C  mov      x0, x19
00688E340  mov      w1, w20
00688E344  blr      x8
00688E348  ldp      x20, x19, [sp, #0x10]
00688E34C  mov      w0, #1
00688E350  ldp      x30, x21, [sp], #0x20
00688E354  ret      

