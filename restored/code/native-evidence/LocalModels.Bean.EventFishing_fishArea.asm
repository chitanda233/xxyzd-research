; LocalModels.Bean.EventFishing_fishArea$$readImpl
; RVA 0x6A72710; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A72710  stp      x30, x21, [sp, #-0x20]!
006A72714  stp      x20, x19, [sp, #0x10]
006A72718  adrp     x20, #0x959d000
006A7271C  adrp     x21, #0x8f37000
006A72720  ldrb     w8, [x20, #0xdcf]
006A72724  ldr      x21, [x21, #0x728]
006A72728  mov      x19, x0
006A7272C  tbnz     w8, #0, #0x6a72744
006A72730  adrp     x0, #0x8f37000
006A72734  ldr      x0, [x0, #0x728]
006A72738  bl       #0x382bd14 ; 
006A7273C  mov      w8, #1
006A72740  strb     w8, [x20, #0xdcf]
006A72744  ldr      x1, [x21]
006A72748  ldrb     w8, [x1, #0x53]
006A7274C  tbnz     w8, #5, #0x6a7279c
006A72750  mov      x0, x19
006A72754  mov      x1, xzr
006A72758  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7275C  adrp     x21, #0x959e000
006A72760  ldrb     w8, [x21, #0x467]
006A72764  mov      w20, w0
006A72768  cbnz     w8, #0x6a72780
006A7276C  adrp     x0, #0x8f37000
006A72770  ldr      x0, [x0, #0x700]
006A72774  bl       #0x382bd14 ; 
006A72778  mov      w8, #1
006A7277C  strb     w8, [x21, #0x467]
006A72780  adrp     x8, #0x8f37000
006A72784  ldr      x8, [x8, #0x700]
006A72788  ldr      x2, [x8]
006A7278C  ldrb     w8, [x2, #0x53]
006A72790  tbnz     w8, #5, #0x6a727b0
006A72794  str      w20, [x19, #0x20]
006A72798  b        #0x6a727c0 ; 
006A7279C  ldr      x2, [x1, #0x60]
006A727A0  mov      x0, x19
006A727A4  ldp      x20, x19, [sp, #0x10]
006A727A8  ldp      x30, x21, [sp], #0x20
006A727AC  br       x2
006A727B0  ldr      x8, [x2, #0x60]
006A727B4  mov      x0, x19
006A727B8  mov      w1, w20
006A727BC  blr      x8
006A727C0  mov      x0, x19
006A727C4  mov      x1, xzr
006A727C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A727CC  adrp     x21, #0x959e000
006A727D0  ldrb     w8, [x21, #0x468]
006A727D4  mov      x20, x0
006A727D8  cbnz     w8, #0x6a727f0
006A727DC  adrp     x0, #0x8f37000
006A727E0  ldr      x0, [x0, #0x710]
006A727E4  bl       #0x382bd14 ; 
006A727E8  mov      w8, #1
006A727EC  strb     w8, [x21, #0x468]
006A727F0  adrp     x8, #0x8f37000
006A727F4  ldr      x8, [x8, #0x710]
006A727F8  ldr      x2, [x8]
006A727FC  ldrb     w8, [x2, #0x53]
006A72800  tbnz     w8, #5, #0x6a72818
006A72804  mov      x0, x19
006A72808  str      x20, [x0, #0x28]!
006A7280C  mov      x1, x20
006A72810  bl       #0x382bcb8 ; 
006A72814  b        #0x6a72828 ; 
006A72818  ldr      x8, [x2, #0x60]
006A7281C  mov      x0, x19
006A72820  mov      x1, x20
006A72824  blr      x8
006A72828  mov      x0, x19
006A7282C  mov      x1, xzr
006A72830  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A72834  adrp     x21, #0x959e000
006A72838  ldrb     w8, [x21, #0x469]
006A7283C  mov      x20, x0
006A72840  cbnz     w8, #0x6a72858
006A72844  adrp     x0, #0x8f37000
006A72848  ldr      x0, [x0, #0x720]
006A7284C  bl       #0x382bd14 ; 
006A72850  mov      w8, #1
006A72854  strb     w8, [x21, #0x469]
006A72858  adrp     x8, #0x8f37000
006A7285C  ldr      x8, [x8, #0x720]
006A72860  ldr      x2, [x8]
006A72864  ldrb     w8, [x2, #0x53]
006A72868  tbnz     w8, #5, #0x6a72880
006A7286C  str      x20, [x19, #0x30]!
006A72870  mov      x0, x19
006A72874  mov      x1, x20
006A72878  bl       #0x382bcb8 ; 
006A7287C  b        #0x6a72890 ; 
006A72880  ldr      x8, [x2, #0x60]
006A72884  mov      x0, x19
006A72888  mov      x1, x20
006A7288C  blr      x8
006A72890  ldp      x20, x19, [sp, #0x10]
006A72894  mov      w0, #1
006A72898  ldp      x30, x21, [sp], #0x20
006A7289C  ret      

