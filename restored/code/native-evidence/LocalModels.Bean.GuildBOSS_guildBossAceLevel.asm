; LocalModels.Bean.GuildBOSS_guildBossAceLevel$$readImpl
; RVA 0x6A837B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A837B0  stp      x30, x21, [sp, #-0x20]!
006A837B4  stp      x20, x19, [sp, #0x10]
006A837B8  adrp     x20, #0x959d000
006A837BC  adrp     x21, #0x8f38000
006A837C0  ldrb     w8, [x20, #0xf95]
006A837C4  ldr      x21, [x21, #0x470]
006A837C8  mov      x19, x0
006A837CC  tbnz     w8, #0, #0x6a837e4
006A837D0  adrp     x0, #0x8f38000
006A837D4  ldr      x0, [x0, #0x470]
006A837D8  bl       #0x382bd14 ; 
006A837DC  mov      w8, #1
006A837E0  strb     w8, [x20, #0xf95]
006A837E4  ldr      x1, [x21]
006A837E8  ldrb     w8, [x1, #0x53]
006A837EC  tbnz     w8, #5, #0x6a8383c
006A837F0  mov      x0, x19
006A837F4  mov      x1, xzr
006A837F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A837FC  adrp     x21, #0x959e000
006A83800  ldrb     w8, [x21, #0x523]
006A83804  mov      w20, w0
006A83808  cbnz     w8, #0x6a83820
006A8380C  adrp     x0, #0x8f38000
006A83810  ldr      x0, [x0, #0x448]
006A83814  bl       #0x382bd14 ; 
006A83818  mov      w8, #1
006A8381C  strb     w8, [x21, #0x523]
006A83820  adrp     x8, #0x8f38000
006A83824  ldr      x8, [x8, #0x448]
006A83828  ldr      x2, [x8]
006A8382C  ldrb     w8, [x2, #0x53]
006A83830  tbnz     w8, #5, #0x6a83850
006A83834  str      w20, [x19, #0x20]
006A83838  b        #0x6a83860 ; 
006A8383C  ldr      x2, [x1, #0x60]
006A83840  mov      x0, x19
006A83844  ldp      x20, x19, [sp, #0x10]
006A83848  ldp      x30, x21, [sp], #0x20
006A8384C  br       x2
006A83850  ldr      x8, [x2, #0x60]
006A83854  mov      x0, x19
006A83858  mov      w1, w20
006A8385C  blr      x8
006A83860  mov      x0, x19
006A83864  mov      x1, xzr
006A83868  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A8386C  adrp     x21, #0x959e000
006A83870  ldrb     w8, [x21, #0x524]
006A83874  mov      x20, x0
006A83878  cbnz     w8, #0x6a83890
006A8387C  adrp     x0, #0x8f38000
006A83880  ldr      x0, [x0, #0x458]
006A83884  bl       #0x382bd14 ; 
006A83888  mov      w8, #1
006A8388C  strb     w8, [x21, #0x524]
006A83890  adrp     x8, #0x8f38000
006A83894  ldr      x8, [x8, #0x458]
006A83898  ldr      x2, [x8]
006A8389C  ldrb     w8, [x2, #0x53]
006A838A0  tbnz     w8, #5, #0x6a838ac
006A838A4  str      x20, [x19, #0x28]
006A838A8  b        #0x6a838bc ; 
006A838AC  ldr      x8, [x2, #0x60]
006A838B0  mov      x0, x19
006A838B4  mov      x1, x20
006A838B8  blr      x8
006A838BC  mov      x0, x19
006A838C0  mov      x1, xzr
006A838C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A838C8  adrp     x21, #0x959e000
006A838CC  ldrb     w8, [x21, #0x525]
006A838D0  mov      w20, w0
006A838D4  cbnz     w8, #0x6a838ec
006A838D8  adrp     x0, #0x8f38000
006A838DC  ldr      x0, [x0, #0x468]
006A838E0  bl       #0x382bd14 ; 
006A838E4  mov      w8, #1
006A838E8  strb     w8, [x21, #0x525]
006A838EC  adrp     x8, #0x8f38000
006A838F0  ldr      x8, [x8, #0x468]
006A838F4  ldr      x2, [x8]
006A838F8  ldrb     w8, [x2, #0x53]
006A838FC  tbnz     w8, #5, #0x6a83908
006A83900  str      w20, [x19, #0x30]
006A83904  b        #0x6a83918 ; 
006A83908  ldr      x8, [x2, #0x60]
006A8390C  mov      x0, x19
006A83910  mov      w1, w20
006A83914  blr      x8
006A83918  ldp      x20, x19, [sp, #0x10]
006A8391C  mov      w0, #1
006A83920  ldp      x30, x21, [sp], #0x20
006A83924  ret      

