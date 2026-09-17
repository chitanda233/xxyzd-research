; LocalModels.Bean.ChapterMulti_MultiPlayer$$readImpl
; RVA 0x689A338; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689A338  stp      x30, x21, [sp, #-0x20]!
00689A33C  stp      x20, x19, [sp, #0x10]
00689A340  adrp     x20, #0x959b000
00689A344  adrp     x21, #0x8f25000
00689A348  ldrb     w8, [x20, #0xe3e]
00689A34C  ldr      x21, [x21, #0xf70]
00689A350  mov      x19, x0
00689A354  tbnz     w8, #0, #0x689a36c
00689A358  adrp     x0, #0x8f25000
00689A35C  ldr      x0, [x0, #0xf70]
00689A360  bl       #0x382bd14 ; 
00689A364  mov      w8, #1
00689A368  strb     w8, [x20, #0xe3e]
00689A36C  ldr      x1, [x21]
00689A370  ldrb     w8, [x1, #0x53]
00689A374  tbnz     w8, #5, #0x689a3c4
00689A378  mov      x0, x19
00689A37C  mov      x1, xzr
00689A380  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A384  adrp     x21, #0x959c000
00689A388  ldrb     w8, [x21, #0x4b4]
00689A38C  mov      w20, w0
00689A390  cbnz     w8, #0x689a3a8
00689A394  adrp     x0, #0x8f25000
00689A398  ldr      x0, [x0, #0xca8]
00689A39C  bl       #0x382bd14 ; 
00689A3A0  mov      w8, #1
00689A3A4  strb     w8, [x21, #0x4b4]
00689A3A8  adrp     x8, #0x8f25000
00689A3AC  ldr      x8, [x8, #0xca8]
00689A3B0  ldr      x2, [x8]
00689A3B4  ldrb     w8, [x2, #0x53]
00689A3B8  tbnz     w8, #5, #0x689a3d8
00689A3BC  str      w20, [x19, #0x20]
00689A3C0  b        #0x689a3e8 ; 
00689A3C4  ldr      x2, [x1, #0x60]
00689A3C8  mov      x0, x19
00689A3CC  ldp      x20, x19, [sp, #0x10]
00689A3D0  ldp      x30, x21, [sp], #0x20
00689A3D4  br       x2
00689A3D8  ldr      x8, [x2, #0x60]
00689A3DC  mov      x0, x19
00689A3E0  mov      w1, w20
00689A3E4  blr      x8
00689A3E8  mov      x0, x19
00689A3EC  mov      x1, xzr
00689A3F0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00689A3F4  adrp     x21, #0x959c000
00689A3F8  ldrb     w8, [x21, #0x4b5]
00689A3FC  mov      x20, x0
00689A400  cbnz     w8, #0x689a418
00689A404  adrp     x0, #0x8f25000
00689A408  ldr      x0, [x0, #0xcb8]
00689A40C  bl       #0x382bd14 ; 
00689A410  mov      w8, #1
00689A414  strb     w8, [x21, #0x4b5]
00689A418  adrp     x8, #0x8f25000
00689A41C  ldr      x8, [x8, #0xcb8]
00689A420  ldr      x2, [x8]
00689A424  ldrb     w8, [x2, #0x53]
00689A428  tbnz     w8, #5, #0x689a440
00689A42C  mov      x0, x19
00689A430  str      x20, [x0, #0x28]!
00689A434  mov      x1, x20
00689A438  bl       #0x382bcb8 ; 
00689A43C  b        #0x689a450 ; 
00689A440  ldr      x8, [x2, #0x60]
00689A444  mov      x0, x19
00689A448  mov      x1, x20
00689A44C  blr      x8
00689A450  mov      x0, x19
00689A454  mov      x1, xzr
00689A458  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00689A45C  adrp     x21, #0x959c000
00689A460  ldrb     w8, [x21, #0x4b6]
00689A464  mov      x20, x0
00689A468  cbnz     w8, #0x689a480
00689A46C  adrp     x0, #0x8f25000
00689A470  ldr      x0, [x0, #0xcc8]
00689A474  bl       #0x382bd14 ; 
00689A478  mov      w8, #1
00689A47C  strb     w8, [x21, #0x4b6]
00689A480  adrp     x8, #0x8f25000
00689A484  ldr      x8, [x8, #0xcc8]
00689A488  ldr      x2, [x8]
00689A48C  ldrb     w8, [x2, #0x53]
00689A490  tbnz     w8, #5, #0x689a4a8
00689A494  mov      x0, x19
00689A498  str      x20, [x0, #0x30]!
00689A49C  mov      x1, x20
00689A4A0  bl       #0x382bcb8 ; 
00689A4A4  b        #0x689a4b8 ; 
00689A4A8  ldr      x8, [x2, #0x60]
00689A4AC  mov      x0, x19
00689A4B0  mov      x1, x20
00689A4B4  blr      x8
00689A4B8  mov      x0, x19
00689A4BC  mov      x1, xzr
00689A4C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A4C4  adrp     x21, #0x959c000
00689A4C8  ldrb     w8, [x21, #0x4b7]
00689A4CC  mov      w20, w0
00689A4D0  cbnz     w8, #0x689a4e8
00689A4D4  adrp     x0, #0x8f25000
00689A4D8  ldr      x0, [x0, #0xcd8]
00689A4DC  bl       #0x382bd14 ; 
00689A4E0  mov      w8, #1
00689A4E4  strb     w8, [x21, #0x4b7]
00689A4E8  adrp     x8, #0x8f25000
00689A4EC  ldr      x8, [x8, #0xcd8]
00689A4F0  ldr      x2, [x8]
00689A4F4  ldrb     w8, [x2, #0x53]
00689A4F8  tbnz     w8, #5, #0x689a504
00689A4FC  str      w20, [x19, #0x38]
00689A500  b        #0x689a514 ; 
00689A504  ldr      x8, [x2, #0x60]
00689A508  mov      x0, x19
00689A50C  mov      w1, w20
00689A510  blr      x8
00689A514  mov      x0, x19
00689A518  mov      x1, xzr
00689A51C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689A520  adrp     x21, #0x959c000
00689A524  ldrb     w8, [x21, #0x4b8]
00689A528  mov      x20, x0
00689A52C  cbnz     w8, #0x689a544
00689A530  adrp     x0, #0x8f25000
00689A534  ldr      x0, [x0, #0xce8]
00689A538  bl       #0x382bd14 ; 
00689A53C  mov      w8, #1
00689A540  strb     w8, [x21, #0x4b8]
00689A544  adrp     x8, #0x8f25000
00689A548  ldr      x8, [x8, #0xce8]
00689A54C  ldr      x2, [x8]
00689A550  ldrb     w8, [x2, #0x53]
00689A554  tbnz     w8, #5, #0x689a56c
00689A558  mov      x0, x19
00689A55C  str      x20, [x0, #0x40]!
00689A560  mov      x1, x20
00689A564  bl       #0x382bcb8 ; 
00689A568  b        #0x689a57c ; 
00689A56C  ldr      x8, [x2, #0x60]
00689A570  mov      x0, x19
00689A574  mov      x1, x20
00689A578  blr      x8
00689A57C  mov      x0, x19
00689A580  mov      x1, xzr
00689A584  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A588  adrp     x21, #0x959c000
00689A58C  ldrb     w8, [x21, #0x4b9]
00689A590  mov      w20, w0
00689A594  cbnz     w8, #0x689a5ac
00689A598  adrp     x0, #0x8f25000
00689A59C  ldr      x0, [x0, #0xcf8]
00689A5A0  bl       #0x382bd14 ; 
00689A5A4  mov      w8, #1
00689A5A8  strb     w8, [x21, #0x4b9]
00689A5AC  adrp     x8, #0x8f25000
00689A5B0  ldr      x8, [x8, #0xcf8]
00689A5B4  ldr      x2, [x8]
00689A5B8  ldrb     w8, [x2, #0x53]
00689A5BC  tbnz     w8, #5, #0x689a5c8
00689A5C0  str      w20, [x19, #0x48]
00689A5C4  b        #0x689a5d8 ; 
00689A5C8  ldr      x8, [x2, #0x60]
00689A5CC  mov      x0, x19
00689A5D0  mov      w1, w20
00689A5D4  blr      x8
00689A5D8  mov      x0, x19
00689A5DC  mov      x1, xzr
00689A5E0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689A5E4  adrp     x21, #0x959c000
00689A5E8  ldrb     w8, [x21, #0x4ba]
00689A5EC  mov      x20, x0
00689A5F0  cbnz     w8, #0x689a608
00689A5F4  adrp     x0, #0x8f25000
00689A5F8  ldr      x0, [x0, #0xd08]
00689A5FC  bl       #0x382bd14 ; 
00689A600  mov      w8, #1
00689A604  strb     w8, [x21, #0x4ba]
00689A608  adrp     x8, #0x8f25000
00689A60C  ldr      x8, [x8, #0xd08]
00689A610  ldr      x2, [x8]
00689A614  ldrb     w8, [x2, #0x53]
00689A618  tbnz     w8, #5, #0x689a624
00689A61C  str      x20, [x19, #0x50]
00689A620  b        #0x689a634 ; 
00689A624  ldr      x8, [x2, #0x60]
00689A628  mov      x0, x19
00689A62C  mov      x1, x20
00689A630  blr      x8
00689A634  mov      x0, x19
00689A638  mov      x1, xzr
00689A63C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689A640  adrp     x21, #0x959c000
00689A644  ldrb     w8, [x21, #0x4bb]
00689A648  mov      x20, x0
00689A64C  cbnz     w8, #0x689a664
00689A650  adrp     x0, #0x8f25000
00689A654  ldr      x0, [x0, #0xd18]
00689A658  bl       #0x382bd14 ; 
00689A65C  mov      w8, #1
00689A660  strb     w8, [x21, #0x4bb]
00689A664  adrp     x8, #0x8f25000
00689A668  ldr      x8, [x8, #0xd18]
00689A66C  ldr      x2, [x8]
00689A670  ldrb     w8, [x2, #0x53]
00689A674  tbnz     w8, #5, #0x689a680
00689A678  str      x20, [x19, #0x58]
00689A67C  b        #0x689a690 ; 
00689A680  ldr      x8, [x2, #0x60]
00689A684  mov      x0, x19
00689A688  mov      x1, x20
00689A68C  blr      x8
00689A690  mov      x0, x19
00689A694  mov      x1, xzr
00689A698  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689A69C  adrp     x21, #0x959c000
00689A6A0  ldrb     w8, [x21, #0x4bc]
00689A6A4  mov      x20, x0
00689A6A8  cbnz     w8, #0x689a6c0
00689A6AC  adrp     x0, #0x8f25000
00689A6B0  ldr      x0, [x0, #0xd28]
00689A6B4  bl       #0x382bd14 ; 
00689A6B8  mov      w8, #1
00689A6BC  strb     w8, [x21, #0x4bc]
00689A6C0  adrp     x8, #0x8f25000
00689A6C4  ldr      x8, [x8, #0xd28]
00689A6C8  ldr      x2, [x8]
00689A6CC  ldrb     w8, [x2, #0x53]
00689A6D0  tbnz     w8, #5, #0x689a6dc
00689A6D4  str      x20, [x19, #0x60]
00689A6D8  b        #0x689a6ec ; 
00689A6DC  ldr      x8, [x2, #0x60]
00689A6E0  mov      x0, x19
00689A6E4  mov      x1, x20
00689A6E8  blr      x8
00689A6EC  mov      x0, x19
00689A6F0  mov      x1, xzr
00689A6F4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689A6F8  adrp     x21, #0x959c000
00689A6FC  ldrb     w8, [x21, #0x4bd]
00689A700  mov      x20, x0
00689A704  cbnz     w8, #0x689a71c
00689A708  adrp     x0, #0x8f25000
00689A70C  ldr      x0, [x0, #0xd38]
00689A710  bl       #0x382bd14 ; 
00689A714  mov      w8, #1
00689A718  strb     w8, [x21, #0x4bd]
00689A71C  adrp     x8, #0x8f25000
00689A720  ldr      x8, [x8, #0xd38]
00689A724  ldr      x2, [x8]
00689A728  ldrb     w8, [x2, #0x53]
00689A72C  tbnz     w8, #5, #0x689a738
00689A730  str      x20, [x19, #0x68]
00689A734  b        #0x689a748 ; 
00689A738  ldr      x8, [x2, #0x60]
00689A73C  mov      x0, x19
00689A740  mov      x1, x20
00689A744  blr      x8
00689A748  mov      x0, x19
00689A74C  mov      x1, xzr
00689A750  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A754  adrp     x21, #0x959c000
00689A758  ldrb     w8, [x21, #0x4be]
00689A75C  mov      w20, w0
00689A760  cbnz     w8, #0x689a778
00689A764  adrp     x0, #0x8f25000
00689A768  ldr      x0, [x0, #0xd48]
00689A76C  bl       #0x382bd14 ; 
00689A770  mov      w8, #1
00689A774  strb     w8, [x21, #0x4be]
00689A778  adrp     x8, #0x8f25000
00689A77C  ldr      x8, [x8, #0xd48]
00689A780  ldr      x2, [x8]
00689A784  ldrb     w8, [x2, #0x53]
00689A788  tbnz     w8, #5, #0x689a794
00689A78C  str      w20, [x19, #0x70]
00689A790  b        #0x689a7a4 ; 
00689A794  ldr      x8, [x2, #0x60]
00689A798  mov      x0, x19
00689A79C  mov      w1, w20
00689A7A0  blr      x8
00689A7A4  mov      x0, x19
00689A7A8  mov      x1, xzr
00689A7AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A7B0  adrp     x21, #0x959c000
00689A7B4  ldrb     w8, [x21, #0x4bf]
00689A7B8  mov      w20, w0
00689A7BC  cbnz     w8, #0x689a7d4
00689A7C0  adrp     x0, #0x8f25000
00689A7C4  ldr      x0, [x0, #0xd58]
00689A7C8  bl       #0x382bd14 ; 
00689A7CC  mov      w8, #1
00689A7D0  strb     w8, [x21, #0x4bf]
00689A7D4  adrp     x8, #0x8f25000
00689A7D8  ldr      x8, [x8, #0xd58]
00689A7DC  ldr      x2, [x8]
00689A7E0  ldrb     w8, [x2, #0x53]
00689A7E4  tbnz     w8, #5, #0x689a7f0
00689A7E8  str      w20, [x19, #0x74]
00689A7EC  b        #0x689a800 ; 
00689A7F0  ldr      x8, [x2, #0x60]
00689A7F4  mov      x0, x19
00689A7F8  mov      w1, w20
00689A7FC  blr      x8
00689A800  mov      x0, x19
00689A804  mov      x1, xzr
00689A808  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A80C  adrp     x21, #0x959c000
00689A810  ldrb     w8, [x21, #0x4c0]
00689A814  mov      w20, w0
00689A818  cbnz     w8, #0x689a830
00689A81C  adrp     x0, #0x8f25000
00689A820  ldr      x0, [x0, #0xd68]
00689A824  bl       #0x382bd14 ; 
00689A828  mov      w8, #1
00689A82C  strb     w8, [x21, #0x4c0]
00689A830  adrp     x8, #0x8f25000
00689A834  ldr      x8, [x8, #0xd68]
00689A838  ldr      x2, [x8]
00689A83C  ldrb     w8, [x2, #0x53]
00689A840  tbnz     w8, #5, #0x689a84c
00689A844  str      w20, [x19, #0x78]
00689A848  b        #0x689a85c ; 
00689A84C  ldr      x8, [x2, #0x60]
00689A850  mov      x0, x19
00689A854  mov      w1, w20
00689A858  blr      x8
00689A85C  mov      x0, x19
00689A860  mov      x1, xzr
00689A864  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
00689A868  adrp     x21, #0x959c000
00689A86C  ldrb     w8, [x21, #0x4c1]
00689A870  mov      x20, x0
00689A874  cbnz     w8, #0x689a88c
00689A878  adrp     x0, #0x8f25000
00689A87C  ldr      x0, [x0, #0xd78]
00689A880  bl       #0x382bd14 ; 
00689A884  mov      w8, #1
00689A888  strb     w8, [x21, #0x4c1]
00689A88C  adrp     x8, #0x8f25000
00689A890  ldr      x8, [x8, #0xd78]
00689A894  ldr      x2, [x8]
00689A898  ldrb     w8, [x2, #0x53]
00689A89C  tbnz     w8, #5, #0x689a8b4
00689A8A0  mov      x0, x19
00689A8A4  str      x20, [x0, #0x80]!
00689A8A8  mov      x1, x20
00689A8AC  bl       #0x382bcb8 ; 
00689A8B0  b        #0x689a8c4 ; 
00689A8B4  ldr      x8, [x2, #0x60]
00689A8B8  mov      x0, x19
00689A8BC  mov      x1, x20
00689A8C0  blr      x8
00689A8C4  mov      x0, x19
00689A8C8  mov      x1, xzr
00689A8CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A8D0  adrp     x21, #0x959c000
00689A8D4  ldrb     w8, [x21, #0x4c2]
00689A8D8  mov      w20, w0
00689A8DC  cbnz     w8, #0x689a8f4
00689A8E0  adrp     x0, #0x8f25000
00689A8E4  ldr      x0, [x0, #0xd88]
00689A8E8  bl       #0x382bd14 ; 
00689A8EC  mov      w8, #1
00689A8F0  strb     w8, [x21, #0x4c2]
00689A8F4  adrp     x8, #0x8f25000
00689A8F8  ldr      x8, [x8, #0xd88]
00689A8FC  ldr      x2, [x8]
00689A900  ldrb     w8, [x2, #0x53]
00689A904  tbnz     w8, #5, #0x689a910
00689A908  str      w20, [x19, #0x88]
00689A90C  b        #0x689a920 ; 
00689A910  ldr      x8, [x2, #0x60]
00689A914  mov      x0, x19
00689A918  mov      w1, w20
00689A91C  blr      x8
00689A920  mov      x0, x19
00689A924  mov      x1, xzr
00689A928  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689A92C  adrp     x21, #0x959c000
00689A930  ldrb     w8, [x21, #0x4c3]
00689A934  mov      x20, x0
00689A938  cbnz     w8, #0x689a950
00689A93C  adrp     x0, #0x8f25000
00689A940  ldr      x0, [x0, #0xd98]
00689A944  bl       #0x382bd14 ; 
00689A948  mov      w8, #1
00689A94C  strb     w8, [x21, #0x4c3]
00689A950  adrp     x8, #0x8f25000
00689A954  ldr      x8, [x8, #0xd98]
00689A958  ldr      x2, [x8]
00689A95C  ldrb     w8, [x2, #0x53]
00689A960  tbnz     w8, #5, #0x689a978
00689A964  mov      x0, x19
00689A968  str      x20, [x0, #0x90]!
00689A96C  mov      x1, x20
00689A970  bl       #0x382bcb8 ; 
00689A974  b        #0x689a988 ; 
00689A978  ldr      x8, [x2, #0x60]
00689A97C  mov      x0, x19
00689A980  mov      x1, x20
00689A984  blr      x8
00689A988  mov      x0, x19
00689A98C  mov      x1, xzr
00689A990  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689A994  adrp     x21, #0x959c000
00689A998  ldrb     w8, [x21, #0x4c4]
00689A99C  mov      w20, w0
00689A9A0  cbnz     w8, #0x689a9b8
00689A9A4  adrp     x0, #0x8f25000
00689A9A8  ldr      x0, [x0, #0xda8]
00689A9AC  bl       #0x382bd14 ; 
00689A9B0  mov      w8, #1
00689A9B4  strb     w8, [x21, #0x4c4]
00689A9B8  adrp     x8, #0x8f25000
00689A9BC  ldr      x8, [x8, #0xda8]
00689A9C0  ldr      x2, [x8]
00689A9C4  ldrb     w8, [x2, #0x53]
00689A9C8  tbnz     w8, #5, #0x689a9d4
00689A9CC  str      w20, [x19, #0x98]
00689A9D0  b        #0x689a9e4 ; 
00689A9D4  ldr      x8, [x2, #0x60]
00689A9D8  mov      x0, x19
00689A9DC  mov      w1, w20
00689A9E0  blr      x8
00689A9E4  mov      x0, x19
00689A9E8  mov      x1, xzr
00689A9EC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
00689A9F0  adrp     x21, #0x959c000
00689A9F4  ldrb     w8, [x21, #0x4c5]
00689A9F8  mov      x20, x0
00689A9FC  cbnz     w8, #0x689aa14
00689AA00  adrp     x0, #0x8f25000
00689AA04  ldr      x0, [x0, #0xdb8]
00689AA08  bl       #0x382bd14 ; 
00689AA0C  mov      w8, #1
00689AA10  strb     w8, [x21, #0x4c5]
00689AA14  adrp     x8, #0x8f25000
00689AA18  ldr      x8, [x8, #0xdb8]
00689AA1C  ldr      x2, [x8]
00689AA20  ldrb     w8, [x2, #0x53]
00689AA24  tbnz     w8, #5, #0x689aa3c
00689AA28  mov      x0, x19
00689AA2C  str      x20, [x0, #0xa0]!
00689AA30  mov      x1, x20
00689AA34  bl       #0x382bcb8 ; 
00689AA38  b        #0x689aa4c ; 
00689AA3C  ldr      x8, [x2, #0x60]
00689AA40  mov      x0, x19
00689AA44  mov      x1, x20
00689AA48  blr      x8
00689AA4C  mov      x0, x19
00689AA50  mov      x1, xzr
00689AA54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AA58  adrp     x21, #0x959c000
00689AA5C  ldrb     w8, [x21, #0x4c6]
00689AA60  mov      w20, w0
00689AA64  cbnz     w8, #0x689aa7c
00689AA68  adrp     x0, #0x8f25000
00689AA6C  ldr      x0, [x0, #0xdc8]
00689AA70  bl       #0x382bd14 ; 
00689AA74  mov      w8, #1
00689AA78  strb     w8, [x21, #0x4c6]
00689AA7C  adrp     x8, #0x8f25000
00689AA80  ldr      x8, [x8, #0xdc8]
00689AA84  ldr      x2, [x8]
00689AA88  ldrb     w8, [x2, #0x53]
00689AA8C  tbnz     w8, #5, #0x689aa98
00689AA90  str      w20, [x19, #0xa8]
00689AA94  b        #0x689aaa8 ; 
00689AA98  ldr      x8, [x2, #0x60]
00689AA9C  mov      x0, x19
00689AAA0  mov      w1, w20
00689AAA4  blr      x8
00689AAA8  mov      x0, x19
00689AAAC  mov      x1, xzr
00689AAB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AAB4  adrp     x21, #0x959c000
00689AAB8  ldrb     w8, [x21, #0x4c7]
00689AABC  mov      w20, w0
00689AAC0  cbnz     w8, #0x689aad8
00689AAC4  adrp     x0, #0x8f25000
00689AAC8  ldr      x0, [x0, #0xdd8]
00689AACC  bl       #0x382bd14 ; 
00689AAD0  mov      w8, #1
00689AAD4  strb     w8, [x21, #0x4c7]
00689AAD8  adrp     x8, #0x8f25000
00689AADC  ldr      x8, [x8, #0xdd8]
00689AAE0  ldr      x2, [x8]
00689AAE4  ldrb     w8, [x2, #0x53]
00689AAE8  tbnz     w8, #5, #0x689aaf4
00689AAEC  str      w20, [x19, #0xac]
00689AAF0  b        #0x689ab04 ; 
00689AAF4  ldr      x8, [x2, #0x60]
00689AAF8  mov      x0, x19
00689AAFC  mov      w1, w20
00689AB00  blr      x8
00689AB04  mov      x0, x19
00689AB08  mov      x1, xzr
00689AB0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AB10  adrp     x21, #0x959c000
00689AB14  ldrb     w8, [x21, #0x4c8]
00689AB18  mov      w20, w0
00689AB1C  cbnz     w8, #0x689ab34
00689AB20  adrp     x0, #0x8f25000
00689AB24  ldr      x0, [x0, #0xde8]
00689AB28  bl       #0x382bd14 ; 
00689AB2C  mov      w8, #1
00689AB30  strb     w8, [x21, #0x4c8]
00689AB34  adrp     x8, #0x8f25000
00689AB38  ldr      x8, [x8, #0xde8]
00689AB3C  ldr      x2, [x8]
00689AB40  ldrb     w8, [x2, #0x53]
00689AB44  tbnz     w8, #5, #0x689ab50
00689AB48  str      w20, [x19, #0xb0]
00689AB4C  b        #0x689ab60 ; 
00689AB50  ldr      x8, [x2, #0x60]
00689AB54  mov      x0, x19
00689AB58  mov      w1, w20
00689AB5C  blr      x8
00689AB60  mov      x0, x19
00689AB64  mov      x1, xzr
00689AB68  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689AB6C  adrp     x21, #0x959c000
00689AB70  ldrb     w8, [x21, #0x4c9]
00689AB74  mov      x20, x0
00689AB78  cbnz     w8, #0x689ab90
00689AB7C  adrp     x0, #0x8f25000
00689AB80  ldr      x0, [x0, #0xdf8]
00689AB84  bl       #0x382bd14 ; 
00689AB88  mov      w8, #1
00689AB8C  strb     w8, [x21, #0x4c9]
00689AB90  adrp     x8, #0x8f25000
00689AB94  ldr      x8, [x8, #0xdf8]
00689AB98  ldr      x2, [x8]
00689AB9C  ldrb     w8, [x2, #0x53]
00689ABA0  tbnz     w8, #5, #0x689abb8
00689ABA4  mov      x0, x19
00689ABA8  str      x20, [x0, #0xb8]!
00689ABAC  mov      x1, x20
00689ABB0  bl       #0x382bcb8 ; 
00689ABB4  b        #0x689abc8 ; 
00689ABB8  ldr      x8, [x2, #0x60]
00689ABBC  mov      x0, x19
00689ABC0  mov      x1, x20
00689ABC4  blr      x8
00689ABC8  mov      x0, x19
00689ABCC  mov      x1, xzr
00689ABD0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689ABD4  adrp     x21, #0x959c000
00689ABD8  ldrb     w8, [x21, #0x4ca]
00689ABDC  mov      x20, x0
00689ABE0  cbnz     w8, #0x689abf8
00689ABE4  adrp     x0, #0x8f25000
00689ABE8  ldr      x0, [x0, #0xe08]
00689ABEC  bl       #0x382bd14 ; 
00689ABF0  mov      w8, #1
00689ABF4  strb     w8, [x21, #0x4ca]
00689ABF8  adrp     x8, #0x8f25000
00689ABFC  ldr      x8, [x8, #0xe08]
00689AC00  ldr      x2, [x8]
00689AC04  ldrb     w8, [x2, #0x53]
00689AC08  tbnz     w8, #5, #0x689ac20
00689AC0C  mov      x0, x19
00689AC10  str      x20, [x0, #0xc0]!
00689AC14  mov      x1, x20
00689AC18  bl       #0x382bcb8 ; 
00689AC1C  b        #0x689ac30 ; 
00689AC20  ldr      x8, [x2, #0x60]
00689AC24  mov      x0, x19
00689AC28  mov      x1, x20
00689AC2C  blr      x8
00689AC30  mov      x0, x19
00689AC34  mov      x1, xzr
00689AC38  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689AC3C  adrp     x21, #0x959c000
00689AC40  ldrb     w8, [x21, #0x4cb]
00689AC44  mov      x20, x0
00689AC48  cbnz     w8, #0x689ac60
00689AC4C  adrp     x0, #0x8f25000
00689AC50  ldr      x0, [x0, #0xe18]
00689AC54  bl       #0x382bd14 ; 
00689AC58  mov      w8, #1
00689AC5C  strb     w8, [x21, #0x4cb]
00689AC60  adrp     x8, #0x8f25000
00689AC64  ldr      x8, [x8, #0xe18]
00689AC68  ldr      x2, [x8]
00689AC6C  ldrb     w8, [x2, #0x53]
00689AC70  tbnz     w8, #5, #0x689ac88
00689AC74  mov      x0, x19
00689AC78  str      x20, [x0, #0xc8]!
00689AC7C  mov      x1, x20
00689AC80  bl       #0x382bcb8 ; 
00689AC84  b        #0x689ac98 ; 
00689AC88  ldr      x8, [x2, #0x60]
00689AC8C  mov      x0, x19
00689AC90  mov      x1, x20
00689AC94  blr      x8
00689AC98  mov      x0, x19
00689AC9C  mov      x1, xzr
00689ACA0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689ACA4  adrp     x21, #0x959c000
00689ACA8  ldrb     w8, [x21, #0x4cc]
00689ACAC  mov      x20, x0
00689ACB0  cbnz     w8, #0x689acc8
00689ACB4  adrp     x0, #0x8f25000
00689ACB8  ldr      x0, [x0, #0xe28]
00689ACBC  bl       #0x382bd14 ; 
00689ACC0  mov      w8, #1
00689ACC4  strb     w8, [x21, #0x4cc]
00689ACC8  adrp     x8, #0x8f25000
00689ACCC  ldr      x8, [x8, #0xe28]
00689ACD0  ldr      x2, [x8]
00689ACD4  ldrb     w8, [x2, #0x53]
00689ACD8  tbnz     w8, #5, #0x689acf0
00689ACDC  mov      x0, x19
00689ACE0  str      x20, [x0, #0xd0]!
00689ACE4  mov      x1, x20
00689ACE8  bl       #0x382bcb8 ; 
00689ACEC  b        #0x689ad00 ; 
00689ACF0  ldr      x8, [x2, #0x60]
00689ACF4  mov      x0, x19
00689ACF8  mov      x1, x20
00689ACFC  blr      x8
00689AD00  mov      x0, x19
00689AD04  mov      x1, xzr
00689AD08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AD0C  adrp     x21, #0x959c000
00689AD10  ldrb     w8, [x21, #0x4cd]
00689AD14  mov      w20, w0
00689AD18  cbnz     w8, #0x689ad30
00689AD1C  adrp     x0, #0x8f25000
00689AD20  ldr      x0, [x0, #0xe38]
00689AD24  bl       #0x382bd14 ; 
00689AD28  mov      w8, #1
00689AD2C  strb     w8, [x21, #0x4cd]
00689AD30  adrp     x8, #0x8f25000
00689AD34  ldr      x8, [x8, #0xe38]
00689AD38  ldr      x2, [x8]
00689AD3C  ldrb     w8, [x2, #0x53]
00689AD40  tbnz     w8, #5, #0x689ad4c
00689AD44  str      w20, [x19, #0xd8]
00689AD48  b        #0x689ad5c ; 
00689AD4C  ldr      x8, [x2, #0x60]
00689AD50  mov      x0, x19
00689AD54  mov      w1, w20
00689AD58  blr      x8
00689AD5C  mov      x0, x19
00689AD60  mov      x1, xzr
00689AD64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AD68  adrp     x21, #0x959c000
00689AD6C  ldrb     w8, [x21, #0x4ce]
00689AD70  mov      w20, w0
00689AD74  cbnz     w8, #0x689ad8c
00689AD78  adrp     x0, #0x8f25000
00689AD7C  ldr      x0, [x0, #0xe48]
00689AD80  bl       #0x382bd14 ; 
00689AD84  mov      w8, #1
00689AD88  strb     w8, [x21, #0x4ce]
00689AD8C  adrp     x8, #0x8f25000
00689AD90  ldr      x8, [x8, #0xe48]
00689AD94  ldr      x2, [x8]
00689AD98  ldrb     w8, [x2, #0x53]
00689AD9C  tbnz     w8, #5, #0x689ada8
00689ADA0  str      w20, [x19, #0xdc]
00689ADA4  b        #0x689adb8 ; 
00689ADA8  ldr      x8, [x2, #0x60]
00689ADAC  mov      x0, x19
00689ADB0  mov      w1, w20
00689ADB4  blr      x8
00689ADB8  mov      x0, x19
00689ADBC  mov      x1, xzr
00689ADC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689ADC4  adrp     x21, #0x959c000
00689ADC8  ldrb     w8, [x21, #0x4cf]
00689ADCC  mov      w20, w0
00689ADD0  cbnz     w8, #0x689ade8
00689ADD4  adrp     x0, #0x8f25000
00689ADD8  ldr      x0, [x0, #0xe58]
00689ADDC  bl       #0x382bd14 ; 
00689ADE0  mov      w8, #1
00689ADE4  strb     w8, [x21, #0x4cf]
00689ADE8  adrp     x8, #0x8f25000
00689ADEC  ldr      x8, [x8, #0xe58]
00689ADF0  ldr      x2, [x8]
00689ADF4  ldrb     w8, [x2, #0x53]
00689ADF8  tbnz     w8, #5, #0x689ae04
00689ADFC  str      w20, [x19, #0xe0]
00689AE00  b        #0x689ae14 ; 
00689AE04  ldr      x8, [x2, #0x60]
00689AE08  mov      x0, x19
00689AE0C  mov      w1, w20
00689AE10  blr      x8
00689AE14  mov      x0, x19
00689AE18  mov      x1, xzr
00689AE1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AE20  adrp     x21, #0x959c000
00689AE24  ldrb     w8, [x21, #0x4d0]
00689AE28  mov      w20, w0
00689AE2C  cbnz     w8, #0x689ae44
00689AE30  adrp     x0, #0x8f25000
00689AE34  ldr      x0, [x0, #0xe68]
00689AE38  bl       #0x382bd14 ; 
00689AE3C  mov      w8, #1
00689AE40  strb     w8, [x21, #0x4d0]
00689AE44  adrp     x8, #0x8f25000
00689AE48  ldr      x8, [x8, #0xe68]
00689AE4C  ldr      x2, [x8]
00689AE50  ldrb     w8, [x2, #0x53]
00689AE54  tbnz     w8, #5, #0x689ae60
00689AE58  str      w20, [x19, #0xe4]
00689AE5C  b        #0x689ae70 ; 
00689AE60  ldr      x8, [x2, #0x60]
00689AE64  mov      x0, x19
00689AE68  mov      w1, w20
00689AE6C  blr      x8
00689AE70  mov      x0, x19
00689AE74  mov      x1, xzr
00689AE78  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00689AE7C  adrp     x21, #0x959c000
00689AE80  ldrb     w8, [x21, #0x4d1]
00689AE84  mov      x20, x0
00689AE88  cbnz     w8, #0x689aea0
00689AE8C  adrp     x0, #0x8f25000
00689AE90  ldr      x0, [x0, #0xe78]
00689AE94  bl       #0x382bd14 ; 
00689AE98  mov      w8, #1
00689AE9C  strb     w8, [x21, #0x4d1]
00689AEA0  adrp     x8, #0x8f25000
00689AEA4  ldr      x8, [x8, #0xe78]
00689AEA8  ldr      x2, [x8]
00689AEAC  ldrb     w8, [x2, #0x53]
00689AEB0  tbnz     w8, #5, #0x689aebc
00689AEB4  str      x20, [x19, #0xe8]
00689AEB8  b        #0x689aecc ; 
00689AEBC  ldr      x8, [x2, #0x60]
00689AEC0  mov      x0, x19
00689AEC4  mov      x1, x20
00689AEC8  blr      x8
00689AECC  mov      x0, x19
00689AED0  mov      x1, xzr
00689AED4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AED8  adrp     x21, #0x959c000
00689AEDC  ldrb     w8, [x21, #0x4d2]
00689AEE0  mov      w20, w0
00689AEE4  cbnz     w8, #0x689aefc
00689AEE8  adrp     x0, #0x8f25000
00689AEEC  ldr      x0, [x0, #0xe88]
00689AEF0  bl       #0x382bd14 ; 
00689AEF4  mov      w8, #1
00689AEF8  strb     w8, [x21, #0x4d2]
00689AEFC  adrp     x8, #0x8f25000
00689AF00  ldr      x8, [x8, #0xe88]
00689AF04  ldr      x2, [x8]
00689AF08  ldrb     w8, [x2, #0x53]
00689AF0C  tbnz     w8, #5, #0x689af18
00689AF10  str      w20, [x19, #0xf0]
00689AF14  b        #0x689af28 ; 
00689AF18  ldr      x8, [x2, #0x60]
00689AF1C  mov      x0, x19
00689AF20  mov      w1, w20
00689AF24  blr      x8
00689AF28  mov      x0, x19
00689AF2C  mov      x1, xzr
00689AF30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689AF34  adrp     x21, #0x959c000
00689AF38  ldrb     w8, [x21, #0x4d3]
00689AF3C  mov      w20, w0
00689AF40  cbnz     w8, #0x689af58
00689AF44  adrp     x0, #0x8f25000
00689AF48  ldr      x0, [x0, #0xe98]
00689AF4C  bl       #0x382bd14 ; 
00689AF50  mov      w8, #1
00689AF54  strb     w8, [x21, #0x4d3]
00689AF58  adrp     x8, #0x8f25000
00689AF5C  ldr      x8, [x8, #0xe98]
00689AF60  ldr      x2, [x8]
00689AF64  ldrb     w8, [x2, #0x53]
00689AF68  tbnz     w8, #5, #0x689af74
00689AF6C  str      w20, [x19, #0xf4]
00689AF70  b        #0x689af84 ; 
00689AF74  ldr      x8, [x2, #0x60]
00689AF78  mov      x0, x19
00689AF7C  mov      w1, w20
00689AF80  blr      x8
00689AF84  mov      x0, x19
00689AF88  mov      x1, xzr
00689AF8C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
00689AF90  adrp     x21, #0x959c000
00689AF94  ldrb     w8, [x21, #0x4d4]
00689AF98  mov      x20, x0
00689AF9C  cbnz     w8, #0x689afb4
00689AFA0  adrp     x0, #0x8f25000
00689AFA4  ldr      x0, [x0, #0xea8]
00689AFA8  bl       #0x382bd14 ; 
00689AFAC  mov      w8, #1
00689AFB0  strb     w8, [x21, #0x4d4]
00689AFB4  adrp     x8, #0x8f25000
00689AFB8  ldr      x8, [x8, #0xea8]
00689AFBC  ldr      x2, [x8]
00689AFC0  ldrb     w8, [x2, #0x53]
00689AFC4  tbnz     w8, #5, #0x689afdc
00689AFC8  mov      x0, x19
00689AFCC  str      x20, [x0, #0xf8]!
00689AFD0  mov      x1, x20
00689AFD4  bl       #0x382bcb8 ; 
00689AFD8  b        #0x689afec ; 
00689AFDC  ldr      x8, [x2, #0x60]
00689AFE0  mov      x0, x19
00689AFE4  mov      x1, x20
00689AFE8  blr      x8
00689AFEC  mov      x0, x19
00689AFF0  mov      x1, xzr
00689AFF4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689AFF8  adrp     x21, #0x959c000
00689AFFC  ldrb     w8, [x21, #0x4d5]
00689B000  mov      x20, x0
00689B004  cbnz     w8, #0x689b01c
00689B008  adrp     x0, #0x8f25000
00689B00C  ldr      x0, [x0, #0xeb8]
00689B010  bl       #0x382bd14 ; 
00689B014  mov      w8, #1
00689B018  strb     w8, [x21, #0x4d5]
00689B01C  adrp     x8, #0x8f25000
00689B020  ldr      x8, [x8, #0xeb8]
00689B024  ldr      x2, [x8]
00689B028  ldrb     w8, [x2, #0x53]
00689B02C  tbnz     w8, #5, #0x689b044
00689B030  add      x0, x19, #0x100
00689B034  mov      x1, x20
00689B038  str      x20, [x19, #0x100]
00689B03C  bl       #0x382bcb8 ; 
00689B040  b        #0x689b054 ; 
00689B044  ldr      x8, [x2, #0x60]
00689B048  mov      x0, x19
00689B04C  mov      x1, x20
00689B050  blr      x8
00689B054  mov      x0, x19
00689B058  mov      x1, xzr
00689B05C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689B060  adrp     x21, #0x959c000
00689B064  ldrb     w8, [x21, #0x4d6]
00689B068  mov      w20, w0
00689B06C  cbnz     w8, #0x689b084
00689B070  adrp     x0, #0x8f25000
00689B074  ldr      x0, [x0, #0xec8]
00689B078  bl       #0x382bd14 ; 
00689B07C  mov      w8, #1
00689B080  strb     w8, [x21, #0x4d6]
00689B084  adrp     x8, #0x8f25000
00689B088  ldr      x8, [x8, #0xec8]
00689B08C  ldr      x2, [x8]
00689B090  ldrb     w8, [x2, #0x53]
00689B094  tbnz     w8, #5, #0x689b0a0
00689B098  str      w20, [x19, #0x108]
00689B09C  b        #0x689b0b0 ; 
00689B0A0  ldr      x8, [x2, #0x60]
00689B0A4  mov      x0, x19
00689B0A8  mov      w1, w20
00689B0AC  blr      x8
00689B0B0  mov      x0, x19
00689B0B4  mov      x1, xzr
00689B0B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689B0BC  adrp     x21, #0x959c000
00689B0C0  ldrb     w8, [x21, #0x4d7]
00689B0C4  mov      w20, w0
00689B0C8  cbnz     w8, #0x689b0e0
00689B0CC  adrp     x0, #0x8f25000
00689B0D0  ldr      x0, [x0, #0xed8]
00689B0D4  bl       #0x382bd14 ; 
00689B0D8  mov      w8, #1
00689B0DC  strb     w8, [x21, #0x4d7]
00689B0E0  adrp     x8, #0x8f25000
00689B0E4  ldr      x8, [x8, #0xed8]
00689B0E8  ldr      x2, [x8]
00689B0EC  ldrb     w8, [x2, #0x53]
00689B0F0  tbnz     w8, #5, #0x689b0fc
00689B0F4  str      w20, [x19, #0x10c]
00689B0F8  b        #0x689b10c ; 
00689B0FC  ldr      x8, [x2, #0x60]
00689B100  mov      x0, x19
00689B104  mov      w1, w20
00689B108  blr      x8
00689B10C  mov      x0, x19
00689B110  mov      x1, xzr
00689B114  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B118  adrp     x21, #0x959c000
00689B11C  ldrb     w8, [x21, #0x4d8]
00689B120  mov      x20, x0
00689B124  cbnz     w8, #0x689b13c
00689B128  adrp     x0, #0x8f25000
00689B12C  ldr      x0, [x0, #0xee8]
00689B130  bl       #0x382bd14 ; 
00689B134  mov      w8, #1
00689B138  strb     w8, [x21, #0x4d8]
00689B13C  adrp     x8, #0x8f25000
00689B140  ldr      x8, [x8, #0xee8]
00689B144  ldr      x2, [x8]
00689B148  ldrb     w8, [x2, #0x53]
00689B14C  tbnz     w8, #5, #0x689b164
00689B150  add      x0, x19, #0x110
00689B154  mov      x1, x20
00689B158  str      x20, [x19, #0x110]
00689B15C  bl       #0x382bcb8 ; 
00689B160  b        #0x689b174 ; 
00689B164  ldr      x8, [x2, #0x60]
00689B168  mov      x0, x19
00689B16C  mov      x1, x20
00689B170  blr      x8
00689B174  mov      x0, x19
00689B178  mov      x1, xzr
00689B17C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B180  adrp     x21, #0x959c000
00689B184  ldrb     w8, [x21, #0x4d9]
00689B188  mov      x20, x0
00689B18C  cbnz     w8, #0x689b1a4
00689B190  adrp     x0, #0x8f25000
00689B194  ldr      x0, [x0, #0xef8]
00689B198  bl       #0x382bd14 ; 
00689B19C  mov      w8, #1
00689B1A0  strb     w8, [x21, #0x4d9]
00689B1A4  adrp     x8, #0x8f25000
00689B1A8  ldr      x8, [x8, #0xef8]
00689B1AC  ldr      x2, [x8]
00689B1B0  ldrb     w8, [x2, #0x53]
00689B1B4  tbnz     w8, #5, #0x689b1cc
00689B1B8  add      x0, x19, #0x118
00689B1BC  mov      x1, x20
00689B1C0  str      x20, [x19, #0x118]
00689B1C4  bl       #0x382bcb8 ; 
00689B1C8  b        #0x689b1dc ; 
00689B1CC  ldr      x8, [x2, #0x60]
00689B1D0  mov      x0, x19
00689B1D4  mov      x1, x20
00689B1D8  blr      x8
00689B1DC  mov      x0, x19
00689B1E0  mov      x1, xzr
00689B1E4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B1E8  adrp     x21, #0x959c000
00689B1EC  ldrb     w8, [x21, #0x4da]
00689B1F0  mov      x20, x0
00689B1F4  cbnz     w8, #0x689b20c
00689B1F8  adrp     x0, #0x8f25000
00689B1FC  ldr      x0, [x0, #0xf08]
00689B200  bl       #0x382bd14 ; 
00689B204  mov      w8, #1
00689B208  strb     w8, [x21, #0x4da]
00689B20C  adrp     x8, #0x8f25000
00689B210  ldr      x8, [x8, #0xf08]
00689B214  ldr      x2, [x8]
00689B218  ldrb     w8, [x2, #0x53]
00689B21C  tbnz     w8, #5, #0x689b234
00689B220  add      x0, x19, #0x120
00689B224  mov      x1, x20
00689B228  str      x20, [x19, #0x120]
00689B22C  bl       #0x382bcb8 ; 
00689B230  b        #0x689b244 ; 
00689B234  ldr      x8, [x2, #0x60]
00689B238  mov      x0, x19
00689B23C  mov      x1, x20
00689B240  blr      x8
00689B244  mov      x0, x19
00689B248  mov      x1, xzr
00689B24C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B250  adrp     x21, #0x959c000
00689B254  ldrb     w8, [x21, #0x4db]
00689B258  mov      x20, x0
00689B25C  cbnz     w8, #0x689b274
00689B260  adrp     x0, #0x8f25000
00689B264  ldr      x0, [x0, #0xf18]
00689B268  bl       #0x382bd14 ; 
00689B26C  mov      w8, #1
00689B270  strb     w8, [x21, #0x4db]
00689B274  adrp     x8, #0x8f25000
00689B278  ldr      x8, [x8, #0xf18]
00689B27C  ldr      x2, [x8]
00689B280  ldrb     w8, [x2, #0x53]
00689B284  tbnz     w8, #5, #0x689b29c
00689B288  add      x0, x19, #0x128
00689B28C  mov      x1, x20
00689B290  str      x20, [x19, #0x128]
00689B294  bl       #0x382bcb8 ; 
00689B298  b        #0x689b2ac ; 
00689B29C  ldr      x8, [x2, #0x60]
00689B2A0  mov      x0, x19
00689B2A4  mov      x1, x20
00689B2A8  blr      x8
00689B2AC  mov      x0, x19
00689B2B0  mov      x1, xzr
00689B2B4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B2B8  adrp     x21, #0x959c000
00689B2BC  ldrb     w8, [x21, #0x4dc]
00689B2C0  mov      x20, x0
00689B2C4  cbnz     w8, #0x689b2dc
00689B2C8  adrp     x0, #0x8f25000
00689B2CC  ldr      x0, [x0, #0xf28]
00689B2D0  bl       #0x382bd14 ; 
00689B2D4  mov      w8, #1
00689B2D8  strb     w8, [x21, #0x4dc]
00689B2DC  adrp     x8, #0x8f25000
00689B2E0  ldr      x8, [x8, #0xf28]
00689B2E4  ldr      x2, [x8]
00689B2E8  ldrb     w8, [x2, #0x53]
00689B2EC  tbnz     w8, #5, #0x689b304
00689B2F0  add      x0, x19, #0x130
00689B2F4  mov      x1, x20
00689B2F8  str      x20, [x19, #0x130]
00689B2FC  bl       #0x382bcb8 ; 
00689B300  b        #0x689b314 ; 
00689B304  ldr      x8, [x2, #0x60]
00689B308  mov      x0, x19
00689B30C  mov      x1, x20
00689B310  blr      x8
00689B314  mov      x0, x19
00689B318  mov      x1, xzr
00689B31C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B320  adrp     x21, #0x959c000
00689B324  ldrb     w8, [x21, #0x4dd]
00689B328  mov      x20, x0
00689B32C  cbnz     w8, #0x689b344
00689B330  adrp     x0, #0x8f25000
00689B334  ldr      x0, [x0, #0xf38]
00689B338  bl       #0x382bd14 ; 
00689B33C  mov      w8, #1
00689B340  strb     w8, [x21, #0x4dd]
00689B344  adrp     x8, #0x8f25000
00689B348  ldr      x8, [x8, #0xf38]
00689B34C  ldr      x2, [x8]
00689B350  ldrb     w8, [x2, #0x53]
00689B354  tbnz     w8, #5, #0x689b36c
00689B358  add      x0, x19, #0x138
00689B35C  mov      x1, x20
00689B360  str      x20, [x19, #0x138]
00689B364  bl       #0x382bcb8 ; 
00689B368  b        #0x689b37c ; 
00689B36C  ldr      x8, [x2, #0x60]
00689B370  mov      x0, x19
00689B374  mov      x1, x20
00689B378  blr      x8
00689B37C  mov      x0, x19
00689B380  mov      x1, xzr
00689B384  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B388  adrp     x21, #0x959c000
00689B38C  ldrb     w8, [x21, #0x4de]
00689B390  mov      x20, x0
00689B394  cbnz     w8, #0x689b3ac
00689B398  adrp     x0, #0x8f25000
00689B39C  ldr      x0, [x0, #0xf48]
00689B3A0  bl       #0x382bd14 ; 
00689B3A4  mov      w8, #1
00689B3A8  strb     w8, [x21, #0x4de]
00689B3AC  adrp     x8, #0x8f25000
00689B3B0  ldr      x8, [x8, #0xf48]
00689B3B4  ldr      x2, [x8]
00689B3B8  ldrb     w8, [x2, #0x53]
00689B3BC  tbnz     w8, #5, #0x689b3d4
00689B3C0  add      x0, x19, #0x140
00689B3C4  mov      x1, x20
00689B3C8  str      x20, [x19, #0x140]
00689B3CC  bl       #0x382bcb8 ; 
00689B3D0  b        #0x689b3e4 ; 
00689B3D4  ldr      x8, [x2, #0x60]
00689B3D8  mov      x0, x19
00689B3DC  mov      x1, x20
00689B3E0  blr      x8
00689B3E4  mov      x0, x19
00689B3E8  mov      x1, xzr
00689B3EC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B3F0  adrp     x21, #0x959c000
00689B3F4  ldrb     w8, [x21, #0x4df]
00689B3F8  mov      x20, x0
00689B3FC  cbnz     w8, #0x689b414
00689B400  adrp     x0, #0x8f25000
00689B404  ldr      x0, [x0, #0xf58]
00689B408  bl       #0x382bd14 ; 
00689B40C  mov      w8, #1
00689B410  strb     w8, [x21, #0x4df]
00689B414  adrp     x8, #0x8f25000
00689B418  ldr      x8, [x8, #0xf58]
00689B41C  ldr      x2, [x8]
00689B420  ldrb     w8, [x2, #0x53]
00689B424  tbnz     w8, #5, #0x689b43c
00689B428  add      x0, x19, #0x148
00689B42C  mov      x1, x20
00689B430  str      x20, [x19, #0x148]
00689B434  bl       #0x382bcb8 ; 
00689B438  b        #0x689b44c ; 
00689B43C  ldr      x8, [x2, #0x60]
00689B440  mov      x0, x19
00689B444  mov      x1, x20
00689B448  blr      x8
00689B44C  mov      x0, x19
00689B450  mov      x1, xzr
00689B454  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
00689B458  adrp     x21, #0x959c000
00689B45C  ldrb     w8, [x21, #0x4e0]
00689B460  mov      x20, x0
00689B464  cbnz     w8, #0x689b47c
00689B468  adrp     x0, #0x8f25000
00689B46C  ldr      x0, [x0, #0xf68]
00689B470  bl       #0x382bd14 ; 
00689B474  mov      w8, #1
00689B478  strb     w8, [x21, #0x4e0]
00689B47C  adrp     x8, #0x8f25000
00689B480  ldr      x8, [x8, #0xf68]
00689B484  ldr      x2, [x8]
00689B488  ldrb     w8, [x2, #0x53]
00689B48C  tbnz     w8, #5, #0x689b4a4
00689B490  add      x0, x19, #0x150
00689B494  mov      x1, x20
00689B498  str      x20, [x19, #0x150]
00689B49C  bl       #0x382bcb8 ; 
00689B4A0  b        #0x689b4b4 ; 
00689B4A4  ldr      x8, [x2, #0x60]
00689B4A8  mov      x0, x19
00689B4AC  mov      x1, x20
00689B4B0  blr      x8
00689B4B4  ldp      x20, x19, [sp, #0x10]
00689B4B8  mov      w0, #1
00689B4BC  ldp      x30, x21, [sp], #0x20
00689B4C0  ret      

