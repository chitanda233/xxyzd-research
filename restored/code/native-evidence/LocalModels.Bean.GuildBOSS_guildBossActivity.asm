; LocalModels.Bean.GuildBOSS_guildBossActivity$$readImpl
; RVA 0x6A84060; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A84060  stp      x30, x21, [sp, #-0x20]!
006A84064  stp      x20, x19, [sp, #0x10]
006A84068  adrp     x20, #0x959d000
006A8406C  adrp     x21, #0x8f38000
006A84070  ldrb     w8, [x20, #0xfa6]
006A84074  ldr      x21, [x21, #0x4f0]
006A84078  mov      x19, x0
006A8407C  tbnz     w8, #0, #0x6a84094
006A84080  adrp     x0, #0x8f38000
006A84084  ldr      x0, [x0, #0x4f0]
006A84088  bl       #0x382bd14 ; 
006A8408C  mov      w8, #1
006A84090  strb     w8, [x20, #0xfa6]
006A84094  ldr      x1, [x21]
006A84098  ldrb     w8, [x1, #0x53]
006A8409C  tbnz     w8, #5, #0x6a840ec
006A840A0  mov      x0, x19
006A840A4  mov      x1, xzr
006A840A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A840AC  adrp     x21, #0x959e000
006A840B0  ldrb     w8, [x21, #0x526]
006A840B4  mov      w20, w0
006A840B8  cbnz     w8, #0x6a840d0
006A840BC  adrp     x0, #0x8f38000
006A840C0  ldr      x0, [x0, #0x488]
006A840C4  bl       #0x382bd14 ; 
006A840C8  mov      w8, #1
006A840CC  strb     w8, [x21, #0x526]
006A840D0  adrp     x8, #0x8f38000
006A840D4  ldr      x8, [x8, #0x488]
006A840D8  ldr      x2, [x8]
006A840DC  ldrb     w8, [x2, #0x53]
006A840E0  tbnz     w8, #5, #0x6a84100
006A840E4  str      w20, [x19, #0x20]
006A840E8  b        #0x6a84110 ; 
006A840EC  ldr      x2, [x1, #0x60]
006A840F0  mov      x0, x19
006A840F4  ldp      x20, x19, [sp, #0x10]
006A840F8  ldp      x30, x21, [sp], #0x20
006A840FC  br       x2
006A84100  ldr      x8, [x2, #0x60]
006A84104  mov      x0, x19
006A84108  mov      w1, w20
006A8410C  blr      x8
006A84110  mov      x0, x19
006A84114  mov      x1, xzr
006A84118  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8411C  adrp     x21, #0x959e000
006A84120  ldrb     w8, [x21, #0x527]
006A84124  mov      x20, x0
006A84128  cbnz     w8, #0x6a84140
006A8412C  adrp     x0, #0x8f38000
006A84130  ldr      x0, [x0, #0x498]
006A84134  bl       #0x382bd14 ; 
006A84138  mov      w8, #1
006A8413C  strb     w8, [x21, #0x527]
006A84140  adrp     x8, #0x8f38000
006A84144  ldr      x8, [x8, #0x498]
006A84148  ldr      x2, [x8]
006A8414C  ldrb     w8, [x2, #0x53]
006A84150  tbnz     w8, #5, #0x6a84168
006A84154  mov      x0, x19
006A84158  str      x20, [x0, #0x28]!
006A8415C  mov      x1, x20
006A84160  bl       #0x382bcb8 ; 
006A84164  b        #0x6a84178 ; 
006A84168  ldr      x8, [x2, #0x60]
006A8416C  mov      x0, x19
006A84170  mov      x1, x20
006A84174  blr      x8
006A84178  mov      x0, x19
006A8417C  mov      x1, xzr
006A84180  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A84184  adrp     x21, #0x959e000
006A84188  ldrb     w8, [x21, #0x528]
006A8418C  mov      x20, x0
006A84190  cbnz     w8, #0x6a841a8
006A84194  adrp     x0, #0x8f38000
006A84198  ldr      x0, [x0, #0x4a8]
006A8419C  bl       #0x382bd14 ; 
006A841A0  mov      w8, #1
006A841A4  strb     w8, [x21, #0x528]
006A841A8  adrp     x8, #0x8f38000
006A841AC  ldr      x8, [x8, #0x4a8]
006A841B0  ldr      x2, [x8]
006A841B4  ldrb     w8, [x2, #0x53]
006A841B8  tbnz     w8, #5, #0x6a841d0
006A841BC  mov      x0, x19
006A841C0  str      x20, [x0, #0x30]!
006A841C4  mov      x1, x20
006A841C8  bl       #0x382bcb8 ; 
006A841CC  b        #0x6a841e0 ; 
006A841D0  ldr      x8, [x2, #0x60]
006A841D4  mov      x0, x19
006A841D8  mov      x1, x20
006A841DC  blr      x8
006A841E0  mov      x0, x19
006A841E4  mov      x1, xzr
006A841E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A841EC  adrp     x21, #0x959e000
006A841F0  ldrb     w8, [x21, #0x529]
006A841F4  mov      x20, x0
006A841F8  cbnz     w8, #0x6a84210
006A841FC  adrp     x0, #0x8f38000
006A84200  ldr      x0, [x0, #0x4b8]
006A84204  bl       #0x382bd14 ; 
006A84208  mov      w8, #1
006A8420C  strb     w8, [x21, #0x529]
006A84210  adrp     x8, #0x8f38000
006A84214  ldr      x8, [x8, #0x4b8]
006A84218  ldr      x2, [x8]
006A8421C  ldrb     w8, [x2, #0x53]
006A84220  tbnz     w8, #5, #0x6a84238
006A84224  mov      x0, x19
006A84228  str      x20, [x0, #0x38]!
006A8422C  mov      x1, x20
006A84230  bl       #0x382bcb8 ; 
006A84234  b        #0x6a84248 ; 
006A84238  ldr      x8, [x2, #0x60]
006A8423C  mov      x0, x19
006A84240  mov      x1, x20
006A84244  blr      x8
006A84248  mov      x0, x19
006A8424C  mov      x1, xzr
006A84250  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A84254  adrp     x21, #0x959e000
006A84258  ldrb     w8, [x21, #0x52a]
006A8425C  mov      x20, x0
006A84260  cbnz     w8, #0x6a84278
006A84264  adrp     x0, #0x8f38000
006A84268  ldr      x0, [x0, #0x4c8]
006A8426C  bl       #0x382bd14 ; 
006A84270  mov      w8, #1
006A84274  strb     w8, [x21, #0x52a]
006A84278  adrp     x8, #0x8f38000
006A8427C  ldr      x8, [x8, #0x4c8]
006A84280  ldr      x2, [x8]
006A84284  ldrb     w8, [x2, #0x53]
006A84288  tbnz     w8, #5, #0x6a842a0
006A8428C  mov      x0, x19
006A84290  str      x20, [x0, #0x40]!
006A84294  mov      x1, x20
006A84298  bl       #0x382bcb8 ; 
006A8429C  b        #0x6a842b0 ; 
006A842A0  ldr      x8, [x2, #0x60]
006A842A4  mov      x0, x19
006A842A8  mov      x1, x20
006A842AC  blr      x8
006A842B0  mov      x0, x19
006A842B4  mov      x1, xzr
006A842B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A842BC  adrp     x21, #0x959e000
006A842C0  ldrb     w8, [x21, #0x52b]
006A842C4  mov      w20, w0
006A842C8  cbnz     w8, #0x6a842e0
006A842CC  adrp     x0, #0x8f38000
006A842D0  ldr      x0, [x0, #0x4d8]
006A842D4  bl       #0x382bd14 ; 
006A842D8  mov      w8, #1
006A842DC  strb     w8, [x21, #0x52b]
006A842E0  adrp     x8, #0x8f38000
006A842E4  ldr      x8, [x8, #0x4d8]
006A842E8  ldr      x2, [x8]
006A842EC  ldrb     w8, [x2, #0x53]
006A842F0  tbnz     w8, #5, #0x6a842fc
006A842F4  str      w20, [x19, #0x48]
006A842F8  b        #0x6a8430c ; 
006A842FC  ldr      x8, [x2, #0x60]
006A84300  mov      x0, x19
006A84304  mov      w1, w20
006A84308  blr      x8
006A8430C  mov      x0, x19
006A84310  mov      x1, xzr
006A84314  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A84318  adrp     x21, #0x959e000
006A8431C  ldrb     w8, [x21, #0x52c]
006A84320  mov      w20, w0
006A84324  cbnz     w8, #0x6a8433c
006A84328  adrp     x0, #0x8f38000
006A8432C  ldr      x0, [x0, #0x4e8]
006A84330  bl       #0x382bd14 ; 
006A84334  mov      w8, #1
006A84338  strb     w8, [x21, #0x52c]
006A8433C  adrp     x8, #0x8f38000
006A84340  ldr      x8, [x8, #0x4e8]
006A84344  ldr      x2, [x8]
006A84348  ldrb     w8, [x2, #0x53]
006A8434C  tbnz     w8, #5, #0x6a84358
006A84350  str      w20, [x19, #0x4c]
006A84354  b        #0x6a84368 ; 
006A84358  ldr      x8, [x2, #0x60]
006A8435C  mov      x0, x19
006A84360  mov      w1, w20
006A84364  blr      x8
006A84368  ldp      x20, x19, [sp, #0x10]
006A8436C  mov      w0, #1
006A84370  ldp      x30, x21, [sp], #0x20
006A84374  ret      

