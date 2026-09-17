; LocalModels.Bean.DrawBox_InventoryDrawCredits$$readImpl
; RVA 0x6A5ABE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5ABE8  stp      x30, x21, [sp, #-0x20]!
006A5ABEC  stp      x20, x19, [sp, #0x10]
006A5ABF0  adrp     x20, #0x959d000
006A5ABF4  adrp     x21, #0x8f36000
006A5ABF8  ldrb     w8, [x20, #0xb60]
006A5ABFC  ldr      x21, [x21, #0x5b0]
006A5AC00  mov      x19, x0
006A5AC04  tbnz     w8, #0, #0x6a5ac1c
006A5AC08  adrp     x0, #0x8f36000
006A5AC0C  ldr      x0, [x0, #0x5b0]
006A5AC10  bl       #0x382bd14 ; 
006A5AC14  mov      w8, #1
006A5AC18  strb     w8, [x20, #0xb60]
006A5AC1C  ldr      x1, [x21]
006A5AC20  ldrb     w8, [x1, #0x53]
006A5AC24  tbnz     w8, #5, #0x6a5ac74
006A5AC28  mov      x0, x19
006A5AC2C  mov      x1, xzr
006A5AC30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5AC34  adrp     x21, #0x959e000
006A5AC38  ldrb     w8, [x21, #0x35e]
006A5AC3C  mov      w20, w0
006A5AC40  cbnz     w8, #0x6a5ac58
006A5AC44  adrp     x0, #0x8f36000
006A5AC48  ldr      x0, [x0, #0x588]
006A5AC4C  bl       #0x382bd14 ; 
006A5AC50  mov      w8, #1
006A5AC54  strb     w8, [x21, #0x35e]
006A5AC58  adrp     x8, #0x8f36000
006A5AC5C  ldr      x8, [x8, #0x588]
006A5AC60  ldr      x2, [x8]
006A5AC64  ldrb     w8, [x2, #0x53]
006A5AC68  tbnz     w8, #5, #0x6a5ac88
006A5AC6C  str      w20, [x19, #0x20]
006A5AC70  b        #0x6a5ac98 ; 
006A5AC74  ldr      x2, [x1, #0x60]
006A5AC78  mov      x0, x19
006A5AC7C  ldp      x20, x19, [sp, #0x10]
006A5AC80  ldp      x30, x21, [sp], #0x20
006A5AC84  br       x2
006A5AC88  ldr      x8, [x2, #0x60]
006A5AC8C  mov      x0, x19
006A5AC90  mov      w1, w20
006A5AC94  blr      x8
006A5AC98  mov      x0, x19
006A5AC9C  mov      x1, xzr
006A5ACA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5ACA4  adrp     x21, #0x959e000
006A5ACA8  ldrb     w8, [x21, #0x35f]
006A5ACAC  mov      w20, w0
006A5ACB0  cbnz     w8, #0x6a5acc8
006A5ACB4  adrp     x0, #0x8f36000
006A5ACB8  ldr      x0, [x0, #0x598]
006A5ACBC  bl       #0x382bd14 ; 
006A5ACC0  mov      w8, #1
006A5ACC4  strb     w8, [x21, #0x35f]
006A5ACC8  adrp     x8, #0x8f36000
006A5ACCC  ldr      x8, [x8, #0x598]
006A5ACD0  ldr      x2, [x8]
006A5ACD4  ldrb     w8, [x2, #0x53]
006A5ACD8  tbnz     w8, #5, #0x6a5ace4
006A5ACDC  str      w20, [x19, #0x24]
006A5ACE0  b        #0x6a5acf4 ; 
006A5ACE4  ldr      x8, [x2, #0x60]
006A5ACE8  mov      x0, x19
006A5ACEC  mov      w1, w20
006A5ACF0  blr      x8
006A5ACF4  mov      x0, x19
006A5ACF8  mov      x1, xzr
006A5ACFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5AD00  adrp     x21, #0x959e000
006A5AD04  ldrb     w8, [x21, #0x360]
006A5AD08  mov      w20, w0
006A5AD0C  cbnz     w8, #0x6a5ad24
006A5AD10  adrp     x0, #0x8f36000
006A5AD14  ldr      x0, [x0, #0x5a8]
006A5AD18  bl       #0x382bd14 ; 
006A5AD1C  mov      w8, #1
006A5AD20  strb     w8, [x21, #0x360]
006A5AD24  adrp     x8, #0x8f36000
006A5AD28  ldr      x8, [x8, #0x5a8]
006A5AD2C  ldr      x2, [x8]
006A5AD30  ldrb     w8, [x2, #0x53]
006A5AD34  tbnz     w8, #5, #0x6a5ad40
006A5AD38  str      w20, [x19, #0x28]
006A5AD3C  b        #0x6a5ad50 ; 
006A5AD40  ldr      x8, [x2, #0x60]
006A5AD44  mov      x0, x19
006A5AD48  mov      w1, w20
006A5AD4C  blr      x8
006A5AD50  ldp      x20, x19, [sp, #0x10]
006A5AD54  mov      w0, #1
006A5AD58  ldp      x30, x21, [sp], #0x20
006A5AD5C  ret      

