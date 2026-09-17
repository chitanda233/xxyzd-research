; LocalModels.Bean.EventFishing_fishRod$$readImpl
; RVA 0x6A76510; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A76510  stp      x30, x21, [sp, #-0x20]!
006A76514  stp      x20, x19, [sp, #0x10]
006A76518  adrp     x20, #0x959d000
006A7651C  adrp     x21, #0x8f37000
006A76520  ldrb     w8, [x20, #0xe37]
006A76524  ldr      x21, [x21, #0xa48]
006A76528  mov      x19, x0
006A7652C  tbnz     w8, #0, #0x6a76544
006A76530  adrp     x0, #0x8f37000
006A76534  ldr      x0, [x0, #0xa48]
006A76538  bl       #0x382bd14 ; 
006A7653C  mov      w8, #1
006A76540  strb     w8, [x20, #0xe37]
006A76544  ldr      x1, [x21]
006A76548  ldrb     w8, [x1, #0x53]
006A7654C  tbnz     w8, #5, #0x6a7659c
006A76550  mov      x0, x19
006A76554  mov      x1, xzr
006A76558  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7655C  adrp     x21, #0x959e000
006A76560  ldrb     w8, [x21, #0x491]
006A76564  mov      w20, w0
006A76568  cbnz     w8, #0x6a76580
006A7656C  adrp     x0, #0x8f37000
006A76570  ldr      x0, [x0, #0x9e0]
006A76574  bl       #0x382bd14 ; 
006A76578  mov      w8, #1
006A7657C  strb     w8, [x21, #0x491]
006A76580  adrp     x8, #0x8f37000
006A76584  ldr      x8, [x8, #0x9e0]
006A76588  ldr      x2, [x8]
006A7658C  ldrb     w8, [x2, #0x53]
006A76590  tbnz     w8, #5, #0x6a765b0
006A76594  str      w20, [x19, #0x20]
006A76598  b        #0x6a765c0 ; 
006A7659C  ldr      x2, [x1, #0x60]
006A765A0  mov      x0, x19
006A765A4  ldp      x20, x19, [sp, #0x10]
006A765A8  ldp      x30, x21, [sp], #0x20
006A765AC  br       x2
006A765B0  ldr      x8, [x2, #0x60]
006A765B4  mov      x0, x19
006A765B8  mov      w1, w20
006A765BC  blr      x8
006A765C0  mov      x0, x19
006A765C4  mov      x1, xzr
006A765C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A765CC  adrp     x21, #0x959e000
006A765D0  ldrb     w8, [x21, #0x492]
006A765D4  mov      w20, w0
006A765D8  cbnz     w8, #0x6a765f0
006A765DC  adrp     x0, #0x8f37000
006A765E0  ldr      x0, [x0, #0x9f0]
006A765E4  bl       #0x382bd14 ; 
006A765E8  mov      w8, #1
006A765EC  strb     w8, [x21, #0x492]
006A765F0  adrp     x8, #0x8f37000
006A765F4  ldr      x8, [x8, #0x9f0]
006A765F8  ldr      x2, [x8]
006A765FC  ldrb     w8, [x2, #0x53]
006A76600  tbnz     w8, #5, #0x6a7660c
006A76604  str      w20, [x19, #0x24]
006A76608  b        #0x6a7661c ; 
006A7660C  ldr      x8, [x2, #0x60]
006A76610  mov      x0, x19
006A76614  mov      w1, w20
006A76618  blr      x8
006A7661C  mov      x0, x19
006A76620  mov      x1, xzr
006A76624  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A76628  adrp     x21, #0x959e000
006A7662C  ldrb     w8, [x21, #0x493]
006A76630  mov      w20, w0
006A76634  cbnz     w8, #0x6a7664c
006A76638  adrp     x0, #0x8f37000
006A7663C  ldr      x0, [x0, #0xa00]
006A76640  bl       #0x382bd14 ; 
006A76644  mov      w8, #1
006A76648  strb     w8, [x21, #0x493]
006A7664C  adrp     x8, #0x8f37000
006A76650  ldr      x8, [x8, #0xa00]
006A76654  ldr      x2, [x8]
006A76658  ldrb     w8, [x2, #0x53]
006A7665C  tbnz     w8, #5, #0x6a76668
006A76660  str      w20, [x19, #0x28]
006A76664  b        #0x6a76678 ; 
006A76668  ldr      x8, [x2, #0x60]
006A7666C  mov      x0, x19
006A76670  mov      w1, w20
006A76674  blr      x8
006A76678  mov      x0, x19
006A7667C  mov      x1, xzr
006A76680  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A76684  adrp     x21, #0x959e000
006A76688  ldrb     w8, [x21, #0x494]
006A7668C  mov      w20, w0
006A76690  cbnz     w8, #0x6a766a8
006A76694  adrp     x0, #0x8f37000
006A76698  ldr      x0, [x0, #0xa10]
006A7669C  bl       #0x382bd14 ; 
006A766A0  mov      w8, #1
006A766A4  strb     w8, [x21, #0x494]
006A766A8  adrp     x8, #0x8f37000
006A766AC  ldr      x8, [x8, #0xa10]
006A766B0  ldr      x2, [x8]
006A766B4  ldrb     w8, [x2, #0x53]
006A766B8  tbnz     w8, #5, #0x6a766c4
006A766BC  str      w20, [x19, #0x2c]
006A766C0  b        #0x6a766d4 ; 
006A766C4  ldr      x8, [x2, #0x60]
006A766C8  mov      x0, x19
006A766CC  mov      w1, w20
006A766D0  blr      x8
006A766D4  mov      x0, x19
006A766D8  mov      x1, xzr
006A766DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A766E0  adrp     x21, #0x959e000
006A766E4  ldrb     w8, [x21, #0x495]
006A766E8  mov      w20, w0
006A766EC  cbnz     w8, #0x6a76704
006A766F0  adrp     x0, #0x8f37000
006A766F4  ldr      x0, [x0, #0xa20]
006A766F8  bl       #0x382bd14 ; 
006A766FC  mov      w8, #1
006A76700  strb     w8, [x21, #0x495]
006A76704  adrp     x8, #0x8f37000
006A76708  ldr      x8, [x8, #0xa20]
006A7670C  ldr      x2, [x8]
006A76710  ldrb     w8, [x2, #0x53]
006A76714  tbnz     w8, #5, #0x6a76720
006A76718  str      w20, [x19, #0x30]
006A7671C  b        #0x6a76730 ; 
006A76720  ldr      x8, [x2, #0x60]
006A76724  mov      x0, x19
006A76728  mov      w1, w20
006A7672C  blr      x8
006A76730  mov      x0, x19
006A76734  mov      x1, xzr
006A76738  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7673C  adrp     x21, #0x959e000
006A76740  ldrb     w8, [x21, #0x496]
006A76744  mov      w20, w0
006A76748  cbnz     w8, #0x6a76760
006A7674C  adrp     x0, #0x8f37000
006A76750  ldr      x0, [x0, #0xa30]
006A76754  bl       #0x382bd14 ; 
006A76758  mov      w8, #1
006A7675C  strb     w8, [x21, #0x496]
006A76760  adrp     x8, #0x8f37000
006A76764  ldr      x8, [x8, #0xa30]
006A76768  ldr      x2, [x8]
006A7676C  ldrb     w8, [x2, #0x53]
006A76770  tbnz     w8, #5, #0x6a7677c
006A76774  str      w20, [x19, #0x34]
006A76778  b        #0x6a7678c ; 
006A7677C  ldr      x8, [x2, #0x60]
006A76780  mov      x0, x19
006A76784  mov      w1, w20
006A76788  blr      x8
006A7678C  mov      x0, x19
006A76790  mov      x1, xzr
006A76794  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A76798  adrp     x21, #0x959e000
006A7679C  ldrb     w8, [x21, #0x497]
006A767A0  mov      w20, w0
006A767A4  cbnz     w8, #0x6a767bc
006A767A8  adrp     x0, #0x8f37000
006A767AC  ldr      x0, [x0, #0xa40]
006A767B0  bl       #0x382bd14 ; 
006A767B4  mov      w8, #1
006A767B8  strb     w8, [x21, #0x497]
006A767BC  adrp     x8, #0x8f37000
006A767C0  ldr      x8, [x8, #0xa40]
006A767C4  ldr      x2, [x8]
006A767C8  ldrb     w8, [x2, #0x53]
006A767CC  tbnz     w8, #5, #0x6a767d8
006A767D0  str      w20, [x19, #0x38]
006A767D4  b        #0x6a767e8 ; 
006A767D8  ldr      x8, [x2, #0x60]
006A767DC  mov      x0, x19
006A767E0  mov      w1, w20
006A767E4  blr      x8
006A767E8  ldp      x20, x19, [sp, #0x10]
006A767EC  mov      w0, #1
006A767F0  ldp      x30, x21, [sp], #0x20
006A767F4  ret      

