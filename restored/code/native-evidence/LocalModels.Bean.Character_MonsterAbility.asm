; LocalModels.Bean.Character_MonsterAbility$$readImpl
; RVA 0x68C8EA4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C8EA4  stp      x30, x21, [sp, #-0x20]!
0068C8EA8  stp      x20, x19, [sp, #0x10]
0068C8EAC  adrp     x20, #0x959c000
0068C8EB0  adrp     x21, #0x8f28000
0068C8EB4  ldrb     w8, [x20, #0x2e6]
0068C8EB8  ldr      x21, [x21, #0x118]
0068C8EBC  mov      x19, x0
0068C8EC0  tbnz     w8, #0, #0x68c8ed8
0068C8EC4  adrp     x0, #0x8f28000
0068C8EC8  ldr      x0, [x0, #0x118]
0068C8ECC  bl       #0x382bd14 ; 
0068C8ED0  mov      w8, #1
0068C8ED4  strb     w8, [x20, #0x2e6]
0068C8ED8  ldr      x1, [x21]
0068C8EDC  ldrb     w8, [x1, #0x53]
0068C8EE0  tbnz     w8, #5, #0x68c8f30
0068C8EE4  mov      x0, x19
0068C8EE8  mov      x1, xzr
0068C8EEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C8EF0  adrp     x21, #0x959c000
0068C8EF4  ldrb     w8, [x21, #0x705]
0068C8EF8  mov      w20, w0
0068C8EFC  cbnz     w8, #0x68c8f14
0068C8F00  adrp     x0, #0x8f28000
0068C8F04  ldr      x0, [x0, #0xe0]
0068C8F08  bl       #0x382bd14 ; 
0068C8F0C  mov      w8, #1
0068C8F10  strb     w8, [x21, #0x705]
0068C8F14  adrp     x8, #0x8f28000
0068C8F18  ldr      x8, [x8, #0xe0]
0068C8F1C  ldr      x2, [x8]
0068C8F20  ldrb     w8, [x2, #0x53]
0068C8F24  tbnz     w8, #5, #0x68c8f44
0068C8F28  str      w20, [x19, #0x20]
0068C8F2C  b        #0x68c8f54 ; 
0068C8F30  ldr      x2, [x1, #0x60]
0068C8F34  mov      x0, x19
0068C8F38  ldp      x20, x19, [sp, #0x10]
0068C8F3C  ldp      x30, x21, [sp], #0x20
0068C8F40  br       x2
0068C8F44  ldr      x8, [x2, #0x60]
0068C8F48  mov      x0, x19
0068C8F4C  mov      w1, w20
0068C8F50  blr      x8
0068C8F54  mov      x0, x19
0068C8F58  mov      x1, xzr
0068C8F5C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C8F60  adrp     x21, #0x959c000
0068C8F64  ldrb     w8, [x21, #0x706]
0068C8F68  mov      x20, x0
0068C8F6C  cbnz     w8, #0x68c8f84
0068C8F70  adrp     x0, #0x8f28000
0068C8F74  ldr      x0, [x0, #0xf0]
0068C8F78  bl       #0x382bd14 ; 
0068C8F7C  mov      w8, #1
0068C8F80  strb     w8, [x21, #0x706]
0068C8F84  adrp     x8, #0x8f28000
0068C8F88  ldr      x8, [x8, #0xf0]
0068C8F8C  ldr      x2, [x8]
0068C8F90  ldrb     w8, [x2, #0x53]
0068C8F94  tbnz     w8, #5, #0x68c8fac
0068C8F98  mov      x0, x19
0068C8F9C  str      x20, [x0, #0x28]!
0068C8FA0  mov      x1, x20
0068C8FA4  bl       #0x382bcb8 ; 
0068C8FA8  b        #0x68c8fbc ; 
0068C8FAC  ldr      x8, [x2, #0x60]
0068C8FB0  mov      x0, x19
0068C8FB4  mov      x1, x20
0068C8FB8  blr      x8
0068C8FBC  mov      x0, x19
0068C8FC0  mov      x1, xzr
0068C8FC4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C8FC8  adrp     x21, #0x959c000
0068C8FCC  ldrb     w8, [x21, #0x707]
0068C8FD0  mov      x20, x0
0068C8FD4  cbnz     w8, #0x68c8fec
0068C8FD8  adrp     x0, #0x8f28000
0068C8FDC  ldr      x0, [x0, #0x100]
0068C8FE0  bl       #0x382bd14 ; 
0068C8FE4  mov      w8, #1
0068C8FE8  strb     w8, [x21, #0x707]
0068C8FEC  adrp     x8, #0x8f28000
0068C8FF0  ldr      x8, [x8, #0x100]
0068C8FF4  ldr      x2, [x8]
0068C8FF8  ldrb     w8, [x2, #0x53]
0068C8FFC  tbnz     w8, #5, #0x68c9014
0068C9000  mov      x0, x19
0068C9004  str      x20, [x0, #0x30]!
0068C9008  mov      x1, x20
0068C900C  bl       #0x382bcb8 ; 
0068C9010  b        #0x68c9024 ; 
0068C9014  ldr      x8, [x2, #0x60]
0068C9018  mov      x0, x19
0068C901C  mov      x1, x20
0068C9020  blr      x8
0068C9024  mov      x0, x19
0068C9028  mov      x1, xzr
0068C902C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C9030  adrp     x21, #0x959c000
0068C9034  ldrb     w8, [x21, #0x708]
0068C9038  mov      x20, x0
0068C903C  cbnz     w8, #0x68c9054
0068C9040  adrp     x0, #0x8f28000
0068C9044  ldr      x0, [x0, #0x110]
0068C9048  bl       #0x382bd14 ; 
0068C904C  mov      w8, #1
0068C9050  strb     w8, [x21, #0x708]
0068C9054  adrp     x8, #0x8f28000
0068C9058  ldr      x8, [x8, #0x110]
0068C905C  ldr      x2, [x8]
0068C9060  ldrb     w8, [x2, #0x53]
0068C9064  tbnz     w8, #5, #0x68c907c
0068C9068  str      x20, [x19, #0x38]!
0068C906C  mov      x0, x19
0068C9070  mov      x1, x20
0068C9074  bl       #0x382bcb8 ; 
0068C9078  b        #0x68c908c ; 
0068C907C  ldr      x8, [x2, #0x60]
0068C9080  mov      x0, x19
0068C9084  mov      x1, x20
0068C9088  blr      x8
0068C908C  ldp      x20, x19, [sp, #0x10]
0068C9090  mov      w0, #1
0068C9094  ldp      x30, x21, [sp], #0x20
0068C9098  ret      

