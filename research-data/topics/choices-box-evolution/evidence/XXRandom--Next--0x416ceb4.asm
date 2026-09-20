; XXRandom$$Next
; RVA 0x416CEB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00416CEB4  ldr      x8, [x0, #0x10]
00416CEB8  mov      x9, #0xe66d
00416CEBC  movk     x9, #0xdeec, lsl #16
00416CEC0  movk     x9, #5, lsl #32
00416CEC4  mul      x8, x8, x9
00416CEC8  add      x8, x8, #0xb
00416CECC  and      x9, x8, #0xffffffffffff
00416CED0  lsr      x8, x8, #0x10
00416CED4  udiv     w10, w8, w1
00416CED8  msub     w8, w10, w1, w8
00416CEDC  str      x9, [x0, #0x10]
00416CEE0  mov      w0, w8
00416CEE4  ret      

