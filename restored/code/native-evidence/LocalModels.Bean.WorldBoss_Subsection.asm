; LocalModels.Bean.WorldBoss_Subsection$$readImpl
; RVA 0x6B256DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B256DC  stp      x30, x21, [sp, #-0x20]!
006B256E0  stp      x20, x19, [sp, #0x10]
006B256E4  adrp     x20, #0x959f000
006B256E8  adrp     x21, #0x8f3f000
006B256EC  ldrb     w8, [x20, #0x765]
006B256F0  ldr      x21, [x21, #0xb78]
006B256F4  mov      x19, x0
006B256F8  tbnz     w8, #0, #0x6b25710
006B256FC  adrp     x0, #0x8f3f000
006B25700  ldr      x0, [x0, #0xb78]
006B25704  bl       #0x382bd14 ; 
006B25708  mov      w8, #1
006B2570C  strb     w8, [x20, #0x765]
006B25710  ldr      x1, [x21]
006B25714  ldrb     w8, [x1, #0x53]
006B25718  tbnz     w8, #5, #0x6b25768
006B2571C  mov      x0, x19
006B25720  mov      x1, xzr
006B25724  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B25728  adrp     x21, #0x959f000
006B2572C  ldrb     w8, [x21, #0xa8b]
006B25730  mov      w20, w0
006B25734  cbnz     w8, #0x6b2574c
006B25738  adrp     x0, #0x8f3f000
006B2573C  ldr      x0, [x0, #0xb10]
006B25740  bl       #0x382bd14 ; 
006B25744  mov      w8, #1
006B25748  strb     w8, [x21, #0xa8b]
006B2574C  adrp     x8, #0x8f3f000
006B25750  ldr      x8, [x8, #0xb10]
006B25754  ldr      x2, [x8]
006B25758  ldrb     w8, [x2, #0x53]
006B2575C  tbnz     w8, #5, #0x6b2577c
006B25760  str      w20, [x19, #0x20]
006B25764  b        #0x6b2578c ; 
006B25768  ldr      x2, [x1, #0x60]
006B2576C  mov      x0, x19
006B25770  ldp      x20, x19, [sp, #0x10]
006B25774  ldp      x30, x21, [sp], #0x20
006B25778  br       x2
006B2577C  ldr      x8, [x2, #0x60]
006B25780  mov      x0, x19
006B25784  mov      w1, w20
006B25788  blr      x8
006B2578C  mov      x0, x19
006B25790  mov      x1, xzr
006B25794  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B25798  adrp     x21, #0x959f000
006B2579C  ldrb     w8, [x21, #0xa8c]
006B257A0  mov      w20, w0
006B257A4  cbnz     w8, #0x6b257bc
006B257A8  adrp     x0, #0x8f3f000
006B257AC  ldr      x0, [x0, #0xb20]
006B257B0  bl       #0x382bd14 ; 
006B257B4  mov      w8, #1
006B257B8  strb     w8, [x21, #0xa8c]
006B257BC  adrp     x8, #0x8f3f000
006B257C0  ldr      x8, [x8, #0xb20]
006B257C4  ldr      x2, [x8]
006B257C8  ldrb     w8, [x2, #0x53]
006B257CC  tbnz     w8, #5, #0x6b257d8
006B257D0  str      w20, [x19, #0x24]
006B257D4  b        #0x6b257e8 ; 
006B257D8  ldr      x8, [x2, #0x60]
006B257DC  mov      x0, x19
006B257E0  mov      w1, w20
006B257E4  blr      x8
006B257E8  mov      x0, x19
006B257EC  mov      x1, xzr
006B257F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B257F4  adrp     x21, #0x959f000
006B257F8  ldrb     w8, [x21, #0xa8d]
006B257FC  mov      w20, w0
006B25800  cbnz     w8, #0x6b25818
006B25804  adrp     x0, #0x8f3f000
006B25808  ldr      x0, [x0, #0xb30]
006B2580C  bl       #0x382bd14 ; 
006B25810  mov      w8, #1
006B25814  strb     w8, [x21, #0xa8d]
006B25818  adrp     x8, #0x8f3f000
006B2581C  ldr      x8, [x8, #0xb30]
006B25820  ldr      x2, [x8]
006B25824  ldrb     w8, [x2, #0x53]
006B25828  tbnz     w8, #5, #0x6b25834
006B2582C  str      w20, [x19, #0x28]
006B25830  b        #0x6b25844 ; 
006B25834  ldr      x8, [x2, #0x60]
006B25838  mov      x0, x19
006B2583C  mov      w1, w20
006B25840  blr      x8
006B25844  mov      x0, x19
006B25848  mov      x1, xzr
006B2584C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B25850  adrp     x21, #0x959f000
006B25854  ldrb     w8, [x21, #0xa8e]
006B25858  mov      w20, w0
006B2585C  cbnz     w8, #0x6b25874
006B25860  adrp     x0, #0x8f3f000
006B25864  ldr      x0, [x0, #0xb40]
006B25868  bl       #0x382bd14 ; 
006B2586C  mov      w8, #1
006B25870  strb     w8, [x21, #0xa8e]
006B25874  adrp     x8, #0x8f3f000
006B25878  ldr      x8, [x8, #0xb40]
006B2587C  ldr      x2, [x8]
006B25880  ldrb     w8, [x2, #0x53]
006B25884  tbnz     w8, #5, #0x6b25890
006B25888  str      w20, [x19, #0x2c]
006B2588C  b        #0x6b258a0 ; 
006B25890  ldr      x8, [x2, #0x60]
006B25894  mov      x0, x19
006B25898  mov      w1, w20
006B2589C  blr      x8
006B258A0  mov      x0, x19
006B258A4  mov      x1, xzr
006B258A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B258AC  adrp     x21, #0x959f000
006B258B0  ldrb     w8, [x21, #0xa8f]
006B258B4  mov      w20, w0
006B258B8  cbnz     w8, #0x6b258d0
006B258BC  adrp     x0, #0x8f3f000
006B258C0  ldr      x0, [x0, #0xb50]
006B258C4  bl       #0x382bd14 ; 
006B258C8  mov      w8, #1
006B258CC  strb     w8, [x21, #0xa8f]
006B258D0  adrp     x8, #0x8f3f000
006B258D4  ldr      x8, [x8, #0xb50]
006B258D8  ldr      x2, [x8]
006B258DC  ldrb     w8, [x2, #0x53]
006B258E0  tbnz     w8, #5, #0x6b258ec
006B258E4  str      w20, [x19, #0x30]
006B258E8  b        #0x6b258fc ; 
006B258EC  ldr      x8, [x2, #0x60]
006B258F0  mov      x0, x19
006B258F4  mov      w1, w20
006B258F8  blr      x8
006B258FC  mov      x0, x19
006B25900  mov      x1, xzr
006B25904  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B25908  adrp     x21, #0x959f000
006B2590C  ldrb     w8, [x21, #0xa90]
006B25910  mov      w20, w0
006B25914  cbnz     w8, #0x6b2592c
006B25918  adrp     x0, #0x8f3f000
006B2591C  ldr      x0, [x0, #0xb60]
006B25920  bl       #0x382bd14 ; 
006B25924  mov      w8, #1
006B25928  strb     w8, [x21, #0xa90]
006B2592C  adrp     x8, #0x8f3f000
006B25930  ldr      x8, [x8, #0xb60]
006B25934  ldr      x2, [x8]
006B25938  ldrb     w8, [x2, #0x53]
006B2593C  tbnz     w8, #5, #0x6b25948
006B25940  str      w20, [x19, #0x34]
006B25944  b        #0x6b25958 ; 
006B25948  ldr      x8, [x2, #0x60]
006B2594C  mov      x0, x19
006B25950  mov      w1, w20
006B25954  blr      x8
006B25958  mov      x0, x19
006B2595C  mov      x1, xzr
006B25960  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B25964  adrp     x21, #0x959f000
006B25968  ldrb     w8, [x21, #0xa91]
006B2596C  mov      x20, x0
006B25970  cbnz     w8, #0x6b25988
006B25974  adrp     x0, #0x8f3f000
006B25978  ldr      x0, [x0, #0xb70]
006B2597C  bl       #0x382bd14 ; 
006B25980  mov      w8, #1
006B25984  strb     w8, [x21, #0xa91]
006B25988  adrp     x8, #0x8f3f000
006B2598C  ldr      x8, [x8, #0xb70]
006B25990  ldr      x2, [x8]
006B25994  ldrb     w8, [x2, #0x53]
006B25998  tbnz     w8, #5, #0x6b259b0
006B2599C  str      x20, [x19, #0x38]!
006B259A0  mov      x0, x19
006B259A4  mov      x1, x20
006B259A8  bl       #0x382bcb8 ; 
006B259AC  b        #0x6b259c0 ; 
006B259B0  ldr      x8, [x2, #0x60]
006B259B4  mov      x0, x19
006B259B8  mov      x1, x20
006B259BC  blr      x8
006B259C0  ldp      x20, x19, [sp, #0x10]
006B259C4  mov      w0, #1
006B259C8  ldp      x30, x21, [sp], #0x20
006B259CC  ret      

