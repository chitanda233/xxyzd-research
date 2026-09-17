; LocalModels.Bean.IAP_CycleGift$$readImpl
; RVA 0x6AA0FF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA0FF4  stp      x30, x21, [sp, #-0x20]!
006AA0FF8  stp      x20, x19, [sp, #0x10]
006AA0FFC  adrp     x20, #0x959e000
006AA1000  adrp     x21, #0x8f39000
006AA1004  ldrb     w8, [x20, #0x2ac]
006AA1008  ldr      x21, [x21, #0xae0]
006AA100C  mov      x19, x0
006AA1010  tbnz     w8, #0, #0x6aa1028
006AA1014  adrp     x0, #0x8f39000
006AA1018  ldr      x0, [x0, #0xae0]
006AA101C  bl       #0x382bd14 ; 
006AA1020  mov      w8, #1
006AA1024  strb     w8, [x20, #0x2ac]
006AA1028  ldr      x1, [x21]
006AA102C  ldrb     w8, [x1, #0x53]
006AA1030  tbnz     w8, #5, #0x6aa1080
006AA1034  mov      x0, x19
006AA1038  mov      x1, xzr
006AA103C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA1040  adrp     x21, #0x959e000
006AA1044  ldrb     w8, [x21, #0x65f]
006AA1048  mov      w20, w0
006AA104C  cbnz     w8, #0x6aa1064
006AA1050  adrp     x0, #0x8f39000
006AA1054  ldr      x0, [x0, #0xa58]
006AA1058  bl       #0x382bd14 ; 
006AA105C  mov      w8, #1
006AA1060  strb     w8, [x21, #0x65f]
006AA1064  adrp     x8, #0x8f39000
006AA1068  ldr      x8, [x8, #0xa58]
006AA106C  ldr      x2, [x8]
006AA1070  ldrb     w8, [x2, #0x53]
006AA1074  tbnz     w8, #5, #0x6aa1094
006AA1078  str      w20, [x19, #0x20]
006AA107C  b        #0x6aa10a4 ; 
006AA1080  ldr      x2, [x1, #0x60]
006AA1084  mov      x0, x19
006AA1088  ldp      x20, x19, [sp, #0x10]
006AA108C  ldp      x30, x21, [sp], #0x20
006AA1090  br       x2
006AA1094  ldr      x8, [x2, #0x60]
006AA1098  mov      x0, x19
006AA109C  mov      w1, w20
006AA10A0  blr      x8
006AA10A4  mov      x0, x19
006AA10A8  mov      x1, xzr
006AA10AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA10B0  adrp     x21, #0x959e000
006AA10B4  ldrb     w8, [x21, #0x660]
006AA10B8  mov      x20, x0
006AA10BC  cbnz     w8, #0x6aa10d4
006AA10C0  adrp     x0, #0x8f39000
006AA10C4  ldr      x0, [x0, #0xa68]
006AA10C8  bl       #0x382bd14 ; 
006AA10CC  mov      w8, #1
006AA10D0  strb     w8, [x21, #0x660]
006AA10D4  adrp     x8, #0x8f39000
006AA10D8  ldr      x8, [x8, #0xa68]
006AA10DC  ldr      x2, [x8]
006AA10E0  ldrb     w8, [x2, #0x53]
006AA10E4  tbnz     w8, #5, #0x6aa10fc
006AA10E8  mov      x0, x19
006AA10EC  str      x20, [x0, #0x28]!
006AA10F0  mov      x1, x20
006AA10F4  bl       #0x382bcb8 ; 
006AA10F8  b        #0x6aa110c ; 
006AA10FC  ldr      x8, [x2, #0x60]
006AA1100  mov      x0, x19
006AA1104  mov      x1, x20
006AA1108  blr      x8
006AA110C  mov      x0, x19
006AA1110  mov      x1, xzr
006AA1114  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA1118  adrp     x21, #0x959e000
006AA111C  ldrb     w8, [x21, #0x661]
006AA1120  mov      x20, x0
006AA1124  cbnz     w8, #0x6aa113c
006AA1128  adrp     x0, #0x8f39000
006AA112C  ldr      x0, [x0, #0xa78]
006AA1130  bl       #0x382bd14 ; 
006AA1134  mov      w8, #1
006AA1138  strb     w8, [x21, #0x661]
006AA113C  adrp     x8, #0x8f39000
006AA1140  ldr      x8, [x8, #0xa78]
006AA1144  ldr      x2, [x8]
006AA1148  ldrb     w8, [x2, #0x53]
006AA114C  tbnz     w8, #5, #0x6aa1164
006AA1150  mov      x0, x19
006AA1154  str      x20, [x0, #0x30]!
006AA1158  mov      x1, x20
006AA115C  bl       #0x382bcb8 ; 
006AA1160  b        #0x6aa1174 ; 
006AA1164  ldr      x8, [x2, #0x60]
006AA1168  mov      x0, x19
006AA116C  mov      x1, x20
006AA1170  blr      x8
006AA1174  mov      x0, x19
006AA1178  mov      x1, xzr
006AA117C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA1180  adrp     x21, #0x959e000
006AA1184  ldrb     w8, [x21, #0x662]
006AA1188  mov      w20, w0
006AA118C  cbnz     w8, #0x6aa11a4
006AA1190  adrp     x0, #0x8f39000
006AA1194  ldr      x0, [x0, #0xa88]
006AA1198  bl       #0x382bd14 ; 
006AA119C  mov      w8, #1
006AA11A0  strb     w8, [x21, #0x662]
006AA11A4  adrp     x8, #0x8f39000
006AA11A8  ldr      x8, [x8, #0xa88]
006AA11AC  ldr      x2, [x8]
006AA11B0  ldrb     w8, [x2, #0x53]
006AA11B4  tbnz     w8, #5, #0x6aa11c0
006AA11B8  str      w20, [x19, #0x38]
006AA11BC  b        #0x6aa11d0 ; 
006AA11C0  ldr      x8, [x2, #0x60]
006AA11C4  mov      x0, x19
006AA11C8  mov      w1, w20
006AA11CC  blr      x8
006AA11D0  mov      x0, x19
006AA11D4  mov      x1, xzr
006AA11D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA11DC  adrp     x21, #0x959e000
006AA11E0  ldrb     w8, [x21, #0x663]
006AA11E4  mov      w20, w0
006AA11E8  cbnz     w8, #0x6aa1200
006AA11EC  adrp     x0, #0x8f39000
006AA11F0  ldr      x0, [x0, #0xa98]
006AA11F4  bl       #0x382bd14 ; 
006AA11F8  mov      w8, #1
006AA11FC  strb     w8, [x21, #0x663]
006AA1200  adrp     x8, #0x8f39000
006AA1204  ldr      x8, [x8, #0xa98]
006AA1208  ldr      x2, [x8]
006AA120C  ldrb     w8, [x2, #0x53]
006AA1210  tbnz     w8, #5, #0x6aa121c
006AA1214  str      w20, [x19, #0x3c]
006AA1218  b        #0x6aa122c ; 
006AA121C  ldr      x8, [x2, #0x60]
006AA1220  mov      x0, x19
006AA1224  mov      w1, w20
006AA1228  blr      x8
006AA122C  mov      x0, x19
006AA1230  mov      x1, xzr
006AA1234  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA1238  adrp     x21, #0x959e000
006AA123C  ldrb     w8, [x21, #0x664]
006AA1240  mov      x20, x0
006AA1244  cbnz     w8, #0x6aa125c
006AA1248  adrp     x0, #0x8f39000
006AA124C  ldr      x0, [x0, #0xaa8]
006AA1250  bl       #0x382bd14 ; 
006AA1254  mov      w8, #1
006AA1258  strb     w8, [x21, #0x664]
006AA125C  adrp     x8, #0x8f39000
006AA1260  ldr      x8, [x8, #0xaa8]
006AA1264  ldr      x2, [x8]
006AA1268  ldrb     w8, [x2, #0x53]
006AA126C  tbnz     w8, #5, #0x6aa1284
006AA1270  mov      x0, x19
006AA1274  str      x20, [x0, #0x40]!
006AA1278  mov      x1, x20
006AA127C  bl       #0x382bcb8 ; 
006AA1280  b        #0x6aa1294 ; 
006AA1284  ldr      x8, [x2, #0x60]
006AA1288  mov      x0, x19
006AA128C  mov      x1, x20
006AA1290  blr      x8
006AA1294  mov      x0, x19
006AA1298  mov      x1, xzr
006AA129C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA12A0  adrp     x21, #0x959e000
006AA12A4  ldrb     w8, [x21, #0x665]
006AA12A8  mov      w20, w0
006AA12AC  cbnz     w8, #0x6aa12c4
006AA12B0  adrp     x0, #0x8f39000
006AA12B4  ldr      x0, [x0, #0xab8]
006AA12B8  bl       #0x382bd14 ; 
006AA12BC  mov      w8, #1
006AA12C0  strb     w8, [x21, #0x665]
006AA12C4  adrp     x8, #0x8f39000
006AA12C8  ldr      x8, [x8, #0xab8]
006AA12CC  ldr      x2, [x8]
006AA12D0  ldrb     w8, [x2, #0x53]
006AA12D4  tbnz     w8, #5, #0x6aa12e0
006AA12D8  str      w20, [x19, #0x48]
006AA12DC  b        #0x6aa12f0 ; 
006AA12E0  ldr      x8, [x2, #0x60]
006AA12E4  mov      x0, x19
006AA12E8  mov      w1, w20
006AA12EC  blr      x8
006AA12F0  mov      x0, x19
006AA12F4  mov      x1, xzr
006AA12F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA12FC  adrp     x21, #0x959e000
006AA1300  ldrb     w8, [x21, #0x666]
006AA1304  mov      w20, w0
006AA1308  cbnz     w8, #0x6aa1320
006AA130C  adrp     x0, #0x8f39000
006AA1310  ldr      x0, [x0, #0xac8]
006AA1314  bl       #0x382bd14 ; 
006AA1318  mov      w8, #1
006AA131C  strb     w8, [x21, #0x666]
006AA1320  adrp     x8, #0x8f39000
006AA1324  ldr      x8, [x8, #0xac8]
006AA1328  ldr      x2, [x8]
006AA132C  ldrb     w8, [x2, #0x53]
006AA1330  tbnz     w8, #5, #0x6aa133c
006AA1334  str      w20, [x19, #0x4c]
006AA1338  b        #0x6aa134c ; 
006AA133C  ldr      x8, [x2, #0x60]
006AA1340  mov      x0, x19
006AA1344  mov      w1, w20
006AA1348  blr      x8
006AA134C  mov      x0, x19
006AA1350  mov      x1, xzr
006AA1354  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AA1358  adrp     x21, #0x959e000
006AA135C  ldrb     w8, [x21, #0x667]
006AA1360  mov      x20, x0
006AA1364  cbnz     w8, #0x6aa137c
006AA1368  adrp     x0, #0x8f39000
006AA136C  ldr      x0, [x0, #0xad8]
006AA1370  bl       #0x382bd14 ; 
006AA1374  mov      w8, #1
006AA1378  strb     w8, [x21, #0x667]
006AA137C  adrp     x8, #0x8f39000
006AA1380  ldr      x8, [x8, #0xad8]
006AA1384  ldr      x2, [x8]
006AA1388  ldrb     w8, [x2, #0x53]
006AA138C  tbnz     w8, #5, #0x6aa13a4
006AA1390  str      x20, [x19, #0x50]!
006AA1394  mov      x0, x19
006AA1398  mov      x1, x20
006AA139C  bl       #0x382bcb8 ; 
006AA13A0  b        #0x6aa13b4 ; 
006AA13A4  ldr      x8, [x2, #0x60]
006AA13A8  mov      x0, x19
006AA13AC  mov      x1, x20
006AA13B0  blr      x8
006AA13B4  ldp      x20, x19, [sp, #0x10]
006AA13B8  mov      w0, #1
006AA13BC  ldp      x30, x21, [sp], #0x20
006AA13C0  ret      

