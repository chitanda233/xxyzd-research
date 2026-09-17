; LocalModels.Bean.EventFishing_fishUnlock$$readImpl
; RVA 0x6A76E3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A76E3C  stp      x30, x21, [sp, #-0x20]!
006A76E40  stp      x20, x19, [sp, #0x10]
006A76E44  adrp     x20, #0x959d000
006A76E48  adrp     x21, #0x8f37000
006A76E4C  ldrb     w8, [x20, #0xe46]
006A76E50  ldr      x21, [x21, #0xab8]
006A76E54  mov      x19, x0
006A76E58  tbnz     w8, #0, #0x6a76e70
006A76E5C  adrp     x0, #0x8f37000
006A76E60  ldr      x0, [x0, #0xab8]
006A76E64  bl       #0x382bd14 ; 
006A76E68  mov      w8, #1
006A76E6C  strb     w8, [x20, #0xe46]
006A76E70  ldr      x1, [x21]
006A76E74  ldrb     w8, [x1, #0x53]
006A76E78  tbnz     w8, #5, #0x6a76ec8
006A76E7C  mov      x0, x19
006A76E80  mov      x1, xzr
006A76E84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A76E88  adrp     x21, #0x959e000
006A76E8C  ldrb     w8, [x21, #0x498]
006A76E90  mov      w20, w0
006A76E94  cbnz     w8, #0x6a76eac
006A76E98  adrp     x0, #0x8f37000
006A76E9C  ldr      x0, [x0, #0xa60]
006A76EA0  bl       #0x382bd14 ; 
006A76EA4  mov      w8, #1
006A76EA8  strb     w8, [x21, #0x498]
006A76EAC  adrp     x8, #0x8f37000
006A76EB0  ldr      x8, [x8, #0xa60]
006A76EB4  ldr      x2, [x8]
006A76EB8  ldrb     w8, [x2, #0x53]
006A76EBC  tbnz     w8, #5, #0x6a76edc
006A76EC0  str      w20, [x19, #0x20]
006A76EC4  b        #0x6a76eec ; 
006A76EC8  ldr      x2, [x1, #0x60]
006A76ECC  mov      x0, x19
006A76ED0  ldp      x20, x19, [sp, #0x10]
006A76ED4  ldp      x30, x21, [sp], #0x20
006A76ED8  br       x2
006A76EDC  ldr      x8, [x2, #0x60]
006A76EE0  mov      x0, x19
006A76EE4  mov      w1, w20
006A76EE8  blr      x8
006A76EEC  mov      x0, x19
006A76EF0  mov      x1, xzr
006A76EF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A76EF8  adrp     x21, #0x959e000
006A76EFC  ldrb     w8, [x21, #0x499]
006A76F00  mov      w20, w0
006A76F04  cbnz     w8, #0x6a76f1c
006A76F08  adrp     x0, #0x8f37000
006A76F0C  ldr      x0, [x0, #0xa70]
006A76F10  bl       #0x382bd14 ; 
006A76F14  mov      w8, #1
006A76F18  strb     w8, [x21, #0x499]
006A76F1C  adrp     x8, #0x8f37000
006A76F20  ldr      x8, [x8, #0xa70]
006A76F24  ldr      x2, [x8]
006A76F28  ldrb     w8, [x2, #0x53]
006A76F2C  tbnz     w8, #5, #0x6a76f38
006A76F30  str      w20, [x19, #0x24]
006A76F34  b        #0x6a76f48 ; 
006A76F38  ldr      x8, [x2, #0x60]
006A76F3C  mov      x0, x19
006A76F40  mov      w1, w20
006A76F44  blr      x8
006A76F48  mov      x0, x19
006A76F4C  mov      x1, xzr
006A76F50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A76F54  adrp     x21, #0x959e000
006A76F58  ldrb     w8, [x21, #0x49a]
006A76F5C  mov      w20, w0
006A76F60  cbnz     w8, #0x6a76f78
006A76F64  adrp     x0, #0x8f37000
006A76F68  ldr      x0, [x0, #0xa80]
006A76F6C  bl       #0x382bd14 ; 
006A76F70  mov      w8, #1
006A76F74  strb     w8, [x21, #0x49a]
006A76F78  adrp     x8, #0x8f37000
006A76F7C  ldr      x8, [x8, #0xa80]
006A76F80  ldr      x2, [x8]
006A76F84  ldrb     w8, [x2, #0x53]
006A76F88  tbnz     w8, #5, #0x6a76f94
006A76F8C  str      w20, [x19, #0x28]
006A76F90  b        #0x6a76fa4 ; 
006A76F94  ldr      x8, [x2, #0x60]
006A76F98  mov      x0, x19
006A76F9C  mov      w1, w20
006A76FA0  blr      x8
006A76FA4  mov      x0, x19
006A76FA8  mov      x1, xzr
006A76FAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A76FB0  adrp     x21, #0x959e000
006A76FB4  ldrb     w8, [x21, #0x49b]
006A76FB8  mov      w20, w0
006A76FBC  cbnz     w8, #0x6a76fd4
006A76FC0  adrp     x0, #0x8f37000
006A76FC4  ldr      x0, [x0, #0xa90]
006A76FC8  bl       #0x382bd14 ; 
006A76FCC  mov      w8, #1
006A76FD0  strb     w8, [x21, #0x49b]
006A76FD4  adrp     x8, #0x8f37000
006A76FD8  ldr      x8, [x8, #0xa90]
006A76FDC  ldr      x2, [x8]
006A76FE0  ldrb     w8, [x2, #0x53]
006A76FE4  tbnz     w8, #5, #0x6a76ff0
006A76FE8  str      w20, [x19, #0x2c]
006A76FEC  b        #0x6a77000 ; 
006A76FF0  ldr      x8, [x2, #0x60]
006A76FF4  mov      x0, x19
006A76FF8  mov      w1, w20
006A76FFC  blr      x8
006A77000  mov      x0, x19
006A77004  mov      x1, xzr
006A77008  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7700C  adrp     x21, #0x959e000
006A77010  ldrb     w8, [x21, #0x49c]
006A77014  mov      w20, w0
006A77018  cbnz     w8, #0x6a77030
006A7701C  adrp     x0, #0x8f37000
006A77020  ldr      x0, [x0, #0xaa0]
006A77024  bl       #0x382bd14 ; 
006A77028  mov      w8, #1
006A7702C  strb     w8, [x21, #0x49c]
006A77030  adrp     x8, #0x8f37000
006A77034  ldr      x8, [x8, #0xaa0]
006A77038  ldr      x2, [x8]
006A7703C  ldrb     w8, [x2, #0x53]
006A77040  tbnz     w8, #5, #0x6a7704c
006A77044  str      w20, [x19, #0x30]
006A77048  b        #0x6a7705c ; 
006A7704C  ldr      x8, [x2, #0x60]
006A77050  mov      x0, x19
006A77054  mov      w1, w20
006A77058  blr      x8
006A7705C  mov      x0, x19
006A77060  mov      x1, xzr
006A77064  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A77068  adrp     x21, #0x959e000
006A7706C  ldrb     w8, [x21, #0x49d]
006A77070  mov      x20, x0
006A77074  cbnz     w8, #0x6a7708c
006A77078  adrp     x0, #0x8f37000
006A7707C  ldr      x0, [x0, #0xab0]
006A77080  bl       #0x382bd14 ; 
006A77084  mov      w8, #1
006A77088  strb     w8, [x21, #0x49d]
006A7708C  adrp     x8, #0x8f37000
006A77090  ldr      x8, [x8, #0xab0]
006A77094  ldr      x2, [x8]
006A77098  ldrb     w8, [x2, #0x53]
006A7709C  tbnz     w8, #5, #0x6a770b4
006A770A0  str      x20, [x19, #0x38]!
006A770A4  mov      x0, x19
006A770A8  mov      x1, x20
006A770AC  bl       #0x382bcb8 ; 
006A770B0  b        #0x6a770c4 ; 
006A770B4  ldr      x8, [x2, #0x60]
006A770B8  mov      x0, x19
006A770BC  mov      x1, x20
006A770C0  blr      x8
006A770C4  ldp      x20, x19, [sp, #0x10]
006A770C8  mov      w0, #1
006A770CC  ldp      x30, x21, [sp], #0x20
006A770D0  ret      

