; LocalModels.Bean.Weapon_Weapon$$readImpl
; RVA 0x6B21190; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B21190  stp      x30, x21, [sp, #-0x20]!
006B21194  stp      x20, x19, [sp, #0x10]
006B21198  adrp     x20, #0x959f000
006B2119C  adrp     x21, #0x8f3f000
006B211A0  ldrb     w8, [x20, #0x700]
006B211A4  ldr      x21, [x21, #0x890]
006B211A8  mov      x19, x0
006B211AC  tbnz     w8, #0, #0x6b211c4
006B211B0  adrp     x0, #0x8f3f000
006B211B4  ldr      x0, [x0, #0x890]
006B211B8  bl       #0x382bd14 ; 
006B211BC  mov      w8, #1
006B211C0  strb     w8, [x20, #0x700]
006B211C4  ldr      x1, [x21]
006B211C8  ldrb     w8, [x1, #0x53]
006B211CC  tbnz     w8, #5, #0x6b2121c
006B211D0  mov      x0, x19
006B211D4  mov      x1, xzr
006B211D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B211DC  adrp     x21, #0x959f000
006B211E0  ldrb     w8, [x21, #0xa4e]
006B211E4  mov      w20, w0
006B211E8  cbnz     w8, #0x6b21200
006B211EC  adrp     x0, #0x8f3f000
006B211F0  ldr      x0, [x0, #0x790]
006B211F4  bl       #0x382bd14 ; 
006B211F8  mov      w8, #1
006B211FC  strb     w8, [x21, #0xa4e]
006B21200  adrp     x8, #0x8f3f000
006B21204  ldr      x8, [x8, #0x790]
006B21208  ldr      x2, [x8]
006B2120C  ldrb     w8, [x2, #0x53]
006B21210  tbnz     w8, #5, #0x6b21230
006B21214  str      w20, [x19, #0x20]
006B21218  b        #0x6b21240 ; 
006B2121C  ldr      x2, [x1, #0x60]
006B21220  mov      x0, x19
006B21224  ldp      x20, x19, [sp, #0x10]
006B21228  ldp      x30, x21, [sp], #0x20
006B2122C  br       x2
006B21230  ldr      x8, [x2, #0x60]
006B21234  mov      x0, x19
006B21238  mov      w1, w20
006B2123C  blr      x8
006B21240  mov      x0, x19
006B21244  mov      x1, xzr
006B21248  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B2124C  adrp     x21, #0x959f000
006B21250  ldrb     w8, [x21, #0xa4f]
006B21254  mov      w20, w0
006B21258  cbnz     w8, #0x6b21270
006B2125C  adrp     x0, #0x8f3f000
006B21260  ldr      x0, [x0, #0x798]
006B21264  bl       #0x382bd14 ; 
006B21268  mov      w8, #1
006B2126C  strb     w8, [x21, #0xa4f]
006B21270  adrp     x8, #0x8f3f000
006B21274  ldr      x8, [x8, #0x798]
006B21278  ldr      x2, [x8]
006B2127C  ldrb     w8, [x2, #0x53]
006B21280  tbnz     w8, #5, #0x6b2128c
006B21284  str      w20, [x19, #0x24]
006B21288  b        #0x6b2129c ; 
006B2128C  ldr      x8, [x2, #0x60]
006B21290  mov      x0, x19
006B21294  mov      w1, w20
006B21298  blr      x8
006B2129C  mov      x0, x19
006B212A0  mov      x1, xzr
006B212A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B212A8  adrp     x21, #0x959f000
006B212AC  ldrb     w8, [x21, #0xa50]
006B212B0  mov      w20, w0
006B212B4  cbnz     w8, #0x6b212cc
006B212B8  adrp     x0, #0x8f3f000
006B212BC  ldr      x0, [x0, #0x7a0]
006B212C0  bl       #0x382bd14 ; 
006B212C4  mov      w8, #1
006B212C8  strb     w8, [x21, #0xa50]
006B212CC  adrp     x8, #0x8f3f000
006B212D0  ldr      x8, [x8, #0x7a0]
006B212D4  ldr      x2, [x8]
006B212D8  ldrb     w8, [x2, #0x53]
006B212DC  tbnz     w8, #5, #0x6b212e8
006B212E0  str      w20, [x19, #0x28]
006B212E4  b        #0x6b212f8 ; 
006B212E8  ldr      x8, [x2, #0x60]
006B212EC  mov      x0, x19
006B212F0  mov      w1, w20
006B212F4  blr      x8
006B212F8  mov      x0, x19
006B212FC  mov      x1, xzr
006B21300  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21304  adrp     x21, #0x959f000
006B21308  ldrb     w8, [x21, #0xa51]
006B2130C  mov      w20, w0
006B21310  cbnz     w8, #0x6b21328
006B21314  adrp     x0, #0x8f3f000
006B21318  ldr      x0, [x0, #0x7b0]
006B2131C  bl       #0x382bd14 ; 
006B21320  mov      w8, #1
006B21324  strb     w8, [x21, #0xa51]
006B21328  adrp     x8, #0x8f3f000
006B2132C  ldr      x8, [x8, #0x7b0]
006B21330  ldr      x2, [x8]
006B21334  ldrb     w8, [x2, #0x53]
006B21338  tbnz     w8, #5, #0x6b21344
006B2133C  str      w20, [x19, #0x2c]
006B21340  b        #0x6b21354 ; 
006B21344  ldr      x8, [x2, #0x60]
006B21348  mov      x0, x19
006B2134C  mov      w1, w20
006B21350  blr      x8
006B21354  mov      x0, x19
006B21358  mov      x1, xzr
006B2135C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21360  adrp     x21, #0x959f000
006B21364  ldrb     w8, [x21, #0xa52]
006B21368  mov      w20, w0
006B2136C  cbnz     w8, #0x6b21384
006B21370  adrp     x0, #0x8f3f000
006B21374  ldr      x0, [x0, #0x7c0]
006B21378  bl       #0x382bd14 ; 
006B2137C  mov      w8, #1
006B21380  strb     w8, [x21, #0xa52]
006B21384  adrp     x8, #0x8f3f000
006B21388  ldr      x8, [x8, #0x7c0]
006B2138C  ldr      x2, [x8]
006B21390  ldrb     w8, [x2, #0x53]
006B21394  tbnz     w8, #5, #0x6b213a0
006B21398  str      w20, [x19, #0x30]
006B2139C  b        #0x6b213b0 ; 
006B213A0  ldr      x8, [x2, #0x60]
006B213A4  mov      x0, x19
006B213A8  mov      w1, w20
006B213AC  blr      x8
006B213B0  mov      x0, x19
006B213B4  mov      x1, xzr
006B213B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B213BC  adrp     x21, #0x959f000
006B213C0  ldrb     w8, [x21, #0xa53]
006B213C4  mov      w20, w0
006B213C8  cbnz     w8, #0x6b213e0
006B213CC  adrp     x0, #0x8f3f000
006B213D0  ldr      x0, [x0, #0x7c8]
006B213D4  bl       #0x382bd14 ; 
006B213D8  mov      w8, #1
006B213DC  strb     w8, [x21, #0xa53]
006B213E0  adrp     x8, #0x8f3f000
006B213E4  ldr      x8, [x8, #0x7c8]
006B213E8  ldr      x2, [x8]
006B213EC  ldrb     w8, [x2, #0x53]
006B213F0  tbnz     w8, #5, #0x6b213fc
006B213F4  str      w20, [x19, #0x34]
006B213F8  b        #0x6b2140c ; 
006B213FC  ldr      x8, [x2, #0x60]
006B21400  mov      x0, x19
006B21404  mov      w1, w20
006B21408  blr      x8
006B2140C  mov      x0, x19
006B21410  mov      x1, xzr
006B21414  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B21418  adrp     x21, #0x959f000
006B2141C  ldrb     w8, [x21, #0xa54]
006B21420  mov      x20, x0
006B21424  cbnz     w8, #0x6b2143c
006B21428  adrp     x0, #0x8f3f000
006B2142C  ldr      x0, [x0, #0x7d0]
006B21430  bl       #0x382bd14 ; 
006B21434  mov      w8, #1
006B21438  strb     w8, [x21, #0xa54]
006B2143C  adrp     x8, #0x8f3f000
006B21440  ldr      x8, [x8, #0x7d0]
006B21444  ldr      x2, [x8]
006B21448  ldrb     w8, [x2, #0x53]
006B2144C  tbnz     w8, #5, #0x6b21464
006B21450  mov      x0, x19
006B21454  str      x20, [x0, #0x38]!
006B21458  mov      x1, x20
006B2145C  bl       #0x382bcb8 ; 
006B21460  b        #0x6b21474 ; 
006B21464  ldr      x8, [x2, #0x60]
006B21468  mov      x0, x19
006B2146C  mov      x1, x20
006B21470  blr      x8
006B21474  mov      x0, x19
006B21478  mov      x1, xzr
006B2147C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B21480  adrp     x21, #0x959f000
006B21484  ldrb     w8, [x21, #0xa55]
006B21488  mov      x20, x0
006B2148C  cbnz     w8, #0x6b214a4
006B21490  adrp     x0, #0x8f3f000
006B21494  ldr      x0, [x0, #0x7d8]
006B21498  bl       #0x382bd14 ; 
006B2149C  mov      w8, #1
006B214A0  strb     w8, [x21, #0xa55]
006B214A4  adrp     x8, #0x8f3f000
006B214A8  ldr      x8, [x8, #0x7d8]
006B214AC  ldr      x2, [x8]
006B214B0  ldrb     w8, [x2, #0x53]
006B214B4  tbnz     w8, #5, #0x6b214cc
006B214B8  mov      x0, x19
006B214BC  str      x20, [x0, #0x40]!
006B214C0  mov      x1, x20
006B214C4  bl       #0x382bcb8 ; 
006B214C8  b        #0x6b214dc ; 
006B214CC  ldr      x8, [x2, #0x60]
006B214D0  mov      x0, x19
006B214D4  mov      x1, x20
006B214D8  blr      x8
006B214DC  mov      x0, x19
006B214E0  mov      x1, xzr
006B214E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B214E8  adrp     x21, #0x959f000
006B214EC  ldrb     w8, [x21, #0xa56]
006B214F0  mov      w20, w0
006B214F4  cbnz     w8, #0x6b2150c
006B214F8  adrp     x0, #0x8f3f000
006B214FC  ldr      x0, [x0, #0x7e0]
006B21500  bl       #0x382bd14 ; 
006B21504  mov      w8, #1
006B21508  strb     w8, [x21, #0xa56]
006B2150C  adrp     x8, #0x8f3f000
006B21510  ldr      x8, [x8, #0x7e0]
006B21514  ldr      x2, [x8]
006B21518  ldrb     w8, [x2, #0x53]
006B2151C  tbnz     w8, #5, #0x6b21528
006B21520  str      w20, [x19, #0x48]
006B21524  b        #0x6b21538 ; 
006B21528  ldr      x8, [x2, #0x60]
006B2152C  mov      x0, x19
006B21530  mov      w1, w20
006B21534  blr      x8
006B21538  mov      x0, x19
006B2153C  mov      x1, xzr
006B21540  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21544  adrp     x21, #0x959f000
006B21548  ldrb     w8, [x21, #0xa57]
006B2154C  mov      w20, w0
006B21550  cbnz     w8, #0x6b21568
006B21554  adrp     x0, #0x8f3f000
006B21558  ldr      x0, [x0, #0x7e8]
006B2155C  bl       #0x382bd14 ; 
006B21560  mov      w8, #1
006B21564  strb     w8, [x21, #0xa57]
006B21568  adrp     x8, #0x8f3f000
006B2156C  ldr      x8, [x8, #0x7e8]
006B21570  ldr      x2, [x8]
006B21574  ldrb     w8, [x2, #0x53]
006B21578  tbnz     w8, #5, #0x6b21584
006B2157C  str      w20, [x19, #0x4c]
006B21580  b        #0x6b21594 ; 
006B21584  ldr      x8, [x2, #0x60]
006B21588  mov      x0, x19
006B2158C  mov      w1, w20
006B21590  blr      x8
006B21594  mov      x0, x19
006B21598  mov      x1, xzr
006B2159C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B215A0  adrp     x21, #0x959f000
006B215A4  ldrb     w8, [x21, #0xa58]
006B215A8  mov      x20, x0
006B215AC  cbnz     w8, #0x6b215c4
006B215B0  adrp     x0, #0x8f3f000
006B215B4  ldr      x0, [x0, #0x7f0]
006B215B8  bl       #0x382bd14 ; 
006B215BC  mov      w8, #1
006B215C0  strb     w8, [x21, #0xa58]
006B215C4  adrp     x8, #0x8f3f000
006B215C8  ldr      x8, [x8, #0x7f0]
006B215CC  ldr      x2, [x8]
006B215D0  ldrb     w8, [x2, #0x53]
006B215D4  tbnz     w8, #5, #0x6b215ec
006B215D8  mov      x0, x19
006B215DC  str      x20, [x0, #0x50]!
006B215E0  mov      x1, x20
006B215E4  bl       #0x382bcb8 ; 
006B215E8  b        #0x6b215fc ; 
006B215EC  ldr      x8, [x2, #0x60]
006B215F0  mov      x0, x19
006B215F4  mov      x1, x20
006B215F8  blr      x8
006B215FC  mov      x0, x19
006B21600  mov      x1, xzr
006B21604  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B21608  adrp     x21, #0x959f000
006B2160C  ldrb     w8, [x21, #0xa59]
006B21610  mov      x20, x0
006B21614  cbnz     w8, #0x6b2162c
006B21618  adrp     x0, #0x8f3f000
006B2161C  ldr      x0, [x0, #0x7f8]
006B21620  bl       #0x382bd14 ; 
006B21624  mov      w8, #1
006B21628  strb     w8, [x21, #0xa59]
006B2162C  adrp     x8, #0x8f3f000
006B21630  ldr      x8, [x8, #0x7f8]
006B21634  ldr      x2, [x8]
006B21638  ldrb     w8, [x2, #0x53]
006B2163C  tbnz     w8, #5, #0x6b21654
006B21640  mov      x0, x19
006B21644  str      x20, [x0, #0x58]!
006B21648  mov      x1, x20
006B2164C  bl       #0x382bcb8 ; 
006B21650  b        #0x6b21664 ; 
006B21654  ldr      x8, [x2, #0x60]
006B21658  mov      x0, x19
006B2165C  mov      x1, x20
006B21660  blr      x8
006B21664  mov      x0, x19
006B21668  mov      x1, xzr
006B2166C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B21670  adrp     x21, #0x959f000
006B21674  ldrb     w8, [x21, #0xa5a]
006B21678  mov      x20, x0
006B2167C  cbnz     w8, #0x6b21694
006B21680  adrp     x0, #0x8f3f000
006B21684  ldr      x0, [x0, #0x800]
006B21688  bl       #0x382bd14 ; 
006B2168C  mov      w8, #1
006B21690  strb     w8, [x21, #0xa5a]
006B21694  adrp     x8, #0x8f3f000
006B21698  ldr      x8, [x8, #0x800]
006B2169C  ldr      x2, [x8]
006B216A0  ldrb     w8, [x2, #0x53]
006B216A4  tbnz     w8, #5, #0x6b216bc
006B216A8  mov      x0, x19
006B216AC  str      x20, [x0, #0x60]!
006B216B0  mov      x1, x20
006B216B4  bl       #0x382bcb8 ; 
006B216B8  b        #0x6b216cc ; 
006B216BC  ldr      x8, [x2, #0x60]
006B216C0  mov      x0, x19
006B216C4  mov      x1, x20
006B216C8  blr      x8
006B216CC  mov      x0, x19
006B216D0  mov      x1, xzr
006B216D4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B216D8  adrp     x21, #0x959f000
006B216DC  ldrb     w8, [x21, #0xa5b]
006B216E0  mov      x20, x0
006B216E4  cbnz     w8, #0x6b216fc
006B216E8  adrp     x0, #0x8f3f000
006B216EC  ldr      x0, [x0, #0x808]
006B216F0  bl       #0x382bd14 ; 
006B216F4  mov      w8, #1
006B216F8  strb     w8, [x21, #0xa5b]
006B216FC  adrp     x8, #0x8f3f000
006B21700  ldr      x8, [x8, #0x808]
006B21704  ldr      x2, [x8]
006B21708  ldrb     w8, [x2, #0x53]
006B2170C  tbnz     w8, #5, #0x6b21724
006B21710  mov      x0, x19
006B21714  str      x20, [x0, #0x68]!
006B21718  mov      x1, x20
006B2171C  bl       #0x382bcb8 ; 
006B21720  b        #0x6b21734 ; 
006B21724  ldr      x8, [x2, #0x60]
006B21728  mov      x0, x19
006B2172C  mov      x1, x20
006B21730  blr      x8
006B21734  mov      x0, x19
006B21738  mov      x1, xzr
006B2173C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21740  adrp     x21, #0x959f000
006B21744  ldrb     w8, [x21, #0xa5c]
006B21748  mov      w20, w0
006B2174C  cbnz     w8, #0x6b21764
006B21750  adrp     x0, #0x8f3f000
006B21754  ldr      x0, [x0, #0x810]
006B21758  bl       #0x382bd14 ; 
006B2175C  mov      w8, #1
006B21760  strb     w8, [x21, #0xa5c]
006B21764  adrp     x8, #0x8f3f000
006B21768  ldr      x8, [x8, #0x810]
006B2176C  ldr      x2, [x8]
006B21770  ldrb     w8, [x2, #0x53]
006B21774  tbnz     w8, #5, #0x6b21780
006B21778  str      w20, [x19, #0x70]
006B2177C  b        #0x6b21790 ; 
006B21780  ldr      x8, [x2, #0x60]
006B21784  mov      x0, x19
006B21788  mov      w1, w20
006B2178C  blr      x8
006B21790  mov      x0, x19
006B21794  mov      x1, xzr
006B21798  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B2179C  adrp     x21, #0x959f000
006B217A0  ldrb     w8, [x21, #0xa5d]
006B217A4  mov      x20, x0
006B217A8  cbnz     w8, #0x6b217c0
006B217AC  adrp     x0, #0x8f3f000
006B217B0  ldr      x0, [x0, #0x818]
006B217B4  bl       #0x382bd14 ; 
006B217B8  mov      w8, #1
006B217BC  strb     w8, [x21, #0xa5d]
006B217C0  adrp     x8, #0x8f3f000
006B217C4  ldr      x8, [x8, #0x818]
006B217C8  ldr      x2, [x8]
006B217CC  ldrb     w8, [x2, #0x53]
006B217D0  tbnz     w8, #5, #0x6b217e8
006B217D4  mov      x0, x19
006B217D8  str      x20, [x0, #0x78]!
006B217DC  mov      x1, x20
006B217E0  bl       #0x382bcb8 ; 
006B217E4  b        #0x6b217f8 ; 
006B217E8  ldr      x8, [x2, #0x60]
006B217EC  mov      x0, x19
006B217F0  mov      x1, x20
006B217F4  blr      x8
006B217F8  mov      x0, x19
006B217FC  mov      x1, xzr
006B21800  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B21804  adrp     x21, #0x959f000
006B21808  ldrb     w8, [x21, #0xa5e]
006B2180C  mov      x20, x0
006B21810  cbnz     w8, #0x6b21828
006B21814  adrp     x0, #0x8f3f000
006B21818  ldr      x0, [x0, #0x820]
006B2181C  bl       #0x382bd14 ; 
006B21820  mov      w8, #1
006B21824  strb     w8, [x21, #0xa5e]
006B21828  adrp     x8, #0x8f3f000
006B2182C  ldr      x8, [x8, #0x820]
006B21830  ldr      x2, [x8]
006B21834  ldrb     w8, [x2, #0x53]
006B21838  tbnz     w8, #5, #0x6b21850
006B2183C  mov      x0, x19
006B21840  str      x20, [x0, #0x80]!
006B21844  mov      x1, x20
006B21848  bl       #0x382bcb8 ; 
006B2184C  b        #0x6b21860 ; 
006B21850  ldr      x8, [x2, #0x60]
006B21854  mov      x0, x19
006B21858  mov      x1, x20
006B2185C  blr      x8
006B21860  mov      x0, x19
006B21864  mov      x1, xzr
006B21868  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B2186C  adrp     x21, #0x959f000
006B21870  ldrb     w8, [x21, #0xa5f]
006B21874  mov      x20, x0
006B21878  cbnz     w8, #0x6b21890
006B2187C  adrp     x0, #0x8f3f000
006B21880  ldr      x0, [x0, #0x828]
006B21884  bl       #0x382bd14 ; 
006B21888  mov      w8, #1
006B2188C  strb     w8, [x21, #0xa5f]
006B21890  adrp     x8, #0x8f3f000
006B21894  ldr      x8, [x8, #0x828]
006B21898  ldr      x2, [x8]
006B2189C  ldrb     w8, [x2, #0x53]
006B218A0  tbnz     w8, #5, #0x6b218b8
006B218A4  mov      x0, x19
006B218A8  str      x20, [x0, #0x88]!
006B218AC  mov      x1, x20
006B218B0  bl       #0x382bcb8 ; 
006B218B4  b        #0x6b218c8 ; 
006B218B8  ldr      x8, [x2, #0x60]
006B218BC  mov      x0, x19
006B218C0  mov      x1, x20
006B218C4  blr      x8
006B218C8  mov      x0, x19
006B218CC  mov      x1, xzr
006B218D0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B218D4  adrp     x21, #0x959f000
006B218D8  ldrb     w8, [x21, #0xa60]
006B218DC  mov      x20, x0
006B218E0  cbnz     w8, #0x6b218f8
006B218E4  adrp     x0, #0x8f3f000
006B218E8  ldr      x0, [x0, #0x830]
006B218EC  bl       #0x382bd14 ; 
006B218F0  mov      w8, #1
006B218F4  strb     w8, [x21, #0xa60]
006B218F8  adrp     x8, #0x8f3f000
006B218FC  ldr      x8, [x8, #0x830]
006B21900  ldr      x2, [x8]
006B21904  ldrb     w8, [x2, #0x53]
006B21908  tbnz     w8, #5, #0x6b21920
006B2190C  mov      x0, x19
006B21910  str      x20, [x0, #0x90]!
006B21914  mov      x1, x20
006B21918  bl       #0x382bcb8 ; 
006B2191C  b        #0x6b21930 ; 
006B21920  ldr      x8, [x2, #0x60]
006B21924  mov      x0, x19
006B21928  mov      x1, x20
006B2192C  blr      x8
006B21930  mov      x0, x19
006B21934  mov      x1, xzr
006B21938  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B2193C  adrp     x21, #0x959f000
006B21940  ldrb     w8, [x21, #0xa61]
006B21944  mov      x20, x0
006B21948  cbnz     w8, #0x6b21960
006B2194C  adrp     x0, #0x8f3f000
006B21950  ldr      x0, [x0, #0x838]
006B21954  bl       #0x382bd14 ; 
006B21958  mov      w8, #1
006B2195C  strb     w8, [x21, #0xa61]
006B21960  adrp     x8, #0x8f3f000
006B21964  ldr      x8, [x8, #0x838]
006B21968  ldr      x2, [x8]
006B2196C  ldrb     w8, [x2, #0x53]
006B21970  tbnz     w8, #5, #0x6b21988
006B21974  mov      x0, x19
006B21978  str      x20, [x0, #0x98]!
006B2197C  mov      x1, x20
006B21980  bl       #0x382bcb8 ; 
006B21984  b        #0x6b21998 ; 
006B21988  ldr      x8, [x2, #0x60]
006B2198C  mov      x0, x19
006B21990  mov      x1, x20
006B21994  blr      x8
006B21998  mov      x0, x19
006B2199C  mov      x1, xzr
006B219A0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B219A4  adrp     x21, #0x959f000
006B219A8  ldrb     w8, [x21, #0xa62]
006B219AC  mov      x20, x0
006B219B0  cbnz     w8, #0x6b219c8
006B219B4  adrp     x0, #0x8f3f000
006B219B8  ldr      x0, [x0, #0x840]
006B219BC  bl       #0x382bd14 ; 
006B219C0  mov      w8, #1
006B219C4  strb     w8, [x21, #0xa62]
006B219C8  adrp     x8, #0x8f3f000
006B219CC  ldr      x8, [x8, #0x840]
006B219D0  ldr      x2, [x8]
006B219D4  ldrb     w8, [x2, #0x53]
006B219D8  tbnz     w8, #5, #0x6b219f0
006B219DC  mov      x0, x19
006B219E0  str      x20, [x0, #0xa0]!
006B219E4  mov      x1, x20
006B219E8  bl       #0x382bcb8 ; 
006B219EC  b        #0x6b21a00 ; 
006B219F0  ldr      x8, [x2, #0x60]
006B219F4  mov      x0, x19
006B219F8  mov      x1, x20
006B219FC  blr      x8
006B21A00  mov      x0, x19
006B21A04  mov      x1, xzr
006B21A08  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B21A0C  adrp     x21, #0x959f000
006B21A10  ldrb     w8, [x21, #0xa63]
006B21A14  mov      x20, x0
006B21A18  cbnz     w8, #0x6b21a30
006B21A1C  adrp     x0, #0x8f3f000
006B21A20  ldr      x0, [x0, #0x848]
006B21A24  bl       #0x382bd14 ; 
006B21A28  mov      w8, #1
006B21A2C  strb     w8, [x21, #0xa63]
006B21A30  adrp     x8, #0x8f3f000
006B21A34  ldr      x8, [x8, #0x848]
006B21A38  ldr      x2, [x8]
006B21A3C  ldrb     w8, [x2, #0x53]
006B21A40  tbnz     w8, #5, #0x6b21a58
006B21A44  mov      x0, x19
006B21A48  str      x20, [x0, #0xa8]!
006B21A4C  mov      x1, x20
006B21A50  bl       #0x382bcb8 ; 
006B21A54  b        #0x6b21a68 ; 
006B21A58  ldr      x8, [x2, #0x60]
006B21A5C  mov      x0, x19
006B21A60  mov      x1, x20
006B21A64  blr      x8
006B21A68  mov      x0, x19
006B21A6C  mov      x1, xzr
006B21A70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21A74  adrp     x21, #0x959f000
006B21A78  ldrb     w8, [x21, #0xa64]
006B21A7C  mov      w20, w0
006B21A80  cbnz     w8, #0x6b21a98
006B21A84  adrp     x0, #0x8f3f000
006B21A88  ldr      x0, [x0, #0x850]
006B21A8C  bl       #0x382bd14 ; 
006B21A90  mov      w8, #1
006B21A94  strb     w8, [x21, #0xa64]
006B21A98  adrp     x8, #0x8f3f000
006B21A9C  ldr      x8, [x8, #0x850]
006B21AA0  ldr      x2, [x8]
006B21AA4  ldrb     w8, [x2, #0x53]
006B21AA8  tbnz     w8, #5, #0x6b21ab4
006B21AAC  str      w20, [x19, #0xb0]
006B21AB0  b        #0x6b21ac4 ; 
006B21AB4  ldr      x8, [x2, #0x60]
006B21AB8  mov      x0, x19
006B21ABC  mov      w1, w20
006B21AC0  blr      x8
006B21AC4  mov      x0, x19
006B21AC8  mov      x1, xzr
006B21ACC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21AD0  adrp     x21, #0x959f000
006B21AD4  ldrb     w8, [x21, #0xa65]
006B21AD8  mov      w20, w0
006B21ADC  cbnz     w8, #0x6b21af4
006B21AE0  adrp     x0, #0x8f3f000
006B21AE4  ldr      x0, [x0, #0x858]
006B21AE8  bl       #0x382bd14 ; 
006B21AEC  mov      w8, #1
006B21AF0  strb     w8, [x21, #0xa65]
006B21AF4  adrp     x8, #0x8f3f000
006B21AF8  ldr      x8, [x8, #0x858]
006B21AFC  ldr      x2, [x8]
006B21B00  ldrb     w8, [x2, #0x53]
006B21B04  tbnz     w8, #5, #0x6b21b10
006B21B08  str      w20, [x19, #0xb4]
006B21B0C  b        #0x6b21b20 ; 
006B21B10  ldr      x8, [x2, #0x60]
006B21B14  mov      x0, x19
006B21B18  mov      w1, w20
006B21B1C  blr      x8
006B21B20  mov      x0, x19
006B21B24  mov      x1, xzr
006B21B28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21B2C  adrp     x21, #0x959f000
006B21B30  ldrb     w8, [x21, #0xa66]
006B21B34  mov      w20, w0
006B21B38  cbnz     w8, #0x6b21b50
006B21B3C  adrp     x0, #0x8f3f000
006B21B40  ldr      x0, [x0, #0x860]
006B21B44  bl       #0x382bd14 ; 
006B21B48  mov      w8, #1
006B21B4C  strb     w8, [x21, #0xa66]
006B21B50  adrp     x8, #0x8f3f000
006B21B54  ldr      x8, [x8, #0x860]
006B21B58  ldr      x2, [x8]
006B21B5C  ldrb     w8, [x2, #0x53]
006B21B60  tbnz     w8, #5, #0x6b21b6c
006B21B64  str      w20, [x19, #0xb8]
006B21B68  b        #0x6b21b7c ; 
006B21B6C  ldr      x8, [x2, #0x60]
006B21B70  mov      x0, x19
006B21B74  mov      w1, w20
006B21B78  blr      x8
006B21B7C  mov      x0, x19
006B21B80  mov      x1, xzr
006B21B84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21B88  adrp     x21, #0x959f000
006B21B8C  ldrb     w8, [x21, #0xa67]
006B21B90  mov      w20, w0
006B21B94  cbnz     w8, #0x6b21bac
006B21B98  adrp     x0, #0x8f3f000
006B21B9C  ldr      x0, [x0, #0x868]
006B21BA0  bl       #0x382bd14 ; 
006B21BA4  mov      w8, #1
006B21BA8  strb     w8, [x21, #0xa67]
006B21BAC  adrp     x8, #0x8f3f000
006B21BB0  ldr      x8, [x8, #0x868]
006B21BB4  ldr      x2, [x8]
006B21BB8  ldrb     w8, [x2, #0x53]
006B21BBC  tbnz     w8, #5, #0x6b21bc8
006B21BC0  str      w20, [x19, #0xbc]
006B21BC4  b        #0x6b21bd8 ; 
006B21BC8  ldr      x8, [x2, #0x60]
006B21BCC  mov      x0, x19
006B21BD0  mov      w1, w20
006B21BD4  blr      x8
006B21BD8  mov      x0, x19
006B21BDC  mov      x1, xzr
006B21BE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21BE4  adrp     x21, #0x959f000
006B21BE8  ldrb     w8, [x21, #0xa68]
006B21BEC  mov      w20, w0
006B21BF0  cbnz     w8, #0x6b21c08
006B21BF4  adrp     x0, #0x8f3f000
006B21BF8  ldr      x0, [x0, #0x870]
006B21BFC  bl       #0x382bd14 ; 
006B21C00  mov      w8, #1
006B21C04  strb     w8, [x21, #0xa68]
006B21C08  adrp     x8, #0x8f3f000
006B21C0C  ldr      x8, [x8, #0x870]
006B21C10  ldr      x2, [x8]
006B21C14  ldrb     w8, [x2, #0x53]
006B21C18  tbnz     w8, #5, #0x6b21c24
006B21C1C  str      w20, [x19, #0xc0]
006B21C20  b        #0x6b21c34 ; 
006B21C24  ldr      x8, [x2, #0x60]
006B21C28  mov      x0, x19
006B21C2C  mov      w1, w20
006B21C30  blr      x8
006B21C34  mov      x0, x19
006B21C38  mov      x1, xzr
006B21C3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21C40  adrp     x21, #0x959f000
006B21C44  ldrb     w8, [x21, #0xa69]
006B21C48  mov      w20, w0
006B21C4C  cbnz     w8, #0x6b21c64
006B21C50  adrp     x0, #0x8f3f000
006B21C54  ldr      x0, [x0, #0x878]
006B21C58  bl       #0x382bd14 ; 
006B21C5C  mov      w8, #1
006B21C60  strb     w8, [x21, #0xa69]
006B21C64  adrp     x8, #0x8f3f000
006B21C68  ldr      x8, [x8, #0x878]
006B21C6C  ldr      x2, [x8]
006B21C70  ldrb     w8, [x2, #0x53]
006B21C74  tbnz     w8, #5, #0x6b21c80
006B21C78  str      w20, [x19, #0xc4]
006B21C7C  b        #0x6b21c90 ; 
006B21C80  ldr      x8, [x2, #0x60]
006B21C84  mov      x0, x19
006B21C88  mov      w1, w20
006B21C8C  blr      x8
006B21C90  mov      x0, x19
006B21C94  mov      x1, xzr
006B21C98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21C9C  adrp     x21, #0x959f000
006B21CA0  ldrb     w8, [x21, #0xa6a]
006B21CA4  mov      w20, w0
006B21CA8  cbnz     w8, #0x6b21cc0
006B21CAC  adrp     x0, #0x8f3f000
006B21CB0  ldr      x0, [x0, #0x880]
006B21CB4  bl       #0x382bd14 ; 
006B21CB8  mov      w8, #1
006B21CBC  strb     w8, [x21, #0xa6a]
006B21CC0  adrp     x8, #0x8f3f000
006B21CC4  ldr      x8, [x8, #0x880]
006B21CC8  ldr      x2, [x8]
006B21CCC  ldrb     w8, [x2, #0x53]
006B21CD0  tbnz     w8, #5, #0x6b21cdc
006B21CD4  str      w20, [x19, #0xc8]
006B21CD8  b        #0x6b21cec ; 
006B21CDC  ldr      x8, [x2, #0x60]
006B21CE0  mov      x0, x19
006B21CE4  mov      w1, w20
006B21CE8  blr      x8
006B21CEC  mov      x0, x19
006B21CF0  mov      x1, xzr
006B21CF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B21CF8  adrp     x21, #0x959f000
006B21CFC  ldrb     w8, [x21, #0xa6b]
006B21D00  mov      w20, w0
006B21D04  cbnz     w8, #0x6b21d1c
006B21D08  adrp     x0, #0x8f3f000
006B21D0C  ldr      x0, [x0, #0x888]
006B21D10  bl       #0x382bd14 ; 
006B21D14  mov      w8, #1
006B21D18  strb     w8, [x21, #0xa6b]
006B21D1C  adrp     x8, #0x8f3f000
006B21D20  ldr      x8, [x8, #0x888]
006B21D24  ldr      x2, [x8]
006B21D28  ldrb     w8, [x2, #0x53]
006B21D2C  tbnz     w8, #5, #0x6b21d38
006B21D30  str      w20, [x19, #0xcc]
006B21D34  b        #0x6b21d48 ; 
006B21D38  ldr      x8, [x2, #0x60]
006B21D3C  mov      x0, x19
006B21D40  mov      w1, w20
006B21D44  blr      x8
006B21D48  ldp      x20, x19, [sp, #0x10]
006B21D4C  mov      w0, #1
006B21D50  ldp      x30, x21, [sp], #0x20
006B21D54  ret      

