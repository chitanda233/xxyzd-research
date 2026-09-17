; LocalModels.Bean.EventTurntable_EventTurntable$$readImpl
; RVA 0x6A78590; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A78590  str      d8, [sp, #-0x30]!
006A78594  stp      x30, x21, [sp, #0x10]
006A78598  stp      x20, x19, [sp, #0x20]
006A7859C  adrp     x20, #0x959d000
006A785A0  adrp     x21, #0x8f37000
006A785A4  ldrb     w8, [x20, #0xe6e]
006A785A8  ldr      x21, [x21, #0xbe8]
006A785AC  mov      x19, x0
006A785B0  tbnz     w8, #0, #0x6a785c8
006A785B4  adrp     x0, #0x8f37000
006A785B8  ldr      x0, [x0, #0xbe8]
006A785BC  bl       #0x382bd14 ; 
006A785C0  mov      w8, #1
006A785C4  strb     w8, [x20, #0xe6e]
006A785C8  ldr      x1, [x21]
006A785CC  ldrb     w8, [x1, #0x53]
006A785D0  tbnz     w8, #5, #0x6a7862c
006A785D4  mov      x0, x19
006A785D8  mov      x1, xzr
006A785DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A785E0  adrp     x21, #0x959e000
006A785E4  ldrb     w8, [x21, #0x4a7]
006A785E8  mov      x20, x0
006A785EC  cbnz     w8, #0x6a78604
006A785F0  adrp     x0, #0x8f37000
006A785F4  ldr      x0, [x0, #0xb70]
006A785F8  bl       #0x382bd14 ; 
006A785FC  mov      w8, #1
006A78600  strb     w8, [x21, #0x4a7]
006A78604  adrp     x8, #0x8f37000
006A78608  ldr      x8, [x8, #0xb70]
006A7860C  ldr      x2, [x8]
006A78610  ldrb     w8, [x2, #0x53]
006A78614  tbnz     w8, #5, #0x6a78644
006A78618  mov      x0, x19
006A7861C  str      x20, [x0, #0x20]!
006A78620  mov      x1, x20
006A78624  bl       #0x382bcb8 ; 
006A78628  b        #0x6a78654 ; 
006A7862C  ldr      x2, [x1, #0x60]
006A78630  mov      x0, x19
006A78634  ldp      x20, x19, [sp, #0x20]
006A78638  ldp      x30, x21, [sp, #0x10]
006A7863C  ldr      d8, [sp], #0x30
006A78640  br       x2
006A78644  ldr      x8, [x2, #0x60]
006A78648  mov      x0, x19
006A7864C  mov      x1, x20
006A78650  blr      x8
006A78654  mov      x0, x19
006A78658  mov      x1, xzr
006A7865C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A78660  adrp     x21, #0x959e000
006A78664  ldrb     w8, [x21, #0x4a8]
006A78668  mov      x20, x0
006A7866C  cbnz     w8, #0x6a78684
006A78670  adrp     x0, #0x8f37000
006A78674  ldr      x0, [x0, #0xb80]
006A78678  bl       #0x382bd14 ; 
006A7867C  mov      w8, #1
006A78680  strb     w8, [x21, #0x4a8]
006A78684  adrp     x8, #0x8f37000
006A78688  ldr      x8, [x8, #0xb80]
006A7868C  ldr      x2, [x8]
006A78690  ldrb     w8, [x2, #0x53]
006A78694  tbnz     w8, #5, #0x6a786ac
006A78698  mov      x0, x19
006A7869C  str      x20, [x0, #0x28]!
006A786A0  mov      x1, x20
006A786A4  bl       #0x382bcb8 ; 
006A786A8  b        #0x6a786bc ; 
006A786AC  ldr      x8, [x2, #0x60]
006A786B0  mov      x0, x19
006A786B4  mov      x1, x20
006A786B8  blr      x8
006A786BC  mov      x0, x19
006A786C0  mov      x1, xzr
006A786C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A786C8  adrp     x21, #0x959e000
006A786CC  ldrb     w8, [x21, #0x4a9]
006A786D0  mov      w20, w0
006A786D4  cbnz     w8, #0x6a786ec
006A786D8  adrp     x0, #0x8f37000
006A786DC  ldr      x0, [x0, #0xb90]
006A786E0  bl       #0x382bd14 ; 
006A786E4  mov      w8, #1
006A786E8  strb     w8, [x21, #0x4a9]
006A786EC  adrp     x8, #0x8f37000
006A786F0  ldr      x8, [x8, #0xb90]
006A786F4  ldr      x2, [x8]
006A786F8  ldrb     w8, [x2, #0x53]
006A786FC  tbnz     w8, #5, #0x6a78708
006A78700  str      w20, [x19, #0x30]
006A78704  b        #0x6a78718 ; 
006A78708  ldr      x8, [x2, #0x60]
006A7870C  mov      x0, x19
006A78710  mov      w1, w20
006A78714  blr      x8
006A78718  mov      x0, x19
006A7871C  mov      x1, xzr
006A78720  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A78724  adrp     x21, #0x959e000
006A78728  ldrb     w8, [x21, #0x4aa]
006A7872C  mov      x20, x0
006A78730  cbnz     w8, #0x6a78748
006A78734  adrp     x0, #0x8f37000
006A78738  ldr      x0, [x0, #0xba0]
006A7873C  bl       #0x382bd14 ; 
006A78740  mov      w8, #1
006A78744  strb     w8, [x21, #0x4aa]
006A78748  adrp     x8, #0x8f37000
006A7874C  ldr      x8, [x8, #0xba0]
006A78750  ldr      x2, [x8]
006A78754  ldrb     w8, [x2, #0x53]
006A78758  tbnz     w8, #5, #0x6a78770
006A7875C  mov      x0, x19
006A78760  str      x20, [x0, #0x38]!
006A78764  mov      x1, x20
006A78768  bl       #0x382bcb8 ; 
006A7876C  b        #0x6a78780 ; 
006A78770  ldr      x8, [x2, #0x60]
006A78774  mov      x0, x19
006A78778  mov      x1, x20
006A7877C  blr      x8
006A78780  mov      x0, x19
006A78784  mov      x1, xzr
006A78788  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7878C  adrp     x21, #0x959e000
006A78790  ldrb     w8, [x21, #0x4ab]
006A78794  mov      x20, x0
006A78798  cbnz     w8, #0x6a787b0
006A7879C  adrp     x0, #0x8f37000
006A787A0  ldr      x0, [x0, #0xbb0]
006A787A4  bl       #0x382bd14 ; 
006A787A8  mov      w8, #1
006A787AC  strb     w8, [x21, #0x4ab]
006A787B0  adrp     x8, #0x8f37000
006A787B4  ldr      x8, [x8, #0xbb0]
006A787B8  ldr      x2, [x8]
006A787BC  ldrb     w8, [x2, #0x53]
006A787C0  tbnz     w8, #5, #0x6a787d8
006A787C4  mov      x0, x19
006A787C8  str      x20, [x0, #0x40]!
006A787CC  mov      x1, x20
006A787D0  bl       #0x382bcb8 ; 
006A787D4  b        #0x6a787e8 ; 
006A787D8  ldr      x8, [x2, #0x60]
006A787DC  mov      x0, x19
006A787E0  mov      x1, x20
006A787E4  blr      x8
006A787E8  mov      x0, x19
006A787EC  mov      x1, xzr
006A787F0  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006A787F4  adrp     x20, #0x959e000
006A787F8  ldrb     w8, [x20, #0x4ac]
006A787FC  mov      v8.16b, v0.16b
006A78800  cbnz     w8, #0x6a78818
006A78804  adrp     x0, #0x8f37000
006A78808  ldr      x0, [x0, #0xbc0]
006A7880C  bl       #0x382bd14 ; 
006A78810  mov      w8, #1
006A78814  strb     w8, [x20, #0x4ac]
006A78818  adrp     x8, #0x8f37000
006A7881C  ldr      x8, [x8, #0xbc0]
006A78820  ldr      x1, [x8]
006A78824  ldrb     w8, [x1, #0x53]
006A78828  tbnz     w8, #5, #0x6a78834
006A7882C  str      s8, [x19, #0x48]
006A78830  b        #0x6a78844 ; 
006A78834  ldr      x8, [x1, #0x60]
006A78838  mov      x0, x19
006A7883C  mov      v0.16b, v8.16b
006A78840  blr      x8
006A78844  mov      x0, x19
006A78848  mov      x1, xzr
006A7884C  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
006A78850  adrp     x21, #0x959e000
006A78854  ldrb     w8, [x21, #0x4ad]
006A78858  mov      x20, x0
006A7885C  cbnz     w8, #0x6a78874
006A78860  adrp     x0, #0x8f37000
006A78864  ldr      x0, [x0, #0xbd0]
006A78868  bl       #0x382bd14 ; 
006A7886C  mov      w8, #1
006A78870  strb     w8, [x21, #0x4ad]
006A78874  adrp     x8, #0x8f37000
006A78878  ldr      x8, [x8, #0xbd0]
006A7887C  ldr      x2, [x8]
006A78880  ldrb     w8, [x2, #0x53]
006A78884  tbnz     w8, #5, #0x6a7889c
006A78888  mov      x0, x19
006A7888C  str      x20, [x0, #0x50]!
006A78890  mov      x1, x20
006A78894  bl       #0x382bcb8 ; 
006A78898  b        #0x6a788ac ; 
006A7889C  ldr      x8, [x2, #0x60]
006A788A0  mov      x0, x19
006A788A4  mov      x1, x20
006A788A8  blr      x8
006A788AC  mov      x0, x19
006A788B0  mov      x1, xzr
006A788B4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A788B8  adrp     x21, #0x959e000
006A788BC  ldrb     w8, [x21, #0x4ae]
006A788C0  mov      x20, x0
006A788C4  cbnz     w8, #0x6a788dc
006A788C8  adrp     x0, #0x8f37000
006A788CC  ldr      x0, [x0, #0xbe0]
006A788D0  bl       #0x382bd14 ; 
006A788D4  mov      w8, #1
006A788D8  strb     w8, [x21, #0x4ae]
006A788DC  adrp     x8, #0x8f37000
006A788E0  ldr      x8, [x8, #0xbe0]
006A788E4  ldr      x2, [x8]
006A788E8  ldrb     w8, [x2, #0x53]
006A788EC  tbnz     w8, #5, #0x6a78904
006A788F0  str      x20, [x19, #0x58]!
006A788F4  mov      x0, x19
006A788F8  mov      x1, x20
006A788FC  bl       #0x382bcb8 ; 
006A78900  b        #0x6a78914 ; 
006A78904  ldr      x8, [x2, #0x60]
006A78908  mov      x0, x19
006A7890C  mov      x1, x20
006A78910  blr      x8
006A78914  ldp      x20, x19, [sp, #0x20]
006A78918  ldp      x30, x21, [sp, #0x10]
006A7891C  mov      w0, #1
006A78920  ldr      d8, [sp], #0x30
006A78924  ret      

