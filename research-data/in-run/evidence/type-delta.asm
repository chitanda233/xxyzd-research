; HotFix.BattleLogic.HeroComponentRandomSkill$$GetDeltaWeightPercent
; RVA 0x6869E9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006869E9C  str      x30, [sp, #-0x30]!
006869EA0  stp      x22, x21, [sp, #0x10]
006869EA4  stp      x20, x19, [sp, #0x20]
006869EA8  adrp     x21, #0x959b000
006869EAC  adrp     x22, #0x8f24000
006869EB0  ldrb     w8, [x21, #0xa6a]
006869EB4  ldr      x22, [x22, #8]
006869EB8  mov      w19, w1
006869EBC  mov      x20, x0
006869EC0  tbnz     w8, #0, #0x6869f14
006869EC4  adrp     x0, #0x8f24000
006869EC8  ldr      x0, [x0, #8]
006869ECC  bl       #0x382bd14 ; 
006869ED0  adrp     x0, #0x8ebf000
006869ED4  ldr      x0, [x0, #0xba0]
006869ED8  bl       #0x382bd14 ; 
006869EDC  adrp     x0, #0x8ee1000
006869EE0  ldr      x0, [x0, #0x6e8]
006869EE4  bl       #0x382bd14 ; 
006869EE8  adrp     x0, #0x8f24000
006869EEC  ldr      x0, [x0, #0x10]
006869EF0  bl       #0x382bd14 ; 
006869EF4  adrp     x0, #0x8f24000
006869EF8  ldr      x0, [x0, #0x18]
006869EFC  bl       #0x382bd14 ; 
006869F00  adrp     x0, #0x8f24000
006869F04  ldr      x0, [x0, #0x20]
006869F08  bl       #0x382bd14 ; 
006869F0C  mov      w8, #1
006869F10  strb     w8, [x21, #0xa6a]
006869F14  ldr      x2, [x22]
006869F18  ldrb     w8, [x2, #0x53]
006869F1C  tbnz     w8, #5, #0x6869f5c
006869F20  adrp     x21, #0x9591000
006869F24  ldrb     w8, [x21, #0xa4b]
006869F28  cbnz     w8, #0x6869f40
006869F2C  adrp     x0, #0x8ee5000
006869F30  ldr      x0, [x0, #0xb28]
006869F34  bl       #0x382bd14 ; 
006869F38  mov      w8, #1
006869F3C  strb     w8, [x21, #0xa4b]
006869F40  adrp     x8, #0x8ee5000
006869F44  ldr      x8, [x8, #0xb28]
006869F48  ldr      x1, [x8]
006869F4C  ldrb     w8, [x1, #0x53]
006869F50  tbnz     w8, #5, #0x6869f78
006869F54  ldr      x21, [x20, #0x20]
006869F58  b        #0x6869f88 ; 
006869F5C  ldr      x3, [x2, #0x60]
006869F60  mov      x0, x20
006869F64  mov      w1, w19
006869F68  ldp      x20, x19, [sp, #0x20]
006869F6C  ldp      x22, x21, [sp, #0x10]
006869F70  ldr      x30, [sp], #0x30
006869F74  br       x3
006869F78  ldr      x8, [x1, #0x60]
006869F7C  mov      x0, x20
006869F80  blr      x8
006869F84  mov      x21, x0
006869F88  cbz      x21, #0x686a178
006869F8C  adrp     x22, #0x9598000
006869F90  ldrb     w8, [x22, #0xfcc]
006869F94  cbnz     w8, #0x6869fac
006869F98  adrp     x0, #0x8f06000
006869F9C  ldr      x0, [x0, #0x470]
006869FA0  bl       #0x382bd14 ; 
006869FA4  mov      w8, #1
006869FA8  strb     w8, [x22, #0xfcc]
006869FAC  adrp     x8, #0x8f06000
006869FB0  ldr      x8, [x8, #0x470]
006869FB4  ldr      x1, [x8]
006869FB8  ldrb     w8, [x1, #0x53]
006869FBC  tbnz     w8, #5, #0x6869fc8
006869FC0  ldr      x0, [x21, #0x200]
006869FC4  b        #0x6869fd4 ; 
006869FC8  ldr      x8, [x1, #0x60]
006869FCC  mov      x0, x21
006869FD0  blr      x8
006869FD4  cbz      x0, #0x686a178
006869FD8  mov      w1, w19
006869FDC  mov      x2, xzr
006869FE0  bl       #0x64db89c ; LocalModels.LocalModelManager$$GetSkill_SkillTypeWeight
006869FE4  cbz      x0, #0x686a038
006869FE8  mov      x21, x0
006869FEC  mov      x0, x20
006869FF0  mov      w1, w19
006869FF4  bl       #0x6871660 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillCountByType
006869FF8  adrp     x20, #0x959b000
006869FFC  ldrb     w8, [x20, #0xbb4]
00686A000  mov      w19, w0
00686A004  cbnz     w8, #0x686a01c
00686A008  adrp     x0, #0x8f24000
00686A00C  ldr      x0, [x0, #0x28]
00686A010  bl       #0x382bd14 ; 
00686A014  mov      w8, #1
00686A018  strb     w8, [x20, #0xbb4]
00686A01C  adrp     x8, #0x8f24000
00686A020  ldr      x8, [x8, #0x28]
00686A024  ldr      x1, [x8]
00686A028  ldrb     w8, [x1, #0x53]
00686A02C  tbnz     w8, #5, #0x686a0bc
00686A030  ldr      w0, [x21, #0x24]
00686A034  b        #0x686a0c8 ; 
00686A038  adrp     x8, #0x8ebf000
00686A03C  ldr      x8, [x8, #0xba0]
00686A040  add      x1, sp, #0xc
00686A044  str      w19, [sp, #0xc]
00686A048  ldr      x0, [x8]
00686A04C  bl       #0x382be94 ; 
00686A050  adrp     x8, #0x8f24000
00686A054  ldr      x8, [x8, #0x18]
00686A058  mov      x1, x0
00686A05C  mov      x2, xzr
00686A060  ldr      x8, [x8]
00686A064  mov      x0, x8
00686A068  bl       #0x79d140c ; System.String$$Format
00686A06C  adrp     x8, #0x8ee1000
00686A070  ldr      x8, [x8, #0x6e8]
00686A074  mov      x19, x0
00686A078  ldr      x8, [x8]
00686A07C  ldr      w9, [x8, #0xe0]
00686A080  cbnz     w9, #0x686a08c
00686A084  mov      x0, x8
00686A088  bl       #0x382be8c ; 
00686A08C  adrp     x8, #0x8f24000
00686A090  adrp     x9, #0x8f24000
00686A094  ldr      x8, [x8, #0x10]
00686A098  ldr      x9, [x9, #0x20]
00686A09C  mov      w3, #0x85
00686A0A0  mov      x0, x19
00686A0A4  ldr      x1, [x8]
00686A0A8  ldr      x2, [x9]
00686A0AC  mov      x4, xzr
00686A0B0  bl       #0x7997754 ; Logger$$LogError
00686A0B4  mov      x0, xzr
00686A0B8  b        #0x686a168 ; 
00686A0BC  ldr      x8, [x1, #0x60]
00686A0C0  mov      x0, x21
00686A0C4  blr      x8
00686A0C8  mov      x9, #0xd70b
00686A0CC  movk     x9, #0x70a3, lsl #16
00686A0D0  movk     x9, #0xa3d, lsl #32
00686A0D4  lsl      x8, x0, #0x20
00686A0D8  movk     x9, #0xa3d7, lsl #48
00686A0DC  adrp     x22, #0x959b000
00686A0E0  smulh    x8, x8, x9
00686A0E4  ldrb     w9, [x22, #0xbb5]
00686A0E8  add      x8, x8, x0, lsl #32
00686A0EC  asr      x10, x8, #0x16
00686A0F0  add      x20, x10, x8, lsr #63
00686A0F4  sxtw     x19, w19
00686A0F8  cbnz     w9, #0x686a110
00686A0FC  adrp     x0, #0x8f24000
00686A100  ldr      x0, [x0, #0x30]
00686A104  bl       #0x382bd14 ; 
00686A108  mov      w8, #1
00686A10C  strb     w8, [x22, #0xbb5]
00686A110  adrp     x8, #0x8f24000
00686A114  ldr      x8, [x8, #0x30]
00686A118  mul      x19, x20, x19
00686A11C  ldr      x1, [x8]
00686A120  ldrb     w8, [x1, #0x53]
00686A124  tbnz     w8, #5, #0x686a130
00686A128  ldr      w0, [x21, #0x28]
00686A12C  b        #0x686a13c ; 
00686A130  ldr      x8, [x1, #0x60]
00686A134  mov      x0, x21
00686A138  blr      x8
00686A13C  mov      x9, #0xd70b
00686A140  movk     x9, #0x70a3, lsl #16
00686A144  movk     x9, #0xa3d, lsl #32
00686A148  lsl      x8, x0, #0x20
00686A14C  movk     x9, #0xa3d7, lsl #48
00686A150  smulh    x8, x8, x9
00686A154  add      x8, x8, x0, lsl #32
00686A158  asr      x9, x8, #0x16
00686A15C  add      x8, x9, x8, lsr #63
00686A160  cmp      x19, x8
00686A164  csel     x0, x19, x8, lt
00686A168  ldp      x20, x19, [sp, #0x20]
00686A16C  ldp      x22, x21, [sp, #0x10]
00686A170  ldr      x30, [sp], #0x30
00686A174  ret      
00686A178  bl       #0x382bfb8 ; 

