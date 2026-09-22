; MissionData$$ReadRects
; RVA 0x64C7B14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C7B14  str      x30, [sp, #-0x40]!
0064C7B18  stp      x24, x23, [sp, #0x10]
0064C7B1C  stp      x22, x21, [sp, #0x20]
0064C7B20  stp      x20, x19, [sp, #0x30]
0064C7B24  adrp     x22, #0x9597000
0064C7B28  adrp     x23, #0x8ef9000
0064C7B2C  ldrb     w8, [x22, #0xfa5]
0064C7B30  ldr      x23, [x23, #0xe68] ; GLOBAL Method$MissionData.ReadRects()
0064C7B34  mov      x19, x2
0064C7B38  mov      x20, x1
0064C7B3C  mov      x21, x0
0064C7B40  tbnz     w8, #0, #0x64c7b64
0064C7B44  adrp     x0, #0x8ef9000
0064C7B48  ldr      x0, [x0, #0xe18] ; GLOBAL MapRect[]_TypeInfo
0064C7B4C  bl       #0x382bd14 ; 
0064C7B50  adrp     x0, #0x8ef9000
0064C7B54  ldr      x0, [x0, #0xe68] ; GLOBAL Method$MissionData.ReadRects()
0064C7B58  bl       #0x382bd14 ; 
0064C7B5C  mov      w8, #1
0064C7B60  strb     w8, [x22, #0xfa5]
0064C7B64  ldr      x3, [x23]
0064C7B68  ldrb     w8, [x3, #0x53]
0064C7B6C  tbnz     w8, #5, #0x64c7c10
0064C7B70  cbz      x20, #0x64c7c34
0064C7B74  ldr      x8, [x20]
0064C7B78  mov      x0, x20
0064C7B7C  ldr      x9, [x8, #0x238]
0064C7B80  ldr      x1, [x8, #0x240]
0064C7B84  blr      x9
0064C7B88  adrp     x8, #0x8ef9000
0064C7B8C  ldr      x8, [x8, #0xe18] ; GLOBAL MapRect[]_TypeInfo
0064C7B90  mov      w22, w0
0064C7B94  mov      w1, w22
0064C7B98  ldr      x8, [x8]
0064C7B9C  mov      x0, x8
0064C7BA0  bl       #0x382bdfc ; 
0064C7BA4  mov      x1, x0
0064C7BA8  str      x0, [x19]
0064C7BAC  mov      x0, x19
0064C7BB0  bl       #0x382bcb8 ; 
0064C7BB4  cmp      w22, #1
0064C7BB8  b.lt     #0x64c7bfc
0064C7BBC  mov      x23, xzr
0064C7BC0  mov      w22, w22
0064C7BC4  mov      w24, #0x20
0064C7BC8  ldr      x8, [x19]
0064C7BCC  cbz      x8, #0x64c7c34
0064C7BD0  ldr      w9, [x8, #0x18]
0064C7BD4  cmp      x23, x9
0064C7BD8  b.hs     #0x64c7c38
0064C7BDC  add      x2, x8, x24
0064C7BE0  mov      x0, x21
0064C7BE4  mov      x1, x20
0064C7BE8  bl       #0x64c79d0 ; MissionData$$ReadRect
0064C7BEC  add      x23, x23, #1
0064C7BF0  cmp      x22, x23
0064C7BF4  add      x24, x24, #0x40
0064C7BF8  b.ne     #0x64c7bc8
0064C7BFC  ldp      x20, x19, [sp, #0x30]
0064C7C00  ldp      x22, x21, [sp, #0x20]
0064C7C04  ldp      x24, x23, [sp, #0x10]
0064C7C08  ldr      x30, [sp], #0x40
0064C7C0C  ret      
0064C7C10  ldr      x4, [x3, #0x60]
0064C7C14  mov      x0, x21
0064C7C18  mov      x1, x20
0064C7C1C  mov      x2, x19
0064C7C20  ldp      x20, x19, [sp, #0x30]
0064C7C24  ldp      x22, x21, [sp, #0x20]
0064C7C28  ldp      x24, x23, [sp, #0x10]
0064C7C2C  ldr      x30, [sp], #0x40
0064C7C30  br       x4
0064C7C34  bl       #0x382bfb8 ; 
0064C7C38  bl       #0x382bfc0 ; 

