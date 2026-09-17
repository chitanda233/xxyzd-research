; LocalModels.Bean.Detail_Detail$$readImpl
; RVA 0x6A57D78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A57D78  stp      x30, x21, [sp, #-0x20]!
006A57D7C  stp      x20, x19, [sp, #0x10]
006A57D80  adrp     x20, #0x959d000
006A57D84  adrp     x21, #0x8f36000
006A57D88  ldrb     w8, [x20, #0xb15]
006A57D8C  ldr      x21, [x21, #0x378]
006A57D90  mov      x19, x0
006A57D94  tbnz     w8, #0, #0x6a57dac
006A57D98  adrp     x0, #0x8f36000
006A57D9C  ldr      x0, [x0, #0x378]
006A57DA0  bl       #0x382bd14 ; 
006A57DA4  mov      w8, #1
006A57DA8  strb     w8, [x20, #0xb15]
006A57DAC  ldr      x1, [x21]
006A57DB0  ldrb     w8, [x1, #0x53]
006A57DB4  tbnz     w8, #5, #0x6a57e04
006A57DB8  mov      x0, x19
006A57DBC  mov      x1, xzr
006A57DC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A57DC4  adrp     x21, #0x959e000
006A57DC8  ldrb     w8, [x21, #0x33d]
006A57DCC  mov      w20, w0
006A57DD0  cbnz     w8, #0x6a57de8
006A57DD4  adrp     x0, #0x8f36000
006A57DD8  ldr      x0, [x0, #0x350]
006A57DDC  bl       #0x382bd14 ; 
006A57DE0  mov      w8, #1
006A57DE4  strb     w8, [x21, #0x33d]
006A57DE8  adrp     x8, #0x8f36000
006A57DEC  ldr      x8, [x8, #0x350]
006A57DF0  ldr      x2, [x8]
006A57DF4  ldrb     w8, [x2, #0x53]
006A57DF8  tbnz     w8, #5, #0x6a57e18
006A57DFC  str      w20, [x19, #0x20]
006A57E00  b        #0x6a57e28 ; 
006A57E04  ldr      x2, [x1, #0x60]
006A57E08  mov      x0, x19
006A57E0C  ldp      x20, x19, [sp, #0x10]
006A57E10  ldp      x30, x21, [sp], #0x20
006A57E14  br       x2
006A57E18  ldr      x8, [x2, #0x60]
006A57E1C  mov      x0, x19
006A57E20  mov      w1, w20
006A57E24  blr      x8
006A57E28  mov      x0, x19
006A57E2C  mov      x1, xzr
006A57E30  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A57E34  adrp     x21, #0x959e000
006A57E38  ldrb     w8, [x21, #0x33e]
006A57E3C  mov      x20, x0
006A57E40  cbnz     w8, #0x6a57e58
006A57E44  adrp     x0, #0x8f36000
006A57E48  ldr      x0, [x0, #0x360]
006A57E4C  bl       #0x382bd14 ; 
006A57E50  mov      w8, #1
006A57E54  strb     w8, [x21, #0x33e]
006A57E58  adrp     x8, #0x8f36000
006A57E5C  ldr      x8, [x8, #0x360]
006A57E60  ldr      x2, [x8]
006A57E64  ldrb     w8, [x2, #0x53]
006A57E68  tbnz     w8, #5, #0x6a57e80
006A57E6C  mov      x0, x19
006A57E70  str      x20, [x0, #0x28]!
006A57E74  mov      x1, x20
006A57E78  bl       #0x382bcb8 ; 
006A57E7C  b        #0x6a57e90 ; 
006A57E80  ldr      x8, [x2, #0x60]
006A57E84  mov      x0, x19
006A57E88  mov      x1, x20
006A57E8C  blr      x8
006A57E90  mov      x0, x19
006A57E94  mov      x1, xzr
006A57E98  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A57E9C  adrp     x21, #0x959e000
006A57EA0  ldrb     w8, [x21, #0x33f]
006A57EA4  mov      x20, x0
006A57EA8  cbnz     w8, #0x6a57ec0
006A57EAC  adrp     x0, #0x8f36000
006A57EB0  ldr      x0, [x0, #0x370]
006A57EB4  bl       #0x382bd14 ; 
006A57EB8  mov      w8, #1
006A57EBC  strb     w8, [x21, #0x33f]
006A57EC0  adrp     x8, #0x8f36000
006A57EC4  ldr      x8, [x8, #0x370]
006A57EC8  ldr      x2, [x8]
006A57ECC  ldrb     w8, [x2, #0x53]
006A57ED0  tbnz     w8, #5, #0x6a57ee8
006A57ED4  str      x20, [x19, #0x30]!
006A57ED8  mov      x0, x19
006A57EDC  mov      x1, x20
006A57EE0  bl       #0x382bcb8 ; 
006A57EE4  b        #0x6a57ef8 ; 
006A57EE8  ldr      x8, [x2, #0x60]
006A57EEC  mov      x0, x19
006A57EF0  mov      x1, x20
006A57EF4  blr      x8
006A57EF8  ldp      x20, x19, [sp, #0x10]
006A57EFC  mov      w0, #1
006A57F00  ldp      x30, x21, [sp], #0x20
006A57F04  ret      

