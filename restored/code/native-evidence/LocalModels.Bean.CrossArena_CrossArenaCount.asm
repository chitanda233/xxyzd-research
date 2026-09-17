; LocalModels.Bean.CrossArena_CrossArenaCount$$readImpl
; RVA 0x6A535A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A535A0  stp      x30, x21, [sp, #-0x20]!
006A535A4  stp      x20, x19, [sp, #0x10]
006A535A8  adrp     x20, #0x959d000
006A535AC  adrp     x21, #0x8f35000
006A535B0  ldrb     w8, [x20, #0xa9d]
006A535B4  ldr      x21, [x21, #0xff8]
006A535B8  mov      x19, x0
006A535BC  tbnz     w8, #0, #0x6a535d4
006A535C0  adrp     x0, #0x8f35000
006A535C4  ldr      x0, [x0, #0xff8]
006A535C8  bl       #0x382bd14 ; 
006A535CC  mov      w8, #1
006A535D0  strb     w8, [x20, #0xa9d]
006A535D4  ldr      x1, [x21]
006A535D8  ldrb     w8, [x1, #0x53]
006A535DC  tbnz     w8, #5, #0x6a5362c
006A535E0  mov      x0, x19
006A535E4  mov      x1, xzr
006A535E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A535EC  adrp     x21, #0x959e000
006A535F0  ldrb     w8, [x21, #0x30c]
006A535F4  mov      w20, w0
006A535F8  cbnz     w8, #0x6a53610
006A535FC  adrp     x0, #0x8f35000
006A53600  ldr      x0, [x0, #0xfc0]
006A53604  bl       #0x382bd14 ; 
006A53608  mov      w8, #1
006A5360C  strb     w8, [x21, #0x30c]
006A53610  adrp     x8, #0x8f35000
006A53614  ldr      x8, [x8, #0xfc0]
006A53618  ldr      x2, [x8]
006A5361C  ldrb     w8, [x2, #0x53]
006A53620  tbnz     w8, #5, #0x6a53640
006A53624  str      w20, [x19, #0x20]
006A53628  b        #0x6a53650 ; 
006A5362C  ldr      x2, [x1, #0x60]
006A53630  mov      x0, x19
006A53634  ldp      x20, x19, [sp, #0x10]
006A53638  ldp      x30, x21, [sp], #0x20
006A5363C  br       x2
006A53640  ldr      x8, [x2, #0x60]
006A53644  mov      x0, x19
006A53648  mov      w1, w20
006A5364C  blr      x8
006A53650  mov      x0, x19
006A53654  mov      x1, xzr
006A53658  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5365C  adrp     x21, #0x959e000
006A53660  ldrb     w8, [x21, #0x30d]
006A53664  mov      w20, w0
006A53668  cbnz     w8, #0x6a53680
006A5366C  adrp     x0, #0x8f35000
006A53670  ldr      x0, [x0, #0xfd0]
006A53674  bl       #0x382bd14 ; 
006A53678  mov      w8, #1
006A5367C  strb     w8, [x21, #0x30d]
006A53680  adrp     x8, #0x8f35000
006A53684  ldr      x8, [x8, #0xfd0]
006A53688  ldr      x2, [x8]
006A5368C  ldrb     w8, [x2, #0x53]
006A53690  tbnz     w8, #5, #0x6a5369c
006A53694  str      w20, [x19, #0x24]
006A53698  b        #0x6a536ac ; 
006A5369C  ldr      x8, [x2, #0x60]
006A536A0  mov      x0, x19
006A536A4  mov      w1, w20
006A536A8  blr      x8
006A536AC  mov      x0, x19
006A536B0  mov      x1, xzr
006A536B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A536B8  adrp     x21, #0x959e000
006A536BC  ldrb     w8, [x21, #0x30e]
006A536C0  mov      w20, w0
006A536C4  cbnz     w8, #0x6a536dc
006A536C8  adrp     x0, #0x8f35000
006A536CC  ldr      x0, [x0, #0xfe0]
006A536D0  bl       #0x382bd14 ; 
006A536D4  mov      w8, #1
006A536D8  strb     w8, [x21, #0x30e]
006A536DC  adrp     x8, #0x8f35000
006A536E0  ldr      x8, [x8, #0xfe0]
006A536E4  ldr      x2, [x8]
006A536E8  ldrb     w8, [x2, #0x53]
006A536EC  tbnz     w8, #5, #0x6a536f8
006A536F0  str      w20, [x19, #0x28]
006A536F4  b        #0x6a53708 ; 
006A536F8  ldr      x8, [x2, #0x60]
006A536FC  mov      x0, x19
006A53700  mov      w1, w20
006A53704  blr      x8
006A53708  mov      x0, x19
006A5370C  mov      x1, xzr
006A53710  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A53714  adrp     x21, #0x959e000
006A53718  ldrb     w8, [x21, #0x30f]
006A5371C  mov      w20, w0
006A53720  cbnz     w8, #0x6a53738
006A53724  adrp     x0, #0x8f35000
006A53728  ldr      x0, [x0, #0xff0]
006A5372C  bl       #0x382bd14 ; 
006A53730  mov      w8, #1
006A53734  strb     w8, [x21, #0x30f]
006A53738  adrp     x8, #0x8f35000
006A5373C  ldr      x8, [x8, #0xff0]
006A53740  ldr      x2, [x8]
006A53744  ldrb     w8, [x2, #0x53]
006A53748  tbnz     w8, #5, #0x6a53754
006A5374C  str      w20, [x19, #0x2c]
006A53750  b        #0x6a53764 ; 
006A53754  ldr      x8, [x2, #0x60]
006A53758  mov      x0, x19
006A5375C  mov      w1, w20
006A53760  blr      x8
006A53764  ldp      x20, x19, [sp, #0x10]
006A53768  mov      w0, #1
006A5376C  ldp      x30, x21, [sp], #0x20
006A53770  ret      

