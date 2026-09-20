; XXRandom$$Next
; RVA 0x416D068; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00416D068  cmp      w1, w2
00416D06C  b.eq     #0x416d0ac
00416D070  ldr      x9, [x0, #0x10]
00416D074  mov      x11, #0xe66d
00416D078  movk     x11, #0xdeec, lsl #16
00416D07C  movk     x11, #5, lsl #32
00416D080  mul      x9, x9, x11
00416D084  csel     w8, w1, w2, gt
00416D088  csel     w10, w2, w1, gt
00416D08C  add      x9, x9, #0xb
00416D090  sub      w8, w8, w10
00416D094  and      x11, x9, #0xffffffffffff
00416D098  lsr      x9, x9, #0x10
00416D09C  str      x11, [x0, #0x10]
00416D0A0  udiv     w11, w9, w8
00416D0A4  msub     w8, w11, w8, w9
00416D0A8  add      w1, w8, w10
00416D0AC  mov      w0, w1
00416D0B0  ret      

