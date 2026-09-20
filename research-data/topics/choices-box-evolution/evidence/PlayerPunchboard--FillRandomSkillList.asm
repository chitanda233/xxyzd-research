; HotFix.BattleLogic.PlayerPunchboard$$FillRandomSkillList
; RVA 0x65A3CEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065A3CEC  str      x30, [sp, #-0x50]!
0065A3CF0  stp      x26, x25, [sp, #0x10]
0065A3CF4  stp      x24, x23, [sp, #0x20]
0065A3CF8  stp      x22, x21, [sp, #0x30]
0065A3CFC  stp      x20, x19, [sp, #0x40]
0065A3D00  adrp     x22, #0x9599000
0065A3D04  adrp     x23, #0x8f09000
0065A3D08  ldrb     w8, [x22, #0x361]
0065A3D0C  ldr      x23, [x23, #0x2a8] ; GLOBAL Method$HotFix.BattleLogic.PlayerPunchboard.FillRandomSkillList() @ 0x929a320
0065A3D10  mov      x19, x2
0065A3D14  mov      w20, w1
0065A3D18  mov      x21, x0
0065A3D1C  tbnz     w8, #0, #0x65a3d70
0065A3D20  adrp     x0, #0x8f08000
0065A3D24  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
0065A3D28  bl       #0x382bd14 ; 
0065A3D2C  adrp     x0, #0x8f09000
0065A3D30  ldr      x0, [x0, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
0065A3D34  bl       #0x382bd14 ; 
0065A3D38  adrp     x0, #0x8ec2000
0065A3D3C  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
0065A3D40  bl       #0x382bd14 ; 
0065A3D44  adrp     x0, #0x8f09000
0065A3D48  ldr      x0, [x0, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
0065A3D4C  bl       #0x382bd14 ; 
0065A3D50  adrp     x0, #0x8ec2000
0065A3D54  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
0065A3D58  bl       #0x382bd14 ; 
0065A3D5C  adrp     x0, #0x8f09000
0065A3D60  ldr      x0, [x0, #0x2a8] ; GLOBAL Method$HotFix.BattleLogic.PlayerPunchboard.FillRandomSkillList() @ 0x929a320
0065A3D64  bl       #0x382bd14 ; 
0065A3D68  mov      w8, #1
0065A3D6C  strb     w8, [x22, #0x361]
0065A3D70  ldr      x3, [x23]
0065A3D74  ldrb     w8, [x3, #0x53]
0065A3D78  tbnz     w8, #5, #0x65a3f00
0065A3D7C  ldr      x0, [x21, #0x38]
0065A3D80  cbz      x0, #0x65a3fd4
0065A3D84  ldr      w8, [x0, #0x18]
0065A3D88  cmp      w8, w20
0065A3D8C  csel     w24, w8, w20, lt
0065A3D90  cmp      w24, #1
0065A3D94  b.lt     #0x65a3e2c
0065A3D98  adrp     x23, #0x8f09000
0065A3D9C  adrp     x25, #0x8f09000
0065A3DA0  ldr      x23, [x23, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
0065A3DA4  ldr      x25, [x25, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
0065A3DA8  mov      w22, wzr
0065A3DAC  ldr      x0, [x21, #0x40]
0065A3DB0  cbz      x0, #0x65a3fd4
0065A3DB4  ldr      x2, [x23]
0065A3DB8  mov      w1, w22
0065A3DBC  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
0065A3DC0  cbz      x19, #0x65a3fd4
0065A3DC4  ldr      w10, [x19, #0x1c]
0065A3DC8  ldr      x8, [x19, #0x10]
0065A3DCC  ldr      x9, [x25]
0065A3DD0  add      w10, w10, #1
0065A3DD4  str      w10, [x19, #0x1c]
0065A3DD8  cbz      x8, #0x65a3fd4
0065A3DDC  ldrsw    x10, [x19, #0x18]
0065A3DE0  ldr      w11, [x8, #0x18]
0065A3DE4  mov      x1, x0
0065A3DE8  cmp      w10, w11
0065A3DEC  b.hs     #0x65a3e04
0065A3DF0  add      w9, w10, #1
0065A3DF4  add      x8, x8, x10, lsl #3
0065A3DF8  str      w9, [x19, #0x18]
0065A3DFC  str      x1, [x8, #0x20]
0065A3E00  b        #0x65a3e18 ; 
0065A3E04  ldr      x8, [x9, #0x20]
0065A3E08  mov      x0, x19
0065A3E0C  ldr      x8, [x8, #0xc0]
0065A3E10  ldr      x2, [x8, #0x70]
0065A3E14  bl       #0x4dd582c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$AddWithResize
0065A3E18  add      w22, w22, #1
0065A3E1C  cmp      w24, w22
0065A3E20  b.ne     #0x65a3dac
0065A3E24  ldr      x0, [x21, #0x38]
0065A3E28  cbz      x0, #0x65a3fd4
0065A3E2C  adrp     x8, #0x8f08000
0065A3E30  ldr      x1, [x21, #0x30]
0065A3E34  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
0065A3E38  ldr      x2, [x8]
0065A3E3C  bl       #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
0065A3E40  ldr      x0, [x21, #0x30]
0065A3E44  cbz      x0, #0x65a3fd4
0065A3E48  adrp     x25, #0x8ec2000
0065A3E4C  adrp     x26, #0x8f09000
0065A3E50  ldr      x25, [x25, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
0065A3E54  ldr      x26, [x26, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
0065A3E58  mov      w22, wzr
0065A3E5C  ldr      w8, [x0, #0x18]
0065A3E60  cmp      w22, w8
0065A3E64  b.ge     #0x65a3f28
0065A3E68  ldr      x2, [x25]
0065A3E6C  mov      w1, w22
0065A3E70  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065A3E74  ldr      x8, [x21, #0x30]
0065A3E78  cbz      x8, #0x65a3fd4
0065A3E7C  ldr      x2, [x25]
0065A3E80  mov      w23, w0
0065A3E84  mov      x0, x8
0065A3E88  mov      w1, w22
0065A3E8C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065A3E90  ldr      x8, [x21, #0x40]
0065A3E94  cbz      x8, #0x65a3fd4
0065A3E98  ldr      w11, [x8, #0x1c]
0065A3E9C  ldr      x9, [x8, #0x10]
0065A3EA0  ldr      x10, [x26]
0065A3EA4  add      w11, w11, #1
0065A3EA8  str      w11, [x8, #0x1c]
0065A3EAC  cbz      x9, #0x65a3fd4
0065A3EB0  ldrsw    x11, [x8, #0x18]
0065A3EB4  ldr      w12, [x9, #0x18]
0065A3EB8  mov      w1, w23
0065A3EBC  bfi      x1, x0, #0x20, #0x20
0065A3EC0  cmp      w11, w12
0065A3EC4  b.hs     #0x65a3edc
0065A3EC8  add      w10, w11, #1
0065A3ECC  add      x9, x9, x11, lsl #3
0065A3ED0  str      w10, [x8, #0x18]
0065A3ED4  str      x1, [x9, #0x20]
0065A3ED8  b        #0x65a3ef0 ; 
0065A3EDC  ldr      x9, [x10, #0x20]
0065A3EE0  mov      x0, x8
0065A3EE4  ldr      x9, [x9, #0xc0]
0065A3EE8  ldr      x2, [x9, #0x70]
0065A3EEC  bl       #0x4dd582c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$AddWithResize
0065A3EF0  ldr      x0, [x21, #0x30]
0065A3EF4  add      w22, w22, #1
0065A3EF8  cbnz     x0, #0x65a3e5c
0065A3EFC  b        #0x65a3fd4 ; 
0065A3F00  ldr      x4, [x3, #0x60]
0065A3F04  mov      x0, x21
0065A3F08  mov      w1, w20
0065A3F0C  mov      x2, x19
0065A3F10  ldp      x20, x19, [sp, #0x40]
0065A3F14  ldp      x22, x21, [sp, #0x30]
0065A3F18  ldp      x24, x23, [sp, #0x20]
0065A3F1C  ldp      x26, x25, [sp, #0x10]
0065A3F20  ldr      x30, [sp], #0x50
0065A3F24  br       x4
0065A3F28  sub      w24, w20, w24
0065A3F2C  cmp      w24, #1
0065A3F30  b.lt     #0x65a3fd8
0065A3F34  cbz      x0, #0x65a3fd4
0065A3F38  mov      w22, wzr
0065A3F3C  ldr      x2, [x25]
0065A3F40  mov      w1, w22
0065A3F44  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065A3F48  ldr      x8, [x21, #0x30]
0065A3F4C  cbz      x8, #0x65a3fd4
0065A3F50  ldr      x2, [x25]
0065A3F54  mov      w23, w0
0065A3F58  mov      x0, x8
0065A3F5C  mov      w1, w22
0065A3F60  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065A3F64  cbz      x19, #0x65a3fd4
0065A3F68  ldr      w10, [x19, #0x1c]
0065A3F6C  ldr      x8, [x19, #0x10]
0065A3F70  ldr      x9, [x26]
0065A3F74  add      w10, w10, #1
0065A3F78  str      w10, [x19, #0x1c]
0065A3F7C  cbz      x8, #0x65a3fd4
0065A3F80  ldrsw    x10, [x19, #0x18]
0065A3F84  ldr      w11, [x8, #0x18]
0065A3F88  mov      w1, w23
0065A3F8C  bfi      x1, x0, #0x20, #0x20
0065A3F90  cmp      w10, w11
0065A3F94  b.hs     #0x65a3fac
0065A3F98  add      w9, w10, #1
0065A3F9C  add      x8, x8, x10, lsl #3
0065A3FA0  str      w9, [x19, #0x18]
0065A3FA4  str      x1, [x8, #0x20]
0065A3FA8  b        #0x65a3fc0 ; 
0065A3FAC  ldr      x8, [x9, #0x20]
0065A3FB0  mov      x0, x19
0065A3FB4  ldr      x8, [x8, #0xc0]
0065A3FB8  ldr      x2, [x8, #0x70]
0065A3FBC  bl       #0x4dd582c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$AddWithResize
0065A3FC0  add      w22, w22, #1
0065A3FC4  cmp      w24, w22
0065A3FC8  b.eq     #0x65a3fd8
0065A3FCC  ldr      x0, [x21, #0x30]
0065A3FD0  cbnz     x0, #0x65a3f3c
0065A3FD4  bl       #0x382bfb8 ; 
0065A3FD8  mov      w0, w20
0065A3FDC  ldp      x20, x19, [sp, #0x40]
0065A3FE0  ldp      x22, x21, [sp, #0x30]
0065A3FE4  ldp      x24, x23, [sp, #0x20]
0065A3FE8  ldp      x26, x25, [sp, #0x10]
0065A3FEC  ldr      x30, [sp], #0x50
0065A3FF0  ret      

