; LocalModels.Bean.Tips_Sheet1$$readImpl
; RVA 0x6B164E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B164E0  stp      x30, x21, [sp, #-0x20]!
006B164E4  stp      x20, x19, [sp, #0x10]
006B164E8  adrp     x20, #0x959f000
006B164EC  adrp     x21, #0x8f3f000
006B164F0  ldrb     w8, [x20, #0x5d6]
006B164F4  ldr      x21, [x21, #0xe8]
006B164F8  mov      x19, x0
006B164FC  tbnz     w8, #0, #0x6b16514
006B16500  adrp     x0, #0x8f3f000
006B16504  ldr      x0, [x0, #0xe8]
006B16508  bl       #0x382bd14 ; 
006B1650C  mov      w8, #1
006B16510  strb     w8, [x20, #0x5d6]
006B16514  ldr      x1, [x21]
006B16518  ldrb     w8, [x1, #0x53]
006B1651C  tbnz     w8, #5, #0x6b1656c
006B16520  mov      x0, x19
006B16524  mov      x1, xzr
006B16528  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1652C  adrp     x21, #0x959f000
006B16530  ldrb     w8, [x21, #0x9e3]
006B16534  mov      w20, w0
006B16538  cbnz     w8, #0x6b16550
006B1653C  adrp     x0, #0x8f3f000
006B16540  ldr      x0, [x0, #0x90]
006B16544  bl       #0x382bd14 ; 
006B16548  mov      w8, #1
006B1654C  strb     w8, [x21, #0x9e3]
006B16550  adrp     x8, #0x8f3f000
006B16554  ldr      x8, [x8, #0x90]
006B16558  ldr      x2, [x8]
006B1655C  ldrb     w8, [x2, #0x53]
006B16560  tbnz     w8, #5, #0x6b16580
006B16564  str      w20, [x19, #0x20]
006B16568  b        #0x6b16590 ; 
006B1656C  ldr      x2, [x1, #0x60]
006B16570  mov      x0, x19
006B16574  ldp      x20, x19, [sp, #0x10]
006B16578  ldp      x30, x21, [sp], #0x20
006B1657C  br       x2
006B16580  ldr      x8, [x2, #0x60]
006B16584  mov      x0, x19
006B16588  mov      w1, w20
006B1658C  blr      x8
006B16590  mov      x0, x19
006B16594  mov      x1, xzr
006B16598  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1659C  adrp     x21, #0x959f000
006B165A0  ldrb     w8, [x21, #0x9e4]
006B165A4  mov      x20, x0
006B165A8  cbnz     w8, #0x6b165c0
006B165AC  adrp     x0, #0x8f3f000
006B165B0  ldr      x0, [x0, #0xa0]
006B165B4  bl       #0x382bd14 ; 
006B165B8  mov      w8, #1
006B165BC  strb     w8, [x21, #0x9e4]
006B165C0  adrp     x8, #0x8f3f000
006B165C4  ldr      x8, [x8, #0xa0]
006B165C8  ldr      x2, [x8]
006B165CC  ldrb     w8, [x2, #0x53]
006B165D0  tbnz     w8, #5, #0x6b165e8
006B165D4  mov      x0, x19
006B165D8  str      x20, [x0, #0x28]!
006B165DC  mov      x1, x20
006B165E0  bl       #0x382bcb8 ; 
006B165E4  b        #0x6b165f8 ; 
006B165E8  ldr      x8, [x2, #0x60]
006B165EC  mov      x0, x19
006B165F0  mov      x1, x20
006B165F4  blr      x8
006B165F8  mov      x0, x19
006B165FC  mov      x1, xzr
006B16600  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B16604  adrp     x21, #0x959f000
006B16608  ldrb     w8, [x21, #0x9e5]
006B1660C  mov      x20, x0
006B16610  cbnz     w8, #0x6b16628
006B16614  adrp     x0, #0x8f3f000
006B16618  ldr      x0, [x0, #0xb0]
006B1661C  bl       #0x382bd14 ; 
006B16620  mov      w8, #1
006B16624  strb     w8, [x21, #0x9e5]
006B16628  adrp     x8, #0x8f3f000
006B1662C  ldr      x8, [x8, #0xb0]
006B16630  ldr      x2, [x8]
006B16634  ldrb     w8, [x2, #0x53]
006B16638  tbnz     w8, #5, #0x6b16650
006B1663C  mov      x0, x19
006B16640  str      x20, [x0, #0x30]!
006B16644  mov      x1, x20
006B16648  bl       #0x382bcb8 ; 
006B1664C  b        #0x6b16660 ; 
006B16650  ldr      x8, [x2, #0x60]
006B16654  mov      x0, x19
006B16658  mov      x1, x20
006B1665C  blr      x8
006B16660  mov      x0, x19
006B16664  mov      x1, xzr
006B16668  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1666C  adrp     x21, #0x959f000
006B16670  ldrb     w8, [x21, #0x9e6]
006B16674  mov      w20, w0
006B16678  cbnz     w8, #0x6b16690
006B1667C  adrp     x0, #0x8f3f000
006B16680  ldr      x0, [x0, #0xc0]
006B16684  bl       #0x382bd14 ; 
006B16688  mov      w8, #1
006B1668C  strb     w8, [x21, #0x9e6]
006B16690  adrp     x8, #0x8f3f000
006B16694  ldr      x8, [x8, #0xc0]
006B16698  ldr      x2, [x8]
006B1669C  ldrb     w8, [x2, #0x53]
006B166A0  tbnz     w8, #5, #0x6b166ac
006B166A4  str      w20, [x19, #0x38]
006B166A8  b        #0x6b166bc ; 
006B166AC  ldr      x8, [x2, #0x60]
006B166B0  mov      x0, x19
006B166B4  mov      w1, w20
006B166B8  blr      x8
006B166BC  mov      x0, x19
006B166C0  mov      x1, xzr
006B166C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B166C8  adrp     x21, #0x959f000
006B166CC  ldrb     w8, [x21, #0x9e7]
006B166D0  mov      x20, x0
006B166D4  cbnz     w8, #0x6b166ec
006B166D8  adrp     x0, #0x8f3f000
006B166DC  ldr      x0, [x0, #0xd0]
006B166E0  bl       #0x382bd14 ; 
006B166E4  mov      w8, #1
006B166E8  strb     w8, [x21, #0x9e7]
006B166EC  adrp     x8, #0x8f3f000
006B166F0  ldr      x8, [x8, #0xd0]
006B166F4  ldr      x2, [x8]
006B166F8  ldrb     w8, [x2, #0x53]
006B166FC  tbnz     w8, #5, #0x6b16714
006B16700  mov      x0, x19
006B16704  str      x20, [x0, #0x40]!
006B16708  mov      x1, x20
006B1670C  bl       #0x382bcb8 ; 
006B16710  b        #0x6b16724 ; 
006B16714  ldr      x8, [x2, #0x60]
006B16718  mov      x0, x19
006B1671C  mov      x1, x20
006B16720  blr      x8
006B16724  mov      x0, x19
006B16728  mov      x1, xzr
006B1672C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B16730  adrp     x21, #0x959f000
006B16734  ldrb     w8, [x21, #0x9e8]
006B16738  mov      x20, x0
006B1673C  cbnz     w8, #0x6b16754
006B16740  adrp     x0, #0x8f3f000
006B16744  ldr      x0, [x0, #0xe0]
006B16748  bl       #0x382bd14 ; 
006B1674C  mov      w8, #1
006B16750  strb     w8, [x21, #0x9e8]
006B16754  adrp     x8, #0x8f3f000
006B16758  ldr      x8, [x8, #0xe0]
006B1675C  ldr      x2, [x8]
006B16760  ldrb     w8, [x2, #0x53]
006B16764  tbnz     w8, #5, #0x6b1677c
006B16768  str      x20, [x19, #0x48]!
006B1676C  mov      x0, x19
006B16770  mov      x1, x20
006B16774  bl       #0x382bcb8 ; 
006B16778  b        #0x6b1678c ; 
006B1677C  ldr      x8, [x2, #0x60]
006B16780  mov      x0, x19
006B16784  mov      x1, x20
006B16788  blr      x8
006B1678C  ldp      x20, x19, [sp, #0x10]
006B16790  mov      w0, #1
006B16794  ldp      x30, x21, [sp], #0x20
006B16798  ret      

