; LocalModels.Bean.EventFishing_fish$$readImpl
; RVA 0x6A71D60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A71D60  stp      x30, x21, [sp, #-0x20]!
006A71D64  stp      x20, x19, [sp, #0x10]
006A71D68  adrp     x20, #0x959d000
006A71D6C  adrp     x21, #0x8f37000
006A71D70  ldrb     w8, [x20, #0xdc6]
006A71D74  ldr      x21, [x21, #0x6e8]
006A71D78  mov      x19, x0
006A71D7C  tbnz     w8, #0, #0x6a71d94
006A71D80  adrp     x0, #0x8f37000
006A71D84  ldr      x0, [x0, #0x6e8]
006A71D88  bl       #0x382bd14 ; 
006A71D8C  mov      w8, #1
006A71D90  strb     w8, [x20, #0xdc6]
006A71D94  ldr      x1, [x21]
006A71D98  ldrb     w8, [x1, #0x53]
006A71D9C  tbnz     w8, #5, #0x6a71dec
006A71DA0  mov      x0, x19
006A71DA4  mov      x1, xzr
006A71DA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A71DAC  adrp     x21, #0x959e000
006A71DB0  ldrb     w8, [x21, #0x458]
006A71DB4  mov      w20, w0
006A71DB8  cbnz     w8, #0x6a71dd0
006A71DBC  adrp     x0, #0x8f37000
006A71DC0  ldr      x0, [x0, #0x600]
006A71DC4  bl       #0x382bd14 ; 
006A71DC8  mov      w8, #1
006A71DCC  strb     w8, [x21, #0x458]
006A71DD0  adrp     x8, #0x8f37000
006A71DD4  ldr      x8, [x8, #0x600]
006A71DD8  ldr      x2, [x8]
006A71DDC  ldrb     w8, [x2, #0x53]
006A71DE0  tbnz     w8, #5, #0x6a71e00
006A71DE4  str      w20, [x19, #0x20]
006A71DE8  b        #0x6a71e10 ; 
006A71DEC  ldr      x2, [x1, #0x60]
006A71DF0  mov      x0, x19
006A71DF4  ldp      x20, x19, [sp, #0x10]
006A71DF8  ldp      x30, x21, [sp], #0x20
006A71DFC  br       x2
006A71E00  ldr      x8, [x2, #0x60]
006A71E04  mov      x0, x19
006A71E08  mov      w1, w20
006A71E0C  blr      x8
006A71E10  mov      x0, x19
006A71E14  mov      x1, xzr
006A71E18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A71E1C  adrp     x21, #0x959e000
006A71E20  ldrb     w8, [x21, #0x459]
006A71E24  mov      w20, w0
006A71E28  cbnz     w8, #0x6a71e40
006A71E2C  adrp     x0, #0x8f37000
006A71E30  ldr      x0, [x0, #0x610]
006A71E34  bl       #0x382bd14 ; 
006A71E38  mov      w8, #1
006A71E3C  strb     w8, [x21, #0x459]
006A71E40  adrp     x8, #0x8f37000
006A71E44  ldr      x8, [x8, #0x610]
006A71E48  ldr      x2, [x8]
006A71E4C  ldrb     w8, [x2, #0x53]
006A71E50  tbnz     w8, #5, #0x6a71e5c
006A71E54  str      w20, [x19, #0x24]
006A71E58  b        #0x6a71e6c ; 
006A71E5C  ldr      x8, [x2, #0x60]
006A71E60  mov      x0, x19
006A71E64  mov      w1, w20
006A71E68  blr      x8
006A71E6C  mov      x0, x19
006A71E70  mov      x1, xzr
006A71E74  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A71E78  adrp     x21, #0x959e000
006A71E7C  ldrb     w8, [x21, #0x45a]
006A71E80  mov      w20, w0
006A71E84  cbnz     w8, #0x6a71e9c
006A71E88  adrp     x0, #0x8f37000
006A71E8C  ldr      x0, [x0, #0x620]
006A71E90  bl       #0x382bd14 ; 
006A71E94  mov      w8, #1
006A71E98  strb     w8, [x21, #0x45a]
006A71E9C  adrp     x8, #0x8f37000
006A71EA0  ldr      x8, [x8, #0x620]
006A71EA4  ldr      x2, [x8]
006A71EA8  ldrb     w8, [x2, #0x53]
006A71EAC  tbnz     w8, #5, #0x6a71eb8
006A71EB0  str      w20, [x19, #0x28]
006A71EB4  b        #0x6a71ec8 ; 
006A71EB8  ldr      x8, [x2, #0x60]
006A71EBC  mov      x0, x19
006A71EC0  mov      w1, w20
006A71EC4  blr      x8
006A71EC8  mov      x0, x19
006A71ECC  mov      x1, xzr
006A71ED0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A71ED4  adrp     x21, #0x959e000
006A71ED8  ldrb     w8, [x21, #0x45b]
006A71EDC  mov      w20, w0
006A71EE0  cbnz     w8, #0x6a71ef8
006A71EE4  adrp     x0, #0x8f37000
006A71EE8  ldr      x0, [x0, #0x630]
006A71EEC  bl       #0x382bd14 ; 
006A71EF0  mov      w8, #1
006A71EF4  strb     w8, [x21, #0x45b]
006A71EF8  adrp     x8, #0x8f37000
006A71EFC  ldr      x8, [x8, #0x630]
006A71F00  ldr      x2, [x8]
006A71F04  ldrb     w8, [x2, #0x53]
006A71F08  tbnz     w8, #5, #0x6a71f14
006A71F0C  str      w20, [x19, #0x2c]
006A71F10  b        #0x6a71f24 ; 
006A71F14  ldr      x8, [x2, #0x60]
006A71F18  mov      x0, x19
006A71F1C  mov      w1, w20
006A71F20  blr      x8
006A71F24  mov      x0, x19
006A71F28  mov      x1, xzr
006A71F2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A71F30  adrp     x21, #0x959e000
006A71F34  ldrb     w8, [x21, #0x45c]
006A71F38  mov      w20, w0
006A71F3C  cbnz     w8, #0x6a71f54
006A71F40  adrp     x0, #0x8f37000
006A71F44  ldr      x0, [x0, #0x640]
006A71F48  bl       #0x382bd14 ; 
006A71F4C  mov      w8, #1
006A71F50  strb     w8, [x21, #0x45c]
006A71F54  adrp     x8, #0x8f37000
006A71F58  ldr      x8, [x8, #0x640]
006A71F5C  ldr      x2, [x8]
006A71F60  ldrb     w8, [x2, #0x53]
006A71F64  tbnz     w8, #5, #0x6a71f70
006A71F68  str      w20, [x19, #0x30]
006A71F6C  b        #0x6a71f80 ; 
006A71F70  ldr      x8, [x2, #0x60]
006A71F74  mov      x0, x19
006A71F78  mov      w1, w20
006A71F7C  blr      x8
006A71F80  mov      x0, x19
006A71F84  mov      x1, xzr
006A71F88  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A71F8C  adrp     x21, #0x959e000
006A71F90  ldrb     w8, [x21, #0x45d]
006A71F94  mov      x20, x0
006A71F98  cbnz     w8, #0x6a71fb0
006A71F9C  adrp     x0, #0x8f37000
006A71FA0  ldr      x0, [x0, #0x650]
006A71FA4  bl       #0x382bd14 ; 
006A71FA8  mov      w8, #1
006A71FAC  strb     w8, [x21, #0x45d]
006A71FB0  adrp     x8, #0x8f37000
006A71FB4  ldr      x8, [x8, #0x650]
006A71FB8  ldr      x2, [x8]
006A71FBC  ldrb     w8, [x2, #0x53]
006A71FC0  tbnz     w8, #5, #0x6a71fd8
006A71FC4  mov      x0, x19
006A71FC8  str      x20, [x0, #0x38]!
006A71FCC  mov      x1, x20
006A71FD0  bl       #0x382bcb8 ; 
006A71FD4  b        #0x6a71fe8 ; 
006A71FD8  ldr      x8, [x2, #0x60]
006A71FDC  mov      x0, x19
006A71FE0  mov      x1, x20
006A71FE4  blr      x8
006A71FE8  mov      x0, x19
006A71FEC  mov      x1, xzr
006A71FF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A71FF4  adrp     x21, #0x959e000
006A71FF8  ldrb     w8, [x21, #0x45e]
006A71FFC  mov      w20, w0
006A72000  cbnz     w8, #0x6a72018
006A72004  adrp     x0, #0x8f37000
006A72008  ldr      x0, [x0, #0x660]
006A7200C  bl       #0x382bd14 ; 
006A72010  mov      w8, #1
006A72014  strb     w8, [x21, #0x45e]
006A72018  adrp     x8, #0x8f37000
006A7201C  ldr      x8, [x8, #0x660]
006A72020  ldr      x2, [x8]
006A72024  ldrb     w8, [x2, #0x53]
006A72028  tbnz     w8, #5, #0x6a72034
006A7202C  str      w20, [x19, #0x40]
006A72030  b        #0x6a72044 ; 
006A72034  ldr      x8, [x2, #0x60]
006A72038  mov      x0, x19
006A7203C  mov      w1, w20
006A72040  blr      x8
006A72044  mov      x0, x19
006A72048  mov      x1, xzr
006A7204C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A72050  adrp     x21, #0x959e000
006A72054  ldrb     w8, [x21, #0x45f]
006A72058  mov      w20, w0
006A7205C  cbnz     w8, #0x6a72074
006A72060  adrp     x0, #0x8f37000
006A72064  ldr      x0, [x0, #0x670]
006A72068  bl       #0x382bd14 ; 
006A7206C  mov      w8, #1
006A72070  strb     w8, [x21, #0x45f]
006A72074  adrp     x8, #0x8f37000
006A72078  ldr      x8, [x8, #0x670]
006A7207C  ldr      x2, [x8]
006A72080  ldrb     w8, [x2, #0x53]
006A72084  tbnz     w8, #5, #0x6a72090
006A72088  str      w20, [x19, #0x44]
006A7208C  b        #0x6a720a0 ; 
006A72090  ldr      x8, [x2, #0x60]
006A72094  mov      x0, x19
006A72098  mov      w1, w20
006A7209C  blr      x8
006A720A0  mov      x0, x19
006A720A4  mov      x1, xzr
006A720A8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A720AC  adrp     x21, #0x959e000
006A720B0  ldrb     w8, [x21, #0x460]
006A720B4  mov      x20, x0
006A720B8  cbnz     w8, #0x6a720d0
006A720BC  adrp     x0, #0x8f37000
006A720C0  ldr      x0, [x0, #0x680]
006A720C4  bl       #0x382bd14 ; 
006A720C8  mov      w8, #1
006A720CC  strb     w8, [x21, #0x460]
006A720D0  adrp     x8, #0x8f37000
006A720D4  ldr      x8, [x8, #0x680]
006A720D8  ldr      x2, [x8]
006A720DC  ldrb     w8, [x2, #0x53]
006A720E0  tbnz     w8, #5, #0x6a720f8
006A720E4  mov      x0, x19
006A720E8  str      x20, [x0, #0x48]!
006A720EC  mov      x1, x20
006A720F0  bl       #0x382bcb8 ; 
006A720F4  b        #0x6a72108 ; 
006A720F8  ldr      x8, [x2, #0x60]
006A720FC  mov      x0, x19
006A72100  mov      x1, x20
006A72104  blr      x8
006A72108  mov      x0, x19
006A7210C  mov      x1, xzr
006A72110  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A72114  adrp     x21, #0x959e000
006A72118  ldrb     w8, [x21, #0x461]
006A7211C  mov      x20, x0
006A72120  cbnz     w8, #0x6a72138
006A72124  adrp     x0, #0x8f37000
006A72128  ldr      x0, [x0, #0x690]
006A7212C  bl       #0x382bd14 ; 
006A72130  mov      w8, #1
006A72134  strb     w8, [x21, #0x461]
006A72138  adrp     x8, #0x8f37000
006A7213C  ldr      x8, [x8, #0x690]
006A72140  ldr      x2, [x8]
006A72144  ldrb     w8, [x2, #0x53]
006A72148  tbnz     w8, #5, #0x6a72160
006A7214C  mov      x0, x19
006A72150  str      x20, [x0, #0x50]!
006A72154  mov      x1, x20
006A72158  bl       #0x382bcb8 ; 
006A7215C  b        #0x6a72170 ; 
006A72160  ldr      x8, [x2, #0x60]
006A72164  mov      x0, x19
006A72168  mov      x1, x20
006A7216C  blr      x8
006A72170  mov      x0, x19
006A72174  mov      x1, xzr
006A72178  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7217C  adrp     x21, #0x959e000
006A72180  ldrb     w8, [x21, #0x462]
006A72184  mov      w20, w0
006A72188  cbnz     w8, #0x6a721a0
006A7218C  adrp     x0, #0x8f37000
006A72190  ldr      x0, [x0, #0x6a0]
006A72194  bl       #0x382bd14 ; 
006A72198  mov      w8, #1
006A7219C  strb     w8, [x21, #0x462]
006A721A0  adrp     x8, #0x8f37000
006A721A4  ldr      x8, [x8, #0x6a0]
006A721A8  ldr      x2, [x8]
006A721AC  ldrb     w8, [x2, #0x53]
006A721B0  tbnz     w8, #5, #0x6a721bc
006A721B4  str      w20, [x19, #0x58]
006A721B8  b        #0x6a721cc ; 
006A721BC  ldr      x8, [x2, #0x60]
006A721C0  mov      x0, x19
006A721C4  mov      w1, w20
006A721C8  blr      x8
006A721CC  mov      x0, x19
006A721D0  mov      x1, xzr
006A721D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A721D8  adrp     x21, #0x959e000
006A721DC  ldrb     w8, [x21, #0x463]
006A721E0  mov      w20, w0
006A721E4  cbnz     w8, #0x6a721fc
006A721E8  adrp     x0, #0x8f37000
006A721EC  ldr      x0, [x0, #0x6b0]
006A721F0  bl       #0x382bd14 ; 
006A721F4  mov      w8, #1
006A721F8  strb     w8, [x21, #0x463]
006A721FC  adrp     x8, #0x8f37000
006A72200  ldr      x8, [x8, #0x6b0]
006A72204  ldr      x2, [x8]
006A72208  ldrb     w8, [x2, #0x53]
006A7220C  tbnz     w8, #5, #0x6a72218
006A72210  str      w20, [x19, #0x5c]
006A72214  b        #0x6a72228 ; 
006A72218  ldr      x8, [x2, #0x60]
006A7221C  mov      x0, x19
006A72220  mov      w1, w20
006A72224  blr      x8
006A72228  mov      x0, x19
006A7222C  mov      x1, xzr
006A72230  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A72234  adrp     x21, #0x959e000
006A72238  ldrb     w8, [x21, #0x464]
006A7223C  mov      w20, w0
006A72240  cbnz     w8, #0x6a72258
006A72244  adrp     x0, #0x8f37000
006A72248  ldr      x0, [x0, #0x6c0]
006A7224C  bl       #0x382bd14 ; 
006A72250  mov      w8, #1
006A72254  strb     w8, [x21, #0x464]
006A72258  adrp     x8, #0x8f37000
006A7225C  ldr      x8, [x8, #0x6c0]
006A72260  ldr      x2, [x8]
006A72264  ldrb     w8, [x2, #0x53]
006A72268  tbnz     w8, #5, #0x6a72274
006A7226C  str      w20, [x19, #0x60]
006A72270  b        #0x6a72284 ; 
006A72274  ldr      x8, [x2, #0x60]
006A72278  mov      x0, x19
006A7227C  mov      w1, w20
006A72280  blr      x8
006A72284  mov      x0, x19
006A72288  mov      x1, xzr
006A7228C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A72290  adrp     x21, #0x959e000
006A72294  ldrb     w8, [x21, #0x465]
006A72298  mov      x20, x0
006A7229C  cbnz     w8, #0x6a722b4
006A722A0  adrp     x0, #0x8f37000
006A722A4  ldr      x0, [x0, #0x6d0]
006A722A8  bl       #0x382bd14 ; 
006A722AC  mov      w8, #1
006A722B0  strb     w8, [x21, #0x465]
006A722B4  adrp     x8, #0x8f37000
006A722B8  ldr      x8, [x8, #0x6d0]
006A722BC  ldr      x2, [x8]
006A722C0  ldrb     w8, [x2, #0x53]
006A722C4  tbnz     w8, #5, #0x6a722dc
006A722C8  mov      x0, x19
006A722CC  str      x20, [x0, #0x68]!
006A722D0  mov      x1, x20
006A722D4  bl       #0x382bcb8 ; 
006A722D8  b        #0x6a722ec ; 
006A722DC  ldr      x8, [x2, #0x60]
006A722E0  mov      x0, x19
006A722E4  mov      x1, x20
006A722E8  blr      x8
006A722EC  mov      x0, x19
006A722F0  mov      x1, xzr
006A722F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A722F8  adrp     x21, #0x959e000
006A722FC  ldrb     w8, [x21, #0x466]
006A72300  mov      w20, w0
006A72304  cbnz     w8, #0x6a7231c
006A72308  adrp     x0, #0x8f37000
006A7230C  ldr      x0, [x0, #0x6e0]
006A72310  bl       #0x382bd14 ; 
006A72314  mov      w8, #1
006A72318  strb     w8, [x21, #0x466]
006A7231C  adrp     x8, #0x8f37000
006A72320  ldr      x8, [x8, #0x6e0]
006A72324  ldr      x2, [x8]
006A72328  ldrb     w8, [x2, #0x53]
006A7232C  tbnz     w8, #5, #0x6a72338
006A72330  str      w20, [x19, #0x70]
006A72334  b        #0x6a72348 ; 
006A72338  ldr      x8, [x2, #0x60]
006A7233C  mov      x0, x19
006A72340  mov      w1, w20
006A72344  blr      x8
006A72348  ldp      x20, x19, [sp, #0x10]
006A7234C  mov      w0, #1
006A72350  ldp      x30, x21, [sp], #0x20
006A72354  ret      

