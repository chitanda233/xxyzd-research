; LocalModels.Bean.Role_Skin$$readImpl
; RVA 0x6AE0D3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE0D3C  stp      x30, x21, [sp, #-0x20]!
006AE0D40  stp      x20, x19, [sp, #0x10]
006AE0D44  adrp     x20, #0x959e000
006AE0D48  adrp     x21, #0x8f3c000
006AE0D4C  ldrb     w8, [x20, #0xcc7]
006AE0D50  ldr      x21, [x21, #0xa70]
006AE0D54  mov      x19, x0
006AE0D58  tbnz     w8, #0, #0x6ae0d70
006AE0D5C  adrp     x0, #0x8f3c000
006AE0D60  ldr      x0, [x0, #0xa70]
006AE0D64  bl       #0x382bd14 ; 
006AE0D68  mov      w8, #1
006AE0D6C  strb     w8, [x20, #0xcc7]
006AE0D70  ldr      x1, [x21]
006AE0D74  ldrb     w8, [x1, #0x53]
006AE0D78  tbnz     w8, #5, #0x6ae0dc8
006AE0D7C  mov      x0, x19
006AE0D80  mov      x1, xzr
006AE0D84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE0D88  adrp     x21, #0x959f000
006AE0D8C  ldrb     w8, [x21, #0x190]
006AE0D90  mov      w20, w0
006AE0D94  cbnz     w8, #0x6ae0dac
006AE0D98  adrp     x0, #0x8f3c000
006AE0D9C  ldr      x0, [x0, #0x970]
006AE0DA0  bl       #0x382bd14 ; 
006AE0DA4  mov      w8, #1
006AE0DA8  strb     w8, [x21, #0x190]
006AE0DAC  adrp     x8, #0x8f3c000
006AE0DB0  ldr      x8, [x8, #0x970]
006AE0DB4  ldr      x2, [x8]
006AE0DB8  ldrb     w8, [x2, #0x53]
006AE0DBC  tbnz     w8, #5, #0x6ae0ddc
006AE0DC0  str      w20, [x19, #0x20]
006AE0DC4  b        #0x6ae0dec ; 
006AE0DC8  ldr      x2, [x1, #0x60]
006AE0DCC  mov      x0, x19
006AE0DD0  ldp      x20, x19, [sp, #0x10]
006AE0DD4  ldp      x30, x21, [sp], #0x20
006AE0DD8  br       x2
006AE0DDC  ldr      x8, [x2, #0x60]
006AE0DE0  mov      x0, x19
006AE0DE4  mov      w1, w20
006AE0DE8  blr      x8
006AE0DEC  mov      x0, x19
006AE0DF0  mov      x1, xzr
006AE0DF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE0DF8  adrp     x21, #0x959f000
006AE0DFC  ldrb     w8, [x21, #0x191]
006AE0E00  mov      w20, w0
006AE0E04  cbnz     w8, #0x6ae0e1c
006AE0E08  adrp     x0, #0x8f3c000
006AE0E0C  ldr      x0, [x0, #0x980]
006AE0E10  bl       #0x382bd14 ; 
006AE0E14  mov      w8, #1
006AE0E18  strb     w8, [x21, #0x191]
006AE0E1C  adrp     x8, #0x8f3c000
006AE0E20  ldr      x8, [x8, #0x980]
006AE0E24  ldr      x2, [x8]
006AE0E28  ldrb     w8, [x2, #0x53]
006AE0E2C  tbnz     w8, #5, #0x6ae0e38
006AE0E30  str      w20, [x19, #0x24]
006AE0E34  b        #0x6ae0e48 ; 
006AE0E38  ldr      x8, [x2, #0x60]
006AE0E3C  mov      x0, x19
006AE0E40  mov      w1, w20
006AE0E44  blr      x8
006AE0E48  mov      x0, x19
006AE0E4C  mov      x1, xzr
006AE0E50  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AE0E54  adrp     x21, #0x959f000
006AE0E58  ldrb     w8, [x21, #0x192]
006AE0E5C  mov      x20, x0
006AE0E60  cbnz     w8, #0x6ae0e78
006AE0E64  adrp     x0, #0x8f3c000
006AE0E68  ldr      x0, [x0, #0x990]
006AE0E6C  bl       #0x382bd14 ; 
006AE0E70  mov      w8, #1
006AE0E74  strb     w8, [x21, #0x192]
006AE0E78  adrp     x8, #0x8f3c000
006AE0E7C  ldr      x8, [x8, #0x990]
006AE0E80  ldr      x2, [x8]
006AE0E84  ldrb     w8, [x2, #0x53]
006AE0E88  tbnz     w8, #5, #0x6ae0ea0
006AE0E8C  mov      x0, x19
006AE0E90  str      x20, [x0, #0x28]!
006AE0E94  mov      x1, x20
006AE0E98  bl       #0x382bcb8 ; 
006AE0E9C  b        #0x6ae0eb0 ; 
006AE0EA0  ldr      x8, [x2, #0x60]
006AE0EA4  mov      x0, x19
006AE0EA8  mov      x1, x20
006AE0EAC  blr      x8
006AE0EB0  mov      x0, x19
006AE0EB4  mov      x1, xzr
006AE0EB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE0EBC  adrp     x21, #0x959f000
006AE0EC0  ldrb     w8, [x21, #0x193]
006AE0EC4  mov      w20, w0
006AE0EC8  cbnz     w8, #0x6ae0ee0
006AE0ECC  adrp     x0, #0x8f3c000
006AE0ED0  ldr      x0, [x0, #0x998]
006AE0ED4  bl       #0x382bd14 ; 
006AE0ED8  mov      w8, #1
006AE0EDC  strb     w8, [x21, #0x193]
006AE0EE0  adrp     x8, #0x8f3c000
006AE0EE4  ldr      x8, [x8, #0x998]
006AE0EE8  ldr      x2, [x8]
006AE0EEC  ldrb     w8, [x2, #0x53]
006AE0EF0  tbnz     w8, #5, #0x6ae0efc
006AE0EF4  str      w20, [x19, #0x30]
006AE0EF8  b        #0x6ae0f0c ; 
006AE0EFC  ldr      x8, [x2, #0x60]
006AE0F00  mov      x0, x19
006AE0F04  mov      w1, w20
006AE0F08  blr      x8
006AE0F0C  mov      x0, x19
006AE0F10  mov      x1, xzr
006AE0F14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE0F18  adrp     x21, #0x959f000
006AE0F1C  ldrb     w8, [x21, #0x194]
006AE0F20  mov      w20, w0
006AE0F24  cbnz     w8, #0x6ae0f3c
006AE0F28  adrp     x0, #0x8f3c000
006AE0F2C  ldr      x0, [x0, #0x9a8]
006AE0F30  bl       #0x382bd14 ; 
006AE0F34  mov      w8, #1
006AE0F38  strb     w8, [x21, #0x194]
006AE0F3C  adrp     x8, #0x8f3c000
006AE0F40  ldr      x8, [x8, #0x9a8]
006AE0F44  ldr      x2, [x8]
006AE0F48  ldrb     w8, [x2, #0x53]
006AE0F4C  tbnz     w8, #5, #0x6ae0f58
006AE0F50  str      w20, [x19, #0x34]
006AE0F54  b        #0x6ae0f68 ; 
006AE0F58  ldr      x8, [x2, #0x60]
006AE0F5C  mov      x0, x19
006AE0F60  mov      w1, w20
006AE0F64  blr      x8
006AE0F68  mov      x0, x19
006AE0F6C  mov      x1, xzr
006AE0F70  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE0F74  adrp     x21, #0x959f000
006AE0F78  ldrb     w8, [x21, #0x195]
006AE0F7C  mov      x20, x0
006AE0F80  cbnz     w8, #0x6ae0f98
006AE0F84  adrp     x0, #0x8f3c000
006AE0F88  ldr      x0, [x0, #0x9b8]
006AE0F8C  bl       #0x382bd14 ; 
006AE0F90  mov      w8, #1
006AE0F94  strb     w8, [x21, #0x195]
006AE0F98  adrp     x8, #0x8f3c000
006AE0F9C  ldr      x8, [x8, #0x9b8]
006AE0FA0  ldr      x2, [x8]
006AE0FA4  ldrb     w8, [x2, #0x53]
006AE0FA8  tbnz     w8, #5, #0x6ae0fc0
006AE0FAC  mov      x0, x19
006AE0FB0  str      x20, [x0, #0x38]!
006AE0FB4  mov      x1, x20
006AE0FB8  bl       #0x382bcb8 ; 
006AE0FBC  b        #0x6ae0fd0 ; 
006AE0FC0  ldr      x8, [x2, #0x60]
006AE0FC4  mov      x0, x19
006AE0FC8  mov      x1, x20
006AE0FCC  blr      x8
006AE0FD0  mov      x0, x19
006AE0FD4  mov      x1, xzr
006AE0FD8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE0FDC  adrp     x21, #0x959f000
006AE0FE0  ldrb     w8, [x21, #0x196]
006AE0FE4  mov      x20, x0
006AE0FE8  cbnz     w8, #0x6ae1000
006AE0FEC  adrp     x0, #0x8f3c000
006AE0FF0  ldr      x0, [x0, #0x9c8]
006AE0FF4  bl       #0x382bd14 ; 
006AE0FF8  mov      w8, #1
006AE0FFC  strb     w8, [x21, #0x196]
006AE1000  adrp     x8, #0x8f3c000
006AE1004  ldr      x8, [x8, #0x9c8]
006AE1008  ldr      x2, [x8]
006AE100C  ldrb     w8, [x2, #0x53]
006AE1010  tbnz     w8, #5, #0x6ae1028
006AE1014  mov      x0, x19
006AE1018  str      x20, [x0, #0x40]!
006AE101C  mov      x1, x20
006AE1020  bl       #0x382bcb8 ; 
006AE1024  b        #0x6ae1038 ; 
006AE1028  ldr      x8, [x2, #0x60]
006AE102C  mov      x0, x19
006AE1030  mov      x1, x20
006AE1034  blr      x8
006AE1038  mov      x0, x19
006AE103C  mov      x1, xzr
006AE1040  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE1044  adrp     x21, #0x959f000
006AE1048  ldrb     w8, [x21, #0x197]
006AE104C  mov      x20, x0
006AE1050  cbnz     w8, #0x6ae1068
006AE1054  adrp     x0, #0x8f3c000
006AE1058  ldr      x0, [x0, #0x9d8]
006AE105C  bl       #0x382bd14 ; 
006AE1060  mov      w8, #1
006AE1064  strb     w8, [x21, #0x197]
006AE1068  adrp     x8, #0x8f3c000
006AE106C  ldr      x8, [x8, #0x9d8]
006AE1070  ldr      x2, [x8]
006AE1074  ldrb     w8, [x2, #0x53]
006AE1078  tbnz     w8, #5, #0x6ae1090
006AE107C  mov      x0, x19
006AE1080  str      x20, [x0, #0x48]!
006AE1084  mov      x1, x20
006AE1088  bl       #0x382bcb8 ; 
006AE108C  b        #0x6ae10a0 ; 
006AE1090  ldr      x8, [x2, #0x60]
006AE1094  mov      x0, x19
006AE1098  mov      x1, x20
006AE109C  blr      x8
006AE10A0  mov      x0, x19
006AE10A4  mov      x1, xzr
006AE10A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE10AC  adrp     x21, #0x959f000
006AE10B0  ldrb     w8, [x21, #0x198]
006AE10B4  mov      w20, w0
006AE10B8  cbnz     w8, #0x6ae10d0
006AE10BC  adrp     x0, #0x8f3c000
006AE10C0  ldr      x0, [x0, #0x9e8]
006AE10C4  bl       #0x382bd14 ; 
006AE10C8  mov      w8, #1
006AE10CC  strb     w8, [x21, #0x198]
006AE10D0  adrp     x8, #0x8f3c000
006AE10D4  ldr      x8, [x8, #0x9e8]
006AE10D8  ldr      x2, [x8]
006AE10DC  ldrb     w8, [x2, #0x53]
006AE10E0  tbnz     w8, #5, #0x6ae10ec
006AE10E4  str      w20, [x19, #0x50]
006AE10E8  b        #0x6ae10fc ; 
006AE10EC  ldr      x8, [x2, #0x60]
006AE10F0  mov      x0, x19
006AE10F4  mov      w1, w20
006AE10F8  blr      x8
006AE10FC  mov      x0, x19
006AE1100  mov      x1, xzr
006AE1104  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE1108  adrp     x21, #0x959f000
006AE110C  ldrb     w8, [x21, #0x199]
006AE1110  mov      w20, w0
006AE1114  cbnz     w8, #0x6ae112c
006AE1118  adrp     x0, #0x8f3c000
006AE111C  ldr      x0, [x0, #0x9f8]
006AE1120  bl       #0x382bd14 ; 
006AE1124  mov      w8, #1
006AE1128  strb     w8, [x21, #0x199]
006AE112C  adrp     x8, #0x8f3c000
006AE1130  ldr      x8, [x8, #0x9f8]
006AE1134  ldr      x2, [x8]
006AE1138  ldrb     w8, [x2, #0x53]
006AE113C  tbnz     w8, #5, #0x6ae1148
006AE1140  str      w20, [x19, #0x54]
006AE1144  b        #0x6ae1158 ; 
006AE1148  ldr      x8, [x2, #0x60]
006AE114C  mov      x0, x19
006AE1150  mov      w1, w20
006AE1154  blr      x8
006AE1158  mov      x0, x19
006AE115C  mov      x1, xzr
006AE1160  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE1164  adrp     x21, #0x959f000
006AE1168  ldrb     w8, [x21, #0x19a]
006AE116C  mov      w20, w0
006AE1170  cbnz     w8, #0x6ae1188
006AE1174  adrp     x0, #0x8f3c000
006AE1178  ldr      x0, [x0, #0xa08]
006AE117C  bl       #0x382bd14 ; 
006AE1180  mov      w8, #1
006AE1184  strb     w8, [x21, #0x19a]
006AE1188  adrp     x8, #0x8f3c000
006AE118C  ldr      x8, [x8, #0xa08]
006AE1190  ldr      x2, [x8]
006AE1194  ldrb     w8, [x2, #0x53]
006AE1198  tbnz     w8, #5, #0x6ae11a4
006AE119C  str      w20, [x19, #0x58]
006AE11A0  b        #0x6ae11b4 ; 
006AE11A4  ldr      x8, [x2, #0x60]
006AE11A8  mov      x0, x19
006AE11AC  mov      w1, w20
006AE11B0  blr      x8
006AE11B4  mov      x0, x19
006AE11B8  mov      x1, xzr
006AE11BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE11C0  adrp     x21, #0x959f000
006AE11C4  ldrb     w8, [x21, #0x19b]
006AE11C8  mov      w20, w0
006AE11CC  cbnz     w8, #0x6ae11e4
006AE11D0  adrp     x0, #0x8f3c000
006AE11D4  ldr      x0, [x0, #0xa18]
006AE11D8  bl       #0x382bd14 ; 
006AE11DC  mov      w8, #1
006AE11E0  strb     w8, [x21, #0x19b]
006AE11E4  adrp     x8, #0x8f3c000
006AE11E8  ldr      x8, [x8, #0xa18]
006AE11EC  ldr      x2, [x8]
006AE11F0  ldrb     w8, [x2, #0x53]
006AE11F4  tbnz     w8, #5, #0x6ae1200
006AE11F8  str      w20, [x19, #0x5c]
006AE11FC  b        #0x6ae1210 ; 
006AE1200  ldr      x8, [x2, #0x60]
006AE1204  mov      x0, x19
006AE1208  mov      w1, w20
006AE120C  blr      x8
006AE1210  mov      x0, x19
006AE1214  mov      x1, xzr
006AE1218  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE121C  adrp     x21, #0x959f000
006AE1220  ldrb     w8, [x21, #0x19c]
006AE1224  mov      x20, x0
006AE1228  cbnz     w8, #0x6ae1240
006AE122C  adrp     x0, #0x8f3c000
006AE1230  ldr      x0, [x0, #0xa28]
006AE1234  bl       #0x382bd14 ; 
006AE1238  mov      w8, #1
006AE123C  strb     w8, [x21, #0x19c]
006AE1240  adrp     x8, #0x8f3c000
006AE1244  ldr      x8, [x8, #0xa28]
006AE1248  ldr      x2, [x8]
006AE124C  ldrb     w8, [x2, #0x53]
006AE1250  tbnz     w8, #5, #0x6ae1268
006AE1254  mov      x0, x19
006AE1258  str      x20, [x0, #0x60]!
006AE125C  mov      x1, x20
006AE1260  bl       #0x382bcb8 ; 
006AE1264  b        #0x6ae1278 ; 
006AE1268  ldr      x8, [x2, #0x60]
006AE126C  mov      x0, x19
006AE1270  mov      x1, x20
006AE1274  blr      x8
006AE1278  mov      x0, x19
006AE127C  mov      x1, xzr
006AE1280  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE1284  adrp     x21, #0x959f000
006AE1288  ldrb     w8, [x21, #0x19d]
006AE128C  mov      x20, x0
006AE1290  cbnz     w8, #0x6ae12a8
006AE1294  adrp     x0, #0x8f3c000
006AE1298  ldr      x0, [x0, #0xa38]
006AE129C  bl       #0x382bd14 ; 
006AE12A0  mov      w8, #1
006AE12A4  strb     w8, [x21, #0x19d]
006AE12A8  adrp     x8, #0x8f3c000
006AE12AC  ldr      x8, [x8, #0xa38]
006AE12B0  ldr      x2, [x8]
006AE12B4  ldrb     w8, [x2, #0x53]
006AE12B8  tbnz     w8, #5, #0x6ae12d0
006AE12BC  mov      x0, x19
006AE12C0  str      x20, [x0, #0x68]!
006AE12C4  mov      x1, x20
006AE12C8  bl       #0x382bcb8 ; 
006AE12CC  b        #0x6ae12e0 ; 
006AE12D0  ldr      x8, [x2, #0x60]
006AE12D4  mov      x0, x19
006AE12D8  mov      x1, x20
006AE12DC  blr      x8
006AE12E0  mov      x0, x19
006AE12E4  mov      x1, xzr
006AE12E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE12EC  adrp     x21, #0x959f000
006AE12F0  ldrb     w8, [x21, #0x19e]
006AE12F4  mov      x20, x0
006AE12F8  cbnz     w8, #0x6ae1310
006AE12FC  adrp     x0, #0x8f3c000
006AE1300  ldr      x0, [x0, #0xa48]
006AE1304  bl       #0x382bd14 ; 
006AE1308  mov      w8, #1
006AE130C  strb     w8, [x21, #0x19e]
006AE1310  adrp     x8, #0x8f3c000
006AE1314  ldr      x8, [x8, #0xa48]
006AE1318  ldr      x2, [x8]
006AE131C  ldrb     w8, [x2, #0x53]
006AE1320  tbnz     w8, #5, #0x6ae1338
006AE1324  mov      x0, x19
006AE1328  str      x20, [x0, #0x70]!
006AE132C  mov      x1, x20
006AE1330  bl       #0x382bcb8 ; 
006AE1334  b        #0x6ae1348 ; 
006AE1338  ldr      x8, [x2, #0x60]
006AE133C  mov      x0, x19
006AE1340  mov      x1, x20
006AE1344  blr      x8
006AE1348  mov      x0, x19
006AE134C  mov      x1, xzr
006AE1350  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE1354  adrp     x21, #0x959f000
006AE1358  ldrb     w8, [x21, #0x19f]
006AE135C  mov      x20, x0
006AE1360  cbnz     w8, #0x6ae1378
006AE1364  adrp     x0, #0x8f3c000
006AE1368  ldr      x0, [x0, #0xa58]
006AE136C  bl       #0x382bd14 ; 
006AE1370  mov      w8, #1
006AE1374  strb     w8, [x21, #0x19f]
006AE1378  adrp     x8, #0x8f3c000
006AE137C  ldr      x8, [x8, #0xa58]
006AE1380  ldr      x2, [x8]
006AE1384  ldrb     w8, [x2, #0x53]
006AE1388  tbnz     w8, #5, #0x6ae13a0
006AE138C  mov      x0, x19
006AE1390  str      x20, [x0, #0x78]!
006AE1394  mov      x1, x20
006AE1398  bl       #0x382bcb8 ; 
006AE139C  b        #0x6ae13b0 ; 
006AE13A0  ldr      x8, [x2, #0x60]
006AE13A4  mov      x0, x19
006AE13A8  mov      x1, x20
006AE13AC  blr      x8
006AE13B0  mov      x0, x19
006AE13B4  mov      x1, xzr
006AE13B8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE13BC  adrp     x21, #0x959f000
006AE13C0  ldrb     w8, [x21, #0x1a0]
006AE13C4  mov      x20, x0
006AE13C8  cbnz     w8, #0x6ae13e0
006AE13CC  adrp     x0, #0x8f3c000
006AE13D0  ldr      x0, [x0, #0xa68]
006AE13D4  bl       #0x382bd14 ; 
006AE13D8  mov      w8, #1
006AE13DC  strb     w8, [x21, #0x1a0]
006AE13E0  adrp     x8, #0x8f3c000
006AE13E4  ldr      x8, [x8, #0xa68]
006AE13E8  ldr      x2, [x8]
006AE13EC  ldrb     w8, [x2, #0x53]
006AE13F0  tbnz     w8, #5, #0x6ae1408
006AE13F4  str      x20, [x19, #0x80]!
006AE13F8  mov      x0, x19
006AE13FC  mov      x1, x20
006AE1400  bl       #0x382bcb8 ; 
006AE1404  b        #0x6ae1418 ; 
006AE1408  ldr      x8, [x2, #0x60]
006AE140C  mov      x0, x19
006AE1410  mov      x1, x20
006AE1414  blr      x8
006AE1418  ldp      x20, x19, [sp, #0x10]
006AE141C  mov      w0, #1
006AE1420  ldp      x30, x21, [sp], #0x20
006AE1424  ret      

