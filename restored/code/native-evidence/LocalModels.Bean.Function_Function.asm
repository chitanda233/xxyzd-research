; LocalModels.Bean.Function_Function$$readImpl
; RVA 0x6A7D774; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7D774  stp      x30, x21, [sp, #-0x20]!
006A7D778  stp      x20, x19, [sp, #0x10]
006A7D77C  adrp     x20, #0x959d000
006A7D780  adrp     x21, #0x8f37000
006A7D784  ldrb     w8, [x20, #0xefa]
006A7D788  ldr      x21, [x21, #0xfe0]
006A7D78C  mov      x19, x0
006A7D790  tbnz     w8, #0, #0x6a7d7a8
006A7D794  adrp     x0, #0x8f37000
006A7D798  ldr      x0, [x0, #0xfe0]
006A7D79C  bl       #0x382bd14 ; 
006A7D7A0  mov      w8, #1
006A7D7A4  strb     w8, [x20, #0xefa]
006A7D7A8  ldr      x1, [x21]
006A7D7AC  ldrb     w8, [x1, #0x53]
006A7D7B0  tbnz     w8, #5, #0x6a7d800
006A7D7B4  mov      x0, x19
006A7D7B8  mov      x1, xzr
006A7D7BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7D7C0  adrp     x21, #0x959e000
006A7D7C4  ldrb     w8, [x21, #0x4da]
006A7D7C8  mov      w20, w0
006A7D7CC  cbnz     w8, #0x6a7d7e4
006A7D7D0  adrp     x0, #0x8f37000
006A7D7D4  ldr      x0, [x0, #0xf28]
006A7D7D8  bl       #0x382bd14 ; 
006A7D7DC  mov      w8, #1
006A7D7E0  strb     w8, [x21, #0x4da]
006A7D7E4  adrp     x8, #0x8f37000
006A7D7E8  ldr      x8, [x8, #0xf28]
006A7D7EC  ldr      x2, [x8]
006A7D7F0  ldrb     w8, [x2, #0x53]
006A7D7F4  tbnz     w8, #5, #0x6a7d814
006A7D7F8  str      w20, [x19, #0x20]
006A7D7FC  b        #0x6a7d824 ; 
006A7D800  ldr      x2, [x1, #0x60]
006A7D804  mov      x0, x19
006A7D808  ldp      x20, x19, [sp, #0x10]
006A7D80C  ldp      x30, x21, [sp], #0x20
006A7D810  br       x2
006A7D814  ldr      x8, [x2, #0x60]
006A7D818  mov      x0, x19
006A7D81C  mov      w1, w20
006A7D820  blr      x8
006A7D824  mov      x0, x19
006A7D828  mov      x1, xzr
006A7D82C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7D830  adrp     x21, #0x959e000
006A7D834  ldrb     w8, [x21, #0x4db]
006A7D838  mov      w20, w0
006A7D83C  cbnz     w8, #0x6a7d854
006A7D840  adrp     x0, #0x8f37000
006A7D844  ldr      x0, [x0, #0xf38]
006A7D848  bl       #0x382bd14 ; 
006A7D84C  mov      w8, #1
006A7D850  strb     w8, [x21, #0x4db]
006A7D854  adrp     x8, #0x8f37000
006A7D858  ldr      x8, [x8, #0xf38]
006A7D85C  ldr      x2, [x8]
006A7D860  ldrb     w8, [x2, #0x53]
006A7D864  tbnz     w8, #5, #0x6a7d870
006A7D868  str      w20, [x19, #0x24]
006A7D86C  b        #0x6a7d880 ; 
006A7D870  ldr      x8, [x2, #0x60]
006A7D874  mov      x0, x19
006A7D878  mov      w1, w20
006A7D87C  blr      x8
006A7D880  mov      x0, x19
006A7D884  mov      x1, xzr
006A7D888  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7D88C  adrp     x21, #0x959e000
006A7D890  ldrb     w8, [x21, #0x4dc]
006A7D894  mov      x20, x0
006A7D898  cbnz     w8, #0x6a7d8b0
006A7D89C  adrp     x0, #0x8f37000
006A7D8A0  ldr      x0, [x0, #0xf48]
006A7D8A4  bl       #0x382bd14 ; 
006A7D8A8  mov      w8, #1
006A7D8AC  strb     w8, [x21, #0x4dc]
006A7D8B0  adrp     x8, #0x8f37000
006A7D8B4  ldr      x8, [x8, #0xf48]
006A7D8B8  ldr      x2, [x8]
006A7D8BC  ldrb     w8, [x2, #0x53]
006A7D8C0  tbnz     w8, #5, #0x6a7d8d8
006A7D8C4  mov      x0, x19
006A7D8C8  str      x20, [x0, #0x28]!
006A7D8CC  mov      x1, x20
006A7D8D0  bl       #0x382bcb8 ; 
006A7D8D4  b        #0x6a7d8e8 ; 
006A7D8D8  ldr      x8, [x2, #0x60]
006A7D8DC  mov      x0, x19
006A7D8E0  mov      x1, x20
006A7D8E4  blr      x8
006A7D8E8  mov      x0, x19
006A7D8EC  mov      x1, xzr
006A7D8F0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7D8F4  adrp     x21, #0x959e000
006A7D8F8  ldrb     w8, [x21, #0x4dd]
006A7D8FC  mov      x20, x0
006A7D900  cbnz     w8, #0x6a7d918
006A7D904  adrp     x0, #0x8f37000
006A7D908  ldr      x0, [x0, #0xf58]
006A7D90C  bl       #0x382bd14 ; 
006A7D910  mov      w8, #1
006A7D914  strb     w8, [x21, #0x4dd]
006A7D918  adrp     x8, #0x8f37000
006A7D91C  ldr      x8, [x8, #0xf58]
006A7D920  ldr      x2, [x8]
006A7D924  ldrb     w8, [x2, #0x53]
006A7D928  tbnz     w8, #5, #0x6a7d940
006A7D92C  mov      x0, x19
006A7D930  str      x20, [x0, #0x30]!
006A7D934  mov      x1, x20
006A7D938  bl       #0x382bcb8 ; 
006A7D93C  b        #0x6a7d950 ; 
006A7D940  ldr      x8, [x2, #0x60]
006A7D944  mov      x0, x19
006A7D948  mov      x1, x20
006A7D94C  blr      x8
006A7D950  mov      x0, x19
006A7D954  mov      x1, xzr
006A7D958  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7D95C  adrp     x21, #0x959e000
006A7D960  ldrb     w8, [x21, #0x4de]
006A7D964  mov      x20, x0
006A7D968  cbnz     w8, #0x6a7d980
006A7D96C  adrp     x0, #0x8f37000
006A7D970  ldr      x0, [x0, #0xf68]
006A7D974  bl       #0x382bd14 ; 
006A7D978  mov      w8, #1
006A7D97C  strb     w8, [x21, #0x4de]
006A7D980  adrp     x8, #0x8f37000
006A7D984  ldr      x8, [x8, #0xf68]
006A7D988  ldr      x2, [x8]
006A7D98C  ldrb     w8, [x2, #0x53]
006A7D990  tbnz     w8, #5, #0x6a7d9a8
006A7D994  mov      x0, x19
006A7D998  str      x20, [x0, #0x38]!
006A7D99C  mov      x1, x20
006A7D9A0  bl       #0x382bcb8 ; 
006A7D9A4  b        #0x6a7d9b8 ; 
006A7D9A8  ldr      x8, [x2, #0x60]
006A7D9AC  mov      x0, x19
006A7D9B0  mov      x1, x20
006A7D9B4  blr      x8
006A7D9B8  mov      x0, x19
006A7D9BC  mov      x1, xzr
006A7D9C0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7D9C4  adrp     x21, #0x959e000
006A7D9C8  ldrb     w8, [x21, #0x4df]
006A7D9CC  mov      x20, x0
006A7D9D0  cbnz     w8, #0x6a7d9e8
006A7D9D4  adrp     x0, #0x8f37000
006A7D9D8  ldr      x0, [x0, #0xf78]
006A7D9DC  bl       #0x382bd14 ; 
006A7D9E0  mov      w8, #1
006A7D9E4  strb     w8, [x21, #0x4df]
006A7D9E8  adrp     x8, #0x8f37000
006A7D9EC  ldr      x8, [x8, #0xf78]
006A7D9F0  ldr      x2, [x8]
006A7D9F4  ldrb     w8, [x2, #0x53]
006A7D9F8  tbnz     w8, #5, #0x6a7da10
006A7D9FC  mov      x0, x19
006A7DA00  str      x20, [x0, #0x40]!
006A7DA04  mov      x1, x20
006A7DA08  bl       #0x382bcb8 ; 
006A7DA0C  b        #0x6a7da20 ; 
006A7DA10  ldr      x8, [x2, #0x60]
006A7DA14  mov      x0, x19
006A7DA18  mov      x1, x20
006A7DA1C  blr      x8
006A7DA20  mov      x0, x19
006A7DA24  mov      x1, xzr
006A7DA28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7DA2C  adrp     x21, #0x959e000
006A7DA30  ldrb     w8, [x21, #0x4e0]
006A7DA34  mov      w20, w0
006A7DA38  cbnz     w8, #0x6a7da50
006A7DA3C  adrp     x0, #0x8f37000
006A7DA40  ldr      x0, [x0, #0xf88]
006A7DA44  bl       #0x382bd14 ; 
006A7DA48  mov      w8, #1
006A7DA4C  strb     w8, [x21, #0x4e0]
006A7DA50  adrp     x8, #0x8f37000
006A7DA54  ldr      x8, [x8, #0xf88]
006A7DA58  ldr      x2, [x8]
006A7DA5C  ldrb     w8, [x2, #0x53]
006A7DA60  tbnz     w8, #5, #0x6a7da6c
006A7DA64  str      w20, [x19, #0x48]
006A7DA68  b        #0x6a7da7c ; 
006A7DA6C  ldr      x8, [x2, #0x60]
006A7DA70  mov      x0, x19
006A7DA74  mov      w1, w20
006A7DA78  blr      x8
006A7DA7C  mov      x0, x19
006A7DA80  mov      x1, xzr
006A7DA84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7DA88  adrp     x21, #0x959e000
006A7DA8C  ldrb     w8, [x21, #0x4e1]
006A7DA90  mov      w20, w0
006A7DA94  cbnz     w8, #0x6a7daac
006A7DA98  adrp     x0, #0x8f37000
006A7DA9C  ldr      x0, [x0, #0xf98]
006A7DAA0  bl       #0x382bd14 ; 
006A7DAA4  mov      w8, #1
006A7DAA8  strb     w8, [x21, #0x4e1]
006A7DAAC  adrp     x8, #0x8f37000
006A7DAB0  ldr      x8, [x8, #0xf98]
006A7DAB4  ldr      x2, [x8]
006A7DAB8  ldrb     w8, [x2, #0x53]
006A7DABC  tbnz     w8, #5, #0x6a7dac8
006A7DAC0  str      w20, [x19, #0x4c]
006A7DAC4  b        #0x6a7dad8 ; 
006A7DAC8  ldr      x8, [x2, #0x60]
006A7DACC  mov      x0, x19
006A7DAD0  mov      w1, w20
006A7DAD4  blr      x8
006A7DAD8  mov      x0, x19
006A7DADC  mov      x1, xzr
006A7DAE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7DAE4  adrp     x21, #0x959e000
006A7DAE8  ldrb     w8, [x21, #0x4e2]
006A7DAEC  mov      w20, w0
006A7DAF0  cbnz     w8, #0x6a7db08
006A7DAF4  adrp     x0, #0x8f37000
006A7DAF8  ldr      x0, [x0, #0xfa8]
006A7DAFC  bl       #0x382bd14 ; 
006A7DB00  mov      w8, #1
006A7DB04  strb     w8, [x21, #0x4e2]
006A7DB08  adrp     x8, #0x8f37000
006A7DB0C  ldr      x8, [x8, #0xfa8]
006A7DB10  ldr      x2, [x8]
006A7DB14  ldrb     w8, [x2, #0x53]
006A7DB18  tbnz     w8, #5, #0x6a7db24
006A7DB1C  str      w20, [x19, #0x50]
006A7DB20  b        #0x6a7db34 ; 
006A7DB24  ldr      x8, [x2, #0x60]
006A7DB28  mov      x0, x19
006A7DB2C  mov      w1, w20
006A7DB30  blr      x8
006A7DB34  mov      x0, x19
006A7DB38  mov      x1, xzr
006A7DB3C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7DB40  adrp     x21, #0x959e000
006A7DB44  ldrb     w8, [x21, #0x4e3]
006A7DB48  mov      x20, x0
006A7DB4C  cbnz     w8, #0x6a7db64
006A7DB50  adrp     x0, #0x8f37000
006A7DB54  ldr      x0, [x0, #0xfb8]
006A7DB58  bl       #0x382bd14 ; 
006A7DB5C  mov      w8, #1
006A7DB60  strb     w8, [x21, #0x4e3]
006A7DB64  adrp     x8, #0x8f37000
006A7DB68  ldr      x8, [x8, #0xfb8]
006A7DB6C  ldr      x2, [x8]
006A7DB70  ldrb     w8, [x2, #0x53]
006A7DB74  tbnz     w8, #5, #0x6a7db8c
006A7DB78  mov      x0, x19
006A7DB7C  str      x20, [x0, #0x58]!
006A7DB80  mov      x1, x20
006A7DB84  bl       #0x382bcb8 ; 
006A7DB88  b        #0x6a7db9c ; 
006A7DB8C  ldr      x8, [x2, #0x60]
006A7DB90  mov      x0, x19
006A7DB94  mov      x1, x20
006A7DB98  blr      x8
006A7DB9C  mov      x0, x19
006A7DBA0  mov      x1, xzr
006A7DBA4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7DBA8  adrp     x21, #0x959e000
006A7DBAC  ldrb     w8, [x21, #0x4e4]
006A7DBB0  mov      x20, x0
006A7DBB4  cbnz     w8, #0x6a7dbcc
006A7DBB8  adrp     x0, #0x8f37000
006A7DBBC  ldr      x0, [x0, #0xfc8]
006A7DBC0  bl       #0x382bd14 ; 
006A7DBC4  mov      w8, #1
006A7DBC8  strb     w8, [x21, #0x4e4]
006A7DBCC  adrp     x8, #0x8f37000
006A7DBD0  ldr      x8, [x8, #0xfc8]
006A7DBD4  ldr      x2, [x8]
006A7DBD8  ldrb     w8, [x2, #0x53]
006A7DBDC  tbnz     w8, #5, #0x6a7dbf4
006A7DBE0  mov      x0, x19
006A7DBE4  str      x20, [x0, #0x60]!
006A7DBE8  mov      x1, x20
006A7DBEC  bl       #0x382bcb8 ; 
006A7DBF0  b        #0x6a7dc04 ; 
006A7DBF4  ldr      x8, [x2, #0x60]
006A7DBF8  mov      x0, x19
006A7DBFC  mov      x1, x20
006A7DC00  blr      x8
006A7DC04  mov      x0, x19
006A7DC08  mov      x1, xzr
006A7DC0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7DC10  adrp     x21, #0x959e000
006A7DC14  ldrb     w8, [x21, #0x4e5]
006A7DC18  mov      w20, w0
006A7DC1C  cbnz     w8, #0x6a7dc34
006A7DC20  adrp     x0, #0x8f37000
006A7DC24  ldr      x0, [x0, #0xfd8]
006A7DC28  bl       #0x382bd14 ; 
006A7DC2C  mov      w8, #1
006A7DC30  strb     w8, [x21, #0x4e5]
006A7DC34  adrp     x8, #0x8f37000
006A7DC38  ldr      x8, [x8, #0xfd8]
006A7DC3C  ldr      x2, [x8]
006A7DC40  ldrb     w8, [x2, #0x53]
006A7DC44  tbnz     w8, #5, #0x6a7dc50
006A7DC48  str      w20, [x19, #0x68]
006A7DC4C  b        #0x6a7dc60 ; 
006A7DC50  ldr      x8, [x2, #0x60]
006A7DC54  mov      x0, x19
006A7DC58  mov      w1, w20
006A7DC5C  blr      x8
006A7DC60  ldp      x20, x19, [sp, #0x10]
006A7DC64  mov      w0, #1
006A7DC68  ldp      x30, x21, [sp], #0x20
006A7DC6C  ret      

