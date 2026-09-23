; HotFix.BattleLogic.BattleWorldContext$$DoInitSkillGroup
; RVA 0x6A035C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A035C0  stp      x30, x21, [sp, #-0x20]!
006A035C4  stp      x20, x19, [sp, #0x10]
006A035C8  adrp     x20, #0x959d000
006A035CC  adrp     x21, #0x8f23000
006A035D0  ldrb     w8, [x20, #0x576]
006A035D4  ldr      x21, [x21, #0xb80]
006A035D8  mov      x19, x0
006A035DC  tbnz     w8, #0, #0x6a035f4
006A035E0  adrp     x0, #0x8f23000
006A035E4  ldr      x0, [x0, #0xb80]
006A035E8  bl       #0x382bd14 ;
006A035EC  mov      w8, #1
006A035F0  strb     w8, [x20, #0x576]
006A035F4  ldr      x1, [x21]
006A035F8  ldrb     w8, [x1, #0x53]
006A035FC  tbnz     w8, #5, #0x6a03618
006A03600  ldr      w8, [x19, #0x2c4]
006A03604  sub      w8, w8, #1
006A03608  str      w8, [x19, #0x2c4]
006A0360C  ldp      x20, x19, [sp, #0x10]
006A03610  ldp      x30, x21, [sp], #0x20
006A03614  ret
006A03618  ldr      x2, [x1, #0x60]
006A0361C  mov      x0, x19
006A03620  ldp      x20, x19, [sp, #0x10]
006A03624  ldp      x30, x21, [sp], #0x20
006A03628  br       x2

; HotFix.BattleLogic.BattleWorldContext$$DoInitSkillGroupCount
; RVA 0x6A0362C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A0362C  str      x30, [sp, #-0x30]!
006A03630  stp      x22, x21, [sp, #0x10]
006A03634  stp      x20, x19, [sp, #0x20]
006A03638  adrp     x21, #0x959d000
006A0363C  adrp     x22, #0x8f0a000
006A03640  ldrb     w8, [x21, #0x577]
006A03644  ldr      x22, [x22, #0x600]
006A03648  mov      w19, w1
006A0364C  mov      x20, x0
006A03650  tbnz     w8, #0, #0x6a03668
006A03654  adrp     x0, #0x8f0a000
006A03658  ldr      x0, [x0, #0x600]
006A0365C  bl       #0x382bd14 ;
006A03660  mov      w8, #1
006A03664  strb     w8, [x21, #0x577]
006A03668  ldr      x2, [x22]
006A0366C  ldrb     w8, [x2, #0x53]
006A03670  tbnz     w8, #5, #0x6a036a0
006A03674  ldr      x0, [x20, #0x1d0]
006A03678  cbz      x0, #0x6a036bc
006A0367C  ldr      x8, [x0]
006A03680  ldp      x9, x1, [x8, #0x198]
006A03684  blr      x9
006A03688  tbnz     w0, #0, #0x6a03690
006A0368C  str      w19, [x20, #0x2c4]
006A03690  ldp      x20, x19, [sp, #0x20]
006A03694  ldp      x22, x21, [sp, #0x10]
006A03698  ldr      x30, [sp], #0x30
006A0369C  ret
006A036A0  ldr      x3, [x2, #0x60]
006A036A4  mov      x0, x20
006A036A8  mov      w1, w19
006A036AC  ldp      x20, x19, [sp, #0x20]
006A036B0  ldp      x22, x21, [sp, #0x10]
006A036B4  ldr      x30, [sp], #0x30
006A036B8  br       x3
006A036BC  bl       #0x382bfb8 ;
