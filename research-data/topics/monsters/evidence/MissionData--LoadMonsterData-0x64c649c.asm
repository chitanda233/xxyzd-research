; MissionData$$LoadMonsterData
; RVA 0x64C649C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C649C  str      x30, [sp, #-0x40]!
0064C64A0  stp      x24, x23, [sp, #0x10]
0064C64A4  stp      x22, x21, [sp, #0x20]
0064C64A8  stp      x20, x19, [sp, #0x30]
0064C64AC  adrp     x21, #0x9597000
0064C64B0  adrp     x22, #0x8ef9000
0064C64B4  ldrb     w8, [x21, #0xf9c]
0064C64B8  ldr      x22, [x22, #0xde0] ; GLOBAL Method$MissionData.LoadMonsterData()
0064C64BC  mov      x20, x1
0064C64C0  mov      x19, x0
0064C64C4  tbnz     w8, #0, #0x64c64dc
0064C64C8  adrp     x0, #0x8ef9000
0064C64CC  ldr      x0, [x0, #0xde0] ; GLOBAL Method$MissionData.LoadMonsterData()
0064C64D0  bl       #0x382bd14 ; 
0064C64D4  mov      w8, #1
0064C64D8  strb     w8, [x21, #0xf9c]
0064C64DC  ldr      x2, [x22]
0064C64E0  ldrb     w8, [x2, #0x53]
0064C64E4  tbnz     w8, #5, #0x64c6558
0064C64E8  ldr      x8, [x19, #0x140]
0064C64EC  cbz      x8, #0x64c6598
0064C64F0  ldr      x9, [x8, #0x18]
0064C64F4  cmp      w9, #1
0064C64F8  and      x9, x9, #0xffffffff
0064C64FC  b.lt     #0x64c654c
0064C6500  cbz      x9, #0x64c654c
0064C6504  mov      x21, xzr
0064C6508  mov      x22, xzr
0064C650C  lsl      x23, x9, #4
0064C6510  cmp      x22, w9, uxtw
0064C6514  b.hs     #0x64c659c
0064C6518  add      x24, x8, x21
0064C651C  ldr      x0, [x24, #0x20]
0064C6520  mov      x1, x20
0064C6524  mov      x2, xzr
0064C6528  bl       #0x79d1644 ; System.String$$op_Equality
0064C652C  tbnz     w0, #0, #0x64c6578
0064C6530  ldr      x8, [x19, #0x140]
0064C6534  cbz      x8, #0x64c6598
0064C6538  ldr      w9, [x8, #0x18]
0064C653C  add      x21, x21, #0x10
0064C6540  cmp      x23, x21
0064C6544  add      x22, x22, #1
0064C6548  b.ne     #0x64c6510
0064C654C  cbz      w9, #0x64c659c
0064C6550  ldr      x1, [x8, #0x28]
0064C6554  b        #0x64c657c ; 
0064C6558  ldr      x3, [x2, #0x60]
0064C655C  mov      x0, x19
0064C6560  mov      x1, x20
0064C6564  ldp      x20, x19, [sp, #0x30]
0064C6568  ldp      x22, x21, [sp, #0x20]
0064C656C  ldp      x24, x23, [sp, #0x10]
0064C6570  ldr      x30, [sp], #0x40
0064C6574  br       x3
0064C6578  ldr      x1, [x24, #0x28]
0064C657C  add      x0, x19, #0x158
0064C6580  str      x1, [x19, #0x158]
0064C6584  ldp      x20, x19, [sp, #0x30]
0064C6588  ldp      x22, x21, [sp, #0x20]
0064C658C  ldp      x24, x23, [sp, #0x10]
0064C6590  ldr      x30, [sp], #0x40
0064C6594  b        #0x382bcb8 ; 
0064C6598  bl       #0x382bfb8 ; 
0064C659C  bl       #0x382bfc0 ; 

