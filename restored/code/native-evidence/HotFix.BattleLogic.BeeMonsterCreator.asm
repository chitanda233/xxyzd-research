; HotFix.BattleLogic.BeeMonsterCreator$$get_FlushId
; RVA 0x65B9D28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B9D28  stp      x30, x21, [sp, #-0x20]!
0065B9D2C  stp      x20, x19, [sp, #0x10]
0065B9D30  adrp     x20, #0x9599000
0065B9D34  adrp     x21, #0x8f09000
0065B9D38  ldrb     w8, [x20, #0x474]
0065B9D3C  ldr      x21, [x21, #0xec0]
0065B9D40  mov      x19, x0
0065B9D44  tbnz     w8, #0, #0x65b9d5c
0065B9D48  adrp     x0, #0x8f09000
0065B9D4C  ldr      x0, [x0, #0xec0]
0065B9D50  bl       #0x382bd14 ; 
0065B9D54  mov      w8, #1
0065B9D58  strb     w8, [x20, #0x474]
0065B9D5C  ldr      x1, [x21]
0065B9D60  ldrb     w8, [x1, #0x53]
0065B9D64  tbnz     w8, #5, #0x65b9d78
0065B9D68  ldr      w0, [x19, #0x28]
0065B9D6C  ldp      x20, x19, [sp, #0x10]
0065B9D70  ldp      x30, x21, [sp], #0x20
0065B9D74  ret      
0065B9D78  ldr      x2, [x1, #0x60]
0065B9D7C  mov      x0, x19
0065B9D80  ldp      x20, x19, [sp, #0x10]
0065B9D84  ldp      x30, x21, [sp], #0x20
0065B9D88  br       x2

; HotFix.BattleLogic.BeeMonsterCreator$$set_FlushId
; RVA 0x65B9D8C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B9D8C  str      x30, [sp, #-0x30]!
0065B9D90  stp      x22, x21, [sp, #0x10]
0065B9D94  stp      x20, x19, [sp, #0x20]
0065B9D98  adrp     x21, #0x9599000
0065B9D9C  adrp     x22, #0x8f09000
0065B9DA0  ldrb     w8, [x21, #0x475]
0065B9DA4  ldr      x22, [x22, #0xec8]
0065B9DA8  mov      w19, w1
0065B9DAC  mov      x20, x0
0065B9DB0  tbnz     w8, #0, #0x65b9dc8
0065B9DB4  adrp     x0, #0x8f09000
0065B9DB8  ldr      x0, [x0, #0xec8]
0065B9DBC  bl       #0x382bd14 ; 
0065B9DC0  mov      w8, #1
0065B9DC4  strb     w8, [x21, #0x475]
0065B9DC8  ldr      x2, [x22]
0065B9DCC  ldrb     w8, [x2, #0x53]
0065B9DD0  tbnz     w8, #5, #0x65b9de8
0065B9DD4  str      w19, [x20, #0x28]
0065B9DD8  ldp      x20, x19, [sp, #0x20]
0065B9DDC  ldp      x22, x21, [sp, #0x10]
0065B9DE0  ldr      x30, [sp], #0x30
0065B9DE4  ret      
0065B9DE8  ldr      x3, [x2, #0x60]
0065B9DEC  mov      x0, x20
0065B9DF0  mov      w1, w19
0065B9DF4  ldp      x20, x19, [sp, #0x20]
0065B9DF8  ldp      x22, x21, [sp, #0x10]
0065B9DFC  ldr      x30, [sp], #0x30
0065B9E00  br       x3

; HotFix.BattleLogic.BeeMonsterCreator$$SetData
; RVA 0x65B9E04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B9E04  sub      sp, sp, #0x70
0065B9E08  stp      x30, x27, [sp, #0x20]
0065B9E0C  stp      x26, x25, [sp, #0x30]
0065B9E10  stp      x24, x23, [sp, #0x40]
0065B9E14  stp      x22, x21, [sp, #0x50]
0065B9E18  stp      x20, x19, [sp, #0x60]
0065B9E1C  mrs      x24, tpidr_el0
0065B9E20  ldr      x8, [x24, #0x28]
0065B9E24  adrp     x22, #0x9599000
0065B9E28  adrp     x23, #0x8f09000
0065B9E2C  mov      w21, w2
0065B9E30  str      x8, [sp, #0x18]
0065B9E34  ldrb     w8, [x22, #0x476]
0065B9E38  ldr      x23, [x23, #0xed0]
0065B9E3C  mov      w20, w1
0065B9E40  mov      x19, x0
0065B9E44  tbnz     w8, #0, #0x65b9e98
0065B9E48  adrp     x0, #0x8f09000
0065B9E4C  ldr      x0, [x0, #0xed0]
0065B9E50  bl       #0x382bd14 ; 
0065B9E54  adrp     x0, #0x8f09000
0065B9E58  ldr      x0, [x0, #0xed8]
0065B9E5C  bl       #0x382bd14 ; 
0065B9E60  adrp     x0, #0x8f09000
0065B9E64  ldr      x0, [x0, #0xee0]
0065B9E68  bl       #0x382bd14 ; 
0065B9E6C  adrp     x0, #0x8f09000
0065B9E70  ldr      x0, [x0, #0xee8]
0065B9E74  bl       #0x382bd14 ; 
0065B9E78  adrp     x0, #0x8f09000
0065B9E7C  ldr      x0, [x0, #0xef0]
0065B9E80  bl       #0x382bd14 ; 
0065B9E84  adrp     x0, #0x8f09000
0065B9E88  ldr      x0, [x0, #0xef8]
0065B9E8C  bl       #0x382bd14 ; 
0065B9E90  mov      w8, #1
0065B9E94  strb     w8, [x22, #0x476]
0065B9E98  ldr      x3, [x23]
0065B9E9C  ldrb     w8, [x3, #0x53]
0065B9EA0  tbnz     w8, #5, #0x65b9f38
0065B9EA4  mov      x22, x19
0065B9EA8  adrp     x25, #0x8f09000
0065B9EAC  adrp     x23, #0x8f09000
0065B9EB0  ldr      x0, [x22, #0x88]!
0065B9EB4  ldr      x25, [x25, #0xee8]
0065B9EB8  ldr      x23, [x23, #0xee0]
0065B9EBC  cbz      x0, #0x65b9ed0
0065B9EC0  adrp     x8, #0x8f09000
0065B9EC4  ldr      x8, [x8, #0xed8]
0065B9EC8  ldr      x1, [x8]
0065B9ECC  bl       #0x5e5fbc4 ; System.Collections.Generic.Dictionary<int, object>$$Clear
0065B9ED0  ldr      x0, [x25]
0065B9ED4  bl       #0x382bfa0 ; 
0065B9ED8  ldr      x1, [x23]
0065B9EDC  mov      x23, x0
0065B9EE0  bl       #0x5e5ec40 ; System.Collections.Generic.Dictionary<int, object>$$.ctor
0065B9EE4  mov      x0, x22
0065B9EE8  mov      x1, x23
0065B9EEC  str      x23, [x19, #0x88]
0065B9EF0  bl       #0x382bcb8 ; 
0065B9EF4  str      w21, [x19, #0x64]
0065B9EF8  mov      w21, #1
0065B9EFC  strb     w21, [x19, #0x39]
0065B9F00  adrp     x23, #0x9591000
0065B9F04  ldrb     w8, [x23, #0xa4b]
0065B9F08  cbnz     w8, #0x65b9f1c
0065B9F0C  adrp     x0, #0x8ee5000
0065B9F10  ldr      x0, [x0, #0xb28]
0065B9F14  bl       #0x382bd14 ; 
0065B9F18  strb     w21, [x23, #0xa4b]
0065B9F1C  adrp     x25, #0x8ee5000
0065B9F20  ldr      x25, [x25, #0xb28]
0065B9F24  ldr      x1, [x25]
0065B9F28  ldrb     w8, [x1, #0x53]
0065B9F2C  tbnz     w8, #5, #0x65b9f50
0065B9F30  ldr      x0, [x19, #0x20]
0065B9F34  b        #0x65b9f5c ; 
0065B9F38  ldr      x8, [x3, #0x60]
0065B9F3C  mov      x0, x19
0065B9F40  mov      w1, w20
0065B9F44  mov      w2, w21
0065B9F48  blr      x8
0065B9F4C  b        #0x65ba398 ; 
0065B9F50  ldr      x8, [x1, #0x60]
0065B9F54  mov      x0, x19
0065B9F58  blr      x8
0065B9F5C  cbz      x0, #0x65ba3c4
0065B9F60  ldr      x8, [x0, #0x128]
0065B9F64  mov      w22, #1
0065B9F68  strb     w22, [x19, #0x38]
0065B9F6C  adrp     x26, #0x8f09000
0065B9F70  str      x8, [x19, #0x30]
0065B9F74  ldr      x26, [x26, #0xef8]
0065B9F78  ldr      x0, [x26]
0065B9F7C  bl       #0x382bfa0 ; 
0065B9F80  adrp     x27, #0x8f09000
0065B9F84  ldr      x27, [x27, #0xef0]
0065B9F88  mov      x21, x0
0065B9F8C  ldr      x1, [x27]
0065B9F90  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0065B9F94  mov      x0, x19
0065B9F98  str      x21, [x0, #0x78]!
0065B9F9C  mov      x1, x21
0065B9FA0  bl       #0x382bcb8 ; 
0065B9FA4  ldr      x0, [x26]
0065B9FA8  bl       #0x382bfa0 ; 
0065B9FAC  ldr      x1, [x27]
0065B9FB0  mov      x21, x0
0065B9FB4  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0065B9FB8  mov      x0, x19
0065B9FBC  str      x21, [x0, #0x80]!
0065B9FC0  mov      x1, x21
0065B9FC4  bl       #0x382bcb8 ; 
0065B9FC8  ldrb     w8, [x23, #0xa4b]
0065B9FCC  cbnz     w8, #0x65b9fe0
0065B9FD0  adrp     x0, #0x8ee5000
0065B9FD4  ldr      x0, [x0, #0xb28]
0065B9FD8  bl       #0x382bd14 ; 
0065B9FDC  strb     w22, [x23, #0xa4b]
0065B9FE0  ldr      x1, [x25]
0065B9FE4  ldrb     w8, [x1, #0x53]
0065B9FE8  tbnz     w8, #5, #0x65b9ff4
0065B9FEC  ldr      x21, [x19, #0x20]
0065B9FF0  b        #0x65ba004 ; 
0065B9FF4  ldr      x8, [x1, #0x60]
0065B9FF8  mov      x0, x19
0065B9FFC  blr      x8
0065BA000  mov      x21, x0
0065BA004  cbz      x21, #0x65ba3c4
0065BA008  adrp     x22, #0x9598000
0065BA00C  ldrb     w8, [x22, #0xfcc]
0065BA010  cbnz     w8, #0x65ba028
0065BA014  adrp     x0, #0x8f06000
0065BA018  ldr      x0, [x0, #0x470]
0065BA01C  bl       #0x382bd14 ; 
0065BA020  mov      w8, #1
0065BA024  strb     w8, [x22, #0xfcc]
0065BA028  adrp     x8, #0x8f06000
0065BA02C  ldr      x8, [x8, #0x470]
0065BA030  ldr      x1, [x8]
0065BA034  ldrb     w8, [x1, #0x53]
0065BA038  tbnz     w8, #5, #0x65ba044
0065BA03C  ldr      x0, [x21, #0x200]
0065BA040  b        #0x65ba050 ; 
0065BA044  ldr      x8, [x1, #0x60]
0065BA048  mov      x0, x21
0065BA04C  blr      x8
0065BA050  cbz      x0, #0x65ba3c4
0065BA054  mov      w1, w20
0065BA058  mov      x2, xzr
0065BA05C  bl       #0x64d3b8c ; LocalModels.LocalModelManager$$GetMission_BeeMonsterFlushConfig
0065BA060  cbz      x0, #0x65ba3c4
0065BA064  adrp     x21, #0x9599000
0065BA068  ldrb     w8, [x21, #0x4e5]
0065BA06C  mov      x20, x0
0065BA070  cbnz     w8, #0x65ba088
0065BA074  adrp     x0, #0x8f09000
0065BA078  ldr      x0, [x0, #0xf00]
0065BA07C  bl       #0x382bd14 ; 
0065BA080  mov      w8, #1
0065BA084  strb     w8, [x21, #0x4e5]
0065BA088  adrp     x8, #0x8f09000
0065BA08C  ldr      x8, [x8, #0xf00]
0065BA090  ldr      x1, [x8]
0065BA094  ldrb     w8, [x1, #0x53]
0065BA098  tbnz     w8, #5, #0x65ba0a4
0065BA09C  ldr      w0, [x20, #0x38]
0065BA0A0  b        #0x65ba0b0 ; 
0065BA0A4  ldr      x8, [x1, #0x60]
0065BA0A8  mov      x0, x20
0065BA0AC  blr      x8
0065BA0B0  str      w0, [x19, #0x3c]
0065BA0B4  adrp     x26, #0x9599000
0065BA0B8  ldrb     w8, [x26, #0x4e6]
0065BA0BC  cbnz     w8, #0x65ba0d4
0065BA0C0  adrp     x0, #0x8f09000
0065BA0C4  ldr      x0, [x0, #0xf08]
0065BA0C8  bl       #0x382bd14 ; 
0065BA0CC  mov      w8, #1
0065BA0D0  strb     w8, [x26, #0x4e6]
0065BA0D4  adrp     x27, #0x8f09000
0065BA0D8  ldr      x27, [x27, #0xf08]
0065BA0DC  ldr      x1, [x27]
0065BA0E0  ldrb     w8, [x1, #0x53]
0065BA0E4  tbnz     w8, #5, #0x65ba0f0
0065BA0E8  ldr      x0, [x20, #0x40]
0065BA0EC  b        #0x65ba0fc ; 
0065BA0F0  ldr      x8, [x1, #0x60]
0065BA0F4  mov      x0, x20
0065BA0F8  blr      x8
0065BA0FC  cbz      x0, #0x65ba3c4
0065BA100  ldr      w8, [x0, #0x18]
0065BA104  cbz      w8, #0x65ba3c8
0065BA108  ldrb     w8, [x26, #0x4e6]
0065BA10C  ldr      x21, [x0, #0x20]
0065BA110  cbnz     w8, #0x65ba128
0065BA114  adrp     x0, #0x8f09000
0065BA118  ldr      x0, [x0, #0xf08]
0065BA11C  bl       #0x382bd14 ; 
0065BA120  mov      w8, #1
0065BA124  strb     w8, [x26, #0x4e6]
0065BA128  ldr      x1, [x27]
0065BA12C  ldrb     w8, [x1, #0x53]
0065BA130  tbnz     w8, #5, #0x65ba13c
0065BA134  ldr      x0, [x20, #0x40]
0065BA138  b        #0x65ba148 ; 
0065BA13C  ldr      x8, [x1, #0x60]
0065BA140  mov      x0, x20
0065BA144  blr      x8
0065BA148  cbz      x0, #0x65ba3c4
0065BA14C  ldr      w8, [x0, #0x18]
0065BA150  cmp      w8, #1
0065BA154  b.ls     #0x65ba3c8
0065BA158  ldrb     w8, [x26, #0x4e6]
0065BA15C  ldr      x22, [x0, #0x28]
0065BA160  cbnz     w8, #0x65ba178
0065BA164  adrp     x0, #0x8f09000
0065BA168  ldr      x0, [x0, #0xf08]
0065BA16C  bl       #0x382bd14 ; 
0065BA170  mov      w8, #1
0065BA174  strb     w8, [x26, #0x4e6]
0065BA178  ldr      x1, [x27]
0065BA17C  ldrb     w8, [x1, #0x53]
0065BA180  tbnz     w8, #5, #0x65ba18c
0065BA184  ldr      x0, [x20, #0x40]
0065BA188  b        #0x65ba198 ; 
0065BA18C  ldr      x8, [x1, #0x60]
0065BA190  mov      x0, x20
0065BA194  blr      x8
0065BA198  cbz      x0, #0x65ba3c4
0065BA19C  ldr      w8, [x0, #0x18]
0065BA1A0  cmp      w8, #2
0065BA1A4  b.ls     #0x65ba3c8
0065BA1A8  ldr      x3, [x0, #0x30]
0065BA1AC  mov      x0, sp
0065BA1B0  mov      x1, x21
0065BA1B4  mov      x2, x22
0065BA1B8  mov      x4, xzr
0065BA1BC  stp      xzr, xzr, [sp]
0065BA1C0  str      xzr, [sp, #0x10]
0065BA1C4  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065BA1C8  ldr      x8, [sp, #0x10]
0065BA1CC  ldr      q0, [sp]
0065BA1D0  adrp     x21, #0x9599000
0065BA1D4  str      x8, [x19, #0x50]
0065BA1D8  str      q0, [x19, #0x40]
0065BA1DC  ldrb     w8, [x21, #0x4e7]
0065BA1E0  cbnz     w8, #0x65ba1f8
0065BA1E4  adrp     x0, #0x8f09000
0065BA1E8  ldr      x0, [x0, #0xf10]
0065BA1EC  bl       #0x382bd14 ; 
0065BA1F0  mov      w8, #1
0065BA1F4  strb     w8, [x21, #0x4e7]
0065BA1F8  adrp     x8, #0x8f09000
0065BA1FC  ldr      x8, [x8, #0xf10]
0065BA200  ldr      x1, [x8]
0065BA204  ldrb     w8, [x1, #0x53]
0065BA208  tbnz     w8, #5, #0x65ba214
0065BA20C  ldr      x0, [x20, #0x48]
0065BA210  b        #0x65ba220 ; 
0065BA214  ldr      x8, [x1, #0x60]
0065BA218  mov      x0, x20
0065BA21C  blr      x8
0065BA220  str      x0, [x19, #0x58]
0065BA224  adrp     x21, #0x9599000
0065BA228  ldrb     w8, [x21, #0x4e8]
0065BA22C  cbnz     w8, #0x65ba244
0065BA230  adrp     x0, #0x8f09000
0065BA234  ldr      x0, [x0, #0xf18]
0065BA238  bl       #0x382bd14 ; 
0065BA23C  mov      w8, #1
0065BA240  strb     w8, [x21, #0x4e8]
0065BA244  adrp     x8, #0x8f09000
0065BA248  ldr      x8, [x8, #0xf18]
0065BA24C  ldr      x1, [x8]
0065BA250  ldrb     w8, [x1, #0x53]
0065BA254  tbnz     w8, #5, #0x65ba260
0065BA258  ldr      w0, [x20, #0x50]
0065BA25C  b        #0x65ba26c ; 
0065BA260  ldr      x8, [x1, #0x60]
0065BA264  mov      x0, x20
0065BA268  blr      x8
0065BA26C  str      w0, [x19, #0x60]
0065BA270  ldrb     w8, [x23, #0xa4b]
0065BA274  cbnz     w8, #0x65ba28c
0065BA278  adrp     x0, #0x8ee5000
0065BA27C  ldr      x0, [x0, #0xb28]
0065BA280  bl       #0x382bd14 ; 
0065BA284  mov      w8, #1
0065BA288  strb     w8, [x23, #0xa4b]
0065BA28C  ldr      x1, [x25]
0065BA290  ldrb     w8, [x1, #0x53]
0065BA294  tbnz     w8, #5, #0x65ba2a0
0065BA298  ldr      x0, [x19, #0x20]
0065BA29C  b        #0x65ba2ac ; 
0065BA2A0  ldr      x8, [x1, #0x60]
0065BA2A4  mov      x0, x19
0065BA2A8  blr      x8
0065BA2AC  cbz      x0, #0x65ba3c4
0065BA2B0  ldrb     w8, [x0, #0x13]
0065BA2B4  cbz      w8, #0x65ba300
0065BA2B8  ldrb     w8, [x23, #0xa4b]
0065BA2BC  cbnz     w8, #0x65ba2d4
0065BA2C0  adrp     x0, #0x8ee5000
0065BA2C4  ldr      x0, [x0, #0xb28]
0065BA2C8  bl       #0x382bd14 ; 
0065BA2CC  mov      w8, #1
0065BA2D0  strb     w8, [x23, #0xa4b]
0065BA2D4  ldr      x1, [x25]
0065BA2D8  ldrb     w8, [x1, #0x53]
0065BA2DC  tbnz     w8, #5, #0x65ba2e8
0065BA2E0  ldr      x0, [x19, #0x20]
0065BA2E4  b        #0x65ba2f4 ; 
0065BA2E8  ldr      x8, [x1, #0x60]
0065BA2EC  mov      x0, x19
0065BA2F0  blr      x8
0065BA2F4  cbz      x0, #0x65ba3c4
0065BA2F8  ldr      w8, [x0, #0x20]
0065BA2FC  str      w8, [x19, #0x60]
0065BA300  adrp     x21, #0x9599000
0065BA304  ldrb     w8, [x21, #0x4e9]
0065BA308  cbnz     w8, #0x65ba320
0065BA30C  adrp     x0, #0x8f09000
0065BA310  ldr      x0, [x0, #0xf20]
0065BA314  bl       #0x382bd14 ; 
0065BA318  mov      w8, #1
0065BA31C  strb     w8, [x21, #0x4e9]
0065BA320  adrp     x8, #0x8f09000
0065BA324  ldr      x8, [x8, #0xf20]
0065BA328  ldr      x1, [x8]
0065BA32C  ldrb     w8, [x1, #0x53]
0065BA330  tbnz     w8, #5, #0x65ba33c
0065BA334  ldr      x0, [x20, #0x30]
0065BA338  b        #0x65ba348 ; 
0065BA33C  ldr      x8, [x1, #0x60]
0065BA340  mov      x0, x20
0065BA344  blr      x8
0065BA348  str      x0, [x19, #0x68]
0065BA34C  adrp     x21, #0x9599000
0065BA350  ldrb     w8, [x21, #0x4ea]
0065BA354  cbnz     w8, #0x65ba36c
0065BA358  adrp     x0, #0x8f09000
0065BA35C  ldr      x0, [x0, #0xf28]
0065BA360  bl       #0x382bd14 ; 
0065BA364  mov      w8, #1
0065BA368  strb     w8, [x21, #0x4ea]
0065BA36C  adrp     x8, #0x8f09000
0065BA370  ldr      x8, [x8, #0xf28]
0065BA374  ldr      x1, [x8]
0065BA378  ldrb     w8, [x1, #0x53]
0065BA37C  tbnz     w8, #5, #0x65ba388
0065BA380  ldr      x0, [x20, #0x28]
0065BA384  b        #0x65ba394 ; 
0065BA388  ldr      x8, [x1, #0x60]
0065BA38C  mov      x0, x20
0065BA390  blr      x8
0065BA394  str      x0, [x19, #0x70]
0065BA398  ldr      x8, [x24, #0x28]
0065BA39C  ldr      x9, [sp, #0x18]
0065BA3A0  cmp      x8, x9
0065BA3A4  b.ne     #0x65ba3cc
0065BA3A8  ldp      x20, x19, [sp, #0x60]
0065BA3AC  ldp      x22, x21, [sp, #0x50]
0065BA3B0  ldp      x24, x23, [sp, #0x40]
0065BA3B4  ldp      x26, x25, [sp, #0x30]
0065BA3B8  ldp      x30, x27, [sp, #0x20]
0065BA3BC  add      sp, sp, #0x70
0065BA3C0  ret      
0065BA3C4  bl       #0x382bfb8 ; 
0065BA3C8  bl       #0x382bfc0 ; 
0065BA3CC  bl       #0x89edb60 ; 

; HotFix.BattleLogic.BeeMonsterCreator$$Update
; RVA 0x65BA3D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BA3D0  sub      sp, sp, #0xc0
0065BA3D4  stp      x30, x25, [sp, #0x80]
0065BA3D8  stp      x24, x23, [sp, #0x90]
0065BA3DC  stp      x22, x21, [sp, #0xa0]
0065BA3E0  stp      x20, x19, [sp, #0xb0]
0065BA3E4  mrs      x22, tpidr_el0
0065BA3E8  ldr      x8, [x22, #0x28]
0065BA3EC  adrp     x21, #0x9599000
0065BA3F0  adrp     x23, #0x8f09000
0065BA3F4  mov      x20, x1
0065BA3F8  str      x8, [sp, #0x78]
0065BA3FC  ldrb     w8, [x21, #0x477]
0065BA400  ldr      x23, [x23, #0xf30]
0065BA404  mov      x19, x0
0065BA408  tbnz     w8, #0, #0x65ba480
0065BA40C  adrp     x0, #0x8f09000
0065BA410  ldr      x0, [x0, #0xf30]
0065BA414  bl       #0x382bd14 ; 
0065BA418  adrp     x0, #0x8f09000
0065BA41C  ldr      x0, [x0, #0xf38]
0065BA420  bl       #0x382bd14 ; 
0065BA424  adrp     x0, #0x8f09000
0065BA428  ldr      x0, [x0, #0xf40]
0065BA42C  bl       #0x382bd14 ; 
0065BA430  adrp     x0, #0x8f09000
0065BA434  ldr      x0, [x0, #0xf48]
0065BA438  bl       #0x382bd14 ; 
0065BA43C  adrp     x0, #0x8f09000
0065BA440  ldr      x0, [x0, #0xf50]
0065BA444  bl       #0x382bd14 ; 
0065BA448  adrp     x0, #0x8f09000
0065BA44C  ldr      x0, [x0, #0xf58]
0065BA450  bl       #0x382bd14 ; 
0065BA454  adrp     x0, #0x8f09000
0065BA458  ldr      x0, [x0, #0xf60]
0065BA45C  bl       #0x382bd14 ; 
0065BA460  adrp     x0, #0x8f09000
0065BA464  ldr      x0, [x0, #0xf68]
0065BA468  bl       #0x382bd14 ; 
0065BA46C  adrp     x0, #0x8f09000
0065BA470  ldr      x0, [x0, #0xf70]
0065BA474  bl       #0x382bd14 ; 
0065BA478  mov      w8, #1
0065BA47C  strb     w8, [x21, #0x477]
0065BA480  ldr      x2, [x23]
0065BA484  ldrb     w8, [x2, #0x53]
0065BA488  tbnz     w8, #5, #0x65ba4e0
0065BA48C  stp      xzr, xzr, [sp, #0x20]
0065BA490  str      xzr, [sp, #0x30]
0065BA494  ldrb     w8, [x19, #0x39]
0065BA498  cbz      w8, #0x65baa10
0065BA49C  adrp     x23, #0x8ee5000
0065BA4A0  ldrb     w8, [x19, #0x38]
0065BA4A4  ldr      x23, [x23, #0xb28]
0065BA4A8  adrp     x24, #0x9591000
0065BA4AC  cbz      w8, #0x65ba51c
0065BA4B0  ldrb     w8, [x24, #0xa4b]
0065BA4B4  cbnz     w8, #0x65ba4cc
0065BA4B8  adrp     x0, #0x8ee5000
0065BA4BC  ldr      x0, [x0, #0xb28]
0065BA4C0  bl       #0x382bd14 ; 
0065BA4C4  mov      w8, #1
0065BA4C8  strb     w8, [x24, #0xa4b]
0065BA4CC  ldr      x1, [x23]
0065BA4D0  ldrb     w8, [x1, #0x53]
0065BA4D4  tbnz     w8, #5, #0x65ba4f4
0065BA4D8  ldr      x0, [x19, #0x20]
0065BA4DC  b        #0x65ba500 ; 
0065BA4E0  ldr      x8, [x2, #0x60]
0065BA4E4  mov      x0, x19
0065BA4E8  mov      x1, x20
0065BA4EC  blr      x8
0065BA4F0  b        #0x65baa10 ; 
0065BA4F4  ldr      x8, [x1, #0x60]
0065BA4F8  mov      x0, x19
0065BA4FC  blr      x8
0065BA500  cbz      x0, #0x65baa4c
0065BA504  ldr      x8, [x0, #0x128]
0065BA508  ldr      x9, [x19, #0x30]
0065BA50C  ldr      x10, [x19, #0x70]
0065BA510  sub      x8, x8, x9
0065BA514  cmp      x8, x10
0065BA518  b.ge     #0x65ba5a4
0065BA51C  ldrb     w8, [x24, #0xa4b]
0065BA520  cbnz     w8, #0x65ba538
0065BA524  adrp     x0, #0x8ee5000
0065BA528  ldr      x0, [x0, #0xb28]
0065BA52C  bl       #0x382bd14 ; 
0065BA530  mov      w8, #1
0065BA534  strb     w8, [x24, #0xa4b]
0065BA538  ldr      x1, [x23]
0065BA53C  ldrb     w8, [x1, #0x53]
0065BA540  tbnz     w8, #5, #0x65ba54c
0065BA544  ldr      x0, [x19, #0x20]
0065BA548  b        #0x65ba558 ; 
0065BA54C  ldr      x8, [x1, #0x60]
0065BA550  mov      x0, x19
0065BA554  blr      x8
0065BA558  cbz      x0, #0x65baa4c
0065BA55C  ldr      x8, [x0, #0x128]
0065BA560  ldr      x9, [x19, #0x30]
0065BA564  ldr      x10, [x19, #0x68]
0065BA568  sub      x8, x8, x9
0065BA56C  cmp      x8, x10
0065BA570  b.lt     #0x65ba888
0065BA574  ldrb     w8, [x24, #0xa4b]
0065BA578  cbnz     w8, #0x65ba590
0065BA57C  adrp     x0, #0x8ee5000
0065BA580  ldr      x0, [x0, #0xb28]
0065BA584  bl       #0x382bd14 ; 
0065BA588  mov      w8, #1
0065BA58C  strb     w8, [x24, #0xa4b]
0065BA590  ldr      x1, [x23]
0065BA594  ldrb     w8, [x1, #0x53]
0065BA598  tbnz     w8, #5, #0x65ba5d4
0065BA59C  ldr      x21, [x19, #0x20]
0065BA5A0  b        #0x65ba5e4 ; 
0065BA5A4  ldrb     w8, [x24, #0xa4b]
0065BA5A8  cbnz     w8, #0x65ba5c0
0065BA5AC  adrp     x0, #0x8ee5000
0065BA5B0  ldr      x0, [x0, #0xb28]
0065BA5B4  bl       #0x382bd14 ; 
0065BA5B8  mov      w8, #1
0065BA5BC  strb     w8, [x24, #0xa4b]
0065BA5C0  ldr      x1, [x23]
0065BA5C4  ldrb     w8, [x1, #0x53]
0065BA5C8  tbnz     w8, #5, #0x65ba72c
0065BA5CC  ldr      x21, [x19, #0x20]
0065BA5D0  b        #0x65ba73c ; 
0065BA5D4  ldr      x8, [x1, #0x60]
0065BA5D8  mov      x0, x19
0065BA5DC  blr      x8
0065BA5E0  mov      x21, x0
0065BA5E4  cbz      x21, #0x65baa4c
0065BA5E8  adrp     x25, #0x9591000
0065BA5EC  ldrb     w8, [x25, #0xa4c]
0065BA5F0  cbnz     w8, #0x65ba608
0065BA5F4  adrp     x0, #0x8ee5000
0065BA5F8  ldr      x0, [x0, #0xb30]
0065BA5FC  bl       #0x382bd14 ; 
0065BA600  mov      w8, #1
0065BA604  strb     w8, [x25, #0xa4c]
0065BA608  adrp     x8, #0x8ee5000
0065BA60C  ldr      x8, [x8, #0xb30]
0065BA610  ldr      x1, [x8]
0065BA614  ldrb     w8, [x1, #0x53]
0065BA618  tbnz     w8, #5, #0x65ba624
0065BA61C  ldr      x0, [x21, #0x210]
0065BA620  b        #0x65ba630 ; 
0065BA624  ldr      x8, [x1, #0x60]
0065BA628  mov      x0, x21
0065BA62C  blr      x8
0065BA630  cbz      x0, #0x65baa4c
0065BA634  adrp     x8, #0x8f09000
0065BA638  ldr      x8, [x8, #0xf70]
0065BA63C  ldr      x1, [x8]
0065BA640  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0065BA644  cbz      x0, #0x65baa4c
0065BA648  mov      x1, xzr
0065BA64C  mov      x21, x0
0065BA650  bl       #0x6b4d2e8 ; HotFix.Common.PooledElement$$Alloc
0065BA654  ldp      x8, x2, [x19, #0x50]
0065BA658  ldr      q0, [x19, #0x40]
0065BA65C  ldr      w1, [x19, #0x3c]
0065BA660  add      x3, sp, #0x40
0065BA664  str      x8, [sp, #0x50]
0065BA668  str      q0, [sp, #0x40]
0065BA66C  ldp      w4, w5, [x19, #0x60]
0065BA670  mov      x0, x21
0065BA674  bl       #0x65bab4c ; HotFix.BattleLogic.BeeMonsterRefresher$$SetData
0065BA678  ldr      x0, [x19, #0x78]
0065BA67C  cbz      x0, #0x65baa4c
0065BA680  adrp     x9, #0x8f09000
0065BA684  ldr      x9, [x9, #0xf50]
0065BA688  ldr      w10, [x0, #0x1c]
0065BA68C  ldr      x8, [x0, #0x10]
0065BA690  ldr      x9, [x9]
0065BA694  add      w10, w10, #1
0065BA698  str      w10, [x0, #0x1c]
0065BA69C  cbz      x8, #0x65baa4c
0065BA6A0  ldrsw    x10, [x0, #0x18]
0065BA6A4  ldr      w11, [x8, #0x18]
0065BA6A8  cmp      w10, w11
0065BA6AC  b.hs     #0x65ba6d0
0065BA6B0  add      w9, w10, #1
0065BA6B4  add      x8, x8, x10, lsl #3
0065BA6B8  str      w9, [x0, #0x18]
0065BA6BC  str      x21, [x8, #0x20]!
0065BA6C0  mov      x0, x8
0065BA6C4  mov      x1, x21
0065BA6C8  bl       #0x382bcb8 ; 
0065BA6CC  b        #0x65ba6e4 ; 
0065BA6D0  ldr      x8, [x9, #0x20]
0065BA6D4  mov      x1, x21
0065BA6D8  ldr      x8, [x8, #0xc0]
0065BA6DC  ldr      x2, [x8, #0x70]
0065BA6E0  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0065BA6E4  ldrb     w8, [x24, #0xa4b]
0065BA6E8  cbnz     w8, #0x65ba700
0065BA6EC  adrp     x0, #0x8ee5000
0065BA6F0  ldr      x0, [x0, #0xb28]
0065BA6F4  bl       #0x382bd14 ; 
0065BA6F8  mov      w8, #1
0065BA6FC  strb     w8, [x24, #0xa4b]
0065BA700  ldr      x1, [x23]
0065BA704  ldrb     w8, [x1, #0x53]
0065BA708  tbnz     w8, #5, #0x65ba714
0065BA70C  ldr      x0, [x19, #0x20]
0065BA710  b        #0x65ba720 ; 
0065BA714  ldr      x8, [x1, #0x60]
0065BA718  mov      x0, x19
0065BA71C  blr      x8
0065BA720  cbz      x0, #0x65baa4c
0065BA724  ldr      x8, [x0, #0x128]
0065BA728  b        #0x65ba884 ; 
0065BA72C  ldr      x8, [x1, #0x60]
0065BA730  mov      x0, x19
0065BA734  blr      x8
0065BA738  mov      x21, x0
0065BA73C  cbz      x21, #0x65baa4c
0065BA740  adrp     x25, #0x9591000
0065BA744  ldrb     w8, [x25, #0xa4c]
0065BA748  cbnz     w8, #0x65ba760
0065BA74C  adrp     x0, #0x8ee5000
0065BA750  ldr      x0, [x0, #0xb30]
0065BA754  bl       #0x382bd14 ; 
0065BA758  mov      w8, #1
0065BA75C  strb     w8, [x25, #0xa4c]
0065BA760  adrp     x8, #0x8ee5000
0065BA764  ldr      x8, [x8, #0xb30]
0065BA768  ldr      x1, [x8]
0065BA76C  ldrb     w8, [x1, #0x53]
0065BA770  tbnz     w8, #5, #0x65ba77c
0065BA774  ldr      x0, [x21, #0x210]
0065BA778  b        #0x65ba788 ; 
0065BA77C  ldr      x8, [x1, #0x60]
0065BA780  mov      x0, x21
0065BA784  blr      x8
0065BA788  cbz      x0, #0x65baa4c
0065BA78C  adrp     x8, #0x8f09000
0065BA790  ldr      x8, [x8, #0xf70]
0065BA794  ldr      x1, [x8]
0065BA798  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0065BA79C  cbz      x0, #0x65baa4c
0065BA7A0  mov      x1, xzr
0065BA7A4  mov      x21, x0
0065BA7A8  bl       #0x6b4d2e8 ; HotFix.Common.PooledElement$$Alloc
0065BA7AC  ldp      x8, x2, [x19, #0x50]
0065BA7B0  ldr      q0, [x19, #0x40]
0065BA7B4  ldr      w1, [x19, #0x3c]
0065BA7B8  add      x3, sp, #0x60
0065BA7BC  str      x8, [sp, #0x70]
0065BA7C0  str      q0, [sp, #0x60]
0065BA7C4  ldp      w4, w5, [x19, #0x60]
0065BA7C8  mov      x0, x21
0065BA7CC  bl       #0x65bab4c ; HotFix.BattleLogic.BeeMonsterRefresher$$SetData
0065BA7D0  ldr      x0, [x19, #0x78]
0065BA7D4  cbz      x0, #0x65baa4c
0065BA7D8  adrp     x9, #0x8f09000
0065BA7DC  ldr      x9, [x9, #0xf50]
0065BA7E0  ldr      w10, [x0, #0x1c]
0065BA7E4  ldr      x8, [x0, #0x10]
0065BA7E8  ldr      x9, [x9]
0065BA7EC  add      w10, w10, #1
0065BA7F0  str      w10, [x0, #0x1c]
0065BA7F4  cbz      x8, #0x65baa4c
0065BA7F8  ldrsw    x10, [x0, #0x18]
0065BA7FC  ldr      w11, [x8, #0x18]
0065BA800  cmp      w10, w11
0065BA804  b.hs     #0x65ba828
0065BA808  add      w9, w10, #1
0065BA80C  add      x8, x8, x10, lsl #3
0065BA810  str      w9, [x0, #0x18]
0065BA814  str      x21, [x8, #0x20]!
0065BA818  mov      x0, x8
0065BA81C  mov      x1, x21
0065BA820  bl       #0x382bcb8 ; 
0065BA824  b        #0x65ba83c ; 
0065BA828  ldr      x8, [x9, #0x20]
0065BA82C  mov      x1, x21
0065BA830  ldr      x8, [x8, #0xc0]
0065BA834  ldr      x2, [x8, #0x70]
0065BA838  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0065BA83C  ldrb     w8, [x24, #0xa4b]
0065BA840  cbnz     w8, #0x65ba858
0065BA844  adrp     x0, #0x8ee5000
0065BA848  ldr      x0, [x0, #0xb28]
0065BA84C  bl       #0x382bd14 ; 
0065BA850  mov      w8, #1
0065BA854  strb     w8, [x24, #0xa4b]
0065BA858  ldr      x1, [x23]
0065BA85C  ldrb     w8, [x1, #0x53]
0065BA860  tbnz     w8, #5, #0x65ba86c
0065BA864  ldr      x0, [x19, #0x20]
0065BA868  b        #0x65ba878 ; 
0065BA86C  ldr      x8, [x1, #0x60]
0065BA870  mov      x0, x19
0065BA874  blr      x8
0065BA878  cbz      x0, #0x65baa4c
0065BA87C  ldr      x8, [x0, #0x128]
0065BA880  strb     wzr, [x19, #0x38]
0065BA884  str      x8, [x19, #0x30]
0065BA888  ldr      x0, [x19, #0x78]
0065BA88C  cbz      x0, #0x65baa4c
0065BA890  adrp     x24, #0x8f09000
0065BA894  ldr      x24, [x24, #0xf60]
0065BA898  add      x8, sp, #8
0065BA89C  ldr      x1, [x24]
0065BA8A0  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
0065BA8A4  ldur     q0, [sp, #8]
0065BA8A8  ldr      x8, [sp, #0x18]
0065BA8AC  adrp     x23, #0x8f09000
0065BA8B0  ldr      x23, [x23, #0xf40]
0065BA8B4  str      q0, [sp, #0x20]
0065BA8B8  str      x8, [sp, #0x30]
0065BA8BC  adrp     x25, #0x8f09000
0065BA8C0  ldr      x25, [x25, #0xf50]
0065BA8C4  ldr      x1, [x23]
0065BA8C8  add      x0, sp, #0x20
0065BA8CC  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
0065BA8D0  tbz      w0, #0, #0x65ba954
0065BA8D4  ldr      x21, [sp, #0x30]
0065BA8D8  cbz      x21, #0x65baa38
0065BA8DC  mov      x0, x21
0065BA8E0  mov      x1, x20
0065BA8E4  bl       #0x65bac44 ; HotFix.BattleLogic.BeeMonsterRefresher$$Update
0065BA8E8  tbz      w0, #0, #0x65ba8c4
0065BA8EC  ldr      x0, [x19, #0x80]
0065BA8F0  cbz      x0, #0x65baa44
0065BA8F4  ldr      w10, [x0, #0x1c]
0065BA8F8  ldr      x8, [x0, #0x10]
0065BA8FC  ldr      x9, [x25]
0065BA900  add      w10, w10, #1
0065BA904  str      w10, [x0, #0x1c]
0065BA908  cbz      x8, #0x65baa48
0065BA90C  ldrsw    x10, [x0, #0x18]
0065BA910  ldr      w11, [x8, #0x18]
0065BA914  cmp      w10, w11
0065BA918  b.hs     #0x65ba93c
0065BA91C  add      w9, w10, #1
0065BA920  add      x8, x8, x10, lsl #3
0065BA924  str      w9, [x0, #0x18]
0065BA928  str      x21, [x8, #0x20]!
0065BA92C  mov      x0, x8
0065BA930  mov      x1, x21
0065BA934  bl       #0x382bcb8 ; 
0065BA938  b        #0x65ba8c4 ; 
0065BA93C  ldr      x8, [x9, #0x20]
0065BA940  ldr      x8, [x8, #0xc0]
0065BA944  ldr      x2, [x8, #0x70]
0065BA948  mov      x1, x21
0065BA94C  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0065BA950  b        #0x65ba8c4 ; 
0065BA954  adrp     x8, #0x8f09000
0065BA958  ldr      x8, [x8, #0xf38]
0065BA95C  add      x0, sp, #0x20
0065BA960  ldr      x1, [x8]
0065BA964  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BA968  ldr      x0, [x19, #0x80]
0065BA96C  cbz      x0, #0x65baa4c
0065BA970  ldr      x1, [x24]
0065BA974  add      x8, sp, #8
0065BA978  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
0065BA97C  ldur     q0, [sp, #8]
0065BA980  ldr      x8, [sp, #0x18]
0065BA984  adrp     x21, #0x8f09000
0065BA988  str      q0, [sp, #0x20]
0065BA98C  str      x8, [sp, #0x30]
0065BA990  ldr      x21, [x21, #0xf68]
0065BA994  ldr      x1, [x23]
0065BA998  add      x0, sp, #0x20
0065BA99C  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
0065BA9A0  tbz      w0, #0, #0x65ba9d0
0065BA9A4  ldr      x0, [x19, #0x78]
0065BA9A8  cbz      x0, #0x65baa3c
0065BA9AC  ldr      x20, [sp, #0x30]
0065BA9B0  ldr      x2, [x21]
0065BA9B4  mov      x1, x20
0065BA9B8  bl       #0x4db16c0 ; System.Collections.Generic.List<object>$$Remove
0065BA9BC  cbz      x20, #0x65baa40
0065BA9C0  mov      x0, x20
0065BA9C4  mov      x1, xzr
0065BA9C8  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0065BA9CC  b        #0x65ba994 ; 
0065BA9D0  adrp     x8, #0x8f09000
0065BA9D4  ldr      x8, [x8, #0xf38]
0065BA9D8  add      x0, sp, #0x20
0065BA9DC  ldr      x1, [x8]
0065BA9E0  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BA9E4  ldr      x8, [x19, #0x80]
0065BA9E8  cbz      x8, #0x65baa4c
0065BA9EC  ldp      w2, w9, [x8, #0x18]
0065BA9F0  add      w9, w9, #1
0065BA9F4  cmp      w2, #1
0065BA9F8  stp      wzr, w9, [x8, #0x18]
0065BA9FC  b.lt     #0x65baa10
0065BAA00  ldr      x0, [x8, #0x10]
0065BAA04  mov      w1, wzr
0065BAA08  mov      x3, xzr
0065BAA0C  bl       #0x7c001d0 ; System.Array$$Clear
0065BAA10  ldr      x8, [x22, #0x28]
0065BAA14  ldr      x9, [sp, #0x78]
0065BAA18  cmp      x8, x9
0065BAA1C  b.ne     #0x65baa50
0065BAA20  ldp      x20, x19, [sp, #0xb0]
0065BAA24  ldp      x22, x21, [sp, #0xa0]
0065BAA28  ldp      x24, x23, [sp, #0x90]
0065BAA2C  ldp      x30, x25, [sp, #0x80]
0065BAA30  add      sp, sp, #0xc0
0065BAA34  ret      
0065BAA38  bl       #0x382bfb8 ; 
0065BAA3C  bl       #0x382bfb8 ; 
0065BAA40  bl       #0x382bfb8 ; 
0065BAA44  bl       #0x382bfb8 ; 
0065BAA48  bl       #0x382bfb8 ; 
0065BAA4C  bl       #0x382bfb8 ; 
0065BAA50  bl       #0x89edb60 ; 
0065BAA54  b        #0x65baad8 ; 
0065BAA58  b        #0x65baa74 ; 
0065BAA5C  b        #0x65baa74 ; 
0065BAA60  b        #0x65baa74 ; 
0065BAA64  b        #0x65baa74 ; 
0065BAA68  b        #0x65baad8 ; 
0065BAA6C  b        #0x65baad8 ; 
0065BAA70  b        #0x65baad8 ; 
0065BAA74  mov      x20, x0
0065BAA78  cmp      w1, #1
0065BAA7C  b.ne     #0x65baaac
0065BAA80  mov      x0, x20
0065BAA84  bl       #0x89eda50 ; 
0065BAA88  ldr      x21, [x0]
0065BAA8C  bl       #0x89eda60 ; 
0065BAA90  adrp     x8, #0x8f09000
0065BAA94  ldr      x8, [x8, #0xf38]
0065BAA98  add      x0, sp, #0x20
0065BAA9C  ldr      x1, [x8]
0065BAAA0  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BAAA4  cbz      x21, #0x65ba9e4
0065BAAA8  b        #0x65bab0c ; 
0065BAAAC  mov      x21, xzr
0065BAAB0  b        #0x65baab8 ; 
0065BAAB4  mov      x20, x0
0065BAAB8  adrp     x8, #0x8f09000
0065BAABC  ldr      x8, [x8, #0xf38]
0065BAAC0  ldr      x1, [x8]
0065BAAC4  add      x0, sp, #0x20
0065BAAC8  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BAACC  cbz      x21, #0x65bab38
0065BAAD0  mov      x0, x21
0065BAAD4  bl       #0x382bfb0 ; 
0065BAAD8  mov      x20, x0
0065BAADC  cmp      w1, #1
0065BAAE0  b.ne     #0x65bab14
0065BAAE4  mov      x0, x20
0065BAAE8  bl       #0x89eda50 ; 
0065BAAEC  ldr      x21, [x0]
0065BAAF0  bl       #0x89eda60 ; 
0065BAAF4  adrp     x8, #0x8f09000
0065BAAF8  ldr      x8, [x8, #0xf38]
0065BAAFC  add      x0, sp, #0x20
0065BAB00  ldr      x1, [x8]
0065BAB04  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BAB08  cbz      x21, #0x65ba968
0065BAB0C  mov      x0, x21
0065BAB10  bl       #0x382bfb0 ; 
0065BAB14  mov      x21, xzr
0065BAB18  b        #0x65bab20 ; 
0065BAB1C  mov      x20, x0
0065BAB20  adrp     x8, #0x8f09000
0065BAB24  ldr      x8, [x8, #0xf38]
0065BAB28  ldr      x1, [x8]
0065BAB2C  add      x0, sp, #0x20
0065BAB30  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BAB34  cbnz     x21, #0x65bab40
0065BAB38  mov      x0, x20
0065BAB3C  bl       #0x3b56bfc ; 
0065BAB40  mov      x0, x21
0065BAB44  bl       #0x382bfb0 ; 
0065BAB48  bl       #0x3442448 ; 

; HotFix.BattleLogic.BeeMonsterCreator$$tryGetFlushPoint
; RVA 0x65BAF54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BAF54  sub      sp, sp, #0x60
0065BAF58  str      x30, [sp, #0x20]
0065BAF5C  stp      x24, x23, [sp, #0x30]
0065BAF60  stp      x22, x21, [sp, #0x40]
0065BAF64  stp      x20, x19, [sp, #0x50]
0065BAF68  mrs      x22, tpidr_el0
0065BAF6C  mov      x19, x8
0065BAF70  ldr      x8, [x22, #0x28]
0065BAF74  adrp     x23, #0x9599000
0065BAF78  adrp     x24, #0x8f09000
0065BAF7C  mov      w20, w1
0065BAF80  str      x8, [sp, #0x18]
0065BAF84  ldrb     w8, [x23, #0x478]
0065BAF88  ldr      x24, [x24, #0xf88]
0065BAF8C  mov      x21, x0
0065BAF90  tbnz     w8, #0, #0x65bafa8
0065BAF94  adrp     x0, #0x8f09000
0065BAF98  ldr      x0, [x0, #0xf88]
0065BAF9C  bl       #0x382bd14 ; 
0065BAFA0  mov      w8, #1
0065BAFA4  strb     w8, [x23, #0x478]
0065BAFA8  ldr      x2, [x24]
0065BAFAC  ldrb     w8, [x2, #0x53]
0065BAFB0  tbnz     w8, #5, #0x65baff0
0065BAFB4  adrp     x23, #0x9591000
0065BAFB8  ldrb     w8, [x23, #0xa4b]
0065BAFBC  cbnz     w8, #0x65bafd4
0065BAFC0  adrp     x0, #0x8ee5000
0065BAFC4  ldr      x0, [x0, #0xb28]
0065BAFC8  bl       #0x382bd14 ; 
0065BAFCC  mov      w8, #1
0065BAFD0  strb     w8, [x23, #0xa4b]
0065BAFD4  adrp     x8, #0x8ee5000
0065BAFD8  ldr      x8, [x8, #0xb28]
0065BAFDC  ldr      x1, [x8]
0065BAFE0  ldrb     w8, [x1, #0x53]
0065BAFE4  tbnz     w8, #5, #0x65bb008
0065BAFE8  ldr      x0, [x21, #0x20]
0065BAFEC  b        #0x65bb014 ; 
0065BAFF0  ldr      x9, [x2, #0x60]
0065BAFF4  mov      x8, x19
0065BAFF8  mov      x0, x21
0065BAFFC  mov      w1, w20
0065BB000  blr      x9
0065BB004  b        #0x65bb050 ; 
0065BB008  ldr      x8, [x1, #0x60]
0065BB00C  mov      x0, x21
0065BB010  blr      x8
0065BB014  cbz      x0, #0x65bb078
0065BB018  mov      w1, w20
0065BB01C  mov      x2, xzr
0065BB020  bl       #0x6a18f24 ; HotFix.BattleLogic.BattleWorldContext$$GetMonsterMovePath
0065BB024  mov      x8, sp
0065BB028  cbz      x0, #0x65bb03c
0065BB02C  mov      x1, xzr
0065BB030  mov      x2, xzr
0065BB034  bl       #0x690c8ac ; HotFix.BattleLogic.BezierCurve$$GetPointAt
0065BB038  b        #0x65bb040 ; 
0065BB03C  bl       #0x7d4fd40 ; Photon.Deterministic.FPVector3$$get_Zero
0065BB040  ldr      x8, [sp, #0x10]
0065BB044  ldr      q0, [sp]
0065BB048  str      x8, [x19, #0x10]
0065BB04C  str      q0, [x19]
0065BB050  ldr      x8, [x22, #0x28]
0065BB054  ldr      x9, [sp, #0x18]
0065BB058  cmp      x8, x9
0065BB05C  b.ne     #0x65bb07c
0065BB060  ldp      x20, x19, [sp, #0x50]
0065BB064  ldp      x22, x21, [sp, #0x40]
0065BB068  ldp      x24, x23, [sp, #0x30]
0065BB06C  ldr      x30, [sp, #0x20]
0065BB070  add      sp, sp, #0x60
0065BB074  ret      
0065BB078  bl       #0x382bfb8 ; 
0065BB07C  bl       #0x89edb60 ; 

; HotFix.BattleLogic.BeeMonsterCreator$$SetFlushId
; RVA 0x65BB080; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BB080  str      x30, [sp, #-0x30]!
0065BB084  stp      x22, x21, [sp, #0x10]
0065BB088  stp      x20, x19, [sp, #0x20]
0065BB08C  adrp     x21, #0x9599000
0065BB090  adrp     x22, #0x8f09000
0065BB094  ldrb     w8, [x21, #0x479]
0065BB098  ldr      x22, [x22, #0xf90]
0065BB09C  mov      w19, w1
0065BB0A0  mov      x20, x0
0065BB0A4  tbnz     w8, #0, #0x65bb0bc
0065BB0A8  adrp     x0, #0x8f09000
0065BB0AC  ldr      x0, [x0, #0xf90]
0065BB0B0  bl       #0x382bd14 ; 
0065BB0B4  mov      w8, #1
0065BB0B8  strb     w8, [x21, #0x479]
0065BB0BC  ldr      x2, [x22]
0065BB0C0  ldrb     w8, [x2, #0x53]
0065BB0C4  tbnz     w8, #5, #0x65bb110
0065BB0C8  adrp     x21, #0x9599000
0065BB0CC  ldrb     w8, [x21, #0x4eb]
0065BB0D0  cbnz     w8, #0x65bb0e8
0065BB0D4  adrp     x0, #0x8f09000
0065BB0D8  ldr      x0, [x0, #0xec8]
0065BB0DC  bl       #0x382bd14 ; 
0065BB0E0  mov      w8, #1
0065BB0E4  strb     w8, [x21, #0x4eb]
0065BB0E8  adrp     x8, #0x8f09000
0065BB0EC  ldr      x8, [x8, #0xec8]
0065BB0F0  ldr      x2, [x8]
0065BB0F4  ldrb     w8, [x2, #0x53]
0065BB0F8  tbnz     w8, #5, #0x65bb110
0065BB0FC  str      w19, [x20, #0x28]
0065BB100  ldp      x20, x19, [sp, #0x20]
0065BB104  ldp      x22, x21, [sp, #0x10]
0065BB108  ldr      x30, [sp], #0x30
0065BB10C  ret      
0065BB110  ldr      x3, [x2, #0x60]
0065BB114  mov      x0, x20
0065BB118  mov      w1, w19
0065BB11C  ldp      x20, x19, [sp, #0x20]
0065BB120  ldp      x22, x21, [sp, #0x10]
0065BB124  ldr      x30, [sp], #0x30
0065BB128  br       x3

; HotFix.BattleLogic.BeeMonsterCreator$$OnMissionClear
; RVA 0x65BB12C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BB12C  sub      sp, sp, #0x40
0065BB130  stp      x30, x21, [sp, #0x20]
0065BB134  stp      x20, x19, [sp, #0x30]
0065BB138  adrp     x20, #0x9599000
0065BB13C  adrp     x21, #0x8f09000
0065BB140  ldrb     w8, [x20, #0x47a]
0065BB144  ldr      x21, [x21, #0xf98]
0065BB148  mov      x19, x0
0065BB14C  tbnz     w8, #0, #0x65bb1a0
0065BB150  adrp     x0, #0x8f09000
0065BB154  ldr      x0, [x0, #0xf98]
0065BB158  bl       #0x382bd14 ; 
0065BB15C  adrp     x0, #0x8f09000
0065BB160  ldr      x0, [x0, #0xf38]
0065BB164  bl       #0x382bd14 ; 
0065BB168  adrp     x0, #0x8f09000
0065BB16C  ldr      x0, [x0, #0xf40]
0065BB170  bl       #0x382bd14 ; 
0065BB174  adrp     x0, #0x8f09000
0065BB178  ldr      x0, [x0, #0xf48]
0065BB17C  bl       #0x382bd14 ; 
0065BB180  adrp     x0, #0x8f09000
0065BB184  ldr      x0, [x0, #0xf58]
0065BB188  bl       #0x382bd14 ; 
0065BB18C  adrp     x0, #0x8f09000
0065BB190  ldr      x0, [x0, #0xf60]
0065BB194  bl       #0x382bd14 ; 
0065BB198  mov      w8, #1
0065BB19C  strb     w8, [x20, #0x47a]
0065BB1A0  ldr      x1, [x21]
0065BB1A4  ldrb     w8, [x1, #0x53]
0065BB1A8  tbnz     w8, #5, #0x65bb1fc
0065BB1AC  stp      xzr, xzr, [sp, #8]
0065BB1B0  str      xzr, [sp, #0x18]
0065BB1B4  ldr      x0, [x19, #0x78]
0065BB1B8  cbz      x0, #0x65bb280
0065BB1BC  adrp     x8, #0x8f09000
0065BB1C0  ldr      x8, [x8, #0xf60]
0065BB1C4  ldr      x1, [x8]
0065BB1C8  add      x8, sp, #8
0065BB1CC  bl       #0x4db0a68 ; System.Collections.Generic.List<object>$$GetEnumerator
0065BB1D0  adrp     x20, #0x8f09000
0065BB1D4  ldr      x20, [x20, #0xf40]
0065BB1D8  ldr      x1, [x20]
0065BB1DC  add      x0, sp, #8
0065BB1E0  bl       #0x60e943c ; System.Collections.Generic.List.Enumerator<object>$$MoveNext
0065BB1E4  tbz      w0, #0, #0x65bb214
0065BB1E8  ldr      x0, [sp, #0x18]
0065BB1EC  cbz      x0, #0x65bb294
0065BB1F0  mov      x1, xzr
0065BB1F4  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
0065BB1F8  b        #0x65bb1d8 ; 
0065BB1FC  ldr      x2, [x1, #0x60]
0065BB200  mov      x0, x19
0065BB204  ldp      x20, x19, [sp, #0x30]
0065BB208  ldp      x30, x21, [sp, #0x20]
0065BB20C  add      sp, sp, #0x40
0065BB210  br       x2
0065BB214  adrp     x8, #0x8f09000
0065BB218  ldr      x8, [x8, #0xf38]
0065BB21C  add      x0, sp, #8
0065BB220  ldr      x1, [x8]
0065BB224  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BB228  ldr      x8, [x19, #0x78]
0065BB22C  cbz      x8, #0x65bb298
0065BB230  ldp      w2, w9, [x8, #0x18]
0065BB234  add      w9, w9, #1
0065BB238  cmp      w2, #1
0065BB23C  stp      wzr, w9, [x8, #0x18]
0065BB240  b.lt     #0x65bb254
0065BB244  ldr      x0, [x8, #0x10]
0065BB248  mov      w1, wzr
0065BB24C  mov      x3, xzr
0065BB250  bl       #0x7c001d0 ; System.Array$$Clear
0065BB254  ldr      x8, [x19, #0x80]
0065BB258  cbz      x8, #0x65bb298
0065BB25C  ldp      w2, w9, [x8, #0x18]
0065BB260  add      w9, w9, #1
0065BB264  cmp      w2, #1
0065BB268  stp      wzr, w9, [x8, #0x18]
0065BB26C  b.lt     #0x65bb280
0065BB270  ldr      x0, [x8, #0x10]
0065BB274  mov      w1, wzr
0065BB278  mov      x3, xzr
0065BB27C  bl       #0x7c001d0 ; System.Array$$Clear
0065BB280  strb     wzr, [x19, #0x39]
0065BB284  ldp      x20, x19, [sp, #0x30]
0065BB288  ldp      x30, x21, [sp, #0x20]
0065BB28C  add      sp, sp, #0x40
0065BB290  ret      
0065BB294  bl       #0x382bfb8 ; 
0065BB298  bl       #0x382bfb8 ; 
0065BB29C  b        #0x65bb2a4 ; 
0065BB2A0  b        #0x65bb2a4 ; 
0065BB2A4  mov      x20, x0
0065BB2A8  cmp      w1, #1
0065BB2AC  b.ne     #0x65bb2e0
0065BB2B0  mov      x0, x20
0065BB2B4  bl       #0x89eda50 ; 
0065BB2B8  ldr      x21, [x0]
0065BB2BC  bl       #0x89eda60 ; 
0065BB2C0  adrp     x8, #0x8f09000
0065BB2C4  ldr      x8, [x8, #0xf38]
0065BB2C8  add      x0, sp, #8
0065BB2CC  ldr      x1, [x8]
0065BB2D0  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BB2D4  cbz      x21, #0x65bb228
0065BB2D8  mov      x0, x21
0065BB2DC  bl       #0x382bfb0 ; 
0065BB2E0  mov      x21, xzr
0065BB2E4  b        #0x65bb2ec ; 
0065BB2E8  mov      x20, x0
0065BB2EC  adrp     x8, #0x8f09000
0065BB2F0  ldr      x8, [x8, #0xf38]
0065BB2F4  ldr      x1, [x8]
0065BB2F8  add      x0, sp, #8
0065BB2FC  bl       #0x60e9438 ; System.Collections.Generic.List.Enumerator<object>$$Dispose
0065BB300  cbnz     x21, #0x65bb30c
0065BB304  mov      x0, x20
0065BB308  bl       #0x3b56bfc ; 
0065BB30C  mov      x0, x21
0065BB310  bl       #0x382bfb0 ; 
0065BB314  bl       #0x3442448 ; 

; HotFix.BattleLogic.BeeMonsterCreator$$.ctor
; RVA 0x65BB318; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BB318  stp      x30, x21, [sp, #-0x20]!
0065BB31C  stp      x20, x19, [sp, #0x10]
0065BB320  adrp     x20, #0x9599000
0065BB324  adrp     x21, #0x8f09000
0065BB328  ldrb     w8, [x20, #0x47b]
0065BB32C  ldr      x21, [x21, #0xfa0]
0065BB330  mov      x19, x0
0065BB334  tbnz     w8, #0, #0x65bb34c
0065BB338  adrp     x0, #0x8f09000
0065BB33C  ldr      x0, [x0, #0xfa0]
0065BB340  bl       #0x382bd14 ; 
0065BB344  mov      w8, #1
0065BB348  strb     w8, [x20, #0x47b]
0065BB34C  ldr      x1, [x21]
0065BB350  ldrb     w8, [x1, #0x53]
0065BB354  tbnz     w8, #5, #0x65bb36c
0065BB358  mov      x0, x19
0065BB35C  ldp      x20, x19, [sp, #0x10]
0065BB360  mov      x1, xzr
0065BB364  ldp      x30, x21, [sp], #0x20
0065BB368  b        #0x6a34500 ; HotFix.BattleLogic.PooledWorldElement$$.ctor
0065BB36C  ldr      x2, [x1, #0x60]
0065BB370  mov      x0, x19
0065BB374  ldp      x20, x19, [sp, #0x10]
0065BB378  ldp      x30, x21, [sp], #0x20
0065BB37C  br       x2

