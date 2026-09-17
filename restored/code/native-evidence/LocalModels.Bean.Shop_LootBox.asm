; LocalModels.Bean.Shop_LootBox$$readImpl
; RVA 0x6AEB6B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEB6B8  stp      x30, x21, [sp, #-0x20]!
006AEB6BC  stp      x20, x19, [sp, #0x10]
006AEB6C0  adrp     x20, #0x959e000
006AEB6C4  adrp     x21, #0x8f3d000
006AEB6C8  ldrb     w8, [x20, #0xddd]
006AEB6CC  ldr      x21, [x21, #0x248]
006AEB6D0  mov      x19, x0
006AEB6D4  tbnz     w8, #0, #0x6aeb6ec
006AEB6D8  adrp     x0, #0x8f3d000
006AEB6DC  ldr      x0, [x0, #0x248]
006AEB6E0  bl       #0x382bd14 ; 
006AEB6E4  mov      w8, #1
006AEB6E8  strb     w8, [x20, #0xddd]
006AEB6EC  ldr      x1, [x21]
006AEB6F0  ldrb     w8, [x1, #0x53]
006AEB6F4  tbnz     w8, #5, #0x6aeb744
006AEB6F8  mov      x0, x19
006AEB6FC  mov      x1, xzr
006AEB700  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEB704  adrp     x21, #0x959f000
006AEB708  ldrb     w8, [x21, #0x20a]
006AEB70C  mov      w20, w0
006AEB710  cbnz     w8, #0x6aeb728
006AEB714  adrp     x0, #0x8f3d000
006AEB718  ldr      x0, [x0, #0x1b0]
006AEB71C  bl       #0x382bd14 ; 
006AEB720  mov      w8, #1
006AEB724  strb     w8, [x21, #0x20a]
006AEB728  adrp     x8, #0x8f3d000
006AEB72C  ldr      x8, [x8, #0x1b0]
006AEB730  ldr      x2, [x8]
006AEB734  ldrb     w8, [x2, #0x53]
006AEB738  tbnz     w8, #5, #0x6aeb758
006AEB73C  str      w20, [x19, #0x20]
006AEB740  b        #0x6aeb768 ; 
006AEB744  ldr      x2, [x1, #0x60]
006AEB748  mov      x0, x19
006AEB74C  ldp      x20, x19, [sp, #0x10]
006AEB750  ldp      x30, x21, [sp], #0x20
006AEB754  br       x2
006AEB758  ldr      x8, [x2, #0x60]
006AEB75C  mov      x0, x19
006AEB760  mov      w1, w20
006AEB764  blr      x8
006AEB768  mov      x0, x19
006AEB76C  mov      x1, xzr
006AEB770  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEB774  adrp     x21, #0x959f000
006AEB778  ldrb     w8, [x21, #0x20b]
006AEB77C  mov      w20, w0
006AEB780  cbnz     w8, #0x6aeb798
006AEB784  adrp     x0, #0x8f3d000
006AEB788  ldr      x0, [x0, #0x1c0]
006AEB78C  bl       #0x382bd14 ; 
006AEB790  mov      w8, #1
006AEB794  strb     w8, [x21, #0x20b]
006AEB798  adrp     x8, #0x8f3d000
006AEB79C  ldr      x8, [x8, #0x1c0]
006AEB7A0  ldr      x2, [x8]
006AEB7A4  ldrb     w8, [x2, #0x53]
006AEB7A8  tbnz     w8, #5, #0x6aeb7b4
006AEB7AC  str      w20, [x19, #0x24]
006AEB7B0  b        #0x6aeb7c4 ; 
006AEB7B4  ldr      x8, [x2, #0x60]
006AEB7B8  mov      x0, x19
006AEB7BC  mov      w1, w20
006AEB7C0  blr      x8
006AEB7C4  mov      x0, x19
006AEB7C8  mov      x1, xzr
006AEB7CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEB7D0  adrp     x21, #0x959f000
006AEB7D4  ldrb     w8, [x21, #0x20c]
006AEB7D8  mov      w20, w0
006AEB7DC  cbnz     w8, #0x6aeb7f4
006AEB7E0  adrp     x0, #0x8f3d000
006AEB7E4  ldr      x0, [x0, #0x1d0]
006AEB7E8  bl       #0x382bd14 ; 
006AEB7EC  mov      w8, #1
006AEB7F0  strb     w8, [x21, #0x20c]
006AEB7F4  adrp     x8, #0x8f3d000
006AEB7F8  ldr      x8, [x8, #0x1d0]
006AEB7FC  ldr      x2, [x8]
006AEB800  ldrb     w8, [x2, #0x53]
006AEB804  tbnz     w8, #5, #0x6aeb810
006AEB808  str      w20, [x19, #0x28]
006AEB80C  b        #0x6aeb820 ; 
006AEB810  ldr      x8, [x2, #0x60]
006AEB814  mov      x0, x19
006AEB818  mov      w1, w20
006AEB81C  blr      x8
006AEB820  mov      x0, x19
006AEB824  mov      x1, xzr
006AEB828  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEB82C  adrp     x21, #0x959f000
006AEB830  ldrb     w8, [x21, #0x20d]
006AEB834  mov      w20, w0
006AEB838  cbnz     w8, #0x6aeb850
006AEB83C  adrp     x0, #0x8f3d000
006AEB840  ldr      x0, [x0, #0x1e0]
006AEB844  bl       #0x382bd14 ; 
006AEB848  mov      w8, #1
006AEB84C  strb     w8, [x21, #0x20d]
006AEB850  adrp     x8, #0x8f3d000
006AEB854  ldr      x8, [x8, #0x1e0]
006AEB858  ldr      x2, [x8]
006AEB85C  ldrb     w8, [x2, #0x53]
006AEB860  tbnz     w8, #5, #0x6aeb86c
006AEB864  str      w20, [x19, #0x2c]
006AEB868  b        #0x6aeb87c ; 
006AEB86C  ldr      x8, [x2, #0x60]
006AEB870  mov      x0, x19
006AEB874  mov      w1, w20
006AEB878  blr      x8
006AEB87C  mov      x0, x19
006AEB880  mov      x1, xzr
006AEB884  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEB888  adrp     x21, #0x959f000
006AEB88C  ldrb     w8, [x21, #0x20e]
006AEB890  mov      w20, w0
006AEB894  cbnz     w8, #0x6aeb8ac
006AEB898  adrp     x0, #0x8f3d000
006AEB89C  ldr      x0, [x0, #0x1f0]
006AEB8A0  bl       #0x382bd14 ; 
006AEB8A4  mov      w8, #1
006AEB8A8  strb     w8, [x21, #0x20e]
006AEB8AC  adrp     x8, #0x8f3d000
006AEB8B0  ldr      x8, [x8, #0x1f0]
006AEB8B4  ldr      x2, [x8]
006AEB8B8  ldrb     w8, [x2, #0x53]
006AEB8BC  tbnz     w8, #5, #0x6aeb8c8
006AEB8C0  str      w20, [x19, #0x30]
006AEB8C4  b        #0x6aeb8d8 ; 
006AEB8C8  ldr      x8, [x2, #0x60]
006AEB8CC  mov      x0, x19
006AEB8D0  mov      w1, w20
006AEB8D4  blr      x8
006AEB8D8  mov      x0, x19
006AEB8DC  mov      x1, xzr
006AEB8E0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AEB8E4  adrp     x21, #0x959f000
006AEB8E8  ldrb     w8, [x21, #0x20f]
006AEB8EC  mov      x20, x0
006AEB8F0  cbnz     w8, #0x6aeb908
006AEB8F4  adrp     x0, #0x8f3d000
006AEB8F8  ldr      x0, [x0, #0x200]
006AEB8FC  bl       #0x382bd14 ; 
006AEB900  mov      w8, #1
006AEB904  strb     w8, [x21, #0x20f]
006AEB908  adrp     x8, #0x8f3d000
006AEB90C  ldr      x8, [x8, #0x200]
006AEB910  ldr      x2, [x8]
006AEB914  ldrb     w8, [x2, #0x53]
006AEB918  tbnz     w8, #5, #0x6aeb930
006AEB91C  mov      x0, x19
006AEB920  str      x20, [x0, #0x38]!
006AEB924  mov      x1, x20
006AEB928  bl       #0x382bcb8 ; 
006AEB92C  b        #0x6aeb940 ; 
006AEB930  ldr      x8, [x2, #0x60]
006AEB934  mov      x0, x19
006AEB938  mov      x1, x20
006AEB93C  blr      x8
006AEB940  mov      x0, x19
006AEB944  mov      x1, xzr
006AEB948  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEB94C  adrp     x21, #0x959f000
006AEB950  ldrb     w8, [x21, #0x210]
006AEB954  mov      w20, w0
006AEB958  cbnz     w8, #0x6aeb970
006AEB95C  adrp     x0, #0x8f3d000
006AEB960  ldr      x0, [x0, #0x210]
006AEB964  bl       #0x382bd14 ; 
006AEB968  mov      w8, #1
006AEB96C  strb     w8, [x21, #0x210]
006AEB970  adrp     x8, #0x8f3d000
006AEB974  ldr      x8, [x8, #0x210]
006AEB978  ldr      x2, [x8]
006AEB97C  ldrb     w8, [x2, #0x53]
006AEB980  tbnz     w8, #5, #0x6aeb98c
006AEB984  str      w20, [x19, #0x40]
006AEB988  b        #0x6aeb99c ; 
006AEB98C  ldr      x8, [x2, #0x60]
006AEB990  mov      x0, x19
006AEB994  mov      w1, w20
006AEB998  blr      x8
006AEB99C  mov      x0, x19
006AEB9A0  mov      x1, xzr
006AEB9A4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AEB9A8  adrp     x21, #0x959f000
006AEB9AC  ldrb     w8, [x21, #0x211]
006AEB9B0  mov      x20, x0
006AEB9B4  cbnz     w8, #0x6aeb9cc
006AEB9B8  adrp     x0, #0x8f3d000
006AEB9BC  ldr      x0, [x0, #0x220]
006AEB9C0  bl       #0x382bd14 ; 
006AEB9C4  mov      w8, #1
006AEB9C8  strb     w8, [x21, #0x211]
006AEB9CC  adrp     x8, #0x8f3d000
006AEB9D0  ldr      x8, [x8, #0x220]
006AEB9D4  ldr      x2, [x8]
006AEB9D8  ldrb     w8, [x2, #0x53]
006AEB9DC  tbnz     w8, #5, #0x6aeb9f4
006AEB9E0  mov      x0, x19
006AEB9E4  str      x20, [x0, #0x48]!
006AEB9E8  mov      x1, x20
006AEB9EC  bl       #0x382bcb8 ; 
006AEB9F0  b        #0x6aeba04 ; 
006AEB9F4  ldr      x8, [x2, #0x60]
006AEB9F8  mov      x0, x19
006AEB9FC  mov      x1, x20
006AEBA00  blr      x8
006AEBA04  mov      x0, x19
006AEBA08  mov      x1, xzr
006AEBA0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEBA10  adrp     x21, #0x959f000
006AEBA14  ldrb     w8, [x21, #0x212]
006AEBA18  mov      w20, w0
006AEBA1C  cbnz     w8, #0x6aeba34
006AEBA20  adrp     x0, #0x8f3d000
006AEBA24  ldr      x0, [x0, #0x230]
006AEBA28  bl       #0x382bd14 ; 
006AEBA2C  mov      w8, #1
006AEBA30  strb     w8, [x21, #0x212]
006AEBA34  adrp     x8, #0x8f3d000
006AEBA38  ldr      x8, [x8, #0x230]
006AEBA3C  ldr      x2, [x8]
006AEBA40  ldrb     w8, [x2, #0x53]
006AEBA44  tbnz     w8, #5, #0x6aeba50
006AEBA48  str      w20, [x19, #0x50]
006AEBA4C  b        #0x6aeba60 ; 
006AEBA50  ldr      x8, [x2, #0x60]
006AEBA54  mov      x0, x19
006AEBA58  mov      w1, w20
006AEBA5C  blr      x8
006AEBA60  mov      x0, x19
006AEBA64  mov      x1, xzr
006AEBA68  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AEBA6C  adrp     x21, #0x959f000
006AEBA70  ldrb     w8, [x21, #0x213]
006AEBA74  mov      x20, x0
006AEBA78  cbnz     w8, #0x6aeba90
006AEBA7C  adrp     x0, #0x8f3d000
006AEBA80  ldr      x0, [x0, #0x240]
006AEBA84  bl       #0x382bd14 ; 
006AEBA88  mov      w8, #1
006AEBA8C  strb     w8, [x21, #0x213]
006AEBA90  adrp     x8, #0x8f3d000
006AEBA94  ldr      x8, [x8, #0x240]
006AEBA98  ldr      x2, [x8]
006AEBA9C  ldrb     w8, [x2, #0x53]
006AEBAA0  tbnz     w8, #5, #0x6aebab8
006AEBAA4  str      x20, [x19, #0x58]!
006AEBAA8  mov      x0, x19
006AEBAAC  mov      x1, x20
006AEBAB0  bl       #0x382bcb8 ; 
006AEBAB4  b        #0x6aebac8 ; 
006AEBAB8  ldr      x8, [x2, #0x60]
006AEBABC  mov      x0, x19
006AEBAC0  mov      x1, x20
006AEBAC4  blr      x8
006AEBAC8  ldp      x20, x19, [sp, #0x10]
006AEBACC  mov      w0, #1
006AEBAD0  ldp      x30, x21, [sp], #0x20
006AEBAD4  ret      

