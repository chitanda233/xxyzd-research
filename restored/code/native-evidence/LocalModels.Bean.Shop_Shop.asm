; LocalModels.Bean.Shop_Shop$$readImpl
; RVA 0x6AEF3A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEF3A0  stp      x30, x21, [sp, #-0x20]!
006AEF3A4  stp      x20, x19, [sp, #0x10]
006AEF3A8  adrp     x20, #0x959e000
006AEF3AC  adrp     x21, #0x8f3d000
006AEF3B0  ldrb     w8, [x20, #0xe45]
006AEF3B4  ldr      x21, [x21, #0x548]
006AEF3B8  mov      x19, x0
006AEF3BC  tbnz     w8, #0, #0x6aef3d4
006AEF3C0  adrp     x0, #0x8f3d000
006AEF3C4  ldr      x0, [x0, #0x548]
006AEF3C8  bl       #0x382bd14 ; 
006AEF3CC  mov      w8, #1
006AEF3D0  strb     w8, [x20, #0xe45]
006AEF3D4  ldr      x1, [x21]
006AEF3D8  ldrb     w8, [x1, #0x53]
006AEF3DC  tbnz     w8, #5, #0x6aef42c
006AEF3E0  mov      x0, x19
006AEF3E4  mov      x1, xzr
006AEF3E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEF3EC  adrp     x21, #0x959f000
006AEF3F0  ldrb     w8, [x21, #0x231]
006AEF3F4  mov      w20, w0
006AEF3F8  cbnz     w8, #0x6aef410
006AEF3FC  adrp     x0, #0x8f3d000
006AEF400  ldr      x0, [x0, #0x4a0]
006AEF404  bl       #0x382bd14 ; 
006AEF408  mov      w8, #1
006AEF40C  strb     w8, [x21, #0x231]
006AEF410  adrp     x8, #0x8f3d000
006AEF414  ldr      x8, [x8, #0x4a0]
006AEF418  ldr      x2, [x8]
006AEF41C  ldrb     w8, [x2, #0x53]
006AEF420  tbnz     w8, #5, #0x6aef440
006AEF424  str      w20, [x19, #0x20]
006AEF428  b        #0x6aef450 ; 
006AEF42C  ldr      x2, [x1, #0x60]
006AEF430  mov      x0, x19
006AEF434  ldp      x20, x19, [sp, #0x10]
006AEF438  ldp      x30, x21, [sp], #0x20
006AEF43C  br       x2
006AEF440  ldr      x8, [x2, #0x60]
006AEF444  mov      x0, x19
006AEF448  mov      w1, w20
006AEF44C  blr      x8
006AEF450  mov      x0, x19
006AEF454  mov      x1, xzr
006AEF458  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AEF45C  adrp     x21, #0x959f000
006AEF460  ldrb     w8, [x21, #0x232]
006AEF464  mov      x20, x0
006AEF468  cbnz     w8, #0x6aef480
006AEF46C  adrp     x0, #0x8f3d000
006AEF470  ldr      x0, [x0, #0x4b0]
006AEF474  bl       #0x382bd14 ; 
006AEF478  mov      w8, #1
006AEF47C  strb     w8, [x21, #0x232]
006AEF480  adrp     x8, #0x8f3d000
006AEF484  ldr      x8, [x8, #0x4b0]
006AEF488  ldr      x2, [x8]
006AEF48C  ldrb     w8, [x2, #0x53]
006AEF490  tbnz     w8, #5, #0x6aef4a8
006AEF494  mov      x0, x19
006AEF498  str      x20, [x0, #0x28]!
006AEF49C  mov      x1, x20
006AEF4A0  bl       #0x382bcb8 ; 
006AEF4A4  b        #0x6aef4b8 ; 
006AEF4A8  ldr      x8, [x2, #0x60]
006AEF4AC  mov      x0, x19
006AEF4B0  mov      x1, x20
006AEF4B4  blr      x8
006AEF4B8  mov      x0, x19
006AEF4BC  mov      x1, xzr
006AEF4C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEF4C4  adrp     x21, #0x959f000
006AEF4C8  ldrb     w8, [x21, #0x233]
006AEF4CC  mov      w20, w0
006AEF4D0  cbnz     w8, #0x6aef4e8
006AEF4D4  adrp     x0, #0x8f3d000
006AEF4D8  ldr      x0, [x0, #0x4c0]
006AEF4DC  bl       #0x382bd14 ; 
006AEF4E0  mov      w8, #1
006AEF4E4  strb     w8, [x21, #0x233]
006AEF4E8  adrp     x8, #0x8f3d000
006AEF4EC  ldr      x8, [x8, #0x4c0]
006AEF4F0  ldr      x2, [x8]
006AEF4F4  ldrb     w8, [x2, #0x53]
006AEF4F8  tbnz     w8, #5, #0x6aef504
006AEF4FC  str      w20, [x19, #0x30]
006AEF500  b        #0x6aef514 ; 
006AEF504  ldr      x8, [x2, #0x60]
006AEF508  mov      x0, x19
006AEF50C  mov      w1, w20
006AEF510  blr      x8
006AEF514  mov      x0, x19
006AEF518  mov      x1, xzr
006AEF51C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEF520  adrp     x21, #0x959f000
006AEF524  ldrb     w8, [x21, #0x234]
006AEF528  mov      w20, w0
006AEF52C  cbnz     w8, #0x6aef544
006AEF530  adrp     x0, #0x8f3d000
006AEF534  ldr      x0, [x0, #0x4d0]
006AEF538  bl       #0x382bd14 ; 
006AEF53C  mov      w8, #1
006AEF540  strb     w8, [x21, #0x234]
006AEF544  adrp     x8, #0x8f3d000
006AEF548  ldr      x8, [x8, #0x4d0]
006AEF54C  ldr      x2, [x8]
006AEF550  ldrb     w8, [x2, #0x53]
006AEF554  tbnz     w8, #5, #0x6aef560
006AEF558  str      w20, [x19, #0x34]
006AEF55C  b        #0x6aef570 ; 
006AEF560  ldr      x8, [x2, #0x60]
006AEF564  mov      x0, x19
006AEF568  mov      w1, w20
006AEF56C  blr      x8
006AEF570  mov      x0, x19
006AEF574  mov      x1, xzr
006AEF578  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEF57C  adrp     x21, #0x959f000
006AEF580  ldrb     w8, [x21, #0x235]
006AEF584  mov      w20, w0
006AEF588  cbnz     w8, #0x6aef5a0
006AEF58C  adrp     x0, #0x8f3d000
006AEF590  ldr      x0, [x0, #0x4e0]
006AEF594  bl       #0x382bd14 ; 
006AEF598  mov      w8, #1
006AEF59C  strb     w8, [x21, #0x235]
006AEF5A0  adrp     x8, #0x8f3d000
006AEF5A4  ldr      x8, [x8, #0x4e0]
006AEF5A8  ldr      x2, [x8]
006AEF5AC  ldrb     w8, [x2, #0x53]
006AEF5B0  tbnz     w8, #5, #0x6aef5bc
006AEF5B4  str      w20, [x19, #0x38]
006AEF5B8  b        #0x6aef5cc ; 
006AEF5BC  ldr      x8, [x2, #0x60]
006AEF5C0  mov      x0, x19
006AEF5C4  mov      w1, w20
006AEF5C8  blr      x8
006AEF5CC  mov      x0, x19
006AEF5D0  mov      x1, xzr
006AEF5D4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AEF5D8  adrp     x21, #0x959f000
006AEF5DC  ldrb     w8, [x21, #0x236]
006AEF5E0  mov      x20, x0
006AEF5E4  cbnz     w8, #0x6aef5fc
006AEF5E8  adrp     x0, #0x8f3d000
006AEF5EC  ldr      x0, [x0, #0x4f0]
006AEF5F0  bl       #0x382bd14 ; 
006AEF5F4  mov      w8, #1
006AEF5F8  strb     w8, [x21, #0x236]
006AEF5FC  adrp     x8, #0x8f3d000
006AEF600  ldr      x8, [x8, #0x4f0]
006AEF604  ldr      x2, [x8]
006AEF608  ldrb     w8, [x2, #0x53]
006AEF60C  tbnz     w8, #5, #0x6aef624
006AEF610  mov      x0, x19
006AEF614  str      x20, [x0, #0x40]!
006AEF618  mov      x1, x20
006AEF61C  bl       #0x382bcb8 ; 
006AEF620  b        #0x6aef634 ; 
006AEF624  ldr      x8, [x2, #0x60]
006AEF628  mov      x0, x19
006AEF62C  mov      x1, x20
006AEF630  blr      x8
006AEF634  mov      x0, x19
006AEF638  mov      x1, xzr
006AEF63C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEF640  adrp     x21, #0x959f000
006AEF644  ldrb     w8, [x21, #0x237]
006AEF648  mov      w20, w0
006AEF64C  cbnz     w8, #0x6aef664
006AEF650  adrp     x0, #0x8f3d000
006AEF654  ldr      x0, [x0, #0x500]
006AEF658  bl       #0x382bd14 ; 
006AEF65C  mov      w8, #1
006AEF660  strb     w8, [x21, #0x237]
006AEF664  adrp     x8, #0x8f3d000
006AEF668  ldr      x8, [x8, #0x500]
006AEF66C  ldr      x2, [x8]
006AEF670  ldrb     w8, [x2, #0x53]
006AEF674  tbnz     w8, #5, #0x6aef680
006AEF678  str      w20, [x19, #0x48]
006AEF67C  b        #0x6aef690 ; 
006AEF680  ldr      x8, [x2, #0x60]
006AEF684  mov      x0, x19
006AEF688  mov      w1, w20
006AEF68C  blr      x8
006AEF690  mov      x0, x19
006AEF694  mov      x1, xzr
006AEF698  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AEF69C  adrp     x21, #0x959f000
006AEF6A0  ldrb     w8, [x21, #0x238]
006AEF6A4  mov      x20, x0
006AEF6A8  cbnz     w8, #0x6aef6c0
006AEF6AC  adrp     x0, #0x8f3d000
006AEF6B0  ldr      x0, [x0, #0x510]
006AEF6B4  bl       #0x382bd14 ; 
006AEF6B8  mov      w8, #1
006AEF6BC  strb     w8, [x21, #0x238]
006AEF6C0  adrp     x8, #0x8f3d000
006AEF6C4  ldr      x8, [x8, #0x510]
006AEF6C8  ldr      x2, [x8]
006AEF6CC  ldrb     w8, [x2, #0x53]
006AEF6D0  tbnz     w8, #5, #0x6aef6e8
006AEF6D4  mov      x0, x19
006AEF6D8  str      x20, [x0, #0x50]!
006AEF6DC  mov      x1, x20
006AEF6E0  bl       #0x382bcb8 ; 
006AEF6E4  b        #0x6aef6f8 ; 
006AEF6E8  ldr      x8, [x2, #0x60]
006AEF6EC  mov      x0, x19
006AEF6F0  mov      x1, x20
006AEF6F4  blr      x8
006AEF6F8  mov      x0, x19
006AEF6FC  mov      x1, xzr
006AEF700  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AEF704  adrp     x21, #0x959f000
006AEF708  ldrb     w8, [x21, #0x239]
006AEF70C  mov      x20, x0
006AEF710  cbnz     w8, #0x6aef728
006AEF714  adrp     x0, #0x8f3d000
006AEF718  ldr      x0, [x0, #0x520]
006AEF71C  bl       #0x382bd14 ; 
006AEF720  mov      w8, #1
006AEF724  strb     w8, [x21, #0x239]
006AEF728  adrp     x8, #0x8f3d000
006AEF72C  ldr      x8, [x8, #0x520]
006AEF730  ldr      x2, [x8]
006AEF734  ldrb     w8, [x2, #0x53]
006AEF738  tbnz     w8, #5, #0x6aef750
006AEF73C  mov      x0, x19
006AEF740  str      x20, [x0, #0x58]!
006AEF744  mov      x1, x20
006AEF748  bl       #0x382bcb8 ; 
006AEF74C  b        #0x6aef760 ; 
006AEF750  ldr      x8, [x2, #0x60]
006AEF754  mov      x0, x19
006AEF758  mov      x1, x20
006AEF75C  blr      x8
006AEF760  mov      x0, x19
006AEF764  mov      x1, xzr
006AEF768  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AEF76C  adrp     x21, #0x959f000
006AEF770  ldrb     w8, [x21, #0x23a]
006AEF774  mov      x20, x0
006AEF778  cbnz     w8, #0x6aef790
006AEF77C  adrp     x0, #0x8f3d000
006AEF780  ldr      x0, [x0, #0x530]
006AEF784  bl       #0x382bd14 ; 
006AEF788  mov      w8, #1
006AEF78C  strb     w8, [x21, #0x23a]
006AEF790  adrp     x8, #0x8f3d000
006AEF794  ldr      x8, [x8, #0x530]
006AEF798  ldr      x2, [x8]
006AEF79C  ldrb     w8, [x2, #0x53]
006AEF7A0  tbnz     w8, #5, #0x6aef7b8
006AEF7A4  mov      x0, x19
006AEF7A8  str      x20, [x0, #0x60]!
006AEF7AC  mov      x1, x20
006AEF7B0  bl       #0x382bcb8 ; 
006AEF7B4  b        #0x6aef7c8 ; 
006AEF7B8  ldr      x8, [x2, #0x60]
006AEF7BC  mov      x0, x19
006AEF7C0  mov      x1, x20
006AEF7C4  blr      x8
006AEF7C8  mov      x0, x19
006AEF7CC  mov      x1, xzr
006AEF7D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEF7D4  adrp     x21, #0x959f000
006AEF7D8  ldrb     w8, [x21, #0x23b]
006AEF7DC  mov      w20, w0
006AEF7E0  cbnz     w8, #0x6aef7f8
006AEF7E4  adrp     x0, #0x8f3d000
006AEF7E8  ldr      x0, [x0, #0x540]
006AEF7EC  bl       #0x382bd14 ; 
006AEF7F0  mov      w8, #1
006AEF7F4  strb     w8, [x21, #0x23b]
006AEF7F8  adrp     x8, #0x8f3d000
006AEF7FC  ldr      x8, [x8, #0x540]
006AEF800  ldr      x2, [x8]
006AEF804  ldrb     w8, [x2, #0x53]
006AEF808  tbnz     w8, #5, #0x6aef814
006AEF80C  str      w20, [x19, #0x68]
006AEF810  b        #0x6aef824 ; 
006AEF814  ldr      x8, [x2, #0x60]
006AEF818  mov      x0, x19
006AEF81C  mov      w1, w20
006AEF820  blr      x8
006AEF824  ldp      x20, x19, [sp, #0x10]
006AEF828  mov      w0, #1
006AEF82C  ldp      x30, x21, [sp], #0x20
006AEF830  ret      

