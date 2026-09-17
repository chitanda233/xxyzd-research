; LocalModels.Bean.Equipment_Equip$$readImpl
; RVA 0x6A65E18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A65E18  stp      x30, x21, [sp, #-0x20]!
006A65E1C  stp      x20, x19, [sp, #0x10]
006A65E20  adrp     x20, #0x959d000
006A65E24  adrp     x21, #0x8f36000
006A65E28  ldrb     w8, [x20, #0xc8a]
006A65E2C  ldr      x21, [x21, #0xdc0]
006A65E30  mov      x19, x0
006A65E34  tbnz     w8, #0, #0x6a65e4c
006A65E38  adrp     x0, #0x8f36000
006A65E3C  ldr      x0, [x0, #0xdc0]
006A65E40  bl       #0x382bd14 ; 
006A65E44  mov      w8, #1
006A65E48  strb     w8, [x20, #0xc8a]
006A65E4C  ldr      x1, [x21]
006A65E50  ldrb     w8, [x1, #0x53]
006A65E54  tbnz     w8, #5, #0x6a65ea4
006A65E58  mov      x0, x19
006A65E5C  mov      x1, xzr
006A65E60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A65E64  adrp     x21, #0x959e000
006A65E68  ldrb     w8, [x21, #0x3d5]
006A65E6C  mov      w20, w0
006A65E70  cbnz     w8, #0x6a65e88
006A65E74  adrp     x0, #0x8f36000
006A65E78  ldr      x0, [x0, #0xce8]
006A65E7C  bl       #0x382bd14 ; 
006A65E80  mov      w8, #1
006A65E84  strb     w8, [x21, #0x3d5]
006A65E88  adrp     x8, #0x8f36000
006A65E8C  ldr      x8, [x8, #0xce8]
006A65E90  ldr      x2, [x8]
006A65E94  ldrb     w8, [x2, #0x53]
006A65E98  tbnz     w8, #5, #0x6a65eb8
006A65E9C  str      w20, [x19, #0x20]
006A65EA0  b        #0x6a65ec8 ; 
006A65EA4  ldr      x2, [x1, #0x60]
006A65EA8  mov      x0, x19
006A65EAC  ldp      x20, x19, [sp, #0x10]
006A65EB0  ldp      x30, x21, [sp], #0x20
006A65EB4  br       x2
006A65EB8  ldr      x8, [x2, #0x60]
006A65EBC  mov      x0, x19
006A65EC0  mov      w1, w20
006A65EC4  blr      x8
006A65EC8  mov      x0, x19
006A65ECC  mov      x1, xzr
006A65ED0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A65ED4  adrp     x21, #0x959e000
006A65ED8  ldrb     w8, [x21, #0x3d6]
006A65EDC  mov      w20, w0
006A65EE0  cbnz     w8, #0x6a65ef8
006A65EE4  adrp     x0, #0x8f36000
006A65EE8  ldr      x0, [x0, #0xcf0]
006A65EEC  bl       #0x382bd14 ; 
006A65EF0  mov      w8, #1
006A65EF4  strb     w8, [x21, #0x3d6]
006A65EF8  adrp     x8, #0x8f36000
006A65EFC  ldr      x8, [x8, #0xcf0]
006A65F00  ldr      x2, [x8]
006A65F04  ldrb     w8, [x2, #0x53]
006A65F08  tbnz     w8, #5, #0x6a65f14
006A65F0C  str      w20, [x19, #0x24]
006A65F10  b        #0x6a65f24 ; 
006A65F14  ldr      x8, [x2, #0x60]
006A65F18  mov      x0, x19
006A65F1C  mov      w1, w20
006A65F20  blr      x8
006A65F24  mov      x0, x19
006A65F28  mov      x1, xzr
006A65F2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A65F30  adrp     x21, #0x959e000
006A65F34  ldrb     w8, [x21, #0x3d7]
006A65F38  mov      w20, w0
006A65F3C  cbnz     w8, #0x6a65f54
006A65F40  adrp     x0, #0x8f36000
006A65F44  ldr      x0, [x0, #0xcf8]
006A65F48  bl       #0x382bd14 ; 
006A65F4C  mov      w8, #1
006A65F50  strb     w8, [x21, #0x3d7]
006A65F54  adrp     x8, #0x8f36000
006A65F58  ldr      x8, [x8, #0xcf8]
006A65F5C  ldr      x2, [x8]
006A65F60  ldrb     w8, [x2, #0x53]
006A65F64  tbnz     w8, #5, #0x6a65f70
006A65F68  str      w20, [x19, #0x28]
006A65F6C  b        #0x6a65f80 ; 
006A65F70  ldr      x8, [x2, #0x60]
006A65F74  mov      x0, x19
006A65F78  mov      w1, w20
006A65F7C  blr      x8
006A65F80  mov      x0, x19
006A65F84  mov      x1, xzr
006A65F88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A65F8C  adrp     x21, #0x959e000
006A65F90  ldrb     w8, [x21, #0x3d8]
006A65F94  mov      w20, w0
006A65F98  cbnz     w8, #0x6a65fb0
006A65F9C  adrp     x0, #0x8f36000
006A65FA0  ldr      x0, [x0, #0xd00]
006A65FA4  bl       #0x382bd14 ; 
006A65FA8  mov      w8, #1
006A65FAC  strb     w8, [x21, #0x3d8]
006A65FB0  adrp     x8, #0x8f36000
006A65FB4  ldr      x8, [x8, #0xd00]
006A65FB8  ldr      x2, [x8]
006A65FBC  ldrb     w8, [x2, #0x53]
006A65FC0  tbnz     w8, #5, #0x6a65fcc
006A65FC4  str      w20, [x19, #0x2c]
006A65FC8  b        #0x6a65fdc ; 
006A65FCC  ldr      x8, [x2, #0x60]
006A65FD0  mov      x0, x19
006A65FD4  mov      w1, w20
006A65FD8  blr      x8
006A65FDC  mov      x0, x19
006A65FE0  mov      x1, xzr
006A65FE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A65FE8  adrp     x21, #0x959e000
006A65FEC  ldrb     w8, [x21, #0x3d9]
006A65FF0  mov      w20, w0
006A65FF4  cbnz     w8, #0x6a6600c
006A65FF8  adrp     x0, #0x8f36000
006A65FFC  ldr      x0, [x0, #0xd08]
006A66000  bl       #0x382bd14 ; 
006A66004  mov      w8, #1
006A66008  strb     w8, [x21, #0x3d9]
006A6600C  adrp     x8, #0x8f36000
006A66010  ldr      x8, [x8, #0xd08]
006A66014  ldr      x2, [x8]
006A66018  ldrb     w8, [x2, #0x53]
006A6601C  tbnz     w8, #5, #0x6a66028
006A66020  str      w20, [x19, #0x30]
006A66024  b        #0x6a66038 ; 
006A66028  ldr      x8, [x2, #0x60]
006A6602C  mov      x0, x19
006A66030  mov      w1, w20
006A66034  blr      x8
006A66038  mov      x0, x19
006A6603C  mov      x1, xzr
006A66040  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A66044  adrp     x21, #0x959e000
006A66048  ldrb     w8, [x21, #0x3da]
006A6604C  mov      w20, w0
006A66050  cbnz     w8, #0x6a66068
006A66054  adrp     x0, #0x8f36000
006A66058  ldr      x0, [x0, #0xd18]
006A6605C  bl       #0x382bd14 ; 
006A66060  mov      w8, #1
006A66064  strb     w8, [x21, #0x3da]
006A66068  adrp     x8, #0x8f36000
006A6606C  ldr      x8, [x8, #0xd18]
006A66070  ldr      x2, [x8]
006A66074  ldrb     w8, [x2, #0x53]
006A66078  tbnz     w8, #5, #0x6a66084
006A6607C  str      w20, [x19, #0x34]
006A66080  b        #0x6a66094 ; 
006A66084  ldr      x8, [x2, #0x60]
006A66088  mov      x0, x19
006A6608C  mov      w1, w20
006A66090  blr      x8
006A66094  mov      x0, x19
006A66098  mov      x1, xzr
006A6609C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A660A0  adrp     x21, #0x959e000
006A660A4  ldrb     w8, [x21, #0x3db]
006A660A8  mov      w20, w0
006A660AC  cbnz     w8, #0x6a660c4
006A660B0  adrp     x0, #0x8f36000
006A660B4  ldr      x0, [x0, #0xd20]
006A660B8  bl       #0x382bd14 ; 
006A660BC  mov      w8, #1
006A660C0  strb     w8, [x21, #0x3db]
006A660C4  adrp     x8, #0x8f36000
006A660C8  ldr      x8, [x8, #0xd20]
006A660CC  ldr      x2, [x8]
006A660D0  ldrb     w8, [x2, #0x53]
006A660D4  tbnz     w8, #5, #0x6a660e0
006A660D8  str      w20, [x19, #0x38]
006A660DC  b        #0x6a660f0 ; 
006A660E0  ldr      x8, [x2, #0x60]
006A660E4  mov      x0, x19
006A660E8  mov      w1, w20
006A660EC  blr      x8
006A660F0  mov      x0, x19
006A660F4  mov      x1, xzr
006A660F8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A660FC  adrp     x21, #0x959e000
006A66100  ldrb     w8, [x21, #0x3dc]
006A66104  mov      x20, x0
006A66108  cbnz     w8, #0x6a66120
006A6610C  adrp     x0, #0x8f36000
006A66110  ldr      x0, [x0, #0xd28]
006A66114  bl       #0x382bd14 ; 
006A66118  mov      w8, #1
006A6611C  strb     w8, [x21, #0x3dc]
006A66120  adrp     x8, #0x8f36000
006A66124  ldr      x8, [x8, #0xd28]
006A66128  ldr      x2, [x8]
006A6612C  ldrb     w8, [x2, #0x53]
006A66130  tbnz     w8, #5, #0x6a66148
006A66134  mov      x0, x19
006A66138  str      x20, [x0, #0x40]!
006A6613C  mov      x1, x20
006A66140  bl       #0x382bcb8 ; 
006A66144  b        #0x6a66158 ; 
006A66148  ldr      x8, [x2, #0x60]
006A6614C  mov      x0, x19
006A66150  mov      x1, x20
006A66154  blr      x8
006A66158  mov      x0, x19
006A6615C  mov      x1, xzr
006A66160  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A66164  adrp     x21, #0x959e000
006A66168  ldrb     w8, [x21, #0x3dd]
006A6616C  mov      x20, x0
006A66170  cbnz     w8, #0x6a66188
006A66174  adrp     x0, #0x8f36000
006A66178  ldr      x0, [x0, #0xd30]
006A6617C  bl       #0x382bd14 ; 
006A66180  mov      w8, #1
006A66184  strb     w8, [x21, #0x3dd]
006A66188  adrp     x8, #0x8f36000
006A6618C  ldr      x8, [x8, #0xd30]
006A66190  ldr      x2, [x8]
006A66194  ldrb     w8, [x2, #0x53]
006A66198  tbnz     w8, #5, #0x6a661b0
006A6619C  mov      x0, x19
006A661A0  str      x20, [x0, #0x48]!
006A661A4  mov      x1, x20
006A661A8  bl       #0x382bcb8 ; 
006A661AC  b        #0x6a661c0 ; 
006A661B0  ldr      x8, [x2, #0x60]
006A661B4  mov      x0, x19
006A661B8  mov      x1, x20
006A661BC  blr      x8
006A661C0  mov      x0, x19
006A661C4  mov      x1, xzr
006A661C8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A661CC  adrp     x21, #0x959e000
006A661D0  ldrb     w8, [x21, #0x3de]
006A661D4  mov      x20, x0
006A661D8  cbnz     w8, #0x6a661f0
006A661DC  adrp     x0, #0x8f36000
006A661E0  ldr      x0, [x0, #0xd40]
006A661E4  bl       #0x382bd14 ; 
006A661E8  mov      w8, #1
006A661EC  strb     w8, [x21, #0x3de]
006A661F0  adrp     x8, #0x8f36000
006A661F4  ldr      x8, [x8, #0xd40]
006A661F8  ldr      x2, [x8]
006A661FC  ldrb     w8, [x2, #0x53]
006A66200  tbnz     w8, #5, #0x6a66218
006A66204  mov      x0, x19
006A66208  str      x20, [x0, #0x50]!
006A6620C  mov      x1, x20
006A66210  bl       #0x382bcb8 ; 
006A66214  b        #0x6a66228 ; 
006A66218  ldr      x8, [x2, #0x60]
006A6621C  mov      x0, x19
006A66220  mov      x1, x20
006A66224  blr      x8
006A66228  mov      x0, x19
006A6622C  mov      x1, xzr
006A66230  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A66234  adrp     x21, #0x959e000
006A66238  ldrb     w8, [x21, #0x3df]
006A6623C  mov      x20, x0
006A66240  cbnz     w8, #0x6a66258
006A66244  adrp     x0, #0x8f36000
006A66248  ldr      x0, [x0, #0xd48]
006A6624C  bl       #0x382bd14 ; 
006A66250  mov      w8, #1
006A66254  strb     w8, [x21, #0x3df]
006A66258  adrp     x8, #0x8f36000
006A6625C  ldr      x8, [x8, #0xd48]
006A66260  ldr      x2, [x8]
006A66264  ldrb     w8, [x2, #0x53]
006A66268  tbnz     w8, #5, #0x6a66280
006A6626C  mov      x0, x19
006A66270  str      x20, [x0, #0x58]!
006A66274  mov      x1, x20
006A66278  bl       #0x382bcb8 ; 
006A6627C  b        #0x6a66290 ; 
006A66280  ldr      x8, [x2, #0x60]
006A66284  mov      x0, x19
006A66288  mov      x1, x20
006A6628C  blr      x8
006A66290  mov      x0, x19
006A66294  mov      x1, xzr
006A66298  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6629C  adrp     x21, #0x959e000
006A662A0  ldrb     w8, [x21, #0x3e0]
006A662A4  mov      x20, x0
006A662A8  cbnz     w8, #0x6a662c0
006A662AC  adrp     x0, #0x8f36000
006A662B0  ldr      x0, [x0, #0xd58]
006A662B4  bl       #0x382bd14 ; 
006A662B8  mov      w8, #1
006A662BC  strb     w8, [x21, #0x3e0]
006A662C0  adrp     x8, #0x8f36000
006A662C4  ldr      x8, [x8, #0xd58]
006A662C8  ldr      x2, [x8]
006A662CC  ldrb     w8, [x2, #0x53]
006A662D0  tbnz     w8, #5, #0x6a662e8
006A662D4  mov      x0, x19
006A662D8  str      x20, [x0, #0x60]!
006A662DC  mov      x1, x20
006A662E0  bl       #0x382bcb8 ; 
006A662E4  b        #0x6a662f8 ; 
006A662E8  ldr      x8, [x2, #0x60]
006A662EC  mov      x0, x19
006A662F0  mov      x1, x20
006A662F4  blr      x8
006A662F8  mov      x0, x19
006A662FC  mov      x1, xzr
006A66300  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A66304  adrp     x21, #0x959e000
006A66308  ldrb     w8, [x21, #0x3e1]
006A6630C  mov      x20, x0
006A66310  cbnz     w8, #0x6a66328
006A66314  adrp     x0, #0x8f36000
006A66318  ldr      x0, [x0, #0xd68]
006A6631C  bl       #0x382bd14 ; 
006A66320  mov      w8, #1
006A66324  strb     w8, [x21, #0x3e1]
006A66328  adrp     x8, #0x8f36000
006A6632C  ldr      x8, [x8, #0xd68]
006A66330  ldr      x2, [x8]
006A66334  ldrb     w8, [x2, #0x53]
006A66338  tbnz     w8, #5, #0x6a66350
006A6633C  mov      x0, x19
006A66340  str      x20, [x0, #0x68]!
006A66344  mov      x1, x20
006A66348  bl       #0x382bcb8 ; 
006A6634C  b        #0x6a66360 ; 
006A66350  ldr      x8, [x2, #0x60]
006A66354  mov      x0, x19
006A66358  mov      x1, x20
006A6635C  blr      x8
006A66360  mov      x0, x19
006A66364  mov      x1, xzr
006A66368  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6636C  adrp     x21, #0x959e000
006A66370  ldrb     w8, [x21, #0x3e2]
006A66374  mov      w20, w0
006A66378  cbnz     w8, #0x6a66390
006A6637C  adrp     x0, #0x8f36000
006A66380  ldr      x0, [x0, #0xd78]
006A66384  bl       #0x382bd14 ; 
006A66388  mov      w8, #1
006A6638C  strb     w8, [x21, #0x3e2]
006A66390  adrp     x8, #0x8f36000
006A66394  ldr      x8, [x8, #0xd78]
006A66398  ldr      x2, [x8]
006A6639C  ldrb     w8, [x2, #0x53]
006A663A0  tbnz     w8, #5, #0x6a663ac
006A663A4  str      w20, [x19, #0x70]
006A663A8  b        #0x6a663bc ; 
006A663AC  ldr      x8, [x2, #0x60]
006A663B0  mov      x0, x19
006A663B4  mov      w1, w20
006A663B8  blr      x8
006A663BC  mov      x0, x19
006A663C0  mov      x1, xzr
006A663C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A663C8  adrp     x21, #0x959e000
006A663CC  ldrb     w8, [x21, #0x3e3]
006A663D0  mov      x20, x0
006A663D4  cbnz     w8, #0x6a663ec
006A663D8  adrp     x0, #0x8f36000
006A663DC  ldr      x0, [x0, #0xd88]
006A663E0  bl       #0x382bd14 ; 
006A663E4  mov      w8, #1
006A663E8  strb     w8, [x21, #0x3e3]
006A663EC  adrp     x8, #0x8f36000
006A663F0  ldr      x8, [x8, #0xd88]
006A663F4  ldr      x2, [x8]
006A663F8  ldrb     w8, [x2, #0x53]
006A663FC  tbnz     w8, #5, #0x6a66414
006A66400  mov      x0, x19
006A66404  str      x20, [x0, #0x78]!
006A66408  mov      x1, x20
006A6640C  bl       #0x382bcb8 ; 
006A66410  b        #0x6a66424 ; 
006A66414  ldr      x8, [x2, #0x60]
006A66418  mov      x0, x19
006A6641C  mov      x1, x20
006A66420  blr      x8
006A66424  mov      x0, x19
006A66428  mov      x1, xzr
006A6642C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A66430  adrp     x21, #0x959e000
006A66434  ldrb     w8, [x21, #0x3e4]
006A66438  mov      x20, x0
006A6643C  cbnz     w8, #0x6a66454
006A66440  adrp     x0, #0x8f36000
006A66444  ldr      x0, [x0, #0xd98]
006A66448  bl       #0x382bd14 ; 
006A6644C  mov      w8, #1
006A66450  strb     w8, [x21, #0x3e4]
006A66454  adrp     x8, #0x8f36000
006A66458  ldr      x8, [x8, #0xd98]
006A6645C  ldr      x2, [x8]
006A66460  ldrb     w8, [x2, #0x53]
006A66464  tbnz     w8, #5, #0x6a6647c
006A66468  mov      x0, x19
006A6646C  str      x20, [x0, #0x80]!
006A66470  mov      x1, x20
006A66474  bl       #0x382bcb8 ; 
006A66478  b        #0x6a6648c ; 
006A6647C  ldr      x8, [x2, #0x60]
006A66480  mov      x0, x19
006A66484  mov      x1, x20
006A66488  blr      x8
006A6648C  mov      x0, x19
006A66490  mov      x1, xzr
006A66494  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A66498  adrp     x21, #0x959e000
006A6649C  ldrb     w8, [x21, #0x3e5]
006A664A0  mov      x20, x0
006A664A4  cbnz     w8, #0x6a664bc
006A664A8  adrp     x0, #0x8f36000
006A664AC  ldr      x0, [x0, #0xda8]
006A664B0  bl       #0x382bd14 ; 
006A664B4  mov      w8, #1
006A664B8  strb     w8, [x21, #0x3e5]
006A664BC  adrp     x8, #0x8f36000
006A664C0  ldr      x8, [x8, #0xda8]
006A664C4  ldr      x2, [x8]
006A664C8  ldrb     w8, [x2, #0x53]
006A664CC  tbnz     w8, #5, #0x6a664e4
006A664D0  mov      x0, x19
006A664D4  str      x20, [x0, #0x88]!
006A664D8  mov      x1, x20
006A664DC  bl       #0x382bcb8 ; 
006A664E0  b        #0x6a664f4 ; 
006A664E4  ldr      x8, [x2, #0x60]
006A664E8  mov      x0, x19
006A664EC  mov      x1, x20
006A664F0  blr      x8
006A664F4  mov      x0, x19
006A664F8  mov      x1, xzr
006A664FC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A66500  adrp     x21, #0x959e000
006A66504  ldrb     w8, [x21, #0x3e6]
006A66508  mov      x20, x0
006A6650C  cbnz     w8, #0x6a66524
006A66510  adrp     x0, #0x8f36000
006A66514  ldr      x0, [x0, #0xdb8]
006A66518  bl       #0x382bd14 ; 
006A6651C  mov      w8, #1
006A66520  strb     w8, [x21, #0x3e6]
006A66524  adrp     x8, #0x8f36000
006A66528  ldr      x8, [x8, #0xdb8]
006A6652C  ldr      x2, [x8]
006A66530  ldrb     w8, [x2, #0x53]
006A66534  tbnz     w8, #5, #0x6a6654c
006A66538  str      x20, [x19, #0x90]!
006A6653C  mov      x0, x19
006A66540  mov      x1, x20
006A66544  bl       #0x382bcb8 ; 
006A66548  b        #0x6a6655c ; 
006A6654C  ldr      x8, [x2, #0x60]
006A66550  mov      x0, x19
006A66554  mov      x1, x20
006A66558  blr      x8
006A6655C  ldp      x20, x19, [sp, #0x10]
006A66560  mov      w0, #1
006A66564  ldp      x30, x21, [sp], #0x20
006A66568  ret      

