; System.Array.InternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$.ctor
; RVA 0x4A3A8DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A3A8DC  stp      x30, x19, [sp, #-0x10]!
004A3A8E0  mov      x19, x0
004A3A8E4  str      x1, [x0]
004A3A8E8  bl       #0x382bcb8 ; 
004A3A8EC  mov      w8, #-2
004A3A8F0  str      w8, [x19, #8]
004A3A8F4  ldp      x30, x19, [sp], #0x10
004A3A8F8  ret      

; System.Array.InternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$Dispose
; RVA 0x4A3A8FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A3A8FC  ret      

; System.Array.InternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$MoveNext
; RVA 0x4A3A900; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A3A900  stp      x30, x19, [sp, #-0x10]!
004A3A904  mov      x19, x0
004A3A908  ldr      w0, [x0, #8]
004A3A90C  cmn      w0, #2
004A3A910  b.ne     #0x4a3a928
004A3A914  ldr      x0, [x19]
004A3A918  cbz      x0, #0x4a3a94c
004A3A91C  mov      x1, xzr
004A3A920  bl       #0x7bffd60 ; System.Array$$get_Length
004A3A924  str      w0, [x19, #8]
004A3A928  cmn      w0, #1
004A3A92C  b.eq     #0x4a3a940
004A3A930  subs     w8, w0, #1
004A3A934  cset     w0, hs
004A3A938  str      w8, [x19, #8]
004A3A93C  b        #0x4a3a944 ; 
004A3A940  mov      w0, wzr
004A3A944  ldp      x30, x19, [sp], #0x10
004A3A948  ret      
004A3A94C  bl       #0x382bfb8 ; 

; System.Array.InternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$get_Current
; RVA 0x4A3A950; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A3A950  sub      sp, sp, #0xc0
004A3A954  stp      x30, x23, [sp, #0x90]
004A3A958  stp      x22, x21, [sp, #0xa0]
004A3A95C  stp      x20, x19, [sp, #0xb0]
004A3A960  mrs      x23, tpidr_el0
004A3A964  ldr      x9, [x23, #0x28]
004A3A968  mov      x19, x1
004A3A96C  str      x9, [sp, #0x88]
004A3A970  ldr      w9, [x0, #8]
004A3A974  cmn      w9, #1
004A3A978  b.eq     #0x4a3aa10
004A3A97C  cmn      w9, #2
004A3A980  b.eq     #0x4a3aa30
004A3A984  ldr      x21, [x0]
004A3A988  mov      x22, x0
004A3A98C  cbz      x21, #0x4a3aa6c
004A3A990  mov      x0, x21
004A3A994  mov      x1, xzr
004A3A998  mov      x20, x8
004A3A99C  bl       #0x7bffd60 ; System.Array$$get_Length
004A3A9A0  ldr      x8, [x19, #0x20]
004A3A9A4  ldr      w22, [x22, #8]
004A3A9A8  mov      w19, w0
004A3A9AC  ldrb     w9, [x8, #0x135]
004A3A9B0  tbnz     w9, #0, #0x4a3a9c0
004A3A9B4  mov      x0, x8
004A3A9B8  bl       #0x3a7e60c ; 
004A3A9BC  mov      x8, x0
004A3A9C0  ldr      x8, [x8, #0xc0]
004A3A9C4  mov      x0, x21
004A3A9C8  ldr      x2, [x8, #8]
004A3A9CC  mvn      w8, w22
004A3A9D0  add      w1, w19, w8
004A3A9D4  add      x8, sp, #8
004A3A9D8  bl       #0x43dcbb0 ; System.Array$$InternalArray__get_Item<BaseSurvivalBattleManager.CreateMonsterData>
004A3A9DC  add      x1, sp, #8
004A3A9E0  mov      w2, #0x80
004A3A9E4  mov      x0, x20
004A3A9E8  bl       #0x89edad0 ; 
004A3A9EC  ldr      x8, [x23, #0x28]
004A3A9F0  ldr      x9, [sp, #0x88]
004A3A9F4  cmp      x8, x9
004A3A9F8  b.ne     #0x4a3aa70
004A3A9FC  ldp      x20, x19, [sp, #0xb0]
004A3AA00  ldp      x22, x21, [sp, #0xa0]
004A3AA04  ldp      x30, x23, [sp, #0x90]
004A3AA08  add      sp, sp, #0xc0
004A3AA0C  ret      
004A3AA10  adrp     x0, #0x8ec3000
004A3AA14  ldr      x0, [x0, #0x760]
004A3AA18  bl       #0x382bd28 ; 
004A3AA1C  bl       #0x382bfa0 ; 
004A3AA20  mov      x20, x0
004A3AA24  adrp     x0, #0x8ee8000
004A3AA28  ldr      x0, [x0, #0x668]
004A3AA2C  b        #0x4a3aa4c ; 
004A3AA30  adrp     x0, #0x8ec3000
004A3AA34  ldr      x0, [x0, #0x760]
004A3AA38  bl       #0x382bd28 ; 
004A3AA3C  bl       #0x382bfa0 ; 
004A3AA40  mov      x20, x0
004A3AA44  adrp     x0, #0x8ee8000
004A3AA48  ldr      x0, [x0, #0x670]
004A3AA4C  bl       #0x382bd28 ; 
004A3AA50  mov      x1, x0
004A3AA54  mov      x0, x20
004A3AA58  mov      x2, xzr
004A3AA5C  bl       #0x7bd4cd8 ; System.InvalidOperationException$$.ctor
004A3AA60  mov      x0, x20
004A3AA64  mov      x1, x19
004A3AA68  bl       #0x382be7c ; 
004A3AA6C  bl       #0x382bfb8 ; 
004A3AA70  bl       #0x89edb60 ; 

; System.Array.InternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$System.Collections.IEnumerator.Reset
; RVA 0x4A3AA74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A3AA74  mov      w8, #-2
004A3AA78  str      w8, [x0, #8]
004A3AA7C  ret      

; System.Array.InternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$System.Collections.IEnumerator.get_Current
; RVA 0x4A3AA80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004A3AA80  sub      sp, sp, #0x140
004A3AA84  str      x29, [sp, #0x110]
004A3AA88  stp      x30, x21, [sp, #0x120]
004A3AA8C  stp      x20, x19, [sp, #0x130]
004A3AA90  mrs      x21, tpidr_el0
004A3AA94  ldr      x8, [x21, #0x28]
004A3AA98  mov      x19, x1
004A3AA9C  mov      x20, x0
004A3AAA0  str      x8, [sp, #0x108]
004A3AAA4  ldr      x8, [x1, #0x20]
004A3AAA8  ldrb     w9, [x8, #0x135]
004A3AAAC  tbnz     w9, #0, #0x4a3aabc
004A3AAB0  mov      x0, x8
004A3AAB4  bl       #0x3a7e60c ; 
004A3AAB8  mov      x8, x0
004A3AABC  ldr      x8, [x8, #0xc0]
004A3AAC0  mov      x0, x20
004A3AAC4  ldr      x1, [x8, #0x18]
004A3AAC8  add      x8, sp, #0x88
004A3AACC  bl       #0x4a3a950 ; System.Array.InternalEnumerator<BaseSurvivalBattleManager.CreateMonsterData>$$get_Current
004A3AAD0  add      x0, sp, #8
004A3AAD4  add      x1, sp, #0x88
004A3AAD8  mov      w2, #0x80
004A3AADC  bl       #0x89edad0 ; 
004A3AAE0  ldr      x0, [x19, #0x20]
004A3AAE4  ldrb     w8, [x0, #0x135]
004A3AAE8  tbnz     w8, #0, #0x4a3aaf0
004A3AAEC  bl       #0x3a7e60c ; 
004A3AAF0  ldr      x8, [x0, #0xc0]
004A3AAF4  add      x1, sp, #8
004A3AAF8  ldr      x0, [x8, #0x10]
004A3AAFC  bl       #0x382be94 ; 
004A3AB00  ldr      x8, [x21, #0x28]
004A3AB04  ldr      x9, [sp, #0x108]
004A3AB08  cmp      x8, x9
004A3AB0C  b.ne     #0x4a3ab24
004A3AB10  ldp      x20, x19, [sp, #0x130]
004A3AB14  ldp      x30, x21, [sp, #0x120]
004A3AB18  ldr      x29, [sp, #0x110]
004A3AB1C  add      sp, sp, #0x140
004A3AB20  ret      
004A3AB24  bl       #0x89edb60 ; 

