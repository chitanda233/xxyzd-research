; LocalModels.Bean.Task_ScoreBoxReward$$readImpl
; RVA 0x6B13154; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B13154  stp      x30, x21, [sp, #-0x20]!
006B13158  stp      x20, x19, [sp, #0x10]
006B1315C  adrp     x20, #0x959f000
006B13160  adrp     x21, #0x8f3e000
006B13164  ldrb     w8, [x20, #0x57e]
006B13168  ldr      x21, [x21, #0xe58]
006B1316C  mov      x19, x0
006B13170  tbnz     w8, #0, #0x6b13188
006B13174  adrp     x0, #0x8f3e000
006B13178  ldr      x0, [x0, #0xe58]
006B1317C  bl       #0x382bd14 ; 
006B13180  mov      w8, #1
006B13184  strb     w8, [x20, #0x57e]
006B13188  ldr      x1, [x21]
006B1318C  ldrb     w8, [x1, #0x53]
006B13190  tbnz     w8, #5, #0x6b131e0
006B13194  mov      x0, x19
006B13198  mov      x1, xzr
006B1319C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B131A0  adrp     x21, #0x959f000
006B131A4  ldrb     w8, [x21, #0x9c2]
006B131A8  mov      w20, w0
006B131AC  cbnz     w8, #0x6b131c4
006B131B0  adrp     x0, #0x8f3e000
006B131B4  ldr      x0, [x0, #0xe20]
006B131B8  bl       #0x382bd14 ; 
006B131BC  mov      w8, #1
006B131C0  strb     w8, [x21, #0x9c2]
006B131C4  adrp     x8, #0x8f3e000
006B131C8  ldr      x8, [x8, #0xe20]
006B131CC  ldr      x2, [x8]
006B131D0  ldrb     w8, [x2, #0x53]
006B131D4  tbnz     w8, #5, #0x6b131f4
006B131D8  str      w20, [x19, #0x20]
006B131DC  b        #0x6b13204 ; 
006B131E0  ldr      x2, [x1, #0x60]
006B131E4  mov      x0, x19
006B131E8  ldp      x20, x19, [sp, #0x10]
006B131EC  ldp      x30, x21, [sp], #0x20
006B131F0  br       x2
006B131F4  ldr      x8, [x2, #0x60]
006B131F8  mov      x0, x19
006B131FC  mov      w1, w20
006B13200  blr      x8
006B13204  mov      x0, x19
006B13208  mov      x1, xzr
006B1320C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B13210  adrp     x21, #0x959f000
006B13214  ldrb     w8, [x21, #0x9c3]
006B13218  mov      w20, w0
006B1321C  cbnz     w8, #0x6b13234
006B13220  adrp     x0, #0x8f3e000
006B13224  ldr      x0, [x0, #0xe30]
006B13228  bl       #0x382bd14 ; 
006B1322C  mov      w8, #1
006B13230  strb     w8, [x21, #0x9c3]
006B13234  adrp     x8, #0x8f3e000
006B13238  ldr      x8, [x8, #0xe30]
006B1323C  ldr      x2, [x8]
006B13240  ldrb     w8, [x2, #0x53]
006B13244  tbnz     w8, #5, #0x6b13250
006B13248  str      w20, [x19, #0x24]
006B1324C  b        #0x6b13260 ; 
006B13250  ldr      x8, [x2, #0x60]
006B13254  mov      x0, x19
006B13258  mov      w1, w20
006B1325C  blr      x8
006B13260  mov      x0, x19
006B13264  mov      x1, xzr
006B13268  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1326C  adrp     x21, #0x959f000
006B13270  ldrb     w8, [x21, #0x9c4]
006B13274  mov      w20, w0
006B13278  cbnz     w8, #0x6b13290
006B1327C  adrp     x0, #0x8f3e000
006B13280  ldr      x0, [x0, #0xe40]
006B13284  bl       #0x382bd14 ; 
006B13288  mov      w8, #1
006B1328C  strb     w8, [x21, #0x9c4]
006B13290  adrp     x8, #0x8f3e000
006B13294  ldr      x8, [x8, #0xe40]
006B13298  ldr      x2, [x8]
006B1329C  ldrb     w8, [x2, #0x53]
006B132A0  tbnz     w8, #5, #0x6b132ac
006B132A4  str      w20, [x19, #0x28]
006B132A8  b        #0x6b132bc ; 
006B132AC  ldr      x8, [x2, #0x60]
006B132B0  mov      x0, x19
006B132B4  mov      w1, w20
006B132B8  blr      x8
006B132BC  mov      x0, x19
006B132C0  mov      x1, xzr
006B132C4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B132C8  adrp     x21, #0x959f000
006B132CC  ldrb     w8, [x21, #0x9c5]
006B132D0  mov      x20, x0
006B132D4  cbnz     w8, #0x6b132ec
006B132D8  adrp     x0, #0x8f3e000
006B132DC  ldr      x0, [x0, #0xe50]
006B132E0  bl       #0x382bd14 ; 
006B132E4  mov      w8, #1
006B132E8  strb     w8, [x21, #0x9c5]
006B132EC  adrp     x8, #0x8f3e000
006B132F0  ldr      x8, [x8, #0xe50]
006B132F4  ldr      x2, [x8]
006B132F8  ldrb     w8, [x2, #0x53]
006B132FC  tbnz     w8, #5, #0x6b13314
006B13300  str      x20, [x19, #0x30]!
006B13304  mov      x0, x19
006B13308  mov      x1, x20
006B1330C  bl       #0x382bcb8 ; 
006B13310  b        #0x6b13324 ; 
006B13314  ldr      x8, [x2, #0x60]
006B13318  mov      x0, x19
006B1331C  mov      x1, x20
006B13320  blr      x8
006B13324  ldp      x20, x19, [sp, #0x10]
006B13328  mov      w0, #1
006B1332C  ldp      x30, x21, [sp], #0x20
006B13330  ret      

