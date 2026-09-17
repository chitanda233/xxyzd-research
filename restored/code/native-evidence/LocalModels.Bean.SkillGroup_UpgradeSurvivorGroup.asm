; LocalModels.Bean.SkillGroup_UpgradeSurvivorGroup$$readImpl
; RVA 0x6AFE6C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFE6C8  stp      x30, x21, [sp, #-0x20]!
006AFE6CC  stp      x20, x19, [sp, #0x10]
006AFE6D0  adrp     x20, #0x959f000
006AFE6D4  adrp     x21, #0x8f3e000
006AFE6D8  ldrb     w8, [x20, #0x368]
006AFE6DC  ldr      x21, [x21, #0xa8]
006AFE6E0  mov      x19, x0
006AFE6E4  tbnz     w8, #0, #0x6afe6fc
006AFE6E8  adrp     x0, #0x8f3e000
006AFE6EC  ldr      x0, [x0, #0xa8]
006AFE6F0  bl       #0x382bd14 ; 
006AFE6F4  mov      w8, #1
006AFE6F8  strb     w8, [x20, #0x368]
006AFE6FC  ldr      x1, [x21]
006AFE700  ldrb     w8, [x1, #0x53]
006AFE704  tbnz     w8, #5, #0x6afe754
006AFE708  mov      x0, x19
006AFE70C  mov      x1, xzr
006AFE710  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE714  adrp     x21, #0x959f000
006AFE718  ldrb     w8, [x21, #0x8ca]
006AFE71C  mov      w20, w0
006AFE720  cbnz     w8, #0x6afe738
006AFE724  adrp     x0, #0x8f3d000
006AFE728  ldr      x0, [x0, #0xfd8]
006AFE72C  bl       #0x382bd14 ; 
006AFE730  mov      w8, #1
006AFE734  strb     w8, [x21, #0x8ca]
006AFE738  adrp     x8, #0x8f3d000
006AFE73C  ldr      x8, [x8, #0xfd8]
006AFE740  ldr      x2, [x8]
006AFE744  ldrb     w8, [x2, #0x53]
006AFE748  tbnz     w8, #5, #0x6afe768
006AFE74C  str      w20, [x19, #0x20]
006AFE750  b        #0x6afe778 ; 
006AFE754  ldr      x2, [x1, #0x60]
006AFE758  mov      x0, x19
006AFE75C  ldp      x20, x19, [sp, #0x10]
006AFE760  ldp      x30, x21, [sp], #0x20
006AFE764  br       x2
006AFE768  ldr      x8, [x2, #0x60]
006AFE76C  mov      x0, x19
006AFE770  mov      w1, w20
006AFE774  blr      x8
006AFE778  mov      x0, x19
006AFE77C  mov      x1, xzr
006AFE780  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE784  adrp     x21, #0x959f000
006AFE788  ldrb     w8, [x21, #0x8cb]
006AFE78C  mov      w20, w0
006AFE790  cbnz     w8, #0x6afe7a8
006AFE794  adrp     x0, #0x8f3d000
006AFE798  ldr      x0, [x0, #0xfe0]
006AFE79C  bl       #0x382bd14 ; 
006AFE7A0  mov      w8, #1
006AFE7A4  strb     w8, [x21, #0x8cb]
006AFE7A8  adrp     x8, #0x8f3d000
006AFE7AC  ldr      x8, [x8, #0xfe0]
006AFE7B0  ldr      x2, [x8]
006AFE7B4  ldrb     w8, [x2, #0x53]
006AFE7B8  tbnz     w8, #5, #0x6afe7c4
006AFE7BC  str      w20, [x19, #0x24]
006AFE7C0  b        #0x6afe7d4 ; 
006AFE7C4  ldr      x8, [x2, #0x60]
006AFE7C8  mov      x0, x19
006AFE7CC  mov      w1, w20
006AFE7D0  blr      x8
006AFE7D4  mov      x0, x19
006AFE7D8  mov      x1, xzr
006AFE7DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE7E0  adrp     x21, #0x959f000
006AFE7E4  ldrb     w8, [x21, #0x8cc]
006AFE7E8  mov      w20, w0
006AFE7EC  cbnz     w8, #0x6afe804
006AFE7F0  adrp     x0, #0x8f3d000
006AFE7F4  ldr      x0, [x0, #0xff0]
006AFE7F8  bl       #0x382bd14 ; 
006AFE7FC  mov      w8, #1
006AFE800  strb     w8, [x21, #0x8cc]
006AFE804  adrp     x8, #0x8f3d000
006AFE808  ldr      x8, [x8, #0xff0]
006AFE80C  ldr      x2, [x8]
006AFE810  ldrb     w8, [x2, #0x53]
006AFE814  tbnz     w8, #5, #0x6afe820
006AFE818  str      w20, [x19, #0x28]
006AFE81C  b        #0x6afe830 ; 
006AFE820  ldr      x8, [x2, #0x60]
006AFE824  mov      x0, x19
006AFE828  mov      w1, w20
006AFE82C  blr      x8
006AFE830  mov      x0, x19
006AFE834  mov      x1, xzr
006AFE838  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE83C  adrp     x21, #0x959f000
006AFE840  ldrb     w8, [x21, #0x8cd]
006AFE844  mov      w20, w0
006AFE848  cbnz     w8, #0x6afe860
006AFE84C  adrp     x0, #0x8f3e000
006AFE850  ldr      x0, [x0]
006AFE854  bl       #0x382bd14 ; 
006AFE858  mov      w8, #1
006AFE85C  strb     w8, [x21, #0x8cd]
006AFE860  adrp     x8, #0x8f3e000
006AFE864  ldr      x8, [x8]
006AFE868  ldr      x2, [x8]
006AFE86C  ldrb     w8, [x2, #0x53]
006AFE870  tbnz     w8, #5, #0x6afe87c
006AFE874  str      w20, [x19, #0x2c]
006AFE878  b        #0x6afe88c ; 
006AFE87C  ldr      x8, [x2, #0x60]
006AFE880  mov      x0, x19
006AFE884  mov      w1, w20
006AFE888  blr      x8
006AFE88C  mov      x0, x19
006AFE890  mov      x1, xzr
006AFE894  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE898  adrp     x21, #0x959f000
006AFE89C  ldrb     w8, [x21, #0x8ce]
006AFE8A0  mov      w20, w0
006AFE8A4  cbnz     w8, #0x6afe8bc
006AFE8A8  adrp     x0, #0x8f3e000
006AFE8AC  ldr      x0, [x0, #0x10]
006AFE8B0  bl       #0x382bd14 ; 
006AFE8B4  mov      w8, #1
006AFE8B8  strb     w8, [x21, #0x8ce]
006AFE8BC  adrp     x8, #0x8f3e000
006AFE8C0  ldr      x8, [x8, #0x10]
006AFE8C4  ldr      x2, [x8]
006AFE8C8  ldrb     w8, [x2, #0x53]
006AFE8CC  tbnz     w8, #5, #0x6afe8d8
006AFE8D0  str      w20, [x19, #0x30]
006AFE8D4  b        #0x6afe8e8 ; 
006AFE8D8  ldr      x8, [x2, #0x60]
006AFE8DC  mov      x0, x19
006AFE8E0  mov      w1, w20
006AFE8E4  blr      x8
006AFE8E8  mov      x0, x19
006AFE8EC  mov      x1, xzr
006AFE8F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE8F4  adrp     x21, #0x959f000
006AFE8F8  ldrb     w8, [x21, #0x8cf]
006AFE8FC  mov      w20, w0
006AFE900  cbnz     w8, #0x6afe918
006AFE904  adrp     x0, #0x8f3e000
006AFE908  ldr      x0, [x0, #0x20]
006AFE90C  bl       #0x382bd14 ; 
006AFE910  mov      w8, #1
006AFE914  strb     w8, [x21, #0x8cf]
006AFE918  adrp     x8, #0x8f3e000
006AFE91C  ldr      x8, [x8, #0x20]
006AFE920  ldr      x2, [x8]
006AFE924  ldrb     w8, [x2, #0x53]
006AFE928  tbnz     w8, #5, #0x6afe934
006AFE92C  str      w20, [x19, #0x34]
006AFE930  b        #0x6afe944 ; 
006AFE934  ldr      x8, [x2, #0x60]
006AFE938  mov      x0, x19
006AFE93C  mov      w1, w20
006AFE940  blr      x8
006AFE944  mov      x0, x19
006AFE948  mov      x1, xzr
006AFE94C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE950  adrp     x21, #0x959f000
006AFE954  ldrb     w8, [x21, #0x8d0]
006AFE958  mov      w20, w0
006AFE95C  cbnz     w8, #0x6afe974
006AFE960  adrp     x0, #0x8f3e000
006AFE964  ldr      x0, [x0, #0x30]
006AFE968  bl       #0x382bd14 ; 
006AFE96C  mov      w8, #1
006AFE970  strb     w8, [x21, #0x8d0]
006AFE974  adrp     x8, #0x8f3e000
006AFE978  ldr      x8, [x8, #0x30]
006AFE97C  ldr      x2, [x8]
006AFE980  ldrb     w8, [x2, #0x53]
006AFE984  tbnz     w8, #5, #0x6afe990
006AFE988  str      w20, [x19, #0x38]
006AFE98C  b        #0x6afe9a0 ; 
006AFE990  ldr      x8, [x2, #0x60]
006AFE994  mov      x0, x19
006AFE998  mov      w1, w20
006AFE99C  blr      x8
006AFE9A0  mov      x0, x19
006AFE9A4  mov      x1, xzr
006AFE9A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFE9AC  adrp     x21, #0x959f000
006AFE9B0  ldrb     w8, [x21, #0x8d1]
006AFE9B4  mov      w20, w0
006AFE9B8  cbnz     w8, #0x6afe9d0
006AFE9BC  adrp     x0, #0x8f3e000
006AFE9C0  ldr      x0, [x0, #0x40]
006AFE9C4  bl       #0x382bd14 ; 
006AFE9C8  mov      w8, #1
006AFE9CC  strb     w8, [x21, #0x8d1]
006AFE9D0  adrp     x8, #0x8f3e000
006AFE9D4  ldr      x8, [x8, #0x40]
006AFE9D8  ldr      x2, [x8]
006AFE9DC  ldrb     w8, [x2, #0x53]
006AFE9E0  tbnz     w8, #5, #0x6afe9ec
006AFE9E4  str      w20, [x19, #0x3c]
006AFE9E8  b        #0x6afe9fc ; 
006AFE9EC  ldr      x8, [x2, #0x60]
006AFE9F0  mov      x0, x19
006AFE9F4  mov      w1, w20
006AFE9F8  blr      x8
006AFE9FC  mov      x0, x19
006AFEA00  mov      x1, xzr
006AFEA04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFEA08  adrp     x21, #0x959f000
006AFEA0C  ldrb     w8, [x21, #0x8d2]
006AFEA10  mov      w20, w0
006AFEA14  cbnz     w8, #0x6afea2c
006AFEA18  adrp     x0, #0x8f3e000
006AFEA1C  ldr      x0, [x0, #0x50]
006AFEA20  bl       #0x382bd14 ; 
006AFEA24  mov      w8, #1
006AFEA28  strb     w8, [x21, #0x8d2]
006AFEA2C  adrp     x8, #0x8f3e000
006AFEA30  ldr      x8, [x8, #0x50]
006AFEA34  ldr      x2, [x8]
006AFEA38  ldrb     w8, [x2, #0x53]
006AFEA3C  tbnz     w8, #5, #0x6afea48
006AFEA40  str      w20, [x19, #0x40]
006AFEA44  b        #0x6afea58 ; 
006AFEA48  ldr      x8, [x2, #0x60]
006AFEA4C  mov      x0, x19
006AFEA50  mov      w1, w20
006AFEA54  blr      x8
006AFEA58  mov      x0, x19
006AFEA5C  mov      x1, xzr
006AFEA60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFEA64  adrp     x21, #0x959f000
006AFEA68  ldrb     w8, [x21, #0x8d3]
006AFEA6C  mov      w20, w0
006AFEA70  cbnz     w8, #0x6afea88
006AFEA74  adrp     x0, #0x8f3e000
006AFEA78  ldr      x0, [x0, #0x60]
006AFEA7C  bl       #0x382bd14 ; 
006AFEA80  mov      w8, #1
006AFEA84  strb     w8, [x21, #0x8d3]
006AFEA88  adrp     x8, #0x8f3e000
006AFEA8C  ldr      x8, [x8, #0x60]
006AFEA90  ldr      x2, [x8]
006AFEA94  ldrb     w8, [x2, #0x53]
006AFEA98  tbnz     w8, #5, #0x6afeaa4
006AFEA9C  str      w20, [x19, #0x44]
006AFEAA0  b        #0x6afeab4 ; 
006AFEAA4  ldr      x8, [x2, #0x60]
006AFEAA8  mov      x0, x19
006AFEAAC  mov      w1, w20
006AFEAB0  blr      x8
006AFEAB4  mov      x0, x19
006AFEAB8  mov      x1, xzr
006AFEABC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFEAC0  adrp     x21, #0x959f000
006AFEAC4  ldrb     w8, [x21, #0x8d4]
006AFEAC8  mov      w20, w0
006AFEACC  cbnz     w8, #0x6afeae4
006AFEAD0  adrp     x0, #0x8f3e000
006AFEAD4  ldr      x0, [x0, #0x70]
006AFEAD8  bl       #0x382bd14 ; 
006AFEADC  mov      w8, #1
006AFEAE0  strb     w8, [x21, #0x8d4]
006AFEAE4  adrp     x8, #0x8f3e000
006AFEAE8  ldr      x8, [x8, #0x70]
006AFEAEC  ldr      x2, [x8]
006AFEAF0  ldrb     w8, [x2, #0x53]
006AFEAF4  tbnz     w8, #5, #0x6afeb00
006AFEAF8  str      w20, [x19, #0x48]
006AFEAFC  b        #0x6afeb10 ; 
006AFEB00  ldr      x8, [x2, #0x60]
006AFEB04  mov      x0, x19
006AFEB08  mov      w1, w20
006AFEB0C  blr      x8
006AFEB10  mov      x0, x19
006AFEB14  mov      x1, xzr
006AFEB18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFEB1C  adrp     x21, #0x959f000
006AFEB20  ldrb     w8, [x21, #0x8d5]
006AFEB24  mov      w20, w0
006AFEB28  cbnz     w8, #0x6afeb40
006AFEB2C  adrp     x0, #0x8f3e000
006AFEB30  ldr      x0, [x0, #0x80]
006AFEB34  bl       #0x382bd14 ; 
006AFEB38  mov      w8, #1
006AFEB3C  strb     w8, [x21, #0x8d5]
006AFEB40  adrp     x8, #0x8f3e000
006AFEB44  ldr      x8, [x8, #0x80]
006AFEB48  ldr      x2, [x8]
006AFEB4C  ldrb     w8, [x2, #0x53]
006AFEB50  tbnz     w8, #5, #0x6afeb5c
006AFEB54  str      w20, [x19, #0x4c]
006AFEB58  b        #0x6afeb6c ; 
006AFEB5C  ldr      x8, [x2, #0x60]
006AFEB60  mov      x0, x19
006AFEB64  mov      w1, w20
006AFEB68  blr      x8
006AFEB6C  mov      x0, x19
006AFEB70  mov      x1, xzr
006AFEB74  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFEB78  adrp     x21, #0x959f000
006AFEB7C  ldrb     w8, [x21, #0x8d6]
006AFEB80  mov      w20, w0
006AFEB84  cbnz     w8, #0x6afeb9c
006AFEB88  adrp     x0, #0x8f3e000
006AFEB8C  ldr      x0, [x0, #0x90]
006AFEB90  bl       #0x382bd14 ; 
006AFEB94  mov      w8, #1
006AFEB98  strb     w8, [x21, #0x8d6]
006AFEB9C  adrp     x8, #0x8f3e000
006AFEBA0  ldr      x8, [x8, #0x90]
006AFEBA4  ldr      x2, [x8]
006AFEBA8  ldrb     w8, [x2, #0x53]
006AFEBAC  tbnz     w8, #5, #0x6afebb8
006AFEBB0  str      w20, [x19, #0x50]
006AFEBB4  b        #0x6afebc8 ; 
006AFEBB8  ldr      x8, [x2, #0x60]
006AFEBBC  mov      x0, x19
006AFEBC0  mov      w1, w20
006AFEBC4  blr      x8
006AFEBC8  mov      x0, x19
006AFEBCC  mov      x1, xzr
006AFEBD0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFEBD4  adrp     x21, #0x959f000
006AFEBD8  ldrb     w8, [x21, #0x8d7]
006AFEBDC  mov      w20, w0
006AFEBE0  cbnz     w8, #0x6afebf8
006AFEBE4  adrp     x0, #0x8f3e000
006AFEBE8  ldr      x0, [x0, #0xa0]
006AFEBEC  bl       #0x382bd14 ; 
006AFEBF0  mov      w8, #1
006AFEBF4  strb     w8, [x21, #0x8d7]
006AFEBF8  adrp     x8, #0x8f3e000
006AFEBFC  ldr      x8, [x8, #0xa0]
006AFEC00  ldr      x2, [x8]
006AFEC04  ldrb     w8, [x2, #0x53]
006AFEC08  tbnz     w8, #5, #0x6afec14
006AFEC0C  str      w20, [x19, #0x54]
006AFEC10  b        #0x6afec24 ; 
006AFEC14  ldr      x8, [x2, #0x60]
006AFEC18  mov      x0, x19
006AFEC1C  mov      w1, w20
006AFEC20  blr      x8
006AFEC24  ldp      x20, x19, [sp, #0x10]
006AFEC28  mov      w0, #1
006AFEC2C  ldp      x30, x21, [sp], #0x20
006AFEC30  ret      

