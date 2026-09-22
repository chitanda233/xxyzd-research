; MissionData$$Deserialize
; RVA 0x64C7054; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C7054  sub      sp, sp, #0x70
0064C7058  stp      x29, x30, [sp, #0x10]
0064C705C  stp      x28, x27, [sp, #0x20]
0064C7060  stp      x26, x25, [sp, #0x30]
0064C7064  stp      x24, x23, [sp, #0x40]
0064C7068  stp      x22, x21, [sp, #0x50]
0064C706C  stp      x20, x19, [sp, #0x60]
0064C7070  adrp     x19, #0x9597000
0064C7074  adrp     x22, #0x8ef9000
0064C7078  ldrb     w8, [x19, #0xfa3]
0064C707C  ldr      x22, [x22, #0xe28] ; GLOBAL Method$MissionData.Deserialize()
0064C7080  mov      x21, x1
0064C7084  mov      x20, x0
0064C7088  tbnz     w8, #0, #0x64c7100
0064C708C  adrp     x0, #0x8ec5000
0064C7090  ldr      x0, [x0, #0x880] ; GLOBAL System.IO.BinaryReader_TypeInfo
0064C7094  bl       #0x382bd14 ; 
0064C7098  adrp     x0, #0x8ef9000
0064C709C  ldr      x0, [x0, #0xe30] ; GLOBAL DecorationItem[]_TypeInfo
0064C70A0  bl       #0x382bd14 ; 
0064C70A4  adrp     x0, #0x8ef9000
0064C70A8  ldr      x0, [x0, #0xe38] ; GLOBAL DoorItem[]_TypeInfo
0064C70AC  bl       #0x382bd14 ; 
0064C70B0  adrp     x0, #0x8ebf000
0064C70B4  ldr      x0, [x0, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0064C70B8  bl       #0x382bd14 ; 
0064C70BC  adrp     x0, #0x8ec1000
0064C70C0  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo
0064C70C4  bl       #0x382bd14 ; 
0064C70C8  adrp     x0, #0x8ef9000
0064C70CC  ldr      x0, [x0, #0xe40] ; GLOBAL MapItem[]_TypeInfo
0064C70D0  bl       #0x382bd14 ; 
0064C70D4  adrp     x0, #0x8ef9000
0064C70D8  ldr      x0, [x0, #0xe48] ; GLOBAL MapMonsterData[]_TypeInfo
0064C70DC  bl       #0x382bd14 ; 
0064C70E0  adrp     x0, #0x8ef9000
0064C70E4  ldr      x0, [x0, #0xe50] ; GLOBAL MapMonsterItem[]_TypeInfo
0064C70E8  bl       #0x382bd14 ; 
0064C70EC  adrp     x0, #0x8ef9000
0064C70F0  ldr      x0, [x0, #0xe28] ; GLOBAL Method$MissionData.Deserialize()
0064C70F4  bl       #0x382bd14 ; 
0064C70F8  mov      w8, #1
0064C70FC  strb     w8, [x19, #0xfa3]
0064C7100  ldr      x2, [x22]
0064C7104  ldrb     w8, [x2, #0x53]
0064C7108  tbnz     w8, #5, #0x64c71b4
0064C710C  adrp     x8, #0x8ec5000
0064C7110  ldr      x8, [x8, #0x880] ; GLOBAL System.IO.BinaryReader_TypeInfo
0064C7114  ldr      x0, [x8]
0064C7118  bl       #0x382bfa0 ; 
0064C711C  mov      x1, x21
0064C7120  mov      x2, xzr
0064C7124  mov      x19, x0
0064C7128  bl       #0x7b416e8 ; System.IO.BinaryReader$$.ctor
0064C712C  cbz      x19, #0x64c7798
0064C7130  ldr      x8, [x19]
0064C7134  ldr      x1, [x8, #0x240]
0064C7138  ldr      x9, [x8, #0x238]
0064C713C  mov      x0, x19
0064C7140  blr      x9
0064C7144  str      w0, [x20, #0x10]
0064C7148  ldr      x8, [x19]
0064C714C  ldr      x1, [x8, #0x240]
0064C7150  ldr      x9, [x8, #0x238]
0064C7154  mov      x0, x19
0064C7158  blr      x9
0064C715C  str      w0, [x20, #0x14]
0064C7160  ldr      x8, [x19]
0064C7164  ldp      x9, x1, [x8, #0x1d8]
0064C7168  mov      x0, x19
0064C716C  blr      x9
0064C7170  adrp     x22, #0x9598000
0064C7174  ldrb     w8, [x22, #0x35d]
0064C7178  mov      w21, w0
0064C717C  cbnz     w8, #0x64c7194
0064C7180  adrp     x0, #0x8ef9000
0064C7184  ldr      x0, [x0, #0xd98] ; GLOBAL Method$MissionData.set_HasSky()
0064C7188  bl       #0x382bd14 ; 
0064C718C  mov      w8, #1
0064C7190  strb     w8, [x22, #0x35d]
0064C7194  adrp     x8, #0x8ef9000
0064C7198  ldr      x8, [x8, #0xd98] ; GLOBAL Method$MissionData.set_HasSky()
0064C719C  ldr      x2, [x8]
0064C71A0  ldrb     w8, [x2, #0x53]
0064C71A4  tbnz     w8, #5, #0x64c71e0
0064C71A8  and      w8, w21, #1
0064C71AC  strb     w8, [x20, #0x18]
0064C71B0  b        #0x64c71f0 ; 
0064C71B4  ldr      x3, [x2, #0x60]
0064C71B8  mov      x0, x20
0064C71BC  mov      x1, x21
0064C71C0  ldp      x20, x19, [sp, #0x60]
0064C71C4  ldp      x22, x21, [sp, #0x50]
0064C71C8  ldp      x24, x23, [sp, #0x40]
0064C71CC  ldp      x26, x25, [sp, #0x30]
0064C71D0  ldp      x28, x27, [sp, #0x20]
0064C71D4  ldp      x29, x30, [sp, #0x10]
0064C71D8  add      sp, sp, #0x70
0064C71DC  br       x3
0064C71E0  ldr      x8, [x2, #0x60]
0064C71E4  and      w1, w21, #1
0064C71E8  mov      x0, x20
0064C71EC  blr      x8
0064C71F0  add      x2, x20, #0xd8
0064C71F4  mov      x0, x20
0064C71F8  mov      x1, x19
0064C71FC  bl       #0x64c7904 ; MissionData$$ReadPos
0064C7200  add      x2, x20, #0x20
0064C7204  mov      x0, x20
0064C7208  mov      x1, x19
0064C720C  bl       #0x64c79d0 ; MissionData$$ReadRect
0064C7210  add      x2, x20, #0xf0
0064C7214  mov      x0, x20
0064C7218  mov      x1, x19
0064C721C  bl       #0x64c7904 ; MissionData$$ReadPos
0064C7220  add      x2, x20, #0x60
0064C7224  mov      x0, x20
0064C7228  mov      x1, x19
0064C722C  bl       #0x64c79d0 ; MissionData$$ReadRect
0064C7230  add      x2, x20, #0xa0
0064C7234  mov      x0, x20
0064C7238  mov      x1, x19
0064C723C  bl       #0x64c7b14 ; MissionData$$ReadRects
0064C7240  add      x2, x20, #0xa8
0064C7244  mov      x0, x20
0064C7248  mov      x1, x19
0064C724C  bl       #0x64c7b14 ; MissionData$$ReadRects
0064C7250  add      x2, x20, #0xb0
0064C7254  mov      x0, x20
0064C7258  mov      x1, x19
0064C725C  bl       #0x64c7b14 ; MissionData$$ReadRects
0064C7260  add      x2, x20, #0xb8
0064C7264  mov      x0, x20
0064C7268  mov      x1, x19
0064C726C  bl       #0x64c7b14 ; MissionData$$ReadRects
0064C7270  ldr      x8, [x19]
0064C7274  ldp      w10, w9, [x20, #0x10]
0064C7278  ldr      x11, [x8, #0x308]
0064C727C  ldr      x2, [x8, #0x310]
0064C7280  mul      w1, w10, w9
0064C7284  mov      x0, x19
0064C7288  blr      x11
0064C728C  mov      x1, x0
0064C7290  add      x0, x20, #0x108
0064C7294  str      x1, [x20, #0x108]
0064C7298  bl       #0x382bcb8 ; 
0064C729C  ldr      x8, [x19]
0064C72A0  ldr      x1, [x8, #0x240]
0064C72A4  ldr      x9, [x8, #0x238]
0064C72A8  mov      x0, x19
0064C72AC  blr      x9
0064C72B0  adrp     x8, #0x8ef9000
0064C72B4  ldr      x8, [x8, #0xe38] ; GLOBAL DoorItem[]_TypeInfo
0064C72B8  mov      w22, w0
0064C72BC  ldr      x0, [x8]
0064C72C0  mov      w1, w22
0064C72C4  bl       #0x382bdfc ; 
0064C72C8  mov      x1, x0
0064C72CC  mov      x21, x20
0064C72D0  str      x1, [x21, #0xc8]!
0064C72D4  mov      x0, x21
0064C72D8  bl       #0x382bcb8 ; 
0064C72DC  cmp      w22, #1
0064C72E0  b.lt     #0x64c7340
0064C72E4  mov      x23, xzr
0064C72E8  mov      w22, w22
0064C72EC  mov      w24, #0x38
0064C72F0  ldr      x25, [x21]
0064C72F4  cbz      x25, #0x64c7778
0064C72F8  ldr      w8, [x25, #0x18]
0064C72FC  cmp      x23, x8
0064C7300  b.hs     #0x64c777c
0064C7304  add      x8, x25, x24
0064C7308  sub      x2, x8, #0x18
0064C730C  mov      x0, x20
0064C7310  mov      x1, x19
0064C7314  bl       #0x64c7904 ; MissionData$$ReadPos
0064C7318  ldr      x8, [x19]
0064C731C  ldr      x1, [x8, #0x240]
0064C7320  ldr      x9, [x8, #0x238]
0064C7324  mov      x0, x19
0064C7328  blr      x9
0064C732C  add      x23, x23, #1
0064C7330  str      w0, [x25, x24]
0064C7334  cmp      x22, x23
0064C7338  add      x24, x24, #0x20
0064C733C  b.ne     #0x64c72f0
0064C7340  ldr      x8, [x19]
0064C7344  ldr      x1, [x8, #0x240]
0064C7348  ldr      x9, [x8, #0x238]
0064C734C  mov      x0, x19
0064C7350  blr      x9
0064C7354  adrp     x8, #0x8ef9000
0064C7358  ldr      x8, [x8, #0xe48] ; GLOBAL MapMonsterData[]_TypeInfo
0064C735C  mov      w22, w0
0064C7360  ldr      x0, [x8]
0064C7364  mov      w1, w22
0064C7368  bl       #0x382bdfc ; 
0064C736C  mov      x1, x0
0064C7370  add      x0, x20, #0x140
0064C7374  str      x1, [x20, #0x140]
0064C7378  str      x0, [sp, #8]
0064C737C  bl       #0x382bcb8 ; 
0064C7380  cmp      w22, #1
0064C7384  b.lt     #0x64c7548
0064C7388  mov      x25, xzr
0064C738C  mov      w8, w22
0064C7390  mov      w28, #0x38
0064C7394  str      x8, [sp]
0064C7398  ldr      x8, [sp, #8]
0064C739C  ldr      x22, [x8]
0064C73A0  cbz      x22, #0x64c7794
0064C73A4  ldr      w8, [x22, #0x18]
0064C73A8  cmp      x25, x8
0064C73AC  b.hs     #0x64c7790
0064C73B0  ldr      x8, [x19]
0064C73B4  ldr      x1, [x8, #0x2b0]
0064C73B8  ldr      x9, [x8, #0x2a8]
0064C73BC  mov      x0, x19
0064C73C0  blr      x9
0064C73C4  mov      x1, x0
0064C73C8  add      x8, x22, x25, lsl #4
0064C73CC  add      x0, x8, #0x20
0064C73D0  str      x1, [x0]
0064C73D4  bl       #0x382bcb8 ; 
0064C73D8  ldr      x8, [x19]
0064C73DC  ldr      x1, [x8, #0x240]
0064C73E0  ldr      x9, [x8, #0x238]
0064C73E4  mov      x0, x19
0064C73E8  blr      x9
0064C73EC  adrp     x8, #0x8ef9000
0064C73F0  ldr      x8, [x8, #0xe50] ; GLOBAL MapMonsterItem[]_TypeInfo
0064C73F4  mov      w23, w0
0064C73F8  ldr      x0, [x8]
0064C73FC  mov      w1, w23
0064C7400  bl       #0x382bdfc ; 
0064C7404  mov      x1, x0
0064C7408  add      x22, x22, x25, lsl #4
0064C740C  str      x1, [x22, #0x28]!
0064C7410  mov      x0, x22
0064C7414  bl       #0x382bcb8 ; 
0064C7418  cmp      w23, #1
0064C741C  b.lt     #0x64c7538
0064C7420  mov      x27, xzr
0064C7424  mov      w26, w23
0064C7428  ldr      x23, [x22]
0064C742C  cbz      x23, #0x64c7774
0064C7430  ldr      w8, [x23, #0x18]
0064C7434  cmp      x27, x8
0064C7438  b.hs     #0x64c7770
0064C743C  ldr      x8, [x19]
0064C7440  ldr      x1, [x8, #0x240]
0064C7444  ldr      x9, [x8, #0x238]
0064C7448  mov      x0, x19
0064C744C  blr      x9
0064C7450  madd     x8, x27, x28, x23
0064C7454  str      w0, [x8, #0x20]
0064C7458  add      x2, x8, #0x28
0064C745C  mov      x0, x20
0064C7460  mov      x1, x19
0064C7464  bl       #0x64c7904 ; MissionData$$ReadPos
0064C7468  ldr      x8, [x19]
0064C746C  ldr      x1, [x8, #0x260]
0064C7470  ldr      x9, [x8, #0x258]
0064C7474  mov      x0, x19
0064C7478  blr      x9
0064C747C  madd     x8, x27, x28, x23
0064C7480  str      x0, [x8, #0x40]
0064C7484  ldr      x8, [x19]
0064C7488  ldr      x1, [x8, #0x260]
0064C748C  ldr      x9, [x8, #0x258]
0064C7490  mov      x0, x19
0064C7494  blr      x9
0064C7498  madd     x8, x27, x28, x23
0064C749C  str      x0, [x8, #0x48]
0064C74A0  ldr      x8, [x19]
0064C74A4  ldr      x1, [x8, #0x240]
0064C74A8  ldr      x9, [x8, #0x238]
0064C74AC  mov      x0, x19
0064C74B0  blr      x9
0064C74B4  mov      w24, w0
0064C74B8  cmp      w0, #1
0064C74BC  b.lt     #0x64c752c
0064C74C0  adrp     x8, #0x8ec1000
0064C74C4  ldr      x8, [x8, #0x240] ; GLOBAL int[]_TypeInfo
0064C74C8  ldr      x0, [x8]
0064C74CC  mov      w1, w24
0064C74D0  bl       #0x382bdfc ; 
0064C74D4  mov      x1, x0
0064C74D8  madd     x23, x27, x28, x23
0064C74DC  str      x1, [x23, #0x50]!
0064C74E0  mov      x0, x23
0064C74E4  bl       #0x382bcb8 ; 
0064C74E8  mov      x21, xzr
0064C74EC  mov      w24, w24
0064C74F0  ldr      x8, [x19]
0064C74F4  ldr      x29, [x23]
0064C74F8  ldr      x1, [x8, #0x240]
0064C74FC  ldr      x9, [x8, #0x238]
0064C7500  mov      x0, x19
0064C7504  blr      x9
0064C7508  cbz      x29, #0x64c7768
0064C750C  ldr      w8, [x29, #0x18]
0064C7510  cmp      x21, x8
0064C7514  b.hs     #0x64c776c
0064C7518  add      x8, x29, x21, lsl #2
0064C751C  add      x21, x21, #1
0064C7520  cmp      x24, x21
0064C7524  str      w0, [x8, #0x20]
0064C7528  b.ne     #0x64c74f0
0064C752C  add      x27, x27, #1
0064C7530  cmp      x27, x26
0064C7534  b.ne     #0x64c7428
0064C7538  ldr      x8, [sp]
0064C753C  add      x25, x25, #1
0064C7540  cmp      x25, x8
0064C7544  b.ne     #0x64c7398
0064C7548  ldr      x8, [x19]
0064C754C  ldr      x1, [x8, #0x240]
0064C7550  ldr      x9, [x8, #0x238]
0064C7554  mov      x0, x19
0064C7558  blr      x9
0064C755C  adrp     x8, #0x8ef9000
0064C7560  ldr      x8, [x8, #0xe40] ; GLOBAL MapItem[]_TypeInfo
0064C7564  mov      w22, w0
0064C7568  ldr      x0, [x8]
0064C756C  mov      w1, w22
0064C7570  bl       #0x382bdfc ; 
0064C7574  mov      x1, x0
0064C7578  mov      x21, x20
0064C757C  str      x1, [x21, #0xc0]!
0064C7580  mov      x0, x21
0064C7584  bl       #0x382bcb8 ; 
0064C7588  cmp      w22, #1
0064C758C  b.lt     #0x64c7608
0064C7590  mov      x23, xzr
0064C7594  mov      w22, w22
0064C7598  mov      w24, #0x40
0064C759C  ldr      x25, [x21]
0064C75A0  cbz      x25, #0x64c7780
0064C75A4  ldr      w8, [x25, #0x18]
0064C75A8  cmp      x23, x8
0064C75AC  b.hs     #0x64c7784
0064C75B0  add      x8, x25, x24
0064C75B4  sub      x2, x8, #0x20
0064C75B8  mov      x0, x20
0064C75BC  mov      x1, x19
0064C75C0  bl       #0x64c7904 ; MissionData$$ReadPos
0064C75C4  ldr      x8, [x19]
0064C75C8  ldr      x1, [x8, #0x240]
0064C75CC  ldr      x9, [x8, #0x238]
0064C75D0  mov      x0, x19
0064C75D4  blr      x9
0064C75D8  add      x8, x25, x24
0064C75DC  stur     w0, [x8, #-8]
0064C75E0  ldr      x8, [x19]
0064C75E4  ldr      x1, [x8, #0x260]
0064C75E8  ldr      x9, [x8, #0x258]
0064C75EC  mov      x0, x19
0064C75F0  blr      x9
0064C75F4  add      x23, x23, #1
0064C75F8  str      x0, [x25, x24]
0064C75FC  cmp      x22, x23
0064C7600  add      x24, x24, #0x28
0064C7604  b.ne     #0x64c759c
0064C7608  ldr      x8, [x19]
0064C760C  ldr      x1, [x8, #0x240]
0064C7610  ldr      x9, [x8, #0x238]
0064C7614  mov      x0, x19
0064C7618  blr      x9
0064C761C  adrp     x8, #0x8ef9000
0064C7620  ldr      x8, [x8, #0xe30] ; GLOBAL DecorationItem[]_TypeInfo
0064C7624  mov      w22, w0
0064C7628  ldr      x0, [x8]
0064C762C  mov      w1, w22
0064C7630  bl       #0x382bdfc ; 
0064C7634  mov      x1, x0
0064C7638  mov      x21, x20
0064C763C  str      x1, [x21, #0xd0]!
0064C7640  mov      x0, x21
0064C7644  bl       #0x382bcb8 ; 
0064C7648  cmp      w22, #1
0064C764C  b.lt     #0x64c76e0
0064C7650  mov      x23, xzr
0064C7654  mov      w22, w22
0064C7658  mov      w24, #0x44
0064C765C  ldr      x25, [x21]
0064C7660  cbz      x25, #0x64c7788
0064C7664  ldr      w8, [x25, #0x18]
0064C7668  cmp      x23, x8
0064C766C  b.hs     #0x64c778c
0064C7670  ldr      x8, [x19]
0064C7674  ldr      x1, [x8, #0x240]
0064C7678  ldr      x9, [x8, #0x238]
0064C767C  mov      x0, x19
0064C7680  blr      x9
0064C7684  add      x8, x25, x24
0064C7688  stur     w0, [x8, #-0x24]
0064C768C  sub      x2, x8, #0x1c
0064C7690  mov      x0, x20
0064C7694  mov      x1, x19
0064C7698  bl       #0x64c7904 ; MissionData$$ReadPos
0064C769C  ldr      x8, [x19]
0064C76A0  ldr      x1, [x8, #0x240]
0064C76A4  ldr      x9, [x8, #0x238]
0064C76A8  mov      x0, x19
0064C76AC  blr      x9
0064C76B0  add      x8, x25, x24
0064C76B4  stur     w0, [x8, #-4]
0064C76B8  ldr      x8, [x19]
0064C76BC  ldr      x1, [x8, #0x240]
0064C76C0  ldr      x9, [x8, #0x238]
0064C76C4  mov      x0, x19
0064C76C8  blr      x9
0064C76CC  add      x23, x23, #1
0064C76D0  str      w0, [x25, x24]
0064C76D4  cmp      x22, x23
0064C76D8  add      x24, x24, #0x30
0064C76DC  b.ne     #0x64c765c
0064C76E0  mov      x21, xzr
0064C76E4  adrp     x10, #0x8ebf000
0064C76E8  ldr      x8, [x19]
0064C76EC  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0064C76F0  ldrh     w9, [x8, #0x12e]
0064C76F4  ldr      x1, [x10]
0064C76F8  cbz      x9, #0x64c771c
0064C76FC  ldr      x10, [x8, #0xb0]
0064C7700  add      x10, x10, #8
0064C7704  ldur     x11, [x10, #-8]
0064C7708  cmp      x11, x1
0064C770C  b.eq     #0x64c772c
0064C7710  subs     x9, x9, #1
0064C7714  add      x10, x10, #0x10
0064C7718  b.ne     #0x64c7704
0064C771C  mov      x0, x19
0064C7720  mov      w2, wzr
0064C7724  bl       #0x3a7e710 ; 
0064C7728  b        #0x64c7738 ; 
0064C772C  ldrsw    x9, [x10]
0064C7730  add      x8, x8, x9, lsl #4
0064C7734  add      x0, x8, #0x138
0064C7738  ldp      x8, x1, [x0]
0064C773C  mov      x0, x19
0064C7740  blr      x8
0064C7744  cbnz     x21, #0x64c779c
0064C7748  ldp      x20, x19, [sp, #0x60]
0064C774C  ldp      x22, x21, [sp, #0x50]
0064C7750  ldp      x24, x23, [sp, #0x40]
0064C7754  ldp      x26, x25, [sp, #0x30]
0064C7758  ldp      x28, x27, [sp, #0x20]
0064C775C  ldp      x29, x30, [sp, #0x10]
0064C7760  add      sp, sp, #0x70
0064C7764  ret      
0064C7768  bl       #0x382bfb8 ; 
0064C776C  bl       #0x382bfc0 ; 
0064C7770  bl       #0x382bfc0 ; 
0064C7774  bl       #0x382bfb8 ; 
0064C7778  bl       #0x382bfb8 ; 
0064C777C  bl       #0x382bfc0 ; 
0064C7780  bl       #0x382bfb8 ; 
0064C7784  bl       #0x382bfc0 ; 
0064C7788  bl       #0x382bfb8 ; 
0064C778C  bl       #0x382bfc0 ; 
0064C7790  bl       #0x382bfc0 ; 
0064C7794  bl       #0x382bfb8 ; 
0064C7798  bl       #0x382bfb8 ; 
0064C779C  mov      x0, x21
0064C77A0  bl       #0x382bfb0 ; 
0064C77A4  b        #0x64c7858 ; 
0064C77A8  b        #0x64c7858 ; 
0064C77AC  b        #0x64c7858 ; 
0064C77B0  b        #0x64c7858 ; 
0064C77B4  b        #0x64c7858 ; 
0064C77B8  b        #0x64c7858 ; 
0064C77BC  b        #0x64c7858 ; 
0064C77C0  b        #0x64c7858 ; 
0064C77C4  b        #0x64c7858 ; 
0064C77C8  b        #0x64c7858 ; 
0064C77CC  b        #0x64c7858 ; 
0064C77D0  b        #0x64c7858 ; 
0064C77D4  b        #0x64c7858 ; 
0064C77D8  b        #0x64c7858 ; 
0064C77DC  b        #0x64c7858 ; 
0064C77E0  b        #0x64c7858 ; 
0064C77E4  b        #0x64c7858 ; 
0064C77E8  b        #0x64c7858 ; 
0064C77EC  b        #0x64c7858 ; 
0064C77F0  b        #0x64c7858 ; 
0064C77F4  b        #0x64c7858 ; 
0064C77F8  b        #0x64c7858 ; 
0064C77FC  b        #0x64c7858 ; 
0064C7800  b        #0x64c7858 ; 
0064C7804  b        #0x64c7858 ; 
0064C7808  b        #0x64c7858 ; 
0064C780C  b        #0x64c7858 ; 
0064C7810  b        #0x64c7858 ; 
0064C7814  b        #0x64c7858 ; 
0064C7818  b        #0x64c7858 ; 
0064C781C  b        #0x64c7858 ; 
0064C7820  b        #0x64c7858 ; 
0064C7824  b        #0x64c7858 ; 
0064C7828  b        #0x64c7858 ; 
0064C782C  b        #0x64c7858 ; 
0064C7830  b        #0x64c7858 ; 
0064C7834  b        #0x64c7858 ; 
0064C7838  b        #0x64c7858 ; 
0064C783C  b        #0x64c7858 ; 
0064C7840  b        #0x64c7858 ; 
0064C7844  b        #0x64c7858 ; 
0064C7848  b        #0x64c7858 ; 
0064C784C  b        #0x64c7858 ; 
0064C7850  b        #0x64c7858 ; 
0064C7854  b        #0x64c7858 ; 
0064C7858  mov      x20, x0
0064C785C  cmp      w1, #1
0064C7860  b.ne     #0x64c787c
0064C7864  mov      x0, x20
0064C7868  bl       #0x89eda50 ; 
0064C786C  ldr      x21, [x0]
0064C7870  bl       #0x89eda60 ; 
0064C7874  cbnz     x19, #0x64c76e4
0064C7878  b        #0x64c7744 ; 
0064C787C  mov      x21, xzr
0064C7880  b        #0x64c7888 ; 
0064C7884  mov      x20, x0
0064C7888  cbz      x19, #0x64c78ec
0064C788C  adrp     x10, #0x8ebf000
0064C7890  ldr      x8, [x19]
0064C7894  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo
0064C7898  ldrh     w9, [x8, #0x12e]
0064C789C  ldr      x1, [x10]
0064C78A0  cbz      x9, #0x64c78c4
0064C78A4  ldr      x10, [x8, #0xb0]
0064C78A8  add      x10, x10, #8
0064C78AC  ldur     x11, [x10, #-8]
0064C78B0  cmp      x11, x1
0064C78B4  b.eq     #0x64c78d4
0064C78B8  subs     x9, x9, #1
0064C78BC  add      x10, x10, #0x10
0064C78C0  b.ne     #0x64c78ac
0064C78C4  mov      x0, x19
0064C78C8  mov      w2, wzr
0064C78CC  bl       #0x3a7e710 ; 
0064C78D0  b        #0x64c78e0 ; 
0064C78D4  ldrsw    x9, [x10]
0064C78D8  add      x8, x8, x9, lsl #4
0064C78DC  add      x0, x8, #0x138
0064C78E0  ldp      x8, x1, [x0]
0064C78E4  mov      x0, x19
0064C78E8  blr      x8
0064C78EC  cbnz     x21, #0x64c78f8
0064C78F0  mov      x0, x20
0064C78F4  bl       #0x3b56bfc ; 
0064C78F8  mov      x0, x21
0064C78FC  bl       #0x382bfb0 ; 
0064C7900  bl       #0x3442448 ; 

