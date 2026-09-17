; LocalModels.Bean.MissionGuildBoss_GuildBoss$$readImpl
; RVA 0x6AB736C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AB736C  stp      x30, x21, [sp, #-0x20]!
006AB7370  stp      x20, x19, [sp, #0x10]
006AB7374  adrp     x20, #0x959e000
006AB7378  adrp     x21, #0x8f3a000
006AB737C  ldrb     w8, [x20, #0x883]
006AB7380  ldr      x21, [x21, #0xbf0]
006AB7384  mov      x19, x0
006AB7388  tbnz     w8, #0, #0x6ab73a0
006AB738C  adrp     x0, #0x8f3a000
006AB7390  ldr      x0, [x0, #0xbf0]
006AB7394  bl       #0x382bd14 ; 
006AB7398  mov      w8, #1
006AB739C  strb     w8, [x20, #0x883]
006AB73A0  ldr      x1, [x21]
006AB73A4  ldrb     w8, [x1, #0x53]
006AB73A8  tbnz     w8, #5, #0x6ab73f8
006AB73AC  mov      x0, x19
006AB73B0  mov      x1, xzr
006AB73B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB73B8  adrp     x21, #0x959e000
006AB73BC  ldrb     w8, [x21, #0xfb3]
006AB73C0  mov      w20, w0
006AB73C4  cbnz     w8, #0x6ab73dc
006AB73C8  adrp     x0, #0x8f3a000
006AB73CC  ldr      x0, [x0, #0xa88]
006AB73D0  bl       #0x382bd14 ; 
006AB73D4  mov      w8, #1
006AB73D8  strb     w8, [x21, #0xfb3]
006AB73DC  adrp     x8, #0x8f3a000
006AB73E0  ldr      x8, [x8, #0xa88]
006AB73E4  ldr      x2, [x8]
006AB73E8  ldrb     w8, [x2, #0x53]
006AB73EC  tbnz     w8, #5, #0x6ab740c
006AB73F0  str      w20, [x19, #0x20]
006AB73F4  b        #0x6ab741c ; 
006AB73F8  ldr      x2, [x1, #0x60]
006AB73FC  mov      x0, x19
006AB7400  ldp      x20, x19, [sp, #0x10]
006AB7404  ldp      x30, x21, [sp], #0x20
006AB7408  br       x2
006AB740C  ldr      x8, [x2, #0x60]
006AB7410  mov      x0, x19
006AB7414  mov      w1, w20
006AB7418  blr      x8
006AB741C  mov      x0, x19
006AB7420  mov      x1, xzr
006AB7424  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB7428  adrp     x21, #0x959e000
006AB742C  ldrb     w8, [x21, #0xfb4]
006AB7430  mov      w20, w0
006AB7434  cbnz     w8, #0x6ab744c
006AB7438  adrp     x0, #0x8f3a000
006AB743C  ldr      x0, [x0, #0xa98]
006AB7440  bl       #0x382bd14 ; 
006AB7444  mov      w8, #1
006AB7448  strb     w8, [x21, #0xfb4]
006AB744C  adrp     x8, #0x8f3a000
006AB7450  ldr      x8, [x8, #0xa98]
006AB7454  ldr      x2, [x8]
006AB7458  ldrb     w8, [x2, #0x53]
006AB745C  tbnz     w8, #5, #0x6ab7468
006AB7460  str      w20, [x19, #0x24]
006AB7464  b        #0x6ab7478 ; 
006AB7468  ldr      x8, [x2, #0x60]
006AB746C  mov      x0, x19
006AB7470  mov      w1, w20
006AB7474  blr      x8
006AB7478  mov      x0, x19
006AB747C  mov      x1, xzr
006AB7480  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB7484  adrp     x21, #0x959e000
006AB7488  ldrb     w8, [x21, #0xfb5]
006AB748C  mov      x20, x0
006AB7490  cbnz     w8, #0x6ab74a8
006AB7494  adrp     x0, #0x8f3a000
006AB7498  ldr      x0, [x0, #0xaa8]
006AB749C  bl       #0x382bd14 ; 
006AB74A0  mov      w8, #1
006AB74A4  strb     w8, [x21, #0xfb5]
006AB74A8  adrp     x8, #0x8f3a000
006AB74AC  ldr      x8, [x8, #0xaa8]
006AB74B0  ldr      x2, [x8]
006AB74B4  ldrb     w8, [x2, #0x53]
006AB74B8  tbnz     w8, #5, #0x6ab74c4
006AB74BC  str      x20, [x19, #0x28]
006AB74C0  b        #0x6ab74d4 ; 
006AB74C4  ldr      x8, [x2, #0x60]
006AB74C8  mov      x0, x19
006AB74CC  mov      x1, x20
006AB74D0  blr      x8
006AB74D4  mov      x0, x19
006AB74D8  mov      x1, xzr
006AB74DC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB74E0  adrp     x21, #0x959e000
006AB74E4  ldrb     w8, [x21, #0xfb6]
006AB74E8  mov      x20, x0
006AB74EC  cbnz     w8, #0x6ab7504
006AB74F0  adrp     x0, #0x8f3a000
006AB74F4  ldr      x0, [x0, #0xab8]
006AB74F8  bl       #0x382bd14 ; 
006AB74FC  mov      w8, #1
006AB7500  strb     w8, [x21, #0xfb6]
006AB7504  adrp     x8, #0x8f3a000
006AB7508  ldr      x8, [x8, #0xab8]
006AB750C  ldr      x2, [x8]
006AB7510  ldrb     w8, [x2, #0x53]
006AB7514  tbnz     w8, #5, #0x6ab7520
006AB7518  str      x20, [x19, #0x30]
006AB751C  b        #0x6ab7530 ; 
006AB7520  ldr      x8, [x2, #0x60]
006AB7524  mov      x0, x19
006AB7528  mov      x1, x20
006AB752C  blr      x8
006AB7530  mov      x0, x19
006AB7534  mov      x1, xzr
006AB7538  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB753C  adrp     x21, #0x959e000
006AB7540  ldrb     w8, [x21, #0xfb7]
006AB7544  mov      w20, w0
006AB7548  cbnz     w8, #0x6ab7560
006AB754C  adrp     x0, #0x8f3a000
006AB7550  ldr      x0, [x0, #0xac8]
006AB7554  bl       #0x382bd14 ; 
006AB7558  mov      w8, #1
006AB755C  strb     w8, [x21, #0xfb7]
006AB7560  adrp     x8, #0x8f3a000
006AB7564  ldr      x8, [x8, #0xac8]
006AB7568  ldr      x2, [x8]
006AB756C  ldrb     w8, [x2, #0x53]
006AB7570  tbnz     w8, #5, #0x6ab757c
006AB7574  str      w20, [x19, #0x38]
006AB7578  b        #0x6ab758c ; 
006AB757C  ldr      x8, [x2, #0x60]
006AB7580  mov      x0, x19
006AB7584  mov      w1, w20
006AB7588  blr      x8
006AB758C  mov      x0, x19
006AB7590  mov      x1, xzr
006AB7594  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006AB7598  adrp     x21, #0x959e000
006AB759C  ldrb     w8, [x21, #0xfb8]
006AB75A0  mov      x20, x0
006AB75A4  cbnz     w8, #0x6ab75bc
006AB75A8  adrp     x0, #0x8f3a000
006AB75AC  ldr      x0, [x0, #0xad8]
006AB75B0  bl       #0x382bd14 ; 
006AB75B4  mov      w8, #1
006AB75B8  strb     w8, [x21, #0xfb8]
006AB75BC  adrp     x8, #0x8f3a000
006AB75C0  ldr      x8, [x8, #0xad8]
006AB75C4  ldr      x2, [x8]
006AB75C8  ldrb     w8, [x2, #0x53]
006AB75CC  tbnz     w8, #5, #0x6ab75e4
006AB75D0  mov      x0, x19
006AB75D4  str      x20, [x0, #0x40]!
006AB75D8  mov      x1, x20
006AB75DC  bl       #0x382bcb8 ; 
006AB75E0  b        #0x6ab75f4 ; 
006AB75E4  ldr      x8, [x2, #0x60]
006AB75E8  mov      x0, x19
006AB75EC  mov      x1, x20
006AB75F0  blr      x8
006AB75F4  mov      x0, x19
006AB75F8  mov      x1, xzr
006AB75FC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB7600  adrp     x21, #0x959e000
006AB7604  ldrb     w8, [x21, #0xfb9]
006AB7608  mov      x20, x0
006AB760C  cbnz     w8, #0x6ab7624
006AB7610  adrp     x0, #0x8f3a000
006AB7614  ldr      x0, [x0, #0xae8]
006AB7618  bl       #0x382bd14 ; 
006AB761C  mov      w8, #1
006AB7620  strb     w8, [x21, #0xfb9]
006AB7624  adrp     x8, #0x8f3a000
006AB7628  ldr      x8, [x8, #0xae8]
006AB762C  ldr      x2, [x8]
006AB7630  ldrb     w8, [x2, #0x53]
006AB7634  tbnz     w8, #5, #0x6ab764c
006AB7638  mov      x0, x19
006AB763C  str      x20, [x0, #0x48]!
006AB7640  mov      x1, x20
006AB7644  bl       #0x382bcb8 ; 
006AB7648  b        #0x6ab765c ; 
006AB764C  ldr      x8, [x2, #0x60]
006AB7650  mov      x0, x19
006AB7654  mov      x1, x20
006AB7658  blr      x8
006AB765C  mov      x0, x19
006AB7660  mov      x1, xzr
006AB7664  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB7668  adrp     x21, #0x959e000
006AB766C  ldrb     w8, [x21, #0xfba]
006AB7670  mov      w20, w0
006AB7674  cbnz     w8, #0x6ab768c
006AB7678  adrp     x0, #0x8f3a000
006AB767C  ldr      x0, [x0, #0xaf8]
006AB7680  bl       #0x382bd14 ; 
006AB7684  mov      w8, #1
006AB7688  strb     w8, [x21, #0xfba]
006AB768C  adrp     x8, #0x8f3a000
006AB7690  ldr      x8, [x8, #0xaf8]
006AB7694  ldr      x2, [x8]
006AB7698  ldrb     w8, [x2, #0x53]
006AB769C  tbnz     w8, #5, #0x6ab76a8
006AB76A0  str      w20, [x19, #0x50]
006AB76A4  b        #0x6ab76b8 ; 
006AB76A8  ldr      x8, [x2, #0x60]
006AB76AC  mov      x0, x19
006AB76B0  mov      w1, w20
006AB76B4  blr      x8
006AB76B8  mov      x0, x19
006AB76BC  mov      x1, xzr
006AB76C0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB76C4  adrp     x21, #0x959e000
006AB76C8  ldrb     w8, [x21, #0xfbb]
006AB76CC  mov      x20, x0
006AB76D0  cbnz     w8, #0x6ab76e8
006AB76D4  adrp     x0, #0x8f3a000
006AB76D8  ldr      x0, [x0, #0xb08]
006AB76DC  bl       #0x382bd14 ; 
006AB76E0  mov      w8, #1
006AB76E4  strb     w8, [x21, #0xfbb]
006AB76E8  adrp     x8, #0x8f3a000
006AB76EC  ldr      x8, [x8, #0xb08]
006AB76F0  ldr      x2, [x8]
006AB76F4  ldrb     w8, [x2, #0x53]
006AB76F8  tbnz     w8, #5, #0x6ab7710
006AB76FC  mov      x0, x19
006AB7700  str      x20, [x0, #0x58]!
006AB7704  mov      x1, x20
006AB7708  bl       #0x382bcb8 ; 
006AB770C  b        #0x6ab7720 ; 
006AB7710  ldr      x8, [x2, #0x60]
006AB7714  mov      x0, x19
006AB7718  mov      x1, x20
006AB771C  blr      x8
006AB7720  mov      x0, x19
006AB7724  mov      x1, xzr
006AB7728  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB772C  adrp     x21, #0x959e000
006AB7730  ldrb     w8, [x21, #0xfbc]
006AB7734  mov      x20, x0
006AB7738  cbnz     w8, #0x6ab7750
006AB773C  adrp     x0, #0x8f3a000
006AB7740  ldr      x0, [x0, #0xb18]
006AB7744  bl       #0x382bd14 ; 
006AB7748  mov      w8, #1
006AB774C  strb     w8, [x21, #0xfbc]
006AB7750  adrp     x8, #0x8f3a000
006AB7754  ldr      x8, [x8, #0xb18]
006AB7758  ldr      x2, [x8]
006AB775C  ldrb     w8, [x2, #0x53]
006AB7760  tbnz     w8, #5, #0x6ab7778
006AB7764  mov      x0, x19
006AB7768  str      x20, [x0, #0x60]!
006AB776C  mov      x1, x20
006AB7770  bl       #0x382bcb8 ; 
006AB7774  b        #0x6ab7788 ; 
006AB7778  ldr      x8, [x2, #0x60]
006AB777C  mov      x0, x19
006AB7780  mov      x1, x20
006AB7784  blr      x8
006AB7788  mov      x0, x19
006AB778C  mov      x1, xzr
006AB7790  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB7794  adrp     x21, #0x959e000
006AB7798  ldrb     w8, [x21, #0xfbd]
006AB779C  mov      x20, x0
006AB77A0  cbnz     w8, #0x6ab77b8
006AB77A4  adrp     x0, #0x8f3a000
006AB77A8  ldr      x0, [x0, #0xb28]
006AB77AC  bl       #0x382bd14 ; 
006AB77B0  mov      w8, #1
006AB77B4  strb     w8, [x21, #0xfbd]
006AB77B8  adrp     x8, #0x8f3a000
006AB77BC  ldr      x8, [x8, #0xb28]
006AB77C0  ldr      x2, [x8]
006AB77C4  ldrb     w8, [x2, #0x53]
006AB77C8  tbnz     w8, #5, #0x6ab77e0
006AB77CC  mov      x0, x19
006AB77D0  str      x20, [x0, #0x68]!
006AB77D4  mov      x1, x20
006AB77D8  bl       #0x382bcb8 ; 
006AB77DC  b        #0x6ab77f0 ; 
006AB77E0  ldr      x8, [x2, #0x60]
006AB77E4  mov      x0, x19
006AB77E8  mov      x1, x20
006AB77EC  blr      x8
006AB77F0  mov      x0, x19
006AB77F4  mov      x1, xzr
006AB77F8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB77FC  adrp     x21, #0x959e000
006AB7800  ldrb     w8, [x21, #0xfbe]
006AB7804  mov      x20, x0
006AB7808  cbnz     w8, #0x6ab7820
006AB780C  adrp     x0, #0x8f3a000
006AB7810  ldr      x0, [x0, #0xb38]
006AB7814  bl       #0x382bd14 ; 
006AB7818  mov      w8, #1
006AB781C  strb     w8, [x21, #0xfbe]
006AB7820  adrp     x8, #0x8f3a000
006AB7824  ldr      x8, [x8, #0xb38]
006AB7828  ldr      x2, [x8]
006AB782C  ldrb     w8, [x2, #0x53]
006AB7830  tbnz     w8, #5, #0x6ab7848
006AB7834  mov      x0, x19
006AB7838  str      x20, [x0, #0x70]!
006AB783C  mov      x1, x20
006AB7840  bl       #0x382bcb8 ; 
006AB7844  b        #0x6ab7858 ; 
006AB7848  ldr      x8, [x2, #0x60]
006AB784C  mov      x0, x19
006AB7850  mov      x1, x20
006AB7854  blr      x8
006AB7858  mov      x0, x19
006AB785C  mov      x1, xzr
006AB7860  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB7864  adrp     x21, #0x959e000
006AB7868  ldrb     w8, [x21, #0xfbf]
006AB786C  mov      w20, w0
006AB7870  cbnz     w8, #0x6ab7888
006AB7874  adrp     x0, #0x8f3a000
006AB7878  ldr      x0, [x0, #0xb48]
006AB787C  bl       #0x382bd14 ; 
006AB7880  mov      w8, #1
006AB7884  strb     w8, [x21, #0xfbf]
006AB7888  adrp     x8, #0x8f3a000
006AB788C  ldr      x8, [x8, #0xb48]
006AB7890  ldr      x2, [x8]
006AB7894  ldrb     w8, [x2, #0x53]
006AB7898  tbnz     w8, #5, #0x6ab78a4
006AB789C  str      w20, [x19, #0x78]
006AB78A0  b        #0x6ab78b4 ; 
006AB78A4  ldr      x8, [x2, #0x60]
006AB78A8  mov      x0, x19
006AB78AC  mov      w1, w20
006AB78B0  blr      x8
006AB78B4  mov      x0, x19
006AB78B8  mov      x1, xzr
006AB78BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB78C0  adrp     x21, #0x959e000
006AB78C4  ldrb     w8, [x21, #0xfc0]
006AB78C8  mov      w20, w0
006AB78CC  cbnz     w8, #0x6ab78e4
006AB78D0  adrp     x0, #0x8f3a000
006AB78D4  ldr      x0, [x0, #0xb58]
006AB78D8  bl       #0x382bd14 ; 
006AB78DC  mov      w8, #1
006AB78E0  strb     w8, [x21, #0xfc0]
006AB78E4  adrp     x8, #0x8f3a000
006AB78E8  ldr      x8, [x8, #0xb58]
006AB78EC  ldr      x2, [x8]
006AB78F0  ldrb     w8, [x2, #0x53]
006AB78F4  tbnz     w8, #5, #0x6ab7900
006AB78F8  str      w20, [x19, #0x7c]
006AB78FC  b        #0x6ab7910 ; 
006AB7900  ldr      x8, [x2, #0x60]
006AB7904  mov      x0, x19
006AB7908  mov      w1, w20
006AB790C  blr      x8
006AB7910  mov      x0, x19
006AB7914  mov      x1, xzr
006AB7918  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB791C  adrp     x21, #0x959e000
006AB7920  ldrb     w8, [x21, #0xfc1]
006AB7924  mov      x20, x0
006AB7928  cbnz     w8, #0x6ab7940
006AB792C  adrp     x0, #0x8f3a000
006AB7930  ldr      x0, [x0, #0xb68]
006AB7934  bl       #0x382bd14 ; 
006AB7938  mov      w8, #1
006AB793C  strb     w8, [x21, #0xfc1]
006AB7940  adrp     x8, #0x8f3a000
006AB7944  ldr      x8, [x8, #0xb68]
006AB7948  ldr      x2, [x8]
006AB794C  ldrb     w8, [x2, #0x53]
006AB7950  tbnz     w8, #5, #0x6ab795c
006AB7954  str      x20, [x19, #0x80]
006AB7958  b        #0x6ab796c ; 
006AB795C  ldr      x8, [x2, #0x60]
006AB7960  mov      x0, x19
006AB7964  mov      x1, x20
006AB7968  blr      x8
006AB796C  mov      x0, x19
006AB7970  mov      x1, xzr
006AB7974  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB7978  adrp     x21, #0x959e000
006AB797C  ldrb     w8, [x21, #0xfc2]
006AB7980  mov      x20, x0
006AB7984  cbnz     w8, #0x6ab799c
006AB7988  adrp     x0, #0x8f3a000
006AB798C  ldr      x0, [x0, #0xb78]
006AB7990  bl       #0x382bd14 ; 
006AB7994  mov      w8, #1
006AB7998  strb     w8, [x21, #0xfc2]
006AB799C  adrp     x8, #0x8f3a000
006AB79A0  ldr      x8, [x8, #0xb78]
006AB79A4  ldr      x2, [x8]
006AB79A8  ldrb     w8, [x2, #0x53]
006AB79AC  tbnz     w8, #5, #0x6ab79b8
006AB79B0  str      x20, [x19, #0x88]
006AB79B4  b        #0x6ab79c8 ; 
006AB79B8  ldr      x8, [x2, #0x60]
006AB79BC  mov      x0, x19
006AB79C0  mov      x1, x20
006AB79C4  blr      x8
006AB79C8  mov      x0, x19
006AB79CC  mov      x1, xzr
006AB79D0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB79D4  adrp     x21, #0x959e000
006AB79D8  ldrb     w8, [x21, #0xfc3]
006AB79DC  mov      x20, x0
006AB79E0  cbnz     w8, #0x6ab79f8
006AB79E4  adrp     x0, #0x8f3a000
006AB79E8  ldr      x0, [x0, #0xb88]
006AB79EC  bl       #0x382bd14 ; 
006AB79F0  mov      w8, #1
006AB79F4  strb     w8, [x21, #0xfc3]
006AB79F8  adrp     x8, #0x8f3a000
006AB79FC  ldr      x8, [x8, #0xb88]
006AB7A00  ldr      x2, [x8]
006AB7A04  ldrb     w8, [x2, #0x53]
006AB7A08  tbnz     w8, #5, #0x6ab7a14
006AB7A0C  str      x20, [x19, #0x90]
006AB7A10  b        #0x6ab7a24 ; 
006AB7A14  ldr      x8, [x2, #0x60]
006AB7A18  mov      x0, x19
006AB7A1C  mov      x1, x20
006AB7A20  blr      x8
006AB7A24  mov      x0, x19
006AB7A28  mov      x1, xzr
006AB7A2C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AB7A30  adrp     x21, #0x959e000
006AB7A34  ldrb     w8, [x21, #0xfc4]
006AB7A38  mov      x20, x0
006AB7A3C  cbnz     w8, #0x6ab7a54
006AB7A40  adrp     x0, #0x8f3a000
006AB7A44  ldr      x0, [x0, #0xb98]
006AB7A48  bl       #0x382bd14 ; 
006AB7A4C  mov      w8, #1
006AB7A50  strb     w8, [x21, #0xfc4]
006AB7A54  adrp     x8, #0x8f3a000
006AB7A58  ldr      x8, [x8, #0xb98]
006AB7A5C  ldr      x2, [x8]
006AB7A60  ldrb     w8, [x2, #0x53]
006AB7A64  tbnz     w8, #5, #0x6ab7a70
006AB7A68  str      x20, [x19, #0x98]
006AB7A6C  b        #0x6ab7a80 ; 
006AB7A70  ldr      x8, [x2, #0x60]
006AB7A74  mov      x0, x19
006AB7A78  mov      x1, x20
006AB7A7C  blr      x8
006AB7A80  mov      x0, x19
006AB7A84  mov      x1, xzr
006AB7A88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB7A8C  adrp     x21, #0x959e000
006AB7A90  ldrb     w8, [x21, #0xfc5]
006AB7A94  mov      w20, w0
006AB7A98  cbnz     w8, #0x6ab7ab0
006AB7A9C  adrp     x0, #0x8f3a000
006AB7AA0  ldr      x0, [x0, #0xba8]
006AB7AA4  bl       #0x382bd14 ; 
006AB7AA8  mov      w8, #1
006AB7AAC  strb     w8, [x21, #0xfc5]
006AB7AB0  adrp     x8, #0x8f3a000
006AB7AB4  ldr      x8, [x8, #0xba8]
006AB7AB8  ldr      x2, [x8]
006AB7ABC  ldrb     w8, [x2, #0x53]
006AB7AC0  tbnz     w8, #5, #0x6ab7acc
006AB7AC4  str      w20, [x19, #0xa0]
006AB7AC8  b        #0x6ab7adc ; 
006AB7ACC  ldr      x8, [x2, #0x60]
006AB7AD0  mov      x0, x19
006AB7AD4  mov      w1, w20
006AB7AD8  blr      x8
006AB7ADC  mov      x0, x19
006AB7AE0  mov      x1, xzr
006AB7AE4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB7AE8  adrp     x21, #0x959e000
006AB7AEC  ldrb     w8, [x21, #0xfc6]
006AB7AF0  mov      x20, x0
006AB7AF4  cbnz     w8, #0x6ab7b0c
006AB7AF8  adrp     x0, #0x8f3a000
006AB7AFC  ldr      x0, [x0, #0xbb8]
006AB7B00  bl       #0x382bd14 ; 
006AB7B04  mov      w8, #1
006AB7B08  strb     w8, [x21, #0xfc6]
006AB7B0C  adrp     x8, #0x8f3a000
006AB7B10  ldr      x8, [x8, #0xbb8]
006AB7B14  ldr      x2, [x8]
006AB7B18  ldrb     w8, [x2, #0x53]
006AB7B1C  tbnz     w8, #5, #0x6ab7b34
006AB7B20  mov      x0, x19
006AB7B24  str      x20, [x0, #0xa8]!
006AB7B28  mov      x1, x20
006AB7B2C  bl       #0x382bcb8 ; 
006AB7B30  b        #0x6ab7b44 ; 
006AB7B34  ldr      x8, [x2, #0x60]
006AB7B38  mov      x0, x19
006AB7B3C  mov      x1, x20
006AB7B40  blr      x8
006AB7B44  mov      x0, x19
006AB7B48  mov      x1, xzr
006AB7B4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB7B50  adrp     x21, #0x959e000
006AB7B54  ldrb     w8, [x21, #0xfc7]
006AB7B58  mov      w20, w0
006AB7B5C  cbnz     w8, #0x6ab7b74
006AB7B60  adrp     x0, #0x8f3a000
006AB7B64  ldr      x0, [x0, #0xbc8]
006AB7B68  bl       #0x382bd14 ; 
006AB7B6C  mov      w8, #1
006AB7B70  strb     w8, [x21, #0xfc7]
006AB7B74  adrp     x8, #0x8f3a000
006AB7B78  ldr      x8, [x8, #0xbc8]
006AB7B7C  ldr      x2, [x8]
006AB7B80  ldrb     w8, [x2, #0x53]
006AB7B84  tbnz     w8, #5, #0x6ab7b90
006AB7B88  str      w20, [x19, #0xb0]
006AB7B8C  b        #0x6ab7ba0 ; 
006AB7B90  ldr      x8, [x2, #0x60]
006AB7B94  mov      x0, x19
006AB7B98  mov      w1, w20
006AB7B9C  blr      x8
006AB7BA0  mov      x0, x19
006AB7BA4  mov      x1, xzr
006AB7BA8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB7BAC  adrp     x21, #0x959e000
006AB7BB0  ldrb     w8, [x21, #0xfc8]
006AB7BB4  mov      x20, x0
006AB7BB8  cbnz     w8, #0x6ab7bd0
006AB7BBC  adrp     x0, #0x8f3a000
006AB7BC0  ldr      x0, [x0, #0xbd8]
006AB7BC4  bl       #0x382bd14 ; 
006AB7BC8  mov      w8, #1
006AB7BCC  strb     w8, [x21, #0xfc8]
006AB7BD0  adrp     x8, #0x8f3a000
006AB7BD4  ldr      x8, [x8, #0xbd8]
006AB7BD8  ldr      x2, [x8]
006AB7BDC  ldrb     w8, [x2, #0x53]
006AB7BE0  tbnz     w8, #5, #0x6ab7bf8
006AB7BE4  mov      x0, x19
006AB7BE8  str      x20, [x0, #0xb8]!
006AB7BEC  mov      x1, x20
006AB7BF0  bl       #0x382bcb8 ; 
006AB7BF4  b        #0x6ab7c08 ; 
006AB7BF8  ldr      x8, [x2, #0x60]
006AB7BFC  mov      x0, x19
006AB7C00  mov      x1, x20
006AB7C04  blr      x8
006AB7C08  mov      x0, x19
006AB7C0C  mov      x1, xzr
006AB7C10  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AB7C14  adrp     x21, #0x959e000
006AB7C18  ldrb     w8, [x21, #0xfc9]
006AB7C1C  mov      x20, x0
006AB7C20  cbnz     w8, #0x6ab7c38
006AB7C24  adrp     x0, #0x8f3a000
006AB7C28  ldr      x0, [x0, #0xbe8]
006AB7C2C  bl       #0x382bd14 ; 
006AB7C30  mov      w8, #1
006AB7C34  strb     w8, [x21, #0xfc9]
006AB7C38  adrp     x8, #0x8f3a000
006AB7C3C  ldr      x8, [x8, #0xbe8]
006AB7C40  ldr      x2, [x8]
006AB7C44  ldrb     w8, [x2, #0x53]
006AB7C48  tbnz     w8, #5, #0x6ab7c60
006AB7C4C  str      x20, [x19, #0xc0]!
006AB7C50  mov      x0, x19
006AB7C54  mov      x1, x20
006AB7C58  bl       #0x382bcb8 ; 
006AB7C5C  b        #0x6ab7c70 ; 
006AB7C60  ldr      x8, [x2, #0x60]
006AB7C64  mov      x0, x19
006AB7C68  mov      x1, x20
006AB7C6C  blr      x8
006AB7C70  ldp      x20, x19, [sp, #0x10]
006AB7C74  mov      w0, #1
006AB7C78  ldp      x30, x21, [sp], #0x20
006AB7C7C  ret      

