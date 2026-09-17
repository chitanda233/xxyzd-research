; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$Dispose
; RVA 0x60A04B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060A04B4  ret      

; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$MoveNext
; RVA 0x60A04B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060A04B8  mov      w0, wzr
0060A04BC  ret      

; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$get_Current
; RVA 0x60A04C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060A04C0  str      x30, [sp, #-0x20]!
0060A04C4  stp      x20, x19, [sp, #0x10]
0060A04C8  adrp     x0, #0x8ec3000
0060A04CC  ldr      x0, [x0, #0x760]
0060A04D0  mov      x19, x1
0060A04D4  bl       #0x382bd28 ; 
0060A04D8  bl       #0x382bfa0 ; 
0060A04DC  mov      x20, x0
0060A04E0  adrp     x0, #0x8ee8000
0060A04E4  ldr      x0, [x0, #0x670]
0060A04E8  bl       #0x382bd28 ; 
0060A04EC  mov      x1, x0
0060A04F0  mov      x0, x20
0060A04F4  mov      x2, xzr
0060A04F8  bl       #0x7bd4cd8 ; System.InvalidOperationException$$.ctor
0060A04FC  mov      x0, x20
0060A0500  mov      x1, x19
0060A0504  bl       #0x382be7c ; 

; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$System.Collections.IEnumerator.get_Current
; RVA 0x60A0508; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060A0508  str      x30, [sp, #-0x10]!
0060A050C  ldr      x8, [x1, #0x20]
0060A0510  ldr      x8, [x8, #0xc0]
0060A0514  ldr      x1, [x8, #8]
0060A0518  bl       #0x60a04c0 ; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$get_Current

; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$System.Collections.IEnumerator.Reset
; RVA 0x60A051C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060A051C  ret      

; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$.ctor
; RVA 0x60A0520; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060A0520  mov      x1, xzr
0060A0524  b        #0x7c335dc ; System.Object$$.ctor

; System.Array.EmptyInternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$.cctor
; RVA 0x60A0528; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0060A0528  str      x30, [sp, #-0x20]!
0060A052C  stp      x20, x19, [sp, #0x10]
0060A0530  mov      x19, x0
0060A0534  ldr      x0, [x0, #0x20]
0060A0538  ldrb     w8, [x0, #0x135]
0060A053C  tbnz     w8, #0, #0x60a0544
0060A0540  bl       #0x3a7e60c ; 
0060A0544  ldr      x8, [x0, #0xc0]
0060A0548  ldr      x0, [x8, #0x10]
0060A054C  ldrb     w8, [x0, #0x135]
0060A0550  tbnz     w8, #0, #0x60a0558
0060A0554  bl       #0x3a7e60c ; 
0060A0558  bl       #0x382bfa0 ; 
0060A055C  ldr      x8, [x19, #0x20]
0060A0560  mov      x20, x0
0060A0564  ldrb     w9, [x8, #0x135]
0060A0568  tbnz     w9, #0, #0x60a0574
0060A056C  mov      x0, x8
0060A0570  bl       #0x3a7e60c ; 
0060A0574  mov      x0, x20
0060A0578  mov      x1, xzr
0060A057C  bl       #0x7c335dc ; System.Object$$.ctor
0060A0580  ldr      x0, [x19, #0x20]
0060A0584  ldrb     w8, [x0, #0x135]
0060A0588  tbnz     w8, #0, #0x60a0590
0060A058C  bl       #0x3a7e60c ; 
0060A0590  ldr      x8, [x0, #0xc0]
0060A0594  ldr      x0, [x8, #0x20]
0060A0598  ldrb     w8, [x0, #0x135]
0060A059C  tbnz     w8, #0, #0x60a05a4
0060A05A0  bl       #0x3a7e60c ; 
0060A05A4  ldr      x8, [x0, #0xb8]
0060A05A8  str      x20, [x8]
0060A05AC  ldr      x0, [x19, #0x20]
0060A05B0  ldrb     w8, [x0, #0x135]
0060A05B4  tbnz     w8, #0, #0x60a05bc
0060A05B8  bl       #0x3a7e60c ; 
0060A05BC  ldr      x8, [x0, #0xc0]
0060A05C0  ldr      x0, [x8, #0x20]
0060A05C4  ldrb     w8, [x0, #0x135]
0060A05C8  tbnz     w8, #0, #0x60a05d0
0060A05CC  bl       #0x3a7e60c ; 
0060A05D0  ldr      x0, [x0, #0xb8]
0060A05D4  mov      x1, x20
0060A05D8  ldp      x20, x19, [sp, #0x10]
0060A05DC  ldr      x30, [sp], #0x20
0060A05E0  b        #0x382bcb8 ; 

