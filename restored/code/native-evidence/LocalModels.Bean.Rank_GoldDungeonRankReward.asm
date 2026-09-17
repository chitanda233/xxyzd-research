; LocalModels.Bean.Rank_GoldDungeonRankReward$$readImpl
; RVA 0x6AD6614; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD6614  stp      x30, x21, [sp, #-0x20]!
006AD6618  stp      x20, x19, [sp, #0x10]
006AD661C  adrp     x20, #0x959e000
006AD6620  adrp     x21, #0x8f3c000
006AD6624  ldrb     w8, [x20, #0xbaf]
006AD6628  ldr      x21, [x21, #0x280]
006AD662C  mov      x19, x0
006AD6630  tbnz     w8, #0, #0x6ad6648
006AD6634  adrp     x0, #0x8f3c000
006AD6638  ldr      x0, [x0, #0x280]
006AD663C  bl       #0x382bd14 ; 
006AD6640  mov      w8, #1
006AD6644  strb     w8, [x20, #0xbaf]
006AD6648  ldr      x1, [x21]
006AD664C  ldrb     w8, [x1, #0x53]
006AD6650  tbnz     w8, #5, #0x6ad66a0
006AD6654  mov      x0, x19
006AD6658  mov      x1, xzr
006AD665C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD6660  adrp     x21, #0x959f000
006AD6664  ldrb     w8, [x21, #0x124]
006AD6668  mov      w20, w0
006AD666C  cbnz     w8, #0x6ad6684
006AD6670  adrp     x0, #0x8f3c000
006AD6674  ldr      x0, [x0, #0x258]
006AD6678  bl       #0x382bd14 ; 
006AD667C  mov      w8, #1
006AD6680  strb     w8, [x21, #0x124]
006AD6684  adrp     x8, #0x8f3c000
006AD6688  ldr      x8, [x8, #0x258]
006AD668C  ldr      x2, [x8]
006AD6690  ldrb     w8, [x2, #0x53]
006AD6694  tbnz     w8, #5, #0x6ad66b4
006AD6698  str      w20, [x19, #0x20]
006AD669C  b        #0x6ad66c4 ; 
006AD66A0  ldr      x2, [x1, #0x60]
006AD66A4  mov      x0, x19
006AD66A8  ldp      x20, x19, [sp, #0x10]
006AD66AC  ldp      x30, x21, [sp], #0x20
006AD66B0  br       x2
006AD66B4  ldr      x8, [x2, #0x60]
006AD66B8  mov      x0, x19
006AD66BC  mov      w1, w20
006AD66C0  blr      x8
006AD66C4  mov      x0, x19
006AD66C8  mov      x1, xzr
006AD66CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD66D0  adrp     x21, #0x959f000
006AD66D4  ldrb     w8, [x21, #0x125]
006AD66D8  mov      w20, w0
006AD66DC  cbnz     w8, #0x6ad66f4
006AD66E0  adrp     x0, #0x8f3c000
006AD66E4  ldr      x0, [x0, #0x268]
006AD66E8  bl       #0x382bd14 ; 
006AD66EC  mov      w8, #1
006AD66F0  strb     w8, [x21, #0x125]
006AD66F4  adrp     x8, #0x8f3c000
006AD66F8  ldr      x8, [x8, #0x268]
006AD66FC  ldr      x2, [x8]
006AD6700  ldrb     w8, [x2, #0x53]
006AD6704  tbnz     w8, #5, #0x6ad6710
006AD6708  str      w20, [x19, #0x24]
006AD670C  b        #0x6ad6720 ; 
006AD6710  ldr      x8, [x2, #0x60]
006AD6714  mov      x0, x19
006AD6718  mov      w1, w20
006AD671C  blr      x8
006AD6720  mov      x0, x19
006AD6724  mov      x1, xzr
006AD6728  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AD672C  adrp     x21, #0x959f000
006AD6730  ldrb     w8, [x21, #0x126]
006AD6734  mov      x20, x0
006AD6738  cbnz     w8, #0x6ad6750
006AD673C  adrp     x0, #0x8f3c000
006AD6740  ldr      x0, [x0, #0x278]
006AD6744  bl       #0x382bd14 ; 
006AD6748  mov      w8, #1
006AD674C  strb     w8, [x21, #0x126]
006AD6750  adrp     x8, #0x8f3c000
006AD6754  ldr      x8, [x8, #0x278]
006AD6758  ldr      x2, [x8]
006AD675C  ldrb     w8, [x2, #0x53]
006AD6760  tbnz     w8, #5, #0x6ad6778
006AD6764  str      x20, [x19, #0x28]!
006AD6768  mov      x0, x19
006AD676C  mov      x1, x20
006AD6770  bl       #0x382bcb8 ; 
006AD6774  b        #0x6ad6788 ; 
006AD6778  ldr      x8, [x2, #0x60]
006AD677C  mov      x0, x19
006AD6780  mov      x1, x20
006AD6784  blr      x8
006AD6788  ldp      x20, x19, [sp, #0x10]
006AD678C  mov      w0, #1
006AD6790  ldp      x30, x21, [sp], #0x20
006AD6794  ret      

