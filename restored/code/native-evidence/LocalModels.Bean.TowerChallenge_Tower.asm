; LocalModels.Bean.TowerChallenge_Tower$$readImpl
; RVA 0x6B17548; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B17548  stp      x30, x21, [sp, #-0x20]!
006B1754C  stp      x20, x19, [sp, #0x10]
006B17550  adrp     x20, #0x959f000
006B17554  adrp     x21, #0x8f3f000
006B17558  ldrb     w8, [x20, #0x5f0]
006B1755C  ldr      x21, [x21, #0x1a8]
006B17560  mov      x19, x0
006B17564  tbnz     w8, #0, #0x6b1757c
006B17568  adrp     x0, #0x8f3f000
006B1756C  ldr      x0, [x0, #0x1a8]
006B17570  bl       #0x382bd14 ; 
006B17574  mov      w8, #1
006B17578  strb     w8, [x20, #0x5f0]
006B1757C  ldr      x1, [x21]
006B17580  ldrb     w8, [x1, #0x53]
006B17584  tbnz     w8, #5, #0x6b175d4
006B17588  mov      x0, x19
006B1758C  mov      x1, xzr
006B17590  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B17594  adrp     x21, #0x959f000
006B17598  ldrb     w8, [x21, #0x9ef]
006B1759C  mov      w20, w0
006B175A0  cbnz     w8, #0x6b175b8
006B175A4  adrp     x0, #0x8f3f000
006B175A8  ldr      x0, [x0, #0x170]
006B175AC  bl       #0x382bd14 ; 
006B175B0  mov      w8, #1
006B175B4  strb     w8, [x21, #0x9ef]
006B175B8  adrp     x8, #0x8f3f000
006B175BC  ldr      x8, [x8, #0x170]
006B175C0  ldr      x2, [x8]
006B175C4  ldrb     w8, [x2, #0x53]
006B175C8  tbnz     w8, #5, #0x6b175e8
006B175CC  str      w20, [x19, #0x20]
006B175D0  b        #0x6b175f8 ; 
006B175D4  ldr      x2, [x1, #0x60]
006B175D8  mov      x0, x19
006B175DC  ldp      x20, x19, [sp, #0x10]
006B175E0  ldp      x30, x21, [sp], #0x20
006B175E4  br       x2
006B175E8  ldr      x8, [x2, #0x60]
006B175EC  mov      x0, x19
006B175F0  mov      w1, w20
006B175F4  blr      x8
006B175F8  mov      x0, x19
006B175FC  mov      x1, xzr
006B17600  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B17604  adrp     x21, #0x959f000
006B17608  ldrb     w8, [x21, #0x9f0]
006B1760C  mov      w20, w0
006B17610  cbnz     w8, #0x6b17628
006B17614  adrp     x0, #0x8f3f000
006B17618  ldr      x0, [x0, #0x180]
006B1761C  bl       #0x382bd14 ; 
006B17620  mov      w8, #1
006B17624  strb     w8, [x21, #0x9f0]
006B17628  adrp     x8, #0x8f3f000
006B1762C  ldr      x8, [x8, #0x180]
006B17630  ldr      x2, [x8]
006B17634  ldrb     w8, [x2, #0x53]
006B17638  tbnz     w8, #5, #0x6b17644
006B1763C  str      w20, [x19, #0x24]
006B17640  b        #0x6b17654 ; 
006B17644  ldr      x8, [x2, #0x60]
006B17648  mov      x0, x19
006B1764C  mov      w1, w20
006B17650  blr      x8
006B17654  mov      x0, x19
006B17658  mov      x1, xzr
006B1765C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B17660  adrp     x21, #0x959f000
006B17664  ldrb     w8, [x21, #0x9f1]
006B17668  mov      x20, x0
006B1766C  cbnz     w8, #0x6b17684
006B17670  adrp     x0, #0x8f3f000
006B17674  ldr      x0, [x0, #0x190]
006B17678  bl       #0x382bd14 ; 
006B1767C  mov      w8, #1
006B17680  strb     w8, [x21, #0x9f1]
006B17684  adrp     x8, #0x8f3f000
006B17688  ldr      x8, [x8, #0x190]
006B1768C  ldr      x2, [x8]
006B17690  ldrb     w8, [x2, #0x53]
006B17694  tbnz     w8, #5, #0x6b176ac
006B17698  mov      x0, x19
006B1769C  str      x20, [x0, #0x28]!
006B176A0  mov      x1, x20
006B176A4  bl       #0x382bcb8 ; 
006B176A8  b        #0x6b176bc ; 
006B176AC  ldr      x8, [x2, #0x60]
006B176B0  mov      x0, x19
006B176B4  mov      x1, x20
006B176B8  blr      x8
006B176BC  mov      x0, x19
006B176C0  mov      x1, xzr
006B176C4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B176C8  adrp     x21, #0x959f000
006B176CC  ldrb     w8, [x21, #0x9f2]
006B176D0  mov      x20, x0
006B176D4  cbnz     w8, #0x6b176ec
006B176D8  adrp     x0, #0x8f3f000
006B176DC  ldr      x0, [x0, #0x1a0]
006B176E0  bl       #0x382bd14 ; 
006B176E4  mov      w8, #1
006B176E8  strb     w8, [x21, #0x9f2]
006B176EC  adrp     x8, #0x8f3f000
006B176F0  ldr      x8, [x8, #0x1a0]
006B176F4  ldr      x2, [x8]
006B176F8  ldrb     w8, [x2, #0x53]
006B176FC  tbnz     w8, #5, #0x6b17714
006B17700  str      x20, [x19, #0x30]!
006B17704  mov      x0, x19
006B17708  mov      x1, x20
006B1770C  bl       #0x382bcb8 ; 
006B17710  b        #0x6b17724 ; 
006B17714  ldr      x8, [x2, #0x60]
006B17718  mov      x0, x19
006B1771C  mov      x1, x20
006B17720  blr      x8
006B17724  ldp      x20, x19, [sp, #0x10]
006B17728  mov      w0, #1
006B1772C  ldp      x30, x21, [sp], #0x20
006B17730  ret      

