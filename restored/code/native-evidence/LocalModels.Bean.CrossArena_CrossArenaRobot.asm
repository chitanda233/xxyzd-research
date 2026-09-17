; LocalModels.Bean.CrossArena_CrossArenaRobot$$readImpl
; RVA 0x6A55600; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A55600  stp      x30, x21, [sp, #-0x20]!
006A55604  stp      x20, x19, [sp, #0x10]
006A55608  adrp     x20, #0x959d000
006A5560C  adrp     x21, #0x8f36000
006A55610  ldrb     w8, [x20, #0xad6]
006A55614  ldr      x21, [x21, #0x1a8]
006A55618  mov      x19, x0
006A5561C  tbnz     w8, #0, #0x6a55634
006A55620  adrp     x0, #0x8f36000
006A55624  ldr      x0, [x0, #0x1a8]
006A55628  bl       #0x382bd14 ; 
006A5562C  mov      w8, #1
006A55630  strb     w8, [x20, #0xad6]
006A55634  ldr      x1, [x21]
006A55638  ldrb     w8, [x1, #0x53]
006A5563C  tbnz     w8, #5, #0x6a5568c
006A55640  mov      x0, x19
006A55644  mov      x1, xzr
006A55648  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5564C  adrp     x21, #0x959e000
006A55650  ldrb     w8, [x21, #0x31f]
006A55654  mov      w20, w0
006A55658  cbnz     w8, #0x6a55670
006A5565C  adrp     x0, #0x8f36000
006A55660  ldr      x0, [x0, #0x120]
006A55664  bl       #0x382bd14 ; 
006A55668  mov      w8, #1
006A5566C  strb     w8, [x21, #0x31f]
006A55670  adrp     x8, #0x8f36000
006A55674  ldr      x8, [x8, #0x120]
006A55678  ldr      x2, [x8]
006A5567C  ldrb     w8, [x2, #0x53]
006A55680  tbnz     w8, #5, #0x6a556a0
006A55684  str      w20, [x19, #0x20]
006A55688  b        #0x6a556b0 ; 
006A5568C  ldr      x2, [x1, #0x60]
006A55690  mov      x0, x19
006A55694  ldp      x20, x19, [sp, #0x10]
006A55698  ldp      x30, x21, [sp], #0x20
006A5569C  br       x2
006A556A0  ldr      x8, [x2, #0x60]
006A556A4  mov      x0, x19
006A556A8  mov      w1, w20
006A556AC  blr      x8
006A556B0  mov      x0, x19
006A556B4  mov      x1, xzr
006A556B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A556BC  adrp     x21, #0x959e000
006A556C0  ldrb     w8, [x21, #0x320]
006A556C4  mov      w20, w0
006A556C8  cbnz     w8, #0x6a556e0
006A556CC  adrp     x0, #0x8f36000
006A556D0  ldr      x0, [x0, #0x130]
006A556D4  bl       #0x382bd14 ; 
006A556D8  mov      w8, #1
006A556DC  strb     w8, [x21, #0x320]
006A556E0  adrp     x8, #0x8f36000
006A556E4  ldr      x8, [x8, #0x130]
006A556E8  ldr      x2, [x8]
006A556EC  ldrb     w8, [x2, #0x53]
006A556F0  tbnz     w8, #5, #0x6a556fc
006A556F4  str      w20, [x19, #0x24]
006A556F8  b        #0x6a5570c ; 
006A556FC  ldr      x8, [x2, #0x60]
006A55700  mov      x0, x19
006A55704  mov      w1, w20
006A55708  blr      x8
006A5570C  mov      x0, x19
006A55710  mov      x1, xzr
006A55714  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A55718  adrp     x21, #0x959e000
006A5571C  ldrb     w8, [x21, #0x321]
006A55720  mov      x20, x0
006A55724  cbnz     w8, #0x6a5573c
006A55728  adrp     x0, #0x8f36000
006A5572C  ldr      x0, [x0, #0x140]
006A55730  bl       #0x382bd14 ; 
006A55734  mov      w8, #1
006A55738  strb     w8, [x21, #0x321]
006A5573C  adrp     x8, #0x8f36000
006A55740  ldr      x8, [x8, #0x140]
006A55744  ldr      x2, [x8]
006A55748  ldrb     w8, [x2, #0x53]
006A5574C  tbnz     w8, #5, #0x6a55764
006A55750  mov      x0, x19
006A55754  str      x20, [x0, #0x28]!
006A55758  mov      x1, x20
006A5575C  bl       #0x382bcb8 ; 
006A55760  b        #0x6a55774 ; 
006A55764  ldr      x8, [x2, #0x60]
006A55768  mov      x0, x19
006A5576C  mov      x1, x20
006A55770  blr      x8
006A55774  mov      x0, x19
006A55778  mov      x1, xzr
006A5577C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A55780  adrp     x21, #0x959e000
006A55784  ldrb     w8, [x21, #0x322]
006A55788  mov      w20, w0
006A5578C  cbnz     w8, #0x6a557a4
006A55790  adrp     x0, #0x8f36000
006A55794  ldr      x0, [x0, #0x150]
006A55798  bl       #0x382bd14 ; 
006A5579C  mov      w8, #1
006A557A0  strb     w8, [x21, #0x322]
006A557A4  adrp     x8, #0x8f36000
006A557A8  ldr      x8, [x8, #0x150]
006A557AC  ldr      x2, [x8]
006A557B0  ldrb     w8, [x2, #0x53]
006A557B4  tbnz     w8, #5, #0x6a557c0
006A557B8  str      w20, [x19, #0x30]
006A557BC  b        #0x6a557d0 ; 
006A557C0  ldr      x8, [x2, #0x60]
006A557C4  mov      x0, x19
006A557C8  mov      w1, w20
006A557CC  blr      x8
006A557D0  mov      x0, x19
006A557D4  mov      x1, xzr
006A557D8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A557DC  adrp     x21, #0x959e000
006A557E0  ldrb     w8, [x21, #0x323]
006A557E4  mov      x20, x0
006A557E8  cbnz     w8, #0x6a55800
006A557EC  adrp     x0, #0x8f36000
006A557F0  ldr      x0, [x0, #0x160]
006A557F4  bl       #0x382bd14 ; 
006A557F8  mov      w8, #1
006A557FC  strb     w8, [x21, #0x323]
006A55800  adrp     x8, #0x8f36000
006A55804  ldr      x8, [x8, #0x160]
006A55808  ldr      x2, [x8]
006A5580C  ldrb     w8, [x2, #0x53]
006A55810  tbnz     w8, #5, #0x6a55828
006A55814  mov      x0, x19
006A55818  str      x20, [x0, #0x38]!
006A5581C  mov      x1, x20
006A55820  bl       #0x382bcb8 ; 
006A55824  b        #0x6a55838 ; 
006A55828  ldr      x8, [x2, #0x60]
006A5582C  mov      x0, x19
006A55830  mov      x1, x20
006A55834  blr      x8
006A55838  mov      x0, x19
006A5583C  mov      x1, xzr
006A55840  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A55844  adrp     x21, #0x959e000
006A55848  ldrb     w8, [x21, #0x324]
006A5584C  mov      x20, x0
006A55850  cbnz     w8, #0x6a55868
006A55854  adrp     x0, #0x8f36000
006A55858  ldr      x0, [x0, #0x170]
006A5585C  bl       #0x382bd14 ; 
006A55860  mov      w8, #1
006A55864  strb     w8, [x21, #0x324]
006A55868  adrp     x8, #0x8f36000
006A5586C  ldr      x8, [x8, #0x170]
006A55870  ldr      x2, [x8]
006A55874  ldrb     w8, [x2, #0x53]
006A55878  tbnz     w8, #5, #0x6a55890
006A5587C  mov      x0, x19
006A55880  str      x20, [x0, #0x40]!
006A55884  mov      x1, x20
006A55888  bl       #0x382bcb8 ; 
006A5588C  b        #0x6a558a0 ; 
006A55890  ldr      x8, [x2, #0x60]
006A55894  mov      x0, x19
006A55898  mov      x1, x20
006A5589C  blr      x8
006A558A0  mov      x0, x19
006A558A4  mov      x1, xzr
006A558A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A558AC  adrp     x21, #0x959e000
006A558B0  ldrb     w8, [x21, #0x325]
006A558B4  mov      w20, w0
006A558B8  cbnz     w8, #0x6a558d0
006A558BC  adrp     x0, #0x8f36000
006A558C0  ldr      x0, [x0, #0x180]
006A558C4  bl       #0x382bd14 ; 
006A558C8  mov      w8, #1
006A558CC  strb     w8, [x21, #0x325]
006A558D0  adrp     x8, #0x8f36000
006A558D4  ldr      x8, [x8, #0x180]
006A558D8  ldr      x2, [x8]
006A558DC  ldrb     w8, [x2, #0x53]
006A558E0  tbnz     w8, #5, #0x6a558ec
006A558E4  str      w20, [x19, #0x48]
006A558E8  b        #0x6a558fc ; 
006A558EC  ldr      x8, [x2, #0x60]
006A558F0  mov      x0, x19
006A558F4  mov      w1, w20
006A558F8  blr      x8
006A558FC  mov      x0, x19
006A55900  mov      x1, xzr
006A55904  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A55908  adrp     x21, #0x959e000
006A5590C  ldrb     w8, [x21, #0x326]
006A55910  mov      x20, x0
006A55914  cbnz     w8, #0x6a5592c
006A55918  adrp     x0, #0x8f36000
006A5591C  ldr      x0, [x0, #0x190]
006A55920  bl       #0x382bd14 ; 
006A55924  mov      w8, #1
006A55928  strb     w8, [x21, #0x326]
006A5592C  adrp     x8, #0x8f36000
006A55930  ldr      x8, [x8, #0x190]
006A55934  ldr      x2, [x8]
006A55938  ldrb     w8, [x2, #0x53]
006A5593C  tbnz     w8, #5, #0x6a55954
006A55940  mov      x0, x19
006A55944  str      x20, [x0, #0x50]!
006A55948  mov      x1, x20
006A5594C  bl       #0x382bcb8 ; 
006A55950  b        #0x6a55964 ; 
006A55954  ldr      x8, [x2, #0x60]
006A55958  mov      x0, x19
006A5595C  mov      x1, x20
006A55960  blr      x8
006A55964  mov      x0, x19
006A55968  mov      x1, xzr
006A5596C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A55970  adrp     x21, #0x959e000
006A55974  ldrb     w8, [x21, #0x327]
006A55978  mov      w20, w0
006A5597C  cbnz     w8, #0x6a55994
006A55980  adrp     x0, #0x8f36000
006A55984  ldr      x0, [x0, #0x1a0]
006A55988  bl       #0x382bd14 ; 
006A5598C  mov      w8, #1
006A55990  strb     w8, [x21, #0x327]
006A55994  adrp     x8, #0x8f36000
006A55998  ldr      x8, [x8, #0x1a0]
006A5599C  ldr      x2, [x8]
006A559A0  ldrb     w8, [x2, #0x53]
006A559A4  tbnz     w8, #5, #0x6a559b0
006A559A8  str      w20, [x19, #0x58]
006A559AC  b        #0x6a559c0 ; 
006A559B0  ldr      x8, [x2, #0x60]
006A559B4  mov      x0, x19
006A559B8  mov      w1, w20
006A559BC  blr      x8
006A559C0  ldp      x20, x19, [sp, #0x10]
006A559C4  mov      w0, #1
006A559C8  ldp      x30, x21, [sp], #0x20
006A559CC  ret      

