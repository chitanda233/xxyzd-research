; LocalModels.Bean.Calendar_CalendarFinalReward$$readImpl
; RVA 0x6890960; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006890960  stp      x30, x21, [sp, #-0x20]!
006890964  stp      x20, x19, [sp, #0x10]
006890968  adrp     x20, #0x959b000
00689096C  adrp     x21, #0x8f25000
006890970  ldrb     w8, [x20, #0xd25]
006890974  ldr      x21, [x21, #0x710]
006890978  mov      x19, x0
00689097C  tbnz     w8, #0, #0x6890994
006890980  adrp     x0, #0x8f25000
006890984  ldr      x0, [x0, #0x710]
006890988  bl       #0x382bd14 ; 
00689098C  mov      w8, #1
006890990  strb     w8, [x20, #0xd25]
006890994  ldr      x1, [x21]
006890998  ldrb     w8, [x1, #0x53]
00689099C  tbnz     w8, #5, #0x68909ec
0068909A0  mov      x0, x19
0068909A4  mov      x1, xzr
0068909A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068909AC  adrp     x21, #0x959c000
0068909B0  ldrb     w8, [x21, #0x466]
0068909B4  mov      w20, w0
0068909B8  cbnz     w8, #0x68909d0
0068909BC  adrp     x0, #0x8f25000
0068909C0  ldr      x0, [x0, #0x6f8]
0068909C4  bl       #0x382bd14 ; 
0068909C8  mov      w8, #1
0068909CC  strb     w8, [x21, #0x466]
0068909D0  adrp     x8, #0x8f25000
0068909D4  ldr      x8, [x8, #0x6f8]
0068909D8  ldr      x2, [x8]
0068909DC  ldrb     w8, [x2, #0x53]
0068909E0  tbnz     w8, #5, #0x6890a00
0068909E4  str      w20, [x19, #0x20]
0068909E8  b        #0x6890a10 ; 
0068909EC  ldr      x2, [x1, #0x60]
0068909F0  mov      x0, x19
0068909F4  ldp      x20, x19, [sp, #0x10]
0068909F8  ldp      x30, x21, [sp], #0x20
0068909FC  br       x2
006890A00  ldr      x8, [x2, #0x60]
006890A04  mov      x0, x19
006890A08  mov      w1, w20
006890A0C  blr      x8
006890A10  mov      x0, x19
006890A14  mov      x1, xzr
006890A18  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006890A1C  adrp     x21, #0x959c000
006890A20  ldrb     w8, [x21, #0x467]
006890A24  mov      x20, x0
006890A28  cbnz     w8, #0x6890a40
006890A2C  adrp     x0, #0x8f25000
006890A30  ldr      x0, [x0, #0x708]
006890A34  bl       #0x382bd14 ; 
006890A38  mov      w8, #1
006890A3C  strb     w8, [x21, #0x467]
006890A40  adrp     x8, #0x8f25000
006890A44  ldr      x8, [x8, #0x708]
006890A48  ldr      x2, [x8]
006890A4C  ldrb     w8, [x2, #0x53]
006890A50  tbnz     w8, #5, #0x6890a68
006890A54  str      x20, [x19, #0x28]!
006890A58  mov      x0, x19
006890A5C  mov      x1, x20
006890A60  bl       #0x382bcb8 ; 
006890A64  b        #0x6890a78 ; 
006890A68  ldr      x8, [x2, #0x60]
006890A6C  mov      x0, x19
006890A70  mov      x1, x20
006890A74  blr      x8
006890A78  ldp      x20, x19, [sp, #0x10]
006890A7C  mov      w0, #1
006890A80  ldp      x30, x21, [sp], #0x20
006890A84  ret      

