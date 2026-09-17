; LocalModels.Bean.Chapter_HardMissionReward$$readImpl
; RVA 0x68AA778; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068AA778  stp      x30, x21, [sp, #-0x20]!
0068AA77C  stp      x20, x19, [sp, #0x10]
0068AA780  adrp     x20, #0x959b000
0068AA784  adrp     x21, #0x8f26000
0068AA788  ldrb     w8, [x20, #0xfd3]
0068AA78C  ldr      x21, [x21, #0xab8]
0068AA790  mov      x19, x0
0068AA794  tbnz     w8, #0, #0x68aa7ac
0068AA798  adrp     x0, #0x8f26000
0068AA79C  ldr      x0, [x0, #0xab8]
0068AA7A0  bl       #0x382bd14 ; 
0068AA7A4  mov      w8, #1
0068AA7A8  strb     w8, [x20, #0xfd3]
0068AA7AC  ldr      x1, [x21]
0068AA7B0  ldrb     w8, [x1, #0x53]
0068AA7B4  tbnz     w8, #5, #0x68aa804
0068AA7B8  mov      x0, x19
0068AA7BC  mov      x1, xzr
0068AA7C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AA7C4  adrp     x21, #0x959c000
0068AA7C8  ldrb     w8, [x21, #0x58f]
0068AA7CC  mov      w20, w0
0068AA7D0  cbnz     w8, #0x68aa7e8
0068AA7D4  adrp     x0, #0x8f26000
0068AA7D8  ldr      x0, [x0, #0xa60]
0068AA7DC  bl       #0x382bd14 ; 
0068AA7E0  mov      w8, #1
0068AA7E4  strb     w8, [x21, #0x58f]
0068AA7E8  adrp     x8, #0x8f26000
0068AA7EC  ldr      x8, [x8, #0xa60]
0068AA7F0  ldr      x2, [x8]
0068AA7F4  ldrb     w8, [x2, #0x53]
0068AA7F8  tbnz     w8, #5, #0x68aa818
0068AA7FC  str      w20, [x19, #0x20]
0068AA800  b        #0x68aa828 ; 
0068AA804  ldr      x2, [x1, #0x60]
0068AA808  mov      x0, x19
0068AA80C  ldp      x20, x19, [sp, #0x10]
0068AA810  ldp      x30, x21, [sp], #0x20
0068AA814  br       x2
0068AA818  ldr      x8, [x2, #0x60]
0068AA81C  mov      x0, x19
0068AA820  mov      w1, w20
0068AA824  blr      x8
0068AA828  mov      x0, x19
0068AA82C  mov      x1, xzr
0068AA830  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AA834  adrp     x21, #0x959c000
0068AA838  ldrb     w8, [x21, #0x590]
0068AA83C  mov      w20, w0
0068AA840  cbnz     w8, #0x68aa858
0068AA844  adrp     x0, #0x8f26000
0068AA848  ldr      x0, [x0, #0xa70]
0068AA84C  bl       #0x382bd14 ; 
0068AA850  mov      w8, #1
0068AA854  strb     w8, [x21, #0x590]
0068AA858  adrp     x8, #0x8f26000
0068AA85C  ldr      x8, [x8, #0xa70]
0068AA860  ldr      x2, [x8]
0068AA864  ldrb     w8, [x2, #0x53]
0068AA868  tbnz     w8, #5, #0x68aa874
0068AA86C  str      w20, [x19, #0x24]
0068AA870  b        #0x68aa884 ; 
0068AA874  ldr      x8, [x2, #0x60]
0068AA878  mov      x0, x19
0068AA87C  mov      w1, w20
0068AA880  blr      x8
0068AA884  mov      x0, x19
0068AA888  mov      x1, xzr
0068AA88C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AA890  adrp     x21, #0x959c000
0068AA894  ldrb     w8, [x21, #0x591]
0068AA898  mov      w20, w0
0068AA89C  cbnz     w8, #0x68aa8b4
0068AA8A0  adrp     x0, #0x8f26000
0068AA8A4  ldr      x0, [x0, #0xa80]
0068AA8A8  bl       #0x382bd14 ; 
0068AA8AC  mov      w8, #1
0068AA8B0  strb     w8, [x21, #0x591]
0068AA8B4  adrp     x8, #0x8f26000
0068AA8B8  ldr      x8, [x8, #0xa80]
0068AA8BC  ldr      x2, [x8]
0068AA8C0  ldrb     w8, [x2, #0x53]
0068AA8C4  tbnz     w8, #5, #0x68aa8d0
0068AA8C8  str      w20, [x19, #0x28]
0068AA8CC  b        #0x68aa8e0 ; 
0068AA8D0  ldr      x8, [x2, #0x60]
0068AA8D4  mov      x0, x19
0068AA8D8  mov      w1, w20
0068AA8DC  blr      x8
0068AA8E0  mov      x0, x19
0068AA8E4  mov      x1, xzr
0068AA8E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AA8EC  adrp     x21, #0x959c000
0068AA8F0  ldrb     w8, [x21, #0x592]
0068AA8F4  mov      w20, w0
0068AA8F8  cbnz     w8, #0x68aa910
0068AA8FC  adrp     x0, #0x8f26000
0068AA900  ldr      x0, [x0, #0xa90]
0068AA904  bl       #0x382bd14 ; 
0068AA908  mov      w8, #1
0068AA90C  strb     w8, [x21, #0x592]
0068AA910  adrp     x8, #0x8f26000
0068AA914  ldr      x8, [x8, #0xa90]
0068AA918  ldr      x2, [x8]
0068AA91C  ldrb     w8, [x2, #0x53]
0068AA920  tbnz     w8, #5, #0x68aa92c
0068AA924  str      w20, [x19, #0x2c]
0068AA928  b        #0x68aa93c ; 
0068AA92C  ldr      x8, [x2, #0x60]
0068AA930  mov      x0, x19
0068AA934  mov      w1, w20
0068AA938  blr      x8
0068AA93C  mov      x0, x19
0068AA940  mov      x1, xzr
0068AA944  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AA948  adrp     x21, #0x959c000
0068AA94C  ldrb     w8, [x21, #0x593]
0068AA950  mov      w20, w0
0068AA954  cbnz     w8, #0x68aa96c
0068AA958  adrp     x0, #0x8f26000
0068AA95C  ldr      x0, [x0, #0xaa0]
0068AA960  bl       #0x382bd14 ; 
0068AA964  mov      w8, #1
0068AA968  strb     w8, [x21, #0x593]
0068AA96C  adrp     x8, #0x8f26000
0068AA970  ldr      x8, [x8, #0xaa0]
0068AA974  ldr      x2, [x8]
0068AA978  ldrb     w8, [x2, #0x53]
0068AA97C  tbnz     w8, #5, #0x68aa988
0068AA980  str      w20, [x19, #0x30]
0068AA984  b        #0x68aa998 ; 
0068AA988  ldr      x8, [x2, #0x60]
0068AA98C  mov      x0, x19
0068AA990  mov      w1, w20
0068AA994  blr      x8
0068AA998  mov      x0, x19
0068AA99C  mov      x1, xzr
0068AA9A0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068AA9A4  adrp     x21, #0x959c000
0068AA9A8  ldrb     w8, [x21, #0x594]
0068AA9AC  mov      x20, x0
0068AA9B0  cbnz     w8, #0x68aa9c8
0068AA9B4  adrp     x0, #0x8f26000
0068AA9B8  ldr      x0, [x0, #0xab0]
0068AA9BC  bl       #0x382bd14 ; 
0068AA9C0  mov      w8, #1
0068AA9C4  strb     w8, [x21, #0x594]
0068AA9C8  adrp     x8, #0x8f26000
0068AA9CC  ldr      x8, [x8, #0xab0]
0068AA9D0  ldr      x2, [x8]
0068AA9D4  ldrb     w8, [x2, #0x53]
0068AA9D8  tbnz     w8, #5, #0x68aa9f0
0068AA9DC  str      x20, [x19, #0x38]!
0068AA9E0  mov      x0, x19
0068AA9E4  mov      x1, x20
0068AA9E8  bl       #0x382bcb8 ; 
0068AA9EC  b        #0x68aaa00 ; 
0068AA9F0  ldr      x8, [x2, #0x60]
0068AA9F4  mov      x0, x19
0068AA9F8  mov      x1, x20
0068AA9FC  blr      x8
0068AAA00  ldp      x20, x19, [sp, #0x10]
0068AAA04  mov      w0, #1
0068AAA08  ldp      x30, x21, [sp], #0x20
0068AAA0C  ret      

