; HotFix.BattleLogic.HeroComponentRandomSkill$$GetNormalSkill
; RVA 0x686E0A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686E0A0  sub      sp, sp, #0x70
00686E0A4  str      x30, [sp, #0x10]
00686E0A8  stp      x28, x27, [sp, #0x20]
00686E0AC  stp      x26, x25, [sp, #0x30]
00686E0B0  stp      x24, x23, [sp, #0x40]
00686E0B4  stp      x22, x21, [sp, #0x50]
00686E0B8  stp      x20, x19, [sp, #0x60]
00686E0BC  adrp     x24, #0x959b000
00686E0C0  adrp     x26, #0x8f24000
00686E0C4  ldrb     w8, [x24, #0xa58]
00686E0C8  ldr      x26, [x26, #0x218]
00686E0CC  mov      x19, x5
00686E0D0  mov      w25, w4
00686E0D4  mov      w21, w3
00686E0D8  mov      w22, w2
00686E0DC  mov      x20, x1
00686E0E0  mov      x23, x0
00686E0E4  tbnz     w8, #0, #0x686e12c
00686E0E8  adrp     x0, #0x8ee8000
00686E0EC  ldr      x0, [x0, #0x898]
00686E0F0  bl       #0x382bd14 ; 
00686E0F4  adrp     x0, #0x8ee6000
00686E0F8  ldr      x0, [x0, #0xd8]
00686E0FC  bl       #0x382bd14 ; 
00686E100  adrp     x0, #0x8f23000
00686E104  ldr      x0, [x0, #0x140]
00686E108  bl       #0x382bd14 ; 
00686E10C  adrp     x0, #0x8f24000
00686E110  ldr      x0, [x0, #0x218]
00686E114  bl       #0x382bd14 ; 
00686E118  adrp     x0, #0x8f24000
00686E11C  ldr      x0, [x0, #0x220]
00686E120  bl       #0x382bd14 ; 
00686E124  mov      w8, #1
00686E128  strb     w8, [x24, #0xa58]
00686E12C  ldr      x6, [x26]
00686E130  ldrb     w8, [x6, #0x53]
00686E134  tbnz     w8, #5, #0x686e174
00686E138  adrp     x26, #0x9591000
00686E13C  ldrb     w8, [x26, #0xa4b]
00686E140  cbnz     w8, #0x686e158
00686E144  adrp     x0, #0x8ee5000
00686E148  ldr      x0, [x0, #0xb28]
00686E14C  bl       #0x382bd14 ; 
00686E150  mov      w8, #1
00686E154  strb     w8, [x26, #0xa4b]
00686E158  adrp     x27, #0x8ee5000
00686E15C  ldr      x27, [x27, #0xb28]
00686E160  ldr      x1, [x27]
00686E164  ldrb     w8, [x1, #0x53]
00686E168  tbnz     w8, #5, #0x686e1b0
00686E16C  ldr      x0, [x23, #0x20]
00686E170  b        #0x686e1bc ; 
00686E174  ldr      x7, [x6, #0x60]
00686E178  and      w2, w22, #1
00686E17C  and      w3, w21, #1
00686E180  mov      x0, x23
00686E184  mov      x1, x20
00686E188  mov      w4, w25
00686E18C  mov      x5, x19
00686E190  ldp      x20, x19, [sp, #0x60]
00686E194  ldp      x22, x21, [sp, #0x50]
00686E198  ldp      x24, x23, [sp, #0x40]
00686E19C  ldp      x26, x25, [sp, #0x30]
00686E1A0  ldp      x28, x27, [sp, #0x20]
00686E1A4  ldr      x30, [sp, #0x10]
00686E1A8  add      sp, sp, #0x70
00686E1AC  br       x7
00686E1B0  ldr      x8, [x1, #0x60]
00686E1B4  mov      x0, x23
00686E1B8  blr      x8
00686E1BC  cbz      x0, #0x686e560
00686E1C0  mov      x1, xzr
00686E1C4  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
00686E1C8  tbz      w0, #0, #0x686e200
00686E1CC  ldrb     w8, [x26, #0xa4b]
00686E1D0  ldr      x24, [x23, #0xb0]
00686E1D4  cbnz     w8, #0x686e1ec
00686E1D8  adrp     x0, #0x8ee5000
00686E1DC  ldr      x0, [x0, #0xb28]
00686E1E0  bl       #0x382bd14 ; 
00686E1E4  mov      w8, #1
00686E1E8  strb     w8, [x26, #0xa4b]
00686E1EC  ldr      x1, [x27]
00686E1F0  ldrb     w8, [x1, #0x53]
00686E1F4  tbnz     w8, #5, #0x686e220
00686E1F8  ldr      x26, [x23, #0x20]
00686E1FC  b        #0x686e230 ; 
00686E200  adrp     x25, #0x8ee8000
00686E204  ldr      x25, [x25, #0x898]
00686E208  ldr      x24, [x23, #0xa8]
00686E20C  ldr      x0, [x25]
00686E210  ldr      w8, [x0, #0xe0]
00686E214  cbz      w8, #0x686e368
00686E218  mov      x1, x24
00686E21C  b        #0x686e374 ; 
00686E220  ldr      x8, [x1, #0x60]
00686E224  mov      x0, x23
00686E228  blr      x8
00686E22C  mov      x26, x0
00686E230  cbz      x26, #0x686e560
00686E234  adrp     x27, #0x9598000
00686E238  ldrb     w8, [x27, #0xfcc]
00686E23C  cbnz     w8, #0x686e254
00686E240  adrp     x0, #0x8f06000
00686E244  ldr      x0, [x0, #0x470]
00686E248  bl       #0x382bd14 ; 
00686E24C  mov      w8, #1
00686E250  strb     w8, [x27, #0xfcc]
00686E254  adrp     x8, #0x8f06000
00686E258  ldr      x8, [x8, #0x470]
00686E25C  ldr      x1, [x8]
00686E260  ldrb     w8, [x1, #0x53]
00686E264  tbnz     w8, #5, #0x686e270
00686E268  ldr      x0, [x26, #0x200]
00686E26C  b        #0x686e27c ; 
00686E270  ldr      x8, [x1, #0x60]
00686E274  mov      x0, x26
00686E278  blr      x8
00686E27C  cbz      x0, #0x686e560
00686E280  mov      w1, w25
00686E284  mov      x2, xzr
00686E288  bl       #0x64e564c ; LocalModels.LocalModelManager$$GetExp_exp
00686E28C  adrp     x28, #0x8ee8000
00686E290  ldr      x28, [x28, #0x898]
00686E294  mov      x25, x0
00686E298  ldr      x8, [x28]
00686E29C  ldr      w9, [x8, #0xe0]
00686E2A0  cbnz     w9, #0x686e2ac
00686E2A4  mov      x0, x8
00686E2A8  bl       #0x382be8c ; 
00686E2AC  mov      x0, xzr
00686E2B0  bl       #0x64cb688 ; LocalModels.Const$$GetDankeSkillWeight
00686E2B4  ldr      x26, [x23, #0xb0]
00686E2B8  mov      x27, x0
00686E2BC  mov      x0, xzr
00686E2C0  bl       #0x64cb688 ; LocalModels.Const$$GetDankeSkillWeight
00686E2C4  cbz      x0, #0x686e560
00686E2C8  ldr      w2, [x0, #0x18]
00686E2CC  mov      x0, x27
00686E2D0  mov      x1, x26
00686E2D4  mov      x3, xzr
00686E2D8  bl       #0x7c01418 ; System.Array$$Copy
00686E2DC  cbz      x25, #0x686e560
00686E2E0  adrp     x26, #0x959b000
00686E2E4  ldrb     w8, [x26, #0xbb2]
00686E2E8  cbnz     w8, #0x686e300
00686E2EC  adrp     x0, #0x8f24000
00686E2F0  ldr      x0, [x0, #0x228]
00686E2F4  bl       #0x382bd14 ; 
00686E2F8  mov      w8, #1
00686E2FC  strb     w8, [x26, #0xbb2]
00686E300  adrp     x8, #0x8f24000
00686E304  ldr      x8, [x8, #0x228]
00686E308  ldr      x1, [x8]
00686E30C  ldrb     w8, [x1, #0x53]
00686E310  tbnz     w8, #5, #0x686e31c
00686E314  ldr      x25, [x25, #0x28]
00686E318  b        #0x686e32c ; 
00686E31C  ldr      x8, [x1, #0x60]
00686E320  mov      x0, x25
00686E324  blr      x8
00686E328  mov      x25, x0
00686E32C  ldr      x0, [x23, #0x88]
00686E330  cbz      x0, #0x686e560
00686E334  ldr      x8, [x0]
00686E338  ldr      x9, [x8, #0x248]
00686E33C  ldr      x1, [x8, #0x250]
00686E340  blr      x9
00686E344  tbz      w0, #0, #0x686e38c
00686E348  ldr      x0, [x28]
00686E34C  ldr      w8, [x0, #0xe0]
00686E350  cbnz     w8, #0x686e35c
00686E354  bl       #0x382be8c ; 
00686E358  ldr      x0, [x28]
00686E35C  ldr      x8, [x0, #0xb8]
00686E360  ldr      x25, [x8, #0x3b8]
00686E364  b        #0x686e38c ; 
00686E368  bl       #0x382be8c ; 
00686E36C  ldr      x0, [x25]
00686E370  ldr      x1, [x23, #0xa8]
00686E374  ldr      x8, [x0, #0xb8]
00686E378  mov      x3, xzr
00686E37C  ldr      x0, [x8, #0x1c0]
00686E380  ldr      w2, [x8, #0x2f0]
00686E384  bl       #0x7c01418 ; System.Array$$Copy
00686E388  mov      x25, xzr
00686E38C  adrp     x8, #0x8f23000
00686E390  ldr      x8, [x8, #0x140]
00686E394  ldr      x1, [x8]
00686E398  ldrb     w8, [x1, #0x53]
00686E39C  tbnz     w8, #5, #0x686e3a8
00686E3A0  ldr      x0, [x23, #0x30]
00686E3A4  b        #0x686e3b4 ; 
00686E3A8  ldr      x8, [x1, #0x60]
00686E3AC  mov      x0, x23
00686E3B0  blr      x8
00686E3B4  cbz      x0, #0x686e560
00686E3B8  adrp     x8, #0x8ee6000
00686E3BC  ldr      x8, [x8, #0xd8]
00686E3C0  ldr      x1, [x8]
00686E3C4  ldrb     w8, [x1, #0x53]
00686E3C8  tbnz     w8, #5, #0x686e3d4
00686E3CC  ldr      x26, [x0, #0x38]
00686E3D0  b        #0x686e3e0 ; 
00686E3D4  ldr      x8, [x1, #0x60]
00686E3D8  blr      x8
00686E3DC  mov      x26, x0
00686E3E0  cbz      x26, #0x686e560
00686E3E4  adrp     x27, #0x9591000
00686E3E8  ldrb     w8, [x27, #0xa7f]
00686E3EC  cbnz     w8, #0x686e404
00686E3F0  adrp     x0, #0x8ee6000
00686E3F4  ldr      x0, [x0, #0x2d8]
00686E3F8  bl       #0x382bd14 ; 
00686E3FC  mov      w8, #1
00686E400  strb     w8, [x27, #0xa7f]
00686E404  adrp     x8, #0x8ee6000
00686E408  ldr      x8, [x8, #0x2d8]
00686E40C  ldr      x1, [x8]
00686E410  ldrb     w8, [x1, #0x53]
00686E414  tbnz     w8, #5, #0x686e420
00686E418  ldr      x0, [x26, #0x178]
00686E41C  b        #0x686e42c ; 
00686E420  ldr      x8, [x1, #0x60]
00686E424  mov      x0, x26
00686E428  blr      x8
00686E42C  cbz      x0, #0x686e560
00686E430  adrp     x8, #0x8f24000
00686E434  ldr      x8, [x8, #0x220]
00686E438  mov      x2, xzr
00686E43C  ldr      x1, [x8]
00686E440  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686E444  cmp      x0, #1
00686E448  b.lt     #0x686e4b8
00686E44C  ldr      x27, [x23, #0xa8]
00686E450  cbz      x27, #0x686e560
00686E454  ldr      w8, [x27, #0x18]
00686E458  cmp      w8, #1
00686E45C  b.ls     #0x686e564
00686E460  ldrsw    x8, [x27, #0x24]
00686E464  add      x26, x0, #0x10, lsl #12
00686E468  mov      x1, xzr
00686E46C  mul      x0, x26, x8
00686E470  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686E474  ldr      w8, [x27, #0x18]
00686E478  cmp      w8, #1
00686E47C  b.ls     #0x686e564
00686E480  str      w0, [x27, #0x24]
00686E484  ldr      x27, [x23, #0xa8]
00686E488  cbz      x27, #0x686e560
00686E48C  ldr      w8, [x27, #0x18]
00686E490  cmp      w8, #2
00686E494  b.ls     #0x686e564
00686E498  ldrsw    x8, [x27, #0x28]
00686E49C  mov      x1, xzr
00686E4A0  mul      x0, x26, x8
00686E4A4  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686E4A8  ldr      w8, [x27, #0x18]
00686E4AC  cmp      w8, #2
00686E4B0  b.ls     #0x686e564
00686E4B4  str      w0, [x27, #0x28]
00686E4B8  adrp     x27, #0x9599000
00686E4BC  ldrb     w8, [x27, #0x4c7]
00686E4C0  ldr      x26, [x23, #0x88]
00686E4C4  cbnz     w8, #0x686e4dc
00686E4C8  adrp     x0, #0x8f09000
00686E4CC  ldr      x0, [x0, #0xc8]
00686E4D0  bl       #0x382bd14 ; 
00686E4D4  mov      w8, #1
00686E4D8  strb     w8, [x27, #0x4c7]
00686E4DC  adrp     x8, #0x8f09000
00686E4E0  ldr      x8, [x8, #0xc8]
00686E4E4  ldr      x1, [x8]
00686E4E8  ldrb     w8, [x1, #0x53]
00686E4EC  tbnz     w8, #5, #0x686e4f8
00686E4F0  ldr      x5, [x23, #0x58]
00686E4F4  b        #0x686e508 ; 
00686E4F8  ldr      x8, [x1, #0x60]
00686E4FC  mov      x0, x23
00686E500  blr      x8
00686E504  mov      x5, x0
00686E508  cbz      x26, #0x686e560
00686E50C  ldr      x8, [x26]
00686E510  and      w2, w21, #1
00686E514  and      w4, w22, #1
00686E518  mov      x0, x26
00686E51C  ldr      x9, [x8, #0x238]
00686E520  ldr      x8, [x8, #0x240]
00686E524  mov      x1, x20
00686E528  mov      x3, x24
00686E52C  mov      x6, x19
00686E530  mov      x7, x25
00686E534  str      x8, [sp]
00686E538  blr      x9
00686E53C  ldp      x20, x19, [sp, #0x60]
00686E540  ldp      x22, x21, [sp, #0x50]
00686E544  ldp      x24, x23, [sp, #0x40]
00686E548  ldp      x26, x25, [sp, #0x30]
00686E54C  ldp      x28, x27, [sp, #0x20]
00686E550  ldr      x30, [sp, #0x10]
00686E554  and      w0, w0, #1
00686E558  add      sp, sp, #0x70
00686E55C  ret      
00686E560  bl       #0x382bfb8 ; 
00686E564  bl       #0x382bfc0 ; 

