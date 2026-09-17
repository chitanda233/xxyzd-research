; LocalModels.Bean.SkillLab_Lab$$readImpl
; RVA 0x6B00388; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B00388  stp      x30, x21, [sp, #-0x20]!
006B0038C  stp      x20, x19, [sp, #0x10]
006B00390  adrp     x20, #0x959f000
006B00394  adrp     x21, #0x8f3e000
006B00398  ldrb     w8, [x20, #0x394]
006B0039C  ldr      x21, [x21, #0x1f0]
006B003A0  mov      x19, x0
006B003A4  tbnz     w8, #0, #0x6b003bc
006B003A8  adrp     x0, #0x8f3e000
006B003AC  ldr      x0, [x0, #0x1f0]
006B003B0  bl       #0x382bd14 ; 
006B003B4  mov      w8, #1
006B003B8  strb     w8, [x20, #0x394]
006B003BC  ldr      x1, [x21]
006B003C0  ldrb     w8, [x1, #0x53]
006B003C4  tbnz     w8, #5, #0x6b00414
006B003C8  mov      x0, x19
006B003CC  mov      x1, xzr
006B003D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B003D4  adrp     x21, #0x959f000
006B003D8  ldrb     w8, [x21, #0x8e7]
006B003DC  mov      w20, w0
006B003E0  cbnz     w8, #0x6b003f8
006B003E4  adrp     x0, #0x8f3e000
006B003E8  ldr      x0, [x0, #0x110]
006B003EC  bl       #0x382bd14 ; 
006B003F0  mov      w8, #1
006B003F4  strb     w8, [x21, #0x8e7]
006B003F8  adrp     x8, #0x8f3e000
006B003FC  ldr      x8, [x8, #0x110]
006B00400  ldr      x2, [x8]
006B00404  ldrb     w8, [x2, #0x53]
006B00408  tbnz     w8, #5, #0x6b00428
006B0040C  str      w20, [x19, #0x20]
006B00410  b        #0x6b00438 ; 
006B00414  ldr      x2, [x1, #0x60]
006B00418  mov      x0, x19
006B0041C  ldp      x20, x19, [sp, #0x10]
006B00420  ldp      x30, x21, [sp], #0x20
006B00424  br       x2
006B00428  ldr      x8, [x2, #0x60]
006B0042C  mov      x0, x19
006B00430  mov      w1, w20
006B00434  blr      x8
006B00438  mov      x0, x19
006B0043C  mov      x1, xzr
006B00440  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B00444  adrp     x21, #0x959f000
006B00448  ldrb     w8, [x21, #0x8e8]
006B0044C  mov      w20, w0
006B00450  cbnz     w8, #0x6b00468
006B00454  adrp     x0, #0x8f3e000
006B00458  ldr      x0, [x0, #0x120]
006B0045C  bl       #0x382bd14 ; 
006B00460  mov      w8, #1
006B00464  strb     w8, [x21, #0x8e8]
006B00468  adrp     x8, #0x8f3e000
006B0046C  ldr      x8, [x8, #0x120]
006B00470  ldr      x2, [x8]
006B00474  ldrb     w8, [x2, #0x53]
006B00478  tbnz     w8, #5, #0x6b00484
006B0047C  str      w20, [x19, #0x24]
006B00480  b        #0x6b00494 ; 
006B00484  ldr      x8, [x2, #0x60]
006B00488  mov      x0, x19
006B0048C  mov      w1, w20
006B00490  blr      x8
006B00494  mov      x0, x19
006B00498  mov      x1, xzr
006B0049C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B004A0  adrp     x21, #0x959f000
006B004A4  ldrb     w8, [x21, #0x8e9]
006B004A8  mov      w20, w0
006B004AC  cbnz     w8, #0x6b004c4
006B004B0  adrp     x0, #0x8f3e000
006B004B4  ldr      x0, [x0, #0x130]
006B004B8  bl       #0x382bd14 ; 
006B004BC  mov      w8, #1
006B004C0  strb     w8, [x21, #0x8e9]
006B004C4  adrp     x8, #0x8f3e000
006B004C8  ldr      x8, [x8, #0x130]
006B004CC  ldr      x2, [x8]
006B004D0  ldrb     w8, [x2, #0x53]
006B004D4  tbnz     w8, #5, #0x6b004e0
006B004D8  str      w20, [x19, #0x28]
006B004DC  b        #0x6b004f0 ; 
006B004E0  ldr      x8, [x2, #0x60]
006B004E4  mov      x0, x19
006B004E8  mov      w1, w20
006B004EC  blr      x8
006B004F0  mov      x0, x19
006B004F4  mov      x1, xzr
006B004F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B004FC  adrp     x21, #0x959f000
006B00500  ldrb     w8, [x21, #0x8ea]
006B00504  mov      w20, w0
006B00508  cbnz     w8, #0x6b00520
006B0050C  adrp     x0, #0x8f3e000
006B00510  ldr      x0, [x0, #0x138]
006B00514  bl       #0x382bd14 ; 
006B00518  mov      w8, #1
006B0051C  strb     w8, [x21, #0x8ea]
006B00520  adrp     x8, #0x8f3e000
006B00524  ldr      x8, [x8, #0x138]
006B00528  ldr      x2, [x8]
006B0052C  ldrb     w8, [x2, #0x53]
006B00530  tbnz     w8, #5, #0x6b0053c
006B00534  str      w20, [x19, #0x2c]
006B00538  b        #0x6b0054c ; 
006B0053C  ldr      x8, [x2, #0x60]
006B00540  mov      x0, x19
006B00544  mov      w1, w20
006B00548  blr      x8
006B0054C  mov      x0, x19
006B00550  mov      x1, xzr
006B00554  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B00558  adrp     x21, #0x959f000
006B0055C  ldrb     w8, [x21, #0x8eb]
006B00560  mov      w20, w0
006B00564  cbnz     w8, #0x6b0057c
006B00568  adrp     x0, #0x8f3e000
006B0056C  ldr      x0, [x0, #0x148]
006B00570  bl       #0x382bd14 ; 
006B00574  mov      w8, #1
006B00578  strb     w8, [x21, #0x8eb]
006B0057C  adrp     x8, #0x8f3e000
006B00580  ldr      x8, [x8, #0x148]
006B00584  ldr      x2, [x8]
006B00588  ldrb     w8, [x2, #0x53]
006B0058C  tbnz     w8, #5, #0x6b00598
006B00590  str      w20, [x19, #0x30]
006B00594  b        #0x6b005a8 ; 
006B00598  ldr      x8, [x2, #0x60]
006B0059C  mov      x0, x19
006B005A0  mov      w1, w20
006B005A4  blr      x8
006B005A8  mov      x0, x19
006B005AC  mov      x1, xzr
006B005B0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B005B4  adrp     x21, #0x959f000
006B005B8  ldrb     w8, [x21, #0x8ec]
006B005BC  mov      x20, x0
006B005C0  cbnz     w8, #0x6b005d8
006B005C4  adrp     x0, #0x8f3e000
006B005C8  ldr      x0, [x0, #0x158]
006B005CC  bl       #0x382bd14 ; 
006B005D0  mov      w8, #1
006B005D4  strb     w8, [x21, #0x8ec]
006B005D8  adrp     x8, #0x8f3e000
006B005DC  ldr      x8, [x8, #0x158]
006B005E0  ldr      x2, [x8]
006B005E4  ldrb     w8, [x2, #0x53]
006B005E8  tbnz     w8, #5, #0x6b00600
006B005EC  mov      x0, x19
006B005F0  str      x20, [x0, #0x38]!
006B005F4  mov      x1, x20
006B005F8  bl       #0x382bcb8 ; 
006B005FC  b        #0x6b00610 ; 
006B00600  ldr      x8, [x2, #0x60]
006B00604  mov      x0, x19
006B00608  mov      x1, x20
006B0060C  blr      x8
006B00610  mov      x0, x19
006B00614  mov      x1, xzr
006B00618  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0061C  adrp     x21, #0x959f000
006B00620  ldrb     w8, [x21, #0x8ed]
006B00624  mov      w20, w0
006B00628  cbnz     w8, #0x6b00640
006B0062C  adrp     x0, #0x8f3e000
006B00630  ldr      x0, [x0, #0x168]
006B00634  bl       #0x382bd14 ; 
006B00638  mov      w8, #1
006B0063C  strb     w8, [x21, #0x8ed]
006B00640  adrp     x8, #0x8f3e000
006B00644  ldr      x8, [x8, #0x168]
006B00648  ldr      x2, [x8]
006B0064C  ldrb     w8, [x2, #0x53]
006B00650  tbnz     w8, #5, #0x6b0065c
006B00654  str      w20, [x19, #0x40]
006B00658  b        #0x6b0066c ; 
006B0065C  ldr      x8, [x2, #0x60]
006B00660  mov      x0, x19
006B00664  mov      w1, w20
006B00668  blr      x8
006B0066C  mov      x0, x19
006B00670  mov      x1, xzr
006B00674  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B00678  adrp     x21, #0x959f000
006B0067C  ldrb     w8, [x21, #0x8ee]
006B00680  mov      x20, x0
006B00684  cbnz     w8, #0x6b0069c
006B00688  adrp     x0, #0x8f3e000
006B0068C  ldr      x0, [x0, #0x178]
006B00690  bl       #0x382bd14 ; 
006B00694  mov      w8, #1
006B00698  strb     w8, [x21, #0x8ee]
006B0069C  adrp     x8, #0x8f3e000
006B006A0  ldr      x8, [x8, #0x178]
006B006A4  ldr      x2, [x8]
006B006A8  ldrb     w8, [x2, #0x53]
006B006AC  tbnz     w8, #5, #0x6b006c4
006B006B0  mov      x0, x19
006B006B4  str      x20, [x0, #0x48]!
006B006B8  mov      x1, x20
006B006BC  bl       #0x382bcb8 ; 
006B006C0  b        #0x6b006d4 ; 
006B006C4  ldr      x8, [x2, #0x60]
006B006C8  mov      x0, x19
006B006CC  mov      x1, x20
006B006D0  blr      x8
006B006D4  mov      x0, x19
006B006D8  mov      x1, xzr
006B006DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B006E0  adrp     x21, #0x959f000
006B006E4  ldrb     w8, [x21, #0x8ef]
006B006E8  mov      x20, x0
006B006EC  cbnz     w8, #0x6b00704
006B006F0  adrp     x0, #0x8f3e000
006B006F4  ldr      x0, [x0, #0x188]
006B006F8  bl       #0x382bd14 ; 
006B006FC  mov      w8, #1
006B00700  strb     w8, [x21, #0x8ef]
006B00704  adrp     x8, #0x8f3e000
006B00708  ldr      x8, [x8, #0x188]
006B0070C  ldr      x2, [x8]
006B00710  ldrb     w8, [x2, #0x53]
006B00714  tbnz     w8, #5, #0x6b0072c
006B00718  mov      x0, x19
006B0071C  str      x20, [x0, #0x50]!
006B00720  mov      x1, x20
006B00724  bl       #0x382bcb8 ; 
006B00728  b        #0x6b0073c ; 
006B0072C  ldr      x8, [x2, #0x60]
006B00730  mov      x0, x19
006B00734  mov      x1, x20
006B00738  blr      x8
006B0073C  mov      x0, x19
006B00740  mov      x1, xzr
006B00744  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B00748  adrp     x21, #0x959f000
006B0074C  ldrb     w8, [x21, #0x8f0]
006B00750  mov      w20, w0
006B00754  cbnz     w8, #0x6b0076c
006B00758  adrp     x0, #0x8f3e000
006B0075C  ldr      x0, [x0, #0x198]
006B00760  bl       #0x382bd14 ; 
006B00764  mov      w8, #1
006B00768  strb     w8, [x21, #0x8f0]
006B0076C  adrp     x8, #0x8f3e000
006B00770  ldr      x8, [x8, #0x198]
006B00774  ldr      x2, [x8]
006B00778  ldrb     w8, [x2, #0x53]
006B0077C  tbnz     w8, #5, #0x6b00788
006B00780  str      w20, [x19, #0x58]
006B00784  b        #0x6b00798 ; 
006B00788  ldr      x8, [x2, #0x60]
006B0078C  mov      x0, x19
006B00790  mov      w1, w20
006B00794  blr      x8
006B00798  mov      x0, x19
006B0079C  mov      x1, xzr
006B007A0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B007A4  adrp     x21, #0x959f000
006B007A8  ldrb     w8, [x21, #0x8f1]
006B007AC  mov      x20, x0
006B007B0  cbnz     w8, #0x6b007c8
006B007B4  adrp     x0, #0x8f3e000
006B007B8  ldr      x0, [x0, #0x1a8]
006B007BC  bl       #0x382bd14 ; 
006B007C0  mov      w8, #1
006B007C4  strb     w8, [x21, #0x8f1]
006B007C8  adrp     x8, #0x8f3e000
006B007CC  ldr      x8, [x8, #0x1a8]
006B007D0  ldr      x2, [x8]
006B007D4  ldrb     w8, [x2, #0x53]
006B007D8  tbnz     w8, #5, #0x6b007f0
006B007DC  mov      x0, x19
006B007E0  str      x20, [x0, #0x60]!
006B007E4  mov      x1, x20
006B007E8  bl       #0x382bcb8 ; 
006B007EC  b        #0x6b00800 ; 
006B007F0  ldr      x8, [x2, #0x60]
006B007F4  mov      x0, x19
006B007F8  mov      x1, x20
006B007FC  blr      x8
006B00800  mov      x0, x19
006B00804  mov      x1, xzr
006B00808  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0080C  adrp     x21, #0x959f000
006B00810  ldrb     w8, [x21, #0x8f2]
006B00814  mov      x20, x0
006B00818  cbnz     w8, #0x6b00830
006B0081C  adrp     x0, #0x8f3e000
006B00820  ldr      x0, [x0, #0x1b8]
006B00824  bl       #0x382bd14 ; 
006B00828  mov      w8, #1
006B0082C  strb     w8, [x21, #0x8f2]
006B00830  adrp     x8, #0x8f3e000
006B00834  ldr      x8, [x8, #0x1b8]
006B00838  ldr      x2, [x8]
006B0083C  ldrb     w8, [x2, #0x53]
006B00840  tbnz     w8, #5, #0x6b00858
006B00844  mov      x0, x19
006B00848  str      x20, [x0, #0x68]!
006B0084C  mov      x1, x20
006B00850  bl       #0x382bcb8 ; 
006B00854  b        #0x6b00868 ; 
006B00858  ldr      x8, [x2, #0x60]
006B0085C  mov      x0, x19
006B00860  mov      x1, x20
006B00864  blr      x8
006B00868  mov      x0, x19
006B0086C  mov      x1, xzr
006B00870  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B00874  adrp     x21, #0x959f000
006B00878  ldrb     w8, [x21, #0x8f3]
006B0087C  mov      w20, w0
006B00880  cbnz     w8, #0x6b00898
006B00884  adrp     x0, #0x8f3e000
006B00888  ldr      x0, [x0, #0x1c8]
006B0088C  bl       #0x382bd14 ; 
006B00890  mov      w8, #1
006B00894  strb     w8, [x21, #0x8f3]
006B00898  adrp     x8, #0x8f3e000
006B0089C  ldr      x8, [x8, #0x1c8]
006B008A0  ldr      x2, [x8]
006B008A4  ldrb     w8, [x2, #0x53]
006B008A8  tbnz     w8, #5, #0x6b008b4
006B008AC  str      w20, [x19, #0x70]
006B008B0  b        #0x6b008c4 ; 
006B008B4  ldr      x8, [x2, #0x60]
006B008B8  mov      x0, x19
006B008BC  mov      w1, w20
006B008C0  blr      x8
006B008C4  mov      x0, x19
006B008C8  mov      x1, xzr
006B008CC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B008D0  adrp     x21, #0x959f000
006B008D4  ldrb     w8, [x21, #0x8f4]
006B008D8  mov      x20, x0
006B008DC  cbnz     w8, #0x6b008f4
006B008E0  adrp     x0, #0x8f3e000
006B008E4  ldr      x0, [x0, #0x1d8]
006B008E8  bl       #0x382bd14 ; 
006B008EC  mov      w8, #1
006B008F0  strb     w8, [x21, #0x8f4]
006B008F4  adrp     x8, #0x8f3e000
006B008F8  ldr      x8, [x8, #0x1d8]
006B008FC  ldr      x2, [x8]
006B00900  ldrb     w8, [x2, #0x53]
006B00904  tbnz     w8, #5, #0x6b0091c
006B00908  mov      x0, x19
006B0090C  str      x20, [x0, #0x78]!
006B00910  mov      x1, x20
006B00914  bl       #0x382bcb8 ; 
006B00918  b        #0x6b0092c ; 
006B0091C  ldr      x8, [x2, #0x60]
006B00920  mov      x0, x19
006B00924  mov      x1, x20
006B00928  blr      x8
006B0092C  mov      x0, x19
006B00930  mov      x1, xzr
006B00934  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B00938  adrp     x21, #0x959f000
006B0093C  ldrb     w8, [x21, #0x8f5]
006B00940  mov      x20, x0
006B00944  cbnz     w8, #0x6b0095c
006B00948  adrp     x0, #0x8f3e000
006B0094C  ldr      x0, [x0, #0x1e8]
006B00950  bl       #0x382bd14 ; 
006B00954  mov      w8, #1
006B00958  strb     w8, [x21, #0x8f5]
006B0095C  adrp     x8, #0x8f3e000
006B00960  ldr      x8, [x8, #0x1e8]
006B00964  ldr      x2, [x8]
006B00968  ldrb     w8, [x2, #0x53]
006B0096C  tbnz     w8, #5, #0x6b00984
006B00970  str      x20, [x19, #0x80]!
006B00974  mov      x0, x19
006B00978  mov      x1, x20
006B0097C  bl       #0x382bcb8 ; 
006B00980  b        #0x6b00994 ; 
006B00984  ldr      x8, [x2, #0x60]
006B00988  mov      x0, x19
006B0098C  mov      x1, x20
006B00990  blr      x8
006B00994  ldp      x20, x19, [sp, #0x10]
006B00998  mov      w0, #1
006B0099C  ldp      x30, x21, [sp], #0x20
006B009A0  ret      

