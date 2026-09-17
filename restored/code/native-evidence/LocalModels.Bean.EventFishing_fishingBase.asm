; LocalModels.Bean.EventFishing_fishingBase$$readImpl
; RVA 0x6A74138; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A74138  stp      x30, x21, [sp, #-0x20]!
006A7413C  stp      x20, x19, [sp, #0x10]
006A74140  adrp     x20, #0x959d000
006A74144  adrp     x21, #0x8f37000
006A74148  ldrb     w8, [x20, #0xe08]
006A7414C  ldr      x21, [x21, #0x8e8]
006A74150  mov      x19, x0
006A74154  tbnz     w8, #0, #0x6a7416c
006A74158  adrp     x0, #0x8f37000
006A7415C  ldr      x0, [x0, #0x8e8]
006A74160  bl       #0x382bd14 ; 
006A74164  mov      w8, #1
006A74168  strb     w8, [x20, #0xe08]
006A7416C  ldr      x1, [x21]
006A74170  ldrb     w8, [x1, #0x53]
006A74174  tbnz     w8, #5, #0x6a741c4
006A74178  mov      x0, x19
006A7417C  mov      x1, xzr
006A74180  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74184  adrp     x21, #0x959e000
006A74188  ldrb     w8, [x21, #0x46a]
006A7418C  mov      w20, w0
006A74190  cbnz     w8, #0x6a741a8
006A74194  adrp     x0, #0x8f37000
006A74198  ldr      x0, [x0, #0x740]
006A7419C  bl       #0x382bd14 ; 
006A741A0  mov      w8, #1
006A741A4  strb     w8, [x21, #0x46a]
006A741A8  adrp     x8, #0x8f37000
006A741AC  ldr      x8, [x8, #0x740]
006A741B0  ldr      x2, [x8]
006A741B4  ldrb     w8, [x2, #0x53]
006A741B8  tbnz     w8, #5, #0x6a741d8
006A741BC  str      w20, [x19, #0x20]
006A741C0  b        #0x6a741e8 ; 
006A741C4  ldr      x2, [x1, #0x60]
006A741C8  mov      x0, x19
006A741CC  ldp      x20, x19, [sp, #0x10]
006A741D0  ldp      x30, x21, [sp], #0x20
006A741D4  br       x2
006A741D8  ldr      x8, [x2, #0x60]
006A741DC  mov      x0, x19
006A741E0  mov      w1, w20
006A741E4  blr      x8
006A741E8  mov      x0, x19
006A741EC  mov      x1, xzr
006A741F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A741F4  adrp     x21, #0x959e000
006A741F8  ldrb     w8, [x21, #0x46b]
006A741FC  mov      w20, w0
006A74200  cbnz     w8, #0x6a74218
006A74204  adrp     x0, #0x8f37000
006A74208  ldr      x0, [x0, #0x750]
006A7420C  bl       #0x382bd14 ; 
006A74210  mov      w8, #1
006A74214  strb     w8, [x21, #0x46b]
006A74218  adrp     x8, #0x8f37000
006A7421C  ldr      x8, [x8, #0x750]
006A74220  ldr      x2, [x8]
006A74224  ldrb     w8, [x2, #0x53]
006A74228  tbnz     w8, #5, #0x6a74234
006A7422C  str      w20, [x19, #0x24]
006A74230  b        #0x6a74244 ; 
006A74234  ldr      x8, [x2, #0x60]
006A74238  mov      x0, x19
006A7423C  mov      w1, w20
006A74240  blr      x8
006A74244  mov      x0, x19
006A74248  mov      x1, xzr
006A7424C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74250  adrp     x21, #0x959e000
006A74254  ldrb     w8, [x21, #0x46c]
006A74258  mov      w20, w0
006A7425C  cbnz     w8, #0x6a74274
006A74260  adrp     x0, #0x8f37000
006A74264  ldr      x0, [x0, #0x760]
006A74268  bl       #0x382bd14 ; 
006A7426C  mov      w8, #1
006A74270  strb     w8, [x21, #0x46c]
006A74274  adrp     x8, #0x8f37000
006A74278  ldr      x8, [x8, #0x760]
006A7427C  ldr      x2, [x8]
006A74280  ldrb     w8, [x2, #0x53]
006A74284  tbnz     w8, #5, #0x6a74290
006A74288  str      w20, [x19, #0x28]
006A7428C  b        #0x6a742a0 ; 
006A74290  ldr      x8, [x2, #0x60]
006A74294  mov      x0, x19
006A74298  mov      w1, w20
006A7429C  blr      x8
006A742A0  mov      x0, x19
006A742A4  mov      x1, xzr
006A742A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A742AC  adrp     x21, #0x959e000
006A742B0  ldrb     w8, [x21, #0x46d]
006A742B4  mov      w20, w0
006A742B8  cbnz     w8, #0x6a742d0
006A742BC  adrp     x0, #0x8f37000
006A742C0  ldr      x0, [x0, #0x770]
006A742C4  bl       #0x382bd14 ; 
006A742C8  mov      w8, #1
006A742CC  strb     w8, [x21, #0x46d]
006A742D0  adrp     x8, #0x8f37000
006A742D4  ldr      x8, [x8, #0x770]
006A742D8  ldr      x2, [x8]
006A742DC  ldrb     w8, [x2, #0x53]
006A742E0  tbnz     w8, #5, #0x6a742ec
006A742E4  str      w20, [x19, #0x2c]
006A742E8  b        #0x6a742fc ; 
006A742EC  ldr      x8, [x2, #0x60]
006A742F0  mov      x0, x19
006A742F4  mov      w1, w20
006A742F8  blr      x8
006A742FC  mov      x0, x19
006A74300  mov      x1, xzr
006A74304  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74308  adrp     x21, #0x959e000
006A7430C  ldrb     w8, [x21, #0x46e]
006A74310  mov      w20, w0
006A74314  cbnz     w8, #0x6a7432c
006A74318  adrp     x0, #0x8f37000
006A7431C  ldr      x0, [x0, #0x780]
006A74320  bl       #0x382bd14 ; 
006A74324  mov      w8, #1
006A74328  strb     w8, [x21, #0x46e]
006A7432C  adrp     x8, #0x8f37000
006A74330  ldr      x8, [x8, #0x780]
006A74334  ldr      x2, [x8]
006A74338  ldrb     w8, [x2, #0x53]
006A7433C  tbnz     w8, #5, #0x6a74348
006A74340  str      w20, [x19, #0x30]
006A74344  b        #0x6a74358 ; 
006A74348  ldr      x8, [x2, #0x60]
006A7434C  mov      x0, x19
006A74350  mov      w1, w20
006A74354  blr      x8
006A74358  mov      x0, x19
006A7435C  mov      x1, xzr
006A74360  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A74364  adrp     x21, #0x959e000
006A74368  ldrb     w8, [x21, #0x46f]
006A7436C  mov      x20, x0
006A74370  cbnz     w8, #0x6a74388
006A74374  adrp     x0, #0x8f37000
006A74378  ldr      x0, [x0, #0x790]
006A7437C  bl       #0x382bd14 ; 
006A74380  mov      w8, #1
006A74384  strb     w8, [x21, #0x46f]
006A74388  adrp     x8, #0x8f37000
006A7438C  ldr      x8, [x8, #0x790]
006A74390  ldr      x2, [x8]
006A74394  ldrb     w8, [x2, #0x53]
006A74398  tbnz     w8, #5, #0x6a743b0
006A7439C  mov      x0, x19
006A743A0  str      x20, [x0, #0x38]!
006A743A4  mov      x1, x20
006A743A8  bl       #0x382bcb8 ; 
006A743AC  b        #0x6a743c0 ; 
006A743B0  ldr      x8, [x2, #0x60]
006A743B4  mov      x0, x19
006A743B8  mov      x1, x20
006A743BC  blr      x8
006A743C0  mov      x0, x19
006A743C4  mov      x1, xzr
006A743C8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A743CC  adrp     x21, #0x959e000
006A743D0  ldrb     w8, [x21, #0x470]
006A743D4  mov      x20, x0
006A743D8  cbnz     w8, #0x6a743f0
006A743DC  adrp     x0, #0x8f37000
006A743E0  ldr      x0, [x0, #0x7a0]
006A743E4  bl       #0x382bd14 ; 
006A743E8  mov      w8, #1
006A743EC  strb     w8, [x21, #0x470]
006A743F0  adrp     x8, #0x8f37000
006A743F4  ldr      x8, [x8, #0x7a0]
006A743F8  ldr      x2, [x8]
006A743FC  ldrb     w8, [x2, #0x53]
006A74400  tbnz     w8, #5, #0x6a74418
006A74404  mov      x0, x19
006A74408  str      x20, [x0, #0x40]!
006A7440C  mov      x1, x20
006A74410  bl       #0x382bcb8 ; 
006A74414  b        #0x6a74428 ; 
006A74418  ldr      x8, [x2, #0x60]
006A7441C  mov      x0, x19
006A74420  mov      x1, x20
006A74424  blr      x8
006A74428  mov      x0, x19
006A7442C  mov      x1, xzr
006A74430  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74434  adrp     x21, #0x959e000
006A74438  ldrb     w8, [x21, #0x471]
006A7443C  mov      w20, w0
006A74440  cbnz     w8, #0x6a74458
006A74444  adrp     x0, #0x8f37000
006A74448  ldr      x0, [x0, #0x7b0]
006A7444C  bl       #0x382bd14 ; 
006A74450  mov      w8, #1
006A74454  strb     w8, [x21, #0x471]
006A74458  adrp     x8, #0x8f37000
006A7445C  ldr      x8, [x8, #0x7b0]
006A74460  ldr      x2, [x8]
006A74464  ldrb     w8, [x2, #0x53]
006A74468  tbnz     w8, #5, #0x6a74474
006A7446C  str      w20, [x19, #0x48]
006A74470  b        #0x6a74484 ; 
006A74474  ldr      x8, [x2, #0x60]
006A74478  mov      x0, x19
006A7447C  mov      w1, w20
006A74480  blr      x8
006A74484  mov      x0, x19
006A74488  mov      x1, xzr
006A7448C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74490  adrp     x21, #0x959e000
006A74494  ldrb     w8, [x21, #0x472]
006A74498  mov      w20, w0
006A7449C  cbnz     w8, #0x6a744b4
006A744A0  adrp     x0, #0x8f37000
006A744A4  ldr      x0, [x0, #0x7c0]
006A744A8  bl       #0x382bd14 ; 
006A744AC  mov      w8, #1
006A744B0  strb     w8, [x21, #0x472]
006A744B4  adrp     x8, #0x8f37000
006A744B8  ldr      x8, [x8, #0x7c0]
006A744BC  ldr      x2, [x8]
006A744C0  ldrb     w8, [x2, #0x53]
006A744C4  tbnz     w8, #5, #0x6a744d0
006A744C8  str      w20, [x19, #0x4c]
006A744CC  b        #0x6a744e0 ; 
006A744D0  ldr      x8, [x2, #0x60]
006A744D4  mov      x0, x19
006A744D8  mov      w1, w20
006A744DC  blr      x8
006A744E0  mov      x0, x19
006A744E4  mov      x1, xzr
006A744E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A744EC  adrp     x21, #0x959e000
006A744F0  ldrb     w8, [x21, #0x473]
006A744F4  mov      x20, x0
006A744F8  cbnz     w8, #0x6a74510
006A744FC  adrp     x0, #0x8f37000
006A74500  ldr      x0, [x0, #0x7d0]
006A74504  bl       #0x382bd14 ; 
006A74508  mov      w8, #1
006A7450C  strb     w8, [x21, #0x473]
006A74510  adrp     x8, #0x8f37000
006A74514  ldr      x8, [x8, #0x7d0]
006A74518  ldr      x2, [x8]
006A7451C  ldrb     w8, [x2, #0x53]
006A74520  tbnz     w8, #5, #0x6a74538
006A74524  mov      x0, x19
006A74528  str      x20, [x0, #0x50]!
006A7452C  mov      x1, x20
006A74530  bl       #0x382bcb8 ; 
006A74534  b        #0x6a74548 ; 
006A74538  ldr      x8, [x2, #0x60]
006A7453C  mov      x0, x19
006A74540  mov      x1, x20
006A74544  blr      x8
006A74548  mov      x0, x19
006A7454C  mov      x1, xzr
006A74550  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A74554  adrp     x21, #0x959e000
006A74558  ldrb     w8, [x21, #0x474]
006A7455C  mov      x20, x0
006A74560  cbnz     w8, #0x6a74578
006A74564  adrp     x0, #0x8f37000
006A74568  ldr      x0, [x0, #0x7e0]
006A7456C  bl       #0x382bd14 ; 
006A74570  mov      w8, #1
006A74574  strb     w8, [x21, #0x474]
006A74578  adrp     x8, #0x8f37000
006A7457C  ldr      x8, [x8, #0x7e0]
006A74580  ldr      x2, [x8]
006A74584  ldrb     w8, [x2, #0x53]
006A74588  tbnz     w8, #5, #0x6a745a0
006A7458C  mov      x0, x19
006A74590  str      x20, [x0, #0x58]!
006A74594  mov      x1, x20
006A74598  bl       #0x382bcb8 ; 
006A7459C  b        #0x6a745b0 ; 
006A745A0  ldr      x8, [x2, #0x60]
006A745A4  mov      x0, x19
006A745A8  mov      x1, x20
006A745AC  blr      x8
006A745B0  mov      x0, x19
006A745B4  mov      x1, xzr
006A745B8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A745BC  adrp     x21, #0x959e000
006A745C0  ldrb     w8, [x21, #0x475]
006A745C4  mov      x20, x0
006A745C8  cbnz     w8, #0x6a745e0
006A745CC  adrp     x0, #0x8f37000
006A745D0  ldr      x0, [x0, #0x7f0]
006A745D4  bl       #0x382bd14 ; 
006A745D8  mov      w8, #1
006A745DC  strb     w8, [x21, #0x475]
006A745E0  adrp     x8, #0x8f37000
006A745E4  ldr      x8, [x8, #0x7f0]
006A745E8  ldr      x2, [x8]
006A745EC  ldrb     w8, [x2, #0x53]
006A745F0  tbnz     w8, #5, #0x6a74608
006A745F4  mov      x0, x19
006A745F8  str      x20, [x0, #0x60]!
006A745FC  mov      x1, x20
006A74600  bl       #0x382bcb8 ; 
006A74604  b        #0x6a74618 ; 
006A74608  ldr      x8, [x2, #0x60]
006A7460C  mov      x0, x19
006A74610  mov      x1, x20
006A74614  blr      x8
006A74618  mov      x0, x19
006A7461C  mov      x1, xzr
006A74620  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74624  adrp     x21, #0x959e000
006A74628  ldrb     w8, [x21, #0x476]
006A7462C  mov      w20, w0
006A74630  cbnz     w8, #0x6a74648
006A74634  adrp     x0, #0x8f37000
006A74638  ldr      x0, [x0, #0x800]
006A7463C  bl       #0x382bd14 ; 
006A74640  mov      w8, #1
006A74644  strb     w8, [x21, #0x476]
006A74648  adrp     x8, #0x8f37000
006A7464C  ldr      x8, [x8, #0x800]
006A74650  ldr      x2, [x8]
006A74654  ldrb     w8, [x2, #0x53]
006A74658  tbnz     w8, #5, #0x6a74664
006A7465C  str      w20, [x19, #0x68]
006A74660  b        #0x6a74674 ; 
006A74664  ldr      x8, [x2, #0x60]
006A74668  mov      x0, x19
006A7466C  mov      w1, w20
006A74670  blr      x8
006A74674  mov      x0, x19
006A74678  mov      x1, xzr
006A7467C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A74680  adrp     x21, #0x959e000
006A74684  ldrb     w8, [x21, #0x477]
006A74688  mov      x20, x0
006A7468C  cbnz     w8, #0x6a746a4
006A74690  adrp     x0, #0x8f37000
006A74694  ldr      x0, [x0, #0x810]
006A74698  bl       #0x382bd14 ; 
006A7469C  mov      w8, #1
006A746A0  strb     w8, [x21, #0x477]
006A746A4  adrp     x8, #0x8f37000
006A746A8  ldr      x8, [x8, #0x810]
006A746AC  ldr      x2, [x8]
006A746B0  ldrb     w8, [x2, #0x53]
006A746B4  tbnz     w8, #5, #0x6a746cc
006A746B8  mov      x0, x19
006A746BC  str      x20, [x0, #0x70]!
006A746C0  mov      x1, x20
006A746C4  bl       #0x382bcb8 ; 
006A746C8  b        #0x6a746dc ; 
006A746CC  ldr      x8, [x2, #0x60]
006A746D0  mov      x0, x19
006A746D4  mov      x1, x20
006A746D8  blr      x8
006A746DC  mov      x0, x19
006A746E0  mov      x1, xzr
006A746E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A746E8  adrp     x21, #0x959e000
006A746EC  ldrb     w8, [x21, #0x478]
006A746F0  mov      w20, w0
006A746F4  cbnz     w8, #0x6a7470c
006A746F8  adrp     x0, #0x8f37000
006A746FC  ldr      x0, [x0, #0x820]
006A74700  bl       #0x382bd14 ; 
006A74704  mov      w8, #1
006A74708  strb     w8, [x21, #0x478]
006A7470C  adrp     x8, #0x8f37000
006A74710  ldr      x8, [x8, #0x820]
006A74714  ldr      x2, [x8]
006A74718  ldrb     w8, [x2, #0x53]
006A7471C  tbnz     w8, #5, #0x6a74728
006A74720  str      w20, [x19, #0x78]
006A74724  b        #0x6a74738 ; 
006A74728  ldr      x8, [x2, #0x60]
006A7472C  mov      x0, x19
006A74730  mov      w1, w20
006A74734  blr      x8
006A74738  mov      x0, x19
006A7473C  mov      x1, xzr
006A74740  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A74744  adrp     x21, #0x959e000
006A74748  ldrb     w8, [x21, #0x479]
006A7474C  mov      x20, x0
006A74750  cbnz     w8, #0x6a74768
006A74754  adrp     x0, #0x8f37000
006A74758  ldr      x0, [x0, #0x830]
006A7475C  bl       #0x382bd14 ; 
006A74760  mov      w8, #1
006A74764  strb     w8, [x21, #0x479]
006A74768  adrp     x8, #0x8f37000
006A7476C  ldr      x8, [x8, #0x830]
006A74770  ldr      x2, [x8]
006A74774  ldrb     w8, [x2, #0x53]
006A74778  tbnz     w8, #5, #0x6a74790
006A7477C  mov      x0, x19
006A74780  str      x20, [x0, #0x80]!
006A74784  mov      x1, x20
006A74788  bl       #0x382bcb8 ; 
006A7478C  b        #0x6a747a0 ; 
006A74790  ldr      x8, [x2, #0x60]
006A74794  mov      x0, x19
006A74798  mov      x1, x20
006A7479C  blr      x8
006A747A0  mov      x0, x19
006A747A4  mov      x1, xzr
006A747A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A747AC  adrp     x21, #0x959e000
006A747B0  ldrb     w8, [x21, #0x47a]
006A747B4  mov      w20, w0
006A747B8  cbnz     w8, #0x6a747d0
006A747BC  adrp     x0, #0x8f37000
006A747C0  ldr      x0, [x0, #0x840]
006A747C4  bl       #0x382bd14 ; 
006A747C8  mov      w8, #1
006A747CC  strb     w8, [x21, #0x47a]
006A747D0  adrp     x8, #0x8f37000
006A747D4  ldr      x8, [x8, #0x840]
006A747D8  ldr      x2, [x8]
006A747DC  ldrb     w8, [x2, #0x53]
006A747E0  tbnz     w8, #5, #0x6a747ec
006A747E4  str      w20, [x19, #0x88]
006A747E8  b        #0x6a747fc ; 
006A747EC  ldr      x8, [x2, #0x60]
006A747F0  mov      x0, x19
006A747F4  mov      w1, w20
006A747F8  blr      x8
006A747FC  mov      x0, x19
006A74800  mov      x1, xzr
006A74804  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74808  adrp     x21, #0x959e000
006A7480C  ldrb     w8, [x21, #0x47b]
006A74810  mov      w20, w0
006A74814  cbnz     w8, #0x6a7482c
006A74818  adrp     x0, #0x8f37000
006A7481C  ldr      x0, [x0, #0x850]
006A74820  bl       #0x382bd14 ; 
006A74824  mov      w8, #1
006A74828  strb     w8, [x21, #0x47b]
006A7482C  adrp     x8, #0x8f37000
006A74830  ldr      x8, [x8, #0x850]
006A74834  ldr      x2, [x8]
006A74838  ldrb     w8, [x2, #0x53]
006A7483C  tbnz     w8, #5, #0x6a74848
006A74840  str      w20, [x19, #0x8c]
006A74844  b        #0x6a74858 ; 
006A74848  ldr      x8, [x2, #0x60]
006A7484C  mov      x0, x19
006A74850  mov      w1, w20
006A74854  blr      x8
006A74858  mov      x0, x19
006A7485C  mov      x1, xzr
006A74860  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A74864  adrp     x21, #0x959e000
006A74868  ldrb     w8, [x21, #0x47c]
006A7486C  mov      x20, x0
006A74870  cbnz     w8, #0x6a74888
006A74874  adrp     x0, #0x8f37000
006A74878  ldr      x0, [x0, #0x860]
006A7487C  bl       #0x382bd14 ; 
006A74880  mov      w8, #1
006A74884  strb     w8, [x21, #0x47c]
006A74888  adrp     x8, #0x8f37000
006A7488C  ldr      x8, [x8, #0x860]
006A74890  ldr      x2, [x8]
006A74894  ldrb     w8, [x2, #0x53]
006A74898  tbnz     w8, #5, #0x6a748b0
006A7489C  mov      x0, x19
006A748A0  str      x20, [x0, #0x90]!
006A748A4  mov      x1, x20
006A748A8  bl       #0x382bcb8 ; 
006A748AC  b        #0x6a748c0 ; 
006A748B0  ldr      x8, [x2, #0x60]
006A748B4  mov      x0, x19
006A748B8  mov      x1, x20
006A748BC  blr      x8
006A748C0  mov      x0, x19
006A748C4  mov      x1, xzr
006A748C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A748CC  adrp     x21, #0x959e000
006A748D0  ldrb     w8, [x21, #0x47d]
006A748D4  mov      w20, w0
006A748D8  cbnz     w8, #0x6a748f0
006A748DC  adrp     x0, #0x8f37000
006A748E0  ldr      x0, [x0, #0x870]
006A748E4  bl       #0x382bd14 ; 
006A748E8  mov      w8, #1
006A748EC  strb     w8, [x21, #0x47d]
006A748F0  adrp     x8, #0x8f37000
006A748F4  ldr      x8, [x8, #0x870]
006A748F8  ldr      x2, [x8]
006A748FC  ldrb     w8, [x2, #0x53]
006A74900  tbnz     w8, #5, #0x6a7490c
006A74904  str      w20, [x19, #0x98]
006A74908  b        #0x6a7491c ; 
006A7490C  ldr      x8, [x2, #0x60]
006A74910  mov      x0, x19
006A74914  mov      w1, w20
006A74918  blr      x8
006A7491C  mov      x0, x19
006A74920  mov      x1, xzr
006A74924  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74928  adrp     x21, #0x959e000
006A7492C  ldrb     w8, [x21, #0x47e]
006A74930  mov      w20, w0
006A74934  cbnz     w8, #0x6a7494c
006A74938  adrp     x0, #0x8f37000
006A7493C  ldr      x0, [x0, #0x880]
006A74940  bl       #0x382bd14 ; 
006A74944  mov      w8, #1
006A74948  strb     w8, [x21, #0x47e]
006A7494C  adrp     x8, #0x8f37000
006A74950  ldr      x8, [x8, #0x880]
006A74954  ldr      x2, [x8]
006A74958  ldrb     w8, [x2, #0x53]
006A7495C  tbnz     w8, #5, #0x6a74968
006A74960  str      w20, [x19, #0x9c]
006A74964  b        #0x6a74978 ; 
006A74968  ldr      x8, [x2, #0x60]
006A7496C  mov      x0, x19
006A74970  mov      w1, w20
006A74974  blr      x8
006A74978  mov      x0, x19
006A7497C  mov      x1, xzr
006A74980  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74984  adrp     x21, #0x959e000
006A74988  ldrb     w8, [x21, #0x47f]
006A7498C  mov      w20, w0
006A74990  cbnz     w8, #0x6a749a8
006A74994  adrp     x0, #0x8f37000
006A74998  ldr      x0, [x0, #0x890]
006A7499C  bl       #0x382bd14 ; 
006A749A0  mov      w8, #1
006A749A4  strb     w8, [x21, #0x47f]
006A749A8  adrp     x8, #0x8f37000
006A749AC  ldr      x8, [x8, #0x890]
006A749B0  ldr      x2, [x8]
006A749B4  ldrb     w8, [x2, #0x53]
006A749B8  tbnz     w8, #5, #0x6a749c4
006A749BC  str      w20, [x19, #0xa0]
006A749C0  b        #0x6a749d4 ; 
006A749C4  ldr      x8, [x2, #0x60]
006A749C8  mov      x0, x19
006A749CC  mov      w1, w20
006A749D0  blr      x8
006A749D4  mov      x0, x19
006A749D8  mov      x1, xzr
006A749DC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A749E0  adrp     x21, #0x959e000
006A749E4  ldrb     w8, [x21, #0x480]
006A749E8  mov      x20, x0
006A749EC  cbnz     w8, #0x6a74a04
006A749F0  adrp     x0, #0x8f37000
006A749F4  ldr      x0, [x0, #0x8a0]
006A749F8  bl       #0x382bd14 ; 
006A749FC  mov      w8, #1
006A74A00  strb     w8, [x21, #0x480]
006A74A04  adrp     x8, #0x8f37000
006A74A08  ldr      x8, [x8, #0x8a0]
006A74A0C  ldr      x2, [x8]
006A74A10  ldrb     w8, [x2, #0x53]
006A74A14  tbnz     w8, #5, #0x6a74a2c
006A74A18  mov      x0, x19
006A74A1C  str      x20, [x0, #0xa8]!
006A74A20  mov      x1, x20
006A74A24  bl       #0x382bcb8 ; 
006A74A28  b        #0x6a74a3c ; 
006A74A2C  ldr      x8, [x2, #0x60]
006A74A30  mov      x0, x19
006A74A34  mov      x1, x20
006A74A38  blr      x8
006A74A3C  mov      x0, x19
006A74A40  mov      x1, xzr
006A74A44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74A48  adrp     x21, #0x959e000
006A74A4C  ldrb     w8, [x21, #0x481]
006A74A50  mov      w20, w0
006A74A54  cbnz     w8, #0x6a74a6c
006A74A58  adrp     x0, #0x8f37000
006A74A5C  ldr      x0, [x0, #0x8b0]
006A74A60  bl       #0x382bd14 ; 
006A74A64  mov      w8, #1
006A74A68  strb     w8, [x21, #0x481]
006A74A6C  adrp     x8, #0x8f37000
006A74A70  ldr      x8, [x8, #0x8b0]
006A74A74  ldr      x2, [x8]
006A74A78  ldrb     w8, [x2, #0x53]
006A74A7C  tbnz     w8, #5, #0x6a74a88
006A74A80  str      w20, [x19, #0xb0]
006A74A84  b        #0x6a74a98 ; 
006A74A88  ldr      x8, [x2, #0x60]
006A74A8C  mov      x0, x19
006A74A90  mov      w1, w20
006A74A94  blr      x8
006A74A98  mov      x0, x19
006A74A9C  mov      x1, xzr
006A74AA0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A74AA4  adrp     x21, #0x959e000
006A74AA8  ldrb     w8, [x21, #0x482]
006A74AAC  mov      x20, x0
006A74AB0  cbnz     w8, #0x6a74ac8
006A74AB4  adrp     x0, #0x8f37000
006A74AB8  ldr      x0, [x0, #0x8c0]
006A74ABC  bl       #0x382bd14 ; 
006A74AC0  mov      w8, #1
006A74AC4  strb     w8, [x21, #0x482]
006A74AC8  adrp     x8, #0x8f37000
006A74ACC  ldr      x8, [x8, #0x8c0]
006A74AD0  ldr      x2, [x8]
006A74AD4  ldrb     w8, [x2, #0x53]
006A74AD8  tbnz     w8, #5, #0x6a74af0
006A74ADC  mov      x0, x19
006A74AE0  str      x20, [x0, #0xb8]!
006A74AE4  mov      x1, x20
006A74AE8  bl       #0x382bcb8 ; 
006A74AEC  b        #0x6a74b00 ; 
006A74AF0  ldr      x8, [x2, #0x60]
006A74AF4  mov      x0, x19
006A74AF8  mov      x1, x20
006A74AFC  blr      x8
006A74B00  mov      x0, x19
006A74B04  mov      x1, xzr
006A74B08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74B0C  adrp     x21, #0x959e000
006A74B10  ldrb     w8, [x21, #0x483]
006A74B14  mov      w20, w0
006A74B18  cbnz     w8, #0x6a74b30
006A74B1C  adrp     x0, #0x8f37000
006A74B20  ldr      x0, [x0, #0x8d0]
006A74B24  bl       #0x382bd14 ; 
006A74B28  mov      w8, #1
006A74B2C  strb     w8, [x21, #0x483]
006A74B30  adrp     x8, #0x8f37000
006A74B34  ldr      x8, [x8, #0x8d0]
006A74B38  ldr      x2, [x8]
006A74B3C  ldrb     w8, [x2, #0x53]
006A74B40  tbnz     w8, #5, #0x6a74b4c
006A74B44  str      w20, [x19, #0xc0]
006A74B48  b        #0x6a74b5c ; 
006A74B4C  ldr      x8, [x2, #0x60]
006A74B50  mov      x0, x19
006A74B54  mov      w1, w20
006A74B58  blr      x8
006A74B5C  mov      x0, x19
006A74B60  mov      x1, xzr
006A74B64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A74B68  adrp     x21, #0x959e000
006A74B6C  ldrb     w8, [x21, #0x484]
006A74B70  mov      w20, w0
006A74B74  cbnz     w8, #0x6a74b8c
006A74B78  adrp     x0, #0x8f37000
006A74B7C  ldr      x0, [x0, #0x8e0]
006A74B80  bl       #0x382bd14 ; 
006A74B84  mov      w8, #1
006A74B88  strb     w8, [x21, #0x484]
006A74B8C  adrp     x8, #0x8f37000
006A74B90  ldr      x8, [x8, #0x8e0]
006A74B94  ldr      x2, [x8]
006A74B98  ldrb     w8, [x2, #0x53]
006A74B9C  tbnz     w8, #5, #0x6a74ba8
006A74BA0  str      w20, [x19, #0xc4]
006A74BA4  b        #0x6a74bb8 ; 
006A74BA8  ldr      x8, [x2, #0x60]
006A74BAC  mov      x0, x19
006A74BB0  mov      w1, w20
006A74BB4  blr      x8
006A74BB8  ldp      x20, x19, [sp, #0x10]
006A74BBC  mov      w0, #1
006A74BC0  ldp      x30, x21, [sp], #0x20
006A74BC4  ret      

