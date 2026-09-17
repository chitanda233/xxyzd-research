; LocalModels.Bean.Calendar_CalendarConstant$$readImpl
; RVA 0x688F738; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00688F738  str      d8, [sp, #-0x30]!
00688F73C  stp      x30, x21, [sp, #0x10]
00688F740  stp      x20, x19, [sp, #0x20]
00688F744  adrp     x20, #0x959b000
00688F748  adrp     x21, #0x8f25000
00688F74C  ldrb     w8, [x20, #0xd0b]
00688F750  ldr      x21, [x21, #0x650]
00688F754  mov      x19, x0
00688F758  tbnz     w8, #0, #0x688f770
00688F75C  adrp     x0, #0x8f25000
00688F760  ldr      x0, [x0, #0x650]
00688F764  bl       #0x382bd14 ; 
00688F768  mov      w8, #1
00688F76C  strb     w8, [x20, #0xd0b]
00688F770  ldr      x1, [x21]
00688F774  ldrb     w8, [x1, #0x53]
00688F778  tbnz     w8, #5, #0x688f7d4
00688F77C  mov      x0, x19
00688F780  mov      x1, xzr
00688F784  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688F788  adrp     x21, #0x959c000
00688F78C  ldrb     w8, [x21, #0x456]
00688F790  mov      x20, x0
00688F794  cbnz     w8, #0x688f7ac
00688F798  adrp     x0, #0x8f25000
00688F79C  ldr      x0, [x0, #0x5d8]
00688F7A0  bl       #0x382bd14 ; 
00688F7A4  mov      w8, #1
00688F7A8  strb     w8, [x21, #0x456]
00688F7AC  adrp     x8, #0x8f25000
00688F7B0  ldr      x8, [x8, #0x5d8]
00688F7B4  ldr      x2, [x8]
00688F7B8  ldrb     w8, [x2, #0x53]
00688F7BC  tbnz     w8, #5, #0x688f7ec
00688F7C0  mov      x0, x19
00688F7C4  str      x20, [x0, #0x20]!
00688F7C8  mov      x1, x20
00688F7CC  bl       #0x382bcb8 ; 
00688F7D0  b        #0x688f7fc ; 
00688F7D4  ldr      x2, [x1, #0x60]
00688F7D8  mov      x0, x19
00688F7DC  ldp      x20, x19, [sp, #0x20]
00688F7E0  ldp      x30, x21, [sp, #0x10]
00688F7E4  ldr      d8, [sp], #0x30
00688F7E8  br       x2
00688F7EC  ldr      x8, [x2, #0x60]
00688F7F0  mov      x0, x19
00688F7F4  mov      x1, x20
00688F7F8  blr      x8
00688F7FC  mov      x0, x19
00688F800  mov      x1, xzr
00688F804  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688F808  adrp     x21, #0x959c000
00688F80C  ldrb     w8, [x21, #0x457]
00688F810  mov      x20, x0
00688F814  cbnz     w8, #0x688f82c
00688F818  adrp     x0, #0x8f25000
00688F81C  ldr      x0, [x0, #0x5e8]
00688F820  bl       #0x382bd14 ; 
00688F824  mov      w8, #1
00688F828  strb     w8, [x21, #0x457]
00688F82C  adrp     x8, #0x8f25000
00688F830  ldr      x8, [x8, #0x5e8]
00688F834  ldr      x2, [x8]
00688F838  ldrb     w8, [x2, #0x53]
00688F83C  tbnz     w8, #5, #0x688f854
00688F840  mov      x0, x19
00688F844  str      x20, [x0, #0x28]!
00688F848  mov      x1, x20
00688F84C  bl       #0x382bcb8 ; 
00688F850  b        #0x688f864 ; 
00688F854  ldr      x8, [x2, #0x60]
00688F858  mov      x0, x19
00688F85C  mov      x1, x20
00688F860  blr      x8
00688F864  mov      x0, x19
00688F868  mov      x1, xzr
00688F86C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688F870  adrp     x21, #0x959c000
00688F874  ldrb     w8, [x21, #0x458]
00688F878  mov      w20, w0
00688F87C  cbnz     w8, #0x688f894
00688F880  adrp     x0, #0x8f25000
00688F884  ldr      x0, [x0, #0x5f8]
00688F888  bl       #0x382bd14 ; 
00688F88C  mov      w8, #1
00688F890  strb     w8, [x21, #0x458]
00688F894  adrp     x8, #0x8f25000
00688F898  ldr      x8, [x8, #0x5f8]
00688F89C  ldr      x2, [x8]
00688F8A0  ldrb     w8, [x2, #0x53]
00688F8A4  tbnz     w8, #5, #0x688f8b0
00688F8A8  str      w20, [x19, #0x30]
00688F8AC  b        #0x688f8c0 ; 
00688F8B0  ldr      x8, [x2, #0x60]
00688F8B4  mov      x0, x19
00688F8B8  mov      w1, w20
00688F8BC  blr      x8
00688F8C0  mov      x0, x19
00688F8C4  mov      x1, xzr
00688F8C8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00688F8CC  adrp     x21, #0x959c000
00688F8D0  ldrb     w8, [x21, #0x459]
00688F8D4  mov      x20, x0
00688F8D8  cbnz     w8, #0x688f8f0
00688F8DC  adrp     x0, #0x8f25000
00688F8E0  ldr      x0, [x0, #0x608]
00688F8E4  bl       #0x382bd14 ; 
00688F8E8  mov      w8, #1
00688F8EC  strb     w8, [x21, #0x459]
00688F8F0  adrp     x8, #0x8f25000
00688F8F4  ldr      x8, [x8, #0x608]
00688F8F8  ldr      x2, [x8]
00688F8FC  ldrb     w8, [x2, #0x53]
00688F900  tbnz     w8, #5, #0x688f918
00688F904  mov      x0, x19
00688F908  str      x20, [x0, #0x38]!
00688F90C  mov      x1, x20
00688F910  bl       #0x382bcb8 ; 
00688F914  b        #0x688f928 ; 
00688F918  ldr      x8, [x2, #0x60]
00688F91C  mov      x0, x19
00688F920  mov      x1, x20
00688F924  blr      x8
00688F928  mov      x0, x19
00688F92C  mov      x1, xzr
00688F930  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00688F934  adrp     x21, #0x959c000
00688F938  ldrb     w8, [x21, #0x45a]
00688F93C  mov      x20, x0
00688F940  cbnz     w8, #0x688f958
00688F944  adrp     x0, #0x8f25000
00688F948  ldr      x0, [x0, #0x618]
00688F94C  bl       #0x382bd14 ; 
00688F950  mov      w8, #1
00688F954  strb     w8, [x21, #0x45a]
00688F958  adrp     x8, #0x8f25000
00688F95C  ldr      x8, [x8, #0x618]
00688F960  ldr      x2, [x8]
00688F964  ldrb     w8, [x2, #0x53]
00688F968  tbnz     w8, #5, #0x688f980
00688F96C  mov      x0, x19
00688F970  str      x20, [x0, #0x40]!
00688F974  mov      x1, x20
00688F978  bl       #0x382bcb8 ; 
00688F97C  b        #0x688f990 ; 
00688F980  ldr      x8, [x2, #0x60]
00688F984  mov      x0, x19
00688F988  mov      x1, x20
00688F98C  blr      x8
00688F990  mov      x0, x19
00688F994  mov      x1, xzr
00688F998  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
00688F99C  adrp     x20, #0x959c000
00688F9A0  ldrb     w8, [x20, #0x45b]
00688F9A4  mov      v8.16b, v0.16b
00688F9A8  cbnz     w8, #0x688f9c0
00688F9AC  adrp     x0, #0x8f25000
00688F9B0  ldr      x0, [x0, #0x628]
00688F9B4  bl       #0x382bd14 ; 
00688F9B8  mov      w8, #1
00688F9BC  strb     w8, [x20, #0x45b]
00688F9C0  adrp     x8, #0x8f25000
00688F9C4  ldr      x8, [x8, #0x628]
00688F9C8  ldr      x1, [x8]
00688F9CC  ldrb     w8, [x1, #0x53]
00688F9D0  tbnz     w8, #5, #0x688f9dc
00688F9D4  str      s8, [x19, #0x48]
00688F9D8  b        #0x688f9ec ; 
00688F9DC  ldr      x8, [x1, #0x60]
00688F9E0  mov      x0, x19
00688F9E4  mov      v0.16b, v8.16b
00688F9E8  blr      x8
00688F9EC  mov      x0, x19
00688F9F0  mov      x1, xzr
00688F9F4  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
00688F9F8  adrp     x21, #0x959c000
00688F9FC  ldrb     w8, [x21, #0x45c]
00688FA00  mov      x20, x0
00688FA04  cbnz     w8, #0x688fa1c
00688FA08  adrp     x0, #0x8f25000
00688FA0C  ldr      x0, [x0, #0x638]
00688FA10  bl       #0x382bd14 ; 
00688FA14  mov      w8, #1
00688FA18  strb     w8, [x21, #0x45c]
00688FA1C  adrp     x8, #0x8f25000
00688FA20  ldr      x8, [x8, #0x638]
00688FA24  ldr      x2, [x8]
00688FA28  ldrb     w8, [x2, #0x53]
00688FA2C  tbnz     w8, #5, #0x688fa44
00688FA30  mov      x0, x19
00688FA34  str      x20, [x0, #0x50]!
00688FA38  mov      x1, x20
00688FA3C  bl       #0x382bcb8 ; 
00688FA40  b        #0x688fa54 ; 
00688FA44  ldr      x8, [x2, #0x60]
00688FA48  mov      x0, x19
00688FA4C  mov      x1, x20
00688FA50  blr      x8
00688FA54  mov      x0, x19
00688FA58  mov      x1, xzr
00688FA5C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
00688FA60  adrp     x21, #0x959c000
00688FA64  ldrb     w8, [x21, #0x45d]
00688FA68  mov      x20, x0
00688FA6C  cbnz     w8, #0x688fa84
00688FA70  adrp     x0, #0x8f25000
00688FA74  ldr      x0, [x0, #0x648]
00688FA78  bl       #0x382bd14 ; 
00688FA7C  mov      w8, #1
00688FA80  strb     w8, [x21, #0x45d]
00688FA84  adrp     x8, #0x8f25000
00688FA88  ldr      x8, [x8, #0x648]
00688FA8C  ldr      x2, [x8]
00688FA90  ldrb     w8, [x2, #0x53]
00688FA94  tbnz     w8, #5, #0x688faac
00688FA98  str      x20, [x19, #0x58]!
00688FA9C  mov      x0, x19
00688FAA0  mov      x1, x20
00688FAA4  bl       #0x382bcb8 ; 
00688FAA8  b        #0x688fabc ; 
00688FAAC  ldr      x8, [x2, #0x60]
00688FAB0  mov      x0, x19
00688FAB4  mov      x1, x20
00688FAB8  blr      x8
00688FABC  ldp      x20, x19, [sp, #0x20]
00688FAC0  ldp      x30, x21, [sp, #0x10]
00688FAC4  mov      w0, #1
00688FAC8  ldr      d8, [sp], #0x30
00688FACC  ret      

