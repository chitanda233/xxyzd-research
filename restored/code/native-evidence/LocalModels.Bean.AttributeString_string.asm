; LocalModels.Bean.AttributeString_string$$readImpl
; RVA 0x6702F00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006702F00  stp      x30, x21, [sp, #-0x20]!
006702F04  stp      x20, x19, [sp, #0x10]
006702F08  adrp     x20, #0x959a000
006702F0C  adrp     x21, #0x8f17000
006702F10  ldrb     w8, [x20, #0x8d3]
006702F14  ldr      x21, [x21, #0x8a0]
006702F18  mov      x19, x0
006702F1C  tbnz     w8, #0, #0x6702f34
006702F20  adrp     x0, #0x8f17000
006702F24  ldr      x0, [x0, #0x8a0]
006702F28  bl       #0x382bd14 ; 
006702F2C  mov      w8, #1
006702F30  strb     w8, [x20, #0x8d3]
006702F34  ldr      x1, [x21]
006702F38  ldrb     w8, [x1, #0x53]
006702F3C  tbnz     w8, #5, #0x6702f8c
006702F40  mov      x0, x19
006702F44  mov      x1, xzr
006702F48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006702F4C  adrp     x21, #0x959a000
006702F50  ldrb     w8, [x21, #0x966]
006702F54  mov      w20, w0
006702F58  cbnz     w8, #0x6702f70
006702F5C  adrp     x0, #0x8f17000
006702F60  ldr      x0, [x0, #0x7c8]
006702F64  bl       #0x382bd14 ; 
006702F68  mov      w8, #1
006702F6C  strb     w8, [x21, #0x966]
006702F70  adrp     x8, #0x8f17000
006702F74  ldr      x8, [x8, #0x7c8]
006702F78  ldr      x2, [x8]
006702F7C  ldrb     w8, [x2, #0x53]
006702F80  tbnz     w8, #5, #0x6702fa0
006702F84  str      w20, [x19, #0x20]
006702F88  b        #0x6702fb0 ; 
006702F8C  ldr      x2, [x1, #0x60]
006702F90  mov      x0, x19
006702F94  ldp      x20, x19, [sp, #0x10]
006702F98  ldp      x30, x21, [sp], #0x20
006702F9C  br       x2
006702FA0  ldr      x8, [x2, #0x60]
006702FA4  mov      x0, x19
006702FA8  mov      w1, w20
006702FAC  blr      x8
006702FB0  mov      x0, x19
006702FB4  mov      x1, xzr
006702FB8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006702FBC  adrp     x21, #0x959a000
006702FC0  ldrb     w8, [x21, #0x967]
006702FC4  mov      x20, x0
006702FC8  cbnz     w8, #0x6702fe0
006702FCC  adrp     x0, #0x8f17000
006702FD0  ldr      x0, [x0, #0x7d8]
006702FD4  bl       #0x382bd14 ; 
006702FD8  mov      w8, #1
006702FDC  strb     w8, [x21, #0x967]
006702FE0  adrp     x8, #0x8f17000
006702FE4  ldr      x8, [x8, #0x7d8]
006702FE8  ldr      x2, [x8]
006702FEC  ldrb     w8, [x2, #0x53]
006702FF0  tbnz     w8, #5, #0x6703008
006702FF4  mov      x0, x19
006702FF8  str      x20, [x0, #0x28]!
006702FFC  mov      x1, x20
006703000  bl       #0x382bcb8 ; 
006703004  b        #0x6703018 ; 
006703008  ldr      x8, [x2, #0x60]
00670300C  mov      x0, x19
006703010  mov      x1, x20
006703014  blr      x8
006703018  mov      x0, x19
00670301C  mov      x1, xzr
006703020  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006703024  adrp     x21, #0x959a000
006703028  ldrb     w8, [x21, #0x968]
00670302C  mov      x20, x0
006703030  cbnz     w8, #0x6703048
006703034  adrp     x0, #0x8f17000
006703038  ldr      x0, [x0, #0x7e8]
00670303C  bl       #0x382bd14 ; 
006703040  mov      w8, #1
006703044  strb     w8, [x21, #0x968]
006703048  adrp     x8, #0x8f17000
00670304C  ldr      x8, [x8, #0x7e8]
006703050  ldr      x2, [x8]
006703054  ldrb     w8, [x2, #0x53]
006703058  tbnz     w8, #5, #0x6703070
00670305C  mov      x0, x19
006703060  str      x20, [x0, #0x30]!
006703064  mov      x1, x20
006703068  bl       #0x382bcb8 ; 
00670306C  b        #0x6703080 ; 
006703070  ldr      x8, [x2, #0x60]
006703074  mov      x0, x19
006703078  mov      x1, x20
00670307C  blr      x8
006703080  mov      x0, x19
006703084  mov      x1, xzr
006703088  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00670308C  adrp     x21, #0x959a000
006703090  ldrb     w8, [x21, #0x969]
006703094  mov      w20, w0
006703098  cbnz     w8, #0x67030b0
00670309C  adrp     x0, #0x8f17000
0067030A0  ldr      x0, [x0, #0x7f8]
0067030A4  bl       #0x382bd14 ; 
0067030A8  mov      w8, #1
0067030AC  strb     w8, [x21, #0x969]
0067030B0  adrp     x8, #0x8f17000
0067030B4  ldr      x8, [x8, #0x7f8]
0067030B8  ldr      x2, [x8]
0067030BC  ldrb     w8, [x2, #0x53]
0067030C0  tbnz     w8, #5, #0x67030cc
0067030C4  str      w20, [x19, #0x38]
0067030C8  b        #0x67030dc ; 
0067030CC  ldr      x8, [x2, #0x60]
0067030D0  mov      x0, x19
0067030D4  mov      w1, w20
0067030D8  blr      x8
0067030DC  mov      x0, x19
0067030E0  mov      x1, xzr
0067030E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067030E8  adrp     x21, #0x959a000
0067030EC  ldrb     w8, [x21, #0x96a]
0067030F0  mov      w20, w0
0067030F4  cbnz     w8, #0x670310c
0067030F8  adrp     x0, #0x8f17000
0067030FC  ldr      x0, [x0, #0x808]
006703100  bl       #0x382bd14 ; 
006703104  mov      w8, #1
006703108  strb     w8, [x21, #0x96a]
00670310C  adrp     x8, #0x8f17000
006703110  ldr      x8, [x8, #0x808]
006703114  ldr      x2, [x8]
006703118  ldrb     w8, [x2, #0x53]
00670311C  tbnz     w8, #5, #0x6703128
006703120  str      w20, [x19, #0x3c]
006703124  b        #0x6703138 ; 
006703128  ldr      x8, [x2, #0x60]
00670312C  mov      x0, x19
006703130  mov      w1, w20
006703134  blr      x8
006703138  mov      x0, x19
00670313C  mov      x1, xzr
006703140  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006703144  adrp     x21, #0x959a000
006703148  ldrb     w8, [x21, #0x96b]
00670314C  mov      w20, w0
006703150  cbnz     w8, #0x6703168
006703154  adrp     x0, #0x8f17000
006703158  ldr      x0, [x0, #0x818]
00670315C  bl       #0x382bd14 ; 
006703160  mov      w8, #1
006703164  strb     w8, [x21, #0x96b]
006703168  adrp     x8, #0x8f17000
00670316C  ldr      x8, [x8, #0x818]
006703170  ldr      x2, [x8]
006703174  ldrb     w8, [x2, #0x53]
006703178  tbnz     w8, #5, #0x6703184
00670317C  str      w20, [x19, #0x40]
006703180  b        #0x6703194 ; 
006703184  ldr      x8, [x2, #0x60]
006703188  mov      x0, x19
00670318C  mov      w1, w20
006703190  blr      x8
006703194  mov      x0, x19
006703198  mov      x1, xzr
00670319C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067031A0  adrp     x21, #0x959a000
0067031A4  ldrb     w8, [x21, #0x96c]
0067031A8  mov      w20, w0
0067031AC  cbnz     w8, #0x67031c4
0067031B0  adrp     x0, #0x8f17000
0067031B4  ldr      x0, [x0, #0x828]
0067031B8  bl       #0x382bd14 ; 
0067031BC  mov      w8, #1
0067031C0  strb     w8, [x21, #0x96c]
0067031C4  adrp     x8, #0x8f17000
0067031C8  ldr      x8, [x8, #0x828]
0067031CC  ldr      x2, [x8]
0067031D0  ldrb     w8, [x2, #0x53]
0067031D4  tbnz     w8, #5, #0x67031e0
0067031D8  str      w20, [x19, #0x44]
0067031DC  b        #0x67031f0 ; 
0067031E0  ldr      x8, [x2, #0x60]
0067031E4  mov      x0, x19
0067031E8  mov      w1, w20
0067031EC  blr      x8
0067031F0  mov      x0, x19
0067031F4  mov      x1, xzr
0067031F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0067031FC  adrp     x21, #0x959a000
006703200  ldrb     w8, [x21, #0x96d]
006703204  mov      x20, x0
006703208  cbnz     w8, #0x6703220
00670320C  adrp     x0, #0x8f17000
006703210  ldr      x0, [x0, #0x838]
006703214  bl       #0x382bd14 ; 
006703218  mov      w8, #1
00670321C  strb     w8, [x21, #0x96d]
006703220  adrp     x8, #0x8f17000
006703224  ldr      x8, [x8, #0x838]
006703228  ldr      x2, [x8]
00670322C  ldrb     w8, [x2, #0x53]
006703230  tbnz     w8, #5, #0x6703248
006703234  mov      x0, x19
006703238  str      x20, [x0, #0x48]!
00670323C  mov      x1, x20
006703240  bl       #0x382bcb8 ; 
006703244  b        #0x6703258 ; 
006703248  ldr      x8, [x2, #0x60]
00670324C  mov      x0, x19
006703250  mov      x1, x20
006703254  blr      x8
006703258  mov      x0, x19
00670325C  mov      x1, xzr
006703260  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006703264  adrp     x21, #0x959a000
006703268  ldrb     w8, [x21, #0x96e]
00670326C  mov      w20, w0
006703270  cbnz     w8, #0x6703288
006703274  adrp     x0, #0x8f17000
006703278  ldr      x0, [x0, #0x848]
00670327C  bl       #0x382bd14 ; 
006703280  mov      w8, #1
006703284  strb     w8, [x21, #0x96e]
006703288  adrp     x8, #0x8f17000
00670328C  ldr      x8, [x8, #0x848]
006703290  ldr      x2, [x8]
006703294  ldrb     w8, [x2, #0x53]
006703298  tbnz     w8, #5, #0x67032a4
00670329C  str      w20, [x19, #0x50]
0067032A0  b        #0x67032b4 ; 
0067032A4  ldr      x8, [x2, #0x60]
0067032A8  mov      x0, x19
0067032AC  mov      w1, w20
0067032B0  blr      x8
0067032B4  mov      x0, x19
0067032B8  mov      x1, xzr
0067032BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067032C0  adrp     x21, #0x959a000
0067032C4  ldrb     w8, [x21, #0x96f]
0067032C8  mov      w20, w0
0067032CC  cbnz     w8, #0x67032e4
0067032D0  adrp     x0, #0x8f17000
0067032D4  ldr      x0, [x0, #0x858]
0067032D8  bl       #0x382bd14 ; 
0067032DC  mov      w8, #1
0067032E0  strb     w8, [x21, #0x96f]
0067032E4  adrp     x8, #0x8f17000
0067032E8  ldr      x8, [x8, #0x858]
0067032EC  ldr      x2, [x8]
0067032F0  ldrb     w8, [x2, #0x53]
0067032F4  tbnz     w8, #5, #0x6703300
0067032F8  str      w20, [x19, #0x54]
0067032FC  b        #0x6703310 ; 
006703300  ldr      x8, [x2, #0x60]
006703304  mov      x0, x19
006703308  mov      w1, w20
00670330C  blr      x8
006703310  mov      x0, x19
006703314  mov      x1, xzr
006703318  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00670331C  adrp     x21, #0x959a000
006703320  ldrb     w8, [x21, #0x970]
006703324  mov      w20, w0
006703328  cbnz     w8, #0x6703340
00670332C  adrp     x0, #0x8f17000
006703330  ldr      x0, [x0, #0x868]
006703334  bl       #0x382bd14 ; 
006703338  mov      w8, #1
00670333C  strb     w8, [x21, #0x970]
006703340  adrp     x8, #0x8f17000
006703344  ldr      x8, [x8, #0x868]
006703348  ldr      x2, [x8]
00670334C  ldrb     w8, [x2, #0x53]
006703350  tbnz     w8, #5, #0x670335c
006703354  str      w20, [x19, #0x58]
006703358  b        #0x670336c ; 
00670335C  ldr      x8, [x2, #0x60]
006703360  mov      x0, x19
006703364  mov      w1, w20
006703368  blr      x8
00670336C  mov      x0, x19
006703370  mov      x1, xzr
006703374  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006703378  adrp     x21, #0x959a000
00670337C  ldrb     w8, [x21, #0x971]
006703380  mov      w20, w0
006703384  cbnz     w8, #0x670339c
006703388  adrp     x0, #0x8f17000
00670338C  ldr      x0, [x0, #0x878]
006703390  bl       #0x382bd14 ; 
006703394  mov      w8, #1
006703398  strb     w8, [x21, #0x971]
00670339C  adrp     x8, #0x8f17000
0067033A0  ldr      x8, [x8, #0x878]
0067033A4  ldr      x2, [x8]
0067033A8  ldrb     w8, [x2, #0x53]
0067033AC  tbnz     w8, #5, #0x67033b8
0067033B0  str      w20, [x19, #0x5c]
0067033B4  b        #0x67033c8 ; 
0067033B8  ldr      x8, [x2, #0x60]
0067033BC  mov      x0, x19
0067033C0  mov      w1, w20
0067033C4  blr      x8
0067033C8  mov      x0, x19
0067033CC  mov      x1, xzr
0067033D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067033D4  adrp     x21, #0x959a000
0067033D8  ldrb     w8, [x21, #0x972]
0067033DC  mov      w20, w0
0067033E0  cbnz     w8, #0x67033f8
0067033E4  adrp     x0, #0x8f17000
0067033E8  ldr      x0, [x0, #0x888]
0067033EC  bl       #0x382bd14 ; 
0067033F0  mov      w8, #1
0067033F4  strb     w8, [x21, #0x972]
0067033F8  adrp     x8, #0x8f17000
0067033FC  ldr      x8, [x8, #0x888]
006703400  ldr      x2, [x8]
006703404  ldrb     w8, [x2, #0x53]
006703408  tbnz     w8, #5, #0x6703414
00670340C  str      w20, [x19, #0x60]
006703410  b        #0x6703424 ; 
006703414  ldr      x8, [x2, #0x60]
006703418  mov      x0, x19
00670341C  mov      w1, w20
006703420  blr      x8
006703424  mov      x0, x19
006703428  mov      x1, xzr
00670342C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006703430  adrp     x21, #0x959a000
006703434  ldrb     w8, [x21, #0x973]
006703438  mov      x20, x0
00670343C  cbnz     w8, #0x6703454
006703440  adrp     x0, #0x8f17000
006703444  ldr      x0, [x0, #0x898]
006703448  bl       #0x382bd14 ; 
00670344C  mov      w8, #1
006703450  strb     w8, [x21, #0x973]
006703454  adrp     x8, #0x8f17000
006703458  ldr      x8, [x8, #0x898]
00670345C  ldr      x2, [x8]
006703460  ldrb     w8, [x2, #0x53]
006703464  tbnz     w8, #5, #0x670347c
006703468  str      x20, [x19, #0x68]!
00670346C  mov      x0, x19
006703470  mov      x1, x20
006703474  bl       #0x382bcb8 ; 
006703478  b        #0x670348c ; 
00670347C  ldr      x8, [x2, #0x60]
006703480  mov      x0, x19
006703484  mov      x1, x20
006703488  blr      x8
00670348C  ldp      x20, x19, [sp, #0x10]
006703490  mov      w0, #1
006703494  ldp      x30, x21, [sp], #0x20
006703498  ret      

