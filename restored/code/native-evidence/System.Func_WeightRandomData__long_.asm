; System.Func<WeightRandomData, long>$$.ctor
; RVA 0x48DB704; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB704  str      x30, [sp, #-0x30]!
0048DB708  stp      x22, x21, [sp, #0x10]
0048DB70C  stp      x20, x19, [sp, #0x20]
0048DB710  ldr      x8, [x2, #8]
0048DB714  mov      x19, x0
0048DB718  str      x2, [x0, #0x28]
0048DB71C  mov      x21, x2
0048DB720  str      x8, [x0, #0x10]
0048DB724  str      x1, [x0, #0x20]!
0048DB728  mov      x20, x1
0048DB72C  bl       #0x382bcb8 ; 
0048DB730  ldrb     w22, [x21, #0x52]
0048DB734  mov      x0, x21
0048DB738  str      x19, [x19, #0x40]
0048DB73C  bl       #0x382be14 ; 
0048DB740  tbz      w0, #0, #0x48db75c
0048DB744  cmp      w22, #1
0048DB748  b.ne     #0x48db760
0048DB74C  adrp     x8, #0x3475000
0048DB750  add      x8, x8, #0x224
0048DB754  str      x8, [x19, #0x18]
0048DB758  b        #0x48db770 ; 
0048DB75C  cbz      x20, #0x48db78c
0048DB760  ldr      x8, [x19, #0x10]
0048DB764  ldr      x9, [x19, #0x20]
0048DB768  str      x8, [x19, #0x18]
0048DB76C  str      x9, [x19, #0x40]
0048DB770  adrp     x8, #0x3475000
0048DB774  add      x8, x8, #0x1b4
0048DB778  str      x8, [x19, #0x38]
0048DB77C  ldp      x20, x19, [sp, #0x20]
0048DB780  ldp      x22, x21, [sp, #0x10]
0048DB784  ldr      x30, [sp], #0x30
0048DB788  ret      
0048DB78C  adrp     x1, #0x1a2d000
0048DB790  add      x1, x1, #0x4e9
0048DB794  mov      x0, xzr
0048DB798  bl       #0x382bfd4 ; 
0048DB79C  mov      x1, xzr
0048DB7A0  bl       #0x382be7c ; 

; System.Func<WeightRandomData, long>$$Invoke
; RVA 0x48DB7A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB7A4  sub      sp, sp, #0x50
0048DB7A8  str      x30, [sp, #0x40]
0048DB7AC  ldp      q2, q0, [x1, #0x10]
0048DB7B0  ldr      x10, [x1, #0x30]
0048DB7B4  ldr      q1, [x1]
0048DB7B8  ldr      x9, [x0, #0x18]
0048DB7BC  ldr      x8, [x0, #0x40]
0048DB7C0  str      x10, [sp, #0x30]
0048DB7C4  stp      q2, q0, [sp, #0x10]
0048DB7C8  str      q1, [sp]
0048DB7CC  ldr      x2, [x0, #0x28]
0048DB7D0  mov      x1, sp
0048DB7D4  mov      x0, x8
0048DB7D8  blr      x9
0048DB7DC  ldr      x30, [sp, #0x40]
0048DB7E0  add      sp, sp, #0x50
0048DB7E4  ret      

; System.Func<WeightRandomData, long>$$BeginInvoke
; RVA 0x48DB7E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB7E8  sub      sp, sp, #0x50
0048DB7EC  str      x30, [sp, #0x10]
0048DB7F0  stp      x24, x23, [sp, #0x20]
0048DB7F4  stp      x22, x21, [sp, #0x30]
0048DB7F8  stp      x20, x19, [sp, #0x40]
0048DB7FC  adrp     x24, #0x9591000
0048DB800  adrp     x23, #0x8ee8000
0048DB804  ldrb     w8, [x24, #0xfa8]
0048DB808  ldr      x23, [x23, #0x3d8]
0048DB80C  mov      x19, x3
0048DB810  mov      x20, x2
0048DB814  mov      x22, x1
0048DB818  mov      x21, x0
0048DB81C  tbnz     w8, #0, #0x48db834
0048DB820  adrp     x0, #0x8ee8000
0048DB824  ldr      x0, [x0, #0x3d8]
0048DB828  bl       #0x382bd14 ; 
0048DB82C  mov      w8, #1
0048DB830  strb     w8, [x24, #0xfa8]
0048DB834  ldr      x0, [x23]
0048DB838  mov      x1, x22
0048DB83C  str      xzr, [sp, #8]
0048DB840  bl       #0x382be94 ; 
0048DB844  str      x0, [sp]
0048DB848  mov      x1, sp
0048DB84C  mov      x0, x21
0048DB850  mov      x2, x20
0048DB854  mov      x3, x19
0048DB858  bl       #0x382bcc8 ; 
0048DB85C  ldp      x20, x19, [sp, #0x40]
0048DB860  ldp      x22, x21, [sp, #0x30]
0048DB864  ldp      x24, x23, [sp, #0x20]
0048DB868  ldr      x30, [sp, #0x10]
0048DB86C  add      sp, sp, #0x50
0048DB870  ret      

; System.Func<WeightRandomData, long>$$EndInvoke
; RVA 0x48DB874; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB874  str      x30, [sp, #-0x10]!
0048DB878  mov      x0, x1
0048DB87C  mov      x1, xzr
0048DB880  bl       #0x382bccc ; 
0048DB884  cbz      x0, #0x48db898
0048DB888  bl       #0x382be98 ; 
0048DB88C  ldr      x0, [x0]
0048DB890  ldr      x30, [sp], #0x10
0048DB894  ret      
0048DB898  bl       #0x382bfb8 ; 

