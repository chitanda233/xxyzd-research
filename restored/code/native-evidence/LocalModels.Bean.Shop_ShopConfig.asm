; LocalModels.Bean.Shop_ShopConfig$$readImpl
; RVA 0x6AF0058; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF0058  str      d8, [sp, #-0x30]!
006AF005C  stp      x30, x21, [sp, #0x10]
006AF0060  stp      x20, x19, [sp, #0x20]
006AF0064  adrp     x20, #0x959e000
006AF0068  adrp     x21, #0x8f3d000
006AF006C  ldrb     w8, [x20, #0xe58]
006AF0070  ldr      x21, [x21, #0x5d8]
006AF0074  mov      x19, x0
006AF0078  tbnz     w8, #0, #0x6af0090
006AF007C  adrp     x0, #0x8f3d000
006AF0080  ldr      x0, [x0, #0x5d8]
006AF0084  bl       #0x382bd14 ; 
006AF0088  mov      w8, #1
006AF008C  strb     w8, [x20, #0xe58]
006AF0090  ldr      x1, [x21]
006AF0094  ldrb     w8, [x1, #0x53]
006AF0098  tbnz     w8, #5, #0x6af00f4
006AF009C  mov      x0, x19
006AF00A0  mov      x1, xzr
006AF00A4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF00A8  adrp     x21, #0x959f000
006AF00AC  ldrb     w8, [x21, #0x23c]
006AF00B0  mov      x20, x0
006AF00B4  cbnz     w8, #0x6af00cc
006AF00B8  adrp     x0, #0x8f3d000
006AF00BC  ldr      x0, [x0, #0x560]
006AF00C0  bl       #0x382bd14 ; 
006AF00C4  mov      w8, #1
006AF00C8  strb     w8, [x21, #0x23c]
006AF00CC  adrp     x8, #0x8f3d000
006AF00D0  ldr      x8, [x8, #0x560]
006AF00D4  ldr      x2, [x8]
006AF00D8  ldrb     w8, [x2, #0x53]
006AF00DC  tbnz     w8, #5, #0x6af010c
006AF00E0  mov      x0, x19
006AF00E4  str      x20, [x0, #0x20]!
006AF00E8  mov      x1, x20
006AF00EC  bl       #0x382bcb8 ; 
006AF00F0  b        #0x6af011c ; 
006AF00F4  ldr      x2, [x1, #0x60]
006AF00F8  mov      x0, x19
006AF00FC  ldp      x20, x19, [sp, #0x20]
006AF0100  ldp      x30, x21, [sp, #0x10]
006AF0104  ldr      d8, [sp], #0x30
006AF0108  br       x2
006AF010C  ldr      x8, [x2, #0x60]
006AF0110  mov      x0, x19
006AF0114  mov      x1, x20
006AF0118  blr      x8
006AF011C  mov      x0, x19
006AF0120  mov      x1, xzr
006AF0124  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF0128  adrp     x21, #0x959f000
006AF012C  ldrb     w8, [x21, #0x23d]
006AF0130  mov      x20, x0
006AF0134  cbnz     w8, #0x6af014c
006AF0138  adrp     x0, #0x8f3d000
006AF013C  ldr      x0, [x0, #0x570]
006AF0140  bl       #0x382bd14 ; 
006AF0144  mov      w8, #1
006AF0148  strb     w8, [x21, #0x23d]
006AF014C  adrp     x8, #0x8f3d000
006AF0150  ldr      x8, [x8, #0x570]
006AF0154  ldr      x2, [x8]
006AF0158  ldrb     w8, [x2, #0x53]
006AF015C  tbnz     w8, #5, #0x6af0174
006AF0160  mov      x0, x19
006AF0164  str      x20, [x0, #0x28]!
006AF0168  mov      x1, x20
006AF016C  bl       #0x382bcb8 ; 
006AF0170  b        #0x6af0184 ; 
006AF0174  ldr      x8, [x2, #0x60]
006AF0178  mov      x0, x19
006AF017C  mov      x1, x20
006AF0180  blr      x8
006AF0184  mov      x0, x19
006AF0188  mov      x1, xzr
006AF018C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF0190  adrp     x21, #0x959f000
006AF0194  ldrb     w8, [x21, #0x23e]
006AF0198  mov      w20, w0
006AF019C  cbnz     w8, #0x6af01b4
006AF01A0  adrp     x0, #0x8f3d000
006AF01A4  ldr      x0, [x0, #0x580]
006AF01A8  bl       #0x382bd14 ; 
006AF01AC  mov      w8, #1
006AF01B0  strb     w8, [x21, #0x23e]
006AF01B4  adrp     x8, #0x8f3d000
006AF01B8  ldr      x8, [x8, #0x580]
006AF01BC  ldr      x2, [x8]
006AF01C0  ldrb     w8, [x2, #0x53]
006AF01C4  tbnz     w8, #5, #0x6af01d0
006AF01C8  str      w20, [x19, #0x30]
006AF01CC  b        #0x6af01e0 ; 
006AF01D0  ldr      x8, [x2, #0x60]
006AF01D4  mov      x0, x19
006AF01D8  mov      w1, w20
006AF01DC  blr      x8
006AF01E0  mov      x0, x19
006AF01E4  mov      x1, xzr
006AF01E8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AF01EC  adrp     x21, #0x959f000
006AF01F0  ldrb     w8, [x21, #0x23f]
006AF01F4  mov      x20, x0
006AF01F8  cbnz     w8, #0x6af0210
006AF01FC  adrp     x0, #0x8f3d000
006AF0200  ldr      x0, [x0, #0x590]
006AF0204  bl       #0x382bd14 ; 
006AF0208  mov      w8, #1
006AF020C  strb     w8, [x21, #0x23f]
006AF0210  adrp     x8, #0x8f3d000
006AF0214  ldr      x8, [x8, #0x590]
006AF0218  ldr      x2, [x8]
006AF021C  ldrb     w8, [x2, #0x53]
006AF0220  tbnz     w8, #5, #0x6af0238
006AF0224  mov      x0, x19
006AF0228  str      x20, [x0, #0x38]!
006AF022C  mov      x1, x20
006AF0230  bl       #0x382bcb8 ; 
006AF0234  b        #0x6af0248 ; 
006AF0238  ldr      x8, [x2, #0x60]
006AF023C  mov      x0, x19
006AF0240  mov      x1, x20
006AF0244  blr      x8
006AF0248  mov      x0, x19
006AF024C  mov      x1, xzr
006AF0250  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF0254  adrp     x21, #0x959f000
006AF0258  ldrb     w8, [x21, #0x240]
006AF025C  mov      x20, x0
006AF0260  cbnz     w8, #0x6af0278
006AF0264  adrp     x0, #0x8f3d000
006AF0268  ldr      x0, [x0, #0x5a0]
006AF026C  bl       #0x382bd14 ; 
006AF0270  mov      w8, #1
006AF0274  strb     w8, [x21, #0x240]
006AF0278  adrp     x8, #0x8f3d000
006AF027C  ldr      x8, [x8, #0x5a0]
006AF0280  ldr      x2, [x8]
006AF0284  ldrb     w8, [x2, #0x53]
006AF0288  tbnz     w8, #5, #0x6af02a0
006AF028C  mov      x0, x19
006AF0290  str      x20, [x0, #0x40]!
006AF0294  mov      x1, x20
006AF0298  bl       #0x382bcb8 ; 
006AF029C  b        #0x6af02b0 ; 
006AF02A0  ldr      x8, [x2, #0x60]
006AF02A4  mov      x0, x19
006AF02A8  mov      x1, x20
006AF02AC  blr      x8
006AF02B0  mov      x0, x19
006AF02B4  mov      x1, xzr
006AF02B8  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006AF02BC  adrp     x20, #0x959f000
006AF02C0  ldrb     w8, [x20, #0x241]
006AF02C4  mov      v8.16b, v0.16b
006AF02C8  cbnz     w8, #0x6af02e0
006AF02CC  adrp     x0, #0x8f3d000
006AF02D0  ldr      x0, [x0, #0x5b0]
006AF02D4  bl       #0x382bd14 ; 
006AF02D8  mov      w8, #1
006AF02DC  strb     w8, [x20, #0x241]
006AF02E0  adrp     x8, #0x8f3d000
006AF02E4  ldr      x8, [x8, #0x5b0]
006AF02E8  ldr      x1, [x8]
006AF02EC  ldrb     w8, [x1, #0x53]
006AF02F0  tbnz     w8, #5, #0x6af02fc
006AF02F4  str      s8, [x19, #0x48]
006AF02F8  b        #0x6af030c ; 
006AF02FC  ldr      x8, [x1, #0x60]
006AF0300  mov      x0, x19
006AF0304  mov      v0.16b, v8.16b
006AF0308  blr      x8
006AF030C  mov      x0, x19
006AF0310  mov      x1, xzr
006AF0314  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
006AF0318  adrp     x21, #0x959f000
006AF031C  ldrb     w8, [x21, #0x242]
006AF0320  mov      x20, x0
006AF0324  cbnz     w8, #0x6af033c
006AF0328  adrp     x0, #0x8f3d000
006AF032C  ldr      x0, [x0, #0x5c0]
006AF0330  bl       #0x382bd14 ; 
006AF0334  mov      w8, #1
006AF0338  strb     w8, [x21, #0x242]
006AF033C  adrp     x8, #0x8f3d000
006AF0340  ldr      x8, [x8, #0x5c0]
006AF0344  ldr      x2, [x8]
006AF0348  ldrb     w8, [x2, #0x53]
006AF034C  tbnz     w8, #5, #0x6af0364
006AF0350  mov      x0, x19
006AF0354  str      x20, [x0, #0x50]!
006AF0358  mov      x1, x20
006AF035C  bl       #0x382bcb8 ; 
006AF0360  b        #0x6af0374 ; 
006AF0364  ldr      x8, [x2, #0x60]
006AF0368  mov      x0, x19
006AF036C  mov      x1, x20
006AF0370  blr      x8
006AF0374  mov      x0, x19
006AF0378  mov      x1, xzr
006AF037C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF0380  adrp     x21, #0x959f000
006AF0384  ldrb     w8, [x21, #0x243]
006AF0388  mov      x20, x0
006AF038C  cbnz     w8, #0x6af03a4
006AF0390  adrp     x0, #0x8f3d000
006AF0394  ldr      x0, [x0, #0x5d0]
006AF0398  bl       #0x382bd14 ; 
006AF039C  mov      w8, #1
006AF03A0  strb     w8, [x21, #0x243]
006AF03A4  adrp     x8, #0x8f3d000
006AF03A8  ldr      x8, [x8, #0x5d0]
006AF03AC  ldr      x2, [x8]
006AF03B0  ldrb     w8, [x2, #0x53]
006AF03B4  tbnz     w8, #5, #0x6af03cc
006AF03B8  str      x20, [x19, #0x58]!
006AF03BC  mov      x0, x19
006AF03C0  mov      x1, x20
006AF03C4  bl       #0x382bcb8 ; 
006AF03C8  b        #0x6af03dc ; 
006AF03CC  ldr      x8, [x2, #0x60]
006AF03D0  mov      x0, x19
006AF03D4  mov      x1, x20
006AF03D8  blr      x8
006AF03DC  ldp      x20, x19, [sp, #0x20]
006AF03E0  ldp      x30, x21, [sp, #0x10]
006AF03E4  mov      w0, #1
006AF03E8  ldr      d8, [sp], #0x30
006AF03EC  ret      

