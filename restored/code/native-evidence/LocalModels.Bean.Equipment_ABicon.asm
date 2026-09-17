; LocalModels.Bean.Equipment_ABicon$$readImpl
; RVA 0x6A64638; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A64638  stp      x30, x21, [sp, #-0x20]!
006A6463C  stp      x20, x19, [sp, #0x10]
006A64640  adrp     x20, #0x959d000
006A64644  adrp     x21, #0x8f36000
006A64648  ldrb     w8, [x20, #0xc60]
006A6464C  ldr      x21, [x21, #0xcb8]
006A64650  mov      x19, x0
006A64654  tbnz     w8, #0, #0x6a6466c
006A64658  adrp     x0, #0x8f36000
006A6465C  ldr      x0, [x0, #0xcb8]
006A64660  bl       #0x382bd14 ; 
006A64664  mov      w8, #1
006A64668  strb     w8, [x20, #0xc60]
006A6466C  ldr      x1, [x21]
006A64670  ldrb     w8, [x1, #0x53]
006A64674  tbnz     w8, #5, #0x6a646c4
006A64678  mov      x0, x19
006A6467C  mov      x1, xzr
006A64680  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A64684  adrp     x21, #0x959e000
006A64688  ldrb     w8, [x21, #0x3c7]
006A6468C  mov      w20, w0
006A64690  cbnz     w8, #0x6a646a8
006A64694  adrp     x0, #0x8f36000
006A64698  ldr      x0, [x0, #0xc40]
006A6469C  bl       #0x382bd14 ; 
006A646A0  mov      w8, #1
006A646A4  strb     w8, [x21, #0x3c7]
006A646A8  adrp     x8, #0x8f36000
006A646AC  ldr      x8, [x8, #0xc40]
006A646B0  ldr      x2, [x8]
006A646B4  ldrb     w8, [x2, #0x53]
006A646B8  tbnz     w8, #5, #0x6a646d8
006A646BC  str      w20, [x19, #0x20]
006A646C0  b        #0x6a646e8 ; 
006A646C4  ldr      x2, [x1, #0x60]
006A646C8  mov      x0, x19
006A646CC  ldp      x20, x19, [sp, #0x10]
006A646D0  ldp      x30, x21, [sp], #0x20
006A646D4  br       x2
006A646D8  ldr      x8, [x2, #0x60]
006A646DC  mov      x0, x19
006A646E0  mov      w1, w20
006A646E4  blr      x8
006A646E8  mov      x0, x19
006A646EC  mov      x1, xzr
006A646F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A646F4  adrp     x21, #0x959e000
006A646F8  ldrb     w8, [x21, #0x3c8]
006A646FC  mov      w20, w0
006A64700  cbnz     w8, #0x6a64718
006A64704  adrp     x0, #0x8f36000
006A64708  ldr      x0, [x0, #0xc50]
006A6470C  bl       #0x382bd14 ; 
006A64710  mov      w8, #1
006A64714  strb     w8, [x21, #0x3c8]
006A64718  adrp     x8, #0x8f36000
006A6471C  ldr      x8, [x8, #0xc50]
006A64720  ldr      x2, [x8]
006A64724  ldrb     w8, [x2, #0x53]
006A64728  tbnz     w8, #5, #0x6a64734
006A6472C  str      w20, [x19, #0x24]
006A64730  b        #0x6a64744 ; 
006A64734  ldr      x8, [x2, #0x60]
006A64738  mov      x0, x19
006A6473C  mov      w1, w20
006A64740  blr      x8
006A64744  mov      x0, x19
006A64748  mov      x1, xzr
006A6474C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A64750  adrp     x21, #0x959e000
006A64754  ldrb     w8, [x21, #0x3c9]
006A64758  mov      x20, x0
006A6475C  cbnz     w8, #0x6a64774
006A64760  adrp     x0, #0x8f36000
006A64764  ldr      x0, [x0, #0xc60]
006A64768  bl       #0x382bd14 ; 
006A6476C  mov      w8, #1
006A64770  strb     w8, [x21, #0x3c9]
006A64774  adrp     x8, #0x8f36000
006A64778  ldr      x8, [x8, #0xc60]
006A6477C  ldr      x2, [x8]
006A64780  ldrb     w8, [x2, #0x53]
006A64784  tbnz     w8, #5, #0x6a6479c
006A64788  mov      x0, x19
006A6478C  str      x20, [x0, #0x28]!
006A64790  mov      x1, x20
006A64794  bl       #0x382bcb8 ; 
006A64798  b        #0x6a647ac ; 
006A6479C  ldr      x8, [x2, #0x60]
006A647A0  mov      x0, x19
006A647A4  mov      x1, x20
006A647A8  blr      x8
006A647AC  mov      x0, x19
006A647B0  mov      x1, xzr
006A647B4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A647B8  adrp     x21, #0x959e000
006A647BC  ldrb     w8, [x21, #0x3ca]
006A647C0  mov      x20, x0
006A647C4  cbnz     w8, #0x6a647dc
006A647C8  adrp     x0, #0x8f36000
006A647CC  ldr      x0, [x0, #0xc70]
006A647D0  bl       #0x382bd14 ; 
006A647D4  mov      w8, #1
006A647D8  strb     w8, [x21, #0x3ca]
006A647DC  adrp     x8, #0x8f36000
006A647E0  ldr      x8, [x8, #0xc70]
006A647E4  ldr      x2, [x8]
006A647E8  ldrb     w8, [x2, #0x53]
006A647EC  tbnz     w8, #5, #0x6a64804
006A647F0  mov      x0, x19
006A647F4  str      x20, [x0, #0x30]!
006A647F8  mov      x1, x20
006A647FC  bl       #0x382bcb8 ; 
006A64800  b        #0x6a64814 ; 
006A64804  ldr      x8, [x2, #0x60]
006A64808  mov      x0, x19
006A6480C  mov      x1, x20
006A64810  blr      x8
006A64814  mov      x0, x19
006A64818  mov      x1, xzr
006A6481C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A64820  adrp     x21, #0x959e000
006A64824  ldrb     w8, [x21, #0x3cb]
006A64828  mov      x20, x0
006A6482C  cbnz     w8, #0x6a64844
006A64830  adrp     x0, #0x8f36000
006A64834  ldr      x0, [x0, #0xc80]
006A64838  bl       #0x382bd14 ; 
006A6483C  mov      w8, #1
006A64840  strb     w8, [x21, #0x3cb]
006A64844  adrp     x8, #0x8f36000
006A64848  ldr      x8, [x8, #0xc80]
006A6484C  ldr      x2, [x8]
006A64850  ldrb     w8, [x2, #0x53]
006A64854  tbnz     w8, #5, #0x6a6486c
006A64858  mov      x0, x19
006A6485C  str      x20, [x0, #0x38]!
006A64860  mov      x1, x20
006A64864  bl       #0x382bcb8 ; 
006A64868  b        #0x6a6487c ; 
006A6486C  ldr      x8, [x2, #0x60]
006A64870  mov      x0, x19
006A64874  mov      x1, x20
006A64878  blr      x8
006A6487C  mov      x0, x19
006A64880  mov      x1, xzr
006A64884  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A64888  adrp     x21, #0x959e000
006A6488C  ldrb     w8, [x21, #0x3cc]
006A64890  mov      x20, x0
006A64894  cbnz     w8, #0x6a648ac
006A64898  adrp     x0, #0x8f36000
006A6489C  ldr      x0, [x0, #0xc90]
006A648A0  bl       #0x382bd14 ; 
006A648A4  mov      w8, #1
006A648A8  strb     w8, [x21, #0x3cc]
006A648AC  adrp     x8, #0x8f36000
006A648B0  ldr      x8, [x8, #0xc90]
006A648B4  ldr      x2, [x8]
006A648B8  ldrb     w8, [x2, #0x53]
006A648BC  tbnz     w8, #5, #0x6a648d4
006A648C0  mov      x0, x19
006A648C4  str      x20, [x0, #0x40]!
006A648C8  mov      x1, x20
006A648CC  bl       #0x382bcb8 ; 
006A648D0  b        #0x6a648e4 ; 
006A648D4  ldr      x8, [x2, #0x60]
006A648D8  mov      x0, x19
006A648DC  mov      x1, x20
006A648E0  blr      x8
006A648E4  mov      x0, x19
006A648E8  mov      x1, xzr
006A648EC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A648F0  adrp     x21, #0x959e000
006A648F4  ldrb     w8, [x21, #0x3cd]
006A648F8  mov      x20, x0
006A648FC  cbnz     w8, #0x6a64914
006A64900  adrp     x0, #0x8f36000
006A64904  ldr      x0, [x0, #0xca0]
006A64908  bl       #0x382bd14 ; 
006A6490C  mov      w8, #1
006A64910  strb     w8, [x21, #0x3cd]
006A64914  adrp     x8, #0x8f36000
006A64918  ldr      x8, [x8, #0xca0]
006A6491C  ldr      x2, [x8]
006A64920  ldrb     w8, [x2, #0x53]
006A64924  tbnz     w8, #5, #0x6a6493c
006A64928  mov      x0, x19
006A6492C  str      x20, [x0, #0x48]!
006A64930  mov      x1, x20
006A64934  bl       #0x382bcb8 ; 
006A64938  b        #0x6a6494c ; 
006A6493C  ldr      x8, [x2, #0x60]
006A64940  mov      x0, x19
006A64944  mov      x1, x20
006A64948  blr      x8
006A6494C  mov      x0, x19
006A64950  mov      x1, xzr
006A64954  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A64958  adrp     x21, #0x959e000
006A6495C  ldrb     w8, [x21, #0x3ce]
006A64960  mov      x20, x0
006A64964  cbnz     w8, #0x6a6497c
006A64968  adrp     x0, #0x8f36000
006A6496C  ldr      x0, [x0, #0xcb0]
006A64970  bl       #0x382bd14 ; 
006A64974  mov      w8, #1
006A64978  strb     w8, [x21, #0x3ce]
006A6497C  adrp     x8, #0x8f36000
006A64980  ldr      x8, [x8, #0xcb0]
006A64984  ldr      x2, [x8]
006A64988  ldrb     w8, [x2, #0x53]
006A6498C  tbnz     w8, #5, #0x6a649a4
006A64990  str      x20, [x19, #0x50]!
006A64994  mov      x0, x19
006A64998  mov      x1, x20
006A6499C  bl       #0x382bcb8 ; 
006A649A0  b        #0x6a649b4 ; 
006A649A4  ldr      x8, [x2, #0x60]
006A649A8  mov      x0, x19
006A649AC  mov      x1, x20
006A649B0  blr      x8
006A649B4  ldp      x20, x19, [sp, #0x10]
006A649B8  mov      w0, #1
006A649BC  ldp      x30, x21, [sp], #0x20
006A649C0  ret      

