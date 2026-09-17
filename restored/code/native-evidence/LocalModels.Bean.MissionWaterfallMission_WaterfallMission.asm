; LocalModels.Bean.MissionWaterfallMission_WaterfallMission$$readImpl
; RVA 0x6ABEC3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ABEC3C  stp      x30, x21, [sp, #-0x20]!
006ABEC40  stp      x20, x19, [sp, #0x10]
006ABEC44  adrp     x20, #0x959e000
006ABEC48  adrp     x21, #0x8f3b000
006ABEC4C  ldrb     w8, [x20, #0x947]
006ABEC50  ldr      x21, [x21, #0x160]
006ABEC54  mov      x19, x0
006ABEC58  tbnz     w8, #0, #0x6abec70
006ABEC5C  adrp     x0, #0x8f3b000
006ABEC60  ldr      x0, [x0, #0x160]
006ABEC64  bl       #0x382bd14 ; 
006ABEC68  mov      w8, #1
006ABEC6C  strb     w8, [x20, #0x947]
006ABEC70  ldr      x1, [x21]
006ABEC74  ldrb     w8, [x1, #0x53]
006ABEC78  tbnz     w8, #5, #0x6abecc8
006ABEC7C  mov      x0, x19
006ABEC80  mov      x1, xzr
006ABEC84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABEC88  adrp     x21, #0x959f000
006ABEC8C  ldrb     w8, [x21, #0xf]
006ABEC90  mov      w20, w0
006ABEC94  cbnz     w8, #0x6abecac
006ABEC98  adrp     x0, #0x8f3a000
006ABEC9C  ldr      x0, [x0, #0xff8]
006ABECA0  bl       #0x382bd14 ; 
006ABECA4  mov      w8, #1
006ABECA8  strb     w8, [x21, #0xf]
006ABECAC  adrp     x8, #0x8f3a000
006ABECB0  ldr      x8, [x8, #0xff8]
006ABECB4  ldr      x2, [x8]
006ABECB8  ldrb     w8, [x2, #0x53]
006ABECBC  tbnz     w8, #5, #0x6abecdc
006ABECC0  str      w20, [x19, #0x20]
006ABECC4  b        #0x6abecec ; 
006ABECC8  ldr      x2, [x1, #0x60]
006ABECCC  mov      x0, x19
006ABECD0  ldp      x20, x19, [sp, #0x10]
006ABECD4  ldp      x30, x21, [sp], #0x20
006ABECD8  br       x2
006ABECDC  ldr      x8, [x2, #0x60]
006ABECE0  mov      x0, x19
006ABECE4  mov      w1, w20
006ABECE8  blr      x8
006ABECEC  mov      x0, x19
006ABECF0  mov      x1, xzr
006ABECF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABECF8  adrp     x21, #0x959f000
006ABECFC  ldrb     w8, [x21, #0x10]
006ABED00  mov      w20, w0
006ABED04  cbnz     w8, #0x6abed1c
006ABED08  adrp     x0, #0x8f3b000
006ABED0C  ldr      x0, [x0, #8]
006ABED10  bl       #0x382bd14 ; 
006ABED14  mov      w8, #1
006ABED18  strb     w8, [x21, #0x10]
006ABED1C  adrp     x8, #0x8f3b000
006ABED20  ldr      x8, [x8, #8]
006ABED24  ldr      x2, [x8]
006ABED28  ldrb     w8, [x2, #0x53]
006ABED2C  tbnz     w8, #5, #0x6abed38
006ABED30  str      w20, [x19, #0x24]
006ABED34  b        #0x6abed48 ; 
006ABED38  ldr      x8, [x2, #0x60]
006ABED3C  mov      x0, x19
006ABED40  mov      w1, w20
006ABED44  blr      x8
006ABED48  mov      x0, x19
006ABED4C  mov      x1, xzr
006ABED50  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABED54  adrp     x21, #0x959f000
006ABED58  ldrb     w8, [x21, #0x11]
006ABED5C  mov      x20, x0
006ABED60  cbnz     w8, #0x6abed78
006ABED64  adrp     x0, #0x8f3b000
006ABED68  ldr      x0, [x0, #0x18]
006ABED6C  bl       #0x382bd14 ; 
006ABED70  mov      w8, #1
006ABED74  strb     w8, [x21, #0x11]
006ABED78  adrp     x8, #0x8f3b000
006ABED7C  ldr      x8, [x8, #0x18]
006ABED80  ldr      x2, [x8]
006ABED84  ldrb     w8, [x2, #0x53]
006ABED88  tbnz     w8, #5, #0x6abed94
006ABED8C  str      x20, [x19, #0x28]
006ABED90  b        #0x6abeda4 ; 
006ABED94  ldr      x8, [x2, #0x60]
006ABED98  mov      x0, x19
006ABED9C  mov      x1, x20
006ABEDA0  blr      x8
006ABEDA4  mov      x0, x19
006ABEDA8  mov      x1, xzr
006ABEDAC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABEDB0  adrp     x21, #0x959f000
006ABEDB4  ldrb     w8, [x21, #0x12]
006ABEDB8  mov      x20, x0
006ABEDBC  cbnz     w8, #0x6abedd4
006ABEDC0  adrp     x0, #0x8f3b000
006ABEDC4  ldr      x0, [x0, #0x28]
006ABEDC8  bl       #0x382bd14 ; 
006ABEDCC  mov      w8, #1
006ABEDD0  strb     w8, [x21, #0x12]
006ABEDD4  adrp     x8, #0x8f3b000
006ABEDD8  ldr      x8, [x8, #0x28]
006ABEDDC  ldr      x2, [x8]
006ABEDE0  ldrb     w8, [x2, #0x53]
006ABEDE4  tbnz     w8, #5, #0x6abedf0
006ABEDE8  str      x20, [x19, #0x30]
006ABEDEC  b        #0x6abee00 ; 
006ABEDF0  ldr      x8, [x2, #0x60]
006ABEDF4  mov      x0, x19
006ABEDF8  mov      x1, x20
006ABEDFC  blr      x8
006ABEE00  mov      x0, x19
006ABEE04  mov      x1, xzr
006ABEE08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABEE0C  adrp     x21, #0x959f000
006ABEE10  ldrb     w8, [x21, #0x13]
006ABEE14  mov      w20, w0
006ABEE18  cbnz     w8, #0x6abee30
006ABEE1C  adrp     x0, #0x8f3b000
006ABEE20  ldr      x0, [x0, #0x38]
006ABEE24  bl       #0x382bd14 ; 
006ABEE28  mov      w8, #1
006ABEE2C  strb     w8, [x21, #0x13]
006ABEE30  adrp     x8, #0x8f3b000
006ABEE34  ldr      x8, [x8, #0x38]
006ABEE38  ldr      x2, [x8]
006ABEE3C  ldrb     w8, [x2, #0x53]
006ABEE40  tbnz     w8, #5, #0x6abee4c
006ABEE44  str      w20, [x19, #0x38]
006ABEE48  b        #0x6abee5c ; 
006ABEE4C  ldr      x8, [x2, #0x60]
006ABEE50  mov      x0, x19
006ABEE54  mov      w1, w20
006ABEE58  blr      x8
006ABEE5C  mov      x0, x19
006ABEE60  mov      x1, xzr
006ABEE64  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006ABEE68  adrp     x21, #0x959f000
006ABEE6C  ldrb     w8, [x21, #0x14]
006ABEE70  mov      x20, x0
006ABEE74  cbnz     w8, #0x6abee8c
006ABEE78  adrp     x0, #0x8f3b000
006ABEE7C  ldr      x0, [x0, #0x48]
006ABEE80  bl       #0x382bd14 ; 
006ABEE84  mov      w8, #1
006ABEE88  strb     w8, [x21, #0x14]
006ABEE8C  adrp     x8, #0x8f3b000
006ABEE90  ldr      x8, [x8, #0x48]
006ABEE94  ldr      x2, [x8]
006ABEE98  ldrb     w8, [x2, #0x53]
006ABEE9C  tbnz     w8, #5, #0x6abeeb4
006ABEEA0  mov      x0, x19
006ABEEA4  str      x20, [x0, #0x40]!
006ABEEA8  mov      x1, x20
006ABEEAC  bl       #0x382bcb8 ; 
006ABEEB0  b        #0x6abeec4 ; 
006ABEEB4  ldr      x8, [x2, #0x60]
006ABEEB8  mov      x0, x19
006ABEEBC  mov      x1, x20
006ABEEC0  blr      x8
006ABEEC4  mov      x0, x19
006ABEEC8  mov      x1, xzr
006ABEECC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABEED0  adrp     x21, #0x959f000
006ABEED4  ldrb     w8, [x21, #0x15]
006ABEED8  mov      x20, x0
006ABEEDC  cbnz     w8, #0x6abeef4
006ABEEE0  adrp     x0, #0x8f3b000
006ABEEE4  ldr      x0, [x0, #0x58]
006ABEEE8  bl       #0x382bd14 ; 
006ABEEEC  mov      w8, #1
006ABEEF0  strb     w8, [x21, #0x15]
006ABEEF4  adrp     x8, #0x8f3b000
006ABEEF8  ldr      x8, [x8, #0x58]
006ABEEFC  ldr      x2, [x8]
006ABEF00  ldrb     w8, [x2, #0x53]
006ABEF04  tbnz     w8, #5, #0x6abef1c
006ABEF08  mov      x0, x19
006ABEF0C  str      x20, [x0, #0x48]!
006ABEF10  mov      x1, x20
006ABEF14  bl       #0x382bcb8 ; 
006ABEF18  b        #0x6abef2c ; 
006ABEF1C  ldr      x8, [x2, #0x60]
006ABEF20  mov      x0, x19
006ABEF24  mov      x1, x20
006ABEF28  blr      x8
006ABEF2C  mov      x0, x19
006ABEF30  mov      x1, xzr
006ABEF34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABEF38  adrp     x21, #0x959f000
006ABEF3C  ldrb     w8, [x21, #0x16]
006ABEF40  mov      w20, w0
006ABEF44  cbnz     w8, #0x6abef5c
006ABEF48  adrp     x0, #0x8f3b000
006ABEF4C  ldr      x0, [x0, #0x68]
006ABEF50  bl       #0x382bd14 ; 
006ABEF54  mov      w8, #1
006ABEF58  strb     w8, [x21, #0x16]
006ABEF5C  adrp     x8, #0x8f3b000
006ABEF60  ldr      x8, [x8, #0x68]
006ABEF64  ldr      x2, [x8]
006ABEF68  ldrb     w8, [x2, #0x53]
006ABEF6C  tbnz     w8, #5, #0x6abef78
006ABEF70  str      w20, [x19, #0x50]
006ABEF74  b        #0x6abef88 ; 
006ABEF78  ldr      x8, [x2, #0x60]
006ABEF7C  mov      x0, x19
006ABEF80  mov      w1, w20
006ABEF84  blr      x8
006ABEF88  mov      x0, x19
006ABEF8C  mov      x1, xzr
006ABEF90  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABEF94  adrp     x21, #0x959f000
006ABEF98  ldrb     w8, [x21, #0x17]
006ABEF9C  mov      x20, x0
006ABEFA0  cbnz     w8, #0x6abefb8
006ABEFA4  adrp     x0, #0x8f3b000
006ABEFA8  ldr      x0, [x0, #0x78]
006ABEFAC  bl       #0x382bd14 ; 
006ABEFB0  mov      w8, #1
006ABEFB4  strb     w8, [x21, #0x17]
006ABEFB8  adrp     x8, #0x8f3b000
006ABEFBC  ldr      x8, [x8, #0x78]
006ABEFC0  ldr      x2, [x8]
006ABEFC4  ldrb     w8, [x2, #0x53]
006ABEFC8  tbnz     w8, #5, #0x6abefe0
006ABEFCC  mov      x0, x19
006ABEFD0  str      x20, [x0, #0x58]!
006ABEFD4  mov      x1, x20
006ABEFD8  bl       #0x382bcb8 ; 
006ABEFDC  b        #0x6abeff0 ; 
006ABEFE0  ldr      x8, [x2, #0x60]
006ABEFE4  mov      x0, x19
006ABEFE8  mov      x1, x20
006ABEFEC  blr      x8
006ABEFF0  mov      x0, x19
006ABEFF4  mov      x1, xzr
006ABEFF8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABEFFC  adrp     x21, #0x959f000
006ABF000  ldrb     w8, [x21, #0x18]
006ABF004  mov      x20, x0
006ABF008  cbnz     w8, #0x6abf020
006ABF00C  adrp     x0, #0x8f3b000
006ABF010  ldr      x0, [x0, #0x88]
006ABF014  bl       #0x382bd14 ; 
006ABF018  mov      w8, #1
006ABF01C  strb     w8, [x21, #0x18]
006ABF020  adrp     x8, #0x8f3b000
006ABF024  ldr      x8, [x8, #0x88]
006ABF028  ldr      x2, [x8]
006ABF02C  ldrb     w8, [x2, #0x53]
006ABF030  tbnz     w8, #5, #0x6abf048
006ABF034  mov      x0, x19
006ABF038  str      x20, [x0, #0x60]!
006ABF03C  mov      x1, x20
006ABF040  bl       #0x382bcb8 ; 
006ABF044  b        #0x6abf058 ; 
006ABF048  ldr      x8, [x2, #0x60]
006ABF04C  mov      x0, x19
006ABF050  mov      x1, x20
006ABF054  blr      x8
006ABF058  mov      x0, x19
006ABF05C  mov      x1, xzr
006ABF060  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABF064  adrp     x21, #0x959f000
006ABF068  ldrb     w8, [x21, #0x19]
006ABF06C  mov      x20, x0
006ABF070  cbnz     w8, #0x6abf088
006ABF074  adrp     x0, #0x8f3b000
006ABF078  ldr      x0, [x0, #0x98]
006ABF07C  bl       #0x382bd14 ; 
006ABF080  mov      w8, #1
006ABF084  strb     w8, [x21, #0x19]
006ABF088  adrp     x8, #0x8f3b000
006ABF08C  ldr      x8, [x8, #0x98]
006ABF090  ldr      x2, [x8]
006ABF094  ldrb     w8, [x2, #0x53]
006ABF098  tbnz     w8, #5, #0x6abf0b0
006ABF09C  mov      x0, x19
006ABF0A0  str      x20, [x0, #0x68]!
006ABF0A4  mov      x1, x20
006ABF0A8  bl       #0x382bcb8 ; 
006ABF0AC  b        #0x6abf0c0 ; 
006ABF0B0  ldr      x8, [x2, #0x60]
006ABF0B4  mov      x0, x19
006ABF0B8  mov      x1, x20
006ABF0BC  blr      x8
006ABF0C0  mov      x0, x19
006ABF0C4  mov      x1, xzr
006ABF0C8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABF0CC  adrp     x21, #0x959f000
006ABF0D0  ldrb     w8, [x21, #0x1a]
006ABF0D4  mov      x20, x0
006ABF0D8  cbnz     w8, #0x6abf0f0
006ABF0DC  adrp     x0, #0x8f3b000
006ABF0E0  ldr      x0, [x0, #0xa8]
006ABF0E4  bl       #0x382bd14 ; 
006ABF0E8  mov      w8, #1
006ABF0EC  strb     w8, [x21, #0x1a]
006ABF0F0  adrp     x8, #0x8f3b000
006ABF0F4  ldr      x8, [x8, #0xa8]
006ABF0F8  ldr      x2, [x8]
006ABF0FC  ldrb     w8, [x2, #0x53]
006ABF100  tbnz     w8, #5, #0x6abf118
006ABF104  mov      x0, x19
006ABF108  str      x20, [x0, #0x70]!
006ABF10C  mov      x1, x20
006ABF110  bl       #0x382bcb8 ; 
006ABF114  b        #0x6abf128 ; 
006ABF118  ldr      x8, [x2, #0x60]
006ABF11C  mov      x0, x19
006ABF120  mov      x1, x20
006ABF124  blr      x8
006ABF128  mov      x0, x19
006ABF12C  mov      x1, xzr
006ABF130  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABF134  adrp     x21, #0x959f000
006ABF138  ldrb     w8, [x21, #0x1b]
006ABF13C  mov      w20, w0
006ABF140  cbnz     w8, #0x6abf158
006ABF144  adrp     x0, #0x8f3b000
006ABF148  ldr      x0, [x0, #0xb8]
006ABF14C  bl       #0x382bd14 ; 
006ABF150  mov      w8, #1
006ABF154  strb     w8, [x21, #0x1b]
006ABF158  adrp     x8, #0x8f3b000
006ABF15C  ldr      x8, [x8, #0xb8]
006ABF160  ldr      x2, [x8]
006ABF164  ldrb     w8, [x2, #0x53]
006ABF168  tbnz     w8, #5, #0x6abf174
006ABF16C  str      w20, [x19, #0x78]
006ABF170  b        #0x6abf184 ; 
006ABF174  ldr      x8, [x2, #0x60]
006ABF178  mov      x0, x19
006ABF17C  mov      w1, w20
006ABF180  blr      x8
006ABF184  mov      x0, x19
006ABF188  mov      x1, xzr
006ABF18C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABF190  adrp     x21, #0x959f000
006ABF194  ldrb     w8, [x21, #0x1c]
006ABF198  mov      w20, w0
006ABF19C  cbnz     w8, #0x6abf1b4
006ABF1A0  adrp     x0, #0x8f3b000
006ABF1A4  ldr      x0, [x0, #0xc8]
006ABF1A8  bl       #0x382bd14 ; 
006ABF1AC  mov      w8, #1
006ABF1B0  strb     w8, [x21, #0x1c]
006ABF1B4  adrp     x8, #0x8f3b000
006ABF1B8  ldr      x8, [x8, #0xc8]
006ABF1BC  ldr      x2, [x8]
006ABF1C0  ldrb     w8, [x2, #0x53]
006ABF1C4  tbnz     w8, #5, #0x6abf1d0
006ABF1C8  str      w20, [x19, #0x7c]
006ABF1CC  b        #0x6abf1e0 ; 
006ABF1D0  ldr      x8, [x2, #0x60]
006ABF1D4  mov      x0, x19
006ABF1D8  mov      w1, w20
006ABF1DC  blr      x8
006ABF1E0  mov      x0, x19
006ABF1E4  mov      x1, xzr
006ABF1E8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABF1EC  adrp     x21, #0x959f000
006ABF1F0  ldrb     w8, [x21, #0x1d]
006ABF1F4  mov      x20, x0
006ABF1F8  cbnz     w8, #0x6abf210
006ABF1FC  adrp     x0, #0x8f3b000
006ABF200  ldr      x0, [x0, #0xd8]
006ABF204  bl       #0x382bd14 ; 
006ABF208  mov      w8, #1
006ABF20C  strb     w8, [x21, #0x1d]
006ABF210  adrp     x8, #0x8f3b000
006ABF214  ldr      x8, [x8, #0xd8]
006ABF218  ldr      x2, [x8]
006ABF21C  ldrb     w8, [x2, #0x53]
006ABF220  tbnz     w8, #5, #0x6abf22c
006ABF224  str      x20, [x19, #0x80]
006ABF228  b        #0x6abf23c ; 
006ABF22C  ldr      x8, [x2, #0x60]
006ABF230  mov      x0, x19
006ABF234  mov      x1, x20
006ABF238  blr      x8
006ABF23C  mov      x0, x19
006ABF240  mov      x1, xzr
006ABF244  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABF248  adrp     x21, #0x959f000
006ABF24C  ldrb     w8, [x21, #0x1e]
006ABF250  mov      x20, x0
006ABF254  cbnz     w8, #0x6abf26c
006ABF258  adrp     x0, #0x8f3b000
006ABF25C  ldr      x0, [x0, #0xe8]
006ABF260  bl       #0x382bd14 ; 
006ABF264  mov      w8, #1
006ABF268  strb     w8, [x21, #0x1e]
006ABF26C  adrp     x8, #0x8f3b000
006ABF270  ldr      x8, [x8, #0xe8]
006ABF274  ldr      x2, [x8]
006ABF278  ldrb     w8, [x2, #0x53]
006ABF27C  tbnz     w8, #5, #0x6abf288
006ABF280  str      x20, [x19, #0x88]
006ABF284  b        #0x6abf298 ; 
006ABF288  ldr      x8, [x2, #0x60]
006ABF28C  mov      x0, x19
006ABF290  mov      x1, x20
006ABF294  blr      x8
006ABF298  mov      x0, x19
006ABF29C  mov      x1, xzr
006ABF2A0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABF2A4  adrp     x21, #0x959f000
006ABF2A8  ldrb     w8, [x21, #0x1f]
006ABF2AC  mov      x20, x0
006ABF2B0  cbnz     w8, #0x6abf2c8
006ABF2B4  adrp     x0, #0x8f3b000
006ABF2B8  ldr      x0, [x0, #0xf8]
006ABF2BC  bl       #0x382bd14 ; 
006ABF2C0  mov      w8, #1
006ABF2C4  strb     w8, [x21, #0x1f]
006ABF2C8  adrp     x8, #0x8f3b000
006ABF2CC  ldr      x8, [x8, #0xf8]
006ABF2D0  ldr      x2, [x8]
006ABF2D4  ldrb     w8, [x2, #0x53]
006ABF2D8  tbnz     w8, #5, #0x6abf2e4
006ABF2DC  str      x20, [x19, #0x90]
006ABF2E0  b        #0x6abf2f4 ; 
006ABF2E4  ldr      x8, [x2, #0x60]
006ABF2E8  mov      x0, x19
006ABF2EC  mov      x1, x20
006ABF2F0  blr      x8
006ABF2F4  mov      x0, x19
006ABF2F8  mov      x1, xzr
006ABF2FC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ABF300  adrp     x21, #0x959f000
006ABF304  ldrb     w8, [x21, #0x20]
006ABF308  mov      x20, x0
006ABF30C  cbnz     w8, #0x6abf324
006ABF310  adrp     x0, #0x8f3b000
006ABF314  ldr      x0, [x0, #0x108]
006ABF318  bl       #0x382bd14 ; 
006ABF31C  mov      w8, #1
006ABF320  strb     w8, [x21, #0x20]
006ABF324  adrp     x8, #0x8f3b000
006ABF328  ldr      x8, [x8, #0x108]
006ABF32C  ldr      x2, [x8]
006ABF330  ldrb     w8, [x2, #0x53]
006ABF334  tbnz     w8, #5, #0x6abf340
006ABF338  str      x20, [x19, #0x98]
006ABF33C  b        #0x6abf350 ; 
006ABF340  ldr      x8, [x2, #0x60]
006ABF344  mov      x0, x19
006ABF348  mov      x1, x20
006ABF34C  blr      x8
006ABF350  mov      x0, x19
006ABF354  mov      x1, xzr
006ABF358  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABF35C  adrp     x21, #0x959f000
006ABF360  ldrb     w8, [x21, #0x21]
006ABF364  mov      w20, w0
006ABF368  cbnz     w8, #0x6abf380
006ABF36C  adrp     x0, #0x8f3b000
006ABF370  ldr      x0, [x0, #0x118]
006ABF374  bl       #0x382bd14 ; 
006ABF378  mov      w8, #1
006ABF37C  strb     w8, [x21, #0x21]
006ABF380  adrp     x8, #0x8f3b000
006ABF384  ldr      x8, [x8, #0x118]
006ABF388  ldr      x2, [x8]
006ABF38C  ldrb     w8, [x2, #0x53]
006ABF390  tbnz     w8, #5, #0x6abf39c
006ABF394  str      w20, [x19, #0xa0]
006ABF398  b        #0x6abf3ac ; 
006ABF39C  ldr      x8, [x2, #0x60]
006ABF3A0  mov      x0, x19
006ABF3A4  mov      w1, w20
006ABF3A8  blr      x8
006ABF3AC  mov      x0, x19
006ABF3B0  mov      x1, xzr
006ABF3B4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ABF3B8  adrp     x21, #0x959f000
006ABF3BC  ldrb     w8, [x21, #0x22]
006ABF3C0  mov      x20, x0
006ABF3C4  cbnz     w8, #0x6abf3dc
006ABF3C8  adrp     x0, #0x8f3b000
006ABF3CC  ldr      x0, [x0, #0x128]
006ABF3D0  bl       #0x382bd14 ; 
006ABF3D4  mov      w8, #1
006ABF3D8  strb     w8, [x21, #0x22]
006ABF3DC  adrp     x8, #0x8f3b000
006ABF3E0  ldr      x8, [x8, #0x128]
006ABF3E4  ldr      x2, [x8]
006ABF3E8  ldrb     w8, [x2, #0x53]
006ABF3EC  tbnz     w8, #5, #0x6abf404
006ABF3F0  mov      x0, x19
006ABF3F4  str      x20, [x0, #0xa8]!
006ABF3F8  mov      x1, x20
006ABF3FC  bl       #0x382bcb8 ; 
006ABF400  b        #0x6abf414 ; 
006ABF404  ldr      x8, [x2, #0x60]
006ABF408  mov      x0, x19
006ABF40C  mov      x1, x20
006ABF410  blr      x8
006ABF414  mov      x0, x19
006ABF418  mov      x1, xzr
006ABF41C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ABF420  adrp     x21, #0x959f000
006ABF424  ldrb     w8, [x21, #0x23]
006ABF428  mov      w20, w0
006ABF42C  cbnz     w8, #0x6abf444
006ABF430  adrp     x0, #0x8f3b000
006ABF434  ldr      x0, [x0, #0x138]
006ABF438  bl       #0x382bd14 ; 
006ABF43C  mov      w8, #1
006ABF440  strb     w8, [x21, #0x23]
006ABF444  adrp     x8, #0x8f3b000
006ABF448  ldr      x8, [x8, #0x138]
006ABF44C  ldr      x2, [x8]
006ABF450  ldrb     w8, [x2, #0x53]
006ABF454  tbnz     w8, #5, #0x6abf460
006ABF458  str      w20, [x19, #0xb0]
006ABF45C  b        #0x6abf470 ; 
006ABF460  ldr      x8, [x2, #0x60]
006ABF464  mov      x0, x19
006ABF468  mov      w1, w20
006ABF46C  blr      x8
006ABF470  mov      x0, x19
006ABF474  mov      x1, xzr
006ABF478  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ABF47C  adrp     x21, #0x959f000
006ABF480  ldrb     w8, [x21, #0x24]
006ABF484  mov      x20, x0
006ABF488  cbnz     w8, #0x6abf4a0
006ABF48C  adrp     x0, #0x8f3b000
006ABF490  ldr      x0, [x0, #0x148]
006ABF494  bl       #0x382bd14 ; 
006ABF498  mov      w8, #1
006ABF49C  strb     w8, [x21, #0x24]
006ABF4A0  adrp     x8, #0x8f3b000
006ABF4A4  ldr      x8, [x8, #0x148]
006ABF4A8  ldr      x2, [x8]
006ABF4AC  ldrb     w8, [x2, #0x53]
006ABF4B0  tbnz     w8, #5, #0x6abf4c8
006ABF4B4  mov      x0, x19
006ABF4B8  str      x20, [x0, #0xb8]!
006ABF4BC  mov      x1, x20
006ABF4C0  bl       #0x382bcb8 ; 
006ABF4C4  b        #0x6abf4d8 ; 
006ABF4C8  ldr      x8, [x2, #0x60]
006ABF4CC  mov      x0, x19
006ABF4D0  mov      x1, x20
006ABF4D4  blr      x8
006ABF4D8  mov      x0, x19
006ABF4DC  mov      x1, xzr
006ABF4E0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ABF4E4  adrp     x21, #0x959f000
006ABF4E8  ldrb     w8, [x21, #0x25]
006ABF4EC  mov      x20, x0
006ABF4F0  cbnz     w8, #0x6abf508
006ABF4F4  adrp     x0, #0x8f3b000
006ABF4F8  ldr      x0, [x0, #0x158]
006ABF4FC  bl       #0x382bd14 ; 
006ABF500  mov      w8, #1
006ABF504  strb     w8, [x21, #0x25]
006ABF508  adrp     x8, #0x8f3b000
006ABF50C  ldr      x8, [x8, #0x158]
006ABF510  ldr      x2, [x8]
006ABF514  ldrb     w8, [x2, #0x53]
006ABF518  tbnz     w8, #5, #0x6abf530
006ABF51C  str      x20, [x19, #0xc0]!
006ABF520  mov      x0, x19
006ABF524  mov      x1, x20
006ABF528  bl       #0x382bcb8 ; 
006ABF52C  b        #0x6abf540 ; 
006ABF530  ldr      x8, [x2, #0x60]
006ABF534  mov      x0, x19
006ABF538  mov      x1, x20
006ABF53C  blr      x8
006ABF540  ldp      x20, x19, [sp, #0x10]
006ABF544  mov      w0, #1
006ABF548  ldp      x30, x21, [sp], #0x20
006ABF54C  ret      

