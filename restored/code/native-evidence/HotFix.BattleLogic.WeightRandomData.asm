; HotFix.BattleLogic.WeightRandomData$$GetNeedFlags
; RVA 0x6631D14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631D14  stp      x30, x21, [sp, #-0x20]!
006631D18  stp      x20, x19, [sp, #0x10]
006631D1C  adrp     x20, #0x9599000
006631D20  adrp     x21, #0x8f0c000
006631D24  ldrb     w8, [x20, #0x9b9]
006631D28  ldr      x21, [x21, #0xe98]
006631D2C  mov      x19, x0
006631D30  tbnz     w8, #0, #0x6631d48
006631D34  adrp     x0, #0x8f0c000
006631D38  ldr      x0, [x0, #0xe98]
006631D3C  bl       #0x382bd14 ; 
006631D40  mov      w8, #1
006631D44  strb     w8, [x20, #0x9b9]
006631D48  ldr      x1, [x21]
006631D4C  ldrb     w8, [x1, #0x53]
006631D50  tbnz     w8, #5, #0x6631d64
006631D54  ldr      w0, [x19, #0xc]
006631D58  ldp      x20, x19, [sp, #0x10]
006631D5C  ldp      x30, x21, [sp], #0x20
006631D60  ret      
006631D64  ldr      x2, [x1, #0x60]
006631D68  mov      x0, x19
006631D6C  ldp      x20, x19, [sp, #0x10]
006631D70  ldp      x30, x21, [sp], #0x20
006631D74  br       x2

; HotFix.BattleLogic.WeightRandomData$$GetSkillFlags
; RVA 0x6631D78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631D78  stp      x30, x21, [sp, #-0x20]!
006631D7C  stp      x20, x19, [sp, #0x10]
006631D80  adrp     x20, #0x9599000
006631D84  adrp     x21, #0x8f0c000
006631D88  ldrb     w8, [x20, #0x9bb]
006631D8C  ldr      x21, [x21, #0xea0]
006631D90  mov      x19, x0
006631D94  tbnz     w8, #0, #0x6631dac
006631D98  adrp     x0, #0x8f0c000
006631D9C  ldr      x0, [x0, #0xea0]
006631DA0  bl       #0x382bd14 ; 
006631DA4  mov      w8, #1
006631DA8  strb     w8, [x20, #0x9bb]
006631DAC  ldr      x1, [x21]
006631DB0  ldrb     w8, [x1, #0x53]
006631DB4  tbnz     w8, #5, #0x6631dc8
006631DB8  ldr      x0, [x19, #0x10]
006631DBC  ldp      x20, x19, [sp, #0x10]
006631DC0  ldp      x30, x21, [sp], #0x20
006631DC4  ret      
006631DC8  ldr      x2, [x1, #0x60]
006631DCC  mov      x0, x19
006631DD0  ldp      x20, x19, [sp, #0x10]
006631DD4  ldp      x30, x21, [sp], #0x20
006631DD8  br       x2

; HotFix.BattleLogic.WeightRandomData$$GetNeedSkills
; RVA 0x6631DDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631DDC  stp      x30, x21, [sp, #-0x20]!
006631DE0  stp      x20, x19, [sp, #0x10]
006631DE4  adrp     x20, #0x9599000
006631DE8  adrp     x21, #0x8f0c000
006631DEC  ldrb     w8, [x20, #0x9bd]
006631DF0  ldr      x21, [x21, #0xea8]
006631DF4  mov      x19, x0
006631DF8  tbnz     w8, #0, #0x6631e10
006631DFC  adrp     x0, #0x8f0c000
006631E00  ldr      x0, [x0, #0xea8]
006631E04  bl       #0x382bd14 ; 
006631E08  mov      w8, #1
006631E0C  strb     w8, [x20, #0x9bd]
006631E10  ldr      x1, [x21]
006631E14  ldrb     w8, [x1, #0x53]
006631E18  tbnz     w8, #5, #0x6631e2c
006631E1C  ldr      x0, [x19, #0x28]
006631E20  ldp      x20, x19, [sp, #0x10]
006631E24  ldp      x30, x21, [sp], #0x20
006631E28  ret      
006631E2C  ldr      x2, [x1, #0x60]
006631E30  mov      x0, x19
006631E34  ldp      x20, x19, [sp, #0x10]
006631E38  ldp      x30, x21, [sp], #0x20
006631E3C  br       x2

; HotFix.BattleLogic.WeightRandomData$$Clear
; RVA 0x6631E40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631E40  stp      x30, x21, [sp, #-0x20]!
006631E44  stp      x20, x19, [sp, #0x10]
006631E48  adrp     x20, #0x9599000
006631E4C  adrp     x21, #0x8f0c000
006631E50  ldrb     w8, [x20, #0x9bf]
006631E54  ldr      x21, [x21, #0xeb0]
006631E58  mov      x19, x0
006631E5C  tbnz     w8, #0, #0x6631e80
006631E60  adrp     x0, #0x8ec2000
006631E64  ldr      x0, [x0, #0x240]
006631E68  bl       #0x382bd14 ; 
006631E6C  adrp     x0, #0x8f0c000
006631E70  ldr      x0, [x0, #0xeb0]
006631E74  bl       #0x382bd14 ; 
006631E78  mov      w8, #1
006631E7C  strb     w8, [x20, #0x9bf]
006631E80  ldr      x1, [x21]
006631E84  ldrb     w8, [x1, #0x53]
006631E88  tbnz     w8, #5, #0x6631ecc
006631E8C  mov      x0, x19
006631E90  str      xzr, [x0, #0x10]!
006631E94  mov      x1, xzr
006631E98  stp      xzr, xzr, [x19]
006631E9C  bl       #0x382bcb8 ; 
006631EA0  ldr      x8, [x19, #0x28]
006631EA4  str      xzr, [x19, #0x18]
006631EA8  strh     wzr, [x19, #0x20]
006631EAC  strb     wzr, [x19, #0x30]
006631EB0  cbz      x8, #0x6631ee0
006631EB4  ldr      w9, [x8, #0x1c]
006631EB8  ldp      x20, x19, [sp, #0x10]
006631EBC  add      w9, w9, #1
006631EC0  stp      wzr, w9, [x8, #0x18]
006631EC4  ldp      x30, x21, [sp], #0x20
006631EC8  ret      
006631ECC  ldr      x2, [x1, #0x60]
006631ED0  mov      x0, x19
006631ED4  ldp      x20, x19, [sp, #0x10]
006631ED8  ldp      x30, x21, [sp], #0x20
006631EDC  br       x2
006631EE0  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandomData$$Init
; RVA 0x6631EE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631EE4  str      x30, [sp, #-0x50]!
006631EE8  stp      x26, x25, [sp, #0x10]
006631EEC  stp      x24, x23, [sp, #0x20]
006631EF0  stp      x22, x21, [sp, #0x30]
006631EF4  stp      x20, x19, [sp, #0x40]
006631EF8  adrp     x25, #0x9599000
006631EFC  adrp     x26, #0x8f0c000
006631F00  ldrb     w8, [x25, #0x9c1]
006631F04  ldr      x26, [x26, #0xeb8]
006631F08  mov      x19, x5
006631F0C  mov      x21, x4
006631F10  mov      w22, w3
006631F14  mov      w23, w2
006631F18  mov      w24, w1
006631F1C  mov      x20, x0
006631F20  tbnz     w8, #0, #0x6631f68
006631F24  adrp     x0, #0x8f08000
006631F28  ldr      x0, [x0, #0xbb0]
006631F2C  bl       #0x382bd14 ; 
006631F30  adrp     x0, #0x8ec2000
006631F34  ldr      x0, [x0, #0x240]
006631F38  bl       #0x382bd14 ; 
006631F3C  adrp     x0, #0x8edb000
006631F40  ldr      x0, [x0, #0x2f8]
006631F44  bl       #0x382bd14 ; 
006631F48  adrp     x0, #0x8ec2000
006631F4C  ldr      x0, [x0, #0x2d0]
006631F50  bl       #0x382bd14 ; 
006631F54  adrp     x0, #0x8f0c000
006631F58  ldr      x0, [x0, #0xeb8]
006631F5C  bl       #0x382bd14 ; 
006631F60  mov      w8, #1
006631F64  strb     w8, [x25, #0x9c1]
006631F68  ldr      x6, [x26]
006631F6C  ldrb     w8, [x6, #0x53]
006631F70  tbnz     w8, #5, #0x6631fe0
006631F74  mov      x0, x20
006631F78  stp      w24, w23, [x20]
006631F7C  stp      w23, w22, [x20, #8]
006631F80  str      x21, [x0, #0x10]!
006631F84  mov      x1, x21
006631F88  bl       #0x382bcb8 ; 
006631F8C  ldr      x8, [x20, #0x28]!
006631F90  stur     xzr, [x20, #-0x10]
006631F94  sturh    wzr, [x20, #-8]
006631F98  strb     wzr, [x20, #8]
006631F9C  cbz      x8, #0x6632014
006631FA0  ldr      w9, [x8, #0x1c]
006631FA4  add      w9, w9, #1
006631FA8  stp      wzr, w9, [x8, #0x18]
006631FAC  cbz      x19, #0x6632050
006631FB0  ldr      x0, [x20]
006631FB4  cbz      x0, #0x6632068
006631FB8  adrp     x8, #0x8f08000
006631FBC  ldr      x8, [x8, #0xbb0]
006631FC0  mov      x1, x19
006631FC4  ldp      x20, x19, [sp, #0x40]
006631FC8  ldp      x22, x21, [sp, #0x30]
006631FCC  ldr      x2, [x8]
006631FD0  ldp      x24, x23, [sp, #0x20]
006631FD4  ldp      x26, x25, [sp, #0x10]
006631FD8  ldr      x30, [sp], #0x50
006631FDC  b        #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
006631FE0  ldr      x7, [x6, #0x60]
006631FE4  mov      x0, x20
006631FE8  mov      w1, w24
006631FEC  mov      w2, w23
006631FF0  mov      w3, w22
006631FF4  mov      x4, x21
006631FF8  mov      x5, x19
006631FFC  ldp      x20, x19, [sp, #0x40]
006632000  ldp      x22, x21, [sp, #0x30]
006632004  ldp      x24, x23, [sp, #0x20]
006632008  ldp      x26, x25, [sp, #0x10]
00663200C  ldr      x30, [sp], #0x50
006632010  br       x7
006632014  adrp     x8, #0x8ec2000
006632018  ldr      x8, [x8, #0x2d0]
00663201C  ldr      x0, [x8]
006632020  bl       #0x382bfa0 ; 
006632024  adrp     x8, #0x8edb000
006632028  ldr      x8, [x8, #0x2f8]
00663202C  mov      w1, #0xa
006632030  mov      x21, x0
006632034  ldr      x2, [x8]
006632038  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
00663203C  mov      x0, x20
006632040  mov      x1, x21
006632044  str      x21, [x20]
006632048  bl       #0x382bcb8 ; 
00663204C  cbnz     x19, #0x6631fb0
006632050  ldp      x20, x19, [sp, #0x40]
006632054  ldp      x22, x21, [sp, #0x30]
006632058  ldp      x24, x23, [sp, #0x20]
00663205C  ldp      x26, x25, [sp, #0x10]
006632060  ldr      x30, [sp], #0x50
006632064  ret      
006632068  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandomData$$Weight
; RVA 0x663206C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00663206C  stp      x30, x21, [sp, #-0x20]!
006632070  stp      x20, x19, [sp, #0x10]
006632074  adrp     x20, #0x9599000
006632078  adrp     x21, #0x8f0c000
00663207C  ldrb     w8, [x20, #0x9c3]
006632080  ldr      x21, [x21, #0xec0]
006632084  mov      x19, x0
006632088  tbnz     w8, #0, #0x66320ac
00663208C  adrp     x0, #0x8ec2000
006632090  ldr      x0, [x0, #0x268]
006632094  bl       #0x382bd14 ; 
006632098  adrp     x0, #0x8f0c000
00663209C  ldr      x0, [x0, #0xec0]
0066320A0  bl       #0x382bd14 ; 
0066320A4  mov      w8, #1
0066320A8  strb     w8, [x20, #0x9c3]
0066320AC  ldr      x1, [x21]
0066320B0  ldrb     w8, [x1, #0x53]
0066320B4  tbnz     w8, #5, #0x66320f8
0066320B8  ldr      w8, [x19, #0xc]
0066320BC  cbnz     w8, #0x66320e8
0066320C0  ldrb     w8, [x19, #0x30]
0066320C4  cbnz     w8, #0x66320e8
0066320C8  ldr      x8, [x19, #0x28]
0066320CC  cbz      x8, #0x663211c
0066320D0  ldr      w8, [x8, #0x18]
0066320D4  cbnz     w8, #0x66320e8
0066320D8  ldrb     w8, [x19, #0x20]
0066320DC  cbnz     w8, #0x66320e8
0066320E0  ldrb     w8, [x19, #0x21]
0066320E4  cbz      w8, #0x663210c
0066320E8  ldp      x20, x19, [sp, #0x10]
0066320EC  mov      w0, wzr
0066320F0  ldp      x30, x21, [sp], #0x20
0066320F4  ret      
0066320F8  ldr      x2, [x1, #0x60]
0066320FC  mov      x0, x19
006632100  ldp      x20, x19, [sp, #0x10]
006632104  ldp      x30, x21, [sp], #0x20
006632108  br       x2
00663210C  mov      x0, x19
006632110  ldp      x20, x19, [sp, #0x10]
006632114  ldp      x30, x21, [sp], #0x20
006632118  b        #0x6632120 ; HotFix.BattleLogic.WeightRandomData$$PracticalWeight
00663211C  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandomData$$PracticalWeight
; RVA 0x6632120; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632120  stp      x30, x21, [sp, #-0x20]!
006632124  stp      x20, x19, [sp, #0x10]
006632128  adrp     x20, #0x9599000
00663212C  adrp     x21, #0x8f0c000
006632130  ldrb     w8, [x20, #0x9c5]
006632134  ldr      x21, [x21, #0xec8]
006632138  mov      x19, x0
00663213C  tbnz     w8, #0, #0x6632154
006632140  adrp     x0, #0x8f0c000
006632144  ldr      x0, [x0, #0xec8]
006632148  bl       #0x382bd14 ; 
00663214C  mov      w8, #1
006632150  strb     w8, [x20, #0x9c5]
006632154  ldr      x1, [x21]
006632158  ldrb     w8, [x1, #0x53]
00663215C  tbnz     w8, #5, #0x6632180
006632160  ldr      x8, [x19, #0x18]
006632164  ldrsw    x9, [x19, #4]
006632168  ldp      x20, x19, [sp, #0x10]
00663216C  add      x8, x8, #0x10, lsl #12
006632170  mul      x8, x8, x9
006632174  lsr      x0, x8, #0x10
006632178  ldp      x30, x21, [sp], #0x20
00663217C  ret      
006632180  ldr      x2, [x1, #0x60]
006632184  mov      x0, x19
006632188  ldp      x20, x19, [sp, #0x10]
00663218C  ldp      x30, x21, [sp], #0x20
006632190  br       x2

; HotFix.BattleLogic.WeightRandomData$$UpdateDeltaWeightPercent
; RVA 0x6632194; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632194  str      x30, [sp, #-0x30]!
006632198  stp      x22, x21, [sp, #0x10]
00663219C  stp      x20, x19, [sp, #0x20]
0066321A0  adrp     x21, #0x9599000
0066321A4  adrp     x22, #0x8f0c000
0066321A8  ldrb     w8, [x21, #0x9c7]
0066321AC  ldr      x22, [x22, #0xed0]
0066321B0  mov      x19, x1
0066321B4  mov      x20, x0
0066321B8  tbnz     w8, #0, #0x66321d0
0066321BC  adrp     x0, #0x8f0c000
0066321C0  ldr      x0, [x0, #0xed0]
0066321C4  bl       #0x382bd14 ; 
0066321C8  mov      w8, #1
0066321CC  strb     w8, [x21, #0x9c7]
0066321D0  ldr      x2, [x22]
0066321D4  ldrb     w8, [x2, #0x53]
0066321D8  tbnz     w8, #5, #0x66321f0
0066321DC  str      x19, [x20, #0x18]
0066321E0  ldp      x20, x19, [sp, #0x20]
0066321E4  ldp      x22, x21, [sp, #0x10]
0066321E8  ldr      x30, [sp], #0x30
0066321EC  ret      
0066321F0  ldr      x3, [x2, #0x60]
0066321F4  mov      x0, x20
0066321F8  mov      x1, x19
0066321FC  ldp      x20, x19, [sp, #0x20]
006632200  ldp      x22, x21, [sp, #0x10]
006632204  ldr      x30, [sp], #0x30
006632208  br       x3

; HotFix.BattleLogic.WeightRandomData$$AddRejectFlag
; RVA 0x663220C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00663220C  str      x30, [sp, #-0x30]!
006632210  stp      x22, x21, [sp, #0x10]
006632214  stp      x20, x19, [sp, #0x20]
006632218  adrp     x21, #0x9599000
00663221C  adrp     x22, #0x8f0c000
006632220  ldrb     w8, [x21, #0x9c9]
006632224  ldr      x22, [x22, #0xed8]
006632228  mov      w20, w1
00663222C  mov      x19, x0
006632230  tbnz     w8, #0, #0x6632248
006632234  adrp     x0, #0x8f0c000
006632238  ldr      x0, [x0, #0xed8]
00663223C  bl       #0x382bd14 ; 
006632240  mov      w8, #1
006632244  strb     w8, [x21, #0x9c9]
006632248  ldr      x2, [x22]
00663224C  ldrb     w8, [x2, #0x53]
006632250  tbnz     w8, #5, #0x66322b0
006632254  cbz      w20, #0x663229c
006632258  ldr      x10, [x19, #0x10]
00663225C  cbz      x10, #0x663229c
006632260  ldr      w8, [x10, #0x18]
006632264  cmp      w8, #1
006632268  b.lt     #0x663229c
00663226C  mov      x9, xzr
006632270  add      x10, x10, #0x20
006632274  mov      w11, #1
006632278  cmp      w9, w8
00663227C  b.hs     #0x66322d8
006632280  ldr      w12, [x10, x9, lsl #2]
006632284  lsl      w12, w11, w12
006632288  cmp      w12, w20
00663228C  b.eq     #0x66322cc
006632290  add      x9, x9, #1
006632294  cmp      w9, w8
006632298  b.lt     #0x6632278
00663229C  mov      w0, wzr
0066322A0  ldp      x20, x19, [sp, #0x20]
0066322A4  ldp      x22, x21, [sp, #0x10]
0066322A8  ldr      x30, [sp], #0x30
0066322AC  ret      
0066322B0  ldr      x3, [x2, #0x60]
0066322B4  mov      x0, x19
0066322B8  mov      w1, w20
0066322BC  ldp      x20, x19, [sp, #0x20]
0066322C0  ldp      x22, x21, [sp, #0x10]
0066322C4  ldr      x30, [sp], #0x30
0066322C8  br       x3
0066322CC  mov      w0, #1
0066322D0  strb     w0, [x19, #0x20]
0066322D4  b        #0x66322a0 ; 
0066322D8  bl       #0x382bfc0 ; 

; HotFix.BattleLogic.WeightRandomData$$TryAddFlag
; RVA 0x66322DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066322DC  str      x30, [sp, #-0x30]!
0066322E0  stp      x22, x21, [sp, #0x10]
0066322E4  stp      x20, x19, [sp, #0x20]
0066322E8  adrp     x21, #0x9599000
0066322EC  adrp     x22, #0x8f0c000
0066322F0  ldrb     w8, [x21, #0x9cb]
0066322F4  ldr      x22, [x22, #0xee0]
0066322F8  mov      w20, w1
0066322FC  mov      x19, x0
006632300  tbnz     w8, #0, #0x6632318
006632304  adrp     x0, #0x8f0c000
006632308  ldr      x0, [x0, #0xee0]
00663230C  bl       #0x382bd14 ; 
006632310  mov      w8, #1
006632314  strb     w8, [x21, #0x9cb]
006632318  ldr      x2, [x22]
00663231C  ldrb     w8, [x2, #0x53]
006632320  tbnz     w8, #5, #0x6632350
006632324  ldr      w8, [x19, #0xc]
006632328  mov      w0, wzr
00663232C  cbz      w8, #0x6632340
006632330  cmp      w8, w20
006632334  b.ne     #0x6632340
006632338  mov      w0, #1
00663233C  str      wzr, [x19, #0xc]
006632340  ldp      x20, x19, [sp, #0x20]
006632344  ldp      x22, x21, [sp, #0x10]
006632348  ldr      x30, [sp], #0x30
00663234C  ret      
006632350  ldr      x3, [x2, #0x60]
006632354  mov      x0, x19
006632358  mov      w1, w20
00663235C  ldp      x20, x19, [sp, #0x20]
006632360  ldp      x22, x21, [sp, #0x10]
006632364  ldr      x30, [sp], #0x30
006632368  br       x3

; HotFix.BattleLogic.WeightRandomData$$AddRejectSkill
; RVA 0x663236C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00663236C  stp      x30, x21, [sp, #-0x20]!
006632370  stp      x20, x19, [sp, #0x10]
006632374  adrp     x20, #0x9599000
006632378  adrp     x21, #0x8f0c000
00663237C  ldrb     w8, [x20, #0x9cd]
006632380  ldr      x21, [x21, #0xee8]
006632384  mov      x19, x0
006632388  tbnz     w8, #0, #0x66323a0
00663238C  adrp     x0, #0x8f0c000
006632390  ldr      x0, [x0, #0xee8]
006632394  bl       #0x382bd14 ; 
006632398  mov      w8, #1
00663239C  strb     w8, [x20, #0x9cd]
0066323A0  ldr      x1, [x21]
0066323A4  ldrb     w8, [x1, #0x53]
0066323A8  tbnz     w8, #5, #0x66323bc
0066323AC  ldrb     w8, [x19, #0x21]
0066323B0  cbz      w8, #0x66323d0
0066323B4  mov      w0, wzr
0066323B8  b        #0x66323d8 ; 
0066323BC  ldr      x2, [x1, #0x60]
0066323C0  mov      x0, x19
0066323C4  ldp      x20, x19, [sp, #0x10]
0066323C8  ldp      x30, x21, [sp], #0x20
0066323CC  br       x2
0066323D0  mov      w0, #1
0066323D4  strb     w0, [x19, #0x21]
0066323D8  ldp      x20, x19, [sp, #0x10]
0066323DC  ldp      x30, x21, [sp], #0x20
0066323E0  ret      

; HotFix.BattleLogic.WeightRandomData$$BoostWeight
; RVA 0x66323E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066323E4  str      x30, [sp, #-0x30]!
0066323E8  stp      x22, x21, [sp, #0x10]
0066323EC  stp      x20, x19, [sp, #0x20]
0066323F0  adrp     x21, #0x9599000
0066323F4  adrp     x22, #0x8f0c000
0066323F8  ldrb     w8, [x21, #0x9cf]
0066323FC  ldr      x22, [x22, #0xef0]
006632400  mov      w20, w1
006632404  mov      x19, x0
006632408  tbnz     w8, #0, #0x6632420
00663240C  adrp     x0, #0x8f0c000
006632410  ldr      x0, [x0, #0xef0]
006632414  bl       #0x382bd14 ; 
006632418  mov      w8, #1
00663241C  strb     w8, [x21, #0x9cf]
006632420  ldr      x2, [x22]
006632424  ldrb     w8, [x2, #0x53]
006632428  tbnz     w8, #5, #0x6632460
00663242C  ldr      w8, [x19, #4]
006632430  mul      w9, w8, w20
006632434  cmp      w9, #0x64
006632438  b.lt     #0x663247c
00663243C  mov      w10, #0x851f
006632440  movk     w10, #0x51eb, lsl #16
006632444  smull    x9, w9, w10
006632448  lsr      x10, x9, #0x3f
00663244C  asr      x9, x9, #0x25
006632450  add      w0, w9, w10
006632454  add      w8, w0, w8
006632458  str      w8, [x19, #4]
00663245C  b        #0x6632480 ; 
006632460  ldr      x3, [x2, #0x60]
006632464  mov      x0, x19
006632468  mov      w1, w20
00663246C  ldp      x20, x19, [sp, #0x20]
006632470  ldp      x22, x21, [sp, #0x10]
006632474  ldr      x30, [sp], #0x30
006632478  br       x3
00663247C  mov      w0, wzr
006632480  ldp      x20, x19, [sp, #0x20]
006632484  ldp      x22, x21, [sp, #0x10]
006632488  ldr      x30, [sp], #0x30
00663248C  ret      

; HotFix.BattleLogic.WeightRandomData$$RevertWeightBoost
; RVA 0x6632490; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632490  str      x30, [sp, #-0x30]!
006632494  stp      x22, x21, [sp, #0x10]
006632498  stp      x20, x19, [sp, #0x20]
00663249C  adrp     x21, #0x9599000
0066324A0  adrp     x22, #0x8f0c000
0066324A4  ldrb     w8, [x21, #0x9d1]
0066324A8  ldr      x22, [x22, #0xef8]
0066324AC  mov      w19, w1
0066324B0  mov      x20, x0
0066324B4  tbnz     w8, #0, #0x66324cc
0066324B8  adrp     x0, #0x8f0c000
0066324BC  ldr      x0, [x0, #0xef8]
0066324C0  bl       #0x382bd14 ; 
0066324C4  mov      w8, #1
0066324C8  strb     w8, [x21, #0x9d1]
0066324CC  ldr      x2, [x22]
0066324D0  ldrb     w8, [x2, #0x53]
0066324D4  tbnz     w8, #5, #0x66324f4
0066324D8  ldr      w8, [x20, #4]
0066324DC  ldp      x22, x21, [sp, #0x10]
0066324E0  sub      w8, w8, w19
0066324E4  str      w8, [x20, #4]
0066324E8  ldp      x20, x19, [sp, #0x20]
0066324EC  ldr      x30, [sp], #0x30
0066324F0  ret      
0066324F4  ldr      x3, [x2, #0x60]
0066324F8  mov      x0, x20
0066324FC  mov      w1, w19
006632500  ldp      x20, x19, [sp, #0x20]
006632504  ldp      x22, x21, [sp, #0x10]
006632508  ldr      x30, [sp], #0x30
00663250C  br       x3

; HotFix.BattleLogic.WeightRandomData$$AddNeedSkill
; RVA 0x6632510; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632510  str      x30, [sp, #-0x30]!
006632514  stp      x22, x21, [sp, #0x10]
006632518  stp      x20, x19, [sp, #0x20]
00663251C  adrp     x21, #0x9599000
006632520  adrp     x22, #0x8f0c000
006632524  ldrb     w8, [x21, #0x9d3]
006632528  ldr      x22, [x22, #0xf00]
00663252C  mov      w20, w1
006632530  mov      x19, x0
006632534  tbnz     w8, #0, #0x6632570
006632538  adrp     x0, #0x8f08000
00663253C  ldr      x0, [x0, #0x630]
006632540  bl       #0x382bd14 ; 
006632544  adrp     x0, #0x8edb000
006632548  ldr      x0, [x0, #0x180]
00663254C  bl       #0x382bd14 ; 
006632550  adrp     x0, #0x8ec2000
006632554  ldr      x0, [x0, #0x268]
006632558  bl       #0x382bd14 ; 
00663255C  adrp     x0, #0x8f0c000
006632560  ldr      x0, [x0, #0xf00]
006632564  bl       #0x382bd14 ; 
006632568  mov      w8, #1
00663256C  strb     w8, [x21, #0x9d3]
006632570  ldr      x2, [x22]
006632574  ldrb     w8, [x2, #0x53]
006632578  tbnz     w8, #5, #0x66325dc
00663257C  ldr      x0, [x19, #0x28]
006632580  cbz      x0, #0x6632600
006632584  adrp     x8, #0x8f08000
006632588  ldr      x8, [x8, #0x630]
00663258C  mov      w1, w20
006632590  ldr      x2, [x8]
006632594  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006632598  tbz      w0, #0, #0x66325c8
00663259C  ldr      x0, [x19, #0x28]
0066325A0  cbz      x0, #0x6632600
0066325A4  adrp     x8, #0x8edb000
0066325A8  ldr      x8, [x8, #0x180]
0066325AC  mov      w1, w20
0066325B0  ldr      x2, [x8]
0066325B4  bl       #0x4d65db8 ; System.Collections.Generic.List<int>$$Remove
0066325B8  ldr      x8, [x19, #0x28]
0066325BC  cbz      x8, #0x6632600
0066325C0  ldr      w8, [x8, #0x18]
0066325C4  cbz      w8, #0x66325f8
0066325C8  mov      w0, wzr
0066325CC  ldp      x20, x19, [sp, #0x20]
0066325D0  ldp      x22, x21, [sp, #0x10]
0066325D4  ldr      x30, [sp], #0x30
0066325D8  ret      
0066325DC  ldr      x3, [x2, #0x60]
0066325E0  mov      x0, x19
0066325E4  mov      w1, w20
0066325E8  ldp      x20, x19, [sp, #0x20]
0066325EC  ldp      x22, x21, [sp, #0x10]
0066325F0  ldr      x30, [sp], #0x30
0066325F4  br       x3
0066325F8  mov      w0, #1
0066325FC  b        #0x66325cc ; 
006632600  bl       #0x382bfb8 ; 

; HotFix.BattleLogic.WeightRandomData$$CopyFrom
; RVA 0x6632604; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632604  str      x30, [sp, #-0x30]!
006632608  stp      x22, x21, [sp, #0x10]
00663260C  stp      x20, x19, [sp, #0x20]
006632610  adrp     x21, #0x9599000
006632614  adrp     x22, #0x8f0c000
006632618  ldrb     w8, [x21, #0x9d5]
00663261C  ldr      x22, [x22, #0xf08]
006632620  mov      x20, x1
006632624  mov      x19, x0
006632628  tbnz     w8, #0, #0x6632670
00663262C  adrp     x0, #0x8f08000
006632630  ldr      x0, [x0, #0xbb0]
006632634  bl       #0x382bd14 ; 
006632638  adrp     x0, #0x8ec2000
00663263C  ldr      x0, [x0, #0x240]
006632640  bl       #0x382bd14 ; 
006632644  adrp     x0, #0x8edb000
006632648  ldr      x0, [x0, #0x2f8]
00663264C  bl       #0x382bd14 ; 
006632650  adrp     x0, #0x8ec2000
006632654  ldr      x0, [x0, #0x2d0]
006632658  bl       #0x382bd14 ; 
00663265C  adrp     x0, #0x8f0c000
006632660  ldr      x0, [x0, #0xf08]
006632664  bl       #0x382bd14 ; 
006632668  mov      w8, #1
00663266C  strb     w8, [x21, #0x9d5]
006632670  ldr      x2, [x22]
006632674  ldrb     w8, [x2, #0x53]
006632678  tbnz     w8, #5, #0x66326cc
00663267C  ldr      q0, [x20]
006632680  mov      x0, x19
006632684  str      q0, [x19]
006632688  ldr      x1, [x20, #0x10]
00663268C  str      x1, [x0, #0x10]!
006632690  bl       #0x382bcb8 ; 
006632694  ldr      x9, [x20, #0x18]
006632698  ldr      x8, [x19, #0x28]!
00663269C  stur     x9, [x19, #-0x10]
0066326A0  ldrb     w9, [x20, #0x20]
0066326A4  sturb    w9, [x19, #-8]
0066326A8  ldrb     w9, [x20, #0x21]
0066326AC  sturb    w9, [x19, #-7]
0066326B0  ldrb     w9, [x20, #0x30]
0066326B4  strb     w9, [x19, #8]
0066326B8  cbz      x8, #0x66326e8
0066326BC  ldr      w9, [x8, #0x1c]
0066326C0  add      w9, w9, #1
0066326C4  stp      wzr, w9, [x8, #0x18]
0066326C8  b        #0x6632720 ; 
0066326CC  ldr      x3, [x2, #0x60]
0066326D0  mov      x0, x19
0066326D4  mov      x1, x20
0066326D8  ldp      x20, x19, [sp, #0x20]
0066326DC  ldp      x22, x21, [sp, #0x10]
0066326E0  ldr      x30, [sp], #0x30
0066326E4  br       x3
0066326E8  adrp     x8, #0x8ec2000
0066326EC  ldr      x8, [x8, #0x2d0]
0066326F0  ldr      x0, [x8]
0066326F4  bl       #0x382bfa0 ; 
0066326F8  adrp     x8, #0x8edb000
0066326FC  ldr      x8, [x8, #0x2f8]
006632700  mov      w1, #0xa
006632704  mov      x21, x0
006632708  ldr      x2, [x8]
00663270C  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
006632710  mov      x0, x19
006632714  mov      x1, x21
006632718  str      x21, [x19]
00663271C  bl       #0x382bcb8 ; 
006632720  ldr      x1, [x20, #0x28]
006632724  cbz      x1, #0x663274c
006632728  ldr      x0, [x19]
00663272C  cbz      x0, #0x663275c
006632730  adrp     x8, #0x8f08000
006632734  ldr      x8, [x8, #0xbb0]
006632738  ldp      x20, x19, [sp, #0x20]
00663273C  ldp      x22, x21, [sp, #0x10]
006632740  ldr      x2, [x8]
006632744  ldr      x30, [sp], #0x30
006632748  b        #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
00663274C  ldp      x20, x19, [sp, #0x20]
006632750  ldp      x22, x21, [sp, #0x10]
006632754  ldr      x30, [sp], #0x30
006632758  ret      
00663275C  bl       #0x382bfb8 ; 

