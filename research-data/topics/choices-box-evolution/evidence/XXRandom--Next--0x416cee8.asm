; XXRandom$$Next
; RVA 0x416CEE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00416CEE8  ldr      x8, [x0, #0x10]
00416CEEC  mov      x9, #0xe66d
00416CEF0  movk     x9, #0xdeec, lsl #16
00416CEF4  movk     x9, #5, lsl #32
00416CEF8  mul      x8, x8, x9
00416CEFC  add      x8, x8, #0xb
00416CF00  and      x9, x8, #0xffffffffffff
00416CF04  lsr      x10, x8, #0x10
00416CF08  ubfx     x8, x8, #0x10, #0x20
00416CF0C  sxtw     x11, w1
00416CF10  sdiv     x8, x8, x11
00416CF14  msub     w8, w8, w1, w10
00416CF18  str      x9, [x0, #0x10]
00416CF1C  mov      w0, w8
00416CF20  ret      

