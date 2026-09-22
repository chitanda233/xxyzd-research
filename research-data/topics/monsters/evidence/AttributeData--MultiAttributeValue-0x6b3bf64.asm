; HotFix.Common.AttributeData$$MultiAttributeValue
; RVA 0x6B3BF64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B3BF64  stp      x30, x23, [sp, #-0x30]!
006B3BF68  stp      x22, x21, [sp, #0x10]
006B3BF6C  stp      x20, x19, [sp, #0x20]
006B3BF70  adrp     x22, #0x959f000
006B3BF74  adrp     x23, #0x8f40000
006B3BF78  ldrb     w8, [x22, #0x831]
006B3BF7C  ldr      x23, [x23, #0x6e0] ; GLOBAL Method$HotFix.Common.AttributeData.MultiAttributeValue()
006B3BF80  mov      x20, x2
006B3BF84  mov      x19, x1
006B3BF88  mov      x21, x0
006B3BF8C  tbnz     w8, #0, #0x6b3bfa4
006B3BF90  adrp     x0, #0x8f40000
006B3BF94  ldr      x0, [x0, #0x6e0] ; GLOBAL Method$HotFix.Common.AttributeData.MultiAttributeValue()
006B3BF98  bl       #0x382bd14 ; 
006B3BF9C  mov      w8, #1
006B3BFA0  strb     w8, [x22, #0x831]
006B3BFA4  ldr      x3, [x23]
006B3BFA8  ldrb     w8, [x3, #0x53]
006B3BFAC  tbnz     w8, #5, #0x6b3bff0
006B3BFB0  mov      x0, x21
006B3BFB4  mov      x1, x19
006B3BFB8  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
006B3BFBC  ldr      x8, [x21]
006B3BFC0  mov      x1, x19
006B3BFC4  ldp      x9, x3, [x8, #0x178]
006B3BFC8  mul      x8, x0, x20
006B3BFCC  asr      x20, x8, #0x10
006B3BFD0  mov      x0, x21
006B3BFD4  mov      x2, x20
006B3BFD8  blr      x9
006B3BFDC  mov      x0, x20
006B3BFE0  ldp      x20, x19, [sp, #0x20]
006B3BFE4  ldp      x22, x21, [sp, #0x10]
006B3BFE8  ldp      x30, x23, [sp], #0x30
006B3BFEC  ret      
006B3BFF0  ldr      x4, [x3, #0x60]
006B3BFF4  mov      x0, x21
006B3BFF8  mov      x1, x19
006B3BFFC  mov      x2, x20
006B3C000  ldp      x20, x19, [sp, #0x20]
006B3C004  ldp      x22, x21, [sp, #0x10]
006B3C008  ldp      x30, x23, [sp], #0x30
006B3C00C  br       x4

