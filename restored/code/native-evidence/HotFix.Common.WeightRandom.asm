; HotFix.Common.WeightRandom$$GetCount
; RVA 0x6B52394; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52394  stp      x30, x21, [sp, #-0x20]!
006B52398  stp      x20, x19, [sp, #0x10]
006B5239C  adrp     x20, #0x959f000
006B523A0  adrp     x21, #0x8f41000
006B523A4  ldrb     w8, [x20, #0xc25]
006B523A8  ldr      x21, [x21, #0x4a8]
006B523AC  mov      x19, x0
006B523B0  tbnz     w8, #0, #0x6b523d4
006B523B4  adrp     x0, #0x8f41000
006B523B8  ldr      x0, [x0, #0x4b0]
006B523BC  bl       #0x382bd14 ; 
006B523C0  adrp     x0, #0x8f41000
006B523C4  ldr      x0, [x0, #0x4a8]
006B523C8  bl       #0x382bd14 ; 
006B523CC  mov      w8, #1
006B523D0  strb     w8, [x20, #0xc25]
006B523D4  ldr      x1, [x21]
006B523D8  ldrb     w8, [x1, #0x53]
006B523DC  tbnz     w8, #5, #0x6b523f8
006B523E0  ldr      x8, [x19, #0x20]
006B523E4  cbz      x8, #0x6b5240c
006B523E8  ldr      w0, [x8, #0x18]
006B523EC  ldp      x20, x19, [sp, #0x10]
006B523F0  ldp      x30, x21, [sp], #0x20
006B523F4  ret      
006B523F8  ldr      x2, [x1, #0x60]
006B523FC  mov      x0, x19
006B52400  ldp      x20, x19, [sp, #0x10]
006B52404  ldp      x30, x21, [sp], #0x20
006B52408  br       x2
006B5240C  bl       #0x382bfb8 ; 

; HotFix.Common.WeightRandom$$get_WeightRandomList
; RVA 0x6B52410; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52410  stp      x30, x21, [sp, #-0x20]!
006B52414  stp      x20, x19, [sp, #0x10]
006B52418  adrp     x20, #0x959f000
006B5241C  adrp     x21, #0x8f3f000
006B52420  ldrb     w8, [x20, #0xc26]
006B52424  ldr      x21, [x21, #0xf00]
006B52428  mov      x19, x0
006B5242C  tbnz     w8, #0, #0x6b52444
006B52430  adrp     x0, #0x8f3f000
006B52434  ldr      x0, [x0, #0xf00]
006B52438  bl       #0x382bd14 ; 
006B5243C  mov      w8, #1
006B52440  strb     w8, [x20, #0xc26]
006B52444  ldr      x1, [x21]
006B52448  ldrb     w8, [x1, #0x53]
006B5244C  tbnz     w8, #5, #0x6b52460
006B52450  ldr      x0, [x19, #0x20]
006B52454  ldp      x20, x19, [sp, #0x10]
006B52458  ldp      x30, x21, [sp], #0x20
006B5245C  ret      
006B52460  ldr      x2, [x1, #0x60]
006B52464  mov      x0, x19
006B52468  ldp      x20, x19, [sp, #0x10]
006B5246C  ldp      x30, x21, [sp], #0x20
006B52470  br       x2

; HotFix.Common.WeightRandom$$Add
; RVA 0x6B52474; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52474  sub      sp, sp, #0x40
006B52478  stp      x30, x23, [sp, #0x10]
006B5247C  stp      x22, x21, [sp, #0x20]
006B52480  stp      x20, x19, [sp, #0x30]
006B52484  adrp     x22, #0x959f000
006B52488  adrp     x23, #0x8f41000
006B5248C  ldrb     w8, [x22, #0xc27]
006B52490  ldr      x23, [x23, #0x4b8]
006B52494  mov      w19, w2
006B52498  mov      w21, w1
006B5249C  mov      x20, x0
006B524A0  tbnz     w8, #0, #0x6b52518
006B524A4  adrp     x0, #0x8ebf000
006B524A8  ldr      x0, [x0, #0xba0]
006B524AC  bl       #0x382bd14 ; 
006B524B0  adrp     x0, #0x8f41000
006B524B4  ldr      x0, [x0, #0x4c0]
006B524B8  bl       #0x382bd14 ; 
006B524BC  adrp     x0, #0x8ee1000
006B524C0  ldr      x0, [x0, #0x6e8]
006B524C4  bl       #0x382bd14 ; 
006B524C8  adrp     x0, #0x8f41000
006B524CC  ldr      x0, [x0, #0x4c8]
006B524D0  bl       #0x382bd14 ; 
006B524D4  adrp     x0, #0x8f41000
006B524D8  ldr      x0, [x0, #0x4b8]
006B524DC  bl       #0x382bd14 ; 
006B524E0  adrp     x0, #0x8f41000
006B524E4  ldr      x0, [x0, #0x4d0]
006B524E8  bl       #0x382bd14 ; 
006B524EC  adrp     x0, #0x8ed8000
006B524F0  ldr      x0, [x0, #0x3f0]
006B524F4  bl       #0x382bd14 ; 
006B524F8  adrp     x0, #0x8f41000
006B524FC  ldr      x0, [x0, #0x4d8]
006B52500  bl       #0x382bd14 ; 
006B52504  adrp     x0, #0x8f41000
006B52508  ldr      x0, [x0, #0x4e0]
006B5250C  bl       #0x382bd14 ; 
006B52510  mov      w8, #1
006B52514  strb     w8, [x22, #0xc27]
006B52518  ldr      x3, [x23]
006B5251C  ldrb     w8, [x3, #0x53]
006B52520  tbnz     w8, #5, #0x6b525a0
006B52524  mov      x0, x20
006B52528  mov      w1, w21
006B5252C  bl       #0x6b526fc ; HotFix.Common.WeightRandom$$Exist
006B52530  tbz      w0, #0, #0x6b525c4
006B52534  adrp     x8, #0x8ebf000
006B52538  ldr      x8, [x8, #0xba0]
006B5253C  add      x1, sp, #0xc
006B52540  str      w21, [sp, #0xc]
006B52544  ldr      x0, [x8]
006B52548  bl       #0x382be94 ; 
006B5254C  adrp     x8, #0x8f41000
006B52550  ldr      x8, [x8, #0x4d0]
006B52554  mov      x1, x0
006B52558  mov      x2, xzr
006B5255C  ldr      x8, [x8]
006B52560  mov      x0, x8
006B52564  bl       #0x79d140c ; System.String$$Format
006B52568  adrp     x8, #0x8ee1000
006B5256C  ldr      x8, [x8, #0x6e8]
006B52570  mov      x19, x0
006B52574  ldr      x8, [x8]
006B52578  ldr      w9, [x8, #0xe0]
006B5257C  cbnz     w9, #0x6b52588
006B52580  mov      x0, x8
006B52584  bl       #0x382be8c ; 
006B52588  adrp     x8, #0x8ed8000
006B5258C  adrp     x9, #0x8f41000
006B52590  ldr      x8, [x8, #0x3f0]
006B52594  ldr      x9, [x9, #0x4d8]
006B52598  mov      w3, #0x25
006B5259C  b        #0x6b526ac ; 
006B525A0  ldr      x4, [x3, #0x60]
006B525A4  mov      x0, x20
006B525A8  mov      w1, w21
006B525AC  mov      w2, w19
006B525B0  ldp      x20, x19, [sp, #0x30]
006B525B4  ldp      x22, x21, [sp, #0x20]
006B525B8  ldp      x30, x23, [sp, #0x10]
006B525BC  add      sp, sp, #0x40
006B525C0  br       x4
006B525C4  cmp      w19, #0
006B525C8  b.le     #0x6b52644
006B525CC  adrp     x8, #0x8f41000
006B525D0  ldr      x8, [x8, #0x4c8]
006B525D4  ldr      x0, [x8]
006B525D8  bl       #0x382bfa0 ; 
006B525DC  mov      w1, w21
006B525E0  mov      w2, w19
006B525E4  mov      x22, x0
006B525E8  bl       #0x6b52308 ; HotFix.Common.WeightRandomData$$.ctor
006B525EC  ldr      x0, [x20, #0x20]
006B525F0  cbz      x0, #0x6b526f8
006B525F4  adrp     x9, #0x8f41000
006B525F8  ldr      x9, [x9, #0x4c0]
006B525FC  ldr      w10, [x0, #0x1c]
006B52600  ldr      x8, [x0, #0x10]
006B52604  ldr      x9, [x9]
006B52608  add      w10, w10, #1
006B5260C  str      w10, [x0, #0x1c]
006B52610  cbz      x8, #0x6b526f8
006B52614  ldrsw    x10, [x0, #0x18]
006B52618  ldr      w11, [x8, #0x18]
006B5261C  cmp      w10, w11
006B52620  b.hs     #0x6b526c4
006B52624  add      w9, w10, #1
006B52628  add      x8, x8, x10, lsl #3
006B5262C  str      w9, [x0, #0x18]
006B52630  str      x22, [x8, #0x20]!
006B52634  mov      x0, x8
006B52638  mov      x1, x22
006B5263C  bl       #0x382bcb8 ; 
006B52640  b        #0x6b526d8 ; 
006B52644  adrp     x8, #0x8ebf000
006B52648  ldr      x8, [x8, #0xba0]
006B5264C  add      x1, sp, #8
006B52650  str      w21, [sp, #8]
006B52654  ldr      x0, [x8]
006B52658  bl       #0x382be94 ; 
006B5265C  adrp     x8, #0x8f41000
006B52660  ldr      x8, [x8, #0x4e0]
006B52664  mov      x1, x0
006B52668  mov      x2, xzr
006B5266C  ldr      x8, [x8]
006B52670  mov      x0, x8
006B52674  bl       #0x79d140c ; System.String$$Format
006B52678  adrp     x8, #0x8ee1000
006B5267C  ldr      x8, [x8, #0x6e8]
006B52680  mov      x19, x0
006B52684  ldr      x8, [x8]
006B52688  ldr      w9, [x8, #0xe0]
006B5268C  cbnz     w9, #0x6b52698
006B52690  mov      x0, x8
006B52694  bl       #0x382be8c ; 
006B52698  adrp     x8, #0x8ed8000
006B5269C  adrp     x9, #0x8f41000
006B526A0  ldr      x8, [x8, #0x3f0]
006B526A4  ldr      x9, [x9, #0x4d8]
006B526A8  mov      w3, #0x2b
006B526AC  ldr      x1, [x8]
006B526B0  ldr      x2, [x9]
006B526B4  mov      x0, x19
006B526B8  mov      x4, xzr
006B526BC  bl       #0x7997754 ; Logger$$LogError
006B526C0  b        #0x6b526e4 ; 
006B526C4  ldr      x8, [x9, #0x20]
006B526C8  mov      x1, x22
006B526CC  ldr      x8, [x8, #0xc0]
006B526D0  ldr      x2, [x8, #0x70]
006B526D4  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
006B526D8  ldr      w8, [x20, #0x18]
006B526DC  add      w8, w8, w19
006B526E0  str      w8, [x20, #0x18]
006B526E4  ldp      x20, x19, [sp, #0x30]
006B526E8  ldp      x22, x21, [sp, #0x20]
006B526EC  ldp      x30, x23, [sp, #0x10]
006B526F0  add      sp, sp, #0x40
006B526F4  ret      
006B526F8  bl       #0x382bfb8 ; 

; HotFix.Common.WeightRandom$$Remove
; RVA 0x6B527DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B527DC  stp      x30, x23, [sp, #-0x30]!
006B527E0  stp      x22, x21, [sp, #0x10]
006B527E4  stp      x20, x19, [sp, #0x20]
006B527E8  adrp     x21, #0x959f000
006B527EC  adrp     x22, #0x8f41000
006B527F0  ldrb     w8, [x21, #0xc28]
006B527F4  ldr      x22, [x22, #0x4f8]
006B527F8  mov      w19, w1
006B527FC  mov      x20, x0
006B52800  tbnz     w8, #0, #0x6b5283c
006B52804  adrp     x0, #0x8f41000
006B52808  ldr      x0, [x0, #0x500]
006B5280C  bl       #0x382bd14 ; 
006B52810  adrp     x0, #0x8f41000
006B52814  ldr      x0, [x0, #0x4b0]
006B52818  bl       #0x382bd14 ; 
006B5281C  adrp     x0, #0x8f41000
006B52820  ldr      x0, [x0, #0x4f0]
006B52824  bl       #0x382bd14 ; 
006B52828  adrp     x0, #0x8f41000
006B5282C  ldr      x0, [x0, #0x4f8]
006B52830  bl       #0x382bd14 ; 
006B52834  mov      w8, #1
006B52838  strb     w8, [x21, #0xc28]
006B5283C  ldr      x2, [x22]
006B52840  ldrb     w8, [x2, #0x53]
006B52844  tbnz     w8, #5, #0x6b528c0
006B52848  ldr      x0, [x20, #0x20]
006B5284C  cbz      x0, #0x6b528bc
006B52850  ldr      w8, [x0, #0x18]
006B52854  subs     w21, w8, #1
006B52858  b.mi     #0x6b528dc
006B5285C  adrp     x22, #0x8f41000
006B52860  adrp     x23, #0x8f41000
006B52864  ldr      x22, [x22, #0x4f0]
006B52868  ldr      x23, [x23, #0x500]
006B5286C  ldr      x2, [x22]
006B52870  mov      w1, w21
006B52874  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006B52878  cbz      x0, #0x6b528bc
006B5287C  ldr      w8, [x0, #0x10]
006B52880  cmp      w8, w19
006B52884  b.ne     #0x6b528ac
006B52888  ldr      w8, [x20, #0x18]
006B5288C  ldr      w9, [x0, #0x14]
006B52890  ldr      x0, [x20, #0x20]
006B52894  sub      w8, w8, w9
006B52898  str      w8, [x20, #0x18]
006B5289C  cbz      x0, #0x6b528bc
006B528A0  ldr      x2, [x23]
006B528A4  mov      w1, w21
006B528A8  bl       #0x4db196c ; System.Collections.Generic.List<object>$$RemoveAt
006B528AC  subs     w21, w21, #1
006B528B0  b.mi     #0x6b528dc
006B528B4  ldr      x0, [x20, #0x20]
006B528B8  cbnz     x0, #0x6b5286c
006B528BC  bl       #0x382bfb8 ; 
006B528C0  ldr      x3, [x2, #0x60]
006B528C4  mov      x0, x20
006B528C8  mov      w1, w19
006B528CC  ldp      x20, x19, [sp, #0x20]
006B528D0  ldp      x22, x21, [sp, #0x10]
006B528D4  ldp      x30, x23, [sp], #0x30
006B528D8  br       x3
006B528DC  ldp      x20, x19, [sp, #0x20]
006B528E0  ldp      x22, x21, [sp, #0x10]
006B528E4  ldp      x30, x23, [sp], #0x30
006B528E8  ret      

; HotFix.Common.WeightRandom$$AddWeight
; RVA 0x6B528EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B528EC  stp      x30, x23, [sp, #-0x30]!
006B528F0  stp      x22, x21, [sp, #0x10]
006B528F4  stp      x20, x19, [sp, #0x20]
006B528F8  adrp     x22, #0x959f000
006B528FC  adrp     x23, #0x8f41000
006B52900  ldrb     w8, [x22, #0xc29]
006B52904  ldr      x23, [x23, #0x508]
006B52908  mov      w19, w2
006B5290C  mov      w21, w1
006B52910  mov      x20, x0
006B52914  tbnz     w8, #0, #0x6b5295c
006B52918  adrp     x0, #0x8f41000
006B5291C  ldr      x0, [x0, #0x510]
006B52920  bl       #0x382bd14 ; 
006B52924  adrp     x0, #0x8f41000
006B52928  ldr      x0, [x0, #0x518]
006B5292C  bl       #0x382bd14 ; 
006B52930  adrp     x0, #0x8f41000
006B52934  ldr      x0, [x0, #0x520]
006B52938  bl       #0x382bd14 ; 
006B5293C  adrp     x0, #0x8f41000
006B52940  ldr      x0, [x0, #0x528]
006B52944  bl       #0x382bd14 ; 
006B52948  adrp     x0, #0x8f41000
006B5294C  ldr      x0, [x0, #0x508]
006B52950  bl       #0x382bd14 ; 
006B52954  mov      w8, #1
006B52958  strb     w8, [x22, #0xc29]
006B5295C  ldr      x3, [x23]
006B52960  ldrb     w8, [x3, #0x53]
006B52964  tbnz     w8, #5, #0x6b52a04
006B52968  adrp     x8, #0x8f41000
006B5296C  ldr      x8, [x8, #0x528]
006B52970  ldr      x0, [x8]
006B52974  bl       #0x382bfa0 ; 
006B52978  mov      x22, x0
006B5297C  bl       #0x6b52a28 ; HotFix.Common.WeightRandom.<>c__DisplayClass8_0$$.ctor
006B52980  cbz      x22, #0x6b52a24
006B52984  str      w21, [x22, #0x10]
006B52988  adrp     x8, #0x8f41000
006B5298C  ldr      x8, [x8, #0x518]
006B52990  ldr      x21, [x20, #0x20]
006B52994  ldr      x0, [x8]
006B52998  bl       #0x382bfa0 ; 
006B5299C  adrp     x8, #0x8f41000
006B529A0  ldr      x8, [x8, #0x520]
006B529A4  mov      x1, x22
006B529A8  mov      x3, xzr
006B529AC  mov      x23, x0
006B529B0  ldr      x2, [x8]
006B529B4  bl       #0x527cd68 ; System.Predicate<object>$$.ctor
006B529B8  cbz      x21, #0x6b52a24
006B529BC  adrp     x8, #0x8f41000
006B529C0  ldr      x8, [x8, #0x510]
006B529C4  mov      x0, x21
006B529C8  mov      x1, x23
006B529CC  ldr      x2, [x8]
006B529D0  bl       #0x4db04fc ; System.Collections.Generic.List<object>$$Find
006B529D4  cbz      x0, #0x6b529f4
006B529D8  ldr      w8, [x0, #0x14]
006B529DC  add      w8, w8, w19
006B529E0  str      w8, [x0, #0x14]
006B529E4  ldr      w8, [x20, #0x18]
006B529E8  mov      w0, #1
006B529EC  add      w8, w8, w19
006B529F0  str      w8, [x20, #0x18]
006B529F4  ldp      x20, x19, [sp, #0x20]
006B529F8  ldp      x22, x21, [sp, #0x10]
006B529FC  ldp      x30, x23, [sp], #0x30
006B52A00  ret      
006B52A04  ldr      x4, [x3, #0x60]
006B52A08  mov      x0, x20
006B52A0C  mov      w1, w21
006B52A10  mov      w2, w19
006B52A14  ldp      x20, x19, [sp, #0x20]
006B52A18  ldp      x22, x21, [sp, #0x10]
006B52A1C  ldp      x30, x23, [sp], #0x30
006B52A20  br       x4
006B52A24  bl       #0x382bfb8 ; 

; HotFix.Common.WeightRandom$$AddWeightByPercent
; RVA 0x6B52A90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52A90  stp      x30, x23, [sp, #-0x30]!
006B52A94  stp      x22, x21, [sp, #0x10]
006B52A98  stp      x20, x19, [sp, #0x20]
006B52A9C  adrp     x22, #0x959f000
006B52AA0  adrp     x23, #0x8f41000
006B52AA4  ldrb     w8, [x22, #0xc2a]
006B52AA8  ldr      x23, [x23, #0x538]
006B52AAC  mov      w20, w2
006B52AB0  mov      w21, w1
006B52AB4  mov      x19, x0
006B52AB8  tbnz     w8, #0, #0x6b52ae8
006B52ABC  adrp     x0, #0x8f41000
006B52AC0  ldr      x0, [x0, #0x4b0]
006B52AC4  bl       #0x382bd14 ; 
006B52AC8  adrp     x0, #0x8f41000
006B52ACC  ldr      x0, [x0, #0x4f0]
006B52AD0  bl       #0x382bd14 ; 
006B52AD4  adrp     x0, #0x8f41000
006B52AD8  ldr      x0, [x0, #0x538]
006B52ADC  bl       #0x382bd14 ; 
006B52AE0  mov      w8, #1
006B52AE4  strb     w8, [x22, #0xc2a]
006B52AE8  ldr      x3, [x23]
006B52AEC  ldrb     w8, [x3, #0x53]
006B52AF0  tbnz     w8, #5, #0x6b52b40
006B52AF4  ldr      x0, [x19, #0x20]
006B52AF8  cbz      x0, #0x6b52b3c
006B52AFC  adrp     x23, #0x8f41000
006B52B00  ldr      x23, [x23, #0x4f0]
006B52B04  mov      w22, wzr
006B52B08  ldr      w8, [x0, #0x18]
006B52B0C  cmp      w22, w8
006B52B10  b.ge     #0x6b52b9c
006B52B14  ldr      x2, [x23]
006B52B18  mov      w1, w22
006B52B1C  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006B52B20  cbz      x0, #0x6b52b3c
006B52B24  ldr      w8, [x0, #0x10]
006B52B28  cmp      w8, w21
006B52B2C  b.eq     #0x6b52b60
006B52B30  ldr      x0, [x19, #0x20]
006B52B34  add      w22, w22, #1
006B52B38  cbnz     x0, #0x6b52b08
006B52B3C  bl       #0x382bfb8 ; 
006B52B40  ldr      x4, [x3, #0x60]
006B52B44  mov      x0, x19
006B52B48  mov      w1, w21
006B52B4C  mov      w2, w20
006B52B50  ldp      x20, x19, [sp, #0x20]
006B52B54  ldp      x22, x21, [sp, #0x10]
006B52B58  ldp      x30, x23, [sp], #0x30
006B52B5C  br       x4
006B52B60  ldr      w8, [x0, #0x14]
006B52B64  mul      w9, w8, w20
006B52B68  cmp      w9, #0x64
006B52B6C  b.lt     #0x6b52b9c
006B52B70  mov      w10, #0x851f
006B52B74  movk     w10, #0x51eb, lsl #16
006B52B78  smull    x9, w9, w10
006B52B7C  lsr      x10, x9, #0x3f
006B52B80  asr      x9, x9, #0x25
006B52B84  add      w9, w9, w10
006B52B88  add      w8, w9, w8
006B52B8C  str      w8, [x0, #0x14]
006B52B90  ldr      w8, [x19, #0x18]
006B52B94  add      w8, w8, w9
006B52B98  str      w8, [x19, #0x18]
006B52B9C  ldp      x20, x19, [sp, #0x20]
006B52BA0  ldp      x22, x21, [sp, #0x10]
006B52BA4  ldp      x30, x23, [sp], #0x30
006B52BA8  ret      

; HotFix.Common.WeightRandom$$GetRandom
; RVA 0x6B52BAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52BAC  str      x30, [sp, #-0x30]!
006B52BB0  stp      x22, x21, [sp, #0x10]
006B52BB4  stp      x20, x19, [sp, #0x20]
006B52BB8  adrp     x20, #0x959f000
006B52BBC  adrp     x21, #0x8f41000
006B52BC0  ldrb     w8, [x20, #0xc2b]
006B52BC4  ldr      x21, [x21, #0x540]
006B52BC8  mov      x19, x0
006B52BCC  tbnz     w8, #0, #0x6b52c38
006B52BD0  adrp     x0, #0x8ebf000
006B52BD4  ldr      x0, [x0, #0xba0]
006B52BD8  bl       #0x382bd14 ; 
006B52BDC  adrp     x0, #0x8f41000
006B52BE0  ldr      x0, [x0, #0x4b0]
006B52BE4  bl       #0x382bd14 ; 
006B52BE8  adrp     x0, #0x8f41000
006B52BEC  ldr      x0, [x0, #0x4f0]
006B52BF0  bl       #0x382bd14 ; 
006B52BF4  adrp     x0, #0x8ee1000
006B52BF8  ldr      x0, [x0, #0x6e8]
006B52BFC  bl       #0x382bd14 ; 
006B52C00  adrp     x0, #0x8f41000
006B52C04  ldr      x0, [x0, #0x540]
006B52C08  bl       #0x382bd14 ; 
006B52C0C  adrp     x0, #0x8f0c000
006B52C10  ldr      x0, [x0, #0xff0]
006B52C14  bl       #0x382bd14 ; 
006B52C18  adrp     x0, #0x8f41000
006B52C1C  ldr      x0, [x0, #0x4d8]
006B52C20  bl       #0x382bd14 ; 
006B52C24  adrp     x0, #0x8f41000
006B52C28  ldr      x0, [x0, #0x548]
006B52C2C  bl       #0x382bd14 ; 
006B52C30  mov      w8, #1
006B52C34  strb     w8, [x20, #0xc2b]
006B52C38  ldr      x1, [x21]
006B52C3C  ldrb     w8, [x1, #0x53]
006B52C40  tbnz     w8, #5, #0x6b52cb0
006B52C44  ldr      x0, [x19, #0x10]
006B52C48  cbz      x0, #0x6b52d94
006B52C4C  ldr      w2, [x19, #0x18]
006B52C50  mov      w1, wzr
006B52C54  mov      x3, xzr
006B52C58  bl       #0x416cad8 ; XRandom$$nextInt
006B52C5C  ldr      x8, [x19, #0x20]
006B52C60  cbz      x8, #0x6b52d94
006B52C64  adrp     x22, #0x8f41000
006B52C68  ldr      x22, [x22, #0x4f0]
006B52C6C  mov      w20, w0
006B52C70  mov      w21, wzr
006B52C74  ldr      w9, [x8, #0x18]
006B52C78  cmp      w21, w9
006B52C7C  b.ge     #0x6b52cc8
006B52C80  ldr      x2, [x22]
006B52C84  mov      x0, x8
006B52C88  mov      w1, w21
006B52C8C  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006B52C90  cbz      x0, #0x6b52d94
006B52C94  ldr      w8, [x0, #0x14]
006B52C98  subs     w20, w20, w8
006B52C9C  b.lt     #0x6b52d68
006B52CA0  ldr      x8, [x19, #0x20]
006B52CA4  add      w21, w21, #1
006B52CA8  cbnz     x8, #0x6b52c74
006B52CAC  b        #0x6b52d94 ; 
006B52CB0  ldr      x2, [x1, #0x60]
006B52CB4  mov      x0, x19
006B52CB8  ldp      x20, x19, [sp, #0x20]
006B52CBC  ldp      x22, x21, [sp, #0x10]
006B52CC0  ldr      x30, [sp], #0x30
006B52CC4  br       x2
006B52CC8  adrp     x21, #0x8ebf000
006B52CCC  ldr      w8, [x19, #0x18]
006B52CD0  ldr      x21, [x21, #0xba0]
006B52CD4  add      x1, sp, #0xc
006B52CD8  str      w8, [sp, #0xc]
006B52CDC  ldr      x0, [x21]
006B52CE0  bl       #0x382be94 ; 
006B52CE4  mov      x19, x0
006B52CE8  ldr      x0, [x21]
006B52CEC  add      x1, sp, #8
006B52CF0  str      w20, [sp, #8]
006B52CF4  bl       #0x382be94 ; 
006B52CF8  adrp     x8, #0x8f41000
006B52CFC  ldr      x8, [x8, #0x548]
006B52D00  mov      x2, x0
006B52D04  mov      x1, x19
006B52D08  mov      x3, xzr
006B52D0C  ldr      x8, [x8]
006B52D10  mov      x0, x8
006B52D14  bl       #0x79e2794 ; System.String$$Format
006B52D18  adrp     x8, #0x8ee1000
006B52D1C  ldr      x8, [x8, #0x6e8]
006B52D20  mov      x19, x0
006B52D24  ldr      x8, [x8]
006B52D28  ldr      w9, [x8, #0xe0]
006B52D2C  cbnz     w9, #0x6b52d38
006B52D30  mov      x0, x8
006B52D34  bl       #0x382be8c ; 
006B52D38  adrp     x8, #0x8f0c000
006B52D3C  adrp     x9, #0x8f41000
006B52D40  ldr      x8, [x8, #0xff0]
006B52D44  ldr      x9, [x9, #0x4d8]
006B52D48  mov      w3, #0x74
006B52D4C  mov      x0, x19
006B52D50  ldr      x1, [x8]
006B52D54  ldr      x2, [x9]
006B52D58  mov      x4, xzr
006B52D5C  bl       #0x7997754 ; Logger$$LogError
006B52D60  mov      w0, #-1
006B52D64  b        #0x6b52d84 ; 
006B52D68  ldr      x0, [x19, #0x20]
006B52D6C  cbz      x0, #0x6b52d94
006B52D70  ldr      x2, [x22]
006B52D74  mov      w1, w21
006B52D78  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006B52D7C  cbz      x0, #0x6b52d94
006B52D80  ldr      w0, [x0, #0x10]
006B52D84  ldp      x20, x19, [sp, #0x20]
006B52D88  ldp      x22, x21, [sp, #0x10]
006B52D8C  ldr      x30, [sp], #0x30
006B52D90  ret      
006B52D94  bl       #0x382bfb8 ; 

; HotFix.Common.WeightRandom$$GetRandomCount
; RVA 0x6B52D98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52D98  stp      x29, x30, [sp, #-0x60]!
006B52D9C  stp      x28, x27, [sp, #0x10]
006B52DA0  stp      x26, x25, [sp, #0x20]
006B52DA4  stp      x24, x23, [sp, #0x30]
006B52DA8  stp      x22, x21, [sp, #0x40]
006B52DAC  stp      x20, x19, [sp, #0x50]
006B52DB0  adrp     x21, #0x959f000
006B52DB4  adrp     x22, #0x8f41000
006B52DB8  ldrb     w8, [x21, #0xc2c]
006B52DBC  ldr      x22, [x22, #0x550]
006B52DC0  mov      w19, w1
006B52DC4  mov      x20, x0
006B52DC8  tbnz     w8, #0, #0x6b52e58
006B52DCC  adrp     x0, #0x8f41000
006B52DD0  ldr      x0, [x0, #0x558]
006B52DD4  bl       #0x382bd14 ; 
006B52DD8  adrp     x0, #0x8f41000
006B52DDC  ldr      x0, [x0, #0x560]
006B52DE0  bl       #0x382bd14 ; 
006B52DE4  adrp     x0, #0x8f41000
006B52DE8  ldr      x0, [x0, #0x568]
006B52DEC  bl       #0x382bd14 ; 
006B52DF0  adrp     x0, #0x8f41000
006B52DF4  ldr      x0, [x0, #0x570]
006B52DF8  bl       #0x382bd14 ; 
006B52DFC  adrp     x0, #0x8ec2000
006B52E00  ldr      x0, [x0, #0x260]
006B52E04  bl       #0x382bd14 ; 
006B52E08  adrp     x0, #0x8f41000
006B52E0C  ldr      x0, [x0, #0x578]
006B52E10  bl       #0x382bd14 ; 
006B52E14  adrp     x0, #0x8ec2000
006B52E18  ldr      x0, [x0, #0x2b8]
006B52E1C  bl       #0x382bd14 ; 
006B52E20  adrp     x0, #0x8f41000
006B52E24  ldr      x0, [x0, #0x4b0]
006B52E28  bl       #0x382bd14 ; 
006B52E2C  adrp     x0, #0x8f41000
006B52E30  ldr      x0, [x0, #0x4f0]
006B52E34  bl       #0x382bd14 ; 
006B52E38  adrp     x0, #0x8ec2000
006B52E3C  ldr      x0, [x0, #0x2d0]
006B52E40  bl       #0x382bd14 ; 
006B52E44  adrp     x0, #0x8f41000
006B52E48  ldr      x0, [x0, #0x550]
006B52E4C  bl       #0x382bd14 ; 
006B52E50  mov      w8, #1
006B52E54  strb     w8, [x21, #0xc2c]
006B52E58  ldr      x2, [x22]
006B52E5C  ldrb     w8, [x2, #0x53]
006B52E60  tbnz     w8, #5, #0x6b5301c
006B52E64  adrp     x8, #0x8f41000
006B52E68  ldr      x8, [x8, #0x568]
006B52E6C  ldr      x0, [x8]
006B52E70  ldr      w8, [x0, #0xe0]
006B52E74  cbnz     w8, #0x6b52e7c
006B52E78  bl       #0x382be8c ; 
006B52E7C  adrp     x8, #0x8f41000
006B52E80  ldr      x8, [x8, #0x558]
006B52E84  ldr      x0, [x8]
006B52E88  bl       #0x4b69088 ; ListPool<object>$$Get
006B52E8C  cbz      x0, #0x6b53044
006B52E90  adrp     x8, #0x8f41000
006B52E94  ldr      x1, [x20, #0x20]
006B52E98  ldr      x8, [x8, #0x570]
006B52E9C  mov      x21, x0
006B52EA0  ldr      x2, [x8]
006B52EA4  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
006B52EA8  adrp     x8, #0x8ec2000
006B52EAC  ldr      w23, [x20, #0x18]
006B52EB0  ldr      x8, [x8, #0x2d0]
006B52EB4  ldr      x0, [x8]
006B52EB8  bl       #0x382bfa0 ; 
006B52EBC  adrp     x8, #0x8ec2000
006B52EC0  ldr      x8, [x8, #0x2b8]
006B52EC4  mov      x22, x0
006B52EC8  ldr      x1, [x8]
006B52ECC  bl       #0x4d63d00 ; System.Collections.Generic.List<int>$$.ctor
006B52ED0  cmp      w19, #1
006B52ED4  b.lt     #0x6b52fd0
006B52ED8  adrp     x29, #0x8f41000
006B52EDC  ldr      x29, [x29, #0x4f0]
006B52EE0  mov      w28, wzr
006B52EE4  ldr      x0, [x20, #0x10]
006B52EE8  cbz      x0, #0x6b53044
006B52EEC  mov      w1, wzr
006B52EF0  mov      w2, w23
006B52EF4  mov      x3, xzr
006B52EF8  bl       #0x416cad8 ; XRandom$$nextInt
006B52EFC  ldr      w27, [x21, #0x18]
006B52F00  cmp      w27, #1
006B52F04  b.lt     #0x6b52fc4
006B52F08  mov      w25, w0
006B52F0C  mov      w26, wzr
006B52F10  ldr      x2, [x29]
006B52F14  mov      x0, x21
006B52F18  mov      w1, w26
006B52F1C  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006B52F20  cbz      x0, #0x6b53044
006B52F24  ldr      w8, [x0, #0x14]
006B52F28  mov      x24, x0
006B52F2C  subs     w25, w25, w8
006B52F30  b.lt     #0x6b52f44
006B52F34  add      w26, w26, #1
006B52F38  cmp      w27, w26
006B52F3C  b.ne     #0x6b52f10
006B52F40  b        #0x6b52fc4 ; 
006B52F44  cbz      x22, #0x6b53044
006B52F48  adrp     x9, #0x8ec2000
006B52F4C  ldr      w1, [x24, #0x10]
006B52F50  ldr      w10, [x22, #0x1c]
006B52F54  ldr      x8, [x22, #0x10]
006B52F58  ldr      x9, [x9, #0x260]
006B52F5C  add      w10, w10, #1
006B52F60  ldr      x9, [x9]
006B52F64  str      w10, [x22, #0x1c]
006B52F68  cbz      x8, #0x6b53044
006B52F6C  ldrsw    x10, [x22, #0x18]
006B52F70  ldr      w11, [x8, #0x18]
006B52F74  cmp      w10, w11
006B52F78  b.hs     #0x6b52f90
006B52F7C  add      w9, w10, #1
006B52F80  add      x8, x8, x10, lsl #2
006B52F84  str      w9, [x22, #0x18]
006B52F88  str      w1, [x8, #0x20]
006B52F8C  b        #0x6b52fa4 ; 
006B52F90  ldr      x8, [x9, #0x20]
006B52F94  mov      x0, x22
006B52F98  ldr      x8, [x8, #0xc0]
006B52F9C  ldr      x2, [x8, #0x70]
006B52FA0  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006B52FA4  adrp     x8, #0x8f41000
006B52FA8  ldr      x8, [x8, #0x578]
006B52FAC  mov      x0, x21
006B52FB0  mov      x1, x24
006B52FB4  ldr      x2, [x8]
006B52FB8  bl       #0x4db16c0 ; System.Collections.Generic.List<object>$$Remove
006B52FBC  ldr      w8, [x24, #0x14]
006B52FC0  sub      w23, w23, w8
006B52FC4  add      w28, w28, #1
006B52FC8  cmp      w28, w19
006B52FCC  b.ne     #0x6b52ee4
006B52FD0  adrp     x8, #0x8f41000
006B52FD4  ldr      x8, [x8, #0x568]
006B52FD8  ldr      x0, [x8]
006B52FDC  ldr      w8, [x0, #0xe0]
006B52FE0  cbnz     w8, #0x6b52fe8
006B52FE4  bl       #0x382be8c ; 
006B52FE8  adrp     x8, #0x8f41000
006B52FEC  ldr      x8, [x8, #0x560]
006B52FF0  mov      x0, x21
006B52FF4  ldr      x1, [x8]
006B52FF8  bl       #0x4b6913c ; ListPool<object>$$Release
006B52FFC  mov      x0, x22
006B53000  ldp      x20, x19, [sp, #0x50]
006B53004  ldp      x22, x21, [sp, #0x40]
006B53008  ldp      x24, x23, [sp, #0x30]
006B5300C  ldp      x26, x25, [sp, #0x20]
006B53010  ldp      x28, x27, [sp, #0x10]
006B53014  ldp      x29, x30, [sp], #0x60
006B53018  ret      
006B5301C  ldr      x3, [x2, #0x60]
006B53020  mov      x0, x20
006B53024  mov      w1, w19
006B53028  ldp      x20, x19, [sp, #0x50]
006B5302C  ldp      x22, x21, [sp, #0x40]
006B53030  ldp      x24, x23, [sp, #0x30]
006B53034  ldp      x26, x25, [sp, #0x20]
006B53038  ldp      x28, x27, [sp, #0x10]
006B5303C  ldp      x29, x30, [sp], #0x60
006B53040  br       x3
006B53044  bl       #0x382bfb8 ; 

; HotFix.Common.WeightRandom$$GetRandomCount
; RVA 0x6B53048; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B53048  stp      x29, x30, [sp, #-0x60]!
006B5304C  stp      x28, x27, [sp, #0x10]
006B53050  stp      x26, x25, [sp, #0x20]
006B53054  stp      x24, x23, [sp, #0x30]
006B53058  stp      x22, x21, [sp, #0x40]
006B5305C  stp      x20, x19, [sp, #0x50]
006B53060  adrp     x21, #0x959f000
006B53064  adrp     x23, #0x8f41000
006B53068  ldrb     w8, [x21, #0xc2d]
006B5306C  ldr      x23, [x23, #0x580]
006B53070  mov      x22, x2
006B53074  mov      w19, w1
006B53078  mov      x20, x0
006B5307C  tbnz     w8, #0, #0x6b530f4
006B53080  adrp     x0, #0x8f41000
006B53084  ldr      x0, [x0, #0x558]
006B53088  bl       #0x382bd14 ; 
006B5308C  adrp     x0, #0x8f41000
006B53090  ldr      x0, [x0, #0x560]
006B53094  bl       #0x382bd14 ; 
006B53098  adrp     x0, #0x8f41000
006B5309C  ldr      x0, [x0, #0x568]
006B530A0  bl       #0x382bd14 ; 
006B530A4  adrp     x0, #0x8f41000
006B530A8  ldr      x0, [x0, #0x570]
006B530AC  bl       #0x382bd14 ; 
006B530B0  adrp     x0, #0x8ec2000
006B530B4  ldr      x0, [x0, #0x260]
006B530B8  bl       #0x382bd14 ; 
006B530BC  adrp     x0, #0x8f41000
006B530C0  ldr      x0, [x0, #0x578]
006B530C4  bl       #0x382bd14 ; 
006B530C8  adrp     x0, #0x8f41000
006B530CC  ldr      x0, [x0, #0x4b0]
006B530D0  bl       #0x382bd14 ; 
006B530D4  adrp     x0, #0x8f41000
006B530D8  ldr      x0, [x0, #0x4f0]
006B530DC  bl       #0x382bd14 ; 
006B530E0  adrp     x0, #0x8f41000
006B530E4  ldr      x0, [x0, #0x580]
006B530E8  bl       #0x382bd14 ; 
006B530EC  mov      w8, #1
006B530F0  strb     w8, [x21, #0xc2d]
006B530F4  ldr      x3, [x23]
006B530F8  ldrb     w8, [x3, #0x53]
006B530FC  tbnz     w8, #5, #0x6b53290
006B53100  adrp     x8, #0x8f41000
006B53104  ldr      x8, [x8, #0x568]
006B53108  ldr      x0, [x8]
006B5310C  ldr      w8, [x0, #0xe0]
006B53110  cbnz     w8, #0x6b53118
006B53114  bl       #0x382be8c ; 
006B53118  adrp     x8, #0x8f41000
006B5311C  ldr      x8, [x8, #0x558]
006B53120  ldr      x0, [x8]
006B53124  bl       #0x4b69088 ; ListPool<object>$$Get
006B53128  cbz      x0, #0x6b532bc
006B5312C  adrp     x8, #0x8f41000
006B53130  ldr      x1, [x20, #0x20]
006B53134  ldr      x8, [x8, #0x570]
006B53138  mov      x21, x0
006B5313C  ldr      x2, [x8]
006B53140  bl       #0x4db003c ; System.Collections.Generic.List<object>$$AddRange
006B53144  cmp      w19, #1
006B53148  b.lt     #0x6b5324c
006B5314C  adrp     x29, #0x8f41000
006B53150  ldr      x22, [x22]
006B53154  ldr      w23, [x20, #0x18]
006B53158  ldr      x29, [x29, #0x4f0]
006B5315C  mov      w28, wzr
006B53160  ldr      x0, [x20, #0x10]
006B53164  cbz      x0, #0x6b532bc
006B53168  mov      w1, wzr
006B5316C  mov      w2, w23
006B53170  mov      x3, xzr
006B53174  bl       #0x416cad8 ; XRandom$$nextInt
006B53178  ldr      w27, [x21, #0x18]
006B5317C  cmp      w27, #1
006B53180  b.lt     #0x6b53240
006B53184  mov      w25, w0
006B53188  mov      w26, wzr
006B5318C  ldr      x2, [x29]
006B53190  mov      x0, x21
006B53194  mov      w1, w26
006B53198  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006B5319C  cbz      x0, #0x6b532bc
006B531A0  ldr      w8, [x0, #0x14]
006B531A4  mov      x24, x0
006B531A8  subs     w25, w25, w8
006B531AC  b.lt     #0x6b531c0
006B531B0  add      w26, w26, #1
006B531B4  cmp      w27, w26
006B531B8  b.ne     #0x6b5318c
006B531BC  b        #0x6b53240 ; 
006B531C0  cbz      x22, #0x6b532bc
006B531C4  adrp     x9, #0x8ec2000
006B531C8  ldr      w1, [x24, #0x10]
006B531CC  ldr      w10, [x22, #0x1c]
006B531D0  ldr      x8, [x22, #0x10]
006B531D4  ldr      x9, [x9, #0x260]
006B531D8  add      w10, w10, #1
006B531DC  ldr      x9, [x9]
006B531E0  str      w10, [x22, #0x1c]
006B531E4  cbz      x8, #0x6b532bc
006B531E8  ldrsw    x10, [x22, #0x18]
006B531EC  ldr      w11, [x8, #0x18]
006B531F0  cmp      w10, w11
006B531F4  b.hs     #0x6b5320c
006B531F8  add      w9, w10, #1
006B531FC  add      x8, x8, x10, lsl #2
006B53200  str      w9, [x22, #0x18]
006B53204  str      w1, [x8, #0x20]
006B53208  b        #0x6b53220 ; 
006B5320C  ldr      x8, [x9, #0x20]
006B53210  mov      x0, x22
006B53214  ldr      x8, [x8, #0xc0]
006B53218  ldr      x2, [x8, #0x70]
006B5321C  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006B53220  adrp     x8, #0x8f41000
006B53224  ldr      x8, [x8, #0x578]
006B53228  mov      x0, x21
006B5322C  mov      x1, x24
006B53230  ldr      x2, [x8]
006B53234  bl       #0x4db16c0 ; System.Collections.Generic.List<object>$$Remove
006B53238  ldr      w8, [x24, #0x14]
006B5323C  sub      w23, w23, w8
006B53240  add      w28, w28, #1
006B53244  cmp      w28, w19
006B53248  b.ne     #0x6b53160
006B5324C  adrp     x8, #0x8f41000
006B53250  ldr      x8, [x8, #0x568]
006B53254  ldr      x0, [x8]
006B53258  ldr      w8, [x0, #0xe0]
006B5325C  cbnz     w8, #0x6b53264
006B53260  bl       #0x382be8c ; 
006B53264  adrp     x8, #0x8f41000
006B53268  ldr      x8, [x8, #0x560]
006B5326C  mov      x0, x21
006B53270  ldp      x20, x19, [sp, #0x50]
006B53274  ldp      x22, x21, [sp, #0x40]
006B53278  ldr      x1, [x8]
006B5327C  ldp      x24, x23, [sp, #0x30]
006B53280  ldp      x26, x25, [sp, #0x20]
006B53284  ldp      x28, x27, [sp, #0x10]
006B53288  ldp      x29, x30, [sp], #0x60
006B5328C  b        #0x4b6913c ; ListPool<object>$$Release
006B53290  ldr      x4, [x3, #0x60]
006B53294  mov      x0, x20
006B53298  mov      w1, w19
006B5329C  mov      x2, x22
006B532A0  ldp      x20, x19, [sp, #0x50]
006B532A4  ldp      x22, x21, [sp, #0x40]
006B532A8  ldp      x24, x23, [sp, #0x30]
006B532AC  ldp      x26, x25, [sp, #0x20]
006B532B0  ldp      x28, x27, [sp, #0x10]
006B532B4  ldp      x29, x30, [sp], #0x60
006B532B8  br       x4
006B532BC  bl       #0x382bfb8 ; 

; HotFix.Common.WeightRandom$$Clear
; RVA 0x6B532C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B532C0  stp      x30, x21, [sp, #-0x20]!
006B532C4  stp      x20, x19, [sp, #0x10]
006B532C8  adrp     x20, #0x959f000
006B532CC  adrp     x21, #0x8f41000
006B532D0  ldrb     w8, [x20, #0xc2e]
006B532D4  ldr      x21, [x21, #0x588]
006B532D8  mov      x19, x0
006B532DC  tbnz     w8, #0, #0x6b53300
006B532E0  adrp     x0, #0x8f41000
006B532E4  ldr      x0, [x0, #0x590]
006B532E8  bl       #0x382bd14 ; 
006B532EC  adrp     x0, #0x8f41000
006B532F0  ldr      x0, [x0, #0x588]
006B532F4  bl       #0x382bd14 ; 
006B532F8  mov      w8, #1
006B532FC  strb     w8, [x20, #0xc2e]
006B53300  ldr      x1, [x21]
006B53304  ldrb     w8, [x1, #0x53]
006B53308  tbnz     w8, #5, #0x6b53348
006B5330C  ldr      x8, [x19, #0x20]
006B53310  cbz      x8, #0x6b5335c
006B53314  ldp      w2, w9, [x8, #0x18]
006B53318  add      w9, w9, #1
006B5331C  cmp      w2, #1
006B53320  stp      wzr, w9, [x8, #0x18]
006B53324  b.lt     #0x6b53338
006B53328  ldr      x0, [x8, #0x10]
006B5332C  mov      w1, wzr
006B53330  mov      x3, xzr
006B53334  bl       #0x7c001d0 ; System.Array$$Clear
006B53338  str      wzr, [x19, #0x18]
006B5333C  ldp      x20, x19, [sp, #0x10]
006B53340  ldp      x30, x21, [sp], #0x20
006B53344  ret      
006B53348  ldr      x2, [x1, #0x60]
006B5334C  mov      x0, x19
006B53350  ldp      x20, x19, [sp, #0x10]
006B53354  ldp      x30, x21, [sp], #0x20
006B53358  br       x2
006B5335C  bl       #0x382bfb8 ; 

; HotFix.Common.WeightRandom$$Exist
; RVA 0x6B526FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B526FC  stp      x30, x23, [sp, #-0x30]!
006B52700  stp      x22, x21, [sp, #0x10]
006B52704  stp      x20, x19, [sp, #0x20]
006B52708  adrp     x21, #0x959f000
006B5270C  adrp     x22, #0x8f41000
006B52710  ldrb     w8, [x21, #0xc2f]
006B52714  ldr      x22, [x22, #0x4e8]
006B52718  mov      w19, w1
006B5271C  mov      x20, x0
006B52720  tbnz     w8, #0, #0x6b52750
006B52724  adrp     x0, #0x8f41000
006B52728  ldr      x0, [x0, #0x4b0]
006B5272C  bl       #0x382bd14 ; 
006B52730  adrp     x0, #0x8f41000
006B52734  ldr      x0, [x0, #0x4f0]
006B52738  bl       #0x382bd14 ; 
006B5273C  adrp     x0, #0x8f41000
006B52740  ldr      x0, [x0, #0x4e8]
006B52744  bl       #0x382bd14 ; 
006B52748  mov      w8, #1
006B5274C  strb     w8, [x21, #0xc2f]
006B52750  ldr      x2, [x22]
006B52754  ldrb     w8, [x2, #0x53]
006B52758  tbnz     w8, #5, #0x6b527a8
006B5275C  ldr      x0, [x20, #0x20]
006B52760  cbz      x0, #0x6b527a4
006B52764  adrp     x22, #0x8f41000
006B52768  ldr      x22, [x22, #0x4f0]
006B5276C  mov      w21, wzr
006B52770  ldr      w23, [x0, #0x18]
006B52774  cmp      w21, w23
006B52778  b.ge     #0x6b527c4
006B5277C  ldr      x2, [x22]
006B52780  mov      w1, w21
006B52784  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
006B52788  cbz      x0, #0x6b527a4
006B5278C  ldr      w8, [x0, #0x10]
006B52790  cmp      w8, w19
006B52794  b.eq     #0x6b527c4
006B52798  ldr      x0, [x20, #0x20]
006B5279C  add      w21, w21, #1
006B527A0  cbnz     x0, #0x6b52770
006B527A4  bl       #0x382bfb8 ; 
006B527A8  ldr      x3, [x2, #0x60]
006B527AC  mov      x0, x20
006B527B0  mov      w1, w19
006B527B4  ldp      x20, x19, [sp, #0x20]
006B527B8  ldp      x22, x21, [sp, #0x10]
006B527BC  ldp      x30, x23, [sp], #0x30
006B527C0  br       x3
006B527C4  cmp      w21, w23
006B527C8  ldp      x20, x19, [sp, #0x20]
006B527CC  ldp      x22, x21, [sp, #0x10]
006B527D0  cset     w0, lt
006B527D4  ldp      x30, x23, [sp], #0x30
006B527D8  ret      

; HotFix.Common.WeightRandom$$.ctor
; RVA 0x6B53360; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B53360  str      x30, [sp, #-0x30]!
006B53364  stp      x22, x21, [sp, #0x10]
006B53368  stp      x20, x19, [sp, #0x20]
006B5336C  adrp     x20, #0x959f000
006B53370  adrp     x21, #0x8f41000
006B53374  ldrb     w8, [x20, #0xc30]
006B53378  ldr      x21, [x21, #0x598]
006B5337C  mov      x19, x0
006B53380  tbnz     w8, #0, #0x6b533bc
006B53384  adrp     x0, #0x8f41000
006B53388  ldr      x0, [x0, #0x5a0]
006B5338C  bl       #0x382bd14 ; 
006B53390  adrp     x0, #0x8f41000
006B53394  ldr      x0, [x0, #0x5a8]
006B53398  bl       #0x382bd14 ; 
006B5339C  adrp     x0, #0x8f41000
006B533A0  ldr      x0, [x0, #0x598]
006B533A4  bl       #0x382bd14 ; 
006B533A8  adrp     x0, #0x8ee2000
006B533AC  ldr      x0, [x0, #0x848]
006B533B0  bl       #0x382bd14 ; 
006B533B4  mov      w8, #1
006B533B8  strb     w8, [x20, #0xc30]
006B533BC  ldr      x1, [x21]
006B533C0  ldrb     w8, [x1, #0x53]
006B533C4  tbnz     w8, #5, #0x6b53440
006B533C8  adrp     x8, #0x8ee2000
006B533CC  ldr      x8, [x8, #0x848]
006B533D0  adrp     x21, #0x8f41000
006B533D4  adrp     x22, #0x8f41000
006B533D8  ldr      x0, [x8]
006B533DC  ldr      x21, [x21, #0x5a8]
006B533E0  ldr      x22, [x22, #0x5a0]
006B533E4  bl       #0x382bfa0 ; 
006B533E8  mov      x1, xzr
006B533EC  mov      x20, x0
006B533F0  bl       #0x416c54c ; XRandom$$.ctor
006B533F4  mov      x0, x19
006B533F8  str      x20, [x0, #0x10]!
006B533FC  mov      x1, x20
006B53400  bl       #0x382bcb8 ; 
006B53404  ldr      x0, [x21]
006B53408  bl       #0x382bfa0 ; 
006B5340C  ldr      x1, [x22]
006B53410  mov      x20, x0
006B53414  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
006B53418  mov      x0, x19
006B5341C  str      x20, [x0, #0x20]!
006B53420  mov      x1, x20
006B53424  bl       #0x382bcb8 ; 
006B53428  mov      x0, x19
006B5342C  ldp      x20, x19, [sp, #0x20]
006B53430  ldp      x22, x21, [sp, #0x10]
006B53434  mov      x1, xzr
006B53438  ldr      x30, [sp], #0x30
006B5343C  b        #0x7c335dc ; System.Object$$.ctor
006B53440  ldr      x2, [x1, #0x60]
006B53444  mov      x0, x19
006B53448  ldp      x20, x19, [sp, #0x20]
006B5344C  ldp      x22, x21, [sp, #0x10]
006B53450  ldr      x30, [sp], #0x30
006B53454  br       x2

