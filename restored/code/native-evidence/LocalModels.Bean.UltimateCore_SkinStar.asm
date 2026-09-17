; LocalModels.Bean.UltimateCore_SkinStar$$readImpl
; RVA 0x6B1BE78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B1BE78  stp      x30, x21, [sp, #-0x20]!
006B1BE7C  stp      x20, x19, [sp, #0x10]
006B1BE80  adrp     x20, #0x959f000
006B1BE84  adrp     x21, #0x8f3f000
006B1BE88  ldrb     w8, [x20, #0x66b]
006B1BE8C  ldr      x21, [x21, #0x500]
006B1BE90  mov      x19, x0
006B1BE94  tbnz     w8, #0, #0x6b1beac
006B1BE98  adrp     x0, #0x8f3f000
006B1BE9C  ldr      x0, [x0, #0x500]
006B1BEA0  bl       #0x382bd14 ; 
006B1BEA4  mov      w8, #1
006B1BEA8  strb     w8, [x20, #0x66b]
006B1BEAC  ldr      x1, [x21]
006B1BEB0  ldrb     w8, [x1, #0x53]
006B1BEB4  tbnz     w8, #5, #0x6b1bf04
006B1BEB8  mov      x0, x19
006B1BEBC  mov      x1, xzr
006B1BEC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1BEC4  adrp     x21, #0x959f000
006B1BEC8  ldrb     w8, [x21, #0xa21]
006B1BECC  mov      w20, w0
006B1BED0  cbnz     w8, #0x6b1bee8
006B1BED4  adrp     x0, #0x8f3f000
006B1BED8  ldr      x0, [x0, #0x498]
006B1BEDC  bl       #0x382bd14 ; 
006B1BEE0  mov      w8, #1
006B1BEE4  strb     w8, [x21, #0xa21]
006B1BEE8  adrp     x8, #0x8f3f000
006B1BEEC  ldr      x8, [x8, #0x498]
006B1BEF0  ldr      x2, [x8]
006B1BEF4  ldrb     w8, [x2, #0x53]
006B1BEF8  tbnz     w8, #5, #0x6b1bf18
006B1BEFC  str      w20, [x19, #0x20]
006B1BF00  b        #0x6b1bf28 ; 
006B1BF04  ldr      x2, [x1, #0x60]
006B1BF08  mov      x0, x19
006B1BF0C  ldp      x20, x19, [sp, #0x10]
006B1BF10  ldp      x30, x21, [sp], #0x20
006B1BF14  br       x2
006B1BF18  ldr      x8, [x2, #0x60]
006B1BF1C  mov      x0, x19
006B1BF20  mov      w1, w20
006B1BF24  blr      x8
006B1BF28  mov      x0, x19
006B1BF2C  mov      x1, xzr
006B1BF30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1BF34  adrp     x21, #0x959f000
006B1BF38  ldrb     w8, [x21, #0xa22]
006B1BF3C  mov      w20, w0
006B1BF40  cbnz     w8, #0x6b1bf58
006B1BF44  adrp     x0, #0x8f3f000
006B1BF48  ldr      x0, [x0, #0x4a8]
006B1BF4C  bl       #0x382bd14 ; 
006B1BF50  mov      w8, #1
006B1BF54  strb     w8, [x21, #0xa22]
006B1BF58  adrp     x8, #0x8f3f000
006B1BF5C  ldr      x8, [x8, #0x4a8]
006B1BF60  ldr      x2, [x8]
006B1BF64  ldrb     w8, [x2, #0x53]
006B1BF68  tbnz     w8, #5, #0x6b1bf74
006B1BF6C  str      w20, [x19, #0x24]
006B1BF70  b        #0x6b1bf84 ; 
006B1BF74  ldr      x8, [x2, #0x60]
006B1BF78  mov      x0, x19
006B1BF7C  mov      w1, w20
006B1BF80  blr      x8
006B1BF84  mov      x0, x19
006B1BF88  mov      x1, xzr
006B1BF8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1BF90  adrp     x21, #0x959f000
006B1BF94  ldrb     w8, [x21, #0xa23]
006B1BF98  mov      w20, w0
006B1BF9C  cbnz     w8, #0x6b1bfb4
006B1BFA0  adrp     x0, #0x8f3f000
006B1BFA4  ldr      x0, [x0, #0x4b8]
006B1BFA8  bl       #0x382bd14 ; 
006B1BFAC  mov      w8, #1
006B1BFB0  strb     w8, [x21, #0xa23]
006B1BFB4  adrp     x8, #0x8f3f000
006B1BFB8  ldr      x8, [x8, #0x4b8]
006B1BFBC  ldr      x2, [x8]
006B1BFC0  ldrb     w8, [x2, #0x53]
006B1BFC4  tbnz     w8, #5, #0x6b1bfd0
006B1BFC8  str      w20, [x19, #0x28]
006B1BFCC  b        #0x6b1bfe0 ; 
006B1BFD0  ldr      x8, [x2, #0x60]
006B1BFD4  mov      x0, x19
006B1BFD8  mov      w1, w20
006B1BFDC  blr      x8
006B1BFE0  mov      x0, x19
006B1BFE4  mov      x1, xzr
006B1BFE8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B1BFEC  adrp     x21, #0x959f000
006B1BFF0  ldrb     w8, [x21, #0xa24]
006B1BFF4  mov      x20, x0
006B1BFF8  cbnz     w8, #0x6b1c010
006B1BFFC  adrp     x0, #0x8f3f000
006B1C000  ldr      x0, [x0, #0x4c8]
006B1C004  bl       #0x382bd14 ; 
006B1C008  mov      w8, #1
006B1C00C  strb     w8, [x21, #0xa24]
006B1C010  adrp     x8, #0x8f3f000
006B1C014  ldr      x8, [x8, #0x4c8]
006B1C018  ldr      x2, [x8]
006B1C01C  ldrb     w8, [x2, #0x53]
006B1C020  tbnz     w8, #5, #0x6b1c038
006B1C024  mov      x0, x19
006B1C028  str      x20, [x0, #0x30]!
006B1C02C  mov      x1, x20
006B1C030  bl       #0x382bcb8 ; 
006B1C034  b        #0x6b1c048 ; 
006B1C038  ldr      x8, [x2, #0x60]
006B1C03C  mov      x0, x19
006B1C040  mov      x1, x20
006B1C044  blr      x8
006B1C048  mov      x0, x19
006B1C04C  mov      x1, xzr
006B1C050  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1C054  adrp     x21, #0x959f000
006B1C058  ldrb     w8, [x21, #0xa25]
006B1C05C  mov      w20, w0
006B1C060  cbnz     w8, #0x6b1c078
006B1C064  adrp     x0, #0x8f3f000
006B1C068  ldr      x0, [x0, #0x4d8]
006B1C06C  bl       #0x382bd14 ; 
006B1C070  mov      w8, #1
006B1C074  strb     w8, [x21, #0xa25]
006B1C078  adrp     x8, #0x8f3f000
006B1C07C  ldr      x8, [x8, #0x4d8]
006B1C080  ldr      x2, [x8]
006B1C084  ldrb     w8, [x2, #0x53]
006B1C088  tbnz     w8, #5, #0x6b1c094
006B1C08C  str      w20, [x19, #0x38]
006B1C090  b        #0x6b1c0a4 ; 
006B1C094  ldr      x8, [x2, #0x60]
006B1C098  mov      x0, x19
006B1C09C  mov      w1, w20
006B1C0A0  blr      x8
006B1C0A4  mov      x0, x19
006B1C0A8  mov      x1, xzr
006B1C0AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1C0B0  adrp     x21, #0x959f000
006B1C0B4  ldrb     w8, [x21, #0xa26]
006B1C0B8  mov      x20, x0
006B1C0BC  cbnz     w8, #0x6b1c0d4
006B1C0C0  adrp     x0, #0x8f3f000
006B1C0C4  ldr      x0, [x0, #0x4e0]
006B1C0C8  bl       #0x382bd14 ; 
006B1C0CC  mov      w8, #1
006B1C0D0  strb     w8, [x21, #0xa26]
006B1C0D4  adrp     x8, #0x8f3f000
006B1C0D8  ldr      x8, [x8, #0x4e0]
006B1C0DC  ldr      x2, [x8]
006B1C0E0  ldrb     w8, [x2, #0x53]
006B1C0E4  tbnz     w8, #5, #0x6b1c0fc
006B1C0E8  mov      x0, x19
006B1C0EC  str      x20, [x0, #0x40]!
006B1C0F0  mov      x1, x20
006B1C0F4  bl       #0x382bcb8 ; 
006B1C0F8  b        #0x6b1c10c ; 
006B1C0FC  ldr      x8, [x2, #0x60]
006B1C100  mov      x0, x19
006B1C104  mov      x1, x20
006B1C108  blr      x8
006B1C10C  mov      x0, x19
006B1C110  mov      x1, xzr
006B1C114  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B1C118  adrp     x21, #0x959f000
006B1C11C  ldrb     w8, [x21, #0xa27]
006B1C120  mov      x20, x0
006B1C124  cbnz     w8, #0x6b1c13c
006B1C128  adrp     x0, #0x8f3f000
006B1C12C  ldr      x0, [x0, #0x4e8]
006B1C130  bl       #0x382bd14 ; 
006B1C134  mov      w8, #1
006B1C138  strb     w8, [x21, #0xa27]
006B1C13C  adrp     x8, #0x8f3f000
006B1C140  ldr      x8, [x8, #0x4e8]
006B1C144  ldr      x2, [x8]
006B1C148  ldrb     w8, [x2, #0x53]
006B1C14C  tbnz     w8, #5, #0x6b1c164
006B1C150  mov      x0, x19
006B1C154  str      x20, [x0, #0x48]!
006B1C158  mov      x1, x20
006B1C15C  bl       #0x382bcb8 ; 
006B1C160  b        #0x6b1c174 ; 
006B1C164  ldr      x8, [x2, #0x60]
006B1C168  mov      x0, x19
006B1C16C  mov      x1, x20
006B1C170  blr      x8
006B1C174  mov      x0, x19
006B1C178  mov      x1, xzr
006B1C17C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B1C180  adrp     x21, #0x959f000
006B1C184  ldrb     w8, [x21, #0xa28]
006B1C188  mov      x20, x0
006B1C18C  cbnz     w8, #0x6b1c1a4
006B1C190  adrp     x0, #0x8f3f000
006B1C194  ldr      x0, [x0, #0x4f8]
006B1C198  bl       #0x382bd14 ; 
006B1C19C  mov      w8, #1
006B1C1A0  strb     w8, [x21, #0xa28]
006B1C1A4  adrp     x8, #0x8f3f000
006B1C1A8  ldr      x8, [x8, #0x4f8]
006B1C1AC  ldr      x2, [x8]
006B1C1B0  ldrb     w8, [x2, #0x53]
006B1C1B4  tbnz     w8, #5, #0x6b1c1cc
006B1C1B8  str      x20, [x19, #0x50]!
006B1C1BC  mov      x0, x19
006B1C1C0  mov      x1, x20
006B1C1C4  bl       #0x382bcb8 ; 
006B1C1C8  b        #0x6b1c1dc ; 
006B1C1CC  ldr      x8, [x2, #0x60]
006B1C1D0  mov      x0, x19
006B1C1D4  mov      x1, x20
006B1C1D8  blr      x8
006B1C1DC  ldp      x20, x19, [sp, #0x10]
006B1C1E0  mov      w0, #1
006B1C1E4  ldp      x30, x21, [sp], #0x20
006B1C1E8  ret      

