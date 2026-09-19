; HotFix.RelivePopupViewModule$$OnOpen
; RVA 0x7602954; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007602954  sub      sp, sp, #0x50
007602958  str      x30, [sp, #0x20]
00760295C  stp      x22, x21, [sp, #0x30]
007602960  stp      x20, x19, [sp, #0x40]
007602964  adrp     x21, #0x95a9000
007602968  adrp     x22, #0x8faa000
00760296C  ldrb     w8, [x21, #0xefb]
007602970  ldr      x22, [x22, #0xb88]
007602974  mov      x20, x1
007602978  mov      x19, x0
00760297C  tbnz     w8, #0, #0x76029dc
007602980  adrp     x0, #0x8f9c000
007602984  ldr      x0, [x0, #0x420]
007602988  bl       #0x382bd14 ; 
00760298C  adrp     x0, #0x8f6e000
007602990  ldr      x0, [x0, #0xe98]
007602994  bl       #0x382bd14 ; 
007602998  adrp     x0, #0x8faa000
00760299C  ldr      x0, [x0, #0xb90]
0076029A0  bl       #0x382bd14 ; 
0076029A4  adrp     x0, #0x8faa000
0076029A8  ldr      x0, [x0, #0xb88]
0076029AC  bl       #0x382bd14 ; 
0076029B0  adrp     x0, #0x8f6b000
0076029B4  ldr      x0, [x0, #0xeb0]
0076029B8  bl       #0x382bd14 ; 
0076029BC  adrp     x0, #0x8f77000
0076029C0  ldr      x0, [x0, #0xd50]
0076029C4  bl       #0x382bd14 ; 
0076029C8  adrp     x0, #0x8faa000
0076029CC  ldr      x0, [x0, #0xb98]
0076029D0  bl       #0x382bd14 ; 
0076029D4  mov      w8, #1
0076029D8  strb     w8, [x21, #0xefb]
0076029DC  ldr      x2, [x22]
0076029E0  ldrb     w8, [x2, #0x53]
0076029E4  tbnz     w8, #5, #0x7602a78
0076029E8  adrp     x8, #0x8f6b000
0076029EC  ldr      x8, [x8, #0xeb0]
0076029F0  ldr      x0, [x8]
0076029F4  bl       #0x54ead0c ; HotFix.Singleton<object>$$get_Instance
0076029F8  cbz      x0, #0x7602ba0
0076029FC  adrp     x8, #0x8faa000
007602A00  ldr      x8, [x8, #0xb98]
007602A04  mov      x2, xzr
007602A08  ldr      x1, [x8]
007602A0C  bl       #0x72794c0 ; HotFix.ADModuleMgr$$TrackAdButtonShow
007602A10  cbz      x20, #0x7602a98
007602A14  adrp     x8, #0x8f6e000
007602A18  ldr      x8, [x8, #0xe98]
007602A1C  ldr      x9, [x20]
007602A20  ldr      x1, [x8]
007602A24  ldrb     w10, [x9, #0x130]
007602A28  ldrb     w8, [x1, #0x130]
007602A2C  cmp      w10, w8
007602A30  b.lo     #0x7602a70
007602A34  ldr      x10, [x9, #0xc8]
007602A38  sub      x9, x8, #1
007602A3C  ldr      x10, [x10, x9, lsl #3]
007602A40  cmp      x10, x1
007602A44  b.ne     #0x7602a70
007602A48  mov      x21, x19
007602A4C  str      x20, [x21, #0x68]!
007602A50  ldr      x10, [x20]
007602A54  ldrb     w11, [x10, #0x130]
007602A58  cmp      w11, w8
007602A5C  b.lo     #0x7602a70
007602A60  ldr      x8, [x10, #0xc8]
007602A64  ldr      x8, [x8, x9, lsl #3]
007602A68  cmp      x8, x1
007602A6C  b.eq     #0x7602aa0
007602A70  mov      x0, x20
007602A74  bl       #0x382c354 ; 
007602A78  ldr      x3, [x2, #0x60]
007602A7C  mov      x0, x19
007602A80  mov      x1, x20
007602A84  ldp      x20, x19, [sp, #0x40]
007602A88  ldp      x22, x21, [sp, #0x30]
007602A8C  ldr      x30, [sp, #0x20]
007602A90  add      sp, sp, #0x50
007602A94  br       x3
007602A98  mov      x21, x19
007602A9C  str      xzr, [x21, #0x68]!
007602AA0  mov      x0, x21
007602AA4  mov      x1, x20
007602AA8  bl       #0x382bcb8 ; 
007602AAC  mov      x8, #0x40a00000
007602AB0  movk     x8, #5, lsl #32
007602AB4  str      x8, [x19, #0x58]
007602AB8  adrp     x8, #0x8f77000
007602ABC  ldr      x8, [x8, #0xd50]
007602AC0  ldr      x20, [x19, #0x38]
007602AC4  ldr      x0, [x8]
007602AC8  ldr      w8, [x0, #0xe0]
007602ACC  cbnz     w8, #0x7602ad4
007602AD0  bl       #0x382be8c ; 
007602AD4  mov      w0, #5
007602AD8  mov      x1, xzr
007602ADC  bl       #0x77fd0dc ; HotFix.UIStringTools$$GetNormalStr
007602AE0  cbz      x20, #0x7602ba0
007602AE4  ldr      x8, [x20]
007602AE8  mov      x1, x0
007602AEC  mov      x0, x20
007602AF0  ldr      x9, [x8, #0x5e8]
007602AF4  ldr      x2, [x8, #0x5f0]
007602AF8  blr      x9
007602AFC  strb     wzr, [x19, #0x60]
007602B00  adrp     x8, #0x8f9c000
007602B04  ldr      x20, [x19, #0x40]
007602B08  ldr      x8, [x8, #0x420]
007602B0C  ldr      x0, [x8]
007602B10  bl       #0x382bfa0 ; 
007602B14  adrp     x8, #0x8faa000
007602B18  ldr      x8, [x8, #0xb90]
007602B1C  mov      x1, x19
007602B20  mov      x3, xzr
007602B24  mov      x22, x0
007602B28  ldr      x2, [x8]
007602B2C  bl       #0x6040bf8 ; System.Action<int, int>$$.ctor
007602B30  cbz      x20, #0x7602ba0
007602B34  mov      w8, #1
007602B38  mov      w1, #5
007602B3C  mov      w2, #0x259
007602B40  mov      x0, x20
007602B44  mov      x3, xzr
007602B48  mov      x4, x22
007602B4C  mov      x5, xzr
007602B50  mov      x6, xzr
007602B54  mov      w7, wzr
007602B58  stp      xzr, xzr, [sp, #0x10]
007602B5C  strb     w8, [sp, #8]
007602B60  strb     wzr, [sp]
007602B64  bl       #0x77eab28 ; HotFix.PurchaseButtonCtrl$$SetData
007602B68  ldr      x0, [x19, #0x50]
007602B6C  cbz      x0, #0x7602ba0
007602B70  mov      x1, xzr
007602B74  bl       #0x874a860 ; UnityEngine.Component$$get_gameObject
007602B78  ldr      x8, [x21]
007602B7C  cbz      x8, #0x7602ba0
007602B80  cbz      x0, #0x7602ba0
007602B84  ldrb     w1, [x8, #0x15]
007602B88  ldp      x20, x19, [sp, #0x40]
007602B8C  ldp      x22, x21, [sp, #0x30]
007602B90  ldr      x30, [sp, #0x20]
007602B94  mov      x2, xzr
007602B98  add      sp, sp, #0x50
007602B9C  b        #0x874e1f4 ; UnityEngine.GameObject$$SetActive
007602BA0  bl       #0x382bfb8 ; 

