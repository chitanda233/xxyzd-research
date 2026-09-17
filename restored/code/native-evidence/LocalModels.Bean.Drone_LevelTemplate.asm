; LocalModels.Bean.Drone_LevelTemplate$$readImpl
; RVA 0x6A5F76C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5F76C  stp      x30, x21, [sp, #-0x20]!
006A5F770  stp      x20, x19, [sp, #0x10]
006A5F774  adrp     x20, #0x959d000
006A5F778  adrp     x21, #0x8f36000
006A5F77C  ldrb     w8, [x20, #0xbdf]
006A5F780  ldr      x21, [x21, #0x938]
006A5F784  mov      x19, x0
006A5F788  tbnz     w8, #0, #0x6a5f7a0
006A5F78C  adrp     x0, #0x8f36000
006A5F790  ldr      x0, [x0, #0x938]
006A5F794  bl       #0x382bd14 ; 
006A5F798  mov      w8, #1
006A5F79C  strb     w8, [x20, #0xbdf]
006A5F7A0  ldr      x1, [x21]
006A5F7A4  ldrb     w8, [x1, #0x53]
006A5F7A8  tbnz     w8, #5, #0x6a5f7f8
006A5F7AC  mov      x0, x19
006A5F7B0  mov      x1, xzr
006A5F7B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5F7B8  adrp     x21, #0x959e000
006A5F7BC  ldrb     w8, [x21, #0x390]
006A5F7C0  mov      w20, w0
006A5F7C4  cbnz     w8, #0x6a5f7dc
006A5F7C8  adrp     x0, #0x8f36000
006A5F7CC  ldr      x0, [x0, #0x900]
006A5F7D0  bl       #0x382bd14 ; 
006A5F7D4  mov      w8, #1
006A5F7D8  strb     w8, [x21, #0x390]
006A5F7DC  adrp     x8, #0x8f36000
006A5F7E0  ldr      x8, [x8, #0x900]
006A5F7E4  ldr      x2, [x8]
006A5F7E8  ldrb     w8, [x2, #0x53]
006A5F7EC  tbnz     w8, #5, #0x6a5f80c
006A5F7F0  str      w20, [x19, #0x20]
006A5F7F4  b        #0x6a5f81c ; 
006A5F7F8  ldr      x2, [x1, #0x60]
006A5F7FC  mov      x0, x19
006A5F800  ldp      x20, x19, [sp, #0x10]
006A5F804  ldp      x30, x21, [sp], #0x20
006A5F808  br       x2
006A5F80C  ldr      x8, [x2, #0x60]
006A5F810  mov      x0, x19
006A5F814  mov      w1, w20
006A5F818  blr      x8
006A5F81C  mov      x0, x19
006A5F820  mov      x1, xzr
006A5F824  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A5F828  adrp     x21, #0x959e000
006A5F82C  ldrb     w8, [x21, #0x391]
006A5F830  mov      x20, x0
006A5F834  cbnz     w8, #0x6a5f84c
006A5F838  adrp     x0, #0x8f36000
006A5F83C  ldr      x0, [x0, #0x910]
006A5F840  bl       #0x382bd14 ; 
006A5F844  mov      w8, #1
006A5F848  strb     w8, [x21, #0x391]
006A5F84C  adrp     x8, #0x8f36000
006A5F850  ldr      x8, [x8, #0x910]
006A5F854  ldr      x2, [x8]
006A5F858  ldrb     w8, [x2, #0x53]
006A5F85C  tbnz     w8, #5, #0x6a5f874
006A5F860  mov      x0, x19
006A5F864  str      x20, [x0, #0x28]!
006A5F868  mov      x1, x20
006A5F86C  bl       #0x382bcb8 ; 
006A5F870  b        #0x6a5f884 ; 
006A5F874  ldr      x8, [x2, #0x60]
006A5F878  mov      x0, x19
006A5F87C  mov      x1, x20
006A5F880  blr      x8
006A5F884  mov      x0, x19
006A5F888  mov      x1, xzr
006A5F88C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5F890  adrp     x21, #0x959e000
006A5F894  ldrb     w8, [x21, #0x392]
006A5F898  mov      x20, x0
006A5F89C  cbnz     w8, #0x6a5f8b4
006A5F8A0  adrp     x0, #0x8f36000
006A5F8A4  ldr      x0, [x0, #0x918]
006A5F8A8  bl       #0x382bd14 ; 
006A5F8AC  mov      w8, #1
006A5F8B0  strb     w8, [x21, #0x392]
006A5F8B4  adrp     x8, #0x8f36000
006A5F8B8  ldr      x8, [x8, #0x918]
006A5F8BC  ldr      x2, [x8]
006A5F8C0  ldrb     w8, [x2, #0x53]
006A5F8C4  tbnz     w8, #5, #0x6a5f8dc
006A5F8C8  mov      x0, x19
006A5F8CC  str      x20, [x0, #0x30]!
006A5F8D0  mov      x1, x20
006A5F8D4  bl       #0x382bcb8 ; 
006A5F8D8  b        #0x6a5f8ec ; 
006A5F8DC  ldr      x8, [x2, #0x60]
006A5F8E0  mov      x0, x19
006A5F8E4  mov      x1, x20
006A5F8E8  blr      x8
006A5F8EC  mov      x0, x19
006A5F8F0  mov      x1, xzr
006A5F8F4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5F8F8  adrp     x21, #0x959e000
006A5F8FC  ldrb     w8, [x21, #0x393]
006A5F900  mov      x20, x0
006A5F904  cbnz     w8, #0x6a5f91c
006A5F908  adrp     x0, #0x8f36000
006A5F90C  ldr      x0, [x0, #0x920]
006A5F910  bl       #0x382bd14 ; 
006A5F914  mov      w8, #1
006A5F918  strb     w8, [x21, #0x393]
006A5F91C  adrp     x8, #0x8f36000
006A5F920  ldr      x8, [x8, #0x920]
006A5F924  ldr      x2, [x8]
006A5F928  ldrb     w8, [x2, #0x53]
006A5F92C  tbnz     w8, #5, #0x6a5f944
006A5F930  mov      x0, x19
006A5F934  str      x20, [x0, #0x38]!
006A5F938  mov      x1, x20
006A5F93C  bl       #0x382bcb8 ; 
006A5F940  b        #0x6a5f954 ; 
006A5F944  ldr      x8, [x2, #0x60]
006A5F948  mov      x0, x19
006A5F94C  mov      x1, x20
006A5F950  blr      x8
006A5F954  mov      x0, x19
006A5F958  mov      x1, xzr
006A5F95C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5F960  adrp     x21, #0x959e000
006A5F964  ldrb     w8, [x21, #0x394]
006A5F968  mov      x20, x0
006A5F96C  cbnz     w8, #0x6a5f984
006A5F970  adrp     x0, #0x8f36000
006A5F974  ldr      x0, [x0, #0x928]
006A5F978  bl       #0x382bd14 ; 
006A5F97C  mov      w8, #1
006A5F980  strb     w8, [x21, #0x394]
006A5F984  adrp     x8, #0x8f36000
006A5F988  ldr      x8, [x8, #0x928]
006A5F98C  ldr      x2, [x8]
006A5F990  ldrb     w8, [x2, #0x53]
006A5F994  tbnz     w8, #5, #0x6a5f9ac
006A5F998  mov      x0, x19
006A5F99C  str      x20, [x0, #0x40]!
006A5F9A0  mov      x1, x20
006A5F9A4  bl       #0x382bcb8 ; 
006A5F9A8  b        #0x6a5f9bc ; 
006A5F9AC  ldr      x8, [x2, #0x60]
006A5F9B0  mov      x0, x19
006A5F9B4  mov      x1, x20
006A5F9B8  blr      x8
006A5F9BC  mov      x0, x19
006A5F9C0  mov      x1, xzr
006A5F9C4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5F9C8  adrp     x21, #0x959e000
006A5F9CC  ldrb     w8, [x21, #0x395]
006A5F9D0  mov      x20, x0
006A5F9D4  cbnz     w8, #0x6a5f9ec
006A5F9D8  adrp     x0, #0x8f36000
006A5F9DC  ldr      x0, [x0, #0x930]
006A5F9E0  bl       #0x382bd14 ; 
006A5F9E4  mov      w8, #1
006A5F9E8  strb     w8, [x21, #0x395]
006A5F9EC  adrp     x8, #0x8f36000
006A5F9F0  ldr      x8, [x8, #0x930]
006A5F9F4  ldr      x2, [x8]
006A5F9F8  ldrb     w8, [x2, #0x53]
006A5F9FC  tbnz     w8, #5, #0x6a5fa14
006A5FA00  str      x20, [x19, #0x48]!
006A5FA04  mov      x0, x19
006A5FA08  mov      x1, x20
006A5FA0C  bl       #0x382bcb8 ; 
006A5FA10  b        #0x6a5fa24 ; 
006A5FA14  ldr      x8, [x2, #0x60]
006A5FA18  mov      x0, x19
006A5FA1C  mov      x1, x20
006A5FA20  blr      x8
006A5FA24  ldp      x20, x19, [sp, #0x10]
006A5FA28  mov      w0, #1
006A5FA2C  ldp      x30, x21, [sp], #0x20
006A5FA30  ret      

