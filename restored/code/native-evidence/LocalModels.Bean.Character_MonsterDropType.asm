; LocalModels.Bean.Character_MonsterDropType$$readImpl
; RVA 0x68C95FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C95FC  stp      x30, x21, [sp, #-0x20]!
0068C9600  stp      x20, x19, [sp, #0x10]
0068C9604  adrp     x20, #0x959c000
0068C9608  adrp     x21, #0x8f28000
0068C960C  ldrb     w8, [x20, #0x2f3]
0068C9610  ldr      x21, [x21, #0x158]
0068C9614  mov      x19, x0
0068C9618  tbnz     w8, #0, #0x68c9630
0068C961C  adrp     x0, #0x8f28000
0068C9620  ldr      x0, [x0, #0x158]
0068C9624  bl       #0x382bd14 ; 
0068C9628  mov      w8, #1
0068C962C  strb     w8, [x20, #0x2f3]
0068C9630  ldr      x1, [x21]
0068C9634  ldrb     w8, [x1, #0x53]
0068C9638  tbnz     w8, #5, #0x68c9688
0068C963C  mov      x0, x19
0068C9640  mov      x1, xzr
0068C9644  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C9648  adrp     x21, #0x959c000
0068C964C  ldrb     w8, [x21, #0x709]
0068C9650  mov      w20, w0
0068C9654  cbnz     w8, #0x68c966c
0068C9658  adrp     x0, #0x8f28000
0068C965C  ldr      x0, [x0, #0x130]
0068C9660  bl       #0x382bd14 ; 
0068C9664  mov      w8, #1
0068C9668  strb     w8, [x21, #0x709]
0068C966C  adrp     x8, #0x8f28000
0068C9670  ldr      x8, [x8, #0x130]
0068C9674  ldr      x2, [x8]
0068C9678  ldrb     w8, [x2, #0x53]
0068C967C  tbnz     w8, #5, #0x68c969c
0068C9680  str      w20, [x19, #0x20]
0068C9684  b        #0x68c96ac ; 
0068C9688  ldr      x2, [x1, #0x60]
0068C968C  mov      x0, x19
0068C9690  ldp      x20, x19, [sp, #0x10]
0068C9694  ldp      x30, x21, [sp], #0x20
0068C9698  br       x2
0068C969C  ldr      x8, [x2, #0x60]
0068C96A0  mov      x0, x19
0068C96A4  mov      w1, w20
0068C96A8  blr      x8
0068C96AC  mov      x0, x19
0068C96B0  mov      x1, xzr
0068C96B4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C96B8  adrp     x21, #0x959c000
0068C96BC  ldrb     w8, [x21, #0x70a]
0068C96C0  mov      x20, x0
0068C96C4  cbnz     w8, #0x68c96dc
0068C96C8  adrp     x0, #0x8f28000
0068C96CC  ldr      x0, [x0, #0x138]
0068C96D0  bl       #0x382bd14 ; 
0068C96D4  mov      w8, #1
0068C96D8  strb     w8, [x21, #0x70a]
0068C96DC  adrp     x8, #0x8f28000
0068C96E0  ldr      x8, [x8, #0x138]
0068C96E4  ldr      x2, [x8]
0068C96E8  ldrb     w8, [x2, #0x53]
0068C96EC  tbnz     w8, #5, #0x68c96f8
0068C96F0  str      x20, [x19, #0x28]
0068C96F4  b        #0x68c9708 ; 
0068C96F8  ldr      x8, [x2, #0x60]
0068C96FC  mov      x0, x19
0068C9700  mov      x1, x20
0068C9704  blr      x8
0068C9708  mov      x0, x19
0068C970C  mov      x1, xzr
0068C9710  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C9714  adrp     x21, #0x959c000
0068C9718  ldrb     w8, [x21, #0x70b]
0068C971C  mov      x20, x0
0068C9720  cbnz     w8, #0x68c9738
0068C9724  adrp     x0, #0x8f28000
0068C9728  ldr      x0, [x0, #0x140]
0068C972C  bl       #0x382bd14 ; 
0068C9730  mov      w8, #1
0068C9734  strb     w8, [x21, #0x70b]
0068C9738  adrp     x8, #0x8f28000
0068C973C  ldr      x8, [x8, #0x140]
0068C9740  ldr      x2, [x8]
0068C9744  ldrb     w8, [x2, #0x53]
0068C9748  tbnz     w8, #5, #0x68c9754
0068C974C  str      x20, [x19, #0x30]
0068C9750  b        #0x68c9764 ; 
0068C9754  ldr      x8, [x2, #0x60]
0068C9758  mov      x0, x19
0068C975C  mov      x1, x20
0068C9760  blr      x8
0068C9764  mov      x0, x19
0068C9768  mov      x1, xzr
0068C976C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C9770  adrp     x21, #0x959c000
0068C9774  ldrb     w8, [x21, #0x70c]
0068C9778  mov      w20, w0
0068C977C  cbnz     w8, #0x68c9794
0068C9780  adrp     x0, #0x8f28000
0068C9784  ldr      x0, [x0, #0x148]
0068C9788  bl       #0x382bd14 ; 
0068C978C  mov      w8, #1
0068C9790  strb     w8, [x21, #0x70c]
0068C9794  adrp     x8, #0x8f28000
0068C9798  ldr      x8, [x8, #0x148]
0068C979C  ldr      x2, [x8]
0068C97A0  ldrb     w8, [x2, #0x53]
0068C97A4  tbnz     w8, #5, #0x68c97b0
0068C97A8  str      w20, [x19, #0x38]
0068C97AC  b        #0x68c97c0 ; 
0068C97B0  ldr      x8, [x2, #0x60]
0068C97B4  mov      x0, x19
0068C97B8  mov      w1, w20
0068C97BC  blr      x8
0068C97C0  mov      x0, x19
0068C97C4  mov      x1, xzr
0068C97C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C97CC  adrp     x21, #0x959c000
0068C97D0  ldrb     w8, [x21, #0x70d]
0068C97D4  mov      w20, w0
0068C97D8  cbnz     w8, #0x68c97f0
0068C97DC  adrp     x0, #0x8f28000
0068C97E0  ldr      x0, [x0, #0x150]
0068C97E4  bl       #0x382bd14 ; 
0068C97E8  mov      w8, #1
0068C97EC  strb     w8, [x21, #0x70d]
0068C97F0  adrp     x8, #0x8f28000
0068C97F4  ldr      x8, [x8, #0x150]
0068C97F8  ldr      x2, [x8]
0068C97FC  ldrb     w8, [x2, #0x53]
0068C9800  tbnz     w8, #5, #0x68c980c
0068C9804  str      w20, [x19, #0x3c]
0068C9808  b        #0x68c981c ; 
0068C980C  ldr      x8, [x2, #0x60]
0068C9810  mov      x0, x19
0068C9814  mov      w1, w20
0068C9818  blr      x8
0068C981C  ldp      x20, x19, [sp, #0x10]
0068C9820  mov      w0, #1
0068C9824  ldp      x30, x21, [sp], #0x20
0068C9828  ret      

