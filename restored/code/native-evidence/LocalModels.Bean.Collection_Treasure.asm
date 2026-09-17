; LocalModels.Bean.Collection_Treasure$$readImpl
; RVA 0x68CC574; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CC574  stp      x30, x21, [sp, #-0x20]!
0068CC578  stp      x20, x19, [sp, #0x10]
0068CC57C  adrp     x20, #0x959c000
0068CC580  adrp     x21, #0x8f28000
0068CC584  ldrb     w8, [x20, #0x349]
0068CC588  ldr      x21, [x21, #0x3d8]
0068CC58C  mov      x19, x0
0068CC590  tbnz     w8, #0, #0x68cc5a8
0068CC594  adrp     x0, #0x8f28000
0068CC598  ldr      x0, [x0, #0x3d8]
0068CC59C  bl       #0x382bd14 ; 
0068CC5A0  mov      w8, #1
0068CC5A4  strb     w8, [x20, #0x349]
0068CC5A8  ldr      x1, [x21]
0068CC5AC  ldrb     w8, [x1, #0x53]
0068CC5B0  tbnz     w8, #5, #0x68cc600
0068CC5B4  mov      x0, x19
0068CC5B8  mov      x1, xzr
0068CC5BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC5C0  adrp     x21, #0x959c000
0068CC5C4  ldrb     w8, [x21, #0x721]
0068CC5C8  mov      w20, w0
0068CC5CC  cbnz     w8, #0x68cc5e4
0068CC5D0  adrp     x0, #0x8f28000
0068CC5D4  ldr      x0, [x0, #0x2f0]
0068CC5D8  bl       #0x382bd14 ; 
0068CC5DC  mov      w8, #1
0068CC5E0  strb     w8, [x21, #0x721]
0068CC5E4  adrp     x8, #0x8f28000
0068CC5E8  ldr      x8, [x8, #0x2f0]
0068CC5EC  ldr      x2, [x8]
0068CC5F0  ldrb     w8, [x2, #0x53]
0068CC5F4  tbnz     w8, #5, #0x68cc614
0068CC5F8  str      w20, [x19, #0x20]
0068CC5FC  b        #0x68cc624 ; 
0068CC600  ldr      x2, [x1, #0x60]
0068CC604  mov      x0, x19
0068CC608  ldp      x20, x19, [sp, #0x10]
0068CC60C  ldp      x30, x21, [sp], #0x20
0068CC610  br       x2
0068CC614  ldr      x8, [x2, #0x60]
0068CC618  mov      x0, x19
0068CC61C  mov      w1, w20
0068CC620  blr      x8
0068CC624  mov      x0, x19
0068CC628  mov      x1, xzr
0068CC62C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC630  adrp     x21, #0x959c000
0068CC634  ldrb     w8, [x21, #0x722]
0068CC638  mov      w20, w0
0068CC63C  cbnz     w8, #0x68cc654
0068CC640  adrp     x0, #0x8f28000
0068CC644  ldr      x0, [x0, #0x300]
0068CC648  bl       #0x382bd14 ; 
0068CC64C  mov      w8, #1
0068CC650  strb     w8, [x21, #0x722]
0068CC654  adrp     x8, #0x8f28000
0068CC658  ldr      x8, [x8, #0x300]
0068CC65C  ldr      x2, [x8]
0068CC660  ldrb     w8, [x2, #0x53]
0068CC664  tbnz     w8, #5, #0x68cc670
0068CC668  str      w20, [x19, #0x24]
0068CC66C  b        #0x68cc680 ; 
0068CC670  ldr      x8, [x2, #0x60]
0068CC674  mov      x0, x19
0068CC678  mov      w1, w20
0068CC67C  blr      x8
0068CC680  mov      x0, x19
0068CC684  mov      x1, xzr
0068CC688  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC68C  adrp     x21, #0x959c000
0068CC690  ldrb     w8, [x21, #0x723]
0068CC694  mov      w20, w0
0068CC698  cbnz     w8, #0x68cc6b0
0068CC69C  adrp     x0, #0x8f28000
0068CC6A0  ldr      x0, [x0, #0x310]
0068CC6A4  bl       #0x382bd14 ; 
0068CC6A8  mov      w8, #1
0068CC6AC  strb     w8, [x21, #0x723]
0068CC6B0  adrp     x8, #0x8f28000
0068CC6B4  ldr      x8, [x8, #0x310]
0068CC6B8  ldr      x2, [x8]
0068CC6BC  ldrb     w8, [x2, #0x53]
0068CC6C0  tbnz     w8, #5, #0x68cc6cc
0068CC6C4  str      w20, [x19, #0x28]
0068CC6C8  b        #0x68cc6dc ; 
0068CC6CC  ldr      x8, [x2, #0x60]
0068CC6D0  mov      x0, x19
0068CC6D4  mov      w1, w20
0068CC6D8  blr      x8
0068CC6DC  mov      x0, x19
0068CC6E0  mov      x1, xzr
0068CC6E4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CC6E8  adrp     x21, #0x959c000
0068CC6EC  ldrb     w8, [x21, #0x724]
0068CC6F0  mov      x20, x0
0068CC6F4  cbnz     w8, #0x68cc70c
0068CC6F8  adrp     x0, #0x8f28000
0068CC6FC  ldr      x0, [x0, #0x320]
0068CC700  bl       #0x382bd14 ; 
0068CC704  mov      w8, #1
0068CC708  strb     w8, [x21, #0x724]
0068CC70C  adrp     x8, #0x8f28000
0068CC710  ldr      x8, [x8, #0x320]
0068CC714  ldr      x2, [x8]
0068CC718  ldrb     w8, [x2, #0x53]
0068CC71C  tbnz     w8, #5, #0x68cc734
0068CC720  mov      x0, x19
0068CC724  str      x20, [x0, #0x30]!
0068CC728  mov      x1, x20
0068CC72C  bl       #0x382bcb8 ; 
0068CC730  b        #0x68cc744 ; 
0068CC734  ldr      x8, [x2, #0x60]
0068CC738  mov      x0, x19
0068CC73C  mov      x1, x20
0068CC740  blr      x8
0068CC744  mov      x0, x19
0068CC748  mov      x1, xzr
0068CC74C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC750  adrp     x21, #0x959c000
0068CC754  ldrb     w8, [x21, #0x725]
0068CC758  mov      w20, w0
0068CC75C  cbnz     w8, #0x68cc774
0068CC760  adrp     x0, #0x8f28000
0068CC764  ldr      x0, [x0, #0x330]
0068CC768  bl       #0x382bd14 ; 
0068CC76C  mov      w8, #1
0068CC770  strb     w8, [x21, #0x725]
0068CC774  adrp     x8, #0x8f28000
0068CC778  ldr      x8, [x8, #0x330]
0068CC77C  ldr      x2, [x8]
0068CC780  ldrb     w8, [x2, #0x53]
0068CC784  tbnz     w8, #5, #0x68cc790
0068CC788  str      w20, [x19, #0x38]
0068CC78C  b        #0x68cc7a0 ; 
0068CC790  ldr      x8, [x2, #0x60]
0068CC794  mov      x0, x19
0068CC798  mov      w1, w20
0068CC79C  blr      x8
0068CC7A0  mov      x0, x19
0068CC7A4  mov      x1, xzr
0068CC7A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC7AC  adrp     x21, #0x959c000
0068CC7B0  ldrb     w8, [x21, #0x726]
0068CC7B4  mov      w20, w0
0068CC7B8  cbnz     w8, #0x68cc7d0
0068CC7BC  adrp     x0, #0x8f28000
0068CC7C0  ldr      x0, [x0, #0x340]
0068CC7C4  bl       #0x382bd14 ; 
0068CC7C8  mov      w8, #1
0068CC7CC  strb     w8, [x21, #0x726]
0068CC7D0  adrp     x8, #0x8f28000
0068CC7D4  ldr      x8, [x8, #0x340]
0068CC7D8  ldr      x2, [x8]
0068CC7DC  ldrb     w8, [x2, #0x53]
0068CC7E0  tbnz     w8, #5, #0x68cc7ec
0068CC7E4  str      w20, [x19, #0x3c]
0068CC7E8  b        #0x68cc7fc ; 
0068CC7EC  ldr      x8, [x2, #0x60]
0068CC7F0  mov      x0, x19
0068CC7F4  mov      w1, w20
0068CC7F8  blr      x8
0068CC7FC  mov      x0, x19
0068CC800  mov      x1, xzr
0068CC804  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC808  adrp     x21, #0x959c000
0068CC80C  ldrb     w8, [x21, #0x727]
0068CC810  mov      w20, w0
0068CC814  cbnz     w8, #0x68cc82c
0068CC818  adrp     x0, #0x8f28000
0068CC81C  ldr      x0, [x0, #0x350]
0068CC820  bl       #0x382bd14 ; 
0068CC824  mov      w8, #1
0068CC828  strb     w8, [x21, #0x727]
0068CC82C  adrp     x8, #0x8f28000
0068CC830  ldr      x8, [x8, #0x350]
0068CC834  ldr      x2, [x8]
0068CC838  ldrb     w8, [x2, #0x53]
0068CC83C  tbnz     w8, #5, #0x68cc848
0068CC840  str      w20, [x19, #0x40]
0068CC844  b        #0x68cc858 ; 
0068CC848  ldr      x8, [x2, #0x60]
0068CC84C  mov      x0, x19
0068CC850  mov      w1, w20
0068CC854  blr      x8
0068CC858  mov      x0, x19
0068CC85C  mov      x1, xzr
0068CC860  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC864  adrp     x21, #0x959c000
0068CC868  ldrb     w8, [x21, #0x728]
0068CC86C  mov      w20, w0
0068CC870  cbnz     w8, #0x68cc888
0068CC874  adrp     x0, #0x8f28000
0068CC878  ldr      x0, [x0, #0x360]
0068CC87C  bl       #0x382bd14 ; 
0068CC880  mov      w8, #1
0068CC884  strb     w8, [x21, #0x728]
0068CC888  adrp     x8, #0x8f28000
0068CC88C  ldr      x8, [x8, #0x360]
0068CC890  ldr      x2, [x8]
0068CC894  ldrb     w8, [x2, #0x53]
0068CC898  tbnz     w8, #5, #0x68cc8a4
0068CC89C  str      w20, [x19, #0x44]
0068CC8A0  b        #0x68cc8b4 ; 
0068CC8A4  ldr      x8, [x2, #0x60]
0068CC8A8  mov      x0, x19
0068CC8AC  mov      w1, w20
0068CC8B0  blr      x8
0068CC8B4  mov      x0, x19
0068CC8B8  mov      x1, xzr
0068CC8BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC8C0  adrp     x21, #0x959c000
0068CC8C4  ldrb     w8, [x21, #0x729]
0068CC8C8  mov      w20, w0
0068CC8CC  cbnz     w8, #0x68cc8e4
0068CC8D0  adrp     x0, #0x8f28000
0068CC8D4  ldr      x0, [x0, #0x370]
0068CC8D8  bl       #0x382bd14 ; 
0068CC8DC  mov      w8, #1
0068CC8E0  strb     w8, [x21, #0x729]
0068CC8E4  adrp     x8, #0x8f28000
0068CC8E8  ldr      x8, [x8, #0x370]
0068CC8EC  ldr      x2, [x8]
0068CC8F0  ldrb     w8, [x2, #0x53]
0068CC8F4  tbnz     w8, #5, #0x68cc900
0068CC8F8  str      w20, [x19, #0x48]
0068CC8FC  b        #0x68cc910 ; 
0068CC900  ldr      x8, [x2, #0x60]
0068CC904  mov      x0, x19
0068CC908  mov      w1, w20
0068CC90C  blr      x8
0068CC910  mov      x0, x19
0068CC914  mov      x1, xzr
0068CC918  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC91C  adrp     x21, #0x959c000
0068CC920  ldrb     w8, [x21, #0x72a]
0068CC924  mov      w20, w0
0068CC928  cbnz     w8, #0x68cc940
0068CC92C  adrp     x0, #0x8f28000
0068CC930  ldr      x0, [x0, #0x380]
0068CC934  bl       #0x382bd14 ; 
0068CC938  mov      w8, #1
0068CC93C  strb     w8, [x21, #0x72a]
0068CC940  adrp     x8, #0x8f28000
0068CC944  ldr      x8, [x8, #0x380]
0068CC948  ldr      x2, [x8]
0068CC94C  ldrb     w8, [x2, #0x53]
0068CC950  tbnz     w8, #5, #0x68cc95c
0068CC954  str      w20, [x19, #0x4c]
0068CC958  b        #0x68cc96c ; 
0068CC95C  ldr      x8, [x2, #0x60]
0068CC960  mov      x0, x19
0068CC964  mov      w1, w20
0068CC968  blr      x8
0068CC96C  mov      x0, x19
0068CC970  mov      x1, xzr
0068CC974  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC978  adrp     x21, #0x959c000
0068CC97C  ldrb     w8, [x21, #0x72b]
0068CC980  mov      w20, w0
0068CC984  cbnz     w8, #0x68cc99c
0068CC988  adrp     x0, #0x8f28000
0068CC98C  ldr      x0, [x0, #0x390]
0068CC990  bl       #0x382bd14 ; 
0068CC994  mov      w8, #1
0068CC998  strb     w8, [x21, #0x72b]
0068CC99C  adrp     x8, #0x8f28000
0068CC9A0  ldr      x8, [x8, #0x390]
0068CC9A4  ldr      x2, [x8]
0068CC9A8  ldrb     w8, [x2, #0x53]
0068CC9AC  tbnz     w8, #5, #0x68cc9b8
0068CC9B0  str      w20, [x19, #0x50]
0068CC9B4  b        #0x68cc9c8 ; 
0068CC9B8  ldr      x8, [x2, #0x60]
0068CC9BC  mov      x0, x19
0068CC9C0  mov      w1, w20
0068CC9C4  blr      x8
0068CC9C8  mov      x0, x19
0068CC9CC  mov      x1, xzr
0068CC9D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CC9D4  adrp     x21, #0x959c000
0068CC9D8  ldrb     w8, [x21, #0x72c]
0068CC9DC  mov      w20, w0
0068CC9E0  cbnz     w8, #0x68cc9f8
0068CC9E4  adrp     x0, #0x8f28000
0068CC9E8  ldr      x0, [x0, #0x3a0]
0068CC9EC  bl       #0x382bd14 ; 
0068CC9F0  mov      w8, #1
0068CC9F4  strb     w8, [x21, #0x72c]
0068CC9F8  adrp     x8, #0x8f28000
0068CC9FC  ldr      x8, [x8, #0x3a0]
0068CCA00  ldr      x2, [x8]
0068CCA04  ldrb     w8, [x2, #0x53]
0068CCA08  tbnz     w8, #5, #0x68cca14
0068CCA0C  str      w20, [x19, #0x54]
0068CCA10  b        #0x68cca24 ; 
0068CCA14  ldr      x8, [x2, #0x60]
0068CCA18  mov      x0, x19
0068CCA1C  mov      w1, w20
0068CCA20  blr      x8
0068CCA24  mov      x0, x19
0068CCA28  mov      x1, xzr
0068CCA2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CCA30  adrp     x21, #0x959c000
0068CCA34  ldrb     w8, [x21, #0x72d]
0068CCA38  mov      w20, w0
0068CCA3C  cbnz     w8, #0x68cca54
0068CCA40  adrp     x0, #0x8f28000
0068CCA44  ldr      x0, [x0, #0x3b0]
0068CCA48  bl       #0x382bd14 ; 
0068CCA4C  mov      w8, #1
0068CCA50  strb     w8, [x21, #0x72d]
0068CCA54  adrp     x8, #0x8f28000
0068CCA58  ldr      x8, [x8, #0x3b0]
0068CCA5C  ldr      x2, [x8]
0068CCA60  ldrb     w8, [x2, #0x53]
0068CCA64  tbnz     w8, #5, #0x68cca70
0068CCA68  str      w20, [x19, #0x58]
0068CCA6C  b        #0x68cca80 ; 
0068CCA70  ldr      x8, [x2, #0x60]
0068CCA74  mov      x0, x19
0068CCA78  mov      w1, w20
0068CCA7C  blr      x8
0068CCA80  mov      x0, x19
0068CCA84  mov      x1, xzr
0068CCA88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CCA8C  adrp     x21, #0x959c000
0068CCA90  ldrb     w8, [x21, #0x72e]
0068CCA94  mov      w20, w0
0068CCA98  cbnz     w8, #0x68ccab0
0068CCA9C  adrp     x0, #0x8f28000
0068CCAA0  ldr      x0, [x0, #0x3c0]
0068CCAA4  bl       #0x382bd14 ; 
0068CCAA8  mov      w8, #1
0068CCAAC  strb     w8, [x21, #0x72e]
0068CCAB0  adrp     x8, #0x8f28000
0068CCAB4  ldr      x8, [x8, #0x3c0]
0068CCAB8  ldr      x2, [x8]
0068CCABC  ldrb     w8, [x2, #0x53]
0068CCAC0  tbnz     w8, #5, #0x68ccacc
0068CCAC4  str      w20, [x19, #0x5c]
0068CCAC8  b        #0x68ccadc ; 
0068CCACC  ldr      x8, [x2, #0x60]
0068CCAD0  mov      x0, x19
0068CCAD4  mov      w1, w20
0068CCAD8  blr      x8
0068CCADC  mov      x0, x19
0068CCAE0  mov      x1, xzr
0068CCAE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CCAE8  adrp     x21, #0x959c000
0068CCAEC  ldrb     w8, [x21, #0x72f]
0068CCAF0  mov      w20, w0
0068CCAF4  cbnz     w8, #0x68ccb0c
0068CCAF8  adrp     x0, #0x8f28000
0068CCAFC  ldr      x0, [x0, #0x3d0]
0068CCB00  bl       #0x382bd14 ; 
0068CCB04  mov      w8, #1
0068CCB08  strb     w8, [x21, #0x72f]
0068CCB0C  adrp     x8, #0x8f28000
0068CCB10  ldr      x8, [x8, #0x3d0]
0068CCB14  ldr      x2, [x8]
0068CCB18  ldrb     w8, [x2, #0x53]
0068CCB1C  tbnz     w8, #5, #0x68ccb28
0068CCB20  str      w20, [x19, #0x60]
0068CCB24  b        #0x68ccb38 ; 
0068CCB28  ldr      x8, [x2, #0x60]
0068CCB2C  mov      x0, x19
0068CCB30  mov      w1, w20
0068CCB34  blr      x8
0068CCB38  ldp      x20, x19, [sp, #0x10]
0068CCB3C  mov      w0, #1
0068CCB40  ldp      x30, x21, [sp], #0x20
0068CCB44  ret      

