; XXRandom$$Next
; RVA 0x416CFE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00416CFE8  ldr      x9, [x0, #0x10]
00416CFEC  mov      x10, #0xe66d
00416CFF0  movk     x10, #0xdeec, lsl #16
00416CFF4  movk     x10, #5, lsl #32
00416CFF8  mul      x9, x9, x10
00416CFFC  add      x9, x9, #0xb
00416D000  mov      x8, xzr
00416D004  and      x10, x9, #0xffffffffffff
00416D008  lsr      x9, x9, #0x20
00416D00C  sub      x8, x8, w9, uxth
00416D010  asr      x8, x8, #0x10
00416D014  eor      x8, x8, #0x8000000000000000
00416D018  str      x10, [x0, #0x10]
00416D01C  mov      x0, x8
00416D020  ret      

