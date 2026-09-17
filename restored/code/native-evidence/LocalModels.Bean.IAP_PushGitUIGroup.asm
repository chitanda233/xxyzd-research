; LocalModels.Bean.IAP_PushGitUIGroup$$readImpl
; RVA 0x6AA8E30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA8E30  stp      x30, x21, [sp, #-0x20]!
006AA8E34  stp      x20, x19, [sp, #0x10]
006AA8E38  adrp     x20, #0x959e000
006AA8E3C  adrp     x21, #0x8f3a000
006AA8E40  ldrb     w8, [x20, #0x706]
006AA8E44  ldr      x21, [x21, #0xe8]
006AA8E48  mov      x19, x0
006AA8E4C  tbnz     w8, #0, #0x6aa8e64
006AA8E50  adrp     x0, #0x8f3a000
006AA8E54  ldr      x0, [x0, #0xe8]
006AA8E58  bl       #0x382bd14 ; 
006AA8E5C  mov      w8, #1
006AA8E60  strb     w8, [x20, #0x706]
006AA8E64  ldr      x1, [x21]
006AA8E68  ldrb     w8, [x1, #0x53]
006AA8E6C  tbnz     w8, #5, #0x6aa8ebc
006AA8E70  mov      x0, x19
006AA8E74  mov      x1, xzr
006AA8E78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA8E7C  adrp     x21, #0x959e000
006AA8E80  ldrb     w8, [x21, #0xf18]
006AA8E84  mov      w20, w0
006AA8E88  cbnz     w8, #0x6aa8ea0
006AA8E8C  adrp     x0, #0x8f3a000
006AA8E90  ldr      x0, [x0, #0x70]
006AA8E94  bl       #0x382bd14 ; 
006AA8E98  mov      w8, #1
006AA8E9C  strb     w8, [x21, #0xf18]
006AA8EA0  adrp     x8, #0x8f3a000
006AA8EA4  ldr      x8, [x8, #0x70]
006AA8EA8  ldr      x2, [x8]
006AA8EAC  ldrb     w8, [x2, #0x53]
006AA8EB0  tbnz     w8, #5, #0x6aa8ed0
006AA8EB4  str      w20, [x19, #0x20]
006AA8EB8  b        #0x6aa8ee0 ; 
006AA8EBC  ldr      x2, [x1, #0x60]
006AA8EC0  mov      x0, x19
006AA8EC4  ldp      x20, x19, [sp, #0x10]
006AA8EC8  ldp      x30, x21, [sp], #0x20
006AA8ECC  br       x2
006AA8ED0  ldr      x8, [x2, #0x60]
006AA8ED4  mov      x0, x19
006AA8ED8  mov      w1, w20
006AA8EDC  blr      x8
006AA8EE0  mov      x0, x19
006AA8EE4  mov      x1, xzr
006AA8EE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA8EEC  adrp     x21, #0x959e000
006AA8EF0  ldrb     w8, [x21, #0xf19]
006AA8EF4  mov      w20, w0
006AA8EF8  cbnz     w8, #0x6aa8f10
006AA8EFC  adrp     x0, #0x8f3a000
006AA8F00  ldr      x0, [x0, #0x80]
006AA8F04  bl       #0x382bd14 ; 
006AA8F08  mov      w8, #1
006AA8F0C  strb     w8, [x21, #0xf19]
006AA8F10  adrp     x8, #0x8f3a000
006AA8F14  ldr      x8, [x8, #0x80]
006AA8F18  ldr      x2, [x8]
006AA8F1C  ldrb     w8, [x2, #0x53]
006AA8F20  tbnz     w8, #5, #0x6aa8f2c
006AA8F24  str      w20, [x19, #0x24]
006AA8F28  b        #0x6aa8f3c ; 
006AA8F2C  ldr      x8, [x2, #0x60]
006AA8F30  mov      x0, x19
006AA8F34  mov      w1, w20
006AA8F38  blr      x8
006AA8F3C  mov      x0, x19
006AA8F40  mov      x1, xzr
006AA8F44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA8F48  adrp     x21, #0x959e000
006AA8F4C  ldrb     w8, [x21, #0xf1a]
006AA8F50  mov      x20, x0
006AA8F54  cbnz     w8, #0x6aa8f6c
006AA8F58  adrp     x0, #0x8f3a000
006AA8F5C  ldr      x0, [x0, #0x90]
006AA8F60  bl       #0x382bd14 ; 
006AA8F64  mov      w8, #1
006AA8F68  strb     w8, [x21, #0xf1a]
006AA8F6C  adrp     x8, #0x8f3a000
006AA8F70  ldr      x8, [x8, #0x90]
006AA8F74  ldr      x2, [x8]
006AA8F78  ldrb     w8, [x2, #0x53]
006AA8F7C  tbnz     w8, #5, #0x6aa8f94
006AA8F80  mov      x0, x19
006AA8F84  str      x20, [x0, #0x28]!
006AA8F88  mov      x1, x20
006AA8F8C  bl       #0x382bcb8 ; 
006AA8F90  b        #0x6aa8fa4 ; 
006AA8F94  ldr      x8, [x2, #0x60]
006AA8F98  mov      x0, x19
006AA8F9C  mov      x1, x20
006AA8FA0  blr      x8
006AA8FA4  mov      x0, x19
006AA8FA8  mov      x1, xzr
006AA8FAC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA8FB0  adrp     x21, #0x959e000
006AA8FB4  ldrb     w8, [x21, #0xf1b]
006AA8FB8  mov      x20, x0
006AA8FBC  cbnz     w8, #0x6aa8fd4
006AA8FC0  adrp     x0, #0x8f3a000
006AA8FC4  ldr      x0, [x0, #0xa0]
006AA8FC8  bl       #0x382bd14 ; 
006AA8FCC  mov      w8, #1
006AA8FD0  strb     w8, [x21, #0xf1b]
006AA8FD4  adrp     x8, #0x8f3a000
006AA8FD8  ldr      x8, [x8, #0xa0]
006AA8FDC  ldr      x2, [x8]
006AA8FE0  ldrb     w8, [x2, #0x53]
006AA8FE4  tbnz     w8, #5, #0x6aa8ffc
006AA8FE8  mov      x0, x19
006AA8FEC  str      x20, [x0, #0x30]!
006AA8FF0  mov      x1, x20
006AA8FF4  bl       #0x382bcb8 ; 
006AA8FF8  b        #0x6aa900c ; 
006AA8FFC  ldr      x8, [x2, #0x60]
006AA9000  mov      x0, x19
006AA9004  mov      x1, x20
006AA9008  blr      x8
006AA900C  mov      x0, x19
006AA9010  mov      x1, xzr
006AA9014  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA9018  adrp     x21, #0x959e000
006AA901C  ldrb     w8, [x21, #0xf1c]
006AA9020  mov      w20, w0
006AA9024  cbnz     w8, #0x6aa903c
006AA9028  adrp     x0, #0x8f3a000
006AA902C  ldr      x0, [x0, #0xb0]
006AA9030  bl       #0x382bd14 ; 
006AA9034  mov      w8, #1
006AA9038  strb     w8, [x21, #0xf1c]
006AA903C  adrp     x8, #0x8f3a000
006AA9040  ldr      x8, [x8, #0xb0]
006AA9044  ldr      x2, [x8]
006AA9048  ldrb     w8, [x2, #0x53]
006AA904C  tbnz     w8, #5, #0x6aa9058
006AA9050  str      w20, [x19, #0x38]
006AA9054  b        #0x6aa9068 ; 
006AA9058  ldr      x8, [x2, #0x60]
006AA905C  mov      x0, x19
006AA9060  mov      w1, w20
006AA9064  blr      x8
006AA9068  mov      x0, x19
006AA906C  mov      x1, xzr
006AA9070  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA9074  adrp     x21, #0x959e000
006AA9078  ldrb     w8, [x21, #0xf1d]
006AA907C  mov      x20, x0
006AA9080  cbnz     w8, #0x6aa9098
006AA9084  adrp     x0, #0x8f3a000
006AA9088  ldr      x0, [x0, #0xc0]
006AA908C  bl       #0x382bd14 ; 
006AA9090  mov      w8, #1
006AA9094  strb     w8, [x21, #0xf1d]
006AA9098  adrp     x8, #0x8f3a000
006AA909C  ldr      x8, [x8, #0xc0]
006AA90A0  ldr      x2, [x8]
006AA90A4  ldrb     w8, [x2, #0x53]
006AA90A8  tbnz     w8, #5, #0x6aa90c0
006AA90AC  mov      x0, x19
006AA90B0  str      x20, [x0, #0x40]!
006AA90B4  mov      x1, x20
006AA90B8  bl       #0x382bcb8 ; 
006AA90BC  b        #0x6aa90d0 ; 
006AA90C0  ldr      x8, [x2, #0x60]
006AA90C4  mov      x0, x19
006AA90C8  mov      x1, x20
006AA90CC  blr      x8
006AA90D0  mov      x0, x19
006AA90D4  mov      x1, xzr
006AA90D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA90DC  adrp     x21, #0x959e000
006AA90E0  ldrb     w8, [x21, #0xf1e]
006AA90E4  mov      w20, w0
006AA90E8  cbnz     w8, #0x6aa9100
006AA90EC  adrp     x0, #0x8f3a000
006AA90F0  ldr      x0, [x0, #0xd0]
006AA90F4  bl       #0x382bd14 ; 
006AA90F8  mov      w8, #1
006AA90FC  strb     w8, [x21, #0xf1e]
006AA9100  adrp     x8, #0x8f3a000
006AA9104  ldr      x8, [x8, #0xd0]
006AA9108  ldr      x2, [x8]
006AA910C  ldrb     w8, [x2, #0x53]
006AA9110  tbnz     w8, #5, #0x6aa911c
006AA9114  str      w20, [x19, #0x48]
006AA9118  b        #0x6aa912c ; 
006AA911C  ldr      x8, [x2, #0x60]
006AA9120  mov      x0, x19
006AA9124  mov      w1, w20
006AA9128  blr      x8
006AA912C  mov      x0, x19
006AA9130  mov      x1, xzr
006AA9134  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AA9138  adrp     x21, #0x959e000
006AA913C  ldrb     w8, [x21, #0xf1f]
006AA9140  mov      x20, x0
006AA9144  cbnz     w8, #0x6aa915c
006AA9148  adrp     x0, #0x8f3a000
006AA914C  ldr      x0, [x0, #0xe0]
006AA9150  bl       #0x382bd14 ; 
006AA9154  mov      w8, #1
006AA9158  strb     w8, [x21, #0xf1f]
006AA915C  adrp     x8, #0x8f3a000
006AA9160  ldr      x8, [x8, #0xe0]
006AA9164  ldr      x2, [x8]
006AA9168  ldrb     w8, [x2, #0x53]
006AA916C  tbnz     w8, #5, #0x6aa9184
006AA9170  str      x20, [x19, #0x50]!
006AA9174  mov      x0, x19
006AA9178  mov      x1, x20
006AA917C  bl       #0x382bcb8 ; 
006AA9180  b        #0x6aa9194 ; 
006AA9184  ldr      x8, [x2, #0x60]
006AA9188  mov      x0, x19
006AA918C  mov      x1, x20
006AA9190  blr      x8
006AA9194  ldp      x20, x19, [sp, #0x10]
006AA9198  mov      w0, #1
006AA919C  ldp      x30, x21, [sp], #0x20
006AA91A0  ret      

