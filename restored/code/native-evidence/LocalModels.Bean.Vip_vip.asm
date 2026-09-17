; LocalModels.Bean.Vip_vip$$readImpl
; RVA 0x6B1E240; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B1E240  stp      x30, x21, [sp, #-0x20]!
006B1E244  stp      x20, x19, [sp, #0x10]
006B1E248  adrp     x20, #0x959f000
006B1E24C  adrp     x21, #0x8f3f000
006B1E250  ldrb     w8, [x20, #0x6aa]
006B1E254  ldr      x21, [x21, #0x6c8]
006B1E258  mov      x19, x0
006B1E25C  tbnz     w8, #0, #0x6b1e274
006B1E260  adrp     x0, #0x8f3f000
006B1E264  ldr      x0, [x0, #0x6c8]
006B1E268  bl       #0x382bd14 ; 
006B1E26C  mov      w8, #1
006B1E270  strb     w8, [x20, #0x6aa]
006B1E274  ldr      x1, [x21]
006B1E278  ldrb     w8, [x1, #0x53]
006B1E27C  tbnz     w8, #5, #0x6b1e2cc
006B1E280  mov      x0, x19
006B1E284  mov      x1, xzr
006B1E288  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1E28C  adrp     x21, #0x959f000
006B1E290  ldrb     w8, [x21, #0xa35]
006B1E294  mov      w20, w0
006B1E298  cbnz     w8, #0x6b1e2b0
006B1E29C  adrp     x0, #0x8f3f000
006B1E2A0  ldr      x0, [x0, #0x5e0]
006B1E2A4  bl       #0x382bd14 ; 
006B1E2A8  mov      w8, #1
006B1E2AC  strb     w8, [x21, #0xa35]
006B1E2B0  adrp     x8, #0x8f3f000
006B1E2B4  ldr      x8, [x8, #0x5e0]
006B1E2B8  ldr      x2, [x8]
006B1E2BC  ldrb     w8, [x2, #0x53]
006B1E2C0  tbnz     w8, #5, #0x6b1e2e0
006B1E2C4  str      w20, [x19, #0x20]
006B1E2C8  b        #0x6b1e2f0 ; 
006B1E2CC  ldr      x2, [x1, #0x60]
006B1E2D0  mov      x0, x19
006B1E2D4  ldp      x20, x19, [sp, #0x10]
006B1E2D8  ldp      x30, x21, [sp], #0x20
006B1E2DC  br       x2
006B1E2E0  ldr      x8, [x2, #0x60]
006B1E2E4  mov      x0, x19
006B1E2E8  mov      w1, w20
006B1E2EC  blr      x8
006B1E2F0  mov      x0, x19
006B1E2F4  mov      x1, xzr
006B1E2F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1E2FC  adrp     x21, #0x959f000
006B1E300  ldrb     w8, [x21, #0xa36]
006B1E304  mov      w20, w0
006B1E308  cbnz     w8, #0x6b1e320
006B1E30C  adrp     x0, #0x8f3f000
006B1E310  ldr      x0, [x0, #0x5f0]
006B1E314  bl       #0x382bd14 ; 
006B1E318  mov      w8, #1
006B1E31C  strb     w8, [x21, #0xa36]
006B1E320  adrp     x8, #0x8f3f000
006B1E324  ldr      x8, [x8, #0x5f0]
006B1E328  ldr      x2, [x8]
006B1E32C  ldrb     w8, [x2, #0x53]
006B1E330  tbnz     w8, #5, #0x6b1e33c
006B1E334  str      w20, [x19, #0x24]
006B1E338  b        #0x6b1e34c ; 
006B1E33C  ldr      x8, [x2, #0x60]
006B1E340  mov      x0, x19
006B1E344  mov      w1, w20
006B1E348  blr      x8
006B1E34C  mov      x0, x19
006B1E350  mov      x1, xzr
006B1E354  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B1E358  adrp     x21, #0x959f000
006B1E35C  ldrb     w8, [x21, #0xa37]
006B1E360  mov      x20, x0
006B1E364  cbnz     w8, #0x6b1e37c
006B1E368  adrp     x0, #0x8f3f000
006B1E36C  ldr      x0, [x0, #0x600]
006B1E370  bl       #0x382bd14 ; 
006B1E374  mov      w8, #1
006B1E378  strb     w8, [x21, #0xa37]
006B1E37C  adrp     x8, #0x8f3f000
006B1E380  ldr      x8, [x8, #0x600]
006B1E384  ldr      x2, [x8]
006B1E388  ldrb     w8, [x2, #0x53]
006B1E38C  tbnz     w8, #5, #0x6b1e3a4
006B1E390  mov      x0, x19
006B1E394  str      x20, [x0, #0x28]!
006B1E398  mov      x1, x20
006B1E39C  bl       #0x382bcb8 ; 
006B1E3A0  b        #0x6b1e3b4 ; 
006B1E3A4  ldr      x8, [x2, #0x60]
006B1E3A8  mov      x0, x19
006B1E3AC  mov      x1, x20
006B1E3B0  blr      x8
006B1E3B4  mov      x0, x19
006B1E3B8  mov      x1, xzr
006B1E3BC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B1E3C0  adrp     x21, #0x959f000
006B1E3C4  ldrb     w8, [x21, #0xa38]
006B1E3C8  mov      x20, x0
006B1E3CC  cbnz     w8, #0x6b1e3e4
006B1E3D0  adrp     x0, #0x8f3f000
006B1E3D4  ldr      x0, [x0, #0x610]
006B1E3D8  bl       #0x382bd14 ; 
006B1E3DC  mov      w8, #1
006B1E3E0  strb     w8, [x21, #0xa38]
006B1E3E4  adrp     x8, #0x8f3f000
006B1E3E8  ldr      x8, [x8, #0x610]
006B1E3EC  ldr      x2, [x8]
006B1E3F0  ldrb     w8, [x2, #0x53]
006B1E3F4  tbnz     w8, #5, #0x6b1e40c
006B1E3F8  mov      x0, x19
006B1E3FC  str      x20, [x0, #0x30]!
006B1E400  mov      x1, x20
006B1E404  bl       #0x382bcb8 ; 
006B1E408  b        #0x6b1e41c ; 
006B1E40C  ldr      x8, [x2, #0x60]
006B1E410  mov      x0, x19
006B1E414  mov      x1, x20
006B1E418  blr      x8
006B1E41C  mov      x0, x19
006B1E420  mov      x1, xzr
006B1E424  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B1E428  adrp     x21, #0x959f000
006B1E42C  ldrb     w8, [x21, #0xa39]
006B1E430  mov      x20, x0
006B1E434  cbnz     w8, #0x6b1e44c
006B1E438  adrp     x0, #0x8f3f000
006B1E43C  ldr      x0, [x0, #0x620]
006B1E440  bl       #0x382bd14 ; 
006B1E444  mov      w8, #1
006B1E448  strb     w8, [x21, #0xa39]
006B1E44C  adrp     x8, #0x8f3f000
006B1E450  ldr      x8, [x8, #0x620]
006B1E454  ldr      x2, [x8]
006B1E458  ldrb     w8, [x2, #0x53]
006B1E45C  tbnz     w8, #5, #0x6b1e474
006B1E460  mov      x0, x19
006B1E464  str      x20, [x0, #0x38]!
006B1E468  mov      x1, x20
006B1E46C  bl       #0x382bcb8 ; 
006B1E470  b        #0x6b1e484 ; 
006B1E474  ldr      x8, [x2, #0x60]
006B1E478  mov      x0, x19
006B1E47C  mov      x1, x20
006B1E480  blr      x8
006B1E484  mov      x0, x19
006B1E488  mov      x1, xzr
006B1E48C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E490  adrp     x21, #0x959f000
006B1E494  ldrb     w8, [x21, #0xa3a]
006B1E498  mov      x20, x0
006B1E49C  cbnz     w8, #0x6b1e4b4
006B1E4A0  adrp     x0, #0x8f3f000
006B1E4A4  ldr      x0, [x0, #0x630]
006B1E4A8  bl       #0x382bd14 ; 
006B1E4AC  mov      w8, #1
006B1E4B0  strb     w8, [x21, #0xa3a]
006B1E4B4  adrp     x8, #0x8f3f000
006B1E4B8  ldr      x8, [x8, #0x630]
006B1E4BC  ldr      x2, [x8]
006B1E4C0  ldrb     w8, [x2, #0x53]
006B1E4C4  tbnz     w8, #5, #0x6b1e4dc
006B1E4C8  mov      x0, x19
006B1E4CC  str      x20, [x0, #0x40]!
006B1E4D0  mov      x1, x20
006B1E4D4  bl       #0x382bcb8 ; 
006B1E4D8  b        #0x6b1e4ec ; 
006B1E4DC  ldr      x8, [x2, #0x60]
006B1E4E0  mov      x0, x19
006B1E4E4  mov      x1, x20
006B1E4E8  blr      x8
006B1E4EC  mov      x0, x19
006B1E4F0  mov      x1, xzr
006B1E4F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E4F8  adrp     x21, #0x959f000
006B1E4FC  ldrb     w8, [x21, #0xa3b]
006B1E500  mov      x20, x0
006B1E504  cbnz     w8, #0x6b1e51c
006B1E508  adrp     x0, #0x8f3f000
006B1E50C  ldr      x0, [x0, #0x640]
006B1E510  bl       #0x382bd14 ; 
006B1E514  mov      w8, #1
006B1E518  strb     w8, [x21, #0xa3b]
006B1E51C  adrp     x8, #0x8f3f000
006B1E520  ldr      x8, [x8, #0x640]
006B1E524  ldr      x2, [x8]
006B1E528  ldrb     w8, [x2, #0x53]
006B1E52C  tbnz     w8, #5, #0x6b1e544
006B1E530  mov      x0, x19
006B1E534  str      x20, [x0, #0x48]!
006B1E538  mov      x1, x20
006B1E53C  bl       #0x382bcb8 ; 
006B1E540  b        #0x6b1e554 ; 
006B1E544  ldr      x8, [x2, #0x60]
006B1E548  mov      x0, x19
006B1E54C  mov      x1, x20
006B1E550  blr      x8
006B1E554  mov      x0, x19
006B1E558  mov      x1, xzr
006B1E55C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E560  adrp     x21, #0x959f000
006B1E564  ldrb     w8, [x21, #0xa3c]
006B1E568  mov      x20, x0
006B1E56C  cbnz     w8, #0x6b1e584
006B1E570  adrp     x0, #0x8f3f000
006B1E574  ldr      x0, [x0, #0x650]
006B1E578  bl       #0x382bd14 ; 
006B1E57C  mov      w8, #1
006B1E580  strb     w8, [x21, #0xa3c]
006B1E584  adrp     x8, #0x8f3f000
006B1E588  ldr      x8, [x8, #0x650]
006B1E58C  ldr      x2, [x8]
006B1E590  ldrb     w8, [x2, #0x53]
006B1E594  tbnz     w8, #5, #0x6b1e5ac
006B1E598  mov      x0, x19
006B1E59C  str      x20, [x0, #0x50]!
006B1E5A0  mov      x1, x20
006B1E5A4  bl       #0x382bcb8 ; 
006B1E5A8  b        #0x6b1e5bc ; 
006B1E5AC  ldr      x8, [x2, #0x60]
006B1E5B0  mov      x0, x19
006B1E5B4  mov      x1, x20
006B1E5B8  blr      x8
006B1E5BC  mov      x0, x19
006B1E5C0  mov      x1, xzr
006B1E5C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E5C8  adrp     x21, #0x959f000
006B1E5CC  ldrb     w8, [x21, #0xa3d]
006B1E5D0  mov      x20, x0
006B1E5D4  cbnz     w8, #0x6b1e5ec
006B1E5D8  adrp     x0, #0x8f3f000
006B1E5DC  ldr      x0, [x0, #0x660]
006B1E5E0  bl       #0x382bd14 ; 
006B1E5E4  mov      w8, #1
006B1E5E8  strb     w8, [x21, #0xa3d]
006B1E5EC  adrp     x8, #0x8f3f000
006B1E5F0  ldr      x8, [x8, #0x660]
006B1E5F4  ldr      x2, [x8]
006B1E5F8  ldrb     w8, [x2, #0x53]
006B1E5FC  tbnz     w8, #5, #0x6b1e614
006B1E600  mov      x0, x19
006B1E604  str      x20, [x0, #0x58]!
006B1E608  mov      x1, x20
006B1E60C  bl       #0x382bcb8 ; 
006B1E610  b        #0x6b1e624 ; 
006B1E614  ldr      x8, [x2, #0x60]
006B1E618  mov      x0, x19
006B1E61C  mov      x1, x20
006B1E620  blr      x8
006B1E624  mov      x0, x19
006B1E628  mov      x1, xzr
006B1E62C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E630  adrp     x21, #0x959f000
006B1E634  ldrb     w8, [x21, #0xa3e]
006B1E638  mov      x20, x0
006B1E63C  cbnz     w8, #0x6b1e654
006B1E640  adrp     x0, #0x8f3f000
006B1E644  ldr      x0, [x0, #0x670]
006B1E648  bl       #0x382bd14 ; 
006B1E64C  mov      w8, #1
006B1E650  strb     w8, [x21, #0xa3e]
006B1E654  adrp     x8, #0x8f3f000
006B1E658  ldr      x8, [x8, #0x670]
006B1E65C  ldr      x2, [x8]
006B1E660  ldrb     w8, [x2, #0x53]
006B1E664  tbnz     w8, #5, #0x6b1e67c
006B1E668  mov      x0, x19
006B1E66C  str      x20, [x0, #0x60]!
006B1E670  mov      x1, x20
006B1E674  bl       #0x382bcb8 ; 
006B1E678  b        #0x6b1e68c ; 
006B1E67C  ldr      x8, [x2, #0x60]
006B1E680  mov      x0, x19
006B1E684  mov      x1, x20
006B1E688  blr      x8
006B1E68C  mov      x0, x19
006B1E690  mov      x1, xzr
006B1E694  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E698  adrp     x21, #0x959f000
006B1E69C  ldrb     w8, [x21, #0xa3f]
006B1E6A0  mov      x20, x0
006B1E6A4  cbnz     w8, #0x6b1e6bc
006B1E6A8  adrp     x0, #0x8f3f000
006B1E6AC  ldr      x0, [x0, #0x680]
006B1E6B0  bl       #0x382bd14 ; 
006B1E6B4  mov      w8, #1
006B1E6B8  strb     w8, [x21, #0xa3f]
006B1E6BC  adrp     x8, #0x8f3f000
006B1E6C0  ldr      x8, [x8, #0x680]
006B1E6C4  ldr      x2, [x8]
006B1E6C8  ldrb     w8, [x2, #0x53]
006B1E6CC  tbnz     w8, #5, #0x6b1e6e4
006B1E6D0  mov      x0, x19
006B1E6D4  str      x20, [x0, #0x68]!
006B1E6D8  mov      x1, x20
006B1E6DC  bl       #0x382bcb8 ; 
006B1E6E0  b        #0x6b1e6f4 ; 
006B1E6E4  ldr      x8, [x2, #0x60]
006B1E6E8  mov      x0, x19
006B1E6EC  mov      x1, x20
006B1E6F0  blr      x8
006B1E6F4  mov      x0, x19
006B1E6F8  mov      x1, xzr
006B1E6FC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E700  adrp     x21, #0x959f000
006B1E704  ldrb     w8, [x21, #0xa40]
006B1E708  mov      x20, x0
006B1E70C  cbnz     w8, #0x6b1e724
006B1E710  adrp     x0, #0x8f3f000
006B1E714  ldr      x0, [x0, #0x690]
006B1E718  bl       #0x382bd14 ; 
006B1E71C  mov      w8, #1
006B1E720  strb     w8, [x21, #0xa40]
006B1E724  adrp     x8, #0x8f3f000
006B1E728  ldr      x8, [x8, #0x690]
006B1E72C  ldr      x2, [x8]
006B1E730  ldrb     w8, [x2, #0x53]
006B1E734  tbnz     w8, #5, #0x6b1e74c
006B1E738  mov      x0, x19
006B1E73C  str      x20, [x0, #0x70]!
006B1E740  mov      x1, x20
006B1E744  bl       #0x382bcb8 ; 
006B1E748  b        #0x6b1e75c ; 
006B1E74C  ldr      x8, [x2, #0x60]
006B1E750  mov      x0, x19
006B1E754  mov      x1, x20
006B1E758  blr      x8
006B1E75C  mov      x0, x19
006B1E760  mov      x1, xzr
006B1E764  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E768  adrp     x21, #0x959f000
006B1E76C  ldrb     w8, [x21, #0xa41]
006B1E770  mov      x20, x0
006B1E774  cbnz     w8, #0x6b1e78c
006B1E778  adrp     x0, #0x8f3f000
006B1E77C  ldr      x0, [x0, #0x6a0]
006B1E780  bl       #0x382bd14 ; 
006B1E784  mov      w8, #1
006B1E788  strb     w8, [x21, #0xa41]
006B1E78C  adrp     x8, #0x8f3f000
006B1E790  ldr      x8, [x8, #0x6a0]
006B1E794  ldr      x2, [x8]
006B1E798  ldrb     w8, [x2, #0x53]
006B1E79C  tbnz     w8, #5, #0x6b1e7b4
006B1E7A0  mov      x0, x19
006B1E7A4  str      x20, [x0, #0x78]!
006B1E7A8  mov      x1, x20
006B1E7AC  bl       #0x382bcb8 ; 
006B1E7B0  b        #0x6b1e7c4 ; 
006B1E7B4  ldr      x8, [x2, #0x60]
006B1E7B8  mov      x0, x19
006B1E7BC  mov      x1, x20
006B1E7C0  blr      x8
006B1E7C4  mov      x0, x19
006B1E7C8  mov      x1, xzr
006B1E7CC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E7D0  adrp     x21, #0x959f000
006B1E7D4  ldrb     w8, [x21, #0xa42]
006B1E7D8  mov      x20, x0
006B1E7DC  cbnz     w8, #0x6b1e7f4
006B1E7E0  adrp     x0, #0x8f3f000
006B1E7E4  ldr      x0, [x0, #0x6b0]
006B1E7E8  bl       #0x382bd14 ; 
006B1E7EC  mov      w8, #1
006B1E7F0  strb     w8, [x21, #0xa42]
006B1E7F4  adrp     x8, #0x8f3f000
006B1E7F8  ldr      x8, [x8, #0x6b0]
006B1E7FC  ldr      x2, [x8]
006B1E800  ldrb     w8, [x2, #0x53]
006B1E804  tbnz     w8, #5, #0x6b1e81c
006B1E808  mov      x0, x19
006B1E80C  str      x20, [x0, #0x80]!
006B1E810  mov      x1, x20
006B1E814  bl       #0x382bcb8 ; 
006B1E818  b        #0x6b1e82c ; 
006B1E81C  ldr      x8, [x2, #0x60]
006B1E820  mov      x0, x19
006B1E824  mov      x1, x20
006B1E828  blr      x8
006B1E82C  mov      x0, x19
006B1E830  mov      x1, xzr
006B1E834  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1E838  adrp     x21, #0x959f000
006B1E83C  ldrb     w8, [x21, #0xa43]
006B1E840  mov      x20, x0
006B1E844  cbnz     w8, #0x6b1e85c
006B1E848  adrp     x0, #0x8f3f000
006B1E84C  ldr      x0, [x0, #0x6c0]
006B1E850  bl       #0x382bd14 ; 
006B1E854  mov      w8, #1
006B1E858  strb     w8, [x21, #0xa43]
006B1E85C  adrp     x8, #0x8f3f000
006B1E860  ldr      x8, [x8, #0x6c0]
006B1E864  ldr      x2, [x8]
006B1E868  ldrb     w8, [x2, #0x53]
006B1E86C  tbnz     w8, #5, #0x6b1e884
006B1E870  str      x20, [x19, #0x88]!
006B1E874  mov      x0, x19
006B1E878  mov      x1, x20
006B1E87C  bl       #0x382bcb8 ; 
006B1E880  b        #0x6b1e894 ; 
006B1E884  ldr      x8, [x2, #0x60]
006B1E888  mov      x0, x19
006B1E88C  mov      x1, x20
006B1E890  blr      x8
006B1E894  ldp      x20, x19, [sp, #0x10]
006B1E898  mov      w0, #1
006B1E89C  ldp      x30, x21, [sp], #0x20
006B1E8A0  ret      

