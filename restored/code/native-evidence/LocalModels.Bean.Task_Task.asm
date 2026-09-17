; LocalModels.Bean.Task_Task$$readImpl
; RVA 0x6B13EC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B13EC8  stp      x30, x21, [sp, #-0x20]!
006B13ECC  stp      x20, x19, [sp, #0x10]
006B13ED0  adrp     x20, #0x959f000
006B13ED4  adrp     x21, #0x8f3e000
006B13ED8  ldrb     w8, [x20, #0x599]
006B13EDC  ldr      x21, [x21, #0xf28]
006B13EE0  mov      x19, x0
006B13EE4  tbnz     w8, #0, #0x6b13efc
006B13EE8  adrp     x0, #0x8f3e000
006B13EEC  ldr      x0, [x0, #0xf28]
006B13EF0  bl       #0x382bd14 ; 
006B13EF4  mov      w8, #1
006B13EF8  strb     w8, [x20, #0x599]
006B13EFC  ldr      x1, [x21]
006B13F00  ldrb     w8, [x1, #0x53]
006B13F04  tbnz     w8, #5, #0x6b13f54
006B13F08  mov      x0, x19
006B13F0C  mov      x1, xzr
006B13F10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B13F14  adrp     x21, #0x959f000
006B13F18  ldrb     w8, [x21, #0x9c6]
006B13F1C  mov      w20, w0
006B13F20  cbnz     w8, #0x6b13f38
006B13F24  adrp     x0, #0x8f3e000
006B13F28  ldr      x0, [x0, #0xe70]
006B13F2C  bl       #0x382bd14 ; 
006B13F30  mov      w8, #1
006B13F34  strb     w8, [x21, #0x9c6]
006B13F38  adrp     x8, #0x8f3e000
006B13F3C  ldr      x8, [x8, #0xe70]
006B13F40  ldr      x2, [x8]
006B13F44  ldrb     w8, [x2, #0x53]
006B13F48  tbnz     w8, #5, #0x6b13f68
006B13F4C  str      w20, [x19, #0x20]
006B13F50  b        #0x6b13f78 ; 
006B13F54  ldr      x2, [x1, #0x60]
006B13F58  mov      x0, x19
006B13F5C  ldp      x20, x19, [sp, #0x10]
006B13F60  ldp      x30, x21, [sp], #0x20
006B13F64  br       x2
006B13F68  ldr      x8, [x2, #0x60]
006B13F6C  mov      x0, x19
006B13F70  mov      w1, w20
006B13F74  blr      x8
006B13F78  mov      x0, x19
006B13F7C  mov      x1, xzr
006B13F80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B13F84  adrp     x21, #0x959f000
006B13F88  ldrb     w8, [x21, #0x9c7]
006B13F8C  mov      w20, w0
006B13F90  cbnz     w8, #0x6b13fa8
006B13F94  adrp     x0, #0x8f3e000
006B13F98  ldr      x0, [x0, #0xe80]
006B13F9C  bl       #0x382bd14 ; 
006B13FA0  mov      w8, #1
006B13FA4  strb     w8, [x21, #0x9c7]
006B13FA8  adrp     x8, #0x8f3e000
006B13FAC  ldr      x8, [x8, #0xe80]
006B13FB0  ldr      x2, [x8]
006B13FB4  ldrb     w8, [x2, #0x53]
006B13FB8  tbnz     w8, #5, #0x6b13fc4
006B13FBC  str      w20, [x19, #0x24]
006B13FC0  b        #0x6b13fd4 ; 
006B13FC4  ldr      x8, [x2, #0x60]
006B13FC8  mov      x0, x19
006B13FCC  mov      w1, w20
006B13FD0  blr      x8
006B13FD4  mov      x0, x19
006B13FD8  mov      x1, xzr
006B13FDC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B13FE0  adrp     x21, #0x959f000
006B13FE4  ldrb     w8, [x21, #0x9c8]
006B13FE8  mov      x20, x0
006B13FEC  cbnz     w8, #0x6b14004
006B13FF0  adrp     x0, #0x8f3e000
006B13FF4  ldr      x0, [x0, #0xe90]
006B13FF8  bl       #0x382bd14 ; 
006B13FFC  mov      w8, #1
006B14000  strb     w8, [x21, #0x9c8]
006B14004  adrp     x8, #0x8f3e000
006B14008  ldr      x8, [x8, #0xe90]
006B1400C  ldr      x2, [x8]
006B14010  ldrb     w8, [x2, #0x53]
006B14014  tbnz     w8, #5, #0x6b1402c
006B14018  mov      x0, x19
006B1401C  str      x20, [x0, #0x28]!
006B14020  mov      x1, x20
006B14024  bl       #0x382bcb8 ; 
006B14028  b        #0x6b1403c ; 
006B1402C  ldr      x8, [x2, #0x60]
006B14030  mov      x0, x19
006B14034  mov      x1, x20
006B14038  blr      x8
006B1403C  mov      x0, x19
006B14040  mov      x1, xzr
006B14044  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B14048  adrp     x21, #0x959f000
006B1404C  ldrb     w8, [x21, #0x9c9]
006B14050  mov      w20, w0
006B14054  cbnz     w8, #0x6b1406c
006B14058  adrp     x0, #0x8f3e000
006B1405C  ldr      x0, [x0, #0xea0]
006B14060  bl       #0x382bd14 ; 
006B14064  mov      w8, #1
006B14068  strb     w8, [x21, #0x9c9]
006B1406C  adrp     x8, #0x8f3e000
006B14070  ldr      x8, [x8, #0xea0]
006B14074  ldr      x2, [x8]
006B14078  ldrb     w8, [x2, #0x53]
006B1407C  tbnz     w8, #5, #0x6b14088
006B14080  str      w20, [x19, #0x30]
006B14084  b        #0x6b14098 ; 
006B14088  ldr      x8, [x2, #0x60]
006B1408C  mov      x0, x19
006B14090  mov      w1, w20
006B14094  blr      x8
006B14098  mov      x0, x19
006B1409C  mov      x1, xzr
006B140A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B140A4  adrp     x21, #0x959f000
006B140A8  ldrb     w8, [x21, #0x9ca]
006B140AC  mov      w20, w0
006B140B0  cbnz     w8, #0x6b140c8
006B140B4  adrp     x0, #0x8f3e000
006B140B8  ldr      x0, [x0, #0xeb0]
006B140BC  bl       #0x382bd14 ; 
006B140C0  mov      w8, #1
006B140C4  strb     w8, [x21, #0x9ca]
006B140C8  adrp     x8, #0x8f3e000
006B140CC  ldr      x8, [x8, #0xeb0]
006B140D0  ldr      x2, [x8]
006B140D4  ldrb     w8, [x2, #0x53]
006B140D8  tbnz     w8, #5, #0x6b140e4
006B140DC  str      w20, [x19, #0x34]
006B140E0  b        #0x6b140f4 ; 
006B140E4  ldr      x8, [x2, #0x60]
006B140E8  mov      x0, x19
006B140EC  mov      w1, w20
006B140F0  blr      x8
006B140F4  mov      x0, x19
006B140F8  mov      x1, xzr
006B140FC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B14100  adrp     x21, #0x959f000
006B14104  ldrb     w8, [x21, #0x9cb]
006B14108  mov      x20, x0
006B1410C  cbnz     w8, #0x6b14124
006B14110  adrp     x0, #0x8f3e000
006B14114  ldr      x0, [x0, #0xec0]
006B14118  bl       #0x382bd14 ; 
006B1411C  mov      w8, #1
006B14120  strb     w8, [x21, #0x9cb]
006B14124  adrp     x8, #0x8f3e000
006B14128  ldr      x8, [x8, #0xec0]
006B1412C  ldr      x2, [x8]
006B14130  ldrb     w8, [x2, #0x53]
006B14134  tbnz     w8, #5, #0x6b1414c
006B14138  mov      x0, x19
006B1413C  str      x20, [x0, #0x38]!
006B14140  mov      x1, x20
006B14144  bl       #0x382bcb8 ; 
006B14148  b        #0x6b1415c ; 
006B1414C  ldr      x8, [x2, #0x60]
006B14150  mov      x0, x19
006B14154  mov      x1, x20
006B14158  blr      x8
006B1415C  mov      x0, x19
006B14160  mov      x1, xzr
006B14164  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B14168  adrp     x21, #0x959f000
006B1416C  ldrb     w8, [x21, #0x9cc]
006B14170  mov      x20, x0
006B14174  cbnz     w8, #0x6b1418c
006B14178  adrp     x0, #0x8f3e000
006B1417C  ldr      x0, [x0, #0xed0]
006B14180  bl       #0x382bd14 ; 
006B14184  mov      w8, #1
006B14188  strb     w8, [x21, #0x9cc]
006B1418C  adrp     x8, #0x8f3e000
006B14190  ldr      x8, [x8, #0xed0]
006B14194  ldr      x2, [x8]
006B14198  ldrb     w8, [x2, #0x53]
006B1419C  tbnz     w8, #5, #0x6b141b4
006B141A0  mov      x0, x19
006B141A4  str      x20, [x0, #0x40]!
006B141A8  mov      x1, x20
006B141AC  bl       #0x382bcb8 ; 
006B141B0  b        #0x6b141c4 ; 
006B141B4  ldr      x8, [x2, #0x60]
006B141B8  mov      x0, x19
006B141BC  mov      x1, x20
006B141C0  blr      x8
006B141C4  mov      x0, x19
006B141C8  mov      x1, xzr
006B141CC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B141D0  adrp     x21, #0x959f000
006B141D4  ldrb     w8, [x21, #0x9cd]
006B141D8  mov      x20, x0
006B141DC  cbnz     w8, #0x6b141f4
006B141E0  adrp     x0, #0x8f3e000
006B141E4  ldr      x0, [x0, #0xee0]
006B141E8  bl       #0x382bd14 ; 
006B141EC  mov      w8, #1
006B141F0  strb     w8, [x21, #0x9cd]
006B141F4  adrp     x8, #0x8f3e000
006B141F8  ldr      x8, [x8, #0xee0]
006B141FC  ldr      x2, [x8]
006B14200  ldrb     w8, [x2, #0x53]
006B14204  tbnz     w8, #5, #0x6b1421c
006B14208  mov      x0, x19
006B1420C  str      x20, [x0, #0x48]!
006B14210  mov      x1, x20
006B14214  bl       #0x382bcb8 ; 
006B14218  b        #0x6b1422c ; 
006B1421C  ldr      x8, [x2, #0x60]
006B14220  mov      x0, x19
006B14224  mov      x1, x20
006B14228  blr      x8
006B1422C  mov      x0, x19
006B14230  mov      x1, xzr
006B14234  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B14238  adrp     x21, #0x959f000
006B1423C  ldrb     w8, [x21, #0x9ce]
006B14240  mov      w20, w0
006B14244  cbnz     w8, #0x6b1425c
006B14248  adrp     x0, #0x8f3e000
006B1424C  ldr      x0, [x0, #0xef0]
006B14250  bl       #0x382bd14 ; 
006B14254  mov      w8, #1
006B14258  strb     w8, [x21, #0x9ce]
006B1425C  adrp     x8, #0x8f3e000
006B14260  ldr      x8, [x8, #0xef0]
006B14264  ldr      x2, [x8]
006B14268  ldrb     w8, [x2, #0x53]
006B1426C  tbnz     w8, #5, #0x6b14278
006B14270  str      w20, [x19, #0x50]
006B14274  b        #0x6b14288 ; 
006B14278  ldr      x8, [x2, #0x60]
006B1427C  mov      x0, x19
006B14280  mov      w1, w20
006B14284  blr      x8
006B14288  mov      x0, x19
006B1428C  mov      x1, xzr
006B14290  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B14294  adrp     x21, #0x959f000
006B14298  ldrb     w8, [x21, #0x9cf]
006B1429C  mov      x20, x0
006B142A0  cbnz     w8, #0x6b142b8
006B142A4  adrp     x0, #0x8f3e000
006B142A8  ldr      x0, [x0, #0xf00]
006B142AC  bl       #0x382bd14 ; 
006B142B0  mov      w8, #1
006B142B4  strb     w8, [x21, #0x9cf]
006B142B8  adrp     x8, #0x8f3e000
006B142BC  ldr      x8, [x8, #0xf00]
006B142C0  ldr      x2, [x8]
006B142C4  ldrb     w8, [x2, #0x53]
006B142C8  tbnz     w8, #5, #0x6b142e0
006B142CC  mov      x0, x19
006B142D0  str      x20, [x0, #0x58]!
006B142D4  mov      x1, x20
006B142D8  bl       #0x382bcb8 ; 
006B142DC  b        #0x6b142f0 ; 
006B142E0  ldr      x8, [x2, #0x60]
006B142E4  mov      x0, x19
006B142E8  mov      x1, x20
006B142EC  blr      x8
006B142F0  mov      x0, x19
006B142F4  mov      x1, xzr
006B142F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B142FC  adrp     x21, #0x959f000
006B14300  ldrb     w8, [x21, #0x9d0]
006B14304  mov      x20, x0
006B14308  cbnz     w8, #0x6b14320
006B1430C  adrp     x0, #0x8f3e000
006B14310  ldr      x0, [x0, #0xf10]
006B14314  bl       #0x382bd14 ; 
006B14318  mov      w8, #1
006B1431C  strb     w8, [x21, #0x9d0]
006B14320  adrp     x8, #0x8f3e000
006B14324  ldr      x8, [x8, #0xf10]
006B14328  ldr      x2, [x8]
006B1432C  ldrb     w8, [x2, #0x53]
006B14330  tbnz     w8, #5, #0x6b14348
006B14334  mov      x0, x19
006B14338  str      x20, [x0, #0x60]!
006B1433C  mov      x1, x20
006B14340  bl       #0x382bcb8 ; 
006B14344  b        #0x6b14358 ; 
006B14348  ldr      x8, [x2, #0x60]
006B1434C  mov      x0, x19
006B14350  mov      x1, x20
006B14354  blr      x8
006B14358  mov      x0, x19
006B1435C  mov      x1, xzr
006B14360  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B14364  adrp     x21, #0x959f000
006B14368  ldrb     w8, [x21, #0x9d1]
006B1436C  mov      w20, w0
006B14370  cbnz     w8, #0x6b14388
006B14374  adrp     x0, #0x8f3e000
006B14378  ldr      x0, [x0, #0xf20]
006B1437C  bl       #0x382bd14 ; 
006B14380  mov      w8, #1
006B14384  strb     w8, [x21, #0x9d1]
006B14388  adrp     x8, #0x8f3e000
006B1438C  ldr      x8, [x8, #0xf20]
006B14390  ldr      x2, [x8]
006B14394  ldrb     w8, [x2, #0x53]
006B14398  tbnz     w8, #5, #0x6b143a4
006B1439C  str      w20, [x19, #0x68]
006B143A0  b        #0x6b143b4 ; 
006B143A4  ldr      x8, [x2, #0x60]
006B143A8  mov      x0, x19
006B143AC  mov      w1, w20
006B143B0  blr      x8
006B143B4  ldp      x20, x19, [sp, #0x10]
006B143B8  mov      w0, #1
006B143BC  ldp      x30, x21, [sp], #0x20
006B143C0  ret      

