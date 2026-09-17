; LocalModels.Bean.Skillss_Trigger$$readImpl
; RVA 0x6B052B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B052B4  stp      x30, x21, [sp, #-0x20]!
006B052B8  stp      x20, x19, [sp, #0x10]
006B052BC  adrp     x20, #0x959f000
006B052C0  adrp     x21, #0x8f3e000
006B052C4  ldrb     w8, [x20, #0x419]
006B052C8  ldr      x21, [x21, #0x5c0]
006B052CC  mov      x19, x0
006B052D0  tbnz     w8, #0, #0x6b052e8
006B052D4  adrp     x0, #0x8f3e000
006B052D8  ldr      x0, [x0, #0x5c0]
006B052DC  bl       #0x382bd14 ; 
006B052E0  mov      w8, #1
006B052E4  strb     w8, [x20, #0x419]
006B052E8  ldr      x1, [x21]
006B052EC  ldrb     w8, [x1, #0x53]
006B052F0  tbnz     w8, #5, #0x6b05340
006B052F4  mov      x0, x19
006B052F8  mov      x1, xzr
006B052FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B05300  adrp     x21, #0x959f000
006B05304  ldrb     w8, [x21, #0x91c]
006B05308  mov      w20, w0
006B0530C  cbnz     w8, #0x6b05324
006B05310  adrp     x0, #0x8f3e000
006B05314  ldr      x0, [x0, #0x4d8]
006B05318  bl       #0x382bd14 ; 
006B0531C  mov      w8, #1
006B05320  strb     w8, [x21, #0x91c]
006B05324  adrp     x8, #0x8f3e000
006B05328  ldr      x8, [x8, #0x4d8]
006B0532C  ldr      x2, [x8]
006B05330  ldrb     w8, [x2, #0x53]
006B05334  tbnz     w8, #5, #0x6b05354
006B05338  str      w20, [x19, #0x20]
006B0533C  b        #0x6b05364 ; 
006B05340  ldr      x2, [x1, #0x60]
006B05344  mov      x0, x19
006B05348  ldp      x20, x19, [sp, #0x10]
006B0534C  ldp      x30, x21, [sp], #0x20
006B05350  br       x2
006B05354  ldr      x8, [x2, #0x60]
006B05358  mov      x0, x19
006B0535C  mov      w1, w20
006B05360  blr      x8
006B05364  mov      x0, x19
006B05368  mov      x1, xzr
006B0536C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B05370  adrp     x21, #0x959f000
006B05374  ldrb     w8, [x21, #0x91d]
006B05378  mov      w20, w0
006B0537C  cbnz     w8, #0x6b05394
006B05380  adrp     x0, #0x8f3e000
006B05384  ldr      x0, [x0, #0x4e8]
006B05388  bl       #0x382bd14 ; 
006B0538C  mov      w8, #1
006B05390  strb     w8, [x21, #0x91d]
006B05394  adrp     x8, #0x8f3e000
006B05398  ldr      x8, [x8, #0x4e8]
006B0539C  ldr      x2, [x8]
006B053A0  ldrb     w8, [x2, #0x53]
006B053A4  tbnz     w8, #5, #0x6b053b0
006B053A8  str      w20, [x19, #0x24]
006B053AC  b        #0x6b053c0 ; 
006B053B0  ldr      x8, [x2, #0x60]
006B053B4  mov      x0, x19
006B053B8  mov      w1, w20
006B053BC  blr      x8
006B053C0  mov      x0, x19
006B053C4  mov      x1, xzr
006B053C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B053CC  adrp     x21, #0x959f000
006B053D0  ldrb     w8, [x21, #0x91e]
006B053D4  mov      w20, w0
006B053D8  cbnz     w8, #0x6b053f0
006B053DC  adrp     x0, #0x8f3e000
006B053E0  ldr      x0, [x0, #0x4f8]
006B053E4  bl       #0x382bd14 ; 
006B053E8  mov      w8, #1
006B053EC  strb     w8, [x21, #0x91e]
006B053F0  adrp     x8, #0x8f3e000
006B053F4  ldr      x8, [x8, #0x4f8]
006B053F8  ldr      x2, [x8]
006B053FC  ldrb     w8, [x2, #0x53]
006B05400  tbnz     w8, #5, #0x6b0540c
006B05404  str      w20, [x19, #0x28]
006B05408  b        #0x6b0541c ; 
006B0540C  ldr      x8, [x2, #0x60]
006B05410  mov      x0, x19
006B05414  mov      w1, w20
006B05418  blr      x8
006B0541C  mov      x0, x19
006B05420  mov      x1, xzr
006B05424  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B05428  adrp     x21, #0x959f000
006B0542C  ldrb     w8, [x21, #0x91f]
006B05430  mov      x20, x0
006B05434  cbnz     w8, #0x6b0544c
006B05438  adrp     x0, #0x8f3e000
006B0543C  ldr      x0, [x0, #0x508]
006B05440  bl       #0x382bd14 ; 
006B05444  mov      w8, #1
006B05448  strb     w8, [x21, #0x91f]
006B0544C  adrp     x8, #0x8f3e000
006B05450  ldr      x8, [x8, #0x508]
006B05454  ldr      x2, [x8]
006B05458  ldrb     w8, [x2, #0x53]
006B0545C  tbnz     w8, #5, #0x6b05474
006B05460  mov      x0, x19
006B05464  str      x20, [x0, #0x30]!
006B05468  mov      x1, x20
006B0546C  bl       #0x382bcb8 ; 
006B05470  b        #0x6b05484 ; 
006B05474  ldr      x8, [x2, #0x60]
006B05478  mov      x0, x19
006B0547C  mov      x1, x20
006B05480  blr      x8
006B05484  mov      x0, x19
006B05488  mov      x1, xzr
006B0548C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B05490  adrp     x21, #0x959f000
006B05494  ldrb     w8, [x21, #0x920]
006B05498  mov      x20, x0
006B0549C  cbnz     w8, #0x6b054b4
006B054A0  adrp     x0, #0x8f3e000
006B054A4  ldr      x0, [x0, #0x518]
006B054A8  bl       #0x382bd14 ; 
006B054AC  mov      w8, #1
006B054B0  strb     w8, [x21, #0x920]
006B054B4  adrp     x8, #0x8f3e000
006B054B8  ldr      x8, [x8, #0x518]
006B054BC  ldr      x2, [x8]
006B054C0  ldrb     w8, [x2, #0x53]
006B054C4  tbnz     w8, #5, #0x6b054d0
006B054C8  str      x20, [x19, #0x38]
006B054CC  b        #0x6b054e0 ; 
006B054D0  ldr      x8, [x2, #0x60]
006B054D4  mov      x0, x19
006B054D8  mov      x1, x20
006B054DC  blr      x8
006B054E0  mov      x0, x19
006B054E4  mov      x1, xzr
006B054E8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B054EC  adrp     x21, #0x959f000
006B054F0  ldrb     w8, [x21, #0x921]
006B054F4  mov      x20, x0
006B054F8  cbnz     w8, #0x6b05510
006B054FC  adrp     x0, #0x8f3e000
006B05500  ldr      x0, [x0, #0x528]
006B05504  bl       #0x382bd14 ; 
006B05508  mov      w8, #1
006B0550C  strb     w8, [x21, #0x921]
006B05510  adrp     x8, #0x8f3e000
006B05514  ldr      x8, [x8, #0x528]
006B05518  ldr      x2, [x8]
006B0551C  ldrb     w8, [x2, #0x53]
006B05520  tbnz     w8, #5, #0x6b0552c
006B05524  str      x20, [x19, #0x40]
006B05528  b        #0x6b0553c ; 
006B0552C  ldr      x8, [x2, #0x60]
006B05530  mov      x0, x19
006B05534  mov      x1, x20
006B05538  blr      x8
006B0553C  mov      x0, x19
006B05540  mov      x1, xzr
006B05544  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B05548  adrp     x21, #0x959f000
006B0554C  ldrb     w8, [x21, #0x922]
006B05550  mov      w20, w0
006B05554  cbnz     w8, #0x6b0556c
006B05558  adrp     x0, #0x8f3e000
006B0555C  ldr      x0, [x0, #0x538]
006B05560  bl       #0x382bd14 ; 
006B05564  mov      w8, #1
006B05568  strb     w8, [x21, #0x922]
006B0556C  adrp     x8, #0x8f3e000
006B05570  ldr      x8, [x8, #0x538]
006B05574  ldr      x2, [x8]
006B05578  ldrb     w8, [x2, #0x53]
006B0557C  tbnz     w8, #5, #0x6b05588
006B05580  str      w20, [x19, #0x48]
006B05584  b        #0x6b05598 ; 
006B05588  ldr      x8, [x2, #0x60]
006B0558C  mov      x0, x19
006B05590  mov      w1, w20
006B05594  blr      x8
006B05598  mov      x0, x19
006B0559C  mov      x1, xzr
006B055A0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B055A4  adrp     x21, #0x959f000
006B055A8  ldrb     w8, [x21, #0x923]
006B055AC  mov      x20, x0
006B055B0  cbnz     w8, #0x6b055c8
006B055B4  adrp     x0, #0x8f3e000
006B055B8  ldr      x0, [x0, #0x548]
006B055BC  bl       #0x382bd14 ; 
006B055C0  mov      w8, #1
006B055C4  strb     w8, [x21, #0x923]
006B055C8  adrp     x8, #0x8f3e000
006B055CC  ldr      x8, [x8, #0x548]
006B055D0  ldr      x2, [x8]
006B055D4  ldrb     w8, [x2, #0x53]
006B055D8  tbnz     w8, #5, #0x6b055e4
006B055DC  str      x20, [x19, #0x50]
006B055E0  b        #0x6b055f4 ; 
006B055E4  ldr      x8, [x2, #0x60]
006B055E8  mov      x0, x19
006B055EC  mov      x1, x20
006B055F0  blr      x8
006B055F4  mov      x0, x19
006B055F8  mov      x1, xzr
006B055FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B05600  adrp     x21, #0x959f000
006B05604  ldrb     w8, [x21, #0x924]
006B05608  mov      w20, w0
006B0560C  cbnz     w8, #0x6b05624
006B05610  adrp     x0, #0x8f3e000
006B05614  ldr      x0, [x0, #0x558]
006B05618  bl       #0x382bd14 ; 
006B0561C  mov      w8, #1
006B05620  strb     w8, [x21, #0x924]
006B05624  adrp     x8, #0x8f3e000
006B05628  ldr      x8, [x8, #0x558]
006B0562C  ldr      x2, [x8]
006B05630  ldrb     w8, [x2, #0x53]
006B05634  tbnz     w8, #5, #0x6b05640
006B05638  str      w20, [x19, #0x58]
006B0563C  b        #0x6b05650 ; 
006B05640  ldr      x8, [x2, #0x60]
006B05644  mov      x0, x19
006B05648  mov      w1, w20
006B0564C  blr      x8
006B05650  mov      x0, x19
006B05654  mov      x1, xzr
006B05658  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0565C  adrp     x21, #0x959f000
006B05660  ldrb     w8, [x21, #0x925]
006B05664  mov      w20, w0
006B05668  cbnz     w8, #0x6b05680
006B0566C  adrp     x0, #0x8f3e000
006B05670  ldr      x0, [x0, #0x568]
006B05674  bl       #0x382bd14 ; 
006B05678  mov      w8, #1
006B0567C  strb     w8, [x21, #0x925]
006B05680  adrp     x8, #0x8f3e000
006B05684  ldr      x8, [x8, #0x568]
006B05688  ldr      x2, [x8]
006B0568C  ldrb     w8, [x2, #0x53]
006B05690  tbnz     w8, #5, #0x6b0569c
006B05694  str      w20, [x19, #0x5c]
006B05698  b        #0x6b056ac ; 
006B0569C  ldr      x8, [x2, #0x60]
006B056A0  mov      x0, x19
006B056A4  mov      w1, w20
006B056A8  blr      x8
006B056AC  mov      x0, x19
006B056B0  mov      x1, xzr
006B056B4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B056B8  adrp     x21, #0x959f000
006B056BC  ldrb     w8, [x21, #0x926]
006B056C0  mov      x20, x0
006B056C4  cbnz     w8, #0x6b056dc
006B056C8  adrp     x0, #0x8f3e000
006B056CC  ldr      x0, [x0, #0x578]
006B056D0  bl       #0x382bd14 ; 
006B056D4  mov      w8, #1
006B056D8  strb     w8, [x21, #0x926]
006B056DC  adrp     x8, #0x8f3e000
006B056E0  ldr      x8, [x8, #0x578]
006B056E4  ldr      x2, [x8]
006B056E8  ldrb     w8, [x2, #0x53]
006B056EC  tbnz     w8, #5, #0x6b05704
006B056F0  mov      x0, x19
006B056F4  str      x20, [x0, #0x60]!
006B056F8  mov      x1, x20
006B056FC  bl       #0x382bcb8 ; 
006B05700  b        #0x6b05714 ; 
006B05704  ldr      x8, [x2, #0x60]
006B05708  mov      x0, x19
006B0570C  mov      x1, x20
006B05710  blr      x8
006B05714  mov      x0, x19
006B05718  mov      x1, xzr
006B0571C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B05720  adrp     x21, #0x959f000
006B05724  ldrb     w8, [x21, #0x927]
006B05728  mov      w20, w0
006B0572C  cbnz     w8, #0x6b05744
006B05730  adrp     x0, #0x8f3e000
006B05734  ldr      x0, [x0, #0x588]
006B05738  bl       #0x382bd14 ; 
006B0573C  mov      w8, #1
006B05740  strb     w8, [x21, #0x927]
006B05744  adrp     x8, #0x8f3e000
006B05748  ldr      x8, [x8, #0x588]
006B0574C  ldr      x2, [x8]
006B05750  ldrb     w8, [x2, #0x53]
006B05754  tbnz     w8, #5, #0x6b05760
006B05758  str      w20, [x19, #0x68]
006B0575C  b        #0x6b05770 ; 
006B05760  ldr      x8, [x2, #0x60]
006B05764  mov      x0, x19
006B05768  mov      w1, w20
006B0576C  blr      x8
006B05770  mov      x0, x19
006B05774  mov      x1, xzr
006B05778  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0577C  adrp     x21, #0x959f000
006B05780  ldrb     w8, [x21, #0x928]
006B05784  mov      x20, x0
006B05788  cbnz     w8, #0x6b057a0
006B0578C  adrp     x0, #0x8f3e000
006B05790  ldr      x0, [x0, #0x598]
006B05794  bl       #0x382bd14 ; 
006B05798  mov      w8, #1
006B0579C  strb     w8, [x21, #0x928]
006B057A0  adrp     x8, #0x8f3e000
006B057A4  ldr      x8, [x8, #0x598]
006B057A8  ldr      x2, [x8]
006B057AC  ldrb     w8, [x2, #0x53]
006B057B0  tbnz     w8, #5, #0x6b057c8
006B057B4  mov      x0, x19
006B057B8  str      x20, [x0, #0x70]!
006B057BC  mov      x1, x20
006B057C0  bl       #0x382bcb8 ; 
006B057C4  b        #0x6b057d8 ; 
006B057C8  ldr      x8, [x2, #0x60]
006B057CC  mov      x0, x19
006B057D0  mov      x1, x20
006B057D4  blr      x8
006B057D8  mov      x0, x19
006B057DC  mov      x1, xzr
006B057E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B057E4  adrp     x21, #0x959f000
006B057E8  ldrb     w8, [x21, #0x929]
006B057EC  mov      w20, w0
006B057F0  cbnz     w8, #0x6b05808
006B057F4  adrp     x0, #0x8f3e000
006B057F8  ldr      x0, [x0, #0x5a8]
006B057FC  bl       #0x382bd14 ; 
006B05800  mov      w8, #1
006B05804  strb     w8, [x21, #0x929]
006B05808  adrp     x8, #0x8f3e000
006B0580C  ldr      x8, [x8, #0x5a8]
006B05810  ldr      x2, [x8]
006B05814  ldrb     w8, [x2, #0x53]
006B05818  tbnz     w8, #5, #0x6b05824
006B0581C  str      w20, [x19, #0x78]
006B05820  b        #0x6b05834 ; 
006B05824  ldr      x8, [x2, #0x60]
006B05828  mov      x0, x19
006B0582C  mov      w1, w20
006B05830  blr      x8
006B05834  mov      x0, x19
006B05838  mov      x1, xzr
006B0583C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B05840  adrp     x21, #0x959f000
006B05844  ldrb     w8, [x21, #0x92a]
006B05848  mov      w20, w0
006B0584C  cbnz     w8, #0x6b05864
006B05850  adrp     x0, #0x8f3e000
006B05854  ldr      x0, [x0, #0x5b8]
006B05858  bl       #0x382bd14 ; 
006B0585C  mov      w8, #1
006B05860  strb     w8, [x21, #0x92a]
006B05864  adrp     x8, #0x8f3e000
006B05868  ldr      x8, [x8, #0x5b8]
006B0586C  ldr      x2, [x8]
006B05870  ldrb     w8, [x2, #0x53]
006B05874  tbnz     w8, #5, #0x6b05880
006B05878  str      w20, [x19, #0x7c]
006B0587C  b        #0x6b05890 ; 
006B05880  ldr      x8, [x2, #0x60]
006B05884  mov      x0, x19
006B05888  mov      w1, w20
006B0588C  blr      x8
006B05890  ldp      x20, x19, [sp, #0x10]
006B05894  mov      w0, #1
006B05898  ldp      x30, x21, [sp], #0x20
006B0589C  ret      

