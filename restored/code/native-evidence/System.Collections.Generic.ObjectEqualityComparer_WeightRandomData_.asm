; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$Equals
; RVA 0x51D8F1C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0051D8F1C  sub      sp, sp, #0xb0
0051D8F20  str      x30, [sp, #0x90]
0051D8F24  stp      x20, x19, [sp, #0xa0]
0051D8F28  ldr      x8, [x2, #0x30]
0051D8F2C  ldp      q1, q0, [x2, #0x10]
0051D8F30  ldr      q2, [x2]
0051D8F34  mov      x19, x1
0051D8F38  str      x8, [sp, #0x80]
0051D8F3C  stp      q1, q0, [sp, #0x60]
0051D8F40  str      q2, [sp, #0x50]
0051D8F44  ldr      x8, [x3, #0x20]
0051D8F48  add      x1, sp, #0x50
0051D8F4C  mov      x20, x3
0051D8F50  ldr      x8, [x8, #0xc0]
0051D8F54  ldr      x0, [x8]
0051D8F58  bl       #0x382be94 ; 
0051D8F5C  ldr      x8, [x20, #0x20]
0051D8F60  mov      x20, x0
0051D8F64  ldr      x8, [x8, #0xc0]
0051D8F68  ldr      x8, [x8]
0051D8F6C  ldrb     w9, [x8, #0x135]
0051D8F70  tbnz     w9, #0, #0x51d8f80
0051D8F74  mov      x0, x8
0051D8F78  bl       #0x3a7e60c ; 
0051D8F7C  mov      x8, x0
0051D8F80  mov      x9, #-1
0051D8F84  stp      x8, x9, [sp, #8]
0051D8F88  ldr      x8, [x19, #0x30]
0051D8F8C  ldp      q1, q0, [x19, #0x10]
0051D8F90  ldr      q2, [x19]
0051D8F94  add      x0, sp, #8
0051D8F98  mov      x1, x20
0051D8F9C  mov      x2, xzr
0051D8FA0  str      x8, [sp, #0x48]
0051D8FA4  stur     q0, [sp, #0x38]
0051D8FA8  stur     q1, [sp, #0x28]
0051D8FAC  stur     q2, [sp, #0x18]
0051D8FB0  bl       #0x7c443cc ; System.ValueType$$Equals
0051D8FB4  ldp      x20, x19, [sp, #0xa0]
0051D8FB8  ldr      x30, [sp, #0x90]
0051D8FBC  and      w0, w0, #1
0051D8FC0  add      sp, sp, #0xb0
0051D8FC4  ret      

; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$GetHashCode
; RVA 0x51D8FC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0051D8FC8  sub      sp, sp, #0x60
0051D8FCC  stp      x30, x19, [sp, #0x50]
0051D8FD0  ldr      x8, [x2, #0x20]
0051D8FD4  mov      x19, x1
0051D8FD8  ldr      x8, [x8, #0xc0]
0051D8FDC  ldr      x0, [x8]
0051D8FE0  ldrb     w8, [x0, #0x135]
0051D8FE4  tbnz     w8, #0, #0x51d8fec
0051D8FE8  bl       #0x3a7e60c ; 
0051D8FEC  mov      x8, #-1
0051D8FF0  stp      x0, x8, [sp, #8]
0051D8FF4  ldr      x8, [x19, #0x30]
0051D8FF8  ldp      q1, q0, [x19, #0x10]
0051D8FFC  ldr      q2, [x19]
0051D9000  add      x0, sp, #8
0051D9004  mov      x1, xzr
0051D9008  str      x8, [sp, #0x48]
0051D900C  stur     q0, [sp, #0x38]
0051D9010  stur     q1, [sp, #0x28]
0051D9014  stur     q2, [sp, #0x18]
0051D9018  bl       #0x7c443d4 ; System.ValueType$$GetHashCode
0051D901C  ldp      x30, x19, [sp, #0x50]
0051D9020  add      sp, sp, #0x60
0051D9024  ret      

; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$IndexOf
; RVA 0x51D9028; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0051D9028  sub      sp, sp, #0xe0
0051D902C  stp      x30, x27, [sp, #0x90]
0051D9030  stp      x26, x25, [sp, #0xa0]
0051D9034  stp      x24, x23, [sp, #0xb0]
0051D9038  stp      x22, x21, [sp, #0xc0]
0051D903C  stp      x20, x19, [sp, #0xd0]
0051D9040  add      w8, w4, w3
0051D9044  cmp      w8, w3
0051D9048  b.le     #0x51d9128
0051D904C  mov      x22, x1
0051D9050  cbz      x1, #0x51d9150
0051D9054  add      x9, sp, #8
0051D9058  mov      w10, #0x38
0051D905C  sxtw     x8, w8
0051D9060  add      x24, x9, #0x10
0051D9064  smaddl   x9, w3, w10, x22
0051D9068  mov      x20, x5
0051D906C  mov      w19, w3
0051D9070  mov      x21, x2
0051D9074  sub      x25, x8, w3, sxtw
0051D9078  add      x26, x9, #0x20
0051D907C  mov      x27, #-1
0051D9080  ldr      w8, [x22, #0x18]
0051D9084  cmp      w19, w8
0051D9088  b.hs     #0x51d914c
0051D908C  ldr      x8, [x21, #0x30]
0051D9090  ldp      q1, q0, [x21, #0x10]
0051D9094  ldr      q2, [x21]
0051D9098  add      x1, sp, #0x50
0051D909C  str      x8, [sp, #0x80]
0051D90A0  stp      q1, q0, [sp, #0x60]
0051D90A4  str      q2, [sp, #0x50]
0051D90A8  ldr      x8, [x20, #0x20]
0051D90AC  ldr      x8, [x8, #0xc0]
0051D90B0  ldr      x0, [x8]
0051D90B4  bl       #0x382be94 ; 
0051D90B8  ldr      x8, [x20, #0x20]
0051D90BC  mov      x23, x0
0051D90C0  ldr      x8, [x8, #0xc0]
0051D90C4  ldr      x8, [x8]
0051D90C8  ldrb     w9, [x8, #0x135]
0051D90CC  tbnz     w9, #0, #0x51d90dc
0051D90D0  mov      x0, x8
0051D90D4  bl       #0x3a7e60c ; 
0051D90D8  mov      x8, x0
0051D90DC  ldr      w9, [x22, #0x18]
0051D90E0  cmp      w19, w9
0051D90E4  b.hs     #0x51d914c
0051D90E8  stp      x8, x27, [sp, #8]
0051D90EC  ldr      x8, [x26, #0x30]
0051D90F0  ldp      q1, q0, [x26, #0x10]
0051D90F4  ldr      q2, [x26]
0051D90F8  add      x0, sp, #8
0051D90FC  mov      x1, x23
0051D9100  mov      x2, xzr
0051D9104  str      x8, [x24, #0x30]
0051D9108  stp      q1, q0, [x24, #0x10]
0051D910C  str      q2, [x24]
0051D9110  bl       #0x7c443cc ; System.ValueType$$Equals
0051D9114  tbnz     w0, #0, #0x51d912c
0051D9118  add      w19, w19, #1
0051D911C  subs     x25, x25, #1
0051D9120  add      x26, x26, #0x38
0051D9124  b.ne     #0x51d9080
0051D9128  mov      w19, #-1
0051D912C  mov      w0, w19
0051D9130  ldp      x20, x19, [sp, #0xd0]
0051D9134  ldp      x22, x21, [sp, #0xc0]
0051D9138  ldp      x24, x23, [sp, #0xb0]
0051D913C  ldp      x26, x25, [sp, #0xa0]
0051D9140  ldp      x30, x27, [sp, #0x90]
0051D9144  add      sp, sp, #0xe0
0051D9148  ret      
0051D914C  bl       #0x382bfc0 ; 
0051D9150  bl       #0x382bfb8 ; 

; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$LastIndexOf
; RVA 0x51D9154; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0051D9154  sub      sp, sp, #0xe0
0051D9158  stp      x30, x27, [sp, #0x90]
0051D915C  stp      x26, x25, [sp, #0xa0]
0051D9160  stp      x24, x23, [sp, #0xb0]
0051D9164  stp      x22, x21, [sp, #0xc0]
0051D9168  stp      x20, x19, [sp, #0xd0]
0051D916C  sub      w8, w3, w4
0051D9170  add      w24, w8, #1
0051D9174  cmp      w24, w3
0051D9178  b.gt     #0x51d924c
0051D917C  mov      x22, x1
0051D9180  cbz      x1, #0x51d9274
0051D9184  add      x8, sp, #8
0051D9188  mov      x20, x5
0051D918C  mov      w19, w3
0051D9190  mov      x21, x2
0051D9194  mov      w25, #0x38
0051D9198  add      x26, x8, #0x10
0051D919C  mov      x27, #-1
0051D91A0  ldr      w8, [x22, #0x18]
0051D91A4  cmp      w19, w8
0051D91A8  b.hs     #0x51d9270
0051D91AC  ldr      x8, [x21, #0x30]
0051D91B0  ldp      q1, q0, [x21, #0x10]
0051D91B4  ldr      q2, [x21]
0051D91B8  add      x1, sp, #0x50
0051D91BC  str      x8, [sp, #0x80]
0051D91C0  stp      q1, q0, [sp, #0x60]
0051D91C4  str      q2, [sp, #0x50]
0051D91C8  ldr      x8, [x20, #0x20]
0051D91CC  ldr      x8, [x8, #0xc0]
0051D91D0  ldr      x0, [x8]
0051D91D4  bl       #0x382be94 ; 
0051D91D8  ldr      x8, [x20, #0x20]
0051D91DC  mov      x23, x0
0051D91E0  ldr      x8, [x8, #0xc0]
0051D91E4  ldr      x8, [x8]
0051D91E8  ldrb     w9, [x8, #0x135]
0051D91EC  tbnz     w9, #0, #0x51d91fc
0051D91F0  mov      x0, x8
0051D91F4  bl       #0x3a7e60c ; 
0051D91F8  mov      x8, x0
0051D91FC  ldr      w9, [x22, #0x18]
0051D9200  cmp      w19, w9
0051D9204  b.hs     #0x51d9270
0051D9208  smaddl   x9, w19, w25, x22
0051D920C  stp      x8, x27, [sp, #8]
0051D9210  add      x8, x9, #0x20
0051D9214  ldr      x9, [x8, #0x30]
0051D9218  ldp      q1, q0, [x8, #0x10]
0051D921C  ldr      q2, [x8]
0051D9220  add      x0, sp, #8
0051D9224  mov      x1, x23
0051D9228  mov      x2, xzr
0051D922C  str      x9, [x26, #0x30]
0051D9230  stp      q1, q0, [x26, #0x10]
0051D9234  str      q2, [x26]
0051D9238  bl       #0x7c443cc ; System.ValueType$$Equals
0051D923C  tbnz     w0, #0, #0x51d9250
0051D9240  sub      w19, w19, #1
0051D9244  cmp      w19, w24
0051D9248  b.ge     #0x51d91a0
0051D924C  mov      w19, #-1
0051D9250  mov      w0, w19
0051D9254  ldp      x20, x19, [sp, #0xd0]
0051D9258  ldp      x22, x21, [sp, #0xc0]
0051D925C  ldp      x24, x23, [sp, #0xb0]
0051D9260  ldp      x26, x25, [sp, #0xa0]
0051D9264  ldp      x30, x27, [sp, #0x90]
0051D9268  add      sp, sp, #0xe0
0051D926C  ret      
0051D9270  bl       #0x382bfc0 ; 
0051D9274  bl       #0x382bfb8 ; 

; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$Equals
; RVA 0x51D9278; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0051D9278  stp      x30, x19, [sp, #-0x10]!
0051D927C  ldr      x8, [x2, #0x20]
0051D9280  mov      x19, x1
0051D9284  ldr      x8, [x8, #0xc0]
0051D9288  ldr      x0, [x8, #0x20]
0051D928C  ldrb     w8, [x0, #0x135]
0051D9290  tbnz     w8, #0, #0x51d9298
0051D9294  bl       #0x3a7e60c ; 
0051D9298  cbz      x19, #0x51d92b0
0051D929C  ldr      x8, [x19]
0051D92A0  ldrb     w9, [x0, #0x130]
0051D92A4  ldrb     w10, [x8, #0x130]
0051D92A8  cmp      w10, w9
0051D92AC  b.hs     #0x51d92b8
0051D92B0  mov      w0, wzr
0051D92B4  b        #0x51d92cc ; 
0051D92B8  ldr      x8, [x8, #0xc8]
0051D92BC  add      x8, x8, x9, lsl #3
0051D92C0  ldur     x8, [x8, #-8]
0051D92C4  cmp      x8, x0
0051D92C8  cset     w0, eq
0051D92CC  ldp      x30, x19, [sp], #0x10
0051D92D0  ret      

; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$GetHashCode
; RVA 0x51D92D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0051D92D4  str      x30, [sp, #-0x10]!
0051D92D8  cbz      x0, #0x51d930c
0051D92DC  mov      x1, xzr
0051D92E0  bl       #0x7c33c40 ; System.Object$$GetType
0051D92E4  cbz      x0, #0x51d930c
0051D92E8  ldr      x8, [x0]
0051D92EC  ldr      x9, [x8, #0x208]
0051D92F0  ldr      x1, [x8, #0x210]
0051D92F4  blr      x9
0051D92F8  cbz      x0, #0x51d930c
0051D92FC  ldr      x8, [x0]
0051D9300  ldp      x2, x1, [x8, #0x158]
0051D9304  ldr      x30, [sp], #0x10
0051D9308  br       x2
0051D930C  bl       #0x382bfb8 ; 

; System.Collections.Generic.ObjectEqualityComparer<WeightRandomData>$$.ctor
; RVA 0x51D9310; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0051D9310  ldr      x8, [x1, #0x20]
0051D9314  ldr      x8, [x8, #0xc0]
0051D9318  ldr      x1, [x8, #0x28]
0051D931C  b        #0x62b2aac ; System.Collections.Generic.EqualityComparer<WeightRandomData>$$.ctor

