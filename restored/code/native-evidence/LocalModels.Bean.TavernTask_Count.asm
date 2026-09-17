; LocalModels.Bean.TavernTask_Count$$readImpl
; RVA 0x6B14BC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B14BC4  stp      x30, x21, [sp, #-0x20]!
006B14BC8  stp      x20, x19, [sp, #0x10]
006B14BCC  adrp     x20, #0x959f000
006B14BD0  adrp     x21, #0x8f3e000
006B14BD4  ldrb     w8, [x20, #0x5a9]
006B14BD8  ldr      x21, [x21, #0xf98]
006B14BDC  mov      x19, x0
006B14BE0  tbnz     w8, #0, #0x6b14bf8
006B14BE4  adrp     x0, #0x8f3e000
006B14BE8  ldr      x0, [x0, #0xf98]
006B14BEC  bl       #0x382bd14 ; 
006B14BF0  mov      w8, #1
006B14BF4  strb     w8, [x20, #0x5a9]
006B14BF8  ldr      x1, [x21]
006B14BFC  ldrb     w8, [x1, #0x53]
006B14C00  tbnz     w8, #5, #0x6b14c50
006B14C04  mov      x0, x19
006B14C08  mov      x1, xzr
006B14C0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B14C10  adrp     x21, #0x959f000
006B14C14  ldrb     w8, [x21, #0x9d5]
006B14C18  mov      w20, w0
006B14C1C  cbnz     w8, #0x6b14c34
006B14C20  adrp     x0, #0x8f3e000
006B14C24  ldr      x0, [x0, #0xf80]
006B14C28  bl       #0x382bd14 ; 
006B14C2C  mov      w8, #1
006B14C30  strb     w8, [x21, #0x9d5]
006B14C34  adrp     x8, #0x8f3e000
006B14C38  ldr      x8, [x8, #0xf80]
006B14C3C  ldr      x2, [x8]
006B14C40  ldrb     w8, [x2, #0x53]
006B14C44  tbnz     w8, #5, #0x6b14c64
006B14C48  str      w20, [x19, #0x20]
006B14C4C  b        #0x6b14c74 ; 
006B14C50  ldr      x2, [x1, #0x60]
006B14C54  mov      x0, x19
006B14C58  ldp      x20, x19, [sp, #0x10]
006B14C5C  ldp      x30, x21, [sp], #0x20
006B14C60  br       x2
006B14C64  ldr      x8, [x2, #0x60]
006B14C68  mov      x0, x19
006B14C6C  mov      w1, w20
006B14C70  blr      x8
006B14C74  mov      x0, x19
006B14C78  mov      x1, xzr
006B14C7C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B14C80  adrp     x21, #0x959f000
006B14C84  ldrb     w8, [x21, #0x9d6]
006B14C88  mov      w20, w0
006B14C8C  cbnz     w8, #0x6b14ca4
006B14C90  adrp     x0, #0x8f3e000
006B14C94  ldr      x0, [x0, #0xf90]
006B14C98  bl       #0x382bd14 ; 
006B14C9C  mov      w8, #1
006B14CA0  strb     w8, [x21, #0x9d6]
006B14CA4  adrp     x8, #0x8f3e000
006B14CA8  ldr      x8, [x8, #0xf90]
006B14CAC  ldr      x2, [x8]
006B14CB0  ldrb     w8, [x2, #0x53]
006B14CB4  tbnz     w8, #5, #0x6b14cc0
006B14CB8  str      w20, [x19, #0x24]
006B14CBC  b        #0x6b14cd0 ; 
006B14CC0  ldr      x8, [x2, #0x60]
006B14CC4  mov      x0, x19
006B14CC8  mov      w1, w20
006B14CCC  blr      x8
006B14CD0  ldp      x20, x19, [sp, #0x10]
006B14CD4  mov      w0, #1
006B14CD8  ldp      x30, x21, [sp], #0x20
006B14CDC  ret      

