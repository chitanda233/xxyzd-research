; LocalModels.Bean.Skill_Main$$GetUpgradeSkillId
; RVA 0x6B0A438; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0A438  stp      x30, x21, [sp, #-0x20]!
006B0A43C  stp      x20, x19, [sp, #0x10]
006B0A440  adrp     x20, #0x959f000
006B0A444  adrp     x21, #0x8f3e000
006B0A448  ldrb     w8, [x20, #0x48d]
006B0A44C  ldr      x21, [x21, #0x850]
006B0A450  mov      x19, x0
006B0A454  tbnz     w8, #0, #0x6b0a478
006B0A458  adrp     x0, #0x8ee8000
006B0A45C  ldr      x0, [x0, #0x898]
006B0A460  bl       #0x382bd14 ;
006B0A464  adrp     x0, #0x8f3e000
006B0A468  ldr      x0, [x0, #0x850]
006B0A46C  bl       #0x382bd14 ;
006B0A470  mov      w8, #1
006B0A474  strb     w8, [x20, #0x48d]
006B0A478  ldr      x1, [x21]
006B0A47C  ldrb     w8, [x1, #0x53]
006B0A480  tbnz     w8, #5, #0x6b0a588
006B0A484  adrp     x20, #0x8ee8000
006B0A488  ldr      x20, [x20, #0x898]
006B0A48C  ldr      x0, [x20]
006B0A490  ldr      w8, [x0, #0xe0]
006B0A494  cbnz     w8, #0x6b0a49c
006B0A498  bl       #0x382be8c ;
006B0A49C  adrp     x21, #0x959b000
006B0A4A0  ldrb     w8, [x21, #0xb85]
006B0A4A4  cbnz     w8, #0x6b0a4c8
006B0A4A8  adrp     x0, #0x8efa000
006B0A4AC  ldr      x0, [x0, #0x120]
006B0A4B0  bl       #0x382bd14 ;
006B0A4B4  adrp     x0, #0x8ee8000
006B0A4B8  ldr      x0, [x0, #0x898]
006B0A4BC  bl       #0x382bd14 ;
006B0A4C0  mov      w8, #1
006B0A4C4  strb     w8, [x21, #0xb85]
006B0A4C8  adrp     x8, #0x8efa000
006B0A4CC  ldr      x8, [x8, #0x120]
006B0A4D0  ldr      x0, [x8]
006B0A4D4  ldrb     w8, [x0, #0x53]
006B0A4D8  tbnz     w8, #5, #0x6b0a538
006B0A4DC  ldr      x0, [x20]
006B0A4E0  ldr      w8, [x0, #0xe0]
006B0A4E4  cbnz     w8, #0x6b0a4f0
006B0A4E8  bl       #0x382be8c ;
006B0A4EC  ldr      x0, [x20]
006B0A4F0  ldr      x8, [x0, #0xb8]
006B0A4F4  ldrb     w8, [x8, #0x530]
006B0A4F8  cbz      w8, #0x6b0a544
006B0A4FC  adrp     x20, #0x959f000
006B0A500  ldrb     w8, [x20, #0x964]
006B0A504  cbnz     w8, #0x6b0a51c
006B0A508  adrp     x0, #0x8f3e000
006B0A50C  ldr      x0, [x0, #0x628]
006B0A510  bl       #0x382bd14 ;
006B0A514  mov      w8, #1
006B0A518  strb     w8, [x20, #0x964]
006B0A51C  adrp     x8, #0x8f3e000
006B0A520  ldr      x8, [x8, #0x628]
006B0A524  ldr      x1, [x8]
006B0A528  ldrb     w8, [x1, #0x53]
006B0A52C  tbnz     w8, #5, #0x6b0a588
006B0A530  ldr      x0, [x19, #0x40]
006B0A534  b        #0x6b0a57c ;
006B0A538  ldr      x8, [x0, #0x60]
006B0A53C  blr      x8
006B0A540  tbnz     w0, #0, #0x6b0a4fc
006B0A544  adrp     x20, #0x959f000
006B0A548  ldrb     w8, [x20, #0x963]
006B0A54C  cbnz     w8, #0x6b0a564
006B0A550  adrp     x0, #0x8f3e000
006B0A554  ldr      x0, [x0, #0x618]
006B0A558  bl       #0x382bd14 ;
006B0A55C  mov      w8, #1
006B0A560  strb     w8, [x20, #0x963]
006B0A564  adrp     x8, #0x8f3e000
006B0A568  ldr      x8, [x8, #0x618]
006B0A56C  ldr      x1, [x8]
006B0A570  ldrb     w8, [x1, #0x53]
006B0A574  tbnz     w8, #5, #0x6b0a588
006B0A578  ldr      x0, [x19, #0x38]
006B0A57C  ldp      x20, x19, [sp, #0x10]
006B0A580  ldp      x30, x21, [sp], #0x20
006B0A584  ret
006B0A588  ldr      x2, [x1, #0x60]
006B0A58C  mov      x0, x19
006B0A590  ldp      x20, x19, [sp, #0x10]
006B0A594  ldp      x30, x21, [sp], #0x20
006B0A598  br       x2
