; HotFix.PunchboardViewModule$$ClickFinish
; RVA 0x778A150; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00778A150  stp      x30, x21, [sp, #-0x20]!
00778A154  stp      x20, x19, [sp, #0x10]
00778A158  adrp     x20, #0x95ab000
00778A15C  adrp     x21, #0x8fb7000
00778A160  ldrb     w8, [x20, #0x287]
00778A164  ldr      x21, [x21, #0x350] ; GLOBAL Method$HotFix.PunchboardViewModule.ClickFinish() @ 0x929bae0
00778A168  mov      x19, x0
00778A16C  tbnz     w8, #0, #0x778a184
00778A170  adrp     x0, #0x8fb7000
00778A174  ldr      x0, [x0, #0x350] ; GLOBAL Method$HotFix.PunchboardViewModule.ClickFinish() @ 0x929bae0
00778A178  bl       #0x382bd14 ; 
00778A17C  mov      w8, #1
00778A180  strb     w8, [x20, #0x287]
00778A184  ldr      x1, [x21]
00778A188  ldrb     w8, [x1, #0x53]
00778A18C  tbnz     w8, #5, #0x778a1a0
00778A190  mov      x0, x19
00778A194  ldp      x20, x19, [sp, #0x10]
00778A198  ldp      x30, x21, [sp], #0x20
00778A19C  b        #0x778a1b4 ; HotFix.PunchboardViewModule$$DispatchSelectCmd
00778A1A0  ldr      x2, [x1, #0x60]
00778A1A4  mov      x0, x19
00778A1A8  ldp      x20, x19, [sp, #0x10]
00778A1AC  ldp      x30, x21, [sp], #0x20
00778A1B0  br       x2

