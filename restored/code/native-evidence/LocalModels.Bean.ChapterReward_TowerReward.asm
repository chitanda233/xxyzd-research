; LocalModels.Bean.ChapterReward_TowerReward$$readImpl
; RVA 0x689DF18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689DF18  stp      x30, x21, [sp, #-0x20]!
00689DF1C  stp      x20, x19, [sp, #0x10]
00689DF20  adrp     x20, #0x959b000
00689DF24  adrp     x21, #0x8f26000
00689DF28  ldrb     w8, [x20, #0xe87]
00689DF2C  ldr      x21, [x21, #0x178]
00689DF30  mov      x19, x0
00689DF34  tbnz     w8, #0, #0x689df4c
00689DF38  adrp     x0, #0x8f26000
00689DF3C  ldr      x0, [x0, #0x178]
00689DF40  bl       #0x382bd14 ; 
00689DF44  mov      w8, #1
00689DF48  strb     w8, [x20, #0xe87]
00689DF4C  ldr      x1, [x21]
00689DF50  ldrb     w8, [x1, #0x53]
00689DF54  tbnz     w8, #5, #0x689dfa4
00689DF58  mov      x0, x19
00689DF5C  mov      x1, xzr
00689DF60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689DF64  adrp     x21, #0x959c000
00689DF68  ldrb     w8, [x21, #0x4fb]
00689DF6C  mov      w20, w0
00689DF70  cbnz     w8, #0x689df88
00689DF74  adrp     x0, #0x8f26000
00689DF78  ldr      x0, [x0, #0x160]
00689DF7C  bl       #0x382bd14 ; 
00689DF80  mov      w8, #1
00689DF84  strb     w8, [x21, #0x4fb]
00689DF88  adrp     x8, #0x8f26000
00689DF8C  ldr      x8, [x8, #0x160]
00689DF90  ldr      x2, [x8]
00689DF94  ldrb     w8, [x2, #0x53]
00689DF98  tbnz     w8, #5, #0x689dfb8
00689DF9C  str      w20, [x19, #0x20]
00689DFA0  b        #0x689dfc8 ; 
00689DFA4  ldr      x2, [x1, #0x60]
00689DFA8  mov      x0, x19
00689DFAC  ldp      x20, x19, [sp, #0x10]
00689DFB0  ldp      x30, x21, [sp], #0x20
00689DFB4  br       x2
00689DFB8  ldr      x8, [x2, #0x60]
00689DFBC  mov      x0, x19
00689DFC0  mov      w1, w20
00689DFC4  blr      x8
00689DFC8  mov      x0, x19
00689DFCC  mov      x1, xzr
00689DFD0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
00689DFD4  adrp     x21, #0x959c000
00689DFD8  ldrb     w8, [x21, #0x4fc]
00689DFDC  mov      x20, x0
00689DFE0  cbnz     w8, #0x689dff8
00689DFE4  adrp     x0, #0x8f26000
00689DFE8  ldr      x0, [x0, #0x170]
00689DFEC  bl       #0x382bd14 ; 
00689DFF0  mov      w8, #1
00689DFF4  strb     w8, [x21, #0x4fc]
00689DFF8  adrp     x8, #0x8f26000
00689DFFC  ldr      x8, [x8, #0x170]
00689E000  ldr      x2, [x8]
00689E004  ldrb     w8, [x2, #0x53]
00689E008  tbnz     w8, #5, #0x689e020
00689E00C  str      x20, [x19, #0x28]!
00689E010  mov      x0, x19
00689E014  mov      x1, x20
00689E018  bl       #0x382bcb8 ; 
00689E01C  b        #0x689e030 ; 
00689E020  ldr      x8, [x2, #0x60]
00689E024  mov      x0, x19
00689E028  mov      x1, x20
00689E02C  blr      x8
00689E030  ldp      x20, x19, [sp, #0x10]
00689E034  mov      w0, #1
00689E038  ldp      x30, x21, [sp], #0x20
00689E03C  ret      

