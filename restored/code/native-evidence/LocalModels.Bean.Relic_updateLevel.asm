; LocalModels.Bean.Relic_updateLevel$$readImpl
; RVA 0x6ADBEB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ADBEB0  stp      x30, x21, [sp, #-0x20]!
006ADBEB4  stp      x20, x19, [sp, #0x10]
006ADBEB8  adrp     x20, #0x959e000
006ADBEBC  adrp     x21, #0x8f3c000
006ADBEC0  ldrb     w8, [x20, #0xc45]
006ADBEC4  ldr      x21, [x21, #0x6c8]
006ADBEC8  mov      x19, x0
006ADBECC  tbnz     w8, #0, #0x6adbee4
006ADBED0  adrp     x0, #0x8f3c000
006ADBED4  ldr      x0, [x0, #0x6c8]
006ADBED8  bl       #0x382bd14 ; 
006ADBEDC  mov      w8, #1
006ADBEE0  strb     w8, [x20, #0xc45]
006ADBEE4  ldr      x1, [x21]
006ADBEE8  ldrb     w8, [x1, #0x53]
006ADBEEC  tbnz     w8, #5, #0x6adbf3c
006ADBEF0  mov      x0, x19
006ADBEF4  mov      x1, xzr
006ADBEF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADBEFC  adrp     x21, #0x959f000
006ADBF00  ldrb     w8, [x21, #0x15d]
006ADBF04  mov      w20, w0
006ADBF08  cbnz     w8, #0x6adbf20
006ADBF0C  adrp     x0, #0x8f3c000
006ADBF10  ldr      x0, [x0, #0x670]
006ADBF14  bl       #0x382bd14 ; 
006ADBF18  mov      w8, #1
006ADBF1C  strb     w8, [x21, #0x15d]
006ADBF20  adrp     x8, #0x8f3c000
006ADBF24  ldr      x8, [x8, #0x670]
006ADBF28  ldr      x2, [x8]
006ADBF2C  ldrb     w8, [x2, #0x53]
006ADBF30  tbnz     w8, #5, #0x6adbf50
006ADBF34  str      w20, [x19, #0x20]
006ADBF38  b        #0x6adbf60 ; 
006ADBF3C  ldr      x2, [x1, #0x60]
006ADBF40  mov      x0, x19
006ADBF44  ldp      x20, x19, [sp, #0x10]
006ADBF48  ldp      x30, x21, [sp], #0x20
006ADBF4C  br       x2
006ADBF50  ldr      x8, [x2, #0x60]
006ADBF54  mov      x0, x19
006ADBF58  mov      w1, w20
006ADBF5C  blr      x8
006ADBF60  mov      x0, x19
006ADBF64  mov      x1, xzr
006ADBF68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADBF6C  adrp     x21, #0x959f000
006ADBF70  ldrb     w8, [x21, #0x15e]
006ADBF74  mov      w20, w0
006ADBF78  cbnz     w8, #0x6adbf90
006ADBF7C  adrp     x0, #0x8f3c000
006ADBF80  ldr      x0, [x0, #0x680]
006ADBF84  bl       #0x382bd14 ; 
006ADBF88  mov      w8, #1
006ADBF8C  strb     w8, [x21, #0x15e]
006ADBF90  adrp     x8, #0x8f3c000
006ADBF94  ldr      x8, [x8, #0x680]
006ADBF98  ldr      x2, [x8]
006ADBF9C  ldrb     w8, [x2, #0x53]
006ADBFA0  tbnz     w8, #5, #0x6adbfac
006ADBFA4  str      w20, [x19, #0x24]
006ADBFA8  b        #0x6adbfbc ; 
006ADBFAC  ldr      x8, [x2, #0x60]
006ADBFB0  mov      x0, x19
006ADBFB4  mov      w1, w20
006ADBFB8  blr      x8
006ADBFBC  mov      x0, x19
006ADBFC0  mov      x1, xzr
006ADBFC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADBFC8  adrp     x21, #0x959f000
006ADBFCC  ldrb     w8, [x21, #0x15f]
006ADBFD0  mov      w20, w0
006ADBFD4  cbnz     w8, #0x6adbfec
006ADBFD8  adrp     x0, #0x8f3c000
006ADBFDC  ldr      x0, [x0, #0x690]
006ADBFE0  bl       #0x382bd14 ; 
006ADBFE4  mov      w8, #1
006ADBFE8  strb     w8, [x21, #0x15f]
006ADBFEC  adrp     x8, #0x8f3c000
006ADBFF0  ldr      x8, [x8, #0x690]
006ADBFF4  ldr      x2, [x8]
006ADBFF8  ldrb     w8, [x2, #0x53]
006ADBFFC  tbnz     w8, #5, #0x6adc008
006ADC000  str      w20, [x19, #0x28]
006ADC004  b        #0x6adc018 ; 
006ADC008  ldr      x8, [x2, #0x60]
006ADC00C  mov      x0, x19
006ADC010  mov      w1, w20
006ADC014  blr      x8
006ADC018  mov      x0, x19
006ADC01C  mov      x1, xzr
006ADC020  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADC024  adrp     x21, #0x959f000
006ADC028  ldrb     w8, [x21, #0x160]
006ADC02C  mov      w20, w0
006ADC030  cbnz     w8, #0x6adc048
006ADC034  adrp     x0, #0x8f3c000
006ADC038  ldr      x0, [x0, #0x6a0]
006ADC03C  bl       #0x382bd14 ; 
006ADC040  mov      w8, #1
006ADC044  strb     w8, [x21, #0x160]
006ADC048  adrp     x8, #0x8f3c000
006ADC04C  ldr      x8, [x8, #0x6a0]
006ADC050  ldr      x2, [x8]
006ADC054  ldrb     w8, [x2, #0x53]
006ADC058  tbnz     w8, #5, #0x6adc064
006ADC05C  str      w20, [x19, #0x2c]
006ADC060  b        #0x6adc074 ; 
006ADC064  ldr      x8, [x2, #0x60]
006ADC068  mov      x0, x19
006ADC06C  mov      w1, w20
006ADC070  blr      x8
006ADC074  mov      x0, x19
006ADC078  mov      x1, xzr
006ADC07C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADC080  adrp     x21, #0x959f000
006ADC084  ldrb     w8, [x21, #0x161]
006ADC088  mov      x20, x0
006ADC08C  cbnz     w8, #0x6adc0a4
006ADC090  adrp     x0, #0x8f3c000
006ADC094  ldr      x0, [x0, #0x6b0]
006ADC098  bl       #0x382bd14 ; 
006ADC09C  mov      w8, #1
006ADC0A0  strb     w8, [x21, #0x161]
006ADC0A4  adrp     x8, #0x8f3c000
006ADC0A8  ldr      x8, [x8, #0x6b0]
006ADC0AC  ldr      x2, [x8]
006ADC0B0  ldrb     w8, [x2, #0x53]
006ADC0B4  tbnz     w8, #5, #0x6adc0cc
006ADC0B8  mov      x0, x19
006ADC0BC  str      x20, [x0, #0x30]!
006ADC0C0  mov      x1, x20
006ADC0C4  bl       #0x382bcb8 ; 
006ADC0C8  b        #0x6adc0dc ; 
006ADC0CC  ldr      x8, [x2, #0x60]
006ADC0D0  mov      x0, x19
006ADC0D4  mov      x1, x20
006ADC0D8  blr      x8
006ADC0DC  mov      x0, x19
006ADC0E0  mov      x1, xzr
006ADC0E4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADC0E8  adrp     x21, #0x959f000
006ADC0EC  ldrb     w8, [x21, #0x162]
006ADC0F0  mov      x20, x0
006ADC0F4  cbnz     w8, #0x6adc10c
006ADC0F8  adrp     x0, #0x8f3c000
006ADC0FC  ldr      x0, [x0, #0x6c0]
006ADC100  bl       #0x382bd14 ; 
006ADC104  mov      w8, #1
006ADC108  strb     w8, [x21, #0x162]
006ADC10C  adrp     x8, #0x8f3c000
006ADC110  ldr      x8, [x8, #0x6c0]
006ADC114  ldr      x2, [x8]
006ADC118  ldrb     w8, [x2, #0x53]
006ADC11C  tbnz     w8, #5, #0x6adc134
006ADC120  str      x20, [x19, #0x38]!
006ADC124  mov      x0, x19
006ADC128  mov      x1, x20
006ADC12C  bl       #0x382bcb8 ; 
006ADC130  b        #0x6adc144 ; 
006ADC134  ldr      x8, [x2, #0x60]
006ADC138  mov      x0, x19
006ADC13C  mov      x1, x20
006ADC140  blr      x8
006ADC144  ldp      x20, x19, [sp, #0x10]
006ADC148  mov      w0, #1
006ADC14C  ldp      x30, x21, [sp], #0x20
006ADC150  ret      

