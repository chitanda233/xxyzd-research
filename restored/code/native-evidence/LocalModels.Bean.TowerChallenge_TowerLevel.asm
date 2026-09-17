; LocalModels.Bean.TowerChallenge_TowerLevel$$readImpl
; RVA 0x6B17E64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B17E64  stp      x30, x21, [sp, #-0x20]!
006B17E68  stp      x20, x19, [sp, #0x10]
006B17E6C  adrp     x20, #0x959f000
006B17E70  adrp     x21, #0x8f3f000
006B17E74  ldrb     w8, [x20, #0x601]
006B17E78  ldr      x21, [x21, #0x228]
006B17E7C  mov      x19, x0
006B17E80  tbnz     w8, #0, #0x6b17e98
006B17E84  adrp     x0, #0x8f3f000
006B17E88  ldr      x0, [x0, #0x228]
006B17E8C  bl       #0x382bd14 ; 
006B17E90  mov      w8, #1
006B17E94  strb     w8, [x20, #0x601]
006B17E98  ldr      x1, [x21]
006B17E9C  ldrb     w8, [x1, #0x53]
006B17EA0  tbnz     w8, #5, #0x6b17ef0
006B17EA4  mov      x0, x19
006B17EA8  mov      x1, xzr
006B17EAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B17EB0  adrp     x21, #0x959f000
006B17EB4  ldrb     w8, [x21, #0x9f3]
006B17EB8  mov      w20, w0
006B17EBC  cbnz     w8, #0x6b17ed4
006B17EC0  adrp     x0, #0x8f3f000
006B17EC4  ldr      x0, [x0, #0x1c0]
006B17EC8  bl       #0x382bd14 ; 
006B17ECC  mov      w8, #1
006B17ED0  strb     w8, [x21, #0x9f3]
006B17ED4  adrp     x8, #0x8f3f000
006B17ED8  ldr      x8, [x8, #0x1c0]
006B17EDC  ldr      x2, [x8]
006B17EE0  ldrb     w8, [x2, #0x53]
006B17EE4  tbnz     w8, #5, #0x6b17f04
006B17EE8  str      w20, [x19, #0x20]
006B17EEC  b        #0x6b17f14 ; 
006B17EF0  ldr      x2, [x1, #0x60]
006B17EF4  mov      x0, x19
006B17EF8  ldp      x20, x19, [sp, #0x10]
006B17EFC  ldp      x30, x21, [sp], #0x20
006B17F00  br       x2
006B17F04  ldr      x8, [x2, #0x60]
006B17F08  mov      x0, x19
006B17F0C  mov      w1, w20
006B17F10  blr      x8
006B17F14  mov      x0, x19
006B17F18  mov      x1, xzr
006B17F1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B17F20  adrp     x21, #0x959f000
006B17F24  ldrb     w8, [x21, #0x9f4]
006B17F28  mov      w20, w0
006B17F2C  cbnz     w8, #0x6b17f44
006B17F30  adrp     x0, #0x8f3f000
006B17F34  ldr      x0, [x0, #0x1d0]
006B17F38  bl       #0x382bd14 ; 
006B17F3C  mov      w8, #1
006B17F40  strb     w8, [x21, #0x9f4]
006B17F44  adrp     x8, #0x8f3f000
006B17F48  ldr      x8, [x8, #0x1d0]
006B17F4C  ldr      x2, [x8]
006B17F50  ldrb     w8, [x2, #0x53]
006B17F54  tbnz     w8, #5, #0x6b17f60
006B17F58  str      w20, [x19, #0x24]
006B17F5C  b        #0x6b17f70 ; 
006B17F60  ldr      x8, [x2, #0x60]
006B17F64  mov      x0, x19
006B17F68  mov      w1, w20
006B17F6C  blr      x8
006B17F70  mov      x0, x19
006B17F74  mov      x1, xzr
006B17F78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B17F7C  adrp     x21, #0x959f000
006B17F80  ldrb     w8, [x21, #0x9f5]
006B17F84  mov      w20, w0
006B17F88  cbnz     w8, #0x6b17fa0
006B17F8C  adrp     x0, #0x8f3f000
006B17F90  ldr      x0, [x0, #0x1e0]
006B17F94  bl       #0x382bd14 ; 
006B17F98  mov      w8, #1
006B17F9C  strb     w8, [x21, #0x9f5]
006B17FA0  adrp     x8, #0x8f3f000
006B17FA4  ldr      x8, [x8, #0x1e0]
006B17FA8  ldr      x2, [x8]
006B17FAC  ldrb     w8, [x2, #0x53]
006B17FB0  tbnz     w8, #5, #0x6b17fbc
006B17FB4  str      w20, [x19, #0x28]
006B17FB8  b        #0x6b17fcc ; 
006B17FBC  ldr      x8, [x2, #0x60]
006B17FC0  mov      x0, x19
006B17FC4  mov      w1, w20
006B17FC8  blr      x8
006B17FCC  mov      x0, x19
006B17FD0  mov      x1, xzr
006B17FD4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B17FD8  adrp     x21, #0x959f000
006B17FDC  ldrb     w8, [x21, #0x9f6]
006B17FE0  mov      w20, w0
006B17FE4  cbnz     w8, #0x6b17ffc
006B17FE8  adrp     x0, #0x8f3f000
006B17FEC  ldr      x0, [x0, #0x1f0]
006B17FF0  bl       #0x382bd14 ; 
006B17FF4  mov      w8, #1
006B17FF8  strb     w8, [x21, #0x9f6]
006B17FFC  adrp     x8, #0x8f3f000
006B18000  ldr      x8, [x8, #0x1f0]
006B18004  ldr      x2, [x8]
006B18008  ldrb     w8, [x2, #0x53]
006B1800C  tbnz     w8, #5, #0x6b18018
006B18010  str      w20, [x19, #0x2c]
006B18014  b        #0x6b18028 ; 
006B18018  ldr      x8, [x2, #0x60]
006B1801C  mov      x0, x19
006B18020  mov      w1, w20
006B18024  blr      x8
006B18028  mov      x0, x19
006B1802C  mov      x1, xzr
006B18030  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B18034  adrp     x21, #0x959f000
006B18038  ldrb     w8, [x21, #0x9f7]
006B1803C  mov      x20, x0
006B18040  cbnz     w8, #0x6b18058
006B18044  adrp     x0, #0x8f3f000
006B18048  ldr      x0, [x0, #0x200]
006B1804C  bl       #0x382bd14 ; 
006B18050  mov      w8, #1
006B18054  strb     w8, [x21, #0x9f7]
006B18058  adrp     x8, #0x8f3f000
006B1805C  ldr      x8, [x8, #0x200]
006B18060  ldr      x2, [x8]
006B18064  ldrb     w8, [x2, #0x53]
006B18068  tbnz     w8, #5, #0x6b18080
006B1806C  mov      x0, x19
006B18070  str      x20, [x0, #0x30]!
006B18074  mov      x1, x20
006B18078  bl       #0x382bcb8 ; 
006B1807C  b        #0x6b18090 ; 
006B18080  ldr      x8, [x2, #0x60]
006B18084  mov      x0, x19
006B18088  mov      x1, x20
006B1808C  blr      x8
006B18090  mov      x0, x19
006B18094  mov      x1, xzr
006B18098  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1809C  adrp     x21, #0x959f000
006B180A0  ldrb     w8, [x21, #0x9f8]
006B180A4  mov      x20, x0
006B180A8  cbnz     w8, #0x6b180c0
006B180AC  adrp     x0, #0x8f3f000
006B180B0  ldr      x0, [x0, #0x210]
006B180B4  bl       #0x382bd14 ; 
006B180B8  mov      w8, #1
006B180BC  strb     w8, [x21, #0x9f8]
006B180C0  adrp     x8, #0x8f3f000
006B180C4  ldr      x8, [x8, #0x210]
006B180C8  ldr      x2, [x8]
006B180CC  ldrb     w8, [x2, #0x53]
006B180D0  tbnz     w8, #5, #0x6b180e8
006B180D4  mov      x0, x19
006B180D8  str      x20, [x0, #0x38]!
006B180DC  mov      x1, x20
006B180E0  bl       #0x382bcb8 ; 
006B180E4  b        #0x6b180f8 ; 
006B180E8  ldr      x8, [x2, #0x60]
006B180EC  mov      x0, x19
006B180F0  mov      x1, x20
006B180F4  blr      x8
006B180F8  mov      x0, x19
006B180FC  mov      x1, xzr
006B18100  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B18104  adrp     x21, #0x959f000
006B18108  ldrb     w8, [x21, #0x9f9]
006B1810C  mov      x20, x0
006B18110  cbnz     w8, #0x6b18128
006B18114  adrp     x0, #0x8f3f000
006B18118  ldr      x0, [x0, #0x220]
006B1811C  bl       #0x382bd14 ; 
006B18120  mov      w8, #1
006B18124  strb     w8, [x21, #0x9f9]
006B18128  adrp     x8, #0x8f3f000
006B1812C  ldr      x8, [x8, #0x220]
006B18130  ldr      x2, [x8]
006B18134  ldrb     w8, [x2, #0x53]
006B18138  tbnz     w8, #5, #0x6b18150
006B1813C  str      x20, [x19, #0x40]!
006B18140  mov      x0, x19
006B18144  mov      x1, x20
006B18148  bl       #0x382bcb8 ; 
006B1814C  b        #0x6b18160 ; 
006B18150  ldr      x8, [x2, #0x60]
006B18154  mov      x0, x19
006B18158  mov      x1, x20
006B1815C  blr      x8
006B18160  ldp      x20, x19, [sp, #0x10]
006B18164  mov      w0, #1
006B18168  ldp      x30, x21, [sp], #0x20
006B1816C  ret      

