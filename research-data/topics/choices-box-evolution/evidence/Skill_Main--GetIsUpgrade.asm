; LocalModels.Bean.Skill_Main$$GetIsUpgrade
; RVA 0x6B0A2D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0A2D4  stp      x30, x21, [sp, #-0x20]!
006B0A2D8  stp      x20, x19, [sp, #0x10]
006B0A2DC  adrp     x20, #0x959f000
006B0A2E0  adrp     x21, #0x8f3e000
006B0A2E4  ldrb     w8, [x20, #0x48c]
006B0A2E8  ldr      x21, [x21, #0x848]
006B0A2EC  mov      x19, x0
006B0A2F0  tbnz     w8, #0, #0x6b0a314
006B0A2F4  adrp     x0, #0x8ee8000
006B0A2F8  ldr      x0, [x0, #0x898]
006B0A2FC  bl       #0x382bd14 ;
006B0A300  adrp     x0, #0x8f3e000
006B0A304  ldr      x0, [x0, #0x848]
006B0A308  bl       #0x382bd14 ;
006B0A30C  mov      w8, #1
006B0A310  strb     w8, [x20, #0x48c]
006B0A314  ldr      x1, [x21]
006B0A318  ldrb     w8, [x1, #0x53]
006B0A31C  tbnz     w8, #5, #0x6b0a424
006B0A320  adrp     x20, #0x8ee8000
006B0A324  ldr      x20, [x20, #0x898]
006B0A328  ldr      x0, [x20]
006B0A32C  ldr      w8, [x0, #0xe0]
006B0A330  cbnz     w8, #0x6b0a338
006B0A334  bl       #0x382be8c ;
006B0A338  adrp     x21, #0x959b000
006B0A33C  ldrb     w8, [x21, #0xb85]
006B0A340  cbnz     w8, #0x6b0a364
006B0A344  adrp     x0, #0x8efa000
006B0A348  ldr      x0, [x0, #0x120]
006B0A34C  bl       #0x382bd14 ;
006B0A350  adrp     x0, #0x8ee8000
006B0A354  ldr      x0, [x0, #0x898]
006B0A358  bl       #0x382bd14 ;
006B0A35C  mov      w8, #1
006B0A360  strb     w8, [x21, #0xb85]
006B0A364  adrp     x8, #0x8efa000
006B0A368  ldr      x8, [x8, #0x120]
006B0A36C  ldr      x0, [x8]
006B0A370  ldrb     w8, [x0, #0x53]
006B0A374  tbnz     w8, #5, #0x6b0a3d4
006B0A378  ldr      x0, [x20]
006B0A37C  ldr      w8, [x0, #0xe0]
006B0A380  cbnz     w8, #0x6b0a38c
006B0A384  bl       #0x382be8c ;
006B0A388  ldr      x0, [x20]
006B0A38C  ldr      x8, [x0, #0xb8]
006B0A390  ldrb     w8, [x8, #0x530]
006B0A394  cbz      w8, #0x6b0a3e0
006B0A398  adrp     x20, #0x959f000
006B0A39C  ldrb     w8, [x20, #0x962]
006B0A3A0  cbnz     w8, #0x6b0a3b8
006B0A3A4  adrp     x0, #0x8f3e000
006B0A3A8  ldr      x0, [x0, #0x5f8]
006B0A3AC  bl       #0x382bd14 ;
006B0A3B0  mov      w8, #1
006B0A3B4  strb     w8, [x20, #0x962]
006B0A3B8  adrp     x8, #0x8f3e000
006B0A3BC  ldr      x8, [x8, #0x5f8]
006B0A3C0  ldr      x1, [x8]
006B0A3C4  ldrb     w8, [x1, #0x53]
006B0A3C8  tbnz     w8, #5, #0x6b0a424
006B0A3CC  ldr      w0, [x19, #0x2c]
006B0A3D0  b        #0x6b0a418 ;
006B0A3D4  ldr      x8, [x0, #0x60]
006B0A3D8  blr      x8
006B0A3DC  tbnz     w0, #0, #0x6b0a398
006B0A3E0  adrp     x20, #0x959f000
006B0A3E4  ldrb     w8, [x20, #0x961]
006B0A3E8  cbnz     w8, #0x6b0a400
006B0A3EC  adrp     x0, #0x8f3e000
006B0A3F0  ldr      x0, [x0, #0x5e8]
006B0A3F4  bl       #0x382bd14 ;
006B0A3F8  mov      w8, #1
006B0A3FC  strb     w8, [x20, #0x961]
006B0A400  adrp     x8, #0x8f3e000
006B0A404  ldr      x8, [x8, #0x5e8]
006B0A408  ldr      x1, [x8]
006B0A40C  ldrb     w8, [x1, #0x53]
006B0A410  tbnz     w8, #5, #0x6b0a424
006B0A414  ldr      w0, [x19, #0x28]
006B0A418  ldp      x20, x19, [sp, #0x10]
006B0A41C  ldp      x30, x21, [sp], #0x20
006B0A420  ret
006B0A424  ldr      x2, [x1, #0x60]
006B0A428  mov      x0, x19
006B0A42C  ldp      x20, x19, [sp, #0x10]
006B0A430  ldp      x30, x21, [sp], #0x20
006B0A434  br       x2
