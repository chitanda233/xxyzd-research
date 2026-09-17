; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Sort
; RVA 0x5048324; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005048324  str      x30, [sp, #-0x40]!
005048328  stp      x24, x23, [sp, #0x10]
00504832C  stp      x22, x21, [sp, #0x20]
005048330  stp      x20, x19, [sp, #0x30]
005048334  mov      x19, x5
005048338  mov      x20, x4
00504833C  mov      w21, w3
005048340  mov      w22, w2
005048344  mov      x23, x1
005048348  cbnz     x4, #0x5048360
00504834C  ldr      x8, [x19, #0x20]
005048350  ldr      x8, [x8, #0xc0]
005048354  ldr      x0, [x8, #8]
005048358  bl       #0x5c4f3cc ; System.Collections.Generic.Comparer<WeightRandomData>$$get_Default
00504835C  mov      x20, x0
005048360  ldr      x8, [x19, #0x20]
005048364  ldr      x8, [x8, #0xc0]
005048368  ldr      x0, [x8, #0x30]
00504836C  ldrb     w8, [x0, #0x135]
005048370  tbnz     w8, #0, #0x5048378
005048374  bl       #0x3a7e60c ; 
005048378  bl       #0x382bfa0 ; 
00504837C  ldr      x8, [x19, #0x20]
005048380  mov      x24, x0
005048384  ldr      x8, [x8, #0xc0]
005048388  ldr      x1, [x8]
00504838C  ldrb     w8, [x1, #0x135]
005048390  tbnz     w8, #0, #0x50483a0
005048394  mov      x0, x1
005048398  bl       #0x3a7e60c ; 
00504839C  mov      x1, x0
0050483A0  cbz      x20, #0x5048460
0050483A4  ldr      x8, [x20]
0050483A8  ldrh     w9, [x8, #0x12e]
0050483AC  cbz      x9, #0x50483d0
0050483B0  ldr      x10, [x8, #0xb0]
0050483B4  add      x10, x10, #8
0050483B8  ldur     x11, [x10, #-8]
0050483BC  cmp      x11, x1
0050483C0  b.eq     #0x50483e0
0050483C4  subs     x9, x9, #1
0050483C8  add      x10, x10, #0x10
0050483CC  b.ne     #0x50483b8
0050483D0  mov      x0, x20
0050483D4  mov      w2, wzr
0050483D8  bl       #0x3a7e710 ; 
0050483DC  b        #0x50483ec ; 
0050483E0  ldrsw    x9, [x10]
0050483E4  add      x8, x8, x9, lsl #4
0050483E8  add      x0, x8, #0x138
0050483EC  ldr      x8, [x19, #0x20]
0050483F0  ldr      x2, [x0, #8]
0050483F4  ldr      x8, [x8, #0xc0]
0050483F8  ldr      x3, [x8, #0x38]
0050483FC  mov      x0, x24
005048400  mov      x1, x20
005048404  bl       #0x5c8efac ; System.Comparison<WeightRandomData>$$.ctor
005048408  ldr      x8, [x19, #0x20]
00504840C  ldr      x8, [x8, #0xc0]
005048410  ldr      x0, [x8, #0x48]
005048414  ldrb     w8, [x0, #0x135]
005048418  tbnz     w8, #0, #0x5048420
00504841C  bl       #0x3a7e60c ; 
005048420  ldr      w8, [x0, #0xe0]
005048424  cbnz     w8, #0x504842c
005048428  bl       #0x382be8c ; 
00504842C  ldr      x8, [x19, #0x20]
005048430  ldr      x8, [x8, #0xc0]
005048434  ldr      x4, [x8, #0x40]
005048438  mov      x0, x23
00504843C  mov      w1, w22
005048440  mov      w2, w21
005048444  mov      x3, x24
005048448  bl       #0x5048db0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$IntrospectiveSort
00504844C  ldp      x20, x19, [sp, #0x30]
005048450  ldp      x22, x21, [sp, #0x20]
005048454  ldp      x24, x23, [sp, #0x10]
005048458  ldr      x30, [sp], #0x40
00504845C  ret      
005048460  bl       #0x382bfb8 ; 
005048464  mov      x21, x0
005048468  mov      x20, xzr
00504846C  b        #0x5048474 ; 
005048470  mov      x21, x0
005048474  cmp      w1, #1
005048478  b.ne     #0x504857c
00504847C  mov      x0, x21
005048480  bl       #0x89eda50 ; 
005048484  mov      x21, x0
005048488  adrp     x0, #0x8ec8000
00504848C  ldr      x0, [x0, #0xee8]
005048490  bl       #0x382bd28 ; 
005048494  ldr      x8, [x21]
005048498  ldr      x1, [x8]
00504849C  bl       #0x382c3e4 ; 
0050484A0  tbz      w0, #0, #0x50484c4
0050484A4  bl       #0x89eda60 ; 
0050484A8  mov      x0, x20
0050484AC  ldp      x20, x19, [sp, #0x30]
0050484B0  ldp      x22, x21, [sp, #0x20]
0050484B4  ldp      x24, x23, [sp, #0x10]
0050484B8  mov      x1, xzr
0050484BC  ldr      x30, [sp], #0x40
0050484C0  b        #0x7bacfd0 ; System.Collections.Generic.IntrospectiveSortUtilities$$ThrowOrIgnoreBadComparer
0050484C4  adrp     x0, #0x8ee8000
0050484C8  ldr      x0, [x0, #0xf0]
0050484CC  bl       #0x382bd28 ; 
0050484D0  ldr      x8, [x21]
0050484D4  ldr      x1, [x8]
0050484D8  bl       #0x382c3e4 ; 
0050484DC  tbz      w0, #0, #0x50484f0
0050484E0  ldr      x19, [x21]
0050484E4  bl       #0x89eda60 ; 
0050484E8  mov      x0, x19
0050484EC  bl       #0x382bfb0 ; 
0050484F0  adrp     x0, #0x8ebf000
0050484F4  ldr      x0, [x0, #0xc70]
0050484F8  bl       #0x382bd28 ; 
0050484FC  ldr      x8, [x21]
005048500  ldr      x1, [x8]
005048504  bl       #0x382c3e4 ; 
005048508  tbz      w0, #0, #0x5048554
00504850C  ldr      x20, [x21]
005048510  bl       #0x89eda60 ; 
005048514  adrp     x0, #0x8ec3000
005048518  ldr      x0, [x0, #0x760]
00504851C  bl       #0x382bd28 ; 
005048520  bl       #0x382bfa0 ; 
005048524  mov      x21, x0
005048528  adrp     x0, #0x8ee8000
00504852C  ldr      x0, [x0, #0xf8]
005048530  bl       #0x382bd28 ; 
005048534  mov      x1, x0
005048538  mov      x0, x21
00504853C  mov      x2, x20
005048540  mov      x3, xzr
005048544  bl       #0x7bd4cfc ; System.InvalidOperationException$$.ctor
005048548  mov      x0, x21
00504854C  mov      x1, x19
005048550  bl       #0x382be7c ; 
005048554  mov      w0, #8
005048558  bl       #0x89eda70 ; 
00504855C  ldr      x8, [x21]
005048560  str      x8, [x0]
005048564  adrp     x1, #0x89f3000
005048568  add      x1, x1, #0xf98
00504856C  mov      x2, xzr
005048570  bl       #0x89eda80 ; 
005048574  mov      x21, x0
005048578  bl       #0x89eda60 ; 
00504857C  mov      x0, x21
005048580  bl       #0x3b56bfc ; 
005048584  bl       #0x3442448 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$BinarySearch
; RVA 0x5048588; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005048588  sub      sp, sp, #0xc0
00504858C  str      x30, [sp, #0x80]
005048590  stp      x24, x23, [sp, #0x90]
005048594  stp      x22, x21, [sp, #0xa0]
005048598  stp      x20, x19, [sp, #0xb0]
00504859C  mov      x19, x6
0050485A0  mov      x23, x5
0050485A4  mov      x24, x4
0050485A8  mov      w20, w3
0050485AC  mov      w21, w2
0050485B0  mov      x22, x1
0050485B4  cbnz     x5, #0x50485cc
0050485B8  ldr      x8, [x19, #0x20]
0050485BC  ldr      x8, [x8, #0xc0]
0050485C0  ldr      x0, [x8, #8]
0050485C4  bl       #0x5c4f3cc ; System.Collections.Generic.Comparer<WeightRandomData>$$get_Default
0050485C8  mov      x23, x0
0050485CC  ldr      x8, [x24, #0x30]
0050485D0  ldp      q1, q0, [x24, #0x10]
0050485D4  ldr      q2, [x24]
0050485D8  str      x8, [sp, #0x30]
0050485DC  stp      q1, q0, [sp, #0x10]
0050485E0  str      q2, [sp]
0050485E4  ldr      x8, [x19, #0x20]
0050485E8  ldr      x8, [x8, #0xc0]
0050485EC  ldr      x0, [x8, #0x48]
0050485F0  ldrb     w8, [x0, #0x135]
0050485F4  tbnz     w8, #0, #0x50485fc
0050485F8  bl       #0x3a7e60c ; 
0050485FC  ldr      w8, [x0, #0xe0]
005048600  cbnz     w8, #0x5048608
005048604  bl       #0x382be8c ; 
005048608  ldr      x8, [x19, #0x20]
00504860C  ldp      q0, q1, [sp]
005048610  ldr      q2, [sp, #0x20]
005048614  ldr      x9, [sp, #0x30]
005048618  ldr      x8, [x8, #0xc0]
00504861C  ldr      x5, [x8, #0x58]
005048620  stp      q0, q1, [sp, #0x40]
005048624  str      q2, [sp, #0x60]
005048628  str      x9, [sp, #0x70]
00504862C  add      x3, sp, #0x40
005048630  mov      x0, x22
005048634  mov      w1, w21
005048638  mov      w2, w20
00504863C  mov      x4, x23
005048640  bl       #0x50488e8 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$InternalBinarySearch
005048644  ldp      x20, x19, [sp, #0xb0]
005048648  ldp      x22, x21, [sp, #0xa0]
00504864C  ldp      x24, x23, [sp, #0x90]
005048650  ldr      x30, [sp, #0x80]
005048654  add      sp, sp, #0xc0
005048658  ret      
00504865C  b        #0x5048664 ; 
005048660  b        #0x5048664 ; 
005048664  mov      x20, x0
005048668  cmp      w1, #1
00504866C  b.ne     #0x5048734
005048670  mov      x0, x20
005048674  bl       #0x89eda50 ; 
005048678  mov      x20, x0
00504867C  adrp     x0, #0x8ee8000
005048680  ldr      x0, [x0, #0xf0]
005048684  bl       #0x382bd28 ; 
005048688  ldr      x8, [x20]
00504868C  ldr      x1, [x8]
005048690  bl       #0x382c3e4 ; 
005048694  tbz      w0, #0, #0x50486a8
005048698  ldr      x19, [x20]
00504869C  bl       #0x89eda60 ; 
0050486A0  mov      x0, x19
0050486A4  bl       #0x382bfb0 ; 
0050486A8  adrp     x0, #0x8ebf000
0050486AC  ldr      x0, [x0, #0xc70]
0050486B0  bl       #0x382bd28 ; 
0050486B4  ldr      x8, [x20]
0050486B8  ldr      x1, [x8]
0050486BC  bl       #0x382c3e4 ; 
0050486C0  tbz      w0, #0, #0x504870c
0050486C4  ldr      x20, [x20]
0050486C8  bl       #0x89eda60 ; 
0050486CC  adrp     x0, #0x8ec3000
0050486D0  ldr      x0, [x0, #0x760]
0050486D4  bl       #0x382bd28 ; 
0050486D8  bl       #0x382bfa0 ; 
0050486DC  mov      x21, x0
0050486E0  adrp     x0, #0x8ee8000
0050486E4  ldr      x0, [x0, #0xf8]
0050486E8  bl       #0x382bd28 ; 
0050486EC  mov      x1, x0
0050486F0  mov      x0, x21
0050486F4  mov      x2, x20
0050486F8  mov      x3, xzr
0050486FC  bl       #0x7bd4cfc ; System.InvalidOperationException$$.ctor
005048700  mov      x0, x21
005048704  mov      x1, x19
005048708  bl       #0x382be7c ; 
00504870C  mov      w0, #8
005048710  bl       #0x89eda70 ; 
005048714  ldr      x8, [x20]
005048718  str      x8, [x0]
00504871C  adrp     x1, #0x89f3000
005048720  add      x1, x1, #0xf98
005048724  mov      x2, xzr
005048728  bl       #0x89eda80 ; 
00504872C  mov      x20, x0
005048730  bl       #0x89eda60 ; 
005048734  mov      x0, x20
005048738  bl       #0x3b56bfc ; 
00504873C  bl       #0x3442448 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Sort
; RVA 0x5048740; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005048740  stp      x30, x23, [sp, #-0x30]!
005048744  stp      x22, x21, [sp, #0x10]
005048748  stp      x20, x19, [sp, #0x20]
00504874C  ldr      x8, [x4, #0x20]
005048750  mov      x19, x4
005048754  mov      x20, x3
005048758  mov      w21, w2
00504875C  ldrb     w9, [x8, #0x135]
005048760  mov      w22, w1
005048764  mov      x23, x0
005048768  tbnz     w9, #0, #0x5048778
00504876C  mov      x0, x8
005048770  bl       #0x3a7e60c ; 
005048774  mov      x8, x0
005048778  ldr      x8, [x8, #0xc0]
00504877C  ldr      x0, [x8, #0x48]
005048780  ldrb     w8, [x0, #0x135]
005048784  tbnz     w8, #0, #0x504878c
005048788  bl       #0x3a7e60c ; 
00504878C  ldr      w8, [x0, #0xe0]
005048790  cbnz     w8, #0x5048798
005048794  bl       #0x382be8c ; 
005048798  ldr      x0, [x19, #0x20]
00504879C  ldrb     w8, [x0, #0x135]
0050487A0  tbnz     w8, #0, #0x50487a8
0050487A4  bl       #0x3a7e60c ; 
0050487A8  ldr      x8, [x0, #0xc0]
0050487AC  ldr      x4, [x8, #0x40]
0050487B0  mov      x0, x23
0050487B4  mov      w1, w22
0050487B8  mov      w2, w21
0050487BC  mov      x3, x20
0050487C0  bl       #0x5048db0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$IntrospectiveSort
0050487C4  ldp      x20, x19, [sp, #0x20]
0050487C8  ldp      x22, x21, [sp, #0x10]
0050487CC  ldp      x30, x23, [sp], #0x30
0050487D0  ret      
0050487D4  cmp      w1, #1
0050487D8  mov      x21, x0
0050487DC  b.ne     #0x50488dc
0050487E0  mov      x0, x21
0050487E4  bl       #0x89eda50 ; 
0050487E8  mov      x21, x0
0050487EC  adrp     x0, #0x8ec8000
0050487F0  ldr      x0, [x0, #0xee8]
0050487F4  bl       #0x382bd28 ; 
0050487F8  ldr      x8, [x21]
0050487FC  ldr      x1, [x8]
005048800  bl       #0x382c3e4 ; 
005048804  tbz      w0, #0, #0x5048824
005048808  bl       #0x89eda60 ; 
00504880C  mov      x0, x20
005048810  ldp      x20, x19, [sp, #0x20]
005048814  ldp      x22, x21, [sp, #0x10]
005048818  mov      x1, xzr
00504881C  ldp      x30, x23, [sp], #0x30
005048820  b        #0x7bacfd0 ; System.Collections.Generic.IntrospectiveSortUtilities$$ThrowOrIgnoreBadComparer
005048824  adrp     x0, #0x8ee8000
005048828  ldr      x0, [x0, #0xf0]
00504882C  bl       #0x382bd28 ; 
005048830  ldr      x8, [x21]
005048834  ldr      x1, [x8]
005048838  bl       #0x382c3e4 ; 
00504883C  tbz      w0, #0, #0x5048850
005048840  ldr      x19, [x21]
005048844  bl       #0x89eda60 ; 
005048848  mov      x0, x19
00504884C  bl       #0x382bfb0 ; 
005048850  adrp     x0, #0x8ebf000
005048854  ldr      x0, [x0, #0xc70]
005048858  bl       #0x382bd28 ; 
00504885C  ldr      x8, [x21]
005048860  ldr      x1, [x8]
005048864  bl       #0x382c3e4 ; 
005048868  tbz      w0, #0, #0x50488b4
00504886C  ldr      x20, [x21]
005048870  bl       #0x89eda60 ; 
005048874  adrp     x0, #0x8ec3000
005048878  ldr      x0, [x0, #0x760]
00504887C  bl       #0x382bd28 ; 
005048880  bl       #0x382bfa0 ; 
005048884  mov      x21, x0
005048888  adrp     x0, #0x8ee8000
00504888C  ldr      x0, [x0, #0xf8]
005048890  bl       #0x382bd28 ; 
005048894  mov      x1, x0
005048898  mov      x0, x21
00504889C  mov      x2, x20
0050488A0  mov      x3, xzr
0050488A4  bl       #0x7bd4cfc ; System.InvalidOperationException$$.ctor
0050488A8  mov      x0, x21
0050488AC  mov      x1, x19
0050488B0  bl       #0x382be7c ; 
0050488B4  mov      w0, #8
0050488B8  bl       #0x89eda70 ; 
0050488BC  ldr      x8, [x21]
0050488C0  str      x8, [x0]
0050488C4  adrp     x1, #0x89f3000
0050488C8  add      x1, x1, #0xf98
0050488CC  mov      x2, xzr
0050488D0  bl       #0x89eda80 ; 
0050488D4  mov      x21, x0
0050488D8  bl       #0x89eda60 ; 
0050488DC  mov      x0, x21
0050488E0  bl       #0x3b56bfc ; 
0050488E4  bl       #0x3442448 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$InternalBinarySearch
; RVA 0x50488E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0050488E8  sub      sp, sp, #0x1d0
0050488EC  stp      x29, x30, [sp, #0x180]
0050488F0  stp      x26, x25, [sp, #0x190]
0050488F4  stp      x24, x23, [sp, #0x1a0]
0050488F8  stp      x22, x21, [sp, #0x1b0]
0050488FC  stp      x20, x19, [sp, #0x1c0]
005048900  add      w8, w1, w2
005048904  sub      w25, w8, #1
005048908  mov      w19, w1
00504890C  cmp      w25, w1
005048910  b.ge     #0x5048938
005048914  mvn      w24, w19
005048918  mov      w0, w24
00504891C  ldp      x20, x19, [sp, #0x1c0]
005048920  ldp      x22, x21, [sp, #0x1b0]
005048924  ldp      x24, x23, [sp, #0x1a0]
005048928  ldp      x26, x25, [sp, #0x190]
00504892C  ldp      x29, x30, [sp, #0x180]
005048930  add      sp, sp, #0x1d0
005048934  ret      
005048938  mov      x23, x0
00504893C  cbz      x0, #0x5048aac
005048940  mov      x20, x5
005048944  mov      x21, x4
005048948  mov      x22, x3
00504894C  mov      w26, #0x38
005048950  ldr      w8, [x23, #0x18]
005048954  sub      w9, w25, w19
005048958  add      w24, w19, w9, asr #1
00504895C  cmp      w24, w8
005048960  b.hs     #0x5048aa8
005048964  smaddl   x8, w24, w26, x23
005048968  ldr      x9, [x8, #0x50]
00504896C  ldp      q1, q0, [x8, #0x30]
005048970  ldr      q2, [x8, #0x20]
005048974  str      x9, [sp, #0xf0]
005048978  stp      q1, q0, [sp, #0xd0]
00504897C  str      q2, [sp, #0xc0]
005048980  ldr      x8, [x22, #0x30]
005048984  ldp      q1, q0, [x22, #0x10]
005048988  ldr      q2, [x22]
00504898C  str      x8, [sp, #0xb0]
005048990  stp      q1, q0, [sp, #0x90]
005048994  str      q2, [sp, #0x80]
005048998  cbz      x21, #0x5048aac
00504899C  ldr      x0, [x20, #0x20]
0050489A0  ldrb     w8, [x0, #0x135]
0050489A4  tbnz     w8, #0, #0x50489ac
0050489A8  bl       #0x3a7e60c ; 
0050489AC  ldr      x8, [x0, #0xc0]
0050489B0  ldr      x1, [x8]
0050489B4  ldrb     w8, [x1, #0x135]
0050489B8  tbnz     w8, #0, #0x50489c8
0050489BC  mov      x0, x1
0050489C0  bl       #0x3a7e60c ; 
0050489C4  mov      x1, x0
0050489C8  ldp      q0, q1, [sp, #0xc0]
0050489CC  ldr      q2, [sp, #0xe0]
0050489D0  ldr      x8, [sp, #0xf0]
0050489D4  ldr      x9, [sp, #0xb0]
0050489D8  stp      q0, q1, [sp, #0x40]
0050489DC  ldp      q0, q1, [sp, #0x80]
0050489E0  str      q2, [sp, #0x60]
0050489E4  ldr      q2, [sp, #0xa0]
0050489E8  str      x8, [sp, #0x70]
0050489EC  stp      q0, q1, [sp]
0050489F0  str      x9, [sp, #0x30]
0050489F4  str      q2, [sp, #0x20]
0050489F8  ldr      x8, [x21]
0050489FC  ldrh     w9, [x8, #0x12e]
005048A00  cbz      x9, #0x5048a24
005048A04  ldr      x10, [x8, #0xb0]
005048A08  add      x10, x10, #8
005048A0C  ldur     x11, [x10, #-8]
005048A10  cmp      x11, x1
005048A14  b.eq     #0x5048a34
005048A18  subs     x9, x9, #1
005048A1C  add      x10, x10, #0x10
005048A20  b.ne     #0x5048a0c
005048A24  mov      x0, x21
005048A28  mov      w2, wzr
005048A2C  bl       #0x3a7e710 ; 
005048A30  b        #0x5048a40 ; 
005048A34  ldrsw    x9, [x10]
005048A38  add      x8, x8, x9, lsl #4
005048A3C  add      x0, x8, #0x138
005048A40  ldp      q0, q1, [sp, #0x40]
005048A44  ldr      q2, [sp, #0x60]
005048A48  ldr      x8, [x0]
005048A4C  ldr      x9, [sp, #0x70]
005048A50  stp      q0, q1, [sp, #0x140]
005048A54  ldp      q0, q1, [sp]
005048A58  str      q2, [sp, #0x160]
005048A5C  ldr      q2, [sp, #0x20]
005048A60  ldr      x10, [sp, #0x30]
005048A64  stp      q0, q1, [sp, #0x100]
005048A68  str      x9, [sp, #0x170]
005048A6C  str      q2, [sp, #0x120]
005048A70  str      x10, [sp, #0x130]
005048A74  ldr      x3, [x0, #8]
005048A78  add      x1, sp, #0x140
005048A7C  add      x2, sp, #0x100
005048A80  mov      x0, x21
005048A84  blr      x8
005048A88  cbz      w0, #0x5048918
005048A8C  tbz      w0, #0x1f, #0x5048aa0
005048A90  add      w19, w24, #1
005048A94  cmp      w25, w19
005048A98  b.ge     #0x5048950
005048A9C  b        #0x5048914 ; 
005048AA0  sub      w25, w24, #1
005048AA4  b        #0x5048a94 ; 
005048AA8  bl       #0x382bfc0 ; 
005048AAC  bl       #0x382bfb8 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$SwapIfGreater
; RVA 0x5048AB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005048AB0  stp      x29, x30, [sp, #-0x50]!
005048AB4  stp      x26, x25, [sp, #0x10]
005048AB8  stp      x24, x23, [sp, #0x20]
005048ABC  stp      x22, x21, [sp, #0x30]
005048AC0  stp      x20, x19, [sp, #0x40]
005048AC4  sub      sp, sp, #0x1c0
005048AC8  cmp      w2, w3
005048ACC  b.eq     #0x5048c84
005048AD0  mov      x19, x0
005048AD4  cbz      x0, #0x5048ca4
005048AD8  ldr      w8, [x19, #0x18]
005048ADC  mov      w21, w2
005048AE0  cmp      w8, w2
005048AE4  b.ls     #0x5048ca0
005048AE8  sxtw     x24, w21
005048AEC  mov      w9, #0x38
005048AF0  madd     x25, x24, x9, x19
005048AF4  ldp      q2, q0, [x25, #0x30]
005048AF8  ldr      x9, [x25, #0x50]
005048AFC  ldr      q1, [x25, #0x20]
005048B00  mov      w20, w3
005048B04  cmp      w8, w3
005048B08  str      x9, [sp, #0x130]
005048B0C  stp      q2, q0, [sp, #0x110]
005048B10  str      q1, [sp, #0x100]
005048B14  b.ls     #0x5048ca0
005048B18  sxtw     x23, w20
005048B1C  mov      w8, #0x38
005048B20  madd     x26, x23, x8, x19
005048B24  ldr      x8, [x26, #0x50]
005048B28  ldp      q1, q0, [x26, #0x30]
005048B2C  ldr      q2, [x26, #0x20]
005048B30  mov      x22, x1
005048B34  str      x8, [sp, #0xf0]
005048B38  stp      q1, q0, [sp, #0xd0]
005048B3C  str      q2, [sp, #0xc0]
005048B40  cbz      x1, #0x5048ca4
005048B44  ldp      q1, q0, [sp, #0x110]
005048B48  ldr      x8, [sp, #0x130]
005048B4C  ldr      q2, [sp, #0x100]
005048B50  ldr      x9, [sp, #0xf0]
005048B54  stp      q1, q0, [sp, #0x90]
005048B58  ldp      q0, q3, [sp, #0xc0]
005048B5C  ldr      q1, [sp, #0xe0]
005048B60  str      q2, [sp, #0x80]
005048B64  str      x8, [sp, #0xb0]
005048B68  stp      q0, q3, [sp, #0x40]
005048B6C  str      q1, [sp, #0x60]
005048B70  str      x9, [sp, #0x70]
005048B74  ldr      x0, [x4, #0x20]
005048B78  ldrb     w8, [x0, #0x135]
005048B7C  tbnz     w8, #0, #0x5048b84
005048B80  bl       #0x3a7e60c ; 
005048B84  ldp      q0, q1, [sp, #0x80]
005048B88  ldr      q2, [sp, #0xa0]
005048B8C  ldr      x8, [x22, #0x18]
005048B90  ldr      x0, [x22, #0x40]
005048B94  ldr      x9, [sp, #0xb0]
005048B98  stp      q0, q1, [sp, #0x180]
005048B9C  ldp      q0, q1, [sp, #0x40]
005048BA0  str      q2, [sp, #0x1a0]
005048BA4  ldr      q2, [sp, #0x60]
005048BA8  ldr      x10, [sp, #0x70]
005048BAC  stp      q0, q1, [sp, #0x140]
005048BB0  str      x9, [sp, #0x1b0]
005048BB4  str      q2, [sp, #0x160]
005048BB8  str      x10, [sp, #0x170]
005048BBC  ldr      x3, [x22, #0x28]
005048BC0  add      x1, sp, #0x180
005048BC4  add      x2, sp, #0x140
005048BC8  blr      x8
005048BCC  cmp      w0, #1
005048BD0  b.lt     #0x5048c84
005048BD4  ldr      w9, [x19, #0x18]
005048BD8  cmp      w9, w21
005048BDC  b.ls     #0x5048ca0
005048BE0  add      x8, x25, #0x20
005048BE4  ldp      q2, q0, [x8, #0x10]
005048BE8  ldr      x10, [x8, #0x30]
005048BEC  ldr      q1, [x8]
005048BF0  cmp      w9, w20
005048BF4  stp      q2, q0, [sp, #0x190]
005048BF8  str      x10, [sp, #0x1b0]
005048BFC  str      q1, [sp, #0x180]
005048C00  b.ls     #0x5048ca0
005048C04  add      x21, x26, #0x20
005048C08  ldp      q2, q0, [x21, #0x10]
005048C0C  ldr      x10, [x21, #0x30]
005048C10  ldr      q1, [x21]
005048C14  mov      w9, #0x38
005048C18  madd     x9, x24, x9, x19
005048C1C  add      x0, x9, #0x30
005048C20  mov      x1, xzr
005048C24  str      x10, [x8, #0x30]
005048C28  stp      q2, q0, [x8, #0x10]
005048C2C  str      q1, [x8]
005048C30  bl       #0x382bcb8 ; 
005048C34  ldr      x8, [sp, #0x1b0]
005048C38  ldp      q1, q0, [sp, #0x190]
005048C3C  ldr      q2, [sp, #0x180]
005048C40  str      x8, [sp, #0x30]
005048C44  stp      q1, q0, [sp, #0x10]
005048C48  str      q2, [sp]
005048C4C  ldr      w8, [x19, #0x18]
005048C50  cmp      w8, w20
005048C54  b.ls     #0x5048ca0
005048C58  ldp      q0, q1, [sp]
005048C5C  ldr      x8, [sp, #0x30]
005048C60  ldr      q2, [sp, #0x20]
005048C64  mov      w9, #0x38
005048C68  madd     x9, x23, x9, x19
005048C6C  add      x0, x9, #0x30
005048C70  mov      x1, xzr
005048C74  str      x8, [x21, #0x30]
005048C78  stp      q1, q2, [x21, #0x10]
005048C7C  str      q0, [x21]
005048C80  bl       #0x382bcb8 ; 
005048C84  add      sp, sp, #0x1c0
005048C88  ldp      x20, x19, [sp, #0x40]
005048C8C  ldp      x22, x21, [sp, #0x30]
005048C90  ldp      x24, x23, [sp, #0x20]
005048C94  ldp      x26, x25, [sp, #0x10]
005048C98  ldp      x29, x30, [sp], #0x50
005048C9C  ret      
005048CA0  bl       #0x382bfc0 ; 
005048CA4  bl       #0x382bfb8 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Swap
; RVA 0x5048CA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005048CA8  sub      sp, sp, #0xb0
005048CAC  str      x30, [sp, #0x80]
005048CB0  stp      x22, x21, [sp, #0x90]
005048CB4  stp      x20, x19, [sp, #0xa0]
005048CB8  cmp      w1, w2
005048CBC  b.eq     #0x5048d94
005048CC0  mov      x19, x0
005048CC4  cbz      x0, #0x5048dac
005048CC8  ldr      w9, [x19, #0x18]
005048CCC  cmp      w9, w1
005048CD0  b.ls     #0x5048da8
005048CD4  sxtw     x8, w1
005048CD8  mov      w10, #0x38
005048CDC  madd     x10, x8, x10, x19
005048CE0  ldp      q2, q0, [x10, #0x30]
005048CE4  ldr      x11, [x10, #0x50]
005048CE8  ldr      q1, [x10, #0x20]
005048CEC  mov      w20, w2
005048CF0  cmp      w9, w2
005048CF4  str      x11, [sp, #0x70]
005048CF8  stp      q2, q0, [sp, #0x50]
005048CFC  str      q1, [sp, #0x40]
005048D00  b.ls     #0x5048da8
005048D04  add      x9, x10, #0x20
005048D08  sxtw     x21, w20
005048D0C  mov      w10, #0x38
005048D10  add      x11, x19, #0x20
005048D14  madd     x22, x21, x10, x11
005048D18  ldp      q2, q0, [x22, #0x10]
005048D1C  ldr      x12, [x22, #0x30]
005048D20  ldr      q1, [x22]
005048D24  nop      
005048D28  madd     x8, x8, x10, x11
005048D2C  add      x0, x8, #0x10
005048D30  mov      x1, xzr
005048D34  str      x12, [x9, #0x30]
005048D38  stp      q2, q0, [x9, #0x10]
005048D3C  str      q1, [x9]
005048D40  bl       #0x382bcb8 ; 
005048D44  ldr      x8, [sp, #0x70]
005048D48  ldp      q1, q0, [sp, #0x50]
005048D4C  ldr      q2, [sp, #0x40]
005048D50  str      x8, [sp, #0x30]
005048D54  stp      q1, q0, [sp, #0x10]
005048D58  str      q2, [sp]
005048D5C  ldr      w8, [x19, #0x18]
005048D60  cmp      w8, w20
005048D64  b.ls     #0x5048da8
005048D68  ldp      q0, q1, [sp]
005048D6C  ldr      x8, [sp, #0x30]
005048D70  ldr      q2, [sp, #0x20]
005048D74  mov      w9, #0x38
005048D78  madd     x9, x21, x9, x19
005048D7C  add      x0, x9, #0x30
005048D80  mov      x1, xzr
005048D84  str      x8, [x22, #0x30]
005048D88  stp      q1, q2, [x22, #0x10]
005048D8C  str      q0, [x22]
005048D90  bl       #0x382bcb8 ; 
005048D94  ldp      x20, x19, [sp, #0xa0]
005048D98  ldp      x22, x21, [sp, #0x90]
005048D9C  ldr      x30, [sp, #0x80]
005048DA0  add      sp, sp, #0xb0
005048DA4  ret      
005048DA8  bl       #0x382bfc0 ; 
005048DAC  bl       #0x382bfb8 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$IntrospectiveSort
; RVA 0x5048DB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005048DB0  cmp      w2, #2
005048DB4  b.lt     #0x5048e70
005048DB8  str      x30, [sp, #-0x40]!
005048DBC  stp      x24, x23, [sp, #0x10]
005048DC0  stp      x22, x21, [sp, #0x20]
005048DC4  stp      x20, x19, [sp, #0x30]
005048DC8  mov      w20, w1
005048DCC  mov      x21, x0
005048DD0  mov      w0, w2
005048DD4  mov      x1, xzr
005048DD8  mov      x23, x4
005048DDC  mov      x19, x3
005048DE0  mov      w22, w2
005048DE4  bl       #0x7bacfa8 ; System.Collections.Generic.IntrospectiveSortUtilities$$FloorLog2PlusOne
005048DE8  ldr      x8, [x23, #0x20]
005048DEC  mov      w24, w0
005048DF0  ldrb     w9, [x8, #0x135]
005048DF4  tbnz     w9, #0, #0x5048e04
005048DF8  mov      x0, x8
005048DFC  bl       #0x3a7e60c ; 
005048E00  mov      x8, x0
005048E04  ldr      x8, [x8, #0xc0]
005048E08  ldr      x0, [x8, #0x48]
005048E0C  ldrb     w8, [x0, #0x135]
005048E10  tbnz     w8, #0, #0x5048e18
005048E14  bl       #0x3a7e60c ; 
005048E18  ldr      w8, [x0, #0xe0]
005048E1C  cbnz     w8, #0x5048e24
005048E20  bl       #0x382be8c ; 
005048E24  ldr      x0, [x23, #0x20]
005048E28  add      w9, w20, w22
005048E2C  sub      w23, w9, #1
005048E30  lsl      w22, w24, #1
005048E34  ldrb     w8, [x0, #0x135]
005048E38  tbnz     w8, #0, #0x5048e40
005048E3C  bl       #0x3a7e60c ; 
005048E40  ldr      x8, [x0, #0xc0]
005048E44  mov      x0, x21
005048E48  mov      w1, w20
005048E4C  mov      w2, w23
005048E50  ldr      x5, [x8, #0x68]
005048E54  mov      w3, w22
005048E58  mov      x4, x19
005048E5C  ldp      x20, x19, [sp, #0x30]
005048E60  ldp      x22, x21, [sp, #0x20]
005048E64  ldp      x24, x23, [sp, #0x10]
005048E68  ldr      x30, [sp], #0x40
005048E6C  b        #0x5048e74 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$IntroSort
005048E70  ret      

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$IntroSort
; RVA 0x5048E74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005048E74  stp      x30, x25, [sp, #-0x40]!
005048E78  stp      x24, x23, [sp, #0x10]
005048E7C  stp      x22, x21, [sp, #0x20]
005048E80  stp      x20, x19, [sp, #0x30]
005048E84  cmp      w2, w1
005048E88  b.le     #0x5048fd0
005048E8C  mov      x23, x5
005048E90  mov      x19, x4
005048E94  mov      w20, w2
005048E98  mov      w22, w1
005048E9C  mov      x21, x0
005048EA0  sub      w24, w3, #1
005048EA4  sub      w8, w20, w22
005048EA8  add      w9, w8, #1
005048EAC  cmp      w9, #0x10
005048EB0  b.le     #0x5048f68
005048EB4  cmn      w24, #1
005048EB8  b.eq     #0x5048fe4
005048EBC  ldr      x0, [x23, #0x20]
005048EC0  ldrb     w8, [x0, #0x135]
005048EC4  tbnz     w8, #0, #0x5048ecc
005048EC8  bl       #0x3a7e60c ; 
005048ECC  ldr      x8, [x0, #0xc0]
005048ED0  ldr      x0, [x8, #0x48]
005048ED4  ldrb     w8, [x0, #0x135]
005048ED8  tbnz     w8, #0, #0x5048ee0
005048EDC  bl       #0x3a7e60c ; 
005048EE0  ldr      w8, [x0, #0xe0]
005048EE4  cbnz     w8, #0x5048eec
005048EE8  bl       #0x382be8c ; 
005048EEC  ldr      x0, [x23, #0x20]
005048EF0  ldrb     w8, [x0, #0x135]
005048EF4  tbnz     w8, #0, #0x5048efc
005048EF8  bl       #0x3a7e60c ; 
005048EFC  ldr      x8, [x0, #0xc0]
005048F00  mov      x0, x21
005048F04  mov      w1, w22
005048F08  mov      w2, w20
005048F0C  ldr      x4, [x8, #0x88]
005048F10  mov      x3, x19
005048F14  bl       #0x5049184 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$PickPivotAndPartition
005048F18  ldr      x8, [x23, #0x20]
005048F1C  mov      w25, w0
005048F20  ldrb     w9, [x8, #0x135]
005048F24  tbnz     w9, #0, #0x5048f34
005048F28  mov      x0, x8
005048F2C  bl       #0x3a7e60c ; 
005048F30  mov      x8, x0
005048F34  ldr      x8, [x8, #0xc0]
005048F38  add      w1, w25, #1
005048F3C  mov      x0, x21
005048F40  mov      w2, w20
005048F44  ldr      x5, [x8, #0x68]
005048F48  mov      w3, w24
005048F4C  mov      x4, x19
005048F50  bl       #0x5048e74 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$IntroSort
005048F54  sub      w20, w25, #1
005048F58  cmp      w20, w22
005048F5C  sub      w24, w24, #1
005048F60  b.gt     #0x5048ea4
005048F64  b        #0x5048fd0 ; 
005048F68  cbz      w8, #0x5048fd0
005048F6C  cmp      w8, #2
005048F70  b.eq     #0x5049050
005048F74  cmp      w8, #1
005048F78  b.ne     #0x5049118
005048F7C  ldr      x0, [x23, #0x20]
005048F80  ldrb     w8, [x0, #0x135]
005048F84  tbnz     w8, #0, #0x5048f8c
005048F88  bl       #0x3a7e60c ; 
005048F8C  ldr      x8, [x0, #0xc0]
005048F90  ldr      x0, [x8, #0x48]
005048F94  ldrb     w8, [x0, #0x135]
005048F98  tbnz     w8, #0, #0x5048fa0
005048F9C  bl       #0x3a7e60c ; 
005048FA0  ldr      w8, [x0, #0xe0]
005048FA4  cbnz     w8, #0x5048fac
005048FA8  bl       #0x382be8c ; 
005048FAC  ldr      x0, [x23, #0x20]
005048FB0  ldrb     w8, [x0, #0x135]
005048FB4  tbnz     w8, #0, #0x5048fbc
005048FB8  bl       #0x3a7e60c ; 
005048FBC  ldr      x8, [x0, #0xc0]
005048FC0  mov      x0, x21
005048FC4  mov      x1, x19
005048FC8  mov      w2, w22
005048FCC  b        #0x50490fc ; 
005048FD0  ldp      x20, x19, [sp, #0x30]
005048FD4  ldp      x22, x21, [sp, #0x20]
005048FD8  ldp      x24, x23, [sp, #0x10]
005048FDC  ldp      x30, x25, [sp], #0x40
005048FE0  ret      
005048FE4  ldr      x0, [x23, #0x20]
005048FE8  ldrb     w8, [x0, #0x135]
005048FEC  tbnz     w8, #0, #0x5048ff4
005048FF0  bl       #0x3a7e60c ; 
005048FF4  ldr      x8, [x0, #0xc0]
005048FF8  ldr      x0, [x8, #0x48]
005048FFC  ldrb     w8, [x0, #0x135]
005049000  tbnz     w8, #0, #0x5049008
005049004  bl       #0x3a7e60c ; 
005049008  ldr      w8, [x0, #0xe0]
00504900C  cbnz     w8, #0x5049014
005049010  bl       #0x382be8c ; 
005049014  ldr      x0, [x23, #0x20]
005049018  ldrb     w8, [x0, #0x135]
00504901C  tbnz     w8, #0, #0x5049024
005049020  bl       #0x3a7e60c ; 
005049024  ldr      x8, [x0, #0xc0]
005049028  mov      x0, x21
00504902C  mov      w1, w22
005049030  mov      w2, w20
005049034  ldr      x4, [x8, #0x80]
005049038  mov      x3, x19
00504903C  ldp      x20, x19, [sp, #0x30]
005049040  ldp      x22, x21, [sp, #0x20]
005049044  ldp      x24, x23, [sp, #0x10]
005049048  ldp      x30, x25, [sp], #0x40
00504904C  b        #0x5049548 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Heapsort
005049050  ldr      x0, [x23, #0x20]
005049054  ldrb     w8, [x0, #0x135]
005049058  tbnz     w8, #0, #0x5049060
00504905C  bl       #0x3a7e60c ; 
005049060  ldr      x8, [x0, #0xc0]
005049064  ldr      x0, [x8, #0x48]
005049068  ldrb     w8, [x0, #0x135]
00504906C  tbnz     w8, #0, #0x5049074
005049070  bl       #0x3a7e60c ; 
005049074  ldr      w8, [x0, #0xe0]
005049078  cbnz     w8, #0x5049080
00504907C  bl       #0x382be8c ; 
005049080  ldr      x0, [x23, #0x20]
005049084  sub      w24, w20, #1
005049088  ldrb     w8, [x0, #0x135]
00504908C  tbnz     w8, #0, #0x5049094
005049090  bl       #0x3a7e60c ; 
005049094  ldr      x8, [x0, #0xc0]
005049098  mov      x0, x21
00504909C  mov      x1, x19
0050490A0  mov      w2, w22
0050490A4  ldr      x4, [x8, #0x70]
0050490A8  mov      w3, w24
0050490AC  bl       #0x5048ab0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$SwapIfGreater
0050490B0  ldr      x0, [x23, #0x20]
0050490B4  ldrb     w8, [x0, #0x135]
0050490B8  tbnz     w8, #0, #0x50490c0
0050490BC  bl       #0x3a7e60c ; 
0050490C0  ldr      x8, [x0, #0xc0]
0050490C4  mov      x0, x21
0050490C8  mov      x1, x19
0050490CC  mov      w2, w22
0050490D0  ldr      x4, [x8, #0x70]
0050490D4  mov      w3, w20
0050490D8  bl       #0x5048ab0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$SwapIfGreater
0050490DC  ldr      x0, [x23, #0x20]
0050490E0  ldrb     w8, [x0, #0x135]
0050490E4  tbnz     w8, #0, #0x50490ec
0050490E8  bl       #0x3a7e60c ; 
0050490EC  ldr      x8, [x0, #0xc0]
0050490F0  mov      x0, x21
0050490F4  mov      x1, x19
0050490F8  mov      w2, w24
0050490FC  ldr      x4, [x8, #0x70]
005049100  mov      w3, w20
005049104  ldp      x20, x19, [sp, #0x30]
005049108  ldp      x22, x21, [sp, #0x20]
00504910C  ldp      x24, x23, [sp, #0x10]
005049110  ldp      x30, x25, [sp], #0x40
005049114  b        #0x5048ab0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$SwapIfGreater
005049118  ldr      x0, [x23, #0x20]
00504911C  ldrb     w8, [x0, #0x135]
005049120  tbnz     w8, #0, #0x5049128
005049124  bl       #0x3a7e60c ; 
005049128  ldr      x8, [x0, #0xc0]
00504912C  ldr      x0, [x8, #0x48]
005049130  ldrb     w8, [x0, #0x135]
005049134  tbnz     w8, #0, #0x504913c
005049138  bl       #0x3a7e60c ; 
00504913C  ldr      w8, [x0, #0xe0]
005049140  cbnz     w8, #0x5049148
005049144  bl       #0x382be8c ; 
005049148  ldr      x0, [x23, #0x20]
00504914C  ldrb     w8, [x0, #0x135]
005049150  tbnz     w8, #0, #0x5049158
005049154  bl       #0x3a7e60c ; 
005049158  ldr      x8, [x0, #0xc0]
00504915C  mov      x0, x21
005049160  mov      w1, w22
005049164  mov      w2, w20
005049168  ldr      x4, [x8, #0x78]
00504916C  mov      x3, x19
005049170  ldp      x20, x19, [sp, #0x30]
005049174  ldp      x22, x21, [sp, #0x20]
005049178  ldp      x24, x23, [sp, #0x10]
00504917C  ldp      x30, x25, [sp], #0x40
005049180  b        #0x50499e0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$InsertionSort

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$PickPivotAndPartition
; RVA 0x5049184; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005049184  str      x29, [sp, #-0x50]!
005049188  stp      x30, x25, [sp, #0x10]
00504918C  stp      x24, x23, [sp, #0x20]
005049190  stp      x22, x21, [sp, #0x30]
005049194  stp      x20, x19, [sp, #0x40]
005049198  sub      sp, sp, #0x240
00504919C  movi     v0.2d, #0000000000000000
0050491A0  str      xzr, [sp, #0x1b0]
0050491A4  stp      q0, q0, [sp, #0x190]
0050491A8  str      q0, [sp, #0x180]
0050491AC  mov      x20, x0
0050491B0  ldr      x0, [x4, #0x20]
0050491B4  sub      w9, w2, w1
0050491B8  cmp      w9, #0
0050491BC  mov      x21, x4
0050491C0  ldrb     w8, [x0, #0x135]
0050491C4  mov      x22, x3
0050491C8  mov      w23, w2
0050491CC  mov      w19, w1
0050491D0  cinc     w24, w9, lt
0050491D4  tbnz     w8, #0, #0x50491dc
0050491D8  bl       #0x3a7e60c ; 
0050491DC  ldr      x8, [x0, #0xc0]
0050491E0  ldr      x0, [x8, #0x48]
0050491E4  ldrb     w8, [x0, #0x135]
0050491E8  tbnz     w8, #0, #0x50491f0
0050491EC  bl       #0x3a7e60c ; 
0050491F0  ldr      w8, [x0, #0xe0]
0050491F4  add      w24, w19, w24, asr #1
0050491F8  cbnz     w8, #0x5049200
0050491FC  bl       #0x382be8c ; 
005049200  ldr      x0, [x21, #0x20]
005049204  ldrb     w8, [x0, #0x135]
005049208  tbnz     w8, #0, #0x5049210
00504920C  bl       #0x3a7e60c ; 
005049210  ldr      x8, [x0, #0xc0]
005049214  mov      x0, x20
005049218  mov      x1, x22
00504921C  mov      w2, w19
005049220  ldr      x4, [x8, #0x70]
005049224  mov      w3, w24
005049228  bl       #0x5048ab0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$SwapIfGreater
00504922C  ldr      x0, [x21, #0x20]
005049230  ldrb     w8, [x0, #0x135]
005049234  tbnz     w8, #0, #0x504923c
005049238  bl       #0x3a7e60c ; 
00504923C  ldr      x8, [x0, #0xc0]
005049240  mov      x0, x20
005049244  mov      x1, x22
005049248  mov      w2, w19
00504924C  ldr      x4, [x8, #0x70]
005049250  mov      w3, w23
005049254  bl       #0x5048ab0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$SwapIfGreater
005049258  ldr      x0, [x21, #0x20]
00504925C  ldrb     w8, [x0, #0x135]
005049260  tbnz     w8, #0, #0x5049268
005049264  bl       #0x3a7e60c ; 
005049268  ldr      x8, [x0, #0xc0]
00504926C  mov      x0, x20
005049270  mov      x1, x22
005049274  mov      w2, w24
005049278  ldr      x4, [x8, #0x70]
00504927C  mov      w3, w23
005049280  bl       #0x5048ab0 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$SwapIfGreater
005049284  cbz      x20, #0x5049544
005049288  ldr      w8, [x20, #0x18]
00504928C  cmp      w24, w8
005049290  b.hs     #0x5049540
005049294  mov      w8, #0x38
005049298  smaddl   x8, w24, w8, x20
00504929C  ldr      x9, [x8, #0x50]
0050492A0  ldp      q1, q0, [x8, #0x30]
0050492A4  ldr      q2, [x8, #0x20]
0050492A8  sub      w23, w23, #1
0050492AC  str      x9, [sp, #0x1b0]
0050492B0  stp      q1, q0, [sp, #0x190]
0050492B4  str      q2, [sp, #0x180]
0050492B8  ldr      x0, [x21, #0x20]
0050492BC  ldrb     w8, [x0, #0x135]
0050492C0  tbnz     w8, #0, #0x50492c8
0050492C4  bl       #0x3a7e60c ; 
0050492C8  mov      x0, x20
0050492CC  mov      w1, w24
0050492D0  mov      w2, w23
0050492D4  bl       #0x5048ca8 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Swap
0050492D8  cmp      w23, w19
0050492DC  b.le     #0x50494d0
0050492E0  mov      w25, #0x38
0050492E4  mov      w24, w23
0050492E8  ldr      w8, [x20, #0x18]
0050492EC  add      w19, w19, #1
0050492F0  cmp      w19, w8
0050492F4  b.hs     #0x5049540
0050492F8  smaddl   x8, w19, w25, x20
0050492FC  ldp      q3, q4, [x8, #0x20]
005049300  ldr      q5, [x8, #0x40]
005049304  ldr      x8, [x8, #0x50]
005049308  ldp      q0, q1, [sp, #0x180]
00504930C  ldr      q2, [sp, #0x1a0]
005049310  stp      q4, q5, [sp, #0x150]
005049314  str      x8, [sp, #0x170]
005049318  ldr      x8, [sp, #0x1b0]
00504931C  stp      q0, q1, [sp, #0x100]
005049320  str      q2, [sp, #0x120]
005049324  str      q3, [sp, #0x140]
005049328  str      x8, [sp, #0x130]
00504932C  cbz      x22, #0x5049544
005049330  ldp      q1, q0, [sp, #0x150]
005049334  ldr      x8, [sp, #0x170]
005049338  ldr      q2, [sp, #0x140]
00504933C  ldr      x9, [sp, #0x130]
005049340  stp      q1, q0, [sp, #0xd0]
005049344  ldp      q0, q3, [sp, #0x100]
005049348  ldr      q1, [sp, #0x120]
00504934C  str      q2, [sp, #0xc0]
005049350  str      x8, [sp, #0xf0]
005049354  stp      q0, q3, [sp, #0x80]
005049358  str      q1, [sp, #0xa0]
00504935C  str      x9, [sp, #0xb0]
005049360  ldr      x0, [x21, #0x20]
005049364  ldrb     w8, [x0, #0x135]
005049368  tbnz     w8, #0, #0x5049370
00504936C  bl       #0x3a7e60c ; 
005049370  ldp      q0, q1, [sp, #0xc0]
005049374  ldr      q2, [sp, #0xe0]
005049378  ldr      x8, [x22, #0x18]
00504937C  ldr      x0, [x22, #0x40]
005049380  ldr      x9, [sp, #0xf0]
005049384  stp      q0, q1, [sp, #0x200]
005049388  ldp      q0, q1, [sp, #0x80]
00504938C  str      q2, [sp, #0x220]
005049390  ldr      q2, [sp, #0xa0]
005049394  ldr      x10, [sp, #0xb0]
005049398  stp      q0, q1, [sp, #0x1c0]
00504939C  str      x9, [sp, #0x230]
0050493A0  str      q2, [sp, #0x1e0]
0050493A4  str      x10, [sp, #0x1f0]
0050493A8  ldr      x3, [x22, #0x28]
0050493AC  add      x1, sp, #0x200
0050493B0  add      x2, sp, #0x1c0
0050493B4  blr      x8
0050493B8  tbnz     w0, #0x1f, #0x50492e8
0050493BC  ldp      q0, q1, [sp, #0x180]
0050493C0  ldr      q2, [sp, #0x1a0]
0050493C4  ldr      x8, [sp, #0x1b0]
0050493C8  sub      w24, w24, #1
0050493CC  stp      q0, q1, [sp, #0x140]
0050493D0  str      q2, [sp, #0x160]
0050493D4  str      x8, [sp, #0x170]
0050493D8  ldr      w8, [x20, #0x18]
0050493DC  cmp      w24, w8
0050493E0  b.hs     #0x5049540
0050493E4  smaddl   x8, w24, w25, x20
0050493E8  ldp      q0, q1, [sp, #0x140]
0050493EC  ldr      q2, [sp, #0x160]
0050493F0  ldp      q3, q4, [x8, #0x20]
0050493F4  ldr      q5, [x8, #0x40]
0050493F8  ldr      x8, [x8, #0x50]
0050493FC  ldr      x9, [sp, #0x170]
005049400  stp      q0, q1, [sp, #0x40]
005049404  str      q2, [sp, #0x60]
005049408  str      x8, [sp, #0x30]
00504940C  stp      q4, q5, [sp, #0x10]
005049410  str      q3, [sp]
005049414  str      x9, [sp, #0x70]
005049418  ldr      x0, [x21, #0x20]
00504941C  ldrb     w8, [x0, #0x135]
005049420  tbnz     w8, #0, #0x5049428
005049424  bl       #0x3a7e60c ; 
005049428  ldp      q0, q1, [sp, #0x40]
00504942C  ldr      q2, [sp, #0x60]
005049430  ldr      x8, [x22, #0x18]
005049434  ldr      x0, [x22, #0x40]
005049438  ldr      x9, [sp, #0x70]
00504943C  stp      q0, q1, [sp, #0x200]
005049440  ldp      q0, q1, [sp]
005049444  str      q2, [sp, #0x220]
005049448  ldr      q2, [sp, #0x20]
00504944C  ldr      x10, [sp, #0x30]
005049450  stp      q0, q1, [sp, #0x1c0]
005049454  str      x9, [sp, #0x230]
005049458  str      q2, [sp, #0x1e0]
00504945C  str      x10, [sp, #0x1f0]
005049460  ldr      x3, [x22, #0x28]
005049464  add      x1, sp, #0x200
005049468  add      x2, sp, #0x1c0
00504946C  blr      x8
005049470  tbnz     w0, #0x1f, #0x50493bc
005049474  cmp      w19, w24
005049478  b.ge     #0x50494d0
00504947C  ldr      x0, [x21, #0x20]
005049480  ldrb     w8, [x0, #0x135]
005049484  tbnz     w8, #0, #0x504948c
005049488  bl       #0x3a7e60c ; 
00504948C  ldr      x8, [x0, #0xc0]
005049490  ldr      x0, [x8, #0x48]
005049494  ldrb     w8, [x0, #0x135]
005049498  tbnz     w8, #0, #0x50494a0
00504949C  bl       #0x3a7e60c ; 
0050494A0  ldr      w8, [x0, #0xe0]
0050494A4  cbnz     w8, #0x50494ac
0050494A8  bl       #0x382be8c ; 
0050494AC  ldr      x0, [x21, #0x20]
0050494B0  ldrb     w8, [x0, #0x135]
0050494B4  tbnz     w8, #0, #0x50494bc
0050494B8  bl       #0x3a7e60c ; 
0050494BC  mov      x0, x20
0050494C0  mov      w1, w19
0050494C4  mov      w2, w24
0050494C8  bl       #0x5048ca8 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Swap
0050494CC  b        #0x50492e8 ; 
0050494D0  ldr      x0, [x21, #0x20]
0050494D4  ldrb     w8, [x0, #0x135]
0050494D8  tbnz     w8, #0, #0x50494e0
0050494DC  bl       #0x3a7e60c ; 
0050494E0  ldr      x8, [x0, #0xc0]
0050494E4  ldr      x0, [x8, #0x48]
0050494E8  ldrb     w8, [x0, #0x135]
0050494EC  tbnz     w8, #0, #0x50494f4
0050494F0  bl       #0x3a7e60c ; 
0050494F4  ldr      w8, [x0, #0xe0]
0050494F8  cbnz     w8, #0x5049500
0050494FC  bl       #0x382be8c ; 
005049500  ldr      x0, [x21, #0x20]
005049504  ldrb     w8, [x0, #0x135]
005049508  tbnz     w8, #0, #0x5049510
00504950C  bl       #0x3a7e60c ; 
005049510  mov      x0, x20
005049514  mov      w1, w19
005049518  mov      w2, w23
00504951C  bl       #0x5048ca8 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Swap
005049520  mov      w0, w19
005049524  add      sp, sp, #0x240
005049528  ldp      x20, x19, [sp, #0x40]
00504952C  ldp      x22, x21, [sp, #0x30]
005049530  ldp      x24, x23, [sp, #0x20]
005049534  ldp      x30, x25, [sp, #0x10]
005049538  ldr      x29, [sp], #0x50
00504953C  ret      
005049540  bl       #0x382bfc0 ; 
005049544  bl       #0x382bfb8 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Heapsort
; RVA 0x5049548; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005049548  stp      x30, x25, [sp, #-0x40]!
00504954C  stp      x24, x23, [sp, #0x10]
005049550  stp      x22, x21, [sp, #0x20]
005049554  stp      x20, x19, [sp, #0x30]
005049558  sub      w8, w2, w1
00504955C  add      w24, w8, #1
005049560  cmp      w24, #2
005049564  b.lt     #0x5049688
005049568  mov      x19, x4
00504956C  mov      x20, x3
005049570  mov      w21, w2
005049574  mov      w22, w1
005049578  mov      x23, x0
00504957C  lsr      w25, w24, #1
005049580  ldr      x0, [x19, #0x20]
005049584  ldrb     w8, [x0, #0x135]
005049588  tbnz     w8, #0, #0x5049590
00504958C  bl       #0x3a7e60c ; 
005049590  ldr      x8, [x0, #0xc0]
005049594  ldr      x0, [x8, #0x48]
005049598  ldrb     w8, [x0, #0x135]
00504959C  tbnz     w8, #0, #0x50495a4
0050495A0  bl       #0x3a7e60c ; 
0050495A4  ldr      w8, [x0, #0xe0]
0050495A8  cbnz     w8, #0x50495b0
0050495AC  bl       #0x382be8c ; 
0050495B0  ldr      x0, [x19, #0x20]
0050495B4  ldrb     w8, [x0, #0x135]
0050495B8  tbnz     w8, #0, #0x50495c0
0050495BC  bl       #0x3a7e60c ; 
0050495C0  ldr      x8, [x0, #0xc0]
0050495C4  mov      x0, x23
0050495C8  mov      w1, w25
0050495CC  mov      w2, w24
0050495D0  ldr      x5, [x8, #0x98]
0050495D4  mov      w3, w22
0050495D8  mov      x4, x20
0050495DC  bl       #0x504969c ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$DownHeap
0050495E0  subs     w25, w25, #1
0050495E4  b.gt     #0x5049580
0050495E8  cmp      w24, #2
0050495EC  b.lt     #0x5049688
0050495F0  neg      w24, w22
0050495F4  ldr      x0, [x19, #0x20]
0050495F8  ldrb     w8, [x0, #0x135]
0050495FC  tbnz     w8, #0, #0x5049604
005049600  bl       #0x3a7e60c ; 
005049604  ldr      x8, [x0, #0xc0]
005049608  ldr      x0, [x8, #0x48]
00504960C  ldrb     w8, [x0, #0x135]
005049610  tbnz     w8, #0, #0x5049618
005049614  bl       #0x3a7e60c ; 
005049618  ldr      w8, [x0, #0xe0]
00504961C  cbnz     w8, #0x5049624
005049620  bl       #0x382be8c ; 
005049624  ldr      x0, [x19, #0x20]
005049628  ldrb     w8, [x0, #0x135]
00504962C  tbnz     w8, #0, #0x5049634
005049630  bl       #0x3a7e60c ; 
005049634  mov      x0, x23
005049638  mov      w1, w22
00504963C  mov      w2, w21
005049640  bl       #0x5048ca8 ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$Swap
005049644  ldr      x0, [x19, #0x20]
005049648  ldrb     w8, [x0, #0x135]
00504964C  tbnz     w8, #0, #0x5049654
005049650  bl       #0x3a7e60c ; 
005049654  ldr      x8, [x0, #0xc0]
005049658  add      w2, w24, w21
00504965C  mov      w1, #1
005049660  mov      x0, x23
005049664  ldr      x5, [x8, #0x98]
005049668  mov      w3, w22
00504966C  mov      x4, x20
005049670  bl       #0x504969c ; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$DownHeap
005049674  sub      w21, w21, #1
005049678  add      w8, w24, w21
00504967C  add      w8, w8, #2
005049680  cmp      w8, #2
005049684  b.gt     #0x50495f4
005049688  ldp      x20, x19, [sp, #0x30]
00504968C  ldp      x22, x21, [sp, #0x20]
005049690  ldp      x24, x23, [sp, #0x10]
005049694  ldp      x30, x25, [sp], #0x40
005049698  ret      

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$DownHeap
; RVA 0x504969C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00504969C  stp      x29, x30, [sp, #-0x60]!
0050496A0  stp      x28, x27, [sp, #0x10]
0050496A4  stp      x26, x25, [sp, #0x20]
0050496A8  stp      x24, x23, [sp, #0x30]
0050496AC  stp      x22, x21, [sp, #0x40]
0050496B0  stp      x20, x19, [sp, #0x50]
0050496B4  sub      sp, sp, #0x2d0
0050496B8  cbz      x0, #0x50499dc
0050496BC  ldr      w8, [x0, #0x18]
0050496C0  sub      w25, w3, #1
0050496C4  add      w29, w25, w1
0050496C8  mov      w24, w1
0050496CC  mov      x19, x0
0050496D0  cmp      w29, w8
0050496D4  b.hs     #0x50499d8
0050496D8  mov      w26, #0x38
0050496DC  smaddl   x9, w29, w26, x19
0050496E0  cmp      w2, #0
0050496E4  ldp      q0, q1, [x9, #0x20]
0050496E8  ldr      x11, [x9, #0x50]
0050496EC  ldr      q2, [x9, #0x40]
0050496F0  cinc     w10, w2, lt
0050496F4  asr      w27, w10, #1
0050496F8  mov      w23, w2
0050496FC  cmp      w27, w24
005049700  str      x11, [sp, #0x240]
005049704  stp      q1, q2, [sp, #0x220]
005049708  str      q0, [sp, #0x210]
00504970C  b.ge     #0x5049718
005049710  sxtw     x9, w29
005049714  b        #0x504996c ; 
005049718  mov      x20, x5
00504971C  mov      x21, x4
005049720  str      w3, [sp, #0xc]
005049724  lsl      w28, w24, #1
005049728  cmp      w28, w23
00504972C  b.ge     #0x5049818
005049730  ldr      w8, [sp, #0xc]
005049734  ldr      w9, [x19, #0x18]
005049738  add      w8, w28, w8
00504973C  sub      w10, w8, #1
005049740  cmp      w10, w9
005049744  b.hs     #0x50499d8
005049748  smaddl   x10, w10, w26, x19
00504974C  ldp      q2, q0, [x10, #0x30]
005049750  ldr      x11, [x10, #0x50]
005049754  ldr      q1, [x10, #0x20]
005049758  cmp      w8, w9
00504975C  stp      q2, q0, [sp, #0x1e0]
005049760  str      x11, [sp, #0x200]
005049764  str      q1, [sp, #0x1d0]
005049768  b.hs     #0x50499d8
00504976C  smaddl   x8, w8, w26, x19
005049770  ldr      x9, [x8, #0x50]
005049774  ldp      q1, q0, [x8, #0x30]
005049778  ldr      q2, [x8, #0x20]
00504977C  str      x9, [sp, #0x1c0]
005049780  stp      q1, q0, [sp, #0x1a0]
005049784  str      q2, [sp, #0x190]
005049788  cbz      x21, #0x50499dc
00504978C  ldp      q1, q0, [sp, #0x1e0]
005049790  ldr      x8, [sp, #0x200]
005049794  ldr      q2, [sp, #0x1d0]
005049798  ldr      x9, [sp, #0x1c0]
00504979C  stp      q1, q0, [sp, #0x160]
0050497A0  ldp      q0, q3, [sp, #0x190]
0050497A4  ldr      q1, [sp, #0x1b0]
0050497A8  str      q2, [sp, #0x150]
0050497AC  str      x8, [sp, #0x180]
0050497B0  stp      q0, q3, [sp, #0x110]
0050497B4  str      q1, [sp, #0x130]
0050497B8  str      x9, [sp, #0x140]
0050497BC  ldr      x0, [x20, #0x20]
0050497C0  ldrb     w8, [x0, #0x135]
0050497C4  tbnz     w8, #0, #0x50497cc
0050497C8  bl       #0x3a7e60c ; 
0050497CC  ldp      q0, q1, [sp, #0x150]
0050497D0  ldr      q2, [sp, #0x170]
0050497D4  ldr      x8, [x21, #0x18]
0050497D8  ldr      x0, [x21, #0x40]
0050497DC  ldr      x9, [sp, #0x180]
0050497E0  stp      q0, q1, [sp, #0x290]
0050497E4  ldp      q0, q1, [sp, #0x110]
0050497E8  str      q2, [sp, #0x2b0]
0050497EC  ldr      q2, [sp, #0x130]
0050497F0  ldr      x10, [sp, #0x140]
0050497F4  stp      q0, q1, [sp, #0x250]
0050497F8  str      x9, [sp, #0x2c0]
0050497FC  str      q2, [sp, #0x270]
005049800  str      x10, [sp, #0x280]
005049804  ldr      x3, [x21, #0x28]
005049808  add      x1, sp, #0x290
00504980C  add      x2, sp, #0x250
005049810  blr      x8
005049814  orr      w28, w28, w0, lsr #31
005049818  ldp      q0, q1, [sp, #0x210]
00504981C  ldr      q2, [sp, #0x230]
005049820  ldr      x8, [sp, #0x240]
005049824  add      w29, w25, w28
005049828  stp      q0, q1, [sp, #0x1d0]
00504982C  str      q2, [sp, #0x1f0]
005049830  str      x8, [sp, #0x200]
005049834  ldr      w8, [x19, #0x18]
005049838  cmp      w29, w8
00504983C  b.hs     #0x50499d8
005049840  smaddl   x22, w29, w26, x19
005049844  ldr      x8, [x22, #0x50]
005049848  ldp      q1, q0, [x22, #0x30]
00504984C  ldr      q2, [x22, #0x20]
005049850  str      x8, [sp, #0x1c0]
005049854  stp      q1, q0, [sp, #0x1a0]
005049858  str      q2, [sp, #0x190]
00504985C  cbz      x21, #0x50499dc
005049860  ldp      q1, q0, [sp, #0x1e0]
005049864  ldr      x8, [sp, #0x200]
005049868  ldr      q2, [sp, #0x1d0]
00504986C  ldr      x9, [sp, #0x1c0]
005049870  stp      q1, q0, [sp, #0xe0]
005049874  ldp      q0, q3, [sp, #0x190]
005049878  ldr      q1, [sp, #0x1b0]
00504987C  str      q2, [sp, #0xd0]
005049880  str      x8, [sp, #0x100]
005049884  stp      q0, q3, [sp, #0x90]
005049888  str      q1, [sp, #0xb0]
00504988C  str      x9, [sp, #0xc0]
005049890  ldr      x0, [x20, #0x20]
005049894  ldrb     w8, [x0, #0x135]
005049898  tbnz     w8, #0, #0x50498a0
00504989C  bl       #0x3a7e60c ; 
0050498A0  ldp      q0, q1, [sp, #0xd0]
0050498A4  ldr      q2, [sp, #0xf0]
0050498A8  ldr      x8, [x21, #0x18]
0050498AC  ldr      x0, [x21, #0x40]
0050498B0  ldr      x9, [sp, #0x100]
0050498B4  stp      q0, q1, [sp, #0x290]
0050498B8  ldp      q0, q1, [sp, #0x90]
0050498BC  str      q2, [sp, #0x2b0]
0050498C0  ldr      q2, [sp, #0xb0]
0050498C4  ldr      x10, [sp, #0xc0]
0050498C8  stp      q0, q1, [sp, #0x250]
0050498CC  str      x9, [sp, #0x2c0]
0050498D0  str      q2, [sp, #0x270]
0050498D4  str      x10, [sp, #0x280]
0050498D8  ldr      x3, [x21, #0x28]
0050498DC  add      x1, sp, #0x290
0050498E0  add      x2, sp, #0x250
0050498E4  blr      x8
0050498E8  tbz      w0, #0x1f, #0x5049960
0050498EC  ldr      w8, [x19, #0x18]
0050498F0  cmp      w29, w8
0050498F4  b.hs     #0x50499d8
0050498F8  add      x10, x22, #0x20
0050498FC  ldp      q2, q0, [x10, #0x10]
005049900  ldr      x11, [x10, #0x30]
005049904  ldr      q1, [x10]
005049908  add      w9, w25, w24
00504990C  cmp      w9, w8
005049910  str      x11, [sp, #0x80]
005049914  stp      q2, q0, [sp, #0x60]
005049918  str      q1, [sp, #0x50]
00504991C  b.hs     #0x50499d8
005049920  sxtw     x8, w9
005049924  ldp      q2, q0, [sp, #0x60]
005049928  ldr      x9, [sp, #0x80]
00504992C  ldr      q1, [sp, #0x50]
005049930  nop      
005049934  madd     x8, x8, x26, x19
005049938  add      x0, x8, #0x30
00504993C  mov      x1, xzr
005049940  str      x9, [x8, #0x50]
005049944  stp      q2, q0, [x8, #0x30]
005049948  str      q1, [x8, #0x20]
00504994C  bl       #0x382bcb8 ; 
005049950  cmp      w28, w27
005049954  mov      w24, w28
005049958  b.le     #0x5049724
00504995C  b        #0x5049964 ; 
005049960  add      w29, w25, w24
005049964  ldr      w8, [x19, #0x18]
005049968  sxtw     x9, w29
00504996C  ldp      q0, q1, [sp, #0x210]
005049970  ldr      q2, [sp, #0x230]
005049974  ldr      x10, [sp, #0x240]
005049978  cmp      w29, w8
00504997C  stp      q0, q1, [sp, #0x10]
005049980  str      q2, [sp, #0x30]
005049984  str      x10, [sp, #0x40]
005049988  b.hs     #0x50499d8
00504998C  ldp      q2, q0, [sp, #0x20]
005049990  ldr      x10, [sp, #0x40]
005049994  ldr      q1, [sp, #0x10]
005049998  mov      w8, #0x38
00504999C  madd     x8, x9, x8, x19
0050499A0  add      x0, x8, #0x30
0050499A4  mov      x1, xzr
0050499A8  str      x10, [x8, #0x50]
0050499AC  stp      q2, q0, [x8, #0x30]
0050499B0  str      q1, [x8, #0x20]
0050499B4  bl       #0x382bcb8 ; 
0050499B8  add      sp, sp, #0x2d0
0050499BC  ldp      x20, x19, [sp, #0x50]
0050499C0  ldp      x22, x21, [sp, #0x40]
0050499C4  ldp      x24, x23, [sp, #0x30]
0050499C8  ldp      x26, x25, [sp, #0x20]
0050499CC  ldp      x28, x27, [sp, #0x10]
0050499D0  ldp      x29, x30, [sp], #0x60
0050499D4  ret      
0050499D8  bl       #0x382bfc0 ; 
0050499DC  bl       #0x382bfb8 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$InsertionSort
; RVA 0x50499E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0050499E0  stp      x29, x30, [sp, #-0x60]!
0050499E4  stp      x28, x27, [sp, #0x10]
0050499E8  stp      x26, x25, [sp, #0x20]
0050499EC  stp      x24, x23, [sp, #0x30]
0050499F0  stp      x22, x21, [sp, #0x40]
0050499F4  stp      x20, x19, [sp, #0x50]
0050499F8  sub      sp, sp, #0x240
0050499FC  cmp      w1, w2
005049A00  b.ge     #0x5049c1c
005049A04  mov      x22, x0
005049A08  cbz      x0, #0x5049c40
005049A0C  mov      w21, w1
005049A10  sxtw     x23, w21
005049A14  mov      x19, x4
005049A18  mov      x20, x3
005049A1C  sxtw     x24, w2
005049A20  mov      w25, #0x38
005049A24  mov      x27, x23
005049A28  ldr      x8, [x22, #0x18]
005049A2C  add      x26, x27, #1
005049A30  cmp      w26, w8
005049A34  b.hs     #0x5049c3c
005049A38  madd     x9, x26, x25, x22
005049A3C  ldp      q2, q0, [x9, #0x30]
005049A40  ldr      x10, [x9, #0x50]
005049A44  ldr      q1, [x9, #0x20]
005049A48  cmp      x27, x23
005049A4C  stp      q2, q0, [sp, #0x190]
005049A50  str      x10, [sp, #0x1b0]
005049A54  str      q1, [sp, #0x180]
005049A58  b.lt     #0x5049bbc
005049A5C  ldp      q0, q1, [sp, #0x180]
005049A60  ldr      q2, [sp, #0x1a0]
005049A64  ldr      x9, [sp, #0x1b0]
005049A68  cmp      w27, w8
005049A6C  stp      q0, q1, [sp, #0x100]
005049A70  str      q2, [sp, #0x120]
005049A74  str      x9, [sp, #0x130]
005049A78  b.hs     #0x5049c3c
005049A7C  smaddl   x28, w27, w25, x22
005049A80  ldr      x8, [x28, #0x50]
005049A84  ldp      q1, q0, [x28, #0x30]
005049A88  ldr      q2, [x28, #0x20]
005049A8C  str      x8, [sp, #0xf0]
005049A90  stp      q1, q0, [sp, #0xd0]
005049A94  str      q2, [sp, #0xc0]
005049A98  cbz      x20, #0x5049c40
005049A9C  ldp      q1, q0, [sp, #0x110]
005049AA0  ldr      x8, [sp, #0x130]
005049AA4  ldr      q2, [sp, #0x100]
005049AA8  ldr      x9, [sp, #0xf0]
005049AAC  stp      q1, q0, [sp, #0x90]
005049AB0  ldp      q0, q3, [sp, #0xc0]
005049AB4  ldr      q1, [sp, #0xe0]
005049AB8  str      q2, [sp, #0x80]
005049ABC  str      x8, [sp, #0xb0]
005049AC0  stp      q0, q3, [sp, #0x40]
005049AC4  str      q1, [sp, #0x60]
005049AC8  str      x9, [sp, #0x70]
005049ACC  ldr      x0, [x19, #0x20]
005049AD0  ldrb     w8, [x0, #0x135]
005049AD4  tbnz     w8, #0, #0x5049adc
005049AD8  bl       #0x3a7e60c ; 
005049ADC  ldp      q0, q1, [sp, #0x80]
005049AE0  ldr      q2, [sp, #0xa0]
005049AE4  ldr      x8, [x20, #0x18]
005049AE8  ldr      x0, [x20, #0x40]
005049AEC  ldr      x9, [sp, #0xb0]
005049AF0  stp      q0, q1, [sp, #0x200]
005049AF4  ldp      q0, q1, [sp, #0x40]
005049AF8  str      q2, [sp, #0x220]
005049AFC  ldr      q2, [sp, #0x60]
005049B00  ldr      x10, [sp, #0x70]
005049B04  stp      q0, q1, [sp, #0x1c0]
005049B08  str      x9, [sp, #0x230]
005049B0C  str      q2, [sp, #0x1e0]
005049B10  str      x10, [sp, #0x1f0]
005049B14  ldr      x3, [x20, #0x28]
005049B18  add      x1, sp, #0x200
005049B1C  add      x2, sp, #0x1c0
005049B20  blr      x8
005049B24  tbz      w0, #0x1f, #0x5049bb8
005049B28  ldr      w8, [x22, #0x18]
005049B2C  cmp      w27, w8
005049B30  b.hs     #0x5049c3c
005049B34  add      x10, x28, #0x20
005049B38  ldp      q2, q0, [x10, #0x10]
005049B3C  ldr      x11, [x10, #0x30]
005049B40  ldr      q1, [x10]
005049B44  add      w9, w27, #1
005049B48  cmp      w9, w8
005049B4C  str      x11, [sp, #0x170]
005049B50  stp      q2, q0, [sp, #0x150]
005049B54  str      q1, [sp, #0x140]
005049B58  b.hs     #0x5049c3c
005049B5C  sxtw     x8, w9
005049B60  ldp      q2, q0, [sp, #0x150]
005049B64  ldr      x9, [sp, #0x170]
005049B68  ldr      q1, [sp, #0x140]
005049B6C  nop      
005049B70  madd     x8, x8, x25, x22
005049B74  add      x0, x8, #0x30
005049B78  mov      x1, xzr
005049B7C  str      x9, [x8, #0x50]
005049B80  stp      q2, q0, [x8, #0x30]
005049B84  str      q1, [x8, #0x20]
005049B88  bl       #0x382bcb8 ; 
005049B8C  sub      w27, w27, #1
005049B90  cmp      w27, w21
005049B94  b.lt     #0x5049bb8
005049B98  ldr      w8, [x22, #0x18]
005049B9C  ldp      q0, q1, [sp, #0x180]
005049BA0  ldr      q2, [sp, #0x1a0]
005049BA4  ldr      x9, [sp, #0x1b0]
005049BA8  cmp      w27, w8
005049BAC  stp      q0, q1, [sp, #0x100]
005049BB0  str      q2, [sp, #0x120]
005049BB4  b        #0x5049a74 ; 
005049BB8  ldr      w8, [x22, #0x18]
005049BBC  ldp      q0, q1, [sp, #0x180]
005049BC0  ldr      q2, [sp, #0x1a0]
005049BC4  ldr      x10, [sp, #0x1b0]
005049BC8  add      w9, w27, #1
005049BCC  cmp      w9, w8
005049BD0  stp      q0, q1, [sp]
005049BD4  str      q2, [sp, #0x20]
005049BD8  str      x10, [sp, #0x30]
005049BDC  b.hs     #0x5049c3c
005049BE0  sxtw     x8, w9
005049BE4  ldp      q2, q0, [sp, #0x10]
005049BE8  ldr      x9, [sp, #0x30]
005049BEC  ldr      q1, [sp]
005049BF0  nop      
005049BF4  madd     x8, x8, x25, x22
005049BF8  add      x0, x8, #0x30
005049BFC  mov      x1, xzr
005049C00  str      x9, [x8, #0x50]
005049C04  stp      q2, q0, [x8, #0x30]
005049C08  str      q1, [x8, #0x20]
005049C0C  bl       #0x382bcb8 ; 
005049C10  cmp      x26, x24
005049C14  mov      x27, x26
005049C18  b.ne     #0x5049a28
005049C1C  add      sp, sp, #0x240
005049C20  ldp      x20, x19, [sp, #0x50]
005049C24  ldp      x22, x21, [sp, #0x40]
005049C28  ldp      x24, x23, [sp, #0x30]
005049C2C  ldp      x26, x25, [sp, #0x20]
005049C30  ldp      x28, x27, [sp, #0x10]
005049C34  ldp      x29, x30, [sp], #0x60
005049C38  ret      
005049C3C  bl       #0x382bfc0 ; 
005049C40  bl       #0x382bfb8 ; 

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$get_Default
; RVA 0x5049C44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005049C44  stp      x30, x19, [sp, #-0x10]!
005049C48  mov      x19, x0
005049C4C  ldr      x0, [x0, #0x20]
005049C50  ldrb     w8, [x0, #0x135]
005049C54  tbnz     w8, #0, #0x5049c5c
005049C58  bl       #0x3a7e60c ; 
005049C5C  ldr      x8, [x0, #0xc0]
005049C60  ldr      x0, [x8, #0x48]
005049C64  ldrb     w8, [x0, #0x135]
005049C68  tbnz     w8, #0, #0x5049c70
005049C6C  bl       #0x3a7e60c ; 
005049C70  ldr      w8, [x0, #0xe0]
005049C74  cbnz     w8, #0x5049c7c
005049C78  bl       #0x382be8c ; 
005049C7C  ldr      x0, [x19, #0x20]
005049C80  ldrb     w8, [x0, #0x135]
005049C84  tbnz     w8, #0, #0x5049c8c
005049C88  bl       #0x3a7e60c ; 
005049C8C  ldr      x8, [x0, #0xc0]
005049C90  ldr      x0, [x8, #0x48]
005049C94  ldrb     w8, [x0, #0x135]
005049C98  tbnz     w8, #0, #0x5049ca0
005049C9C  bl       #0x3a7e60c ; 
005049CA0  ldr      x8, [x0, #0xb8]
005049CA4  ldr      x0, [x8]
005049CA8  ldp      x30, x19, [sp], #0x10
005049CAC  ret      

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$.ctor
; RVA 0x5049CB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005049CB0  mov      x1, xzr
005049CB4  b        #0x7c335dc ; System.Object$$.ctor

; System.Collections.Generic.ArraySortHelper<WeightRandomData>$$.cctor
; RVA 0x5049CB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005049CB8  str      x30, [sp, #-0x20]!
005049CBC  stp      x20, x19, [sp, #0x10]
005049CC0  mov      x19, x0
005049CC4  ldr      x0, [x0, #0x20]
005049CC8  ldrb     w8, [x0, #0x135]
005049CCC  tbnz     w8, #0, #0x5049cd4
005049CD0  bl       #0x3a7e60c ; 
005049CD4  ldr      x8, [x0, #0xc0]
005049CD8  ldr      x0, [x8, #0xa0]
005049CDC  ldrb     w8, [x0, #0x135]
005049CE0  tbnz     w8, #0, #0x5049ce8
005049CE4  bl       #0x3a7e60c ; 
005049CE8  bl       #0x382bfa0 ; 
005049CEC  ldr      x8, [x19, #0x20]
005049CF0  mov      x20, x0
005049CF4  ldrb     w9, [x8, #0x135]
005049CF8  tbnz     w9, #0, #0x5049d04
005049CFC  mov      x0, x8
005049D00  bl       #0x3a7e60c ; 
005049D04  mov      x0, x20
005049D08  mov      x1, xzr
005049D0C  bl       #0x7c335dc ; System.Object$$.ctor
005049D10  ldr      x0, [x19, #0x20]
005049D14  ldrb     w8, [x0, #0x135]
005049D18  tbnz     w8, #0, #0x5049d20
005049D1C  bl       #0x3a7e60c ; 
005049D20  ldr      x8, [x0, #0xc0]
005049D24  ldr      x0, [x8, #0x48]
005049D28  ldrb     w8, [x0, #0x135]
005049D2C  tbnz     w8, #0, #0x5049d34
005049D30  bl       #0x3a7e60c ; 
005049D34  ldr      x8, [x0, #0xb8]
005049D38  str      x20, [x8]
005049D3C  ldr      x0, [x19, #0x20]
005049D40  ldrb     w8, [x0, #0x135]
005049D44  tbnz     w8, #0, #0x5049d4c
005049D48  bl       #0x3a7e60c ; 
005049D4C  ldr      x8, [x0, #0xc0]
005049D50  ldr      x0, [x8, #0x48]
005049D54  ldrb     w8, [x0, #0x135]
005049D58  tbnz     w8, #0, #0x5049d60
005049D5C  bl       #0x3a7e60c ; 
005049D60  ldr      x0, [x0, #0xb8]
005049D64  mov      x1, x20
005049D68  ldp      x20, x19, [sp, #0x10]
005049D6C  ldr      x30, [sp], #0x20
005049D70  b        #0x382bcb8 ; 

