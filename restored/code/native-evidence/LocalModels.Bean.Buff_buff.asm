; LocalModels.Bean.Buff_buff$$readImpl
; RVA 0x6886AA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006886AA0  stp      x30, x21, [sp, #-0x20]!
006886AA4  stp      x20, x19, [sp, #0x10]
006886AA8  adrp     x20, #0x959b000
006886AAC  adrp     x21, #0x8f25000
006886AB0  ldrb     w8, [x20, #0xc34]
006886AB4  ldr      x21, [x21, #0x70]
006886AB8  mov      x19, x0
006886ABC  tbnz     w8, #0, #0x6886ad4
006886AC0  adrp     x0, #0x8f25000
006886AC4  ldr      x0, [x0, #0x70]
006886AC8  bl       #0x382bd14 ; 
006886ACC  mov      w8, #1
006886AD0  strb     w8, [x20, #0xc34]
006886AD4  ldr      x1, [x21]
006886AD8  ldrb     w8, [x1, #0x53]
006886ADC  tbnz     w8, #5, #0x6886b2c
006886AE0  mov      x0, x19
006886AE4  mov      x1, xzr
006886AE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886AEC  adrp     x21, #0x959c000
006886AF0  ldrb     w8, [x21, #0x3e6]
006886AF4  mov      w20, w0
006886AF8  cbnz     w8, #0x6886b10
006886AFC  adrp     x0, #0x8f24000
006886B00  ldr      x0, [x0, #0xf80]
006886B04  bl       #0x382bd14 ; 
006886B08  mov      w8, #1
006886B0C  strb     w8, [x21, #0x3e6]
006886B10  adrp     x8, #0x8f24000
006886B14  ldr      x8, [x8, #0xf80]
006886B18  ldr      x2, [x8]
006886B1C  ldrb     w8, [x2, #0x53]
006886B20  tbnz     w8, #5, #0x6886b40
006886B24  str      w20, [x19, #0x20]
006886B28  b        #0x6886b50 ; 
006886B2C  ldr      x2, [x1, #0x60]
006886B30  mov      x0, x19
006886B34  ldp      x20, x19, [sp, #0x10]
006886B38  ldp      x30, x21, [sp], #0x20
006886B3C  br       x2
006886B40  ldr      x8, [x2, #0x60]
006886B44  mov      x0, x19
006886B48  mov      w1, w20
006886B4C  blr      x8
006886B50  mov      x0, x19
006886B54  mov      x1, xzr
006886B58  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886B5C  adrp     x21, #0x959c000
006886B60  ldrb     w8, [x21, #0x3e7]
006886B64  mov      w20, w0
006886B68  cbnz     w8, #0x6886b80
006886B6C  adrp     x0, #0x8f24000
006886B70  ldr      x0, [x0, #0xf88]
006886B74  bl       #0x382bd14 ; 
006886B78  mov      w8, #1
006886B7C  strb     w8, [x21, #0x3e7]
006886B80  adrp     x8, #0x8f24000
006886B84  ldr      x8, [x8, #0xf88]
006886B88  ldr      x2, [x8]
006886B8C  ldrb     w8, [x2, #0x53]
006886B90  tbnz     w8, #5, #0x6886b9c
006886B94  str      w20, [x19, #0x24]
006886B98  b        #0x6886bac ; 
006886B9C  ldr      x8, [x2, #0x60]
006886BA0  mov      x0, x19
006886BA4  mov      w1, w20
006886BA8  blr      x8
006886BAC  mov      x0, x19
006886BB0  mov      x1, xzr
006886BB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886BB8  adrp     x21, #0x959c000
006886BBC  ldrb     w8, [x21, #0x3e8]
006886BC0  mov      w20, w0
006886BC4  cbnz     w8, #0x6886bdc
006886BC8  adrp     x0, #0x8f24000
006886BCC  ldr      x0, [x0, #0xf90]
006886BD0  bl       #0x382bd14 ; 
006886BD4  mov      w8, #1
006886BD8  strb     w8, [x21, #0x3e8]
006886BDC  adrp     x8, #0x8f24000
006886BE0  ldr      x8, [x8, #0xf90]
006886BE4  ldr      x2, [x8]
006886BE8  ldrb     w8, [x2, #0x53]
006886BEC  tbnz     w8, #5, #0x6886bf8
006886BF0  str      w20, [x19, #0x28]
006886BF4  b        #0x6886c08 ; 
006886BF8  ldr      x8, [x2, #0x60]
006886BFC  mov      x0, x19
006886C00  mov      w1, w20
006886C04  blr      x8
006886C08  mov      x0, x19
006886C0C  mov      x1, xzr
006886C10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886C14  adrp     x21, #0x959c000
006886C18  ldrb     w8, [x21, #0x3e9]
006886C1C  mov      w20, w0
006886C20  cbnz     w8, #0x6886c38
006886C24  adrp     x0, #0x8f24000
006886C28  ldr      x0, [x0, #0xf98]
006886C2C  bl       #0x382bd14 ; 
006886C30  mov      w8, #1
006886C34  strb     w8, [x21, #0x3e9]
006886C38  adrp     x8, #0x8f24000
006886C3C  ldr      x8, [x8, #0xf98]
006886C40  ldr      x2, [x8]
006886C44  ldrb     w8, [x2, #0x53]
006886C48  tbnz     w8, #5, #0x6886c54
006886C4C  str      w20, [x19, #0x2c]
006886C50  b        #0x6886c64 ; 
006886C54  ldr      x8, [x2, #0x60]
006886C58  mov      x0, x19
006886C5C  mov      w1, w20
006886C60  blr      x8
006886C64  mov      x0, x19
006886C68  mov      x1, xzr
006886C6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886C70  adrp     x21, #0x959c000
006886C74  ldrb     w8, [x21, #0x3ea]
006886C78  mov      w20, w0
006886C7C  cbnz     w8, #0x6886c94
006886C80  adrp     x0, #0x8f24000
006886C84  ldr      x0, [x0, #0xfa8]
006886C88  bl       #0x382bd14 ; 
006886C8C  mov      w8, #1
006886C90  strb     w8, [x21, #0x3ea]
006886C94  adrp     x8, #0x8f24000
006886C98  ldr      x8, [x8, #0xfa8]
006886C9C  ldr      x2, [x8]
006886CA0  ldrb     w8, [x2, #0x53]
006886CA4  tbnz     w8, #5, #0x6886cb0
006886CA8  str      w20, [x19, #0x30]
006886CAC  b        #0x6886cc0 ; 
006886CB0  ldr      x8, [x2, #0x60]
006886CB4  mov      x0, x19
006886CB8  mov      w1, w20
006886CBC  blr      x8
006886CC0  mov      x0, x19
006886CC4  mov      x1, xzr
006886CC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886CCC  adrp     x21, #0x959c000
006886CD0  ldrb     w8, [x21, #0x3eb]
006886CD4  mov      w20, w0
006886CD8  cbnz     w8, #0x6886cf0
006886CDC  adrp     x0, #0x8f24000
006886CE0  ldr      x0, [x0, #0xfb0]
006886CE4  bl       #0x382bd14 ; 
006886CE8  mov      w8, #1
006886CEC  strb     w8, [x21, #0x3eb]
006886CF0  adrp     x8, #0x8f24000
006886CF4  ldr      x8, [x8, #0xfb0]
006886CF8  ldr      x2, [x8]
006886CFC  ldrb     w8, [x2, #0x53]
006886D00  tbnz     w8, #5, #0x6886d0c
006886D04  str      w20, [x19, #0x34]
006886D08  b        #0x6886d1c ; 
006886D0C  ldr      x8, [x2, #0x60]
006886D10  mov      x0, x19
006886D14  mov      w1, w20
006886D18  blr      x8
006886D1C  mov      x0, x19
006886D20  mov      x1, xzr
006886D24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886D28  adrp     x21, #0x959c000
006886D2C  ldrb     w8, [x21, #0x3ec]
006886D30  mov      w20, w0
006886D34  cbnz     w8, #0x6886d4c
006886D38  adrp     x0, #0x8f24000
006886D3C  ldr      x0, [x0, #0xfb8]
006886D40  bl       #0x382bd14 ; 
006886D44  mov      w8, #1
006886D48  strb     w8, [x21, #0x3ec]
006886D4C  adrp     x8, #0x8f24000
006886D50  ldr      x8, [x8, #0xfb8]
006886D54  ldr      x2, [x8]
006886D58  ldrb     w8, [x2, #0x53]
006886D5C  tbnz     w8, #5, #0x6886d68
006886D60  str      w20, [x19, #0x38]
006886D64  b        #0x6886d78 ; 
006886D68  ldr      x8, [x2, #0x60]
006886D6C  mov      x0, x19
006886D70  mov      w1, w20
006886D74  blr      x8
006886D78  mov      x0, x19
006886D7C  mov      x1, xzr
006886D80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886D84  adrp     x21, #0x959c000
006886D88  ldrb     w8, [x21, #0x3ed]
006886D8C  mov      w20, w0
006886D90  cbnz     w8, #0x6886da8
006886D94  adrp     x0, #0x8f24000
006886D98  ldr      x0, [x0, #0xfc0]
006886D9C  bl       #0x382bd14 ; 
006886DA0  mov      w8, #1
006886DA4  strb     w8, [x21, #0x3ed]
006886DA8  adrp     x8, #0x8f24000
006886DAC  ldr      x8, [x8, #0xfc0]
006886DB0  ldr      x2, [x8]
006886DB4  ldrb     w8, [x2, #0x53]
006886DB8  tbnz     w8, #5, #0x6886dc4
006886DBC  str      w20, [x19, #0x3c]
006886DC0  b        #0x6886dd4 ; 
006886DC4  ldr      x8, [x2, #0x60]
006886DC8  mov      x0, x19
006886DCC  mov      w1, w20
006886DD0  blr      x8
006886DD4  mov      x0, x19
006886DD8  mov      x1, xzr
006886DDC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006886DE0  adrp     x21, #0x959c000
006886DE4  ldrb     w8, [x21, #0x3ee]
006886DE8  mov      x20, x0
006886DEC  cbnz     w8, #0x6886e04
006886DF0  adrp     x0, #0x8f24000
006886DF4  ldr      x0, [x0, #0xfc8]
006886DF8  bl       #0x382bd14 ; 
006886DFC  mov      w8, #1
006886E00  strb     w8, [x21, #0x3ee]
006886E04  adrp     x8, #0x8f24000
006886E08  ldr      x8, [x8, #0xfc8]
006886E0C  ldr      x2, [x8]
006886E10  ldrb     w8, [x2, #0x53]
006886E14  tbnz     w8, #5, #0x6886e2c
006886E18  mov      x0, x19
006886E1C  str      x20, [x0, #0x40]!
006886E20  mov      x1, x20
006886E24  bl       #0x382bcb8 ; 
006886E28  b        #0x6886e3c ; 
006886E2C  ldr      x8, [x2, #0x60]
006886E30  mov      x0, x19
006886E34  mov      x1, x20
006886E38  blr      x8
006886E3C  mov      x0, x19
006886E40  mov      x1, xzr
006886E44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886E48  adrp     x21, #0x959c000
006886E4C  ldrb     w8, [x21, #0x3ef]
006886E50  mov      w20, w0
006886E54  cbnz     w8, #0x6886e6c
006886E58  adrp     x0, #0x8f24000
006886E5C  ldr      x0, [x0, #0xfd0]
006886E60  bl       #0x382bd14 ; 
006886E64  mov      w8, #1
006886E68  strb     w8, [x21, #0x3ef]
006886E6C  adrp     x8, #0x8f24000
006886E70  ldr      x8, [x8, #0xfd0]
006886E74  ldr      x2, [x8]
006886E78  ldrb     w8, [x2, #0x53]
006886E7C  tbnz     w8, #5, #0x6886e88
006886E80  str      w20, [x19, #0x48]
006886E84  b        #0x6886e98 ; 
006886E88  ldr      x8, [x2, #0x60]
006886E8C  mov      x0, x19
006886E90  mov      w1, w20
006886E94  blr      x8
006886E98  mov      x0, x19
006886E9C  mov      x1, xzr
006886EA0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006886EA4  adrp     x21, #0x959c000
006886EA8  ldrb     w8, [x21, #0x3f0]
006886EAC  mov      x20, x0
006886EB0  cbnz     w8, #0x6886ec8
006886EB4  adrp     x0, #0x8f24000
006886EB8  ldr      x0, [x0, #0xfd8]
006886EBC  bl       #0x382bd14 ; 
006886EC0  mov      w8, #1
006886EC4  strb     w8, [x21, #0x3f0]
006886EC8  adrp     x8, #0x8f24000
006886ECC  ldr      x8, [x8, #0xfd8]
006886ED0  ldr      x2, [x8]
006886ED4  ldrb     w8, [x2, #0x53]
006886ED8  tbnz     w8, #5, #0x6886ee4
006886EDC  str      x20, [x19, #0x50]
006886EE0  b        #0x6886ef4 ; 
006886EE4  ldr      x8, [x2, #0x60]
006886EE8  mov      x0, x19
006886EEC  mov      x1, x20
006886EF0  blr      x8
006886EF4  mov      x0, x19
006886EF8  mov      x1, xzr
006886EFC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006886F00  adrp     x21, #0x959c000
006886F04  ldrb     w8, [x21, #0x3f1]
006886F08  mov      x20, x0
006886F0C  cbnz     w8, #0x6886f24
006886F10  adrp     x0, #0x8f24000
006886F14  ldr      x0, [x0, #0xfe0]
006886F18  bl       #0x382bd14 ; 
006886F1C  mov      w8, #1
006886F20  strb     w8, [x21, #0x3f1]
006886F24  adrp     x8, #0x8f24000
006886F28  ldr      x8, [x8, #0xfe0]
006886F2C  ldr      x2, [x8]
006886F30  ldrb     w8, [x2, #0x53]
006886F34  tbnz     w8, #5, #0x6886f40
006886F38  str      x20, [x19, #0x58]
006886F3C  b        #0x6886f50 ; 
006886F40  ldr      x8, [x2, #0x60]
006886F44  mov      x0, x19
006886F48  mov      x1, x20
006886F4C  blr      x8
006886F50  mov      x0, x19
006886F54  mov      x1, xzr
006886F58  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886F5C  adrp     x21, #0x959c000
006886F60  ldrb     w8, [x21, #0x3f2]
006886F64  mov      w20, w0
006886F68  cbnz     w8, #0x6886f80
006886F6C  adrp     x0, #0x8f24000
006886F70  ldr      x0, [x0, #0xfe8]
006886F74  bl       #0x382bd14 ; 
006886F78  mov      w8, #1
006886F7C  strb     w8, [x21, #0x3f2]
006886F80  adrp     x8, #0x8f24000
006886F84  ldr      x8, [x8, #0xfe8]
006886F88  ldr      x2, [x8]
006886F8C  ldrb     w8, [x2, #0x53]
006886F90  tbnz     w8, #5, #0x6886f9c
006886F94  str      w20, [x19, #0x60]
006886F98  b        #0x6886fac ; 
006886F9C  ldr      x8, [x2, #0x60]
006886FA0  mov      x0, x19
006886FA4  mov      w1, w20
006886FA8  blr      x8
006886FAC  mov      x0, x19
006886FB0  mov      x1, xzr
006886FB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006886FB8  adrp     x21, #0x959c000
006886FBC  ldrb     w8, [x21, #0x3f3]
006886FC0  mov      w20, w0
006886FC4  cbnz     w8, #0x6886fdc
006886FC8  adrp     x0, #0x8f24000
006886FCC  ldr      x0, [x0, #0xff0]
006886FD0  bl       #0x382bd14 ; 
006886FD4  mov      w8, #1
006886FD8  strb     w8, [x21, #0x3f3]
006886FDC  adrp     x8, #0x8f24000
006886FE0  ldr      x8, [x8, #0xff0]
006886FE4  ldr      x2, [x8]
006886FE8  ldrb     w8, [x2, #0x53]
006886FEC  tbnz     w8, #5, #0x6886ff8
006886FF0  str      w20, [x19, #0x64]
006886FF4  b        #0x6887008 ; 
006886FF8  ldr      x8, [x2, #0x60]
006886FFC  mov      x0, x19
006887000  mov      w1, w20
006887004  blr      x8
006887008  mov      x0, x19
00688700C  mov      x1, xzr
006887010  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006887014  adrp     x21, #0x959c000
006887018  ldrb     w8, [x21, #0x3f4]
00688701C  mov      w20, w0
006887020  cbnz     w8, #0x6887038
006887024  adrp     x0, #0x8f24000
006887028  ldr      x0, [x0, #0xff8]
00688702C  bl       #0x382bd14 ; 
006887030  mov      w8, #1
006887034  strb     w8, [x21, #0x3f4]
006887038  adrp     x8, #0x8f24000
00688703C  ldr      x8, [x8, #0xff8]
006887040  ldr      x2, [x8]
006887044  ldrb     w8, [x2, #0x53]
006887048  tbnz     w8, #5, #0x6887054
00688704C  str      w20, [x19, #0x68]
006887050  b        #0x6887064 ; 
006887054  ldr      x8, [x2, #0x60]
006887058  mov      x0, x19
00688705C  mov      w1, w20
006887060  blr      x8
006887064  mov      x0, x19
006887068  mov      x1, xzr
00688706C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006887070  adrp     x21, #0x959c000
006887074  ldrb     w8, [x21, #0x3f5]
006887078  mov      w20, w0
00688707C  cbnz     w8, #0x6887094
006887080  adrp     x0, #0x8f25000
006887084  ldr      x0, [x0]
006887088  bl       #0x382bd14 ; 
00688708C  mov      w8, #1
006887090  strb     w8, [x21, #0x3f5]
006887094  adrp     x8, #0x8f25000
006887098  ldr      x8, [x8]
00688709C  ldr      x2, [x8]
0068870A0  ldrb     w8, [x2, #0x53]
0068870A4  tbnz     w8, #5, #0x68870b0
0068870A8  str      w20, [x19, #0x6c]
0068870AC  b        #0x68870c0 ; 
0068870B0  ldr      x8, [x2, #0x60]
0068870B4  mov      x0, x19
0068870B8  mov      w1, w20
0068870BC  blr      x8
0068870C0  mov      x0, x19
0068870C4  mov      x1, xzr
0068870C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068870CC  adrp     x21, #0x959c000
0068870D0  ldrb     w8, [x21, #0x3f6]
0068870D4  mov      w20, w0
0068870D8  cbnz     w8, #0x68870f0
0068870DC  adrp     x0, #0x8f25000
0068870E0  ldr      x0, [x0, #8]
0068870E4  bl       #0x382bd14 ; 
0068870E8  mov      w8, #1
0068870EC  strb     w8, [x21, #0x3f6]
0068870F0  adrp     x8, #0x8f25000
0068870F4  ldr      x8, [x8, #8]
0068870F8  ldr      x2, [x8]
0068870FC  ldrb     w8, [x2, #0x53]
006887100  tbnz     w8, #5, #0x688710c
006887104  str      w20, [x19, #0x70]
006887108  b        #0x688711c ; 
00688710C  ldr      x8, [x2, #0x60]
006887110  mov      x0, x19
006887114  mov      w1, w20
006887118  blr      x8
00688711C  mov      x0, x19
006887120  mov      x1, xzr
006887124  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006887128  adrp     x21, #0x959c000
00688712C  ldrb     w8, [x21, #0x3f7]
006887130  mov      w20, w0
006887134  cbnz     w8, #0x688714c
006887138  adrp     x0, #0x8f25000
00688713C  ldr      x0, [x0, #0x10]
006887140  bl       #0x382bd14 ; 
006887144  mov      w8, #1
006887148  strb     w8, [x21, #0x3f7]
00688714C  adrp     x8, #0x8f25000
006887150  ldr      x8, [x8, #0x10]
006887154  ldr      x2, [x8]
006887158  ldrb     w8, [x2, #0x53]
00688715C  tbnz     w8, #5, #0x6887168
006887160  str      w20, [x19, #0x74]
006887164  b        #0x6887178 ; 
006887168  ldr      x8, [x2, #0x60]
00688716C  mov      x0, x19
006887170  mov      w1, w20
006887174  blr      x8
006887178  mov      x0, x19
00688717C  mov      x1, xzr
006887180  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006887184  adrp     x21, #0x959c000
006887188  ldrb     w8, [x21, #0x3f8]
00688718C  mov      x20, x0
006887190  cbnz     w8, #0x68871a8
006887194  adrp     x0, #0x8f25000
006887198  ldr      x0, [x0, #0x18]
00688719C  bl       #0x382bd14 ; 
0068871A0  mov      w8, #1
0068871A4  strb     w8, [x21, #0x3f8]
0068871A8  adrp     x8, #0x8f25000
0068871AC  ldr      x8, [x8, #0x18]
0068871B0  ldr      x2, [x8]
0068871B4  ldrb     w8, [x2, #0x53]
0068871B8  tbnz     w8, #5, #0x68871d0
0068871BC  mov      x0, x19
0068871C0  str      x20, [x0, #0x78]!
0068871C4  mov      x1, x20
0068871C8  bl       #0x382bcb8 ; 
0068871CC  b        #0x68871e0 ; 
0068871D0  ldr      x8, [x2, #0x60]
0068871D4  mov      x0, x19
0068871D8  mov      x1, x20
0068871DC  blr      x8
0068871E0  mov      x0, x19
0068871E4  mov      x1, xzr
0068871E8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068871EC  adrp     x21, #0x959c000
0068871F0  ldrb     w8, [x21, #0x3f9]
0068871F4  mov      x20, x0
0068871F8  cbnz     w8, #0x6887210
0068871FC  adrp     x0, #0x8f25000
006887200  ldr      x0, [x0, #0x20]
006887204  bl       #0x382bd14 ; 
006887208  mov      w8, #1
00688720C  strb     w8, [x21, #0x3f9]
006887210  adrp     x8, #0x8f25000
006887214  ldr      x8, [x8, #0x20]
006887218  ldr      x2, [x8]
00688721C  ldrb     w8, [x2, #0x53]
006887220  tbnz     w8, #5, #0x6887238
006887224  mov      x0, x19
006887228  str      x20, [x0, #0x80]!
00688722C  mov      x1, x20
006887230  bl       #0x382bcb8 ; 
006887234  b        #0x6887248 ; 
006887238  ldr      x8, [x2, #0x60]
00688723C  mov      x0, x19
006887240  mov      x1, x20
006887244  blr      x8
006887248  mov      x0, x19
00688724C  mov      x1, xzr
006887250  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006887254  adrp     x21, #0x959c000
006887258  ldrb     w8, [x21, #0x3fa]
00688725C  mov      x20, x0
006887260  cbnz     w8, #0x6887278
006887264  adrp     x0, #0x8f25000
006887268  ldr      x0, [x0, #0x28]
00688726C  bl       #0x382bd14 ; 
006887270  mov      w8, #1
006887274  strb     w8, [x21, #0x3fa]
006887278  adrp     x8, #0x8f25000
00688727C  ldr      x8, [x8, #0x28]
006887280  ldr      x2, [x8]
006887284  ldrb     w8, [x2, #0x53]
006887288  tbnz     w8, #5, #0x68872a0
00688728C  mov      x0, x19
006887290  str      x20, [x0, #0x88]!
006887294  mov      x1, x20
006887298  bl       #0x382bcb8 ; 
00688729C  b        #0x68872b0 ; 
0068872A0  ldr      x8, [x2, #0x60]
0068872A4  mov      x0, x19
0068872A8  mov      x1, x20
0068872AC  blr      x8
0068872B0  mov      x0, x19
0068872B4  mov      x1, xzr
0068872B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068872BC  adrp     x21, #0x959c000
0068872C0  ldrb     w8, [x21, #0x3fb]
0068872C4  mov      w20, w0
0068872C8  cbnz     w8, #0x68872e0
0068872CC  adrp     x0, #0x8f25000
0068872D0  ldr      x0, [x0, #0x30]
0068872D4  bl       #0x382bd14 ; 
0068872D8  mov      w8, #1
0068872DC  strb     w8, [x21, #0x3fb]
0068872E0  adrp     x8, #0x8f25000
0068872E4  ldr      x8, [x8, #0x30]
0068872E8  ldr      x2, [x8]
0068872EC  ldrb     w8, [x2, #0x53]
0068872F0  tbnz     w8, #5, #0x68872fc
0068872F4  str      w20, [x19, #0x90]
0068872F8  b        #0x688730c ; 
0068872FC  ldr      x8, [x2, #0x60]
006887300  mov      x0, x19
006887304  mov      w1, w20
006887308  blr      x8
00688730C  mov      x0, x19
006887310  mov      x1, xzr
006887314  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006887318  adrp     x21, #0x959c000
00688731C  ldrb     w8, [x21, #0x3fc]
006887320  mov      x20, x0
006887324  cbnz     w8, #0x688733c
006887328  adrp     x0, #0x8f25000
00688732C  ldr      x0, [x0, #0x40]
006887330  bl       #0x382bd14 ; 
006887334  mov      w8, #1
006887338  strb     w8, [x21, #0x3fc]
00688733C  adrp     x8, #0x8f25000
006887340  ldr      x8, [x8, #0x40]
006887344  ldr      x2, [x8]
006887348  ldrb     w8, [x2, #0x53]
00688734C  tbnz     w8, #5, #0x6887364
006887350  mov      x0, x19
006887354  str      x20, [x0, #0x98]!
006887358  mov      x1, x20
00688735C  bl       #0x382bcb8 ; 
006887360  b        #0x6887374 ; 
006887364  ldr      x8, [x2, #0x60]
006887368  mov      x0, x19
00688736C  mov      x1, x20
006887370  blr      x8
006887374  mov      x0, x19
006887378  mov      x1, xzr
00688737C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006887380  adrp     x21, #0x959c000
006887384  ldrb     w8, [x21, #0x3fd]
006887388  mov      w20, w0
00688738C  cbnz     w8, #0x68873a4
006887390  adrp     x0, #0x8f25000
006887394  ldr      x0, [x0, #0x50]
006887398  bl       #0x382bd14 ; 
00688739C  mov      w8, #1
0068873A0  strb     w8, [x21, #0x3fd]
0068873A4  adrp     x8, #0x8f25000
0068873A8  ldr      x8, [x8, #0x50]
0068873AC  ldr      x2, [x8]
0068873B0  ldrb     w8, [x2, #0x53]
0068873B4  tbnz     w8, #5, #0x68873c0
0068873B8  str      w20, [x19, #0xa0]
0068873BC  b        #0x68873d0 ; 
0068873C0  ldr      x8, [x2, #0x60]
0068873C4  mov      x0, x19
0068873C8  mov      w1, w20
0068873CC  blr      x8
0068873D0  mov      x0, x19
0068873D4  mov      x1, xzr
0068873D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068873DC  adrp     x21, #0x959c000
0068873E0  ldrb     w8, [x21, #0x3fe]
0068873E4  mov      w20, w0
0068873E8  cbnz     w8, #0x6887400
0068873EC  adrp     x0, #0x8f25000
0068873F0  ldr      x0, [x0, #0x60]
0068873F4  bl       #0x382bd14 ; 
0068873F8  mov      w8, #1
0068873FC  strb     w8, [x21, #0x3fe]
006887400  adrp     x8, #0x8f25000
006887404  ldr      x8, [x8, #0x60]
006887408  ldr      x2, [x8]
00688740C  ldrb     w8, [x2, #0x53]
006887410  tbnz     w8, #5, #0x688741c
006887414  str      w20, [x19, #0xa4]
006887418  b        #0x688742c ; 
00688741C  ldr      x8, [x2, #0x60]
006887420  mov      x0, x19
006887424  mov      w1, w20
006887428  blr      x8
00688742C  mov      x0, x19
006887430  mov      x1, xzr
006887434  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006887438  adrp     x21, #0x959c000
00688743C  ldrb     w8, [x21, #0x3ff]
006887440  mov      x20, x0
006887444  cbnz     w8, #0x688745c
006887448  adrp     x0, #0x8f25000
00688744C  ldr      x0, [x0, #0x68]
006887450  bl       #0x382bd14 ; 
006887454  mov      w8, #1
006887458  strb     w8, [x21, #0x3ff]
00688745C  adrp     x8, #0x8f25000
006887460  ldr      x8, [x8, #0x68]
006887464  ldr      x2, [x8]
006887468  ldrb     w8, [x2, #0x53]
00688746C  tbnz     w8, #5, #0x6887484
006887470  str      x20, [x19, #0xa8]!
006887474  mov      x0, x19
006887478  mov      x1, x20
00688747C  bl       #0x382bcb8 ; 
006887480  b        #0x6887494 ; 
006887484  ldr      x8, [x2, #0x60]
006887488  mov      x0, x19
00688748C  mov      x1, x20
006887490  blr      x8
006887494  ldp      x20, x19, [sp, #0x10]
006887498  mov      w0, #1
00688749C  ldp      x30, x21, [sp], #0x20
0068874A0  ret      

