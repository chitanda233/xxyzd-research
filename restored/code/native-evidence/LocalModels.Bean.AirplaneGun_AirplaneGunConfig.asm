; LocalModels.Bean.AirplaneGun_AirplaneGunConfig$$readImpl
; RVA 0x66FE7D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066FE7D4  stp      x30, x21, [sp, #-0x20]!
0066FE7D8  stp      x20, x19, [sp, #0x10]
0066FE7DC  adrp     x20, #0x959a000
0066FE7E0  adrp     x21, #0x8f17000
0066FE7E4  ldrb     w8, [x20, #0x858]
0066FE7E8  ldr      x21, [x21, #0x500]
0066FE7EC  mov      x19, x0
0066FE7F0  tbnz     w8, #0, #0x66fe808
0066FE7F4  adrp     x0, #0x8f17000
0066FE7F8  ldr      x0, [x0, #0x500]
0066FE7FC  bl       #0x382bd14 ; 
0066FE800  mov      w8, #1
0066FE804  strb     w8, [x20, #0x858]
0066FE808  ldr      x1, [x21]
0066FE80C  ldrb     w8, [x1, #0x53]
0066FE810  tbnz     w8, #5, #0x66fe860
0066FE814  mov      x0, x19
0066FE818  mov      x1, xzr
0066FE81C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FE820  adrp     x21, #0x959a000
0066FE824  ldrb     w8, [x21, #0x93b]
0066FE828  mov      w20, w0
0066FE82C  cbnz     w8, #0x66fe844
0066FE830  adrp     x0, #0x8f17000
0066FE834  ldr      x0, [x0, #0x4a8]
0066FE838  bl       #0x382bd14 ; 
0066FE83C  mov      w8, #1
0066FE840  strb     w8, [x21, #0x93b]
0066FE844  adrp     x8, #0x8f17000
0066FE848  ldr      x8, [x8, #0x4a8]
0066FE84C  ldr      x2, [x8]
0066FE850  ldrb     w8, [x2, #0x53]
0066FE854  tbnz     w8, #5, #0x66fe874
0066FE858  str      w20, [x19, #0x20]
0066FE85C  b        #0x66fe884 ; 
0066FE860  ldr      x2, [x1, #0x60]
0066FE864  mov      x0, x19
0066FE868  ldp      x20, x19, [sp, #0x10]
0066FE86C  ldp      x30, x21, [sp], #0x20
0066FE870  br       x2
0066FE874  ldr      x8, [x2, #0x60]
0066FE878  mov      x0, x19
0066FE87C  mov      w1, w20
0066FE880  blr      x8
0066FE884  mov      x0, x19
0066FE888  mov      x1, xzr
0066FE88C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FE890  adrp     x21, #0x959a000
0066FE894  ldrb     w8, [x21, #0x93c]
0066FE898  mov      x20, x0
0066FE89C  cbnz     w8, #0x66fe8b4
0066FE8A0  adrp     x0, #0x8f17000
0066FE8A4  ldr      x0, [x0, #0x4b8]
0066FE8A8  bl       #0x382bd14 ; 
0066FE8AC  mov      w8, #1
0066FE8B0  strb     w8, [x21, #0x93c]
0066FE8B4  adrp     x8, #0x8f17000
0066FE8B8  ldr      x8, [x8, #0x4b8]
0066FE8BC  ldr      x2, [x8]
0066FE8C0  ldrb     w8, [x2, #0x53]
0066FE8C4  tbnz     w8, #5, #0x66fe8dc
0066FE8C8  mov      x0, x19
0066FE8CC  str      x20, [x0, #0x28]!
0066FE8D0  mov      x1, x20
0066FE8D4  bl       #0x382bcb8 ; 
0066FE8D8  b        #0x66fe8ec ; 
0066FE8DC  ldr      x8, [x2, #0x60]
0066FE8E0  mov      x0, x19
0066FE8E4  mov      x1, x20
0066FE8E8  blr      x8
0066FE8EC  mov      x0, x19
0066FE8F0  mov      x1, xzr
0066FE8F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FE8F8  adrp     x21, #0x959a000
0066FE8FC  ldrb     w8, [x21, #0x93d]
0066FE900  mov      x20, x0
0066FE904  cbnz     w8, #0x66fe91c
0066FE908  adrp     x0, #0x8f17000
0066FE90C  ldr      x0, [x0, #0x4c8]
0066FE910  bl       #0x382bd14 ; 
0066FE914  mov      w8, #1
0066FE918  strb     w8, [x21, #0x93d]
0066FE91C  adrp     x8, #0x8f17000
0066FE920  ldr      x8, [x8, #0x4c8]
0066FE924  ldr      x2, [x8]
0066FE928  ldrb     w8, [x2, #0x53]
0066FE92C  tbnz     w8, #5, #0x66fe944
0066FE930  mov      x0, x19
0066FE934  str      x20, [x0, #0x30]!
0066FE938  mov      x1, x20
0066FE93C  bl       #0x382bcb8 ; 
0066FE940  b        #0x66fe954 ; 
0066FE944  ldr      x8, [x2, #0x60]
0066FE948  mov      x0, x19
0066FE94C  mov      x1, x20
0066FE950  blr      x8
0066FE954  mov      x0, x19
0066FE958  mov      x1, xzr
0066FE95C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0066FE960  adrp     x21, #0x959a000
0066FE964  ldrb     w8, [x21, #0x93e]
0066FE968  mov      w20, w0
0066FE96C  cbnz     w8, #0x66fe984
0066FE970  adrp     x0, #0x8f17000
0066FE974  ldr      x0, [x0, #0x4d8]
0066FE978  bl       #0x382bd14 ; 
0066FE97C  mov      w8, #1
0066FE980  strb     w8, [x21, #0x93e]
0066FE984  adrp     x8, #0x8f17000
0066FE988  ldr      x8, [x8, #0x4d8]
0066FE98C  ldr      x2, [x8]
0066FE990  ldrb     w8, [x2, #0x53]
0066FE994  tbnz     w8, #5, #0x66fe9a0
0066FE998  str      w20, [x19, #0x38]
0066FE99C  b        #0x66fe9b0 ; 
0066FE9A0  ldr      x8, [x2, #0x60]
0066FE9A4  mov      x0, x19
0066FE9A8  mov      w1, w20
0066FE9AC  blr      x8
0066FE9B0  mov      x0, x19
0066FE9B4  mov      x1, xzr
0066FE9B8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0066FE9BC  adrp     x21, #0x959a000
0066FE9C0  ldrb     w8, [x21, #0x93f]
0066FE9C4  mov      x20, x0
0066FE9C8  cbnz     w8, #0x66fe9e0
0066FE9CC  adrp     x0, #0x8f17000
0066FE9D0  ldr      x0, [x0, #0x4e8]
0066FE9D4  bl       #0x382bd14 ; 
0066FE9D8  mov      w8, #1
0066FE9DC  strb     w8, [x21, #0x93f]
0066FE9E0  adrp     x8, #0x8f17000
0066FE9E4  ldr      x8, [x8, #0x4e8]
0066FE9E8  ldr      x2, [x8]
0066FE9EC  ldrb     w8, [x2, #0x53]
0066FE9F0  tbnz     w8, #5, #0x66fea08
0066FE9F4  mov      x0, x19
0066FE9F8  str      x20, [x0, #0x40]!
0066FE9FC  mov      x1, x20
0066FEA00  bl       #0x382bcb8 ; 
0066FEA04  b        #0x66fea18 ; 
0066FEA08  ldr      x8, [x2, #0x60]
0066FEA0C  mov      x0, x19
0066FEA10  mov      x1, x20
0066FEA14  blr      x8
0066FEA18  mov      x0, x19
0066FEA1C  mov      x1, xzr
0066FEA20  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0066FEA24  adrp     x21, #0x959a000
0066FEA28  ldrb     w8, [x21, #0x940]
0066FEA2C  mov      x20, x0
0066FEA30  cbnz     w8, #0x66fea48
0066FEA34  adrp     x0, #0x8f17000
0066FEA38  ldr      x0, [x0, #0x4f8]
0066FEA3C  bl       #0x382bd14 ; 
0066FEA40  mov      w8, #1
0066FEA44  strb     w8, [x21, #0x940]
0066FEA48  adrp     x8, #0x8f17000
0066FEA4C  ldr      x8, [x8, #0x4f8]
0066FEA50  ldr      x2, [x8]
0066FEA54  ldrb     w8, [x2, #0x53]
0066FEA58  tbnz     w8, #5, #0x66fea70
0066FEA5C  str      x20, [x19, #0x48]!
0066FEA60  mov      x0, x19
0066FEA64  mov      x1, x20
0066FEA68  bl       #0x382bcb8 ; 
0066FEA6C  b        #0x66fea80 ; 
0066FEA70  ldr      x8, [x2, #0x60]
0066FEA74  mov      x0, x19
0066FEA78  mov      x1, x20
0066FEA7C  blr      x8
0066FEA80  ldp      x20, x19, [sp, #0x10]
0066FEA84  mov      w0, #1
0066FEA88  ldp      x30, x21, [sp], #0x20
0066FEA8C  ret      

