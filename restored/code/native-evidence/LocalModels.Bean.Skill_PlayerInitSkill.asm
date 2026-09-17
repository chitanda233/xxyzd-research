; LocalModels.Bean.Skill_PlayerInitSkill$$readImpl
; RVA 0x6B0AB58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0AB58  stp      x30, x21, [sp, #-0x20]!
006B0AB5C  stp      x20, x19, [sp, #0x10]
006B0AB60  adrp     x20, #0x959f000
006B0AB64  adrp     x21, #0x8f3e000
006B0AB68  ldrb     w8, [x20, #0x49b]
006B0AB6C  ldr      x21, [x21, #0x898]
006B0AB70  mov      x19, x0
006B0AB74  tbnz     w8, #0, #0x6b0ab8c
006B0AB78  adrp     x0, #0x8f3e000
006B0AB7C  ldr      x0, [x0, #0x898]
006B0AB80  bl       #0x382bd14 ; 
006B0AB84  mov      w8, #1
006B0AB88  strb     w8, [x20, #0x49b]
006B0AB8C  ldr      x1, [x21]
006B0AB90  ldrb     w8, [x1, #0x53]
006B0AB94  tbnz     w8, #5, #0x6b0abe4
006B0AB98  mov      x0, x19
006B0AB9C  mov      x1, xzr
006B0ABA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0ABA4  adrp     x21, #0x959f000
006B0ABA8  ldrb     w8, [x21, #0x969]
006B0ABAC  mov      w20, w0
006B0ABB0  cbnz     w8, #0x6b0abc8
006B0ABB4  adrp     x0, #0x8f3e000
006B0ABB8  ldr      x0, [x0, #0x888]
006B0ABBC  bl       #0x382bd14 ; 
006B0ABC0  mov      w8, #1
006B0ABC4  strb     w8, [x21, #0x969]
006B0ABC8  adrp     x8, #0x8f3e000
006B0ABCC  ldr      x8, [x8, #0x888]
006B0ABD0  ldr      x2, [x8]
006B0ABD4  ldrb     w8, [x2, #0x53]
006B0ABD8  tbnz     w8, #5, #0x6b0abf8
006B0ABDC  str      w20, [x19, #0x20]
006B0ABE0  b        #0x6b0ac08 ; 
006B0ABE4  ldr      x2, [x1, #0x60]
006B0ABE8  mov      x0, x19
006B0ABEC  ldp      x20, x19, [sp, #0x10]
006B0ABF0  ldp      x30, x21, [sp], #0x20
006B0ABF4  br       x2
006B0ABF8  ldr      x8, [x2, #0x60]
006B0ABFC  mov      x0, x19
006B0AC00  mov      w1, w20
006B0AC04  blr      x8
006B0AC08  mov      x0, x19
006B0AC0C  mov      x1, xzr
006B0AC10  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B0AC14  adrp     x21, #0x959f000
006B0AC18  ldrb     w8, [x21, #0x96a]
006B0AC1C  mov      x20, x0
006B0AC20  cbnz     w8, #0x6b0ac38
006B0AC24  adrp     x0, #0x8f3e000
006B0AC28  ldr      x0, [x0, #0x890]
006B0AC2C  bl       #0x382bd14 ; 
006B0AC30  mov      w8, #1
006B0AC34  strb     w8, [x21, #0x96a]
006B0AC38  adrp     x8, #0x8f3e000
006B0AC3C  ldr      x8, [x8, #0x890]
006B0AC40  ldr      x2, [x8]
006B0AC44  ldrb     w8, [x2, #0x53]
006B0AC48  tbnz     w8, #5, #0x6b0ac60
006B0AC4C  str      x20, [x19, #0x28]!
006B0AC50  mov      x0, x19
006B0AC54  mov      x1, x20
006B0AC58  bl       #0x382bcb8 ; 
006B0AC5C  b        #0x6b0ac70 ; 
006B0AC60  ldr      x8, [x2, #0x60]
006B0AC64  mov      x0, x19
006B0AC68  mov      x1, x20
006B0AC6C  blr      x8
006B0AC70  ldp      x20, x19, [sp, #0x10]
006B0AC74  mov      w0, #1
006B0AC78  ldp      x30, x21, [sp], #0x20
006B0AC7C  ret      

