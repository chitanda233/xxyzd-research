; LocalModels.Bean.Collection_TreasureStar$$readImpl
; RVA 0x68CDE80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CDE80  stp      x30, x21, [sp, #-0x20]!
0068CDE84  stp      x20, x19, [sp, #0x10]
0068CDE88  adrp     x20, #0x959c000
0068CDE8C  adrp     x21, #0x8f28000
0068CDE90  ldrb     w8, [x20, #0x36f]
0068CDE94  ldr      x21, [x21, #0x4f8]
0068CDE98  mov      x19, x0
0068CDE9C  tbnz     w8, #0, #0x68cdeb4
0068CDEA0  adrp     x0, #0x8f28000
0068CDEA4  ldr      x0, [x0, #0x4f8]
0068CDEA8  bl       #0x382bd14 ; 
0068CDEAC  mov      w8, #1
0068CDEB0  strb     w8, [x20, #0x36f]
0068CDEB4  ldr      x1, [x21]
0068CDEB8  ldrb     w8, [x1, #0x53]
0068CDEBC  tbnz     w8, #5, #0x68cdf0c
0068CDEC0  mov      x0, x19
0068CDEC4  mov      x1, xzr
0068CDEC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CDECC  adrp     x21, #0x959c000
0068CDED0  ldrb     w8, [x21, #0x737]
0068CDED4  mov      w20, w0
0068CDED8  cbnz     w8, #0x68cdef0
0068CDEDC  adrp     x0, #0x8f28000
0068CDEE0  ldr      x0, [x0, #0x470]
0068CDEE4  bl       #0x382bd14 ; 
0068CDEE8  mov      w8, #1
0068CDEEC  strb     w8, [x21, #0x737]
0068CDEF0  adrp     x8, #0x8f28000
0068CDEF4  ldr      x8, [x8, #0x470]
0068CDEF8  ldr      x2, [x8]
0068CDEFC  ldrb     w8, [x2, #0x53]
0068CDF00  tbnz     w8, #5, #0x68cdf20
0068CDF04  str      w20, [x19, #0x20]
0068CDF08  b        #0x68cdf30 ; 
0068CDF0C  ldr      x2, [x1, #0x60]
0068CDF10  mov      x0, x19
0068CDF14  ldp      x20, x19, [sp, #0x10]
0068CDF18  ldp      x30, x21, [sp], #0x20
0068CDF1C  br       x2
0068CDF20  ldr      x8, [x2, #0x60]
0068CDF24  mov      x0, x19
0068CDF28  mov      w1, w20
0068CDF2C  blr      x8
0068CDF30  mov      x0, x19
0068CDF34  mov      x1, xzr
0068CDF38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CDF3C  adrp     x21, #0x959c000
0068CDF40  ldrb     w8, [x21, #0x738]
0068CDF44  mov      w20, w0
0068CDF48  cbnz     w8, #0x68cdf60
0068CDF4C  adrp     x0, #0x8f28000
0068CDF50  ldr      x0, [x0, #0x480]
0068CDF54  bl       #0x382bd14 ; 
0068CDF58  mov      w8, #1
0068CDF5C  strb     w8, [x21, #0x738]
0068CDF60  adrp     x8, #0x8f28000
0068CDF64  ldr      x8, [x8, #0x480]
0068CDF68  ldr      x2, [x8]
0068CDF6C  ldrb     w8, [x2, #0x53]
0068CDF70  tbnz     w8, #5, #0x68cdf7c
0068CDF74  str      w20, [x19, #0x24]
0068CDF78  b        #0x68cdf8c ; 
0068CDF7C  ldr      x8, [x2, #0x60]
0068CDF80  mov      x0, x19
0068CDF84  mov      w1, w20
0068CDF88  blr      x8
0068CDF8C  mov      x0, x19
0068CDF90  mov      x1, xzr
0068CDF94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CDF98  adrp     x21, #0x959c000
0068CDF9C  ldrb     w8, [x21, #0x739]
0068CDFA0  mov      w20, w0
0068CDFA4  cbnz     w8, #0x68cdfbc
0068CDFA8  adrp     x0, #0x8f28000
0068CDFAC  ldr      x0, [x0, #0x490]
0068CDFB0  bl       #0x382bd14 ; 
0068CDFB4  mov      w8, #1
0068CDFB8  strb     w8, [x21, #0x739]
0068CDFBC  adrp     x8, #0x8f28000
0068CDFC0  ldr      x8, [x8, #0x490]
0068CDFC4  ldr      x2, [x8]
0068CDFC8  ldrb     w8, [x2, #0x53]
0068CDFCC  tbnz     w8, #5, #0x68cdfd8
0068CDFD0  str      w20, [x19, #0x28]
0068CDFD4  b        #0x68cdfe8 ; 
0068CDFD8  ldr      x8, [x2, #0x60]
0068CDFDC  mov      x0, x19
0068CDFE0  mov      w1, w20
0068CDFE4  blr      x8
0068CDFE8  mov      x0, x19
0068CDFEC  mov      x1, xzr
0068CDFF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CDFF4  adrp     x21, #0x959c000
0068CDFF8  ldrb     w8, [x21, #0x73a]
0068CDFFC  mov      w20, w0
0068CE000  cbnz     w8, #0x68ce018
0068CE004  adrp     x0, #0x8f28000
0068CE008  ldr      x0, [x0, #0x4a0]
0068CE00C  bl       #0x382bd14 ; 
0068CE010  mov      w8, #1
0068CE014  strb     w8, [x21, #0x73a]
0068CE018  adrp     x8, #0x8f28000
0068CE01C  ldr      x8, [x8, #0x4a0]
0068CE020  ldr      x2, [x8]
0068CE024  ldrb     w8, [x2, #0x53]
0068CE028  tbnz     w8, #5, #0x68ce034
0068CE02C  str      w20, [x19, #0x2c]
0068CE030  b        #0x68ce044 ; 
0068CE034  ldr      x8, [x2, #0x60]
0068CE038  mov      x0, x19
0068CE03C  mov      w1, w20
0068CE040  blr      x8
0068CE044  mov      x0, x19
0068CE048  mov      x1, xzr
0068CE04C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068CE050  adrp     x21, #0x959c000
0068CE054  ldrb     w8, [x21, #0x73b]
0068CE058  mov      x20, x0
0068CE05C  cbnz     w8, #0x68ce074
0068CE060  adrp     x0, #0x8f28000
0068CE064  ldr      x0, [x0, #0x4b0]
0068CE068  bl       #0x382bd14 ; 
0068CE06C  mov      w8, #1
0068CE070  strb     w8, [x21, #0x73b]
0068CE074  adrp     x8, #0x8f28000
0068CE078  ldr      x8, [x8, #0x4b0]
0068CE07C  ldr      x2, [x8]
0068CE080  ldrb     w8, [x2, #0x53]
0068CE084  tbnz     w8, #5, #0x68ce09c
0068CE088  mov      x0, x19
0068CE08C  str      x20, [x0, #0x30]!
0068CE090  mov      x1, x20
0068CE094  bl       #0x382bcb8 ; 
0068CE098  b        #0x68ce0ac ; 
0068CE09C  ldr      x8, [x2, #0x60]
0068CE0A0  mov      x0, x19
0068CE0A4  mov      x1, x20
0068CE0A8  blr      x8
0068CE0AC  mov      x0, x19
0068CE0B0  mov      x1, xzr
0068CE0B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CE0B8  adrp     x21, #0x959c000
0068CE0BC  ldrb     w8, [x21, #0x73c]
0068CE0C0  mov      w20, w0
0068CE0C4  cbnz     w8, #0x68ce0dc
0068CE0C8  adrp     x0, #0x8f28000
0068CE0CC  ldr      x0, [x0, #0x4c0]
0068CE0D0  bl       #0x382bd14 ; 
0068CE0D4  mov      w8, #1
0068CE0D8  strb     w8, [x21, #0x73c]
0068CE0DC  adrp     x8, #0x8f28000
0068CE0E0  ldr      x8, [x8, #0x4c0]
0068CE0E4  ldr      x2, [x8]
0068CE0E8  ldrb     w8, [x2, #0x53]
0068CE0EC  tbnz     w8, #5, #0x68ce0f8
0068CE0F0  str      w20, [x19, #0x38]
0068CE0F4  b        #0x68ce108 ; 
0068CE0F8  ldr      x8, [x2, #0x60]
0068CE0FC  mov      x0, x19
0068CE100  mov      w1, w20
0068CE104  blr      x8
0068CE108  mov      x0, x19
0068CE10C  mov      x1, xzr
0068CE110  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CE114  adrp     x21, #0x959c000
0068CE118  ldrb     w8, [x21, #0x73d]
0068CE11C  mov      x20, x0
0068CE120  cbnz     w8, #0x68ce138
0068CE124  adrp     x0, #0x8f28000
0068CE128  ldr      x0, [x0, #0x4d0]
0068CE12C  bl       #0x382bd14 ; 
0068CE130  mov      w8, #1
0068CE134  strb     w8, [x21, #0x73d]
0068CE138  adrp     x8, #0x8f28000
0068CE13C  ldr      x8, [x8, #0x4d0]
0068CE140  ldr      x2, [x8]
0068CE144  ldrb     w8, [x2, #0x53]
0068CE148  tbnz     w8, #5, #0x68ce160
0068CE14C  mov      x0, x19
0068CE150  str      x20, [x0, #0x40]!
0068CE154  mov      x1, x20
0068CE158  bl       #0x382bcb8 ; 
0068CE15C  b        #0x68ce170 ; 
0068CE160  ldr      x8, [x2, #0x60]
0068CE164  mov      x0, x19
0068CE168  mov      x1, x20
0068CE16C  blr      x8
0068CE170  mov      x0, x19
0068CE174  mov      x1, xzr
0068CE178  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068CE17C  adrp     x21, #0x959c000
0068CE180  ldrb     w8, [x21, #0x73e]
0068CE184  mov      x20, x0
0068CE188  cbnz     w8, #0x68ce1a0
0068CE18C  adrp     x0, #0x8f28000
0068CE190  ldr      x0, [x0, #0x4e0]
0068CE194  bl       #0x382bd14 ; 
0068CE198  mov      w8, #1
0068CE19C  strb     w8, [x21, #0x73e]
0068CE1A0  adrp     x8, #0x8f28000
0068CE1A4  ldr      x8, [x8, #0x4e0]
0068CE1A8  ldr      x2, [x8]
0068CE1AC  ldrb     w8, [x2, #0x53]
0068CE1B0  tbnz     w8, #5, #0x68ce1c8
0068CE1B4  mov      x0, x19
0068CE1B8  str      x20, [x0, #0x48]!
0068CE1BC  mov      x1, x20
0068CE1C0  bl       #0x382bcb8 ; 
0068CE1C4  b        #0x68ce1d8 ; 
0068CE1C8  ldr      x8, [x2, #0x60]
0068CE1CC  mov      x0, x19
0068CE1D0  mov      x1, x20
0068CE1D4  blr      x8
0068CE1D8  mov      x0, x19
0068CE1DC  mov      x1, xzr
0068CE1E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CE1E4  adrp     x21, #0x959c000
0068CE1E8  ldrb     w8, [x21, #0x73f]
0068CE1EC  mov      w20, w0
0068CE1F0  cbnz     w8, #0x68ce208
0068CE1F4  adrp     x0, #0x8f28000
0068CE1F8  ldr      x0, [x0, #0x4f0]
0068CE1FC  bl       #0x382bd14 ; 
0068CE200  mov      w8, #1
0068CE204  strb     w8, [x21, #0x73f]
0068CE208  adrp     x8, #0x8f28000
0068CE20C  ldr      x8, [x8, #0x4f0]
0068CE210  ldr      x2, [x8]
0068CE214  ldrb     w8, [x2, #0x53]
0068CE218  tbnz     w8, #5, #0x68ce224
0068CE21C  str      w20, [x19, #0x50]
0068CE220  b        #0x68ce234 ; 
0068CE224  ldr      x8, [x2, #0x60]
0068CE228  mov      x0, x19
0068CE22C  mov      w1, w20
0068CE230  blr      x8
0068CE234  ldp      x20, x19, [sp, #0x10]
0068CE238  mov      w0, #1
0068CE23C  ldp      x30, x21, [sp], #0x20
0068CE240  ret      

