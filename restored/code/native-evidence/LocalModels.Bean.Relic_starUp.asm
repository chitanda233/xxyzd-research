; LocalModels.Bean.Relic_starUp$$readImpl
; RVA 0x6ADB570; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ADB570  stp      x30, x21, [sp, #-0x20]!
006ADB574  stp      x20, x19, [sp, #0x10]
006ADB578  adrp     x20, #0x959e000
006ADB57C  adrp     x21, #0x8f3c000
006ADB580  ldrb     w8, [x20, #0xc36]
006ADB584  ldr      x21, [x21, #0x658]
006ADB588  mov      x19, x0
006ADB58C  tbnz     w8, #0, #0x6adb5a4
006ADB590  adrp     x0, #0x8f3c000
006ADB594  ldr      x0, [x0, #0x658]
006ADB598  bl       #0x382bd14 ; 
006ADB59C  mov      w8, #1
006ADB5A0  strb     w8, [x20, #0xc36]
006ADB5A4  ldr      x1, [x21]
006ADB5A8  ldrb     w8, [x1, #0x53]
006ADB5AC  tbnz     w8, #5, #0x6adb5fc
006ADB5B0  mov      x0, x19
006ADB5B4  mov      x1, xzr
006ADB5B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADB5BC  adrp     x21, #0x959f000
006ADB5C0  ldrb     w8, [x21, #0x156]
006ADB5C4  mov      w20, w0
006ADB5C8  cbnz     w8, #0x6adb5e0
006ADB5CC  adrp     x0, #0x8f3c000
006ADB5D0  ldr      x0, [x0, #0x5f0]
006ADB5D4  bl       #0x382bd14 ; 
006ADB5D8  mov      w8, #1
006ADB5DC  strb     w8, [x21, #0x156]
006ADB5E0  adrp     x8, #0x8f3c000
006ADB5E4  ldr      x8, [x8, #0x5f0]
006ADB5E8  ldr      x2, [x8]
006ADB5EC  ldrb     w8, [x2, #0x53]
006ADB5F0  tbnz     w8, #5, #0x6adb610
006ADB5F4  str      w20, [x19, #0x20]
006ADB5F8  b        #0x6adb620 ; 
006ADB5FC  ldr      x2, [x1, #0x60]
006ADB600  mov      x0, x19
006ADB604  ldp      x20, x19, [sp, #0x10]
006ADB608  ldp      x30, x21, [sp], #0x20
006ADB60C  br       x2
006ADB610  ldr      x8, [x2, #0x60]
006ADB614  mov      x0, x19
006ADB618  mov      w1, w20
006ADB61C  blr      x8
006ADB620  mov      x0, x19
006ADB624  mov      x1, xzr
006ADB628  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADB62C  adrp     x21, #0x959f000
006ADB630  ldrb     w8, [x21, #0x157]
006ADB634  mov      w20, w0
006ADB638  cbnz     w8, #0x6adb650
006ADB63C  adrp     x0, #0x8f3c000
006ADB640  ldr      x0, [x0, #0x600]
006ADB644  bl       #0x382bd14 ; 
006ADB648  mov      w8, #1
006ADB64C  strb     w8, [x21, #0x157]
006ADB650  adrp     x8, #0x8f3c000
006ADB654  ldr      x8, [x8, #0x600]
006ADB658  ldr      x2, [x8]
006ADB65C  ldrb     w8, [x2, #0x53]
006ADB660  tbnz     w8, #5, #0x6adb66c
006ADB664  str      w20, [x19, #0x24]
006ADB668  b        #0x6adb67c ; 
006ADB66C  ldr      x8, [x2, #0x60]
006ADB670  mov      x0, x19
006ADB674  mov      w1, w20
006ADB678  blr      x8
006ADB67C  mov      x0, x19
006ADB680  mov      x1, xzr
006ADB684  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADB688  adrp     x21, #0x959f000
006ADB68C  ldrb     w8, [x21, #0x158]
006ADB690  mov      w20, w0
006ADB694  cbnz     w8, #0x6adb6ac
006ADB698  adrp     x0, #0x8f3c000
006ADB69C  ldr      x0, [x0, #0x610]
006ADB6A0  bl       #0x382bd14 ; 
006ADB6A4  mov      w8, #1
006ADB6A8  strb     w8, [x21, #0x158]
006ADB6AC  adrp     x8, #0x8f3c000
006ADB6B0  ldr      x8, [x8, #0x610]
006ADB6B4  ldr      x2, [x8]
006ADB6B8  ldrb     w8, [x2, #0x53]
006ADB6BC  tbnz     w8, #5, #0x6adb6c8
006ADB6C0  str      w20, [x19, #0x28]
006ADB6C4  b        #0x6adb6d8 ; 
006ADB6C8  ldr      x8, [x2, #0x60]
006ADB6CC  mov      x0, x19
006ADB6D0  mov      w1, w20
006ADB6D4  blr      x8
006ADB6D8  mov      x0, x19
006ADB6DC  mov      x1, xzr
006ADB6E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADB6E4  adrp     x21, #0x959f000
006ADB6E8  ldrb     w8, [x21, #0x159]
006ADB6EC  mov      w20, w0
006ADB6F0  cbnz     w8, #0x6adb708
006ADB6F4  adrp     x0, #0x8f3c000
006ADB6F8  ldr      x0, [x0, #0x620]
006ADB6FC  bl       #0x382bd14 ; 
006ADB700  mov      w8, #1
006ADB704  strb     w8, [x21, #0x159]
006ADB708  adrp     x8, #0x8f3c000
006ADB70C  ldr      x8, [x8, #0x620]
006ADB710  ldr      x2, [x8]
006ADB714  ldrb     w8, [x2, #0x53]
006ADB718  tbnz     w8, #5, #0x6adb724
006ADB71C  str      w20, [x19, #0x2c]
006ADB720  b        #0x6adb734 ; 
006ADB724  ldr      x8, [x2, #0x60]
006ADB728  mov      x0, x19
006ADB72C  mov      w1, w20
006ADB730  blr      x8
006ADB734  mov      x0, x19
006ADB738  mov      x1, xzr
006ADB73C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADB740  adrp     x21, #0x959f000
006ADB744  ldrb     w8, [x21, #0x15a]
006ADB748  mov      w20, w0
006ADB74C  cbnz     w8, #0x6adb764
006ADB750  adrp     x0, #0x8f3c000
006ADB754  ldr      x0, [x0, #0x630]
006ADB758  bl       #0x382bd14 ; 
006ADB75C  mov      w8, #1
006ADB760  strb     w8, [x21, #0x15a]
006ADB764  adrp     x8, #0x8f3c000
006ADB768  ldr      x8, [x8, #0x630]
006ADB76C  ldr      x2, [x8]
006ADB770  ldrb     w8, [x2, #0x53]
006ADB774  tbnz     w8, #5, #0x6adb780
006ADB778  str      w20, [x19, #0x30]
006ADB77C  b        #0x6adb790 ; 
006ADB780  ldr      x8, [x2, #0x60]
006ADB784  mov      x0, x19
006ADB788  mov      w1, w20
006ADB78C  blr      x8
006ADB790  mov      x0, x19
006ADB794  mov      x1, xzr
006ADB798  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADB79C  adrp     x21, #0x959f000
006ADB7A0  ldrb     w8, [x21, #0x15b]
006ADB7A4  mov      w20, w0
006ADB7A8  cbnz     w8, #0x6adb7c0
006ADB7AC  adrp     x0, #0x8f3c000
006ADB7B0  ldr      x0, [x0, #0x640]
006ADB7B4  bl       #0x382bd14 ; 
006ADB7B8  mov      w8, #1
006ADB7BC  strb     w8, [x21, #0x15b]
006ADB7C0  adrp     x8, #0x8f3c000
006ADB7C4  ldr      x8, [x8, #0x640]
006ADB7C8  ldr      x2, [x8]
006ADB7CC  ldrb     w8, [x2, #0x53]
006ADB7D0  tbnz     w8, #5, #0x6adb7dc
006ADB7D4  str      w20, [x19, #0x34]
006ADB7D8  b        #0x6adb7ec ; 
006ADB7DC  ldr      x8, [x2, #0x60]
006ADB7E0  mov      x0, x19
006ADB7E4  mov      w1, w20
006ADB7E8  blr      x8
006ADB7EC  mov      x0, x19
006ADB7F0  mov      x1, xzr
006ADB7F4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADB7F8  adrp     x21, #0x959f000
006ADB7FC  ldrb     w8, [x21, #0x15c]
006ADB800  mov      x20, x0
006ADB804  cbnz     w8, #0x6adb81c
006ADB808  adrp     x0, #0x8f3c000
006ADB80C  ldr      x0, [x0, #0x650]
006ADB810  bl       #0x382bd14 ; 
006ADB814  mov      w8, #1
006ADB818  strb     w8, [x21, #0x15c]
006ADB81C  adrp     x8, #0x8f3c000
006ADB820  ldr      x8, [x8, #0x650]
006ADB824  ldr      x2, [x8]
006ADB828  ldrb     w8, [x2, #0x53]
006ADB82C  tbnz     w8, #5, #0x6adb844
006ADB830  str      x20, [x19, #0x38]!
006ADB834  mov      x0, x19
006ADB838  mov      x1, x20
006ADB83C  bl       #0x382bcb8 ; 
006ADB840  b        #0x6adb854 ; 
006ADB844  ldr      x8, [x2, #0x60]
006ADB848  mov      x0, x19
006ADB84C  mov      x1, x20
006ADB850  blr      x8
006ADB854  ldp      x20, x19, [sp, #0x10]
006ADB858  mov      w0, #1
006ADB85C  ldp      x30, x21, [sp], #0x20
006ADB860  ret      

