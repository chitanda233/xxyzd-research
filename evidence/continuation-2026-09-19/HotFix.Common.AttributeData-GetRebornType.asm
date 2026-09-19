; HotFix.Common.AttributeData$$GetRebornType
; RVA 0x6B3DD14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B3DD14  stp      x30, x23, [sp, #-0x30]!
006B3DD18  stp      x22, x21, [sp, #0x10]
006B3DD1C  stp      x20, x19, [sp, #0x20]
006B3DD20  adrp     x22, #0x959f000
006B3DD24  adrp     x23, #0x8f40000
006B3DD28  ldrb     w8, [x22, #0x855]
006B3DD2C  ldr      x23, [x23, #0x840] ; GLOBAL Method$HotFix.Common.AttributeData.GetRebornType() @ 0x9239e88
006B3DD30  mov      w19, w2
006B3DD34  mov      x20, x1
006B3DD38  mov      x21, x0
006B3DD3C  tbnz     w8, #0, #0x6b3dd6c
006B3DD40  adrp     x0, #0x8f40000
006B3DD44  ldr      x0, [x0, #0x840] ; GLOBAL Method$HotFix.Common.AttributeData.GetRebornType() @ 0x9239e88
006B3DD48  bl       #0x382bd14 ; 
006B3DD4C  adrp     x0, #0x8f40000
006B3DD50  ldr      x0, [x0, #0x848] ; GLOBAL ResurrectionFullRate% @ 0x930bdf0
006B3DD54  bl       #0x382bd14 ; 
006B3DD58  adrp     x0, #0x8f40000
006B3DD5C  ldr      x0, [x0, #0x850] ; GLOBAL ResurrectionRate% @ 0x930bdf8
006B3DD60  bl       #0x382bd14 ; 
006B3DD64  mov      w8, #1
006B3DD68  strb     w8, [x22, #0x855]
006B3DD6C  ldr      x3, [x23]
006B3DD70  ldrb     w8, [x3, #0x53]
006B3DD74  tbnz     w8, #5, #0x6b3dd90
006B3DD78  mov      x0, x21
006B3DD7C  bl       #0x6b3de14 ; HotFix.Common.AttributeData$$GetSkill1RebornCount
006B3DD80  cmp      w0, #0
006B3DD84  b.le     #0x6b3ddb0
006B3DD88  mov      w0, #4
006B3DD8C  b        #0x6b3de04 ; 
006B3DD90  ldr      x4, [x3, #0x60]
006B3DD94  mov      x0, x21
006B3DD98  mov      x1, x20
006B3DD9C  mov      w2, w19
006B3DDA0  ldp      x20, x19, [sp, #0x20]
006B3DDA4  ldp      x22, x21, [sp, #0x10]
006B3DDA8  ldp      x30, x23, [sp], #0x30
006B3DDAC  br       x4
006B3DDB0  adrp     x8, #0x8f40000
006B3DDB4  ldr      x8, [x8, #0x848] ; GLOBAL ResurrectionFullRate% @ 0x930bdf0
006B3DDB8  mov      x0, x21
006B3DDBC  ldr      x1, [x8]
006B3DDC0  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
006B3DDC4  cmp      x0, x20
006B3DDC8  b.ge     #0x6b3ddf8
006B3DDCC  adrp     x8, #0x8f40000
006B3DDD0  ldr      x8, [x8, #0x850] ; GLOBAL ResurrectionRate% @ 0x930bdf8
006B3DDD4  mov      x0, x21
006B3DDD8  ldr      x1, [x8]
006B3DDDC  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
006B3DDE0  cmp      x0, x20
006B3DDE4  b.ge     #0x6b3de00
006B3DDE8  cmp      w19, #0
006B3DDEC  mov      w8, #3
006B3DDF0  csel     w0, w8, wzr, gt
006B3DDF4  b        #0x6b3de04 ; 
006B3DDF8  mov      w0, #2
006B3DDFC  b        #0x6b3de04 ; 
006B3DE00  mov      w0, #1
006B3DE04  ldp      x20, x19, [sp, #0x20]
006B3DE08  ldp      x22, x21, [sp, #0x10]
006B3DE0C  ldp      x30, x23, [sp], #0x30
006B3DE10  ret      

