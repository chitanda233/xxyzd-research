; LocalModels.Bean.TalentSystem_Talent$$readImpl
; RVA 0x6B0FF38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0FF38  stp      x30, x21, [sp, #-0x20]!
006B0FF3C  stp      x20, x19, [sp, #0x10]
006B0FF40  adrp     x20, #0x959f000
006B0FF44  adrp     x21, #0x8f3e000
006B0FF48  ldrb     w8, [x20, #0x52c]
006B0FF4C  ldr      x21, [x21, #0xbf8]
006B0FF50  mov      x19, x0
006B0FF54  tbnz     w8, #0, #0x6b0ff6c
006B0FF58  adrp     x0, #0x8f3e000
006B0FF5C  ldr      x0, [x0, #0xbf8]
006B0FF60  bl       #0x382bd14 ; 
006B0FF64  mov      w8, #1
006B0FF68  strb     w8, [x20, #0x52c]
006B0FF6C  ldr      x1, [x21]
006B0FF70  ldrb     w8, [x1, #0x53]
006B0FF74  tbnz     w8, #5, #0x6b0ffc4
006B0FF78  mov      x0, x19
006B0FF7C  mov      x1, xzr
006B0FF80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0FF84  adrp     x21, #0x959f000
006B0FF88  ldrb     w8, [x21, #0x99e]
006B0FF8C  mov      w20, w0
006B0FF90  cbnz     w8, #0x6b0ffa8
006B0FF94  adrp     x0, #0x8f3e000
006B0FF98  ldr      x0, [x0, #0xb80]
006B0FF9C  bl       #0x382bd14 ; 
006B0FFA0  mov      w8, #1
006B0FFA4  strb     w8, [x21, #0x99e]
006B0FFA8  adrp     x8, #0x8f3e000
006B0FFAC  ldr      x8, [x8, #0xb80]
006B0FFB0  ldr      x2, [x8]
006B0FFB4  ldrb     w8, [x2, #0x53]
006B0FFB8  tbnz     w8, #5, #0x6b0ffd8
006B0FFBC  str      w20, [x19, #0x20]
006B0FFC0  b        #0x6b0ffe8 ; 
006B0FFC4  ldr      x2, [x1, #0x60]
006B0FFC8  mov      x0, x19
006B0FFCC  ldp      x20, x19, [sp, #0x10]
006B0FFD0  ldp      x30, x21, [sp], #0x20
006B0FFD4  br       x2
006B0FFD8  ldr      x8, [x2, #0x60]
006B0FFDC  mov      x0, x19
006B0FFE0  mov      w1, w20
006B0FFE4  blr      x8
006B0FFE8  mov      x0, x19
006B0FFEC  mov      x1, xzr
006B0FFF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0FFF4  adrp     x21, #0x959f000
006B0FFF8  ldrb     w8, [x21, #0x99f]
006B0FFFC  mov      w20, w0
006B10000  cbnz     w8, #0x6b10018
006B10004  adrp     x0, #0x8f3e000
006B10008  ldr      x0, [x0, #0xb90]
006B1000C  bl       #0x382bd14 ; 
006B10010  mov      w8, #1
006B10014  strb     w8, [x21, #0x99f]
006B10018  adrp     x8, #0x8f3e000
006B1001C  ldr      x8, [x8, #0xb90]
006B10020  ldr      x2, [x8]
006B10024  ldrb     w8, [x2, #0x53]
006B10028  tbnz     w8, #5, #0x6b10034
006B1002C  str      w20, [x19, #0x24]
006B10030  b        #0x6b10044 ; 
006B10034  ldr      x8, [x2, #0x60]
006B10038  mov      x0, x19
006B1003C  mov      w1, w20
006B10040  blr      x8
006B10044  mov      x0, x19
006B10048  mov      x1, xzr
006B1004C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10050  adrp     x21, #0x959f000
006B10054  ldrb     w8, [x21, #0x9a0]
006B10058  mov      w20, w0
006B1005C  cbnz     w8, #0x6b10074
006B10060  adrp     x0, #0x8f3e000
006B10064  ldr      x0, [x0, #0xba0]
006B10068  bl       #0x382bd14 ; 
006B1006C  mov      w8, #1
006B10070  strb     w8, [x21, #0x9a0]
006B10074  adrp     x8, #0x8f3e000
006B10078  ldr      x8, [x8, #0xba0]
006B1007C  ldr      x2, [x8]
006B10080  ldrb     w8, [x2, #0x53]
006B10084  tbnz     w8, #5, #0x6b10090
006B10088  str      w20, [x19, #0x28]
006B1008C  b        #0x6b100a0 ; 
006B10090  ldr      x8, [x2, #0x60]
006B10094  mov      x0, x19
006B10098  mov      w1, w20
006B1009C  blr      x8
006B100A0  mov      x0, x19
006B100A4  mov      x1, xzr
006B100A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B100AC  adrp     x21, #0x959f000
006B100B0  ldrb     w8, [x21, #0x9a1]
006B100B4  mov      w20, w0
006B100B8  cbnz     w8, #0x6b100d0
006B100BC  adrp     x0, #0x8f3e000
006B100C0  ldr      x0, [x0, #0xbb0]
006B100C4  bl       #0x382bd14 ; 
006B100C8  mov      w8, #1
006B100CC  strb     w8, [x21, #0x9a1]
006B100D0  adrp     x8, #0x8f3e000
006B100D4  ldr      x8, [x8, #0xbb0]
006B100D8  ldr      x2, [x8]
006B100DC  ldrb     w8, [x2, #0x53]
006B100E0  tbnz     w8, #5, #0x6b100ec
006B100E4  str      w20, [x19, #0x2c]
006B100E8  b        #0x6b100fc ; 
006B100EC  ldr      x8, [x2, #0x60]
006B100F0  mov      x0, x19
006B100F4  mov      w1, w20
006B100F8  blr      x8
006B100FC  mov      x0, x19
006B10100  mov      x1, xzr
006B10104  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10108  adrp     x21, #0x959f000
006B1010C  ldrb     w8, [x21, #0x9a2]
006B10110  mov      w20, w0
006B10114  cbnz     w8, #0x6b1012c
006B10118  adrp     x0, #0x8f3e000
006B1011C  ldr      x0, [x0, #0xbc0]
006B10120  bl       #0x382bd14 ; 
006B10124  mov      w8, #1
006B10128  strb     w8, [x21, #0x9a2]
006B1012C  adrp     x8, #0x8f3e000
006B10130  ldr      x8, [x8, #0xbc0]
006B10134  ldr      x2, [x8]
006B10138  ldrb     w8, [x2, #0x53]
006B1013C  tbnz     w8, #5, #0x6b10148
006B10140  str      w20, [x19, #0x30]
006B10144  b        #0x6b10158 ; 
006B10148  ldr      x8, [x2, #0x60]
006B1014C  mov      x0, x19
006B10150  mov      w1, w20
006B10154  blr      x8
006B10158  mov      x0, x19
006B1015C  mov      x1, xzr
006B10160  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10164  adrp     x21, #0x959f000
006B10168  ldrb     w8, [x21, #0x9a3]
006B1016C  mov      w20, w0
006B10170  cbnz     w8, #0x6b10188
006B10174  adrp     x0, #0x8f3e000
006B10178  ldr      x0, [x0, #0xbd0]
006B1017C  bl       #0x382bd14 ; 
006B10180  mov      w8, #1
006B10184  strb     w8, [x21, #0x9a3]
006B10188  adrp     x8, #0x8f3e000
006B1018C  ldr      x8, [x8, #0xbd0]
006B10190  ldr      x2, [x8]
006B10194  ldrb     w8, [x2, #0x53]
006B10198  tbnz     w8, #5, #0x6b101a4
006B1019C  str      w20, [x19, #0x34]
006B101A0  b        #0x6b101b4 ; 
006B101A4  ldr      x8, [x2, #0x60]
006B101A8  mov      x0, x19
006B101AC  mov      w1, w20
006B101B0  blr      x8
006B101B4  mov      x0, x19
006B101B8  mov      x1, xzr
006B101BC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B101C0  adrp     x21, #0x959f000
006B101C4  ldrb     w8, [x21, #0x9a4]
006B101C8  mov      x20, x0
006B101CC  cbnz     w8, #0x6b101e4
006B101D0  adrp     x0, #0x8f3e000
006B101D4  ldr      x0, [x0, #0xbe0]
006B101D8  bl       #0x382bd14 ; 
006B101DC  mov      w8, #1
006B101E0  strb     w8, [x21, #0x9a4]
006B101E4  adrp     x8, #0x8f3e000
006B101E8  ldr      x8, [x8, #0xbe0]
006B101EC  ldr      x2, [x8]
006B101F0  ldrb     w8, [x2, #0x53]
006B101F4  tbnz     w8, #5, #0x6b1020c
006B101F8  mov      x0, x19
006B101FC  str      x20, [x0, #0x38]!
006B10200  mov      x1, x20
006B10204  bl       #0x382bcb8 ; 
006B10208  b        #0x6b1021c ; 
006B1020C  ldr      x8, [x2, #0x60]
006B10210  mov      x0, x19
006B10214  mov      x1, x20
006B10218  blr      x8
006B1021C  mov      x0, x19
006B10220  mov      x1, xzr
006B10224  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10228  adrp     x21, #0x959f000
006B1022C  ldrb     w8, [x21, #0x9a5]
006B10230  mov      w20, w0
006B10234  cbnz     w8, #0x6b1024c
006B10238  adrp     x0, #0x8f3e000
006B1023C  ldr      x0, [x0, #0xbf0]
006B10240  bl       #0x382bd14 ; 
006B10244  mov      w8, #1
006B10248  strb     w8, [x21, #0x9a5]
006B1024C  adrp     x8, #0x8f3e000
006B10250  ldr      x8, [x8, #0xbf0]
006B10254  ldr      x2, [x8]
006B10258  ldrb     w8, [x2, #0x53]
006B1025C  tbnz     w8, #5, #0x6b10268
006B10260  str      w20, [x19, #0x40]
006B10264  b        #0x6b10278 ; 
006B10268  ldr      x8, [x2, #0x60]
006B1026C  mov      x0, x19
006B10270  mov      w1, w20
006B10274  blr      x8
006B10278  ldp      x20, x19, [sp, #0x10]
006B1027C  mov      w0, #1
006B10280  ldp      x30, x21, [sp], #0x20
006B10284  ret      

