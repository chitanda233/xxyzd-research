; LocalModels.Bean.Skill_Trigger$$readImpl
; RVA 0x6B0D9E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0D9E8  stp      x30, x21, [sp, #-0x20]!
006B0D9EC  stp      x20, x19, [sp, #0x10]
006B0D9F0  adrp     x20, #0x959f000
006B0D9F4  adrp     x21, #0x8f3e000
006B0D9F8  ldrb     w8, [x20, #0x4f2]
006B0D9FC  ldr      x21, [x21, #0xa58]
006B0DA00  mov      x19, x0
006B0DA04  tbnz     w8, #0, #0x6b0da1c
006B0DA08  adrp     x0, #0x8f3e000
006B0DA0C  ldr      x0, [x0, #0xa58]
006B0DA10  bl       #0x382bd14 ; 
006B0DA14  mov      w8, #1
006B0DA18  strb     w8, [x20, #0x4f2]
006B0DA1C  ldr      x1, [x21]
006B0DA20  ldrb     w8, [x1, #0x53]
006B0DA24  tbnz     w8, #5, #0x6b0da74
006B0DA28  mov      x0, x19
006B0DA2C  mov      x1, xzr
006B0DA30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DA34  adrp     x21, #0x959f000
006B0DA38  ldrb     w8, [x21, #0x97f]
006B0DA3C  mov      w20, w0
006B0DA40  cbnz     w8, #0x6b0da58
006B0DA44  adrp     x0, #0x8f3e000
006B0DA48  ldr      x0, [x0, #0x9d0]
006B0DA4C  bl       #0x382bd14 ; 
006B0DA50  mov      w8, #1
006B0DA54  strb     w8, [x21, #0x97f]
006B0DA58  adrp     x8, #0x8f3e000
006B0DA5C  ldr      x8, [x8, #0x9d0]
006B0DA60  ldr      x2, [x8]
006B0DA64  ldrb     w8, [x2, #0x53]
006B0DA68  tbnz     w8, #5, #0x6b0da88
006B0DA6C  str      w20, [x19, #0x20]
006B0DA70  b        #0x6b0da98 ; 
006B0DA74  ldr      x2, [x1, #0x60]
006B0DA78  mov      x0, x19
006B0DA7C  ldp      x20, x19, [sp, #0x10]
006B0DA80  ldp      x30, x21, [sp], #0x20
006B0DA84  br       x2
006B0DA88  ldr      x8, [x2, #0x60]
006B0DA8C  mov      x0, x19
006B0DA90  mov      w1, w20
006B0DA94  blr      x8
006B0DA98  mov      x0, x19
006B0DA9C  mov      x1, xzr
006B0DAA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DAA4  adrp     x21, #0x959f000
006B0DAA8  ldrb     w8, [x21, #0x980]
006B0DAAC  mov      w20, w0
006B0DAB0  cbnz     w8, #0x6b0dac8
006B0DAB4  adrp     x0, #0x8f3e000
006B0DAB8  ldr      x0, [x0, #0x9d8]
006B0DABC  bl       #0x382bd14 ; 
006B0DAC0  mov      w8, #1
006B0DAC4  strb     w8, [x21, #0x980]
006B0DAC8  adrp     x8, #0x8f3e000
006B0DACC  ldr      x8, [x8, #0x9d8]
006B0DAD0  ldr      x2, [x8]
006B0DAD4  ldrb     w8, [x2, #0x53]
006B0DAD8  tbnz     w8, #5, #0x6b0dae4
006B0DADC  str      w20, [x19, #0x24]
006B0DAE0  b        #0x6b0daf4 ; 
006B0DAE4  ldr      x8, [x2, #0x60]
006B0DAE8  mov      x0, x19
006B0DAEC  mov      w1, w20
006B0DAF0  blr      x8
006B0DAF4  mov      x0, x19
006B0DAF8  mov      x1, xzr
006B0DAFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DB00  adrp     x21, #0x959f000
006B0DB04  ldrb     w8, [x21, #0x981]
006B0DB08  mov      w20, w0
006B0DB0C  cbnz     w8, #0x6b0db24
006B0DB10  adrp     x0, #0x8f3e000
006B0DB14  ldr      x0, [x0, #0x9e0]
006B0DB18  bl       #0x382bd14 ; 
006B0DB1C  mov      w8, #1
006B0DB20  strb     w8, [x21, #0x981]
006B0DB24  adrp     x8, #0x8f3e000
006B0DB28  ldr      x8, [x8, #0x9e0]
006B0DB2C  ldr      x2, [x8]
006B0DB30  ldrb     w8, [x2, #0x53]
006B0DB34  tbnz     w8, #5, #0x6b0db40
006B0DB38  str      w20, [x19, #0x28]
006B0DB3C  b        #0x6b0db50 ; 
006B0DB40  ldr      x8, [x2, #0x60]
006B0DB44  mov      x0, x19
006B0DB48  mov      w1, w20
006B0DB4C  blr      x8
006B0DB50  mov      x0, x19
006B0DB54  mov      x1, xzr
006B0DB58  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0DB5C  adrp     x21, #0x959f000
006B0DB60  ldrb     w8, [x21, #0x982]
006B0DB64  mov      x20, x0
006B0DB68  cbnz     w8, #0x6b0db80
006B0DB6C  adrp     x0, #0x8f3e000
006B0DB70  ldr      x0, [x0, #0x9e8]
006B0DB74  bl       #0x382bd14 ; 
006B0DB78  mov      w8, #1
006B0DB7C  strb     w8, [x21, #0x982]
006B0DB80  adrp     x8, #0x8f3e000
006B0DB84  ldr      x8, [x8, #0x9e8]
006B0DB88  ldr      x2, [x8]
006B0DB8C  ldrb     w8, [x2, #0x53]
006B0DB90  tbnz     w8, #5, #0x6b0dba8
006B0DB94  mov      x0, x19
006B0DB98  str      x20, [x0, #0x30]!
006B0DB9C  mov      x1, x20
006B0DBA0  bl       #0x382bcb8 ; 
006B0DBA4  b        #0x6b0dbb8 ; 
006B0DBA8  ldr      x8, [x2, #0x60]
006B0DBAC  mov      x0, x19
006B0DBB0  mov      x1, x20
006B0DBB4  blr      x8
006B0DBB8  mov      x0, x19
006B0DBBC  mov      x1, xzr
006B0DBC0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B0DBC4  adrp     x21, #0x959f000
006B0DBC8  ldrb     w8, [x21, #0x983]
006B0DBCC  mov      x20, x0
006B0DBD0  cbnz     w8, #0x6b0dbe8
006B0DBD4  adrp     x0, #0x8f3e000
006B0DBD8  ldr      x0, [x0, #0x9f0]
006B0DBDC  bl       #0x382bd14 ; 
006B0DBE0  mov      w8, #1
006B0DBE4  strb     w8, [x21, #0x983]
006B0DBE8  adrp     x8, #0x8f3e000
006B0DBEC  ldr      x8, [x8, #0x9f0]
006B0DBF0  ldr      x2, [x8]
006B0DBF4  ldrb     w8, [x2, #0x53]
006B0DBF8  tbnz     w8, #5, #0x6b0dc04
006B0DBFC  str      x20, [x19, #0x38]
006B0DC00  b        #0x6b0dc14 ; 
006B0DC04  ldr      x8, [x2, #0x60]
006B0DC08  mov      x0, x19
006B0DC0C  mov      x1, x20
006B0DC10  blr      x8
006B0DC14  mov      x0, x19
006B0DC18  mov      x1, xzr
006B0DC1C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B0DC20  adrp     x21, #0x959f000
006B0DC24  ldrb     w8, [x21, #0x984]
006B0DC28  mov      x20, x0
006B0DC2C  cbnz     w8, #0x6b0dc44
006B0DC30  adrp     x0, #0x8f3e000
006B0DC34  ldr      x0, [x0, #0x9f8]
006B0DC38  bl       #0x382bd14 ; 
006B0DC3C  mov      w8, #1
006B0DC40  strb     w8, [x21, #0x984]
006B0DC44  adrp     x8, #0x8f3e000
006B0DC48  ldr      x8, [x8, #0x9f8]
006B0DC4C  ldr      x2, [x8]
006B0DC50  ldrb     w8, [x2, #0x53]
006B0DC54  tbnz     w8, #5, #0x6b0dc60
006B0DC58  str      x20, [x19, #0x40]
006B0DC5C  b        #0x6b0dc70 ; 
006B0DC60  ldr      x8, [x2, #0x60]
006B0DC64  mov      x0, x19
006B0DC68  mov      x1, x20
006B0DC6C  blr      x8
006B0DC70  mov      x0, x19
006B0DC74  mov      x1, xzr
006B0DC78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DC7C  adrp     x21, #0x959f000
006B0DC80  ldrb     w8, [x21, #0x985]
006B0DC84  mov      w20, w0
006B0DC88  cbnz     w8, #0x6b0dca0
006B0DC8C  adrp     x0, #0x8f3e000
006B0DC90  ldr      x0, [x0, #0xa00]
006B0DC94  bl       #0x382bd14 ; 
006B0DC98  mov      w8, #1
006B0DC9C  strb     w8, [x21, #0x985]
006B0DCA0  adrp     x8, #0x8f3e000
006B0DCA4  ldr      x8, [x8, #0xa00]
006B0DCA8  ldr      x2, [x8]
006B0DCAC  ldrb     w8, [x2, #0x53]
006B0DCB0  tbnz     w8, #5, #0x6b0dcbc
006B0DCB4  str      w20, [x19, #0x48]
006B0DCB8  b        #0x6b0dccc ; 
006B0DCBC  ldr      x8, [x2, #0x60]
006B0DCC0  mov      x0, x19
006B0DCC4  mov      w1, w20
006B0DCC8  blr      x8
006B0DCCC  mov      x0, x19
006B0DCD0  mov      x1, xzr
006B0DCD4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B0DCD8  adrp     x21, #0x959f000
006B0DCDC  ldrb     w8, [x21, #0x986]
006B0DCE0  mov      x20, x0
006B0DCE4  cbnz     w8, #0x6b0dcfc
006B0DCE8  adrp     x0, #0x8f3e000
006B0DCEC  ldr      x0, [x0, #0xa08]
006B0DCF0  bl       #0x382bd14 ; 
006B0DCF4  mov      w8, #1
006B0DCF8  strb     w8, [x21, #0x986]
006B0DCFC  adrp     x8, #0x8f3e000
006B0DD00  ldr      x8, [x8, #0xa08]
006B0DD04  ldr      x2, [x8]
006B0DD08  ldrb     w8, [x2, #0x53]
006B0DD0C  tbnz     w8, #5, #0x6b0dd18
006B0DD10  str      x20, [x19, #0x50]
006B0DD14  b        #0x6b0dd28 ; 
006B0DD18  ldr      x8, [x2, #0x60]
006B0DD1C  mov      x0, x19
006B0DD20  mov      x1, x20
006B0DD24  blr      x8
006B0DD28  mov      x0, x19
006B0DD2C  mov      x1, xzr
006B0DD30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DD34  adrp     x21, #0x959f000
006B0DD38  ldrb     w8, [x21, #0x987]
006B0DD3C  mov      w20, w0
006B0DD40  cbnz     w8, #0x6b0dd58
006B0DD44  adrp     x0, #0x8f3e000
006B0DD48  ldr      x0, [x0, #0xa10]
006B0DD4C  bl       #0x382bd14 ; 
006B0DD50  mov      w8, #1
006B0DD54  strb     w8, [x21, #0x987]
006B0DD58  adrp     x8, #0x8f3e000
006B0DD5C  ldr      x8, [x8, #0xa10]
006B0DD60  ldr      x2, [x8]
006B0DD64  ldrb     w8, [x2, #0x53]
006B0DD68  tbnz     w8, #5, #0x6b0dd74
006B0DD6C  str      w20, [x19, #0x58]
006B0DD70  b        #0x6b0dd84 ; 
006B0DD74  ldr      x8, [x2, #0x60]
006B0DD78  mov      x0, x19
006B0DD7C  mov      w1, w20
006B0DD80  blr      x8
006B0DD84  mov      x0, x19
006B0DD88  mov      x1, xzr
006B0DD8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DD90  adrp     x21, #0x959f000
006B0DD94  ldrb     w8, [x21, #0x988]
006B0DD98  mov      w20, w0
006B0DD9C  cbnz     w8, #0x6b0ddb4
006B0DDA0  adrp     x0, #0x8f3e000
006B0DDA4  ldr      x0, [x0, #0xa18]
006B0DDA8  bl       #0x382bd14 ; 
006B0DDAC  mov      w8, #1
006B0DDB0  strb     w8, [x21, #0x988]
006B0DDB4  adrp     x8, #0x8f3e000
006B0DDB8  ldr      x8, [x8, #0xa18]
006B0DDBC  ldr      x2, [x8]
006B0DDC0  ldrb     w8, [x2, #0x53]
006B0DDC4  tbnz     w8, #5, #0x6b0ddd0
006B0DDC8  str      w20, [x19, #0x5c]
006B0DDCC  b        #0x6b0dde0 ; 
006B0DDD0  ldr      x8, [x2, #0x60]
006B0DDD4  mov      x0, x19
006B0DDD8  mov      w1, w20
006B0DDDC  blr      x8
006B0DDE0  mov      x0, x19
006B0DDE4  mov      x1, xzr
006B0DDE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DDEC  adrp     x21, #0x959f000
006B0DDF0  ldrb     w8, [x21, #0x989]
006B0DDF4  mov      w20, w0
006B0DDF8  cbnz     w8, #0x6b0de10
006B0DDFC  adrp     x0, #0x8f3e000
006B0DE00  ldr      x0, [x0, #0xa20]
006B0DE04  bl       #0x382bd14 ; 
006B0DE08  mov      w8, #1
006B0DE0C  strb     w8, [x21, #0x989]
006B0DE10  adrp     x8, #0x8f3e000
006B0DE14  ldr      x8, [x8, #0xa20]
006B0DE18  ldr      x2, [x8]
006B0DE1C  ldrb     w8, [x2, #0x53]
006B0DE20  tbnz     w8, #5, #0x6b0de2c
006B0DE24  str      w20, [x19, #0x60]
006B0DE28  b        #0x6b0de3c ; 
006B0DE2C  ldr      x8, [x2, #0x60]
006B0DE30  mov      x0, x19
006B0DE34  mov      w1, w20
006B0DE38  blr      x8
006B0DE3C  mov      x0, x19
006B0DE40  mov      x1, xzr
006B0DE44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0DE48  adrp     x21, #0x959f000
006B0DE4C  ldrb     w8, [x21, #0x98a]
006B0DE50  mov      x20, x0
006B0DE54  cbnz     w8, #0x6b0de6c
006B0DE58  adrp     x0, #0x8f3e000
006B0DE5C  ldr      x0, [x0, #0xa28]
006B0DE60  bl       #0x382bd14 ; 
006B0DE64  mov      w8, #1
006B0DE68  strb     w8, [x21, #0x98a]
006B0DE6C  adrp     x8, #0x8f3e000
006B0DE70  ldr      x8, [x8, #0xa28]
006B0DE74  ldr      x2, [x8]
006B0DE78  ldrb     w8, [x2, #0x53]
006B0DE7C  tbnz     w8, #5, #0x6b0de94
006B0DE80  mov      x0, x19
006B0DE84  str      x20, [x0, #0x68]!
006B0DE88  mov      x1, x20
006B0DE8C  bl       #0x382bcb8 ; 
006B0DE90  b        #0x6b0dea4 ; 
006B0DE94  ldr      x8, [x2, #0x60]
006B0DE98  mov      x0, x19
006B0DE9C  mov      x1, x20
006B0DEA0  blr      x8
006B0DEA4  mov      x0, x19
006B0DEA8  mov      x1, xzr
006B0DEAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DEB0  adrp     x21, #0x959f000
006B0DEB4  ldrb     w8, [x21, #0x98b]
006B0DEB8  mov      w20, w0
006B0DEBC  cbnz     w8, #0x6b0ded4
006B0DEC0  adrp     x0, #0x8f3e000
006B0DEC4  ldr      x0, [x0, #0xa30]
006B0DEC8  bl       #0x382bd14 ; 
006B0DECC  mov      w8, #1
006B0DED0  strb     w8, [x21, #0x98b]
006B0DED4  adrp     x8, #0x8f3e000
006B0DED8  ldr      x8, [x8, #0xa30]
006B0DEDC  ldr      x2, [x8]
006B0DEE0  ldrb     w8, [x2, #0x53]
006B0DEE4  tbnz     w8, #5, #0x6b0def0
006B0DEE8  str      w20, [x19, #0x70]
006B0DEEC  b        #0x6b0df00 ; 
006B0DEF0  ldr      x8, [x2, #0x60]
006B0DEF4  mov      x0, x19
006B0DEF8  mov      w1, w20
006B0DEFC  blr      x8
006B0DF00  mov      x0, x19
006B0DF04  mov      x1, xzr
006B0DF08  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0DF0C  adrp     x21, #0x959f000
006B0DF10  ldrb     w8, [x21, #0x98c]
006B0DF14  mov      x20, x0
006B0DF18  cbnz     w8, #0x6b0df30
006B0DF1C  adrp     x0, #0x8f3e000
006B0DF20  ldr      x0, [x0, #0xa38]
006B0DF24  bl       #0x382bd14 ; 
006B0DF28  mov      w8, #1
006B0DF2C  strb     w8, [x21, #0x98c]
006B0DF30  adrp     x8, #0x8f3e000
006B0DF34  ldr      x8, [x8, #0xa38]
006B0DF38  ldr      x2, [x8]
006B0DF3C  ldrb     w8, [x2, #0x53]
006B0DF40  tbnz     w8, #5, #0x6b0df58
006B0DF44  mov      x0, x19
006B0DF48  str      x20, [x0, #0x78]!
006B0DF4C  mov      x1, x20
006B0DF50  bl       #0x382bcb8 ; 
006B0DF54  b        #0x6b0df68 ; 
006B0DF58  ldr      x8, [x2, #0x60]
006B0DF5C  mov      x0, x19
006B0DF60  mov      x1, x20
006B0DF64  blr      x8
006B0DF68  mov      x0, x19
006B0DF6C  mov      x1, xzr
006B0DF70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DF74  adrp     x21, #0x959f000
006B0DF78  ldrb     w8, [x21, #0x98d]
006B0DF7C  mov      w20, w0
006B0DF80  cbnz     w8, #0x6b0df98
006B0DF84  adrp     x0, #0x8f3e000
006B0DF88  ldr      x0, [x0, #0xa40]
006B0DF8C  bl       #0x382bd14 ; 
006B0DF90  mov      w8, #1
006B0DF94  strb     w8, [x21, #0x98d]
006B0DF98  adrp     x8, #0x8f3e000
006B0DF9C  ldr      x8, [x8, #0xa40]
006B0DFA0  ldr      x2, [x8]
006B0DFA4  ldrb     w8, [x2, #0x53]
006B0DFA8  tbnz     w8, #5, #0x6b0dfb4
006B0DFAC  str      w20, [x19, #0x80]
006B0DFB0  b        #0x6b0dfc4 ; 
006B0DFB4  ldr      x8, [x2, #0x60]
006B0DFB8  mov      x0, x19
006B0DFBC  mov      w1, w20
006B0DFC0  blr      x8
006B0DFC4  mov      x0, x19
006B0DFC8  mov      x1, xzr
006B0DFCC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0DFD0  adrp     x21, #0x959f000
006B0DFD4  ldrb     w8, [x21, #0x98e]
006B0DFD8  mov      w20, w0
006B0DFDC  cbnz     w8, #0x6b0dff4
006B0DFE0  adrp     x0, #0x8f3e000
006B0DFE4  ldr      x0, [x0, #0xa50]
006B0DFE8  bl       #0x382bd14 ; 
006B0DFEC  mov      w8, #1
006B0DFF0  strb     w8, [x21, #0x98e]
006B0DFF4  adrp     x8, #0x8f3e000
006B0DFF8  ldr      x8, [x8, #0xa50]
006B0DFFC  ldr      x2, [x8]
006B0E000  ldrb     w8, [x2, #0x53]
006B0E004  tbnz     w8, #5, #0x6b0e010
006B0E008  str      w20, [x19, #0x84]
006B0E00C  b        #0x6b0e020 ; 
006B0E010  ldr      x8, [x2, #0x60]
006B0E014  mov      x0, x19
006B0E018  mov      w1, w20
006B0E01C  blr      x8
006B0E020  ldp      x20, x19, [sp, #0x10]
006B0E024  mov      w0, #1
006B0E028  ldp      x30, x21, [sp], #0x20
006B0E02C  ret      

