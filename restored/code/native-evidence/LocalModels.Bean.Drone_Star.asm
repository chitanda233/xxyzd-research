; LocalModels.Bean.Drone_Star$$readImpl
; RVA 0x6A60240; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A60240  stp      x30, x21, [sp, #-0x20]!
006A60244  stp      x20, x19, [sp, #0x10]
006A60248  adrp     x20, #0x959d000
006A6024C  adrp     x21, #0x8f36000
006A60250  ldrb     w8, [x20, #0xbf2]
006A60254  ldr      x21, [x21, #0x9a0]
006A60258  mov      x19, x0
006A6025C  tbnz     w8, #0, #0x6a60274
006A60260  adrp     x0, #0x8f36000
006A60264  ldr      x0, [x0, #0x9a0]
006A60268  bl       #0x382bd14 ; 
006A6026C  mov      w8, #1
006A60270  strb     w8, [x20, #0xbf2]
006A60274  ldr      x1, [x21]
006A60278  ldrb     w8, [x1, #0x53]
006A6027C  tbnz     w8, #5, #0x6a602cc
006A60280  mov      x0, x19
006A60284  mov      x1, xzr
006A60288  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6028C  adrp     x21, #0x959e000
006A60290  ldrb     w8, [x21, #0x396]
006A60294  mov      w20, w0
006A60298  cbnz     w8, #0x6a602b0
006A6029C  adrp     x0, #0x8f36000
006A602A0  ldr      x0, [x0, #0x950]
006A602A4  bl       #0x382bd14 ; 
006A602A8  mov      w8, #1
006A602AC  strb     w8, [x21, #0x396]
006A602B0  adrp     x8, #0x8f36000
006A602B4  ldr      x8, [x8, #0x950]
006A602B8  ldr      x2, [x8]
006A602BC  ldrb     w8, [x2, #0x53]
006A602C0  tbnz     w8, #5, #0x6a602e0
006A602C4  str      w20, [x19, #0x20]
006A602C8  b        #0x6a602f0 ; 
006A602CC  ldr      x2, [x1, #0x60]
006A602D0  mov      x0, x19
006A602D4  ldp      x20, x19, [sp, #0x10]
006A602D8  ldp      x30, x21, [sp], #0x20
006A602DC  br       x2
006A602E0  ldr      x8, [x2, #0x60]
006A602E4  mov      x0, x19
006A602E8  mov      w1, w20
006A602EC  blr      x8
006A602F0  mov      x0, x19
006A602F4  mov      x1, xzr
006A602F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A602FC  adrp     x21, #0x959e000
006A60300  ldrb     w8, [x21, #0x397]
006A60304  mov      w20, w0
006A60308  cbnz     w8, #0x6a60320
006A6030C  adrp     x0, #0x8f36000
006A60310  ldr      x0, [x0, #0x958]
006A60314  bl       #0x382bd14 ; 
006A60318  mov      w8, #1
006A6031C  strb     w8, [x21, #0x397]
006A60320  adrp     x8, #0x8f36000
006A60324  ldr      x8, [x8, #0x958]
006A60328  ldr      x2, [x8]
006A6032C  ldrb     w8, [x2, #0x53]
006A60330  tbnz     w8, #5, #0x6a6033c
006A60334  str      w20, [x19, #0x24]
006A60338  b        #0x6a6034c ; 
006A6033C  ldr      x8, [x2, #0x60]
006A60340  mov      x0, x19
006A60344  mov      w1, w20
006A60348  blr      x8
006A6034C  mov      x0, x19
006A60350  mov      x1, xzr
006A60354  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A60358  adrp     x21, #0x959e000
006A6035C  ldrb     w8, [x21, #0x398]
006A60360  mov      w20, w0
006A60364  cbnz     w8, #0x6a6037c
006A60368  adrp     x0, #0x8f36000
006A6036C  ldr      x0, [x0, #0x960]
006A60370  bl       #0x382bd14 ; 
006A60374  mov      w8, #1
006A60378  strb     w8, [x21, #0x398]
006A6037C  adrp     x8, #0x8f36000
006A60380  ldr      x8, [x8, #0x960]
006A60384  ldr      x2, [x8]
006A60388  ldrb     w8, [x2, #0x53]
006A6038C  tbnz     w8, #5, #0x6a60398
006A60390  str      w20, [x19, #0x28]
006A60394  b        #0x6a603a8 ; 
006A60398  ldr      x8, [x2, #0x60]
006A6039C  mov      x0, x19
006A603A0  mov      w1, w20
006A603A4  blr      x8
006A603A8  mov      x0, x19
006A603AC  mov      x1, xzr
006A603B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A603B4  adrp     x21, #0x959e000
006A603B8  ldrb     w8, [x21, #0x399]
006A603BC  mov      w20, w0
006A603C0  cbnz     w8, #0x6a603d8
006A603C4  adrp     x0, #0x8f36000
006A603C8  ldr      x0, [x0, #0x970]
006A603CC  bl       #0x382bd14 ; 
006A603D0  mov      w8, #1
006A603D4  strb     w8, [x21, #0x399]
006A603D8  adrp     x8, #0x8f36000
006A603DC  ldr      x8, [x8, #0x970]
006A603E0  ldr      x2, [x8]
006A603E4  ldrb     w8, [x2, #0x53]
006A603E8  tbnz     w8, #5, #0x6a603f4
006A603EC  str      w20, [x19, #0x2c]
006A603F0  b        #0x6a60404 ; 
006A603F4  ldr      x8, [x2, #0x60]
006A603F8  mov      x0, x19
006A603FC  mov      w1, w20
006A60400  blr      x8
006A60404  mov      x0, x19
006A60408  mov      x1, xzr
006A6040C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A60410  adrp     x21, #0x959e000
006A60414  ldrb     w8, [x21, #0x39a]
006A60418  mov      w20, w0
006A6041C  cbnz     w8, #0x6a60434
006A60420  adrp     x0, #0x8f36000
006A60424  ldr      x0, [x0, #0x980]
006A60428  bl       #0x382bd14 ; 
006A6042C  mov      w8, #1
006A60430  strb     w8, [x21, #0x39a]
006A60434  adrp     x8, #0x8f36000
006A60438  ldr      x8, [x8, #0x980]
006A6043C  ldr      x2, [x8]
006A60440  ldrb     w8, [x2, #0x53]
006A60444  tbnz     w8, #5, #0x6a60450
006A60448  str      w20, [x19, #0x30]
006A6044C  b        #0x6a60460 ; 
006A60450  ldr      x8, [x2, #0x60]
006A60454  mov      x0, x19
006A60458  mov      w1, w20
006A6045C  blr      x8
006A60460  mov      x0, x19
006A60464  mov      x1, xzr
006A60468  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A6046C  adrp     x21, #0x959e000
006A60470  ldrb     w8, [x21, #0x39b]
006A60474  mov      x20, x0
006A60478  cbnz     w8, #0x6a60490
006A6047C  adrp     x0, #0x8f36000
006A60480  ldr      x0, [x0, #0x988]
006A60484  bl       #0x382bd14 ; 
006A60488  mov      w8, #1
006A6048C  strb     w8, [x21, #0x39b]
006A60490  adrp     x8, #0x8f36000
006A60494  ldr      x8, [x8, #0x988]
006A60498  ldr      x2, [x8]
006A6049C  ldrb     w8, [x2, #0x53]
006A604A0  tbnz     w8, #5, #0x6a604b8
006A604A4  mov      x0, x19
006A604A8  str      x20, [x0, #0x38]!
006A604AC  mov      x1, x20
006A604B0  bl       #0x382bcb8 ; 
006A604B4  b        #0x6a604c8 ; 
006A604B8  ldr      x8, [x2, #0x60]
006A604BC  mov      x0, x19
006A604C0  mov      x1, x20
006A604C4  blr      x8
006A604C8  mov      x0, x19
006A604CC  mov      x1, xzr
006A604D0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A604D4  adrp     x21, #0x959e000
006A604D8  ldrb     w8, [x21, #0x39c]
006A604DC  mov      x20, x0
006A604E0  cbnz     w8, #0x6a604f8
006A604E4  adrp     x0, #0x8f36000
006A604E8  ldr      x0, [x0, #0x990]
006A604EC  bl       #0x382bd14 ; 
006A604F0  mov      w8, #1
006A604F4  strb     w8, [x21, #0x39c]
006A604F8  adrp     x8, #0x8f36000
006A604FC  ldr      x8, [x8, #0x990]
006A60500  ldr      x2, [x8]
006A60504  ldrb     w8, [x2, #0x53]
006A60508  tbnz     w8, #5, #0x6a60520
006A6050C  mov      x0, x19
006A60510  str      x20, [x0, #0x40]!
006A60514  mov      x1, x20
006A60518  bl       #0x382bcb8 ; 
006A6051C  b        #0x6a60530 ; 
006A60520  ldr      x8, [x2, #0x60]
006A60524  mov      x0, x19
006A60528  mov      x1, x20
006A6052C  blr      x8
006A60530  mov      x0, x19
006A60534  mov      x1, xzr
006A60538  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A6053C  adrp     x21, #0x959e000
006A60540  ldrb     w8, [x21, #0x39d]
006A60544  mov      x20, x0
006A60548  cbnz     w8, #0x6a60560
006A6054C  adrp     x0, #0x8f36000
006A60550  ldr      x0, [x0, #0x998]
006A60554  bl       #0x382bd14 ; 
006A60558  mov      w8, #1
006A6055C  strb     w8, [x21, #0x39d]
006A60560  adrp     x8, #0x8f36000
006A60564  ldr      x8, [x8, #0x998]
006A60568  ldr      x2, [x8]
006A6056C  ldrb     w8, [x2, #0x53]
006A60570  tbnz     w8, #5, #0x6a60588
006A60574  str      x20, [x19, #0x48]!
006A60578  mov      x0, x19
006A6057C  mov      x1, x20
006A60580  bl       #0x382bcb8 ; 
006A60584  b        #0x6a60598 ; 
006A60588  ldr      x8, [x2, #0x60]
006A6058C  mov      x0, x19
006A60590  mov      x1, x20
006A60594  blr      x8
006A60598  ldp      x20, x19, [sp, #0x10]
006A6059C  mov      w0, #1
006A605A0  ldp      x30, x21, [sp], #0x20
006A605A4  ret      

