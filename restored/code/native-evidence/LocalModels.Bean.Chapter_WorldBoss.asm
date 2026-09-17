; LocalModels.Bean.Chapter_WorldBoss$$readImpl
; RVA 0x68BC5BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068BC5BC  str      d8, [sp, #-0x30]!
0068BC5C0  stp      x30, x21, [sp, #0x10]
0068BC5C4  stp      x20, x19, [sp, #0x20]
0068BC5C8  adrp     x20, #0x959c000
0068BC5CC  adrp     x21, #0x8f27000
0068BC5D0  ldrb     w8, [x20, #0x1b1]
0068BC5D4  ldr      x21, [x21, #0x8f8]
0068BC5D8  mov      x19, x0
0068BC5DC  tbnz     w8, #0, #0x68bc5f4
0068BC5E0  adrp     x0, #0x8f27000
0068BC5E4  ldr      x0, [x0, #0x8f8]
0068BC5E8  bl       #0x382bd14 ; 
0068BC5EC  mov      w8, #1
0068BC5F0  strb     w8, [x20, #0x1b1]
0068BC5F4  ldr      x1, [x21]
0068BC5F8  ldrb     w8, [x1, #0x53]
0068BC5FC  tbnz     w8, #5, #0x68bc64c
0068BC600  mov      x0, x19
0068BC604  mov      x1, xzr
0068BC608  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BC60C  adrp     x21, #0x959c000
0068BC610  ldrb     w8, [x21, #0x65b]
0068BC614  mov      w20, w0
0068BC618  cbnz     w8, #0x68bc630
0068BC61C  adrp     x0, #0x8f27000
0068BC620  ldr      x0, [x0, #0x6f8]
0068BC624  bl       #0x382bd14 ; 
0068BC628  mov      w8, #1
0068BC62C  strb     w8, [x21, #0x65b]
0068BC630  adrp     x8, #0x8f27000
0068BC634  ldr      x8, [x8, #0x6f8]
0068BC638  ldr      x2, [x8]
0068BC63C  ldrb     w8, [x2, #0x53]
0068BC640  tbnz     w8, #5, #0x68bc664
0068BC644  str      w20, [x19, #0x20]
0068BC648  b        #0x68bc674 ; 
0068BC64C  ldr      x2, [x1, #0x60]
0068BC650  mov      x0, x19
0068BC654  ldp      x20, x19, [sp, #0x20]
0068BC658  ldp      x30, x21, [sp, #0x10]
0068BC65C  ldr      d8, [sp], #0x30
0068BC660  br       x2
0068BC664  ldr      x8, [x2, #0x60]
0068BC668  mov      x0, x19
0068BC66C  mov      w1, w20
0068BC670  blr      x8
0068BC674  mov      x0, x19
0068BC678  mov      x1, xzr
0068BC67C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068BC680  adrp     x21, #0x959c000
0068BC684  ldrb     w8, [x21, #0x65c]
0068BC688  mov      x20, x0
0068BC68C  cbnz     w8, #0x68bc6a4
0068BC690  adrp     x0, #0x8f27000
0068BC694  ldr      x0, [x0, #0x708]
0068BC698  bl       #0x382bd14 ; 
0068BC69C  mov      w8, #1
0068BC6A0  strb     w8, [x21, #0x65c]
0068BC6A4  adrp     x8, #0x8f27000
0068BC6A8  ldr      x8, [x8, #0x708]
0068BC6AC  ldr      x2, [x8]
0068BC6B0  ldrb     w8, [x2, #0x53]
0068BC6B4  tbnz     w8, #5, #0x68bc6cc
0068BC6B8  mov      x0, x19
0068BC6BC  str      x20, [x0, #0x28]!
0068BC6C0  mov      x1, x20
0068BC6C4  bl       #0x382bcb8 ; 
0068BC6C8  b        #0x68bc6dc ; 
0068BC6CC  ldr      x8, [x2, #0x60]
0068BC6D0  mov      x0, x19
0068BC6D4  mov      x1, x20
0068BC6D8  blr      x8
0068BC6DC  mov      x0, x19
0068BC6E0  mov      x1, xzr
0068BC6E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BC6E8  adrp     x21, #0x959c000
0068BC6EC  ldrb     w8, [x21, #0x65d]
0068BC6F0  mov      w20, w0
0068BC6F4  cbnz     w8, #0x68bc70c
0068BC6F8  adrp     x0, #0x8f27000
0068BC6FC  ldr      x0, [x0, #0x718]
0068BC700  bl       #0x382bd14 ; 
0068BC704  mov      w8, #1
0068BC708  strb     w8, [x21, #0x65d]
0068BC70C  adrp     x8, #0x8f27000
0068BC710  ldr      x8, [x8, #0x718]
0068BC714  ldr      x2, [x8]
0068BC718  ldrb     w8, [x2, #0x53]
0068BC71C  tbnz     w8, #5, #0x68bc728
0068BC720  str      w20, [x19, #0x30]
0068BC724  b        #0x68bc738 ; 
0068BC728  ldr      x8, [x2, #0x60]
0068BC72C  mov      x0, x19
0068BC730  mov      w1, w20
0068BC734  blr      x8
0068BC738  mov      x0, x19
0068BC73C  mov      x1, xzr
0068BC740  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BC744  adrp     x21, #0x959c000
0068BC748  ldrb     w8, [x21, #0x65e]
0068BC74C  mov      x20, x0
0068BC750  cbnz     w8, #0x68bc768
0068BC754  adrp     x0, #0x8f27000
0068BC758  ldr      x0, [x0, #0x728]
0068BC75C  bl       #0x382bd14 ; 
0068BC760  mov      w8, #1
0068BC764  strb     w8, [x21, #0x65e]
0068BC768  adrp     x8, #0x8f27000
0068BC76C  ldr      x8, [x8, #0x728]
0068BC770  ldr      x2, [x8]
0068BC774  ldrb     w8, [x2, #0x53]
0068BC778  tbnz     w8, #5, #0x68bc790
0068BC77C  mov      x0, x19
0068BC780  str      x20, [x0, #0x38]!
0068BC784  mov      x1, x20
0068BC788  bl       #0x382bcb8 ; 
0068BC78C  b        #0x68bc7a0 ; 
0068BC790  ldr      x8, [x2, #0x60]
0068BC794  mov      x0, x19
0068BC798  mov      x1, x20
0068BC79C  blr      x8
0068BC7A0  mov      x0, x19
0068BC7A4  mov      x1, xzr
0068BC7A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BC7AC  adrp     x21, #0x959c000
0068BC7B0  ldrb     w8, [x21, #0x65f]
0068BC7B4  mov      w20, w0
0068BC7B8  cbnz     w8, #0x68bc7d0
0068BC7BC  adrp     x0, #0x8f27000
0068BC7C0  ldr      x0, [x0, #0x738]
0068BC7C4  bl       #0x382bd14 ; 
0068BC7C8  mov      w8, #1
0068BC7CC  strb     w8, [x21, #0x65f]
0068BC7D0  adrp     x8, #0x8f27000
0068BC7D4  ldr      x8, [x8, #0x738]
0068BC7D8  ldr      x2, [x8]
0068BC7DC  ldrb     w8, [x2, #0x53]
0068BC7E0  tbnz     w8, #5, #0x68bc7ec
0068BC7E4  str      w20, [x19, #0x40]
0068BC7E8  b        #0x68bc7fc ; 
0068BC7EC  ldr      x8, [x2, #0x60]
0068BC7F0  mov      x0, x19
0068BC7F4  mov      w1, w20
0068BC7F8  blr      x8
0068BC7FC  mov      x0, x19
0068BC800  mov      x1, xzr
0068BC804  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BC808  adrp     x21, #0x959c000
0068BC80C  ldrb     w8, [x21, #0x660]
0068BC810  mov      w20, w0
0068BC814  cbnz     w8, #0x68bc82c
0068BC818  adrp     x0, #0x8f27000
0068BC81C  ldr      x0, [x0, #0x748]
0068BC820  bl       #0x382bd14 ; 
0068BC824  mov      w8, #1
0068BC828  strb     w8, [x21, #0x660]
0068BC82C  adrp     x8, #0x8f27000
0068BC830  ldr      x8, [x8, #0x748]
0068BC834  ldr      x2, [x8]
0068BC838  ldrb     w8, [x2, #0x53]
0068BC83C  tbnz     w8, #5, #0x68bc848
0068BC840  str      w20, [x19, #0x44]
0068BC844  b        #0x68bc858 ; 
0068BC848  ldr      x8, [x2, #0x60]
0068BC84C  mov      x0, x19
0068BC850  mov      w1, w20
0068BC854  blr      x8
0068BC858  mov      x0, x19
0068BC85C  mov      x1, xzr
0068BC860  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BC864  adrp     x21, #0x959c000
0068BC868  ldrb     w8, [x21, #0x661]
0068BC86C  mov      w20, w0
0068BC870  cbnz     w8, #0x68bc888
0068BC874  adrp     x0, #0x8f27000
0068BC878  ldr      x0, [x0, #0x758]
0068BC87C  bl       #0x382bd14 ; 
0068BC880  mov      w8, #1
0068BC884  strb     w8, [x21, #0x661]
0068BC888  adrp     x8, #0x8f27000
0068BC88C  ldr      x8, [x8, #0x758]
0068BC890  ldr      x2, [x8]
0068BC894  ldrb     w8, [x2, #0x53]
0068BC898  tbnz     w8, #5, #0x68bc8a4
0068BC89C  str      w20, [x19, #0x48]
0068BC8A0  b        #0x68bc8b4 ; 
0068BC8A4  ldr      x8, [x2, #0x60]
0068BC8A8  mov      x0, x19
0068BC8AC  mov      w1, w20
0068BC8B0  blr      x8
0068BC8B4  mov      x0, x19
0068BC8B8  mov      x1, xzr
0068BC8BC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068BC8C0  adrp     x21, #0x959c000
0068BC8C4  ldrb     w8, [x21, #0x662]
0068BC8C8  mov      x20, x0
0068BC8CC  cbnz     w8, #0x68bc8e4
0068BC8D0  adrp     x0, #0x8f27000
0068BC8D4  ldr      x0, [x0, #0x768]
0068BC8D8  bl       #0x382bd14 ; 
0068BC8DC  mov      w8, #1
0068BC8E0  strb     w8, [x21, #0x662]
0068BC8E4  adrp     x8, #0x8f27000
0068BC8E8  ldr      x8, [x8, #0x768]
0068BC8EC  ldr      x2, [x8]
0068BC8F0  ldrb     w8, [x2, #0x53]
0068BC8F4  tbnz     w8, #5, #0x68bc900
0068BC8F8  str      x20, [x19, #0x50]
0068BC8FC  b        #0x68bc910 ; 
0068BC900  ldr      x8, [x2, #0x60]
0068BC904  mov      x0, x19
0068BC908  mov      x1, x20
0068BC90C  blr      x8
0068BC910  mov      x0, x19
0068BC914  mov      x1, xzr
0068BC918  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068BC91C  adrp     x21, #0x959c000
0068BC920  ldrb     w8, [x21, #0x663]
0068BC924  mov      x20, x0
0068BC928  cbnz     w8, #0x68bc940
0068BC92C  adrp     x0, #0x8f27000
0068BC930  ldr      x0, [x0, #0x778]
0068BC934  bl       #0x382bd14 ; 
0068BC938  mov      w8, #1
0068BC93C  strb     w8, [x21, #0x663]
0068BC940  adrp     x8, #0x8f27000
0068BC944  ldr      x8, [x8, #0x778]
0068BC948  ldr      x2, [x8]
0068BC94C  ldrb     w8, [x2, #0x53]
0068BC950  tbnz     w8, #5, #0x68bc95c
0068BC954  str      x20, [x19, #0x58]
0068BC958  b        #0x68bc96c ; 
0068BC95C  ldr      x8, [x2, #0x60]
0068BC960  mov      x0, x19
0068BC964  mov      x1, x20
0068BC968  blr      x8
0068BC96C  mov      x0, x19
0068BC970  mov      x1, xzr
0068BC974  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068BC978  adrp     x21, #0x959c000
0068BC97C  ldrb     w8, [x21, #0x664]
0068BC980  mov      x20, x0
0068BC984  cbnz     w8, #0x68bc99c
0068BC988  adrp     x0, #0x8f27000
0068BC98C  ldr      x0, [x0, #0x788]
0068BC990  bl       #0x382bd14 ; 
0068BC994  mov      w8, #1
0068BC998  strb     w8, [x21, #0x664]
0068BC99C  adrp     x8, #0x8f27000
0068BC9A0  ldr      x8, [x8, #0x788]
0068BC9A4  ldr      x2, [x8]
0068BC9A8  ldrb     w8, [x2, #0x53]
0068BC9AC  tbnz     w8, #5, #0x68bc9b8
0068BC9B0  str      x20, [x19, #0x60]
0068BC9B4  b        #0x68bc9c8 ; 
0068BC9B8  ldr      x8, [x2, #0x60]
0068BC9BC  mov      x0, x19
0068BC9C0  mov      x1, x20
0068BC9C4  blr      x8
0068BC9C8  mov      x0, x19
0068BC9CC  mov      x1, xzr
0068BC9D0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068BC9D4  adrp     x21, #0x959c000
0068BC9D8  ldrb     w8, [x21, #0x665]
0068BC9DC  mov      x20, x0
0068BC9E0  cbnz     w8, #0x68bc9f8
0068BC9E4  adrp     x0, #0x8f27000
0068BC9E8  ldr      x0, [x0, #0x798]
0068BC9EC  bl       #0x382bd14 ; 
0068BC9F0  mov      w8, #1
0068BC9F4  strb     w8, [x21, #0x665]
0068BC9F8  adrp     x8, #0x8f27000
0068BC9FC  ldr      x8, [x8, #0x798]
0068BCA00  ldr      x2, [x8]
0068BCA04  ldrb     w8, [x2, #0x53]
0068BCA08  tbnz     w8, #5, #0x68bca14
0068BCA0C  str      x20, [x19, #0x68]
0068BCA10  b        #0x68bca24 ; 
0068BCA14  ldr      x8, [x2, #0x60]
0068BCA18  mov      x0, x19
0068BCA1C  mov      x1, x20
0068BCA20  blr      x8
0068BCA24  mov      x0, x19
0068BCA28  mov      x1, xzr
0068BCA2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCA30  adrp     x21, #0x959c000
0068BCA34  ldrb     w8, [x21, #0x666]
0068BCA38  mov      w20, w0
0068BCA3C  cbnz     w8, #0x68bca54
0068BCA40  adrp     x0, #0x8f27000
0068BCA44  ldr      x0, [x0, #0x7a8]
0068BCA48  bl       #0x382bd14 ; 
0068BCA4C  mov      w8, #1
0068BCA50  strb     w8, [x21, #0x666]
0068BCA54  adrp     x8, #0x8f27000
0068BCA58  ldr      x8, [x8, #0x7a8]
0068BCA5C  ldr      x2, [x8]
0068BCA60  ldrb     w8, [x2, #0x53]
0068BCA64  tbnz     w8, #5, #0x68bca70
0068BCA68  str      w20, [x19, #0x70]
0068BCA6C  b        #0x68bca80 ; 
0068BCA70  ldr      x8, [x2, #0x60]
0068BCA74  mov      x0, x19
0068BCA78  mov      w1, w20
0068BCA7C  blr      x8
0068BCA80  mov      x0, x19
0068BCA84  mov      x1, xzr
0068BCA88  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068BCA8C  adrp     x21, #0x959c000
0068BCA90  ldrb     w8, [x21, #0x667]
0068BCA94  mov      x20, x0
0068BCA98  cbnz     w8, #0x68bcab0
0068BCA9C  adrp     x0, #0x8f27000
0068BCAA0  ldr      x0, [x0, #0x7b8]
0068BCAA4  bl       #0x382bd14 ; 
0068BCAA8  mov      w8, #1
0068BCAAC  strb     w8, [x21, #0x667]
0068BCAB0  adrp     x8, #0x8f27000
0068BCAB4  ldr      x8, [x8, #0x7b8]
0068BCAB8  ldr      x2, [x8]
0068BCABC  ldrb     w8, [x2, #0x53]
0068BCAC0  tbnz     w8, #5, #0x68bcad8
0068BCAC4  mov      x0, x19
0068BCAC8  str      x20, [x0, #0x78]!
0068BCACC  mov      x1, x20
0068BCAD0  bl       #0x382bcb8 ; 
0068BCAD4  b        #0x68bcae8 ; 
0068BCAD8  ldr      x8, [x2, #0x60]
0068BCADC  mov      x0, x19
0068BCAE0  mov      x1, x20
0068BCAE4  blr      x8
0068BCAE8  mov      x0, x19
0068BCAEC  mov      x1, xzr
0068BCAF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCAF4  adrp     x21, #0x959c000
0068BCAF8  ldrb     w8, [x21, #0x668]
0068BCAFC  mov      w20, w0
0068BCB00  cbnz     w8, #0x68bcb18
0068BCB04  adrp     x0, #0x8f27000
0068BCB08  ldr      x0, [x0, #0x7c8]
0068BCB0C  bl       #0x382bd14 ; 
0068BCB10  mov      w8, #1
0068BCB14  strb     w8, [x21, #0x668]
0068BCB18  adrp     x8, #0x8f27000
0068BCB1C  ldr      x8, [x8, #0x7c8]
0068BCB20  ldr      x2, [x8]
0068BCB24  ldrb     w8, [x2, #0x53]
0068BCB28  tbnz     w8, #5, #0x68bcb34
0068BCB2C  str      w20, [x19, #0x80]
0068BCB30  b        #0x68bcb44 ; 
0068BCB34  ldr      x8, [x2, #0x60]
0068BCB38  mov      x0, x19
0068BCB3C  mov      w1, w20
0068BCB40  blr      x8
0068BCB44  mov      x0, x19
0068BCB48  mov      x1, xzr
0068BCB4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCB50  adrp     x21, #0x959c000
0068BCB54  ldrb     w8, [x21, #0x669]
0068BCB58  mov      w20, w0
0068BCB5C  cbnz     w8, #0x68bcb74
0068BCB60  adrp     x0, #0x8f27000
0068BCB64  ldr      x0, [x0, #0x7d8]
0068BCB68  bl       #0x382bd14 ; 
0068BCB6C  mov      w8, #1
0068BCB70  strb     w8, [x21, #0x669]
0068BCB74  adrp     x8, #0x8f27000
0068BCB78  ldr      x8, [x8, #0x7d8]
0068BCB7C  ldr      x2, [x8]
0068BCB80  ldrb     w8, [x2, #0x53]
0068BCB84  tbnz     w8, #5, #0x68bcb90
0068BCB88  str      w20, [x19, #0x84]
0068BCB8C  b        #0x68bcba0 ; 
0068BCB90  ldr      x8, [x2, #0x60]
0068BCB94  mov      x0, x19
0068BCB98  mov      w1, w20
0068BCB9C  blr      x8
0068BCBA0  mov      x0, x19
0068BCBA4  mov      x1, xzr
0068BCBA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCBAC  adrp     x21, #0x959c000
0068BCBB0  ldrb     w8, [x21, #0x66a]
0068BCBB4  mov      w20, w0
0068BCBB8  cbnz     w8, #0x68bcbd0
0068BCBBC  adrp     x0, #0x8f27000
0068BCBC0  ldr      x0, [x0, #0x7e0]
0068BCBC4  bl       #0x382bd14 ; 
0068BCBC8  mov      w8, #1
0068BCBCC  strb     w8, [x21, #0x66a]
0068BCBD0  adrp     x8, #0x8f27000
0068BCBD4  ldr      x8, [x8, #0x7e0]
0068BCBD8  ldr      x2, [x8]
0068BCBDC  ldrb     w8, [x2, #0x53]
0068BCBE0  tbnz     w8, #5, #0x68bcbec
0068BCBE4  str      w20, [x19, #0x88]
0068BCBE8  b        #0x68bcbfc ; 
0068BCBEC  ldr      x8, [x2, #0x60]
0068BCBF0  mov      x0, x19
0068BCBF4  mov      w1, w20
0068BCBF8  blr      x8
0068BCBFC  mov      x0, x19
0068BCC00  mov      x1, xzr
0068BCC04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCC08  adrp     x21, #0x959c000
0068BCC0C  ldrb     w8, [x21, #0x66b]
0068BCC10  mov      w20, w0
0068BCC14  cbnz     w8, #0x68bcc2c
0068BCC18  adrp     x0, #0x8f27000
0068BCC1C  ldr      x0, [x0, #0x7e8]
0068BCC20  bl       #0x382bd14 ; 
0068BCC24  mov      w8, #1
0068BCC28  strb     w8, [x21, #0x66b]
0068BCC2C  adrp     x8, #0x8f27000
0068BCC30  ldr      x8, [x8, #0x7e8]
0068BCC34  ldr      x2, [x8]
0068BCC38  ldrb     w8, [x2, #0x53]
0068BCC3C  tbnz     w8, #5, #0x68bcc48
0068BCC40  str      w20, [x19, #0x8c]
0068BCC44  b        #0x68bcc58 ; 
0068BCC48  ldr      x8, [x2, #0x60]
0068BCC4C  mov      x0, x19
0068BCC50  mov      w1, w20
0068BCC54  blr      x8
0068BCC58  mov      x0, x19
0068BCC5C  mov      x1, xzr
0068BCC60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCC64  adrp     x21, #0x959c000
0068BCC68  ldrb     w8, [x21, #0x66c]
0068BCC6C  mov      w20, w0
0068BCC70  cbnz     w8, #0x68bcc88
0068BCC74  adrp     x0, #0x8f27000
0068BCC78  ldr      x0, [x0, #0x7f8]
0068BCC7C  bl       #0x382bd14 ; 
0068BCC80  mov      w8, #1
0068BCC84  strb     w8, [x21, #0x66c]
0068BCC88  adrp     x8, #0x8f27000
0068BCC8C  ldr      x8, [x8, #0x7f8]
0068BCC90  ldr      x2, [x8]
0068BCC94  ldrb     w8, [x2, #0x53]
0068BCC98  tbnz     w8, #5, #0x68bcca4
0068BCC9C  str      w20, [x19, #0x90]
0068BCCA0  b        #0x68bccb4 ; 
0068BCCA4  ldr      x8, [x2, #0x60]
0068BCCA8  mov      x0, x19
0068BCCAC  mov      w1, w20
0068BCCB0  blr      x8
0068BCCB4  mov      x0, x19
0068BCCB8  mov      x1, xzr
0068BCCBC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCCC0  adrp     x21, #0x959c000
0068BCCC4  ldrb     w8, [x21, #0x66d]
0068BCCC8  mov      w20, w0
0068BCCCC  cbnz     w8, #0x68bcce4
0068BCCD0  adrp     x0, #0x8f27000
0068BCCD4  ldr      x0, [x0, #0x808]
0068BCCD8  bl       #0x382bd14 ; 
0068BCCDC  mov      w8, #1
0068BCCE0  strb     w8, [x21, #0x66d]
0068BCCE4  adrp     x8, #0x8f27000
0068BCCE8  ldr      x8, [x8, #0x808]
0068BCCEC  ldr      x2, [x8]
0068BCCF0  ldrb     w8, [x2, #0x53]
0068BCCF4  tbnz     w8, #5, #0x68bcd00
0068BCCF8  str      w20, [x19, #0x94]
0068BCCFC  b        #0x68bcd10 ; 
0068BCD00  ldr      x8, [x2, #0x60]
0068BCD04  mov      x0, x19
0068BCD08  mov      w1, w20
0068BCD0C  blr      x8
0068BCD10  mov      x0, x19
0068BCD14  mov      x1, xzr
0068BCD18  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068BCD1C  adrp     x21, #0x959c000
0068BCD20  ldrb     w8, [x21, #0x66e]
0068BCD24  mov      x20, x0
0068BCD28  cbnz     w8, #0x68bcd40
0068BCD2C  adrp     x0, #0x8f27000
0068BCD30  ldr      x0, [x0, #0x818]
0068BCD34  bl       #0x382bd14 ; 
0068BCD38  mov      w8, #1
0068BCD3C  strb     w8, [x21, #0x66e]
0068BCD40  adrp     x8, #0x8f27000
0068BCD44  ldr      x8, [x8, #0x818]
0068BCD48  ldr      x2, [x8]
0068BCD4C  ldrb     w8, [x2, #0x53]
0068BCD50  tbnz     w8, #5, #0x68bcd68
0068BCD54  mov      x0, x19
0068BCD58  str      x20, [x0, #0x98]!
0068BCD5C  mov      x1, x20
0068BCD60  bl       #0x382bcb8 ; 
0068BCD64  b        #0x68bcd78 ; 
0068BCD68  ldr      x8, [x2, #0x60]
0068BCD6C  mov      x0, x19
0068BCD70  mov      x1, x20
0068BCD74  blr      x8
0068BCD78  mov      x0, x19
0068BCD7C  mov      x1, xzr
0068BCD80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCD84  adrp     x21, #0x959c000
0068BCD88  ldrb     w8, [x21, #0x66f]
0068BCD8C  mov      w20, w0
0068BCD90  cbnz     w8, #0x68bcda8
0068BCD94  adrp     x0, #0x8f27000
0068BCD98  ldr      x0, [x0, #0x828]
0068BCD9C  bl       #0x382bd14 ; 
0068BCDA0  mov      w8, #1
0068BCDA4  strb     w8, [x21, #0x66f]
0068BCDA8  adrp     x8, #0x8f27000
0068BCDAC  ldr      x8, [x8, #0x828]
0068BCDB0  ldr      x2, [x8]
0068BCDB4  ldrb     w8, [x2, #0x53]
0068BCDB8  tbnz     w8, #5, #0x68bcdc4
0068BCDBC  str      w20, [x19, #0xa0]
0068BCDC0  b        #0x68bcdd4 ; 
0068BCDC4  ldr      x8, [x2, #0x60]
0068BCDC8  mov      x0, x19
0068BCDCC  mov      w1, w20
0068BCDD0  blr      x8
0068BCDD4  mov      x0, x19
0068BCDD8  mov      x1, xzr
0068BCDDC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068BCDE0  adrp     x21, #0x959c000
0068BCDE4  ldrb     w8, [x21, #0x670]
0068BCDE8  mov      x20, x0
0068BCDEC  cbnz     w8, #0x68bce04
0068BCDF0  adrp     x0, #0x8f27000
0068BCDF4  ldr      x0, [x0, #0x830]
0068BCDF8  bl       #0x382bd14 ; 
0068BCDFC  mov      w8, #1
0068BCE00  strb     w8, [x21, #0x670]
0068BCE04  adrp     x8, #0x8f27000
0068BCE08  ldr      x8, [x8, #0x830]
0068BCE0C  ldr      x2, [x8]
0068BCE10  ldrb     w8, [x2, #0x53]
0068BCE14  tbnz     w8, #5, #0x68bce2c
0068BCE18  mov      x0, x19
0068BCE1C  str      x20, [x0, #0xa8]!
0068BCE20  mov      x1, x20
0068BCE24  bl       #0x382bcb8 ; 
0068BCE28  b        #0x68bce3c ; 
0068BCE2C  ldr      x8, [x2, #0x60]
0068BCE30  mov      x0, x19
0068BCE34  mov      x1, x20
0068BCE38  blr      x8
0068BCE3C  mov      x0, x19
0068BCE40  mov      x1, xzr
0068BCE44  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BCE48  adrp     x21, #0x959c000
0068BCE4C  ldrb     w8, [x21, #0x671]
0068BCE50  mov      x20, x0
0068BCE54  cbnz     w8, #0x68bce6c
0068BCE58  adrp     x0, #0x8f27000
0068BCE5C  ldr      x0, [x0, #0x838]
0068BCE60  bl       #0x382bd14 ; 
0068BCE64  mov      w8, #1
0068BCE68  strb     w8, [x21, #0x671]
0068BCE6C  adrp     x8, #0x8f27000
0068BCE70  ldr      x8, [x8, #0x838]
0068BCE74  ldr      x2, [x8]
0068BCE78  ldrb     w8, [x2, #0x53]
0068BCE7C  tbnz     w8, #5, #0x68bce94
0068BCE80  mov      x0, x19
0068BCE84  str      x20, [x0, #0xb0]!
0068BCE88  mov      x1, x20
0068BCE8C  bl       #0x382bcb8 ; 
0068BCE90  b        #0x68bcea4 ; 
0068BCE94  ldr      x8, [x2, #0x60]
0068BCE98  mov      x0, x19
0068BCE9C  mov      x1, x20
0068BCEA0  blr      x8
0068BCEA4  mov      x0, x19
0068BCEA8  mov      x1, xzr
0068BCEAC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BCEB0  adrp     x21, #0x959c000
0068BCEB4  ldrb     w8, [x21, #0x672]
0068BCEB8  mov      x20, x0
0068BCEBC  cbnz     w8, #0x68bced4
0068BCEC0  adrp     x0, #0x8f27000
0068BCEC4  ldr      x0, [x0, #0x840]
0068BCEC8  bl       #0x382bd14 ; 
0068BCECC  mov      w8, #1
0068BCED0  strb     w8, [x21, #0x672]
0068BCED4  adrp     x8, #0x8f27000
0068BCED8  ldr      x8, [x8, #0x840]
0068BCEDC  ldr      x2, [x8]
0068BCEE0  ldrb     w8, [x2, #0x53]
0068BCEE4  tbnz     w8, #5, #0x68bcefc
0068BCEE8  mov      x0, x19
0068BCEEC  str      x20, [x0, #0xb8]!
0068BCEF0  mov      x1, x20
0068BCEF4  bl       #0x382bcb8 ; 
0068BCEF8  b        #0x68bcf0c ; 
0068BCEFC  ldr      x8, [x2, #0x60]
0068BCF00  mov      x0, x19
0068BCF04  mov      x1, x20
0068BCF08  blr      x8
0068BCF0C  mov      x0, x19
0068BCF10  mov      x1, xzr
0068BCF14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCF18  adrp     x21, #0x959c000
0068BCF1C  ldrb     w8, [x21, #0x673]
0068BCF20  mov      w20, w0
0068BCF24  cbnz     w8, #0x68bcf3c
0068BCF28  adrp     x0, #0x8f27000
0068BCF2C  ldr      x0, [x0, #0x850]
0068BCF30  bl       #0x382bd14 ; 
0068BCF34  mov      w8, #1
0068BCF38  strb     w8, [x21, #0x673]
0068BCF3C  adrp     x8, #0x8f27000
0068BCF40  ldr      x8, [x8, #0x850]
0068BCF44  ldr      x2, [x8]
0068BCF48  ldrb     w8, [x2, #0x53]
0068BCF4C  tbnz     w8, #5, #0x68bcf58
0068BCF50  str      w20, [x19, #0xc0]
0068BCF54  b        #0x68bcf68 ; 
0068BCF58  ldr      x8, [x2, #0x60]
0068BCF5C  mov      x0, x19
0068BCF60  mov      w1, w20
0068BCF64  blr      x8
0068BCF68  mov      x0, x19
0068BCF6C  mov      x1, xzr
0068BCF70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BCF74  adrp     x21, #0x959c000
0068BCF78  ldrb     w8, [x21, #0x674]
0068BCF7C  mov      w20, w0
0068BCF80  cbnz     w8, #0x68bcf98
0068BCF84  adrp     x0, #0x8f27000
0068BCF88  ldr      x0, [x0, #0x860]
0068BCF8C  bl       #0x382bd14 ; 
0068BCF90  mov      w8, #1
0068BCF94  strb     w8, [x21, #0x674]
0068BCF98  adrp     x8, #0x8f27000
0068BCF9C  ldr      x8, [x8, #0x860]
0068BCFA0  ldr      x2, [x8]
0068BCFA4  ldrb     w8, [x2, #0x53]
0068BCFA8  tbnz     w8, #5, #0x68bcfb4
0068BCFAC  str      w20, [x19, #0xc4]
0068BCFB0  b        #0x68bcfc4 ; 
0068BCFB4  ldr      x8, [x2, #0x60]
0068BCFB8  mov      x0, x19
0068BCFBC  mov      w1, w20
0068BCFC0  blr      x8
0068BCFC4  mov      x0, x19
0068BCFC8  mov      x1, xzr
0068BCFCC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068BCFD0  adrp     x21, #0x959c000
0068BCFD4  ldrb     w8, [x21, #0x675]
0068BCFD8  mov      x20, x0
0068BCFDC  cbnz     w8, #0x68bcff4
0068BCFE0  adrp     x0, #0x8f27000
0068BCFE4  ldr      x0, [x0, #0x870]
0068BCFE8  bl       #0x382bd14 ; 
0068BCFEC  mov      w8, #1
0068BCFF0  strb     w8, [x21, #0x675]
0068BCFF4  adrp     x8, #0x8f27000
0068BCFF8  ldr      x8, [x8, #0x870]
0068BCFFC  ldr      x2, [x8]
0068BD000  ldrb     w8, [x2, #0x53]
0068BD004  tbnz     w8, #5, #0x68bd01c
0068BD008  mov      x0, x19
0068BD00C  str      x20, [x0, #0xc8]!
0068BD010  mov      x1, x20
0068BD014  bl       #0x382bcb8 ; 
0068BD018  b        #0x68bd02c ; 
0068BD01C  ldr      x8, [x2, #0x60]
0068BD020  mov      x0, x19
0068BD024  mov      x1, x20
0068BD028  blr      x8
0068BD02C  mov      x0, x19
0068BD030  mov      x1, xzr
0068BD034  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BD038  adrp     x21, #0x959c000
0068BD03C  ldrb     w8, [x21, #0x676]
0068BD040  mov      x20, x0
0068BD044  cbnz     w8, #0x68bd05c
0068BD048  adrp     x0, #0x8f27000
0068BD04C  ldr      x0, [x0, #0x880]
0068BD050  bl       #0x382bd14 ; 
0068BD054  mov      w8, #1
0068BD058  strb     w8, [x21, #0x676]
0068BD05C  adrp     x8, #0x8f27000
0068BD060  ldr      x8, [x8, #0x880]
0068BD064  ldr      x2, [x8]
0068BD068  ldrb     w8, [x2, #0x53]
0068BD06C  tbnz     w8, #5, #0x68bd084
0068BD070  mov      x0, x19
0068BD074  str      x20, [x0, #0xd0]!
0068BD078  mov      x1, x20
0068BD07C  bl       #0x382bcb8 ; 
0068BD080  b        #0x68bd094 ; 
0068BD084  ldr      x8, [x2, #0x60]
0068BD088  mov      x0, x19
0068BD08C  mov      x1, x20
0068BD090  blr      x8
0068BD094  mov      x0, x19
0068BD098  mov      x1, xzr
0068BD09C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BD0A0  adrp     x21, #0x959c000
0068BD0A4  ldrb     w8, [x21, #0x677]
0068BD0A8  mov      x20, x0
0068BD0AC  cbnz     w8, #0x68bd0c4
0068BD0B0  adrp     x0, #0x8f27000
0068BD0B4  ldr      x0, [x0, #0x890]
0068BD0B8  bl       #0x382bd14 ; 
0068BD0BC  mov      w8, #1
0068BD0C0  strb     w8, [x21, #0x677]
0068BD0C4  adrp     x8, #0x8f27000
0068BD0C8  ldr      x8, [x8, #0x890]
0068BD0CC  ldr      x2, [x8]
0068BD0D0  ldrb     w8, [x2, #0x53]
0068BD0D4  tbnz     w8, #5, #0x68bd0ec
0068BD0D8  mov      x0, x19
0068BD0DC  str      x20, [x0, #0xd8]!
0068BD0E0  mov      x1, x20
0068BD0E4  bl       #0x382bcb8 ; 
0068BD0E8  b        #0x68bd0fc ; 
0068BD0EC  ldr      x8, [x2, #0x60]
0068BD0F0  mov      x0, x19
0068BD0F4  mov      x1, x20
0068BD0F8  blr      x8
0068BD0FC  mov      x0, x19
0068BD100  mov      x1, xzr
0068BD104  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BD108  adrp     x21, #0x959c000
0068BD10C  ldrb     w8, [x21, #0x678]
0068BD110  mov      x20, x0
0068BD114  cbnz     w8, #0x68bd12c
0068BD118  adrp     x0, #0x8f27000
0068BD11C  ldr      x0, [x0, #0x8a0]
0068BD120  bl       #0x382bd14 ; 
0068BD124  mov      w8, #1
0068BD128  strb     w8, [x21, #0x678]
0068BD12C  adrp     x8, #0x8f27000
0068BD130  ldr      x8, [x8, #0x8a0]
0068BD134  ldr      x2, [x8]
0068BD138  ldrb     w8, [x2, #0x53]
0068BD13C  tbnz     w8, #5, #0x68bd154
0068BD140  mov      x0, x19
0068BD144  str      x20, [x0, #0xe0]!
0068BD148  mov      x1, x20
0068BD14C  bl       #0x382bcb8 ; 
0068BD150  b        #0x68bd164 ; 
0068BD154  ldr      x8, [x2, #0x60]
0068BD158  mov      x0, x19
0068BD15C  mov      x1, x20
0068BD160  blr      x8
0068BD164  mov      x0, x19
0068BD168  mov      x1, xzr
0068BD16C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BD170  adrp     x21, #0x959c000
0068BD174  ldrb     w8, [x21, #0x679]
0068BD178  mov      x20, x0
0068BD17C  cbnz     w8, #0x68bd194
0068BD180  adrp     x0, #0x8f27000
0068BD184  ldr      x0, [x0, #0x8b0]
0068BD188  bl       #0x382bd14 ; 
0068BD18C  mov      w8, #1
0068BD190  strb     w8, [x21, #0x679]
0068BD194  adrp     x8, #0x8f27000
0068BD198  ldr      x8, [x8, #0x8b0]
0068BD19C  ldr      x2, [x8]
0068BD1A0  ldrb     w8, [x2, #0x53]
0068BD1A4  tbnz     w8, #5, #0x68bd1bc
0068BD1A8  mov      x0, x19
0068BD1AC  str      x20, [x0, #0xe8]!
0068BD1B0  mov      x1, x20
0068BD1B4  bl       #0x382bcb8 ; 
0068BD1B8  b        #0x68bd1cc ; 
0068BD1BC  ldr      x8, [x2, #0x60]
0068BD1C0  mov      x0, x19
0068BD1C4  mov      x1, x20
0068BD1C8  blr      x8
0068BD1CC  mov      x0, x19
0068BD1D0  mov      x1, xzr
0068BD1D4  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068BD1D8  adrp     x20, #0x959c000
0068BD1DC  ldrb     w8, [x20, #0x67a]
0068BD1E0  mov      v8.16b, v0.16b
0068BD1E4  cbnz     w8, #0x68bd1fc
0068BD1E8  adrp     x0, #0x8f27000
0068BD1EC  ldr      x0, [x0, #0x8c0]
0068BD1F0  bl       #0x382bd14 ; 
0068BD1F4  mov      w8, #1
0068BD1F8  strb     w8, [x20, #0x67a]
0068BD1FC  adrp     x8, #0x8f27000
0068BD200  ldr      x8, [x8, #0x8c0]
0068BD204  ldr      x1, [x8]
0068BD208  ldrb     w8, [x1, #0x53]
0068BD20C  tbnz     w8, #5, #0x68bd218
0068BD210  str      s8, [x19, #0xf0]
0068BD214  b        #0x68bd228 ; 
0068BD218  ldr      x8, [x1, #0x60]
0068BD21C  mov      x0, x19
0068BD220  mov      v0.16b, v8.16b
0068BD224  blr      x8
0068BD228  mov      x0, x19
0068BD22C  mov      x1, xzr
0068BD230  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068BD234  adrp     x20, #0x959c000
0068BD238  ldrb     w8, [x20, #0x67b]
0068BD23C  mov      v8.16b, v0.16b
0068BD240  cbnz     w8, #0x68bd258
0068BD244  adrp     x0, #0x8f27000
0068BD248  ldr      x0, [x0, #0x8d0]
0068BD24C  bl       #0x382bd14 ; 
0068BD250  mov      w8, #1
0068BD254  strb     w8, [x20, #0x67b]
0068BD258  adrp     x8, #0x8f27000
0068BD25C  ldr      x8, [x8, #0x8d0]
0068BD260  ldr      x1, [x8]
0068BD264  ldrb     w8, [x1, #0x53]
0068BD268  tbnz     w8, #5, #0x68bd274
0068BD26C  str      s8, [x19, #0xf4]
0068BD270  b        #0x68bd284 ; 
0068BD274  ldr      x8, [x1, #0x60]
0068BD278  mov      x0, x19
0068BD27C  mov      v0.16b, v8.16b
0068BD280  blr      x8
0068BD284  mov      x0, x19
0068BD288  mov      x1, xzr
0068BD28C  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068BD290  adrp     x20, #0x959c000
0068BD294  ldrb     w8, [x20, #0x67c]
0068BD298  mov      v8.16b, v0.16b
0068BD29C  cbnz     w8, #0x68bd2b4
0068BD2A0  adrp     x0, #0x8f27000
0068BD2A4  ldr      x0, [x0, #0x8e0]
0068BD2A8  bl       #0x382bd14 ; 
0068BD2AC  mov      w8, #1
0068BD2B0  strb     w8, [x20, #0x67c]
0068BD2B4  adrp     x8, #0x8f27000
0068BD2B8  ldr      x8, [x8, #0x8e0]
0068BD2BC  ldr      x1, [x8]
0068BD2C0  ldrb     w8, [x1, #0x53]
0068BD2C4  tbnz     w8, #5, #0x68bd2d0
0068BD2C8  str      s8, [x19, #0xf8]
0068BD2CC  b        #0x68bd2e0 ; 
0068BD2D0  ldr      x8, [x1, #0x60]
0068BD2D4  mov      x0, x19
0068BD2D8  mov      v0.16b, v8.16b
0068BD2DC  blr      x8
0068BD2E0  mov      x0, x19
0068BD2E4  mov      x1, xzr
0068BD2E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BD2EC  adrp     x21, #0x959c000
0068BD2F0  ldrb     w8, [x21, #0x67d]
0068BD2F4  mov      w20, w0
0068BD2F8  cbnz     w8, #0x68bd310
0068BD2FC  adrp     x0, #0x8f27000
0068BD300  ldr      x0, [x0, #0x8f0]
0068BD304  bl       #0x382bd14 ; 
0068BD308  mov      w8, #1
0068BD30C  strb     w8, [x21, #0x67d]
0068BD310  adrp     x8, #0x8f27000
0068BD314  ldr      x8, [x8, #0x8f0]
0068BD318  ldr      x2, [x8]
0068BD31C  ldrb     w8, [x2, #0x53]
0068BD320  tbnz     w8, #5, #0x68bd32c
0068BD324  str      w20, [x19, #0xfc]
0068BD328  b        #0x68bd33c ; 
0068BD32C  ldr      x8, [x2, #0x60]
0068BD330  mov      x0, x19
0068BD334  mov      w1, w20
0068BD338  blr      x8
0068BD33C  ldp      x20, x19, [sp, #0x20]
0068BD340  ldp      x30, x21, [sp, #0x10]
0068BD344  mov      w0, #1
0068BD348  ldr      d8, [sp], #0x30
0068BD34C  ret      

