; LocalModels.Bean.SkillGroup_SurvivorGroup$$readImpl
; RVA 0x6AFBFB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFBFB0  stp      x30, x21, [sp, #-0x20]!
006AFBFB4  stp      x20, x19, [sp, #0x10]
006AFBFB8  adrp     x20, #0x959f000
006AFBFBC  adrp     x21, #0x8f3d000
006AFBFC0  ldrb     w8, [x20, #0x32b]
006AFBFC4  ldr      x21, [x21, #0xef8]
006AFBFC8  mov      x19, x0
006AFBFCC  tbnz     w8, #0, #0x6afbfe4
006AFBFD0  adrp     x0, #0x8f3d000
006AFBFD4  ldr      x0, [x0, #0xef8]
006AFBFD8  bl       #0x382bd14 ; 
006AFBFDC  mov      w8, #1
006AFBFE0  strb     w8, [x20, #0x32b]
006AFBFE4  ldr      x1, [x21]
006AFBFE8  ldrb     w8, [x1, #0x53]
006AFBFEC  tbnz     w8, #5, #0x6afc03c
006AFBFF0  mov      x0, x19
006AFBFF4  mov      x1, xzr
006AFBFF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFBFFC  adrp     x21, #0x959f000
006AFC000  ldrb     w8, [x21, #0x8a5]
006AFC004  mov      w20, w0
006AFC008  cbnz     w8, #0x6afc020
006AFC00C  adrp     x0, #0x8f3d000
006AFC010  ldr      x0, [x0, #0xe18]
006AFC014  bl       #0x382bd14 ; 
006AFC018  mov      w8, #1
006AFC01C  strb     w8, [x21, #0x8a5]
006AFC020  adrp     x8, #0x8f3d000
006AFC024  ldr      x8, [x8, #0xe18]
006AFC028  ldr      x2, [x8]
006AFC02C  ldrb     w8, [x2, #0x53]
006AFC030  tbnz     w8, #5, #0x6afc050
006AFC034  str      w20, [x19, #0x20]
006AFC038  b        #0x6afc060 ; 
006AFC03C  ldr      x2, [x1, #0x60]
006AFC040  mov      x0, x19
006AFC044  ldp      x20, x19, [sp, #0x10]
006AFC048  ldp      x30, x21, [sp], #0x20
006AFC04C  br       x2
006AFC050  ldr      x8, [x2, #0x60]
006AFC054  mov      x0, x19
006AFC058  mov      w1, w20
006AFC05C  blr      x8
006AFC060  mov      x0, x19
006AFC064  mov      x1, xzr
006AFC068  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC06C  adrp     x21, #0x959f000
006AFC070  ldrb     w8, [x21, #0x8a6]
006AFC074  mov      w20, w0
006AFC078  cbnz     w8, #0x6afc090
006AFC07C  adrp     x0, #0x8f3d000
006AFC080  ldr      x0, [x0, #0xe20]
006AFC084  bl       #0x382bd14 ; 
006AFC088  mov      w8, #1
006AFC08C  strb     w8, [x21, #0x8a6]
006AFC090  adrp     x8, #0x8f3d000
006AFC094  ldr      x8, [x8, #0xe20]
006AFC098  ldr      x2, [x8]
006AFC09C  ldrb     w8, [x2, #0x53]
006AFC0A0  tbnz     w8, #5, #0x6afc0ac
006AFC0A4  str      w20, [x19, #0x24]
006AFC0A8  b        #0x6afc0bc ; 
006AFC0AC  ldr      x8, [x2, #0x60]
006AFC0B0  mov      x0, x19
006AFC0B4  mov      w1, w20
006AFC0B8  blr      x8
006AFC0BC  mov      x0, x19
006AFC0C0  mov      x1, xzr
006AFC0C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AFC0C8  adrp     x21, #0x959f000
006AFC0CC  ldrb     w8, [x21, #0x8a7]
006AFC0D0  mov      x20, x0
006AFC0D4  cbnz     w8, #0x6afc0ec
006AFC0D8  adrp     x0, #0x8f3d000
006AFC0DC  ldr      x0, [x0, #0xe30]
006AFC0E0  bl       #0x382bd14 ; 
006AFC0E4  mov      w8, #1
006AFC0E8  strb     w8, [x21, #0x8a7]
006AFC0EC  adrp     x8, #0x8f3d000
006AFC0F0  ldr      x8, [x8, #0xe30]
006AFC0F4  ldr      x2, [x8]
006AFC0F8  ldrb     w8, [x2, #0x53]
006AFC0FC  tbnz     w8, #5, #0x6afc114
006AFC100  mov      x0, x19
006AFC104  str      x20, [x0, #0x28]!
006AFC108  mov      x1, x20
006AFC10C  bl       #0x382bcb8 ; 
006AFC110  b        #0x6afc124 ; 
006AFC114  ldr      x8, [x2, #0x60]
006AFC118  mov      x0, x19
006AFC11C  mov      x1, x20
006AFC120  blr      x8
006AFC124  mov      x0, x19
006AFC128  mov      x1, xzr
006AFC12C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC130  adrp     x21, #0x959f000
006AFC134  ldrb     w8, [x21, #0x8a8]
006AFC138  mov      w20, w0
006AFC13C  cbnz     w8, #0x6afc154
006AFC140  adrp     x0, #0x8f3d000
006AFC144  ldr      x0, [x0, #0xe40]
006AFC148  bl       #0x382bd14 ; 
006AFC14C  mov      w8, #1
006AFC150  strb     w8, [x21, #0x8a8]
006AFC154  adrp     x8, #0x8f3d000
006AFC158  ldr      x8, [x8, #0xe40]
006AFC15C  ldr      x2, [x8]
006AFC160  ldrb     w8, [x2, #0x53]
006AFC164  tbnz     w8, #5, #0x6afc170
006AFC168  str      w20, [x19, #0x30]
006AFC16C  b        #0x6afc180 ; 
006AFC170  ldr      x8, [x2, #0x60]
006AFC174  mov      x0, x19
006AFC178  mov      w1, w20
006AFC17C  blr      x8
006AFC180  mov      x0, x19
006AFC184  mov      x1, xzr
006AFC188  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC18C  adrp     x21, #0x959f000
006AFC190  ldrb     w8, [x21, #0x8a9]
006AFC194  mov      w20, w0
006AFC198  cbnz     w8, #0x6afc1b0
006AFC19C  adrp     x0, #0x8f3d000
006AFC1A0  ldr      x0, [x0, #0xe50]
006AFC1A4  bl       #0x382bd14 ; 
006AFC1A8  mov      w8, #1
006AFC1AC  strb     w8, [x21, #0x8a9]
006AFC1B0  adrp     x8, #0x8f3d000
006AFC1B4  ldr      x8, [x8, #0xe50]
006AFC1B8  ldr      x2, [x8]
006AFC1BC  ldrb     w8, [x2, #0x53]
006AFC1C0  tbnz     w8, #5, #0x6afc1cc
006AFC1C4  str      w20, [x19, #0x34]
006AFC1C8  b        #0x6afc1dc ; 
006AFC1CC  ldr      x8, [x2, #0x60]
006AFC1D0  mov      x0, x19
006AFC1D4  mov      w1, w20
006AFC1D8  blr      x8
006AFC1DC  mov      x0, x19
006AFC1E0  mov      x1, xzr
006AFC1E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC1E8  adrp     x21, #0x959f000
006AFC1EC  ldrb     w8, [x21, #0x8aa]
006AFC1F0  mov      w20, w0
006AFC1F4  cbnz     w8, #0x6afc20c
006AFC1F8  adrp     x0, #0x8f3d000
006AFC1FC  ldr      x0, [x0, #0xe60]
006AFC200  bl       #0x382bd14 ; 
006AFC204  mov      w8, #1
006AFC208  strb     w8, [x21, #0x8aa]
006AFC20C  adrp     x8, #0x8f3d000
006AFC210  ldr      x8, [x8, #0xe60]
006AFC214  ldr      x2, [x8]
006AFC218  ldrb     w8, [x2, #0x53]
006AFC21C  tbnz     w8, #5, #0x6afc228
006AFC220  str      w20, [x19, #0x38]
006AFC224  b        #0x6afc238 ; 
006AFC228  ldr      x8, [x2, #0x60]
006AFC22C  mov      x0, x19
006AFC230  mov      w1, w20
006AFC234  blr      x8
006AFC238  mov      x0, x19
006AFC23C  mov      x1, xzr
006AFC240  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC244  adrp     x21, #0x959f000
006AFC248  ldrb     w8, [x21, #0x8ab]
006AFC24C  mov      w20, w0
006AFC250  cbnz     w8, #0x6afc268
006AFC254  adrp     x0, #0x8f3d000
006AFC258  ldr      x0, [x0, #0xe70]
006AFC25C  bl       #0x382bd14 ; 
006AFC260  mov      w8, #1
006AFC264  strb     w8, [x21, #0x8ab]
006AFC268  adrp     x8, #0x8f3d000
006AFC26C  ldr      x8, [x8, #0xe70]
006AFC270  ldr      x2, [x8]
006AFC274  ldrb     w8, [x2, #0x53]
006AFC278  tbnz     w8, #5, #0x6afc284
006AFC27C  str      w20, [x19, #0x3c]
006AFC280  b        #0x6afc294 ; 
006AFC284  ldr      x8, [x2, #0x60]
006AFC288  mov      x0, x19
006AFC28C  mov      w1, w20
006AFC290  blr      x8
006AFC294  mov      x0, x19
006AFC298  mov      x1, xzr
006AFC29C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC2A0  adrp     x21, #0x959f000
006AFC2A4  ldrb     w8, [x21, #0x8ac]
006AFC2A8  mov      w20, w0
006AFC2AC  cbnz     w8, #0x6afc2c4
006AFC2B0  adrp     x0, #0x8f3d000
006AFC2B4  ldr      x0, [x0, #0xe80]
006AFC2B8  bl       #0x382bd14 ; 
006AFC2BC  mov      w8, #1
006AFC2C0  strb     w8, [x21, #0x8ac]
006AFC2C4  adrp     x8, #0x8f3d000
006AFC2C8  ldr      x8, [x8, #0xe80]
006AFC2CC  ldr      x2, [x8]
006AFC2D0  ldrb     w8, [x2, #0x53]
006AFC2D4  tbnz     w8, #5, #0x6afc2e0
006AFC2D8  str      w20, [x19, #0x40]
006AFC2DC  b        #0x6afc2f0 ; 
006AFC2E0  ldr      x8, [x2, #0x60]
006AFC2E4  mov      x0, x19
006AFC2E8  mov      w1, w20
006AFC2EC  blr      x8
006AFC2F0  mov      x0, x19
006AFC2F4  mov      x1, xzr
006AFC2F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC2FC  adrp     x21, #0x959f000
006AFC300  ldrb     w8, [x21, #0x8ad]
006AFC304  mov      w20, w0
006AFC308  cbnz     w8, #0x6afc320
006AFC30C  adrp     x0, #0x8f3d000
006AFC310  ldr      x0, [x0, #0xe90]
006AFC314  bl       #0x382bd14 ; 
006AFC318  mov      w8, #1
006AFC31C  strb     w8, [x21, #0x8ad]
006AFC320  adrp     x8, #0x8f3d000
006AFC324  ldr      x8, [x8, #0xe90]
006AFC328  ldr      x2, [x8]
006AFC32C  ldrb     w8, [x2, #0x53]
006AFC330  tbnz     w8, #5, #0x6afc33c
006AFC334  str      w20, [x19, #0x44]
006AFC338  b        #0x6afc34c ; 
006AFC33C  ldr      x8, [x2, #0x60]
006AFC340  mov      x0, x19
006AFC344  mov      w1, w20
006AFC348  blr      x8
006AFC34C  mov      x0, x19
006AFC350  mov      x1, xzr
006AFC354  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC358  adrp     x21, #0x959f000
006AFC35C  ldrb     w8, [x21, #0x8ae]
006AFC360  mov      w20, w0
006AFC364  cbnz     w8, #0x6afc37c
006AFC368  adrp     x0, #0x8f3d000
006AFC36C  ldr      x0, [x0, #0xea0]
006AFC370  bl       #0x382bd14 ; 
006AFC374  mov      w8, #1
006AFC378  strb     w8, [x21, #0x8ae]
006AFC37C  adrp     x8, #0x8f3d000
006AFC380  ldr      x8, [x8, #0xea0]
006AFC384  ldr      x2, [x8]
006AFC388  ldrb     w8, [x2, #0x53]
006AFC38C  tbnz     w8, #5, #0x6afc398
006AFC390  str      w20, [x19, #0x48]
006AFC394  b        #0x6afc3a8 ; 
006AFC398  ldr      x8, [x2, #0x60]
006AFC39C  mov      x0, x19
006AFC3A0  mov      w1, w20
006AFC3A4  blr      x8
006AFC3A8  mov      x0, x19
006AFC3AC  mov      x1, xzr
006AFC3B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC3B4  adrp     x21, #0x959f000
006AFC3B8  ldrb     w8, [x21, #0x8af]
006AFC3BC  mov      w20, w0
006AFC3C0  cbnz     w8, #0x6afc3d8
006AFC3C4  adrp     x0, #0x8f3d000
006AFC3C8  ldr      x0, [x0, #0xeb0]
006AFC3CC  bl       #0x382bd14 ; 
006AFC3D0  mov      w8, #1
006AFC3D4  strb     w8, [x21, #0x8af]
006AFC3D8  adrp     x8, #0x8f3d000
006AFC3DC  ldr      x8, [x8, #0xeb0]
006AFC3E0  ldr      x2, [x8]
006AFC3E4  ldrb     w8, [x2, #0x53]
006AFC3E8  tbnz     w8, #5, #0x6afc3f4
006AFC3EC  str      w20, [x19, #0x4c]
006AFC3F0  b        #0x6afc404 ; 
006AFC3F4  ldr      x8, [x2, #0x60]
006AFC3F8  mov      x0, x19
006AFC3FC  mov      w1, w20
006AFC400  blr      x8
006AFC404  mov      x0, x19
006AFC408  mov      x1, xzr
006AFC40C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC410  adrp     x21, #0x959f000
006AFC414  ldrb     w8, [x21, #0x8b0]
006AFC418  mov      w20, w0
006AFC41C  cbnz     w8, #0x6afc434
006AFC420  adrp     x0, #0x8f3d000
006AFC424  ldr      x0, [x0, #0xec0]
006AFC428  bl       #0x382bd14 ; 
006AFC42C  mov      w8, #1
006AFC430  strb     w8, [x21, #0x8b0]
006AFC434  adrp     x8, #0x8f3d000
006AFC438  ldr      x8, [x8, #0xec0]
006AFC43C  ldr      x2, [x8]
006AFC440  ldrb     w8, [x2, #0x53]
006AFC444  tbnz     w8, #5, #0x6afc450
006AFC448  str      w20, [x19, #0x50]
006AFC44C  b        #0x6afc460 ; 
006AFC450  ldr      x8, [x2, #0x60]
006AFC454  mov      x0, x19
006AFC458  mov      w1, w20
006AFC45C  blr      x8
006AFC460  mov      x0, x19
006AFC464  mov      x1, xzr
006AFC468  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC46C  adrp     x21, #0x959f000
006AFC470  ldrb     w8, [x21, #0x8b1]
006AFC474  mov      w20, w0
006AFC478  cbnz     w8, #0x6afc490
006AFC47C  adrp     x0, #0x8f3d000
006AFC480  ldr      x0, [x0, #0xed0]
006AFC484  bl       #0x382bd14 ; 
006AFC488  mov      w8, #1
006AFC48C  strb     w8, [x21, #0x8b1]
006AFC490  adrp     x8, #0x8f3d000
006AFC494  ldr      x8, [x8, #0xed0]
006AFC498  ldr      x2, [x8]
006AFC49C  ldrb     w8, [x2, #0x53]
006AFC4A0  tbnz     w8, #5, #0x6afc4ac
006AFC4A4  str      w20, [x19, #0x54]
006AFC4A8  b        #0x6afc4bc ; 
006AFC4AC  ldr      x8, [x2, #0x60]
006AFC4B0  mov      x0, x19
006AFC4B4  mov      w1, w20
006AFC4B8  blr      x8
006AFC4BC  mov      x0, x19
006AFC4C0  mov      x1, xzr
006AFC4C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC4C8  adrp     x21, #0x959f000
006AFC4CC  ldrb     w8, [x21, #0x8b2]
006AFC4D0  mov      w20, w0
006AFC4D4  cbnz     w8, #0x6afc4ec
006AFC4D8  adrp     x0, #0x8f3d000
006AFC4DC  ldr      x0, [x0, #0xee0]
006AFC4E0  bl       #0x382bd14 ; 
006AFC4E4  mov      w8, #1
006AFC4E8  strb     w8, [x21, #0x8b2]
006AFC4EC  adrp     x8, #0x8f3d000
006AFC4F0  ldr      x8, [x8, #0xee0]
006AFC4F4  ldr      x2, [x8]
006AFC4F8  ldrb     w8, [x2, #0x53]
006AFC4FC  tbnz     w8, #5, #0x6afc508
006AFC500  str      w20, [x19, #0x58]
006AFC504  b        #0x6afc518 ; 
006AFC508  ldr      x8, [x2, #0x60]
006AFC50C  mov      x0, x19
006AFC510  mov      w1, w20
006AFC514  blr      x8
006AFC518  mov      x0, x19
006AFC51C  mov      x1, xzr
006AFC520  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFC524  adrp     x21, #0x959f000
006AFC528  ldrb     w8, [x21, #0x8b3]
006AFC52C  mov      w20, w0
006AFC530  cbnz     w8, #0x6afc548
006AFC534  adrp     x0, #0x8f3d000
006AFC538  ldr      x0, [x0, #0xef0]
006AFC53C  bl       #0x382bd14 ; 
006AFC540  mov      w8, #1
006AFC544  strb     w8, [x21, #0x8b3]
006AFC548  adrp     x8, #0x8f3d000
006AFC54C  ldr      x8, [x8, #0xef0]
006AFC550  ldr      x2, [x8]
006AFC554  ldrb     w8, [x2, #0x53]
006AFC558  tbnz     w8, #5, #0x6afc564
006AFC55C  str      w20, [x19, #0x5c]
006AFC560  b        #0x6afc574 ; 
006AFC564  ldr      x8, [x2, #0x60]
006AFC568  mov      x0, x19
006AFC56C  mov      w1, w20
006AFC570  blr      x8
006AFC574  ldp      x20, x19, [sp, #0x10]
006AFC578  mov      w0, #1
006AFC57C  ldp      x30, x21, [sp], #0x20
006AFC580  ret      

