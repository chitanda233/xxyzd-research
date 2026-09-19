; HotFix.BattleLogic.PlayerPunchboard$$Init
; RVA 0x659F280; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659F280  stp      x30, x23, [sp, #-0x30]!
00659F284  stp      x22, x21, [sp, #0x10]
00659F288  stp      x20, x19, [sp, #0x20]
00659F28C  adrp     x20, #0x9599000
00659F290  adrp     x21, #0x8f09000
00659F294  ldrb     w8, [x20, #0x35e]
00659F298  ldr      x21, [x21, #0x60]
00659F29C  mov      x19, x0
00659F2A0  tbnz     w8, #0, #0x659f300
00659F2A4  adrp     x0, #0x8f09000
00659F2A8  ldr      x0, [x0, #0x68]
00659F2AC  bl       #0x382bd14 ; 
00659F2B0  adrp     x0, #0x8ec2000
00659F2B4  ldr      x0, [x0, #0x240]
00659F2B8  bl       #0x382bd14 ; 
00659F2BC  adrp     x0, #0x8edb000
00659F2C0  ldr      x0, [x0, #0x2f8]
00659F2C4  bl       #0x382bd14 ; 
00659F2C8  adrp     x0, #0x8f09000
00659F2CC  ldr      x0, [x0, #0x70]
00659F2D0  bl       #0x382bd14 ; 
00659F2D4  adrp     x0, #0x8ec2000
00659F2D8  ldr      x0, [x0, #0x2d0]
00659F2DC  bl       #0x382bd14 ; 
00659F2E0  adrp     x0, #0x8f09000
00659F2E4  ldr      x0, [x0, #0x78]
00659F2E8  bl       #0x382bd14 ; 
00659F2EC  adrp     x0, #0x8f09000
00659F2F0  ldr      x0, [x0, #0x60]
00659F2F4  bl       #0x382bd14 ; 
00659F2F8  mov      w8, #1
00659F2FC  strb     w8, [x20, #0x35e]
00659F300  ldr      x1, [x21]
00659F304  ldrb     w8, [x1, #0x53]
00659F308  tbnz     w8, #5, #0x659f398
00659F30C  mov      x20, x19
00659F310  ldr      x8, [x20, #0x20]!
00659F314  cbz      x8, #0x659f3b0
00659F318  ldr      w9, [x8, #0x1c]
00659F31C  add      w9, w9, #1
00659F320  stp      wzr, w9, [x8, #0x18]
00659F324  ldr      x8, [x19, #0x28]
00659F328  cbz      x8, #0x659f4c4
00659F32C  ldr      w9, [x8, #0x1c]
00659F330  add      w9, w9, #1
00659F334  stp      wzr, w9, [x8, #0x18]
00659F338  ldr      x8, [x19, #0x30]
00659F33C  cbz      x8, #0x659f4c4
00659F340  ldr      w9, [x8, #0x1c]
00659F344  add      w9, w9, #1
00659F348  stp      wzr, w9, [x8, #0x18]
00659F34C  ldr      x8, [x19, #0x38]
00659F350  cbz      x8, #0x659f4c4
00659F354  ldr      w9, [x8, #0x1c]
00659F358  add      w9, w9, #1
00659F35C  stp      wzr, w9, [x8, #0x18]
00659F360  ldr      x8, [x19, #0x40]
00659F364  cbz      x8, #0x659f4c4
00659F368  ldr      w9, [x8, #0x1c]
00659F36C  add      w9, w9, #1
00659F370  stp      wzr, w9, [x8, #0x18]
00659F374  ldr      x8, [x19, #0x48]
00659F378  cbz      x8, #0x659f4c4
00659F37C  ldr      w9, [x8, #0x1c]
00659F380  ldp      x20, x19, [sp, #0x20]
00659F384  ldp      x22, x21, [sp, #0x10]
00659F388  add      w9, w9, #1
00659F38C  stp      wzr, w9, [x8, #0x18]
00659F390  ldp      x30, x23, [sp], #0x30
00659F394  ret      
00659F398  ldr      x2, [x1, #0x60]
00659F39C  mov      x0, x19
00659F3A0  ldp      x20, x19, [sp, #0x20]
00659F3A4  ldp      x22, x21, [sp, #0x10]
00659F3A8  ldp      x30, x23, [sp], #0x30
00659F3AC  br       x2
00659F3B0  adrp     x22, #0x8ec2000
00659F3B4  ldr      x22, [x22, #0x2d0]
00659F3B8  ldr      x0, [x22]
00659F3BC  bl       #0x382bfa0 ; 
00659F3C0  adrp     x23, #0x8edb000
00659F3C4  ldr      x23, [x23, #0x2f8]
00659F3C8  mov      w1, #0x10
00659F3CC  mov      x21, x0
00659F3D0  ldr      x2, [x23]
00659F3D4  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
00659F3D8  mov      x0, x20
00659F3DC  mov      x1, x21
00659F3E0  str      x21, [x19, #0x20]
00659F3E4  bl       #0x382bcb8 ; 
00659F3E8  ldr      x0, [x22]
00659F3EC  bl       #0x382bfa0 ; 
00659F3F0  ldr      x2, [x23]
00659F3F4  mov      w1, #0x10
00659F3F8  mov      x20, x0
00659F3FC  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
00659F400  mov      x0, x19
00659F404  str      x20, [x0, #0x28]!
00659F408  mov      x1, x20
00659F40C  bl       #0x382bcb8 ; 
00659F410  ldr      x0, [x22]
00659F414  bl       #0x382bfa0 ; 
00659F418  ldr      x2, [x23]
00659F41C  mov      w1, #0x10
00659F420  mov      x20, x0
00659F424  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
00659F428  mov      x0, x19
00659F42C  str      x20, [x0, #0x30]!
00659F430  mov      x1, x20
00659F434  bl       #0x382bcb8 ; 
00659F438  ldr      x0, [x22]
00659F43C  bl       #0x382bfa0 ; 
00659F440  ldr      x2, [x23]
00659F444  mov      w1, #0x10
00659F448  mov      x20, x0
00659F44C  bl       #0x4d63d70 ; System.Collections.Generic.List<int>$$.ctor
00659F450  mov      x0, x19
00659F454  str      x20, [x0, #0x38]!
00659F458  mov      x1, x20
00659F45C  bl       #0x382bcb8 ; 
00659F460  adrp     x21, #0x8f09000
00659F464  ldr      x21, [x21, #0x78]
00659F468  ldr      x0, [x21]
00659F46C  bl       #0x382bfa0 ; 
00659F470  adrp     x22, #0x8f09000
00659F474  ldr      x22, [x22, #0x70]
00659F478  mov      x20, x0
00659F47C  ldr      x1, [x22]
00659F480  bl       #0x4dd4fd8 ; System.Collections.Generic.List<PunchboardSkillRandomData>$$.ctor
00659F484  mov      x0, x19
00659F488  str      x20, [x0, #0x40]!
00659F48C  mov      x1, x20
00659F490  bl       #0x382bcb8 ; 
00659F494  ldr      x0, [x21]
00659F498  bl       #0x382bfa0 ; 
00659F49C  ldr      x1, [x22]
00659F4A0  mov      x20, x0
00659F4A4  bl       #0x4dd4fd8 ; System.Collections.Generic.List<PunchboardSkillRandomData>$$.ctor
00659F4A8  str      x20, [x19, #0x48]!
00659F4AC  mov      x0, x19
00659F4B0  mov      x1, x20
00659F4B4  ldp      x20, x19, [sp, #0x20]
00659F4B8  ldp      x22, x21, [sp, #0x10]
00659F4BC  ldp      x30, x23, [sp], #0x30
00659F4C0  b        #0x382bcb8 ; 
00659F4C4  bl       #0x382bfb8 ; 

