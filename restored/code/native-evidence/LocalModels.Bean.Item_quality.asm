; LocalModels.Bean.Item_quality$$readImpl
; RVA 0x6AB0F60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AB0F60  stp      x30, x21, [sp, #-0x20]!
006AB0F64  stp      x20, x19, [sp, #0x10]
006AB0F68  adrp     x20, #0x959e000
006AB0F6C  adrp     x21, #0x8f3a000
006AB0F70  ldrb     w8, [x20, #0x7dd]
006AB0F74  ldr      x21, [x21, #0x6f0]
006AB0F78  mov      x19, x0
006AB0F7C  tbnz     w8, #0, #0x6ab0f94
006AB0F80  adrp     x0, #0x8f3a000
006AB0F84  ldr      x0, [x0, #0x6f0]
006AB0F88  bl       #0x382bd14 ; 
006AB0F8C  mov      w8, #1
006AB0F90  strb     w8, [x20, #0x7dd]
006AB0F94  ldr      x1, [x21]
006AB0F98  ldrb     w8, [x1, #0x53]
006AB0F9C  tbnz     w8, #5, #0x6ab0fec
006AB0FA0  mov      x0, x19
006AB0FA4  mov      x1, xzr
006AB0FA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB0FAC  adrp     x21, #0x959e000
006AB0FB0  ldrb     w8, [x21, #0xf70]
006AB0FB4  mov      w20, w0
006AB0FB8  cbnz     w8, #0x6ab0fd0
006AB0FBC  adrp     x0, #0x8f3a000
006AB0FC0  ldr      x0, [x0, #0x5f8]
006AB0FC4  bl       #0x382bd14 ; 
006AB0FC8  mov      w8, #1
006AB0FCC  strb     w8, [x21, #0xf70]
006AB0FD0  adrp     x8, #0x8f3a000
006AB0FD4  ldr      x8, [x8, #0x5f8]
006AB0FD8  ldr      x2, [x8]
006AB0FDC  ldrb     w8, [x2, #0x53]
006AB0FE0  tbnz     w8, #5, #0x6ab1000
006AB0FE4  str      w20, [x19, #0x20]
006AB0FE8  b        #0x6ab1010 ; 
006AB0FEC  ldr      x2, [x1, #0x60]
006AB0FF0  mov      x0, x19
006AB0FF4  ldp      x20, x19, [sp, #0x10]
006AB0FF8  ldp      x30, x21, [sp], #0x20
006AB0FFC  br       x2
006AB1000  ldr      x8, [x2, #0x60]
006AB1004  mov      x0, x19
006AB1008  mov      w1, w20
006AB100C  blr      x8
006AB1010  mov      x0, x19
006AB1014  mov      x1, xzr
006AB1018  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB101C  adrp     x21, #0x959e000
006AB1020  ldrb     w8, [x21, #0xf71]
006AB1024  mov      x20, x0
006AB1028  cbnz     w8, #0x6ab1040
006AB102C  adrp     x0, #0x8f3a000
006AB1030  ldr      x0, [x0, #0x608]
006AB1034  bl       #0x382bd14 ; 
006AB1038  mov      w8, #1
006AB103C  strb     w8, [x21, #0xf71]
006AB1040  adrp     x8, #0x8f3a000
006AB1044  ldr      x8, [x8, #0x608]
006AB1048  ldr      x2, [x8]
006AB104C  ldrb     w8, [x2, #0x53]
006AB1050  tbnz     w8, #5, #0x6ab1068
006AB1054  mov      x0, x19
006AB1058  str      x20, [x0, #0x28]!
006AB105C  mov      x1, x20
006AB1060  bl       #0x382bcb8 ; 
006AB1064  b        #0x6ab1078 ; 
006AB1068  ldr      x8, [x2, #0x60]
006AB106C  mov      x0, x19
006AB1070  mov      x1, x20
006AB1074  blr      x8
006AB1078  mov      x0, x19
006AB107C  mov      x1, xzr
006AB1080  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB1084  adrp     x21, #0x959e000
006AB1088  ldrb     w8, [x21, #0xf72]
006AB108C  mov      x20, x0
006AB1090  cbnz     w8, #0x6ab10a8
006AB1094  adrp     x0, #0x8f3a000
006AB1098  ldr      x0, [x0, #0x618]
006AB109C  bl       #0x382bd14 ; 
006AB10A0  mov      w8, #1
006AB10A4  strb     w8, [x21, #0xf72]
006AB10A8  adrp     x8, #0x8f3a000
006AB10AC  ldr      x8, [x8, #0x618]
006AB10B0  ldr      x2, [x8]
006AB10B4  ldrb     w8, [x2, #0x53]
006AB10B8  tbnz     w8, #5, #0x6ab10d0
006AB10BC  mov      x0, x19
006AB10C0  str      x20, [x0, #0x30]!
006AB10C4  mov      x1, x20
006AB10C8  bl       #0x382bcb8 ; 
006AB10CC  b        #0x6ab10e0 ; 
006AB10D0  ldr      x8, [x2, #0x60]
006AB10D4  mov      x0, x19
006AB10D8  mov      x1, x20
006AB10DC  blr      x8
006AB10E0  mov      x0, x19
006AB10E4  mov      x1, xzr
006AB10E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB10EC  adrp     x21, #0x959e000
006AB10F0  ldrb     w8, [x21, #0xf73]
006AB10F4  mov      x20, x0
006AB10F8  cbnz     w8, #0x6ab1110
006AB10FC  adrp     x0, #0x8f3a000
006AB1100  ldr      x0, [x0, #0x628]
006AB1104  bl       #0x382bd14 ; 
006AB1108  mov      w8, #1
006AB110C  strb     w8, [x21, #0xf73]
006AB1110  adrp     x8, #0x8f3a000
006AB1114  ldr      x8, [x8, #0x628]
006AB1118  ldr      x2, [x8]
006AB111C  ldrb     w8, [x2, #0x53]
006AB1120  tbnz     w8, #5, #0x6ab1138
006AB1124  mov      x0, x19
006AB1128  str      x20, [x0, #0x38]!
006AB112C  mov      x1, x20
006AB1130  bl       #0x382bcb8 ; 
006AB1134  b        #0x6ab1148 ; 
006AB1138  ldr      x8, [x2, #0x60]
006AB113C  mov      x0, x19
006AB1140  mov      x1, x20
006AB1144  blr      x8
006AB1148  mov      x0, x19
006AB114C  mov      x1, xzr
006AB1150  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB1154  adrp     x21, #0x959e000
006AB1158  ldrb     w8, [x21, #0xf74]
006AB115C  mov      x20, x0
006AB1160  cbnz     w8, #0x6ab1178
006AB1164  adrp     x0, #0x8f3a000
006AB1168  ldr      x0, [x0, #0x638]
006AB116C  bl       #0x382bd14 ; 
006AB1170  mov      w8, #1
006AB1174  strb     w8, [x21, #0xf74]
006AB1178  adrp     x8, #0x8f3a000
006AB117C  ldr      x8, [x8, #0x638]
006AB1180  ldr      x2, [x8]
006AB1184  ldrb     w8, [x2, #0x53]
006AB1188  tbnz     w8, #5, #0x6ab11a0
006AB118C  mov      x0, x19
006AB1190  str      x20, [x0, #0x40]!
006AB1194  mov      x1, x20
006AB1198  bl       #0x382bcb8 ; 
006AB119C  b        #0x6ab11b0 ; 
006AB11A0  ldr      x8, [x2, #0x60]
006AB11A4  mov      x0, x19
006AB11A8  mov      x1, x20
006AB11AC  blr      x8
006AB11B0  mov      x0, x19
006AB11B4  mov      x1, xzr
006AB11B8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB11BC  adrp     x21, #0x959e000
006AB11C0  ldrb     w8, [x21, #0xf75]
006AB11C4  mov      x20, x0
006AB11C8  cbnz     w8, #0x6ab11e0
006AB11CC  adrp     x0, #0x8f3a000
006AB11D0  ldr      x0, [x0, #0x648]
006AB11D4  bl       #0x382bd14 ; 
006AB11D8  mov      w8, #1
006AB11DC  strb     w8, [x21, #0xf75]
006AB11E0  adrp     x8, #0x8f3a000
006AB11E4  ldr      x8, [x8, #0x648]
006AB11E8  ldr      x2, [x8]
006AB11EC  ldrb     w8, [x2, #0x53]
006AB11F0  tbnz     w8, #5, #0x6ab1208
006AB11F4  mov      x0, x19
006AB11F8  str      x20, [x0, #0x48]!
006AB11FC  mov      x1, x20
006AB1200  bl       #0x382bcb8 ; 
006AB1204  b        #0x6ab1218 ; 
006AB1208  ldr      x8, [x2, #0x60]
006AB120C  mov      x0, x19
006AB1210  mov      x1, x20
006AB1214  blr      x8
006AB1218  mov      x0, x19
006AB121C  mov      x1, xzr
006AB1220  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB1224  adrp     x21, #0x959e000
006AB1228  ldrb     w8, [x21, #0xf76]
006AB122C  mov      x20, x0
006AB1230  cbnz     w8, #0x6ab1248
006AB1234  adrp     x0, #0x8f3a000
006AB1238  ldr      x0, [x0, #0x658]
006AB123C  bl       #0x382bd14 ; 
006AB1240  mov      w8, #1
006AB1244  strb     w8, [x21, #0xf76]
006AB1248  adrp     x8, #0x8f3a000
006AB124C  ldr      x8, [x8, #0x658]
006AB1250  ldr      x2, [x8]
006AB1254  ldrb     w8, [x2, #0x53]
006AB1258  tbnz     w8, #5, #0x6ab1270
006AB125C  mov      x0, x19
006AB1260  str      x20, [x0, #0x50]!
006AB1264  mov      x1, x20
006AB1268  bl       #0x382bcb8 ; 
006AB126C  b        #0x6ab1280 ; 
006AB1270  ldr      x8, [x2, #0x60]
006AB1274  mov      x0, x19
006AB1278  mov      x1, x20
006AB127C  blr      x8
006AB1280  mov      x0, x19
006AB1284  mov      x1, xzr
006AB1288  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB128C  adrp     x21, #0x959e000
006AB1290  ldrb     w8, [x21, #0xf77]
006AB1294  mov      x20, x0
006AB1298  cbnz     w8, #0x6ab12b0
006AB129C  adrp     x0, #0x8f3a000
006AB12A0  ldr      x0, [x0, #0x668]
006AB12A4  bl       #0x382bd14 ; 
006AB12A8  mov      w8, #1
006AB12AC  strb     w8, [x21, #0xf77]
006AB12B0  adrp     x8, #0x8f3a000
006AB12B4  ldr      x8, [x8, #0x668]
006AB12B8  ldr      x2, [x8]
006AB12BC  ldrb     w8, [x2, #0x53]
006AB12C0  tbnz     w8, #5, #0x6ab12d8
006AB12C4  mov      x0, x19
006AB12C8  str      x20, [x0, #0x58]!
006AB12CC  mov      x1, x20
006AB12D0  bl       #0x382bcb8 ; 
006AB12D4  b        #0x6ab12e8 ; 
006AB12D8  ldr      x8, [x2, #0x60]
006AB12DC  mov      x0, x19
006AB12E0  mov      x1, x20
006AB12E4  blr      x8
006AB12E8  mov      x0, x19
006AB12EC  mov      x1, xzr
006AB12F0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB12F4  adrp     x21, #0x959e000
006AB12F8  ldrb     w8, [x21, #0xf78]
006AB12FC  mov      x20, x0
006AB1300  cbnz     w8, #0x6ab1318
006AB1304  adrp     x0, #0x8f3a000
006AB1308  ldr      x0, [x0, #0x678]
006AB130C  bl       #0x382bd14 ; 
006AB1310  mov      w8, #1
006AB1314  strb     w8, [x21, #0xf78]
006AB1318  adrp     x8, #0x8f3a000
006AB131C  ldr      x8, [x8, #0x678]
006AB1320  ldr      x2, [x8]
006AB1324  ldrb     w8, [x2, #0x53]
006AB1328  tbnz     w8, #5, #0x6ab1340
006AB132C  mov      x0, x19
006AB1330  str      x20, [x0, #0x60]!
006AB1334  mov      x1, x20
006AB1338  bl       #0x382bcb8 ; 
006AB133C  b        #0x6ab1350 ; 
006AB1340  ldr      x8, [x2, #0x60]
006AB1344  mov      x0, x19
006AB1348  mov      x1, x20
006AB134C  blr      x8
006AB1350  mov      x0, x19
006AB1354  mov      x1, xzr
006AB1358  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB135C  adrp     x21, #0x959e000
006AB1360  ldrb     w8, [x21, #0xf79]
006AB1364  mov      x20, x0
006AB1368  cbnz     w8, #0x6ab1380
006AB136C  adrp     x0, #0x8f3a000
006AB1370  ldr      x0, [x0, #0x688]
006AB1374  bl       #0x382bd14 ; 
006AB1378  mov      w8, #1
006AB137C  strb     w8, [x21, #0xf79]
006AB1380  adrp     x8, #0x8f3a000
006AB1384  ldr      x8, [x8, #0x688]
006AB1388  ldr      x2, [x8]
006AB138C  ldrb     w8, [x2, #0x53]
006AB1390  tbnz     w8, #5, #0x6ab13a8
006AB1394  mov      x0, x19
006AB1398  str      x20, [x0, #0x68]!
006AB139C  mov      x1, x20
006AB13A0  bl       #0x382bcb8 ; 
006AB13A4  b        #0x6ab13b8 ; 
006AB13A8  ldr      x8, [x2, #0x60]
006AB13AC  mov      x0, x19
006AB13B0  mov      x1, x20
006AB13B4  blr      x8
006AB13B8  mov      x0, x19
006AB13BC  mov      x1, xzr
006AB13C0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB13C4  adrp     x21, #0x959e000
006AB13C8  ldrb     w8, [x21, #0xf7a]
006AB13CC  mov      x20, x0
006AB13D0  cbnz     w8, #0x6ab13e8
006AB13D4  adrp     x0, #0x8f3a000
006AB13D8  ldr      x0, [x0, #0x698]
006AB13DC  bl       #0x382bd14 ; 
006AB13E0  mov      w8, #1
006AB13E4  strb     w8, [x21, #0xf7a]
006AB13E8  adrp     x8, #0x8f3a000
006AB13EC  ldr      x8, [x8, #0x698]
006AB13F0  ldr      x2, [x8]
006AB13F4  ldrb     w8, [x2, #0x53]
006AB13F8  tbnz     w8, #5, #0x6ab1410
006AB13FC  mov      x0, x19
006AB1400  str      x20, [x0, #0x70]!
006AB1404  mov      x1, x20
006AB1408  bl       #0x382bcb8 ; 
006AB140C  b        #0x6ab1420 ; 
006AB1410  ldr      x8, [x2, #0x60]
006AB1414  mov      x0, x19
006AB1418  mov      x1, x20
006AB141C  blr      x8
006AB1420  mov      x0, x19
006AB1424  mov      x1, xzr
006AB1428  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB142C  adrp     x21, #0x959e000
006AB1430  ldrb     w8, [x21, #0xf7b]
006AB1434  mov      x20, x0
006AB1438  cbnz     w8, #0x6ab1450
006AB143C  adrp     x0, #0x8f3a000
006AB1440  ldr      x0, [x0, #0x6a8]
006AB1444  bl       #0x382bd14 ; 
006AB1448  mov      w8, #1
006AB144C  strb     w8, [x21, #0xf7b]
006AB1450  adrp     x8, #0x8f3a000
006AB1454  ldr      x8, [x8, #0x6a8]
006AB1458  ldr      x2, [x8]
006AB145C  ldrb     w8, [x2, #0x53]
006AB1460  tbnz     w8, #5, #0x6ab1478
006AB1464  mov      x0, x19
006AB1468  str      x20, [x0, #0x78]!
006AB146C  mov      x1, x20
006AB1470  bl       #0x382bcb8 ; 
006AB1474  b        #0x6ab1488 ; 
006AB1478  ldr      x8, [x2, #0x60]
006AB147C  mov      x0, x19
006AB1480  mov      x1, x20
006AB1484  blr      x8
006AB1488  mov      x0, x19
006AB148C  mov      x1, xzr
006AB1490  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB1494  adrp     x21, #0x959e000
006AB1498  ldrb     w8, [x21, #0xf7c]
006AB149C  mov      x20, x0
006AB14A0  cbnz     w8, #0x6ab14b8
006AB14A4  adrp     x0, #0x8f3a000
006AB14A8  ldr      x0, [x0, #0x6b8]
006AB14AC  bl       #0x382bd14 ; 
006AB14B0  mov      w8, #1
006AB14B4  strb     w8, [x21, #0xf7c]
006AB14B8  adrp     x8, #0x8f3a000
006AB14BC  ldr      x8, [x8, #0x6b8]
006AB14C0  ldr      x2, [x8]
006AB14C4  ldrb     w8, [x2, #0x53]
006AB14C8  tbnz     w8, #5, #0x6ab14e0
006AB14CC  mov      x0, x19
006AB14D0  str      x20, [x0, #0x80]!
006AB14D4  mov      x1, x20
006AB14D8  bl       #0x382bcb8 ; 
006AB14DC  b        #0x6ab14f0 ; 
006AB14E0  ldr      x8, [x2, #0x60]
006AB14E4  mov      x0, x19
006AB14E8  mov      x1, x20
006AB14EC  blr      x8
006AB14F0  mov      x0, x19
006AB14F4  mov      x1, xzr
006AB14F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB14FC  adrp     x21, #0x959e000
006AB1500  ldrb     w8, [x21, #0xf7d]
006AB1504  mov      x20, x0
006AB1508  cbnz     w8, #0x6ab1520
006AB150C  adrp     x0, #0x8f3a000
006AB1510  ldr      x0, [x0, #0x6c8]
006AB1514  bl       #0x382bd14 ; 
006AB1518  mov      w8, #1
006AB151C  strb     w8, [x21, #0xf7d]
006AB1520  adrp     x8, #0x8f3a000
006AB1524  ldr      x8, [x8, #0x6c8]
006AB1528  ldr      x2, [x8]
006AB152C  ldrb     w8, [x2, #0x53]
006AB1530  tbnz     w8, #5, #0x6ab1548
006AB1534  mov      x0, x19
006AB1538  str      x20, [x0, #0x88]!
006AB153C  mov      x1, x20
006AB1540  bl       #0x382bcb8 ; 
006AB1544  b        #0x6ab1558 ; 
006AB1548  ldr      x8, [x2, #0x60]
006AB154C  mov      x0, x19
006AB1550  mov      x1, x20
006AB1554  blr      x8
006AB1558  mov      x0, x19
006AB155C  mov      x1, xzr
006AB1560  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB1564  adrp     x21, #0x959e000
006AB1568  ldrb     w8, [x21, #0xf7e]
006AB156C  mov      x20, x0
006AB1570  cbnz     w8, #0x6ab1588
006AB1574  adrp     x0, #0x8f3a000
006AB1578  ldr      x0, [x0, #0x6d8]
006AB157C  bl       #0x382bd14 ; 
006AB1580  mov      w8, #1
006AB1584  strb     w8, [x21, #0xf7e]
006AB1588  adrp     x8, #0x8f3a000
006AB158C  ldr      x8, [x8, #0x6d8]
006AB1590  ldr      x2, [x8]
006AB1594  ldrb     w8, [x2, #0x53]
006AB1598  tbnz     w8, #5, #0x6ab15b0
006AB159C  mov      x0, x19
006AB15A0  str      x20, [x0, #0x90]!
006AB15A4  mov      x1, x20
006AB15A8  bl       #0x382bcb8 ; 
006AB15AC  b        #0x6ab15c0 ; 
006AB15B0  ldr      x8, [x2, #0x60]
006AB15B4  mov      x0, x19
006AB15B8  mov      x1, x20
006AB15BC  blr      x8
006AB15C0  mov      x0, x19
006AB15C4  mov      x1, xzr
006AB15C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB15CC  adrp     x21, #0x959e000
006AB15D0  ldrb     w8, [x21, #0xf7f]
006AB15D4  mov      x20, x0
006AB15D8  cbnz     w8, #0x6ab15f0
006AB15DC  adrp     x0, #0x8f3a000
006AB15E0  ldr      x0, [x0, #0x6e8]
006AB15E4  bl       #0x382bd14 ; 
006AB15E8  mov      w8, #1
006AB15EC  strb     w8, [x21, #0xf7f]
006AB15F0  adrp     x8, #0x8f3a000
006AB15F4  ldr      x8, [x8, #0x6e8]
006AB15F8  ldr      x2, [x8]
006AB15FC  ldrb     w8, [x2, #0x53]
006AB1600  tbnz     w8, #5, #0x6ab1618
006AB1604  str      x20, [x19, #0x98]!
006AB1608  mov      x0, x19
006AB160C  mov      x1, x20
006AB1610  bl       #0x382bcb8 ; 
006AB1614  b        #0x6ab1628 ; 
006AB1618  ldr      x8, [x2, #0x60]
006AB161C  mov      x0, x19
006AB1620  mov      x1, x20
006AB1624  blr      x8
006AB1628  ldp      x20, x19, [sp, #0x10]
006AB162C  mov      w0, #1
006AB1630  ldp      x30, x21, [sp], #0x20
006AB1634  ret      

