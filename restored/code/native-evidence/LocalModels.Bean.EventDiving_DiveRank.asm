; LocalModels.Bean.EventDiving_DiveRank$$readImpl
; RVA 0x6A6EFD4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6EFD4  stp      x30, x21, [sp, #-0x20]!
006A6EFD8  stp      x20, x19, [sp, #0x10]
006A6EFDC  adrp     x20, #0x959d000
006A6EFE0  adrp     x21, #0x8f37000
006A6EFE4  ldrb     w8, [x20, #0xd74]
006A6EFE8  ldr      x21, [x21, #0x488]
006A6EFEC  mov      x19, x0
006A6EFF0  tbnz     w8, #0, #0x6a6f008
006A6EFF4  adrp     x0, #0x8f37000
006A6EFF8  ldr      x0, [x0, #0x488]
006A6EFFC  bl       #0x382bd14 ; 
006A6F000  mov      w8, #1
006A6F004  strb     w8, [x20, #0xd74]
006A6F008  ldr      x1, [x21]
006A6F00C  ldrb     w8, [x1, #0x53]
006A6F010  tbnz     w8, #5, #0x6a6f060
006A6F014  mov      x0, x19
006A6F018  mov      x1, xzr
006A6F01C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6F020  adrp     x21, #0x959e000
006A6F024  ldrb     w8, [x21, #0x441]
006A6F028  mov      w20, w0
006A6F02C  cbnz     w8, #0x6a6f044
006A6F030  adrp     x0, #0x8f37000
006A6F034  ldr      x0, [x0, #0x430]
006A6F038  bl       #0x382bd14 ; 
006A6F03C  mov      w8, #1
006A6F040  strb     w8, [x21, #0x441]
006A6F044  adrp     x8, #0x8f37000
006A6F048  ldr      x8, [x8, #0x430]
006A6F04C  ldr      x2, [x8]
006A6F050  ldrb     w8, [x2, #0x53]
006A6F054  tbnz     w8, #5, #0x6a6f074
006A6F058  str      w20, [x19, #0x20]
006A6F05C  b        #0x6a6f084 ; 
006A6F060  ldr      x2, [x1, #0x60]
006A6F064  mov      x0, x19
006A6F068  ldp      x20, x19, [sp, #0x10]
006A6F06C  ldp      x30, x21, [sp], #0x20
006A6F070  br       x2
006A6F074  ldr      x8, [x2, #0x60]
006A6F078  mov      x0, x19
006A6F07C  mov      w1, w20
006A6F080  blr      x8
006A6F084  mov      x0, x19
006A6F088  mov      x1, xzr
006A6F08C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6F090  adrp     x21, #0x959e000
006A6F094  ldrb     w8, [x21, #0x442]
006A6F098  mov      w20, w0
006A6F09C  cbnz     w8, #0x6a6f0b4
006A6F0A0  adrp     x0, #0x8f37000
006A6F0A4  ldr      x0, [x0, #0x440]
006A6F0A8  bl       #0x382bd14 ; 
006A6F0AC  mov      w8, #1
006A6F0B0  strb     w8, [x21, #0x442]
006A6F0B4  adrp     x8, #0x8f37000
006A6F0B8  ldr      x8, [x8, #0x440]
006A6F0BC  ldr      x2, [x8]
006A6F0C0  ldrb     w8, [x2, #0x53]
006A6F0C4  tbnz     w8, #5, #0x6a6f0d0
006A6F0C8  str      w20, [x19, #0x24]
006A6F0CC  b        #0x6a6f0e0 ; 
006A6F0D0  ldr      x8, [x2, #0x60]
006A6F0D4  mov      x0, x19
006A6F0D8  mov      w1, w20
006A6F0DC  blr      x8
006A6F0E0  mov      x0, x19
006A6F0E4  mov      x1, xzr
006A6F0E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6F0EC  adrp     x21, #0x959e000
006A6F0F0  ldrb     w8, [x21, #0x443]
006A6F0F4  mov      w20, w0
006A6F0F8  cbnz     w8, #0x6a6f110
006A6F0FC  adrp     x0, #0x8f37000
006A6F100  ldr      x0, [x0, #0x450]
006A6F104  bl       #0x382bd14 ; 
006A6F108  mov      w8, #1
006A6F10C  strb     w8, [x21, #0x443]
006A6F110  adrp     x8, #0x8f37000
006A6F114  ldr      x8, [x8, #0x450]
006A6F118  ldr      x2, [x8]
006A6F11C  ldrb     w8, [x2, #0x53]
006A6F120  tbnz     w8, #5, #0x6a6f12c
006A6F124  str      w20, [x19, #0x28]
006A6F128  b        #0x6a6f13c ; 
006A6F12C  ldr      x8, [x2, #0x60]
006A6F130  mov      x0, x19
006A6F134  mov      w1, w20
006A6F138  blr      x8
006A6F13C  mov      x0, x19
006A6F140  mov      x1, xzr
006A6F144  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A6F148  adrp     x21, #0x959e000
006A6F14C  ldrb     w8, [x21, #0x444]
006A6F150  mov      x20, x0
006A6F154  cbnz     w8, #0x6a6f16c
006A6F158  adrp     x0, #0x8f37000
006A6F15C  ldr      x0, [x0, #0x460]
006A6F160  bl       #0x382bd14 ; 
006A6F164  mov      w8, #1
006A6F168  strb     w8, [x21, #0x444]
006A6F16C  adrp     x8, #0x8f37000
006A6F170  ldr      x8, [x8, #0x460]
006A6F174  ldr      x2, [x8]
006A6F178  ldrb     w8, [x2, #0x53]
006A6F17C  tbnz     w8, #5, #0x6a6f194
006A6F180  mov      x0, x19
006A6F184  str      x20, [x0, #0x30]!
006A6F188  mov      x1, x20
006A6F18C  bl       #0x382bcb8 ; 
006A6F190  b        #0x6a6f1a4 ; 
006A6F194  ldr      x8, [x2, #0x60]
006A6F198  mov      x0, x19
006A6F19C  mov      x1, x20
006A6F1A0  blr      x8
006A6F1A4  mov      x0, x19
006A6F1A8  mov      x1, xzr
006A6F1AC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A6F1B0  adrp     x21, #0x959e000
006A6F1B4  ldrb     w8, [x21, #0x445]
006A6F1B8  mov      x20, x0
006A6F1BC  cbnz     w8, #0x6a6f1d4
006A6F1C0  adrp     x0, #0x8f37000
006A6F1C4  ldr      x0, [x0, #0x470]
006A6F1C8  bl       #0x382bd14 ; 
006A6F1CC  mov      w8, #1
006A6F1D0  strb     w8, [x21, #0x445]
006A6F1D4  adrp     x8, #0x8f37000
006A6F1D8  ldr      x8, [x8, #0x470]
006A6F1DC  ldr      x2, [x8]
006A6F1E0  ldrb     w8, [x2, #0x53]
006A6F1E4  tbnz     w8, #5, #0x6a6f1fc
006A6F1E8  mov      x0, x19
006A6F1EC  str      x20, [x0, #0x38]!
006A6F1F0  mov      x1, x20
006A6F1F4  bl       #0x382bcb8 ; 
006A6F1F8  b        #0x6a6f20c ; 
006A6F1FC  ldr      x8, [x2, #0x60]
006A6F200  mov      x0, x19
006A6F204  mov      x1, x20
006A6F208  blr      x8
006A6F20C  mov      x0, x19
006A6F210  mov      x1, xzr
006A6F214  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A6F218  adrp     x21, #0x959e000
006A6F21C  ldrb     w8, [x21, #0x446]
006A6F220  mov      x20, x0
006A6F224  cbnz     w8, #0x6a6f23c
006A6F228  adrp     x0, #0x8f37000
006A6F22C  ldr      x0, [x0, #0x480]
006A6F230  bl       #0x382bd14 ; 
006A6F234  mov      w8, #1
006A6F238  strb     w8, [x21, #0x446]
006A6F23C  adrp     x8, #0x8f37000
006A6F240  ldr      x8, [x8, #0x480]
006A6F244  ldr      x2, [x8]
006A6F248  ldrb     w8, [x2, #0x53]
006A6F24C  tbnz     w8, #5, #0x6a6f264
006A6F250  str      x20, [x19, #0x40]!
006A6F254  mov      x0, x19
006A6F258  mov      x1, x20
006A6F25C  bl       #0x382bcb8 ; 
006A6F260  b        #0x6a6f274 ; 
006A6F264  ldr      x8, [x2, #0x60]
006A6F268  mov      x0, x19
006A6F26C  mov      x1, x20
006A6F270  blr      x8
006A6F274  ldp      x20, x19, [sp, #0x10]
006A6F278  mov      w0, #1
006A6F27C  ldp      x30, x21, [sp], #0x20
006A6F280  ret      

