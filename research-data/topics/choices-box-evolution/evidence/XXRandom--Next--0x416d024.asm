; XXRandom$$Next
; RVA 0x416D024; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00416D024  ldr      x8, [x0, #0x10]
00416D028  mov      x11, #0xe66d
00416D02C  movk     x11, #0xdeec, lsl #16
00416D030  movk     x11, #5, lsl #32
00416D034  cmp      x1, x2
00416D038  mul      x8, x8, x11
00416D03C  csel     x9, x1, x2, gt
00416D040  csel     x10, x2, x1, gt
00416D044  add      x8, x8, #0xb
00416D048  and      x11, x8, #0xffffffffffff
00416D04C  ubfx     x8, x8, #0x20, #0x10
00416D050  sub      x9, x9, x10
00416D054  mul      x8, x8, x9
00416D058  add      x8, x10, x8, asr #16
00416D05C  str      x11, [x0, #0x10]
00416D060  mov      x0, x8
00416D064  ret      

