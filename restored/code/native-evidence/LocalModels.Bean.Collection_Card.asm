; LocalModels.Bean.Collection_Card$$readImpl
; RVA 0x68CA820; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CA820  stp      x30, x21, [sp, #-0x20]!
0068CA824  stp      x20, x19, [sp, #0x10]
0068CA828  adrp     x20, #0x959c000
0068CA82C  adrp     x21, #0x8f28000
0068CA830  ldrb     w8, [x20, #0x312]
0068CA834  ldr      x21, [x21, #0x238]
0068CA838  mov      x19, x0
0068CA83C  tbnz     w8, #0, #0x68ca854
0068CA840  adrp     x0, #0x8f28000
0068CA844  ldr      x0, [x0, #0x238]
0068CA848  bl       #0x382bd14 ; 
0068CA84C  mov      w8, #1
0068CA850  strb     w8, [x20, #0x312]
0068CA854  ldr      x1, [x21]
0068CA858  ldrb     w8, [x1, #0x53]
0068CA85C  tbnz     w8, #5, #0x68ca8ac
0068CA860  mov      x0, x19
0068CA864  mov      x1, xzr
0068CA868  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CA86C  adrp     x21, #0x959c000
0068CA870  ldrb     w8, [x21, #0x714]
0068CA874  mov      w20, w0
0068CA878  cbnz     w8, #0x68ca890
0068CA87C  adrp     x0, #0x8f28000
0068CA880  ldr      x0, [x0, #0x1f0]
0068CA884  bl       #0x382bd14 ; 
0068CA888  mov      w8, #1
0068CA88C  strb     w8, [x21, #0x714]
0068CA890  adrp     x8, #0x8f28000
0068CA894  ldr      x8, [x8, #0x1f0]
0068CA898  ldr      x2, [x8]
0068CA89C  ldrb     w8, [x2, #0x53]
0068CA8A0  tbnz     w8, #5, #0x68ca8c0
0068CA8A4  str      w20, [x19, #0x20]
0068CA8A8  b        #0x68ca8d0 ; 
0068CA8AC  ldr      x2, [x1, #0x60]
0068CA8B0  mov      x0, x19
0068CA8B4  ldp      x20, x19, [sp, #0x10]
0068CA8B8  ldp      x30, x21, [sp], #0x20
0068CA8BC  br       x2
0068CA8C0  ldr      x8, [x2, #0x60]
0068CA8C4  mov      x0, x19
0068CA8C8  mov      w1, w20
0068CA8CC  blr      x8
0068CA8D0  mov      x0, x19
0068CA8D4  mov      x1, xzr
0068CA8D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CA8DC  adrp     x21, #0x959c000
0068CA8E0  ldrb     w8, [x21, #0x715]
0068CA8E4  mov      w20, w0
0068CA8E8  cbnz     w8, #0x68ca900
0068CA8EC  adrp     x0, #0x8f28000
0068CA8F0  ldr      x0, [x0, #0x200]
0068CA8F4  bl       #0x382bd14 ; 
0068CA8F8  mov      w8, #1
0068CA8FC  strb     w8, [x21, #0x715]
0068CA900  adrp     x8, #0x8f28000
0068CA904  ldr      x8, [x8, #0x200]
0068CA908  ldr      x2, [x8]
0068CA90C  ldrb     w8, [x2, #0x53]
0068CA910  tbnz     w8, #5, #0x68ca91c
0068CA914  str      w20, [x19, #0x24]
0068CA918  b        #0x68ca92c ; 
0068CA91C  ldr      x8, [x2, #0x60]
0068CA920  mov      x0, x19
0068CA924  mov      w1, w20
0068CA928  blr      x8
0068CA92C  mov      x0, x19
0068CA930  mov      x1, xzr
0068CA934  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CA938  adrp     x21, #0x959c000
0068CA93C  ldrb     w8, [x21, #0x716]
0068CA940  mov      x20, x0
0068CA944  cbnz     w8, #0x68ca95c
0068CA948  adrp     x0, #0x8f28000
0068CA94C  ldr      x0, [x0, #0x210]
0068CA950  bl       #0x382bd14 ; 
0068CA954  mov      w8, #1
0068CA958  strb     w8, [x21, #0x716]
0068CA95C  adrp     x8, #0x8f28000
0068CA960  ldr      x8, [x8, #0x210]
0068CA964  ldr      x2, [x8]
0068CA968  ldrb     w8, [x2, #0x53]
0068CA96C  tbnz     w8, #5, #0x68ca984
0068CA970  mov      x0, x19
0068CA974  str      x20, [x0, #0x28]!
0068CA978  mov      x1, x20
0068CA97C  bl       #0x382bcb8 ; 
0068CA980  b        #0x68ca994 ; 
0068CA984  ldr      x8, [x2, #0x60]
0068CA988  mov      x0, x19
0068CA98C  mov      x1, x20
0068CA990  blr      x8
0068CA994  mov      x0, x19
0068CA998  mov      x1, xzr
0068CA99C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068CA9A0  adrp     x21, #0x959c000
0068CA9A4  ldrb     w8, [x21, #0x717]
0068CA9A8  mov      x20, x0
0068CA9AC  cbnz     w8, #0x68ca9c4
0068CA9B0  adrp     x0, #0x8f28000
0068CA9B4  ldr      x0, [x0, #0x220]
0068CA9B8  bl       #0x382bd14 ; 
0068CA9BC  mov      w8, #1
0068CA9C0  strb     w8, [x21, #0x717]
0068CA9C4  adrp     x8, #0x8f28000
0068CA9C8  ldr      x8, [x8, #0x220]
0068CA9CC  ldr      x2, [x8]
0068CA9D0  ldrb     w8, [x2, #0x53]
0068CA9D4  tbnz     w8, #5, #0x68ca9ec
0068CA9D8  mov      x0, x19
0068CA9DC  str      x20, [x0, #0x30]!
0068CA9E0  mov      x1, x20
0068CA9E4  bl       #0x382bcb8 ; 
0068CA9E8  b        #0x68ca9fc ; 
0068CA9EC  ldr      x8, [x2, #0x60]
0068CA9F0  mov      x0, x19
0068CA9F4  mov      x1, x20
0068CA9F8  blr      x8
0068CA9FC  mov      x0, x19
0068CAA00  mov      x1, xzr
0068CAA04  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068CAA08  adrp     x21, #0x959c000
0068CAA0C  ldrb     w8, [x21, #0x718]
0068CAA10  mov      x20, x0
0068CAA14  cbnz     w8, #0x68caa2c
0068CAA18  adrp     x0, #0x8f28000
0068CAA1C  ldr      x0, [x0, #0x230]
0068CAA20  bl       #0x382bd14 ; 
0068CAA24  mov      w8, #1
0068CAA28  strb     w8, [x21, #0x718]
0068CAA2C  adrp     x8, #0x8f28000
0068CAA30  ldr      x8, [x8, #0x230]
0068CAA34  ldr      x2, [x8]
0068CAA38  ldrb     w8, [x2, #0x53]
0068CAA3C  tbnz     w8, #5, #0x68caa54
0068CAA40  str      x20, [x19, #0x38]!
0068CAA44  mov      x0, x19
0068CAA48  mov      x1, x20
0068CAA4C  bl       #0x382bcb8 ; 
0068CAA50  b        #0x68caa64 ; 
0068CAA54  ldr      x8, [x2, #0x60]
0068CAA58  mov      x0, x19
0068CAA5C  mov      x1, x20
0068CAA60  blr      x8
0068CAA64  ldp      x20, x19, [sp, #0x10]
0068CAA68  mov      w0, #1
0068CAA6C  ldp      x30, x21, [sp], #0x20
0068CAA70  ret      

