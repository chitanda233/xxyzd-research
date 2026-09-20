; LocalModels.Bean.SkillGroup_InitSurvivorGroup$$GetWeightByGroup
; RVA 0x6AF9E9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF9E9C  str      x30, [sp, #-0x30]!
006AF9EA0  stp      x22, x21, [sp, #0x10]
006AF9EA4  stp      x20, x19, [sp, #0x20]
006AF9EA8  adrp     x21, #0x959f000
006AF9EAC  adrp     x22, #0x8f3d000
006AF9EB0  ldrb     w8, [x21, #0x2ee]
006AF9EB4  ldr      x22, [x22, #0xd40] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.GetWeightByGroup() @ 0x92ab3a8
006AF9EB8  mov      w20, w1
006AF9EBC  mov      x19, x0
006AF9EC0  tbnz     w8, #0, #0x6af9ed8
006AF9EC4  adrp     x0, #0x8f3d000
006AF9EC8  ldr      x0, [x0, #0xd40] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.GetWeightByGroup() @ 0x92ab3a8
006AF9ECC  bl       #0x382bd14 ; 
006AF9ED0  mov      w8, #1
006AF9ED4  strb     w8, [x21, #0x2ee]
006AF9ED8  ldr      x2, [x22]
006AF9EDC  ldrb     w8, [x2, #0x53]
006AF9EE0  tbnz     w8, #5, #0x6af9f44
006AF9EE4  sub      w8, w20, #1
006AF9EE8  cmp      w8, #9
006AF9EEC  b.hi     #0x6af9f60
006AF9EF0  adrp     x9, #0x1a72000
006AF9EF4  add      x9, x9, #0x709
006AF9EF8  adr      x10, #0x6af9f08
006AF9EFC  ldrb     w11, [x9, x8]
006AF9F00  add      x10, x10, x11, lsl #2
006AF9F04  br       x10
006AF9F08  adrp     x20, #0x959f000
006AF9F0C  ldrb     w8, [x20, #0x88f]
006AF9F10  cbnz     w8, #0x6af9f28
006AF9F14  adrp     x0, #0x8f3d000
006AF9F18  ldr      x0, [x0, #0xc78] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_1() @ 0x92ab3d8
006AF9F1C  bl       #0x382bd14 ; 
006AF9F20  mov      w8, #1
006AF9F24  strb     w8, [x20, #0x88f]
006AF9F28  adrp     x8, #0x8f3d000
006AF9F2C  ldr      x8, [x8, #0xc78] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_1() @ 0x92ab3d8
006AF9F30  ldr      x1, [x8]
006AF9F34  ldrb     w8, [x1, #0x53]
006AF9F38  tbnz     w8, #5, #0x6afa1c4
006AF9F3C  ldr      w0, [x19, #0x2c]
006AF9F40  b        #0x6afa1b4 ; 
006AF9F44  ldr      x3, [x2, #0x60]
006AF9F48  mov      x0, x19
006AF9F4C  mov      w1, w20
006AF9F50  ldp      x20, x19, [sp, #0x20]
006AF9F54  ldp      x22, x21, [sp, #0x10]
006AF9F58  ldr      x30, [sp], #0x30
006AF9F5C  br       x3
006AF9F60  adrp     x20, #0x959f000
006AF9F64  ldrb     w8, [x20, #0x899]
006AF9F68  cbnz     w8, #0x6af9f80
006AF9F6C  adrp     x0, #0x8f3d000
006AF9F70  ldr      x0, [x0, #0xc68] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight() @ 0x92ab3c8
006AF9F74  bl       #0x382bd14 ; 
006AF9F78  mov      w8, #1
006AF9F7C  strb     w8, [x20, #0x899]
006AF9F80  adrp     x8, #0x8f3d000
006AF9F84  ldr      x8, [x8, #0xc68] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight() @ 0x92ab3c8
006AF9F88  ldr      x1, [x8]
006AF9F8C  ldrb     w8, [x1, #0x53]
006AF9F90  tbnz     w8, #5, #0x6afa1c4
006AF9F94  ldr      w0, [x19, #0x28]
006AF9F98  b        #0x6afa1b4 ; 
006AF9F9C  adrp     x20, #0x959f000
006AF9FA0  ldrb     w8, [x20, #0x890]
006AF9FA4  cbnz     w8, #0x6af9fbc
006AF9FA8  adrp     x0, #0x8f3d000
006AF9FAC  ldr      x0, [x0, #0xc88] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_2() @ 0x92ab3e8
006AF9FB0  bl       #0x382bd14 ; 
006AF9FB4  mov      w8, #1
006AF9FB8  strb     w8, [x20, #0x890]
006AF9FBC  adrp     x8, #0x8f3d000
006AF9FC0  ldr      x8, [x8, #0xc88] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_2() @ 0x92ab3e8
006AF9FC4  ldr      x1, [x8]
006AF9FC8  ldrb     w8, [x1, #0x53]
006AF9FCC  tbnz     w8, #5, #0x6afa1c4
006AF9FD0  ldr      w0, [x19, #0x30]
006AF9FD4  b        #0x6afa1b4 ; 
006AF9FD8  adrp     x20, #0x959f000
006AF9FDC  ldrb     w8, [x20, #0x891]
006AF9FE0  cbnz     w8, #0x6af9ff8
006AF9FE4  adrp     x0, #0x8f3d000
006AF9FE8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_3() @ 0x92ab3f0
006AF9FEC  bl       #0x382bd14 ; 
006AF9FF0  mov      w8, #1
006AF9FF4  strb     w8, [x20, #0x891]
006AF9FF8  adrp     x8, #0x8f3d000
006AF9FFC  ldr      x8, [x8, #0xc98] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_3() @ 0x92ab3f0
006AFA000  ldr      x1, [x8]
006AFA004  ldrb     w8, [x1, #0x53]
006AFA008  tbnz     w8, #5, #0x6afa1c4
006AFA00C  ldr      w0, [x19, #0x34]
006AFA010  b        #0x6afa1b4 ; 
006AFA014  adrp     x20, #0x959f000
006AFA018  ldrb     w8, [x20, #0x892]
006AFA01C  cbnz     w8, #0x6afa034
006AFA020  adrp     x0, #0x8f3d000
006AFA024  ldr      x0, [x0, #0xca8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_4() @ 0x92ab3f8
006AFA028  bl       #0x382bd14 ; 
006AFA02C  mov      w8, #1
006AFA030  strb     w8, [x20, #0x892]
006AFA034  adrp     x8, #0x8f3d000
006AFA038  ldr      x8, [x8, #0xca8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_4() @ 0x92ab3f8
006AFA03C  ldr      x1, [x8]
006AFA040  ldrb     w8, [x1, #0x53]
006AFA044  tbnz     w8, #5, #0x6afa1c4
006AFA048  ldr      w0, [x19, #0x38]
006AFA04C  b        #0x6afa1b4 ; 
006AFA050  adrp     x20, #0x959f000
006AFA054  ldrb     w8, [x20, #0x893]
006AFA058  cbnz     w8, #0x6afa070
006AFA05C  adrp     x0, #0x8f3d000
006AFA060  ldr      x0, [x0, #0xcb8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_5() @ 0x92ab400
006AFA064  bl       #0x382bd14 ; 
006AFA068  mov      w8, #1
006AFA06C  strb     w8, [x20, #0x893]
006AFA070  adrp     x8, #0x8f3d000
006AFA074  ldr      x8, [x8, #0xcb8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_5() @ 0x92ab400
006AFA078  ldr      x1, [x8]
006AFA07C  ldrb     w8, [x1, #0x53]
006AFA080  tbnz     w8, #5, #0x6afa1c4
006AFA084  ldr      w0, [x19, #0x3c]
006AFA088  b        #0x6afa1b4 ; 
006AFA08C  adrp     x20, #0x959f000
006AFA090  ldrb     w8, [x20, #0x894]
006AFA094  cbnz     w8, #0x6afa0ac
006AFA098  adrp     x0, #0x8f3d000
006AFA09C  ldr      x0, [x0, #0xcc8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_6() @ 0x92ab408
006AFA0A0  bl       #0x382bd14 ; 
006AFA0A4  mov      w8, #1
006AFA0A8  strb     w8, [x20, #0x894]
006AFA0AC  adrp     x8, #0x8f3d000
006AFA0B0  ldr      x8, [x8, #0xcc8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_6() @ 0x92ab408
006AFA0B4  ldr      x1, [x8]
006AFA0B8  ldrb     w8, [x1, #0x53]
006AFA0BC  tbnz     w8, #5, #0x6afa1c4
006AFA0C0  ldr      w0, [x19, #0x40]
006AFA0C4  b        #0x6afa1b4 ; 
006AFA0C8  adrp     x20, #0x959f000
006AFA0CC  ldrb     w8, [x20, #0x895]
006AFA0D0  cbnz     w8, #0x6afa0e8
006AFA0D4  adrp     x0, #0x8f3d000
006AFA0D8  ldr      x0, [x0, #0xcd8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_7() @ 0x92ab410
006AFA0DC  bl       #0x382bd14 ; 
006AFA0E0  mov      w8, #1
006AFA0E4  strb     w8, [x20, #0x895]
006AFA0E8  adrp     x8, #0x8f3d000
006AFA0EC  ldr      x8, [x8, #0xcd8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_7() @ 0x92ab410
006AFA0F0  ldr      x1, [x8]
006AFA0F4  ldrb     w8, [x1, #0x53]
006AFA0F8  tbnz     w8, #5, #0x6afa1c4
006AFA0FC  ldr      w0, [x19, #0x44]
006AFA100  b        #0x6afa1b4 ; 
006AFA104  adrp     x20, #0x959f000
006AFA108  ldrb     w8, [x20, #0x896]
006AFA10C  cbnz     w8, #0x6afa124
006AFA110  adrp     x0, #0x8f3d000
006AFA114  ldr      x0, [x0, #0xce8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_8() @ 0x92ab418
006AFA118  bl       #0x382bd14 ; 
006AFA11C  mov      w8, #1
006AFA120  strb     w8, [x20, #0x896]
006AFA124  adrp     x8, #0x8f3d000
006AFA128  ldr      x8, [x8, #0xce8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_8() @ 0x92ab418
006AFA12C  ldr      x1, [x8]
006AFA130  ldrb     w8, [x1, #0x53]
006AFA134  tbnz     w8, #5, #0x6afa1c4
006AFA138  ldr      w0, [x19, #0x48]
006AFA13C  b        #0x6afa1b4 ; 
006AFA140  adrp     x20, #0x959f000
006AFA144  ldrb     w8, [x20, #0x897]
006AFA148  cbnz     w8, #0x6afa160
006AFA14C  adrp     x0, #0x8f3d000
006AFA150  ldr      x0, [x0, #0xcf8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_9() @ 0x92ab420
006AFA154  bl       #0x382bd14 ; 
006AFA158  mov      w8, #1
006AFA15C  strb     w8, [x20, #0x897]
006AFA160  adrp     x8, #0x8f3d000
006AFA164  ldr      x8, [x8, #0xcf8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_9() @ 0x92ab420
006AFA168  ldr      x1, [x8]
006AFA16C  ldrb     w8, [x1, #0x53]
006AFA170  tbnz     w8, #5, #0x6afa1c4
006AFA174  ldr      w0, [x19, #0x4c]
006AFA178  b        #0x6afa1b4 ; 
006AFA17C  adrp     x20, #0x959f000
006AFA180  ldrb     w8, [x20, #0x898]
006AFA184  cbnz     w8, #0x6afa19c
006AFA188  adrp     x0, #0x8f3d000
006AFA18C  ldr      x0, [x0, #0xd08] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_10() @ 0x92ab3e0
006AFA190  bl       #0x382bd14 ; 
006AFA194  mov      w8, #1
006AFA198  strb     w8, [x20, #0x898]
006AFA19C  adrp     x8, #0x8f3d000
006AFA1A0  ldr      x8, [x8, #0xd08] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InitSurvivorGroup.get_Weight_10() @ 0x92ab3e0
006AFA1A4  ldr      x1, [x8]
006AFA1A8  ldrb     w8, [x1, #0x53]
006AFA1AC  tbnz     w8, #5, #0x6afa1c4
006AFA1B0  ldr      w0, [x19, #0x50]
006AFA1B4  ldp      x20, x19, [sp, #0x20]
006AFA1B8  ldp      x22, x21, [sp, #0x10]
006AFA1BC  ldr      x30, [sp], #0x30
006AFA1C0  ret      
006AFA1C4  ldr      x2, [x1, #0x60]
006AFA1C8  mov      x0, x19
006AFA1CC  ldp      x20, x19, [sp, #0x20]
006AFA1D0  ldp      x22, x21, [sp, #0x10]
006AFA1D4  ldr      x30, [sp], #0x30
006AFA1D8  br       x2

