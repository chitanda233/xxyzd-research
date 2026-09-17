; LocalModels.Bean.Pilot_Pilot$$readImpl
; RVA 0x6AD111C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD111C  stp      x30, x21, [sp, #-0x20]!
006AD1120  stp      x20, x19, [sp, #0x10]
006AD1124  adrp     x20, #0x959e000
006AD1128  adrp     x21, #0x8f3b000
006AD112C  ldrb     w8, [x20, #0xb27]
006AD1130  ldr      x21, [x21, #0xe90]
006AD1134  mov      x19, x0
006AD1138  tbnz     w8, #0, #0x6ad1150
006AD113C  adrp     x0, #0x8f3b000
006AD1140  ldr      x0, [x0, #0xe90]
006AD1144  bl       #0x382bd14 ; 
006AD1148  mov      w8, #1
006AD114C  strb     w8, [x20, #0xb27]
006AD1150  ldr      x1, [x21]
006AD1154  ldrb     w8, [x1, #0x53]
006AD1158  tbnz     w8, #5, #0x6ad11a8
006AD115C  mov      x0, x19
006AD1160  mov      x1, xzr
006AD1164  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD1168  adrp     x21, #0x959f000
006AD116C  ldrb     w8, [x21, #0xe5]
006AD1170  mov      w20, w0
006AD1174  cbnz     w8, #0x6ad118c
006AD1178  adrp     x0, #0x8f3b000
006AD117C  ldr      x0, [x0, #0xdc8]
006AD1180  bl       #0x382bd14 ; 
006AD1184  mov      w8, #1
006AD1188  strb     w8, [x21, #0xe5]
006AD118C  adrp     x8, #0x8f3b000
006AD1190  ldr      x8, [x8, #0xdc8]
006AD1194  ldr      x2, [x8]
006AD1198  ldrb     w8, [x2, #0x53]
006AD119C  tbnz     w8, #5, #0x6ad11bc
006AD11A0  str      w20, [x19, #0x20]
006AD11A4  b        #0x6ad11cc ; 
006AD11A8  ldr      x2, [x1, #0x60]
006AD11AC  mov      x0, x19
006AD11B0  ldp      x20, x19, [sp, #0x10]
006AD11B4  ldp      x30, x21, [sp], #0x20
006AD11B8  br       x2
006AD11BC  ldr      x8, [x2, #0x60]
006AD11C0  mov      x0, x19
006AD11C4  mov      w1, w20
006AD11C8  blr      x8
006AD11CC  mov      x0, x19
006AD11D0  mov      x1, xzr
006AD11D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD11D8  adrp     x21, #0x959f000
006AD11DC  ldrb     w8, [x21, #0xe6]
006AD11E0  mov      w20, w0
006AD11E4  cbnz     w8, #0x6ad11fc
006AD11E8  adrp     x0, #0x8f3b000
006AD11EC  ldr      x0, [x0, #0xdd8]
006AD11F0  bl       #0x382bd14 ; 
006AD11F4  mov      w8, #1
006AD11F8  strb     w8, [x21, #0xe6]
006AD11FC  adrp     x8, #0x8f3b000
006AD1200  ldr      x8, [x8, #0xdd8]
006AD1204  ldr      x2, [x8]
006AD1208  ldrb     w8, [x2, #0x53]
006AD120C  tbnz     w8, #5, #0x6ad1218
006AD1210  str      w20, [x19, #0x24]
006AD1214  b        #0x6ad1228 ; 
006AD1218  ldr      x8, [x2, #0x60]
006AD121C  mov      x0, x19
006AD1220  mov      w1, w20
006AD1224  blr      x8
006AD1228  mov      x0, x19
006AD122C  mov      x1, xzr
006AD1230  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD1234  adrp     x21, #0x959f000
006AD1238  ldrb     w8, [x21, #0xe7]
006AD123C  mov      w20, w0
006AD1240  cbnz     w8, #0x6ad1258
006AD1244  adrp     x0, #0x8f3b000
006AD1248  ldr      x0, [x0, #0xde8]
006AD124C  bl       #0x382bd14 ; 
006AD1250  mov      w8, #1
006AD1254  strb     w8, [x21, #0xe7]
006AD1258  adrp     x8, #0x8f3b000
006AD125C  ldr      x8, [x8, #0xde8]
006AD1260  ldr      x2, [x8]
006AD1264  ldrb     w8, [x2, #0x53]
006AD1268  tbnz     w8, #5, #0x6ad1274
006AD126C  str      w20, [x19, #0x28]
006AD1270  b        #0x6ad1284 ; 
006AD1274  ldr      x8, [x2, #0x60]
006AD1278  mov      x0, x19
006AD127C  mov      w1, w20
006AD1280  blr      x8
006AD1284  mov      x0, x19
006AD1288  mov      x1, xzr
006AD128C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD1290  adrp     x21, #0x959f000
006AD1294  ldrb     w8, [x21, #0xe8]
006AD1298  mov      x20, x0
006AD129C  cbnz     w8, #0x6ad12b4
006AD12A0  adrp     x0, #0x8f3b000
006AD12A4  ldr      x0, [x0, #0xdf8]
006AD12A8  bl       #0x382bd14 ; 
006AD12AC  mov      w8, #1
006AD12B0  strb     w8, [x21, #0xe8]
006AD12B4  adrp     x8, #0x8f3b000
006AD12B8  ldr      x8, [x8, #0xdf8]
006AD12BC  ldr      x2, [x8]
006AD12C0  ldrb     w8, [x2, #0x53]
006AD12C4  tbnz     w8, #5, #0x6ad12dc
006AD12C8  mov      x0, x19
006AD12CC  str      x20, [x0, #0x30]!
006AD12D0  mov      x1, x20
006AD12D4  bl       #0x382bcb8 ; 
006AD12D8  b        #0x6ad12ec ; 
006AD12DC  ldr      x8, [x2, #0x60]
006AD12E0  mov      x0, x19
006AD12E4  mov      x1, x20
006AD12E8  blr      x8
006AD12EC  mov      x0, x19
006AD12F0  mov      x1, xzr
006AD12F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD12F8  adrp     x21, #0x959f000
006AD12FC  ldrb     w8, [x21, #0xe9]
006AD1300  mov      x20, x0
006AD1304  cbnz     w8, #0x6ad131c
006AD1308  adrp     x0, #0x8f3b000
006AD130C  ldr      x0, [x0, #0xe08]
006AD1310  bl       #0x382bd14 ; 
006AD1314  mov      w8, #1
006AD1318  strb     w8, [x21, #0xe9]
006AD131C  adrp     x8, #0x8f3b000
006AD1320  ldr      x8, [x8, #0xe08]
006AD1324  ldr      x2, [x8]
006AD1328  ldrb     w8, [x2, #0x53]
006AD132C  tbnz     w8, #5, #0x6ad1344
006AD1330  mov      x0, x19
006AD1334  str      x20, [x0, #0x38]!
006AD1338  mov      x1, x20
006AD133C  bl       #0x382bcb8 ; 
006AD1340  b        #0x6ad1354 ; 
006AD1344  ldr      x8, [x2, #0x60]
006AD1348  mov      x0, x19
006AD134C  mov      x1, x20
006AD1350  blr      x8
006AD1354  mov      x0, x19
006AD1358  mov      x1, xzr
006AD135C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD1360  adrp     x21, #0x959f000
006AD1364  ldrb     w8, [x21, #0xea]
006AD1368  mov      w20, w0
006AD136C  cbnz     w8, #0x6ad1384
006AD1370  adrp     x0, #0x8f3b000
006AD1374  ldr      x0, [x0, #0xe18]
006AD1378  bl       #0x382bd14 ; 
006AD137C  mov      w8, #1
006AD1380  strb     w8, [x21, #0xea]
006AD1384  adrp     x8, #0x8f3b000
006AD1388  ldr      x8, [x8, #0xe18]
006AD138C  ldr      x2, [x8]
006AD1390  ldrb     w8, [x2, #0x53]
006AD1394  tbnz     w8, #5, #0x6ad13a0
006AD1398  str      w20, [x19, #0x40]
006AD139C  b        #0x6ad13b0 ; 
006AD13A0  ldr      x8, [x2, #0x60]
006AD13A4  mov      x0, x19
006AD13A8  mov      w1, w20
006AD13AC  blr      x8
006AD13B0  mov      x0, x19
006AD13B4  mov      x1, xzr
006AD13B8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD13BC  adrp     x21, #0x959f000
006AD13C0  ldrb     w8, [x21, #0xeb]
006AD13C4  mov      x20, x0
006AD13C8  cbnz     w8, #0x6ad13e0
006AD13CC  adrp     x0, #0x8f3b000
006AD13D0  ldr      x0, [x0, #0xe28]
006AD13D4  bl       #0x382bd14 ; 
006AD13D8  mov      w8, #1
006AD13DC  strb     w8, [x21, #0xeb]
006AD13E0  adrp     x8, #0x8f3b000
006AD13E4  ldr      x8, [x8, #0xe28]
006AD13E8  ldr      x2, [x8]
006AD13EC  ldrb     w8, [x2, #0x53]
006AD13F0  tbnz     w8, #5, #0x6ad1408
006AD13F4  mov      x0, x19
006AD13F8  str      x20, [x0, #0x48]!
006AD13FC  mov      x1, x20
006AD1400  bl       #0x382bcb8 ; 
006AD1404  b        #0x6ad1418 ; 
006AD1408  ldr      x8, [x2, #0x60]
006AD140C  mov      x0, x19
006AD1410  mov      x1, x20
006AD1414  blr      x8
006AD1418  mov      x0, x19
006AD141C  mov      x1, xzr
006AD1420  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD1424  adrp     x21, #0x959f000
006AD1428  ldrb     w8, [x21, #0xec]
006AD142C  mov      x20, x0
006AD1430  cbnz     w8, #0x6ad1448
006AD1434  adrp     x0, #0x8f3b000
006AD1438  ldr      x0, [x0, #0xe38]
006AD143C  bl       #0x382bd14 ; 
006AD1440  mov      w8, #1
006AD1444  strb     w8, [x21, #0xec]
006AD1448  adrp     x8, #0x8f3b000
006AD144C  ldr      x8, [x8, #0xe38]
006AD1450  ldr      x2, [x8]
006AD1454  ldrb     w8, [x2, #0x53]
006AD1458  tbnz     w8, #5, #0x6ad1470
006AD145C  mov      x0, x19
006AD1460  str      x20, [x0, #0x50]!
006AD1464  mov      x1, x20
006AD1468  bl       #0x382bcb8 ; 
006AD146C  b        #0x6ad1480 ; 
006AD1470  ldr      x8, [x2, #0x60]
006AD1474  mov      x0, x19
006AD1478  mov      x1, x20
006AD147C  blr      x8
006AD1480  mov      x0, x19
006AD1484  mov      x1, xzr
006AD1488  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AD148C  adrp     x21, #0x959f000
006AD1490  ldrb     w8, [x21, #0xed]
006AD1494  mov      x20, x0
006AD1498  cbnz     w8, #0x6ad14b0
006AD149C  adrp     x0, #0x8f3b000
006AD14A0  ldr      x0, [x0, #0xe48]
006AD14A4  bl       #0x382bd14 ; 
006AD14A8  mov      w8, #1
006AD14AC  strb     w8, [x21, #0xed]
006AD14B0  adrp     x8, #0x8f3b000
006AD14B4  ldr      x8, [x8, #0xe48]
006AD14B8  ldr      x2, [x8]
006AD14BC  ldrb     w8, [x2, #0x53]
006AD14C0  tbnz     w8, #5, #0x6ad14d8
006AD14C4  mov      x0, x19
006AD14C8  str      x20, [x0, #0x58]!
006AD14CC  mov      x1, x20
006AD14D0  bl       #0x382bcb8 ; 
006AD14D4  b        #0x6ad14e8 ; 
006AD14D8  ldr      x8, [x2, #0x60]
006AD14DC  mov      x0, x19
006AD14E0  mov      x1, x20
006AD14E4  blr      x8
006AD14E8  mov      x0, x19
006AD14EC  mov      x1, xzr
006AD14F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD14F4  adrp     x21, #0x959f000
006AD14F8  ldrb     w8, [x21, #0xee]
006AD14FC  mov      w20, w0
006AD1500  cbnz     w8, #0x6ad1518
006AD1504  adrp     x0, #0x8f3b000
006AD1508  ldr      x0, [x0, #0xe58]
006AD150C  bl       #0x382bd14 ; 
006AD1510  mov      w8, #1
006AD1514  strb     w8, [x21, #0xee]
006AD1518  adrp     x8, #0x8f3b000
006AD151C  ldr      x8, [x8, #0xe58]
006AD1520  ldr      x2, [x8]
006AD1524  ldrb     w8, [x2, #0x53]
006AD1528  tbnz     w8, #5, #0x6ad1534
006AD152C  str      w20, [x19, #0x60]
006AD1530  b        #0x6ad1544 ; 
006AD1534  ldr      x8, [x2, #0x60]
006AD1538  mov      x0, x19
006AD153C  mov      w1, w20
006AD1540  blr      x8
006AD1544  mov      x0, x19
006AD1548  mov      x1, xzr
006AD154C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD1550  adrp     x21, #0x959f000
006AD1554  ldrb     w8, [x21, #0xef]
006AD1558  mov      w20, w0
006AD155C  cbnz     w8, #0x6ad1574
006AD1560  adrp     x0, #0x8f3b000
006AD1564  ldr      x0, [x0, #0xe68]
006AD1568  bl       #0x382bd14 ; 
006AD156C  mov      w8, #1
006AD1570  strb     w8, [x21, #0xef]
006AD1574  adrp     x8, #0x8f3b000
006AD1578  ldr      x8, [x8, #0xe68]
006AD157C  ldr      x2, [x8]
006AD1580  ldrb     w8, [x2, #0x53]
006AD1584  tbnz     w8, #5, #0x6ad1590
006AD1588  str      w20, [x19, #0x64]
006AD158C  b        #0x6ad15a0 ; 
006AD1590  ldr      x8, [x2, #0x60]
006AD1594  mov      x0, x19
006AD1598  mov      w1, w20
006AD159C  blr      x8
006AD15A0  mov      x0, x19
006AD15A4  mov      x1, xzr
006AD15A8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD15AC  adrp     x21, #0x959f000
006AD15B0  ldrb     w8, [x21, #0xf0]
006AD15B4  mov      x20, x0
006AD15B8  cbnz     w8, #0x6ad15d0
006AD15BC  adrp     x0, #0x8f3b000
006AD15C0  ldr      x0, [x0, #0xe78]
006AD15C4  bl       #0x382bd14 ; 
006AD15C8  mov      w8, #1
006AD15CC  strb     w8, [x21, #0xf0]
006AD15D0  adrp     x8, #0x8f3b000
006AD15D4  ldr      x8, [x8, #0xe78]
006AD15D8  ldr      x2, [x8]
006AD15DC  ldrb     w8, [x2, #0x53]
006AD15E0  tbnz     w8, #5, #0x6ad15f8
006AD15E4  mov      x0, x19
006AD15E8  str      x20, [x0, #0x68]!
006AD15EC  mov      x1, x20
006AD15F0  bl       #0x382bcb8 ; 
006AD15F4  b        #0x6ad1608 ; 
006AD15F8  ldr      x8, [x2, #0x60]
006AD15FC  mov      x0, x19
006AD1600  mov      x1, x20
006AD1604  blr      x8
006AD1608  mov      x0, x19
006AD160C  mov      x1, xzr
006AD1610  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD1614  adrp     x21, #0x959f000
006AD1618  ldrb     w8, [x21, #0xf1]
006AD161C  mov      x20, x0
006AD1620  cbnz     w8, #0x6ad1638
006AD1624  adrp     x0, #0x8f3b000
006AD1628  ldr      x0, [x0, #0xe88]
006AD162C  bl       #0x382bd14 ; 
006AD1630  mov      w8, #1
006AD1634  strb     w8, [x21, #0xf1]
006AD1638  adrp     x8, #0x8f3b000
006AD163C  ldr      x8, [x8, #0xe88]
006AD1640  ldr      x2, [x8]
006AD1644  ldrb     w8, [x2, #0x53]
006AD1648  tbnz     w8, #5, #0x6ad1660
006AD164C  str      x20, [x19, #0x70]!
006AD1650  mov      x0, x19
006AD1654  mov      x1, x20
006AD1658  bl       #0x382bcb8 ; 
006AD165C  b        #0x6ad1670 ; 
006AD1660  ldr      x8, [x2, #0x60]
006AD1664  mov      x0, x19
006AD1668  mov      x1, x20
006AD166C  blr      x8
006AD1670  ldp      x20, x19, [sp, #0x10]
006AD1674  mov      w0, #1
006AD1678  ldp      x30, x21, [sp], #0x20
006AD167C  ret      

