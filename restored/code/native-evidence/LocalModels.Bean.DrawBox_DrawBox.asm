; LocalModels.Bean.DrawBox_DrawBox$$readImpl
; RVA 0x6A58D50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A58D50  stp      x30, x21, [sp, #-0x20]!
006A58D54  stp      x20, x19, [sp, #0x10]
006A58D58  adrp     x20, #0x959d000
006A58D5C  adrp     x21, #0x8f36000
006A58D60  ldrb     w8, [x20, #0xb36]
006A58D64  ldr      x21, [x21, #0x478]
006A58D68  mov      x19, x0
006A58D6C  tbnz     w8, #0, #0x6a58d84
006A58D70  adrp     x0, #0x8f36000
006A58D74  ldr      x0, [x0, #0x478]
006A58D78  bl       #0x382bd14 ; 
006A58D7C  mov      w8, #1
006A58D80  strb     w8, [x20, #0xb36]
006A58D84  ldr      x1, [x21]
006A58D88  ldrb     w8, [x1, #0x53]
006A58D8C  tbnz     w8, #5, #0x6a58ddc
006A58D90  mov      x0, x19
006A58D94  mov      x1, xzr
006A58D98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A58D9C  adrp     x21, #0x959e000
006A58DA0  ldrb     w8, [x21, #0x340]
006A58DA4  mov      w20, w0
006A58DA8  cbnz     w8, #0x6a58dc0
006A58DAC  adrp     x0, #0x8f36000
006A58DB0  ldr      x0, [x0, #0x390]
006A58DB4  bl       #0x382bd14 ; 
006A58DB8  mov      w8, #1
006A58DBC  strb     w8, [x21, #0x340]
006A58DC0  adrp     x8, #0x8f36000
006A58DC4  ldr      x8, [x8, #0x390]
006A58DC8  ldr      x2, [x8]
006A58DCC  ldrb     w8, [x2, #0x53]
006A58DD0  tbnz     w8, #5, #0x6a58df0
006A58DD4  str      w20, [x19, #0x20]
006A58DD8  b        #0x6a58e00 ; 
006A58DDC  ldr      x2, [x1, #0x60]
006A58DE0  mov      x0, x19
006A58DE4  ldp      x20, x19, [sp, #0x10]
006A58DE8  ldp      x30, x21, [sp], #0x20
006A58DEC  br       x2
006A58DF0  ldr      x8, [x2, #0x60]
006A58DF4  mov      x0, x19
006A58DF8  mov      w1, w20
006A58DFC  blr      x8
006A58E00  mov      x0, x19
006A58E04  mov      x1, xzr
006A58E08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A58E0C  adrp     x21, #0x959e000
006A58E10  ldrb     w8, [x21, #0x341]
006A58E14  mov      w20, w0
006A58E18  cbnz     w8, #0x6a58e30
006A58E1C  adrp     x0, #0x8f36000
006A58E20  ldr      x0, [x0, #0x3a0]
006A58E24  bl       #0x382bd14 ; 
006A58E28  mov      w8, #1
006A58E2C  strb     w8, [x21, #0x341]
006A58E30  adrp     x8, #0x8f36000
006A58E34  ldr      x8, [x8, #0x3a0]
006A58E38  ldr      x2, [x8]
006A58E3C  ldrb     w8, [x2, #0x53]
006A58E40  tbnz     w8, #5, #0x6a58e4c
006A58E44  str      w20, [x19, #0x24]
006A58E48  b        #0x6a58e5c ; 
006A58E4C  ldr      x8, [x2, #0x60]
006A58E50  mov      x0, x19
006A58E54  mov      w1, w20
006A58E58  blr      x8
006A58E5C  mov      x0, x19
006A58E60  mov      x1, xzr
006A58E64  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A58E68  adrp     x21, #0x959e000
006A58E6C  ldrb     w8, [x21, #0x342]
006A58E70  mov      x20, x0
006A58E74  cbnz     w8, #0x6a58e8c
006A58E78  adrp     x0, #0x8f36000
006A58E7C  ldr      x0, [x0, #0x3b0]
006A58E80  bl       #0x382bd14 ; 
006A58E84  mov      w8, #1
006A58E88  strb     w8, [x21, #0x342]
006A58E8C  adrp     x8, #0x8f36000
006A58E90  ldr      x8, [x8, #0x3b0]
006A58E94  ldr      x2, [x8]
006A58E98  ldrb     w8, [x2, #0x53]
006A58E9C  tbnz     w8, #5, #0x6a58eb4
006A58EA0  mov      x0, x19
006A58EA4  str      x20, [x0, #0x28]!
006A58EA8  mov      x1, x20
006A58EAC  bl       #0x382bcb8 ; 
006A58EB0  b        #0x6a58ec4 ; 
006A58EB4  ldr      x8, [x2, #0x60]
006A58EB8  mov      x0, x19
006A58EBC  mov      x1, x20
006A58EC0  blr      x8
006A58EC4  mov      x0, x19
006A58EC8  mov      x1, xzr
006A58ECC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A58ED0  adrp     x21, #0x959e000
006A58ED4  ldrb     w8, [x21, #0x343]
006A58ED8  mov      w20, w0
006A58EDC  cbnz     w8, #0x6a58ef4
006A58EE0  adrp     x0, #0x8f36000
006A58EE4  ldr      x0, [x0, #0x3c0]
006A58EE8  bl       #0x382bd14 ; 
006A58EEC  mov      w8, #1
006A58EF0  strb     w8, [x21, #0x343]
006A58EF4  adrp     x8, #0x8f36000
006A58EF8  ldr      x8, [x8, #0x3c0]
006A58EFC  ldr      x2, [x8]
006A58F00  ldrb     w8, [x2, #0x53]
006A58F04  tbnz     w8, #5, #0x6a58f10
006A58F08  str      w20, [x19, #0x30]
006A58F0C  b        #0x6a58f20 ; 
006A58F10  ldr      x8, [x2, #0x60]
006A58F14  mov      x0, x19
006A58F18  mov      w1, w20
006A58F1C  blr      x8
006A58F20  mov      x0, x19
006A58F24  mov      x1, xzr
006A58F28  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A58F2C  adrp     x21, #0x959e000
006A58F30  ldrb     w8, [x21, #0x344]
006A58F34  mov      x20, x0
006A58F38  cbnz     w8, #0x6a58f50
006A58F3C  adrp     x0, #0x8f36000
006A58F40  ldr      x0, [x0, #0x3d0]
006A58F44  bl       #0x382bd14 ; 
006A58F48  mov      w8, #1
006A58F4C  strb     w8, [x21, #0x344]
006A58F50  adrp     x8, #0x8f36000
006A58F54  ldr      x8, [x8, #0x3d0]
006A58F58  ldr      x2, [x8]
006A58F5C  ldrb     w8, [x2, #0x53]
006A58F60  tbnz     w8, #5, #0x6a58f78
006A58F64  mov      x0, x19
006A58F68  str      x20, [x0, #0x38]!
006A58F6C  mov      x1, x20
006A58F70  bl       #0x382bcb8 ; 
006A58F74  b        #0x6a58f88 ; 
006A58F78  ldr      x8, [x2, #0x60]
006A58F7C  mov      x0, x19
006A58F80  mov      x1, x20
006A58F84  blr      x8
006A58F88  mov      x0, x19
006A58F8C  mov      x1, xzr
006A58F90  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A58F94  adrp     x21, #0x959e000
006A58F98  ldrb     w8, [x21, #0x345]
006A58F9C  mov      x20, x0
006A58FA0  cbnz     w8, #0x6a58fb8
006A58FA4  adrp     x0, #0x8f36000
006A58FA8  ldr      x0, [x0, #0x3e0]
006A58FAC  bl       #0x382bd14 ; 
006A58FB0  mov      w8, #1
006A58FB4  strb     w8, [x21, #0x345]
006A58FB8  adrp     x8, #0x8f36000
006A58FBC  ldr      x8, [x8, #0x3e0]
006A58FC0  ldr      x2, [x8]
006A58FC4  ldrb     w8, [x2, #0x53]
006A58FC8  tbnz     w8, #5, #0x6a58fe0
006A58FCC  mov      x0, x19
006A58FD0  str      x20, [x0, #0x40]!
006A58FD4  mov      x1, x20
006A58FD8  bl       #0x382bcb8 ; 
006A58FDC  b        #0x6a58ff0 ; 
006A58FE0  ldr      x8, [x2, #0x60]
006A58FE4  mov      x0, x19
006A58FE8  mov      x1, x20
006A58FEC  blr      x8
006A58FF0  mov      x0, x19
006A58FF4  mov      x1, xzr
006A58FF8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A58FFC  adrp     x21, #0x959e000
006A59000  ldrb     w8, [x21, #0x346]
006A59004  mov      x20, x0
006A59008  cbnz     w8, #0x6a59020
006A5900C  adrp     x0, #0x8f36000
006A59010  ldr      x0, [x0, #0x3f0]
006A59014  bl       #0x382bd14 ; 
006A59018  mov      w8, #1
006A5901C  strb     w8, [x21, #0x346]
006A59020  adrp     x8, #0x8f36000
006A59024  ldr      x8, [x8, #0x3f0]
006A59028  ldr      x2, [x8]
006A5902C  ldrb     w8, [x2, #0x53]
006A59030  tbnz     w8, #5, #0x6a59048
006A59034  mov      x0, x19
006A59038  str      x20, [x0, #0x48]!
006A5903C  mov      x1, x20
006A59040  bl       #0x382bcb8 ; 
006A59044  b        #0x6a59058 ; 
006A59048  ldr      x8, [x2, #0x60]
006A5904C  mov      x0, x19
006A59050  mov      x1, x20
006A59054  blr      x8
006A59058  mov      x0, x19
006A5905C  mov      x1, xzr
006A59060  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A59064  adrp     x21, #0x959e000
006A59068  ldrb     w8, [x21, #0x347]
006A5906C  mov      x20, x0
006A59070  cbnz     w8, #0x6a59088
006A59074  adrp     x0, #0x8f36000
006A59078  ldr      x0, [x0, #0x400]
006A5907C  bl       #0x382bd14 ; 
006A59080  mov      w8, #1
006A59084  strb     w8, [x21, #0x347]
006A59088  adrp     x8, #0x8f36000
006A5908C  ldr      x8, [x8, #0x400]
006A59090  ldr      x2, [x8]
006A59094  ldrb     w8, [x2, #0x53]
006A59098  tbnz     w8, #5, #0x6a590b0
006A5909C  mov      x0, x19
006A590A0  str      x20, [x0, #0x50]!
006A590A4  mov      x1, x20
006A590A8  bl       #0x382bcb8 ; 
006A590AC  b        #0x6a590c0 ; 
006A590B0  ldr      x8, [x2, #0x60]
006A590B4  mov      x0, x19
006A590B8  mov      x1, x20
006A590BC  blr      x8
006A590C0  mov      x0, x19
006A590C4  mov      x1, xzr
006A590C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A590CC  adrp     x21, #0x959e000
006A590D0  ldrb     w8, [x21, #0x348]
006A590D4  mov      x20, x0
006A590D8  cbnz     w8, #0x6a590f0
006A590DC  adrp     x0, #0x8f36000
006A590E0  ldr      x0, [x0, #0x410]
006A590E4  bl       #0x382bd14 ; 
006A590E8  mov      w8, #1
006A590EC  strb     w8, [x21, #0x348]
006A590F0  adrp     x8, #0x8f36000
006A590F4  ldr      x8, [x8, #0x410]
006A590F8  ldr      x2, [x8]
006A590FC  ldrb     w8, [x2, #0x53]
006A59100  tbnz     w8, #5, #0x6a59118
006A59104  mov      x0, x19
006A59108  str      x20, [x0, #0x58]!
006A5910C  mov      x1, x20
006A59110  bl       #0x382bcb8 ; 
006A59114  b        #0x6a59128 ; 
006A59118  ldr      x8, [x2, #0x60]
006A5911C  mov      x0, x19
006A59120  mov      x1, x20
006A59124  blr      x8
006A59128  mov      x0, x19
006A5912C  mov      x1, xzr
006A59130  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A59134  adrp     x21, #0x959e000
006A59138  ldrb     w8, [x21, #0x349]
006A5913C  mov      x20, x0
006A59140  cbnz     w8, #0x6a59158
006A59144  adrp     x0, #0x8f36000
006A59148  ldr      x0, [x0, #0x420]
006A5914C  bl       #0x382bd14 ; 
006A59150  mov      w8, #1
006A59154  strb     w8, [x21, #0x349]
006A59158  adrp     x8, #0x8f36000
006A5915C  ldr      x8, [x8, #0x420]
006A59160  ldr      x2, [x8]
006A59164  ldrb     w8, [x2, #0x53]
006A59168  tbnz     w8, #5, #0x6a59180
006A5916C  mov      x0, x19
006A59170  str      x20, [x0, #0x60]!
006A59174  mov      x1, x20
006A59178  bl       #0x382bcb8 ; 
006A5917C  b        #0x6a59190 ; 
006A59180  ldr      x8, [x2, #0x60]
006A59184  mov      x0, x19
006A59188  mov      x1, x20
006A5918C  blr      x8
006A59190  mov      x0, x19
006A59194  mov      x1, xzr
006A59198  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5919C  adrp     x21, #0x959e000
006A591A0  ldrb     w8, [x21, #0x34a]
006A591A4  mov      w20, w0
006A591A8  cbnz     w8, #0x6a591c0
006A591AC  adrp     x0, #0x8f36000
006A591B0  ldr      x0, [x0, #0x430]
006A591B4  bl       #0x382bd14 ; 
006A591B8  mov      w8, #1
006A591BC  strb     w8, [x21, #0x34a]
006A591C0  adrp     x8, #0x8f36000
006A591C4  ldr      x8, [x8, #0x430]
006A591C8  ldr      x2, [x8]
006A591CC  ldrb     w8, [x2, #0x53]
006A591D0  tbnz     w8, #5, #0x6a591dc
006A591D4  str      w20, [x19, #0x68]
006A591D8  b        #0x6a591ec ; 
006A591DC  ldr      x8, [x2, #0x60]
006A591E0  mov      x0, x19
006A591E4  mov      w1, w20
006A591E8  blr      x8
006A591EC  mov      x0, x19
006A591F0  mov      x1, xzr
006A591F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A591F8  adrp     x21, #0x959e000
006A591FC  ldrb     w8, [x21, #0x34b]
006A59200  mov      w20, w0
006A59204  cbnz     w8, #0x6a5921c
006A59208  adrp     x0, #0x8f36000
006A5920C  ldr      x0, [x0, #0x440]
006A59210  bl       #0x382bd14 ; 
006A59214  mov      w8, #1
006A59218  strb     w8, [x21, #0x34b]
006A5921C  adrp     x8, #0x8f36000
006A59220  ldr      x8, [x8, #0x440]
006A59224  ldr      x2, [x8]
006A59228  ldrb     w8, [x2, #0x53]
006A5922C  tbnz     w8, #5, #0x6a59238
006A59230  str      w20, [x19, #0x6c]
006A59234  b        #0x6a59248 ; 
006A59238  ldr      x8, [x2, #0x60]
006A5923C  mov      x0, x19
006A59240  mov      w1, w20
006A59244  blr      x8
006A59248  mov      x0, x19
006A5924C  mov      x1, xzr
006A59250  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A59254  adrp     x21, #0x959e000
006A59258  ldrb     w8, [x21, #0x34c]
006A5925C  mov      x20, x0
006A59260  cbnz     w8, #0x6a59278
006A59264  adrp     x0, #0x8f36000
006A59268  ldr      x0, [x0, #0x450]
006A5926C  bl       #0x382bd14 ; 
006A59270  mov      w8, #1
006A59274  strb     w8, [x21, #0x34c]
006A59278  adrp     x8, #0x8f36000
006A5927C  ldr      x8, [x8, #0x450]
006A59280  ldr      x2, [x8]
006A59284  ldrb     w8, [x2, #0x53]
006A59288  tbnz     w8, #5, #0x6a592a0
006A5928C  mov      x0, x19
006A59290  str      x20, [x0, #0x70]!
006A59294  mov      x1, x20
006A59298  bl       #0x382bcb8 ; 
006A5929C  b        #0x6a592b0 ; 
006A592A0  ldr      x8, [x2, #0x60]
006A592A4  mov      x0, x19
006A592A8  mov      x1, x20
006A592AC  blr      x8
006A592B0  mov      x0, x19
006A592B4  mov      x1, xzr
006A592B8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A592BC  adrp     x21, #0x959e000
006A592C0  ldrb     w8, [x21, #0x34d]
006A592C4  mov      x20, x0
006A592C8  cbnz     w8, #0x6a592e0
006A592CC  adrp     x0, #0x8f36000
006A592D0  ldr      x0, [x0, #0x460]
006A592D4  bl       #0x382bd14 ; 
006A592D8  mov      w8, #1
006A592DC  strb     w8, [x21, #0x34d]
006A592E0  adrp     x8, #0x8f36000
006A592E4  ldr      x8, [x8, #0x460]
006A592E8  ldr      x2, [x8]
006A592EC  ldrb     w8, [x2, #0x53]
006A592F0  tbnz     w8, #5, #0x6a59308
006A592F4  mov      x0, x19
006A592F8  str      x20, [x0, #0x78]!
006A592FC  mov      x1, x20
006A59300  bl       #0x382bcb8 ; 
006A59304  b        #0x6a59318 ; 
006A59308  ldr      x8, [x2, #0x60]
006A5930C  mov      x0, x19
006A59310  mov      x1, x20
006A59314  blr      x8
006A59318  mov      x0, x19
006A5931C  mov      x1, xzr
006A59320  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A59324  adrp     x21, #0x959e000
006A59328  ldrb     w8, [x21, #0x34e]
006A5932C  mov      x20, x0
006A59330  cbnz     w8, #0x6a59348
006A59334  adrp     x0, #0x8f36000
006A59338  ldr      x0, [x0, #0x470]
006A5933C  bl       #0x382bd14 ; 
006A59340  mov      w8, #1
006A59344  strb     w8, [x21, #0x34e]
006A59348  adrp     x8, #0x8f36000
006A5934C  ldr      x8, [x8, #0x470]
006A59350  ldr      x2, [x8]
006A59354  ldrb     w8, [x2, #0x53]
006A59358  tbnz     w8, #5, #0x6a59370
006A5935C  str      x20, [x19, #0x80]!
006A59360  mov      x0, x19
006A59364  mov      x1, x20
006A59368  bl       #0x382bcb8 ; 
006A5936C  b        #0x6a59380 ; 
006A59370  ldr      x8, [x2, #0x60]
006A59374  mov      x0, x19
006A59378  mov      x1, x20
006A5937C  blr      x8
006A59380  ldp      x20, x19, [sp, #0x10]
006A59384  mov      w0, #1
006A59388  ldp      x30, x21, [sp], #0x20
006A5938C  ret      

