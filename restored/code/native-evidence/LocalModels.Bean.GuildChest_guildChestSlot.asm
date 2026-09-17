; LocalModels.Bean.GuildChest_guildChestSlot$$readImpl
; RVA 0x6A89F28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A89F28  stp      x30, x21, [sp, #-0x20]!
006A89F2C  stp      x20, x19, [sp, #0x10]
006A89F30  adrp     x20, #0x959e000
006A89F34  adrp     x21, #0x8f38000
006A89F38  ldrb     w8, [x20, #0x44]
006A89F3C  ldr      x21, [x21, #0x950]
006A89F40  mov      x19, x0
006A89F44  tbnz     w8, #0, #0x6a89f5c
006A89F48  adrp     x0, #0x8f38000
006A89F4C  ldr      x0, [x0, #0x950]
006A89F50  bl       #0x382bd14 ; 
006A89F54  mov      w8, #1
006A89F58  strb     w8, [x20, #0x44]
006A89F5C  ldr      x1, [x21]
006A89F60  ldrb     w8, [x1, #0x53]
006A89F64  tbnz     w8, #5, #0x6a89fb4
006A89F68  mov      x0, x19
006A89F6C  mov      x1, xzr
006A89F70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A89F74  adrp     x21, #0x959e000
006A89F78  ldrb     w8, [x21, #0x564]
006A89F7C  mov      w20, w0
006A89F80  cbnz     w8, #0x6a89f98
006A89F84  adrp     x0, #0x8f38000
006A89F88  ldr      x0, [x0, #0x928]
006A89F8C  bl       #0x382bd14 ; 
006A89F90  mov      w8, #1
006A89F94  strb     w8, [x21, #0x564]
006A89F98  adrp     x8, #0x8f38000
006A89F9C  ldr      x8, [x8, #0x928]
006A89FA0  ldr      x2, [x8]
006A89FA4  ldrb     w8, [x2, #0x53]
006A89FA8  tbnz     w8, #5, #0x6a89fc8
006A89FAC  str      w20, [x19, #0x20]
006A89FB0  b        #0x6a89fd8 ; 
006A89FB4  ldr      x2, [x1, #0x60]
006A89FB8  mov      x0, x19
006A89FBC  ldp      x20, x19, [sp, #0x10]
006A89FC0  ldp      x30, x21, [sp], #0x20
006A89FC4  br       x2
006A89FC8  ldr      x8, [x2, #0x60]
006A89FCC  mov      x0, x19
006A89FD0  mov      w1, w20
006A89FD4  blr      x8
006A89FD8  mov      x0, x19
006A89FDC  mov      x1, xzr
006A89FE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A89FE4  adrp     x21, #0x959e000
006A89FE8  ldrb     w8, [x21, #0x565]
006A89FEC  mov      w20, w0
006A89FF0  cbnz     w8, #0x6a8a008
006A89FF4  adrp     x0, #0x8f38000
006A89FF8  ldr      x0, [x0, #0x938]
006A89FFC  bl       #0x382bd14 ; 
006A8A000  mov      w8, #1
006A8A004  strb     w8, [x21, #0x565]
006A8A008  adrp     x8, #0x8f38000
006A8A00C  ldr      x8, [x8, #0x938]
006A8A010  ldr      x2, [x8]
006A8A014  ldrb     w8, [x2, #0x53]
006A8A018  tbnz     w8, #5, #0x6a8a024
006A8A01C  str      w20, [x19, #0x24]
006A8A020  b        #0x6a8a034 ; 
006A8A024  ldr      x8, [x2, #0x60]
006A8A028  mov      x0, x19
006A8A02C  mov      w1, w20
006A8A030  blr      x8
006A8A034  mov      x0, x19
006A8A038  mov      x1, xzr
006A8A03C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8A040  adrp     x21, #0x959e000
006A8A044  ldrb     w8, [x21, #0x566]
006A8A048  mov      x20, x0
006A8A04C  cbnz     w8, #0x6a8a064
006A8A050  adrp     x0, #0x8f38000
006A8A054  ldr      x0, [x0, #0x948]
006A8A058  bl       #0x382bd14 ; 
006A8A05C  mov      w8, #1
006A8A060  strb     w8, [x21, #0x566]
006A8A064  adrp     x8, #0x8f38000
006A8A068  ldr      x8, [x8, #0x948]
006A8A06C  ldr      x2, [x8]
006A8A070  ldrb     w8, [x2, #0x53]
006A8A074  tbnz     w8, #5, #0x6a8a08c
006A8A078  str      x20, [x19, #0x28]!
006A8A07C  mov      x0, x19
006A8A080  mov      x1, x20
006A8A084  bl       #0x382bcb8 ; 
006A8A088  b        #0x6a8a09c ; 
006A8A08C  ldr      x8, [x2, #0x60]
006A8A090  mov      x0, x19
006A8A094  mov      x1, x20
006A8A098  blr      x8
006A8A09C  ldp      x20, x19, [sp, #0x10]
006A8A0A0  mov      w0, #1
006A8A0A4  ldp      x30, x21, [sp], #0x20
006A8A0A8  ret      

