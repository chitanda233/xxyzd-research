; LocalModels.Bean.Shop_MissionGift$$readImpl
; RVA 0x6AECF90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AECF90  stp      x30, x21, [sp, #-0x20]!
006AECF94  stp      x20, x19, [sp, #0x10]
006AECF98  adrp     x20, #0x959e000
006AECF9C  adrp     x21, #0x8f3d000
006AECFA0  ldrb     w8, [x20, #0xe04]
006AECFA4  ldr      x21, [x21, #0x368]
006AECFA8  mov      x19, x0
006AECFAC  tbnz     w8, #0, #0x6aecfc4
006AECFB0  adrp     x0, #0x8f3d000
006AECFB4  ldr      x0, [x0, #0x368]
006AECFB8  bl       #0x382bd14 ; 
006AECFBC  mov      w8, #1
006AECFC0  strb     w8, [x20, #0xe04]
006AECFC4  ldr      x1, [x21]
006AECFC8  ldrb     w8, [x1, #0x53]
006AECFCC  tbnz     w8, #5, #0x6aed01c
006AECFD0  mov      x0, x19
006AECFD4  mov      x1, xzr
006AECFD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AECFDC  adrp     x21, #0x959f000
006AECFE0  ldrb     w8, [x21, #0x21e]
006AECFE4  mov      w20, w0
006AECFE8  cbnz     w8, #0x6aed000
006AECFEC  adrp     x0, #0x8f3d000
006AECFF0  ldr      x0, [x0, #0x320]
006AECFF4  bl       #0x382bd14 ; 
006AECFF8  mov      w8, #1
006AECFFC  strb     w8, [x21, #0x21e]
006AED000  adrp     x8, #0x8f3d000
006AED004  ldr      x8, [x8, #0x320]
006AED008  ldr      x2, [x8]
006AED00C  ldrb     w8, [x2, #0x53]
006AED010  tbnz     w8, #5, #0x6aed030
006AED014  str      w20, [x19, #0x20]
006AED018  b        #0x6aed040 ; 
006AED01C  ldr      x2, [x1, #0x60]
006AED020  mov      x0, x19
006AED024  ldp      x20, x19, [sp, #0x10]
006AED028  ldp      x30, x21, [sp], #0x20
006AED02C  br       x2
006AED030  ldr      x8, [x2, #0x60]
006AED034  mov      x0, x19
006AED038  mov      w1, w20
006AED03C  blr      x8
006AED040  mov      x0, x19
006AED044  mov      x1, xzr
006AED048  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AED04C  adrp     x21, #0x959f000
006AED050  ldrb     w8, [x21, #0x21f]
006AED054  mov      x20, x0
006AED058  cbnz     w8, #0x6aed070
006AED05C  adrp     x0, #0x8f3d000
006AED060  ldr      x0, [x0, #0x330]
006AED064  bl       #0x382bd14 ; 
006AED068  mov      w8, #1
006AED06C  strb     w8, [x21, #0x21f]
006AED070  adrp     x8, #0x8f3d000
006AED074  ldr      x8, [x8, #0x330]
006AED078  ldr      x2, [x8]
006AED07C  ldrb     w8, [x2, #0x53]
006AED080  tbnz     w8, #5, #0x6aed098
006AED084  mov      x0, x19
006AED088  str      x20, [x0, #0x28]!
006AED08C  mov      x1, x20
006AED090  bl       #0x382bcb8 ; 
006AED094  b        #0x6aed0a8 ; 
006AED098  ldr      x8, [x2, #0x60]
006AED09C  mov      x0, x19
006AED0A0  mov      x1, x20
006AED0A4  blr      x8
006AED0A8  mov      x0, x19
006AED0AC  mov      x1, xzr
006AED0B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AED0B4  adrp     x21, #0x959f000
006AED0B8  ldrb     w8, [x21, #0x220]
006AED0BC  mov      w20, w0
006AED0C0  cbnz     w8, #0x6aed0d8
006AED0C4  adrp     x0, #0x8f3d000
006AED0C8  ldr      x0, [x0, #0x340]
006AED0CC  bl       #0x382bd14 ; 
006AED0D0  mov      w8, #1
006AED0D4  strb     w8, [x21, #0x220]
006AED0D8  adrp     x8, #0x8f3d000
006AED0DC  ldr      x8, [x8, #0x340]
006AED0E0  ldr      x2, [x8]
006AED0E4  ldrb     w8, [x2, #0x53]
006AED0E8  tbnz     w8, #5, #0x6aed0f4
006AED0EC  str      w20, [x19, #0x30]
006AED0F0  b        #0x6aed104 ; 
006AED0F4  ldr      x8, [x2, #0x60]
006AED0F8  mov      x0, x19
006AED0FC  mov      w1, w20
006AED100  blr      x8
006AED104  mov      x0, x19
006AED108  mov      x1, xzr
006AED10C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AED110  adrp     x21, #0x959f000
006AED114  ldrb     w8, [x21, #0x221]
006AED118  mov      w20, w0
006AED11C  cbnz     w8, #0x6aed134
006AED120  adrp     x0, #0x8f3d000
006AED124  ldr      x0, [x0, #0x350]
006AED128  bl       #0x382bd14 ; 
006AED12C  mov      w8, #1
006AED130  strb     w8, [x21, #0x221]
006AED134  adrp     x8, #0x8f3d000
006AED138  ldr      x8, [x8, #0x350]
006AED13C  ldr      x2, [x8]
006AED140  ldrb     w8, [x2, #0x53]
006AED144  tbnz     w8, #5, #0x6aed150
006AED148  str      w20, [x19, #0x34]
006AED14C  b        #0x6aed160 ; 
006AED150  ldr      x8, [x2, #0x60]
006AED154  mov      x0, x19
006AED158  mov      w1, w20
006AED15C  blr      x8
006AED160  mov      x0, x19
006AED164  mov      x1, xzr
006AED168  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AED16C  adrp     x21, #0x959f000
006AED170  ldrb     w8, [x21, #0x222]
006AED174  mov      x20, x0
006AED178  cbnz     w8, #0x6aed190
006AED17C  adrp     x0, #0x8f3d000
006AED180  ldr      x0, [x0, #0x360]
006AED184  bl       #0x382bd14 ; 
006AED188  mov      w8, #1
006AED18C  strb     w8, [x21, #0x222]
006AED190  adrp     x8, #0x8f3d000
006AED194  ldr      x8, [x8, #0x360]
006AED198  ldr      x2, [x8]
006AED19C  ldrb     w8, [x2, #0x53]
006AED1A0  tbnz     w8, #5, #0x6aed1b8
006AED1A4  str      x20, [x19, #0x38]!
006AED1A8  mov      x0, x19
006AED1AC  mov      x1, x20
006AED1B0  bl       #0x382bcb8 ; 
006AED1B4  b        #0x6aed1c8 ; 
006AED1B8  ldr      x8, [x2, #0x60]
006AED1BC  mov      x0, x19
006AED1C0  mov      x1, x20
006AED1C4  blr      x8
006AED1C8  ldp      x20, x19, [sp, #0x10]
006AED1CC  mov      w0, #1
006AED1D0  ldp      x30, x21, [sp], #0x20
006AED1D4  ret      

