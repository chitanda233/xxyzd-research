; LocalModels.Bean.GuildBOSS_guildBossAttr$$readImpl
; RVA 0x6A84F28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A84F28  stp      x30, x21, [sp, #-0x20]!
006A84F2C  stp      x20, x19, [sp, #0x10]
006A84F30  adrp     x20, #0x959d000
006A84F34  adrp     x21, #0x8f38000
006A84F38  ldrb     w8, [x20, #0xfbc]
006A84F3C  ldr      x21, [x21, #0x590]
006A84F40  mov      x19, x0
006A84F44  tbnz     w8, #0, #0x6a84f5c
006A84F48  adrp     x0, #0x8f38000
006A84F4C  ldr      x0, [x0, #0x590]
006A84F50  bl       #0x382bd14 ; 
006A84F54  mov      w8, #1
006A84F58  strb     w8, [x20, #0xfbc]
006A84F5C  ldr      x1, [x21]
006A84F60  ldrb     w8, [x1, #0x53]
006A84F64  tbnz     w8, #5, #0x6a84fb4
006A84F68  mov      x0, x19
006A84F6C  mov      x1, xzr
006A84F70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A84F74  adrp     x21, #0x959e000
006A84F78  ldrb     w8, [x21, #0x533]
006A84F7C  mov      w20, w0
006A84F80  cbnz     w8, #0x6a84f98
006A84F84  adrp     x0, #0x8f38000
006A84F88  ldr      x0, [x0, #0x578]
006A84F8C  bl       #0x382bd14 ; 
006A84F90  mov      w8, #1
006A84F94  strb     w8, [x21, #0x533]
006A84F98  adrp     x8, #0x8f38000
006A84F9C  ldr      x8, [x8, #0x578]
006A84FA0  ldr      x2, [x8]
006A84FA4  ldrb     w8, [x2, #0x53]
006A84FA8  tbnz     w8, #5, #0x6a84fc8
006A84FAC  str      w20, [x19, #0x20]
006A84FB0  b        #0x6a84fd8 ; 
006A84FB4  ldr      x2, [x1, #0x60]
006A84FB8  mov      x0, x19
006A84FBC  ldp      x20, x19, [sp, #0x10]
006A84FC0  ldp      x30, x21, [sp], #0x20
006A84FC4  br       x2
006A84FC8  ldr      x8, [x2, #0x60]
006A84FCC  mov      x0, x19
006A84FD0  mov      w1, w20
006A84FD4  blr      x8
006A84FD8  mov      x0, x19
006A84FDC  mov      x1, xzr
006A84FE0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A84FE4  adrp     x21, #0x959e000
006A84FE8  ldrb     w8, [x21, #0x534]
006A84FEC  mov      x20, x0
006A84FF0  cbnz     w8, #0x6a85008
006A84FF4  adrp     x0, #0x8f38000
006A84FF8  ldr      x0, [x0, #0x588]
006A84FFC  bl       #0x382bd14 ; 
006A85000  mov      w8, #1
006A85004  strb     w8, [x21, #0x534]
006A85008  adrp     x8, #0x8f38000
006A8500C  ldr      x8, [x8, #0x588]
006A85010  ldr      x2, [x8]
006A85014  ldrb     w8, [x2, #0x53]
006A85018  tbnz     w8, #5, #0x6a85030
006A8501C  str      x20, [x19, #0x28]!
006A85020  mov      x0, x19
006A85024  mov      x1, x20
006A85028  bl       #0x382bcb8 ; 
006A8502C  b        #0x6a85040 ; 
006A85030  ldr      x8, [x2, #0x60]
006A85034  mov      x0, x19
006A85038  mov      x1, x20
006A8503C  blr      x8
006A85040  ldp      x20, x19, [sp, #0x10]
006A85044  mov      w0, #1
006A85048  ldp      x30, x21, [sp], #0x20
006A8504C  ret      

