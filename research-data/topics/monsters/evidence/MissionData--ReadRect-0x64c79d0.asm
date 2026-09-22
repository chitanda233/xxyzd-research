; MissionData$$ReadRect
; RVA 0x64C79D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C79D0  stp      x30, x23, [sp, #-0x30]!
0064C79D4  stp      x22, x21, [sp, #0x10]
0064C79D8  stp      x20, x19, [sp, #0x20]
0064C79DC  adrp     x22, #0x9597000
0064C79E0  adrp     x23, #0x8ef9000
0064C79E4  ldrb     w8, [x22, #0xfa6]
0064C79E8  ldr      x23, [x23, #0xe60] ; GLOBAL Method$MissionData.ReadRect()
0064C79EC  mov      x19, x2
0064C79F0  mov      x20, x1
0064C79F4  mov      x21, x0
0064C79F8  tbnz     w8, #0, #0x64c7a10
0064C79FC  adrp     x0, #0x8ef9000
0064C7A00  ldr      x0, [x0, #0xe60] ; GLOBAL Method$MissionData.ReadRect()
0064C7A04  bl       #0x382bd14 ; 
0064C7A08  mov      w8, #1
0064C7A0C  strb     w8, [x22, #0xfa6]
0064C7A10  ldr      x3, [x23]
0064C7A14  ldrb     w8, [x3, #0x53]
0064C7A18  tbnz     w8, #5, #0x64c7af0
0064C7A1C  cbz      x20, #0x64c7b10
0064C7A20  ldr      x8, [x20]
0064C7A24  mov      x0, x20
0064C7A28  ldr      x9, [x8, #0x238]
0064C7A2C  ldr      x1, [x8, #0x240]
0064C7A30  blr      x9
0064C7A34  str      w0, [x19]
0064C7A38  ldr      x8, [x20]
0064C7A3C  mov      x0, x20
0064C7A40  ldr      x9, [x8, #0x238]
0064C7A44  ldr      x1, [x8, #0x240]
0064C7A48  blr      x9
0064C7A4C  str      w0, [x19, #4]
0064C7A50  ldr      x8, [x20]
0064C7A54  mov      x0, x20
0064C7A58  ldr      x9, [x8, #0x238]
0064C7A5C  ldr      x1, [x8, #0x240]
0064C7A60  blr      x9
0064C7A64  str      w0, [x19, #8]
0064C7A68  ldr      x8, [x20]
0064C7A6C  mov      x0, x20
0064C7A70  ldr      x9, [x8, #0x238]
0064C7A74  ldr      x1, [x8, #0x240]
0064C7A78  blr      x9
0064C7A7C  str      w0, [x19, #0xc]
0064C7A80  ldr      x8, [x20]
0064C7A84  mov      x0, x20
0064C7A88  ldr      x9, [x8, #0x238]
0064C7A8C  ldr      x1, [x8, #0x240]
0064C7A90  blr      x9
0064C7A94  str      w0, [x19, #0x10]
0064C7A98  ldr      x8, [x20]
0064C7A9C  mov      x0, x20
0064C7AA0  ldr      x9, [x8, #0x238]
0064C7AA4  ldr      x1, [x8, #0x240]
0064C7AA8  blr      x9
0064C7AAC  str      w0, [x19, #0x14]
0064C7AB0  ldr      x8, [x20]
0064C7AB4  mov      x0, x20
0064C7AB8  ldr      x9, [x8, #0x238]
0064C7ABC  ldr      x1, [x8, #0x240]
0064C7AC0  blr      x9
0064C7AC4  str      w0, [x19, #0x18]
0064C7AC8  ldr      x8, [x20]
0064C7ACC  mov      x0, x20
0064C7AD0  ldr      x9, [x8, #0x238]
0064C7AD4  ldr      x1, [x8, #0x240]
0064C7AD8  blr      x9
0064C7ADC  str      w0, [x19, #0x1c]
0064C7AE0  ldp      x20, x19, [sp, #0x20]
0064C7AE4  ldp      x22, x21, [sp, #0x10]
0064C7AE8  ldp      x30, x23, [sp], #0x30
0064C7AEC  ret      
0064C7AF0  ldr      x4, [x3, #0x60]
0064C7AF4  mov      x0, x21
0064C7AF8  mov      x1, x20
0064C7AFC  mov      x2, x19
0064C7B00  ldp      x20, x19, [sp, #0x20]
0064C7B04  ldp      x22, x21, [sp, #0x10]
0064C7B08  ldp      x30, x23, [sp], #0x30
0064C7B0C  br       x4
0064C7B10  bl       #0x382bfb8 ; 

